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
using Microsoft.CodeAnalysis;
using Unity.Burst;
using UnityEngine;

// Image 102: Base.Beyond.dll - Assembly: Base.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63229-63248
[assembly: BurstCompiler.StaticTypeReinit(typeof(Beyond.StringUtils._EqualsIgnoreCase_0000002C_BurstDirectCall))]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

internal static class _BurstDirectCallInitializer // TypeDefIndex: 63244
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize(); // 0x0000000184D84E70-0x0000000184D84E90
}

namespace Beyond
{
	public static class CollectionUtils // TypeDefIndex: 63234
	{
		// Extension methods
		public static void AddRange<T>(this HashSet<T> hashSet, IEnumerable<T> range);
		public static HashSet<T> DeepClone<T>(this HashSet<T> hashSet);
	}

	public class DebugAssert // TypeDefIndex: 63235
	{
		// Fields
		private const string NODE_NAME = "BEYOND_DEBUG_COMMAND"; // Metadata: 0x023526F9
	
		// Constructors
		public DebugAssert(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsTrue(bool condition); // 0x00000001841E1670-0x00000001841E1680
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsTrue(bool condition, string message); // 0x00000001841E1670-0x00000001841E1680
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsFalse(bool condition); // 0x00000001841E1670-0x00000001841E1680
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsFalse(bool condition, string message); // 0x00000001841E1670-0x00000001841E1680
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsNotNull<T>(T value)
			where T : class;
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsNull<T>(T value)
			where T : class;
	}

	public static class EnumUtils // TypeDefIndex: 63236
	{
		// Fields
		private static readonly Dictionary<System.Type, int> _enumCountCache; // 0x00
	
		// Constructors
		static EnumUtils(); // 0x0000000186366450-0x00000001863664A8
	
		// Methods
		public static int GetEnumCount<T>()
			where T : Enum;
		public static TEnum FromIntNoGC<TEnum>(int value)
			where TEnum : struct, Enum;
		public static TEnum IntToEnumNoGC<TEnum>(int value)
			where TEnum : struct, Enum;
	}

	public class StaticFastLookupCollection<TKey, TValue> // TypeDefIndex: 63237
	{
		// Fields
		private readonly Dictionary<TKey, TValue> m_dict;
		private readonly List<TValue> m_list;
	
		// Properties
		public IReadOnlyList<TValue> items { get; }
	
		// Constructors
		public StaticFastLookupCollection();
	
		// Methods
		public bool TryAdd(TKey key, TValue value);
		public bool TryGetValue(TKey key, out ref TValue value);
		public bool ContainsKey(TKey key);
		public void Clear();
	}

	public class DynamicFastLookupCollection<TKey, TValue> // TypeDefIndex: 63238
	{
		// Fields
		private Dictionary<TKey, TValue> m_dict;
		private List<ValueTuple<TKey, TValue>> m_list;
		private readonly IEqualityComparer<TKey> m_keyComparer;
	
		// Properties
		public IReadOnlyList<ValueTuple<TKey, TValue>> items { get; }
	
		// Constructors
		public DynamicFastLookupCollection();
	
		// Methods
		public bool TryAdd(TKey key, TValue value);
		public void Add(TKey key, TValue value);
		public int Count();
		public bool TryGetValue(TKey key, out ref TValue value);
		public bool ContainsKey(TKey key);
		public bool Remove(TKey key, out ref TValue value);
		public bool Remove(TKey key);
		public void Clear();
	}

	[BurstCompile]
	public static class StringUtils // TypeDefIndex: 63241
	{
		// Nested types
		public unsafe delegate bool _EqualsIgnoreCase_0000002C_PostfixBurstDelegate(short* str1, short* str2, int len); // TypeDefIndex: 63239; 0x00000001814F3120-0x00000001814F3140
	
		internal static class _EqualsIgnoreCase_0000002C_BurstDirectCall // TypeDefIndex: 63240
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _EqualsIgnoreCase_0000002C_BurstDirectCall(); // 0x0000000183FAEB20-0x0000000183FAEB30
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00086ddb); // 0x000000018307BA90-0x000000018307BBA0
			private static IntPtr GetFunctionPointer(); // 0x000000018307B390-0x000000018307B4B0
			public static void Constructor(); // 0x0000000183FAEBF0-0x0000000183FAEC50
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe bool Invoke(short* str1, short* str2, int len); // 0x000000018307B310-0x000000018307B390
		}
	
		// Methods
		[BurstCompile]
		private static unsafe bool _EqualsIgnoreCase(short* str1, short* str2, int len); // 0x000000018307B270-0x000000018307B310
		public static int HexToInt(char hex); // 0x000000018636753C-0x00000001863676BC
		public static int StringHexToInt(string s); // 0x0000000186367884-0x0000000186367938
		public static Utf16ValueStringBuilder CreateZStringBuilder(); // 0x0000000182F271D0-0x0000000182F27370
		public static string ZConcat<T1, T2>(T1 arg1, T2 arg2);
		public static string ZConcat<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);
		public static string ZConcat<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public static string ZConcat<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		public static string ZConcat<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
		public static string ZConcat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);
		public static string ZFormat<T1>(string format, T1 arg1);
		public static string ZFormat<T1, T2>(string format, T1 arg1, T2 arg2);
		public static string ZFormat<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3);
		public static string ZFormat<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public static string ZFormat<T1, T2, T3, T4, T5>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		public static string ZFormat<T1, T2, T3, T4, T5, T6>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
		public static string ZFormat<T1, T2, T3, T4, T5, T6, T7>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
		public static string ZFormat<T1, T2, T3, T4, T5, T6, T7, T8>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
		public static string ZJoin<T>(char separator, params T[] values);
		public static string ZJoin<T>(char separator, List<T> values);
		public static string ZJoin<T>(char separator, IEnumerable<T> values);
		public static string ZJoin<T>(char separator, ICollection<T> values);
		public static string ZJoin<T>(char separator, IList<T> values);
		public static string ZJoin<T>(char separator, IReadOnlyList<T> values);
		public static string ZJoin<T>(char separator, IReadOnlyCollection<T> values);
		public static string ZJoin<T>(string separator, List<T> values);
		public static string ZJoin<T>(string separator, IEnumerable<T> values);
		public static string ZJoin<T>(string separator, ICollection<T> values);
		public static string ZJoin<T>(string separator, IList<T> values);
		public static string ZJoin<T>(string separator, IReadOnlyList<T> values);
		public static string ZJoin<T>(string separator, IReadOnlyCollection<T> values);
		[BurstCompile]
		public static unsafe bool _EqualsIgnoreCase_BurstManaged(short* str1, short* str2, int len); // 0x00000001863663F0-0x0000000186366450
	
		// Extension methods
		public static string LowerFirst(this string str, bool includeAllStartUppers = false /* Metadata: 0x0235270E */); // 0x00000001863676BC-0x0000000186367884
		[IDTag(0)]
		public static string TrimStartLength(this string str, string lengthString); // 0x0000000186367A28-0x0000000186367AAC
		[IDTag(1)]
		public static string TrimStartLength(this string str, int length); // 0x00000001863679B0-0x0000000186367A28
		[IDTag(0)]
		public static string TrimEndLength(this string str, string lengthString); // 0x00000001842BAC90-0x00000001842BAD00
		[IDTag(1)]
		public static string TrimEndLength(this string str, int length); // 0x0000000186367938-0x00000001863679B0
		public static string Trim(this string str, string startLengthString, string endLengthString); // 0x0000000186367AAC-0x0000000186367B60
		public static bool EqualsIgnoreCase(this string strA, string strB); // 0x000000018307B110-0x000000018307B220
		public static string SafeValue(this string str); // 0x00000001833B8840-0x00000001833B88B0
	}
}

namespace Beyond.Base
{
	public interface IDisposeEnumerator // TypeDefIndex: 63243
	{
		// Methods
		void Dispose();
	}
}

namespace Beyond.Security
{
	public class IOOO000iiI // TypeDefIndex: 63242
	{
		// Fields
		public const string FONT_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Fonts/"; // Metadata: 0x0235270F
	
		// Constructors
		public IOOO000iiI(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static string Encrypt(string text, string key = null); // 0x00000001863671E0-0x000000018636725C
		public static string IOoOIiII(string encryptText, string key = null); // 0x000000018636725C-0x00000001863672E0
		public static string EncryptBytes(byte[] bytes, string key = null); // 0x0000000186367154-0x00000001863671E0
		private static byte[] _IooiIIO(string encryptText, string key = null); // 0x00000001863674B4-0x000000018636753C
		public static int IooiIIO(string encryptText, Span<byte> result, string key = null); // 0x000000018307C380-0x000000018307C8F0
		private static byte[] _Encrypt(byte[] data, string key); // 0x00000001863672E0-0x00000001863673C0
		[IDTag(1)]
		private static void _IIiiIIIoO(ReadOnlySpan<byte> data, string key, Span<byte> result); // 0x0000000182F800B0-0x0000000182F804B0
		[IDTag(0)]
		private static byte[] _IIiiIIIoO(byte[] data, string key); // 0x00000001863673C0-0x00000001863674B4
		public static void FromBase64String(string text, Span<byte> buffer, out int count); // 0x000000018307BC20-0x000000018307BD60
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63245
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D7A410-0x0000000184D7A450
	
		// Methods
		public string __Gen_Wrap_0(object P0, bool P1); // 0x00000001863664A8-0x0000000186366584
		public string __Gen_Wrap_1(object P0, object P1); // 0x0000000186366900-0x00000001863669F0
		public string __Gen_Wrap_2(object P0, int P1); // 0x00000001863669F0-0x0000000186366ACC
		public string __Gen_Wrap_3(object P0, object P1, object P2); // 0x0000000186366ACC-0x0000000186366BC4
		public bool __Gen_Wrap_4(object P0, object P1); // 0x0000000186366BC4-0x0000000186366CB0
		public string __Gen_Wrap_5(object P0); // 0x0000000186366CB0-0x0000000186366D84
		public int __Gen_Wrap_6(char P0); // 0x0000000186366D84-0x0000000186366E40
		public int __Gen_Wrap_7(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public Utf16ValueStringBuilder __Gen_Wrap_8(); // 0x0000000186366EFC-0x0000000186366FD0
		public byte[] __Gen_Wrap_9(object P0, object P1); // 0x0000000186366FD0-0x00000001863670C0
		public int __Gen_Wrap_10(object P0, Span<byte> P1, object P2); // 0x0000000186366584-0x00000001863666A4
		public void __Gen_Wrap_11(ReadOnlySpan<byte> P0, object P1, Span<byte> P2); // 0x00000001863666A4-0x00000001863667D0
		public void __Gen_Wrap_12(object P0, Span<byte> P1, out int P2); // 0x00000001863667D0-0x0000000186366900
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63246
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x00000001863670C0-0x0000000186367154
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63247
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000186367CD8-0x0000000186367D2C
		public static bool IsPatched(int id); // 0x000000018307B220-0x000000018307B270
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000186367BE8-0x0000000186367C7C
		public object CreateWrapper(int id); // 0x0000000186367C7C-0x0000000186367CD8
		public object InitWrapperArray(int len); // 0x0000000186367D2C-0x0000000186367D8C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000186367B60-0x0000000186367BE8
	}

	public enum IDMAP0 // TypeDefIndex: 63248
	{
		Beyond-StringUtils-LowerFirst0 = 0,
		Beyond-StringUtils-TrimStartLength0 = 1,
		Beyond-StringUtils-TrimStartLength1 = 2,
		Beyond-StringUtils-TrimEndLength0 = 3,
		Beyond-StringUtils-TrimEndLength1 = 4,
		Beyond-StringUtils-Trim0 = 5,
		Beyond-StringUtils-EqualsIgnoreCase0 = 6,
		Beyond-StringUtils-SafeValue0 = 7,
		Beyond-StringUtils-HexToInt0 = 8,
		Beyond-StringUtils-StringHexToInt0 = 9,
		Beyond-StringUtils-CreateZStringBuilder0 = 10,
		Beyond-Security-IOOO000iiI-Encrypt0 = 11,
		Beyond-Security-IOOO000iiI-EncryptBytes0 = 12,
		Beyond-Security-IOOO000iiI-_Encrypt0 = 13,
		Beyond-Security-IOOO000iiI-IOoOIiII0 = 14,
		Beyond-Security-IOOO000iiI-_IooiIIO0 = 15,
		Beyond-Security-IOOO000iiI-_IIiiIIIoO0 = 16,
		Beyond-Security-IOOO000iiI-IooiIIO0 = 17,
		Beyond-Security-IOOO000iiI-_IIiiIIIoO1 = 18,
		Beyond-Security-IOOO000iiI-FromBase64String0 = 19
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 63230
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 63231
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Unity.IL2CPP.CompilerServices
{
	public enum Option // TypeDefIndex: 63232
	{
		NullChecks = 1,
		ArrayBoundsChecks = 2,
		DivideByZeroChecks = 3
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate, Inherited = false, AllowMultiple = true)]
	public class Il2CppSetOptionAttribute : Attribute // TypeDefIndex: 63233
	{
		// Fields
		[CompilerGenerated]
		private Option _Option_k__BackingField; // 0x10
		[CompilerGenerated]
		private object _Value_k__BackingField; // 0x18
	
		// Properties
		public Option Option { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		public object Value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public Il2CppSetOptionAttribute(Option option, object value); // 0x0000000184A41B50-0x0000000184A41B60
	}
}
