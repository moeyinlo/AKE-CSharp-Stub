/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
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

// Image 63: Lua.Beyond.dll - Assembly: Lua.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 88930-89080

namespace Beyond.Lua
{
	public abstract class CsToLuaClass // TypeDefIndex: 88939
	{
		// Fields
		protected LuaTable m_luaTable; // 0x10
	
		// Constructors
		public CsToLuaClass(string luaPath); // 0x000000018C2EC36C-0x000000018C2EC444
	}

	public class LuaEventSystem : ILuaEventSystem, IDisposable // TypeDefIndex: 88948
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
		public delegate void DispatchEventFunc(string eventName, LuaTable luaTable); // TypeDefIndex: 88940; 0x00000001859B7730-0x00000001859B7740
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 88941
		{
			// Fields
			public LuaEventSystem __4__this; // 0x10
			public string eventName; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _DispatchEvent_b__0(); // 0x000000018709E8E0-0x000000018709E9C0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0<T> // TypeDefIndex: 88942
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
		private sealed class __c__DisplayClass11_0<T0, T1> // TypeDefIndex: 88943
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
		private sealed class __c__DisplayClass12_0<T0, T1, T2> // TypeDefIndex: 88944
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
		private sealed class __c__DisplayClass13_0<T0, T1, T2, T3> // TypeDefIndex: 88945
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
		private sealed class __c__DisplayClass14_0<T0, T1, T2, T3, T4> // TypeDefIndex: 88946
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
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0<T0, T1, T2, T3, T4, T5> // TypeDefIndex: 88947
		{
			// Fields
			public LuaEventSystem __4__this;
			public string eventName;
			public T0 arg0;
			public T1 arg1;
			public T2 arg2;
			public T3 arg3;
			public T4 arg4;
			public T5 arg5;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _DispatchEvent_b__0();
		}
	
		// Constructors
		public LuaEventSystem(); // 0x0000000186CD9440-0x0000000186CD9650
	
		// Methods
		public void DispatchEvent(string eventName); // 0x0000000185A82EB0-0x0000000185A83040
		public void DispatchEvent<T>(string eventName, T arg);
		public void DispatchEvent<T0, T1>(string eventName, T0 arg0, T1 arg1);
		public void DispatchEvent<T0, T1, T2>(string eventName, T0 arg0, T1 arg1, T2 arg2);
		public void DispatchEvent<T0, T1, T2, T3>(string eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3);
		public void DispatchEvent<T0, T1, T2, T3, T4>(string eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public void DispatchEvent<T0, T1, T2, T3, T4, T5>(string eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		public void PushEventName(string eventName); // 0x0000000185A83040-0x0000000185A831D0
		public void Dispose(); // 0x000000018C2EF26C-0x000000018C2EF30C
	}

	public class CSharpCallLuaRegistration // TypeDefIndex: 88949
	{
		// Fields
		private LuaEventSystem m_luaEventSystem; // 0x10
	
		// Constructors
		public CSharpCallLuaRegistration(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Init(); // 0x0000000186CD8570-0x0000000186CD9440
		public void Dispose(); // 0x000000018C2EC2C4-0x000000018C2EC36C
	}

	public class LuaCustomConfig : MonoBehaviour, ILuaCallCSharp, ISerializationCallbackReceiver // TypeDefIndex: 88954
	{
		// Fields
		[SerializeField]
		public List<Item> itemList; // 0x18
		private Dictionary<string, Item> m_itemDict; // 0x20
	
		// Properties
		public Dictionary<string, Item> itemDict { get; } // 0x00000001869A0B20-0x00000001869A0D60 
	
		// Nested types
		public enum ValueType // TypeDefIndex: 88950
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
		public class Item : ILuaCallCSharp // TypeDefIndex: 88951
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
			public Item(); // 0x0000000185F5DA60-0x0000000185F5DCB0
	
			// Methods
			public bool HasLuaValueChanged(); // 0x000000018C2ECEC8-0x000000018C2ECF1C
			public bool ShouldSerializeLuaTableJson(); // 0x000000018C2ECF64-0x000000018C2ECFB8
			public void MarkLuaValueProcessed(); // 0x000000018C2ECF1C-0x000000018C2ECF64
			public System.Type GetEnumType(); // 0x000000018C2ECB24-0x000000018C2ECD14
			public object GetEnumValueObject(); // 0x000000018C2ECD14-0x000000018C2ECEC8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 88952
		{
			// Fields
			public List<object> keys1; // 0x10
			public List<object> keys2; // 0x18
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __CompareLuaTables_b__0(object k, object _); // 0x000000018C2F2C3C-0x000000018C2F2C90
			internal void __CompareLuaTables_b__1(object k, object _); // 0x000000018C2F2C90-0x000000018C2F2CE4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 88953
		{
			// Fields
			public JObject jObject; // 0x10
	
			// Constructors
			public __c__DisplayClass23_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _ConvertLuaTableToJson_b__0(object key, object value); // 0x000000018C2F2CE4-0x000000018C2F2DE8
		}
	
		// Constructors
		public LuaCustomConfig(); // 0x000000018548CF20-0x000000018548CF90
	
		// Methods
		public void OnBeforeSerialize(); // 0x00000001864D2470-0x00000001864D2510
		public void OnAfterDeserialize(); // 0x000000018644ABA0-0x000000018644ABD0
		private bool _ProcessLuaTableItem(Item item); // 0x000000018C2EED00-0x000000018C2EEF80
		public bool ShouldProcessEnumItem(Item item); // 0x000000018C2ED404-0x000000018C2ED488
		private bool _ProcessEnumItem(Item item); // 0x000000018C2EEB20-0x000000018C2EED00
		private bool _ValidateLuaTableConsistency(string luaCode, string json); // 0x000000018C2EEF80-0x000000018C2EF26C
		private LuaTable _JsonToLuaTableForValidation(string json, LuaEnv luaEnv); // 0x000000018C2EDED4-0x000000018C2EE024
		private void _PopulateLuaTableFromJTokenForValidation(LuaTable luaTable, JToken jToken, LuaEnv luaEnv); // 0x000000018C2EE1DC-0x000000018C2EE670
		private object _ConvertJValueToObjectForValidation(JToken jValue); // 0x000000018C2EDA38-0x000000018C2EDBBC
		private bool _CompareLuaTables(LuaTable table1, LuaTable table2); // 0x000000018C2ED488-0x000000018C2ED8EC
		private bool _CompareValues(object value1, object value2); // 0x000000018C2ED8EC-0x000000018C2EDA38
		private bool _IsNumericType(object obj); // 0x000000018C2EDD3C-0x000000018C2EDED4
		public void InitConfigTable(LuaTable configTable); // 0x0000000185A82220-0x0000000185A82EB0
		private LuaTable _JsonToLuaTable(string json, LuaEnv luaEnv); // 0x000000018C2EE024-0x000000018C2EE1DC
		private void _PopulateLuaTableFromJToken(LuaTable luaTable, JToken jToken); // 0x000000018C2EE670-0x000000018C2EEB20
		private object _ConvertJValueToObject(JToken jValue); // 0x000000018C2EDBBC-0x000000018C2EDD3C
		public static string ConvertLuaCodeToJson(string luaCode); // 0x000000018C2ECFB8-0x000000018C2ED284
		public static string ConvertLuaTableToJson(LuaTable luaTable); // 0x000000018C2ED284-0x000000018C2ED404
	}

	public class LuaDebugSocketManager : MonoBehaviour // TypeDefIndex: 88955
	{
		// Constructors
		public LuaDebugSocketManager(); // 0x00000001878364A0-0x00000001878364B8
	}

	public static class LuaHotFix // TypeDefIndex: 88957
	{
		// Nested types
		[CSharpCallLua]
		public delegate bool LuaHotFixInvoker(string luaCode); // TypeDefIndex: 88956; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Methods
		public static void LuaHotFixTest(); // 0x000000018C2EF87C-0x000000018C2EF8AC
		[IDTag(1)]
		public static bool HotFixLua(string lua); // 0x000000018C2EF780-0x000000018C2EF87C
		[IDTag(2)]
		public static bool HotFixLua(byte[] lua); // 0x000000018C2EF30C-0x000000018C2EF3AC
		[IDTag(0)]
		public static bool HotFixLua(Span<byte> lua, int length); // 0x000000018C2EF3AC-0x000000018C2EF780
	}

	public static class LuaLogBuffer // TypeDefIndex: 88958
	{
	}

	public class LoadLuaProxy : ILoadLuaProxy // TypeDefIndex: 88959
	{
		// Constructors
		public LoadLuaProxy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void _RunOnStart(); // 0x0000000187106430-0x00000001871064E0
		public byte[] LoadLua(string name); // 0x0000000185C49E00-0x0000000185C49E80
	}

	public class LuaMethodPointerModule // TypeDefIndex: 88960
	{
		// Constructors
		public LuaMethodPointerModule(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void _RunOnStart(); // 0x0000000186FAF4D0-0x0000000186FAF610
	}

	public class LuaManager : BaseTickManager, ILuaProxy // TypeDefIndex: 88963
	{
		// Fields
		[CompilerGenerated]
		private static LuaManager _instance_k__BackingField; // 0x00
		private const float TICK_INTERVAL = 1f; // Metadata: 0x02648835
		private readonly CSharpCallLuaRegistration m_csCallLua; // 0x70
		private PeriodicTimer m_envTickTimer; // 0x78
		public static bool s_xluaReflectionOpt; // 0x08
		[CompilerGenerated]
		private LuaEnv _luaEnv_k__BackingField; // 0x80
		public Action<LuaTable, string, LuaUIWidget> wrapUIWidgetFunction; // 0x88
		public Action<LuaTable, string, LuaReference> bindLuaRefFunction; // 0x90
		private bool m_isQuittingApplication; // 0x98
		private const int MAX_LUA_ENV_DISPOSE_RETRY = 5; // Metadata: 0x02648839
		public TickEvent actionTick; // 0xA0
		public TickEvent actionLateTick; // 0xA8
		public TickEvent actionTailTick; // 0xB0
		public TickEvent actionRenderDone; // 0xB8
	
		// Properties
		public static LuaManager instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187200B20-0x0000000187200B70 0x000000018C2F09B0-0x000000018C2F0A0C
		public LuaEnv luaEnv { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828D49D0-0x00000001828D49E0 0x00000001870EAAE0-0x00000001870EAAF0
		public bool isQuittingApplication { get; set; } // 0x000000018C2F096C-0x000000018C2F09B0 0x000000018C2F0A0C-0x000000018C2F0A94
		public override FrameTickGroup frameTickGroup { get; } // 0x0000000187225FE0-0x0000000187226010 
	
		// Nested types
		public class TickEvent : DisposedUnityEvent<float> // TypeDefIndex: 88961
		{
			// Constructors
			public TickEvent(); // 0x00000001864E45A0-0x00000001864E45E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0 // TypeDefIndex: 88962
		{
			// Fields
			public LuaManager __4__this; // 0x10
			public LuaEnv env; // 0x18
			public int retryCount; // 0x20
	
			// Constructors
			public __c__DisplayClass29_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __ReleaseDelegateInAnotherStackFrame_b__0(); // 0x000000018C2F2DE8-0x000000018C2F2E18
		}
	
		// Constructors
		public LuaManager(); // 0x00000001864E4410-0x00000001864E45A0
		static LuaManager(); // 0x00000001872201F0-0x0000000187220230
	
		// Methods
		public static void CreateInstance(); // 0x00000001864E3580-0x00000001864E36D0
		public static void DestroyInstance(); // 0x000000018C2EF8AC-0x000000018C2EF984
		public static bool IsEnableMultithreadGC(); // 0x0000000185A83C40-0x0000000185A83D70
		public static bool IsLuaGCing(); // 0x0000000185A82100-0x0000000185A82220
		protected override void OnInit(); // 0x00000001858D7520-0x00000001858D8070
		public static string GetLuaStack(); // 0x0000000185C49A40-0x0000000185C49C80
		protected override void OnRelease(); // 0x000000018C2EFC20-0x000000018C2F0194
		public static void ReStartLuaProfiler(); // 0x000000018C2F0194-0x000000018C2F01C4
		[IDTag(1)]
		private void _ReleaseDelegateInAnotherStackFrame(); // 0x000000018C2F06E0-0x000000018C2F0724
		[IDTag(0)]
		private void _ReleaseDelegateInAnotherStackFrame(LuaEnv env, int retryCount); // 0x000000018C2F0724-0x000000018C2F096C
		private static void _DumpResidualDelegateBridges(LuaEnv env, bool asCritical); // 0x000000018C2F0294-0x000000018C2F03E0
		public override void Tick(float deltaTime); // 0x000000018559DF10-0x000000018559EC90
		public override void LateTick(float deltaTime); // 0x000000018559EC90-0x000000018559EDA0
		public override void TailLateTick(float deltaTime); // 0x000000018559EDA0-0x000000018559EEB0
		public string GetLuaFileRealPath(string modulePath); // 0x000000018C2EF984-0x000000018C2EFA14
		public bool IsLuaFileExist(string modulePath); // 0x000000018565AF70-0x000000018565AFC0
		public long LoadLuaByteByFileRealPath(string modulePath, out int len); // 0x000000018C2EFA14-0x000000018C2EFAE8
		public byte[] LoadLua(string modulePath); // 0x000000018568DF50-0x000000018568DFA0
		public IntPtr LoadLuaBytePtr(string modulePath); // 0x000000018C2EFAE8-0x000000018C2EFC20
		public byte[] LoadLuaBytes(ref string modulePath); // 0x0000000186E14800-0x0000000186E14890
		private void _RegisterCSharpCallLua(); // 0x0000000186CD8530-0x0000000186CD8570
		private static void _Register3rdPartyLibraries(LuaEnv env); // 0x0000000185C4A7F0-0x0000000185C4AA70
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static void _HyperLuaLogCallback(IntPtr L, int level, string text); // 0x000000018C2F03E0-0x000000018C2F04D4
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static void _LuaUtilsLogCallback(int level, string text); // 0x000000018C2F04D4-0x000000018C2F056C
		private void _OnEnvLangChanged(EnvLang lang); // 0x000000018C2F056C-0x000000018C2F064C
		public object[] DoString(string code); // 0x0000000185C49F20-0x0000000185C49FB0
		public IntPtr GetLuaState(); // 0x0000000185E3A0F0-0x0000000185E3A130
		public void ClearAllUnityObjectUserdata(); // 0x00000001861DA8C0-0x00000001861DA920
		[IDTag(1)]
		private void _OnRenderDone(HGRenderPipeCallbackArgs args); // 0x000000018C2F064C-0x000000018C2F06E0
		[IDTag(0)]
		private void _OnRenderDone(); // 0x000000018559EF50-0x000000018559EF90
		public bool AddLuaEventAfterGCDo(UnityAction action); // 0x0000000186D2E1A0-0x0000000186D2E1F0
		public static void RemoveLuaEventAfterGCDo(UnityAction action); // 0x000000018C2F01C4-0x000000018C2F0294
		public void AddOnceLuaEventAfterGCDo(UnityAction action); // 0x000000018709C7E0-0x000000018709C830
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LuaCalculateABPathHash(IntPtr L); // 0x00000001861A8E70-0x00000001861A8F10
		public static void CasterStringPathHash(IntPtr L, int index, out StringPathHash o); // 0x00000001854E81A0-0x00000001854E8240
		public static bool CheckStringPathHash(IntPtr L, int index); // 0x00000001863FEC90-0x00000001863FECF0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188D6202C-0x0000000188D62034
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D6200C-0x0000000188D62014
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000188D62024-0x0000000188D6202C
		public FrameTickGroup __iFixBaseProxy_get_frameTickGroup(); // 0x0000000188F1C35C-0x0000000188F1C364
	}

	[ExecuteInEditMode]
	public class LuaReference : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 88968
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
		public class ComponentRefDict : SerializeReferenceDictionary<string, Component> // TypeDefIndex: 88964
		{
			// Constructors
			public ComponentRefDict(); // 0x000000018548DE50-0x000000018548DE90
		}
	
		[Serializable]
		public class RefExtraInfo // TypeDefIndex: 88966
		{
			// Fields
			public List<CustomUIStyleInfo> customUIStyles; // 0x10
	
			// Nested types
			[Serializable]
			public class CustomUIStyleInfo // TypeDefIndex: 88965
			{
				// Fields
				public CustomUIStyle style; // 0x10
				public Component component; // 0x18
	
				// Constructors
				public CustomUIStyleInfo(); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Constructors
			public RefExtraInfo(); // 0x0000000186A51CB0-0x0000000186A51D30
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 88967
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<LuaReference> __9__8_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018C2F2E18-0x000000018C2F2E7C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Reset_b__8_0(LuaReference item); // 0x000000018C2F2BF0-0x000000018C2F2C3C
		}
	
		// Constructors
		public LuaReference(); // 0x000000018548D970-0x000000018548DB40
	
		// Methods
		private void Reset(); // 0x000000018C2F1188-0x000000018C2F1418
		private void OnDestroy(); // 0x0000000185A806F0-0x0000000185A80740
		private void _UnBindFromXluaRef(); // 0x0000000185A80CD0-0x0000000185A81230
		public void BindToLua(LuaTable table); // 0x0000000185A80740-0x0000000185A80CD0
		private void _BindSelfReferences(LuaTable table); // 0x0000000185A812A0-0x0000000185A82010
		public bool RefreshCustomUIStyleBindings(); // 0x000000018C2F0F94-0x000000018C2F1188
		private bool _RefreshSelfCustomUIStyleBindings(LuaTable table); // 0x000000018C2F1418-0x000000018C2F19BC
		public bool ContainsGameObject(GameObject obj, bool recursive = true /* Metadata: 0x0264883A */); // 0x000000018C2F0A94-0x000000018C2F0F94
	}

	public struct LuaTestReflectionOptStruct // TypeDefIndex: 88969
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
		public int a1 { get; } // 0x000000018C2F2480-0x000000018C2F24C0 
		public string b1 { get; } // 0x000000018C2F24C0-0x000000018C2F2500 
		public long l1 { get; } // 0x000000018C2F25CC-0x000000018C2F260C 
		public ulong ul1 { get; } // 0x000000018C2F260C-0x000000018C2F264C 
		public float f1 { get; } // 0x000000018C2F2588-0x000000018C2F25CC 
		public double d1 { get; } // 0x000000018C2F2544-0x000000018C2F2588 
		public bool bl1 { get; } // 0x000000018C2F2500-0x000000018C2F2544 
	
		// Constructors
		public LuaTestReflectionOptStruct(int a, string b, long l, ulong ul, float f, double d, bool bl); // 0x000000018C2F2438-0x000000018C2F2480
	
		// Methods
		public int TestInt(int a); // 0x000000018C2F227C-0x000000018C2F22B4
		public void TestVoid(); // 0x000000018C2F2404-0x000000018C2F2438
		public void TestStructParam(LuaTestReflectionOptStruct testStruct); // 0x000000018C2F23A0-0x000000018C2F2404
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct); // 0x000000018C2F2368-0x000000018C2F23A0
		public object TestReturnObj(); // 0x000000018C2F22EC-0x000000018C2F2368
		public void TestObjParam(object obj); // 0x000000018C2F22B4-0x000000018C2F22EC
	}

	public struct LuaTestReflectionOptStruct2 // TypeDefIndex: 88970
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
		public int a1 { get; } // 0x000000018C2F20B0-0x000000018C2F20F0 
		public string b1 { get; } // 0x000000018C2F20F0-0x000000018C2F2130 
		public long l1 { get; } // 0x000000018C2F21FC-0x000000018C2F223C 
		public ulong ul1 { get; } // 0x000000018C2F223C-0x000000018C2F227C 
		public float f1 { get; } // 0x000000018C2F21B8-0x000000018C2F21FC 
		public double d1 { get; } // 0x000000018C2F2174-0x000000018C2F21B8 
		public bool bl1 { get; } // 0x000000018C2F2130-0x000000018C2F2174 
	
		// Methods
		public int TestInt(int a); // 0x000000018C2F1EF4-0x000000018C2F1F2C
		public void TestVoid(); // 0x000000018C2F207C-0x000000018C2F20B0
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct); // 0x000000018C2F2018-0x000000018C2F207C
		public void TestStructParam2(ref LuaTestReflectionOptStruct2 testStruct); // 0x000000018C2F1FE0-0x000000018C2F2018
		public object TestReturnObj(); // 0x000000018C2F1F64-0x000000018C2F1FE0
		public void TestObjParam(object obj); // 0x000000018C2F1F2C-0x000000018C2F1F64
	}

	public enum ETestEnum // TypeDefIndex: 88971
	{
		Test1 = 2,
		Test2 = 2
	}

	public class LuaTestReflectionOpt2 // TypeDefIndex: 88972
	{
		// Fields
		public List<int> TestList; // 0x10
		public Dictionary<int, string> TestDict; // 0x18
	
		// Constructors
		public LuaTestReflectionOpt2(); // 0x000000018C2F1D68-0x000000018C2F1EF4
	
		// Methods
		public void TestVoid(); // 0x000000018C2F1D34-0x000000018C2F1D68
		public int TestInt(int a); // 0x000000018C2F19F4-0x000000018C2F1A2C
		[IDTag(0)]
		public void TestStructParam(LuaTestReflectionOptStruct testStruct); // 0x000000018C2F1BC0-0x000000018C2F1C24
		[IDTag(1)]
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct); // 0x000000018C2F1B5C-0x000000018C2F1BC0
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct); // 0x000000018C2F1B24-0x000000018C2F1B5C
		public object TestReturnObj(); // 0x000000018C2F1AA8-0x000000018C2F1B24
		public void TestObjParam(object obj); // 0x000000018C2F1A2C-0x000000018C2F1A64
		public void TestEnum(ETestEnum e); // 0x000000018C2F19BC-0x000000018C2F19F4
		public ETestEnum TestReturnEnum(); // 0x000000018C2F1A64-0x000000018C2F1AA8
		public LuaTestReflectionOptStruct TestStruct(LuaTestReflectionOptStruct a); // 0x000000018C2F1C24-0x000000018C2F1D34
	}

	public class LuaTestReflectionOpt // TypeDefIndex: 88973
	{
		// Fields
		public List<int> TestList; // 0x10
		public Dictionary<int, string> TestDict; // 0x18
	
		// Constructors
		public LuaTestReflectionOpt(); // 0x000000018C2F29F8-0x000000018C2F2B84
	
		// Methods
		public void TestVoid(); // 0x000000018C2F29C4-0x000000018C2F29F8
		public int TestInt(int a); // 0x000000018C2F2684-0x000000018C2F26BC
		[IDTag(0)]
		public void TestStructParam(LuaTestReflectionOptStruct testStruct); // 0x000000018C2F2850-0x000000018C2F28B4
		[IDTag(1)]
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct); // 0x000000018C2F27EC-0x000000018C2F2850
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct); // 0x000000018C2F27B4-0x000000018C2F27EC
		public object TestReturnObj(); // 0x000000018C2F2738-0x000000018C2F27B4
		public void TestObjParam(object obj); // 0x000000018C2F26BC-0x000000018C2F26F4
		public void TestEnum(ETestEnum e); // 0x000000018C2F264C-0x000000018C2F2684
		public ETestEnum TestReturnEnum(); // 0x000000018C2F26F4-0x000000018C2F2738
		public LuaTestReflectionOptStruct TestStruct(LuaTestReflectionOptStruct a); // 0x000000018C2F28B4-0x000000018C2F29C4
	}

	public class LuaUIWidget : MonoBehaviour, IUIClearable // TypeDefIndex: 88974
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
		public LuaTable table { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x000000018658F530-0x000000018658F540
	
		// Constructors
		public LuaUIWidget(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		private void Reset(); // 0x000000018C2F2B84-0x000000018C2F2BF0
		private void OnEnable(); // 0x0000000185385A50-0x0000000185385AB0
		private void OnDisable(); // 0x0000000185385AB0-0x0000000185385B10
		private void OnDestroy(); // 0x00000001863B3410-0x00000001863B3440
		public void ClearComponent(); // 0x0000000185722330-0x0000000185722430
	}

	public static class UtilsForLua // TypeDefIndex: 88980
	{
		// Fields
		private static Vector3[] s_worldCorners; // 0x00
		private static readonly Regex IMAGE_CONTENT_REGEX; // 0x08
	
		// Nested types
		public class ImageContentParam // TypeDefIndex: 88975
		{
			// Fields
			public string path; // 0x10
	
			// Constructors
			public ImageContentParam(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 88976
		{
			// Fields
			public float from; // 0x10
			public LuaFunction setter; // 0x18
	
			// Constructors
			public __c__DisplayClass34_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _TweenTo_b__0(); // 0x0000000187232D00-0x0000000187232D10
			internal void _TweenTo_b__1(float value); // 0x00000001853856D0-0x00000001853857A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0 // TypeDefIndex: 88977
		{
			// Fields
			public bool isGcFinished; // 0x10
	
			// Constructors
			public __c__DisplayClass48_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __ForceGCWithBlackScreen_b__0(); // 0x00000001829D07F0-0x00000001829D0800
		}
	
		[CompilerGenerated]
		private sealed class __ForceGCWithBlackScreen_d__48 : IEnumerator<object> // TypeDefIndex: 88978
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float timeoutSec; // 0x20
			private __c__DisplayClass48_0 __8__1; // 0x28
			public float fadeOutTime; // 0x30
			private float _deadline_5__2; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ForceGCWithBlackScreen_d__48(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001849DD3E0-0x00000001849DE5B0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001849DE5B0-0x00000001849DE600
		}
	
		[CompilerGenerated]
		private sealed class __RunForceGC_d__49 : IEnumerator<object> // TypeDefIndex: 88979
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Action onFinished; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __RunForceGC_d__49(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001849DE600-0x00000001849DE990
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x00000001849DE990-0x00000001849DE9E0
		}
	
		// Constructors
		static UtilsForLua(); // 0x00000001871D5200-0x00000001871D5DC0
	
		// Methods
		[IDTag(0)]
		public static GameObject CreateObject(GameObject asset); // 0x000000018702BBA0-0x000000018702BC30
		[IDTag(1)]
		public static GameObject CreateObject(GameObject asset, Transform parent); // 0x00000001851BDD10-0x00000001851BDD70
		[IDTag(2)]
		public static GameObject CreateObject(GameObject asset, GameObject parent); // 0x00000001851BDC90-0x00000001851BDD10
		public static void UIContainerResize(Transform container, int size, int templateIndex = 0 /* Metadata: 0x0264883D */); // 0x000000018685AC40-0x000000018685ADB0
		public static int TurnOffLayer(int value, string layerName); // 0x000000018C2F42D0-0x000000018C2F432C
		public static int TurnOnLayer(int value, string layerName); // 0x000000018C2F432C-0x000000018C2F4388
		public static int ToggleLayer(int value, string layerName); // 0x000000018C2F4158-0x000000018C2F41B4
		public static void ClearUIComponents(GameObject gameObject); // 0x0000000186967CE0-0x0000000186967D30
		public static bool RayCast(out RaycastHit hitInfo, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction interaction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x0264883E */); // 0x000000018C2F38D8-0x000000018C2F39D8
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction interaction); // 0x000000018C2F39D8-0x000000018C2F3AD8
		public static Bounds GetRectTransformBounds(RectTransform transform); // 0x000000018599BEB0-0x000000018599C030
		public static UnityEngine.Rect RectTransformToScreenRect(RectTransform rectTransform, Camera uiCamera); // 0x0000000185C89D80-0x0000000185C89E00
		public static Vector3 GetRectTransformCenterPosition(RectTransform rectTransform); // 0x000000018C2F34A0-0x000000018C2F35D8
		public static Bounds CalcBoundOfRectTransform(RectTransform transform, RectTransform local); // 0x000000018C2F2E7C-0x000000018C2F2F3C
		public static Vector2 ClampPointInRectTransform(RectTransform source, RectTransform target, Vector2 sourcePoint); // 0x000000018C2F30D0-0x000000018C2F317C
		public static List<string> GetStringList(); // 0x000000018C2F361C-0x000000018C2F36B0
		public static int GetStringHash(string str); // 0x000000018C2F35D8-0x000000018C2F361C
		public static float EntityDistance(Entity a, Entity b); // 0x000000018C2F317C-0x000000018C2F3234
		public static void OpenAccountCenter(); // 0x000000018C2F36B0-0x000000018C2F3720
		public static void ExitGame(); // 0x000000018C2F3234-0x000000018C2F32B4
		public static string GetCurrentUID(); // 0x000000018C2F3414-0x000000018C2F34A0
		public static bool StartPayment(string productId, string signParams); // 0x000000018C2F40D8-0x000000018C2F4158
		public static bool TryGetCharacterVolume(UnityEngine.Rendering.Volume volume, out HGCharacterVolume hgCharacterVolume); // 0x000000018C2F422C-0x000000018C2F42D0
		public static float GetAnimationCurveLength(AnimationCurve curve); // 0x00000001871C7090-0x00000001871C70F0
		public static Tweener TweenTo(float from, float to, float duration, LuaFunction setter); // 0x0000000186BAB4F0-0x0000000186BAB680
		public static bool IsNull(UnityEngine.Object o); // 0x000000018621E540-0x000000018621E5C0
		public static ImageContentParam ParseImageContent(string content); // 0x000000018C2F3720-0x000000018C2F38A0
		public static void ReturnToLogin(); // 0x000000018C2F3AD8-0x000000018C2F3B5C
		public static void QuitGame(int exitCode); // 0x000000018C2F38A0-0x000000018C2F38D8
		public static bool CheckExtremeDangerousByLevel(int level); // 0x000000018C2F2F3C-0x000000018C2F30D0
		public static void ToggleCharInfoInUpgradePanelOption(bool isIn); // 0x00000001861E8220-0x00000001861E8280
		public static void ToggleWeaponInUpgradePanelOption(bool isIn); // 0x000000018C2F41B4-0x000000018C2F422C
		public static CinemachineTransposer GetCinemachineTransposer(CinemachineVirtualCamera vcam); // 0x000000018C2F3364-0x000000018C2F3414
		public static CinemachineComposer GetCinemachineComposer(CinemachineVirtualCamera vcam); // 0x000000018C2F32B4-0x000000018C2F3364
		public static CinemachineCameraOffset GetOrAddCinemachineCameraOffset(CinemachineVirtualCamera vcam); // 0x00000001851AC880-0x00000001851AC910
		public static void ForceGCWithBlackScreen(string desc, float timeoutSec = 5f /* Metadata: 0x0264883F */, float fadeInTime = 0.1f /* Metadata: 0x02648843 */, float fadeOutTime = 0.1f /* Metadata: 0x02648847 */); // 0x00000001849DE9E0-0x00000001849DF830
		[IteratorStateMachine(typeof(__ForceGCWithBlackScreen_d__48))]
		private static IEnumerator _ForceGCWithBlackScreen(string desc, float timeoutSec, float fadeOutTime); // 0x00000001849DF830-0x00000001849DFBA0
		[IteratorStateMachine(typeof(__RunForceGC_d__49))]
		private static IEnumerator _RunForceGC(Action onFinished); // 0x00000001849DFBA0-0x00000001849DFF50
	
		// Extension methods
		public static void SetPosX(this Transform t, float value); // 0x000000018C2F3B5C-0x000000018C2F3BFC
		public static void SetPosY(this Transform t, float value); // 0x000000018C2F3BFC-0x000000018C2F3C9C
		public static void SetPosZ(this Transform t, float value); // 0x000000018C2F3C9C-0x000000018C2F3D30
		public static void SetRotX(this Transform t, float value); // 0x000000018C2F3D30-0x000000018C2F3DD0
		public static void SetRotY(this Transform t, float value); // 0x000000018C2F3DD0-0x000000018C2F3E70
		public static void SetRotZ(this Transform t, float value); // 0x000000018C2F3E70-0x000000018C2F3F04
		public static void SetScaleX(this Transform t, float value); // 0x000000018C2F3F04-0x000000018C2F3FA4
		public static void SetScaleY(this Transform t, float value); // 0x000000018C2F3FA4-0x000000018C2F4044
		public static void SetScaleZ(this Transform t, float value); // 0x000000018C2F4044-0x000000018C2F40D8
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 88932
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 88933
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 88934
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 88935
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 88936
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 88937
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 88938
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 88931
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 88981
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018C2EC9E0-0x000000018C2ECA44
	
		// Methods
		public void __Gen_Wrap_0(object P0, object P1); // 0x0000000188B47220-0x0000000188B472F0
		public bool __Gen_Wrap_1(); // 0x00000001887ECE94-0x00000001887ECF30
		public void __Gen_Wrap_2(); // 0x00000001887ED074-0x00000001887ED104
		public void __Gen_Wrap_3(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public Dictionary<string, LuaCustomConfig.Item> __Gen_Wrap_4(object P0); // 0x000000018C2EC604-0x000000018C2EC6E4
		public string __Gen_Wrap_5(object P0); // 0x000000018C2EC6E4-0x000000018C2EC7C4
		public object __Gen_Wrap_6(object P0, object P1); // 0x000000018C2EC7C4-0x000000018C2EC8C4
		public void __Gen_Wrap_7(object P0, object P1, object P2, object P3); // 0x000000018C0C986C-0x000000018C0C996C
		public LuaTable __Gen_Wrap_8(object P0, object P1, object P2); // 0x000000018C2EC8C4-0x000000018C2EC9E0
		public bool __Gen_Wrap_9(object P0, object P1); // 0x00000001887F2FB4-0x00000001887F3094
		public bool __Gen_Wrap_10(object P0, object P1, object P2); // 0x000000018C0E006C-0x000000018C0E0164
		public void __Gen_Wrap_11(object P0, object P1, object P2); // 0x00000001887EF660-0x00000001887EF74C
		public System.Type __Gen_Wrap_12(object P0); // 0x000000018C2EC444-0x000000018C2EC524
		public object __Gen_Wrap_13(object P0); // 0x000000018C2EC524-0x000000018C2EC604
		public bool __Gen_Wrap_14(object P0); // 0x0000000188B46E14-0x0000000188B46ED4
		public bool __Gen_Wrap_15(Span<byte> P0, int P1); // 0x00000001849B4DE0-0x00000001849B53B0
		public byte[] __Gen_Wrap_16(object P0, object P1); // 0x00000001849B53B0-0x00000001849B5DB0
		public void __Gen_Wrap_17(object P0, HGRenderPipeCallbackArgs P1); // 0x00000001849B5DB0-0x00000001849B6430
		public string __Gen_Wrap_18(); // 0x00000001849B6430-0x00000001849B6C50
		public void __Gen_Wrap_19(IntPtr P0, int P1, object P2); // 0x000000018339B680-0x000000018339B980
		public void __Gen_Wrap_20(int P0, object P1); // 0x0000000182220EE0-0x00000001822211B0
		public byte[] __Gen_Wrap_21(object P0, ref string P1); // 0x00000001849B6C50-0x00000001849B79A0
		public void __Gen_Wrap_22(object P0, EnvLang P1); // 0x00000001824828A0-0x0000000182482B70
		public int __Gen_Wrap_23(IntPtr P0); // 0x0000000182224090-0x0000000182224290
		public void __Gen_Wrap_24(IntPtr P0, int P1, out StringPathHash P2); // 0x00000001849B79A0-0x00000001849B8230
		public bool __Gen_Wrap_25(IntPtr P0, int P1); // 0x00000001849B8230-0x00000001849B8440
		public void __Gen_Wrap_26(object P0, bool P1); // 0x000000018253E590-0x000000018253E870
		public void __Gen_Wrap_27(object P0, object P1, int P2); // 0x0000000182528040-0x00000001825283D0
		public void __Gen_Wrap_28(object P0, float P1); // 0x0000000182659420-0x0000000182659700
		public string __Gen_Wrap_29(object P0, object P1); // 0x00000001849B8440-0x00000001849B8E40
		public long __Gen_Wrap_30(object P0, object P1, out int P2); // 0x00000001849B8E40-0x00000001849B9200
		public IntPtr __Gen_Wrap_31(object P0, object P1); // 0x00000001831240C0-0x0000000183124450
		public object[] __Gen_Wrap_32(object P0, object P1); // 0x00000001849B9200-0x00000001849B9C00
		public IntPtr __Gen_Wrap_33(object P0); // 0x00000001826107D0-0x0000000182610A90
		public FrameTickGroup __Gen_Wrap_34(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public bool __Gen_Wrap_35(LuaReference P0); // 0x00000001822262C0-0x0000000182226590
		public bool __Gen_Wrap_36(object P0, object P1, bool P2); // 0x00000001826B7CB0-0x00000001826B8050
		public int __Gen_Wrap_37(ref LuaTestReflectionOptStruct P0); // 0x00000001849B9C00-0x00000001849BA830
		public string __Gen_Wrap_38(ref LuaTestReflectionOptStruct P0); // 0x00000001849BA830-0x00000001849BB760
		public long __Gen_Wrap_39(ref LuaTestReflectionOptStruct P0); // 0x00000001849BB760-0x00000001849BC390
		public ulong __Gen_Wrap_40(ref LuaTestReflectionOptStruct P0); // 0x00000001849BC390-0x00000001849BCFC0
		public float __Gen_Wrap_41(ref LuaTestReflectionOptStruct P0); // 0x00000001849BCFC0-0x00000001849BDBF0
		public double __Gen_Wrap_42(ref LuaTestReflectionOptStruct P0); // 0x00000001849BDBF0-0x00000001849BE820
		public bool __Gen_Wrap_43(ref LuaTestReflectionOptStruct P0); // 0x00000001849BE820-0x00000001849BF450
		public int __Gen_Wrap_44(ref LuaTestReflectionOptStruct P0, int P1); // 0x00000001849BF450-0x00000001849C00B0
		public void __Gen_Wrap_45(ref LuaTestReflectionOptStruct P0); // 0x00000001849C00B0-0x00000001849C0CD0
		public void __Gen_Wrap_46(ref LuaTestReflectionOptStruct P0, LuaTestReflectionOptStruct P1); // 0x00000001849C0CD0-0x00000001849C1A10
		public void __Gen_Wrap_47(ref LuaTestReflectionOptStruct P0, ref LuaTestReflectionOptStruct P1); // 0x00000001849C1A10-0x00000001849C2800
		public object __Gen_Wrap_48(ref LuaTestReflectionOptStruct P0); // 0x00000001849C2800-0x00000001849C3730
		public void __Gen_Wrap_49(ref LuaTestReflectionOptStruct P0, object P1); // 0x00000001849C3730-0x00000001849C4450
		public int __Gen_Wrap_50(ref LuaTestReflectionOptStruct2 P0); // 0x00000001849C4450-0x00000001849C5080
		public string __Gen_Wrap_51(ref LuaTestReflectionOptStruct2 P0); // 0x00000001849C5080-0x00000001849C5FB0
		public long __Gen_Wrap_52(ref LuaTestReflectionOptStruct2 P0); // 0x00000001849C5FB0-0x00000001849C6BE0
		public ulong __Gen_Wrap_53(ref LuaTestReflectionOptStruct2 P0); // 0x00000001849C6BE0-0x00000001849C7810
		public float __Gen_Wrap_54(ref LuaTestReflectionOptStruct2 P0); // 0x00000001849C7810-0x00000001849C8440
		public double __Gen_Wrap_55(ref LuaTestReflectionOptStruct2 P0); // 0x00000001849C8440-0x00000001849C9070
		public bool __Gen_Wrap_56(ref LuaTestReflectionOptStruct2 P0); // 0x00000001849C9070-0x00000001849C9CA0
		public int __Gen_Wrap_57(ref LuaTestReflectionOptStruct2 P0, int P1); // 0x00000001849C9CA0-0x00000001849CA900
		public void __Gen_Wrap_58(ref LuaTestReflectionOptStruct2 P0); // 0x00000001849CA900-0x00000001849CB520
		public void __Gen_Wrap_59(ref LuaTestReflectionOptStruct2 P0, LuaTestReflectionOptStruct2 P1); // 0x00000001849CB520-0x00000001849CC260
		public void __Gen_Wrap_60(ref LuaTestReflectionOptStruct2 P0, ref LuaTestReflectionOptStruct2 P1); // 0x00000001849CC260-0x00000001849CD050
		public object __Gen_Wrap_61(ref LuaTestReflectionOptStruct2 P0); // 0x00000001849CD050-0x00000001849CDF80
		public void __Gen_Wrap_62(ref LuaTestReflectionOptStruct2 P0, object P1); // 0x00000001849CDF80-0x00000001849CECA0
		public int __Gen_Wrap_63(object P0, int P1); // 0x00000001824748D0-0x0000000182474BB0
		public void __Gen_Wrap_64(object P0, LuaTestReflectionOptStruct P1); // 0x00000001849CECA0-0x00000001849CF330
		public void __Gen_Wrap_65(object P0, LuaTestReflectionOptStruct2 P1); // 0x00000001849CF330-0x00000001849CF9C0
		public void __Gen_Wrap_66(object P0, ref LuaTestReflectionOptStruct P1); // 0x00000001849CF9C0-0x00000001849D06E0
		public void __Gen_Wrap_67(object P0, ETestEnum P1); // 0x00000001824828A0-0x0000000182482B70
		public ETestEnum __Gen_Wrap_68(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public LuaTestReflectionOptStruct __Gen_Wrap_69(object P0, LuaTestReflectionOptStruct P1); // 0x00000001849D06E0-0x00000001849D1360
		public GameObject __Gen_Wrap_70(object P0); // 0x00000001849D1360-0x00000001849D1C80
		public GameObject __Gen_Wrap_71(object P0, object P1); // 0x00000001849D1C80-0x00000001849D2680
		public void __Gen_Wrap_72(object P0, int P1, int P2); // 0x00000001824F9690-0x00000001824F9980
		public int __Gen_Wrap_73(int P0, object P1); // 0x00000001831A2F90-0x00000001831A3270
		public bool __Gen_Wrap_74(out RaycastHit P0, Ray P1, float P2, int P3, QueryTriggerInteraction P4); // 0x00000001849D2680-0x00000001849D3240
		public int __Gen_Wrap_75(Ray P0, object P1, float P2, int P3, QueryTriggerInteraction P4); // 0x00000001849D3240-0x00000001849D3930
		public Bounds __Gen_Wrap_76(object P0); // 0x00000001849D3930-0x00000001849D4220
		public UnityEngine.Rect __Gen_Wrap_77(object P0, object P1); // 0x00000001849D4220-0x00000001849D4BE0
		public Vector3 __Gen_Wrap_78(object P0); // 0x00000001849D4BE0-0x00000001849D54D0
		public Bounds __Gen_Wrap_79(object P0, object P1); // 0x00000001849D54D0-0x00000001849D5E90
		public Vector2 __Gen_Wrap_80(object P0, object P1, Vector2 P2); // 0x00000001849D5E90-0x00000001849D6BB0
		public List<string> __Gen_Wrap_81(); // 0x00000001849D6BB0-0x00000001849D73D0
		public int __Gen_Wrap_82(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public float __Gen_Wrap_83(object P0, object P1); // 0x0000000182E04540-0x0000000182E048D0
		public bool __Gen_Wrap_84(object P0, out HGCharacterVolume P1); // 0x00000001849D73D0-0x00000001849D7DE0
		public float __Gen_Wrap_85(object P0); // 0x00000001826A2110-0x00000001826A23D0
		public float __Gen_Wrap_86(); // 0x0000000182552560-0x0000000182552730
		public void __Gen_Wrap_87(float P0); // 0x0000000182541570-0x0000000182541760
		public Tweener __Gen_Wrap_88(float P0, float P1, float P2, object P3); // 0x00000001849D7DE0-0x00000001849D8770
		public UtilsForLua.ImageContentParam __Gen_Wrap_89(object P0); // 0x00000001849D8770-0x00000001849D9090
		public void __Gen_Wrap_90(int P0); // 0x0000000182220CF0-0x0000000182220EE0
		public bool __Gen_Wrap_91(int P0); // 0x0000000182220AF0-0x0000000182220CF0
		public void __Gen_Wrap_92(bool P0); // 0x0000000182521C80-0x0000000182521E70
		public CinemachineTransposer __Gen_Wrap_93(object P0); // 0x00000001849D9090-0x00000001849D99B0
		public CinemachineComposer __Gen_Wrap_94(object P0); // 0x00000001849D99B0-0x00000001849DA2D0
		public CinemachineCameraOffset __Gen_Wrap_95(object P0); // 0x00000001849DA2D0-0x00000001849DABF0
		public IEnumerator __Gen_Wrap_96(object P0); // 0x00000001849DABF0-0x00000001849DB510
		public IEnumerator __Gen_Wrap_97(object P0, float P1, float P2); // 0x00000001849DB510-0x00000001849DBEA0
		public void __Gen_Wrap_98(object P0, float P1, float P2, float P3); // 0x00000001832ACB60-0x00000001832ACE80
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 88982
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x00000001849DC060-0x00000001849DC870 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x00000001849DCA20-0x00000001849DD230 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018C2ECA44-0x000000018C2ECB24
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x00000001849DD230-0x00000001849DD3E0
		[IDTag(1)]
		private bool MoveNext(); // 0x00000001849DBEA0-0x00000001849DC060
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x00000001849DC870-0x00000001849DCA20
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 88983
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018C2F4574-0x000000018C2F45D8
		public static bool IsPatched(int id); // 0x000000018C2F4664-0x000000018C2F46E0
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018C2F442C-0x000000018C2F44F8
		public object CreateWrapper(int id); // 0x000000018C2F44F8-0x000000018C2F4574
		public object InitWrapperArray(int len); // 0x000000018C2F45D8-0x000000018C2F4664
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018C2F4388-0x000000018C2F442C
	}

	public delegate void __HotPatchDelegate_0(object P0, object P1); // TypeDefIndex: 88984; 0x00000001859B7730-0x00000001859B7740

	public enum HotPatchIDMAP0 // TypeDefIndex: 88985
	{
		Beyond-Lua-LuaEventSystem-PushEventName0 = 0,
		Beyond-Lua-LuaManager-AddOnceLuaEventAfterGCDo0 = 0,
		Beyond-Lua-LuaEventSystem-DispatchEvent0 = 0,
		Beyond-Lua-LuaCustomConfig-InitConfigTable0 = 0,
		Beyond-Lua-LuaReference-_BindSelfReferences0 = 0,
		Beyond-Lua-LuaReference-BindToLua0 = 0,
		Beyond-Lua-LuaTestReflectionOpt2-TestObjParam0 = 0,
		Beyond-Lua-LuaTestReflectionOpt-TestObjParam0 = 0,
		Beyond-Lua-LuaManager-IsLuaGCing0 = 1,
		Beyond-Lua-LuaManager-IsEnableMultithreadGC0 = 1,
		Beyond-Lua-LuaEventSystem-Dispose0 = 2,
		Beyond-Lua-CSharpCallLuaRegistration-Init0 = 2,
		Beyond-Lua-CSharpCallLuaRegistration-Dispose0 = 2,
		Beyond-Lua-LuaCustomConfig-OnBeforeSerialize0 = 2,
		Beyond-Lua-LuaCustomConfig-OnAfterDeserialize0 = 2,
		Beyond-Lua-LuaCustomConfig-Item-MarkLuaValueProcessed0 = 2,
		Beyond-Lua-LuaManager-_OnRenderDone0 = 2,
		Beyond-Lua-LuaManager-_Register3rdPartyLibraries0 = 2,
		Beyond-Lua-LuaManager-_RegisterCSharpCallLua0 = 2,
		Beyond-Lua-LuaManager-OnInit0 = 2,
		Beyond-Lua-LuaManager-_ReleaseDelegateInAnotherStackFrame1 = 2,
		Beyond-Lua-LuaManager-OnRelease0 = 2,
		Beyond-Lua-LuaManager-ClearAllUnityObjectUserdata0 = 2,
		Beyond-Lua-LuaManager-RemoveLuaEventAfterGCDo0 = 2,
		Beyond-Lua-LuaReference-Reset0 = 2,
		Beyond-Lua-LuaReference-_UnBindFromXluaRef0 = 2,
		Beyond-Lua-LuaReference-OnDestroy0 = 2,
		Beyond-Lua-LuaTestReflectionOpt2-TestVoid0 = 2,
		Beyond-Lua-LuaTestReflectionOpt-TestVoid0 = 2,
		Beyond-Lua-LuaUIWidget-Reset0 = 2,
		Beyond-Lua-LuaUIWidget-OnEnable0 = 2,
		Beyond-Lua-LuaUIWidget-OnDisable0 = 2,
		Beyond-Lua-LuaUIWidget-ClearComponent0 = 2,
		Beyond-Lua-LuaUIWidget-OnDestroy0 = 2,
		Beyond-Lua-UtilsForLua-ClearUIComponents0 = 2,
		Beyond-Lua-LuaCustomConfig-get_itemDict0 = 3,
		Beyond-Lua-LuaCustomConfig-ConvertLuaTableToJson0 = 4,
		Beyond-Lua-LuaCustomConfig-ConvertLuaCodeToJson0 = 4,
		Beyond-Lua-LuaCustomConfig-_ConvertJValueToObjectForValidation0 = 5,
		Beyond-Lua-LuaCustomConfig-_ConvertJValueToObject0 = 5,
		Beyond-Lua-LuaCustomConfig-_PopulateLuaTableFromJTokenForValidation0 = 6,
		Beyond-Lua-LuaCustomConfig-_JsonToLuaTableForValidation0 = 7,
		Beyond-Lua-LuaCustomConfig-_JsonToLuaTable0 = 7,
		Beyond-Lua-LuaCustomConfig-_IsNumericType0 = 8,
		Beyond-Lua-LuaCustomConfig-_ProcessLuaTableItem0 = 8,
		Beyond-Lua-LuaCustomConfig-ShouldProcessEnumItem0 = 8,
		Beyond-Lua-LuaCustomConfig-_ProcessEnumItem0 = 8,
		Beyond-Lua-LuaManager-IsLuaFileExist0 = 8,
		Beyond-Lua-LuaManager-AddLuaEventAfterGCDo0 = 8,
		Beyond-Lua-LuaReference-_RefreshSelfCustomUIStyleBindings0 = 8,
		Beyond-Lua-UtilsForLua-StartPayment0 = 8,
		Beyond-Lua-LuaCustomConfig-_CompareValues0 = 9,
		Beyond-Lua-LuaCustomConfig-_CompareLuaTables0 = 9,
		Beyond-Lua-LuaCustomConfig-_ValidateLuaTableConsistency0 = 9,
		Beyond-Lua-LuaCustomConfig-_PopulateLuaTableFromJToken0 = 10,
		Beyond-Lua-LuaCustomConfig-Item-GetEnumType0 = 11,
		Beyond-Lua-LuaCustomConfig-Item-GetEnumValueObject0 = 12,
		Beyond-Lua-LuaTestReflectionOpt2-TestReturnObj0 = 12,
		Beyond-Lua-LuaTestReflectionOpt-TestReturnObj0 = 12,
		Beyond-Lua-LuaCustomConfig-Item-HasLuaValueChanged0 = 13,
		Beyond-Lua-LuaCustomConfig-Item-ShouldSerializeLuaTableJson0 = 13,
		Beyond-Lua-LuaHotFix-HotFixLua1 = 13,
		Beyond-Lua-LuaHotFix-HotFixLua2 = 13,
		Beyond-Lua-LuaManager-get_isQuittingApplication0 = 13,
		Beyond-Lua-LuaReference-RefreshCustomUIStyleBindings0 = 13,
		Beyond-Lua-UtilsForLua-IsNull0 = 13,
		Beyond-Lua-LuaHotFix-LuaHotFixTest0 = 14,
		Beyond-Lua-LoadLuaProxy-_RunOnStart0 = 14,
		Beyond-Lua-LuaMethodPointerModule-_RunOnStart0 = 14,
		Beyond-Lua-LuaManager-CreateInstance0 = 14,
		Beyond-Lua-LuaManager-DestroyInstance0 = 14,
		Beyond-Lua-LuaManager-ReStartLuaProfiler0 = 14,
		Beyond-Lua-UtilsForLua-OpenAccountCenter0 = 14,
		Beyond-Lua-UtilsForLua-ExitGame0 = 14,
		Beyond-Lua-UtilsForLua-ReturnToLogin0 = 14,
		Beyond-Lua-LuaHotFix-HotFixLua0 = 15,
		Beyond-Lua-LoadLuaProxy-LoadLua0 = 16,
		Beyond-Lua-LuaManager-LoadLua0 = 16,
		Beyond-Lua-LuaManager-_OnRenderDone1 = 17,
		Beyond-Lua-LuaManager-GetLuaStack0 = 18,
		Beyond-Lua-UtilsForLua-GetCurrentUID0 = 18,
		Beyond-Lua-LuaManager-_HyperLuaLogCallback0 = 19,
		Beyond-Lua-LuaManager-_LuaUtilsLogCallback0 = 20,
		Beyond-Lua-LuaManager-LoadLuaBytes0 = 21,
		Beyond-Lua-LuaManager-_OnEnvLangChanged0 = 22,
		Beyond-Lua-LuaManager-LuaCalculateABPathHash0 = 23,
		Beyond-Lua-LuaManager-CasterStringPathHash0 = 24,
		Beyond-Lua-LuaManager-CheckStringPathHash0 = 25,
		Beyond-Lua-LuaManager-_DumpResidualDelegateBridges0 = 26,
		Beyond-Lua-LuaManager-set_isQuittingApplication0 = 26,
		Beyond-Lua-LuaManager-_ReleaseDelegateInAnotherStackFrame0 = 27,
		Beyond-Lua-LuaManager-Tick0 = 28,
		Beyond-Lua-LuaManager-LateTick0 = 28,
		Beyond-Lua-LuaManager-TailLateTick0 = 28,
		Beyond-Lua-UtilsForLua-SetPosX0 = 28,
		Beyond-Lua-UtilsForLua-SetPosY0 = 28,
		Beyond-Lua-UtilsForLua-SetPosZ0 = 28,
		Beyond-Lua-UtilsForLua-SetRotX0 = 28,
		Beyond-Lua-UtilsForLua-SetRotY0 = 28,
		Beyond-Lua-UtilsForLua-SetRotZ0 = 28,
		Beyond-Lua-UtilsForLua-SetScaleX0 = 28,
		Beyond-Lua-UtilsForLua-SetScaleY0 = 28,
		Beyond-Lua-UtilsForLua-SetScaleZ0 = 28,
		Beyond-Lua-LuaManager-GetLuaFileRealPath0 = 29,
		Beyond-Lua-LuaManager-LoadLuaByteByFileRealPath0 = 30,
		Beyond-Lua-LuaManager-LoadLuaBytePtr0 = 31,
		Beyond-Lua-LuaManager-DoString0 = 32,
		Beyond-Lua-LuaManager-GetLuaState0 = 33,
		Beyond-Lua-LuaManager-get_frameTickGroup0 = 34,
		Beyond-Lua-LuaReference-ContainsGameObject0 = 35,
		Beyond-Lua-LuaTestReflectionOptStruct-get_a10 = 36,
		Beyond-Lua-LuaTestReflectionOptStruct-get_b10 = 37,
		Beyond-Lua-LuaTestReflectionOptStruct-get_l10 = 38,
		Beyond-Lua-LuaTestReflectionOptStruct-get_ul10 = 39,
		Beyond-Lua-LuaTestReflectionOptStruct-get_f10 = 40,
		Beyond-Lua-LuaTestReflectionOptStruct-get_d10 = 41,
		Beyond-Lua-LuaTestReflectionOptStruct-get_bl10 = 42,
		Beyond-Lua-LuaTestReflectionOptStruct-TestInt0 = 43,
		Beyond-Lua-LuaTestReflectionOptStruct-TestVoid0 = 44,
		Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam0 = 45,
		Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam20 = 46,
		Beyond-Lua-LuaTestReflectionOptStruct-TestReturnObj0 = 47,
		Beyond-Lua-LuaTestReflectionOptStruct-TestObjParam0 = 48,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_a10 = 49,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_b10 = 50,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_l10 = 51,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_ul10 = 52,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_f10 = 53,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_d10 = 54,
		Beyond-Lua-LuaTestReflectionOptStruct2-get_bl10 = 55,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestInt0 = 56,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestVoid0 = 57,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam0 = 58,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam20 = 59,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestReturnObj0 = 60,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestObjParam0 = 61,
		Beyond-Lua-LuaTestReflectionOpt2-TestInt0 = 62,
		Beyond-Lua-LuaTestReflectionOpt-TestInt0 = 62,
		Beyond-Lua-LuaTestReflectionOpt2-TestStructParam0 = 63,
		Beyond-Lua-LuaTestReflectionOpt-TestStructParam0 = 63,
		Beyond-Lua-LuaTestReflectionOpt2-TestStructParam1 = 64,
		Beyond-Lua-LuaTestReflectionOpt-TestStructParam1 = 64,
		Beyond-Lua-LuaTestReflectionOpt2-TestStructParam20 = 65,
		Beyond-Lua-LuaTestReflectionOpt-TestStructParam20 = 65,
		Beyond-Lua-LuaTestReflectionOpt2-TestEnum0 = 66,
		Beyond-Lua-LuaTestReflectionOpt-TestEnum0 = 66,
		Beyond-Lua-LuaTestReflectionOpt2-TestReturnEnum0 = 67,
		Beyond-Lua-LuaTestReflectionOpt-TestReturnEnum0 = 67,
		Beyond-Lua-LuaTestReflectionOpt2-TestStruct0 = 68,
		Beyond-Lua-LuaTestReflectionOpt-TestStruct0 = 68,
		Beyond-Lua-UtilsForLua-CreateObject0 = 69,
		Beyond-Lua-UtilsForLua-CreateObject1 = 70,
		Beyond-Lua-UtilsForLua-CreateObject2 = 70,
		Beyond-Lua-UtilsForLua-UIContainerResize0 = 71,
		Beyond-Lua-UtilsForLua-TurnOffLayer0 = 72,
		Beyond-Lua-UtilsForLua-TurnOnLayer0 = 72,
		Beyond-Lua-UtilsForLua-ToggleLayer0 = 72,
		Beyond-Lua-UtilsForLua-RayCast0 = 73,
		Beyond-Lua-UtilsForLua-RaycastNonAlloc0 = 74,
		Beyond-Lua-UtilsForLua-GetRectTransformBounds0 = 75,
		Beyond-Lua-UtilsForLua-RectTransformToScreenRect0 = 76,
		Beyond-Lua-UtilsForLua-GetRectTransformCenterPosition0 = 77,
		Beyond-Lua-UtilsForLua-CalcBoundOfRectTransform0 = 78,
		Beyond-Lua-UtilsForLua-ClampPointInRectTransform0 = 79,
		Beyond-Lua-UtilsForLua-GetStringList0 = 80,
		Beyond-Lua-UtilsForLua-GetStringHash0 = 81,
		Beyond-Lua-UtilsForLua-EntityDistance0 = 82,
		Beyond-Lua-UtilsForLua-TryGetCharacterVolume0 = 83,
		Beyond-Lua-UtilsForLua-GetAnimationCurveLength0 = 84,
		Beyond-Lua-UtilsForLua-TweenTo0 = 85,
		Beyond-Lua-UtilsForLua-ParseImageContent0 = 86,
		Beyond-Lua-UtilsForLua-QuitGame0 = 87,
		Beyond-Lua-UtilsForLua-CheckExtremeDangerousByLevel0 = 88,
		Beyond-Lua-UtilsForLua-ToggleCharInfoInUpgradePanelOption0 = 89,
		Beyond-Lua-UtilsForLua-ToggleWeaponInUpgradePanelOption0 = 89,
		Beyond-Lua-UtilsForLua-GetCinemachineTransposer0 = 90,
		Beyond-Lua-UtilsForLua-GetCinemachineComposer0 = 91,
		Beyond-Lua-UtilsForLua-GetOrAddCinemachineCameraOffset0 = 92,
		Beyond-Lua-UtilsForLua-_RunForceGC0 = 93,
		Beyond-Lua-UtilsForLua-_ForceGCWithBlackScreen0 = 94,
		Beyond-Lua-UtilsForLua-ForceGCWithBlackScreen0 = 95
	}

	public delegate bool __HotPatchDelegate_1(); // TypeDefIndex: 88986; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_2(object P0); // TypeDefIndex: 88987; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Dictionary<string, LuaCustomConfig.Item> __HotPatchDelegate_3(object P0); // TypeDefIndex: 88988; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_4(object P0); // TypeDefIndex: 88989; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate object __HotPatchDelegate_5(object P0, object P1); // TypeDefIndex: 88990; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_6(object P0, object P1, object P2, object P3); // TypeDefIndex: 88991; 0x00000001811CDB70-0x00000001811CDB90

	public delegate LuaTable __HotPatchDelegate_7(object P0, object P1, object P2); // TypeDefIndex: 88992; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_8(object P0, object P1); // TypeDefIndex: 88993; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_9(object P0, object P1, object P2); // TypeDefIndex: 88994; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_10(object P0, object P1, object P2); // TypeDefIndex: 88995; 0x00000001811DF7F0-0x00000001811DF810

	public delegate System.Type __HotPatchDelegate_11(object P0); // TypeDefIndex: 88996; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate object __HotPatchDelegate_12(object P0); // TypeDefIndex: 88997; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_13(object P0); // TypeDefIndex: 88998; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_14(); // TypeDefIndex: 88999; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_15(Span<byte> P0, int P1); // TypeDefIndex: 89000; 0x00000001826DF750-0x00000001826DF780

	public delegate byte[] __HotPatchDelegate_16(object P0, object P1); // TypeDefIndex: 89001; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_17(object P0, HGRenderPipeCallbackArgs P1); // TypeDefIndex: 89002; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_18(); // TypeDefIndex: 89003; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_19(IntPtr P0, int P1, object P2); // TypeDefIndex: 89004; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_20(int P0, object P1); // TypeDefIndex: 89005; 0x00000001859B7730-0x00000001859B7740

	public delegate byte[] __HotPatchDelegate_21(object P0, ref string P1); // TypeDefIndex: 89006; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_22(object P0, EnvLang P1); // TypeDefIndex: 89007; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_23(IntPtr P0); // TypeDefIndex: 89008; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_24(IntPtr P0, int P1, out StringPathHash P2); // TypeDefIndex: 89009; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_25(IntPtr P0, int P1); // TypeDefIndex: 89010; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_26(object P0, bool P1); // TypeDefIndex: 89011; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_27(object P0, object P1, int P2); // TypeDefIndex: 89012; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_28(object P0, float P1); // TypeDefIndex: 89013; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_29(object P0, object P1); // TypeDefIndex: 89014; 0x00000001859B7730-0x00000001859B7740

	public delegate long __HotPatchDelegate_30(object P0, object P1, out int P2); // TypeDefIndex: 89015; 0x00000001811DF7F0-0x00000001811DF810

	public delegate IntPtr __HotPatchDelegate_31(object P0, object P1); // TypeDefIndex: 89016; 0x00000001859B7730-0x00000001859B7740

	public delegate object[] __HotPatchDelegate_32(object P0, object P1); // TypeDefIndex: 89017; 0x00000001859B7730-0x00000001859B7740

	public delegate IntPtr __HotPatchDelegate_33(object P0); // TypeDefIndex: 89018; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate FrameTickGroup __HotPatchDelegate_34(object P0); // TypeDefIndex: 89019; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_35(object P0, object P1, bool P2); // TypeDefIndex: 89020; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_36(ref LuaTestReflectionOptStruct P0); // TypeDefIndex: 89021; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_37(ref LuaTestReflectionOptStruct P0); // TypeDefIndex: 89022; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate long __HotPatchDelegate_38(ref LuaTestReflectionOptStruct P0); // TypeDefIndex: 89023; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate ulong __HotPatchDelegate_39(ref LuaTestReflectionOptStruct P0); // TypeDefIndex: 89024; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_40(ref LuaTestReflectionOptStruct P0); // TypeDefIndex: 89025; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate double __HotPatchDelegate_41(ref LuaTestReflectionOptStruct P0); // TypeDefIndex: 89026; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_42(ref LuaTestReflectionOptStruct P0); // TypeDefIndex: 89027; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_43(ref LuaTestReflectionOptStruct P0, int P1); // TypeDefIndex: 89028; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_44(ref LuaTestReflectionOptStruct P0); // TypeDefIndex: 89029; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_45(ref LuaTestReflectionOptStruct P0, LuaTestReflectionOptStruct P1); // TypeDefIndex: 89030; 0x00000001826EA580-0x00000001826EA5D0

	public delegate void __HotPatchDelegate_46(ref LuaTestReflectionOptStruct P0, ref LuaTestReflectionOptStruct P1); // TypeDefIndex: 89031; 0x00000001859B7730-0x00000001859B7740

	public delegate object __HotPatchDelegate_47(ref LuaTestReflectionOptStruct P0); // TypeDefIndex: 89032; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_48(ref LuaTestReflectionOptStruct P0, object P1); // TypeDefIndex: 89033; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_49(ref LuaTestReflectionOptStruct2 P0); // TypeDefIndex: 89034; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_50(ref LuaTestReflectionOptStruct2 P0); // TypeDefIndex: 89035; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate long __HotPatchDelegate_51(ref LuaTestReflectionOptStruct2 P0); // TypeDefIndex: 89036; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate ulong __HotPatchDelegate_52(ref LuaTestReflectionOptStruct2 P0); // TypeDefIndex: 89037; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_53(ref LuaTestReflectionOptStruct2 P0); // TypeDefIndex: 89038; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate double __HotPatchDelegate_54(ref LuaTestReflectionOptStruct2 P0); // TypeDefIndex: 89039; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_55(ref LuaTestReflectionOptStruct2 P0); // TypeDefIndex: 89040; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_56(ref LuaTestReflectionOptStruct2 P0, int P1); // TypeDefIndex: 89041; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_57(ref LuaTestReflectionOptStruct2 P0); // TypeDefIndex: 89042; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_58(ref LuaTestReflectionOptStruct2 P0, LuaTestReflectionOptStruct2 P1); // TypeDefIndex: 89043; 0x00000001826EA580-0x00000001826EA5D0

	public delegate void __HotPatchDelegate_59(ref LuaTestReflectionOptStruct2 P0, ref LuaTestReflectionOptStruct2 P1); // TypeDefIndex: 89044; 0x00000001859B7730-0x00000001859B7740

	public delegate object __HotPatchDelegate_60(ref LuaTestReflectionOptStruct2 P0); // TypeDefIndex: 89045; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_61(ref LuaTestReflectionOptStruct2 P0, object P1); // TypeDefIndex: 89046; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_62(object P0, int P1); // TypeDefIndex: 89047; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_63(object P0, LuaTestReflectionOptStruct P1); // TypeDefIndex: 89048; 0x00000001826EA580-0x00000001826EA5D0

	public delegate void __HotPatchDelegate_64(object P0, LuaTestReflectionOptStruct2 P1); // TypeDefIndex: 89049; 0x00000001826EA580-0x00000001826EA5D0

	public delegate void __HotPatchDelegate_65(object P0, ref LuaTestReflectionOptStruct P1); // TypeDefIndex: 89050; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_66(object P0, ETestEnum P1); // TypeDefIndex: 89051; 0x00000001859B7730-0x00000001859B7740

	public delegate ETestEnum __HotPatchDelegate_67(object P0); // TypeDefIndex: 89052; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate LuaTestReflectionOptStruct __HotPatchDelegate_68(object P0, LuaTestReflectionOptStruct P1); // TypeDefIndex: 89053; 0x00000001849DFF50-0x00000001849DFFD0

	public delegate GameObject __HotPatchDelegate_69(object P0); // TypeDefIndex: 89054; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate GameObject __HotPatchDelegate_70(object P0, object P1); // TypeDefIndex: 89055; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_71(object P0, int P1, int P2); // TypeDefIndex: 89056; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_72(int P0, object P1); // TypeDefIndex: 89057; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_73(out RaycastHit P0, Ray P1, float P2, int P3, QueryTriggerInteraction P4); // TypeDefIndex: 89058; 0x00000001849DFFD0-0x00000001849E0020

	public delegate int __HotPatchDelegate_74(Ray P0, object P1, float P2, int P3, QueryTriggerInteraction P4); // TypeDefIndex: 89059; 0x0000000184160490-0x00000001841604E0

	public delegate Bounds __HotPatchDelegate_75(object P0); // TypeDefIndex: 89060; 0x00000001811D4E00-0x00000001811D4E40

	public delegate UnityEngine.Rect __HotPatchDelegate_76(object P0, object P1); // TypeDefIndex: 89061; 0x00000001812C43A0-0x00000001812C43E0

	public delegate Vector3 __HotPatchDelegate_77(object P0); // TypeDefIndex: 89062; 0x0000000185D32980-0x0000000185D329C0

	public delegate Bounds __HotPatchDelegate_78(object P0, object P1); // TypeDefIndex: 89063; 0x0000000181247850-0x0000000181247890

	public delegate Vector2 __HotPatchDelegate_79(object P0, object P1, Vector2 P2); // TypeDefIndex: 89064; 0x00000001811DF7F0-0x00000001811DF810

	public delegate List<string> __HotPatchDelegate_80(); // TypeDefIndex: 89065; 0x0000000185B44B70-0x0000000185B44B80

	public delegate int __HotPatchDelegate_81(object P0); // TypeDefIndex: 89066; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_82(object P0, object P1); // TypeDefIndex: 89067; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_83(object P0, out HGCharacterVolume P1); // TypeDefIndex: 89068; 0x00000001859B7730-0x00000001859B7740

	public delegate float __HotPatchDelegate_84(object P0); // TypeDefIndex: 89069; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Tweener __HotPatchDelegate_85(float P0, float P1, float P2, object P3); // TypeDefIndex: 89070; 0x00000001812750F0-0x0000000181275110

	public delegate UtilsForLua.ImageContentParam __HotPatchDelegate_86(object P0); // TypeDefIndex: 89071; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_87(int P0); // TypeDefIndex: 89072; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_88(int P0); // TypeDefIndex: 89073; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_89(bool P0); // TypeDefIndex: 89074; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate CinemachineTransposer __HotPatchDelegate_90(object P0); // TypeDefIndex: 89075; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate CinemachineComposer __HotPatchDelegate_91(object P0); // TypeDefIndex: 89076; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate CinemachineCameraOffset __HotPatchDelegate_92(object P0); // TypeDefIndex: 89077; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_93(object P0); // TypeDefIndex: 89078; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_94(object P0, float P1, float P2); // TypeDefIndex: 89079; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_95(object P0, float P1, float P2, float P3); // TypeDefIndex: 89080; 0x00000001812250A0-0x00000001812250C0
}
