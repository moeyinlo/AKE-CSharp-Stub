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

// Image 38: XLua.Runtime.dll - Assembly: XLua.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 85363-85626

[CompilerGenerated]
internal sealed class __f__AnonymousType0<_Type_j__TPar, _Value_j__TPar, _Index_j__TPar> // TypeDefIndex: 85364
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
internal sealed class __f__AnonymousType1<_type_j__TPar, _method_j__TPar> // TypeDefIndex: 85365
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
public class LuaAsset : ScriptableObject // TypeDefIndex: 85368
{
	// Fields
	public static string LuaDecodeKey; // 0x00
	public bool encode; // 0x18
	public byte[] data; // 0x20

	// Constructors
	public LuaAsset(); // 0x0000000188F94274-0x0000000188F94280
	static LuaAsset(); // 0x000000018D9DA694-0x000000018D9DA6F0

	// Methods
	public byte[] GetDecodeBytes(); // 0x000000018D9DA60C-0x000000018D9DA694
}

namespace Beyond.Lua
{
	public class LuaCypher // TypeDefIndex: 85437
	{
		// Fields
		private const string KEY = "=="; // Metadata: 0x02644F10
		private static readonly string[] KEYS; // 0x00
		private const string INITIAL_ASSETS_ROOT_PATH = "Assets/Beyond/InitialAssets/"; // Metadata: 0x02644F13
		private static readonly ProfilerMarker decryptionMaker; // 0x08
	
		// Constructors
		public LuaCypher(); // 0x0000000186805BA0-0x0000000186805BB0
		static LuaCypher(); // 0x0000000186E42A00-0x0000000186E440C0
	
		// Methods
		[IDTag(0)]
		private static string GetKey(); // 0x000000018D9DB3C4-0x000000018D9DB704
		[IDTag(1)]
		private static void GetKey(Span<byte> buffer, out int len); // 0x000000018D9DB14C-0x000000018D9DB3C4
		protected static bool SkipDecrypt(string luaString); // 0x000000018D9DB704-0x000000018D9DB81C
		public static string DecryptLuaString(string encryptLua); // 0x000000018D9DA930-0x000000018D9DA9D0
		public static byte[] DecryptLua(string encryptLua); // 0x000000018D9DA9D0-0x000000018D9DB14C
		[XLua.MonoPInvokeCallback(typeof(Lua.DecryptionFunc))]
		public static IntPtr DecryptionFunc(IntPtr input, int size, out int outSize); // 0x0000000186364820-0x0000000186365280
	}

	public class LuaGenericDelegateCaller // TypeDefIndex: 85439
	{
		// Fields
		private static Dictionary<string, LuaGenericDelegateCall> s_callerDic; // 0x00
	
		// Nested types
		public delegate int LuaGenericDelegateCall(IntPtr L, Delegate @delegate, ObjectTranslator objectTranslator, List<System.Type> castType); // TypeDefIndex: 85438; 0x00000001811CDB70-0x00000001811CDB90
	
		// Constructors
		public LuaGenericDelegateCaller(); // 0x0000000186805BA0-0x0000000186805BB0
		static LuaGenericDelegateCaller(); // 0x0000000187177A50-0x0000000187177AE0
	
		// Methods
		public static LuaGenericDelegateCall GetCaller(string delegateTypeName); // 0x00000001863C4190-0x00000001863C4220
		public static void AddCaller(string delegateTypeName, LuaGenericDelegateCall caller); // 0x000000018616DD10-0x000000018616DE60
		public static int OverloadMethodCall(IntPtr L, ObjectTranslator objectTranslator, IOverloadMethodWrap[] overload); // 0x000000018511BD50-0x000000018511C340
		public static int DefaultValueMethodCall(IntPtr L, ObjectTranslator objectTranslator, IOverloadMethodWrap[] defaultValues); // 0x000000018511E450-0x000000018511EC30
	}
}

namespace Beyond.Reflection
{
	public class GenericDelegateCaller // TypeDefIndex: 85370
	{
		// Fields
		private static Dictionary<string, System.Type> s_customDelegateTypeDic; // 0x00
	
		// Constructors
		public GenericDelegateCaller(); // 0x0000000186805BA0-0x0000000186805BB0
		static GenericDelegateCaller(); // 0x00000001867EE210-0x00000001867EE2A0
	
		// Methods
		public static System.Type GetCustomDelegateType(string delegateName); // 0x00000001857C35D0-0x00000001857C3660
		public static void AddCustomDelegateType(string delegateName, System.Type type); // 0x000000018621FB60-0x000000018621FCB0
	}

	public class MethodParamItem // TypeDefIndex: 85371
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
		public MethodParamItem(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static List<MethodParamItem> GetMethodParamList(MethodInfo method, bool needLua = false /* Metadata: 0x02644F08 */, bool needEnum = false /* Metadata: 0x02644F09 */); // 0x0000000185A36A60-0x0000000185A36F20
		public static string GetMethodSignatureString(MethodInfo method, bool needLua = false /* Metadata: 0x02644F0A */, bool keepType = false /* Metadata: 0x02644F0B */, bool needEnum = false /* Metadata: 0x02644F0C */); // 0x0000000185368EF0-0x0000000185369790
	}
}

namespace Beyond.Reflection.StructSizeGen
{
	public struct FStructSize0 // TypeDefIndex: 85372
	{
	}

	public struct FStructSize1 // TypeDefIndex: 85373
	{
		// Fields
		public byte b0; // 0x00
	}

	public struct FStructSize2 // TypeDefIndex: 85374
	{
		// Fields
		public short s0; // 0x00
	}

	public struct FStructSize3 // TypeDefIndex: 85375
	{
		// Fields
		public short s0; // 0x00
		public byte b0; // 0x02
	}

	public struct FStructSize4 // TypeDefIndex: 85376
	{
		// Fields
		public int i0; // 0x00
	}

	public struct FStructSize5 // TypeDefIndex: 85377
	{
		// Fields
		public int i0; // 0x00
		public byte b0; // 0x04
	}

	public struct FStructSize8 // TypeDefIndex: 85378
	{
		// Fields
		public long l0; // 0x00
	}

	public struct FStructSize12 // TypeDefIndex: 85379
	{
		// Fields
		public long l0; // 0x00
		public int i0; // 0x08
	}

	public struct FStructSize16 // TypeDefIndex: 85380
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
	}

	public struct FStructSize20 // TypeDefIndex: 85381
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public int i0; // 0x10
	}

	public struct FStructSize22 // TypeDefIndex: 85382
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public int i0; // 0x10
		public short s0; // 0x14
	}

	public struct FStructSize24 // TypeDefIndex: 85383
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
	}

	public struct FStructSize28 // TypeDefIndex: 85384
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public int i0; // 0x18
	}

	public struct FStructSize32 // TypeDefIndex: 85385
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
	}

	public struct FStructSize36 // TypeDefIndex: 85386
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public int i0; // 0x20
	}

	public struct FStructSize40 // TypeDefIndex: 85387
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
	}

	public struct FStructSize44 // TypeDefIndex: 85388
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public int i0; // 0x28
	}

	public struct FStructSize48 // TypeDefIndex: 85389
	{
		// Fields
		public long l0; // 0x00
		public long l1; // 0x08
		public long l2; // 0x10
		public long l3; // 0x18
		public long l4; // 0x20
		public long l5; // 0x28
	}

	public struct FStructSize52 // TypeDefIndex: 85390
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

	public struct FStructSize56 // TypeDefIndex: 85391
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

	public struct FStructSize60 // TypeDefIndex: 85392
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

	public struct FStructSize64 // TypeDefIndex: 85393
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

	public struct FStructSize68 // TypeDefIndex: 85394
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

	public struct FStructSize72 // TypeDefIndex: 85395
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

	public struct FStructSize76 // TypeDefIndex: 85396
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

	public struct FStructSize80 // TypeDefIndex: 85397
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

	public struct FStructSize84 // TypeDefIndex: 85398
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

	public struct FStructSize88 // TypeDefIndex: 85399
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

	public struct FStructSize92 // TypeDefIndex: 85400
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

	public struct FStructSize96 // TypeDefIndex: 85401
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

	public struct FStructSize100 // TypeDefIndex: 85402
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
		public int i0; // 0x60
	}

	public struct FStructSize104 // TypeDefIndex: 85403
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

	public struct FStructSize108 // TypeDefIndex: 85404
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

	public struct FStructSize112 // TypeDefIndex: 85405
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

	public struct FStructSize116 // TypeDefIndex: 85406
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

	public struct FStructSize120 // TypeDefIndex: 85407
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

	public struct FStructSize124 // TypeDefIndex: 85408
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

	public struct FStructSize128 // TypeDefIndex: 85409
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

	public struct FStructSize136 // TypeDefIndex: 85410
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

	public struct FStructSize140 // TypeDefIndex: 85411
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

	public struct FStructSize144 // TypeDefIndex: 85412
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

	public struct FStructSize148 // TypeDefIndex: 85413
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

	public struct FStructSize152 // TypeDefIndex: 85414
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

	public struct FStructSize160 // TypeDefIndex: 85415
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

	public struct FStructSize164 // TypeDefIndex: 85416
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

	public struct FStructSize168 // TypeDefIndex: 85417
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

	public struct FStructSize176 // TypeDefIndex: 85418
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

	public struct FStructSize180 // TypeDefIndex: 85419
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

	public struct FStructSize184 // TypeDefIndex: 85420
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

	public struct FStructSize192 // TypeDefIndex: 85421
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

	public struct FStructSize196 // TypeDefIndex: 85422
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

	public struct FStructSize200 // TypeDefIndex: 85423
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

	public struct FStructSize208 // TypeDefIndex: 85424
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

	public struct FStructSize224 // TypeDefIndex: 85425
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

	public struct FStructSize232 // TypeDefIndex: 85426
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

	public struct FStructSize240 // TypeDefIndex: 85427
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

	public struct FStructSize248 // TypeDefIndex: 85428
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

	public struct FStructSize256 // TypeDefIndex: 85429
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
	public enum ELuaMultithreadingGCState // TypeDefIndex: 85430
	{
		MinorGC = 0,
		MajorGC = 1
	}

	public class OnGCEndEvent : UnityEvent // TypeDefIndex: 85431
	{
		// Constructors
		public OnGCEndEvent(); // 0x000000018548D960-0x000000018548D970
	}

	public class LuaMultithreadingGC // TypeDefIndex: 85436
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
		public struct StartLuaGC // TypeDefIndex: 85432
		{
		}
	
		public struct WaitLuaGC // TypeDefIndex: 85433
		{
		}
	
		public struct OnGCEnd // TypeDefIndex: 85434
		{
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 85435
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<PlayerLoopSystem, bool> __9__44_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D9E0D44-0x000000018D9E0DA8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool __Dispose_b__44_0(PlayerLoopSystem x); // 0x000000018D9E0768-0x000000018D9E082C
		}
	
		// Constructors
		public LuaMultithreadingGC(LuaEnv luaEnv); // 0x0000000185BB4D00-0x0000000185BB5030
		static LuaMultithreadingGC(); // 0x00000001870347F0-0x0000000187034900
	
		// Methods
		public void StartGCAsync(); // 0x0000000185151670-0x0000000185151B70
		public void NormalStop(); // 0x000000018D9DCE38-0x000000018D9DCEE0
		public void ForceStopAsyncGC(); // 0x000000018D9DCC78-0x000000018D9DCCF4
		public void MainThreadWait(); // 0x0000000185151E60-0x0000000185151F80
		public void AddLuaAfterGCEvent(UnityAction action); // 0x0000000186D2E220-0x0000000186D2E260
		public void AddLuaAfterGCOnceEvent(UnityAction action); // 0x000000018709C870-0x000000018709C8F0
		public void RemoveLuaAfterGCEvent(UnityAction action); // 0x000000018D9DCEE0-0x000000018D9DCF38
		private void _OnGCEnd(); // 0x0000000185151B70-0x0000000185151E60
		private void _Init(); // 0x0000000185BB92C0-0x0000000185BB99F0
		private void _Dispose(); // 0x000000018D9DCF38-0x000000018D9DD410
		private static int _FindLoopSystemIndex(PlayerLoopSystem[] playerLoopList, string typeName); // 0x0000000185BBBE50-0x0000000185BBBF00
		[AOT.MonoPInvokeCallback(typeof(XLua.lua_Hook))]
		public static int LuaHook(IntPtr L, ref lua_debug ar); // 0x000000018D9DCCF4-0x000000018D9DCE38
		private void _UpdateOldHook(); // 0x000000018D9DD410-0x000000018D9DD5F4
		private bool _DoLock(); // 0x0000000185885960-0x0000000185885990
		private bool _DoGc(int work = 0 /* Metadata: 0x02644F0F */); // 0x0000000185883920-0x00000001858839E0
		private void _GCMethodWrapper(); // 0x00000001858839E0-0x0000000185883DB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 85607
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018D9E9C7C-0x000000018D9E9CE0
	
		// Methods
		public System.Type __Gen_Wrap_0(object P0); // 0x000000018D9E9334-0x000000018D9E9414
		public void __Gen_Wrap_1(object P0, object P1); // 0x0000000188B47220-0x0000000188B472F0
		public List<MethodParamItem> __Gen_Wrap_2(object P0, bool P1, bool P2); // 0x000000018D9E97B4-0x000000018D9E98D0
		public string __Gen_Wrap_3(object P0, bool P1, bool P2, bool P3); // 0x000000018D9E98D0-0x000000018D9E9A00
		public void __Gen_Wrap_4(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public bool __Gen_Wrap_5(PlayerLoopSystem P0); // 0x000000018D9E9A00-0x000000018D9E9B0C
		public int __Gen_Wrap_6(object P0, object P1); // 0x0000000188B4BB74-0x0000000188B4BC54
		public int __Gen_Wrap_7(IntPtr P0, ref lua_debug P1); // 0x000000018D9E9B0C-0x000000018D9E9C7C
		public bool __Gen_Wrap_8(object P0); // 0x0000000188B46E14-0x0000000188B46ED4
		public bool __Gen_Wrap_9(object P0, int P1); // 0x0000000188B4B5C0-0x0000000188B4B69C
		public string __Gen_Wrap_10(); // 0x000000018D9E9414-0x000000018D9E94D0
		public void __Gen_Wrap_11(Span<byte> P0, out int P1); // 0x000000018D9E94D0-0x000000018D9E95F4
		public byte[] __Gen_Wrap_12(object P0); // 0x000000018D9E95F4-0x000000018D9E96D4
		public string __Gen_Wrap_13(object P0); // 0x000000018D9E96D4-0x000000018D9E97B4
		public IntPtr __Gen_Wrap_14(IntPtr P0, int P1, out int P2); // 0x0000000184F7A730-0x0000000184F7A980
		public LuaGenericDelegateCaller.LuaGenericDelegateCall __Gen_Wrap_15(object P0); // 0x0000000184F7A980-0x0000000184F7B2A0
		public int __Gen_Wrap_16(IntPtr P0, object P1, object P2); // 0x0000000184F7B2A0-0x0000000184F7B680
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 85608
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018D9E9CE0-0x000000018D9E9D78
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 85609
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018D9F1390-0x000000018D9F13F4
		public static bool IsPatched(int id); // 0x000000018D9F1480-0x000000018D9F14FC
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018D9F1248-0x000000018D9F1314
		public object CreateWrapper(int id); // 0x000000018D9F1314-0x000000018D9F1390
		public object InitWrapperArray(int len); // 0x000000018D9F13F4-0x000000018D9F1480
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018D9F11A4-0x000000018D9F1248
	}

	public delegate System.Type __HotPatchDelegate_0(object P0); // TypeDefIndex: 85610; 0x0000000185B78EA0-0x0000000185B78EB0

	public enum HotPatchIDMAP0 // TypeDefIndex: 85611
	{
		Beyond-Reflection-GenericDelegateCaller-GetCustomDelegateType0 = 0,
		Beyond-Reflection-GenericDelegateCaller-AddCustomDelegateType0 = 1,
		Beyond-Scripts-Lua-LuaMultithreadingGC-AddLuaAfterGCEvent0 = 1,
		Beyond-Scripts-Lua-LuaMultithreadingGC-AddLuaAfterGCOnceEvent0 = 1,
		Beyond-Scripts-Lua-LuaMultithreadingGC-RemoveLuaAfterGCEvent0 = 1,
		Beyond-Lua-LuaGenericDelegateCaller-AddCaller0 = 1,
		Beyond-Reflection-MethodParamItem-GetMethodParamList0 = 2,
		Beyond-Reflection-MethodParamItem-GetMethodSignatureString0 = 3,
		Beyond-Scripts-Lua-LuaMultithreadingGC-StartGCAsync0 = 4,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_OnGCEnd0 = 4,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_Dispose0 = 4,
		Beyond-Scripts-Lua-LuaMultithreadingGC-NormalStop0 = 4,
		Beyond-Scripts-Lua-LuaMultithreadingGC-ForceStopAsyncGC0 = 4,
		Beyond-Scripts-Lua-LuaMultithreadingGC-MainThreadWait0 = 4,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_Init0 = 4,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_UpdateOldHook0 = 4,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_GCMethodWrapper0 = 4,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_FindLoopSystemIndex0 = 5,
		Beyond-Scripts-Lua-LuaMultithreadingGC-LuaHook0 = 6,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_DoLock0 = 7,
		Beyond-Lua-LuaCypher-SkipDecrypt0 = 7,
		Beyond-Scripts-Lua-LuaMultithreadingGC-_DoGc0 = 8,
		Beyond-Lua-LuaCypher-GetKey0 = 9,
		Beyond-Lua-LuaCypher-GetKey1 = 10,
		Beyond-Lua-LuaCypher-DecryptLua0 = 11,
		Beyond-Lua-LuaCypher-DecryptLuaString0 = 12,
		Beyond-Lua-LuaCypher-DecryptionFunc0 = 13,
		Beyond-Lua-LuaGenericDelegateCaller-GetCaller0 = 14,
		Beyond-Lua-LuaGenericDelegateCaller-OverloadMethodCall0 = 15,
		Beyond-Lua-LuaGenericDelegateCaller-DefaultValueMethodCall0 = 15
	}

	public delegate void __HotPatchDelegate_1(object P0, object P1); // TypeDefIndex: 85612; 0x00000001859B7730-0x00000001859B7740

	public delegate List<MethodParamItem> __HotPatchDelegate_2(object P0, bool P1, bool P2); // TypeDefIndex: 85613; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_3(object P0, bool P1, bool P2, bool P3); // TypeDefIndex: 85614; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_4(object P0); // TypeDefIndex: 85615; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_5(object P0, object P1); // TypeDefIndex: 85616; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_6(IntPtr P0, ref lua_debug P1); // TypeDefIndex: 85617; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_7(object P0); // TypeDefIndex: 85618; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_8(object P0, int P1); // TypeDefIndex: 85619; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_9(); // TypeDefIndex: 85620; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_10(Span<byte> P0, out int P1); // TypeDefIndex: 85621; 0x00000001826DF750-0x00000001826DF780

	public delegate byte[] __HotPatchDelegate_11(object P0); // TypeDefIndex: 85622; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_12(object P0); // TypeDefIndex: 85623; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IntPtr __HotPatchDelegate_13(IntPtr P0, int P1, out int P2); // TypeDefIndex: 85624; 0x00000001811DF7F0-0x00000001811DF810

	public delegate LuaGenericDelegateCaller.LuaGenericDelegateCall __HotPatchDelegate_14(object P0); // TypeDefIndex: 85625; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_15(IntPtr P0, object P1, object P2); // TypeDefIndex: 85626; 0x00000001811DF7F0-0x00000001811DF810
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 85366
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Security
{
	public sealed class XXTEA // TypeDefIndex: 85369
	{
		// Fields
		private static readonly UTF8Encoding utf8; // 0x00
		private const uint delta = 2654435769; // Metadata: 0x02644F03
	
		// Constructors
		private XXTEA(); // 0x0000000186805BA0-0x0000000186805BB0
		static XXTEA(); // 0x000000018D9E2594-0x000000018D9E2610
	
		// Methods
		private static uint MX(uint sum, uint y, uint z, int p, uint e, uint[] k); // 0x000000018D9E1DBC-0x000000018D9E1E60
		public static byte[] Encrypt(byte[] data, byte[] key); // 0x000000018D9E1B54-0x000000018D9E1BF0
		public static byte[] Encrypt(string data, byte[] key); // 0x000000018D9E1838-0x000000018D9E18B4
		public static byte[] Encrypt(byte[] data, string key); // 0x000000018D9E1BF0-0x000000018D9E1C6C
		public static byte[] Encrypt(string data, string key); // 0x000000018D9E18B4-0x000000018D9E1954
		public static string EncryptToBase64String(byte[] data, byte[] key); // 0x000000018D9E1748-0x000000018D9E17C0
		public static string EncryptToBase64String(string data, byte[] key); // 0x000000018D9E17C0-0x000000018D9E1838
		public static string EncryptToBase64String(byte[] data, string key); // 0x000000018D9E1658-0x000000018D9E16D0
		public static string EncryptToBase64String(string data, string key); // 0x000000018D9E16D0-0x000000018D9E1748
		public static byte[] Decrypt(byte[] data, byte[] key); // 0x000000018D9E1538-0x000000018D9E15D4
		private static int _Decrypt(Span<byte> data, Span<byte> key, Span<byte> result); // 0x000000018D9E22D8-0x000000018D9E2594
		public static byte[] Decrypt(byte[] data, string key); // 0x000000018D9E14BC-0x000000018D9E1538
		public static int Decrypt(Span<byte> data, Span<byte> key, Span<byte> result); // 0x000000018D9E15D4-0x000000018D9E1658
		public static byte[] DecryptBase64String(string data, byte[] key); // 0x000000018D9E0F14-0x000000018D9E0F8C
		public static byte[] DecryptBase64String(string data, string key); // 0x000000018D9E0F8C-0x000000018D9E1004
		public static string DecryptToString(byte[] data, byte[] key); // 0x000000018D9E11E4-0x000000018D9E1268
		public static string DecryptToString(byte[] data, string key); // 0x000000018D9E1268-0x000000018D9E12EC
		public static string DecryptBase64StringToString(string data, byte[] key); // 0x000000018D9E0E90-0x000000018D9E0F14
		public static string DecryptBase64StringToString(string data, string key); // 0x000000018D9E0E0C-0x000000018D9E0E90
		private static uint[] Encrypt(uint[] v, uint[] k); // 0x000000018D9E1954-0x000000018D9E1B54
		private static uint[] Decrypt(uint[] v, uint[] k); // 0x000000018D9E12EC-0x000000018D9E14BC
		private static void DecryptInPlace(Span<uint> v, Span<uint> k); // 0x000000018D9E1004-0x000000018D9E11E4
		private static uint MxForSpan(uint sum, uint y, uint z, int p, uint e, Span<uint> k); // 0x000000018D9E1E60-0x000000018D9E1EC4
		private static byte[] FixKey(byte[] key); // 0x000000018D9E1D24-0x000000018D9E1DBC
		private static void FixKey(Span<byte> key, Span<byte> fixedkey); // 0x000000018D9E1C6C-0x000000018D9E1D24
		private static uint[] ToUInt32Array(byte[] data, bool includeLength); // 0x000000018D9E21DC-0x000000018D9E22D8
		private static void ToUInt32Array(Span<byte> data, bool includeLength, Span<uint> result); // 0x000000018D9E20EC-0x000000018D9E21DC
		private static byte[] ToByteArray(uint[] data, bool includeLength); // 0x000000018D9E1EC4-0x000000018D9E1FA8
		private static void ToByteSpanFromUInt32(Span<uint> data, bool includeLength, Span<byte> result, out int len); // 0x000000018D9E1FA8-0x000000018D9E20EC
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 85367
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace XLua
{
	public class CopyByValue // TypeDefIndex: 85440
	{
		// Fields
		public static CopyByValue Instance; // 0x00
	
		// Constructors
		public CopyByValue(); // 0x0000000186805BA0-0x0000000186805BB0
		static CopyByValue(); // 0x00000001871E81E0-0x00000001871E8240
	
		// Methods
		public bool Pack(IntPtr buff, int offset, byte field); // 0x000000018D9D6804-0x000000018D9D6868
		public bool UnPack(IntPtr buff, int offset, out byte field); // 0x000000018D9D7034-0x000000018D9D7098
		public bool Pack(IntPtr buff, int offset, sbyte field); // 0x000000018D9D6740-0x000000018D9D67A4
		public bool UnPack(IntPtr buff, int offset, out sbyte field); // 0x000000018D9D6FC4-0x000000018D9D7034
		public bool Pack(IntPtr buff, int offset, short field); // 0x000000018D9D6868-0x000000018D9D68CC
		public bool UnPack(IntPtr buff, int offset, out short field); // 0x000000018D9D6F60-0x000000018D9D6FC4
		public bool Pack(IntPtr buff, int offset, ushort field); // 0x000000018D9D6A5C-0x000000018D9D6AC0
		public bool UnPack(IntPtr buff, int offset, out ushort field); // 0x000000018D9D6BD8-0x000000018D9D6C58
		public bool Pack(IntPtr buff, int offset, int field); // 0x0000000186322770-0x00000001863227D0
		public bool UnPack(IntPtr buff, int offset, out int field); // 0x000000018D9D6B24-0x000000018D9D6B74
		public bool Pack(IntPtr buff, int offset, uint field); // 0x000000018D9D67A4-0x000000018D9D6804
		public bool UnPack(IntPtr buff, int offset, out uint field); // 0x000000018D9D6CBC-0x000000018D9D6D30
		public bool Pack(IntPtr buff, int offset, long field); // 0x000000018D9D69F8-0x000000018D9D6A5C
		public bool UnPack(IntPtr buff, int offset, out long field); // 0x000000018D9D6B74-0x000000018D9D6BD8
		public bool Pack(IntPtr buff, int offset, ulong field); // 0x000000018D9D6994-0x000000018D9D69F8
		public bool UnPack(IntPtr buff, int offset, out ulong field); // 0x000000018D9D6EE8-0x000000018D9D6F60
		public bool Pack(IntPtr buff, int offset, float field); // 0x000000018D9D6930-0x000000018D9D6994
		public bool UnPack(IntPtr buff, int offset, out float field); // 0x000000018D9D6C58-0x000000018D9D6CBC
		public bool Pack(IntPtr buff, int offset, double field); // 0x000000018D9D68CC-0x000000018D9D6930
		public bool UnPack(IntPtr buff, int offset, out double field); // 0x000000018D9D6E84-0x000000018D9D6EE8
		public bool Pack(IntPtr buff, int offset, decimal field); // 0x000000018D9D6AC0-0x000000018D9D6B24
		public bool UnPack(IntPtr buff, int offset, out decimal field); // 0x000000018D9D6D30-0x000000018D9D6E84
		public bool IsStruct(System.Type type); // 0x00000001854C4A60-0x00000001854C4AB0
	}

	public abstract class DelegateBridgeBase : LuaBase // TypeDefIndex: 85441
	{
		// Fields
		private System.Type firstKey; // 0x20
		private Delegate firstValue; // 0x28
		private Dictionary<System.Type, Delegate> bindTo; // 0x30
		public int errorFuncRef; // 0x38
	
		// Properties
		public bool IsDispose { get; } // 0x00000001829D0800-0x00000001829D0810 
	
		// Constructors
		public DelegateBridgeBase(int reference, LuaEnv luaenv); // 0x00000001860B8020-0x00000001860B8060
	
		// Methods
		public bool TryGetDelegate(System.Type key, out Delegate value); // 0x00000001866DDB40-0x00000001866DDBB0
		public void AddDelegate(System.Type key, Delegate value); // 0x0000000186077620-0x00000001860776D0
		public virtual Delegate GetDelegateByType(System.Type type); // 0x0000000185829EC0-0x0000000185829ED0
	}

	public static class HotfixDelegateBridge // TypeDefIndex: 85442
	{
		// Methods
		public static bool xlua_get_hotfix_flag(int idx); // 0x000000018D9DA4F4-0x000000018D9DA584
		public static DelegateBridge Get(int idx); // 0x000000018D9DA2FC-0x000000018D9DA360
		public static void Set(int idx, DelegateBridge val); // 0x000000018D9DA360-0x000000018D9DA4F4
	}

	public class DelegateBridge : DelegateBridgeBase // TypeDefIndex: 85447
	{
		// Fields
		internal static DelegateBridge[] DelegateBridgeList; // 0x00
		public static bool Gen_Flag; // 0x08
		public static Func<DelegateBridge, System.Type, Delegate> GetDelegateTypeDelegate; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0<T1> // TypeDefIndex: 85443
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
		private sealed class __c__DisplayClass10_0<T1, T2> // TypeDefIndex: 85444
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
		private sealed class __c__DisplayClass12_0<T1, T2, T3> // TypeDefIndex: 85445
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
		private sealed class __c__DisplayClass14_0<T1, T2, T3, T4> // TypeDefIndex: 85446
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
		public DelegateBridge(int reference, LuaEnv luaenv); // 0x00000001878355A4-0x00000001878355AC
		static DelegateBridge(); // 0x000000018714D8C0-0x000000018714D970
	
		// Methods
		public void PCall(IntPtr L, int nArgs, int nResults, int errFunc); // 0x00000001851F9F10-0x00000001851F9FA0
		public override Delegate GetDelegateByType(System.Type type); // 0x00000001861D7F10-0x00000001861D7F70
		public void Action(); // 0x0000000185CE0810-0x0000000185CE0910
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

	public enum GenFlag // TypeDefIndex: 85448
	{
		No = 0,
		GCOptimize = 1
	}

	public class LuaCallCSharpAttribute : Attribute // TypeDefIndex: 85449
	{
		// Fields
		private GenFlag flag; // 0x10
	
		// Properties
		public GenFlag Flag { get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
	
		// Constructors
		public LuaCallCSharpAttribute(GenFlag flag = GenFlag.No /* Metadata: 0x02644F32 */); // 0x0000000182234E90-0x0000000182234EA0
	}

	public class CSharpCallLuaAttribute : Attribute // TypeDefIndex: 85450
	{
		// Constructors
		public CSharpCallLuaAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class BlackListAttribute : Attribute // TypeDefIndex: 85451
	{
		// Constructors
		public BlackListAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Flags]
	public enum OptimizeFlag // TypeDefIndex: 85452
	{
		Default = 0,
		PackAsTable = 1,
		Custom = 2
	}

	public class GCOptimizeAttribute : Attribute // TypeDefIndex: 85453
	{
		// Fields
		private OptimizeFlag flag; // 0x10
	
		// Properties
		public OptimizeFlag Flag { get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
	
		// Constructors
		public GCOptimizeAttribute(OptimizeFlag flag = OptimizeFlag.Default /* Metadata: 0x02644F36 */); // 0x0000000182234E90-0x0000000182234EA0
	}

	public class ReflectionUseAttribute : Attribute // TypeDefIndex: 85454
	{
		// Constructors
		public ReflectionUseAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class DoNotGenAttribute : Attribute // TypeDefIndex: 85455
	{
		// Constructors
		public DoNotGenAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class AdditionalPropertiesAttribute : Attribute // TypeDefIndex: 85456
	{
		// Constructors
		public AdditionalPropertiesAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Flags]
	public enum HotfixFlag // TypeDefIndex: 85457
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

	public class HotfixAttribute : Attribute // TypeDefIndex: 85458
	{
		// Fields
		private HotfixFlag flag; // 0x10
	
		// Properties
		public HotfixFlag Flag { get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
	
		// Constructors
		public HotfixAttribute(HotfixFlag e = HotfixFlag.Stateless /* Metadata: 0x02644F44 */); // 0x0000000182234E90-0x0000000182234EA0
	}

	[AttributeUsage(AttributeTargets.Delegate)]
	internal class HotfixDelegateAttribute : Attribute // TypeDefIndex: 85459
	{
		// Constructors
		public HotfixDelegateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class SysGenConfig // TypeDefIndex: 85460
	{
		// Properties
		[GCOptimize(OptimizeFlag.Default)]
		private static List<System.Type> GCOptimize { get; } // 0x000000018D9E010C-0x000000018D9E0300 
		[AdditionalProperties]
		private static Dictionary<System.Type, List<string>> AdditionalProperties { get; } // 0x000000018D9DFE88-0x000000018D9E010C 
	}

	public enum HotPatchParameterDirection : byte // TypeDefIndex: 85461
	{
		Value = 0,
		In = 1,
		Ref = 2,
		Out = 3
	}

	public sealed class HotPatchSignature // TypeDefIndex: 85462
	{
		// Fields
		[CompilerGenerated]
		private System.Type _ReturnType_k__BackingField; // 0x10
		[CompilerGenerated]
		private System.Type[] _ParameterTypes_k__BackingField; // 0x18
		[CompilerGenerated]
		private HotPatchParameterDirection[] _ParameterDirections_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _IsParamArray_k__BackingField; // 0x28
		[CompilerGenerated]
		private string _CanonicalName_k__BackingField; // 0x30
		[CompilerGenerated]
		private string _Id_k__BackingField; // 0x38
	
		// Properties
		public System.Type ReturnType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public System.Type[] ParameterTypes { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public HotPatchParameterDirection[] ParameterDirections { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public bool IsParamArray { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public string CanonicalName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public string Id { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
	
		// Constructors
		internal HotPatchSignature(System.Type returnType, System.Type[] parameterTypes, HotPatchParameterDirection[] parameterDirections, bool isParamArray, string canonicalName, string id); // 0x000000018D9DA298-0x000000018D9DA2FC
	}

	public static class HotPatchSignatureUtility // TypeDefIndex: 85463
	{
		// Fields
		private const string DELEGATE_TYPE_PREFIX = "__HotPatchDelegate_"; // Metadata: 0x02644F49
		private const string BRIDGE_METHOD_PREFIX = "__Gen_Delegate_Imp_"; // Metadata: 0x02644F5D
		private const ulong FNV_OFFSET_BASIS = 14695981039346656037; // Metadata: 0x02644F71
		private const ulong FNV_OFFSET_BASIS_REVERSE = 7809847782465536322; // Metadata: 0x02644F79
		private const ulong FNV_PRIME = 1099511628211; // Metadata: 0x02644F81
	
		// Methods
		public static HotPatchSignature Create(MethodBase method); // 0x000000018D9D9D2C-0x000000018D9DA13C
		public static HotPatchSignature CreateWithDirections(System.Type returnType, System.Type[] parameterTypes, HotPatchParameterDirection[] parameterDirections, bool isParamArray); // 0x000000018D9D98B8-0x000000018D9D9D2C
		public static HotPatchParameterDirection GetParameterDirection(ParameterInfo parameter); // 0x000000018D9DA1FC-0x000000018D9DA298
		public static string GetDelegateTypeName(string signatureId); // 0x000000018D9DA1C0-0x000000018D9DA1FC
		public static string GetDelegateTypeFullName(string signatureId); // 0x000000018D9DA178-0x000000018D9DA1C0
		public static string GetBridgeMethodName(string signatureId); // 0x000000018D9DA13C-0x000000018D9DA178
		private static string BuildCanonicalName(System.Type returnType, System.Type[] parameterTypes, HotPatchParameterDirection[] parameterDirections, bool isParamArray); // 0x000000018D9D958C-0x000000018D9D9774
		private static void AppendTypeName(StringBuilder builder, System.Type type); // 0x000000018D9D927C-0x000000018D9D958C
		private static void AppendSimpleTypeName(StringBuilder builder, System.Type type); // 0x000000018D9D9114-0x000000018D9D91E8
		private static void AppendString(StringBuilder builder, string value); // 0x000000018D9D91E8-0x000000018D9D927C
		private static string ComputeId(string canonicalName); // 0x000000018D9D9774-0x000000018D9D98B8
	}

	internal sealed class HotPatchGeneratedGlue // TypeDefIndex: 85464
	{
		// Fields
		[CompilerGenerated]
		private HotPatchSignature _Signature_k__BackingField; // 0x10
		[CompilerGenerated]
		private System.Type _DelegateType_k__BackingField; // 0x18
		[CompilerGenerated]
		private MethodInfo _WrapperMethod_k__BackingField; // 0x20
	
		// Properties
		public HotPatchSignature Signature { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public System.Type DelegateType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public MethodInfo WrapperMethod { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
		// Constructors
		public HotPatchGeneratedGlue(HotPatchSignature signature, System.Type delegateType, MethodInfo wrapperMethod); // 0x00000001854F5A50-0x00000001854F5A90
	}

	public static class HotPatchDelegateRegistry // TypeDefIndex: 85465
	{
		// Fields
		private static readonly object s_GeneratedGlueLock; // 0x00
		private static readonly Dictionary<string, HotPatchGeneratedGlue> s_GeneratedGlues; // 0x08
		private static Assembly s_GeneratedAssembly; // 0x10
		private static System.Type s_GeneratedBridgeType; // 0x18
	
		// Constructors
		static HotPatchDelegateRegistry(); // 0x00000001870A90C0-0x00000001870A91A0
	
		// Methods
		public static void RegisterGeneratedBridgeType(System.Type generatedBridgeType); // 0x0000000186BCBEA0-0x0000000186BCC1F0
		public static MethodBase[] ResolveMethods(System.Type type, string methodName, System.Type[] parameterTypes); // 0x000000018D9D86FC-0x000000018D9D89B4
		internal static HotPatchGeneratedGlue ResolveGeneratedGlue(MethodBase method); // 0x000000018D9D80B4-0x000000018D9D86FC
		private static bool ParameterTypesEqual(ParameterInfo[] parameterInfos, System.Type[] parameterTypes); // 0x000000018D9D7FEC-0x000000018D9D80B4
		private static string ValidateGeneratedGlue(HotPatchSignature signature, System.Type delegateType, MethodInfo wrapperMethod); // 0x000000018D9D89B4-0x000000018D9D8C6C
		private static string ValidateSignature(HotPatchSignature signature, System.Type returnType, ParameterInfo[] parameterInfos, int offset); // 0x000000018D9D8C6C-0x000000018D9D9114
		private static InvalidOperationException CreateResolutionException(MethodBase method, HotPatchSignature signature, string reason); // 0x000000018D9D7E3C-0x000000018D9D7FEC
	}

	public static class HotPatchBridge // TypeDefIndex: 85466
	{
		// Fields
		private static readonly object s_ApiLock; // 0x00
		private static readonly Dictionary<MethodBase, Delegate> s_LocalHandlers; // 0x08
		private static bool s_ApiResolved; // 0x10
		private static MethodInfo s_SetPatchMethod; // 0x18
		private static MethodInfo s_ClearPatchMethod; // 0x20
		private static string s_ResolutionError; // 0x28
	
		// Constructors
		static HotPatchBridge(); // 0x000000018D9D7D68-0x000000018D9D7E3C
	
		// Methods
		private static void ResolveApi(); // 0x000000018D9D752C-0x000000018D9D7A78
		private static void EnsureApiAvailable(); // 0x000000018D9D73B0-0x000000018D9D74A8
		public static bool IsAvailable(); // 0x000000018D9D74A8-0x000000018D9D752C
		public static void SetPatch(MethodBase method, Delegate handler); // 0x000000018D9D7A78-0x000000018D9D7D68
		public static void ClearPatch(MethodBase method); // 0x000000018D9D7178-0x000000018D9D7270
		public static void ClearPatches(IEnumerable<MethodBase> methods); // 0x000000018D9D7270-0x000000018D9D73B0
		public static void ClearAllLocalPatches(); // 0x000000018D9D7098-0x000000018D9D7178
	}

	public class InternalGlobals // TypeDefIndex: 85469
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
		public delegate bool TryArrayGet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int index); // TypeDefIndex: 85467; 0x00000001812083C0-0x00000001812083E0
	
		public delegate bool TryArraySet(System.Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx); // TypeDefIndex: 85468; 0x0000000181256340-0x0000000181256360
	
		// Constructors
		public InternalGlobals(); // 0x0000000186805BA0-0x0000000186805BB0
		static InternalGlobals(); // 0x0000000186C16DC0-0x0000000186C172E0
	}

	public abstract class LuaBase : IDisposable // TypeDefIndex: 85470
	{
		// Fields
		public bool disposed; // 0x10
		public readonly int luaReference; // 0x14
		public readonly LuaEnv luaEnv; // 0x18
	
		// Constructors
		public LuaBase(int reference, LuaEnv luaenv); // 0x00000001860B8060-0x00000001860B80C0
	
		// Methods
		~LuaBase(); // 0x0000000185720FE0-0x0000000185721090
		public void Dispose(); // 0x0000000185722430-0x0000000185722790
		public virtual void Dispose(bool disposeManagedResources); // 0x00000001857227D0-0x0000000185722B20
		public override bool Equals(object o); // 0x000000018D9DA6F0-0x000000018D9DA828
		public override int GetHashCode(); // 0x000000018D9DA828-0x000000018D9DA8DC
		public virtual void push(IntPtr L); // 0x000000018D9DA8DC-0x000000018D9DA930
	}

	public struct lua_debug // TypeDefIndex: 85471
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

	public struct lua_state // TypeDefIndex: 85472
	{
		// Fields
		public IntPtr ptr; // 0x00
		public byte byte1; // 0x08
		public byte byte2; // 0x09
		public byte status; // 0x0A
		public byte allowhook; // 0x0B
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int lua_Hook(IntPtr L, ref lua_debug ar); // TypeDefIndex: 85473; 0x00000001859B7730-0x00000001859B7740

	public static class LuaDeadLoopCheck // TypeDefIndex: 85475
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
		private sealed class __c // TypeDefIndex: 85474
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Stopwatch> __9__7_0; // 0x08
			public static Action<Stopwatch> __9__7_1; // 0x10
			public static Action<Stopwatch> __9__7_2; // 0x18
	
			// Constructors
			static __c(); // 0x000000018D9E0DA8-0x000000018D9E0E0C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Stopwatch _EnableCheck_b__7_0(); // 0x000000018D9E06E0-0x000000018D9E071C
			internal void _EnableCheck_b__7_1(Stopwatch sw); // 0x000000018D9E071C-0x000000018D9E0748
			internal void _EnableCheck_b__7_2(Stopwatch sw); // 0x000000018D9E0748-0x000000018D9E0768
		}
	
		// Methods
		public static void EnableCheck(IntPtr L); // 0x000000018D9DBAC8-0x000000018D9DBFA4
		[AOT.MonoPInvokeCallback(typeof(XLua.lua_Hook))]
		public static int LuaHook(IntPtr L, ref lua_debug ar); // 0x000000018D9DBFA4-0x000000018D9DC20C
		public static void DisableCheck(IntPtr L); // 0x000000018D9DBA90-0x000000018D9DBAC8
		public static void PushTime(); // 0x00000001851F9FA0-0x00000001851FA0A0
		public static void PopTime(); // 0x000000018605B540-0x000000018605B650
		public static void CheckDeadLoop(); // 0x000000018D9DB81C-0x000000018D9DBA90
	}

	public interface ILoadLuaProxy // TypeDefIndex: 85476
	{
		// Methods
		byte[] LoadLua(string name);
	}

	public class LoadLuaProxyModule // TypeDefIndex: 85477
	{
		// Fields
		private static ILoadLuaProxy s_loadLuaProxy; // 0x00
	
		// Constructors
		public LoadLuaProxyModule(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void RegisterProxy(ILoadLuaProxy loadLuaProxy); // 0x000000018D9DA5BC-0x000000018D9DA60C
		public static ILoadLuaProxy GetLoadLuaProxy(); // 0x000000018D9DA584-0x000000018D9DA5BC
	}

	public class LuaEnv : IDisposable // TypeDefIndex: 85480
	{
		// Fields
		public const string CSHARP_NAMESPACE = "xlua_csharp_namespace"; // Metadata: 0x02644FAE
		public const string MAIN_SHREAD = "xlua_main_thread"; // Metadata: 0x02644FC4
		private LuaMultithreadingGC m_luaMultithreadingGC; // 0x10
		public static bool ENABLE_MULTITHREAD_GC; // 0x00
		public bool isQuittingApplication; // 0x18
		public IntPtr rawL; // 0x20
		private LuaTable _G; // 0x28
		public ObjectTranslator translator; // 0x30
		public int errorFuncRef; // 0x38
		private const int LIB_VERSION_EXPECT = 105; // Metadata: 0x02644FD5
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
		public IntPtr L { get; } // 0x000000018511B770-0x000000018511B790 
		public LuaTable Global { get; } // 0x0000000182262130-0x0000000182262140 
		public int GcPause { get; set; } // 0x000000018D9DC8C0-0x000000018D9DC940 0x000000018D9DC9C0-0x000000018D9DCA20
		public int GcStepmul { get; set; } // 0x000000018D9DC940-0x000000018D9DC9C0 0x000000018D9DCA20-0x000000018D9DCA80
		public int Memroy { get; } // 0x0000000185151F80-0x0000000185151FD0 
	
		// Nested types
		internal struct GCAction // TypeDefIndex: 85478
		{
			// Fields
			public int Reference; // 0x00
			public bool IsDelegate; // 0x04
		}
	
		public delegate byte[] CustomLoader(ref string filepath); // TypeDefIndex: 85479; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		public LuaEnv(); // 0x0000000185C4ABE0-0x0000000185C4B870
		static LuaEnv(); // 0x00000001871E9100-0x00000001871E9170
	
		// Methods
		public bool IsEnableMultithreadGC(); // 0x0000000186ACC9A0-0x0000000186ACCA70
		public bool IsLuaGCing(); // 0x00000001851F9EF0-0x00000001851F9F10
		public bool AddLuaEventAfterGCDo(UnityAction action); // 0x0000000186D2E1F0-0x0000000186D2E220
		public void RemoveLuaEventAfterGCDo(UnityAction action); // 0x000000018D9DC6C0-0x000000018D9DC6D4
		public void AddOnceLuaEventAfterGCDo(UnityAction action); // 0x000000018709C830-0x000000018709C870
		public void CriticalLuaCallWaitLuaGC(); // 0x000000018D9DC22C-0x000000018D9DC288
		public void MainThreadWait(); // 0x000000018D9DC5A8-0x000000018D9DC5BC
		public void StopMultiGC(); // 0x000000018D9DC778-0x000000018D9DC7A8
		public static void AddIniter(Action<LuaEnv, ObjectTranslator> initer); // 0x0000000186BCBC20-0x0000000186BCBD70
		public T LoadString<T>(byte[] chunk, string chunkName = "chunk" /* Metadata: 0x02644F89 */, LuaTable env = null);
		public T LoadString<T>(string chunk, string chunkName = "chunk" /* Metadata: 0x02644F8F */, LuaTable env = null);
		public LuaFunction LoadString(string chunk, string chunkName = "chunk" /* Metadata: 0x02644F95 */, LuaTable env = null); // 0x000000018D9DC538-0x000000018D9DC5A8
		public object[] DoString(byte[] chunk, string chunkName = "chunk" /* Metadata: 0x02644F9B */, LuaTable env = null); // 0x0000000185C4A020-0x0000000185C4A190
		public object[] DoString(string chunk, string chunkName = "chunk" /* Metadata: 0x02644FA1 */, LuaTable env = null); // 0x0000000185C49FB0-0x0000000185C4A020
		public object[] DoFile(string luaFile, string chunkName = "chunk" /* Metadata: 0x02644FA7 */, LuaTable env = null); // 0x0000000185C49D50-0x0000000185C49E00
		public object[] DoFile(string luaFile, LuaTable env = null); // 0x0000000187839E68-0x0000000187839E88
		public object[] CallGlobalFunction(string funcName); // 0x0000000186C55B60-0x0000000186C55BE0
		public object[] CallGlobalFunction<T0>(string funcName, T0 param0);
		public void SetGlobalTable<K, V>(K key, V value);
		public V GetGlobalTable<K, V>(K key);
		public void InitCacheString(); // 0x0000000185C496B0-0x0000000185C498D0
		public string TryGetLuaString(IntPtr p); // 0x0000000185C15780-0x0000000185C158A0
		public void RefString(IntPtr L, IntPtr strPoint, int index, string ss); // 0x00000001854C0C20-0x00000001854C0DE0
		public void ReleaseStringCache(bool dispose = true /* Metadata: 0x02644FAD */); // 0x0000000185C495E0-0x0000000185C496B0
		public void AutoFreeStringCache(); // 0x000000018559EF90-0x000000018559EFB0
		private void AddSearcher(lua_CSFunction searcher, int index); // 0x0000000185C4BAD0-0x0000000185C4BC70
		public void Alias(System.Type type, string alias); // 0x000000018D9DC20C-0x000000018D9DC22C
		private static bool ObjectValidCheck(object obj); // 0x0000000185D65160-0x0000000185D65200
		public void ClearAllUserdata(); // 0x00000001861DA920-0x00000001861DA960
		public void CleanTick(); // 0x000000018559F100-0x000000018559F400
		public void GC(); // 0x000000018D9DC4CC-0x000000018D9DC4D4
		public LuaTable NewTable(); // 0x000000018D9DC5BC-0x000000018D9DC6C0
		public void WaitForGCComplete(); // 0x000000018D9DC8B8-0x000000018D9DC8C0
		public void Dispose(); // 0x000000018D9DC3E8-0x000000018D9DC478
		public virtual void Dispose(bool dispose); // 0x000000018D9DC288-0x000000018D9DC3E8
		public void ThrowExceptionFromError(int oldTop); // 0x000000018D9DC7A8-0x000000018D9DC8B8
		internal void equeueGCAction(GCAction action); // 0x0000000185722FD0-0x0000000185723320
		public void AddLoader(CustomLoader loader); // 0x00000001871F0410-0x00000001871F0470
		public void AddBuildin(string name, lua_CSFunction initer); // 0x0000000185C4AA70-0x0000000185C4AB10
		public void FullGc(); // 0x000000018D9DC478-0x000000018D9DC4CC
		public void StopGc(); // 0x000000018D9DC728-0x000000018D9DC778
		public void RestartGc(); // 0x000000018D9DC6D4-0x000000018D9DC728
		public bool GcStep(int data); // 0x000000018D9DC4D4-0x000000018D9DC538
	}

	[Serializable]
	public class LuaException : Exception // TypeDefIndex: 85481
	{
		// Constructors
		public LuaException(string message); // 0x000000018D9DCA80-0x000000018D9DCADC
	}

	public class LuaFunction : LuaBase // TypeDefIndex: 85484
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0<T> // TypeDefIndex: 85482
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
		private sealed class __c__DisplayClass5_0<T1, T2> // TypeDefIndex: 85483
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
		public LuaFunction(int reference, LuaEnv luaenv); // 0x0000000187834C94-0x0000000187834C9C
	
		// Methods
		public void Action<T>(T a);
		private void ActionAfterGC<T>(T a);
		public TResult Func<T, TResult>(T a);
		public void Action<T1, T2>(T1 a1, T2 a2);
		private void ActionAfterGC<T1, T2>(T1 a1, T2 a2);
		public TResult Func<T1, T2, TResult>(T1 a1, T2 a2);
		public object[] Call(object[] args, System.Type[] returnTypes); // 0x00000001851F9330-0x00000001851F95F0
		public object[] Call(params object[] args); // 0x0000000187835D04-0x0000000187835D10
		public T Cast<T>();
		public void SetEnv(LuaTable env); // 0x000000018D9DCADC-0x000000018D9DCB94
		public override void push(IntPtr L); // 0x00000001871F03B0-0x00000001871F0410
		public override string ToString(); // 0x000000018D9DCB94-0x000000018D9DCBDC
	}

	public class LuaTable : LuaBase // TypeDefIndex: 85487
	{
		// Properties
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[string field] { get => default; set {} } // 0x000000018D9DD77C-0x000000018D9DD7C4 0x000000018D9DD8F8-0x000000018D9DD950
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[object field] { get => default; set {} } // 0x000000018D9DD7C4-0x000000018D9DD80C 0x000000018D9DD8A0-0x000000018D9DD8F8
		public int Length { get; } // 0x000000018D9DD80C-0x000000018D9DD8A0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetKeys_d__15 : IEnumerable<object>, IEnumerator<object> // TypeDefIndex: 85485
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetKeys_d__15(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D9E0490-0x000000018D9E05FC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D9E0694-0x000000018D9E06E0
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator(); // 0x000000018D9E05FC-0x000000018D9E068C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D9E068C-0x000000018D9E0694
		}
	
		[CompilerGenerated]
		private sealed class _GetKeys_d__16<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 85486
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
		public LuaTable(int reference, LuaEnv luaenv); // 0x0000000187834C94-0x0000000187834C9C
	
		// Methods
		public void Get<TKey, TValue>(TKey key, out ref TValue value);
		public bool ContainsKey<TKey>(TKey key);
		public void Set<TKey, TValue>(TKey key, TValue value);
		public T GetInPath<T>(string path);
		public void SetInPath<T>(string path, T val);
		public void ForEach<TKey, TValue>(Action<TKey, TValue> action);
		[IteratorStateMachine(typeof(_GetKeys_d__15))]
		public IEnumerable GetKeys(); // 0x000000018D9DD5F4-0x000000018D9DD664
		[IteratorStateMachine(typeof(_GetKeys_d__16<T>))]
		public IEnumerable<T> GetKeys<T>();
		public T Get<T>(object key);
		public TValue Get<TKey, TValue>(TKey key);
		public TValue Get<TValue>(string key);
		public void SetMetaTable(LuaTable metaTable); // 0x000000018D9DD664-0x000000018D9DD734
		public T Cast<T>();
		public override void push(IntPtr L); // 0x00000001863227F0-0x00000001863229A0
		public override string ToString(); // 0x000000018D9DD734-0x000000018D9DD77C
		public ObjectTranslator GetTranslator(); // 0x0000000185A82080-0x0000000185A82100
	}

	public interface IOverloadMethodWrap // TypeDefIndex: 85488
	{
		// Properties
		bool InitedForDelegateCall { get; }
		bool HasDefalutValue { get; }
	
		// Methods
		int Call(IntPtr L, ObjectTranslator translator);
		bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x02644FD7 */);
	}

	public class OverloadMethodWrapBase // TypeDefIndex: 85489
	{
		// Fields
		protected ObjectTranslator translator; // 0x10
		protected MethodBase method; // 0x18
	
		// Constructors
		public OverloadMethodWrapBase(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static IOverloadMethodWrap CreateMethodWrap(ObjectTranslator translator, MethodBase method, System.Type target); // 0x000000018536C1C0-0x000000018536C290
	}

	public class OverloadMethodWrapForDelegate : OverloadMethodWrapBase, IOverloadMethodWrap // TypeDefIndex: 85490
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
		public bool InitedForDelegateCall { get; } // 0x0000000186269AD0-0x0000000186269AE0 
		public List<System.Type> CastTypes { get; } // 0x000000018225E800-0x000000018225E810 
		public int OptionParamCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
		public object[] DefalutValue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public bool HasDefalutValue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
		public bool[] OutParamFlags { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
	
		// Constructors
		public OverloadMethodWrapForDelegate(MethodInfo method); // 0x000000018536C160-0x000000018536C1C0
	
		// Methods
		public static OverloadMethodWrapForDelegate TryGetWrapForDelegate(MethodInfo method); // 0x000000018536C8C0-0x000000018536CE80
		public void InitForDefaultValue(); // 0x00000001865177F0-0x0000000186517A10
		public int Call(IntPtr L, ObjectTranslator translator); // 0x0000000185118540-0x0000000185119F40
		public bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x02644FD8 */); // 0x00000001851A4410-0x00000001851A4420
	}

	public class OverloadMethodWrapForReflection : OverloadMethodWrapBase, IOverloadMethodWrap // TypeDefIndex: 85491
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
		public bool InitedForDelegateCall { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public bool HasDefalutValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public OverloadMethodWrapForReflection(System.Type target, MethodBase methodInfo); // 0x00000001867FE060-0x00000001867FE0A0
	
		// Methods
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters); // 0x0000000185A361B0-0x0000000185A36A60
		public int Call(IntPtr L, ObjectTranslator translator); // 0x0000000185119F40-0x000000018511A850
		public bool Check(IntPtr L, bool haveOverload = false /* Metadata: 0x02644FD9 */); // 0x000000018511AC00-0x000000018511AC30
		public bool Check(IntPtr L); // 0x0000000185FFBC80-0x0000000185FFBE00
		public bool CheckForNoOverride(IntPtr L); // 0x000000018511A8B0-0x000000018511AC00
	}

	public class OverloadMethodWrap // TypeDefIndex: 85492
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
		public bool InitedForDelegateCall { get; } // 0x000000018B61C9A4-0x000000018B61C9B0 
		public MethodBase Method { get; } // 0x000000018225E800-0x000000018225E810 
		public List<System.Type> CastTypes { get; } // 0x0000000182986470-0x0000000182986480 
		public int OptionParamCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271AC0-0x0000000182271AD0 0x0000000182271B20-0x0000000182271B30
		public object[] DefalutValue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
		public bool IsInited { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E110-0x000000018225E120 0x000000018225E120-0x000000018225E130
		public bool HasDefalutValue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723E5E0-0x000000018723E5F0 0x000000018723E600-0x000000018723E610
	
		// Constructors
		public OverloadMethodWrap(ObjectTranslator translator, System.Type targetType, MethodBase method); // 0x000000018D9DFE3C-0x000000018D9DFE88
	
		// Methods
		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters); // 0x000000018D9DF398-0x000000018D9DFE3C
		public void InitForDefaultValue(); // 0x000000018D9DEAF4-0x000000018D9DEDAC
		public void InitForDelegateCallMethod(); // 0x000000018D9DEDAC-0x000000018D9DF398
		public int Call(IntPtr L); // 0x000000018D9DE318-0x000000018D9DEAF4
		public int CallForDelegate(IntPtr L, ObjectTranslator translator); // 0x000000018D9DE19C-0x000000018D9DE318
	}

	public class MethodWrap // TypeDefIndex: 85493
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
		public MethodWrap(string methodName, List<MethodBase> overloads, System.Type targetType, bool forceCheck); // 0x00000001858C8FB0-0x00000001858C90F0
	
		// Methods
		private void _InitForDelegateCall(); // 0x0000000186269960-0x0000000186269AD0
		public int Call(IntPtr L); // 0x0000000185117F80-0x0000000185118540
	}

	public class MethodWrapsCache // TypeDefIndex: 85497
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
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 85494
		{
			// Fields
			public MethodWrapsCache __4__this; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetConstructorWrap_b__0(IntPtr L); // 0x00000001870B2460-0x00000001870B24C0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_1 // TypeDefIndex: 85495
		{
			// Fields
			public lua_CSFunction ctor; // 0x10
			public __c__DisplayClass11_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass11_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetConstructorWrap_b__1(IntPtr L); // 0x0000000185B78E10-0x0000000185B78EA0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 85496
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
			public __c__DisplayClass15_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetEventWrap_b__0(IntPtr L); // 0x000000018D9E082C-0x000000018D9E0D44
		}
	
		// Constructors
		static MethodWrapsCache(); // 0x0000000186EB7820-0x0000000186EB78B0
		public MethodWrapsCache(ObjectTranslator translator, ObjectCheckers objCheckers, ObjectCasters objCasters); // 0x0000000186EB78B0-0x0000000186EB79F0
	
		// Methods
		public static void AddCodeGenConstructor(System.Type type, lua_CSFunction lua_CSFunction); // 0x000000018D9DD950-0x000000018D9DDA50
		public static void ClearCodeGenConstructorMap(); // 0x000000018D9DDA50-0x000000018D9DDAB4
		public lua_CSFunction GetConstructorWrap(System.Type type); // 0x00000001854C2A20-0x00000001854C2D70
		public lua_CSFunction GetMethodWrap(System.Type type, string methodName); // 0x000000018D9DDC0C-0x000000018D9DDE58
		public lua_CSFunction GetMethodWrapInCache(System.Type type, string methodName); // 0x000000018D9DDAB4-0x000000018D9DDC0C
		public lua_CSFunction GetDelegateWrap(System.Type type); // 0x0000000185B78BF0-0x0000000185B78E10
		public lua_CSFunction GetEventWrap(System.Type type, string eventName); // 0x0000000185C492F0-0x0000000185C495C0
		public MethodWrap _GenMethodWrap(System.Type type, string methodName, IEnumerable<MemberInfo> methodBases, bool forceCheck = false /* Metadata: 0x02644FDA */); // 0x00000001858C8B20-0x00000001858C8F70
		private static bool tryMakeGenericMethod(ref MethodBase method); // 0x000000018D9DDE58-0x000000018D9DE064
	}

	public delegate bool ObjectCheck(IntPtr L, int idx); // TypeDefIndex: 85498; 0x00000001859B7730-0x00000001859B7740

	public delegate object ObjectCast(IntPtr L, int idx, object target); // TypeDefIndex: 85499; 0x00000001811DF7F0-0x00000001811DF810

	public class ObjectCheckers // TypeDefIndex: 85502
	{
		// Fields
		private Dictionary<System.Type, ObjectCheck> checkersMap; // 0x10
		private ObjectTranslator translator; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 85500
		{
			// Fields
			public ObjectCheckers __4__this; // 0x10
			public System.Type type; // 0x18
			public ObjectCheck fixTypeCheck; // 0x20
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _genChecker_b__0(IntPtr L, int idx); // 0x000000018511D6F0-0x000000018511D7E0
			internal bool _genChecker_b__1(IntPtr L, int idx); // 0x000000018645AF90-0x000000018645B010
			internal bool _genChecker_b__2(IntPtr L, int idx); // 0x00000001861B8060-0x00000001861B80E0
			internal bool _genChecker_b__3(IntPtr L, int idx); // 0x000000018707C940-0x000000018707C9E0
			internal bool _genChecker_b__4(IntPtr L, int idx); // 0x0000000186443D40-0x0000000186443DE0
			internal bool _genChecker_b__5(IntPtr L, int idx); // 0x000000018625C330-0x000000018625C400
			internal bool _genChecker_b__6(IntPtr L, int idx); // 0x0000000186607080-0x0000000186607100
			internal bool _genChecker_b__7(IntPtr L, int idx); // 0x000000018511DB60-0x000000018511DC00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 85501
		{
			// Fields
			public ObjectCheck oc; // 0x10
	
			// Constructors
			public __c__DisplayClass15_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _genNullableChecker_b__0(IntPtr L, int idx); // 0x00000001870788B0-0x0000000187078930
		}
	
		// Constructors
		public ObjectCheckers(ObjectTranslator translator); // 0x00000001863B4BA0-0x00000001863B5500
	
		// Methods
		private static bool objectCheck(IntPtr L, int idx); // 0x00000001851A4410-0x00000001851A4420
		private bool luaTableCheck(IntPtr L, int idx); // 0x000000018511F100-0x000000018511F1E0
		private bool numberCheck(IntPtr L, int idx); // 0x00000001861DBEE0-0x00000001861DBF50
		private bool decimalCheck(IntPtr L, int idx); // 0x000000018D9E36D0-0x000000018D9E3750
		private bool strCheck(IntPtr L, int idx); // 0x000000018511EC80-0x000000018511ED10
		private bool bytesCheck(IntPtr L, int idx); // 0x000000018D9E35F0-0x000000018D9E36D0
		private bool boolCheck(IntPtr L, int idx); // 0x0000000186309F30-0x0000000186309FA0
		private bool int64Check(IntPtr L, int idx); // 0x0000000186458900-0x0000000186458950
		private bool uint64Check(IntPtr L, int idx); // 0x0000000185FBC840-0x0000000185FBC8E0
		private bool luaFunctionCheck(IntPtr L, int idx); // 0x0000000186D28D70-0x0000000186D28E20
		private bool intptrCheck(IntPtr L, int idx); // 0x000000018D9E3750-0x000000018D9E37A4
		private ObjectCheck genChecker(System.Type type); // 0x00000001863B5EB0-0x00000001863B6240
		public ObjectCheck genNullableChecker(ObjectCheck oc); // 0x00000001863B49D0-0x00000001863B4A80
		public void AddChecker(System.Type type, ObjectCheck oc); // 0x00000001863B4960-0x00000001863B49D0
		public ObjectCheck GetChecker(System.Type type); // 0x000000018511D270-0x000000018511D420
	}

	public class ObjectCasters // TypeDefIndex: 85507
	{
		// Fields
		private Dictionary<System.Type, ObjectCast> castersMap; // 0x10
		private ObjectTranslator translator; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 85503
		{
			// Fields
			public ObjectCasters __4__this; // 0x10
			public System.Type type; // 0x18
			public ObjectCast fixTypeGetter; // 0x20
	
			// Constructors
			public __c__DisplayClass23_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _genCaster_b__0(IntPtr L, int idx, object target); // 0x0000000185C4D3D0-0x0000000185C4D4F0
			internal object _genCaster_b__1(IntPtr L, int idx, object target); // 0x0000000185C4D630-0x0000000185C4D6F0
			internal object _genCaster_b__2(IntPtr L, int idx, object target); // 0x000000018D9E8CB8-0x000000018D9E8D78
			internal object _genCaster_b__3(IntPtr L, int idx, object target); // 0x0000000185C4BEA0-0x0000000185C4BF80
			internal object _genCaster_b__4(IntPtr L, int idx, object target); // 0x0000000185C4D560-0x0000000185C4D630
			internal object _genCaster_b__5(IntPtr L, int idx, object target); // 0x0000000185C4CA90-0x0000000185C4CD90
			internal object _genCaster_b__6(IntPtr L, int idx, object target); // 0x0000000185C4D7B0-0x0000000185C5B140
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_1 // TypeDefIndex: 85504
		{
			// Fields
			public System.Type elementType; // 0x10
			public ObjectCast elementCaster; // 0x18
			public __c__DisplayClass23_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass23_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _genCaster_b__7(IntPtr L, int idx, object target); // 0x0000000185C4CD90-0x0000000185C4D3D0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_2 // TypeDefIndex: 85505
		{
			// Fields
			public System.Type keyType; // 0x10
			public System.Type valueType; // 0x18
			public ObjectCast keyCaster; // 0x20
			public ObjectCast valueCaster; // 0x28
			public __c__DisplayClass23_0 CS___8__locals2; // 0x30
	
			// Constructors
			public __c__DisplayClass23_2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _genCaster_b__8(IntPtr L, int idx, object target); // 0x000000018D9E8D78-0x000000018D9E906C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 85506
		{
			// Fields
			public ObjectCast oc; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _genNullableCaster_b__0(IntPtr L, int idx, object target); // 0x0000000187078310-0x00000001870783A0
		}
	
		// Constructors
		public ObjectCasters(ObjectTranslator translator); // 0x00000001863B5500-0x00000001863B5EB0
	
		// Methods
		private static object charCaster(IntPtr L, int idx, object target); // 0x000000018D9E31C0-0x000000018D9E3230
		private static object sbyteCaster(IntPtr L, int idx, object target); // 0x000000018D9E34A0-0x000000018D9E3510
		private static object byteCaster(IntPtr L, int idx, object target); // 0x000000018D9E3150-0x000000018D9E31C0
		private static object shortCaster(IntPtr L, int idx, object target); // 0x000000018D9E3510-0x000000018D9E3580
		private static object ushortCaster(IntPtr L, int idx, object target); // 0x000000018D9E3580-0x000000018D9E35F0
		private static object intCaster(IntPtr L, int idx, object target); // 0x00000001865CD6C0-0x00000001865CD9A0
		private static object uintCaster(IntPtr L, int idx, object target); // 0x0000000185D375D0-0x0000000185D37620
		private static object longCaster(IntPtr L, int idx, object target); // 0x00000001854E85B0-0x00000001854E8610
		private static object ulongCaster(IntPtr L, int idx, object target); // 0x0000000185D36B10-0x0000000185D36B70
		private static object getDouble(IntPtr L, int idx, object target); // 0x000000018D9E33C0-0x000000018D9E3430
		private static object floatCaster(IntPtr L, int idx, object target); // 0x0000000185D36A50-0x0000000185D36AB0
		private object decimalCaster(IntPtr L, int idx, object target); // 0x000000018D9E3230-0x000000018D9E32C0
		private static object getBoolean(IntPtr L, int idx, object target); // 0x0000000185D36AB0-0x0000000185D36B10
		private static object getString(IntPtr L, int idx, object target); // 0x000000018630AD80-0x000000018630ADC0
		private object getBytes(IntPtr L, int idx, object target); // 0x000000018D9E32C0-0x000000018D9E33C0
		private object getIntptr(IntPtr L, int idx, object target); // 0x000000018D9E3430-0x000000018D9E34A0
		private object getObject(IntPtr L, int idx, object target); // 0x0000000185C4BD30-0x0000000185C4BEA0
		private object getLuaTable(IntPtr L, int idx, object target); // 0x000000018511EEC0-0x000000018511F090
		private object getLuaFunction(IntPtr L, int idx, object target); // 0x00000001851F8B90-0x00000001851F8D00
		public void AddCaster(System.Type type, ObjectCast oc); // 0x00000001863B4B30-0x00000001863B4BA0
		private ObjectCast genCaster(System.Type type); // 0x00000001863B62D0-0x00000001863B6750
		private ObjectCast genNullableCaster(ObjectCast oc); // 0x00000001863B4A80-0x00000001863B4B30
		public ObjectCast GetCaster(System.Type type); // 0x000000018511ED10-0x000000018511EEC0
	}

	public class ObjectPool // TypeDefIndex: 85509
	{
		// Fields
		private const int LIST_END = -1; // Metadata: 0x02644FDB
		private const int ALLOCED = -2; // Metadata: 0x02644FDC
		private Slot[] list; // 0x10
		private int freelist; // 0x18
		private int count; // 0x1C
		private List<object> needCleanImmediately; // 0x20
	
		// Properties
		public object this[int i] { get => default; } // 0x000000018D9E37FC-0x000000018D9E3830 
	
		// Nested types
		private struct Slot // TypeDefIndex: 85508
		{
			// Fields
			public int next; // 0x00
			public object obj; // 0x08
	
			// Constructors
			public Slot(int next, object obj); // 0x000000018783C19C-0x000000018783C1AC
		}
	
		// Constructors
		public ObjectPool(); // 0x0000000187106220-0x00000001871062D0
	
		// Methods
		public void AddToNeedCleanImmediately(object obj); // 0x0000000185A81270-0x0000000185A812A0
		public void Clear(); // 0x000000018D9E37A4-0x000000018D9E37FC
		private void extend_capacity(); // 0x0000000185B8EB20-0x0000000185B8EBE0
		public int Add(object obj); // 0x0000000185115F20-0x0000000185116340
		public bool TryGetValue(int index, out object obj); // 0x0000000185116ED0-0x0000000185117010
		public object Get(int index); // 0x0000000185115DC0-0x0000000185115E00
		public object Remove(int index); // 0x0000000185116340-0x0000000185116660
		public object Replace(int index, object o); // 0x0000000185115A60-0x0000000185115B80
		public int Check(int check_pos, int max_check, Func<object, bool> checker, Dictionary<object, int> reverse_map); // 0x0000000185116660-0x0000000185116BC0
		public void ClearAllUserdata(Func<object, bool> checker, Dictionary<object, int> reverse_map); // 0x00000001861DA960-0x00000001861DAA20
	}

	internal class ReferenceEqualsComparer : IEqualityComparer<object> // TypeDefIndex: 85510
	{
		// Constructors
		public ReferenceEqualsComparer(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public new bool Equals(object o1, object o2); // 0x0000000185BF2100-0x0000000185BF2110
		public int GetHashCode(object obj); // 0x0000000187251670-0x0000000187251680
	}

	public class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 85511
	{
		// Fields
		private System.Type type; // 0x10
	
		// Constructors
		public MonoPInvokeCallbackAttribute(System.Type t); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public enum LuaTypes // TypeDefIndex: 85512
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

	public enum LuaGCOptions // TypeDefIndex: 85513
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

	public enum LuaThreadStatus // TypeDefIndex: 85514
	{
		LUA_RESUME_ERROR = -1,
		LUA_OK = 0,
		LUA_YIELD = 1,
		LUA_ERRRUN = 2,
		LUA_ERRSYNTAX = 3,
		LUA_ERRMEM = 4,
		LUA_ERRERR = 5
	}

	public class LuaIndexes // TypeDefIndex: 85515
	{
		// Properties
		public static int LUA_REGISTRYINDEX { get; set; } // 0x000000018511B810-0x000000018511B850 0x00000001871F9740-0x00000001871F97A0
	
		// Constructors
		public LuaIndexes(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class ObjectTranslator // TypeDefIndex: 85537
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
		public ObjectPool Pools { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Nested types
		public enum LOGLEVEL // TypeDefIndex: 85516
		{
			NO = 0,
			INFO = 1,
			WARN = 2,
			ERROR = 3
		}
	
		private struct EnumerableWrapper // TypeDefIndex: 85517
		{
			// Fields
			public int Index; // 0x00
			public IList CurList; // 0x08
			public IEnumerator Enumerator; // 0x10
			public static Stack<EnumerableWrapper> enumerableStack; // 0x00
	
			// Constructors
			static EnumerableWrapper(); // 0x000000018D9E26B0-0x000000018D9E273C
	
			// Methods
			[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
			public static int ListCsPairs(IntPtr L); // 0x0000000185C4C8D0-0x0000000185C4CA70
			[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
			public static int DicCsPairs(IntPtr L); // 0x0000000185C3E300-0x0000000185C41390
			[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
			public static int IEnumerableCsPairs(IntPtr L); // 0x00000001860ADF20-0x00000001860AE070
		}
	
		private struct FStructWrap<T> // TypeDefIndex: 85518
		{
			// Fields
			public T value;
	
			// Methods
			public IntPtr GetPtr();
		}
	
		private struct CSharpStructInLua // TypeDefIndex: 85519
		{
			// Fields
			public int fake_id; // 0x00
			public uint len; // 0x04
			public IntPtr ptr; // 0x08
		}
	
		public struct LuaCSFunctionPtr // TypeDefIndex: 85520
		{
			// Fields
			public IntPtr ptr; // 0x00
			public object target; // 0x08
		}
	
		public delegate ValueTuple<IntPtr, T1> GetDelegatePointer<T1>(Delegate d); // TypeDefIndex: 85521; 0x00000000-0x00000000
	
		public delegate void PushCSObject(IntPtr L, object obj); // TypeDefIndex: 85522; 0x00000001859B7730-0x00000001859B7740
	
		public delegate object GetCSObject(IntPtr L, int idx); // TypeDefIndex: 85523; 0x00000001859B7730-0x00000001859B7740
	
		public delegate void UpdateCSObject(IntPtr L, int idx, object obj); // TypeDefIndex: 85524; 0x00000001811DF7F0-0x00000001811DF810
	
		public delegate bool CheckFunc<T>(IntPtr L, int idx); // TypeDefIndex: 85525; 0x00000000-0x00000000
	
		public delegate void GetFunc<T>(IntPtr L, int idx, out ref T val); // TypeDefIndex: 85526; 0x00000000-0x00000000
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0 // TypeDefIndex: 85527
		{
			// Fields
			public System.Type delegateType; // 0x10
			public MethodInfo genericMethodInfo; // 0x18
	
			// Constructors
			public __c__DisplayClass32_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Delegate _getCreatorUsingGeneric_b__7(DelegateBridgeBase o); // 0x000000018D9E906C-0x000000018D9E907C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_1 // TypeDefIndex: 85528
		{
			// Fields
			public MethodInfo methodInfo; // 0x10
			public __c__DisplayClass32_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass32_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Delegate _getCreatorUsingGeneric_b__8(DelegateBridgeBase o); // 0x000000018536C840-0x000000018536C880
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 85529
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
			static __c(); // 0x00000001871E6500-0x00000001871E6560
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _getCreatorUsingGeneric_b__32_1(MethodInfo m); // 0x0000000186D412F0-0x0000000186D41350
			internal int _getCreatorUsingGeneric_b__32_2(MethodInfo m); // 0x00000001860B5180-0x00000001860B51B0
			internal bool _getCreatorUsingGeneric_b__32_3(MethodInfo m); // 0x0000000186D41290-0x0000000186D412F0
			internal int _getCreatorUsingGeneric_b__32_4(MethodInfo m); // 0x00000001860B5180-0x00000001860B51B0
			internal Delegate _getCreatorUsingGeneric_b__32_0(DelegateBridgeBase x); // 0x0000000185829EC0-0x0000000185829ED0
			internal Delegate _getCreatorUsingGeneric_b__32_5(DelegateBridgeBase x); // 0x0000000185829EC0-0x0000000185829ED0
			internal System.Type _getCreatorUsingGeneric_b__32_6(ParameterInfo pinfo); // 0x000000018702CD70-0x000000018702CD90
			internal bool _getDelegate_b__33_0(MethodInfo m); // 0x0000000186912D20-0x0000000186912DB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0 // TypeDefIndex: 85530
		{
			// Fields
			public System.Type delegateType; // 0x10
	
			// Constructors
			public __c__DisplayClass33_0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_1 // TypeDefIndex: 85531
		{
			// Fields
			public MethodInfo foundMethod; // 0x10
			public __c__DisplayClass33_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass33_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Delegate _getDelegate_b__1(DelegateBridgeBase o); // 0x000000018536C840-0x000000018536C880
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__123<T> // TypeDefIndex: 85532
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
		private sealed class __c__125<T> // TypeDefIndex: 85533
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
		private sealed class __c__DisplayClass128_0<T> // TypeDefIndex: 85534
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
		private sealed class __c__DisplayClass129_0<T> // TypeDefIndex: 85535
		{
			// Fields
			public CheckFunc<T> check;
	
			// Constructors
			public __c__DisplayClass129_0();
	
			// Methods
			internal bool _RegisterChecker_b__0(IntPtr L, int idx);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass130_0<T> // TypeDefIndex: 85536
		{
			// Fields
			public GetFunc<T> get;
	
			// Constructors
			public __c__DisplayClass130_0();
	
			// Methods
			internal object _RegisterCaster_b__0(IntPtr L, int idx, object o);
		}
	
		// Constructors
		public ObjectTranslator(LuaEnv luaenv, IntPtr L); // 0x0000000185B80840-0x0000000185B81280
		static ObjectTranslator(); // 0x0000000186F8A080-0x0000000186F8A1D0
	
		// Methods
		public void DelayWrapLoader(System.Type type, Action<IntPtr> loader); // 0x00000001865F85C0-0x00000001865F85F0
		public void AddInterfaceBridgeCreator(System.Type type, Func<int, LuaEnv, LuaBase> creator); // 0x00000001865FC430-0x00000001865FC4A0
		public bool TryDelayWrapLoader(IntPtr L, System.Type type); // 0x00000001854C0930-0x00000001854C0BE0
		public void Alias(System.Type type, string alias); // 0x0000000185FD69E0-0x0000000185FD6A90
		private void addAssemblieByName(IEnumerable<Assembly> assemblies_usorted, string name); // 0x0000000185B80250-0x0000000185B80520
		private void initCSharpCallLua(); // 0x0000000186805BA0-0x0000000186805BB0
		private Func<DelegateBridgeBase, Delegate> getCreatorUsingGeneric(DelegateBridgeBase bridge, System.Type delegateType, MethodInfo delegateMethod); // 0x00000001867FC510-0x00000001867FCE00
		private Delegate getDelegate(DelegateBridgeBase bridge, System.Type delegateType); // 0x00000001851F8D40-0x00000001851F9170
		public object CreateDelegateBridge(IntPtr L, System.Type delegateType, int idx); // 0x00000001851F82B0-0x00000001851F8730
		public bool AllDelegateBridgeReleased(); // 0x000000018D9E38EC-0x000000018D9E3A40
		public void ReleaseLuaBase(IntPtr L, int reference, bool is_delegate); // 0x0000000185722B20-0x0000000185722DA0
		public object CreateInterfaceBridge(IntPtr L, System.Type interfaceType, int idx); // 0x0000000185C4A720-0x0000000185C4A7F0
		public void CreateArrayMetatable(IntPtr L); // 0x0000000186439200-0x00000001864393F0
		public void CreateDelegateMetatable(IntPtr L); // 0x0000000186438FE0-0x0000000186439200
		internal void CreateEnumerablePairs(IntPtr L); // 0x0000000186C55840-0x0000000186C55A90
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int CsPairs(IntPtr L); // 0x00000001860A5710-0x00000001860ADF20
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumToInt(IntPtr L); // 0x000000018D9E3A50-0x000000018D9E3AE4
		internal void CreateEnumerableCSPairs(IntPtr L); // 0x0000000186C557F0-0x0000000186C55840
		public void OpenLib(IntPtr L); // 0x0000000186B94310-0x0000000186B949C0
		internal void createFunctionMetatable(IntPtr L); // 0x00000001864393F0-0x0000000186439590
		internal System.Type FindType(string className, bool isQualifiedName = false /* Metadata: 0x02644FF9 */); // 0x0000000185FD7060-0x0000000185FD7330
		private bool hasMethod(System.Type type, string methodName); // 0x000000018D9E45B8-0x000000018D9E4648
		internal void collectObject(int obj_index_to_collect); // 0x0000000184FC39F0-0x0000000184FC3CC0
		private int addObject(object obj, bool is_valuetype, bool is_enum); // 0x00000001855BCAB0-0x00000001855BD070
		internal object GetObject(IntPtr L, int index); // 0x0000000185C4BC70-0x0000000185C4BD30
		public System.Type GetTypeOf(IntPtr L, int idx); // 0x000000018626BC60-0x000000018626BD70
		public bool Assignable<T>(IntPtr L, int index);
		public bool Assignable(IntPtr L, int index, System.Type type); // 0x000000018511CF80-0x000000018511D270
		public object FastGetObject(IntPtr L, int index, System.Type type); // 0x0000000185115E00-0x0000000185115F20
		public object GetObject(IntPtr L, int index, System.Type type); // 0x0000000187835018-0x0000000187835028
		private void _Get<T>(IntPtr L, int index, out ref T v);
		public void Get<T>(IntPtr L, int index, out ref T v);
		public void PushByType<T>(IntPtr L, T v);
		public T[] GetParams<T>(IntPtr L, int index);
		public Array GetParams(IntPtr L, int index, System.Type type); // 0x000000018D9E3BB0-0x000000018D9E3CAC
		public T GetDelegate<T>(IntPtr L, int index)
			where T : class;
		public int GetTypeId(IntPtr L, System.Type type); // 0x0000000187836604-0x0000000187836630
		public void PrivateAccessible(IntPtr L, System.Type type); // 0x000000018D9E4004-0x000000018D9E40E8
		public int getTypeId(IntPtr L, System.Type type, out bool is_first, LOGLEVEL log_level = LOGLEVEL.WARN /* Metadata: 0x02644FFA */); // 0x00000001854C0200-0x00000001854C08E0
		private void pushPrimitive(IntPtr L, object o); // 0x00000001854E28E0-0x00000001854E2C50
		public void PushObject(IntPtr L, object o); // 0x00000001878373B4-0x00000001878373BC
		public void PushAny(IntPtr L, object o); // 0x0000000184FFACE0-0x0000000184FFB9E0
		public int TranslateToEnumToTop(IntPtr L, System.Type type, int idx); // 0x000000018511C870-0x000000018511CC50
		public void Push(IntPtr L, lua_CSFunction o); // 0x000000018D9E4428-0x000000018D9E44E8
		public void Push(IntPtr L, LuaBase o); // 0x000000018D9E43C4-0x000000018D9E4428
		public void Push<T>(IntPtr L, T o)
			where T : struct;
		public void Push(IntPtr L, object o); // 0x0000000184FF9ED0-0x0000000184FFAA60
		public void PushObject(IntPtr L, object o, int type_id); // 0x000000018D9E42B0-0x000000018D9E43C4
		public bool IsUnmanagedType(System.Type type); // 0x00000001854E3AC0-0x00000001854E3BA0
		public void PushBrigeStruct(IntPtr L, IntPtr ptr, System.Type type, int size); // 0x00000001854E37F0-0x00000001854E3AC0
		private void _PushBrigeStruct(IntPtr L, IntPtr ptr, System.Type type, int size); // 0x00000001854E3150-0x00000001854E3290
		public void GetBrigeStruct(IntPtr L, IntPtr ptr, int index, int size, System.Type type); // 0x00000001854E4640-0x00000001854E4870
		public void AddNeedRemoveObjRef(object obj); // 0x0000000185A81230-0x0000000185A81270
		private void _GetBrigeStruct(IntPtr L, IntPtr ptr, int index, int size, System.Type type); // 0x00000001854E20C0-0x00000001854E2280
		public void UpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type); // 0x000000018600C8D0-0x000000018600C990
		public void BeyondUpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type); // 0x000000018D9E3A40-0x000000018D9E3A50
		private void _UpdateStructObj(IntPtr L, IntPtr ptr, int index, int size, System.Type type); // 0x000000018600CB00-0x000000018600CB90
		public void Update<T>(IntPtr L, int index, T obj)
			where T : struct;
		public void Update(IntPtr L, int index, object obj); // 0x000000018511AC30-0x000000018511AED0
		private object getCsObj(IntPtr L, int index, int udata); // 0x0000000185116BC0-0x0000000185116ED0
		internal object SafeGetCSObj(IntPtr L, int index); // 0x0000000185C4D4F0-0x0000000185C4D560
		public object FastGetCSObj(IntPtr L, int index); // 0x000000018D9E3AE4-0x000000018D9E3B58
		internal void ReleaseCSObj(IntPtr L, int index); // 0x000000018D9E44E8-0x000000018D9E45B8
		internal lua_CSFunction GetFixCSFunction(int index); // 0x000000018D9E3B58-0x000000018D9E3BB0
		internal LuaCSFunctionPtr GetFixCSFunctionPtr(int index); // 0x0000000184FC5320-0x0000000184FC53A0
		internal void PushFixCSFunction(IntPtr L, lua_CSFunction func); // 0x00000001854E3BA0-0x00000001854E3F90
		internal object[] popValues(IntPtr L, int oldTop); // 0x00000001851F95F0-0x00000001851F96F0
		internal object[] popValues(IntPtr L, int oldTop, System.Type[] popTypes); // 0x000000018D9E4648-0x000000018D9E47E0
		private void registerCustomOp(System.Type type, PushCSObject push, GetCSObject get, UpdateCSObject update); // 0x0000000185AA9690-0x0000000185AA9730
		public bool HasCustomOp(System.Type type); // 0x0000000186439920-0x0000000186439950
		private bool tryGetPushFuncByType<T>(System.Type type, out ref T func)
			where T : class;
		private bool tryGetGetFuncByType<T>(System.Type type, out ref T func)
			where T : class;
		public void RegisterPushAndGetAndUpdate<T>(Action<IntPtr, T> push, GetFunc<T> get, Action<IntPtr, int, T> update);
		public void RegisterChecker<T>(CheckFunc<T> check);
		public void RegisterCaster<T>(GetFunc<T> get);
		public void PushDecimal(IntPtr L, decimal val); // 0x000000018D9E40E8-0x000000018D9E42B0
		public bool IsDecimal(IntPtr L, int index); // 0x000000018D9E3F94-0x000000018D9E4004
		public decimal GetDecimal(IntPtr L, int index); // 0x0000000189BBDF4C-0x0000000189BBDF88
		public void Get(IntPtr L, int index, out decimal val); // 0x000000018D9E3CAC-0x000000018D9E3F94
		[CompilerGenerated]
		private decimal _tryGetGetFuncByType_b__125_0<T>(IntPtr L, int idx)
			where T : class;
	}

	public class ObjectTranslatorPool // TypeDefIndex: 85538
	{
		// Fields
		private Dictionary<IntPtr, WeakReference> translators; // 0x10
		private IntPtr lastPtr; // 0x18
		private ObjectTranslator lastTranslator; // 0x20
		public static ObjectTranslatorPool Instance; // 0x00
	
		// Constructors
		public ObjectTranslatorPool(); // 0x00000001870AD290-0x00000001870AD310
		static ObjectTranslatorPool(); // 0x00000001870AD220-0x00000001870AD290
	
		// Methods
		public void Add(IntPtr L, ObjectTranslator translator); // 0x00000001870A2190-0x00000001870A2280
		public ObjectTranslator Find(IntPtr L); // 0x000000018225E800-0x000000018225E810
		public void Remove(IntPtr L); // 0x000000018D9E3830-0x000000018D9E38EC
	}

	public interface RawObject // TypeDefIndex: 85539
	{
		// Properties
		object Target { get; }
	}

	public class InternalUtility // TypeDefIndex: 85540
	{
		// Fields
		private static Dictionary<System.Type, string> s_baseValueTypeDic; // 0x00
	
		// Constructors
		public InternalUtility(); // 0x0000000186805BA0-0x0000000186805BB0
		static InternalUtility(); // 0x00000001867ED580-0x00000001867EDA80
	
		// Methods
		public static string GetTypeGenericSignatureDefine(System.Type type, bool isGetType = false /* Metadata: 0x02644FFF */, bool isRef = false /* Metadata: 0x02645000 */, bool isOut = false /* Metadata: 0x02645001 */, bool needLua = false /* Metadata: 0x02645002 */, bool keepType = false /* Metadata: 0x02645003 */, bool needEnum = false /* Metadata: 0x02645004 */); // 0x0000000185A370B0-0x0000000185A373A0
		public static bool CheckRegisterBaseStructOnArm(System.Type type); // 0x0000000185369790-0x00000001853699A0
		public static bool CheckCustomDelegate(string name); // 0x0000000186321120-0x00000001863214B0
		public static bool CheckTypNeedToGen(System.Type type, Func<System.Type, bool> additionalTypeFilter = null); // 0x000000018D9E27D4-0x000000018D9E2908
		public static bool IsPublic(System.Type type); // 0x000000018D9E309C-0x000000018D9E3150
		public static string GetTypeFullName(System.Type t); // 0x00000001857028C0-0x0000000185702AF0
		public static string GetDelegateName(MethodInfo method); // 0x000000018D9E2908-0x000000018D9E2C74
		public static bool IsStruct(System.Type type); // 0x00000001853699A0-0x0000000185369A20
		public static string GetGenericTypeName(System.Type type, bool needPoint = false /* Metadata: 0x02645005 */); // 0x000000018D9E2E24-0x000000018D9E309C
		public static string GeNormalName(string str); // 0x000000018536A580-0x000000018536A690
		public static string GetGenericTypeNameString(System.Type type); // 0x000000018D9E2C74-0x000000018D9E2E24
	}

	public class MethodAndDelegateSignatureManager // TypeDefIndex: 85541
	{
		// Constructors
		public MethodAndDelegateSignatureManager(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static System.Type MakeMethodDelegateType(MethodInfo method); // 0x00000001861D5450-0x00000001861D7130
		public static System.Type MakeMethodDelegateType(MethodInfo method, System.Type customDelegateType); // 0x00000001862AE2C0-0x00000001862AEFC0
		public static ValueTuple<System.Type, string> GetMethodDelegateType(MethodInfo method); // 0x000000018536C080-0x000000018536C160
	}

	public class SignatureLoader // TypeDefIndex: 85542
	{
		// Fields
		private LuaEnv.CustomLoader userLoader; // 0x10
		private RSACryptoServiceProvider rsa; // 0x18
		private SHA1 sha; // 0x20
	
		// Constructors
		public SignatureLoader(string publicKey, LuaEnv.CustomLoader loader); // 0x000000018D9E4864-0x000000018D9E4964
	
		// Methods
		private byte[] load_and_verify(ref string filepath); // 0x000000018D9E4964-0x000000018D9E4B4C
		public static implicit operator LuaEnv.CustomLoader(SignatureLoader signatureLoader); // 0x000000018D9E4B4C-0x000000018D9E4BC0
	}

	public delegate TRet CallDelegatePointer<TParam1, TParam2, TRet>(IntPtr ptr, TParam1 target, TParam2 param); // TypeDefIndex: 85543; 0x00000000-0x00000000

	public class StaticLuaCallbacks // TypeDefIndex: 85544
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
		public StaticLuaCallbacks(); // 0x0000000186E0A3F0-0x0000000186E0A600
	
		// Methods
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumAnd(IntPtr L); // 0x000000018D9E5300-0x000000018D9E5588
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int EnumOr(IntPtr L); // 0x000000018D9E5588-0x000000018D9E5810
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int StaticCSFunction(IntPtr L); // 0x000000018D9E6E08-0x000000018D9E6FB4
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int FixCSFunction(IntPtr L); // 0x0000000184FC40E0-0x0000000184FC5320
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCall(IntPtr L); // 0x0000000185B78AA0-0x0000000185B78BF0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LuaGC(IntPtr L); // 0x0000000184FC3CC0-0x0000000184FC40E0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToString(IntPtr L); // 0x0000000186A51A60-0x0000000186A51B60
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateCombine(IntPtr L); // 0x000000018D9E4E64-0x000000018D9E50C4
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateRemove(IntPtr L); // 0x0000000186A9CCC0-0x0000000186A9CE30
		private static bool tryPrimitiveArrayGet(System.Type type, IntPtr L, object obj, int index); // 0x00000001854EA890-0x00000001854EAC00
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayIndexer(IntPtr L); // 0x00000001854EA530-0x00000001854EA890
		public static bool TryPrimitiveArraySet(System.Type type, IntPtr L, object obj, int array_idx, int obj_idx); // 0x0000000185C4BF80-0x0000000185C4C4C0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayNewIndexer(IntPtr L); // 0x0000000185C4C4C0-0x0000000185C4C8D0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ArrayLength(IntPtr L); // 0x000000018694EE50-0x000000018694EF70
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int MetaFuncIndex(IntPtr L); // 0x0000000186601510-0x0000000186601670
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Panic(IntPtr L); // 0x000000018D9E6940-0x000000018D9E69DC
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int Print(IntPtr L); // 0x000000018D9E69DC-0x000000018D9E6CC0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadSocketCore(IntPtr L); // 0x000000018D9E68F8-0x000000018D9E6940
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadCS(IntPtr L); // 0x000000018D9E627C-0x000000018D9E62E8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadBuiltinLib(IntPtr L); // 0x0000000186A2A050-0x0000000186A2A200
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromResource(IntPtr L); // 0x000000018D9E62E8-0x000000018D9E65FC
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromStreamingAssetsPath(IntPtr L); // 0x000000018D9E65FC-0x000000018D9E68F8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LoadFromCustomLoaders(IntPtr L); // 0x0000000185C4A190-0x0000000185C4A6B0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadAssembly(IntPtr L); // 0x000000018D9E5FF8-0x000000018D9E627C
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportType(IntPtr L); // 0x0000000185FD6EF0-0x0000000185FD7060
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ImportGenericType(IntPtr L); // 0x0000000185FD6A90-0x0000000185FD6D50
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Cast(IntPtr L); // 0x000000018D9E4BC0-0x000000018D9E4E64
		private static System.Type getType(IntPtr L, ObjectTranslator translator, int idx); // 0x0000000185FD6D50-0x0000000185FD6E40
		private static int absIndex(IntPtr L, int idx); // 0x000000018D9E80AC-0x000000018D9E8110
		private static System.Type[] getTypeArray(IntPtr L, ObjectTranslator translator, int idx); // 0x000000018D9E8950-0x000000018D9E8BA4
		private static void makePrivateAccessible(IntPtr L, ObjectTranslator translator, System.Type type); // 0x000000018D9E8C38-0x000000018D9E8CB8
		private static bool isClearPatchValue(IntPtr L, int idx); // 0x000000018D9E8BA4-0x000000018D9E8C38
		private static void applyHotPatch(IntPtr L, ObjectTranslator translator, System.Type type, string methodName, int funcIdx, System.Type[] parameterTypes); // 0x000000018D9E8110-0x000000018D9E8950
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaHotPatch(IntPtr L); // 0x000000018D9E77B0-0x000000018D9E7BA0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaAccess(IntPtr L); // 0x000000018D9E732C-0x000000018D9E77B0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaPrivateAccessible(IntPtr L); // 0x000000018D9E7EA8-0x000000018D9E80AC
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int XLuaMetatableOperation(IntPtr L); // 0x000000018D9E7BA0-0x000000018D9E7EA8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int DelegateConstructor(IntPtr L); // 0x000000018D9E50C4-0x000000018D9E5300
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ToFunction(IntPtr L); // 0x000000018D9E6FB4-0x000000018D9E732C
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GenericMethodWraper(IntPtr L); // 0x000000018D9E5810-0x000000018D9E5BF4
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int GetGenericMethod(IntPtr L); // 0x000000018D9E5BF4-0x000000018D9E5FF8
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int ReleaseCsObject(IntPtr L); // 0x000000018D9E6CC0-0x000000018D9E6E08
	}

	internal static class TypeExtensions // TypeDefIndex: 85546
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 85545
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, string> __9__12_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D9EE884-0x000000018D9EE8E8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _GetFriendlyName_b__12_0(System.Type x); // 0x000000018D9EC620-0x000000018D9EC62C
		}
	
		// Extension methods
		public static bool IsValueType(this System.Type type); // 0x0000000184FD4F40-0x0000000184FD4F60
		public static bool IsEnum(this System.Type type); // 0x0000000184FC39D0-0x0000000184FC39F0
		public static bool IsPrimitive(this System.Type type); // 0x0000000184FFAA60-0x0000000184FFAA80
		public static bool IsAbstract(this System.Type type); // 0x0000000184FD28E0-0x0000000184FD2910
		public static bool IsSealed(this System.Type type); // 0x000000018D9EC2C4-0x000000018D9EC2E0
		public static bool IsInterface(this System.Type type); // 0x0000000184FD3C40-0x0000000184FD3C60
		public static bool IsClass(this System.Type type); // 0x00000001858C65A0-0x00000001858C65C0
		public static System.Type BaseType(this System.Type type); // 0x000000018536E300-0x000000018536E320
		public static bool IsGenericType(this System.Type type); // 0x0000000184FD3C20-0x0000000184FD3C40
		public static bool IsGenericTypeDefinition(this System.Type type); // 0x0000000184FD3C60-0x0000000184FD3C80
		public static bool IsNestedPublic(this System.Type type); // 0x000000018D9EC28C-0x000000018D9EC2A8
		public static bool IsPublic(this System.Type type); // 0x000000018D9EC2A8-0x000000018D9EC2C4
		public static string GetFriendlyName(this System.Type type); // 0x000000018D9EBD90-0x000000018D9EC28C
	}

	public enum LazyMemberTypes // TypeDefIndex: 85547
	{
		Method = 0,
		FieldGet = 1,
		FieldSet = 2,
		PropertyGet = 3,
		PropertySet = 4,
		Event = 5
	}

	public static class Utils // TypeDefIndex: 85563
	{
		// Fields
		public static bool s_xluaReflectionOpt; // 0x00
		public const int OBJ_META_IDX = -4; // Metadata: 0x0264500E
		public const int METHOD_IDX = -3; // Metadata: 0x0264500F
		public const int GETTER_IDX = -2; // Metadata: 0x02645010
		public const int SETTER_IDX = -1; // Metadata: 0x02645011
		public const int CLS_IDX = -4; // Metadata: 0x02645012
		public const int CLS_META_IDX = -3; // Metadata: 0x02645013
		public const int CLS_GETTER_IDX = -2; // Metadata: 0x02645014
		public const int CLS_SETTER_IDX = -1; // Metadata: 0x02645015
		public const string LuaIndexsFieldName = "LuaIndexs"; // Metadata: 0x02645016
		public const string LuaNewIndexsFieldName = "LuaNewIndexs"; // Metadata: 0x02645020
		public const string LuaClassIndexsFieldName = "LuaClassIndexs"; // Metadata: 0x0264502D
		public const string LuaClassNewIndexsFieldName = "LuaClassNewIndexs"; // Metadata: 0x0264503C
	
		// Nested types
		private struct MethodKey // TypeDefIndex: 85548
		{
			// Fields
			public string Name; // 0x00
			public bool IsStatic; // 0x08
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 85549
		{
			// Fields
			public bool exclude_generic_definition; // 0x10
			public Func<System.Type, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetAllTypes_b__0(System.Type type); // 0x000000018D9EDD44-0x000000018D9EDD68
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 85550
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _genFieldGetter_b__0(IntPtr L); // 0x000000018D9EDD68-0x000000018D9EDE08
			internal int _genFieldGetter_b__1(IntPtr L); // 0x000000018D9EDE08-0x000000018D9EE058
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 85551
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _genFieldGetterByPointer_b__0(IntPtr L); // 0x00000001860008D0-0x00000001860009A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 85552
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _genFieldSetter_b__0(IntPtr L); // 0x000000018D9EE1D8-0x000000018D9EE448
			internal int _genFieldSetter_b__1(IntPtr L); // 0x000000018D9EE448-0x000000018D9EE820
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 85553
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _genFieldSetterByPointer_b__0(IntPtr L); // 0x00000001866FF410-0x00000001866FF5C0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 85554
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public MethodWrap[] methods; // 0x28
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _genItemGetterOpt_b__1(IntPtr L); // 0x0000000186034A30-0x0000000186034C00
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 85555
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
			static __c(); // 0x00000001871E5060-0x00000001871E50C0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _genItemGetterOpt_b__9_0(PropertyInfo prop); // 0x0000000186793900-0x00000001867939C0
			internal bool _genItemGetter_b__10_0(PropertyInfo prop); // 0x000000018D9EC8E4-0x000000018D9EC990
			internal bool _genItemSetterOpt_b__11_0(PropertyInfo prop); // 0x0000000186793840-0x0000000186793900
			internal bool _genItemSetter_b__12_0(PropertyInfo prop); // 0x000000018D9EC990-0x000000018D9ECA3C
			internal bool _GetExtensionMethodsOf_b__14_7(System.Type t); // 0x000000018D9EC528-0x000000018D9EC5A4
			internal bool _GetExtensionMethodsOf_b__14_8(System.Type t); // 0x000000018D9EC5A4-0x000000018D9EC620
			internal IEnumerable<MethodInfo> _GetExtensionMethodsOf_b__14_0(System.Type type); // 0x000000018D9EC2E0-0x000000018D9EC300
			internal __f__AnonymousType1<System.Type, MethodInfo> _GetExtensionMethodsOf_b__14_1(System.Type type, MethodInfo method); // 0x000000018D9EC300-0x000000018D9EC380
			internal bool _GetExtensionMethodsOf_b__14_2(__f__AnonymousType1<System.Type, MethodInfo> __h__TransparentIdentifier0); // 0x000000018D9EC380-0x000000018D9EC448
			internal System.Type _GetExtensionMethodsOf_b__14_3(__f__AnonymousType1<System.Type, MethodInfo> __h__TransparentIdentifier0); // 0x000000018D9EC448-0x000000018D9EC4A4
			internal MethodInfo _GetExtensionMethodsOf_b__14_4(__f__AnonymousType1<System.Type, MethodInfo> __h__TransparentIdentifier0); // 0x000000018D9EC4A4-0x000000018D9EC4E0
			internal System.Type _GetExtensionMethodsOf_b__14_5(IGrouping<System.Type, MethodInfo> g); // 0x000000018D9EC4E0-0x000000018D9EC528
			internal IEnumerable<MethodInfo> _GetExtensionMethodsOf_b__14_6(IGrouping<System.Type, MethodInfo> g); // 0x000000018459BB50-0x000000018459BB60
			internal string _makeReflectionWrap_b__16_0(MethodInfo p); // 0x000000018CB8FB40-0x000000018CB8FB60
			internal string _makeReflectionWrap_b__16_1(MethodInfo q); // 0x000000018CB8FB40-0x000000018CB8FB60
			internal MethodInfo _makeReflectionWrap_b__16_2(MethodInfo p, MethodInfo q); // 0x000000018459BB50-0x000000018459BB60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 85556
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public object[] arg; // 0x28
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _genItemGetter_b__1(IntPtr L); // 0x000000018D9ECA3C-0x000000018D9ECF9C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 85557
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public MethodWrap[] methods; // 0x28
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _genItemSetterOpt_b__1(IntPtr L); // 0x000000018D9ECF9C-0x000000018D9ED4B0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 85558
		{
			// Fields
			public System.Type type; // 0x10
			public PropertyInfo[] props; // 0x18
			public System.Type[] params_type; // 0x20
			public object[] arg; // 0x28
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _genItemSetter_b__1(IntPtr L); // 0x000000018D9ED4B0-0x000000018D9EDB38
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 85559
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _genEnumCastFrom_b__0(IntPtr L); // 0x000000018511C340-0x000000018511C870
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 85560
		{
			// Fields
			public string fieldName; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _makeReflectionWrap_b__3(EventInfo e); // 0x0000000186ED7220-0x0000000186ED7260
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 85561
		{
			// Fields
			public string memberName; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _LazyReflectionCall_b__0(MethodInfo m); // 0x000000018CB4BB18-0x000000018CB4BB4C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 85562
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _ReflectionWrap_b__0(IntPtr LL); // 0x000000018D9EDCAC-0x000000018D9EDD44
		}
	
		// Constructors
		static Utils(); // 0x000000018721F6B0-0x000000018721F6F0
	
		// Methods
		public static bool LoadField(IntPtr L, int idx, string field_name); // 0x000000018D9EFE0C-0x000000018D9EFEA0
		public static IntPtr GetMainState(IntPtr L); // 0x000000018D9EEBE8-0x000000018D9EECA4
		public static List<System.Type> GetAllTypes(bool exclude_generic_definition = true /* Metadata: 0x0264500C */); // 0x000000018D9EE9B0-0x000000018D9EEBE8
		private static lua_CSFunction genFieldGetter(System.Type type, System.Reflection.FieldInfo field); // 0x000000018D9F0764-0x000000018D9F0858
		private static lua_CSFunction genFieldGetterByPointer(System.Type type, System.Reflection.FieldInfo field); // 0x00000001854C38C0-0x00000001854C3C10
		public static bool IsNullableType(System.Type type); // 0x000000018D9EECA4-0x000000018D9EED38
		private static lua_CSFunction genFieldSetter(System.Type type, System.Reflection.FieldInfo field); // 0x000000018D9F0858-0x000000018D9F094C
		private static lua_CSFunction genFieldSetterByPointer(System.Type type, System.Reflection.FieldInfo field); // 0x00000001854C3C10-0x00000001854C3F50
		private static lua_CSFunction genItemGetterOpt(System.Type type, PropertyInfo[] props, ObjectTranslator translator); // 0x000000018633EE00-0x000000018633F250
		private static lua_CSFunction genItemGetter(System.Type type, PropertyInfo[] props); // 0x000000018D9F094C-0x000000018D9F0C14
		private static lua_CSFunction genItemSetterOpt(System.Type type, PropertyInfo[] props, ObjectTranslator translator); // 0x000000018633F250-0x000000018633F6A0
		private static lua_CSFunction genItemSetter(System.Type type, PropertyInfo[] props); // 0x000000018D9F0C14-0x000000018D9F0EDC
		private static lua_CSFunction genEnumCastFrom(System.Type type); // 0x00000001854C2270-0x00000001854C2320
		internal static IEnumerable<MethodInfo> GetExtensionMethodsOf(System.Type type_to_be_extend); // 0x00000001862B7EA0-0x00000001862B7FC0
		private static void makeReflectionWrap(IntPtr L, System.Type type, int cls_field, int cls_getter, int cls_setter, int obj_field, int obj_getter, int obj_setter, int obj_meta, out lua_CSFunction item_getter, out lua_CSFunction item_setter, System.Reflection.BindingFlags access); // 0x00000001850C5620-0x00000001850C8BE0
		public static void loadUpvalue(IntPtr L, System.Type type, string metafunc, int index); // 0x000000018D9F1000-0x000000018D9F11A4
		public static void RegisterEnumType(IntPtr L, System.Type type); // 0x000000018D9F04D0-0x000000018D9F05FC
		public static void MakePrivateAccessible(IntPtr L, System.Type type); // 0x000000018D9F0008-0x000000018D9F04D0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		internal static int LazyReflectionCall(IntPtr L); // 0x000000018D9EF024-0x000000018D9EFCC0
		public static void ReflectionWrap(IntPtr L, System.Type type, bool privateAccessible); // 0x00000001851F7770-0x00000001851F82B0
		public static void BeginObjectRegister(System.Type type, IntPtr L, ObjectTranslator translator, int meta_count, int method_count, int getter_count, int setter_count, int type_id = -1 /* Metadata: 0x0264500D */); // 0x0000000186439590-0x0000000186439920
		private static int abs_idx(int top, int idx); // 0x00000001860CE820-0x00000001860CE830
		public static void EndObjectRegister(System.Type type, IntPtr L, ObjectTranslator translator, lua_CSFunction csIndexer, lua_CSFunction csNewIndexer, System.Type base_type, lua_CSFunction arrayIndexer, lua_CSFunction arrayNewIndexer); // 0x00000001860CE160-0x00000001860CE6C0
		public static void RegisterFunc(IntPtr L, int idx, string name, lua_CSFunction func); // 0x00000001860CE6C0-0x00000001860CE820
		public static void RegisterLazyFunc(IntPtr L, int idx, string name, System.Type type, LazyMemberTypes memberType, bool isStatic); // 0x000000018D9F05FC-0x000000018D9F0764
		public static void RegisterObject(IntPtr L, ObjectTranslator translator, int idx, string name, object obj); // 0x0000000186745A00-0x0000000186745AC0
		public static void BeginClassRegister(System.Type type, IntPtr L, lua_CSFunction creator, int class_field_count, int static_getter_count, int static_setter_count); // 0x0000000185C4B870-0x0000000185C4BAD0
		public static void EndClassRegister(System.Type type, IntPtr L, ObjectTranslator translator); // 0x00000001860CDF10-0x00000001860CE160
		private static List<string> getPathOfType(System.Type type); // 0x0000000185369A20-0x0000000185369C00
		public static void LoadCSTable(IntPtr L, System.Type type); // 0x000000018D9EFCC0-0x000000018D9EFE0C
		public static void SetCSTable(IntPtr L, System.Type type, int cls_table); // 0x00000001851F8780-0x00000001851F8B90
		public static bool IsParamsMatch(MethodInfo delegateMethod, MethodInfo bridgeMethod); // 0x0000000186B08280-0x0000000186B083B0
		public static bool IsSupportedMethod(MethodInfo method); // 0x000000018D9EEE48-0x000000018D9EF024
		public static MethodInfo MakeGenericMethodWithConstraints(MethodInfo method); // 0x000000018D9EFEA0-0x000000018D9F0008
		private static System.Type getExtendedType(MethodInfo method); // 0x000000018D9F0EDC-0x000000018D9F1000
		public static bool IsStaticPInvokeCSFunction(lua_CSFunction csFunction); // 0x0000000185C4AB10-0x0000000185C4ABE0
		public static bool IsPublic(System.Type type); // 0x000000018D9EED38-0x000000018D9EEE48
	}
}

namespace XLua.Cast
{
	public class Any<T> : RawObject // TypeDefIndex: 85590
	{
		// Fields
		private T mTarget;
	
		// Properties
		public object Target { get; }
	
		// Constructors
		public Any(T i);
	}

	public class Byte : Any<byte> // TypeDefIndex: 85591
	{
		// Constructors
		public Byte(byte i); // 0x000000018D9E911C-0x000000018D9E915C
	}

	public class SByte : Any<sbyte> // TypeDefIndex: 85592
	{
		// Constructors
		public SByte(sbyte i); // 0x000000018D9EBD04-0x000000018D9EBD44
	}

	public class Char : Any<char> // TypeDefIndex: 85593
	{
		// Constructors
		public Char(char i); // 0x000000018D9E915C-0x000000018D9E91A0
	}

	public class Int16 : Any<short> // TypeDefIndex: 85594
	{
		// Constructors
		public Int16(short i); // 0x000000018D9E9D78-0x000000018D9E9DBC
	}

	public class UInt16 : Any<ushort> // TypeDefIndex: 85595
	{
		// Constructors
		public UInt16(ushort i); // 0x000000018D9EE8E8-0x000000018D9EE92C
	}

	public class Int32 : Any<int> // TypeDefIndex: 85596
	{
		// Constructors
		public Int32(int i); // 0x000000018D9E9DBC-0x000000018D9E9DFC
	}

	public class UInt32 : Any<uint> // TypeDefIndex: 85597
	{
		// Constructors
		public UInt32(uint i); // 0x000000018D9EE92C-0x000000018D9EE96C
	}

	public class Int64 : Any<long> // TypeDefIndex: 85598
	{
		// Constructors
		public Int64(long i); // 0x000000018D9E9DFC-0x000000018D9E9E40
	}

	public class UInt64 : Any<ulong> // TypeDefIndex: 85599
	{
		// Constructors
		public UInt64(ulong i); // 0x000000018D9EE96C-0x000000018D9EE9B0
	}

	public class Float : Any<float> // TypeDefIndex: 85600
	{
		// Constructors
		public Float(float i); // 0x000000018D9E9250-0x000000018D9E9294
	}
}

namespace XLua.LuaDLL
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int lua_CSFunction(IntPtr L); // TypeDefIndex: 85601; 0x0000000185B78EA0-0x0000000185B78EB0

	public static class Lua // TypeDefIndex: 85605
	{
		// Fields
		private const string LUADLL = "__Internal"; // Metadata: 0x02645055
		private static int s_mainThreadId; // 0x00
		public static Func<IntPtr, string> tryGetLuaStringFunc; // 0x08
		public static Action<IntPtr, IntPtr, int, string> refLuaStringFunc; // 0x10
		public const int LUAI_MAXSHORTLEN = 40; // Metadata: 0x02645060
	
		// Nested types
		public delegate void HyperLuaLogCallbackDelegate(IntPtr L, int level, string text); // TypeDefIndex: 85602; 0x00000001811DF7F0-0x00000001811DF810
	
		public delegate void LuaUtilsLogCallbackDelegate(int level, string text); // TypeDefIndex: 85603; 0x00000001859B7730-0x00000001859B7740
	
		public delegate IntPtr DecryptionFunc(IntPtr input, int size, out int outSize); // TypeDefIndex: 85604; 0x00000001811DF7F0-0x00000001811DF810
	
		// Constructors
		static Lua(); // 0x00000001871E7D60-0x00000001871E7DC0
	
		// Methods
		public static extern IntPtr lua_tothread(IntPtr L, int index); // 0x0000000187839E38-0x0000000187839E40
		public static extern int xlua_get_lib_version(); // 0x0000000187839E60-0x0000000187839E68
		public static extern int lua_gc(IntPtr L, XLua.LuaGCOptions what, int data); // 0x0000000187834D74-0x0000000187834D7C
		public static extern IntPtr lua_getupvalue(IntPtr L, int funcindex, int n); // 0x000000018D9EAA38-0x000000018D9EAA40
		public static extern IntPtr lua_setupvalue(IntPtr L, int funcindex, int n); // 0x000000018D9EAB50-0x000000018D9EAB58
		public static extern int lua_pushthread(IntPtr L); // 0x0000000187839E40-0x0000000187839E48
		public static bool lua_isfunction(IntPtr L, int stackPos); // 0x000000018511EC30-0x000000018511EC80
		public static bool lua_islightuserdata(IntPtr L, int stackPos); // 0x000000018D9EAA94-0x000000018D9EAAE8
		public static bool lua_istable(IntPtr L, int stackPos); // 0x000000018511D7E0-0x000000018511D830
		public static bool lua_isthread(IntPtr L, int stackPos); // 0x0000000185C49CE0-0x0000000185C49D50
		public static int luaL_error(IntPtr L, string message); // 0x000000018D9EA894-0x000000018D9EA8E8
		public static extern int lua_setfenv(IntPtr L, int stackPos); // 0x000000018D9EAB08-0x000000018D9EAB10
		public static extern IntPtr luaL_newstate(); // 0x0000000187839E88-0x0000000187839E90
		public static extern void lua_close(IntPtr L); // 0x000000018D9EA990-0x000000018D9EA998
		public static extern void luaopen_xlua(IntPtr L); // 0x0000000187839E28-0x0000000187839E30
		public static extern void luaL_openlibs(IntPtr L); // 0x000000018D9EA980-0x000000018D9EA988
		public static extern uint xlua_objlen(IntPtr L, int stackPos); // 0x0000000187839EA0-0x0000000187839EA8
		public static extern void lua_createtable(IntPtr L, int narr, int nrec); // 0x000000018783559C-0x00000001878355A4
		public static void lua_newtable(IntPtr L, int arrayL = 0 /* Metadata: 0x02645051 */, int hashL = 0 /* Metadata: 0x02645052 */); // 0x00000001851F8730-0x00000001851F8780
		public static extern int xlua_getglobal(IntPtr L, string name); // 0x00000001854C0DE0-0x00000001854C0E20
		public static extern int xlua_setglobal(IntPtr L, string name); // 0x0000000185C49A00-0x0000000185C49A40
		public static extern void xlua_getloaders(IntPtr L); // 0x0000000187839E98-0x0000000187839EA0
		public static extern void lua_settop(IntPtr L, int newTop); // 0x0000000187834C4C-0x0000000187834C54
		public static void lua_pop(IntPtr L, int amount); // 0x00000001851F8D00-0x00000001851F8D40
		public static extern void lua_insert(IntPtr L, int newTop); // 0x000000018783B638-0x000000018783B640
		public static extern void lua_remove(IntPtr L, int index); // 0x00000001878355B8-0x00000001878355C0
		public static extern int lua_rawget(IntPtr L, int index); // 0x0000000187835594-0x000000018783559C
		public static extern void lua_rawset(IntPtr L, int index); // 0x0000000187835584-0x000000018783558C
		public static extern int lua_setmetatable(IntPtr L, int objIndex); // 0x0000000187839E90-0x0000000187839E98
		public static extern int lua_rawequal(IntPtr L, int index1, int index2); // 0x000000018D9EAAF8-0x000000018D9EAB00
		public static extern void lua_pushvalue(IntPtr L, int index); // 0x000000018783558C-0x0000000187835594
		public static extern void lua_pushcclosure(IntPtr L, IntPtr fn, int n); // 0x000000018D9EAAF0-0x000000018D9EAAF8
		public static extern void lua_replace(IntPtr L, int index); // 0x000000018D9EAB00-0x000000018D9EAB08
		public static extern int lua_gettop(IntPtr L); // 0x0000000187834C0C-0x0000000187834C14
		public static extern LuaTypes lua_type(IntPtr L, int index); // 0x0000000187834C6C-0x0000000187834C74
		public static bool lua_isnil(IntPtr L, int index); // 0x000000018511CF20-0x000000018511CF80
		public static extern bool lua_isnumber(IntPtr L, int index); // 0x00000001854E5890-0x00000001854E58B0
		public static bool lua_isboolean(IntPtr L, int index); // 0x000000018D9EAA40-0x000000018D9EAA94
		public static extern int luaL_ref(IntPtr L, int registryIndex); // 0x0000000187834C8C-0x0000000187834C94
		public static int luaL_ref(IntPtr L); // 0x000000018511F090-0x000000018511F100
		public static extern void xlua_rawgeti(IntPtr L, int tableIndex, long index); // 0x0000000187834C54-0x0000000187834C5C
		public static extern void xlua_rawseti(IntPtr L, int tableIndex, long index); // 0x00000001878364FC-0x0000000187836504
		public static void lua_getref(IntPtr L, int reference); // 0x000000018511B790-0x000000018511B810
		public static extern int pcall_prepare(IntPtr L, int error_func_ref, int func_ref); // 0x00000001878355C8-0x00000001878355D0
		public static extern void luaL_unref(IntPtr L, int registryIndex, int reference); // 0x00000001878375D0-0x00000001878375D8
		public static void lua_unref(IntPtr L, int reference); // 0x0000000185722DA0-0x0000000185722E20
		public static extern bool lua_isstring(IntPtr L, int index); // 0x00000001854C0E20-0x00000001854C0E40
		public static extern bool lua_isinteger(IntPtr L, int index); // 0x00000001861B80E0-0x00000001861B8100
		public static extern void lua_pushnil(IntPtr L); // 0x00000001878375D8-0x00000001878375E0
		public static void lua_pushstdcallcfunction(IntPtr L, lua_CSFunction function, int n = 0 /* Metadata: 0x02645053 */); // 0x00000001854E3F90-0x00000001854E4070
		public static extern int xlua_upvalueindex(int n); // 0x0000000187834598-0x00000001878345A0
		public static int lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc); // 0x00000001851FA0A0-0x00000001851FA240
		public static extern int _lua_pcall(IntPtr L, int nArgs, int nResults, int errfunc); // 0x00000001878355D8-0x00000001878355E0
		public static extern double lua_tonumber(IntPtr L, int index); // 0x0000000187834C64-0x0000000187834C6C
		public static extern int xlua_tointeger(IntPtr L, int index); // 0x00000001878345A0-0x00000001878345A8
		public static extern uint xlua_touint(IntPtr L, int index); // 0x000000018783A310-0x000000018783A318
		public static extern bool lua_toboolean(IntPtr L, int index); // 0x00000001851CECB0-0x00000001851CED10
		public static extern IntPtr lua_topointer(IntPtr L, int index); // 0x000000018D9EAC3C-0x000000018D9EAC44
		public static extern IntPtr lua_tolstring(IntPtr L, int index, out IntPtr strLen); // 0x00000001878365EC-0x00000001878365F4
		public static string lua_tostring_beyond(IntPtr L, int index); // 0x00000001854E15A0-0x00000001854E15E0
		public static string lua_tostring(IntPtr L, int index, bool cache = false /* Metadata: 0x02645054 */); // 0x00000001854E15E0-0x00000001854E19A0
		public static extern IntPtr lua_atpanic(IntPtr L, lua_CSFunction panicf); // 0x0000000185AFBD40-0x0000000185AFBD70
		public static extern void lua_pushnumber(IntPtr L, double number); // 0x00000001878355D0-0x00000001878355D8
		public static extern void lua_pushboolean(IntPtr L, bool value); // 0x00000001854E1B70-0x00000001854E1B80
		public static extern void xlua_pushinteger(IntPtr L, int value); // 0x00000001854E28D0-0x00000001854E28E0
		public static extern void xlua_pushuint(IntPtr L, uint value); // 0x0000000185D37C00-0x0000000185D37C10
		public static void lua_pushstring(IntPtr L, string str); // 0x00000001851F50C0-0x00000001851F5350
		public static extern void xlua_pushlstring(IntPtr L, byte[] str, int size); // 0x00000001851F5D50-0x00000001851F5D70
		public static void xlua_pushasciistring(IntPtr L, string str); // 0x00000001851F7590-0x00000001851F7770
		public static void lua_pushstring(IntPtr L, byte[] str); // 0x0000000186606B00-0x0000000186606B50
		public static byte[] lua_tobytes(IntPtr L, int index); // 0x000000018D9EAB58-0x000000018D9EAC3C
		public static extern int luaL_newmetatable(IntPtr L, string meta); // 0x00000001854C0BE0-0x00000001854C0C20
		public static extern int xlua_pgettable(IntPtr L, int idx); // 0x0000000187834C5C-0x0000000187834C64
		public static extern int xlua_psettable(IntPtr L, int idx); // 0x0000000187834C44-0x0000000187834C4C
		public static void luaL_getmetatable(IntPtr L, string meta); // 0x00000001854C08E0-0x00000001854C0930
		public static extern int xluaL_loadbuffer(IntPtr L, byte[] buff, int size, string name); // 0x0000000185C4A6B0-0x0000000185C4A720
		public static int luaL_loadbuffer(IntPtr L, string buff, string name); // 0x000000018D9EA8E8-0x000000018D9EA980
		public static extern int xlua_tocsobj_safe(IntPtr L, int obj); // 0x0000000187834590-0x0000000187834598
		public static extern int xlua_tocsobj_fast(IntPtr L, int obj); // 0x0000000187834C04-0x0000000187834C0C
		public static int lua_error(IntPtr L); // 0x000000018D9EA998-0x000000018D9EA9E4
		public static extern bool lua_checkstack(IntPtr L, int extra); // 0x0000000185C4CA70-0x0000000185C4CA90
		public static extern int lua_next(IntPtr L, int index); // 0x000000018D9EAAE8-0x000000018D9EAAF0
		public static extern void lua_pushlightuserdata(IntPtr L, IntPtr udata); // 0x000000018783C170-0x000000018783C178
		public static extern IntPtr xlua_tag(); // 0x000000018783C168-0x000000018783C170
		public static extern void luaL_where(IntPtr L, int level); // 0x000000018D9EA988-0x000000018D9EA990
		public static extern int xlua_tryget_cachedud(IntPtr L, int key, int cache_ref); // 0x0000000187834710-0x0000000187834718
		public static extern void xlua_pushcsobj(IntPtr L, int key, int meta_ref, bool need_cache, int cache_ref); // 0x000000018D9EAEC0-0x000000018D9EAECC
		public static extern int gen_obj_indexer(IntPtr L); // 0x000000018783B764-0x000000018783B76C
		public static extern int gen_obj_newindexer(IntPtr L); // 0x000000018783B76C-0x000000018783B774
		public static extern int gen_cls_indexer(IntPtr L); // 0x000000018783B754-0x000000018783B75C
		public static extern int gen_cls_newindexer(IntPtr L); // 0x000000018783B75C-0x000000018783B764
		public static extern int get_error_func_ref(IntPtr L); // 0x0000000187839E48-0x0000000187839E50
		public static extern int load_error_func(IntPtr L, int Ref); // 0x00000001878355C0-0x00000001878355C8
		public static extern int luaopen_i64lib(IntPtr L); // 0x0000000187839E50-0x0000000187839E58
		public static extern int luaopen_socket_core(IntPtr L); // 0x000000018D9EAC44-0x000000018D9EAC4C
		public static extern void lua_pushint64(IntPtr L, long n); // 0x00000001854E20B0-0x00000001854E20C0
		public static extern void lua_pushuint64(IntPtr L, ulong n); // 0x00000001854E37E0-0x00000001854E37F0
		public static extern bool lua_isint64(IntPtr L, int idx); // 0x0000000185FBC820-0x0000000185FBC840
		public static extern bool lua_isuint64(IntPtr L, int idx); // 0x0000000185FBC820-0x0000000185FBC840
		public static extern long lua_toint64(IntPtr L, int idx); // 0x00000001878345A0-0x00000001878345A8
		public static extern ulong lua_touint64(IntPtr L, int idx); // 0x00000001878345A0-0x00000001878345A8
		public static extern void xlua_push_csharp_function(IntPtr L, IntPtr fn, int n); // 0x0000000187836630-0x0000000187836638
		public static extern int xlua_csharp_str_error(IntPtr L, string message); // 0x000000018D9EAC54-0x000000018D9EAC94
		public static extern int xlua_csharp_error(IntPtr L); // 0x000000018D9EAC4C-0x000000018D9EAC54
		public static extern bool xlua_pack_int8_t(IntPtr buff, int offset, byte field); // 0x000000018D9EAE5C-0x000000018D9EAE70
		public static extern bool xlua_unpack_int8_t(IntPtr buff, int offset, out byte field); // 0x000000018D9EAFEC-0x000000018D9EB000
		public static extern bool xlua_pack_int16_t(IntPtr buff, int offset, short field); // 0x000000018D9EAE34-0x000000018D9EAE48
		public static extern bool xlua_unpack_int16_t(IntPtr buff, int offset, out short field); // 0x000000018D9EAFD8-0x000000018D9EAFEC
		public static extern bool xlua_pack_int32_t(IntPtr buff, int offset, int field); // 0x00000001863227D0-0x00000001863227F0
		public static extern bool xlua_unpack_int32_t(IntPtr buff, int offset, out int field); // 0x000000018D9EAFC4-0x000000018D9EAFD8
		public static extern bool xlua_pack_int64_t(IntPtr buff, int offset, long field); // 0x000000018D9EAE48-0x000000018D9EAE5C
		public static extern bool xlua_unpack_int64_t(IntPtr buff, int offset, out long field); // 0x000000018D9EAEFC-0x000000018D9EAF10
		public static extern bool xlua_pack_float(IntPtr buff, int offset, float field); // 0x000000018D9EAE20-0x000000018D9EAE34
		public static extern bool xlua_unpack_float(IntPtr buff, int offset, out float field); // 0x000000018D9EAFC4-0x000000018D9EAFD8
		public static extern bool xlua_pack_double(IntPtr buff, int offset, double field); // 0x000000018D9EAD84-0x000000018D9EAD98
		public static extern bool xlua_unpack_double(IntPtr buff, int offset, out double field); // 0x000000018D9EAEFC-0x000000018D9EAF10
		public static extern IntPtr xlua_pushstruct(IntPtr L, uint size, int meta_ref); // 0x00000001878365FC-0x0000000187836604
		public static extern void xlua_pushcstable(IntPtr L, uint field_count, int meta_ref); // 0x000000018D9EAECC-0x000000018D9EAED4
		public static extern IntPtr lua_touserdata(IntPtr L, int idx); // 0x00000001878365F4-0x00000001878365FC
		public static extern int xlua_gettypeid(IntPtr L, int idx); // 0x0000000187834C84-0x0000000187834C8C
		public static extern int xlua_get_registry_index(); // 0x0000000187839E58-0x0000000187839E60
		public static extern int xlua_pgettable_bypath(IntPtr L, int idx, string path); // 0x0000000186968440-0x0000000186968490
		public static extern int xlua_psettable_bypath(IntPtr L, int idx, string path); // 0x000000018D9EAE70-0x000000018D9EAEC0
		public static extern bool xlua_pack_float2(IntPtr buff, int offset, float f1, float f2); // 0x00000001854E5230-0x00000001854E5250
		public static extern bool xlua_unpack_float2(IntPtr buff, int offset, out float f1, out float f2); // 0x000000018D9EAF10-0x000000018D9EAF24
		public static extern bool xlua_pack_float3(IntPtr buff, int offset, float f1, float f2, float f3); // 0x00000001854E4610-0x00000001854E4640
		public static extern bool xlua_unpack_float3(IntPtr buff, int offset, out float f1, out float f2, out float f3); // 0x0000000186E67310-0x0000000186E67340
		public static extern bool xlua_pack_float4(IntPtr buff, int offset, float f1, float f2, float f3, float f4); // 0x00000001857E5A80-0x00000001857E5AB0
		public static extern bool xlua_unpack_float4(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4); // 0x000000018D9EAF24-0x000000018D9EAF4C
		public static extern bool xlua_pack_float5(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5); // 0x000000018D9EAD98-0x000000018D9EADD4
		public static extern bool xlua_unpack_float5(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5); // 0x000000018D9EAF4C-0x000000018D9EAF80
		public static extern bool xlua_pack_float6(IntPtr buff, int offset, float f1, float f2, float f3, float f4, float f5, float f6); // 0x000000018D9EADD4-0x000000018D9EAE20
		public static extern bool xlua_unpack_float6(IntPtr buff, int offset, out float f1, out float f2, out float f3, out float f4, out float f5, out float f6); // 0x000000018D9EAF80-0x000000018D9EAFC4
		public static extern bool xlua_pack_decimal(IntPtr buff, int offset, ref decimal dec); // 0x000000018D9EAD70-0x000000018D9EAD84
		public static extern bool xlua_unpack_decimal(IntPtr buff, int offset, out byte scale, out byte sign, out int hi32, out ulong lo64); // 0x000000018D9EAED4-0x000000018D9EAEFC
		public static bool xlua_is_eq_str(IntPtr L, int index, string str); // 0x000000018D9EAC94-0x000000018D9EAD14
		public static extern bool xlua_is_eq_str(IntPtr L, int index, string str, int str_len); // 0x000000018D9EAD14-0x000000018D9EAD70
		public static extern IntPtr xlua_gl(IntPtr L); // 0x000000018783D884-0x000000018783D88C
		public static extern int luaL_traceback(IntPtr L, IntPtr L1, string msg, int level); // 0x0000000185C49C80-0x0000000185C49CE0
		public static extern int lua_sethook(IntPtr L, XLua.LuaDLL.lua_Hook hook, int mask, int count); // 0x000000018D9EAB10-0x000000018D9EAB50
		public static extern XLua.LuaDLL.lua_Hook lua_gethook(IntPtr L); // 0x000000018D9EA9EC-0x000000018D9EAA30
		public static extern int lua_gethookmask(IntPtr L); // 0x000000018D9EAA30-0x000000018D9EAA38
		public static extern int lua_getglobal(IntPtr L, IntPtr charPtr); // 0x000000018D9EA9E4-0x000000018D9EA9EC
		public static extern int lua_pushlstring(IntPtr L, IntPtr charPtr, int len); // 0x0000000187839650-0x0000000187839658
		public static extern int luaopen_HyperLua(IntPtr L); // 0x000000018783D9C0-0x000000018783D9C8
		public static extern void HyperLua_SetLogCallback(HyperLuaLogCallbackDelegate logCallback); // 0x0000000185AFBD70-0x0000000185AFBD90
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadHyperLua(IntPtr L); // 0x0000000187184860-0x00000001871848B0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static void SetHyperLuaLogCallback(HyperLuaLogCallbackDelegate logCallback); // 0x00000001871FC200-0x00000001871FC250
		public static extern int luaopen_LuaUtils(IntPtr L); // 0x000000018783D9B0-0x000000018783D9B8
		public static extern void LuaUtils_SetLogCallback(LuaUtilsLogCallbackDelegate logCallback); // 0x0000000185AFBD90-0x0000000185AFBDB0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLuaUtils(IntPtr L); // 0x00000001871847C0-0x0000000187184810
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static void SetLuaUtilsLogCallback(LuaUtilsLogCallbackDelegate logCallback); // 0x00000001871FC1B0-0x00000001871FC200
		public static extern int luaopen_rapidjson(IntPtr L); // 0x000000018783D9A8-0x000000018783D9B0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadRapidJson(IntPtr L); // 0x0000000187184770-0x00000001871847C0
		public static extern int luaopen_pb(IntPtr L); // 0x000000018783D9B8-0x000000018783D9C0
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int LoadLuaProtobuf(IntPtr L); // 0x0000000187184810-0x0000000187184860
		public static extern void beyond_setDecryptionFunc(IntPtr L, IntPtr func); // 0x0000000187839E30-0x0000000187839E38
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int lua_Hook(IntPtr L, ref lua_debug ar); // TypeDefIndex: 85606; 0x00000001859B7730-0x00000001859B7740
}

namespace XLua.Reflection
{
	public class LuaObjFieldGetterSetter // TypeDefIndex: 85588
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0<T> // TypeDefIndex: 85570
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
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 85571
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjFloatFieldGetterByPushNumber_b__0(IntPtr L); // 0x00000001861F79F0-0x00000001861F7AB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 85572
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjDoubleFieldGetterByPushNumber_b__0(IntPtr L); // 0x000000018D9EE058-0x000000018D9EE1D8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0<T> // TypeDefIndex: 85573
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
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 85574
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjFieldGetterByPushBool_b__0(IntPtr L); // 0x00000001854E19A0-0x00000001854E1B70
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 85575
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass8_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjFieldGetterByPushString_b__0(IntPtr L); // 0x0000000185C1E120-0x0000000185C1E590
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 85576
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjFieldObjGetter_b__0(IntPtr L); // 0x0000000185115B80-0x0000000185115DC0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 85577
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
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjFieldStructGetter_b__0(IntPtr L); // 0x000000018607AB40-0x000000018607AE80
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 85578
		{
			// Fields
			public System.Type type; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public int offset; // 0x20
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjFieldEnumGetter_b__0(IntPtr L); // 0x00000001855BAF40-0x00000001855BB780
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0<T> // TypeDefIndex: 85579
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
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 85580
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public System.Type type; // 0x18
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjFieldObjSetter_b__0(IntPtr L); // 0x00000001855BC350-0x00000001855BC560
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 85581
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
			public bool isNullable; // 0x2C
			public int size; // 0x30
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjFieldStructSetter_b__0(IntPtr L); // 0x000000018670B750-0x000000018670C540
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0<T> // TypeDefIndex: 85582
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
		private sealed class __c__DisplayClass16_0<T> // TypeDefIndex: 85583
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
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 85584
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjFloatFieldSetterByGetNumber_b__0(IntPtr L); // 0x00000001864453C0-0x00000001864454F0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 85585
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass18_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjDoubleFieldSetterByGetNumber_b__0(IntPtr L); // 0x000000018D9EDB38-0x000000018D9EDCAC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 85586
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjFieldBoolSetter_b__0(IntPtr L); // 0x0000000186328670-0x0000000186328720
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 85587
		{
			// Fields
			public bool isUnmanagedType; // 0x10
			public System.Reflection.FieldInfo field; // 0x18
			public System.Type type; // 0x20
			public int offset; // 0x28
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetObjFieldEnumSetter_b__0(IntPtr L); // 0x0000000186C6AC10-0x0000000186C6AD90
		}
	
		// Constructors
		public LuaObjFieldGetterSetter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static bool _CheckRuntimeType(IntPtr L, object obj, System.Type type, System.Reflection.FieldInfo field); // 0x000000018D9E9E40-0x000000018D9EA010
		private static IntPtr _GetPtrFromObj(object obj); // 0x000000018D9EA0E0-0x000000018D9EA134
		private static IntPtr _GetPtrFromLuaStack(IntPtr L, ObjectTranslator translator, int index, bool isUnmanagedType); // 0x000000018D9EA010-0x000000018D9EA0E0
		public static lua_CSFunction GetObjFieldGetterByPushInt32<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct;
		public static lua_CSFunction GetObjFloatFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field); // 0x00000001864EF490-0x00000001864EF540
		public static lua_CSFunction GetObjDoubleFieldGetterByPushNumber(System.Type type, System.Reflection.FieldInfo field); // 0x000000018694FD00-0x000000018694FDE0
		public static lua_CSFunction GetObjFieldGetterByPushInt64<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct;
		public static lua_CSFunction GetObjFieldGetterByPushBool(System.Type type, System.Reflection.FieldInfo field); // 0x00000001854C23D0-0x00000001854C2480
		public static lua_CSFunction GetObjFieldGetterByPushString(System.Type type, System.Reflection.FieldInfo field); // 0x00000001854C2320-0x00000001854C23D0
		public static lua_CSFunction GetObjFieldObjGetter(System.Type type, System.Reflection.FieldInfo field); // 0x00000001854C2920-0x00000001854C29E0
		public static lua_CSFunction GetObjFieldStructGetter(System.Type type, System.Reflection.FieldInfo field); // 0x000000018600C0E0-0x000000018600C270
		public static lua_CSFunction GetObjFieldEnumGetter(System.Type type, System.Reflection.FieldInfo field); // 0x00000001865CD500-0x00000001865CD5A0
		public static lua_CSFunction GetObjFieldStructGetter<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct;
		public static lua_CSFunction GetObjFieldObjSetter(System.Type type, System.Reflection.FieldInfo field); // 0x00000001854C37F0-0x00000001854C38A0
		public static lua_CSFunction GetObjFieldStructSetter(System.Type type, System.Reflection.FieldInfo field); // 0x000000018600C270-0x000000018600C680
		public static lua_CSFunction GetObjFieldSetterByGetInt32<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct;
		public static lua_CSFunction GetObjFieldSetterByGetInt64<T>(System.Type type, System.Reflection.FieldInfo field)
			where T : struct;
		public static lua_CSFunction GetObjFloatFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field); // 0x00000001864EF3E0-0x00000001864EF490
		public static lua_CSFunction GetObjDoubleFieldSetterByGetNumber(System.Type type, System.Reflection.FieldInfo field); // 0x000000018694FC20-0x000000018694FD00
		public static lua_CSFunction GetObjFieldBoolSetter(System.Type type, System.Reflection.FieldInfo field); // 0x00000001854C2480-0x00000001854C2530
		public static lua_CSFunction GetObjFieldEnumSetter(System.Type type, System.Reflection.FieldInfo field); // 0x0000000186578260-0x0000000186578310
	}

	public static class RuntimeEnumDic // TypeDefIndex: 85589
	{
		// Fields
		private static Dictionary<System.Type, Dictionary<int, object>> s_enumDic; // 0x00
	
		// Constructors
		static RuntimeEnumDic(); // 0x0000000187176F10-0x0000000187176FA0
	
		// Methods
		public static object GetEnumByTypeAndValue(System.Type enumType, int value); // 0x00000001855BB780-0x00000001855BBD80
		public static void AddEnumValue(System.Type enumType, object enumObj); // 0x00000001855BC560-0x00000001855BC6E0
	}
}

namespace XLua.TemplateEngine
{
	public enum TokenType // TypeDefIndex: 85564
	{
		Code = 0,
		Eval = 1,
		Text = 2
	}

	public class Chunk // TypeDefIndex: 85565
	{
		// Fields
		[CompilerGenerated]
		private TokenType _Type_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Text_k__BackingField; // 0x18
	
		// Properties
		public TokenType Type { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public string Text { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public Chunk(TokenType type, string text); // 0x0000000185CF10D0-0x0000000185CF1300
	}

	internal class TemplateFormatException : Exception // TypeDefIndex: 85566
	{
		// Constructors
		public TemplateFormatException(string message); // 0x000000018D9EBD44-0x000000018D9EBD90
	}

	public class Parser // TypeDefIndex: 85568
	{
		// Fields
		[CompilerGenerated]
		private static string _RegexString_k__BackingField; // 0x00
	
		// Properties
		public static string RegexString { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D9EBC58-0x000000018D9EBCA8 0x000000018D9EBCA8-0x000000018D9EBD04
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 85567
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Text.RegularExpressions.Capture, __f__AnonymousType0<TokenType, string, int>> __9__7_0; // 0x08
			public static Func<System.Text.RegularExpressions.Capture, __f__AnonymousType0<TokenType, string, int>> __9__7_1; // 0x10
			public static Func<System.Text.RegularExpressions.Capture, __f__AnonymousType0<TokenType, string, int>> __9__7_2; // 0x18
			public static Func<__f__AnonymousType0<TokenType, string, int>, int> __9__7_3; // 0x20
			public static Func<__f__AnonymousType0<TokenType, string, int>, Chunk> __9__7_4; // 0x28
	
			// Constructors
			static __c(); // 0x000000018D9EE820-0x000000018D9EE884
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal __f__AnonymousType0<TokenType, string, int> _Parse_b__7_0(System.Text.RegularExpressions.Capture p); // 0x000000018D9EC62C-0x000000018D9EC6C4
			internal __f__AnonymousType0<TokenType, string, int> _Parse_b__7_1(System.Text.RegularExpressions.Capture p); // 0x000000018D9EC6C4-0x000000018D9EC784
			internal __f__AnonymousType0<TokenType, string, int> _Parse_b__7_2(System.Text.RegularExpressions.Capture p); // 0x000000018D9EC784-0x000000018D9EC820
			internal int _Parse_b__7_3(__f__AnonymousType0<TokenType, string, int> p); // 0x000000018D9EC820-0x000000018D9EC85C
			internal Chunk _Parse_b__7_4(__f__AnonymousType0<TokenType, string, int> m); // 0x000000018D9EC85C-0x000000018D9EC8E4
		}
	
		// Constructors
		static Parser(); // 0x000000018D9EBBE8-0x000000018D9EBC58
		public Parser(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static string EscapeString(string input); // 0x000000018D9EB000-0x000000018D9EB298
		private static string GetRegexString(); // 0x000000018D9EB298-0x000000018D9EB4D0
		public static List<Chunk> Parse(string snippet); // 0x000000018D9EB4D0-0x000000018D9EBBE8
	}

	public class LuaTemplate // TypeDefIndex: 85569
	{
		// Fields
		private static lua_CSFunction templateCompileFunction; // 0x00
		private static lua_CSFunction templateExecuteFunction; // 0x08
	
		// Constructors
		public LuaTemplate(); // 0x0000000186805BA0-0x0000000186805BB0
		static LuaTemplate(); // 0x000000018707BD80-0x000000018707BE70
	
		// Methods
		public static string ComposeCode(List<Chunk> chunks); // 0x000000018D9EA398-0x000000018D9EA630
		public static LuaFunction Compile(LuaEnv luaenv, string snippet); // 0x000000018D9EA134-0x000000018D9EA1DC
		public static string Execute(LuaFunction compiledTemplate, LuaTable parameters); // 0x000000018D9EA708-0x000000018D9EA798
		public static string Execute(LuaFunction compiledTemplate); // 0x000000018D9EA798-0x000000018D9EA810
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Compile(IntPtr L); // 0x000000018D9EA1DC-0x000000018D9EA398
		[XLua.MonoPInvokeCallback(typeof(lua_CSFunction))]
		public static int Execute(IntPtr L); // 0x000000018D9EA630-0x000000018D9EA708
		public static void OpenLib(IntPtr L); // 0x0000000185C498D0-0x0000000185C49A00
	}
}
