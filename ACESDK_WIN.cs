/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using AceSdk;

// Image 120: ACESDK_WIN.dll - Assembly: ACESDK_WIN, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60991-61020

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 61020
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_33 _069D1FC04DF5D3A97841869D60961B287D2BF035BAE96ED2B8B31CDC3A9084AF; // 0x00 // Static value (base64): 9vbrxN7D6cLPy97v0trP2N729uvp74foy9nPnJ6EzsbG - Metadata: 0x02082D34
	internal static readonly __StaticArrayInitTypeSize_14 A79B64018AA2094EC519F1C00795ED3CD8C3F6B942D7CA802FF2B45B51A55B9C; // 0x21 // Static value (base64): 48TD3uvJz+nGw8/E3p8= - Metadata: 0x02082D5C
	internal static readonly __StaticArrayInitTypeSize_38 EF03B53ABC241FB166156A9BAB8EB62CCE1FD43274D0BAF46A38C9FED67CCB00; // 0x2F // Static value (base64): 9vbrxN7D6cLPy97v0trP2N729tKSnPb26+nvh+jL2c+ZmITOxsY= - Metadata: 0x02082D6C

	// Nested types
	private struct __StaticArrayInitTypeSize_14 // TypeDefIndex: 61017
	{
	}

	private struct __StaticArrayInitTypeSize_33 // TypeDefIndex: 61018
	{
	}

	private struct __StaticArrayInitTypeSize_38 // TypeDefIndex: 61019
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace AceSdk
{
	public enum AceSdkAccountType : uint // TypeDefIndex: 60993
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

	public enum AceSdkAccountPlatID : uint // TypeDefIndex: 60994
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

	public class AceSdkAccount // TypeDefIndex: 60995
	{
		// Fields
		public const int ACE_SDK_MAX_ACCOUNT_LEN = 65; // Metadata: 0x02082C92
		public StringBuilder account_; // 0x10
		public AceSdkAccountType account_type_; // 0x18
		public AceSdkAccountPlatID plat_id_; // 0x1C
		public uint game_id_; // 0x20
		public uint world_id_; // 0x24
	
		// Constructors
		public AceSdkAccount() {} // 0x0000000185492010-0x0000000185492020
	}

	public class AceSdkClient // TypeDefIndex: 61008
	{
		// Fields
		private AceSdkClientObject client_obj_; // 0x10
		private byte[] get_packet_buffer_; // 0x58
		private byte[] get_light_feature_packet_buffer_; // 0x60
	
		// Nested types
		private delegate AceSdkResult InitAceClient5Routine(uint ver, IntPtr opt, out IntPtr client_obj_ptr); // TypeDefIndex: 60996; 0x00000001864776B8-0x00000001864776E4
	
		private delegate AceSdkResult LogInRoutine(IntPtr handle, string account, uint account_type, uint world_id, string login_ticket); // TypeDefIndex: 60997; 0x0000000186477C94-0x0000000186477CD0
	
		private delegate AceSdkResult LogOutRoutine(IntPtr handle); // TypeDefIndex: 60998; 0x0000000186477CD0-0x0000000186477D50
	
		private delegate AceSdkResult DeinitRoutine(IntPtr handle); // TypeDefIndex: 60999; 0x0000000186477420-0x000000018647749C
	
		private delegate AceSdkResult GetPacketRoutine(IntPtr handle, ref AceSdkClientPacket packet); // TypeDefIndex: 61000; 0x0000000186478278-0x0000000186478324
	
		private delegate AceSdkResult OnPacketReceivedRoutine(IntPtr handle, byte[] data, uint len); // TypeDefIndex: 61001; 0x00000001864783EC-0x00000001864784A8
	
		private delegate AceSdkResult GetLightFeaturePacketRoutine(IntPtr handle, ref AceSdkClientLightFeaturePacket packet); // TypeDefIndex: 61002; 0x0000000186478570-0x00000001864785E8
	
		private delegate AceSdkResult OnLightFeaturePacketReceivedRoutine(IntPtr handle, ref AceSdkClientLightFeature data); // TypeDefIndex: 61003; 0x0000000186477DDC-0x0000000186477E54
	
		private struct AceSdkClientObject // TypeDefIndex: 61004
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
	
		private struct AceSdkClientPacket // TypeDefIndex: 61005
		{
			// Fields
			public byte[] buffer_; // 0x00
			public uint len_; // 0x08
		}
	
		private struct AceSdkClientLightFeaturePacket // TypeDefIndex: 61006
		{
			// Fields
			public byte[] buffer_; // 0x00
			public uint len_; // 0x08
		}
	
		private struct AceSdkClientLightFeature // TypeDefIndex: 61007
		{
			// Fields
			public string name_; // 0x00
			public IntPtr data_; // 0x08
			public uint data_len_; // 0x10
			public uint crc_; // 0x14
		}
	
		// Constructors
		public AceSdkClient() {} // Dummy constructor
		private AceSdkClient(IntPtr client_obj_ptr) {} // 0x0000000181B59400-0x0000000181B59410
	
		// Methods
		public static AceSdkResult ace_sdk_client_init(out AceSdkClient ace_client) {
			ace_client = default;
			return default;
		} // 0x0000000181B59400-0x0000000181B59410
		public AceSdkResult ace_sdk_client_deinit() => default; // 0x00000001864781DC-0x0000000186478278
		public AceSdkResult ace_sdk_client_log_in(string account_id, AceSdkAccountType account_type, uint world_id, string login_ticket) => default; // 0x00000001864780E8-0x0000000186478114
		public AceSdkResult ace_sdk_client_log_out() => default; // 0x0000000186478720-0x00000001864787E8
		public AceSdkResult ace_sdk_client_get_packet(out byte[] packet) {
			packet = default;
			return default;
		} // 0x00000001817E31E0-0x00000001817E3200
		public AceSdkResult ace_sdk_client_on_packet_received(byte[] packet) => default; // 0x0000000186478684-0x0000000186478720
		public AceSdkResult ace_sdk_client_get_light_feature_packet(out byte[] packet) {
			packet = default;
			return default;
		} // 0x0000000186477E54-0x0000000186477F84
		public AceSdkResult ace_sdk_client_on_light_feature_packet_received(byte[] lf_data, string name, uint crc) => default; // 0x0000000186478114-0x00000001864781DC
		private static int get_exe_module_path(StringBuilder path, int len) => default; // 0x000000018647804C-0x00000001864780E8
		private static string DecryptString(byte[] encrypted, byte key) => default; // 0x00000001864780E8-0x0000000186478114
		private static extern IntPtr LoadLibrary(string lpLibFileName); // 0x0000000186478114-0x00000001864781DC
		private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName); // 0x0000000181B59400-0x0000000181B59410
		private static extern IntPtr GetProcAddressByOrdinal(IntPtr hModule, int nOrdinal); // 0x00000001864785E8-0x0000000186478684
		private static extern uint GetModuleFileName(IntPtr hModule, StringBuilder lpFilename, int nSize); // 0x00000001864780E8-0x0000000186478114
	}

	public enum AceSdkResult // TypeDefIndex: 61009
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

	public class AceSdkTool // TypeDefIndex: 61010
	{
		// Constructors
		public AceSdkTool() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static string get_string_from_bytearray_until_zero(byte[] input_bytes) => default; // 0x0000000186477D50-0x0000000186477DDC
	}
}

namespace Beyond.AceSdk
{
	public class AceSDKInterfaceWin // TypeDefIndex: 61016
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
		public static AceSDKInterfaceWin Instance { get => default; } // 0x0000000186477234-0x00000001864772C4 
	
		// Constructors
		public AceSDKInterfaceWin() {} // 0x0000000186477104-0x0000000186477234
	
		// Methods
		~AceSDKInterfaceWin() {} // 0x0000000186476BE0-0x0000000186476D88
		public void InitACESDK() {} // 0x0000000186476D88-0x0000000186476E00
		public void DeinitACESDK() {} // 0x0000000186476B78-0x0000000186476BE0
		public void OnApplicationPause(bool pause) {} // 0x0000000185FAFE20-0x0000000185FAFE30
		public void AceSdkClientLogIn(string account_id, string ticket, uint world_id = 0 /* Metadata: 0x02082D2E */) {} // 0x00000001864769D4-0x0000000186476AFC
		public void AceSdkClientLogOut() {} // 0x0000000186476AFC-0x0000000186476B78
		public void StartNetThread() {} // 0x0000000186476FDC-0x00000001864770F8
		private void NetworkThread(AceSdkClient ace_client) {} // 0x0000000186476E00-0x0000000186476EF8
		private static void SendPktToGameServer(byte[] pkg) {} // 0x0000000186476F0C-0x0000000186476FDC
		public void OnAceSdkPacketReceived(byte[] pkt) {} // 0x0000000186476EF8-0x0000000186476F0C
		private void _StartNetThread_b__16_0() {} // 0x00000001864770F8-0x0000000186477104
	}
}

namespace Beyond.SourceGenerator
{
	internal class DataNAttribute : Attribute // TypeDefIndex: 61011
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 61012
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 61013
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 61014
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 61015
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 60992
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
