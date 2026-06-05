/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using Cysharp.Text;
using IFix.Core;

// Image 100: Base.Beyond.dll - Assembly: Base.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60594-60613

internal static class _BurstDirectCallInitializer // TypeDefIndex: 60609
{
	// Methods
	private static void Initialize() {} // 0x0000000185FA6940-0x0000000185FA6980
}

namespace Beyond
{
	public static class CollectionUtils // TypeDefIndex: 60599
	{
		// Methods
		public static void AddRange<T>(HashSet<T> hashSet, IEnumerable<T> range) {}
		public static HashSet<T> DeepClone<T>(HashSet<T> hashSet) => default;
	}

	public class DebugAssert // TypeDefIndex: 60600
	{
		// Fields
		private const string NODE_NAME = "BEYOND_DEBUG_COMMAND"; // Metadata: 0x02082A15
	
		// Constructors
		public DebugAssert() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void IsTrue(bool condition) {} // 0x0000000185492010-0x0000000185492020
		public static void IsTrue(bool condition, string message) {} // 0x0000000185492010-0x0000000185492020
		public static void IsFalse(bool condition) {} // 0x0000000185492010-0x0000000185492020
		public static void IsFalse(bool condition, string message) {} // 0x0000000185492010-0x0000000185492020
		public static void IsNotNull<T>(T value)
			where T : class {}
		public static void IsNull<T>(T value)
			where T : class {}
	}

	public static class EnumUtils // TypeDefIndex: 60601
	{
		// Fields
		private static readonly Dictionary<System.Type, int> _enumCountCache; // 0x00
	
		// Constructors
		static EnumUtils() {} // 0x0000000187341B8C-0x0000000187341C18
	
		// Methods
		public static int GetEnumCount<T>()
			where T : Enum => default;
		public static TEnum FromIntNoGC<TEnum>(int value)
			where TEnum : struct, Enum => default;
		public static TEnum IntToEnumNoGC<TEnum>(int value)
			where TEnum : struct, Enum => default;
	}

	public class StaticFastLookupCollection<TKey, TValue> // TypeDefIndex: 60602
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

	public class DynamicFastLookupCollection<TKey, TValue> // TypeDefIndex: 60603
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

	public static class StringUtils // TypeDefIndex: 60606
	{
		// Nested types
		public unsafe delegate bool _EqualsIgnoreCase_0000002C_PostfixBurstDelegate(short* str1, short* str2, int len); // TypeDefIndex: 60604; 0x0000000187342FCC-0x0000000187343050
	
		internal static class _EqualsIgnoreCase_0000002C_BurstDirectCall // TypeDefIndex: 60605
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _EqualsIgnoreCase_0000002C_BurstDirectCall() {} // 0x000000018499E610-0x000000018499E660
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_0007f53d) {} // 0x0000000187342EDC-0x0000000187342F54
			private static IntPtr GetFunctionPointer() => default; // 0x0000000187343050-0x0000000187343104
			public static void Constructor() {} // 0x00000001849A0D20-0x00000001849A0E20
			public static void Initialize() {} // 0x00000001849A0E20-0x00000001849A0E90
			public static unsafe bool Invoke(short* str1, short* str2, int len) => default; // 0x000000018439A590-0x000000018439A610
		}
	
		// Methods
		public static string LowerFirst(string str, bool includeAllStartUppers = false /* Metadata: 0x02082A2A */) => default;
		public static string TrimStartLength(string str, string lengthString) => default;
		public static string TrimStartLength(string str, int length) => default;
		public static string TrimEndLength(string str, string lengthString) => default;
		public static string TrimEndLength(string str, int length) => default;
		public static string Trim(string str, string startLengthString, string endLengthString) => default;
		public static bool EqualsIgnoreCase(string strA, string strB) => default;
		private static unsafe bool _EqualsIgnoreCase(short* str1, short* str2, int len) => default;
		public static string SafeValue(string str) => default;
		public static Utf16ValueStringBuilder CreateZStringBuilder() => default;
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
		public static string ZJoin<T>(char separator, T[] values) => default;
		public static string ZJoin<T>(char separator, List<T> values) => default;
		public static string ZJoin<T>(char separator, IEnumerable<T> values) => default;
		public static string ZJoin<T>(char separator, ICollection<T> values) => default; // 0x0000000187341B2C-0x0000000187341B8C
		public static string ZJoin<T>(char separator, IList<T> values) => default; // 0x0000000187343464-0x0000000187343538
		public static string ZJoin<T>(char separator, IReadOnlyList<T> values) => default; // 0x00000001817E31E0-0x00000001817E3200
		public static string ZJoin<T>(char separator, IReadOnlyCollection<T> values) => default; // 0x00000001873433DC-0x0000000187343464
		public static string ZJoin<T>(string separator, List<T> values) => default; // 0x00000001864BBBD0-0x00000001864BBD00
		public static string ZJoin<T>(string separator, IEnumerable<T> values) => default; // 0x00000001849A0FA0-0x00000001849A10F0
		public static string ZJoin<T>(string separator, ICollection<T> values) => default; // 0x00000001849A0F40-0x00000001849A0FA0
		public static string ZJoin<T>(string separator, IList<T> values) => default; // 0x0000000185F43AC0-0x0000000185F43B50
		public static string ZJoin<T>(string separator, IReadOnlyList<T> values) => default; // 0x0000000185492010-0x0000000185492020
		public static string ZJoin<T>(string separator, IReadOnlyCollection<T> values) => default; // 0x0000000185F43AB0-0x0000000185F43AC0
		public static unsafe bool _EqualsIgnoreCase_BurstManaged(short* str1, short* str2, int len) => default; // 0x00000001849A0E90-0x00000001849A0F40
	}
}

namespace Beyond.Base
{
	public interface IDisposeEnumerator // TypeDefIndex: 60608
	{
		// Methods
		void Dispose();
	}
}

namespace Beyond.Security
{
	public class IOOO000iiI // TypeDefIndex: 60607
	{
		// Fields
		public const string FONT_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Fonts/"; // Metadata: 0x02082A2B
	
		// Constructors
		public IOOO000iiI() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static string Encrypt(string text, string key = null) => default; // 0x0000000187342924-0x00000001873429A0
		public static string IOoOIiII(string encryptText, string key = null) => default; // 0x00000001873429A0-0x0000000187342A24
		public static string EncryptBytes(byte[] bytes, string key = null) => default; // 0x0000000187342870-0x0000000187342924
		private static byte[] _IooiIIO(string encryptText, string key = null) => default; // 0x0000000187342C30-0x0000000187342CE0
		public static int IooiIIO(string encryptText, Span<byte> result, string key = null) => default; // 0x0000000184669C20-0x000000018466A300
		private static byte[] _Encrypt(byte[] data, string key) => default; // 0x0000000187342A24-0x0000000187342B20
		private static void _IIiiIIIoO(ReadOnlySpan<byte> data, string key, Span<byte> result) {} // 0x0000000184056660-0x0000000184056B20
		private static byte[] _IIiiIIIoO(byte[] data, string key) => default; // 0x0000000187342B20-0x0000000187342C30
		public static void FromBase64String(string text, Span<byte> buffer, out int count) {
			count = default;
		} // 0x000000018466A300-0x000000018466A4A0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60610
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F646A0-0x0000000185F64710
	
		// Methods
		public string __Gen_Wrap_0(object P0, bool P1) => default; // 0x0000000187341C18-0x0000000187341D10
		public string __Gen_Wrap_1(object P0, object P1) => default; // 0x0000000187341E5C-0x0000000187341F68
		public string __Gen_Wrap_2(object P0, int P1) => default; // 0x0000000187341F68-0x0000000187342060
		public string __Gen_Wrap_3(object P0, object P1, object P2) => default; // 0x0000000187342060-0x0000000187342174
		public bool __Gen_Wrap_4(object P0, object P1) => default; // 0x0000000187342174-0x0000000187342260
		public string __Gen_Wrap_5(object P0) => default; // 0x0000000187342260-0x0000000187342350
		public Utf16ValueStringBuilder __Gen_Wrap_6() => default; // 0x0000000187342350-0x0000000187342440
		public byte[] __Gen_Wrap_7(object P0, object P1) => default; // 0x0000000187342440-0x000000018734254C
		public int __Gen_Wrap_8(object P0, Span<byte> P1, object P2) => default; // 0x000000018734254C-0x0000000187342688
		public void __Gen_Wrap_9(ReadOnlySpan<byte> P0, object P1, Span<byte> P2) {} // 0x0000000187342688-0x00000001873427DC
		public void __Gen_Wrap_10(object P0, Span<byte> P1, out int P2) {
			P2 = default;
		} // 0x0000000187341D10-0x0000000187341E5C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60611
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001873427DC-0x0000000187342870
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60612
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001873432EC-0x0000000187343350
		public static bool IsPatched(int id) => default; // 0x000000018466AB80-0x000000018466ABF0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001873431A8-0x0000000187343274
		public object CreateWrapper(int id) => default; // 0x0000000187343274-0x00000001873432EC
		public object InitWrapperArray(int len) => default; // 0x0000000187343350-0x00000001873433DC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000187343104-0x00000001873431A8
	}

	public enum IDMAP0 // TypeDefIndex: 60613
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

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60595
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 60596
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.IL2CPP.CompilerServices
{
	public enum Option // TypeDefIndex: 60597
	{
		NullChecks = 1,
		ArrayBoundsChecks = 2,
		DivideByZeroChecks = 3
	}

	public class Il2CppSetOptionAttribute : Attribute // TypeDefIndex: 60598
	{
		// Fields
		private Option _Option_k__BackingField; // 0x10
		private object _Value_k__BackingField; // 0x18
	
		// Properties
		public Option Option { get; private set; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public object Value { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public Il2CppSetOptionAttribute() {} // Dummy constructor
		public Il2CppSetOptionAttribute(Option option, object value) {} // 0x0000000185CA5540-0x0000000185CA5550
	}
}
