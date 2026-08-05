/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 101: Hypergryph.EventLogSDK.dll - Assembly: Hypergryph.EventLogSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63219-63228
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Hypergryph.SDK
{
	public class CloudGameUtil // TypeDefIndex: 63220
	{
		// Methods
		public static bool IsCloudGame(); // 0x00000001840BC870-0x00000001840BC9E0
	}

	public interface IEventLogSDK // TypeDefIndex: 63221
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

	internal static class HGEventLogSDKBridge // TypeDefIndex: 63222
	{
		// Fields
		private static IEventLogSDK s_el; // 0x00
	
		// Properties
		public static IEventLogSDK eventLogSdk { get; } // 0x00000001840BC440-0x00000001840BC530 
	}

	public class HGEventLogSDKAppInstance : MonoBehaviour // TypeDefIndex: 63223
	{
		// Constructors
		public HGEventLogSDKAppInstance(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public static bool SetEnvironment(string env); // 0x0000000189DDD450-0x0000000189DDD47C
		public static bool SetGlobalProperties(string globalProperties); // 0x0000000189DDD47C-0x0000000189DDD4EC
		public static bool UnsetGlobalProperties(string propertyKeys); // 0x0000000189DDD54C-0x0000000189DDD5BC
		public static void ClearGlobalProperties(); // 0x0000000189DDD218-0x0000000189DDD278
		public static bool EventTrack(string name, string properties); // 0x00000001840BC3E0-0x00000001840BC440
		public static bool AppStartEvent(string channel1, string channel2, bool beat, string properties); // 0x0000000189DDD0C0-0x0000000189DDD174
		public static bool UserLoginEvent(string userId, string properties); // 0x0000000189DDD61C-0x0000000189DDD6A0
		public static void UnsetUser(); // 0x0000000189DDD5BC-0x0000000189DDD61C
		public static bool CharacterLoginEvent(string characterId, string serverId, string properties); // 0x0000000189DDD174-0x0000000189DDD218
		public static void UnsetCharacter(); // 0x0000000189DDD4EC-0x0000000189DDD54C
		public static string GetPresetProperties(); // 0x00000001840BC220-0x00000001840BC270
		public static void PauseBeat(); // 0x0000000189DDD408-0x0000000189DDD42C
		public static void ResumeBeat(); // 0x0000000189DDD42C-0x0000000189DDD450
		public static void Flush(); // 0x0000000189DDD2A4-0x0000000189DDD304
		public static bool EnableRealTimeSend(bool enable); // 0x0000000189DDD278-0x0000000189DDD2A4
		public static string GetStaticPresetProperties(); // 0x0000000189DDD368-0x0000000189DDD3CC
		public static string GetDeviceIdProperties(); // 0x0000000189DDD304-0x0000000189DDD368
		private void OnApplicationPause(bool pause); // 0x0000000189DDD3CC-0x0000000189DDD408
	}

	public class HGEventLogSDKInstance // TypeDefIndex: 63224
	{
		// Methods
		public static bool init(string appId, string region); // 0x00000001840BA9B0-0x00000001840BA9F0
		public static bool EventTrackWithAppId(string appId, string name, string properties); // 0x0000000189DDD6A0-0x0000000189DDD744
	}

	public class HGEventLogSDKMgr : MonoBehaviour // TypeDefIndex: 63225
	{
		// Fields
		private static string appIdForInstance; // 0x00
	
		// Constructors
		public HGEventLogSDKMgr(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public static bool SetEnvironment(string env); // 0x0000000189DDDF84-0x0000000189DDDFE8
		public static bool Init(string appId, string regionTag); // 0x0000000189DDDD80-0x0000000189DDDE1C
		public static bool SetGlobalProperties(string globalProperties); // 0x0000000189DDDFE8-0x0000000189DDE0B0
		public static bool UnsetGlobalProperties(string propertyKeys); // 0x0000000189DDE15C-0x0000000189DDE224
		public static void ClearGlobalProperties(); // 0x0000000189DDD940-0x0000000189DDD9EC
		public static bool EventTrack(string name, string properties); // 0x0000000189DDD9EC-0x0000000189DDDAC4
		public static bool AppStartEvent(string channel1, string channel2, bool beat, string properties); // 0x0000000189DDD744-0x0000000189DDD850
		public static bool UserLoginEvent(string userId, string properties); // 0x0000000189DDE2D0-0x0000000189DDE3A8
		public static void UnsetUser(); // 0x0000000189DDE224-0x0000000189DDE2D0
		public static bool CharacterLoginEvent(string characterId, string serverId, string properties); // 0x0000000189DDD850-0x0000000189DDD940
		public static void UnsetCharacter(); // 0x0000000189DDE0B0-0x0000000189DDE15C
		public static string GetPresetProperties(); // 0x0000000189DDDC20-0x0000000189DDDCD0
		public static void PauseBeat(); // 0x0000000189DDDEBC-0x0000000189DDDF20
		public static void ResumeBeat(); // 0x0000000189DDDF20-0x0000000189DDDF84
		public static void Flush(); // 0x0000000189DDDAC4-0x0000000189DDDB70
		public static bool EnableRealTimeSend(bool enable); // 0x0000000189DDD278-0x0000000189DDD2A4
		public static string GetStaticPresetProperties(); // 0x0000000189DDDCD0-0x0000000189DDDD80
		public static string GetDeviceIdProperties(); // 0x0000000189DDDB70-0x0000000189DDDC20
		private void OnApplicationPause(bool pause); // 0x0000000189DDDE1C-0x0000000189DDDEBC
	}

	public class HGEventLogSDKPluginCloud : IEventLogSDK // TypeDefIndex: 63226
	{
		// Fields
		private object _cloudClientBridgeInstance; // 0x10
		private MethodInfo _sendDataWithKeyMethod; // 0x18
	
		// Constructors
		public HGEventLogSDKPluginCloud(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private static extern bool EventLogInitInstance(string appId, string regionTag); // 0x0000000189DDE444-0x0000000189DDE4BC
		private static extern bool EventLogEvent(string appId, string name, string properties); // 0x0000000189DDE3A8-0x0000000189DDE444
		private void SendDataWithKey(string key, string data, Action<string> callback); // 0x0000000189DDE4BC-0x0000000189DDE77C
		public bool appStartEvent(string appId, string channel1, string channel2, bool beat, string properties); // 0x0000000189DDEB68-0x0000000189DDEBB8
		public bool appStartEventV2(string channel1, string channel2, bool beat, string properties); // 0x0000000189DDE77C-0x0000000189DDEB68
		public bool characterLoginEvent(string appId, string characterId, string serverId, string properties); // 0x0000000189DDEF3C-0x0000000189DDEF8C
		public bool characterLoginEventV2(string characterId, string serverId, string properties); // 0x0000000189DDEBB8-0x0000000189DDEF3C
		public void clearGlobalProperties(string appId); // 0x0000000189DDF198-0x0000000189DDF1EC
		public void clearGlobalPropertiesV2(); // 0x0000000189DDEF8C-0x0000000189DDF198
		public bool enableRealTimeSend(bool enable); // 0x0000000189DDF1EC-0x0000000189DDF49C
		public bool eventTrack(string appId, string name, string properties); // 0x0000000189DDF7F0-0x0000000189DDF944
		public bool eventTrackV2(string name, string properties); // 0x0000000189DDF49C-0x0000000189DDF760
		public bool eventTrackV3(string appId, string name, string properties); // 0x0000000189DDF760-0x0000000189DDF7F0
		public void flush(string appId); // 0x0000000189DDFB50-0x0000000189DDFBA4
		public void flushV2(); // 0x0000000189DDF944-0x0000000189DDFB50
		public string getDeviceIdProperties(string appId); // 0x0000000189DDFC0C-0x0000000189DDFC74
		public string getDeviceIdPropertiesV2(); // 0x0000000189DDFBA4-0x0000000189DDFC0C
		public string getPresetProperties(string appId); // 0x0000000189DDFCDC-0x0000000189DDFD44
		public string getPresetPropertiesV2(); // 0x0000000189DDFC74-0x0000000189DDFCDC
		public string getStaticPresetProperties(string appId); // 0x0000000189DDFDAC-0x0000000189DDFE14
		public string getStaticPresetPropertiesV2(); // 0x0000000189DDFD44-0x0000000189DDFDAC
		public bool init(string appId, string regionTag); // 0x0000000189DDFE14-0x0000000189DDFF54
		public void pauseBeat(string appId); // 0x0000000189DE0160-0x0000000189DE01B4
		public void pauseBeatV2(); // 0x0000000189DDFF54-0x0000000189DE0160
		public void resumeBeat(string appId); // 0x0000000189DE03C0-0x0000000189DE0414
		public void resumeBeatV2(); // 0x0000000189DE01B4-0x0000000189DE03C0
		public bool setEnvironment(string env); // 0x0000000189DE0414-0x0000000189DE069C
		public bool setGlobalProperties(string appId, string globalProperties); // 0x0000000189DE0924-0x0000000189DE0974
		public bool setGlobalPropertiesV2(string globalProperties); // 0x0000000189DE069C-0x0000000189DE0924
		public void unsetCharacter(string appId); // 0x0000000189DE0B80-0x0000000189DE0BD4
		public void unsetCharacterV2(); // 0x0000000189DE0974-0x0000000189DE0B80
		public bool unsetGlobalProperties(string appId, string propertyKeys); // 0x0000000189DE0E5C-0x0000000189DE0EAC
		public bool unsetGlobalPropertiesV2(string propertyKeys); // 0x0000000189DE0BD4-0x0000000189DE0E5C
		public void unsetUser(string appId); // 0x0000000189DE10B8-0x0000000189DE110C
		public void unsetUserV2(); // 0x0000000189DE0EAC-0x0000000189DE10B8
		public bool userLoginEvent(string appId, string userId, string properties); // 0x0000000189DE13D0-0x0000000189DE1420
		public bool userLoginEventV2(string userId, string properties); // 0x0000000189DE110C-0x0000000189DE13D0
	}

	public class HGEventLogSDKPluginWindows : IEventLogSDK // TypeDefIndex: 63227
	{
		// Constructors
		public HGEventLogSDKPluginWindows(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private static extern bool EventLogSetEnvironment(string env); // 0x0000000189DE1E84-0x0000000189DE1EE0
		private static extern bool EventLogInitInstance(string appId, string regionTag); // 0x00000001840BA7E0-0x00000001840BA870
		private static extern bool EventLogSetGlobalProperties(string appId, string globalProperties); // 0x0000000189DE1F3C-0x0000000189DE1FFC
		private static extern bool EventLogUnsetGlobalProperties(string appId, string propertyKeys); // 0x0000000189DE2128-0x0000000189DE21E8
		private static extern bool EventLogClearGlobalProperties(string appId); // 0x0000000189DE19C8-0x0000000189DE1A24
		private static extern bool EventLogEvent(string appId, string name, string properties); // 0x0000000189DE1A9C-0x0000000189DE1B38
		private static extern bool EventLogAppStartEvent(string appId, string channel1, string channel2, bool beat, string properties); // 0x0000000189DE1514-0x0000000189DE1624
		private static extern bool EventLogBeatPause(string appId); // 0x0000000189DE1650-0x0000000189DE16AC
		private static extern bool EventLogBeatResume(string appId); // 0x0000000189DE1714-0x0000000189DE17B0
		private static extern bool EventLogUserLoginEvent(string appId, string userId, string properties); // 0x0000000189DE22F8-0x0000000189DE23D8
		private static extern bool EventLogUnsetUser(string appId); // 0x0000000189DE2214-0x0000000189DE2270
		private static extern bool EventLogCharacterLoginEvent(string appId, string characterId, string serverId, string properties); // 0x0000000189DE1890-0x0000000189DE1994
		private static extern bool EventLogUnsetCharacter(string appId); // 0x0000000189DE2030-0x0000000189DE208C
		private static extern IntPtr EventLogGetPresetProperties(string appId); // 0x0000000189DE1D20-0x0000000189DE1DB8
		private static extern IntPtr EventLogGetStaticPresetProperties(string appId); // 0x0000000189DE1DEC-0x0000000189DE1E84
		private static extern IntPtr EventLogGetDeviceIdProperties(string appId); // 0x0000000189DE1C88-0x0000000189DE1D20
		private static extern bool EventLogEnableRealTimeSend(bool enable); // 0x0000000189DE1A24-0x0000000189DE1A9C
		private static extern void EventLogFlush(string appId); // 0x0000000189DE1BA0-0x0000000189DE1C20
		private static extern bool EventLogFree(IntPtr buf); // 0x00000001840BC600-0x00000001840BC680
		private static extern bool EventLogUnsetGlobalPropertiesV2(string property_keys); // 0x0000000189DE208C-0x0000000189DE2128
		private static extern bool EventLogSetGlobalPropertiesV2(string global_properties); // 0x0000000189DE1EE0-0x0000000189DE1F3C
		private static extern void EventLogClearGlobalPropertiesV2(); // 0x0000000189DE1994-0x0000000189DE19C8
		private static extern bool EventLogEventV2(string name, string json_str); // 0x000000018445BAF0-0x000000018445BB80
		private static extern bool EventLogAppStartEventV2(string channel1, string channel2, bool beat, string json_str); // 0x0000000189DE1420-0x0000000189DE1514
		private static extern void EventLogBeatPauseV2(); // 0x0000000189DE1624-0x0000000189DE1650
		private static extern void EventLogBeatResumeV2(); // 0x0000000189DE16AC-0x0000000189DE1714
		private static extern bool EventLogUserLoginEventV2(string user_id, string json_str); // 0x0000000189DE2270-0x0000000189DE22F8
		private static extern void EventLogUnsetUserV2(); // 0x0000000189DE21E8-0x0000000189DE2214
		private static extern bool EventLogCharacterLoginEventV2(string character_id, string server_id, string json_str); // 0x0000000189DE17B0-0x0000000189DE1890
		private static extern void EventLogUnsetCharacterV2(); // 0x0000000189DE1FFC-0x0000000189DE2030
		private static extern IntPtr EventLogGetPresetPropertiesV2(); // 0x00000001840BC300-0x00000001840BC330
		private static extern IntPtr EventLogGetStaticPresetPropertiesV2(); // 0x0000000189DE1DB8-0x0000000189DE1DEC
		private static extern IntPtr EventLogGetDeviceIdPropertiesV2(); // 0x0000000189DE1C20-0x0000000189DE1C88
		private static extern void EventLogFlushV2(); // 0x0000000189DE1B38-0x0000000189DE1BA0
		public bool setEnvironment(string env); // 0x0000000189DE2D34-0x0000000189DE2DB0
		public bool init(string appId, string regionTag); // 0x00000001840BC680-0x00000001840BC6B0
		public bool setGlobalProperties(string appId, string globalProperties); // 0x0000000189DE2DBC-0x0000000189DE2E40
		public bool unsetGlobalProperties(string appId, string propertyKeys); // 0x0000000189DE2ED0-0x0000000189DE2F54
		public void clearGlobalProperties(string appId); // 0x0000000189DE2560-0x0000000189DE25DC
		public bool eventTrack(string appId, string name, string properties); // 0x0000000189DE2668-0x0000000189DE26F4
		public bool appStartEvent(string appId, string channel1, string channel2, bool beat, string properties); // 0x0000000189DE2408-0x0000000189DE24A8
		public void pauseBeat(string appId); // 0x0000000189DE2C34-0x0000000189DE2CB0
		public void resumeBeat(string appId); // 0x0000000189DE2CB8-0x0000000189DE2D34
		public bool userLoginEvent(string appId, string userId, string properties); // 0x0000000189DE2FEC-0x0000000189DE30B8
		public void unsetUser(string appId); // 0x0000000189DE2F5C-0x0000000189DE2FD8
		public bool characterLoginEvent(string appId, string characterId, string serverId, string properties); // 0x0000000189DE24C0-0x0000000189DE2558
		public void unsetCharacter(string appId); // 0x0000000189DE2E48-0x0000000189DE2EC4
		public string getPresetProperties(string appId); // 0x0000000189DE2958-0x0000000189DE2A4C
		public string getStaticPresetProperties(string appId); // 0x0000000189DE2B38-0x0000000189DE2C2C
		public string getDeviceIdProperties(string appId); // 0x0000000189DE2864-0x0000000189DE2958
		public void flush(string appId); // 0x0000000189DE26FC-0x0000000189DE2778
		public bool enableRealTimeSend(bool enable); // 0x0000000189DE25DC-0x0000000189DE2658
		public bool setGlobalPropertiesV2(string globalProperties); // 0x0000000189DE2DB0-0x0000000189DE2DBC
		public bool unsetGlobalPropertiesV2(string propertyKeys); // 0x0000000189DE2EC4-0x0000000189DE2ED0
		public void clearGlobalPropertiesV2(); // 0x0000000189DE2558-0x0000000189DE2560
		public bool eventTrackV2(string name, string properties); // 0x0000000185396E8C-0x0000000185396EA0
		public bool appStartEventV2(string channel1, string channel2, bool beat, string properties); // 0x0000000189DE23D8-0x0000000189DE2408
		public void pauseBeatV2(); // 0x0000000189DE2C2C-0x0000000189DE2C34
		public void resumeBeatV2(); // 0x0000000189DE2CB0-0x0000000189DE2CB8
		public bool userLoginEventV2(string userId, string properties); // 0x0000000189DE2FD8-0x0000000189DE2FEC
		public void unsetUserV2(); // 0x0000000189DE2F54-0x0000000189DE2F5C
		public bool characterLoginEventV2(string characterId, string serverId, string properties); // 0x0000000189DE24A8-0x0000000189DE24C0
		public void unsetCharacterV2(); // 0x0000000189DE2E40-0x0000000189DE2E48
		public string getPresetPropertiesV2(); // 0x00000001840BC270-0x00000001840BC300
		public void flushV2(); // 0x0000000189DE26F4-0x0000000189DE26FC
		public string getStaticPresetPropertiesV2(); // 0x0000000189DE2A4C-0x0000000189DE2B38
		public string getDeviceIdPropertiesV2(); // 0x0000000189DE2778-0x0000000189DE2864
		public bool eventTrackV3(string appId, string name, string properties); // 0x0000000189DE2658-0x0000000189DE2668
	}

	public static class HGEventLogSDKVersion // TypeDefIndex: 63228
	{
		// Fields
		public static readonly string VERSION; // 0x00
	
		// Constructors
		static HGEventLogSDKVersion(); // 0x0000000184D50680-0x0000000184D506E0
	}
}
