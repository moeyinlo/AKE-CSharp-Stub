/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Sirenix.Utilities;
using UnityEngine;

// Image 124: Sirenix.Serialization.Config.dll - Assembly: Sirenix.Serialization.Config, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60004-60011

namespace Sirenix.Serialization
{
	public class CustomLogger : ILogger // TypeDefIndex: 60005
	{
		// Fields
		private Action<string> logWarningDelegate; // 0x10
		private Action<string> logErrorDelegate; // 0x18
		private Action<Exception> logExceptionDelegate; // 0x20
	
		// Constructors
		public CustomLogger() {} // Dummy constructor
		public CustomLogger(Action<string> logWarningDelegate, Action<string> logErrorDelegate, Action<Exception> logExceptionDelegate) {} // 0x000000018966719C-0x00000001896672E0
	
		// Methods
		public void LogWarning(string warning) {} // 0x0000000186D51538-0x0000000186D51558
		public void LogError(string error) {} // 0x0000000188593F38-0x0000000188593F58
		public void LogException(Exception exception) {} // 0x000000018966717C-0x000000018966719C
	}

	public enum DataFormat // TypeDefIndex: 60006
	{
		Binary = 0,
		JSON = 1,
		Nodes = 2
	}

	public static class DefaultLoggers // TypeDefIndex: 60007
	{
		// Fields
		private static readonly object LOCK; // 0x00
		private static ILogger unityLogger; // 0x08
	
		// Properties
		public static ILogger DefaultLogger { get; } // 0x0000000189667350-0x0000000189667390 
		public static ILogger UnityLogger { get; } // 0x0000000189667390-0x0000000189667690 
	
		// Constructors
		static DefaultLoggers() {} // 0x00000001896672E0-0x0000000189667350
	}

	public enum ErrorHandlingPolicy // TypeDefIndex: 60008
	{
		Resilient = 0,
		ThrowOnErrors = 1,
		ThrowOnWarningsAndErrors = 2
	}

	[SirenixGlobalConfig]
	public class GlobalSerializationConfig : GlobalConfig<Sirenix.Serialization.GlobalSerializationConfig> // TypeDefIndex: 60009
	{
		// Fields
		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_TEXT = "Odin\'s custom serialization protocol is stable and fast. It is built to be fast, reliable and resilient above all.\n\n*Words of caution* \nHowever, caveats apply - there is a reason Unity chose such a drastically limited serialization protocol. It keeps things simple and manageable, and limits how much complexity you can introduce into your data structures. It can be very easy to get carried away and shoot yourself in the foot when all limitations suddenly disappear, and hence we have included this cautionary warning.\n\nWarning words aside, there can of course be valid reasons to use a more powerful serialization protocol such as Odin\'s. However, we advise you to use it wisely and with restraint. After all, with great power comes great responsibility!"; // Metadata: 0x01FDD5BD
		public const string ODIN_PREFAB_CAUTIONARY_WARNING_TEXT = "In 2018.3, Unity introduced a new prefab workflow, and in so doing, changed how all prefabs fundamentally work. Despite our best efforts, we have so far been unable to achieve a stable implementation of Odin-serialized prefab modifications on prefab instances and variants in the new prefab workflow.This has nothing to do with Odin serializer itself, which remains rock solid. Odin-serialized ScriptableObjects and non-prefab Components/Behaviours are still perfectly stable - you are only seeing this message because this is an Odin-serialized prefab asset or instance.\n\nUsing prefabs with Odin serialization in 2018.3 and above is considered a *deprecated feature* and is officially unsupported. In short, if you disregard this message and then experience issues, we will not be able to help or support you.\n\nPlease keep all this in mind, if you wish to continue using Odin-serialized prefabs."; // Metadata: 0x01FDD8B4
		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_BUTTON_TEXT = "I know what I\'m about, son. Hide message forever."; // Metadata: 0x01FDDC36
		public const string ODIN_PREFAB_CAUTIONARY_WARNING_BUTTON_TEXT = "I understand that I\'m on my own. Hide message forever."; // Metadata: 0x01FDDC68
		private static readonly DataFormat[] BuildFormats; // 0x00
		public bool HideSerializationCautionaryMessage; // 0x18
		public bool HidePrefabCautionaryMessage; // 0x19
		[SerializeField]
		public bool HideOdinSerializeAttributeWarningMessages; // 0x1A
		[SerializeField]
		public bool HideNonSerializedShowInInspectorWarningMessages; // 0x1B
		[SerializeField]
		private DataFormat buildSerializationFormat; // 0x1C
		[SerializeField]
		private DataFormat editorSerializationFormat; // 0x20
		[SerializeField]
		private LoggingPolicy loggingPolicy; // 0x24
		[SerializeField]
		private ErrorHandlingPolicy errorHandlingPolicy; // 0x28
	
		// Properties
		public ILogger Logger { get => default; } // 0x0000000189667A24-0x0000000189667A64 
		public DataFormat EditorSerializationFormat { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public DataFormat BuildSerializationFormat { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public LoggingPolicy LoggingPolicy { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public ErrorHandlingPolicy ErrorHandlingPolicy { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
	
		// Constructors
		public GlobalSerializationConfig() {} // 0x00000001896679E8-0x0000000189667A24
		static GlobalSerializationConfig() {} // 0x0000000189667960-0x00000001896679E8
	
		// Methods
		private void OnInspectorGUI() {} // 0x0000000189667690-0x0000000189667960
	}

	public interface ILogger // TypeDefIndex: 60010
	{
		// Methods
		void LogWarning(string warning);
		void LogError(string error);
		void LogException(Exception exception);
	}

	public enum LoggingPolicy // TypeDefIndex: 60011
	{
		LogErrors = 0,
		LogWarningsAndErrors = 1,
		Silent = 2
	}
}
