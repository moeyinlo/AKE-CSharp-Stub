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

// Image 129: Sirenix.Serialization.Config.dll - Assembly: Sirenix.Serialization.Config, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63745-63752
[assembly: AssemblyCompany("Sirenix ApS")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCopyright("Copyright \u00A9 2022")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyProduct("Sirenix.Serialization.Config")]
[assembly: AssemblyTitle("Sirenix.Serialization.Config")]
[assembly: AssemblyTrademark("")]
[assembly: CLSCompliant(false)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Guid("74721B9F-0AF4-48F5-AE2E-91102A1A5EDD")]
[assembly: PersistentAssembly]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Sirenix.Serialization
{
	public class CustomLogger : ILogger // TypeDefIndex: 63746
	{
		// Fields
		private Action<string> logWarningDelegate; // 0x10
		private Action<string> logErrorDelegate; // 0x18
		private Action<Exception> logExceptionDelegate; // 0x20
	
		// Constructors
		public CustomLogger(Action<string> logWarningDelegate, Action<string> logErrorDelegate, Action<Exception> logExceptionDelegate); // 0x000000018AC46D10-0x000000018AC46E54
	
		// Methods
		public void LogWarning(string warning); // 0x000000018810F944-0x000000018810F964
		public void LogError(string error); // 0x0000000189B21654-0x0000000189B21674
		public void LogException(Exception exception); // 0x000000018AC46CF0-0x000000018AC46D10
	}

	public enum DataFormat // TypeDefIndex: 63747
	{
		Binary = 0,
		JSON = 1,
		Nodes = 2
	}

	public static class DefaultLoggers // TypeDefIndex: 63748
	{
		// Fields
		private static readonly object LOCK; // 0x00
		private static ILogger unityLogger; // 0x08
	
		// Properties
		public static ILogger DefaultLogger { get; } // 0x000000018AC46EC4-0x000000018AC46F04 
		public static ILogger UnityLogger { get; } // 0x000000018AC46F04-0x000000018AC47204 
	
		// Constructors
		static DefaultLoggers(); // 0x000000018AC46E54-0x000000018AC46EC4
	}

	public enum ErrorHandlingPolicy // TypeDefIndex: 63749
	{
		Resilient = 0,
		ThrowOnErrors = 1,
		ThrowOnWarningsAndErrors = 2
	}

	[SirenixGlobalConfig]
	public class GlobalSerializationConfig : GlobalConfig<Sirenix.Serialization.GlobalSerializationConfig> // TypeDefIndex: 63750
	{
		// Fields
		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_TEXT = "Odin\'s custom serialization protocol is stable and fast. It is built to be fast, reliable and resilient above all.\n\n*Words of caution* \nHowever, caveats apply - there is a reason Unity chose such a drastically limited serialization protocol. It keeps things simple and manageable, and limits how much complexity you can introduce into your data structures. It can be very easy to get carried away and shoot yourself in the foot when all limitations suddenly disappear, and hence we have included this cautionary warning.\n\nWarning words aside, there can of course be valid reasons to use a more powerful serialization protocol such as Odin\'s. However, we advise you to use it wisely and with restraint. After all, with great power comes great responsibility!"; // Metadata: 0x02352B28
		public const string ODIN_PREFAB_CAUTIONARY_WARNING_TEXT = "In 2018.3, Unity introduced a new prefab workflow, and in so doing, changed how all prefabs fundamentally work. Despite our best efforts, we have so far been unable to achieve a stable implementation of Odin-serialized prefab modifications on prefab instances and variants in the new prefab workflow.This has nothing to do with Odin serializer itself, which remains rock solid. Odin-serialized ScriptableObjects and non-prefab Components/Behaviours are still perfectly stable - you are only seeing this message because this is an Odin-serialized prefab asset or instance.\n\nUsing prefabs with Odin serialization in 2018.3 and above is considered a *deprecated feature* and is officially unsupported. In short, if you disregard this message and then experience issues, we will not be able to help or support you.\n\nPlease keep all this in mind, if you wish to continue using Odin-serialized prefabs."; // Metadata: 0x02352E1F
		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_BUTTON_TEXT = "I know what I\'m about, son. Hide message forever."; // Metadata: 0x023531A1
		public const string ODIN_PREFAB_CAUTIONARY_WARNING_BUTTON_TEXT = "I understand that I\'m on my own. Hide message forever."; // Metadata: 0x023531D3
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
		public ILogger Logger { get; } // 0x000000018AC47598-0x000000018AC475D8 
		public DataFormat EditorSerializationFormat { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public DataFormat BuildSerializationFormat { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		public LoggingPolicy LoggingPolicy { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public ErrorHandlingPolicy ErrorHandlingPolicy { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
	
		// Constructors
		public GlobalSerializationConfig(); // 0x000000018AC4755C-0x000000018AC47598
		static GlobalSerializationConfig(); // 0x000000018AC474D4-0x000000018AC4755C
	
		// Methods
		private void OnInspectorGUI(); // 0x000000018AC47204-0x000000018AC474D4
	}

	public interface ILogger // TypeDefIndex: 63751
	{
		// Methods
		void LogWarning(string warning);
		void LogError(string error);
		void LogException(Exception exception);
	}

	public enum LoggingPolicy // TypeDefIndex: 63752
	{
		LogErrors = 0,
		LogWarningsAndErrors = 1,
		Silent = 2
	}
}
