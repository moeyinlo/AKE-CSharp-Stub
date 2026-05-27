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

// Image 70: Lua.Beyond.dll - Assembly: Lua.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58633-58679
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Lua
{
	public abstract class CsToLuaClass // TypeDefIndex: 58640
	{
		// Fields
		protected LuaTable m_luaTable; // 0x10
	
		// Constructors
		protected CsToLuaClass() {} // Dummy constructor
		public CsToLuaClass(string luaPath) {} // 0x0000000188935D44-0x0000000188935E1C
	}

	public class LuaEventSystem : ILuaEventSystem, IDisposable // TypeDefIndex: 58648
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
		public delegate void DispatchEventFunc(string eventName, LuaTable luaTable); // TypeDefIndex: 58641; 0x0000000182065C10-0x0000000182065C20
	
		// Constructors
		public LuaEventSystem() {} // 0x000000018332F850-0x000000018332FA60
	
		// Methods
		public void DispatchEvent(string eventName) {} // 0x0000000183488720-0x00000001834888A0
		public void DispatchEvent<T>(string eventName, T arg) {}
		public void DispatchEvent<T0, T1>(string eventName, T0 arg0, T1 arg1) {}
		public void DispatchEvent<T0, T1, T2>(string eventName, T0 arg0, T1 arg1, T2 arg2) {}
		public void DispatchEvent<T0, T1, T2, T3>(string eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3) {}
		public void DispatchEvent<T0, T1, T2, T3, T4>(string eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {}
		public void PushEventName(string eventName) {} // 0x00000001825D44B0-0x00000001825D4610
		public void Dispose() {} // 0x000000018893C40C-0x000000018893C4A8
	}

	public class CSharpCallLuaRegistration // TypeDefIndex: 58649
	{
		// Fields
		private LuaEventSystem m_luaEventSystem; // 0x10
	
		// Constructors
		public CSharpCallLuaRegistration() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Init() {} // 0x000000018332FA60-0x000000018332FB50
		public void Dispose() {} // 0x0000000188935CA4-0x0000000188935D44
	}

	public class LuaCustomConfig : MonoBehaviour, ILuaCallCSharp, ISerializationCallbackReceiver // TypeDefIndex: 58654
	{
		// Fields
		[SerializeField]
		public List<Item> itemList; // 0x18
		private Dictionary<string, Item> m_itemDict; // 0x20
	
		// Properties
		public Dictionary<string, Item> itemDict { get => default; } // 0x000000018893C228-0x000000018893C40C 
	
		// Nested types
		public enum ValueType // TypeDefIndex: 58650
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
		public class Item : ILuaCallCSharp // TypeDefIndex: 58651
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
			public Item() {} // 0x00000001830BFFE0-0x00000001830C00C0
	
			// Methods
			public bool HasLuaValueChanged() => default; // 0x0000000188939CA8-0x0000000188939D04
			public bool ShouldSerializeLuaTableJson() => default; // 0x0000000188939D60-0x0000000188939DD0
			public void MarkLuaValueProcessed() {} // 0x0000000188939D04-0x0000000188939D60
			public System.Type GetEnumType() => default; // 0x0000000188939908-0x0000000188939AF4
			public object GetEnumValueObject() => default; // 0x0000000188939AF4-0x0000000188939CA8
		}
	
		// Constructors
		public LuaCustomConfig() {} // 0x0000000183367F70-0x0000000183368000
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018356B820-0x000000018356B850
		public void OnAfterDeserialize() {} // 0x00000001834BB050-0x00000001834BB080
		private bool _ProcessLuaTableItem(Item item) => default; // 0x000000018893BCBC-0x000000018893BF38
		public bool ShouldProcessEnumItem(Item item) => default; // 0x000000018893A218-0x000000018893A2B8
		private bool _ProcessEnumItem(Item item) => default; // 0x000000018893BAE8-0x000000018893BCBC
		private bool _ValidateLuaTableConsistency(string luaCode, string json) => default; // 0x000000018893BF38-0x000000018893C228
		private LuaTable _JsonToLuaTableForValidation(string json, LuaEnv luaEnv) => default; // 0x000000018893ACF0-0x000000018893AE3C
		private void _PopulateLuaTableFromJTokenForValidation(LuaTable luaTable, JToken jToken, LuaEnv luaEnv) {} // 0x000000018893AFE4-0x000000018893B47C
		private object _ConvertJValueToObjectForValidation(JToken jValue) => default; // 0x000000018893A86C-0x000000018893A9E4
		private bool _CompareLuaTables(LuaTable table1, LuaTable table2) => default; // 0x000000018893A2B8-0x000000018893A724
		private bool _CompareValues(object value1, object value2) => default; // 0x000000018893A724-0x000000018893A86C
		private bool _IsNumericType(object obj) => default; // 0x000000018893AB64-0x000000018893ACF0
		public void InitConfigTable(LuaTable configTable) {} // 0x00000001831307E0-0x0000000183132A80
		private LuaTable _JsonToLuaTable(string json, LuaEnv luaEnv) => default; // 0x000000018893AE3C-0x000000018893AFE4
		private void _PopulateLuaTableFromJToken(LuaTable luaTable, JToken jToken) {} // 0x000000018893B47C-0x000000018893BAE8
		private object _ConvertJValueToObject(JToken jValue) => default; // 0x000000018893A9E4-0x000000018893AB64
		public static string ConvertLuaCodeToJson(string luaCode) => default; // 0x0000000188939DD0-0x000000018893A09C
		public static string ConvertLuaTableToJson(LuaTable luaTable) => default; // 0x000000018893A09C-0x000000018893A218
	}

	public class LuaDebugSocketManager : MonoBehaviour // TypeDefIndex: 58655
	{
		// Constructors
		public LuaDebugSocketManager() {} // 0x0000000183C910C0-0x0000000183C915F0
	}

	public static class LuaHotFix // TypeDefIndex: 58657
	{
		// Nested types
		[CSharpCallLua]
		public delegate bool LuaHotFixInvoker(string luaCode); // TypeDefIndex: 58656; 0x000000018102B410-0x000000018102B420
	
		// Methods
		public static void LuaHotFixTest() {} // 0x000000018893C97C-0x000000018893C9BC
		[IDTag(1)]
		public static bool HotFixLua(string lua) => default; // 0x000000018893C884-0x000000018893C97C
		[IDTag(2)]
		public static bool HotFixLua(byte[] lua) => default; // 0x000000018893C4A8-0x000000018893C540
		[IDTag(0)]
		public static bool HotFixLua(Span<byte> lua, int length) => default; // 0x000000018893C540-0x000000018893C884
	}

	public class LoadLuaProxy : ILoadLuaProxy // TypeDefIndex: 58658
	{
		// Constructors
		public LoadLuaProxy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void _RunOnStart() {} // 0x0000000183CB42A0-0x0000000183CB4350
		public byte[] LoadLua(string name) => default; // 0x0000000182D3C020-0x0000000182D3C090
	}

	public class LuaMethodPointerModule // TypeDefIndex: 58659
	{
		// Constructors
		public LuaMethodPointerModule() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void _RunOnStart() {} // 0x0000000183B2E3F0-0x0000000183B2E530
	}

	public class LuaManager : BaseTickManager, ILuaProxy // TypeDefIndex: 58661
	{
		// Fields
		private const float TICK_INTERVAL = 1f; // Metadata: 0x01FDB747
		private readonly CSharpCallLuaRegistration m_csCallLua; // 0x70
		private PeriodicTimer m_envTickTimer; // 0x78
		public static bool s_xluaReflectionOpt; // 0x08
		public Action<LuaTable, string, LuaUIWidget> wrapUIWidgetFunction; // 0x88
		public Action<LuaTable, string, LuaReference> bindLuaRefFunction; // 0x90
		private bool m_isQuittingApplication; // 0x98
		public TickEvent actionTick; // 0xA0
		public TickEvent actionLateTick; // 0xA8
		public TickEvent actionTailTick; // 0xB0
		public TickEvent actionRenderDone; // 0xB8
	
		// Properties
		public static LuaManager instance { get; private set; } // 0x0000000183D2E220-0x0000000183D2E270 0x000000018893D4B4-0x000000018893D510
		public LuaEnv luaEnv { get; private set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
		public bool isQuittingApplication { get => default; set {} } // 0x0000000183D58690-0x0000000183D586A0 0x000000018893D510-0x000000018893D598
		public override FrameTickGroup frameTickGroup { get => default; } // 0x0000000183D51110-0x0000000183D51120 
	
		// Nested types
		public class TickEvent : DisposedUnityEvent<float> // TypeDefIndex: 58660
		{
			// Constructors
			public TickEvent() {} // 0x000000018323A1B0-0x000000018323A1F0
		}
	
		// Constructors
		public LuaManager() {} // 0x000000018323A020-0x000000018323A1B0
		static LuaManager() {} // 0x0000000183D44320-0x0000000183D44360
	
		// Methods
		public static void CreateInstance() {} // 0x0000000183103810-0x00000001831038F0
		public static void DestroyInstance() {} // 0x0000000183103590-0x0000000183103640
		public static bool IsEnableMultithreadGC() => default; // 0x00000001829A6AC0-0x00000001829A6BF0
		public static bool IsLuaGCing() => default; // 0x00000001825D4CC0-0x00000001825D4E00
		protected override void OnInit() {} // 0x000000018332FF70-0x0000000183334160
		public static string GetLuaStack() => default; // 0x000000018893CB5C-0x000000018893CD20
		protected override void OnRelease() {} // 0x0000000183B2E660-0x0000000183B2E780
		public static void ReStartLuaProfiler() {} // 0x000000018893CF14-0x000000018893CF54
		private void _ReleaseDelegateInAnotherStackFrame() {} // 0x000000018893D2F0-0x000000018893D4B4
		public override void Tick(float deltaTime) {} // 0x0000000182BE1ED0-0x0000000182BE3470
		public override void LateTick(float deltaTime) {} // 0x0000000182BE3470-0x0000000182BE3640
		public override void TailLateTick(float deltaTime) {} // 0x0000000182BE3640-0x0000000182BE3810
		public string GetLuaFileRealPath(string modulePath) => default; // 0x000000018893CAD8-0x000000018893CB5C
		public bool IsLuaFileExist(string modulePath) => default; // 0x0000000182BE1BD0-0x0000000182BE1C40
		public long LoadLuaByteByFileRealPath(string modulePath, out int len) {
			len = default;
			return default;
		} // 0x000000018893CD20-0x000000018893CDE8
		public byte[] LoadLua(string modulePath) => default; // 0x0000000182BE1420-0x0000000182BE14A0
		public IntPtr LoadLuaBytePtr(string modulePath) => default; // 0x000000018893CDE8-0x000000018893CF14
		public byte[] LoadLuaBytes(ref string modulePath) => default; // 0x00000001839C53F0-0x00000001839C5470
		private void _RegisterCSharpCallLua() {} // 0x000000018332FD40-0x000000018332FD80
		private static void _Register3rdPartyLibraries(LuaEnv env) {} // 0x0000000182D3CA10-0x0000000182D3CC90
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static void _HyperLuaLogCallback(IntPtr L, int level, string text) {} // 0x000000018893D018-0x000000018893D104
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static void _LuaUtilsLogCallback(int level, string text) {} // 0x000000018893D104-0x000000018893D194
		private void _OnEnvLangChanged(EnvLang lang) {} // 0x000000018893D194-0x000000018893D268
		public object[] DoString(string code) => default; // 0x000000018893CA40-0x000000018893CAD8
		public IntPtr GetLuaState() => default; // 0x00000001832CFAF0-0x00000001832CFB30
		public void ClearAllUnityObjectUserdata() {} // 0x00000001830CDB70-0x00000001830CDBD0
		[IDTag(1)]
		private void _OnRenderDone(HGRenderPipeCallbackArgs args) {} // 0x000000018893D268-0x000000018893D2F0
		[IDTag(0)]
		private void _OnRenderDone() {} // 0x0000000182BE3990-0x0000000182BE3A40
		public bool AddLuaEventAfterGCDo(UnityAction action) => default; // 0x000000018332FEA0-0x000000018332FEF0
		public static void RemoveLuaEventAfterGCDo(UnityAction action) {} // 0x000000018893CF54-0x000000018893D018
		public void AddOnceLuaEventAfterGCDo(UnityAction action) {} // 0x000000018893C9BC-0x000000018893CA40
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LuaCalculateABPathHash(IntPtr L) => default; // 0x0000000183058750-0x0000000183058830
		public static void CasterStringPathHash(IntPtr L, int index, out StringPathHash o) {
			o = default;
		} // 0x00000001824D6F00-0x00000001824D6FF0
		public static bool CheckStringPathHash(IntPtr L, int index) => default; // 0x00000001824D8180-0x00000001824D8200
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018589C8E8-0x000000018589C8F0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589C8C0-0x000000018589C8C8
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x000000018589C8E0-0x000000018589C8E8
	}

	[ExecuteInEditMode]
	public class LuaReference : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 58666
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
	
		// Nested types
		[Serializable]
		public class ComponentRefDict : SerializeReferenceDictionary<string, Component> // TypeDefIndex: 58662
		{
			// Constructors
			public ComponentRefDict() {} // 0x0000000182815B80-0x0000000182815BE0
		}
	
		[Serializable]
		public class RefExtraInfo // TypeDefIndex: 58664
		{
			// Fields
			public List<CustomUIStyleInfo> customUIStyles; // 0x10
	
			// Nested types
			[Serializable]
			public class CustomUIStyleInfo // TypeDefIndex: 58663
			{
				// Fields
				public CustomUIStyle style; // 0x10
				public Component component; // 0x18
	
				// Constructors
				public CustomUIStyleInfo() {} // 0x000000018350B670-0x000000018350B680
			}
	
			// Constructors
			public RefExtraInfo() {} // 0x00000001837CA630-0x00000001837CA6B0
		}
	
		// Constructors
		public LuaReference() {} // 0x0000000182815690-0x0000000182815830
	
		// Methods
		private void Reset() {} // 0x000000018893DA7C-0x000000018893DD10
		private void OnDestroy() {} // 0x000000018260DFA0-0x000000018260DFF0
		private void _UnBindFromXluaRef() {} // 0x000000018260CEA0-0x000000018260DED0
		public void BindToLua(LuaTable table) {} // 0x000000018260B090-0x000000018260BC50
		private void _BindSelfReferences(LuaTable table) {} // 0x000000018260BC50-0x000000018260CEA0
		public bool ContainsGameObject(GameObject obj, bool recursive = true /* Metadata: 0x01FDB74B */) => default; // 0x000000018893D598-0x000000018893DA7C
	}

	public struct LuaTestReflectionOptStruct // TypeDefIndex: 58667
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
		public int a1 { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
		public string b1 { get => default; } // 0x0000000183D50DE0-0x0000000183D50DF0 
		public long l1 { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public ulong ul1 { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public float f1 { get => default; } // 0x0000000183D4F2E0-0x0000000183D4F2F0 
		public double d1 { get => default; } // 0x0000000183D4F5B0-0x0000000183D4F5C0 
		public bool bl1 { get => default; } // 0x0000000183D4EF60-0x0000000183D4EF70 
	
		// Constructors
		public LuaTestReflectionOptStruct(int a, string b, long l, ulong ul, float f, double d, bool bl) : this() {
			this.a = default;
			this.b = default;
			this.l = default;
			this.ul = default;
			this.f = default;
			this.d = default;
			this.bl = default;
		} // 0x000000018893E718-0x000000018893E760
	
		// Methods
		public int TestInt(int a) => default; // 0x000000018893E4F8-0x000000018893E54C
		public void TestVoid() {} // 0x000000018893E6D8-0x000000018893E718
		public void TestStructParam(LuaTestReflectionOptStruct testStruct) {} // 0x000000018893E660-0x000000018893E6D8
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct) {} // 0x000000018893E610-0x000000018893E660
		public object TestReturnObj() => default; // 0x000000018893E59C-0x000000018893E610
		public void TestObjParam(object obj) {} // 0x000000018893E54C-0x000000018893E59C
	}

	public struct LuaTestReflectionOptStruct2 // TypeDefIndex: 58668
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
		public int a1 { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
		public string b1 { get => default; } // 0x0000000183D50DE0-0x0000000183D50DF0 
		public long l1 { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public ulong ul1 { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public float f1 { get => default; } // 0x0000000183D4F2E0-0x0000000183D4F2F0 
		public double d1 { get => default; } // 0x0000000183D4F5B0-0x0000000183D4F5C0 
		public bool bl1 { get => default; } // 0x0000000183D4EF60-0x0000000183D4EF70 
	
		// Methods
		public int TestInt(int a) => default; // 0x000000018893E2D8-0x000000018893E32C
		public void TestVoid() {} // 0x000000018893E4B8-0x000000018893E4F8
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct) {} // 0x000000018893E440-0x000000018893E4B8
		public void TestStructParam2(ref LuaTestReflectionOptStruct2 testStruct) {} // 0x000000018893E3F0-0x000000018893E440
		public object TestReturnObj() => default; // 0x000000018893E37C-0x000000018893E3F0
		public void TestObjParam(object obj) {} // 0x000000018893E32C-0x000000018893E37C
	}

	public enum ETestEnum // TypeDefIndex: 58669
	{
		Test1 = 2,
		Test2 = 2
	}

	public class LuaTestReflectionOpt2 // TypeDefIndex: 58670
	{
		// Fields
		public List<int> TestList; // 0x10
		public Dictionary<int, string> TestDict; // 0x18
	
		// Constructors
		public LuaTestReflectionOpt2() {} // 0x000000018893E14C-0x000000018893E2D8
	
		// Methods
		public void TestVoid() {} // 0x000000018893E10C-0x000000018893E14C
		public int TestInt(int a) => default; // 0x000000018893DD60-0x000000018893DDB4
		[IDTag(0)]
		public void TestStructParam(LuaTestReflectionOptStruct testStruct) {} // 0x000000018893DF8C-0x000000018893E004
		[IDTag(1)]
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct) {} // 0x000000018893DF14-0x000000018893DF8C
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct) {} // 0x000000018893DEC4-0x000000018893DF14
		public object TestReturnObj() => default; // 0x000000018893DE50-0x000000018893DEC4
		public void TestObjParam(object obj) {} // 0x000000018893DDB4-0x000000018893DE04
		public void TestEnum(ETestEnum e) {} // 0x000000018893DD10-0x000000018893DD60
		public ETestEnum TestReturnEnum() => default; // 0x000000018893DE04-0x000000018893DE50
		public LuaTestReflectionOptStruct TestStruct(LuaTestReflectionOptStruct a) => default; // 0x000000018893E004-0x000000018893E10C
	}

	public class LuaTestReflectionOpt // TypeDefIndex: 58671
	{
		// Fields
		public List<int> TestList; // 0x10
		public Dictionary<int, string> TestDict; // 0x18
	
		// Constructors
		public LuaTestReflectionOpt() {} // 0x000000018893EB9C-0x000000018893ED28
	
		// Methods
		public void TestVoid() {} // 0x000000018893EB5C-0x000000018893EB9C
		public int TestInt(int a) => default; // 0x000000018893E7B0-0x000000018893E804
		[IDTag(0)]
		public void TestStructParam(LuaTestReflectionOptStruct testStruct) {} // 0x000000018893E9DC-0x000000018893EA54
		[IDTag(1)]
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct) {} // 0x000000018893E964-0x000000018893E9DC
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct) {} // 0x000000018893E914-0x000000018893E964
		public object TestReturnObj() => default; // 0x000000018893E8A0-0x000000018893E914
		public void TestObjParam(object obj) {} // 0x000000018893E804-0x000000018893E854
		public void TestEnum(ETestEnum e) {} // 0x000000018893E760-0x000000018893E7B0
		public ETestEnum TestReturnEnum() => default; // 0x000000018893E854-0x000000018893E8A0
		public LuaTestReflectionOptStruct TestStruct(LuaTestReflectionOptStruct a) => default; // 0x000000018893EA54-0x000000018893EB5C
	}

	public class LuaUIWidget : MonoBehaviour, IUIClearable // TypeDefIndex: 58672
	{
		// Fields
		public string id; // 0x18
		public bool isEmbeddedWidget; // 0x20
		public LuaFunction onEnable; // 0x30
		public LuaFunction onDisable; // 0x38
		public LuaFunction onDestroy; // 0x40
	
		// Properties
		public LuaTable table { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000183743D60-0x0000000183743D70
	
		// Constructors
		public LuaUIWidget() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Reset() {} // 0x000000018893ED28-0x000000018893ED94
		private void OnEnable() {} // 0x00000001825E5070-0x00000001825E50E0
		private void OnDisable() {} // 0x00000001825E4FD0-0x00000001825E5040
		private void OnDestroy() {} // 0x0000000183561EE0-0x0000000183561F20
		public void ClearComponent() {} // 0x000000018260E090-0x000000018260E1B0
	}

	public static class UtilsForLua // TypeDefIndex: 58675
	{
		// Fields
		private static Vector3[] s_worldCorners; // 0x00
	
		// Nested types
		public class ImageContentParam // TypeDefIndex: 58673
		{
			// Fields
			public string path; // 0x10
	
			// Constructors
			public ImageContentParam() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		static UtilsForLua() {} // 0x0000000183D43270-0x0000000183D432E0
	
		// Methods
		[IDTag(0)]
		public static GameObject CreateObject(GameObject asset) => default; // 0x0000000183B742E0-0x0000000183B74360
		[IDTag(1)]
		public static GameObject CreateObject(GameObject asset, Transform parent) => default; // 0x0000000182874B30-0x0000000182874BC0
		[IDTag(2)]
		public static GameObject CreateObject(GameObject asset, GameObject parent) => default; // 0x0000000182874A90-0x0000000182874B30
		public static void UIContainerResize(Transform container, int size, int templateIndex = 0 /* Metadata: 0x01FDB74E */) {} // 0x0000000188940890-0x0000000188940A74
		public static int TurnOffLayer(int value, string layerName) => default; // 0x000000018894063C-0x00000001889406A0
		public static int TurnOnLayer(int value, string layerName) => default; // 0x00000001889406A0-0x0000000188940704
		public static int ToggleLayer(int value, string layerName) => default; // 0x00000001889404CC-0x0000000188940530
		public static void ClearUIComponents(GameObject gameObject) {} // 0x0000000182AE9FF0-0x0000000182AEA060
		public static bool RayCast(out RaycastHit hitInfo, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction interaction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x01FDB74F */) {
			hitInfo = default;
			return default;
		} // 0x000000018893FB28-0x000000018893FC24
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction interaction) => default; // 0x000000018893FC24-0x000000018893FD20
		public static Bounds GetRectTransformBounds(RectTransform transform) => default; // 0x0000000182B37BD0-0x0000000182B37D70
		public static UnityEngine.Rect RectTransformToScreenRect(RectTransform rectTransform, Camera uiCamera) => default; // 0x000000018893FD20-0x000000018893FDD0
		public static Vector3 GetRectTransformCenterPosition(RectTransform rectTransform) => default; // 0x000000018893F680-0x000000018893F7B4
		public static Bounds CalcBoundOfRectTransform(RectTransform transform, RectTransform local) => default; // 0x000000018893F19C-0x000000018893F254
		public static List<string> GetStringList() => default; // 0x000000018893F818-0x000000018893F8A8
		public static int GetStringHash(string str) => default; // 0x000000018893F7B4-0x000000018893F818
		public static float EntityDistance(Entity a, Entity b) => default; // 0x000000018893F254-0x000000018893F310
		public static void OpenAccountCenter() {} // 0x000000018893F8A8-0x000000018893F914
		public static void ExitGame() {} // 0x000000018893F310-0x000000018893F38C
		public static string GetCurrentUID() => default; // 0x000000018893F560-0x000000018893F5E4
		public static bool StartPayment(string productId, string signParams) => default; // 0x00000001889403C8-0x0000000188940458
		public static bool TryGetCharacterVolume(UnityEngine.Rendering.Volume volume, out HGCharacterVolume hgCharacterVolume) {
			hgCharacterVolume = default;
			return default;
		} // 0x00000001889405A4-0x000000018894063C
		public static float GetAnimationCurveLength(AnimationCurve curve) => default; // 0x000000018893F38C-0x000000018893F408
		public static Tweener TweenTo(float from, float to, float duration, LuaFunction setter) => default; // 0x0000000188940704-0x0000000188940890
		public static bool IsNull(UnityEngine.Object o) => default; // 0x000000018333FE20-0x000000018333FE90
		public static ImageContentParam ParseImageContent(string xml) => default; // 0x000000018893F914-0x000000018893FAD8
		public static void ReturnToLogin() {} // 0x000000018893FDD0-0x000000018893FE4C
		public static void QuitGame(int exitCode) {} // 0x000000018893FAD8-0x000000018893FB28
		public static void ToggleCharInfoInUpgradePanelOption(bool isIn) {} // 0x0000000188940458-0x00000001889404CC
		public static void ToggleWeaponInUpgradePanelOption(bool isIn) {} // 0x0000000188940530-0x00000001889405A4
		public static CinemachineTransposer GetCinemachineTransposer(CinemachineVirtualCamera vcam) => default; // 0x000000018893F4B4-0x000000018893F560
		public static CinemachineComposer GetCinemachineComposer(CinemachineVirtualCamera vcam) => default; // 0x000000018893F408-0x000000018893F4B4
		public static CinemachineCameraOffset GetOrAddCinemachineCameraOffset(CinemachineVirtualCamera vcam) => default; // 0x000000018893F5E4-0x000000018893F680
	
		// Extension methods
		public static void SetPosX(this Transform t, float value) {} // 0x000000018893FE4C-0x000000018893FEEC
		public static void SetPosY(this Transform t, float value) {} // 0x000000018893FEEC-0x000000018893FF8C
		public static void SetPosZ(this Transform t, float value) {} // 0x000000018893FF8C-0x0000000188940020
		public static void SetRotX(this Transform t, float value) {} // 0x0000000188940020-0x00000001889400C0
		public static void SetRotY(this Transform t, float value) {} // 0x00000001889400C0-0x0000000188940160
		public static void SetRotZ(this Transform t, float value) {} // 0x0000000188940160-0x00000001889401F4
		public static void SetScaleX(this Transform t, float value) {} // 0x00000001889401F4-0x0000000188940294
		public static void SetScaleY(this Transform t, float value) {} // 0x0000000188940294-0x0000000188940334
		public static void SetScaleZ(this Transform t, float value) {} // 0x0000000188940334-0x00000001889403C8
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 58635
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 58636
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 58637
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 58638
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 58639
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 58634
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 58676
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D059C0-0x0000000183D05A30
	
		// Methods
		public void __Gen_Wrap_0(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
		public bool __Gen_Wrap_1() => default; // 0x000000018514F380-0x000000018514F42C
		public void __Gen_Wrap_2() {} // 0x00000001850F3444-0x00000001850F34E0
		public void __Gen_Wrap_3(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public Dictionary<string, LuaCustomConfig.Item> __Gen_Wrap_4(object P0) => default; // 0x0000000188938060-0x000000018893813C
		public string __Gen_Wrap_5(object P0) => default; // 0x00000001889389F0-0x0000000188938ACC
		public object __Gen_Wrap_6(object P0, object P1) => default; // 0x00000001889391A0-0x00000001889392AC
		public void __Gen_Wrap_7(object P0, object P1, object P2, object P3) {} // 0x0000000185160E44-0x0000000185160F3C
		public LuaTable __Gen_Wrap_8(object P0, object P1, object P2) => default; // 0x000000018893974C-0x0000000188939874
		public bool __Gen_Wrap_9(object P0, object P1) => default; // 0x0000000185153920-0x0000000185153A0C
		public bool __Gen_Wrap_10(object P0, object P1, object P2) => default; // 0x0000000185488110-0x0000000185488204
		public void __Gen_Wrap_11(object P0, object P1, object P2) {} // 0x0000000185150B1C-0x0000000185150C14
		public System.Type __Gen_Wrap_12(object P0) => default; // 0x0000000188935E1C-0x0000000188935F0C
		public object __Gen_Wrap_13(object P0) => default; // 0x0000000188935F0C-0x0000000188935FFC
		public bool __Gen_Wrap_14(object P0) => default; // 0x000000018514EF5C-0x000000018514F02C
		public bool __Gen_Wrap_15(Span<byte> P0, int P1) => default; // 0x0000000188935FFC-0x000000018893611C
		public byte[] __Gen_Wrap_16(object P0, object P1) => default; // 0x000000018893611C-0x0000000188936228
		public void __Gen_Wrap_17(object P0, HGRenderPipeCallbackArgs P1) {} // 0x0000000188936228-0x0000000188936328
		public string __Gen_Wrap_18() => default; // 0x0000000188936328-0x00000001889363E0
		public void __Gen_Wrap_19(IntPtr P0, int P1, object P2) {} // 0x00000001889363E0-0x00000001889364C4
		public void __Gen_Wrap_20(int P0, object P1) {} // 0x00000001850F1370-0x00000001850F1438
		public byte[] __Gen_Wrap_21(object P0, ref string P1) => default; // 0x00000001889364C4-0x00000001889365FC
		public void __Gen_Wrap_22(object P0, EnvLang P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public int __Gen_Wrap_23(IntPtr P0) => default; // 0x0000000185152658-0x0000000185152714
		public void __Gen_Wrap_24(IntPtr P0, int P1, out StringPathHash P2) {
			P2 = default;
		} // 0x00000001889365FC-0x0000000188936734
		public bool __Gen_Wrap_25(IntPtr P0, int P1) => default; // 0x0000000188936734-0x0000000188936820
		public void __Gen_Wrap_26(object P0, bool P1) {} // 0x00000001850F0448-0x00000001850F0510
		public void __Gen_Wrap_27(object P0, float P1) {} // 0x00000001850F0008-0x00000001850F00E8
		public string __Gen_Wrap_28(object P0, object P1) => default; // 0x0000000188936820-0x0000000188936918
		public long __Gen_Wrap_29(object P0, object P1, out int P2) {
			P2 = default;
			return default;
		} // 0x0000000188936918-0x0000000188936A30
		public IntPtr __Gen_Wrap_30(object P0, object P1) => default; // 0x000000018870040C-0x00000001887004E4
		public object[] __Gen_Wrap_31(object P0, object P1) => default; // 0x0000000188936A30-0x0000000188936B28
		public IntPtr __Gen_Wrap_32(object P0) => default; // 0x000000018516CA20-0x000000018516CAF0
		public bool __Gen_Wrap_33(LuaReference P0) => default; // 0x00000001850EF298-0x00000001850EF354
		public bool __Gen_Wrap_34(object P0, object P1, bool P2) => default; // 0x000000018561AEBC-0x000000018561AFB0
		public int __Gen_Wrap_35(ref LuaTestReflectionOptStruct P0, int P1) => default; // 0x0000000188936B28-0x0000000188936CB0
		public void __Gen_Wrap_36(ref LuaTestReflectionOptStruct P0) {} // 0x0000000188936CB0-0x0000000188936E0C
		public void __Gen_Wrap_37(ref LuaTestReflectionOptStruct P0, LuaTestReflectionOptStruct P1) {} // 0x0000000188936E0C-0x0000000188936FB4
		public void __Gen_Wrap_38(ref LuaTestReflectionOptStruct P0, ref LuaTestReflectionOptStruct P1) {} // 0x0000000188936FB4-0x00000001889371B0
		public object __Gen_Wrap_39(ref LuaTestReflectionOptStruct P0) => default; // 0x00000001889371B0-0x0000000188937330
		public void __Gen_Wrap_40(ref LuaTestReflectionOptStruct P0, object P1) {} // 0x0000000188937330-0x00000001889374A8
		public int __Gen_Wrap_41(ref LuaTestReflectionOptStruct2 P0, int P1) => default; // 0x00000001889374A8-0x0000000188937630
		public void __Gen_Wrap_42(ref LuaTestReflectionOptStruct2 P0) {} // 0x0000000188937630-0x000000018893778C
		public void __Gen_Wrap_43(ref LuaTestReflectionOptStruct2 P0, LuaTestReflectionOptStruct2 P1) {} // 0x000000018893778C-0x0000000188937934
		public void __Gen_Wrap_44(ref LuaTestReflectionOptStruct2 P0, ref LuaTestReflectionOptStruct2 P1) {} // 0x0000000188937934-0x0000000188937B30
		public object __Gen_Wrap_45(ref LuaTestReflectionOptStruct2 P0) => default; // 0x0000000188937B30-0x0000000188937CB0
		public void __Gen_Wrap_46(ref LuaTestReflectionOptStruct2 P0, object P1) {} // 0x0000000188937CB0-0x0000000188937E28
		public int __Gen_Wrap_47(object P0, int P1) => default; // 0x0000000185613324-0x00000001856133FC
		public void __Gen_Wrap_48(object P0, LuaTestReflectionOptStruct P1) {} // 0x0000000188937E28-0x0000000188937F44
		public void __Gen_Wrap_49(object P0, LuaTestReflectionOptStruct2 P1) {} // 0x0000000188937F44-0x0000000188938060
		public void __Gen_Wrap_50(object P0, ref LuaTestReflectionOptStruct P1) {} // 0x000000018893813C-0x00000001889382B4
		public void __Gen_Wrap_51(object P0, ETestEnum P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public ETestEnum __Gen_Wrap_52(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public LuaTestReflectionOptStruct __Gen_Wrap_53(object P0, LuaTestReflectionOptStruct P1) => default; // 0x00000001889382B4-0x0000000188938420
		public GameObject __Gen_Wrap_54(object P0) => default; // 0x0000000188938420-0x0000000188938510
		public GameObject __Gen_Wrap_55(object P0, object P1) => default; // 0x0000000188938510-0x000000018893861C
		public void __Gen_Wrap_56(object P0, int P1, int P2) {} // 0x00000001887040F0-0x00000001887041D4
		public int __Gen_Wrap_57(int P0, object P1) => default; // 0x000000018893861C-0x00000001889386F4
		public bool __Gen_Wrap_58(out RaycastHit P0, Ray P1, float P2, int P3, QueryTriggerInteraction P4) {
			P0 = default;
			return default;
		} // 0x00000001889386F4-0x000000018893889C
		public int __Gen_Wrap_59(Ray P0, object P1, float P2, int P3, QueryTriggerInteraction P4) => default; // 0x000000018893889C-0x00000001889389F0
		public Bounds __Gen_Wrap_60(object P0) => default; // 0x0000000188938ACC-0x0000000188938BD0
		public UnityEngine.Rect __Gen_Wrap_61(object P0, object P1) => default; // 0x0000000188938BD0-0x0000000188938CE8
		public Vector3 __Gen_Wrap_62(object P0) => default; // 0x0000000188938CE8-0x0000000188938DE8
		public Bounds __Gen_Wrap_63(object P0, object P1) => default; // 0x0000000188938DE8-0x0000000188938F08
		public List<string> __Gen_Wrap_64() => default; // 0x0000000188938F08-0x0000000188938FC0
		public int __Gen_Wrap_65(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public float __Gen_Wrap_66(object P0, object P1) => default; // 0x000000018870A4D8-0x000000018870A5B0
		public bool __Gen_Wrap_67(object P0, out HGCharacterVolume P1) {
			P1 = default;
			return default;
		} // 0x0000000188938FC0-0x00000001889390E4
		public float __Gen_Wrap_68(object P0) => default; // 0x00000001889390E4-0x00000001889391A0
		public float __Gen_Wrap_69() => default; // 0x00000001850F18D0-0x00000001850F1968
		public void __Gen_Wrap_70(float P0) {} // 0x00000001850F0B68-0x00000001850F0C14
		public Tweener __Gen_Wrap_71(float P0, float P1, float P2, object P3) => default; // 0x00000001889392AC-0x00000001889393DC
		public UtilsForLua.ImageContentParam __Gen_Wrap_72(object P0) => default; // 0x00000001889393DC-0x00000001889394B8
		public void __Gen_Wrap_73(int P0) {} // 0x00000001850EE9C4-0x00000001850EEA70
		public void __Gen_Wrap_74(bool P0) {} // 0x00000001850F0C14-0x00000001850F0CC0
		public CinemachineTransposer __Gen_Wrap_75(object P0) => default; // 0x00000001889394B8-0x0000000188939594
		public CinemachineComposer __Gen_Wrap_76(object P0) => default; // 0x0000000188939594-0x0000000188939670
		public CinemachineCameraOffset __Gen_Wrap_77(object P0) => default; // 0x0000000188939670-0x000000018893974C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 58677
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000188939874-0x0000000188939908
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 58678
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000188940C5C-0x0000000188940CC0
		public static bool IsPatched(int id) => default; // 0x0000000182BE3A60-0x0000000182BE3AD0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000188940B18-0x0000000188940BE4
		public object CreateWrapper(int id) => default; // 0x0000000188940BE4-0x0000000188940C5C
		public object InitWrapperArray(int len) => default; // 0x0000000188940CC0-0x0000000188940D4C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000188940A74-0x0000000188940B18
	}

	public enum IDMAP0 // TypeDefIndex: 58679
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
		Beyond-Lua-LuaManager-_ReleaseDelegateInAnotherStackFrame0 = 66,
		Beyond-Lua-LuaManager-ReStartLuaProfiler0 = 67,
		Beyond-Lua-LuaManager-set_isQuittingApplication0 = 68,
		Beyond-Lua-LuaManager-Tick0 = 69,
		Beyond-Lua-LuaManager-LateTick0 = 70,
		Beyond-Lua-LuaManager-TailLateTick0 = 71,
		Beyond-Lua-LuaManager-GetLuaFileRealPath0 = 72,
		Beyond-Lua-LuaManager-IsLuaFileExist0 = 73,
		Beyond-Lua-LuaManager-LoadLuaByteByFileRealPath0 = 74,
		Beyond-Lua-LuaManager-LoadLua0 = 75,
		Beyond-Lua-LuaManager-LoadLuaBytePtr0 = 76,
		Beyond-Lua-LuaManager-DoString0 = 77,
		Beyond-Lua-LuaManager-GetLuaState0 = 78,
		Beyond-Lua-LuaManager-ClearAllUnityObjectUserdata0 = 79,
		Beyond-Lua-LuaManager-AddLuaEventAfterGCDo0 = 80,
		Beyond-Lua-LuaManager-RemoveLuaEventAfterGCDo0 = 81,
		Beyond-Lua-LuaReference-Reset0 = 82,
		Beyond-Lua-LuaReference-OnDestroy0 = 86,
		Beyond-Lua-LuaReference-_UnBindFromXluaRef0 = 87,
		Beyond-Lua-LuaReference-BindToLua0 = 88,
		Beyond-Lua-LuaReference-_BindSelfReferences0 = 89,
		Beyond-Lua-LuaReference-ContainsGameObject0 = 90,
		Beyond-Lua-LuaTestReflectionOptStruct-TestInt0 = 91,
		Beyond-Lua-LuaTestReflectionOptStruct-TestVoid0 = 92,
		Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam0 = 93,
		Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam20 = 94,
		Beyond-Lua-LuaTestReflectionOptStruct-TestReturnObj0 = 95,
		Beyond-Lua-LuaTestReflectionOptStruct-TestObjParam0 = 96,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestInt0 = 97,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestVoid0 = 98,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam0 = 99,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam20 = 100,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestReturnObj0 = 101,
		Beyond-Lua-LuaTestReflectionOptStruct2-TestObjParam0 = 102,
		Beyond-Lua-LuaTestReflectionOpt2-TestVoid0 = 103,
		Beyond-Lua-LuaTestReflectionOpt2-TestInt0 = 104,
		Beyond-Lua-LuaTestReflectionOpt2-TestStructParam0 = 105,
		Beyond-Lua-LuaTestReflectionOpt2-TestStructParam1 = 106,
		Beyond-Lua-LuaTestReflectionOpt2-TestStructParam20 = 107,
		Beyond-Lua-LuaTestReflectionOpt2-TestReturnObj0 = 108,
		Beyond-Lua-LuaTestReflectionOpt2-TestObjParam0 = 109,
		Beyond-Lua-LuaTestReflectionOpt2-TestEnum0 = 110,
		Beyond-Lua-LuaTestReflectionOpt2-TestReturnEnum0 = 111,
		Beyond-Lua-LuaTestReflectionOpt2-TestStruct0 = 112,
		Beyond-Lua-LuaTestReflectionOpt-TestVoid0 = 113,
		Beyond-Lua-LuaTestReflectionOpt-TestInt0 = 114,
		Beyond-Lua-LuaTestReflectionOpt-TestStructParam0 = 115,
		Beyond-Lua-LuaTestReflectionOpt-TestStructParam1 = 116,
		Beyond-Lua-LuaTestReflectionOpt-TestStructParam20 = 117,
		Beyond-Lua-LuaTestReflectionOpt-TestReturnObj0 = 118,
		Beyond-Lua-LuaTestReflectionOpt-TestObjParam0 = 119,
		Beyond-Lua-LuaTestReflectionOpt-TestEnum0 = 120,
		Beyond-Lua-LuaTestReflectionOpt-TestReturnEnum0 = 121,
		Beyond-Lua-LuaTestReflectionOpt-TestStruct0 = 122,
		Beyond-Lua-LuaUIWidget-Reset0 = 123,
		Beyond-Lua-LuaUIWidget-OnEnable0 = 124,
		Beyond-Lua-LuaUIWidget-OnDisable0 = 125,
		Beyond-Lua-LuaUIWidget-OnDestroy0 = 126,
		Beyond-Lua-LuaUIWidget-ClearComponent0 = 127,
		Beyond-Lua-UtilsForLua-CreateObject0 = 130,
		Beyond-Lua-UtilsForLua-CreateObject1 = 131,
		Beyond-Lua-UtilsForLua-CreateObject2 = 132,
		Beyond-Lua-UtilsForLua-UIContainerResize0 = 133,
		Beyond-Lua-UtilsForLua-TurnOffLayer0 = 134,
		Beyond-Lua-UtilsForLua-TurnOnLayer0 = 135,
		Beyond-Lua-UtilsForLua-ToggleLayer0 = 136,
		Beyond-Lua-UtilsForLua-SetPosX0 = 137,
		Beyond-Lua-UtilsForLua-SetPosY0 = 138,
		Beyond-Lua-UtilsForLua-SetPosZ0 = 139,
		Beyond-Lua-UtilsForLua-SetRotX0 = 140,
		Beyond-Lua-UtilsForLua-SetRotY0 = 141,
		Beyond-Lua-UtilsForLua-SetRotZ0 = 142,
		Beyond-Lua-UtilsForLua-SetScaleX0 = 143,
		Beyond-Lua-UtilsForLua-SetScaleY0 = 144,
		Beyond-Lua-UtilsForLua-SetScaleZ0 = 145,
		Beyond-Lua-UtilsForLua-ClearUIComponents0 = 146,
		Beyond-Lua-UtilsForLua-RayCast0 = 147,
		Beyond-Lua-UtilsForLua-RaycastNonAlloc0 = 148,
		Beyond-Lua-UtilsForLua-GetRectTransformBounds0 = 149,
		Beyond-Lua-UtilsForLua-RectTransformToScreenRect0 = 150,
		Beyond-Lua-UtilsForLua-GetRectTransformCenterPosition0 = 151,
		Beyond-Lua-UtilsForLua-CalcBoundOfRectTransform0 = 152,
		Beyond-Lua-UtilsForLua-GetStringList0 = 153,
		Beyond-Lua-UtilsForLua-GetStringHash0 = 154,
		Beyond-Lua-UtilsForLua-EntityDistance0 = 155,
		Beyond-Lua-UtilsForLua-OpenAccountCenter0 = 156,
		Beyond-Lua-UtilsForLua-ExitGame0 = 157,
		Beyond-Lua-UtilsForLua-GetCurrentUID0 = 158,
		Beyond-Lua-UtilsForLua-StartPayment0 = 159,
		Beyond-Lua-UtilsForLua-TryGetCharacterVolume0 = 160,
		Beyond-Lua-UtilsForLua-GetAnimationCurveLength0 = 161,
		Beyond-Lua-UtilsForLua-TweenTo0 = 162,
		Beyond-Lua-UtilsForLua-IsNull0 = 166,
		Beyond-Lua-UtilsForLua-ParseImageContent0 = 167,
		Beyond-Lua-UtilsForLua-ReturnToLogin0 = 168,
		Beyond-Lua-UtilsForLua-QuitGame0 = 169,
		Beyond-Lua-UtilsForLua-ToggleCharInfoInUpgradePanelOption0 = 170,
		Beyond-Lua-UtilsForLua-ToggleWeaponInUpgradePanelOption0 = 171,
		Beyond-Lua-UtilsForLua-GetCinemachineTransposer0 = 172,
		Beyond-Lua-UtilsForLua-GetCinemachineComposer0 = 173,
		Beyond-Lua-UtilsForLua-GetOrAddCinemachineCameraOffset0 = 174
	}
}
