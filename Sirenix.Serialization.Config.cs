/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using Sirenix.Utilities;

// Image 127: Sirenix.Serialization.Config.dll - Assembly: Sirenix.Serialization.Config, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61109-61116

namespace Sirenix.Serialization
{
	public class CustomLogger : ILogger // TypeDefIndex: 61110
	{
		// Fields
		private Action<string> logWarningDelegate; // 0x10
		private Action<string> logErrorDelegate; // 0x18
		private Action<Exception> logExceptionDelegate; // 0x20
	
		// Constructors
		public CustomLogger() {} // Dummy constructor
		public CustomLogger(Action<string> logWarningDelegate, Action<string> logErrorDelegate, Action<Exception> logExceptionDelegate) {} // 0x000000018B78D2B8-0x000000018B78D3FC
	
		// Methods
		public void LogWarning(string warning) {} // 0x0000000188E58AAC-0x0000000188E58ACC
		public void LogError(string error) {} // 0x000000018A6BD944-0x000000018A6BD964
		public void LogException(Exception exception) {} // 0x000000018B78D298-0x000000018B78D2B8
	}

	public enum DataFormat // TypeDefIndex: 61111
	{
		Binary = 0,
		JSON = 1,
		Nodes = 2
	}

	public static class DefaultLoggers // TypeDefIndex: 61112
	{
		// Fields
		private static readonly object LOCK; // 0x00
		private static ILogger unityLogger; // 0x08
	
		// Properties
		public static ILogger DefaultLogger { get; } // 0x000000018B78D46C-0x000000018B78D4AC 
		public static ILogger UnityLogger { get; } // 0x000000018B78D4AC-0x000000018B78D7AC 
	
		// Constructors
		static DefaultLoggers() {} // 0x000000018B78D3FC-0x000000018B78D46C
	}

	public enum ErrorHandlingPolicy // TypeDefIndex: 61113
	{
		Resilient = 0,
		ThrowOnErrors = 1,
		ThrowOnWarningsAndErrors = 2
	}

	public class GlobalSerializationConfig : GlobalConfig<Sirenix.Serialization.GlobalSerializationConfig> // TypeDefIndex: 61114
	{
		// Fields
		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_TEXT = "Odin\'s custom serialization protocol is stable and fast. It is built to be fast, reliable and resilient above all.\n\n*Words of caution* \nHowever, caveats apply - there is a reason Unity chose such a drastically limited serialization protocol. It keeps things simple and manageable, and limits how much complexity you can introduce into your data structures. It can be very easy to get carried away and shoot yourself in the foot when all limitations suddenly disappear, and hence we have included this cautionary warning.\n\nWarning words aside, there can of course be valid reasons to use a more powerful serialization protocol such as Odin\'s. However, we advise you to use it wisely and with restraint. After all, with great power comes great responsibility!"; // Metadata: 0x02082EA8
		public const string ODIN_PREFAB_CAUTIONARY_WARNING_TEXT = "In 2018.3, Unity introduced a new prefab workflow, and in so doing, changed how all prefabs fundamentally work. Despite our best efforts, we have so far been unable to achieve a stable implementation of Odin-serialized prefab modifications on prefab instances and variants in the new prefab workflow.This has nothing to do with Odin serializer itself, which remains rock solid. Odin-serialized ScriptableObjects and non-prefab Components/Behaviours are still perfectly stable - you are only seeing this message because this is an Odin-serialized prefab asset or instance.\n\nUsing prefabs with Odin serialization in 2018.3 and above is considered a *deprecated feature* and is officially unsupported. In short, if you disregard this message and then experience issues, we will not be able to help or support you.\n\nPlease keep all this in mind, if you wish to continue using Odin-serialized prefabs."; // Metadata: 0x0208319F
		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_BUTTON_TEXT = "I know what I\'m about, son. Hide message forever."; // Metadata: 0x02083521
		public const string ODIN_PREFAB_CAUTIONARY_WARNING_BUTTON_TEXT = "I understand that I\'m on my own. Hide message forever."; // Metadata: 0x02083553
		private static readonly DataFormat[] BuildFormats; // 0x00
		public bool HideSerializationCautionaryMessage; // 0x18
		public bool HidePrefabCautionaryMessage; // 0x19
		public bool HideOdinSerializeAttributeWarningMessages; // 0x1A
		public bool HideNonSerializedShowInInspectorWarningMessages; // 0x1B
		private DataFormat buildSerializationFormat; // 0x1C
		private DataFormat editorSerializationFormat; // 0x20
		private LoggingPolicy loggingPolicy; // 0x24
		private ErrorHandlingPolicy errorHandlingPolicy; // 0x28
	
		// Properties
		public ILogger Logger { get => default; } // 0x000000018B78DB40-0x000000018B78DB80 
		public DataFormat EditorSerializationFormat { get => default; set {} } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public DataFormat BuildSerializationFormat { get => default; set {} } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
		public LoggingPolicy LoggingPolicy { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		public ErrorHandlingPolicy ErrorHandlingPolicy { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
	
		// Constructors
		public GlobalSerializationConfig() {} // 0x000000018B78DB04-0x000000018B78DB40
		static GlobalSerializationConfig() {} // 0x000000018B78DA7C-0x000000018B78DB04
	
		// Methods
		private void OnInspectorGUI() {} // 0x000000018B78D7AC-0x000000018B78DA7C
	}

	public interface ILogger // TypeDefIndex: 61115
	{
		// Methods
		void LogWarning(string warning);
		void LogError(string error);
		void LogException(Exception exception);
	}

	public enum LoggingPolicy // TypeDefIndex: 61116
	{
		LogErrors = 0,
		LogWarningsAndErrors = 1,
		Silent = 2
	}
}
