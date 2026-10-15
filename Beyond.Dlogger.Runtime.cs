/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Beyond;
using Beyond.Log;
using IFix.Core;
using UnityEngine;
using UnityEngine.LowLevel;

// Image 69: Beyond.Dlogger.Runtime.dll - Assembly: Beyond.Dlogger.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89511-89532

namespace Beyond
{
	public enum ELogChannel : byte // TypeDefIndex: 89512
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
		TyphoeaArchery = 100,
		GlobalTag = 101,
		MoveSync = 102,
		SubVersionControl = 103,
		SimulationTraining = 104,
		BlackScreen = 105,
		ParkourGame = 106,
		GambleBattle = 107,
		ServerGameTag = 108,
		Max = 109
	}

	[Flags]
	public enum ELogLevel : byte // TypeDefIndex: 89513
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

	public enum EColorTag : byte // TypeDefIndex: 89514
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

	public static class LogDefine // TypeDefIndex: 89515
	{
		// Fields
		private static Dictionary<int, string> s_logNameCacheDict; // 0x00
	
		// Constructors
		static LogDefine(); // 0x0000000187177B70-0x0000000187177C00
	
		// Methods
		public static string ConvertColorTagToName(EColorTag colorTag); // 0x0000000188800558-0x0000000188800724
	
		// Extension methods
		public static string ConvertLogChannelToName(this ELogChannel logChannel); // 0x000000018583DEE0-0x000000018583DFF0
	}

	public enum EnableLogType // TypeDefIndex: 89516
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

	public static class DLogger // TypeDefIndex: 89524
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
		[CompilerGenerated]
		private static int _FrameCountThreadSafe_k__BackingField; // 0x60
		[CompilerGenerated]
		private static int _LogPing_k__BackingField; // 0x64
		[CompilerGenerated]
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
		public static ELogLevel[] s_enabledLogChannel { get; } // 0x00000001887FF9D8-0x00000001887FFA54 
		public static int FrameCountThreadSafe { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001887FF8E0-0x00000001887FF930 0x00000001887FFD6C-0x00000001887FFDC0
		public static int LogPing { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001887FF930-0x00000001887FF980 0x00000001887FFDC0-0x00000001887FFE14
		public static Vector3 LogPlayerPos { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001887FF980-0x00000001887FF9D8 0x00000001887FFE14-0x00000001887FFE68
	
		// Events
		public static event LogCallback s_logCriticalAndExceptionMessageReceived {
			add; // 0x0000000186E24070-0x0000000186E24170
			remove; // 0x00000001887FFA54-0x00000001887FFB5C
		}
		public static event LogCallback s_onBeforeLogError {
			add; // 0x00000001887FF7D8-0x00000001887FF8E0
			remove; // 0x00000001887FFC64-0x00000001887FFD6C
		}
		public static event LogCallback s_onBeforeLogCriticalAndException {
			add; // 0x00000001887FF6D0-0x00000001887FF7D8
			remove; // 0x00000001887FFB5C-0x00000001887FFC64
		}
	
		// Nested types
		public class Options // TypeDefIndex: 89517
		{
			// Fields
			public Dictionary<EnableLogType, bool> remoteSet; // 0x10
	
			// Constructors
			public Options(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public delegate void LogCallback(ref FLogMessage msg); // TypeDefIndex: 89518; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public class DebugContext // TypeDefIndex: 89519
		{
			// Fields
			public ELogLevel logLevelMask; // 0x10
			public string info; // 0x18
	
			// Constructors
			public DebugContext(); // 0x0000000187232F40-0x0000000187232F50
		}
	
		[IsReadOnly]
		public struct DebugContextScope : IDisposable // TypeDefIndex: 89520
		{
			// Methods
			public void Dispose(); // 0x00000001863959D0-0x0000000186395B50
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 89521
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static PlayerLoopSystem.UpdateFunction __9__432_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E7280-0x00000001871E72E0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __AddCustomGameLoop_b__432_0(); // 0x0000000185BBF4D0-0x0000000185BBF580
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass433_0 // TypeDefIndex: 89522
		{
			// Fields
			public string categoryName; // 0x10
			public string systemName; // 0x18
	
			// Constructors
			public __c__DisplayClass433_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AddPlayerLoop_b__0(PlayerLoopSystem s); // 0x0000000186672600-0x0000000186672640
			internal bool _AddPlayerLoop_b__1(PlayerLoopSystem h); // 0x0000000188800810-0x000000018880084C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass434_0 // TypeDefIndex: 89523
		{
			// Fields
			public System.Type t; // 0x10
			public Func<PlayerLoopSystem, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass434_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CheckRegist_b__0(PlayerLoopSystem x); // 0x0000000186A20610-0x0000000186A20650
		}
	
		// Constructors
		static DLogger(); // 0x0000000186CEDAE0-0x0000000186CEDE70
	
		// Methods
		public static void SetImportantLogConfig(Options options); // 0x000000018679D870-0x000000018679DA80
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _RunOnStart(); // 0x0000000187102A50-0x0000000187102B20
		private static void UpdateLogCount(ref FLogMessage msg); // 0x000000018583DBD0-0x000000018583DCB0
		public static void SetServerLogger(Beyond.Log.ILogger logger); // 0x0000000185B82DD0-0x0000000185B82E60
		public static void SetLogLevel(ELogLevel level); // 0x00000001887FEDA4-0x00000001887FEE28
		public static bool CheckLogLevel(ELogLevel level); // 0x0000000185DBDAF0-0x0000000185DBDB50
		public static void SetLogChannelEnabled(ELogChannel channel, ELogLevel level, bool val); // 0x0000000186FC4C60-0x0000000186FC4D10
		public static bool CheckLogChannelEnabled(ELogChannel channel, ELogLevel level = ELogLevel.None | ELogLevel.Info /* Metadata: 0x0264922B */); // 0x0000000185DBD9F0-0x0000000185DBDAF0
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(0)]
		public static void Log(string message); // 0x00000001887FE728-0x00000001887FE7BC
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T>(string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(1)]
		public static void Log(ELogChannel channel, string message); // 0x00000001887FE680-0x00000001887FE728
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T>(ELogChannel channel, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(2)]
		public static void Log(ELogChannel channel, EColorTag color, string message); // 0x00000001887FEC50-0x00000001887FED08
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T>(ELogChannel channel, EColorTag color, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(3)]
		public static void Log(UnityEngine.Object context, string message); // 0x00000001887FEBAC-0x00000001887FEC50
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T>(UnityEngine.Object context, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("ENABLE_LOG")]
		[Conditional("UNITY_EDITOR")]
		[IDTag(4)]
		public static void Log(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x00000001887FEA68-0x00000001887FEBAC
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(0)]
		public static void LogEditorAlwaysPrint(string message); // 0x00000001887FCCAC-0x00000001887FCCE0
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T>(string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2>(string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(1)]
		public static void LogEditorAlwaysPrint(ELogChannel channel, string message); // 0x00000001887FCC3C-0x00000001887FCC74
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T>(ELogChannel channel, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(2)]
		public static void LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, string message); // 0x00000001887FCD30-0x00000001887FCD78
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T>(ELogChannel channel, EColorTag color, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(3)]
		public static void LogEditorAlwaysPrint(UnityEngine.Object context, string message); // 0x00000001887FCC74-0x00000001887FCCAC
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T>(UnityEngine.Object context, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(4)]
		public static void LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x00000001887FCCE0-0x00000001887FCD30
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		[IDTag(0)]
		public static void LogWarning(string message); // 0x00000001887FE5EC-0x00000001887FE680
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		[IDTag(1)]
		public static void LogWarning(UnityEngine.Object context, string message); // 0x00000001887FE2B0-0x00000001887FE354
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T>(string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2>(string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("ENABLE_WARNING")]
		[Conditional("UNITY_EDITOR")]
		[IDTag(2)]
		public static void LogWarning(ELogChannel channel, string message); // 0x00000001887FE418-0x00000001887FE534
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T>(ELogChannel channel, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		[IDTag(3)]
		public static void LogWarning(ELogChannel channel, EColorTag color, string message); // 0x00000001887FE534-0x00000001887FE5EC
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T>(ELogChannel channel, EColorTag color, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		[IDTag(4)]
		public static void LogWarning(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x00000001887FE354-0x00000001887FE418
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(0)]
		public static void LogError(string message); // 0x0000000186F902B0-0x0000000186F90360
		[IDTag(0)]
		public static void LogErrorWithLuaStack(ELogChannel channel, string message); // 0x00000001887FD400-0x00000001887FD610
		public static void LogErrorWithLuaStack<T1>(ELogChannel channel, string message, T1 param1);
		public static void LogErrorWithLuaStack<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		public static void LogErrorWithLuaStack<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		[IDTag(1)]
		public static void LogErrorWithLuaStack(string message); // 0x00000001887FD380-0x00000001887FD400
		public static void LogError<T>(string message, T param1);
		public static void LogError<T1, T2>(string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(1)]
		public static void LogError(ELogChannel channel, string message); // 0x0000000186074790-0x0000000186074850
		public static void LogError<T>(ELogChannel channel, string message, T param1);
		public static void LogError<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(2)]
		public static void LogError(ELogChannel channel, EColorTag color, string message); // 0x00000001887FD888-0x00000001887FD95C
		public static void LogError<T>(ELogChannel channel, EColorTag color, string message, T param1);
		public static void LogError<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(3)]
		public static void LogError(UnityEngine.Object context, string message); // 0x00000001887FD610-0x00000001887FD6D0
		public static void LogError<T>(UnityEngine.Object context, string message, T param1);
		public static void LogError<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(4)]
		public static void LogError(ELogChannel channel, UnityEngine.Object context, string message); // 0x00000001887FD7B8-0x00000001887FD888
		public static void LogError<T>(ELogChannel channel, UnityEngine.Object context, string message, T param1);
		public static void LogError<T1, T2>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(5)]
		public static void LogError(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x00000001887FD6D0-0x00000001887FD7B8
		public static void LogError<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1);
		public static void LogError<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(0)]
		public static void IFixLogError(string message); // 0x00000001887FBADC-0x00000001887FBB8C
		[IDTag(1)]
		public static void IFixLogError(string message, string param1); // 0x00000001887FB584-0x00000001887FB690
		[IDTag(2)]
		public static void IFixLogError(string message, string param1, string param2); // 0x00000001887FB9C8-0x00000001887FBADC
		[IDTag(3)]
		public static void IFixLogError(string message, string param1, string param2, string param3); // 0x00000001887FC1E4-0x00000001887FC304
		[IDTag(4)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4); // 0x00000001887FC0BC-0x00000001887FC1E4
		[IDTag(5)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5); // 0x00000001887FBCB0-0x00000001887FBDF0
		[IDTag(6)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5, string param6); // 0x00000001887FB438-0x00000001887FB584
		[IDTag(7)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5, string param6, string param7); // 0x00000001887FB690-0x00000001887FB7F0
		[IDTag(8)]
		public static void IFixLogError(ELogChannel channel, string message); // 0x00000001887FB908-0x00000001887FB9C8
		[IDTag(9)]
		public static void IFixLogError(ELogChannel channel, string message, string param1); // 0x00000001887FB7F0-0x00000001887FB908
		[IDTag(10)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2); // 0x00000001887FBB8C-0x00000001887FBCB0
		[IDTag(11)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3); // 0x00000001887FC444-0x00000001887FC578
		[IDTag(12)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4); // 0x00000001887FC304-0x00000001887FC444
		[IDTag(13)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5); // 0x00000001887FBDF0-0x00000001887FBF44
		[IDTag(14)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5, string param6); // 0x00000001887FC578-0x00000001887FC6D8
		[IDTag(15)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5, string param6, string param7); // 0x00000001887FBF44-0x00000001887FC0BC
		[IDTag(0)]
		public static void LogErrorWithFilter(string message, string filter); // 0x00000001887FD210-0x00000001887FD2B0
		public static void LogErrorWithFilter<T>(string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(1)]
		public static void LogErrorWithFilter(ELogChannel channel, string message, string filter); // 0x00000001887FD15C-0x00000001887FD210
		public static void LogErrorWithFilter<T>(ELogChannel channel, string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(2)]
		public static void LogErrorWithFilter(ELogChannel channel, EColorTag color, string message, string filter); // 0x00000001887FCF68-0x00000001887FD028
		public static void LogErrorWithFilter<T>(ELogChannel channel, EColorTag color, string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(3)]
		public static void LogErrorWithFilter(UnityEngine.Object context, string message, string filter); // 0x00000001887FCEB4-0x00000001887FCF68
		public static void LogErrorWithFilter<T>(UnityEngine.Object context, string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(4)]
		public static void LogErrorWithFilter(ELogChannel channel, UnityEngine.Object context, string message, string filter); // 0x00000001887FD028-0x00000001887FD15C
		public static void LogErrorWithFilter<T>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(5)]
		public static void LogErrorWithFilter(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x00000001887FD2B0-0x00000001887FD380
		public static void LogErrorWithFilter<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(0)]
		public static void LogCritical(string message); // 0x00000001887FCB8C-0x00000001887FCC3C
		public static void LogCritical<T>(string message, T param1);
		public static void LogCritical<T1, T2>(string message, T1 param1, T2 param2);
		public static void LogCritical<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3);
		public static void LogCritical<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogCritical<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(1)]
		public static void LogCritical(UnityEngine.Object context, string message); // 0x00000001887FC9F8-0x00000001887FCAB8
		public static void LogCritical<T>(UnityEngine.Object context, string message, T param1);
		public static void LogCritical<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogCritical<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogCritical<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogCritical<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(2)]
		public static void LogCritical(ELogChannel channel, UnityEngine.Object context, string message); // 0x00000001887FC810-0x00000001887FC938
		[IDTag(3)]
		public static void LogCritical(ELogChannel channel, string message); // 0x00000001887FC938-0x00000001887FC9F8
		public static void LogCritical<T>(ELogChannel channel, string message, T param1);
		public static void LogCritical<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(4)]
		public static void LogCritical(ELogChannel channel, EColorTag color, string message); // 0x00000001887FCAB8-0x00000001887FCB8C
		public static void LogCritical<T>(ELogChannel channel, EColorTag color, string message, T param1);
		public static void LogCritical<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2);
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3);
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(5)]
		public static void LogCritical(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x00000001887FC6D8-0x00000001887FC810
		public static void LogCritical<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1);
		public static void LogCritical<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		public static void LogCritical<T>(ELogChannel channel, UnityEngine.Object context, string message, T param1);
		public static void LogCritical<T1, T2>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(1)]
		public static void LogException(Exception e); // 0x00000001887FDBBC-0x00000001887FDC48
		[IDTag(2)]
		public static void LogException(UnityEngine.Object context, Exception e); // 0x00000001887FDC48-0x00000001887FDCE4
		[IDTag(3)]
		public static void LogException(ELogChannel channel, Exception e); // 0x0000000186E42550-0x0000000186E425E0
		[IDTag(4)]
		public static void LogException(ELogChannel channel, EColorTag color, Exception e); // 0x00000001887FDB0C-0x00000001887FDBBC
		[IDTag(0)]
		public static void LogException(ELogChannel channel, EColorTag color, UnityEngine.Object context, Exception e); // 0x0000000186E425E0-0x0000000186E427B0
		[IDTag(0)]
		public static void LogImportant(EnableLogType enableLogType, string message); // 0x00000001859BD080-0x00000001859BD110
		public static void LogImportant<T>(EnableLogType enableLogType, string message, T param1);
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, string message, T1 param1, T2 param2);
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3);
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(1)]
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, string message); // 0x0000000185DBD640-0x0000000185DBD6C0
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, string message, T param1);
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2);
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(2)]
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message); // 0x00000001887FDCE4-0x00000001887FDDA0
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T param1);
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2);
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3);
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(3)]
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x00000001887FDDA0-0x00000001887FDE6C
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1);
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _Log(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x00000001887FF55C-0x00000001887FF630
		private static void _Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		private static void _LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x00000001887FF3B4-0x00000001887FF488
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		private static void _LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _LogWarning(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x00000001887FF488-0x00000001887FF55C
		private static void _LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _LogErrorWithFilter(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x0000000185DBC890-0x0000000185DBC940
		private static void _LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _LogImportant(ELogChannel channel, EnableLogType enableLogType, EColorTag color, UnityEngine.Object context, string message); // 0x0000000185DBD6C0-0x0000000185DBD7E0
		private static void _LogImportant<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EnableLogType enableLogType, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _LogCritical(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x00000001887FF2E0-0x00000001887FF3B4
		private static void _LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _ApplyLog(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x0000000185DBDB50-0x0000000185DBDC80
		private static void _LogWithFilter(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x0000000185DBD7E0-0x0000000185DBD8A0
		private static void _ApplyLog<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _LogWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogToConsole(ELogChannel channel, string message); // 0x00000001887FDE6C-0x00000001887FDFA4
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogToConsole<T>(ELogChannel channel, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogToConsole<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogErrorToConsole(ELogChannel channel, string message); // 0x00000001887FCD78-0x00000001887FCEB4
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogErrorToConsole<T>(ELogChannel channel, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogErrorToConsole<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogErrorToConsole<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogErrorToConsole<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogExceptionToConsole(ELogChannel channel, Exception e); // 0x00000001887FD95C-0x00000001887FDB0C
		[Conditional("UNITY_EDITOR")]
		public static void SetLogToSceneViewEnabled(bool enabled); // 0x00000001887FEE28-0x00000001887FEEBC
		[Conditional("UNITY_EDITOR")]
		private static void LogToSceneViewImpl(ELogLevel logLevel, ELogChannel channel, string message, float lifeTime); // 0x00000001887FE094-0x00000001887FE1C0
		[Conditional("UNITY_EDITOR")]
		public static void ClearSceneViewLogs(string message); // 0x00000001887FB39C-0x00000001887FB438
		[Conditional("UNITY_EDITOR")]
		public static void ClearSceneViewLogsRegex(string message); // 0x00000001887FB300-0x00000001887FB39C
		[Conditional("UNITY_EDITOR")]
		[IDTag(0)]
		public static void LogToSceneView(ELogChannel channel, float lifeTime, string message); // 0x00000001887FE270-0x00000001887FE2B0
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneView(ELogChannel channel, string message); // 0x00000001887FE238-0x00000001887FE270
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneView<T>(ELogChannel channel, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneView<T>(ELogChannel channel, float lifeTime, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneView<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneView<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[IDTag(0)]
		public static void LogToSceneViewWarning(ELogChannel channel, float lifeTime, string message); // 0x00000001887FE1C0-0x00000001887FE200
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneViewWarning(ELogChannel channel, string message); // 0x00000001887FE200-0x00000001887FE238
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewWarning<T>(ELogChannel channel, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewWarning<T>(ELogChannel channel, float lifeTime, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewWarning<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewWarning<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[IDTag(0)]
		public static void LogToSceneViewError(ELogChannel channel, float lifeTime, string message); // 0x00000001887FE054-0x00000001887FE094
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneViewError(ELogChannel channel, string message); // 0x00000001887FE01C-0x00000001887FE054
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewError<T>(ELogChannel channel, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewError<T>(ELogChannel channel, float lifeTime, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewError<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewError<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[IDTag(0)]
		public static void LogToSceneViewCritical(ELogChannel channel, float lifeTime, string message); // 0x00000001887FDFA4-0x00000001887FDFE4
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneViewCritical(ELogChannel channel, string message); // 0x00000001887FDFE4-0x00000001887FE01C
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T>(ELogChannel channel, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T>(ELogChannel channel, float lifeTime, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2);
		[IDTag(5)]
		public static void Log(ELogLevel logLevel, ELogChannel channel, string message, UnityEngine.Object context = null); // 0x00000001887FE7BC-0x00000001887FE90C
		[IDTag(6)]
		public static void Log(ELogLevel logLevel, ELogChannel channel, EColorTag color, string message, UnityEngine.Object context = null); // 0x00000001887FE90C-0x00000001887FEA68
		private static void _DefaultLog(ref FLogMessage msg); // 0x00000001887FEF18-0x00000001887FF2E0
		private static void _ConsoleLog(ref FLogMessage msg); // 0x00000001887FEEBC-0x00000001887FEF18
		private static void _SceneViewLog(ref FLogMessage msg, float time); // 0x00000001887FF660-0x00000001887FF6D0
		private static DebugContext _AllocateDebugContext(); // 0x0000000185653580-0x0000000185653650
		public static DebugContextScope SetDebugContextInfo_MustUseUsing(string info, ELogLevel logLevelMask = ELogLevel.None | ELogLevel.Info | ELogLevel.Warning | ELogLevel.Error | ELogLevel.Critical | ELogLevel.Important | ELogLevel.Exception | ELogLevel.All /* Metadata: 0x0264922C */); // 0x00000001856534E0-0x0000000185653580
		public static string GetDebugContextInfo(ELogLevel logLevelMask = ELogLevel.None | ELogLevel.Info | ELogLevel.Warning | ELogLevel.Error | ELogLevel.Critical | ELogLevel.Important | ELogLevel.Exception | ELogLevel.All /* Metadata: 0x0264922D */); // 0x000000018583C2C0-0x000000018583C680
		public static void PushPing(int ping); // 0x00000001887FED08-0x00000001887FED50
		public static void PushPlayerPos(Vector3 pos); // 0x00000001887FED50-0x00000001887FEDA4
		public static void Init(); // 0x0000000185BBF2F0-0x0000000185BBF4D0
		private static void _AddCustomGameLoop(ref PlayerLoopSystem playerLoop); // 0x0000000185BBEAB0-0x0000000185BBED20
		private static void AddPlayerLoop(PlayerLoopSystem method, ref PlayerLoopSystem playerLoop, string categoryName, string systemName, bool last = false /* Metadata: 0x0264922E */, bool before = false /* Metadata: 0x0264922F */); // 0x0000000185BBE7F0-0x0000000185BBEAB0
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop); // 0x0000000185BBB0A0-0x0000000185BBB250
		private static void _OnApplicationQuit(); // 0x00000001887FF630-0x00000001887FF660
	}
}

namespace Beyond.Log
{
	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray256 // TypeDefIndex: 89525
	{
		// Fields
		[SerializeField]
		private ulong data1; // 0x00
		[SerializeField]
		private ulong data2; // 0x08
		[SerializeField]
		private ulong data3; // 0x10
		[SerializeField]
		private ulong data4; // 0x18
	
		// Properties
		public uint capacity { get; } // 0x00000001887FAAD4-0x00000001887FAB18 
		public bool allFalse { get; } // 0x00000001887FAA34-0x00000001887FAA84 
		public bool allTrue { get; } // 0x00000001887FAA84-0x00000001887FAAD4 
		public string humanizedData { get; } // 0x00000001887FAB18-0x00000001887FAE20 
		public bool this[byte index] { get => default; set {} } // 0x00000001887FA9F4-0x00000001887FAA34 0x00000001887FB1A8-0x00000001887FB1FC
	
		// Constructors
		public BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4); // 0x0000000187232F20-0x0000000187232F40
		public BitArray256(IEnumerable<uint> bitIndexTrue); // 0x00000001887FA8E8-0x00000001887FA9F4
	
		// Methods
		public static BitArray256 operator ~(BitArray256 a); // 0x00000001887FB110-0x00000001887FB1A8
		public static BitArray256 operator |(BitArray256 a, BitArray256 b); // 0x00000001887FAF04-0x00000001887FAFE8
		public static BitArray256 operator &(BitArray256 a, BitArray256 b); // 0x00000001887FAE20-0x00000001887FAF04
		public static bool operator ==(BitArray256 a, BitArray256 b); // 0x00000001887FAFE8-0x00000001887FB07C
		public static bool operator !=(BitArray256 a, BitArray256 b); // 0x00000001887FB07C-0x00000001887FB110
		public override bool Equals(object obj); // 0x00000001887FA514-0x00000001887FA5FC
		public override int GetHashCode(); // 0x00000001887FA664-0x00000001887FA6E4
		public bool GetBool(byte index); // 0x00000001887FA5FC-0x00000001887FA664
		public void SetBool(uint index, bool value); // 0x00000001887FA76C-0x00000001887FA828
		public void SetAllTrue(); // 0x00000001887FA728-0x00000001887FA76C
		public void SetAllFalse(); // 0x00000001887FA6E4-0x00000001887FA728
		public static BitArray256 AllTrue(); // 0x0000000185B82490-0x0000000185B824E0
		public static BitArray256 AllFalse(); // 0x00000001887FA4B0-0x00000001887FA514
		public bool __iFixBaseProxy_Equals(object P0); // 0x00000001887FA828-0x00000001887FA890
		public int __iFixBaseProxy_GetHashCode(); // 0x00000001887FA890-0x00000001887FA8E8
	}

	public class ConsoleLogger : Beyond.Log.ILogger // TypeDefIndex: 89526
	{
		// Fields
		public static readonly string LOG_TAG; // 0x00
	
		// Constructors
		public ConsoleLogger(); // 0x0000000186805BA0-0x0000000186805BB0
		static ConsoleLogger(); // 0x00000001871EA4B0-0x00000001871EA510
	
		// Methods
		private static bool _CheckIsMainThread(); // 0x00000001887FB1FC-0x00000001887FB258
		private static string _GetCurrentThreadName(); // 0x00000001887FB2AC-0x00000001887FB300
		private static int _GetCurrentThreadID(); // 0x00000001887FB258-0x00000001887FB2AC
		public void Log(ref FLogMessage msg); // 0x000000018583DCB0-0x000000018583DDA0
		private static void LogToUnity(ELogLevel level, string msg, Exception exception, UnityEngine.Object context); // 0x000000018583DFF0-0x000000018583E140
		private static string _BuildLogForRuntime(long msgTime, int frameCount, string message, ELogChannel channel, EColorTag color, ELogLevel logLevel); // 0x000000018583DDA0-0x000000018583DEE0
	}

	public struct FLogMessage // TypeDefIndex: 89527
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
		public static FLogMessage CreateFromUnityLogCallback(ELogChannel channel, string message, string stacktrace, UnityEngine.LogType type); // 0x00000001887FFE68-0x0000000188800060
	}

	public interface ILogger // TypeDefIndex: 89528
	{
		// Methods
		void Log(ref FLogMessage msg);
	}

	public class LocalLogger // TypeDefIndex: 89530
	{
		// Fields
		private static SynchronizationContext s_mainContext; // 0x00
		private static int s_generation; // 0x08
		private static bool s_shutdown; // 0x0C
		private static int mainThreadId; // 0x10
		private static bool s_initLog; // 0x14
		private static StreamWriter s_StreamWriter; // 0x18
		private static TextWriter s_threadSafeStreamWriter; // 0x20
		private static ConcurrentStack<UnSafeString> s_stack; // 0x28
		private static UnSafeString s_mainCache; // 0x30
		private static string s_LogFilePath; // 0x38
		private static string[] s_logTypeString; // 0x40
	
		// Properties
		public static string persistentDataPath { get; } // 0x00000001866474D0-0x0000000186647560 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 89529
		{
			// Fields
			public bool forceDebug; // 0x10
			public int generation; // 0x14
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _LogInit_b__0(object _); // 0x0000000182238270-0x00000001822385D0
		}
	
		// Constructors
		public LocalLogger(); // 0x0000000186805BA0-0x0000000186805BB0
		static LocalLogger(); // 0x0000000186E4E810-0x0000000186E4FC40
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration(); // 0x0000000186643CF0-0x0000000186644CE0
		public static void LogInit(bool forceDebug = false /* Metadata: 0x02649230 */); // 0x0000000186645990-0x00000001866474D0
		private static void InitLocalLogger(string path); // 0x0000000185B83200-0x0000000185B86310
		private static void OnWantsToShutdown(); // 0x000000018880016C-0x0000000188800244
		private static void _DisposeLocalLogger(); // 0x00000001822372D0-0x0000000182238270
		public static string FlushFile(); // 0x0000000188800060-0x000000018880016C
		public static string getLogFileLocalPath(); // 0x00000001888004A4-0x0000000188800558
		private static void _UnityLogCallback(string condition, string stackTrace, UnityEngine.LogType type); // 0x0000000185444D40-0x0000000185445020
		private static void _UnityLogCallbackThread(string condition, string stackTrace, UnityEngine.LogType type); // 0x0000000185444A80-0x0000000185444D40
		private static void _GetTime(UnSafeString unSafeString); // 0x0000000188800308-0x00000001888004A4
		private static void _GetLogType(UnSafeString unSafeString, UnityEngine.LogType type); // 0x0000000188800244-0x0000000188800308
		public static UnSafeString Alloc(); // 0x0000000185445020-0x00000001854451B0
		public static void Release(UnSafeString value); // 0x00000001865D4770-0x00000001865D4820
	}

	public class SceneViewMessageLogger : Beyond.Log.ILogger // TypeDefIndex: 89531
	{
		// Fields
		public bool enabled; // 0x10
	
		// Constructors
		public SceneViewMessageLogger(); // 0x00000001829D07F0-0x00000001829D0800
	
		// Methods
		[IDTag(0)]
		public void Log(ref FLogMessage msg); // 0x00000001888007D8-0x0000000188800810
		[IDTag(1)]
		public void Log(ref FLogMessage msg, float lifeTime); // 0x0000000188800794-0x00000001888007D8
		public void ClearLogs(string msg); // 0x000000018880075C-0x0000000188800794
		public void ClearLogsRegex(string regexMsg); // 0x0000000188800724-0x000000018880075C
	}

	public class UnionLogger : Beyond.Log.ILogger // TypeDefIndex: 89532
	{
		// Fields
		internal Beyond.Log.ILogger s_consoleLogger; // 0x10
		internal Beyond.Log.ILogger s_netServerLogger; // 0x18
		private const int MAX_MSG_LEN = 2000; // Metadata: 0x02649231
	
		// Constructors
		public UnionLogger(); // 0x0000000186CEDE70-0x0000000186CEDEC0
	
		// Methods
		public void SetServerLogger(Beyond.Log.ILogger log); // 0x000000018880084C-0x000000018880088C
		public void Log(ref FLogMessage msg); // 0x000000018583DAF0-0x000000018583DBD0
	}
}
