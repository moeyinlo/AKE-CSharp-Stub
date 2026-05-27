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
using Beyond;
using Beyond.Log;
using IFix.Core;
using UnityEngine;
using UnityEngine.LowLevel;

// Image 62: Beyond.Dlogger.Runtime.dll - Assembly: Beyond.Dlogger.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58048-58070
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond
{
	public enum ELogChannel : byte // TypeDefIndex: 58049
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
		GlobalTag = 96,
		MoveSync = 97,
		Max = 98
	}

	[Flags]
	public enum ELogLevel : byte // TypeDefIndex: 58050
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

	public enum EColorTag : byte // TypeDefIndex: 58051
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

	public static class LogDefine // TypeDefIndex: 58052
	{
		// Fields
		private static Dictionary<int, string> s_logNameCacheDict; // 0x00
	
		// Constructors
		static LogDefine() {} // 0x0000000183CE3C10-0x0000000183CE3CA0
	
		// Methods
		public static string ConvertColorTagToName(EColorTag colorTag) => default; // 0x0000000185164BD0-0x0000000185164DB0
	
		// Extension methods
		public static string ConvertLogChannelToName(this ELogChannel logChannel) => default; // 0x00000001825F4980-0x00000001825F4AE0
	}

	public enum EnableLogType // TypeDefIndex: 58053
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

	public static class DLogger // TypeDefIndex: 58061
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
		public static int ExceptionCount; // 0x74
		public static int CriticalCount; // 0x78
		public static int ErrorCount; // 0x7C
		public static int ImportantCount; // 0x80
		public static int WarningCount; // 0x84
		public static int InfoCount; // 0x88
		public static int PauseCount; // 0x8C
		public static int ReturnLoginCount; // 0x90
	
		// Properties
		public static ELogLevel[] s_enabledLogChannel { get; } // 0x00000001851600BC-0x000000018516010C 
		public static int FrameCountThreadSafe { get; private set; } // 0x000000018515FFC4-0x0000000185160014 0x000000018516040C-0x0000000185160460
		public static int LogPing { get; private set; } // 0x0000000185160014-0x0000000185160064 0x0000000185160460-0x00000001851604B4
		public static Vector3 LogPlayerPos { get; private set; } // 0x0000000185160064-0x00000001851600BC 0x00000001851604B4-0x0000000185160508
	
		// Events
		public static event LogCallback s_logCriticalAndExceptionMessageReceived;
		public static event LogCallback s_onBeforeLogError;
		public static event LogCallback s_onBeforeLogCriticalAndException;
	
		// Nested types
		public class Options // TypeDefIndex: 58054
		{
			// Fields
			public Dictionary<EnableLogType, bool> remoteSet; // 0x10
	
			// Constructors
			public Options() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public delegate void LogCallback(ref FLogMessage msg); // TypeDefIndex: 58055; 0x0000000182149960-0x0000000182149970
	
		public class DebugContext // TypeDefIndex: 58056
		{
			// Fields
			public ELogLevel logLevelMask; // 0x10
			public string info; // 0x18
	
			// Constructors
			public DebugContext() {} // 0x0000000183D4EA50-0x0000000183D4EA60
		}
	
		[IsReadOnly]
		public struct DebugContextScope : IDisposable // TypeDefIndex: 58057
		{
			// Methods
			public void Dispose() {} // 0x0000000185160508-0x0000000185160684
		}
	
		// Constructors
		static DLogger() {} // 0x00000001838A41C0-0x00000001838A4550
	
		// Methods
		public static void SetImportantLogConfig(Options options) {} // 0x00000001836B73C0-0x00000001836B75C0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _RunOnStart() {} // 0x0000000183CABEC0-0x0000000183CABF90
		private static void UpdateLogCount(ref FLogMessage msg) {} // 0x00000001825F4460-0x00000001825F4540
		public static void SetServerLogger(Beyond.Log.ILogger logger) {} // 0x0000000183B6D0E0-0x0000000183B6D170
		public static void SetLogLevel(ELogLevel level) {} // 0x000000018515F3D0-0x000000018515F44C
		public static bool CheckLogLevel(ELogLevel level) => default; // 0x00000001825F4D10-0x00000001825F4D90
		public static void SetLogChannelEnabled(ELogChannel channel, ELogLevel level, bool val) {} // 0x000000018515F314-0x000000018515F3D0
		public static bool CheckLogChannelEnabled(ELogChannel channel, ELogLevel level = ELogLevel.None | ELogLevel.Info /* Metadata: 0x01FDABA9 */) => default; // 0x00000001825F4C00-0x00000001825F4D10
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(0)]
		public static void Log(string message) {} // 0x000000018515EC44-0x000000018515ECCC
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T>(string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(1)]
		public static void Log(ELogChannel channel, string message) {} // 0x000000018515EBAC-0x000000018515EC44
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T>(ELogChannel channel, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(2)]
		public static void Log(ELogChannel channel, EColorTag color, string message) {} // 0x000000018515F100-0x000000018515F1AC
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T>(ELogChannel channel, EColorTag color, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("ENABLE_LOG")]
		[Conditional("UNITY_EDITOR")]
		[IDTag(3)]
		public static void Log(UnityEngine.Object context, string message) {} // 0x000000018515F06C-0x000000018515F100
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T>(UnityEngine.Object context, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(4)]
		public static void Log(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {} // 0x000000018515EF40-0x000000018515F06C
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(0)]
		public static void LogEditorAlwaysPrint(string message) {} // 0x000000018515CEFC-0x000000018515CF3C
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T>(string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2>(string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(1)]
		public static void LogEditorAlwaysPrint(ELogChannel channel, string message) {} // 0x000000018515CE5C-0x000000018515CEAC
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T>(ELogChannel channel, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(2)]
		public static void LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, string message) {} // 0x000000018515CFB0-0x000000018515D014
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T>(ELogChannel channel, EColorTag color, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(3)]
		public static void LogEditorAlwaysPrint(UnityEngine.Object context, string message) {} // 0x000000018515CEAC-0x000000018515CEFC
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T>(UnityEngine.Object context, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(4)]
		public static void LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {} // 0x000000018515CF3C-0x000000018515CFB0
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		[IDTag(0)]
		public static void LogWarning(string message) {} // 0x000000018515EB24-0x000000018515EBAC
		[Conditional("ENABLE_WARNING")]
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogWarning(UnityEngine.Object context, string message) {} // 0x000000018515E814-0x000000018515E8A8
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T>(string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2>(string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		[IDTag(2)]
		public static void LogWarning(ELogChannel channel, string message) {} // 0x000000018515E964-0x000000018515EA78
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T>(ELogChannel channel, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		[IDTag(3)]
		public static void LogWarning(ELogChannel channel, EColorTag color, string message) {} // 0x000000018515EA78-0x000000018515EB24
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T>(ELogChannel channel, EColorTag color, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		[IDTag(4)]
		public static void LogWarning(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {} // 0x000000018515E8A8-0x000000018515E964
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		public static void LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(0)]
		public static void LogError(string message) {} // 0x000000018319B910-0x000000018319B9B0
		[IDTag(0)]
		public static void LogErrorWithLuaStack(ELogChannel channel, string message) {} // 0x000000018515D62C-0x000000018515D82C
		public static void LogErrorWithLuaStack<T1>(ELogChannel channel, string message, T1 param1) {}
		public static void LogErrorWithLuaStack<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogErrorWithLuaStack<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {}
		[IDTag(1)]
		public static void LogErrorWithLuaStack(string message) {} // 0x000000018515D5B0-0x000000018515D62C
		public static void LogError<T>(string message, T param1) {}
		public static void LogError<T1, T2>(string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogError<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogError<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogError<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(1)]
		public static void LogError(ELogChannel channel, string message) {} // 0x000000018515DB6C-0x000000018515DC28
		public static void LogError<T>(ELogChannel channel, string message, T param1) {}
		public static void LogError<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(2)]
		public static void LogError(ELogChannel channel, EColorTag color, string message) {} // 0x000000018515DA9C-0x000000018515DB6C
		public static void LogError<T>(ELogChannel channel, EColorTag color, string message, T param1) {}
		public static void LogError<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(3)]
		public static void LogError(UnityEngine.Object context, string message) {} // 0x000000018515D82C-0x000000018515D8E8
		public static void LogError<T>(UnityEngine.Object context, string message, T param1) {}
		public static void LogError<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogError<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogError<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogError<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(4)]
		public static void LogError(ELogChannel channel, UnityEngine.Object context, string message) {} // 0x000000018515D9CC-0x000000018515DA9C
		public static void LogError<T>(ELogChannel channel, UnityEngine.Object context, string message, T param1) {}
		public static void LogError<T1, T2>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(5)]
		public static void LogError(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {} // 0x000000018515D8E8-0x000000018515D9CC
		public static void LogError<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {}
		public static void LogError<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogError<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(0)]
		public static void IFixLogError(string message) {} // 0x000000018515BD70-0x000000018515BE1C
		[IDTag(1)]
		public static void IFixLogError(string message, string param1) {} // 0x000000018515B834-0x000000018515B93C
		[IDTag(2)]
		public static void IFixLogError(string message, string param1, string param2) {} // 0x000000018515BC60-0x000000018515BD70
		[IDTag(3)]
		public static void IFixLogError(string message, string param1, string param2, string param3) {} // 0x000000018515C454-0x000000018515C56C
		[IDTag(4)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4) {} // 0x000000018515C330-0x000000018515C454
		[IDTag(5)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5) {} // 0x000000018515BF30-0x000000018515C06C
		[IDTag(6)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5, string param6) {} // 0x000000018515B6EC-0x000000018515B834
		[IDTag(7)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5, string param6, string param7) {} // 0x000000018515B93C-0x000000018515BA98
		[IDTag(8)]
		public static void IFixLogError(ELogChannel channel, string message) {} // 0x000000018515BBA4-0x000000018515BC60
		[IDTag(9)]
		public static void IFixLogError(ELogChannel channel, string message, string param1) {} // 0x000000018515BA98-0x000000018515BBA4
		[IDTag(10)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2) {} // 0x000000018515BE1C-0x000000018515BF30
		[IDTag(11)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3) {} // 0x000000018515C6A8-0x000000018515C7D4
		[IDTag(12)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4) {} // 0x000000018515C56C-0x000000018515C6A8
		[IDTag(13)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5) {} // 0x000000018515C06C-0x000000018515C1BC
		[IDTag(14)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5, string param6) {} // 0x000000018515C7D4-0x000000018515C930
		[IDTag(15)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5, string param6, string param7) {} // 0x000000018515C1BC-0x000000018515C330
		[IDTag(0)]
		public static void LogErrorWithFilter(string message, string filter) {} // 0x000000018515D450-0x000000018515D4E4
		public static void LogErrorWithFilter<T>(string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(string message, string filter, T1 param1, T2 param2, T3 param3) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(1)]
		public static void LogErrorWithFilter(ELogChannel channel, string message, string filter) {} // 0x000000018515D3A8-0x000000018515D450
		public static void LogErrorWithFilter<T>(ELogChannel channel, string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(2)]
		public static void LogErrorWithFilter(ELogChannel channel, EColorTag color, string message, string filter) {} // 0x000000018515D1D0-0x000000018515D28C
		public static void LogErrorWithFilter<T>(ELogChannel channel, EColorTag color, string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(3)]
		public static void LogErrorWithFilter(UnityEngine.Object context, string message, string filter) {} // 0x000000018515D128-0x000000018515D1D0
		public static void LogErrorWithFilter<T>(UnityEngine.Object context, string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(4)]
		public static void LogErrorWithFilter(ELogChannel channel, UnityEngine.Object context, string message, string filter) {} // 0x000000018515D28C-0x000000018515D3A8
		public static void LogErrorWithFilter<T>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(5)]
		public static void LogErrorWithFilter(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x000000018515D4E4-0x000000018515D5B0
		public static void LogErrorWithFilter<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T param1) {}
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2) {}
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(0)]
		public static void LogCritical(string message) {} // 0x000000018515CDB0-0x000000018515CE5C
		public static void LogCritical<T>(string message, T param1) {}
		public static void LogCritical<T1, T2>(string message, T1 param1, T2 param2) {}
		public static void LogCritical<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogCritical<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogCritical<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(1)]
		public static void LogCritical(UnityEngine.Object context, string message) {} // 0x000000018515CC24-0x000000018515CCE0
		public static void LogCritical<T>(UnityEngine.Object context, string message, T param1) {}
		public static void LogCritical<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogCritical<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogCritical<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogCritical<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(2)]
		public static void LogCritical(ELogChannel channel, UnityEngine.Object context, string message) {} // 0x000000018515CA50-0x000000018515CB68
		[IDTag(3)]
		public static void LogCritical(ELogChannel channel, string message) {} // 0x000000018515CB68-0x000000018515CC24
		public static void LogCritical<T>(ELogChannel channel, string message, T param1) {}
		public static void LogCritical<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(4)]
		public static void LogCritical(ELogChannel channel, EColorTag color, string message) {} // 0x000000018515CCE0-0x000000018515CDB0
		public static void LogCritical<T>(ELogChannel channel, EColorTag color, string message, T param1) {}
		public static void LogCritical<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {}
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(5)]
		public static void LogCritical(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {} // 0x000000018515C930-0x000000018515CA50
		public static void LogCritical<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {}
		public static void LogCritical<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		public static void LogCritical<T>(ELogChannel channel, UnityEngine.Object context, string message, T param1) {}
		public static void LogCritical<T1, T2>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(1)]
		public static void LogException(Exception e) {} // 0x000000018515E088-0x000000018515E10C
		[IDTag(2)]
		public static void LogException(UnityEngine.Object context, Exception e) {} // 0x000000018515E10C-0x000000018515E19C
		[IDTag(3)]
		public static void LogException(ELogChannel channel, Exception e) {} // 0x000000018515DDB0-0x000000018515DE40
		[IDTag(4)]
		public static void LogException(ELogChannel channel, EColorTag color, Exception e) {} // 0x000000018515DFE4-0x000000018515E088
		[IDTag(0)]
		public static void LogException(ELogChannel channel, EColorTag color, UnityEngine.Object context, Exception e) {} // 0x000000018515DE40-0x000000018515DFE4
		[IDTag(0)]
		public static void LogImportant(EnableLogType enableLogType, string message) {} // 0x0000000182D77700-0x0000000182D77780
		public static void LogImportant<T>(EnableLogType enableLogType, string message, T param1) {}
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, string message, T1 param1, T2 param2) {}
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(1)]
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, string message) {} // 0x00000001825F6660-0x00000001825F66F0
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, string message, T param1) {}
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2) {}
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(2)]
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message) {} // 0x000000018515E19C-0x000000018515E254
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T param1) {}
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2) {}
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[IDTag(3)]
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message) {} // 0x000000018515E254-0x000000018515E31C
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1) {}
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2) {}
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3) {}
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) {}
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		private static void _Log(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x000000018515FC44-0x000000018515FD14
		private static void _Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		private static void _LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x000000018515FAA4-0x000000018515FB74
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		private static void _LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		private static void _LogWarning(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x000000018515FB74-0x000000018515FC44
		private static void _LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		private static void _LogErrorWithFilter(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x000000018319B9B0-0x000000018319BA60
		private static void _LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		private static void _LogImportant(ELogChannel channel, EnableLogType enableLogType, EColorTag color, UnityEngine.Object context, string message) {} // 0x00000001825F6500-0x00000001825F6660
		private static void _LogImportant<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EnableLogType enableLogType, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		private static void _LogCritical(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x000000018515F9D4-0x000000018515FAA4
		private static void _LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		private static void _ApplyLog(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x00000001825F67E0-0x00000001825F6930
		private static void _LogWithFilter(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter) {} // 0x00000001825F66F0-0x00000001825F67E0
		private static void _ApplyLog<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		private static void _LogWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogToConsole(ELogChannel channel, string message) {} // 0x000000018515E31C-0x000000018515E42C
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogToConsole<T>(ELogChannel channel, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogToConsole<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogErrorToConsole(ELogChannel channel, string message) {} // 0x000000018515D014-0x000000018515D128
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogErrorToConsole<T>(ELogChannel channel, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogErrorToConsole<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogErrorToConsole<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogErrorToConsole<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4) {}
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogExceptionToConsole(ELogChannel channel, Exception e) {} // 0x000000018515DC28-0x000000018515DDB0
		[Conditional("UNITY_EDITOR")]
		public static void SetLogToSceneViewEnabled(bool enabled) {} // 0x000000018515F44C-0x000000018515F4D4
		[Conditional("UNITY_EDITOR")]
		private static void LogToSceneViewImpl(ELogLevel logLevel, ELogChannel channel, string message, float lifeTime) {} // 0x000000018515E594-0x000000018515E6AC
		[Conditional("UNITY_EDITOR")]
		public static void ClearSceneViewLogs(string message) {} // 0x000000018515B65C-0x000000018515B6EC
		[Conditional("UNITY_EDITOR")]
		public static void ClearSceneViewLogsRegex(string message) {} // 0x000000018515B5CC-0x000000018515B65C
		[Conditional("UNITY_EDITOR")]
		[IDTag(0)]
		public static void LogToSceneView(ELogChannel channel, float lifeTime, string message) {} // 0x000000018515E7B0-0x000000018515E814
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneView(ELogChannel channel, string message) {} // 0x000000018515E760-0x000000018515E7B0
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneView<T>(ELogChannel channel, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneView<T>(ELogChannel channel, float lifeTime, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneView<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneView<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[IDTag(0)]
		public static void LogToSceneViewWarning(ELogChannel channel, float lifeTime, string message) {} // 0x000000018515E6AC-0x000000018515E710
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneViewWarning(ELogChannel channel, string message) {} // 0x000000018515E710-0x000000018515E760
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewWarning<T>(ELogChannel channel, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewWarning<T>(ELogChannel channel, float lifeTime, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewWarning<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewWarning<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[IDTag(0)]
		public static void LogToSceneViewError(ELogChannel channel, float lifeTime, string message) {} // 0x000000018515E530-0x000000018515E594
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneViewError(ELogChannel channel, string message) {} // 0x000000018515E4E0-0x000000018515E530
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewError<T>(ELogChannel channel, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewError<T>(ELogChannel channel, float lifeTime, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewError<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewError<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		[IDTag(0)]
		public static void LogToSceneViewCritical(ELogChannel channel, float lifeTime, string message) {} // 0x000000018515E42C-0x000000018515E490
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneViewCritical(ELogChannel channel, string message) {} // 0x000000018515E490-0x000000018515E4E0
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T>(ELogChannel channel, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T>(ELogChannel channel, float lifeTime, string message, T param1) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2) {}
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2) {}
		[IDTag(5)]
		public static void Log(ELogLevel logLevel, ELogChannel channel, string message, UnityEngine.Object context = null) {} // 0x000000018515ECCC-0x000000018515EE00
		[IDTag(6)]
		public static void Log(ELogLevel logLevel, ELogChannel channel, EColorTag color, string message, UnityEngine.Object context = null) {} // 0x000000018515EE00-0x000000018515EF40
		private static void _DefaultLog(ref FLogMessage msg) {} // 0x000000018515F61C-0x000000018515F9D4
		private static void _ConsoleLog(ref FLogMessage msg) {} // 0x000000018515F5C0-0x000000018515F61C
		private static void _SceneViewLog(ref FLogMessage msg, float time) {} // 0x000000018515FD54-0x000000018515FDC4
		private static DebugContext _AllocateDebugContext() => default; // 0x000000018515F4D4-0x000000018515F5C0
		public static DebugContextScope SetDebugContextInfo_MustUseUsing(string info, ELogLevel logLevelMask = ELogLevel.None | ELogLevel.Info | ELogLevel.Warning | ELogLevel.Error | ELogLevel.Critical | ELogLevel.Important | ELogLevel.Exception | ELogLevel.All /* Metadata: 0x01FDABAA */) => default; // 0x000000018515F248-0x000000018515F314
		public static string GetDebugContextInfo(ELogLevel logLevelMask = ELogLevel.None | ELogLevel.Info | ELogLevel.Warning | ELogLevel.Error | ELogLevel.Critical | ELogLevel.Important | ELogLevel.Exception | ELogLevel.All /* Metadata: 0x01FDABAB */) => default; // 0x00000001825F3FB0-0x00000001825F4460
		public static void PushPing(int ping) {} // 0x000000018515F1AC-0x000000018515F1F4
		public static void PushPlayerPos(Vector3 pos) {} // 0x000000018515F1F4-0x000000018515F248
		public static void Init() {} // 0x00000001829535C0-0x00000001829537A0
		private static void _AddCustomGameLoop(ref PlayerLoopSystem playerLoop) {} // 0x0000000182D97AE0-0x0000000182D97D50
		private static void AddPlayerLoop(PlayerLoopSystem method, ref PlayerLoopSystem playerLoop, string categoryName, string systemName, bool last = false /* Metadata: 0x01FDABAC */, bool before = false /* Metadata: 0x01FDABAD */) {} // 0x0000000182D97820-0x0000000182D97AE0
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop) => default; // 0x0000000182D94030-0x0000000182D941D0
		private static void _OnApplicationQuit() {} // 0x000000018515FD14-0x000000018515FD54
	}
}

namespace Beyond.Log
{
	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray256 // TypeDefIndex: 58062
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
		public uint capacity { get => default; } // 0x0000000183D4EA40-0x0000000183D4EA50 
		public bool allFalse { get => default; } // 0x000000018515ACFC-0x000000018515AD68 
		public bool allTrue { get => default; } // 0x000000018515AD68-0x000000018515ADD4 
		public string humanizedData { get => default; } // 0x000000018515ADD4-0x000000018515B0D0 
		public bool this[byte index] { get => default; set {} } // 0x000000018515ACF4-0x000000018515ACFC 0x000000018515B4BC-0x000000018515B4C8
	
		// Constructors
		public BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4) : this() {
			data1 = default;
			data2 = default;
			data3 = default;
			data4 = default;
		} // 0x0000000183D4EA20-0x0000000183D4EA40
		public BitArray256(IEnumerable<uint> bitIndexTrue) : this() {
			data1 = default;
			data2 = default;
			data3 = default;
			data4 = default;
		} // 0x000000018515AC00-0x000000018515ACF4
	
		// Methods
		public static BitArray256 operator ~(BitArray256 a) => default; // 0x000000018515B418-0x000000018515B4BC
		public static BitArray256 operator |(BitArray256 a, BitArray256 b) => default; // 0x000000018515B1C4-0x000000018515B2B8
		public static BitArray256 operator &(BitArray256 a, BitArray256 b) => default; // 0x000000018515B0D0-0x000000018515B1C4
		public static bool operator ==(BitArray256 a, BitArray256 b) => default; // 0x000000018515B2B8-0x000000018515B368
		public static bool operator !=(BitArray256 a, BitArray256 b) => default; // 0x000000018515B368-0x000000018515B418
		public override bool Equals(object obj) => default; // 0x000000018515A7A4-0x000000018515A888
		public override int GetHashCode() => default; // 0x000000018515A914-0x000000018515A9A4
		public bool GetBool(byte index) => default; // 0x000000018515A888-0x000000018515A914
		public void SetBool(uint index, bool value) {} // 0x000000018515AA5C-0x000000018515AB40
		public void SetAllTrue() {} // 0x000000018515AA00-0x000000018515AA5C
		public void SetAllFalse() {} // 0x000000018515A9A4-0x000000018515AA00
		public static BitArray256 AllTrue() => default; // 0x0000000183B2CA70-0x0000000183B2CAD0
		public static BitArray256 AllFalse() => default; // 0x000000018515A728-0x000000018515A7A4
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018515AB40-0x000000018515ABA8
		public int __iFixBaseProxy_GetHashCode() => default; // 0x000000018515ABA8-0x000000018515AC00
	}

	public class ConsoleLogger : Beyond.Log.ILogger // TypeDefIndex: 58063
	{
		// Fields
		public static readonly string LOG_TAG; // 0x00
	
		// Constructors
		public ConsoleLogger() {} // 0x000000018350B670-0x000000018350B680
		static ConsoleLogger() {} // 0x0000000183D1E740-0x0000000183D1E7A0
	
		// Methods
		private static bool _CheckIsMainThread() => default; // 0x000000018515B4C8-0x000000018515B524
		private static string _GetCurrentThreadName() => default; // 0x000000018515B578-0x000000018515B5CC
		private static int _GetCurrentThreadID() => default; // 0x000000018515B524-0x000000018515B578
		public void Log(ref FLogMessage msg) {} // 0x00000001825F46A0-0x00000001825F47B0
		private static void LogToUnity(ELogLevel level, string msg, Exception exception, UnityEngine.Object context) {} // 0x00000001825F4540-0x00000001825F46A0
		private static string _BuildLogForRuntime(long msgTime, int frameCount, string message, ELogChannel channel, EColorTag color, ELogLevel logLevel) => default; // 0x00000001825F47B0-0x00000001825F4980
	}

	public struct FLogMessage // TypeDefIndex: 58064
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
		public static FLogMessage CreateFromUnityLogCallback(ELogChannel channel, string message, string stacktrace, UnityEngine.LogType type) => default; // 0x000000018367C650-0x000000018367C840
	}

	public interface ILogger // TypeDefIndex: 58065
	{
		// Methods
		void Log(ref FLogMessage msg);
	}

	public class LocalLogger // TypeDefIndex: 58066
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
		public static string persistentDataPath { get => default; } // 0x000000018268BEC0-0x000000018268BF40 
	
		// Constructors
		static LocalLogger() {} // 0x00000001839D0C50-0x00000001839D0E20
		public LocalLogger() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration() {} // 0x0000000183D1B470-0x0000000183D1B4D0
		public static void LogInit(bool forceDebug = false /* Metadata: 0x01FDABAE */) {} // 0x000000018268B720-0x000000018268BEC0
		private static void InitLocalLogger(string path) {} // 0x000000018267B970-0x000000018267CB20
		private static void OnWantsToShutdown() {} // 0x00000001851646EC-0x00000001851648B8
		public static string FlushFile() => default; // 0x000000018516462C-0x00000001851646EC
		public static string getLogFileLocalPath() => default; // 0x0000000185164B18-0x0000000185164BD0
		private static void _UnityLogCallback(string condition, string stackTrace, UnityEngine.LogType type) {} // 0x0000000182CB44E0-0x0000000182CB4700
		private static void _UnityLogCallbackThread(string condition, string stackTrace, UnityEngine.LogType type) {} // 0x0000000182CB42C0-0x0000000182CB44E0
		private static void _GetTime(UnSafeString unSafeString) {} // 0x000000018516497C-0x0000000185164B18
		private static void _GetLogType(UnSafeString unSafeString, UnityEngine.LogType type) {} // 0x00000001851648B8-0x000000018516497C
		public static UnSafeString Alloc() => default; // 0x0000000182CB4700-0x0000000182CB4930
		public static void Release(UnSafeString value) {} // 0x0000000182CB4930-0x0000000182CB4AC0
	}

	public class SceneViewMessageLogger : Beyond.Log.ILogger // TypeDefIndex: 58067
	{
		// Fields
		public bool enabled; // 0x10
	
		// Constructors
		public SceneViewMessageLogger() {} // 0x0000000181168960-0x0000000181168970
	
		// Methods
		[IDTag(0)]
		public void Log(ref FLogMessage msg) {} // 0x0000000185164EB8-0x0000000185164F0C
		[IDTag(1)]
		public void Log(ref FLogMessage msg, float lifeTime) {} // 0x0000000185164E50-0x0000000185164EB8
		public void ClearLogs(string msg) {} // 0x0000000185164E00-0x0000000185164E50
		public void ClearLogsRegex(string regexMsg) {} // 0x0000000185164DB0-0x0000000185164E00
	}

	public class UnionLogger : Beyond.Log.ILogger // TypeDefIndex: 58068
	{
		// Fields
		internal Beyond.Log.ILogger s_consoleLogger; // 0x10
		internal Beyond.Log.ILogger s_netServerLogger; // 0x18
		private const int MAX_MSG_LEN = 2000; // Metadata: 0x01FDABAF
	
		// Constructors
		public UnionLogger() {} // 0x00000001838A4550-0x00000001838A4860
	
		// Methods
		public void SetServerLogger(Beyond.Log.ILogger log) {} // 0x0000000183B6D170-0x0000000183B6D1B0
		public void Log(ref FLogMessage msg) {} // 0x00000001825F4AE0-0x00000001825F4C00
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 58069
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05A30-0x0000000183D05AA0
	
		// Methods
		public string __Gen_Wrap_0(EColorTag P0) => default; // 0x0000000185160684-0x0000000185160760
		public string __Gen_Wrap_1(ELogChannel P0) => default; // 0x0000000185161164-0x0000000185161240
		public void __Gen_Wrap_2(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public void __Gen_Wrap_3() {} // 0x00000001851624BC-0x0000000185162544
		public void __Gen_Wrap_4(ref FLogMessage P0) {} // 0x00000001851630DC-0x0000000185163234
		public void __Gen_Wrap_5(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
		public void __Gen_Wrap_6(ELogLevel P0) {} // 0x00000001851643B0-0x000000018516445C
		public bool __Gen_Wrap_7(ELogLevel P0) => default; // 0x000000018514EE8C-0x000000018514EF5C
		public void __Gen_Wrap_8(ELogChannel P0, ELogLevel P1, bool P2) {} // 0x000000018516445C-0x0000000185164540
		public bool __Gen_Wrap_9(ELogChannel P0, ELogLevel P1) => default; // 0x0000000185164540-0x000000018516462C
		public void __Gen_Wrap_10(ELogChannel P0, ELogLevel P1, EColorTag P2, object P3, object P4, object P5) {} // 0x0000000185160760-0x0000000185160888
		public void __Gen_Wrap_11(ELogChannel P0, EColorTag P1, object P2, object P3, object P4) {} // 0x0000000185160888-0x00000001851609A0
		public void __Gen_Wrap_12(ELogChannel P0, object P1) {} // 0x00000001851609A0-0x0000000185160A7C
		public void __Gen_Wrap_13(ELogChannel P0, EColorTag P1, object P2) {} // 0x0000000185160A7C-0x0000000185160B74
		public void __Gen_Wrap_14(ELogChannel P0, EColorTag P1, object P2, object P3) {} // 0x0000000185160B74-0x0000000185160C7C
		public void __Gen_Wrap_15(ELogChannel P0, object P1, object P2) {} // 0x0000000185160C7C-0x0000000185160D60
		public void __Gen_Wrap_16(object P0, object P1, object P2) {} // 0x0000000185160D60-0x0000000185160E44
		public void __Gen_Wrap_17(object P0, object P1, object P2, object P3) {} // 0x0000000185160E44-0x0000000185160F3C
		public void __Gen_Wrap_18(object P0, object P1, object P2, object P3, object P4) {} // 0x0000000185160F3C-0x000000018516104C
		public void __Gen_Wrap_19(object P0, object P1, object P2, object P3, object P4, object P5) {} // 0x000000018516104C-0x0000000185161164
		public void __Gen_Wrap_20(object P0, object P1, object P2, object P3, object P4, object P5, object P6) {} // 0x00000001850F2B3C-0x00000001850F2C64
		public void __Gen_Wrap_21(object P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7) {} // 0x0000000185161240-0x0000000185161378
		public void __Gen_Wrap_22(ELogChannel P0, object P1, object P2, object P3) {} // 0x0000000185161378-0x0000000185161470
		public void __Gen_Wrap_23(ELogChannel P0, object P1, object P2, object P3, object P4) {} // 0x0000000185161470-0x000000018516157C
		public void __Gen_Wrap_24(ELogChannel P0, object P1, object P2, object P3, object P4, object P5) {} // 0x000000018516157C-0x0000000185161694
		public void __Gen_Wrap_25(ELogChannel P0, object P1, object P2, object P3, object P4, object P5, object P6) {} // 0x0000000185161694-0x00000001851617BC
		public void __Gen_Wrap_26(ELogChannel P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7) {} // 0x00000001851617BC-0x00000001851618F4
		public void __Gen_Wrap_27(ELogChannel P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8) {} // 0x00000001851618F4-0x0000000185161A3C
		public void __Gen_Wrap_28(ELogChannel P0, EnableLogType P1, EColorTag P2, object P3, object P4) {} // 0x0000000185161A3C-0x0000000185161B54
		public void __Gen_Wrap_29(EnableLogType P0, object P1) {} // 0x0000000185161B54-0x0000000185161C30
		public void __Gen_Wrap_30(EnableLogType P0, ELogChannel P1, object P2) {} // 0x0000000185161C30-0x0000000185161D28
		public void __Gen_Wrap_31(EnableLogType P0, ELogChannel P1, EColorTag P2, object P3) {} // 0x0000000185161D28-0x0000000185161E20
		public void __Gen_Wrap_32(EnableLogType P0, ELogChannel P1, EColorTag P2, object P3, object P4) {} // 0x0000000185161E20-0x0000000185161F2C
		public void __Gen_Wrap_33(bool P0) {} // 0x000000018514F660-0x000000018514F720
		public void __Gen_Wrap_34(ELogLevel P0, ELogChannel P1, object P2, float P3) {} // 0x0000000185161F2C-0x0000000185162024
		public void __Gen_Wrap_35(ELogChannel P0, float P1, object P2) {} // 0x0000000185162024-0x0000000185162108
		public void __Gen_Wrap_36(ELogLevel P0, ELogChannel P1, object P2, object P3) {} // 0x0000000185162108-0x0000000185162200
		public void __Gen_Wrap_37(ELogLevel P0, ELogChannel P1, EColorTag P2, object P3, object P4) {} // 0x0000000185162200-0x000000018516230C
		public DLogger.DebugContext __Gen_Wrap_38() => default; // 0x000000018516230C-0x00000001851623C4
		public DLogger.DebugContextScope __Gen_Wrap_39(object P0, ELogLevel P1) => default; // 0x00000001851623C4-0x00000001851624BC
		public string __Gen_Wrap_40(ELogLevel P0) => default; // 0x0000000185162544-0x0000000185162620
		public bool __Gen_Wrap_42(ref PlayerLoopSystem P0) => default; // 0x0000000185162620-0x000000018516277C
		public void __Gen_Wrap_43(PlayerLoopSystem P0, ref PlayerLoopSystem P1, object P2, object P3, bool P4, bool P5) {} // 0x000000018516277C-0x0000000185162954
		public void __Gen_Wrap_44(ref PlayerLoopSystem P0) {} // 0x0000000185162954-0x0000000185162AA0
		public void __Gen_Wrap_45(ref DLogger.DebugContextScope P0) {} // 0x0000000185162AA0-0x0000000185162BB8
		public bool __Gen_Wrap_46(ref BitArray256 P0) => default; // 0x0000000185162BB8-0x0000000185162CF8
		public string __Gen_Wrap_47(ref BitArray256 P0) => default; // 0x0000000185162CF8-0x0000000185162E48
		public BitArray256 __Gen_Wrap_48(BitArray256 P0) => default; // 0x0000000185162E48-0x0000000185162F74
		public BitArray256 __Gen_Wrap_49(BitArray256 P0, BitArray256 P1) => default; // 0x0000000185162F74-0x00000001851630DC
		public bool __Gen_Wrap_50(BitArray256 P0, BitArray256 P1) => default; // 0x0000000185163234-0x0000000185163368
		public bool __Gen_Wrap_51(ref BitArray256 P0, object P1) => default; // 0x0000000185163368-0x00000001851634C4
		public int __Gen_Wrap_52(ref BitArray256 P0) => default; // 0x00000001851634C4-0x0000000185163604
		public bool __Gen_Wrap_53(ref BitArray256 P0, byte P1) => default; // 0x0000000185163604-0x0000000185163760
		public void __Gen_Wrap_54(ref BitArray256 P0, uint P1, bool P2) {} // 0x0000000185163760-0x00000001851638C4
		public void __Gen_Wrap_55(ref BitArray256 P0) {} // 0x00000001851638C4-0x00000001851639F4
		public BitArray256 __Gen_Wrap_56() => default; // 0x00000001851639F4-0x0000000185163AE8
		public bool __Gen_Wrap_57() => default; // 0x00000001850F1D3C-0x00000001850F1DD4
		public string __Gen_Wrap_58() => default; // 0x0000000185163AE8-0x0000000185163BA0
		public int __Gen_Wrap_59() => default; // 0x00000001850F1DD4-0x00000001850F1E6C
		public string __Gen_Wrap_60(long P0, int P1, object P2, ELogChannel P3, EColorTag P4, ELogLevel P5) => default; // 0x0000000185163C7C-0x0000000185163DC0
		public void __Gen_Wrap_61(ELogLevel P0, object P1, object P2, object P3) {} // 0x0000000185161378-0x0000000185161470
		public void __Gen_Wrap_62(object P0, ref FLogMessage P1) {} // 0x0000000185163DC0-0x0000000185163F34
		public FLogMessage __Gen_Wrap_63(ELogChannel P0, object P1, object P2, UnityEngine.LogType P3) => default; // 0x0000000185163F34-0x0000000185164084
		public UnSafeString __Gen_Wrap_64() => default; // 0x0000000185164084-0x000000018516413C
		public void __Gen_Wrap_65(object P0, object P1, UnityEngine.LogType P2) {} // 0x000000018516413C-0x0000000185164220
		public void __Gen_Wrap_66(object P0, ref FLogMessage P1, float P2) {} // 0x0000000185164220-0x00000001851643B0
	}

	public class WrappersManagerImpl // TypeDefIndex: 58070
	{
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000185164F48-0x000000018516504C
		public static bool IsPatched(int id) => default; // 0x00000001825F4D90-0x00000001825F4E00
	}
}
