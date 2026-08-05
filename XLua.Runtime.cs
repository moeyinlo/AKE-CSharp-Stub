/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using AOT;
using Beyond.Lua;
using Beyond.Reflection;
using Beyond.Scripts.Lua;
using IFix.Core;
using Microsoft.CodeAnalysis;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.LowLevel;
using UnityEngine.Pool;
using XLua;
using XLua.LuaDLL;

// Image 38: XLua.Runtime.dll - Assembly: XLua.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58612-58854
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class __f__AnonymousType0<_Type_j__TPar, _Value_j__TPar, _Index_j__TPar> // TypeDefIndex: 58613
{
	// Fields
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _Type_j__TPar _Type_i__Field;
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _Value_j__TPar _Value_i__Field;
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _Index_j__TPar _Index_i__Field;

	// Properties
	public _Type_j__TPar Type { get; }
	public _Value_j__TPar Value { get; }
	public _Index_j__TPar Index { get; }

	// Constructors
	[DebuggerHidden]
	public __f__AnonymousType0(_Type_j__TPar Type, _Value_j__TPar Value, _Index_j__TPar Index);

	// Methods
	[DebuggerHidden]
	public override bool Equals(object value);
	[DebuggerHidden]
	public override int GetHashCode();
	[DebuggerHidden]
	public override string ToString();
}

[CompilerGenerated]
internal sealed class __f__AnonymousType1<_type_j__TPar, _method_j__TPar> // TypeDefIndex: 58614
{
	// Fields
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _type_j__TPar _type_i__Field;
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _method_j__TPar _method_i__Field;

	// Properties
	public _type_j__TPar type { get; }
	public _method_j__TPar method { get; }

	// Constructors
	[DebuggerHidden]
	public __f__AnonymousType1(_type_j__TPar type, _method_j__TPar method);

	// Methods
	[DebuggerHidden]
	public override bool Equals(object value);
	[DebuggerHidden]
	public override int GetHashCode();
	[DebuggerHidden]
	public override string ToString();
}

[Serializable]
public class LuaAsset : ScriptableObject // TypeDefIndex: 58617
{
	// Fields
	public static string LuaDecodeKey; // 0x00
	public bool encode; // 0x18
	public byte[] data; // 0x20

	// Constructors
	public LuaAsset(); // 0x0000000186DCF4A4-0x0000000186DCF4B0
	static LuaAsset(); // 0x000000018B89F134-0x000000018B89F190

	// Methods
	public byte[] GetDecodeBytes(); // 0x000000018B89F0AC-0x000000018B89F134
}

namespace Beyond.Lua
{
	public class LuaCypher // TypeDefIndex: 58687
	{
		// Fields
		private const string KEY = "=="; // Metadata: 0x0234BE55
		private static readonly string[] KEYS; // 0x00
		private const string INITIAL_ASSETS_ROOT_PATH = "Assets/Beyond/InitialAssets/"; // Metadata: 0x0234BE58
		private static readonly ProfilerMarker decryptionMaker; // 0x08
	
		// Constructors
		public LuaCypher(); // 0x00000001841E1670-0x00000001841E1680
		static LuaCypher(); // 0x00000001849D9E80-0x00000001849DA040
	
		// Methods
		[IDTag(0)]
		private static string GetKey(); // 0x000000018B89FE54-0x000000018B8A0184
		[IDTag(1)]
		private static void GetKey(Span<byte> buffer, out int len); // 0x000000018B89FBE8-0x000000018B89FE54
		protected static bool SkipDecrypt(string luaString); // 0x000000018B8A0184-0x000000018B8A0294
		public static string DecryptLuaString(string encryptLua); // 0x000000018B89F3D0-0x000000018B89F46C
		public static byte[] DecryptLua(string encryptLua); // 0x000000018B89F46C-0x000000018B89FBE8
		[XLua.MonoPInvokeCallback(typeof(Lua.DecryptionFunc))]
		public static IntPtr DecryptionFunc(IntPtr input, int size, out int outSize); // 0x00000001838F0A60-0x00000001838F13E0
	}

	public class LuaGenericDelegateCaller // TypeDefIndex: 58689
	{
		// Fields
		private static Dictionary<string, LuaGenericDelegateCall> s_callerDic; // 0x00
	
		// Nested types
		public delegate int LuaGenericDelegateCall(IntPtr L, Delegate @delegate, ObjectTranslator objectTranslator, List<System.Type> castType); // TypeDefIndex: 58688; 0x00000001814D0D00-0x00000001814D0D20
	
		// Constructors
		public LuaGenericDelegateCaller(); // 0x00000001841E1670-0x00000001841E1680
		static LuaGenericDelegateCaller(); // 0x0000000184D179A0-0x0000000184D17A30
	
		// Methods
		public static LuaGenericDelegateCall GetCaller(string delegateTypeName); // 0x00000001838EDEB0-0x00000001838EDF40
		public static void AddCaller(string delegateTypeName, LuaGenericDelegateCall caller); // 0x00000001838EE6A0-0x00000001838EE820
		public static int OverloadMethodCall(IntPtr L, ObjectTranslator objectTranslator, IOverloadMethodWrap[] overload); // 0x000000018329ABB0-0x000000018329B230
		public static int DefaultValueMethodCall(IntPtr L, ObjectTranslator objectTranslator, IOverloadMethodWrap[] defaultValues); // 0x00000001838EE200-0x00000001838EE520
	}
}

namespace Beyond.Reflection
{
	public class GenericDelegateCaller // TypeDefIndex: 58619
	{
		// Fields
		private static Dictionary<string, System.Type> s_customDelegateTypeDic; // 0x00
	
		// Constructors
		public GenericDelegateCaller(); // 0x00000001841E1670-0x00000001841E1680
		static GenericDelegateCaller(); // 0x00000001845B1A60-0x00000001845B1AF0
	
		// Methods
		public static System.Type GetCustomDelegateType(string delegateName); // 0x00000001838F13E0-0x00000001838F1470
		public static void AddCustomDelegateType(string delegateName, System.Type type); // 0x00000001838EE520-0x00000001838EE6A0
	}

	public class MethodParamItem // TypeDefIndex: 58620
	{
		// Fields
		public System.Type type; // 0x10
		public bool isRef; // 0x18
		public bool isOut; // 0x19
		public object defaultValue; // 0x20
		public bool hasDefaultValue; // 0x28
		public string name; // 0x30
		public System.Type realType; // 0x38
	
		// Constructors
		public MethodParamItem(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static List<MethodParamItem> GetMethodParamList(MethodInfo method, bool needLua = false /* Metadata: 0x0234BE4D */, bool needEnum = false /* Metadata: 0x0234BE4E */); // 0x0000000182F2D880-0x0000000182F2DD60
		public static string GetMethodSignatureString(MethodInfo method, bool needLua = false /* Metadata: 0x0234BE4F */, bool keepType = false /* Metadata: 0x0234BE50 */, bool needEnum = false /* Metadata: 0x0234BE51 */); // 0x0000000182F2B440-0x0000000182F2BCB0
	}
}

namespace Beyond.Reflection.StructSizeGen
{
	public struct FStructSize0 // TypeDefIndex: 58621
	{
	}

	public struct FStructSize1 // TypeDefIndex: 58622
	{
		// Fields
		public byte b0; // 0x00
	}

	public struct FStructSize2 // TypeDefIndex: 58623
	{
		// Fields
		public short s0; // 0x00
	}

	public struct FStructSize3 // TypeDefIndex: 58624
	{
		// Fields
		public short s0; // 0x00
		public byte b0; // 0x02
	}

	public struct FStructSize4 // TypeDefIndex: 58625
	{
		// Fields
		public int i0; // 0x00
	}

	public struct FStructSize5 // TypeDefIndex: 58626
	{
		// Fields
		public int i0; // 0x00
		public byte b0; // 0x04
	}

	public struct FStructSize8 // TypeDefIndex: 58627
	{
		// Fields
		public long l0; // 0x00
	}

	public struct FStructSize12 // TypeDefIndex: 58628
	{
		// Fields
		public long l0; // 0x00
		public int i0; // 0x08
	}

	public struct FStructSize16 // TypeDefIndex: 58629
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
	}

	public struct FStructSize19 // TypeDefIndex: 58630
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public short s0; // 0x10
		public byte b0; // 0x12
	}

	public struct FStructSize20 // TypeDefIndex: 58631
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public int i0; // 0x10
	}

	public struct FStructSize24 // TypeDefIndex: 58632
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
	}

	public struct FStructSize28 // TypeDefIndex: 58633
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public int i0; // 0x18
	}

	public struct FStructSize32 // TypeDefIndex: 58634
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
	}

	public struct FStructSize34 // TypeDefIndex: 58635
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public short s0; // 0x20
	}

	public struct FStructSize36 // TypeDefIndex: 58636
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public int i0; // 0x20
	}

	public struct FStructSize40 // TypeDefIndex: 58637
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
	}

	public struct FStructSize44 // TypeDefIndex: 58638
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public int i0; // 0x28
	}

	public struct FStructSize48 // TypeDefIndex: 58639
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
	}

	public struct FStructSize52 // TypeDefIndex: 58640
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public int i0; // 0x30
	}

	public struct FStructSize56 // TypeDefIndex: 58641
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
	}

	public struct FStructSize60 // TypeDefIndex: 58642
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public int i0; // 0x38
	}

	public struct FStructSize64 // TypeDefIndex: 58643
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
	}

	public struct FStructSize68 // TypeDefIndex: 58644
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public int i0; // 0x40
	}

	public struct FStructSize72 // TypeDefIndex: 58645
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
	}

	public struct FStructSize76 // TypeDefIndex: 58646
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public int i0; // 0x48
	}

	public struct FStructSize80 // TypeDefIndex: 58647
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
	}

	public struct FStructSize84 // TypeDefIndex: 58648
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public int i0; // 0x50
	}

	public struct FStructSize88 // TypeDefIndex: 58649
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
	}

	public struct FStructSize92 // TypeDefIndex: 58650
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public int i0; // 0x58
	}

	public struct FStructSize96 // TypeDefIndex: 58651
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
	}

	public struct FStructSize104 // TypeDefIndex: 58652
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
	}

	public struct FStructSize108 // TypeDefIndex: 58653
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public int i0; // 0x68
	}

	public struct FStructSize112 // TypeDefIndex: 58654
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
	}

	public struct FStructSize116 // TypeDefIndex: 58655
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public int i0; // 0x70
	}

	public struct FStructSize120 // TypeDefIndex: 58656
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
	}

	public struct FStructSize124 // TypeDefIndex: 58657
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public int i0; // 0x78
	}

	public struct FStructSize128 // TypeDefIndex: 58658
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
	}

	public struct FStructSize136 // TypeDefIndex: 58659
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
	}

	public struct FStructSize140 // TypeDefIndex: 58660
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public int i0; // 0x88
	}

	public struct FStructSize144 // TypeDefIndex: 58661
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
	}

	public struct FStructSize148 // TypeDefIndex: 58662
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public int i0; // 0x90
	}

	public struct FStructSize152 // TypeDefIndex: 58663
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
	}

	public struct FStructSize160 // TypeDefIndex: 58664
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
	}

	public struct FStructSize164 // TypeDefIndex: 58665
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public int i0; // 0xA0
	}

	public struct FStructSize168 // TypeDefIndex: 58666
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
	}

	public struct FStructSize176 // TypeDefIndex: 58667
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
	}

	public struct FStructSize180 // TypeDefIndex: 58668
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public int i0; // 0xB0
	}

	public struct FStructSize184 // TypeDefIndex: 58669
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public long l22; // 0xB0
	}

	public struct FStructSize192 // TypeDefIndex: 58670
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public long l22; // 0xB0
		public long l23; // 0xB8
	}

	public struct FStructSize196 // TypeDefIndex: 58671
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public long l22; // 0xB0
		public long l23; // 0xB8
		public int i0; // 0xC0
	}

	public struct FStructSize200 // TypeDefIndex: 58672
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public long l22; // 0xB0
		public long l23; // 0xB8
		public long l24; // 0xC0
	}

	public struct FStructSize208 // TypeDefIndex: 58673
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public long l22; // 0xB0
		public long l23; // 0xB8
		public long l24; // 0xC0
		public long l25; // 0xC8
	}

	public struct FStructSize220 // TypeDefIndex: 58674
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public long l22; // 0xB0
		public long l23; // 0xB8
		public long l24; // 0xC0
		public long l25; // 0xC8
		public long l26; // 0xD0
		public int i0; // 0xD8
	}

	public struct FStructSize224 // TypeDefIndex: 58675
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public long l22; // 0xB0
		public long l23; // 0xB8
		public long l24; // 0xC0
		public long l25; // 0xC8
		public long l26; // 0xD0
		public long l27; // 0xD8
	}

	public struct FStructSize232 // TypeDefIndex: 58676
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public long l22; // 0xB0
		public long l23; // 0xB8
		public long l24; // 0xC0
		public long l25; // 0xC8
		public long l26; // 0xD0
		public long l27; // 0xD8
		public long l28; // 0xE0
	}

	public struct FStructSize240 // TypeDefIndex: 58677
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public long l22; // 0xB0
		public long l23; // 0xB8
		public long l24; // 0xC0
		public long l25; // 0xC8
		public long l26; // 0xD0
		public long l27; // 0xD8
		public long l28; // 0xE0
		public long l29; // 0xE8
	}

	public struct FStructSize248 // TypeDefIndex: 58678
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public long l22; // 0xB0
		public long l23; // 0xB8
		public long l24; // 0xC0
		public long l25; // 0xC8
		public long l26; // 0xD0
		public long l27; // 0xD8
		public long l28; // 0xE0
		public long l29; // 0xE8
		public long l30; // 0xF0
	}

	public struct FStructSize256 // TypeDefIndex: 58679
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
		public long l6; // 0x30
		public long l7; // 0x38
		public long l8; // 0x40
		public long l9; // 0x48
		public long l10; // 0x50
		public long l11; // 0x58
		public long l12; // 0x60
		public long l13; // 0x68
		public long l14; // 0x70
		public long l15; // 0x78
		public long l16; // 0x80
		public long l17; // 0x88
		public long l18; // 0x90
		public long l19; // 0x98
		public long l20; // 0xA0
		public long l21; // 0xA8
		public long l22; // 0xB0
		public long l23; // 0xB8
		public long l24; // 0xC0
		public long l25; // 0xC8
		public long l26; // 0xD0
		public long l27; // 0xD8
		public long l28; // 0xE0
		public long l29; // 0xE8
		public long l30; // 0xF0
		public long l31; // 0xF8
	}
}

namespace Beyond.Scripts.Lua
{
	public enum ELuaMultithreadingGCState // TypeDefIndex: 58680
	{
		MinorGC = 0,
		MajorGC = 1
	}

	public class OnGCEndEvent : UnityEvent // TypeDefIndex: 58681
	{
		// Constructors
		public OnGCEndEvent(); // 0x0000000185393538-0x0000000185393540
	}

	public class LuaMultithreadingGC // TypeDefIndex: 58686
	{
		// Fields
		public static int threadGcCount; // 0x00
		public static int mainThreadSignalCount; // 0x04
		public static int mainTheadForceGCCount; // 0x08
		public static int gcMarkCount; // 0x0C
		public static int gcSweepCount; // 0x10
		private Thread m_gcThread; // 0x10
		private AutoResetEvent m_workSignal; // 0x18
		private LuaEnv m_luaEnv; // 0x20
		private int m_lastMajorGCMemory; // 0x28
		private int m_lastMinorGCMemory; // 0x2C
		private int m_badGCCounter; // 0x30
		private int m_badGCThreshold; // 0x34
		private float m_genGcIncreaseThreshold; // 0x38
		private float m_genGcIncreaseThresholdDiff; // 0x3C
		private int m_forceGCBaseLine; // 0x40
		private int m_incGCThreshold; // 0x44
		private int m_majorGCFactor; // 0x48
		private int m_forceGCFactor; // 0x4C
		private OnGCEndEvent m_afterGCEvent; // 0x50
		private List<UnityAction> m_afterGCEventOnceEvents; // 0x58
		public ELuaMultithreadingGCState gcState; // 0x60
		public long mainThreadWait; // 0x68
		public long gcThreadStop; // 0x70
		public bool stop; // 0x78
		public bool isRunning; // 0x79
		private XLua.LuaDLL.lua_Hook hook; // 0x80
		private static XLua.LuaDLL.lua_Hook oldHook; // 0x18
		private static int oldHookMask; // 0x20
		private bool haveRunOnce; // 0x88
		private static readonly ProfilerMarker PROFILER_MARKER_START_GC; // 0x28
		private static readonly ProfilerMarker PROFILER_MARKER_THREAD_NOTIFY; // 0x30
	
		// Nested types
		public struct StartLuaGC // TypeDefIndex: 58682
		{
		}
	
		public struct WaitLuaGC // TypeDefIndex: 58683
		{
		}
	
		public struct OnGCEnd // TypeDefIndex: 58684
		{
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58685
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<PlayerLoopSystem, bool> __9__44_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B8A5BD8-0x000000018B8A5C3C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool __Dispose_b__44_0(PlayerLoopSystem x); // 0x0000000182ED60A0-0x0000000182ED6C30
		}
	
		// Constructors
		public LuaMultithreadingGC(LuaEnv luaEnv); // 0x0000000183B25580-0x0000000183B258B0
		static LuaMultithreadingGC(); // 0x0000000184B84B50-0x0000000184B84C60
	
		// Methods
		public void StartGCAsync(); // 0x00000001838EE820-0x00000001838EF140
		public void NormalStop(); // 0x000000018B8A11B4-0x000000018B8A1254
		public void ForceStopAsyncGC(); // 0x000000018B8A0FF8-0x000000018B8A1070
		public void MainThreadWait(); // 0x00000001838EF140-0x00000001838EF8C0
		public void AddLuaAfterGCEvent(UnityAction action); // 0x000000018488B6A0-0x000000018488B6F0
		public void AddLuaAfterGCOnceEvent(UnityAction action); // 0x000000018423A4A0-0x000000018423A510
		public void RemoveLuaAfterGCEvent(UnityAction action); // 0x000000018B8A1254-0x000000018B8A12BC
		private void _OnGCEnd(); // 0x00000001838EF910-0x00000001838EFAD0
		private void _Init(); // 0x0000000183322B40-0x0000000183323290
		private void _Dispose(); // 0x000000018B8A12BC-0x000000018B8A178C
		private static int _FindLoopSystemIndex(PlayerLoopSystem[] playerLoopList, string typeName); // 0x0000000183325790-0x0000000183325840
		[AOT.MonoPInvokeCallback(typeof(XLua.lua_Hook))]
		public static int LuaHook(IntPtr L, ref lua_debug ar); // 0x000000018B8A1070-0x000000018B8A11B4
		private void _UpdateOldHook(); // 0x000000018B8A178C-0x000000018B8A1974
		private bool _DoLock(); // 0x00000001838F0A20-0x00000001838F0A60
		private bool _DoGc(int work = 0 /* Metadata: 0x0234BE54 */); // 0x00000001838F1730-0x00000001838F17F0
		private void _GCMethodWrapper(); // 0x00000001838EFB20-0x00000001838F0A20
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 58851
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37800-0x0000000184D37870
	
		// Methods
		public System.Type __Gen_Wrap_0(object P0); // 0x000000018B8AE564-0x000000018B8AE640
		public void __Gen_Wrap_1(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
		public List<MethodParamItem> __Gen_Wrap_2(object P0, bool P1, bool P2); // 0x000000018B8AECBC-0x000000018B8AEDD0
		public string __Gen_Wrap_3(object P0, bool P1, bool P2, bool P3); // 0x000000018B8AEDD0-0x000000018B8AEEF8
		public void __Gen_Wrap_4(object P0); // 0x00000001863633B4-0x0000000186363474
		public bool __Gen_Wrap_5(PlayerLoopSystem P0); // 0x000000018B8AEEF8-0x000000018B8AEFFC
		public int __Gen_Wrap_6(object P0, object P1); // 0x0000000186360610-0x00000001863606FC
		public int __Gen_Wrap_7(IntPtr P0, ref lua_debug P1); // 0x000000018B8AEFFC-0x000000018B8AF168
		public bool __Gen_Wrap_8(object P0); // 0x00000001863632E4-0x00000001863633B4
		public bool __Gen_Wrap_9(object P0, int P1); // 0x00000001866E0A9C-0x00000001866E0B88
		public string __Gen_Wrap_10(); // 0x000000018B8AE640-0x000000018B8AE6F8
		public void __Gen_Wrap_11(Span<byte> P0, out int P1); // 0x000000018B8AE6F8-0x000000018B8AE81C
		public byte[] __Gen_Wrap_12(object P0); // 0x000000018B8AE81C-0x000000018B8AE8F8
		public string __Gen_Wrap_13(object P0); // 0x000000018B8AE8F8-0x000000018B8AE9D4
		public IntPtr __Gen_Wrap_14(IntPtr P0, int P1, out int P2); // 0x000000018B8AE9D4-0x000000018B8AEAEC
		public LuaGenericDelegateCaller.LuaGenericDelegateCall __Gen_Wrap_15(object P0); // 0x000000018B8AEAEC-0x000000018B8AEBC8
		public int __Gen_Wrap_16(IntPtr P0, object P1, object P2); // 0x000000018B8AEBC8-0x000000018B8AECBC
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 58852
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018B8AF168-0x000000018B8AF1FC
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 58853
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018B8B6A50-0x000000018B8B6AB4
		public static bool IsPatched(int id); // 0x00000001838EFAD0-0x00000001838EFB20
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018B8B690C-0x000000018B8B69D8
		public object CreateWrapper(int id); // 0x000000018B8B69D8-0x000000018B8B6A50
		public object InitWrapperArray(int len); // 0x000000018B8B6AB4-0x000000018B8B6B40
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018B8B6868-0x000000018B8B690C
	}

	public enum IDMAP0 // TypeDefIndex: 58854
	{
		Beyond-Reflection-GenericDelegateCaller-GetCustomDelegateType0 = 0,
		Beyond-Reflection-GenericDelegateCaller-AddCustomDelegateType0 = 1,
		Beyond-Reflection-MethodParamItem-GetMethodParamList0 = 2,
		Beyond-Reflection-MethodParamItem-GetMethodSignatureString0 = 3,
		Beyond-Scripts-Lua-LuaMultithreadingGC-StartGCAsync0 = 4,
		Beyond-Scripts-Lua-LuaMultithreadingGC-NormalStop0 = 5,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_OnGCEnd0 = 6,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_Dispose0 = 7,
		Beyond-Scripts-Lua-LuaMultithreadingGC-ForceStopAsyncGC0 = 11,
		Beyond-Scripts-Lua-LuaMultithreadingGC-MainThreadWait0 = 12,
		Beyond-Scripts-Lua-LuaMultithreadingGC-AddLuaAfterGCEvent0 = 13,
		Beyond-Scripts-Lua-LuaMultithreadingGC-AddLuaAfterGCOnceEvent0 = 14,
		Beyond-Scripts-Lua-LuaMultithreadingGC-RemoveLuaAfterGCEvent0 = 15,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_Init0 = 16,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_FindLoopSystemIndex0 = 17,
		Beyond-Scripts-Lua-LuaMultithreadingGC-LuaHook0 = 18,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_UpdateOldHook0 = 19,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_DoLock0 = 20,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_DoGc0 = 21,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_GCMethodWrapper0 = 22,
		Beyond-Lua-LuaCypher-GetKey0 = 23,
		Beyond-Lua-LuaCypher-GetKey1 = 24,
		Beyond-Lua-LuaCypher-SkipDecrypt0 = 25,
		Beyond-Lua-LuaCypher-DecryptLuaString0 = 26,
		Beyond-Lua-LuaCypher-DecryptLua0 = 27,
		Beyond-Lua-LuaCypher-DecryptionFunc0 = 28,
		Beyond-Lua-LuaGenericDelegateCaller-GetCaller0 = 29,
		Beyond-Lua-LuaGenericDelegateCaller-AddCaller0 = 30,
		Beyond-Lua-LuaGenericDelegateCaller-OverloadMethodCall0 = 31,
		Beyond-Lua-LuaGenericDelegateCaller-DefaultValueMethodCall0 = 34
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 58615
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Security
{
	public sealed class XXTEA // TypeDefIndex: 58618
	{
		// Fields
		private static readonly UTF8Encoding utf8; // 0x00
		private const uint delta = 2654435769; // Metadata: 0x0234BE48
	
		// Constructors
		private XXTEA(); // 0x00000001841E1670-0x00000001841E1680
		static XXTEA(); // 0x000000018B8A732C-0x000000018B8A73A8
	
		// Methods
		private static uint MX(uint sum, uint y, uint z, int p, uint e, uint[] k); // 0x000000018B8A6B74-0x000000018B8A6C18
		public static byte[] Encrypt(byte[] data, byte[] key); // 0x000000018B8A6914-0x000000018B8A69B0
		public static byte[] Encrypt(string data, byte[] key); // 0x000000018B8A6638-0x000000018B8A66B4
		public static byte[] Encrypt(byte[] data, string key); // 0x000000018B8A69B0-0x000000018B8A6A2C
		public static byte[] Encrypt(string data, string key); // 0x000000018B8A66B4-0x000000018B8A6754
		public static string EncryptToBase64String(byte[] data, byte[] key); // 0x000000018B8A6548-0x000000018B8A65C0
		public static string EncryptToBase64String(string data, byte[] key); // 0x000000018B8A65C0-0x000000018B8A6638
		public static string EncryptToBase64String(byte[] data, string key); // 0x000000018B8A6458-0x000000018B8A64D0
		public static string EncryptToBase64String(string data, string key); // 0x000000018B8A64D0-0x000000018B8A6548
		public static byte[] Decrypt(byte[] data, byte[] key); // 0x000000018B8A6338-0x000000018B8A63D4
		private static int _Decrypt(Span<byte> data, Span<byte> key, Span<byte> result); // 0x000000018B8A707C-0x000000018B8A732C
		public static byte[] Decrypt(byte[] data, string key); // 0x000000018B8A62BC-0x000000018B8A6338
		public static int Decrypt(Span<byte> data, Span<byte> key, Span<byte> result); // 0x000000018B8A63D4-0x000000018B8A6458
		public static byte[] DecryptBase64String(string data, byte[] key); // 0x000000018B8A5D44-0x000000018B8A5DBC
		public static byte[] DecryptBase64String(string data, string key); // 0x000000018B8A5DBC-0x000000018B8A5E34
		public static string DecryptToString(byte[] data, byte[] key); // 0x000000018B8A6010-0x000000018B8A6094
		public static string DecryptToString(byte[] data, string key); // 0x000000018B8A6094-0x000000018B8A6118
		public static string DecryptBase64StringToString(string data, byte[] key); // 0x000000018B8A5CC0-0x000000018B8A5D44
		public static string DecryptBase64StringToString(string data, string key); // 0x000000018B8A5C3C-0x000000018B8A5CC0
		private static uint[] Encrypt(uint[] v, uint[] k); // 0x000000018B8A6754-0x000000018B8A6914
		private static uint[] Decrypt(uint[] v, uint[] k); // 0x000000018B8A6118-0x000000018B8A62BC
		private static void DecryptInPlace(Span<uint> v, Span<uint> k); // 0x000000018B8A5E34-0x000000018B8A6010
		private static uint MxForSpan(uint sum, uint y, uint z, int p, uint e, Span<uint> k); // 0x000000018B8A6C18-0x000000018B8A6C7C
		private static byte[] FixKey(byte[] key); // 0x000000018B8A6ADC-0x000000018B8A6B74
		private static void FixKey(Span<byte> key, Span<byte> fixedkey); // 0x000000018B8A6A2C-0x000000018B8A6ADC
		private static uint[] ToUInt32Array(byte[] data, bool includeLength); // 0x000000018B8A6F8C-0x000000018B8A707C
		private static void ToUInt32Array(Span<byte> data, bool includeLength, Span<uint> result); // 0x000000018B8A6E9C-0x000000018B8A6F8C
		private static byte[] ToByteArray(uint[] data, bool includeLength); // 0x000000018B8A6C7C-0x000000018B8A6D58
		private static void ToByteSpanFromUInt32(Span<uint> data, bool includeLength, Span<byte> result, out int len); // 0x000000018B8A6D58-0x000000018B8A6E9C
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 58616
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace XLua
{
	public class CopyByValue // TypeDefIndex: 58690
	{
		// Fields
		public static CopyByValue Instance; // 0x00
	
		// Constructors
		public CopyByValue(); // 0x00000001841E1670-0x00000001841E1680
		static CopyByValue(); // 0x0000000184D4E3D0-0x0000000184D4E430
	
		// Methods
		public bool Pack(IntPtr buff, int offset, byte field); // 0x000000018B89E56C-0x000000018B89E5D0
		public bool UnPack(IntPtr buff, int offset, out byte field); // 0x000000018B89ED38-0x000000018B89ED9C
		public bool Pack(IntPtr buff, int offset, sbyte field); // 0x000000018B89E4A8-0x000000018B89E50C
		public bool UnPack(IntPtr buff, int offset, out sbyte field); // 0x000000018B89ECC8-0x000000018B89ED38
		public bool Pack(IntPtr buff, int offset, short field); // 0x000000018B89E5D0-0x000000018B89E634
		public bool UnPack(IntPtr buff, int offset, out short field); // 0x000000018B89EC64-0x000000018B89ECC8
		public bool Pack(IntPtr buff, int offset, ushort field); // 0x000000018B89E7C4-0x000000018B89E828
		public bool UnPack(IntPtr buff, int offset, out ushort field); // 0x000000018B89E8F0-0x000000018B89E970
		public bool Pack(IntPtr buff, int offset, int field); // 0x0000000183B61630-0x0000000183B61690
		public bool UnPack(IntPtr buff, int offset, out int field); // 0x0000000183A1B1B0-0x0000000183A1B210
		public bool Pack(IntPtr buff, int offset, uint field); // 0x000000018B89E50C-0x000000018B89E56C
		public bool UnPack(IntPtr buff, int offset, out uint field); // 0x000000018B89E9D4-0x000000018B89EA44
		public bool Pack(IntPtr buff, int offset, long field); // 0x000000018B89E760-0x000000018B89E7C4
		public bool UnPack(IntPtr buff, int offset, out long field); // 0x000000018B89E88C-0x000000018B89E8F0
		public bool Pack(IntPtr buff, int offset, ulong field); // 0x000000018B89E6FC-0x000000018B89E760
		public bool UnPack(IntPtr buff, int offset, out ulong field); // 0x000000018B89EBF0-0x000000018B89EC64
		public bool Pack(IntPtr buff, int offset, float field); // 0x000000018B89E698-0x000000018B89E6FC
		public bool UnPack(IntPtr buff, int offset, out float field); // 0x000000018B89E970-0x000000018B89E9D4
		public bool Pack(IntPtr buff, int offset, double field); // 0x000000018B89E634-0x000000018B89E698
		public bool UnPack(IntPtr buff, int offset, out double field); // 0x000000018B89EB8C-0x000000018B89EBF0
		public bool Pack(IntPtr buff, int offset, decimal field); // 0x000000018B89E828-0x000000018B89E88C
		public bool UnPack(IntPtr buff, int offset, out decimal field); // 0x000000018B89EA44-0x000000018B89EB8C
		public bool IsStruct(System.Type type); // 0x0000000182F2A650-0x0000000182F2A6A0
	}

	public abstract class DelegateBridgeBase : LuaBase // TypeDefIndex: 58691
	{
		// Fields
		private System.Type firstKey; // 0x20
		private Delegate firstValue; // 0x28
		private Dictionary<System.Type, Delegate> bindTo; // 0x30
		public int errorFuncRef; // 0x38
	
		// Properties
		public bool IsDispose { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
	
		// Constructors
		public DelegateBridgeBase(int reference, LuaEnv luaenv); // 0x0000000183F20D50-0x0000000183F20D90
	
		// Methods
		public bool TryGetDelegate(System.Type key, out Delegate value); // 0x00000001844228D0-0x0000000184422940
		public void AddDelegate(System.Type key, Delegate value); // 0x0000000183608370-0x0000000183608420
		public virtual Delegate GetDelegateByType(System.Type type); // 0x00000001811EC580-0x00000001811EC590
	}

	public static class HotfixDelegateBridge // TypeDefIndex: 58692
	{
		// Methods
		public static bool xlua_get_hotfix_flag(int idx); // 0x000000018B89EF94-0x000000018B89F024
		public static DelegateBridge Get(int idx); // 0x000000018B89ED9C-0x000000018B89EE00
		public static void Set(int idx, DelegateBridge val); // 0x000000018B89EE00-0x000000018B89EF94
	}

	public class DelegateBridge : DelegateBridgeBase // TypeDefIndex: 58697
	{
		// Fields
		internal static DelegateBridge[] DelegateBridgeList; // 0x00
		public static bool Gen_Flag; // 0x08
		public static Func<DelegateBridge, System.Type, Delegate> GetDelegateTypeDelegate; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0<T1> // TypeDefIndex: 58693
		{
			// Fields
			public DelegateBridge __4__this;
			public T1 p1;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _ActionAfterGC_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0<T1, T2> // TypeDefIndex: 58694
		{
			// Fields
			public DelegateBridge __4__this;
			public T1 p1;
			public T2 p2;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _ActionAfterGC_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0<T1, T2, T3> // TypeDefIndex: 58695
		{
			// Fields
			public DelegateBridge __4__this;
			public T1 p1;
			public T2 p2;
			public T3 p3;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _ActionAfterGC_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0<T1, T2, T3, T4> // TypeDefIndex: 58696
		{
			// Fields
			public DelegateBridge __4__this;
			public T1 p1;
			public T2 p2;
			public T3 p3;
			public T4 p4;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _ActionAfterGC_b__0();
		}
	
		// Constructors
		public DelegateBridge(int reference, LuaEnv luaenv); // 0x00000001853932E8-0x00000001853932F0
		static DelegateBridge(); // 0x0000000184CF5740-0x0000000184CF57F0
	
		// Methods
		public void PCall(IntPtr L, int nArgs, int nResults, int errFunc); // 0x000000018329DBE0-0x000000018329E7E0
		public override Delegate GetDelegateByType(System.Type type); // 0x0000000183FC2290-0x0000000183FC22F0
		public void Action(); // 0x0000000183544810-0x0000000183544910
		public void Action<T1>(T1 p1);
		private void ActionAfterGC<T1>(T1 p1);
		public void Action<T1, T2>(T1 p1, T2 p2);
		private void ActionAfterGC<T1, T2>(T1 p1, T2 p2);
		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3);
		private void ActionAfterGC<T1, T2, T3>(T1 p1, T2 p2, T3 p3);
		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4);
		private void ActionAfterGC<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4);
		public TResult Func<TResult>();
		public TResult Func<T1, TResult>(T1 p1);
		public TResult Func<T1, T2, TResult>(T1 p1, T2 p2);
		public TResult Func<T1, T2, T3, TResult>(T1 p1, T2 p2, T3 p3);
		public TResult Func<T1, T2, T3, T4, TResult>(T1 p1, T2 p2, T3 p3, T4 p4);
	}

	public enum GenFlag // TypeDefIndex: 58698
	{
		No = 0,
		GCOptimize = 1
	}

	public class LuaCallCSharpAttribute : Attribute // TypeDefIndex: 58699
	{
		// Fields
		private GenFlag flag; // 0x10
	
		// Properties
		public GenFlag Flag { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
	
		// Constructors
		public LuaCallCSharpAttribute(GenFlag flag = GenFlag.No /* Metadata: 0x0234BE77 */); // 0x00000001814F51F0-0x00000001814F5220
	}

	public class CSharpCallLuaAttribute : Attribute // TypeDefIndex: 58700
	{
		// Constructors
		public CSharpCallLuaAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class BlackListAttribute : Attribute // TypeDefIndex: 58701
	{
		// Constructors
		public BlackListAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Flags]
	public enum OptimizeFlag // TypeDefIndex: 58702
	{
		Default = 0,
		PackAsTable = 1,
		Custom = 2
	}

	public class GCOptimizeAttribute : Attribute // TypeDefIndex: 58703
	{
		// Fields
		private OptimizeFlag flag; // 0x10
	
		// Properties
		public OptimizeFlag Flag { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
	
		// Constructors
		public GCOptimizeAttribute(OptimizeFlag flag = OptimizeFlag.Default /* Metadata: 0x0234BE7B */); // 0x00000001814F51F0-0x00000001814F5220
	}

	public class ReflectionUseAttribute : Attribute // TypeDefIndex: 58704
	{
		// Constructors
		public ReflectionUseAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class DoNotGenAttribute : Attribute // TypeDefIndex: 58705
	{
		// Constructors
		public DoNotGenAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class AdditionalPropertiesAttribute : Attribute // TypeDefIndex: 58706
	{
		// Constructors
		public AdditionalPropertiesAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Flags]
	public enum HotfixFlag // TypeDefIndex: 58707
	{
		Stateless = 0,
		Stateful = 1,
		ValueTypeBoxing = 2,
		IgnoreProperty = 4,
		IgnoreNotPublic = 8,
		Inline = 16,
		IntKey = 32,
		AdaptByDelegate = 64,
		IgnoreCompilerGenerated = 128,
		NoBaseProxy = 256
	}

	public class HotfixAttribute : Attribute // TypeDefIndex: 58708
	{
		// Fields
		private HotfixFlag flag; // 0x10
	
		// Properties
		public HotfixFlag Flag { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
	
		// Constructors
		public HotfixAttribute(HotfixFlag e = HotfixFlag.Stateless /* Metadata: 0x0234BE89 */); // 0x00000001814F51F0-0x00000001814F5220
	}

	[AttributeUsage(AttributeTargets.Delegate)]
	internal class HotfixDelegateAttribute : Attribute // TypeDefIndex: 58709
	{
		// Constructors
		public HotfixDelegateAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class SysGenConfig // TypeDefIndex: 58710
	{
		// Properties
		[GCOptimize(OptimizeFlag.Default)]
		private static List<System.Type> GCOptimize { get; } // 0x000000018B8A4F10-0x000000018B8A5104 
		[AdditionalProperties]
		private static Dictionary<System.Type, List<string>> AdditionalProperties { get; } // 0x000000018B8A4C8C-0x000000018B8A4F10 
	}

	public class InternalGlobals // TypeDefIndex: 58713
	{
		// Fields
		internal static byte[] strBuff; // 0x00
		public static TryArrayGet genTryArrayGetPtr; // 0x08
		public static TryArraySet genTryArraySetPtr; // 0x10
		internal static int LUA_REGISTRYINDEX; // 0x18
		internal static Dictionary<string, string> supportOp; // 0x20
		public static Dictionary<System.Type, IEnumerable<MethodInfo>> extensionMethodMap; // 0x28
		internal static lua_CSFunction LazyReflectionWrap; // 0x30
	
		// Nested types
		public delegate bool TryArrayGet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int index); // TypeDefIndex: 58711; 0x00000001814D3FD0-0x00000001814D3FF0
	
		public delegate bool TryArraySet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx); // TypeDefIndex: 58712; 0x00000001814CDD50-0x00000001814CDD70
	
		// Constructors
		public InternalGlobals(); // 0x00000001841E1670-0x00000001841E1680
		static InternalGlobals(); // 0x00000001847729E0-0x0000000184772F00
	}

	public abstract class LuaBase : IDisposable // TypeDefIndex: 58714
	{
		// Fields
		public bool disposed; // 0x10
		public readonly int luaReference; // 0x14
		public readonly LuaEnv luaEnv; // 0x18
	
		// Constructors
		public LuaBase(int reference, LuaEnv luaenv); // 0x00000001853932C0-0x00000001853932D0
	
		// Methods
		~LuaBase(); // 0x00000001832EF070-0x00000001832EF120
		public void Dispose(); // 0x00000001832EF250-0x00000001832EF310
		public virtual void Dispose(bool disposeManagedResources); // 0x00000001832EF310-0x00000001832EF3E0
		public override bool Equals(object o); // 0x000000018B89F190-0x000000018B89F2C8
		public override int GetHashCode(); // 0x000000018B89F2C8-0x000000018B89F37C
		public virtual void push(IntPtr L); // 0x000000018B89F37C-0x000000018B89F3D0
	}

	public struct lua_debug // TypeDefIndex: 58715
	{
		// Fields
		public int eventCode; // 0x00
		public IntPtr name; // 0x08
		public IntPtr namewhat; // 0x10
		public IntPtr what; // 0x18
		public IntPtr source; // 0x20
		public int currentline; // 0x28
		public int linedefined; // 0x2C
	}

	public struct lua_state // TypeDefIndex: 58716
	{
		// Fields
		public IntPtr ptr; // 0x00
		public byte byte1; // 0x08
		public byte byte2; // 0x09
		public byte status; // 0x0A
		public byte allowhook; // 0x0B
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int lua_Hook(IntPtr L, ref lua_debug ar); // TypeDefIndex: 58717; 0x00000001815802E0-0x00000001815802F0

	public static class LuaDeadLoopCheck // TypeDefIndex: 58719
	{
		// Fields
		private static Thread s_checkThread; // 0x00
		private static Stack<Stopwatch> s_costStack; // 0x08
		private static SpinLock s_lockObj; // 0x10
		private static bool s_isCheck; // 0x14
		private static IntPtr L; // 0x18
		private static ObjectPool<Stopwatch> s_stopwatchPool; // 0x20
		private static int s_allowHookOffset; // 0x28
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58718
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Stopwatch> __9__7_0; // 0x08
			public static Action<Stopwatch> __9__7_1; // 0x10
			public static Action<Stopwatch> __9__7_2; // 0x18
	
			// Constructors
			static __c(); // 0x0000000184D4A1D0-0x0000000184D4A230
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Stopwatch _EnableCheck_b__7_0(); // 0x0000000184A3E0F0-0x0000000184A3E130
			internal void _EnableCheck_b__7_1(Stopwatch sw); // 0x000000018329ECB0-0x000000018329ED00
			internal void _EnableCheck_b__7_2(Stopwatch sw); // 0x000000018329E930-0x000000018329E990
		}
	
		// Methods
		public static void EnableCheck(IntPtr L); // 0x0000000183B26BD0-0x0000000183B27100
		[AOT.MonoPInvokeCallback(typeof(XLua.lua_Hook))]
		public static int LuaHook(IntPtr L, ref lua_debug ar); // 0x000000018B8A02CC-0x000000018B8A0528
		public static void DisableCheck(IntPtr L); // 0x000000018B8A0294-0x000000018B8A02CC
		public static void PushTime(); // 0x000000018329EB90-0x000000018329ECB0
		public static void PopTime(); // 0x000000018329E7E0-0x000000018329E930
		public static void CheckDeadLoop(); // 0x0000000182EFE970-0x0000000182EFEC80
	}

	public interface ILoadLuaProxy // TypeDefIndex: 58720
	{
		// Methods
		byte[] LoadLua(string name);
	}

	public class LoadLuaProxyModule // TypeDefIndex: 58721
	{
		// Fields
		private static ILoadLuaProxy s_loadLuaProxy; // 0x00
	
		// Constructors
		public LoadLuaProxyModule(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void RegisterProxy(ILoadLuaProxy loadLuaProxy); // 0x000000018B89F05C-0x000000018B89F0AC
		public static ILoadLuaProxy GetLoadLuaProxy(); // 0x000000018B89F024-0x000000018B89F05C
	}

	public class LuaEnv : IDisposable // TypeDefIndex: 58724
	{
		// Fields
		public const string CSHARP_NAMESPACE = "xlua_csharp_namespace"; // Metadata: 0x0234BEAF
		public const string MAIN_SHREAD = "xlua_main_thread"; // Metadata: 0x0234BEC5
		private LuaMultithreadingGC m_luaMultithreadingGC; // 0x10
		public static bool ENABLE_MULTITHREAD_GC; // 0x00
		public bool isQuittingApplication; // 0x18
		public IntPtr rawL; // 0x20
		private LuaTable _G; // 0x28
		public ObjectTranslator translator; // 0x30
		public int errorFuncRef; // 0x38
		private const int LIB_VERSION_EXPECT = 105; // Metadata: 0x0234BED6
		private static List<Action<LuaEnv, ObjectTranslator>> initers; // 0x08
		private Dictionary<long, string> _stringCache; // 0x40
		private long _stringCacheMemory; // 0x48
		private readonly long _freeSize; // 0x50
		private int last_check_point; // 0x58
		private int max_check_per_tick; // 0x5C
		private Func<object, bool> object_valid_checker; // 0x60
		private bool disposed; // 0x68
		private Queue<GCAction> refQueue; // 0x70
		internal List<CustomLoader> customLoaders; // 0x78
		internal Dictionary<string, lua_CSFunction> buildin_initer; // 0x80
	
		// Properties
		public IntPtr L { get; } // 0x000000018329D7C0-0x000000018329D7E0 
		public LuaTable Global { get; } // 0x0000000184D86240-0x0000000184D86250 
		public int GcPause { get; set; } // 0x000000018B8A0C40-0x000000018B8A0CC0 0x000000018B8A0D40-0x000000018B8A0DA0
		public int GcStepmul { get; set; } // 0x000000018B8A0CC0-0x000000018B8A0D40 0x000000018B8A0DA0-0x000000018B8A0E00
		public int Memroy { get; } // 0x00000001838EF8C0-0x00000001838EF910 
	
		// Nested types
		internal struct GCAction // TypeDefIndex: 58722
		{
			// Fields
			public int Reference; // 0x00
			public bool IsDelegate; // 0x04
		}
	
		public delegate byte[] CustomLoader(ref string filepath); // TypeDefIndex: 58723; 0x00000001814E2060-0x00000001814E2070
	
		// Constructors
		public LuaEnv(); // 0x0000000183601B70-0x0000000183602800
		static LuaEnv(); // 0x0000000184D4F970-0x0000000184D4F9E0
	
		// Methods
		public bool IsEnableMultithreadGC(); // 0x0000000183A73F30-0x0000000183A73FA0
		public bool IsLuaGCing(); // 0x000000018329DBC0-0x000000018329DBE0
		public bool AddLuaEventAfterGCDo(UnityAction action); // 0x000000018488B670-0x000000018488B6A0
		public void RemoveLuaEventAfterGCDo(UnityAction action); // 0x000000018B8A0A40-0x000000018B8A0A54
		public void AddOnceLuaEventAfterGCDo(UnityAction action); // 0x000000018423A460-0x000000018423A4A0
		public void CriticalLuaCallWaitLuaGC(); // 0x000000018B8A0548-0x000000018B8A05A4
		public void MainThreadWait(); // 0x000000018B8A092C-0x000000018B8A0940
		public void StopMultiGC(); // 0x000000018B8A0AF8-0x000000018B8A0B28
		public static void AddIniter(Action<LuaEnv, ObjectTranslator> initer); // 0x0000000184810000-0x0000000184810150
		public T LoadString<T>(byte[] chunk, string chunkName = "chunk" /* Metadata: 0x0234BE8A */, LuaTable env = null);
		public T LoadString<T>(string chunk, string chunkName = "chunk" /* Metadata: 0x0234BE90 */, LuaTable env = null);
		public LuaFunction LoadString(string chunk, string chunkName = "chunk" /* Metadata: 0x0234BE96 */, LuaTable env = null); // 0x000000018B8A08BC-0x000000018B8A092C
		public object[] DoString(byte[] chunk, string chunkName = "chunk" /* Metadata: 0x0234BE9C */, LuaTable env = null); // 0x0000000183600E10-0x0000000183600F50
		public object[] DoString(string chunk, string chunkName = "chunk" /* Metadata: 0x0234BEA2 */, LuaTable env = null); // 0x000000018B8A078C-0x000000018B8A07FC
		public object[] DoFile(string luaFile, string chunkName = "chunk" /* Metadata: 0x0234BEA8 */, LuaTable env = null); // 0x0000000183600CF0-0x0000000183600DA0
		public object[] DoFile(string luaFile, LuaTable env = null); // 0x000000018539321C-0x000000018539323C
		public object[] CallGlobalFunction(string funcName); // 0x000000018321C3A0-0x000000018321C420
		public object[] CallGlobalFunction<T0>(string funcName, T0 param0);
		public void SetGlobalTable<K, V>(K key, V value);
		public V GetGlobalTable<K, V>(K key);
		public void InitCacheString(); // 0x0000000183600960-0x0000000183600B80
		public string TryGetLuaString(IntPtr p); // 0x0000000183C16CA0-0x0000000183C16DC0
		public void RefString(IntPtr L, IntPtr strPoint, int index, string ss); // 0x0000000183608420-0x00000001836085E0
		public void ReleaseStringCache(bool dispose = true /* Metadata: 0x0234BEAE */); // 0x0000000183600890-0x0000000183600960
		public void AutoFreeStringCache(); // 0x000000018301FCD0-0x000000018301FCF0
		private void AddSearcher(lua_CSFunction searcher, int index); // 0x0000000183602870-0x0000000183602A10
		public void Alias(System.Type type, string alias); // 0x000000018B8A0528-0x000000018B8A0548
		private static bool ObjectValidCheck(object obj); // 0x0000000183B14BD0-0x0000000183B14C70
		public void ClearAllUserdata(); // 0x0000000184034F70-0x0000000184034FB0
		public void CleanTick(); // 0x000000018301FDD0-0x0000000183020120
		public void GC(); // 0x000000018B8A0850-0x000000018B8A0858
		public LuaTable NewTable(); // 0x000000018B8A0940-0x000000018B8A0A40
		public void WaitForGCComplete(); // 0x000000018B8A0C38-0x000000018B8A0C40
		public void Dispose(); // 0x000000018B8A0700-0x000000018B8A078C
		public virtual void Dispose(bool dispose); // 0x000000018B8A05A4-0x000000018B8A0700
		public void ThrowExceptionFromError(int oldTop); // 0x000000018B8A0B28-0x000000018B8A0C38
		internal void equeueGCAction(GCAction action); // 0x00000001832EED00-0x00000001832EF070
		public void AddLoader(CustomLoader loader); // 0x0000000184D54440-0x0000000184D544A0
		public void AddBuildin(string name, lua_CSFunction initer); // 0x0000000183601A00-0x0000000183601AA0
		public void FullGc(); // 0x000000018B8A07FC-0x000000018B8A0850
		public void StopGc(); // 0x000000018B8A0AA8-0x000000018B8A0AF8
		public void RestartGc(); // 0x000000018B8A0A54-0x000000018B8A0AA8
		public bool GcStep(int data); // 0x000000018B8A0858-0x000000018B8A08BC
	}

	[Serializable]
	public class LuaException : Exception // TypeDefIndex: 58725
	{
		// Constructors
		public LuaException(string message); // 0x000000018B8A0E00-0x000000018B8A0E5C
	}

	public class LuaFunction : LuaBase // TypeDefIndex: 58728
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0<T> // TypeDefIndex: 58726
		{
			// Fields
			public LuaFunction __4__this;
			public T a;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal void _ActionAfterGC_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0<T1, T2> // TypeDefIndex: 58727
		{
			// Fields
			public LuaFunction __4__this;
			public T1 a1;
			public T2 a2;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _ActionAfterGC_b__0();
		}
	
		// Constructors
		public LuaFunction(int reference, LuaEnv luaenv); // 0x00000001853932C0-0x00000001853932D0
	
		// Methods
		public void Action<T>(T a);
		private void ActionAfterGC<T>(T a);
		public TResult Func<T, TResult>(T a);
		public void Action<T1, T2>(T1 a1, T2 a2);
		private void ActionAfterGC<T1, T2>(T1 a1, T2 a2);
		public TResult Func<T1, T2, TResult>(T1 a1, T2 a2);
		public object[] Call(object[] args, System.Type[] returnTypes); // 0x0000000183544DE0-0x0000000183544FA0
		public object[] Call(params object[] args); // 0x0000000185391968-0x0000000185391974
		public T Cast<T>();
		public void SetEnv(LuaTable env); // 0x000000018B8A0E5C-0x000000018B8A0F14
		public override void push(IntPtr L); // 0x0000000184D543E0-0x0000000184D54440
		public override string ToString(); // 0x000000018B8A0F14-0x000000018B8A0F5C
	}

	public class LuaTable : LuaBase // TypeDefIndex: 58731
	{
		// Properties
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[string field] { get => default; set {} } // 0x000000018B8A1AFC-0x000000018B8A1B44 0x000000018B8A1C78-0x000000018B8A1CD0
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[object field] { get => default; set {} } // 0x000000018B8A1B44-0x000000018B8A1B8C 0x000000018B8A1C20-0x000000018B8A1C78
		public int Length { get; } // 0x000000018B8A1B8C-0x000000018B8A1C20 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetKeys_d__15 : IEnumerable<object>, IEnumerator<object> // TypeDefIndex: 58729
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public LuaTable __4__this; // 0x28
			private IntPtr _L_5__2; // 0x30
			private ObjectTranslator _translator_5__3; // 0x38
			private int _oldTop_5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetKeys_d__15(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B8A528C-0x000000018B8A53F0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B8A5484-0x000000018B8A54D0
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator(); // 0x000000018B8A53F0-0x000000018B8A547C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B8A547C-0x000000018B8A5484
		}
	
		[CompilerGenerated]
		private sealed class _GetKeys_d__16<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 58730
		{
			// Fields
			private int __1__state;
			private T __2__current;
			private int __l__initialThreadId;
			public LuaTable __4__this;
			private IntPtr _L_5__2;
			private ObjectTranslator _translator_5__3;
			private int _oldTop_5__4;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetKeys_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Constructors
		public LuaTable(int reference, LuaEnv luaenv); // 0x00000001853932C0-0x00000001853932D0
	
		// Methods
		public void Get<TKey, TValue>(TKey key, out ref TValue value);
		public bool ContainsKey<TKey>(TKey key);
		public void Set<TKey, TValue>(TKey key, TValue value);
		public T GetInPath<T>(string path);
		public void SetInPath<T>(string path, T val);
		public void ForEach<TKey, TValue>(Action<TKey, TValue> action);
		[IteratorStateMachine(typeof(_GetKeys_d__15))]
		public IEnumerable GetKeys(); // 0x000000018B8A1974-0x000000018B8A19E4
		[IteratorStateMachine(typeof(_GetKeys_d__16<T>))]
		public IEnumerable<T> GetKeys<T>();
		public T Get<T>(object key);
		public TValue Get<TKey, TValue>(TKey key);
		public TValue Get<TValue>(string key);
		public void SetMetaTable(LuaTable metaTable); // 0x000000018B8A19E4-0x000000018B8A1AB4
		public T Cast<T>();
		public override void push(IntPtr L); // 0x000000018427F7E0-0x000000018427F820
		public override string ToString(); // 0x000000018B8A1AB4-0x000000018B8A1AFC
		public ObjectTranslator GetTranslator(); // 0x00000001832F12A0-0x00000001832F1320
	}

	public interface IOverloadMethodWrap // TypeDefIndex: 58732
	{
		// Properties
		bool InitedForDelegateCall { get; }
		bool HasDefalutValue { get; }
	
		// Methods
		int Call(IntPtr L, ObjectTranslator translator);
		bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x0234BED8 */);
	}

	public class OverloadMethodWrapBase // TypeDefIndex: 58733
	{
		// Fields
		protected ObjectTranslator translator; // 0x10
		protected MethodBase method; // 0x18
	
		// Constructors
		public OverloadMethodWrapBase(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static IOverloadMethodWrap CreateMethodWrap(ObjectTranslator translator, MethodBase method, System.Type target); // 0x0000000182F2C470-0x0000000182F2C530
	}

	public class OverloadMethodWrapForDelegate : OverloadMethodWrapBase, IOverloadMethodWrap // TypeDefIndex: 58734
	{
		// Fields
		private List<System.Type> castTypes; // 0x20
		private Delegate @delegate; // 0x28
		private LuaGenericDelegateCaller.LuaGenericDelegateCall caller; // 0x30
		[CompilerGenerated]
		private int _OptionParamCount_k__BackingField; // 0x38
		[CompilerGenerated]
		private object[] _DefalutValue_k__BackingField; // 0x40
		[CompilerGenerated]
		private bool _HasDefalutValue_k__BackingField; // 0x48
		[CompilerGenerated]
		private bool[] _OutParamFlags_k__BackingField; // 0x50
	
		// Properties
		public bool InitedForDelegateCall { get; } // 0x0000000183FB3DE0-0x0000000183FB3DF0 
		public List<System.Type> CastTypes { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public int OptionParamCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		public object[] DefalutValue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public bool HasDefalutValue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
		public bool[] OutParamFlags { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
	
		// Constructors
		public OverloadMethodWrapForDelegate(MethodInfo method); // 0x0000000182F2C410-0x0000000182F2C470
	
		// Methods
		public static OverloadMethodWrapForDelegate TryGetWrapForDelegate(MethodInfo method); // 0x0000000182F2CE00-0x0000000182F2D380
		public void InitForDefaultValue(); // 0x0000000184281250-0x00000001842815A0
		public int Call(IntPtr L, ObjectTranslator translator); // 0x000000018329BD30-0x000000018329C0B0
		public bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x0234BED9 */); // 0x0000000182FFF600-0x0000000182FFF610
	}

	public class OverloadMethodWrapForReflection : OverloadMethodWrapBase, IOverloadMethodWrap // TypeDefIndex: 58735
	{
		// Fields
		private ObjectCheck[] checkArray; // 0x20
		private ObjectCast[] castArray; // 0x28
		private System.Type targetType; // 0x30
		private int[] inPosArray; // 0x38
		private int[] outPosArray; // 0x40
		private bool[] isOptionalArray; // 0x48
		private object[] defaultValueArray; // 0x50
		private bool isVoid; // 0x58
		private int luaStackPosStart; // 0x5C
		private bool targetNeeded; // 0x60
		private object[] args; // 0x68
		private int[] refPos; // 0x70
		private System.Type paramsType; // 0x78
	
		// Properties
		public bool InitedForDelegateCall { get; } // 0x00000001812081B0-0x0000000181208610 
		public bool HasDefalutValue { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public OverloadMethodWrapForReflection(System.Type target, MethodBase methodInfo); // 0x00000001844C5110-0x00000001844C5150
	
		// Methods
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters); // 0x0000000182F2C530-0x0000000182F2CE00
		public int Call(IntPtr L, ObjectTranslator translator); // 0x000000018329C0E0-0x000000018329C9E0
		public bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x0234BEDA */); // 0x000000018329C0B0-0x000000018329C0E0
		public bool Check(IntPtr L); // 0x0000000183DC80D0-0x0000000183DC8230
		public bool CheckForNoOverride(IntPtr L); // 0x000000018329B2F0-0x000000018329B440
	}

	public class OverloadMethodWrap // TypeDefIndex: 58736
	{
		// Fields
		private ObjectTranslator translator; // 0x10
		private System.Type targetType; // 0x18
		private MethodBase method; // 0x20
		private ObjectCheck[] checkArray; // 0x28
		private ObjectCast[] castArray; // 0x30
		private List<System.Type> castTypes; // 0x38
		private Delegate @delegate; // 0x40
		private LuaGenericDelegateCaller.LuaGenericDelegateCall caller; // 0x48
		private int[] inPosArray; // 0x50
		private int[] outPosArray; // 0x58
		private bool[] isOptionalArray; // 0x60
		private object[] defaultValueArray; // 0x68
		private bool isVoid; // 0x70
		private int luaStackPosStart; // 0x74
		private bool targetNeeded; // 0x78
		private object[] args; // 0x80
		private int[] refPos; // 0x88
		private System.Type paramsType; // 0x90
		[CompilerGenerated]
		private int _OptionParamCount_k__BackingField; // 0x98
		[CompilerGenerated]
		private object[] _DefalutValue_k__BackingField; // 0xA0
		[CompilerGenerated]
		private bool _IsInited_k__BackingField; // 0xA8
		[CompilerGenerated]
		private bool _HasDefalutValue_k__BackingField; // 0xA9
	
		// Properties
		public bool InitedForDelegateCall { get; } // 0x00000001890BCB14-0x00000001890BCB20 
		public MethodBase Method { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public List<System.Type> CastTypes { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		public int OptionParamCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862D0-0x0000000184D862E0 0x0000000184D86300-0x0000000184D86310
		public object[] DefalutValue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
		public bool IsInited { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D90720-0x0000000184D90730 0x0000000184D90750-0x0000000184D90760
		public bool HasDefalutValue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182ED0880-0x0000000182ED0890 0x0000000184D90740-0x0000000184D90750
	
		// Constructors
		public OverloadMethodWrap(ObjectTranslator translator, System.Type targetType, MethodBase method); // 0x000000018B8A4C40-0x000000018B8A4C8C
	
		// Methods
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters); // 0x000000018B8A417C-0x000000018B8A4C40
		public void InitForDefaultValue(); // 0x000000018B8A38B0-0x000000018B8A3B7C
		public void InitForDelegateCallMethod(); // 0x000000018B8A3B7C-0x000000018B8A417C
		public int Call(IntPtr L); // 0x000000018B8A30EC-0x000000018B8A38B0
		public int CallForDelegate(IntPtr L, ObjectTranslator translator); // 0x000000018B8A2F74-0x000000018B8A30EC
	}

	public class MethodWrap // TypeDefIndex: 58737
	{
		// Fields
		private string methodName; // 0x10
		private IOverloadMethodWrap[] overloads; // 0x18
		private System.Type targetType; // 0x20
		private MethodBase[] allMethods; // 0x28
		private bool forceCheck; // 0x30
		private bool initedForDelegateCall; // 0x31
		private bool haveDefault; // 0x32
	
		// Constructors
		public MethodWrap(string methodName, List<MethodBase> overloads, System.Type targetType, bool forceCheck); // 0x0000000182F320F0-0x0000000182F32150
	
		// Methods
		private void _InitForDelegateCall(); // 0x0000000183FB3C80-0x0000000183FB3DE0
		public int Call(IntPtr L); // 0x000000018329B7B0-0x000000018329BD30
	}

	public class MethodWrapsCache // TypeDefIndex: 58741
	{
		// Fields
		public static Dictionary<System.Type, lua_CSFunction> CodeGenConstructorMap; // 0x00
		private ObjectTranslator translator; // 0x10
		private ObjectCheckers objCheckers; // 0x18
		private ObjectCasters objCasters; // 0x20
		private Dictionary<System.Type, lua_CSFunction> constructorCache; // 0x28
		private Dictionary<System.Type, Dictionary<string, lua_CSFunction>> methodsCache; // 0x30
		private Dictionary<System.Type, lua_CSFunction> delegateCache; // 0x38
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 58738
		{
			// Fields
			public MethodWrapsCache __4__this; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetConstructorWrap_b__0(IntPtr L); // 0x000000018B8A54D0-0x000000018B8A5524
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_1 // TypeDefIndex: 58739
		{
			// Fields
			public lua_CSFunction ctor; // 0x10
			public __c__DisplayClass11_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass11_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetConstructorWrap_b__1(IntPtr L); // 0x00000001848BB230-0x00000001848BB2C0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 58740
		{
			// Fields
			public MethodWrapsCache __4__this; // 0x10
			public System.Type type; // 0x18
			public string eventName; // 0x20
			public bool is_static; // 0x28
			public EventInfo eventInfo; // 0x30
			public int start_idx; // 0x38
			public MethodInfo add; // 0x40
			public MethodInfo remove; // 0x48
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetEventWrap_b__0(IntPtr L); // 0x000000018B8A5640-0x000000018B8A5B58
		}
	
		// Constructors
		static MethodWrapsCache(); // 0x0000000184A22640-0x0000000184A226D0
		public MethodWrapsCache(ObjectTranslator translator, ObjectCheckers objCheckers, ObjectCasters objCasters); // 0x0000000184A226D0-0x0000000184A22810
	
		// Methods
		public static void AddCodeGenConstructor(System.Type type, lua_CSFunction lua_CSFunction); // 0x000000018B8A1CD0-0x000000018B8A1DD0
		public static void ClearCodeGenConstructorMap(); // 0x000000018B8A1DD0-0x000000018B8A1E34
		public lua_CSFunction GetConstructorWrap(System.Type type); // 0x0000000183605D90-0x00000001836060D0
		public lua_CSFunction GetMethodWrap(System.Type type, string methodName); // 0x000000018B8A218C-0x000000018B8A23D4
		public lua_CSFunction GetMethodWrapInCache(System.Type type, string methodName); // 0x000000018B8A2034-0x000000018B8A218C
		public lua_CSFunction GetDelegateWrap(System.Type type); // 0x000000018B8A1E34-0x000000018B8A2034
		public lua_CSFunction GetEventWrap(System.Type type, string eventName); // 0x0000000183600400-0x00000001836006D0
		public MethodWrap _GenMethodWrap(System.Type type, string methodName, IEnumerable<MemberInfo> methodBases, bool forceCheck = false /* Metadata: 0x0234BEDB */); // 0x0000000182F31950-0x0000000182F31D10
		private static bool tryMakeGenericMethod(ref MethodBase method); // 0x000000018B8A23D4-0x000000018B8A25E0
	}

	public delegate bool ObjectCheck(IntPtr L, int idx); // TypeDefIndex: 58742; 0x00000001815802E0-0x00000001815802F0

	public delegate object ObjectCast(IntPtr L, int idx, object target); // TypeDefIndex: 58743; 0x00000001814F3120-0x00000001814F3140

	public class ObjectCheckers // TypeDefIndex: 58746
	{
		// Fields
		private Dictionary<System.Type, ObjectCheck> checkersMap; // 0x10
		private ObjectTranslator translator; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 58744
		{
			// Fields
			public ObjectCheckers __4__this; // 0x10
			public System.Type type; // 0x18
			public ObjectCheck fixTypeCheck; // 0x20
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _genChecker_b__0(IntPtr L, int idx); // 0x0000000183299A40-0x0000000183299B30
			internal bool _genChecker_b__1(IntPtr L, int idx); // 0x000000018434B0B0-0x000000018434B130
			internal bool _genChecker_b__2(IntPtr L, int idx); // 0x0000000183F70F10-0x0000000183F70F90
			internal bool _genChecker_b__3(IntPtr L, int idx); // 0x000000018B8A5524-0x000000018B8A55C0
			internal bool _genChecker_b__4(IntPtr L, int idx); // 0x0000000184192E50-0x0000000184192EF0
			internal bool _genChecker_b__5(IntPtr L, int idx); // 0x00000001841AE0D0-0x00000001841AE170
			internal bool _genChecker_b__6(IntPtr L, int idx); // 0x000000018B8A55C0-0x000000018B8A5640
			internal bool _genChecker_b__7(IntPtr L, int idx); // 0x0000000183299530-0x00000001832995D0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 58745
		{
			// Fields
			public ObjectCheck oc; // 0x10
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _genNullableChecker_b__0(IntPtr L, int idx); // 0x000000018B8A5B58-0x000000018B8A5BD8
		}
	
		// Constructors
		public ObjectCheckers(ObjectTranslator translator); // 0x0000000183602A10-0x0000000183603370
	
		// Methods
		private static bool objectCheck(IntPtr L, int idx); // 0x0000000182FFF600-0x0000000182FFF610
		private bool luaTableCheck(IntPtr L, int idx); // 0x000000018B8A2E94-0x000000018B8A2F74
		private bool numberCheck(IntPtr L, int idx); // 0x00000001840B5BE0-0x00000001840B5C50
		private bool decimalCheck(IntPtr L, int idx); // 0x000000018B8A2CE0-0x000000018B8A2D60
		private bool strCheck(IntPtr L, int idx); // 0x0000000183FC2070-0x0000000183FC20F0
		private bool bytesCheck(IntPtr L, int idx); // 0x000000018B8A2C00-0x000000018B8A2CE0
		private bool boolCheck(IntPtr L, int idx); // 0x0000000184129F90-0x0000000184129FE0
		private bool int64Check(IntPtr L, int idx); // 0x0000000184188EB0-0x0000000184188F00
		private bool uint64Check(IntPtr L, int idx); // 0x0000000184188EB0-0x0000000184188F00
		private bool luaFunctionCheck(IntPtr L, int idx); // 0x000000018B8A2DB4-0x000000018B8A2E94
		private bool intptrCheck(IntPtr L, int idx); // 0x000000018B8A2D60-0x000000018B8A2DB4
		private ObjectCheck genChecker(System.Type type); // 0x00000001836044C0-0x0000000183604830
		public ObjectCheck genNullableChecker(ObjectCheck oc); // 0x0000000184A30C90-0x0000000184A30D40
		public void AddChecker(System.Type type, ObjectCheck oc); // 0x0000000184A3C880-0x0000000184A3C8F0
		public ObjectCheck GetChecker(System.Type type); // 0x0000000183299E60-0x000000018329A160
	}

	public class ObjectCasters // TypeDefIndex: 58751
	{
		// Fields
		private Dictionary<System.Type, ObjectCast> castersMap; // 0x10
		private ObjectTranslator translator; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 58747
		{
			// Fields
			public ObjectCasters __4__this; // 0x10
			public System.Type type; // 0x18
			public ObjectCast fixTypeGetter; // 0x20
	
			// Constructors
			public __c__DisplayClass23_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _genCaster_b__0(IntPtr L, int idx, object target); // 0x0000000183605A30-0x0000000183605B50
			internal object _genCaster_b__1(IntPtr L, int idx, object target); // 0x0000000183605CE0-0x0000000183605D90
			internal object _genCaster_b__2(IntPtr L, int idx, object target); // 0x000000018B8ADB5C-0x000000018B8ADC18
			internal object _genCaster_b__3(IntPtr L, int idx, object target); // 0x00000001847F20E0-0x00000001847F2190
			internal object _genCaster_b__4(IntPtr L, int idx, object target); // 0x0000000183605C80-0x0000000183605CE0
			internal object _genCaster_b__5(IntPtr L, int idx, object target); // 0x000000018B8ADC18-0x000000018B8ADF2C
			internal object _genCaster_b__6(IntPtr L, int idx, object target); // 0x00000001836055C0-0x0000000183605A30
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_1 // TypeDefIndex: 58748
		{
			// Fields
			public System.Type elementType; // 0x10
			public ObjectCast elementCaster; // 0x18
			public __c__DisplayClass23_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass23_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _genCaster_b__7(IntPtr L, int idx, object target); // 0x00000001836050E0-0x0000000183605350
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_2 // TypeDefIndex: 58749
		{
			// Fields
			public System.Type keyType; // 0x10
			public System.Type valueType; // 0x18
			public ObjectCast keyCaster; // 0x20
			public ObjectCast valueCaster; // 0x28
			public __c__DisplayClass23_0 CS___8__locals2; // 0x30
	
			// Constructors
			public __c__DisplayClass23_2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _genCaster_b__8(IntPtr L, int idx, object target); // 0x000000018B8ADF2C-0x000000018B8AE218
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 58750
		{
			// Fields
			public ObjectCast oc; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal object _genNullableCaster_b__0(IntPtr L, int idx, object target); // 0x000000018B8AE218-0x000000018B8AE2A8
		}
	
		// Constructors
		public ObjectCasters(ObjectTranslator translator); // 0x0000000183603370-0x0000000183603D20
	
		// Methods
		private static object charCaster(IntPtr L, int idx, object target); // 0x000000018B8A26EC-0x000000018B8A275C
		private static object sbyteCaster(IntPtr L, int idx, object target); // 0x000000018B8A29CC-0x000000018B8A2A3C
		private static object byteCaster(IntPtr L, int idx, object target); // 0x000000018B8A267C-0x000000018B8A26EC
		private static object shortCaster(IntPtr L, int idx, object target); // 0x000000018B8A2A3C-0x000000018B8A2AAC
		private static object ushortCaster(IntPtr L, int idx, object target); // 0x000000018B8A2AFC-0x000000018B8A2B6C
		private static object intCaster(IntPtr L, int idx, object target); // 0x00000001834DC170-0x00000001834DC1C0
		private static object uintCaster(IntPtr L, int idx, object target); // 0x000000018B8A2AAC-0x000000018B8A2AFC
		private static object longCaster(IntPtr L, int idx, object target); // 0x0000000182F332A0-0x0000000182F33300
		private static object ulongCaster(IntPtr L, int idx, object target); // 0x00000001834DC010-0x00000001834DC070
		private static object getDouble(IntPtr L, int idx, object target); // 0x000000018B8A28EC-0x000000018B8A295C
		private static object floatCaster(IntPtr L, int idx, object target); // 0x00000001834DC240-0x00000001834DC2A0
		private object decimalCaster(IntPtr L, int idx, object target); // 0x000000018B8A275C-0x000000018B8A27EC
		private static object getBoolean(IntPtr L, int idx, object target); // 0x00000001844606C0-0x0000000184460720
		private static object getString(IntPtr L, int idx, object target); // 0x00000001841A2A70-0x00000001841A2AB0
		private object getBytes(IntPtr L, int idx, object target); // 0x000000018B8A27EC-0x000000018B8A28EC
		private object getIntptr(IntPtr L, int idx, object target); // 0x000000018B8A295C-0x000000018B8A29CC
		private object getObject(IntPtr L, int idx, object target); // 0x00000001849B7D80-0x00000001849B7EE0
		private object getLuaTable(IntPtr L, int idx, object target); // 0x0000000183606E60-0x0000000183606FA0
		private object getLuaFunction(IntPtr L, int idx, object target); // 0x0000000183606CD0-0x0000000183606E10
		public void AddCaster(System.Type type, ObjectCast oc); // 0x0000000183602800-0x0000000183602870
		private ObjectCast genCaster(System.Type type); // 0x0000000183603D20-0x0000000183604170
		private ObjectCast genNullableCaster(ObjectCast oc); // 0x0000000184A30D40-0x0000000184A30DF0
		public ObjectCast GetCaster(System.Type type); // 0x0000000183298500-0x0000000183298710
	}

	public class ObjectPool // TypeDefIndex: 58753
	{
		// Fields
		private const int LIST_END = -1; // Metadata: 0x0234BEDC
		private const int ALLOCED = -2; // Metadata: 0x0234BEDD
		private Slot[] list; // 0x10
		private int freelist; // 0x18
		private int count; // 0x1C
		private List<object> needCleanImmediately; // 0x20
	
		// Properties
		public object this[int i] { get => default; } // 0x000000018B8A7F4C-0x000000018B8A7F80 
	
		// Nested types
		private struct Slot // TypeDefIndex: 58752
		{
			// Fields
			public int next; // 0x00
			public object obj; // 0x08
	
			// Constructors
			public Slot(int next, object obj); // 0x0000000186B17430-0x0000000186B17440
		}
	
		// Constructors
		public ObjectPool(); // 0x0000000184CE6E20-0x0000000184CE6ED0
	
		// Methods
		public void AddToNeedCleanImmediately(object obj); // 0x00000001832F0140-0x00000001832F0170
		public void Clear(); // 0x000000018B8A7EFC-0x000000018B8A7F4C
		private void extend_capacity(); // 0x0000000183AC9B40-0x0000000183AC9C00
		public int Add(object obj); // 0x00000001831342D0-0x00000001831346E0
		public bool TryGetValue(int index, out object obj); // 0x0000000183135180-0x00000001831352C0
		public object Get(int index); // 0x0000000183134170-0x00000001831341B0
		public object Remove(int index); // 0x0000000183134BA0-0x0000000183134D10
		public object Replace(int index, object o); // 0x00000001831346E0-0x0000000183134890
		public int Check(int check_pos, int max_check, Func<object, bool> checker, Dictionary<object, int> reverse_map); // 0x0000000183134D10-0x0000000183135180
		public void ClearAllUserdata(Func<object, bool> checker, Dictionary<object, int> reverse_map); // 0x0000000184034FB0-0x0000000184035120
	}

	internal class ReferenceEqualsComparer : IEqualityComparer<object> // TypeDefIndex: 58754
	{
		// Constructors
		public ReferenceEqualsComparer(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public new bool Equals(object o1, object o2); // 0x0000000183C05140-0x0000000183C05150
		public int GetHashCode(object obj); // 0x0000000184DA3AC0-0x0000000184DA3AD0
	}

	public class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 58755
	{
		// Fields
		private System.Type type; // 0x10
	
		// Constructors
		public MonoPInvokeCallbackAttribute(System.Type t); // 0x00000001853908C0-0x00000001853908D0
	}

	public enum LuaTypes // TypeDefIndex: 58756
	{
		LUA_TNONE = -1,
		LUA_TNIL = 0,
		LUA_TBOOLEAN = 1,
		LUA_TLIGHTUSERDATA = 2,
		LUA_TNUMBER = 3,
		LUA_TSTRING = 4,
		LUA_TTABLE = 5,
		LUA_TFUNCTION = 6,
		LUA_TUSERDATA = 7,
		LUA_TTHREAD = 8
	}

	public enum LuaGCOptions // TypeDefIndex: 58757
	{
		LUA_GCSTOP = 0,
		LUA_GCRESTART = 1,
		LUA_GCCOLLECT = 2,
		LUA_GCCOUNT = 3,
		LUA_GCCOUNTB = 4,
		LUA_GCSTEP = 5,
		LUA_GCSETPAUSE = 6,
		LUA_GCSETSTEPMUL = 7,
		LUA_GCISRUNNING = 9,
		LUA_GCGEN = 10,
		LUA_GCINC = 11
	}

	public enum LuaThreadStatus // TypeDefIndex: 58758
	{
		LUA_RESUME_ERROR = -1,
		LUA_OK = 0,
		LUA_YIELD = 1,
		LUA_ERRRUN = 2,
		LUA_ERRSYNTAX = 3,
		LUA_ERRMEM = 4,
		LUA_ERRERR = 5
	}

	public class LuaIndexes // TypeDefIndex: 58759
	{
		// Properties
		public static int LUA_REGISTRYINDEX { get; set; } // 0x000000018329B2B0-0x000000018329B2F0 0x0000000184D58F10-0x0000000184D58F70
	
		// Constructors
		public LuaIndexes(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class ObjectTranslator // TypeDefIndex: 58781
	{
		// Fields
		public MethodWrapsCache methodWrapsCache; // 0x10
		public ObjectCheckers objectCheckers; // 0x18
		public ObjectCasters objectCasters; // 0x20
		internal readonly ObjectPool objects; // 0x28
		internal readonly Dictionary<object, int> reverseMap; // 0x30
		internal LuaEnv luaEnv; // 0x38
		internal StaticLuaCallbacks metaFunctions; // 0x40
		internal List<Assembly> assemblies; // 0x48
		private lua_CSFunction importTypeFunction; // 0x50
		private lua_CSFunction loadAssemblyFunction; // 0x58
		private lua_CSFunction castFunction; // 0x60
		private static lua_CSFunction listPairFunction; // 0x00
		private static lua_CSFunction dicPairFunction; // 0x08
		private static lua_CSFunction normalPairFunction; // 0x10
		private readonly Dictionary<System.Type, Action<IntPtr>> delayWrap; // 0x68
		private readonly Dictionary<System.Type, Func<int, LuaEnv, LuaBase>> interfaceBridgeCreators; // 0x70
		private readonly Dictionary<System.Type, System.Type> aliasCfg; // 0x78
		private Dictionary<System.Type, bool> loaded_types; // 0x80
		public int cacheRef; // 0x88
		private MethodInfo[] genericAction; // 0x90
		private MethodInfo[] genericFunc; // 0x98
		private Dictionary<System.Type, Func<DelegateBridgeBase, Delegate>> delegateCreatorCache; // 0xA0
		private Dictionary<int, WeakReference> delegate_bridges; // 0xA8
		private int common_array_meta; // 0xB0
		private int common_delegate_meta; // 0xB4
		private int enumerable_pairs_func; // 0xB8
		private Dictionary<System.Type, int> typeIdMap; // 0xC0
		private Dictionary<int, System.Type> typeMap; // 0xC8
		private HashSet<System.Type> privateAccessibleFlags; // 0xD0
		private Dictionary<object, int> enumMap; // 0xD8
		public static int s_luaBuffOffset; // 0x18
		public static int s_nullableValueOffset; // 0x1C
		private Dictionary<System.Type, bool> _unmanagedTypes; // 0xE0
		private List<lua_CSFunction> fix_cs_functions; // 0xE8
		private List<LuaCSFunctionPtr> fix_cs_function_ptrs; // 0xF0
		public static bool enableLuaCSFunctionPtr; // 0x20
		public static GetDelegatePointer<object> getDelegatePointer; // 0x28
		private Dictionary<System.Type, PushCSObject> custom_push_funcs; // 0xF8
		private Dictionary<System.Type, GetCSObject> custom_get_funcs; // 0x100
		private Dictionary<System.Type, UpdateCSObject> custom_update_funcs; // 0x108
		private Dictionary<System.Type, Delegate> push_func_with_type; // 0x110
		private Dictionary<System.Type, Delegate> get_func_with_type; // 0x118
		private int decimal_type_id; // 0x120
	
		// Properties
		public ObjectPool Pools { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Nested types
		public enum LOGLEVEL // TypeDefIndex: 58760
		{
			NO = 0,
			INFO = 1,
			WARN = 2,
			ERROR = 3
		}
	
		private struct EnumerableWrapper // TypeDefIndex: 58761
		{
			// Fields
			public int Index; // 0x00
			public IList CurList; // 0x08
			public IEnumerator Enumerator; // 0x10
			public static Stack<EnumerableWrapper> enumerableStack; // 0x00
	
			// Constructors
			static EnumerableWrapper(); // 0x000000018B8A7444-0x000000018B8A74D0
	
			// Methods
			[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
			public static int ListCsPairs(IntPtr L); // 0x0000000183E77DB0-0x0000000183E84C50
			[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
			public static int DicCsPairs(IntPtr L); // 0x0000000183C35420-0x0000000183C35660
			[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
			public static int IEnumerableCsPairs(IntPtr L); // 0x0000000183E1DA60-0x0000000183E1DBB0
		}
	
		private struct FStructWrap<T> // TypeDefIndex: 58762
		{
			// Fields
			public T value;
	
			// Methods
			public IntPtr GetPtr();
		}
	
		private struct CSharpStructInLua // TypeDefIndex: 58763
		{
			// Fields
			public int fake_id; // 0x00
			public uint len; // 0x04
			public IntPtr ptr; // 0x08
		}
	
		public struct LuaCSFunctionPtr // TypeDefIndex: 58764
		{
			// Fields
			public IntPtr ptr; // 0x00
			public object target; // 0x08
		}
	
		public delegate ValueTuple<IntPtr, T1> GetDelegatePointer<T1>(Delegate d); // TypeDefIndex: 58765; 0x00000000-0x00000000
	
		public delegate void PushCSObject(IntPtr L, object obj); // TypeDefIndex: 58766; 0x00000001838E1420-0x00000001838E1430
	
		public delegate object GetCSObject(IntPtr L, int idx); // TypeDefIndex: 58767; 0x00000001815802E0-0x00000001815802F0
	
		public delegate void UpdateCSObject(IntPtr L, int idx, object obj); // TypeDefIndex: 58768; 0x0000000181546280-0x00000001815462A0
	
		public delegate bool CheckFunc<T>(IntPtr L, int idx); // TypeDefIndex: 58769; 0x00000000-0x00000000
	
		public delegate void GetFunc<T>(IntPtr L, int idx, out ref T val); // TypeDefIndex: 58770; 0x00000000-0x00000000
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 58771
		{
			// Fields
			public System.Type delegateType; // 0x10
			public MethodInfo genericMethodInfo; // 0x18
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Delegate _getCreatorUsingGeneric_b__7(DelegateBridgeBase o); // 0x000000018B8AE2A8-0x000000018B8AE2B8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_1 // TypeDefIndex: 58772
		{
			// Fields
			public MethodInfo methodInfo; // 0x10
			public __c__DisplayClass32_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass32_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Delegate _getCreatorUsingGeneric_b__8(DelegateBridgeBase o); // 0x00000001835D0700-0x00000001835D0740
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58773
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MethodInfo, bool> __9__32_1; // 0x08
			public static Func<MethodInfo, int> __9__32_2; // 0x10
			public static Func<MethodInfo, bool> __9__32_3; // 0x18
			public static Func<MethodInfo, int> __9__32_4; // 0x20
			public static Func<DelegateBridgeBase, Delegate> __9__32_0; // 0x28
			public static Func<DelegateBridgeBase, Delegate> __9__32_5; // 0x30
			public static Func<ParameterInfo, System.Type> __9__32_6; // 0x38
			public static Func<MethodInfo, bool> __9__33_0; // 0x40
	
			// Constructors
			static __c(); // 0x0000000184D47950-0x0000000184D479B0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _getCreatorUsingGeneric_b__32_1(MethodInfo m); // 0x00000001848E05D0-0x00000001848E0630
			internal int _getCreatorUsingGeneric_b__32_2(MethodInfo m); // 0x0000000183E647D0-0x0000000183E64880
			internal bool _getCreatorUsingGeneric_b__32_3(MethodInfo m); // 0x00000001848E0570-0x00000001848E05D0
			internal int _getCreatorUsingGeneric_b__32_4(MethodInfo m); // 0x0000000183E647D0-0x0000000183E64880
			internal Delegate _getCreatorUsingGeneric_b__32_0(DelegateBridgeBase x); // 0x00000001811EC580-0x00000001811EC590
			internal Delegate _getCreatorUsingGeneric_b__32_5(DelegateBridgeBase x); // 0x00000001811EC580-0x00000001811EC590
			internal System.Type _getCreatorUsingGeneric_b__32_6(ParameterInfo pinfo); // 0x0000000184CA3150-0x0000000184CA3170
			internal bool _getDelegate_b__33_0(MethodInfo m); // 0x000000018448D790-0x000000018448D820
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 58774
		{
			// Fields
			public System.Type delegateType; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_1 // TypeDefIndex: 58775
		{
			// Fields
			public MethodInfo foundMethod; // 0x10
			public __c__DisplayClass33_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass33_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Delegate _getDelegate_b__1(DelegateBridgeBase o); // 0x00000001835D0700-0x00000001835D0740
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__123<T> // TypeDefIndex: 58776
			where T : class
		{
			// Fields
			public static readonly __c__123<T> __9;
			public static Action<IntPtr, byte> __9__123_0;
			public static Action<IntPtr, sbyte> __9__123_1;
			public static Action<IntPtr, char> __9__123_2;
			public static Action<IntPtr, short> __9__123_3;
			public static Action<IntPtr, ushort> __9__123_4;
			public static Action<IntPtr, float> __9__123_5;
	
			// Constructors
			static __c__123();
			public __c__123();
	
			// Methods
			internal void _tryGetPushFuncByType_b__123_0(IntPtr L, byte v);
			internal void _tryGetPushFuncByType_b__123_1(IntPtr L, sbyte v);
			internal void _tryGetPushFuncByType_b__123_2(IntPtr L, char v);
			internal void _tryGetPushFuncByType_b__123_3(IntPtr L, short v);
			internal void _tryGetPushFuncByType_b__123_4(IntPtr L, ushort v);
			internal void _tryGetPushFuncByType_b__123_5(IntPtr L, float v);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__125<T> // TypeDefIndex: 58777
			where T : class
		{
			// Fields
			public static readonly __c__125<T> __9;
			public static Func<IntPtr, int, byte> __9__125_1;
			public static Func<IntPtr, int, sbyte> __9__125_2;
			public static Func<IntPtr, int, char> __9__125_3;
			public static Func<IntPtr, int, short> __9__125_4;
			public static Func<IntPtr, int, ushort> __9__125_5;
			public static Func<IntPtr, int, float> __9__125_6;
	
			// Constructors
			static __c__125();
			public __c__125();
	
			// Methods
			internal byte _tryGetGetFuncByType_b__125_1(IntPtr L, int idx);
			internal sbyte _tryGetGetFuncByType_b__125_2(IntPtr L, int idx);
			internal char _tryGetGetFuncByType_b__125_3(IntPtr L, int idx);
			internal short _tryGetGetFuncByType_b__125_4(IntPtr L, int idx);
			internal ushort _tryGetGetFuncByType_b__125_5(IntPtr L, int idx);
			internal float _tryGetGetFuncByType_b__125_6(IntPtr L, int idx);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass128_0<T> // TypeDefIndex: 58778
		{
			// Fields
			public GetFunc<T> get;
			public Action<IntPtr, T> push;
			public Action<IntPtr, int, T> update;
	
			// Constructors
			public __c__DisplayClass128_0();
	
			// Methods
			internal T _RegisterPushAndGetAndUpdate_b__0(IntPtr L, int idx);
			internal void _RegisterPushAndGetAndUpdate_b__1(IntPtr L, object obj);
			internal object _RegisterPushAndGetAndUpdate_b__2(IntPtr L, int idx);
			internal void _RegisterPushAndGetAndUpdate_b__3(IntPtr L, int idx, object obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass129_0<T> // TypeDefIndex: 58779
		{
			// Fields
			public CheckFunc<T> check;
	
			// Constructors
			public __c__DisplayClass129_0();
	
			// Methods
			internal bool _RegisterChecker_b__0(IntPtr L, int idx);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass130_0<T> // TypeDefIndex: 58780
		{
			// Fields
			public GetFunc<T> get;
	
			// Constructors
			public __c__DisplayClass130_0();
	
			// Methods
			internal object _RegisterCaster_b__0(IntPtr L, int idx, object o);
		}
	
		// Constructors
		public ObjectTranslator(LuaEnv luaenv, IntPtr L); // 0x0000000183B0E680-0x0000000183B0F0B0
		static ObjectTranslator(); // 0x0000000184B0D4C0-0x0000000184B0D610
	
		// Methods
		public void DelayWrapLoader(System.Type type, Action<IntPtr> loader); // 0x000000018406D660-0x000000018406D690
		public void AddInterfaceBridgeCreator(System.Type type, Func<int, LuaEnv, LuaBase> creator); // 0x000000018439C4B0-0x000000018439C520
		public bool TryDelayWrapLoader(IntPtr L, System.Type type); // 0x00000001836060D0-0x0000000183606330
		public void Alias(System.Type type, string alias); // 0x0000000183B11A90-0x0000000183B11B40
		private void addAssemblieByName(IEnumerable<Assembly> assemblies_usorted, string name); // 0x0000000183B0E090-0x0000000183B0E360
		private void initCSharpCallLua(); // 0x00000001841E1670-0x00000001841E1680
		private Func<DelegateBridgeBase, Delegate> getCreatorUsingGeneric(DelegateBridgeBase bridge, System.Type delegateType, MethodInfo delegateMethod); // 0x00000001843E6550-0x00000001843E6E40
		private Delegate getDelegate(DelegateBridgeBase bridge, System.Type delegateType); // 0x0000000183607FA0-0x0000000183608370
		public object CreateDelegateBridge(IntPtr L, System.Type delegateType, int idx); // 0x0000000183606FF0-0x0000000183607450
		public bool AllDelegateBridgeReleased(); // 0x000000018B8A803C-0x000000018B8A8178
		public void ReleaseLuaBase(IntPtr L, int reference, bool is_delegate); // 0x00000001832EF3E0-0x00000001832EF630
		public object CreateInterfaceBridge(IntPtr L, System.Type interfaceType, int idx); // 0x000000018B8A8188-0x000000018B8A82DC
		public void CreateArrayMetatable(IntPtr L); // 0x00000001849E51E0-0x00000001849E53D0
		public void CreateDelegateMetatable(IntPtr L); // 0x00000001849C0530-0x00000001849C0750
		internal void CreateEnumerablePairs(IntPtr L); // 0x000000018321AE00-0x000000018321B050
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int CsPairs(IntPtr L); // 0x0000000183FE81A0-0x0000000183FF0EC0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumToInt(IntPtr L); // 0x000000018B8A82DC-0x000000018B8A8370
		internal void CreateEnumerableCSPairs(IntPtr L); // 0x000000018321ADB0-0x000000018321AE00
		public void OpenLib(IntPtr L); // 0x0000000184707AA0-0x0000000184708080
		internal void createFunctionMetatable(IntPtr L); // 0x000000018404E170-0x000000018404E310
		internal System.Type FindType(string className, bool isQualifiedName = false /* Metadata: 0x0234BEFA */); // 0x0000000183B112A0-0x0000000183B11550
		private bool hasMethod(System.Type type, string methodName); // 0x000000018B8A8F4C-0x000000018B8A8FD0
		internal void collectObject(int obj_index_to_collect); // 0x0000000182F39F90-0x0000000182F3A240
		private int addObject(object obj, bool is_valuetype, bool is_enum); // 0x00000001831339F0-0x0000000183134170
		internal object GetObject(IntPtr L, int index); // 0x00000001848FC960-0x00000001848FCA20
		public System.Type GetTypeOf(IntPtr L, int idx); // 0x0000000183A1B080-0x0000000183A1B170
		public bool Assignable<T>(IntPtr L, int index);
		public bool Assignable(IntPtr L, int index, System.Type type); // 0x0000000183299B30-0x0000000183299E00
		public object FastGetObject(IntPtr L, int index, System.Type type); // 0x00000001831341B0-0x00000001831342D0
		public object GetObject(IntPtr L, int index, System.Type type); // 0x0000000185391698-0x00000001853916A8
		private void _Get<T>(IntPtr L, int index, out ref T v);
		public void Get<T>(IntPtr L, int index, out ref T v);
		public void PushByType<T>(IntPtr L, T v);
		public T[] GetParams<T>(IntPtr L, int index);
		public Array GetParams(IntPtr L, int index, System.Type type); // 0x000000018B8A843C-0x000000018B8A8538
		public T GetDelegate<T>(IntPtr L, int index)
			where T : class;
		public int GetTypeId(IntPtr L, System.Type type); // 0x0000000185391C58-0x0000000185391C84
		public void PrivateAccessible(IntPtr L, System.Type type); // 0x000000018B8A8888-0x000000018B8A896C
		public int getTypeId(IntPtr L, System.Type type, out bool is_first, LOGLEVEL log_level = LOGLEVEL.WARN /* Metadata: 0x0234BEFB */); // 0x00000001831333D0-0x00000001831339F0
		private void pushPrimitive(IntPtr L, object o); // 0x0000000182FB7620-0x0000000182FB7970
		public void PushObject(IntPtr L, object o); // 0x0000000185391E68-0x0000000185391E70
		public void PushAny(IntPtr L, object o); // 0x0000000182FB8890-0x0000000182FB8CC0
		public int TranslateToEnumToTop(IntPtr L, System.Type type, int idx); // 0x000000018B8A8E2C-0x000000018B8A8F4C
		public void Push(IntPtr L, lua_CSFunction o); // 0x000000018B8A8C9C-0x000000018B8A8D5C
		public void Push(IntPtr L, LuaBase o); // 0x000000018B8A8C38-0x000000018B8A8C9C
		public void Push<T>(IntPtr L, T o)
			where T : struct;
		public void Push(IntPtr L, object o); // 0x0000000183132DB0-0x00000001831333D0
		public void PushObject(IntPtr L, object o, int type_id); // 0x000000018B8A8B2C-0x000000018B8A8C38
		public bool IsUnmanagedType(System.Type type); // 0x0000000183297170-0x0000000183297250
		public void PushBrigeStruct(IntPtr L, IntPtr ptr, System.Type type, int size); // 0x0000000183296F20-0x0000000183297170
		private void _PushBrigeStruct(IntPtr L, IntPtr ptr, System.Type type, int size); // 0x0000000183297250-0x0000000183297390
		public void GetBrigeStruct(IntPtr L, IntPtr ptr, int index, int size, System.Type type); // 0x0000000183296BE0-0x0000000183296D50
		public void AddNeedRemoveObjRef(object obj); // 0x00000001832F0100-0x00000001832F0140
		private void _GetBrigeStruct(IntPtr L, IntPtr ptr, int index, int size, System.Type type); // 0x0000000183297390-0x0000000183297550
		public void UpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type); // 0x0000000183EE0380-0x0000000183EE0420
		public void BeyondUpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type); // 0x000000018B8A8178-0x000000018B8A8188
		private void _UpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type); // 0x0000000183EE0420-0x0000000183EE04B0
		public void Update<T>(IntPtr L, int index, T obj)
			where T : struct;
		public void Update(IntPtr L, int index, object obj); // 0x000000018329CA40-0x000000018329CCE0
		private object getCsObj(IntPtr L, int index, int udata); // 0x0000000183134890-0x0000000183134BA0
		internal object SafeGetCSObj(IntPtr L, int index); // 0x0000000183605B50-0x0000000183605BC0
		public object FastGetCSObj(IntPtr L, int index); // 0x000000018B8A8370-0x000000018B8A83E4
		internal void ReleaseCSObj(IntPtr L, int index); // 0x000000018B8A8D5C-0x000000018B8A8E2C
		internal lua_CSFunction GetFixCSFunction(int index); // 0x000000018B8A83E4-0x000000018B8A843C
		internal LuaCSFunctionPtr GetFixCSFunctionPtr(int index); // 0x0000000182F39AF0-0x0000000182F39B70
		internal void PushFixCSFunction(IntPtr L, lua_CSFunction func); // 0x0000000183297D70-0x0000000183298160
		internal object[] popValues(IntPtr L, int oldTop); // 0x0000000183544FA0-0x00000001835450A0
		internal object[] popValues(IntPtr L, int oldTop, System.Type[] popTypes); // 0x000000018B8A8FD0-0x000000018B8A9154
		private void registerCustomOp(System.Type type, PushCSObject push, GetCSObject get, UpdateCSObject update); // 0x0000000182F29E00-0x0000000182F29EA0
		public bool HasCustomOp(System.Type type); // 0x00000001843C05F0-0x00000001843C0620
		private bool tryGetPushFuncByType<T>(System.Type type, out ref T func)
			where T : class;
		private bool tryGetGetFuncByType<T>(System.Type type, out ref T func)
			where T : class;
		public void RegisterPushAndGetAndUpdate<T>(Action<IntPtr, T> push, GetFunc<T> get, Action<IntPtr, int, T> update);
		public void RegisterChecker<T>(CheckFunc<T> check);
		public void RegisterCaster<T>(GetFunc<T> get);
		public void PushDecimal(IntPtr L, decimal val); // 0x000000018B8A896C-0x000000018B8A8B2C
		public bool IsDecimal(IntPtr L, int index); // 0x000000018B8A8818-0x000000018B8A8888
		public decimal GetDecimal(IntPtr L, int index); // 0x0000000187766224-0x0000000187766260
		public void Get(IntPtr L, int index, out decimal val); // 0x000000018B8A8538-0x000000018B8A8818
		[CompilerGenerated]
		private decimal _tryGetGetFuncByType_b__125_0<T>(IntPtr L, int idx)
			where T : class;
	}

	public class ObjectTranslatorPool // TypeDefIndex: 58782
	{
		// Fields
		private Dictionary<IntPtr, WeakReference> translators; // 0x10
		private IntPtr lastPtr; // 0x18
		private ObjectTranslator lastTranslator; // 0x20
		public static ObjectTranslatorPool Instance; // 0x00
	
		// Constructors
		public ObjectTranslatorPool(); // 0x0000000184CB69A0-0x0000000184CB6A20
		static ObjectTranslatorPool(); // 0x0000000184CB6930-0x0000000184CB69A0
	
		// Methods
		public void Add(IntPtr L, ObjectTranslator translator); // 0x0000000184CB0ED0-0x0000000184CB0FC0
		public ObjectTranslator Find(IntPtr L); // 0x0000000184D862C0-0x0000000184D862D0
		public void Remove(IntPtr L); // 0x000000018B8A7F80-0x000000018B8A803C
	}

	public interface RawObject // TypeDefIndex: 58783
	{
		// Properties
		object Target { get; }
	}

	public class InternalUtility // TypeDefIndex: 58784
	{
		// Fields
		private static Dictionary<System.Type, string> s_baseValueTypeDic; // 0x00
	
		// Constructors
		public InternalUtility(); // 0x00000001841E1670-0x00000001841E1680
		static InternalUtility(); // 0x00000001845B0DD0-0x00000001845B12D0
	
		// Methods
		public static string GetTypeGenericSignatureDefine(System.Type type, bool isGetType = false /* Metadata: 0x0234BF00 */, bool isRef = false /* Metadata: 0x0234BF01 */, bool isOut = false /* Metadata: 0x0234BF02 */, bool needLua = false /* Metadata: 0x0234BF03 */, bool keepType = false /* Metadata: 0x0234BF04 */, bool needEnum = false /* Metadata: 0x0234BF05 */); // 0x0000000182F2BF90-0x0000000182F2C220
		public static bool CheckRegisterBaseStructOnArm(System.Type type); // 0x0000000182F2BCB0-0x0000000182F2BE60
		public static bool CheckCustomDelegate(string name); // 0x00000001840B35E0-0x00000001840B3660
		public static bool CheckTypNeedToGen(System.Type type); // 0x000000018B8A7564-0x000000018B8A7698
		public static bool IsPublic(System.Type type); // 0x000000018B8A7E48-0x000000018B8A7EFC
		public static string GetTypeFullName(System.Type t); // 0x00000001835CCBA0-0x00000001835CCDD0
		public static string GetDelegateName(MethodInfo method); // 0x000000018B8A7698-0x000000018B8A7A20
		public static bool IsStruct(System.Type type); // 0x0000000182F2BE60-0x0000000182F2BEE0
		public static string GetGenericTypeName(System.Type type, bool needPoint = false /* Metadata: 0x0234BF06 */); // 0x000000018B8A7BD0-0x000000018B8A7E48
		public static string GeNormalName(string str); // 0x0000000182F2C220-0x0000000182F2C330
		public static string GetGenericTypeNameString(System.Type type); // 0x000000018B8A7A20-0x000000018B8A7BD0
	}

	public class MethodAndDelegateSignatureManager // TypeDefIndex: 58785
	{
		// Constructors
		public MethodAndDelegateSignatureManager(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static System.Type MakeMethodDelegateType(MethodInfo method); // 0x0000000183895320-0x0000000183896C60
		public static System.Type MakeMethodDelegateType(MethodInfo method, System.Type customDelegateType); // 0x0000000183897230-0x0000000183897F20
		public static ValueTuple<System.Type, string> GetMethodDelegateType(MethodInfo method); // 0x0000000182F2C330-0x0000000182F2C410
	}

	public class SignatureLoader // TypeDefIndex: 58786
	{
		// Fields
		private LuaEnv.CustomLoader userLoader; // 0x10
		private RSACryptoServiceProvider rsa; // 0x18
		private SHA1 sha; // 0x20
	
		// Constructors
		public SignatureLoader(string publicKey, LuaEnv.CustomLoader loader); // 0x000000018B8A91D4-0x000000018B8A92D4
	
		// Methods
		private byte[] load_and_verify(ref string filepath); // 0x000000018B8A92D4-0x000000018B8A94B4
		public static implicit operator LuaEnv.CustomLoader(SignatureLoader signatureLoader); // 0x000000018B8A94B4-0x000000018B8A9528
	}

	public delegate TRet CallDelegatePointer<TParam1, TParam2, TRet>(IntPtr ptr, TParam1 target, TParam2 param); // TypeDefIndex: 58787; 0x00000000-0x00000000

	public class StaticLuaCallbacks // TypeDefIndex: 58788
	{
		// Fields
		internal lua_CSFunction GcMeta; // 0x10
		internal lua_CSFunction ToStringMeta; // 0x18
		internal lua_CSFunction EnumAndMeta; // 0x20
		internal lua_CSFunction EnumOrMeta; // 0x28
		internal lua_CSFunction StaticCSFunctionWraper; // 0x30
		internal lua_CSFunction FixCSFunctionWraper; // 0x38
		internal lua_CSFunction DelegateCtor; // 0x40
		public static CallDelegatePointer<object, IntPtr, int> callDelegatePointer; // 0x00
	
		// Constructors
		public StaticLuaCallbacks(); // 0x00000001849B2490-0x00000001849B26A0
	
		// Methods
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumAnd(IntPtr L); // 0x000000018B8AA308-0x000000018B8AA590
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumOr(IntPtr L); // 0x000000018B8AA590-0x000000018B8AA818
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int StaticCSFunction(IntPtr L); // 0x000000018B8AC200-0x000000018B8AC3AC
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int FixCSFunction(IntPtr L); // 0x0000000182F39600-0x0000000182F39AF0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCall(IntPtr L); // 0x000000018B8A9C7C-0x000000018B8A9E6C
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LuaGC(IntPtr L); // 0x0000000182F39B70-0x0000000182F39F80
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToString(IntPtr L); // 0x00000001843DF130-0x00000001843DF230
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCombine(IntPtr L); // 0x000000018B8A9E6C-0x000000018B8AA0CC
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateRemove(IntPtr L); // 0x0000000184611010-0x0000000184611180
		private static bool tryPrimitiveArrayGet(System.Type type, IntPtr L, object obj, int index); // 0x0000000183FD2B40-0x0000000183FD2EB0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayIndexer(IntPtr L); // 0x0000000183FD2800-0x0000000183FD2B40
		public static bool TryPrimitiveArraySet(System.Type type, IntPtr L, object obj, int array_idx, int obj_idx); // 0x000000018B8AC724-0x000000018B8AD048
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayNewIndexer(IntPtr L); // 0x000000018B8A9528-0x000000018B8A99D8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayLength(IntPtr L); // 0x000000018459E650-0x000000018459E770
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int MetaFuncIndex(IntPtr L); // 0x00000001842F06D0-0x00000001842F0830
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Panic(IntPtr L); // 0x000000018B8ABD38-0x000000018B8ABDD4
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Print(IntPtr L); // 0x000000018B8ABDD4-0x000000018B8AC0B8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadSocketCore(IntPtr L); // 0x000000018B8ABCF0-0x000000018B8ABD38
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadCS(IntPtr L); // 0x000000018B8AB674-0x000000018B8AB6E0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadBuiltinLib(IntPtr L); // 0x0000000184564CC0-0x0000000184564E70
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromResource(IntPtr L); // 0x000000018B8AB6E0-0x000000018B8AB9F4
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromStreamingAssetsPath(IntPtr L); // 0x000000018B8AB9F4-0x000000018B8ABCF0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromCustomLoaders(IntPtr L); // 0x0000000183600F50-0x0000000183601710
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadAssembly(IntPtr L); // 0x000000018B8AB3E8-0x000000018B8AB674
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportType(IntPtr L); // 0x0000000183B11160-0x0000000183B112A0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportGenericType(IntPtr L); // 0x000000018B8AB008-0x000000018B8AB3E8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Cast(IntPtr L); // 0x000000018B8A99D8-0x000000018B8A9C7C
		private static System.Type getType(IntPtr L, ObjectTranslator translator, int idx); // 0x000000018B8AD9D8-0x000000018B8ADB5C
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaAccess(IntPtr L); // 0x000000018B8AD048-0x000000018B8AD4CC
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaPrivateAccessible(IntPtr L); // 0x000000018B8AD7D0-0x000000018B8AD9D8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaMetatableOperation(IntPtr L); // 0x000000018B8AD4CC-0x000000018B8AD7D0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateConstructor(IntPtr L); // 0x000000018B8AA0CC-0x000000018B8AA308
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToFunction(IntPtr L); // 0x000000018B8AC3AC-0x000000018B8AC724
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GenericMethodWraper(IntPtr L); // 0x000000018B8AA818-0x000000018B8AAC00
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GetGenericMethod(IntPtr L); // 0x000000018B8AAC00-0x000000018B8AB008
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ReleaseCsObject(IntPtr L); // 0x000000018B8AC0B8-0x000000018B8AC200
	}

	internal static class TypeExtensions // TypeDefIndex: 58790
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58789
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, string> __9__12_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B8B420C-0x000000018B8B4270
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _GetFriendlyName_b__12_0(System.Type x); // 0x000000018B8B1A80-0x000000018B8B1A8C
		}
	
		// Extension methods
		public static bool IsValueType(this System.Type type); // 0x0000000183131F30-0x0000000183131F50
		public static bool IsEnum(this System.Type type); // 0x0000000182F3A240-0x0000000182F3A260
		public static bool IsPrimitive(this System.Type type); // 0x0000000182F2AB50-0x0000000182F2AB70
		public static bool IsAbstract(this System.Type type); // 0x00000001835CFFA0-0x00000001835CFFD0
		public static bool IsSealed(this System.Type type); // 0x000000018B8B1724-0x000000018B8B1740
		public static bool IsInterface(this System.Type type); // 0x00000001835CFF60-0x00000001835CFF80
		public static bool IsClass(this System.Type type); // 0x00000001835CE330-0x00000001835CE350
		public static System.Type BaseType(this System.Type type); // 0x0000000183607F30-0x0000000183607F50
		public static bool IsGenericType(this System.Type type); // 0x0000000184D83A60-0x0000000184D83A80
		public static bool IsGenericTypeDefinition(this System.Type type); // 0x00000001835CFF80-0x00000001835CFFA0
		public static bool IsNestedPublic(this System.Type type); // 0x000000018B8B16EC-0x000000018B8B1708
		public static bool IsPublic(this System.Type type); // 0x000000018B8B1708-0x000000018B8B1724
		public static string GetFriendlyName(this System.Type type); // 0x000000018B8B11F4-0x000000018B8B16EC
	}

	public enum LazyMemberTypes // TypeDefIndex: 58791
	{
		Method = 0,
		FieldGet = 1,
		FieldSet = 2,
		PropertyGet = 3,
		PropertySet = 4,
		Event = 5
	}

	public static class Utils // TypeDefIndex: 58807
	{
		// Fields
		public static bool s_xluaReflectionOpt; // 0x00
		public const int OBJ_META_IDX = -4; // Metadata: 0x0234BF0F
		public const int METHOD_IDX = -3; // Metadata: 0x0234BF10
		public const int GETTER_IDX = -2; // Metadata: 0x0234BF11
		public const int SETTER_IDX = -1; // Metadata: 0x0234BF12
		public const int CLS_IDX = -4; // Metadata: 0x0234BF13
		public const int CLS_META_IDX = -3; // Metadata: 0x0234BF14
		public const int CLS_GETTER_IDX = -2; // Metadata: 0x0234BF15
		public const int CLS_SETTER_IDX = -1; // Metadata: 0x0234BF16
		public const string LuaIndexsFieldName = "LuaIndexs"; // Metadata: 0x0234BF17
		public const string LuaNewIndexsFieldName = "LuaNewIndexs"; // Metadata: 0x0234BF21
		public const string LuaClassIndexsFieldName = "LuaClassIndexs"; // Metadata: 0x0234BF2E
		public const string LuaClassNewIndexsFieldName = "LuaClassNewIndexs"; // Metadata: 0x0234BF3D
	
		// Nested types
		private struct MethodKey // TypeDefIndex: 58792
		{
			// Fields
			public string Name; // 0x00
			public bool IsStatic; // 0x08
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 58793
		{
			// Fields
			public bool exclude_generic_definition; // 0x10
			public Func<System.Type, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetAllTypes_b__0(System.Type type); // 0x000000018B8B36D0-0x000000018B8B36F4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 58794
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _genFieldGetter_b__0(IntPtr L); // 0x000000018B8B36F4-0x000000018B8B3794
			internal int _genFieldGetter_b__1(IntPtr L); // 0x000000018B8B3794-0x000000018B8B39E4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 58795
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _genFieldGetterByPointer_b__0(IntPtr L); // 0x00000001835944C0-0x0000000183594590
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 58796
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _genFieldSetter_b__0(IntPtr L); // 0x000000018B8B3B60-0x000000018B8B3DD0
			internal int _genFieldSetter_b__1(IntPtr L); // 0x000000018B8B3DD0-0x000000018B8B41A8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 58797
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _genFieldSetterByPointer_b__0(IntPtr L); // 0x00000001849B9E60-0x00000001849B9FA0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 58798
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public MethodWrap[] methods; // 0x28
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _genItemGetterOpt_b__1(IntPtr L); // 0x00000001838EDD30-0x00000001838EDEB0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58799
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<PropertyInfo, bool> __9__9_0; // 0x08
			public static Func<PropertyInfo, bool> __9__10_0; // 0x10
			public static Func<PropertyInfo, bool> __9__11_0; // 0x18
			public static Func<PropertyInfo, bool> __9__12_0; // 0x20
			public static Func<System.Type, bool> __9__14_7; // 0x28
			public static Func<System.Type, bool> __9__14_8; // 0x30
			public static Func<System.Type, IEnumerable<MethodInfo>> __9__14_0; // 0x38
			public static Func<System.Type, MethodInfo, __f__AnonymousType1<System.Type, MethodInfo>> __9__14_1; // 0x40
			public static Func<__f__AnonymousType1<System.Type, MethodInfo>, bool> __9__14_2; // 0x48
			public static Func<__f__AnonymousType1<System.Type, MethodInfo>, System.Type> __9__14_3; // 0x50
			public static Func<__f__AnonymousType1<System.Type, MethodInfo>, MethodInfo> __9__14_4; // 0x58
			public static Func<IGrouping<System.Type, MethodInfo>, System.Type> __9__14_5; // 0x60
			public static Func<IGrouping<System.Type, MethodInfo>, IEnumerable<MethodInfo>> __9__14_6; // 0x68
			public static Func<MethodInfo, string> __9__16_0; // 0x70
			public static Func<MethodInfo, string> __9__16_1; // 0x78
			public static Func<MethodInfo, MethodInfo, MethodInfo> __9__16_2; // 0x80
	
			// Constructors
			static __c(); // 0x0000000184D41AD0-0x0000000184D41B30
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _genItemGetterOpt_b__9_0(PropertyInfo prop); // 0x00000001844E1A70-0x00000001844E1B30
			internal bool _genItemGetter_b__10_0(PropertyInfo prop); // 0x000000018B8B1D44-0x000000018B8B1DF0
			internal bool _genItemSetterOpt_b__11_0(PropertyInfo prop); // 0x00000001844E19B0-0x00000001844E1A70
			internal bool _genItemSetter_b__12_0(PropertyInfo prop); // 0x000000018B8B1DF0-0x000000018B8B1E9C
			internal bool _GetExtensionMethodsOf_b__14_7(System.Type t); // 0x000000018B8B1988-0x000000018B8B1A04
			internal bool _GetExtensionMethodsOf_b__14_8(System.Type t); // 0x000000018B8B1A04-0x000000018B8B1A80
			internal IEnumerable<MethodInfo> _GetExtensionMethodsOf_b__14_0(System.Type type); // 0x000000018B8B1740-0x000000018B8B1760
			internal __f__AnonymousType1<System.Type, MethodInfo> _GetExtensionMethodsOf_b__14_1(System.Type type, MethodInfo method); // 0x000000018B8B1760-0x000000018B8B17E0
			internal bool _GetExtensionMethodsOf_b__14_2(__f__AnonymousType1<System.Type, MethodInfo> __h__TransparentIdentifier0); // 0x000000018B8B17E0-0x000000018B8B18A8
			internal System.Type _GetExtensionMethodsOf_b__14_3(__f__AnonymousType1<System.Type, MethodInfo> __h__TransparentIdentifier0); // 0x000000018B8B18A8-0x000000018B8B1904
			internal MethodInfo _GetExtensionMethodsOf_b__14_4(__f__AnonymousType1<System.Type, MethodInfo> __h__TransparentIdentifier0); // 0x000000018B8B1904-0x000000018B8B1940
			internal System.Type _GetExtensionMethodsOf_b__14_5(IGrouping<System.Type, MethodInfo> g); // 0x000000018B8B1940-0x000000018B8B1988
			internal IEnumerable<MethodInfo> _GetExtensionMethodsOf_b__14_6(IGrouping<System.Type, MethodInfo> g); // 0x0000000184D88C30-0x0000000184D88C40
			internal string _makeReflectionWrap_b__16_0(MethodInfo p); // 0x000000018B8B1E9C-0x000000018B8B1EBC
			internal string _makeReflectionWrap_b__16_1(MethodInfo q); // 0x000000018B8B1E9C-0x000000018B8B1EBC
			internal MethodInfo _makeReflectionWrap_b__16_2(MethodInfo p, MethodInfo q); // 0x0000000184D88C30-0x0000000184D88C40
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 58800
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public object[] arg; // 0x28
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _genItemGetter_b__1(IntPtr L); // 0x000000018B8B1EBC-0x000000018B8B2410
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 58801
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public MethodWrap[] methods; // 0x28
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _genItemSetterOpt_b__1(IntPtr L); // 0x000000018B8B2410-0x000000018B8B291C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 58802
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public object[] arg; // 0x28
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _genItemSetter_b__1(IntPtr L); // 0x000000018B8B291C-0x000000018B8B2FA4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 58803
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _genEnumCastFrom_b__0(IntPtr L); // 0x000000018B8B2FA4-0x000000018B8B3150
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 58804
		{
			// Fields
			public string fieldName; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _makeReflectionWrap_b__3(EventInfo e); // 0x0000000184CE1D50-0x0000000184CE1D90
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 58805
		{
			// Fields
			public string memberName; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _LazyReflectionCall_b__0(MethodInfo m); // 0x000000018A99AD6C-0x000000018A99ADA0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 58806
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _ReflectionWrap_b__0(IntPtr LL); // 0x000000018B8B3638-0x000000018B8B36D0
		}
	
		// Constructors
		static Utils(); // 0x0000000184D79790-0x0000000184D797D0
	
		// Methods
		public static bool LoadField(IntPtr L, int idx, string field_name); // 0x000000018B8B561C-0x000000018B8B56B0
		public static IntPtr GetMainState(IntPtr L); // 0x000000018B8B4570-0x000000018B8B462C
		public static List<System.Type> GetAllTypes(bool exclude_generic_definition = true /* Metadata: 0x0234BF0D */); // 0x000000018B8B4338-0x000000018B8B4570
		private static lua_CSFunction genFieldGetter(System.Type type, System.Reflection.FieldInfo field); // 0x000000018B8B5E40-0x000000018B8B5F34
		private static lua_CSFunction genFieldGetterByPointer(System.Type type, System.Reflection.FieldInfo field); // 0x0000000182F29FB0-0x0000000182F2A2E0
		public static bool IsNullableType(System.Type type); // 0x000000018B8B462C-0x000000018B8B46C0
		private static lua_CSFunction genFieldSetter(System.Type type, System.Reflection.FieldInfo field); // 0x000000018B8B5F34-0x000000018B8B6028
		private static lua_CSFunction genFieldSetterByPointer(System.Type type, System.Reflection.FieldInfo field); // 0x0000000182F2A2E0-0x0000000182F2A600
		private static lua_CSFunction genItemGetterOpt(System.Type type, PropertyInfo[] props, ObjectTranslator translator); // 0x0000000184074AC0-0x0000000184074F00
		private static lua_CSFunction genItemGetter(System.Type type, PropertyInfo[] props); // 0x000000018B8B6028-0x000000018B8B62E4
		private static lua_CSFunction genItemSetterOpt(System.Type type, PropertyInfo[] props, ObjectTranslator translator); // 0x0000000184074F00-0x0000000184075340
		private static lua_CSFunction genItemSetter(System.Type type, PropertyInfo[] props); // 0x000000018B8B62E4-0x000000018B8B65A0
		private static lua_CSFunction genEnumCastFrom(System.Type type); // 0x000000018468A000-0x000000018468A0B0
		internal static IEnumerable<MethodInfo> GetExtensionMethodsOf(System.Type type_to_be_extend); // 0x000000018408E7B0-0x000000018408E8C0
		private static void makeReflectionWrap(IntPtr L, System.Type type, int cls_field, int cls_getter, int cls_setter, int obj_field, int obj_getter, int obj_setter, int obj_meta, out lua_CSFunction item_getter, out lua_CSFunction item_setter, System.Reflection.BindingFlags access); // 0x0000000182F86380-0x0000000182F8A600
		public static void loadUpvalue(IntPtr L, System.Type type, string metafunc, int index); // 0x000000018B8B66C4-0x000000018B8B6868
		public static void RegisterEnumType(IntPtr L, System.Type type); // 0x00000001836FDEF0-0x00000001836FE100
		public static void MakePrivateAccessible(IntPtr L, System.Type type); // 0x000000018B8B5818-0x000000018B8B5CD8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LazyReflectionCall(IntPtr L); // 0x000000018B8B49A0-0x000000018B8B561C
		public static void ReflectionWrap(IntPtr L, System.Type type, bool privateAccessible); // 0x0000000183607450-0x0000000183607EE0
		public static void BeginObjectRegister(System.Type type, IntPtr L, ObjectTranslator translator, int meta_count, int method_count, int getter_count, int setter_count, int type_id = -1 /* Metadata: 0x0234BF0E */); // 0x00000001832EE950-0x00000001832EED00
		private static int abs_idx(int top, int idx); // 0x0000000183296720-0x0000000183296730
		public static void EndObjectRegister(System.Type type, IntPtr L, ObjectTranslator translator, lua_CSFunction csIndexer, lua_CSFunction csNewIndexer, System.Type base_type, lua_CSFunction arrayIndexer, lua_CSFunction arrayNewIndexer); // 0x00000001836065E0-0x0000000183606B40
		public static void RegisterFunc(IntPtr L, int idx, string name, lua_CSFunction func); // 0x00000001832965C0-0x0000000183296720
		public static void RegisterLazyFunc(IntPtr L, int idx, string name, System.Type type, LazyMemberTypes memberType, bool isStatic); // 0x000000018B8B5CD8-0x000000018B8B5E40
		public static void RegisterObject(IntPtr L, ObjectTranslator translator, int idx, string name, object obj); // 0x0000000183296260-0x0000000183296320
		public static void BeginClassRegister(System.Type type, IntPtr L, lua_CSFunction creator, int class_field_count, int static_getter_count, int static_setter_count); // 0x0000000183605350-0x00000001836055C0
		public static void EndClassRegister(System.Type type, IntPtr L, ObjectTranslator translator); // 0x0000000183606390-0x00000001836065E0
		private static List<string> getPathOfType(System.Type type); // 0x00000001835AA040-0x00000001835AA210
		public static void LoadCSTable(IntPtr L, System.Type type); // 0x00000001835A82B0-0x00000001835A8430
		public static void SetCSTable(IntPtr L, System.Type type, int cls_table); // 0x0000000183030C20-0x0000000183030FD0
		public static bool IsParamsMatch(MethodInfo delegateMethod, MethodInfo bridgeMethod); // 0x000000018463E4F0-0x000000018463E610
		public static bool IsSupportedMethod(MethodInfo method); // 0x000000018B8B47C0-0x000000018B8B49A0
		public static MethodInfo MakeGenericMethodWithConstraints(MethodInfo method); // 0x000000018B8B56B0-0x000000018B8B5818
		private static System.Type getExtendedType(MethodInfo method); // 0x000000018B8B65A0-0x000000018B8B66C4
		public static bool IsStaticPInvokeCSFunction(lua_CSFunction csFunction); // 0x0000000183601AA0-0x0000000183601B70
		public static bool IsPublic(System.Type type); // 0x000000018B8B46C0-0x000000018B8B47C0
	}
}

namespace XLua.Cast
{
	public class Any<T> : RawObject // TypeDefIndex: 58834
	{
		// Fields
		private T mTarget;
	
		// Properties
		public object Target { get; }
	
		// Constructors
		public Any(T i);
	}

	public class Byte : Any<byte> // TypeDefIndex: 58835
	{
		// Constructors
		public Byte(byte i); // 0x000000018B8AE354-0x000000018B8AE394
	}

	public class SByte : Any<sbyte> // TypeDefIndex: 58836
	{
		// Constructors
		public SByte(sbyte i); // 0x000000018B8B1168-0x000000018B8B11A8
	}

	public class Char : Any<char> // TypeDefIndex: 58837
	{
		// Constructors
		public Char(char i); // 0x000000018B8AE394-0x000000018B8AE3D8
	}

	public class Int16 : Any<short> // TypeDefIndex: 58838
	{
		// Constructors
		public Int16(short i); // 0x000000018B8AF1FC-0x000000018B8AF240
	}

	public class UInt16 : Any<ushort> // TypeDefIndex: 58839
	{
		// Constructors
		public UInt16(ushort i); // 0x000000018B8B4270-0x000000018B8B42B4
	}

	public class Int32 : Any<int> // TypeDefIndex: 58840
	{
		// Constructors
		public Int32(int i); // 0x000000018B8AF240-0x000000018B8AF280
	}

	public class UInt32 : Any<uint> // TypeDefIndex: 58841
	{
		// Constructors
		public UInt32(uint i); // 0x000000018B8B42B4-0x000000018B8B42F4
	}

	public class Int64 : Any<long> // TypeDefIndex: 58842
	{
		// Constructors
		public Int64(long i); // 0x000000018B8AF280-0x000000018B8AF2C4
	}

	public class UInt64 : Any<ulong> // TypeDefIndex: 58843
	{
		// Constructors
		public UInt64(ulong i); // 0x000000018B8B42F4-0x000000018B8B4338
	}

	public class Float : Any<float> // TypeDefIndex: 58844
	{
		// Constructors
		public Float(float i); // 0x000000018B8AE484-0x000000018B8AE4C8
	}
}

namespace XLua.LuaDLL
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int lua_CSFunction(IntPtr L); // TypeDefIndex: 58845; 0x00000001814E2060-0x00000001814E2070

	public static class Lua // TypeDefIndex: 58849
	{
		// Fields
		private const string LUADLL = "__Internal"; // Metadata: 0x0234BF56
		private static int s_mainThreadId; // 0x00
		public static Func<IntPtr, string> tryGetLuaStringFunc; // 0x08
		public static Action<IntPtr, IntPtr, int, string> refLuaStringFunc; // 0x10
		public const int LUAI_MAXSHORTLEN = 40; // Metadata: 0x0234BF61
	
		// Nested types
		public delegate void HyperLuaLogCallbackDelegate(IntPtr L, int level, string text); // TypeDefIndex: 58846; 0x0000000181546280-0x00000001815462A0
	
		public delegate void LuaUtilsLogCallbackDelegate(int level, string text); // TypeDefIndex: 58847; 0x00000001838E1420-0x00000001838E1430
	
		public delegate IntPtr DecryptionFunc(IntPtr input, int size, out int outSize); // TypeDefIndex: 58848; 0x00000001814F3120-0x00000001814F3140
	
		// Constructors
		static Lua(); // 0x0000000184D4DFB0-0x0000000184D4E010
	
		// Methods
		public static extern IntPtr lua_tothread(IntPtr L, int index); // 0x0000000185391F08-0x0000000185391F10
		public static extern int xlua_get_lib_version(); // 0x0000000185393214-0x000000018539321C
		public static extern int lua_gc(IntPtr L, XLua.LuaGCOptions what, int data); // 0x0000000185393E50-0x0000000185393E58
		public static extern IntPtr lua_getupvalue(IntPtr L, int funcindex, int n); // 0x000000018B8AFE9C-0x000000018B8AFEA4
		public static extern IntPtr lua_setupvalue(IntPtr L, int funcindex, int n); // 0x000000018B8AFFC8-0x000000018B8AFFD0
		public static extern int lua_pushthread(IntPtr L); // 0x0000000185391F10-0x0000000185391F18
		public static bool lua_isfunction(IntPtr L, int stackPos); // 0x0000000183607F50-0x0000000183607FA0
		public static bool lua_islightuserdata(IntPtr L, int stackPos); // 0x000000018B8AFF0C-0x000000018B8AFF60
		public static bool lua_istable(IntPtr L, int stackPos); // 0x00000001832989B0-0x0000000183298A00
		public static bool lua_isthread(IntPtr L, int stackPos); // 0x00000001832F1A20-0x00000001832F1A90
		public static int luaL_error(IntPtr L, string message); // 0x000000018B8AFCFC-0x000000018B8AFD50
		public static extern int lua_setfenv(IntPtr L, int stackPos); // 0x000000018B8AFF80-0x000000018B8AFF88
		public static extern IntPtr luaL_newstate(); // 0x000000018539323C-0x0000000185393244
		public static extern void lua_close(IntPtr L); // 0x000000018B8AFDF4-0x000000018B8AFDFC
		public static extern void luaopen_xlua(IntPtr L); // 0x00000001853931EC-0x00000001853931F4
		public static extern void luaL_openlibs(IntPtr L); // 0x000000018B8AFDE4-0x000000018B8AFDEC
		public static extern uint xlua_objlen(IntPtr L, int stackPos); // 0x000000018539324C-0x0000000185393254
		public static extern void lua_createtable(IntPtr L, int narr, int nrec); // 0x00000001853932E0-0x00000001853932E8
		public static void lua_newtable(IntPtr L, int arrayL = 0 /* Metadata: 0x0234BF52 */, int hashL = 0 /* Metadata: 0x0234BF53 */); // 0x0000000183607EE0-0x0000000183607F30
		public static extern int xlua_getglobal(IntPtr L, string name); // 0x00000001836085E0-0x0000000183608620
		public static extern int xlua_setglobal(IntPtr L, string name); // 0x0000000183600CB0-0x0000000183600CF0
		public static extern void xlua_getloaders(IntPtr L); // 0x0000000185393244-0x000000018539324C
		public static extern void lua_settop(IntPtr L, int newTop); // 0x0000000185391D14-0x0000000185391D1C
		public static void lua_pop(IntPtr L, int amount); // 0x000000018329D960-0x000000018329D9A0
		public static extern void lua_insert(IntPtr L, int newTop); // 0x0000000185393ED0-0x0000000185393ED8
		public static extern void lua_remove(IntPtr L, int index); // 0x0000000185390E48-0x0000000185390E50
		public static extern int lua_rawget(IntPtr L, int index); // 0x00000001853932D8-0x00000001853932E0
		public static extern void lua_rawset(IntPtr L, int index); // 0x0000000185390AAC-0x0000000185390AB4
		public static extern int lua_setmetatable(IntPtr L, int objIndex); // 0x000000018539327C-0x0000000185393284
		public static extern int lua_rawequal(IntPtr L, int index1, int index2); // 0x000000018B8AFF70-0x000000018B8AFF78
		public static extern void lua_pushvalue(IntPtr L, int index); // 0x00000001853932D0-0x00000001853932D8
		public static extern void lua_pushcclosure(IntPtr L, IntPtr fn, int n); // 0x000000018B8AFF68-0x000000018B8AFF70
		public static extern void lua_replace(IntPtr L, int index); // 0x000000018B8AFF78-0x000000018B8AFF80
		public static extern int lua_gettop(IntPtr L); // 0x0000000185391CCC-0x0000000185391CD4
		public static extern LuaTypes lua_type(IntPtr L, int index); // 0x0000000185391CAC-0x0000000185391CB4
		public static bool lua_isnil(IntPtr L, int index); // 0x0000000183299E00-0x0000000183299E60
		public static extern bool lua_isnumber(IntPtr L, int index); // 0x0000000182F34150-0x0000000182F34170
		public static bool lua_isboolean(IntPtr L, int index); // 0x000000018B8AFEA4-0x000000018B8AFEF8
		public static extern int luaL_ref(IntPtr L, int registryIndex); // 0x00000001853932AC-0x00000001853932C0
		public static int luaL_ref(IntPtr L); // 0x0000000183606FA0-0x0000000183606FF0
		public static extern void xlua_rawgeti(IntPtr L, int tableIndex, long index); // 0x0000000185391CC4-0x0000000185391CCC
		public static extern void xlua_rawseti(IntPtr L, int tableIndex, long index); // 0x0000000185395328-0x0000000185395330
		public static void lua_getref(IntPtr L, int reference); // 0x000000018329B230-0x000000018329B2B0
		public static extern int pcall_prepare(IntPtr L, int error_func_ref, int func_ref); // 0x0000000185391D0C-0x0000000185391D14
		public static extern void luaL_unref(IntPtr L, int registryIndex, int reference); // 0x0000000185391F00-0x0000000185391F08
		public static void lua_unref(IntPtr L, int reference); // 0x00000001832EF630-0x00000001832EF680
		public static extern bool lua_isstring(IntPtr L, int index); // 0x0000000183606CB0-0x0000000183606CD0
		public static extern bool lua_isinteger(IntPtr L, int index); // 0x0000000183F70F90-0x0000000183F70FB0
		public static extern void lua_pushnil(IntPtr L); // 0x0000000185391EF8-0x0000000185391F00
		public static void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, int n = 0 /* Metadata: 0x0234BF54 */); // 0x0000000183298170-0x0000000183298250
		public static extern int xlua_upvalueindex(int n); // 0x00000001853909D0-0x00000001853909D8
		public static int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc); // 0x000000018329E9F0-0x000000018329EB90
		public static extern int _lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc); // 0x0000000185391D24-0x0000000185391D2C
		public static extern double lua_tonumber(IntPtr L, int index); // 0x000000018539097C-0x0000000185390984
		public static extern int xlua_tointeger(IntPtr L, int index); // 0x0000000185390990-0x0000000185390998
		public static extern uint xlua_touint(IntPtr L, int index); // 0x0000000185391444-0x000000018539144C
		public static extern bool lua_toboolean(IntPtr L, int index); // 0x000000018339E8E0-0x000000018339E900
		public static extern IntPtr lua_topointer(IntPtr L, int index); // 0x000000018B8B00AC-0x000000018B8B00B4
		public static extern IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen); // 0x0000000185391C9C-0x0000000185391CA4
		public static string lua_tostring_beyond(IntPtr L, int index); // 0x0000000183298C90-0x0000000183298CD0
		public static string lua_tostring(IntPtr L, int index, bool cache = false /* Metadata: 0x0234BF55 */); // 0x0000000183298CD0-0x0000000183299040
		public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf); // 0x0000000183826DF0-0x0000000183826E20
		public static extern void lua_pushnumber(IntPtr L, double number); // 0x0000000185391D1C-0x0000000185391D24
		public static extern void lua_pushboolean(IntPtr L, bool value); // 0x000000018329A510-0x000000018329A520
		public static extern void xlua_pushinteger(IntPtr L, int value); // 0x0000000183298160-0x0000000183298170
		public static extern void xlua_pushuint(IntPtr L, uint value); // 0x0000000185392CE0-0x0000000185392CE8
		public static void lua_pushstring(IntPtr L, string str); // 0x0000000182F84530-0x0000000182F847C0
		public static extern void xlua_pushlstring(IntPtr L, byte[] str, int size); // 0x0000000182F847C0-0x0000000182F847E0
		public static void xlua_pushasciistring(IntPtr L, string str); // 0x0000000182F847E0-0x0000000182F849C0
		public static void lua_pushstring(IntPtr L, byte[] str); // 0x000000018432B1E0-0x000000018432B230
		public static byte[] lua_tobytes(IntPtr L, int index); // 0x000000018B8AFFD0-0x000000018B8B00AC
		public static extern int luaL_newmetatable(IntPtr L, string meta); // 0x0000000183606330-0x0000000183606370
		public static extern int xlua_pgettable(IntPtr L, int idx); // 0x0000000185391CA4-0x0000000185391CAC
		public static extern int xlua_psettable(IntPtr L, int idx); // 0x0000000185391D04-0x0000000185391D0C
		public static void luaL_getmetatable(IntPtr L, string meta); // 0x0000000183606E10-0x0000000183606E60
		public static extern int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name); // 0x0000000183601710-0x0000000183601780
		public static int luaL_loadbuffer(IntPtr L, string buff, string name); // 0x000000018B8AFD50-0x000000018B8AFDE4
		public static extern int xlua_tocsobj_safe(IntPtr L, int obj); // 0x00000001853909D8-0x00000001853909E0
		public static extern int xlua_tocsobj_fast(IntPtr L, int obj); // 0x0000000185391314-0x000000018539131C
		public static int lua_error(IntPtr L); // 0x000000018B8AFDFC-0x000000018B8AFE48
		public static extern bool lua_checkstack(IntPtr L, int extra); // 0x0000000183606370-0x0000000183606390
		public static extern int lua_next(IntPtr L, int index); // 0x000000018B8AFF60-0x000000018B8AFF68
		public static extern void lua_pushlightuserdata(IntPtr L, IntPtr udata); // 0x0000000185393274-0x000000018539327C
		public static extern IntPtr xlua_tag(); // 0x00000001853932A4-0x00000001853932AC
		public static extern void luaL_where(IntPtr L, int level); // 0x000000018B8AFDEC-0x000000018B8AFDF4
		public static extern int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref); // 0x000000018539130C-0x0000000185391314
		public static extern void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref); // 0x00000001853912F0-0x00000001853912FC
		public static extern int gen_obj_indexer(IntPtr L); // 0x0000000185393284-0x000000018539328C
		public static extern int gen_obj_newindexer(IntPtr L); // 0x000000018539328C-0x0000000185393294
		public static extern int gen_cls_indexer(IntPtr L); // 0x0000000185393294-0x000000018539329C
		public static extern int gen_cls_newindexer(IntPtr L); // 0x000000018539329C-0x00000001853932A4
		public static extern int get_error_func_ref(IntPtr L); // 0x00000001853931FC-0x0000000185393204
		public static extern int load_error_func(IntPtr L, int Ref); // 0x0000000185392E2C-0x0000000185392E34
		public static extern int luaopen_i64lib(IntPtr L); // 0x0000000185393204-0x000000018539320C
		public static extern int luaopen_socket_core(IntPtr L); // 0x000000018B8B00B4-0x000000018B8B00BC
		public static extern void lua_pushint64(IntPtr L, long n); // 0x00000001832978D0-0x00000001832978E0
		public static extern void lua_pushuint64(IntPtr L, ulong n); // 0x000000018539733C-0x0000000185397344
		public static extern bool lua_isint64(IntPtr L, int idx); // 0x000000018B8AFEF8-0x000000018B8AFF0C
		public static extern bool lua_isuint64(IntPtr L, int idx); // 0x000000018B8AFEF8-0x000000018B8AFF0C
		public static extern long lua_toint64(IntPtr L, int idx); // 0x0000000185390990-0x0000000185390998
		public static extern ulong lua_touint64(IntPtr L, int idx); // 0x0000000185390990-0x0000000185390998
		public static extern void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n); // 0x0000000185391C8C-0x0000000185391C94
		public static extern int xlua_csharp_str_error(IntPtr L, string message); // 0x000000018B8B00C4-0x000000018B8B0104
		public static extern int xlua_csharp_error(IntPtr L); // 0x000000018B8B00BC-0x000000018B8B00C4
		public static extern bool xlua_pack_int8_t(IntPtr buff, int offset, byte field); // 0x000000018B8B02CC-0x000000018B8B02E0
		public static extern bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field); // 0x000000018B8B0450-0x000000018B8B0464
		public static extern bool xlua_pack_int16_t(IntPtr buff, int offset, short field); // 0x000000018B8B02A4-0x000000018B8B02B8
		public static extern bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field); // 0x000000018B8B043C-0x000000018B8B0450
		public static extern bool xlua_pack_int32_t(IntPtr buff, int offset, int field); // 0x0000000183B61690-0x0000000183B616B0
		public static extern bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field); // 0x0000000183A1B210-0x0000000183A1B230
		public static extern bool xlua_pack_int64_t(IntPtr buff, int offset, long field); // 0x000000018B8B02B8-0x000000018B8B02CC
		public static extern bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field); // 0x000000018B8B0360-0x000000018B8B0374
		public static extern bool xlua_pack_float(IntPtr buff, int offset, float field); // 0x000000018B8B0290-0x000000018B8B02A4
		public static extern bool xlua_unpack_float(IntPtr buff, int offset, out float field); // 0x000000018B8B0428-0x000000018B8B043C
		public static extern bool xlua_pack_double(IntPtr buff, int offset, double field); // 0x000000018B8B01F4-0x000000018B8B0208
		public static extern bool xlua_unpack_double(IntPtr buff, int offset, out double field); // 0x000000018B8B0360-0x000000018B8B0374
		public static extern IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref); // 0x0000000185391C50-0x0000000185391C58
		public static extern void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref); // 0x000000018B8B0330-0x000000018B8B0338
		public static extern IntPtr lua_touserdata(IntPtr L, int idx); // 0x0000000185391C84-0x0000000185391C8C
		public static extern int xlua_gettypeid(IntPtr L, int idx); // 0x0000000185394850-0x0000000185394858
		public static extern int xlua_get_registry_index(); // 0x000000018539320C-0x0000000185393214
		public static extern int xlua_pgettable_bypath(IntPtr L, int idx, string path); // 0x00000001844BDE60-0x00000001844BDEB0
		public static extern int xlua_psettable_bypath(IntPtr L, int idx, string path); // 0x000000018B8B02E0-0x000000018B8B0330
		public static extern bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2); // 0x00000001832975B0-0x00000001832975D0
		public static extern bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2); // 0x000000018B8B0374-0x000000018B8B0388
		public static extern bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3); // 0x0000000183297650-0x0000000183297680
		public static extern bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3); // 0x00000001849E78C0-0x00000001849E78F0
		public static extern bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4); // 0x0000000183A1C160-0x0000000183A1C190
		public static extern bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4); // 0x000000018B8B0388-0x000000018B8B03B0
		public static extern bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5); // 0x000000018B8B0208-0x000000018B8B0244
		public static extern bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5); // 0x000000018B8B03B0-0x000000018B8B03E4
		public static extern bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5, float f6); // 0x000000018B8B0244-0x000000018B8B0290
		public static extern bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5, out float f6); // 0x000000018B8B03E4-0x000000018B8B0428
		public static extern bool xlua_pack_decimal(IntPtr buff, int offset, ref decimal dec); // 0x000000018B8B01E0-0x000000018B8B01F4
		public static extern bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign, out int hi32, out ulong lo64); // 0x000000018B8B0338-0x000000018B8B0360
		public static bool xlua_is_eq_str(IntPtr L, int index, string str); // 0x000000018B8B0104-0x000000018B8B0184
		public static extern bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len); // 0x000000018B8B0184-0x000000018B8B01E0
		public static extern IntPtr xlua_gl(IntPtr L); // 0x00000001853980C0-0x00000001853980C8
		public static extern int luaL_traceback(IntPtr L, IntPtr L1, string msg, int level); // 0x00000001832F19C0-0x00000001832F1A20
		public static extern int lua_sethook(IntPtr L, XLua.LuaDLL.lua_Hook hook, int mask, int count); // 0x000000018B8AFF88-0x000000018B8AFFC8
		public static extern XLua.LuaDLL.lua_Hook lua_gethook(IntPtr L); // 0x000000018B8AFE50-0x000000018B8AFE94
		public static extern int lua_gethookmask(IntPtr L); // 0x000000018B8AFE94-0x000000018B8AFE9C
		public static extern int lua_getglobal(IntPtr L, IntPtr charPtr); // 0x000000018B8AFE48-0x000000018B8AFE50
		public static extern int lua_pushlstring(IntPtr L, IntPtr charPtr, int len); // 0x00000001853911C8-0x00000001853911D0
		public static extern int luaopen_HyperLua(IntPtr L); // 0x000000018539820C-0x0000000185398214
		public static extern void HyperLua_SetLogCallback(HyperLuaLogCallbackDelegate logCallback); // 0x0000000183826E20-0x0000000183826E40
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadHyperLua(IntPtr L); // 0x0000000184D22950-0x0000000184D229A0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static void SetHyperLuaLogCallback(HyperLuaLogCallbackDelegate logCallback); // 0x0000000184D5DAA0-0x0000000184D5DAF0
		public static extern int luaopen_LuaUtils(IntPtr L); // 0x00000001853981FC-0x0000000185398204
		public static extern void LuaUtils_SetLogCallback(LuaUtilsLogCallbackDelegate logCallback); // 0x0000000183826E40-0x0000000183826E60
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLuaUtils(IntPtr L); // 0x0000000184D228B0-0x0000000184D22900
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static void SetLuaUtilsLogCallback(LuaUtilsLogCallbackDelegate logCallback); // 0x0000000184D5DA50-0x0000000184D5DAA0
		public static extern int luaopen_rapidjson(IntPtr L); // 0x00000001853981F4-0x00000001853981FC
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadRapidJson(IntPtr L); // 0x0000000184D22860-0x0000000184D228B0
		public static extern int luaopen_pb(IntPtr L); // 0x0000000185398204-0x000000018539820C
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLuaProtobuf(IntPtr L); // 0x0000000184D22900-0x0000000184D22950
		public static extern void beyond_setDecryptionFunc(IntPtr L, IntPtr func); // 0x00000001853931F4-0x00000001853931FC
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int lua_Hook(IntPtr L, ref lua_debug ar); // TypeDefIndex: 58850; 0x00000001815802E0-0x00000001815802F0
}

namespace XLua.Reflection
{
	public class LuaObjFieldGetterSetter // TypeDefIndex: 58832
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0<T> // TypeDefIndex: 58814
			where T : struct
		{
			// Fields
			public bool isUnmanagedType;
			public System.Reflection.FieldInfo field;
			public System.Type type;
			public int offset;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal int _GetObjFieldGetterByPushInt32_b__0(IntPtr L);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 58815
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjFloatFieldGetterByPushNumber_b__0(IntPtr L); // 0x0000000183FDBC00-0x0000000183FDBCC0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 58816
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjDoubleFieldGetterByPushNumber_b__0(IntPtr L); // 0x000000018B8B39E4-0x000000018B8B3B60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0<T> // TypeDefIndex: 58817
			where T : struct
		{
			// Fields
			public bool isUnmanagedType;
			public System.Reflection.FieldInfo field;
			public System.Type type;
			public int offset;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal int _GetObjFieldGetterByPushInt64_b__0(IntPtr L);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 58818
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjFieldGetterByPushBool_b__0(IntPtr L); // 0x0000000183DC3010-0x0000000183DC30C0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 58819
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjFieldGetterByPushString_b__0(IntPtr L); // 0x0000000183C33910-0x0000000183C33B40
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 58820
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjFieldObjGetter_b__0(IntPtr L); // 0x000000018329CCE0-0x000000018329CF20
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 58821
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
			public bool isNullable; // 0x2C
			public System.Type filedType; // 0x30
			public int size; // 0x38
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjFieldStructGetter_b__0(IntPtr L); // 0x0000000183E85C70-0x0000000183E85D50
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 58822
		{
			// Fields
			public System.Type type; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public int offset; // 0x20
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjFieldEnumGetter_b__0(IntPtr L); // 0x00000001836FD950-0x00000001836FDA70
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0<T> // TypeDefIndex: 58823
			where T : struct
		{
			// Fields
			public System.Type type;
			public System.Reflection.FieldInfo field;
			public int offset;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal int _GetObjFieldStructGetter_b__0(IntPtr L);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 58824
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjFieldObjSetter_b__0(IntPtr L); // 0x00000001836FD840-0x00000001836FD950
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 58825
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
			public bool isNullable; // 0x2C
			public int size; // 0x30
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjFieldStructSetter_b__0(IntPtr L); // 0x00000001844AC740-0x00000001844AC850
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0<T> // TypeDefIndex: 58826
			where T : struct
		{
			// Fields
			public bool isUnmanagedType;
			public System.Reflection.FieldInfo field;
			public System.Type type;
			public int offset;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal int _GetObjFieldSetterByGetInt32_b__0(IntPtr L);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0<T> // TypeDefIndex: 58827
			where T : struct
		{
			// Fields
			public bool isUnmanagedType;
			public System.Reflection.FieldInfo field;
			public System.Type type;
			public int offset;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal int _GetObjFieldSetterByGetInt64_b__0(IntPtr L);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 58828
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjFloatFieldSetterByGetNumber_b__0(IntPtr L); // 0x00000001849AEF10-0x00000001849AF040
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 58829
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass18_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjDoubleFieldSetterByGetNumber_b__0(IntPtr L); // 0x000000018B8B3150-0x000000018B8B32BC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 58830
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjFieldBoolSetter_b__0(IntPtr L); // 0x00000001841F2450-0x00000001841F2500
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 58831
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _GetObjFieldEnumSetter_b__0(IntPtr L); // 0x000000018B8B32BC-0x000000018B8B3638
		}
	
		// Constructors
		public LuaObjFieldGetterSetter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private static bool _CheckRuntimeType(IntPtr L, object obj, System.Type type, System.Reflection.FieldInfo field); // 0x000000018B8AF2C4-0x000000018B8AF494
		private static IntPtr _GetPtrFromObj(object obj); // 0x000000018B8AF564-0x000000018B8AF5B8
		private static IntPtr _GetPtrFromLuaStack(IntPtr L, ObjectTranslator translator, int index, bool isUnmanagedType); // 0x000000018B8AF494-0x000000018B8AF564
		public static lua_CSFunction GetObjFieldGetterByPushInt32<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct;
		public static lua_CSFunction GetObjFloatFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field); // 0x0000000184221230-0x00000001842212E0
		public static lua_CSFunction GetObjDoubleFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field); // 0x00000001844BB460-0x00000001844BB540
		public static lua_CSFunction GetObjFieldGetterByPushInt64<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct;
		public static lua_CSFunction GetObjFieldGetterByPushBool(System.Type type, System.Reflection.FieldInfo field); // 0x00000001840E3940-0x00000001840E39F0
		public static lua_CSFunction GetObjFieldGetterByPushString(System.Type type, System.Reflection.FieldInfo field); // 0x00000001840FBC40-0x00000001840FBCF0
		public static lua_CSFunction GetObjFieldObjGetter(System.Type type, System.Reflection.FieldInfo field); // 0x0000000182F2BEE0-0x0000000182F2BF90
		public static lua_CSFunction GetObjFieldStructGetter(System.Type type, System.Reflection.FieldInfo field); // 0x0000000183EE0030-0x0000000183EE01C0
		public static lua_CSFunction GetObjFieldEnumGetter(System.Type type, System.Reflection.FieldInfo field); // 0x000000018429F080-0x000000018429F120
		public static lua_CSFunction GetObjFieldStructGetter<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct;
		public static lua_CSFunction GetObjFieldObjSetter(System.Type type, System.Reflection.FieldInfo field); // 0x0000000182F2AB70-0x0000000182F2AC20
		public static lua_CSFunction GetObjFieldStructSetter(System.Type type, System.Reflection.FieldInfo field); // 0x0000000183EE01C0-0x0000000183EE0340
		public static lua_CSFunction GetObjFieldSetterByGetInt32<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct;
		public static lua_CSFunction GetObjFieldSetterByGetInt64<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct;
		public static lua_CSFunction GetObjFloatFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field); // 0x0000000184221180-0x0000000184221230
		public static lua_CSFunction GetObjDoubleFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field); // 0x00000001844BB380-0x00000001844BB460
		public static lua_CSFunction GetObjFieldBoolSetter(System.Type type, System.Reflection.FieldInfo field); // 0x00000001840E39F0-0x00000001840E3AA0
		public static lua_CSFunction GetObjFieldEnumSetter(System.Type type, System.Reflection.FieldInfo field); // 0x0000000184250A50-0x0000000184250B00
	}

	public static class RuntimeEnumDic // TypeDefIndex: 58833
	{
		// Fields
		private static Dictionary<System.Type, Dictionary<int, object>> s_enumDic; // 0x00
	
		// Constructors
		static RuntimeEnumDic(); // 0x0000000184D16EF0-0x0000000184D16F80
	
		// Methods
		public static object GetEnumByTypeAndValue(System.Type enumType, int value); // 0x00000001836FDA70-0x00000001836FDED0
		public static void AddEnumValue(System.Type enumType, object enumObj); // 0x00000001836FD4A0-0x00000001836FD5D0
	}
}

namespace XLua.TemplateEngine
{
	public enum TokenType // TypeDefIndex: 58808
	{
		Code = 0,
		Eval = 1,
		Text = 2
	}

	public class Chunk // TypeDefIndex: 58809
	{
		// Fields
		[CompilerGenerated]
		private XLua.TemplateEngine.TokenType _Type_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Text_k__BackingField; // 0x18
	
		// Properties
		public XLua.TemplateEngine.TokenType Type { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		public string Text { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public Chunk(XLua.TemplateEngine.TokenType type, string text); // 0x0000000185391D70-0x0000000185391D80
	}

	internal class TemplateFormatException : Exception // TypeDefIndex: 58810
	{
		// Constructors
		public TemplateFormatException(string message); // 0x000000018B8B11A8-0x000000018B8B11F4
	}

	public class Parser // TypeDefIndex: 58812
	{
		// Fields
		[CompilerGenerated]
		private static string _RegexString_k__BackingField; // 0x00
	
		// Properties
		public static string RegexString { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018B8B10BC-0x000000018B8B110C 0x000000018B8B110C-0x000000018B8B1168
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58811
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Text.RegularExpressions.Capture, __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int>> __9__7_0; // 0x08
			public static Func<System.Text.RegularExpressions.Capture, __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int>> __9__7_1; // 0x10
			public static Func<System.Text.RegularExpressions.Capture, __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int>> __9__7_2; // 0x18
			public static Func<__f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int>, int> __9__7_3; // 0x20
			public static Func<__f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int>, Chunk> __9__7_4; // 0x28
	
			// Constructors
			static __c(); // 0x000000018B8B41A8-0x000000018B8B420C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int> _Parse_b__7_0(System.Text.RegularExpressions.Capture p); // 0x000000018B8B1A8C-0x000000018B8B1B24
			internal __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int> _Parse_b__7_1(System.Text.RegularExpressions.Capture p); // 0x000000018B8B1B24-0x000000018B8B1BE4
			internal __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int> _Parse_b__7_2(System.Text.RegularExpressions.Capture p); // 0x000000018B8B1BE4-0x000000018B8B1C80
			internal int _Parse_b__7_3(__f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int> p); // 0x000000018B8B1C80-0x000000018B8B1CBC
			internal Chunk _Parse_b__7_4(__f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int> m); // 0x000000018B8B1CBC-0x000000018B8B1D44
		}
	
		// Constructors
		static Parser(); // 0x000000018B8B104C-0x000000018B8B10BC
		public Parser(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private static string EscapeString(string input); // 0x000000018B8B0464-0x000000018B8B06FC
		private static string GetRegexString(); // 0x000000018B8B06FC-0x000000018B8B0934
		public static List<Chunk> Parse(string snippet); // 0x000000018B8B0934-0x000000018B8B104C
	}

	public class LuaTemplate // TypeDefIndex: 58813
	{
		// Fields
		private static lua_CSFunction templateCompileFunction; // 0x00
		private static lua_CSFunction templateExecuteFunction; // 0x08
	
		// Constructors
		public LuaTemplate(); // 0x00000001841E1670-0x00000001841E1680
		static LuaTemplate(); // 0x0000000184CA1250-0x0000000184CA1340
	
		// Methods
		public static string ComposeCode(List<Chunk> chunks); // 0x000000018B8AF818-0x000000018B8AFAA0
		public static LuaFunction Compile(LuaEnv luaenv, string snippet); // 0x000000018B8AF5B8-0x000000018B8AF65C
		public static string Execute(LuaFunction compiledTemplate, LuaTable parameters); // 0x000000018B8AFB74-0x000000018B8AFC04
		public static string Execute(LuaFunction compiledTemplate); // 0x000000018B8AFC04-0x000000018B8AFC7C
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Compile(IntPtr L); // 0x000000018B8AF65C-0x000000018B8AF818
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Execute(IntPtr L); // 0x000000018B8AFAA0-0x000000018B8AFB74
		public static void OpenLib(IntPtr L); // 0x0000000183600B80-0x0000000183600CB0
	}
}
