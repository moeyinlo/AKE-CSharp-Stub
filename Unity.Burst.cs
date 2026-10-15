/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Scripting;

// Image 88: Unity.Burst.dll - Assembly: Unity.Burst, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90129-90180

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 90180
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_256 _07DB995E8ED2CFB0AB71EBA69F3A3EC07D5C6AC10C0C64F33E94ED2949B348AA; // 0x00 // Static value (base64): AAABAQICAgIDAwMDAwMDAwQEBAQEBAQEBAQEBAQEBAQFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBw== - Metadata: 0x0264AB30
	internal static readonly __StaticArrayInitTypeSize_32 C69994AC61B52FBCEA582D6CCCD595C12E00BDB18F0C6F593FB6B393CAEDB08C; // 0x100 // Static value (base64): AQAAAAoAAABkAAAA6AMAABAnAACghgEAQEIPAICWmAA= - Metadata: 0x0264AC38
	internal static readonly long D0067CAD9A63E0813759A2BB841051CA73570C0DA2E08E840A8EB45DB6A7A010; // 0x120 // Static value (base64): SW5maW5pdHk= - Metadata: 0x0264AC60
	internal static readonly __StaticArrayInitTypeSize_3 D5B592C05DC25B5032553F1B27F4139BE95E881F73DB33B02B05AB20C3F9981E; // 0x128 // Static value (base64): TmFO - Metadata: 0x0264AC70

	// Nested types
	private struct __StaticArrayInitTypeSize_3 // TypeDefIndex: 90177
	{
	}

	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 90178
	{
	}

	private struct __StaticArrayInitTypeSize_256 // TypeDefIndex: 90179
	{
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 90130
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 90131
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Unity.Burst
{
	public enum OptimizeFor // TypeDefIndex: 90132
	{
		Default = 0,
		Performance = 1,
		Size = 2,
		FastCompilation = 3,
		Balanced = 4
	}

	public enum FloatMode // TypeDefIndex: 90133
	{
		Default = 0,
		Strict = 1,
		Deterministic = 2,
		Fast = 3
	}

	public enum FloatPrecision // TypeDefIndex: 90134
	{
		Standard = 0,
		High = 1,
		Medium = 2,
		Low = 3
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
	public class BurstCompileAttribute : Attribute // TypeDefIndex: 90135
	{
		// Fields
		[CompilerGenerated]
		private FloatMode _FloatMode_k__BackingField; // 0x10
		[CompilerGenerated]
		private FloatPrecision _FloatPrecision_k__BackingField; // 0x14
		internal bool? _compileSynchronously; // 0x18
		internal bool? _disableDirectCall; // 0x1A
		[CompilerGenerated]
		private OptimizeFor _OptimizeFor_k__BackingField; // 0x1C
		[CompilerGenerated]
		private string[] _Options_k__BackingField; // 0x20
	
		// Properties
		public FloatMode FloatMode { [CompilerGenerated] set; } // 0x0000000182234E90-0x0000000182234EA0
		public FloatPrecision FloatPrecision { [CompilerGenerated] set; } // 0x000000018275FD70-0x000000018275FD80
		public bool CompileSynchronously { set; } // 0x000000018709C990-0x000000018709C9E0
		public bool DisableDirectCall { set; } // 0x00000001871844E0-0x0000000187184530
		public OptimizeFor OptimizeFor { [CompilerGenerated] set; } // 0x0000000187233010-0x0000000187233020
		internal string[] Options { [CompilerGenerated] set; } // 0x0000000187835950-0x0000000187835960
	
		// Constructors
		public BurstCompileAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode); // 0x000000018722B780-0x000000018722B790
	}

	public static class BurstCompiler // TypeDefIndex: 90141
	{
		// Fields
		internal static bool _IsEnabled; // 0x00
		public static readonly BurstCompilerOptions Options; // 0x08
		internal static Action OnCompileILPPMethod2; // 0x10
		private static readonly MethodInfo DummyMethodInfo; // 0x18
	
		// Properties
		public static bool IsEnabled { get; } // 0x0000000184FEF710-0x0000000184FEF780 
	
		// Nested types
		[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
		internal class StaticTypeReinitAttribute : Attribute // TypeDefIndex: 90136
		{
			// Fields
			public readonly System.Type reinitType; // 0x10
	
			// Constructors
			public StaticTypeReinitAttribute(System.Type toReinit); // 0x0000000184FD2410-0x0000000184FD2420
		}
	
		[BurstCompile]
		internal static class BurstCompilerHelper // TypeDefIndex: 90138
		{
			// Fields
			private static readonly IsBurstEnabledDelegate IsBurstEnabledImpl; // 0x00
			public static readonly bool IsBurstGenerated; // 0x08
	
			// Nested types
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			private delegate bool IsBurstEnabledDelegate(); // TypeDefIndex: 90137; 0x0000000185B44B70-0x0000000185B44B80
	
			// Constructors
			static BurstCompilerHelper(); // 0x000000018633AE30-0x000000018633AEF0
	
			// Methods
			[BurstCompile]
			[AOT.MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
			private static bool IsBurstEnabled(); // 0x000000018D2A59DC-0x000000018D2A5A18
			[BurstDiscard]
			private static void DiscardedMethod(ref bool value); // 0x0000000187233BD0-0x0000000187233BE0
			private static bool IsCompiledByBurst(Delegate del); // 0x000000018633C540-0x000000018633C5A0
		}
	
		private class FakeDelegate // TypeDefIndex: 90139
		{
			// Fields
			[CompilerGenerated]
			private readonly MethodInfo _Method_k__BackingField; // 0x10
	
			// Properties
			[UnityEngine.Scripting.Preserve]
			public MethodInfo Method { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
	
			// Constructors
			public FakeDelegate(MethodInfo method); // 0x0000000184FD2410-0x0000000184FD2420
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90140
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Attribute, bool> __9__22_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E5A80-0x00000001871E5AE0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _Compile_b__22_0(Attribute s); // 0x0000000186CBD4A0-0x0000000186CBD510
		}
	
		// Constructors
		static BurstCompiler(); // 0x0000000186DBBDA0-0x0000000186DBBEC0
	
		// Methods
		public static IntPtr CompileILPPMethod2(RuntimeMethodHandle burstMethodHandle); // 0x000000018633C6E0-0x000000018633C7C0
		public static unsafe void* GetILPPMethodFunctionPointer2(IntPtr ilppMethod, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle); // 0x0000000186BFD550-0x0000000186BFD580
		public static FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod)
			where T : class;
		private static unsafe void* Compile(object delegateObj, bool isFunctionPointer); // 0x000000018633C610-0x000000018633C6E0
		private static unsafe void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing); // 0x000000018633C850-0x000000018633CAF0
		private static void DummyMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public sealed class BurstCompilerOptions // TypeDefIndex: 90142
	{
		// Fields
		internal static readonly bool ForceDisableBurstCompilation; // 0x00
		private static readonly bool ForceBurstCompilationSynchronously; // 0x01
		internal static readonly bool IsSecondaryUnityProcess; // 0x02
		private bool _enableBurstCompilation; // 0x10
		private bool _enableBurstSafetyChecks; // 0x11
		[CompilerGenerated]
		private readonly bool _IsGlobal_k__BackingField; // 0x12
		[CompilerGenerated]
		private Action _OptionsChanged_k__BackingField; // 0x18
	
		// Properties
		private bool IsGlobal { [CompilerGenerated] get; } // 0x0000000187235CB0-0x0000000187235CC0 
		public bool EnableBurstCompilation { get; set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000186DBBF00-0x0000000186DBBFF0
		public bool EnableBurstSafetyChecks { set; } // 0x0000000186DBBFF0-0x0000000186DBC010
		internal Action OptionsChanged { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Constructors
		internal BurstCompilerOptions(bool isGlobal); // 0x0000000186DBBEC0-0x0000000186DBBF00
		static BurstCompilerOptions(); // 0x0000000186612E60-0x0000000186612F60
	
		// Methods
		private static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute); // 0x000000018633CBE0-0x000000018633CC60
		private static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo); // 0x000000018633CC60-0x000000018633CEF0
		internal static bool HasBurstCompileAttribute(MemberInfo member); // 0x000000018633CB80-0x000000018633CBE0
		private void OnOptionsChanged(); // 0x0000000186DBC010-0x0000000186DBC030
		private void MaybeTriggerRecompilation(); // 0x0000000186805BA0-0x0000000186805BB0
		private static bool CheckIsSecondaryUnityProcess(); // 0x00000001843FFFF0-0x0000000184400000
	}

	public static class BurstRuntime // TypeDefIndex: 90145
	{
		// Nested types
		private struct HashCode64<T> // TypeDefIndex: 90143
		{
			// Fields
			public static readonly long Value;
	
			// Constructors
			static HashCode64();
		}
	
		internal class PreserveAttribute : Attribute // TypeDefIndex: 90144
		{
			// Constructors
			public PreserveAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Methods
		public static long GetHashCode64<T>();
		internal static long HashStringWithFNV1A64(string text); // 0x0000000185EC39C0-0x0000000185EC3A30
		[Preserve]
		internal static void PreventRequiredAttributeStrip(); // 0x000000018D2A5A3C-0x000000018D2A5B18
		[Preserve]
		internal static unsafe void Log(byte* message, int logType, byte* fileName, int lineNumber); // 0x000000018D2A5A18-0x000000018D2A5A3C
	}

	internal static class BurstString // TypeDefIndex: 90156
	{
		// Fields
		private static readonly char[] SplitByColon; // 0x00
		private static readonly byte[] logTable; // 0x08
		private static readonly uint[] g_PowerOf10_U32; // 0x10
		private static readonly byte[] InfinityString; // 0x18
		private static readonly byte[] NanString; // 0x20
	
		// Nested types
		internal class PreserveAttribute : Attribute // TypeDefIndex: 90146
		{
			// Constructors
			public PreserveAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private enum NumberBufferKind // TypeDefIndex: 90147
		{
			Integer = 0,
			Float = 1
		}
	
		private struct NumberBuffer // TypeDefIndex: 90148
		{
			// Fields
			private readonly unsafe byte* _buffer; // 0x00
			public NumberBufferKind Kind; // 0x08
			public int DigitsCount; // 0x0C
			public int Scale; // 0x10
			public readonly bool IsNegative; // 0x14
	
			// Constructors
			public unsafe NumberBuffer(NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative); // 0x0000000187259120-0x0000000187259140
	
			// Methods
			public unsafe byte* GetDigitsPointer(); // 0x0000000184431970-0x0000000184431980
		}
	
		public enum NumberFormatKind : byte // TypeDefIndex: 90149
		{
			General = 0,
			Decimal = 1,
			DecimalForceSigned = 2,
			Hexadecimal = 3
		}
	
		public struct FormatOptions // TypeDefIndex: 90150
		{
			// Fields
			public NumberFormatKind Kind; // 0x00
			public sbyte AlignAndSize; // 0x01
			public byte Specifier; // 0x02
			public bool Lowercase; // 0x03
	
			// Properties
			public bool Uppercase { get; } // 0x000000018CFED0F8-0x000000018CFED100 
	
			// Constructors
			public FormatOptions(NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase); // 0x0000000187259100-0x0000000187259120
	
			// Methods
			public int GetBase(); // 0x000000018D2A8C7C-0x000000018D2A8C90
			public override string ToString(); // 0x000000018D2A8C90-0x000000018D2A8ECC
		}
	
		public struct tBigInt // TypeDefIndex: 90152
		{
			// Fields
			public int m_length; // 0x00
			public unsafe fixed /* 0x00000000-0x00000000 */ uint m_blocks[0]; // 0x04
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _m_blocks_e__FixedBuffer // TypeDefIndex: 90151
			{
				// Fields
				public uint FixedElementField; // 0x00
			}
	
			// Methods
			public int GetLength(); // 0x00000001844AD290-0x00000001844AD2A0
			public uint GetBlock(int idx); // 0x0000000187259220-0x0000000187259230
			public bool IsZero(); // 0x0000000186535F00-0x0000000186535F10
			public void SetU64(ulong val); // 0x000000018D2A9010-0x000000018D2A9040
			public void SetU32(uint val); // 0x000000018D2A8FFC-0x000000018D2A9010
		}
	
		public enum CutoffMode // TypeDefIndex: 90153
		{
			Unique = 0,
			TotalLength = 1,
			FractionLength = 2
		}
	
		public struct tFloatUnion32 // TypeDefIndex: 90154
		{
			// Fields
			public float m_floatingPoint; // 0x00
			public uint m_integer; // 0x00
	
			// Methods
			public bool IsNegative(); // 0x000000018CA3575C-0x000000018CA35764
			public uint GetExponent(); // 0x0000000187259230-0x0000000187259240
			public uint GetMantissa(); // 0x0000000187259240-0x0000000187259250
		}
	
		public struct tFloatUnion64 // TypeDefIndex: 90155
		{
			// Fields
			public double m_floatingPoint; // 0x00
			public ulong m_integer; // 0x00
	
			// Methods
			public bool IsNegative(); // 0x000000018D2A9040-0x000000018D2A9054
			public uint GetExponent(); // 0x0000000187259250-0x0000000187259260
			public ulong GetMantissa(); // 0x0000000187259260-0x0000000187259280
		}
	
		// Constructors
		static BurstString(); // 0x000000018D2A88AC-0x000000018D2A8AB8
	
		// Methods
		[Preserve]
		public static unsafe void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength); // 0x000000018D2A6F30-0x000000018D2A6F54
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw); // 0x000000018D2A80DC-0x000000018D2A81BC
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw); // 0x000000018D2A8498-0x000000018D2A8510
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw); // 0x000000018D2A8234-0x000000018D2A82AC
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw); // 0x000000018D2A82AC-0x000000018D2A8400
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw); // 0x000000018D2A7C54-0x000000018D2A7E18
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw); // 0x000000018D2A8510-0x000000018D2A8588
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw); // 0x000000018D2A7E90-0x000000018D2A7F08
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw); // 0x000000018D2A81BC-0x000000018D2A8234
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw); // 0x000000018D2A7E18-0x000000018D2A7E90
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw); // 0x000000018D2A7F08-0x000000018D2A7FA4
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw); // 0x000000018D2A8040-0x000000018D2A80DC
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw); // 0x000000018D2A7FA4-0x000000018D2A8040
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw); // 0x000000018D2A8400-0x000000018D2A8498
		private static unsafe void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, FormatOptions options); // 0x000000018D2A6DC0-0x000000018D2A6F30
		private static int GetLengthIntegerToString(long value, int basis, int zeroPadding); // 0x000000018D2A864C-0x000000018D2A8678
		private static unsafe void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, FormatOptions options); // 0x000000018D2A6C48-0x000000018D2A6DC0
		private static unsafe void FormatNumber(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, FormatOptions options); // 0x000000018D2A7A58-0x000000018D2A7C54
		private static unsafe void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int zeroPadding, bool outputPositiveSign); // 0x000000018D2A768C-0x000000018D2A772C
		private static byte ValueToIntegerChar(int value, bool uppercase); // 0x000000018D2A8884-0x000000018D2A88AC
		private static unsafe bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length); // 0x000000018D2A5B48-0x000000018D2A5BD4
		private static unsafe bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length); // 0x000000018D2A5B18-0x000000018D2A5B48
		private static int GetLengthForFormatGeneral(ref NumberBuffer number, int nMaxDigits); // 0x000000018D2A8588-0x000000018D2A864C
		private static unsafe void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, byte expChar); // 0x000000018D2A772C-0x000000018D2A78A4
		private static void RoundNumber(ref NumberBuffer number, int pos, bool isCorrectlyRounded); // 0x000000018D2A876C-0x000000018D2A8860
		private static unsafe bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded); // 0x000000018D2A8860-0x000000018D2A8884
		private static uint LogBase2(uint val); // 0x000000018D2A8678-0x000000018D2A876C
		private static int BigInt_Compare([IsReadOnly] in tBigInt lhs, [IsReadOnly] in tBigInt rhs); // 0x000000018D2A5CFC-0x000000018D2A5D54
		private static void BigInt_Add(out tBigInt pResult, [IsReadOnly] in tBigInt lhs, [IsReadOnly] in tBigInt rhs); // 0x000000018D2A5C88-0x000000018D2A5CFC
		private static void BigInt_Add_internal(out tBigInt pResult, [IsReadOnly] in tBigInt pLarge, [IsReadOnly] in tBigInt pSmall); // 0x000000018D2A5BD4-0x000000018D2A5C88
		private static void BigInt_Multiply(out tBigInt pResult, [IsReadOnly] in tBigInt lhs, [IsReadOnly] in tBigInt rhs); // 0x000000018D2A6348-0x000000018D2A63BC
		private static void BigInt_Multiply_internal(out tBigInt pResult, [IsReadOnly] in tBigInt pLarge, [IsReadOnly] in tBigInt pSmall); // 0x000000018D2A61FC-0x000000018D2A62E0
		private static void BigInt_Multiply(out tBigInt pResult, [IsReadOnly] in tBigInt lhs, uint rhs); // 0x000000018D2A62E0-0x000000018D2A6348
		private static void BigInt_Multiply2(out tBigInt pResult, [IsReadOnly] in tBigInt input); // 0x000000018D2A5EE8-0x000000018D2A5F40
		private static void BigInt_Multiply2(ref tBigInt pResult); // 0x000000018D2A5F40-0x000000018D2A5F7C
		private static void BigInt_Multiply10(ref tBigInt pResult); // 0x000000018D2A5EAC-0x000000018D2A5EE8
		private static tBigInt g_PowerOf10_Big(int i); // 0x000000018D2A8AB8-0x000000018D2A8C7C
		private static void BigInt_Pow10(out tBigInt pResult, uint exponent); // 0x000000018D2A63BC-0x000000018D2A65D0
		private static void BigInt_MultiplyPow10(out tBigInt pResult, [IsReadOnly] in tBigInt input, uint exponent); // 0x000000018D2A5F7C-0x000000018D2A61FC
		private static void BigInt_Pow2(out tBigInt pResult, uint exponent); // 0x000000018D2A65D0-0x000000018D2A661C
		private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref tBigInt pDividend, [IsReadOnly] in tBigInt divisor); // 0x000000018D2A5D54-0x000000018D2A5EAC
		private static void BigInt_ShiftLeft(ref tBigInt pResult, uint shift); // 0x000000018D2A661C-0x000000018D2A6768
		private static unsafe uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, out int pOutExponent); // 0x000000018D2A6F54-0x000000018D2A768C
		private static unsafe void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, FormatOptions formatOptions); // 0x000000018D2A78A4-0x000000018D2A7A58
		private static unsafe void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, FormatOptions formatOptions); // 0x000000018D2A69E8-0x000000018D2A6C48
		private static unsafe void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, FormatOptions formatOptions); // 0x000000018D2A6768-0x000000018D2A69E8
	}

	[IsReadOnly]
	public struct FunctionPointer<T> // TypeDefIndex: 90157
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private readonly IntPtr _ptr;
	
		// Properties
		public T Invoke { get; }
	
		// Constructors
		public FunctionPointer(IntPtr ptr);
	}

	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class NoAliasAttribute : Attribute // TypeDefIndex: 90158
	{
		// Constructors
		public NoAliasAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[IsReadOnly]
	public struct SharedStatic<T> // TypeDefIndex: 90159
		where T : struct
	{
		// Fields
		private readonly unsafe void* _buffer;
	
		// Properties
		public ref T Data { get; }
		public unsafe void* UnsafeDataPointer { get; }
	
		// Constructors
		private unsafe SharedStatic(void* buffer);
	
		// Methods
		public static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0 /* Metadata: 0x0264AB2D */);
		public static SharedStatic<T> GetOrCreate<TContext, TSubContext>(uint alignment = 0 /* Metadata: 0x0264AB2E */);
		public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode);
	}

	internal static class SharedStatic // TypeDefIndex: 90161
	{
		// Nested types
		internal class PreserveAttribute : Attribute // TypeDefIndex: 90160
		{
			// Constructors
			public PreserveAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Methods
		[Preserve]
		public static unsafe void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment); // 0x00000001865B1D40-0x00000001865B1D90
	}
}

namespace Unity.Burst.CompilerServices
{
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class AssumeRangeAttribute : Attribute // TypeDefIndex: 90175
	{
		// Constructors
		public AssumeRangeAttribute(long min, long max); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class Hint // TypeDefIndex: 90176
	{
		// Methods
		public static bool Likely(bool condition); // 0x0000000187241400-0x0000000187241410
	}
}

namespace Unity.Burst.Intrinsics
{
	public static class Common // TypeDefIndex: 90162
	{
		// Methods
		public static ulong umul128(ulong x, ulong y, out ulong high); // 0x00000001872590A0-0x0000000187259100
	}

	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[Unity.Burst.BurstRuntime.Preserve]
	internal sealed class BurstTargetCpuAttribute : Attribute // TypeDefIndex: 90163
	{
	}

	internal class V64DebugView // TypeDefIndex: 90164
	{
	}

	internal class V128DebugView // TypeDefIndex: 90165
	{
	}

	internal class V256DebugView // TypeDefIndex: 90166
	{
	}

	[DebuggerTypeProxy(typeof(V128DebugView))]
	public struct v128 // TypeDefIndex: 90167
	{
		// Fields
		public byte Byte0; // 0x00
		public byte Byte1; // 0x01
		public byte Byte2; // 0x02
		public byte Byte3; // 0x03
		public byte Byte4; // 0x04
		public byte Byte5; // 0x05
		public byte Byte6; // 0x06
		public byte Byte7; // 0x07
		public byte Byte8; // 0x08
		public byte Byte9; // 0x09
		public byte Byte10; // 0x0A
		public byte Byte11; // 0x0B
		public byte Byte12; // 0x0C
		public byte Byte13; // 0x0D
		public byte Byte14; // 0x0E
		public byte Byte15; // 0x0F
		public sbyte SByte0; // 0x00
		public sbyte SByte1; // 0x01
		public sbyte SByte2; // 0x02
		public sbyte SByte3; // 0x03
		public sbyte SByte4; // 0x04
		public sbyte SByte5; // 0x05
		public sbyte SByte6; // 0x06
		public sbyte SByte7; // 0x07
		public sbyte SByte8; // 0x08
		public sbyte SByte9; // 0x09
		public sbyte SByte10; // 0x0A
		public sbyte SByte11; // 0x0B
		public sbyte SByte12; // 0x0C
		public sbyte SByte13; // 0x0D
		public sbyte SByte14; // 0x0E
		public sbyte SByte15; // 0x0F
		public ushort UShort0; // 0x00
		public ushort UShort1; // 0x02
		public ushort UShort2; // 0x04
		public ushort UShort3; // 0x06
		public ushort UShort4; // 0x08
		public ushort UShort5; // 0x0A
		public ushort UShort6; // 0x0C
		public ushort UShort7; // 0x0E
		public short SShort0; // 0x00
		public short SShort1; // 0x02
		public short SShort2; // 0x04
		public short SShort3; // 0x06
		public short SShort4; // 0x08
		public short SShort5; // 0x0A
		public short SShort6; // 0x0C
		public short SShort7; // 0x0E
		public uint UInt0; // 0x00
		public uint UInt1; // 0x04
		public uint UInt2; // 0x08
		public uint UInt3; // 0x0C
		public int SInt0; // 0x00
		public int SInt1; // 0x04
		public int SInt2; // 0x08
		public int SInt3; // 0x0C
		public ulong ULong0; // 0x00
		public ulong ULong1; // 0x08
		public long SLong0; // 0x00
		public long SLong1; // 0x08
		public float Float0; // 0x00
		public float Float1; // 0x04
		public float Float2; // 0x08
		public float Float3; // 0x0C
		public double Double0; // 0x00
		public double Double1; // 0x08
		public v64 Lo64; // 0x00
		public v64 Hi64; // 0x08
	}

	[DebuggerTypeProxy(typeof(V256DebugView))]
	public struct v256 // TypeDefIndex: 90168
	{
		// Fields
		public byte Byte0; // 0x00
		public byte Byte1; // 0x01
		public byte Byte2; // 0x02
		public byte Byte3; // 0x03
		public byte Byte4; // 0x04
		public byte Byte5; // 0x05
		public byte Byte6; // 0x06
		public byte Byte7; // 0x07
		public byte Byte8; // 0x08
		public byte Byte9; // 0x09
		public byte Byte10; // 0x0A
		public byte Byte11; // 0x0B
		public byte Byte12; // 0x0C
		public byte Byte13; // 0x0D
		public byte Byte14; // 0x0E
		public byte Byte15; // 0x0F
		public byte Byte16; // 0x10
		public byte Byte17; // 0x11
		public byte Byte18; // 0x12
		public byte Byte19; // 0x13
		public byte Byte20; // 0x14
		public byte Byte21; // 0x15
		public byte Byte22; // 0x16
		public byte Byte23; // 0x17
		public byte Byte24; // 0x18
		public byte Byte25; // 0x19
		public byte Byte26; // 0x1A
		public byte Byte27; // 0x1B
		public byte Byte28; // 0x1C
		public byte Byte29; // 0x1D
		public byte Byte30; // 0x1E
		public byte Byte31; // 0x1F
		public sbyte SByte0; // 0x00
		public sbyte SByte1; // 0x01
		public sbyte SByte2; // 0x02
		public sbyte SByte3; // 0x03
		public sbyte SByte4; // 0x04
		public sbyte SByte5; // 0x05
		public sbyte SByte6; // 0x06
		public sbyte SByte7; // 0x07
		public sbyte SByte8; // 0x08
		public sbyte SByte9; // 0x09
		public sbyte SByte10; // 0x0A
		public sbyte SByte11; // 0x0B
		public sbyte SByte12; // 0x0C
		public sbyte SByte13; // 0x0D
		public sbyte SByte14; // 0x0E
		public sbyte SByte15; // 0x0F
		public sbyte SByte16; // 0x10
		public sbyte SByte17; // 0x11
		public sbyte SByte18; // 0x12
		public sbyte SByte19; // 0x13
		public sbyte SByte20; // 0x14
		public sbyte SByte21; // 0x15
		public sbyte SByte22; // 0x16
		public sbyte SByte23; // 0x17
		public sbyte SByte24; // 0x18
		public sbyte SByte25; // 0x19
		public sbyte SByte26; // 0x1A
		public sbyte SByte27; // 0x1B
		public sbyte SByte28; // 0x1C
		public sbyte SByte29; // 0x1D
		public sbyte SByte30; // 0x1E
		public sbyte SByte31; // 0x1F
		public ushort UShort0; // 0x00
		public ushort UShort1; // 0x02
		public ushort UShort2; // 0x04
		public ushort UShort3; // 0x06
		public ushort UShort4; // 0x08
		public ushort UShort5; // 0x0A
		public ushort UShort6; // 0x0C
		public ushort UShort7; // 0x0E
		public ushort UShort8; // 0x10
		public ushort UShort9; // 0x12
		public ushort UShort10; // 0x14
		public ushort UShort11; // 0x16
		public ushort UShort12; // 0x18
		public ushort UShort13; // 0x1A
		public ushort UShort14; // 0x1C
		public ushort UShort15; // 0x1E
		public short SShort0; // 0x00
		public short SShort1; // 0x02
		public short SShort2; // 0x04
		public short SShort3; // 0x06
		public short SShort4; // 0x08
		public short SShort5; // 0x0A
		public short SShort6; // 0x0C
		public short SShort7; // 0x0E
		public short SShort8; // 0x10
		public short SShort9; // 0x12
		public short SShort10; // 0x14
		public short SShort11; // 0x16
		public short SShort12; // 0x18
		public short SShort13; // 0x1A
		public short SShort14; // 0x1C
		public short SShort15; // 0x1E
		public uint UInt0; // 0x00
		public uint UInt1; // 0x04
		public uint UInt2; // 0x08
		public uint UInt3; // 0x0C
		public uint UInt4; // 0x10
		public uint UInt5; // 0x14
		public uint UInt6; // 0x18
		public uint UInt7; // 0x1C
		public int SInt0; // 0x00
		public int SInt1; // 0x04
		public int SInt2; // 0x08
		public int SInt3; // 0x0C
		public int SInt4; // 0x10
		public int SInt5; // 0x14
		public int SInt6; // 0x18
		public int SInt7; // 0x1C
		public ulong ULong0; // 0x00
		public ulong ULong1; // 0x08
		public ulong ULong2; // 0x10
		public ulong ULong3; // 0x18
		public long SLong0; // 0x00
		public long SLong1; // 0x08
		public long SLong2; // 0x10
		public long SLong3; // 0x18
		public float Float0; // 0x00
		public float Float1; // 0x04
		public float Float2; // 0x08
		public float Float3; // 0x0C
		public float Float4; // 0x10
		public float Float5; // 0x14
		public float Float6; // 0x18
		public float Float7; // 0x1C
		public double Double0; // 0x00
		public double Double1; // 0x08
		public double Double2; // 0x10
		public double Double3; // 0x18
		public v128 Lo128; // 0x00
		public v128 Hi128; // 0x10
	
		// Constructors
		public v256(int v); // 0x0000000187259280-0x00000001872592A0
		public v256(v128 lo, v128 hi); // 0x0000000187239550-0x0000000187239560
	}

	[DebuggerTypeProxy(typeof(V64DebugView))]
	public struct v64 // TypeDefIndex: 90169
	{
		// Fields
		public byte Byte0; // 0x00
		public byte Byte1; // 0x01
		public byte Byte2; // 0x02
		public byte Byte3; // 0x03
		public byte Byte4; // 0x04
		public byte Byte5; // 0x05
		public byte Byte6; // 0x06
		public byte Byte7; // 0x07
		public sbyte SByte0; // 0x00
		public sbyte SByte1; // 0x01
		public sbyte SByte2; // 0x02
		public sbyte SByte3; // 0x03
		public sbyte SByte4; // 0x04
		public sbyte SByte5; // 0x05
		public sbyte SByte6; // 0x06
		public sbyte SByte7; // 0x07
		public ushort UShort0; // 0x00
		public ushort UShort1; // 0x02
		public ushort UShort2; // 0x04
		public ushort UShort3; // 0x06
		public short SShort0; // 0x00
		public short SShort1; // 0x02
		public short SShort2; // 0x04
		public short SShort3; // 0x06
		public uint UInt0; // 0x00
		public uint UInt1; // 0x04
		public int SInt0; // 0x00
		public int SInt1; // 0x04
		public ulong ULong0; // 0x00
		public long SLong0; // 0x00
		public float Float0; // 0x00
		public float Float1; // 0x04
		public double Double0; // 0x00
	}

	[BurstCompile]
	public static class X86 // TypeDefIndex: 90174
	{
		// Nested types
		public static class Avx // TypeDefIndex: 90170
		{
			// Methods
			[DebuggerStepThrough]
			public static unsafe v256 mm256_load_ps(void* ptr); // 0x0000000184295680-0x00000001842956A0
			[DebuggerStepThrough]
			public static unsafe void mm256_store_ps(void* ptr, v256 val); // 0x0000000187259090-0x00000001872590A0
			[DebuggerStepThrough]
			public static unsafe v256 mm256_loadu_si256(void* ptr); // 0x0000000184295680-0x00000001842956A0
			[DebuggerStepThrough]
			public static unsafe void mm256_storeu_si256(void* ptr, v256 v); // 0x0000000187259090-0x00000001872590A0
			[DebuggerStepThrough]
			public static v256 mm256_set1_epi32(int a); // 0x000000018D2A59B8-0x000000018D2A59DC
		}
	
		public static class Avx2 // TypeDefIndex: 90171
		{
			// Properties
			public static bool IsAvx2Supported { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
			// Methods
			[DebuggerStepThrough]
			public static v256 mm256_xor_si256(v256 a, v256 b); // 0x000000018D2A591C-0x000000018D2A59B8
			[DebuggerStepThrough]
			public static v256 mm256_add_epi64(v256 a, v256 b); // 0x000000018D2A5670-0x000000018D2A570C
			[DebuggerStepThrough]
			public static v256 mm256_mul_epu32(v256 a, v256 b); // 0x000000018D2A570C-0x000000018D2A57A8
			[DebuggerStepThrough]
			public static v256 mm256_slli_epi64(v256 a, int imm8); // 0x000000018D2A5824-0x000000018D2A58A0
			[DebuggerStepThrough]
			public static v256 mm256_srli_epi64(v256 a, int imm8); // 0x000000018D2A58A0-0x000000018D2A591C
			[DebuggerStepThrough]
			public static v256 mm256_shuffle_epi32(v256 a, int imm8); // 0x000000018D2A57A8-0x000000018D2A5824
		}
	
		public static class Sse // TypeDefIndex: 90172
		{
			// Methods
			public static int SHUFFLE(int d, int c, int b, int a); // 0x00000001872591F0-0x0000000187259220
		}
	
		public static class Sse2 // TypeDefIndex: 90173
		{
			// Methods
			[DebuggerStepThrough]
			public static v128 add_epi64(v128 a, v128 b); // 0x0000000187259140-0x0000000187259160
			[DebuggerStepThrough]
			public static v128 mul_epu32(v128 a, v128 b); // 0x0000000187259160-0x0000000187259180
			[DebuggerStepThrough]
			public static v128 slli_epi64(v128 a, int imm8); // 0x000000018D2A8ECC-0x000000018D2A8F64
			[DebuggerStepThrough]
			public static v128 srli_epi64(v128 a, int imm8); // 0x000000018D2A8F64-0x000000018D2A8FFC
			[DebuggerStepThrough]
			public static v128 xor_si128(v128 a, v128 b); // 0x00000001872591D0-0x00000001872591F0
			[DebuggerStepThrough]
			public static v128 shuffle_epi32(v128 a, int imm8); // 0x0000000187259180-0x00000001872591D0
		}
	}
}
