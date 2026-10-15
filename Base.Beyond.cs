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

// Image 102: Base.Beyond.dll - Assembly: Base.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90618-90651

internal static class _BurstDirectCallInitializer // TypeDefIndex: 90634
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize(); // 0x00000001872313E0-0x0000000187231400
}

namespace Beyond
{
	public static class CollectionUtils // TypeDefIndex: 90624
	{
		// Extension methods
		public static void AddRange<T>(this HashSet<T> hashSet, IEnumerable<T> range);
		public static HashSet<T> DeepClone<T>(this HashSet<T> hashSet);
	}

	public class DebugAssert // TypeDefIndex: 90625
	{
		// Fields
		private const string NODE_NAME = "BEYOND_DEBUG_COMMAND"; // Metadata: 0x0264B07F
	
		// Constructors
		public DebugAssert(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsTrue(bool condition); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsTrue(bool condition, string message); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsFalse(bool condition); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsFalse(bool condition, string message); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsNotNull<T>(T value)
			where T : class;
		[Conditional("BEYOND_DEBUG_COMMAND")]
		public static void IsNull<T>(T value)
			where T : class;
	}

	public static class EnumUtils // TypeDefIndex: 90626
	{
		// Fields
		private static readonly Dictionary<System.Type, int> _enumCountCache; // 0x00
	
		// Constructors
		static EnumUtils(); // 0x00000001887F2860-0x00000001887F28B8
	
		// Methods
		public static int GetEnumCount<T>()
			where T : Enum;
		public static TEnum FromIntNoGC<TEnum>(int value)
			where TEnum : struct, Enum;
		public static TEnum IntToEnumNoGC<TEnum>(int value)
			where TEnum : struct, Enum;
	}

	public class StaticFastLookupCollection<TKey, TValue> // TypeDefIndex: 90627
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

	public class DynamicFastLookupCollection<TKey, TValue> // TypeDefIndex: 90628
	{
		// Fields
		private Dictionary<TKey, TValue> m_dict;
		private List<ValueTuple<TKey, TValue>> m_list;
		private readonly IEqualityComparer<TKey> m_keyComparer;
	
		// Properties
		public IReadOnlyList<ValueTuple<TKey, TValue>> items { get; }
	
		// Constructors
		public DynamicFastLookupCollection();
		public DynamicFastLookupCollection(int capacity);
	
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
	public static class StringUtils // TypeDefIndex: 90631
	{
		// Nested types
		public unsafe delegate bool _EqualsIgnoreCase_0000002E_PostfixBurstDelegate(short* str1, short* str2, int len); // TypeDefIndex: 90629; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _EqualsIgnoreCase_0000002E_BurstDirectCall // TypeDefIndex: 90630
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _EqualsIgnoreCase_0000002E_BurstDirectCall(); // 0x000000018633AE20-0x000000018633AE30
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000bfdc0); // 0x0000000184FEF8C0-0x0000000184FEF9D0
			private static IntPtr GetFunctionPointer(); // 0x0000000184FEEF20-0x0000000184FEF040
			public static void Constructor(); // 0x000000018633AEF0-0x000000018633AF50
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe bool Invoke(short* str1, short* str2, int len); // 0x0000000184FEEEA0-0x0000000184FEEF20
		}
	
		// Methods
		[BurstCompile]
		private static unsafe bool _EqualsIgnoreCase(short* str1, short* str2, int len); // 0x0000000184FEEE00-0x0000000184FEEEA0
		public static int HexToInt(char hex); // 0x00000001887F3494-0x00000001887F3604
		public static int StringHexToInt(string s); // 0x00000001887F37C8-0x00000001887F387C
		public static Utf16ValueStringBuilder CreateZStringBuilder(); // 0x000000018539C700-0x000000018539C800
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
		public static unsafe bool _EqualsIgnoreCase_BurstManaged(short* str1, short* str2, int len); // 0x00000001887F2800-0x00000001887F2860
	
		// Extension methods
		public static string LowerFirst(this string str, bool includeAllStartUppers = false /* Metadata: 0x0264B094 */); // 0x00000001887F3604-0x00000001887F37C8
		[IDTag(0)]
		public static string TrimStartLength(this string str, string lengthString); // 0x00000001887F3988-0x00000001887F39E8
		[IDTag(1)]
		public static string TrimStartLength(this string str, int length); // 0x00000001887F3934-0x00000001887F3988
		[IDTag(0)]
		public static string TrimEndLength(this string str, string lengthString); // 0x00000001887F387C-0x00000001887F38DC
		[IDTag(1)]
		public static string TrimEndLength(this string str, int length); // 0x00000001887F38DC-0x00000001887F3934
		public static string Trim(this string str, string startLengthString, string endLengthString); // 0x00000001887F39E8-0x00000001887F3A70
		public static bool EqualsIgnoreCase(this string strA, string strB); // 0x0000000184FEED20-0x0000000184FEEE00
		public static string SafeValue(this string str); // 0x0000000184FF0A50-0x0000000184FF0A90
	}
}

namespace Beyond.Base
{
	public interface IDisposeEnumerator // TypeDefIndex: 90633
	{
		// Methods
		void Dispose();
	}
}

namespace Beyond.Security
{
	public class IOOO000iiI // TypeDefIndex: 90632
	{
		// Fields
		public const string FONT_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Fonts/"; // Metadata: 0x0264B095
	
		// Constructors
		public IOOO000iiI(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static string Encrypt(string text, string key = null); // 0x00000001858DA350-0x00000001858DA3C0
		public static string IOoOIiII(string encryptText, string key = null); // 0x00000001858DAF30-0x00000001858DAFA0
		public static string EncryptBytes(byte[] bytes, string key = null); // 0x00000001858DA3C0-0x00000001858DA440
		private static byte[] _IooiIIO(string encryptText, string key = null); // 0x00000001858DAFA0-0x00000001858DB020
		public static int IooiIIO(string encryptText, Span<byte> result, string key = null); // 0x0000000184F8FBB0-0x0000000184F90060
		private static byte[] _Encrypt(byte[] data, string key); // 0x00000001858DA440-0x00000001858DA530
		[IDTag(1)]
		private static void _IIiiIIIoO(ReadOnlySpan<byte> data, string key, Span<byte> result); // 0x0000000184F89760-0x0000000184F899F0
		[IDTag(0)]
		private static byte[] _IIiiIIIoO(byte[] data, string key); // 0x00000001858DC440-0x00000001858DC560
		public static void FromBase64String(string text, Span<byte> buffer, out int count); // 0x0000000184F8FAC0-0x0000000184F8FBB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 90635
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x00000001887F33C0-0x00000001887F33FC
	
		// Methods
		public string __Gen_Wrap_0(object P0, bool P1); // 0x00000001887F28B8-0x00000001887F299C
		public string __Gen_Wrap_1(object P0, object P1); // 0x00000001887F2CF4-0x00000001887F2DD8
		public string __Gen_Wrap_2(object P0, int P1); // 0x00000001887F2DD8-0x00000001887F2EB8
		public string __Gen_Wrap_3(object P0, object P1, object P2); // 0x00000001887F2EB8-0x00000001887F2FB4
		public bool __Gen_Wrap_4(object P0, object P1); // 0x00000001887F2FB4-0x00000001887F3094
		public string __Gen_Wrap_5(object P0); // 0x00000001887F3094-0x00000001887F3158
		public int __Gen_Wrap_6(char P0); // 0x00000001887F3158-0x00000001887F3218
		public int __Gen_Wrap_7(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public Utf16ValueStringBuilder __Gen_Wrap_8(); // 0x00000001887F3218-0x00000001887F32DC
		public byte[] __Gen_Wrap_9(object P0, object P1); // 0x00000001887F32DC-0x00000001887F33C0
		public int __Gen_Wrap_10(object P0, Span<byte> P1, object P2); // 0x00000001887F299C-0x00000001887F2AB0
		public void __Gen_Wrap_11(ReadOnlySpan<byte> P0, object P1, Span<byte> P2); // 0x00000001887F2AB0-0x00000001887F2BD0
		public void __Gen_Wrap_12(object P0, Span<byte> P1, out int P2); // 0x00000001887F2BD0-0x00000001887F2CF4
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 90636
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x00000001887F33FC-0x00000001887F3494
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 90637
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x00000001887F3BEC-0x00000001887F3C40
		public static bool IsPatched(int id); // 0x00000001887F3CA0-0x00000001887F3D1C
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x00000001887F3AF8-0x00000001887F3B90
		public object CreateWrapper(int id); // 0x00000001887F3B90-0x00000001887F3BEC
		public object InitWrapperArray(int len); // 0x00000001887F3C40-0x00000001887F3CA0
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x00000001887F3A70-0x00000001887F3AF8
	}

	public delegate string __HotPatchDelegate_0(object P0, bool P1); // TypeDefIndex: 90638; 0x00000001859B7730-0x00000001859B7740

	public enum HotPatchIDMAP0 // TypeDefIndex: 90639
	{
		Beyond-StringUtils-LowerFirst0 = 0,
		Beyond-StringUtils-TrimStartLength0 = 1,
		Beyond-StringUtils-TrimEndLength0 = 1,
		Beyond-Security-IOOO000iiI-EncryptBytes0 = 1,
		Beyond-Security-IOOO000iiI-Encrypt0 = 1,
		Beyond-Security-IOOO000iiI-IOoOIiII0 = 1,
		Beyond-StringUtils-TrimStartLength1 = 2,
		Beyond-StringUtils-TrimEndLength1 = 2,
		Beyond-StringUtils-Trim0 = 3,
		Beyond-StringUtils-EqualsIgnoreCase0 = 4,
		Beyond-StringUtils-SafeValue0 = 5,
		Beyond-StringUtils-HexToInt0 = 6,
		Beyond-StringUtils-StringHexToInt0 = 7,
		Beyond-StringUtils-CreateZStringBuilder0 = 8,
		Beyond-Security-IOOO000iiI-_Encrypt0 = 9,
		Beyond-Security-IOOO000iiI-_IIiiIIIoO0 = 9,
		Beyond-Security-IOOO000iiI-_IooiIIO0 = 9,
		Beyond-Security-IOOO000iiI-IooiIIO0 = 10,
		Beyond-Security-IOOO000iiI-_IIiiIIIoO1 = 11,
		Beyond-Security-IOOO000iiI-FromBase64String0 = 12
	}

	public delegate string __HotPatchDelegate_1(object P0, object P1); // TypeDefIndex: 90640; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_2(object P0, int P1); // TypeDefIndex: 90641; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_3(object P0, object P1, object P2); // TypeDefIndex: 90642; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_4(object P0, object P1); // TypeDefIndex: 90643; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_5(object P0); // TypeDefIndex: 90644; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_6(char P0); // TypeDefIndex: 90645; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_7(object P0); // TypeDefIndex: 90646; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Utf16ValueStringBuilder __HotPatchDelegate_8(); // TypeDefIndex: 90647; 0x0000000185378C70-0x0000000185378CA0

	public delegate byte[] __HotPatchDelegate_9(object P0, object P1); // TypeDefIndex: 90648; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_10(object P0, Span<byte> P1, object P2); // TypeDefIndex: 90649; 0x0000000181256E30-0x0000000181256E60

	public delegate void __HotPatchDelegate_11(ReadOnlySpan<byte> P0, object P1, Span<byte> P2); // TypeDefIndex: 90650; 0x0000000187996158-0x0000000187996190

	public delegate void __HotPatchDelegate_12(object P0, Span<byte> P1, out int P2); // TypeDefIndex: 90651; 0x0000000181256E30-0x0000000181256E60
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 90619
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 90620
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Unity.IL2CPP.CompilerServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
	public class Il2CppEagerStaticClassConstructionAttribute : Attribute // TypeDefIndex: 90621
	{
		// Constructors
		public Il2CppEagerStaticClassConstructionAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public enum Option // TypeDefIndex: 90622
	{
		NullChecks = 1,
		ArrayBoundsChecks = 2,
		DivideByZeroChecks = 3
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate, Inherited = false, AllowMultiple = true)]
	public class Il2CppSetOptionAttribute : Attribute // TypeDefIndex: 90623
	{
		// Fields
		[CompilerGenerated]
		private Option _Option_k__BackingField; // 0x10
		[CompilerGenerated]
		private object _Value_k__BackingField; // 0x18
	
		// Properties
		public Option Option { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public object Value { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public Il2CppSetOptionAttribute(Option option, object value); // 0x0000000186EDC850-0x0000000186EDC860
	}
}
