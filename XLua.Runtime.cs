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
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.LowLevel;
using UnityEngine.Pool;
using XLua;
using XLua.LuaDLL;

// Image 37: XLua.Runtime.dll - Assembly: XLua.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 54978-55220
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[Serializable]
public class LuaAsset : ScriptableObject // TypeDefIndex: 54983
{
	// Fields
	public static string LuaDecodeKey; // 0x00
	public bool encode; // 0x18
	public byte[] data; // 0x20

	// Constructors
	public LuaAsset() {} // 0x0000000185AE6988-0x0000000185AE6994
	static LuaAsset() {} // 0x000000018A29B5B8-0x000000018A29B614

	// Methods
	public byte[] GetDecodeBytes() => default; // 0x000000018A29B530-0x000000018A29B5B8
}

namespace Beyond.Lua
{
	public class LuaCypher // TypeDefIndex: 55053
	{
		// Fields
		private const string KEY = "=="; // Metadata: 0x01FD6979
		private static readonly string[] KEYS; // 0x00
		private const string INITIAL_ASSETS_ROOT_PATH = "Assets/Beyond/InitialAssets/"; // Metadata: 0x01FD697C
		private static readonly ProfilerMarker decryptionMaker; // 0x08
	
		// Constructors
		public LuaCypher() {} // 0x000000018350B670-0x000000018350B680
		static LuaCypher() {} // 0x00000001839D0E20-0x00000001839D0FE0
	
		// Methods
		[IDTag(0)]
		private static string GetKey() => default; // 0x000000018A29C2D8-0x000000018A29C608
		[IDTag(1)]
		private static void GetKey(Span<byte> buffer, out int len) {
			len = default;
		} // 0x000000018A29C06C-0x000000018A29C2D8
		protected static bool SkipDecrypt(string luaString) => default; // 0x000000018A29C608-0x000000018A29C718
		public static string DecryptLuaString(string encryptLua) => default; // 0x000000018A29B854-0x000000018A29B8F0
		public static byte[] DecryptLua(string encryptLua) => default; // 0x000000018A29B8F0-0x000000018A29C06C
		[XLua.MonoPInvokeCallback(typeof(Lua.DecryptionFunc))]
		public static IntPtr DecryptionFunc(IntPtr input, int size, out int outSize) {
			outSize = default;
			return default;
		} // 0x000000018328D390-0x000000018328E560
	}

	public class LuaGenericDelegateCaller // TypeDefIndex: 55055
	{
		// Fields
		private static Dictionary<string, LuaGenericDelegateCall> s_callerDic; // 0x00
	
		// Nested types
		public delegate int LuaGenericDelegateCall(IntPtr L, Delegate @delegate, ObjectTranslator objectTranslator, List<System.Type> castType); // TypeDefIndex: 55054; 0x000000018101C850-0x000000018101C870
	
		// Constructors
		public LuaGenericDelegateCaller() {} // 0x000000018350B670-0x000000018350B680
		static LuaGenericDelegateCaller() {} // 0x0000000183CE3AF0-0x0000000183CE3B80
	
		// Methods
		public static LuaGenericDelegateCall GetCaller(string delegateTypeName) => default; // 0x00000001832D5B20-0x00000001832D5BE0
		public static void AddCaller(string delegateTypeName, LuaGenericDelegateCall caller) {} // 0x00000001823116C0-0x00000001823118A0
		public static int OverloadMethodCall(IntPtr L, ObjectTranslator objectTranslator, IOverloadMethodWrap[] overload) => default; // 0x0000000182613990-0x0000000182613BE0
		public static int DefaultValueMethodCall(IntPtr L, ObjectTranslator objectTranslator, IOverloadMethodWrap[] defaultValues) => default; // 0x00000001826126F0-0x0000000182612A00
	}
}

namespace Beyond.Reflection
{
	public class GenericDelegateCaller // TypeDefIndex: 54985
	{
		// Fields
		private static Dictionary<string, System.Type> s_customDelegateTypeDic; // 0x00
	
		// Constructors
		public GenericDelegateCaller() {} // 0x000000018350B670-0x000000018350B680
		static GenericDelegateCaller() {} // 0x0000000183690C80-0x0000000183690D10
	
		// Methods
		public static System.Type GetCustomDelegateType(string delegateName) => default; // 0x00000001826AD210-0x00000001826AD2D0
		public static void AddCustomDelegateType(string delegateName, System.Type type) {} // 0x00000001823114E0-0x00000001823116C0
	}

	public class MethodParamItem // TypeDefIndex: 54986
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
		public MethodParamItem() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static List<MethodParamItem> GetMethodParamList(MethodInfo method, bool needLua = false /* Metadata: 0x01FD6971 */, bool needEnum = false /* Metadata: 0x01FD6972 */) => default; // 0x0000000182303020-0x00000001823035A0
		public static string GetMethodSignatureString(MethodInfo method, bool needLua = false /* Metadata: 0x01FD6973 */, bool keepType = false /* Metadata: 0x01FD6974 */, bool needEnum = false /* Metadata: 0x01FD6975 */) => default; // 0x00000001825DEDB0-0x00000001825DF6F0
	}
}

namespace Beyond.Reflection.StructSizeGen
{
	public struct FStructSize0 // TypeDefIndex: 54987
	{
	}

	public struct FStructSize1 // TypeDefIndex: 54988
	{
		// Fields
		public byte b0; // 0x00
	}

	public struct FStructSize2 // TypeDefIndex: 54989
	{
		// Fields
		public short s0; // 0x00
	}

	public struct FStructSize3 // TypeDefIndex: 54990
	{
		// Fields
		public short s0; // 0x00
		public byte b0; // 0x02
	}

	public struct FStructSize4 // TypeDefIndex: 54991
	{
		// Fields
		public int i0; // 0x00
	}

	public struct FStructSize5 // TypeDefIndex: 54992
	{
		// Fields
		public int i0; // 0x00
		public byte b0; // 0x04
	}

	public struct FStructSize8 // TypeDefIndex: 54993
	{
		// Fields
		public long l0; // 0x00
	}

	public struct FStructSize12 // TypeDefIndex: 54994
	{
		// Fields
		public long l0; // 0x00
		public int i0; // 0x08
	}

	public struct FStructSize16 // TypeDefIndex: 54995
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
	}

	public struct FStructSize18 // TypeDefIndex: 54996
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public short s0; // 0x10
	}

	public struct FStructSize20 // TypeDefIndex: 54997
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public int i0; // 0x10
	}

	public struct FStructSize24 // TypeDefIndex: 54998
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
	}

	public struct FStructSize28 // TypeDefIndex: 54999
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public int i0; // 0x18
	}

	public struct FStructSize32 // TypeDefIndex: 55000
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
	}

	public struct FStructSize34 // TypeDefIndex: 55001
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public short s0; // 0x20
	}

	public struct FStructSize36 // TypeDefIndex: 55002
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public int i0; // 0x20
	}

	public struct FStructSize40 // TypeDefIndex: 55003
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
	}

	public struct FStructSize44 // TypeDefIndex: 55004
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public int i0; // 0x28
	}

	public struct FStructSize48 // TypeDefIndex: 55005
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
	}

	public struct FStructSize52 // TypeDefIndex: 55006
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

	public struct FStructSize56 // TypeDefIndex: 55007
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

	public struct FStructSize60 // TypeDefIndex: 55008
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

	public struct FStructSize64 // TypeDefIndex: 55009
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

	public struct FStructSize68 // TypeDefIndex: 55010
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

	public struct FStructSize72 // TypeDefIndex: 55011
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

	public struct FStructSize76 // TypeDefIndex: 55012
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

	public struct FStructSize80 // TypeDefIndex: 55013
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

	public struct FStructSize84 // TypeDefIndex: 55014
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

	public struct FStructSize88 // TypeDefIndex: 55015
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

	public struct FStructSize92 // TypeDefIndex: 55016
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

	public struct FStructSize96 // TypeDefIndex: 55017
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

	public struct FStructSize104 // TypeDefIndex: 55018
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

	public struct FStructSize108 // TypeDefIndex: 55019
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

	public struct FStructSize112 // TypeDefIndex: 55020
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

	public struct FStructSize116 // TypeDefIndex: 55021
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

	public struct FStructSize120 // TypeDefIndex: 55022
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

	public struct FStructSize124 // TypeDefIndex: 55023
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

	public struct FStructSize128 // TypeDefIndex: 55024
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

	public struct FStructSize136 // TypeDefIndex: 55025
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

	public struct FStructSize140 // TypeDefIndex: 55026
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

	public struct FStructSize144 // TypeDefIndex: 55027
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

	public struct FStructSize148 // TypeDefIndex: 55028
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

	public struct FStructSize152 // TypeDefIndex: 55029
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

	public struct FStructSize160 // TypeDefIndex: 55030
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

	public struct FStructSize168 // TypeDefIndex: 55031
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

	public struct FStructSize172 // TypeDefIndex: 55032
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

	public struct FStructSize176 // TypeDefIndex: 55033
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

	public struct FStructSize180 // TypeDefIndex: 55034
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

	public struct FStructSize184 // TypeDefIndex: 55035
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

	public struct FStructSize192 // TypeDefIndex: 55036
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

	public struct FStructSize196 // TypeDefIndex: 55037
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

	public struct FStructSize200 // TypeDefIndex: 55038
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

	public struct FStructSize208 // TypeDefIndex: 55039
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

	public struct FStructSize216 // TypeDefIndex: 55040
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

	public struct FStructSize220 // TypeDefIndex: 55041
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

	public struct FStructSize224 // TypeDefIndex: 55042
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

	public struct FStructSize232 // TypeDefIndex: 55043
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

	public struct FStructSize240 // TypeDefIndex: 55044
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

	public struct FStructSize256 // TypeDefIndex: 55045
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
	public enum ELuaMultithreadingGCState // TypeDefIndex: 55046
	{
		MinorGC = 0,
		MajorGC = 1
	}

	public class OnGCEndEvent : UnityEvent // TypeDefIndex: 55047
	{
		// Constructors
		public OnGCEndEvent() {} // 0x0000000184271C98-0x0000000184271CA0
	}

	public class LuaMultithreadingGC // TypeDefIndex: 55052
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
		public struct StartLuaGC // TypeDefIndex: 55048
		{
		}
	
		public struct WaitLuaGC // TypeDefIndex: 55049
		{
		}
	
		public struct OnGCEnd // TypeDefIndex: 55050
		{
		}
	
		// Constructors
		public LuaMultithreadingGC() {} // Dummy constructor
		public LuaMultithreadingGC(LuaEnv luaEnv) {} // 0x0000000182E2F750-0x0000000182E2FA60
		static LuaMultithreadingGC() {} // 0x0000000183B6E710-0x0000000183B6E820
	
		// Methods
		public void StartGCAsync() {} // 0x00000001823118A0-0x0000000182311F10
		public void NormalStop() {} // 0x000000018A2A0010-0x000000018A2A00B0
		public void ForceStopAsyncGC() {} // 0x000000018A29FE54-0x000000018A29FECC
		public void MainThreadWait() {} // 0x0000000182311F10-0x00000001823120B0
		public void AddLuaAfterGCEvent(UnityAction action) {} // 0x000000018332FF20-0x000000018332FF70
		public void AddLuaAfterGCOnceEvent(UnityAction action) {} // 0x000000018A29FDCC-0x000000018A29FE54
		public void RemoveLuaAfterGCEvent(UnityAction action) {} // 0x000000018A2A00B0-0x000000018A2A0118
		private void _OnGCEnd() {} // 0x00000001823120B0-0x00000001823121D0
		private void _Init() {} // 0x0000000182D921F0-0x0000000182D92940
		private void _Dispose() {} // 0x000000018A2A0118-0x000000018A2A05E8
		private static int _FindLoopSystemIndex(PlayerLoopSystem[] playerLoopList, string typeName) => default; // 0x0000000182D94E40-0x0000000182D94EF0
		[AOT.MonoPInvokeCallback(typeof(XLua.lua_Hook))]
		public static int LuaHook(IntPtr L, ref lua_debug ar) => default; // 0x000000018A29FECC-0x000000018A2A0010
		private void _UpdateOldHook() {} // 0x000000018A2A05E8-0x000000018A2A07CC
		private bool _DoLock() => default; // 0x0000000182E311E0-0x0000000182E31220
		private bool _DoGc(int work = 0 /* Metadata: 0x01FD6978 */) => default; // 0x0000000182E324D0-0x0000000182E325B0
		private void _GCMethodWrapper() {} // 0x0000000182E30850-0x0000000182E30B50
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 55217
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05E90-0x0000000183D05F00
	
		// Methods
		public System.Type __Gen_Wrap_0(object P0) => default; // 0x000000018A2AD408-0x000000018A2AD4E4
		public void __Gen_Wrap_1(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
		public List<MethodParamItem> __Gen_Wrap_2(object P0, bool P1, bool P2) => default; // 0x000000018A2ADB60-0x000000018A2ADC74
		public string __Gen_Wrap_3(object P0, bool P1, bool P2, bool P3) => default; // 0x000000018A2ADC74-0x000000018A2ADD9C
		public void __Gen_Wrap_4(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public bool __Gen_Wrap_5(PlayerLoopSystem P0) => default; // 0x000000018A2ADD9C-0x000000018A2ADEA0
		public int __Gen_Wrap_6(object P0, object P1) => default; // 0x0000000185152714-0x0000000185152800
		public int __Gen_Wrap_7(IntPtr P0, ref lua_debug P1) => default; // 0x000000018A2ADEA0-0x000000018A2AE00C
		public bool __Gen_Wrap_8(object P0) => default; // 0x000000018514EF5C-0x000000018514F02C
		public bool __Gen_Wrap_9(object P0, int P1) => default; // 0x000000018548C780-0x000000018548C86C
		public string __Gen_Wrap_10() => default; // 0x000000018A2AD4E4-0x000000018A2AD59C
		public void __Gen_Wrap_11(Span<byte> P0, out int P1) {
			P1 = default;
		} // 0x000000018A2AD59C-0x000000018A2AD6C0
		public byte[] __Gen_Wrap_12(object P0) => default; // 0x000000018A2AD6C0-0x000000018A2AD79C
		public string __Gen_Wrap_13(object P0) => default; // 0x000000018A2AD79C-0x000000018A2AD878
		public IntPtr __Gen_Wrap_14(IntPtr P0, int P1, out int P2) {
			P2 = default;
			return default;
		} // 0x000000018A2AD878-0x000000018A2AD990
		public LuaGenericDelegateCaller.LuaGenericDelegateCall __Gen_Wrap_15(object P0) => default; // 0x000000018A2AD990-0x000000018A2ADA6C
		public int __Gen_Wrap_16(IntPtr P0, object P1, object P2) => default; // 0x000000018A2ADA6C-0x000000018A2ADB60
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 55218
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018A2AE00C-0x000000018A2AE0A0
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 55219
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001842741D0-0x0000000184274234
		public static bool IsPatched(int id) => default; // 0x00000001823121D0-0x0000000182312240
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018A2B5954-0x000000018A2B5A20
		public object CreateWrapper(int id) => default; // 0x000000018A2B5A20-0x000000018A2B5A98
		public object InitWrapperArray(int len) => default; // 0x000000018A2B5A98-0x000000018A2B5B24
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018A2B58B0-0x000000018A2B5954
	}

	public enum IDMAP0 // TypeDefIndex: 55220
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

namespace Security
{
	public sealed class XXTEA // TypeDefIndex: 54984
	{
		// Fields
		private static readonly UTF8Encoding utf8; // 0x00
		private const uint delta = 2654435769; // Metadata: 0x01FD696C
	
		// Constructors
		private XXTEA() {} // 0x000000018350B670-0x000000018350B680
		static XXTEA() {} // 0x000000018A2A6178-0x000000018A2A61F4
	
		// Methods
		private static uint MX(uint sum, uint y, uint z, int p, uint e, uint[] k) => default; // 0x000000018A2A59C0-0x000000018A2A5A64
		public static byte[] Encrypt(byte[] data, byte[] key) => default; // 0x000000018A2A5760-0x000000018A2A57FC
		public static byte[] Encrypt(string data, byte[] key) => default; // 0x000000018A2A5484-0x000000018A2A5500
		public static byte[] Encrypt(byte[] data, string key) => default; // 0x000000018A2A57FC-0x000000018A2A5878
		public static byte[] Encrypt(string data, string key) => default; // 0x000000018A2A5500-0x000000018A2A55A0
		public static string EncryptToBase64String(byte[] data, byte[] key) => default; // 0x000000018A2A5394-0x000000018A2A540C
		public static string EncryptToBase64String(string data, byte[] key) => default; // 0x000000018A2A540C-0x000000018A2A5484
		public static string EncryptToBase64String(byte[] data, string key) => default; // 0x000000018A2A52A4-0x000000018A2A531C
		public static string EncryptToBase64String(string data, string key) => default; // 0x000000018A2A531C-0x000000018A2A5394
		public static byte[] Decrypt(byte[] data, byte[] key) => default; // 0x000000018A2A5184-0x000000018A2A5220
		private static int _Decrypt(Span<byte> data, Span<byte> key, Span<byte> result) => default; // 0x000000018A2A5EC8-0x000000018A2A6178
		public static byte[] Decrypt(byte[] data, string key) => default; // 0x000000018A2A5108-0x000000018A2A5184
		public static int Decrypt(Span<byte> data, Span<byte> key, Span<byte> result) => default; // 0x000000018A2A5220-0x000000018A2A52A4
		public static byte[] DecryptBase64String(string data, byte[] key) => default; // 0x000000018A2A4B90-0x000000018A2A4C08
		public static byte[] DecryptBase64String(string data, string key) => default; // 0x000000018A2A4C08-0x000000018A2A4C80
		public static string DecryptToString(byte[] data, byte[] key) => default; // 0x000000018A2A4E5C-0x000000018A2A4EE0
		public static string DecryptToString(byte[] data, string key) => default; // 0x000000018A2A4EE0-0x000000018A2A4F64
		public static string DecryptBase64StringToString(string data, byte[] key) => default; // 0x000000018A2A4B0C-0x000000018A2A4B90
		public static string DecryptBase64StringToString(string data, string key) => default; // 0x000000018A2A4A88-0x000000018A2A4B0C
		private static uint[] Encrypt(uint[] v, uint[] k) => default; // 0x000000018A2A55A0-0x000000018A2A5760
		private static uint[] Decrypt(uint[] v, uint[] k) => default; // 0x000000018A2A4F64-0x000000018A2A5108
		private static void DecryptInPlace(Span<uint> v, Span<uint> k) {} // 0x000000018A2A4C80-0x000000018A2A4E5C
		private static uint MxForSpan(uint sum, uint y, uint z, int p, uint e, Span<uint> k) => default; // 0x000000018A2A5A64-0x000000018A2A5AC8
		private static byte[] FixKey(byte[] key) => default; // 0x000000018A2A5928-0x000000018A2A59C0
		private static void FixKey(Span<byte> key, Span<byte> fixedkey) {} // 0x000000018A2A5878-0x000000018A2A5928
		private static uint[] ToUInt32Array(byte[] data, bool includeLength) => default; // 0x000000018A2A5DD8-0x000000018A2A5EC8
		private static void ToUInt32Array(Span<byte> data, bool includeLength, Span<uint> result) {} // 0x000000018A2A5CE8-0x000000018A2A5DD8
		private static byte[] ToByteArray(uint[] data, bool includeLength) => default; // 0x000000018A2A5AC8-0x000000018A2A5BA4
		private static void ToByteSpanFromUInt32(Span<uint> data, bool includeLength, Span<byte> result, out int len) {
			len = default;
		} // 0x000000018A2A5BA4-0x000000018A2A5CE8
	}
}

namespace XLua
{
	public class CopyByValue // TypeDefIndex: 55056
	{
		// Fields
		public static CopyByValue Instance; // 0x00
	
		// Constructors
		public CopyByValue() {} // 0x000000018350B670-0x000000018350B680
		static CopyByValue() {} // 0x0000000183D1B710-0x0000000183D1B770
	
		// Methods
		public bool Pack(IntPtr buff, int offset, byte field) => default; // 0x000000018A29AA5C-0x000000018A29AAC0
		public bool UnPack(IntPtr buff, int offset, out byte field) {
			field = default;
			return default;
		} // 0x000000018A29B1BC-0x000000018A29B220
		public bool Pack(IntPtr buff, int offset, sbyte field) => default; // 0x000000018A29A998-0x000000018A29A9FC
		public bool UnPack(IntPtr buff, int offset, out sbyte field) {
			field = default;
			return default;
		} // 0x000000018A29B14C-0x000000018A29B1BC
		public bool Pack(IntPtr buff, int offset, short field) => default; // 0x000000018A29AAC0-0x000000018A29AB24
		public bool UnPack(IntPtr buff, int offset, out short field) {
			field = default;
			return default;
		} // 0x000000018A29B0E8-0x000000018A29B14C
		public bool Pack(IntPtr buff, int offset, ushort field) => default; // 0x000000018A29ACB4-0x000000018A29AD18
		public bool UnPack(IntPtr buff, int offset, out ushort field) {
			field = default;
			return default;
		} // 0x000000018A29ADE0-0x000000018A29AE60
		public bool Pack(IntPtr buff, int offset, int field) => default; // 0x0000000182ED8350-0x0000000182ED83D0
		public bool UnPack(IntPtr buff, int offset, out int field) {
			field = default;
			return default;
		} // 0x0000000182EDEE70-0x0000000182EDEEF0
		public bool Pack(IntPtr buff, int offset, uint field) => default; // 0x000000018A29A9FC-0x000000018A29AA5C
		public bool UnPack(IntPtr buff, int offset, out uint field) {
			field = default;
			return default;
		} // 0x000000018A29AEC4-0x000000018A29AF34
		public bool Pack(IntPtr buff, int offset, long field) => default; // 0x000000018A29AC50-0x000000018A29ACB4
		public bool UnPack(IntPtr buff, int offset, out long field) {
			field = default;
			return default;
		} // 0x000000018A29AD7C-0x000000018A29ADE0
		public bool Pack(IntPtr buff, int offset, ulong field) => default; // 0x000000018A29ABEC-0x000000018A29AC50
		public bool UnPack(IntPtr buff, int offset, out ulong field) {
			field = default;
			return default;
		} // 0x000000018A29B074-0x000000018A29B0E8
		public bool Pack(IntPtr buff, int offset, float field) => default; // 0x000000018A29AB88-0x000000018A29ABEC
		public bool UnPack(IntPtr buff, int offset, out float field) {
			field = default;
			return default;
		} // 0x000000018A29AE60-0x000000018A29AEC4
		public bool Pack(IntPtr buff, int offset, double field) => default; // 0x000000018A29AB24-0x000000018A29AB88
		public bool UnPack(IntPtr buff, int offset, out double field) {
			field = default;
			return default;
		} // 0x000000018A29B010-0x000000018A29B074
		public bool Pack(IntPtr buff, int offset, decimal field) => default; // 0x000000018A29AD18-0x000000018A29AD7C
		public bool UnPack(IntPtr buff, int offset, out decimal field) {
			field = default;
			return default;
		} // 0x000000018A29AF34-0x000000018A29B010
		public bool IsStruct(System.Type type) => default; // 0x00000001824DAF20-0x00000001824DAF70
	}

	public abstract class DelegateBridgeBase : LuaBase // TypeDefIndex: 55057
	{
		// Fields
		private System.Type firstKey; // 0x20
		private Delegate firstValue; // 0x28
		private Dictionary<System.Type, Delegate> bindTo; // 0x30
		public int errorFuncRef; // 0x38
	
		// Properties
		public bool IsDispose { get; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		protected DelegateBridgeBase() {} // Dummy constructor
		public DelegateBridgeBase(int reference, LuaEnv luaenv) {} // 0x00000001831EDA00-0x00000001831EDA40
	
		// Methods
		public bool TryGetDelegate(System.Type key, out Delegate value) {
			value = default;
			return default;
		} // 0x000000018346C840-0x000000018346C8E0
		public void AddDelegate(System.Type key, Delegate value) {} // 0x000000018260FFA0-0x00000001826100A0
		public virtual Delegate GetDelegateByType(System.Type type) => default; // 0x0000000181002730-0x0000000181002740
	}

	public static class HotfixDelegateBridge // TypeDefIndex: 55058
	{
		// Methods
		public static bool xlua_get_hotfix_flag(int idx) => default; // 0x000000018A29B418-0x000000018A29B4A8
		public static DelegateBridge Get(int idx) => default; // 0x000000018A29B220-0x000000018A29B284
		public static void Set(int idx, DelegateBridge val) {} // 0x000000018A29B284-0x000000018A29B418
	}

	public class DelegateBridge : DelegateBridgeBase // TypeDefIndex: 55063
	{
		// Fields
		internal static DelegateBridge[] DelegateBridgeList; // 0x00
		public static bool Gen_Flag; // 0x08
		public static Func<DelegateBridge, System.Type, Delegate> GetDelegateTypeDelegate; // 0x10
	
		// Constructors
		public DelegateBridge() {} // Dummy constructor
		public DelegateBridge(int reference, LuaEnv luaenv) {} // 0x0000000184270B44-0x0000000184270B4C
		static DelegateBridge() {} // 0x0000000183CC53A0-0x0000000183CC5450
	
		// Methods
		public void PCall(IntPtr L, int nArgs, int nResults, int errFunc) {} // 0x00000001825D6B30-0x00000001825D6C00
		public override Delegate GetDelegateByType(System.Type type) => default; // 0x0000000183287F00-0x0000000183287F80
		public void Action() {} // 0x00000001825D3FF0-0x00000001825D4130
		public void Action<T1>(T1 p1) {}
		private void ActionAfterGC<T1>(T1 p1) {}
		public void Action<T1, T2>(T1 p1, T2 p2) {}
		private void ActionAfterGC<T1, T2>(T1 p1, T2 p2) {}
		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3) {}
		private void ActionAfterGC<T1, T2, T3>(T1 p1, T2 p2, T3 p3) {}
		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4) {}
		private void ActionAfterGC<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4) {}
		public TResult Func<TResult>() => default;
		public TResult Func<T1, TResult>(T1 p1) => default;
		public TResult Func<T1, T2, TResult>(T1 p1, T2 p2) => default;
		public TResult Func<T1, T2, T3, TResult>(T1 p1, T2 p2, T3 p3) => default;
		public TResult Func<T1, T2, T3, T4, TResult>(T1 p1, T2 p2, T3 p3, T4 p4) => default;
	}

	public enum GenFlag // TypeDefIndex: 55064
	{
		No = 0,
		GCOptimize = 1
	}

	public class LuaCallCSharpAttribute : Attribute // TypeDefIndex: 55065
	{
		// Fields
		private GenFlag flag; // 0x10
	
		// Properties
		public GenFlag Flag { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public LuaCallCSharpAttribute() {} // Dummy constructor
		public LuaCallCSharpAttribute(GenFlag flag = GenFlag.No /* Metadata: 0x01FD699B */) {} // 0x00000001810410F0-0x0000000181041100
	}

	public class CSharpCallLuaAttribute : Attribute // TypeDefIndex: 55066
	{
		// Constructors
		public CSharpCallLuaAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public class BlackListAttribute : Attribute // TypeDefIndex: 55067
	{
		// Constructors
		public BlackListAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Flags]
	public enum OptimizeFlag // TypeDefIndex: 55068
	{
		Default = 0,
		PackAsTable = 1,
		Custom = 2
	}

	public class GCOptimizeAttribute : Attribute // TypeDefIndex: 55069
	{
		// Fields
		private OptimizeFlag flag; // 0x10
	
		// Properties
		public OptimizeFlag Flag { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public GCOptimizeAttribute() {} // Dummy constructor
		public GCOptimizeAttribute(OptimizeFlag flag = OptimizeFlag.Default /* Metadata: 0x01FD699F */) {} // 0x00000001810410F0-0x0000000181041100
	}

	public class ReflectionUseAttribute : Attribute // TypeDefIndex: 55070
	{
		// Constructors
		public ReflectionUseAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public class DoNotGenAttribute : Attribute // TypeDefIndex: 55071
	{
		// Constructors
		public DoNotGenAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public class AdditionalPropertiesAttribute : Attribute // TypeDefIndex: 55072
	{
		// Constructors
		public AdditionalPropertiesAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[Flags]
	public enum HotfixFlag // TypeDefIndex: 55073
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

	public class HotfixAttribute : Attribute // TypeDefIndex: 55074
	{
		// Fields
		private HotfixFlag flag; // 0x10
	
		// Properties
		public HotfixFlag Flag { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public HotfixAttribute() {} // Dummy constructor
		public HotfixAttribute(HotfixFlag e = HotfixFlag.Stateless /* Metadata: 0x01FD69AD */) {} // 0x00000001810410F0-0x0000000181041100
	}

	[AttributeUsage(AttributeTargets.Delegate)]
	internal class HotfixDelegateAttribute : Attribute // TypeDefIndex: 55075
	{
		// Constructors
		public HotfixDelegateAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class SysGenConfig // TypeDefIndex: 55076
	{
		// Properties
		[GCOptimize(OptimizeFlag.Default)]
		private static List<System.Type> GCOptimize { get; } // 0x000000018A2A3D18-0x000000018A2A3F0C 
		[AdditionalProperties]
		private static Dictionary<System.Type, List<string>> AdditionalProperties { get; } // 0x000000018A2A3A94-0x000000018A2A3D18 
	}

	public class InternalGlobals // TypeDefIndex: 55079
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
		public delegate bool TryArrayGet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int index); // TypeDefIndex: 55077; 0x000000018101FB20-0x000000018101FB40
	
		public delegate bool TryArraySet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx); // TypeDefIndex: 55078; 0x00000001810198A0-0x00000001810198C0
	
		// Constructors
		public InternalGlobals() {} // 0x000000018350B670-0x000000018350B680
		static InternalGlobals() {} // 0x00000001837E58E0-0x00000001837E5E00
	}

	public abstract class LuaBase : IDisposable // TypeDefIndex: 55080
	{
		// Fields
		public bool disposed; // 0x10
		public readonly int luaReference; // 0x14
		public readonly LuaEnv luaEnv; // 0x18
	
		// Constructors
		protected LuaBase() {} // Dummy constructor
		public LuaBase(int reference, LuaEnv luaenv) {} // 0x0000000184270B20-0x0000000184270B30
	
		// Methods
		~LuaBase() {} // 0x00000001833E0980-0x00000001833E09D0
		public void Dispose() {} // 0x000000018260E1B0-0x000000018260E210
		public virtual void Dispose(bool disposeManagedResources) {} // 0x000000018260E210-0x000000018260E300
		public override bool Equals(object o) => default; // 0x000000018A29B614-0x000000018A29B74C
		public override int GetHashCode() => default; // 0x000000018A29B74C-0x000000018A29B800
		public virtual void push(IntPtr L) {} // 0x000000018A29B800-0x000000018A29B854
	}

	public struct lua_debug // TypeDefIndex: 55081
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

	public struct lua_state // TypeDefIndex: 55082
	{
		// Fields
		public IntPtr ptr; // 0x00
		public byte byte1; // 0x08
		public byte byte2; // 0x09
		public byte status; // 0x0A
		public byte allowhook; // 0x0B
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int lua_Hook(IntPtr L, ref lua_debug ar); // TypeDefIndex: 55083; 0x0000000181165340-0x0000000181165350

	public static class LuaDeadLoopCheck // TypeDefIndex: 55085
	{
		// Fields
		private static Thread s_checkThread; // 0x00
		private static Stack<Stopwatch> s_costStack; // 0x08
		private static SpinLock s_lockObj; // 0x10
		private static bool s_isCheck; // 0x14
		private static IntPtr L; // 0x18
		private static ObjectPool<Stopwatch> s_stopwatchPool; // 0x20
		private static int s_allowHookOffset; // 0x28
	
		// Methods
		public static void EnableCheck(IntPtr L) {} // 0x000000018A29C9B8-0x000000018A29EF8C
		[AOT.MonoPInvokeCallback(typeof(XLua.lua_Hook))]
		public static int LuaHook(IntPtr L, ref lua_debug ar) => default; // 0x000000018A29EF8C-0x000000018A29F2BC
		public static void DisableCheck(IntPtr L) {} // 0x000000018A29C980-0x000000018A29C9B8
		public static void PushTime() {} // 0x00000001825D7160-0x00000001825D72A0
		public static void PopTime() {} // 0x000000018303D500-0x000000018303D660
		public static void CheckDeadLoop() {} // 0x000000018A29C718-0x000000018A29C980
	}

	public interface ILoadLuaProxy // TypeDefIndex: 55086
	{
		// Methods
		byte[] LoadLua(string name);
	}

	public class LoadLuaProxyModule // TypeDefIndex: 55087
	{
		// Fields
		private static ILoadLuaProxy s_loadLuaProxy; // 0x00
	
		// Constructors
		public LoadLuaProxyModule() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void RegisterProxy(ILoadLuaProxy loadLuaProxy) {} // 0x000000018A29B4E0-0x000000018A29B530
		public static ILoadLuaProxy GetLoadLuaProxy() => default; // 0x000000018A29B4A8-0x000000018A29B4E0
	}

	public class LuaEnv : IDisposable // TypeDefIndex: 55090
	{
		// Fields
		public const string CSHARP_NAMESPACE = "xlua_csharp_namespace"; // Metadata: 0x01FD69D3
		public const string MAIN_SHREAD = "xlua_main_thread"; // Metadata: 0x01FD69E9
		private LuaMultithreadingGC m_luaMultithreadingGC; // 0x10
		public static bool ENABLE_MULTITHREAD_GC; // 0x00
		public bool isQuittingApplication; // 0x18
		public IntPtr rawL; // 0x20
		private LuaTable _G; // 0x28
		public ObjectTranslator translator; // 0x30
		public int errorFuncRef; // 0x38
		private const int LIB_VERSION_EXPECT = 105; // Metadata: 0x01FD69FA
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
		public IntPtr L { get => default; } // 0x0000000182615690-0x00000001826156B0 
		public LuaTable Global { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public int GcPause { get => default; set {} } // 0x000000018A29FA14-0x000000018A29FA94 0x000000018A29FB14-0x000000018A29FB74
		public int GcStepmul { get => default; set {} } // 0x000000018A29FA94-0x000000018A29FB14 0x000000018A29FB74-0x000000018A29FBD4
		public int Memroy { get => default; } // 0x0000000182615620-0x0000000182615690 
	
		// Nested types
		internal struct GCAction // TypeDefIndex: 55088
		{
			// Fields
			public int Reference; // 0x00
			public bool IsDelegate; // 0x04
		}
	
		public delegate byte[] CustomLoader(ref string filepath); // TypeDefIndex: 55089; 0x000000018102B410-0x000000018102B420
	
		// Constructors
		public LuaEnv() {} // 0x0000000182D3CE70-0x0000000182D3DB00
		static LuaEnv() {} // 0x0000000183D1D570-0x0000000183D1D5E0
	
		// Methods
		public bool IsEnableMultithreadGC() => default; // 0x00000001829A6FD0-0x00000001829A7040
		public bool IsLuaGCing() => default; // 0x00000001825D4E00-0x00000001825D4E20
		public bool AddLuaEventAfterGCDo(UnityAction action) => default; // 0x000000018332FEF0-0x000000018332FF20
		public void RemoveLuaEventAfterGCDo(UnityAction action) {} // 0x000000018A29F814-0x000000018A29F828
		public void AddOnceLuaEventAfterGCDo(UnityAction action) {} // 0x000000018A29F2BC-0x000000018A29F2FC
		public void CriticalLuaCallWaitLuaGC() {} // 0x000000018A29F31C-0x000000018A29F378
		public void MainThreadWait() {} // 0x000000018A29F700-0x000000018A29F714
		public void StopMultiGC() {} // 0x000000018A29F8CC-0x000000018A29F8FC
		public static void AddIniter(Action<LuaEnv, ObjectTranslator> initer) {} // 0x00000001838674A0-0x00000001838675F0
		public T LoadString<T>(byte[] chunk, string chunkName = "chunk" /* Metadata: 0x01FD69AE */, LuaTable env = null) => default;
		public T LoadString<T>(string chunk, string chunkName = "chunk" /* Metadata: 0x01FD69B4 */, LuaTable env = null) => default;
		public LuaFunction LoadString(string chunk, string chunkName = "chunk" /* Metadata: 0x01FD69BA */, LuaTable env = null) => default; // 0x000000018A29F690-0x000000018A29F700
		public object[] DoString(byte[] chunk, string chunkName = "chunk" /* Metadata: 0x01FD69C0 */, LuaTable env = null) => default; // 0x0000000182D3C090-0x0000000182D3C1E0
		public object[] DoString(string chunk, string chunkName = "chunk" /* Metadata: 0x01FD69C6 */, LuaTable env = null) => default; // 0x000000018A29F560-0x000000018A29F5D0
		public object[] DoFile(string luaFile, string chunkName = "chunk" /* Metadata: 0x01FD69CC */, LuaTable env = null) => default; // 0x0000000182D3BF50-0x0000000182D3C020
		public object[] DoFile(string luaFile, LuaTable env = null) => default; // 0x000000018427332C-0x000000018427334C
		public object[] CallGlobalFunction(string funcName) => default; // 0x0000000183820DC0-0x0000000183820E40
		public object[] CallGlobalFunction<T0>(string funcName, T0 param0) => default;
		public void SetGlobalTable<K, V>(K key, V value) {}
		public V GetGlobalTable<K, V>(K key) => default;
		public void InitCacheString() {} // 0x0000000182D3BB90-0x0000000182D3BDE0
		public string TryGetLuaString(IntPtr p) => default; // 0x0000000182EEA410-0x0000000182EEA550
		public void RefString(IntPtr L, IntPtr strPoint, int index, string ss) {} // 0x0000000182611210-0x00000001826113B0
		public void ReleaseStringCache(bool dispose = true /* Metadata: 0x01FD69D2 */) {} // 0x0000000182D3BA80-0x0000000182D3BB90
		public void AutoFreeStringCache() {} // 0x0000000182BE3A40-0x0000000182BE3A60
		private void AddSearcher(lua_CSFunction searcher, int index) {} // 0x0000000182D3DB00-0x0000000182D3DCA0
		public void Alias(System.Type type, string alias) {} // 0x000000018A29F2FC-0x000000018A29F31C
		private static bool ObjectValidCheck(object obj) => default; // 0x0000000182D37180-0x0000000182D37290
		public void ClearAllUserdata() {} // 0x00000001830CDBD0-0x00000001830CDC10
		public void CleanTick() {} // 0x0000000182BE3AD0-0x0000000182BE3E50
		public void GC() {} // 0x000000018A29F624-0x000000018A29F62C
		public LuaTable NewTable() => default; // 0x000000018A29F714-0x000000018A29F814
		public void WaitForGCComplete() {} // 0x000000018A29FA0C-0x000000018A29FA14
		public void Dispose() {} // 0x000000018A29F4D4-0x000000018A29F560
		public virtual void Dispose(bool dispose) {} // 0x000000018A29F378-0x000000018A29F4D4
		public void ThrowExceptionFromError(int oldTop) {} // 0x000000018A29F8FC-0x000000018A29FA0C
		internal void equeueGCAction(GCAction action) {} // 0x000000018333D8F0-0x000000018333DC90
		public void AddLoader(CustomLoader loader) {} // 0x000000018332FC60-0x000000018332FCC0
		public void AddBuildin(string name, lua_CSFunction initer) {} // 0x0000000182D3CC90-0x0000000182D3CD30
		public void FullGc() {} // 0x000000018A29F5D0-0x000000018A29F624
		public void StopGc() {} // 0x000000018A29F87C-0x000000018A29F8CC
		public void RestartGc() {} // 0x000000018A29F828-0x000000018A29F87C
		public bool GcStep(int data) => default; // 0x000000018A29F62C-0x000000018A29F690
	}

	[Serializable]
	public class LuaException : Exception // TypeDefIndex: 55091
	{
		// Constructors
		public LuaException() {} // Dummy constructor
		public LuaException(string message) {} // 0x000000018A29FBD4-0x000000018A29FC30
	}

	public class LuaFunction : LuaBase // TypeDefIndex: 55094
	{
		// Constructors
		public LuaFunction() {} // Dummy constructor
		public LuaFunction(int reference, LuaEnv luaenv) {} // 0x0000000184270B20-0x0000000184270B30
	
		// Methods
		public void Action<T>(T a) {}
		private void ActionAfterGC<T>(T a) {}
		public TResult Func<T, TResult>(T a) => default;
		public void Action<T1, T2>(T1 a1, T2 a2) {}
		private void ActionAfterGC<T1, T2>(T1 a1, T2 a2) {}
		public TResult Func<T1, T2, TResult>(T1 a1, T2 a2) => default;
		public object[] Call(object[] args, System.Type[] returnTypes) => default; // 0x00000001825D4E20-0x00000001825D5000
		public object[] Call(params object[] args) => default; // 0x000000018427099C-0x00000001842709A8
		public T Cast<T>() => default;
		public void SetEnv(LuaTable env) {} // 0x000000018A29FC30-0x000000018A29FCE8
		public override void push(IntPtr L) {} // 0x0000000183D21B00-0x0000000183D21B60
		public override string ToString() => default; // 0x000000018A29FCE8-0x000000018A29FD30
	}

	public class LuaTable : LuaBase // TypeDefIndex: 55097
	{
		// Properties
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[string field] { get => default; set {} } // 0x000000018A2A0954-0x000000018A2A099C 0x000000018A2A0AD0-0x000000018A2A0B28
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[object field] { get => default; set {} } // 0x000000018A2A099C-0x000000018A2A09E4 0x000000018A2A0A78-0x000000018A2A0AD0
		public int Length { get => default; } // 0x000000018A2A09E4-0x000000018A2A0A78 
	
		// Constructors
		public LuaTable() {} // Dummy constructor
		public LuaTable(int reference, LuaEnv luaenv) {} // 0x0000000184270B20-0x0000000184270B30
	
		// Methods
		public void Get<TKey, TValue>(TKey key, out ref TValue value) {
			value = default;
		}
		public bool ContainsKey<TKey>(TKey key) => default;
		public void Set<TKey, TValue>(TKey key, TValue value) {}
		public T GetInPath<T>(string path) => default;
		public void SetInPath<T>(string path, T val) {}
		public void ForEach<TKey, TValue>(Action<TKey, TValue> action) {}
		[IteratorStateMachine(typeof(_GetKeys_d__15))]
		public IEnumerable GetKeys() => default; // 0x000000018A2A07CC-0x000000018A2A083C
		[IteratorStateMachine(typeof(_GetKeys_d__16<T>))]
		public IEnumerable<T> GetKeys<T>() => default;
		public T Get<T>(object key) => default;
		public TValue Get<TKey, TValue>(TKey key) => default;
		public TValue Get<TValue>(string key) => default;
		public void SetMetaTable(LuaTable metaTable) {} // 0x000000018A2A083C-0x000000018A2A090C
		public T Cast<T>() => default;
		public override void push(IntPtr L) {} // 0x000000018341D660-0x000000018341D6C0
		public override string ToString() => default; // 0x000000018A2A090C-0x000000018A2A0954
		public ObjectTranslator GetTranslator() => default; // 0x000000018260DFF0-0x000000018260E090
	}

	public interface IOverloadMethodWrap // TypeDefIndex: 55098
	{
		// Properties
		bool InitedForDelegateCall { get; }
		bool HasDefalutValue { get; }
	
		// Methods
		int Call(IntPtr L, ObjectTranslator translator);
		bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x01FD69FC */);
	}

	public class OverloadMethodWrapBase // TypeDefIndex: 55099
	{
		// Fields
		protected ObjectTranslator translator; // 0x10
		protected MethodBase method; // 0x18
	
		// Constructors
		public OverloadMethodWrapBase() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static IOverloadMethodWrap CreateMethodWrap(ObjectTranslator translator, MethodBase method, System.Type target) => default; // 0x000000018286D9C0-0x000000018286DAB0
	}

	public class OverloadMethodWrapForDelegate : OverloadMethodWrapBase, IOverloadMethodWrap // TypeDefIndex: 55100
	{
		// Fields
		private List<System.Type> castTypes; // 0x20
		private Delegate @delegate; // 0x28
		private LuaGenericDelegateCaller.LuaGenericDelegateCall caller; // 0x30
	
		// Properties
		public bool InitedForDelegateCall { get => default; } // 0x0000000183178FA0-0x0000000183178FB0 
		public List<System.Type> CastTypes { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public int OptionParamCount { get; private set; } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public object[] DefalutValue { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public bool HasDefalutValue { get; private set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
		public bool[] OutParamFlags { get; private set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
	
		// Constructors
		public OverloadMethodWrapForDelegate() {} // Dummy constructor
		public OverloadMethodWrapForDelegate(MethodInfo method) {} // 0x000000018283E4A0-0x000000018283E530
	
		// Methods
		public static OverloadMethodWrapForDelegate TryGetWrapForDelegate(MethodInfo method) => default; // 0x00000001823029E0-0x0000000182303020
		public void InitForDefaultValue() {} // 0x000000018286DAF0-0x000000018286DD10
		public int Call(IntPtr L, ObjectTranslator translator) => default; // 0x00000001826171B0-0x0000000182617880
		public bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x01FD69FD */) => default; // 0x000000018232EB60-0x000000018232EB70
	}

	public class OverloadMethodWrapForReflection : OverloadMethodWrapBase, IOverloadMethodWrap // TypeDefIndex: 55101
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
		public bool InitedForDelegateCall { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public bool HasDefalutValue { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public OverloadMethodWrapForReflection() {} // Dummy constructor
		public OverloadMethodWrapForReflection(System.Type target, MethodBase methodInfo) {} // 0x000000018286DAB0-0x000000018286DAF0
	
		// Methods
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters) {} // 0x000000018286DD10-0x000000018286E790
		public int Call(IntPtr L, ObjectTranslator translator) => default; // 0x0000000182615AA0-0x00000001826166A0
		public bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x01FD69FE */) => default; // 0x00000001826166A0-0x00000001826166D0
		public bool Check(IntPtr L) => default; // 0x0000000183044B40-0x0000000183044CE0
		public bool CheckForNoOverride(IntPtr L) => default; // 0x0000000182615890-0x0000000182615A20
	}

	public class OverloadMethodWrap // TypeDefIndex: 55102
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
	
		// Properties
		public bool InitedForDelegateCall { get => default; } // 0x0000000185ED8890-0x0000000185ED889C 
		public MethodBase Method { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public List<System.Type> CastTypes { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public int OptionParamCount { get; private set; } // 0x0000000183D4EB50-0x0000000183D4EB60 0x0000000183D4EB80-0x0000000183D4EB90
		public object[] DefalutValue { get; private set; } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000184270264-0x0000000184270278
		public bool IsInited { get; private set; } // 0x00000001811B9C10-0x00000001811B9C20 0x00000001811B9C20-0x00000001811B9C30
		public bool HasDefalutValue { get; private set; } // 0x0000000183D5AB90-0x0000000183D5ABA0 0x0000000183D5ABB0-0x0000000183D5ABC0
	
		// Constructors
		public OverloadMethodWrap() {} // Dummy constructor
		public OverloadMethodWrap(ObjectTranslator translator, System.Type targetType, MethodBase method) {} // 0x000000018A2A3A48-0x000000018A2A3A94
	
		// Methods
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters) {} // 0x000000018A2A2F84-0x000000018A2A3A48
		public void InitForDefaultValue() {} // 0x000000018A2A26B8-0x000000018A2A2984
		public void InitForDelegateCallMethod() {} // 0x000000018A2A2984-0x000000018A2A2F84
		public int Call(IntPtr L) => default; // 0x000000018A2A1EF4-0x000000018A2A26B8
		public int CallForDelegate(IntPtr L, ObjectTranslator translator) => default; // 0x000000018A2A1D7C-0x000000018A2A1EF4
	}

	public class MethodWrap // TypeDefIndex: 55103
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
		public MethodWrap(string methodName, List<MethodBase> overloads, System.Type targetType, bool forceCheck) {} // 0x00000001825E3B90-0x00000001825E3C30
	
		// Methods
		private void _InitForDelegateCall() {} // 0x0000000183178DF0-0x0000000183178FA0
		public int Call(IntPtr L) => default; // 0x0000000182616A50-0x00000001826171B0
	}

	public class MethodWrapsCache // TypeDefIndex: 55107
	{
		// Fields
		public static Dictionary<System.Type, lua_CSFunction> CodeGenConstructorMap; // 0x00
		private ObjectTranslator translator; // 0x10
		private ObjectCheckers objCheckers; // 0x18
		private ObjectCasters objCasters; // 0x20
		private Dictionary<System.Type, lua_CSFunction> constructorCache; // 0x28
		private Dictionary<System.Type, Dictionary<string, lua_CSFunction>> methodsCache; // 0x30
		private Dictionary<System.Type, lua_CSFunction> delegateCache; // 0x38
	
		// Constructors
		public MethodWrapsCache() {} // Dummy constructor
		static MethodWrapsCache() {} // 0x0000000183A24C60-0x0000000183A24CF0
		public MethodWrapsCache(ObjectTranslator translator, ObjectCheckers objCheckers, ObjectCasters objCasters) {} // 0x0000000183A24CF0-0x0000000183A24E30
	
		// Methods
		public static void AddCodeGenConstructor(System.Type type, lua_CSFunction lua_CSFunction) {} // 0x000000018A2A0B28-0x000000018A2A0C28
		public static void ClearCodeGenConstructorMap() {} // 0x000000018A2A0C28-0x000000018A2A0C8C
		public lua_CSFunction GetConstructorWrap(System.Type type) => default; // 0x00000001825E3C30-0x00000001825E4020
		public lua_CSFunction GetMethodWrap(System.Type type, string methodName) => default; // 0x000000018A2A0FE4-0x000000018A2A122C
		public lua_CSFunction GetMethodWrapInCache(System.Type type, string methodName) => default; // 0x000000018A2A0E8C-0x000000018A2A0FE4
		public lua_CSFunction GetDelegateWrap(System.Type type) => default; // 0x000000018A2A0C8C-0x000000018A2A0E8C
		public lua_CSFunction GetEventWrap(System.Type type, string eventName) => default; // 0x0000000182E50F00-0x0000000182E511D0
		public MethodWrap _GenMethodWrap(System.Type type, string methodName, IEnumerable<MemberInfo> methodBases, bool forceCheck = false /* Metadata: 0x01FD69FF */) => default; // 0x00000001825E2EF0-0x00000001825E3B20
		private static bool tryMakeGenericMethod(ref MethodBase method) => default; // 0x000000018A2A122C-0x000000018A2A1438
	}

	public delegate bool ObjectCheck(IntPtr L, int idx); // TypeDefIndex: 55108; 0x0000000181165340-0x0000000181165350

	public delegate object ObjectCast(IntPtr L, int idx, object target); // TypeDefIndex: 55109; 0x0000000181035ED0-0x0000000181035EF0

	public class ObjectCheckers // TypeDefIndex: 55112
	{
		// Fields
		private Dictionary<System.Type, ObjectCheck> checkersMap; // 0x10
		private ObjectTranslator translator; // 0x18
	
		// Constructors
		public ObjectCheckers() {} // Dummy constructor
		public ObjectCheckers(ObjectTranslator translator) {} // 0x000000018308F530-0x000000018308FE90
	
		// Methods
		private static bool objectCheck(IntPtr L, int idx) => default; // 0x000000018232EB60-0x000000018232EB70
		private bool luaTableCheck(IntPtr L, int idx) => default; // 0x000000018A2A1C9C-0x000000018A2A1D7C
		private bool numberCheck(IntPtr L, int idx) => default; // 0x0000000183271BE0-0x0000000183271C70
		private bool decimalCheck(IntPtr L, int idx) => default; // 0x000000018A2A1AE8-0x000000018A2A1B68
		private bool strCheck(IntPtr L, int idx) => default; // 0x00000001831B4870-0x00000001831B49C0
		private bool bytesCheck(IntPtr L, int idx) => default; // 0x000000018A2A1A08-0x000000018A2A1AE8
		private bool boolCheck(IntPtr L, int idx) => default; // 0x00000001832899D0-0x0000000183289A60
		private bool int64Check(IntPtr L, int idx) => default; // 0x0000000183486610-0x0000000183486680
		private bool uint64Check(IntPtr L, int idx) => default; // 0x00000001838664F0-0x0000000183866560
		private bool luaFunctionCheck(IntPtr L, int idx) => default; // 0x000000018A2A1BBC-0x000000018A2A1C9C
		private bool intptrCheck(IntPtr L, int idx) => default; // 0x000000018A2A1B68-0x000000018A2A1BBC
		private ObjectCheck genChecker(System.Type type) => default; // 0x000000018308FE90-0x0000000183090200
		public ObjectCheck genNullableChecker(ObjectCheck oc) => default; // 0x000000018308F480-0x000000018308F530
		public void AddChecker(System.Type type, ObjectCheck oc) {} // 0x0000000183090420-0x0000000183090490
		public ObjectCheck GetChecker(System.Type type) => default; // 0x0000000182614570-0x00000001826147E0
	}

	public class ObjectCasters // TypeDefIndex: 55117
	{
		// Fields
		private Dictionary<System.Type, ObjectCast> castersMap; // 0x10
		private ObjectTranslator translator; // 0x18
	
		// Constructors
		public ObjectCasters() {} // Dummy constructor
		public ObjectCasters(ObjectTranslator translator) {} // 0x0000000183658DB0-0x0000000183659760
	
		// Methods
		private static object charCaster(IntPtr L, int idx, object target) => default; // 0x000000018A2A1544-0x000000018A2A15B4
		private static object sbyteCaster(IntPtr L, int idx, object target) => default; // 0x000000018A2A1824-0x000000018A2A1894
		private static object byteCaster(IntPtr L, int idx, object target) => default; // 0x000000018A2A14D4-0x000000018A2A1544
		private static object shortCaster(IntPtr L, int idx, object target) => default; // 0x000000018A2A1894-0x000000018A2A1904
		private static object ushortCaster(IntPtr L, int idx, object target) => default; // 0x000000018A2A1904-0x000000018A2A1974
		private static object intCaster(IntPtr L, int idx, object target) => default; // 0x00000001830A8700-0x00000001830A8780
		private static object uintCaster(IntPtr L, int idx, object target) => default; // 0x00000001830A8810-0x00000001830A8890
		private static object longCaster(IntPtr L, int idx, object target) => default; // 0x00000001824D8100-0x00000001824D8180
		private static object ulongCaster(IntPtr L, int idx, object target) => default; // 0x00000001830A8890-0x00000001830A8910
		private static object getDouble(IntPtr L, int idx, object target) => default; // 0x000000018A2A1744-0x000000018A2A17B4
		private static object floatCaster(IntPtr L, int idx, object target) => default; // 0x00000001830A8780-0x00000001830A8810
		private object decimalCaster(IntPtr L, int idx, object target) => default; // 0x000000018A2A15B4-0x000000018A2A1644
		private static object getBoolean(IntPtr L, int idx, object target) => default; // 0x00000001833D8A00-0x00000001833D8A80
		private static object getString(IntPtr L, int idx, object target) => default; // 0x00000001833CD9A0-0x00000001833CDA00
		private object getBytes(IntPtr L, int idx, object target) => default; // 0x000000018A2A1644-0x000000018A2A1744
		private object getIntptr(IntPtr L, int idx, object target) => default; // 0x000000018A2A17B4-0x000000018A2A1824
		private object getObject(IntPtr L, int idx, object target) => default; // 0x00000001839B1150-0x00000001839B12B0
		private object getLuaTable(IntPtr L, int idx, object target) => default; // 0x0000000182611080-0x00000001826111B0
		private object getLuaFunction(IntPtr L, int idx, object target) => default; // 0x000000018260FB60-0x000000018260FC90
		public void AddCaster(System.Type type, ObjectCast oc) {} // 0x0000000183658D40-0x0000000183658DB0
		private ObjectCast genCaster(System.Type type) => default; // 0x000000018286FDE0-0x0000000182870330
		private ObjectCast genNullableCaster(ObjectCast oc) => default; // 0x000000018286D260-0x000000018286D310
		public ObjectCast GetCaster(System.Type type) => default; // 0x000000018286E970-0x000000018286EB20
	}

	public class ObjectPool // TypeDefIndex: 55119
	{
		// Fields
		private const int LIST_END = -1; // Metadata: 0x01FD6A00
		private const int ALLOCED = -2; // Metadata: 0x01FD6A01
		private Slot[] list; // 0x10
		private int freelist; // 0x18
		private int count; // 0x1C
		private List<object> needCleanImmediately; // 0x20
	
		// Properties
		public object this[int i] { get => default; } // 0x000000018A2A6D98-0x000000018A2A6DCC 
	
		// Nested types
		private struct Slot // TypeDefIndex: 55118
		{
			// Fields
			public int next; // 0x00
			public object obj; // 0x08
	
			// Constructors
			public Slot(int next, object obj) {
				this.next = default;
				this.obj = default;
			} // 0x00000001871AED58-0x00000001871AED68
		}
	
		// Constructors
		public ObjectPool() {} // 0x0000000183CB6900-0x0000000183CB69B0
	
		// Methods
		public void AddToNeedCleanImmediately(object obj) {} // 0x000000018260DF40-0x000000018260DFA0
		public void Clear() {} // 0x000000018A2A6D48-0x000000018A2A6D98
		private void extend_capacity() {} // 0x0000000182DA44D0-0x0000000182DA4590
		public int Add(object obj) => default; // 0x0000000182618F80-0x0000000182619130
		public bool TryGetValue(int index, out object obj) {
			obj = default;
			return default;
		} // 0x0000000182619B30-0x0000000182619C70
		public object Get(int index) => default; // 0x0000000182619130-0x0000000182619170
		public object Remove(int index) => default; // 0x0000000182619680-0x00000001826197C0
		public object Replace(int index, object o) => default; // 0x0000000182618F10-0x0000000182618F80
		public int Check(int check_pos, int max_check, Func<object, bool> checker, Dictionary<object, int> reverse_map) => default; // 0x0000000182619C70-0x000000018261A180
		public void ClearAllUserdata(Func<object, bool> checker, Dictionary<object, int> reverse_map) {} // 0x00000001830CD9E0-0x00000001830CDAB0
	}

	internal class ReferenceEqualsComparer : IEqualityComparer<object> // TypeDefIndex: 55120
	{
		// Constructors
		public ReferenceEqualsComparer() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public new bool Equals(object o1, object o2) => default; // 0x0000000182F62F80-0x0000000182F62F90
		public int GetHashCode(object obj) => default; // 0x0000000183D6E640-0x0000000183D6E650
	}

	public class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 55121
	{
		// Fields
		private System.Type type; // 0x10
	
		// Constructors
		public MonoPInvokeCallbackAttribute() {} // Dummy constructor
		public MonoPInvokeCallbackAttribute(System.Type t) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public enum LuaTypes // TypeDefIndex: 55122
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

	public enum LuaGCOptions // TypeDefIndex: 55123
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

	public enum LuaThreadStatus // TypeDefIndex: 55124
	{
		LUA_RESUME_ERROR = -1,
		LUA_OK = 0,
		LUA_YIELD = 1,
		LUA_ERRRUN = 2,
		LUA_ERRSYNTAX = 3,
		LUA_ERRMEM = 4,
		LUA_ERRERR = 5
	}

	public class LuaIndexes // TypeDefIndex: 55125
	{
		// Properties
		public static int LUA_REGISTRYINDEX { get => default; set {} } // 0x0000000182615330-0x0000000182615390 0x0000000183D29A40-0x0000000183D29AA0
	
		// Constructors
		public LuaIndexes() {} // 0x000000018350B670-0x000000018350B680
	}

	public class ObjectTranslator // TypeDefIndex: 55147
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
		public ObjectPool Pools { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Nested types
		public enum LOGLEVEL // TypeDefIndex: 55126
		{
			NO = 0,
			INFO = 1,
			WARN = 2,
			ERROR = 3
		}
	
		private struct EnumerableWrapper // TypeDefIndex: 55127
		{
			// Fields
			public int Index; // 0x00
			public IList CurList; // 0x08
			public IEnumerator Enumerator; // 0x10
			public static Stack<EnumerableWrapper> enumerableStack; // 0x00
	
			// Constructors
			static EnumerableWrapper() {
				enumerableStack = default;
			} // 0x000000018A2A6290-0x000000018A2A631C
	
			// Methods
			[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
			public static int ListCsPairs(IntPtr L) => default; // 0x0000000182D3DCC0-0x0000000182D3DE60
			[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
			public static int DicCsPairs(IntPtr L) => default; // 0x000000018309BD20-0x000000018309BFB0
			[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
			public static int IEnumerableCsPairs(IntPtr L) => default; // 0x0000000183241480-0x00000001832415E0
		}
	
		private struct FStructWrap<T> // TypeDefIndex: 55128
		{
			// Fields
			public T value;
	
			// Methods
			public IntPtr GetPtr() => default;
		}
	
		private struct CSharpStructInLua // TypeDefIndex: 55129
		{
			// Fields
			public int fake_id; // 0x00
			public uint len; // 0x04
			public IntPtr ptr; // 0x08
		}
	
		public struct LuaCSFunctionPtr // TypeDefIndex: 55130
		{
			// Fields
			public IntPtr ptr; // 0x00
			public object target; // 0x08
		}
	
		public delegate ValueTuple<IntPtr, T1> GetDelegatePointer<T1>(Delegate d); // TypeDefIndex: 55131; 0x00000000-0x00000000
	
		public delegate void PushCSObject(IntPtr L, object obj); // TypeDefIndex: 55132; 0x0000000182065C10-0x0000000182065C20
	
		public delegate object GetCSObject(IntPtr L, int idx); // TypeDefIndex: 55133; 0x0000000181165340-0x0000000181165350
	
		public delegate void UpdateCSObject(IntPtr L, int idx, object obj); // TypeDefIndex: 55134; 0x00000001811360D0-0x00000001811360F0
	
		public delegate bool CheckFunc<T>(IntPtr L, int idx); // TypeDefIndex: 55135; 0x00000000-0x00000000
	
		public delegate void GetFunc<T>(IntPtr L, int idx, out ref T val); // TypeDefIndex: 55136; 0x00000000-0x00000000
	
		// Constructors
		public ObjectTranslator() {} // Dummy constructor
		public ObjectTranslator(LuaEnv luaenv, IntPtr L) {} // 0x00000001826794B0-0x0000000182679EE0
		static ObjectTranslator() {} // 0x0000000183B12440-0x0000000183B12590
	
		// Methods
		public void DelayWrapLoader(System.Type type, Action<IntPtr> loader) {} // 0x00000001831E24C0-0x00000001831E2530
		public void AddInterfaceBridgeCreator(System.Type type, Func<int, LuaEnv, LuaBase> creator) {} // 0x000000018350B680-0x000000018350B6F0
		public bool TryDelayWrapLoader(IntPtr L, System.Type type) => default; // 0x000000018260FCD0-0x000000018260FFA0
		public void Alias(System.Type type, string alias) {} // 0x0000000183CA6B90-0x0000000183CA6C40
		private void addAssemblieByName(IEnumerable<Assembly> assemblies_usorted, string name) {} // 0x0000000182678A80-0x0000000182678D50
		private void initCSharpCallLua() {} // 0x000000018350B670-0x000000018350B680
		private Func<DelegateBridgeBase, Delegate> getCreatorUsingGeneric(DelegateBridgeBase bridge, System.Type delegateType, MethodInfo delegateMethod) => default; // 0x00000001830BDBA0-0x00000001830BE4A0
		private Delegate getDelegate(DelegateBridgeBase bridge, System.Type delegateType) => default; // 0x00000001830BD5D0-0x00000001830BDA80
		public object CreateDelegateBridge(IntPtr L, System.Type delegateType, int idx) => default; // 0x0000000182611AF0-0x0000000182611E90
		public bool AllDelegateBridgeReleased() => default; // 0x000000018A2A6E88-0x000000018A2A6FC4
		public void ReleaseLuaBase(IntPtr L, int reference, bool is_delegate) {} // 0x000000018260E300-0x000000018260E500
		public object CreateInterfaceBridge(IntPtr L, System.Type interfaceType, int idx) => default; // 0x000000018A2A6FD4-0x000000018A2A7128
		public void CreateArrayMetatable(IntPtr L) {} // 0x00000001839DF490-0x00000001839DF680
		public void CreateDelegateMetatable(IntPtr L) {} // 0x00000001839BA930-0x00000001839BAB50
		internal void CreateEnumerablePairs(IntPtr L) {} // 0x0000000183820AA0-0x0000000183820CF0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int CsPairs(IntPtr L) => default; // 0x00000001827C0810-0x00000001827C9170
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumToInt(IntPtr L) => default; // 0x000000018A2A7128-0x000000018A2A71BC
		internal void CreateEnumerableCSPairs(IntPtr L) {} // 0x0000000183820A50-0x0000000183820AA0
		public void OpenLib(IntPtr L) {} // 0x0000000183799C90-0x000000018379A270
		internal void createFunctionMetatable(IntPtr L) {} // 0x0000000183A1FF70-0x0000000183A20110
		internal System.Type FindType(string className, bool isQualifiedName = false /* Metadata: 0x01FD6A1E */) => default; // 0x000000018267A1D0-0x000000018267A4F0
		private bool hasMethod(System.Type type, string methodName) => default; // 0x000000018A2A7D98-0x000000018A2A7E1C
		internal void collectObject(int obj_index_to_collect) {} // 0x00000001824DB3C0-0x00000001824DB640
		private int addObject(object obj, bool is_valuetype, bool is_enum) => default; // 0x0000000182617B30-0x0000000182618F10
		internal object GetObject(IntPtr L, int index) => default; // 0x000000018286D310-0x000000018286D3D0
		public System.Type GetTypeOf(IntPtr L, int idx) => default; // 0x00000001829D3BB0-0x00000001829D3CE0
		public bool Assignable<T>(IntPtr L, int index) => default;
		public bool Assignable(IntPtr L, int index, System.Type type) => default; // 0x00000001826141F0-0x00000001826144F0
		public object FastGetObject(IntPtr L, int index, System.Type type) => default; // 0x0000000182619510-0x0000000182619680
		public object GetObject(IntPtr L, int index, System.Type type) => default; // 0x0000000184272BE0-0x0000000184272BF0
		private void _Get<T>(IntPtr L, int index, out ref T v) {
			v = default;
		}
		public void Get<T>(IntPtr L, int index, out ref T v) {
			v = default;
		}
		public void PushByType<T>(IntPtr L, T v) {}
		public T[] GetParams<T>(IntPtr L, int index) => default;
		public Array GetParams(IntPtr L, int index, System.Type type) => default; // 0x000000018A2A7288-0x000000018A2A7384
		public T GetDelegate<T>(IntPtr L, int index)
			where T : class => default;
		public int GetTypeId(IntPtr L, System.Type type) => default; // 0x00000001842725F8-0x0000000184272624
		public void PrivateAccessible(IntPtr L, System.Type type) {} // 0x000000018A2A76D4-0x000000018A2A77B8
		public int getTypeId(IntPtr L, System.Type type, out bool is_first, LOGLEVEL log_level = LOGLEVEL.WARN /* Metadata: 0x01FD6A1F */) {
			is_first = default;
			return default;
		} // 0x00000001826113F0-0x0000000182611A80
		private void pushPrimitive(IntPtr L, object o) {} // 0x0000000182613280-0x0000000182613620
		public void PushObject(IntPtr L, object o) {} // 0x00000001842702CC-0x00000001842702D4
		public void PushAny(IntPtr L, object o) {} // 0x000000018247CB10-0x000000018247D000
		public int TranslateToEnumToTop(IntPtr L, System.Type type, int idx) => default; // 0x000000018A2A7C78-0x000000018A2A7D98
		public void Push(IntPtr L, lua_CSFunction o) {} // 0x000000018A2A7AE8-0x000000018A2A7BA8
		public void Push(IntPtr L, LuaBase o) {} // 0x000000018A2A7A84-0x000000018A2A7AE8
		public void Push<T>(IntPtr L, T o)
			where T : struct {}
		public void Push(IntPtr L, object o) {} // 0x000000018247BF40-0x000000018247C260
		public void PushObject(IntPtr L, object o, int type_id) {} // 0x000000018A2A7978-0x000000018A2A7A84
		public bool IsUnmanagedType(System.Type type) => default; // 0x00000001829D2080-0x00000001829D2190
		public void PushBrigeStruct(IntPtr L, IntPtr ptr, System.Type type, int size) {} // 0x00000001829D1DB0-0x00000001829D2080
		private void _PushBrigeStruct(IntPtr L, IntPtr ptr, System.Type type, int size) {} // 0x00000001829D2190-0x00000001829D2310
		public void GetBrigeStruct(IntPtr L, IntPtr ptr, int index, int size, System.Type type) {} // 0x00000001829D10E0-0x00000001829D12C0
		public void AddNeedRemoveObjRef(object obj) {} // 0x000000018260DED0-0x000000018260DF40
		private void _GetBrigeStruct(IntPtr L, IntPtr ptr, int index, int size, System.Type type) {} // 0x00000001829D2310-0x00000001829D2520
		public void UpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type) {} // 0x00000001824D7CA0-0x00000001824D7D60
		public void BeyondUpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type) {} // 0x000000018A2A6FC4-0x000000018A2A6FD4
		private void _UpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type) {} // 0x00000001824D7D60-0x00000001824D7E20
		public void Update<T>(IntPtr L, int index, T obj)
			where T : struct {}
		public void Update(IntPtr L, int index, object obj) {} // 0x00000001826156B0-0x0000000182615890
		private object getCsObj(IntPtr L, int index, int udata) => default; // 0x00000001826197C0-0x0000000182619B30
		internal object SafeGetCSObj(IntPtr L, int index) => default; // 0x00000001824DAF70-0x00000001824DB000
		public object FastGetCSObj(IntPtr L, int index) => default; // 0x000000018A2A71BC-0x000000018A2A7230
		internal void ReleaseCSObj(IntPtr L, int index) {} // 0x000000018A2A7BA8-0x000000018A2A7C78
		internal lua_CSFunction GetFixCSFunction(int index) => default; // 0x000000018A2A7230-0x000000018A2A7288
		internal LuaCSFunctionPtr GetFixCSFunctionPtr(int index) => default; // 0x00000001822C57B0-0x00000001822C5860
		internal void PushFixCSFunction(IntPtr L, lua_CSFunction func) {} // 0x00000001825422D0-0x0000000182542690
		internal object[] popValues(IntPtr L, int oldTop) => default; // 0x00000001825D5000-0x00000001825D5130
		internal object[] popValues(IntPtr L, int oldTop, System.Type[] popTypes) => default; // 0x000000018A2A7E1C-0x000000018A2A7FA0
		private void registerCustomOp(System.Type type, PushCSObject push, GetCSObject get, UpdateCSObject update) {} // 0x0000000183048FA0-0x0000000183049150
		public bool HasCustomOp(System.Type type) => default; // 0x000000018348E380-0x000000018348E3E0
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
		public void PushDecimal(IntPtr L, decimal val) {} // 0x000000018A2A77B8-0x000000018A2A7978
		public bool IsDecimal(IntPtr L, int index) => default; // 0x000000018A2A7664-0x000000018A2A76D4
		public decimal GetDecimal(IntPtr L, int index) => default; // 0x00000001863F9B58-0x00000001863F9B94
		public void Get(IntPtr L, int index, out decimal val) {
			val = default;
		} // 0x000000018A2A7384-0x000000018A2A7664
	}

	public class ObjectTranslatorPool // TypeDefIndex: 55148
	{
		// Fields
		private Dictionary<IntPtr, WeakReference> translators; // 0x10
		private IntPtr lastPtr; // 0x18
		private ObjectTranslator lastTranslator; // 0x20
		public static ObjectTranslatorPool Instance; // 0x00
	
		// Constructors
		public ObjectTranslatorPool() {} // 0x0000000183C8B130-0x0000000183C8B1B0
		static ObjectTranslatorPool() {} // 0x0000000183C8B0C0-0x0000000183C8B130
	
		// Methods
		public void Add(IntPtr L, ObjectTranslator translator) {} // 0x0000000183C84FB0-0x0000000183C850A0
		public ObjectTranslator Find(IntPtr L) => default; // 0x0000000183D4EB40-0x0000000183D4EB50
		public void Remove(IntPtr L) {} // 0x000000018A2A6DCC-0x000000018A2A6E88
	}

	public interface RawObject // TypeDefIndex: 55149
	{
		// Properties
		object Target { get; }
	}

	public class InternalUtility // TypeDefIndex: 55150
	{
		// Fields
		private static Dictionary<System.Type, string> s_baseValueTypeDic; // 0x00
	
		// Constructors
		public InternalUtility() {} // 0x000000018350B670-0x000000018350B680
		static InternalUtility() {} // 0x000000018368FFF0-0x00000001836904F0
	
		// Methods
		public static string GetTypeGenericSignatureDefine(System.Type type, bool isGetType = false /* Metadata: 0x01FD6A24 */, bool isRef = false /* Metadata: 0x01FD6A25 */, bool isOut = false /* Metadata: 0x01FD6A26 */, bool needLua = false /* Metadata: 0x01FD6A27 */, bool keepType = false /* Metadata: 0x01FD6A28 */, bool needEnum = false /* Metadata: 0x01FD6A29 */) => default; // 0x00000001825E0C40-0x00000001825E0F90
		public static bool CheckRegisterBaseStructOnArm(System.Type type) => default; // 0x00000001825DF6F0-0x00000001825DF950
		public static bool CheckCustomDelegate(string name) => default; // 0x00000001823016E0-0x00000001823017E0
		public static bool CheckTypNeedToGen(System.Type type) => default; // 0x000000018A2A63B0-0x000000018A2A64E4
		public static bool IsPublic(System.Type type) => default; // 0x000000018A2A6C94-0x000000018A2A6D48
		public static string GetTypeFullName(System.Type t) => default; // 0x00000001826D2BC0-0x00000001826D2F00
		public static string GetDelegateName(MethodInfo method) => default; // 0x000000018A2A64E4-0x000000018A2A686C
		public static bool IsStruct(System.Type type) => default; // 0x00000001825DF950-0x00000001825DF9D0
		public static string GetGenericTypeName(System.Type type, bool needPoint = false /* Metadata: 0x01FD6A2A */) => default; // 0x000000018A2A6A1C-0x000000018A2A6C94
		public static string GeNormalName(string str) => default; // 0x00000001825DDFA0-0x00000001825DE150
		public static string GetGenericTypeNameString(System.Type type) => default; // 0x000000018A2A686C-0x000000018A2A6A1C
	}

	public class MethodAndDelegateSignatureManager // TypeDefIndex: 55151
	{
		// Constructors
		public MethodAndDelegateSignatureManager() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static System.Type MakeMethodDelegateType(MethodInfo method) => default; // 0x00000001826ADB80-0x00000001826AF830
		public static System.Type MakeMethodDelegateType(MethodInfo method, System.Type customDelegateType) => default; // 0x00000001826AC170-0x00000001826AD210
		public static ValueTuple<System.Type, string> GetMethodDelegateType(MethodInfo method) => default; // 0x00000001826AD780-0x00000001826AD8A0
	}

	public class SignatureLoader // TypeDefIndex: 55152
	{
		// Fields
		private LuaEnv.CustomLoader userLoader; // 0x10
		private RSACryptoServiceProvider rsa; // 0x18
		private SHA1 sha; // 0x20
	
		// Constructors
		public SignatureLoader() {} // Dummy constructor
		public SignatureLoader(string publicKey, LuaEnv.CustomLoader loader) {} // 0x000000018A2A8020-0x000000018A2A8120
	
		// Methods
		private byte[] load_and_verify(ref string filepath) => default; // 0x000000018A2A8120-0x000000018A2A8300
		public static implicit operator LuaEnv.CustomLoader(SignatureLoader signatureLoader) => default; // 0x000000018A2A8300-0x000000018A2A8374
	}

	public delegate TRet CallDelegatePointer<TParam1, TParam2, TRet>(IntPtr ptr, TParam1 target, TParam2 param); // TypeDefIndex: 55153; 0x00000000-0x00000000

	public class StaticLuaCallbacks // TypeDefIndex: 55154
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
		public StaticLuaCallbacks() {} // 0x00000001839ACFC0-0x00000001839AD1D0
	
		// Methods
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumAnd(IntPtr L) => default; // 0x000000018A2A9154-0x000000018A2A93DC
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumOr(IntPtr L) => default; // 0x000000018A2A93DC-0x000000018A2A9664
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int StaticCSFunction(IntPtr L) => default; // 0x000000018A2AB04C-0x000000018A2AB1F8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int FixCSFunction(IntPtr L) => default; // 0x00000001822C5230-0x00000001822C57B0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCall(IntPtr L) => default; // 0x000000018A2A8AC8-0x000000018A2A8CB8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LuaGC(IntPtr L) => default; // 0x00000001824DB2F0-0x00000001824DB3C0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToString(IntPtr L) => default; // 0x00000001834DE390-0x00000001834DE4D0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCombine(IntPtr L) => default; // 0x000000018A2A8CB8-0x000000018A2A8F18
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateRemove(IntPtr L) => default; // 0x00000001837B1F60-0x00000001837B20D0
		private static bool tryPrimitiveArrayGet(System.Type type, IntPtr L, object obj, int index) => default; // 0x00000001833BA1C0-0x00000001833BA6B0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayIndexer(IntPtr L) => default; // 0x00000001833B9DE0-0x00000001833BA1C0
		public static bool TryPrimitiveArraySet(System.Type type, IntPtr L, object obj, int array_idx, int obj_idx) => default; // 0x000000018A2AB58C-0x000000018A2ABEB0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayNewIndexer(IntPtr L) => default; // 0x000000018A2A8374-0x000000018A2A8824
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayLength(IntPtr L) => default; // 0x0000000183893400-0x0000000183893520
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int MetaFuncIndex(IntPtr L) => default; // 0x0000000183429080-0x00000001834291E0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Panic(IntPtr L) => default; // 0x000000018A2AAB84-0x000000018A2AAC20
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Print(IntPtr L) => default; // 0x000000018A2AAC20-0x000000018A2AAF04
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadSocketCore(IntPtr L) => default; // 0x000000018A2AAB3C-0x000000018A2AAB84
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadCS(IntPtr L) => default; // 0x000000018A2AA4C0-0x000000018A2AA52C
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadBuiltinLib(IntPtr L) => default; // 0x000000018364F9D0-0x000000018364FB80
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromResource(IntPtr L) => default; // 0x000000018A2AA52C-0x000000018A2AA840
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromStreamingAssetsPath(IntPtr L) => default; // 0x000000018A2AA840-0x000000018A2AAB3C
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromCustomLoaders(IntPtr L) => default; // 0x0000000182D3C1E0-0x0000000182D3C9A0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadAssembly(IntPtr L) => default; // 0x000000018A2AA234-0x000000018A2AA4C0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportType(IntPtr L) => default; // 0x000000018267A010-0x000000018267A1D0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportGenericType(IntPtr L) => default; // 0x000000018A2A9E54-0x000000018A2AA234
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Cast(IntPtr L) => default; // 0x000000018A2A8824-0x000000018A2A8AC8
		private static System.Type getType(IntPtr L, ObjectTranslator translator, int idx) => default; // 0x000000018A2AC840-0x000000018A2AC9C4
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaAccess(IntPtr L) => default; // 0x000000018A2ABEB0-0x000000018A2AC334
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaPrivateAccessible(IntPtr L) => default; // 0x000000018A2AC638-0x000000018A2AC840
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaMetatableOperation(IntPtr L) => default; // 0x000000018A2AC334-0x000000018A2AC638
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateConstructor(IntPtr L) => default; // 0x000000018A2A8F18-0x000000018A2A9154
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToFunction(IntPtr L) => default; // 0x000000018A2AB1F8-0x000000018A2AB58C
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GenericMethodWraper(IntPtr L) => default; // 0x000000018A2A9664-0x000000018A2A9A4C
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GetGenericMethod(IntPtr L) => default; // 0x000000018A2A9A4C-0x000000018A2A9E54
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ReleaseCsObject(IntPtr L) => default; // 0x000000018A2AAF04-0x000000018A2AB04C
	}

	internal static class TypeExtensions // TypeDefIndex: 55156
	{
		// Extension methods
		public static bool IsValueType(this System.Type type) => default; // 0x000000018247C260-0x000000018247C280
		public static bool IsEnum(this System.Type type) => default; // 0x0000000182477240-0x0000000182477260
		public static bool IsPrimitive(this System.Type type) => default; // 0x000000018247C280-0x000000018247C2A0
		public static bool IsAbstract(this System.Type type) => default; // 0x0000000182476B50-0x0000000182476B80
		public static bool IsSealed(this System.Type type) => default; // 0x000000018A2B06C8-0x000000018A2B06E4
		public static bool IsInterface(this System.Type type) => default; // 0x0000000182478640-0x0000000182478660
		public static bool IsClass(this System.Type type) => default; // 0x000000018308ECB0-0x000000018308ECD0
		public static System.Type BaseType(this System.Type type) => default; // 0x000000018260F010-0x000000018260F030
		public static bool IsGenericType(this System.Type type) => default; // 0x0000000182478620-0x0000000182478640
		public static bool IsGenericTypeDefinition(this System.Type type) => default; // 0x0000000182478660-0x0000000182478680
		public static bool IsNestedPublic(this System.Type type) => default; // 0x000000018A2B0690-0x000000018A2B06AC
		public static bool IsPublic(this System.Type type) => default; // 0x000000018A2B06AC-0x000000018A2B06C8
		public static string GetFriendlyName(this System.Type type) => default; // 0x000000018A2B0198-0x000000018A2B0690
	}

	public enum LazyMemberTypes // TypeDefIndex: 55157
	{
		Method = 0,
		FieldGet = 1,
		FieldSet = 2,
		PropertyGet = 3,
		PropertySet = 4,
		Event = 5
	}

	public static class Utils // TypeDefIndex: 55173
	{
		// Fields
		public static bool s_xluaReflectionOpt; // 0x00
		public const int OBJ_META_IDX = -4; // Metadata: 0x01FD6A33
		public const int METHOD_IDX = -3; // Metadata: 0x01FD6A34
		public const int GETTER_IDX = -2; // Metadata: 0x01FD6A35
		public const int SETTER_IDX = -1; // Metadata: 0x01FD6A36
		public const int CLS_IDX = -4; // Metadata: 0x01FD6A37
		public const int CLS_META_IDX = -3; // Metadata: 0x01FD6A38
		public const int CLS_GETTER_IDX = -2; // Metadata: 0x01FD6A39
		public const int CLS_SETTER_IDX = -1; // Metadata: 0x01FD6A3A
		public const string LuaIndexsFieldName = "LuaIndexs"; // Metadata: 0x01FD6A3B
		public const string LuaNewIndexsFieldName = "LuaNewIndexs"; // Metadata: 0x01FD6A45
		public const string LuaClassIndexsFieldName = "LuaClassIndexs"; // Metadata: 0x01FD6A52
		public const string LuaClassNewIndexsFieldName = "LuaClassNewIndexs"; // Metadata: 0x01FD6A61
	
		// Nested types
		private struct MethodKey // TypeDefIndex: 55158
		{
			// Fields
			public string Name; // 0x00
			public bool IsStatic; // 0x08
		}
	
		// Constructors
		static Utils() {} // 0x0000000183D43820-0x0000000183D43860
	
		// Methods
		public static bool LoadField(IntPtr L, int idx, string field_name) => default; // 0x000000018A2B4664-0x000000018A2B46F8
		public static IntPtr GetMainState(IntPtr L) => default; // 0x000000018A2B35B8-0x000000018A2B3674
		public static List<System.Type> GetAllTypes(bool exclude_generic_definition = true /* Metadata: 0x01FD6A31 */) => default; // 0x000000018A2B3380-0x000000018A2B35B8
		private static lua_CSFunction genFieldGetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x000000018A2B4E88-0x000000018A2B4F7C
		private static lua_CSFunction genFieldGetterByPointer(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001824DA6B0-0x00000001824DAAC0
		public static bool IsNullableType(System.Type type) => default; // 0x000000018A2B3674-0x000000018A2B3708
		private static lua_CSFunction genFieldSetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x000000018A2B4F7C-0x000000018A2B5070
		private static lua_CSFunction genFieldSetterByPointer(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001824DAAC0-0x00000001824DAEC0
		private static lua_CSFunction genItemGetterOpt(System.Type type, PropertyInfo[] props, ObjectTranslator translator) => default; // 0x000000018321B570-0x000000018321B9C0
		private static lua_CSFunction genItemGetter(System.Type type, PropertyInfo[] props) => default; // 0x000000018A2B5070-0x000000018A2B532C
		private static lua_CSFunction genItemSetterOpt(System.Type type, PropertyInfo[] props, ObjectTranslator translator) => default; // 0x000000018321B9C0-0x000000018321BE10
		private static lua_CSFunction genItemSetter(System.Type type, PropertyInfo[] props) => default; // 0x000000018A2B532C-0x000000018A2B55E8
		private static lua_CSFunction genEnumCastFrom(System.Type type) => default; // 0x000000018375AB10-0x000000018375ABC0
		internal static IEnumerable<MethodInfo> GetExtensionMethodsOf(System.Type type_to_be_extend) => default; // 0x000000018323D420-0x000000018323D730
		private static void makeReflectionWrap(IntPtr L, System.Type type, int cls_field, int cls_getter, int cls_setter, int obj_field, int obj_getter, int obj_setter, int obj_meta, out lua_CSFunction item_getter, out lua_CSFunction item_setter, System.Reflection.BindingFlags access) {
			item_getter = default;
			item_setter = default;
		} // 0x00000001825427F0-0x0000000182548220
		public static void loadUpvalue(IntPtr L, System.Type type, string metafunc, int index) {} // 0x000000018A2B570C-0x000000018A2B58B0
		public static void RegisterEnumType(IntPtr L, System.Type type) {} // 0x00000001826100A0-0x00000001826102C0
		public static void MakePrivateAccessible(IntPtr L, System.Type type) {} // 0x000000018A2B4860-0x000000018A2B4D20
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LazyReflectionCall(IntPtr L) => default; // 0x000000018A2B39E8-0x000000018A2B4664
		public static void ReflectionWrap(IntPtr L, System.Type type, bool privateAccessible) {} // 0x0000000182541610-0x00000001825422B0
		public static void BeginObjectRegister(System.Type type, IntPtr L, ObjectTranslator translator, int meta_count, int method_count, int getter_count, int setter_count, int type_id = -1 /* Metadata: 0x01FD6A32 */) {} // 0x000000018260F120-0x000000018260F520
		private static int abs_idx(int top, int idx) => default; // 0x0000000182610790-0x00000001826107A0
		public static void EndObjectRegister(System.Type type, IntPtr L, ObjectTranslator translator, lua_CSFunction csIndexer, lua_CSFunction csNewIndexer, System.Type base_type, lua_CSFunction arrayIndexer, lua_CSFunction arrayNewIndexer) {} // 0x0000000182610A50-0x0000000182611010
		public static void RegisterFunc(IntPtr L, int idx, string name, lua_CSFunction func) {} // 0x00000001826105A0-0x0000000182610790
		public static void RegisterLazyFunc(IntPtr L, int idx, string name, System.Type type, LazyMemberTypes memberType, bool isStatic) {} // 0x000000018A2B4D20-0x000000018A2B4E88
		public static void RegisterObject(IntPtr L, ObjectTranslator translator, int idx, string name, object obj) {} // 0x00000001826104A0-0x00000001826105A0
		public static void BeginClassRegister(System.Type type, IntPtr L, lua_CSFunction creator, int class_field_count, int static_getter_count, int static_setter_count) {} // 0x000000018260ECC0-0x000000018260EFA0
		public static void EndClassRegister(System.Type type, IntPtr L, ObjectTranslator translator) {} // 0x00000001826107A0-0x0000000182610A50
		private static List<string> getPathOfType(System.Type type) => default; // 0x00000001825DEBA0-0x00000001825DEDB0
		public static void LoadCSTable(IntPtr L, System.Type type) {} // 0x0000000182ED5690-0x0000000182ED5880
		public static void SetCSTable(IntPtr L, System.Type type, int cls_table) {} // 0x0000000182612110-0x0000000182612580
		public static bool IsParamsMatch(MethodInfo delegateMethod, MethodInfo bridgeMethod) => default; // 0x00000001830BDA80-0x00000001830BDBA0
		public static bool IsSupportedMethod(MethodInfo method) => default; // 0x000000018A2B3808-0x000000018A2B39E8
		public static MethodInfo MakeGenericMethodWithConstraints(MethodInfo method) => default; // 0x000000018A2B46F8-0x000000018A2B4860
		private static System.Type getExtendedType(MethodInfo method) => default; // 0x000000018A2B55E8-0x000000018A2B570C
		public static bool IsStaticPInvokeCSFunction(lua_CSFunction csFunction) => default; // 0x0000000182D3CD30-0x0000000182D3CE70
		public static bool IsPublic(System.Type type) => default; // 0x000000018A2B3708-0x000000018A2B3808
	}
}

namespace XLua.Cast
{
	public class Any<T> : RawObject // TypeDefIndex: 55200
	{
		// Fields
		private T mTarget;
	
		// Properties
		public object Target { get => default; }
	
		// Constructors
		public Any() {} // Dummy constructor
		public Any(T i) {}
	}

	public class Byte : Any<byte> // TypeDefIndex: 55201
	{
		// Constructors
		public Byte() {} // Dummy constructor
		public Byte(byte i) {} // 0x000000018A2AD1F8-0x000000018A2AD238
	}

	public class SByte : Any<sbyte> // TypeDefIndex: 55202
	{
		// Constructors
		public SByte() {} // Dummy constructor
		public SByte(sbyte i) {} // 0x000000018A2B010C-0x000000018A2B014C
	}

	public class Char : Any<char> // TypeDefIndex: 55203
	{
		// Constructors
		public Char() {} // Dummy constructor
		public Char(char i) {} // 0x000000018A2AD238-0x000000018A2AD27C
	}

	public class Int16 : Any<short> // TypeDefIndex: 55204
	{
		// Constructors
		public Int16() {} // Dummy constructor
		public Int16(short i) {} // 0x000000018A2AE0A0-0x000000018A2AE0E4
	}

	public class UInt16 : Any<ushort> // TypeDefIndex: 55205
	{
		// Constructors
		public UInt16() {} // Dummy constructor
		public UInt16(ushort i) {} // 0x000000018A2B32B8-0x000000018A2B32FC
	}

	public class Int32 : Any<int> // TypeDefIndex: 55206
	{
		// Constructors
		public Int32() {} // Dummy constructor
		public Int32(int i) {} // 0x000000018A2AE0E4-0x000000018A2AE124
	}

	public class UInt32 : Any<uint> // TypeDefIndex: 55207
	{
		// Constructors
		public UInt32() {} // Dummy constructor
		public UInt32(uint i) {} // 0x000000018A2B32FC-0x000000018A2B333C
	}

	public class Int64 : Any<long> // TypeDefIndex: 55208
	{
		// Constructors
		public Int64() {} // Dummy constructor
		public Int64(long i) {} // 0x000000018A2AE124-0x000000018A2AE168
	}

	public class UInt64 : Any<ulong> // TypeDefIndex: 55209
	{
		// Constructors
		public UInt64() {} // Dummy constructor
		public UInt64(ulong i) {} // 0x000000018A2B333C-0x000000018A2B3380
	}

	public class Float : Any<float> // TypeDefIndex: 55210
	{
		// Constructors
		public Float() {} // Dummy constructor
		public Float(float i) {} // 0x000000018A2AD328-0x000000018A2AD36C
	}
}

namespace XLua.LuaDLL
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int lua_CSFunction(IntPtr L); // TypeDefIndex: 55211; 0x000000018102B410-0x000000018102B420

	public static class Lua // TypeDefIndex: 55215
	{
		// Fields
		private const string LUADLL = "__Internal"; // Metadata: 0x01FD6A7A
		private static int s_mainThreadId; // 0x00
		public static Func<IntPtr, string> tryGetLuaStringFunc; // 0x08
		public static Action<IntPtr, IntPtr, int, string> refLuaStringFunc; // 0x10
		public const int LUAI_MAXSHORTLEN = 40; // Metadata: 0x01FD6A85
	
		// Nested types
		public delegate void HyperLuaLogCallbackDelegate(IntPtr L, int level, string text); // TypeDefIndex: 55212; 0x00000001811360D0-0x00000001811360F0
	
		public delegate void LuaUtilsLogCallbackDelegate(int level, string text); // TypeDefIndex: 55213; 0x0000000182065C10-0x0000000182065C20
	
		public delegate IntPtr DecryptionFunc(IntPtr input, int size, out int outSize); // TypeDefIndex: 55214; 0x0000000181035ED0-0x0000000181035EF0
	
		// Constructors
		static Lua() {} // 0x0000000183D1B410-0x0000000183D1B470
	
		// Methods
		public static extern IntPtr lua_tothread(IntPtr L, int index); // 0x000000018A2AF03C-0x000000018A2AF044
		public static extern int xlua_get_lib_version(); // 0x0000000184273324-0x000000018427332C
		public static extern int lua_gc(IntPtr L, XLua.LuaGCOptions what, int data); // 0x0000000184270BE4-0x0000000184270BEC
		public static extern IntPtr lua_getupvalue(IntPtr L, int funcindex, int n); // 0x000000018A2AEDBC-0x000000018A2AEDC4
		public static extern IntPtr lua_setupvalue(IntPtr L, int funcindex, int n); // 0x000000018A2AEF50-0x000000018A2AEF58
		public static extern int lua_pushthread(IntPtr L); // 0x0000000184273304-0x000000018427330C
		public static bool lua_isfunction(IntPtr L, int stackPos) => default; // 0x000000018260FB00-0x000000018260FB60
		public static bool lua_islightuserdata(IntPtr L, int stackPos) => default; // 0x000000018A2AEE2C-0x000000018A2AEE80
		public static bool lua_istable(IntPtr L, int stackPos) => default; // 0x0000000182613930-0x0000000182613990
		public static bool lua_isthread(IntPtr L, int stackPos) => default; // 0x000000018A2AEE94-0x000000018A2AEEE8
		public static int luaL_error(IntPtr L, string message) => default; // 0x000000018A2AEBC0-0x000000018A2AEC14
		public static extern int lua_setfenv(IntPtr L, int stackPos); // 0x000000018A2AEF08-0x000000018A2AEF10
		public static extern IntPtr luaL_newstate(); // 0x000000018427334C-0x0000000184273354
		public static extern void lua_close(IntPtr L); // 0x000000018A2AED14-0x000000018A2AED1C
		public static extern void luaopen_xlua(IntPtr L); // 0x00000001842732F4-0x00000001842732FC
		public static extern void luaL_openlibs(IntPtr L); // 0x000000018A2AECA8-0x000000018A2AECB0
		public static extern uint xlua_objlen(IntPtr L, int stackPos); // 0x0000000184273370-0x0000000184273378
		public static extern void lua_createtable(IntPtr L, int narr, int nrec); // 0x0000000184270B10-0x0000000184270B20
		public static void lua_newtable(IntPtr L, int arrayL = 0 /* Metadata: 0x01FD6A76 */, int hashL = 0 /* Metadata: 0x01FD6A77 */) {} // 0x000000018260EFA0-0x000000018260F010
		public static extern int xlua_getglobal(IntPtr L, string name); // 0x00000001826113B0-0x00000001826113F0
		public static extern int xlua_setglobal(IntPtr L, string name); // 0x0000000182D3BF10-0x0000000182D3BF50
		public static extern void xlua_getloaders(IntPtr L); // 0x0000000184273368-0x0000000184273370
		public static extern void lua_settop(IntPtr L, int newTop); // 0x0000000184270BDC-0x0000000184270BE4
		public static void lua_pop(IntPtr L, int amount) {} // 0x0000000182615390-0x00000001826153F0
		public static extern void lua_insert(IntPtr L, int newTop); // 0x000000018427610C-0x0000000184276114
		public static extern void lua_remove(IntPtr L, int index); // 0x0000000184270B84-0x0000000184270B8C
		public static extern int lua_rawget(IntPtr L, int index); // 0x0000000184270B6C-0x0000000184270B74
		public static extern void lua_rawset(IntPtr L, int index); // 0x00000001842704CC-0x00000001842704D4
		public static extern int lua_setmetatable(IntPtr L, int objIndex); // 0x0000000184273360-0x0000000184273368
		public static extern int lua_rawequal(IntPtr L, int index1, int index2); // 0x000000018A2AEEF8-0x000000018A2AEF00
		public static extern void lua_pushvalue(IntPtr L, int index); // 0x0000000184270B74-0x0000000184270B7C
		public static extern void lua_pushcclosure(IntPtr L, IntPtr fn, int n); // 0x000000018A2AEEF0-0x000000018A2AEEF8
		public static extern void lua_replace(IntPtr L, int index); // 0x000000018A2AEF00-0x000000018A2AEF08
		public static extern int lua_gettop(IntPtr L); // 0x0000000184270C24-0x0000000184270C2C
		public static extern LuaTypes lua_type(IntPtr L, int index); // 0x0000000184270BB4-0x0000000184270BBC
		public static bool lua_isnil(IntPtr L, int index) => default; // 0x00000001826144F0-0x0000000182614570
		public static extern bool lua_isnumber(IntPtr L, int index); // 0x00000001824D7170-0x00000001824D7190
		public static bool lua_isboolean(IntPtr L, int index) => default; // 0x000000018A2AEDC4-0x000000018A2AEE18
		public static extern int luaL_ref(IntPtr L, int registryIndex); // 0x0000000184270B64-0x0000000184270B6C
		public static int luaL_ref(IntPtr L) => default; // 0x00000001826111B0-0x0000000182611210
		public static extern void xlua_rawgeti(IntPtr L, int tableIndex, long index); // 0x0000000184270BD4-0x0000000184270BDC
		public static extern void xlua_rawseti(IntPtr L, int tableIndex, long index); // 0x0000000184270B30-0x0000000184270B38
		public static void lua_getref(IntPtr L, int reference) {} // 0x0000000182615270-0x0000000182615330
		public static extern int pcall_prepare(IntPtr L, int error_func_ref, int func_ref); // 0x000000018A2AF04C-0x000000018A2AF054
		public static extern void luaL_unref(IntPtr L, int registryIndex, int reference); // 0x0000000184270B08-0x0000000184270B10
		public static void lua_unref(IntPtr L, int reference) {} // 0x000000018260E500-0x000000018260E570
		public static extern bool lua_isstring(IntPtr L, int index); // 0x000000018A2AEE80-0x000000018A2AEE94
		public static extern bool lua_isinteger(IntPtr L, int index); // 0x000000018316DAF0-0x000000018316DB10
		public static extern void lua_pushnil(IntPtr L); // 0x0000000184270B4C-0x0000000184270B54
		public static void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, int n = 0 /* Metadata: 0x01FD6A78 */) {} // 0x00000001825426A0-0x00000001825427F0
		public static extern int xlua_upvalueindex(int n); // 0x000000018426F6BC-0x000000018426F6C4
		public static int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc) => default; // 0x00000001825D6C00-0x00000001825D6DC0
		public static extern int _lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc); // 0x0000000184270970-0x0000000184270978
		public static extern double lua_tonumber(IntPtr L, int index); // 0x00000001842725DC-0x00000001842725E4
		public static extern int xlua_tointeger(IntPtr L, int index); // 0x000000018426F6C4-0x000000018426F6CC
		public static extern uint xlua_touint(IntPtr L, int index); // 0x0000000184274EB8-0x0000000184274EC0
		public static extern bool lua_toboolean(IntPtr L, int index); // 0x0000000182648340-0x00000001826483A0
		public static extern IntPtr lua_topointer(IntPtr L, int index); // 0x000000018A2AF034-0x000000018A2AF03C
		public static extern IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen); // 0x0000000184270BAC-0x0000000184270BB4
		public static string lua_tostring_beyond(IntPtr L, int index) => default; // 0x0000000182613D70-0x0000000182613DD0
		public static string lua_tostring(IntPtr L, int index, bool cache = false /* Metadata: 0x01FD6A79 */) => default; // 0x0000000182613DD0-0x0000000182614170
		public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf); // 0x00000001822C7180-0x00000001822C71B0
		public static extern void lua_pushnumber(IntPtr L, double number); // 0x0000000184270600-0x0000000184270608
		public static extern void lua_pushboolean(IntPtr L, bool value); // 0x0000000182614170-0x0000000182614180
		public static extern void xlua_pushinteger(IntPtr L, int value); // 0x0000000182542690-0x00000001825426A0
		public static extern void xlua_pushuint(IntPtr L, uint value); // 0x0000000184274EC0-0x0000000184274EC8
		public static void lua_pushstring(IntPtr L, string str) {} // 0x00000001824D63D0-0x00000001824D6630
		public static extern void xlua_pushlstring(IntPtr L, byte[] str, int size); // 0x00000001823B9C80-0x00000001823B9CA0
		public static void xlua_pushasciistring(IntPtr L, string str) {} // 0x00000001823B9CA0-0x00000001823B9EF0
		public static void lua_pushstring(IntPtr L, byte[] str) {} // 0x000000018346C700-0x000000018346C770
		public static byte[] lua_tobytes(IntPtr L, int index) => default; // 0x000000018A2AEF58-0x000000018A2AF034
		public static extern int luaL_newmetatable(IntPtr L, string meta); // 0x000000018260FC90-0x000000018260FCD0
		public static extern int xlua_pgettable(IntPtr L, int idx); // 0x0000000184270BCC-0x0000000184270BD4
		public static extern int xlua_psettable(IntPtr L, int idx); // 0x0000000184270BEC-0x0000000184270BF4
		public static void luaL_getmetatable(IntPtr L, string meta) {} // 0x0000000182611A80-0x0000000182611AF0
		public static extern int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name); // 0x0000000182D3C9A0-0x0000000182D3CA10
		public static int luaL_loadbuffer(IntPtr L, string buff, string name) => default; // 0x000000018A2AEC14-0x000000018A2AECA8
		public static extern int xlua_tocsobj_safe(IntPtr L, int obj); // 0x0000000184270280-0x0000000184270288
		public static extern int xlua_tocsobj_fast(IntPtr L, int obj); // 0x0000000184270C2C-0x0000000184270C34
		public static int lua_error(IntPtr L) => default; // 0x000000018A2AED1C-0x000000018A2AED68
		public static extern bool lua_checkstack(IntPtr L, int extra); // 0x0000000182D3DCA0-0x0000000182D3DCC0
		public static extern int lua_next(IntPtr L, int index); // 0x000000018A2AEEE8-0x000000018A2AEEF0
		public static extern void lua_pushlightuserdata(IntPtr L, IntPtr udata); // 0x0000000184276D28-0x0000000184276D30
		public static extern IntPtr xlua_tag(); // 0x0000000184276D20-0x0000000184276D28
		public static extern void luaL_where(IntPtr L, int level); // 0x000000018A2AED0C-0x000000018A2AED14
		public static extern int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref); // 0x000000018426FFAC-0x000000018426FFB4
		public static extern void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref); // 0x000000018A2AF2C8-0x000000018A2AF2D4
		public static extern int gen_obj_indexer(IntPtr L); // 0x000000018A2AEBB0-0x000000018A2AEBB8
		public static extern int gen_obj_newindexer(IntPtr L); // 0x000000018A2AEBB8-0x000000018A2AEBC0
		public static extern int gen_cls_indexer(IntPtr L); // 0x000000018A2AEBA0-0x000000018A2AEBA8
		public static extern int gen_cls_newindexer(IntPtr L); // 0x000000018A2AEBA8-0x000000018A2AEBB0
		public static extern int get_error_func_ref(IntPtr L); // 0x000000018427330C-0x0000000184273314
		public static extern int load_error_func(IntPtr L, int Ref); // 0x0000000184270968-0x0000000184270970
		public static extern int luaopen_i64lib(IntPtr L); // 0x0000000184273314-0x000000018427331C
		public static extern int luaopen_socket_core(IntPtr L); // 0x000000018A2AF044-0x000000018A2AF04C
		public static extern void lua_pushint64(IntPtr L, long n); // 0x0000000184274D84-0x0000000184274D8C
		public static extern void lua_pushuint64(IntPtr L, ulong n); // 0x0000000184274D84-0x0000000184274D8C
		public static extern bool lua_isint64(IntPtr L, int idx); // 0x000000018A2AEE18-0x000000018A2AEE2C
		public static extern bool lua_isuint64(IntPtr L, int idx); // 0x000000018A2AEE18-0x000000018A2AEE2C
		public static extern long lua_toint64(IntPtr L, int idx); // 0x000000018426F6C4-0x000000018426F6CC
		public static extern ulong lua_touint64(IntPtr L, int idx); // 0x000000018426F6C4-0x000000018426F6CC
		public static extern void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n); // 0x00000001842704C4-0x00000001842704CC
		public static extern int xlua_csharp_str_error(IntPtr L, string message); // 0x000000018A2AF05C-0x000000018A2AF09C
		public static extern int xlua_csharp_error(IntPtr L); // 0x000000018A2AF054-0x000000018A2AF05C
		public static extern bool xlua_pack_int8_t(IntPtr buff, int offset, byte field); // 0x000000018A2AF264-0x000000018A2AF278
		public static extern bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field); // 0x000000018A2AF3F4-0x000000018A2AF408
		public static extern bool xlua_pack_int16_t(IntPtr buff, int offset, short field); // 0x000000018A2AF23C-0x000000018A2AF250
		public static extern bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field); // 0x000000018A2AF3E0-0x000000018A2AF3F4
		public static extern bool xlua_pack_int32_t(IntPtr buff, int offset, int field); // 0x0000000182ED83D0-0x0000000182ED83F0
		public static extern bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field); // 0x0000000182EDEEF0-0x0000000182EDEF10
		public static extern bool xlua_pack_int64_t(IntPtr buff, int offset, long field); // 0x000000018A2AF250-0x000000018A2AF264
		public static extern bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field); // 0x000000018A2AF304-0x000000018A2AF318
		public static extern bool xlua_pack_float(IntPtr buff, int offset, float field); // 0x000000018A2AF228-0x000000018A2AF23C
		public static extern bool xlua_unpack_float(IntPtr buff, int offset, out float field); // 0x000000018A2AF3CC-0x000000018A2AF3E0
		public static extern bool xlua_pack_double(IntPtr buff, int offset, double field); // 0x000000018A2AF18C-0x000000018A2AF1A0
		public static extern bool xlua_unpack_double(IntPtr buff, int offset, out double field); // 0x000000018A2AF304-0x000000018A2AF318
		public static extern IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref); // 0x00000001842725F0-0x00000001842725F8
		public static extern void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref); // 0x000000018A2AF2D4-0x000000018A2AF2DC
		public static extern IntPtr lua_touserdata(IntPtr L, int idx); // 0x0000000184272624-0x000000018427262C
		public static extern int xlua_gettypeid(IntPtr L, int idx); // 0x0000000184272668-0x0000000184272670
		public static extern int xlua_get_registry_index(); // 0x000000018427331C-0x0000000184273324
		public static extern int xlua_pgettable_bypath(IntPtr L, int idx, string path); // 0x00000001835A7A50-0x00000001835A7AA0
		public static extern int xlua_psettable_bypath(IntPtr L, int idx, string path); // 0x000000018A2AF278-0x000000018A2AF2C8
		public static extern bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2); // 0x00000001829D2660-0x00000001829D2680
		public static extern bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2); // 0x000000018A2AF318-0x000000018A2AF32C
		public static extern bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3); // 0x00000001829D25B0-0x00000001829D25E0
		public static extern bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3); // 0x0000000183274DB0-0x0000000183274DE0
		public static extern bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4); // 0x00000001829CE790-0x00000001829CE7C0
		public static extern bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4); // 0x000000018A2AF32C-0x000000018A2AF354
		public static extern bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5); // 0x000000018A2AF1A0-0x000000018A2AF1DC
		public static extern bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5); // 0x000000018A2AF354-0x000000018A2AF388
		public static extern bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5, float f6); // 0x000000018A2AF1DC-0x000000018A2AF228
		public static extern bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5, out float f6); // 0x000000018A2AF388-0x000000018A2AF3CC
		public static extern bool xlua_pack_decimal(IntPtr buff, int offset, ref decimal dec); // 0x000000018A2AF178-0x000000018A2AF18C
		public static extern bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign, out int hi32, out ulong lo64); // 0x000000018A2AF2DC-0x000000018A2AF304
		public static bool xlua_is_eq_str(IntPtr L, int index, string str) => default; // 0x000000018A2AF09C-0x000000018A2AF11C
		public static extern bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len); // 0x000000018A2AF11C-0x000000018A2AF178
		public static extern IntPtr xlua_gl(IntPtr L); // 0x0000000184276FCC-0x0000000184276FD4
		public static extern int luaL_traceback(IntPtr L, IntPtr L1, string msg, int level); // 0x000000018A2AECB0-0x000000018A2AED0C
		public static extern int lua_sethook(IntPtr L, XLua.LuaDLL.lua_Hook hook, int mask, int count); // 0x000000018A2AEF10-0x000000018A2AEF50
		public static extern XLua.LuaDLL.lua_Hook lua_gethook(IntPtr L); // 0x000000018A2AED70-0x000000018A2AEDB4
		public static extern int lua_gethookmask(IntPtr L); // 0x000000018A2AEDB4-0x000000018A2AEDBC
		public static extern int lua_getglobal(IntPtr L, IntPtr charPtr); // 0x000000018A2AED68-0x000000018A2AED70
		public static extern int lua_pushlstring(IntPtr L, IntPtr charPtr, int len); // 0x0000000184270934-0x000000018427093C
		public static extern int luaopen_HyperLua(IntPtr L); // 0x00000001842770E8-0x00000001842770F0
		public static extern void HyperLua_SetLogCallback(HyperLuaLogCallbackDelegate logCallback); // 0x00000001822C71B0-0x00000001822C71D0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadHyperLua(IntPtr L) => default; // 0x0000000183CF5080-0x0000000183CF50D0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static void SetHyperLuaLogCallback(HyperLuaLogCallbackDelegate logCallback) {} // 0x0000000183D2BFE0-0x0000000183D2C030
		public static extern int luaopen_LuaUtils(IntPtr L); // 0x00000001842770D8-0x00000001842770E0
		public static extern void LuaUtils_SetLogCallback(LuaUtilsLogCallbackDelegate logCallback); // 0x00000001822C71D0-0x00000001822C71F0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLuaUtils(IntPtr L) => default; // 0x0000000183CF4FE0-0x0000000183CF5030
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static void SetLuaUtilsLogCallback(LuaUtilsLogCallbackDelegate logCallback) {} // 0x0000000183D2BF90-0x0000000183D2BFE0
		public static extern int luaopen_rapidjson(IntPtr L); // 0x00000001842770D0-0x00000001842770D8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadRapidJson(IntPtr L) => default; // 0x0000000183CF4F90-0x0000000183CF4FE0
		public static extern int luaopen_pb(IntPtr L); // 0x00000001842770E0-0x00000001842770E8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLuaProtobuf(IntPtr L) => default; // 0x0000000183CF5030-0x0000000183CF5080
		public static extern void beyond_setDecryptionFunc(IntPtr L, IntPtr func); // 0x00000001842732FC-0x0000000184273304
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int lua_Hook(IntPtr L, ref lua_debug ar); // TypeDefIndex: 55216; 0x0000000181165340-0x0000000181165350
}

namespace XLua.Reflection
{
	public class LuaObjFieldGetterSetter // TypeDefIndex: 55198
	{
		// Constructors
		public LuaObjFieldGetterSetter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static bool _CheckRuntimeType(IntPtr L, object obj, System.Type type, System.Reflection.FieldInfo field) => default; // 0x000000018A2AE168-0x000000018A2AE338
		private static IntPtr _GetPtrFromObj(object obj) => default; // 0x000000018A2AE408-0x000000018A2AE45C
		private static IntPtr _GetPtrFromLuaStack(IntPtr L, ObjectTranslator translator, int index, bool isUnmanagedType) => default; // 0x000000018A2AE338-0x000000018A2AE408
		public static lua_CSFunction GetObjFieldGetterByPushInt32<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct => default;
		public static lua_CSFunction GetObjFloatFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001833B3060-0x00000001833B3150
		public static lua_CSFunction GetObjDoubleFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001835B55C0-0x00000001835B56B0
		public static lua_CSFunction GetObjFieldGetterByPushInt64<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct => default;
		public static lua_CSFunction GetObjFieldGetterByPushBool(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001824D8F90-0x00000001824D9080
		public static lua_CSFunction GetObjFieldGetterByPushString(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001824D8EA0-0x00000001824D8F90
		public static lua_CSFunction GetObjFieldObjGetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001824D91B0-0x00000001824D92A0
		public static lua_CSFunction GetObjFieldStructGetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001824D85C0-0x00000001824D87B0
		public static lua_CSFunction GetObjFieldEnumGetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001834143F0-0x00000001834144C0
		public static lua_CSFunction GetObjFieldStructGetter<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct => default;
		public static lua_CSFunction GetObjFieldObjSetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001824D9AD0-0x00000001824D9BE0
		public static lua_CSFunction GetObjFieldStructSetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001824D83F0-0x00000001824D85C0
		public static lua_CSFunction GetObjFieldSetterByGetInt32<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct => default;
		public static lua_CSFunction GetObjFieldSetterByGetInt64<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct => default;
		public static lua_CSFunction GetObjFloatFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001833B2F70-0x00000001833B3060
		public static lua_CSFunction GetObjDoubleFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001835B54D0-0x00000001835B55C0
		public static lua_CSFunction GetObjFieldBoolSetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001824D9080-0x00000001824D9170
		public static lua_CSFunction GetObjFieldEnumSetter(System.Type type, System.Reflection.FieldInfo field) => default; // 0x00000001833D4DA0-0x00000001833D4E90
	}

	public static class RuntimeEnumDic // TypeDefIndex: 55199
	{
		// Fields
		private static Dictionary<System.Type, Dictionary<int, object>> s_enumDic; // 0x00
	
		// Constructors
		static RuntimeEnumDic() {} // 0x0000000183CE3160-0x0000000183CE31F0
	
		// Methods
		public static object GetEnumByTypeAndValue(System.Type enumType, int value) => default; // 0x000000018260E880-0x000000018260ECC0
		public static void AddEnumValue(System.Type enumType, object enumObj) {} // 0x00000001834602D0-0x0000000183460470
	}
}

namespace XLua.TemplateEngine
{
	public enum TokenType // TypeDefIndex: 55174
	{
		Code = 0,
		Eval = 1,
		Text = 2
	}

	public class Chunk // TypeDefIndex: 55175
	{
		// Properties
		public XLua.TemplateEngine.TokenType Type { get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public string Text { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public Chunk() {} // Dummy constructor
		public Chunk(XLua.TemplateEngine.TokenType type, string text) {} // 0x0000000184270E40-0x0000000184270E50
	}

	internal class TemplateFormatException : Exception // TypeDefIndex: 55176
	{
		// Constructors
		public TemplateFormatException() {} // Dummy constructor
		public TemplateFormatException(string message) {} // 0x000000018A2B014C-0x000000018A2B0198
	}

	public class Parser // TypeDefIndex: 55178
	{
		// Properties
		public static string RegexString { get; private set; } // 0x000000018A2B0060-0x000000018A2B00B0 0x000000018A2B00B0-0x000000018A2B010C
	
		// Constructors
		static Parser() {} // 0x000000018A2AFFF0-0x000000018A2B0060
		public Parser() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static string EscapeString(string input) => default; // 0x000000018A2AF408-0x000000018A2AF6A0
		private static string GetRegexString() => default; // 0x000000018A2AF6A0-0x000000018A2AF8D8
		public static List<Chunk> Parse(string snippet) => default; // 0x000000018A2AF8D8-0x000000018A2AFFF0
	}

	public class LuaTemplate // TypeDefIndex: 55179
	{
		// Fields
		private static lua_CSFunction templateCompileFunction; // 0x00
		private static lua_CSFunction templateExecuteFunction; // 0x08
	
		// Constructors
		public LuaTemplate() {} // 0x000000018350B670-0x000000018350B680
		static LuaTemplate() {} // 0x0000000183C786C0-0x0000000183C787B0
	
		// Methods
		public static string ComposeCode(List<Chunk> chunks) => default; // 0x000000018A2AE6BC-0x000000018A2AE944
		public static LuaFunction Compile(LuaEnv luaenv, string snippet) => default; // 0x000000018A2AE45C-0x000000018A2AE500
		public static string Execute(LuaFunction compiledTemplate, LuaTable parameters) => default; // 0x000000018A2AEA18-0x000000018A2AEAA8
		public static string Execute(LuaFunction compiledTemplate) => default; // 0x000000018A2AEAA8-0x000000018A2AEB20
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Compile(IntPtr L) => default; // 0x000000018A2AE500-0x000000018A2AE6BC
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Execute(IntPtr L) => default; // 0x000000018A2AE944-0x000000018A2AEA18
		public static void OpenLib(IntPtr L) {} // 0x0000000182D3BDE0-0x0000000182D3BF10
	}
}
