/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using Beyond;
using Beyond.Log;
using IFix.Core;
using UnityEngine;
using UnityEngine.LowLevel;

// Image 63: Beyond.Dlogger.Runtime.dll - Assembly: Beyond.Dlogger.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59196-59218

namespace Beyond
{
	public enum ELogChannel : byte // TypeDefIndex: 59197
	{
		None = 0,
		Res = 1,
		Cfg = 2,
		Battle = 3,
		GamePlay = 4,
		UI = 5,
		Effect = 6,
		Audio = 7,
		Network = 8,
		Dialog = 9,
		Cutscene = 10,
		HGRP = 11,
		Build = 12,
		Camera = 13,
		Animation = 14,
		Scene = 15,
		Action = 16,
		Tool = 17,
		Inventory = 18,
		Lua = 19,
		Debug = 20,
		LevelScript = 21,
		Movement = 22,
		Interactive = 23,
		Common = 24,
		Editor = 25,
		Streaming = 26,
		Factory = 27,
		Utils = 28,
		NPC = 29,
		VIDEO = 30,
		I18N = 31,
		Guide = 32,
		HGEventLog = 33,
		RedDot = 34,
		NetworkCore = 35,
		ExportScene = 36,
		ExportSceneValidation = 37,
		HGNetLog = 38,
		IFix = 39,
		SDK = 40,
		VFS = 41,
		Preload = 42,
		Voice = 43,
		CmdExport = 44,
		BossBattler = 45,
		ActionDetail = 46,
		ActionExecutor = 47,
		GameEventManager = 48,
		ClientData = 49,
		P4 = 50,
		NavMesh = 51,
		FMV = 52,
		Scope = 53,
		MiniGame = 54,
		Spawner = 55,
		AI = 56,
		Validation = 57,
		Luna = 58,
		LevelScriptTask = 59,
		Dungeon = 60,
		WorldLifeSpan = 61,
		SNS = 62,
		HttpGm = 63,
		LevelEditor = 64,
		TowerDefense = 65,
		Spaceship = 66,
		Physics = 67,
		Weapon = 68,
		DataManager = 69,
		TempFile = 70,
		Quality = 71,
		Map = 72,
		Bark = 73,
		Entity = 74,
		Squad = 75,
		LevelSeq = 76,
		Mission = 77,
		Tracking = 78,
		Friend = 79,
		Lsm = 80,
		ConditionRuntime = 81,
		DynamicScene = 82,
		ModelView = 83,
		WaterDrone = 84,
		HelloWorld = 85,
		MapRegion = 86,
		GameSetting = 87,
		LevelLoader = 88,
		PS5 = 89,
		Activity = 90,
		Login = 91,
		SkeletalMorph = 92,
		Gm = 93,
		AbilityAction = 94,
		AbilityActionEssential = 95,
		SystemPoi = 96,
		CharPerform = 97,
		BackgroundNotification = 98,
		CloudGame = 99,
		GlobalTag = 100,
		MoveSync = 101,
		SubVersionControl = 102,
		SimulationTraining = 103,
		Max = 104
	}

	public enum ELogLevel : byte // TypeDefIndex: 59198
	{
		None = 0,
		Info = 1,
		Warning = 2,
		Error = 4,
		Critical = 8,
		Important = 16,
		Exception = 32,
		All = 63
	}

	public enum EColorTag : byte // TypeDefIndex: 59199
	{
		None = 0,
		Red = 1,
		Yellow = 2,
		Green = 3,
		Blue = 4,
		White = 5,
		Black = 6,
		Grey = 7,
		Cyan = 8,
		Magenta = 9,
		Critical = 10
	}

	public static class LogDefine // TypeDefIndex: 59200
	{
		// Fields
		private static Dictionary<int, string> s_logNameCacheDict; // 0x00
	
		// Constructors
		static LogDefine() {} // 0x0000000185F3F760-0x0000000185F3F7F0
	
		// Methods
		public static string ConvertColorTagToName(EColorTag colorTag) => default; // 0x00000001873538E8-0x0000000187353AC8
		public static string ConvertLogChannelToName(ELogChannel logChannel) => default; // 0x00000001841C93D0-0x00000001841C9530
	}

	public enum EnableLogType // TypeDefIndex: 59201
	{
		DevOnly = 0,
		Release = 1,
		Login = 2,
		EntitySpawn = 3,
		NpcSpawn = 4,
		Proxy = 5,
		NpcAction = 6,
		GuideState = 7,
		MainCharacter = 8,
		Perform = 9,
		LevelLoader = 10,
		Dialog = 11,
		MainHudActionQueue = 12,
		AirWall = 13,
		Gm = 14,
		I18N = 15,
		Count = 16
	}

	public static class DLogger // TypeDefIndex: 59209
	{
		// Fields
		private static bool[] s_remoteSet; // 0x00
		internal static Beyond.Log.ILogger s_consoleLogger; // 0x08
		internal static SceneViewMessageLogger s_sceneViewLogger; // 0x10
		internal static UnionLogger s_defaultLogger; // 0x18
		private static ELogLevel ms_enabledLogLevel; // 0x20
		private static ELogLevel[] ms_enabledLogChannel; // 0x28
		private static LogCallback ms_logCriticalAndExceptionCallbackHandler; // 0x30
		private static LogCallback ms_onBeforeLogError; // 0x38
		private static LogCallback ms_onBeforeLogCriticalAndException; // 0x40
		public static Func<string> s_getLuaStackTraceHandler; // 0x48
		private static Stack<DebugContext> s_debugContextPool; // 0x50
		private static List<DebugContext> s_debugContextList; // 0x58
		private static int _FrameCountThreadSafe_k__BackingField; // 0x60
		private static int _LogPing_k__BackingField; // 0x64
		private static Vector3 _LogPlayerPos_k__BackingField; // 0x68
		public static int ExceptionCount; // 0x74
		public static int CriticalCount; // 0x78
		public static int ErrorCount; // 0x7C
		public static int ImportantCount; // 0x80
		public static int WarningCount; // 0x84
		public static int InfoCount; // 0x88
		public static int PauseCount; // 0x8C
		public static int ReturnLoginCount; // 0x90
	
		// Properties
		public static ELogLevel[] s_enabledLogChannel { get; } // 0x00000001841C9650-0x00000001841C9760 
		public static int FrameCountThreadSafe { get; private set; } // 0x0000000185A303D0-0x0000000185A30760 0x0000000185492010-0x0000000185492020
		public static int LogPing { get; private set; } // 0x0000000185B96300-0x0000000185B96380 0x00000001833EEC70-0x00000001833EEC80
		public static Vector3 LogPlayerPos { get; private set; } // 0x0000000185FB0500-0x0000000185FB0510 0x000000018734EE38-0x000000018734EFB4
	
		// Events
		public static event LogCallback s_logCriticalAndExceptionMessageReceived;
		public static event LogCallback s_onBeforeLogError;
		public static event LogCallback s_onBeforeLogCriticalAndException;
	
		// Nested types
		public class Options // TypeDefIndex: 59202
		{
			// Fields
			public Dictionary<EnableLogType, bool> remoteSet; // 0x10
	
			// Constructors
			public Options() {} // 0x000000018570B520-0x000000018570B720
		}
	
		public delegate void LogCallback(ref FLogMessage msg); // TypeDefIndex: 59203; 0x0000000185B96380-0x0000000185B96480
	
		public class DebugContext // TypeDefIndex: 59204
		{
			// Fields
			public ELogLevel logLevelMask; // 0x10
			public string info; // 0x18
	
			// Constructors
			public DebugContext() {} // 0x000000018734EA3C-0x000000018734EB3C
		}
	
		public struct DebugContextScope : IDisposable // TypeDefIndex: 59205
		{
			// Methods
			public void Dispose() {} // 0x0000000185EFF0B0-0x0000000185EFF180
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 59206
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static PlayerLoopSystem.UpdateFunction __9__432_0; // 0x08
	
			// Constructors
			static __c() {} // 0x00000001841C8EB0-0x00000001841C8F90
			public __c() {} // 0x000000018734E7F4-0x000000018734E8F4
	
			// Methods
			internal void __AddCustomGameLoop_b__432_0() {} // 0x000000018734EC3C-0x000000018734ED3C
		}
	
		private sealed class __c__DisplayClass433_0 // TypeDefIndex: 59207
		{
			// Fields
			public string categoryName; // 0x10
			public string systemName; // 0x18
	
			// Constructors
			public __c__DisplayClass433_0() {} // 0x000000018734E6F4-0x000000018734E7F4
	
			// Methods
			internal bool _AddPlayerLoop_b__0(PlayerLoopSystem s) => default; // 0x000000018734EB3C-0x000000018734EC3C
			internal bool _AddPlayerLoop_b__1(PlayerLoopSystem h) => default; // 0x0000000184F30E40-0x0000000184F30ED0
		}
	
		private sealed class __c__DisplayClass434_0 // TypeDefIndex: 59208
		{
			// Fields
			public System.Type t; // 0x10
			public Func<PlayerLoopSystem, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass434_0() {} // 0x000000018734DD00-0x000000018734DD7C
	
			// Methods
			internal bool _CheckRegist_b__0(PlayerLoopSystem x) => default; // 0x00000001841C9760-0x00000001841C97E0
		}
	
		// Constructors
		static DLogger() {} // 0x0000000185642B20-0x0000000185642C90
	
		// Methods
		public static void SetImportantLogConfig(Options options) {} // 0x000000018734DC44-0x000000018734DD00
		private static void _RunOnStart() {}
		private static void UpdateLogCount(ref FLogMessage msg) {}
		public static void SetServerLogger(Beyond.Log.ILogger logger) {} // 0x000000018734D4DC-0x000000018734D574
		public static void SetLogLevel(ELogLevel level) {}
		public static bool CheckLogLevel(ELogLevel level) => default;
		public static void SetLogChannelEnabled(ELogChannel channel, ELogLevel level, bool val) {}
		public static bool CheckLogChannelEnabled(ELogChannel channel, ELogLevel level = ELogLevel.Info /* Metadata: 0x02080541 */) => default;
		public static void Log(string message) {}
		public static void Log<T>(string message, T param1) {}
		public static void Log<T1, T2>(string message, T1 param1, T2 param2) {}
		public static void Log<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734DA30-0x000000018734DADC
		public static void Log<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void Log<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void Log<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void Log(ELogChannel channel, string message) {}
		public static void Log<T>(ELogChannel channel, string message, T param1) {}
		public static void Log<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void Log<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734D99C-0x000000018734DA30
		public static void Log<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void Log<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void Log<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void Log(ELogChannel channel, EColorTag color, string message) {}
		public static void Log<T>(ELogChannel channel, EColorTag color, string message, T param1) {}
		public static void Log<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {} // 0x000000018734D870-0x000000018734D99C
		public static void Log<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {}
		public static void Log<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void Log<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void Log<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void Log(UnityEngine.Object context, string message) {}
		public static void Log<T>(UnityEngine.Object context, string message, T param1) {}
		public static void Log<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2) {} // 0x000000018734B82C-0x000000018734B86C
		public static void Log<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void Log<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void Log<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void Log<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void Log(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {}
		public static void Log<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {}
		public static void Log<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void Log<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734B78C-0x000000018734B7DC
		public static void Log<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void Log<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void Log<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogEditorAlwaysPrint(string message) {}
		public static void LogEditorAlwaysPrint<T>(string message, T param1) {}
		public static void LogEditorAlwaysPrint<T1, T2>(string message, T1 param1, T2 param2) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734B8E0-0x000000018734B944
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogEditorAlwaysPrint(ELogChannel channel, string message) {}
		public static void LogEditorAlwaysPrint<T>(ELogChannel channel, string message, T param1) {}
		public static void LogEditorAlwaysPrint<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734B7DC-0x000000018734B82C
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, string message) {}
		public static void LogEditorAlwaysPrint<T>(ELogChannel channel, EColorTag color, string message, T param1) {}
		public static void LogEditorAlwaysPrint<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {} // 0x000000018734B86C-0x000000018734B8E0
		public static void LogEditorAlwaysPrint<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogEditorAlwaysPrint(UnityEngine.Object context, string message) {}
		public static void LogEditorAlwaysPrint<T>(UnityEngine.Object context, string message, T param1) {}
		public static void LogEditorAlwaysPrint<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2) {} // 0x000000018734D454-0x000000018734D4DC
		public static void LogEditorAlwaysPrint<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734D144-0x000000018734D1D8
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {}
		public static void LogEditorAlwaysPrint<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {}
		public static void LogEditorAlwaysPrint<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {} // 0x000000018734D294-0x000000018734D3A8
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogWarning(string message) {}
		public static void LogWarning(UnityEngine.Object context, string message) {}
		public static void LogWarning<T>(string message, T param1) {}
		public static void LogWarning<T1, T2>(string message, T1 param1, T2 param2) {}
		public static void LogWarning<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734D3A8-0x000000018734D454
		public static void LogWarning<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogWarning<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogWarning(ELogChannel channel, string message) {}
		public static void LogWarning<T>(ELogChannel channel, string message, T param1) {}
		public static void LogWarning<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogWarning<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734D1D8-0x000000018734D294
		public static void LogWarning<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogWarning<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogWarning(ELogChannel channel, EColorTag color, string message) {}
		public static void LogWarning<T>(ELogChannel channel, EColorTag color, string message, T param1) {}
		public static void LogWarning<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {}
		public static void LogWarning<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {} // 0x0000000185393C40-0x0000000185393CE0
		public static void LogWarning<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {} // 0x000000018734BF5C-0x000000018734C15C
		public static void LogWarning<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogWarning(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {} // 0x000000018734BEE0-0x000000018734BF5C
		public static void LogWarning<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {}
		public static void LogWarning<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogWarning<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogWarning<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogWarning<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogError(string message) {} // 0x000000018734C49C-0x000000018734C558
		public static void LogErrorWithLuaStack(ELogChannel channel, string message) {}
		public static void LogErrorWithLuaStack<T1>(ELogChannel channel, string message, T1 param1) {}
		public static void LogErrorWithLuaStack<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogErrorWithLuaStack<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogErrorWithLuaStack(string message) {}
		public static void LogError<T>(string message, T param1) {}
		public static void LogError<T1, T2>(string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734C3CC-0x000000018734C49C
		public static void LogError<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogError<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogError<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogError(ELogChannel channel, string message) {}
		public static void LogError<T>(ELogChannel channel, string message, T param1) {}
		public static void LogError<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734C15C-0x000000018734C218
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogError(ELogChannel channel, EColorTag color, string message) {}
		public static void LogError<T>(ELogChannel channel, EColorTag color, string message, T param1) {}
		public static void LogError<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734C2FC-0x000000018734C3CC
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogError(UnityEngine.Object context, string message) {}
		public static void LogError<T>(UnityEngine.Object context, string message, T param1) {}
		public static void LogError<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734C218-0x000000018734C2FC
		public static void LogError<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogError<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogError<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogError(ELogChannel channel, UnityEngine.Object context, string message) {}
		public static void LogError<T>(ELogChannel channel, UnityEngine.Object context, string message, T param1) {}
		public static void LogError<T1, T2>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734A6A0-0x000000018734A74C
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {} // 0x000000018734A164-0x000000018734A26C
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {} // 0x000000018734A590-0x000000018734A6A0
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {} // 0x000000018734AD84-0x000000018734AE9C
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {} // 0x000000018734AC60-0x000000018734AD84
		public static void LogError(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {} // 0x000000018734A860-0x000000018734A99C
		public static void LogError<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {} // 0x000000018734A01C-0x000000018734A164
		public static void LogError<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {} // 0x000000018734A26C-0x000000018734A3C8
		public static void LogError<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734A4D4-0x000000018734A590
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {} // 0x000000018734A3C8-0x000000018734A4D4
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {} // 0x000000018734A74C-0x000000018734A860
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {} // 0x000000018734AFD8-0x000000018734B104
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {} // 0x000000018734AE9C-0x000000018734AFD8
		public static void IFixLogError(string message) {} // 0x000000018734A99C-0x000000018734AAEC
		public static void IFixLogError(string message, string param1) {} // 0x000000018734B104-0x000000018734B260
		public static void IFixLogError(string message, string param1, string param2) {} // 0x000000018734AAEC-0x000000018734AC60
		public static void IFixLogError(string message, string param1, string param2, string param3) {} // 0x000000018734BD80-0x000000018734BE14
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4) {}
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5) {}
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5, string param6) {}
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5, string param6, string param7) {}
		public static void IFixLogError(ELogChannel channel, string message) {}
		public static void IFixLogError(ELogChannel channel, string message, string param1) {}
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2) {}
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3) {} // 0x000000018734BCD8-0x000000018734BD80
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4) {}
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5) {}
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5, string param6) {}
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5, string param6, string param7) {}
		public static void LogErrorWithFilter(string message, string filter) {}
		public static void LogErrorWithFilter<T>(string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(string message, string filter, T1 param1, T2 param2, T3 param3) {} // 0x000000018734BB00-0x000000018734BBBC
		public static void LogErrorWithFilter<T1, T2, T3, T4>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogErrorWithFilter(ELogChannel channel, string message, string filter) {}
		public static void LogErrorWithFilter<T>(ELogChannel channel, string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3) {} // 0x000000018734BA58-0x000000018734BB00
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogErrorWithFilter(ELogChannel channel, EColorTag color, string message, string filter) {}
		public static void LogErrorWithFilter<T>(ELogChannel channel, EColorTag color, string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3) {} // 0x000000018734BBBC-0x000000018734BCD8
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogErrorWithFilter(UnityEngine.Object context, string message, string filter) {}
		public static void LogErrorWithFilter<T>(UnityEngine.Object context, string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3) {} // 0x000000018734BE14-0x000000018734BEE0
		public static void LogErrorWithFilter<T1, T2, T3, T4>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogErrorWithFilter(ELogChannel channel, UnityEngine.Object context, string message, string filter) {}
		public static void LogErrorWithFilter<T>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3) {} // 0x000000018734B6E0-0x000000018734B78C
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogErrorWithFilter(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {}
		public static void LogErrorWithFilter<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3) {} // 0x000000018734B554-0x000000018734B610
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogCritical(string message) {}
		public static void LogCritical<T>(string message, T param1) {}
		public static void LogCritical<T1, T2>(string message, T1 param1, T2 param2) {}
		public static void LogCritical<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734B380-0x000000018734B498
		public static void LogCritical<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {} // 0x000000018734B498-0x000000018734B554
		public static void LogCritical<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogCritical(UnityEngine.Object context, string message) {}
		public static void LogCritical<T>(UnityEngine.Object context, string message, T param1) {}
		public static void LogCritical<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogCritical<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogCritical<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {} // 0x000000018734B610-0x000000018734B6E0
		public static void LogCritical<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogCritical(ELogChannel channel, UnityEngine.Object context, string message) {}
		public static void LogCritical(ELogChannel channel, string message) {}
		public static void LogCritical<T>(ELogChannel channel, string message, T param1) {}
		public static void LogCritical<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734B260-0x000000018734B380
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogCritical(ELogChannel channel, EColorTag color, string message) {}
		public static void LogCritical<T>(ELogChannel channel, EColorTag color, string message, T param1) {}
		public static void LogCritical<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {}
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogCritical(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {}
		public static void LogCritical<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {}
		public static void LogCritical<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {} // 0x000000018734C9B8-0x000000018734CA3C
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734CA3C-0x000000018734CACC
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {} // 0x000000018734C6E0-0x000000018734C770
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {} // 0x000000018734C914-0x000000018734C9B8
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {} // 0x000000018734C770-0x000000018734C914
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {} // 0x0000000184F676F0-0x0000000184F67770
		public static void LogCritical<T>(ELogChannel channel, UnityEngine.Object context, string message, T param1) {}
		public static void LogCritical<T1, T2>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogException(Exception e) {} // 0x0000000184F69230-0x0000000184F692C0
		public static void LogException(UnityEngine.Object context, Exception e) {}
		public static void LogException(ELogChannel channel, Exception e) {}
		public static void LogException(ELogChannel channel, EColorTag color, Exception e) {}
		public static void LogException(ELogChannel channel, EColorTag color, UnityEngine.Object context, Exception e) {}
		public static void LogImportant(EnableLogType enableLogType, string message) {}
		public static void LogImportant<T>(EnableLogType enableLogType, string message, T param1) {}
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, string message, T1 param1, T2 param2) {}
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734CACC-0x000000018734CB84
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, string message) {}
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, string message, T param1) {}
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734CB84-0x000000018734CC4C
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message) {}
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T param1) {}
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {}
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734E574-0x000000018734E644
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {} // 0x000000018734E3D4-0x000000018734E4A4
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {} // 0x000000018734E4A4-0x000000018734E574
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {}
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {} // 0x0000000185393CE0-0x0000000185393D90
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {} // 0x0000000184F692C0-0x0000000184F69420
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {} // 0x000000018734E304-0x000000018734E3D4
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {} // 0x0000000184F69510-0x0000000184F69660
		private static void _Log(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x0000000184F69420-0x0000000184F69510
		private static void _Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		private static void _LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {}
		private static void _LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {} // 0x000000018734CC4C-0x000000018734CD5C
		private static void _LogWarning(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {}
		private static void _LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		private static void _LogErrorWithFilter(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x000000018734B944-0x000000018734BA58
		private static void _LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		private static void _LogImportant(ELogChannel channel, EnableLogType enableLogType, EColorTag color, UnityEngine.Object context, string message) {}
		private static void _LogImportant<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EnableLogType enableLogType, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		private static void _LogCritical(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {}
		private static void _LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {} // 0x000000018734C558-0x000000018734C6E0
		private static void _ApplyLog(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x000000018734DD7C-0x000000018734DE04
		private static void _LogWithFilter(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x000000018734CEC4-0x000000018734CFDC
		private static void _ApplyLog<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {} // 0x0000000187349F8C-0x000000018734A01C
		private static void _LogWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {} // 0x0000000187349EFC-0x0000000187349F8C
		public static void LogToConsole(ELogChannel channel, string message) {} // 0x000000018734D0E0-0x000000018734D144
		public static void LogToConsole<T>(ELogChannel channel, string message, T param1) {} // 0x000000018734D090-0x000000018734D0E0
		public static void LogToConsole<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogErrorToConsole(ELogChannel channel, string message) {}
		public static void LogErrorToConsole<T>(ELogChannel channel, string message, T param1) {}
		public static void LogErrorToConsole<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogErrorToConsole<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {} // 0x000000018734CFDC-0x000000018734D040
		public static void LogErrorToConsole<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {} // 0x000000018734D040-0x000000018734D090
		public static void LogExceptionToConsole(ELogChannel channel, Exception e) {}
		public static void SetLogToSceneViewEnabled(bool enabled) {}
		private static void LogToSceneViewImpl(ELogLevel logLevel, ELogChannel channel, string message, float lifeTime) {}
		public static void ClearSceneViewLogs(string message) {}
		public static void ClearSceneViewLogsRegex(string message) {} // 0x000000018734CE60-0x000000018734CEC4
		public static void LogToSceneView(ELogChannel channel, float lifeTime, string message) {} // 0x000000018734CE10-0x000000018734CE60
		public static void LogToSceneView(ELogChannel channel, string message) {}
		public static void LogToSceneView<T>(ELogChannel channel, string message, T param1) {}
		public static void LogToSceneView<T>(ELogChannel channel, float lifeTime, string message, T param1) {}
		public static void LogToSceneView<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogToSceneView<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2) {} // 0x000000018734CD5C-0x000000018734CDC0
		public static void LogToSceneViewWarning(ELogChannel channel, float lifeTime, string message) {} // 0x000000018734CDC0-0x000000018734CE10
		public static void LogToSceneViewWarning(ELogChannel channel, string message) {}
		public static void LogToSceneViewWarning<T>(ELogChannel channel, string message, T param1) {}
		public static void LogToSceneViewWarning<T>(ELogChannel channel, float lifeTime, string message, T param1) {}
		public static void LogToSceneViewWarning<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogToSceneViewWarning<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2) {} // 0x000000018734D5FC-0x000000018734D730
		public static void LogToSceneViewError(ELogChannel channel, float lifeTime, string message) {} // 0x000000018734D730-0x000000018734D870
		public static void LogToSceneViewError(ELogChannel channel, string message) {} // 0x000000018734DF4C-0x000000018734E304
		public static void LogToSceneViewError<T>(ELogChannel channel, string message, T param1) {} // 0x000000018734DEF0-0x000000018734DF4C
		public static void LogToSceneViewError<T>(ELogChannel channel, float lifeTime, string message, T param1) {} // 0x000000018734E684-0x000000018734E6F4
		public static void LogToSceneViewError<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {} // 0x000000018734DE04-0x000000018734DEF0
		public static void LogToSceneViewError<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2) {} // 0x000000018734DB78-0x000000018734DC44
		public static void LogToSceneViewCritical(ELogChannel channel, float lifeTime, string message) {} // 0x00000001841C8A00-0x00000001841C8EB0
		public static void LogToSceneViewCritical(ELogChannel channel, string message) {} // 0x000000018734E8F4-0x000000018734E944
		public static void LogToSceneViewCritical<T>(ELogChannel channel, string message, T param1) {} // 0x000000018734ED3C-0x000000018734ED90
		public static void LogToSceneViewCritical<T>(ELogChannel channel, float lifeTime, string message, T param1) {} // 0x000000018734E944-0x000000018734E994
		public static void LogToSceneViewCritical<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {} // 0x000000018734ED90-0x000000018734EDE4
		public static void LogToSceneViewCritical<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2) {} // 0x000000018734E994-0x000000018734E9EC
		public static void Log(ELogLevel logLevel, ELogChannel channel, string message, UnityEngine.Object context = null) {} // 0x000000018734EDE4-0x000000018734EE38
		public static void Log(ELogLevel logLevel, ELogChannel channel, EColorTag color, string message, UnityEngine.Object context = null) {} // 0x000000018734DADC-0x000000018734DB24
		private static void _DefaultLog(ref FLogMessage msg) {} // 0x000000018734DB24-0x000000018734DB78
		private static void _ConsoleLog(ref FLogMessage msg) {} // 0x0000000184B2BF50-0x0000000184B2C130
		private static void _SceneViewLog(ref FLogMessage msg, float time) {} // 0x0000000184B2AEA0-0x0000000184B2B110
		private static DebugContext _AllocateDebugContext() => default; // 0x0000000184B2ABA0-0x0000000184B2AE60
		public static DebugContextScope SetDebugContextInfo_MustUseUsing(string info, ELogLevel logLevelMask = ELogLevel.All /* Metadata: 0x02080542 */) => default; // 0x0000000184B273B0-0x0000000184B27550
		public static string GetDebugContextInfo(ELogLevel logLevelMask = ELogLevel.All /* Metadata: 0x02080543 */) => default; // 0x000000018734E644-0x000000018734E684
		public static void PushPing(int ping) {} // 0x0000000185F77890-0x0000000185F778F0
		public static void PushPlayerPos(Vector3 pos) {} // 0x0000000185492010-0x0000000185492020
		public static void Init() {} // 0x00000001844086E0-0x0000000184408790
		private static void _AddCustomGameLoop(ref PlayerLoopSystem playerLoop) {} // 0x0000000185492010-0x0000000185492020
		private static void AddPlayerLoop(PlayerLoopSystem method, ref PlayerLoopSystem playerLoop, string categoryName, string systemName, bool last = false /* Metadata: 0x02080544 */, bool before = false /* Metadata: 0x02080545 */) {} // 0x00000001853DB4B0-0x00000001853DB4F0
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop) => default; // 0x0000000187353C24-0x0000000187353C60
		private static void _OnApplicationQuit() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Beyond.Log
{
	[Serializable]
	public struct BitArray256 // TypeDefIndex: 59210
	{
		// Fields
		private ulong data1; // 0x00
		private ulong data2; // 0x08
		private ulong data3; // 0x10
		private ulong data4; // 0x18
	
		// Properties
		public uint capacity { get => default; } // 0x0000000185FB04F0-0x0000000185FB0500 
		public bool allFalse { get => default; } // 0x000000018734962C-0x0000000187349698 
		public bool allTrue { get => default; } // 0x0000000187349698-0x0000000187349704 
		public string humanizedData { get => default; } // 0x0000000187349704-0x0000000187349A00 
		public bool this[byte index] { get => default; set {} } // 0x0000000187349624-0x000000018734962C 0x0000000187349DEC-0x0000000187349DF8
	
		// Constructors
		public BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4) : this() {
			data1 = default;
			data2 = default;
			data3 = default;
			data4 = default;
		} // 0x0000000185FB04D0-0x0000000185FB04F0
		public BitArray256(IEnumerable<uint> bitIndexTrue) : this() {
			data1 = default;
			data2 = default;
			data3 = default;
			data4 = default;
		} // 0x0000000187349530-0x0000000187349624
	
		// Methods
		public static BitArray256 operator ~(BitArray256 a) => default; // 0x0000000187349D48-0x0000000187349DEC
		public static BitArray256 operator |(BitArray256 a, BitArray256 b) => default; // 0x0000000187349AF4-0x0000000187349BE8
		public static BitArray256 operator &(BitArray256 a, BitArray256 b) => default; // 0x0000000187349A00-0x0000000187349AF4
		public static bool operator ==(BitArray256 a, BitArray256 b) => default; // 0x0000000187349BE8-0x0000000187349C98
		public static bool operator !=(BitArray256 a, BitArray256 b) => default; // 0x0000000187349C98-0x0000000187349D48
		public override bool Equals(object obj) => default; // 0x00000001873490D4-0x00000001873491B8
		public override int GetHashCode() => default; // 0x0000000187349244-0x00000001873492D4
		public bool GetBool(byte index) => default; // 0x00000001873491B8-0x0000000187349244
		public void SetBool(uint index, bool value) {} // 0x000000018734938C-0x0000000187349470
		public void SetAllTrue() {} // 0x0000000187349330-0x000000018734938C
		public void SetAllFalse() {} // 0x00000001873492D4-0x0000000187349330
		public static BitArray256 AllTrue() => default; // 0x0000000184F30FA0-0x0000000184F31000
		public static BitArray256 AllFalse() => default; // 0x0000000187349058-0x00000001873490D4
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x0000000187349470-0x00000001873494D8
		public int __iFixBaseProxy_GetHashCode() => default; // 0x00000001873494D8-0x0000000187349530
	}

	public class ConsoleLogger : Beyond.Log.ILogger // TypeDefIndex: 59211
	{
		// Fields
		public static readonly string LOG_TAG; // 0x00
	
		// Constructors
		public ConsoleLogger() {} // 0x0000000185492010-0x0000000185492020
		static ConsoleLogger() {} // 0x0000000185F7D4A0-0x0000000185F7D500
	
		// Methods
		private static bool _CheckIsMainThread() => default; // 0x0000000187349DF8-0x0000000187349E54
		private static string _GetCurrentThreadName() => default; // 0x0000000187349EA8-0x0000000187349EFC
		private static int _GetCurrentThreadID() => default; // 0x0000000187349E54-0x0000000187349EA8
		public void Log(ref FLogMessage msg) {} // 0x00000001841C90F0-0x00000001841C9200
		private static void LogToUnity(ELogLevel level, string msg, Exception exception, UnityEngine.Object context) {} // 0x00000001841C8F90-0x00000001841C90F0
		private static string _BuildLogForRuntime(long msgTime, int frameCount, string message, ELogChannel channel, EColorTag color, ELogLevel logLevel) => default; // 0x00000001841C9200-0x00000001841C93D0
	}

	public struct FLogMessage // TypeDefIndex: 59212
	{
		// Fields
		public string message; // 0x00
		public long msgTime; // 0x08
		public Exception exception; // 0x10
		public ELogLevel logLevel; // 0x18
		public EColorTag colorTag; // 0x19
		public ELogChannel channel; // 0x1A
		public UnityEngine.Object context; // 0x20
		public int ping; // 0x28
		public int frameCount; // 0x2C
		public Vector3 playerPos; // 0x30
	
		// Methods
		public static FLogMessage CreateFromUnityLogCallback(ELogChannel channel, string message, string stacktrace, UnityEngine.LogType type) => default; // 0x0000000184F2F670-0x0000000184F2F860
	}

	public interface ILogger // TypeDefIndex: 59213
	{
		// Methods
		void Log(ref FLogMessage msg);
	}

	public class LocalLogger // TypeDefIndex: 59214
	{
		// Fields
		private static int mainThreadId; // 0x00
		private static bool s_initLog; // 0x04
		private static StreamWriter s_StreamWriter; // 0x08
		private static ConcurrentStack<UnSafeString> s_stack; // 0x10
		private static UnSafeString s_mainCache; // 0x18
		private static string s_LogFilePath; // 0x20
		private static string[] s_logTypeString; // 0x28
	
		// Properties
		public static string persistentDataPath { get => default; } // 0x00000001844D05D0-0x00000001844D0650 
	
		// Constructors
		static LocalLogger() {} // 0x0000000185BB8E40-0x0000000185BB9010
		public LocalLogger() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static void SubsystemRegistration() {} // 0x0000000185F79ED0-0x0000000185F79F30
		public static void LogInit(bool forceDebug = false /* Metadata: 0x02080546 */) {} // 0x00000001844CFE30-0x00000001844D05D0
		private static void InitLocalLogger(string path) {} // 0x0000000184A8F890-0x0000000184A90A40
		private static void OnWantsToShutdown() {} // 0x0000000187353404-0x00000001873535D0
		public static string FlushFile() => default; // 0x0000000187353344-0x0000000187353404
		public static string getLogFileLocalPath() => default; // 0x0000000187353830-0x00000001873538E8
		private static void _UnityLogCallback(string condition, string stackTrace, UnityEngine.LogType type) {} // 0x0000000184778670-0x0000000184778890
		private static void _UnityLogCallbackThread(string condition, string stackTrace, UnityEngine.LogType type) {} // 0x0000000184778450-0x0000000184778670
		private static void _GetTime(UnSafeString unSafeString) {} // 0x0000000187353694-0x0000000187353830
		private static void _GetLogType(UnSafeString unSafeString, UnityEngine.LogType type) {} // 0x00000001873535D0-0x0000000187353694
		public static UnSafeString Alloc() => default; // 0x0000000184778890-0x0000000184778AC0
		public static void Release(UnSafeString value) {} // 0x0000000184778AC0-0x0000000184778C50
	}

	public class SceneViewMessageLogger : Beyond.Log.ILogger // TypeDefIndex: 59215
	{
		// Fields
		public bool enabled; // 0x10
	
		// Constructors
		public SceneViewMessageLogger() {} // 0x0000000181B9A230-0x0000000181B9A240
	
		// Methods
		public void Log(ref FLogMessage msg) {} // 0x0000000187353BD0-0x0000000187353C24
		public void Log(ref FLogMessage msg, float lifeTime) {} // 0x0000000187353B68-0x0000000187353BD0
		public void ClearLogs(string msg) {} // 0x0000000187353B18-0x0000000187353B68
		public void ClearLogsRegex(string regexMsg) {} // 0x0000000187353AC8-0x0000000187353B18
	}

	public class UnionLogger : Beyond.Log.ILogger // TypeDefIndex: 59216
	{
		// Fields
		internal Beyond.Log.ILogger s_consoleLogger; // 0x10
		internal Beyond.Log.ILogger s_netServerLogger; // 0x18
		private const int MAX_MSG_LEN = 2000; // Metadata: 0x02080547
	
		// Constructors
		public UnionLogger() {} // 0x0000000185A30760-0x0000000185A30A70
	
		// Methods
		public void SetServerLogger(Beyond.Log.ILogger log) {} // 0x0000000184F30ED0-0x0000000184F30F10
		public void Log(ref FLogMessage msg) {} // 0x00000001841C9530-0x00000001841C9650
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59217
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64320-0x0000000185F64390
	
		// Methods
		public string __Gen_Wrap_0(EColorTag P0) => default; // 0x000000018734EFB4-0x000000018734F090
		public string __Gen_Wrap_1(ELogChannel P0) => default; // 0x000000018734FA94-0x000000018734FB70
		public void __Gen_Wrap_2(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public void __Gen_Wrap_3() {} // 0x0000000187350FD4-0x000000018735105C
		public void __Gen_Wrap_4(ref FLogMessage P0) {} // 0x0000000187351BF4-0x0000000187351D4C
		public void __Gen_Wrap_5(object P0, object P1) {} // 0x00000001873527E8-0x00000001873528C4
		public void __Gen_Wrap_6(ELogLevel P0) {} // 0x0000000187352FF8-0x00000001873530A4
		public bool __Gen_Wrap_7(ELogLevel P0) => default; // 0x00000001873530A4-0x0000000187353174
		public void __Gen_Wrap_8(ELogChannel P0, ELogLevel P1, bool P2) {} // 0x0000000187353174-0x0000000187353258
		public bool __Gen_Wrap_9(ELogChannel P0, ELogLevel P1) => default; // 0x0000000187353258-0x0000000187353344
		public void __Gen_Wrap_10(ELogChannel P0, ELogLevel P1, EColorTag P2, object P3, object P4, object P5) {} // 0x000000018734F090-0x000000018734F1B8
		public void __Gen_Wrap_11(ELogChannel P0, EColorTag P1, object P2, object P3, object P4) {} // 0x000000018734F1B8-0x000000018734F2D0
		public void __Gen_Wrap_12(ELogChannel P0, object P1) {} // 0x000000018734F2D0-0x000000018734F3AC
		public void __Gen_Wrap_13(ELogChannel P0, EColorTag P1, object P2) {} // 0x000000018734F3AC-0x000000018734F4A4
		public void __Gen_Wrap_14(ELogChannel P0, EColorTag P1, object P2, object P3) {} // 0x000000018734F4A4-0x000000018734F5AC
		public void __Gen_Wrap_15(ELogChannel P0, object P1, object P2) {} // 0x000000018734F5AC-0x000000018734F690
		public void __Gen_Wrap_16(object P0, object P1, object P2) {} // 0x000000018734F690-0x000000018734F774
		public void __Gen_Wrap_17(object P0, object P1, object P2, object P3) {} // 0x000000018734F774-0x000000018734F86C
		public void __Gen_Wrap_18(object P0, object P1, object P2, object P3, object P4) {} // 0x000000018734F86C-0x000000018734F97C
		public void __Gen_Wrap_19(object P0, object P1, object P2, object P3, object P4, object P5) {} // 0x000000018734F97C-0x000000018734FA94
		public void __Gen_Wrap_20(object P0, object P1, object P2, object P3, object P4, object P5, object P6) {} // 0x000000018734FB70-0x000000018734FC98
		public void __Gen_Wrap_21(object P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7) {} // 0x000000018734FC98-0x000000018734FDD0
		public void __Gen_Wrap_22(ELogChannel P0, object P1, object P2, object P3) {} // 0x000000018734FDD0-0x000000018734FEC8
		public void __Gen_Wrap_23(ELogChannel P0, object P1, object P2, object P3, object P4) {} // 0x000000018734FEC8-0x000000018734FFD4
		public void __Gen_Wrap_24(ELogChannel P0, object P1, object P2, object P3, object P4, object P5) {} // 0x000000018734FFD4-0x00000001873500EC
		public void __Gen_Wrap_25(ELogChannel P0, object P1, object P2, object P3, object P4, object P5, object P6) {} // 0x00000001873500EC-0x0000000187350214
		public void __Gen_Wrap_26(ELogChannel P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7) {} // 0x0000000187350214-0x000000018735034C
		public void __Gen_Wrap_27(ELogChannel P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8) {} // 0x000000018735034C-0x0000000187350494
		public void __Gen_Wrap_28(ELogChannel P0, EnableLogType P1, EColorTag P2, object P3, object P4) {} // 0x0000000187350494-0x00000001873505AC
		public void __Gen_Wrap_29(EnableLogType P0, object P1) {} // 0x00000001873505AC-0x0000000187350688
		public void __Gen_Wrap_30(EnableLogType P0, ELogChannel P1, object P2) {} // 0x0000000187350688-0x0000000187350780
		public void __Gen_Wrap_31(EnableLogType P0, ELogChannel P1, EColorTag P2, object P3) {} // 0x0000000187350780-0x0000000187350878
		public void __Gen_Wrap_32(EnableLogType P0, ELogChannel P1, EColorTag P2, object P3, object P4) {} // 0x0000000187350878-0x0000000187350984
		public void __Gen_Wrap_33(bool P0) {} // 0x0000000187350984-0x0000000187350A44
		public void __Gen_Wrap_34(ELogLevel P0, ELogChannel P1, object P2, float P3) {} // 0x0000000187350A44-0x0000000187350B3C
		public void __Gen_Wrap_35(ELogChannel P0, float P1, object P2) {} // 0x0000000187350B3C-0x0000000187350C20
		public void __Gen_Wrap_36(ELogLevel P0, ELogChannel P1, object P2, object P3) {} // 0x0000000187350C20-0x0000000187350D18
		public void __Gen_Wrap_37(ELogLevel P0, ELogChannel P1, EColorTag P2, object P3, object P4) {} // 0x0000000187350D18-0x0000000187350E24
		public DLogger.DebugContext __Gen_Wrap_38() => default; // 0x0000000187350E24-0x0000000187350EDC
		public DLogger.DebugContextScope __Gen_Wrap_39(object P0, ELogLevel P1) => default; // 0x0000000187350EDC-0x0000000187350FD4
		public string __Gen_Wrap_40(ELogLevel P0) => default; // 0x000000018735105C-0x0000000187351138
		public bool __Gen_Wrap_42(ref PlayerLoopSystem P0) => default; // 0x0000000187351138-0x0000000187351294
		public void __Gen_Wrap_43(PlayerLoopSystem P0, ref PlayerLoopSystem P1, object P2, object P3, bool P4, bool P5) {} // 0x0000000187351294-0x000000018735146C
		public void __Gen_Wrap_44(ref PlayerLoopSystem P0) {} // 0x000000018735146C-0x00000001873515B8
		public void __Gen_Wrap_45(ref DLogger.DebugContextScope P0) {} // 0x00000001873515B8-0x00000001873516D0
		public bool __Gen_Wrap_46(ref BitArray256 P0) => default; // 0x00000001873516D0-0x0000000187351810
		public string __Gen_Wrap_47(ref BitArray256 P0) => default; // 0x0000000187351810-0x0000000187351960
		public BitArray256 __Gen_Wrap_48(BitArray256 P0) => default; // 0x0000000187351960-0x0000000187351A8C
		public BitArray256 __Gen_Wrap_49(BitArray256 P0, BitArray256 P1) => default; // 0x0000000187351A8C-0x0000000187351BF4
		public bool __Gen_Wrap_50(BitArray256 P0, BitArray256 P1) => default; // 0x0000000187351D4C-0x0000000187351E80
		public bool __Gen_Wrap_51(ref BitArray256 P0, object P1) => default; // 0x0000000187351E80-0x0000000187351FDC
		public int __Gen_Wrap_52(ref BitArray256 P0) => default; // 0x0000000187351FDC-0x000000018735211C
		public bool __Gen_Wrap_53(ref BitArray256 P0, byte P1) => default; // 0x000000018735211C-0x0000000187352278
		public void __Gen_Wrap_54(ref BitArray256 P0, uint P1, bool P2) {} // 0x0000000187352278-0x00000001873523DC
		public void __Gen_Wrap_55(ref BitArray256 P0) {} // 0x00000001873523DC-0x000000018735250C
		public BitArray256 __Gen_Wrap_56() => default; // 0x000000018735250C-0x0000000187352600
		public bool __Gen_Wrap_57() => default; // 0x0000000187352600-0x0000000187352698
		public string __Gen_Wrap_58() => default; // 0x0000000187352698-0x0000000187352750
		public int __Gen_Wrap_59() => default; // 0x0000000187352750-0x00000001873527E8
		public string __Gen_Wrap_60(long P0, int P1, object P2, ELogChannel P3, EColorTag P4, ELogLevel P5) => default; // 0x00000001873528C4-0x0000000187352A08
		public void __Gen_Wrap_61(ELogLevel P0, object P1, object P2, object P3) {} // 0x000000018734FDD0-0x000000018734FEC8
		public void __Gen_Wrap_62(object P0, ref FLogMessage P1) {} // 0x0000000187352A08-0x0000000187352B7C
		public FLogMessage __Gen_Wrap_63(ELogChannel P0, object P1, object P2, UnityEngine.LogType P3) => default; // 0x0000000187352B7C-0x0000000187352CCC
		public UnSafeString __Gen_Wrap_64() => default; // 0x0000000187352CCC-0x0000000187352D84
		public void __Gen_Wrap_65(object P0, object P1, UnityEngine.LogType P2) {} // 0x0000000187352D84-0x0000000187352E68
		public void __Gen_Wrap_66(object P0, ref FLogMessage P1, float P2) {} // 0x0000000187352E68-0x0000000187352FF8
	}

	public class WrappersManagerImpl // TypeDefIndex: 59218
	{
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000187353C60-0x0000000187353D64
		public static bool IsPatched(int id) => default; // 0x00000001841C97E0-0x00000001841C9850
	}
}
