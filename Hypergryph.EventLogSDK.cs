/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using UnityEngine;

// Image 95: Hypergryph.EventLogSDK.dll - Assembly: Hypergryph.EventLogSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60509-60518

namespace Hypergryph.SDK
{
	public class CloudGameUtil // TypeDefIndex: 60510
	{
		// Constructors
		public CloudGameUtil() {} // Dummy constructor
	
		// Methods
		public static bool IsCloudGame() => default; // 0x00000001839805F0-0x00000001839818B0
	}

	public interface IEventLogSDK // TypeDefIndex: 60511
	{
		// Methods
		bool setEnvironment(string env);
		bool enableRealTimeSend(bool enable);
		bool init(string appId, string regionTag);
		bool setGlobalProperties(string appId, string globalProperties);
		bool unsetGlobalProperties(string appId, string propertyKeys);
		void clearGlobalProperties(string appId);
		bool eventTrack(string appId, string name, string properties);
		bool appStartEvent(string appId, string channel1, string channel2, bool beat, string properties);
		void pauseBeat(string appId);
		void resumeBeat(string appId);
		bool userLoginEvent(string appId, string userId, string properties);
		void unsetUser(string appId);
		bool characterLoginEvent(string appId, string characterId, string serverId, string properties);
		void unsetCharacter(string appId);
		string getPresetProperties(string appId);
		void flush(string appId);
		string getStaticPresetProperties(string appId);
		string getDeviceIdProperties(string appId);
		bool setGlobalPropertiesV2(string globalProperties);
		bool unsetGlobalPropertiesV2(string propertyKeys);
		void clearGlobalPropertiesV2();
		bool eventTrackV2(string name, string properties);
		bool appStartEventV2(string channel1, string channel2, bool beat, string properties);
		void pauseBeatV2();
		void resumeBeatV2();
		bool userLoginEventV2(string userId, string properties);
		void unsetUserV2();
		bool characterLoginEventV2(string characterId, string serverId, string properties);
		void unsetCharacterV2();
		string getPresetPropertiesV2();
		void flushV2();
		string getStaticPresetPropertiesV2();
		string getDeviceIdPropertiesV2();
		bool eventTrackV3(string appId, string name, string properties);
	}

	internal static class HGEventLogSDKBridge // TypeDefIndex: 60512
	{
		// Fields
		private static IEventLogSDK s_el; // 0x00
	
		// Properties
		public static IEventLogSDK eventLogSdk { get; } // 0x00000001848B8F40-0x00000001848BA410 
	}

	public class HGEventLogSDKAppInstance : MonoBehaviour // TypeDefIndex: 60513
	{
		// Constructors
		public HGEventLogSDKAppInstance() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public static bool SetEnvironment(string env) => default; // 0x000000018A97E1B4-0x000000018A97E1E0
		public static bool SetGlobalProperties(string globalProperties) => default; // 0x000000018A97E1E0-0x000000018A97E284
		public static bool UnsetGlobalProperties(string propertyKeys) => default; // 0x000000018A97E308-0x000000018A97E3AC
		public static void ClearGlobalProperties() {} // 0x000000018A97DEF4-0x000000018A97DF78
		public static bool EventTrack(string name, string properties) => default; // 0x00000001848B8F00-0x00000001848B8F40
		public static bool AppStartEvent(string channel1, string channel2, bool beat, string properties) => default; // 0x000000018A97DE48-0x000000018A97DEA8
		public static bool UserLoginEvent(string userId, string properties) => default; // 0x000000018A97E430-0x000000018A97E46C
		public static void UnsetUser() {} // 0x000000018A97E3AC-0x000000018A97E430
		public static bool CharacterLoginEvent(string characterId, string serverId, string properties) => default; // 0x000000018A97DEA8-0x000000018A97DEF4
		public static void UnsetCharacter() {} // 0x000000018A97E284-0x000000018A97E308
		public static string GetPresetProperties() => default; // 0x00000001848BA570-0x00000001848BA8D0
		public static void PauseBeat() {} // 0x000000018A97E16C-0x000000018A97E190
		public static void ResumeBeat() {} // 0x000000018A97E190-0x000000018A97E1B4
		public static void Flush() {} // 0x000000018A97DFA4-0x000000018A97E028
		public static bool EnableRealTimeSend(bool enable) => default; // 0x000000018A97DF78-0x000000018A97DFA4
		public static string GetStaticPresetProperties() => default; // 0x000000018A97E0AC-0x000000018A97E130
		public static string GetDeviceIdProperties() => default; // 0x000000018A97E028-0x000000018A97E0AC
		private void OnApplicationPause(bool pause) {} // 0x000000018A97E130-0x000000018A97E16C
	}

	public class HGEventLogSDKInstance // TypeDefIndex: 60514
	{
		// Constructors
		public HGEventLogSDKInstance() {} // Dummy constructor
	
		// Methods
		public static bool init(string appId, string region) => default; // 0x0000000185C1E370-0x0000000185C1E710
		public static bool EventTrackWithAppId(string appId, string name, string properties) => default; // 0x000000018A97E46C-0x000000018A97E4B8
	}

	public class HGEventLogSDKMgr : MonoBehaviour // TypeDefIndex: 60515
	{
		// Fields
		private static string appIdForInstance; // 0x00
	
		// Constructors
		public HGEventLogSDKMgr() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public static bool SetEnvironment(string env) => default; // 0x000000018A97ECB8-0x000000018A97ED1C
		public static bool Init(string appId, string regionTag) => default; // 0x000000018A97EAB4-0x000000018A97EB50
		public static bool SetGlobalProperties(string globalProperties) => default; // 0x000000018A97ED1C-0x000000018A97ED90
		public static bool UnsetGlobalProperties(string propertyKeys) => default; // 0x000000018A97EE68-0x000000018A97EEDC
		public static void ClearGlobalProperties() {} // 0x000000018A97E5F0-0x000000018A97E6C8
		public static bool EventTrack(string name, string properties) => default; // 0x000000018A97E6C8-0x000000018A97E748
		public static bool AppStartEvent(string channel1, string channel2, bool beat, string properties) => default; // 0x000000018A97E4B8-0x000000018A97E55C
		public static bool UserLoginEvent(string userId, string properties) => default; // 0x000000018A97EFB4-0x000000018A97F034
		public static void UnsetUser() {} // 0x000000018A97EEDC-0x000000018A97EFB4
		public static bool CharacterLoginEvent(string characterId, string serverId, string properties) => default; // 0x000000018A97E55C-0x000000018A97E5F0
		public static void UnsetCharacter() {} // 0x000000018A97ED90-0x000000018A97EE68
		public static string GetPresetProperties() => default; // 0x000000018A97E8FC-0x000000018A97E9D8
		public static void PauseBeat() {} // 0x000000018A97EBF0-0x000000018A97EC54
		public static void ResumeBeat() {} // 0x000000018A97EC54-0x000000018A97ECB8
		public static void Flush() {} // 0x000000018A97E748-0x000000018A97E820
		public static bool EnableRealTimeSend(bool enable) => default; // 0x000000018A97DF78-0x000000018A97DFA4
		public static string GetStaticPresetProperties() => default; // 0x000000018A97E9D8-0x000000018A97EAB4
		public static string GetDeviceIdProperties() => default; // 0x000000018A97E820-0x000000018A97E8FC
		private void OnApplicationPause(bool pause) {} // 0x000000018A97EB50-0x000000018A97EBF0
	}

	public class HGEventLogSDKPluginCloud : IEventLogSDK // TypeDefIndex: 60516
	{
		// Fields
		private object _cloudClientBridgeInstance; // 0x10
		private MethodInfo _sendDataWithKeyMethod; // 0x18
	
		// Constructors
		public HGEventLogSDKPluginCloud() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static extern bool EventLogInitInstance(string appId, string regionTag); // 0x0000000183981B80-0x0000000183981D80
		private static extern bool EventLogEvent(string appId, string name, string properties); // 0x00000001839818B0-0x0000000183981B80
		private void SendDataWithKey(string key, string data, Action<string> callback) {} // 0x0000000183981D80-0x00000001839839F0
		public bool appStartEvent(string appId, string channel1, string channel2, bool beat, string properties) => default; // 0x0000000183985FB0-0x0000000183986B20
		public bool appStartEventV2(string channel1, string channel2, bool beat, string properties) => default; // 0x00000001839839F0-0x0000000183985FB0
		public bool characterLoginEvent(string appId, string characterId, string serverId, string properties) => default; // 0x0000000183988F80-0x0000000183989AF0
		public bool characterLoginEventV2(string characterId, string serverId, string properties) => default; // 0x0000000183986B20-0x0000000183988F80
		public void clearGlobalProperties(string appId) {} // 0x000000018398B610-0x000000018398C180
		public void clearGlobalPropertiesV2() {} // 0x0000000183989AF0-0x000000018398B610
		public bool enableRealTimeSend(bool enable) => default; // 0x000000018398C180-0x000000018398E030
		public bool eventTrack(string appId, string name, string properties) => default; // 0x0000000183990B30-0x00000001839917C0
		public bool eventTrackV2(string name, string properties) => default; // 0x000000018398E030-0x000000018398FF90
		public bool eventTrackV3(string appId, string name, string properties) => default; // 0x000000018398FF90-0x0000000183990B30
		public void flush(string appId) {} // 0x00000001839932E0-0x0000000183993E50
		public void flushV2() {} // 0x00000001839917C0-0x00000001839932E0
		public string getDeviceIdProperties(string appId) => default; // 0x0000000183994C60-0x0000000183995A70
		public string getDeviceIdPropertiesV2() => default; // 0x0000000183993E50-0x0000000183994C60
		public string getPresetProperties(string appId) => default; // 0x0000000183996880-0x0000000183997690
		public string getPresetPropertiesV2() => default; // 0x0000000183995A70-0x0000000183996880
		public string getStaticPresetProperties(string appId) => default; // 0x00000001839984A0-0x00000001839992B0
		public string getStaticPresetPropertiesV2() => default; // 0x0000000183997690-0x00000001839984A0
		public bool init(string appId, string regionTag) => default; // 0x00000001839992B0-0x0000000183999F40
		public void pauseBeat(string appId) {} // 0x000000018399BA60-0x000000018399C5D0
		public void pauseBeatV2() {} // 0x0000000183999F40-0x000000018399BA60
		public void resumeBeat(string appId) {} // 0x000000018399E0F0-0x000000018399EC60
		public void resumeBeatV2() {} // 0x000000018399C5D0-0x000000018399E0F0
		public bool setEnvironment(string env) => default; // 0x000000018399EC60-0x00000001839A0940
		public bool setGlobalProperties(string appId, string globalProperties) => default; // 0x00000001839A2620-0x00000001839A3190
		public bool setGlobalPropertiesV2(string globalProperties) => default; // 0x00000001839A0940-0x00000001839A2620
		public void unsetCharacter(string appId) {} // 0x00000001839A4CB0-0x00000001839A5820
		public void unsetCharacterV2() {} // 0x00000001839A3190-0x00000001839A4CB0
		public bool unsetGlobalProperties(string appId, string propertyKeys) => default; // 0x00000001839A7500-0x00000001839A8070
		public bool unsetGlobalPropertiesV2(string propertyKeys) => default; // 0x00000001839A5820-0x00000001839A7500
		public void unsetUser(string appId) {} // 0x00000001839A9B90-0x00000001839AA700
		public void unsetUserV2() {} // 0x00000001839A8070-0x00000001839A9B90
		public bool userLoginEvent(string appId, string userId, string properties) => default; // 0x00000001839AC660-0x00000001839AD1D0
		public bool userLoginEventV2(string userId, string properties) => default; // 0x00000001839AA700-0x00000001839AC660
	}

	public class HGEventLogSDKPluginWindows : IEventLogSDK // TypeDefIndex: 60517
	{
		// Constructors
		public HGEventLogSDKPluginWindows() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static extern bool EventLogSetEnvironment(string env); // 0x000000018A97FA98-0x000000018A97FAF4
		private static extern bool EventLogInitInstance(string appId, string regionTag); // 0x0000000185C1E740-0x0000000185C1E7D0
		private static extern bool EventLogSetGlobalProperties(string appId, string globalProperties); // 0x000000018A97FB50-0x000000018A97FC10
		private static extern bool EventLogUnsetGlobalProperties(string appId, string propertyKeys); // 0x000000018A97FD3C-0x000000018A97FDFC
		private static extern bool EventLogClearGlobalProperties(string appId); // 0x000000018A97F5DC-0x000000018A97F638
		private static extern bool EventLogEvent(string appId, string name, string properties); // 0x000000018A97F6B0-0x000000018A97F74C
		private static extern bool EventLogAppStartEvent(string appId, string channel1, string channel2, bool beat, string properties); // 0x000000018A97F128-0x000000018A97F238
		private static extern bool EventLogBeatPause(string appId); // 0x000000018A97F264-0x000000018A97F2C0
		private static extern bool EventLogBeatResume(string appId); // 0x000000018A97F328-0x000000018A97F3C4
		private static extern bool EventLogUserLoginEvent(string appId, string userId, string properties); // 0x000000018A97FF0C-0x000000018A97FFEC
		private static extern bool EventLogUnsetUser(string appId); // 0x000000018A97FE28-0x000000018A97FE84
		private static extern bool EventLogCharacterLoginEvent(string appId, string characterId, string serverId, string properties); // 0x000000018A97F4A4-0x000000018A97F5A8
		private static extern bool EventLogUnsetCharacter(string appId); // 0x000000018A97FC44-0x000000018A97FCA0
		private static extern IntPtr EventLogGetPresetProperties(string appId); // 0x000000018A97F934-0x000000018A97F9CC
		private static extern IntPtr EventLogGetStaticPresetProperties(string appId); // 0x000000018A97FA00-0x000000018A97FA98
		private static extern IntPtr EventLogGetDeviceIdProperties(string appId); // 0x000000018A97F89C-0x000000018A97F934
		private static extern bool EventLogEnableRealTimeSend(bool enable); // 0x000000018A97F638-0x000000018A97F6B0
		private static extern void EventLogFlush(string appId); // 0x000000018A97F7B4-0x000000018A97F834
		private static extern bool EventLogFree(IntPtr buf); // 0x0000000185C52630-0x0000000185C526B0
		private static extern bool EventLogUnsetGlobalPropertiesV2(string property_keys); // 0x000000018A97FCA0-0x000000018A97FD3C
		private static extern bool EventLogSetGlobalPropertiesV2(string global_properties); // 0x000000018A97FAF4-0x000000018A97FB50
		private static extern void EventLogClearGlobalPropertiesV2(); // 0x000000018A97F5A8-0x000000018A97F5DC
		private static extern bool EventLogEventV2(string name, string json_str); // 0x00000001844CE170-0x00000001844CE200
		private static extern bool EventLogAppStartEventV2(string channel1, string channel2, bool beat, string json_str); // 0x000000018A97F034-0x000000018A97F128
		private static extern void EventLogBeatPauseV2(); // 0x000000018A97F238-0x000000018A97F264
		private static extern void EventLogBeatResumeV2(); // 0x000000018A97F2C0-0x000000018A97F328
		private static extern bool EventLogUserLoginEventV2(string user_id, string json_str); // 0x000000018A97FE84-0x000000018A97FF0C
		private static extern void EventLogUnsetUserV2(); // 0x000000018A97FDFC-0x000000018A97FE28
		private static extern bool EventLogCharacterLoginEventV2(string character_id, string server_id, string json_str); // 0x000000018A97F3C4-0x000000018A97F4A4
		private static extern void EventLogUnsetCharacterV2(); // 0x000000018A97FC10-0x000000018A97FC44
		private static extern IntPtr EventLogGetPresetPropertiesV2(); // 0x00000001848BA8D0-0x00000001848BA900
		private static extern IntPtr EventLogGetStaticPresetPropertiesV2(); // 0x000000018A97F9CC-0x000000018A97FA00
		private static extern IntPtr EventLogGetDeviceIdPropertiesV2(); // 0x000000018A97F834-0x000000018A97F89C
		private static extern void EventLogFlushV2(); // 0x000000018A97F74C-0x000000018A97F7B4
		public bool setEnvironment(string env) => default; // 0x000000018A980948-0x000000018A9809C4
		public bool init(string appId, string regionTag) => default; // 0x0000000185C1E710-0x0000000185C1E740
		public bool setGlobalProperties(string appId, string globalProperties) => default; // 0x000000018A9809D0-0x000000018A980A54
		public bool unsetGlobalProperties(string appId, string propertyKeys) => default; // 0x000000018A980AE4-0x000000018A980B68
		public void clearGlobalProperties(string appId) {} // 0x000000018A980174-0x000000018A9801F0
		public bool eventTrack(string appId, string name, string properties) => default; // 0x000000018A98027C-0x000000018A980308
		public bool appStartEvent(string appId, string channel1, string channel2, bool beat, string properties) => default; // 0x000000018A98001C-0x000000018A9800BC
		public void pauseBeat(string appId) {} // 0x000000018A980848-0x000000018A9808C4
		public void resumeBeat(string appId) {} // 0x000000018A9808CC-0x000000018A980948
		public bool userLoginEvent(string appId, string userId, string properties) => default; // 0x000000018A980C00-0x000000018A980CF8
		public void unsetUser(string appId) {} // 0x000000018A980B70-0x000000018A980BEC
		public bool characterLoginEvent(string appId, string characterId, string serverId, string properties) => default; // 0x000000018A9800D4-0x000000018A98016C
		public void unsetCharacter(string appId) {} // 0x000000018A980A5C-0x000000018A980AD8
		public string getPresetProperties(string appId) => default; // 0x000000018A98056C-0x000000018A980660
		public string getStaticPresetProperties(string appId) => default; // 0x000000018A98074C-0x000000018A980840
		public string getDeviceIdProperties(string appId) => default; // 0x000000018A980478-0x000000018A98056C
		public void flush(string appId) {} // 0x000000018A980310-0x000000018A98038C
		public bool enableRealTimeSend(bool enable) => default; // 0x000000018A9801F0-0x000000018A98026C
		public bool setGlobalPropertiesV2(string globalProperties) => default; // 0x000000018A9809C4-0x000000018A9809D0
		public bool unsetGlobalPropertiesV2(string propertyKeys) => default; // 0x000000018A980AD8-0x000000018A980AE4
		public void clearGlobalPropertiesV2() {} // 0x000000018A98016C-0x000000018A980174
		public bool eventTrackV2(string name, string properties) => default; // 0x0000000186470CC0-0x0000000186470CD4
		public bool appStartEventV2(string channel1, string channel2, bool beat, string properties) => default; // 0x000000018A97FFEC-0x000000018A98001C
		public void pauseBeatV2() {} // 0x000000018A980840-0x000000018A980848
		public void resumeBeatV2() {} // 0x000000018A9808C4-0x000000018A9808CC
		public bool userLoginEventV2(string userId, string properties) => default; // 0x000000018A980BEC-0x000000018A980C00
		public void unsetUserV2() {} // 0x000000018A980B68-0x000000018A980B70
		public bool characterLoginEventV2(string characterId, string serverId, string properties) => default; // 0x000000018A9800BC-0x000000018A9800D4
		public void unsetCharacterV2() {} // 0x000000018A980A54-0x000000018A980A5C
		public string getPresetPropertiesV2() => default; // 0x00000001848BA900-0x00000001848BA990
		public void flushV2() {} // 0x000000018A980308-0x000000018A980310
		public string getStaticPresetPropertiesV2() => default; // 0x000000018A980660-0x000000018A98074C
		public string getDeviceIdPropertiesV2() => default; // 0x000000018A98038C-0x000000018A980478
		public bool eventTrackV3(string appId, string name, string properties) => default; // 0x000000018A98026C-0x000000018A98027C
	}

	public static class HGEventLogSDKVersion // TypeDefIndex: 60518
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static HGEventLogSDKVersion() {} // 0x00000001839AD1D0-0x00000001839AE4A0
	}
}
