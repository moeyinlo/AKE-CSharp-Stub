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

// Image 88: Unity.Burst.dll - Assembly: Unity.Burst, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62813-62864
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.Burst.Benchmarks")]
[assembly: InternalsVisibleTo("Unity.Burst.Tests.UnitTests")]
[assembly: InternalsVisibleTo("Unity.Burst.Editor")]
[assembly: InternalsVisibleTo("Unity.Burst.CodeGen")]
[assembly: InternalsVisibleTo("Unity.Burst.Editor.Tests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 62864
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_256 _07DB995E8ED2CFB0AB71EBA69F3A3EC07D5C6AC10C0C64F33E94ED2949B348AA; // 0x00 // Static value (base64): AAABAQICAgIDAwMDAwMDAwQEBAQEBAQEBAQEBAQEBAQFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBw== - Metadata: 0x023521AC
	internal static readonly __StaticArrayInitTypeSize_32 C69994AC61B52FBCEA582D6CCCD595C12E00BDB18F0C6F593FB6B393CAEDB08C; // 0x100 // Static value (base64): AQAAAAoAAABkAAAA6AMAABAnAACghgEAQEIPAICWmAA= - Metadata: 0x023522B4
	internal static readonly long D0067CAD9A63E0813759A2BB841051CA73570C0DA2E08E840A8EB45DB6A7A010; // 0x120 // Static value (base64): SW5maW5pdHk= - Metadata: 0x023522DC
	internal static readonly __StaticArrayInitTypeSize_3 D5B592C05DC25B5032553F1B27F4139BE95E881F73DB33B02B05AB20C3F9981E; // 0x128 // Static value (base64): TmFO - Metadata: 0x023522EC

	// Nested types
	private struct __StaticArrayInitTypeSize_3 // TypeDefIndex: 62861
	{
	}

	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 62862
	{
	}

	private struct __StaticArrayInitTypeSize_256 // TypeDefIndex: 62863
	{
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 62814
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 62815
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Unity.Burst
{
	public enum OptimizeFor // TypeDefIndex: 62816
	{
		Default = 0,
		Performance = 1,
		Size = 2,
		FastCompilation = 3,
		Balanced = 4
	}

	public enum FloatMode // TypeDefIndex: 62817
	{
		Default = 0,
		Strict = 1,
		Deterministic = 2,
		Fast = 3
	}

	public enum FloatPrecision // TypeDefIndex: 62818
	{
		Standard = 0,
		High = 1,
		Medium = 2,
		Low = 3
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
	public class BurstCompileAttribute : Attribute // TypeDefIndex: 62819
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
		public FloatMode FloatMode { [CompilerGenerated] set; } // 0x00000001814F51F0-0x00000001814F5220
		public FloatPrecision FloatPrecision { [CompilerGenerated] set; } // 0x0000000184D8F540-0x0000000184D8F550
		public bool CompileSynchronously { set; } // 0x0000000183F26250-0x0000000183F262A0
		public bool DisableDirectCall { set; } // 0x000000018B15C1EC-0x000000018B15C238
		public OptimizeFor OptimizeFor { [CompilerGenerated] set; } // 0x0000000184D86320-0x0000000184D86330
		internal string[] Options { [CompilerGenerated] set; } // 0x0000000185390F40-0x0000000185390F50
	
		// Constructors
		public BurstCompileAttribute(); // 0x00000001841E1670-0x00000001841E1680
		public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode); // 0x0000000184D85930-0x0000000184D85940
	}

	public static class BurstCompiler // TypeDefIndex: 62825
	{
		// Fields
		internal static bool _IsEnabled; // 0x00
		public static readonly BurstCompilerOptions Options; // 0x08
		internal static Action OnCompileILPPMethod2; // 0x10
		private static readonly MethodInfo DummyMethodInfo; // 0x18
	
		// Properties
		public static bool IsEnabled { get; } // 0x000000018307B8D0-0x000000018307B940 
	
		// Nested types
		[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
		internal class StaticTypeReinitAttribute : Attribute // TypeDefIndex: 62820
		{
			// Fields
			public readonly System.Type reinitType; // 0x10
	
			// Constructors
			public StaticTypeReinitAttribute(System.Type toReinit); // 0x00000001853908C0-0x00000001853908D0
		}
	
		[BurstCompile]
		internal static class BurstCompilerHelper // TypeDefIndex: 62822
		{
			// Fields
			private static readonly IsBurstEnabledDelegate IsBurstEnabledImpl; // 0x00
			public static readonly bool IsBurstGenerated; // 0x08
	
			// Nested types
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			private delegate bool IsBurstEnabledDelegate(); // TypeDefIndex: 62821; 0x0000000187378308-0x0000000187378318
	
			// Constructors
			static BurstCompilerHelper(); // 0x0000000183FAEB30-0x0000000183FAEBF0
	
			// Methods
			[BurstCompile]
			[AOT.MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
			private static bool IsBurstEnabled(); // 0x000000018B15C238-0x000000018B15C274
			[BurstDiscard]
			private static void DiscardedMethod(ref bool value); // 0x0000000184D87170-0x0000000184D87180
			private static bool IsCompiledByBurst(Delegate del); // 0x0000000183FB0A20-0x0000000183FB0A80
		}
	
		private class FakeDelegate // TypeDefIndex: 62823
		{
			// Fields
			[CompilerGenerated]
			private readonly MethodInfo _Method_k__BackingField; // 0x10
	
			// Properties
			[UnityEngine.Scripting.Preserve]
			public MethodInfo Method { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
			// Constructors
			public FakeDelegate(MethodInfo method); // 0x00000001853908C0-0x00000001853908D0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62824
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Attribute, bool> __9__22_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D45010-0x0000000184D45070
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Compile_b__22_0(Attribute s); // 0x0000000184843A60-0x0000000184843AD0
		}
	
		// Constructors
		static BurstCompiler(); // 0x000000018495EE80-0x000000018495EFA0
	
		// Methods
		public static IntPtr CompileILPPMethod2(RuntimeMethodHandle burstMethodHandle); // 0x0000000183FB0BC0-0x0000000183FB0CA0
		public static unsafe void* GetILPPMethodFunctionPointer2(IntPtr ilppMethod, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle); // 0x000000018474F6F0-0x000000018474F720
		public static FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod)
			where T : class;
		private static unsafe void* Compile(object delegateObj, bool isFunctionPointer); // 0x0000000183FB0AF0-0x0000000183FB0BC0
		private static unsafe void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing); // 0x0000000183FB0D30-0x0000000183FB0FD0
		private static void DummyMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public sealed class BurstCompilerOptions // TypeDefIndex: 62826
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
		private bool IsGlobal { [CompilerGenerated] get; } // 0x0000000184D88390-0x0000000184D883A0 
		public bool EnableBurstCompilation { get; set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x000000018495EFE0-0x000000018495F0D0
		public bool EnableBurstSafetyChecks { set; } // 0x000000018495F0D0-0x000000018495F0F0
		internal Action OptionsChanged { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
	
		// Constructors
		internal BurstCompilerOptions(bool isGlobal); // 0x000000018495EFA0-0x000000018495EFE0
		static BurstCompilerOptions(); // 0x00000001841A6310-0x00000001841A6400
	
		// Methods
		private static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute); // 0x0000000183FB10C0-0x0000000183FB1140
		private static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo); // 0x0000000183FB1140-0x0000000183FB13D0
		internal static bool HasBurstCompileAttribute(MemberInfo member); // 0x0000000183FB1060-0x0000000183FB10C0
		private void OnOptionsChanged(); // 0x000000018495F0F0-0x000000018495F110
		private void MaybeTriggerRecompilation(); // 0x00000001841E1670-0x00000001841E1680
		private static bool CheckIsSecondaryUnityProcess(); // 0x00000001812081B0-0x0000000181208610
	}

	public static class BurstRuntime // TypeDefIndex: 62829
	{
		// Nested types
		private struct HashCode64<T> // TypeDefIndex: 62827
		{
			// Fields
			public static readonly long Value;
	
			// Constructors
			static HashCode64();
		}
	
		internal class PreserveAttribute : Attribute // TypeDefIndex: 62828
		{
			// Constructors
			public PreserveAttribute(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Methods
		public static long GetHashCode64<T>();
		internal static long HashStringWithFNV1A64(string text); // 0x0000000183B99BA0-0x0000000183B99C20
		[Preserve]
		internal static void PreventRequiredAttributeStrip(); // 0x000000018B15C298-0x000000018B15C374
		[Preserve]
		internal static unsafe void Log(byte* message, int logType, byte* fileName, int lineNumber); // 0x000000018B15C274-0x000000018B15C298
	}

	internal static class BurstString // TypeDefIndex: 62840
	{
		// Fields
		private static readonly char[] SplitByColon; // 0x00
		private static readonly byte[] logTable; // 0x08
		private static readonly uint[] g_PowerOf10_U32; // 0x10
		private static readonly byte[] InfinityString; // 0x18
		private static readonly byte[] NanString; // 0x20
	
		// Nested types
		internal class PreserveAttribute : Attribute // TypeDefIndex: 62830
		{
			// Constructors
			public PreserveAttribute(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private enum NumberBufferKind // TypeDefIndex: 62831
		{
			Integer = 0,
			Float = 1
		}
	
		private struct NumberBuffer // TypeDefIndex: 62832
		{
			// Fields
			private readonly unsafe byte* _buffer; // 0x00
			public NumberBufferKind Kind; // 0x08
			public int DigitsCount; // 0x0C
			public int Scale; // 0x10
			public readonly bool IsNegative; // 0x14
	
			// Constructors
			public unsafe NumberBuffer(NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative); // 0x0000000184DAB260-0x0000000184DAB280
	
			// Methods
			public unsafe byte* GetDigitsPointer(); // 0x0000000182B76770-0x0000000182B76780
		}
	
		public enum NumberFormatKind : byte // TypeDefIndex: 62833
		{
			General = 0,
			Decimal = 1,
			DecimalForceSigned = 2,
			Hexadecimal = 3
		}
	
		public struct FormatOptions // TypeDefIndex: 62834
		{
			// Fields
			public NumberFormatKind Kind; // 0x00
			public sbyte AlignAndSize; // 0x01
			public byte Specifier; // 0x02
			public bool Lowercase; // 0x03
	
			// Properties
			public bool Uppercase { get; } // 0x000000018AE38EF0-0x000000018AE38EF8 
	
			// Constructors
			public FormatOptions(NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase); // 0x0000000184DAB240-0x0000000184DAB260
	
			// Methods
			public int GetBase(); // 0x000000018B15F580-0x000000018B15F594
			public override string ToString(); // 0x000000018B15F594-0x000000018B15F7D0
		}
	
		public struct tBigInt // TypeDefIndex: 62836
		{
			// Fields
			public int m_length; // 0x00
			public unsafe fixed /* 0x00000000-0x00000000 */ uint m_blocks[0]; // 0x04
	
			// Nested types
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _m_blocks_e__FixedBuffer // TypeDefIndex: 62835
			{
				// Fields
				public uint FixedElementField; // 0x00
			}
	
			// Methods
			public int GetLength(); // 0x0000000182B77620-0x0000000182B77630
			public uint GetBlock(int idx); // 0x0000000184DAB360-0x0000000184DAB370
			public bool IsZero(); // 0x000000018426F6A0-0x000000018426F6B0
			public void SetU64(ulong val); // 0x000000018B15F91C-0x000000018B15F94C
			public void SetU32(uint val); // 0x000000018B15F908-0x000000018B15F91C
		}
	
		public enum CutoffMode // TypeDefIndex: 62837
		{
			Unique = 0,
			TotalLength = 1,
			FractionLength = 2
		}
	
		public struct tFloatUnion32 // TypeDefIndex: 62838
		{
			// Fields
			public float m_floatingPoint; // 0x00
			public uint m_integer; // 0x00
	
			// Methods
			public bool IsNegative(); // 0x000000018A879674-0x000000018A87967C
			public uint GetExponent(); // 0x0000000184DAB370-0x0000000184DAB380
			public uint GetMantissa(); // 0x0000000184DAB380-0x0000000184DAB390
		}
	
		public struct tFloatUnion64 // TypeDefIndex: 62839
		{
			// Fields
			public double m_floatingPoint; // 0x00
			public ulong m_integer; // 0x00
	
			// Methods
			public bool IsNegative(); // 0x000000018B15F94C-0x000000018B15F960
			public uint GetExponent(); // 0x0000000184DAB390-0x0000000184DAB3A0
			public ulong GetMantissa(); // 0x0000000184DAB3A0-0x0000000184DAB3C0
		}
	
		// Constructors
		static BurstString(); // 0x000000018B15F1B0-0x000000018B15F3BC
	
		// Methods
		[Preserve]
		public static unsafe void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength); // 0x000000018B15D844-0x000000018B15D868
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw); // 0x000000018B15E9CC-0x000000018B15EAA8
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw); // 0x000000018B15ED80-0x000000018B15EDFC
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw); // 0x000000018B15EB24-0x000000018B15EBA0
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw); // 0x000000018B15EBA0-0x000000018B15ECEC
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw); // 0x000000018B15E54C-0x000000018B15E708
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw); // 0x000000018B15EDFC-0x000000018B15EE7C
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw); // 0x000000018B15E784-0x000000018B15E804
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw); // 0x000000018B15EAA8-0x000000018B15EB24
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw); // 0x000000018B15E708-0x000000018B15E784
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw); // 0x000000018B15E804-0x000000018B15E89C
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw); // 0x000000018B15E934-0x000000018B15E9CC
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw); // 0x000000018B15E89C-0x000000018B15E934
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw); // 0x000000018B15ECEC-0x000000018B15ED80
		private static unsafe void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, FormatOptions options); // 0x000000018B15D6D4-0x000000018B15D844
		private static int GetLengthIntegerToString(long value, int basis, int zeroPadding); // 0x000000018B15EF50-0x000000018B15EF7C
		private static unsafe void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, FormatOptions options); // 0x000000018B15D53C-0x000000018B15D6D4
		private static unsafe void FormatNumber(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, FormatOptions options); // 0x000000018B15E34C-0x000000018B15E54C
		private static unsafe void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int zeroPadding, bool outputPositiveSign); // 0x000000018B15DF98-0x000000018B15E038
		private static byte ValueToIntegerChar(int value, bool uppercase); // 0x000000018B15F188-0x000000018B15F1B0
		private static unsafe bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length); // 0x000000018B15C3A4-0x000000018B15C42C
		private static unsafe bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length); // 0x000000018B15C374-0x000000018B15C3A4
		private static int GetLengthForFormatGeneral(ref NumberBuffer number, int nMaxDigits); // 0x000000018B15EE7C-0x000000018B15EF50
		private static unsafe void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, byte expChar); // 0x000000018B15E038-0x000000018B15E1B0
		private static void RoundNumber(ref NumberBuffer number, int pos, bool isCorrectlyRounded); // 0x000000018B15F070-0x000000018B15F164
		private static unsafe bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded); // 0x000000018B15F164-0x000000018B15F188
		private static uint LogBase2(uint val); // 0x000000018B15EF7C-0x000000018B15F070
		private static int BigInt_Compare([IsReadOnly] in tBigInt lhs, [IsReadOnly] in tBigInt rhs); // 0x000000018B15C54C-0x000000018B15C5A0
		private static void BigInt_Add(out tBigInt pResult, [IsReadOnly] in tBigInt lhs, [IsReadOnly] in tBigInt rhs); // 0x000000018B15C4D8-0x000000018B15C54C
		private static void BigInt_Add_internal(out tBigInt pResult, [IsReadOnly] in tBigInt pLarge, [IsReadOnly] in tBigInt pSmall); // 0x000000018B15C42C-0x000000018B15C4D8
		private static void BigInt_Multiply(out tBigInt pResult, [IsReadOnly] in tBigInt lhs, [IsReadOnly] in tBigInt rhs); // 0x000000018B15CBEC-0x000000018B15CC60
		private static void BigInt_Multiply_internal(out tBigInt pResult, [IsReadOnly] in tBigInt pLarge, [IsReadOnly] in tBigInt pSmall); // 0x000000018B15CAAC-0x000000018B15CB84
		private static void BigInt_Multiply(out tBigInt pResult, [IsReadOnly] in tBigInt lhs, uint rhs); // 0x000000018B15CB84-0x000000018B15CBEC
		private static void BigInt_Multiply2(out tBigInt pResult, [IsReadOnly] in tBigInt input); // 0x000000018B15C744-0x000000018B15C79C
		private static void BigInt_Multiply2(ref tBigInt pResult); // 0x000000018B15C79C-0x000000018B15C7D8
		private static void BigInt_Multiply10(ref tBigInt pResult); // 0x000000018B15C708-0x000000018B15C744
		private static tBigInt g_PowerOf10_Big(int i); // 0x000000018B15F3BC-0x000000018B15F580
		private static void BigInt_Pow10(out tBigInt pResult, uint exponent); // 0x000000018B15CC60-0x000000018B15CECC
		private static void BigInt_MultiplyPow10(out tBigInt pResult, [IsReadOnly] in tBigInt input, uint exponent); // 0x000000018B15C7D8-0x000000018B15CAAC
		private static void BigInt_Pow2(out tBigInt pResult, uint exponent); // 0x000000018B15CECC-0x000000018B15CF14
		private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref tBigInt pDividend, [IsReadOnly] in tBigInt divisor); // 0x000000018B15C5A0-0x000000018B15C708
		private static void BigInt_ShiftLeft(ref tBigInt pResult, uint shift); // 0x000000018B15CF14-0x000000018B15D060
		private static unsafe uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, out int pOutExponent); // 0x000000018B15D868-0x000000018B15DF98
		private static unsafe void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, FormatOptions formatOptions); // 0x000000018B15E1B0-0x000000018B15E34C
		private static unsafe void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, FormatOptions formatOptions); // 0x000000018B15D2E0-0x000000018B15D53C
		private static unsafe void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, FormatOptions formatOptions); // 0x000000018B15D060-0x000000018B15D2E0
	}

	[IsReadOnly]
	public struct FunctionPointer<T> // TypeDefIndex: 62841
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
	public class NoAliasAttribute : Attribute // TypeDefIndex: 62842
	{
		// Constructors
		public NoAliasAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[IsReadOnly]
	public struct SharedStatic<T> // TypeDefIndex: 62843
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
		public static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0 /* Metadata: 0x023521A5 */);
		public static SharedStatic<T> GetOrCreate<TContext, TSubContext>(uint alignment = 0 /* Metadata: 0x023521A6 */);
		public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode);
	}

	internal static class SharedStatic // TypeDefIndex: 62845
	{
		// Nested types
		internal class PreserveAttribute : Attribute // TypeDefIndex: 62844
		{
			// Constructors
			public PreserveAttribute(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Methods
		[Preserve]
		public static unsafe void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment); // 0x00000001842094B0-0x0000000184209500
	}
}

namespace Unity.Burst.CompilerServices
{
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class AssumeRangeAttribute : Attribute // TypeDefIndex: 62859
	{
		// Constructors
		public AssumeRangeAttribute(long min, long max); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class Hint // TypeDefIndex: 62860
	{
		// Methods
		public static bool Likely(bool condition); // 0x0000000184D94BA0-0x0000000184D94BB0
	}
}

namespace Unity.Burst.Intrinsics
{
	public static class Common // TypeDefIndex: 62846
	{
		// Methods
		public static ulong umul128(ulong x, ulong y, out ulong high); // 0x0000000184DAB1D0-0x0000000184DAB240
	}

	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[Unity.Burst.BurstRuntime.Preserve]
	internal sealed class BurstTargetCpuAttribute : Attribute // TypeDefIndex: 62847
	{
	}

	internal class V64DebugView // TypeDefIndex: 62848
	{
	}

	internal class V128DebugView // TypeDefIndex: 62849
	{
	}

	internal class V256DebugView // TypeDefIndex: 62850
	{
	}

	[DebuggerTypeProxy(typeof(V128DebugView))]
	public struct v128 // TypeDefIndex: 62851
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
	public struct v256 // TypeDefIndex: 62852
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
		public v256(int v); // 0x0000000184DAB3C0-0x0000000184DAB3E0
		public v256(v128 lo, v128 hi); // 0x0000000184D8C810-0x0000000184D8C820
	}

	[DebuggerTypeProxy(typeof(V64DebugView))]
	public struct v64 // TypeDefIndex: 62853
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
	public static class X86 // TypeDefIndex: 62858
	{
		// Nested types
		public static class Avx // TypeDefIndex: 62854
		{
			// Methods
			[DebuggerStepThrough]
			public static unsafe v256 mm256_load_ps(void* ptr); // 0x0000000184D91D40-0x0000000184D91D60
			[DebuggerStepThrough]
			public static unsafe void mm256_store_ps(void* ptr, v256 val); // 0x0000000184DAB1C0-0x0000000184DAB1D0
			[DebuggerStepThrough]
			public static unsafe v256 mm256_loadu_si256(void* ptr); // 0x0000000184D91D40-0x0000000184D91D60
			[DebuggerStepThrough]
			public static unsafe void mm256_storeu_si256(void* ptr, v256 v); // 0x0000000184DAB1C0-0x0000000184DAB1D0
			[DebuggerStepThrough]
			public static v256 mm256_set1_epi32(int a); // 0x000000018B15C1C8-0x000000018B15C1EC
		}
	
		public static class Avx2 // TypeDefIndex: 62855
		{
			// Properties
			public static bool IsAvx2Supported { get; } // 0x00000001812081B0-0x0000000181208610 
	
			// Methods
			[DebuggerStepThrough]
			public static v256 mm256_xor_si256(v256 a, v256 b); // 0x000000018B15C12C-0x000000018B15C1C8
			[DebuggerStepThrough]
			public static v256 mm256_add_epi64(v256 a, v256 b); // 0x000000018B15BE80-0x000000018B15BF1C
			[DebuggerStepThrough]
			public static v256 mm256_mul_epu32(v256 a, v256 b); // 0x000000018B15BF1C-0x000000018B15BFB8
			[DebuggerStepThrough]
			public static v256 mm256_slli_epi64(v256 a, int imm8); // 0x000000018B15C034-0x000000018B15C0B0
			[DebuggerStepThrough]
			public static v256 mm256_srli_epi64(v256 a, int imm8); // 0x000000018B15C0B0-0x000000018B15C12C
			[DebuggerStepThrough]
			public static v256 mm256_shuffle_epi32(v256 a, int imm8); // 0x000000018B15BFB8-0x000000018B15C034
		}
	
		public static class Sse // TypeDefIndex: 62856
		{
			// Methods
			public static int SHUFFLE(int d, int c, int b, int a); // 0x0000000184DAB330-0x0000000184DAB360
		}
	
		public static class Sse2 // TypeDefIndex: 62857
		{
			// Methods
			[DebuggerStepThrough]
			public static v128 add_epi64(v128 a, v128 b); // 0x0000000184DAB280-0x0000000184DAB2A0
			[DebuggerStepThrough]
			public static v128 mul_epu32(v128 a, v128 b); // 0x0000000184DAB2A0-0x0000000184DAB2C0
			[DebuggerStepThrough]
			public static v128 slli_epi64(v128 a, int imm8); // 0x000000018B15F7D0-0x000000018B15F86C
			[DebuggerStepThrough]
			public static v128 srli_epi64(v128 a, int imm8); // 0x000000018B15F86C-0x000000018B15F908
			[DebuggerStepThrough]
			public static v128 xor_si128(v128 a, v128 b); // 0x0000000184DAB310-0x0000000184DAB330
			[DebuggerStepThrough]
			public static v128 shuffle_epi32(v128 a, int imm8); // 0x0000000184DAB2C0-0x0000000184DAB310
		}
	}
}
