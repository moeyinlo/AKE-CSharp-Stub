/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Beyond;
using Beyond.GEnums;
using Beyond.Gameplay;
using Beyond.Gameplay.Core;
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

// Image 70: Lua.Beyond.dll - Assembly: Lua.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59658-59704

namespace Beyond.Lua
{
	public abstract class CsToLuaClass // TypeDefIndex: 59665
	{
		// Fields
		protected LuaTable m_luaTable; // 0x10
	
		// Constructors
		protected CsToLuaClass() {} // Dummy constructor
		public CsToLuaClass(string luaPath) {} // 0x000000018AA48C9C-0x000000018AA48D74
	}

	public class LuaEventSystem : ILuaEventSystem, IDisposable // TypeDefIndex: 59673
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
		public delegate void DispatchEventFunc(string eventName, LuaTable luaTable); // TypeDefIndex: 59666; 0x0000000184772110-0x0000000184772290
	
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 59667
		{
			// Fields
			public LuaEventSystem __4__this; // 0x10
			public string eventName; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0() {}
	
			// Methods
			internal void _DispatchEvent_b__0() {}
		}
	
		private sealed class __c__DisplayClass10_0<T> // TypeDefIndex: 59668
		{
			// Fields
			public LuaEventSystem __4__this;
			public string eventName;
			public T arg;
	
			// Constructors
			public __c__DisplayClass10_0() {}
	
			// Methods
			internal void _DispatchEvent_b__0() {} // 0x0000000184772740-0x00000001847728A0
		}
	
		private sealed class __c__DisplayClass11_0<T0, T1> // TypeDefIndex: 59669
		{
			// Fields
			public LuaEventSystem __4__this;
			public string eventName;
			public T0 arg0;
			public T1 arg1;
	
			// Constructors
			public __c__DisplayClass11_0() {} // 0x000000018AA4F518-0x000000018AA4F5B4
	
			// Methods
			internal void _DispatchEvent_b__0() {} // 0x00000001846DBAD0-0x00000001846DBB50
		}
	
		private sealed class __c__DisplayClass12_0<T0, T1, T2> // TypeDefIndex: 59670
		{
			// Fields
			public LuaEventSystem __4__this;
			public string eventName;
			public T0 arg0;
			public T1 arg1;
			public T2 arg2;
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x00000001831C5680-0x00000001831C5690
	
			// Methods
			internal void _DispatchEvent_b__0() {} // 0x0000000186E8C1B8-0x0000000186E8C1EC
		}
	
		private sealed class __c__DisplayClass13_0<T0, T1, T2, T3> // TypeDefIndex: 59671
		{
			// Fields
			public LuaEventSystem __4__this;
			public string eventName;
			public T0 arg0;
			public T1 arg1;
			public T2 arg2;
			public T3 arg3;
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x00000001864BB614-0x00000001864BB734
	
			// Methods
			internal void _DispatchEvent_b__0() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __c__DisplayClass14_0<T0, T1, T2, T3, T4> // TypeDefIndex: 59672
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
			public __c__DisplayClass14_0() {} // 0x000000018AA5215C-0x000000018AA52244
	
			// Methods
			internal void _DispatchEvent_b__0() {}
		}
	
		// Constructors
		public LuaEventSystem() {}
	
		// Methods
		public void DispatchEvent(string eventName) {}
		public void DispatchEvent<T>(string eventName, T arg) {}
		public void DispatchEvent<T0, T1>(string eventName, T0 arg0, T1 arg1) {}
		public void DispatchEvent<T0, T1, T2>(string eventName, T0 arg0, T1 arg1, T2 arg2) {}
		public void DispatchEvent<T0, T1, T2, T3>(string eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3) {}
		public void DispatchEvent<T0, T1, T2, T3, T4>(string eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {}
		public void PushEventName(string eventName) {}
		public void Dispose() {}
	}

	public class CSharpCallLuaRegistration // TypeDefIndex: 59674
	{
		// Fields
		private LuaEventSystem m_luaEventSystem; // 0x10
	
		// Constructors
		public CSharpCallLuaRegistration() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Init() {} // 0x0000000185A21860-0x0000000185A21950
		public void Dispose() {} // 0x000000018AA48BFC-0x000000018AA48C9C
	}

	public class LuaCustomConfig : MonoBehaviour, ILuaCallCSharp, ISerializationCallbackReceiver // TypeDefIndex: 59679
	{
		// Fields
		public List<Item> itemList; // 0x18
		private Dictionary<string, Item> m_itemDict; // 0x20
	
		// Properties
		public Dictionary<string, Item> itemDict { get => default; } // 0x000000018AA4D8F4-0x000000018AA4DA3C 
	
		// Nested types
		public enum ValueType // TypeDefIndex: 59675
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
		public class Item : ILuaCallCSharp // TypeDefIndex: 59676
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
			private string m_lastLuaValue; // 0xC8
			[NonSerialized]
			private System.Type m_cachedEnumType; // 0xD0
	
			// Constructors
			public Item() {} // 0x000000018AA4EBF4-0x000000018AA4EDC8
	
			// Methods
			public bool HasLuaValueChanged() => default; // 0x000000018AA4F334-0x000000018AA4F518
			public bool ShouldSerializeLuaTableJson() => default; // 0x00000001855DEE90-0x00000001855DEEC0
			public void MarkLuaValueProcessed() {} // 0x00000001854D22B0-0x00000001854D22E0
			public System.Type GetEnumType() => default; // 0x000000018AA4EDC8-0x000000018AA4F044
			public object GetEnumValueObject() => default; // 0x000000018AA4D3E8-0x000000018AA4D488
		}
	
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 59677
		{
			// Fields
			public List<object> keys1; // 0x10
			public List<object> keys2; // 0x18
	
			// Constructors
			public __c__DisplayClass15_0() {} // 0x000000018AA4F044-0x000000018AA4F334
	
			// Methods
			internal void __CompareLuaTables_b__0(object k, object _) {} // 0x000000018AA4DEC0-0x000000018AA4E00C
			internal void __CompareLuaTables_b__1(object k, object _) {} // 0x000000018AA4E1B4-0x000000018AA4E64C
		}
	
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 59678
		{
			// Fields
			public JObject jObject; // 0x10
	
			// Constructors
			public __c__DisplayClass23_0() {} // 0x000000018AA4DA3C-0x000000018AA4DBB4
	
			// Methods
			internal void _ConvertLuaTableToJson_b__0(object key, object value) {} // 0x000000018AA4D488-0x000000018AA4D8F4
		}
	
		// Constructors
		public LuaCustomConfig() {} // 0x000000018AA51F94-0x000000018AA52098
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018AA4DD34-0x000000018AA4DEC0
		public void OnAfterDeserialize() {} // 0x0000000185097BB0-0x0000000185099E50
		private bool _ProcessLuaTableItem(Item item) => default; // 0x000000018AA4E00C-0x000000018AA4E1B4
		public bool ShouldProcessEnumItem(Item item) => default; // 0x000000018AA4E64C-0x000000018AA4EBF4
		private bool _ProcessEnumItem(Item item) => default; // 0x000000018AA4DBB4-0x000000018AA4DD34
		private bool _ValidateLuaTableConsistency(string luaCode, string json) => default; // 0x000000018AA4CFA0-0x000000018AA4D26C
		private LuaTable _JsonToLuaTableForValidation(string json, LuaEnv luaEnv) => default; // 0x000000018AA4D26C-0x000000018AA4D3E8
		private void _PopulateLuaTableFromJTokenForValidation(LuaTable luaTable, JToken jToken, LuaEnv luaEnv) {} // 0x00000001845608D0-0x0000000184560960
		private object _ConvertJValueToObjectForValidation(JToken jValue) => default; // 0x000000018AA4CE78-0x000000018AA4CED4
		private bool _CompareLuaTables(LuaTable table1, LuaTable table2) => default; // 0x000000018AA4CF30-0x000000018AA4CFA0
		private bool _CompareValues(object value1, object value2) => default; // 0x000000018AA4CED4-0x000000018AA4CF30
		private bool _IsNumericType(object obj) => default; // 0x000000018AA4CAD8-0x000000018AA4CCC4
		public void InitConfigTable(LuaTable configTable) {} // 0x000000018AA4CCC4-0x000000018AA4CE78
		private LuaTable _JsonToLuaTable(string json, LuaEnv luaEnv) => default; // 0x0000000184F9CB00-0x0000000184F9CBE0
		private void _PopulateLuaTableFromJToken(LuaTable luaTable, JToken jToken) {} // 0x0000000185492010-0x0000000185492020
		private object _ConvertJValueToObject(JToken jValue) => default; // 0x000000018AA51EEC-0x000000018AA51F40
		public static string ConvertLuaCodeToJson(string luaCode) => default; // 0x000000018AA51F40-0x000000018AA51F94
		public static string ConvertLuaTableToJson(LuaTable luaTable) => default; // 0x0000000185492010-0x0000000185492020
	}

	public class LuaDebugSocketManager : MonoBehaviour // TypeDefIndex: 59680
	{
		// Constructors
		public LuaDebugSocketManager() {} // 0x0000000185EDCA50-0x0000000185EDCF80
	}

	public static class LuaHotFix // TypeDefIndex: 59682
	{
		// Nested types
		public delegate bool LuaHotFixInvoker(string luaCode); // TypeDefIndex: 59681; 0x000000018AA4F990-0x000000018AA4FA88
	
		// Methods
		public static void LuaHotFixTest() {} // 0x0000000189ED183C-0x0000000189ED1910
		public static bool HotFixLua(string lua) => default; // 0x00000001817C2F70-0x00000001817C2F80
		public static bool HotFixLua(byte[] lua) => default; // 0x0000000185A264E0-0x0000000185A26510
		public static bool HotFixLua(Span<byte> lua, int length) => default; // 0x00000001864BBBD0-0x00000001864BBD00
	}

	public class LoadLuaProxy : ILoadLuaProxy // TypeDefIndex: 59683
	{
		// Constructors
		public LoadLuaProxy() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static void _RunOnStart() {} // 0x0000000185F072D0-0x0000000185F07380
		public byte[] LoadLua(string name) => default; // 0x0000000184C33280-0x0000000184C332F0
	}

	public class LuaMethodPointerModule // TypeDefIndex: 59684
	{
		// Constructors
		public LuaMethodPointerModule() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static void _RunOnStart() {} // 0x0000000185D5C1D0-0x0000000185D5C310
	}

	public class LuaManager : BaseTickManager, ILuaProxy // TypeDefIndex: 59686
	{
		// Fields
		private static LuaManager _instance_k__BackingField; // 0x00
		private const float TICK_INTERVAL = 1f; // Metadata: 0x0208102B
		private readonly CSharpCallLuaRegistration m_csCallLua; // 0x70
		private PeriodicTimer m_envTickTimer; // 0x78
		public static bool s_xluaReflectionOpt; // 0x08
		private LuaEnv _luaEnv_k__BackingField; // 0x80
		public Action<LuaTable, string, LuaUIWidget> wrapUIWidgetFunction; // 0x88
		public Action<LuaTable, string, LuaReference> bindLuaRefFunction; // 0x90
		private bool m_isQuittingApplication; // 0x98
		public TickEvent actionTick; // 0xA0
		public TickEvent actionLateTick; // 0xA8
		public TickEvent actionTailTick; // 0xB0
		public TickEvent actionRenderDone; // 0xB8
	
		// Properties
		public static LuaManager instance { get; private set; } // 0x000000018AA505C0-0x000000018AA5061C 0x0000000184CC6750-0x0000000184CC6830
		public LuaEnv luaEnv { get; private set; } // 0x00000001873CBE98-0x00000001873CBEA8 0x0000000184771F80-0x0000000184772110
		public bool isQuittingApplication { get => default; set {} } // 0x000000018AA5061C-0x000000018AA506A4 0x000000018AA503FC-0x000000018AA505C0
		public override FrameTickGroup frameTickGroup { get => default; } // 0x0000000185FA4760-0x0000000185FA47A0 
	
		// Nested types
		public class TickEvent : DisposedUnityEvent<float> // TypeDefIndex: 59685
		{
			// Constructors
			public TickEvent() {} // 0x0000000185F8D6E0-0x0000000185F8D730
		}
	
		// Constructors
		public LuaManager() {} // 0x000000018140CF50-0x000000018140CF60
		static LuaManager() {} // 0x0000000187A71414-0x0000000187A7141C
	
		// Methods
		public static void CreateInstance() {} // 0x0000000184CC64D0-0x0000000184CC6580
		public static void DestroyInstance() {} // 0x0000000184B51CF0-0x0000000184B51E80
		public static bool IsEnableMultithreadGC() => default; // 0x0000000184772F50-0x0000000184773090
		public static bool IsLuaGCing() => default; // 0x00000001853DB8A0-0x00000001853DFA00
		protected override void OnInit() {} // 0x000000018AA4FC68-0x000000018AA4FE2C
		public static string GetLuaStack() => default; // 0x0000000185D577B0-0x0000000185D5AA20
		protected override void OnRelease() {} // 0x000000018AA50020-0x000000018AA50060
		public static void ReStartLuaProfiler() {} // 0x0000000185FB9E80-0x0000000185FB9E90
		private void _ReleaseDelegateInAnotherStackFrame() {} // 0x0000000184559C80-0x0000000184559F20
		public override void Tick(float deltaTime) {} // 0x0000000184559F20-0x000000018455A0F0
		public override void LateTick(float deltaTime) {} // 0x000000018455A0F0-0x000000018455A2C0
		public override void TailLateTick(float deltaTime) {} // 0x000000018AA4FBE4-0x000000018AA4FC68
		public string GetLuaFileRealPath(string modulePath) => default; // 0x000000018425B600-0x000000018425B670
		public bool IsLuaFileExist(string modulePath) => default; // 0x000000018AA4FE2C-0x000000018AA4FEF4
		public long LoadLuaByteByFileRealPath(string modulePath, out int len) {
			len = default;
			return default;
		} // 0x00000001849607D0-0x0000000184960850
		public byte[] LoadLua(string modulePath) => default; // 0x000000018AA4FEF4-0x000000018AA50020
		public IntPtr LoadLuaBytePtr(string modulePath) => default; // 0x0000000185BAB3F0-0x0000000185BAB470
		public byte[] LoadLuaBytes(ref string modulePath) => default; // 0x0000000185A21820-0x0000000185A21860
		private void _RegisterCSharpCallLua() {} // 0x0000000184C33C70-0x0000000184C33EF0
		private static void _Register3rdPartyLibraries(LuaEnv env) {} // 0x000000018AA50124-0x000000018AA50210
		private static void _HyperLuaLogCallback(IntPtr L, int level, string text) {} // 0x000000018AA50210-0x000000018AA502A0
		private static void _LuaUtilsLogCallback(int level, string text) {} // 0x000000018AA502A0-0x000000018AA50374
		private void _OnEnvLangChanged(EnvLang lang) {} // 0x000000018AA4FB4C-0x000000018AA4FBE4
		public object[] DoString(string code) => default; // 0x0000000184921DF0-0x0000000184921E30
		public IntPtr GetLuaState() => default; // 0x0000000184FD23C0-0x0000000184FD2420
		public void ClearAllUnityObjectUserdata() {} // 0x000000018AA50374-0x000000018AA503FC
		private void _OnRenderDone(HGRenderPipeCallbackArgs args) {} // 0x000000018455A450-0x000000018455A500
		private void _OnRenderDone() {} // 0x0000000185A5F090-0x0000000185A5F0E0
		public bool AddLuaEventAfterGCDo(UnityAction action) => default; // 0x000000018AA50060-0x000000018AA50124
		public static void RemoveLuaEventAfterGCDo(UnityAction action) {} // 0x000000018AA4FAC8-0x000000018AA4FB4C
		public void AddOnceLuaEventAfterGCDo(UnityAction action) {} // 0x0000000184852880-0x0000000184852960
		public static int LuaCalculateABPathHash(IntPtr L) => default; // 0x000000018433FD30-0x000000018433FE20
		public static void CasterStringPathHash(IntPtr L, int index, out StringPathHash o) {
			o = default;
		} // 0x000000018433F170-0x000000018433F1F0
		public static bool CheckStringPathHash(IntPtr L, int index) => default; // 0x0000000181D409B0-0x0000000181D40CF0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x0000000187A713F4-0x0000000187A713FC
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A7140C-0x0000000187A71414
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x0000000184B51E80-0x0000000184B51EC0
	}

	public class LuaReference : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 59691
	{
		// Fields
		public ComponentRefDict refDict; // 0x18
		public SerializeReferenceDictionary<string, RefExtraInfo> refExtraInfoDict; // 0x20
		public bool isRootRef; // 0x28
		public List<LuaReference> subReferences; // 0x30
		private LuaTable m_table; // 0x38
	
		// Nested types
		[Serializable]
		public class ComponentRefDict : SerializeReferenceDictionary<string, Component> // TypeDefIndex: 59687
		{
			// Constructors
			public ComponentRefDict() {} // 0x000000018AA50B88-0x000000018AA50E1C
		}
	
		[Serializable]
		public class RefExtraInfo // TypeDefIndex: 59689
		{
			// Fields
			public List<CustomUIStyleInfo> customUIStyles; // 0x10
	
			// Nested types
			[Serializable]
			public class CustomUIStyleInfo // TypeDefIndex: 59688
			{
				// Fields
				public CustomUIStyle style; // 0x10
				public Component component; // 0x18
	
				// Constructors
				public CustomUIStyleInfo() {} // 0x000000018454F4C0-0x000000018454F510
			}
	
			// Constructors
			public RefExtraInfo() {} // 0x000000018454E620-0x000000018454F3F0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 59690
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<LuaReference> __9__7_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018454C810-0x000000018454D3D0
			public __c() {} // 0x000000018454D3D0-0x000000018454E620
	
			// Methods
			internal bool _Reset_b__7_0(LuaReference item) => default; // 0x000000018AA506A4-0x000000018AA50B88
		}
	
		// Constructors
		public LuaReference() {} // 0x000000018AA51EA0-0x000000018AA51EEC
	
		// Methods
		private void Reset() {} // 0x0000000184560F80-0x0000000184561120
		private void OnDestroy() {} // 0x0000000184562850-0x00000001845628B0
		private void _UnBindFromXluaRef() {} // 0x0000000185905C80-0x0000000185905D00
		public void BindToLua(LuaTable table) {} // 0x0000000185492010-0x0000000185492020
		private void _BindSelfReferences(LuaTable table) {} // 0x000000018AA52244-0x000000018AA522A8
		public bool ContainsGameObject(GameObject obj, bool recursive = true /* Metadata: 0x0208102F */) => default; // 0x0000000185492010-0x0000000185492020
	}

	public struct LuaTestReflectionOptStruct // TypeDefIndex: 59692
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
		public int a1 { get => default; } // 0x00000001818226B0-0x00000001818226C0 
		public string b1 { get => default; } // 0x000000018357A260-0x000000018357A270 
		public long l1 { get => default; } // 0x000000018346D130-0x000000018346D140 
		public ulong ul1 { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public float f1 { get => default; } // 0x0000000181C9AC70-0x0000000181C9AC80 
		public double d1 { get => default; } // 0x0000000185FB0BC0-0x0000000185FB0BD0 
		public bool bl1 { get => default; } // 0x00000001814294C0-0x00000001814294D0 
	
		// Constructors
		public LuaTestReflectionOptStruct(int a, string b, long l, ulong ul, float f, double d, bool bl) : this() {
			this.a = default;
			this.b = default;
			this.l = default;
			this.ul = default;
			this.f = default;
			this.d = default;
			this.bl = default;
		} // 0x000000018AA51824-0x000000018AA5186C
	
		// Methods
		public int TestInt(int a) => default; // 0x000000018AA51604-0x000000018AA51658
		public void TestVoid() {} // 0x000000018AA517E4-0x000000018AA51824
		public void TestStructParam(LuaTestReflectionOptStruct testStruct) {} // 0x000000018AA5176C-0x000000018AA517E4
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct) {} // 0x000000018AA5171C-0x000000018AA5176C
		public object TestReturnObj() => default; // 0x000000018AA516A8-0x000000018AA5171C
		public void TestObjParam(object obj) {} // 0x000000018AA51658-0x000000018AA516A8
	}

	public struct LuaTestReflectionOptStruct2 // TypeDefIndex: 59693
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
		public int a1 { get => default; } // 0x00000001818226B0-0x00000001818226C0 
		public string b1 { get => default; } // 0x000000018357A260-0x000000018357A270 
		public long l1 { get => default; } // 0x000000018346D130-0x000000018346D140 
		public ulong ul1 { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public float f1 { get => default; } // 0x0000000181C9AC70-0x0000000181C9AC80 
		public double d1 { get => default; } // 0x0000000185FB0BC0-0x0000000185FB0BD0 
		public bool bl1 { get => default; } // 0x00000001814294C0-0x00000001814294D0 
	
		// Methods
		public int TestInt(int a) => default; // 0x000000018AA513E4-0x000000018AA51438
		public void TestVoid() {} // 0x000000018AA515C4-0x000000018AA51604
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct) {} // 0x000000018AA5154C-0x000000018AA515C4
		public void TestStructParam2(ref LuaTestReflectionOptStruct2 testStruct) {} // 0x000000018AA514FC-0x000000018AA5154C
		public object TestReturnObj() => default; // 0x000000018AA51488-0x000000018AA514FC
		public void TestObjParam(object obj) {} // 0x000000018AA51438-0x000000018AA51488
	}

	public enum ETestEnum // TypeDefIndex: 59694
	{
		Test1 = 2,
		Test2 = 2
	}

	public class LuaTestReflectionOpt2 // TypeDefIndex: 59695
	{
		// Fields
		public List<int> TestList; // 0x10
		public Dictionary<int, string> TestDict; // 0x18
	
		// Constructors
		public LuaTestReflectionOpt2() {} // 0x000000018AA51258-0x000000018AA513E4
	
		// Methods
		public void TestVoid() {} // 0x000000018AA51218-0x000000018AA51258
		public int TestInt(int a) => default; // 0x000000018AA50E6C-0x000000018AA50EC0
		public void TestStructParam(LuaTestReflectionOptStruct testStruct) {} // 0x000000018AA51098-0x000000018AA51110
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct) {} // 0x000000018AA51020-0x000000018AA51098
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct) {} // 0x000000018AA50FD0-0x000000018AA51020
		public object TestReturnObj() => default; // 0x000000018AA50F5C-0x000000018AA50FD0
		public void TestObjParam(object obj) {} // 0x000000018AA50EC0-0x000000018AA50F10
		public void TestEnum(ETestEnum e) {} // 0x000000018AA50E1C-0x000000018AA50E6C
		public ETestEnum TestReturnEnum() => default; // 0x000000018AA50F10-0x000000018AA50F5C
		public LuaTestReflectionOptStruct TestStruct(LuaTestReflectionOptStruct a) => default; // 0x000000018AA51110-0x000000018AA51218
	}

	public class LuaTestReflectionOpt // TypeDefIndex: 59696
	{
		// Fields
		public List<int> TestList; // 0x10
		public Dictionary<int, string> TestDict; // 0x18
	
		// Constructors
		public LuaTestReflectionOpt() {} // 0x000000018AA51CA8-0x000000018AA51E34
	
		// Methods
		public void TestVoid() {} // 0x000000018AA51C68-0x000000018AA51CA8
		public int TestInt(int a) => default; // 0x000000018AA518BC-0x000000018AA51910
		public void TestStructParam(LuaTestReflectionOptStruct testStruct) {} // 0x000000018AA51AE8-0x000000018AA51B60
		public void TestStructParam(LuaTestReflectionOptStruct2 testStruct) {} // 0x000000018AA51A70-0x000000018AA51AE8
		public void TestStructParam2(ref LuaTestReflectionOptStruct testStruct) {} // 0x000000018AA51A20-0x000000018AA51A70
		public object TestReturnObj() => default; // 0x000000018AA519AC-0x000000018AA51A20
		public void TestObjParam(object obj) {} // 0x000000018AA51910-0x000000018AA51960
		public void TestEnum(ETestEnum e) {} // 0x000000018AA5186C-0x000000018AA518BC
		public ETestEnum TestReturnEnum() => default; // 0x000000018AA51960-0x000000018AA519AC
		public LuaTestReflectionOptStruct TestStruct(LuaTestReflectionOptStruct a) => default; // 0x000000018AA51B60-0x000000018AA51C68
	}

	public class LuaUIWidget : MonoBehaviour, IUIClearable // TypeDefIndex: 59697
	{
		// Fields
		public string id; // 0x18
		public bool isEmbeddedWidget; // 0x20
		private LuaTable _table_k__BackingField; // 0x28
		public LuaFunction onEnable; // 0x30
		public LuaFunction onDisable; // 0x38
		public LuaFunction onDestroy; // 0x40
	
		// Properties
		public LuaTable table { get; set; } // 0x00000001813B8590-0x00000001813B85A0 0x00000001858474A0-0x00000001858474B0
	
		// Constructors
		public LuaUIWidget() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Reset() {} // 0x000000018AA51E34-0x000000018AA51EA0
		private void OnEnable() {} // 0x000000018439EDD0-0x000000018439EE40
		private void OnDisable() {} // 0x000000018439ED30-0x000000018439EDA0
		private void OnDestroy() {} // 0x00000001855D1DC0-0x00000001855D1E00
		public void ClearComponent() {} // 0x000000018454F5B0-0x000000018454F6D0
	}

	public static class UtilsForLua // TypeDefIndex: 59700
	{
		// Fields
		private static Vector3[] s_worldCorners; // 0x00
	
		// Nested types
		public class ImageContentParam // TypeDefIndex: 59698
		{
			// Fields
			public string path; // 0x10
	
			// Constructors
			public ImageContentParam() {} // 0x0000000185DB1350-0x0000000185DB13D0
		}
	
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 59699
		{
			// Fields
			public float from; // 0x10
			public LuaFunction setter; // 0x18
	
			// Constructors
			public __c__DisplayClass33_0() {} // 0x00000001845A8ED0-0x00000001845A8F60
	
			// Methods
			internal float _TweenTo_b__0() => default; // 0x00000001845A8E30-0x00000001845A8ED0
			internal void _TweenTo_b__1(float value) {} // 0x000000018AA539A0-0x000000018AA53B84
		}
	
		// Constructors
		static UtilsForLua() {} // 0x000000018AA52098-0x000000018AA5215C
	
		// Methods
		public static GameObject CreateObject(GameObject asset) => default; // 0x000000018AA5374C-0x000000018AA537B0
		public static GameObject CreateObject(GameObject asset, Transform parent) => default; // 0x000000018AA537B0-0x000000018AA53814
		public static GameObject CreateObject(GameObject asset, GameObject parent) => default; // 0x000000018AA535DC-0x000000018AA53640
		public static void UIContainerResize(Transform container, int size, int templateIndex = 0 /* Metadata: 0x02081032 */) {} // 0x000000018AA52F5C-0x000000018AA52FFC
		public static int TurnOffLayer(int value, string layerName) => default; // 0x000000018AA52FFC-0x000000018AA5309C
		public static int TurnOnLayer(int value, string layerName) => default; // 0x000000018AA5309C-0x000000018AA53130
		public static int ToggleLayer(int value, string layerName) => default; // 0x000000018AA53130-0x000000018AA531D0
		public static void SetPosX(Transform t, float value) {} // 0x000000018AA531D0-0x000000018AA53270
		public static void SetPosY(Transform t, float value) {} // 0x000000018AA53270-0x000000018AA53304
		public static void SetPosZ(Transform t, float value) {} // 0x000000018AA53304-0x000000018AA533A4
		public static void SetRotX(Transform t, float value) {} // 0x000000018AA533A4-0x000000018AA53444
		public static void SetRotY(Transform t, float value) {} // 0x000000018AA53444-0x000000018AA534D8
		public static void SetRotZ(Transform t, float value) {} // 0x00000001845D6EA0-0x00000001845D6F10
		public static void SetScaleX(Transform t, float value) {} // 0x000000018AA52C38-0x000000018AA52D34
		public static void SetScaleY(Transform t, float value) {} // 0x000000018AA52D34-0x000000018AA52E30
		public static void SetScaleZ(Transform t, float value) {} // 0x00000001848461E0-0x0000000184846380
		public static void ClearUIComponents(GameObject gameObject) {} // 0x000000018AA52E30-0x000000018AA52EE0
		public static bool RayCast(out RaycastHit hitInfo, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction interaction = QueryTriggerInteraction.UseGlobal /* Metadata: 0x02081033 */) {
			hitInfo = default;
			return default;
		} // 0x000000018AA52790-0x000000018AA528C4
		public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction interaction) => default; // 0x000000018AA522A8-0x000000018AA52360
		public static Bounds GetRectTransformBounds(RectTransform transform) => default; // 0x000000018AA52928-0x000000018AA529B8
		public static UnityEngine.Rect RectTransformToScreenRect(RectTransform rectTransform, Camera uiCamera) => default; // 0x000000018AA528C4-0x000000018AA52928
		public static Vector3 GetRectTransformCenterPosition(RectTransform rectTransform) => default; // 0x000000018AA52360-0x000000018AA5241C
		public static Bounds CalcBoundOfRectTransform(RectTransform transform, RectTransform local) => default; // 0x000000018AA529B8-0x000000018AA52A24
		public static List<string> GetStringList() => default; // 0x000000018AA5241C-0x000000018AA5249C
		public static int GetStringHash(string str) => default; // 0x000000018AA52670-0x000000018AA526F4
		public static float EntityDistance(Entity a, Entity b) => default; // 0x000000018AA534D8-0x000000018AA53568
		public static void OpenAccountCenter() {} // 0x000000018AA536B4-0x000000018AA5374C
		public static void ExitGame() {} // 0x000000018AA5249C-0x000000018AA52518
		public static string GetCurrentUID() => default; // 0x000000018AA53814-0x000000018AA539A0
		public static bool StartPayment(string productId, string signParams) => default; // 0x00000001852CECC0-0x00000001852CED30
		public static bool TryGetCharacterVolume(UnityEngine.Rendering.Volume volume, out HGCharacterVolume hgCharacterVolume) {
			hgCharacterVolume = default;
			return default;
		} // 0x000000018AA52A24-0x000000018AA52BE8
		public static float GetAnimationCurveLength(AnimationCurve curve) => default; // 0x000000018AA52EE0-0x000000018AA52F5C
		public static Tweener TweenTo(float from, float to, float duration, LuaFunction setter) => default; // 0x000000018AA52BE8-0x000000018AA52C38
		public static bool IsNull(UnityEngine.Object o) => default; // 0x000000018AA53568-0x000000018AA535DC
		public static ImageContentParam ParseImageContent(string xml) => default; // 0x000000018AA53640-0x000000018AA536B4
		public static void ReturnToLogin() {} // 0x000000018AA525C4-0x000000018AA52670
		public static void QuitGame(int exitCode) {} // 0x000000018AA52518-0x000000018AA525C4
		public static void ToggleCharInfoInUpgradePanelOption(bool isIn) {} // 0x000000018AA526F4-0x000000018AA52790
		public static void ToggleWeaponInUpgradePanelOption(bool isIn) {} // 0x0000000185FA3670-0x0000000185FA36E0
		public static CinemachineTransposer GetCinemachineTransposer(CinemachineVirtualCamera vcam) => default; // 0x0000000185492010-0x0000000185492020
		public static CinemachineComposer GetCinemachineComposer(CinemachineVirtualCamera vcam) => default; // 0x0000000185492010-0x0000000185492020
		public static CinemachineCameraOffset GetOrAddCinemachineCameraOffset(CinemachineVirtualCamera vcam) => default; // 0x0000000181DCCCE0-0x0000000181DCCCF0
	}
}

namespace Beyond.SourceGenerator
{
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 59660
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 59661
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 59662
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 59663
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 59664
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 59659
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59701
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F642B0-0x0000000185F64320
	
		// Methods
		public void __Gen_Wrap_0(object P0, object P1) {} // 0x00000001873527E8-0x00000001873528C4
		public bool __Gen_Wrap_1() => default; // 0x000000018735B3F8-0x000000018735B4A4
		public void __Gen_Wrap_2() {} // 0x0000000187678160-0x00000001876781FC
		public void __Gen_Wrap_3(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public Dictionary<string, LuaCustomConfig.Item> __Gen_Wrap_4(object P0) => default; // 0x000000018AA4B230-0x000000018AA4B30C
		public string __Gen_Wrap_5(object P0) => default; // 0x000000018AA4BBC0-0x000000018AA4BC9C
		public object __Gen_Wrap_6(object P0, object P1) => default; // 0x000000018AA4C370-0x000000018AA4C47C
		public void __Gen_Wrap_7(object P0, object P1, object P2, object P3) {} // 0x000000018734F774-0x000000018734F86C
		public LuaTable __Gen_Wrap_8(object P0, object P1, object P2) => default; // 0x000000018AA4C91C-0x000000018AA4CA44
		public bool __Gen_Wrap_9(object P0, object P1) => default; // 0x0000000187342174-0x0000000187342260
		public bool __Gen_Wrap_10(object P0, object P1, object P2) => default; // 0x000000018768937C-0x0000000187689470
		public void __Gen_Wrap_11(object P0, object P1, object P2) {} // 0x0000000187340E48-0x0000000187340F40
		public System.Type __Gen_Wrap_12(object P0) => default; // 0x000000018AA48D74-0x000000018AA48E64
		public object __Gen_Wrap_13(object P0) => default; // 0x000000018AA48E64-0x000000018AA48F54
		public bool __Gen_Wrap_14(object P0) => default; // 0x000000018735B960-0x000000018735BA30
		public bool __Gen_Wrap_15(Span<byte> P0, int P1) => default; // 0x000000018AA48F54-0x000000018AA49074
		public byte[] __Gen_Wrap_16(object P0, object P1) => default; // 0x000000018AA49074-0x000000018AA49180
		public void __Gen_Wrap_17(object P0, HGRenderPipeCallbackArgs P1) {} // 0x000000018AA49180-0x000000018AA49280
		public string __Gen_Wrap_18() => default; // 0x000000018AA49280-0x000000018AA49338
		public void __Gen_Wrap_19(IntPtr P0, int P1, object P2) {} // 0x000000018AA49338-0x000000018AA4941C
		public void __Gen_Wrap_20(int P0, object P1) {} // 0x000000018A849A0C-0x000000018A849AD4
		public byte[] __Gen_Wrap_21(object P0, ref string P1) => default; // 0x000000018AA4941C-0x000000018AA49554
		public void __Gen_Wrap_22(object P0, EnvLang P1) {} // 0x000000018A80A9F8-0x000000018A80AAC0
		public int __Gen_Wrap_23(IntPtr P0) => default; // 0x000000018AA49554-0x000000018AA49610
		public void __Gen_Wrap_24(IntPtr P0, int P1, out StringPathHash P2) {
			P2 = default;
		} // 0x000000018AA49610-0x000000018AA49748
		public bool __Gen_Wrap_25(IntPtr P0, int P1) => default; // 0x000000018AA49748-0x000000018AA49834
		public void __Gen_Wrap_26(object P0, bool P1) {} // 0x000000018AA49834-0x000000018AA498FC
		public void __Gen_Wrap_27(object P0, float P1) {} // 0x0000000187678884-0x0000000187678964
		public string __Gen_Wrap_28(object P0, object P1) => default; // 0x000000018AA498FC-0x000000018AA499F4
		public long __Gen_Wrap_29(object P0, object P1, out int P2) {
			P2 = default;
			return default;
		} // 0x000000018AA499F4-0x000000018AA49B0C
		public IntPtr __Gen_Wrap_30(object P0, object P1) => default; // 0x000000018A8145AC-0x000000018A814684
		public object[] __Gen_Wrap_31(object P0, object P1) => default; // 0x000000018AA49B0C-0x000000018AA49C04
		public IntPtr __Gen_Wrap_32(object P0) => default; // 0x000000018735B890-0x000000018735B960
		public bool __Gen_Wrap_33(LuaReference P0) => default; // 0x0000000187678D18-0x0000000187678DD4
		public bool __Gen_Wrap_34(object P0, object P1, bool P2) => default; // 0x000000018AA49C04-0x000000018AA49CF8
		public int __Gen_Wrap_35(ref LuaTestReflectionOptStruct P0, int P1) => default; // 0x000000018AA49CF8-0x000000018AA49E80
		public void __Gen_Wrap_36(ref LuaTestReflectionOptStruct P0) {} // 0x000000018AA49E80-0x000000018AA49FDC
		public void __Gen_Wrap_37(ref LuaTestReflectionOptStruct P0, LuaTestReflectionOptStruct P1) {} // 0x000000018AA49FDC-0x000000018AA4A184
		public void __Gen_Wrap_38(ref LuaTestReflectionOptStruct P0, ref LuaTestReflectionOptStruct P1) {} // 0x000000018AA4A184-0x000000018AA4A380
		public object __Gen_Wrap_39(ref LuaTestReflectionOptStruct P0) => default; // 0x000000018AA4A380-0x000000018AA4A500
		public void __Gen_Wrap_40(ref LuaTestReflectionOptStruct P0, object P1) {} // 0x000000018AA4A500-0x000000018AA4A678
		public int __Gen_Wrap_41(ref LuaTestReflectionOptStruct2 P0, int P1) => default; // 0x000000018AA4A678-0x000000018AA4A800
		public void __Gen_Wrap_42(ref LuaTestReflectionOptStruct2 P0) {} // 0x000000018AA4A800-0x000000018AA4A95C
		public void __Gen_Wrap_43(ref LuaTestReflectionOptStruct2 P0, LuaTestReflectionOptStruct2 P1) {} // 0x000000018AA4A95C-0x000000018AA4AB04
		public void __Gen_Wrap_44(ref LuaTestReflectionOptStruct2 P0, ref LuaTestReflectionOptStruct2 P1) {} // 0x000000018AA4AB04-0x000000018AA4AD00
		public object __Gen_Wrap_45(ref LuaTestReflectionOptStruct2 P0) => default; // 0x000000018AA4AD00-0x000000018AA4AE80
		public void __Gen_Wrap_46(ref LuaTestReflectionOptStruct2 P0, object P1) {} // 0x000000018AA4AE80-0x000000018AA4AFF8
		public int __Gen_Wrap_47(object P0, int P1) => default; // 0x000000018A803240-0x000000018A803318
		public void __Gen_Wrap_48(object P0, LuaTestReflectionOptStruct P1) {} // 0x000000018AA4AFF8-0x000000018AA4B114
		public void __Gen_Wrap_49(object P0, LuaTestReflectionOptStruct2 P1) {} // 0x000000018AA4B114-0x000000018AA4B230
		public void __Gen_Wrap_50(object P0, ref LuaTestReflectionOptStruct P1) {} // 0x000000018AA4B30C-0x000000018AA4B484
		public void __Gen_Wrap_51(object P0, ETestEnum P1) {} // 0x000000018A80A9F8-0x000000018A80AAC0
		public ETestEnum __Gen_Wrap_52(object P0) => default; // 0x000000018767917C-0x0000000187679238
		public LuaTestReflectionOptStruct __Gen_Wrap_53(object P0, LuaTestReflectionOptStruct P1) => default; // 0x000000018AA4B484-0x000000018AA4B5F0
		public GameObject __Gen_Wrap_54(object P0) => default; // 0x000000018AA4B5F0-0x000000018AA4B6E0
		public GameObject __Gen_Wrap_55(object P0, object P1) => default; // 0x000000018AA4B6E0-0x000000018AA4B7EC
		public void __Gen_Wrap_56(object P0, int P1, int P2) {} // 0x000000018A8169B4-0x000000018A816A98
		public int __Gen_Wrap_57(int P0, object P1) => default; // 0x000000018AA4B7EC-0x000000018AA4B8C4
		public bool __Gen_Wrap_58(out RaycastHit P0, Ray P1, float P2, int P3, QueryTriggerInteraction P4) {
			P0 = default;
			return default;
		} // 0x000000018AA4B8C4-0x000000018AA4BA6C
		public int __Gen_Wrap_59(Ray P0, object P1, float P2, int P3, QueryTriggerInteraction P4) => default; // 0x000000018AA4BA6C-0x000000018AA4BBC0
		public Bounds __Gen_Wrap_60(object P0) => default; // 0x000000018AA4BC9C-0x000000018AA4BDA0
		public UnityEngine.Rect __Gen_Wrap_61(object P0, object P1) => default; // 0x000000018AA4BDA0-0x000000018AA4BEB8
		public Vector3 __Gen_Wrap_62(object P0) => default; // 0x000000018AA4BEB8-0x000000018AA4BFB8
		public Bounds __Gen_Wrap_63(object P0, object P1) => default; // 0x000000018AA4BFB8-0x000000018AA4C0D8
		public List<string> __Gen_Wrap_64() => default; // 0x000000018AA4C0D8-0x000000018AA4C190
		public int __Gen_Wrap_65(object P0) => default; // 0x000000018767917C-0x0000000187679238
		public float __Gen_Wrap_66(object P0, object P1) => default; // 0x000000018A81D3F0-0x000000018A81D4C8
		public bool __Gen_Wrap_67(object P0, out HGCharacterVolume P1) {
			P1 = default;
			return default;
		} // 0x000000018AA4C190-0x000000018AA4C2B4
		public float __Gen_Wrap_68(object P0) => default; // 0x000000018AA4C2B4-0x000000018AA4C370
		public float __Gen_Wrap_69() => default; // 0x000000018735B7F8-0x000000018735B890
		public void __Gen_Wrap_70(float P0) {} // 0x00000001876927D8-0x0000000187692884
		public Tweener __Gen_Wrap_71(float P0, float P1, float P2, object P3) => default; // 0x000000018AA4C47C-0x000000018AA4C5AC
		public UtilsForLua.ImageContentParam __Gen_Wrap_72(object P0) => default; // 0x000000018AA4C5AC-0x000000018AA4C688
		public void __Gen_Wrap_73(int P0) {} // 0x00000001872E71D4-0x00000001872E7280
		public void __Gen_Wrap_74(bool P0) {} // 0x000000018769263C-0x00000001876926E8
		public CinemachineTransposer __Gen_Wrap_75(object P0) => default; // 0x000000018AA4C688-0x000000018AA4C764
		public CinemachineComposer __Gen_Wrap_76(object P0) => default; // 0x000000018AA4C764-0x000000018AA4C840
		public CinemachineCameraOffset __Gen_Wrap_77(object P0) => default; // 0x000000018AA4C840-0x000000018AA4C91C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 59702
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018AA4CA44-0x000000018AA4CAD8
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 59703
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018AA53D6C-0x000000018AA53DD0
		public static bool IsPatched(int id) => default; // 0x000000018455A520-0x000000018455A590
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018AA53C28-0x000000018AA53CF4
		public object CreateWrapper(int id) => default; // 0x000000018AA53CF4-0x000000018AA53D6C
		public object InitWrapperArray(int len) => default; // 0x000000018AA53DD0-0x000000018AA53E5C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018AA53B84-0x000000018AA53C28
	}

	public enum IDMAP0 // TypeDefIndex: 59704
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
