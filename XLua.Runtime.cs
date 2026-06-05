/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Beyond.Lua;
using Beyond.Reflection;
using Beyond.Scripts.Lua;
using IFix.Core;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.LowLevel;
using UnityEngine.Pool;
using XLua;
using XLua.LuaDLL;

// Image 37: XLua.Runtime.dll - Assembly: XLua.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55971-56214

internal sealed class __f__AnonymousType0<_Type_j__TPar, _Value_j__TPar, _Index_j__TPar> // TypeDefIndex: 55972
{
	// Fields
	private readonly _Type_j__TPar _Type_i__Field;
	private readonly _Value_j__TPar _Value_i__Field;
	private readonly _Index_j__TPar _Index_i__Field;

	// Properties
	public _Type_j__TPar Type { get => default; }
	public _Value_j__TPar Value { get => default; }
	public _Index_j__TPar Index { get => default; }

	// Constructors
	public __f__AnonymousType0() {} // Dummy constructor
	public __f__AnonymousType0(_Type_j__TPar Type, _Value_j__TPar Value, _Index_j__TPar Index) {}

	// Methods
	public override bool Equals(object value) => default;
	public override int GetHashCode() => default;
	public override string ToString() => default;
}

internal sealed class __f__AnonymousType1<_type_j__TPar, _method_j__TPar> // TypeDefIndex: 55973
{
	// Fields
	private readonly _type_j__TPar _type_i__Field;
	private readonly _method_j__TPar _method_i__Field;

	// Properties
	public _type_j__TPar type { get => default; }
	public _method_j__TPar method { get => default; }

	// Constructors
	public __f__AnonymousType1() {} // Dummy constructor
	public __f__AnonymousType1(_type_j__TPar type, _method_j__TPar method) {}

	// Methods
	public override bool Equals(object value) => default;
	public override int GetHashCode() => default;
	public override string ToString() => default;
}

[Serializable]
public class LuaAsset : ScriptableObject // TypeDefIndex: 55976
{
	// Fields
	public static string LuaDecodeKey; // 0x00
	public bool encode; // 0x18
	public byte[] data; // 0x20

	// Constructors
	public LuaAsset() {} // 0x0000000187C9E364-0x0000000187C9E370
	static LuaAsset() {} // 0x000000018C3B3690-0x000000018C3B36EC

	// Methods
	public byte[] GetDecodeBytes() => default; // 0x000000018C3B3608-0x000000018C3B3690
}

namespace Beyond.Lua
{
	public class LuaCypher // TypeDefIndex: 56047
	{
		// Fields
		private const string KEY = "=="; // Metadata: 0x0207C1A5
		private static readonly string[] KEYS; // 0x00
		private const string INITIAL_ASSETS_ROOT_PATH = "Assets/Beyond/InitialAssets/"; // Metadata: 0x0207C1A8
		private static readonly ProfilerMarker decryptionMaker; // 0x08
	
		// Constructors
		public LuaCypher() {} // 0x0000000185492010-0x0000000185492020
		static LuaCypher() {} // 0x0000000185BB9010-0x0000000185BB91D0
	
		// Methods
		private static string GetKey() => default; // 0x000000018C3B43B0-0x000000018C3B46E0
		private static void GetKey(Span<byte> buffer, out int len) {
			len = default;
		} // 0x000000018C3B4144-0x000000018C3B43B0
		protected static bool SkipDecrypt(string luaString) => default; // 0x000000018C3B46E0-0x000000018C3B47F0
		public static string DecryptLuaString(string encryptLua) => default; // 0x000000018C3B392C-0x000000018C3B39C8
		public static byte[] DecryptLua(string encryptLua) => default; // 0x000000018C3B39C8-0x000000018C3B4144
		public static IntPtr DecryptionFunc(IntPtr input, int size, out int outSize) {
			outSize = default;
			return default;
		} // 0x00000001852128F0-0x0000000185213AC0
	}

	public class LuaGenericDelegateCaller // TypeDefIndex: 56049
	{
		// Fields
		private static Dictionary<string, LuaGenericDelegateCall> s_callerDic; // 0x00
	
		// Nested types
		public delegate int LuaGenericDelegateCall(IntPtr L, Delegate @delegate, ObjectTranslator objectTranslator, List<System.Type> castType); // TypeDefIndex: 56048; 0x0000000184E61400-0x0000000184E615E0
	
		// Constructors
		public LuaGenericDelegateCaller() {} // 0x000000018C3B7E08-0x000000018C3B7EA4
		static LuaGenericDelegateCaller() {} // 0x0000000186477E54-0x0000000186477F84
	
		// Methods
		public static LuaGenericDelegateCall GetCaller(string delegateTypeName) => default; // 0x0000000185492010-0x0000000185492020
		public static void AddCaller(string delegateTypeName, LuaGenericDelegateCall caller) {} // 0x0000000185F3F6D0-0x0000000185F3F760
		public static int OverloadMethodCall(IntPtr L, ObjectTranslator objectTranslator, IOverloadMethodWrap[] overload) => default; // 0x0000000183FB1670-0x0000000183FB1700
		public static int DefaultValueMethodCall(IntPtr L, ObjectTranslator objectTranslator, IOverloadMethodWrap[] defaultValues) => default; // 0x00000001817B21C0-0x00000001817B21E0
	}
}

namespace Beyond.Reflection
{
	public class GenericDelegateCaller // TypeDefIndex: 55978
	{
		// Fields
		private static Dictionary<string, System.Type> s_customDelegateTypeDic; // 0x00
	
		// Constructors
		public GenericDelegateCaller() {} // 0x0000000185492010-0x0000000185492020
		static GenericDelegateCaller() {} // 0x000000018576E730-0x000000018576E7C0
	
		// Methods
		public static System.Type GetCustomDelegateType(string delegateName) => default; // 0x00000001843DEEA0-0x00000001843DEF60
		public static void AddCustomDelegateType(string delegateName, System.Type type) {} // 0x0000000184F6E890-0x0000000184F6EA70
	}

	public class MethodParamItem // TypeDefIndex: 55979
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
		public MethodParamItem() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static List<MethodParamItem> GetMethodParamList(MethodInfo method, bool needLua = false /* Metadata: 0x0207C19D */, bool needEnum = false /* Metadata: 0x0207C19E */) => default; // 0x000000018400DA90-0x000000018400E010
		public static string GetMethodSignatureString(MethodInfo method, bool needLua = false /* Metadata: 0x0207C19F */, bool keepType = false /* Metadata: 0x0207C1A0 */, bool needEnum = false /* Metadata: 0x0207C1A1 */) => default; // 0x0000000184398AF0-0x0000000184399430
	}
}

namespace Beyond.Reflection.StructSizeGen
{
	public struct FStructSize0 // TypeDefIndex: 55980
	{
	}

	public struct FStructSize1 // TypeDefIndex: 55981
	{
		// Fields
		public byte b0; // 0x00
	}

	public struct FStructSize2 // TypeDefIndex: 55982
	{
		// Fields
		public short s0; // 0x00
	}

	public struct FStructSize3 // TypeDefIndex: 55983
	{
		// Fields
		public short s0; // 0x00
		public byte b0; // 0x02
	}

	public struct FStructSize4 // TypeDefIndex: 55984
	{
		// Fields
		public int i0; // 0x00
	}

	public struct FStructSize5 // TypeDefIndex: 55985
	{
		// Fields
		public int i0; // 0x00
		public byte b0; // 0x04
	}

	public struct FStructSize8 // TypeDefIndex: 55986
	{
		// Fields
		public long l0; // 0x00
	}

	public struct FStructSize12 // TypeDefIndex: 55987
	{
		// Fields
		public long l0; // 0x00
		public int i0; // 0x08
	}

	public struct FStructSize16 // TypeDefIndex: 55988
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
	}

	public struct FStructSize18 // TypeDefIndex: 55989
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public short s0; // 0x10
	}

	public struct FStructSize20 // TypeDefIndex: 55990
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public int i0; // 0x10
	}

	public struct FStructSize24 // TypeDefIndex: 55991
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
	}

	public struct FStructSize28 // TypeDefIndex: 55992
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public int i0; // 0x18
	}

	public struct FStructSize32 // TypeDefIndex: 55993
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
	}

	public struct FStructSize34 // TypeDefIndex: 55994
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public short s0; // 0x20
	}

	public struct FStructSize36 // TypeDefIndex: 55995
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public int i0; // 0x20
	}

	public struct FStructSize40 // TypeDefIndex: 55996
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
	}

	public struct FStructSize44 // TypeDefIndex: 55997
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public int i0; // 0x28
	}

	public struct FStructSize48 // TypeDefIndex: 55998
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
	}

	public struct FStructSize52 // TypeDefIndex: 55999
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

	public struct FStructSize56 // TypeDefIndex: 56000
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

	public struct FStructSize60 // TypeDefIndex: 56001
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

	public struct FStructSize64 // TypeDefIndex: 56002
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

	public struct FStructSize68 // TypeDefIndex: 56003
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

	public struct FStructSize72 // TypeDefIndex: 56004
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

	public struct FStructSize76 // TypeDefIndex: 56005
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

	public struct FStructSize80 // TypeDefIndex: 56006
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

	public struct FStructSize84 // TypeDefIndex: 56007
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

	public struct FStructSize88 // TypeDefIndex: 56008
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

	public struct FStructSize92 // TypeDefIndex: 56009
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

	public struct FStructSize96 // TypeDefIndex: 56010
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

	public struct FStructSize104 // TypeDefIndex: 56011
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

	public struct FStructSize108 // TypeDefIndex: 56012
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

	public struct FStructSize112 // TypeDefIndex: 56013
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

	public struct FStructSize116 // TypeDefIndex: 56014
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

	public struct FStructSize120 // TypeDefIndex: 56015
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

	public struct FStructSize124 // TypeDefIndex: 56016
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

	public struct FStructSize128 // TypeDefIndex: 56017
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

	public struct FStructSize136 // TypeDefIndex: 56018
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

	public struct FStructSize140 // TypeDefIndex: 56019
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

	public struct FStructSize144 // TypeDefIndex: 56020
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

	public struct FStructSize148 // TypeDefIndex: 56021
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

	public struct FStructSize152 // TypeDefIndex: 56022
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

	public struct FStructSize160 // TypeDefIndex: 56023
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

	public struct FStructSize168 // TypeDefIndex: 56024
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

	public struct FStructSize172 // TypeDefIndex: 56025
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
		public int i0; // 0xA8
	}

	public struct FStructSize176 // TypeDefIndex: 56026
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

	public struct FStructSize180 // TypeDefIndex: 56027
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

	public struct FStructSize184 // TypeDefIndex: 56028
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

	public struct FStructSize192 // TypeDefIndex: 56029
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

	public struct FStructSize196 // TypeDefIndex: 56030
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

	public struct FStructSize200 // TypeDefIndex: 56031
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

	public struct FStructSize208 // TypeDefIndex: 56032
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

	public struct FStructSize216 // TypeDefIndex: 56033
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
	}

	public struct FStructSize220 // TypeDefIndex: 56034
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

	public struct FStructSize224 // TypeDefIndex: 56035
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

	public struct FStructSize232 // TypeDefIndex: 56036
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

	public struct FStructSize240 // TypeDefIndex: 56037
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

	public struct FStructSize248 // TypeDefIndex: 56038
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

	public struct FStructSize256 // TypeDefIndex: 56039
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
	public enum ELuaMultithreadingGCState // TypeDefIndex: 56040
	{
		MinorGC = 0,
		MajorGC = 1
	}

	public class OnGCEndEvent : UnityEvent // TypeDefIndex: 56041
	{
		// Constructors
		public OnGCEndEvent() {} // 0x0000000186470378-0x0000000186470380
	}

	public class LuaMultithreadingGC // TypeDefIndex: 56046
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
		private int m_incGCThreshold; // 0x40
		private OnGCEndEvent m_afterGCEvent; // 0x48
		private List<UnityAction> m_afterGCEventOnceEvents; // 0x50
		public ELuaMultithreadingGCState gcState; // 0x58
		public long mainThreadWait; // 0x60
		public long gcThreadStop; // 0x68
		public bool stop; // 0x70
		public bool isRunning; // 0x71
		private XLua.LuaDLL.lua_Hook hook; // 0x78
		private static XLua.LuaDLL.lua_Hook oldHook; // 0x18
		private static int oldHookMask; // 0x20
		private bool haveRunOnce; // 0x80
		private static readonly ProfilerMarker PROFILER_MARKER_START_GC; // 0x28
		private static readonly ProfilerMarker PROFILER_MARKER_THREAD_NOTIFY; // 0x30
	
		// Nested types
		public struct StartLuaGC // TypeDefIndex: 56042
		{
		}
	
		public struct WaitLuaGC // TypeDefIndex: 56043
		{
		}
	
		public struct OnGCEnd // TypeDefIndex: 56044
		{
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 56045
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<PlayerLoopSystem, bool> __9__41_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000184CC43C0-0x0000000184CC46D0
			public __c() {} // 0x000000018455A590-0x000000018455AC00
	
			// Methods
			internal bool __Dispose_b__41_0(PlayerLoopSystem x) => default; // 0x000000018C3B80E8-0x000000018C3B8188
		}
	
		// Constructors
		public LuaMultithreadingGC() {} // Dummy constructor
		public LuaMultithreadingGC(LuaEnv luaEnv) {} // 0x000000018C3B7F2C-0x000000018C3B7FA4
		static LuaMultithreadingGC() {} // 0x000000018C3BC3B0-0x000000018C3BC474
	
		// Methods
		public void StartGCAsync() {} // 0x0000000184559950-0x0000000184559AF0
		public void NormalStop() {} // 0x0000000185A5F110-0x0000000185A5F160
		public void ForceStopAsyncGC() {} // 0x000000018C3B7EA4-0x000000018C3B7F2C
		public void MainThreadWait() {} // 0x000000018C3B8188-0x000000018C3B81F0
		public void AddLuaAfterGCEvent(UnityAction action) {} // 0x0000000184559AF0-0x0000000184559C10
		public void AddLuaAfterGCOnceEvent(UnityAction action) {} // 0x0000000184B25570-0x0000000184B25CC0
		public void RemoveLuaAfterGCEvent(UnityAction action) {} // 0x000000018C3B81F0-0x000000018C3B86C0
		private void _OnGCEnd() {} // 0x0000000184B281C0-0x0000000184B28270
		private void _Init() {} // 0x000000018C3B7FA4-0x000000018C3B80E8
		private void _Dispose() {} // 0x000000018C3B86C0-0x000000018C3B88A4
		private static int _FindLoopSystemIndex(PlayerLoopSystem[] playerLoopList, string typeName) => default; // 0x00000001847C40E0-0x00000001847C4120
		public static int LuaHook(IntPtr L, ref lua_debug ar) => default; // 0x00000001847C2CF0-0x00000001847C2DD0
		private void _UpdateOldHook() {} // 0x00000001847C4120-0x00000001847C4420
		private bool _DoLock() => default; // 0x0000000185DAB8A0-0x0000000185DAB9B0
		private bool _DoGc(int work = 0 /* Metadata: 0x0207C1A4 */) => default; // 0x000000018C3BCAFC-0x000000018C3BCB60
		private void _GCMethodWrapper() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 56211
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64780-0x0000000185F647F0
	
		// Methods
		public System.Type __Gen_Wrap_0(object P0) => default; // 0x000000018C3C54E0-0x000000018C3C55BC
		public void __Gen_Wrap_1(object P0, object P1) {} // 0x00000001873527E8-0x00000001873528C4
		public List<MethodParamItem> __Gen_Wrap_2(object P0, bool P1, bool P2) => default; // 0x000000018C3C5C38-0x000000018C3C5D4C
		public string __Gen_Wrap_3(object P0, bool P1, bool P2, bool P3) => default; // 0x000000018C3C5D4C-0x000000018C3C5E74
		public void __Gen_Wrap_4(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public bool __Gen_Wrap_5(PlayerLoopSystem P0) => default; // 0x000000018C3C5E74-0x000000018C3C5F78
		public int __Gen_Wrap_6(object P0, object P1) => default; // 0x00000001876A48A4-0x00000001876A4990
		public int __Gen_Wrap_7(IntPtr P0, ref lua_debug P1) => default; // 0x000000018C3C5F78-0x000000018C3C60E4
		public bool __Gen_Wrap_8(object P0) => default; // 0x000000018735B960-0x000000018735BA30
		public bool __Gen_Wrap_9(object P0, int P1) => default; // 0x000000018768D9EC-0x000000018768DAD8
		public string __Gen_Wrap_10() => default; // 0x000000018C3C55BC-0x000000018C3C5674
		public void __Gen_Wrap_11(Span<byte> P0, out int P1) {
			P1 = default;
		} // 0x000000018C3C5674-0x000000018C3C5798
		public byte[] __Gen_Wrap_12(object P0) => default; // 0x000000018C3C5798-0x000000018C3C5874
		public string __Gen_Wrap_13(object P0) => default; // 0x000000018C3C5874-0x000000018C3C5950
		public IntPtr __Gen_Wrap_14(IntPtr P0, int P1, out int P2) {
			P2 = default;
			return default;
		} // 0x000000018C3C5950-0x000000018C3C5A68
		public LuaGenericDelegateCaller.LuaGenericDelegateCall __Gen_Wrap_15(object P0) => default; // 0x000000018C3C5A68-0x000000018C3C5B44
		public int __Gen_Wrap_16(IntPtr P0, object P1, object P2) => default; // 0x000000018C3C5B44-0x000000018C3C5C38
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 56212
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018C3C60E4-0x000000018C3C6178
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 56213
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000186470080-0x00000001864700E4
		public static bool IsPatched(int id) => default; // 0x0000000184559C10-0x0000000184559C80
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018C3CDA3C-0x000000018C3CDB08
		public object CreateWrapper(int id) => default; // 0x000000018C3CDB08-0x000000018C3CDB80
		public object InitWrapperArray(int len) => default; // 0x000000018C3CDB80-0x000000018C3CDC0C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018C3CD998-0x000000018C3CDA3C
	}

	public enum IDMAP0 // TypeDefIndex: 56214
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
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 55974
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Security
{
	public sealed class XXTEA // TypeDefIndex: 55977
	{
		// Fields
		private static readonly UTF8Encoding utf8; // 0x00
		private const uint delta = 2654435769; // Metadata: 0x0207C198
	
		// Constructors
		private XXTEA() {} // 0x0000000185492010-0x0000000185492020
		static XXTEA() {} // 0x000000018C3BE250-0x000000018C3BE2CC
	
		// Methods
		private static uint MX(uint sum, uint y, uint z, int p, uint e, uint[] k) => default; // 0x000000018C3BDA98-0x000000018C3BDB3C
		public static byte[] Encrypt(byte[] data, byte[] key) => default; // 0x000000018C3BD838-0x000000018C3BD8D4
		public static byte[] Encrypt(string data, byte[] key) => default; // 0x000000018C3BD55C-0x000000018C3BD5D8
		public static byte[] Encrypt(byte[] data, string key) => default; // 0x000000018C3BD8D4-0x000000018C3BD950
		public static byte[] Encrypt(string data, string key) => default; // 0x000000018C3BD5D8-0x000000018C3BD678
		public static string EncryptToBase64String(byte[] data, byte[] key) => default; // 0x000000018C3BD46C-0x000000018C3BD4E4
		public static string EncryptToBase64String(string data, byte[] key) => default; // 0x000000018C3BD4E4-0x000000018C3BD55C
		public static string EncryptToBase64String(byte[] data, string key) => default; // 0x000000018C3BD37C-0x000000018C3BD3F4
		public static string EncryptToBase64String(string data, string key) => default; // 0x000000018C3BD3F4-0x000000018C3BD46C
		public static byte[] Decrypt(byte[] data, byte[] key) => default; // 0x000000018C3BD25C-0x000000018C3BD2F8
		private static int _Decrypt(Span<byte> data, Span<byte> key, Span<byte> result) => default; // 0x000000018C3BDFA0-0x000000018C3BE250
		public static byte[] Decrypt(byte[] data, string key) => default; // 0x000000018C3BD1E0-0x000000018C3BD25C
		public static int Decrypt(Span<byte> data, Span<byte> key, Span<byte> result) => default; // 0x000000018C3BD2F8-0x000000018C3BD37C
		public static byte[] DecryptBase64String(string data, byte[] key) => default; // 0x000000018C3BCC68-0x000000018C3BCCE0
		public static byte[] DecryptBase64String(string data, string key) => default; // 0x000000018C3BCCE0-0x000000018C3BCD58
		public static string DecryptToString(byte[] data, byte[] key) => default; // 0x000000018C3BCF34-0x000000018C3BCFB8
		public static string DecryptToString(byte[] data, string key) => default; // 0x000000018C3BCFB8-0x000000018C3BD03C
		public static string DecryptBase64StringToString(string data, byte[] key) => default; // 0x000000018C3BCBE4-0x000000018C3BCC68
		public static string DecryptBase64StringToString(string data, string key) => default; // 0x000000018C3BCB60-0x000000018C3BCBE4
		private static uint[] Encrypt(uint[] v, uint[] k) => default; // 0x000000018C3BD678-0x000000018C3BD838
		private static uint[] Decrypt(uint[] v, uint[] k) => default; // 0x000000018C3BD03C-0x000000018C3BD1E0
		private static void DecryptInPlace(Span<uint> v, Span<uint> k) {} // 0x000000018C3BCD58-0x000000018C3BCF34
		private static uint MxForSpan(uint sum, uint y, uint z, int p, uint e, Span<uint> k) => default; // 0x000000018C3BDB3C-0x000000018C3BDBA0
		private static byte[] FixKey(byte[] key) => default; // 0x000000018C3BDA00-0x000000018C3BDA98
		private static void FixKey(Span<byte> key, Span<byte> fixedkey) {} // 0x000000018C3BD950-0x000000018C3BDA00
		private static uint[] ToUInt32Array(byte[] data, bool includeLength) => default; // 0x000000018C3BDEB0-0x000000018C3BDFA0
		private static void ToUInt32Array(Span<byte> data, bool includeLength, Span<uint> result) {} // 0x000000018C3BDDC0-0x000000018C3BDEB0
		private static byte[] ToByteArray(uint[] data, bool includeLength) => default; // 0x000000018C3BDBA0-0x000000018C3BDC7C
		private static void ToByteSpanFromUInt32(Span<uint> data, bool includeLength, Span<byte> result, out int len) {
			len = default;
		} // 0x000000018C3BDC7C-0x000000018C3BDDC0
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 55975
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace XLua
{
	public class CopyByValue // TypeDefIndex: 56050
	{
		// Fields
		public static CopyByValue Instance; // 0x00
	
		// Constructors
		public CopyByValue() {} // 0x0000000185492010-0x0000000185492020
		static CopyByValue() {} // 0x0000000185F7A170-0x0000000185F7A1D0
	
		// Methods
		public bool Pack(IntPtr buff, int offset, byte field) => default; // 0x000000018C3B2B2C-0x000000018C3B2B90
		public bool UnPack(IntPtr buff, int offset, out byte field) {
			field = default;
			return default;
		} // 0x000000018C3B328C-0x000000018C3B32F0
		public bool Pack(IntPtr buff, int offset, sbyte field) => default; // 0x000000018C3B2A68-0x000000018C3B2ACC
		public bool UnPack(IntPtr buff, int offset, out sbyte field) {
			field = default;
			return default;
		} // 0x000000018C3B321C-0x000000018C3B328C
		public bool Pack(IntPtr buff, int offset, short field) => default; // 0x000000018C3B2B90-0x000000018C3B2BF4
		public bool UnPack(IntPtr buff, int offset, out short field) {
			field = default;
			return default;
		} // 0x000000018C3B31B8-0x000000018C3B321C
		public bool Pack(IntPtr buff, int offset, ushort field) => default; // 0x000000018C3B2D84-0x000000018C3B2DE8
		public bool UnPack(IntPtr buff, int offset, out ushort field) {
			field = default;
			return default;
		} // 0x000000018C3B2EB0-0x000000018C3B2F30
		public bool Pack(IntPtr buff, int offset, int field) => default; // 0x0000000184CF4D60-0x0000000184CF4DE0
		public bool UnPack(IntPtr buff, int offset, out int field) {
			field = default;
			return default;
		} // 0x0000000184D27620-0x0000000184D276A0
		public bool Pack(IntPtr buff, int offset, uint field) => default; // 0x000000018C3B2ACC-0x000000018C3B2B2C
		public bool UnPack(IntPtr buff, int offset, out uint field) {
			field = default;
			return default;
		} // 0x000000018C3B2F94-0x000000018C3B3004
		public bool Pack(IntPtr buff, int offset, long field) => default; // 0x000000018C3B2D20-0x000000018C3B2D84
		public bool UnPack(IntPtr buff, int offset, out long field) {
			field = default;
			return default;
		} // 0x000000018C3B2E4C-0x000000018C3B2EB0
		public bool Pack(IntPtr buff, int offset, ulong field) => default; // 0x000000018C3B2CBC-0x000000018C3B2D20
		public bool UnPack(IntPtr buff, int offset, out ulong field) {
			field = default;
			return default;
		} // 0x000000018C3B3144-0x000000018C3B31B8
		public bool Pack(IntPtr buff, int offset, float field) => default; // 0x000000018C3B2C58-0x000000018C3B2CBC
		public bool UnPack(IntPtr buff, int offset, out float field) {
			field = default;
			return default;
		} // 0x000000018C3B2F30-0x000000018C3B2F94
		public bool Pack(IntPtr buff, int offset, double field) => default; // 0x000000018C3B2BF4-0x000000018C3B2C58
		public bool UnPack(IntPtr buff, int offset, out double field) {
			field = default;
			return default;
		} // 0x000000018C3B30E0-0x000000018C3B3144
		public bool Pack(IntPtr buff, int offset, decimal field) => default; // 0x000000018C3B2DE8-0x000000018C3B2E4C
		public bool UnPack(IntPtr buff, int offset, out decimal field) {
			field = default;
			return default;
		} // 0x000000018C3B3004-0x000000018C3B30E0
		public bool IsStruct(System.Type type) => default; // 0x0000000184343F40-0x0000000184343F90
	}

	public abstract class DelegateBridgeBase : LuaBase // TypeDefIndex: 56051
	{
		// Fields
		private System.Type firstKey; // 0x20
		private Delegate firstValue; // 0x28
		private Dictionary<System.Type, Delegate> bindTo; // 0x30
		public int errorFuncRef; // 0x38
	
		// Properties
		public bool IsDispose { get; } // 0x0000000181C2FD60-0x0000000181C2FD70 
	
		// Constructors
		protected DelegateBridgeBase() {} // Dummy constructor
		public DelegateBridgeBase(int reference, LuaEnv luaenv) {} // 0x0000000185167420-0x0000000185167460
	
		// Methods
		public bool TryGetDelegate(System.Type key, out Delegate value) {
			value = default;
			return default;
		} // 0x000000018545B200-0x000000018545B2A0
		public void AddDelegate(System.Type key, Delegate value) {} // 0x00000001850E1030-0x00000001850E11C0
		public virtual Delegate GetDelegateByType(System.Type type) => default; // 0x00000001813AE580-0x00000001813AE590
	}

	public static class HotfixDelegateBridge // TypeDefIndex: 56052
	{
		// Methods
		public static bool xlua_get_hotfix_flag(int idx) => default; // 0x000000018C3B34F0-0x000000018C3B3580
		public static DelegateBridge Get(int idx) => default; // 0x000000018C3B32F8-0x000000018C3B335C
		public static void Set(int idx, DelegateBridge val) {} // 0x000000018C3B335C-0x000000018C3B34F0
	}

	public class DelegateBridge : DelegateBridgeBase // TypeDefIndex: 56057
	{
		// Fields
		internal static DelegateBridge[] DelegateBridgeList; // 0x00
		public static bool Gen_Flag; // 0x08
		public static Func<DelegateBridge, System.Type, Delegate> GetDelegateTypeDelegate; // 0x10
	
		// Nested types
		private sealed class __c__DisplayClass8_0<T1> // TypeDefIndex: 56053
		{
			// Fields
			public DelegateBridge __4__this;
			public T1 p1;
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x000000018C3B32F0-0x000000018C3B32F8
	
			// Methods
			internal void _ActionAfterGC_b__0() {} // 0x0000000184774DC0-0x0000000184774E90
		}
	
		private sealed class __c__DisplayClass10_0<T1, T2> // TypeDefIndex: 56054
		{
			// Fields
			public DelegateBridge __4__this;
			public T1 p1;
			public T2 p2;
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x00000001851E9DE0-0x00000001851E9E60
	
			// Methods
			internal void _ActionAfterGC_b__0() {} // 0x0000000184772290-0x00000001847723D0
		}
	
		private sealed class __c__DisplayClass12_0<T1, T2, T3> // TypeDefIndex: 56055
		{
			// Fields
			public DelegateBridge __4__this;
			public T1 p1;
			public T2 p2;
			public T3 p3;
	
			// Constructors
			public __c__DisplayClass12_0() {}
	
			// Methods
			internal void _ActionAfterGC_b__0() {}
		}
	
		private sealed class __c__DisplayClass14_0<T1, T2, T3, T4> // TypeDefIndex: 56056
		{
			// Fields
			public DelegateBridge __4__this;
			public T1 p1;
			public T2 p2;
			public T3 p3;
			public T4 p4;
	
			// Constructors
			public __c__DisplayClass14_0() {}
	
			// Methods
			internal void _ActionAfterGC_b__0() {}
		}
	
		// Constructors
		public DelegateBridge() {} // Dummy constructor
		public DelegateBridge(int reference, LuaEnv luaenv) {}
		static DelegateBridge() {}
	
		// Methods
		public void PCall(IntPtr L, int nArgs, int nResults, int errFunc) {}
		public override Delegate GetDelegateByType(System.Type type) => default;
		public void Action() {}
		public void Action<T1>(T1 p1) {}
		private void ActionAfterGC<T1>(T1 p1) {}
		public void Action<T1, T2>(T1 p1, T2 p2) {}
		private void ActionAfterGC<T1, T2>(T1 p1, T2 p2) {}
		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3) {}
		private void ActionAfterGC<T1, T2, T3>(T1 p1, T2 p2, T3 p3) {} // 0x0000000185F1EC70-0x0000000185F1ED20
		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4) {}
		private void ActionAfterGC<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4) {}
		public TResult Func<TResult>() => default;
		public TResult Func<T1, TResult>(T1 p1) => default;
		public TResult Func<T1, T2, TResult>(T1 p1, T2 p2) => default;
		public TResult Func<T1, T2, T3, TResult>(T1 p1, T2 p2, T3 p3) => default;
		public TResult Func<T1, T2, T3, T4, TResult>(T1 p1, T2 p2, T3 p3, T4 p4) => default;
	}

	public enum GenFlag // TypeDefIndex: 56058
	{
		No = 0,
		GCOptimize = 1
	}

	public class LuaCallCSharpAttribute : Attribute // TypeDefIndex: 56059
	{
		// Fields
		private GenFlag flag; // 0x10
	
		// Properties
		public GenFlag Flag { get => default; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
	
		// Constructors
		public LuaCallCSharpAttribute() {} // Dummy constructor
		public LuaCallCSharpAttribute(GenFlag flag = GenFlag.No /* Metadata: 0x0207C1C7 */) {} // 0x0000000181378230-0x0000000181378240
	}

	public class CSharpCallLuaAttribute : Attribute // TypeDefIndex: 56060
	{
		// Constructors
		public CSharpCallLuaAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class BlackListAttribute : Attribute // TypeDefIndex: 56061
	{
		// Constructors
		public BlackListAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum OptimizeFlag // TypeDefIndex: 56062
	{
		Default = 0,
		PackAsTable = 1,
		Custom = 2
	}

	public class GCOptimizeAttribute : Attribute // TypeDefIndex: 56063
	{
		// Fields
		private OptimizeFlag flag; // 0x10
	
		// Properties
		public OptimizeFlag Flag { get => default; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
	
		// Constructors
		public GCOptimizeAttribute() {} // Dummy constructor
		public GCOptimizeAttribute(OptimizeFlag flag = OptimizeFlag.Default /* Metadata: 0x0207C1CB */) {} // 0x0000000181378230-0x0000000181378240
	}

	public class ReflectionUseAttribute : Attribute // TypeDefIndex: 56064
	{
		// Constructors
		public ReflectionUseAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class DoNotGenAttribute : Attribute // TypeDefIndex: 56065
	{
		// Constructors
		public DoNotGenAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class AdditionalPropertiesAttribute : Attribute // TypeDefIndex: 56066
	{
		// Constructors
		public AdditionalPropertiesAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum HotfixFlag // TypeDefIndex: 56067
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

	public class HotfixAttribute : Attribute // TypeDefIndex: 56068
	{
		// Fields
		private HotfixFlag flag; // 0x10
	
		// Properties
		public HotfixFlag Flag { get => default; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
	
		// Constructors
		public HotfixAttribute() {} // Dummy constructor
		public HotfixAttribute(HotfixFlag e = HotfixFlag.Stateless /* Metadata: 0x0207C1D9 */) {} // 0x0000000181378230-0x0000000181378240
	}

	internal class HotfixDelegateAttribute : Attribute // TypeDefIndex: 56069
	{
		// Constructors
		public HotfixDelegateAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class SysGenConfig // TypeDefIndex: 56070
	{
		// Properties
		private static List<System.Type> GCOptimize { get; } // 0x000000018C3BBDF0-0x000000018C3BBFE4 
		private static Dictionary<System.Type, List<string>> AdditionalProperties { get; } // 0x000000018C3BBB6C-0x000000018C3BBDF0 
	}

	public class InternalGlobals // TypeDefIndex: 56073
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
		public delegate bool TryArrayGet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int index); // TypeDefIndex: 56071; 0x000000018592B900-0x000000018592BE20
	
		public delegate bool TryArraySet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx); // TypeDefIndex: 56072; 0x00000001864BBBD0-0x00000001864BBD00
	
		// Constructors
		public InternalGlobals() {} // 0x000000018C3BC0A4-0x000000018C3BC16C
		static InternalGlobals() {} // 0x00000001864BBBD0-0x00000001864BBD00
	}

	public abstract class LuaBase : IDisposable // TypeDefIndex: 56074
	{
		// Fields
		public bool disposed; // 0x10
		public readonly int luaReference; // 0x14
		public readonly LuaEnv luaEnv; // 0x18
	
		// Constructors
		protected LuaBase() {} // Dummy constructor
		public LuaBase(int reference, LuaEnv luaenv) {} // 0x000000018646F290-0x000000018646F2A0
	
		// Methods
		~LuaBase() {} // 0x00000001853BB8E0-0x00000001853BB930
		public void Dispose() {} // 0x000000018454F6D0-0x000000018454F730
		public virtual void Dispose(bool disposeManagedResources) {} // 0x000000018454F730-0x000000018454F820
		public override bool Equals(object o) => default; // 0x000000018C3B36EC-0x000000018C3B3824
		public override int GetHashCode() => default; // 0x000000018C3B3824-0x000000018C3B38D8
		public virtual void push(IntPtr L) {} // 0x000000018C3B38D8-0x000000018C3B392C
	}

	public struct lua_debug // TypeDefIndex: 56075
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

	public struct lua_state // TypeDefIndex: 56076
	{
		// Fields
		public IntPtr ptr; // 0x00
		public byte byte1; // 0x08
		public byte byte2; // 0x09
		public byte status; // 0x0A
		public byte allowhook; // 0x0B
	}

	public delegate int lua_Hook(IntPtr L, ref lua_debug ar); // TypeDefIndex: 56077; 0x0000000181B59400-0x0000000181B59410

	public static class LuaDeadLoopCheck // TypeDefIndex: 56079
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
		private sealed class __c // TypeDefIndex: 56078
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Stopwatch> __9__7_0; // 0x08
			public static Action<Stopwatch> __9__7_1; // 0x10
			public static Action<Stopwatch> __9__7_2; // 0x18
	
			// Constructors
			static __c() {} // 0x000000018C3B4A90-0x000000018C3B7064
			public __c() {} // 0x000000018C3B7064-0x000000018C3B7394
	
			// Methods
			internal Stopwatch _EnableCheck_b__7_0() => default; // 0x000000018C3B4A58-0x000000018C3B4A90
			internal void _EnableCheck_b__7_1(Stopwatch sw) {} // 0x00000001847753F0-0x0000000184775530
			internal void _EnableCheck_b__7_2(Stopwatch sw) {} // 0x0000000184EC2D10-0x0000000184EC2E70
		}
	
		// Methods
		public static void EnableCheck(IntPtr L) {} // 0x000000018C3B47F0-0x000000018C3B4A58
		public static int LuaHook(IntPtr L, ref lua_debug ar) => default; // 0x0000000183F8B990-0x0000000183F8BD20
		public static void DisableCheck(IntPtr L) {} // 0x0000000185492010-0x0000000185492020
		public static void PushTime() {} // 0x0000000183F8B330-0x0000000183F8B630
		public static void PopTime() {} // 0x0000000183F8B630-0x0000000183F8B970
		public static void CheckDeadLoop() {} // 0x0000000183F8B970-0x0000000183F8B990
	}

	public interface ILoadLuaProxy // TypeDefIndex: 56080
	{
		// Methods
		byte[] LoadLua(string name);
	}

	public class LoadLuaProxyModule // TypeDefIndex: 56081
	{
		// Fields
		private static ILoadLuaProxy s_loadLuaProxy; // 0x00
	
		// Constructors
		public LoadLuaProxyModule() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void RegisterProxy(ILoadLuaProxy loadLuaProxy) {} // 0x000000018C3B35B8-0x000000018C3B3608
		public static ILoadLuaProxy GetLoadLuaProxy() => default; // 0x000000018C3B3580-0x000000018C3B35B8
	}

	public class LuaEnv : IDisposable // TypeDefIndex: 56084
	{
		// Fields
		public const string CSHARP_NAMESPACE = "xlua_csharp_namespace"; // Metadata: 0x0207C1FF
		public const string MAIN_SHREAD = "xlua_main_thread"; // Metadata: 0x0207C215
		private LuaMultithreadingGC m_luaMultithreadingGC; // 0x10
		public static bool ENABLE_MULTITHREAD_GC; // 0x00
		public bool isQuittingApplication; // 0x18
		public IntPtr rawL; // 0x20
		private LuaTable _G; // 0x28
		public ObjectTranslator translator; // 0x30
		public int errorFuncRef; // 0x38
		private const int LIB_VERSION_EXPECT = 105; // Metadata: 0x0207C226
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
		public IntPtr L { get => default; } // 0x000000018C3B78EC-0x000000018C3B7900 
		public LuaTable Global { get => default; } // 0x0000000184C332F0-0x0000000184C33440 
		public int GcPause { get => default; set {} } // 0x000000018C3B76A8-0x000000018C3B76FC 0x000000018C3B7954-0x000000018C3B79A4
		public int GcStepmul { get => default; set {} } // 0x000000018C3B7900-0x000000018C3B7954 0x000000018C3B7704-0x000000018C3B7768
		public int Memroy { get => default; } // 0x000000018A2FF9D4-0x000000018A2FF9F8 
	
		// Nested types
		internal struct GCAction // TypeDefIndex: 56082
		{
			// Fields
			public int Reference; // 0x00
			public bool IsDelegate; // 0x04
		}
	
		public delegate byte[] CustomLoader(ref string filepath); // TypeDefIndex: 56083; 0x0000000184771640-0x00000001847716B0
	
		// Constructors
		public LuaEnv() {}
		static LuaEnv() {} // 0x00000001872076D8-0x00000001872076F4
	
		// Methods
		public bool IsEnableMultithreadGC() => default; // 0x000000018C3B7394-0x000000018C3B73D4
		public bool IsLuaGCing() => default; // 0x000000018C3B73F4-0x000000018C3B7450
		public bool AddLuaEventAfterGCDo(UnityAction action) => default; // 0x000000018C3B77D8-0x000000018C3B77EC
		public void RemoveLuaEventAfterGCDo(UnityAction action) {} // 0x000000018C3B79A4-0x000000018C3B79D4
		public void AddOnceLuaEventAfterGCDo(UnityAction action) {} // 0x0000000184C34060-0x0000000184C34CF0
		public void CriticalLuaCallWaitLuaGC() {} // 0x00000001859DD8F0-0x00000001859DDA40
		public void MainThreadWait() {} // 0x00000001813B8590-0x00000001813B85A0
		public void StopMultiGC() {}
		public static void AddIniter(Action<LuaEnv, ObjectTranslator> initer) {} // 0x000000018C3B7768-0x000000018C3B77D8
		public T LoadString<T>(byte[] chunk, string chunkName = "chunk" /* Metadata: 0x0207C1DA */, LuaTable env = null) => default; // 0x000000018C3B7638-0x000000018C3B76A8
		public T LoadString<T>(string chunk, string chunkName = "chunk" /* Metadata: 0x0207C1E0 */, LuaTable env = null) => default; // 0x0000000184C331B0-0x0000000184C33280
		public LuaFunction LoadString(string chunk, string chunkName = "chunk" /* Metadata: 0x0207C1E6 */, LuaTable env = null) => default; // 0x0000000186472154-0x0000000186472174
		public object[] DoString(byte[] chunk, string chunkName = "chunk" /* Metadata: 0x0207C1EC */, LuaTable env = null) => default; // 0x000000018598E9F0-0x000000018598EA70
		public object[] DoString(string chunk, string chunkName = "chunk" /* Metadata: 0x0207C1F2 */, LuaTable env = null) => default;
		public object[] DoFile(string luaFile, string chunkName = "chunk" /* Metadata: 0x0207C1F8 */, LuaTable env = null) => default;
		public object[] DoFile(string luaFile, LuaTable env = null) => default;
		public object[] CallGlobalFunction(string funcName) => default; // 0x0000000184C319C0-0x0000000184C33040
		public object[] CallGlobalFunction<T0>(string funcName, T0 param0) => default; // 0x0000000184CFCE80-0x0000000184CFD0F0
		public void SetGlobalTable<K, V>(K key, V value) {} // 0x0000000184552480-0x0000000184553130
		public V GetGlobalTable<K, V>(K key) => default; // 0x0000000185D78B60-0x0000000185D798F0
		public void InitCacheString() {} // 0x000000018455A500-0x000000018455A520
		public string TryGetLuaString(IntPtr p) => default; // 0x0000000184C34CF0-0x0000000184C34E90
		public void RefString(IntPtr L, IntPtr strPoint, int index, string ss) {} // 0x000000018C3B73D4-0x000000018C3B73F4
		public void ReleaseStringCache(bool dispose = true /* Metadata: 0x0207C1FE */) {} // 0x0000000184AAB8C0-0x0000000184AAB9D0
		public void AutoFreeStringCache() {} // 0x0000000184FD2420-0x0000000184FD2460
		private void AddSearcher(lua_CSFunction searcher, int index) {} // 0x00000001845595D0-0x0000000184559950
		public void Alias(System.Type type, string alias) {} // 0x000000018C3B76FC-0x000000018C3B7704
		private static bool ObjectValidCheck(object obj) => default; // 0x000000018C3B77EC-0x000000018C3B78EC
		public void ClearAllUserdata() {} // 0x000000018C3B7AE4-0x000000018C3B7AEC
		public void CleanTick() {} // 0x000000018C3B75AC-0x000000018C3B7638
		public void GC() {} // 0x000000018C3B7450-0x000000018C3B75AC
		public LuaTable NewTable() => default; // 0x000000018C3B79D4-0x000000018C3B7AE4
		public void WaitForGCComplete() {} // 0x00000001852C48A0-0x00000001852C4C40
		public void Dispose() {} // 0x0000000185F81060-0x0000000185F810C0
		public virtual void Dispose(bool dispose) {} // 0x0000000184C33EF0-0x0000000184C33F90
		public void ThrowExceptionFromError(int oldTop) {} // 0x000000018C3B7AEC-0x000000018C3B7B6C
		internal void equeueGCAction(GCAction action) {} // 0x000000018C3B7BEC-0x000000018C3B7C4C
		public void AddLoader(CustomLoader loader) {} // 0x000000018C3B7B6C-0x000000018C3B7BEC
		public void AddBuildin(string name, lua_CSFunction initer) {} // 0x000000018C3B7C4C-0x000000018C3B7CAC
		public void FullGc() {} // 0x00000001845591C0-0x0000000184559230
		public void StopGc() {} // 0x0000000185F7C390-0x0000000185F7C400
		public void RestartGc() {} // 0x000000018563DEC0-0x000000018563DF40
		public bool GcStep(int data) => default; // 0x00000001817C2F70-0x00000001817C2F80
	}

	[Serializable]
	public class LuaException : Exception // TypeDefIndex: 56085
	{
		// Constructors
		public LuaException() {} // Dummy constructor
		public LuaException(string message) {} // 0x000000018C3B7CAC-0x000000018C3B7D08
	}

	public class LuaFunction : LuaBase // TypeDefIndex: 56088
	{
		// Nested types
		private sealed class __c__DisplayClass2_0<T> // TypeDefIndex: 56086
		{
			// Fields
			public LuaFunction __4__this;
			public T a;
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018646F290-0x000000018646F2A0
	
			// Methods
			internal void _ActionAfterGC_b__0() {}
		}
	
		private sealed class __c__DisplayClass5_0<T1, T2> // TypeDefIndex: 56087
		{
			// Fields
			public LuaFunction __4__this;
			public T1 a1;
			public T2 a2;
	
			// Constructors
			public __c__DisplayClass5_0() {}
	
			// Methods
			internal void _ActionAfterGC_b__0() {}
		}
	
		// Constructors
		public LuaFunction() {} // Dummy constructor
		public LuaFunction(int reference, LuaEnv luaenv) {}
	
		// Methods
		public void Action<T>(T a) {}
		private void ActionAfterGC<T>(T a) {}
		public TResult Func<T, TResult>(T a) => default; // 0x00000001847730B0-0x0000000184773290
		public void Action<T1, T2>(T1 a1, T2 a2) {} // 0x000000018646EA64-0x000000018646EA70
		private void ActionAfterGC<T1, T2>(T1 a1, T2 a2) {}
		public TResult Func<T1, T2, TResult>(T1 a1, T2 a2) => default; // 0x000000018C3B7D08-0x000000018C3B7DC0
		public object[] Call(object[] args, System.Type[] returnTypes) => default; // 0x0000000185F81000-0x0000000185F81060
		public object[] Call(object[] args) => default; // 0x000000018C3B7DC0-0x000000018C3B7E08
		public T Cast<T>() => default;
		public void SetEnv(LuaTable env) {}
		public override void push(IntPtr L) {}
		public override string ToString() => default;
	}

	public class LuaTable : LuaBase // TypeDefIndex: 56091
	{
		// Properties
		public object this[string field] { get => default; set {} } // 0x0000000184775050-0x0000000184775070 0x0000000185492010-0x0000000185492020
		public object this[object field] { get => default; set {} } // 0x000000018C3BC16C-0x000000018C3BC2D0 0x0000000181377E40-0x0000000181377E50
		public int Length { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		private sealed class _GetKeys_d__15 : IEnumerable<object>, IEnumerator<object> // TypeDefIndex: 56089
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
			object IEnumerator<System.Object>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetKeys_d__15() {} // Dummy constructor
			public _GetKeys_d__15(int __1__state) {} // 0x000000018646F290-0x000000018646F2A0
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
			IEnumerator<object> IEnumerable<object>.GetEnumerator() => default; // 0x000000018C3B8A2C-0x000000018C3B8A74
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C3B8BA8-0x000000018C3B8C00
		}
	
		private sealed class _GetKeys_d__16<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 56090
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
			T IEnumerator<T>.Current { get => default; } // 0x000000018C3B8ABC-0x000000018C3B8B50 
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetKeys_d__16() {} // Dummy constructor
			public _GetKeys_d__16(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018C3B8B50-0x000000018C3B8BA8
			private bool MoveNext() => default;
			void IEnumerator.Reset() {} // 0x000000018C3B88A4-0x000000018C3B8914
			IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		// Constructors
		public LuaTable() {} // Dummy constructor
		public LuaTable(int reference, LuaEnv luaenv) {}
	
		// Methods
		public void Get<TKey, TValue>(TKey key, out ref TValue value) {
			value = default;
		} // 0x000000018C3B8914-0x000000018C3B89E4
		public bool ContainsKey<TKey>(TKey key) => default;
		public void Set<TKey, TValue>(TKey key, TValue value) {} // 0x00000001853F9490-0x00000001853F94F0
		public T GetInPath<T>(string path) => default; // 0x000000018C3B89E4-0x000000018C3B8A2C
		public void SetInPath<T>(string path, T val) {} // 0x000000018454F510-0x000000018454F5B0
		public void ForEach<TKey, TValue>(Action<TKey, TValue> action) {} // 0x000000018C3BC364-0x000000018C3BC3B0
		public IEnumerable GetKeys() => default; // 0x000000018C3BC2D0-0x000000018C3BC35C
		public IEnumerable<T> GetKeys<T>() => default; // 0x000000018C3BC35C-0x000000018C3BC364
		public T Get<T>(object key) => default;
		public TValue Get<TKey, TValue>(TKey key) => default;
		public TValue Get<TValue>(string key) => default;
		public void SetMetaTable(LuaTable metaTable) {}
		public T Cast<T>() => default;
		public override void push(IntPtr L) {}
		public override string ToString() => default;
		public ObjectTranslator GetTranslator() => default;
	}

	public interface IOverloadMethodWrap // TypeDefIndex: 56092
	{
		// Properties
		bool InitedForDelegateCall { get; }
		bool HasDefalutValue { get; }
	
		// Methods
		int Call(IntPtr L, ObjectTranslator translator);
		bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x0207C228 */);
	}

	public class OverloadMethodWrapBase // TypeDefIndex: 56093
	{
		// Fields
		protected ObjectTranslator translator; // 0x10
		protected MethodBase method; // 0x18
	
		// Constructors
		public OverloadMethodWrapBase() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static IOverloadMethodWrap CreateMethodWrap(ObjectTranslator translator, MethodBase method, System.Type target) => default; // 0x0000000184BBB580-0x0000000184BBB670
	}

	public class OverloadMethodWrapForDelegate : OverloadMethodWrapBase, IOverloadMethodWrap // TypeDefIndex: 56094
	{
		// Fields
		private List<System.Type> castTypes; // 0x20
		private Delegate @delegate; // 0x28
		private LuaGenericDelegateCaller.LuaGenericDelegateCall caller; // 0x30
		private int _OptionParamCount_k__BackingField; // 0x38
		private object[] _DefalutValue_k__BackingField; // 0x40
		private bool _HasDefalutValue_k__BackingField; // 0x48
		private bool[] _OutParamFlags_k__BackingField; // 0x50
	
		// Properties
		public bool InitedForDelegateCall { get => default; } // 0x00000001850EAEA0-0x00000001850EAEB0 
		public List<System.Type> CastTypes { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public int OptionParamCount { get; private set; } // 0x00000001813E5E30-0x00000001813E5E40 0x00000001813E6F50-0x00000001813E6F60
		public object[] DefalutValue { get; private set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public bool HasDefalutValue { get; private set; } // 0x0000000185FB0750-0x0000000185FB0760 0x0000000185FB0770-0x0000000185FB0780
		public bool[] OutParamFlags { get; private set; } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
	
		// Constructors
		public OverloadMethodWrapForDelegate() {} // Dummy constructor
		public OverloadMethodWrapForDelegate(MethodInfo method) {} // 0x000000018480C210-0x000000018480C2A0
	
		// Methods
		public static OverloadMethodWrapForDelegate TryGetWrapForDelegate(MethodInfo method) => default; // 0x000000018400D450-0x000000018400DA90
		public void InitForDefaultValue() {} // 0x0000000184BBB6B0-0x0000000184BBB8D0
		public int Call(IntPtr L, ObjectTranslator translator) => default; // 0x00000001845575F0-0x0000000184557CC0
		public bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x0207C229 */) => default; // 0x00000001840A27C0-0x00000001840A27D0
	}

	public class OverloadMethodWrapForReflection : OverloadMethodWrapBase, IOverloadMethodWrap // TypeDefIndex: 56095
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
		public bool InitedForDelegateCall { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public bool HasDefalutValue { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public OverloadMethodWrapForReflection() {} // Dummy constructor
		public OverloadMethodWrapForReflection(System.Type target, MethodBase methodInfo) {} // 0x0000000184BBB670-0x0000000184BBB6B0
	
		// Methods
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters) {} // 0x0000000184BBBC10-0x0000000184BBC690
		public int Call(IntPtr L, ObjectTranslator translator) => default; // 0x0000000184557FA0-0x0000000184558BA0
		public bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x0207C22A */) => default; // 0x0000000184557F70-0x0000000184557FA0
		public bool Check(IntPtr L) => default; // 0x0000000184ED01F0-0x0000000184ED0390
		public bool CheckForNoOverride(IntPtr L) => default; // 0x0000000184558C20-0x0000000184558DB0
	}

	public class OverloadMethodWrap // TypeDefIndex: 56096
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
		private int _OptionParamCount_k__BackingField; // 0x98
		private object[] _DefalutValue_k__BackingField; // 0xA0
		private bool _IsInited_k__BackingField; // 0xA8
		private bool _HasDefalutValue_k__BackingField; // 0xA9
	
		// Properties
		public bool InitedForDelegateCall { get => default; } // 0x000000018805D4CC-0x000000018805D4D8 
		public MethodBase Method { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public List<System.Type> CastTypes { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public int OptionParamCount { get; private set; } // 0x00000001834A0D40-0x00000001834A0D50 0x00000001834A2250-0x00000001834A2260
		public object[] DefalutValue { get; private set; } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018646EBCC-0x000000018646EBE0
		public bool IsInited { get; private set; } // 0x0000000185FB8C10-0x0000000185FB8C20 0x0000000185FBC1E0-0x0000000185FBC1F0
		public bool HasDefalutValue { get; private set; } // 0x0000000185FBC1B0-0x0000000185FBC1C0 0x0000000185FBC1D0-0x0000000185FBC1E0
	
		// Constructors
		public OverloadMethodWrap() {} // Dummy constructor
		public OverloadMethodWrap(ObjectTranslator translator, System.Type targetType, MethodBase method) {} // 0x000000018C3BBB20-0x000000018C3BBB6C
	
		// Methods
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters) {} // 0x000000018C3BB05C-0x000000018C3BBB20
		public void InitForDefaultValue() {} // 0x000000018C3BA790-0x000000018C3BAA5C
		public void InitForDelegateCallMethod() {} // 0x000000018C3BAA5C-0x000000018C3BB05C
		public int Call(IntPtr L) => default; // 0x000000018C3B9FCC-0x000000018C3BA790
		public int CallForDelegate(IntPtr L, ObjectTranslator translator) => default; // 0x000000018C3B9E54-0x000000018C3B9FCC
	}

	public class MethodWrap // TypeDefIndex: 56097
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
		public MethodWrap() {} // Dummy constructor
		public MethodWrap(string methodName, List<MethodBase> overloads, System.Type targetType, bool forceCheck) {} // 0x000000018439D8F0-0x000000018439D990
	
		// Methods
		private void _InitForDelegateCall() {} // 0x00000001850EACF0-0x00000001850EAEA0
		public int Call(IntPtr L) => default; // 0x0000000184556E90-0x00000001845575F0
	}

	public class MethodWrapsCache // TypeDefIndex: 56101
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
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 56098
		{
			// Fields
			public MethodWrapsCache __4__this; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0() {} // 0x000000018C3B8C00-0x000000018C3B8D00
	
			// Methods
			internal int _GetConstructorWrap_b__0(IntPtr L) => default; // 0x000000018C3B8D00-0x000000018C3B8D64
		}
	
		private sealed class __c__DisplayClass11_1 // TypeDefIndex: 56099
		{
			// Fields
			public lua_CSFunction ctor; // 0x10
			public __c__DisplayClass11_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass11_1() {} // 0x0000000185C28B40-0x0000000185C28BD0
	
			// Methods
			internal int _GetConstructorWrap_b__1(IntPtr L) => default; // 0x0000000185C28BD0-0x0000000185C28D10
		}
	
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 56100
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
			public __c__DisplayClass15_0() {} // 0x000000018439D990-0x000000018439DD80
	
			// Methods
			internal int _GetEventWrap_b__0(IntPtr L) => default; // 0x000000018C3B90BC-0x000000018C3B9304
		}
	
		// Constructors
		public MethodWrapsCache() {} // Dummy constructor
		static MethodWrapsCache() {} // 0x00000001840880D0-0x00000001840883A0
		public MethodWrapsCache(ObjectTranslator translator, ObjectCheckers objCheckers, ObjectCasters objCasters) {} // 0x000000018439CDA0-0x000000018439D880
	
		// Methods
		public static void AddCodeGenConstructor(System.Type type, lua_CSFunction lua_CSFunction) {} // 0x000000018C3B8F64-0x000000018C3B90BC
		public static void ClearCodeGenConstructorMap() {} // 0x000000018C3B8D64-0x000000018C3B8F64
		public lua_CSFunction GetConstructorWrap(System.Type type) => default; // 0x000000018C3B9304-0x000000018C3B9510
		public lua_CSFunction GetMethodWrap(System.Type type, string methodName) => default; // 0x0000000185492010-0x0000000185492020
		public lua_CSFunction GetMethodWrapInCache(System.Type type, string methodName) => default; // 0x000000018C3BC474-0x000000018C3BC4C8
		public lua_CSFunction GetDelegateWrap(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
		public lua_CSFunction GetEventWrap(System.Type type, string eventName) => default; // 0x00000001857DD2E0-0x00000001857DD370
		public MethodWrap _GenMethodWrap(System.Type type, string methodName, IEnumerable<MemberInfo> methodBases, bool forceCheck = false /* Metadata: 0x0207C22B */) => default; // 0x0000000185492010-0x0000000185492020
		private static bool tryMakeGenericMethod(ref MethodBase method) => default; // 0x000000018C3BC564-0x000000018C3BCA7C
	}

	public delegate bool ObjectCheck(IntPtr L, int idx); // TypeDefIndex: 56102; 0x0000000181B59400-0x0000000181B59410

	public delegate object ObjectCast(IntPtr L, int idx, object target); // TypeDefIndex: 56103; 0x00000001817E31E0-0x00000001817E3200

	public class ObjectCheckers // TypeDefIndex: 56106
	{
		// Fields
		private Dictionary<System.Type, ObjectCheck> checkersMap; // 0x10
		private ObjectTranslator translator; // 0x18
	
		// Nested types
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 56104
		{
			// Fields
			public ObjectCheckers __4__this; // 0x10
			public System.Type type; // 0x18
			public ObjectCheck fixTypeCheck; // 0x20
	
			// Constructors
			public __c__DisplayClass14_0() {} // 0x00000001843A0C70-0x00000001843A15D0
	
			// Methods
			internal bool _genChecker_b__0(IntPtr L, int idx) => default; // 0x00000001840A27C0-0x00000001840A27D0
			internal bool _genChecker_b__1(IntPtr L, int idx) => default; // 0x000000018C3B9D74-0x000000018C3B9E54
			internal bool _genChecker_b__2(IntPtr L, int idx) => default; // 0x00000001851D24C0-0x00000001851D2550
			internal bool _genChecker_b__3(IntPtr L, int idx) => default; // 0x000000018C3B9BC0-0x000000018C3B9C40
			internal bool _genChecker_b__4(IntPtr L, int idx) => default; // 0x0000000185125650-0x00000001851256F0
			internal bool _genChecker_b__5(IntPtr L, int idx) => default; // 0x000000018C3B9AE0-0x000000018C3B9BC0
			internal bool _genChecker_b__6(IntPtr L, int idx) => default; // 0x000000018520CC40-0x000000018520CCD0
			internal bool _genChecker_b__7(IntPtr L, int idx) => default; // 0x0000000185485E90-0x0000000185485F00
		}
	
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 56105
		{
			// Fields
			public ObjectCheck oc; // 0x10
	
			// Constructors
			public __c__DisplayClass15_0() {} // 0x00000001859DB7D0-0x00000001859DB840
	
			// Methods
			internal bool _genNullableChecker_b__0(IntPtr L, int idx) => default; // 0x000000018C3B9C94-0x000000018C3B9D74
		}
	
		// Constructors
		public ObjectCheckers() {} // Dummy constructor
		public ObjectCheckers(ObjectTranslator translator) {} // 0x000000018C3B9C40-0x000000018C3B9C94
	
		// Methods
		private static bool objectCheck(IntPtr L, int idx) => default; // 0x000000018439F830-0x000000018439FBA0
		private bool luaTableCheck(IntPtr L, int idx) => default; // 0x0000000185C3BD50-0x0000000185C3BE00
		private bool numberCheck(IntPtr L, int idx) => default; // 0x0000000185C57100-0x0000000185C57170
		private bool decimalCheck(IntPtr L, int idx) => default; // 0x00000001845555B0-0x0000000184555820
		private bool strCheck(IntPtr L, int idx) => default; // 0x0000000185492010-0x0000000185492020
		private bool bytesCheck(IntPtr L, int idx) => default; // 0x0000000184554BE0-0x0000000184554D30
		private bool boolCheck(IntPtr L, int idx) => default; // 0x0000000185504650-0x00000001855046F0
		private bool int64Check(IntPtr L, int idx) => default; // 0x00000001850D3DE0-0x00000001850D3E80
		private bool uint64Check(IntPtr L, int idx) => default; // 0x0000000185EBBAB0-0x0000000185EBBB70
		private bool luaFunctionCheck(IntPtr L, int idx) => default; // 0x00000001853C66D0-0x00000001853C6790
		private bool intptrCheck(IntPtr L, int idx) => default; // 0x00000001852C3530-0x00000001852C35F0
		private ObjectCheck genChecker(System.Type type) => default; // 0x000000018C3BC4C8-0x000000018C3BC564
		public ObjectCheck genNullableChecker(ObjectCheck oc) => default; // 0x0000000184554A70-0x0000000184554B40
		public void AddChecker(System.Type type, ObjectCheck oc) {} // 0x0000000185492010-0x0000000185492020
		public ObjectCheck GetChecker(System.Type type) => default; // 0x000000018C3BCA7C-0x000000018C3BCAFC
	}

	public class ObjectCasters // TypeDefIndex: 56111
	{
		// Fields
		private Dictionary<System.Type, ObjectCast> castersMap; // 0x10
		private ObjectTranslator translator; // 0x18
	
		// Nested types
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 56107
		{
			// Fields
			public ObjectCasters __4__this; // 0x10
			public System.Type type; // 0x18
			public ObjectCast fixTypeGetter; // 0x20
	
			// Constructors
			public __c__DisplayClass23_0() {} // 0x00000001843A02C0-0x00000001843A0C70
	
			// Methods
			internal object _genCaster_b__0(IntPtr L, int idx, object target) => default; // 0x000000018C3B961C-0x000000018C3B968C
			internal object _genCaster_b__1(IntPtr L, int idx, object target) => default; // 0x000000018C3B98FC-0x000000018C3B996C
			internal object _genCaster_b__2(IntPtr L, int idx, object target) => default; // 0x000000018C3B95AC-0x000000018C3B961C
			internal object _genCaster_b__3(IntPtr L, int idx, object target) => default; // 0x000000018C3B996C-0x000000018C3B99DC
			internal object _genCaster_b__4(IntPtr L, int idx, object target) => default; // 0x000000018C3B99DC-0x000000018C3B9A4C
			internal object _genCaster_b__5(IntPtr L, int idx, object target) => default; // 0x0000000184FC4450-0x0000000184FC44D0
			internal object _genCaster_b__6(IntPtr L, int idx, object target) => default; // 0x0000000184FC4560-0x0000000184FC45E0
		}
	
		private sealed class __c__DisplayClass23_1 // TypeDefIndex: 56108
		{
			// Fields
			public System.Type elementType; // 0x10
			public ObjectCast elementCaster; // 0x18
			public __c__DisplayClass23_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass23_1() {} // 0x000000018433F1F0-0x000000018433F270
	
			// Methods
			internal object _genCaster_b__7(IntPtr L, int idx, object target) => default; // 0x0000000184FC45E0-0x0000000184FC4660
		}
	
		private sealed class __c__DisplayClass23_2 // TypeDefIndex: 56109
		{
			// Fields
			public System.Type keyType; // 0x10
			public System.Type valueType; // 0x18
			public ObjectCast keyCaster; // 0x20
			public ObjectCast valueCaster; // 0x28
			public __c__DisplayClass23_0 CS___8__locals2; // 0x30
	
			// Constructors
			public __c__DisplayClass23_2() {} // 0x000000018C3B981C-0x000000018C3B988C
	
			// Methods
			internal object _genCaster_b__8(IntPtr L, int idx, object target) => default; // 0x0000000184FC44D0-0x0000000184FC4560
		}
	
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 56110
		{
			// Fields
			public ObjectCast oc; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0() {} // 0x000000018C3B968C-0x000000018C3B971C
	
			// Methods
			internal object _genNullableCaster_b__0(IntPtr L, int idx, object target) => default; // 0x00000001853B1920-0x00000001853B19A0
		}
	
		// Constructors
		public ObjectCasters() {} // Dummy constructor
		public ObjectCasters(ObjectTranslator translator) {} // 0x00000001853A8730-0x00000001853A8790
	
		// Methods
		private static object charCaster(IntPtr L, int idx, object target) => default; // 0x000000018C3B971C-0x000000018C3B981C
		private static object sbyteCaster(IntPtr L, int idx, object target) => default; // 0x000000018C3B988C-0x000000018C3B98FC
		private static object byteCaster(IntPtr L, int idx, object target) => default; // 0x0000000185B92E60-0x0000000185B92FC0
		private static object shortCaster(IntPtr L, int idx, object target) => default; // 0x0000000184552120-0x0000000184552250
		private static object ushortCaster(IntPtr L, int idx, object target) => default; // 0x0000000184551080-0x00000001845511B0
		private static object intCaster(IntPtr L, int idx, object target) => default; // 0x0000000185925D70-0x0000000185925DE0
		private static object uintCaster(IntPtr L, int idx, object target) => default; // 0x000000018439FC50-0x00000001843A01A0
		private static object longCaster(IntPtr L, int idx, object target) => default; // 0x0000000185C3BE00-0x0000000185C3BEB0
		private static object ulongCaster(IntPtr L, int idx, object target) => default; // 0x00000001845541B0-0x0000000184554360
		private static object getDouble(IntPtr L, int idx, object target) => default; // 0x0000000185492010-0x0000000185492020
		private static object floatCaster(IntPtr L, int idx, object target) => default; // 0x00000001843435E0-0x00000001843436D0
		private object decimalCaster(IntPtr L, int idx, object target) => default; // 0x0000000184550550-0x0000000184550640
		private static object getBoolean(IntPtr L, int idx, object target) => default; // 0x000000018C3C4A9C-0x000000018C3C4B58
		private static object getString(IntPtr L, int idx, object target) => default; // 0x0000000185D7A080-0x0000000185D7A130
		private object getBytes(IntPtr L, int idx, object target) => default; // 0x0000000184550A40-0x0000000184550AE0
		private object getIntptr(IntPtr L, int idx, object target) => default; // 0x000000018C3C4B58-0x000000018C3C4EA8
		private object getObject(IntPtr L, int idx, object target) => default; // 0x00000001853F0010-0x00000001853F0100
		private object getLuaTable(IntPtr L, int idx, object target) => default; // 0x0000000185492010-0x0000000185492020
		private object getLuaFunction(IntPtr L, int idx, object target) => default; // 0x0000000184C35050-0x0000000184C35310
		public void AddCaster(System.Type type, ObjectCast oc) {} // 0x0000000185492010-0x0000000185492020
		private ObjectCast genCaster(System.Type type) => default; // 0x000000018C3C4EA8-0x000000018C3C5194
		private ObjectCast genNullableCaster(ObjectCast oc) => default; // 0x0000000185492010-0x0000000185492020
		public ObjectCast GetCaster(System.Type type) => default; // 0x000000018C3C5194-0x000000018C3C5224
	}

	public class ObjectPool // TypeDefIndex: 56113
	{
		// Fields
		private const int LIST_END = -1; // Metadata: 0x0207C22C
		private const int ALLOCED = -2; // Metadata: 0x0207C22D
		private Slot[] list; // 0x10
		private int freelist; // 0x18
		private int count; // 0x1C
		private List<object> needCleanImmediately; // 0x20
	
		// Properties
		public object this[int i] { get => default; } // 0x000000018454F460-0x000000018454F4C0 
	
		// Nested types
		private struct Slot // TypeDefIndex: 56112
		{
			// Fields
			public int next; // 0x00
			public object obj; // 0x08
	
			// Constructors
			public Slot(int next, object obj) {
				this.next = default;
				this.obj = default;
			} // 0x000000018C3BEE70-0x000000018C3BEEA4
		}
	
		// Constructors
		public ObjectPool() {} // 0x0000000189317CA8-0x0000000189317CB8
	
		// Methods
		public void AddToNeedCleanImmediately(object obj) {} // 0x000000018C3BEE20-0x000000018C3BEE70
		public void Clear() {} // 0x0000000184B5B380-0x0000000184B5B440
		private void extend_capacity() {} // 0x00000001841509A0-0x0000000184150B50
		public int Add(object obj) => default; // 0x0000000184151550-0x0000000184151690
		public bool TryGetValue(int index, out object obj) {
			obj = default;
			return default;
		} // 0x0000000184150B50-0x0000000184150B90
		public object Get(int index) => default; // 0x00000001841510A0-0x00000001841511E0
		public object Remove(int index) => default; // 0x0000000184150930-0x00000001841509A0
		public object Replace(int index, object o) => default; // 0x0000000184151690-0x0000000184151BA0
		public int Check(int check_pos, int max_check, Func<object, bool> checker, Dictionary<object, int> reverse_map) => default; // 0x0000000184FD2230-0x0000000184FD2300
		public void ClearAllUserdata(Func<object, bool> checker, Dictionary<object, int> reverse_map) {} // 0x0000000185F09640-0x0000000185F096F0
	}

	internal class ReferenceEqualsComparer : IEqualityComparer<object> // TypeDefIndex: 56114
	{
		// Constructors
		public ReferenceEqualsComparer() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public new bool Equals(object o1, object o2) => default; // 0x0000000184D81F20-0x0000000184D81F30
		public int GetHashCode(object obj) => default; // 0x0000000185FCF280-0x0000000185FCF290
	}

	public class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 56115
	{
		// Fields
		private System.Type type; // 0x10
	
		// Constructors
		public MonoPInvokeCallbackAttribute() {} // Dummy constructor
		public MonoPInvokeCallbackAttribute(System.Type t) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public enum LuaTypes // TypeDefIndex: 56116
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

	public enum LuaGCOptions // TypeDefIndex: 56117
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

	public enum LuaThreadStatus // TypeDefIndex: 56118
	{
		LUA_RESUME_ERROR = -1,
		LUA_OK = 0,
		LUA_YIELD = 1,
		LUA_ERRRUN = 2,
		LUA_ERRSYNTAX = 3,
		LUA_ERRMEM = 4,
		LUA_ERRERR = 5
	}

	public class LuaIndexes // TypeDefIndex: 56119
	{
		// Properties
		public static int LUA_REGISTRYINDEX { get => default; set {} } // 0x0000000184559370-0x00000001845593D0 0x0000000185F88FE0-0x0000000185F89040
	
		// Constructors
		public LuaIndexes() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ObjectTranslator // TypeDefIndex: 56141
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
		public ObjectPool Pools { get => default; } // 0x000000018548EC80-0x000000018548ECE0 
	
		// Nested types
		public enum LOGLEVEL // TypeDefIndex: 56120
		{
			NO = 0,
			INFO = 1,
			WARN = 2,
			ERROR = 3
		}
	
		private struct EnumerableWrapper // TypeDefIndex: 56121
		{
			// Fields
			public int Index; // 0x00
			public IList CurList; // 0x08
			public IEnumerator Enumerator; // 0x10
			public static Stack<EnumerableWrapper> enumerableStack; // 0x00
	
			// Constructors
			static EnumerableWrapper() {
				enumerableStack = default;
			} // 0x00000001848116B0-0x0000000184811980
	
			// Methods
			public static int ListCsPairs(IntPtr L) => default; // 0x00000001813B8590-0x00000001813B85A0
			public static int DicCsPairs(IntPtr L) => default; // 0x00000001851516E0-0x0000000185151750
			public static int IEnumerableCsPairs(IntPtr L) => default; // 0x0000000185492020-0x0000000185492090
		}
	
		private struct FStructWrap<T> // TypeDefIndex: 56122
		{
			// Fields
			public T value;
	
			// Methods
			public IntPtr GetPtr() => default; // 0x0000000184CB8990-0x0000000184CB8A40
		}
	
		private struct CSharpStructInLua // TypeDefIndex: 56123
		{
			// Fields
			public int fake_id; // 0x00
			public uint len; // 0x04
			public IntPtr ptr; // 0x08
		}
	
		public struct LuaCSFunctionPtr // TypeDefIndex: 56124
		{
			// Fields
			public IntPtr ptr; // 0x00
			public object target; // 0x08
		}
	
		public delegate ValueTuple<IntPtr, T1> GetDelegatePointer<T1>(Delegate d); // TypeDefIndex: 56125; 0x0000000184A8DE20-0x0000000184A8E850
	
		public delegate void PushCSObject(IntPtr L, object obj); // TypeDefIndex: 56126; 0x00000001845532E0-0x0000000184553680
	
		public delegate object GetCSObject(IntPtr L, int idx); // TypeDefIndex: 56127; 0x0000000185BC8260-0x0000000185BC8450
	
		public delegate void UpdateCSObject(IntPtr L, int idx, object obj); // TypeDefIndex: 56128; 0x000000018C3BF200-0x000000018C3BF294
	
		public delegate bool CheckFunc<T>(IntPtr L, int idx); // TypeDefIndex: 56129; 0x0000000184CB8CE0-0x0000000184CB9000
	
		public delegate void GetFunc<T>(IntPtr L, int idx, out ref T val); // TypeDefIndex: 56130; 0x0000000185AED790-0x0000000185AED850
	
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 56131
		{
			// Fields
			public System.Type delegateType; // 0x10
			public MethodInfo genericMethodInfo; // 0x18
	
			// Constructors
			public __c__DisplayClass32_0() {} // 0x0000000184555230-0x0000000184555530
	
			// Methods
			internal Delegate _getCreatorUsingGeneric_b__7(DelegateBridgeBase o) => default; // 0x0000000184150F30-0x00000001841510A0
		}
	
		private sealed class __c__DisplayClass32_1 // TypeDefIndex: 56132
		{
			// Fields
			public MethodInfo methodInfo; // 0x10
			public __c__DisplayClass32_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass32_1() {} // 0x000000018646ED28-0x000000018646ED38
	
			// Methods
			internal Delegate _getCreatorUsingGeneric_b__8(DelegateBridgeBase o) => default;
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 56133
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
			static __c() {}
			public __c() {}
	
			// Methods
			internal bool _getCreatorUsingGeneric_b__32_1(MethodInfo m) => default;
			internal int _getCreatorUsingGeneric_b__32_2(MethodInfo m) => default; // 0x000000018C3BF360-0x000000018C3BF45C
			internal bool _getCreatorUsingGeneric_b__32_3(MethodInfo m) => default;
			internal int _getCreatorUsingGeneric_b__32_4(MethodInfo m) => default; // 0x000000018646EFA8-0x000000018646EFD4
			internal Delegate _getCreatorUsingGeneric_b__32_0(DelegateBridgeBase x) => default; // 0x000000018C3BF7AC-0x000000018C3BF890
			internal Delegate _getCreatorUsingGeneric_b__32_5(DelegateBridgeBase x) => default; // 0x000000018414EEC0-0x000000018414F550
			internal System.Type _getCreatorUsingGeneric_b__32_6(ParameterInfo pinfo) => default; // 0x00000001848549E0-0x0000000184854D80
			internal bool _getDelegate_b__33_0(MethodInfo m) => default; // 0x000000018646D8CC-0x000000018646D8D4
		}
	
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 56134
		{
			// Fields
			public System.Type delegateType; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0() {} // 0x000000018414E530-0x000000018414EA20
		}
	
		private sealed class __c__DisplayClass33_1 // TypeDefIndex: 56135
		{
			// Fields
			public MethodInfo foundMethod; // 0x10
			public __c__DisplayClass33_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass33_1() {} // 0x000000018C3BFD50-0x000000018C3BFE70
	
			// Methods
			internal Delegate _getDelegate_b__1(DelegateBridgeBase o) => default; // 0x000000018C3BFBC0-0x000000018C3BFC80
		}
	
		[Serializable]
		private sealed class __c__123<T> // TypeDefIndex: 56136
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
			static __c__123() {} // 0x000000018C3BFB5C-0x000000018C3BFBC0
			public __c__123() {}
	
			// Methods
			internal void _tryGetPushFuncByType_b__123_0(IntPtr L, byte v) {} // 0x000000018414EA40-0x000000018414ED60
			internal void _tryGetPushFuncByType_b__123_1(IntPtr L, sbyte v) {} // 0x000000018C3BFA50-0x000000018C3BFB5C
			internal void _tryGetPushFuncByType_b__123_2(IntPtr L, char v) {} // 0x00000001844DF7D0-0x00000001844DF8E0
			internal void _tryGetPushFuncByType_b__123_3(IntPtr L, short v) {} // 0x00000001844DF500-0x00000001844DF7D0
			internal void _tryGetPushFuncByType_b__123_4(IntPtr L, ushort v) {} // 0x00000001844DF8E0-0x00000001844DFA60
			internal void _tryGetPushFuncByType_b__123_5(IntPtr L, float v) {} // 0x00000001844DE830-0x00000001844DEA10
		}
	
		[Serializable]
		private sealed class __c__125<T> // TypeDefIndex: 56137
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
			static __c__125() {} // 0x000000018454F3F0-0x000000018454F460
			public __c__125() {}
	
			// Methods
			internal byte _tryGetGetFuncByType_b__125_1(IntPtr L, int idx) => default; // 0x0000000184341AC0-0x0000000184341B80
			internal sbyte _tryGetGetFuncByType_b__125_2(IntPtr L, int idx) => default; // 0x000000018C3BF09C-0x000000018C3BF0AC
			internal char _tryGetGetFuncByType_b__125_3(IntPtr L, int idx) => default; // 0x0000000184341B80-0x0000000184341C40
			internal short _tryGetGetFuncByType_b__125_4(IntPtr L, int idx) => default;
			internal ushort _tryGetGetFuncByType_b__125_5(IntPtr L, int idx) => default; // 0x0000000184558DB0-0x0000000184558F90
			internal float _tryGetGetFuncByType_b__125_6(IntPtr L, int idx) => default; // 0x00000001841511E0-0x0000000184151550
		}
	
		private sealed class __c__DisplayClass128_0<T> // TypeDefIndex: 56138
		{
			// Fields
			public GetFunc<T> get;
			public Action<IntPtr, T> push;
			public Action<IntPtr, int, T> update;
	
			// Constructors
			public __c__DisplayClass128_0() {} // 0x0000000184343F90-0x0000000184344020
	
			// Methods
			internal T _RegisterPushAndGetAndUpdate_b__0(IntPtr L, int idx) => default; // 0x000000018C3BF294-0x000000018C3BF308
			internal void _RegisterPushAndGetAndUpdate_b__1(IntPtr L, object obj) {} // 0x000000018C3BFC80-0x000000018C3BFD50
			internal object _RegisterPushAndGetAndUpdate_b__2(IntPtr L, int idx) => default; // 0x000000018C3BF308-0x000000018C3BF360
			internal void _RegisterPushAndGetAndUpdate_b__3(IntPtr L, int idx, object obj) {} // 0x0000000183FCA080-0x0000000183FCA130
		}
	
		private sealed class __c__DisplayClass129_0<T> // TypeDefIndex: 56139
		{
			// Fields
			public CheckFunc<T> check;
	
			// Constructors
			public __c__DisplayClass129_0() {} // 0x0000000184350220-0x00000001843505E0
	
			// Methods
			internal bool _RegisterChecker_b__0(IntPtr L, int idx) => default; // 0x0000000184773290-0x00000001847733C0
		}
	
		private sealed class __c__DisplayClass130_0<T> // TypeDefIndex: 56140
		{
			// Fields
			public GetFunc<T> get;
	
			// Constructors
			public __c__DisplayClass130_0() {} // 0x000000018C3BFEF4-0x000000018C3C0078
	
			// Methods
			internal object _RegisterCaster_b__0(IntPtr L, int idx, object o) => default; // 0x0000000184ED3740-0x0000000184ED38F0
		}
	
		// Constructors
		public ObjectTranslator() {} // Dummy constructor
		public ObjectTranslator(LuaEnv luaenv, IntPtr L) {} // 0x000000018C3BF890-0x000000018C3BFA50
		static ObjectTranslator() {}
	
		// Methods
		public void DelayWrapLoader(System.Type type, Action<IntPtr> loader) {}
		public void AddInterfaceBridgeCreator(System.Type type, Func<int, LuaEnv, LuaBase> creator) {}
		public bool TryDelayWrapLoader(IntPtr L, System.Type type) => default;
		public void Alias(System.Type type, string alias) {}
		private void addAssemblieByName(IEnumerable<Assembly> assemblies_usorted, string name) {}
		private void initCSharpCallLua() {} // 0x000000018C3BF73C-0x000000018C3BF7AC
		private Func<DelegateBridgeBase, Delegate> getCreatorUsingGeneric(DelegateBridgeBase bridge, System.Type delegateType, MethodInfo delegateMethod) => default; // 0x00000001885563E8-0x0000000188556424
		private Delegate getDelegate(DelegateBridgeBase bridge, System.Type delegateType) => default; // 0x000000018C3BF45C-0x000000018C3BF73C
		public object CreateDelegateBridge(IntPtr L, System.Type delegateType, int idx) => default; // 0x0000000185D29530-0x0000000185D29680
		public bool AllDelegateBridgeReleased() => default;
		public void ReleaseLuaBase(IntPtr L, int reference, bool is_delegate) {} // 0x0000000184C34EB0-0x0000000184C35050
		public object CreateInterfaceBridge(IntPtr L, System.Type interfaceType, int idx) => default; // 0x0000000184F47460-0x0000000184F476F0
		public void CreateArrayMetatable(IntPtr L) {} // 0x00000001851984B0-0x0000000185198610
		public void CreateDelegateMetatable(IntPtr L) {} // 0x000000018C3BE368-0x000000018C3BE3F4
		internal void CreateEnumerablePairs(IntPtr L) {}
		public static int CsPairs(IntPtr L) => default;
		public static int EnumToInt(IntPtr L) => default;
		internal void CreateEnumerableCSPairs(IntPtr L) {}
		public void OpenLib(IntPtr L) {}
		internal void createFunctionMetatable(IntPtr L) {} // 0x0000000183FB0D80-0x0000000183FB0DF0
		internal System.Type FindType(string className, bool isQualifiedName = false /* Metadata: 0x0207C24A */) => default; // 0x00000001831C5680-0x00000001831C5690
		private bool hasMethod(System.Type type, string methodName) => default; // 0x000000018C3C0078-0x000000018C3C00F8
		internal void collectObject(int obj_index_to_collect) {} // 0x00000001864BB614-0x00000001864BB734
		private int addObject(object obj, bool is_valuetype, bool is_enum) => default; // 0x0000000183FB0D10-0x0000000183FB0D80
		internal object GetObject(IntPtr L, int index) => default; // 0x0000000181B59400-0x0000000181B59410
		public System.Type GetTypeOf(IntPtr L, int idx) => default; // 0x000000018C3BE3F4-0x000000018C3BE488
		public bool Assignable<T>(IntPtr L, int index) => default; // 0x00000001864750A8-0x00000001864751CC
		public bool Assignable(IntPtr L, int index, System.Type type) => default; // 0x0000000183FB0CA0-0x0000000183FB0D10
		public object FastGetObject(IntPtr L, int index, System.Type type) => default; // 0x0000000181A578C0-0x0000000181A578E0
		public object GetObject(IntPtr L, int index, System.Type type) => default; // 0x000000018C3C5234-0x000000018C3C52D0
		private void _Get<T>(IntPtr L, int index, out ref T v) {
			v = default;
		} // 0x00000001864BB614-0x00000001864BB734
		public void Get<T>(IntPtr L, int index, out ref T v) {
			v = default;
		}
		public void PushByType<T>(IntPtr L, T v) {}
		public T[] GetParams<T>(IntPtr L, int index) => default;
		public Array GetParams(IntPtr L, int index, System.Type type) => default;
		public T GetDelegate<T>(IntPtr L, int index)
			where T : class => default;
		public int GetTypeId(IntPtr L, System.Type type) => default;
		public void PrivateAccessible(IntPtr L, System.Type type) {}
		public int getTypeId(IntPtr L, System.Type type, out bool is_first, LOGLEVEL log_level = LOGLEVEL.WARN /* Metadata: 0x0207C24B */) {
			is_first = default;
			return default;
		}
		private void pushPrimitive(IntPtr L, object o) {} // 0x0000000185492010-0x0000000185492020
		public void PushObject(IntPtr L, object o) {} // 0x000000018C3C5224-0x000000018C3C5234
		public void PushAny(IntPtr L, object o) {} // 0x0000000185492010-0x0000000185492020
		public int TranslateToEnumToTop(IntPtr L, System.Type type, int idx) => default; // 0x0000000184347460-0x0000000184347920
		public void Push(IntPtr L, lua_CSFunction o) {} // 0x0000000185F73E70-0x0000000185F73ED0
		public void Push(IntPtr L, LuaBase o) {} // 0x0000000185492010-0x0000000185492020
		public void Push<T>(IntPtr L, T o)
			where T : struct {} // 0x0000000185AD1E90-0x0000000185AD1EF0
		public void Push(IntPtr L, object o) {} // 0x0000000185DAF500-0x0000000185DAF530
		public void PushObject(IntPtr L, object o, int type_id) {} // 0x0000000185AD1E30-0x0000000185AD1E90
		public bool IsUnmanagedType(System.Type type) => default; // 0x0000000185DAF500-0x0000000185DAF530
		public void PushBrigeStruct(IntPtr L, IntPtr ptr, System.Type type, int size) {} // 0x00000001813AE580-0x00000001813AE590
		private void _PushBrigeStruct(IntPtr L, IntPtr ptr, System.Type type, int size) {} // 0x00000001813AE580-0x00000001813AE590
		public void GetBrigeStruct(IntPtr L, IntPtr ptr, int index, int size, System.Type type) {} // 0x0000000185EBB940-0x0000000185EBB960
		public void AddNeedRemoveObjRef(object obj) {} // 0x00000001855E7F40-0x00000001855E8000
		private void _GetBrigeStruct(IntPtr L, IntPtr ptr, int index, int size, System.Type type) {} // 0x0000000185492010-0x0000000185492020
		public void UpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type) {} // 0x0000000185492010-0x0000000185492020
		public void BeyondUpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type) {} // 0x0000000184347460-0x0000000184347920
		private void _UpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type) {}
		public void Update<T>(IntPtr L, int index, T obj)
			where T : struct {}
		public void Update(IntPtr L, int index, object obj) {}
		private object getCsObj(IntPtr L, int index, int udata) => default;
		internal object SafeGetCSObj(IntPtr L, int index) => default;
		public object FastGetCSObj(IntPtr L, int index) => default;
		internal void ReleaseCSObj(IntPtr L, int index) {}
		internal lua_CSFunction GetFixCSFunction(int index) => default;
		internal LuaCSFunctionPtr GetFixCSFunctionPtr(int index) => default;
		internal void PushFixCSFunction(IntPtr L, lua_CSFunction func) {}
		internal object[] popValues(IntPtr L, int oldTop) => default;
		internal object[] popValues(IntPtr L, int oldTop, System.Type[] popTypes) => default;
		private void registerCustomOp(System.Type type, PushCSObject push, GetCSObject get, UpdateCSObject update) {}
		public bool HasCustomOp(System.Type type) => default;
		private bool tryGetPushFuncByType<T>(System.Type type, out ref T func)
			where T : class {
			func = default;
			return default;
		}
		private bool tryGetGetFuncByType<T>(System.Type type, out ref T func)
			where T : class {
			func = default;
			return default;
		}
		public void RegisterPushAndGetAndUpdate<T>(Action<IntPtr, T> push, GetFunc<T> get, Action<IntPtr, int, T> update) {}
		public void RegisterChecker<T>(CheckFunc<T> check) {}
		public void RegisterCaster<T>(GetFunc<T> get) {}
		public void PushDecimal(IntPtr L, decimal val) {}
		public bool IsDecimal(IntPtr L, int index) => default;
		public decimal GetDecimal(IntPtr L, int index) => default;
		public void Get(IntPtr L, int index, out decimal val) {
			val = default;
		}
		private decimal _tryGetGetFuncByType_b__125_0<T>(IntPtr L, int idx)
			where T : class => default;
	}

	public class ObjectTranslatorPool // TypeDefIndex: 56142
	{
		// Fields
		private Dictionary<IntPtr, WeakReference> translators; // 0x10
		private IntPtr lastPtr; // 0x18
		private ObjectTranslator lastTranslator; // 0x20
		public static ObjectTranslatorPool Instance; // 0x00
	
		// Constructors
		public ObjectTranslatorPool() {} // 0x0000000185ECB190-0x0000000185ECB210
		static ObjectTranslatorPool() {} // 0x0000000185ECB120-0x0000000185ECB190
	
		// Methods
		public void Add(IntPtr L, ObjectTranslator translator) {} // 0x0000000185EC2EA0-0x0000000185EC2F90
		public ObjectTranslator Find(IntPtr L) => default; // 0x00000001813B31A0-0x00000001813B31B0
		public void Remove(IntPtr L) {} // 0x000000018C3BEEA4-0x000000018C3BEF60
	}

	public interface RawObject // TypeDefIndex: 56143
	{
		// Properties
		object Target { get; }
	}

	public class InternalUtility // TypeDefIndex: 56144
	{
		// Fields
		private static Dictionary<System.Type, string> s_baseValueTypeDic; // 0x00
	
		// Constructors
		public InternalUtility() {} // 0x0000000185492010-0x0000000185492020
		static InternalUtility() {} // 0x000000018576DAA0-0x000000018576DFA0
	
		// Methods
		public static string GetTypeGenericSignatureDefine(System.Type type, bool isGetType = false /* Metadata: 0x0207C250 */, bool isRef = false /* Metadata: 0x0207C251 */, bool isOut = false /* Metadata: 0x0207C252 */, bool needLua = false /* Metadata: 0x0207C253 */, bool keepType = false /* Metadata: 0x0207C254 */, bool needEnum = false /* Metadata: 0x0207C255 */) => default; // 0x000000018439A980-0x000000018439ACD0
		public static bool CheckRegisterBaseStructOnArm(System.Type type) => default; // 0x0000000184399430-0x0000000184399690
		public static bool CheckCustomDelegate(string name) => default; // 0x000000018400C150-0x000000018400C250
		public static bool CheckTypNeedToGen(System.Type type) => default; // 0x000000018C3BE488-0x000000018C3BE5BC
		public static bool IsPublic(System.Type type) => default; // 0x000000018C3BED6C-0x000000018C3BEE20
		public static string GetTypeFullName(System.Type t) => default; // 0x0000000184BBB8D0-0x0000000184BBBC10
		public static string GetDelegateName(MethodInfo method) => default; // 0x000000018C3BE5BC-0x000000018C3BE944
		public static bool IsStruct(System.Type type) => default; // 0x0000000184399690-0x0000000184399710
		public static string GetGenericTypeName(System.Type type, bool needPoint = false /* Metadata: 0x0207C256 */) => default; // 0x000000018C3BEAF4-0x000000018C3BED6C
		public static string GeNormalName(string str) => default; // 0x0000000184397D60-0x0000000184397F10
		public static string GetGenericTypeNameString(System.Type type) => default; // 0x000000018C3BE944-0x000000018C3BEAF4
	}

	public class MethodAndDelegateSignatureManager // TypeDefIndex: 56145
	{
		// Constructors
		public MethodAndDelegateSignatureManager() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static System.Type MakeMethodDelegateType(MethodInfo method) => default; // 0x00000001843DFC40-0x00000001843E18F0
		public static System.Type MakeMethodDelegateType(MethodInfo method, System.Type customDelegateType) => default; // 0x00000001843DDE00-0x00000001843DEEA0
		public static ValueTuple<System.Type, string> GetMethodDelegateType(MethodInfo method) => default; // 0x00000001843DF840-0x00000001843DF960
	}

	public class SignatureLoader // TypeDefIndex: 56146
	{
		// Fields
		private LuaEnv.CustomLoader userLoader; // 0x10
		private RSACryptoServiceProvider rsa; // 0x18
		private SHA1 sha; // 0x20
	
		// Constructors
		public SignatureLoader() {} // Dummy constructor
		public SignatureLoader(string publicKey, LuaEnv.CustomLoader loader) {} // 0x000000018C3C00F8-0x000000018C3C01F8
	
		// Methods
		private byte[] load_and_verify(ref string filepath) => default; // 0x000000018C3C01F8-0x000000018C3C03D8
		public static implicit operator LuaEnv.CustomLoader(SignatureLoader signatureLoader) => default; // 0x000000018C3C03D8-0x000000018C3C044C
	}

	public delegate TRet CallDelegatePointer<TParam1, TParam2, TRet>(IntPtr ptr, TParam1 target, TParam2 param); // TypeDefIndex: 56147; 0x00000000-0x00000000

	public class StaticLuaCallbacks // TypeDefIndex: 56148
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
		public StaticLuaCallbacks() {} // 0x0000000185B8BFF0-0x0000000185B8C200
	
		// Methods
		public static int EnumAnd(IntPtr L) => default; // 0x000000018C3C122C-0x000000018C3C14B4
		public static int EnumOr(IntPtr L) => default; // 0x000000018C3C14B4-0x000000018C3C173C
		private static int StaticCSFunction(IntPtr L) => default; // 0x000000018C3C3124-0x000000018C3C32D0
		private static int FixCSFunction(IntPtr L) => default; // 0x0000000183FC9B00-0x0000000183FCA080
		public static int DelegateCall(IntPtr L) => default; // 0x000000018C3C0BA0-0x000000018C3C0D90
		public static int LuaGC(IntPtr L) => default; // 0x0000000184344020-0x00000001843440F0
		public static int ToString(IntPtr L) => default; // 0x0000000185518A20-0x0000000185518B60
		public static int DelegateCombine(IntPtr L) => default; // 0x000000018C3C0D90-0x000000018C3C0FF0
		public static int DelegateRemove(IntPtr L) => default; // 0x00000001858DBF50-0x00000001858DC0C0
		private static bool tryPrimitiveArrayGet(System.Type type, IntPtr L, object obj, int index) => default; // 0x000000018538F330-0x000000018538F820
		public static int ArrayIndexer(IntPtr L) => default; // 0x000000018538EF50-0x000000018538F330
		public static bool TryPrimitiveArraySet(System.Type type, IntPtr L, object obj, int array_idx, int obj_idx) => default; // 0x000000018C3C3664-0x000000018C3C3F88
		public static int ArrayNewIndexer(IntPtr L) => default; // 0x000000018C3C044C-0x000000018C3C08FC
		public static int ArrayLength(IntPtr L) => default; // 0x0000000185A19410-0x0000000185A19530
		public static int MetaFuncIndex(IntPtr L) => default; // 0x0000000185408D80-0x0000000185408EE0
		internal static int Panic(IntPtr L) => default; // 0x000000018C3C2C5C-0x000000018C3C2CF8
		internal static int Print(IntPtr L) => default; // 0x000000018C3C2CF8-0x000000018C3C2FDC
		internal static int LoadSocketCore(IntPtr L) => default; // 0x000000018C3C2C14-0x000000018C3C2C5C
		internal static int LoadCS(IntPtr L) => default; // 0x000000018C3C2598-0x000000018C3C2604
		internal static int LoadBuiltinLib(IntPtr L) => default; // 0x0000000185715FC0-0x0000000185716170
		internal static int LoadFromResource(IntPtr L) => default; // 0x000000018C3C2604-0x000000018C3C2918
		internal static int LoadFromStreamingAssetsPath(IntPtr L) => default; // 0x000000018C3C2918-0x000000018C3C2C14
		internal static int LoadFromCustomLoaders(IntPtr L) => default; // 0x0000000184C33440-0x0000000184C33C00
		public static int LoadAssembly(IntPtr L) => default; // 0x000000018C3C230C-0x000000018C3C2598
		public static int ImportType(IntPtr L) => default; // 0x0000000184CB8B20-0x0000000184CB8CE0
		public static int ImportGenericType(IntPtr L) => default; // 0x000000018C3C1F2C-0x000000018C3C230C
		public static int Cast(IntPtr L) => default; // 0x000000018C3C08FC-0x000000018C3C0BA0
		private static System.Type getType(IntPtr L, ObjectTranslator translator, int idx) => default; // 0x000000018C3C4918-0x000000018C3C4A9C
		public static int XLuaAccess(IntPtr L) => default; // 0x000000018C3C3F88-0x000000018C3C440C
		public static int XLuaPrivateAccessible(IntPtr L) => default; // 0x000000018C3C4710-0x000000018C3C4918
		public static int XLuaMetatableOperation(IntPtr L) => default; // 0x000000018C3C440C-0x000000018C3C4710
		public static int DelegateConstructor(IntPtr L) => default; // 0x000000018C3C0FF0-0x000000018C3C122C
		public static int ToFunction(IntPtr L) => default; // 0x000000018C3C32D0-0x000000018C3C3664
		public static int GenericMethodWraper(IntPtr L) => default; // 0x000000018C3C173C-0x000000018C3C1B24
		public static int GetGenericMethod(IntPtr L) => default; // 0x000000018C3C1B24-0x000000018C3C1F2C
		public static int ReleaseCsObject(IntPtr L) => default; // 0x000000018C3C2FDC-0x000000018C3C3124
	}

	internal static class TypeExtensions // TypeDefIndex: 56150
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56149
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, string> __9__12_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018414ED60-0x000000018414ED80
			public __c() {} // 0x0000000184344370-0x0000000184344390
	
			// Methods
			internal string _GetFriendlyName_b__12_0(System.Type x) => default; // 0x000000018414EA20-0x000000018414EA40
		}
	
		// Methods
		public static bool IsValueType(System.Type type) => default; // 0x0000000184346740-0x0000000184346770
		public static bool IsEnum(System.Type type) => default; // 0x000000018C3C87B0-0x000000018C3C87CC
		public static bool IsPrimitive(System.Type type) => default; // 0x0000000184348210-0x0000000184348230
		public static bool IsAbstract(System.Type type) => default; // 0x00000001843A0250-0x00000001843A0270
		public static bool IsSealed(System.Type type) => default; // 0x0000000184550530-0x0000000184550550
		public static bool IsInterface(System.Type type) => default; // 0x00000001843481F0-0x0000000184348210
		public static bool IsClass(System.Type type) => default; // 0x0000000184348230-0x0000000184348250
		public static System.Type BaseType(System.Type type) => default; // 0x000000018C3C8778-0x000000018C3C8794
		public static bool IsGenericType(System.Type type) => default; // 0x000000018C3C8794-0x000000018C3C87B0
		public static bool IsGenericTypeDefinition(System.Type type) => default; // 0x000000018C3C8280-0x000000018C3C8778
		public static bool IsNestedPublic(System.Type type) => default; // 0x000000018C3CB33C-0x000000018C3CB3A0
		public static bool IsPublic(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
		public static string GetFriendlyName(System.Type type) => default; // 0x000000018C3C8B0C-0x000000018C3C8B18
	}

	public enum LazyMemberTypes // TypeDefIndex: 56151
	{
		Method = 0,
		FieldGet = 1,
		FieldSet = 2,
		PropertyGet = 3,
		PropertySet = 4,
		Event = 5
	}

	public static class Utils // TypeDefIndex: 56167
	{
		// Fields
		public static bool s_xluaReflectionOpt; // 0x00
		public const int OBJ_META_IDX = -4; // Metadata: 0x0207C25F
		public const int METHOD_IDX = -3; // Metadata: 0x0207C260
		public const int GETTER_IDX = -2; // Metadata: 0x0207C261
		public const int SETTER_IDX = -1; // Metadata: 0x0207C262
		public const int CLS_IDX = -4; // Metadata: 0x0207C263
		public const int CLS_META_IDX = -3; // Metadata: 0x0207C264
		public const int CLS_GETTER_IDX = -2; // Metadata: 0x0207C265
		public const int CLS_SETTER_IDX = -1; // Metadata: 0x0207C266
		public const string LuaIndexsFieldName = "LuaIndexs"; // Metadata: 0x0207C267
		public const string LuaNewIndexsFieldName = "LuaNewIndexs"; // Metadata: 0x0207C271
		public const string LuaClassIndexsFieldName = "LuaClassIndexs"; // Metadata: 0x0207C27E
		public const string LuaClassNewIndexsFieldName = "LuaClassNewIndexs"; // Metadata: 0x0207C28D
	
		// Nested types
		private struct MethodKey // TypeDefIndex: 56152
		{
			// Fields
			public string Name; // 0x00
			public bool IsStatic; // 0x08
		}
	
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 56153
		{
			// Fields
			public bool exclude_generic_definition; // 0x10
			public Func<System.Type, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018C3CC74C-0x000000018C3CC7E0
	
			// Methods
			internal bool _GetAllTypes_b__0(System.Type type) => default; // 0x000000018C3CB6A0-0x000000018C3CB75C
		}
	
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 56154
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018C3CB468-0x000000018C3CB6A0
	
			// Methods
			internal int _genFieldGetter_b__0(IntPtr L) => default; // 0x000000018C3CCF70-0x000000018C3CD064
			internal int _genFieldGetter_b__1(IntPtr L) => default; // 0x00000001843436D0-0x0000000184343AE0
		}
	
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 56155
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x000000018C3CB75C-0x000000018C3CB7F0
	
			// Methods
			internal int _genFieldGetterByPointer_b__0(IntPtr L) => default; // 0x000000018C3CD064-0x000000018C3CD158
		}
	
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 56156
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x0000000184343AE0-0x0000000184343EE0
	
			// Methods
			internal int _genFieldSetter_b__0(IntPtr L) => default; // 0x000000018517B520-0x000000018517B970
			internal int _genFieldSetter_b__1(IntPtr L) => default; // 0x000000018C3CD158-0x000000018C3CD414
		}
	
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 56157
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x000000018517B970-0x000000018517BDC0
	
			// Methods
			internal int _genFieldSetterByPointer_b__0(IntPtr L) => default; // 0x000000018C3CD414-0x000000018C3CD6D0
		}
	
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 56158
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public MethodWrap[] methods; // 0x28
	
			// Constructors
			public __c__DisplayClass9_0() {} // 0x00000001858699A0-0x0000000185869A50
	
			// Methods
			internal int _genItemGetterOpt_b__1(IntPtr L) => default; // 0x0000000185192E50-0x0000000185193160
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 56159
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
			static __c() {} // 0x0000000184350740-0x0000000184356250
			public __c() {} // 0x000000018C3CD7F4-0x000000018C3CD998
	
			// Methods
			internal bool _genItemGetterOpt_b__9_0(PropertyInfo prop) => default; // 0x00000001845511B0-0x00000001845513D0
			internal bool _genItemGetter_b__10_0(PropertyInfo prop) => default; // 0x000000018C3CC948-0x000000018C3CCE08
			internal bool _genItemSetterOpt_b__11_0(PropertyInfo prop) => default; // 0x000000018C3CBAD0-0x000000018C3CC74C
			internal bool _genItemSetter_b__12_0(PropertyInfo prop) => default; // 0x000000018434F560-0x0000000184350200
			internal bool _GetExtensionMethodsOf_b__14_7(System.Type t) => default; // 0x0000000184550640-0x0000000184550A40
			internal bool _GetExtensionMethodsOf_b__14_8(System.Type t) => default; // 0x00000001845518A0-0x00000001845518B0
			internal IEnumerable<MethodInfo> _GetExtensionMethodsOf_b__14_0(System.Type type) => default; // 0x0000000184551B60-0x0000000184552120
			internal __f__AnonymousType1<System.Type, MethodInfo> _GetExtensionMethodsOf_b__14_1(System.Type type, MethodInfo method) => default; // 0x00000001845516B0-0x00000001845518A0
			internal bool _GetExtensionMethodsOf_b__14_2(__f__AnonymousType1<System.Type, MethodInfo> __h__TransparentIdentifier0) => default; // 0x000000018C3CCE08-0x000000018C3CCF70
			internal System.Type _GetExtensionMethodsOf_b__14_3(__f__AnonymousType1<System.Type, MethodInfo> __h__TransparentIdentifier0) => default; // 0x00000001845515B0-0x00000001845516B0
			internal MethodInfo _GetExtensionMethodsOf_b__14_4(__f__AnonymousType1<System.Type, MethodInfo> __h__TransparentIdentifier0) => default; // 0x00000001845501E0-0x00000001845504C0
			internal System.Type _GetExtensionMethodsOf_b__14_5(IGrouping<System.Type, MethodInfo> g) => default; // 0x00000001845518B0-0x0000000184551B60
			internal IEnumerable<MethodInfo> _GetExtensionMethodsOf_b__14_6(IGrouping<System.Type, MethodInfo> g) => default; // 0x00000001843988E0-0x0000000184398AF0
			internal string _makeReflectionWrap_b__16_0(MethodInfo p) => default; // 0x0000000184CF20A0-0x0000000184CF2290
			internal string _makeReflectionWrap_b__16_1(MethodInfo q) => default; // 0x0000000184553A30-0x0000000184553EA0
			internal MethodInfo _makeReflectionWrap_b__16_2(MethodInfo p, MethodInfo q) => default; // 0x0000000184F9A5A0-0x0000000184F9A6C0
		}
	
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 56160
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public object[] arg; // 0x28
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x000000018C3CB8F0-0x000000018C3CBAD0
	
			// Methods
			internal int _genItemGetter_b__1(IntPtr L) => default; // 0x000000018C3CC7E0-0x000000018C3CC948
		}
	
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 56161
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public MethodWrap[] methods; // 0x28
	
			// Constructors
			public __c__DisplayClass11_0() {} // 0x000000018C3CD6D0-0x000000018C3CD7F4
	
			// Methods
			internal int _genItemSetterOpt_b__1(IntPtr L) => default; // 0x0000000184C33F90-0x0000000184C34060
		}
	
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 56162
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public object[] arg; // 0x28
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x000000018C3CB7F0-0x000000018C3CB8F0
	
			// Methods
			internal int _genItemSetter_b__1(IntPtr L) => default; // 0x0000000185FA3C20-0x0000000185FA3C60
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 56163
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal int _genEnumCastFrom_b__0(IntPtr L) => default; // 0x000000018C3CA800-0x000000018C3CA824
		}
	
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 56164
		{
			// Fields
			public string fieldName; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal bool _makeReflectionWrap_b__3(EventInfo e) => default; // 0x000000018C3CA824-0x000000018C3CA8C4
		}
	
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 56165
		{
			// Fields
			public string memberName; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x000000018C3CA8C4-0x000000018C3CAB14
	
			// Methods
			internal bool _LazyReflectionCall_b__0(MethodInfo m) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 56166
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0() {} // 0x00000001843A6050-0x00000001843A6150
	
			// Methods
			internal int _ReflectionWrap_b__0(IntPtr LL) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		static Utils() {} // 0x000000018C3CA768-0x000000018C3CA800
	
		// Methods
		public static bool LoadField(IntPtr L, int idx, string field_name) => default; // 0x000000018C3CAC90-0x000000018C3CAF00
		public static IntPtr GetMainState(IntPtr L) => default; // 0x000000018C3CAF00-0x000000018C3CB2D8
		public static List<System.Type> GetAllTypes(bool exclude_generic_definition = true /* Metadata: 0x0207C25D */) => default; // 0x0000000185492010-0x0000000185492020
		private static lua_CSFunction genFieldGetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x0000000185B960B0-0x0000000185B961F0
		private static lua_CSFunction genFieldGetterByPointer(System.Type type, System.Reflection.FieldInfo field) => default; // 0x0000000185492010-0x0000000185492020
		public static bool IsNullableType(System.Type type) => default; // 0x0000000185298900-0x0000000185298AF0
		private static lua_CSFunction genFieldSetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x0000000185F6E170-0x0000000185F6E1D0
		private static lua_CSFunction genFieldSetterByPointer(System.Type type, System.Reflection.FieldInfo field) => default; // 0x0000000185492010-0x0000000185492020
		private static lua_CSFunction genItemGetterOpt(System.Type type, PropertyInfo[] props, ObjectTranslator translator) => default; // 0x000000018561ADF0-0x000000018561AEB0
		private static lua_CSFunction genItemGetter(System.Type type, PropertyInfo[] props) => default; // 0x000000018C3C8DD0-0x000000018C3C8E7C
		private static lua_CSFunction genItemSetterOpt(System.Type type, PropertyInfo[] props, ObjectTranslator translator) => default; // 0x000000018561AD30-0x000000018561ADF0
		private static lua_CSFunction genItemSetter(System.Type type, PropertyInfo[] props) => default; // 0x000000018C3C8E7C-0x000000018C3C8F28
		private static lua_CSFunction genEnumCastFrom(System.Type type) => default; // 0x000000018C3C8A14-0x000000018C3C8A90
		internal static IEnumerable<MethodInfo> GetExtensionMethodsOf(System.Type type_to_be_extend) => default; // 0x000000018C3C8A90-0x000000018C3C8B0C
		private static void makeReflectionWrap(IntPtr L, System.Type type, int cls_field, int cls_getter, int cls_setter, int obj_field, int obj_getter, int obj_setter, int obj_meta, out lua_CSFunction item_getter, out lua_CSFunction item_setter, System.Reflection.BindingFlags access) {
			item_getter = default;
			item_setter = default;
		} // 0x000000018C3C87CC-0x000000018C3C87EC
		public static void loadUpvalue(IntPtr L, System.Type type, string metafunc, int index) {} // 0x000000018C3C87EC-0x000000018C3C886C
		public static void RegisterEnumType(IntPtr L, System.Type type) {} // 0x000000018C3C886C-0x000000018C3C8934
		public static void MakePrivateAccessible(IntPtr L, System.Type type) {} // 0x000000018C3C8934-0x000000018C3C8990
		internal static int LazyReflectionCall(IntPtr L) => default; // 0x000000018C3C8990-0x000000018C3C89CC
		public static void ReflectionWrap(IntPtr L, System.Type type, bool privateAccessible) {} // 0x000000018C3C89CC-0x000000018C3C8A14
		public static void BeginObjectRegister(System.Type type, IntPtr L, ObjectTranslator translator, int meta_count, int method_count, int getter_count, int setter_count, int type_id = -1 /* Metadata: 0x0207C25E */) {} // 0x00000001834A4750-0x00000001834A4760
		private static int abs_idx(int top, int idx) => default; // 0x000000018C3C8F28-0x000000018C3C8F48
		public static void EndObjectRegister(System.Type type, IntPtr L, ObjectTranslator translator, lua_CSFunction csIndexer, lua_CSFunction csNewIndexer, System.Type base_type, lua_CSFunction arrayIndexer, lua_CSFunction arrayNewIndexer) {} // 0x000000018C3C8F28-0x000000018C3C8F48
		public static void RegisterFunc(IntPtr L, int idx, string name, lua_CSFunction func) {} // 0x00000001834A4750-0x00000001834A4760
		public static void RegisterLazyFunc(IntPtr L, int idx, string name, System.Type type, LazyMemberTypes memberType, bool isStatic) {} // 0x0000000185492010-0x0000000185492020
		public static void RegisterObject(IntPtr L, ObjectTranslator translator, int idx, string name, object obj) {} // 0x000000018C3C8F48-0x000000018C3C949C
		public static void BeginClassRegister(System.Type type, IntPtr L, lua_CSFunction creator, int class_field_count, int static_getter_count, int static_setter_count) {} // 0x0000000185492010-0x0000000185492020
		public static void EndClassRegister(System.Type type, IntPtr L, ObjectTranslator translator) {} // 0x000000018C3C949C-0x000000018C3C99A8
		private static List<string> getPathOfType(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
		public static void LoadCSTable(IntPtr L, System.Type type) {} // 0x000000018C3C99A8-0x000000018C3CA030
		public static void SetCSTable(IntPtr L, System.Type type, int cls_table) {} // 0x0000000185492010-0x0000000185492020
		public static bool IsParamsMatch(MethodInfo delegateMethod, MethodInfo bridgeMethod) => default; // 0x000000018C3CA030-0x000000018C3CA1DC
		public static bool IsSupportedMethod(MethodInfo method) => default; // 0x0000000185492010-0x0000000185492020
		public static MethodInfo MakeGenericMethodWithConstraints(MethodInfo method) => default; // 0x0000000185F05730-0x0000000185F05770
		private static System.Type getExtendedType(MethodInfo method) => default; // 0x0000000185492010-0x0000000185492020
		public static bool IsStaticPInvokeCSFunction(lua_CSFunction csFunction) => default; // 0x000000018B4D5B74-0x000000018B4D5BA8
		public static bool IsPublic(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
	}
}

namespace XLua.Cast
{
	public class Any<T> : RawObject // TypeDefIndex: 56194
	{
		// Fields
		private T mTarget;
	
		// Properties
		public object Target { get => default; }
	
		// Constructors
		public Any() {} // Dummy constructor
		public Any(T i) {}
	}

	public class Byte : Any<byte> // TypeDefIndex: 56195
	{
		// Constructors
		public Byte() {} // Dummy constructor
		public Byte(byte i) {} // 0x000000018C3C52D0-0x000000018C3C5310
	}

	public class SByte : Any<sbyte> // TypeDefIndex: 56196
	{
		// Constructors
		public SByte() {} // Dummy constructor
		public SByte(sbyte i) {} // 0x000000018C3C81F4-0x000000018C3C8234
	}

	public class Char : Any<char> // TypeDefIndex: 56197
	{
		// Constructors
		public Char() {} // Dummy constructor
		public Char(char i) {} // 0x000000018C3C5310-0x000000018C3C5354
	}

	public class Int16 : Any<short> // TypeDefIndex: 56198
	{
		// Constructors
		public Int16() {} // Dummy constructor
		public Int16(short i) {} // 0x000000018C3C6178-0x000000018C3C61BC
	}

	public class UInt16 : Any<ushort> // TypeDefIndex: 56199
	{
		// Constructors
		public UInt16() {} // Dummy constructor
		public UInt16(ushort i) {} // 0x000000018C3CB3A0-0x000000018C3CB3E4
	}

	public class Int32 : Any<int> // TypeDefIndex: 56200
	{
		// Constructors
		public Int32() {} // Dummy constructor
		public Int32(int i) {} // 0x000000018C3C61BC-0x000000018C3C61FC
	}

	public class UInt32 : Any<uint> // TypeDefIndex: 56201
	{
		// Constructors
		public UInt32() {} // Dummy constructor
		public UInt32(uint i) {} // 0x000000018C3CB3E4-0x000000018C3CB424
	}

	public class Int64 : Any<long> // TypeDefIndex: 56202
	{
		// Constructors
		public Int64() {} // Dummy constructor
		public Int64(long i) {} // 0x000000018C3C61FC-0x000000018C3C6240
	}

	public class UInt64 : Any<ulong> // TypeDefIndex: 56203
	{
		// Constructors
		public UInt64() {} // Dummy constructor
		public UInt64(ulong i) {} // 0x000000018C3CB424-0x000000018C3CB468
	}

	public class Float : Any<float> // TypeDefIndex: 56204
	{
		// Constructors
		public Float() {} // Dummy constructor
		public Float(float i) {} // 0x000000018C3C5400-0x000000018C3C5444
	}
}

namespace XLua.LuaDLL
{
	public delegate int lua_CSFunction(IntPtr L); // TypeDefIndex: 56205; 0x00000001817C2F70-0x00000001817C2F80

	public static class Lua // TypeDefIndex: 56209
	{
		// Fields
		private const string LUADLL = "__Internal"; // Metadata: 0x0207C2A6
		private static int s_mainThreadId; // 0x00
		public static Func<IntPtr, string> tryGetLuaStringFunc; // 0x08
		public static Action<IntPtr, IntPtr, int, string> refLuaStringFunc; // 0x10
		public const int LUAI_MAXSHORTLEN = 40; // Metadata: 0x0207C2B1
	
		// Nested types
		public delegate void HyperLuaLogCallbackDelegate(IntPtr L, int level, string text); // TypeDefIndex: 56206; 0x000000018C3C711C-0x000000018C3C7124
	
		public delegate void LuaUtilsLogCallbackDelegate(int level, string text); // TypeDefIndex: 56207; 0x000000018C3C7030-0x000000018C3C7038
	
		public delegate IntPtr DecryptionFunc(IntPtr input, int size, out int outSize); // TypeDefIndex: 56208; 0x00000001845551D0-0x0000000184555230
	
		// Constructors
		static Lua() {} // 0x000000018C3C6FE8-0x000000018C3C6FF0
	
		// Methods
		public static extern IntPtr lua_tothread(IntPtr L, int index); // 0x0000000186472174-0x000000018647217C
		public static extern int xlua_get_lib_version(); // 0x000000018C3C6DF4-0x000000018C3C6DFC
		public static extern int lua_gc(IntPtr L, XLua.LuaGCOptions what, int data); // 0x000000018C3C712C-0x000000018C3C7134
		public static extern IntPtr lua_getupvalue(IntPtr L, int funcindex, int n); // 0x000000018C3C6D88-0x000000018C3C6D90
		public static extern IntPtr lua_setupvalue(IntPtr L, int funcindex, int n); // 0x0000000186472198-0x00000001864721A0
		public static extern int lua_pushthread(IntPtr L); // 0x000000018646F27C-0x000000018646F290
		public static bool lua_isfunction(IntPtr L, int stackPos) => default; // 0x00000001845504C0-0x0000000184550530
		public static bool lua_islightuserdata(IntPtr L, int stackPos) => default; // 0x0000000184553130-0x0000000184553170
		public static bool lua_istable(IntPtr L, int stackPos) => default; // 0x0000000184C33170-0x0000000184C331B0
		public static bool lua_isthread(IntPtr L, int stackPos) => default; // 0x0000000186472190-0x0000000186472198
		public static int luaL_error(IntPtr L, string message) => default; // 0x000000018646F368-0x000000018646F370
		public static extern int lua_setfenv(IntPtr L, int stackPos); // 0x0000000184559250-0x00000001845592B0
		public static extern IntPtr luaL_newstate(); // 0x0000000186473930-0x0000000186473938
		public static extern void lua_close(IntPtr L); // 0x000000018646F2D8-0x000000018646F2E0
		public static extern void luaopen_xlua(IntPtr L); // 0x000000018646F2B8-0x000000018646F2C0
		public static extern void luaL_openlibs(IntPtr L); // 0x000000018646E8A8-0x000000018646E8B0
		public static extern uint xlua_objlen(IntPtr L, int stackPos); // 0x0000000186472188-0x0000000186472190
		public static extern void lua_createtable(IntPtr L, int narr, int nrec); // 0x000000018C3C6FD8-0x000000018C3C6FE0
		public static void lua_newtable(IntPtr L, int arrayL = 0 /* Metadata: 0x0207C2A2 */, int hashL = 0 /* Metadata: 0x0207C2A3 */) {} // 0x000000018646F2C0-0x000000018646F2C8
		public static extern int xlua_getglobal(IntPtr L, string name); // 0x000000018C3C6FD0-0x000000018C3C6FD8
		public static extern int xlua_setglobal(IntPtr L, string name); // 0x000000018C3C6FE0-0x000000018C3C6FE8
		public static extern void xlua_getloaders(IntPtr L); // 0x000000018646F320-0x000000018646F328
		public static extern void lua_settop(IntPtr L, int newTop); // 0x000000018646F300-0x000000018646F308
		public static void lua_pop(IntPtr L, int amount) {} // 0x0000000184555530-0x00000001845555B0
		public static extern void lua_insert(IntPtr L, int newTop); // 0x000000018433FFA0-0x000000018433FFC0
		public static extern void lua_remove(IntPtr L, int index); // 0x000000018C3C6EA4-0x000000018C3C6EF8
		public static extern int lua_rawget(IntPtr L, int index); // 0x000000018646F2A8-0x000000018646F2B0
		public static extern void lua_rawset(IntPtr L, int index); // 0x0000000184552250-0x00000001845522B0
		public static extern int lua_setmetatable(IntPtr L, int objIndex); // 0x000000018646F370-0x000000018646F378
		public static extern int lua_rawequal(IntPtr L, int index1, int index2); // 0x000000018647256C-0x0000000186472574
		public static extern void lua_pushvalue(IntPtr L, int index); // 0x00000001845592B0-0x0000000184559370
		public static extern void lua_pushcclosure(IntPtr L, IntPtr fn, int n); // 0x000000018C3C7134-0x000000018C3C713C
		public static extern void lua_replace(IntPtr L, int index); // 0x000000018646F274-0x000000018646F27C
		public static extern int lua_gettop(IntPtr L); // 0x000000018454FA20-0x000000018454FA90
		public static extern LuaTypes lua_type(IntPtr L, int index); // 0x000000018C3C6F60-0x000000018C3C6F74
		public static bool lua_isnil(IntPtr L, int index) => default; // 0x00000001850D3E80-0x00000001850D3EA0
		public static extern bool lua_isnumber(IntPtr L, int index); // 0x000000018646F2A0-0x000000018646F2A8
		public static bool lua_isboolean(IntPtr L, int index) => default; // 0x00000001843505F0-0x0000000184350740
		public static extern int luaL_ref(IntPtr L, int registryIndex); // 0x000000018646D4EC-0x000000018646D4F4
		public static int luaL_ref(IntPtr L) => default; // 0x0000000184774E90-0x0000000184775050
		public static extern void xlua_rawgeti(IntPtr L, int tableIndex, long index); // 0x000000018646FEDC-0x000000018646FEE4
		public static extern void xlua_rawseti(IntPtr L, int tableIndex, long index); // 0x000000018646EF8C-0x000000018646EF94
		public static void lua_getref(IntPtr L, int reference) {} // 0x000000018646D4F4-0x000000018646D4FC
		public static extern int pcall_prepare(IntPtr L, int error_func_ref, int func_ref); // 0x0000000186473090-0x0000000186473098
		public static extern void luaL_unref(IntPtr L, int registryIndex, int reference); // 0x00000001844E18A0-0x00000001844E1900
		public static void lua_unref(IntPtr L, int reference) {} // 0x000000018C3C7114-0x000000018C3C711C
		public static extern bool lua_isstring(IntPtr L, int index); // 0x000000018646F318-0x000000018646F320
		public static extern bool lua_isinteger(IntPtr L, int index); // 0x0000000184555D50-0x0000000184555DB0
		public static extern void lua_pushnil(IntPtr L); // 0x0000000184555DB0-0x0000000184556840
		public static void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, int n = 0 /* Metadata: 0x0207C2A4 */) {} // 0x00000001844CE2A0-0x00000001844CE2D0
		public static extern int xlua_upvalueindex(int n); // 0x000000018646F2B0-0x000000018646F2B8
		public static int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc) => default; // 0x0000000184556840-0x0000000184556850
		public static extern int _lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc); // 0x00000001843505E0-0x00000001843505F0
		public static extern double lua_tonumber(IntPtr L, int index); // 0x000000018647046C-0x0000000186470474
		public static extern int xlua_tointeger(IntPtr L, int index); // 0x00000001843413D0-0x0000000184341630
		public static extern uint xlua_touint(IntPtr L, int index); // 0x0000000184197F10-0x0000000184197F30
		public static extern bool lua_toboolean(IntPtr L, int index); // 0x0000000184197F30-0x0000000184198180
		public static extern IntPtr lua_topointer(IntPtr L, int index); // 0x000000018545B0C0-0x000000018545B130
		public static extern IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen); // 0x000000018C3C7038-0x000000018C3C7114
		public static string lua_tostring_beyond(IntPtr L, int index) => default; // 0x0000000184811980-0x00000001848119C0
		public static string lua_tostring(IntPtr L, int index, bool cache = false /* Metadata: 0x0207C2A5 */) => default; // 0x000000018646F378-0x000000018646F380
		public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf); // 0x000000018646F360-0x000000018646F368
		public static extern void lua_pushnumber(IntPtr L, double number); // 0x0000000184553270-0x00000001845532E0
		public static extern void lua_pushboolean(IntPtr L, bool value); // 0x0000000184C33C00-0x0000000184C33C70
		public static extern void xlua_pushinteger(IntPtr L, int value); // 0x000000018C3C6CF4-0x000000018C3C6D88
		public static extern void xlua_pushuint(IntPtr L, uint value); // 0x000000018646E860-0x000000018646E868
		public static void lua_pushstring(IntPtr L, string str) {} // 0x000000018646DE34-0x000000018646DE3C
		public static extern void xlua_pushlstring(IntPtr L, byte[] str, int size); // 0x000000018C3C6DFC-0x000000018C3C6E48
		public static void xlua_pushasciistring(IntPtr L, string str) {} // 0x0000000184C34E90-0x0000000184C34EB0
		public static void lua_pushstring(IntPtr L, byte[] str) {} // 0x000000018C3C6FC8-0x000000018C3C6FD0
		public static byte[] lua_tobytes(IntPtr L, int index) => default; // 0x0000000186475060-0x0000000186475068
		public static extern int luaL_newmetatable(IntPtr L, string meta); // 0x0000000186475058-0x0000000186475060
		public static extern int xlua_pgettable(IntPtr L, int idx); // 0x000000018C3C6DEC-0x000000018C3C6DF4
		public static extern int xlua_psettable(IntPtr L, int idx); // 0x000000018646DE2C-0x000000018646DE34
		public static void luaL_getmetatable(IntPtr L, string meta) {} // 0x000000018C3C73B0-0x000000018C3C73BC
		public static extern int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name); // 0x000000018C3C6C90-0x000000018C3C6C98
		public static int luaL_loadbuffer(IntPtr L, string buff, string name) => default; // 0x000000018C3C6C98-0x000000018C3C6CA0
		public static extern int xlua_tocsobj_safe(IntPtr L, int obj); // 0x000000018C3C6C80-0x000000018C3C6C88
		public static extern int xlua_tocsobj_fast(IntPtr L, int obj); // 0x000000018C3C6C88-0x000000018C3C6C90
		public static int lua_error(IntPtr L) => default; // 0x0000000186472134-0x000000018647213C
		public static extern bool lua_checkstack(IntPtr L, int extra); // 0x000000018646FED4-0x000000018646FEDC
		public static extern int lua_next(IntPtr L, int index); // 0x000000018647213C-0x0000000186472144
		public static extern void lua_pushlightuserdata(IntPtr L, IntPtr udata); // 0x000000018C3C7124-0x000000018C3C712C
		public static extern IntPtr xlua_tag(); // 0x000000018647045C-0x0000000186470464
		public static extern void luaL_where(IntPtr L, int level); // 0x000000018647045C-0x0000000186470464
		public static extern int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref); // 0x000000018C3C6EF8-0x000000018C3C6F0C
		public static extern void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref); // 0x000000018C3C6EF8-0x000000018C3C6F0C
		public static extern int gen_obj_indexer(IntPtr L); // 0x000000018646D4F4-0x000000018646D4FC
		public static extern int gen_obj_newindexer(IntPtr L); // 0x000000018646D4F4-0x000000018646D4FC
		public static extern int gen_cls_indexer(IntPtr L); // 0x000000018646E8A0-0x000000018646E8A8
		public static extern int gen_cls_newindexer(IntPtr L); // 0x000000018C3C7144-0x000000018C3C7184
		public static extern int get_error_func_ref(IntPtr L); // 0x000000018C3C713C-0x000000018C3C7144
		public static extern int load_error_func(IntPtr L, int Ref); // 0x000000018C3C734C-0x000000018C3C7360
		public static extern int luaopen_i64lib(IntPtr L); // 0x000000018C3C74DC-0x000000018C3C74F0
		public static extern int luaopen_socket_core(IntPtr L); // 0x000000018C3C7324-0x000000018C3C7338
		public static extern void lua_pushint64(IntPtr L, long n); // 0x000000018C3C74C8-0x000000018C3C74DC
		public static extern void lua_pushuint64(IntPtr L, ulong n); // 0x0000000184CF4DE0-0x0000000184CF4E00
		public static extern bool lua_isint64(IntPtr L, int idx); // 0x0000000184D276A0-0x0000000184D276C0
		public static extern bool lua_isuint64(IntPtr L, int idx); // 0x000000018C3C7338-0x000000018C3C734C
		public static extern long lua_toint64(IntPtr L, int idx); // 0x000000018C3C73EC-0x000000018C3C7400
		public static extern ulong lua_touint64(IntPtr L, int idx); // 0x000000018C3C7310-0x000000018C3C7324
		public static extern void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n); // 0x000000018C3C74B4-0x000000018C3C74C8
		public static extern int xlua_csharp_str_error(IntPtr L, string message); // 0x000000018C3C7274-0x000000018C3C7288
		public static extern int xlua_csharp_error(IntPtr L); // 0x000000018C3C73EC-0x000000018C3C7400
		public static extern bool xlua_pack_int8_t(IntPtr buff, int offset, byte field); // 0x000000018646EFA0-0x000000018646EFA8
		public static extern bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field); // 0x000000018C3C73BC-0x000000018C3C73C4
		public static extern bool xlua_pack_int16_t(IntPtr buff, int offset, short field); // 0x000000018646EFD4-0x000000018646EFDC
		public static extern bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field); // 0x000000018646F2C8-0x000000018646F2D0
		public static extern bool xlua_pack_int32_t(IntPtr buff, int offset, int field); // 0x0000000186472144-0x000000018647214C
		public static extern bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field); // 0x000000018562B370-0x000000018562B3C0
		public static extern bool xlua_pack_int64_t(IntPtr buff, int offset, long field); // 0x000000018C3C7360-0x000000018C3C73B0
		public static extern bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field); // 0x00000001844DFDB0-0x00000001844DFDD0
		public static extern bool xlua_pack_float(IntPtr buff, int offset, float field); // 0x000000018C3C7400-0x000000018C3C7414
		public static extern bool xlua_unpack_float(IntPtr buff, int offset, out float field); // 0x00000001844DFD00-0x00000001844DFD30
		public static extern bool xlua_pack_double(IntPtr buff, int offset, double field); // 0x00000001851DF670-0x00000001851DF6A0
		public static extern bool xlua_unpack_double(IntPtr buff, int offset, out double field); // 0x00000001844DBE00-0x00000001844DBE30
		public static extern IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref); // 0x000000018C3C7414-0x000000018C3C743C
		public static extern void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref); // 0x000000018C3C7288-0x000000018C3C72C4
		public static extern IntPtr lua_touserdata(IntPtr L, int idx); // 0x000000018C3C743C-0x000000018C3C7470
		public static extern int xlua_gettypeid(IntPtr L, int idx); // 0x000000018C3C72C4-0x000000018C3C7310
		public static extern int xlua_get_registry_index(); // 0x000000018C3C7470-0x000000018C3C74B4
		public static extern int xlua_pgettable_bypath(IntPtr L, int idx, string path); // 0x000000018C3C7260-0x000000018C3C7274
		public static extern int xlua_psettable_bypath(IntPtr L, int idx, string path); // 0x000000018C3C73C4-0x000000018C3C73EC
		public static extern bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2); // 0x000000018C3C7184-0x000000018C3C7204
		public static extern bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2); // 0x000000018C3C7204-0x000000018C3C7260
		public static extern bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3); // 0x00000001864752C4-0x00000001864752CC
		public static extern bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3); // 0x000000018C3C6D90-0x000000018C3C6DEC
		public static extern bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4); // 0x000000018C3C6FF0-0x000000018C3C7030
		public static extern bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4); // 0x000000018C3C6E50-0x000000018C3C6E94
		public static extern bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5); // 0x000000018C3C6E94-0x000000018C3C6E9C
		public static extern bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5); // 0x000000018C3C6E48-0x000000018C3C6E50
		public static extern bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5, float f6); // 0x000000018646FEA0-0x000000018646FEA8
		public static extern bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5, out float f6); // 0x00000001864753BC-0x00000001864753C4
		public static extern bool xlua_pack_decimal(IntPtr buff, int offset, ref decimal dec); // 0x00000001844CE2D0-0x00000001844CE2F0
		public static extern bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign, out int hi32, out ulong lo64); // 0x0000000185F51580-0x0000000185F515D0
		public static bool xlua_is_eq_str(IntPtr L, int index, string str) => default; // 0x0000000185F8B320-0x0000000185F8B370
		public static extern bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len); // 0x00000001864753AC-0x00000001864753B4
		public static extern IntPtr xlua_gl(IntPtr L); // 0x00000001844CE2F0-0x00000001844CE310
		public static extern int luaL_traceback(IntPtr L, IntPtr L1, string msg, int level); // 0x0000000185F514E0-0x0000000185F51530
		public static extern int lua_sethook(IntPtr L, XLua.LuaDLL.lua_Hook hook, int mask, int count); // 0x0000000185F8B2D0-0x0000000185F8B320
		public static extern XLua.LuaDLL.lua_Hook lua_gethook(IntPtr L); // 0x00000001864753A4-0x00000001864753AC
		public static extern int lua_gethookmask(IntPtr L); // 0x0000000185F51490-0x0000000185F514E0
		public static extern int lua_getglobal(IntPtr L, IntPtr charPtr); // 0x00000001864753B4-0x00000001864753BC
		public static extern int lua_pushlstring(IntPtr L, IntPtr charPtr, int len); // 0x0000000185F51530-0x0000000185F51580
		public static extern int luaopen_HyperLua(IntPtr L); // 0x000000018C3C6C78-0x000000018C3C6C80
		public static extern void HyperLua_SetLogCallback(HyperLuaLogCallbackDelegate logCallback); // 0x0000000185F190A0-0x0000000185F19130
		public static int LoadHyperLua(IntPtr L) => default; // 0x0000000181A578C0-0x0000000181A578E0
		public static void SetHyperLuaLogCallback(HyperLuaLogCallbackDelegate logCallback) {} // 0x000000018C3C5444-0x000000018C3C54E0
		public static extern int luaopen_LuaUtils(IntPtr L); // 0x00000001864BB614-0x00000001864BB734
		public static extern void LuaUtils_SetLogCallback(LuaUtilsLogCallbackDelegate logCallback); // 0x000000018476D7A0-0x000000018476D830
		public static int LoadLuaUtils(IntPtr L) => default; // 0x00000001831C5680-0x00000001831C5690
		public static void SetLuaUtilsLogCallback(LuaUtilsLogCallbackDelegate logCallback) {} // 0x000000018C3C6BF8-0x000000018C3C6C78
		public static extern int luaopen_rapidjson(IntPtr L); // 0x00000001864BB614-0x00000001864BB734
		public static int LoadRapidJson(IntPtr L) => default; // 0x0000000185F1A770-0x0000000185F1A800
		public static extern int luaopen_pb(IntPtr L); // 0x00000001817E31E0-0x00000001817E3200
		public static int LoadLuaProtobuf(IntPtr L) => default; // 0x000000018C3C5354-0x000000018C3C5400
		public static extern void beyond_setDecryptionFunc(IntPtr L, IntPtr func); // 0x0000000187208828-0x0000000187208854
	}

	public delegate int lua_Hook(IntPtr L, ref lua_debug ar); // TypeDefIndex: 56210; 0x0000000181B59400-0x0000000181B59410
}

namespace XLua.Reflection
{
	public class LuaObjFieldGetterSetter // TypeDefIndex: 56192
	{
		// Nested types
		private sealed class __c__DisplayClass3_0<T> // TypeDefIndex: 56174
			where T : struct
		{
			// Fields
			public bool isUnmanagedType;
			public System.Reflection.FieldInfo field;
			public System.Type type;
			public int offset;
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018C3C6240-0x000000018C3C6410
	
			// Methods
			internal int _GetObjFieldGetterByPushInt32_b__0(IntPtr L) => default; // 0x000000018C3C64E0-0x000000018C3C6534
		}
	
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 56175
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x000000018C3C6410-0x000000018C3C64E0
	
			// Methods
			internal int _GetObjFloatFieldGetterByPushNumber_b__0(IntPtr L) => default;
		}
	
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 56176
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x00000001843450D0-0x00000001843451C0
	
			// Methods
			internal int _GetObjDoubleFieldGetterByPushNumber_b__0(IntPtr L) => default; // 0x0000000185644150-0x0000000185644240
		}
	
		private sealed class __c__DisplayClass6_0<T> // TypeDefIndex: 56177
			where T : struct
		{
			// Fields
			public bool isUnmanagedType;
			public System.Reflection.FieldInfo field;
			public System.Type type;
			public int offset;
	
			// Constructors
			public __c__DisplayClass6_0() {}
	
			// Methods
			internal int _GetObjFieldGetterByPushInt64_b__0(IntPtr L) => default; // 0x0000000184344E00-0x0000000184344EF0
		}
	
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 56178
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x0000000184344EF0-0x0000000184344FE0
	
			// Methods
			internal int _GetObjFieldGetterByPushBool_b__0(IntPtr L) => default; // 0x0000000184344BE0-0x0000000184344CD0
		}
	
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 56179
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x00000001843432F0-0x00000001843434E0
	
			// Methods
			internal int _GetObjFieldGetterByPushString_b__0(IntPtr L) => default; // 0x00000001853EEF00-0x00000001853EEFD0
		}
	
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 56180
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass9_0() {}
	
			// Methods
			internal int _GetObjFieldObjGetter_b__0(IntPtr L) => default; // 0x0000000184344390-0x00000001843444A0
		}
	
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 56181
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
			public __c__DisplayClass10_0() {} // 0x0000000184343120-0x00000001843432F0
	
			// Methods
			internal int _GetObjFieldStructGetter_b__0(IntPtr L) => default;
		}
	
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 56182
		{
			// Fields
			public System.Type type; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public int offset; // 0x20
	
			// Constructors
			public __c__DisplayClass11_0() {}
	
			// Methods
			internal int _GetObjFieldEnumGetter_b__0(IntPtr L) => default; // 0x0000000184344FE0-0x00000001843450D0
		}
	
		private sealed class __c__DisplayClass12_0<T> // TypeDefIndex: 56183
			where T : struct
		{
			// Fields
			public System.Type type;
			public System.Reflection.FieldInfo field;
			public int offset;
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x0000000185644060-0x0000000185644150
	
			// Methods
			internal int _GetObjFieldStructGetter_b__0(IntPtr L) => default; // 0x0000000184344D10-0x0000000184344E00
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 56184
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x00000001853AE070-0x00000001853AE160
	
			// Methods
			internal int _GetObjFieldObjSetter_b__0(IntPtr L) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 56185
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
			public bool isNullable; // 0x2C
			public int size; // 0x30
	
			// Constructors
			public __c__DisplayClass14_0() {}
	
			// Methods
			internal int _GetObjFieldStructSetter_b__0(IntPtr L) => default;
		}
	
		private sealed class __c__DisplayClass15_0<T> // TypeDefIndex: 56186
			where T : struct
		{
			// Fields
			public bool isUnmanagedType;
			public System.Reflection.FieldInfo field;
			public System.Type type;
			public int offset;
	
			// Constructors
			public __c__DisplayClass15_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal int _GetObjFieldSetterByGetInt32_b__0(IntPtr L) => default; // 0x000000018515CDA0-0x000000018515CED0
		}
	
		private sealed class __c__DisplayClass16_0<T> // TypeDefIndex: 56187
			where T : struct
		{
			// Fields
			public bool isUnmanagedType;
			public System.Reflection.FieldInfo field;
			public System.Type type;
			public int offset;
	
			// Constructors
			public __c__DisplayClass16_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal int _GetObjFieldSetterByGetInt64_b__0(IntPtr L) => default; // 0x000000018C3CAB14-0x000000018C3CAC90
		}
	
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 56188
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass17_0() {}
	
			// Methods
			internal int _GetObjFloatFieldSetterByGetNumber_b__0(IntPtr L) => default;
		}
	
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 56189
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass18_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal int _GetObjDoubleFieldSetterByGetNumber_b__0(IntPtr L) => default; // 0x0000000184F47970-0x0000000184F47A90
		}
	
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 56190
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass19_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal int _GetObjFieldBoolSetter_b__0(IntPtr L) => default; // 0x0000000184341270-0x00000001843413D0
		}
	
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 56191
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal int _GetObjFieldEnumSetter_b__0(IntPtr L) => default; // 0x0000000184557CC0-0x0000000184557F70
		}
	
		// Constructors
		public LuaObjFieldGetterSetter() {} // 0x000000018C3CA348-0x000000018C3CA768
	
		// Methods
		private static bool _CheckRuntimeType(IntPtr L, object obj, System.Type type, System.Reflection.FieldInfo field) => default; // 0x0000000185492010-0x0000000185492020
		private static IntPtr _GetPtrFromObj(object obj) => default; // 0x00000001844DE4B0-0x00000001844DE5F0
		private static IntPtr _GetPtrFromLuaStack(IntPtr L, ObjectTranslator translator, int index, bool isUnmanagedType) => default; // 0x0000000185492010-0x0000000185492020
		public static lua_CSFunction GetObjFieldGetterByPushInt32<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct => default; // 0x000000018454FC40-0x000000018454FDA0
		public static lua_CSFunction GetObjFloatFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field) => default;
		public static lua_CSFunction GetObjDoubleFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field) => default;
		public static lua_CSFunction GetObjFieldGetterByPushInt64<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct => default; // 0x0000000185492010-0x0000000185492020
		public static lua_CSFunction GetObjFieldGetterByPushBool(System.Type type, System.Reflection.FieldInfo field) => default; // 0x000000018454FA90-0x000000018454FBC0
		public static lua_CSFunction GetObjFieldGetterByPushString(System.Type type, System.Reflection.FieldInfo field) => default; // 0x0000000185492010-0x0000000185492020
		public static lua_CSFunction GetObjFieldObjGetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001855F6D20-0x00000001855F6EB0
		public static lua_CSFunction GetObjFieldStructGetter(System.Type type, System.Reflection.FieldInfo field) => default;
		public static lua_CSFunction GetObjFieldEnumGetter(System.Type type, System.Reflection.FieldInfo field) => default;
		public static lua_CSFunction GetObjFieldStructGetter<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct => default;
		public static lua_CSFunction GetObjFieldObjSetter(System.Type type, System.Reflection.FieldInfo field) => default;
		public static lua_CSFunction GetObjFieldStructSetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x0000000185492010-0x0000000185492020
		public static lua_CSFunction GetObjFieldSetterByGetInt32<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct => default; // 0x0000000185B88490-0x0000000185B885C0
		public static lua_CSFunction GetObjFieldSetterByGetInt64<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct => default; // 0x0000000185492010-0x0000000185492020
		public static lua_CSFunction GetObjFloatFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field) => default; // 0x000000018C3CA1DC-0x000000018C3CA348
		public static lua_CSFunction GetObjDoubleFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field) => default; // 0x0000000185492010-0x0000000185492020
		public static lua_CSFunction GetObjFieldBoolSetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001853B6BB0-0x00000001853B6CD0
		public static lua_CSFunction GetObjFieldEnumSetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x0000000185492010-0x0000000185492020
	}

	public static class RuntimeEnumDic // TypeDefIndex: 56193
	{
		// Fields
		private static Dictionary<System.Type, Dictionary<int, object>> s_enumDic; // 0x00
	
		// Constructors
		static RuntimeEnumDic() {} // 0x0000000185F3ED40-0x0000000185F3EDD0
	
		// Methods
		public static object GetEnumByTypeAndValue(System.Type enumType, int value) => default; // 0x000000018454FDA0-0x00000001845501E0
		public static void AddEnumValue(System.Type enumType, object enumObj) {} // 0x00000001847B7FB0-0x00000001847B8150
	}
}

namespace XLua.TemplateEngine
{
	public enum TokenType // TypeDefIndex: 56168
	{
		Code = 0,
		Eval = 1,
		Text = 2
	}

	public class Chunk // TypeDefIndex: 56169
	{
		// Fields
		private XLua.TemplateEngine.TokenType _Type_k__BackingField; // 0x10
		private string _Text_k__BackingField; // 0x18
	
		// Properties
		public XLua.TemplateEngine.TokenType Type { get; private set; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public string Text { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public Chunk() {} // Dummy constructor
		public Chunk(XLua.TemplateEngine.TokenType type, string text) {} // 0x000000018646E950-0x000000018646E960
	}

	internal class TemplateFormatException : Exception // TypeDefIndex: 56170
	{
		// Constructors
		public TemplateFormatException() {} // Dummy constructor
		public TemplateFormatException(string message) {} // 0x000000018C3C8234-0x000000018C3C8280
	}

	public class Parser // TypeDefIndex: 56172
	{
		// Fields
		private static string _RegexString_k__BackingField; // 0x00
	
		// Properties
		public static string RegexString { get; private set; } // 0x000000018C3CB2D8-0x000000018C3CB33C 0x0000000185492010-0x0000000185492020
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56171
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Text.RegularExpressions.Capture, __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int>> __9__7_0; // 0x08
			public static Func<System.Text.RegularExpressions.Capture, __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int>> __9__7_1; // 0x10
			public static Func<System.Text.RegularExpressions.Capture, __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int>> __9__7_2; // 0x18
			public static Func<__f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int>, int> __9__7_3; // 0x20
			public static Func<__f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int>, Chunk> __9__7_4; // 0x28
	
			// Constructors
			static __c() {} // 0x000000018C3C8148-0x000000018C3C8198
			public __c() {} // 0x000000018C3C8198-0x000000018C3C81F4
	
			// Methods
			internal __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int> _Parse_b__7_0(System.Text.RegularExpressions.Capture p) => default; // 0x000000018C3C80D8-0x000000018C3C8148
			internal __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int> _Parse_b__7_1(System.Text.RegularExpressions.Capture p) => default; // 0x000000018C3C74F0-0x000000018C3C7788
			internal __f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int> _Parse_b__7_2(System.Text.RegularExpressions.Capture p) => default; // 0x000000018C3C7788-0x000000018C3C79C0
			internal int _Parse_b__7_3(__f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int> p) => default; // 0x000000018C3C79C0-0x000000018C3C80D8
			internal Chunk _Parse_b__7_4(__f__AnonymousType0<XLua.TemplateEngine.TokenType, string, int> m) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		static Parser() {} // 0x000000018C3C8B18-0x000000018C3C8BB0
		public Parser() {} // 0x000000018C3C8D48-0x000000018C3C8DD0
	
		// Methods
		private static string EscapeString(string input) => default; // 0x000000018C3C8BB0-0x000000018C3C8C70
		private static string GetRegexString() => default; // 0x000000018C3C8C70-0x000000018C3C8D0C
		public static List<Chunk> Parse(string snippet) => default; // 0x000000018C3C8D0C-0x000000018C3C8D48
	}

	public class LuaTemplate // TypeDefIndex: 56173
	{
		// Fields
		private static lua_CSFunction templateCompileFunction; // 0x00
		private static lua_CSFunction templateExecuteFunction; // 0x08
	
		// Constructors
		public LuaTemplate() {} // 0x0000000185492010-0x0000000185492020
		static LuaTemplate() {} // 0x0000000185EB5410-0x0000000185EB5500
	
		// Methods
		public static string ComposeCode(List<Chunk> chunks) => default; // 0x000000018C3C6794-0x000000018C3C6A1C
		public static LuaFunction Compile(LuaEnv luaenv, string snippet) => default; // 0x000000018C3C6534-0x000000018C3C65D8
		public static string Execute(LuaFunction compiledTemplate, LuaTable parameters) => default; // 0x000000018C3C6AF0-0x000000018C3C6B80
		public static string Execute(LuaFunction compiledTemplate) => default; // 0x000000018C3C6B80-0x000000018C3C6BF8
		public static int Compile(IntPtr L) => default; // 0x000000018C3C65D8-0x000000018C3C6794
		public static int Execute(IntPtr L) => default; // 0x000000018C3C6A1C-0x000000018C3C6AF0
		public static void OpenLib(IntPtr L) {} // 0x0000000184C33040-0x0000000184C33170
	}
}
