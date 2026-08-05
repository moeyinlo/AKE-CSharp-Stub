/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using SRDebugger;
using SRDebugger.Scripts;
using SRDebugger.Services;
using SRDebugger.UI;
using SRDebugger.UI.Controls;
using SRDebugger.UI.Controls.Data;
using SRDebugger.UI.Other;
using SRF;
using SRF.Helpers;
using SRF.Service;
using SRF.UI;
using SRF.UI.Layout;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Image 48: StompyRobot.SRDebugger.dll - Assembly: StompyRobot.SRDebugger, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60199-60357
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("StompyRobot.SRDebugger.Editor")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public static class SRDebug // TypeDefIndex: 60201
{
	// Fields
	public const string Version = "1.12.1"; // Metadata: 0x0234D2B6
	[CompilerGenerated]
	private static bool _IsInitialized_k__BackingField; // 0x00
	public static Action<ConsoleEntry> CopyConsoleItemCallback; // 0x08

	// Properties
	public static bool IsInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018AC97118-0x000000018AC97168 0x000000018AC97168-0x000000018AC971BC
	public static IDebugService Instance { get; } // 0x000000018AC970EC-0x000000018AC97118 

	// Nested types
	[Serializable]
	[CompilerGenerated]
	private sealed class __c // TypeDefIndex: 60200
	{
		// Fields
		public static readonly __c __9; // 0x00
		public static Action<ConsoleEntry> __9__9_0; // 0x08

		// Constructors
		static __c(); // 0x0000000184D449B0-0x0000000184D44A10
		public __c(); // 0x00000001841E1670-0x00000001841E1680

		// Methods
		internal void _GetDefaultCopyConsoleItemCallback_b__9_0(ConsoleEntry entry); // 0x000000018AC99254-0x000000018AC992D4
	}

	// Constructors
	static SRDebug(); // 0x0000000184B4AA70-0x0000000184B4AAD0

	// Methods
	public static void Init(); // 0x0000000184A24910-0x0000000184A24A00
	public static Action<ConsoleEntry> GetDefaultCopyConsoleItemCallback(); // 0x0000000184B4AAD0-0x0000000184B4ABD0
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 60357
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_36 _0B92E635AE849B517CA3A2F28C2502AF8675E5C6C01CD75EA9F53120E81DDAAA; // 0x00 // Static value (base64): CtejO83MzDuJiAg8CtcjPImIiDyJiAg9zcxMPauqqj2rqio+ - Metadata: 0x0234D554

	// Nested types
	private struct __StaticArrayInitTypeSize_36 // TypeDefIndex: 60356
	{
	}
}

namespace Assets.StompyRobot.SRDebugger.Scripts.Services.Implementation
{
	[Service(typeof(IConsoleFilterState))]
	public sealed class ConsoleFilterStateService : IConsoleFilterState // TypeDefIndex: 60202
	{
		// Fields
		[CompilerGenerated]
		private ConsoleStateChangedEventHandler FilterStateChange; // 0x10
		private readonly bool[] _states; // 0x18
	
		// Events
		public event ConsoleStateChangedEventHandler FilterStateChange {
			add; // 0x000000018AC8AF94-0x000000018AC8B028
			remove; // 0x000000018AC8B0BC-0x000000018AC8B150
		}
	
		// Constructors
		public ConsoleFilterStateService(); // 0x000000018AC8AE18-0x000000018AC8AF00
	
		// Methods
		public void SetConsoleFilterState(UnityEngine.LogType type, bool newState); // 0x000000018AC8ACC0-0x000000018AC8AD30
		public bool GetConsoleFilterState(UnityEngine.LogType type); // 0x000000018AC8AC44-0x000000018AC8AC80
		private static UnityEngine.LogType GetType(UnityEngine.LogType type); // 0x000000018AC8AC80-0x000000018AC8ACC0
	}
}

namespace SRDebugger
{
	public static class AutoInitialize // TypeDefIndex: 60203
	{
		// Fields
		private const RuntimeInitializeLoadType InitializeLoadType = RuntimeInitializeLoadType.SubsystemRegistration; // Metadata: 0x0234D2BD
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void OnLoadBeforeScene(); // 0x0000000184A24A00-0x0000000184A24AA0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		public static void OnLoad(); // 0x0000000184A248B0-0x0000000184A24910
	}

	public class BugReport // TypeDefIndex: 60204
	{
		// Fields
		public List<ConsoleEntry> ConsoleLog; // 0x10
		public string Email; // 0x18
		public byte[] ScreenshotData; // 0x20
		public Dictionary<string, Dictionary<string, object>> SystemInformation; // 0x28
		public string UserDescription; // 0x30
	
		// Constructors
		public BugReport(); // 0x00000001841E1670-0x00000001841E1680
	}

	public sealed class BugReportSubmitResult // TypeDefIndex: 60205
	{
		// Fields
		[CompilerGenerated]
		private readonly bool _IsSuccessful_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly string _ErrorMessage_k__BackingField; // 0x18
	
		// Properties
		public static BugReportSubmitResult Success { get; } // 0x000000018AC89E9C-0x000000018AC89EF0 
		public bool IsSuccessful { [CompilerGenerated] get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
		public string ErrorMessage { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
	
		// Constructors
		private BugReportSubmitResult(bool successful, string error); // 0x0000000183219380-0x0000000183219390
	
		// Methods
		public static BugReportSubmitResult Error(string errorMessage); // 0x000000018AC89E40-0x000000018AC89E9C
	}

	public interface IBugReporterHandler // TypeDefIndex: 60206
	{
		// Properties
		bool IsUsable { get; }
	
		// Methods
		void Submit(BugReport report, Action<BugReportSubmitResult> onComplete, IProgress<float> progress);
	}

	public class CircularBuffer<T> : IReadOnlyList<T> // TypeDefIndex: 60208
	{
		// Fields
		private readonly T[] _buffer;
		private int _end;
		private int _count;
		private int _start;
	
		// Properties
		public int Capacity { get; }
		public bool IsFull { get; }
		public bool IsEmpty { get; }
		public int Count { get; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__18 : IEnumerator<T> // TypeDefIndex: 60207
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public CircularBuffer<T> __4__this;
			private ArraySegment<T>[] __7__wrap1;
			private int __7__wrap2;
			private ArraySegment<T> _segment_5__4;
			private int _i_5__5;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CircularBuffer(int capacity);
		public CircularBuffer(int capacity, T[] items);
	
		// Methods
		public void Clear();
		[IteratorStateMachine(typeof(_GetEnumerator_d__18))]
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public T Front();
		public T Back();
		public void PushBack(T item);
		public void PushFront(T item);
		public void PopBack();
		public void PopFront();
		public T[] ToArray();
		private void ThrowIfEmpty(string message = "Cannot access an empty buffer." /* Metadata: 0x0234D2BE */);
		private void Increment(ref int index);
		private void Decrement(ref int index);
		private int InternalIndex(int index);
		private ArraySegment<T> ArrayOne();
		private ArraySegment<T> ArrayTwo();
	}

	public sealed class OptionDefinition // TypeDefIndex: 60209
	{
		// Fields
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Category_k__BackingField; // 0x18
		[CompilerGenerated]
		private int _SortPriority_k__BackingField; // 0x20
		[CompilerGenerated]
		private MethodReference _Method_k__BackingField; // 0x28
		[CompilerGenerated]
		private PropertyReference _Property_k__BackingField; // 0x30
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string Category { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public int SortPriority { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public bool IsMethod { get; } // 0x00000001868C60A8-0x00000001868C60B4 
		public bool IsProperty { get; } // 0x0000000189B11948-0x0000000189B11954 
		public MethodReference Method { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public PropertyReference Property { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	
		// Constructors
		private OptionDefinition(string name, string category, int sortPriority); // 0x00000001847E1B40-0x00000001847E1B70
		public OptionDefinition(string name, string category, int sortPriority, MethodReference method); // 0x000000018AC9214C-0x000000018AC9217C
		public OptionDefinition(string name, string category, int sortPriority, PropertyReference property); // 0x000000018AC9211C-0x000000018AC9214C
	
		// Methods
		public static OptionDefinition FromMethod(string name, Action callback, string category = "Default" /* Metadata: 0x0234D2DD */, int sortPriority = 0 /* Metadata: 0x0234D2E5 */); // 0x000000018AC92078-0x000000018AC9211C
		public static OptionDefinition Create<T>(string name, Func<T> getter, Action<T> setter = null, string category = "Default" /* Metadata: 0x0234D2E6 */, int sortPriority = 0 /* Metadata: 0x0234D2EE */);
	}

	public interface IOptionContainer // TypeDefIndex: 60210
	{
		// Properties
		bool IsDynamic { get; }
	
		// Events
		event Action<OptionDefinition> OptionAdded {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		event Action<OptionDefinition> OptionRemoved {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		IEnumerable<OptionDefinition> GetOptions();
	}

	public sealed class DynamicOptionContainer : IOptionContainer // TypeDefIndex: 60211
	{
		// Fields
		private readonly List<OptionDefinition> _options; // 0x10
		private readonly IList<OptionDefinition> _optionsReadOnly; // 0x18
		[CompilerGenerated]
		private Action<OptionDefinition> OptionAdded; // 0x20
		[CompilerGenerated]
		private Action<OptionDefinition> OptionRemoved; // 0x28
	
		// Properties
		public IList<OptionDefinition> Options { get; } // 0x000000018385B100-0x000000018385B110 
		public bool IsDynamic { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Events
		public event Action<OptionDefinition> OptionAdded {
			add; // 0x000000018AC8EBE8-0x000000018AC8EC74
			remove; // 0x000000018AC8ED00-0x000000018AC8ED8C
		}
		public event Action<OptionDefinition> OptionRemoved {
			add; // 0x000000018AC8EC74-0x000000018AC8ED00
			remove; // 0x000000018AC8ED8C-0x000000018AC8EE18
		}
	
		// Constructors
		public DynamicOptionContainer(); // 0x000000018AC8EB44-0x000000018AC8EBE8
	
		// Methods
		public void AddOption(OptionDefinition option); // 0x000000018AC8EA64-0x000000018AC8EAD0
		public bool RemoveOption(OptionDefinition option); // 0x000000018AC8EAD0-0x000000018AC8EB44
		IEnumerable<OptionDefinition> IOptionContainer.GetOptions(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
	}

	public delegate void VisibilityChangedDelegate(bool isVisible); // TypeDefIndex: 60212; 0x0000000182B46B90-0x0000000182B46BA0

	public delegate void ActionCompleteCallback(bool success); // TypeDefIndex: 60213; 0x0000000182B46B90-0x0000000182B46BA0

	public delegate void PinnedUiCanvasCreated(RectTransform canvasTransform); // TypeDefIndex: 60214; 0x0000000182B46B90-0x0000000182B46BA0

	public struct EntryCode : IReadOnlyList<int> // TypeDefIndex: 60215
	{
		// Fields
		public readonly int Digit1; // 0x00
		public readonly int Digit2; // 0x04
		public readonly int Digit3; // 0x08
		public readonly int Digit4; // 0x0C
	
		// Properties
		public int Count { get; } // 0x0000000184D882B0-0x0000000184D882C0 
		public int this[int index] { get => default; } // 0x000000018AC8F108-0x000000018AC8F18C 
	
		// Constructors
		public EntryCode(int digit1, int digit2, int digit3, int digit4); // 0x000000018AC8EF30-0x000000018AC8F108
	
		// Methods
		public IEnumerator<int> GetEnumerator(); // 0x000000018AC8EE18-0x000000018AC8EF28
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018AC8EF28-0x000000018AC8EF30
	}

	public sealed class InfoEntry // TypeDefIndex: 60217
	{
		// Fields
		[CompilerGenerated]
		private string _Title_k__BackingField; // 0x10
		[CompilerGenerated]
		private bool _IsPrivate_k__BackingField; // 0x18
		private Func<object> _valueGetter; // 0x20
	
		// Properties
		public string Title { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public object Value { get; } // 0x000000018AC8FAB4-0x000000018AC8FBC8 
		public bool IsPrivate { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 60216
		{
			// Fields
			public object value; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _Create_b__0(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		}
	
		// Constructors
		public InfoEntry(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static InfoEntry Create(string name, Func<object> getter, bool isPrivate = false /* Metadata: 0x0234D2EF */); // 0x00000001841A8030-0x00000001841A80C0
		public static InfoEntry Create(string name, object value, bool isPrivate = false /* Metadata: 0x0234D2F0 */); // 0x00000001841A80C0-0x00000001841A81D0
	}

	public enum DefaultTabs // TypeDefIndex: 60218
	{
		SystemInformation = 0,
		Options = 1,
		Console = 2,
		Profiler = 3,
		BugReporter = 4
	}

	public enum PinAlignment // TypeDefIndex: 60219
	{
		TopLeft = 0,
		TopRight = 1,
		BottomLeft = 2,
		BottomRight = 3,
		CenterLeft = 4,
		CenterRight = 5,
		TopCenter = 6,
		BottomCenter = 7
	}

	public enum ConsoleAlignment // TypeDefIndex: 60220
	{
		Top = 0,
		Bottom = 1
	}

	public class Settings : ScriptableObject // TypeDefIndex: 60227
	{
		// Fields
		internal const string ResourcesName = "Settings"; // Metadata: 0x0234D300
		private static Settings _instance; // 0x00
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged; // 0x18
		[SerializeField]
		private bool _isEnabled; // 0x20
		[SerializeField]
		private bool _disableWelcomePopup; // 0x21
		[SerializeField]
		private UIModes _uiInputMode; // 0x24
		[SerializeField]
		private DefaultTabs _defaultTab; // 0x28
		[SerializeField]
		private TriggerEnableModes _triggerEnableMode; // 0x2C
		[SerializeField]
		private TriggerBehaviours _triggerBehaviour; // 0x30
		[SerializeField]
		private bool _errorNotification; // 0x34
		[SerializeField]
		private bool _enableKeyboardShortcuts; // 0x35
		[SerializeField]
		private KeyboardShortcut[] _keyboardShortcuts; // 0x38
		[SerializeField]
		private KeyboardShortcut[] _newKeyboardShortcuts; // 0x40
		[SerializeField]
		private bool _keyboardModifierControl; // 0x48
		[SerializeField]
		private bool _keyboardModifierAlt; // 0x49
		[SerializeField]
		private bool _keyboardModifierShift; // 0x4A
		[SerializeField]
		private bool _keyboardEscapeClose; // 0x4B
		[SerializeField]
		private bool _enableBackgroundTransparency; // 0x4C
		[SerializeField]
		private float _backgroundTransparency; // 0x50
		[SerializeField]
		private bool _collapseDuplicateLogEntries; // 0x54
		[SerializeField]
		private bool _richTextInConsole; // 0x55
		[SerializeField]
		private bool _requireEntryCode; // 0x56
		[SerializeField]
		private bool _requireEntryCodeEveryTime; // 0x57
		[SerializeField]
		private int[] _entryCode; // 0x58
		[SerializeField]
		private bool _useDebugCamera; // 0x60
		[SerializeField]
		private int _debugLayer; // 0x64
		[Range(-100f, 100f)]
		[SerializeField]
		private float _debugCameraDepth; // 0x68
		[SerializeField]
		private string _apiKey; // 0x70
		[SerializeField]
		private bool _enableBugReporter; // 0x78
		[SerializeField]
		private bool _enableBugReportScreenshot; // 0x79
		[SerializeField]
		private DefaultTabs[] _disabledTabs; // 0x80
		[SerializeField]
		private PinAlignment _profilerAlignment; // 0x88
		[SerializeField]
		private PinAlignment _optionsAlignment; // 0x8C
		[SerializeField]
		private ConsoleAlignment _consoleAlignment; // 0x90
		[SerializeField]
		private PinAlignment _triggerPosition; // 0x94
		[SerializeField]
		private int _maximumConsoleEntries; // 0x98
		[SerializeField]
		private bool _enableEventSystemCreation; // 0x9C
		[SerializeField]
		private bool _automaticShowCursor; // 0x9D
		[SerializeField]
		private float _uiScale; // 0xA0
		[SerializeField]
		private bool _unloadOnClose; // 0xA4
	
		// Properties
		public static Settings Instance { get; } // 0x0000000183E3E580-0x0000000183E3E690 
		public bool IsEnabled { get; } // 0x0000000184D866B0-0x0000000184D866C0 
		public UIModes UIInputMode { get; } // 0x00000001811F0020-0x00000001811F0030 
		public DefaultTabs DefaultTab { get; } // 0x00000001811F2A90-0x00000001811F2AA0 
		public TriggerEnableModes EnableTrigger { get; } // 0x0000000184D86710-0x0000000184D86720 
		public TriggerBehaviours TriggerBehaviour { get; } // 0x0000000184D864F0-0x0000000184D86500 
		public bool ErrorNotification { get; } // 0x0000000184D86A90-0x0000000184D86AA0 
		public bool EnableKeyboardShortcuts { get; } // 0x0000000184D86D30-0x0000000184D86D40 
		public IList<KeyboardShortcut> KeyboardShortcuts { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public bool KeyboardEscapeClose { get; } // 0x0000000184D8EC30-0x0000000184D8EC40 
		public bool EnableBackgroundTransparency { get; } // 0x0000000184D86910-0x0000000184D86920 
		public float BackgroundTransparency { get; } // 0x0000000184D885A0-0x0000000184D885B0 
		public bool RequireCode { get; } // 0x0000000184D92D20-0x0000000184D92D30 
		public bool RequireEntryCodeEveryTime { get; } // 0x0000000184D92D30-0x0000000184D92D40 
		public IList<int> EntryCode { get; set; } // 0x000000018AC98268-0x000000018AC982DC 0x000000018AC98370-0x000000018AC98580
		public bool UseDebugCamera { get; } // 0x0000000184D88340-0x0000000184D88350 
		public int DebugLayer { get; } // 0x0000000184D88110-0x0000000184D88120 
		public float DebugCameraDepth { get; } // 0x0000000184D8F060-0x0000000184D8F070 
		public bool CollapseDuplicateLogEntries { get; } // 0x0000000184D86C20-0x0000000184D86C30 
		public bool RichTextInConsole { get; } // 0x0000000184D86C10-0x0000000184D86C20 
		public string ApiKey { get; } // 0x0000000184D862B0-0x0000000184D862C0 
		public bool EnableBugReporter { get; } // 0x0000000184D86F90-0x0000000184D86FA0 
		public bool EnableBugReportScreenshot { get; } // 0x0000000184D88E40-0x0000000184D88E50 
		public IList<DefaultTabs> DisabledTabs { get; } // 0x0000000184D86260-0x0000000184D86270 
		public PinAlignment TriggerPosition { get; } // 0x0000000184D86B20-0x0000000184D86B30 
		public PinAlignment ProfilerAlignment { get; } // 0x0000000184D86890-0x0000000184D868A0 
		public PinAlignment OptionsAlignment { get; } // 0x0000000184D90C40-0x0000000184D90C50 
		public ConsoleAlignment ConsoleAlignment { get; set; } // 0x0000000184D86B60-0x0000000184D86B70 0x0000000184D86BC0-0x0000000184D86BD0
		public int MaximumConsoleEntries { get; set; } // 0x0000000184D862D0-0x0000000184D862E0 0x0000000184D86300-0x0000000184D86310
		public bool EnableEventSystemGeneration { get; set; } // 0x0000000184D92ED0-0x0000000184D92EE0 0x0000000184D92F60-0x0000000184D92F70
		public bool AutomaticallyShowCursor { get; } // 0x0000000184DA34D0-0x0000000184DA34E0 
		public float UIScale { get; set; } // 0x0000000184D91E60-0x0000000184D91E70 0x000000018AC98580-0x000000018AC985E0
		public bool UnloadOnClose { get; } // 0x0000000184D88D60-0x0000000184D88D70 
	
		// Events
		public event PropertyChangedEventHandler PropertyChanged {
			add; // 0x000000018AC981D4-0x000000018AC98268
			remove; // 0x000000018AC982DC-0x000000018AC98370
		}
	
		// Nested types
		public enum ShortcutActions // TypeDefIndex: 60221
		{
			None = 0,
			OpenSystemInfoTab = 1,
			OpenConsoleTab = 2,
			OpenOptionsTab = 3,
			OpenProfilerTab = 4,
			OpenBugReporterTab = 5,
			ClosePanel = 6,
			OpenPanel = 7,
			TogglePanel = 8,
			ShowBugReportPopover = 9,
			ToggleDockedConsole = 10,
			ToggleDockedProfiler = 11
		}
	
		public enum TriggerBehaviours // TypeDefIndex: 60222
		{
			TripleTap = 0,
			TapAndHold = 1,
			DoubleTap = 2
		}
	
		public enum TriggerEnableModes // TypeDefIndex: 60223
		{
			Enabled = 0,
			MobileOnly = 1,
			Off = 2,
			DevelopmentBuildsOnly = 3
		}
	
		public enum UIModes // TypeDefIndex: 60224
		{
			NewInputSystem = 0,
			LegacyInputSystem = 1
		}
	
		[Serializable]
		public sealed class KeyboardShortcut // TypeDefIndex: 60225
		{
			// Fields
			[SerializeField]
			public ShortcutActions Action; // 0x10
			[SerializeField]
			public bool Alt; // 0x14
			[SerializeField]
			public bool Control; // 0x15
			[SerializeField]
			public KeyCode Key; // 0x18
			[SerializeField]
			public bool Shift; // 0x1C
			[NonSerialized]
			public UnityEngine.InputSystem.Key? Cached_KeyCode; // 0x20
	
			// Constructors
			public KeyboardShortcut(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 60226
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<int, bool> __9__42_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018AC993F4-0x000000018AC99458
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _set_EntryCode_b__42_0(int p); // 0x000000018AC99334-0x000000018AC99344
		}
	
		// Constructors
		public Settings(); // 0x000000018485C270-0x000000018485C390
	
		// Methods
		private static KeyboardShortcut[] GetDefaultKeyboardShortcuts(); // 0x000000018485C390-0x000000018485C4D0
		private void UpgradeKeyboardShortcuts(); // 0x0000000184A34530-0x0000000184A345D0
		private void OnPropertyChanged(string propertyName); // 0x000000018AC98144-0x000000018AC981D4
		internal static void ClearCache(); // 0x000000018AC980A4-0x000000018AC98144
		internal static Settings GetInstance(); // 0x0000000184A344E0-0x0000000184A34530
		private static Settings GetOrCreateInstance(); // 0x0000000184A34420-0x0000000184A344E0
	}

	[AddComponentMenu("")]
	[Obsolete("No longer required, use Automatic initialization mode or call SRDebug.Init() manually.")]
	public class SRDebuggerInit : SRMonoBehaviourEx // TypeDefIndex: 60228
	{
		// Constructors
		public SRDebuggerInit(); // 0x0000000185393520-0x0000000185393538
	}

	[AttributeUsage(AttributeTargets.Property)]
	public class NumberRangeAttribute : Attribute // TypeDefIndex: 60229
	{
		// Fields
		public readonly double Max; // 0x10
		public readonly double Min; // 0x18
	
		// Constructors
		public NumberRangeAttribute(double min, double max); // 0x0000000184D85BB0-0x0000000184D85BC0
	}

	[AttributeUsage(AttributeTargets.Property)]
	public class IncrementAttribute : Attribute // TypeDefIndex: 60230
	{
		// Fields
		public readonly double Increment; // 0x10
	
		// Constructors
		public IncrementAttribute(double increment); // 0x0000000184D85BA0-0x0000000184D85BB0
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public class SortAttribute : Attribute // TypeDefIndex: 60231
	{
		// Fields
		public readonly int SortPriority; // 0x10
	
		// Constructors
		public SortAttribute(int priority); // 0x00000001814F51F0-0x00000001814F5220
	}

	public static class VersionInfo // TypeDefIndex: 60232
	{
		// Fields
		public const string Version = "1.12.1"; // Metadata: 0x0234D31E
	}
}

namespace SRDebugger.Internal
{
	public static class SRDebugApi // TypeDefIndex: 60341
	{
		// Fields
		public const string Protocol = "https://"; // Metadata: 0x0234D3D9
		public const string EndPoint = "https://srdebugger.stompyrobot.uk"; // Metadata: 0x0234D3E2
		public const string BugReportEndPoint = "https://srdebugger.stompyrobot.uk/report/submit"; // Metadata: 0x0234D404
	}

	public static class SRDebugApiUtil // TypeDefIndex: 60342
	{
		// Methods
		public static string ParseErrorException(WebException ex); // 0x000000018AC9F6BC-0x000000018AC9F798
		public static string ParseErrorResponse(string response, string fallback = "Unexpected Response" /* Metadata: 0x0234D434 */); // 0x000000018AC9F798-0x000000018AC9FC30
		public static bool ReadResponse(HttpWebRequest request, out string result); // 0x000000018AC9FDB8-0x000000018AC9FE78
		public static string ReadResponseStream(WebResponse stream); // 0x000000018AC9FC30-0x000000018AC9FDB8
	}

	internal class BugReportApi : MonoBehaviour // TypeDefIndex: 60344
	{
		// Fields
		private string _apiKey; // 0x18
		private BugReport _bugReport; // 0x20
		private bool _isBusy; // 0x28
		private UnityWebRequest _webRequest; // 0x30
		private Action<BugReportSubmitResult> _onComplete; // 0x38
		private IProgress<float> _progress; // 0x40
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Submit_d__9 : IEnumerator<object> // TypeDefIndex: 60343
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public BugReportApi __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Submit_d__9(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018ACA3294-0x000000018ACA37EC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018ACA37EC-0x000000018ACA3838
		}
	
		// Constructors
		public BugReportApi(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public static void Submit(BugReport report, string apiKey, Action<BugReportSubmitResult> onComplete, IProgress<float> progress); // 0x000000018AC99D98-0x000000018AC99ED8
		private void Init(BugReport report, string apiKey, Action<BugReportSubmitResult> onComplete, IProgress<float> progress); // 0x000000018AC99C64-0x000000018AC99CAC
		private void Update(); // 0x000000018AC99F34-0x000000018AC99FA4
		[IteratorStateMachine(typeof(_Submit_d__9))]
		private IEnumerator Submit(); // 0x000000018AC99ED8-0x000000018AC99F34
		private void SetCompletionState(BugReportSubmitResult result); // 0x000000018AC99CAC-0x000000018AC99D98
		private static string BuildJsonRequest(BugReport report); // 0x000000018AC997FC-0x000000018AC99978
		private static List<List<string>> CreateConsoleDump(); // 0x000000018AC99978-0x000000018AC99C64
	}

	public class BugReportScreenshotUtil // TypeDefIndex: 60346
	{
		// Fields
		public static byte[] ScreenshotData; // 0x00
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ScreenshotCaptureCo_d__1 : IEnumerator<object> // TypeDefIndex: 60345
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _ScreenshotCaptureCo_d__1(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018ACA306C-0x000000018ACA3248
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018ACA3248-0x000000018ACA3294
		}
	
		// Constructors
		public BugReportScreenshotUtil(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[IteratorStateMachine(typeof(_ScreenshotCaptureCo_d__1))]
		public static IEnumerator ScreenshotCaptureCo(); // 0x000000018AC99FA4-0x000000018AC99FE8
	}

	internal class InternalBugReporterHandler : IBugReporterHandler // TypeDefIndex: 60347
	{
		// Properties
		public bool IsUsable { get; } // 0x000000018AC9B554-0x000000018AC9B594 
	
		// Constructors
		public InternalBugReporterHandler(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Submit(BugReport report, Action<BugReportSubmitResult> onComplete, IProgress<float> progress); // 0x000000018AC9B500-0x000000018AC9B554
	}

	[Service(typeof(InternalOptionsRegistry))]
	public sealed class InternalOptionsRegistry // TypeDefIndex: 60348
	{
		// Fields
		private List<object> _registeredContainers; // 0x10
		private Action<object> _handler; // 0x18
	
		// Constructors
		public InternalOptionsRegistry(); // 0x0000000184D2F4A0-0x0000000184D2F520
	
		// Methods
		public void AddOptionContainer(object obj); // 0x0000000183A45A50-0x0000000183A45AB0
		public void SetHandler(Action<object> action); // 0x00000001839E8710-0x00000001839E8870
	}

	public static class OptionControlFactory // TypeDefIndex: 60351
	{
		// Fields
		private static IList<DataBoundControl> _dataControlPrefabs; // 0x00
		private static ActionControl _actionControlPrefab; // 0x08
		private static readonly Dictionary<OptionType, DataBoundControl> TypeCache; // 0x10
	
		// Nested types
		private struct OptionType // TypeDefIndex: 60349
		{
			// Fields
			public readonly System.Type Type; // 0x00
			public readonly bool IsReadyOnly; // 0x08
	
			// Constructors
			public OptionType(System.Type type, bool isReadyOnly); // 0x00000001886D0120-0x00000001886D013C
	
			// Methods
			public bool Equals(OptionType other); // 0x000000018AC9CF80-0x000000018AC9CFB8
			public override bool Equals(object obj); // 0x000000018AC9CF10-0x000000018AC9CF80
			public override int GetHashCode(); // 0x000000018AC9CFB8-0x000000018AC9D054
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 60350
		{
			// Fields
			public OptionDefinition from; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _TryGetDataControlPrefab_b__0(DataBoundControl p); // 0x000000018ACA3BF4-0x000000018ACA3C38
		}
	
		// Constructors
		static OptionControlFactory(); // 0x000000018AC9CE7C-0x000000018AC9CF10
	
		// Methods
		public static bool CanCreateControl(OptionDefinition from); // 0x000000018AC9C55C-0x000000018AC9C604
		public static OptionsControlBase CreateControl(OptionDefinition from, string categoryPrefix = null); // 0x000000018AC9C704-0x000000018AC9C7F0
		private static void PopulateDataControlPrefabs(); // 0x000000018AC9CAD4-0x000000018AC9CCA0
		private static ActionControl CreateActionControl(OptionDefinition from, string categoryPrefix = null); // 0x000000018AC9C604-0x000000018AC9C704
		private static DataBoundControl CreateDataControl(OptionDefinition from, string categoryPrefix = null); // 0x000000018AC9C7F0-0x000000018AC9CAD4
		private static DataBoundControl TryGetDataControlPrefab(OptionDefinition from); // 0x000000018AC9CCA0-0x000000018AC9CE7C
	}

	public static class SRDebugPaths // TypeDefIndex: 60352
	{
		// Fields
		public const string DataControlsResourcesPath = "SRDebugger/UI/Prefabs/Options"; // Metadata: 0x0234D448
		public const string TriggerPrefabPath = "SRDebugger/UI/Prefabs/Trigger"; // Metadata: 0x0234D466
		public const string DebugPanelPrefabPath = "SRDebugger/UI/Prefabs/DebugPanel"; // Metadata: 0x0234D484
		public const string PinnedUIPrefabPath = "SRDebugger/UI/Prefabs/PinnedUI"; // Metadata: 0x0234D4A5
		public const string DockConsolePrefabPath = "SRDebugger/UI/Prefabs/DockConsole"; // Metadata: 0x0234D4C4
		public const string PinEntryPrefabPath = "SRDebugger/UI/Prefabs/PinEntry"; // Metadata: 0x0234D4E6
		public const string BugReportPopoverPath = "SRDebugger/UI/Prefabs/BugReportPopover"; // Metadata: 0x0234D505
		public const string BugReportSheetPath = "SRDebugger/UI/Prefabs/BugReportSheet"; // Metadata: 0x0234D52C
	}

	public static class Service // TypeDefIndex: 60353
	{
		// Fields
		private static IConsoleService _consoleService; // 0x00
		private static IDebugPanelService _debugPanelService; // 0x08
		private static IDebugTriggerService _debugTriggerService; // 0x10
		private static IPinnedUIService _pinnedUiService; // 0x18
		private static IDebugCameraService _debugCameraService; // 0x20
		private static IOptionsService _optionsService; // 0x28
		private static IDockConsoleService _dockConsoleService; // 0x30
	
		// Properties
		public static IConsoleService Console { get; } // 0x000000018ACA19AC-0x000000018ACA1A4C 
		public static IDockConsoleService DockConsole { get; } // 0x000000018ACA1AF4-0x000000018ACA1B9C 
		public static IDebugPanelService Panel { get; } // 0x000000018ACA1C44-0x000000018ACA1CEC 
		public static IDebugTriggerService Trigger { get; } // 0x000000018ACA1D94-0x000000018ACA1E3C 
		public static IPinnedUIService PinnedUI { get; } // 0x000000018ACA1CEC-0x000000018ACA1D94 
		public static IDebugCameraService DebugCamera { get; } // 0x000000018ACA1A4C-0x000000018ACA1AF4 
		public static IOptionsService Options { get; } // 0x000000018ACA1B9C-0x000000018ACA1C44 
	}

	public class SRDebugStrings // TypeDefIndex: 60354
	{
		// Fields
		public static readonly SRDebugStrings Current; // 0x00
		public readonly string Console_MessageTruncated; // 0x10
		public readonly string Console_NoStackTrace; // 0x18
		public readonly string PinEntryPrompt; // 0x20
		public readonly string Profiler_DisableProfilerInfo; // 0x28
		public readonly string Profiler_EnableProfilerInfo; // 0x30
		public readonly string Profiler_NoProInfo; // 0x38
		public readonly string Profiler_NotSupported; // 0x40
		public readonly string ProfilerCameraListenerHelp; // 0x48
	
		// Constructors
		public SRDebugStrings(); // 0x000000018ACA14E4-0x000000018ACA1604
		static SRDebugStrings(); // 0x000000018ACA1474-0x000000018ACA14E4
	}

	public static class SRDebuggerUtil // TypeDefIndex: 60355
	{
		// Properties
		public static bool IsMobilePlatform { get; } // 0x000000018ACA1980-0x000000018ACA19AC 
	
		// Methods
		public static bool EnsureEventSystemExists(); // 0x000000018ACA1824-0x000000018ACA195C
		public static void CreateDefaultEventSystem(); // 0x000000018ACA1724-0x000000018ACA1824
		private static void AddInputSystem(GameObject go); // 0x000000018ACA1604-0x000000018ACA1664
		private static void AddLegacyInputSystem(GameObject go); // 0x000000018ACA1664-0x000000018ACA16A8
		public static List<OptionDefinition> ScanForOptions(object obj); // 0x000000018445F630-0x000000018445FA00
		public static string GetNumberString(int value, int max, string exceedsMaxString); // 0x000000018ACA195C-0x000000018ACA1980
		public static void ConfigureCanvas(Canvas canvas); // 0x000000018ACA16A8-0x000000018ACA1724
	}
}

namespace SRDebugger.Profiler
{
	public class ProfilerLateUpdateListener : MonoBehaviour // TypeDefIndex: 60337
	{
		// Fields
		public Action OnLateUpdate; // 0x18
	
		// Constructors
		public ProfilerLateUpdateListener(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void LateUpdate(); // 0x0000000183EFA060-0x0000000183EFA080
	}

	public class ProfilerServiceImpl : SRServiceBase<IProfilerService>, IProfilerService // TypeDefIndex: 60338
	{
		// Fields
		[CompilerGenerated]
		private float _AverageFrameTime_k__BackingField; // 0x48
		[CompilerGenerated]
		private float _LastFrameTime_k__BackingField; // 0x4C
		private const int FrameBufferSize = 400; // Metadata: 0x0234D3D5
		private readonly CircularBuffer<ProfilerFrame> _frameBuffer; // 0x50
		private ProfilerLateUpdateListener _lateUpdateListener; // 0x58
		private readonly Stopwatch _stopwatch; // 0x60
		private double _updateDuration; // 0x68
		private double _renderStartTime; // 0x70
		private double _renderDuration; // 0x78
		private int _camerasThisFrame; // 0x80
	
		// Properties
		public float AverageFrameTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public float LastFrameTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public CircularBuffer<ProfilerFrame> FrameBuffer { get; } // 0x0000000184D86270-0x0000000184D86280 
	
		// Constructors
		public ProfilerServiceImpl(); // 0x000000018AC9F520-0x000000018AC9F5E0
	
		// Methods
		protected override void Awake(); // 0x000000018AC9EDE0-0x000000018AC9F0E4
		protected override void Update(); // 0x000000018AC9F39C-0x000000018AC9F520
		protected void PushFrame(double totalTime, double updateTime, double renderTime); // 0x000000018AC9F300-0x000000018AC9F39C
		private void OnLateUpdate(); // 0x000000018AC9F290-0x000000018AC9F300
		private void OnCameraPreRender(Camera cam); // 0x000000018AC9F210-0x000000018AC9F290
		private void OnCameraPostRender(Camera cam); // 0x000000018AC9F19C-0x000000018AC9F210
		private void EndFrame(); // 0x000000018AC9F0E4-0x000000018AC9F19C
	}

	public class SRPProfilerService : SRServiceBase<IProfilerService>, IProfilerService // TypeDefIndex: 60340
	{
		// Fields
		[CompilerGenerated]
		private float _AverageFrameTime_k__BackingField; // 0x48
		[CompilerGenerated]
		private float _LastFrameTime_k__BackingField; // 0x4C
		private const int FrameBufferSize = 400; // Metadata: 0x0234D3D7
		private readonly CircularBuffer<ProfilerFrame> _frameBuffer; // 0x50
		private ProfilerLateUpdateListener _lateUpdateListener; // 0x58
		private double _updateDuration; // 0x60
		private double _renderStartTime; // 0x68
		private double _renderDuration; // 0x70
		private readonly Stopwatch _stopwatch; // 0x78
	
		// Properties
		public float AverageFrameTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public float LastFrameTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		public CircularBuffer<ProfilerFrame> FrameBuffer { get; } // 0x0000000184D86270-0x0000000184D86280 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _EndOfFrameCoroutine_d__19 : IEnumerator<object> // TypeDefIndex: 60339
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SRPProfilerService __4__this; // 0x20
			private WaitForEndOfFrame _endOfFrame_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _EndOfFrameCoroutine_d__19(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001833F62F0-0x00000001833F63D0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018ACA3020-0x000000018ACA306C
		}
	
		// Constructors
		public SRPProfilerService(); // 0x0000000184CC7890-0x0000000184CC7960
	
		// Methods
		protected override void Awake(); // 0x0000000183A47560-0x0000000183A47750
		protected override void Update(); // 0x00000001833F5BC0-0x00000001833F6120
		[IteratorStateMachine(typeof(_EndOfFrameCoroutine_d__19))]
		private IEnumerator EndOfFrameCoroutine(); // 0x0000000183A47750-0x0000000183A477B0
		protected void PushFrame(double totalTime, double updateTime, double renderTime); // 0x00000001833F63D0-0x00000001833F6440
		private void OnLateUpdate(); // 0x00000001833F6290-0x00000001833F62F0
		private void RenderPipelineOnBeginFrameRendering(ScriptableRenderContext context, List<Camera> cameras); // 0x00000001833F58E0-0x00000001833F5940
		private void EndFrame(); // 0x00000001833F6160-0x00000001833F6290
	}
}

namespace SRDebugger.Scripts
{
	public class DebuggerTabController : SRMonoBehaviourEx // TypeDefIndex: 60233
	{
		// Fields
		private SRTab _aboutTabInstance; // 0x48
		private DefaultTabs? _activeTab; // 0x50
		private bool _hasStarted; // 0x58
		public SRTab AboutTab; // 0x60
		[RequiredField]
		public SRTabController TabController; // 0x68
	
		// Properties
		public DefaultTabs? ActiveTab { get; } // 0x000000018AC8DBDC-0x000000018AC8DD00 
	
		// Constructors
		public DebuggerTabController(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC8D820-0x000000018AC8DBDC
		public bool OpenTab(DefaultTabs tab); // 0x000000018AC8D5BC-0x000000018AC8D7B0
		public void ShowAboutTab(); // 0x000000018AC8D7B0-0x000000018AC8D820
	}
}

namespace SRDebugger.Services
{
	public sealed class ConsoleFilterStateService // TypeDefIndex: 60295
	{
		// Fields
		[CompilerGenerated]
		private ConsoleStateChangedEventHandler FilterStateChange; // 0x10
		private bool[] _states; // 0x18
	
		// Events
		public event ConsoleStateChangedEventHandler FilterStateChange {
			add; // 0x000000018AC8AF00-0x000000018AC8AF94
			remove; // 0x000000018AC8B028-0x000000018AC8B0BC
		}
	
		// Constructors
		public ConsoleFilterStateService(); // 0x000000018AC8AD30-0x000000018AC8AE18
	
		// Methods
		public void SetState(UnityEngine.LogType type, bool newState); // 0x000000018AC8ACC0-0x000000018AC8AD30
		public bool GetState(UnityEngine.LogType type); // 0x000000018AC8AC44-0x000000018AC8AC80
		private static UnityEngine.LogType GetType(UnityEngine.LogType type); // 0x000000018AC8AC80-0x000000018AC8ACC0
	}

	public delegate void BugReportCompleteCallback(bool didSucceed, string errorMessage); // TypeDefIndex: 60296; 0x00000001838E1420-0x00000001838E1430

	public delegate void BugReportProgressCallback(float progress); // TypeDefIndex: 60297; 0x0000000182B46B90-0x0000000182B46BA0

	public interface IBugReportService // TypeDefIndex: 60298
	{
		// Properties
		bool IsUsable { get; }
	
		// Methods
		void SetHandler(IBugReporterHandler handler);
		void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, IProgress<float> progressCallback = null);
	}

	public delegate void ConsoleStateChangedEventHandler(UnityEngine.LogType logType, bool newState); // TypeDefIndex: 60299; 0x00000001838E1420-0x00000001838E1430

	public interface IConsoleFilterState // TypeDefIndex: 60300
	{
		// Events
		event ConsoleStateChangedEventHandler FilterStateChange {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		void SetConsoleFilterState(UnityEngine.LogType logType, bool enabled);
		bool GetConsoleFilterState(UnityEngine.LogType logType);
	}

	public delegate void ConsoleUpdatedEventHandler(IConsoleService console); // TypeDefIndex: 60301; 0x0000000182B46B90-0x0000000182B46BA0

	public interface IConsoleService // TypeDefIndex: 60302
	{
		// Properties
		int CriticalCount { get; }
		int ErrorCount { get; }
		int WarningCount { get; }
		int InfoCount { get; }
		IReadOnlyList<ConsoleEntry> Entries { get; }
		IReadOnlyList<ConsoleEntry> AllEntries { get; }
		bool LoggingEnabled { get; set; }
		bool LogHandlerIsOverriden { get; }
	
		// Events
		event ConsoleUpdatedEventHandler Updated {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		event ConsoleUpdatedEventHandler Error {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		void Clear();
	}

	public class ConsoleEntry // TypeDefIndex: 60303
	{
		// Fields
		private const int MessagePreviewLength = 180; // Metadata: 0x0234D3A4
		private const int StackTracePreviewLength = 120; // Metadata: 0x0234D3A6
		private string _messagePreview; // 0x10
		private string _stackTracePreview; // 0x18
		public int Count; // 0x20
		public UnityEngine.LogType LogType; // 0x24
		public string Message; // 0x28
		public string StackTrace; // 0x30
	
		// Properties
		public string MessagePreview { get; } // 0x000000018AC8AACC-0x000000018AC8AB88 
		public string StackTracePreview { get; } // 0x000000018AC8AB88-0x000000018AC8AC44 
	
		// Constructors
		public ConsoleEntry(); // 0x0000000184D8ECB0-0x0000000184D8ECC0
		public ConsoleEntry(ConsoleEntry other); // 0x000000018AC8AA78-0x000000018AC8AACC
	
		// Methods
		public bool Matches(ConsoleEntry other); // 0x000000018AC8AA18-0x000000018AC8AA78
	}

	public interface IDebugCameraService // TypeDefIndex: 60304
	{
		// Properties
		Camera Camera { get; }
	}

	public interface IDebugPanelService // TypeDefIndex: 60305
	{
		// Properties
		bool IsLoaded { get; }
		bool IsVisible { get; set; }
		DefaultTabs? ActiveTab { get; }
	
		// Events
		event Action<IDebugPanelService, bool> VisibilityChanged {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		void Unload();
		void OpenTab(DefaultTabs tab);
	}

	public interface IDebugService // TypeDefIndex: 60306
	{
		// Properties
		SRDebugger.Settings Settings { get; }
		bool IsDebugPanelVisible { get; }
		bool IsTriggerEnabled { get; set; }
		bool IsTriggerErrorNotificationEnabled { get; set; }
		IDockConsoleService DockConsole { get; }
		IConsoleFilterState ConsoleFilter { get; }
		bool IsProfilerDocked { get; set; }
	
		// Events
		event VisibilityChangedDelegate PanelVisibilityChanged {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		event PinnedUiCanvasCreated PinnedUiCanvasCreated {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		void AddSystemInfo(SRDebugger.InfoEntry entry, string category = "Default" /* Metadata: 0x0234D3A8 */);
		void ShowDebugPanel(bool requireEntryCode = true /* Metadata: 0x0234D3B0 */);
		void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = true /* Metadata: 0x0234D3B1 */);
		void HideDebugPanel();
		void SetEntryCode(EntryCode newCode);
		void DisableEntryCode();
		void DestroyDebugPanel();
		void AddOptionContainer(object container);
		void RemoveOptionContainer(object container);
		void AddOption(OptionDefinition option);
		bool RemoveOption(OptionDefinition option);
		void PinAllOptions(string category);
		void UnpinAllOptions(string category);
		void PinOption(string name);
		void UnpinOption(string name);
		void ClearPinnedOptions();
		void ShowBugReportSheet(ActionCompleteCallback onComplete = null, bool takeScreenshot = true /* Metadata: 0x0234D3B2 */, string descriptionContent = null);
		RectTransform EnableWorldSpaceMode();
		void SetBugReporterHandler(IBugReporterHandler bugReporterHandler);
	}

	public interface IDebugTriggerService // TypeDefIndex: 60307
	{
		// Properties
		bool IsEnabled { get; set; }
		bool ShowErrorNotification { get; set; }
		PinAlignment Position { get; set; }
	}

	public interface IDockConsoleService // TypeDefIndex: 60308
	{
		// Properties
		bool IsVisible { get; set; }
		bool IsExpanded { get; set; }
		ConsoleAlignment Alignment { get; set; }
	}

	public interface IOptionsService // TypeDefIndex: 60309
	{
		// Properties
		ICollection<OptionDefinition> Options { get; }
	
		// Events
		event System.EventHandler OptionsUpdated {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		[Obsolete("Use IOptionsService.AddContainer instead.")]
		void Scan(object obj);
		void AddContainer(object obj);
		void AddContainer(IOptionContainer optionContainer);
		void RemoveContainer(object obj);
		void RemoveContainer(IOptionContainer optionContainer);
	}

	public delegate void PinEntryCompleteCallback(bool validPinEntered); // TypeDefIndex: 60310; 0x0000000182B46B90-0x0000000182B46BA0

	public interface IPinEntryService // TypeDefIndex: 60311
	{
		// Properties
		bool IsShowingKeypad { get; }
	
		// Methods
		void ShowPinEntry(IReadOnlyList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true /* Metadata: 0x0234D3B3 */);
	}

	public interface IPinnedUIService // TypeDefIndex: 60312
	{
		// Properties
		bool IsProfilerPinned { get; set; }
	
		// Events
		event Action<OptionDefinition, bool> OptionPinStateChanged {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		event Action<RectTransform> OptionsCanvasCreated {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		void Pin(OptionDefinition option, int order = -1 /* Metadata: 0x0234D3B4 */);
		void Unpin(OptionDefinition option);
		void UnpinAll();
		bool HasPinned(OptionDefinition option);
	}

	public static class ProfilerServiceSelector // TypeDefIndex: 60313
	{
		// Methods
		[ServiceSelector(typeof(IProfilerService))]
		public static System.Type GetProfilerServiceType(); // 0x00000001841E43F0-0x00000001841E44D0
	}

	public struct ProfilerFrame // TypeDefIndex: 60314
	{
		// Fields
		public double FrameTime; // 0x00
		public double OtherTime; // 0x08
		public double RenderTime; // 0x10
		public double UpdateTime; // 0x18
	}

	public interface IProfilerService // TypeDefIndex: 60315
	{
		// Properties
		float AverageFrameTime { get; }
		float LastFrameTime { get; }
		CircularBuffer<ProfilerFrame> FrameBuffer { get; }
	}

	public interface ISystemInformationService // TypeDefIndex: 60316
	{
		// Methods
		IEnumerable<string> GetCategories();
		IList<SRDebugger.InfoEntry> GetInfo(string category);
		void Add(SRDebugger.InfoEntry info, string category = "Default" /* Metadata: 0x0234D3B5 */);
		Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false /* Metadata: 0x0234D3BD */);
	}
}

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IBugReportService))]
	internal class BugReportApiService : IBugReportService // TypeDefIndex: 60318
	{
		// Fields
		private IBugReporterHandler _handler; // 0x10
	
		// Properties
		public bool IsUsable { get; } // 0x000000018AC88D18-0x000000018AC88D30 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 60317
		{
			// Fields
			public BugReportCompleteCallback completeHandler; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _SendBugReport_b__0(BugReportSubmitResult result); // 0x000000018AC993C4-0x000000018AC993F4
		}
	
		// Constructors
		public BugReportApiService(); // 0x000000018AC88CC8-0x000000018AC88D18
	
		// Methods
		public void SetHandler(IBugReporterHandler handler); // 0x000000018AC88C0C-0x000000018AC88CC8
		public void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, IProgress<float> progress = null); // 0x000000018AC88944-0x000000018AC88C0C
	}

	[Service(typeof(BugReportPopoverService))]
	public class BugReportPopoverService : SRServiceBase<BugReportPopoverService> // TypeDefIndex: 60320
	{
		// Fields
		private BugReportCompleteCallback _callback; // 0x48
		private bool _isVisible; // 0x50
		private BugReportPopoverRoot _popover; // 0x58
		private BugReportSheetController _sheet; // 0x60
	
		// Properties
		public bool IsShowingPopover { get; } // 0x0000000184D86800-0x0000000184D86810 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _OpenCo_d__7 : IEnumerator<object> // TypeDefIndex: 60319
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public bool takeScreenshot; // 0x20
			public BugReportPopoverService __4__this; // 0x28
			public string descriptionText; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _OpenCo_d__7(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AC98AFC-0x000000018AC98C24
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AC98C24-0x000000018AC98C70
		}
	
		// Constructors
		public BugReportPopoverService(); // 0x000000018AC89784-0x000000018AC897C4
	
		// Methods
		public void ShowBugReporter(BugReportCompleteCallback callback, bool takeScreenshotFirst = true /* Metadata: 0x0234D3BE */, string descriptionText = null); // 0x000000018AC89550-0x000000018AC896E8
		[IteratorStateMachine(typeof(_OpenCo_d__7))]
		private IEnumerator OpenCo(bool takeScreenshot, string descriptionText); // 0x000000018AC89448-0x000000018AC894CC
		private void SubmitComplete(bool didSucceed, string errorMessage); // 0x000000018AC896E8-0x000000018AC89704
		private void CancelPressed(); // 0x000000018AC88F0C-0x000000018AC88F54
		private void OnComplete(bool success, string errorMessage, bool close); // 0x000000018AC892E4-0x000000018AC89448
		private void TakingScreenshot(); // 0x000000018AC89704-0x000000018AC89784
		private void ScreenshotComplete(); // 0x000000018AC894CC-0x000000018AC89550
		protected override void Awake(); // 0x000000018AC88E78-0x000000018AC88F0C
		private void Load(); // 0x000000018AC88F54-0x000000018AC892E4
	}

	[Service(typeof(IDebugCameraService))]
	public class DebugCameraServiceImpl : IDebugCameraService // TypeDefIndex: 60321
	{
		// Fields
		private Camera _debugCamera; // 0x10
	
		// Properties
		public Camera Camera { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public DebugCameraServiceImpl(); // 0x000000018AC99FE8-0x000000018AC9A164
	}

	[Service(typeof(IDebugPanelService))]
	public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService, IDisposable // TypeDefIndex: 60322
	{
		// Fields
		private DebugPanelRoot _debugPanelRootObject; // 0x18
		[CompilerGenerated]
		private Action<IDebugPanelService, bool> VisibilityChanged; // 0x20
		private bool _isVisible; // 0x28
		private bool? _cursorWasVisible; // 0x29
		private CursorLockMode? _cursorLockMode; // 0x2C
	
		// Properties
		public DebugPanelRoot RootObject { get; } // 0x000000018385B100-0x000000018385B110 
		public bool IsLoaded { get; } // 0x000000018AC9A500-0x000000018AC9A534 
		public bool IsVisible { get; set; } // 0x000000018AC9A534-0x000000018AC9A554 0x000000018AC9A5E0-0x000000018AC9A8F0
		public DefaultTabs? ActiveTab { get; } // 0x000000018AC9A488-0x000000018AC9A500 
	
		// Events
		public event Action<IDebugPanelService, bool> VisibilityChanged {
			add; // 0x0000000183A458C0-0x0000000183A45950
			remove; // 0x000000018AC9A554-0x000000018AC9A5E0
		}
	
		// Constructors
		public DebugPanelServiceImpl(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public void OpenTab(DefaultTabs tab); // 0x000000018AC9A370-0x000000018AC9A3C4
		public void Unload(); // 0x000000018AC9A3C4-0x000000018AC9A488
		private void Load(); // 0x000000018AC9A1E8-0x000000018AC9A370
		public void Dispose(); // 0x000000018AC9A164-0x000000018AC9A1E8
	}

	[Service(typeof(IDebugTriggerService))]
	public class DebugTriggerImpl : SRServiceBase<IDebugTriggerService>, IDebugTriggerService // TypeDefIndex: 60323
	{
		// Fields
		private PinAlignment _position; // 0x48
		private TriggerRoot _trigger; // 0x50
		private IConsoleService _consoleService; // 0x58
		private bool _showErrorNotification; // 0x60
	
		// Properties
		public bool IsEnabled { get; set; } // 0x000000018AC9B000-0x000000018AC9B07C 0x0000000183A455C0-0x0000000183A45670
		public bool ShowErrorNotification { get; set; } // 0x0000000184D88340-0x0000000184D88350 0x0000000183A48D40-0x0000000183A48E10
		public PinAlignment Position { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x0000000183A45710-0x0000000183A457B0
	
		// Constructors
		public DebugTriggerImpl(); // 0x0000000184D75AC0-0x0000000184D75B00
	
		// Methods
		protected override void Awake(); // 0x0000000183A473A0-0x0000000183A474C0
		private void OnError(IConsoleService console); // 0x000000018AC9AE1C-0x000000018AC9AE90
		private void CreateTrigger(); // 0x000000018AC9A8F0-0x000000018AC9AD04
		protected override void OnDestroy(); // 0x000000018AC9AD0C-0x000000018AC9AE1C
		private static void OnActiveSceneChanged(Scene s1, Scene s2); // 0x000000018AC9AD04-0x000000018AC9AD0C
		private void OnTriggerButtonClick(); // 0x000000018AC9AE90-0x000000018AC9AF20
		private static void SetTriggerPosition(RectTransform t, PinAlignment position); // 0x000000018AC9AF20-0x000000018AC9B000
	}

	[Service(typeof(IDockConsoleService))]
	public class DockConsoleServiceImpl : IDockConsoleService // TypeDefIndex: 60324
	{
		// Fields
		private ConsoleAlignment _alignment; // 0x10
		private DockConsoleController _consoleRoot; // 0x18
		private bool _didSuspendTrigger; // 0x20
		private bool _isExpanded; // 0x21
		private bool _isVisible; // 0x22
	
		// Properties
		public bool IsVisible { get; set; } // 0x0000000184D86AD0-0x0000000184D86AE0 0x000000018AC9B454-0x000000018AC9B500
		public bool IsExpanded { get; set; } // 0x0000000184D86850-0x0000000184D86860 0x000000018AC9B3B4-0x000000018AC9B454
		public ConsoleAlignment Alignment { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x000000018AC9B32C-0x000000018AC9B3B4
	
		// Constructors
		public DockConsoleServiceImpl(); // 0x000000018AC9B2FC-0x000000018AC9B32C
	
		// Methods
		private void Load(); // 0x000000018AC9B194-0x000000018AC9B2FC
		private void CheckTrigger(); // 0x000000018AC9B07C-0x000000018AC9B194
	}

	[Service(typeof(KeyboardShortcutListenerService))]
	public class KeyboardShortcutListenerService : SRServiceBase<KeyboardShortcutListenerService> // TypeDefIndex: 60325
	{
		// Fields
		private List<SRDebugger.Settings.KeyboardShortcut> _shortcuts; // 0x48
	
		// Constructors
		public KeyboardShortcutListenerService(); // 0x000000018AC9C238-0x000000018AC9C278
	
		// Methods
		protected override void Awake(); // 0x000000018AC9B594-0x000000018AC9B9F4
		private void ToggleTab(DefaultTabs t); // 0x000000018AC9BCB8-0x000000018AC9BDBC
		private void ExecuteShortcut(SRDebugger.Settings.KeyboardShortcut shortcut); // 0x000000018AC9B9F4-0x000000018AC9BCB8
		protected override void Update(); // 0x000000018AC9C1F0-0x000000018AC9C238
		private void UpdateInputSystem(); // 0x000000018AC9BDBC-0x000000018AC9C048
		private void UpdateLegacyInputSystem(); // 0x000000018AC9C048-0x000000018AC9C1F0
	}

	[Service(typeof(IOptionsService))]
	public sealed class OptionsServiceImpl : IOptionsService // TypeDefIndex: 60328
	{
		// Fields
		[CompilerGenerated]
		private System.EventHandler OptionsUpdated; // 0x10
		private readonly Dictionary<IOptionContainer, List<OptionDefinition>> _optionContainerLookup; // 0x18
		private readonly Dictionary<IOptionContainer, OptionContainerEventHandler> _optionContainerEventHandlerLookup; // 0x20
		private readonly List<OptionDefinition> _options; // 0x28
		private readonly IList<OptionDefinition> _optionsReadonly; // 0x30
	
		// Properties
		public ICollection<OptionDefinition> Options { get; } // 0x00000001811F36E0-0x00000001811F36F0 
	
		// Events
		public event System.EventHandler OptionsUpdated {
			add; // 0x000000018AC9D64C-0x000000018AC9D6E0
			remove; // 0x000000018AC9D6E0-0x000000018AC9D774
		}
	
		// Nested types
		private class OptionContainerEventHandler : IDisposable // TypeDefIndex: 60326
		{
			// Fields
			private readonly OptionsServiceImpl _service; // 0x10
			private readonly IOptionContainer _container; // 0x18
	
			// Constructors
			public OptionContainerEventHandler(OptionsServiceImpl service, IOptionContainer container); // 0x000000018AC9C40C-0x000000018AC9C55C
	
			// Methods
			private void ContainerOnOptionAdded(OptionDefinition obj); // 0x000000018AC9C278-0x000000018AC9C2A4
			private void ContainerOnOptionRemoved(OptionDefinition obj); // 0x000000018AC9C2A4-0x000000018AC9C2D0
			public void Dispose(); // 0x000000018AC9C2D0-0x000000018AC9C40C
		}
	
		private class ReflectionOptionContainer : IOptionContainer // TypeDefIndex: 60327
		{
			// Fields
			private List<OptionDefinition> _options; // 0x10
			private readonly object _target; // 0x18
	
			// Properties
			public bool IsDynamic { get; } // 0x00000001812081B0-0x0000000181208610 
			private List<OptionDefinition> Options { get; } // 0x000000018445F5F0-0x000000018445F630 
	
			// Events
			public event Action<OptionDefinition> OptionAdded {
				add; // 0x00000001841E1670-0x00000001841E1680
				remove; // 0x00000001841E1670-0x00000001841E1680
			}
			public event Action<OptionDefinition> OptionRemoved {
				add; // 0x00000001841E1670-0x00000001841E1680
				remove; // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Constructors
			public ReflectionOptionContainer(object target); // 0x0000000185392C40-0x0000000185392C50
	
			// Methods
			public IEnumerable<OptionDefinition> GetOptions(); // 0x00000001853976CC-0x00000001853976D4
			protected bool Equals(ReflectionOptionContainer other); // 0x000000018AC9F694-0x000000018AC9F6BC
			public override bool Equals(object obj); // 0x000000018AC9F5E0-0x000000018AC9F694
			public override int GetHashCode(); // 0x0000000184D80F90-0x0000000184D80FC0
		}
	
		// Constructors
		public OptionsServiceImpl(); // 0x000000018445F310-0x000000018445F480
	
		// Methods
		private void OptionsContainerOnOptionAdded(IOptionContainer container, OptionDefinition optionDefinition); // 0x000000018AC9D0C0-0x000000018AC9D204
		private void OptionsContainerOnOptionRemoved(IOptionContainer container, OptionDefinition optionDefinition); // 0x000000018AC9D204-0x000000018AC9D31C
		public void Scan(object obj); // 0x000000018AC9D644-0x000000018AC9D64C
		public void AddContainer(object obj); // 0x000000018445F280-0x000000018445F310
		public void AddContainer(IOptionContainer optionContainer); // 0x000000018445F480-0x000000018445F5F0
		public void RemoveContainer(object obj); // 0x000000018AC9D31C-0x000000018AC9D3B8
		public void RemoveContainer(IOptionContainer optionContainer); // 0x000000018AC9D3B8-0x000000018AC9D644
		private void OnOptionsUpdated(); // 0x000000018AC9D054-0x000000018AC9D0C0
	}

	[Service(typeof(IPinEntryService))]
	public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService // TypeDefIndex: 60329
	{
		// Fields
		private PinEntryCompleteCallback _callback; // 0x48
		private bool _isVisible; // 0x50
		private PinEntryControl _pinControl; // 0x58
		private readonly List<int> _requiredPin; // 0x60
	
		// Properties
		public bool IsShowingKeypad { get; } // 0x0000000184D86800-0x0000000184D86810 
	
		// Constructors
		public PinEntryServiceImpl(); // 0x000000018AC9DDD4-0x000000018AC9DE6C
	
		// Methods
		public void ShowPinEntry(IReadOnlyList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true /* Metadata: 0x0234D3BF */); // 0x000000018AC9DA58-0x000000018AC9DC78
		protected override void Awake(); // 0x000000018AC9D774-0x000000018AC9D808
		private void Load(); // 0x000000018AC9D808-0x000000018AC9D994
		private void PinControlOnComplete(IList<int> result, bool didCancel); // 0x000000018AC9D994-0x000000018AC9DA58
		private void VerifyPin(IReadOnlyList<int> pin); // 0x000000018AC9DC78-0x000000018AC9DDD4
	}

	[Service(typeof(IPinnedUIService))]
	public class PinnedUIServiceImpl : SRServiceBase<IPinnedUIService>, IPinnedUIService // TypeDefIndex: 60330
	{
		// Fields
		private readonly List<OptionsControlBase> _controlList; // 0x48
		private readonly Dictionary<OptionDefinition, OptionsControlBase> _pinnedObjects; // 0x50
		private bool _queueRefresh; // 0x58
		private PinnedUIRoot _uiRoot; // 0x60
		[CompilerGenerated]
		private Action<OptionDefinition, bool> OptionPinStateChanged; // 0x68
		[CompilerGenerated]
		private Action<RectTransform> OptionsCanvasCreated; // 0x70
	
		// Properties
		public DockConsoleController DockConsoleController { get; } // 0x000000018AC9EB4C-0x000000018AC9EBC0 
		public bool IsProfilerPinned { get; set; } // 0x000000018AC9EBC0-0x000000018AC9EC38 0x000000018AC9ED50-0x000000018AC9EDE0
	
		// Events
		public event Action<OptionDefinition, bool> OptionPinStateChanged {
			add; // 0x000000018AC9EAC0-0x000000018AC9EB4C
			remove; // 0x000000018AC9EC38-0x000000018AC9ECC4
		}
		public event Action<RectTransform> OptionsCanvasCreated {
			add; // 0x0000000183A45950-0x0000000183A459E0
			remove; // 0x000000018AC9ECC4-0x000000018AC9ED50
		}
	
		// Constructors
		public PinnedUIServiceImpl(); // 0x0000000184CACC60-0x0000000184CACD40
	
		// Methods
		public void Pin(OptionDefinition obj, int order = -1 /* Metadata: 0x0234D3C0 */); // 0x000000018AC9E2FC-0x000000018AC9E48C
		public void Unpin(OptionDefinition obj); // 0x000000018AC9E6C4-0x000000018AC9E7E8
		private void OnPinnedStateChanged(OptionDefinition option, bool isPinned); // 0x000000018AC9E2E8-0x000000018AC9E2FC
		public void UnpinAll(); // 0x000000018AC9E50C-0x000000018AC9E6C4
		public bool HasPinned(OptionDefinition option); // 0x000000018AC9DE6C-0x000000018AC9DEC0
		protected override void Awake(); // 0x0000000183A474C0-0x0000000183A47560
		private void Load(); // 0x000000018AC9DEC0-0x000000018AC9E134
		private void UpdateAnchors(); // 0x000000018AC9E7E8-0x000000018AC9EAC0
		protected override void Update(); // 0x00000001840B9FF0-0x00000001840BA010
		private void OnOptionsUpdated(object sender, EventArgs eventArgs); // 0x000000018AC9E140-0x000000018AC9E2E8
		private void OnDebugPanelVisibilityChanged(bool isVisible); // 0x000000018AC9E134-0x000000018AC9E140
		private void Refresh(); // 0x000000018AC9E48C-0x000000018AC9E50C
	}

	[Service(typeof(IDebugService))]
	public class SRDebugService : IDebugService // TypeDefIndex: 60332
	{
		// Fields
		[CompilerGenerated]
		private VisibilityChangedDelegate PanelVisibilityChanged; // 0x10
		[CompilerGenerated]
		private PinnedUiCanvasCreated PinnedUiCanvasCreated; // 0x18
		private readonly IDebugPanelService _debugPanelService; // 0x20
		private readonly IDebugTriggerService _debugTrigger; // 0x28
		private readonly ISystemInformationService _informationService; // 0x30
		private readonly IOptionsService _optionsService; // 0x38
		private readonly IPinnedUIService _pinnedUiService; // 0x40
		private IConsoleFilterState _consoleFilterState; // 0x48
		private EntryCode? _entryCode; // 0x50
		private bool _hasAuthorised; // 0x64
		private DefaultTabs? _queuedTab; // 0x68
		private RectTransform _worldSpaceTransform; // 0x70
		private DynamicOptionContainer _looseOptionContainer; // 0x78
	
		// Properties
		public IDockConsoleService DockConsole { get; } // 0x000000018ACA11AC-0x000000018ACA11B4 
		public IConsoleFilterState ConsoleFilter { get; } // 0x000000018ACA1144-0x000000018ACA11AC 
		public SRDebugger.Settings Settings { get; } // 0x0000000185394964-0x000000018539496C 
		public bool IsDebugPanelVisible { get; } // 0x000000018ACA11B4-0x000000018ACA11D0 
		public bool IsTriggerEnabled { get; set; } // 0x000000018ACA1220-0x000000018ACA123C 0x000000018ACA1408-0x000000018ACA1424
		public bool IsTriggerErrorNotificationEnabled { get; set; } // 0x000000018ACA123C-0x000000018ACA1280 0x000000018ACA1424-0x000000018ACA1474
		public bool IsProfilerDocked { get; set; } // 0x000000018ACA11D0-0x000000018ACA1220 0x000000018ACA13A8-0x000000018ACA1408
	
		// Events
		public event VisibilityChangedDelegate PanelVisibilityChanged {
			add; // 0x000000018ACA101C-0x000000018ACA10B0
			remove; // 0x000000018ACA1280-0x000000018ACA1314
		}
		public event PinnedUiCanvasCreated PinnedUiCanvasCreated {
			add; // 0x000000018ACA10B0-0x000000018ACA1144
			remove; // 0x000000018ACA1314-0x000000018ACA13A8
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0 // TypeDefIndex: 60331
		{
			// Fields
			public ActionCompleteCallback onComplete; // 0x10
	
			// Constructors
			public __c__DisplayClass51_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _ShowBugReportSheet_b__0(bool succeed, string message); // 0x000000018ACA3BDC-0x000000018ACA3BF4
		}
	
		// Constructors
		public SRDebugService(); // 0x0000000183A460E0-0x0000000183A46560
	
		// Methods
		public void AddSystemInfo(SRDebugger.InfoEntry entry, string category = "Default" /* Metadata: 0x0234D3C1 */); // 0x000000018AC9FF94-0x000000018AC9FFDC
		public void ShowDebugPanel(bool requireEntryCode = true /* Metadata: 0x0234D3C9 */); // 0x000000018ACA0B6C-0x000000018ACA0BD8
		public void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = true /* Metadata: 0x0234D3CA */); // 0x000000018ACA0A94-0x000000018ACA0B6C
		public void HideDebugPanel(); // 0x000000018ACA0380-0x000000018ACA03A0
		public void SetEntryCode(EntryCode newCode); // 0x000000018ACA0914-0x000000018ACA0978
		public void DisableEntryCode(); // 0x0000000184DA9E20-0x0000000184DA9E30
		public void DestroyDebugPanel(); // 0x000000018ACA00F4-0x000000018ACA0154
		public void AddOptionContainer(object container); // 0x000000018AC9FE78-0x000000018AC9FEC8
		public void RemoveOptionContainer(object container); // 0x000000018ACA0814-0x000000018ACA0864
		public void AddOption(OptionDefinition option); // 0x000000018AC9FEC8-0x000000018AC9FF94
		public bool RemoveOption(OptionDefinition option); // 0x000000018ACA0864-0x000000018ACA087C
		public void PinAllOptions(string category); // 0x000000018ACA03A0-0x000000018ACA0514
		public void UnpinAllOptions(string category); // 0x000000018ACA0D34-0x000000018ACA0EA8
		public void PinOption(string name); // 0x000000018ACA0514-0x000000018ACA0688
		public void UnpinOption(string name); // 0x000000018ACA0EA8-0x000000018ACA101C
		public void ClearPinnedOptions(); // 0x000000018AC9FFDC-0x000000018ACA0024
		public void ShowBugReportSheet(ActionCompleteCallback onComplete = null, bool takeScreenshot = true /* Metadata: 0x0234D3CB */, string descriptionContent = null); // 0x000000018ACA0978-0x000000018ACA0A94
		private void DebugPanelServiceOnVisibilityChanged(IDebugPanelService debugPanelService, bool b); // 0x000000018ACA0024-0x000000018ACA00F4
		private void PromptEntryCode(); // 0x000000018ACA0688-0x000000018ACA0814
		public RectTransform EnableWorldSpaceMode(); // 0x000000018ACA0154-0x000000018ACA0380
		public void SetBugReporterHandler(IBugReporterHandler bugReporterHandler); // 0x000000018ACA087C-0x000000018ACA0914
		[CompilerGenerated]
		private void _.ctor_b__21_0(RectTransform transform); // 0x000000018ACA0C80-0x000000018ACA0D34
		[CompilerGenerated]
		private void _PromptEntryCode_b__53_0(bool entered); // 0x000000018ACA0BD8-0x000000018ACA0C80
	}

	[Service(typeof(IConsoleService))]
	public class StandardConsoleService : IConsoleService, IDisposable // TypeDefIndex: 60333
	{
		// Fields
		private readonly bool _collapseEnabled; // 0x10
		private bool _hasCleared; // 0x11
		private readonly CircularBuffer<ConsoleEntry> _allConsoleEntries; // 0x18
		private CircularBuffer<ConsoleEntry> _consoleEntries; // 0x20
		private readonly object _threadLock; // 0x28
		private ILogHandler _expectedLogHandler; // 0x30
		[CompilerGenerated]
		private int _CriticalCount_k__BackingField; // 0x38
		[CompilerGenerated]
		private int _ErrorCount_k__BackingField; // 0x3C
		[CompilerGenerated]
		private int _WarningCount_k__BackingField; // 0x40
		[CompilerGenerated]
		private int _InfoCount_k__BackingField; // 0x44
		[CompilerGenerated]
		private ConsoleUpdatedEventHandler Updated; // 0x48
		[CompilerGenerated]
		private ConsoleUpdatedEventHandler Error; // 0x50
	
		// Properties
		public int CriticalCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		public int ErrorCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86640-0x0000000184D86650 0x0000000184D86670-0x0000000184D86680
		public int WarningCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
		public int InfoCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86530-0x0000000184D86540 0x0000000184D86580-0x0000000184D86590
		public bool LoggingEnabled { get; set; } // 0x000000018ACA2570-0x000000018ACA25C4 0x000000018ACA26EC-0x000000018ACA2764
		public bool LogHandlerIsOverriden { get; } // 0x000000018ACA2518-0x000000018ACA2570 
		public IReadOnlyList<ConsoleEntry> Entries { get; } // 0x000000018ACA2508-0x000000018ACA2518 
		public IReadOnlyList<ConsoleEntry> AllEntries { get; } // 0x000000018385B100-0x000000018385B110 
	
		// Events
		public event ConsoleUpdatedEventHandler Updated {
			add; // 0x000000018ACA2474-0x000000018ACA2508
			remove; // 0x000000018ACA2658-0x000000018ACA26EC
		}
		public event ConsoleUpdatedEventHandler Error {
			add; // 0x000000018ACA23E0-0x000000018ACA2474
			remove; // 0x000000018ACA25C4-0x000000018ACA2658
		}
	
		// Constructors
		public StandardConsoleService(); // 0x0000000183E3E3D0-0x0000000183E3E580
	
		// Methods
		public void Dispose(); // 0x000000018ACA2074-0x000000018ACA2128
		public void Clear(); // 0x000000018ACA1EB4-0x000000018ACA2074
		protected void OnEntryAdded(ConsoleEntry entry); // 0x000000018ACA2128-0x000000018ACA2298
		protected void OnEntryDuplicated(ConsoleEntry entry); // 0x000000018ACA2298-0x000000018ACA234C
		private void OnUpdated(); // 0x000000018ACA234C-0x000000018ACA23E0
		private void UnityLogCallback(string condition, string stackTrace, UnityEngine.LogType type); // 0x00000001841E1670-0x00000001841E1680
		private void AdjustCounter(UnityEngine.LogType type, int amount); // 0x000000018ACA1E3C-0x000000018ACA1EB4
	}

	[Service(typeof(ISystemInformationService))]
	public class StandardSystemInformationService : ISystemInformationService // TypeDefIndex: 60336
	{
		// Fields
		private readonly Dictionary<string, IList<SRDebugger.InfoEntry>> _info; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 60334
		{
			// Fields
			public SRDebugger.InfoEntry info; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Add_b__0(SRDebugger.InfoEntry p); // 0x0000000186B8D048-0x0000000186B8D078
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 60335
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<object> __9__6_0; // 0x08
			public static Func<object> __9__6_1; // 0x10
			public static Func<object> __9__6_2; // 0x18
			public static Func<object> __9__6_3; // 0x20
			public static Func<object> __9__6_4; // 0x28
			public static Func<object> __9__6_5; // 0x30
			public static Func<object> __9__6_6; // 0x38
			public static Func<object> __9__6_7; // 0x40
			public static Func<object> __9__6_8; // 0x48
	
			// Constructors
			static __c(); // 0x0000000184D46030-0x0000000184D46090
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _CreateDefaultSet_b__6_0(); // 0x000000018ACA3838-0x000000018ACA38A8
			internal object _CreateDefaultSet_b__6_1(); // 0x000000018ACA38A8-0x000000018ACA38EC
			internal object _CreateDefaultSet_b__6_2(); // 0x000000018ACA38EC-0x000000018ACA3930
			internal object _CreateDefaultSet_b__6_3(); // 0x000000018ACA3930-0x000000018ACA3974
			internal object _CreateDefaultSet_b__6_4(); // 0x000000018ACA3974-0x000000018ACA39B8
			internal object _CreateDefaultSet_b__6_5(); // 0x000000018ACA39B8-0x000000018ACA39FC
			internal object _CreateDefaultSet_b__6_6(); // 0x000000018ACA39FC-0x000000018ACA3A40
			internal object _CreateDefaultSet_b__6_7(); // 0x000000018ACA3A40-0x000000018ACA3B44
			internal object _CreateDefaultSet_b__6_8(); // 0x000000018ACA3B44-0x000000018ACA3BDC
		}
	
		// Constructors
		public StandardSystemInformationService(); // 0x0000000184D22760-0x0000000184D227E0
	
		// Methods
		public IEnumerable<string> GetCategories(); // 0x000000018ACA2D78-0x000000018ACA2DC0
		public IList<SRDebugger.InfoEntry> GetInfo(string category); // 0x000000018ACA2F14-0x000000018ACA3020
		public void Add(SRDebugger.InfoEntry info, string category = "Default" /* Metadata: 0x0234D3CC */); // 0x000000018ACA2764-0x000000018ACA2970
		public Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false /* Metadata: 0x0234D3D4 */); // 0x000000018ACA2970-0x000000018ACA2D78
		private void CreateDefaultSet(); // 0x00000001841A81D0-0x00000001841AAC60
		private static string GetCloudManifestPrettyName(string name); // 0x000000018ACA2DC0-0x000000018ACA2F14
	}
}

namespace SRDebugger.UI
{
	public class ProfilerFPSLabel : SRMonoBehaviourEx // TypeDefIndex: 60234
	{
		// Fields
		private float _nextUpdate; // 0x48
		[Import]
		private IProfilerService _profilerService; // 0x50
		public float UpdateFrequency; // 0x58
		[RequiredField]
		[SerializeField]
		private UnityEngine.UI.Text _text; // 0x60
	
		// Constructors
		public ProfilerFPSLabel(); // 0x000000018AC9532C-0x000000018AC95348
	
		// Methods
		protected override void Update(); // 0x000000018AC95300-0x000000018AC9532C
		private void Refresh(); // 0x000000018AC951F4-0x000000018AC95300
	}

	public class DebugPanelRoot : SRMonoBehaviourEx // TypeDefIndex: 60235
	{
		// Fields
		[RequiredField]
		public Canvas Canvas; // 0x48
		[RequiredField]
		public CanvasGroup CanvasGroup; // 0x50
		[RequiredField]
		public DebuggerTabController TabController; // 0x58
	
		// Constructors
		public DebugPanelRoot(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void Close(); // 0x000000018AC8D528-0x000000018AC8D5BC
		public void CloseAndDestroy(); // 0x000000018AC8D4CC-0x000000018AC8D528
	}

	public class MobileMenuController : SRMonoBehaviourEx // TypeDefIndex: 60236
	{
		// Fields
		private UnityEngine.UI.Button _closeButton; // 0x48
		[SerializeField]
		private float _maxMenuWidth; // 0x50
		[SerializeField]
		private float _peekAmount; // 0x54
		private float _targetXPosition; // 0x58
		[RequiredField]
		public RectTransform Content; // 0x60
		[RequiredField]
		public RectTransform Menu; // 0x68
		[RequiredField]
		public UnityEngine.UI.Button OpenButton; // 0x70
		[RequiredField]
		public SRTabController TabController; // 0x78
	
		// Properties
		public float PeekAmount { get; } // 0x0000000184D86E00-0x0000000184D86E10 
		public float MaxMenuWidth { get; } // 0x0000000184D885A0-0x0000000184D885B0 
	
		// Constructors
		public MobileMenuController(); // 0x000000018AC91070-0x000000018AC91094
	
		// Methods
		protected override void OnEnable(); // 0x000000018AC90BF8-0x000000018AC90E74
		protected override void OnDisable(); // 0x000000018AC90AC0-0x000000018AC90BF8
		private void CreateCloseButton(); // 0x000000018AC9070C-0x000000018AC90AC0
		private void SetRectSize(RectTransform rect); // 0x000000018AC90ECC-0x000000018AC90F80
		private void CloseButtonClicked(); // 0x000000018AC906CC-0x000000018AC906D4
		protected override void Update(); // 0x000000018AC90F80-0x000000018AC91070
		private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab); // 0x000000018AC906CC-0x000000018AC906D4
		[ContextMenu("Open")]
		public void Open(); // 0x000000018AC90E74-0x000000018AC90ECC
		[ContextMenu("Close")]
		public void Close(); // 0x000000018AC906D4-0x000000018AC9070C
	}
}

namespace SRDebugger.UI.Controls
{
	[RequireComponent(typeof(RectTransform))]
	public class ConsoleEntryView : SRMonoBehaviourEx, SRF.UI.Layout.IVirtualView // TypeDefIndex: 60270
	{
		// Fields
		public const string ConsoleBlobInfo = "Console_Info_Blob"; // Metadata: 0x0234D345
		public const string ConsoleBlobWarning = "Console_Warning_Blob"; // Metadata: 0x0234D357
		public const string ConsoleBlobError = "Console_Error_Blob"; // Metadata: 0x0234D36C
		public const string ConsoleBlobCritical = "Console_Critical_Blob"; // Metadata: 0x0234D37F
		private int _count; // 0x48
		private bool _hasCount; // 0x4C
		private ConsoleEntry _prevData; // 0x50
		private RectTransform _rectTransform; // 0x58
		[RequiredField]
		public UnityEngine.UI.Text Count; // 0x60
		[RequiredField]
		public CanvasGroup CountContainer; // 0x68
		[RequiredField]
		public StyleComponent ImageStyle; // 0x70
		[RequiredField]
		public UnityEngine.UI.Text Message; // 0x78
		[RequiredField]
		public UnityEngine.UI.Text StackTrace; // 0x80
	
		// Constructors
		public ConsoleEntryView(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void SetDataContext(object data); // 0x000000018AC8A6DC-0x000000018AC8AA18
		protected override void Awake(); // 0x000000018AC8A638-0x000000018AC8A6DC
	}

	public class ConsoleLogControl : SRMonoBehaviourEx // TypeDefIndex: 60272
	{
		// Fields
		[RequiredField]
		[SerializeField]
		private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup; // 0x48
		[RequiredField]
		[SerializeField]
		private ScrollRect _consoleScrollRect; // 0x50
		private bool _isDirty; // 0x58
		private Vector2? _scrollPosition; // 0x5C
		private bool _showCriticals; // 0x68
		private bool _showErrors; // 0x69
		private bool _showInfo; // 0x6A
		private bool _showWarnings; // 0x6B
		public Action<ConsoleEntry> SelectedItemChanged; // 0x70
		private string _filter; // 0x78
	
		// Properties
		public bool ShowCriticals { get; set; } // 0x0000000184D86B40-0x0000000184D86B50 0x0000000184DA9DA0-0x0000000184DA9DB0
		public bool ShowErrors { get; set; } // 0x0000000184D86B10-0x0000000184D86B20 0x0000000184DA9DB0-0x0000000184DA9DC0
		public bool ShowWarnings { get; set; } // 0x0000000184DA9D90-0x0000000184DA9DA0 0x0000000184DA9DD0-0x0000000184DA9DE0
		public bool ShowInfo { get; set; } // 0x0000000184DA9D80-0x0000000184DA9D90 0x0000000184DA9DC0-0x0000000184DA9DD0
		public bool EnableSelection { get; set; } // 0x000000018AC8B678-0x000000018AC8B698 0x000000018AC8B698-0x000000018AC8B6B8
		public string Filter { get; set; } // 0x0000000184D862A0-0x0000000184D862B0 0x000000018AC8B6B8-0x000000018AC8B6F4
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ScrollToBottom_d__30 : IEnumerator<object> // TypeDefIndex: 60271
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ConsoleLogControl __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _ScrollToBottom_d__30(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AC98C70-0x000000018AC98D88
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AC98D88-0x000000018AC98DD4
		}
	
		// Constructors
		public ConsoleLogControl(); // 0x000000018AC8B65C-0x000000018AC8B678
	
		// Methods
		protected override void Awake(); // 0x000000018AC8B150-0x000000018AC8B268
		protected override void Start(); // 0x000000018AC8B5A8-0x000000018AC8B5D0
		[IteratorStateMachine(typeof(_ScrollToBottom_d__30))]
		private IEnumerator ScrollToBottom(); // 0x000000018AC8B54C-0x000000018AC8B5A8
		protected override void OnDestroy(); // 0x000000018AC8B268-0x000000018AC8B308
		private void OnSelectedItemChanged(object arg0); // 0x000000018AC8B308-0x000000018AC8B364
		protected override void Update(); // 0x000000018AC8B5D0-0x000000018AC8B65C
		private void Refresh(); // 0x000000018AC8B364-0x000000018AC8B54C
		private void SetIsDirty(); // 0x0000000184DA7440-0x0000000184DA7450
		private void ConsoleOnUpdated(IConsoleService console); // 0x0000000184DA7440-0x0000000184DA7450
	}

	public abstract class DataBoundControl : OptionsControlBase // TypeDefIndex: 60273
	{
		// Fields
		private bool _hasStarted; // 0x60
		private bool _isReadOnly; // 0x61
		private object _prevValue; // 0x68
		private PropertyReference _prop; // 0x70
		[CompilerGenerated]
		private string _PropertyName_k__BackingField; // 0x78
	
		// Properties
		public PropertyReference Property { get; } // 0x0000000184D862B0-0x0000000184D862C0 
		public bool IsReadOnly { get; } // 0x0000000184D892D0-0x0000000184D892E0 
		public string PropertyName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000186402320-0x0000000186402330
	
		// Constructors
		protected DataBoundControl(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void Bind(string propertyName, PropertyReference prop); // 0x000000018AC8CFFC-0x000000018AC8D0F4
		private void OnValueChanged(PropertyReference property); // 0x0000000189843110-0x0000000189843120
		protected void UpdateValue(object newValue); // 0x000000018AC8D35C-0x000000018AC8D3A8
		public override void Refresh(); // 0x000000018AC8D238-0x000000018AC8D33C
		protected virtual void OnBind(string propertyName, System.Type t); // 0x00000001841E1670-0x00000001841E1680
		protected abstract void OnValueUpdated(object newValue);
		public abstract bool CanBind(System.Type type, bool isReadOnly);
		protected override void Start(); // 0x000000018AC8D33C-0x000000018AC8D35C
		protected override void OnEnable(); // 0x000000018AC8D188-0x000000018AC8D238
		protected override void OnDisable(); // 0x000000018AC8D0F4-0x000000018AC8D188
	}

	public abstract class OptionsControlBase : SRMonoBehaviourEx // TypeDefIndex: 60274
	{
		// Fields
		private bool _selectionModeEnabled; // 0x48
		[RequiredField]
		public Toggle SelectionModeToggle; // 0x50
		public OptionDefinition Option; // 0x58
	
		// Properties
		public bool SelectionModeEnabled { get; set; } // 0x0000000184D867D0-0x0000000184D867E0 0x000000018AC92384-0x000000018AC92480
		public bool IsSelected { get; set; } // 0x000000018AC9228C-0x000000018AC922AC 0x000000018AC922AC-0x000000018AC92384
	
		// Constructors
		protected OptionsControlBase(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Awake(); // 0x000000018AC9217C-0x000000018AC921CC
		protected override void OnEnable(); // 0x000000018AC921CC-0x000000018AC9228C
		public virtual void Refresh(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class InfoBlock : SRMonoBehaviourEx // TypeDefIndex: 60275
	{
		// Fields
		[RequiredField]
		public UnityEngine.UI.Text Content; // 0x48
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0x50
	
		// Constructors
		public InfoBlock(); // 0x0000000185393520-0x0000000185393538
	}

	public class MultiTapButton : UnityEngine.UI.Button // TypeDefIndex: 60276
	{
		// Fields
		private float _lastTap; // 0x190
		private int _tapCount; // 0x194
		public int RequiredTapCount; // 0x198
		public float ResetTime; // 0x19C
	
		// Constructors
		public MultiTapButton(); // 0x000000018AC91108-0x000000018AC91124
	
		// Methods
		public override void OnPointerClick(PointerEventData eventData); // 0x000000018AC91094-0x000000018AC91108
	}

	public delegate void PinEntryControlCallback(IList<int> result, bool didCancel); // TypeDefIndex: 60277; 0x00000001838E1420-0x00000001838E1430

	public class PinEntryControl : SRMonoBehaviourEx // TypeDefIndex: 60279
	{
		// Fields
		private bool _isVisible; // 0x48
		private List<int> _numbers; // 0x50
		[RequiredField]
		public Image Background; // 0x58
		public bool CanCancel; // 0x60
		[RequiredField]
		public UnityEngine.UI.Button CancelButton; // 0x68
		[RequiredField]
		public UnityEngine.UI.Text CancelButtonText; // 0x70
		[RequiredField]
		public CanvasGroup CanvasGroup; // 0x78
		[RequiredField]
		public Animator DotAnimator; // 0x80
		public UnityEngine.UI.Button[] NumberButtons; // 0x88
		public Toggle[] NumberDots; // 0x90
		[RequiredField]
		public UnityEngine.UI.Text PromptText; // 0x98
		[CompilerGenerated]
		private PinEntryControlCallback Complete; // 0xA0
	
		// Events
		public event PinEntryControlCallback Complete {
			add; // 0x000000018AC94E40-0x000000018AC94ED8
			remove; // 0x000000018AC94ED8-0x000000018AC94F70
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 60278
		{
			// Fields
			public int number; // 0x10
			public PinEntryControl __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Awake_b__0(); // 0x000000018AC99344-0x000000018AC9936C
		}
	
		// Constructors
		public PinEntryControl(); // 0x000000018AC94DB4-0x000000018AC94E40
	
		// Methods
		protected override void Awake(); // 0x000000018AC9452C-0x000000018AC946CC
		protected override void OnEnable(); // 0x000000018AC949F0-0x000000018AC94A84
		protected override void OnDisable(); // 0x000000018AC9495C-0x000000018AC949F0
		protected override void Update(); // 0x000000018AC94CDC-0x000000018AC94DB4
		private void HandleCharacter(char i); // 0x000000018AC94788-0x000000018AC94808
		public void Show(); // 0x000000018AC94C7C-0x000000018AC94CDC
		public void Hide(); // 0x000000018AC94808-0x000000018AC94864
		public void Clear(); // 0x000000018AC9473C-0x000000018AC94788
		public void PlayInvalidCodeAnimation(); // 0x000000018AC94A84-0x000000018AC94AD0
		protected void OnComplete(); // 0x000000018AC948C0-0x000000018AC9495C
		protected void OnCancel(); // 0x000000018AC94864-0x000000018AC948C0
		private void CancelButtonPressed(); // 0x000000018AC946CC-0x000000018AC9473C
		public void PushNumber(int number); // 0x000000018AC94AD0-0x000000018AC94B90
		private void RefreshState(); // 0x000000018AC94B90-0x000000018AC94C7C
	}

	public class ProfilerMemoryBlock : SRMonoBehaviourEx // TypeDefIndex: 60281
	{
		// Fields
		private float _lastRefresh; // 0x48
		[RequiredField]
		public UnityEngine.UI.Text CurrentUsedText; // 0x50
		[RequiredField]
		public Slider Slider; // 0x58
		[RequiredField]
		public UnityEngine.UI.Text TotalAllocatedText; // 0x60
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CleanUp_d__8 : IEnumerator<object> // TypeDefIndex: 60280
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ProfilerMemoryBlock __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _CleanUp_d__8(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AC98830-0x000000018AC988D8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AC988D8-0x000000018AC98924
		}
	
		// Constructors
		public ProfilerMemoryBlock(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnEnable(); // 0x000000018AC968AC-0x000000018AC968B4
		protected override void Update(); // 0x000000018AC96A9C-0x000000018AC96B1C
		public void TriggerRefresh(); // 0x000000018AC968D8-0x000000018AC96A9C
		public void TriggerCleanup(); // 0x000000018AC968B4-0x000000018AC968D8
		[IteratorStateMachine(typeof(_CleanUp_d__8))]
		private IEnumerator CleanUp(); // 0x000000018AC96850-0x000000018AC968AC
	}

	public class ProfilerMonoBlock : SRMonoBehaviourEx // TypeDefIndex: 60282
	{
		// Fields
		private float _lastRefresh; // 0x48
		[RequiredField]
		public UnityEngine.UI.Text CurrentUsedText; // 0x50
		[RequiredField]
		public GameObject NotSupportedMessage; // 0x58
		[RequiredField]
		public Slider Slider; // 0x60
		[RequiredField]
		public UnityEngine.UI.Text TotalAllocatedText; // 0x68
		private bool _isSupported; // 0x70
	
		// Constructors
		public ProfilerMonoBlock(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnEnable(); // 0x000000018AC96B1C-0x000000018AC96B84
		protected override void Update(); // 0x000000018AC96DC8-0x000000018AC96E48
		public void TriggerRefresh(); // 0x000000018AC96BD4-0x000000018AC96DC8
		public void TriggerCollection(); // 0x000000018AC96B84-0x000000018AC96BD4
	}

	public class ProfilerEnableControl : SRMonoBehaviourEx // TypeDefIndex: 60283
	{
		// Fields
		private bool _previousState; // 0x48
		[RequiredField]
		public UnityEngine.UI.Text ButtonText; // 0x50
		[RequiredField]
		public UnityEngine.UI.Button EnableButton; // 0x58
		[RequiredField]
		public UnityEngine.UI.Text Text; // 0x60
	
		// Constructors
		public ProfilerEnableControl(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC94F70-0x000000018AC9506C
		protected void UpdateLabels(); // 0x000000018AC950C8-0x000000018AC951C8
		protected override void Update(); // 0x000000018AC951C8-0x000000018AC951F4
		public void ToggleProfiler(); // 0x000000018AC9506C-0x000000018AC950C8
	}

	[RequireComponent(typeof(RectTransform))]
	public class ProfilerGraphAxisLabel : SRMonoBehaviourEx // TypeDefIndex: 60284
	{
		// Fields
		private float _prevFrameTime; // 0x48
		private float? _queuedFrameTime; // 0x4C
		private float _yPosition; // 0x54
		[RequiredField]
		public UnityEngine.UI.Text Text; // 0x58
	
		// Constructors
		public ProfilerGraphAxisLabel(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Update(); // 0x000000018AC9557C-0x000000018AC955E0
		public void SetValue(float frameTime, float yPosition); // 0x000000018AC95500-0x000000018AC9557C
		private void SetValueInternal(float frameTime); // 0x000000018AC95348-0x000000018AC95500
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(CanvasRenderer))]
	public class ProfilerGraphControl : Graphic // TypeDefIndex: 60286
	{
		// Fields
		public VerticalAlignments VerticalAlignment; // 0xB0
		private static readonly float[] ScaleSteps; // 0x00
		public bool FloatingScale; // 0xB4
		public bool TargetFpsUseApplication; // 0xB5
		public bool DrawAxes; // 0xB6
		public int TargetFps; // 0xB8
		public bool Clip; // 0xBC
		public const float DataPointMargin = 2f; // Metadata: 0x0234D395
		public const float DataPointVerticalMargin = 2f; // Metadata: 0x0234D399
		public const float DataPointWidth = 4f; // Metadata: 0x0234D39D
		public int VerticalPadding; // 0xC0
		public const int LineCount = 3; // Metadata: 0x0234D3A1
		public UnityEngine.Color[] LineColours; // 0xC8
		private IProfilerService _profilerService; // 0xD0
		private ProfilerGraphAxisLabel[] _axisLabels; // 0xD8
		private Rect _clipBounds; // 0xE0
		private readonly List<Vector3> _meshVertices; // 0xF0
		private readonly List<Color32> _meshVertexColors; // 0xF8
		private readonly List<int> _meshTriangles; // 0x100
	
		// Nested types
		public enum VerticalAlignments // TypeDefIndex: 60285
		{
			Top = 0,
			Bottom = 1
		}
	
		// Constructors
		public ProfilerGraphControl(); // 0x000000018AC966B8-0x000000018AC96850
		static ProfilerGraphControl(); // 0x000000018AC9662C-0x000000018AC966B8
	
		// Methods
		protected override void Awake(); // 0x000000018AC95918-0x000000018AC9597C
		protected override void Start(); // 0x00000001841E1670-0x00000001841E1680
		protected void Update(); // 0x000000018AC9661C-0x000000018AC9662C
		[Obsolete]
		protected override void OnPopulateMesh(Mesh m); // 0x000000018AC96130-0x000000018AC9661C
		protected void DrawDataPoint(float xPosition, float verticalScale, ProfilerFrame frame); // 0x000000018AC95C48-0x000000018AC95F30
		protected void DrawAxis(float frameTime, float yPosition, ProfilerGraphAxisLabel label); // 0x000000018AC95A40-0x000000018AC95C48
		protected void AddRect(Vector3 tl, Vector3 tr, Vector3 bl, Vector3 br, UnityEngine.Color c); // 0x000000018AC955E0-0x000000018AC95918
		protected ProfilerFrame GetFrame(int i); // 0x000000018AC960A4-0x000000018AC96130
		protected int CalculateVisibleDataPointCount(); // 0x000000018AC95A04-0x000000018AC95A40
		protected int GetFrameBufferCurrentSize(); // 0x000000018AC96000-0x000000018AC9604C
		protected int GetFrameBufferMaxSize(); // 0x000000018AC9604C-0x000000018AC960A4
		protected float CalculateMaxFrameTime(); // 0x000000018AC9597C-0x000000018AC95A04
		private ProfilerGraphAxisLabel GetAxisLabel(int index); // 0x000000018AC95F30-0x000000018AC96000
	}

	public class SRTabButton : SRMonoBehaviourEx // TypeDefIndex: 60287
	{
		// Fields
		[RequiredField]
		public UnityEngine.Behaviour ActiveToggle; // 0x48
		[RequiredField]
		public UnityEngine.UI.Button Button; // 0x50
		[RequiredField]
		public RectTransform ExtraContentContainer; // 0x58
		[RequiredField]
		public StyleComponent IconStyleComponent; // 0x60
		[RequiredField]
		public UnityEngine.UI.Text TitleText; // 0x68
	
		// Properties
		public bool IsActive { get; set; } // 0x000000018AC971BC-0x000000018AC971DC 0x000000018AC971DC-0x000000018AC971FC
	
		// Constructors
		public SRTabButton(); // 0x0000000185393520-0x0000000185393538
	}
}

namespace SRDebugger.UI.Controls.Data
{
	public class ActionControl : OptionsControlBase // TypeDefIndex: 60288
	{
		// Fields
		private MethodReference _method; // 0x60
		[RequiredField]
		public UnityEngine.UI.Button Button; // 0x68
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0x70
	
		// Properties
		public MethodReference Method { get; } // 0x0000000184D86280-0x0000000184D86290 
	
		// Constructors
		public ActionControl(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC8868C-0x000000018AC88728
		private void ButtonOnClick(); // 0x000000018AC8853C-0x000000018AC88654
		public void SetMethod(string methodName, MethodReference method); // 0x000000018AC88654-0x000000018AC8868C
	}

	public class BoolControl : DataBoundControl // TypeDefIndex: 60289
	{
		// Fields
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0x80
		[RequiredField]
		public Toggle Toggle; // 0x88
	
		// Constructors
		public BoolControl(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC88834-0x000000018AC888EC
		private void ToggleOnValueChanged(bool isOn); // 0x000000018AC888EC-0x000000018AC88944
		protected override void OnBind(string propertyName, System.Type t); // 0x000000018AC8878C-0x000000018AC887D0
		protected override void OnValueUpdated(object newValue); // 0x000000018AC887D0-0x000000018AC88834
		public override bool CanBind(System.Type type, bool isReadOnly); // 0x000000018AC88728-0x000000018AC8878C
	}

	public class EnumControl : DataBoundControl // TypeDefIndex: 60290
	{
		// Fields
		private object _lastValue; // 0x80
		private string[] _names; // 0x88
		private Array _values; // 0x90
		[RequiredField]
		public LayoutElement ContentLayoutElement; // 0x98
		public GameObject[] DisableOnReadOnly; // 0xA0
		[RequiredField]
		public SRSpinner Spinner; // 0xA8
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0xB0
		[RequiredField]
		public UnityEngine.UI.Text Value; // 0xB8
	
		// Constructors
		public EnumControl(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC8D33C-0x000000018AC8D35C
		protected override void OnBind(string propertyName, System.Type t); // 0x000000018AC8F274-0x000000018AC8F4D0
		protected override void OnValueUpdated(object newValue); // 0x000000018AC8F4D0-0x000000018AC8F58C
		public override bool CanBind(System.Type type, bool isReadOnly); // 0x000000018AC8F18C-0x000000018AC8F1AC
		private void SetIndex(int i); // 0x000000018AC8F58C-0x000000018AC8F5D0
		public void GoToNext(); // 0x000000018AC8F1AC-0x000000018AC8F210
		public void GoToPrevious(); // 0x000000018AC8F210-0x000000018AC8F274
	}

	public class NumberControl : DataBoundControl // TypeDefIndex: 60292
	{
		// Fields
		private static readonly System.Type[] IntegerTypes; // 0x00
		private static readonly System.Type[] DecimalTypes; // 0x08
		public static readonly Dictionary<System.Type, ValueRange> ValueRanges; // 0x10
		private string _lastValue; // 0x80
		private System.Type _type; // 0x88
		public GameObject[] DisableOnReadOnly; // 0x90
		public SRNumberButton DownNumberButton; // 0x98
		[RequiredField]
		public SRNumberSpinner NumberSpinner; // 0xA0
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0xA8
		public SRNumberButton UpNumberButton; // 0xB0
	
		// Nested types
		public struct ValueRange // TypeDefIndex: 60291
		{
			// Fields
			public double MaxValue; // 0x00
			public double MinValue; // 0x08
		}
	
		// Constructors
		public NumberControl(); // 0x0000000185393520-0x0000000185393538
		static NumberControl(); // 0x000000018AC91BF8-0x000000018AC92078
	
		// Methods
		protected override void Start(); // 0x000000018AC91B40-0x000000018AC91BF8
		private void OnValueChanged(string newValue); // 0x000000018AC918C4-0x000000018AC91A38
		protected override void OnBind(string propertyName, System.Type t); // 0x000000018AC91550-0x000000018AC918C4
		protected override void OnValueUpdated(object newValue); // 0x000000018AC91A38-0x000000018AC91B40
		public override bool CanBind(System.Type type, bool isReadOnly); // 0x000000018AC91124-0x000000018AC91188
		protected static bool IsIntegerType(System.Type t); // 0x000000018AC9148C-0x000000018AC91550
		protected static bool IsDecimalType(System.Type t); // 0x000000018AC913C8-0x000000018AC9148C
		protected double GetMaxValue(System.Type t); // 0x000000018AC91188-0x000000018AC912A8
		protected double GetMinValue(System.Type t); // 0x000000018AC912A8-0x000000018AC913C8
	}

	public class ReadOnlyControl : DataBoundControl // TypeDefIndex: 60293
	{
		// Fields
		[RequiredField]
		public UnityEngine.UI.Text ValueText; // 0x80
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0x88
	
		// Constructors
		public ReadOnlyControl(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC8D33C-0x000000018AC8D35C
		protected override void OnBind(string propertyName, System.Type t); // 0x000000018AC9705C-0x000000018AC97080
		protected override void OnValueUpdated(object newValue); // 0x000000018AC97080-0x000000018AC970EC
		public override bool CanBind(System.Type type, bool isReadOnly); // 0x000000018AC96FDC-0x000000018AC9705C
	}

	public class StringControl : DataBoundControl // TypeDefIndex: 60294
	{
		// Fields
		[RequiredField]
		public InputField InputField; // 0x80
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0x88
	
		// Constructors
		public StringControl(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC98778-0x000000018AC98830
		private void OnValueChanged(string newValue); // 0x000000018AC986E8-0x000000018AC986F0
		protected override void OnBind(string propertyName, System.Type t); // 0x000000018AC9865C-0x000000018AC986E8
		protected override void OnValueUpdated(object newValue); // 0x000000018AC986F0-0x000000018AC98778
		public override bool CanBind(System.Type type, bool isReadOnly); // 0x000000018AC985E0-0x000000018AC9865C
	}
}

namespace SRDebugger.UI.Other
{
	public class BugReportPopoverRoot : SRMonoBehaviourEx // TypeDefIndex: 60247
	{
		// Fields
		[RequiredField]
		public CanvasGroup CanvasGroup; // 0x48
		[RequiredField]
		public RectTransform Container; // 0x50
	
		// Constructors
		public BugReportPopoverRoot(); // 0x0000000185393520-0x0000000185393538
	}

	public class BugReportSheetController : SRMonoBehaviourEx // TypeDefIndex: 60249
	{
		// Fields
		[RequiredField]
		public GameObject ButtonContainer; // 0x48
		[RequiredField]
		public UnityEngine.UI.Text ButtonText; // 0x50
		[RequiredField]
		public UnityEngine.UI.Button CancelButton; // 0x58
		public Action CancelPressed; // 0x60
		[RequiredField]
		public InputField DescriptionField; // 0x68
		[RequiredField]
		public InputField EmailField; // 0x70
		[RequiredField]
		public Slider ProgressBar; // 0x78
		[RequiredField]
		public UnityEngine.UI.Text ResultMessageText; // 0x80
		public Action ScreenshotComplete; // 0x88
		[RequiredField]
		public UnityEngine.UI.Button SubmitButton; // 0x90
		public Action<bool, string> SubmitComplete; // 0x98
		public Action TakingScreenshot; // 0xA0
	
		// Properties
		public bool IsCancelButtonEnabled { get; set; } // 0x000000018AC89DD8-0x000000018AC89E08 0x000000018AC89E08-0x000000018AC89E40
	
		// Nested types
		[CompilerGenerated]
		private sealed class _SubmitCo_d__18 : IEnumerator<object> // TypeDefIndex: 60248
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public BugReportSheetController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _SubmitCo_d__18(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AC98DD4-0x000000018AC991D4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AC991D4-0x000000018AC99220
		}
	
		// Constructors
		public BugReportSheetController(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC89C6C-0x000000018AC89C98
		public void Submit(); // 0x000000018AC89CF4-0x000000018AC89DD8
		public void Cancel(); // 0x000000018AC89840-0x000000018AC89854
		[IteratorStateMachine(typeof(_SubmitCo_d__18))]
		private IEnumerator SubmitCo(); // 0x000000018AC89C98-0x000000018AC89CF4
		private void OnBugReportProgress(float progress); // 0x000000018AC89A40-0x000000018AC89A64
		private void OnBugReportComplete(bool didSucceed, string errorMessage); // 0x000000018AC89984-0x000000018AC89A40
		protected void SetLoadingSpinnerVisible(bool visible); // 0x000000018AC89B14-0x000000018AC89B6C
		protected void ClearForm(); // 0x000000018AC898C4-0x000000018AC8993C
		protected void ShowErrorMessage(string userMessage, string serverMessage = null); // 0x000000018AC89B6C-0x000000018AC89C6C
		protected void ClearErrorMessage(); // 0x000000018AC89854-0x000000018AC898C4
		protected void SetFormEnabled(bool e); // 0x000000018AC89AA8-0x000000018AC89B14
		private string GetDefaultEmailFieldContents(); // 0x000000018AC8993C-0x000000018AC89984
		private void SetDefaultEmailFieldContents(string value); // 0x000000018AC89A64-0x000000018AC89AA8
	}

	public class CategoryGroup : SRMonoBehaviourEx // TypeDefIndex: 60250
	{
		// Fields
		[RequiredField]
		public RectTransform Container; // 0x48
		[RequiredField]
		public UnityEngine.UI.Text Header; // 0x50
		[RequiredField]
		public GameObject Background; // 0x58
		[RequiredField]
		public Toggle SelectionToggle; // 0x60
		public GameObject[] EnabledDuringSelectionMode; // 0x68
		private bool _selectionModeEnabled; // 0x70
	
		// Properties
		public bool IsSelected { get; set; } // 0x000000018AC8A190-0x000000018AC8A1B0 0x000000018AC8A1B0-0x000000018AC8A288
		public bool SelectionModeEnabled { get; set; } // 0x0000000184D86A50-0x0000000184D86A60 0x000000018AC8A288-0x000000018AC8A2E8
	
		// Constructors
		public CategoryGroup(); // 0x000000018AC8A13C-0x000000018AC8A190
	}

	[RequireComponent(typeof(Canvas))]
	public class ConfigureCanvasFromSettings : SRMonoBehaviour // TypeDefIndex: 60251
	{
		// Fields
		private Canvas _canvas; // 0x48
		private CanvasScaler _canvasScaler; // 0x50
		private float _originalScale; // 0x58
		private float _lastSetScale; // 0x5C
		private SRDebugger.Settings _settings; // 0x60
	
		// Constructors
		public ConfigureCanvasFromSettings(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Start(); // 0x000000018AC8A4A4-0x000000018AC8A638
		private void OnDestroy(); // 0x000000018AC8A378-0x000000018AC8A438
		private void SettingsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs); // 0x000000018AC8A438-0x000000018AC8A4A4
	}

	public class ConsoleTabQuickViewControl : SRMonoBehaviourEx // TypeDefIndex: 60252
	{
		// Fields
		private const int Max = 1000; // Metadata: 0x0234D336
		private static readonly string MaxString; // 0x00
		private int _prevCriticalCount; // 0x48
		private int _prevErrorCount; // 0x4C
		private int _prevInfoCount; // 0x50
		private int _prevWarningCount; // 0x54
		[Import]
		public IConsoleService ConsoleService; // 0x58
		[RequiredField]
		public UnityEngine.UI.Text CriticalCountText; // 0x60
		[RequiredField]
		public UnityEngine.UI.Text ErrorCountText; // 0x68
		[RequiredField]
		public UnityEngine.UI.Text InfoCountText; // 0x70
		[RequiredField]
		public UnityEngine.UI.Text WarningCountText; // 0x78
	
		// Constructors
		public ConsoleTabQuickViewControl(); // 0x000000018AC8CFD4-0x000000018AC8CFFC
		static ConsoleTabQuickViewControl(); // 0x000000018AC8CF58-0x000000018AC8CFD4
	
		// Methods
		protected override void Awake(); // 0x000000018AC8CC04-0x000000018AC8CCA4
		protected override void Update(); // 0x000000018AC8CCD4-0x000000018AC8CF58
		private static bool HasChanged(int newCount, ref int oldCount, int max); // 0x000000018AC8CCA4-0x000000018AC8CCD4
	}

	[RequireComponent(typeof(StyleComponent))]
	public class DebugPanelBackgroundBehaviour : SRMonoBehaviour // TypeDefIndex: 60253
	{
		// Fields
		private StyleComponent _styleComponent; // 0x48
		public string TransparentStyleKey; // 0x50
		[SerializeField]
		private StyleSheet _styleSheet; // 0x58
	
		// Constructors
		public DebugPanelBackgroundBehaviour(); // 0x000000018AC8D470-0x000000018AC8D4CC
	
		// Methods
		private void Awake(); // 0x000000018AC8D3A8-0x000000018AC8D470
	}

	public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 60254
	{
		// Fields
		public const float NonFocusOpacity = 0.65f; // Metadata: 0x0234D338
		private bool _isDirty; // 0x48
		private bool _isDragging; // 0x49
		private int _pointersOver; // 0x4C
		[Import]
		public IConsoleFilterState FilterState; // 0x50
		[RequiredField]
		public GameObject BottomHandle; // 0x58
		[RequiredField]
		public CanvasGroup CanvasGroup; // 0x60
		[RequiredField]
		public ConsoleLogControl Console; // 0x68
		[RequiredField]
		public GameObject Dropdown; // 0x70
		[RequiredField]
		public Image DropdownToggleSprite; // 0x78
		[RequiredField]
		public UnityEngine.UI.Text TextCriticals; // 0x80
		[RequiredField]
		public UnityEngine.UI.Text TextErrors; // 0x88
		[RequiredField]
		public UnityEngine.UI.Text TextInfo; // 0x90
		[RequiredField]
		public UnityEngine.UI.Text TextWarnings; // 0x98
		[RequiredField]
		public Toggle ToggleCriticals; // 0xA0
		[RequiredField]
		public Toggle ToggleErrors; // 0xA8
		[RequiredField]
		public Toggle ToggleInfo; // 0xB0
		[RequiredField]
		public Toggle ToggleWarnings; // 0xB8
		[RequiredField]
		public GameObject TopBar; // 0xC0
		[RequiredField]
		public GameObject TopHandle; // 0xC8
		[RequiredField]
		public GameObject TopSafeAreaSpacer; // 0xD0
		[RequiredField]
		public GameObject BottomSafeAreaSpacer; // 0xD8
	
		// Properties
		public bool IsVisible { get; set; } // 0x000000018AC8EA10-0x000000018AC8EA34 0x000000018AC8EA34-0x000000018AC8EA64
	
		// Constructors
		public DockConsoleController(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC8E4C0-0x000000018AC8E85C
		protected override void OnDestroy(); // 0x000000018AC8DD80-0x000000018AC8DE74
		protected override void OnEnable(); // 0x000000018AC8DE74-0x000000018AC8DE88
		protected override void OnDisable(); // 0x0000000184DA9DF0-0x0000000184DA9E00
		protected override void Update(); // 0x000000018AC8EA00-0x000000018AC8EA10
		private void OnFilterStateChange(UnityEngine.LogType logType, bool newState); // 0x000000018AC8DE9C-0x000000018AC8DEFC
		private void ConsoleOnUpdated(IConsoleService console); // 0x0000000184D99870-0x0000000184D99880
		public void SetDropdownVisibility(bool visible); // 0x000000018AC8E434-0x000000018AC8E4C0
		public void SetAlignmentMode(ConsoleAlignment alignment); // 0x000000018AC8E198-0x000000018AC8E434
		private void Refresh(); // 0x000000018AC8DF64-0x000000018AC8E198
		private void RefreshAlpha(); // 0x000000018AC8DF1C-0x000000018AC8DF64
		public void ToggleDropdownVisible(); // 0x000000018AC8E85C-0x000000018AC8E890
		public void MenuButtonPressed(); // 0x000000018AC8DD24-0x000000018AC8DD74
		public void ClearButtonPressed(); // 0x000000018AC8DD00-0x000000018AC8DD24
		public void TogglesUpdated(); // 0x000000018AC8E890-0x000000018AC8E940
		public void OnPointerEnter(PointerEventData e); // 0x000000018AC8DEFC-0x000000018AC8DF0C
		public void OnPointerExit(PointerEventData e); // 0x000000018AC8DF0C-0x000000018AC8DF1C
		public void OnBeginDrag(); // 0x000000018AC8DD74-0x000000018AC8DD80
		public void OnEndDrag(); // 0x000000018AC8DE88-0x000000018AC8DE9C
		[CompilerGenerated]
		private void _Start_b__25_0(bool isOn); // 0x000000018AC8E940-0x000000018AC8E970
		[CompilerGenerated]
		private void _Start_b__25_1(bool isOn); // 0x000000018AC8E970-0x000000018AC8E9A0
		[CompilerGenerated]
		private void _Start_b__25_2(bool isOn); // 0x000000018AC8E9A0-0x000000018AC8E9D0
		[CompilerGenerated]
		private void _Start_b__25_3(bool isOn); // 0x000000018AC8E9D0-0x000000018AC8EA00
	}

	public class ErrorNotifier : MonoBehaviour // TypeDefIndex: 60255
	{
		// Fields
		private const float DisplayTime = 6f; // Metadata: 0x0234D33C
		[SerializeField]
		private Animator _animator; // 0x18
		private int _triggerHash; // 0x20
		private float _hideTime; // 0x24
		private bool _isShowing; // 0x28
		private bool _queueWarning; // 0x29
	
		// Properties
		public bool IsVisible { get; } // 0x00000001811F33C0-0x00000001811F33D0 
	
		// Constructors
		public ErrorNotifier(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x000000018AC8F5D0-0x000000018AC8F60C
		public void ShowErrorWarning(); // 0x0000000184DA9E00-0x0000000184DA9E10
		private void Update(); // 0x000000018AC8F60C-0x000000018AC8F690
	}

	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class FloatOverElement : UIBehaviour, ILayoutSelfController // TypeDefIndex: 60256
	{
		// Fields
		public RectTransform CopyFrom; // 0x18
		private DrivenRectTransformTracker _tracker; // 0x20
	
		// Constructors
		public FloatOverElement(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Copy(); // 0x000000018AC8F690-0x000000018AC8F83C
		public void SetLayoutHorizontal(); // 0x000000018AC8F83C-0x000000018AC8F844
		public void SetLayoutVertical(); // 0x000000018AC8F83C-0x000000018AC8F844
	}

	public class HandleManager : SRMonoBehaviour // TypeDefIndex: 60257
	{
		// Fields
		private bool _hasSet; // 0x48
		public GameObject BottomHandle; // 0x50
		public GameObject BottomLeftHandle; // 0x58
		public GameObject BottomRightHandle; // 0x60
		public PinAlignment DefaultAlignment; // 0x68
		public GameObject LeftHandle; // 0x70
		public GameObject RightHandle; // 0x78
		public GameObject TopHandle; // 0x80
		public GameObject TopLeftHandle; // 0x88
		public GameObject TopRightHandle; // 0x90
	
		// Constructors
		public HandleManager(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Start(); // 0x000000018AC8FAA0-0x000000018AC8FAB4
		public void SetAlignment(PinAlignment alignment); // 0x000000018AC8F8B4-0x000000018AC8FAA0
		private void SetActive(GameObject obj, bool active); // 0x000000018AC8F844-0x000000018AC8F8B4
	}

	public interface IEnableTab // TypeDefIndex: 60258
	{
		// Properties
		bool IsEnabled { get; }
	}

	public class LoadingSpinnerBehaviour : SRMonoBehaviour // TypeDefIndex: 60259
	{
		// Fields
		private float _dt; // 0x48
		public int FrameCount; // 0x4C
		public float SpinDuration; // 0x50
	
		// Constructors
		public LoadingSpinnerBehaviour(); // 0x000000018AC906A8-0x000000018AC906CC
	
		// Methods
		private void Update(); // 0x000000018AC9059C-0x000000018AC906A8
	}

	public class PinnedUIRoot : SRMonoBehaviourEx // TypeDefIndex: 60260
	{
		// Fields
		[RequiredField]
		public Canvas Canvas; // 0x48
		[RequiredField]
		public RectTransform Container; // 0x50
		[RequiredField]
		public DockConsoleController DockConsoleController; // 0x58
		[RequiredField]
		public GameObject Options; // 0x60
		[RequiredField]
		public FlowLayoutGroup OptionsLayoutGroup; // 0x68
		[RequiredField]
		public GameObject Profiler; // 0x70
		[RequiredField]
		public HandleManager ProfilerHandleManager; // 0x78
		[RequiredField]
		public VerticalLayoutGroup ProfilerVerticalLayoutGroup; // 0x80
	
		// Constructors
		public PinnedUIRoot(); // 0x0000000185393520-0x0000000185393538
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class SafeAreaSizer : UIBehaviour, ILayoutElement // TypeDefIndex: 60261
	{
		// Fields
		[FormerlySerializedAs("Edge")]
		[SerializeField]
		private RectTransform.Edge _edge; // 0x18
		public float Scale; // 0x1C
		private float _height; // 0x20
		private float _width; // 0x24
	
		// Properties
		public RectTransform.Edge Edge { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018AC97F78-0x000000018AC98004
		public float preferredWidth { get; } // 0x0000000184D89850-0x0000000184D89860 
		public float preferredHeight { get; } // 0x00000001811EC8A0-0x00000001811EC8B0 
		public float minWidth { get; } // 0x0000000184D89850-0x0000000184D89860 
		public float minHeight { get; } // 0x00000001811EC8A0-0x00000001811EC8B0 
		public int layoutPriority { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public float flexibleHeight { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public float flexibleWidth { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
	
		// Constructors
		public SafeAreaSizer(); // 0x000000018AC97F5C-0x000000018AC97F78
	
		// Methods
		private void Refresh(); // 0x000000018AC97CBC-0x000000018AC97F5C
		public void CalculateLayoutInputHorizontal(); // 0x000000018AC97C90-0x000000018AC97CBC
		public void CalculateLayoutInputVertical(); // 0x000000018AC97C90-0x000000018AC97CBC
	}

	[RequireComponent(typeof(ScrollRect))]
	public class ScrollSettingsBehaviour : MonoBehaviour // TypeDefIndex: 60262
	{
		// Fields
		public const float ScrollSensitivity = 40f; // Metadata: 0x0234D340
	
		// Constructors
		public ScrollSettingsBehaviour(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x000000018AC98004-0x000000018AC98068
	}

	public class SetLayerFromSettings : SRMonoBehaviour // TypeDefIndex: 60263
	{
		// Constructors
		public SetLayerFromSettings(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Start(); // 0x000000018AC98068-0x000000018AC980A4
	}

	public class SRTab : SRMonoBehaviourEx // TypeDefIndex: 60264
	{
		// Fields
		public RectTransform HeaderExtraContent; // 0x48
		[HideInInspector]
		[Obsolete]
		public Sprite Icon; // 0x50
		public RectTransform IconExtraContent; // 0x58
		public string IconStyleKey; // 0x60
		public int SortIndex; // 0x68
		[HideInInspector]
		public SRTabButton TabButton; // 0x70
		[FormerlySerializedAs("Title")]
		[SerializeField]
		private string _title; // 0x78
		[SerializeField]
		private string _longTitle; // 0x80
		[SerializeField]
		private string _key; // 0x88
	
		// Properties
		public string Title { get; } // 0x0000000184D862A0-0x0000000184D862B0 
		public string LongTitle { get; } // 0x000000018AC97C78-0x000000018AC97C90 
		public string Key { get; } // 0x0000000184D861F0-0x0000000184D86200 
	
		// Constructors
		public SRTab(); // 0x000000018AC97C1C-0x000000018AC97C78
	}

	public class SRTabController : SRMonoBehaviourEx // TypeDefIndex: 60267
	{
		// Fields
		private readonly SRList<SRTab> _tabs; // 0x48
		private SRTab _activeTab; // 0x50
		[RequiredField]
		public RectTransform TabButtonContainer; // 0x58
		[RequiredField]
		public SRTabButton TabButtonPrefab; // 0x60
		[RequiredField]
		public RectTransform TabContentsContainer; // 0x68
		[RequiredField]
		public RectTransform TabHeaderContentContainer; // 0x70
		[RequiredField]
		public UnityEngine.UI.Text TabHeaderText; // 0x78
		[CompilerGenerated]
		private Action<SRTabController, SRTab> ActiveTabChanged; // 0x80
	
		// Properties
		public SRTab ActiveTab { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x000000018AC97C14-0x000000018AC97C1C
		public IList<SRTab> Tabs { get; } // 0x000000018AC97B3C-0x000000018AC97B84 
	
		// Events
		public event Action<SRTabController, SRTab> ActiveTabChanged {
			add; // 0x000000018AC97AAC-0x000000018AC97B3C
			remove; // 0x000000018AC97B84-0x000000018AC97C14
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 60265
		{
			// Fields
			public SRTabController __4__this; // 0x10
			public SRTab tab; // 0x18
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _AddTab_b__0(); // 0x000000018AC9936C-0x000000018AC99394
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 60266
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<SRTab> __9__17_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018AC994BC-0x000000018AC99520
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _SortTabs_b__17_0(SRTab t1, SRTab t2); // 0x000000018AC99308-0x000000018AC99334
		}
	
		// Constructors
		public SRTabController(); // 0x000000018AC97A48-0x000000018AC97AAC
	
		// Methods
		public void AddTab(SRTab tab, bool visibleInSidebar = true /* Metadata: 0x0234D344 */); // 0x000000018AC971FC-0x000000018AC97508
		private void MakeActive(SRTab tab); // 0x000000018AC97508-0x000000018AC97870
		private void SortTabs(); // 0x000000018AC97870-0x000000018AC97A48
	}

	public class TriggerRoot : SRMonoBehaviourEx // TypeDefIndex: 60268
	{
		// Fields
		[RequiredField]
		public Canvas Canvas; // 0x48
		[RequiredField]
		public LongPressButton TapHoldButton; // 0x50
		[RequiredField]
		public RectTransform TriggerTransform; // 0x58
		[RequiredField]
		public ErrorNotifier ErrorNotifier; // 0x60
		[FormerlySerializedAs("TriggerButton")]
		[RequiredField]
		public MultiTapButton TripleTapButton; // 0x68
	
		// Constructors
		public TriggerRoot(); // 0x0000000185393520-0x0000000185393538
	}

	public class VersionTextBehaviour : SRMonoBehaviourEx // TypeDefIndex: 60269
	{
		// Fields
		public string Format; // 0x48
		[RequiredField]
		public UnityEngine.UI.Text Text; // 0x50
	
		// Constructors
		public VersionTextBehaviour(); // 0x000000018AC99584-0x000000018AC995E0
	
		// Methods
		protected override void Start(); // 0x000000018AC99520-0x000000018AC99584
	}
}

namespace SRDebugger.UI.Tabs
{
	public class BugReportTabController : SRMonoBehaviourEx, IEnableTab // TypeDefIndex: 60237
	{
		// Fields
		[RequiredField]
		public BugReportSheetController BugReportSheetPrefab; // 0x48
		[RequiredField]
		public RectTransform Container; // 0x50
	
		// Properties
		public bool IsEnabled { get; } // 0x000000018AC8A0B8-0x000000018AC8A13C 
	
		// Constructors
		public BugReportTabController(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC89F3C-0x000000018AC8A06C
		private void TakingScreenshot(); // 0x000000018AC8A06C-0x000000018AC8A0B8
		private void ScreenshotComplete(); // 0x000000018AC89EF0-0x000000018AC89F3C
	}

	public class ConsoleTabController : SRMonoBehaviourEx // TypeDefIndex: 60240
	{
		// Fields
		private const int MaxLength = 2600; // Metadata: 0x0234D325
		private Canvas _consoleCanvas; // 0x48
		private bool _isDirty; // 0x50
		private static bool _hasWarnedAboutLogHandler; // 0x00
		private static bool _hasWarnedAboutLoggingDisabled; // 0x01
		[Import]
		public IConsoleFilterState FilterState; // 0x58
		[RequiredField]
		public ConsoleLogControl ConsoleLogControl; // 0x60
		[RequiredField]
		public Toggle PinToggle; // 0x68
		[RequiredField]
		public ScrollRect StackTraceScrollRect; // 0x70
		[RequiredField]
		public UnityEngine.UI.Text StackTraceText; // 0x78
		[RequiredField]
		public Toggle ToggleCriticals; // 0x80
		[RequiredField]
		public UnityEngine.UI.Text ToggleCriticalsText; // 0x88
		[RequiredField]
		public Toggle ToggleErrors; // 0x90
		[RequiredField]
		public UnityEngine.UI.Text ToggleErrorsText; // 0x98
		[RequiredField]
		public Toggle ToggleInfo; // 0xA0
		[RequiredField]
		public UnityEngine.UI.Text ToggleInfoText; // 0xA8
		[RequiredField]
		public Toggle ToggleWarnings; // 0xB0
		[RequiredField]
		public UnityEngine.UI.Text ToggleWarningsText; // 0xB8
		[RequiredField]
		public GameObject CopyToClipboardContainer; // 0xC0
		[RequiredField]
		public GameObject CopyToClipboardButton; // 0xC8
		[RequiredField]
		public GameObject CopyToClipboardMessage; // 0xD0
		[RequiredField]
		public CanvasGroup CopyToClipboardMessageCanvasGroup; // 0xD8
		[RequiredField]
		public GameObject LoggingIsDisabledCanvasGroup; // 0xE0
		[RequiredField]
		public GameObject LogHandlerHasBeenOverridenGroup; // 0xE8
		[RequiredField]
		public Toggle FilterToggle; // 0xF0
		[RequiredField]
		public InputField FilterField; // 0xF8
		[RequiredField]
		public GameObject FilterBarContainer; // 0x100
		private ConsoleEntry _selectedItem; // 0x108
		private Coroutine _fadeButtonCoroutine; // 0x110
	
		// Nested types
		public enum CopyToClipboardStates // TypeDefIndex: 60238
		{
			Hidden = 0,
			Visible = 1,
			Activated = 2
		}
	
		[CompilerGenerated]
		private sealed class _FadeCopyButton_d__44 : IEnumerator<object> // TypeDefIndex: 60239
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ConsoleTabController __4__this; // 0x20
			private float _startTime_5__2; // 0x28
			private float _endTime_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _FadeCopyButton_d__44(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AC98924-0x000000018AC98AB0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AC98AB0-0x000000018AC98AFC
		}
	
		// Constructors
		public ConsoleTabController(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC8C4A0-0x000000018AC8CAD8
		private void OnFilterStateChange(UnityEngine.LogType logtype, bool newstate); // 0x000000018AC8BCA4-0x000000018AC8BD04
		private void FilterToggleValueChanged(bool isOn); // 0x000000018AC8B93C-0x000000018AC8B9BC
		private void FilterValueChanged(string filterText); // 0x000000018AC8B9BC-0x000000018AC8BA38
		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b); // 0x000000018AC8BD04-0x000000018AC8BDA0
		private void PinToggleValueChanged(bool isOn); // 0x000000018AC8BDA0-0x000000018AC8BDCC
		protected override void OnDestroy(); // 0x000000018AC8BB9C-0x000000018AC8BC9C
		protected override void OnEnable(); // 0x0000000184DA9DE0-0x0000000184DA9DF0
		protected override void OnDisable(); // 0x000000018AC8BC9C-0x000000018AC8BCA4
		private void ConsoleLogSelectedItemChanged(object item); // 0x000000018AC8B7B8-0x000000018AC8B80C
		protected override void Update(); // 0x000000018AC8CBF4-0x000000018AC8CC04
		private void PopulateStackTraceArea(ConsoleEntry entry); // 0x000000018AC8BDCC-0x000000018AC8BFA0
		public void CopyToClipboard(); // 0x000000018AC8B80C-0x000000018AC8B8E0
		private void SetCopyToClipboardButtonState(CopyToClipboardStates state); // 0x000000018AC8C2E0-0x000000018AC8C4A0
		[IteratorStateMachine(typeof(_FadeCopyButton_d__44))]
		private IEnumerator FadeCopyButton(); // 0x000000018AC8B8E0-0x000000018AC8B93C
		private void StopAnimations(); // 0x000000018AC8CAD8-0x000000018AC8CB34
		private void Refresh(); // 0x000000018AC8BFA0-0x000000018AC8C2E0
		private void ConsoleOnUpdated(IConsoleService console); // 0x0000000184DA9DE0-0x0000000184DA9DF0
		public void Clear(); // 0x000000018AC8B788-0x000000018AC8B7B8
		public void LogHandlerHasBeenOverridenOkayButtonPress(); // 0x000000018AC8BA38-0x000000018AC8BA90
		public void LoggingDisableCloseAndIgnorePressed(); // 0x000000018AC8BA90-0x000000018AC8BAEC
		public void LoggingDisableReenablePressed(); // 0x000000018AC8BAEC-0x000000018AC8BB9C
		[CompilerGenerated]
		private void _Start_b__29_0(bool isOn); // 0x000000018AC8CB34-0x000000018AC8CB64
		[CompilerGenerated]
		private void _Start_b__29_1(bool isOn); // 0x000000018AC8CB64-0x000000018AC8CB94
		[CompilerGenerated]
		private void _Start_b__29_2(bool isOn); // 0x000000018AC8CB94-0x000000018AC8CBC4
		[CompilerGenerated]
		private void _Start_b__29_3(bool isOn); // 0x000000018AC8CBC4-0x000000018AC8CBF4
	}

	public class InfoTabController : SRMonoBehaviourEx // TypeDefIndex: 60241
	{
		// Fields
		public const char Tick = '\x2713'; // Metadata: 0x0234D32A
		public const char Cross = '\x00d7'; // Metadata: 0x0234D32C
		public const string NameColor = "#BCBCBC"; // Metadata: 0x0234D32E
		private Dictionary<string, InfoBlock> _infoBlocks; // 0x48
		[RequiredField]
		public InfoBlock InfoBlockPrefab; // 0x50
		[RequiredField]
		public RectTransform LayoutContainer; // 0x58
		[RequiredField]
		public FlashGraphic ToggleButton; // 0x60
		private bool _updateEveryFrame; // 0x68
	
		// Constructors
		public InfoTabController(); // 0x000000018AC9051C-0x000000018AC9059C
	
		// Methods
		protected override void OnEnable(); // 0x000000018AC904A0-0x000000018AC904D8
		public void Refresh(); // 0x000000018AC904D8-0x000000018AC9050C
		protected override void Update(); // 0x000000018AC9050C-0x000000018AC9051C
		public void ActivateRefreshEveryFrame(); // 0x000000018AC8FBC8-0x000000018AC8FBFC
		private void InternalRefresh(); // 0x000000018AC90100-0x000000018AC904A0
		private void FillInfoBlock(InfoBlock block, IList<SRDebugger.InfoEntry> info); // 0x000000018AC8FC94-0x000000018AC90100
		private InfoBlock CreateBlock(string title); // 0x000000018AC8FBFC-0x000000018AC8FC94
	}

	public class OptionsTabController : SRMonoBehaviourEx // TypeDefIndex: 60245
	{
		// Fields
		private readonly List<OptionsControlBase> _controls; // 0x48
		private readonly List<CategoryInstance> _categories; // 0x50
		private readonly Dictionary<OptionDefinition, OptionsControlBase> _options; // 0x58
		private bool _queueRefresh; // 0x60
		private bool _selectionModeEnabled; // 0x61
		private Canvas _optionCanvas; // 0x68
		[RequiredField]
		public ActionControl ActionControlPrefab; // 0x70
		[RequiredField]
		public CategoryGroup CategoryGroupPrefab; // 0x78
		[RequiredField]
		public RectTransform ContentContainer; // 0x80
		[RequiredField]
		public GameObject NoOptionsNotice; // 0x88
		[RequiredField]
		public Toggle PinButton; // 0x90
		[RequiredField]
		public GameObject PinPromptSpacer; // 0x98
		[RequiredField]
		public GameObject PinPromptText; // 0xA0
		private bool _isTogglingCategory; // 0xA8
	
		// Nested types
		private class CategoryInstance // TypeDefIndex: 60242
		{
			// Fields
			[CompilerGenerated]
			private CategoryGroup _CategoryGroup_k__BackingField; // 0x10
			public readonly List<OptionsControlBase> Options; // 0x18
	
			// Properties
			public CategoryGroup CategoryGroup { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
			// Constructors
			public CategoryInstance(CategoryGroup group); // 0x000000018AC8A2E8-0x000000018AC8A378
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 60243
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<string, List<OptionDefinition>>, string> __9__29_0; // 0x08
			public static Comparison<OptionDefinition> __9__30_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018AC99458-0x000000018AC994BC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _Populate_b__29_0(KeyValuePair<string, List<OptionDefinition>> p); // 0x000000018AC992D4-0x000000018AC99308
			internal int _CreateCategory_b__30_0(OptionDefinition d1, OptionDefinition d2); // 0x000000018AC99220-0x000000018AC99254
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0 // TypeDefIndex: 60244
		{
			// Fields
			public OptionsTabController __4__this; // 0x10
			public CategoryInstance categoryInstance; // 0x18
	
			// Constructors
			public __c__DisplayClass30_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _CreateCategory_b__1(bool b); // 0x000000018AC99394-0x000000018AC993C4
		}
	
		// Constructors
		public OptionsTabController(); // 0x000000018AC94320-0x000000018AC94434
	
		// Methods
		protected override void Start(); // 0x000000018AC94128-0x000000018AC9430C
		protected override void OnDestroy(); // 0x000000018AC92FE8-0x000000018AC93140
		private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned); // 0x000000018AC932A4-0x000000018AC93344
		private void OnOptionsUpdated(object sender, EventArgs eventArgs); // 0x000000018AC93374-0x000000018AC93394
		protected override void OnEnable(); // 0x000000018AC93210-0x000000018AC932A4
		protected override void OnDisable(); // 0x000000018AC93140-0x000000018AC93210
		protected override void Update(); // 0x000000018AC9430C-0x000000018AC94320
		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b); // 0x000000018AC93394-0x000000018AC93448
		public void SetSelectionModeEnabled(bool isEnabled); // 0x000000018AC93DC8-0x000000018AC94128
		private void Refresh(); // 0x000000018AC93C88-0x000000018AC93DC8
		private void CommitPinnedOptions(); // 0x000000018AC9264C-0x000000018AC92878
		private void RefreshCategorySelection(); // 0x000000018AC93AC4-0x000000018AC93C88
		private void OnOptionSelectionToggle(bool selected); // 0x000000018AC93344-0x000000018AC93374
		private void OnCategorySelectionToggle(CategoryInstance category, bool selected); // 0x000000018AC92F34-0x000000018AC92FE8
		protected void Populate(); // 0x000000018AC93448-0x000000018AC93AC4
		protected void CreateCategory(string title, List<OptionDefinition> options); // 0x000000018AC92878-0x000000018AC92F34
		private void Clear(); // 0x000000018AC92480-0x000000018AC9264C
	}

	public class ProfilerTabController : SRMonoBehaviourEx // TypeDefIndex: 60246
	{
		// Fields
		private bool _isDirty; // 0x48
		[RequiredField]
		public Toggle PinToggle; // 0x50
	
		// Constructors
		public ProfilerTabController(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void Start(); // 0x000000018AC96F14-0x000000018AC96FCC
		private void PinToggleValueChanged(bool isOn); // 0x000000018AC96E48-0x000000018AC96E9C
		protected override void OnEnable(); // 0x0000000184D99870-0x0000000184D99880
		protected override void Update(); // 0x000000018AC96FCC-0x000000018AC96FDC
		private void Refresh(); // 0x000000018AC96E9C-0x000000018AC96F14
	}
}
