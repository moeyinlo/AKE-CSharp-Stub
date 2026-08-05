/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Beyond;
using Beyond.Gameplay;
using Beyond.Gameplay.Core;
using Beyond.GEnums;
using Beyond.Lua;
using Beyond.Resource;
using Beyond.UI;
using Cinemachine;
using DG.Tweening;
using HG.Rendering.Runtime;
using IFix.Core;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using XLua;
using XLua.LuaDLL;

// Image 67: Lua.Beyond.dll - Assembly: Lua.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62029-62076
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Lua
{
	public abstract class CsToLuaClass // TypeDefIndex: 62036
	{
		// Fields
		protected LuaTable m_luaTable; // 0x10
	
		// Constructors
		public CsToLuaClass(string luaPath); // 0x0000000189EB60B8-0x0000000189EB6190
	}

	public class LuaEventSystem : ILuaEventSystem, IDisposable // TypeDefIndex: 62044
	{
		// Fields
		private DispatchEventFunc m_luaNotify; // 0x10
		private IntPtr L; // 0x18
		private ObjectTranslator m_translator; // 0x20
		private IntPtr m_eventNameBytesPtr; // 0x28
		private byte[] m_eventNameBytes; // 0x30
		private LuaEnv m_luaEnv; // 0x38
		private int csNotifyRef; // 0x40
	
		// Nested types
		[CSharpCallLua]
		public delegate void DispatchEventFunc(string eventName, LuaTable luaTable); // TypeDefIndex: 62037; 0x00000001838E1420-0x00000001838E1430
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 62038
		{
			// Fields
			public LuaEventSystem __4__this; // 0x10
			public string eventName; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _DispatchEvent_b__0(); // 0x0000000184CAEE20-0x0000000184CAEF00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0<T> // TypeDefIndex: 62039
		{
			// Fields
			public LuaEventSystem __4__this;
			public string eventName;
			public T arg;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _DispatchEvent_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0<T0, T1> // TypeDefIndex: 62040
		{
			// Fields
			public LuaEventSystem __4__this;
			public string eventName;
			public T0 arg0;
			public T1 arg1;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _DispatchEvent_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0<T0, T1, T2> // TypeDefIndex: 62041
		{
			// Fields
			public LuaEventSystem __4__this;
			public string eventName;
			public T0 arg0;
			public T1 arg1;
			public T2 arg2;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _DispatchEvent_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0<T0, T1, T2, T3> // TypeDefIndex: 62042
		{
			// Fields
			public LuaEventSystem __4__this;
			public string eventName;
			public T0 arg0;
			public T1 arg1;
			public T2 arg2;
			public T3 arg3;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _DispatchEvent_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0<T0, T1, T2, T3, T4> // TypeDefIndex: 62043
		{
			// Fields
			public LuaEventSystem __4__this;
			public string eventName;
			public T0 arg0;
			public T1 arg1;
			public T2 arg2;
			public T3 arg3;
			public T4 arg4;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _DispatchEvent_b__0();
		}
	
		// Constructors
		public LuaEventSystem(); // 0x0000000184852550-0x0000000184852760
	
		// Methods
		public void DispatchEvent(string eventName); // 0x000000018423A270-0x000000018423A400
		public void DispatchEvent<T>(string eventName, T arg);
		public void DispatchEvent<T0, T1>(string eventName, T0 arg0, T1 arg1);
		public void DispatchEvent<T0, T1, T2>(string eventName, T0 arg0, T1 arg1, T2 arg2);
		public void DispatchEvent<T0, T1, T2, T3>(string eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3);
		public void DispatchEvent<T0, T1, T2, T3, T4>(string eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public void PushEventName(string eventName); // 0x0000000183124F10-0x0000000183125030
		public void Dispose(); // 0x0000000189EB9230-0x0000000189EB92CC
	}

	public class CSharpCallLuaRegistration // TypeDefIndex: 62045
	{
		// Fields
		private LuaEventSystem m_luaEventSystem; // 0x10
	
		// Constructors
		public CSharpCallLuaRegistration(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Init(); // 0x00000001848523D0-0x00000001848524C0
		public void Dispose(); // 0x0000000189EB6018-0x0000000189EB60B8
	}

	public class LuaCustomConfig : MonoBehaviour, ILuaCallCSharp, ISerializationCallbackReceiver // TypeDefIndex: 62050
	{
		// Fields
		[SerializeField]
		public List<Item> itemList; // 0x18
		private Dictionary<string, Item> m_itemDict; // 0x20
	
		// Properties
		public Dictionary<string, Item> itemDict { get; } // 0x0000000189EB904C-0x0000000189EB9230 
	
		// Nested types
		public enum ValueType // TypeDefIndex: 62046
		{
			Bool = 0,
			Int = 1,
			Float = 2,
			String = 3,
			Vector2 = 4,
			Vector3 = 5,
			Color = 6,
			Lua = 7,
			GameObject = 8,
			RectTransform = 9,
			AnimationCurve = 10,
			LayerMask = 11,
			Material = 12,
			Enum = 13,
			Vector4 = 14
		}
	
		[Serializable]
		public class Item : ILuaCallCSharp // TypeDefIndex: 62047
		{
			// Fields
			public string name; // 0x10
			public string description; // 0x18
			public Beyond.Lua.LuaCustomConfig.ValueType valueType; // 0x20
			public bool boolValue; // 0x24
			public int intValue; // 0x28
			public float floatValue; // 0x2C
			public string stringValue; // 0x30
			public Vector2 vector2Value; // 0x38
			public Vector3 vector3Value; // 0x40
			public Vector4 vector4Value; // 0x4C
			public UnityEngine.Color colorValue; // 0x5C
			public string luaValue; // 0x70
			public GameObject gameObjectValue; // 0x78
			public RectTransform rectTransformValue; // 0x80
			public AnimationCurve curveValue; // 0x88
			public LayerMask layerMaskValue; // 0x90
			public Material material; // 0x98
			public string enumTypeAQName; // 0xA0
			public string enumTypeFullName; // 0xA8
			public string enumAssemblyName; // 0xB0
			public int enumValue; // 0xB8
			public string luaTableJson; // 0xC0
			[SerializeField]
			private string m_lastLuaValue; // 0xC8
			[NonSerialized]
			private System.Type m_cachedEnumType; // 0xD0
	
			// Constructors
			public Item(); // 0x0000000183E6D660-0x0000000183E6D830
	
			// Methods
			public bool HasLuaValueChanged(); // 0x0000000189EB6B90-0x0000000189EB6BEC
			public bool ShouldSerializeLuaTableJson(); // 0x0000000189EB6C48-0x0000000189EB6CB8
			public void MarkLuaValueProcessed(); // 0x0000000189EB6BEC-0x0000000189EB6C48
			public System.Type GetEnumType(); // 0x0000000189EB67F0-0x0000000189EB69DC
			public object GetEnumValueObject(); // 0x0000000189EB69DC-0x0000000189EB6B90
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 62048
		{
			// Fields
			public List<object> keys1; // 0x10
			public List<object> keys2; // 0x18
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __CompareLuaTables_b__0(object k, object _); // 0x0000000189EBC634-0x0000000189EBC688
			internal void __CompareLuaTables_b__1(object k, object _); // 0x0000000189EBC688-0x0000000189EBC6DC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 62049
		{
			// Fields
			public JObject jObject; // 0x10
	
			// Constructors
			public __c__DisplayClass23_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _ConvertLuaTableToJson_b__0(object key, object value); // 0x0000000189EBC6DC-0x0000000189EBC7E0
		}
	
		// Constructors
		public LuaCustomConfig(); // 0x0000000183698ED0-0x0000000183698F40
	
		// Methods
		public void OnBeforeSerialize(); // 0x000000018441E0E0-0x000000018441E110
		public void OnAfterDeserialize(); // 0x000000018434A2A0-0x000000018434A2D0
		private bool _ProcessLuaTableItem(Item item); // 0x0000000189EB8AE0-0x0000000189EB8D5C
		public bool ShouldProcessEnumItem(Item item); // 0x0000000189EB7100-0x0000000189EB71A0
		private bool _ProcessEnumItem(Item item); // 0x0000000189EB890C-0x0000000189EB8AE0
		private bool _ValidateLuaTableConsistency(string luaCode, string json); // 0x0000000189EB8D5C-0x0000000189EB904C
		private LuaTable _JsonToLuaTableForValidation(string json, LuaEnv luaEnv); // 0x0000000189EB7BD8-0x0000000189EB7D24
		private void _PopulateLuaTableFromJTokenForValidation(LuaTable luaTable, JToken jToken, LuaEnv luaEnv); // 0x0000000189EB7ECC-0x0000000189EB8364
		private object _ConvertJValueToObjectForValidation(JToken jValue); // 0x0000000189EB7754-0x0000000189EB78CC
		private bool _CompareLuaTables(LuaTable table1, LuaTable table2); // 0x0000000189EB71A0-0x0000000189EB760C
		private bool _CompareValues(object value1, object value2); // 0x0000000189EB760C-0x0000000189EB7754
		private bool _IsNumericType(object obj); // 0x0000000189EB7A4C-0x0000000189EB7BD8
		public void InitConfigTable(LuaTable configTable); // 0x0000000183F27100-0x0000000183F28880
		private LuaTable _JsonToLuaTable(string json, LuaEnv luaEnv); // 0x0000000189EB7D24-0x0000000189EB7ECC
		private void _PopulateLuaTableFromJToken(LuaTable luaTable, JToken jToken); // 0x0000000189EB8364-0x0000000189EB890C
		private object _ConvertJValueToObject(JToken jValue); // 0x0000000189EB78CC-0x0000000189EB7A4C
		public static string ConvertLuaCodeToJson(string luaCode); // 0x0000000189EB6CB8-0x0000000189EB6F84
		public static string ConvertLuaTableToJson(LuaTable luaTable); // 0x0000000189EB6F84-0x0000000189EB7100
	}

	public class LuaDebugSocketManager : MonoBehaviour // TypeDefIndex: 62051
	{
		// Constructors
		public LuaDebugSocketManager(); // 0x0000000184CC3270-0x0000000184CC3560
	}

	public static class LuaHotFix // TypeDefIndex: 62053
	{
		// Nested types
		[CSharpCallLua]
		public delegate bool LuaHotFixInvoker(string luaCode); // TypeDefIndex: 62052; 0x00000001814E2060-0x00000001814E2070
	
		// Methods
		public static void LuaHotFixTest(); // 0x0000000189EB97A0-0x0000000189EB97E0
		[IDTag(1)]
		public static bool HotFixLua(string lua); // 0x0000000189EB96A8-0x0000000189EB97A0
		[IDTag(2)]
		public static bool HotFixLua(byte[] lua); // 0x0000000189EB92CC-0x0000000189EB9364
		[IDTag(0)]
		public static bool HotFixLua(Span<byte> lua, int length); // 0x0000000189EB9364-0x0000000189EB96A8
	}

	public static class LuaLogBuffer // TypeDefIndex: 62054
	{
	}

	public class LoadLuaProxy : ILoadLuaProxy // TypeDefIndex: 62055
	{
		// Constructors
		public LoadLuaProxy(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void _RunOnStart(); // 0x0000000184CE2CF0-0x0000000184CE2DA0
		public byte[] LoadLua(string name); // 0x0000000183600DA0-0x0000000183600E10
	}

	public class LuaMethodPointerModule // TypeDefIndex: 62056
	{
		// Constructors
		public LuaMethodPointerModule(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void _RunOnStart(); // 0x0000000184B32CB0-0x0000000184B32DF0
	}

	public class LuaManager : BaseTickManager, ILuaProxy // TypeDefIndex: 62058
	{
		// Fields
		[CompilerGenerated]
		private static LuaManager _instance_k__BackingField; // 0x00
		private const float TICK_INTERVAL = 1f; // Metadata: 0x0235004A
		private readonly CSharpCallLuaRegistration m_csCallLua; // 0x70
		private PeriodicTimer m_envTickTimer; // 0x78
		public static bool s_xluaReflectionOpt; // 0x08
		[CompilerGenerated]
		private LuaEnv _luaEnv_k__BackingField; // 0x80
		public Action<LuaTable, string, LuaUIWidget> wrapUIWidgetFunction; // 0x88
		public Action<LuaTable, string, LuaReference> bindLuaRefFunction; // 0x90
		private bool m_isQuittingApplication; // 0x98
		public TickEvent actionTick; // 0xA0
		public TickEvent actionLateTick; // 0xA8
		public TickEvent actionTailTick; // 0xB0
		public TickEvent actionRenderDone; // 0xB8
	
		// Properties
		public static LuaManager instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D613F0-0x0000000184D61440 0x0000000189EBA0E0-0x0000000189EBA13C
		public LuaEnv luaEnv { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86260-0x0000000184D86270 0x0000000184CD9970-0x0000000184CD9980
		public bool isQuittingApplication { get; set; } // 0x0000000189EBA094-0x0000000189EBA0E0 0x0000000189EBA13C-0x0000000189EBA1C4
		public override FrameTickGroup frameTickGroup { get; } // 0x0000000184D7D310-0x0000000184D7D340 
	
		// Nested types
		public class TickEvent : DisposedUnityEvent<float> // TypeDefIndex: 62057
		{
			// Constructors
			public TickEvent(); // 0x0000000183EB2740-0x0000000183EB2780
		}
	
		// Constructors
		public LuaManager(); // 0x0000000183EB25B0-0x0000000183EB2740
		static LuaManager(); // 0x0000000184D7A1D0-0x0000000184D7A210
	
		// Methods
		public static void CreateInstance(); // 0x00000001848162C0-0x00000001848163A0
		public static void DestroyInstance(); // 0x00000001848163A0-0x0000000184816450
		public static bool IsEnableMultithreadGC(); // 0x0000000183A74140-0x0000000183A74270
		public static bool IsLuaGCing(); // 0x00000001832F1550-0x00000001832F1660
		protected override void OnInit(); // 0x00000001842D2660-0x00000001842D6560
		public static string GetLuaStack(); // 0x00000001832F1320-0x00000001832F1550
		protected override void OnRelease(); // 0x0000000184A79AD0-0x0000000184A7CB10
		public static void ReStartLuaProfiler(); // 0x0000000189EB9AF0-0x0000000189EB9B30
		private void _ReleaseDelegateInAnotherStackFrame(); // 0x0000000189EB9ECC-0x0000000189EBA094
		public override void Tick(float deltaTime); // 0x000000018301EB50-0x000000018301F840
		public override void LateTick(float deltaTime); // 0x000000018301F840-0x000000018301F9D0
		public override void TailLateTick(float deltaTime); // 0x000000018301F9D0-0x000000018301FB60
		public string GetLuaFileRealPath(string modulePath); // 0x0000000189EB9878-0x0000000189EB98FC
		public bool IsLuaFileExist(string modulePath); // 0x0000000182F21AB0-0x0000000182F21B00
		public long LoadLuaByteByFileRealPath(string modulePath, out int len); // 0x0000000189EB98FC-0x0000000189EB99C4
		public byte[] LoadLua(string modulePath); // 0x0000000183CDC650-0x0000000183CDC6B0
		public IntPtr LoadLuaBytePtr(string modulePath); // 0x0000000189EB99C4-0x0000000189EB9AF0
		public byte[] LoadLuaBytes(ref string modulePath); // 0x00000001849CB280-0x00000001849CB300
		private void _RegisterCSharpCallLua(); // 0x0000000184852390-0x00000001848523D0
		private static void _Register3rdPartyLibraries(LuaEnv env); // 0x0000000183601780-0x0000000183601A00
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static void _HyperLuaLogCallback(IntPtr L, int level, string text); // 0x0000000189EB9BF4-0x0000000189EB9CE0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static void _LuaUtilsLogCallback(int level, string text); // 0x0000000189EB9CE0-0x0000000189EB9D70
		private void _OnEnvLangChanged(EnvLang lang); // 0x0000000189EB9D70-0x0000000189EB9E44
		public object[] DoString(string code); // 0x0000000189EB97E0-0x0000000189EB9878
		public IntPtr GetLuaState(); // 0x00000001838B54E0-0x00000001838B5520
		public void ClearAllUnityObjectUserdata(); // 0x0000000184034F10-0x0000000184034F70
		[IDTag(1)]
		private void _OnRenderDone(HGRenderPipeCallbackArgs args); // 0x0000000189EB9E44-0x0000000189EB9ECC
		[IDTag(0)]
		private void _OnRenderDone(); // 0x000000018301FC60-0x000000018301FCD0
		public bool AddLuaEventAfterGCDo(UnityAction action); // 0x000000018488B620-0x000000018488B670
		public static void RemoveLuaEventAfterGCDo(UnityAction action); // 0x0000000189EB9B30-0x0000000189EB9BF4
		public void AddOnceLuaEventAfterGCDo(UnityAction action); // 0x000000018423A400-0x000000018423A460
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LuaCalculateABPathHash(IntPtr L); // 0x0000000183EC1580-0x0000000183EC1650
		public static void CasterStringPathHash(IntPtr L, int index, out StringPathHash o); // 0x0000000182F34080-0x0000000182F34150
		public static bool CheckStringPathHash(IntPtr L, int index); // 0x0000000182F33240-0x0000000182F332A0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000186AC5358-0x0000000186AC5360
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186AC5328-0x0000000186AC5330
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000186ADDC58-0x0000000186ADDC60
		public FrameTickGroup __iFixBaseProxy_get_frameTickGroup(); // 0x0000000186D78630-0x0000000186D78638
	}

	[ExecuteInEditMode]
	public class LuaReference : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 62063
	{
		// Fields
		[SerializeField]
		public ComponentRefDict refDict; // 0x18
		[SerializeField]
		public SerializeReferenceDictionary<string, RefExtraInfo> refExtraInfoDict; // 0x20
		[SerializeField]
		public bool isRootRef; // 0x28
		[SerializeField]
		public List<LuaReference> subReferences; // 0x30
		private LuaTable m_table; // 0x38
		private Dictionary<string, Component> m_customUIStyleComp; // 0x40
	
		// Nested types
		[Serializable]
		public class ComponentRefDict : SerializeReferenceDictionary<string, Component> // TypeDefIndex: 62059
		{
			// Constructors
			public ComponentRefDict(); // 0x0000000183698670-0x00000001836986B0
		}
	
		[Serializable]
		public class RefExtraInfo // TypeDefIndex: 62061
		{
			// Fields
			public List<CustomUIStyleInfo> customUIStyles; // 0x10
	
			// Nested types
			[Serializable]
			public class CustomUIStyleInfo // TypeDefIndex: 62060
			{
				// Fields
				public CustomUIStyle style; // 0x10
				public Component component; // 0x18
	
				// Constructors
				public CustomUIStyleInfo(); // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Constructors
			public RefExtraInfo(); // 0x00000001847D3E80-0x00000001847D3F00
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62062
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<LuaReference> __9__8_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000189EBC8A4-0x0000000189EBC908
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Reset_b__8_0(LuaReference item); // 0x0000000189EBC5E8-0x0000000189EBC634
		}
	
		// Constructors
		public LuaReference(); // 0x0000000183698340-0x0000000183698470
	
		// Methods
		private void Reset(); // 0x0000000189EBA88C-0x0000000189EBAB20
		private void OnDestroy(); // 0x00000001832EF680-0x00000001832EF6F0
		private void _UnBindFromXluaRef(); // 0x00000001832EFC60-0x00000001832F0100
		public void BindToLua(LuaTable table); // 0x00000001832EF6F0-0x00000001832EFC60
		private void _BindSelfReferences(LuaTable table); // 0x00000001832F0170-0x00000001832F1200
		public bool RefreshCustomUIStyleBindings(); // 0x0000000189EBA6A8-0x0000000189EBA88C
		private bool _RefreshSelfCustomUIStyleBindings(LuaTable table); // 0x0000000189EBAB20-0x0000000189EBB114
		public bool ContainsGameObject(GameObject obj, bool recursive = true /* Metadata: 0x0235004E */); // 0x0000000189EBA1C4-0x0000000189EBA6A8
	}

	public struct LuaTestReflectionOptStruct // TypeDefIndex: 62064
	{
		// Fields
		public int a; // 0x00
		public string b; // 0x08
		public long l; // 0x10
		public ulong ul; // 0x18
		public float f; // 0x20
		public double d; // 0x28
		public bool bl; // 0x30
	
		// Properties
		public int a1 { get; } // 0x0000000189EBBD7C-0x0000000189EBBDC4 
		public string b1 { get; } // 0x0000000189EBBDC4-0x0000000189EBBE10 
		public long l1 { get; } // 0x0000000189EBBEF0-0x0000000189EBBF3C 
		public ulong ul1 { get; } // 0x0000000189EBBF3C-0x0000000189EBBF88 
		public float f1 { get; } // 0x0000000189EBBEA4-0x0000000189EBBEF0 
		public double d1 { get; } // 0x0000000189EBBE58-0x0000000189EBBEA4 
		public bool bl1 { get; } // 0x0000000189EBBE10-0x0000000189EBBE58 
	
		// Constructors
		public LuaTestReflectionOptStruct(int a, string b, long l, ulong ul, float f, double d, bool bl); // 0x0000000189EBBD34-0x0000000189EBBD7C
	
		// Methods
		public int TestInt(int a); // 0x0000000189EBBB14-0x0000000189EBBB68
		public void TestVoid(); // 0x0000000189EBBCF4-0x0000000189EBBD34
		public void TestStructParam(LuaTestReflectionOptStruct testStruct); // 0x0000000189EBBC7C-0x0000000189EBBCF4
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct); // 0x0000000189EBBC2C-0x0000000189EBBC7C
		public object TestReturnObj(); // 0x0000000189EBBBB8-0x0000000189EBBC2C
		public void TestObjParam(object obj); // 0x0000000189EBBB68-0x0000000189EBBBB8
	}

	public struct LuaTestReflectionOptStruct2 // TypeDefIndex: 62065
	{
		// Fields
		public int a; // 0x00
		public string b; // 0x08
		public long l; // 0x10
		public ulong ul; // 0x18
		public float f; // 0x20
		public double d; // 0x28
		public bool bl; // 0x30
	
		// Properties
		public int a1 { get; } // 0x0000000189EBB908-0x0000000189EBB950 
		public string b1 { get; } // 0x0000000189EBB950-0x0000000189EBB99C 
		public long l1 { get; } // 0x0000000189EBBA7C-0x0000000189EBBAC8 
		public ulong ul1 { get; } // 0x0000000189EBBAC8-0x0000000189EBBB14 
		public float f1 { get; } // 0x0000000189EBBA30-0x0000000189EBBA7C 
		public double d1 { get; } // 0x0000000189EBB9E4-0x0000000189EBBA30 
		public bool bl1 { get; } // 0x0000000189EBB99C-0x0000000189EBB9E4 
	
		// Methods
		public int TestInt(int a); // 0x0000000189EBB6E8-0x0000000189EBB73C
		public void TestVoid(); // 0x0000000189EBB8C8-0x0000000189EBB908
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct); // 0x0000000189EBB850-0x0000000189EBB8C8
		public void TestStructParam2(ref LuaTestReflectionOptStruct2 testStruct); // 0x0000000189EBB800-0x0000000189EBB850
		public object TestReturnObj(); // 0x0000000189EBB78C-0x0000000189EBB800
		public void TestObjParam(object obj); // 0x0000000189EBB73C-0x0000000189EBB78C
	}

	public enum ETestEnum // TypeDefIndex: 62066
	{
		Test1 = 2,
		Test2 = 2
	}

	public class LuaTestReflectionOpt2 // TypeDefIndex: 62067
	{
		// Fields
		public List<int> TestList; // 0x10
		public Dictionary<int, string> TestDict; // 0x18
	
		// Constructors
		public LuaTestReflectionOpt2(); // 0x0000000189EBB55C-0x0000000189EBB6E8
	
		// Methods
		public void TestVoid(); // 0x0000000189EBB51C-0x0000000189EBB55C
		public int TestInt(int a); // 0x0000000189EBB168-0x0000000189EBB1BC
		[IDTag(0)]
		public void TestStructParam(LuaTestReflectionOptStruct testStruct); // 0x0000000189EBB398-0x0000000189EBB410
		[IDTag(1)]
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct); // 0x0000000189EBB320-0x0000000189EBB398
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct); // 0x0000000189EBB2D0-0x0000000189EBB320
		public object TestReturnObj(); // 0x0000000189EBB25C-0x0000000189EBB2D0
		public void TestObjParam(object obj); // 0x0000000189EBB1BC-0x0000000189EBB20C
		public void TestEnum(ETestEnum e); // 0x0000000189EBB114-0x0000000189EBB168
		public ETestEnum TestReturnEnum(); // 0x0000000189EBB20C-0x0000000189EBB25C
		public LuaTestReflectionOptStruct TestStruct(LuaTestReflectionOptStruct a); // 0x0000000189EBB410-0x0000000189EBB51C
	}

	public class LuaTestReflectionOpt // TypeDefIndex: 62068
	{
		// Fields
		public List<int> TestList; // 0x10
		public Dictionary<int, string> TestDict; // 0x18
	
		// Constructors
		public LuaTestReflectionOpt(); // 0x0000000189EBC3EC-0x0000000189EBC578
	
		// Methods
		public void TestVoid(); // 0x0000000189EBC3A8-0x0000000189EBC3EC
		public int TestInt(int a); // 0x0000000189EBBFDC-0x0000000189EBC034
		[IDTag(0)]
		public void TestStructParam(LuaTestReflectionOptStruct testStruct); // 0x0000000189EBC220-0x0000000189EBC29C
		[IDTag(1)]
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct); // 0x0000000189EBC1A4-0x0000000189EBC220
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct); // 0x0000000189EBC150-0x0000000189EBC1A4
		public object TestReturnObj(); // 0x0000000189EBC0D8-0x0000000189EBC150
		public void TestObjParam(object obj); // 0x0000000189EBC034-0x0000000189EBC088
		public void TestEnum(ETestEnum e); // 0x0000000189EBBF88-0x0000000189EBBFDC
		public ETestEnum TestReturnEnum(); // 0x0000000189EBC088-0x0000000189EBC0D8
		public LuaTestReflectionOptStruct TestStruct(LuaTestReflectionOptStruct a); // 0x0000000189EBC29C-0x0000000189EBC3A8
	}

	public class LuaUIWidget : MonoBehaviour, IUIClearable // TypeDefIndex: 62069
	{
		// Fields
		public string id; // 0x18
		public bool isEmbeddedWidget; // 0x20
		[CompilerGenerated]
		private LuaTable _table_k__BackingField; // 0x28
		public LuaFunction onEnable; // 0x30
		public LuaFunction onDisable; // 0x38
		public LuaFunction onDestroy; // 0x40
	
		// Properties
		public LuaTable table { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86240-0x0000000184D86250 0x00000001844ECC30-0x00000001844ECC40
	
		// Constructors
		public LuaUIWidget(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		private void Reset(); // 0x0000000189EBC578-0x0000000189EBC5E8
		private void OnEnable(); // 0x000000018321CC80-0x000000018321CCD0
		private void OnDisable(); // 0x000000018321CCD0-0x000000018321CD20
		private void OnDestroy(); // 0x0000000184209D50-0x0000000184209D90
		public void ClearComponent(); // 0x00000001832EF120-0x00000001832EF250
	}

	public static class UtilsForLua // TypeDefIndex: 62072
	{
		// Fields
		private static Vector3[] s_worldCorners; // 0x00
	
		// Nested types
		public class ImageContentParam // TypeDefIndex: 62070
		{
			// Fields
			public string path; // 0x10
	
			// Constructors
			public ImageContentParam(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 62071
		{
			// Fields
			public float from; // 0x10
			public LuaFunction setter; // 0x18
	
			// Constructors
			public __c__DisplayClass34_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _TweenTo_b__0(); // 0x0000000184D85F70-0x0000000184D85F80
			internal void _TweenTo_b__1(float value); // 0x0000000189EBC7E0-0x0000000189EBC8A4
		}
	
		// Constructors
		static UtilsForLua(); // 0x0000000184D36290-0x0000000184D36300
	
		// Methods
		[IDTag(0)]
		public static GameObject CreateObject(GameObject asset); // 0x0000000184B4E940-0x0000000184B4E9C0
		[IDTag(1)]
		public static GameObject CreateObject(GameObject asset, Transform parent); // 0x0000000183B1CCD0-0x0000000183B1CD60
		[IDTag(2)]
		public static GameObject CreateObject(GameObject asset, GameObject parent); // 0x0000000183B1CC50-0x0000000183B1CCD0
		public static void UIContainerResize(Transform container, int size, int templateIndex = 0 /* Metadata: 0x02350051 */); // 0x0000000189EBE220-0x0000000189EBE404
		public static int TurnOffLayer(int value, string layerName); // 0x0000000189EBDFCC-0x0000000189EBE030
		public static int TurnOnLayer(int value, string layerName); // 0x0000000189EBE030-0x0000000189EBE094
		public static int ToggleLayer(int value, string layerName); // 0x0000000189EBDE5C-0x0000000189EBDEC0
		public static void ClearUIComponents(GameObject gameObject); // 0x0000000183DC7E60-0x0000000183DC7EB0
		public static bool RayCast(out RaycastHit hitInfo, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction interaction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x02350052 */); // 0x0000000189EBD4D4-0x0000000189EBD5D0
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction interaction); // 0x0000000189EBD5D0-0x0000000189EBD6CC
		public static Bounds GetRectTransformBounds(RectTransform transform); // 0x00000001837D7060-0x00000001837D7200
		public static UnityEngine.Rect RectTransformToScreenRect(RectTransform rectTransform, Camera uiCamera); // 0x0000000189EBD6CC-0x0000000189EBD760
		public static Vector3 GetRectTransformCenterPosition(RectTransform rectTransform); // 0x0000000189EBD02C-0x0000000189EBD160
		public static Bounds CalcBoundOfRectTransform(RectTransform transform, RectTransform local); // 0x0000000189EBC908-0x0000000189EBC9C0
		public static Vector2 ClampPointInRectTransform(RectTransform source, RectTransform target, Vector2 sourcePoint); // 0x0000000189EBCB54-0x0000000189EBCBFC
		public static List<string> GetStringList(); // 0x0000000189EBD1C4-0x0000000189EBD254
		public static int GetStringHash(string str); // 0x0000000189EBD160-0x0000000189EBD1C4
		public static float EntityDistance(Entity a, Entity b); // 0x0000000189EBCBFC-0x0000000189EBCCB8
		public static void OpenAccountCenter(); // 0x0000000189EBD254-0x0000000189EBD2C0
		public static void ExitGame(); // 0x0000000189EBCCB8-0x0000000189EBCD38
		public static string GetCurrentUID(); // 0x0000000189EBCF0C-0x0000000189EBCF90
		public static bool StartPayment(string productId, string signParams); // 0x0000000189EBDD58-0x0000000189EBDDE8
		public static bool TryGetCharacterVolume(UnityEngine.Rendering.Volume volume, out HGCharacterVolume hgCharacterVolume); // 0x0000000189EBDF34-0x0000000189EBDFCC
		public static float GetAnimationCurveLength(AnimationCurve curve); // 0x0000000189EBCD38-0x0000000189EBCDB4
		public static Tweener TweenTo(float from, float to, float duration, LuaFunction setter); // 0x0000000189EBE094-0x0000000189EBE220
		public static bool IsNull(UnityEngine.Object o); // 0x0000000184086AE0-0x0000000184086B90
		public static ImageContentParam ParseImageContent(string xml); // 0x0000000189EBD2C0-0x0000000189EBD484
		public static void ReturnToLogin(); // 0x0000000189EBD760-0x0000000189EBD7DC
		public static void QuitGame(int exitCode); // 0x0000000189EBD484-0x0000000189EBD4D4
		public static bool CheckExtremeDangerousByLevel(int level); // 0x0000000189EBC9C0-0x0000000189EBCB54
		public static void ToggleCharInfoInUpgradePanelOption(bool isIn); // 0x0000000189EBDDE8-0x0000000189EBDE5C
		public static void ToggleWeaponInUpgradePanelOption(bool isIn); // 0x0000000189EBDEC0-0x0000000189EBDF34
		public static CinemachineTransposer GetCinemachineTransposer(CinemachineVirtualCamera vcam); // 0x0000000189EBCE60-0x0000000189EBCF0C
		public static CinemachineComposer GetCinemachineComposer(CinemachineVirtualCamera vcam); // 0x0000000189EBCDB4-0x0000000189EBCE60
		public static CinemachineCameraOffset GetOrAddCinemachineCameraOffset(CinemachineVirtualCamera vcam); // 0x0000000189EBCF90-0x0000000189EBD02C
	
		// Extension methods
		public static void SetPosX(this Transform t, float value); // 0x0000000189EBD7DC-0x0000000189EBD87C
		public static void SetPosY(this Transform t, float value); // 0x0000000189EBD87C-0x0000000189EBD91C
		public static void SetPosZ(this Transform t, float value); // 0x0000000189EBD91C-0x0000000189EBD9B0
		public static void SetRotX(this Transform t, float value); // 0x0000000189EBD9B0-0x0000000189EBDA50
		public static void SetRotY(this Transform t, float value); // 0x0000000189EBDA50-0x0000000189EBDAF0
		public static void SetRotZ(this Transform t, float value); // 0x0000000189EBDAF0-0x0000000189EBDB84
		public static void SetScaleX(this Transform t, float value); // 0x0000000189EBDB84-0x0000000189EBDC24
		public static void SetScaleY(this Transform t, float value); // 0x0000000189EBDC24-0x0000000189EBDCC4
		public static void SetScaleZ(this Transform t, float value); // 0x0000000189EBDCC4-0x0000000189EBDD58
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 62031
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 62032
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 62033
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 62034
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 62035
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 62030
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 62073
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37330-0x0000000184D373A0
	
		// Methods
		public void __Gen_Wrap_0(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
		public bool __Gen_Wrap_1(); // 0x00000001863623A8-0x0000000186362454
		public void __Gen_Wrap_2(); // 0x00000001863625A4-0x0000000186362640
		public void __Gen_Wrap_3(object P0); // 0x00000001863633B4-0x0000000186363474
		public Dictionary<string, LuaCustomConfig.Item> __Gen_Wrap_4(object P0); // 0x0000000189EB6370-0x0000000189EB644C
		public string __Gen_Wrap_5(object P0); // 0x0000000189EB644C-0x0000000189EB6528
		public object __Gen_Wrap_6(object P0, object P1); // 0x0000000189EB6528-0x0000000189EB6634
		public void __Gen_Wrap_7(object P0, object P1, object P2, object P3); // 0x0000000186373E64-0x0000000186373F5C
		public LuaTable __Gen_Wrap_8(object P0, object P1, object P2); // 0x0000000189EB6634-0x0000000189EB675C
		public bool __Gen_Wrap_9(object P0, object P1); // 0x0000000186366BC4-0x0000000186366CB0
		public bool __Gen_Wrap_10(object P0, object P1, object P2); // 0x00000001866D3350-0x00000001866D3444
		public void __Gen_Wrap_11(object P0, object P1, object P2); // 0x0000000186364290-0x0000000186364388
		public System.Type __Gen_Wrap_12(object P0); // 0x0000000189EB6190-0x0000000189EB6280
		public object __Gen_Wrap_13(object P0); // 0x0000000189EB6280-0x0000000189EB6370
		public bool __Gen_Wrap_14(object P0); // 0x00000001863632E4-0x00000001863633B4
		public bool __Gen_Wrap_15(Span<byte> P0, int P1); // 0x0000000182D54B10-0x0000000182D550D0
		public byte[] __Gen_Wrap_16(object P0, object P1); // 0x0000000182D550D0-0x0000000182D55B00
		public void __Gen_Wrap_17(object P0, HGRenderPipeCallbackArgs P1); // 0x0000000182D55B00-0x0000000182D56180
		public string __Gen_Wrap_18(); // 0x0000000182D56180-0x0000000182D569C0
		public void __Gen_Wrap_19(IntPtr P0, int P1, object P2); // 0x0000000181AF7A70-0x0000000181AF7D60
		public void __Gen_Wrap_20(int P0, object P1); // 0x0000000181FBD880-0x0000000181FBDB50
		public byte[] __Gen_Wrap_21(object P0, ref string P1); // 0x0000000182D569C0-0x0000000182D57720
		public void __Gen_Wrap_22(object P0, EnvLang P1); // 0x00000001812A0D50-0x00000001812A1020
		public int __Gen_Wrap_23(IntPtr P0); // 0x0000000181B59610-0x0000000181B59810
		public void __Gen_Wrap_24(IntPtr P0, int P1, out StringPathHash P2); // 0x0000000182D57720-0x0000000182D58010
		public bool __Gen_Wrap_25(IntPtr P0, int P1); // 0x0000000182D58010-0x0000000182D58240
		public void __Gen_Wrap_26(object P0, bool P1); // 0x0000000182D58240-0x0000000182D58520
		public void __Gen_Wrap_27(object P0, float P1); // 0x0000000181410050-0x0000000181410330
		public string __Gen_Wrap_28(object P0, object P1); // 0x0000000182D58520-0x0000000182D58F40
		public long __Gen_Wrap_29(object P0, object P1, out int P2); // 0x0000000182D58F40-0x0000000182D59310
		public IntPtr __Gen_Wrap_30(object P0, object P1); // 0x0000000182D59310-0x0000000182D596A0
		public object[] __Gen_Wrap_31(object P0, object P1); // 0x0000000182D596A0-0x0000000182D5A0C0
		public IntPtr __Gen_Wrap_32(object P0); // 0x00000001811D1C90-0x00000001811D1F50
		public FrameTickGroup __Gen_Wrap_33(object P0); // 0x0000000181298AE0-0x0000000181298DA0
		public bool __Gen_Wrap_34(LuaReference P0); // 0x0000000181738AF0-0x0000000181738DC0
		public bool __Gen_Wrap_35(object P0, object P1, bool P2); // 0x000000018147A0D0-0x000000018147A480
		public int __Gen_Wrap_36(ref LuaTestReflectionOptStruct P0); // 0x0000000182D5A0C0-0x0000000182D5AD00
		public string __Gen_Wrap_37(ref LuaTestReflectionOptStruct P0); // 0x0000000182D5AD00-0x0000000182D5BC30
		public long __Gen_Wrap_38(ref LuaTestReflectionOptStruct P0); // 0x0000000182D5BC30-0x0000000182D5C870
		public ulong __Gen_Wrap_39(ref LuaTestReflectionOptStruct P0); // 0x0000000182D5C870-0x0000000182D5D4B0
		public float __Gen_Wrap_40(ref LuaTestReflectionOptStruct P0); // 0x0000000182D5D4B0-0x0000000182D5E0F0
		public double __Gen_Wrap_41(ref LuaTestReflectionOptStruct P0); // 0x0000000182D5E0F0-0x0000000182D5ED30
		public bool __Gen_Wrap_42(ref LuaTestReflectionOptStruct P0); // 0x0000000182D5ED30-0x0000000182D5F970
		public int __Gen_Wrap_43(ref LuaTestReflectionOptStruct P0, int P1); // 0x0000000182D5F970-0x0000000182D605C0
		public void __Gen_Wrap_44(ref LuaTestReflectionOptStruct P0); // 0x0000000182D605C0-0x0000000182D611F0
		public void __Gen_Wrap_45(ref LuaTestReflectionOptStruct P0, LuaTestReflectionOptStruct P1); // 0x0000000182D611F0-0x0000000182D61F30
		public void __Gen_Wrap_46(ref LuaTestReflectionOptStruct P0, ref LuaTestReflectionOptStruct P1); // 0x0000000182D61F30-0x0000000182D62E90
		public object __Gen_Wrap_47(ref LuaTestReflectionOptStruct P0); // 0x0000000182D62E90-0x0000000182D63DC0
		public void __Gen_Wrap_48(ref LuaTestReflectionOptStruct P0, object P1); // 0x0000000182D63DC0-0x0000000182D64AE0
		public int __Gen_Wrap_49(ref LuaTestReflectionOptStruct2 P0); // 0x0000000182D64AE0-0x0000000182D65720
		public string __Gen_Wrap_50(ref LuaTestReflectionOptStruct2 P0); // 0x0000000182D65720-0x0000000182D66650
		public long __Gen_Wrap_51(ref LuaTestReflectionOptStruct2 P0); // 0x0000000182D66650-0x0000000182D67290
		public ulong __Gen_Wrap_52(ref LuaTestReflectionOptStruct2 P0); // 0x0000000182D67290-0x0000000182D67ED0
		public float __Gen_Wrap_53(ref LuaTestReflectionOptStruct2 P0); // 0x0000000182D67ED0-0x0000000182D68B10
		public double __Gen_Wrap_54(ref LuaTestReflectionOptStruct2 P0); // 0x0000000182D68B10-0x0000000182D69750
		public bool __Gen_Wrap_55(ref LuaTestReflectionOptStruct2 P0); // 0x0000000182D69750-0x0000000182D6A390
		public int __Gen_Wrap_56(ref LuaTestReflectionOptStruct2 P0, int P1); // 0x0000000182D6A390-0x0000000182D6AFE0
		public void __Gen_Wrap_57(ref LuaTestReflectionOptStruct2 P0); // 0x0000000182D6AFE0-0x0000000182D6BC10
		public void __Gen_Wrap_58(ref LuaTestReflectionOptStruct2 P0, LuaTestReflectionOptStruct2 P1); // 0x0000000182D6BC10-0x0000000182D6C950
		public void __Gen_Wrap_59(ref LuaTestReflectionOptStruct2 P0, ref LuaTestReflectionOptStruct2 P1); // 0x0000000182D6C950-0x0000000182D6D8B0
		public object __Gen_Wrap_60(ref LuaTestReflectionOptStruct2 P0); // 0x0000000182D6D8B0-0x0000000182D6E7E0
		public void __Gen_Wrap_61(ref LuaTestReflectionOptStruct2 P0, object P1); // 0x0000000182D6E7E0-0x0000000182D6F500
		public int __Gen_Wrap_62(object P0, int P1); // 0x000000018135C3D0-0x000000018135C6B0
		public void __Gen_Wrap_63(object P0, LuaTestReflectionOptStruct P1); // 0x0000000182D6F500-0x0000000182D6FB90
		public void __Gen_Wrap_64(object P0, LuaTestReflectionOptStruct2 P1); // 0x0000000182D6FB90-0x0000000182D70220
		public void __Gen_Wrap_65(object P0, ref LuaTestReflectionOptStruct P1); // 0x0000000182D70220-0x0000000182D70F40
		public void __Gen_Wrap_66(object P0, ETestEnum P1); // 0x00000001812A0D50-0x00000001812A1020
		public ETestEnum __Gen_Wrap_67(object P0); // 0x0000000181298AE0-0x0000000181298DA0
		public LuaTestReflectionOptStruct __Gen_Wrap_68(object P0, LuaTestReflectionOptStruct P1); // 0x0000000182D70F40-0x0000000182D71BE0
		public GameObject __Gen_Wrap_69(object P0); // 0x0000000182D71BE0-0x0000000182D72520
		public GameObject __Gen_Wrap_70(object P0, object P1); // 0x0000000182D72520-0x0000000182D72F50
		public void __Gen_Wrap_71(object P0, int P1, int P2); // 0x0000000181992E90-0x0000000181993180
		public int __Gen_Wrap_72(int P0, object P1); // 0x0000000182D72F50-0x0000000182D73230
		public bool __Gen_Wrap_73(out RaycastHit P0, Ray P1, float P2, int P3, QueryTriggerInteraction P4); // 0x0000000182D73230-0x0000000182D73E00
		public int __Gen_Wrap_74(Ray P0, object P1, float P2, int P3, QueryTriggerInteraction P4); // 0x0000000182D73E00-0x0000000182D744E0
		public Bounds __Gen_Wrap_75(object P0); // 0x0000000182D744E0-0x0000000182D74DE0
		public UnityEngine.Rect __Gen_Wrap_76(object P0, object P1); // 0x0000000182D74DE0-0x0000000182D757B0
		public Vector3 __Gen_Wrap_77(object P0); // 0x0000000182D757B0-0x0000000182D760B0
		public Bounds __Gen_Wrap_78(object P0, object P1); // 0x0000000182D760B0-0x0000000182D76A80
		public Vector2 __Gen_Wrap_79(object P0, object P1, Vector2 P2); // 0x0000000182D76A80-0x0000000182D777B0
		public List<string> __Gen_Wrap_80(); // 0x0000000182D777B0-0x0000000182D77FF0
		public int __Gen_Wrap_81(object P0); // 0x0000000181298AE0-0x0000000181298DA0
		public float __Gen_Wrap_82(object P0, object P1); // 0x0000000182D77FF0-0x0000000182D78380
		public bool __Gen_Wrap_83(object P0, out HGCharacterVolume P1); // 0x0000000182D78380-0x0000000182D78DA0
		public float __Gen_Wrap_84(object P0); // 0x0000000182837EF0-0x00000001828381B0
		public float __Gen_Wrap_85(); // 0x00000001811D1AC0-0x00000001811D1C90
		public void __Gen_Wrap_86(float P0); // 0x0000000181494100-0x00000001814942F0
		public Tweener __Gen_Wrap_87(float P0, float P1, float P2, object P3); // 0x0000000182D78DA0-0x0000000182D79740
		public UtilsForLua.ImageContentParam __Gen_Wrap_88(object P0); // 0x0000000182D79740-0x0000000182D7A070
		public void __Gen_Wrap_89(int P0); // 0x00000001812F6920-0x00000001812F6B10
		public bool __Gen_Wrap_90(int P0); // 0x00000001818C3AD0-0x00000001818C3CD0
		public void __Gen_Wrap_91(bool P0); // 0x0000000181488F50-0x0000000181489140
		public CinemachineTransposer __Gen_Wrap_92(object P0); // 0x0000000182D7A070-0x0000000182D7A9A0
		public CinemachineComposer __Gen_Wrap_93(object P0); // 0x0000000182D7A9A0-0x0000000182D7B2D0
		public CinemachineCameraOffset __Gen_Wrap_94(object P0); // 0x0000000182D7B2D0-0x0000000182D7BC00
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 62074
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000189EB675C-0x0000000189EB67F0
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 62075
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000189EBE5EC-0x0000000189EBE650
		public static bool IsPatched(int id); // 0x000000018301FCF0-0x000000018301FD40
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000189EBE4A8-0x0000000189EBE574
		public object CreateWrapper(int id); // 0x0000000189EBE574-0x0000000189EBE5EC
		public object InitWrapperArray(int len); // 0x0000000189EBE650-0x0000000189EBE6DC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000189EBE404-0x0000000189EBE4A8
	}

	public enum IDMAP0 // TypeDefIndex: 62076
	{
		Beyond-Lua-LuaEventSystem-DispatchEvent0 = 0,
		Beyond-Lua-LuaEventSystem-PushEventName0 = 3,
		Beyond-Lua-LuaManager-IsLuaGCing0 = 4,
		Beyond-Lua-LuaManager-AddOnceLuaEventAfterGCDo0 = 7,
		Beyond-Lua-LuaEventSystem-Dispose0 = 8,
		Beyond-Lua-CSharpCallLuaRegistration-Init0 = 9,
		Beyond-Lua-CSharpCallLuaRegistration-Dispose0 = 10,
		Beyond-Lua-LuaCustomConfig-get_itemDict0 = 11,
		Beyond-Lua-LuaCustomConfig-OnBeforeSerialize0 = 12,
		Beyond-Lua-LuaCustomConfig-OnAfterDeserialize0 = 13,
		Beyond-Lua-LuaCustomConfig-_ProcessLuaTableItem0 = 14,
		Beyond-Lua-LuaCustomConfig-Item-MarkLuaValueProcessed0 = 15,
		Beyond-Lua-LuaCustomConfig-ConvertLuaCodeToJson0 = 16,
		Beyond-Lua-LuaCustomConfig-ConvertLuaTableToJson0 = 17,
		Beyond-Lua-LuaCustomConfig-_ValidateLuaTableConsistency0 = 20,
		Beyond-Lua-LuaCustomConfig-_JsonToLuaTableForValidation0 = 21,
		Beyond-Lua-LuaCustomConfig-_PopulateLuaTableFromJTokenForValidation0 = 22,
		Beyond-Lua-LuaCustomConfig-_ConvertJValueToObjectForValidation0 = 23,
		Beyond-Lua-LuaCustomConfig-_CompareLuaTables0 = 24,
		Beyond-Lua-LuaCustomConfig-_CompareValues0 = 28,
		Beyond-Lua-LuaCustomConfig-_IsNumericType0 = 29,
		Beyond-Lua-LuaCustomConfig-ShouldProcessEnumItem0 = 30,
		Beyond-Lua-LuaCustomConfig-_ProcessEnumItem0 = 31,
		Beyond-Lua-LuaCustomConfig-InitConfigTable0 = 32,
		Beyond-Lua-LuaCustomConfig-_JsonToLuaTable0 = 33,
		Beyond-Lua-LuaCustomConfig-_PopulateLuaTableFromJToken0 = 34,
		Beyond-Lua-LuaCustomConfig-_ConvertJValueToObject0 = 35,
		Beyond-Lua-LuaCustomConfig-Item-GetEnumValueObject0 = 36,
		Beyond-Lua-LuaCustomConfig-Item-GetEnumType0 = 37,
		Beyond-Lua-LuaCustomConfig-Item-HasLuaValueChanged0 = 38,
		Beyond-Lua-LuaCustomConfig-Item-ShouldSerializeLuaTableJson0 = 39,
		Beyond-Lua-LuaHotFix-LuaHotFixTest0 = 40,
		Beyond-Lua-LuaHotFix-HotFixLua1 = 41,
		Beyond-Lua-LuaHotFix-HotFixLua0 = 42,
		Beyond-Lua-LuaHotFix-HotFixLua2 = 43,
		Beyond-Lua-LoadLuaProxy-_RunOnStart0 = 44,
		Beyond-Lua-LoadLuaProxy-LoadLua0 = 45,
		Beyond-Lua-LuaMethodPointerModule-_RunOnStart0 = 46,
		Beyond-Lua-LuaManager-CreateInstance0 = 47,
		Beyond-Lua-LuaManager-DestroyInstance0 = 49,
		Beyond-Lua-LuaManager-IsEnableMultithreadGC0 = 50,
		Beyond-Lua-LuaManager-OnInit0 = 51,
		Beyond-Lua-LuaManager-_OnRenderDone0 = 53,
		Beyond-Lua-LuaManager-_OnRenderDone1 = 54,
		Beyond-Lua-LuaManager-GetLuaStack0 = 55,
		Beyond-Lua-LuaManager-_Register3rdPartyLibraries0 = 56,
		Beyond-Lua-LuaManager-_HyperLuaLogCallback0 = 57,
		Beyond-Lua-LuaManager-_LuaUtilsLogCallback0 = 58,
		Beyond-Lua-LuaManager-LoadLuaBytes0 = 59,
		Beyond-Lua-LuaManager-_OnEnvLangChanged0 = 60,
		Beyond-Lua-LuaManager-LuaCalculateABPathHash0 = 61,
		Beyond-Lua-LuaManager-CasterStringPathHash0 = 62,
		Beyond-Lua-LuaManager-CheckStringPathHash0 = 63,
		Beyond-Lua-LuaManager-_RegisterCSharpCallLua0 = 64,
		Beyond-Lua-LuaManager-OnRelease0 = 65,
		Beyond-Lua-LuaManager-get_isQuittingApplication0 = 66,
		Beyond-Lua-LuaManager-_ReleaseDelegateInAnotherStackFrame0 = 67,
		Beyond-Lua-LuaManager-ReStartLuaProfiler0 = 68,
		Beyond-Lua-LuaManager-set_isQuittingApplication0 = 69,
		Beyond-Lua-LuaManager-Tick0 = 70,
		Beyond-Lua-LuaManager-LateTick0 = 71,
		Beyond-Lua-LuaManager-TailLateTick0 = 72,
		Beyond-Lua-LuaManager-GetLuaFileRealPath0 = 73,
		Beyond-Lua-LuaManager-IsLuaFileExist0 = 74,
		Beyond-Lua-LuaManager-LoadLuaByteByFileRealPath0 = 75,
		Beyond-Lua-LuaManager-LoadLua0 = 76,
		Beyond-Lua-LuaManager-LoadLuaBytePtr0 = 77,
		Beyond-Lua-LuaManager-DoString0 = 78,
		Beyond-Lua-LuaManager-GetLuaState0 = 79,
		Beyond-Lua-LuaManager-ClearAllUnityObjectUserdata0 = 80,
		Beyond-Lua-LuaManager-AddLuaEventAfterGCDo0 = 81,
		Beyond-Lua-LuaManager-RemoveLuaEventAfterGCDo0 = 82,
		Beyond-Lua-LuaManager-get_frameTickGroup0 = 83,
		Beyond-Lua-LuaReference-Reset0 = 84,
		Beyond-Lua-LuaReference-OnDestroy0 = 88,
		Beyond-Lua-LuaReference-_UnBindFromXluaRef0 = 89,
		Beyond-Lua-LuaReference-BindToLua0 = 90,
		Beyond-Lua-LuaReference-_BindSelfReferences0 = 91,
		Beyond-Lua-LuaReference-RefreshCustomUIStyleBindings0 = 92,
		Beyond-Lua-LuaReference-_RefreshSelfCustomUIStyleBindings0 = 93,
		Beyond-Lua-LuaReference-ContainsGameObject0 = 94,
		Beyond-Lua-LuaTestReflectionOptStruct-get_a10 = 95,
		Beyond-Lua-LuaTestReflectionOptStruct-get_b10 = 96,
		Beyond-Lua-LuaTestReflectionOptStruct-get_l10 = 97,
		Beyond-Lua-LuaTestReflectionOptStruct-get_ul10 = 98,
		Beyond-Lua-LuaTestReflectionOptStruct-get_f10 = 99,
		Beyond-Lua-LuaTestReflectionOptStruct-get_d10 = 100,
		Beyond-Lua-LuaTestReflectionOptStruct-get_bl10 = 101,
		Beyond-Lua-LuaTestReflectionOptStruct-TestInt0 = 102,
		Beyond-Lua-LuaTestReflectionOptStruct-TestVoid0 = 103,
		Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam0 = 104,
		Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam20 = 105,
		Beyond-Lua-LuaTestReflectionOptStruct-TestReturnObj0 = 106,
		Beyond-Lua-LuaTestReflectionOptStruct-TestObjParam0 = 107,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_a10 = 108,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_b10 = 109,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_l10 = 110,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_ul10 = 111,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_f10 = 112,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_d10 = 113,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_bl10 = 114,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestInt0 = 115,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestVoid0 = 116,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam0 = 117,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam20 = 118,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestReturnObj0 = 119,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestObjParam0 = 120,
		Beyond-Lua-LuaTestReflectionOpt2-TestVoid0 = 121,
		Beyond-Lua-LuaTestReflectionOpt2-TestInt0 = 122,
		Beyond-Lua-LuaTestReflectionOpt2-TestStructParam0 = 123,
		Beyond-Lua-LuaTestReflectionOpt2-TestStructParam1 = 124,
		Beyond-Lua-LuaTestReflectionOpt2-TestStructParam20 = 125,
		Beyond-Lua-LuaTestReflectionOpt2-TestReturnObj0 = 126,
		Beyond-Lua-LuaTestReflectionOpt2-TestObjParam0 = 127,
		Beyond-Lua-LuaTestReflectionOpt2-TestEnum0 = 128,
		Beyond-Lua-LuaTestReflectionOpt2-TestReturnEnum0 = 129,
		Beyond-Lua-LuaTestReflectionOpt2-TestStruct0 = 130,
		Beyond-Lua-LuaTestReflectionOpt-TestVoid0 = 131,
		Beyond-Lua-LuaTestReflectionOpt-TestInt0 = 132,
		Beyond-Lua-LuaTestReflectionOpt-TestStructParam0 = 133,
		Beyond-Lua-LuaTestReflectionOpt-TestStructParam1 = 134,
		Beyond-Lua-LuaTestReflectionOpt-TestStructParam20 = 135,
		Beyond-Lua-LuaTestReflectionOpt-TestReturnObj0 = 136,
		Beyond-Lua-LuaTestReflectionOpt-TestObjParam0 = 137,
		Beyond-Lua-LuaTestReflectionOpt-TestEnum0 = 138,
		Beyond-Lua-LuaTestReflectionOpt-TestReturnEnum0 = 139,
		Beyond-Lua-LuaTestReflectionOpt-TestStruct0 = 140,
		Beyond-Lua-LuaUIWidget-Reset0 = 141,
		Beyond-Lua-LuaUIWidget-OnEnable0 = 142,
		Beyond-Lua-LuaUIWidget-OnDisable0 = 143,
		Beyond-Lua-LuaUIWidget-OnDestroy0 = 144,
		Beyond-Lua-LuaUIWidget-ClearComponent0 = 145,
		Beyond-Lua-UtilsForLua-CreateObject0 = 148,
		Beyond-Lua-UtilsForLua-CreateObject1 = 149,
		Beyond-Lua-UtilsForLua-CreateObject2 = 150,
		Beyond-Lua-UtilsForLua-UIContainerResize0 = 151,
		Beyond-Lua-UtilsForLua-TurnOffLayer0 = 152,
		Beyond-Lua-UtilsForLua-TurnOnLayer0 = 153,
		Beyond-Lua-UtilsForLua-ToggleLayer0 = 154,
		Beyond-Lua-UtilsForLua-SetPosX0 = 155,
		Beyond-Lua-UtilsForLua-SetPosY0 = 156,
		Beyond-Lua-UtilsForLua-SetPosZ0 = 157,
		Beyond-Lua-UtilsForLua-SetRotX0 = 158,
		Beyond-Lua-UtilsForLua-SetRotY0 = 159,
		Beyond-Lua-UtilsForLua-SetRotZ0 = 160,
		Beyond-Lua-UtilsForLua-SetScaleX0 = 161,
		Beyond-Lua-UtilsForLua-SetScaleY0 = 162,
		Beyond-Lua-UtilsForLua-SetScaleZ0 = 163,
		Beyond-Lua-UtilsForLua-ClearUIComponents0 = 164,
		Beyond-Lua-UtilsForLua-RayCast0 = 165,
		Beyond-Lua-UtilsForLua-RaycastNonAlloc0 = 166,
		Beyond-Lua-UtilsForLua-GetRectTransformBounds0 = 167,
		Beyond-Lua-UtilsForLua-RectTransformToScreenRect0 = 168,
		Beyond-Lua-UtilsForLua-GetRectTransformCenterPosition0 = 169,
		Beyond-Lua-UtilsForLua-CalcBoundOfRectTransform0 = 170,
		Beyond-Lua-UtilsForLua-ClampPointInRectTransform0 = 171,
		Beyond-Lua-UtilsForLua-GetStringList0 = 172,
		Beyond-Lua-UtilsForLua-GetStringHash0 = 173,
		Beyond-Lua-UtilsForLua-EntityDistance0 = 174,
		Beyond-Lua-UtilsForLua-OpenAccountCenter0 = 175,
		Beyond-Lua-UtilsForLua-ExitGame0 = 176,
		Beyond-Lua-UtilsForLua-GetCurrentUID0 = 177,
		Beyond-Lua-UtilsForLua-StartPayment0 = 178,
		Beyond-Lua-UtilsForLua-TryGetCharacterVolume0 = 179,
		Beyond-Lua-UtilsForLua-GetAnimationCurveLength0 = 180,
		Beyond-Lua-UtilsForLua-TweenTo0 = 181,
		Beyond-Lua-UtilsForLua-IsNull0 = 185,
		Beyond-Lua-UtilsForLua-ParseImageContent0 = 186,
		Beyond-Lua-UtilsForLua-ReturnToLogin0 = 187,
		Beyond-Lua-UtilsForLua-QuitGame0 = 188,
		Beyond-Lua-UtilsForLua-CheckExtremeDangerousByLevel0 = 189,
		Beyond-Lua-UtilsForLua-ToggleCharInfoInUpgradePanelOption0 = 190,
		Beyond-Lua-UtilsForLua-ToggleWeaponInUpgradePanelOption0 = 191,
		Beyond-Lua-UtilsForLua-GetCinemachineTransposer0 = 192,
		Beyond-Lua-UtilsForLua-GetCinemachineComposer0 = 193,
		Beyond-Lua-UtilsForLua-GetOrAddCinemachineCameraOffset0 = 194
	}
}
