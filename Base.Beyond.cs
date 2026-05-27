/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using Cysharp.Text;
using IFix.Core;
using Unity.Burst;
using UnityEngine;

// Image 97: Base.Beyond.dll - Assembly: Base.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59490-59509
[assembly: BurstCompiler.StaticTypeReinit(typeof(Beyond.StringUtils._EqualsIgnoreCase_0000002C_BurstDirectCall))]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

internal static class _BurstDirectCallInitializer // TypeDefIndex: 59505
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize() {} // 0x0000000183D46490-0x0000000183D464D0
}

namespace Beyond
{
	public static class CollectionUtils // TypeDefIndex: 59495
	{
		// Extension methods
		public static void AddRange<T>(this HashSet<T> hashSet, IEnumerable<T> range) {}
		public static HashSet<T> DeepClone<T>(this HashSet<T> hashSet) => default;
	}

	public class DebugAssert // TypeDefIndex: 59496
	{
		// Fields
		private const string NODE_NAME = "BEYOND_DEBUG_COMMAND"; // Metadata: 0x01FDD129
	
		// Constructors
		public DebugAssert() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsTrue(bool condition) {} // 0x000000018350B670-0x000000018350B680
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsTrue(bool condition, string message) {} // 0x000000018350B670-0x000000018350B680
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsFalse(bool condition) {} // 0x000000018350B670-0x000000018350B680
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsFalse(bool condition, string message) {} // 0x000000018350B670-0x000000018350B680
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsNotNull<T>(T value)
			where T : class {}
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsNull<T>(T value)
			where T : class {}
	}

	public static class EnumUtils // TypeDefIndex: 59497
	{
		// Fields
		private static readonly Dictionary<System.Type, int> _enumCountCache; // 0x00
	
		// Constructors
		static EnumUtils() {} // 0x0000000185153338-0x00000001851533C4
	
		// Methods
		public static int GetEnumCount<T>()
			where T : Enum => default;
		public static TEnum FromIntNoGC<TEnum>(int value)
			where TEnum : struct, Enum => default;
		public static TEnum IntToEnumNoGC<TEnum>(int value)
			where TEnum : struct, Enum => default;
	}

	public class StaticFastLookupCollection<TKey, TValue> // TypeDefIndex: 59498
	{
		// Fields
		private readonly Dictionary<TKey, TValue> m_dict;
		private readonly List<TValue> m_list;
	
		// Properties
		public IReadOnlyList<TValue> items { get => default; }
	
		// Constructors
		public StaticFastLookupCollection() {}
	
		// Methods
		public bool TryAdd(TKey key, TValue value) => default;
		public bool TryGetValue(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		public bool ContainsKey(TKey key) => default;
		public void Clear() {}
	}

	public class DynamicFastLookupCollection<TKey, TValue> // TypeDefIndex: 59499
	{
		// Fields
		private Dictionary<TKey, TValue> m_dict;
		private List<ValueTuple<TKey, TValue>> m_list;
		private readonly IEqualityComparer<TKey> m_keyComparer;
	
		// Properties
		public IReadOnlyList<ValueTuple<TKey, TValue>> items { get => default; }
	
		// Constructors
		public DynamicFastLookupCollection() {}
	
		// Methods
		public bool TryAdd(TKey key, TValue value) => default;
		public void Add(TKey key, TValue value) {}
		public int Count() => default;
		public bool TryGetValue(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		public bool ContainsKey(TKey key) => default;
		public bool Remove(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		public bool Remove(TKey key) => default;
		public void Clear() {}
	}

	[BurstCompile]
	public static class StringUtils // TypeDefIndex: 59502
	{
		// Nested types
		public unsafe delegate bool _EqualsIgnoreCase_0000002C_PostfixBurstDelegate(short* str1, short* str2, int len); // TypeDefIndex: 59500; 0x0000000181035ED0-0x0000000181035EF0
	
		internal static class _EqualsIgnoreCase_0000002C_BurstDirectCall // TypeDefIndex: 59501
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _EqualsIgnoreCase_0000002C_BurstDirectCall() {} // 0x0000000183CE7FF0-0x0000000183CE8000
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0007d564) {} // 0x0000000182B6D3A0-0x0000000182B6D4F0
			private static IntPtr GetFunctionPointer() => default; // 0x0000000182B6D340-0x0000000182B6D3A0
			public static void Constructor() {} // 0x0000000183CE8000-0x0000000183CE8090
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe bool Invoke(short* str1, short* str2, int len) => default; // 0x0000000182B6D290-0x0000000182B6D340
		}
	
		// Methods
		[BurstCompile]
		private static unsafe bool _EqualsIgnoreCase(short* str1, short* str2, int len) => default; // 0x0000000182B6D220-0x0000000182B6D290
		public static Utf16ValueStringBuilder CreateZStringBuilder() => default; // 0x00000001825E0850-0x00000001825E08D0
		public static string ZConcat<T1, T2>(T1 arg1, T2 arg2) => default;
		public static string ZConcat<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3) => default;
		public static string ZConcat<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4) => default;
		public static string ZConcat<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => default;
		public static string ZConcat<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => default;
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => default;
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => default;
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => default;
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => default;
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => default;
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => default;
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => default;
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => default;
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => default;
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) => default;
		public static string ZFormat<T1>(string format, T1 arg1) => default;
		public static string ZFormat<T1, T2>(string format, T1 arg1, T2 arg2) => default;
		public static string ZFormat<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) => default;
		public static string ZFormat<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => default;
		public static string ZFormat<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => default;
		public static string ZFormat<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => default;
		public static string ZJoin<T>(char separator, params T[] values) => default;
		public static string ZJoin<T>(char separator, List<T> values) => default;
		public static string ZJoin<T>(char separator, IEnumerable<T> values) => default;
		public static string ZJoin<T>(char separator, ICollection<T> values) => default;
		public static string ZJoin<T>(char separator, IList<T> values) => default;
		public static string ZJoin<T>(char separator, IReadOnlyList<T> values) => default;
		public static string ZJoin<T>(char separator, IReadOnlyCollection<T> values) => default;
		public static string ZJoin<T>(string separator, List<T> values) => default;
		public static string ZJoin<T>(string separator, IEnumerable<T> values) => default;
		public static string ZJoin<T>(string separator, ICollection<T> values) => default;
		public static string ZJoin<T>(string separator, IList<T> values) => default;
		public static string ZJoin<T>(string separator, IReadOnlyList<T> values) => default;
		public static string ZJoin<T>(string separator, IReadOnlyCollection<T> values) => default;
		[BurstCompile]
		public static unsafe bool _EqualsIgnoreCase_BurstManaged(short* str1, short* str2, int len) => default; // 0x00000001851532D8-0x0000000185153338
	
		// Extension methods
		public static string LowerFirst(this string str, bool includeAllStartUppers = false /* Metadata: 0x01FDD13E */) => default; // 0x000000018515448C-0x0000000185154688
		[IDTag(0)]
		public static string TrimStartLength(this string str, string lengthString) => default; // 0x0000000185154778-0x00000001851547FC
		[IDTag(1)]
		public static string TrimStartLength(this string str, int length) => default; // 0x0000000185154700-0x0000000185154778
		[IDTag(0)]
		public static string TrimEndLength(this string str, string lengthString) => default; // 0x0000000182D7EA50-0x0000000182D7EAC0
		[IDTag(1)]
		public static string TrimEndLength(this string str, int length) => default; // 0x0000000185154688-0x0000000185154700
		public static string Trim(this string str, string startLengthString, string endLengthString) => default; // 0x00000001851547FC-0x00000001851548B0
		public static bool EqualsIgnoreCase(this string strA, string strB) => default; // 0x0000000182B6D120-0x0000000182B6D220
		public static string SafeValue(this string str) => default; // 0x0000000182B6AD50-0x0000000182B6ADA0
	}
}

namespace Beyond.Base
{
	public interface IDisposeEnumerator // TypeDefIndex: 59504
	{
		// Methods
		void Dispose();
	}
}

namespace Beyond.Security
{
	public class IOOO000iiI // TypeDefIndex: 59503
	{
		// Fields
		public const string FONT_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Fonts/"; // Metadata: 0x01FDD13F
	
		// Constructors
		public IOOO000iiI() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static string Encrypt(string text, string key = null) => default; // 0x00000001851540D0-0x000000018515414C
		public static string IOoOIiII(string encryptText, string key = null) => default; // 0x000000018515414C-0x00000001851541D0
		public static string EncryptBytes(byte[] bytes, string key = null) => default; // 0x000000018515401C-0x00000001851540D0
		private static byte[] _IooiIIO(string encryptText, string key = null) => default; // 0x00000001851543DC-0x000000018515448C
		public static int IooiIIO(string encryptText, Span<byte> result, string key = null) => default; // 0x00000001825D8270-0x00000001825D8950
		private static byte[] _Encrypt(byte[] data, string key) => default; // 0x00000001851541D0-0x00000001851542CC
		[IDTag(1)]
		private static void _IIiiIIIoO(ReadOnlySpan<byte> data, string key, Span<byte> result) {} // 0x00000001823A8880-0x00000001823A8D40
		[IDTag(0)]
		private static byte[] _IIiiIIIoO(byte[] data, string key) => default; // 0x00000001851542CC-0x00000001851543DC
		public static void FromBase64String(string text, Span<byte> buffer, out int count) {
			count = default;
		} // 0x00000001825D8950-0x00000001825D8AF0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59506
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05DB0-0x0000000183D05E20
	
		// Methods
		public string __Gen_Wrap_0(object P0, bool P1) => default; // 0x00000001851533C4-0x00000001851534BC
		public string __Gen_Wrap_1(object P0, object P1) => default; // 0x0000000185153608-0x0000000185153714
		public string __Gen_Wrap_2(object P0, int P1) => default; // 0x0000000185153714-0x000000018515380C
		public string __Gen_Wrap_3(object P0, object P1, object P2) => default; // 0x000000018515380C-0x0000000185153920
		public bool __Gen_Wrap_4(object P0, object P1) => default; // 0x0000000185153920-0x0000000185153A0C
		public string __Gen_Wrap_5(object P0) => default; // 0x0000000185153A0C-0x0000000185153AFC
		public Utf16ValueStringBuilder __Gen_Wrap_6() => default; // 0x0000000185153AFC-0x0000000185153BEC
		public byte[] __Gen_Wrap_7(object P0, object P1) => default; // 0x0000000185153BEC-0x0000000185153CF8
		public int __Gen_Wrap_8(object P0, Span<byte> P1, object P2) => default; // 0x0000000185153CF8-0x0000000185153E34
		public void __Gen_Wrap_9(ReadOnlySpan<byte> P0, object P1, Span<byte> P2) {} // 0x0000000185153E34-0x0000000185153F88
		public void __Gen_Wrap_10(object P0, Span<byte> P1, out int P2) {
			P2 = default;
		} // 0x00000001851534BC-0x0000000185153608
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 59507
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000185153F88-0x000000018515401C
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 59508
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000185154A98-0x0000000185154AFC
		public static bool IsPatched(int id) => default; // 0x00000001825D91D0-0x00000001825D9240
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000185154954-0x0000000185154A20
		public object CreateWrapper(int id) => default; // 0x0000000185154A20-0x0000000185154A98
		public object InitWrapperArray(int len) => default; // 0x0000000185154AFC-0x0000000185154B88
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001851548B0-0x0000000185154954
	}

	public enum IDMAP0 // TypeDefIndex: 59509
	{
		Beyond-StringUtils-LowerFirst0 = 0,
		Beyond-StringUtils-TrimStartLength0 = 1,
		Beyond-StringUtils-TrimStartLength1 = 2,
		Beyond-StringUtils-TrimEndLength0 = 3,
		Beyond-StringUtils-TrimEndLength1 = 4,
		Beyond-StringUtils-Trim0 = 5,
		Beyond-StringUtils-EqualsIgnoreCase0 = 6,
		Beyond-StringUtils-SafeValue0 = 7,
		Beyond-StringUtils-CreateZStringBuilder0 = 8,
		Beyond-Security-IOOO000iiI-Encrypt0 = 9,
		Beyond-Security-IOOO000iiI-EncryptBytes0 = 10,
		Beyond-Security-IOOO000iiI-_Encrypt0 = 11,
		Beyond-Security-IOOO000iiI-IOoOIiII0 = 12,
		Beyond-Security-IOOO000iiI-_IooiIIO0 = 13,
		Beyond-Security-IOOO000iiI-_IIiiIIIoO0 = 14,
		Beyond-Security-IOOO000iiI-IooiIIO0 = 15,
		Beyond-Security-IOOO000iiI-_IIiiIIIoO1 = 16,
		Beyond-Security-IOOO000iiI-FromBase64String0 = 17
	}
}

namespace Unity.IL2CPP.CompilerServices
{
	public enum Option // TypeDefIndex: 59493
	{
		NullChecks = 1,
		ArrayBoundsChecks = 2,
		DivideByZeroChecks = 3
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate, Inherited = false, AllowMultiple = true)]
	public class Il2CppSetOptionAttribute : Attribute // TypeDefIndex: 59494
	{
		// Properties
		public Option Option { get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public object Value { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public Il2CppSetOptionAttribute() {} // Dummy constructor
		public Il2CppSetOptionAttribute(Option option, object value) {} // 0x0000000183A92330-0x0000000183A92340
	}
}
