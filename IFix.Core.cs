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

// Image 71: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62233-62269
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace IFix
{
	[AttributeUsage(AttributeTargets.Class)]
	public class CustomBridgeAttribute : Attribute // TypeDefIndex: 62260
	{
		// Constructors
		public CustomBridgeAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix.Core
{
	public class IDTagAttribute : Attribute // TypeDefIndex: 62234
	{
		// Fields
		public int ID; // 0x10
	
		// Constructors
		public IDTagAttribute(int id); // 0x00000001814F51F0-0x00000001814F5220
	}

	public static class PatchManager // TypeDefIndex: 62238
	{
		// Fields
		private static Dictionary<Assembly, Action> removers; // 0x00
		[CompilerGenerated]
		private static Func<ParameterInfo, System.Type> __f__am_cache0; // 0x08
	
		// Nested types
		[CompilerGenerated]
		private sealed class _readMethod_c__AnonStorey0 // TypeDefIndex: 62235
		{
			// Fields
			internal System.Type[] genericArgInfos; // 0x10
	
			// Constructors
			public _readMethod_c__AnonStorey0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string __m__0(System.Text.RegularExpressions.Match m); // 0x0000000189E11FB4-0x0000000189E12020
		}
	
		[CompilerGenerated]
		private sealed class _Load_c__AnonStorey1 // TypeDefIndex: 62236
		{
			// Fields
			internal List<IntPtr> nativePointers; // 0x10
	
			// Constructors
			public _Load_c__AnonStorey1(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class _Load_c__AnonStorey2 // TypeDefIndex: 62237
		{
			// Fields
			internal WrappersManager wrapperManager; // 0x10
			internal _Load_c__AnonStorey1 __f__ref_1; // 0x18
	
			// Constructors
			public _Load_c__AnonStorey2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __m__0(); // 0x0000000189E11EF4-0x0000000189E11F94
			internal void __m__1(); // 0x0000000189E11F94-0x0000000189E11FB4
		}
	
		// Constructors
		static PatchManager(); // 0x0000000189E0FA04-0x0000000189E0FA90
	
		// Methods
		private static MethodBase readMethod(BinaryReader reader, System.Type[] externTypes); // 0x0000000189E0FD0C-0x0000000189E106C8
		private static int getMapId(List<System.Type> idMapArray, MethodBase method); // 0x0000000189E0FA90-0x0000000189E0FD0C
		private static int[] readSlotInfo(BinaryReader reader, Dictionary<MethodInfo, int> itfMethodToId, System.Type[] externTypes, int maxId); // 0x0000000189E106C8-0x0000000189E1098C
		public static VirtualMachine Load(Stream stream, bool checkNew = true /* Metadata: 0x02350A04 */); // 0x0000000189E0B1AC-0x0000000189E0F870
		public static void Unload(Assembly assembly); // 0x0000000189E0F870-0x0000000189E0FA04
		[CompilerGenerated]
		private static System.Type _readMethod_m__0(ParameterInfo p); // 0x00000001853E4DA0-0x00000001853E4DB8
	}

	public enum Code // TypeDefIndex: 62239
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

	public struct Instruction // TypeDefIndex: 62240
	{
		// Fields
		public Code Code; // 0x00
		public int Operand; // 0x04
	}

	public enum ExceptionHandlerType // TypeDefIndex: 62241
	{
		Catch = 0,
		Filter = 1,
		Finally = 2,
		Fault = 4
	}

	public sealed class ExceptionHandler // TypeDefIndex: 62242
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
		public ExceptionHandler(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class AnonymousStorey // TypeDefIndex: 62243
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
		public AnonymousStorey(int fieldNum, int[] fieldTypes, int typeID, int[] vTable, VirtualMachine virtualMachine); // 0x0000000189E071B0-0x0000000189E073C8
	
		// Methods
		internal unsafe void Ldfld(int fieldIndex, Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack); // 0x0000000189E06EDC-0x0000000189E06FB8
		internal unsafe void Stfld(int fieldIndex, Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack); // 0x0000000189E0702C-0x0000000189E070F0
		internal object Get(int fieldIndex, System.Type type, VirtualMachine virtualMachine, bool valueTypeClone); // 0x0000000189E06E60-0x0000000189E06EDC
		internal void Set(int fieldIndex, object obj, System.Type type, VirtualMachine virtualMachine); // 0x0000000189E06FB8-0x0000000189E0702C
		public bool ObjectEquals(object obj); // 0x0000000182FB1840-0x0000000182FB1850
		public override bool Equals(object obj); // 0x0000000189E06C20-0x0000000189E06CDC
		public int ObjectGetHashCode(); // 0x0000000184D87100-0x0000000184D87110
		public override int GetHashCode(); // 0x0000000189E06DC4-0x0000000189E06E60
		public string ObjectToString(); // 0x000000018669AD6C-0x000000018669AD74
		public override string ToString(); // 0x0000000189E070F0-0x0000000189E071B0
		~AnonymousStorey(); // 0x0000000189E06CDC-0x0000000189E06DC4
	}

	public class AnonymousStoreyInfo // TypeDefIndex: 62244
	{
		// Fields
		public int FieldNum; // 0x10
		public int[] FieldTypes; // 0x18
		public int CtorId; // 0x20
		public int CtorParamNum; // 0x24
		public int[] Slots; // 0x28
		public int[] VTable; // 0x30
	
		// Constructors
		public AnonymousStoreyInfo(); // 0x00000001841E1670-0x00000001841E1680
	}

	public enum ValueType // TypeDefIndex: 62245
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

	public struct Value // TypeDefIndex: 62246
	{
		// Fields
		public IFix.Core.ValueType Type; // 0x00
		public int Value1; // 0x04
		public int Value2; // 0x08
	}

	internal class GenericDelegateFactory // TypeDefIndex: 62250
	{
		// Fields
		private static MethodInfo[] genericAction; // 0x00
		private static MethodInfo[] genericFunc; // 0x08
		private static Dictionary<System.Type, Func<GenericDelegate, Delegate>> genericDelegateCreatorCache; // 0x10
		[CompilerGenerated]
		private static Func<MethodInfo, bool> __f__am_cache0; // 0x18
		[CompilerGenerated]
		private static Func<MethodInfo, int> __f__am_cache1; // 0x20
		[CompilerGenerated]
		private static Func<MethodInfo, bool> __f__am_cache2; // 0x28
		[CompilerGenerated]
		private static Func<MethodInfo, int> __f__am_cache3; // 0x30
		[CompilerGenerated]
		private static Func<ParameterInfo, bool> __f__am_cache4; // 0x38
		[CompilerGenerated]
		private static Func<GenericDelegate, Delegate> __f__am_cache5; // 0x40
		[CompilerGenerated]
		private static Func<ParameterInfo, System.Type> __f__am_cache6; // 0x48
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Create_c__AnonStorey0 // TypeDefIndex: 62247
		{
			// Fields
			internal System.Type delegateType; // 0x10
	
			// Constructors
			public _Create_c__AnonStorey0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class _Create_c__AnonStorey1 // TypeDefIndex: 62248
		{
			// Fields
			internal MethodInfo methodInfo; // 0x10
			internal _Create_c__AnonStorey0 __f__ref_0; // 0x18
	
			// Constructors
			public _Create_c__AnonStorey1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Delegate __m__0(GenericDelegate o); // 0x0000000189E11ECC-0x0000000189E11EF4
		}
	
		[CompilerGenerated]
		private sealed class _Create_c__AnonStorey2 // TypeDefIndex: 62249
		{
			// Fields
			internal MethodInfo methodInfo; // 0x10
			internal _Create_c__AnonStorey0 __f__ref_0; // 0x18
	
			// Constructors
			public _Create_c__AnonStorey2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Delegate __m__0(GenericDelegate o); // 0x0000000189E11ECC-0x0000000189E11EF4
		}
	
		// Constructors
		static GenericDelegateFactory(); // 0x0000000189E0A5D4-0x0000000189E0A6B4
	
		// Methods
		private static void PreventStripping(object obj); // 0x0000000189E0A2F8-0x0000000189E0A4B8
		internal static Delegate Create(System.Type delegateType, VirtualMachine virtualMachine, int methodId, object anonObj); // 0x0000000189E09798-0x0000000189E0A2F8
		[CompilerGenerated]
		private static bool _Create_m__0(MethodInfo m); // 0x0000000189E0A4B8-0x0000000189E0A50C
		[CompilerGenerated]
		private static int _Create_m__1(MethodInfo m); // 0x0000000189E0A50C-0x0000000189E0A538
		[CompilerGenerated]
		private static bool _Create_m__2(MethodInfo m); // 0x0000000189E0A538-0x0000000189E0A58C
		[CompilerGenerated]
		private static int _Create_m__3(MethodInfo m); // 0x0000000189E0A50C-0x0000000189E0A538
		[CompilerGenerated]
		private static bool _Create_m__4(ParameterInfo p); // 0x0000000189E0A58C-0x0000000189E0A5D4
		[CompilerGenerated]
		private static Delegate _Create_m__5(GenericDelegate x); // 0x00000001811EC580-0x00000001811EC590
		[CompilerGenerated]
		private static System.Type _Create_m__6(ParameterInfo pinfo); // 0x00000001853E4DA0-0x00000001853E4DB8
	}

	internal class GenericDelegate // TypeDefIndex: 62251
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		private bool pushSelf; // 0x28
		private int extraArgNum; // 0x2C
	
		// Constructors
		internal GenericDelegate(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x0000000189E0A748-0x0000000189E0A788
	
		// Methods
		public void Action(); // 0x0000000189E0A6B4-0x0000000189E0A748
		public void Action<T1>(T1 p1)
			where T1 : class;
		public void Action<T1, T2>(T1 p1, T2 p2)
			where T1 : class
			where T2 : class;
		public void Action<T1, T2, T3>(T1 p1, T2 p2, T3 p3)
			where T1 : class
			where T2 : class
			where T3 : class;
		public void Action<T1, T2, T3, T4>(T1 p1, T2 p2, T3 p3, T4 p4)
			where T1 : class
			where T2 : class
			where T3 : class
			where T4 : class;
		public TResult Func<TResult>()
			where TResult : class;
		public TResult Func<T1, TResult>(T1 p1)
			where T1 : class
			where TResult : class;
		public TResult Func<T1, T2, TResult>(T1 p1, T2 p2)
			where T1 : class
			where T2 : class
			where TResult : class;
		public TResult Func<T1, T2, T3, TResult>(T1 p1, T2 p2, T3 p3)
			where T1 : class
			where T2 : class
			where T3 : class
			where TResult : class;
		public TResult Func<T1, T2, T3, T4, TResult>(T1 p1, T2 p2, T3 p3, T4 p4)
			where T1 : class
			where T2 : class
			where T3 : class
			where T4 : class
			where TResult : class;
	}

	public class ObjectClone // TypeDefIndex: 62254
	{
		// Fields
		private MethodInfo memberwiseClone; // 0x10
	
		// Constructors
		public ObjectClone(); // 0x0000000189E0B114-0x0000000189E0B1AC
	
		// Methods
		public object Clone(object obj); // 0x0000000189E0B0F0-0x0000000189E0B114
	}

	internal class ReflectionMethodInvoker // TypeDefIndex: 62255
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
		public ReflectionMethodInvoker(MethodBase method); // 0x0000000189E11880-0x0000000189E11CB4
	
		// Methods
		public void Invoke(VirtualMachine virtualMachine, ref Call call, bool isInstantiate); // 0x0000000189E1098C-0x0000000189E11880
	}

	internal struct UnmanagedStack // TypeDefIndex: 62256
	{
		// Fields
		public unsafe Value* Base; // 0x00
		public unsafe Value* Top; // 0x08
	}

	internal class ThreadStackInfo // TypeDefIndex: 62257
	{
		// Fields
		public unsafe UnmanagedStack* UnmanagedStack; // 0x10
		public object[] ManagedStack; // 0x18
		private IntPtr evaluationStackHandler; // 0x20
		private IntPtr unmanagedStackHandler; // 0x28
		private static LocalDataStoreSlot localSlot; // 0x00
	
		// Properties
		internal static ThreadStackInfo Stack { get; } // 0x0000000189E11DE8-0x0000000189E11ECC 
	
		// Constructors
		public ThreadStackInfo(); // 0x0000000189E11D50-0x0000000189E11DE8
		static ThreadStackInfo(); // 0x0000000189E11D00-0x0000000189E11D50
	}

	internal static class EvaluationStackOperation // TypeDefIndex: 62258
	{
		// Methods
		internal static unsafe void UnboxPrimitive(Value* evaluationStackPointer, object obj, System.Type type); // 0x0000000189E08AD8-0x0000000189E08FAC
		internal static object mGet(bool isArray, object root, int layer, int[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, Dictionary<int, NewFieldInfo> newFieldInfos); // 0x0000000189E09354-0x0000000189E09570
		internal static void mSet(bool isArray, object root, object val, int layer, int[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, Dictionary<int, NewFieldInfo> newFieldInfos); // 0x0000000189E09570-0x0000000189E09798
		internal static unsafe object ToObject(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, System.Type type, VirtualMachine virtualMachine, bool valueTypeClone = true /* Metadata: 0x02350B43 */); // 0x0000000189E07EDC-0x0000000189E08AD8
		public static unsafe void PushObject(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, object obj, System.Type type); // 0x0000000189E07B74-0x0000000189E07EDC
		public static unsafe void UpdateReference(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, object obj, VirtualMachine virtualMachine, System.Type type); // 0x0000000189E08FAC-0x0000000189E09354
	}

	public struct Call // TypeDefIndex: 62259
	{
		// Fields
		internal unsafe Value* argumentBase; // 0x00
		internal unsafe Value* evaluationStackBase; // 0x08
		internal object[] managedStack; // 0x10
		internal unsafe Value* currentTop; // 0x18
		internal unsafe Value** topWriteBack; // 0x20
	
		// Methods
		public static Call Begin(); // 0x0000000189E07448-0x0000000189E0750C
		internal static Call BeginForStack(ThreadStackInfo stack); // 0x0000000189E073C8-0x0000000189E07448
		public void PushBoolean(bool b); // 0x0000000189E076A8-0x0000000189E076D8
		public bool GetBoolean(int offset = 0 /* Metadata: 0x02350B44 */); // 0x0000000189E0750C-0x0000000189E07540
		public void PushByte(byte b); // 0x0000000189E076D8-0x0000000189E076E4
		public byte GetByte(int offset = 0 /* Metadata: 0x02350B45 */); // 0x0000000189E07540-0x0000000189E07548
		public sbyte GetSByte(int offset = 0 /* Metadata: 0x02350B46 */); // 0x0000000189E07540-0x0000000189E07548
		public void PushInt16(short s); // 0x0000000189E07718-0x0000000189E07724
		public short GetInt16(int offset = 0 /* Metadata: 0x02350B47 */); // 0x0000000189E07540-0x0000000189E07548
		public void PushChar(char c); // 0x0000000189E076E4-0x0000000189E076F0
		public char GetChar(int offset = 0 /* Metadata: 0x02350B48 */); // 0x0000000189E07540-0x0000000189E07548
		public void PushUInt16(ushort us); // 0x0000000189E076E4-0x0000000189E076F0
		public ushort GetUInt16(int offset = 0 /* Metadata: 0x02350B49 */); // 0x0000000189E07540-0x0000000189E07548
		public void PushInt32(int i); // 0x0000000189E07724-0x0000000189E07754
		public int GetInt32(int offset = 0 /* Metadata: 0x02350B4A */); // 0x0000000189E07578-0x0000000189E075A8
		public void PushUInt32(uint ui); // 0x0000000189E078D0-0x0000000189E078D8
		public uint GetUInt32(int offset = 0 /* Metadata: 0x02350B4B */); // 0x0000000189E07540-0x0000000189E07548
		public void PushInt64(long i); // 0x0000000189E07754-0x0000000189E07784
		public long GetInt64(int offset = 0 /* Metadata: 0x02350B4C */); // 0x0000000189E075A8-0x0000000189E075D8
		public void PushUInt64(ulong i); // 0x0000000189E078D8-0x0000000189E078E0
		public ulong GetUInt64(int offset = 0 /* Metadata: 0x02350B4D */); // 0x0000000189E075D8-0x0000000189E075E0
		public void PushSingle(float f); // 0x0000000189E078A8-0x0000000189E078D0
		public float GetSingle(int offset = 0 /* Metadata: 0x02350B4E */); // 0x0000000189E07678-0x0000000189E076A8
		public void PushDouble(double d); // 0x0000000189E076F0-0x0000000189E07718
		public double GetDouble(int offset = 0 /* Metadata: 0x02350B4F */); // 0x0000000189E07548-0x0000000189E07578
		public void PushIntPtr(IntPtr i); // 0x0000000189E07784-0x0000000189E07790
		public IntPtr GetIntPtr(int offset = 0 /* Metadata: 0x02350B50 */); // 0x0000000189E075D8-0x0000000189E075E0
		public void PushObject(object o); // 0x0000000189E077CC-0x0000000189E07868
		public void PushValueType(object o); // 0x0000000189E078E0-0x0000000189E0797C
		public object GetObject(int offset = 0 /* Metadata: 0x02350B51 */); // 0x0000000189E075E0-0x0000000189E07678
		public T GetAsType<T>(int offset = 0 /* Metadata: 0x02350B52 */);
		public void PushObjectAsResult(object obj, System.Type type); // 0x0000000189E07790-0x0000000189E077CC
		public void PushRef(int offset); // 0x0000000189E07868-0x0000000189E078A8
		public void UpdateReference(int offset, object obj, VirtualMachine virtualMachine, System.Type type); // 0x0000000189E0797C-0x0000000189E07A2C
	}

	public static class Utils // TypeDefIndex: 62261
	{
		// Fields
		private static Dictionary<System.Type, MethodInfo> delegateAdptCache; // 0x00
	
		// Constructors
		static Utils(); // 0x0000000189E123F0-0x0000000189E1247C
	
		// Methods
		public static bool IsAssignable(MethodInfo delegateMethod, MethodInfo method); // 0x0000000189E12020-0x0000000189E1218C
		public static Delegate TryAdapterToDelegate(object obj, System.Type delegateType, string perfix); // 0x0000000189E1218C-0x0000000189E123F0
	}

	internal class RuntimeException : Exception // TypeDefIndex: 62262
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Exception _Real_k__BackingField; // 0x90
	
		// Properties
		public Exception Real { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000186402330-0x0000000186402344
	
		// Constructors
		public RuntimeException(); // 0x0000000189E11CB4-0x0000000189E11D00
	}

	public delegate void ExternInvoker(VirtualMachine vm, ref Call call, bool isInstantiate); // TypeDefIndex: 62263; 0x0000000181546280-0x00000001815462A0

	internal class FieldAddr // TypeDefIndex: 62264
	{
		// Fields
		public object Object; // 0x10
		public int[] FieldIdList; // 0x18
	
		// Constructors
		public FieldAddr(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class Cleanner // TypeDefIndex: 62265
	{
		// Fields
		private static bool start; // 0x00
	
		// Constructors
		public Cleanner(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void Start(); // 0x0000000189E07AE8-0x0000000189E07B3C
		public static void Stop(); // 0x0000000189E07B3C-0x0000000189E07B74
		~Cleanner(); // 0x0000000189E07A2C-0x0000000189E07AE8
	}

	public class NewFieldInfo // TypeDefIndex: 62266
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
		public NewFieldInfo(); // 0x00000001841E1670-0x00000001841E1680
		static NewFieldInfo(); // 0x0000000189E0AF8C-0x0000000189E0B0F0
	
		// Methods
		private object SetDefaultValue(object obj); // 0x0000000189E0AAEC-0x0000000189E0AB64
		public static void Sweep(); // 0x0000000189E0AD80-0x0000000189E0AF8C
		public void CheckInit(VirtualMachine virtualMachine, object obj); // 0x0000000189E0A788-0x0000000189E0A898
		public int ObjectToIndex(object obj); // 0x0000000189E0AA8C-0x0000000189E0AAEC
		public bool HasInitialize(object obj); // 0x0000000189E0A984-0x0000000189E0AA8C
		public object GetValue(object obj); // 0x0000000189E0A898-0x0000000189E0A984
		public void SetValue(object obj, object value); // 0x0000000189E0AB64-0x0000000189E0AD80
	}

	public class VirtualMachine // TypeDefIndex: 62268
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
		[CompilerGenerated]
		private static Action<string> __f__mg_cache0; // 0x08
	
		// Properties
		public ExceptionHandler[][] ExceptionHandlers { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public System.Type[] ExternTypes { get; set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public MethodBase[] ExternMethods { get; set; } // 0x0000000184D85A60-0x0000000184D85A70 0x0000000189E13534-0x0000000189E135A4
		public string[] InternStrings { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public System.Reflection.FieldInfo[] FieldInfos { set; } // 0x00000001836E5590-0x00000001836E55A0
		public Dictionary<int, NewFieldInfo> NewFieldInfos { set; } // 0x00000001863CC164-0x00000001863CC174
		public AnonymousStoreyInfo[] AnonymousStoreyInfos { set; } // 0x000000018485F170-0x000000018485F180
		public System.Type[] StaticFieldTypes { set; } // 0x0000000189E135A4-0x0000000189E13620
		public int[] Cctors { set; } // 0x0000000185395D30-0x0000000185395D44
		public WrappersManager WrappersManager { get; set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000186402330-0x0000000186402344
	
		// Nested types
		private class CalliInvokerInfo // TypeDefIndex: 62267
		{
			// Fields
			public ExternInvoker Invoker; // 0x10
			public int ArgumentCount; // 0x18
	
			// Constructors
			public CalliInvokerInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		internal unsafe VirtualMachine(Instruction** unmanaged_codes, Action on_dispose); // 0x0000000189E12634-0x0000000189E12760
		static VirtualMachine(); // 0x0000000183AF9D30-0x0000000183AF9E10
	
		// Methods
		~VirtualMachine(); // 0x0000000189E1252C-0x0000000189E125BC
		private unsafe void checkCctorExecute(int fieldId, Value* argumentBase, object[] managedStack, Value* evaluationStackBase); // 0x0000000189E12DFC-0x0000000189E12E80
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void store(Value* stackBase, Value* dst, Value* src, object[] managedStack); // 0x0000000189E1384C-0x0000000189E139F8
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void copy(Value* stackBase, Value* dst, Value* src, object[] managedStack); // 0x0000000189E12E80-0x0000000189E12FC0
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void resolveStackReference(Value* value, Value* stackBase, object[] managedStack); // 0x0000000189E133D8-0x0000000189E13534
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe byte* stackReferenceToPointer(Value* value); // 0x0000000189E13620-0x0000000189E13634
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		private unsafe bool tryConvertStackReferenceToPointer(Value* value); // 0x0000000189E13A7C-0x0000000189E13AA4
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe byte* pointerValueToAddress(Value* value, object[] managedStack); // 0x0000000189E13258-0x0000000189E133D8
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe long valueToInt64(Value* value); // 0x0000000189E13CB4-0x0000000189E13DB0
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe float valueToFloat(Value* value); // 0x0000000189E13BAC-0x0000000189E13CB4
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe double valueToDouble(Value* value); // 0x0000000189E13AA4-0x0000000189E13BAC
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void storeToRawPointer(byte* destination, Value* src, Code code); // 0x0000000189E13634-0x0000000189E1384C
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		private unsafe void loadFromRawPointer(byte* source, Value* dest, Code code); // 0x0000000189E13078-0x0000000189E13258
		public void Execute(int methodIndex, ref Call call, int argsCount, int refCount = 0 /* Metadata: 0x02350B53 */); // 0x0000000189E124C4-0x0000000189E1252C
		public unsafe Value* Execute(int methodIndex, Value* argumentBase, object[] managedStack, Value* evaluationStackBase, int argsCount); // 0x0000000189E1247C-0x0000000189E124C4
		private void throwRuntimeException(Exception e, bool bWrap); // 0x0000000189E139F8-0x0000000189E13A7C
		private ExceptionHandler getExceptionHandler(int methodIndex, System.Type exceptionType, int pc); // 0x0000000189E12FC0-0x0000000189E13078
		private unsafe void arrayGet(object obj, int idx, Value* val, object[] managedStack, Value* evaluationStackBase); // 0x0000000189E12760-0x0000000189E12ACC
		private unsafe void arraySet(object obj, int idx, Value* val, object[] managedStack, Value* evaluationStackBase); // 0x0000000189E12ACC-0x0000000189E12DFC
		public static void _Info(string a); // 0x0000000189E125BC-0x0000000189E12634
		public unsafe Value* Execute(Instruction* pc, Value* argumentBase, object[] managedStack, Value* evaluationStackBase, int argsCount, int methodIndex, int refCount = 0 /* Metadata: 0x02350B54 */, Value** topWriteBack = null); // 0x0000000189DFAAD8-0x0000000189E06C20
	}

	public interface WrappersManager // TypeDefIndex: 62269
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
	internal enum Option // TypeDefIndex: 62252
	{
		NullChecks = 1,
		ArrayBoundsChecks = 2,
		DivideByZeroChecks = 3
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	internal class Il2CppSetOptionAttribute : Attribute // TypeDefIndex: 62253
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Unity.IL2CPP.CompilerServices.Option _Option_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _Value_k__BackingField; // 0x18
	
		// Properties
		private Unity.IL2CPP.CompilerServices.Option Option { [CompilerGenerated] set; } // 0x00000001814F51F0-0x00000001814F5220
		private object Value { [CompilerGenerated] set; } // 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		internal Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option option, object value); // 0x0000000185391D70-0x0000000185391D80
	}
}
