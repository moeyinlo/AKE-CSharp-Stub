/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;

// Image 85: Unity.Burst.dll - Assembly: Unity.Burst, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60198-60249

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 60249
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_256 _07DB995E8ED2CFB0AB71EBA69F3A3EC07D5C6AC10C0C64F33E94ED2949B348AA; // 0x00 // Static value (base64): AAABAQICAgIDAwMDAwMDAwQEBAQEBAQEBAQEBAQEBAQFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYGBgYHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBwcHBw== - Metadata: 0x0208265C
	internal static readonly __StaticArrayInitTypeSize_32 C69994AC61B52FBCEA582D6CCCD595C12E00BDB18F0C6F593FB6B393CAEDB08C; // 0x100 // Static value (base64): AQAAAAoAAABkAAAA6AMAABAnAACghgEAQEIPAICWmAA= - Metadata: 0x02082764
	internal static readonly long D0067CAD9A63E0813759A2BB841051CA73570C0DA2E08E840A8EB45DB6A7A010; // 0x120 // Static value (base64): SW5maW5pdHk= - Metadata: 0x0208278C
	internal static readonly __StaticArrayInitTypeSize_3 D5B592C05DC25B5032553F1B27F4139BE95E881F73DB33B02B05AB20C3F9981E; // 0x128 // Static value (base64): TmFO - Metadata: 0x0208279C

	// Nested types
	private struct __StaticArrayInitTypeSize_3 // TypeDefIndex: 60246
	{
	}

	private struct __StaticArrayInitTypeSize_32 // TypeDefIndex: 60247
	{
	}

	private struct __StaticArrayInitTypeSize_256 // TypeDefIndex: 60248
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60199
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 60200
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.Burst
{
	public enum OptimizeFor // TypeDefIndex: 60201
	{
		Default = 0,
		Performance = 1,
		Size = 2,
		FastCompilation = 3,
		Balanced = 4
	}

	public enum FloatMode // TypeDefIndex: 60202
	{
		Default = 0,
		Strict = 1,
		Deterministic = 2,
		Fast = 3
	}

	public enum FloatPrecision // TypeDefIndex: 60203
	{
		Standard = 0,
		High = 1,
		Medium = 2,
		Low = 3
	}

	public class BurstCompileAttribute : Attribute // TypeDefIndex: 60204
	{
		// Fields
		private FloatMode _FloatMode_k__BackingField; // 0x10
		private FloatPrecision _FloatPrecision_k__BackingField; // 0x14
		internal bool? _compileSynchronously; // 0x18
		internal bool? _disableDirectCall; // 0x1A
		private OptimizeFor _OptimizeFor_k__BackingField; // 0x1C
		private string[] _Options_k__BackingField; // 0x20
	
		// Properties
		public FloatMode FloatMode { get; set; } // 0x0000000181378230-0x0000000181378240
		public FloatPrecision FloatPrecision { get; set; } // 0x0000000185FBB0B0-0x0000000185FBB0C0
		public bool CompileSynchronously { set {} } // 0x000000018509B890-0x000000018509B8E0
		public bool DisableDirectCall { set {} } // 0x000000018BC79380-0x000000018BC793CC
		public OptimizeFor OptimizeFor { get; set; } // 0x00000001813AE9D0-0x00000001813AE9E0
		internal string[] Options { get; set; } // 0x000000018646EE40-0x000000018646EE50
	
		// Constructors
		public BurstCompileAttribute() {} // 0x0000000185492010-0x0000000185492020
		public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode) {} // 0x0000000185FD7180-0x0000000185FD7190
	}

	public static class BurstCompiler // TypeDefIndex: 60210
	{
		// Fields
		internal static bool _IsEnabled; // 0x00
		public static readonly BurstCompilerOptions Options; // 0x08
		internal static Action OnCompileILPPMethod2; // 0x10
		private static readonly MethodInfo DummyMethodInfo; // 0x18
	
		// Properties
		public static bool IsEnabled { get; } // 0x0000000185C24D00-0x0000000185C24DC0 
	
		// Nested types
		internal class StaticTypeReinitAttribute : Attribute // TypeDefIndex: 60205
		{
			// Fields
			public readonly System.Type reinitType; // 0x10
	
			// Constructors
			public StaticTypeReinitAttribute() {} // Dummy constructor
			public StaticTypeReinitAttribute(System.Type toReinit) {} // 0x00000001840C7590-0x00000001840C7620
		}
	
		internal static class BurstCompilerHelper // TypeDefIndex: 60207
		{
			// Fields
			private static readonly IsBurstEnabledDelegate IsBurstEnabledImpl; // 0x00
			public static readonly bool IsBurstGenerated; // 0x08
	
			// Nested types
			private delegate bool IsBurstEnabledDelegate(); // TypeDefIndex: 60206; 0x0000000185958960-0x0000000185958990
	
			// Constructors
			static BurstCompilerHelper() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			private static bool IsBurstEnabled() => default;
			private static void DiscardedMethod(ref bool value) {} // 0x00000001859A7970-0x00000001859A7A40
			private static bool IsCompiledByBurst(Delegate del) => default; // 0x000000018439E5A0-0x000000018439E8F0
		}
	
		private class FakeDelegate // TypeDefIndex: 60208
		{
			// Fields
			private readonly MethodInfo _Method_k__BackingField; // 0x10
	
			// Properties
			public MethodInfo Method { get; } // 0x0000000184096E30-0x0000000184096EF0 
	
			// Constructors
			public FakeDelegate() {} // Dummy constructor
			public FakeDelegate(MethodInfo method) {} // 0x0000000185B3F410-0x0000000185B3F530
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 60209
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Attribute, bool> __9__22_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BC793CC-0x000000018BC79408
			public __c() {} // 0x0000000185FB0F50-0x0000000185FB0F60
	
			// Methods
			internal bool _Compile_b__22_0(Attribute s) => default; // 0x0000000185C24DC0-0x0000000185C24E20
		}
	
		// Constructors
		static BurstCompiler() {} // 0x0000000185BA59D0-0x0000000185BA5A40
	
		// Methods
		public static IntPtr CompileILPPMethod2(RuntimeMethodHandle burstMethodHandle) => default; // 0x0000000185C24E20-0x0000000185C24EB0
		public static unsafe void* GetILPPMethodFunctionPointer2(IntPtr ilppMethod, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle) => default; // 0x0000000183683B30-0x0000000183683B40
		public static FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod)
			where T : class => default; // 0x0000000184096E30-0x0000000184096EF0
		private static unsafe void* Compile(object delegateObj, bool isFunctionPointer) => default; // 0x000000018346D130-0x000000018346D140
		private static unsafe void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing) => default; // 0x0000000185F71590-0x0000000185F715F0
		private static void DummyMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class BurstCompilerOptions // TypeDefIndex: 60211
	{
		// Fields
		internal static readonly bool ForceDisableBurstCompilation; // 0x00
		private static readonly bool ForceBurstCompilationSynchronously; // 0x01
		internal static readonly bool IsSecondaryUnityProcess; // 0x02
		private bool _enableBurstCompilation; // 0x10
		private bool _enableBurstSafetyChecks; // 0x11
		private readonly bool _IsGlobal_k__BackingField; // 0x12
		private Action _OptionsChanged_k__BackingField; // 0x18
	
		// Properties
		private bool IsGlobal { get; } // 0x0000000185FB22D0-0x0000000185FB22E0 
		public bool EnableBurstCompilation { get => default; set {} } // 0x0000000181C2FD60-0x0000000181C2FD70 0x0000000185B3F570-0x0000000185B3F660
		public bool EnableBurstSafetyChecks { set {} } // 0x0000000185B3F660-0x0000000185B3F680
		internal Action OptionsChanged { get; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		public BurstCompilerOptions() {} // Dummy constructor
		internal BurstCompilerOptions(bool isGlobal) {} // 0x0000000185B3F530-0x0000000185B3F570
		static BurstCompilerOptions() {} // 0x0000000183FC2210-0x0000000183FC2300
	
		// Methods
		private static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute) {
			attribute = default;
			return default;
		} // 0x000000018439EA00-0x000000018439EAA0
		private static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo) => default; // 0x000000018439EAA0-0x000000018439ED30
		internal static bool HasBurstCompileAttribute(MemberInfo member) => default; // 0x000000018439E980-0x000000018439EA00
		private void OnOptionsChanged() {} // 0x0000000185B3F680-0x0000000185B3F6A0
		private void MaybeTriggerRecompilation() {} // 0x0000000185492010-0x0000000185492020
		private static bool CheckIsSecondaryUnityProcess() => default; // 0x00000001814A81B0-0x00000001814A81C0
	}

	public static class BurstRuntime // TypeDefIndex: 60214
	{
		// Nested types
		private struct HashCode64<T> // TypeDefIndex: 60212
		{
			// Fields
			public static readonly long Value;
	
			// Constructors
			static HashCode64() {
				Value = default;
			}
		}
	
		internal class PreserveAttribute : Attribute // TypeDefIndex: 60213
		{
			// Constructors
			public PreserveAttribute() {} // 0x0000000184BD7D70-0x0000000184BD7DF0
		}
	
		// Methods
		public static long GetHashCode64<T>() => default; // 0x000000018BC7942C-0x000000018BC79508
		internal static long HashStringWithFNV1A64(string text) => default; // 0x000000018BC79408-0x000000018BC7942C
		internal static void PreventRequiredAttributeStrip() {}
		internal static unsafe void Log(byte* message, int logType, byte* fileName, int lineNumber) {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class BurstString // TypeDefIndex: 60225
	{
		// Fields
		private static readonly char[] SplitByColon; // 0x00
		private static readonly byte[] logTable; // 0x08
		private static readonly uint[] g_PowerOf10_U32; // 0x10
		private static readonly byte[] InfinityString; // 0x18
		private static readonly byte[] NanString; // 0x20
	
		// Nested types
		internal class PreserveAttribute : Attribute // TypeDefIndex: 60215
		{
			// Constructors
			public PreserveAttribute() {} // 0x000000018BC7A9D8-0x000000018BC7A9FC
		}
	
		private enum NumberBufferKind // TypeDefIndex: 60216
		{
			Integer = 0,
			Float = 1
		}
	
		private struct NumberBuffer // TypeDefIndex: 60217
		{
			// Fields
			private readonly unsafe byte* _buffer; // 0x00
			public NumberBufferKind Kind; // 0x08
			public int DigitsCount; // 0x0C
			public int Scale; // 0x10
			public readonly bool IsNegative; // 0x14
	
			// Constructors
			public unsafe NumberBuffer(NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative) {
				_buffer = default;
				Kind = default;
				DigitsCount = default;
				Scale = default;
				IsNegative = default;
			} // 0x000000018BC7BB60-0x000000018BC7BC3C
	
			// Methods
			public unsafe byte* GetDigitsPointer() => default; // 0x000000018BC7BF14-0x000000018BC7BF90
		}
	
		public enum NumberFormatKind : byte // TypeDefIndex: 60218
		{
			General = 0,
			Decimal = 1,
			DecimalForceSigned = 2,
			Hexadecimal = 3
		}
	
		public struct FormatOptions // TypeDefIndex: 60219
		{
			// Fields
			public NumberFormatKind Kind; // 0x00
			public sbyte AlignAndSize; // 0x01
			public byte Specifier; // 0x02
			public bool Lowercase; // 0x03
	
			// Properties
			public bool Uppercase { get => default; } // 0x000000018BC7BD34-0x000000018BC7BE80 
	
			// Constructors
			public FormatOptions(NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase) : this() {
				Kind = default;
				AlignAndSize = default;
				Specifier = default;
				Lowercase = default;
			} // 0x000000018BC7BCB8-0x000000018BC7BD34
	
			// Methods
			public int GetBase() => default; // 0x000000018BC7B6E0-0x000000018BC7B89C
			public override string ToString() => default; // 0x000000018BC7BF90-0x000000018BC7C010
		}
	
		public struct tBigInt // TypeDefIndex: 60221
		{
			// Fields
			public int m_length; // 0x00
			public _m_blocks_e__FixedBuffer m_blocks; // 0x04
	
			// Nested types
			public struct _m_blocks_e__FixedBuffer // TypeDefIndex: 60220
			{
				// Fields
				public uint FixedElementField; // 0x00
			}
	
			// Methods
			public int GetLength() => default; // 0x000000018BC7B918-0x000000018BC7B998
			public uint GetBlock(int idx) => default; // 0x000000018BC7BC3C-0x000000018BC7BCB8
			public bool IsZero() => default; // 0x000000018BC7B89C-0x000000018BC7B918
			public void SetU64(ulong val) {} // 0x000000018BC7B998-0x000000018BC7BA30
			public void SetU32(uint val) {} // 0x000000018BC7BAC8-0x000000018BC7BB60
		}
	
		public enum CutoffMode // TypeDefIndex: 60222
		{
			Unique = 0,
			TotalLength = 1,
			FractionLength = 2
		}
	
		public struct tFloatUnion32 // TypeDefIndex: 60223
		{
			// Fields
			public float m_floatingPoint; // 0x00
			public uint m_integer; // 0x00
	
			// Methods
			public bool IsNegative() => default; // 0x000000018BC7BA30-0x000000018BC7BAC8
			public uint GetExponent() => default; // 0x000000018BC7BE80-0x000000018BC7BF14
			public uint GetMantissa() => default; // 0x000000018BC7A868-0x000000018BC7A9D8
		}
	
		public struct tFloatUnion64 // TypeDefIndex: 60224
		{
			// Fields
			public double m_floatingPoint; // 0x00
			public ulong m_integer; // 0x00
	
			// Methods
			public bool IsNegative() => default; // 0x000000018BC7C0E4-0x000000018BC7C110
			public uint GetExponent() => default; // 0x000000018BC7A6D0-0x000000018BC7A868
			public ulong GetMantissa() => default; // 0x000000018BC7B4E0-0x000000018BC7B6E0
		}
	
		// Constructors
		static BurstString() {} // 0x0000000185FD7360-0x0000000185FD7380
	
		// Methods
		public static unsafe void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength) {} // 0x000000018BC7B12C-0x000000018BC7B1CC
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw) {} // 0x000000018BC7C31C-0x000000018BC7C344
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw) {} // 0x000000018BC79538-0x000000018BC795C0
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw) {} // 0x000000018BC79508-0x000000018BC79538
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw) {} // 0x000000018BC7C010-0x000000018BC7C0E4
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw) {} // 0x000000018BC7B1CC-0x000000018BC7B344
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw) {} // 0x000000018BC7C204-0x000000018BC7C2F8
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw) {} // 0x000000018BC7C2F8-0x000000018BC7C31C
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw) {} // 0x000000018BC7C110-0x000000018BC7C204
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw) {} // 0x000000018BC796E0-0x000000018BC79734
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw) {} // 0x000000018BC7966C-0x000000018BC796E0
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw) {} // 0x000000018BC795C0-0x000000018BC7966C
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw) {} // 0x000000018BC79D80-0x000000018BC79DF4
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw) {} // 0x000000018BC79C40-0x000000018BC79D18
		private static unsafe void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, FormatOptions options) {} // 0x000000018BC79D18-0x000000018BC79D80
		private static int GetLengthIntegerToString(long value, int basis, int zeroPadding) => default; // 0x000000018BC798D8-0x000000018BC79930
		private static unsafe void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, FormatOptions options) {} // 0x000000018BC79930-0x000000018BC7996C
		private static unsafe void FormatNumber(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, FormatOptions options) {} // 0x000000018BC7989C-0x000000018BC798D8
		private static unsafe void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int zeroPadding, bool outputPositiveSign) {} // 0x000000018BC7C550-0x000000018BC7C714
		private static byte ValueToIntegerChar(int value, bool uppercase) => default; // 0x000000018BC79DF4-0x000000018BC7A060
		private static unsafe bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length) => default; // 0x000000018BC7996C-0x000000018BC79C40
		private static unsafe bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length) => default; // 0x000000018BC7A060-0x000000018BC7A0A8
		private static int GetLengthForFormatGeneral(ref NumberBuffer number, int nMaxDigits) => default; // 0x000000018BC79734-0x000000018BC7989C
		private static unsafe void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, byte expChar) {} // 0x000000018BC7A0A8-0x000000018BC7A1F4
		private static void RoundNumber(ref NumberBuffer number, int pos, bool isCorrectlyRounded) {} // 0x000000018BC7A9FC-0x000000018BC7B12C
		private static unsafe bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded) => default; // 0x000000018BC7B344-0x000000018BC7B4E0
		private static uint LogBase2(uint val) => default; // 0x000000018BC7A474-0x000000018BC7A6D0
		private static int BigInt_Compare(in tBigInt lhs, in tBigInt rhs) => default; // 0x000000018BC7A1F4-0x000000018BC7A474
		private static void BigInt_Add(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs) {
			pResult = default;
		} // 0x000000018BC7C344-0x000000018BC7C550
		private static void BigInt_Add_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall) {
			pResult = default;
		} // 0x0000000185492010-0x0000000185492020
		private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, in tBigInt rhs) {
			pResult = default;
		} // 0x0000000185FD7220-0x0000000185FD7240
		private static void BigInt_Multiply_internal(out tBigInt pResult, in tBigInt pLarge, in tBigInt pSmall) {
			pResult = default;
		} // 0x00000001834AFB60-0x00000001834AFB70
		private static void BigInt_Multiply(out tBigInt pResult, in tBigInt lhs, uint rhs) {
			pResult = default;
		} // 0x0000000185FD7200-0x0000000185FD7220
		private static void BigInt_Multiply2(out tBigInt pResult, in tBigInt input) {
			pResult = default;
		} // 0x000000018B980158-0x000000018B980160
		private static void BigInt_Multiply2(ref tBigInt pResult) {} // 0x000000018BC7C714-0x000000018BC7C728
		private static void BigInt_Multiply10(ref tBigInt pResult) {} // 0x000000018BC7C728-0x000000018BC7C964
		private static tBigInt g_PowerOf10_Big(int i) => default; // 0x00000001818226B0-0x00000001818226C0
		private static void BigInt_Pow10(out tBigInt pResult, uint exponent) {
			pResult = default;
		} // 0x0000000185FD7320-0x0000000185FD7330
		private static void BigInt_MultiplyPow10(out tBigInt pResult, in tBigInt input, uint exponent) {
			pResult = default;
		} // 0x00000001840066E0-0x00000001840066F0
		private static void BigInt_Pow2(out tBigInt pResult, uint exponent) {
			pResult = default;
		} // 0x000000018BC7CAB0-0x000000018BC7CAE0
		private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref tBigInt pDividend, in tBigInt divisor) => default; // 0x000000018BC7CA9C-0x000000018BC7CAB0
		private static void BigInt_ShiftLeft(ref tBigInt pResult, uint shift) {} // 0x000000018B3AF13C-0x000000018B3AF144
		private static unsafe uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, out int pOutExponent) {
			pOutExponent = default;
			return default;
		} // 0x0000000185FD7330-0x0000000185FD7340
		private static unsafe void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, FormatOptions formatOptions) {} // 0x0000000185FD7340-0x0000000185FD7350
		private static unsafe void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, FormatOptions formatOptions) {} // 0x000000018BC7CAE0-0x000000018BC7CAF4
		private static unsafe void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, FormatOptions formatOptions) {} // 0x0000000185FD7350-0x0000000185FD7360
	}

	public struct FunctionPointer<T> // TypeDefIndex: 60226
	{
		// Fields
		private readonly IntPtr _ptr;
	
		// Properties
		public T Invoke { get => default; }
	
		// Constructors
		public FunctionPointer(IntPtr ptr) : this() {
			_ptr = default;
		}
	}

	public class NoAliasAttribute : Attribute // TypeDefIndex: 60227
	{
		// Constructors
		public NoAliasAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public struct SharedStatic<T> // TypeDefIndex: 60228
		where T : struct
	{
		// Fields
		private readonly unsafe void* _buffer;
	
		// Properties
		public ref T Data { get => default; }
		public unsafe void* UnsafeDataPointer { get => default; }
	
		// Constructors
		private unsafe SharedStatic(void* buffer) : this() {
			_buffer = default;
		}
	
		// Methods
		public static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0 /* Metadata: 0x02082655 */) => default;
		public static SharedStatic<T> GetOrCreate<TContext, TSubContext>(uint alignment = 0 /* Metadata: 0x02082656 */) => default;
		public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode) => default;
	}

	internal static class SharedStatic // TypeDefIndex: 60230
	{
		// Nested types
		internal class PreserveAttribute : Attribute // TypeDefIndex: 60229
		{
			// Constructors
			public PreserveAttribute() {} // 0x000000018534F7B0-0x000000018534F810
		}
	
		// Methods
		public static unsafe void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) => default; // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.Burst.CompilerServices
{
	public class AssumeRangeAttribute : Attribute // TypeDefIndex: 60244
	{
		// Constructors
		public AssumeRangeAttribute() {} // Dummy constructor
		public AssumeRangeAttribute(long min, long max) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class Hint // TypeDefIndex: 60245
	{
		// Methods
		public static bool Likely(bool condition) => default; // 0x0000000185FD0F30-0x0000000185FD0F40
	}
}

namespace Unity.Burst.Intrinsics
{
	public static class Common // TypeDefIndex: 60231
	{
		// Methods
		public static ulong umul128(ulong x, ulong y, out ulong high) {
			high = default;
			return default;
		} // 0x0000000185FD7190-0x0000000185FD7200
	}

	internal sealed class BurstTargetCpuAttribute : Attribute // TypeDefIndex: 60232
	{
		// Constructors
		public BurstTargetCpuAttribute() {} // Dummy constructor
	}

	internal class V64DebugView // TypeDefIndex: 60233
	{
		// Constructors
		public V64DebugView() {} // Dummy constructor
	}

	internal class V128DebugView // TypeDefIndex: 60234
	{
		// Constructors
		public V128DebugView() {} // Dummy constructor
	}

	internal class V256DebugView // TypeDefIndex: 60235
	{
		// Constructors
		public V256DebugView() {} // Dummy constructor
	}

	public struct v128 // TypeDefIndex: 60236
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

	public struct v256 // TypeDefIndex: 60237
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
		public v256(int v) {
			Byte0 = default;
			Byte1 = default;
			Byte2 = default;
			Byte3 = default;
			Byte4 = default;
			Byte5 = default;
			Byte6 = default;
			Byte7 = default;
			Byte8 = default;
			Byte9 = default;
			Byte10 = default;
			Byte11 = default;
			Byte12 = default;
			Byte13 = default;
			Byte14 = default;
			Byte15 = default;
			Byte16 = default;
			Byte17 = default;
			Byte18 = default;
			Byte19 = default;
			Byte20 = default;
			Byte21 = default;
			Byte22 = default;
			Byte23 = default;
			Byte24 = default;
			Byte25 = default;
			Byte26 = default;
			Byte27 = default;
			Byte28 = default;
			Byte29 = default;
			Byte30 = default;
			Byte31 = default;
			SByte0 = default;
			SByte1 = default;
			SByte2 = default;
			SByte3 = default;
			SByte4 = default;
			SByte5 = default;
			SByte6 = default;
			SByte7 = default;
			SByte8 = default;
			SByte9 = default;
			SByte10 = default;
			SByte11 = default;
			SByte12 = default;
			SByte13 = default;
			SByte14 = default;
			SByte15 = default;
			SByte16 = default;
			SByte17 = default;
			SByte18 = default;
			SByte19 = default;
			SByte20 = default;
			SByte21 = default;
			SByte22 = default;
			SByte23 = default;
			SByte24 = default;
			SByte25 = default;
			SByte26 = default;
			SByte27 = default;
			SByte28 = default;
			SByte29 = default;
			SByte30 = default;
			SByte31 = default;
			UShort0 = default;
			UShort1 = default;
			UShort2 = default;
			UShort3 = default;
			UShort4 = default;
			UShort5 = default;
			UShort6 = default;
			UShort7 = default;
			UShort8 = default;
			UShort9 = default;
			UShort10 = default;
			UShort11 = default;
			UShort12 = default;
			UShort13 = default;
			UShort14 = default;
			UShort15 = default;
			SShort0 = default;
			SShort1 = default;
			SShort2 = default;
			SShort3 = default;
			SShort4 = default;
			SShort5 = default;
			SShort6 = default;
			SShort7 = default;
			SShort8 = default;
			SShort9 = default;
			SShort10 = default;
			SShort11 = default;
			SShort12 = default;
			SShort13 = default;
			SShort14 = default;
			SShort15 = default;
			UInt0 = default;
			UInt1 = default;
			UInt2 = default;
			UInt3 = default;
			UInt4 = default;
			UInt5 = default;
			UInt6 = default;
			UInt7 = default;
			SInt0 = default;
			SInt1 = default;
			SInt2 = default;
			SInt3 = default;
			SInt4 = default;
			SInt5 = default;
			SInt6 = default;
			SInt7 = default;
			ULong0 = default;
			ULong1 = default;
			ULong2 = default;
			ULong3 = default;
			SLong0 = default;
			SLong1 = default;
			SLong2 = default;
			SLong3 = default;
			Float0 = default;
			Float1 = default;
			Float2 = default;
			Float3 = default;
			Float4 = default;
			Float5 = default;
			Float6 = default;
			Float7 = default;
			Double0 = default;
			Double1 = default;
			Double2 = default;
			Double3 = default;
			Lo128 = default;
			Hi128 = default;
		} // 0x0000000185FD7380-0x0000000185FD73A0
		public v256(v128 lo, v128 hi) {
			Byte0 = default;
			Byte1 = default;
			Byte2 = default;
			Byte3 = default;
			Byte4 = default;
			Byte5 = default;
			Byte6 = default;
			Byte7 = default;
			Byte8 = default;
			Byte9 = default;
			Byte10 = default;
			Byte11 = default;
			Byte12 = default;
			Byte13 = default;
			Byte14 = default;
			Byte15 = default;
			Byte16 = default;
			Byte17 = default;
			Byte18 = default;
			Byte19 = default;
			Byte20 = default;
			Byte21 = default;
			Byte22 = default;
			Byte23 = default;
			Byte24 = default;
			Byte25 = default;
			Byte26 = default;
			Byte27 = default;
			Byte28 = default;
			Byte29 = default;
			Byte30 = default;
			Byte31 = default;
			SByte0 = default;
			SByte1 = default;
			SByte2 = default;
			SByte3 = default;
			SByte4 = default;
			SByte5 = default;
			SByte6 = default;
			SByte7 = default;
			SByte8 = default;
			SByte9 = default;
			SByte10 = default;
			SByte11 = default;
			SByte12 = default;
			SByte13 = default;
			SByte14 = default;
			SByte15 = default;
			SByte16 = default;
			SByte17 = default;
			SByte18 = default;
			SByte19 = default;
			SByte20 = default;
			SByte21 = default;
			SByte22 = default;
			SByte23 = default;
			SByte24 = default;
			SByte25 = default;
			SByte26 = default;
			SByte27 = default;
			SByte28 = default;
			SByte29 = default;
			SByte30 = default;
			SByte31 = default;
			UShort0 = default;
			UShort1 = default;
			UShort2 = default;
			UShort3 = default;
			UShort4 = default;
			UShort5 = default;
			UShort6 = default;
			UShort7 = default;
			UShort8 = default;
			UShort9 = default;
			UShort10 = default;
			UShort11 = default;
			UShort12 = default;
			UShort13 = default;
			UShort14 = default;
			UShort15 = default;
			SShort0 = default;
			SShort1 = default;
			SShort2 = default;
			SShort3 = default;
			SShort4 = default;
			SShort5 = default;
			SShort6 = default;
			SShort7 = default;
			SShort8 = default;
			SShort9 = default;
			SShort10 = default;
			SShort11 = default;
			SShort12 = default;
			SShort13 = default;
			SShort14 = default;
			SShort15 = default;
			UInt0 = default;
			UInt1 = default;
			UInt2 = default;
			UInt3 = default;
			UInt4 = default;
			UInt5 = default;
			UInt6 = default;
			UInt7 = default;
			SInt0 = default;
			SInt1 = default;
			SInt2 = default;
			SInt3 = default;
			SInt4 = default;
			SInt5 = default;
			SInt6 = default;
			SInt7 = default;
			ULong0 = default;
			ULong1 = default;
			ULong2 = default;
			ULong3 = default;
			SLong0 = default;
			SLong1 = default;
			SLong2 = default;
			SLong3 = default;
			Float0 = default;
			Float1 = default;
			Float2 = default;
			Float3 = default;
			Float4 = default;
			Float5 = default;
			Float6 = default;
			Float7 = default;
			Double0 = default;
			Double1 = default;
			Double2 = default;
			Double3 = default;
			Lo128 = default;
			Hi128 = default;
		} // 0x0000000185FB6710-0x0000000185FB6720
	}

	public struct v64 // TypeDefIndex: 60238
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

	public static class X86 // TypeDefIndex: 60243
	{
		// Nested types
		public static class Avx // TypeDefIndex: 60239
		{
			// Methods
			public static unsafe v256 mm256_load_ps(void* ptr) => default; // 0x0000000181EBB9F0-0x0000000181EBBA10
			public static unsafe void mm256_store_ps(void* ptr, v256 val) {} // 0x0000000185FD7170-0x0000000185FD7180
			public static unsafe v256 mm256_loadu_si256(void* ptr) => default; // 0x0000000181EBB9F0-0x0000000181EBBA10
			public static unsafe void mm256_storeu_si256(void* ptr, v256 v) {} // 0x0000000185FD7170-0x0000000185FD7180
			public static v256 mm256_set1_epi32(int a) => default; // 0x000000018BC7935C-0x000000018BC79380
		}
	
		public static class Avx2 // TypeDefIndex: 60240
		{
			// Properties
			public static bool IsAvx2Supported { get; } // 0x00000001814A81B0-0x00000001814A81C0 
	
			// Methods
			public static v256 mm256_xor_si256(v256 a, v256 b) => default; // 0x000000018BC792C0-0x000000018BC7935C
			public static v256 mm256_add_epi64(v256 a, v256 b) => default; // 0x000000018BC79014-0x000000018BC790B0
			public static v256 mm256_mul_epu32(v256 a, v256 b) => default; // 0x000000018BC790B0-0x000000018BC7914C
			public static v256 mm256_slli_epi64(v256 a, int imm8) => default; // 0x000000018BC791C8-0x000000018BC79244
			public static v256 mm256_srli_epi64(v256 a, int imm8) => default; // 0x000000018BC79244-0x000000018BC792C0
			public static v256 mm256_shuffle_epi32(v256 a, int imm8) => default; // 0x000000018BC7914C-0x000000018BC791C8
		}
	
		public static class Sse // TypeDefIndex: 60241
		{
			// Methods
			public static int SHUFFLE(int d, int c, int b, int a) => default; // 0x0000000185FD72F0-0x0000000185FD7320
		}
	
		public static class Sse2 // TypeDefIndex: 60242
		{
			// Methods
			public static v128 add_epi64(v128 a, v128 b) => default; // 0x0000000185FD7240-0x0000000185FD7260
			public static v128 mul_epu32(v128 a, v128 b) => default; // 0x0000000185FD7260-0x0000000185FD7280
			public static v128 slli_epi64(v128 a, int imm8) => default; // 0x000000018BC7C964-0x000000018BC7CA00
			public static v128 srli_epi64(v128 a, int imm8) => default; // 0x000000018BC7CA00-0x000000018BC7CA9C
			public static v128 xor_si128(v128 a, v128 b) => default; // 0x0000000185FD72D0-0x0000000185FD72F0
			public static v128 shuffle_epi32(v128 a, int imm8) => default; // 0x0000000185FD7280-0x0000000185FD72D0
		}
	}
}
