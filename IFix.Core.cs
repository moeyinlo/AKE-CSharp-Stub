/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Unity.IL2CPP.CompilerServices;

// Image 68: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58564-58600
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace IFix
{
	[AttributeUsage(AttributeTargets.Class)]
	public class CustomBridgeAttribute : Attribute // TypeDefIndex: 58591
	{
		// Constructors
		public CustomBridgeAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix.Core
{
	public class IDTagAttribute : Attribute // TypeDefIndex: 58565
	{
		// Fields
		public int ID; // 0x10
	
		// Constructors
		public IDTagAttribute() {} // Dummy constructor
		public IDTagAttribute(int id) {} // 0x00000001810410F0-0x0000000181041100
	}

	public static class PatchManager // TypeDefIndex: 58569
	{
		// Fields
		private static Dictionary<Assembly, Action> removers; // 0x00
	
		// Constructors
		static PatchManager() {} // 0x00000001888959F8-0x0000000188895A84
	
		// Methods
		private static MethodBase readMethod(BinaryReader reader, System.Type[] externTypes) => default; // 0x0000000188895D04-0x00000001888966D4
		private static int getMapId(List<System.Type> idMapArray, MethodBase method) => default; // 0x0000000188895A84-0x0000000188895D04
		private static int[] readSlotInfo(BinaryReader reader, Dictionary<MethodInfo, int> itfMethodToId, System.Type[] externTypes, int maxId) => default; // 0x00000001888966D4-0x00000001888969A4
		public static VirtualMachine Load(Stream stream, bool checkNew = true /* Metadata: 0x01FDB380 */) => default; // 0x00000001888910EC-0x000000018889585C
		public static void Unload(Assembly assembly) {} // 0x000000018889585C-0x00000001888959F8
	}

	public enum Code // TypeDefIndex: 58570
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

	public struct Instruction // TypeDefIndex: 58571
	{
		// Fields
		public Code Code; // 0x00
		public int Operand; // 0x04
	}

	public enum ExceptionHandlerType // TypeDefIndex: 58572
	{
		Catch = 0,
		Filter = 1,
		Finally = 2,
		Fault = 4
	}

	public sealed class ExceptionHandler // TypeDefIndex: 58573
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
		public ExceptionHandler() {} // 0x000000018350B670-0x000000018350B680
	}

	public class AnonymousStorey // TypeDefIndex: 58574
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
		public AnonymousStorey(int fieldNum, int[] fieldTypes, int typeID, int[] vTable, VirtualMachine virtualMachine) {} // 0x000000018888D0F4-0x000000018888D30C
	
		// Methods
		internal unsafe void Ldfld(int fieldIndex, Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack) {} // 0x000000018888CE20-0x000000018888CEFC
		internal unsafe void Stfld(int fieldIndex, Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack) {} // 0x000000018888CF70-0x000000018888D034
		internal object Get(int fieldIndex, System.Type type, VirtualMachine virtualMachine, bool valueTypeClone) => default; // 0x000000018888CDA4-0x000000018888CE20
		internal void Set(int fieldIndex, object obj, System.Type type, VirtualMachine virtualMachine) {} // 0x000000018888CEFC-0x000000018888CF70
		public bool ObjectEquals(object obj) => default; // 0x000000018232CE30-0x000000018232CE40
		public override bool Equals(object obj) => default; // 0x000000018888CB64-0x000000018888CC20
		public int ObjectGetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
		public override int GetHashCode() => default; // 0x000000018888CD08-0x000000018888CDA4
		public string ObjectToString() => default; // 0x0000000185459F38-0x0000000185459F40
		public override string ToString() => default; // 0x000000018888D034-0x000000018888D0F4
		~AnonymousStorey() {} // 0x000000018888CC20-0x000000018888CD08
	}

	public class AnonymousStoreyInfo // TypeDefIndex: 58575
	{
		// Fields
		public int FieldNum; // 0x10
		public int[] FieldTypes; // 0x18
		public int CtorId; // 0x20
		public int CtorParamNum; // 0x24
		public int[] Slots; // 0x28
		public int[] VTable; // 0x30
	
		// Constructors
		public AnonymousStoreyInfo() {} // 0x000000018350B670-0x000000018350B680
	}

	public enum ValueType // TypeDefIndex: 58576
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

	public struct Value // TypeDefIndex: 58577
	{
		// Fields
		public IFix.Core.ValueType Type; // 0x00
		public int Value1; // 0x04
		public int Value2; // 0x08
	}

	internal class GenericDelegateFactory // TypeDefIndex: 58581
	{
		// Fields
		private static MethodInfo[] genericAction; // 0x00
		private static MethodInfo[] genericFunc; // 0x08
		private static Dictionary<System.Type, Func<GenericDelegate, Delegate>> genericDelegateCreatorCache; // 0x10
	
		// Constructors
		public GenericDelegateFactory() {} // Dummy constructor
		static GenericDelegateFactory() {} // 0x0000000188890514-0x00000001888905F4
	
		// Methods
		private static void PreventStripping(object obj) {} // 0x0000000188890238-0x00000001888903F8
		internal static Delegate Create(System.Type delegateType, VirtualMachine virtualMachine, int methodId, object anonObj) => default; // 0x000000018888F6D8-0x0000000188890238
	}

	internal class GenericDelegate // TypeDefIndex: 58582
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		private bool pushSelf; // 0x28
		private int extraArgNum; // 0x2C
	
		// Constructors
		public GenericDelegate() {} // Dummy constructor
		internal GenericDelegate(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000188890688-0x00000001888906C8
	
		// Methods
		public void Action() {} // 0x00000001888905F4-0x0000000188890688
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

	public class ObjectClone // TypeDefIndex: 58585
	{
		// Fields
		private MethodInfo memberwiseClone; // 0x10
	
		// Constructors
		public ObjectClone() {} // 0x0000000188891054-0x00000001888910EC
	
		// Methods
		public object Clone(object obj) => default; // 0x0000000188891030-0x0000000188891054
	}

	internal class ReflectionMethodInvoker // TypeDefIndex: 58586
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
		public ReflectionMethodInvoker(MethodBase method) {} // 0x00000001888978D4-0x0000000188897D08
	
		// Methods
		public void Invoke(VirtualMachine virtualMachine, ref Call call, bool isInstantiate) {} // 0x00000001888969A4-0x00000001888978D4
	}

	internal struct UnmanagedStack // TypeDefIndex: 58587
	{
		// Fields
		public unsafe Value* Base; // 0x00
		public unsafe Value* Top; // 0x08
	}

	internal class ThreadStackInfo // TypeDefIndex: 58588
	{
		// Fields
		public unsafe UnmanagedStack* UnmanagedStack; // 0x10
		public object[] ManagedStack; // 0x18
		private IntPtr evaluationStackHandler; // 0x20
		private IntPtr unmanagedStackHandler; // 0x28
		private static LocalDataStoreSlot localSlot; // 0x00
	
		// Properties
		internal static ThreadStackInfo Stack { get => default; } // 0x0000000188897E3C-0x0000000188897F20 
	
		// Constructors
		public ThreadStackInfo() {} // 0x0000000188897DA4-0x0000000188897E3C
		static ThreadStackInfo() {} // 0x0000000188897D54-0x0000000188897DA4
	}

	internal static class EvaluationStackOperation // TypeDefIndex: 58589
	{
		// Methods
		internal static unsafe void UnboxPrimitive(Value* evaluationStackPointer, object obj, System.Type type) {} // 0x000000018888EA18-0x000000018888EEEC
		internal static object mGet(bool isArray, object root, int layer, int[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, Dictionary<int, NewFieldInfo> newFieldInfos) => default; // 0x000000018888F294-0x000000018888F4B0
		internal static void mSet(bool isArray, object root, object val, int layer, int[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, Dictionary<int, NewFieldInfo> newFieldInfos) {} // 0x000000018888F4B0-0x000000018888F6D8
		internal static unsafe object ToObject(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, System.Type type, VirtualMachine virtualMachine, bool valueTypeClone = true /* Metadata: 0x01FDB4BF */) => default; // 0x000000018888DE20-0x000000018888EA18
		public static unsafe void PushObject(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, object obj, System.Type type) {} // 0x000000018888DAB8-0x000000018888DE20
		public static unsafe void UpdateReference(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, object obj, VirtualMachine virtualMachine, System.Type type) {} // 0x000000018888EEEC-0x000000018888F294
	}

	public struct Call // TypeDefIndex: 58590
	{
		// Fields
		internal unsafe Value* argumentBase; // 0x00
		internal unsafe Value* evaluationStackBase; // 0x08
		internal object[] managedStack; // 0x10
		internal unsafe Value* currentTop; // 0x18
		internal unsafe Value** topWriteBack; // 0x20
	
		// Methods
		public static Call Begin() => default; // 0x000000018888D38C-0x000000018888D450
		internal static Call BeginForStack(ThreadStackInfo stack) => default; // 0x000000018888D30C-0x000000018888D38C
		public void PushBoolean(bool b) {} // 0x000000018888D5EC-0x000000018888D61C
		public bool GetBoolean(int offset = 0 /* Metadata: 0x01FDB4C0 */) => default; // 0x000000018888D450-0x000000018888D484
		public void PushByte(byte b) {} // 0x000000018888D61C-0x000000018888D628
		public byte GetByte(int offset = 0 /* Metadata: 0x01FDB4C1 */) => default; // 0x000000018888D484-0x000000018888D48C
		public sbyte GetSByte(int offset = 0 /* Metadata: 0x01FDB4C2 */) => default; // 0x000000018888D484-0x000000018888D48C
		public void PushInt16(short s) {} // 0x000000018888D65C-0x000000018888D668
		public short GetInt16(int offset = 0 /* Metadata: 0x01FDB4C3 */) => default; // 0x000000018888D484-0x000000018888D48C
		public void PushChar(char c) {} // 0x000000018888D628-0x000000018888D634
		public char GetChar(int offset = 0 /* Metadata: 0x01FDB4C4 */) => default; // 0x000000018888D484-0x000000018888D48C
		public void PushUInt16(ushort us) {} // 0x000000018888D628-0x000000018888D634
		public ushort GetUInt16(int offset = 0 /* Metadata: 0x01FDB4C5 */) => default; // 0x000000018888D484-0x000000018888D48C
		public void PushInt32(int i) {} // 0x000000018888D668-0x000000018888D698
		public int GetInt32(int offset = 0 /* Metadata: 0x01FDB4C6 */) => default; // 0x000000018888D4BC-0x000000018888D4EC
		public void PushUInt32(uint ui) {} // 0x000000018888D814-0x000000018888D81C
		public uint GetUInt32(int offset = 0 /* Metadata: 0x01FDB4C7 */) => default; // 0x000000018888D484-0x000000018888D48C
		public void PushInt64(long i) {} // 0x000000018888D698-0x000000018888D6C8
		public long GetInt64(int offset = 0 /* Metadata: 0x01FDB4C8 */) => default; // 0x000000018888D4EC-0x000000018888D51C
		public void PushUInt64(ulong i) {} // 0x000000018888D81C-0x000000018888D824
		public ulong GetUInt64(int offset = 0 /* Metadata: 0x01FDB4C9 */) => default; // 0x000000018888D51C-0x000000018888D524
		public void PushSingle(float f) {} // 0x000000018888D7EC-0x000000018888D814
		public float GetSingle(int offset = 0 /* Metadata: 0x01FDB4CA */) => default; // 0x000000018888D5BC-0x000000018888D5EC
		public void PushDouble(double d) {} // 0x000000018888D634-0x000000018888D65C
		public double GetDouble(int offset = 0 /* Metadata: 0x01FDB4CB */) => default; // 0x000000018888D48C-0x000000018888D4BC
		public void PushIntPtr(IntPtr i) {} // 0x000000018888D6C8-0x000000018888D6D4
		public IntPtr GetIntPtr(int offset = 0 /* Metadata: 0x01FDB4CC */) => default; // 0x000000018888D51C-0x000000018888D524
		public void PushObject(object o) {} // 0x000000018888D710-0x000000018888D7AC
		public void PushValueType(object o) {} // 0x000000018888D824-0x000000018888D8C0
		public object GetObject(int offset = 0 /* Metadata: 0x01FDB4CD */) => default; // 0x000000018888D524-0x000000018888D5BC
		public T GetAsType<T>(int offset = 0 /* Metadata: 0x01FDB4CE */) => default;
		public void PushObjectAsResult(object obj, System.Type type) {} // 0x000000018888D6D4-0x000000018888D710
		public void PushRef(int offset) {} // 0x000000018888D7AC-0x000000018888D7EC
		public void UpdateReference(int offset, object obj, VirtualMachine virtualMachine, System.Type type) {} // 0x000000018888D8C0-0x000000018888D970
	}

	public static class Utils // TypeDefIndex: 58592
	{
		// Fields
		private static Dictionary<System.Type, MethodInfo> delegateAdptCache; // 0x00
	
		// Constructors
		static Utils() {} // 0x0000000188898444-0x00000001888984D0
	
		// Methods
		public static bool IsAssignable(MethodInfo delegateMethod, MethodInfo method) => default; // 0x0000000188898074-0x00000001888981E0
		public static Delegate TryAdapterToDelegate(object obj, System.Type delegateType, string perfix) => default; // 0x00000001888981E0-0x0000000188898444
	}

	internal class RuntimeException : Exception // TypeDefIndex: 58593
	{
		// Properties
		public Exception Real { get; set; } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
	
		// Constructors
		public RuntimeException() {} // 0x0000000188897D08-0x0000000188897D54
	}

	public delegate void ExternInvoker(VirtualMachine vm, ref Call call, bool isInstantiate); // TypeDefIndex: 58594; 0x00000001811360D0-0x00000001811360F0

	internal class FieldAddr // TypeDefIndex: 58595
	{
		// Fields
		public object Object; // 0x10
		public int[] FieldIdList; // 0x18
	
		// Constructors
		public FieldAddr() {} // 0x000000018350B670-0x000000018350B680
	}

	public class Cleanner // TypeDefIndex: 58596
	{
		// Fields
		private static bool start; // 0x00
	
		// Constructors
		public Cleanner() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void Start() {} // 0x000000018888DA2C-0x000000018888DA80
		public static void Stop() {} // 0x000000018888DA80-0x000000018888DAB8
		~Cleanner() {} // 0x000000018888D970-0x000000018888DA2C
	}

	public class NewFieldInfo // TypeDefIndex: 58597
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
		public NewFieldInfo() {} // 0x000000018350B670-0x000000018350B680
		static NewFieldInfo() {} // 0x0000000188890ECC-0x0000000188891030
	
		// Methods
		private object SetDefaultValue(object obj) => default; // 0x0000000188890A2C-0x0000000188890AA4
		public static void Sweep() {} // 0x0000000188890CC0-0x0000000188890ECC
		public void CheckInit(VirtualMachine virtualMachine, object obj) {} // 0x00000001888906C8-0x00000001888907D8
		public int ObjectToIndex(object obj) => default; // 0x00000001888909CC-0x0000000188890A2C
		public bool HasInitialize(object obj) => default; // 0x00000001888908C4-0x00000001888909CC
		public object GetValue(object obj) => default; // 0x00000001888907D8-0x00000001888908C4
		public void SetValue(object obj, object value) {} // 0x0000000188890AA4-0x0000000188890CC0
	}

	public class VirtualMachine // TypeDefIndex: 58599
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
	
		// Properties
		public ExceptionHandler[][] ExceptionHandlers { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public System.Type[] ExternTypes { get => default; set {} } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public MethodBase[] ExternMethods { get => default; set {} } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000188899588-0x00000001888995F8
		public string[] InternStrings { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public System.Reflection.FieldInfo[] FieldInfos { set {} } // 0x0000000183081D30-0x0000000183081D40
		public Dictionary<int, NewFieldInfo> NewFieldInfos { set {} } // 0x00000001839274B0-0x00000001839274C0
		public AnonymousStoreyInfo[] AnonymousStoreyInfos { set {} } // 0x00000001838C5570-0x00000001838C5580
		public System.Type[] StaticFieldTypes { set {} } // 0x00000001888995F8-0x0000000188899674
		public int[] Cctors { set {} } // 0x0000000184274DA0-0x0000000184274DB4
		public WrappersManager WrappersManager { get => default; set {} } // 0x0000000183D4EA90-0x0000000183D4EAA0 0x00000001851DFCB4-0x00000001851DFCC8
	
		// Nested types
		private class CalliInvokerInfo // TypeDefIndex: 58598
		{
			// Fields
			public ExternInvoker Invoker; // 0x10
			public int ArgumentCount; // 0x18
	
			// Constructors
			public CalliInvokerInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public VirtualMachine() {} // Dummy constructor
		internal unsafe VirtualMachine(Instruction** unmanaged_codes, Action on_dispose) {} // 0x0000000188898688-0x00000001888987B4
		static VirtualMachine() {} // 0x0000000182E98FA0-0x0000000182E99080
	
		// Methods
		~VirtualMachine() {} // 0x0000000188898580-0x0000000188898610
		private unsafe void checkCctorExecute(int fieldId, Value* argumentBase, object[] managedStack, Value* evaluationStackBase) {} // 0x0000000188898E50-0x0000000188898ED4
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void store(Value* stackBase, Value* dst, Value* src, object[] managedStack) {} // 0x00000001888998A0-0x0000000188899A4C
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void copy(Value* stackBase, Value* dst, Value* src, object[] managedStack) {} // 0x0000000188898ED4-0x0000000188899014
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void resolveStackReference(Value* value, Value* stackBase, object[] managedStack) {} // 0x000000018889942C-0x0000000188899588
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe byte* stackReferenceToPointer(Value* value) => default; // 0x0000000188899674-0x0000000188899688
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		private unsafe bool tryConvertStackReferenceToPointer(Value* value) => default; // 0x0000000188899AD0-0x0000000188899AF8
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe byte* pointerValueToAddress(Value* value, object[] managedStack) => default; // 0x00000001888992AC-0x000000018889942C
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe long valueToInt64(Value* value) => default; // 0x0000000188899D08-0x0000000188899E04
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe float valueToFloat(Value* value) => default; // 0x0000000188899C00-0x0000000188899D08
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe double valueToDouble(Value* value) => default; // 0x0000000188899AF8-0x0000000188899C00
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void storeToRawPointer(byte* destination, Value* src, Code code) {} // 0x0000000188899688-0x00000001888998A0
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		private unsafe void loadFromRawPointer(byte* source, Value* dest, Code code) {} // 0x00000001888990CC-0x00000001888992AC
		public void Execute(int methodIndex, ref Call call, int argsCount, int refCount = 0 /* Metadata: 0x01FDB4CF */) {} // 0x0000000188898518-0x0000000188898580
		public unsafe Value* Execute(int methodIndex, Value* argumentBase, object[] managedStack, Value* evaluationStackBase, int argsCount) => default; // 0x00000001888984D0-0x0000000188898518
		private void throwRuntimeException(Exception e, bool bWrap) {} // 0x0000000188899A4C-0x0000000188899AD0
		private ExceptionHandler getExceptionHandler(int methodIndex, System.Type exceptionType, int pc) => default; // 0x0000000188899014-0x00000001888990CC
		private unsafe void arrayGet(object obj, int idx, Value* val, object[] managedStack, Value* evaluationStackBase) {} // 0x00000001888987B4-0x0000000188898B20
		private unsafe void arraySet(object obj, int idx, Value* val, object[] managedStack, Value* evaluationStackBase) {} // 0x0000000188898B20-0x0000000188898E50
		public static void _Info(string a) {} // 0x0000000188898610-0x0000000188898688
		public unsafe Value* Execute(Instruction* pc, Value* argumentBase, object[] managedStack, Value* evaluationStackBase, int argsCount, int methodIndex, int refCount = 0 /* Metadata: 0x01FDB4D0 */, Value** topWriteBack = null) => default; // 0x0000000188880B88-0x000000018888CB64
	}

	public interface WrappersManager // TypeDefIndex: 58600
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
	internal enum Option // TypeDefIndex: 58583
	{
		NullChecks = 1,
		ArrayBoundsChecks = 2,
		DivideByZeroChecks = 3
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	internal class Il2CppSetOptionAttribute : Attribute // TypeDefIndex: 58584
	{
		// Properties
		private Unity.IL2CPP.CompilerServices.Option Option { get; set; } // 0x00000001810410F0-0x0000000181041100
		private object Value { get; set; } // 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public Il2CppSetOptionAttribute() {} // Dummy constructor
		internal Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option option, object value) {} // 0x0000000184270E40-0x0000000184270E50
	}
}
