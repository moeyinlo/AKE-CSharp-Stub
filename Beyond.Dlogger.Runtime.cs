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

// Image 64: Beyond.Dlogger.Runtime.dll - Assembly: Beyond.Dlogger.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61745-61767
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond
{
	public enum ELogChannel : byte // TypeDefIndex: 61746
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
		BlackScreen = 104,
		Max = 105
	}

	[Flags]
	public enum ELogLevel : byte // TypeDefIndex: 61747
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

	public enum EColorTag : byte // TypeDefIndex: 61748
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

	public static class LogDefine // TypeDefIndex: 61749
	{
		// Fields
		private static Dictionary<int, string> s_logNameCacheDict; // 0x00
	
		// Constructors
		static LogDefine(); // 0x0000000184D17A30-0x0000000184D17AC0
	
		// Methods
		public static string ConvertColorTagToName(EColorTag colorTag); // 0x00000001863785C0-0x00000001863787A0
	
		// Extension methods
		public static string ConvertLogChannelToName(this ELogChannel logChannel); // 0x000000018313C440-0x000000018313C580
	}

	public enum EnableLogType // TypeDefIndex: 61750
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

	public static class DLogger // TypeDefIndex: 61758
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
		public static ELogLevel[] s_enabledLogChannel { get; } // 0x000000018332EE30-0x000000018332EEC0 
		public static int FrameCountThreadSafe { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000186372F94-0x0000000186372FE4 0x000000018637338C-0x00000001863733E0
		public static int LogPing { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000186372FE4-0x0000000186373034 0x00000001863733E0-0x0000000186373434
		public static Vector3 LogPlayerPos { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000186373034-0x000000018637308C 0x0000000186373434-0x0000000186373488
	
		// Events
		public static event LogCallback s_logCriticalAndExceptionMessageReceived {
			add; // 0x0000000183DD5040-0x0000000183DD5140
			remove; // 0x000000018637308C-0x000000018637318C
		}
		public static event LogCallback s_onBeforeLogError {
			add; // 0x0000000186372E94-0x0000000186372F94
			remove; // 0x000000018637328C-0x000000018637338C
		}
		public static event LogCallback s_onBeforeLogCriticalAndException {
			add; // 0x0000000186372D94-0x0000000186372E94
			remove; // 0x000000018637318C-0x000000018637328C
		}
	
		// Nested types
		public class Options // TypeDefIndex: 61751
		{
			// Fields
			public Dictionary<EnableLogType, bool> remoteSet; // 0x10
	
			// Constructors
			public Options(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public delegate void LogCallback(ref FLogMessage msg); // TypeDefIndex: 61752; 0x0000000182B46B90-0x0000000182B46BA0
	
		public class DebugContext // TypeDefIndex: 61753
		{
			// Fields
			public ELogLevel logLevelMask; // 0x10
			public string info; // 0x18
	
			// Constructors
			public DebugContext(); // 0x0000000184D861E0-0x0000000184D861F0
		}
	
		[IsReadOnly]
		public struct DebugContextScope : IDisposable // TypeDefIndex: 61754
		{
			// Methods
			public void Dispose(); // 0x0000000186373488-0x00000001863735B8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61755
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static PlayerLoopSystem.UpdateFunction __9__432_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D4B8B0-0x0000000184D4B910
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __AddCustomGameLoop_b__432_0(); // 0x0000000183234530-0x00000001832345D0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass433_0 // TypeDefIndex: 61756
		{
			// Fields
			public string categoryName; // 0x10
			public string systemName; // 0x18
	
			// Constructors
			public __c__DisplayClass433_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AddPlayerLoop_b__0(PlayerLoopSystem s); // 0x0000000184294210-0x0000000184294250
			internal bool _AddPlayerLoop_b__1(PlayerLoopSystem h); // 0x00000001863788FC-0x0000000186378938
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass434_0 // TypeDefIndex: 61757
		{
			// Fields
			public System.Type t; // 0x10
			public Func<PlayerLoopSystem, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass434_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _CheckRegist_b__0(PlayerLoopSystem x); // 0x0000000184546160-0x00000001845461A0
		}
	
		// Constructors
		static DLogger(); // 0x00000001848615A0-0x0000000184861930
	
		// Methods
		public static void SetImportantLogConfig(Options options); // 0x00000001845E16D0-0x00000001845E18D0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _RunOnStart(); // 0x0000000184CDEDC0-0x0000000184CDEE90
		private static void UpdateLogCount(ref FLogMessage msg); // 0x000000018313C580-0x000000018313C6C0
		public static void SetServerLogger(Beyond.Log.ILogger logger); // 0x0000000183E3E1B0-0x0000000183E3E240
		public static void SetLogLevel(ELogLevel level); // 0x00000001863724A4-0x0000000186372520
		public static bool CheckLogLevel(ELogLevel level); // 0x000000018332EEC0-0x000000018332EF40
		public static void SetLogChannelEnabled(ELogChannel channel, ELogLevel level, bool val); // 0x00000001863723E4-0x00000001863724A4
		public static bool CheckLogChannelEnabled(ELogChannel channel, ELogLevel level = ELogLevel.None | ELogLevel.Info /* Metadata: 0x0234FF3A */); // 0x000000018332ED70-0x000000018332EE30
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(0)]
		public static void Log(string message); // 0x0000000186371D3C-0x0000000186371DC4
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
		public static void Log(ELogChannel channel, string message); // 0x0000000186371CA4-0x0000000186371D3C
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
		public static void Log(ELogChannel channel, EColorTag color, string message); // 0x00000001863721F8-0x00000001863722A4
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
		[Conditional("ENABLE_LOG")]
		[Conditional("UNITY_EDITOR")]
		[IDTag(3)]
		public static void Log(UnityEngine.Object context, string message); // 0x0000000186372164-0x00000001863721F8
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
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		[IDTag(4)]
		public static void Log(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x0000000186372038-0x0000000186372164
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
		public static void LogEditorAlwaysPrint(string message); // 0x00000001863700B0-0x00000001863700F0
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
		public static void LogEditorAlwaysPrint(ELogChannel channel, string message); // 0x0000000186370010-0x0000000186370060
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
		public static void LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, string message); // 0x0000000186370164-0x00000001863701C8
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
		public static void LogEditorAlwaysPrint(UnityEngine.Object context, string message); // 0x0000000186370060-0x00000001863700B0
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
		public static void LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x00000001863700F0-0x0000000186370164
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
		public static void LogWarning(string message); // 0x0000000186371C1C-0x0000000186371CA4
		[Conditional("ENABLE_WARNING")]
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogWarning(UnityEngine.Object context, string message); // 0x000000018637190C-0x00000001863719A0
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
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_WARNING")]
		[IDTag(2)]
		public static void LogWarning(ELogChannel channel, string message); // 0x0000000186371A5C-0x0000000186371B70
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
		public static void LogWarning(ELogChannel channel, EColorTag color, string message); // 0x0000000186371B70-0x0000000186371C1C
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
		public static void LogWarning(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x00000001863719A0-0x0000000186371A5C
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
		public static void LogError(string message); // 0x0000000184D096D0-0x0000000184D09770
		[IDTag(0)]
		public static void LogErrorWithLuaStack(ELogChannel channel, string message); // 0x00000001863707E0-0x00000001863709E0
		public static void LogErrorWithLuaStack<T1>(ELogChannel channel, string message, T1 param1);
		public static void LogErrorWithLuaStack<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		public static void LogErrorWithLuaStack<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		[IDTag(1)]
		public static void LogErrorWithLuaStack(string message); // 0x0000000186370764-0x00000001863707E0
		public static void LogError<T>(string message, T param1);
		public static void LogError<T1, T2>(string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(1)]
		public static void LogError(ELogChannel channel, string message); // 0x000000018374C520-0x000000018374C5D0
		public static void LogError<T>(ELogChannel channel, string message, T param1);
		public static void LogError<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(2)]
		public static void LogError(ELogChannel channel, EColorTag color, string message); // 0x0000000186370C50-0x0000000186370D20
		public static void LogError<T>(ELogChannel channel, EColorTag color, string message, T param1);
		public static void LogError<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(3)]
		public static void LogError(UnityEngine.Object context, string message); // 0x00000001863709E0-0x0000000186370A9C
		public static void LogError<T>(UnityEngine.Object context, string message, T param1);
		public static void LogError<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(4)]
		public static void LogError(ELogChannel channel, UnityEngine.Object context, string message); // 0x0000000186370B80-0x0000000186370C50
		public static void LogError<T>(ELogChannel channel, UnityEngine.Object context, string message, T param1);
		public static void LogError<T1, T2>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(5)]
		public static void LogError(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x0000000186370A9C-0x0000000186370B80
		public static void LogError<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1);
		public static void LogError<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogError<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogError<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogError<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogError<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogError<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(0)]
		public static void IFixLogError(string message); // 0x000000018636EFE0-0x000000018636F08C
		[IDTag(1)]
		public static void IFixLogError(string message, string param1); // 0x000000018636EAA4-0x000000018636EBAC
		[IDTag(2)]
		public static void IFixLogError(string message, string param1, string param2); // 0x000000018636EED0-0x000000018636EFE0
		[IDTag(3)]
		public static void IFixLogError(string message, string param1, string param2, string param3); // 0x000000018636F6C4-0x000000018636F7DC
		[IDTag(4)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4); // 0x000000018636F5A0-0x000000018636F6C4
		[IDTag(5)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5); // 0x000000018636F1A0-0x000000018636F2DC
		[IDTag(6)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5, string param6); // 0x000000018636E95C-0x000000018636EAA4
		[IDTag(7)]
		public static void IFixLogError(string message, string param1, string param2, string param3, string param4, string param5, string param6, string param7); // 0x000000018636EBAC-0x000000018636ED08
		[IDTag(8)]
		public static void IFixLogError(ELogChannel channel, string message); // 0x000000018636EE14-0x000000018636EED0
		[IDTag(9)]
		public static void IFixLogError(ELogChannel channel, string message, string param1); // 0x000000018636ED08-0x000000018636EE14
		[IDTag(10)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2); // 0x000000018636F08C-0x000000018636F1A0
		[IDTag(11)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3); // 0x000000018636F918-0x000000018636FA44
		[IDTag(12)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4); // 0x000000018636F7DC-0x000000018636F918
		[IDTag(13)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5); // 0x000000018636F2DC-0x000000018636F42C
		[IDTag(14)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5, string param6); // 0x000000018636FA44-0x000000018636FBA0
		[IDTag(15)]
		public static void IFixLogError(ELogChannel channel, string message, string param1, string param2, string param3, string param4, string param5, string param6, string param7); // 0x000000018636F42C-0x000000018636F5A0
		[IDTag(0)]
		public static void LogErrorWithFilter(string message, string filter); // 0x0000000186370604-0x0000000186370698
		public static void LogErrorWithFilter<T>(string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(1)]
		public static void LogErrorWithFilter(ELogChannel channel, string message, string filter); // 0x000000018637055C-0x0000000186370604
		public static void LogErrorWithFilter<T>(ELogChannel channel, string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(2)]
		public static void LogErrorWithFilter(ELogChannel channel, EColorTag color, string message, string filter); // 0x0000000186370384-0x0000000186370440
		public static void LogErrorWithFilter<T>(ELogChannel channel, EColorTag color, string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(3)]
		public static void LogErrorWithFilter(UnityEngine.Object context, string message, string filter); // 0x00000001863702DC-0x0000000186370384
		public static void LogErrorWithFilter<T>(UnityEngine.Object context, string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(4)]
		public static void LogErrorWithFilter(ELogChannel channel, UnityEngine.Object context, string message, string filter); // 0x0000000186370440-0x000000018637055C
		public static void LogErrorWithFilter<T>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(5)]
		public static void LogErrorWithFilter(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x0000000186370698-0x0000000186370764
		public static void LogErrorWithFilter<T>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T param1);
		public static void LogErrorWithFilter<T1, T2>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2);
		public static void LogErrorWithFilter<T1, T2, T3>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3);
		public static void LogErrorWithFilter<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(0)]
		public static void LogCritical(string message); // 0x000000018636FF64-0x0000000186370010
		public static void LogCritical<T>(string message, T param1);
		public static void LogCritical<T1, T2>(string message, T1 param1, T2 param2);
		public static void LogCritical<T1, T2, T3>(string message, T1 param1, T2 param2, T3 param3);
		public static void LogCritical<T1, T2, T3, T4>(string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogCritical<T1, T2, T3, T4, T5>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(1)]
		public static void LogCritical(UnityEngine.Object context, string message); // 0x000000018636FDD8-0x000000018636FE94
		public static void LogCritical<T>(UnityEngine.Object context, string message, T param1);
		public static void LogCritical<T1, T2>(UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogCritical<T1, T2, T3>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogCritical<T1, T2, T3, T4>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogCritical<T1, T2, T3, T4, T5>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(2)]
		public static void LogCritical(ELogChannel channel, UnityEngine.Object context, string message); // 0x000000018636FCC0-0x000000018636FDD8
		[IDTag(3)]
		public static void LogCritical(ELogChannel channel, string message); // 0x000000018421C2E0-0x000000018421C390
		public static void LogCritical<T>(ELogChannel channel, string message, T param1);
		public static void LogCritical<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(4)]
		public static void LogCritical(ELogChannel channel, EColorTag color, string message); // 0x000000018636FE94-0x000000018636FF64
		public static void LogCritical<T>(ELogChannel channel, EColorTag color, string message, T param1);
		public static void LogCritical<T1, T2>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2);
		public static void LogCritical<T1, T2, T3>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3);
		public static void LogCritical<T1, T2, T3, T4>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogCritical<T1, T2, T3, T4, T5>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogCritical<T1, T2, T3, T4, T5, T6>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(5)]
		public static void LogCritical(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x000000018636FBA0-0x000000018636FCC0
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
		public static void LogException(Exception e); // 0x0000000186371180-0x0000000186371204
		[IDTag(2)]
		public static void LogException(UnityEngine.Object context, Exception e); // 0x0000000186371204-0x0000000186371294
		[IDTag(3)]
		public static void LogException(ELogChannel channel, Exception e); // 0x0000000186370EA8-0x0000000186370F38
		[IDTag(4)]
		public static void LogException(ELogChannel channel, EColorTag color, Exception e); // 0x00000001863710DC-0x0000000186371180
		[IDTag(0)]
		public static void LogException(ELogChannel channel, EColorTag color, UnityEngine.Object context, Exception e); // 0x0000000186370F38-0x00000001863710DC
		[IDTag(0)]
		public static void LogImportant(EnableLogType enableLogType, string message); // 0x0000000183AF76E0-0x0000000183AF7760
		public static void LogImportant<T>(EnableLogType enableLogType, string message, T param1);
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, string message, T1 param1, T2 param2);
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3);
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(1)]
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, string message); // 0x000000018332DDD0-0x000000018332DE50
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, string message, T param1);
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2);
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3);
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(2)]
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message); // 0x0000000186371294-0x000000018637134C
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T param1);
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2);
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3);
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[IDTag(3)]
		public static void LogImportant(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message); // 0x000000018637134C-0x0000000186371414
		public static void LogImportant<T>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T param1);
		public static void LogImportant<T1, T2>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2);
		public static void LogImportant<T1, T2, T3>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3);
		public static void LogImportant<T1, T2, T3, T4>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4);
		public static void LogImportant<T1, T2, T3, T4, T5>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
		public static void LogImportant<T1, T2, T3, T4, T5, T6>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
		public static void LogImportant<T1, T2, T3, T4, T5, T6, T7>(EnableLogType enableLogType, ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _Log(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x0000000186372C14-0x0000000186372CE4
		private static void _Log<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		private static void _LogEditorAlwaysPrint(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x0000000186372A74-0x0000000186372B44
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		private static void _LogEditorAlwaysPrint<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _LogWarning(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x0000000186372B44-0x0000000186372C14
		private static void _LogWarning<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _LogErrorWithFilter(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x000000018332E670-0x000000018332E720
		private static void _LogErrorWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _LogImportant(ELogChannel channel, EnableLogType enableLogType, EColorTag color, UnityEngine.Object context, string message); // 0x000000018332DE50-0x000000018332DF70
		private static void _LogImportant<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EnableLogType enableLogType, EColorTag color, UnityEngine.Object context, string message, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _LogCritical(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x000000018421C230-0x000000018421C2E0
		private static void _LogCritical<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _ApplyLog(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x000000018332E720-0x000000018332ECB0
		private static void _LogWithFilter(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter); // 0x000000018332ECB0-0x000000018332ED70
		private static void _ApplyLog<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		private static void _LogWithFilter<T1, T2, T3, T4, T5, T6, T7>(ELogChannel channel, ELogLevel level, EColorTag color, UnityEngine.Object context, string message, string filter, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogToConsole(ELogChannel channel, string message); // 0x0000000186371414-0x0000000186371524
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogToConsole<T>(ELogChannel channel, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		[Conditional("ENABLE_LOG")]
		public static void LogToConsole<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		public static void LogErrorToConsole(ELogChannel channel, string message); // 0x00000001863701C8-0x00000001863702DC
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
		public static void LogExceptionToConsole(ELogChannel channel, Exception e); // 0x0000000186370D20-0x0000000186370EA8
		[Conditional("UNITY_EDITOR")]
		public static void SetLogToSceneViewEnabled(bool enabled); // 0x0000000186372520-0x00000001863725A8
		[Conditional("UNITY_EDITOR")]
		private static void LogToSceneViewImpl(ELogLevel logLevel, ELogChannel channel, string message, float lifeTime); // 0x000000018637168C-0x00000001863717A4
		[Conditional("UNITY_EDITOR")]
		public static void ClearSceneViewLogs(string message); // 0x000000018636E8CC-0x000000018636E95C
		[Conditional("UNITY_EDITOR")]
		public static void ClearSceneViewLogsRegex(string message); // 0x000000018636E83C-0x000000018636E8CC
		[Conditional("UNITY_EDITOR")]
		[IDTag(0)]
		public static void LogToSceneView(ELogChannel channel, float lifeTime, string message); // 0x00000001863718A8-0x000000018637190C
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneView(ELogChannel channel, string message); // 0x0000000186371858-0x00000001863718A8
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
		public static void LogToSceneViewWarning(ELogChannel channel, float lifeTime, string message); // 0x00000001863717A4-0x0000000186371808
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneViewWarning(ELogChannel channel, string message); // 0x0000000186371808-0x0000000186371858
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
		public static void LogToSceneViewError(ELogChannel channel, float lifeTime, string message); // 0x0000000186371628-0x000000018637168C
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneViewError(ELogChannel channel, string message); // 0x00000001863715D8-0x0000000186371628
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
		public static void LogToSceneViewCritical(ELogChannel channel, float lifeTime, string message); // 0x0000000186371524-0x0000000186371588
		[Conditional("UNITY_EDITOR")]
		[IDTag(1)]
		public static void LogToSceneViewCritical(ELogChannel channel, string message); // 0x0000000186371588-0x00000001863715D8
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T>(ELogChannel channel, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T>(ELogChannel channel, float lifeTime, string message, T param1);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T1, T2>(ELogChannel channel, string message, T1 param1, T2 param2);
		[Conditional("UNITY_EDITOR")]
		public static void LogToSceneViewCritical<T1, T2>(ELogChannel channel, float lifeTime, string message, T1 param1, T2 param2);
		[IDTag(5)]
		public static void Log(ELogLevel logLevel, ELogChannel channel, string message, UnityEngine.Object context = null); // 0x0000000186371DC4-0x0000000186371EF8
		[IDTag(6)]
		public static void Log(ELogLevel logLevel, ELogChannel channel, EColorTag color, string message, UnityEngine.Object context = null); // 0x0000000186371EF8-0x0000000186372038
		private static void _DefaultLog(ref FLogMessage msg); // 0x00000001863726BC-0x0000000186372A74
		private static void _ConsoleLog(ref FLogMessage msg); // 0x0000000186372660-0x00000001863726BC
		private static void _SceneViewLog(ref FLogMessage msg, float time); // 0x0000000186372D24-0x0000000186372D94
		private static DebugContext _AllocateDebugContext(); // 0x00000001863725A8-0x0000000186372660
		public static DebugContextScope SetDebugContextInfo_MustUseUsing(string info, ELogLevel logLevelMask = ELogLevel.None | ELogLevel.Info | ELogLevel.Warning | ELogLevel.Error | ELogLevel.Critical | ELogLevel.Important | ELogLevel.Exception | ELogLevel.All /* Metadata: 0x0234FF3B */); // 0x0000000186372340-0x00000001863723E4
		public static string GetDebugContextInfo(ELogLevel logLevelMask = ELogLevel.None | ELogLevel.Info | ELogLevel.Warning | ELogLevel.Error | ELogLevel.Critical | ELogLevel.Important | ELogLevel.Exception | ELogLevel.All /* Metadata: 0x0234FF3C */); // 0x000000018313B970-0x000000018313BE20
		public static void PushPing(int ping); // 0x00000001863722A4-0x00000001863722EC
		public static void PushPlayerPos(Vector3 pos); // 0x00000001863722EC-0x0000000186372340
		public static void Init(); // 0x0000000183328BE0-0x0000000183328DC0
		private static void _AddCustomGameLoop(ref PlayerLoopSystem playerLoop); // 0x00000001833283A0-0x0000000183328610
		private static void AddPlayerLoop(PlayerLoopSystem method, ref PlayerLoopSystem playerLoop, string categoryName, string systemName, bool last = false /* Metadata: 0x0234FF3D */, bool before = false /* Metadata: 0x0234FF3E */); // 0x00000001833280D0-0x00000001833283A0
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop); // 0x0000000183324980-0x0000000183324B20
		private static void _OnApplicationQuit(); // 0x0000000186372CE4-0x0000000186372D24
	}
}

namespace Beyond.Log
{
	[Serializable]
	[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
	public struct BitArray256 // TypeDefIndex: 61759
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
		public uint capacity { get; } // 0x000000018636DF80-0x000000018636DFCC 
		public bool allFalse { get; } // 0x000000018636DEA8-0x000000018636DF14 
		public bool allTrue { get; } // 0x000000018636DF14-0x000000018636DF80 
		public string humanizedData { get; } // 0x000000018636DFCC-0x000000018636E2C8 
		public bool this[byte index] { get => default; set {} } // 0x000000018636DE48-0x000000018636DEA8 0x000000018636E6C0-0x000000018636E738
	
		// Constructors
		public BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4); // 0x0000000184D861C0-0x0000000184D861E0
		public BitArray256(IEnumerable<uint> bitIndexTrue); // 0x000000018636DD3C-0x000000018636DE48
	
		// Methods
		public static BitArray256 operator ~(BitArray256 a); // 0x000000018636E618-0x000000018636E6C0
		public static BitArray256 operator |(BitArray256 a, BitArray256 b); // 0x000000018636E3C0-0x000000018636E4B8
		public static BitArray256 operator &(BitArray256 a, BitArray256 b); // 0x000000018636E2C8-0x000000018636E3C0
		public static bool operator ==(BitArray256 a, BitArray256 b); // 0x000000018636E4B8-0x000000018636E568
		public static bool operator !=(BitArray256 a, BitArray256 b); // 0x000000018636E568-0x000000018636E618
		public override bool Equals(object obj); // 0x000000018636D8E0-0x000000018636D9C4
		public override int GetHashCode(); // 0x000000018636DA50-0x000000018636DAE0
		public bool GetBool(byte index); // 0x000000018636D9C4-0x000000018636DA50
		public void SetBool(uint index, bool value); // 0x000000018636DB98-0x000000018636DC7C
		public void SetAllTrue(); // 0x000000018636DB3C-0x000000018636DB98
		public void SetAllFalse(); // 0x000000018636DAE0-0x000000018636DB3C
		public static BitArray256 AllTrue(); // 0x0000000183E3E150-0x0000000183E3E1B0
		public static BitArray256 AllFalse(); // 0x000000018636D864-0x000000018636D8E0
		public bool __iFixBaseProxy_Equals(object P0); // 0x000000018636DC7C-0x000000018636DCE4
		public int __iFixBaseProxy_GetHashCode(); // 0x000000018636DCE4-0x000000018636DD3C
	}

	public class ConsoleLogger : Beyond.Log.ILogger // TypeDefIndex: 61760
	{
		// Fields
		public static readonly string LOG_TAG; // 0x00
	
		// Constructors
		public ConsoleLogger(); // 0x00000001841E1670-0x00000001841E1680
		static ConsoleLogger(); // 0x0000000184D50940-0x0000000184D509A0
	
		// Methods
		private static bool _CheckIsMainThread(); // 0x000000018636E738-0x000000018636E794
		private static string _GetCurrentThreadName(); // 0x000000018636E7E8-0x000000018636E83C
		private static int _GetCurrentThreadID(); // 0x000000018636E794-0x000000018636E7E8
		public void Log(ref FLogMessage msg); // 0x000000018313C1A0-0x000000018313C2C0
		private static void LogToUnity(ELogLevel level, string msg, Exception exception, UnityEngine.Object context); // 0x000000018313C6C0-0x000000018313C830
		private static string _BuildLogForRuntime(long msgTime, int frameCount, string message, ELogChannel channel, EColorTag color, ELogLevel logLevel); // 0x000000018313C2C0-0x000000018313C440
	}

	public struct FLogMessage // TypeDefIndex: 61761
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
		public static FLogMessage CreateFromUnityLogCallback(ELogChannel channel, string message, string stacktrace, UnityEngine.LogType type); // 0x000000018313AAA0-0x000000018313B970
	}

	public interface ILogger // TypeDefIndex: 61762
	{
		// Methods
		void Log(ref FLogMessage msg);
	}

	public class LocalLogger // TypeDefIndex: 61763
	{
		// Fields
		private static int mainThreadId; // 0x00
		private static bool s_initLog; // 0x04
		private static StreamWriter s_StreamWriter; // 0x08
		private static List<StreamWriter> allStreamWriter; // 0x10
		private static ConcurrentStack<UnSafeString> s_stack; // 0x18
		private static UnSafeString s_mainCache; // 0x20
		private static string s_LogFilePath; // 0x28
		private static string[] s_logTypeString; // 0x30
		[ThreadStatic]
		private static StreamWriter _sThreadStreamWriter; // 0x80000000
	
		// Properties
		public static string persistentDataPath { get; } // 0x0000000183828F80-0x0000000183829010 
	
		// Constructors
		static LocalLogger(); // 0x00000001849D7110-0x00000001849D89D0
		public LocalLogger(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration(); // 0x0000000184D4E070-0x0000000184D4E0D0
		public static void LogInit(bool forceDebug = false /* Metadata: 0x0234FF3F */); // 0x00000001838288B0-0x0000000183828F80
		private static void InitLocalLogger(string path); // 0x0000000183E3E8F0-0x0000000183E40EC0
		private static void OnWantsToShutdown(); // 0x0000000186377EB8-0x00000001863782A8
		public static string FlushFile(); // 0x0000000186377D84-0x0000000186377EB8
		public static string getLogFileLocalPath(); // 0x0000000186378508-0x00000001863785C0
		private static void _UnityLogCallback(string condition, string stackTrace, UnityEngine.LogType type); // 0x00000001833303B0-0x0000000183330A40
		private static void _UnityLogCallbackThread(string condition, string stackTrace, UnityEngine.LogType type); // 0x000000018332EF40-0x00000001833303B0
		private static void _GetTime(UnSafeString unSafeString); // 0x000000018637836C-0x0000000186378508
		private static void _GetLogType(UnSafeString unSafeString, UnityEngine.LogType type); // 0x00000001863782A8-0x000000018637836C
		public static UnSafeString Alloc(); // 0x0000000183330A40-0x0000000183330B30
		public static void Release(UnSafeString value); // 0x0000000183330B30-0x0000000183330C20
	}

	public class SceneViewMessageLogger : Beyond.Log.ILogger // TypeDefIndex: 61764
	{
		// Fields
		public bool enabled; // 0x10
	
		// Constructors
		public SceneViewMessageLogger(); // 0x00000001815EFCD0-0x00000001815EFCE0
	
		// Methods
		[IDTag(0)]
		public void Log(ref FLogMessage msg); // 0x00000001863788A8-0x00000001863788FC
		[IDTag(1)]
		public void Log(ref FLogMessage msg, float lifeTime); // 0x0000000186378840-0x00000001863788A8
		public void ClearLogs(string msg); // 0x00000001863787F0-0x0000000186378840
		public void ClearLogsRegex(string regexMsg); // 0x00000001863787A0-0x00000001863787F0
	}

	public class UnionLogger : Beyond.Log.ILogger // TypeDefIndex: 61765
	{
		// Fields
		internal Beyond.Log.ILogger s_consoleLogger; // 0x10
		internal Beyond.Log.ILogger s_netServerLogger; // 0x18
		private const int MAX_MSG_LEN = 2000; // Metadata: 0x0234FF40
	
		// Constructors
		public UnionLogger(); // 0x0000000184861930-0x0000000184861980
	
		// Methods
		public void SetServerLogger(Beyond.Log.ILogger log); // 0x0000000183E3E240-0x0000000183E3E280
		public void Log(ref FLogMessage msg); // 0x000000018313C020-0x000000018313C1A0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61766
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		static ILFixDynamicMethodWrapper(); // 0x0000000184D373A0-0x0000000184D37410
	
		// Methods
		public string __Gen_Wrap_0(EColorTag P0); // 0x00000001863735B8-0x0000000186373694
		public string __Gen_Wrap_1(ELogChannel P0); // 0x000000018637406C-0x000000018637415C
		public void __Gen_Wrap_2(object P0); // 0x00000001863633B4-0x0000000186363474
		public ELogLevel[] __Gen_Wrap_3(); // 0x00000001863755E0-0x00000001863756AC
		public void __Gen_Wrap_4(); // 0x00000001863761FC-0x0000000186376284
		public void __Gen_Wrap_5(ref FLogMessage P0); // 0x0000000186376F44-0x00000001863770B0
		public void __Gen_Wrap_6(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
		public void __Gen_Wrap_7(ELogLevel P0); // 0x0000000186377BF4-0x0000000186377CA0
		public bool __Gen_Wrap_8(ELogLevel P0); // 0x0000000186363214-0x00000001863632E4
		public void __Gen_Wrap_9(ELogChannel P0, ELogLevel P1, bool P2); // 0x0000000186377CA0-0x0000000186377D84
		public bool __Gen_Wrap_10(ELogChannel P0, ELogLevel P1); // 0x0000000186373694-0x0000000186373780
		public void __Gen_Wrap_11(ELogChannel P0, ELogLevel P1, EColorTag P2, object P3, object P4, object P5); // 0x0000000186373780-0x00000001863738A8
		public void __Gen_Wrap_12(ELogChannel P0, EColorTag P1, object P2, object P3, object P4); // 0x00000001863738A8-0x00000001863739C0
		public void __Gen_Wrap_13(ELogChannel P0, object P1); // 0x00000001863739C0-0x0000000186373A9C
		public void __Gen_Wrap_14(ELogChannel P0, EColorTag P1, object P2); // 0x0000000186373A9C-0x0000000186373B94
		public void __Gen_Wrap_15(ELogChannel P0, EColorTag P1, object P2, object P3); // 0x0000000186373B94-0x0000000186373C9C
		public void __Gen_Wrap_16(ELogChannel P0, object P1, object P2); // 0x0000000186373C9C-0x0000000186373D80
		public void __Gen_Wrap_17(object P0, object P1, object P2); // 0x0000000186373D80-0x0000000186373E64
		public void __Gen_Wrap_18(object P0, object P1, object P2, object P3); // 0x0000000186373E64-0x0000000186373F5C
		public void __Gen_Wrap_19(object P0, object P1, object P2, object P3, object P4); // 0x0000000186373F5C-0x000000018637406C
		public void __Gen_Wrap_20(object P0, object P1, object P2, object P3, object P4, object P5); // 0x000000018637415C-0x0000000186374274
		public void __Gen_Wrap_21(object P0, object P1, object P2, object P3, object P4, object P5, object P6); // 0x0000000186374274-0x000000018637439C
		public void __Gen_Wrap_22(object P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7); // 0x000000018637439C-0x00000001863744D4
		public void __Gen_Wrap_23(ELogChannel P0, object P1, object P2, object P3); // 0x00000001863744D4-0x00000001863745CC
		public void __Gen_Wrap_24(ELogChannel P0, object P1, object P2, object P3, object P4); // 0x00000001863745CC-0x00000001863746D8
		public void __Gen_Wrap_25(ELogChannel P0, object P1, object P2, object P3, object P4, object P5); // 0x00000001863746D8-0x00000001863747F0
		public void __Gen_Wrap_26(ELogChannel P0, object P1, object P2, object P3, object P4, object P5, object P6); // 0x00000001863747F0-0x0000000186374918
		public void __Gen_Wrap_27(ELogChannel P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7); // 0x0000000186374918-0x0000000186374A50
		public void __Gen_Wrap_28(ELogChannel P0, object P1, object P2, object P3, object P4, object P5, object P6, object P7, object P8); // 0x0000000186374A50-0x0000000186374B98
		public void __Gen_Wrap_29(ELogChannel P0, EnableLogType P1, EColorTag P2, object P3, object P4); // 0x0000000186374B98-0x0000000186374CB0
		public void __Gen_Wrap_30(EnableLogType P0, object P1); // 0x0000000186374CB0-0x0000000186374D8C
		public void __Gen_Wrap_31(EnableLogType P0, ELogChannel P1, object P2); // 0x0000000186374D8C-0x0000000186374E84
		public void __Gen_Wrap_32(EnableLogType P0, ELogChannel P1, EColorTag P2, object P3); // 0x0000000186374E84-0x0000000186374F7C
		public void __Gen_Wrap_33(EnableLogType P0, ELogChannel P1, EColorTag P2, object P3, object P4); // 0x0000000186374F7C-0x0000000186375088
		public void __Gen_Wrap_34(bool P0); // 0x0000000186375088-0x0000000186375148
		public void __Gen_Wrap_35(ELogLevel P0, ELogChannel P1, object P2, float P3); // 0x0000000186375148-0x0000000186375240
		public void __Gen_Wrap_36(ELogChannel P0, float P1, object P2); // 0x0000000186375240-0x0000000186375324
		public void __Gen_Wrap_37(ELogLevel P0, ELogChannel P1, object P2, object P3); // 0x0000000186375324-0x000000018637541C
		public void __Gen_Wrap_38(ELogLevel P0, ELogChannel P1, EColorTag P2, object P3, object P4); // 0x000000018637541C-0x0000000186375528
		public DLogger.DebugContext __Gen_Wrap_39(); // 0x0000000186375528-0x00000001863755E0
		public DLogger.DebugContextScope __Gen_Wrap_40(object P0, ELogLevel P1); // 0x00000001863756AC-0x00000001863757A4
		public string __Gen_Wrap_41(ELogLevel P0); // 0x00000001863757A4-0x0000000186375894
		public bool __Gen_Wrap_43(ref PlayerLoopSystem P0); // 0x0000000186375894-0x00000001863759F0
		public void __Gen_Wrap_44(PlayerLoopSystem P0, ref PlayerLoopSystem P1, object P2, object P3, bool P4, bool P5); // 0x00000001863759F0-0x0000000186375BC8
		public void __Gen_Wrap_45(ref PlayerLoopSystem P0); // 0x0000000186375BC8-0x0000000186375D14
		public void __Gen_Wrap_46(ref DLogger.DebugContextScope P0); // 0x0000000186375D14-0x0000000186375E2C
		public uint __Gen_Wrap_47(ref BitArray256 P0); // 0x0000000186375E2C-0x0000000186375F6C
		public bool __Gen_Wrap_48(ref BitArray256 P0); // 0x0000000186375F6C-0x00000001863760AC
		public string __Gen_Wrap_49(ref BitArray256 P0); // 0x00000001863760AC-0x00000001863761FC
		public bool __Gen_Wrap_50(ref BitArray256 P0, byte P1); // 0x0000000186376284-0x00000001863763F0
		public void __Gen_Wrap_51(ref BitArray256 P0, uint P1, bool P2); // 0x00000001863763F0-0x0000000186376554
		public void __Gen_Wrap_52(ref BitArray256 P0, byte P1, bool P2); // 0x0000000186376554-0x00000001863766BC
		public BitArray256 __Gen_Wrap_53(BitArray256 P0); // 0x00000001863766BC-0x00000001863767E8
		public BitArray256 __Gen_Wrap_54(BitArray256 P0, BitArray256 P1); // 0x00000001863767E8-0x0000000186376950
		public bool __Gen_Wrap_55(BitArray256 P0, BitArray256 P1); // 0x0000000186376950-0x0000000186376A84
		public bool __Gen_Wrap_56(ref BitArray256 P0, object P1); // 0x0000000186376A84-0x0000000186376BE0
		public int __Gen_Wrap_57(ref BitArray256 P0); // 0x0000000186376BE0-0x0000000186376D20
		public void __Gen_Wrap_58(ref BitArray256 P0); // 0x0000000186376D20-0x0000000186376E50
		public BitArray256 __Gen_Wrap_59(); // 0x0000000186376E50-0x0000000186376F44
		public bool __Gen_Wrap_60(); // 0x00000001863770B0-0x0000000186377148
		public string __Gen_Wrap_61(); // 0x0000000186377148-0x0000000186377214
		public int __Gen_Wrap_62(); // 0x0000000186377214-0x00000001863772AC
		public string __Gen_Wrap_63(long P0, int P1, object P2, ELogChannel P3, EColorTag P4, ELogLevel P5); // 0x00000001863772AC-0x0000000186377400
		public void __Gen_Wrap_64(ELogLevel P0, object P1, object P2, object P3); // 0x0000000186377400-0x0000000186377508
		public void __Gen_Wrap_65(object P0, ref FLogMessage P1); // 0x0000000186377508-0x000000018637768C
		public FLogMessage __Gen_Wrap_66(ELogChannel P0, object P1, object P2, UnityEngine.LogType P3); // 0x000000018637768C-0x00000001863777EC
		public UnSafeString __Gen_Wrap_67(); // 0x00000001863777EC-0x00000001863778A4
		public void __Gen_Wrap_68(object P0, object P1, UnityEngine.LogType P2); // 0x00000001863778A4-0x0000000186377988
		public void __Gen_Wrap_69(object P0, ref FLogMessage P1, float P2); // 0x0000000186377988-0x0000000186377B18
	}

	public class WrappersManagerImpl // TypeDefIndex: 61767
	{
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000186378938-0x00000001863789EC
		public static bool IsPatched(int id); // 0x0000000183330C20-0x0000000183330D50
	}
}
