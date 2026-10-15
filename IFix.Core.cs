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

// Image 65: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89261-89302

namespace IFix
{
	[AttributeUsage(AttributeTargets.Class)]
	public class CustomBridgeAttribute : Attribute // TypeDefIndex: 89293
	{
		// Constructors
		public CustomBridgeAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix.Core
{
	public class IDTagAttribute : Attribute // TypeDefIndex: 89262
	{
		// Fields
		public int ID; // 0x10
	
		// Constructors
		public IDTagAttribute(int id); // 0x0000000182234E90-0x0000000182234EA0
	}

	public static class PatchManager // TypeDefIndex: 89271
	{
		// Fields
		private static readonly object patchLock; // 0x00
		private static bool hotPatchApiResolved; // 0x08
		private static MethodInfo hotPatchSetPatchMethod; // 0x10
		private static MethodInfo hotPatchClearPatchMethod; // 0x18
		private static PatchState patchState; // 0x20
		[CompilerGenerated]
		private static Func<ParameterInfo, System.Type> __f__am_cache0; // 0x28
	
		// Nested types
		private enum PatchKind // TypeDefIndex: 89263
		{
			Legacy = 0,
			Incremental = 1
		}
	
		private sealed class PatchEntry // TypeDefIndex: 89264
		{
			// Fields
			public PatchKind kind; // 0x10
			public System.Type targetType; // 0x18
			public Assembly wrapperAssembly; // 0x20
			public VirtualMachine virtualMachine; // 0x28
			public int[] positions; // 0x30
			public int[] methodIds; // 0x38
			public WrappersManager wm; // 0x40
			public MethodBase[] hotPatchMethods; // 0x48
			public Delegate[] hotPatchHandlers; // 0x50
	
			// Properties
			public bool isHotPatch { get; } // 0x0000000184930A60-0x0000000184930A70 
	
			// Constructors
			public PatchEntry(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private sealed class HotPatchBinding // TypeDefIndex: 89265
		{
			// Fields
			public PatchEntry entry; // 0x10
			public Delegate handler; // 0x18
	
			// Constructors
			public HotPatchBinding(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private sealed class PatchState // TypeDefIndex: 89266
		{
			// Fields
			public Dictionary<System.Type, List<PatchEntry>> activePatches; // 0x10
			public Dictionary<MethodBase, List<HotPatchBinding>> activeHotPatches; // 0x18
			public Dictionary<VirtualMachine, PatchEntry> patchesByVM; // 0x20
			public Dictionary<Assembly, VirtualMachine> legacyPatches; // 0x28
	
			// Constructors
			public PatchState(); // 0x0000000184947DC0-0x00000001849490E0
		}
	
		private sealed class WrapperArrayUpdate // TypeDefIndex: 89267
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
			public Array previousArray; // 0x18
			public Array nextArray; // 0x20
	
			// Constructors
			public WrapperArrayUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private sealed class HotPatchUpdate // TypeDefIndex: 89268
		{
			// Fields
			public MethodBase method; // 0x10
			public Delegate previousHandler; // 0x18
			public Delegate nextHandler; // 0x20
	
			// Constructors
			public HotPatchUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class _readMethod_c__AnonStorey0 // TypeDefIndex: 89269
		{
			// Fields
			internal System.Type[] genericArgInfos; // 0x10
	
			// Constructors
			public _readMethod_c__AnonStorey0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string __m__0(System.Text.RegularExpressions.Match m); // 0x000000018C2532E0-0x000000018C25334C
		}
	
		[CompilerGenerated]
		private sealed class _LoadInternal_c__AnonStorey1 // TypeDefIndex: 89270
		{
			// Fields
			internal List<IntPtr> nativePointers; // 0x10
	
			// Constructors
			public _LoadInternal_c__AnonStorey1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __m__0(); // 0x00000001849490E0-0x0000000184949990
		}
	
		// Constructors
		static PatchManager(); // 0x000000018C24FD20-0x000000018C24FE70
	
		// Methods
		private static PatchState CloneState(PatchState source); // 0x0000000184936D40-0x0000000184939F60
		private static void AddEntry(PatchState state, PatchEntry entry); // 0x0000000184931080-0x0000000184932DB0
		private static void RemoveEntry(PatchState state, PatchEntry entry); // 0x0000000184944020-0x00000001849458C0
		private static WrapperArrayUpdate BuildWrapperArrayUpdate(PatchState state, System.Type targetType, WrappersManager fallbackManager); // 0x0000000184934040-0x0000000184936D40
		private static Delegate GetEffectiveHotPatchHandler(PatchState state, MethodBase method); // 0x0000000184939F60-0x000000018493A830
		private static HotPatchUpdate BuildHotPatchUpdate(PatchState candidate, MethodBase method); // 0x0000000184933920-0x0000000184934040
		private static void ApplyHotPatchHandler(MethodBase method, Delegate handler); // 0x0000000184932DB0-0x0000000184933920
		private static void PublishState(PatchState candidate, Dictionary<System.Type, WrappersManager> affectedTargets, HashSet<MethodBase> affectedHotPatchMethods); // 0x000000018493FD00-0x0000000184942A20
		private static void AddAffectedEntry(PatchEntry entry, Dictionary<System.Type, WrappersManager> affectedTargets, HashSet<MethodBase> affectedHotPatchMethods); // 0x0000000184930A70-0x0000000184931080
		private static void RegisterPatch(System.Type targetType, VirtualMachine virtualMachine, int[] positions, int[] methodIds, WrappersManager wrapperManager, PatchKind kind, MethodBase[] hotPatchMethods, Delegate[] hotPatchHandlers); // 0x0000000184942A20-0x0000000184944020
		private static MethodBase readMethod(BinaryReader reader, System.Type[] externTypes); // 0x000000018C250164-0x000000018C250B90
		private static int getMapId(List<System.Type> idMapArray, MethodBase method); // 0x000000018C24FFDC-0x000000018C250164
		private static string getMapFieldName(MethodBase method); // 0x000000018C24FE70-0x000000018C24FFDC
		private static System.Type getHotPatchDelegateType(List<System.Type> hotPatchIdMapList, Assembly assembly, MethodBase method); // 0x0000000184946D40-0x0000000184947DC0
		private static void resolveHotPatchApi(); // 0x000000018C250E64-0x000000018C2510F8
		private static int[] readSlotInfo(BinaryReader reader, Dictionary<MethodInfo, int> itfMethodToId, System.Type[] externTypes, int maxId); // 0x000000018C250B90-0x000000018C250E64
		public static VirtualMachine Load(Stream stream, bool checkNew = true /* Metadata: 0x02648989 */); // 0x000000018C24FB58-0x000000018C24FBAC
		public static VirtualMachine LoadIncremental(Stream stream, bool checkNew = true /* Metadata: 0x0264898A */); // 0x000000018493A830-0x000000018493AB50
		private static VirtualMachine LoadInternal(Stream stream, bool checkNew, PatchKind kind); // 0x000000018493AB50-0x000000018493FD00
		public static void UnloadIncremental(VirtualMachine virtualMachine); // 0x00000001849468D0-0x0000000184946D40
		public static void Unload(Assembly assembly); // 0x000000018C24FBAC-0x000000018C24FD20
		private static void RemovePatch(VirtualMachine virtualMachine, bool incrementalOnly); // 0x00000001849458C0-0x00000001849468D0
		[CompilerGenerated]
		private static System.Type _readMethod_m__0(ParameterInfo p); // 0x000000018788A2DC-0x000000018788A2F4
	}

	public enum Code // TypeDefIndex: 89272
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

	public struct Instruction // TypeDefIndex: 89273
	{
		// Fields
		public Code Code; // 0x00
		public int Operand; // 0x04
	}

	public enum ExceptionHandlerType // TypeDefIndex: 89274
	{
		Catch = 0,
		Filter = 1,
		Finally = 2,
		Fault = 4
	}

	public sealed class ExceptionHandler // TypeDefIndex: 89275
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
		public ExceptionHandler(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class AnonymousStorey // TypeDefIndex: 89276
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
		public AnonymousStorey(int fieldNum, int[] fieldTypes, int typeID, int[] vTable, VirtualMachine virtualMachine); // 0x000000018C24BBD8-0x000000018C24BDE8
	
		// Methods
		internal unsafe void Ldfld(int fieldIndex, Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack); // 0x000000018C24B8F4-0x000000018C24B9D0
		internal unsafe void Stfld(int fieldIndex, Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack); // 0x000000018C24BA48-0x000000018C24BB0C
		internal object Get(int fieldIndex, System.Type type, VirtualMachine virtualMachine, bool valueTypeClone); // 0x000000018C24B874-0x000000018C24B8F4
		internal void Set(int fieldIndex, object obj, System.Type type, VirtualMachine virtualMachine); // 0x000000018C24B9D0-0x000000018C24BA48
		public bool ObjectEquals(object obj); // 0x0000000184F9DDF0-0x0000000184F9DE00
		public override bool Equals(object obj); // 0x000000018C24B624-0x000000018C24B6E4
		public int ObjectGetHashCode(); // 0x0000000187235B50-0x0000000187235B60
		public override int GetHashCode(); // 0x000000018C24B7D4-0x000000018C24B874
		public string ObjectToString(); // 0x0000000188ABB3B8-0x0000000188ABB3C0
		public override string ToString(); // 0x000000018C24BB0C-0x000000018C24BBD8
		~AnonymousStorey(); // 0x000000018C24B6E4-0x000000018C24B7D4
	}

	public class AnonymousStoreyInfo // TypeDefIndex: 89277
	{
		// Fields
		public int FieldNum; // 0x10
		public int[] FieldTypes; // 0x18
		public int CtorId; // 0x20
		public int CtorParamNum; // 0x24
		public int[] Slots; // 0x28
		public int[] VTable; // 0x30
	
		// Constructors
		public AnonymousStoreyInfo(); // 0x000000018C24B5E4-0x000000018C24B624
	}

	public enum ValueType // TypeDefIndex: 89278
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

	public struct Value // TypeDefIndex: 89279
	{
		// Fields
		public IFix.Core.ValueType Type; // 0x00
		public int Value1; // 0x04
		public int Value2; // 0x08
	}

	internal class GenericDelegateFactory // TypeDefIndex: 89283
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
		private sealed class _Create_c__AnonStorey0 // TypeDefIndex: 89280
		{
			// Fields
			internal System.Type delegateType; // 0x10
	
			// Constructors
			public _Create_c__AnonStorey0(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class _Create_c__AnonStorey1 // TypeDefIndex: 89281
		{
			// Fields
			internal MethodInfo methodInfo; // 0x10
			internal _Create_c__AnonStorey0 __f__ref_0; // 0x18
	
			// Constructors
			public _Create_c__AnonStorey1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Delegate __m__0(GenericDelegate o); // 0x000000018C2532B8-0x000000018C2532E0
		}
	
		[CompilerGenerated]
		private sealed class _Create_c__AnonStorey2 // TypeDefIndex: 89282
		{
			// Fields
			internal MethodInfo methodInfo; // 0x10
			internal _Create_c__AnonStorey0 __f__ref_0; // 0x18
	
			// Constructors
			public _Create_c__AnonStorey2(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Delegate __m__0(GenericDelegate o); // 0x000000018C2532B8-0x000000018C2532E0
		}
	
		// Constructors
		static GenericDelegateFactory(); // 0x000000018C24EF28-0x000000018C24F010
	
		// Methods
		private static void PreventStripping(object obj); // 0x000000018C24EC48-0x000000018C24EE0C
		internal static Delegate Create(System.Type delegateType, VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018C24E0E8-0x000000018C24EC48
		[CompilerGenerated]
		private static bool _Create_m__0(MethodInfo m); // 0x000000018C24EE0C-0x000000018C24EE60
		[CompilerGenerated]
		private static int _Create_m__1(MethodInfo m); // 0x000000018C24EE60-0x000000018C24EE8C
		[CompilerGenerated]
		private static bool _Create_m__2(MethodInfo m); // 0x000000018C24EE8C-0x000000018C24EEE0
		[CompilerGenerated]
		private static int _Create_m__3(MethodInfo m); // 0x000000018C24EE60-0x000000018C24EE8C
		[CompilerGenerated]
		private static bool _Create_m__4(ParameterInfo p); // 0x000000018C24EEE0-0x000000018C24EF28
		[CompilerGenerated]
		private static Delegate _Create_m__5(GenericDelegate x); // 0x0000000185829EC0-0x0000000185829ED0
		[CompilerGenerated]
		private static System.Type _Create_m__6(ParameterInfo pinfo); // 0x000000018788A2DC-0x000000018788A2F4
	}

	internal class GenericDelegate // TypeDefIndex: 89284
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		private bool pushSelf; // 0x28
		private int extraArgNum; // 0x2C
	
		// Constructors
		internal GenericDelegate(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018C24F0AC-0x000000018C24F0F4
	
		// Methods
		public void Action(); // 0x000000018C24F010-0x000000018C24F0AC
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

	public class ObjectClone // TypeDefIndex: 89287
	{
		// Fields
		private MethodInfo memberwiseClone; // 0x10
	
		// Constructors
		public ObjectClone(); // 0x000000018C24FAC0-0x000000018C24FB58
	
		// Methods
		public object Clone(object obj); // 0x000000018C24FA9C-0x000000018C24FAC0
	}

	internal class ReflectionMethodInvoker // TypeDefIndex: 89288
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
		public ReflectionMethodInvoker(MethodBase method); // 0x000000018C252914-0x000000018C252D54
	
		// Methods
		public void Invoke(VirtualMachine virtualMachine, ref Call call, bool isInstantiate); // 0x000000018C2510F8-0x000000018C252914
		private object invokeConstructorAndUnwrap(object[] args); // 0x000000018C252D54-0x000000018C252E18
		private object invokeMethodAndUnwrap(object instance, object[] args); // 0x000000018C252E18-0x000000018C252EDC
		private void tryWriteBackPreservingPrimary(object instance, IntPtr pointerAddr); // 0x000000018C252EDC-0x000000018C2530A0
	}

	internal struct UnmanagedStack // TypeDefIndex: 89289
	{
		// Fields
		public unsafe Value* Base; // 0x00
		public unsafe Value* Top; // 0x08
	}

	internal class ThreadStackInfo // TypeDefIndex: 89290
	{
		// Fields
		public unsafe UnmanagedStack* UnmanagedStack; // 0x10
		public object[] ManagedStack; // 0x18
		private IntPtr evaluationStackHandler; // 0x20
		private IntPtr unmanagedStackHandler; // 0x28
		private static LocalDataStoreSlot localSlot; // 0x00
	
		// Properties
		internal static ThreadStackInfo Stack { get; } // 0x000000018C2531D4-0x000000018C2532B8 
	
		// Constructors
		public ThreadStackInfo(); // 0x000000018C25313C-0x000000018C2531D4
		static ThreadStackInfo(); // 0x000000018C2530EC-0x000000018C25313C
	}

	internal static class EvaluationStackOperation // TypeDefIndex: 89291
	{
		// Methods
		internal static unsafe void UnboxPrimitive(Value* evaluationStackPointer, object obj, System.Type type); // 0x000000018C24D3BC-0x000000018C24D8BC
		internal static object mGet(bool isArray, object root, int layer, int[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, Dictionary<int, NewFieldInfo> newFieldInfos); // 0x000000018C24DC6C-0x000000018C24DE90
		internal static void mSet(bool isArray, object root, object val, int layer, int[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, Dictionary<int, NewFieldInfo> newFieldInfos); // 0x000000018C24DE90-0x000000018C24E0E8
		internal static unsafe object ToObject(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, System.Type type, VirtualMachine virtualMachine, bool valueTypeClone = true /* Metadata: 0x02648ACB */); // 0x000000018C24C8EC-0x000000018C24D3BC
		public static unsafe void PushObject(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, object obj, System.Type type); // 0x000000018C24C628-0x000000018C24C8EC
		public static unsafe void UpdateReference(Value* evaluationStackBase, Value* evaluationStackPointer, object[] managedStack, object obj, VirtualMachine virtualMachine, System.Type type); // 0x000000018C24D8BC-0x000000018C24DC6C
	}

	public struct Call // TypeDefIndex: 89292
	{
		// Fields
		internal unsafe Value* argumentBase; // 0x00
		internal unsafe Value* evaluationStackBase; // 0x08
		internal object[] managedStack; // 0x10
		internal unsafe Value* currentTop; // 0x18
		internal unsafe Value** topWriteBack; // 0x20
	
		// Methods
		public static Call Begin(); // 0x000000018C24BE68-0x000000018C24BF2C
		internal static Call BeginForStack(ThreadStackInfo stack); // 0x000000018C24BDE8-0x000000018C24BE68
		public void PushBoolean(bool b); // 0x000000018C24C0C8-0x000000018C24C0FC
		public bool GetBoolean(int offset = 0 /* Metadata: 0x02648ACC */); // 0x000000018C24BF2C-0x000000018C24BF60
		public void PushByte(byte b); // 0x000000018C24C0FC-0x000000018C24C108
		public byte GetByte(int offset = 0 /* Metadata: 0x02648ACD */); // 0x000000018C24BF60-0x000000018C24BF68
		public void PushInt16(short s); // 0x000000018C24C13C-0x000000018C24C148
		public short GetInt16(int offset = 0 /* Metadata: 0x02648ACE */); // 0x000000018C24BF60-0x000000018C24BF68
		public void PushChar(char c); // 0x000000018C24C108-0x000000018C24C114
		public char GetChar(int offset = 0 /* Metadata: 0x02648ACF */); // 0x000000018C24BF60-0x000000018C24BF68
		public void PushUInt16(ushort us); // 0x000000018C24C108-0x000000018C24C114
		public ushort GetUInt16(int offset = 0 /* Metadata: 0x02648AD0 */); // 0x000000018C24BF60-0x000000018C24BF68
		public void PushInt32(int i); // 0x000000018C24C148-0x000000018C24C178
		public int GetInt32(int offset = 0 /* Metadata: 0x02648AD1 */); // 0x000000018C24BF98-0x000000018C24BFC8
		public void PushUInt32(uint ui); // 0x000000018C24C2F4-0x000000018C24C2FC
		public uint GetUInt32(int offset = 0 /* Metadata: 0x02648AD2 */); // 0x000000018C24BF60-0x000000018C24BF68
		public void PushInt64(long i); // 0x000000018C24C178-0x000000018C24C1A8
		public long GetInt64(int offset = 0 /* Metadata: 0x02648AD3 */); // 0x000000018C24BFC8-0x000000018C24BFF8
		public void PushUInt64(ulong i); // 0x000000018C24C2FC-0x000000018C24C304
		public ulong GetUInt64(int offset = 0 /* Metadata: 0x02648AD4 */); // 0x000000018C24BFF8-0x000000018C24C000
		public void PushSingle(float f); // 0x000000018C24C2CC-0x000000018C24C2F4
		public float GetSingle(int offset = 0 /* Metadata: 0x02648AD5 */); // 0x000000018C24C098-0x000000018C24C0C8
		public void PushDouble(double d); // 0x000000018C24C114-0x000000018C24C13C
		public double GetDouble(int offset = 0 /* Metadata: 0x02648AD6 */); // 0x000000018C24BF68-0x000000018C24BF98
		public void PushIntPtr(IntPtr i); // 0x000000018C24C1A8-0x000000018C24C1B4
		public IntPtr GetIntPtr(int offset = 0 /* Metadata: 0x02648AD7 */); // 0x000000018C24BFF8-0x000000018C24C000
		public void PushObject(object o); // 0x000000018C24C1F0-0x000000018C24C28C
		public void PushValueType(object o); // 0x000000018C24C304-0x000000018C24C3A0
		public object GetObject(int offset = 0 /* Metadata: 0x02648AD8 */); // 0x000000018C24C000-0x000000018C24C098
		public T GetAsType<T>(int offset = 0 /* Metadata: 0x02648AD9 */);
		public void PushObjectAsResult(object obj, System.Type type); // 0x000000018C24C1B4-0x000000018C24C1F0
		public void PushRef(int offset); // 0x000000018C24C28C-0x000000018C24C2CC
		public void UpdateReference(int offset, object obj, VirtualMachine virtualMachine, System.Type type); // 0x000000018C24C3A0-0x000000018C24C454
	}

	public static class Utils // TypeDefIndex: 89294
	{
		// Fields
		private static Dictionary<System.Type, MethodInfo> delegateAdptCache; // 0x00
	
		// Constructors
		static Utils(); // 0x000000018C253754-0x000000018C2537E0
	
		// Methods
		public static bool IsAssignable(MethodInfo delegateMethod, MethodInfo method); // 0x000000018C25334C-0x000000018C2534E8
		public static Delegate TryAdapterToDelegate(object obj, System.Type delegateType, string perfix); // 0x000000018C2534E8-0x000000018C253754
	}

	internal class RuntimeException : Exception // TypeDefIndex: 89295
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Exception _Real_k__BackingField; // 0x90
	
		// Properties
		public Exception Real { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
	
		// Constructors
		public RuntimeException(); // 0x000000018C2530A0-0x000000018C2530EC
	}

	public delegate void ExternInvoker(VirtualMachine vm, ref Call call, bool isInstantiate); // TypeDefIndex: 89296; 0x00000001811DF7F0-0x00000001811DF810

	internal class FieldAddr // TypeDefIndex: 89297
	{
		// Fields
		public object Object; // 0x10
		public int[] FieldIdList; // 0x18
	
		// Constructors
		public FieldAddr(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class Cleanner // TypeDefIndex: 89298
	{
		// Fields
		private static bool start; // 0x00
	
		// Constructors
		public Cleanner(); // 0x0000000186805BA0-0x0000000186805BB0
		static Cleanner(); // 0x000000018C24C5F0-0x000000018C24C628
	
		// Methods
		public static void Start(); // 0x000000018C24C52C-0x000000018C24C5A0
		public static void Stop(); // 0x000000018C24C5A0-0x000000018C24C5F0
		~Cleanner(); // 0x000000018C24C454-0x000000018C24C52C
	}

	public class NewFieldInfo // TypeDefIndex: 89299
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
		public NewFieldInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		static NewFieldInfo(); // 0x000000018C24F938-0x000000018C24FA9C
	
		// Methods
		private object SetDefaultValue(object obj); // 0x000000018C24F488-0x000000018C24F500
		public static void Sweep(); // 0x000000018C24F71C-0x000000018C24F938
		public void CheckInit(VirtualMachine virtualMachine, object obj); // 0x000000018C24F0F4-0x000000018C24F20C
		public int ObjectToIndex(object obj); // 0x000000018C24F428-0x000000018C24F488
		public bool HasInitialize(object obj); // 0x000000018C24F310-0x000000018C24F428
		public object GetValue(object obj); // 0x000000018C24F20C-0x000000018C24F310
		public void SetValue(object obj, object value); // 0x000000018C24F500-0x000000018C24F71C
	}

	public class VirtualMachine // TypeDefIndex: 89301
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
		public ExceptionHandler[][] ExceptionHandlers { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public System.Type[] ExternTypes { get; set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public MethodBase[] ExternMethods { get; set; } // 0x000000018226EEA0-0x000000018226EEB0 0x000000018C2548B4-0x000000018C254924
		public string[] InternStrings { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public System.Reflection.FieldInfo[] FieldInfos { set; } // 0x00000001856B9750-0x00000001856B9760
		public Dictionary<int, NewFieldInfo> NewFieldInfos { set; } // 0x0000000188800CB0-0x0000000188800CC0
		public AnonymousStoreyInfo[] AnonymousStoreyInfos { set; } // 0x0000000186B19440-0x0000000186B19450
		public System.Type[] StaticFieldTypes { set; } // 0x000000018C254924-0x000000018C2549A0
		public int[] Cctors { set; } // 0x0000000188800C74-0x0000000188800C88
		public WrappersManager WrappersManager { get; set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
	
		// Nested types
		private class CalliInvokerInfo // TypeDefIndex: 89300
		{
			// Fields
			public ExternInvoker Invoker; // 0x10
			public int ArgumentCount; // 0x18
	
			// Constructors
			public CalliInvokerInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		internal unsafe VirtualMachine(Instruction** unmanaged_codes, Action on_dispose); // 0x000000018C2539C8-0x000000018C253B10
		static VirtualMachine(); // 0x00000001870A89C0-0x00000001870A8AA0
	
		// Methods
		~VirtualMachine(); // 0x000000018C253890-0x000000018C253950
		private unsafe void checkCctorExecute(int fieldId, Value* argumentBase, object[] managedStack, Value* evaluationStackBase); // 0x000000018C2541C4-0x000000018C254250
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void store(Value* stackBase, Value* dst, Value* src, object[] managedStack); // 0x000000018C254BCC-0x000000018C254D80
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void copy(Value* stackBase, Value* dst, Value* src, object[] managedStack); // 0x000000018C254250-0x000000018C254394
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void resolveStackReference(Value* value, Value* stackBase, object[] managedStack); // 0x000000018C25475C-0x000000018C2548B4
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe byte* stackReferenceToPointer(Value* value); // 0x000000018C2549A0-0x000000018C2549B4
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		private unsafe bool tryConvertStackReferenceToPointer(Value* value); // 0x000000018C254E04-0x000000018C254E2C
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe byte* pointerValueToAddress(Value* value, object[] managedStack); // 0x000000018C25463C-0x000000018C25475C
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe long valueToInt64(Value* value); // 0x000000018C25503C-0x000000018C255138
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe float valueToFloat(Value* value); // 0x000000018C254F34-0x000000018C25503C
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe double valueToDouble(Value* value); // 0x000000018C254E2C-0x000000018C254F34
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		private unsafe void storeToRawPointer(byte* destination, Value* src, Code code); // 0x000000018C2549B4-0x000000018C254BCC
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
		[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
		private unsafe void loadFromRawPointer(byte* source, Value* dest, Code code); // 0x000000018C25444C-0x000000018C25463C
		public void Execute(int methodIndex, ref Call call, int argsCount, int refCount = 0 /* Metadata: 0x02648ADA */); // 0x000000018C253828-0x000000018C253890
		public unsafe Value* Execute(int methodIndex, Value* argumentBase, object[] managedStack, Value* evaluationStackBase, int argsCount); // 0x000000018C2537E0-0x000000018C253828
		private void throwRuntimeException(Exception e, bool bWrap); // 0x000000018C254D80-0x000000018C254E04
		private ExceptionHandler getExceptionHandler(int methodIndex, System.Type exceptionType, int pc); // 0x000000018C254394-0x000000018C25444C
		private unsafe void arrayGet(object obj, int idx, Value* val, object[] managedStack, Value* evaluationStackBase); // 0x000000018C253B10-0x000000018C253E7C
		private unsafe void arraySet(object obj, int idx, Value* val, object[] managedStack, Value* evaluationStackBase); // 0x000000018C253E7C-0x000000018C2541C4
		public static void _Info(string a); // 0x000000018C253950-0x000000018C2539C8
		public unsafe Value* Execute(Instruction* pc, Value* argumentBase, object[] managedStack, Value* evaluationStackBase, int argsCount, int methodIndex, int refCount = 0 /* Metadata: 0x02648ADB */, Value** topWriteBack = null); // 0x000000018C23FCD0-0x000000018C24B5E4
	}

	public interface WrappersManager // TypeDefIndex: 89302
	{
		// Methods
		Delegate CreateDelegate(System.Type type, int id, object anon);
		AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine);
		object CreateWrapper(int id);
	}
}

namespace Unity.IL2CPP.CompilerServices
{
	internal enum Option // TypeDefIndex: 89285
	{
		NullChecks = 1,
		ArrayBoundsChecks = 2,
		DivideByZeroChecks = 3
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	internal class Il2CppSetOptionAttribute : Attribute // TypeDefIndex: 89286
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Unity.IL2CPP.CompilerServices.Option _Option_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _Value_k__BackingField; // 0x18
	
		// Properties
		private Unity.IL2CPP.CompilerServices.Option Option { [CompilerGenerated] set; } // 0x0000000182234E90-0x0000000182234EA0
		private object Value { [CompilerGenerated] set; } // 0x0000000187835500-0x0000000187835510
	
		// Constructors
		internal Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option option, object value); // 0x0000000185CF10D0-0x0000000185CF1300
	}
}
