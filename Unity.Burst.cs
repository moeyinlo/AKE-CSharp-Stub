/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Scripting;

// Image 85: Unity.Burst.dll - Assembly: Unity.Burst, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59173-59224

namespace Unity.Burst
{
	public enum OptimizeFor // TypeDefIndex: 59176
	{
		Default = 0,
		Performance = 1,
		Size = 2,
		FastCompilation = 3,
		Balanced = 4
	}

	public enum FloatMode // TypeDefIndex: 59177
	{
		Default = 0,
		Strict = 1,
		Deterministic = 2,
		Fast = 3
	}

	public enum FloatPrecision // TypeDefIndex: 59178
	{
		Standard = 0,
		High = 1,
		Medium = 2,
		Low = 3
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
	public class BurstCompileAttribute : Attribute // TypeDefIndex: 59179
	{
		// Fields
		internal bool? _compileSynchronously; // 0x18
		internal bool? _disableDirectCall; // 0x1A
	
		// Properties
		public FloatMode FloatMode { get; set; } // 0x00000001810410F0-0x0000000181041100
		public FloatPrecision FloatPrecision { get; set; } // 0x0000000183D595B0-0x0000000183D595C0
		public bool CompileSynchronously { set {} } // 0x0000000183134A80-0x0000000183134AD0
		public bool DisableDirectCall { set {} } // 0x0000000189B5FB0C-0x0000000189B5FB58
		public OptimizeFor OptimizeFor { get; set; } // 0x0000000183D4EBC0-0x0000000183D4EBD0
		internal string[] Options { get; set; } // 0x0000000184271930-0x0000000184271940
	
		// Constructors
		public BurstCompileAttribute() {} // 0x000000018350B670-0x000000018350B680
		public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode) {} // 0x0000000183D76510-0x0000000183D76520
	}

	public static class BurstCompiler // TypeDefIndex: 59185
	{
		// Fields
		internal static bool _IsEnabled; // 0x00
		public static readonly BurstCompilerOptions Options; // 0x08
		internal static Action OnCompileILPPMethod2; // 0x10
		private static readonly MethodInfo DummyMethodInfo; // 0x18
	
		// Properties
		public static bool IsEnabled { get; } // 0x0000000183A20B80-0x0000000183A20C40 
	
		// Nested types
		[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
		internal class StaticTypeReinitAttribute : Attribute // TypeDefIndex: 59180
		{
			// Fields
			public readonly System.Type reinitType; // 0x10
	
			// Constructors
			public StaticTypeReinitAttribute() {} // Dummy constructor
			public StaticTypeReinitAttribute(System.Type toReinit) {} // 0x00000001826E80F0-0x00000001826E8180
		}
	
		[BurstCompile]
		internal static class BurstCompilerHelper // TypeDefIndex: 59182
		{
			// Fields
			private static readonly IsBurstEnabledDelegate IsBurstEnabledImpl; // 0x00
			public static readonly bool IsBurstGenerated; // 0x08
	
			// Nested types
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			private delegate bool IsBurstEnabledDelegate(); // TypeDefIndex: 59181; 0x00000001837FED30-0x00000001837FED60
	
			// Constructors
			static BurstCompilerHelper() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			[BurstCompile]
			[AOT.MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
			private static bool IsBurstEnabled() => default;
			[BurstDiscard]
			private static void DiscardedMethod(ref bool value) {} // 0x000000018382FDE0-0x000000018382FEB0
			private static bool IsCompiledByBurst(Delegate del) => default; // 0x00000001825E4840-0x00000001825E4B90
		}
	
		private class FakeDelegate // TypeDefIndex: 59183
		{
			// Properties
			[UnityEngine.Scripting.Preserve]
			public MethodInfo Method { get; } // 0x000000018426FEE0-0x000000018426FEF0 
	
			// Constructors
			public FakeDelegate() {} // Dummy constructor
			public FakeDelegate(MethodInfo method) {} // 0x000000018397DA00-0x000000018397DB20
		}
	
		// Constructors
		static BurstCompiler() {} // 0x00000001839C1680-0x00000001839C16F0
	
		// Methods
		public static IntPtr CompileILPPMethod2(RuntimeMethodHandle burstMethodHandle) => default; // 0x0000000183A20CA0-0x0000000183A20D30
		public static unsafe void* GetILPPMethodFunctionPointer2(IntPtr ilppMethod, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle) => default; // 0x0000000186F0A8DC-0x0000000186F0A8EC
		public static FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod)
			where T : class => default; // 0x000000018426FEE0-0x000000018426FEF0
		private static unsafe void* Compile(object delegateObj, bool isFunctionPointer) => default; // 0x00000001820B7B20-0x00000001820B7B30
		private static unsafe void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing) => default; // 0x0000000183D12A70-0x0000000183D12AD0
		private static void DummyMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public sealed class BurstCompilerOptions // TypeDefIndex: 59186
	{
		// Fields
		internal static readonly bool ForceDisableBurstCompilation; // 0x00
		private static readonly bool ForceBurstCompilationSynchronously; // 0x01
		internal static readonly bool IsSecondaryUnityProcess; // 0x02
		private bool _enableBurstCompilation; // 0x10
		private bool _enableBurstSafetyChecks; // 0x11
	
		// Properties
		private bool IsGlobal { get; } // 0x0000000183D519E0-0x0000000183D519F0 
		public bool EnableBurstCompilation { get => default; set {} } // 0x00000001811797F0-0x0000000181179800 0x000000018397DB60-0x000000018397DC50
		public bool EnableBurstSafetyChecks { set {} } // 0x000000018397DC50-0x000000018397DC70
		internal Action OptionsChanged { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public BurstCompilerOptions() {} // Dummy constructor
		internal BurstCompilerOptions(bool isGlobal) {} // 0x000000018397DB20-0x000000018397DB60
		static BurstCompilerOptions() {} // 0x00000001830F0AE0-0x00000001830F0BD0
	
		// Methods
		private static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute) {
			attribute = default;
			return default;
		} // 0x00000001825E4CA0-0x00000001825E4D40
		private static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo) => default; // 0x00000001825E4D40-0x00000001825E4FD0
		internal static bool HasBurstCompileAttribute(MemberInfo member) => default; // 0x00000001825E4C20-0x00000001825E4CA0
		private void OnOptionsChanged() {} // 0x000000018397DC70-0x000000018397DC90
		private void MaybeTriggerRecompilation() {} // 0x000000018350B670-0x000000018350B680
		private static bool CheckIsSecondaryUnityProcess() => default; // 0x000000018115F4C0-0x000000018115F530
	}

	public static class BurstRuntime // TypeDefIndex: 59189
	{
		// Nested types
		private struct HashCode64<T> // TypeDefIndex: 59187
		{
			// Fields
			public static readonly long Value;
	
			// Constructors
			static HashCode64() {
				Value = default;
			}
		}
	
		internal class PreserveAttribute : Attribute // TypeDefIndex: 59188
		{
			// Constructors
			public PreserveAttribute() {} // 0x0000000182DCD400-0x0000000182DCD480
		}
	
		// Methods
		public static long GetHashCode64<T>() => default; // 0x0000000189B5FBB8-0x0000000189B5FC94
		internal static long HashStringWithFNV1A64(string text) => default; // 0x0000000189B5FB94-0x0000000189B5FBB8
		[Preserve]
		internal static void PreventRequiredAttributeStrip() {}
		[Preserve]
		internal static unsafe void Log(byte* message, int logType, byte* fileName, int lineNumber) {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class BurstString // TypeDefIndex: 59200
	{
		// Fields
		private static readonly char[] SplitByColon; // 0x00
		private static readonly byte[] logTable; // 0x08
		private static readonly uint[] g_PowerOf10_U32; // 0x10
		private static readonly byte[] InfinityString; // 0x18
		private static readonly byte[] NanString; // 0x20
	
		// Nested types
		internal class PreserveAttribute : Attribute // TypeDefIndex: 59190
		{
			// Constructors
			public PreserveAttribute() {} // 0x0000000189B61164-0x0000000189B61188
		}
	
		private enum NumberBufferKind // TypeDefIndex: 59191
		{
			Integer = 0,
			Float = 1
		}
	
		private struct NumberBuffer // TypeDefIndex: 59192
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
			} // 0x0000000189B622EC-0x0000000189B623C8
	
			// Methods
			public unsafe byte* GetDigitsPointer() => default; // 0x0000000189B626A0-0x0000000189B6271C
		}
	
		public enum NumberFormatKind : byte // TypeDefIndex: 59193
		{
			General = 0,
			Decimal = 1,
			DecimalForceSigned = 2,
			Hexadecimal = 3
		}
	
		public struct FormatOptions // TypeDefIndex: 59194
		{
			// Fields
			public NumberFormatKind Kind; // 0x00
			public sbyte AlignAndSize; // 0x01
			public byte Specifier; // 0x02
			public bool Lowercase; // 0x03
	
			// Properties
			public bool Uppercase { get => default; } // 0x0000000189B624C0-0x0000000189B6260C 
	
			// Constructors
			public FormatOptions(NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase) : this() {
				Kind = default;
				AlignAndSize = default;
				Specifier = default;
				Lowercase = default;
			} // 0x0000000189B62444-0x0000000189B624C0
	
			// Methods
			public int GetBase() => default; // 0x0000000189B61E6C-0x0000000189B62028
			public override string ToString() => default; // 0x0000000189B6271C-0x0000000189B6279C
		}
	
		public struct tBigInt // TypeDefIndex: 59196
		{
			// Fields
			public int m_length; // 0x00
			public unsafe fixed /* 0x00000000-0x00000000 */ uint m_blocks[0]; // 0x04
	
			// Methods
			public int GetLength() => default; // 0x0000000189B620A4-0x0000000189B62124
			public uint GetBlock(int idx) => default; // 0x0000000189B623C8-0x0000000189B62444
			public bool IsZero() => default; // 0x0000000189B62028-0x0000000189B620A4
			public void SetU64(ulong val) {} // 0x0000000189B62124-0x0000000189B621BC
			public void SetU32(uint val) {} // 0x0000000189B62254-0x0000000189B622EC
		}
	
		public enum CutoffMode // TypeDefIndex: 59197
		{
			Unique = 0,
			TotalLength = 1,
			FractionLength = 2
		}
	
		public struct tFloatUnion32 // TypeDefIndex: 59198
		{
			// Fields
			public float m_floatingPoint; // 0x00
			public uint m_integer; // 0x00
	
			// Methods
			public bool IsNegative() => default; // 0x0000000189B621BC-0x0000000189B62254
			public uint GetExponent() => default; // 0x0000000189B6260C-0x0000000189B626A0
			public uint GetMantissa() => default; // 0x0000000189B60FF4-0x0000000189B61164
		}
	
		public struct tFloatUnion64 // TypeDefIndex: 59199
		{
			// Fields
			public double m_floatingPoint; // 0x00
			public ulong m_integer; // 0x00
	
			// Methods
			public bool IsNegative() => default; // 0x0000000189B62870-0x0000000189B6289C
			public uint GetExponent() => default; // 0x0000000189B60E5C-0x0000000189B60FF4
			public ulong GetMantissa() => default; // 0x0000000189B61C6C-0x0000000189B61E6C
		}
	
		// Constructors
		static BurstString() {} // 0x0000000183D766F0-0x0000000183D76710
	
		// Methods
		[Preserve]
		public static unsafe void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength) {} // 0x0000000189B618B8-0x0000000189B61958
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw) {} // 0x0000000189B62AA8-0x0000000189B62AD0
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw) {} // 0x0000000189B5FCC4-0x0000000189B5FD4C
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw) {} // 0x0000000189B5FC94-0x0000000189B5FCC4
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw) {} // 0x0000000189B6279C-0x0000000189B62870
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw) {} // 0x0000000189B61958-0x0000000189B61AD0
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw) {} // 0x0000000189B62990-0x0000000189B62A84
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw) {} // 0x0000000189B62A84-0x0000000189B62AA8
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw) {} // 0x0000000189B6289C-0x0000000189B62990
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw) {} // 0x0000000189B5FE6C-0x0000000189B5FEC0
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw) {} // 0x0000000189B5FDF8-0x0000000189B5FE6C
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw) {} // 0x0000000189B5FD4C-0x0000000189B5FDF8
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw) {} // 0x0000000189B6050C-0x0000000189B60580
		[Preserve]
		public static unsafe void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw) {} // 0x0000000189B603CC-0x0000000189B604A4
		private static unsafe void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, FormatOptions options) {} // 0x0000000189B604A4-0x0000000189B6050C
		private static int GetLengthIntegerToString(long value, int basis, int zeroPadding) => default; // 0x0000000189B60064-0x0000000189B600BC
		private static unsafe void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, FormatOptions options) {} // 0x0000000189B600BC-0x0000000189B600F8
		private static unsafe void FormatNumber(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, FormatOptions options) {} // 0x0000000189B60028-0x0000000189B60064
		private static unsafe void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int zeroPadding, bool outputPositiveSign) {} // 0x0000000189B62CDC-0x0000000189B62EA0
		private static byte ValueToIntegerChar(int value, bool uppercase) => default; // 0x0000000189B60580-0x0000000189B607EC
		private static unsafe bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length) => default; // 0x0000000189B600F8-0x0000000189B603CC
		private static unsafe bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length) => default; // 0x0000000189B607EC-0x0000000189B60834
		private static int GetLengthForFormatGeneral(ref NumberBuffer number, int nMaxDigits) => default; // 0x0000000189B5FEC0-0x0000000189B60028
		private static unsafe void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref NumberBuffer number, int nMaxDigits, byte expChar) {} // 0x0000000189B60834-0x0000000189B60980
		private static void RoundNumber(ref NumberBuffer number, int pos, bool isCorrectlyRounded) {} // 0x0000000189B61188-0x0000000189B618B8
		private static unsafe bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded) => default; // 0x0000000189B61AD0-0x0000000189B61C6C
		private static uint LogBase2(uint val) => default; // 0x0000000189B60C00-0x0000000189B60E5C
		private static int BigInt_Compare([IsReadOnly] in tBigInt lhs, [IsReadOnly] in tBigInt rhs) => default; // 0x0000000189B60980-0x0000000189B60C00
		private static void BigInt_Add(out tBigInt pResult, [IsReadOnly] in tBigInt lhs, [IsReadOnly] in tBigInt rhs) {
			pResult = default;
		} // 0x0000000189B62AD0-0x0000000189B62CDC
		private static void BigInt_Add_internal(out tBigInt pResult, [IsReadOnly] in tBigInt pLarge, [IsReadOnly] in tBigInt pSmall) {
			pResult = default;
		} // 0x000000018350B670-0x000000018350B680
		private static void BigInt_Multiply(out tBigInt pResult, [IsReadOnly] in tBigInt lhs, [IsReadOnly] in tBigInt rhs) {
			pResult = default;
		} // 0x0000000183D765B0-0x0000000183D765D0
		private static void BigInt_Multiply_internal(out tBigInt pResult, [IsReadOnly] in tBigInt pLarge, [IsReadOnly] in tBigInt pSmall) {
			pResult = default;
		} // 0x00000001820C61B0-0x00000001820C61C0
		private static void BigInt_Multiply(out tBigInt pResult, [IsReadOnly] in tBigInt lhs, uint rhs) {
			pResult = default;
		} // 0x0000000183D76590-0x0000000183D765B0
		private static void BigInt_Multiply2(out tBigInt pResult, [IsReadOnly] in tBigInt input) {
			pResult = default;
		} // 0x0000000189859E24-0x0000000189859E2C
		private static void BigInt_Multiply2(ref tBigInt pResult) {} // 0x0000000189B62EA0-0x0000000189B62EB4
		private static void BigInt_Multiply10(ref tBigInt pResult) {} // 0x0000000189B62EB4-0x0000000189B630F0
		private static tBigInt g_PowerOf10_Big(int i) => default; // 0x0000000183D4E980-0x0000000183D4E990
		private static void BigInt_Pow10(out tBigInt pResult, uint exponent) {
			pResult = default;
		} // 0x0000000183D766B0-0x0000000183D766C0
		private static void BigInt_MultiplyPow10(out tBigInt pResult, [IsReadOnly] in tBigInt input, uint exponent) {
			pResult = default;
		} // 0x00000001822FBAA0-0x00000001822FBAB0
		private static void BigInt_Pow2(out tBigInt pResult, uint exponent) {
			pResult = default;
		} // 0x0000000189B6323C-0x0000000189B6326C
		private static uint BigInt_DivideWithRemainder_MaxQuotient9(ref tBigInt pDividend, [IsReadOnly] in tBigInt divisor) => default; // 0x0000000189B63228-0x0000000189B6323C
		private static void BigInt_ShiftLeft(ref tBigInt pResult, uint shift) {} // 0x0000000189284DFC-0x0000000189284E04
		private static unsafe uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, out int pOutExponent) {
			pOutExponent = default;
			return default;
		} // 0x0000000183D766C0-0x0000000183D766D0
		private static unsafe void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, FormatOptions formatOptions) {} // 0x0000000183D766D0-0x0000000183D766E0
		private static unsafe void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, FormatOptions formatOptions) {} // 0x0000000189B6326C-0x0000000189B63280
		private static unsafe void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, FormatOptions formatOptions) {} // 0x0000000183D766E0-0x0000000183D766F0
	}

	[IsReadOnly]
	public struct FunctionPointer<T> // TypeDefIndex: 59201
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private readonly IntPtr _ptr;
	
		// Properties
		public T Invoke { get => default; }
	
		// Constructors
		public FunctionPointer(IntPtr ptr) : this() {
			_ptr = default;
		}
	}

	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class NoAliasAttribute : Attribute // TypeDefIndex: 59202
	{
		// Constructors
		public NoAliasAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[IsReadOnly]
	public struct SharedStatic<T> // TypeDefIndex: 59203
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
		public static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0 /* Metadata: 0x01FDCD71 */) => default;
		public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode) => default;
	}

	internal static class SharedStatic // TypeDefIndex: 59205
	{
		// Nested types
		internal class PreserveAttribute : Attribute // TypeDefIndex: 59204
		{
			// Constructors
			public PreserveAttribute() {} // 0x000000018338D150-0x000000018338D1B0
		}
	
		// Methods
		[Preserve]
		public static unsafe void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) => default; // 0x000000018350B670-0x000000018350B680
	}
}

namespace Unity.Burst.CompilerServices
{
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class AssumeRangeAttribute : Attribute // TypeDefIndex: 59219
	{
		// Constructors
		public AssumeRangeAttribute() {} // Dummy constructor
		public AssumeRangeAttribute(long min, long max) {} // 0x000000018350B670-0x000000018350B680
	}

	public static class Hint // TypeDefIndex: 59220
	{
		// Methods
		public static bool Likely(bool condition) => default; // 0x0000000183D702E0-0x0000000183D702F0
	}
}

namespace Unity.Burst.Intrinsics
{
	public static class Common // TypeDefIndex: 59206
	{
		// Methods
		public static ulong umul128(ulong x, ulong y, out ulong high) {
			high = default;
			return default;
		} // 0x0000000183D76520-0x0000000183D76590
	}

	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[Unity.Burst.BurstRuntime.Preserve]
	internal sealed class BurstTargetCpuAttribute : Attribute // TypeDefIndex: 59207
	{
		// Constructors
		public BurstTargetCpuAttribute() {} // Dummy constructor
	}

	internal class V64DebugView // TypeDefIndex: 59208
	{
		// Constructors
		public V64DebugView() {} // Dummy constructor
	}

	internal class V128DebugView // TypeDefIndex: 59209
	{
		// Constructors
		public V128DebugView() {} // Dummy constructor
	}

	internal class V256DebugView // TypeDefIndex: 59210
	{
		// Constructors
		public V256DebugView() {} // Dummy constructor
	}

	[DebuggerTypeProxy(typeof(V128DebugView))]
	public struct v128 // TypeDefIndex: 59211
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
	public struct v256 // TypeDefIndex: 59212
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
		} // 0x0000000183D76710-0x0000000183D76730
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
		} // 0x0000000183D553F0-0x0000000183D55400
	}

	[DebuggerTypeProxy(typeof(V64DebugView))]
	public struct v64 // TypeDefIndex: 59213
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
	public static class X86 // TypeDefIndex: 59218
	{
		// Nested types
		public static class Avx // TypeDefIndex: 59214
		{
			// Methods
			[DebuggerStepThrough]
			public static unsafe v256 mm256_load_ps(void* ptr) => default; // 0x0000000183D5C700-0x0000000183D5C720
			[DebuggerStepThrough]
			public static unsafe void mm256_store_ps(void* ptr, v256 val) {} // 0x0000000183D76500-0x0000000183D76510
			[DebuggerStepThrough]
			public static unsafe v256 mm256_loadu_si256(void* ptr) => default; // 0x0000000183D5C700-0x0000000183D5C720
			[DebuggerStepThrough]
			public static unsafe void mm256_storeu_si256(void* ptr, v256 v) {} // 0x0000000183D76500-0x0000000183D76510
			[DebuggerStepThrough]
			public static v256 mm256_set1_epi32(int a) => default; // 0x0000000189B5FAE8-0x0000000189B5FB0C
		}
	
		public static class Avx2 // TypeDefIndex: 59215
		{
			// Properties
			public static bool IsAvx2Supported { get; } // 0x000000018115F4C0-0x000000018115F530 
	
			// Methods
			[DebuggerStepThrough]
			public static v256 mm256_xor_si256(v256 a, v256 b) => default; // 0x0000000189B5FA4C-0x0000000189B5FAE8
			[DebuggerStepThrough]
			public static v256 mm256_add_epi64(v256 a, v256 b) => default; // 0x0000000189B5F7A0-0x0000000189B5F83C
			[DebuggerStepThrough]
			public static v256 mm256_mul_epu32(v256 a, v256 b) => default; // 0x0000000189B5F83C-0x0000000189B5F8D8
			[DebuggerStepThrough]
			public static v256 mm256_slli_epi64(v256 a, int imm8) => default; // 0x0000000189B5F954-0x0000000189B5F9D0
			[DebuggerStepThrough]
			public static v256 mm256_srli_epi64(v256 a, int imm8) => default; // 0x0000000189B5F9D0-0x0000000189B5FA4C
			[DebuggerStepThrough]
			public static v256 mm256_shuffle_epi32(v256 a, int imm8) => default; // 0x0000000189B5F8D8-0x0000000189B5F954
		}
	
		public static class Sse // TypeDefIndex: 59216
		{
			// Methods
			public static int SHUFFLE(int d, int c, int b, int a) => default; // 0x0000000183D76680-0x0000000183D766B0
		}
	
		public static class Sse2 // TypeDefIndex: 59217
		{
			// Methods
			[DebuggerStepThrough]
			public static v128 add_epi64(v128 a, v128 b) => default; // 0x0000000183D765D0-0x0000000183D765F0
			[DebuggerStepThrough]
			public static v128 mul_epu32(v128 a, v128 b) => default; // 0x0000000183D765F0-0x0000000183D76610
			[DebuggerStepThrough]
			public static v128 slli_epi64(v128 a, int imm8) => default; // 0x0000000189B630F0-0x0000000189B6318C
			[DebuggerStepThrough]
			public static v128 srli_epi64(v128 a, int imm8) => default; // 0x0000000189B6318C-0x0000000189B63228
			[DebuggerStepThrough]
			public static v128 xor_si128(v128 a, v128 b) => default; // 0x0000000183D76660-0x0000000183D76680
			[DebuggerStepThrough]
			public static v128 shuffle_epi32(v128 a, int imm8) => default; // 0x0000000183D76610-0x0000000183D76660
		}
	}
}
