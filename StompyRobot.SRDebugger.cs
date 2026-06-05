/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
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
using UnityEngine.UI;

// Image 48: StompyRobot.SRDebugger.dll - Assembly: StompyRobot.SRDebugger, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57690-57848

public static class SRDebug // TypeDefIndex: 57692
{
	// Fields
	public const string Version = "1.12.1"; // Metadata: 0x0207DA0E
	private static bool _IsInitialized_k__BackingField; // 0x00
	public static Action<ConsoleEntry> CopyConsoleItemCallback; // 0x08

	// Properties
	public static bool IsInitialized { get; private set; } // 0x0000000185C2B2A0-0x0000000185C2B390 0x0000000185D6F890-0x0000000185D6F990
	public static IDebugService Instance { get; } // 0x0000000185D6F830-0x0000000185D6F890 

	// Nested types
	[Serializable]
	private sealed class __c // TypeDefIndex: 57691
	{
		// Fields
		public static readonly __c __9; // 0x00
		public static Action<ConsoleEntry> __9__9_0; // 0x08

		// Constructors
		static __c() {} // 0x000000018B7DE9E4-0x000000018B7DEA34
		public __c() {} // 0x000000018B7DEA34-0x000000018B7DEA88

		// Methods
		internal void _GetDefaultCopyConsoleItemCallback_b__9_0(ConsoleEntry entry) {} // 0x000000018B7DE990-0x000000018B7DE9E4
	}

	// Constructors
	static SRDebug() {} // 0x000000018B7E0B28-0x000000018B7E0BA8

	// Methods
	public static void Init() {} // 0x0000000185F70E10-0x0000000185F70E70
	public static Action<ConsoleEntry> GetDefaultCopyConsoleItemCallback() => default; // 0x0000000185492010-0x0000000185492020
}

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 57848
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_36 _0B92E635AE849B517CA3A2F28C2502AF8675E5C6C01CD75EA9F53120E81DDAAA; // 0x00 // Static value (base64): CtejO83MzDuJiAg8CtcjPImIiDyJiAg9zcxMPauqqj2rqio+ - Metadata: 0x0207DCAC

	// Nested types
	private struct __StaticArrayInitTypeSize_36 // TypeDefIndex: 57847
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Assets.StompyRobot.SRDebugger.Scripts.Services.Implementation
{
	public sealed class ConsoleFilterStateService : IConsoleFilterState // TypeDefIndex: 57693
	{
		// Fields
		private ConsoleStateChangedEventHandler FilterStateChange; // 0x10
		private readonly bool[] _states; // 0x18
	
		// Events
		public event ConsoleStateChangedEventHandler FilterStateChange;
	
		// Constructors
		public ConsoleFilterStateService() {} // 0x000000018B7D2530-0x000000018B7D2618
	
		// Methods
		public void SetConsoleFilterState(UnityEngine.LogType type, bool newState) {} // 0x000000018B7D23D8-0x000000018B7D2448
		public bool GetConsoleFilterState(UnityEngine.LogType type) => default; // 0x000000018B7D235C-0x000000018B7D2398
		private static UnityEngine.LogType GetType(UnityEngine.LogType type) => default; // 0x000000018B7D2398-0x000000018B7D23D8
	}
}

namespace SRDebugger
{
	public static class AutoInitialize // TypeDefIndex: 57694
	{
		// Fields
		private const RuntimeInitializeLoadType InitializeLoadType = RuntimeInitializeLoadType.SubsystemRegistration; // Metadata: 0x0207DA15
	
		// Methods
		public static void OnLoadBeforeScene() {} // 0x0000000185C2B390-0x0000000185C2B430
		public static void OnLoad() {} // 0x0000000185C2B240-0x0000000185C2B2A0
	}

	public class BugReport // TypeDefIndex: 57695
	{
		// Fields
		public List<ConsoleEntry> ConsoleLog; // 0x10
		public string Email; // 0x18
		public byte[] ScreenshotData; // 0x20
		public Dictionary<string, Dictionary<string, object>> SystemInformation; // 0x28
		public string UserDescription; // 0x30
	
		// Constructors
		public BugReport() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class BugReportSubmitResult // TypeDefIndex: 57696
	{
		// Fields
		private readonly bool _IsSuccessful_k__BackingField; // 0x10
		private readonly string _ErrorMessage_k__BackingField; // 0x18
	
		// Properties
		public static BugReportSubmitResult Success { get => default; } // 0x000000018B7D15AC-0x000000018B7D1600 
		public bool IsSuccessful { get; } // 0x0000000181C2FD60-0x0000000181C2FD70 
		public string ErrorMessage { get; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		public BugReportSubmitResult() {} // Dummy constructor
		private BugReportSubmitResult(bool successful, string error) {} // 0x000000018470BFE0-0x000000018470BFF0
	
		// Methods
		public static BugReportSubmitResult Error(string errorMessage) => default; // 0x000000018B7D1550-0x000000018B7D15AC
	}

	public interface IBugReporterHandler // TypeDefIndex: 57697
	{
		// Properties
		bool IsUsable { get; }
	
		// Methods
		void Submit(BugReport report, Action<BugReportSubmitResult> onComplete, IProgress<float> progress);
	}

	public class CircularBuffer<T> : IReadOnlyList<T> // TypeDefIndex: 57699
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
	
		// Nested types
		private sealed class _GetEnumerator_d__18 : IEnumerator<T> // TypeDefIndex: 57698
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
			T IEnumerator<T>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetEnumerator_d__18() {} // Dummy constructor
			public _GetEnumerator_d__18(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public CircularBuffer() {} // Dummy constructor
		public CircularBuffer(int capacity) {}
		public CircularBuffer(int capacity, T[] items) {}
	
		// Methods
		public void Clear() {}
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public T Front() => default;
		public T Back() => default;
		public void PushBack(T item) {}
		public void PushFront(T item) {}
		public void PopBack() {}
		public void PopFront() {}
		public T[] ToArray() => default;
		private void ThrowIfEmpty(string message = "Cannot access an empty buffer." /* Metadata: 0x0207DA16 */) {}
		private void Increment(ref int index) {}
		private void Decrement(ref int index) {}
		private int InternalIndex(int index) => default;
		private ArraySegment<T> ArrayOne() => default;
		private ArraySegment<T> ArrayTwo() => default;
	}

	public sealed class OptionDefinition // TypeDefIndex: 57700
	{
		// Fields
		private string _Name_k__BackingField; // 0x10
		private string _Category_k__BackingField; // 0x18
		private int _SortPriority_k__BackingField; // 0x20
		private MethodReference _Method_k__BackingField; // 0x28
		private PropertyReference _Property_k__BackingField; // 0x30
	
		// Properties
		public string Name { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string Category { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public int SortPriority { get; private set; } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public bool IsMethod { get => default; } // 0x00000001878567E4-0x00000001878567F0 
		public bool IsProperty { get => default; } // 0x000000018A6AD3DC-0x000000018A6AD3E8 
		public MethodReference Method { get; private set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public PropertyReference Property { get; private set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
	
		// Constructors
		public OptionDefinition() {} // Dummy constructor
		private OptionDefinition(string name, string category, int sortPriority) {} // 0x00000001859D9860-0x00000001859D9890
		public OptionDefinition(string name, string category, int sortPriority, MethodReference method) {} // 0x000000018B7D98DC-0x000000018B7D990C
		public OptionDefinition(string name, string category, int sortPriority, PropertyReference property) {} // 0x000000018B7D98AC-0x000000018B7D98DC
	
		// Methods
		public static OptionDefinition FromMethod(string name, Action callback, string category = "Default" /* Metadata: 0x0207DA35 */, int sortPriority = 0 /* Metadata: 0x0207DA3D */) => default; // 0x000000018B7D9808-0x000000018B7D98AC
		public static OptionDefinition Create<T>(string name, Func<T> getter, Action<T> setter = null, string category = "Default" /* Metadata: 0x0207DA3E */, int sortPriority = 0 /* Metadata: 0x0207DA46 */) => default;
	}

	public interface IOptionContainer // TypeDefIndex: 57701
	{
		// Properties
		bool IsDynamic { get; }
	
		// Events
		event Action<OptionDefinition> OptionAdded;
		event Action<OptionDefinition> OptionRemoved;
	
		// Methods
		IEnumerable<OptionDefinition> GetOptions();
	}

	public sealed class DynamicOptionContainer : IOptionContainer // TypeDefIndex: 57702
	{
		// Fields
		private readonly List<OptionDefinition> _options; // 0x10
		private readonly IList<OptionDefinition> _optionsReadOnly; // 0x18
		private Action<OptionDefinition> OptionAdded; // 0x20
		private Action<OptionDefinition> OptionRemoved; // 0x28
	
		// Properties
		public IList<OptionDefinition> Options { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public bool IsDynamic { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Events
		public event Action<OptionDefinition> OptionAdded;
		public event Action<OptionDefinition> OptionRemoved;
	
		// Constructors
		public DynamicOptionContainer() {} // 0x000000018B7D62BC-0x000000018B7D6360
	
		// Methods
		public void AddOption(OptionDefinition option) {} // 0x000000018B7D61DC-0x000000018B7D6248
		public bool RemoveOption(OptionDefinition option) => default; // 0x000000018B7D6248-0x000000018B7D62BC
		IEnumerable<OptionDefinition> IOptionContainer.GetOptions() => default; // 0x000000018346D130-0x000000018346D140
	}

	public delegate void VisibilityChangedDelegate(bool isVisible); // TypeDefIndex: 57703; 0x00000001833EEC70-0x00000001833EEC80

	public delegate void ActionCompleteCallback(bool success); // TypeDefIndex: 57704; 0x00000001833EEC70-0x00000001833EEC80

	public delegate void PinnedUiCanvasCreated(RectTransform canvasTransform); // TypeDefIndex: 57705; 0x00000001833EEC70-0x00000001833EEC80

	public struct EntryCode : IReadOnlyList<int> // TypeDefIndex: 57706
	{
		// Fields
		public readonly int Digit1; // 0x00
		public readonly int Digit2; // 0x04
		public readonly int Digit3; // 0x08
		public readonly int Digit4; // 0x0C
	
		// Properties
		public int Count { get => default; } // 0x0000000181C44E90-0x0000000181C44EA0 
		public int this[int index] { get => default; } // 0x000000018B7D6880-0x000000018B7D6904 
	
		// Constructors
		public EntryCode(int digit1, int digit2, int digit3, int digit4) : this() {
			Digit1 = default;
			Digit2 = default;
			Digit3 = default;
			Digit4 = default;
		} // 0x000000018B7D66A8-0x000000018B7D6880
	
		// Methods
		public IEnumerator<int> GetEnumerator() => default; // 0x000000018B7D6590-0x000000018B7D66A0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018B7D66A0-0x000000018B7D66A8
	}

	public sealed class InfoEntry // TypeDefIndex: 57708
	{
		// Fields
		private string _Title_k__BackingField; // 0x10
		private bool _IsPrivate_k__BackingField; // 0x18
		private Func<object> _valueGetter; // 0x20
	
		// Properties
		public string Title { get; set; } // 0x000000018B7D720C-0x000000018B7D7320 0x00000001813C0430-0x00000001813C0440
		public object Value { get => default; } // 0x00000001813C0520-0x00000001813C0530 
		public bool IsPrivate { get; private set; } // 0x0000000183FC52E0-0x0000000183FC5370 0x0000000183FC5370-0x0000000183FC5480
	
		// Nested types
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 57707
		{
			// Fields
			public object value; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x000000018346D130-0x000000018346D140
	
			// Methods
			internal object _Create_b__0() => default; // 0x0000000184096E30-0x0000000184096EF0
		}
	
		// Constructors
		public InfoEntry() {} // 0x000000018346D130-0x000000018346D140
	
		// Methods
		public static InfoEntry Create(string name, Func<object> getter, bool isPrivate = false /* Metadata: 0x0207DA47 */) => default; // 0x0000000185492010-0x0000000185492020
		public static InfoEntry Create(string name, object value, bool isPrivate = false /* Metadata: 0x0207DA48 */) => default; // 0x0000000185492010-0x0000000185492020
	}

	public enum DefaultTabs // TypeDefIndex: 57709
	{
		SystemInformation = 0,
		Options = 1,
		Console = 2,
		Profiler = 3,
		BugReporter = 4
	}

	public enum PinAlignment // TypeDefIndex: 57710
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

	public enum ConsoleAlignment // TypeDefIndex: 57711
	{
		Top = 0,
		Bottom = 1
	}

	public class Settings : ScriptableObject // TypeDefIndex: 57718
	{
		// Fields
		internal const string ResourcesName = "Settings"; // Metadata: 0x0207DA58
		private static Settings _instance; // 0x00
		private PropertyChangedEventHandler PropertyChanged; // 0x18
		private bool _isEnabled; // 0x20
		private bool _disableWelcomePopup; // 0x21
		private UIModes _uiInputMode; // 0x24
		private DefaultTabs _defaultTab; // 0x28
		private TriggerEnableModes _triggerEnableMode; // 0x2C
		private TriggerBehaviours _triggerBehaviour; // 0x30
		private bool _errorNotification; // 0x34
		private bool _enableKeyboardShortcuts; // 0x35
		private KeyboardShortcut[] _keyboardShortcuts; // 0x38
		private KeyboardShortcut[] _newKeyboardShortcuts; // 0x40
		private bool _keyboardModifierControl; // 0x48
		private bool _keyboardModifierAlt; // 0x49
		private bool _keyboardModifierShift; // 0x4A
		private bool _keyboardEscapeClose; // 0x4B
		private bool _enableBackgroundTransparency; // 0x4C
		private float _backgroundTransparency; // 0x50
		private bool _collapseDuplicateLogEntries; // 0x54
		private bool _richTextInConsole; // 0x55
		private bool _requireEntryCode; // 0x56
		private bool _requireEntryCodeEveryTime; // 0x57
		private int[] _entryCode; // 0x58
		private bool _useDebugCamera; // 0x60
		private int _debugLayer; // 0x64
		private float _debugCameraDepth; // 0x68
		private string _apiKey; // 0x70
		private bool _enableBugReporter; // 0x78
		private bool _enableBugReportScreenshot; // 0x79
		private DefaultTabs[] _disabledTabs; // 0x80
		private PinAlignment _profilerAlignment; // 0x88
		private PinAlignment _optionsAlignment; // 0x8C
		private ConsoleAlignment _consoleAlignment; // 0x90
		private PinAlignment _triggerPosition; // 0x94
		private int _maximumConsoleEntries; // 0x98
		private bool _enableEventSystemCreation; // 0x9C
		private bool _automaticShowCursor; // 0x9D
		private float _uiScale; // 0xA0
		private bool _unloadOnClose; // 0xA4
	
		// Properties
		public static Settings Instance { get => default; } // 0x000000018B7DFB78-0x000000018B7DFC0C 
		public bool IsEnabled { get => default; } // 0x00000001813CFF60-0x00000001813CFF70 
		public UIModes UIInputMode { get => default; } // 0x0000000185FB0B90-0x0000000185FB0BA0 
		public DefaultTabs DefaultTab { get => default; } // 0x0000000185FB0B80-0x0000000185FB0B90 
		public TriggerEnableModes EnableTrigger { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public TriggerBehaviours TriggerBehaviour { get => default; } // 0x0000000185FB8A70-0x0000000185FB8A80 
		public bool ErrorNotification { get => default; } // 0x0000000185FB0B40-0x0000000185FB0B50 
		public bool EnableKeyboardShortcuts { get => default; } // 0x0000000185FB3000-0x0000000185FB3010 
		public IList<KeyboardShortcut> KeyboardShortcuts { get => default; } // 0x0000000185FB9CC0-0x0000000185FB9CD0 
		public bool KeyboardEscapeClose { get => default; } // 0x0000000185FB9CB0-0x0000000185FB9CC0 
		public bool EnableBackgroundTransparency { get => default; } // 0x000000018B7DFB04-0x000000018B7DFB78 
		public float BackgroundTransparency { get => default; } // 0x000000018B7DFC0C-0x000000018B7DFE1C 
		public bool RequireCode { get => default; } // 0x000000018386C570-0x000000018386C580 
		public bool RequireEntryCodeEveryTime { get => default; } // 0x0000000185FB2020-0x0000000185FB2030 
		public IList<int> EntryCode { get => default; set {} } // 0x0000000185FB8230-0x0000000185FB8240 0x0000000185FB0A80-0x0000000185FB0A90
		public bool UseDebugCamera { get => default; } // 0x0000000185FB0A70-0x0000000185FB0A80 
		public int DebugLayer { get => default; } // 0x0000000181460F70-0x0000000181460F80 
		public float DebugCameraDepth { get => default; } // 0x0000000185FB0DA0-0x0000000185FB0DB0 
		public bool CollapseDuplicateLogEntries { get => default; } // 0x0000000185FB2E50-0x0000000185FB2E60 
		public bool RichTextInConsole { get => default; } // 0x000000018140CF50-0x000000018140CF60 
		public string ApiKey { get => default; } // 0x0000000181A73EA0-0x0000000181A73EB0 
		public bool EnableBugReporter { get => default; } // 0x00000001834A1F30-0x00000001834A1F40 
		public bool EnableBugReportScreenshot { get => default; } // 0x000000018349D720-0x000000018349D730 
		public IList<DefaultTabs> DisabledTabs { get => default; } // 0x00000001834A0D50-0x00000001834A0D60 
		public PinAlignment TriggerPosition { get => default; } // 0x00000001834A2260-0x00000001834A2270 
		public PinAlignment ProfilerAlignment { get => default; } // 0x00000001834A0D40-0x00000001834A0D50 
		public PinAlignment OptionsAlignment { get => default; } // 0x00000001834A2250-0x00000001834A2260 
		public ConsoleAlignment ConsoleAlignment { get => default; set {} } // 0x0000000185FBF7D0-0x0000000185FBF7E0 0x0000000185FBF810-0x0000000185FBF820
		public int MaximumConsoleEntries { get => default; set {} } // 0x0000000185FCECC0-0x0000000185FCECD0 0x0000000185FB9B70-0x0000000185FB9B80
		public bool EnableEventSystemGeneration { get => default; set {} } // 0x000000018B7DFE1C-0x000000018B7DFE7C 0x0000000185FB9C80-0x0000000185FB9C90
		public bool AutomaticallyShowCursor { get => default; } // 0x000000018B7DF9E0-0x000000018B7DFA70 
		public float UIScale { get => default; set {} } // 0x000000018B7DF940-0x000000018B7DF9E0 0x0000000185C48E20-0x0000000185C48E70
		public bool UnloadOnClose { get => default; } // 0x0000000185C48D80-0x0000000185C48E20 
	
		// Events
		public event PropertyChangedEventHandler PropertyChanged;
	
		// Nested types
		public enum ShortcutActions // TypeDefIndex: 57712
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
	
		public enum TriggerBehaviours // TypeDefIndex: 57713
		{
			TripleTap = 0,
			TapAndHold = 1,
			DoubleTap = 2
		}
	
		public enum TriggerEnableModes // TypeDefIndex: 57714
		{
			Enabled = 0,
			MobileOnly = 1,
			Off = 2,
			DevelopmentBuildsOnly = 3
		}
	
		public enum UIModes // TypeDefIndex: 57715
		{
			NewInputSystem = 0,
			LegacyInputSystem = 1
		}
	
		[Serializable]
		public sealed class KeyboardShortcut // TypeDefIndex: 57716
		{
			// Fields
			public ShortcutActions Action; // 0x10
			public bool Alt; // 0x14
			public bool Control; // 0x15
			public KeyCode Key; // 0x18
			public bool Shift; // 0x1C
			[NonSerialized]
			public UnityEngine.InputSystem.Key? Cached_KeyCode; // 0x20
	
			// Constructors
			public KeyboardShortcut() {} // 0x0000000184A8F7E0-0x0000000184A8F890
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 57717
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<int, bool> __9__42_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000185A29620-0x0000000185A29760
			public __c() {} // 0x0000000185C48E70-0x0000000185C48F10
	
			// Methods
			internal bool _set_EntryCode_b__42_0(int p) => default; // 0x000000018B7DFA70-0x000000018B7DFB04
		}
	
		// Constructors
		public Settings() {} // 0x000000018B7E0C08-0x000000018B7E0C18
	
		// Methods
		private static KeyboardShortcut[] GetDefaultKeyboardShortcuts() => default; // 0x00000001813ECBF0-0x00000001813ECC00
		private void UpgradeKeyboardShortcuts() {} // 0x0000000181424480-0x0000000181424490
		private void OnPropertyChanged(string propertyName) {} // 0x0000000185A29500-0x0000000185A29620
		internal static void ClearCache() {} // 0x0000000185492010-0x0000000185492020
		internal static Settings GetInstance() => default; // 0x000000018B7E0CC8-0x000000018B7E0D2C
		private static Settings GetOrCreateInstance() => default; // 0x0000000185492010-0x0000000185492020
	}

	public class SRDebuggerInit : SRMonoBehaviourEx // TypeDefIndex: 57719
	{
		// Constructors
		public SRDebuggerInit() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class NumberRangeAttribute : Attribute // TypeDefIndex: 57720
	{
		// Fields
		public readonly double Max; // 0x10
		public readonly double Min; // 0x18
	
		// Constructors
		public NumberRangeAttribute() {} // Dummy constructor
		public NumberRangeAttribute(double min, double max) {} // 0x0000000185FAFF70-0x0000000185FAFF80
	}

	public class IncrementAttribute : Attribute // TypeDefIndex: 57721
	{
		// Fields
		public readonly double Increment; // 0x10
	
		// Constructors
		public IncrementAttribute() {} // Dummy constructor
		public IncrementAttribute(double increment) {} // 0x0000000185FAFF60-0x0000000185FAFF70
	}

	public class SortAttribute : Attribute // TypeDefIndex: 57722
	{
		// Fields
		public readonly int SortPriority; // 0x10
	
		// Constructors
		public SortAttribute() {} // Dummy constructor
		public SortAttribute(int priority) {} // 0x0000000181378230-0x0000000181378240
	}

	public static class VersionInfo // TypeDefIndex: 57723
	{
		// Fields
		public const string Version = "1.12.1"; // Metadata: 0x0207DA76
	}
}

namespace SRDebugger.Internal
{
	public static class SRDebugApi // TypeDefIndex: 57832
	{
		// Fields
		public const string Protocol = "https://"; // Metadata: 0x0207DB31
		public const string EndPoint = "https://srdebugger.stompyrobot.uk"; // Metadata: 0x0207DB3A
		public const string BugReportEndPoint = "https://srdebugger.stompyrobot.uk/report/submit"; // Metadata: 0x0207DB5C
	}

	public static class SRDebugApiUtil // TypeDefIndex: 57833
	{
		// Methods
		public static string ParseErrorException(WebException ex) => default; // 0x000000018B7E7160-0x000000018B7E723C
		public static string ParseErrorResponse(string response, string fallback = "Unexpected Response" /* Metadata: 0x0207DB8C */) => default; // 0x000000018B7E723C-0x000000018B7E76D4
		public static bool ReadResponse(HttpWebRequest request, out string result) {
			result = default;
			return default;
		} // 0x000000018B7E785C-0x000000018B7E791C
		public static string ReadResponseStream(WebResponse stream) => default; // 0x000000018B7E76D4-0x000000018B7E785C
	}

	internal class BugReportApi : MonoBehaviour // TypeDefIndex: 57835
	{
		// Fields
		private string _apiKey; // 0x18
		private BugReport _bugReport; // 0x20
		private bool _isBusy; // 0x28
		private UnityWebRequest _webRequest; // 0x30
		private Action<BugReportSubmitResult> _onComplete; // 0x38
		private IProgress<float> _progress; // 0x40
	
		// Nested types
		private sealed class _Submit_d__9 : IEnumerator<object> // TypeDefIndex: 57834
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public BugReportApi __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B7E18A0-0x000000018B7E18FC 
			object IEnumerator.Current { get => default; } // 0x000000018B7E11C4-0x000000018B7E1340 
	
			// Constructors
			public _Submit_d__9() {} // Dummy constructor
			public _Submit_d__9(int __1__state) {} // 0x000000018B7E1760-0x000000018B7E18A0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B7E162C-0x000000018B7E1674
			private bool MoveNext() => default; // 0x000000018B7E18FC-0x000000018B7E196C
			void IEnumerator.Reset() {} // 0x000000018B7E1674-0x000000018B7E1760
		}
	
		// Constructors
		public BugReportApi() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public static void Submit(BugReport report, string apiKey, Action<BugReportSubmitResult> onComplete, IProgress<float> progress) {} // 0x000000018B7E1340-0x000000018B7E162C
		private void Init(BugReport report, string apiKey, Action<BugReportSubmitResult> onComplete, IProgress<float> progress) {} // 0x000000018646DB20-0x000000018646DB28
		private void Update() {} // 0x0000000181378230-0x0000000181378240
		private IEnumerator Submit() => default; // 0x0000000185492010-0x0000000185492020
		private void SetCompletionState(BugReportSubmitResult result) {} // 0x000000018B7EAF7C-0x000000018B7EB4D4
		private static string BuildJsonRequest(BugReport report) => default; // 0x0000000181377E40-0x0000000181377E50
		private static List<List<string>> CreateConsoleDump() => default; // 0x000000018B7EB4D4-0x000000018B7EB520
	}

	public class BugReportScreenshotUtil // TypeDefIndex: 57837
	{
		// Fields
		public static byte[] ScreenshotData; // 0x00
	
		// Nested types
		private sealed class _ScreenshotCaptureCo_d__1 : IEnumerator<object> // TypeDefIndex: 57836
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
			// Constructors
			public _ScreenshotCaptureCo_d__1() {} // Dummy constructor
			public _ScreenshotCaptureCo_d__1(int __1__state) {} // 0x000000018B7E196C-0x000000018B7E19B0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000181378230-0x0000000181378240
			void IEnumerator.Reset() {} // 0x000000018B7EAD54-0x000000018B7EAF30
		}
	
		// Constructors
		public BugReportScreenshotUtil() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public static IEnumerator ScreenshotCaptureCo() => default; // 0x000000018B7EAF30-0x000000018B7EAF7C
	}

	internal class InternalBugReporterHandler : IBugReporterHandler // TypeDefIndex: 57838
	{
		// Properties
		public bool IsUsable { get => default; } // 0x000000018B7E2F58-0x000000018B7E2F98 
	
		// Constructors
		public InternalBugReporterHandler() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Submit(BugReport report, Action<BugReportSubmitResult> onComplete, IProgress<float> progress) {} // 0x000000018B7E2F04-0x000000018B7E2F58
	}

	public sealed class InternalOptionsRegistry // TypeDefIndex: 57839
	{
		// Fields
		private List<object> _registeredContainers; // 0x10
		private Action<object> _handler; // 0x18
	
		// Constructors
		public InternalOptionsRegistry() {} // 0x0000000185F595F0-0x0000000185F59670
	
		// Methods
		public void AddOptionContainer(object obj) {} // 0x000000018466ED40-0x000000018466EDA0
		public void SetHandler(Action<object> action) {} // 0x0000000184B89330-0x0000000184B89490
	}

	public static class OptionControlFactory // TypeDefIndex: 57842
	{
		// Fields
		private static IList<DataBoundControl> _dataControlPrefabs; // 0x00
		private static ActionControl _actionControlPrefab; // 0x08
		private static readonly Dictionary<OptionType, DataBoundControl> TypeCache; // 0x10
	
		// Nested types
		private struct OptionType // TypeDefIndex: 57840
		{
			// Fields
			public readonly System.Type Type; // 0x00
			public readonly bool IsReadyOnly; // 0x08
	
			// Constructors
			public OptionType(System.Type type, bool isReadyOnly) {
				Type = default;
				IsReadyOnly = default;
			} // 0x000000018B7E3FF0-0x000000018B7E4098
	
			// Methods
			public bool Equals(OptionType other) => default; // 0x000000018B7E4198-0x000000018B7E4284
			public override bool Equals(object obj) => default; // 0x000000018B7E4568-0x000000018B7E4734
			public override int GetHashCode() => default; // 0x000000018B7E4098-0x000000018B7E4198
		}
	
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 57841
		{
			// Fields
			public OptionDefinition from; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x000000018B7E4284-0x000000018B7E4568
	
			// Methods
			internal bool _TryGetDataControlPrefab_b__0(DataBoundControl p) => default; // 0x000000018B7E4734-0x000000018B7E4910
		}
	
		// Constructors
		static OptionControlFactory() {} // 0x000000018B7EB90C-0x000000018B7EB950
	
		// Methods
		public static bool CanCreateControl(OptionDefinition from) => default; // 0x000000018B7E4910-0x000000018B7E49A4
		public static OptionsControlBase CreateControl(OptionDefinition from, string categoryPrefix = null) => default; // 0x000000018931A200-0x000000018931A21C
		private static void PopulateDataControlPrefabs() {} // 0x000000018B7E4A14-0x000000018B7E4A4C
		private static ActionControl CreateActionControl(OptionDefinition from, string categoryPrefix = null) => default; // 0x000000018B7E49A4-0x000000018B7E4A14
		private static DataBoundControl CreateDataControl(OptionDefinition from, string categoryPrefix = null) => default; // 0x000000018B7E4A4C-0x000000018B7E4AE8
		private static DataBoundControl TryGetDataControlPrefab(OptionDefinition from) => default; // 0x0000000185492010-0x0000000185492020
	}

	public static class SRDebugPaths // TypeDefIndex: 57843
	{
		// Fields
		public const string DataControlsResourcesPath = "SRDebugger/UI/Prefabs/Options"; // Metadata: 0x0207DBA0
		public const string TriggerPrefabPath = "SRDebugger/UI/Prefabs/Trigger"; // Metadata: 0x0207DBBE
		public const string DebugPanelPrefabPath = "SRDebugger/UI/Prefabs/DebugPanel"; // Metadata: 0x0207DBDC
		public const string PinnedUIPrefabPath = "SRDebugger/UI/Prefabs/PinnedUI"; // Metadata: 0x0207DBFD
		public const string DockConsolePrefabPath = "SRDebugger/UI/Prefabs/DockConsole"; // Metadata: 0x0207DC1C
		public const string PinEntryPrefabPath = "SRDebugger/UI/Prefabs/PinEntry"; // Metadata: 0x0207DC3E
		public const string BugReportPopoverPath = "SRDebugger/UI/Prefabs/BugReportPopover"; // Metadata: 0x0207DC5D
		public const string BugReportSheetPath = "SRDebugger/UI/Prefabs/BugReportSheet"; // Metadata: 0x0207DC84
	}

	public static class Service // TypeDefIndex: 57844
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
		public static IConsoleService Console { get; } // 0x000000018B7E9670-0x000000018B7E9710 
		public static IDockConsoleService DockConsole { get; } // 0x000000018B7E97B8-0x000000018B7E9860 
		public static IDebugPanelService Panel { get; } // 0x000000018B7E9908-0x000000018B7E99B0 
		public static IDebugTriggerService Trigger { get; } // 0x000000018B7E9A58-0x000000018B7E9B00 
		public static IPinnedUIService PinnedUI { get; } // 0x000000018B7E99B0-0x000000018B7E9A58 
		public static IDebugCameraService DebugCamera { get; } // 0x000000018B7E9710-0x000000018B7E97B8 
		public static IOptionsService Options { get; } // 0x000000018B7E9860-0x000000018B7E9908 
	}

	public class SRDebugStrings // TypeDefIndex: 57845
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
		public SRDebugStrings() {} // 0x000000018B7E917C-0x000000018B7E929C
		static SRDebugStrings() {} // 0x000000018B7E910C-0x000000018B7E917C
	}

	public static class SRDebuggerUtil // TypeDefIndex: 57846
	{
		// Properties
		public static bool IsMobilePlatform { get; } // 0x000000018B7E9644-0x000000018B7E9670 
	
		// Methods
		public static bool EnsureEventSystemExists() => default; // 0x000000018B7E94E8-0x000000018B7E9620
		public static void CreateDefaultEventSystem() {} // 0x000000018B7E93E8-0x000000018B7E94E8
		private static void AddInputSystem(GameObject go) {} // 0x000000018B7E929C-0x000000018B7E92FC
		private static void AddLegacyInputSystem(GameObject go) {} // 0x000000018B7E92FC-0x000000018B7E9340
		public static List<OptionDefinition> ScanForOptions(object obj) => default; // 0x00000001840886B0-0x0000000184088A80
		public static string GetNumberString(int value, int max, string exceedsMaxString) => default; // 0x000000018B7E9620-0x000000018B7E9644
		public static void ConfigureCanvas(Canvas canvas) {} // 0x000000018B7E9340-0x000000018B7E93E8
	}
}

namespace SRDebugger.Profiler
{
	public class ProfilerLateUpdateListener : MonoBehaviour // TypeDefIndex: 57828
	{
		// Fields
		public Action OnLateUpdate; // 0x18
	
		// Constructors
		public ProfilerLateUpdateListener() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void LateUpdate() {} // 0x00000001850F1AC0-0x00000001850F1AE0
	}

	public class ProfilerServiceImpl : SRServiceBase<IProfilerService>, IProfilerService // TypeDefIndex: 57829
	{
		// Fields
		private float _AverageFrameTime_k__BackingField; // 0x48
		private float _LastFrameTime_k__BackingField; // 0x4C
		private const int FrameBufferSize = 400; // Metadata: 0x0207DB2D
		private readonly CircularBuffer<ProfilerFrame> _frameBuffer; // 0x50
		private ProfilerLateUpdateListener _lateUpdateListener; // 0x58
		private readonly Stopwatch _stopwatch; // 0x60
		private double _updateDuration; // 0x68
		private double _renderStartTime; // 0x70
		private double _renderDuration; // 0x78
		private int _camerasThisFrame; // 0x80
	
		// Properties
		public float AverageFrameTime { get; private set; } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public float LastFrameTime { get; private set; } // 0x0000000185FB1750-0x0000000185FB1760 0x0000000185FBFAC0-0x0000000185FBFAD0
		public CircularBuffer<ProfilerFrame> FrameBuffer { get => default; } // 0x0000000181460F60-0x0000000181460F70 
	
		// Constructors
		public ProfilerServiceImpl() {} // 0x000000018B7E6FC8-0x000000018B7E7084
	
		// Methods
		protected override void Awake() {} // 0x000000018B7E6888-0x000000018B7E6B8C
		protected override void Update() {} // 0x000000018B7E6E44-0x000000018B7E6FC8
		protected void PushFrame(double totalTime, double updateTime, double renderTime) {} // 0x000000018B7E6DA8-0x000000018B7E6E44
		private void OnLateUpdate() {} // 0x000000018B7E6D38-0x000000018B7E6DA8
		private void OnCameraPreRender(Camera cam) {} // 0x000000018B7E6CB8-0x000000018B7E6D38
		private void OnCameraPostRender(Camera cam) {} // 0x000000018B7E6C44-0x000000018B7E6CB8
		private void EndFrame() {} // 0x000000018B7E6B8C-0x000000018B7E6C44
	}

	public class SRPProfilerService : SRServiceBase<IProfilerService>, IProfilerService // TypeDefIndex: 57831
	{
		// Fields
		private float _AverageFrameTime_k__BackingField; // 0x48
		private float _LastFrameTime_k__BackingField; // 0x4C
		private const int FrameBufferSize = 400; // Metadata: 0x0207DB2F
		private readonly CircularBuffer<ProfilerFrame> _frameBuffer; // 0x50
		private ProfilerLateUpdateListener _lateUpdateListener; // 0x58
		private double _updateDuration; // 0x60
		private double _renderStartTime; // 0x68
		private double _renderDuration; // 0x70
		private readonly Stopwatch _stopwatch; // 0x78
	
		// Properties
		public float AverageFrameTime { get; private set; } // 0x0000000183F9E7C0-0x0000000183F9ED00 0x0000000184A82C40-0x0000000184A82CA0
		public float LastFrameTime { get; private set; } // 0x0000000183F9F110-0x0000000183F9F1D0 0x0000000183F9EF80-0x0000000183F9F000
		public CircularBuffer<ProfilerFrame> FrameBuffer { get => default; } // 0x0000000183F9DD80-0x0000000183F9DE00 
	
		// Nested types
		private sealed class _EndOfFrameCoroutine_d__19 : IEnumerator<object> // TypeDefIndex: 57830
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SRPProfilerService __4__this; // 0x20
			private WaitForEndOfFrame _endOfFrame_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FBFAC0-0x0000000185FBFAD0 
			object IEnumerator.Current { get => default; } // 0x0000000184A82A50-0x0000000184A82C40 
	
			// Constructors
			public _EndOfFrameCoroutine_d__19() {} // Dummy constructor
			public _EndOfFrameCoroutine_d__19(int __1__state) {} // 0x0000000185FB80E0-0x0000000185FB80F0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FBCE20-0x0000000185FBCE30
			private bool MoveNext() => default; // 0x0000000185FB1750-0x0000000185FB1760
			void IEnumerator.Reset() {} // 0x0000000181460F60-0x0000000181460F70
		}
	
		// Constructors
		public SRPProfilerService() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected override void Awake() {} // 0x0000000183F9EDA0-0x0000000183F9EF80
		protected override void Update() {} // 0x0000000185EDEBA0-0x0000000185EDEC60
		private IEnumerator EndOfFrameCoroutine() => default; // 0x0000000181378230-0x0000000181378240
		protected void PushFrame(double totalTime, double updateTime, double renderTime) {} // 0x0000000185492010-0x0000000185492020
		private void OnLateUpdate() {} // 0x0000000183F9F000-0x0000000183F9F110
		private void RenderPipelineOnBeginFrameRendering(ScriptableRenderContext context, List<Camera> cameras) {} // 0x0000000181377E40-0x0000000181377E50
		private void EndFrame() {} // 0x000000018B7EAD08-0x000000018B7EAD54
	}
}

namespace SRDebugger.Scripts
{
	public class DebuggerTabController : SRMonoBehaviourEx // TypeDefIndex: 57724
	{
		// Fields
		private SRTab _aboutTabInstance; // 0x48
		private DefaultTabs? _activeTab; // 0x50
		private bool _hasStarted; // 0x58
		public SRTab AboutTab; // 0x60
		public SRTabController TabController; // 0x68
	
		// Properties
		public DefaultTabs? ActiveTab { get => default; } // 0x000000018B7D5354-0x000000018B7D5478 
	
		// Constructors
		public DebuggerTabController() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Start() {} // 0x000000018B7D4F78-0x000000018B7D5354
		public bool OpenTab(DefaultTabs tab) => default; // 0x000000018B7D4D14-0x000000018B7D4F08
		public void ShowAboutTab() {} // 0x000000018B7D4F08-0x000000018B7D4F78
	}
}

namespace SRDebugger.Services
{
	public sealed class ConsoleFilterStateService // TypeDefIndex: 57786
	{
		// Fields
		private ConsoleStateChangedEventHandler FilterStateChange; // 0x10
		private bool[] _states; // 0x18
	
		// Events
		public event ConsoleStateChangedEventHandler FilterStateChange;
	
		// Constructors
		public ConsoleFilterStateService() {} // 0x000000018B7D2448-0x000000018B7D2530
	
		// Methods
		public void SetState(UnityEngine.LogType type, bool newState) {} // 0x000000018B7D23D8-0x000000018B7D2448
		public bool GetState(UnityEngine.LogType type) => default; // 0x000000018B7D235C-0x000000018B7D2398
		private static UnityEngine.LogType GetType(UnityEngine.LogType type) => default; // 0x000000018B7D2398-0x000000018B7D23D8
	}

	public delegate void BugReportCompleteCallback(bool didSucceed, string errorMessage); // TypeDefIndex: 57787; 0x00000001831C5680-0x00000001831C5690

	public delegate void BugReportProgressCallback(float progress); // TypeDefIndex: 57788; 0x00000001833EEC70-0x00000001833EEC80

	public interface IBugReportService // TypeDefIndex: 57789
	{
		// Properties
		bool IsUsable { get; }
	
		// Methods
		void SetHandler(IBugReporterHandler handler);
		void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, IProgress<float> progressCallback = null);
	}

	public delegate void ConsoleStateChangedEventHandler(UnityEngine.LogType logType, bool newState); // TypeDefIndex: 57790; 0x00000001831C5680-0x00000001831C5690

	public interface IConsoleFilterState // TypeDefIndex: 57791
	{
		// Events
		event ConsoleStateChangedEventHandler FilterStateChange;
	
		// Methods
		void SetConsoleFilterState(UnityEngine.LogType logType, bool enabled);
		bool GetConsoleFilterState(UnityEngine.LogType logType);
	}

	public delegate void ConsoleUpdatedEventHandler(IConsoleService console); // TypeDefIndex: 57792; 0x00000001833EEC70-0x00000001833EEC80

	public interface IConsoleService // TypeDefIndex: 57793
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

	public class ConsoleEntry // TypeDefIndex: 57794
	{
		// Fields
		private const int MessagePreviewLength = 180; // Metadata: 0x0207DAFC
		private const int StackTracePreviewLength = 120; // Metadata: 0x0207DAFE
		private string _messagePreview; // 0x10
		private string _stackTracePreview; // 0x18
		public int Count; // 0x20
		public UnityEngine.LogType LogType; // 0x24
		public string Message; // 0x28
		public string StackTrace; // 0x30
	
		// Properties
		public string MessagePreview { get => default; } // 0x000000018B7D21E4-0x000000018B7D22A0 
		public string StackTracePreview { get => default; } // 0x000000018B7D22A0-0x000000018B7D235C 
	
		// Constructors
		public ConsoleEntry() {} // 0x0000000185FBAD80-0x0000000185FBAD90
		public ConsoleEntry(ConsoleEntry other) {} // 0x000000018B7D2190-0x000000018B7D21E4
	
		// Methods
		public bool Matches(ConsoleEntry other) => default; // 0x000000018B7D2130-0x000000018B7D2190
	}

	public interface IDebugCameraService // TypeDefIndex: 57795
	{
		// Properties
		Camera Camera { get; }
	}

	public interface IDebugPanelService // TypeDefIndex: 57796
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

	public interface IDebugService // TypeDefIndex: 57797
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
		void AddSystemInfo(SRDebugger.InfoEntry entry, string category = "Default" /* Metadata: 0x0207DB00 */);
		void ShowDebugPanel(bool requireEntryCode = true /* Metadata: 0x0207DB08 */);
		void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = true /* Metadata: 0x0207DB09 */);
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
		void ShowBugReportSheet(ActionCompleteCallback onComplete = null, bool takeScreenshot = true /* Metadata: 0x0207DB0A */, string descriptionContent = null);
		RectTransform EnableWorldSpaceMode();
		void SetBugReporterHandler(IBugReporterHandler bugReporterHandler);
	}

	public interface IDebugTriggerService // TypeDefIndex: 57798
	{
		// Properties
		bool IsEnabled { get; set; }
		bool ShowErrorNotification { get; set; }
		PinAlignment Position { get; set; }
	}

	public interface IDockConsoleService // TypeDefIndex: 57799
	{
		// Properties
		bool IsVisible { get; set; }
		bool IsExpanded { get; set; }
		ConsoleAlignment Alignment { get; set; }
	}

	public interface IOptionsService // TypeDefIndex: 57800
	{
		// Properties
		ICollection<OptionDefinition> Options { get; }
	
		// Events
		event System.EventHandler OptionsUpdated;
	
		// Methods
		void Scan(object obj);
		void AddContainer(object obj);
		void AddContainer(IOptionContainer optionContainer);
		void RemoveContainer(object obj);
		void RemoveContainer(IOptionContainer optionContainer);
	}

	public delegate void PinEntryCompleteCallback(bool validPinEntered); // TypeDefIndex: 57801; 0x00000001833EEC70-0x00000001833EEC80

	public interface IPinEntryService // TypeDefIndex: 57802
	{
		// Properties
		bool IsShowingKeypad { get; }
	
		// Methods
		void ShowPinEntry(IReadOnlyList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true /* Metadata: 0x0207DB0B */);
	}

	public interface IPinnedUIService // TypeDefIndex: 57803
	{
		// Properties
		bool IsProfilerPinned { get; set; }
	
		// Events
		event Action<OptionDefinition, bool> OptionPinStateChanged;
		event Action<RectTransform> OptionsCanvasCreated;
	
		// Methods
		void Pin(OptionDefinition option, int order = -1 /* Metadata: 0x0207DB0C */);
		void Unpin(OptionDefinition option);
		void UnpinAll();
		bool HasPinned(OptionDefinition option);
	}

	public static class ProfilerServiceSelector // TypeDefIndex: 57804
	{
		// Methods
		public static System.Type GetProfilerServiceType() => default; // 0x00000001840165D0-0x0000000184016680
	}

	public struct ProfilerFrame // TypeDefIndex: 57805
	{
		// Fields
		public double FrameTime; // 0x00
		public double OtherTime; // 0x08
		public double RenderTime; // 0x10
		public double UpdateTime; // 0x18
	}

	public interface IProfilerService // TypeDefIndex: 57806
	{
		// Properties
		float AverageFrameTime { get; }
		float LastFrameTime { get; }
		CircularBuffer<ProfilerFrame> FrameBuffer { get; }
	}

	public interface ISystemInformationService // TypeDefIndex: 57807
	{
		// Methods
		IEnumerable<string> GetCategories();
		IList<SRDebugger.InfoEntry> GetInfo(string category);
		void Add(SRDebugger.InfoEntry info, string category = "Default" /* Metadata: 0x0207DB0D */);
		Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false /* Metadata: 0x0207DB15 */);
	}
}

namespace SRDebugger.Services.Implementation
{
	internal class BugReportApiService : IBugReportService // TypeDefIndex: 57809
	{
		// Fields
		private IBugReporterHandler _handler; // 0x10
	
		// Properties
		public bool IsUsable { get => default; } // 0x000000018B7D0044-0x000000018B7D0328 
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 57808
		{
			// Fields
			public BugReportCompleteCallback completeHandler; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018B7D0434-0x000000018B7D044C
	
			// Methods
			internal void _SendBugReport_b__0(BugReportSubmitResult result) {} // 0x000000018B7D0328-0x000000018B7D03E4
		}
	
		// Constructors
		public BugReportApiService() {} // 0x000000018B7E0C98-0x000000018B7E0CC8
	
		// Methods
		public void SetHandler(IBugReporterHandler handler) {} // 0x000000018B7D03E4-0x000000018B7D0434
		public void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, IProgress<float> progress = null) {} // 0x0000000185492010-0x0000000185492020
	}

	public class BugReportPopoverService : SRServiceBase<BugReportPopoverService> // TypeDefIndex: 57811
	{
		// Fields
		private BugReportCompleteCallback _callback; // 0x48
		private bool _isVisible; // 0x50
		private BugReportPopoverRoot _popover; // 0x58
		private BugReportSheetController _sheet; // 0x60
	
		// Properties
		public bool IsShowingPopover { get => default; } // 0x000000018B7D0E20-0x000000018B7D0EA0 
	
		// Nested types
		private sealed class _OpenCo_d__7 : IEnumerator<object> // TypeDefIndex: 57810
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public bool takeScreenshot; // 0x20
			public BugReportPopoverService __4__this; // 0x28
			public string descriptionText; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B7D0E04-0x000000018B7D0E20 
			object IEnumerator.Current { get => default; } // 0x000000018B7D0A00-0x000000018B7D0B64 
	
			// Constructors
			public _OpenCo_d__7() {} // Dummy constructor
			public _OpenCo_d__7(int __1__state) {} // 0x00000001813ECBE0-0x00000001813ECBF0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B7D0C6C-0x000000018B7D0E04
			private bool MoveNext() => default; // 0x000000018B7D0B64-0x000000018B7D0BE8
			void IEnumerator.Reset() {} // 0x000000018B7D0628-0x000000018B7D0670
		}
	
		// Constructors
		public BugReportPopoverService() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public void ShowBugReporter(BugReportCompleteCallback callback, bool takeScreenshotFirst = true /* Metadata: 0x0207DB16 */, string descriptionText = null) {} // 0x000000018B7D0BE8-0x000000018B7D0C6C
		private IEnumerator OpenCo(bool takeScreenshot, string descriptionText) => default; // 0x000000018B7D0594-0x000000018B7D0628
		private void SubmitComplete(bool didSucceed, string errorMessage) {} // 0x000000018B7D0670-0x000000018B7D0A00
		private void CancelPressed() {} // 0x000000018B7D0EA0-0x000000018B7D0ED4
		private void OnComplete(bool success, string errorMessage, bool close) {} // 0x0000000181378230-0x0000000181378240
		private void TakingScreenshot() {} // 0x0000000185492010-0x0000000185492020
		private void ScreenshotComplete() {} // 0x000000018B7E0398-0x000000018B7E04C0
		protected override void Awake() {} // 0x0000000181377E40-0x0000000181377E50
		private void Load() {} // 0x000000018B7E04C0-0x000000018B7E050C
	}

	public class DebugCameraServiceImpl : IDebugCameraService // TypeDefIndex: 57812
	{
		// Fields
		private Camera _debugCamera; // 0x10
	
		// Properties
		public Camera Camera { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public DebugCameraServiceImpl() {} // 0x000000018B7E19B0-0x000000018B7E1B2C
	}

	public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService, IDisposable // TypeDefIndex: 57813
	{
		// Fields
		private DebugPanelRoot _debugPanelRootObject; // 0x18
		private Action<IDebugPanelService, bool> VisibilityChanged; // 0x20
		private bool _isVisible; // 0x28
		private bool? _cursorWasVisible; // 0x29
		private CursorLockMode? _cursorLockMode; // 0x2C
	
		// Properties
		public DebugPanelRoot RootObject { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public bool IsLoaded { get => default; } // 0x000000018B7E1EC8-0x000000018B7E1F18 
		public bool IsVisible { get => default; set {} } // 0x000000018B7E1F18-0x000000018B7E1F38 0x000000018B7E1FC4-0x000000018B7E22D4
		public DefaultTabs? ActiveTab { get => default; } // 0x000000018B7E1E50-0x000000018B7E1EC8 
	
		// Events
		public event Action<IDebugPanelService, bool> VisibilityChanged;
	
		// Constructors
		public DebugPanelServiceImpl() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public void OpenTab(DefaultTabs tab) {} // 0x000000018B7E1D38-0x000000018B7E1D8C
		public void Unload() {} // 0x000000018B7E1D8C-0x000000018B7E1E50
		private void Load() {} // 0x000000018B7E1BB0-0x000000018B7E1D38
		public void Dispose() {} // 0x000000018B7E1B2C-0x000000018B7E1BB0
	}

	public class DebugTriggerImpl : SRServiceBase<IDebugTriggerService>, IDebugTriggerService // TypeDefIndex: 57814
	{
		// Fields
		private PinAlignment _position; // 0x48
		private TriggerRoot _trigger; // 0x50
		private IConsoleService _consoleService; // 0x58
		private bool _showErrorNotification; // 0x60
	
		// Properties
		public bool IsEnabled { get => default; set {} } // 0x000000018B7E29E4-0x000000018B7E2A60 0x000000018466EBD0-0x000000018466EC50
		public bool ShowErrorNotification { get => default; set {} } // 0x000000018386C570-0x000000018386C580 0x0000000184A81CD0-0x0000000184A81D70
		public PinAlignment Position { get => default; set {} } // 0x0000000185FB0570-0x0000000185FB0580 0x000000018466EC50-0x000000018466ECD0
	
		// Constructors
		public DebugTriggerImpl() {} // 0x0000000185FA13F0-0x0000000185FA1430
	
		// Methods
		protected override void Awake() {} // 0x0000000184A82890-0x0000000184A829B0
		private void OnError(IConsoleService console) {} // 0x000000018B7E2800-0x000000018B7E2874
		private void CreateTrigger() {} // 0x000000018B7E22D4-0x000000018B7E26E8
		protected override void OnDestroy() {} // 0x000000018B7E26F0-0x000000018B7E2800
		private static void OnActiveSceneChanged(Scene s1, Scene s2) {} // 0x000000018B7E26E8-0x000000018B7E26F0
		private void OnTriggerButtonClick() {} // 0x000000018B7E2874-0x000000018B7E2904
		private static void SetTriggerPosition(RectTransform t, PinAlignment position) {} // 0x000000018B7E2904-0x000000018B7E29E4
	}

	public class DockConsoleServiceImpl : IDockConsoleService // TypeDefIndex: 57815
	{
		// Fields
		private ConsoleAlignment _alignment; // 0x10
		private DockConsoleController _consoleRoot; // 0x18
		private bool _didSuspendTrigger; // 0x20
		private bool _isExpanded; // 0x21
		private bool _isVisible; // 0x22
	
		// Properties
		public bool IsVisible { get => default; set {} } // 0x00000001813FF330-0x00000001813FF340 0x000000018B7E2E58-0x000000018B7E2F04
		public bool IsExpanded { get => default; set {} } // 0x00000001813ECBD0-0x00000001813ECBE0 0x000000018B7E2DB8-0x000000018B7E2E58
		public ConsoleAlignment Alignment { get => default; set {} } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x000000018B7E2D30-0x000000018B7E2DB8
	
		// Constructors
		public DockConsoleServiceImpl() {} // 0x000000018B7E2D00-0x000000018B7E2D30
	
		// Methods
		private void Load() {} // 0x000000018B7E2B98-0x000000018B7E2D00
		private void CheckTrigger() {} // 0x000000018B7E2A60-0x000000018B7E2B98
	}

	public class KeyboardShortcutListenerService : SRServiceBase<KeyboardShortcutListenerService> // TypeDefIndex: 57816
	{
		// Fields
		private List<SRDebugger.Settings.KeyboardShortcut> _shortcuts; // 0x48
	
		// Constructors
		public KeyboardShortcutListenerService() {} // 0x000000018B7E3C78-0x000000018B7E3CAC
	
		// Methods
		protected override void Awake() {} // 0x000000018B7E2F98-0x000000018B7E33F8
		private void ToggleTab(DefaultTabs t) {} // 0x000000018B7E36DC-0x000000018B7E37FC
		private void ExecuteShortcut(SRDebugger.Settings.KeyboardShortcut shortcut) {} // 0x000000018B7E33F8-0x000000018B7E36DC
		protected override void Update() {} // 0x000000018B7E3C30-0x000000018B7E3C78
		private void UpdateInputSystem() {} // 0x000000018B7E37FC-0x000000018B7E3A88
		private void UpdateLegacyInputSystem() {} // 0x000000018B7E3A88-0x000000018B7E3C30
	}

	public sealed class OptionsServiceImpl : IOptionsService // TypeDefIndex: 57819
	{
		// Fields
		private System.EventHandler OptionsUpdated; // 0x10
		private readonly Dictionary<IOptionContainer, List<OptionDefinition>> _optionContainerLookup; // 0x18
		private readonly Dictionary<IOptionContainer, OptionContainerEventHandler> _optionContainerEventHandlerLookup; // 0x20
		private readonly List<OptionDefinition> _options; // 0x28
		private readonly IList<OptionDefinition> _optionsReadonly; // 0x30
	
		// Properties
		public ICollection<OptionDefinition> Options { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Events
		public event System.EventHandler OptionsUpdated;
	
		// Nested types
		private class OptionContainerEventHandler : IDisposable // TypeDefIndex: 57817
		{
			// Fields
			private readonly OptionsServiceImpl _service; // 0x10
			private readonly IOptionContainer _container; // 0x18
	
			// Constructors
			public OptionContainerEventHandler() {} // Dummy constructor
			public OptionContainerEventHandler(OptionsServiceImpl service, IOptionContainer container) {} // 0x000000018B7E50E0-0x000000018B7E5174
	
			// Methods
			private void ContainerOnOptionAdded(OptionDefinition obj) {} // 0x000000018B7E5174-0x000000018B7E5208
			private void ContainerOnOptionRemoved(OptionDefinition obj) {} // 0x00000001813B51D0-0x00000001813B51E0
			public void Dispose() {} // 0x000000018B7E4B54-0x000000018B7E4C98
		}
	
		private class ReflectionOptionContainer : IOptionContainer // TypeDefIndex: 57818
		{
			// Fields
			private List<OptionDefinition> _options; // 0x10
			private readonly object _target; // 0x18
	
			// Properties
			public bool IsDynamic { get => default; } // 0x0000000184088AC0-0x0000000184088C70 
			private List<OptionDefinition> Options { get => default; } // 0x000000018B7E4DB0-0x000000018B7E4E4C 
	
			// Events
			public event Action<OptionDefinition> OptionAdded;
			public event Action<OptionDefinition> OptionRemoved;
	
			// Constructors
			public ReflectionOptionContainer() {} // Dummy constructor
			public ReflectionOptionContainer(object target) {} // 0x000000018B7E4AE8-0x000000018B7E4B54
	
			// Methods
			public IEnumerable<OptionDefinition> GetOptions() => default; // 0x000000018B7E4E4C-0x000000018B7E50D8
			protected bool Equals(ReflectionOptionContainer other) => default; // 0x000000018B7E3E70-0x000000018B7E3FF0
			public override bool Equals(object obj) => default; // 0x000000018B7E3CAC-0x000000018B7E3CD8
			public override int GetHashCode() => default; // 0x000000018B7E3CD8-0x000000018B7E3D04
		}
	
		// Constructors
		public OptionsServiceImpl() {} // 0x00000001814A81B0-0x00000001814A81C0
	
		// Methods
		private void OptionsContainerOnOptionAdded(IOptionContainer container, OptionDefinition optionDefinition) {} // 0x0000000185492010-0x0000000185492020
		private void OptionsContainerOnOptionRemoved(IOptionContainer container, OptionDefinition optionDefinition) {} // 0x0000000185492010-0x0000000185492020
		public void Scan(object obj) {} // 0x0000000184088A80-0x0000000184088AC0
		public void AddContainer(object obj) {} // 0x000000018646D96C-0x000000018646D974
		public void AddContainer(IOptionContainer optionContainer) {} // 0x0000000184088E70-0x0000000184088E80
		public void RemoveContainer(object obj) {} // 0x000000018B7E7138-0x000000018B7E7160
		public void RemoveContainer(IOptionContainer optionContainer) {} // 0x000000018B7E7084-0x000000018B7E7138
		private void OnOptionsUpdated() {} // 0x0000000185FAB1F0-0x0000000185FAB220
	}

	public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService // TypeDefIndex: 57820
	{
		// Fields
		private PinEntryCompleteCallback _callback; // 0x48
		private bool _isVisible; // 0x50
		private PinEntryControl _pinControl; // 0x58
		private readonly List<int> _requiredPin; // 0x60
	
		// Properties
		public bool IsShowingKeypad { get => default; } // 0x00000001813ECBE0-0x00000001813ECBF0 
	
		// Constructors
		public PinEntryServiceImpl() {} // 0x000000018B7E5868-0x000000018B7E58F8
	
		// Methods
		public void ShowPinEntry(IReadOnlyList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true /* Metadata: 0x0207DB17 */) {} // 0x000000018B7E54EC-0x000000018B7E570C
		protected override void Awake() {} // 0x000000018B7E5208-0x000000018B7E529C
		private void Load() {} // 0x000000018B7E529C-0x000000018B7E5428
		private void PinControlOnComplete(IList<int> result, bool didCancel) {} // 0x000000018B7E5428-0x000000018B7E54EC
		private void VerifyPin(IReadOnlyList<int> pin) {} // 0x000000018B7E570C-0x000000018B7E5868
	}

	public class PinnedUIServiceImpl : SRServiceBase<IPinnedUIService>, IPinnedUIService // TypeDefIndex: 57821
	{
		// Fields
		private readonly List<OptionsControlBase> _controlList; // 0x48
		private readonly Dictionary<OptionDefinition, OptionsControlBase> _pinnedObjects; // 0x50
		private bool _queueRefresh; // 0x58
		private PinnedUIRoot _uiRoot; // 0x60
		private Action<OptionDefinition, bool> OptionPinStateChanged; // 0x68
		private Action<RectTransform> OptionsCanvasCreated; // 0x70
	
		// Properties
		public DockConsoleController DockConsoleController { get => default; } // 0x000000018B7E65F4-0x000000018B7E6668 
		public bool IsProfilerPinned { get => default; set {} } // 0x000000018B7E6668-0x000000018B7E66E0 0x000000018B7E67F8-0x000000018B7E6888
	
		// Events
		public event Action<OptionDefinition, bool> OptionPinStateChanged;
		public event Action<RectTransform> OptionsCanvasCreated;
	
		// Constructors
		public PinnedUIServiceImpl() {} // 0x0000000185EBF430-0x0000000185EBF510
	
		// Methods
		public void Pin(OptionDefinition obj, int order = -1 /* Metadata: 0x0207DB18 */) {} // 0x000000018B7E5DA4-0x000000018B7E5F34
		public void Unpin(OptionDefinition obj) {} // 0x000000018B7E616C-0x000000018B7E6290
		private void OnPinnedStateChanged(OptionDefinition option, bool isPinned) {} // 0x000000018B7E5D90-0x000000018B7E5DA4
		public void UnpinAll() {} // 0x000000018B7E5FB4-0x000000018B7E616C
		public bool HasPinned(OptionDefinition option) => default; // 0x000000018B7E58F8-0x000000018B7E594C
		protected override void Awake() {} // 0x0000000184A829B0-0x0000000184A82A50
		private void Load() {} // 0x000000018B7E594C-0x000000018B7E5BDC
		private void UpdateAnchors() {} // 0x000000018B7E6290-0x000000018B7E6568
		protected override void Update() {} // 0x00000001852B42F0-0x00000001852B4310
		private void OnOptionsUpdated(object sender, EventArgs eventArgs) {} // 0x000000018B7E5BE8-0x000000018B7E5D90
		private void OnDebugPanelVisibilityChanged(bool isVisible) {} // 0x000000018B7E5BDC-0x000000018B7E5BE8
		private void Refresh() {} // 0x000000018B7E5F34-0x000000018B7E5FB4
	}

	public class SRDebugService : IDebugService // TypeDefIndex: 57823
	{
		// Fields
		private VisibilityChangedDelegate PanelVisibilityChanged; // 0x10
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
		public IDockConsoleService DockConsole { get => default; } // 0x000000018B7E8C24-0x000000018B7E8CB8 
		public IConsoleFilterState ConsoleFilter { get => default; } // 0x000000018B7E8EC8-0x000000018B7E8F5C 
		public SRDebugger.Settings Settings { get => default; } // 0x000000018B7E8E4C-0x000000018B7E8E68 
		public bool IsDebugPanelVisible { get => default; } // 0x000000018B7E9074-0x000000018B7E9090 
		public bool IsTriggerEnabled { get => default; set {} } // 0x000000018B7E8E68-0x000000018B7E8EC8 0x000000018B7E9090-0x000000018B7E910C
		public bool IsTriggerErrorNotificationEnabled { get => default; set {} } // 0x000000018B7E8DD8-0x000000018B7E8E4C 0x000000018B7E8FF0-0x000000018B7E9074
		public bool IsProfilerDocked { get => default; set {} } // 0x000000018B7E7A94-0x000000018B7E7B18 0x000000018B7E8774-0x000000018B7E87E0
	
		// Events
		public event VisibilityChangedDelegate PanelVisibilityChanged;
		public event PinnedUiCanvasCreated PinnedUiCanvasCreated;
	
		// Nested types
		private sealed class __c__DisplayClass51_0 // TypeDefIndex: 57822
		{
			// Fields
			public ActionCompleteCallback onComplete; // 0x10
	
			// Constructors
			public __c__DisplayClass51_0() {} // 0x000000018B7E8DB4-0x000000018B7E8DBC
	
			// Methods
			internal void _ShowBugReportSheet_b__0(bool succeed, string message) {} // 0x000000018B7E8D4C-0x000000018B7E8DB4
		}
	
		// Constructors
		public SRDebugService() {} // 0x000000018B7E8DBC-0x000000018B7E8DD8
	
		// Methods
		public void AddSystemInfo(SRDebugger.InfoEntry entry, string category = "Default" /* Metadata: 0x0207DB19 */) {} // 0x000000018B7E8680-0x000000018B7E8774
		public void ShowDebugPanel(bool requireEntryCode = true /* Metadata: 0x0207DB21 */) {} // 0x000000018B7E7F00-0x000000018B7E7F20
		public void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = true /* Metadata: 0x0207DB22 */) {} // 0x000000018B7E8500-0x000000018B7E8564
		public void HideDebugPanel() {} // 0x0000000185FD5E10-0x0000000185FD5E20
		public void SetEntryCode(EntryCode newCode) {} // 0x000000018B7E7C54-0x000000018B7E7CD4
		public void DisableEntryCode() {} // 0x000000018B7E791C-0x000000018B7E7998
		public void DestroyDebugPanel() {} // 0x000000018B7E83B4-0x000000018B7E8430
		public void AddOptionContainer(object container) {} // 0x000000018B7E7998-0x000000018B7E7A94
		public void RemoveOptionContainer(object container) {} // 0x000000018B7E8430-0x000000018B7E8448
		public void AddOption(OptionDefinition option) {} // 0x000000018B7E7F20-0x000000018B7E8094
		public bool RemoveOption(OptionDefinition option) => default; // 0x000000018B7E893C-0x000000018B7E8AB0
		public void PinAllOptions(string category) {} // 0x000000018B7E8094-0x000000018B7E8208
		public void UnpinAllOptions(string category) {} // 0x000000018B7E8AB0-0x000000018B7E8C24
		public void PinOption(string name) {} // 0x000000018B7E7B18-0x000000018B7E7B84
		public void UnpinOption(string name) {} // 0x000000018B7E8564-0x000000018B7E8680
		public void ClearPinnedOptions() {} // 0x000000018B7E7B84-0x000000018B7E7C54
		public void ShowBugReportSheet(ActionCompleteCallback onComplete = null, bool takeScreenshot = true /* Metadata: 0x0207DB23 */, string descriptionContent = null) {} // 0x000000018B7E8208-0x000000018B7E83B4
		private void DebugPanelServiceOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) {} // 0x000000018B7E7CD4-0x000000018B7E7F00
		private void PromptEntryCode() {} // 0x000000018B7E8448-0x000000018B7E8500
		public RectTransform EnableWorldSpaceMode() => default; // 0x000000018B7E8888-0x000000018B7E893C
		public void SetBugReporterHandler(IBugReporterHandler bugReporterHandler) {} // 0x000000018B7E87E0-0x000000018B7E8888
		private void _.ctor_b__21_0(RectTransform transform) {} // 0x0000000185492010-0x0000000185492020
		private void _PromptEntryCode_b__53_0(bool entered) {} // 0x000000018B7EB8F4-0x000000018B7EB90C
	}

	public class StandardConsoleService : IConsoleService, IDisposable // TypeDefIndex: 57824
	{
		// Fields
		private readonly bool _collapseEnabled; // 0x10
		private bool _hasCleared; // 0x11
		private readonly CircularBuffer<ConsoleEntry> _allConsoleEntries; // 0x18
		private CircularBuffer<ConsoleEntry> _consoleEntries; // 0x20
		private readonly object _threadLock; // 0x28
		private ILogHandler _expectedLogHandler; // 0x30
		private int _CriticalCount_k__BackingField; // 0x38
		private int _ErrorCount_k__BackingField; // 0x3C
		private int _WarningCount_k__BackingField; // 0x40
		private int _InfoCount_k__BackingField; // 0x44
		private ConsoleUpdatedEventHandler Updated; // 0x48
		private ConsoleUpdatedEventHandler Error; // 0x50
	
		// Properties
		public int CriticalCount { get; private set; } // 0x00000001813E5E30-0x00000001813E5E40 0x00000001813E6F50-0x00000001813E6F60
		public int ErrorCount { get; private set; } // 0x0000000185FB0790-0x0000000185FB07A0 0x0000000185FB07A0-0x0000000185FB07B0
		public int WarningCount { get; private set; } // 0x00000001813ECF10-0x00000001813ECF20 0x00000001813EE9C0-0x00000001813EE9D0
		public int InfoCount { get; private set; } // 0x0000000183908D10-0x0000000183908D20 0x0000000183909010-0x0000000183909020
		public bool LoggingEnabled { get => default; set {} } // 0x000000018B7EA234-0x000000018B7EA288 0x000000018B7EA3B0-0x000000018B7EA44C
		public bool LogHandlerIsOverriden { get => default; } // 0x000000018B7EA1DC-0x000000018B7EA234 
		public IReadOnlyList<ConsoleEntry> Entries { get => default; } // 0x000000018B7EA1CC-0x000000018B7EA1DC 
		public IReadOnlyList<ConsoleEntry> AllEntries { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Events
		public event ConsoleUpdatedEventHandler Updated;
		public event ConsoleUpdatedEventHandler Error;
	
		// Constructors
		public StandardConsoleService() {} // 0x0000000184A8F620-0x0000000184A8F7E0
	
		// Methods
		public void Dispose() {} // 0x000000018B7E9D38-0x000000018B7E9DEC
		public void Clear() {} // 0x000000018B7E9B78-0x000000018B7E9D38
		protected void OnEntryAdded(ConsoleEntry entry) {} // 0x000000018B7E9DEC-0x000000018B7E9F5C
		protected void OnEntryDuplicated(ConsoleEntry entry) {} // 0x000000018B7E9F5C-0x000000018B7EA010
		private void OnUpdated() {} // 0x000000018B7EA010-0x000000018B7EA0A4
		private void UnityLogCallback(string condition, string stackTrace, UnityEngine.LogType type) {} // 0x0000000185492010-0x0000000185492020
		private void AdjustCounter(UnityEngine.LogType type, int amount) {} // 0x000000018B7E9B00-0x000000018B7E9B78
	}

	public class StandardSystemInformationService : ISystemInformationService // TypeDefIndex: 57827
	{
		// Fields
		private readonly Dictionary<string, IList<SRDebugger.InfoEntry>> _info; // 0x10
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 57825
		{
			// Fields
			public SRDebugger.InfoEntry info; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x0000000185F4E830-0x0000000185F4E8B0
	
			// Methods
			internal bool _Add_b__0(SRDebugger.InfoEntry p) => default; // 0x000000018B7EAA60-0x000000018B7EAAA8
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 57826
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
			static __c() {} // 0x000000018B7EABFC-0x000000018B7EAD08
			public __c() {} // 0x000000018B7EA44C-0x000000018B7EA658
	
			// Methods
			internal object _CreateDefaultSet_b__6_0() => default; // 0x000000018B7EA658-0x000000018B7EAA60
			internal object _CreateDefaultSet_b__6_1() => default; // 0x0000000183FC5480-0x0000000183FC9AD0
			internal object _CreateDefaultSet_b__6_2() => default; // 0x000000018B7EAAA8-0x000000018B7EABFC
			internal object _CreateDefaultSet_b__6_3() => default; // 0x0000000185492010-0x0000000185492020
			internal object _CreateDefaultSet_b__6_4() => default; // 0x000000018B7EB8C4-0x000000018B7EB8F4
			internal object _CreateDefaultSet_b__6_5() => default; // 0x0000000185F72670-0x0000000185F726D0
			internal object _CreateDefaultSet_b__6_6() => default; // 0x0000000185492010-0x0000000185492020
			internal object _CreateDefaultSet_b__6_7() => default; // 0x000000018B7EB520-0x000000018B7EB590
			internal object _CreateDefaultSet_b__6_8() => default; // 0x000000018B7EB590-0x000000018B7EB5D4
		}
	
		// Constructors
		public StandardSystemInformationService() {} // 0x000000018B7EB5D4-0x000000018B7EB618
	
		// Methods
		public IEnumerable<string> GetCategories() => default; // 0x000000018B7EB618-0x000000018B7EB65C
		public IList<SRDebugger.InfoEntry> GetInfo(string category) => default; // 0x000000018B7EB65C-0x000000018B7EB6A0
		public void Add(SRDebugger.InfoEntry info, string category = "Default" /* Metadata: 0x0207DB24 */) {} // 0x000000018B7EB6A0-0x000000018B7EB6E4
		public Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false /* Metadata: 0x0207DB2C */) => default; // 0x000000018B7EB6E4-0x000000018B7EB728
		private void CreateDefaultSet() {} // 0x000000018B7EB728-0x000000018B7EB82C
		private static string GetCloudManifestPrettyName(string name) => default; // 0x000000018B7EB82C-0x000000018B7EB8C4
	}
}

namespace SRDebugger.UI
{
	public class ProfilerFPSLabel : SRMonoBehaviourEx // TypeDefIndex: 57725
	{
		// Fields
		private float _nextUpdate; // 0x48
		private IProfilerService _profilerService; // 0x50
		public float UpdateFrequency; // 0x58
		private UnityEngine.UI.Text _text; // 0x60
	
		// Constructors
		public ProfilerFPSLabel() {} // 0x000000018B7DCBD8-0x000000018B7DCBE8
	
		// Methods
		protected override void Update() {} // 0x000000018B7DCBAC-0x000000018B7DCBD8
		private void Refresh() {} // 0x000000018B7DCAA0-0x000000018B7DCBAC
	}

	public class DebugPanelRoot : SRMonoBehaviourEx // TypeDefIndex: 57726
	{
		// Fields
		public Canvas Canvas; // 0x48
		public CanvasGroup CanvasGroup; // 0x50
		public DebuggerTabController TabController; // 0x58
	
		// Constructors
		public DebugPanelRoot() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void Close() {} // 0x000000018B7D4C80-0x000000018B7D4D14
		public void CloseAndDestroy() {} // 0x000000018B7D4C24-0x000000018B7D4C80
	}

	public class MobileMenuController : SRMonoBehaviourEx // TypeDefIndex: 57727
	{
		// Fields
		private UnityEngine.UI.Button _closeButton; // 0x48
		private float _maxMenuWidth; // 0x50
		private float _peekAmount; // 0x54
		private float _targetXPosition; // 0x58
		public RectTransform Content; // 0x60
		public RectTransform Menu; // 0x68
		public UnityEngine.UI.Button OpenButton; // 0x70
		public SRTabController TabController; // 0x78
	
		// Properties
		public float PeekAmount { get => default; } // 0x0000000183F80440-0x0000000183F80450 
		public float MaxMenuWidth { get => default; } // 0x0000000185FB3000-0x0000000185FB3010 
	
		// Constructors
		public MobileMenuController() {} // 0x000000018B7D880C-0x000000018B7D8824
	
		// Methods
		protected override void OnEnable() {} // 0x000000018B7D8394-0x000000018B7D8610
		protected override void OnDisable() {} // 0x000000018B7D825C-0x000000018B7D8394
		private void CreateCloseButton() {} // 0x000000018B7D7EA8-0x000000018B7D825C
		private void SetRectSize(RectTransform rect) {} // 0x000000018B7D8668-0x000000018B7D871C
		private void CloseButtonClicked() {} // 0x000000018B7D7E68-0x000000018B7D7E70
		protected override void Update() {} // 0x000000018B7D871C-0x000000018B7D880C
		private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab) {} // 0x000000018B7D7E68-0x000000018B7D7E70
		public void Open() {} // 0x000000018B7D8610-0x000000018B7D8668
		public void Close() {} // 0x000000018B7D7E70-0x000000018B7D7EA8
	}
}

namespace SRDebugger.UI.Controls
{
	public class ConsoleEntryView : SRMonoBehaviourEx, SRF.UI.Layout.IVirtualView // TypeDefIndex: 57761
	{
		// Fields
		public const string ConsoleBlobInfo = "Console_Info_Blob"; // Metadata: 0x0207DA9D
		public const string ConsoleBlobWarning = "Console_Warning_Blob"; // Metadata: 0x0207DAAF
		public const string ConsoleBlobError = "Console_Error_Blob"; // Metadata: 0x0207DAC4
		public const string ConsoleBlobCritical = "Console_Critical_Blob"; // Metadata: 0x0207DAD7
		private int _count; // 0x48
		private bool _hasCount; // 0x4C
		private ConsoleEntry _prevData; // 0x50
		private RectTransform _rectTransform; // 0x58
		public UnityEngine.UI.Text Count; // 0x60
		public CanvasGroup CountContainer; // 0x68
		public StyleComponent ImageStyle; // 0x70
		public UnityEngine.UI.Text Message; // 0x78
		public UnityEngine.UI.Text StackTrace; // 0x80
	
		// Constructors
		public ConsoleEntryView() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void SetDataContext(object data) {} // 0x000000018B7D1DF4-0x000000018B7D2130
		protected override void Awake() {} // 0x000000018B7D1D50-0x000000018B7D1DF4
	}

	public class ConsoleLogControl : SRMonoBehaviourEx // TypeDefIndex: 57763
	{
		// Fields
		private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup; // 0x48
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
		public bool ShowCriticals { get => default; set {} } // 0x0000000185FD5D70-0x0000000185FD5D80 0x0000000185FD5DB0-0x0000000185FD5DC0
		public bool ShowErrors { get => default; set {} } // 0x000000018B7D2D84-0x000000018B7D2DA4 0x000000018B7D2DA4-0x000000018B7D2DC4
		public bool ShowWarnings { get => default; set {} } // 0x0000000183060C50-0x0000000183060C60 0x000000018B7D2DC4-0x000000018B7D2E00
		public bool ShowInfo { get => default; set {} } // 0x000000018B7D2868-0x000000018B7D2980 0x000000018B7D2CC0-0x000000018B7D2CE8
		public bool EnableSelection { get => default; set {} } // 0x000000018B7D2C64-0x000000018B7D2CC0 0x000000018B7D2980-0x000000018B7D2A20
		public string Filter { get => default; set {} } // 0x000000018B7D2A20-0x000000018B7D2A7C 0x000000018B7D2CE8-0x000000018B7D2D74
	
		// Nested types
		private sealed class _ScrollToBottom_d__30 : IEnumerator<object> // TypeDefIndex: 57762
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ConsoleLogControl __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FD5DA0-0x0000000185FD5DB0 
			object IEnumerator.Current { get => default; } // 0x0000000185FD5DC0-0x0000000185FD5DD0 
	
			// Constructors
			public _ScrollToBottom_d__30() {} // Dummy constructor
			public _ScrollToBottom_d__30(int __1__state) {} // 0x0000000185FB09E0-0x0000000185FB09F0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FD5D90-0x0000000185FD5DA0
			private bool MoveNext() => default; // 0x0000000185FB09C0-0x0000000185FB09D0
			void IEnumerator.Reset() {} // 0x0000000185FD5D80-0x0000000185FD5D90
		}
	
		// Constructors
		public ConsoleLogControl() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected override void Awake() {} // 0x000000018B7D2A7C-0x000000018B7D2C64
		protected override void Start() {} // 0x0000000183F76C40-0x0000000183F76C50
		private IEnumerator ScrollToBottom() => default; // 0x0000000183F76C40-0x0000000183F76C50
		protected override void OnDestroy() {} // 0x000000018B7D2D74-0x000000018B7D2D84
		private void OnSelectedItemChanged(object arg0) {} // 0x0000000181378230-0x0000000181378240
		protected override void Update() {} // 0x0000000185492010-0x0000000185492020
		private void Refresh() {} // 0x000000018B7E050C-0x000000018B7E0624
		private void SetIsDirty() {} // 0x0000000181377E40-0x0000000181377E50
		private void ConsoleOnUpdated(IConsoleService console) {} // 0x000000018B7E0624-0x000000018B7E0670
	}

	public abstract class DataBoundControl : OptionsControlBase // TypeDefIndex: 57764
	{
		// Fields
		private bool _hasStarted; // 0x60
		private bool _isReadOnly; // 0x61
		private object _prevValue; // 0x68
		private PropertyReference _prop; // 0x70
		private string _PropertyName_k__BackingField; // 0x78
	
		// Properties
		public PropertyReference Property { get; } // 0x0000000181460F70-0x0000000181460F80 
		public bool IsReadOnly { get; } // 0x0000000185FB32C0-0x0000000185FB32D0 
		public string PropertyName { get; private set; } // 0x0000000183060C50-0x0000000183060C60 0x000000018738A324-0x000000018738A334
	
		// Constructors
		protected DataBoundControl() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void Bind(string propertyName, PropertyReference prop) {} // 0x000000018B7D4768-0x000000018B7D4860
		private void OnValueChanged(PropertyReference property) {} // 0x000000018A3B3758-0x000000018A3B3768
		protected void UpdateValue(object newValue) {} // 0x000000018B7D4AC8-0x000000018B7D4B14
		public override void Refresh() {} // 0x000000018B7D49A4-0x000000018B7D4AA8
		protected virtual void OnBind(string propertyName, System.Type t) {} // 0x0000000185492010-0x0000000185492020
		protected abstract void OnValueUpdated(object newValue);
		public abstract bool CanBind(System.Type type, bool isReadOnly);
		protected override void Start() {} // 0x000000018B7D4AA8-0x000000018B7D4AC8
		protected override void OnEnable() {} // 0x000000018B7D48F4-0x000000018B7D49A4
		protected override void OnDisable() {} // 0x000000018B7D4860-0x000000018B7D48F4
	}

	public abstract class OptionsControlBase : SRMonoBehaviourEx // TypeDefIndex: 57765
	{
		// Fields
		private bool _selectionModeEnabled; // 0x48
		public Toggle SelectionModeToggle; // 0x50
		public OptionDefinition Option; // 0x58
	
		// Properties
		public bool SelectionModeEnabled { get; set; } // 0x0000000185FB0750-0x0000000185FB0760 0x000000018B7D9B14-0x000000018B7D9C10
		public bool IsSelected { get; set; } // 0x000000018B7D9A1C-0x000000018B7D9A3C 0x000000018B7D9A3C-0x000000018B7D9B14
	
		// Constructors
		protected OptionsControlBase() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Awake() {} // 0x000000018B7D990C-0x000000018B7D995C
		protected override void OnEnable() {} // 0x000000018B7D995C-0x000000018B7D9A1C
		public virtual void Refresh() {} // 0x0000000185492010-0x0000000185492020
	}

	public class InfoBlock : SRMonoBehaviourEx // TypeDefIndex: 57766
	{
		// Fields
		public UnityEngine.UI.Text Content; // 0x48
		public UnityEngine.UI.Text Title; // 0x50
	
		// Constructors
		public InfoBlock() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class MultiTapButton : UnityEngine.UI.Button // TypeDefIndex: 57767
	{
		// Fields
		private float _lastTap; // 0x188
		private int _tapCount; // 0x18C
		public int RequiredTapCount; // 0x190
		public float ResetTime; // 0x194
	
		// Constructors
		public MultiTapButton() {} // 0x000000018B7D8898-0x000000018B7D88B4
	
		// Methods
		public override void OnPointerClick(PointerEventData eventData) {} // 0x000000018B7D8824-0x000000018B7D8898
	}

	public delegate void PinEntryControlCallback(IList<int> result, bool didCancel); // TypeDefIndex: 57768; 0x00000001831C5680-0x00000001831C5690

	public class PinEntryControl : SRMonoBehaviourEx // TypeDefIndex: 57770
	{
		// Fields
		private bool _isVisible; // 0x48
		private List<int> _numbers; // 0x50
		public Image Background; // 0x58
		public bool CanCancel; // 0x60
		public UnityEngine.UI.Button CancelButton; // 0x68
		public UnityEngine.UI.Text CancelButtonText; // 0x70
		public CanvasGroup CanvasGroup; // 0x78
		public Animator DotAnimator; // 0x80
		public UnityEngine.UI.Button[] NumberButtons; // 0x88
		public Toggle[] NumberDots; // 0x90
		public UnityEngine.UI.Text PromptText; // 0x98
		private PinEntryControlCallback Complete; // 0xA0
	
		// Events
		public event PinEntryControlCallback Complete;
	
		// Nested types
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 57769
		{
			// Fields
			public int number; // 0x10
			public PinEntryControl __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass14_0() {} // 0x000000018B7DC6EC-0x000000018B7DC784
	
			// Methods
			internal void _Awake_b__0() {} // 0x000000018B7DC784-0x000000018B7DC81C
		}
	
		// Constructors
		public PinEntryControl() {} // 0x000000018B7E0C18-0x000000018B7E0C40
	
		// Methods
		protected override void Awake() {} // 0x000000018B7DC208-0x000000018B7DC29C
		protected override void OnEnable() {} // 0x000000018B7DC588-0x000000018B7DC660
		protected override void OnDisable() {} // 0x000000018B7DC034-0x000000018B7DC0B4
		protected override void Update() {} // 0x000000018B7DC528-0x000000018B7DC588
		private void HandleCharacter(char i) {} // 0x000000018B7DC0B4-0x000000018B7DC110
		public void Show() {} // 0x000000018B7DBFE8-0x000000018B7DC034
		public void Hide() {} // 0x000000018B7DC330-0x000000018B7DC37C
		public void Clear() {} // 0x000000018B7DC16C-0x000000018B7DC208
		public void PlayInvalidCodeAnimation() {} // 0x000000018B7DC110-0x000000018B7DC16C
		protected void OnComplete() {} // 0x000000018B7DBF78-0x000000018B7DBFE8
		protected void OnCancel() {} // 0x000000018B7DC37C-0x000000018B7DC43C
		private void CancelButtonPressed() {} // 0x000000018B7DC43C-0x000000018B7DC528
		public void PushNumber(int number) {} // 0x000000018B7DC660-0x000000018B7DC6EC
		private void RefreshState() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ProfilerMemoryBlock : SRMonoBehaviourEx // TypeDefIndex: 57772
	{
		// Fields
		private float _lastRefresh; // 0x48
		public UnityEngine.UI.Text CurrentUsedText; // 0x50
		public Slider Slider; // 0x58
		public UnityEngine.UI.Text TotalAllocatedText; // 0x60
	
		// Nested types
		private sealed class _CleanUp_d__8 : IEnumerator<object> // TypeDefIndex: 57771
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ProfilerMemoryBlock __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B7DE158-0x000000018B7DE17C 
			object IEnumerator.Current { get => default; } // 0x000000018646DB20-0x000000018646DB28 
	
			// Constructors
			public _CleanUp_d__8() {} // Dummy constructor
			public _CleanUp_d__8(int __1__state) {} // 0x000000018B7DE150-0x000000018B7DE158
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B7DE340-0x000000018B7DE3C0
			private bool MoveNext() => default; // 0x000000018B7DE17C-0x000000018B7DE340
			void IEnumerator.Reset() {} // 0x000000018B7DE0F4-0x000000018B7DE150
		}
	
		// Constructors
		public ProfilerMemoryBlock() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected override void OnEnable() {} // 0x0000000181378230-0x0000000181378240
		protected override void Update() {} // 0x0000000185492010-0x0000000185492020
		public void TriggerRefresh() {} // 0x000000018B7E00CC-0x000000018B7E0174
		public void TriggerCleanup() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator CleanUp() => default; // 0x000000018B7E0174-0x000000018B7E01C0
	}

	public class ProfilerMonoBlock : SRMonoBehaviourEx // TypeDefIndex: 57773
	{
		// Fields
		private float _lastRefresh; // 0x48
		public UnityEngine.UI.Text CurrentUsedText; // 0x50
		public GameObject NotSupportedMessage; // 0x58
		public Slider Slider; // 0x60
		public UnityEngine.UI.Text TotalAllocatedText; // 0x68
		private bool _isSupported; // 0x70
	
		// Constructors
		public ProfilerMonoBlock() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void OnEnable() {} // 0x000000018B7DE3C0-0x000000018B7DE428
		protected override void Update() {} // 0x000000018B7DE66C-0x000000018B7DE6EC
		public void TriggerRefresh() {} // 0x000000018B7DE478-0x000000018B7DE66C
		public void TriggerCollection() {} // 0x000000018B7DE428-0x000000018B7DE478
	}

	public class ProfilerEnableControl : SRMonoBehaviourEx // TypeDefIndex: 57774
	{
		// Fields
		private bool _previousState; // 0x48
		public UnityEngine.UI.Text ButtonText; // 0x50
		public UnityEngine.UI.Button EnableButton; // 0x58
		public UnityEngine.UI.Text Text; // 0x60
	
		// Constructors
		public ProfilerEnableControl() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Start() {} // 0x000000018B7DC81C-0x000000018B7DC918
		protected void UpdateLabels() {} // 0x000000018B7DC974-0x000000018B7DCA74
		protected override void Update() {} // 0x000000018B7DCA74-0x000000018B7DCAA0
		public void ToggleProfiler() {} // 0x000000018B7DC918-0x000000018B7DC974
	}

	public class ProfilerGraphAxisLabel : SRMonoBehaviourEx // TypeDefIndex: 57775
	{
		// Fields
		private float _prevFrameTime; // 0x48
		private float? _queuedFrameTime; // 0x4C
		private float _yPosition; // 0x54
		public UnityEngine.UI.Text Text; // 0x58
	
		// Constructors
		public ProfilerGraphAxisLabel() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Update() {} // 0x000000018B7DCE1C-0x000000018B7DCE80
		public void SetValue(float frameTime, float yPosition) {} // 0x000000018B7DCDA0-0x000000018B7DCE1C
		private void SetValueInternal(float frameTime) {} // 0x000000018B7DCBE8-0x000000018B7DCDA0
	}

	public class ProfilerGraphControl : Graphic // TypeDefIndex: 57777
	{
		// Fields
		public VerticalAlignments VerticalAlignment; // 0xB0
		private static readonly float[] ScaleSteps; // 0x00
		public bool FloatingScale; // 0xB4
		public bool TargetFpsUseApplication; // 0xB5
		public bool DrawAxes; // 0xB6
		public int TargetFps; // 0xB8
		public bool Clip; // 0xBC
		public const float DataPointMargin = 2f; // Metadata: 0x0207DAED
		public const float DataPointVerticalMargin = 2f; // Metadata: 0x0207DAF1
		public const float DataPointWidth = 4f; // Metadata: 0x0207DAF5
		public int VerticalPadding; // 0xC0
		public const int LineCount = 3; // Metadata: 0x0207DAF9
		public UnityEngine.Color[] LineColours; // 0xC8
		private IProfilerService _profilerService; // 0xD0
		private ProfilerGraphAxisLabel[] _axisLabels; // 0xD8
		private Rect _clipBounds; // 0xE0
		private readonly List<Vector3> _meshVertices; // 0xF0
		private readonly List<Color32> _meshVertexColors; // 0xF8
		private readonly List<int> _meshTriangles; // 0x100
	
		// Nested types
		public enum VerticalAlignments // TypeDefIndex: 57776
		{
			Top = 0,
			Bottom = 1
		}
	
		// Constructors
		public ProfilerGraphControl() {} // 0x000000018B7DDF5C-0x000000018B7DE0F4
		static ProfilerGraphControl() {} // 0x000000018B7DDED0-0x000000018B7DDF5C
	
		// Methods
		protected override void Awake() {} // 0x000000018B7DD1B8-0x000000018B7DD21C
		protected override void Start() {} // 0x0000000185492010-0x0000000185492020
		protected void Update() {} // 0x000000018B7DDEC0-0x000000018B7DDED0
		protected override void OnPopulateMesh(Mesh m) {} // 0x000000018B7DD9D4-0x000000018B7DDEC0
		protected void DrawDataPoint(float xPosition, float verticalScale, ProfilerFrame frame) {} // 0x000000018B7DD4E8-0x000000018B7DD7D4
		protected void DrawAxis(float frameTime, float yPosition, ProfilerGraphAxisLabel label) {} // 0x000000018B7DD2E0-0x000000018B7DD4E8
		protected void AddRect(Vector3 tl, Vector3 tr, Vector3 bl, Vector3 br, UnityEngine.Color c) {} // 0x000000018B7DCE80-0x000000018B7DD1B8
		protected ProfilerFrame GetFrame(int i) => default; // 0x000000018B7DD948-0x000000018B7DD9D4
		protected int CalculateVisibleDataPointCount() => default; // 0x000000018B7DD2A4-0x000000018B7DD2E0
		protected int GetFrameBufferCurrentSize() => default; // 0x000000018B7DD8A4-0x000000018B7DD8F0
		protected int GetFrameBufferMaxSize() => default; // 0x000000018B7DD8F0-0x000000018B7DD948
		protected float CalculateMaxFrameTime() => default; // 0x000000018B7DD21C-0x000000018B7DD2A4
		private ProfilerGraphAxisLabel GetAxisLabel(int index) => default; // 0x000000018B7DD7D4-0x000000018B7DD8A4
	}

	public class SRTabButton : SRMonoBehaviourEx // TypeDefIndex: 57778
	{
		// Fields
		public UnityEngine.Behaviour ActiveToggle; // 0x48
		public UnityEngine.UI.Button Button; // 0x50
		public RectTransform ExtraContentContainer; // 0x58
		public StyleComponent IconStyleComponent; // 0x60
		public UnityEngine.UI.Text TitleText; // 0x68
	
		// Properties
		public bool IsActive { get => default; set {} } // 0x000000018B7DEA88-0x000000018B7DEAA8 0x000000018B7DEAA8-0x000000018B7DEAC8
	
		// Constructors
		public SRTabButton() {} // 0x000000018646DB20-0x000000018646DB28
	}
}

namespace SRDebugger.UI.Controls.Data
{
	public class ActionControl : OptionsControlBase // TypeDefIndex: 57779
	{
		// Fields
		private MethodReference _method; // 0x60
		public UnityEngine.UI.Button Button; // 0x68
		public UnityEngine.UI.Text Title; // 0x70
	
		// Properties
		public MethodReference Method { get => default; } // 0x0000000185FB0530-0x0000000185FB0540 
	
		// Constructors
		public ActionControl() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Start() {} // 0x000000018B7CFD8C-0x000000018B7CFE28
		private void ButtonOnClick() {} // 0x000000018B7CFC3C-0x000000018B7CFD54
		public void SetMethod(string methodName, MethodReference method) {} // 0x000000018B7CFD54-0x000000018B7CFD8C
	}

	public class BoolControl : DataBoundControl // TypeDefIndex: 57780
	{
		// Fields
		public UnityEngine.UI.Text Title; // 0x80
		public Toggle Toggle; // 0x88
	
		// Constructors
		public BoolControl() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Start() {} // 0x000000018B7CFF34-0x000000018B7CFFEC
		private void ToggleOnValueChanged(bool isOn) {} // 0x000000018B7CFFEC-0x000000018B7D0044
		protected override void OnBind(string propertyName, System.Type t) {} // 0x000000018B7CFE8C-0x000000018B7CFED0
		protected override void OnValueUpdated(object newValue) {} // 0x000000018B7CFED0-0x000000018B7CFF34
		public override bool CanBind(System.Type type, bool isReadOnly) => default; // 0x000000018B7CFE28-0x000000018B7CFE8C
	}

	public class EnumControl : DataBoundControl // TypeDefIndex: 57781
	{
		// Fields
		private object _lastValue; // 0x80
		private string[] _names; // 0x88
		private Array _values; // 0x90
		public LayoutElement ContentLayoutElement; // 0x98
		public GameObject[] DisableOnReadOnly; // 0xA0
		public SRSpinner Spinner; // 0xA8
		public UnityEngine.UI.Text Title; // 0xB0
		public UnityEngine.UI.Text Value; // 0xB8
	
		// Constructors
		public EnumControl() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Start() {} // 0x000000018B7D4AA8-0x000000018B7D4AC8
		protected override void OnBind(string propertyName, System.Type t) {} // 0x000000018B7D69CC-0x000000018B7D6C28
		protected override void OnValueUpdated(object newValue) {} // 0x000000018B7D6C28-0x000000018B7D6CE4
		public override bool CanBind(System.Type type, bool isReadOnly) => default; // 0x000000018B4E6B54-0x000000018B4E6B74
		private void SetIndex(int i) {} // 0x000000018B7D6CE4-0x000000018B7D6D28
		public void GoToNext() {} // 0x000000018B7D6904-0x000000018B7D6968
		public void GoToPrevious() {} // 0x000000018B7D6968-0x000000018B7D69CC
	}

	public class NumberControl : DataBoundControl // TypeDefIndex: 57783
	{
		// Fields
		private static readonly System.Type[] IntegerTypes; // 0x00
		private static readonly System.Type[] DecimalTypes; // 0x08
		public static readonly Dictionary<System.Type, ValueRange> ValueRanges; // 0x10
		private string _lastValue; // 0x80
		private System.Type _type; // 0x88
		public GameObject[] DisableOnReadOnly; // 0x90
		public SRNumberButton DownNumberButton; // 0x98
		public SRNumberSpinner NumberSpinner; // 0xA0
		public UnityEngine.UI.Text Title; // 0xA8
		public SRNumberButton UpNumberButton; // 0xB0
	
		// Nested types
		public struct ValueRange // TypeDefIndex: 57782
		{
			// Fields
			public double MaxValue; // 0x00
			public double MinValue; // 0x08
		}
	
		// Constructors
		public NumberControl() {} // 0x000000018646DB20-0x000000018646DB28
		static NumberControl() {} // 0x000000018B7D9388-0x000000018B7D9808
	
		// Methods
		protected override void Start() {} // 0x000000018B7D92D0-0x000000018B7D9388
		private void OnValueChanged(string newValue) {} // 0x000000018B7D9054-0x000000018B7D91C8
		protected override void OnBind(string propertyName, System.Type t) {} // 0x000000018B7D8CE0-0x000000018B7D9054
		protected override void OnValueUpdated(object newValue) {} // 0x000000018B7D91C8-0x000000018B7D92D0
		public override bool CanBind(System.Type type, bool isReadOnly) => default; // 0x000000018B7D88B4-0x000000018B7D8918
		protected static bool IsIntegerType(System.Type t) => default; // 0x000000018B7D8C1C-0x000000018B7D8CE0
		protected static bool IsDecimalType(System.Type t) => default; // 0x000000018B7D8B58-0x000000018B7D8C1C
		protected double GetMaxValue(System.Type t) => default; // 0x000000018B7D8918-0x000000018B7D8A38
		protected double GetMinValue(System.Type t) => default; // 0x000000018B7D8A38-0x000000018B7D8B58
	}

	public class ReadOnlyControl : DataBoundControl // TypeDefIndex: 57784
	{
		// Fields
		public UnityEngine.UI.Text ValueText; // 0x80
		public UnityEngine.UI.Text Title; // 0x88
	
		// Constructors
		public ReadOnlyControl() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Start() {} // 0x000000018B7D4AA8-0x000000018B7D4AC8
		protected override void OnBind(string propertyName, System.Type t) {} // 0x000000018B7DE900-0x000000018B7DE924
		protected override void OnValueUpdated(object newValue) {} // 0x000000018B7DE924-0x000000018B7DE990
		public override bool CanBind(System.Type type, bool isReadOnly) => default; // 0x000000018B7DE880-0x000000018B7DE900
	}

	public class StringControl : DataBoundControl // TypeDefIndex: 57785
	{
		// Fields
		public InputField InputField; // 0x80
		public UnityEngine.UI.Text Title; // 0x88
	
		// Constructors
		public StringControl() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Start() {} // 0x000000018B7E0014-0x000000018B7E00CC
		private void OnValueChanged(string newValue) {} // 0x000000018B7DFF84-0x000000018B7DFF8C
		protected override void OnBind(string propertyName, System.Type t) {} // 0x000000018B7DFEF8-0x000000018B7DFF84
		protected override void OnValueUpdated(object newValue) {} // 0x000000018B7DFF8C-0x000000018B7E0014
		public override bool CanBind(System.Type type, bool isReadOnly) => default; // 0x000000018B7DFE7C-0x000000018B7DFEF8
	}
}

namespace SRDebugger.UI.Other
{
	public class BugReportPopoverRoot : SRMonoBehaviourEx // TypeDefIndex: 57738
	{
		// Fields
		public CanvasGroup CanvasGroup; // 0x48
		public RectTransform Container; // 0x50
	
		// Constructors
		public BugReportPopoverRoot() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class BugReportSheetController : SRMonoBehaviourEx // TypeDefIndex: 57740
	{
		// Fields
		public GameObject ButtonContainer; // 0x48
		public UnityEngine.UI.Text ButtonText; // 0x50
		public UnityEngine.UI.Button CancelButton; // 0x58
		public Action CancelPressed; // 0x60
		public InputField DescriptionField; // 0x68
		public InputField EmailField; // 0x70
		public Slider ProgressBar; // 0x78
		public UnityEngine.UI.Text ResultMessageText; // 0x80
		public Action ScreenshotComplete; // 0x88
		public UnityEngine.UI.Button SubmitButton; // 0x90
		public Action<bool, string> SubmitComplete; // 0x98
		public Action TakingScreenshot; // 0xA0
	
		// Properties
		public bool IsCancelButtonEnabled { get => default; set {} } // 0x000000018B7D1150-0x000000018B7D1174 0x000000018B7D1094-0x000000018B7D1150
	
		// Nested types
		private sealed class _SubmitCo_d__18 : IEnumerator<object> // TypeDefIndex: 57739
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public BugReportSheetController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B7D1404-0x000000018B7D14E8 
			object IEnumerator.Current { get => default; } // 0x000000018B7D13A8-0x000000018B7D1404 
	
			// Constructors
			public _SubmitCo_d__18() {} // Dummy constructor
			public _SubmitCo_d__18(int __1__state) {} // 0x000000018B7D14E8-0x000000018B7D1518
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B7D1518-0x000000018B7D1550
			private bool MoveNext() => default; // 0x000000018B7D137C-0x000000018B7D13A8
			void IEnumerator.Reset() {} // 0x000000018B7D0F50-0x000000018B7D0F64
		}
	
		// Constructors
		public BugReportSheetController() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected override void Start() {} // 0x000000018B7D1224-0x000000018B7D127C
		public void Submit() {} // 0x000000018B7D0FD4-0x000000018B7D104C
		public void Cancel() {} // 0x000000018B7D127C-0x000000018B7D137C
		private IEnumerator SubmitCo() => default; // 0x000000018B7D0F64-0x000000018B7D0FD4
		private void OnBugReportProgress(float progress) {} // 0x000000018B7D11B8-0x000000018B7D1224
		private void OnBugReportComplete(bool didSucceed, string errorMessage) {} // 0x000000018B7D104C-0x000000018B7D1094
		protected void SetLoadingSpinnerVisible(bool visible) {} // 0x000000018B7D1174-0x000000018B7D11B8
		protected void ClearForm() {} // 0x000000018646DB20-0x000000018646DB28
		protected void ShowErrorMessage(string userMessage, string serverMessage = null) {} // 0x0000000181378230-0x0000000181378240
		protected void ClearErrorMessage() {} // 0x0000000185492010-0x0000000185492020
		protected void SetFormEnabled(bool e) {} // 0x000000018B7E0670-0x000000018B7E0AA8
		private string GetDefaultEmailFieldContents() => default; // 0x0000000181377E40-0x0000000181377E50
		private void SetDefaultEmailFieldContents(string value) {} // 0x000000018B7E0AA8-0x000000018B7E0AF4
	}

	public class CategoryGroup : SRMonoBehaviourEx // TypeDefIndex: 57741
	{
		// Fields
		public RectTransform Container; // 0x48
		public UnityEngine.UI.Text Header; // 0x50
		public GameObject Background; // 0x58
		public Toggle SelectionToggle; // 0x60
		public GameObject[] EnabledDuringSelectionMode; // 0x68
		private bool _selectionModeEnabled; // 0x70
	
		// Properties
		public bool IsSelected { get => default; set {} } // 0x000000018B7D18C0-0x000000018B7D18E0 0x000000018B7D18E0-0x000000018B7D19B8
		public bool SelectionModeEnabled { get => default; set {} } // 0x0000000185FB0950-0x0000000185FB0960 0x000000018B7D19B8-0x000000018B7D1A18
	
		// Constructors
		public CategoryGroup() {} // 0x000000018B7D186C-0x000000018B7D18C0
	}

	public class ConfigureCanvasFromSettings : SRMonoBehaviour // TypeDefIndex: 57742
	{
		// Fields
		private Canvas _canvas; // 0x48
		private CanvasScaler _canvasScaler; // 0x50
		private float _originalScale; // 0x58
		private float _lastSetScale; // 0x5C
		private SRDebugger.Settings _settings; // 0x60
	
		// Constructors
		public ConfigureCanvasFromSettings() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Start() {} // 0x000000018B7D1BD4-0x000000018B7D1D50
		private void OnDestroy() {} // 0x000000018B7D1AA8-0x000000018B7D1B68
		private void SettingsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) {} // 0x000000018B7D1B68-0x000000018B7D1BD4
	}

	public class ConsoleTabQuickViewControl : SRMonoBehaviourEx // TypeDefIndex: 57743
	{
		// Fields
		private const int Max = 1000; // Metadata: 0x0207DA8E
		private static readonly string MaxString; // 0x00
		private int _prevCriticalCount; // 0x48
		private int _prevErrorCount; // 0x4C
		private int _prevInfoCount; // 0x50
		private int _prevWarningCount; // 0x54
		public IConsoleService ConsoleService; // 0x58
		public UnityEngine.UI.Text CriticalCountText; // 0x60
		public UnityEngine.UI.Text ErrorCountText; // 0x68
		public UnityEngine.UI.Text InfoCountText; // 0x70
		public UnityEngine.UI.Text WarningCountText; // 0x78
	
		// Constructors
		public ConsoleTabQuickViewControl() {} // 0x000000018B7D4750-0x000000018B7D4768
		static ConsoleTabQuickViewControl() {} // 0x000000018B7D46D4-0x000000018B7D4750
	
		// Methods
		protected override void Awake() {} // 0x000000018B7D4380-0x000000018B7D4420
		protected override void Update() {} // 0x000000018B7D4450-0x000000018B7D46D4
		private static bool HasChanged(int newCount, ref int oldCount, int max) => default; // 0x000000018B7D4420-0x000000018B7D4450
	}

	public class DebugPanelBackgroundBehaviour : SRMonoBehaviour // TypeDefIndex: 57744
	{
		// Fields
		private StyleComponent _styleComponent; // 0x48
		public string TransparentStyleKey; // 0x50
		private StyleSheet _styleSheet; // 0x58
	
		// Constructors
		public DebugPanelBackgroundBehaviour() {} // 0x000000018B7D4BDC-0x000000018B7D4C24
	
		// Methods
		private void Awake() {} // 0x000000018B7D4B14-0x000000018B7D4BDC
	}

	public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 57745
	{
		// Fields
		public const float NonFocusOpacity = 0.65f; // Metadata: 0x0207DA90
		private bool _isDirty; // 0x48
		private bool _isDragging; // 0x49
		private int _pointersOver; // 0x4C
		public IConsoleFilterState FilterState; // 0x50
		public GameObject BottomHandle; // 0x58
		public CanvasGroup CanvasGroup; // 0x60
		public ConsoleLogControl Console; // 0x68
		public GameObject Dropdown; // 0x70
		public Image DropdownToggleSprite; // 0x78
		public UnityEngine.UI.Text TextCriticals; // 0x80
		public UnityEngine.UI.Text TextErrors; // 0x88
		public UnityEngine.UI.Text TextInfo; // 0x90
		public UnityEngine.UI.Text TextWarnings; // 0x98
		public Toggle ToggleCriticals; // 0xA0
		public Toggle ToggleErrors; // 0xA8
		public Toggle ToggleInfo; // 0xB0
		public Toggle ToggleWarnings; // 0xB8
		public GameObject TopBar; // 0xC0
		public GameObject TopHandle; // 0xC8
		public GameObject TopSafeAreaSpacer; // 0xD0
		public GameObject BottomSafeAreaSpacer; // 0xD8
	
		// Properties
		public bool IsVisible { get => default; set {} } // 0x000000018B7D6188-0x000000018B7D61AC 0x000000018B7D61AC-0x000000018B7D61DC
	
		// Constructors
		public DockConsoleController() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Start() {} // 0x000000018B7D5C38-0x000000018B7D5FD4
		protected override void OnDestroy() {} // 0x000000018B7D54F8-0x000000018B7D55EC
		protected override void OnEnable() {} // 0x000000018B7D55EC-0x000000018B7D5600
		protected override void OnDisable() {} // 0x0000000185FD5DE0-0x0000000185FD5DF0
		protected override void Update() {} // 0x000000018B7D6178-0x000000018B7D6188
		private void OnFilterStateChange(UnityEngine.LogType logType, bool newState) {} // 0x000000018B7D5614-0x000000018B7D5674
		private void ConsoleOnUpdated(IConsoleService console) {} // 0x0000000185FD46B0-0x0000000185FD46C0
		public void SetDropdownVisibility(bool visible) {} // 0x000000018B7D5BAC-0x000000018B7D5C38
		public void SetAlignmentMode(ConsoleAlignment alignment) {} // 0x000000018B7D5910-0x000000018B7D5BAC
		private void Refresh() {} // 0x000000018B7D56DC-0x000000018B7D5910
		private void RefreshAlpha() {} // 0x000000018B7D5694-0x000000018B7D56DC
		public void ToggleDropdownVisible() {} // 0x000000018B7D5FD4-0x000000018B7D6008
		public void MenuButtonPressed() {} // 0x000000018B7D549C-0x000000018B7D54EC
		public void ClearButtonPressed() {} // 0x000000018B7D5478-0x000000018B7D549C
		public void TogglesUpdated() {} // 0x000000018B7D6008-0x000000018B7D60B8
		public void OnPointerEnter(PointerEventData e) {} // 0x000000018B7D5674-0x000000018B7D5684
		public void OnPointerExit(PointerEventData e) {} // 0x000000018B7D5684-0x000000018B7D5694
		public void OnBeginDrag() {} // 0x000000018B7D54EC-0x000000018B7D54F8
		public void OnEndDrag() {} // 0x000000018B7D5600-0x000000018B7D5614
		private void _Start_b__25_0(bool isOn) {} // 0x000000018B7D60B8-0x000000018B7D60E8
		private void _Start_b__25_1(bool isOn) {} // 0x000000018B7D60E8-0x000000018B7D6118
		private void _Start_b__25_2(bool isOn) {} // 0x000000018B7D6118-0x000000018B7D6148
		private void _Start_b__25_3(bool isOn) {} // 0x000000018B7D6148-0x000000018B7D6178
	}

	public class ErrorNotifier : MonoBehaviour // TypeDefIndex: 57746
	{
		// Fields
		private const float DisplayTime = 6f; // Metadata: 0x0207DA94
		private Animator _animator; // 0x18
		private int _triggerHash; // 0x20
		private float _hideTime; // 0x24
		private bool _isShowing; // 0x28
		private bool _queueWarning; // 0x29
	
		// Properties
		public bool IsVisible { get => default; } // 0x00000001813B31B0-0x00000001813B31C0 
	
		// Constructors
		public ErrorNotifier() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Awake() {} // 0x000000018B7D6D28-0x000000018B7D6D64
		public void ShowErrorWarning() {} // 0x0000000185FD5DF0-0x0000000185FD5E00
		private void Update() {} // 0x000000018B7D6D64-0x000000018B7D6DE8
	}

	public class FloatOverElement : UIBehaviour, ILayoutSelfController // TypeDefIndex: 57747
	{
		// Fields
		public RectTransform CopyFrom; // 0x18
		private DrivenRectTransformTracker _tracker; // 0x20
	
		// Constructors
		public FloatOverElement() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Copy() {} // 0x000000018B7D6DE8-0x000000018B7D6F94
		public void SetLayoutHorizontal() {} // 0x000000018B7D6F94-0x000000018B7D6F9C
		public void SetLayoutVertical() {} // 0x000000018B7D6F94-0x000000018B7D6F9C
	}

	public class HandleManager : SRMonoBehaviour // TypeDefIndex: 57748
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
		public HandleManager() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Start() {} // 0x000000018B7D71F8-0x000000018B7D720C
		public void SetAlignment(PinAlignment alignment) {} // 0x000000018B7D700C-0x000000018B7D71F8
		private void SetActive(GameObject obj, bool active) {} // 0x000000018B7D6F9C-0x000000018B7D700C
	}

	public interface IEnableTab // TypeDefIndex: 57749
	{
		// Properties
		bool IsEnabled { get; }
	}

	public class LoadingSpinnerBehaviour : SRMonoBehaviour // TypeDefIndex: 57750
	{
		// Fields
		private float _dt; // 0x48
		public int FrameCount; // 0x4C
		public float SpinDuration; // 0x50
	
		// Constructors
		public LoadingSpinnerBehaviour() {} // 0x000000018B7D7E50-0x000000018B7D7E68
	
		// Methods
		private void Update() {} // 0x000000018B7D7D44-0x000000018B7D7E50
	}

	public class PinnedUIRoot : SRMonoBehaviourEx // TypeDefIndex: 57751
	{
		// Fields
		public Canvas Canvas; // 0x48
		public RectTransform Container; // 0x50
		public DockConsoleController DockConsoleController; // 0x58
		public GameObject Options; // 0x60
		public FlowLayoutGroup OptionsLayoutGroup; // 0x68
		public GameObject Profiler; // 0x70
		public HandleManager ProfilerHandleManager; // 0x78
		public VerticalLayoutGroup ProfilerVerticalLayoutGroup; // 0x80
	
		// Constructors
		public PinnedUIRoot() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class SafeAreaSizer : UIBehaviour, ILayoutElement // TypeDefIndex: 57752
	{
		// Fields
		private RectTransform.Edge _edge; // 0x18
		public float Scale; // 0x1C
		private float _height; // 0x20
		private float _width; // 0x24
	
		// Properties
		public RectTransform.Edge Edge { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x000000018B7DF814-0x000000018B7DF8A0
		public float preferredWidth { get => default; } // 0x0000000185FB3810-0x0000000185FB3820 
		public float preferredHeight { get => default; } // 0x0000000181C9AC70-0x0000000181C9AC80 
		public float minWidth { get => default; } // 0x0000000185FB3810-0x0000000185FB3820 
		public float minHeight { get => default; } // 0x0000000181C9AC70-0x0000000181C9AC80 
		public int layoutPriority { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		public float flexibleHeight { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public float flexibleWidth { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
	
		// Constructors
		public SafeAreaSizer() {} // 0x0000000185D78B50-0x0000000185D78B60
	
		// Methods
		private void Refresh() {} // 0x000000018B7DF574-0x000000018B7DF814
		public void CalculateLayoutInputHorizontal() {} // 0x000000018B7DF548-0x000000018B7DF574
		public void CalculateLayoutInputVertical() {} // 0x000000018B7DF548-0x000000018B7DF574
	}

	public class ScrollSettingsBehaviour : MonoBehaviour // TypeDefIndex: 57753
	{
		// Fields
		public const float ScrollSensitivity = 40f; // Metadata: 0x0207DA98
	
		// Constructors
		public ScrollSettingsBehaviour() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Awake() {} // 0x000000018B7DF8A0-0x000000018B7DF904
	}

	public class SetLayerFromSettings : SRMonoBehaviour // TypeDefIndex: 57754
	{
		// Constructors
		public SetLayerFromSettings() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Start() {} // 0x000000018B7DF904-0x000000018B7DF940
	}

	public class SRTab : SRMonoBehaviourEx // TypeDefIndex: 57755
	{
		// Fields
		public RectTransform HeaderExtraContent; // 0x48
		public Sprite Icon; // 0x50
		public RectTransform IconExtraContent; // 0x58
		public string IconStyleKey; // 0x60
		public int SortIndex; // 0x68
		public SRTabButton TabButton; // 0x70
		private string _title; // 0x78
		private string _longTitle; // 0x80
		private string _key; // 0x88
	
		// Properties
		public string Title { get => default; } // 0x0000000183060C50-0x0000000183060C60 
		public string LongTitle { get => default; } // 0x000000018B7DF530-0x000000018B7DF548 
		public string Key { get => default; } // 0x0000000185FB0510-0x0000000185FB0520 
	
		// Constructors
		public SRTab() {} // 0x000000018B7DF4E8-0x000000018B7DF530
	}

	public class SRTabController : SRMonoBehaviourEx // TypeDefIndex: 57758
	{
		// Fields
		private readonly SRList<SRTab> _tabs; // 0x48
		private SRTab _activeTab; // 0x50
		public RectTransform TabButtonContainer; // 0x58
		public SRTabButton TabButtonPrefab; // 0x60
		public RectTransform TabContentsContainer; // 0x68
		public RectTransform TabHeaderContentContainer; // 0x70
		public UnityEngine.UI.Text TabHeaderText; // 0x78
		private Action<SRTabController, SRTab> ActiveTabChanged; // 0x80
	
		// Properties
		public SRTab ActiveTab { get => default; set {} } // 0x000000018B7DEAC8-0x000000018B7DEDD4 0x000000018B7DEDD4-0x000000018B7DF13C
		public IList<SRTab> Tabs { get => default; } // 0x000000018B7DF13C-0x000000018B7DF314 
	
		// Events
		public event Action<SRTabController, SRTab> ActiveTabChanged;
	
		// Nested types
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 57756
		{
			// Fields
			public SRTabController __4__this; // 0x10
			public SRTab tab; // 0x18
	
			// Constructors
			public __c__DisplayClass15_0() {} // 0x0000000181460F60-0x0000000181460F70
	
			// Methods
			internal void _AddTab_b__0() {} // 0x000000018B7DF4E0-0x000000018B7DF4E8
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 57757
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<SRTab> __9__17_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018B7DF408-0x000000018B7DF450
			public __c() {} // 0x000000018B7DF378-0x000000018B7DF408
	
			// Methods
			internal int _SortTabs_b__17_0(SRTab t1, SRTab t2) => default; // 0x000000018B7DF450-0x000000018B7DF4E0
		}
	
		// Constructors
		public SRTabController() {} // 0x000000018B7E0BDC-0x000000018B7E0C08
	
		// Methods
		public void AddTab(SRTab tab, bool visibleInSidebar = true /* Metadata: 0x0207DA9C */) {} // 0x000000018B7E0C40-0x000000018B7E0C68
		private void MakeActive(SRTab tab) {} // 0x000000018B7E0D90-0x000000018B7E0DF4
		private void SortTabs() {} // 0x0000000185492010-0x0000000185492020
	}

	public class TriggerRoot : SRMonoBehaviourEx // TypeDefIndex: 57759
	{
		// Fields
		public Canvas Canvas; // 0x48
		public LongPressButton TapHoldButton; // 0x50
		public RectTransform TriggerTransform; // 0x58
		public ErrorNotifier ErrorNotifier; // 0x60
		public MultiTapButton TripleTapButton; // 0x68
	
		// Constructors
		public TriggerRoot() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class VersionTextBehaviour : SRMonoBehaviourEx // TypeDefIndex: 57760
	{
		// Fields
		public string Format; // 0x48
		public UnityEngine.UI.Text Text; // 0x50
	
		// Constructors
		public VersionTextBehaviour() {} // 0x000000018B7E0E58-0x000000018B7E0EA0
	
		// Methods
		protected override void Start() {} // 0x000000018B7E0DF4-0x000000018B7E0E58
	}
}

namespace SRDebugger.UI.Tabs
{
	public class BugReportTabController : SRMonoBehaviourEx, IEnableTab // TypeDefIndex: 57728
	{
		// Fields
		public BugReportSheetController BugReportSheetPrefab; // 0x48
		public RectTransform Container; // 0x50
	
		// Properties
		public bool IsEnabled { get => default; } // 0x000000018B7D17C8-0x000000018B7D186C 
	
		// Constructors
		public BugReportTabController() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Start() {} // 0x000000018B7D164C-0x000000018B7D177C
		private void TakingScreenshot() {} // 0x000000018B7D177C-0x000000018B7D17C8
		private void ScreenshotComplete() {} // 0x000000018B7D1600-0x000000018B7D164C
	}

	public class ConsoleTabController : SRMonoBehaviourEx // TypeDefIndex: 57731
	{
		// Fields
		private const int MaxLength = 2600; // Metadata: 0x0207DA7D
		private Canvas _consoleCanvas; // 0x48
		private bool _isDirty; // 0x50
		private static bool _hasWarnedAboutLogHandler; // 0x00
		private static bool _hasWarnedAboutLoggingDisabled; // 0x01
		public IConsoleFilterState FilterState; // 0x58
		public ConsoleLogControl ConsoleLogControl; // 0x60
		public Toggle PinToggle; // 0x68
		public ScrollRect StackTraceScrollRect; // 0x70
		public UnityEngine.UI.Text StackTraceText; // 0x78
		public Toggle ToggleCriticals; // 0x80
		public UnityEngine.UI.Text ToggleCriticalsText; // 0x88
		public Toggle ToggleErrors; // 0x90
		public UnityEngine.UI.Text ToggleErrorsText; // 0x98
		public Toggle ToggleInfo; // 0xA0
		public UnityEngine.UI.Text ToggleInfoText; // 0xA8
		public Toggle ToggleWarnings; // 0xB0
		public UnityEngine.UI.Text ToggleWarningsText; // 0xB8
		public GameObject CopyToClipboardContainer; // 0xC0
		public GameObject CopyToClipboardButton; // 0xC8
		public GameObject CopyToClipboardMessage; // 0xD0
		public CanvasGroup CopyToClipboardMessageCanvasGroup; // 0xD8
		public GameObject LoggingIsDisabledCanvasGroup; // 0xE0
		public GameObject LogHandlerHasBeenOverridenGroup; // 0xE8
		public Toggle FilterToggle; // 0xF0
		public InputField FilterField; // 0xF8
		public GameObject FilterBarContainer; // 0x100
		private ConsoleEntry _selectedItem; // 0x108
		private Coroutine _fadeButtonCoroutine; // 0x110
	
		// Nested types
		public enum CopyToClipboardStates // TypeDefIndex: 57729
		{
			Hidden = 0,
			Visible = 1,
			Activated = 2
		}
	
		private sealed class _FadeCopyButton_d__44 : IEnumerator<object> // TypeDefIndex: 57730
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public ConsoleTabController __4__this; // 0x20
			private float _startTime_5__2; // 0x28
			private float _endTime_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B7D30C8-0x000000018B7D3144 
			object IEnumerator.Current { get => default; } // 0x000000018B7D34D8-0x000000018B7D3504 
	
			// Constructors
			public _FadeCopyButton_d__44() {} // Dummy constructor
			public _FadeCopyButton_d__44(int __1__state) {} // 0x000000018B7D3C1C-0x000000018B7D4254
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B7D33DC-0x000000018B7D343C
			private bool MoveNext() => default; // 0x000000018B7D3048-0x000000018B7D30C8
			void IEnumerator.Reset() {} // 0x000000018B7D343C-0x000000018B7D34D8
		}
	
		// Constructors
		public ConsoleTabController() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Start() {} // 0x000000018B7D32D4-0x000000018B7D33D4
		private void OnFilterStateChange(UnityEngine.LogType logtype, bool newstate) {} // 0x0000000185FD5DD0-0x0000000185FD5DE0
		private void FilterToggleValueChanged(bool isOn) {} // 0x000000018B7D33D4-0x000000018B7D33DC
		private void FilterValueChanged(string filterText) {} // 0x000000018B7D2EC4-0x000000018B7D2F18
		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) {} // 0x000000018B7D4370-0x000000018B7D4380
		private void PinToggleValueChanged(bool isOn) {} // 0x000000018B7D3504-0x000000018B7D36D8
		protected override void OnDestroy() {} // 0x000000018B7D2F18-0x000000018B7D2FEC
		protected override void OnEnable() {} // 0x000000018B7D3A5C-0x000000018B7D3C1C
		protected override void OnDisable() {} // 0x000000018B7D2FEC-0x000000018B7D3048
		private void ConsoleLogSelectedItemChanged(object item) {} // 0x000000018B7D4254-0x000000018B7D42B0
		protected override void Update() {} // 0x000000018B7D36D8-0x000000018B7D3A5C
		private void PopulateStackTraceArea(ConsoleEntry entry) {} // 0x0000000185FD5DD0-0x0000000185FD5DE0
		public void CopyToClipboard() {} // 0x000000018B7D2E94-0x000000018B7D2EC4
		private void SetCopyToClipboardButtonState(CopyToClipboardStates state) {} // 0x000000018B7D3144-0x000000018B7D319C
		private IEnumerator FadeCopyButton() => default; // 0x000000018B7D319C-0x000000018B7D31F8
		private void StopAnimations() {} // 0x000000018B7D31F8-0x000000018B7D32D4
		private void Refresh() {} // 0x000000018646DB20-0x000000018646DB28
		private void ConsoleOnUpdated(IConsoleService console) {} // 0x000000018B7D42B0-0x000000018B7D42E0
		public void Clear() {} // 0x000000018B7D42E0-0x000000018B7D4310
		public void LogHandlerHasBeenOverridenOkayButtonPress() {} // 0x000000018B7D4310-0x000000018B7D4340
		public void LoggingDisableCloseAndIgnorePressed() {} // 0x000000018B7D4340-0x000000018B7D4370
		public void LoggingDisableReenablePressed() {} // 0x0000000181378230-0x0000000181378240
		private void _Start_b__29_0(bool isOn) {} // 0x000000018B7E01C0-0x000000018B7E034C
		private void _Start_b__29_1(bool isOn) {} // 0x0000000181377E40-0x0000000181377E50
		private void _Start_b__29_2(bool isOn) {} // 0x000000018B7E034C-0x000000018B7E0398
		private void _Start_b__29_3(bool isOn) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class InfoTabController : SRMonoBehaviourEx // TypeDefIndex: 57732
	{
		// Fields
		public const char Tick = '\x2713'; // Metadata: 0x0207DA82
		public const char Cross = '\x00d7'; // Metadata: 0x0207DA84
		public const string NameColor = "#BCBCBC"; // Metadata: 0x0207DA86
		private Dictionary<string, InfoBlock> _infoBlocks; // 0x48
		public InfoBlock InfoBlockPrefab; // 0x50
		public RectTransform LayoutContainer; // 0x58
		public FlashGraphic ToggleButton; // 0x60
		private bool _updateEveryFrame; // 0x68
	
		// Constructors
		public InfoTabController() {} // 0x000000018B7D7CC4-0x000000018B7D7D44
	
		// Methods
		protected override void OnEnable() {} // 0x000000018B7D7C48-0x000000018B7D7C80
		public void Refresh() {} // 0x000000018B7D7C80-0x000000018B7D7CB4
		protected override void Update() {} // 0x000000018B7D7CB4-0x000000018B7D7CC4
		public void ActivateRefreshEveryFrame() {} // 0x000000018B7D7320-0x000000018B7D7354
		private void InternalRefresh() {} // 0x000000018B7D7858-0x000000018B7D7C48
		private void FillInfoBlock(InfoBlock block, IList<SRDebugger.InfoEntry> info) {} // 0x000000018B7D73EC-0x000000018B7D7858
		private InfoBlock CreateBlock(string title) => default; // 0x000000018B7D7354-0x000000018B7D73EC
	}

	public class OptionsTabController : SRMonoBehaviourEx // TypeDefIndex: 57736
	{
		// Fields
		private readonly List<OptionsControlBase> _controls; // 0x48
		private readonly List<CategoryInstance> _categories; // 0x50
		private readonly Dictionary<OptionDefinition, OptionsControlBase> _options; // 0x58
		private bool _queueRefresh; // 0x60
		private bool _selectionModeEnabled; // 0x61
		private Canvas _optionCanvas; // 0x68
		public ActionControl ActionControlPrefab; // 0x70
		public CategoryGroup CategoryGroupPrefab; // 0x78
		public RectTransform ContentContainer; // 0x80
		public GameObject NoOptionsNotice; // 0x88
		public Toggle PinButton; // 0x90
		public GameObject PinPromptSpacer; // 0x98
		public GameObject PinPromptText; // 0xA0
		private bool _isTogglingCategory; // 0xA8
	
		// Nested types
		private class CategoryInstance // TypeDefIndex: 57733
		{
			// Fields
			private CategoryGroup _CategoryGroup_k__BackingField; // 0x10
			public readonly List<OptionsControlBase> Options; // 0x18
	
			// Properties
			public CategoryGroup CategoryGroup { get; private set; } // 0x000000018B7DB9B4-0x000000018B7DBBB8 0x000000018B7DA81C-0x000000018B7DA9B0
	
			// Constructors
			public CategoryInstance() {} // Dummy constructor
			public CategoryInstance(CategoryGroup group) {} // 0x000000018B7DAB30-0x000000018B7DABD0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 57734
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<string, List<OptionDefinition>>, string> __9__29_0; // 0x08
			public static Comparison<OptionDefinition> __9__30_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018B7DAC00-0x000000018B7DAC20
			public __c() {} // 0x000000018B7DAA9C-0x000000018B7DAB30
	
			// Methods
			internal string _Populate_b__29_0(KeyValuePair<string, List<OptionDefinition>> p) => default; // 0x000000018B7DA9B0-0x000000018B7DAA9C
			internal int _CreateCategory_b__30_0(OptionDefinition d1, OptionDefinition d2) => default; // 0x000000018B7DBBB8-0x000000018B7DBBCC
		}
	
		private sealed class __c__DisplayClass30_0 // TypeDefIndex: 57735
		{
			// Fields
			public OptionsTabController __4__this; // 0x10
			public CategoryInstance categoryInstance; // 0x18
	
			// Constructors
			public __c__DisplayClass30_0() {} // 0x000000018B7DAC20-0x000000018B7DACD4
	
			// Methods
			internal void _CreateCategory_b__1(bool b) {} // 0x000000018B7DB654-0x000000018B7DB9B4
		}
	
		// Constructors
		public OptionsTabController() {} // 0x000000018B7E0C68-0x000000018B7E0C98
	
		// Methods
		protected override void Start() {} // 0x000000018B7DB514-0x000000018B7DB654
		protected override void OnDestroy() {} // 0x000000018B7D9DDC-0x000000018B7DA008
		private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned) {} // 0x000000018B7DB350-0x000000018B7DB514
		private void OnOptionsUpdated(object sender, EventArgs eventArgs) {} // 0x000000018B7DABD0-0x000000018B7DAC00
		protected override void OnEnable() {} // 0x000000018B7DA768-0x000000018B7DA81C
		protected override void OnDisable() {} // 0x000000018B7DACD4-0x000000018B7DB350
		protected override void Update() {} // 0x000000018B7DA008-0x000000018B7DA768
		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b) {} // 0x000000018B7D9C10-0x000000018B7D9DDC
		public void SetSelectionModeEnabled(bool isEnabled) {} // 0x000000018B7DBBCC-0x000000018B7DBCE0
		private void Refresh() {} // 0x000000018346D130-0x000000018346D140
		private void CommitPinnedOptions() {} // 0x0000000184096E30-0x0000000184096EF0
		private void RefreshCategorySelection() {} // 0x000000018B7D1A18-0x000000018B7D1AA8
		private void OnOptionSelectionToggle(bool selected) {} // 0x000000018B7E0D2C-0x000000018B7E0D90
		private void OnCategorySelectionToggle(CategoryInstance category, bool selected) {} // 0x0000000185492010-0x0000000185492020
		protected void Populate() {} // 0x000000018B7E0BA8-0x000000018B7E0BDC
		protected void CreateCategory(string title, List<OptionDefinition> options) {} // 0x000000018B7E0AF4-0x000000018B7E0B28
		private void Clear() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ProfilerTabController : SRMonoBehaviourEx // TypeDefIndex: 57737
	{
		// Fields
		private bool _isDirty; // 0x48
		public Toggle PinToggle; // 0x50
	
		// Constructors
		public ProfilerTabController() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void Start() {} // 0x000000018B7DE7B8-0x000000018B7DE870
		private void PinToggleValueChanged(bool isOn) {} // 0x000000018B7DE6EC-0x000000018B7DE740
		protected override void OnEnable() {} // 0x0000000185FD46B0-0x0000000185FD46C0
		protected override void Update() {} // 0x000000018B7DE870-0x000000018B7DE880
		private void Refresh() {} // 0x000000018B7DE740-0x000000018B7DE7B8
	}
}
