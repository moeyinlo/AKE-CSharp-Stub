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

// Image 116: ACESDK_WIN.dll - Assembly: ACESDK_WIN, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59870-59899
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace AceSdk
{
	public enum AceSdkAccountType : uint // TypeDefIndex: 59872
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

	public enum AceSdkAccountPlatID : uint // TypeDefIndex: 59873
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

	public class AceSdkAccount // TypeDefIndex: 59874
	{
		// Fields
		public const int ACE_SDK_MAX_ACCOUNT_LEN = 65; // Metadata: 0x01FDD33D
		public StringBuilder account_; // 0x10
		public AceSdkAccountType account_type_; // 0x18
		public AceSdkAccountPlatID plat_id_; // 0x1C
		public uint game_id_; // 0x20
		public uint world_id_; // 0x24
	
		// Constructors
		public AceSdkAccount() {} // 0x000000018350B670-0x000000018350B680
	}

	public class AceSdkClient // TypeDefIndex: 59887
	{
		// Fields
		private AceSdkClientObject client_obj_; // 0x10
		[ThreadStatic]
		private byte[] get_packet_buffer_; // 0x58
		[ThreadStatic]
		private byte[] get_light_feature_packet_buffer_; // 0x60
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult InitAceClient5Routine(uint ver, IntPtr opt, out IntPtr client_obj_ptr); // TypeDefIndex: 59875; 0x0000000181035ED0-0x0000000181035EF0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult LogInRoutine(IntPtr handle, string account, uint account_type, uint world_id, string login_ticket); // TypeDefIndex: 59876; 0x000000018101FB20-0x000000018101FB40
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult LogOutRoutine(IntPtr handle); // TypeDefIndex: 59877; 0x000000018102B410-0x000000018102B420
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult DeinitRoutine(IntPtr handle); // TypeDefIndex: 59878; 0x000000018102B410-0x000000018102B420
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult GetPacketRoutine(IntPtr handle, ref AceSdkClientPacket packet); // TypeDefIndex: 59879; 0x0000000181165340-0x0000000181165350
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult OnPacketReceivedRoutine(IntPtr handle, byte[] data, uint len); // TypeDefIndex: 59880; 0x0000000181035ED0-0x0000000181035EF0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult GetLightFeaturePacketRoutine(IntPtr handle, ref AceSdkClientLightFeaturePacket packet); // TypeDefIndex: 59881; 0x0000000181165340-0x0000000181165350
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate AceSdkResult OnLightFeaturePacketReceivedRoutine(IntPtr handle, ref AceSdkClientLightFeature data); // TypeDefIndex: 59882; 0x0000000181165340-0x0000000181165350
	
		private struct AceSdkClientObject // TypeDefIndex: 59883
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
	
		private struct AceSdkClientPacket // TypeDefIndex: 59884
		{
			// Fields
			public byte[] buffer_; // 0x00
			public uint len_; // 0x08
		}
	
		private struct AceSdkClientLightFeaturePacket // TypeDefIndex: 59885
		{
			// Fields
			public byte[] buffer_; // 0x00
			public uint len_; // 0x08
		}
	
		private struct AceSdkClientLightFeature // TypeDefIndex: 59886
		{
			// Fields
			public string name_; // 0x00
			public IntPtr data_; // 0x08
			public uint data_len_; // 0x10
			public uint crc_; // 0x14
		}
	
		// Constructors
		public AceSdkClient() {} // Dummy constructor
		private AceSdkClient(IntPtr client_obj_ptr) {} // 0x00000001842792DC-0x00000001842793D4
	
		// Methods
		public static AceSdkResult ace_sdk_client_init(out AceSdkClient ace_client) {
			ace_client = default;
			return default;
		} // 0x00000001842795D8-0x0000000184279850
		public AceSdkResult ace_sdk_client_deinit() => default; // 0x00000001842793D4-0x0000000184279400
		public AceSdkResult ace_sdk_client_log_in(string account_id, AceSdkAccountType account_type, uint world_id, string login_ticket) => default; // 0x0000000184279850-0x0000000184279898
		public AceSdkResult ace_sdk_client_log_out() => default; // 0x0000000184279898-0x00000001842798C4
		public AceSdkResult ace_sdk_client_get_packet(out byte[] packet) {
			packet = default;
			return default;
		} // 0x00000001842794EC-0x00000001842795D8
		public AceSdkResult ace_sdk_client_on_packet_received(byte[] packet) => default; // 0x00000001842799B0-0x00000001842799EC
		public AceSdkResult ace_sdk_client_get_light_feature_packet(out byte[] packet) {
			packet = default;
			return default;
		} // 0x0000000184279400-0x00000001842794EC
		public AceSdkResult ace_sdk_client_on_light_feature_packet_received(byte[] lf_data, string name, uint crc) => default; // 0x00000001842798C4-0x00000001842799B0
		private static int get_exe_module_path(StringBuilder path, int len) => default; // 0x00000001842799EC-0x0000000184279A6C
		private static string DecryptString(byte[] encrypted, byte key) => default; // 0x0000000184278FE0-0x0000000184279074
		private static extern IntPtr LoadLibrary(string lpLibFileName); // 0x0000000184279264-0x00000001842792DC
		private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName); // 0x00000001842791B8-0x0000000184279264
		private static extern IntPtr GetProcAddressByOrdinal(IntPtr hModule, int nOrdinal); // 0x000000018427913C-0x00000001842791B8
		private static extern uint GetModuleFileName(IntPtr hModule, StringBuilder lpFilename, int nSize); // 0x0000000184279074-0x000000018427913C
	}

	public enum AceSdkResult // TypeDefIndex: 59888
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

	public class AceSdkTool // TypeDefIndex: 59889
	{
		// Constructors
		public AceSdkTool() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static string get_string_from_bytearray_until_zero(byte[] input_bytes) => default; // 0x0000000184279A6C-0x0000000184279AF8
	}
}

namespace Beyond.AceSdk
{
	public class AceSDKInterfaceWin // TypeDefIndex: 59895
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
		public static AceSDKInterfaceWin Instance { get => default; } // 0x0000000184278F50-0x0000000184278FE0 
	
		// Constructors
		public AceSDKInterfaceWin() {} // 0x0000000184278E20-0x0000000184278F50
	
		// Methods
		~AceSDKInterfaceWin() {} // 0x00000001842788FC-0x0000000184278AA4
		public void InitACESDK() {} // 0x0000000184278AA4-0x0000000184278B1C
		public void DeinitACESDK() {} // 0x0000000184278894-0x00000001842788FC
		public void OnApplicationPause(bool pause) {} // 0x0000000183D4E280-0x0000000183D4E290
		public void AceSdkClientLogIn(string account_id, string ticket, uint world_id = 0 /* Metadata: 0x01FDD3D9 */) {} // 0x00000001842786F0-0x0000000184278818
		public void AceSdkClientLogOut() {} // 0x0000000184278818-0x0000000184278894
		public void StartNetThread() {} // 0x0000000184278CF8-0x0000000184278E14
		private void NetworkThread(AceSdkClient ace_client) {} // 0x0000000184278B1C-0x0000000184278C14
		private static void SendPktToGameServer(byte[] pkg) {} // 0x0000000184278C28-0x0000000184278CF8
		public void OnAceSdkPacketReceived(byte[] pkt) {} // 0x0000000184278C14-0x0000000184278C28
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 59890
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 59891
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 59892
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 59893
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 59894
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 59871
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}
