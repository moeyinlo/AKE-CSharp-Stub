/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

// Image 68: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59589-59625

namespace IFix
{
	public class CustomBridgeAttribute : Attribute // TypeDefIndex: 59616
	{
		// Constructors
		public CustomBridgeAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix.Core
{
	public class IDTagAttribute : Attribute // TypeDefIndex: 59590
	{
		// Fields
		public int ID; // 0x10
	
		// Constructors
		public IDTagAttribute() {} // Dummy constructor
		public IDTagAttribute(int id) {} // 0x0000000181378230-0x0000000181378240
	}

	public static class PatchManager // TypeDefIndex: 59594
	{
		// Fields
		private static Dictionary<Assembly, Action> removers; // 0x00
		private static Func<ParameterInfo, System.Type> __f__am_cache0; // 0x08
	
		// Nested types
		private sealed class _readMethod_c__AnonStorey0 // TypeDefIndex: 59591
		{
			// Fields
			internal System.Type[] genericArgInfos; // 0x10
	
			// Constructors
			public _readMethod_c__AnonStorey0() {} // 0x000000018A9A7890-0x000000018A9A8260
	
			// Methods
			internal string __m__0(System.Text.RegularExpressions.Match m) => default; // 0x000000018A9A7610-0x000000018A9A7890
		}
	
		private sealed class _Load_c__AnonStorey1 // TypeDefIndex: 59592
		{
			// Fields
			internal List<IntPtr> nativePointers; // 0x10
	
			// Constructors
			public _Load_c__AnonStorey1() {} // 0x000000018A9A8260-0x000000018A9A8530
		}
	
		private sealed class _Load_c__AnonStorey2 // TypeDefIndex: 59593
		{
			// Fields
			internal WrappersManager wrapperManager; // 0x10
			internal _Load_c__AnonStorey1 __f__ref_1; // 0x18
	
			// Constructors
			public _Load_c__AnonStorey2() {} // 0x000000018A9A2C78-0x000000018A9A73E8
	
			// Methods
			internal void __m__0() {} // 0x000000018A9A73E8-0x000000018A9A7584
			internal void __m__1() {} // 0x000000018A9A7584-0x000000018A9A7610
		}
	
		// Constructors
		static PatchManager() {} // 0x000000018A9A9AD4-0x000000018A9A9B74
	
		// Methods
		private static MethodBase readMethod(BinaryReader reader, System.Type[] externTypes) => default; // 0x00000001864C22B8-0x00000001864C22D0
		private static int getMapId(List<System.Type> idMapArray, MethodBase method) => default; // 0x0000000185492010-0x0000000185492020
		private static int[] readSlotInfo(BinaryReader reader, Dictionary<MethodInfo, int> itfMethodToId, System.Type[] externTypes, int maxId) => default; // 0x000000018A9A9B94-0x000000018A9A9C00
		public static VirtualMachine Load(Stream stream, bool checkNew = true /* Metadata: 0x02080C64 */) => default; // 0x0000000185492010-0x0000000185492020
		public static void Unload(Assembly assembly) {} // 0x0000000185492010-0x0000000185492020
		private static System.Type _readMethod_m__0(ParameterInfo p) => default; // 0x000000018A9A9B74-0x000000018A9A9B94
	}

	public enum Code // TypeDefIndex: 59595
	{
		Blt_Un = 0,
		Ldind_U1 = 1,
		Stelem_Any = 2,
		Ldelem_I = 3,
		Endfinally = 4,
		Arglist = 5,
		Shl = 6,
		Conv_Ovf_I4 = 7,
		Stloc = 8,
		Refanytype = 9,
		Callvirt = 10,
		Ldelem_R8 = 11,
		Unaligned = 12,
		Conv_I2 = 13,
		Ldfld = 14,
		Sizeof = 15,
		Newanon = 16,
		Sub = 17,
		Conv_Ovf_U2 = 18,
		Cgt_Un = 19,
		Call = 20,
		Stind_R8 = 21,
		Conv_Ovf_I8 = 22,
		Readonly = 23,
		Newobj = 24,
		Shr_Un = 25,
		Ldvirtftn = 26,
		Jmp = 27,
		Cgt = 28,
		Ldtoken = 29,
		Conv_Ovf_U = 30,
		Ldind_Ref = 31,
		Conv_Ovf_I_Un = 32,
		Conv_I1 = 33,
		Ldloc = 34,
		Ldind_R8 = 35,
		Ldind_U4 = 36,
		Ldlen = 37,
		Rem_Un = 38,
		Starg = 39,
		Calli = 40,
		Conv_Ovf_U1_Un = 41,
		Add = 42,
		Switch = 43,
		CallExtern = 44,
		Ldelem_I8 = 45,
		Ldelema = 46,
		Div = 47,
		Br = 48,
		Ret = 49,
		Ldind_I4 = 50,
		Clt = 51,
		Conv_I4 = 52,
		Ceq = 53,
		Conv_U = 54,
		Initobj = 55,
		Stelem_Ref = 56,
		Mul_Ovf_Un = 57,
		Ldstr = 58,
		Mul_Ovf = 59,
		Sub_Ovf = 60,
		Ldelem_U1 = 61,
		Conv_I = 62,
		Conv_U4 = 63,
		Blt = 64,
		Conv_Ovf_I = 65,
		No = 66,
		Brtrue = 67,
		Unbox_Any = 68,
		Not = 69,
		Neg = 70,
		Ldind_I8 = 71,
		Stind_Ref = 72,
		Conv_R4 = 73,
		Conv_Ovf_U4 = 74,
		Conv_Ovf_U8 = 75,
		Ldind_I = 76,
		Tail = 77,
		Initblk = 78,
		Conv_Ovf_U8_Un = 79,
		Shr = 80,
		Callvirtvirt = 81,
		StackSpace = 82,
		Ldsflda = 83,
		Ble = 84,
		Ldloca = 85,
		Ldtype = 86,
		Conv_I8 = 87,
		Conv_Ovf_U2_Un = 88,
		Add_Ovf = 89,
		Isinst = 90,
		Stobj = 91,
		Conv_Ovf_I1_Un = 92,
		Cpblk = 93,
		Pop = 94,
		And = 95,
		Box = 96,
		Mul = 97,
		Conv_U1 = 98,
		Nop = 99,
		Conv_R_Un = 100,
		Ldarga = 101,
		Bgt = 102,
		Break = 103,
		Div_Un = 104,
		Ldc_I4 = 105,
		Refanyval = 106,
		Conv_U8 = 107,
		Bgt_Un = 108,
		Stelem_R8 = 109,
		Bge = 110,
		Ldflda = 111,
		Ldelem_I1 = 112,
		Localloc = 113,
		Ldind_I1 = 114,
		Ldelem_U4 = 115,
		Volatile = 116,
		Ldarg = 117,
		Ldftn = 118,
		Xor = 119,
		Conv_Ovf_I2 = 120,
		Conv_Ovf_U_Un = 121,
		Stind_I2 = 122,
		Ldc_R4 = 123,
		Stelem_I2 = 124,
		Or = 125,
		Castclass = 126,
		Newarr = 127,
		Throw = 128,
		Conv_U2 = 129,
		Clt_Un = 130,
		Conv_Ovf_U4_Un = 131,
		Dup = 132,
		Ldvirtftn2 = 133,
		Add_Ovf_Un = 134,
		Ldc_R8 = 135,
		Ldelem_Any = 136,
		Sub_Ovf_Un = 137,
		Brfalse = 138,
		Conv_R8 = 139,
		Unbox = 140,
		Endfilter = 141,
		Rethrow = 142,
		Rem = 143,
		Ldnull = 144,
		Conv_Ovf_U1 = 145,
		Stfld = 146,
		Stelem_I = 147,
		Mkrefany = 148,
		Stelem_R4 = 149,
		Ldc_I8 = 150,
		Cpobj = 151,
		Stind_I8 = 152,
		Bne_Un = 153,
		Constrained = 154,
		Stelem_I1 = 155,
		Beq = 156,
		Bge_Un = 157,
		Ldind_I2 = 158,
		Ldelem_I2 = 159,
		Conv_Ovf_I8_Un = 160,
		Conv_Ovf_I1 = 161,
		Ldobj = 162,
		Leave = 163,
		Stind_I = 164,
		Stind_I1 = 165,
		Ldelem_R4 = 166,
		Conv_Ovf_I4_Un = 167,
		Ldelem_I4 = 168,
		Ldind_R4 = 169,
		Ckfinite = 170,
		Ldelem_Ref = 171,
		Stsfld = 172,
		Ldsfld = 173,
		Stelem_I8 = 174,
		Stelem_I4 = 175,
		Ldelem_U2 = 176,
		Conv_Ovf_I2_Un = 177,
		Stind_R4 = 178,
		Ldind_U2 = 179,
		Ble_Un = 180,
		Stind_I4 = 181
	}

	public struct Instruction // TypeDefIndex: 59596
	{
		// Fields
		public Code Code; // 0x00
		public int Operand; // 0x04
	}

	public enum ExceptionHandlerType // TypeDefIndex: 59597
	{
		Catch = 0,
		Filter = 1,
		Finally = 2,
		Fault = 4
	}

	public sealed class ExceptionHandler // TypeDefIndex: 59598
	{
		// Fields
		public System.Type CatchType; // 0x10
		public int CatchTypeId; // 0x18
		public int HandlerEnd; // 0x1C
		public int HandlerStart; // 0x20
		public ExceptionHandlerType HandlerType; // 0x24
		public int TryEnd; // 0x28
		public int TryStart; // 0x2C
	
		// Constructors
		public ExceptionHandler() {} // 0x0000000185492010-0x0000000185492020
	}

	public class AnonymousStorey // TypeDefIndex: 59599
	{
		// Fields
		private Value[] unmanagedFields; // 0x10
		private object[] managedFields; // 0x18
		internal int typeId; // 0x20
		protected VirtualMachine virtualMachine; // 0x28
		private int equalMethodId; // 0x30
		private int finalizeMethodId; // 0x34
		private int getHashCodeMethodId; // 0x38
		private int toStringMethodId; // 0x3C
	
		// Constructors
		public AnonymousStorey() {} // Dummy constructor
		public AnonymousStorey(int fieldNum, int[] fieldTypes, int typeID, int[] vTable, VirtualMachine virtualMachine) {} // 0x000000018A99EC80-0x000000018A99EE98
	
		// Methods
		internal unsafe void Ldfld(int fieldIndex, Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack) {} // 0x000000018A99E9AC-0x000000018A99EA88
		internal unsafe void Stfld(int fieldIndex, Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack) {} // 0x000000018A99EAFC-0x000000018A99EBC0
		internal object Get(int fieldIndex, System.Type type, VirtualMachine virtualMachine, bool valueTypeClone) => default; // 0x000000018A99E930-0x000000018A99E9AC
		internal void Set(int fieldIndex, object obj, System.Type type, VirtualMachine virtualMachine) {} // 0x000000018A99EA88-0x000000018A99EAFC
		public bool ObjectEquals(object obj) => default; // 0x000000018406FBE0-0x000000018406FBF0
		public override bool Equals(object obj) => default; // 0x000000018A99E6F0-0x000000018A99E7AC
		public int ObjectGetHashCode() => default; // 0x0000000185FB0F10-0x0000000185FB0F20
		public override int GetHashCode() => default; // 0x000000018A99E894-0x000000018A99E930
		public string ObjectToString() => default; // 0x000000018765AF34-0x000000018765AF3C
		public override string ToString() => default; // 0x000000018A99EBC0-0x000000018A99EC80
		~AnonymousStorey() {} // 0x000000018A99E7AC-0x000000018A99E894
	}

	public class AnonymousStoreyInfo // TypeDefIndex: 59600
	{
		// Fields
		public int FieldNum; // 0x10
		public int[] FieldTypes; // 0x18
		public int CtorId; // 0x20
		public int CtorParamNum; // 0x24
		public int[] Slots; // 0x28
		public int[] VTable; // 0x30
	
		// Constructors
		public AnonymousStoreyInfo() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum ValueType // TypeDefIndex: 59601
	{
		Integer = 0,
		Long = 1,
		Float = 2,
		Double = 3,
		StackReference = 4,
		StaticFieldReference = 5,
		FieldReference = 6,
		ChainFieldReference = 7,
		Object = 8,
		ValueType = 9,
		ArrayReference = 10
	}

	public struct Value // TypeDefIndex: 59602
	{
		// Fields
		public IFix.Core.ValueType Type; // 0x00
		public int Value1; // 0x04
		public int Value2; // 0x08
	}

	internal class GenericDelegateFactory // TypeDefIndex: 59606
	{
		// Fields
		private static MethodInfo[] genericAction; // 0x00
		private static MethodInfo[] genericFunc; // 0x08
		private static Dictionary<System.Type, Func<GenericDelegate, Delegate>> genericDelegateCreatorCache; // 0x10
		private static Func<MethodInfo, bool> __f__am_cache0; // 0x18
		private static Func<MethodInfo, int> __f__am_cache1; // 0x20
		private static Func<MethodInfo, bool> __f__am_cache2; // 0x28
		private static Func<MethodInfo, int> __f__am_cache3; // 0x30
		private static Func<ParameterInfo, bool> __f__am_cache4; // 0x38
		private static Func<GenericDelegate, Delegate> __f__am_cache5; // 0x40
		private static Func<ParameterInfo, System.Type> __f__am_cache6; // 0x48
	
		// Nested types
		private sealed class _Create_c__AnonStorey0 // TypeDefIndex: 59603
		{
			// Fields
			internal System.Type delegateType; // 0x10
	
			// Constructors
			public _Create_c__AnonStorey0() {} // 0x000000018A9A1DC4-0x000000018A9A1F84
		}
	
		private sealed class _Create_c__AnonStorey1 // TypeDefIndex: 59604
		{
			// Fields
			internal MethodInfo methodInfo; // 0x10
			internal _Create_c__AnonStorey0 __f__ref_0; // 0x18
	
			// Constructors
			public _Create_c__AnonStorey1() {} // 0x000000018A9A1264-0x000000018A9A1DC4
	
			// Methods
			internal Delegate __m__0(GenericDelegate o) => default; // 0x000000018A9A20A0-0x000000018A9A2180
		}
	
		private sealed class _Create_c__AnonStorey2 // TypeDefIndex: 59605
		{
			// Fields
			internal MethodInfo methodInfo; // 0x10
			internal _Create_c__AnonStorey0 __f__ref_0; // 0x18
	
			// Constructors
			public _Create_c__AnonStorey2() {} // 0x000000018A9A1F84-0x000000018A9A1FD8
	
			// Methods
			internal Delegate __m__0(GenericDelegate o) => default; // 0x000000018A9A1FD8-0x000000018A9A2004
		}
	
		// Constructors
		public GenericDelegateFactory() {} // Dummy constructor
		static GenericDelegateFactory() {} // 0x000000018A9A2058-0x000000018A9A20A0
	
		// Methods
		private static void PreventStripping(object obj) {} // 0x000000018A9A2004-0x000000018A9A2058
		internal static Delegate Create(System.Type delegateType, VirtualMachine virtualMachine, int methodId, object anonObj) => default; // 0x000000018A9A1FD8-0x000000018A9A2004
		private static bool _Create_m__0(MethodInfo m) => default; // 0x00000001813AE580-0x00000001813AE590
		private static int _Create_m__1(MethodInfo m) => default; // 0x00000001864C22B8-0x00000001864C22D0
		private static bool _Create_m__2(MethodInfo m) => default; // 0x0000000185492010-0x0000000185492020
		private static int _Create_m__3(MethodInfo m) => default; // 0x0000000185492010-0x0000000185492020
		private static bool _Create_m__4(ParameterInfo p) => default; // 0x000000018A9A9AAC-0x000000018A9A9AD4
		private static Delegate _Create_m__5(GenericDelegate x) => default; // 0x0000000185492010-0x0000000185492020
		private static System.Type _Create_m__6(ParameterInfo pinfo) => default; // 0x000000018A9A9AAC-0x000000018A9A9AD4
	}

	internal class GenericDelegate // TypeDefIndex: 59607
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		private bool pushSelf; // 0x28
		private int extraArgNum; // 0x2C
	
		// Constructors
		public GenericDelegate() {} // Dummy constructor
		internal GenericDelegate(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x000000018A9A2214-0x000000018A9A2254
	
		// Methods
		public void Action() {} // 0x000000018A9A2180-0x000000018A9A2214
		public void Action<T1>(T1 p1)
			where T1 : class {}
		public void Action<T1, T2>(T1 p1, T2 p2)
			where T1 : class
			where T2 : class {}
		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3)
			where T1 : class
			where T2 : class
			where T3 : class {}
		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4)
			where T1 : class
			where T2 : class
			where T3 : class
			where T4 : class {}
		public TResult Func<TResult>()
			where TResult : class => default;
		public TResult Func<T1, TResult>(T1 p1)
			where T1 : class
			where TResult : class => default;
		public TResult Func<T1, T2, TResult>(T1 p1, T2 p2)
			where T1 : class
			where T2 : class
			where TResult : class => default;
		public TResult Func<T1, T2, T3, TResult>(T1 p1, T2 p2, T3 p3)
			where T1 : class
			where T2 : class
			where T3 : class
			where TResult : class => default;
		public TResult Func<T1, T2, T3, T4, TResult>(T1 p1, T2 p2, T3 p3, T4 p4)
			where T1 : class
			where T2 : class
			where T3 : class
			where T4 : class
			where TResult : class => default;
	}

	public class ObjectClone // TypeDefIndex: 59610
	{
		// Fields
		private MethodInfo memberwiseClone; // 0x10
	
		// Constructors
		public ObjectClone() {} // 0x000000018A9A2BE0-0x000000018A9A2C78
	
		// Methods
		public object Clone(object obj) => default; // 0x000000018A9A2BBC-0x000000018A9A2BE0
	}

	internal class ReflectionMethodInvoker // TypeDefIndex: 59611
	{
		// Fields
		private int paramCount; // 0x10
		private bool hasThis; // 0x14
		private bool hasReturn; // 0x15
		private bool[] refFlags; // 0x18
		private bool[] outFlags; // 0x20
		private System.Type[] rawTypes; // 0x28
		private MethodBase method; // 0x30
		private ConstructorInfo ctor; // 0x38
		private System.Type returnType; // 0x40
		private bool isNullableHasValue; // 0x48
		private bool isNullableValue; // 0x49
	
		// Constructors
		public ReflectionMethodInvoker() {} // Dummy constructor
		public ReflectionMethodInvoker(MethodBase method) {} // 0x000000018A9A9460-0x000000018A9A9894
	
		// Methods
		public void Invoke(VirtualMachine virtualMachine, ref Call call, bool isInstantiate) {} // 0x000000018A9A8530-0x000000018A9A9460
	}

	internal struct UnmanagedStack // TypeDefIndex: 59612
	{
		// Fields
		public unsafe Value* Base; // 0x00
		public unsafe Value* Top; // 0x08
	}

	internal class ThreadStackInfo // TypeDefIndex: 59613
	{
		// Fields
		public unsafe UnmanagedStack* UnmanagedStack; // 0x10
		public object[] ManagedStack; // 0x18
		private IntPtr evaluationStackHandler; // 0x20
		private IntPtr unmanagedStackHandler; // 0x28
		private static LocalDataStoreSlot localSlot; // 0x00
	
		// Properties
		internal static ThreadStackInfo Stack { get => default; } // 0x000000018A9A99C8-0x000000018A9A9AAC 
	
		// Constructors
		public ThreadStackInfo() {} // 0x000000018A9A9930-0x000000018A9A99C8
		static ThreadStackInfo() {} // 0x000000018A9A98E0-0x000000018A9A9930
	}

	internal static class EvaluationStackOperation // TypeDefIndex: 59614
	{
		// Methods
		internal static unsafe void UnboxPrimitive(Value* evaluationStackPointer, object obj, System.Type type) {} // 0x000000018A9A05A4-0x000000018A9A0A78
		internal static object mGet(bool isArray, object root, int layer, int[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, Dictionary<int, NewFieldInfo> newFieldInfos) => default; // 0x000000018A9A0E20-0x000000018A9A103C
		internal static void mSet(bool isArray, object root, object val, int layer, int[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, Dictionary<int, NewFieldInfo> newFieldInfos) {} // 0x000000018A9A103C-0x000000018A9A1264
		internal static unsafe object ToObject(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, System.Type type, VirtualMachine virtualMachine, bool valueTypeClone = true /* Metadata: 0x02080DA3 */) => default; // 0x000000018A99F9AC-0x000000018A9A05A4
		public static unsafe void PushObject(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, object obj, System.Type type) {} // 0x000000018A99F644-0x000000018A99F9AC
		public static unsafe void UpdateReference(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, object obj, VirtualMachine virtualMachine, System.Type type) {} // 0x000000018A9A0A78-0x000000018A9A0E20
	}

	public struct Call // TypeDefIndex: 59615
	{
		// Fields
		internal unsafe Value* argumentBase; // 0x00
		internal unsafe Value* evaluationStackBase; // 0x08
		internal object[] managedStack; // 0x10
		internal unsafe Value* currentTop; // 0x18
		internal unsafe Value** topWriteBack; // 0x20
	
		// Methods
		public static Call Begin() => default; // 0x000000018A99EF18-0x000000018A99EFDC
		internal static Call BeginForStack(ThreadStackInfo stack) => default; // 0x000000018A99EE98-0x000000018A99EF18
		public void PushBoolean(bool b) {} // 0x000000018A99F178-0x000000018A99F1A8
		public bool GetBoolean(int offset = 0 /* Metadata: 0x02080DA4 */) => default; // 0x000000018A99EFDC-0x000000018A99F010
		public void PushByte(byte b) {} // 0x000000018A99F1A8-0x000000018A99F1B4
		public byte GetByte(int offset = 0 /* Metadata: 0x02080DA5 */) => default; // 0x000000018A99F010-0x000000018A99F018
		public sbyte GetSByte(int offset = 0 /* Metadata: 0x02080DA6 */) => default; // 0x000000018A99F010-0x000000018A99F018
		public void PushInt16(short s) {} // 0x000000018A99F1E8-0x000000018A99F1F4
		public short GetInt16(int offset = 0 /* Metadata: 0x02080DA7 */) => default; // 0x000000018A99F010-0x000000018A99F018
		public void PushChar(char c) {} // 0x000000018A99F1B4-0x000000018A99F1C0
		public char GetChar(int offset = 0 /* Metadata: 0x02080DA8 */) => default; // 0x000000018A99F010-0x000000018A99F018
		public void PushUInt16(ushort us) {} // 0x000000018A99F1B4-0x000000018A99F1C0
		public ushort GetUInt16(int offset = 0 /* Metadata: 0x02080DA9 */) => default; // 0x000000018A99F010-0x000000018A99F018
		public void PushInt32(int i) {} // 0x000000018A99F1F4-0x000000018A99F224
		public int GetInt32(int offset = 0 /* Metadata: 0x02080DAA */) => default; // 0x000000018A99F048-0x000000018A99F078
		public void PushUInt32(uint ui) {} // 0x000000018A99F3A0-0x000000018A99F3A8
		public uint GetUInt32(int offset = 0 /* Metadata: 0x02080DAB */) => default; // 0x000000018A99F010-0x000000018A99F018
		public void PushInt64(long i) {} // 0x000000018A99F224-0x000000018A99F254
		public long GetInt64(int offset = 0 /* Metadata: 0x02080DAC */) => default; // 0x000000018A99F078-0x000000018A99F0A8
		public void PushUInt64(ulong i) {} // 0x000000018A99F3A8-0x000000018A99F3B0
		public ulong GetUInt64(int offset = 0 /* Metadata: 0x02080DAD */) => default; // 0x000000018A99F0A8-0x000000018A99F0B0
		public void PushSingle(float f) {} // 0x000000018A99F378-0x000000018A99F3A0
		public float GetSingle(int offset = 0 /* Metadata: 0x02080DAE */) => default; // 0x000000018A99F148-0x000000018A99F178
		public void PushDouble(double d) {} // 0x000000018A99F1C0-0x000000018A99F1E8
		public double GetDouble(int offset = 0 /* Metadata: 0x02080DAF */) => default; // 0x000000018A99F018-0x000000018A99F048
		public void PushIntPtr(IntPtr i) {} // 0x000000018A99F254-0x000000018A99F260
		public IntPtr GetIntPtr(int offset = 0 /* Metadata: 0x02080DB0 */) => default; // 0x000000018A99F0A8-0x000000018A99F0B0
		public void PushObject(object o) {} // 0x000000018A99F29C-0x000000018A99F338
		public void PushValueType(object o) {} // 0x000000018A99F3B0-0x000000018A99F44C
		public object GetObject(int offset = 0 /* Metadata: 0x02080DB1 */) => default; // 0x000000018A99F0B0-0x000000018A99F148
		public T GetAsType<T>(int offset = 0 /* Metadata: 0x02080DB2 */) => default;
		public void PushObjectAsResult(object obj, System.Type type) {} // 0x000000018A99F260-0x000000018A99F29C
		public void PushRef(int offset) {} // 0x000000018A99F338-0x000000018A99F378
		public void UpdateReference(int offset, object obj, VirtualMachine virtualMachine, System.Type type) {} // 0x000000018A99F44C-0x000000018A99F4FC
	}

	public static class Utils // TypeDefIndex: 59617
	{
		// Fields
		private static Dictionary<System.Type, MethodInfo> delegateAdptCache; // 0x00
	
		// Constructors
		static Utils() {} // 0x000000018A9A9FD0-0x000000018A9AA05C
	
		// Methods
		public static bool IsAssignable(MethodInfo delegateMethod, MethodInfo method) => default; // 0x000000018A9A9C00-0x000000018A9A9D6C
		public static Delegate TryAdapterToDelegate(object obj, System.Type delegateType, string perfix) => default; // 0x000000018A9A9D6C-0x000000018A9A9FD0
	}

	internal class RuntimeException : Exception // TypeDefIndex: 59618
	{
		// Fields
		private Exception _Real_k__BackingField; // 0x90
	
		// Properties
		public Exception Real { get; set; } // 0x0000000181B5FFD0-0x0000000181B5FFE0 0x00000001873CBEA8-0x00000001873CBEBC
	
		// Constructors
		public RuntimeException() {} // 0x000000018A9A9894-0x000000018A9A98E0
	}

	public delegate void ExternInvoker(VirtualMachine vm, ref Call call, bool isInstantiate); // TypeDefIndex: 59619; 0x0000000181A578C0-0x0000000181A578E0

	internal class FieldAddr // TypeDefIndex: 59620
	{
		// Fields
		public object Object; // 0x10
		public int[] FieldIdList; // 0x18
	
		// Constructors
		public FieldAddr() {} // 0x0000000185492010-0x0000000185492020
	}

	public class Cleanner // TypeDefIndex: 59621
	{
		// Fields
		private static bool start; // 0x00
	
		// Constructors
		public Cleanner() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void Start() {} // 0x000000018A99F5B8-0x000000018A99F60C
		public static void Stop() {} // 0x000000018A99F60C-0x000000018A99F644
		~Cleanner() {} // 0x000000018A99F4FC-0x000000018A99F5B8
	}

	public class NewFieldInfo // TypeDefIndex: 59622
	{
		// Fields
		public string Name; // 0x10
		public System.Type DeclaringType; // 0x18
		public System.Type FieldType; // 0x20
		public int MethodId; // 0x28
		private static readonly int staticObjectKey; // 0x00
		private static readonly ThreadStackInfo stack; // 0x08
		private static readonly Dictionary<int, Dictionary<string, object>> newFieldValues; // 0x10
		private static readonly Dictionary<int, WeakReference> objList; // 0x18
	
		// Constructors
		public NewFieldInfo() {} // 0x0000000185492010-0x0000000185492020
		static NewFieldInfo() {} // 0x000000018A9A2A58-0x000000018A9A2BBC
	
		// Methods
		private object SetDefaultValue(object obj) => default; // 0x000000018A9A25B8-0x000000018A9A2630
		public static void Sweep() {} // 0x000000018A9A284C-0x000000018A9A2A58
		public void CheckInit(VirtualMachine virtualMachine, object obj) {} // 0x000000018A9A2254-0x000000018A9A2364
		public int ObjectToIndex(object obj) => default; // 0x000000018A9A2558-0x000000018A9A25B8
		public bool HasInitialize(object obj) => default; // 0x000000018A9A2450-0x000000018A9A2558
		public object GetValue(object obj) => default; // 0x000000018A9A2364-0x000000018A9A2450
		public void SetValue(object obj, object value) {} // 0x000000018A9A2630-0x000000018A9A284C
	}

	public class VirtualMachine // TypeDefIndex: 59624
	{
		// Fields
		internal ObjectClone objectClone; // 0x10
		private unsafe Instruction** unmanagedCodes; // 0x18
		private ExceptionHandler[][] exceptionHandlers; // 0x20
		private Action onDispose; // 0x28
		private ExternInvoker[] externInvokers; // 0x30
		private Dictionary<MethodBase, CalliInvokerInfo> calliInvokerCache; // 0x38
		private MethodBase[] externMethods; // 0x40
		private System.Type[] externTypes; // 0x48
		private string[] internStrings; // 0x50
		internal System.Reflection.FieldInfo[] fieldInfos; // 0x58
		internal Dictionary<int, NewFieldInfo> newFieldInfos; // 0x60
		private AnonymousStoreyInfo[] anonymousStoreyInfos; // 0x68
		private Dictionary<System.Type, Dictionary<MethodInfo, MethodInfo>> overrideCache; // 0x70
		internal System.Type[] staticFieldTypes; // 0x78
		internal object[] staticFields; // 0x80
		private int[] cctors; // 0x88
		private WrappersManager wrappersManager; // 0x90
		public static Action<string> Info; // 0x00
		private static Action<string> __f__mg_cache0; // 0x08
	
		// Properties
		public ExceptionHandler[][] ExceptionHandlers { get => default; set {} } // 0x000000018646EE40-0x000000018646EE50 0x00000001813ECF20-0x00000001813ECF30
		public System.Type[] ExternTypes { get => default; set {} } // 0x000000018571FEC0-0x000000018571FED0 0x00000001813FF010-0x00000001813FF020
		public MethodBase[] ExternMethods { get => default; set {} } // 0x000000018A9AB114-0x000000018A9AB184 0x0000000181460F60-0x0000000181460F70
		public string[] InternStrings { get => default; set {} } // 0x0000000184A4E570-0x0000000184A4E580 0x0000000186472DB0-0x0000000186472DC0
		public System.Reflection.FieldInfo[] FieldInfos { set {} } // 0x0000000185AE8FE0-0x0000000185AE8FF0
		public Dictionary<int, NewFieldInfo> NewFieldInfos { set {} } // 0x0000000185A62990-0x0000000185A629A0
		public AnonymousStoreyInfo[] AnonymousStoreyInfos { set {} } // 0x000000018A9AB184-0x000000018A9AB200
		public System.Type[] StaticFieldTypes { set {} } // 0x0000000186472AA8-0x0000000186472ABC
		public int[] Cctors { set {} } // 0x0000000181B5FFD0-0x0000000181B5FFE0
		public WrappersManager WrappersManager { get => default; set {} } // 0x00000001873CBEA8-0x00000001873CBEBC 0x000000018A9AA10C-0x000000018A9AA19C
	
		// Nested types
		private class CalliInvokerInfo // TypeDefIndex: 59623
		{
			// Fields
			public ExternInvoker Invoker; // 0x10
			public int ArgumentCount; // 0x18
	
			// Constructors
			public CalliInvokerInfo() {} // 0x000000018A9AA214-0x000000018A9AA340
		}
	
		// Constructors
		public VirtualMachine() {} // Dummy constructor
		internal unsafe VirtualMachine(Instruction** unmanaged_codes, Action on_dispose) {} // 0x00000001813B31A0-0x00000001813B31B0
		static VirtualMachine() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		~VirtualMachine() {} // 0x000000018A9AA9DC-0x000000018A9AAA60
		private unsafe void checkCctorExecute(int fieldId, Value* argumentBase, object[] managedStack, Value* evaluationStackBase) {} // 0x000000018A9AB42C-0x000000018A9AB5D8
		private unsafe void store(Value* stackBase, Value* dst, Value* src, object[] managedStack) {} // 0x000000018A9AAA60-0x000000018A9AABA0
		private unsafe void copy(Value* stackBase, Value* dst, Value* src, object[] managedStack) {} // 0x000000018A9AAFB8-0x000000018A9AB114
		private unsafe void resolveStackReference(Value* value, Value* stackBase, object[] managedStack) {} // 0x000000018A9AB200-0x000000018A9AB214
		private unsafe byte* stackReferenceToPointer(Value* value) => default; // 0x000000018A9AB65C-0x000000018A9AB684
		private unsafe bool tryConvertStackReferenceToPointer(Value* value) => default; // 0x000000018A9AAE38-0x000000018A9AAFB8
		private unsafe byte* pointerValueToAddress(Value* value, object[] managedStack) => default; // 0x000000018A9AB894-0x000000018A9AB990
		private unsafe long valueToInt64(Value* value) => default; // 0x000000018A9AB78C-0x000000018A9AB894
		private unsafe float valueToFloat(Value* value) => default; // 0x000000018A9AB684-0x000000018A9AB78C
		private unsafe double valueToDouble(Value* value) => default; // 0x000000018A9AB214-0x000000018A9AB42C
		private unsafe void storeToRawPointer(byte* destination, Value* src, Code code) {} // 0x000000018A9AAC58-0x000000018A9AAE38
		private unsafe void loadFromRawPointer(byte* source, Value* dest, Code code) {} // 0x000000018A9AA0A4-0x000000018A9AA10C
		public void Execute(int methodIndex, ref Call call, int argsCount, int refCount = 0 /* Metadata: 0x02080DB3 */) {} // 0x000000018A9AA05C-0x000000018A9AA0A4
		public unsafe Value* Execute(int methodIndex, Value* argumentBase, object[] managedStack, Value* evaluationStackBase, int argsCount) => default; // 0x000000018A9AB5D8-0x000000018A9AB65C
		private void throwRuntimeException(Exception e, bool bWrap) {} // 0x000000018A9AABA0-0x000000018A9AAC58
		private ExceptionHandler getExceptionHandler(int methodIndex, System.Type exceptionType, int pc) => default; // 0x000000018A9AA340-0x000000018A9AA6AC
		private unsafe void arrayGet(object obj, int idx, Value* val, object[] managedStack, Value* evaluationStackBase) {} // 0x000000018A9AA6AC-0x000000018A9AA9DC
		private unsafe void arraySet(object obj, int idx, Value* val, object[] managedStack, Value* evaluationStackBase) {} // 0x000000018A9AA19C-0x000000018A9AA214
		public static void _Info(string a) {} // 0x000000018A992714-0x000000018A99E6F0
		public unsafe Value* Execute(Instruction* pc, Value* argumentBase, object[] managedStack, Value* evaluationStackBase, int argsCount, int methodIndex, int refCount = 0 /* Metadata: 0x02080DB4 */, Value** topWriteBack = null) => default; // 0x0000000184B93420-0x0000000184B93500
	}

	public interface WrappersManager // TypeDefIndex: 59625
	{
		// Methods
		Delegate CreateDelegate(System.Type type, int id, object anon);
		AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine);
		object CreateWrapper(int id);
		object InitWrapperArray(int len);
	}
}

namespace Unity.IL2CPP.CompilerServices
{
	internal enum Option // TypeDefIndex: 59608
	{
		NullChecks = 1,
		ArrayBoundsChecks = 2,
		DivideByZeroChecks = 3
	}

	internal class Il2CppSetOptionAttribute : Attribute // TypeDefIndex: 59609
	{
		// Fields
		private Option _Option_k__BackingField; // 0x10
		private object _Value_k__BackingField; // 0x18
	
		// Properties
		private Option Option { get; set; } // 0x0000000181378230-0x0000000181378240
		private object Value { get; set; } // 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public Il2CppSetOptionAttribute() {} // Dummy constructor
		internal Il2CppSetOptionAttribute(Option option, object value) {} // 0x000000018646E950-0x000000018646E960
	}
}
