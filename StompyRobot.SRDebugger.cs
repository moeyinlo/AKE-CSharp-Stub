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

// Image 48: StompyRobot.SRDebugger.dll - Assembly: StompyRobot.SRDebugger, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56687-56845
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("StompyRobot.SRDebugger.Editor")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public static class SRDebug // TypeDefIndex: 56689
{
	// Fields
	public const string Version = "1.12.1"; // Metadata: 0x01FD8156
	public static Action<ConsoleEntry> CopyConsoleItemCallback; // 0x08

	// Properties
	public static bool IsInitialized { get; private set; } // 0x00000001896B88D8-0x00000001896B8928 0x00000001896B8928-0x00000001896B897C
	public static IDebugService Instance { get; } // 0x00000001896B8884-0x00000001896B88D8 

	// Constructors
	static SRDebug() {} // 0x0000000183B3D220-0x0000000183B3D280

	// Methods
	public static void Init() {} // 0x0000000183A273C0-0x0000000183A274B0
	public static Action<ConsoleEntry> GetDefaultCopyConsoleItemCallback() => default; // 0x0000000183B3D280-0x0000000183B3D380
}

namespace Assets.StompyRobot.SRDebugger.Scripts.Services.Implementation
{
	[Service(typeof(IConsoleFilterState))]
	public sealed class ConsoleFilterStateService : IConsoleFilterState // TypeDefIndex: 56690
	{
		// Fields
		private readonly bool[] _states; // 0x18
	
		// Events
		public event ConsoleStateChangedEventHandler FilterStateChange;
	
		// Constructors
		public ConsoleFilterStateService() {} // 0x00000001896AC424-0x00000001896AC50C
	
		// Methods
		public void SetConsoleFilterState(UnityEngine.LogType type, bool newState) {} // 0x00000001896AC2CC-0x00000001896AC33C
		public bool GetConsoleFilterState(UnityEngine.LogType type) => default; // 0x00000001896AC250-0x00000001896AC28C
		private static UnityEngine.LogType GetType(UnityEngine.LogType type) => default; // 0x00000001896AC28C-0x00000001896AC2CC
	}
}

namespace SRDebugger
{
	public static class AutoInitialize // TypeDefIndex: 56691
	{
		// Fields
		private const RuntimeInitializeLoadType InitializeLoadType = RuntimeInitializeLoadType.SubsystemRegistration; // Metadata: 0x01FD815D
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void OnLoadBeforeScene() {} // 0x0000000183A274B0-0x0000000183A27550
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		public static void OnLoad() {} // 0x0000000183A27360-0x0000000183A273C0
	}

	public class BugReport // TypeDefIndex: 56692
	{
		// Fields
		public List<ConsoleEntry> ConsoleLog; // 0x10
		public string Email; // 0x18
		public byte[] ScreenshotData; // 0x20
		public Dictionary<string, Dictionary<string, object>> SystemInformation; // 0x28
		public string UserDescription; // 0x30
	
		// Constructors
		public BugReport() {} // 0x000000018350B670-0x000000018350B680
	}

	public sealed class BugReportSubmitResult // TypeDefIndex: 56693
	{
		// Properties
		public static BugReportSubmitResult Success { get => default; } // 0x00000001896AB4A0-0x00000001896AB4F4 
		public bool IsSuccessful { get; } // 0x00000001811797F0-0x0000000181179800 
		public string ErrorMessage { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public BugReportSubmitResult() {} // Dummy constructor
		private BugReportSubmitResult(bool successful, string error) {} // 0x0000000182F73D00-0x0000000182F73D10
	
		// Methods
		public static BugReportSubmitResult Error(string errorMessage) => default; // 0x00000001896AB444-0x00000001896AB4A0
	}

	public interface IBugReporterHandler // TypeDefIndex: 56694
	{
		// Properties
		bool IsUsable { get; }
	
		// Methods
		void Submit(BugReport report, Action<BugReportSubmitResult> onComplete, IProgress<float> progress);
	}

	public class CircularBuffer<T> : IReadOnlyList<T> // TypeDefIndex: 56696
	{
		// Fields
		private readonly T[] _buffer;
		private int _end;
		private int _count;
		private int _start;
	
		// Properties
		public int Capacity { get => default; }
		public bool IsFull { get => default; }
		public bool IsEmpty { get => default; }
		public int Count { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public CircularBuffer() {} // Dummy constructor
		public CircularBuffer(int capacity) {}
		public CircularBuffer(int capacity, T[] items) {}
	
		// Methods
		public void Clear() {}
		[IteratorStateMachine(typeof(_GetEnumerator_d__18))]
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public T Front() => default;
		public T Back() => default;
		public void PushBack(T item) {}
		public void PushFront(T item) {}
		public void PopBack() {}
		public void PopFront() {}
		public T[] ToArray() => default;
		private void ThrowIfEmpty(string message = "Cannot access an empty buffer." /* Metadata: 0x01FD815E */) {}
		private void Increment(ref int index) {}
		private void Decrement(ref int index) {}
		private int InternalIndex(int index) => default;
		private ArraySegment<T> ArrayOne() => default;
		private ArraySegment<T> ArrayTwo() => default;
	}

	public sealed class OptionDefinition // TypeDefIndex: 56697
	{
		// Properties
		public string Name { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string Category { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public int SortPriority { get; private set; } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public bool IsMethod { get => default; } // 0x0000000185693D38-0x0000000185693D44 
		public bool IsProperty { get => default; } // 0x00000001885839D0-0x00000001885839DC 
		public MethodReference Method { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public PropertyReference Property { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
	
		// Constructors
		public OptionDefinition() {} // Dummy constructor
		private OptionDefinition(string name, string category, int sortPriority) {} // 0x0000000183864580-0x00000001838645B0
		public OptionDefinition(string name, string category, int sortPriority, MethodReference method) {} // 0x00000001896B37D0-0x00000001896B3800
		public OptionDefinition(string name, string category, int sortPriority, PropertyReference property) {} // 0x00000001896B37A0-0x00000001896B37D0
	
		// Methods
		public static OptionDefinition FromMethod(string name, Action callback, string category = "Default" /* Metadata: 0x01FD817D */, int sortPriority = 0 /* Metadata: 0x01FD8185 */) => default; // 0x00000001896B36FC-0x00000001896B37A0
		public static OptionDefinition Create<T>(string name, Func<T> getter, Action<T> setter = null, string category = "Default" /* Metadata: 0x01FD8186 */, int sortPriority = 0 /* Metadata: 0x01FD818E */) => default;
	}

	public interface IOptionContainer // TypeDefIndex: 56698
	{
		// Properties
		bool IsDynamic { get; }
	
		// Events
		event Action<OptionDefinition> OptionAdded;
		event Action<OptionDefinition> OptionRemoved;
	
		// Methods
		IEnumerable<OptionDefinition> GetOptions();
	}

	public sealed class DynamicOptionContainer : IOptionContainer // TypeDefIndex: 56699
	{
		// Fields
		private readonly List<OptionDefinition> _options; // 0x10
		private readonly IList<OptionDefinition> _optionsReadOnly; // 0x18
	
		// Properties
		public IList<OptionDefinition> Options { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public bool IsDynamic { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Events
		public event Action<OptionDefinition> OptionAdded;
		public event Action<OptionDefinition> OptionRemoved;
	
		// Constructors
		public DynamicOptionContainer() {} // 0x00000001896B01B0-0x00000001896B0254
	
		// Methods
		public void AddOption(OptionDefinition option) {} // 0x00000001896B00D0-0x00000001896B013C
		public bool RemoveOption(OptionDefinition option) => default; // 0x00000001896B013C-0x00000001896B01B0
		IEnumerable<OptionDefinition> IOptionContainer.GetOptions() => default; // 0x00000001820B7B20-0x00000001820B7B30
	}

	public delegate void VisibilityChangedDelegate(bool isVisible); // TypeDefIndex: 56700; 0x0000000182149960-0x0000000182149970

	public delegate void ActionCompleteCallback(bool success); // TypeDefIndex: 56701; 0x0000000182149960-0x0000000182149970

	public delegate void PinnedUiCanvasCreated(RectTransform canvasTransform); // TypeDefIndex: 56702; 0x0000000182149960-0x0000000182149970

	public struct EntryCode : IReadOnlyList<int> // TypeDefIndex: 56703
	{
		// Fields
		public readonly int Digit1; // 0x00
		public readonly int Digit2; // 0x04
		public readonly int Digit3; // 0x08
		public readonly int Digit4; // 0x0C
	
		// Properties
		public int Count { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
		public int this[int index] { get => default; } // 0x00000001896B0774-0x00000001896B07F8 
	
		// Constructors
		public EntryCode(int digit1, int digit2, int digit3, int digit4) : this() {
			Digit1 = default;
			Digit2 = default;
			Digit3 = default;
			Digit4 = default;
		} // 0x00000001896B059C-0x00000001896B0774
	
		// Methods
		public IEnumerator<int> GetEnumerator() => default; // 0x00000001896B0484-0x00000001896B0594
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001896B0594-0x00000001896B059C
	}

	public sealed class InfoEntry // TypeDefIndex: 56705
	{
		// Fields
		private Func<object> _valueGetter; // 0x20
	
		// Properties
		public string Title { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public object Value { get => default; } // 0x00000001896B1100-0x00000001896B1214 
		public bool IsPrivate { get; private set; } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
	
		// Constructors
		public InfoEntry() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static InfoEntry Create(string name, Func<object> getter, bool isPrivate = false /* Metadata: 0x01FD818F */) => default; // 0x000000018315D1E0-0x000000018315D270
		public static InfoEntry Create(string name, object value, bool isPrivate = false /* Metadata: 0x01FD8190 */) => default; // 0x000000018315D270-0x000000018315D380
	}

	public enum DefaultTabs // TypeDefIndex: 56706
	{
		SystemInformation = 0,
		Options = 1,
		Console = 2,
		Profiler = 3,
		BugReporter = 4
	}

	public enum PinAlignment // TypeDefIndex: 56707
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

	public enum ConsoleAlignment // TypeDefIndex: 56708
	{
		Top = 0,
		Bottom = 1
	}

	public class Settings : ScriptableObject // TypeDefIndex: 56715
	{
		// Fields
		internal const string ResourcesName = "Settings"; // Metadata: 0x01FD81A0
		private static Settings _instance; // 0x00
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
		public static Settings Instance { get => default; } // 0x000000018267B8C0-0x000000018267B970 
		public bool IsEnabled { get => default; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
		public UIModes UIInputMode { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public DefaultTabs DefaultTab { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
		public TriggerEnableModes EnableTrigger { get => default; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 
		public TriggerBehaviours TriggerBehaviour { get => default; } // 0x0000000183D4ED20-0x0000000183D4ED30 
		public bool ErrorNotification { get => default; } // 0x0000000183D4F570-0x0000000183D4F580 
		public bool EnableKeyboardShortcuts { get => default; } // 0x0000000183D4F560-0x0000000183D4F570 
		public IList<KeyboardShortcut> KeyboardShortcuts { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public bool KeyboardEscapeClose { get => default; } // 0x0000000183D56CD0-0x0000000183D56CE0 
		public bool EnableBackgroundTransparency { get => default; } // 0x0000000183D4F520-0x0000000183D4F530 
		public float BackgroundTransparency { get => default; } // 0x0000000183D51C90-0x0000000183D51CA0 
		public bool RequireCode { get => default; } // 0x0000000183D58490-0x0000000183D584A0 
		public bool RequireEntryCodeEveryTime { get => default; } // 0x0000000183D58480-0x0000000183D58490 
		public IList<int> EntryCode { get => default; set {} } // 0x00000001896B99F8-0x00000001896B9A6C 0x00000001896B9B00-0x00000001896B9D10
		public bool UseDebugCamera { get => default; } // 0x0000000183D519A0-0x0000000183D519B0 
		public int DebugLayer { get => default; } // 0x0000000183D50B30-0x0000000183D50B40 
		public float DebugCameraDepth { get => default; } // 0x0000000183D56A40-0x0000000183D56A50 
		public bool CollapseDuplicateLogEntries { get => default; } // 0x0000000183D4F320-0x0000000183D4F330 
		public bool RichTextInConsole { get => default; } // 0x0000000183D4F310-0x0000000183D4F320 
		public string ApiKey { get => default; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		public bool EnableBugReporter { get => default; } // 0x0000000183D4F800-0x0000000183D4F810 
		public bool EnableBugReportScreenshot { get => default; } // 0x0000000183D51AE0-0x0000000183D51AF0 
		public IList<DefaultTabs> DisabledTabs { get => default; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public PinAlignment TriggerPosition { get => default; } // 0x0000000183D5B3A0-0x0000000183D5B3B0 
		public PinAlignment ProfilerAlignment { get => default; } // 0x0000000183D4F0B0-0x0000000183D4F0C0 
		public PinAlignment OptionsAlignment { get => default; } // 0x0000000183D4F3D0-0x0000000183D4F3E0 
		public ConsoleAlignment ConsoleAlignment { get => default; set {} } // 0x0000000183D4FB60-0x0000000183D4FB70 0x0000000183D4FB70-0x0000000183D4FB80
		public int MaximumConsoleEntries { get => default; set {} } // 0x0000000183D4EB50-0x0000000183D4EB60 0x0000000183D4EB80-0x0000000183D4EB90
		public bool EnableEventSystemGeneration { get => default; set {} } // 0x0000000183D5E1C0-0x0000000183D5E1D0 0x0000000183D5E200-0x0000000183D5E210
		public bool AutomaticallyShowCursor { get => default; } // 0x0000000183D6E090-0x0000000183D6E0A0 
		public float UIScale { get => default; set {} } // 0x0000000183D58340-0x0000000183D58350 0x00000001896B9D10-0x00000001896B9D70
		public bool UnloadOnClose { get => default; } // 0x0000000183D58450-0x0000000183D58460 
	
		// Events
		public event PropertyChangedEventHandler PropertyChanged;
	
		// Nested types
		public enum ShortcutActions // TypeDefIndex: 56709
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
	
		public enum TriggerBehaviours // TypeDefIndex: 56710
		{
			TripleTap = 0,
			TapAndHold = 1,
			DoubleTap = 2
		}
	
		public enum TriggerEnableModes // TypeDefIndex: 56711
		{
			Enabled = 0,
			MobileOnly = 1,
			Off = 2,
			DevelopmentBuildsOnly = 3
		}
	
		public enum UIModes // TypeDefIndex: 56712
		{
			NewInputSystem = 0,
			LegacyInputSystem = 1
		}
	
		[Serializable]
		public sealed class KeyboardShortcut // TypeDefIndex: 56713
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
			public KeyboardShortcut() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public Settings() {} // 0x000000018389ED90-0x000000018389EEB0
	
		// Methods
		private static KeyboardShortcut[] GetDefaultKeyboardShortcuts() => default; // 0x000000018389EEB0-0x000000018389EFF0
		private void UpgradeKeyboardShortcuts() {} // 0x0000000183A44180-0x0000000183A44220
		private void OnPropertyChanged(string propertyName) {} // 0x00000001896B98D4-0x00000001896B9964
		internal static void ClearCache() {} // 0x00000001896B9834-0x00000001896B98D4
		internal static Settings GetInstance() => default; // 0x0000000183A44130-0x0000000183A44180
		private static Settings GetOrCreateInstance() => default; // 0x0000000183A44090-0x0000000183A44130
	}

	[AddComponentMenu("")]
	[Obsolete("No longer required, use Automatic initialization mode or call SRDebug.Init() manually.")]
	public class SRDebuggerInit : SRMonoBehaviourEx // TypeDefIndex: 56716
	{
		// Constructors
		public SRDebuggerInit() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[AttributeUsage(AttributeTargets.Property)]
	public class NumberRangeAttribute : Attribute // TypeDefIndex: 56717
	{
		// Fields
		public readonly double Max; // 0x10
		public readonly double Min; // 0x18
	
		// Constructors
		public NumberRangeAttribute() {} // Dummy constructor
		public NumberRangeAttribute(double min, double max) {} // 0x0000000183D4E420-0x0000000183D4E430
	}

	[AttributeUsage(AttributeTargets.Property)]
	public class IncrementAttribute : Attribute // TypeDefIndex: 56718
	{
		// Fields
		public readonly double Increment; // 0x10
	
		// Constructors
		public IncrementAttribute() {} // Dummy constructor
		public IncrementAttribute(double increment) {} // 0x0000000183D4E410-0x0000000183D4E420
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public class SortAttribute : Attribute // TypeDefIndex: 56719
	{
		// Fields
		public readonly int SortPriority; // 0x10
	
		// Constructors
		public SortAttribute() {} // Dummy constructor
		public SortAttribute(int priority) {} // 0x00000001810410F0-0x0000000181041100
	}

	public static class VersionInfo // TypeDefIndex: 56720
	{
		// Fields
		public const string Version = "1.12.1"; // Metadata: 0x01FD81BE
	}
}

namespace SRDebugger.Internal
{
	public static class SRDebugApi // TypeDefIndex: 56829
	{
		// Fields
		public const string Protocol = "https://"; // Metadata: 0x01FD8279
		public const string EndPoint = "https://srdebugger.stompyrobot.uk"; // Metadata: 0x01FD8282
		public const string BugReportEndPoint = "https://srdebugger.stompyrobot.uk/report/submit"; // Metadata: 0x01FD82A4
	}

	public static class SRDebugApiUtil // TypeDefIndex: 56830
	{
		// Methods
		public static string ParseErrorException(WebException ex) => default; // 0x00000001896C1054-0x00000001896C1130
		public static string ParseErrorResponse(string response, string fallback = "Unexpected Response" /* Metadata: 0x01FD82D4 */) => default; // 0x00000001896C1130-0x00000001896C15C8
		public static bool ReadResponse(HttpWebRequest request, out string result) {
			result = default;
			return default;
		} // 0x00000001896C1750-0x00000001896C1810
		public static string ReadResponseStream(WebResponse stream) => default; // 0x00000001896C15C8-0x00000001896C1750
	}

	internal class BugReportApi : MonoBehaviour // TypeDefIndex: 56832
	{
		// Fields
		private string _apiKey; // 0x18
		private BugReport _bugReport; // 0x20
		private bool _isBusy; // 0x28
		private UnityWebRequest _webRequest; // 0x30
		private Action<BugReportSubmitResult> _onComplete; // 0x38
		private IProgress<float> _progress; // 0x40
	
		// Constructors
		public BugReportApi() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public static void Submit(BugReport report, string apiKey, Action<BugReportSubmitResult> onComplete, IProgress<float> progress) {} // 0x00000001896BB654-0x00000001896BB794
		private void Init(BugReport report, string apiKey, Action<BugReportSubmitResult> onComplete, IProgress<float> progress) {} // 0x00000001896BB520-0x00000001896BB568
		private void Update() {} // 0x00000001896BB7F0-0x00000001896BB860
		[IteratorStateMachine(typeof(_Submit_d__9))]
		private IEnumerator Submit() => default; // 0x00000001896BB794-0x00000001896BB7F0
		private void SetCompletionState(BugReportSubmitResult result) {} // 0x00000001896BB568-0x00000001896BB654
		private static string BuildJsonRequest(BugReport report) => default; // 0x00000001896BB0B8-0x00000001896BB234
		private static List<List<string>> CreateConsoleDump() => default; // 0x00000001896BB234-0x00000001896BB520
	}

	public class BugReportScreenshotUtil // TypeDefIndex: 56834
	{
		// Fields
		public static byte[] ScreenshotData; // 0x00
	
		// Constructors
		public BugReportScreenshotUtil() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[IteratorStateMachine(typeof(_ScreenshotCaptureCo_d__1))]
		public static IEnumerator ScreenshotCaptureCo() => default; // 0x00000001896BB860-0x00000001896BB8A4
	}

	internal class InternalBugReporterHandler : IBugReporterHandler // TypeDefIndex: 56835
	{
		// Properties
		public bool IsUsable { get => default; } // 0x00000001896BCE4C-0x00000001896BCE8C 
	
		// Constructors
		public InternalBugReporterHandler() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Submit(BugReport report, Action<BugReportSubmitResult> onComplete, IProgress<float> progress) {} // 0x00000001896BCDF8-0x00000001896BCE4C
	}

	[Service(typeof(InternalOptionsRegistry))]
	public sealed class InternalOptionsRegistry // TypeDefIndex: 56836
	{
		// Fields
		private List<object> _registeredContainers; // 0x10
		private Action<object> _handler; // 0x18
	
		// Constructors
		public InternalOptionsRegistry() {} // 0x0000000183CFD4F0-0x0000000183CFD570
	
		// Methods
		public void AddOptionContainer(object obj) {} // 0x00000001826CCCF0-0x00000001826CCD50
		public void SetHandler(Action<object> action) {} // 0x00000001826CBDD0-0x00000001826CBFD0
	}

	public static class OptionControlFactory // TypeDefIndex: 56839
	{
		// Fields
		private static IList<DataBoundControl> _dataControlPrefabs; // 0x00
		private static ActionControl _actionControlPrefab; // 0x08
		private static readonly Dictionary<OptionType, DataBoundControl> TypeCache; // 0x10
	
		// Nested types
		private struct OptionType // TypeDefIndex: 56837
		{
			// Fields
			public readonly System.Type Type; // 0x00
			public readonly bool IsReadyOnly; // 0x08
	
			// Constructors
			public OptionType(System.Type type, bool isReadyOnly) {
				Type = default;
				IsReadyOnly = default;
			} // 0x00000001871B198C-0x00000001871B19A8
	
			// Methods
			public bool Equals(OptionType other) => default; // 0x00000001896BE908-0x00000001896BE940
			public override bool Equals(object obj) => default; // 0x00000001896BE898-0x00000001896BE908
			public override int GetHashCode() => default; // 0x00000001896BE940-0x00000001896BE9DC
		}
	
		// Constructors
		static OptionControlFactory() {} // 0x00000001896BE804-0x00000001896BE898
	
		// Methods
		public static bool CanCreateControl(OptionDefinition from) => default; // 0x00000001896BDEE4-0x00000001896BDF8C
		public static OptionsControlBase CreateControl(OptionDefinition from, string categoryPrefix = null) => default; // 0x00000001896BE08C-0x00000001896BE178
		private static void PopulateDataControlPrefabs() {} // 0x00000001896BE45C-0x00000001896BE628
		private static ActionControl CreateActionControl(OptionDefinition from, string categoryPrefix = null) => default; // 0x00000001896BDF8C-0x00000001896BE08C
		private static DataBoundControl CreateDataControl(OptionDefinition from, string categoryPrefix = null) => default; // 0x00000001896BE178-0x00000001896BE45C
		private static DataBoundControl TryGetDataControlPrefab(OptionDefinition from) => default; // 0x00000001896BE628-0x00000001896BE804
	}

	public static class SRDebugPaths // TypeDefIndex: 56840
	{
		// Fields
		public const string DataControlsResourcesPath = "SRDebugger/UI/Prefabs/Options"; // Metadata: 0x01FD82E8
		public const string TriggerPrefabPath = "SRDebugger/UI/Prefabs/Trigger"; // Metadata: 0x01FD8306
		public const string DebugPanelPrefabPath = "SRDebugger/UI/Prefabs/DebugPanel"; // Metadata: 0x01FD8324
		public const string PinnedUIPrefabPath = "SRDebugger/UI/Prefabs/PinnedUI"; // Metadata: 0x01FD8345
		public const string DockConsolePrefabPath = "SRDebugger/UI/Prefabs/DockConsole"; // Metadata: 0x01FD8364
		public const string PinEntryPrefabPath = "SRDebugger/UI/Prefabs/PinEntry"; // Metadata: 0x01FD8386
		public const string BugReportPopoverPath = "SRDebugger/UI/Prefabs/BugReportPopover"; // Metadata: 0x01FD83A5
		public const string BugReportSheetPath = "SRDebugger/UI/Prefabs/BugReportSheet"; // Metadata: 0x01FD83CC
	}

	public static class Service // TypeDefIndex: 56841
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
		public static IConsoleService Console { get; } // 0x00000001896C3564-0x00000001896C3604 
		public static IDockConsoleService DockConsole { get; } // 0x00000001896C36AC-0x00000001896C3754 
		public static IDebugPanelService Panel { get; } // 0x00000001896C37FC-0x00000001896C38A4 
		public static IDebugTriggerService Trigger { get; } // 0x00000001896C394C-0x00000001896C39F4 
		public static IPinnedUIService PinnedUI { get; } // 0x00000001896C38A4-0x00000001896C394C 
		public static IDebugCameraService DebugCamera { get; } // 0x00000001896C3604-0x00000001896C36AC 
		public static IOptionsService Options { get; } // 0x00000001896C3754-0x00000001896C37FC 
	}

	public class SRDebugStrings // TypeDefIndex: 56842
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
		public SRDebugStrings() {} // 0x00000001896C3070-0x00000001896C3190
		static SRDebugStrings() {} // 0x00000001896C3000-0x00000001896C3070
	}

	public static class SRDebuggerUtil // TypeDefIndex: 56843
	{
		// Properties
		public static bool IsMobilePlatform { get; } // 0x00000001896C3538-0x00000001896C3564 
	
		// Methods
		public static bool EnsureEventSystemExists() => default; // 0x00000001896C33DC-0x00000001896C3514
		public static void CreateDefaultEventSystem() {} // 0x00000001896C32DC-0x00000001896C33DC
		private static void AddInputSystem(GameObject go) {} // 0x00000001896C3190-0x00000001896C31F0
		private static void AddLegacyInputSystem(GameObject go) {} // 0x00000001896C31F0-0x00000001896C3234
		public static List<OptionDefinition> ScanForOptions(object obj) => default; // 0x0000000182678EF0-0x00000001826792C0
		public static string GetNumberString(int value, int max, string exceedsMaxString) => default; // 0x00000001896C3514-0x00000001896C3538
		public static void ConfigureCanvas(Canvas canvas) {} // 0x00000001896C3234-0x00000001896C32DC
	}
}

namespace SRDebugger.Profiler
{
	public class ProfilerLateUpdateListener : MonoBehaviour // TypeDefIndex: 56825
	{
		// Fields
		public Action OnLateUpdate; // 0x18
	
		// Constructors
		public ProfilerLateUpdateListener() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void LateUpdate() {} // 0x0000000183180DF0-0x0000000183180E10
	}

	public class ProfilerServiceImpl : SRServiceBase<IProfilerService>, IProfilerService // TypeDefIndex: 56826
	{
		// Fields
		private const int FrameBufferSize = 400; // Metadata: 0x01FD8275
		private readonly CircularBuffer<ProfilerFrame> _frameBuffer; // 0x50
		private ProfilerLateUpdateListener _lateUpdateListener; // 0x58
		private readonly Stopwatch _stopwatch; // 0x60
		private double _updateDuration; // 0x68
		private double _renderStartTime; // 0x70
		private double _renderDuration; // 0x78
		private int _camerasThisFrame; // 0x80
	
		// Properties
		public float AverageFrameTime { get; private set; } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public float LastFrameTime { get; private set; } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public CircularBuffer<ProfilerFrame> FrameBuffer { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
	
		// Constructors
		public ProfilerServiceImpl() {} // 0x00000001896C0EBC-0x00000001896C0F78
	
		// Methods
		protected override void Awake() {} // 0x00000001896C077C-0x00000001896C0A80
		protected override void Update() {} // 0x00000001896C0D38-0x00000001896C0EBC
		protected void PushFrame(double totalTime, double updateTime, double renderTime) {} // 0x00000001896C0C9C-0x00000001896C0D38
		private void OnLateUpdate() {} // 0x00000001896C0C2C-0x00000001896C0C9C
		private void OnCameraPreRender(Camera cam) {} // 0x00000001896C0BAC-0x00000001896C0C2C
		private void OnCameraPostRender(Camera cam) {} // 0x00000001896C0B38-0x00000001896C0BAC
		private void EndFrame() {} // 0x00000001896C0A80-0x00000001896C0B38
	}

	public class SRPProfilerService : SRServiceBase<IProfilerService>, IProfilerService // TypeDefIndex: 56828
	{
		// Fields
		private const int FrameBufferSize = 400; // Metadata: 0x01FD8277
		private readonly CircularBuffer<ProfilerFrame> _frameBuffer; // 0x50
		private ProfilerLateUpdateListener _lateUpdateListener; // 0x58
		private double _updateDuration; // 0x60
		private double _renderStartTime; // 0x68
		private double _renderDuration; // 0x70
		private readonly Stopwatch _stopwatch; // 0x78
	
		// Properties
		public float AverageFrameTime { get; private set; } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public float LastFrameTime { get; private set; } // 0x0000000183D50200-0x0000000183D50210 0x0000000183D5E680-0x0000000183D5E690
		public CircularBuffer<ProfilerFrame> FrameBuffer { get => default; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
	
		// Constructors
		public SRPProfilerService() {} // 0x0000000183C92F70-0x0000000183C93030
	
		// Methods
		protected override void Awake() {} // 0x000000018268DBE0-0x000000018268DDD0
		protected override void Update() {} // 0x000000018233A400-0x000000018233A940
		[IteratorStateMachine(typeof(_EndOfFrameCoroutine_d__19))]
		private IEnumerator EndOfFrameCoroutine() => default; // 0x000000018268DDD0-0x000000018268DE30
		protected void PushFrame(double totalTime, double updateTime, double renderTime) {} // 0x000000018233AD50-0x000000018233AE10
		private void OnLateUpdate() {} // 0x000000018233ABC0-0x000000018233AC40
		private void RenderPipelineOnBeginFrameRendering(ScriptableRenderContext context, List<Camera> cameras) {} // 0x000000018233AEA0-0x000000018233B2C0
		private void EndFrame() {} // 0x000000018233A9E0-0x000000018233ABC0
	}
}

namespace SRDebugger.Scripts
{
	public class DebuggerTabController : SRMonoBehaviourEx // TypeDefIndex: 56721
	{
		// Fields
		private SRTab _aboutTabInstance; // 0x48
		private DefaultTabs? _activeTab; // 0x50
		private bool _hasStarted; // 0x58
		public SRTab AboutTab; // 0x60
		[RequiredField]
		public SRTabController TabController; // 0x68
	
		// Properties
		public DefaultTabs? ActiveTab { get => default; } // 0x00000001896AF248-0x00000001896AF36C 
	
		// Constructors
		public DebuggerTabController() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896AEE6C-0x00000001896AF248
		public bool OpenTab(DefaultTabs tab) => default; // 0x00000001896AEC08-0x00000001896AEDFC
		public void ShowAboutTab() {} // 0x00000001896AEDFC-0x00000001896AEE6C
	}
}

namespace SRDebugger.Services
{
	public sealed class ConsoleFilterStateService // TypeDefIndex: 56783
	{
		// Fields
		private bool[] _states; // 0x18
	
		// Events
		public event ConsoleStateChangedEventHandler FilterStateChange;
	
		// Constructors
		public ConsoleFilterStateService() {} // 0x00000001896AC33C-0x00000001896AC424
	
		// Methods
		public void SetState(UnityEngine.LogType type, bool newState) {} // 0x00000001896AC2CC-0x00000001896AC33C
		public bool GetState(UnityEngine.LogType type) => default; // 0x00000001896AC250-0x00000001896AC28C
		private static UnityEngine.LogType GetType(UnityEngine.LogType type) => default; // 0x00000001896AC28C-0x00000001896AC2CC
	}

	public delegate void BugReportCompleteCallback(bool didSucceed, string errorMessage); // TypeDefIndex: 56784; 0x0000000182065C10-0x0000000182065C20

	public delegate void BugReportProgressCallback(float progress); // TypeDefIndex: 56785; 0x0000000182149960-0x0000000182149970

	public interface IBugReportService // TypeDefIndex: 56786
	{
		// Properties
		bool IsUsable { get; }
	
		// Methods
		void SetHandler(IBugReporterHandler handler);
		void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, IProgress<float> progressCallback = null);
	}

	public delegate void ConsoleStateChangedEventHandler(UnityEngine.LogType logType, bool newState); // TypeDefIndex: 56787; 0x0000000182065C10-0x0000000182065C20

	public interface IConsoleFilterState // TypeDefIndex: 56788
	{
		// Events
		event ConsoleStateChangedEventHandler FilterStateChange;
	
		// Methods
		void SetConsoleFilterState(UnityEngine.LogType logType, bool enabled);
		bool GetConsoleFilterState(UnityEngine.LogType logType);
	}

	public delegate void ConsoleUpdatedEventHandler(IConsoleService console); // TypeDefIndex: 56789; 0x0000000182149960-0x0000000182149970

	public interface IConsoleService // TypeDefIndex: 56790
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
		event ConsoleUpdatedEventHandler Updated;
		event ConsoleUpdatedEventHandler Error;
	
		// Methods
		void Clear();
	}

	public class ConsoleEntry // TypeDefIndex: 56791
	{
		// Fields
		private const int MessagePreviewLength = 180; // Metadata: 0x01FD8244
		private const int StackTracePreviewLength = 120; // Metadata: 0x01FD8246
		private string _messagePreview; // 0x10
		private string _stackTracePreview; // 0x18
		public int Count; // 0x20
		public UnityEngine.LogType LogType; // 0x24
		public string Message; // 0x28
		public string StackTrace; // 0x30
	
		// Properties
		public string MessagePreview { get => default; } // 0x00000001896AC0D8-0x00000001896AC194 
		public string StackTracePreview { get => default; } // 0x00000001896AC194-0x00000001896AC250 
	
		// Constructors
		public ConsoleEntry() {} // 0x0000000183D58950-0x0000000183D58960
		public ConsoleEntry(ConsoleEntry other) {} // 0x00000001896AC084-0x00000001896AC0D8
	
		// Methods
		public bool Matches(ConsoleEntry other) => default; // 0x00000001896AC024-0x00000001896AC084
	}

	public interface IDebugCameraService // TypeDefIndex: 56792
	{
		// Properties
		Camera Camera { get; }
	}

	public interface IDebugPanelService // TypeDefIndex: 56793
	{
		// Properties
		bool IsLoaded { get; }
		bool IsVisible { get; set; }
		DefaultTabs? ActiveTab { get; }
	
		// Events
		event Action<IDebugPanelService, bool> VisibilityChanged;
	
		// Methods
		void Unload();
		void OpenTab(DefaultTabs tab);
	}

	public interface IDebugService // TypeDefIndex: 56794
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
		event VisibilityChangedDelegate PanelVisibilityChanged;
		event PinnedUiCanvasCreated PinnedUiCanvasCreated;
	
		// Methods
		void AddSystemInfo(SRDebugger.InfoEntry entry, string category = "Default" /* Metadata: 0x01FD8248 */);
		void ShowDebugPanel(bool requireEntryCode = true /* Metadata: 0x01FD8250 */);
		void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = true /* Metadata: 0x01FD8251 */);
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
		void ShowBugReportSheet(ActionCompleteCallback onComplete = null, bool takeScreenshot = true /* Metadata: 0x01FD8252 */, string descriptionContent = null);
		RectTransform EnableWorldSpaceMode();
		void SetBugReporterHandler(IBugReporterHandler bugReporterHandler);
	}

	public interface IDebugTriggerService // TypeDefIndex: 56795
	{
		// Properties
		bool IsEnabled { get; set; }
		bool ShowErrorNotification { get; set; }
		PinAlignment Position { get; set; }
	}

	public interface IDockConsoleService // TypeDefIndex: 56796
	{
		// Properties
		bool IsVisible { get; set; }
		bool IsExpanded { get; set; }
		ConsoleAlignment Alignment { get; set; }
	}

	public interface IOptionsService // TypeDefIndex: 56797
	{
		// Properties
		ICollection<OptionDefinition> Options { get; }
	
		// Events
		event System.EventHandler OptionsUpdated;
	
		// Methods
		[Obsolete("Use IOptionsService.AddContainer instead.")]
		void Scan(object obj);
		void AddContainer(object obj);
		void AddContainer(IOptionContainer optionContainer);
		void RemoveContainer(object obj);
		void RemoveContainer(IOptionContainer optionContainer);
	}

	public delegate void PinEntryCompleteCallback(bool validPinEntered); // TypeDefIndex: 56798; 0x0000000182149960-0x0000000182149970

	public interface IPinEntryService // TypeDefIndex: 56799
	{
		// Properties
		bool IsShowingKeypad { get; }
	
		// Methods
		void ShowPinEntry(IReadOnlyList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true /* Metadata: 0x01FD8253 */);
	}

	public interface IPinnedUIService // TypeDefIndex: 56800
	{
		// Properties
		bool IsProfilerPinned { get; set; }
	
		// Events
		event Action<OptionDefinition, bool> OptionPinStateChanged;
		event Action<RectTransform> OptionsCanvasCreated;
	
		// Methods
		void Pin(OptionDefinition option, int order = -1 /* Metadata: 0x01FD8254 */);
		void Unpin(OptionDefinition option);
		void UnpinAll();
		bool HasPinned(OptionDefinition option);
	}

	public static class ProfilerServiceSelector // TypeDefIndex: 56801
	{
		// Methods
		[ServiceSelector(typeof(IProfilerService))]
		public static System.Type GetProfilerServiceType() => default; // 0x0000000182EAA550-0x0000000182EAA600
	}

	public struct ProfilerFrame // TypeDefIndex: 56802
	{
		// Fields
		public double FrameTime; // 0x00
		public double OtherTime; // 0x08
		public double RenderTime; // 0x10
		public double UpdateTime; // 0x18
	}

	public interface IProfilerService // TypeDefIndex: 56803
	{
		// Properties
		float AverageFrameTime { get; }
		float LastFrameTime { get; }
		CircularBuffer<ProfilerFrame> FrameBuffer { get; }
	}

	public interface ISystemInformationService // TypeDefIndex: 56804
	{
		// Methods
		IEnumerable<string> GetCategories();
		IList<SRDebugger.InfoEntry> GetInfo(string category);
		void Add(SRDebugger.InfoEntry info, string category = "Default" /* Metadata: 0x01FD8255 */);
		Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false /* Metadata: 0x01FD825D */);
	}
}

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IBugReportService))]
	internal class BugReportApiService : IBugReportService // TypeDefIndex: 56806
	{
		// Fields
		private IBugReporterHandler _handler; // 0x10
	
		// Properties
		public bool IsUsable { get => default; } // 0x00000001896AA328-0x00000001896AA340 
	
		// Constructors
		public BugReportApiService() {} // 0x00000001896AA2D8-0x00000001896AA328
	
		// Methods
		public void SetHandler(IBugReporterHandler handler) {} // 0x00000001896AA21C-0x00000001896AA2D8
		public void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, IProgress<float> progress = null) {} // 0x00000001896A9F38-0x00000001896AA21C
	}

	[Service(typeof(BugReportPopoverService))]
	public class BugReportPopoverService : SRServiceBase<BugReportPopoverService> // TypeDefIndex: 56808
	{
		// Fields
		private BugReportCompleteCallback _callback; // 0x48
		private bool _isVisible; // 0x50
		private BugReportPopoverRoot _popover; // 0x58
		private BugReportSheetController _sheet; // 0x60
	
		// Properties
		public bool IsShowingPopover { get => default; } // 0x0000000183D4F000-0x0000000183D4F010 
	
		// Constructors
		public BugReportPopoverService() {} // 0x00000001896AAD94-0x00000001896AADC8
	
		// Methods
		public void ShowBugReporter(BugReportCompleteCallback callback, bool takeScreenshotFirst = true /* Metadata: 0x01FD825E */, string descriptionText = null) {} // 0x00000001896AAB60-0x00000001896AACF8
		[IteratorStateMachine(typeof(_OpenCo_d__7))]
		private IEnumerator OpenCo(bool takeScreenshot, string descriptionText) => default; // 0x00000001896AAA58-0x00000001896AAADC
		private void SubmitComplete(bool didSucceed, string errorMessage) {} // 0x00000001896AACF8-0x00000001896AAD14
		private void CancelPressed() {} // 0x00000001896AA51C-0x00000001896AA564
		private void OnComplete(bool success, string errorMessage, bool close) {} // 0x00000001896AA8F4-0x00000001896AAA58
		private void TakingScreenshot() {} // 0x00000001896AAD14-0x00000001896AAD94
		private void ScreenshotComplete() {} // 0x00000001896AAADC-0x00000001896AAB60
		protected override void Awake() {} // 0x00000001896AA488-0x00000001896AA51C
		private void Load() {} // 0x00000001896AA564-0x00000001896AA8F4
	}

	[Service(typeof(IDebugCameraService))]
	public class DebugCameraServiceImpl : IDebugCameraService // TypeDefIndex: 56809
	{
		// Fields
		private Camera _debugCamera; // 0x10
	
		// Properties
		public Camera Camera { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public DebugCameraServiceImpl() {} // 0x00000001896BB8A4-0x00000001896BBA20
	}

	[Service(typeof(IDebugPanelService))]
	public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService, IDisposable // TypeDefIndex: 56810
	{
		// Fields
		private DebugPanelRoot _debugPanelRootObject; // 0x18
		private bool _isVisible; // 0x28
		private bool? _cursorWasVisible; // 0x29
		private CursorLockMode? _cursorLockMode; // 0x2C
	
		// Properties
		public DebugPanelRoot RootObject { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public bool IsLoaded { get => default; } // 0x00000001896BBDBC-0x00000001896BBE0C 
		public bool IsVisible { get => default; set {} } // 0x00000001896BBE0C-0x00000001896BBE2C 0x00000001896BBEB8-0x00000001896BC1C8
		public DefaultTabs? ActiveTab { get => default; } // 0x00000001896BBD44-0x00000001896BBDBC 
	
		// Events
		public event Action<IDebugPanelService, bool> VisibilityChanged;
	
		// Constructors
		public DebugPanelServiceImpl() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public void OpenTab(DefaultTabs tab) {} // 0x00000001896BBC2C-0x00000001896BBC80
		public void Unload() {} // 0x00000001896BBC80-0x00000001896BBD44
		private void Load() {} // 0x00000001896BBAA4-0x00000001896BBC2C
		public void Dispose() {} // 0x00000001896BBA20-0x00000001896BBAA4
	}

	[Service(typeof(IDebugTriggerService))]
	public class DebugTriggerImpl : SRServiceBase<IDebugTriggerService>, IDebugTriggerService // TypeDefIndex: 56811
	{
		// Fields
		private PinAlignment _position; // 0x48
		private TriggerRoot _trigger; // 0x50
		private IConsoleService _consoleService; // 0x58
		private bool _showErrorNotification; // 0x60
	
		// Properties
		public bool IsEnabled { get => default; set {} } // 0x00000001896BC8D8-0x00000001896BC954 0x00000001826CCB80-0x00000001826CCC00
		public bool ShowErrorNotification { get => default; set {} } // 0x0000000183D519A0-0x0000000183D519B0 0x0000000183CB4A10-0x0000000183CB4AB0
		public PinAlignment Position { get => default; set {} } // 0x0000000183D4EC50-0x0000000183D4EC60 0x00000001826CCC00-0x00000001826CCC80
	
		// Constructors
		public DebugTriggerImpl() {} // 0x0000000183D416A0-0x0000000183D416E0
	
		// Methods
		protected override void Awake() {} // 0x000000018268DA20-0x000000018268DB40
		private void OnError(IConsoleService console) {} // 0x00000001896BC6F4-0x00000001896BC768
		private void CreateTrigger() {} // 0x00000001896BC1C8-0x00000001896BC5DC
		protected override void OnDestroy() {} // 0x00000001896BC5E4-0x00000001896BC6F4
		private static void OnActiveSceneChanged(Scene s1, Scene s2) {} // 0x00000001896BC5DC-0x00000001896BC5E4
		private void OnTriggerButtonClick() {} // 0x00000001896BC768-0x00000001896BC7F8
		private static void SetTriggerPosition(RectTransform t, PinAlignment position) {} // 0x00000001896BC7F8-0x00000001896BC8D8
	}

	[Service(typeof(IDockConsoleService))]
	public class DockConsoleServiceImpl : IDockConsoleService // TypeDefIndex: 56812
	{
		// Fields
		private ConsoleAlignment _alignment; // 0x10
		private DockConsoleController _consoleRoot; // 0x18
		private bool _didSuspendTrigger; // 0x20
		private bool _isExpanded; // 0x21
		private bool _isVisible; // 0x22
	
		// Properties
		public bool IsVisible { get => default; set {} } // 0x0000000183D4F740-0x0000000183D4F750 0x00000001896BCD4C-0x00000001896BCDF8
		public bool IsExpanded { get => default; set {} } // 0x0000000183D4F070-0x0000000183D4F080 0x00000001896BCCAC-0x00000001896BCD4C
		public ConsoleAlignment Alignment { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001896BCC24-0x00000001896BCCAC
	
		// Constructors
		public DockConsoleServiceImpl() {} // 0x00000001896BCBF4-0x00000001896BCC24
	
		// Methods
		private void Load() {} // 0x00000001896BCA8C-0x00000001896BCBF4
		private void CheckTrigger() {} // 0x00000001896BC954-0x00000001896BCA8C
	}

	[Service(typeof(KeyboardShortcutListenerService))]
	public class KeyboardShortcutListenerService : SRServiceBase<KeyboardShortcutListenerService> // TypeDefIndex: 56813
	{
		// Fields
		private List<SRDebugger.Settings.KeyboardShortcut> _shortcuts; // 0x48
	
		// Constructors
		public KeyboardShortcutListenerService() {} // 0x00000001896BDB6C-0x00000001896BDBA0
	
		// Methods
		protected override void Awake() {} // 0x00000001896BCE8C-0x00000001896BD2EC
		private void ToggleTab(DefaultTabs t) {} // 0x00000001896BD5D0-0x00000001896BD6F0
		private void ExecuteShortcut(SRDebugger.Settings.KeyboardShortcut shortcut) {} // 0x00000001896BD2EC-0x00000001896BD5D0
		protected override void Update() {} // 0x00000001896BDB24-0x00000001896BDB6C
		private void UpdateInputSystem() {} // 0x00000001896BD6F0-0x00000001896BD97C
		private void UpdateLegacyInputSystem() {} // 0x00000001896BD97C-0x00000001896BDB24
	}

	[Service(typeof(IOptionsService))]
	public sealed class OptionsServiceImpl : IOptionsService // TypeDefIndex: 56816
	{
		// Fields
		private readonly Dictionary<IOptionContainer, List<OptionDefinition>> _optionContainerLookup; // 0x18
		private readonly Dictionary<IOptionContainer, OptionContainerEventHandler> _optionContainerEventHandlerLookup; // 0x20
		private readonly List<OptionDefinition> _options; // 0x28
		private readonly IList<OptionDefinition> _optionsReadonly; // 0x30
	
		// Properties
		public ICollection<OptionDefinition> Options { get => default; } // 0x0000000181003830-0x0000000181003840 
	
		// Events
		public event System.EventHandler OptionsUpdated;
	
		// Nested types
		private class OptionContainerEventHandler : IDisposable // TypeDefIndex: 56814
		{
			// Fields
			private readonly OptionsServiceImpl _service; // 0x10
			private readonly IOptionContainer _container; // 0x18
	
			// Constructors
			public OptionContainerEventHandler() {} // Dummy constructor
			public OptionContainerEventHandler(OptionsServiceImpl service, IOptionContainer container) {} // 0x00000001896BDD64-0x00000001896BDEE4
	
			// Methods
			private void ContainerOnOptionAdded(OptionDefinition obj) {} // 0x00000001896BDBA0-0x00000001896BDBCC
			private void ContainerOnOptionRemoved(OptionDefinition obj) {} // 0x00000001896BDBCC-0x00000001896BDBF8
			public void Dispose() {} // 0x00000001896BDBF8-0x00000001896BDD64
		}
	
		private class ReflectionOptionContainer : IOptionContainer // TypeDefIndex: 56815
		{
			// Fields
			private List<OptionDefinition> _options; // 0x10
			private readonly object _target; // 0x18
	
			// Properties
			public bool IsDynamic { get => default; } // 0x000000018115F4C0-0x000000018115F530 
			private List<OptionDefinition> Options { get => default; } // 0x0000000183D3CD20-0x0000000183D3CD60 
	
			// Events
			public event Action<OptionDefinition> OptionAdded;
			public event Action<OptionDefinition> OptionRemoved;
	
			// Constructors
			public ReflectionOptionContainer() {} // Dummy constructor
			public ReflectionOptionContainer(object target) {} // 0x00000001822C3A90-0x00000001822C3AA0
	
			// Methods
			public IEnumerable<OptionDefinition> GetOptions() => default; // 0x0000000184276BB8-0x0000000184276BC0
			protected bool Equals(ReflectionOptionContainer other) => default; // 0x00000001896C102C-0x00000001896C1054
			public override bool Equals(object obj) => default; // 0x00000001896C0F78-0x00000001896C102C
			public override int GetHashCode() => default; // 0x0000000183D4A220-0x0000000183D4A250
		}
	
		// Constructors
		public OptionsServiceImpl() {} // 0x000000018386F070-0x000000018386F1E0
	
		// Methods
		private void OptionsContainerOnOptionAdded(IOptionContainer container, OptionDefinition optionDefinition) {} // 0x00000001896BEA48-0x00000001896BEB8C
		private void OptionsContainerOnOptionRemoved(IOptionContainer container, OptionDefinition optionDefinition) {} // 0x00000001896BEB8C-0x00000001896BECA4
		public void Scan(object obj) {} // 0x00000001896BEFCC-0x00000001896BEFD4
		public void AddContainer(object obj) {} // 0x000000018386EFE0-0x000000018386F070
		public void AddContainer(IOptionContainer optionContainer) {} // 0x000000018386F1E0-0x000000018386F390
		public void RemoveContainer(object obj) {} // 0x00000001896BECA4-0x00000001896BED40
		public void RemoveContainer(IOptionContainer optionContainer) {} // 0x00000001896BED40-0x00000001896BEFCC
		private void OnOptionsUpdated() {} // 0x00000001896BE9DC-0x00000001896BEA48
	}

	[Service(typeof(IPinEntryService))]
	public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService // TypeDefIndex: 56817
	{
		// Fields
		private PinEntryCompleteCallback _callback; // 0x48
		private bool _isVisible; // 0x50
		private PinEntryControl _pinControl; // 0x58
		private readonly List<int> _requiredPin; // 0x60
	
		// Properties
		public bool IsShowingKeypad { get => default; } // 0x0000000183D4F000-0x0000000183D4F010 
	
		// Constructors
		public PinEntryServiceImpl() {} // 0x00000001896BF75C-0x00000001896BF7EC
	
		// Methods
		public void ShowPinEntry(IReadOnlyList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true /* Metadata: 0x01FD825F */) {} // 0x00000001896BF3E0-0x00000001896BF600
		protected override void Awake() {} // 0x00000001896BF0FC-0x00000001896BF190
		private void Load() {} // 0x00000001896BF190-0x00000001896BF31C
		private void PinControlOnComplete(IList<int> result, bool didCancel) {} // 0x00000001896BF31C-0x00000001896BF3E0
		private void VerifyPin(IReadOnlyList<int> pin) {} // 0x00000001896BF600-0x00000001896BF75C
	}

	[Service(typeof(IPinnedUIService))]
	public class PinnedUIServiceImpl : SRServiceBase<IPinnedUIService>, IPinnedUIService // TypeDefIndex: 56818
	{
		// Fields
		private readonly List<OptionsControlBase> _controlList; // 0x48
		private readonly Dictionary<OptionDefinition, OptionsControlBase> _pinnedObjects; // 0x50
		private bool _queueRefresh; // 0x58
		private PinnedUIRoot _uiRoot; // 0x60
	
		// Properties
		public DockConsoleController DockConsoleController { get => default; } // 0x00000001896C04E8-0x00000001896C055C 
		public bool IsProfilerPinned { get => default; set {} } // 0x00000001896C055C-0x00000001896C05D4 0x00000001896C06EC-0x00000001896C077C
	
		// Events
		public event Action<OptionDefinition, bool> OptionPinStateChanged;
		public event Action<RectTransform> OptionsCanvasCreated;
	
		// Constructors
		public PinnedUIServiceImpl() {} // 0x0000000183C813B0-0x0000000183C81490
	
		// Methods
		public void Pin(OptionDefinition obj, int order = -1 /* Metadata: 0x01FD8260 */) {} // 0x00000001896BFC98-0x00000001896BFE28
		public void Unpin(OptionDefinition obj) {} // 0x00000001896C0060-0x00000001896C0184
		private void OnPinnedStateChanged(OptionDefinition option, bool isPinned) {} // 0x00000001896BFC84-0x00000001896BFC98
		public void UnpinAll() {} // 0x00000001896BFEA8-0x00000001896C0060
		public bool HasPinned(OptionDefinition option) => default; // 0x00000001896BF7EC-0x00000001896BF840
		protected override void Awake() {} // 0x000000018268DB40-0x000000018268DBE0
		private void Load() {} // 0x00000001896BF840-0x00000001896BFAD0
		private void UpdateAnchors() {} // 0x00000001896C0184-0x00000001896C045C
		protected override void Update() {} // 0x0000000183336BB0-0x0000000183336BD0
		private void OnOptionsUpdated(object sender, EventArgs eventArgs) {} // 0x00000001896BFADC-0x00000001896BFC84
		private void OnDebugPanelVisibilityChanged(bool isVisible) {} // 0x00000001896BFAD0-0x00000001896BFADC
		private void Refresh() {} // 0x00000001896BFE28-0x00000001896BFEA8
	}

	[Service(typeof(IDebugService))]
	public class SRDebugService : IDebugService // TypeDefIndex: 56820
	{
		// Fields
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
		public IDockConsoleService DockConsole { get => default; } // 0x00000001896C2CA8-0x00000001896C2CB0 
		public IConsoleFilterState ConsoleFilter { get => default; } // 0x00000001896C2C40-0x00000001896C2CA8 
		public SRDebugger.Settings Settings { get => default; } // 0x00000001842713D4-0x00000001842713DC 
		public bool IsDebugPanelVisible { get => default; } // 0x00000001896C2CB0-0x00000001896C2CCC 
		public bool IsTriggerEnabled { get => default; set {} } // 0x00000001896C2D40-0x00000001896C2D5C 0x00000001896C2F68-0x00000001896C2F84
		public bool IsTriggerErrorNotificationEnabled { get => default; set {} } // 0x00000001896C2D5C-0x00000001896C2DBC 0x00000001896C2F84-0x00000001896C3000
		public bool IsProfilerDocked { get => default; set {} } // 0x00000001896C2CCC-0x00000001896C2D40 0x00000001896C2EE4-0x00000001896C2F68
	
		// Events
		public event VisibilityChangedDelegate PanelVisibilityChanged;
		public event PinnedUiCanvasCreated PinnedUiCanvasCreated;
	
		// Constructors
		public SRDebugService() {} // 0x00000001826CD3E0-0x00000001826CD890
	
		// Methods
		public void AddSystemInfo(SRDebugger.InfoEntry entry, string category = "Default" /* Metadata: 0x01FD8261 */) {} // 0x00000001896C1988-0x00000001896C1A0C
		public void ShowDebugPanel(bool requireEntryCode = true /* Metadata: 0x01FD8269 */) {} // 0x00000001896C2668-0x00000001896C26D4
		public void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = true /* Metadata: 0x01FD826A */) {} // 0x00000001896C2574-0x00000001896C2668
		public void HideDebugPanel() {} // 0x00000001896C1DF4-0x00000001896C1E14
		public void SetEntryCode(EntryCode newCode) {} // 0x00000001896C23F4-0x00000001896C2458
		public void DisableEntryCode() {} // 0x0000000183D751B0-0x0000000183D751C0
		public void DestroyDebugPanel() {} // 0x00000001896C1B48-0x00000001896C1BC8
		public void AddOptionContainer(object container) {} // 0x00000001896C1810-0x00000001896C188C
		public void RemoveOptionContainer(object container) {} // 0x00000001896C22A8-0x00000001896C2324
		public void AddOption(OptionDefinition option) {} // 0x00000001896C188C-0x00000001896C1988
		public bool RemoveOption(OptionDefinition option) => default; // 0x00000001896C2324-0x00000001896C233C
		public void PinAllOptions(string category) {} // 0x00000001896C1E14-0x00000001896C1F88
		public void UnpinAllOptions(string category) {} // 0x00000001896C2830-0x00000001896C29A4
		public void PinOption(string name) {} // 0x00000001896C1F88-0x00000001896C20FC
		public void UnpinOption(string name) {} // 0x00000001896C29A4-0x00000001896C2B18
		public void ClearPinnedOptions() {} // 0x00000001896C1A0C-0x00000001896C1A78
		public void ShowBugReportSheet(ActionCompleteCallback onComplete = null, bool takeScreenshot = true /* Metadata: 0x01FD826B */, string descriptionContent = null) {} // 0x00000001896C2458-0x00000001896C2574
		private void DebugPanelServiceOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) {} // 0x00000001896C1A78-0x00000001896C1B48
		private void PromptEntryCode() {} // 0x00000001896C20FC-0x00000001896C22A8
		public RectTransform EnableWorldSpaceMode() => default; // 0x00000001896C1BC8-0x00000001896C1DF4
		public void SetBugReporterHandler(IBugReporterHandler bugReporterHandler) {} // 0x00000001896C233C-0x00000001896C23F4
	}

	[Service(typeof(IConsoleService))]
	public class StandardConsoleService : IConsoleService, IDisposable // TypeDefIndex: 56821
	{
		// Fields
		private readonly bool _collapseEnabled; // 0x10
		private bool _hasCleared; // 0x11
		private readonly CircularBuffer<ConsoleEntry> _allConsoleEntries; // 0x18
		private CircularBuffer<ConsoleEntry> _consoleEntries; // 0x20
		private readonly object _threadLock; // 0x28
		private ILogHandler _expectedLogHandler; // 0x30
	
		// Properties
		public int CriticalCount { get; private set; } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public int ErrorCount { get; private set; } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x0000000183D4EDC0-0x0000000183D4EDD0
		public int WarningCount { get; private set; } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
		public int InfoCount { get; private set; } // 0x0000000183D4EE80-0x0000000183D4EE90 0x0000000183D4EEA0-0x0000000183D4EEB0
		public bool LoggingEnabled { get => default; set {} } // 0x00000001896C4128-0x00000001896C417C 0x00000001896C42A4-0x00000001896C4340
		public bool LogHandlerIsOverriden { get => default; } // 0x00000001896C40D0-0x00000001896C4128 
		public IReadOnlyList<ConsoleEntry> Entries { get => default; } // 0x00000001896C40C0-0x00000001896C40D0 
		public IReadOnlyList<ConsoleEntry> AllEntries { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Events
		public event ConsoleUpdatedEventHandler Updated;
		public event ConsoleUpdatedEventHandler Error;
	
		// Constructors
		public StandardConsoleService() {} // 0x000000018267B700-0x000000018267B8C0
	
		// Methods
		public void Dispose() {} // 0x00000001896C3C2C-0x00000001896C3CE0
		public void Clear() {} // 0x00000001896C3A6C-0x00000001896C3C2C
		protected void OnEntryAdded(ConsoleEntry entry) {} // 0x00000001896C3CE0-0x00000001896C3E50
		protected void OnEntryDuplicated(ConsoleEntry entry) {} // 0x00000001896C3E50-0x00000001896C3F04
		private void OnUpdated() {} // 0x00000001896C3F04-0x00000001896C3F98
		private void UnityLogCallback(string condition, string stackTrace, UnityEngine.LogType type) {} // 0x000000018350B670-0x000000018350B680
		private void AdjustCounter(UnityEngine.LogType type, int amount) {} // 0x00000001896C39F4-0x00000001896C3A6C
	}

	[Service(typeof(ISystemInformationService))]
	public class StandardSystemInformationService : ISystemInformationService // TypeDefIndex: 56824
	{
		// Fields
		private readonly Dictionary<string, IList<SRDebugger.InfoEntry>> _info; // 0x10
	
		// Constructors
		public StandardSystemInformationService() {} // 0x0000000183CF21E0-0x0000000183CF2260
	
		// Methods
		public IEnumerable<string> GetCategories() => default; // 0x00000001896C4954-0x00000001896C499C
		public IList<SRDebugger.InfoEntry> GetInfo(string category) => default; // 0x00000001896C4AF0-0x00000001896C4BFC
		public void Add(SRDebugger.InfoEntry info, string category = "Default" /* Metadata: 0x01FD826C */) {} // 0x00000001896C4340-0x00000001896C454C
		public Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false /* Metadata: 0x01FD8274 */) => default; // 0x00000001896C454C-0x00000001896C4954
		private void CreateDefaultSet() {} // 0x000000018315D380-0x00000001831619D0
		private static string GetCloudManifestPrettyName(string name) => default; // 0x00000001896C499C-0x00000001896C4AF0
	}
}

namespace SRDebugger.UI
{
	public class ProfilerFPSLabel : SRMonoBehaviourEx // TypeDefIndex: 56722
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
		public ProfilerFPSLabel() {} // 0x00000001896B6ACC-0x00000001896B6ADC
	
		// Methods
		protected override void Update() {} // 0x00000001896B6AA0-0x00000001896B6ACC
		private void Refresh() {} // 0x00000001896B6994-0x00000001896B6AA0
	}

	public class DebugPanelRoot : SRMonoBehaviourEx // TypeDefIndex: 56723
	{
		// Fields
		[RequiredField]
		public Canvas Canvas; // 0x48
		[RequiredField]
		public CanvasGroup CanvasGroup; // 0x50
		[RequiredField]
		public DebuggerTabController TabController; // 0x58
	
		// Constructors
		public DebugPanelRoot() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void Close() {} // 0x00000001896AEB74-0x00000001896AEC08
		public void CloseAndDestroy() {} // 0x00000001896AEB18-0x00000001896AEB74
	}

	public class MobileMenuController : SRMonoBehaviourEx // TypeDefIndex: 56724
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
		public float PeekAmount { get => default; } // 0x0000000183D4F670-0x0000000183D4F680 
		public float MaxMenuWidth { get => default; } // 0x0000000183D51C90-0x0000000183D51CA0 
	
		// Constructors
		public MobileMenuController() {} // 0x00000001896B2700-0x00000001896B2718
	
		// Methods
		protected override void OnEnable() {} // 0x00000001896B2288-0x00000001896B2504
		protected override void OnDisable() {} // 0x00000001896B2150-0x00000001896B2288
		private void CreateCloseButton() {} // 0x00000001896B1D9C-0x00000001896B2150
		private void SetRectSize(RectTransform rect) {} // 0x00000001896B255C-0x00000001896B2610
		private void CloseButtonClicked() {} // 0x00000001896B1D5C-0x00000001896B1D64
		protected override void Update() {} // 0x00000001896B2610-0x00000001896B2700
		private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab) {} // 0x00000001896B1D5C-0x00000001896B1D64
		[ContextMenu("Open")]
		public void Open() {} // 0x00000001896B2504-0x00000001896B255C
		[ContextMenu("Close")]
		public void Close() {} // 0x00000001896B1D64-0x00000001896B1D9C
	}
}

namespace SRDebugger.UI.Controls
{
	[RequireComponent(typeof(RectTransform))]
	public class ConsoleEntryView : SRMonoBehaviourEx, SRF.UI.Layout.IVirtualView // TypeDefIndex: 56758
	{
		// Fields
		public const string ConsoleBlobInfo = "Console_Info_Blob"; // Metadata: 0x01FD81E5
		public const string ConsoleBlobWarning = "Console_Warning_Blob"; // Metadata: 0x01FD81F7
		public const string ConsoleBlobError = "Console_Error_Blob"; // Metadata: 0x01FD820C
		public const string ConsoleBlobCritical = "Console_Critical_Blob"; // Metadata: 0x01FD821F
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
		public ConsoleEntryView() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void SetDataContext(object data) {} // 0x00000001896ABCE8-0x00000001896AC024
		protected override void Awake() {} // 0x00000001896ABC44-0x00000001896ABCE8
	}

	public class ConsoleLogControl : SRMonoBehaviourEx // TypeDefIndex: 56760
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
		public bool ShowCriticals { get => default; set {} } // 0x0000000183D4F3F0-0x0000000183D4F400 0x0000000183D75140-0x0000000183D75150
		public bool ShowErrors { get => default; set {} } // 0x0000000183D4F3C0-0x0000000183D4F3D0 0x0000000183D75150-0x0000000183D75160
		public bool ShowWarnings { get => default; set {} } // 0x0000000183D75130-0x0000000183D75140 0x0000000183D75170-0x0000000183D75180
		public bool ShowInfo { get => default; set {} } // 0x0000000183D75120-0x0000000183D75130 0x0000000183D75160-0x0000000183D75170
		public bool EnableSelection { get => default; set {} } // 0x00000001896ACC78-0x00000001896ACC98 0x00000001896ACC98-0x00000001896ACCB8
		public string Filter { get => default; set {} } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001896ACCB8-0x00000001896ACCF4
	
		// Constructors
		public ConsoleLogControl() {} // 0x00000001896ACC68-0x00000001896ACC78
	
		// Methods
		protected override void Awake() {} // 0x00000001896AC75C-0x00000001896AC874
		protected override void Start() {} // 0x00000001896ACBB4-0x00000001896ACBDC
		[IteratorStateMachine(typeof(_ScrollToBottom_d__30))]
		private IEnumerator ScrollToBottom() => default; // 0x00000001896ACB58-0x00000001896ACBB4
		protected override void OnDestroy() {} // 0x00000001896AC874-0x00000001896AC914
		private void OnSelectedItemChanged(object arg0) {} // 0x00000001896AC914-0x00000001896AC970
		protected override void Update() {} // 0x00000001896ACBDC-0x00000001896ACC68
		private void Refresh() {} // 0x00000001896AC970-0x00000001896ACB58
		private void SetIsDirty() {} // 0x0000000183D72A60-0x0000000183D72A70
		private void ConsoleOnUpdated(IConsoleService console) {} // 0x0000000183D72A60-0x0000000183D72A70
	}

	public abstract class DataBoundControl : OptionsControlBase // TypeDefIndex: 56761
	{
		// Fields
		private bool _hasStarted; // 0x60
		private bool _isReadOnly; // 0x61
		private object _prevValue; // 0x68
		private PropertyReference _prop; // 0x70
	
		// Properties
		public PropertyReference Property { get; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		public bool IsReadOnly { get; } // 0x0000000183D51F90-0x0000000183D51FA0 
		public string PropertyName { get; private set; } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
	
		// Constructors
		protected DataBoundControl() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void Bind(string propertyName, PropertyReference prop) {} // 0x00000001896AE65C-0x00000001896AE754
		private void OnValueChanged(PropertyReference property) {} // 0x0000000188250BC4-0x0000000188250BD4
		protected void UpdateValue(object newValue) {} // 0x00000001896AE9BC-0x00000001896AEA08
		public override void Refresh() {} // 0x00000001896AE898-0x00000001896AE99C
		protected virtual void OnBind(string propertyName, System.Type t) {} // 0x000000018350B670-0x000000018350B680
		protected abstract void OnValueUpdated(object newValue);
		public abstract bool CanBind(System.Type type, bool isReadOnly);
		protected override void Start() {} // 0x00000001896AE99C-0x00000001896AE9BC
		protected override void OnEnable() {} // 0x00000001896AE7E8-0x00000001896AE898
		protected override void OnDisable() {} // 0x00000001896AE754-0x00000001896AE7E8
	}

	public abstract class OptionsControlBase : SRMonoBehaviourEx // TypeDefIndex: 56762
	{
		// Fields
		private bool _selectionModeEnabled; // 0x48
		[RequiredField]
		public Toggle SelectionModeToggle; // 0x50
		public OptionDefinition Option; // 0x58
	
		// Properties
		public bool SelectionModeEnabled { get; set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x00000001896B3A08-0x00000001896B3B04
		public bool IsSelected { get; set; } // 0x00000001896B3910-0x00000001896B3930 0x00000001896B3930-0x00000001896B3A08
	
		// Constructors
		protected OptionsControlBase() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Awake() {} // 0x00000001896B3800-0x00000001896B3850
		protected override void OnEnable() {} // 0x00000001896B3850-0x00000001896B3910
		public virtual void Refresh() {} // 0x000000018350B670-0x000000018350B680
	}

	public class InfoBlock : SRMonoBehaviourEx // TypeDefIndex: 56763
	{
		// Fields
		[RequiredField]
		public UnityEngine.UI.Text Content; // 0x48
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0x50
	
		// Constructors
		public InfoBlock() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public class MultiTapButton : UnityEngine.UI.Button // TypeDefIndex: 56764
	{
		// Fields
		private float _lastTap; // 0x188
		private int _tapCount; // 0x18C
		public int RequiredTapCount; // 0x190
		public float ResetTime; // 0x194
	
		// Constructors
		public MultiTapButton() {} // 0x00000001896B278C-0x00000001896B27A8
	
		// Methods
		public override void OnPointerClick(PointerEventData eventData) {} // 0x00000001896B2718-0x00000001896B278C
	}

	public delegate void PinEntryControlCallback(IList<int> result, bool didCancel); // TypeDefIndex: 56765; 0x0000000182065C10-0x0000000182065C20

	public class PinEntryControl : SRMonoBehaviourEx // TypeDefIndex: 56767
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
	
		// Events
		public event PinEntryControlCallback Complete;
	
		// Constructors
		public PinEntryControl() {} // 0x00000001896B6554-0x00000001896B65E0
	
		// Methods
		protected override void Awake() {} // 0x00000001896B5CCC-0x00000001896B5E6C
		protected override void OnEnable() {} // 0x00000001896B6190-0x00000001896B6224
		protected override void OnDisable() {} // 0x00000001896B60FC-0x00000001896B6190
		protected override void Update() {} // 0x00000001896B647C-0x00000001896B6554
		private void HandleCharacter(char i) {} // 0x00000001896B5F28-0x00000001896B5FA8
		public void Show() {} // 0x00000001896B641C-0x00000001896B647C
		public void Hide() {} // 0x00000001896B5FA8-0x00000001896B6004
		public void Clear() {} // 0x00000001896B5EDC-0x00000001896B5F28
		public void PlayInvalidCodeAnimation() {} // 0x00000001896B6224-0x00000001896B6270
		protected void OnComplete() {} // 0x00000001896B6060-0x00000001896B60FC
		protected void OnCancel() {} // 0x00000001896B6004-0x00000001896B6060
		private void CancelButtonPressed() {} // 0x00000001896B5E6C-0x00000001896B5EDC
		public void PushNumber(int number) {} // 0x00000001896B6270-0x00000001896B6330
		private void RefreshState() {} // 0x00000001896B6330-0x00000001896B641C
	}

	public class ProfilerMemoryBlock : SRMonoBehaviourEx // TypeDefIndex: 56769
	{
		// Fields
		private float _lastRefresh; // 0x48
		[RequiredField]
		public UnityEngine.UI.Text CurrentUsedText; // 0x50
		[RequiredField]
		public Slider Slider; // 0x58
		[RequiredField]
		public UnityEngine.UI.Text TotalAllocatedText; // 0x60
	
		// Constructors
		public ProfilerMemoryBlock() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnEnable() {} // 0x00000001896B8044-0x00000001896B804C
		protected override void Update() {} // 0x00000001896B8234-0x00000001896B82B4
		public void TriggerRefresh() {} // 0x00000001896B8070-0x00000001896B8234
		public void TriggerCleanup() {} // 0x00000001896B804C-0x00000001896B8070
		[IteratorStateMachine(typeof(_CleanUp_d__8))]
		private IEnumerator CleanUp() => default; // 0x00000001896B7FE8-0x00000001896B8044
	}

	public class ProfilerMonoBlock : SRMonoBehaviourEx // TypeDefIndex: 56770
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
		public ProfilerMonoBlock() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnEnable() {} // 0x00000001896B82B4-0x00000001896B831C
		protected override void Update() {} // 0x00000001896B8560-0x00000001896B85E0
		public void TriggerRefresh() {} // 0x00000001896B836C-0x00000001896B8560
		public void TriggerCollection() {} // 0x00000001896B831C-0x00000001896B836C
	}

	public class ProfilerEnableControl : SRMonoBehaviourEx // TypeDefIndex: 56771
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
		public ProfilerEnableControl() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896B6710-0x00000001896B680C
		protected void UpdateLabels() {} // 0x00000001896B6868-0x00000001896B6968
		protected override void Update() {} // 0x00000001896B6968-0x00000001896B6994
		public void ToggleProfiler() {} // 0x00000001896B680C-0x00000001896B6868
	}

	[RequireComponent(typeof(RectTransform))]
	public class ProfilerGraphAxisLabel : SRMonoBehaviourEx // TypeDefIndex: 56772
	{
		// Fields
		private float _prevFrameTime; // 0x48
		private float? _queuedFrameTime; // 0x4C
		private float _yPosition; // 0x54
		[RequiredField]
		public UnityEngine.UI.Text Text; // 0x58
	
		// Constructors
		public ProfilerGraphAxisLabel() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Update() {} // 0x00000001896B6D10-0x00000001896B6D74
		public void SetValue(float frameTime, float yPosition) {} // 0x00000001896B6C94-0x00000001896B6D10
		private void SetValueInternal(float frameTime) {} // 0x00000001896B6ADC-0x00000001896B6C94
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(CanvasRenderer))]
	public class ProfilerGraphControl : Graphic // TypeDefIndex: 56774
	{
		// Fields
		public VerticalAlignments VerticalAlignment; // 0xB0
		private static readonly float[] ScaleSteps; // 0x00
		public bool FloatingScale; // 0xB4
		public bool TargetFpsUseApplication; // 0xB5
		public bool DrawAxes; // 0xB6
		public int TargetFps; // 0xB8
		public bool Clip; // 0xBC
		public const float DataPointMargin = 2f; // Metadata: 0x01FD8235
		public const float DataPointVerticalMargin = 2f; // Metadata: 0x01FD8239
		public const float DataPointWidth = 4f; // Metadata: 0x01FD823D
		public int VerticalPadding; // 0xC0
		public const int LineCount = 3; // Metadata: 0x01FD8241
		public UnityEngine.Color[] LineColours; // 0xC8
		private IProfilerService _profilerService; // 0xD0
		private ProfilerGraphAxisLabel[] _axisLabels; // 0xD8
		private Rect _clipBounds; // 0xE0
		private readonly List<Vector3> _meshVertices; // 0xF0
		private readonly List<Color32> _meshVertexColors; // 0xF8
		private readonly List<int> _meshTriangles; // 0x100
	
		// Nested types
		public enum VerticalAlignments // TypeDefIndex: 56773
		{
			Top = 0,
			Bottom = 1
		}
	
		// Constructors
		public ProfilerGraphControl() {} // 0x00000001896B7E50-0x00000001896B7FE8
		static ProfilerGraphControl() {} // 0x00000001896B7DC4-0x00000001896B7E50
	
		// Methods
		protected override void Awake() {} // 0x00000001896B70AC-0x00000001896B7110
		protected override void Start() {} // 0x000000018350B670-0x000000018350B680
		protected void Update() {} // 0x00000001896B7DB4-0x00000001896B7DC4
		[Obsolete]
		protected override void OnPopulateMesh(Mesh m) {} // 0x00000001896B78C8-0x00000001896B7DB4
		protected void DrawDataPoint(float xPosition, float verticalScale, ProfilerFrame frame) {} // 0x00000001896B73DC-0x00000001896B76C8
		protected void DrawAxis(float frameTime, float yPosition, ProfilerGraphAxisLabel label) {} // 0x00000001896B71D4-0x00000001896B73DC
		protected void AddRect(Vector3 tl, Vector3 tr, Vector3 bl, Vector3 br, UnityEngine.Color c) {} // 0x00000001896B6D74-0x00000001896B70AC
		protected ProfilerFrame GetFrame(int i) => default; // 0x00000001896B783C-0x00000001896B78C8
		protected int CalculateVisibleDataPointCount() => default; // 0x00000001896B7198-0x00000001896B71D4
		protected int GetFrameBufferCurrentSize() => default; // 0x00000001896B7798-0x00000001896B77E4
		protected int GetFrameBufferMaxSize() => default; // 0x00000001896B77E4-0x00000001896B783C
		protected float CalculateMaxFrameTime() => default; // 0x00000001896B7110-0x00000001896B7198
		private ProfilerGraphAxisLabel GetAxisLabel(int index) => default; // 0x00000001896B76C8-0x00000001896B7798
	}

	public class SRTabButton : SRMonoBehaviourEx // TypeDefIndex: 56775
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
		public bool IsActive { get => default; set {} } // 0x00000001896B897C-0x00000001896B899C 0x00000001896B899C-0x00000001896B89BC
	
		// Constructors
		public SRTabButton() {} // 0x000000018426FE60-0x000000018426FE68
	}
}

namespace SRDebugger.UI.Controls.Data
{
	public class ActionControl : OptionsControlBase // TypeDefIndex: 56776
	{
		// Fields
		private MethodReference _method; // 0x60
		[RequiredField]
		public UnityEngine.UI.Button Button; // 0x68
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0x70
	
		// Properties
		public MethodReference Method { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
	
		// Constructors
		public ActionControl() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896A9C80-0x00000001896A9D1C
		private void ButtonOnClick() {} // 0x00000001896A9B30-0x00000001896A9C48
		public void SetMethod(string methodName, MethodReference method) {} // 0x00000001896A9C48-0x00000001896A9C80
	}

	public class BoolControl : DataBoundControl // TypeDefIndex: 56777
	{
		// Fields
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0x80
		[RequiredField]
		public Toggle Toggle; // 0x88
	
		// Constructors
		public BoolControl() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896A9E28-0x00000001896A9EE0
		private void ToggleOnValueChanged(bool isOn) {} // 0x00000001896A9EE0-0x00000001896A9F38
		protected override void OnBind(string propertyName, System.Type t) {} // 0x00000001896A9D80-0x00000001896A9DC4
		protected override void OnValueUpdated(object newValue) {} // 0x00000001896A9DC4-0x00000001896A9E28
		public override bool CanBind(System.Type type, bool isReadOnly) => default; // 0x00000001896A9D1C-0x00000001896A9D80
	}

	public class EnumControl : DataBoundControl // TypeDefIndex: 56778
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
		public EnumControl() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896AE99C-0x00000001896AE9BC
		protected override void OnBind(string propertyName, System.Type t) {} // 0x00000001896B08C0-0x00000001896B0B1C
		protected override void OnValueUpdated(object newValue) {} // 0x00000001896B0B1C-0x00000001896B0BD8
		public override bool CanBind(System.Type type, bool isReadOnly) => default; // 0x00000001893C0C94-0x00000001893C0CB4
		private void SetIndex(int i) {} // 0x00000001896B0BD8-0x00000001896B0C1C
		public void GoToNext() {} // 0x00000001896B07F8-0x00000001896B085C
		public void GoToPrevious() {} // 0x00000001896B085C-0x00000001896B08C0
	}

	public class NumberControl : DataBoundControl // TypeDefIndex: 56780
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
		public struct ValueRange // TypeDefIndex: 56779
		{
			// Fields
			public double MaxValue; // 0x00
			public double MinValue; // 0x08
		}
	
		// Constructors
		public NumberControl() {} // 0x000000018426FE60-0x000000018426FE68
		static NumberControl() {} // 0x00000001896B327C-0x00000001896B36FC
	
		// Methods
		protected override void Start() {} // 0x00000001896B31C4-0x00000001896B327C
		private void OnValueChanged(string newValue) {} // 0x00000001896B2F48-0x00000001896B30BC
		protected override void OnBind(string propertyName, System.Type t) {} // 0x00000001896B2BD4-0x00000001896B2F48
		protected override void OnValueUpdated(object newValue) {} // 0x00000001896B30BC-0x00000001896B31C4
		public override bool CanBind(System.Type type, bool isReadOnly) => default; // 0x00000001896B27A8-0x00000001896B280C
		protected static bool IsIntegerType(System.Type t) => default; // 0x00000001896B2B10-0x00000001896B2BD4
		protected static bool IsDecimalType(System.Type t) => default; // 0x00000001896B2A4C-0x00000001896B2B10
		protected double GetMaxValue(System.Type t) => default; // 0x00000001896B280C-0x00000001896B292C
		protected double GetMinValue(System.Type t) => default; // 0x00000001896B292C-0x00000001896B2A4C
	}

	public class ReadOnlyControl : DataBoundControl // TypeDefIndex: 56781
	{
		// Fields
		[RequiredField]
		public UnityEngine.UI.Text ValueText; // 0x80
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0x88
	
		// Constructors
		public ReadOnlyControl() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896AE99C-0x00000001896AE9BC
		protected override void OnBind(string propertyName, System.Type t) {} // 0x00000001896B87F4-0x00000001896B8818
		protected override void OnValueUpdated(object newValue) {} // 0x00000001896B8818-0x00000001896B8884
		public override bool CanBind(System.Type type, bool isReadOnly) => default; // 0x00000001896B8774-0x00000001896B87F4
	}

	public class StringControl : DataBoundControl // TypeDefIndex: 56782
	{
		// Fields
		[RequiredField]
		public InputField InputField; // 0x80
		[RequiredField]
		public UnityEngine.UI.Text Title; // 0x88
	
		// Constructors
		public StringControl() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896B9F08-0x00000001896B9FC0
		private void OnValueChanged(string newValue) {} // 0x00000001896B9E78-0x00000001896B9E80
		protected override void OnBind(string propertyName, System.Type t) {} // 0x00000001896B9DEC-0x00000001896B9E78
		protected override void OnValueUpdated(object newValue) {} // 0x00000001896B9E80-0x00000001896B9F08
		public override bool CanBind(System.Type type, bool isReadOnly) => default; // 0x00000001896B9D70-0x00000001896B9DEC
	}
}

namespace SRDebugger.UI.Other
{
	public class BugReportPopoverRoot : SRMonoBehaviourEx // TypeDefIndex: 56735
	{
		// Fields
		[RequiredField]
		public CanvasGroup CanvasGroup; // 0x48
		[RequiredField]
		public RectTransform Container; // 0x50
	
		// Constructors
		public BugReportPopoverRoot() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public class BugReportSheetController : SRMonoBehaviourEx // TypeDefIndex: 56737
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
		public bool IsCancelButtonEnabled { get => default; set {} } // 0x00000001896AB3DC-0x00000001896AB40C 0x00000001896AB40C-0x00000001896AB444
	
		// Constructors
		public BugReportSheetController() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896AB270-0x00000001896AB29C
		public void Submit() {} // 0x00000001896AB2F8-0x00000001896AB3DC
		public void Cancel() {} // 0x00000001896AAE44-0x00000001896AAE58
		[IteratorStateMachine(typeof(_SubmitCo_d__18))]
		private IEnumerator SubmitCo() => default; // 0x00000001896AB29C-0x00000001896AB2F8
		private void OnBugReportProgress(float progress) {} // 0x00000001896AB044-0x00000001896AB068
		private void OnBugReportComplete(bool didSucceed, string errorMessage) {} // 0x00000001896AAF88-0x00000001896AB044
		protected void SetLoadingSpinnerVisible(bool visible) {} // 0x00000001896AB118-0x00000001896AB170
		protected void ClearForm() {} // 0x00000001896AAEC8-0x00000001896AAF40
		protected void ShowErrorMessage(string userMessage, string serverMessage = null) {} // 0x00000001896AB170-0x00000001896AB270
		protected void ClearErrorMessage() {} // 0x00000001896AAE58-0x00000001896AAEC8
		protected void SetFormEnabled(bool e) {} // 0x00000001896AB0AC-0x00000001896AB118
		private string GetDefaultEmailFieldContents() => default; // 0x00000001896AAF40-0x00000001896AAF88
		private void SetDefaultEmailFieldContents(string value) {} // 0x00000001896AB068-0x00000001896AB0AC
	}

	public class CategoryGroup : SRMonoBehaviourEx // TypeDefIndex: 56738
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
		public bool IsSelected { get => default; set {} } // 0x00000001896AB7B4-0x00000001896AB7D4 0x00000001896AB7D4-0x00000001896AB8AC
		public bool SelectionModeEnabled { get => default; set {} } // 0x0000000183D4F260-0x0000000183D4F270 0x00000001896AB8AC-0x00000001896AB90C
	
		// Constructors
		public CategoryGroup() {} // 0x00000001896AB760-0x00000001896AB7B4
	}

	[RequireComponent(typeof(Canvas))]
	public class ConfigureCanvasFromSettings : SRMonoBehaviour // TypeDefIndex: 56739
	{
		// Fields
		private Canvas _canvas; // 0x48
		private CanvasScaler _canvasScaler; // 0x50
		private float _originalScale; // 0x58
		private float _lastSetScale; // 0x5C
		private SRDebugger.Settings _settings; // 0x60
	
		// Constructors
		public ConfigureCanvasFromSettings() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Start() {} // 0x00000001896ABAC8-0x00000001896ABC44
		private void OnDestroy() {} // 0x00000001896AB99C-0x00000001896ABA5C
		private void SettingsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) {} // 0x00000001896ABA5C-0x00000001896ABAC8
	}

	public class ConsoleTabQuickViewControl : SRMonoBehaviourEx // TypeDefIndex: 56740
	{
		// Fields
		private const int Max = 1000; // Metadata: 0x01FD81D6
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
		public ConsoleTabQuickViewControl() {} // 0x00000001896AE644-0x00000001896AE65C
		static ConsoleTabQuickViewControl() {} // 0x00000001896AE5C8-0x00000001896AE644
	
		// Methods
		protected override void Awake() {} // 0x00000001896AE274-0x00000001896AE314
		protected override void Update() {} // 0x00000001896AE344-0x00000001896AE5C8
		private static bool HasChanged(int newCount, ref int oldCount, int max) => default; // 0x00000001896AE314-0x00000001896AE344
	}

	[RequireComponent(typeof(StyleComponent))]
	public class DebugPanelBackgroundBehaviour : SRMonoBehaviour // TypeDefIndex: 56741
	{
		// Fields
		private StyleComponent _styleComponent; // 0x48
		public string TransparentStyleKey; // 0x50
		[SerializeField]
		private StyleSheet _styleSheet; // 0x58
	
		// Constructors
		public DebugPanelBackgroundBehaviour() {} // 0x00000001896AEAD0-0x00000001896AEB18
	
		// Methods
		private void Awake() {} // 0x00000001896AEA08-0x00000001896AEAD0
	}

	public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 56742
	{
		// Fields
		public const float NonFocusOpacity = 0.65f; // Metadata: 0x01FD81D8
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
		public bool IsVisible { get => default; set {} } // 0x00000001896B007C-0x00000001896B00A0 0x00000001896B00A0-0x00000001896B00D0
	
		// Constructors
		public DockConsoleController() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896AFB2C-0x00000001896AFEC8
		protected override void OnDestroy() {} // 0x00000001896AF3EC-0x00000001896AF4E0
		protected override void OnEnable() {} // 0x00000001896AF4E0-0x00000001896AF4F4
		protected override void OnDisable() {} // 0x0000000183D75190-0x0000000183D751A0
		protected override void Update() {} // 0x00000001896B006C-0x00000001896B007C
		private void OnFilterStateChange(UnityEngine.LogType logType, bool newState) {} // 0x00000001896AF508-0x00000001896AF568
		private void ConsoleOnUpdated(IConsoleService console) {} // 0x0000000183D73A50-0x0000000183D73A60
		public void SetDropdownVisibility(bool visible) {} // 0x00000001896AFAA0-0x00000001896AFB2C
		public void SetAlignmentMode(ConsoleAlignment alignment) {} // 0x00000001896AF804-0x00000001896AFAA0
		private void Refresh() {} // 0x00000001896AF5D0-0x00000001896AF804
		private void RefreshAlpha() {} // 0x00000001896AF588-0x00000001896AF5D0
		public void ToggleDropdownVisible() {} // 0x00000001896AFEC8-0x00000001896AFEFC
		public void MenuButtonPressed() {} // 0x00000001896AF390-0x00000001896AF3E0
		public void ClearButtonPressed() {} // 0x00000001896AF36C-0x00000001896AF390
		public void TogglesUpdated() {} // 0x00000001896AFEFC-0x00000001896AFFAC
		public void OnPointerEnter(PointerEventData e) {} // 0x00000001896AF568-0x00000001896AF578
		public void OnPointerExit(PointerEventData e) {} // 0x00000001896AF578-0x00000001896AF588
		public void OnBeginDrag() {} // 0x00000001896AF3E0-0x00000001896AF3EC
		public void OnEndDrag() {} // 0x00000001896AF4F4-0x00000001896AF508
	}

	public class ErrorNotifier : MonoBehaviour // TypeDefIndex: 56743
	{
		// Fields
		private const float DisplayTime = 6f; // Metadata: 0x01FD81DC
		[SerializeField]
		private Animator _animator; // 0x18
		private int _triggerHash; // 0x20
		private float _hideTime; // 0x24
		private bool _isShowing; // 0x28
		private bool _queueWarning; // 0x29
	
		// Properties
		public bool IsVisible { get => default; } // 0x0000000183D4ED50-0x0000000183D4ED60 
	
		// Constructors
		public ErrorNotifier() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x00000001896B0C1C-0x00000001896B0C58
		public void ShowErrorWarning() {} // 0x0000000183D5CAD0-0x0000000183D5CAE0
		private void Update() {} // 0x00000001896B0C58-0x00000001896B0CDC
	}

	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class FloatOverElement : UIBehaviour, ILayoutSelfController // TypeDefIndex: 56744
	{
		// Fields
		public RectTransform CopyFrom; // 0x18
		private DrivenRectTransformTracker _tracker; // 0x20
	
		// Constructors
		public FloatOverElement() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Copy() {} // 0x00000001896B0CDC-0x00000001896B0E88
		public void SetLayoutHorizontal() {} // 0x00000001896B0E88-0x00000001896B0E90
		public void SetLayoutVertical() {} // 0x00000001896B0E88-0x00000001896B0E90
	}

	public class HandleManager : SRMonoBehaviour // TypeDefIndex: 56745
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
		public HandleManager() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Start() {} // 0x00000001896B10EC-0x00000001896B1100
		public void SetAlignment(PinAlignment alignment) {} // 0x00000001896B0F00-0x00000001896B10EC
		private void SetActive(GameObject obj, bool active) {} // 0x00000001896B0E90-0x00000001896B0F00
	}

	public interface IEnableTab // TypeDefIndex: 56746
	{
		// Properties
		bool IsEnabled { get; }
	}

	public class LoadingSpinnerBehaviour : SRMonoBehaviour // TypeDefIndex: 56747
	{
		// Fields
		private float _dt; // 0x48
		public int FrameCount; // 0x4C
		public float SpinDuration; // 0x50
	
		// Constructors
		public LoadingSpinnerBehaviour() {} // 0x00000001896B1D44-0x00000001896B1D5C
	
		// Methods
		private void Update() {} // 0x00000001896B1C38-0x00000001896B1D44
	}

	public class PinnedUIRoot : SRMonoBehaviourEx // TypeDefIndex: 56748
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
		public PinnedUIRoot() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class SafeAreaSizer : UIBehaviour, ILayoutElement // TypeDefIndex: 56749
	{
		// Fields
		[FormerlySerializedAs("Edge")]
		[SerializeField]
		private RectTransform.Edge _edge; // 0x18
		public float Scale; // 0x1C
		private float _height; // 0x20
		private float _width; // 0x24
	
		// Properties
		public RectTransform.Edge Edge { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x00000001896B9708-0x00000001896B9794
		public float preferredWidth { get => default; } // 0x0000000183D524F0-0x0000000183D52500 
		public float preferredHeight { get => default; } // 0x0000000183D4F2E0-0x0000000183D4F2F0 
		public float minWidth { get => default; } // 0x0000000183D524F0-0x0000000183D52500 
		public float minHeight { get => default; } // 0x0000000183D4F2E0-0x0000000183D4F2F0 
		public int layoutPriority { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public float flexibleHeight { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public float flexibleWidth { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
	
		// Constructors
		public SafeAreaSizer() {} // 0x0000000183B45ED0-0x0000000183B45EE0
	
		// Methods
		private void Refresh() {} // 0x00000001896B9468-0x00000001896B9708
		public void CalculateLayoutInputHorizontal() {} // 0x00000001896B943C-0x00000001896B9468
		public void CalculateLayoutInputVertical() {} // 0x00000001896B943C-0x00000001896B9468
	}

	[RequireComponent(typeof(ScrollRect))]
	public class ScrollSettingsBehaviour : MonoBehaviour // TypeDefIndex: 56750
	{
		// Fields
		public const float ScrollSensitivity = 40f; // Metadata: 0x01FD81E0
	
		// Constructors
		public ScrollSettingsBehaviour() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x00000001896B9794-0x00000001896B97F8
	}

	public class SetLayerFromSettings : SRMonoBehaviour // TypeDefIndex: 56751
	{
		// Constructors
		public SetLayerFromSettings() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Start() {} // 0x00000001896B97F8-0x00000001896B9834
	}

	public class SRTab : SRMonoBehaviourEx // TypeDefIndex: 56752
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
		public string Title { get => default; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public string LongTitle { get => default; } // 0x00000001896B9424-0x00000001896B943C 
		public string Key { get => default; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
		// Constructors
		public SRTab() {} // 0x00000001896B93DC-0x00000001896B9424
	}

	public class SRTabController : SRMonoBehaviourEx // TypeDefIndex: 56755
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
	
		// Properties
		public SRTab ActiveTab { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x00000001896B93D4-0x00000001896B93DC
		public IList<SRTab> Tabs { get => default; } // 0x00000001896B92FC-0x00000001896B9344 
	
		// Events
		public event Action<SRTabController, SRTab> ActiveTabChanged;
	
		// Constructors
		public SRTabController() {} // 0x00000001896B9208-0x00000001896B926C
	
		// Methods
		public void AddTab(SRTab tab, bool visibleInSidebar = true /* Metadata: 0x01FD81E4 */) {} // 0x00000001896B89BC-0x00000001896B8CC8
		private void MakeActive(SRTab tab) {} // 0x00000001896B8CC8-0x00000001896B9030
		private void SortTabs() {} // 0x00000001896B9030-0x00000001896B9208
	}

	public class TriggerRoot : SRMonoBehaviourEx // TypeDefIndex: 56756
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
		public TriggerRoot() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public class VersionTextBehaviour : SRMonoBehaviourEx // TypeDefIndex: 56757
	{
		// Fields
		public string Format; // 0x48
		[RequiredField]
		public UnityEngine.UI.Text Text; // 0x50
	
		// Constructors
		public VersionTextBehaviour() {} // 0x00000001896BAD4C-0x00000001896BAD94
	
		// Methods
		protected override void Start() {} // 0x00000001896BACE8-0x00000001896BAD4C
	}
}

namespace SRDebugger.UI.Tabs
{
	public class BugReportTabController : SRMonoBehaviourEx, IEnableTab // TypeDefIndex: 56725
	{
		// Fields
		[RequiredField]
		public BugReportSheetController BugReportSheetPrefab; // 0x48
		[RequiredField]
		public RectTransform Container; // 0x50
	
		// Properties
		public bool IsEnabled { get => default; } // 0x00000001896AB6BC-0x00000001896AB760 
	
		// Constructors
		public BugReportTabController() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896AB540-0x00000001896AB670
		private void TakingScreenshot() {} // 0x00000001896AB670-0x00000001896AB6BC
		private void ScreenshotComplete() {} // 0x00000001896AB4F4-0x00000001896AB540
	}

	public class ConsoleTabController : SRMonoBehaviourEx // TypeDefIndex: 56728
	{
		// Fields
		private const int MaxLength = 2600; // Metadata: 0x01FD81C5
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
		public enum CopyToClipboardStates // TypeDefIndex: 56726
		{
			Hidden = 0,
			Visible = 1,
			Activated = 2
		}
	
		// Constructors
		public ConsoleTabController() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896ADB10-0x00000001896AE148
		private void OnFilterStateChange(UnityEngine.LogType logtype, bool newstate) {} // 0x00000001896AD2D0-0x00000001896AD330
		private void FilterToggleValueChanged(bool isOn) {} // 0x00000001896ACF3C-0x00000001896ACFBC
		private void FilterValueChanged(string filterText) {} // 0x00000001896ACFBC-0x00000001896AD038
		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) {} // 0x00000001896AD330-0x00000001896AD3CC
		private void PinToggleValueChanged(bool isOn) {} // 0x00000001896AD3CC-0x00000001896AD3F8
		protected override void OnDestroy() {} // 0x00000001896AD1C8-0x00000001896AD2C8
		protected override void OnEnable() {} // 0x0000000183D75180-0x0000000183D75190
		protected override void OnDisable() {} // 0x00000001896AD2C8-0x00000001896AD2D0
		private void ConsoleLogSelectedItemChanged(object item) {} // 0x00000001896ACDB8-0x00000001896ACE0C
		protected override void Update() {} // 0x00000001896AE264-0x00000001896AE274
		private void PopulateStackTraceArea(ConsoleEntry entry) {} // 0x00000001896AD3F8-0x00000001896AD5CC
		public void CopyToClipboard() {} // 0x00000001896ACE0C-0x00000001896ACEE0
		private void SetCopyToClipboardButtonState(CopyToClipboardStates state) {} // 0x00000001896AD950-0x00000001896ADB10
		[IteratorStateMachine(typeof(_FadeCopyButton_d__44))]
		private IEnumerator FadeCopyButton() => default; // 0x00000001896ACEE0-0x00000001896ACF3C
		private void StopAnimations() {} // 0x00000001896AE148-0x00000001896AE1A4
		private void Refresh() {} // 0x00000001896AD5CC-0x00000001896AD950
		private void ConsoleOnUpdated(IConsoleService console) {} // 0x0000000183D75180-0x0000000183D75190
		public void Clear() {} // 0x00000001896ACD88-0x00000001896ACDB8
		public void LogHandlerHasBeenOverridenOkayButtonPress() {} // 0x00000001896AD038-0x00000001896AD090
		public void LoggingDisableCloseAndIgnorePressed() {} // 0x00000001896AD090-0x00000001896AD0EC
		public void LoggingDisableReenablePressed() {} // 0x00000001896AD0EC-0x00000001896AD1C8
	}

	public class InfoTabController : SRMonoBehaviourEx // TypeDefIndex: 56729
	{
		// Fields
		public const char Tick = '\x2713'; // Metadata: 0x01FD81CA
		public const char Cross = '\x00d7'; // Metadata: 0x01FD81CC
		public const string NameColor = "#BCBCBC"; // Metadata: 0x01FD81CE
		private Dictionary<string, InfoBlock> _infoBlocks; // 0x48
		[RequiredField]
		public InfoBlock InfoBlockPrefab; // 0x50
		[RequiredField]
		public RectTransform LayoutContainer; // 0x58
		[RequiredField]
		public FlashGraphic ToggleButton; // 0x60
		private bool _updateEveryFrame; // 0x68
	
		// Constructors
		public InfoTabController() {} // 0x00000001896B1BB8-0x00000001896B1C38
	
		// Methods
		protected override void OnEnable() {} // 0x00000001896B1B3C-0x00000001896B1B74
		public void Refresh() {} // 0x00000001896B1B74-0x00000001896B1BA8
		protected override void Update() {} // 0x00000001896B1BA8-0x00000001896B1BB8
		public void ActivateRefreshEveryFrame() {} // 0x00000001896B1214-0x00000001896B1248
		private void InternalRefresh() {} // 0x00000001896B174C-0x00000001896B1B3C
		private void FillInfoBlock(InfoBlock block, IList<SRDebugger.InfoEntry> info) {} // 0x00000001896B12E0-0x00000001896B174C
		private InfoBlock CreateBlock(string title) => default; // 0x00000001896B1248-0x00000001896B12E0
	}

	public class OptionsTabController : SRMonoBehaviourEx // TypeDefIndex: 56733
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
		private class CategoryInstance // TypeDefIndex: 56730
		{
			// Fields
			public readonly List<OptionsControlBase> Options; // 0x18
	
			// Properties
			public CategoryGroup CategoryGroup { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
			// Constructors
			public CategoryInstance() {} // Dummy constructor
			public CategoryInstance(CategoryGroup group) {} // 0x00000001896AB90C-0x00000001896AB99C
		}
	
		// Constructors
		public OptionsTabController() {} // 0x00000001896B5AC0-0x00000001896B5BD4
	
		// Methods
		protected override void Start() {} // 0x00000001896B58A8-0x00000001896B5AAC
		protected override void OnDestroy() {} // 0x00000001896B4710-0x00000001896B48A4
		private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned) {} // 0x00000001896B4A24-0x00000001896B4AC4
		private void OnOptionsUpdated(object sender, EventArgs eventArgs) {} // 0x00000001896B4AF4-0x00000001896B4B14
		protected override void OnEnable() {} // 0x00000001896B4990-0x00000001896B4A24
		protected override void OnDisable() {} // 0x00000001896B48A4-0x00000001896B4990
		protected override void Update() {} // 0x00000001896B5AAC-0x00000001896B5AC0
		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) {} // 0x00000001896B4B14-0x00000001896B4BC8
		public void SetSelectionModeEnabled(bool isEnabled) {} // 0x00000001896B5548-0x00000001896B58A8
		private void Refresh() {} // 0x00000001896B5408-0x00000001896B5548
		private void CommitPinnedOptions() {} // 0x00000001896B3CD0-0x00000001896B3EFC
		private void RefreshCategorySelection() {} // 0x00000001896B5244-0x00000001896B5408
		private void OnOptionSelectionToggle(bool selected) {} // 0x00000001896B4AC4-0x00000001896B4AF4
		private void OnCategorySelectionToggle(CategoryInstance category, bool selected) {} // 0x00000001896B465C-0x00000001896B4710
		protected void Populate() {} // 0x00000001896B4BC8-0x00000001896B5244
		protected void CreateCategory(string title, List<OptionDefinition> options) {} // 0x00000001896B3EFC-0x00000001896B465C
		private void Clear() {} // 0x00000001896B3B04-0x00000001896B3CD0
	}

	public class ProfilerTabController : SRMonoBehaviourEx // TypeDefIndex: 56734
	{
		// Fields
		private bool _isDirty; // 0x48
		[RequiredField]
		public Toggle PinToggle; // 0x50
	
		// Constructors
		public ProfilerTabController() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void Start() {} // 0x00000001896B86AC-0x00000001896B8764
		private void PinToggleValueChanged(bool isOn) {} // 0x00000001896B85E0-0x00000001896B8634
		protected override void OnEnable() {} // 0x0000000183D73A50-0x0000000183D73A60
		protected override void Update() {} // 0x00000001896B8764-0x00000001896B8774
		private void Refresh() {} // 0x00000001896B8634-0x00000001896B86AC
	}
}
