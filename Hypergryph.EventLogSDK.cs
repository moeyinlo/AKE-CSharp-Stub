/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 101: Hypergryph.EventLogSDK.dll - Assembly: Hypergryph.EventLogSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90608-90617

namespace Hypergryph.SDK
{
	public class CloudGameUtil // TypeDefIndex: 90609
	{
		// Methods
		public static bool IsCloudGame(); // 0x0000000186144200-0x0000000186144370
	}

	public interface IEventLogSDK // TypeDefIndex: 90610
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

	internal static class HGEventLogSDKBridge // TypeDefIndex: 90611
	{
		// Fields
		private static IEventLogSDK s_el; // 0x00
	
		// Properties
		public static IEventLogSDK eventLogSdk { get; } // 0x0000000185ED4F00-0x0000000185ED4FF0 
	}

	public class HGEventLogSDKAppInstance : MonoBehaviour // TypeDefIndex: 90612
	{
		// Constructors
		public HGEventLogSDKAppInstance(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public static bool SetEnvironment(string env); // 0x000000018C2244E4-0x000000018C224510
		public static bool SetGlobalProperties(string globalProperties); // 0x000000018C224510-0x000000018C224580
		public static bool UnsetGlobalProperties(string propertyKeys); // 0x000000018C2245E0-0x000000018C224650
		public static void ClearGlobalProperties(); // 0x000000018C2242AC-0x000000018C22430C
		public static bool EventTrack(string name, string properties); // 0x0000000185ED4EA0-0x0000000185ED4F00
		public static bool AppStartEvent(string channel1, string channel2, bool beat, string properties); // 0x000000018C22414C-0x000000018C224208
		public static bool UserLoginEvent(string userId, string properties); // 0x000000018C2246B0-0x000000018C224734
		public static void UnsetUser(); // 0x000000018C224650-0x000000018C2246B0
		public static bool CharacterLoginEvent(string characterId, string serverId, string properties); // 0x000000018C224208-0x000000018C2242AC
		public static void UnsetCharacter(); // 0x000000018C224580-0x000000018C2245E0
		public static string GetPresetProperties(); // 0x0000000185ED4CE0-0x0000000185ED4D30
		public static void PauseBeat(); // 0x000000018C22449C-0x000000018C2244C0
		public static void ResumeBeat(); // 0x000000018C2244C0-0x000000018C2244E4
		public static void Flush(); // 0x000000018C224338-0x000000018C224398
		public static bool EnableRealTimeSend(bool enable); // 0x000000018C22430C-0x000000018C224338
		public static string GetStaticPresetProperties(); // 0x000000018C2243FC-0x000000018C224460
		public static string GetDeviceIdProperties(); // 0x000000018C224398-0x000000018C2243FC
		private void OnApplicationPause(bool pause); // 0x000000018C224460-0x000000018C22449C
	}

	public class HGEventLogSDKInstance // TypeDefIndex: 90613
	{
		// Methods
		public static bool init(string appId, string region); // 0x0000000185ED4AF0-0x0000000185ED4B30
		public static bool EventTrackWithAppId(string appId, string name, string properties); // 0x000000018C224734-0x000000018C2247D8
	}

	public class HGEventLogSDKMgr : MonoBehaviour // TypeDefIndex: 90614
	{
		// Fields
		private static string appIdForInstance; // 0x00
	
		// Constructors
		public HGEventLogSDKMgr(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public static bool SetEnvironment(string env); // 0x000000018C225030-0x000000018C225094
		public static bool Init(string appId, string regionTag); // 0x000000018C224E2C-0x000000018C224EC8
		public static bool SetGlobalProperties(string globalProperties); // 0x000000018C225094-0x000000018C22515C
		public static bool UnsetGlobalProperties(string propertyKeys); // 0x000000018C225208-0x000000018C2252D0
		public static void ClearGlobalProperties(); // 0x000000018C2249E4-0x000000018C224A90
		public static bool EventTrack(string name, string properties); // 0x000000018C224A90-0x000000018C224B70
		public static bool AppStartEvent(string channel1, string channel2, bool beat, string properties); // 0x000000018C2247D8-0x000000018C2248EC
		public static bool UserLoginEvent(string userId, string properties); // 0x000000018C22537C-0x000000018C22545C
		public static void UnsetUser(); // 0x000000018C2252D0-0x000000018C22537C
		public static bool CharacterLoginEvent(string characterId, string serverId, string properties); // 0x000000018C2248EC-0x000000018C2249E4
		public static void UnsetCharacter(); // 0x000000018C22515C-0x000000018C225208
		public static string GetPresetProperties(); // 0x000000018C224CCC-0x000000018C224D7C
		public static void PauseBeat(); // 0x000000018C224F68-0x000000018C224FCC
		public static void ResumeBeat(); // 0x000000018C224FCC-0x000000018C225030
		public static void Flush(); // 0x000000018C224B70-0x000000018C224C1C
		public static bool EnableRealTimeSend(bool enable); // 0x000000018C22430C-0x000000018C224338
		public static string GetStaticPresetProperties(); // 0x000000018C224D7C-0x000000018C224E2C
		public static string GetDeviceIdProperties(); // 0x000000018C224C1C-0x000000018C224CCC
		private void OnApplicationPause(bool pause); // 0x000000018C224EC8-0x000000018C224F68
	}

	public class HGEventLogSDKPluginCloud : IEventLogSDK // TypeDefIndex: 90615
	{
		// Fields
		private object _cloudClientBridgeInstance; // 0x10
		private MethodInfo _sendDataWithKeyMethod; // 0x18
	
		// Constructors
		public HGEventLogSDKPluginCloud(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static extern bool EventLogInitInstance(string appId, string regionTag); // 0x000000018C2254F8-0x000000018C225570
		private static extern bool EventLogEvent(string appId, string name, string properties); // 0x000000018C22545C-0x000000018C2254F8
		private void SendDataWithKey(string key, string data, Action<string> callback); // 0x000000018C225570-0x000000018C225834
		public bool appStartEvent(string appId, string channel1, string channel2, bool beat, string properties); // 0x000000018C225C24-0x000000018C225C74
		public bool appStartEventV2(string channel1, string channel2, bool beat, string properties); // 0x000000018C225834-0x000000018C225C24
		public bool characterLoginEvent(string appId, string characterId, string serverId, string properties); // 0x000000018C225FFC-0x000000018C22604C
		public bool characterLoginEventV2(string characterId, string serverId, string properties); // 0x000000018C225C74-0x000000018C225FFC
		public void clearGlobalProperties(string appId); // 0x000000018C22625C-0x000000018C2262B0
		public void clearGlobalPropertiesV2(); // 0x000000018C22604C-0x000000018C22625C
		public bool enableRealTimeSend(bool enable); // 0x000000018C2262B0-0x000000018C226564
		public bool eventTrack(string appId, string name, string properties); // 0x000000018C2268C0-0x000000018C226A14
		public bool eventTrackV2(string name, string properties); // 0x000000018C226564-0x000000018C226830
		public bool eventTrackV3(string appId, string name, string properties); // 0x000000018C226830-0x000000018C2268C0
		public void flush(string appId); // 0x000000018C226C24-0x000000018C226C78
		public void flushV2(); // 0x000000018C226A14-0x000000018C226C24
		public string getDeviceIdProperties(string appId); // 0x000000018C226CE0-0x000000018C226D48
		public string getDeviceIdPropertiesV2(); // 0x000000018C226C78-0x000000018C226CE0
		public string getPresetProperties(string appId); // 0x000000018C226DB0-0x000000018C226E18
		public string getPresetPropertiesV2(); // 0x000000018C226D48-0x000000018C226DB0
		public string getStaticPresetProperties(string appId); // 0x000000018C226E80-0x000000018C226EE8
		public string getStaticPresetPropertiesV2(); // 0x000000018C226E18-0x000000018C226E80
		public bool init(string appId, string regionTag); // 0x000000018C226EE8-0x000000018C227028
		public void pauseBeat(string appId); // 0x000000018C227238-0x000000018C22728C
		public void pauseBeatV2(); // 0x000000018C227028-0x000000018C227238
		public void resumeBeat(string appId); // 0x000000018C22749C-0x000000018C2274F0
		public void resumeBeatV2(); // 0x000000018C22728C-0x000000018C22749C
		public bool setEnvironment(string env); // 0x000000018C2274F0-0x000000018C22777C
		public bool setGlobalProperties(string appId, string globalProperties); // 0x000000018C227A08-0x000000018C227A58
		public bool setGlobalPropertiesV2(string globalProperties); // 0x000000018C22777C-0x000000018C227A08
		public void unsetCharacter(string appId); // 0x000000018C227C68-0x000000018C227CBC
		public void unsetCharacterV2(); // 0x000000018C227A58-0x000000018C227C68
		public bool unsetGlobalProperties(string appId, string propertyKeys); // 0x000000018C227F48-0x000000018C227F98
		public bool unsetGlobalPropertiesV2(string propertyKeys); // 0x000000018C227CBC-0x000000018C227F48
		public void unsetUser(string appId); // 0x000000018C2281A8-0x000000018C2281FC
		public void unsetUserV2(); // 0x000000018C227F98-0x000000018C2281A8
		public bool userLoginEvent(string appId, string userId, string properties); // 0x000000018C2284C8-0x000000018C228518
		public bool userLoginEventV2(string userId, string properties); // 0x000000018C2281FC-0x000000018C2284C8
	}

	public class HGEventLogSDKPluginWindows : IEventLogSDK // TypeDefIndex: 90616
	{
		// Constructors
		public HGEventLogSDKPluginWindows(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static extern bool EventLogSetEnvironment(string env); // 0x000000018C228F90-0x000000018C228FEC
		private static extern bool EventLogInitInstance(string appId, string regionTag); // 0x0000000186FD75A0-0x0000000186FD7630
		private static extern bool EventLogSetGlobalProperties(string appId, string globalProperties); // 0x000000018C229048-0x000000018C229108
		private static extern bool EventLogUnsetGlobalProperties(string appId, string propertyKeys); // 0x000000018C229238-0x000000018C2292F8
		private static extern bool EventLogClearGlobalProperties(string appId); // 0x000000018C228AD0-0x000000018C228B2C
		private static extern bool EventLogEvent(string appId, string name, string properties); // 0x000000018C228BA8-0x000000018C228C44
		private static extern bool EventLogAppStartEvent(string appId, string channel1, string channel2, bool beat, string properties); // 0x000000018C22860C-0x000000018C228720
		private static extern bool EventLogBeatPause(string appId); // 0x000000018C22874C-0x000000018C2287A8
		private static extern bool EventLogBeatResume(string appId); // 0x000000018C228810-0x000000018C2288B0
		private static extern bool EventLogUserLoginEvent(string appId, string userId, string properties); // 0x000000018C229408-0x000000018C2294EC
		private static extern bool EventLogUnsetUser(string appId); // 0x000000018C229324-0x000000018C229380
		private static extern bool EventLogCharacterLoginEvent(string appId, string characterId, string serverId, string properties); // 0x000000018C228994-0x000000018C228A9C
		private static extern bool EventLogUnsetCharacter(string appId); // 0x000000018C22913C-0x000000018C229198
		private static extern IntPtr EventLogGetPresetProperties(string appId); // 0x000000018C228E2C-0x000000018C228EC4
		private static extern IntPtr EventLogGetStaticPresetProperties(string appId); // 0x000000018C228EF8-0x000000018C228F90
		private static extern IntPtr EventLogGetDeviceIdProperties(string appId); // 0x000000018C228D94-0x000000018C228E2C
		private static extern bool EventLogEnableRealTimeSend(bool enable); // 0x000000018C228B2C-0x000000018C228BA8
		private static extern void EventLogFlush(string appId); // 0x000000018C228CAC-0x000000018C228D2C
		private static extern bool EventLogFree(IntPtr buf); // 0x0000000185ED50C0-0x0000000185ED5100
		private static extern bool EventLogUnsetGlobalPropertiesV2(string property_keys); // 0x000000018C229198-0x000000018C229238
		private static extern bool EventLogSetGlobalPropertiesV2(string global_properties); // 0x000000018C228FEC-0x000000018C229048
		private static extern void EventLogClearGlobalPropertiesV2(); // 0x000000018C228A9C-0x000000018C228AD0
		private static extern bool EventLogEventV2(string name, string json_str); // 0x00000001854C12C0-0x00000001854C1350
		private static extern bool EventLogAppStartEventV2(string channel1, string channel2, bool beat, string json_str); // 0x000000018C228518-0x000000018C22860C
		private static extern void EventLogBeatPauseV2(); // 0x000000018C228720-0x000000018C22874C
		private static extern void EventLogBeatResumeV2(); // 0x000000018C2287A8-0x000000018C228810
		private static extern bool EventLogUserLoginEventV2(string user_id, string json_str); // 0x000000018C229380-0x000000018C229408
		private static extern void EventLogUnsetUserV2(); // 0x000000018C2292F8-0x000000018C229324
		private static extern bool EventLogCharacterLoginEventV2(string character_id, string server_id, string json_str); // 0x000000018C2288B0-0x000000018C228994
		private static extern void EventLogUnsetCharacterV2(); // 0x000000018C229108-0x000000018C22913C
		private static extern IntPtr EventLogGetPresetPropertiesV2(); // 0x0000000185ED4DC0-0x0000000185ED4DF0
		private static extern IntPtr EventLogGetStaticPresetPropertiesV2(); // 0x000000018C228EC4-0x000000018C228EF8
		private static extern IntPtr EventLogGetDeviceIdPropertiesV2(); // 0x000000018C228D2C-0x000000018C228D94
		private static extern void EventLogFlushV2(); // 0x000000018C228C44-0x000000018C228CAC
		public bool setEnvironment(string env); // 0x000000018C229E48-0x000000018C229EC4
		public bool init(string appId, string regionTag); // 0x0000000186FD7570-0x0000000186FD75A0
		public bool setGlobalProperties(string appId, string globalProperties); // 0x000000018C229ED0-0x000000018C229F54
		public bool unsetGlobalProperties(string appId, string propertyKeys); // 0x000000018C229FE4-0x000000018C22A068
		public void clearGlobalProperties(string appId); // 0x000000018C229674-0x000000018C2296F0
		public bool eventTrack(string appId, string name, string properties); // 0x000000018C22977C-0x000000018C229808
		public bool appStartEvent(string appId, string channel1, string channel2, bool beat, string properties); // 0x000000018C22951C-0x000000018C2295BC
		public void pauseBeat(string appId); // 0x000000018C229D48-0x000000018C229DC4
		public void resumeBeat(string appId); // 0x000000018C229DCC-0x000000018C229E48
		public bool userLoginEvent(string appId, string userId, string properties); // 0x000000018C22A100-0x000000018C22A1CC
		public void unsetUser(string appId); // 0x000000018C22A070-0x000000018C22A0EC
		public bool characterLoginEvent(string appId, string characterId, string serverId, string properties); // 0x000000018C2295D4-0x000000018C22966C
		public void unsetCharacter(string appId); // 0x000000018C229F5C-0x000000018C229FD8
		public string getPresetProperties(string appId); // 0x000000018C229A6C-0x000000018C229B60
		public string getStaticPresetProperties(string appId); // 0x000000018C229C4C-0x000000018C229D40
		public string getDeviceIdProperties(string appId); // 0x000000018C229978-0x000000018C229A6C
		public void flush(string appId); // 0x000000018C229810-0x000000018C22988C
		public bool enableRealTimeSend(bool enable); // 0x000000018C2296F0-0x000000018C22976C
		public bool setGlobalPropertiesV2(string globalProperties); // 0x000000018C229EC4-0x000000018C229ED0
		public bool unsetGlobalPropertiesV2(string propertyKeys); // 0x000000018C229FD8-0x000000018C229FE4
		public void clearGlobalPropertiesV2(); // 0x000000018C22966C-0x000000018C229674
		public bool eventTrackV2(string name, string properties); // 0x000000018783B198-0x000000018783B1AC
		public bool appStartEventV2(string channel1, string channel2, bool beat, string properties); // 0x000000018C2294EC-0x000000018C22951C
		public void pauseBeatV2(); // 0x000000018C229D40-0x000000018C229D48
		public void resumeBeatV2(); // 0x000000018C229DC4-0x000000018C229DCC
		public bool userLoginEventV2(string userId, string properties); // 0x000000018C22A0EC-0x000000018C22A100
		public void unsetUserV2(); // 0x000000018C22A068-0x000000018C22A070
		public bool characterLoginEventV2(string characterId, string serverId, string properties); // 0x000000018C2295BC-0x000000018C2295D4
		public void unsetCharacterV2(); // 0x000000018C229F54-0x000000018C229F5C
		public string getPresetPropertiesV2(); // 0x0000000185ED4D30-0x0000000185ED4DC0
		public void flushV2(); // 0x000000018C229808-0x000000018C229810
		public string getStaticPresetPropertiesV2(); // 0x000000018C229B60-0x000000018C229C4C
		public string getDeviceIdPropertiesV2(); // 0x000000018C22988C-0x000000018C229978
		public bool eventTrackV3(string appId, string name, string properties); // 0x000000018C22976C-0x000000018C22977C
	}

	public static class HGEventLogSDKVersion // TypeDefIndex: 90617
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static HGEventLogSDKVersion(); // 0x00000001871EA130-0x00000001871EA190
	}
}
