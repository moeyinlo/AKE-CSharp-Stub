/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Playables;
using UnityEngine.Profiling;
using UnityEngine.Profiling.Experimental;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngineInternal;

// Image 14: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 47188-48125

namespace AOT
{
	public class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 47192
	{
		// Constructors
		public MonoPInvokeCallbackAttribute() {} // Dummy constructor
		public MonoPInvokeCallbackAttribute(System.Type type) {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace JetBrains.Annotations
{
	public sealed class CanBeNullAttribute : Attribute // TypeDefIndex: 47298
	{
		// Constructors
		public CanBeNullAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NotNullAttribute : Attribute // TypeDefIndex: 47299
	{
		// Constructors
		public NotNullAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MeansImplicitUseAttribute : Attribute // TypeDefIndex: 47300
	{
		// Fields
		private readonly ImplicitUseKindFlags _UseKindFlags_k__BackingField; // 0x10
		private readonly ImplicitUseTargetFlags _TargetFlags_k__BackingField; // 0x14
	
		// Constructors
		public MeansImplicitUseAttribute() {} // 0x0000000185FE6900-0x0000000185FE6910
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags) {} // 0x0000000185FB2190-0x0000000185FB21A0
	}

	public enum ImplicitUseKindFlags // TypeDefIndex: 47301
	{
		Access = 1,
		Assign = 2,
		InstantiatedWithFixedConstructorSignature = 4,
		Default = 7,
		InstantiatedNoFixedConstructorSignature = 8
	}

	public enum ImplicitUseTargetFlags // TypeDefIndex: 47302
	{
		Default = 1,
		Itself = 1,
		Members = 2,
		WithMembers = 3
	}

	public sealed class PureAttribute : Attribute // TypeDefIndex: 47303
	{
		// Constructors
		public PureAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MustUseReturnValueAttribute : Attribute // TypeDefIndex: 47304
	{
		// Constructors
		public MustUseReturnValueAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NoEnumerationAttribute : Attribute // TypeDefIndex: 47305
	{
		// Constructors
		public NoEnumerationAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 47189
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 47190
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 47191
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.Burst
{
	public class BurstAuthorizedExternalMethodAttribute : Attribute // TypeDefIndex: 47294
	{
		// Constructors
		public BurstAuthorizedExternalMethodAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class BurstDiscardAttribute : Attribute // TypeDefIndex: 47295
	{
		// Constructors
		public BurstDiscardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.Burst.LowLevel
{
	internal static class BurstCompilerService // TypeDefIndex: 47297
	{
		// Nested types
		public enum BurstLogType // TypeDefIndex: 47296
		{
			Info = 0,
			Warning = 1,
			Error = 2
		}
	
		// Methods
		public static int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions) => default; // 0x000000018439E930-0x000000018439E980
		public static unsafe void* GetAsyncCompiledAsyncDelegateMethod(int userID) => default; // 0x000000018439E8F0-0x000000018439E930
		public static unsafe void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment) => default; // 0x000000018534F850-0x000000018534F8B0
		public static unsafe void Log(void* userData, BurstLogType logType, byte* message, byte* filename, int lineNumber) {} // 0x000000018BEB4FEC-0x000000018BEB504C
	}
}

namespace Unity.Collections
{
	public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 47250
	{
		// Constructors
		public ReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class WriteOnlyAttribute : Attribute // TypeDefIndex: 47251
	{
		// Constructors
		public WriteOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class DeallocateOnJobCompletionAttribute : Attribute // TypeDefIndex: 47252
	{
		// Constructors
		public DeallocateOnJobCompletionAttribute() {} // Dummy constructor
	}

	public sealed class NativeFixedLengthAttribute : Attribute // TypeDefIndex: 47253
	{
		// Constructors
		public NativeFixedLengthAttribute() {} // Dummy constructor
	}

	public sealed class NativeMatchesParallelForLengthAttribute : Attribute // TypeDefIndex: 47254
	{
		// Constructors
		public NativeMatchesParallelForLengthAttribute() {} // Dummy constructor
	}

	public sealed class NativeDisableParallelForRestrictionAttribute : Attribute // TypeDefIndex: 47255
	{
		// Constructors
		public NativeDisableParallelForRestrictionAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum Allocator // TypeDefIndex: 47256
	{
		Invalid = 0,
		None = 1,
		Temp = 2,
		TempJob = 3,
		Persistent = 4,
		AudioKernel = 5
	}

	internal enum LeakCategory // TypeDefIndex: 47257
	{
		Invalid = 0,
		Malloc = 1,
		TempJob = 2,
		Persistent = 3,
		LightProbesQuery = 4,
		NativeTest = 5,
		MeshDataArray = 6,
		TransformAccessArray = 7,
		NavMeshQuery = 8
	}

	public static class NativeLeakDetection // TypeDefIndex: 47258
	{
		// Fields
		private static int s_NativeLeakDetectionMode; // 0x00
	
		// Methods
		private static void Initialize() {} // 0x000000018BEC5948-0x000000018BEC5984
	}

	public enum NativeArrayOptions // TypeDefIndex: 47259
	{
		UninitializedMemory = 0,
		ClearMemory = 1
	}

	public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEquatable<NativeArray<T>> // TypeDefIndex: 47263
		where T : struct
	{
		// Fields
		internal unsafe void* m_Buffer;
		internal int m_Length;
		internal Unity.Collections.Allocator m_AllocatorLabel;
	
		// Properties
		public int Length { get => default; }
		public T this[int index] { get => default; set {} }
		public bool IsCreated { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 47260
		{
			// Fields
			private NativeArray<T> m_Array;
			private int m_Index;
			private T value;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(ref NativeArray<T> array) : this() {
				m_Array = default;
				m_Index = default;
				value = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct ReadOnly : IEnumerable<T> // TypeDefIndex: 47262
		{
			// Fields
			internal unsafe void* m_Buffer;
			internal int m_Length;
	
			// Properties
			public T this[int index] { get => default; }
	
			// Nested types
			public struct Enumerator : IEnumerator<T> // TypeDefIndex: 47261
			{
				// Fields
				private ReadOnly<T> m_Array;
				private int m_Index;
				private T value;
	
				// Properties
				public T Current { get => default; }
				object IEnumerator.Current { get => default; }
	
				// Constructors
				public Enumerator(in ReadOnly<T> array) : this() {
					m_Array = default;
					m_Index = default;
					value = default;
				}
	
				// Methods
				public void Dispose() {}
				public bool MoveNext() => default;
				public void Reset() {}
			}
	
			// Constructors
			internal unsafe ReadOnly(void* buffer, int length) : this() {
				m_Buffer = default;
				m_Length = default;
			}
	
			// Methods
			public Enumerator GetEnumerator() => default;
			IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		// Constructors
		public unsafe NativeArray(int length, Unity.Collections.Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x020602FB */) : this() {
			m_Buffer = default;
			m_Length = default;
			m_AllocatorLabel = default;
		}
		public unsafe NativeArray(T[] array, Unity.Collections.Allocator allocator) : this() {
			m_Buffer = default;
			m_Length = default;
			m_AllocatorLabel = default;
		}
		public unsafe NativeArray(NativeArray<T> array, Unity.Collections.Allocator allocator) : this() {
			m_Buffer = default;
			m_Length = default;
			m_AllocatorLabel = default;
		}
	
		// Methods
		private static void Allocate(int length, Unity.Collections.Allocator allocator, out NativeArray<T> array) {
			array = default;
		}
		public void Dispose() {}
		public JobHandle Dispose(JobHandle inputDeps) => default;
		public void CopyFrom(T[] array) {}
		public void CopyFrom(NativeArray<T> array) {}
		public T[] ToArray() => default;
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool Equals(NativeArray<T> other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
		public static void Copy(NativeArray<T> src, NativeArray<T> dst) {}
		public static void Copy(T[] src, NativeArray<T> dst) {}
		public static void Copy(NativeArray<T> src, T[] dst) {}
		public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length) {}
		public static void Copy(NativeArray<T> src, T[] dst, int length) {}
		public static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) {}
		public static void Copy(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) {}
		public static void Copy(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) {}
		public void ReinterpretStore<U>(int destIndex, U data)
			where U : struct {}
		private Collections.NativeArray<U> InternalReinterpret<U>(int length)
			where U : struct => default;
		public Collections.NativeArray<U> Reinterpret<U>()
			where U : struct => default;
		public NativeArray<T> GetSubArray(int start, int length) => default;
		public ReadOnly AsReadOnly() => default;
	}

	internal struct NativeArrayDispose // TypeDefIndex: 47264
	{
		// Fields
		internal unsafe void* m_Buffer; // 0x00
		internal Unity.Collections.Allocator m_AllocatorLabel; // 0x08
	
		// Methods
		public void Dispose() {} // 0x0000000186473920-0x0000000186473930
	}

	internal struct NativeArrayDisposeJob : IJob // TypeDefIndex: 47265
	{
		// Fields
		internal NativeArrayDispose Data; // 0x00
	
		// Methods
		public void Execute() {} // 0x0000000185280BA0-0x0000000185280BE0
	}

	internal sealed class NativeArrayDebugView<T> // TypeDefIndex: 47266
		where T : struct
	{
		// Constructors
		public NativeArrayDebugView() {} // Dummy constructor
	}

	internal sealed class NativeArrayReadOnlyDebugView<T> // TypeDefIndex: 47267
		where T : struct
	{
		// Constructors
		public NativeArrayReadOnlyDebugView() {} // Dummy constructor
	}

	public static class NativeSliceExtensions // TypeDefIndex: 47268
	{
		// Methods
		public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray, int start, int length)
			where T : struct => default;
		public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice, int start, int length)
			where T : struct => default;
	}

	public struct NativeSlice<T> : IEnumerable<T>, IEquatable<NativeSlice<T>> // TypeDefIndex: 47270
		where T : struct
	{
		// Fields
		internal unsafe byte* m_Buffer;
		internal int m_Stride;
		internal int m_Length;
	
		// Properties
		public T this[int index] { get => default; set {} }
		public int Stride { get => default; }
		public int Length { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 47269
		{
			// Fields
			private NativeSlice<T> m_Array;
			private int m_Index;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(ref NativeSlice<T> array) : this() {
				m_Array = default;
				m_Index = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		// Constructors
		public unsafe NativeSlice(NativeSlice<T> slice, int start, int length) : this() {
			m_Buffer = default;
			m_Stride = default;
			m_Length = default;
		}
		public unsafe NativeSlice(NativeArray<T> array) : this() {
			m_Buffer = default;
			m_Stride = default;
			m_Length = default;
		}
		public unsafe NativeSlice(NativeArray<T> array, int start, int length) : this() {
			m_Buffer = default;
			m_Stride = default;
			m_Length = default;
		}
	
		// Methods
		public static implicit operator NativeSlice<T>(NativeArray<T> array) => default;
		public Collections.NativeSlice<U> SliceConvert<U>()
			where U : struct => default;
		public void CopyFrom(NativeSlice<T> slice) {}
		public void CopyFrom(T[] array) {}
		public void CopyTo(NativeArray<T> array) {}
		public void CopyTo(T[] array) {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool Equals(NativeSlice<T> other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
		public static bool operator !=(NativeSlice<T> left, NativeSlice<T> right) => default;
	}

	internal sealed class NativeSliceDebugView<T> // TypeDefIndex: 47271
		where T : struct
	{
		// Constructors
		public NativeSliceDebugView() {} // Dummy constructor
	}
}

namespace Unity.Collections.LowLevel.Unsafe
{
	internal static class BurstLike // TypeDefIndex: 47274
	{
		// Nested types
		internal struct SharedStatic<T> // TypeDefIndex: 47272
			where T : struct
		{
			// Fields
			private readonly unsafe void* _buffer;
	
			// Properties
			public ref T Data { get => default; }
	
			// Constructors
			private unsafe SharedStatic(void* buffer) : this() {
				_buffer = default;
			}
	
			// Methods
			public static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0 /* Metadata: 0x020602FC */) => default;
		}
	
		internal static class SharedStatic // TypeDefIndex: 47273
		{
			// Methods
			public static unsafe void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) => default; // 0x000000018534F810-0x000000018534F850
		}
	}

	internal static class BurstRuntime // TypeDefIndex: 47276
	{
		// Nested types
		private struct HashCode64<T> // TypeDefIndex: 47275
		{
			// Fields
			public static readonly long Value;
	
			// Constructors
			static HashCode64() {
				Value = default;
			}
		}
	
		// Methods
		public static long GetHashCode64<T>() => default; // 0x0000000184BD7D70-0x0000000184BD7DF0
		internal static long HashStringWithFNV1A64(string text) => default;
	}

	public sealed class NativeContainerAttribute : Attribute // TypeDefIndex: 47277
	{
		// Constructors
		public NativeContainerAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NativeContainerIsReadOnlyAttribute : Attribute // TypeDefIndex: 47278
	{
		// Constructors
		public NativeContainerIsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NativeContainerIsAtomicWriteOnlyAttribute : Attribute // TypeDefIndex: 47279
	{
		// Constructors
		public NativeContainerIsAtomicWriteOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute // TypeDefIndex: 47280
	{
		// Constructors
		public NativeContainerSupportsMinMaxWriteRestrictionAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute // TypeDefIndex: 47281
	{
		// Constructors
		public NativeContainerSupportsDeallocateOnJobCompletionAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NativeContainerSupportsDeferredConvertListToArray : Attribute // TypeDefIndex: 47282
	{
		// Constructors
		public NativeContainerSupportsDeferredConvertListToArray() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NativeSetThreadIndexAttribute : Attribute // TypeDefIndex: 47283
	{
		// Constructors
		public NativeSetThreadIndexAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute // TypeDefIndex: 47284
	{
		// Constructors
		public NativeContainerNeedsThreadIndexAttribute() {} // Dummy constructor
	}

	public class WriteAccessRequiredAttribute : Attribute // TypeDefIndex: 47285
	{
		// Constructors
		public WriteAccessRequiredAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute // TypeDefIndex: 47286
	{
		// Constructors
		public NativeDisableUnsafePtrRestrictionAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NativeDisableContainerSafetyRestrictionAttribute : Attribute // TypeDefIndex: 47287
	{
		// Constructors
		public NativeDisableContainerSafetyRestrictionAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class NativeSetClassTypeToNullOnScheduleAttribute : Attribute // TypeDefIndex: 47288
	{
		// Constructors
		public NativeSetClassTypeToNullOnScheduleAttribute() {} // Dummy constructor
	}

	public static class NativeArrayUnsafeUtility // TypeDefIndex: 47289
	{
		// Methods
		public static unsafe NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Unity.Collections.Allocator allocator)
			where T : struct => default;
		public static unsafe void* GetUnsafePtr<T>(NativeArray<T> nativeArray)
			where T : struct => default;
		public static unsafe void* GetUnsafeReadOnlyPtr<T>(NativeArray<T> nativeArray)
			where T : struct => default;
		public static unsafe void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray)
			where T : struct => default;
	}

	public static class NativeSliceUnsafeUtility // TypeDefIndex: 47290
	{
		// Methods
		public static unsafe NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length)
			where T : struct => default;
		public static unsafe void* GetUnsafePtr<T>(NativeSlice<T> nativeSlice)
			where T : struct => default;
		public static unsafe void* GetUnsafeReadOnlyPtr<T>(NativeSlice<T> nativeSlice)
			where T : struct => default;
	}

	public static class UnsafeUtility // TypeDefIndex: 47293
	{
		// Nested types
		internal struct IsUnmanagedCache<T> // TypeDefIndex: 47291
		{
			// Fields
			internal static int value;
		}
	
		private struct AlignOfHelper<T> // TypeDefIndex: 47292
			where T : struct
		{
			// Fields
			public byte dummy;
			public T data;
		}
	
		// Methods
		private static int GetFieldOffsetInStruct(System.Reflection.FieldInfo field) => default; // 0x0000000184344CD0-0x0000000184344D10
		private static int GetFieldOffsetInClass(System.Reflection.FieldInfo field) => default; // 0x0000000184344580-0x00000001843445C0
		public static int GetFieldOffset(System.Reflection.FieldInfo field) => default; // 0x00000001843444A0-0x0000000184344580
		public static unsafe void* PinGCObjectAndGetAddress(object target, out ulong gcHandle) {
			gcHandle = default;
			return default;
		} // 0x000000018646FEF4-0x000000018646FF00
		public static unsafe void* PinGCArrayAndGetDataAddress(Array target, out ulong gcHandle) {
			gcHandle = default;
			return default;
		} // 0x000000018BEC9E98-0x000000018BEC9EA4
		private static unsafe void* PinSystemArrayAndGetAddress(object target, out ulong gcHandle) {
			gcHandle = default;
			return default;
		} // 0x000000018BEC9EA4-0x000000018BEC9EE8
		private static unsafe void* PinSystemObjectAndGetAddress(object target, out ulong gcHandle) {
			gcHandle = default;
			return default;
		} // 0x0000000184777EB0-0x0000000184777F00
		public static void ReleaseGCObject(ulong gcHandle) {} // 0x0000000184771600-0x0000000184771640
		public static bool IsBlittable<T>()
			where T : struct => default;
		internal static int LeakRecord(IntPtr handle, LeakCategory category, int callstacksToSkip) => default; // 0x0000000184E99130-0x0000000184E99190
		internal static int LeakErase(IntPtr handle, LeakCategory category) => default; // 0x00000001852A50E0-0x00000001852A5130
		public static unsafe void* MallocTracked(long size, int alignment, Unity.Collections.Allocator allocator, int callstacksToSkip) => default; // 0x00000001840C99C0-0x00000001840C9A30
		public static unsafe void FreeTracked(void* memory, Unity.Collections.Allocator allocator) {} // 0x000000018487C3F0-0x000000018487C440
		public static unsafe void* Malloc(long size, int alignment, Unity.Collections.Allocator allocator) => default; // 0x00000001840A6330-0x00000001840A6390
		public static unsafe void Free(void* memory, Unity.Collections.Allocator allocator) {} // 0x00000001847C57E0-0x00000001847C5830
		public static unsafe void MemCpy(void* destination, void* source, long size) {} // 0x0000000184054650-0x00000001840546B0
		public static unsafe void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count) {} // 0x0000000184091F50-0x0000000184091FC0
		public static unsafe void MemMove(void* destination, void* source, long size) {} // 0x000000018BEC9E44-0x000000018BEC9E98
		public static unsafe void MemSet(void* destination, byte value, long size) {} // 0x00000001841E8980-0x00000001841E89E0
		public static unsafe void MemClear(void* destination, long size) {} // 0x000000018646DB88-0x000000018646DB98
		public static unsafe int MemCmp(void* ptr1, void* ptr2, long size) => default; // 0x0000000184582630-0x0000000184582730
		public static int SizeOf(System.Type type) => default; // 0x0000000184341A80-0x0000000184341AC0
		public static bool IsBlittable(System.Type type) => default; // 0x000000018BEC9E10-0x000000018BEC9E44
		public static bool IsUnmanaged(System.Type type) => default; // 0x0000000184344BA0-0x0000000184344BE0
		private static bool IsBlittableValueType(System.Type t) => default; // 0x000000018BEC9DD0-0x000000018BEC9E10
		private static string GetReasonForTypeNonBlittableImpl(System.Type t, string name) => default; // 0x000000018BEC9C08-0x000000018BEC9D94
		internal static bool IsArrayBlittable(Array arr) => default; // 0x000000018BEC9D94-0x000000018BEC9DD0
		internal static bool IsGenericListBlittable<T>()
			where T : struct => default;
		internal static string GetReasonForArrayNonBlittable(Array arr) => default; // 0x000000018BEC9BB4-0x000000018BEC9C08
		internal static string GetReasonForGenericListNonBlittable<T>()
			where T : struct => default;
		public static bool IsUnmanaged<T>() => default;
		public static int AlignOf<T>()
			where T : struct => default;
		public static unsafe void CopyPtrToStructure<T>(void* ptr, out ref T output)
			where T : struct {
			output = default;
		}
		private static unsafe void InternalCopyPtrToStructure<T>(void* ptr, out ref T output)
			where T : struct {
			output = default;
		}
		public static unsafe void CopyStructureToPtr<T>(ref ref T input, void* ptr)
			where T : struct {}
		private static unsafe void InternalCopyStructureToPtr<T>(ref ref T input, void* ptr)
			where T : struct {}
		public static unsafe T ReadArrayElement<T>(void* source, int index) => default;
		public static unsafe T ReadArrayElementWithStride<T>(void* source, int index, int stride) => default;
		public static unsafe void WriteArrayElement<T>(void* destination, int index, T value) {}
		public static unsafe void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value) {}
		public static unsafe void* AddressOf<T>(ref ref T output)
			where T : struct => default;
		public static int SizeOf<T>()
			where T : struct => default;
		public static ref ref T As<U, T>(ref ref U from) => ref _refReturnTypeForAs;
		private ref T _refReturnTypeForAs; // Dummy field
		public static unsafe ref ref T AsRef<T>(void* ptr)
			where T : struct => ref _refReturnTypeForAsRef;
		private ref T _refReturnTypeForAsRef; // Dummy field
		public static unsafe ref ref T ArrayElementAsRef<T>(void* ptr, int index)
			where T : struct => ref _refReturnTypeForArrayElementAsRef;
		private ref T _refReturnTypeForArrayElementAsRef; // Dummy field
		public static int EnumToInt<T>(T enumValue)
			where T : struct, IConvertible => default;
		private static void InternalEnumToInt<T>(ref ref T enumValue, ref int intValue) {}
		public static bool EnumEquals<T>(T lhs, T rhs)
			where T : struct, IConvertible => default;
	}
}

namespace Unity.IL2CPP.CompilerServices
{
	internal class Il2CppEagerStaticClassConstructionAttribute : Attribute // TypeDefIndex: 47238
	{
		// Constructors
		public Il2CppEagerStaticClassConstructionAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.IO.LowLevel.Unsafe
{
	public struct ReadCommand // TypeDefIndex: 47239
	{
		// Fields
		public unsafe void* Buffer; // 0x00
		public long Offset; // 0x08
		public long Size; // 0x10
	}

	public enum FileState // TypeDefIndex: 47240
	{
		Absent = 0,
		Exists = 1
	}

	public enum AssetLoadingSubsystem // TypeDefIndex: 47241
	{
		Other = 0,
		Texture = 1,
		VirtualTexture = 2,
		Mesh = 3,
		Audio = 4,
		Scripts = 5,
		EntitiesScene = 6,
		EntitiesStreamBinaryReader = 7,
		FileInfo = 8
	}

	public enum ReadStatus // TypeDefIndex: 47242
	{
		Complete = 0,
		InProgress = 1,
		Failed = 2,
		Truncated = 4,
		Canceled = 5
	}

	public enum Priority // TypeDefIndex: 47243
	{
		PriorityLow = 0,
		PriorityHigh = 1
	}

	public struct ReadHandle : IDisposable // TypeDefIndex: 47244
	{
		// Fields
		internal IntPtr ptr; // 0x00
		internal int version; // 0x08
	
		// Properties
		public JobHandle JobHandle { get => default; } // 0x00000001847C5830-0x00000001847C58D0 
		public ReadStatus Status { get => default; } // 0x00000001847C5C60-0x00000001847C5D60 
	
		// Methods
		public bool IsValid() => default; // 0x0000000186471AF8-0x0000000186471B18
		public void Dispose() {} // 0x00000001847C5680-0x00000001847C5710
		private static ReadStatus GetReadStatus(ReadHandle handle) => default; // 0x000000018647011C-0x000000018647012C
		private static void ReleaseReadHandle(ReadHandle handle) {} // 0x000000018647013C-0x000000018647014C
		private static bool IsReadHandleValid(ReadHandle handle) => default; // 0x000000018647012C-0x000000018647013C
		private static JobHandle GetJobHandle(ReadHandle handle) => default; // 0x00000001847C58D0-0x00000001847C5930
		private static ReadStatus GetReadStatus_Injected(ref ReadHandle handle) => default; // 0x0000000185190DD0-0x0000000185190E10
		private static void ReleaseReadHandle_Injected(ref ReadHandle handle) {} // 0x00000001853E0C30-0x00000001853E0C70
		private static bool IsReadHandleValid_Injected(ref ReadHandle handle) => default; // 0x0000000185030950-0x0000000185030990
		private static void GetJobHandle_Injected(ref ReadHandle handle, out JobHandle ret) {
			ret = default;
		} // 0x00000001847C5930-0x00000001847C5980
	}

	public static class AsyncReadManager // TypeDefIndex: 47245
	{
		// Methods
		private static unsafe ReadHandle ReadInternal(string filename, void* cmds, uint cmdCount, string assetName, ulong typeID, AssetLoadingSubsystem subsystem) => default; // 0x0000000184AD1110-0x0000000184AD11B0
		public static unsafe ReadHandle Read(string filename, ReadCommand* readCmds, uint readCmdCount, string assetName = "" /* Metadata: 0x020602D8 */, ulong typeID = 0 /* Metadata: 0x020602D9 */, AssetLoadingSubsystem subsystem = AssetLoadingSubsystem.Scripts /* Metadata: 0x020602E1 */) => default; // 0x0000000184AD1060-0x0000000184AD1110
		private static unsafe void ReadInternal_Injected(string filename, void* cmds, uint cmdCount, string assetName, ulong typeID, AssetLoadingSubsystem subsystem, out ReadHandle ret) {
			ret = default;
		} // 0x0000000184AD11B0-0x0000000184AD1220
	}

	public enum ProcessingState // TypeDefIndex: 47246
	{
		Unknown = 0,
		InQueue = 1,
		Reading = 2,
		Completed = 3,
		Failed = 4,
		Canceled = 5
	}

	public enum FileReadType // TypeDefIndex: 47247
	{
		Sync = 0,
		Async = 1
	}

	public struct AsyncReadManagerRequestMetric // TypeDefIndex: 47248
	{
		// Fields
		private readonly string _AssetName_k__BackingField; // 0x00
		private readonly string _FileName_k__BackingField; // 0x08
		private readonly ulong _OffsetBytes_k__BackingField; // 0x10
		private readonly ulong _SizeBytes_k__BackingField; // 0x18
		private readonly ulong _AssetTypeId_k__BackingField; // 0x20
		private readonly ulong _CurrentBytesRead_k__BackingField; // 0x28
		private readonly uint _BatchReadCount_k__BackingField; // 0x30
		private readonly bool _IsBatchRead_k__BackingField; // 0x34
		private readonly ProcessingState _State_k__BackingField; // 0x38
		private readonly FileReadType _ReadType_k__BackingField; // 0x3C
		private readonly Priority _PriorityLevel_k__BackingField; // 0x40
		private readonly AssetLoadingSubsystem _Subsystem_k__BackingField; // 0x44
		private readonly double _RequestTimeMicroseconds_k__BackingField; // 0x48
		private readonly double _TimeInQueueMicroseconds_k__BackingField; // 0x50
		private readonly double _TotalTimeMicroseconds_k__BackingField; // 0x58
	}

	public class AsyncReadManagerMetricsFilters // TypeDefIndex: 47249
	{
		// Fields
		internal ulong[] TypeIDs; // 0x10
		internal ProcessingState[] States; // 0x18
		internal FileReadType[] ReadTypes; // 0x20
		internal Priority[] PriorityLevels; // 0x28
		internal AssetLoadingSubsystem[] Subsystems; // 0x30
	
		// Constructors
		public AsyncReadManagerMetricsFilters() {} // Dummy constructor
	}
}

namespace Unity.Jobs
{
	public interface IJob // TypeDefIndex: 47216
	{
		// Methods
		void Execute();
	}

	public static class IJobExtensions // TypeDefIndex: 47219
	{
		// Nested types
		internal struct JobStruct<T> // TypeDefIndex: 47218
			where T : struct, IJob
		{
			// Fields
			internal static readonly BurstLike.SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 47217; 0x00000000-0x00000000
	
			// Constructors
			static JobStruct() {
				jobReflectionData = default;
			}
	
			// Methods
			internal static void Initialize() {}
			public static void Execute(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	
		// Methods
		public static void EarlyJobInit<T>()
			where T : struct, IJob {}
		private static IntPtr GetReflectionData<T>()
			where T : struct, IJob => default;
		public static JobHandle Schedule<T>(T jobData, JobHandle dependsOn = default)
			where T : struct, IJob => default;
		public static void Run<T>(T jobData)
			where T : struct, IJob {}
		public static JobHandle ScheduleManagedCrossFrameJob<T>(T jobData, JobQueuePriority priority, JobHandle dependsOn = default)
			where T : struct, IJob => default;
	}

	public interface IJobFor // TypeDefIndex: 47220
	{
		// Methods
		void Execute(int index);
	}

	public static class IJobForExtensions // TypeDefIndex: 47223
	{
		// Nested types
		internal struct ForJobStruct<T> // TypeDefIndex: 47222
			where T : struct, IJobFor
		{
			// Fields
			internal static readonly BurstLike.SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			public delegate void ExecuteJobFunction(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 47221; 0x00000000-0x00000000
	
			// Constructors
			static ForJobStruct() {
				jobReflectionData = default;
			}
	
			// Methods
			internal static void Initialize() {}
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	
		// Methods
		public static void EarlyJobInit<T>()
			where T : struct, IJobFor {}
		private static IntPtr GetReflectionData<T>()
			where T : struct, IJobFor => default;
		public static JobHandle ScheduleParallel<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependency)
			where T : struct, IJobFor => default;
	}

	public interface IJobParallelFor // TypeDefIndex: 47224
	{
		// Methods
		void Execute(int index);
	}

	public static class IJobParallelForExtensions // TypeDefIndex: 47227
	{
		// Nested types
		internal struct ParallelForJobStruct<T> // TypeDefIndex: 47226
			where T : struct, IJobParallelFor
		{
			// Fields
			public static readonly IntPtr jobReflectionData;
	
			// Nested types
			public delegate void ExecuteJobFunction(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 47225; 0x00000000-0x00000000
	
			// Constructors
			static ParallelForJobStruct() {
				jobReflectionData = default;
			}
	
			// Methods
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	
		// Methods
		public static JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelFor => default;
		public static void Run<T>(T jobData, int arrayLength)
			where T : struct, IJobParallelFor {}
	}

	public struct JobHandle : IEquatable<JobHandle> // TypeDefIndex: 47228
	{
		// Fields
		internal ulong jobGroup; // 0x00
		internal int jobType; // 0x08
	
		// Properties
		public bool IsCompleted { get => default; } // 0x000000018647014C-0x0000000186470158 
	
		// Methods
		public void Complete() {} // 0x0000000184407960-0x00000001844079B0
		public void CrossFrameComplete() {} // 0x00000001844875B0-0x00000001844875F0
		public bool IsValid() => default; // 0x00000001844522F0-0x0000000184452300
		public static void CompleteAll(NativeArray<JobHandle> jobs) {} // 0x00000001846B3360-0x00000001846B33A0
		public static void ScheduleBatchedJobs() {} // 0x00000001846B33F0-0x00000001846B3430
		private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) {} // 0x00000001844079B0-0x00000001844079F0
		private static void ScheduleBatchedCrossFrameJobsAndComplete(ref JobHandle job) {} // 0x000000018502BC80-0x000000018502BCC0
		private static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job) => default; // 0x0000000185142680-0x00000001851426C0
		private static unsafe void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count) {} // 0x00000001846B33A0-0x00000001846B33F0
		public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) => default; // 0x00000001843ED490-0x00000001843ED510
		public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1, JobHandle job2) => default; // 0x0000000184821710-0x00000001848217A0
		public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs) => default; // 0x0000000184D39A30-0x0000000184D39AC0
		private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) => default; // 0x00000001843ED510-0x00000001843ED580
		private static JobHandle CombineDependenciesInternal3(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2) => default; // 0x00000001848217A0-0x0000000184821820
		internal static unsafe JobHandle CombineDependenciesInternalPtr(void* jobs, int count) => default; // 0x0000000184D39AC0-0x0000000184D39B30
		public bool Equals(JobHandle other) => default; // 0x0000000188095DD0-0x0000000188095DDC
		private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) {
			ret = default;
		} // 0x00000001843ED580-0x00000001843ED5E0
		private static void CombineDependenciesInternal3_Injected(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2, out JobHandle ret) {
			ret = default;
		} // 0x0000000184821820-0x0000000184821890
		private static unsafe void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret) {
			ret = default;
		} // 0x0000000184D39B30-0x0000000184D39B90
	}
}

namespace Unity.Jobs.LowLevel.Unsafe
{
	public struct BatchQueryJob<CommandT, ResultT> // TypeDefIndex: 47229
		where CommandT : struct
		where ResultT : struct
	{
		// Fields
		internal NativeArray<CommandT> commands;
		internal NativeArray<ResultT> results;
	
		// Constructors
		public BatchQueryJob(NativeArray<CommandT> commands, NativeArray<ResultT> results) {
			this.commands = default;
			this.results = default;
		}
	}

	public struct BatchQueryJobStruct<T> // TypeDefIndex: 47230
		where T : struct
	{
		// Fields
		internal static IntPtr jobReflectionData;
	
		// Methods
		public static IntPtr Initialize() => default;
	}

	public sealed class JobProducerTypeAttribute : Attribute // TypeDefIndex: 47231
	{
		// Fields
		private readonly System.Type _ProducerType_k__BackingField; // 0x10
	
		// Constructors
		public JobProducerTypeAttribute() {} // Dummy constructor
		public JobProducerTypeAttribute(System.Type producerType) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public struct JobRanges // TypeDefIndex: 47232
	{
		// Fields
		internal int BatchSize; // 0x00
		internal int NumJobs; // 0x04
		public int TotalIterationCount; // 0x08
		internal IntPtr StartEndIndex; // 0x10
	}

	public enum ScheduleMode // TypeDefIndex: 47233
	{
		Run = 0,
		Batched = 1,
		Parallel = 1,
		Single = 2
	}

	public enum JobQueuePriority // TypeDefIndex: 47234
	{
		NormalJobPriority = 0,
		HighJobPriority = 1
	}

	public static class JobsUtility // TypeDefIndex: 47237
	{
		// Fields
		internal static PanicFunction_ PanicFunction; // 0x00
	
		// Properties
		public static bool IsExecutingJob { get; } // 0x0000000184E75020-0x0000000184E75060 
		public static bool JobCompilerEnabled { get; set; } // 0x000000018646DB7C-0x000000018646DB88
		public static int JobWorkerMaximumCount { get; } // 0x0000000184728D90-0x0000000184728DE0 
		public static int JobWorkerCount { get; } // 0x0000000184728CD0-0x0000000184728D30 
	
		// Nested types
		public struct JobScheduleParameters // TypeDefIndex: 47235
		{
			// Fields
			public JobHandle Dependency; // 0x00
			public int ScheduleMode; // 0x10
			public IntPtr ReflectionData; // 0x18
			public IntPtr JobDataPtr; // 0x20
	
			// Constructors
			public unsafe JobScheduleParameters(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) {
				Dependency = default;
				ScheduleMode = default;
				ReflectionData = default;
				JobDataPtr = default;
			} // 0x0000000185FE6840-0x0000000185FE6860
		}
	
		internal delegate void PanicFunction_(); // TypeDefIndex: 47236; 0x0000000184728D30-0x0000000184728D90
	
		// Methods
		public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) {
			beginIndex = default;
			endIndex = default;
		} // 0x0000000184728C60-0x0000000184728CD0
		public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) {
			beginIndex = default;
			endIndex = default;
			return default;
		} // 0x000000018BEC58EC-0x000000018BEC591C
		public static JobHandle Schedule(ref JobScheduleParameters parameters) => default; // 0x0000000184A42300-0x0000000184A42380
		public static JobHandle ScheduleCrossFrameJob(ref JobScheduleParameters parameters, JobQueuePriority priority) => default; // 0x0000000184A423F0-0x0000000184A42470
		public static JobHandle ScheduleJobCrossFrameJobTransformReadOnly(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray) => default; // 0x0000000184BB4E80-0x0000000184BB4EF0
		public static JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) => default; // 0x0000000184BB53F0-0x0000000184BB5470
		public static unsafe JobHandle ScheduleParallelForDeferArraySize(ref JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle) => default; // 0x0000000184FA1680-0x0000000184FA16F0
		public static JobHandle ScheduleParallelForTransform(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray) => default; // 0x0000000184FA1650-0x0000000184FA1680
		public static JobHandle ScheduleParallelForTransformReadOnly(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray, int innerloopBatchCount) => default; // 0x000000018BEC5830-0x000000018BEC5850
		private static IntPtr CreateJobReflectionData(System.Type wrapperJobType, System.Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) => default; // 0x000000018BEC591C-0x000000018BEC5948
		public static IntPtr CreateJobReflectionData(System.Type type, object managedJobFunction0, object managedJobFunction1 = null, object managedJobFunction2 = null) => default; // 0x0000000185B3F6A0-0x0000000185B3F6E0
		public static IntPtr CreateJobReflectionData(System.Type wrapperJobType, System.Type userJobType, object managedJobFunction0) => default; // 0x0000000184E37340-0x0000000184E37380
		private static int GetJobQueueWorkerThreadCount() => default; // 0x000000018BEC5850-0x000000018BEC5898
		private static void InvokePanicFunction() {} // 0x000000018BEC5898-0x000000018BEC58EC
		private static void Schedule_Injected(ref JobScheduleParameters parameters, out JobHandle ret) {
			ret = default;
		} // 0x0000000184A42380-0x0000000184A423F0
		private static void ScheduleCrossFrameJob_Injected(ref JobScheduleParameters parameters, JobQueuePriority priority, out JobHandle ret) {
			ret = default;
		} // 0x0000000184A42470-0x0000000184A424E0
		private static void ScheduleJobCrossFrameJobTransformReadOnly_Injected(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) {
			ret = default;
		} // 0x0000000184BB4EF0-0x0000000184BB4F50
		private static void ScheduleParallelFor_Injected(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) {
			ret = default;
		} // 0x0000000184BB5470-0x0000000184BB54E0
		private static unsafe void ScheduleParallelForDeferArraySize_Injected(ref JobScheduleParameters parameters, int innerloopBatchCount, void* listData, void* listDataAtomicSafetyHandle, out JobHandle ret) {
			ret = default;
		} // 0x0000000185FE6820-0x0000000185FE6840
		private static void ScheduleParallelForTransform_Injected(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) {
			ret = default;
		} // 0x00000001864BC330-0x00000001864BC3F4
		private static void ScheduleParallelForTransformReadOnly_Injected(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray, int innerloopBatchCount, out JobHandle ret) {
			ret = default;
		} // 0x00000001864BC320-0x00000001864BC330
	}
}

namespace Unity.Profiling
{
	public struct ProfilerCategory // TypeDefIndex: 47198
	{
		// Fields
		private readonly ushort m_CategoryId; // 0x00
	
		// Properties
		public string Name { get => default; } // 0x000000018BEC5F58-0x000000018BEC5F9C 
		public static ProfilerCategory Scripts { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
		public static ProfilerCategory Audio { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		internal ProfilerCategory(ushort category) : this() {
			m_CategoryId = default;
		} // 0x0000000185FB0F40-0x0000000185FB0F50
	
		// Methods
		public override string ToString() => default; // 0x000000018BEC5F4C-0x000000018BEC5F58
		public static implicit operator ushort(ProfilerCategory category) => default; // 0x0000000185FE69A0-0x0000000185FE69B0
	}

	public struct ProfilerMarker // TypeDefIndex: 47200
	{
		// Fields
		[NonSerialized]
		internal readonly IntPtr m_Ptr; // 0x00
	
		// Properties
		public IntPtr Handle { get => default; } // 0x000000018BEC5F9C-0x000000018BEC5FC4 
	
		// Nested types
		public struct AutoScope : IDisposable // TypeDefIndex: 47199
		{
			// Fields
			internal readonly IntPtr m_Ptr; // 0x00
	
			// Constructors
			internal AutoScope(IntPtr markerPtr) {
				m_Ptr = default;
			} // 0x00000001834AFB60-0x00000001834AFB70
	
			// Methods
			public void Dispose() {} // 0x0000000186470380-0x00000001864703B0
		}
	
		// Constructors
		public ProfilerMarker(string name) : this() {
			m_Ptr = default;
		} // 0x0000000183FEFB00-0x0000000183FEFB30
		public ProfilerMarker(ProfilerCategory category, string name) : this() {
			m_Ptr = default;
		} // 0x0000000183FEFB50-0x0000000183FEFB70
	
		// Methods
		public AutoScope Auto() => default; // 0x0000000183FEFB30-0x0000000183FEFB50
	}

	public enum ProfilerMarkerDataUnit : byte // TypeDefIndex: 47201
	{
		Undefined = 0,
		TimeNanoseconds = 1,
		Bytes = 2,
		Count = 3,
		Percent = 4,
		FrequencyHz = 5
	}

	public enum ProfilerCounterOptions : ushort // TypeDefIndex: 47202
	{
		None = 0,
		FlushOnEndOfFrame = 2,
		ResetToZeroOnFlush = 4
	}

	public enum ProfilerRecorderOptions // TypeDefIndex: 47203
	{
		None = 0,
		StartImmediately = 1,
		KeepAliveDuringDomainReload = 2,
		CollectOnlyOnCurrentThread = 4,
		WrapAroundWhenCapacityReached = 8,
		SumAllSamplesInFrame = 16,
		Default = 24,
		GpuRecorder = 64
	}

	public struct ProfilerRecorderSample // TypeDefIndex: 47204
	{
		// Fields
		private long value; // 0x00
		private long count; // 0x08
		private long refValue; // 0x10
	
		// Properties
		public long Count { get => default; } // 0x000000018357A260-0x000000018357A270 
	}

	public struct ProfilerRecorder : IDisposable // TypeDefIndex: 47207
	{
		// Fields
		internal ulong handle; // 0x00
		internal const ProfilerRecorderOptions SharedRecorder = (ProfilerRecorderOptions) 128; // Metadata: 0x0206029C
	
		// Properties
		public bool Valid { get => default; } // 0x0000000185225C90-0x0000000185225CC0 
		public long LastValue { get => default; } // 0x000000018BEC6238-0x000000018BEC6264 
		public int Count { get => default; } // 0x000000018BEC61DC-0x000000018BEC620C 
		public bool IsRunning { get => default; } // 0x000000018BEC620C-0x000000018BEC6238 
	
		// Nested types
		internal enum ControlOptions // TypeDefIndex: 47205
		{
			Start = 0,
			Stop = 1,
			Reset = 2,
			Release = 4,
			SetFilterToCurrentThread = 5,
			SetToCollectFromAllThreads = 6
		}
	
		internal enum CountOptions // TypeDefIndex: 47206
		{
			Count = 0,
			MaxCount = 1
		}
	
		// Constructors
		public ProfilerRecorder(ProfilerRecorderHandle statHandle, int capacity = 1 /* Metadata: 0x0206029A */, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default /* Metadata: 0x0206029B */) : this() {
			handle = default;
		} // 0x0000000186471DB4-0x0000000186471DE0
	
		// Methods
		public void Start() {} // 0x000000018BEC61AC-0x000000018BEC61DC
		public void Stop() {} // 0x0000000185225C40-0x0000000185225C70
		public ProfilerRecorderSample GetSample(int index) => default; // 0x000000018BEC6148-0x000000018BEC61AC
		private static ProfilerRecorder Create(ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options) => default; // 0x00000001852B4310-0x00000001852B4380
		private static void Control(ProfilerRecorder handle, ControlOptions options) {} // 0x0000000186473860-0x000000018647387C
		private static long GetLastValue(ProfilerRecorder handle) => default; // 0x000000018BEC6054-0x000000018BEC6070
		private static int GetCount(ProfilerRecorder handle, CountOptions countOptions) => default; // 0x000000018BEC6004-0x000000018BEC6020
		private static bool GetValid(ProfilerRecorder handle) => default; // 0x000000018647387C-0x0000000186473898
		private static bool GetRunning(ProfilerRecorder handle) => default; // 0x000000018BEC60A4-0x000000018BEC60C0
		private static ProfilerRecorderSample GetSampleInternal(ProfilerRecorder handle, int index) => default; // 0x000000018BEC6110-0x000000018BEC6148
		public void Dispose() {} // 0x0000000185225BB0-0x0000000185225BF0
		private void CheckInitializedAndThrow() {} // 0x0000000185225C70-0x0000000185225C90
		private static void Create_Injected(ref ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options, out ProfilerRecorder ret) {
			ret = default;
		} // 0x00000001852B4380-0x00000001852B43F0
		private static void Control_Injected(ref ProfilerRecorder handle, ControlOptions options) {} // 0x0000000185422750-0x00000001854227A0
		private static long GetLastValue_Injected(ref ProfilerRecorder handle) => default; // 0x000000018BEC6020-0x000000018BEC6054
		private static int GetCount_Injected(ref ProfilerRecorder handle, CountOptions countOptions) => default; // 0x000000018BEC5FC4-0x000000018BEC6004
		private static bool GetValid_Injected(ref ProfilerRecorder handle) => default; // 0x0000000185673A20-0x0000000185673A60
		private static bool GetRunning_Injected(ref ProfilerRecorder handle) => default; // 0x000000018BEC6070-0x000000018BEC60A4
		private static void GetSampleInternal_Injected(ref ProfilerRecorder handle, int index, out ProfilerRecorderSample ret) {
			ret = default;
		} // 0x000000018BEC60C0-0x000000018BEC6110
	}

	internal sealed class ProfilerRecorderDebugView // TypeDefIndex: 47208
	{
		// Constructors
		public ProfilerRecorderDebugView() {} // Dummy constructor
	}
}

namespace Unity.Profiling.LowLevel
{
	public enum MarkerFlags : ushort // TypeDefIndex: 47209
	{
		Default = 0,
		Script = 2,
		AvailabilityEditor = 4,
		AvailabilityNonDevelopment = 8,
		Warning = 16,
		ScriptInvoke = 32,
		ScriptDeepProfiler = 64,
		Counter = 128,
		SampleGPU = 256
	}

	public enum ProfilerMarkerDataType : byte // TypeDefIndex: 47210
	{
		Int32 = 2,
		UInt32 = 3,
		Int64 = 4,
		UInt64 = 5,
		Float = 6,
		Double = 7,
		String16 = 9,
		Blob8 = 11
	}
}

namespace Unity.Profiling.LowLevel.Unsafe
{
	public struct ProfilerRecorderDescription // TypeDefIndex: 47211
	{
		// Fields
		private readonly ProfilerCategory category; // 0x00
		private readonly MarkerFlags flags; // 0x02
		private readonly ProfilerMarkerDataType dataType; // 0x04
		private readonly ProfilerMarkerDataUnit unitType; // 0x05
		private readonly int reserved0; // 0x08
		private readonly int nameUtf8Len; // 0x0C
		private readonly unsafe byte* nameUtf8; // 0x10
	
		// Properties
		public MarkerFlags Flags { get => default; } // 0x0000000182FA7E50-0x0000000182FA7E60 
	}

	public struct ProfilerRecorderHandle // TypeDefIndex: 47212
	{
		// Fields
		internal readonly ulong handle; // 0x00
	
		// Properties
		public bool Valid { get => default; } // 0x0000000184B30F50-0x0000000184B30F70 
	
		// Constructors
		internal ProfilerRecorderHandle(ulong handle) : this() {
			this.handle = default;
		} // 0x0000000185FB2BB0-0x0000000185FB2BC0
	
		// Methods
		public static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle) => default; // 0x0000000184B30E80-0x0000000184B30F10
		private static ProfilerRecorderDescription GetDescriptionInternal(ProfilerRecorderHandle handle) => default; // 0x0000000184B30F10-0x0000000184B30F50
		private static void GetDescriptionInternal_Injected(ref ProfilerRecorderHandle handle, out ProfilerRecorderDescription ret) {
			ret = default;
		} // 0x0000000184B30F70-0x0000000184B30FC0
	}

	public struct ProfilerMarkerData // TypeDefIndex: 47213
	{
		// Fields
		public byte Type; // 0x00
		private readonly byte reserved0; // 0x01
		private readonly ushort reserved1; // 0x02
		public uint Size; // 0x04
		public unsafe void* Ptr; // 0x08
	}

	public struct ProfilerCategoryDescription // TypeDefIndex: 47214
	{
		// Fields
		public readonly ushort Id; // 0x00
		public readonly ushort Flags; // 0x02
		public readonly Color32 Color; // 0x04
		private readonly int reserved0; // 0x08
		public readonly int NameUtf8Len; // 0x0C
		public readonly unsafe byte* NameUtf8; // 0x10
	}

	public static class ProfilerUnsafeUtility // TypeDefIndex: 47215
	{
		// Methods
		public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId) => default; // 0x000000018BEC6360-0x000000018BEC6390
		public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount) => default; // 0x0000000184B30D30-0x0000000184B30DA0
		public static void BeginSample(IntPtr markerPtr) {} // 0x000000018BEC62B4-0x000000018BEC62E8
		public static unsafe void BeginSampleWithMetadata(IntPtr markerPtr, int metadataCount, void* metadata) {} // 0x000000018BEC6264-0x000000018BEC62B4
		public static void EndSample(IntPtr markerPtr) {} // 0x000000018BEC62E8-0x000000018BEC631C
		internal static unsafe string Utf8ToString(byte* chars, int charsLen) => default; // 0x000000018BEC6390-0x000000018BEC644C
		private static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret) {
			ret = default;
		} // 0x000000018BEC631C-0x000000018BEC6360
	}
}

namespace UnityEngine
{
	public enum SendMessageOptions // TypeDefIndex: 47306
	{
		RequireReceiver = 0,
		DontRequireReceiver = 1
	}

	public enum PrimitiveType // TypeDefIndex: 47307
	{
		Sphere = 0,
		Capsule = 1,
		Cylinder = 2,
		Cube = 3,
		Plane = 4,
		Quad = 5
	}

	public enum Space // TypeDefIndex: 47308
	{
		World = 0,
		Self = 1
	}

	public enum RuntimePlatform // TypeDefIndex: 47309
	{
		GameCoreScarlett = -1,
		OSXEditor = 0,
		OSXPlayer = 1,
		WindowsPlayer = 2,
		OSXWebPlayer = 3,
		OSXDashboardPlayer = 4,
		WindowsWebPlayer = 5,
		WindowsEditor = 7,
		IPhonePlayer = 8,
		PS3 = 9,
		XBOX360 = 10,
		Android = 11,
		NaCl = 12,
		LinuxPlayer = 13,
		FlashPlayer = 15,
		LinuxEditor = 16,
		WebGLPlayer = 17,
		MetroPlayerX86 = 18,
		WSAPlayerX86 = 18,
		MetroPlayerX64 = 19,
		WSAPlayerX64 = 19,
		MetroPlayerARM = 20,
		WSAPlayerARM = 20,
		WP8Player = 21,
		BlackBerryPlayer = 22,
		TizenPlayer = 23,
		PSP2 = 24,
		PS4 = 25,
		PSM = 26,
		XboxOne = 27,
		SamsungTVPlayer = 28,
		WiiU = 30,
		tvOS = 31,
		Switch = 32,
		Lumin = 33,
		Stadia = 34,
		CloudRendering = 35,
		GameCoreXboxSeries = 36,
		GameCoreXboxOne = 37,
		PS5 = 38,
		EmbeddedLinuxArm64 = 39,
		EmbeddedLinuxArm32 = 40,
		EmbeddedLinuxX64 = 41,
		EmbeddedLinuxX86 = 42,
		LinuxServer = 43,
		WindowsServer = 44,
		OSXServer = 45
	}

	public enum SystemLanguage // TypeDefIndex: 47310
	{
		Afrikaans = 0,
		Arabic = 1,
		Basque = 2,
		Belarusian = 3,
		Bulgarian = 4,
		Catalan = 5,
		Chinese = 6,
		Czech = 7,
		Danish = 8,
		Dutch = 9,
		English = 10,
		Estonian = 11,
		Faroese = 12,
		Finnish = 13,
		French = 14,
		German = 15,
		Greek = 16,
		Hebrew = 17,
		Hungarian = 18,
		Icelandic = 19,
		Indonesian = 20,
		Italian = 21,
		Japanese = 22,
		Korean = 23,
		Latvian = 24,
		Lithuanian = 25,
		Norwegian = 26,
		Polish = 27,
		Portuguese = 28,
		Romanian = 29,
		Russian = 30,
		SerboCroatian = 31,
		Slovak = 32,
		Slovenian = 33,
		Spanish = 34,
		Swedish = 35,
		Thai = 36,
		Turkish = 37,
		Ukrainian = 38,
		Vietnamese = 39,
		ChineseSimplified = 40,
		ChineseTraditional = 41,
		Unknown = 42
	}

	public enum LogType // TypeDefIndex: 47311
	{
		Critical = 0,
		Error = 1,
		Assert = 2,
		Warning = 3,
		Log = 4,
		Exception = 5
	}

	public enum LogOption // TypeDefIndex: 47312
	{
		None = 0,
		NoStacktrace = 1
	}

	public enum ThreadPriority // TypeDefIndex: 47313
	{
		Low = 0,
		BelowNormal = 1,
		Normal = 2,
		High = 4
	}

	public struct SortingLayer // TypeDefIndex: 47314
	{
		// Fields
		private int m_Id; // 0x00
	
		// Properties
		public string name { get => default; } // 0x000000018BEC9B40-0x000000018BEC9B4C 
		public static SortingLayer[] layers { get => default; } // 0x000000018BEC9ABC-0x000000018BEC9B40 
	
		// Methods
		private static int[] GetSortingLayerIDsInternal() => default; // 0x000000018BEC99F4-0x000000018BEC9A20
		public static int GetLayerValueFromID(int id) => default; // 0x000000018BEC99C0-0x000000018BEC99F4
		public static int NameToID(string name) => default; // 0x000000018BEC9A88-0x000000018BEC9ABC
		public static string IDToName(int id) => default; // 0x000000018BEC9A20-0x000000018BEC9A54
		public static bool IsValid(int id) => default; // 0x000000018BEC9A54-0x000000018BEC9A88
	}

	public enum WeightedMode // TypeDefIndex: 47315
	{
		None = 0,
		In = 1,
		Out = 2,
		Both = 3
	}

	public struct Keyframe // TypeDefIndex: 47316
	{
		// Fields
		private float m_Time; // 0x00
		private float m_Value; // 0x04
		private float m_InTangent; // 0x08
		private float m_OutTangent; // 0x0C
		private int m_WeightedMode; // 0x10
		private float m_InWeight; // 0x14
		private float m_OutWeight; // 0x18
	
		// Properties
		public float time { get => default; set {} } // 0x0000000185FE6770-0x0000000185FE6780 0x0000000185FBA160-0x0000000185FBA170
		public float value { get => default; set {} } // 0x0000000185FE64E0-0x0000000185FE64F0 0x0000000185FBA180-0x0000000185FBA190
		public float inTangent { get => default; set {} } // 0x0000000185FE64D0-0x0000000185FE64E0 0x0000000185FBA170-0x0000000185FBA180
		public float outTangent { get => default; set {} } // 0x0000000185FE66F0-0x0000000185FE6700 0x0000000185FBF770-0x0000000185FBF780
		public float inWeight { get => default; set {} } // 0x0000000185FC40E0-0x0000000185FC40F0 0x0000000181A6E390-0x0000000181A6FA00
		public float outWeight { get => default; set {} } // 0x0000000185FE68F0-0x0000000185FE6900 0x0000000181C9A5A0-0x0000000181C9A5B0
		public WeightedMode weightedMode { get => default; set {} } // 0x0000000185FE6790-0x0000000185FE67A0 0x0000000181378230-0x0000000181378240
		public int tangentMode { get => default; set {} } // 0x0000000185FE67B0-0x0000000185FE67C0 0x0000000185492010-0x0000000185492020
		internal int tangentModeInternal { get => default; set {} } // 0x0000000185FE67B0-0x0000000185FE67C0 0x0000000185492010-0x0000000185492020
	
		// Constructors
		public Keyframe(float time, float value) : this() {
			m_Time = default;
			m_Value = default;
			m_InTangent = default;
			m_OutTangent = default;
			m_WeightedMode = default;
			m_InWeight = default;
			m_OutWeight = default;
		} // 0x0000000185FE68D0-0x0000000185FE68F0
		public Keyframe(float time, float value, float inTangent, float outTangent) : this() {
			m_Time = default;
			m_Value = default;
			m_InTangent = default;
			m_OutTangent = default;
			m_WeightedMode = default;
			m_InWeight = default;
			m_OutWeight = default;
		} // 0x0000000185FE6860-0x0000000185FE6890
		public Keyframe(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight) : this() {
			m_Time = default;
			m_Value = default;
			m_InTangent = default;
			m_OutTangent = default;
			m_WeightedMode = default;
			m_InWeight = default;
			m_OutWeight = default;
		} // 0x0000000185FE6890-0x0000000185FE68D0
	}

	public enum WrapMode // TypeDefIndex: 47317
	{
		Default = 0,
		Once = 1,
		Clamp = 1,
		Loop = 2,
		PingPong = 4,
		ClampForever = 8
	}

	public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 47318
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public Keyframe[] keys { get => default; set {} } // 0x0000000186470C1C-0x0000000186470C28 0x000000018646FD14-0x000000018646FD1C
		public Keyframe this[int index] { get => default; } // 0x0000000184879E80-0x0000000184879F20 
		public int length { get => default; } // 0x00000001845F7CE0-0x00000001845F7D80 
		public UnityEngine.WrapMode preWrapMode { get => default; set {} } // 0x000000018487B460-0x000000018487B4A0 0x00000001847148B0-0x0000000184714900
		public UnityEngine.WrapMode postWrapMode { get => default; set {} } // 0x000000018487B4A0-0x000000018487B4E0 0x0000000184714900-0x0000000184714950
	
		// Constructors
		public AnimationCurve(Keyframe[] keys) {} // 0x00000001847147D0-0x0000000184714820
		public AnimationCurve() {} // 0x0000000184714820-0x0000000184714870
	
		// Methods
		private static void Internal_Destroy(IntPtr ptr) {} // 0x0000000184DFAE10-0x0000000184DFAE50
		private static IntPtr Internal_Create(Keyframe[] keys) => default; // 0x0000000184714870-0x00000001847148B0
		private bool Internal_Equals(IntPtr other) => default; // 0x000000018BEB1A48-0x000000018BEB1A8C
		~AnimationCurve() {} // 0x0000000184DFAD90-0x0000000184DFAE10
		public float Evaluate(float time) => default; // 0x00000001840CE0E0-0x00000001840CE130
		public int AddKey(float time, float value) => default; // 0x0000000185412DB0-0x0000000185412E10
		public int AddKey(Keyframe key) => default; // 0x000000018BEB18EC-0x000000018BEB191C
		private int AddKey_Internal(Keyframe key) => default; // 0x000000018BEB18D8-0x000000018BEB18EC
		public int MoveKey(int index, Keyframe key) => default; // 0x000000018BEB1B30-0x000000018BEB1B44
		public void RemoveKey(int index) {} // 0x000000018BEB1B44-0x000000018BEB1B84
		private void SetKeys(Keyframe[] keys) {} // 0x000000018510CFD0-0x000000018510D020
		public void SetKeys(NativeArray<Keyframe> keys, int count) {} // 0x000000018BEB1B84-0x000000018BEB1BD8
		private void Internal_SetKeysNoGC(IntPtr keys, int count) {} // 0x000000018BEB1A8C-0x000000018BEB1AE0
		private Keyframe GetKey(int index) => default; // 0x0000000184879F20-0x0000000184879F60
		private Keyframe[] GetKeys() => default; // 0x00000001852E04C0-0x00000001852E0500
		public void SmoothTangents(int index, float weight) {} // 0x000000018BEB1BD8-0x000000018BEB1C28
		public static AnimationCurve Constant(float timeStart, float timeEnd, float value) => default; // 0x0000000184B36A40-0x0000000184B36A60
		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) => default; // 0x0000000184714050-0x0000000184714270
		public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) => default; // 0x00000001847132B0-0x0000000184713420
		public override bool Equals(object o) => default; // 0x000000018BEB19AC-0x000000018BEB1A48
		public bool Equals(AnimationCurve other) => default; // 0x000000018BEB191C-0x000000018BEB19AC
		public override int GetHashCode() => default; // 0x0000000185FE6790-0x0000000185FE67A0
		private int AddKey_Internal_Injected(ref Keyframe key) => default; // 0x000000018BEB1894-0x000000018BEB18D8
		private int MoveKey_Injected(int index, ref Keyframe key) => default; // 0x000000018BEB1AE0-0x000000018BEB1B30
		private void GetKey_Injected(int index, out Keyframe ret) {
			ret = default;
		} // 0x0000000184879F60-0x0000000184879FC0
	}

	public sealed class SetRoleInfo // TypeDefIndex: 47319
	{
		// Constructors
		public SetRoleInfo() {} // Dummy constructor
	
		// Methods
		public static void SetRoleInfoParam(string serverId, string roleId) {} // 0x00000001855A7800-0x00000001855A7850
	}

	public class Application // TypeDefIndex: 47323
	{
		// Fields
		private static LowMemoryCallback lowMemory; // 0x00
		private static LogCallback s_LogCallbackHandler; // 0x08
		private static LogCallback s_LogCallbackHandlerThreaded; // 0x10
		internal static AdvertisingIdentifierCallback OnAdvertisingIdentifierCallback; // 0x18
		private static Action<bool> focusChanged; // 0x20
		private static Action<string> deepLinkActivated; // 0x28
		private static Func<bool> wantsToQuit; // 0x30
		private static Action quitting; // 0x38
		private static Action unloading; // 0x40
		private static LogCallback s_RegisterLogCallbackDeprecated; // 0x48
	
		// Properties
		public static bool isLoadingLevel { get => default; } // 0x000000018BEB1DE4-0x000000018BEB1E18 
		public static int streamedBytes { get => default; } // 0x0000000184330090-0x00000001843300D0 
		public static bool webSecurityEnabled { get => default; } // 0x000000018BEB1FF0-0x000000018BEB201C 
		public static bool isPlaying { get => default; } // 0x0000000184955430-0x0000000184955470 
		public static bool isFocused { get => default; } // 0x0000000185FA7740-0x0000000185FA7780 
		public static string buildGUID { get => default; } // 0x000000018BEB32B0-0x000000018BEB32DC 
		public static bool runInBackground { get => default; set {} } // 0x000000018BEB2104-0x000000018BEB2138 0x000000018BEB20A4-0x000000018BEB20D8
		public static bool isBatchMode { get => default; } // 0x00000001844D0650-0x00000001844D0690 
		internal static bool isTestRun { get => default; } // 0x000000018476F1C0-0x000000018476F200 
		internal static bool isHumanControllingUs { get => default; } // 0x00000001850481D0-0x0000000185048210 
		public static string dataPath { get => default; } // 0x000000018BEB2374-0x000000018BEB23A8 
		public static string streamingAssetsPath { get => default; } // 0x0000000184A8F5E0-0x0000000184A8F620 
		public static string persistentDataPath { get => default; } // 0x0000000184260B10-0x0000000184260B50 
		public static string temporaryCachePath { get => default; } // 0x000000018BEB34FC-0x000000018BEB3528 
		public static string absoluteURL { get => default; } // 0x000000018BEB3528-0x000000018BEB3554 
		public static string unityVersion { get => default; } // 0x000000018BEB3554-0x000000018BEB3580 
		public static string unityBuildVersion { get => default; } // 0x000000018BEB35D8-0x000000018BEB3604 
		public static string unityBuildBranch { get => default; } // 0x000000018BEB35AC-0x000000018BEB35D8 
		public static string unityBuildDate { get => default; } // 0x000000018BEB20D8-0x000000018BEB2104 
		public static string unityBuildChangeList { get => default; } // 0x000000018BEB365C-0x000000018BEB3688 
		public static string unityCacheServerNamespace { get => default; } // 0x000000018BEB3604-0x000000018BEB3630 
		public static string unityCacheServerEndpoint { get => default; } // 0x000000018BEB3630-0x000000018BEB365C 
		public static string unityRemoteShaderCacheNamespace { get => default; } // 0x00000001850494F0-0x0000000185049530 
		public static string unityRemoteShaderCacheEndpoint { get => default; } // 0x000000018BEB31FC-0x000000018BEB3228 
		internal static int unityVersionVer { get => default; } // 0x0000000185FA7640-0x0000000185FA7680 
		internal static int unityVersionMaj { get => default; } // 0x0000000185FA7600-0x0000000185FA7640 
		internal static int unityVersionMin { get => default; } // 0x000000018476D5C0-0x000000018476D600 
		public static string version { get => default; } // 0x000000018BEB3178-0x000000018BEB31A4 
		public static string installerName { get => default; } // 0x000000018BEB3334-0x000000018BEB3360 
		public static string identifier { get => default; } // 0x0000000185FA2630-0x0000000185FA2670 
		public static ApplicationInstallMode installMode { get => default; } // 0x000000018BEB3308-0x000000018BEB3334 
		public static ApplicationSandboxType sandboxType { get => default; } // 0x000000018BEB3A20-0x000000018BEB3A54 
		public static string productName { get => default; } // 0x000000018BEB3478-0x000000018BEB34A4 
		public static string companyName { get => default; } // 0x000000018BEB3A54-0x000000018BEB3A88 
		public static bool isRemoveSerializedFileExternalRef { get => default; set {} } // 0x000000018BEB314C-0x000000018BEB3178 0x000000018BEB2D98-0x000000018BEB2DCC
		public static bool isRemoveABPreloadData { get => default; set {} } // 0x000000018BEB2C34-0x000000018BEB2C68 0x000000018BEB1FE8-0x000000018BEB1FF0
		public static bool obsoletePhysicsAPI { get => default; set {} } // 0x00000001840D5D40-0x00000001840D5D80 0x000000018595B580-0x000000018595B5C0
		public static string cloudProjectId { get => default; } // 0x0000000184A90CA0-0x0000000184A90CE0 
		public static int targetFrameRate { get => default; set {} } // 0x000000018BEB2E34-0x000000018BEB2E74 0x000000018BEB31A4-0x000000018BEB31D0
		public static StackTraceLogType stackTraceLogType { get => default; set {} } // 0x0000000183FEACA0-0x0000000183FEACE0 0x0000000185FA76C0-0x0000000185FA7700
		public static string consoleLogPath { get => default; } // 0x000000018BEB2138-0x000000018BEB216C 
		public static UnityEngine.ThreadPriority backgroundLoadingPriority { get => default; set {} } // 0x000000018BEB34D0-0x000000018BEB34FC 0x000000018BEB3360-0x000000018BEB3374
		public static bool genuine { get => default; } // 0x0000000184A17890-0x0000000184A178D0 
		public static bool genuineCheckAvailable { get => default; } // 0x0000000184A15BB0-0x0000000184A15BE0 
		internal static bool submitAnalytics { get => default; } // 0x0000000183FC12F0-0x0000000183FC1330 
		public static bool isShowingSplashScreen { get => default; } // 0x0000000183FC12B0-0x0000000183FC12F0 
		public static RuntimePlatform platform { get => default; } // 0x000000018BEB31D0-0x000000018BEB31FC 
		public static bool isMobilePlatform { get => default; } // 0x0000000184B2C8C0-0x0000000184B2C970 
		public static bool isConsolePlatform { get => default; } // 0x0000000184B2C810-0x0000000184B2C8C0 
		public static bool isCloudGame { get => default; } // 0x000000018BEB1D48-0x000000018BEB1D90 
		public static SystemLanguage systemLanguage { get => default; } // 0x0000000184A90AF0-0x0000000184A90BC0 
		public static NetworkReachability internetReachability { get => default; } // 0x0000000185F0D790-0x0000000185F0D860 
		public static bool enableHGFramePacing { get => default; } // 0x0000000184A90BC0-0x0000000184A90CA0 
		public static bool isPlayer { get => default; } // 0x0000000184D549B0-0x0000000184D54A60 
		public static int levelCount { get => default; } // 0x000000018BEB2550-0x000000018BEB25A0 
		public static int loadedLevel { get => default; } // 0x000000018BEB25F0-0x000000018BEB263C 
		public static string loadedLevelName { get => default; } // 0x000000018BEB263C-0x000000018BEB2688 
		public static bool isEditor { get => default; } // 0x0000000184A90A40-0x0000000184A90AF0 
	
		// Events
		public static event LowMemoryCallback lowMemory;
		public static event LogCallback logMessageReceived;
		public static event LogCallback logMessageReceivedThreaded;
		public static event UnityAction onBeforeRender;
		public static event Action<bool> focusChanged;
		public static event Action<string> deepLinkActivated;
		public static event Func<bool> wantsToQuit;
		public static event Action quitting;
		public static event Action unloading;
	
		// Nested types
		public delegate void AdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled, string errorMsg); // TypeDefIndex: 47320; 0x000000018BEB2C9C-0x000000018BEB2CA8
	
		public delegate void LowMemoryCallback(); // TypeDefIndex: 47321; 0x000000018BEB2F08-0x000000018BEB2F34
	
		public delegate void LogCallback(string condition, string stackTrace, UnityEngine.LogType type); // TypeDefIndex: 47322; 0x000000018BEB2050-0x000000018BEB20A4
	
		// Constructors
		public Application() {} // 0x0000000181A578C0-0x0000000181A578E0
	
		// Methods
		public static void Quit(int exitCode) {} // 0x0000000185FE67A0-0x0000000185FE67B0
		public static void Quit() {} // 0x0000000185FE67B0-0x0000000185FE67C0
		public static void CancelQuit() {} // 0x0000000185FAFEF0-0x0000000185FAFF00
		public static void Unload() {} // 0x000000018BEB1D90-0x000000018BEB1DE4
		public static float GetStreamProgressForLevel(int levelIndex) => default; // 0x000000018443A810-0x000000018443A850
		public static float GetStreamProgressForLevel(string levelName) => default; // 0x000000018BEB247C-0x000000018BEB24B0
		public static bool CanStreamedLevelBeLoaded(int levelIndex) => default; // 0x000000018BEB2E00-0x000000018BEB2E34
		public static bool CanStreamedLevelBeLoaded(string levelName) => default; // 0x000000018BEB3120-0x000000018BEB314C
		public static bool IsPlaying(UnityEngine.Object obj) => default; // 0x000000018BEB3A88-0x000000018BEB3ABC
		public static string[] GetBuildTags() => default; // 0x000000018BEB3228-0x000000018BEB3254
		public static void SetBuildTags(string[] buildTags) {} // 0x000000018BEB3374-0x000000018BEB33A0
		public static bool HasProLicense() => default; // 0x000000018504A140-0x000000018504A180
		internal static bool HasARGV(string name) => default; // 0x000000018BEB30C8-0x000000018BEB30F4
		internal static string GetValueForARGV(string name) => default; // 0x000000018BEB1F78-0x000000018BEB1FE8
		public static void ExternalEval(string script) {} // 0x00000001859E4A60-0x00000001859E4AA0
		private static void Internal_ExternalCall(string script) {} // 0x000000018BEB3580-0x000000018BEB35AC
		public static void HGTestForceCrash() {} // 0x0000000185FA7680-0x0000000185FA76C0
		public static bool RequestAdvertisingIdentifierAsync(AdvertisingIdentifierCallback delegateMethod) => default; // 0x000000018BEB34A4-0x000000018BEB34D0
		public static void OpenURL(string url) {} // 0x000000018BEB3ABC-0x000000018BEB3AF0
		public static void ForceCrash(int mode) {} // 0x000000018BEB201C-0x000000018BEB2050
		private static void SetLogCallbackDefined(bool defined) {} // 0x000000018BEB30F4-0x000000018BEB3120
		public static StackTraceLogType GetStackTraceLogType(UnityEngine.LogType logType) => default; // 0x0000000185FA7700-0x0000000185FA7740
		public static void SetStackTraceLogType(UnityEngine.LogType logType, StackTraceLogType stackTraceType) {} // 0x000000018BEB2DCC-0x000000018BEB2E00
		public static AsyncOperation RequestUserAuthorization(UserAuthorization mode) => default; // 0x000000018BEB3280-0x000000018BEB32B0
		public static bool HasUserAuthorization(UserAuthorization mode) => default; // 0x000000018BEB3254-0x000000018BEB3280
		internal static void CallLowMemory() {} // 0x000000018BEB23F8-0x000000018BEB247C
		private static void CallLogCallback(string logString, string stackTrace, UnityEngine.LogType type, bool invokedOnMainThread) {} // 0x000000018BEB1EFC-0x000000018BEB1F5C
		internal static void InvokeOnAdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled) {} // 0x000000018BEB1EA0-0x000000018BEB1EFC
		private static string ObjectToJSString(object o) => default; // 0x000000018BEB1E44-0x000000018BEB1EA0
		public static void ExternalCall(string functionName, object[] args) {} // 0x000000018BEB2FD8-0x000000018BEB3024
		private static string BuildInvocationForArguments(string functionName, object[] args) => default; // 0x000000018BEB37D0-0x000000018BEB381C
		public static void DontDestroyOnLoad(UnityEngine.Object o) {} // 0x000000018BEB372C-0x000000018BEB37D0
		public static void CaptureScreenshot(string filename, int superSize) {} // 0x000000018BEB2F34-0x000000018BEB2FD8
		public static void CaptureScreenshot(string filename) {} // 0x000000018BEB3688-0x000000018BEB372C
		private static bool Internal_ApplicationWantsToQuit() => default; // 0x000000018BEB2D8C-0x000000018BEB2D98
		private static void Internal_ApplicationQuit() {} // 0x000000018BEB2CA8-0x000000018BEB2CB4
		private static void Internal_ApplicationUnload() {} // 0x000000018BEB2CB4-0x000000018BEB2D8C
		internal static void InvokeOnBeforeRender() {} // 0x000000018BEB33A0-0x000000018BEB33E0
		internal static void InvokeFocusChanged(bool focus) {} // 0x000000018BEB342C-0x000000018BEB3478
		internal static void InvokeDeepLinkActivated(string url) {} // 0x000000018BEB33E0-0x000000018BEB342C
		public static void RegisterLogCallback(LogCallback handler) {} // 0x000000018BEB2688-0x000000018BEB26D4
		public static void RegisterLogCallbackThreaded(LogCallback handler) {} // 0x000000018BEB26D4-0x000000018BEB2720
		private static void RegisterLogCallback(LogCallback handler, bool threaded) {} // 0x000000018BEB25A0-0x000000018BEB25F0
		public static void LoadLevel(int index) {} // 0x000000018BEB2500-0x000000018BEB2550
		public static void LoadLevel(string name) {} // 0x000000018BEB24B0-0x000000018BEB2500
		public static void LoadLevelAdditive(int index) {} // 0x000000018BEB2EC0-0x000000018BEB2F08
		public static void LoadLevelAdditive(string name) {} // 0x000000018BEB2E74-0x000000018BEB2EC0
		public static AsyncOperation LoadLevelAsync(int index) => default; // 0x0000000185FAFEF0-0x0000000185FAFF00
		public static AsyncOperation LoadLevelAsync(string levelName) => default; // 0x0000000185492010-0x0000000185492020
		public static AsyncOperation LoadLevelAdditiveAsync(int index) => default; // 0x000000018BEB17C0-0x000000018BEB1894
		public static AsyncOperation LoadLevelAdditiveAsync(string levelName) => default; // 0x0000000181A578C0-0x0000000181A578E0
		public static bool UnloadLevel(int index) => default; // 0x0000000184B2C770-0x0000000184B2C810
		public static bool UnloadLevel(string scenePath) => default; // 0x00000001864BC320-0x00000001864BC330
	}

	public enum StackTraceLogType // TypeDefIndex: 47324
	{
		None = 0,
		ScriptOnly = 1,
		Full = 2
	}

	public enum NetworkReachability // TypeDefIndex: 47325
	{
		NotReachable = 0,
		ReachableViaCarrierDataNetwork = 1,
		ReachableViaLocalAreaNetwork = 2
	}

	public enum UserAuthorization // TypeDefIndex: 47326
	{
		WebCam = 1,
		Microphone = 2
	}

	public enum ApplicationInstallMode // TypeDefIndex: 47327
	{
		Unknown = 0,
		Store = 1,
		DeveloperBuild = 2,
		Adhoc = 3,
		Enterprise = 4,
		Editor = 5
	}

	public enum ApplicationSandboxType // TypeDefIndex: 47328
	{
		Unknown = 0,
		NotSandboxed = 1,
		Sandboxed = 2,
		SandboxBroken = 3
	}

	public enum AudioType // TypeDefIndex: 47329
	{
		UNKNOWN = 0,
		ACC = 1,
		AIFF = 2,
		IT = 10,
		MOD = 12,
		MPEG = 13,
		OGGVORBIS = 14,
		S3M = 17,
		WAV = 20,
		XM = 21,
		XMA = 22,
		VAG = 23,
		AUDIOQUEUE = 24
	}

	internal class BootConfigData // TypeDefIndex: 47330
	{
		// Fields
		private IntPtr m_Ptr; // 0x10
	
		// Constructors
		public BootConfigData() {} // Dummy constructor
		private BootConfigData(IntPtr nativeHandle) {} // 0x000000018BEB4388-0x000000018BEB43F4
	
		// Methods
		private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) => default; // 0x000000018BEB4328-0x000000018BEB4388
	}

	public struct CachedAssetBundle // TypeDefIndex: 47331
	{
		// Fields
		private string m_Name; // 0x00
		private Hash128 m_Hash; // 0x08
	}

	public struct Cache : IEquatable<UnityEngine.Cache> // TypeDefIndex: 47332
	{
		// Fields
		private int m_Handle; // 0x00
	
		// Properties
		internal int handle { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
		public string path { get => default; } // 0x000000018BEB50EC-0x000000018BEB50F8 
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public override bool Equals(object other) => default; // 0x000000018BEB5080-0x000000018BEB50E4
		public bool Equals(Cache other) => default; // 0x000000018BEB50E4-0x000000018BEB50EC
		internal static string Cache_GetPath(int handle) => default; // 0x000000018BEB504C-0x000000018BEB5080
	}

	public sealed class Caching // TypeDefIndex: 47333
	{
		// Properties
		public static UnityEngine.Cache currentCacheForWriting { get => default; } // 0x000000018BEB512C-0x000000018BEB5150 
	
		// Constructors
		public Caching() {} // Dummy constructor
	
		// Methods
		private static void get_currentCacheForWriting_Injected(out UnityEngine.Cache ret) {
			ret = default;
		} // 0x000000018BEB50F8-0x000000018BEB512C
	}

	public sealed class Camera : UnityEngine.Behaviour // TypeDefIndex: 47345
	{
		// Fields
		public static CameraCallback onPreCull; // 0x00
		public static CameraCallback onPreRender; // 0x08
		public static CameraCallback onPostRender; // 0x10
	
		// Properties
		public float nearClipPlane { get => default; set {} } // 0x00000001858D9100-0x00000001858D9150 0x000000018BEB6A4C-0x000000018BEB6A80
		public float farClipPlane { get => default; set {} } // 0x000000018BEB73D0-0x000000018BEB7414 0x000000018BEB6C88-0x000000018BEB6CBC
		public float fieldOfView { get => default; set {} } // 0x000000018BEB7694-0x000000018BEB76D8 0x0000000184124770-0x00000001841247B0
		public RenderingPath renderingPath { get => default; set {} } // 0x00000001841F9910-0x00000001841F9960 0x00000001842B0890-0x00000001842B08D0
		public RenderingPath actualRenderingPath { get => default; } // 0x00000001852B43F0-0x00000001852B4440 
		public bool allowHDR { get => default; set {} } // 0x000000018BEB7828-0x000000018BEB7868 0x000000018BEB72F8-0x000000018BEB732C
		public bool allowMSAA { get => default; set {} } // 0x000000018BEB7CD8-0x000000018BEB7D18 0x000000018BEB72CC-0x000000018BEB72F8
		public bool allowDynamicResolution { get => default; set {} } // 0x000000018BEB7CC4-0x000000018BEB7CD8 0x000000018BEB6378-0x000000018BEB63AC
		public bool forceIntoRenderTexture { get => default; set {} } // 0x0000000184235EF0-0x0000000184235F30 0x000000018BEB75CC-0x000000018BEB7610
		public float orthographicSize { get => default; set {} } // 0x00000001843F78E0-0x00000001843F7920 0x000000018BEB7414-0x000000018BEB7458
		public bool orthographic { get => default; set {} } // 0x000000018BEB6240-0x000000018BEB6274 0x000000018BEB73A4-0x000000018BEB73D0
		public OpaqueSortMode opaqueSortMode { get => default; set {} } // 0x00000001842AEE40-0x00000001842AEE80 0x00000001852FC8C0-0x00000001852FC910
		public TransparencySortMode transparencySortMode { get => default; set {} } // 0x00000001842AEE00-0x00000001842AEE40 0x000000018BEB7610-0x000000018BEB7650
		public Vector3 transparencySortAxis { get => default; set {} } // 0x000000018BEB6CC8-0x000000018BEB6CFC 0x000000018BEB778C-0x000000018BEB77D0
		public float depth { get => default; set {} } // 0x000000018BEB74B0-0x000000018BEB74F0 0x000000018BEB700C-0x000000018BEB7040
		public float aspect { get => default; set {} } // 0x000000018BEB79F4-0x000000018BEB7A34 0x000000018BEB6FD8-0x000000018BEB700C
		public Vector3 velocity { get => default; } // 0x000000018BEB7184-0x000000018BEB71B8 
		public int cullingMask { get => default; set {} } // 0x000000018BEB6E14-0x000000018BEB6E48 0x000000018BEB7868-0x000000018BEB78AC
		public int eventMask { get => default; set {} } // 0x000000018BEB70DC-0x000000018BEB7110 0x000000018BEB5ADC-0x000000018BEB5B10
		public bool layerCullSpherical { get => default; set {} } // 0x000000018BEB6414-0x000000018BEB6458 0x000000018BEB6CBC-0x000000018BEB6CC8
		public CameraType cameraType { get => default; set {} } // 0x000000018BEB7718-0x000000018BEB778C 0x0000000185FE6810-0x0000000185FE6820
		public uint regionHandle { get => default; set {} } // 0x00000001843F7940-0x00000001843F7980 0x00000001852FBDC0-0x00000001852FBE10
		public uint regionCullingMask { get => default; set {} } // 0x00000001842ADBD0-0x00000001842ADC40 0x000000018BEB75B8-0x000000018BEB75CC
		internal Material skyboxMaterial { get => default; } // 0x000000018BEB6274-0x000000018BEB62A8 
		public ulong overrideSceneCullingMask { get => default; set {} } // 0x000000018BEB6B60-0x000000018BEB6B8C 0x000000018BEB749C-0x000000018BEB74B0
		internal ulong sceneCullingMask { get => default; } // 0x00000001842AEE80-0x00000001842AEEC0 
		public float[] layerCullDistances { get => default; set {} } // 0x00000001843F4370-0x00000001843F43C0 0x000000018BEB6B8C-0x000000018BEB6BC0
		internal static int PreviewCullingLayer { get => default; } // 0x000000018BEB7530-0x000000018BEB7574 
		public bool useOcclusionCulling { get => default; set {} } // 0x000000018BEB6458-0x000000018BEB64AC 0x000000018BEB62DC-0x000000018BEB6310
		public Matrix4x4 cullingMatrix { get => default; set {} } // 0x000000018BEB6F34-0x000000018BEB6F68 0x00000001844016E0-0x0000000184401720
		public UnityEngine.Color backgroundColor { get => default; set {} } // 0x00000001851925E0-0x0000000185192630 0x000000018BEB7B18-0x000000018BEB7B34
		public CameraClearFlags clearFlags { get => default; set {} } // 0x000000018BEB6D40-0x000000018BEB6D64 0x000000018646E2E4-0x000000018646E37C
		public DepthTextureMode depthTextureMode { get => default; set {} } // 0x000000018BEB6C54-0x000000018BEB6C88 0x000000018BEB7650-0x000000018BEB7694
		public bool clearStencilAfterLightingPass { get => default; set {} } // 0x000000018530C470-0x000000018530C4B0 0x000000018BEB76D8-0x000000018BEB7718
		internal ProjectionMatrixMode projectionMatrixMode { get => default; } // 0x000000018BEB5B54-0x000000018BEB5B80 
		public bool usePhysicalProperties { get => default; set {} } // 0x000000018BEB6FAC-0x000000018BEB6FD8 0x000000018BEB79A0-0x000000018BEB79B4
		public Vector2 sensorSize { get => default; set {} } // 0x00000001842AFC60-0x00000001842AFCC0 0x000000018BEB78F0-0x000000018BEB7904
		public Vector2 lensShift { get => default; set {} } // 0x000000018BEB6E8C-0x000000018BEB6EB8 0x00000001842AD220-0x00000001842AD260
		public float focalLength { get => default; set {} } // 0x00000001842AD0C0-0x00000001842AD100 0x000000018BEB70A8-0x000000018BEB70DC
		public GateFitMode gateFit { get => default; set {} } // 0x000000018BEB7074-0x000000018BEB70A8 0x00000001842AFC20-0x00000001842AFC60
		public Rect rect { get => default; set {} } // 0x000000018BEB7BFC-0x000000018BEB7C3C 0x000000018BEB65C8-0x000000018BEB65DC
		public Rect pixelRect { get => default; set {} } // 0x000000018BEB6644-0x000000018BEB6670 0x000000018BEB6630-0x000000018BEB6644
		public RectInt pixelRectInt { get => default; } // 0x000000018BEB6670-0x000000018BEB6690 
		public int pixelWidth { get => default; } // 0x000000018BEB59BC-0x000000018BEB59F0 
		public int pixelHeight { get => default; } // 0x00000001843F6620-0x00000001843F6690 
		public int scaledPixelWidth { get => default; } // 0x000000018429E8A0-0x000000018429E910 
		public int scaledPixelHeight { get => default; } // 0x000000018BEB7DA0-0x000000018BEB7DB4 
		public RenderTexture targetTexture { get => default; set {} } // 0x00000001843F7760-0x00000001843F77D0 0x000000018BEB7948-0x000000018BEB795C
		public RenderTexture activeTexture { get => default; } // 0x000000018BEB6DA8-0x000000018BEB6DE0 
		public int targetDisplay { get => default; set {} } // 0x000000018BEB7814-0x000000018BEB7828 0x000000018BEB732C-0x000000018BEB7360
		public Matrix4x4 cameraToWorldMatrix { get => default; } // 0x0000000184234590-0x0000000184234610 
		public Matrix4x4 worldToCameraMatrix { get => default; set {} } // 0x0000000184CE9880-0x0000000184CE9900 0x000000018BEB69A8-0x000000018BEB69E4
		public Matrix4x4 projectionMatrix { get => default; set {} } // 0x00000001842336C0-0x0000000184233740 0x00000001842344F0-0x0000000184234590
		public Matrix4x4 nonJitteredProjectionMatrix { get => default; set {} } // 0x0000000184CE97E0-0x0000000184CE9880 0x000000018BEB6950-0x000000018BEB69A8
		public bool useJitteredProjectionMatrixForTransparentRendering { get => default; set {} } // 0x0000000184233620-0x00000001842336C0 0x00000001842368E0-0x0000000184236950
		public Matrix4x4 previousViewProjectionMatrix { get => default; } // 0x000000018BEB68B8-0x000000018BEB68EC 
		public static Camera main { get => default; } // 0x000000018BEB7BBC-0x000000018BEB7BFC 
		public static Camera current { get => default; } // 0x000000018BEB71B8-0x000000018BEB71EC 
		public Scene scene { get => default; set {} } // 0x000000018BEB57E8-0x000000018BEB5828 0x000000018BEB5C5C-0x000000018BEB5C98
		public bool stereoEnabled { get => default; } // 0x000000018BEB64FC-0x000000018BEB6510 
		public float stereoSeparation { get => default; set {} } // 0x000000018BEB6310-0x000000018BEB6344 0x000000018BEB6560-0x000000018BEB6574
		public float stereoConvergence { get => default; set {} } // 0x000000018BEB6344-0x000000018BEB6378 0x00000001850CC000-0x00000001850CC040
		public bool areVRStereoViewMatricesWithinSingleCullTolerance { get => default; } // 0x00000001842AC6F0-0x00000001842AC730 
		public StereoTargetEyeMask stereoTargetEye { get => default; set {} } // 0x000000018646E570-0x000000018646E57C 0x000000018586BB90-0x000000018586BBE0
		public MonoOrStereoscopicEye stereoActiveEye { get => default; } // 0x00000001842AC730-0x00000001842AC790 
		public static int allCamerasCount { get => default; } // 0x000000018BEB7110-0x000000018BEB711C 
		public static Camera[] allCameras { get => default; } // 0x000000018BEB60D4-0x000000018BEB6138 
		public SceneViewFilterMode sceneViewFilterMode { get => default; } // 0x000000018BEB52F8-0x000000018BEB5348 
		public int commandBufferCount { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		internal enum ProjectionMatrixMode // TypeDefIndex: 47334
		{
			Explicit = 0,
			Implicit = 1,
			PhysicalPropertiesBased = 2
		}
	
		public enum GateFitMode // TypeDefIndex: 47335
		{
			None = 0,
			Vertical = 1,
			Horizontal = 2,
			Fill = 3,
			Overscan = 4
		}
	
		public enum FieldOfViewAxis // TypeDefIndex: 47336
		{
			Vertical = 0,
			Horizontal = 1
		}
	
		public struct GateFitParameters // TypeDefIndex: 47337
		{
			// Fields
			private GateFitMode _mode_k__BackingField; // 0x00
			private float _aspect_k__BackingField; // 0x04
	
			// Properties
			public GateFitMode mode { get; set; } // 0x000000018BEB5E78-0x000000018BEB5EAC 0x0000000185FC7990-0x0000000185FC79A0
			public float aspect { get; set; } // 0x000000018646DB20-0x000000018646DB28 0x00000001842ADC90-0x00000001842ADCD0
	
			// Constructors
			public GateFitParameters(GateFitMode mode, float aspect) : this() {
				<mode>k__BackingField = default;
				<aspect>k__BackingField = default;
			} // 0x00000001841F9820-0x00000001841F9870
		}
	
		public enum StereoscopicEye // TypeDefIndex: 47338
		{
			Left = 0,
			Right = 1
		}
	
		public enum MonoOrStereoscopicEye // TypeDefIndex: 47339
		{
			Left = 0,
			Right = 1,
			Mono = 2
		}
	
		public enum SceneViewFilterMode // TypeDefIndex: 47340
		{
			Off = 0,
			ShowFiltered = 1
		}
	
		public enum RenderRequestMode // TypeDefIndex: 47341
		{
			None = 0,
			ObjectId = 1,
			Depth = 2,
			VertexNormal = 3,
			WorldPosition = 4,
			EntityId = 5,
			BaseColor = 6,
			SpecularColor = 7,
			Metallic = 8,
			Emission = 9,
			Normal = 10,
			Smoothness = 11,
			Occlusion = 12,
			DiffuseColor = 13
		}
	
		public enum RenderRequestOutputSpace // TypeDefIndex: 47342
		{
			ScreenSpace = -1,
			UV0 = 0,
			UV1 = 1,
			UV2 = 2,
			UV3 = 3,
			UV4 = 4,
			UV5 = 5,
			UV6 = 6,
			UV7 = 7,
			UV8 = 8
		}
	
		public struct RenderRequest // TypeDefIndex: 47343
		{
			// Fields
			private readonly RenderRequestMode m_CameraRenderMode; // 0x00
			private readonly RenderTexture m_ResultRT; // 0x08
			private readonly RenderRequestOutputSpace m_OutputSpace; // 0x10
	
			// Properties
			public bool isValid { get => default; } // 0x00000001843F78A0-0x00000001843F78E0 
			public RenderRequestMode mode { get => default; } // 0x00000001841F98C0-0x00000001841F9910 
			public RenderTexture result { get => default; } // 0x000000018BEB7040-0x000000018BEB7074 
			public RenderRequestOutputSpace outputSpace { get => default; } // 0x000000018BEB7A34-0x000000018BEB7A74 
	
			// Constructors
			public RenderRequest(RenderRequestMode mode, RenderTexture rt) : this() {
				m_CameraRenderMode = default;
				m_ResultRT = default;
				m_OutputSpace = default;
			} // 0x00000001842ADB90-0x00000001842ADBD0
			public RenderRequest(RenderRequestMode mode, RenderRequestOutputSpace space, RenderTexture rt) : this() {
				m_CameraRenderMode = default;
				m_ResultRT = default;
				m_OutputSpace = default;
			} // 0x00000001841F9870-0x00000001841F98C0
		}
	
		public delegate void CameraCallback(Camera cam); // TypeDefIndex: 47344; 0x000000018BEB63E0-0x000000018BEB6414
	
		// Constructors
		public Camera() {} // 0x000000018BEB6AB4-0x000000018BEB6AE8
	
		// Methods
		internal static IntPtr HGGetPtrUnchecked_Camera(int instanceID) => default; // 0x000000018BEB6A80-0x000000018BEB6AB4
		public IntPtr HGGetPtrUnchecked() => default; // 0x00000001858D90B0-0x00000001858D9100
		public void Reset() {} // 0x000000018BEB6DE0-0x000000018BEB6E14
		public void ResetTransparencySortSettings() {} // 0x00000001843F98F0-0x00000001843F9930
		public void ResetAspect() {} // 0x000000018BEB79B4-0x000000018BEB79F4
		private float[] GetLayerCullDistances() => default; // 0x000000018BEB74F0-0x000000018BEB7530
		private void SetLayerCullDistances(float[] d) {} // 0x000000018BEB6C20-0x000000018BEB6C54
		public void ResetCullingMatrix() {} // 0x00000001841F9960-0x00000001841F99B0
		public void SetReplacementShader(Shader shader, string replacementTag) {} // 0x00000001844020C0-0x0000000184402100
		public void ResetReplacementShader() {} // 0x0000000184402150-0x00000001844021A0
		public float GetGateFittedFieldOfView() => default; // 0x000000018BEB7C3C-0x000000018BEB7C80
		public Vector2 GetGateFittedLensShift() => default; // 0x000000018BEB69E4-0x000000018BEB6A18
		internal Vector3 GetLocalSpaceAim() => default; // 0x0000000184236950-0x0000000184236990
		private void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) {} // 0x000000018BEB7D18-0x000000018BEB7D5C
		public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) {} // 0x000000018BEB6EFC-0x000000018BEB6F34
		private void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) {} // 0x000000018BEB63AC-0x000000018BEB63E0
		public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) {} // 0x000000018BEB62A8-0x000000018BEB62DC
		internal string[] GetCameraBufferWarnings() => default; // 0x000000018BEB5650-0x000000018BEB568C
		public void ResetWorldToCameraMatrix() {} // 0x000000018BEB5AB8-0x000000018BEB5ADC
		public void ResetProjectionMatrix() {} // 0x0000000184CEA110-0x0000000184CEA160
		public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) => default; // 0x0000000184CEA050-0x0000000184CEA110
		public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) => default; // 0x0000000184CE9FF0-0x0000000184CEA050
		public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) => default; // 0x0000000184236790-0x0000000184236810
		public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) => default; // 0x00000001842366D0-0x0000000184236790
		public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) => default; // 0x0000000184236620-0x00000001842366D0
		public Vector3 WorldToScreenPoint(Vector3 position) => default; // 0x000000018BEB54DC-0x000000018BEB5500
		public Vector3 WorldToViewportPoint(Vector3 position) => default; // 0x000000018BEB5500-0x000000018BEB55FC
		public Vector3 ViewportToWorldPoint(Vector3 position) => default; // 0x000000018BEB56F0-0x000000018BEB5754
		public Vector3 ScreenToWorldPoint(Vector3 position) => default; // 0x000000018BEB5754-0x000000018BEB57A4
		public Vector3 ScreenToViewportPoint(Vector3 position) => default; // 0x000000018BEB5970-0x000000018BEB59BC
		public Vector3 ViewportToScreenPoint(Vector3 position) => default; // 0x000000018BEB5828-0x000000018BEB5874
		internal Vector2 GetFrustumPlaneSizeAt(float distance) => default; // 0x000000018596D490-0x000000018596D4F0
		private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) => default; // 0x000000018596D380-0x000000018596D3E0
		public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) => default; // 0x0000000184406550-0x0000000184406590
		public Ray ViewportPointToRay(Vector3 pos) => default; // 0x000000018BEB6BF4-0x000000018BEB6C20
		private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) => default; // 0x00000001843F9F60-0x00000001843F9FA0
		public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) => default; // 0x0000000185C2B040-0x0000000185C2B090
		public Ray ScreenPointToRay(Vector3 pos) => default; // 0x000000018BEB7160-0x000000018BEB7184
		private void CalculateFrustumCornersInternal(Rect viewport, float z, MonoOrStereoscopicEye eye, out Vector3[] outCorners) {
			outCorners = default;
		} // 0x000000018BEB7AB8-0x000000018BEB7AD4
		public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) {} // 0x000000018512D8D0-0x000000018512D910
		private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) {
			output = default;
		} // 0x000000018BEB7220-0x000000018BEB7254
		public static void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters = default) {
			output = default;
		} // 0x000000018BEB7B78-0x000000018BEB7BBC
		public static float FocalLengthToFieldOfView(float focalLength, float sensorSize) => default; // 0x000000018BEB71EC-0x000000018BEB7220
		public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) => default; // 0x000000018BEB7B34-0x000000018BEB7B78
		public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) => default; // 0x000000018BEB6AE8-0x000000018BEB6B1C
		public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) => default; // 0x000000018BEB7254-0x000000018BEB7288
		public Camera GetLightWeightCamera() => default; // 0x000000018BEB5BD0-0x000000018BEB5C0C
		public void SetLightWeight(bool flag) {} // 0x000000018BEB5CE8-0x000000018BEB5D24
		public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) => default; // 0x000000018BEB5D24-0x000000018BEB5D58
		public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) => default; // 0x000000018BEB5D64-0x000000018BEB5DA8
		public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) {} // 0x000000018BEB5D58-0x000000018BEB5D64
		public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) => default; // 0x000000018BEB5DA8-0x000000018BEB5E78
		public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) {} // 0x000000018BEB6138-0x000000018BEB618C
		public void ResetStereoProjectionMatrices() {} // 0x000000018BEB619C-0x000000018BEB61A8
		public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) {} // 0x000000018BEB618C-0x000000018BEB619C
		public void ResetStereoViewMatrices() {} // 0x000000018BEB619C-0x000000018BEB61A8
		private static int GetAllCamerasCount() => default; // 0x000000018BEB618C-0x000000018BEB619C
		private static int GetAllCamerasImpl(out Camera[] cam) {
			cam = default;
			return default;
		} // 0x000000018BEB5A30-0x000000018BEB5A64
		public static int GetAllCameras(Camera[] cameras) => default; // 0x000000018BEB61A8-0x000000018BEB61B8
		private static int HGGetAllCamerasCountImpl(bool includeEditorCameras = false /* Metadata: 0x020603A2 */) => default; // 0x000000018BEB620C-0x000000018BEB6240
		private static int HGGetAllCamerasImpl(out Camera[] cam, bool includeEditorCameras = false /* Metadata: 0x020603A3 */) {
			cam = default;
			return default;
		} // 0x000000018BEB61B8-0x000000018BEB620C
		public static int HGGetAllCamerasCount(bool includeEditorCameras = false /* Metadata: 0x020603A4 */) => default; // 0x000000018BEB60A0-0x000000018BEB60D4
		public static int HGGetAllCameras(Camera[] cameras, bool includeEditorCameras = false /* Metadata: 0x020603A5 */) => default; // 0x000000018BEB6708-0x000000018BEB6820
		private bool RenderToCubemapImpl(Texture tex, int faceMask) => default; // 0x000000018BEB66C4-0x000000018BEB6708
		public bool RenderToCubemap(Cubemap cubemap, int faceMask) => default; // 0x000000018BEB6690-0x000000018BEB66C4
		public bool RenderToCubemap(Cubemap cubemap) => default; // 0x000000018BEB57A4-0x000000018BEB57E8
		public bool RenderToCubemap(RenderTexture cubemap, int faceMask) => default; // 0x000000018BEB6BC0-0x000000018BEB6BF4
		public bool RenderToCubemap(RenderTexture cubemap) => default; // 0x000000018BEB6060-0x000000018BEB60A0
		private int GetFilterMode() => default; // 0x000000018BEB5EAC-0x000000018BEB5EE0
		private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) => default; // 0x000000018BEB5150-0x000000018BEB51B0
		public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) => default; // 0x000000018BEB5EE0-0x000000018BEB5F30
		public void Render() {} // 0x000000018BEB5348-0x000000018BEB5478
		public void RenderWithShader(Shader shader, string replacementTag) {} // 0x000000018BEB51B0-0x000000018BEB52F8
		public void RenderDontRestore() {} // 0x000000018BEB5F30-0x000000018BEB6060
		public void SubmitRenderRequests(List<RenderRequest> renderRequests) {} // 0x000000018BEB59F0-0x000000018BEB5A30
		private void SubmitRenderRequestsInternal(object requests) {} // 0x000000018BEB58C8-0x000000018BEB591C
		public static void SetupCurrent(Camera cur) {} // 0x000000018BEB591C-0x000000018BEB5970
		public void CopyFrom(Camera other) {} // 0x000000018BEB5874-0x000000018BEB58C8
		public void RemoveCommandBuffers(CameraEvent evt) {} // 0x0000000185492010-0x0000000185492020
		public void RemoveAllCommandBuffers() {} // 0x000000018BEB6840-0x000000018BEB6864
		private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) {} // 0x000000018BEB6820-0x000000018BEB6840
		private void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) {} // 0x000000018502CD20-0x000000018502CD90
		private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) {} // 0x000000018BEB7288-0x000000018BEB72CC
		public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) {} // 0x000000018BEB7C80-0x000000018BEB7CC4
		public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) {} // 0x000000018BEB7360-0x000000018BEB73A4
		public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) {} // 0x00000001842ADC40-0x00000001842ADC90
		public CommandBuffer[] GetCommandBuffers(CameraEvent evt) => default; // 0x000000018BEB7574-0x000000018BEB75B8
		private static void FireOnPreCull(Camera cam) {} // 0x000000018BEB6B1C-0x000000018BEB6B60
		private static void FireOnPreRender(Camera cam) {} // 0x000000018BEB7458-0x000000018BEB749C
		private static void FireOnPostRender(Camera cam) {} // 0x0000000185192630-0x0000000185192680
		internal void OnlyUsedForTesting1() {} // 0x000000018BEB7AD4-0x000000018BEB7B18
		internal void OnlyUsedForTesting2() {} // 0x000000018BEB6CFC-0x000000018BEB6D40
		public bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters) {
			cullingParameters = default;
			return default;
		} // 0x000000018518ABC0-0x000000018518AC10
		public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) {
			cullingParameters = default;
			return default;
		} // 0x00000001844021A0-0x00000001844021F0
		private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) {
			cullingParameters = default;
			return default;
		} // 0x000000018BEB5B10-0x000000018BEB5B54
		private void get_transparencySortAxis_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEB6F68-0x000000018BEB6FAC
		private void set_transparencySortAxis_Injected(ref Vector3 value) {} // 0x000000018BEB795C-0x000000018BEB79A0
		private void get_velocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001842AFCC0-0x00000001842AFD10
		private void get_cullingMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BEB78AC-0x000000018BEB78F0
		private void set_cullingMatrix_Injected(ref Matrix4x4 value) {} // 0x000000018BEB6E48-0x000000018BEB6E8C
		private void get_backgroundColor_Injected(out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BEB6574-0x000000018BEB65C8
		private void set_backgroundColor_Injected(ref UnityEngine.Color value) {} // 0x000000018BEB65DC-0x000000018BEB6630
		private void get_sensorSize_Injected(out Vector2 ret) {
			ret = default;
		} // 0x00000001843F7980-0x00000001843F79D0
		private void set_sensorSize_Injected(ref Vector2 value) {} // 0x000000018429E910-0x000000018429E960
		private void get_lensShift_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BEB7D5C-0x000000018BEB7DA0
		private void set_lensShift_Injected(ref Vector2 value) {} // 0x00000001843F77D0-0x00000001843F7820
		private void GetGateFittedLensShift_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BEB7904-0x000000018BEB7948
		private void GetLocalSpaceAim_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEB6D64-0x000000018BEB6DA8
		private void get_rect_Injected(out Rect ret) {
			ret = default;
		} // 0x000000018BEB77D0-0x000000018BEB7814
		private void set_rect_Injected(ref Rect value) {} // 0x000000018BEB6EB8-0x000000018BEB6EFC
		private void get_pixelRect_Injected(out Rect ret) {
			ret = default;
		} // 0x000000018BEB55FC-0x000000018BEB5650
		private void set_pixelRect_Injected(ref Rect value) {} // 0x0000000184234610-0x0000000184234680
		private void get_pixelRectInt_Injected(out RectInt ret) {
			ret = default;
		} // 0x0000000184CE9900-0x0000000184CE9970
		private void SetTargetBuffersImpl_Injected(ref RenderBuffer color, ref RenderBuffer depth) {} // 0x000000018BEB68EC-0x000000018BEB6950
		private void SetTargetBuffersMRTImpl_Injected(RenderBuffer[] color, ref RenderBuffer depth) {} // 0x0000000184233740-0x00000001842337B0
		private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000184236880-0x00000001842368E0
		private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BEB6864-0x000000018BEB68B8
		private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) {} // 0x000000018BEB5A64-0x000000018BEB5AB8
		private void get_projectionMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000184CEA160-0x0000000184CEA1D0
		private void set_projectionMatrix_Injected(ref Matrix4x4 value) {} // 0x0000000184236810-0x0000000184236880
		private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BEB5478-0x000000018BEB54DC
		private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) {} // 0x000000018BEB568C-0x000000018BEB56F0
		private void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BEB711C-0x000000018BEB7160
		private void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BEB7A74-0x000000018BEB7AB8
		private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEB5B80-0x000000018BEB5BD0
		private void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEB5C98-0x000000018BEB5CE8
		private void ViewportToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEB5C0C-0x000000018BEB5C5C
		private void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEB64AC-0x000000018BEB64FC
		private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEB6510-0x000000018BEB6560
		private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x00000001818226B0-0x00000001818226C0
		private void GetFrustumPlaneSizeAt_Injected(float distance, out Vector2 ret) {
			ret = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
		private void ViewportPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) {
			ret = default;
		} // 0x0000000185FBA150-0x0000000185FBA160
		private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) {
			ret = default;
		} // 0x0000000185FBA180-0x0000000185FBA190
		private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, MonoOrStereoscopicEye eye, out Vector3[] outCorners) {
			outCorners = default;
		} // 0x0000000185FC8500-0x0000000185FC8510
		private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) {
			output = default;
		} // 0x000000018BEC93F8-0x000000018BEC941C
		private void get_scene_Injected(out Scene ret) {
			ret = default;
		} // 0x000000018BEC941C-0x000000018BEC9440
		private void set_scene_Injected(ref Scene value) {} // 0x000000018BEC9440-0x000000018BEC949C
		private void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) {
			ret = default;
		} // 0x00000001818226B0-0x00000001818226C0
		private void GetStereoViewMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018357A260-0x000000018357A270
		private void GetStereoProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000181C0BBD0-0x0000000181C0BBE0
		private void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) {} // 0x0000000188F4DA44-0x0000000188F4DB18
		private void SetStereoViewMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) {} // 0x00000001833EEC70-0x00000001833EEC80
	}

	public struct BoundingSphere // TypeDefIndex: 47346
	{
		// Fields
		public Vector3 position; // 0x00
		public float radius; // 0x0C
	
		// Constructors
		public BoundingSphere(Vector3 pos, float rad) {
			position = default;
			radius = default;
		} // 0x00000001836800E0-0x0000000183680100
	}

	public struct CullingGroupEvent // TypeDefIndex: 47347
	{
		// Fields
		private int m_Index; // 0x00
		private byte m_PrevState; // 0x04
		private byte m_ThisState; // 0x05
	}

	public class CullingGroup : IDisposable // TypeDefIndex: 47349
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		private StateChanged m_OnStateChanged; // 0x18
	
		// Nested types
		public delegate void StateChanged(CullingGroupEvent sphere); // TypeDefIndex: 47348; 0x000000018BEB7E08-0x000000018BEB7E80
	
		// Constructors
		public CullingGroup() {} // 0x000000018BEB7DB4-0x000000018BEB7DE8
	
		// Methods
		~CullingGroup() {} // 0x000000018BEB7DE8-0x000000018BEB7E08
		private void DisposeInternal() {} // 0x000000018BEB7EE8-0x000000018BEB7F54
		public void Dispose() {} // 0x000000018BEB7EB4-0x000000018BEB7EE8
		private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) {} // 0x000000018BEB7E80-0x000000018BEB7EB4
		private static IntPtr Init(object scripting) => default; // 0x00000001889CB4F0-0x00000001889CB5B8
		private void FinalizerFailure() {} // 0x00000001833EEC70-0x00000001833EEC80
	}

	public class FlareLayer : UnityEngine.Behaviour // TypeDefIndex: 47350
	{
		// Constructors
		public FlareLayer() {} // Dummy constructor
	}

	public sealed class ReflectionProbe : UnityEngine.Behaviour // TypeDefIndex: 47352
	{
		// Fields
		private static Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged; // 0x00
		private static Action<Cubemap> defaultReflectionSet; // 0x08
		private static Action<Texture> defaultReflectionTexture; // 0x10
	
		// Properties
		public ReflectionProbeType type { get => default; set {} } // 0x000000018BEC8714-0x000000018BEC8748 0x000000018BEC93B8-0x000000018BEC93F8
		public Vector3 size { get => default; set {} } // 0x000000018BEC8574-0x000000018BEC85A0 0x000000018BEC92DC-0x000000018BEC92F0
		public Vector3 center { get => default; set {} } // 0x000000018BEC7DD4-0x000000018BEC7E00 0x000000018BEC8C4C-0x000000018BEC8C60
		public Vector3 rotatedExtents { get => default; set {} } // 0x000000018BEC8468-0x000000018BEC8494 0x000000018BEC91BC-0x000000018BEC91D0
		public Vector3 boxRotation { get => default; set {} } // 0x000000018BEC7D64-0x000000018BEC7D90 0x000000018BEC8BF4-0x000000018BEC8C08
		public Vector3 boxInfluenceScale { get => default; set {} } // 0x000000018BEC7CC0-0x000000018BEC7CEC 0x000000018BEC8B58-0x000000018BEC8B6C
		public Matrix4x4 TRS { get => default; set {} } // 0x000000018BEC7A7C-0x000000018BEC7AB4 0x000000018BEC89C8-0x000000018BEC89DC
		public Matrix4x4 TRInverse { get => default; set {} } // 0x000000018BEC7A00-0x000000018BEC7A38 0x000000018BEC8970-0x000000018BEC8984
		public float falloffDistance { get => default; set {} } // 0x000000018BEC803C-0x000000018BEC8070 0x000000018BEC8DC0-0x000000018BEC8E04
		public float cullingDistance { get => default; set {} } // 0x000000018BEC7E34-0x000000018BEC7E68 0x000000018BEC8CA0-0x000000018BEC8CE4
		public float nearClipPlane { get => default; set {} } // 0x000000018BEC8200-0x000000018BEC8234 0x000000018BEC8F94-0x000000018BEC8FD8
		public float farClipPlane { get => default; set {} } // 0x000000018BEC8070-0x000000018BEC80A4 0x000000018BEC8E04-0x000000018BEC8E48
		public float intensity { get => default; set {} } // 0x000000018BEC8140-0x000000018BEC8174 0x000000018BEC8F10-0x000000018BEC8F54
		public Bounds bounds { get => default; } // 0x000000018BEC7C4C-0x000000018BEC7C7C 
		public bool hdr { get => default; set {} } // 0x000000018BEC80A4-0x000000018BEC80D8 0x000000018BEC8E48-0x000000018BEC8E8C
		public bool renderDynamicObjects { get => default; set {} } // 0x000000018BEC83BC-0x000000018BEC83F0 0x000000018BEC90F4-0x000000018BEC9138
		public float shadowDistance { get => default; set {} } // 0x000000018BEC84C8-0x000000018BEC84FC 0x000000018BEC9214-0x000000018BEC9258
		public int resolution { get => default; set {} } // 0x000000018BEC83F0-0x000000018BEC8424 0x000000018BEC9138-0x000000018BEC9178
		public int cullingMask { get => default; set {} } // 0x000000018BEC7E68-0x000000018BEC7E9C 0x000000018BEC8CE4-0x000000018BEC8D24
		public ReflectionProbeClearFlags clearFlags { get => default; set {} } // 0x000000018BEC7E00-0x000000018BEC7E34 0x000000018BEC8C60-0x000000018BEC8CA0
		public UnityEngine.Color backgroundColor { get => default; set {} } // 0x000000018BEC7AF8-0x000000018BEC7B24 0x000000018BEC8A20-0x000000018BEC8A34
		public float blendDistance { get => default; set {} } // 0x000000018BEC7BD4-0x000000018BEC7C08 0x000000018BEC8AD0-0x000000018BEC8B14
		public ReflectionProbeOrientedMode oriented { get => default; set {} } // 0x000000018BEC8234-0x000000018BEC8268 0x000000018BEC8FD8-0x000000018BEC9018
		public ReflectionProbeShapeType shapeType { get => default; set {} } // 0x000000018BEC84FC-0x000000018BEC8530 0x000000018BEC9258-0x000000018BEC9298
		public float sphereRadius { get => default; set {} } // 0x000000018BEC85D4-0x000000018BEC8608 0x000000018BEC9334-0x000000018BEC9378
		public float sphereInfluenceScale { get => default; set {} } // 0x000000018BEC85A0-0x000000018BEC85D4 0x000000018BEC92F0-0x000000018BEC9334
		public long serializedIdentifier { get => default; set {} } // 0x000000018BEC8494-0x000000018BEC84C8 0x000000018BEC91D0-0x000000018BEC9214
		public bool boxProjection { get => default; set {} } // 0x000000018BEC7CEC-0x000000018BEC7D20 0x000000018BEC8B6C-0x000000018BEC8BB0
		public bool immediatelyVisible { get => default; set {} } // 0x000000018BEC80D8-0x000000018BEC810C 0x000000018BEC8E8C-0x000000018BEC8ED0
		public ReflectionProbeMode mode { get => default; set {} } // 0x000000018BEC81CC-0x000000018BEC8200 0x000000018BEC8F54-0x000000018BEC8F94
		public int importance { get => default; set {} } // 0x000000018BEC810C-0x000000018BEC8140 0x000000018BEC8ED0-0x000000018BEC8F10
		public ReflectionProbeRefreshMode refreshMode { get => default; set {} } // 0x000000018BEC8388-0x000000018BEC83BC 0x000000018BEC90B4-0x000000018BEC90F4
		public ReflectionProbeTimeSlicingMode timeSlicingMode { get => default; set {} } // 0x000000018BEC86E0-0x000000018BEC8714 0x000000018BEC9378-0x000000018BEC93B8
		public Texture bakedTexture { get => default; set {} } // 0x000000018BEC7BA0-0x000000018BEC7BD4 0x000000018BEC8A8C-0x000000018BEC8AD0
		public Texture customBakedTexture { get => default; set {} } // 0x000000018BEC7F18-0x000000018BEC7F4C 0x000000018BEC8D7C-0x000000018BEC8DC0
		public RenderTexture realtimeTexture { get => default; set {} } // 0x000000018BEC8354-0x000000018BEC8388 0x000000018BEC9070-0x000000018BEC90B4
		public Texture texture { get => default; } // 0x000000018BEC86AC-0x000000018BEC86E0 
		public SphericalHarmonicsL2 bakedProbeSH { get => default; set {} } // 0x000000018BEC7B68-0x000000018BEC7BA0 0x000000018BEC8A78-0x000000018BEC8A8C
		public SphericalHarmonicsL2 customBakedProbeSH { get => default; set {} } // 0x000000018BEC7EE0-0x000000018BEC7F18 0x000000018BEC8D68-0x000000018BEC8D7C
		public SphericalHarmonicsL2 probeSH { get => default; } // 0x000000018BEC831C-0x000000018BEC8354 
		public Vector4 textureHDRDecodeValues { get => default; } // 0x000000018BEC864C-0x000000018BEC8678 
		public string texturePath { get => default; } // 0x000000018BEC8678-0x000000018BEC86AC 
		public Hash128 probeHash { get => default; set {} } // 0x000000018BEC82AC-0x000000018BEC82D8 0x000000018BEC905C-0x000000018BEC9070
		public static int minBakedCubemapResolution { get => default; } // 0x000000018BEC81A0-0x000000018BEC81CC 
		public static int maxBakedCubemapResolution { get => default; } // 0x000000018BEC8174-0x000000018BEC81A0 
		public static Vector4 defaultTextureHDRDecodeValues { get => default; } // 0x000000018BEC7FF0-0x000000018BEC8010 
		public static Texture defaultTexture { get => default; } // 0x000000018BEC8010-0x000000018BEC803C 
		public static SphericalHarmonicsL2 defaultProbeSH { get => default; } // 0x000000018BEC7F80-0x000000018BEC7FBC 
	
		// Events
		public static event Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged;
		public static event Action<Cubemap> defaultReflectionSet;
		public static event Action<Texture> defaultReflectionTexture;
	
		// Nested types
		public enum ReflectionProbeEvent // TypeDefIndex: 47351
		{
			ReflectionProbeAdded = 0,
			ReflectionProbeRemoved = 1,
			ReflectionProbeTextureChanged = 2
		}
	
		// Constructors
		public ReflectionProbe() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void UpdateRotatedExtentsAndTRS() {} // 0x000000018BEC77A4-0x000000018BEC77D8
		public void SetTexturePathWithoutUpdate(string texturePath) {} // 0x000000018BEC7734-0x000000018BEC7778
		public void Reset() {} // 0x000000018BEC76B0-0x000000018BEC76E4
		public int RenderProbe() => default; // 0x000000018BEC7670-0x000000018BEC767C
		public int RenderProbe(RenderTexture targetTexture) => default; // 0x000000018BEC767C-0x000000018BEC76B0
		public bool IsFinishedRendering(int renderId) => default; // 0x000000018BEC7630-0x000000018BEC7670
		private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) => default; // 0x000000018BEC76E4-0x000000018BEC7734
		public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target) => default; // 0x000000018BEC75CC-0x000000018BEC7630
		public static void UpdateCachedState() {} // 0x000000018BEC7778-0x000000018BEC77A4
		private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) {} // 0x0000000185761FE0-0x0000000185762040
		private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) {} // 0x0000000184ED10A0-0x0000000184ED10F0
		private void get_size_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEC8530-0x000000018BEC8574
		private void set_size_Injected(ref Vector3 value) {} // 0x000000018BEC9298-0x000000018BEC92DC
		private void get_center_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEC7D90-0x000000018BEC7DD4
		private void set_center_Injected(ref Vector3 value) {} // 0x000000018BEC8C08-0x000000018BEC8C4C
		private void get_rotatedExtents_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEC8424-0x000000018BEC8468
		private void set_rotatedExtents_Injected(ref Vector3 value) {} // 0x000000018BEC9178-0x000000018BEC91BC
		private void get_boxRotation_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEC7D20-0x000000018BEC7D64
		private void set_boxRotation_Injected(ref Vector3 value) {} // 0x000000018BEC8BB0-0x000000018BEC8BF4
		private void get_boxInfluenceScale_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEC7C7C-0x000000018BEC7CC0
		private void set_boxInfluenceScale_Injected(ref Vector3 value) {} // 0x000000018BEC8B14-0x000000018BEC8B58
		private void get_TRS_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BEC7A38-0x000000018BEC7A7C
		private void set_TRS_Injected(ref Matrix4x4 value) {} // 0x000000018BEC8984-0x000000018BEC89C8
		private void get_TRInverse_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BEC79BC-0x000000018BEC7A00
		private void set_TRInverse_Injected(ref Matrix4x4 value) {} // 0x000000018BEC892C-0x000000018BEC8970
		private void get_bounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x000000018BEC7C08-0x000000018BEC7C4C
		private void get_backgroundColor_Injected(out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BEC7AB4-0x000000018BEC7AF8
		private void set_backgroundColor_Injected(ref UnityEngine.Color value) {} // 0x000000018BEC89DC-0x000000018BEC8A20
		private void get_bakedProbeSH_Injected(out SphericalHarmonicsL2 ret) {
			ret = default;
		} // 0x000000018BEC7B24-0x000000018BEC7B68
		private void set_bakedProbeSH_Injected(ref SphericalHarmonicsL2 value) {} // 0x000000018BEC8A34-0x000000018BEC8A78
		private void get_customBakedProbeSH_Injected(out SphericalHarmonicsL2 ret) {
			ret = default;
		} // 0x000000018BEC7E9C-0x000000018BEC7EE0
		private void set_customBakedProbeSH_Injected(ref SphericalHarmonicsL2 value) {} // 0x000000018BEC8D24-0x000000018BEC8D68
		private void get_probeSH_Injected(out SphericalHarmonicsL2 ret) {
			ret = default;
		} // 0x000000018BEC82D8-0x000000018BEC831C
		private void get_textureHDRDecodeValues_Injected(out Vector4 ret) {
			ret = default;
		} // 0x000000018BEC8608-0x000000018BEC864C
		private void get_probeHash_Injected(out Hash128 ret) {
			ret = default;
		} // 0x000000018BEC8268-0x000000018BEC82AC
		private void set_probeHash_Injected(ref Hash128 value) {} // 0x000000018BEC9018-0x000000018BEC905C
		private static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret) {
			ret = default;
		} // 0x000000018BEC7FBC-0x000000018BEC7FF0
		private static void get_defaultProbeSH_Injected(out SphericalHarmonicsL2 ret) {
			ret = default;
		} // 0x000000018BEC7F4C-0x000000018BEC7F80
	}

	internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 47353
	{
		// Constructors
		public DebugLogHandler() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal static void Internal_Log(UnityEngine.LogType level, LogOption options, string msg, UnityEngine.Object obj) {} // 0x00000001841C86E0-0x00000001841C8A00
		internal static void Internal_LogException(Exception ex, UnityEngine.Object obj) {} // 0x000000018BEB8020-0x000000018BEB8064
		public void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args) {} // 0x00000001856B5B40-0x00000001856B5B90
		public void LogFormat(UnityEngine.LogType logType, LogOption logOptions, UnityEngine.Object context, string format, object[] args) {} // 0x00000001841C8660-0x00000001841C86E0
		public void LogException(Exception exception, UnityEngine.Object context) {} // 0x000000018BEB8064-0x000000018BEB80DC
	}

	public class Debug // TypeDefIndex: 47354
	{
		// Fields
		internal static readonly ILogger s_DefaultLogger; // 0x00
		internal static ILogger s_Logger; // 0x08
	
		// Properties
		public static ILogger unityLogger { get => default; } // 0x000000018BEB978C-0x000000018BEB97DC 
		public static bool developerConsoleEnabled { get => default; set {} } // 0x000000018BEB964C-0x000000018BEB9678 0x000000018BEB97DC-0x000000018BEB9810
		public static UnityEngine.LogType developerConsoleLogType { get => default; set {} } // 0x000000018BEB9678-0x000000018BEB96B8 0x000000018BEB9810-0x000000018BEB9858
		private static int developerConsoleLoggingLevel { get => default; set {} } // 0x000000018BEB96B8-0x000000018BEB96E4 0x000000018BEB9858-0x000000018BEB988C
		public static bool developerConsoleVisible { get => default; set {} } // 0x000000018BEB96E4-0x000000018BEB9710 0x000000018BEB988C-0x000000018BEB98C0
		public static bool isDebugBuild { get => default; } // 0x000000018508FDE0-0x000000018508FE20 
		internal static DiagnosticSwitch[] diagnosticSwitches { get => default; } // 0x000000018BEB9710-0x000000018BEB973C 
		public static ILogger logger { get => default; } // 0x000000018BEB973C-0x000000018BEB978C 
	
		// Constructors
		public Debug() {} // 0x0000000185492010-0x0000000185492020
		static Debug() {} // 0x0000000185D4C670-0x0000000185D4C780
	
		// Methods
		public static void DrawLine(Vector3 start, Vector3 end, UnityEngine.Color color, float duration) {} // 0x000000018BEB87A8-0x000000018BEB8854
		public static void DrawLine(Vector3 start, Vector3 end, UnityEngine.Color color) {} // 0x000000018BEB8854-0x000000018BEB88F4
		public static void DrawLine(Vector3 start, Vector3 end) {} // 0x000000018BEB88F4-0x000000018BEB899C
		public static void DrawLine(Vector3 start, Vector3 end, UnityEngine.Color color, float duration, bool depthTest) {} // 0x000000018BEB872C-0x000000018BEB87A8
		public static void DrawRay(Vector3 start, Vector3 dir, UnityEngine.Color color, float duration) {} // 0x000000018BEB899C-0x000000018BEB8A48
		public static void DrawRay(Vector3 start, Vector3 dir, UnityEngine.Color color) {} // 0x000000018BEB8BE0-0x000000018BEB8C80
		public static void DrawRay(Vector3 start, Vector3 dir) {} // 0x000000018BEB8B38-0x000000018BEB8BE0
		public static void DrawRay(Vector3 start, Vector3 dir, UnityEngine.Color color, float duration, bool depthTest) {} // 0x000000018BEB8A48-0x000000018BEB8B38
		public static void Break() {} // 0x000000018BEB8490-0x000000018BEB84BC
		public static void DebugBreak() {} // 0x000000018BEB869C-0x000000018BEB86C8
		public static unsafe int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder) => default; // 0x00000001843D8070-0x00000001843D80D0
		public static void Log(object message) {} // 0x00000001856B5690-0x00000001856B5770
		public static void Log(object message, UnityEngine.Object context) {} // 0x000000018BEB9584-0x000000018BEB95EC
		public static void LogFormat(string format, object[] args) {} // 0x000000018BEB935C-0x000000018BEB93C4
		public static void LogFormat(UnityEngine.Object context, string format, object[] args) {} // 0x000000018BEB93C4-0x000000018BEB943C
		public static void LogFormat(UnityEngine.LogType logType, LogOption logOptions, UnityEngine.Object context, string format, object[] args) {} // 0x00000001841C9AA0-0x00000001841C9CF0
		public static void LogError(object message) {} // 0x000000018BEB9250-0x000000018BEB92A8
		public static void LogError(object message, UnityEngine.Object context) {} // 0x00000001856B5840-0x00000001856B5940
		public static void LogErrorFormat(string format, object[] args) {} // 0x000000018BEB91E8-0x000000018BEB9250
		public static void LogErrorFormat(UnityEngine.Object context, string format, object[] args) {} // 0x000000018BEB9170-0x000000018BEB91E8
		public static void LogCritical(object message) {} // 0x000000018BEB9118-0x000000018BEB9170
		public static void LogCritical(object message, UnityEngine.Object context) {} // 0x000000018BEB90B4-0x000000018BEB9118
		public static void LogCriticalFormat(string format, object[] args) {} // 0x000000018BEB9050-0x000000018BEB90B4
		public static void LogCriticalFormat(UnityEngine.Object context, string format, object[] args) {} // 0x000000018BEB8FD8-0x000000018BEB9050
		public static void ClearDeveloperConsole() {} // 0x000000018BEB8670-0x000000018BEB869C
		public static void LogException(Exception exception) {} // 0x000000018BEB92A8-0x000000018BEB92FC
		public static void LogException(Exception exception, UnityEngine.Object context) {} // 0x000000018BEB92FC-0x000000018BEB935C
		public static void LogWarning(object message) {} // 0x00000001856B5620-0x00000001856B5690
		public static void LogWarning(object message, UnityEngine.Object context) {} // 0x000000018BEB951C-0x000000018BEB9584
		public static void LogWarningFormat(string format, object[] args) {} // 0x000000018BEB943C-0x000000018BEB94A4
		public static void LogWarningFormat(UnityEngine.Object context, string format, object[] args) {} // 0x000000018BEB94A4-0x000000018BEB951C
		public static void Assert(bool condition) {} // 0x0000000184015EE0-0x0000000184015F30
		public static void Assert(bool condition, UnityEngine.Object context) {} // 0x000000018BEB839C-0x000000018BEB8418
		public static void Assert(bool condition, object message) {} // 0x000000018BEB8254-0x000000018BEB82BC
		public static void Assert(bool condition, string message) {} // 0x000000018BEB82BC-0x000000018BEB8324
		public static void Assert(bool condition, object message, UnityEngine.Object context) {} // 0x000000018BEB81DC-0x000000018BEB8254
		public static void Assert(bool condition, string message, UnityEngine.Object context) {} // 0x000000018BEB8324-0x000000018BEB839C
		public static void AssertFormat(bool condition, string format, object[] args) {} // 0x000000018BEB8164-0x000000018BEB81DC
		public static void AssertFormat(bool condition, UnityEngine.Object context, string format, object[] args) {} // 0x000000018BEB80DC-0x000000018BEB8164
		public static void LogAssertion(object message) {} // 0x000000018BEB8F18-0x000000018BEB8F70
		public static void LogAssertion(object message, UnityEngine.Object context) {} // 0x000000018BEB8F70-0x000000018BEB8FD8
		public static void LogAssertionFormat(string format, object[] args) {} // 0x000000018BEB8EB0-0x000000018BEB8F18
		public static void LogAssertionFormat(UnityEngine.Object context, string format, object[] args) {} // 0x000000018BEB8E38-0x000000018BEB8EB0
		internal static void OpenConsoleFile() {} // 0x000000018BEB95EC-0x000000018BEB9618
		internal static DiagnosticSwitch GetDiagnosticSwitch(string name) => default; // 0x000000018BEB8C80-0x000000018BEB8D90
		internal static bool CallOverridenDebugHandler(Exception exception, UnityEngine.Object obj) => default; // 0x000000018BEB84BC-0x000000018BEB8670
		internal static bool IsLoggingEnabled() => default; // 0x000000018BEB8D90-0x000000018BEB8E38
		public static void SetStripLogInRelease(bool enable) {} // 0x000000018BEB9618-0x000000018BEB964C
		public static void Assert(bool condition, string format, object[] args) {} // 0x000000018BEB8418-0x000000018BEB8490
		private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref UnityEngine.Color color, float duration, bool depthTest) {} // 0x000000018BEB86C8-0x000000018BEB872C
	}

	internal class DiagnosticSwitch // TypeDefIndex: 47355
	{
		// Fields
		private IntPtr m_Ptr; // 0x10
	
		// Properties
		public string name { get => default; } // 0x000000018BEB98C0-0x000000018BEB98F4 
	
		// Constructors
		private DiagnosticSwitch() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public struct ExposedReference<T> // TypeDefIndex: 47356
		where T : UnityEngine.Object
	{
		// Fields
		public PropertyName exposedName;
		public UnityEngine.Object defaultValue;
	
		// Methods
		public T Resolve(IExposedPropertyTable resolver) => default;
	}

	public interface IExposedPropertyTable // TypeDefIndex: 47357
	{
		// Methods
		void SetReferenceValue(PropertyName id, UnityEngine.Object value);
		UnityEngine.Object GetReferenceValue(PropertyName id, out bool idValid);
	}

	public struct Bounds : IEquatable<Bounds>, IFormattable // TypeDefIndex: 47358
	{
		// Fields
		private Vector3 m_Center; // 0x00
		private Vector3 m_Extents; // 0x0C
	
		// Properties
		public Vector3 center { get => default; set {} } // 0x0000000185FE65B0-0x0000000185FE65D0 0x0000000185FB7BD0-0x0000000185FB7BE0
		public Vector3 size { get => default; set {} } // 0x00000001840E88B0-0x00000001840E8900 0x000000018646DBD4-0x000000018646DC1C
		public Vector3 extents { get => default; set {} } // 0x0000000185FE6590-0x0000000185FE65B0 0x0000000185FB7BE0-0x0000000185FB7BF0
		public Vector3 min { get => default; set {} } // 0x0000000184135150-0x00000001841351B0 0x000000018BEB4F88-0x000000018BEB4FEC
		public Vector3 max { get => default; set {} } // 0x00000001841351B0-0x0000000184135210 0x000000018BEB4F30-0x000000018BEB4F88
	
		// Constructors
		public Bounds(Vector3 center, Vector3 size) : this() {
			m_Center = default;
			m_Extents = default;
		} // 0x00000001840E8F20-0x00000001840E8F80
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018BEB4C20-0x000000018BEB4C78
		public override bool Equals(object other) => default; // 0x000000018BEB4B1C-0x000000018BEB4BA0
		public bool Equals(Bounds other) => default; // 0x000000018BEB4AA0-0x000000018BEB4B1C
		public static bool operator ==(Bounds lhs, Bounds rhs) => default; // 0x0000000184213990-0x0000000184213A30
		public static bool operator !=(Bounds lhs, Bounds rhs) => default; // 0x0000000184213A30-0x0000000184213AF0
		public void SetMinMax(Vector3 min, Vector3 max) {} // 0x0000000184133440-0x0000000184133510
		public void Encapsulate(Vector3 point) {} // 0x0000000184133510-0x00000001841336A0
		public void Encapsulate(Bounds bounds) {} // 0x0000000184133370-0x0000000184133440
		public void Expand(float amount) {} // 0x0000000184133B20-0x0000000184133B80
		public void Expand(Vector3 amount) {} // 0x000000018BEB4BA0-0x000000018BEB4C20
		public bool Intersects(Bounds bounds) => default; // 0x0000000184134DC0-0x0000000184135150
		public bool IntersectRay(Ray ray) => default; // 0x000000018BEB4CE0-0x000000018BEB4D2C
		public bool IntersectRay(Ray ray, out float distance) {
			distance = default;
			return default;
		} // 0x000000018BEB4D2C-0x000000018BEB4D70
		public override string ToString() => default; // 0x000000018BEB4F10-0x000000018BEB4F20
		public string ToString(string format) => default; // 0x000000018BEB4F20-0x000000018BEB4F30
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEB4DC8-0x000000018BEB4F10
		public bool Contains(Vector3 point) => default; // 0x000000018646DD98-0x000000018646DDAC
		public float SqrDistance(Vector3 point) => default; // 0x000000018BEB4DB4-0x000000018BEB4DC8
		private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist) {
			dist = default;
			return default;
		} // 0x000000018BEB4CCC-0x000000018BEB4CE0
		public Vector3 ClosestPoint(Vector3 point) => default; // 0x00000001845C06C0-0x00000001845C0730
		private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point) => default; // 0x0000000184844E30-0x0000000184844E80
		private static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point) => default; // 0x000000018BEB4D70-0x000000018BEB4DB4
		private static bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist) {
			dist = default;
			return default;
		} // 0x000000018BEB4C78-0x000000018BEB4CCC
		private static void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret) {
			ret = default;
		} // 0x00000001845C08C0-0x00000001845C0920
	}

	public struct BoundsInt : IEquatable<BoundsInt>, IFormattable // TypeDefIndex: 47360
	{
		// Fields
		private Vector3Int m_Position; // 0x00
		private Vector3Int m_Size; // 0x0C
	
		// Properties
		public Vector3Int min { get => default; set {} } // 0x000000018BEB4A48-0x000000018BEB4A74 0x000000018BEB4984-0x000000018BEB49E0
		public Vector3Int max { get => default; set {} } // 0x000000018BEB4A74-0x000000018BEB4AA0 0x000000018BEB47B8-0x000000018BEB4814
		public int xMin { get => default; set {} } // 0x0000000185FE67E0-0x0000000185FE67F0 0x000000018BEB4870-0x000000018BEB48CC
		public int yMin { get => default; set {} } // 0x0000000185FE67F0-0x0000000185FE6800 0x000000018BEB4928-0x000000018BEB4984
		public int zMin { get => default; set {} } // 0x0000000185FE6800-0x0000000185FE6810 0x0000000185FE6590-0x0000000185FE65B0
		public int xMax { get => default; set {} } // 0x0000000185FB1480-0x0000000185FB14A0 0x000000018BEB4640-0x000000018BEB4650
		public int yMax { get => default; set {} } // 0x000000018BEB4518-0x000000018BEB4640 0x000000018BEB446C-0x000000018BEB44F0
		public int zMax { get => default; set {} } // 0x000000018BEB43F4-0x000000018BEB446C 0x000000018BEB44F0-0x000000018BEB4518
		public Vector3Int size { get => default; } // 0x000000018BEB4650-0x000000018BEB4700 
		public PositionEnumerator allPositionsWithin { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		public struct PositionEnumerator : IEnumerator<Vector3Int> // TypeDefIndex: 47359
		{
			// Fields
			private readonly Vector3Int _min; // 0x00
			private readonly Vector3Int _max; // 0x0C
			private Vector3Int _current; // 0x18
	
			// Properties
			public Vector3Int Current { get => default; } // 0x000000018BEB4814-0x000000018BEB4870 
			object IEnumerator.Current { get => default; } // 0x000000018BEB4A20-0x000000018BEB4A48 
	
			// Constructors
			public PositionEnumerator(Vector3Int min, Vector3Int max) : this() {
				_min = default;
				_max = default;
				_current = default;
			} // 0x000000018BEB475C-0x000000018BEB47B8
	
			// Methods
			public PositionEnumerator GetEnumerator() => default; // 0x000000018BEB49E0-0x000000018BEB4A20
			public bool MoveNext() => default; // 0x000000018BEB4700-0x000000018BEB475C
			public void Reset() {} // 0x0000000185FE67C0-0x0000000185FE67E0
			void IDisposable.Dispose() {} // 0x000000018BEB48CC-0x000000018BEB4928
		}
	
		// Constructors
		public BoundsInt(Vector3Int position, Vector3Int size) : this() {
			m_Position = default;
			m_Size = default;
		} // 0x000000018BEC5F18-0x000000018BEC5F4C
	
		// Methods
		public override string ToString() => default; // 0x0000000185FE6930-0x0000000185FE6950
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEC5DBC-0x000000018BEC5E70
		public override bool Equals(object other) => default; // 0x0000000185FE6950-0x0000000185FE6970
		public bool Equals(BoundsInt other) => default; // 0x0000000185FE6980-0x0000000185FE69A0
		public override int GetHashCode() => default; // 0x000000018BEC5EB8-0x000000018BEC5F08
	}

	public sealed class GeometryUtility // TypeDefIndex: 47361
	{
		// Constructors
		public GeometryUtility() {} // Dummy constructor
	
		// Methods
		public static void CalculateFrustumPlanes(Camera camera, Plane[] planes) {} // 0x000000018BEB9B60-0x000000018BEB9C6C
		public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) {} // 0x00000001846B0AE0-0x00000001846B0B70
		public static void SPMDCullAABB(Matrix4x4 viewProj, NativeArray<float> centerXs, NativeArray<float> centerYs, NativeArray<float> centerZs, NativeArray<float> halfExtentXs, NativeArray<float> halfExtentYs, NativeArray<float> halfExtentZs, NativeArray<int> visibilityOut) {} // 0x000000018BEB9FEC-0x000000018BEBA194
		public static void SPMDCullAABBNoFar(Matrix4x4 viewProj, NativeArray<float> centerXs, NativeArray<float> centerYs, NativeArray<float> centerZs, NativeArray<float> halfExtentXs, NativeArray<float> halfExtentYs, NativeArray<float> halfExtentZs, NativeArray<int> visibilityOut) {} // 0x000000018BEB9E44-0x000000018BEB9FEC
		public static bool TestPlanesAABB(Plane[] planes, Bounds bounds) => default; // 0x000000018BEBA1D8-0x000000018BEBA1EC
		private static void Internal_SPMDCullAABB(Matrix4x4 viewProj, uint aabbCount, UIntPtr centerXs, UIntPtr centerYs, UIntPtr centerZs, UIntPtr halfExtentXs, UIntPtr halfExtentYs, UIntPtr halfExtentZs, IntPtr visibilityOut) {} // 0x000000018BEB9DEC-0x000000018BEB9E44
		private static void Internal_SPMDCullAABBNoFar(Matrix4x4 viewProj, uint aabbCount, UIntPtr centerXs, UIntPtr centerYs, UIntPtr centerZs, UIntPtr halfExtentXs, UIntPtr halfExtentYs, UIntPtr halfExtentZs, IntPtr visibilityOut) {} // 0x000000018BEB9D34-0x000000018BEB9D8C
		public static float DistFromAABBToPoint(Vector3 bCenter, Vector3 bExtent, Vector3 point) => default; // 0x000000018BEB9CC0-0x000000018BEB9CD4
		private static void Internal_ExtractPlanes(out Plane[] planes, Matrix4x4 worldToProjectionMatrix) {
			planes = default;
		} // 0x000000018646FC04-0x000000018646FC18
		private static bool TestPlanesAABB_Injected(Plane[] planes, ref Bounds bounds) => default; // 0x000000018BEBA194-0x000000018BEBA1D8
		private static void Internal_SPMDCullAABB_Injected(ref Matrix4x4 viewProj, uint aabbCount, UIntPtr centerXs, UIntPtr centerYs, UIntPtr centerZs, UIntPtr halfExtentXs, UIntPtr halfExtentYs, UIntPtr halfExtentZs, IntPtr visibilityOut) {} // 0x000000018BEB9D8C-0x000000018BEB9DEC
		private static void Internal_SPMDCullAABBNoFar_Injected(ref Matrix4x4 viewProj, uint aabbCount, UIntPtr centerXs, UIntPtr centerYs, UIntPtr centerZs, UIntPtr halfExtentXs, UIntPtr halfExtentYs, UIntPtr halfExtentZs, IntPtr visibilityOut) {} // 0x000000018BEB9CD4-0x000000018BEB9D34
		private static float DistFromAABBToPoint_Injected(ref Vector3 bCenter, ref Vector3 bExtent, ref Vector3 point) => default; // 0x000000018BEB9C6C-0x000000018BEB9CC0
		private static void Internal_ExtractPlanes_Injected(out Plane[] planes, ref Matrix4x4 worldToProjectionMatrix) {
			planes = default;
		} // 0x00000001846B0B70-0x00000001846B0BC0
	}

	public struct Plane : IFormattable // TypeDefIndex: 47362
	{
		// Fields
		internal const int size = 16; // Metadata: 0x020603D2
		private Vector3 m_Normal; // 0x00
		private float m_Distance; // 0x0C
	
		// Properties
		public Vector3 normal { get => default; set {} } // 0x0000000185FE65B0-0x0000000185FE65D0 0x0000000185FB7BD0-0x0000000185FB7BE0
		public float distance { get => default; set {} } // 0x0000000185FE66F0-0x0000000185FE6700 0x0000000185FBF770-0x0000000185FBF780
	
		// Constructors
		public Plane(Vector3 inNormal, Vector3 inPoint) : this() {
			m_Normal = default;
			m_Distance = default;
		} // 0x00000001842348D0-0x0000000184234950
		public Plane(Vector3 inNormal, float d) : this() {
			m_Normal = default;
			m_Distance = default;
		} // 0x000000018BEC5C10-0x000000018BEC5C60
		public Plane(Vector3 a, Vector3 b, Vector3 c) : this() {
			m_Normal = default;
			m_Distance = default;
		} // 0x000000018BEC5C60-0x000000018BEC5D78
	
		// Methods
		public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint) {} // 0x00000001846B0990-0x00000001846B0AE0
		public float GetDistanceToPoint(Vector3 point) => default; // 0x000000018BEC5984-0x000000018BEC59C8
		public bool GetSide(Vector3 point) => default; // 0x000000018BEC59C8-0x000000018BEC5A18
		public bool SameSide(Vector3 inPt0, Vector3 inPt1) => default; // 0x000000018BEC5A18-0x000000018BEC5AB8
		public bool Raycast(Ray ray, out float enter) {
			enter = default;
			return default;
		} // 0x00000001842347A0-0x00000001842348D0
		public override string ToString() => default; // 0x000000018BEC5C00-0x000000018BEC5C10
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEC5AB8-0x000000018BEC5C00
	}

	public struct Ray : IFormattable // TypeDefIndex: 47363
	{
		// Fields
		private Vector3 m_Origin; // 0x00
		private Vector3 m_Direction; // 0x0C
	
		// Properties
		public Vector3 origin { get => default; set {} } // 0x0000000185FE65B0-0x0000000185FE65D0 0x0000000185FB7BD0-0x0000000185FB7BE0
		public Vector3 direction { get => default; set {} } // 0x0000000185FE6590-0x0000000185FE65B0 0x000000018BEC67C4-0x000000018BEC67EC
	
		// Constructors
		public Ray(Vector3 origin, Vector3 direction) : this() {
			m_Origin = default;
			m_Direction = default;
		} // 0x000000018646E4D4-0x000000018646E510
	
		// Methods
		public Vector3 GetPoint(float distance) => default; // 0x0000000184234D80-0x0000000184234E10
		public override string ToString() => default; // 0x000000018BEC665C-0x000000018BEC666C
		public string ToString(string format) => default; // 0x000000018BEC67B4-0x000000018BEC67C4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEC666C-0x000000018BEC67B4
	}

	public struct Ray2D : IFormattable // TypeDefIndex: 47364
	{
		// Fields
		private Vector2 m_Origin; // 0x00
		private Vector2 m_Direction; // 0x08
	
		// Properties
		public Vector2 origin { get => default; set {} } // 0x0000000184142CB0-0x0000000184142CC0 0x0000000185FB2BB0-0x0000000185FB2BC0
		public Vector2 direction { get => default; set {} } // 0x0000000185FE69B0-0x0000000185FE69D0 0x000000018BEC6620-0x000000018BEC665C
	
		// Constructors
		public Ray2D(Vector2 origin, Vector2 direction) : this() {
			m_Origin = default;
			m_Direction = default;
		} // 0x000000018BEC65E4-0x000000018BEC6620
	
		// Methods
		public Vector2 GetPoint(float distance) => default; // 0x000000018BEC644C-0x000000018BEC647C
		public override string ToString() => default; // 0x000000018BEC648C-0x000000018BEC649C
		public string ToString(string format) => default; // 0x000000018BEC647C-0x000000018BEC648C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEC649C-0x000000018BEC65E4
	}

	public struct Rect : IEquatable<Rect>, IFormattable // TypeDefIndex: 47365
	{
		// Fields
		private float m_XMin; // 0x00
		private float m_YMin; // 0x04
		private float m_Width; // 0x08
		private float m_Height; // 0x0C
	
		// Properties
		public static Rect zero { get => default; } // 0x0000000185FB2C70-0x0000000185FB2C80 
		public float x { get => default; set {} } // 0x0000000185FE6770-0x0000000185FE6780 0x0000000185FBA160-0x0000000185FBA170
		public float y { get => default; set {} } // 0x0000000185FE64E0-0x0000000185FE64F0 0x0000000185FBA180-0x0000000185FBA190
		public Vector2 position { get => default; set {} } // 0x0000000185FE6AE0-0x0000000185FE6B00 0x0000000185FE0590-0x0000000185FE05B0
		public Vector2 center { get => default; set {} } // 0x00000001842DC120-0x00000001842DC150 0x0000000184F1FEE0-0x0000000184F1FF20
		public Vector2 min { get => default; set {} } // 0x0000000185FE6AC0-0x0000000185FE6AE0 0x000000018BEC758C-0x000000018BEC75CC
		public Vector2 max { get => default; set {} } // 0x0000000185FE6AA0-0x0000000185FE6AC0 0x0000000185FE6B10-0x0000000185FE6B40
		public float width { get => default; set {} } // 0x0000000185FE64D0-0x0000000185FE64E0 0x0000000185FBA170-0x0000000185FBA180
		public float height { get => default; set {} } // 0x0000000185FE66F0-0x0000000185FE6700 0x0000000185FBF770-0x0000000185FBF780
		public Vector2 size { get => default; set {} } // 0x0000000185FE69B0-0x0000000185FE69D0 0x0000000185FE6B40-0x0000000185FE6B60
		public float xMin { get => default; set {} } // 0x0000000185FE6770-0x0000000185FE6780 0x0000000185FE6B60-0x0000000185FE6B80
		public float yMin { get => default; set {} } // 0x0000000185FE64E0-0x0000000185FE64F0 0x0000000185FE6B80-0x0000000185FE6BA0
		public float xMax { get => default; set {} } // 0x0000000185FE6B00-0x0000000185FE6B10 0x0000000185FD4330-0x0000000185FD4340
		public float yMax { get => default; set {} } // 0x0000000185FE6A90-0x0000000185FE6AA0 0x0000000185FD4340-0x0000000185FD4350
		public float left { get => default; } // 0x0000000185FE6770-0x0000000185FE6780 
		public float right { get => default; } // 0x0000000185FE6B00-0x0000000185FE6B10 
		public float top { get => default; } // 0x0000000185FE64E0-0x0000000185FE64F0 
		public float bottom { get => default; } // 0x0000000185FE6A90-0x0000000185FE6AA0 
	
		// Constructors
		public Rect(float x, float y, float width, float height) : this() {
			m_XMin = default;
			m_YMin = default;
			m_Width = default;
			m_Height = default;
		} // 0x0000000185FB2B40-0x0000000185FB2B60
		public Rect(Vector2 position, Vector2 size) : this() {
			m_XMin = default;
			m_YMin = default;
			m_Width = default;
			m_Height = default;
		} // 0x0000000185FE27B0-0x0000000185FE27F0
		public Rect(Rect source) : this() {
			m_XMin = default;
			m_YMin = default;
			m_Width = default;
			m_Height = default;
		} // 0x0000000185FBF140-0x0000000185FBF160
	
		// Methods
		public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) => default; // 0x0000000185FE6A50-0x0000000185FE6A90
		public void Set(float x, float y, float width, float height) {} // 0x0000000185FB2B40-0x0000000185FB2B60
		public bool Contains(Vector2 point) => default; // 0x0000000183FAA3C0-0x0000000183FAA4A0
		public bool Contains(Vector3 point) => default; // 0x00000001842AFD10-0x00000001842AFD50
		public bool Contains(Vector3 point, bool allowInverse) => default; // 0x000000018BEC7070-0x000000018BEC714C
		private static Rect OrderMinMax(Rect rect) => default; // 0x00000001840E6250-0x00000001840E6290
		public bool Overlaps(Rect other) => default; // 0x00000001840E6290-0x00000001840E62E0
		public bool Overlaps(Rect other, bool allowInverse) => default; // 0x00000001840E6120-0x00000001840E6250
		public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates) => default; // 0x000000018BEC7308-0x000000018BEC7354
		public static Vector2 PointToNormalized(Rect rectangle, Vector2 point) => default; // 0x000000018BEC7354-0x000000018BEC73A0
		public static bool operator !=(Rect lhs, Rect rhs) => default; // 0x00000001841EEC00-0x00000001841EEC50
		public static bool operator ==(Rect lhs, Rect rhs) => default; // 0x00000001841EEC50-0x00000001841EEC90
		public override int GetHashCode() => default; // 0x000000018BEC726C-0x000000018BEC7308
		public override bool Equals(object other) => default; // 0x000000018BEC714C-0x000000018BEC71C4
		public bool Equals(Rect other) => default; // 0x000000018BEC71C4-0x000000018BEC726C
		public override string ToString() => default; // 0x000000018BEC73A0-0x000000018BEC73B0
		public string ToString(string format) => default; // 0x000000018BEC73B0-0x000000018BEC73C0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEC73C0-0x000000018BEC758C
	}

	public struct RectInt : IEquatable<RectInt>, IFormattable // TypeDefIndex: 47367
	{
		// Fields
		private int m_XMin; // 0x00
		private int m_YMin; // 0x04
		private int m_Width; // 0x08
		private int m_Height; // 0x0C
	
		// Properties
		public int x { get => default; set {} } // 0x000000018BEC6C1C-0x000000018BEC6C4C 0x0000000185FE69F0-0x0000000185FE6A10
		public int y { get => default; set {} } // 0x00000001835DC780-0x00000001835DC790 0x0000000185FB2B90-0x0000000185FB2BA0
		public Vector2 center { get => default; } // 0x0000000185FC9070-0x0000000185FC9080 
		public Vector2Int min { get => default; set {} } // 0x0000000185FB6960-0x0000000185FB6970 0x000000018429B210-0x000000018429B280
		public Vector2Int max { get => default; set {} } // 0x000000018BEC6CA8-0x000000018BEC6CD0 0x000000018429B280-0x000000018429B2F0
		public int width { get => default; set {} } // 0x000000018BEC6CD0-0x000000018BEC6CFC 0x000000018429B2F0-0x000000018429B360
		public int height { get => default; set {} } // 0x0000000185FE6A30-0x0000000185FE6A40 0x000000018429A5E0-0x000000018429A650
		public int xMin { get => default; set {} } // 0x0000000185FE6A40-0x0000000185FE6A50 0x0000000185FBF370-0x0000000185FBF390
		public int yMin { get => default; set {} } // 0x0000000185FE6A10-0x0000000185FE6A20 0x0000000185FD7F70-0x0000000185FD7F90
		public int xMax { get => default; set {} } // 0x0000000185FE6A20-0x0000000185FE6A30 0x000000018BEC69C4-0x000000018BEC69F4
		public int yMax { get => default; set {} } // 0x0000000185FB2C50-0x0000000185FB2C70 0x0000000185FE69D0-0x0000000185FE69F0
		public Vector2Int position { get => default; set {} } // 0x000000018BEC67EC-0x000000018BEC6930 0x000000018429B060-0x000000018429B210
		public Vector2Int size { get => default; set {} } // 0x000000018BEC6930-0x000000018BEC69C4 0x000000018BEC6B90-0x000000018BEC6BA0
		public PositionEnumerator allPositionsWithin { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		public struct PositionEnumerator : IEnumerator<Vector2Int> // TypeDefIndex: 47366
		{
			// Fields
			private readonly Vector2Int _min; // 0x00
			private readonly Vector2Int _max; // 0x08
			private Vector2Int _current; // 0x10
	
			// Properties
			public Vector2Int Current { get => default; } // 0x00000001840D13C0-0x00000001840D1490 
			object IEnumerator.Current { get => default; } // 0x000000018BEC6C4C-0x000000018BEC6C7C 
	
			// Constructors
			public PositionEnumerator(Vector2Int min, Vector2Int max) : this() {
				_min = default;
				_max = default;
				_current = default;
			} // 0x0000000185FE64F0-0x0000000185FE6500
	
			// Methods
			public PositionEnumerator GetEnumerator() => default; // 0x00000001818AA390-0x00000001818AA3A0
			public bool MoveNext() => default; // 0x0000000185FCA560-0x0000000185FCA570
			public void Reset() {} // 0x0000000185FB2BA0-0x0000000185FB2BB0
			void IDisposable.Dispose() {} // 0x000000018BEC6C7C-0x000000018BEC6CA8
		}
	
		// Constructors
		public RectInt(int xMin, int yMin, int width, int height) : this() {
			m_XMin = default;
			m_YMin = default;
			m_Width = default;
			m_Height = default;
		} // 0x000000018BEC69F4-0x000000018BEC6B90
		public RectInt(Vector2Int position, Vector2Int size) : this() {
			m_XMin = default;
			m_YMin = default;
			m_Width = default;
			m_Height = default;
		} // 0x0000000184102E10-0x0000000184102E40
	
		// Methods
		public void SetMinMax(Vector2Int minPosition, Vector2Int maxPosition) {} // 0x000000018BEC6BA0-0x000000018BEC6BB0
		public void ClampToBounds(RectInt bounds) {} // 0x000000018BEC6BB0-0x000000018BEC6C1C
		public bool Contains(Vector2Int position) => default; // 0x000000018BEC5F08-0x000000018BEC5F18
		public bool Overlaps(RectInt other) => default; // 0x0000000185FE6910-0x0000000185FE6930
		public override string ToString() => default; // 0x000000018BEC5D78-0x000000018BEC5DBC
		public string ToString(string format) => default; // 0x0000000185FE6970-0x0000000185FE6980
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000185FC7990-0x0000000185FC79A0
		public bool Equals(RectInt other) => default; // 0x000000018BEC5E70-0x000000018BEC5EB8
	}

	[Serializable]
	public class RectOffset : IFormattable // TypeDefIndex: 47368
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		private readonly object m_SourceStyle; // 0x18
	
		// Properties
		public int left { get => default; set {} } // 0x00000001844311B0-0x00000001844311F0 0x000000018588B710-0x000000018588B760
		public int right { get => default; set {} } // 0x00000001845E5740-0x00000001845E5780 0x0000000185B66350-0x0000000185B663A0
		public int top { get => default; set {} } // 0x0000000184430C80-0x0000000184430CC0 0x0000000185820A10-0x0000000185820A60
		public int bottom { get => default; set {} } // 0x00000001845E5700-0x00000001845E5740 0x0000000185EBE300-0x0000000185EBE350
		public int horizontal { get => default; } // 0x0000000184431170-0x00000001844311B0 
		public int vertical { get => default; } // 0x0000000184430C40-0x0000000184430C80 
	
		// Constructors
		public RectOffset() {} // 0x0000000184DBEB50-0x0000000184DBEB90
		internal RectOffset(object sourceStyle, IntPtr source) {} // 0x000000018BEC6FDC-0x000000018BEC6FFC
		public RectOffset(int left, int right, int top, int bottom) {} // 0x000000018BEC6FFC-0x000000018BEC7070
	
		// Methods
		~RectOffset() {} // 0x00000001851A2A20-0x00000001851A2AC0
		public override string ToString() => default; // 0x000000018BEC6E14-0x000000018BEC6E24
		public string ToString(string format) => default; // 0x000000018BEC6E04-0x000000018BEC6E14
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEC6E24-0x000000018BEC6FDC
		private void Destroy() {} // 0x00000001851A2AC0-0x00000001851A2AF0
		private static IntPtr InternalCreate() => default; // 0x0000000184DBEB90-0x0000000184DBED70
		private static void InternalDestroy(IntPtr ptr) {} // 0x00000001851A2AF0-0x00000001851A2B30
		public Rect Add(Rect rect) => default; // 0x000000018BEC6D50-0x000000018BEC6D80
		public Rect Remove(Rect rect) => default; // 0x000000018BEC6DD4-0x000000018BEC6E04
		private void Add_Injected(ref Rect rect, out Rect ret) {
			ret = default;
		} // 0x000000018BEC6CFC-0x000000018BEC6D50
		private void Remove_Injected(ref Rect rect, out Rect ret) {
			ret = default;
		} // 0x000000018BEC6D80-0x000000018BEC6DD4
	}

	public sealed class LightingSettings : UnityEngine.Object // TypeDefIndex: 47369
	{
		// Constructors
		public LightingSettings() {} // Dummy constructor
	
		// Methods
		internal void LightingSettingsDontStripMe() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class Gizmos // TypeDefIndex: 47370
	{
		// Properties
		public static UnityEngine.Color color { set {} } // 0x000000018BEBA79C-0x000000018BEBA7AC
		public static Matrix4x4 matrix { set {} } // 0x000000018BEBA7E0-0x000000018BEBA7F0
	
		// Constructors
		public Gizmos() {} // Dummy constructor
	
		// Methods
		public static void DrawLine(Vector3 from, Vector3 to) {} // 0x000000018BEBA314-0x000000018BEBA328
		public static void DrawWireSphere(Vector3 center, float radius) {} // 0x000000018BEBA754-0x000000018BEBA768
		public static void DrawSphere(Vector3 center, float radius) {} // 0x000000018BEBA54C-0x000000018BEBA560
		public static void DrawWireCube(Vector3 center, Vector3 size) {} // 0x000000018BEBA5A4-0x000000018BEBA5B8
		public static void DrawCube(Vector3 center, Vector3 size) {} // 0x000000018BEBA230-0x000000018BEBA244
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) {} // 0x000000018BEBA418-0x000000018BEBA43C
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) {} // 0x000000018BEBA618-0x000000018BEBA63C
		public static void DrawMeshWithMaterial(Mesh mesh, Material material, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) {} // 0x000000018BEBA38C-0x000000018BEBA3B8
		public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) {} // 0x000000018BEBA2AC-0x000000018BEBA2D0
		public static void DrawRay(Vector3 from, Vector3 direction) {} // 0x000000018BEBA494-0x000000018BEBA508
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) {} // 0x000000018BEBA43C-0x000000018BEBA494
		public static void DrawWireMesh(Mesh mesh) {} // 0x000000018BEBA694-0x000000018BEBA710
		public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) {} // 0x000000018BEBA63C-0x000000018BEBA694
		private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) {} // 0x000000018BEBA2D0-0x000000018BEBA314
		private static void DrawWireSphere_Injected(ref Vector3 center, float radius) {} // 0x000000018BEBA710-0x000000018BEBA754
		private static void DrawSphere_Injected(ref Vector3 center, float radius) {} // 0x000000018BEBA508-0x000000018BEBA54C
		private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) {} // 0x000000018BEBA560-0x000000018BEBA5A4
		private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) {} // 0x000000018BEBA1EC-0x000000018BEBA230
		private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) {} // 0x000000018BEBA3B8-0x000000018BEBA418
		private static void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) {} // 0x000000018BEBA5B8-0x000000018BEBA618
		private static void DrawMeshWithMaterial_Injected(Mesh mesh, Material material, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) {} // 0x000000018BEBA328-0x000000018BEBA38C
		private static void set_color_Injected(ref UnityEngine.Color value) {} // 0x000000018BEBA768-0x000000018BEBA79C
		private static void set_matrix_Injected(ref Matrix4x4 value) {} // 0x000000018BEBA7AC-0x000000018BEBA7E0
		private static void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect) {} // 0x000000018BEBA244-0x000000018BEBA2AC
	}

	public class BeforeRenderOrderAttribute : Attribute // TypeDefIndex: 47371
	{
		// Fields
		private int _order_k__BackingField; // 0x10
	
		// Properties
		public int order { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
	
		// Constructors
		public BeforeRenderOrderAttribute() {} // Dummy constructor
	}

	internal static class BeforeRenderHelper // TypeDefIndex: 47373
	{
		// Fields
		private static List<OrderBlock> s_OrderBlocks; // 0x00
	
		// Nested types
		private struct OrderBlock // TypeDefIndex: 47372
		{
			// Fields
			internal int order; // 0x00
			internal UnityAction callback; // 0x08
		}
	
		// Constructors
		static BeforeRenderHelper() {} // 0x0000000185F40DE0-0x0000000185F40E70
	
		// Methods
		private static int GetUpdateOrder(UnityAction callback) => default; // 0x000000018BEB3AF0-0x000000018BEB3BCC
		public static void RegisterCallback(UnityAction callback) {} // 0x000000018BEB3BCC-0x000000018BEB3FE0
		public static void UnregisterCallback(UnityAction callback) {} // 0x000000018BEB3FE0-0x000000018BEB4328
		public static void Invoke() {} // 0x00000001843FE860-0x00000001843FE9F0
	}

	public static class CustomRenderTextureManager // TypeDefIndex: 47374
	{
		// Fields
		private static Action<CustomRenderTexture> textureLoaded; // 0x00
		private static Action<CustomRenderTexture> textureUnloaded; // 0x08
	
		// Methods
		private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) {} // 0x000000018BEB7F84-0x000000018BEB7FD0
		private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) {} // 0x000000018BEB7FD0-0x000000018BEB8020
	}

	public class Display // TypeDefIndex: 47377
	{
		// Fields
		internal IntPtr nativeDisplay; // 0x10
		public static Display[] displays; // 0x00
		private static Display _mainDisplay; // 0x08
		private static int m_ActiveEditorGameViewTarget; // 0x10
		private static DisplaysUpdatedDelegate onDisplaysUpdated; // 0x18
	
		// Properties
		public int renderingWidth { get => default; } // 0x00000001842375A0-0x0000000184237630 
		public int renderingHeight { get => default; } // 0x0000000184237510-0x00000001842375A0 
		public int systemWidth { get => default; } // 0x000000018BEB9B18-0x000000018BEB9B58 
		public int systemHeight { get => default; } // 0x000000018BEB9AB4-0x000000018BEB9B18 
		public static PreTransform preTransform { get => default; } // 0x0000000184237690-0x0000000184237780 
		public static Display main { get => default; } // 0x000000018BEB99C4-0x000000018BEB9A38 
	
		// Nested types
		public enum PreTransform // TypeDefIndex: 47375
		{
			PreTransformIdentity = 0,
			PreTransformRotate90 = 1,
			PreTransformRotate180 = 2,
			PreTransformRotate270 = 3
		}
	
		public delegate void DisplaysUpdatedDelegate(); // TypeDefIndex: 47376; 0x0000000185FB2C40-0x0000000185FB2C50
	
		// Constructors
		internal Display() {} // 0x0000000184237480-0x0000000184237510
		internal Display(IntPtr nativeDisplay) {} // 0x00000001842373F0-0x0000000184237480
		static Display() {} // 0x00000001864BC320-0x00000001864BC330
	
		// Methods
		public void SetRenderingResolution(int w, int h) {} // 0x0000000184237390-0x00000001842373F0
		public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) => default; // 0x0000000184ED1340-0x0000000184ED14F0
		private static void RecreateDisplayList(IntPtr[] nativeDisplay) {} // 0x0000000184237630-0x0000000184237690
		private static void FireDisplaysUpdated() {} // 0x0000000184236990-0x00000001842369F0
		private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) {
			w = default;
			h = default;
		} // 0x000000018BEB9A64-0x000000018BEB9AB4
		private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) {
			w = default;
			h = default;
		} // 0x0000000184237780-0x00000001842377F0
		private static void SetRenderingResolutionImpl(IntPtr nativeDisplay, int w, int h) {} // 0x000000018BEB9A38-0x000000018BEB9A64
		private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) {
			rx = default;
			ry = default;
			return default;
		} // 0x0000000184ED14F0-0x0000000184ED1630
		private static uint GetPreTransform() => default; // 0x00000001864BC330-0x00000001864BC3F4
	}

	internal enum EnabledOrientation // TypeDefIndex: 47378
	{
		kAutorotateToPortrait = 1,
		kAutorotateToPortraitUpsideDown = 2,
		kAutorotateToLandscapeLeft = 4,
		kAutorotateToLandscapeRight = 8
	}

	public enum FullScreenMode // TypeDefIndex: 47379
	{
		ExclusiveFullScreen = 0,
		FullScreenWindow = 1,
		MaximizedWindow = 2,
		Windowed = 3
	}

	public struct RefreshRate : IEquatable<RefreshRate> // TypeDefIndex: 47380
	{
		// Fields
		public uint numerator; // 0x00
		public uint denominator; // 0x04
	
		// Methods
		public bool Equals(RefreshRate other) => default; // 0x0000000187333DF8-0x0000000187333E0C
	}

	public struct DisplayInfo : IEquatable<DisplayInfo> // TypeDefIndex: 47381
	{
		// Fields
		internal ulong handle; // 0x00
		public int width; // 0x08
		public int height; // 0x0C
		public RefreshRate refreshRate; // 0x10
		public RectInt workArea; // 0x18
		public string name; // 0x28
	
		// Methods
		public bool Equals(DisplayInfo other) => default; // 0x000000018BEB98F4-0x000000018BEB99C4
	}

	public sealed class Screen // TypeDefIndex: 47382
	{
		// Properties
		public static int width { get => default; } // 0x00000001842ACF30-0x00000001842ACF70 
		public static int height { get => default; } // 0x00000001842ACF70-0x00000001842ACFB0 
		public static float dpi { get => default; } // 0x000000018BEC97D4-0x000000018BEC9800 
		public static ScreenOrientation orientation { get => default; set {} } // 0x000000018646E41C-0x000000018646E428 0x000000018BEC995C-0x000000018BEC99C0
		public static int sleepTimeout { get => default; set {} } // 0x000000018BEC9818-0x000000018BEC9844 0x0000000185AE87A0-0x0000000185AE87E0
		public static bool autorotateToPortrait { get => default; set {} } // 0x000000018BEC9714-0x000000018BEC9724 0x000000018BEC9874-0x000000018BEC9884
		public static bool autorotateToPortraitUpsideDown { get => default; set {} } // 0x000000018BEC9704-0x000000018BEC9714 0x000000018BEC9864-0x000000018BEC9874
		public static bool autorotateToLandscapeLeft { get => default; set {} } // 0x000000018BEC96E4-0x000000018BEC96F4 0x000000018BEC9844-0x000000018BEC9854
		public static bool autorotateToLandscapeRight { get => default; set {} } // 0x000000018BEC96F4-0x000000018BEC9704 0x000000018BEC9854-0x000000018BEC9864
		public static Resolution currentResolution { get => default; } // 0x000000018BEC9784-0x000000018BEC97A8 
		public static bool fullScreen { get => default; set {} } // 0x00000001842AC270-0x00000001842AC2B0 0x000000018BEC98F4-0x000000018BEC9928
		public static FullScreenMode fullScreenMode { get => default; set {} } // 0x0000000184E74FE0-0x0000000184E75020 0x000000018BEC98C0-0x000000018BEC98F4
		public static Rect safeArea { get => default; } // 0x0000000184BEF0A0-0x0000000184BEF0C0 
		public static Rect[] cutouts { get => default; } // 0x000000018BEC97A8-0x000000018BEC97D4 
		public static Vector2Int mainWindowPosition { get => default; } // 0x000000018BEC9560-0x000000018BEC9584 
		public static DisplayInfo mainWindowDisplayInfo { get => default; } // 0x00000001842AC160-0x00000001842AC1E0 
		public static Resolution[] resolutions { get => default; } // 0x0000000185562E50-0x0000000185562E90 
		public static float brightness { get => default; set {} } // 0x000000018BEC9724-0x000000018BEC9750 0x000000018BEC9884-0x000000018BEC98C0
		public static bool lockCursor { get => default; set {} } // 0x000000018BEC9800-0x000000018BEC9818 0x000000018BEC9928-0x000000018BEC995C
	
		// Constructors
		public Screen() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static void RequestOrientation(ScreenOrientation orient) {} // 0x000000018BEC9634-0x000000018BEC9668
		private static ScreenOrientation GetScreenOrientation() => default; // 0x0000000184E6C450-0x0000000184E6C490
		private static bool IsOrientationEnabled(EnabledOrientation orient) => default; // 0x000000018BEC9584-0x000000018BEC95B8
		private static void SetOrientationEnabled(EnabledOrientation orient, bool enabled) {} // 0x000000018BEC9668-0x000000018BEC96A8
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) {} // 0x0000000185D537F0-0x0000000185D53860
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) {} // 0x0000000186472D38-0x0000000186472D54
		public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) {} // 0x000000018BEC96C4-0x000000018BEC96E4
		public static void SetResolution(int width, int height, bool fullscreen) {} // 0x000000018BEC96A8-0x000000018BEC96C4
		public static void GetDisplayLayout(List<DisplayInfo> displayLayout) {} // 0x000000018BEC94D0-0x000000018BEC952C
		public static AsyncOperation MoveMainWindowTo(in DisplayInfo display, Vector2Int position) => default; // 0x000000018BEC9618-0x000000018BEC9634
		private static Vector2Int GetMainWindowPosition() => default; // 0x000000018BEC9560-0x000000018BEC9584
		private static DisplayInfo GetMainWindowDisplayInfo() => default; // 0x00000001842AC1E0-0x00000001842AC230
		private static void GetDisplayLayoutImpl(List<DisplayInfo> displayLayout) {} // 0x000000018BEC949C-0x000000018BEC94D0
		private static AsyncOperation MoveMainWindowImpl(in DisplayInfo display, Vector2Int position) => default; // 0x000000018BEC95FC-0x000000018BEC9618
		private static void get_currentResolution_Injected(out Resolution ret) {
			ret = default;
		} // 0x000000018BEC9750-0x000000018BEC9784
		private static void get_safeArea_Injected(out Rect ret) {
			ret = default;
		} // 0x0000000184BEF0C0-0x0000000184BEF100
		private static void GetMainWindowPosition_Injected(out Vector2Int ret) {
			ret = default;
		} // 0x000000018BEC952C-0x000000018BEC9560
		private static void GetMainWindowDisplayInfo_Injected(out DisplayInfo ret) {
			ret = default;
		} // 0x00000001842AC230-0x00000001842AC270
		private static AsyncOperation MoveMainWindowImpl_Injected(in DisplayInfo display, ref Vector2Int position) => default; // 0x000000018BEC95B8-0x000000018BEC95FC
	}

	public struct RenderBuffer // TypeDefIndex: 47383
	{
		// Fields
		public int m_RenderTextureInstanceID; // 0x00
		public IntPtr m_BufferPtr; // 0x08
	}

	public enum ComputeBufferMode // TypeDefIndex: 47384
	{
		Immutable = 0,
		Dynamic = 1,
		Circular = 2,
		StreamOut = 3,
		SubUpdates = 4
	}

	public class Graphics // TypeDefIndex: 47385
	{
		// Fields
		internal static readonly int kMaxDrawMeshInstanceCount; // 0x00
		internal static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts; // 0x08
	
		// Properties
		public static ColorGamut activeColorGamut { get => default; } // 0x000000018BEC5638-0x000000018BEC5678 
		public static GraphicsTier activeTier { get => default; set {} } // 0x000000018429EFB0-0x000000018429EFF0 0x000000018BEC57FC-0x000000018BEC5830
		public static int totalBufferCount { get => default; } // 0x000000018BEC5778-0x000000018BEC57A4 
		public static int totalBufferBytes { get => default; } // 0x000000018BEC574C-0x000000018BEC5778 
		public static int totalInternalBufferCount { get => default; } // 0x000000018BEC57D0-0x000000018BEC57FC 
		public static int totalInternalBufferBytes { get => default; } // 0x000000018BEC57A4-0x000000018BEC57D0 
		public static bool preserveFramebufferAlpha { get => default; } // 0x000000018BEC570C-0x000000018BEC574C 
		public static OpenGLESVersion minOpenGLESVersion { get => default; } // 0x000000018BEC56CC-0x000000018BEC570C 
		public static RenderBuffer activeColorBuffer { get => default; } // 0x000000018BEC55E4-0x000000018BEC5638 
		public static RenderBuffer activeDepthBuffer { get => default; } // 0x000000018BEC5678-0x000000018BEC56CC 
	
		// Constructors
		public Graphics() {} // 0x0000000185492010-0x0000000185492020
		static Graphics() {} // 0x0000000185EDA8D0-0x0000000185EDA980
	
		// Methods
		private static int Internal_GetMaxDrawMeshInstanceCount() => default; // 0x0000000185EDA980-0x0000000185EDA9C0
		private static ColorGamut GetActiveColorGamut() => default; // 0x000000018BEC10B4-0x000000018BEC10E0
		public static void AccessBufferForVertexUsage(GraphicsBuffer buffer) {} // 0x000000018BEBA7F0-0x000000018BEBA824
		internal static bool GetPreserveFramebufferAlpha() => default; // 0x000000018BEC1328-0x000000018BEC1354
		internal static OpenGLESVersion GetMinOpenGLESVersion() => default; // 0x000000018BEC12FC-0x000000018BEC1328
		private static RenderBuffer GetActiveColorBuffer() => default; // 0x000000018BEC1068-0x000000018BEC10B4
		private static RenderBuffer GetActiveDepthBuffer() => default; // 0x000000018BEC1114-0x000000018BEC1160
		private static void Internal_SetNullRT() {} // 0x00000001852C8700-0x00000001852C8740
		private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) {} // 0x000000018BEC2E50-0x000000018BEC2ECC
		private static void Internal_SetMRTSimple(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) {} // 0x000000018BEC2D70-0x000000018BEC2DEC
		private static void Internal_SetMRTFullSetup(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice, RenderBufferLoadAction[] colorLA, RenderBufferStoreAction[] colorSA, RenderBufferLoadAction depthLA, RenderBufferStoreAction depthSA) {} // 0x000000018BEC2C5C-0x000000018BEC2D0C
		private static void Internal_SetRandomWriteTargetRT(int index, RenderTexture uav) {} // 0x000000018BEC2F74-0x000000018BEC2FB4
		private static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue) {} // 0x000000018BEC2ECC-0x000000018BEC2F20
		private static void Internal_SetRandomWriteTargetGraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue) {} // 0x000000018BEC2F20-0x000000018BEC2F74
		public static void ClearRandomWriteTargets() {} // 0x00000001852C8530-0x00000001852C8570
		private static void CopyTexture_Full(Texture src, Texture dst) {} // 0x000000018BEBB728-0x000000018BEBB76C
		private static void CopyTexture_Slice_AllMips(Texture src, int srcElement, Texture dst, int dstElement) {} // 0x000000018BEBB7D0-0x000000018BEBB830
		private static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) {} // 0x00000001840141E0-0x0000000184014250
		private static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) {} // 0x000000018BEBB76C-0x000000018BEBB7D0
		private static bool ConvertTexture_Full(Texture src, Texture dst) => default; // 0x000000018BEBB26C-0x000000018BEBB2B0
		private static bool ConvertTexture_Slice(Texture src, int srcElement, Texture dst, int dstElement) => default; // 0x000000018BEBB2B0-0x000000018BEBB310
		private static void CopyBufferImpl(GraphicsBuffer source, GraphicsBuffer dest) {} // 0x000000018BEBB3E0-0x000000018BEBB424
		private static void CopyBufferOffsetImpl(GraphicsBuffer source, int srcOffset, GraphicsBuffer dest, int dstOffset, int size) {} // 0x000000018BEBB424-0x000000018BEBB484
		private static void CopyComputeBufferImpl(ComputeBuffer source, ComputeBuffer dest) {} // 0x000000018BEBB684-0x000000018BEBB6C8
		private static void CopyComputeBufferOffsetImpl(ComputeBuffer source, int srcOffset, ComputeBuffer dest, int dstOffset, int size) {} // 0x000000018BEBB6C8-0x000000018BEBB728
		private static void Internal_DrawMeshNow1(Mesh mesh, int subsetIndex, Vector3 position, Quaternion rotation) {} // 0x000000018BEC1968-0x000000018BEC19DC
		private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) {} // 0x000000018BEC1A2C-0x000000018BEC1A8C
		internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) {} // 0x000000018BEC24C4-0x000000018BEC24F8
		private static unsafe void Internal_RenderMesh(RenderParams rparams, Mesh mesh, int submeshIndex, Matrix4x4 objectToWorld, Matrix4x4* prevObjectToWorld) {} // 0x000000018BEC2800-0x000000018BEC2880
		private static void Internal_RenderMeshInstanced(RenderParams rparams, Mesh mesh, int submeshIndex, IntPtr instanceData, RenderInstancedDataLayout layout, uint instanceCount) {} // 0x000000018BEC263C-0x000000018BEC26C4
		private static void Internal_RenderMeshIndirect(RenderParams rparams, Mesh mesh, GraphicsBuffer commandBuffer, int commandCount, int startCommand) {} // 0x000000018BEC255C-0x000000018BEC25D8
		private static void Internal_RenderMeshPrimitives(RenderParams rparams, Mesh mesh, int submeshIndex, int instanceCount) {} // 0x000000018BEC2728-0x000000018BEC279C
		private static void Internal_RenderPrimitives(RenderParams rparams, MeshTopology topology, int vertexCount, int instanceCount) {} // 0x000000018BEC2B84-0x000000018BEC2BF8
		private static void Internal_RenderPrimitivesIndexed(RenderParams rparams, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int startIndex, int instanceCount) {} // 0x000000018BEC29C4-0x000000018BEC2A48
		private static void Internal_RenderPrimitivesIndirect(RenderParams rparams, MeshTopology topology, GraphicsBuffer commandBuffer, int commandCount, int startCommand) {} // 0x000000018BEC2AA8-0x000000018BEC2B24
		private static void Internal_RenderPrimitivesIndexedIndirect(RenderParams rparams, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer commandBuffer, int commandCount, int startCommand) {} // 0x000000018BEC28E0-0x000000018BEC2964
		private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEC1AF0-0x000000018BEC1BC4
		private static void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEC18A4-0x000000018BEC1908
		private static void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEC17D0-0x000000018BEC18A4
		private static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEC168C-0x000000018BEC176C
		private static void Internal_DrawMeshInstancedIndirectGraphicsBuffer(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEC1548-0x000000018BEC1628
		private static void Internal_DrawProceduralNow(MeshTopology topology, int vertexCount, int instanceCount) {} // 0x000000018BEC2354-0x000000018BEC23A4
		private static void Internal_DrawProceduralIndexedNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount) {} // 0x000000018BEC1EE4-0x000000018BEC1F44
		private static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) {} // 0x000000018BEC21E4-0x000000018BEC2234
		private static void Internal_DrawProceduralIndexedIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset) {} // 0x000000018BEC1D54-0x000000018BEC1DB4
		private static void Internal_DrawProceduralIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) {} // 0x000000018BEC2194-0x000000018BEC21E4
		private static void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset) {} // 0x000000018BEC1CF4-0x000000018BEC1D54
		private static void Internal_DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC2408-0x000000018BEC24C4
		private static void Internal_DrawProceduralIndexed(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC1FAC-0x000000018BEC2074
		private static void Internal_DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC2298-0x000000018BEC2354
		private static void Internal_DrawProceduralIndirectGraphicsBuffer(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC20D8-0x000000018BEC2194
		private static void Internal_DrawProceduralIndexedIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC1E1C-0x000000018BEC1EE4
		private static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC1C2C-0x000000018BEC1CF4
		private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) {} // 0x000000018BEC1354-0x000000018BEC13B8
		private static void Internal_BlitMaterial6(Texture source, RenderTexture dest, Material mat, int pass, bool setRT, int destDepthSlice) {} // 0x000000018BEC13B8-0x000000018BEC141C
		private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) {} // 0x000000018BEC141C-0x000000018BEC1480
		private static void Internal_BlitMultiTap5(Texture source, RenderTexture dest, Material mat, Vector2[] offsets, int destDepthSlice) {} // 0x000000018BEC1480-0x000000018BEC14E4
		private static void Blit2(Texture source, RenderTexture dest) {} // 0x000000018BEBA824-0x000000018BEBA868
		private static void Blit3(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice) {} // 0x000000018BEBA868-0x000000018BEBA8CC
		private static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset) {} // 0x000000018BEBA930-0x000000018BEBA998
		private static void Blit5(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) {} // 0x000000018BEBA9FC-0x000000018BEBAA7C
		private static IntPtr CreateGPUFenceImpl(GraphicsFenceType fenceType, SynchronisationStageFlags stage) => default; // 0x000000018BEBBA98-0x000000018BEBBAD8
		private static void WaitOnGPUFenceImpl(IntPtr fencePtr, SynchronisationStageFlags stage) {} // 0x000000018BEC55A4-0x000000018BEC55E4
		public static void ExecuteCommandBuffer(CommandBuffer buffer) {} // 0x0000000185F9E6B0-0x0000000185F9E6F0
		public static void ExecuteCommandBufferAsync(CommandBuffer buffer, ComputeQueueType queueType) {} // 0x000000018BEC0FF4-0x000000018BEC1034
		public static int GetGfxBufferCount() => default; // 0x000000018BEC128C-0x000000018BEC12B8
		public static void GetGfxBufferStats(List<int> bufferSizes, List<string> bufferNames) {} // 0x000000018BEC12B8-0x000000018BEC12FC
		public static long GetTotalPsoCreationTimeInCPUCycles() => default; // 0x00000001841CBE90-0x00000001841CBED0
		public static PipelineCacheLoadResult GetPipelineCacheLoadResult() => default; // 0x0000000185851EF0-0x0000000185851F30
		public static void DebugRecordRenderGraph(uint frameOffset, uint count) {} // 0x000000018BEBBB6C-0x000000018BEBBBAC
		internal static void CheckLoadActionValid(RenderBufferLoadAction load, string bufferType) {} // 0x000000018BEBB0EC-0x000000018BEBB1A4
		internal static void CheckStoreActionValid(RenderBufferStoreAction store, string bufferType) {} // 0x000000018BEBB1A4-0x000000018BEBB26C
		internal static void SetRenderTargetImpl(RenderTargetSetup setup) {} // 0x000000018BEC403C-0x000000018BEC44F8
		internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) {} // 0x000000018BEC44F8-0x000000018BEC4590
		internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) {} // 0x00000001852C8650-0x00000001852C8700
		internal static void SetRenderTargetImpl(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) {} // 0x000000018BEC3FB4-0x000000018BEC403C
		public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) {} // 0x00000001852C85D0-0x00000001852C8650
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) {} // 0x000000018BEC4608-0x000000018BEC46A0
		public static void SetRenderTarget(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer) {} // 0x000000018BEC4884-0x000000018BEC48F0
		public static void SetRenderTarget(RenderTargetSetup setup) {} // 0x000000018BEC4798-0x000000018BEC4800
		public static void SetRandomWriteTarget(int index, RenderTexture uav) {} // 0x000000018BEC3D00-0x000000018BEC3DF8
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue) {} // 0x000000018BEC3DF8-0x000000018BEC3FB4
		public static void SetRandomWriteTarget(int index, GraphicsBuffer uav, bool preserveCounterValue) {} // 0x000000018BEC3AF0-0x000000018BEC3CAC
		public static void CopyTexture(Texture src, Texture dst) {} // 0x000000018BEBB8A4-0x000000018BEBB900
		public static void CopyTexture(Texture src, int srcElement, Texture dst, int dstElement) {} // 0x000000018BEBB830-0x000000018BEBB8A4
		public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) {} // 0x0000000184014150-0x00000001840141E0
		public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) {} // 0x000000018BEBB900-0x000000018BEBB9D0
		public static bool ConvertTexture(Texture src, Texture dst) => default; // 0x000000018BEBB310-0x000000018BEBB36C
		public static bool ConvertTexture(Texture src, int srcElement, Texture dst, int dstElement) => default; // 0x000000018BEBB36C-0x000000018BEBB3E0
		public static GraphicsFence CreateAsyncGraphicsFence(SynchronisationStage stage) => default; // 0x000000018BEBB9D0-0x000000018BEBBA3C
		public static GraphicsFence CreateAsyncGraphicsFence() => default; // 0x000000018BEBBA3C-0x000000018BEBBA98
		public static GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage) => default; // 0x000000018BEBBAD8-0x000000018BEBBB6C
		public static void WaitOnAsyncGraphicsFence(GraphicsFence fence) {} // 0x000000018BEC5488-0x000000018BEC54DC
		public static void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStage stage) {} // 0x000000018BEC54DC-0x000000018BEC55A4
		internal static void ValidateCopyBuffer(GraphicsBuffer source, GraphicsBuffer dest) {} // 0x000000018BEC4EEC-0x000000018BEC51A0
		internal static void ValidateCopyBuffer(GraphicsBuffer source, int srcOffset, GraphicsBuffer dest, int dstOffset, int size) {} // 0x000000018BEC4B1C-0x000000018BEC4EEC
		internal static void ValidateCopyBuffer(ComputeBuffer source, ComputeBuffer dest) {} // 0x000000018BEC494C-0x000000018BEC4B1C
		internal static void ValidateCopyBuffer(ComputeBuffer source, int srcOffset, ComputeBuffer dest, int dstOffset, int size) {} // 0x000000018BEC51A0-0x000000018BEC5488
		public static void CopyBuffer(GraphicsBuffer source, GraphicsBuffer dest) {} // 0x000000018BEBB524-0x000000018BEBB584
		public static void CopyBuffer(GraphicsBuffer source, int srcOffset, GraphicsBuffer dest, int dstOffset, int size) {} // 0x000000018BEBB5E4-0x000000018BEBB684
		public static void CopyBuffer(ComputeBuffer source, ComputeBuffer dest) {} // 0x000000018BEBB584-0x000000018BEBB5E4
		public static void CopyBuffer(ComputeBuffer source, int srcOffset, ComputeBuffer dest, int dstOffset, int size) {} // 0x000000018BEBB484-0x000000018BEBB524
		private static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, UnityEngine.Color color, Material mat, int pass) {} // 0x000000018BEC05F0-0x000000018BEC0724
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, UnityEngine.Color color, Material mat, int pass) {} // 0x000000018BEC0E28-0x000000018BEC0F14
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) {} // 0x000000018BEC0BAC-0x000000018BEC0CBC
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) {} // 0x000000018BEC0724-0x000000018BEC07F8
		public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass) {} // 0x000000018BEC0B18-0x000000018BEC0BAC
		public static void RenderMesh(in RenderParams rparams, Mesh mesh, int submeshIndex, Matrix4x4 objectToWorld, Matrix4x4? prevObjectToWorld = default) {} // 0x000000018BEC3298-0x000000018BEC34A8
		private static RenderInstancedDataLayout GetCachedRenderInstancedDataLayout(System.Type type) => default; // 0x000000018BEC1160-0x000000018BEC128C
		public static void RenderMeshInstanced<T>(in RenderParams rparams, Mesh mesh, int submeshIndex, T[] instanceData, int instanceCount = -1 /* Metadata: 0x020603E4 */, int startInstance = 0 /* Metadata: 0x020603E5 */)
			where T : struct {}
		public static void RenderMeshInstanced<T>(in RenderParams rparams, Mesh mesh, int submeshIndex, List<T> instanceData, int instanceCount = -1 /* Metadata: 0x020603E6 */, int startInstance = 0 /* Metadata: 0x020603E7 */)
			where T : struct {}
		public static void RenderMeshInstanced<T>(RenderParams rparams, Mesh mesh, int submeshIndex, NativeArray<T> instanceData, int instanceCount = -1 /* Metadata: 0x020603E8 */, int startInstance = 0 /* Metadata: 0x020603E9 */)
			where T : struct {}
		public static void RenderMeshIndirect(in RenderParams rparams, Mesh mesh, GraphicsBuffer commandBuffer, int commandCount = 1 /* Metadata: 0x020603EA */, int startCommand = 0 /* Metadata: 0x020603EB */) {} // 0x000000018BEC2FB4-0x000000018BEC312C
		public static void RenderMeshPrimitives(in RenderParams rparams, Mesh mesh, int submeshIndex, int instanceCount = 1 /* Metadata: 0x020603EC */) {} // 0x000000018BEC312C-0x000000018BEC3298
		public static void RenderPrimitives(in RenderParams rparams, MeshTopology topology, int vertexCount, int instanceCount = 1 /* Metadata: 0x020603ED */) {} // 0x000000018BEC3930-0x000000018BEC3A9C
		public static void RenderPrimitivesIndexed(in RenderParams rparams, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int startIndex = 0 /* Metadata: 0x020603EE */, int instanceCount = 1 /* Metadata: 0x020603EF */) {} // 0x000000018BEC3630-0x000000018BEC37B8
		public static void RenderPrimitivesIndirect(in RenderParams rparams, MeshTopology topology, GraphicsBuffer commandBuffer, int commandCount = 1 /* Metadata: 0x020603F0 */, int startCommand = 0 /* Metadata: 0x020603F1 */) {} // 0x000000018BEC37B8-0x000000018BEC3930
		public static void RenderPrimitivesIndexedIndirect(in RenderParams rparams, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer commandBuffer, int commandCount = 1 /* Metadata: 0x020603F2 */, int startCommand = 0 /* Metadata: 0x020603F3 */) {} // 0x000000018BEC34A8-0x000000018BEC3630
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation, int materialIndex) {} // 0x000000018BEBDC2C-0x000000018BEBDD3C
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) {} // 0x000000018BEBDB28-0x000000018BEBDC2C
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation) {} // 0x000000018BEBDAA0-0x000000018BEBDB28
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) {} // 0x000000018BEBDA24-0x000000018BEBDAA0
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes) {} // 0x000000018BEBEC78-0x000000018BEBEDD8
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes) {} // 0x000000018BEBF450-0x000000018BEBF5B4
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes) {} // 0x000000018BEBE3C4-0x000000018BEBE4C4
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEBF5B4-0x000000018BEBF75C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEBD030-0x000000018BEBD544
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEBD8C4-0x000000018BEBDA24
		public static void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, MaterialPropertyBlock properties = null, ShadowCastingMode castShadows = ShadowCastingMode.On /* Metadata: 0x020603F4 */, bool receiveShadows = true /* Metadata: 0x020603F5 */, int layer = 0 /* Metadata: 0x020603F6 */, Camera camera = null, LightProbeUsage lightProbeUsage = LightProbeUsage.BlendProbes /* Metadata: 0x020603F7 */, LightProbeProxyVolume lightProbeProxyVolume = null) {} // 0x000000018BEBC53C-0x000000018BEBC900
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEBBBAC-0x000000018BEBBF7C
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEBBF7C-0x000000018BEBC34C
		public static void DrawProceduralNow(MeshTopology topology, int vertexCount, int instanceCount = 1 /* Metadata: 0x020603F8 */) {} // 0x000000018BEC02B0-0x000000018BEC030C
		public static void DrawProceduralNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount = 1 /* Metadata: 0x020603F9 */) {} // 0x000000018BEC030C-0x000000018BEC03D8
		public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0 /* Metadata: 0x020603FA */) {} // 0x000000018BEBF948-0x000000018BEBFA00
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset = 0 /* Metadata: 0x020603FB */) {} // 0x000000018BEBFB24-0x000000018BEBFC48
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset = 0 /* Metadata: 0x020603FC */) {} // 0x000000018BEBFC48-0x000000018BEBFD00
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset = 0 /* Metadata: 0x020603FD */) {} // 0x000000018BEBFA00-0x000000018BEBFB24
		public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount = 1 /* Metadata: 0x020603FE */, Camera camera = null, MaterialPropertyBlock properties = null, ShadowCastingMode castShadows = ShadowCastingMode.On /* Metadata: 0x020603FF */, bool receiveShadows = true /* Metadata: 0x02060400 */, int layer = 0 /* Metadata: 0x02060401 */) {} // 0x000000018BEC03D8-0x000000018BEC04B0
		public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount = 1 /* Metadata: 0x02060402 */, Camera camera = null, MaterialPropertyBlock properties = null, ShadowCastingMode castShadows = ShadowCastingMode.On /* Metadata: 0x02060403 */, bool receiveShadows = true /* Metadata: 0x02060404 */, int layer = 0 /* Metadata: 0x02060405 */) {} // 0x000000018BEC04B0-0x000000018BEC05F0
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0 /* Metadata: 0x02060406 */, Camera camera = null, MaterialPropertyBlock properties = null, ShadowCastingMode castShadows = ShadowCastingMode.On /* Metadata: 0x02060407 */, bool receiveShadows = true /* Metadata: 0x02060408 */, int layer = 0 /* Metadata: 0x02060409 */) {} // 0x000000018BEC017C-0x000000018BEC02B0
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset = 0 /* Metadata: 0x0206040A */, Camera camera = null, MaterialPropertyBlock properties = null, ShadowCastingMode castShadows = ShadowCastingMode.On /* Metadata: 0x0206040B */, bool receiveShadows = true /* Metadata: 0x0206040C */, int layer = 0 /* Metadata: 0x0206040D */) {} // 0x000000018BEBFEA4-0x000000018BEBFFD8
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset = 0 /* Metadata: 0x0206040E */, Camera camera = null, MaterialPropertyBlock properties = null, ShadowCastingMode castShadows = ShadowCastingMode.On /* Metadata: 0x0206040F */, bool receiveShadows = true /* Metadata: 0x02060410 */, int layer = 0 /* Metadata: 0x02060411 */) {} // 0x000000018BEBFD00-0x000000018BEBFEA4
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset = 0 /* Metadata: 0x02060412 */, Camera camera = null, MaterialPropertyBlock properties = null, ShadowCastingMode castShadows = ShadowCastingMode.On /* Metadata: 0x02060413 */, bool receiveShadows = true /* Metadata: 0x02060414 */, int layer = 0 /* Metadata: 0x02060415 */) {} // 0x000000018BEBFFD8-0x000000018BEC017C
		public static void Blit(Texture source, RenderTexture dest) {} // 0x000000018BEBAE68-0x000000018BEBAEC4
		public static void Blit(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice) {} // 0x000000018BEBADF4-0x000000018BEBAE68
		public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset) {} // 0x000000018BEBAF2C-0x000000018BEBAFA8
		public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) {} // 0x000000018BEBACE4-0x000000018BEBAD78
		public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) {} // 0x000000018BEBAC68-0x000000018BEBACE4
		public static void Blit(Texture source, RenderTexture dest, Material mat, int pass, int destDepthSlice) {} // 0x000000018BEBAFA8-0x000000018BEBB02C
		public static void Blit(Texture source, RenderTexture dest, Material mat) {} // 0x000000018BEBAEC4-0x000000018BEBAF2C
		public static void Blit(Texture source, Material mat, int pass) {} // 0x000000018BEBB080-0x000000018BEBB0EC
		public static void Blit(Texture source, Material mat, int pass, int destDepthSlice) {} // 0x000000018BEBAD78-0x000000018BEBADF4
		public static void Blit(Texture source, Material mat) {} // 0x000000018BEBB02C-0x000000018BEBB080
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) {} // 0x000000018BEBAB7C-0x000000018BEBAC68
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, int destDepthSlice, Vector2[] offsets) {} // 0x000000018BEBAA7C-0x000000018BEBAB7C
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer) {} // 0x000000018BEBE624-0x000000018BEBE778
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera) {} // 0x000000018BEBE778-0x000000018BEBE8CC
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex) {} // 0x000000018BEBEEBC-0x000000018BEBF014
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) {} // 0x000000018BEBDD3C-0x000000018BEBDE98
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows) {} // 0x000000018BEBF204-0x000000018BEBF360
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) {} // 0x000000018BEBE268-0x000000018BEBE3C4
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows) {} // 0x000000018BEBEA28-0x000000018BEBEB80
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows) {} // 0x000000018BEBE8CC-0x000000018BEBEA28
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor) {} // 0x000000018BEBE4C4-0x000000018BEBE624
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer) {} // 0x000000018BEBE08C-0x000000018BEBE168
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera) {} // 0x000000018BEBEDD8-0x000000018BEBEEBC
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex) {} // 0x000000018BEBF860-0x000000018BEBF948
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) {} // 0x000000018BEBF360-0x000000018BEBF450
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows) {} // 0x000000018BEBF110-0x000000018BEBF204
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) {} // 0x000000018BEBF014-0x000000018BEBF110
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows) {} // 0x000000018BEBDE98-0x000000018BEBDF8C
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows) {} // 0x000000018BEBEB80-0x000000018BEBEC78
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor) {} // 0x000000018BEBDF8C-0x000000018BEBE08C
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes) {} // 0x000000018BEBF75C-0x000000018BEBF860
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage) {} // 0x000000018BEBE168-0x000000018BEBE268
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices) {} // 0x000000018BEBD6AC-0x000000018BEBD760
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count) {} // 0x000000018BEBC9CC-0x000000018BEBCA78
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) {} // 0x000000018BEBD760-0x000000018BEBD814
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows) {} // 0x000000018BEBCEC0-0x000000018BEBCF74
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows) {} // 0x000000018BEBCF74-0x000000018BEBD030
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEBD544-0x000000018BEBD604
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera) {} // 0x000000018BEBCD40-0x000000018BEBCE08
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage) {} // 0x000000018BEBC900-0x000000018BEBC9CC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices) {} // 0x000000018BEBCBE4-0x000000018BEBCC84
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties) {} // 0x000000018BEBD604-0x000000018BEBD6AC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows) {} // 0x000000018BEBCA78-0x000000018BEBCB24
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows) {} // 0x000000018BEBD814-0x000000018BEBD8C4
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEBCE08-0x000000018BEBCEC0
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera) {} // 0x000000018BEBCC84-0x000000018BEBCD40
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage) {} // 0x000000018BEBCB24-0x000000018BEBCBE4
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset = 0 /* Metadata: 0x02060416 */, MaterialPropertyBlock properties = null, ShadowCastingMode castShadows = ShadowCastingMode.On /* Metadata: 0x02060417 */, bool receiveShadows = true /* Metadata: 0x02060418 */, int layer = 0 /* Metadata: 0x02060419 */, Camera camera = null, LightProbeUsage lightProbeUsage = LightProbeUsage.BlendProbes /* Metadata: 0x0206041A */) {} // 0x000000018BEBC34C-0x000000018BEBC444
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset = 0 /* Metadata: 0x0206041B */, MaterialPropertyBlock properties = null, ShadowCastingMode castShadows = ShadowCastingMode.On /* Metadata: 0x0206041C */, bool receiveShadows = true /* Metadata: 0x0206041D */, int layer = 0 /* Metadata: 0x0206041E */, Camera camera = null, LightProbeUsage lightProbeUsage = LightProbeUsage.BlendProbes /* Metadata: 0x0206041F */) {} // 0x000000018BEBC444-0x000000018BEBC53C
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, UnityEngine.Color color, Material mat) {} // 0x000000018BEC0A30-0x000000018BEC0B18
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, UnityEngine.Color color) {} // 0x000000018BEC0F14-0x000000018BEC0FF4
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat) {} // 0x000000018BEC0D68-0x000000018BEC0E28
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder) {} // 0x000000018BEC089C-0x000000018BEC0954
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat) {} // 0x000000018BEC0CBC-0x000000018BEC0D68
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder) {} // 0x000000018BEC07F8-0x000000018BEC089C
		public static void DrawTexture(Rect screenRect, Texture texture, Material mat) {} // 0x000000018BEC09BC-0x000000018BEC0A30
		public static void DrawTexture(Rect screenRect, Texture texture) {} // 0x000000018BEC0954-0x000000018BEC09BC
		public static void SetRenderTarget(RenderTexture rt) {} // 0x00000001852C8570-0x00000001852C85D0
		public static void SetRenderTarget(RenderTexture rt, int mipLevel) {} // 0x000000018BEC48F0-0x000000018BEC494C
		public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face) {} // 0x000000018BEC4730-0x000000018BEC4798
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer) {} // 0x000000018BEC4590-0x000000018BEC4608
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel) {} // 0x000000018BEC4800-0x000000018BEC4884
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face) {} // 0x000000018BEC46A0-0x000000018BEC4730
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav) {} // 0x000000018BEC3A9C-0x000000018BEC3AF0
		public static void SetRandomWriteTarget(int index, GraphicsBuffer uav) {} // 0x000000018BEC3CAC-0x000000018BEC3D00
		private static void GetActiveColorBuffer_Injected(out RenderBuffer ret) {
			ret = default;
		} // 0x000000018BEC1034-0x000000018BEC1068
		private static void GetActiveDepthBuffer_Injected(out RenderBuffer ret) {
			ret = default;
		} // 0x000000018BEC10E0-0x000000018BEC1114
		private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) {} // 0x000000018BEC2DEC-0x000000018BEC2E50
		private static void Internal_SetMRTSimple_Injected(RenderBuffer[] color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) {} // 0x000000018BEC2D0C-0x000000018BEC2D70
		private static void Internal_SetMRTFullSetup_Injected(RenderBuffer[] color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice, RenderBufferLoadAction[] colorLA, RenderBufferStoreAction[] colorSA, RenderBufferLoadAction depthLA, RenderBufferStoreAction depthSA) {} // 0x000000018BEC2BF8-0x000000018BEC2C5C
		private static void Internal_DrawMeshNow1_Injected(Mesh mesh, int subsetIndex, ref Vector3 position, ref Quaternion rotation) {} // 0x000000018BEC1908-0x000000018BEC1968
		private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) {} // 0x000000018BEC19DC-0x000000018BEC1A2C
		private static unsafe void Internal_RenderMesh_Injected(ref RenderParams rparams, Mesh mesh, int submeshIndex, ref Matrix4x4 objectToWorld, Matrix4x4* prevObjectToWorld) {} // 0x000000018BEC279C-0x000000018BEC2800
		private static void Internal_RenderMeshInstanced_Injected(ref RenderParams rparams, Mesh mesh, int submeshIndex, IntPtr instanceData, ref RenderInstancedDataLayout layout, uint instanceCount) {} // 0x000000018BEC25D8-0x000000018BEC263C
		private static void Internal_RenderMeshIndirect_Injected(ref RenderParams rparams, Mesh mesh, GraphicsBuffer commandBuffer, int commandCount, int startCommand) {} // 0x000000018BEC24F8-0x000000018BEC255C
		private static void Internal_RenderMeshPrimitives_Injected(ref RenderParams rparams, Mesh mesh, int submeshIndex, int instanceCount) {} // 0x000000018BEC26C4-0x000000018BEC2728
		private static void Internal_RenderPrimitives_Injected(ref RenderParams rparams, MeshTopology topology, int vertexCount, int instanceCount) {} // 0x000000018BEC2B24-0x000000018BEC2B84
		private static void Internal_RenderPrimitivesIndexed_Injected(ref RenderParams rparams, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int startIndex, int instanceCount) {} // 0x000000018BEC2964-0x000000018BEC29C4
		private static void Internal_RenderPrimitivesIndirect_Injected(ref RenderParams rparams, MeshTopology topology, GraphicsBuffer commandBuffer, int commandCount, int startCommand) {} // 0x000000018BEC2A48-0x000000018BEC2AA8
		private static void Internal_RenderPrimitivesIndexedIndirect_Injected(ref RenderParams rparams, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer commandBuffer, int commandCount, int startCommand) {} // 0x000000018BEC2880-0x000000018BEC28E0
		private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEC1A8C-0x000000018BEC1AF0
		private static void Internal_DrawMeshInstancedProcedural_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEC176C-0x000000018BEC17D0
		private static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEC1628-0x000000018BEC168C
		private static void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018BEC14E4-0x000000018BEC1548
		private static void Internal_DrawProcedural_Injected(Material material, ref Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC23A4-0x000000018BEC2408
		private static void Internal_DrawProceduralIndexed_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC1F44-0x000000018BEC1FAC
		private static void Internal_DrawProceduralIndirect_Injected(Material material, ref Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC2234-0x000000018BEC2298
		private static void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC2074-0x000000018BEC20D8
		private static void Internal_DrawProceduralIndexedIndirect_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC1DB4-0x000000018BEC1E1C
		private static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) {} // 0x000000018BEC1BC4-0x000000018BEC1C2C
		private static void Blit4_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset) {} // 0x000000018BEBA8CC-0x000000018BEBA930
		private static void Blit5_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) {} // 0x000000018BEBA998-0x000000018BEBA9FC
	}

	public sealed class GL // TypeDefIndex: 47386
	{
		// Properties
		public static bool wireframe { get => default; } // 0x000000018BECB6EC-0x000000018BECB718 
		public static bool sRGBWrite { set {} } // 0x000000018BECB750-0x000000018BECB784
		public static Matrix4x4 modelview { set {} } // 0x000000018BECB718-0x000000018BECB750
	
		// Constructors
		public GL() {} // Dummy constructor
	
		// Methods
		public static void Vertex3(float x, float y, float z) {} // 0x000000018BECB630-0x000000018BECB690
		public static void Vertex(Vector3 v) {} // 0x000000018BECB690-0x000000018BECB6A8
		public static void TexCoord3(float x, float y, float z) {} // 0x000000018BECB5D0-0x000000018BECB630
		public static void TexCoord2(float x, float y) {} // 0x000000018BECB5C4-0x000000018BECB5D0
		private static void ImmediateColor(float r, float g, float b, float a) {} // 0x000000018BECB3AC-0x000000018BECB420
		public static void Color(UnityEngine.Color c) {} // 0x000000018BECB224-0x000000018BECB250
		private static void SetViewMatrix(Matrix4x4 m) {} // 0x000000018BECB5B4-0x000000018BECB5C4
		public static void PushMatrix() {} // 0x000000018BECB554-0x000000018BECB580
		public static void PopMatrix() {} // 0x000000018BECB528-0x000000018BECB554
		public static void LoadOrtho() {} // 0x000000018BECB4A8-0x000000018BECB4D4
		public static void LoadProjectionMatrix(Matrix4x4 mat) {} // 0x000000018BECB518-0x000000018BECB528
		public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) => default; // 0x00000001843FF8B0-0x00000001843FF930
		private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) {} // 0x000000018BECB338-0x000000018BECB3AC
		public static void LoadPixelMatrix(float left, float right, float bottom, float top) {} // 0x000000018BECB4D4-0x000000018BECB4E4
		private static void GLIssuePluginEvent(IntPtr callback, int eventID) {} // 0x000000018BECB2F8-0x000000018BECB338
		public static void IssuePluginEvent(IntPtr callback, int eventID) {} // 0x000000018BECB420-0x000000018BECB4A8
		public static void Begin(int mode) {} // 0x000000018BECB198-0x000000018BECB1CC
		public static void End() {} // 0x000000018BECB250-0x000000018BECB27C
		private static void GLClear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth) {} // 0x000000018BECB2E0-0x000000018BECB2F8
		public static void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth) {} // 0x000000018BECB1CC-0x000000018BECB1F4
		public static void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor) {} // 0x000000018BECB1F4-0x000000018BECB224
		public static void Viewport(Rect pixelRect) {} // 0x000000018BECB6DC-0x000000018BECB6EC
		private static void SetViewMatrix_Injected(ref Matrix4x4 m) {} // 0x000000018BECB580-0x000000018BECB5B4
		private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) {} // 0x000000018BECB4E4-0x000000018BECB518
		private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) {
			ret = default;
		} // 0x00000001843FF930-0x00000001843FF990
		private static void GLClear_Injected(bool clearDepth, bool clearColor, ref UnityEngine.Color backgroundColor, float depth) {} // 0x000000018BECB27C-0x000000018BECB2E0
		private static void Viewport_Injected(ref Rect pixelRect) {} // 0x000000018BECB6A8-0x000000018BECB6DC
	}

	public static class ScalableBufferManager // TypeDefIndex: 47387
	{
		// Properties
		public static float widthScaleFactor { get; } // 0x000000018BEDA3A0-0x000000018BEDA3CC 
		public static float heightScaleFactor { get; } // 0x000000018BEDA374-0x000000018BEDA3A0 
	
		// Methods
		public static void ResizeBuffers(float widthScale, float heightScale) {} // 0x000000018BEDA328-0x000000018BEDA374
	}

	public sealed class LightmapData // TypeDefIndex: 47388
	{
		// Fields
		internal Texture2D m_Light; // 0x10
		internal Texture2D m_Dir; // 0x18
		internal Texture2D m_ShadowMask; // 0x20
	
		// Properties
		public Texture2D lightmapColor { get => default; set {} } // 0x0000000185FC7990-0x0000000185FC79A0 0x0000000184096E30-0x0000000184096EF0
		public Texture2D lightmapDir { get => default; set {} } // 0x0000000185FC2A70-0x0000000185FC2A80 0x0000000184088E70-0x0000000184088E80
		public Texture2D shadowMask { get => default; set {} } // 0x0000000185FE66B0-0x0000000185FE66C0 0x000000018646EE40-0x000000018646EE50
	
		// Constructors
		public LightmapData() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class LightmapSettings : UnityEngine.Object // TypeDefIndex: 47389
	{
		// Properties
		public static LightmapData[] lightmaps { set {} } // 0x000000018BED0464-0x000000018BED0498
	
		// Constructors
		public LightmapSettings() {} // Dummy constructor
	}

	public sealed class LightProbes : UnityEngine.Object // TypeDefIndex: 47390
	{
		// Fields
		private static Action tetrahedralizationCompleted; // 0x00
		private static Action needsRetetrahedralization; // 0x08
	
		// Properties
		public Vector3[] positions { get => default; } // 0x000000018BECDF9C-0x000000018BECDFD0 
		public SphericalHarmonicsL2[] bakedProbes { get => default; set {} } // 0x000000018BECDECC-0x000000018BECDF00 0x000000018BECE128-0x000000018BECE16C
		public int count { get => default; } // 0x000000018BECDF68-0x000000018BECDF9C 
		public int cellCount { get => default; } // 0x000000018BECDF00-0x000000018BECDF34 
		public float[] coefficients { get => default; set {} } // 0x000000018BECDF34-0x000000018BECDF68 0x0000000185492010-0x0000000185492020
	
		// Events
		public static event Action tetrahedralizationCompleted;
		public static event Action needsRetetrahedralization;
	
		// Constructors
		private LightProbes() {} // 0x000000018BECDD34-0x000000018BECDD74
	
		// Methods
		private static void Internal_CallTetrahedralizationCompletedFunction() {} // 0x000000018BECDC98-0x000000018BECDCDC
		private static void Internal_CallNeedsRetetrahedralizationFunction() {} // 0x000000018BECDC54-0x000000018BECDC98
		public static void Tetrahedralize() {} // 0x000000018BECDD08-0x000000018BECDD34
		public static void TetrahedralizeAsync() {} // 0x000000018BECDCDC-0x000000018BECDD08
		public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) {
			probe = default;
		} // 0x000000018BECDC40-0x000000018BECDC54
		internal static bool AreLightProbesAllowed(Renderer renderer) => default; // 0x000000018BECD208-0x000000018BECD23C
		public static void CalculateInterpolatedLightAndOcclusionProbes(Vector3[] positions, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes) {} // 0x000000018BECD4C0-0x000000018BECD680
		public static void CalculateInterpolatedLightAndOcclusionProbes(Vector3[] positions, int count, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes) {} // 0x000000018BECD29C-0x000000018BECD4C0
		public static void CalculateInterpolatedLightAndOcclusionProbes(List<Vector3> positions, List<SphericalHarmonicsL2> lightProbes, List<Vector4> occlusionProbes) {} // 0x000000018BECD95C-0x000000018BECDBC0
		public static void CalculateInterpolatedLightAndOcclusionProbes(List<Vector3> positions, int count, List<SphericalHarmonicsL2> lightProbes, List<Vector4> occlusionProbes) {} // 0x000000018BECD680-0x000000018BECD95C
		internal static void CalculateInterpolatedLightAndOcclusionProbes_Internal(Vector3[] positions, int positionsCount, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes) {} // 0x000000018BECD23C-0x000000018BECD29C
		internal static int GetCount() => default; // 0x000000018BECDBC0-0x000000018BECDBEC
		public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, float[] coefficients) {} // 0x0000000185492010-0x0000000185492020
		private static void GetInterpolatedProbe_Injected(ref Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) {
			probe = default;
		} // 0x000000018BECDBEC-0x000000018BECDC40
	}

	public class HDROutputSettings // TypeDefIndex: 47391
	{
		// Fields
		private int m_DisplayIndex; // 0x10
		public static HDROutputSettings[] displays; // 0x00
		private static HDROutputSettings _mainDisplay; // 0x08
	
		// Properties
		public static HDROutputSettings main { get => default; } // 0x0000000184E75110-0x0000000184E75160 
		public bool active { get => default; } // 0x0000000184E74130-0x0000000184E74180 
	
		// Constructors
		internal HDROutputSettings() {} // 0x0000000185FBA4D0-0x0000000185FBA4E0
		static HDROutputSettings() {} // 0x0000000185D697A0-0x0000000185D698A0
	
		// Methods
		private static bool GetActive(int displayIndex) => default; // 0x0000000184E74180-0x0000000184E741C0
	}

	public struct Resolution // TypeDefIndex: 47392
	{
		// Fields
		private int m_Width; // 0x00
		private int m_Height; // 0x04
		private int m_RefreshRate; // 0x08
	
		// Properties
		public int width { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
		public int height { get => default; } // 0x0000000185FCA560-0x0000000185FCA570 
		public int refreshRate { get => default; } // 0x00000001835DC780-0x00000001835DC790 
	
		// Methods
		public override string ToString() => default; // 0x000000018BEDA204-0x000000018BEDA328
	}

	public struct RenderTargetSetup // TypeDefIndex: 47393
	{
		// Fields
		public RenderBuffer[] color; // 0x00
		public RenderBuffer depth; // 0x08
		public int mipLevel; // 0x18
		public CubemapFace cubemapFace; // 0x1C
		public int depthSlice; // 0x20
		public RenderBufferLoadAction[] colorLoad; // 0x28
		public RenderBufferStoreAction[] colorStore; // 0x30
		public RenderBufferLoadAction depthLoad; // 0x38
		public RenderBufferStoreAction depthStore; // 0x3C
	}

	public struct RenderParams // TypeDefIndex: 47394
	{
		// Fields
		private int _layer_k__BackingField; // 0x00
		private uint _renderingLayerMask_k__BackingField; // 0x04
		private int _rendererPriority_k__BackingField; // 0x08
		private Bounds _worldBounds_k__BackingField; // 0x0C
		private Camera _camera_k__BackingField; // 0x28
		private MotionVectorGenerationMode _motionVectorMode_k__BackingField; // 0x30
		private ReflectionProbeUsage _reflectionProbeUsage_k__BackingField; // 0x34
		private Material _material_k__BackingField; // 0x38
		private MaterialPropertyBlock _matProps_k__BackingField; // 0x40
		private ShadowCastingMode _shadowCastingMode_k__BackingField; // 0x48
		private bool _receiveShadows_k__BackingField; // 0x4C
		private LightProbeUsage _lightProbeUsage_k__BackingField; // 0x50
		private LightProbeProxyVolume _lightProbeProxyVolume_k__BackingField; // 0x58
	
		// Properties
		public Material material { get; } // 0x00000001813ECBC0-0x00000001813ECBD0 
	}

	internal struct RenderInstancedDataLayout // TypeDefIndex: 47395
	{
		// Fields
		private readonly int _size_k__BackingField; // 0x00
		private readonly int _offsetObjectToWorld_k__BackingField; // 0x04
		private readonly int _offsetPrevObjectToWorld_k__BackingField; // 0x08
		private readonly int _offsetRenderingLayerMask_k__BackingField; // 0x0C
	
		// Constructors
		public RenderInstancedDataLayout(System.Type t) {
			<size>k__BackingField = default;
			<offsetObjectToWorld>k__BackingField = default;
			<offsetPrevObjectToWorld>k__BackingField = default;
			<offsetRenderingLayerMask>k__BackingField = default;
		} // 0x000000018BED7380-0x000000018BED757C
	}

	internal struct Internal_DrawTextureArguments // TypeDefIndex: 47396
	{
		// Fields
		public Rect screenRect; // 0x00
		public Rect sourceRect; // 0x10
		public int leftBorder; // 0x20
		public int rightBorder; // 0x24
		public int topBorder; // 0x28
		public int bottomBorder; // 0x2C
		public UnityEngine.Color leftBorderColor; // 0x30
		public UnityEngine.Color rightBorderColor; // 0x40
		public UnityEngine.Color topBorderColor; // 0x50
		public UnityEngine.Color bottomBorderColor; // 0x60
		public UnityEngine.Color color; // 0x70
		public Vector4 borderWidths; // 0x80
		public Vector4 cornerRadiuses; // 0x90
		public bool smoothCorners; // 0xA0
		public int pass; // 0xA4
		public Texture texture; // 0xA8
		public Material mat; // 0xB0
	}

	public sealed class QualitySettings : UnityEngine.Object // TypeDefIndex: 47397
	{
		// Properties
		public static QualityLevel currentLevel { get => default; set {} } // 0x000000018BED67E4-0x000000018BED67F0 0x000000018BED6638-0x000000018BED6644
		public static int pixelLightCount { get => default; set {} } // 0x000000018BED68CC-0x000000018BED68F8 0x000000018BED6FA8-0x000000018BED6FDC
		public static ShadowQuality shadows { get => default; set {} } // 0x000000018BED6B44-0x000000018BED6B70 0x000000018BED7248-0x000000018BED727C
		public static ShadowProjection shadowProjection { get => default; set {} } // 0x000000018BED6AC0-0x000000018BED6AEC 0x000000018BED71AC-0x000000018BED71E0
		public static int shadowCascades { get => default; set {} } // 0x000000018BED6A3C-0x000000018BED6A68 0x000000018BED7100-0x000000018BED7134
		public static float shadowDistance { get => default; set {} } // 0x000000018BED6A68-0x000000018BED6A94 0x000000018BED7134-0x000000018BED7170
		public static ShadowResolution shadowResolution { get => default; set {} } // 0x000000018BED6AEC-0x000000018BED6B18 0x000000018BED71E0-0x000000018BED7214
		public static ShadowmaskMode shadowmaskMode { get => default; set {} } // 0x000000018BED6B18-0x000000018BED6B44 0x000000018BED7214-0x000000018BED7248
		public static float shadowNearPlaneOffset { get => default; set {} } // 0x000000018BED6A94-0x000000018BED6AC0 0x000000018BED7170-0x000000018BED71AC
		public static float shadowCascade2Split { get => default; set {} } // 0x000000018BED69B8-0x000000018BED69E4 0x000000018BED7080-0x000000018BED70BC
		public static Vector3 shadowCascade4Split { get => default; set {} } // 0x000000018BED6A18-0x000000018BED6A3C 0x000000018BED70F0-0x000000018BED7100
		public static float lodBias { get => default; set {} } // 0x000000018519E0A0-0x000000018519E0E0 0x000000018BED6E68-0x000000018BED6EA4
		public static int lodOffset { get => default; set {} } // 0x000000018519E060-0x000000018519E0A0 0x000000018BED6EA4-0x000000018BED6ED8
		public static AnisotropicFiltering anisotropicFiltering { get => default; set {} } // 0x000000018BED66B0-0x000000018BED66DC 0x000000018BED6CFC-0x000000018BED6D30
		public static int masterTextureLimit { get => default; set {} } // 0x000000018BED681C-0x000000018BED6848 0x000000018BED6ED8-0x000000018BED6F0C
		public static int maximumLODLevel { get => default; set {} } // 0x000000018519E020-0x000000018519E060 0x000000018BED6F40-0x000000018BED6F74
		public static int particleRaycastBudget { get => default; set {} } // 0x000000018BED68A0-0x000000018BED68CC 0x000000018BED6F74-0x000000018BED6FA8
		public static bool softParticles { get => default; set {} } // 0x000000018BED6B9C-0x000000018BED6BC8 0x000000018BED72B0-0x000000018BED72E4
		public static bool softVegetation { get => default; set {} } // 0x000000018BED6BC8-0x000000018BED6BF4 0x000000018BED72E4-0x000000018BED7318
		public static int vSyncCount { get => default; set {} } // 0x000000018BED6CD0-0x000000018BED6CFC 0x0000000185EFC540-0x0000000185EFC580
		public static bool allowTearing { get => default; set {} } // 0x0000000184E741C0-0x0000000184E74200 0x0000000185BCA7B0-0x0000000185BCA7F0
		public static int realtimeGICPUUsage { get => default; set {} } // 0x000000018BED68F8-0x000000018BED6924 0x000000018BED6FDC-0x000000018BED7010
		public static int antiAliasing { get => default; set {} } // 0x000000018BED66DC-0x000000018BED6708 0x000000018BED6D30-0x000000018BED6D64
		public static int asyncUploadTimeSlice { get => default; set {} } // 0x000000018BED6760-0x000000018BED678C 0x000000018BED6DCC-0x000000018BED6E00
		public static int asyncUploadBufferSize { get => default; set {} } // 0x000000018BED6708-0x000000018BED6734 0x000000018BED6D64-0x000000018BED6D98
		public static bool asyncUploadPersistentBuffer { get => default; set {} } // 0x000000018BED6734-0x000000018BED6760 0x000000018BED6D98-0x000000018BED6DCC
		public static bool realtimeReflectionProbes { get => default; set {} } // 0x000000018BED6924-0x000000018BED6950 0x000000018BED7010-0x000000018BED7044
		public static bool billboardsFaceCameraPosition { get => default; set {} } // 0x000000018BED678C-0x000000018BED67B8 0x000000018BED6E00-0x000000018BED6E34
		public static float resolutionScalingFixedDPIFactor { get => default; set {} } // 0x000000018BED698C-0x000000018BED69B8 0x000000018BED7044-0x000000018BED7080
		private static ScriptableObject INTERNAL_renderPipeline { get => default; set {} } // 0x000000018BED6684-0x000000018BED66B0 0x0000000185F7DC70-0x0000000185F7DCB0
		public static RenderPipelineAsset renderPipeline { get => default; set {} } // 0x000000018BED6950-0x000000018BED698C 0x000000018646D7CC-0x000000018646D7D4
		public static BlendWeights blendWeights { get => default; set {} } // 0x000000018BED67B8-0x000000018BED67E4 0x000000018BED6E34-0x000000018BED6E68
		public static SkinWeights skinWeights { get => default; set {} } // 0x000000018BED6B70-0x000000018BED6B9C 0x000000018BED727C-0x000000018BED72B0
		public static bool streamingMipmapsActive { get => default; set {} } // 0x000000018BED6BF4-0x000000018BED6C20 0x0000000184A19AA0-0x0000000184A19AE0
		public static float streamingMipmapsMemoryBudget { get => default; set {} } // 0x0000000185F8BF00-0x0000000185F8BF40 0x0000000184A19B60-0x0000000184A19BB0
		public static int streamingMipmapsRenderersPerFrame { get => default; set {} } // 0x000000018BED6CA4-0x000000018BED6CD0 0x0000000184A19AE0-0x0000000184A19B20
		public static int streamingMipmapsMaxLevelReduction { get => default; set {} } // 0x000000018BED6C78-0x000000018BED6CA4 0x000000018BED734C-0x000000018BED7380
		public static bool streamingMipmapsAddAllCameras { get => default; set {} } // 0x000000018BED6C20-0x000000018BED6C4C 0x000000018BED7318-0x000000018BED734C
		public static int streamingMipmapsMaxFileIORequests { get => default; set {} } // 0x000000018BED6C4C-0x000000018BED6C78 0x0000000184A19B20-0x0000000184A19B60
		public static int maxQueuedFrames { get => default; set {} } // 0x000000018BED6848-0x000000018BED6874 0x000000018BED6F0C-0x000000018BED6F40
		public static string[] names { get => default; } // 0x000000018BED6874-0x000000018BED68A0 
		public static ColorSpace desiredColorSpace { get => default; } // 0x000000018BED67F0-0x000000018BED681C 
		public static ColorSpace activeColorSpace { get => default; } // 0x0000000184014AB0-0x0000000184014AF0 
	
		// Constructors
		private QualitySettings() {} // 0x000000018BED6644-0x000000018BED6684
	
		// Methods
		public static void IncreaseLevel(bool applyExpensiveChanges) {} // 0x000000018BED6548-0x000000018BED656C
		public static void DecreaseLevel(bool applyExpensiveChanges) {} // 0x000000018BED63BC-0x000000018BED63E0
		public static void SetQualityLevel(int index) {} // 0x000000018BED6638-0x000000018BED6644
		public static void IncreaseLevel() {} // 0x000000018BED656C-0x000000018BED6578
		public static void DecreaseLevel() {} // 0x000000018BED63B0-0x000000018BED63BC
		public static void SetLODSettings(float lodBias, int maximumLODLevel, bool setDirty = true /* Metadata: 0x02060420 */) {} // 0x000000018BED65AC-0x000000018BED65F8
		public static void SetLODSettings(float lodBias, int lodOffset, int maximumLODLevel, bool setDirty = true /* Metadata: 0x02060421 */) {} // 0x000000018502CC40-0x000000018502CCB0
		internal static ScriptableObject InternalGetRenderPipelineAssetAt(int index) => default; // 0x000000018BED6578-0x000000018BED65AC
		public static RenderPipelineAsset GetRenderPipelineAssetAt(int index) => default; // 0x000000018BED6438-0x000000018BED6548
		public static int GetQualityLevel() => default; // 0x000000018BED63E0-0x000000018BED640C
		public static UnityEngine.Object GetQualitySettings() => default; // 0x000000018BED640C-0x000000018BED6438
		public static void SetQualityLevel(int index, bool applyExpensiveChanges) {} // 0x000000018BED65F8-0x000000018BED6638
		private static void get_shadowCascade4Split_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BED69E4-0x000000018BED6A18
		private static void set_shadowCascade4Split_Injected(ref Vector3 value) {} // 0x000000018BED70BC-0x000000018BED70F0
	}

	public sealed class TrailRenderer : Renderer // TypeDefIndex: 47398
	{
		// Properties
		public float time { get => default; set {} } // 0x000000018BEDF458-0x000000018BEDF48C 0x000000018BEDF514-0x000000018BEDF558
		public float startWidth { get => default; set {} } // 0x000000018BEDF424-0x000000018BEDF458 0x000000018BEDF4D0-0x000000018BEDF514
		public float endWidth { get => default; set {} } // 0x000000018BEDF3F0-0x000000018BEDF424 0x000000018BEDF48C-0x000000018BEDF4D0
	
		// Constructors
		public TrailRenderer() {} // Dummy constructor
	}

	public sealed class LineRenderer : Renderer // TypeDefIndex: 47399
	{
		// Properties
		public int numPositions { get => default; set {} } // 0x000000018BED0C00-0x000000018BED0C0C 0x000000018BED0988-0x000000018BED0990
		public float startWidth { get => default; set {} } // 0x000000018BED0CE4-0x000000018BED0D18 0x000000018BED1088-0x000000018BED10CC
		public float endWidth { get => default; set {} } // 0x000000018BED0AFC-0x000000018BED0B30 0x000000018BED0E60-0x000000018BED0EA4
		public float widthMultiplier { get => default; set {} } // 0x000000018BED0D8C-0x000000018BED0DC0 0x000000018BED1158-0x000000018BED119C
		public int numCornerVertices { get => default; set {} } // 0x000000018BED0BCC-0x000000018BED0C00 0x000000018BED0F6C-0x000000018BED0FAC
		public int numCapVertices { get => default; set {} } // 0x000000018BED0B98-0x000000018BED0BCC 0x000000018BED0F2C-0x000000018BED0F6C
		public bool useWorldSpace { get => default; set {} } // 0x000000018BED0D4C-0x000000018BED0D80 0x000000018BED110C-0x000000018BED1150
		public bool loop { get => default; set {} } // 0x000000018BED0B64-0x000000018BED0B98 0x000000018BED0EE8-0x000000018BED0F2C
		public UnityEngine.Color startColor { get => default; set {} } // 0x000000018BED0CB8-0x000000018BED0CE4 0x000000018BED1074-0x000000018BED1088
		public UnityEngine.Color endColor { get => default; set {} } // 0x000000018BED0AD0-0x000000018BED0AFC 0x000000018BED0E4C-0x000000018BED0E60
		public int positionCount { get => default; set {} } // 0x000000018BED0C0C-0x000000018BED0C40 0x000000018BED0FAC-0x000000018BED0FEC
		public float shadowBias { get => default; set {} } // 0x000000018BED0C40-0x000000018BED0C74 0x000000018BED0FEC-0x000000018BED1030
		public bool generateLightingData { get => default; set {} } // 0x000000018BED0B30-0x000000018BED0B64 0x000000018BED0EA4-0x000000018BED0EE8
		public LineTextureMode textureMode { get => default; set {} } // 0x000000018BED0D18-0x000000018BED0D4C 0x000000018BED10CC-0x000000018BED110C
		public LineAlignment alignment { get => default; set {} } // 0x000000018BED0A4C-0x000000018BED0A80 0x000000018BED0DC0-0x000000018BED0E00
		public AnimationCurve widthCurve { get => default; set {} } // 0x000000018BED0D80-0x000000018BED0D8C 0x000000018BED1150-0x000000018BED1158
		public Gradient colorGradient { get => default; set {} } // 0x000000018BED0A80-0x000000018BED0A8C 0x000000018BED0E00-0x000000018BED0E08
	
		// Constructors
		public LineRenderer() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void SetWidth(float start, float end) {} // 0x000000018BED09D4-0x000000018BED0A08
		public void SetColors(UnityEngine.Color start, UnityEngine.Color end) {} // 0x000000018BED07A8-0x000000018BED07F0
		public void SetVertexCount(int count) {} // 0x000000018BED0988-0x000000018BED0990
		public void SetPosition(int index, Vector3 position) {} // 0x000000018BED0840-0x000000018BED0854
		public Vector3 GetPosition(int index) => default; // 0x000000018BED05CC-0x000000018BED05FC
		public void Simplify(float tolerance) {} // 0x000000018BED0A08-0x000000018BED0A4C
		public void BakeMesh(Mesh mesh, bool useTransform = false /* Metadata: 0x02060422 */) {} // 0x000000018BED04FC-0x000000018BED0548
		public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false /* Metadata: 0x02060423 */) {} // 0x000000018BED0498-0x000000018BED04FC
		private AnimationCurve GetWidthCurveCopy() => default; // 0x000000018BED0730-0x000000018BED0764
		private void SetWidthCurve(AnimationCurve curve) {} // 0x000000018BED0990-0x000000018BED09D4
		private Gradient GetColorGradientCopy() => default; // 0x000000018BED0548-0x000000018BED057C
		private void SetColorGradient(Gradient curve) {} // 0x000000018BED0764-0x000000018BED07A8
		public int GetPositions(out Vector3[] positions) {
			positions = default;
			return default;
		} // 0x000000018BED0650-0x000000018BED0694
		public void SetPositions(Vector3[] positions) {} // 0x000000018BED08FC-0x000000018BED0940
		public void SetPositions(NativeArray<Vector3> positions) {} // 0x000000018BED0940-0x000000018BED0988
		public void SetPositions(NativeSlice<Vector3> positions) {} // 0x000000018BED08A8-0x000000018BED08FC
		public int GetPositions(out NativeArray<Vector3> positions) {
			positions = default;
			return default;
		} // 0x000000018BED0694-0x000000018BED06DC
		public int GetPositions(out NativeSlice<Vector3> positions) {
			positions = default;
			return default;
		} // 0x000000018BED06DC-0x000000018BED0730
		private void SetPositionsWithNativeContainer(IntPtr positions, int count) {} // 0x000000018BED0854-0x000000018BED08A8
		private int GetPositionsWithNativeContainer(IntPtr positions, int length) => default; // 0x000000018BED05FC-0x000000018BED0650
		private void get_startColor_Injected(out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BED0C74-0x000000018BED0CB8
		private void set_startColor_Injected(ref UnityEngine.Color value) {} // 0x000000018BED1030-0x000000018BED1074
		private void get_endColor_Injected(out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BED0A8C-0x000000018BED0AD0
		private void set_endColor_Injected(ref UnityEngine.Color value) {} // 0x000000018BED0E08-0x000000018BED0E4C
		private void SetPosition_Injected(int index, ref Vector3 position) {} // 0x000000018BED07F0-0x000000018BED0840
		private void GetPosition_Injected(int index, out Vector3 ret) {
			ret = default;
		} // 0x000000018BED057C-0x000000018BED05CC
	}

	public sealed class MaterialPropertyBlock // TypeDefIndex: 47400
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		public MaterialPropertyBlock() {} // 0x0000000184A77210-0x0000000184A77230
	
		// Methods
		private float GetFloatImpl(int name) => default; // 0x000000018BED11E0-0x000000018BED1220
		private Vector4 GetVectorImpl(int name) => default; // 0x000000018BED1370-0x000000018BED13A0
		private Matrix4x4 GetMatrixImpl(int name) => default; // 0x000000018BED127C-0x000000018BED12B8
		private void SetFloatImpl(int name, float value) {} // 0x00000001850FA9F0-0x00000001850FAA50
		private void SetVectorImpl(int name, Vector4 value) {} // 0x00000001864736A8-0x00000001864736BC
		private void SetColorImpl(int name, UnityEngine.Color value) {} // 0x000000018BED1510-0x000000018BED1524
		private void SetMatrixImpl(int name, Matrix4x4 value) {} // 0x000000018BED1B10-0x000000018BED1B24
		private void SetTextureImpl(int name, Texture value) {} // 0x00000001851472E0-0x0000000185147340
		private void HGSetTextureImpl(int name, Texture value) {} // 0x000000018BED13CC-0x000000018BED141C
		private void SetBufferImpl(int name, ComputeBuffer value, int offset, int size) {} // 0x000000018BED145C-0x000000018BED14BC
		private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) {} // 0x000000018BED15C8-0x000000018BED1628
		private void SetConstantBufferImpl0(int name, uint bufferId, int offset, int size) {} // 0x000000018BED1568-0x000000018BED15C8
		private void SetFloatArrayImpl(int name, float[] values, int count) {} // 0x000000018BED169C-0x000000018BED16FC
		private void SetVectorArrayImpl(int name, Vector4[] values, int count) {} // 0x000000018BED1BC4-0x000000018BED1C24
		private void SetNativeArrayImpl(int name, int type, UIntPtr values, int count) {} // 0x000000018BED1B64-0x000000018BED1BC4
		private static IntPtr CreateImpl() => default; // 0x0000000184A77230-0x0000000184A77270
		private static void DestroyImpl(IntPtr mpb) {} // 0x0000000185668C50-0x0000000185668C90
		private void Clear(bool keepMemory) {} // 0x00000001850D0EF0-0x00000001850D0F40
		public void Clear() {} // 0x000000018646DB98-0x000000018646DBA4
		public void CopyFrom(MaterialPropertyBlock properties) {} // 0x000000018BED119C-0x000000018BED11E0
		private void SetFloatArray(int name, float[] values, int count) {} // 0x000000018BED16FC-0x000000018BED1820
		private void SetVectorArray(int name, Vector4[] values, int count) {} // 0x000000018BED1E20-0x000000018BED1F44
		private void SetFloatArray(int name, NativeArray<float> values, int count) {} // 0x000000018BED1898-0x000000018BED1A3C
		private void SetVectorArray(int name, NativeArray<Vector4> values, int count) {} // 0x000000018BED1C24-0x000000018BED1DCC
		~MaterialPropertyBlock() {} // 0x0000000185668970-0x0000000185668BE0
		public IntPtr GetNativePtr() => default; // 0x0000000185FC7990-0x0000000185FC79A0
		private void Dispose() {} // 0x0000000185668BE0-0x0000000185668C50
		public void SetInt(string name, int value) {} // 0x000000018BED1A74-0x000000018BED1AB0
		public void SetInt(int nameID, int value) {} // 0x000000018BED1AB0-0x000000018BED1AC0
		public void SetFloat(string name, float value) {} // 0x000000018BED1A3C-0x000000018BED1A74
		public void SetFloat(int nameID, float value) {} // 0x000000018646D34C-0x000000018646D354
		public void SetVector(string name, Vector4 value) {} // 0x0000000185147870-0x00000001851478C0
		public void SetVector(int nameID, Vector4 value) {} // 0x000000018BED1F90-0x000000018BED1FB0
		public void SetColor(string name, UnityEngine.Color value) {} // 0x000000018BED1524-0x000000018BED1568
		public void SetColor(int nameID, UnityEngine.Color value) {} // 0x0000000186473DB8-0x0000000186473DE0
		public void SetMatrix(int nameID, Matrix4x4 value) {} // 0x000000018BED1B24-0x000000018BED1B64
		public void SetBuffer(string name, ComputeBuffer value, int offset = 0 /* Metadata: 0x02060424 */, int size = -1 /* Metadata: 0x02060425 */) {} // 0x000000018BED14BC-0x000000018BED1510
		public void SetTexture(string name, Texture value) {} // 0x0000000185147340-0x0000000185147380
		public void SetTexture(int nameID, Texture value) {} // 0x000000018647404C-0x0000000186474054
		public void HGSetTexture(string name, Texture value) {} // 0x000000018BED1424-0x000000018BED145C
		public void HGSetTexture(int nameID, Texture value) {} // 0x000000018BED141C-0x000000018BED1424
		public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) {} // 0x000000018BED1628-0x000000018BED1638
		public void SetConstantBuffer(string name, uint bufferId, int offset, int size) {} // 0x000000018BED1648-0x000000018BED169C
		public void SetConstantBuffer(int nameID, uint bufferId, int offset, int size) {} // 0x000000018BED1638-0x000000018BED1648
		public void SetFloatArray(string name, float[] values) {} // 0x000000018BED1820-0x000000018BED186C
		public void SetFloatArray(int nameID, NativeArray<float> values) {} // 0x000000018BED186C-0x000000018BED1898
		public void SetVectorArray(string name, Vector4[] values) {} // 0x000000018BED1F44-0x000000018BED1F90
		public void SetVectorArray(int nameID, Vector4[] values) {} // 0x000000018BED1DF8-0x000000018BED1E20
		public void SetVectorArray(int nameID, NativeArray<Vector4> values) {} // 0x000000018BED1DCC-0x000000018BED1DF8
		public float GetFloat(int nameID) => default; // 0x000000018BED1220-0x000000018BED122C
		public Vector4 GetVector(int nameID) => default; // 0x000000018BED13A0-0x000000018BED13CC
		public Matrix4x4 GetMatrix(int nameID) => default; // 0x000000018BED12B8-0x000000018BED1320
		private void GetVectorImpl_Injected(int name, out Vector4 ret) {
			ret = default;
		} // 0x000000018BED1320-0x000000018BED1370
		private void GetMatrixImpl_Injected(int name, out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BED122C-0x000000018BED127C
		private void SetVectorImpl_Injected(int name, ref Vector4 value) {} // 0x0000000185EBFF90-0x0000000185EBFFF0
		private void SetColorImpl_Injected(int name, ref UnityEngine.Color value) {} // 0x0000000185F79E10-0x0000000185F79E70
		private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) {} // 0x000000018BED1AC0-0x000000018BED1B10
	}

	public class Renderer : Component // TypeDefIndex: 47401
	{
		// Properties
		public bool castShadows { get => default; set {} } // 0x000000018BED92F0-0x000000018BED9308 0x000000018BED9BEC-0x000000018BED9C0C
		public bool motionVectors { get => default; set {} } // 0x000000018BED9654-0x000000018BED966C 0x000000018BED9E64-0x000000018BED9E84
		public bool useLightProbes { get => default; set {} } // 0x000000018BED9A78-0x000000018BED9A90 0x000000018BEDA1E4-0x000000018BEDA204
		public Bounds bounds { get => default; set {} } // 0x0000000184133240-0x00000001841332A0 0x000000018BED9B94-0x000000018BED9BA8
		public Bounds localBounds { get => default; set {} } // 0x000000018BED955C-0x000000018BED958C 0x000000018BED9E10-0x000000018BED9E24
		public Transform lightingAnchor { get => default; set {} } // 0x000000018BED94A8-0x000000018BED94DC 0x000000018426A4A0-0x000000018426A4F0
		public bool enablePerRendererLighting { get => default; set {} } // 0x000000018BED93A4-0x000000018BED93D8 0x0000000183FE0BD0-0x0000000183FE0C20
		public bool enabled { get => default; set {} } // 0x000000018421D160-0x000000018421D1A0 0x0000000184A9B800-0x0000000184A9B850
		public bool isVisible { get => default; } // 0x0000000184484940-0x0000000184484980 
		public ShadowCastingMode shadowCastingMode { get => default; set {} } // 0x0000000183F9C2F0-0x0000000183F9C330 0x0000000184130FF0-0x0000000184131040
		public bool receiveShadows { get => default; set {} } // 0x000000018BED9754-0x000000018BED9788 0x000000018BED9EFC-0x000000018BED9F40
		public bool forceRenderingOff { get => default; set {} } // 0x000000018BED93D8-0x000000018BED940C 0x000000018BED9CD8-0x000000018BED9D1C
		public bool staticShadowCaster { get => default; set {} } // 0x000000018BED9A04-0x000000018BED9A10 0x000000018BEDA198-0x000000018BEDA1A0
		public bool realtimeShadowCaster { get => default; set {} } // 0x000000018646D56C-0x000000018646D578 0x000000018646D580-0x000000018646D588
		public bool renderFoliageOccluder { get => default; set {} } // 0x000000018BED97BC-0x000000018BED97C8 0x000000018BED9F80-0x000000018BED9F88
		public ushort characterIndex { get => default; set {} } // 0x000000018BED9308-0x000000018BED933C 0x0000000183FDEED0-0x0000000183FDEF20
		public SubMeshRenderMode subMeshRenderMode { get => default; set {} } // 0x000000018BED9A10-0x000000018BED9A44 0x0000000183F9C370-0x0000000183F9C3C0
		public Mesh shadowProxyMesh { get => default; set {} } // 0x000000018BED9830-0x000000018BED9864 0x000000018BED9FC8-0x000000018BEDA00C
		public MotionVectorGenerationMode motionVectorGenerationMode { get => default; set {} } // 0x000000018BED9620-0x000000018BED9654 0x000000018BED9E24-0x000000018BED9E64
		public LightProbeUsage lightProbeUsage { get => default; set {} } // 0x000000018BED9474-0x000000018BED94A8 0x000000018BED9D60-0x000000018BED9DA0
		public ReflectionProbeUsage reflectionProbeUsage { get => default; set {} } // 0x000000018BED9788-0x000000018BED97BC 0x000000018BED9F40-0x000000018BED9F80
		public uint renderingLayerMask { get => default; set {} } // 0x000000018BED97FC-0x000000018BED9830 0x0000000183FDEE80-0x0000000183FDEED0
		public int rendererPriority { get => default; set {} } // 0x000000018BED97C8-0x000000018BED97FC 0x000000018BED9F88-0x000000018BED9FC8
		public RayTracingMode rayTracingMode { get => default; set {} } // 0x0000000183F9C330-0x0000000183F9C370 0x0000000184130FA0-0x0000000184130FF0
		public string sortingLayerName { get => default; set {} } // 0x000000018BED9934-0x000000018BED9968 0x000000018BEDA110-0x000000018BEDA154
		public int sortingLayerID { get => default; set {} } // 0x000000018BED9900-0x000000018BED9934 0x000000018BEDA0D0-0x000000018BEDA110
		public int sortingOrder { get => default; set {} } // 0x000000018BED9968-0x000000018BED999C 0x0000000184CD22A0-0x0000000184CD22F0
		internal int sortingGroupID { get => default; set {} } // 0x000000018BED9898-0x000000018BED98CC 0x000000018BEDA050-0x000000018BEDA090
		internal int sortingGroupOrder { get => default; set {} } // 0x000000018BED98CC-0x000000018BED9900 0x000000018BEDA090-0x000000018BEDA0D0
		public float sortingFudge { get => default; set {} } // 0x000000018BED9864-0x000000018BED9898 0x000000018BEDA00C-0x000000018BEDA050
		public bool useCustomLODFadeValue { get => default; set {} } // 0x000000018BED9A44-0x000000018BED9A78 0x000000018BEDA1A0-0x000000018BEDA1E4
		public float customLODFadeValue { get => default; set {} } // 0x000000018BED933C-0x000000018BED9370 0x000000018BED9C0C-0x000000018BED9C50
		public bool allowOcclusionWhenDynamic { get => default; set {} } // 0x000000018BED92BC-0x000000018BED92F0 0x000000018BED9B0C-0x000000018BED9B50
		internal Transform staticBatchRootTransform { get => default; set {} } // 0x000000018BED99D0-0x000000018BED9A04 0x000000018BEDA154-0x000000018BEDA198
		internal int staticBatchIndex { get => default; } // 0x000000018BED999C-0x000000018BED99D0 
		public bool isPartOfStaticBatch { get => default; } // 0x000000018BED940C-0x000000018BED9440 
		public Matrix4x4 worldToLocalMatrix { get => default; } // 0x000000018BED9AD4-0x000000018BED9B0C 
		public Matrix4x4 localToWorldMatrix { get => default; } // 0x000000018BED95D0-0x000000018BED9608 
		public GameObject lightProbeProxyVolumeOverride { get => default; set {} } // 0x000000018BED9440-0x000000018BED9474 0x000000018BED9D1C-0x000000018BED9D60
		public Transform probeAnchor { get => default; set {} } // 0x000000018BED96DC-0x000000018BED9710 0x000000018BED9E84-0x000000018BED9EC8
		public LODGroup LODGroup { get => default; } // 0x000000018BED9288-0x000000018BED92BC 
		public int lightmapIndex { get => default; set {} } // 0x000000018BED94DC-0x000000018BED94E8 0x000000018BED9DA0-0x000000018BED9DAC
		public int realtimeLightmapIndex { get => default; set {} } // 0x000000018BED9710-0x000000018BED9720 0x000000018BED9EC8-0x000000018BED9ED8
		public Vector4 lightmapScaleOffset { get => default; set {} } // 0x000000018BED94E8-0x000000018BED9518 0x000000018BED9DAC-0x000000018BED9DCC
		public Vector4 realtimeLightmapScaleOffset { get => default; set {} } // 0x000000018BED9720-0x000000018BED9754 0x000000018BED9ED8-0x000000018BED9EFC
		public Material[] materials { get => default; set {} } // 0x000000018BED9614-0x000000018BED9620 0x000000018646D578-0x000000018646D580
		public Material material { get => default; set {} } // 0x000000018BED9608-0x000000018BED9614 0x0000000186470F14-0x0000000186470F1C
		public Material sharedMaterial { get => default; set {} } // 0x000000018646FE20-0x000000018646FE2C 0x0000000186470F14-0x0000000186470F1C
		public Material[] sharedMaterials { get => default; set {} } // 0x000000018646D340-0x000000018646D34C 0x000000018646D578-0x000000018646D580
		public bool enableManualDither { set {} } // 0x000000018421D110-0x000000018421D160
		public bool enableCameraDither { set {} } // 0x000000018BED9C50-0x000000018BED9C94
		public float manualDitherAlphaValue { set {} } // 0x000000018421D0C0-0x000000018421D110
		public float cameraDitherAlphaValue { set {} } // 0x000000018BED9BA8-0x000000018BED9BEC
		public bool enableCharacterOutline { get => default; set {} } // 0x000000018BED9370-0x000000018BED93A4 0x000000018BED9C94-0x000000018BED9CD8
		public Vector3 perRendererLightingOffset { get => default; set {} } // 0x000000018BED96B0-0x000000018BED96DC 0x000000018646E468-0x000000018646E47C
	
		// Constructors
		public Renderer() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void ResetBounds() {} // 0x000000018BED9004-0x000000018BED9038
		public void ResetLocalBounds() {} // 0x0000000184267D60-0x0000000184267DA0
		private void SetStaticLightmapST(Vector4 st) {} // 0x000000018BED9274-0x000000018BED9288
		public Material GetInstantiatedMaterial() => default; // 0x00000001859A8640-0x00000001859A8680
		public Material[] GetInstantiatedMaterialArray() => default; // 0x0000000184A75400-0x0000000184A75440
		private Material GetAndAssignInstantiatedMaterial() => default; // 0x000000018BED8998-0x000000018BED89CC
		private Material GetSharedMaterial() => default; // 0x0000000184F400E0-0x0000000184F40120
		private void SetMaterial(Material m) {} // 0x000000018587B470-0x000000018587B4C0
		private Material[] GetMaterialArray() => default; // 0x000000018BED8D1C-0x000000018BED8D50
		private void CopyAndAssignInstantiatedMaterialArray(out Material[] m) {
			m = default;
		} // 0x000000018BED8898-0x000000018BED88DC
		public void CopyInstantiatedMaterialArray(out Material[] m) {
			m = default;
		} // 0x000000018BED88DC-0x000000018BED8920
		private void CopySharedMaterialArray(out Material[] m) {
			m = default;
		} // 0x0000000183F9C2A0-0x0000000183F9C2F0
		private void SetMaterialArray(Material[] m) {} // 0x000000018514C670-0x000000018514C6C0
		internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) {} // 0x0000000184D81FD0-0x0000000184D82020
		internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) {} // 0x0000000185BC1E80-0x0000000185BC1ED0
		internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) {} // 0x000000018BED8FB0-0x000000018BED9004
		internal void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex) {} // 0x000000018BED8F5C-0x000000018BED8FB0
		public bool HasPropertyBlock() => default; // 0x000000018BED8F28-0x000000018BED8F5C
		public void SetPropertyBlock(MaterialPropertyBlock properties) {} // 0x000000018646DBA4-0x000000018646DBAC
		public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) {} // 0x000000018BED9194-0x000000018BED919C
		public void GetPropertyBlock(MaterialPropertyBlock properties) {} // 0x0000000186474054-0x000000018647405C
		public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) {} // 0x000000018BED8E80-0x000000018BED8E88
		private void GetClosestReflectionProbesInternal(object result) {} // 0x000000018BED8A30-0x000000018BED8A74
		private static void GetClosestReflectionProbesInternal2(in Bounds aabb, Transform anchor, ReflectionProbeUsage usage, object result) {} // 0x000000018BED89CC-0x000000018BED8A30
		public static ReflectionProbe GetReflectionProbeBySerializedIdentifier(long identifier) => default; // 0x000000018BED8EC0-0x000000018BED8EF4
		private static void GetAllReflectionProbesInternal(object result) {} // 0x000000018BED895C-0x000000018BED8990
		private static void GetAllProbeTextureIndicesInternal(out int[] result) {
			result = default;
		} // 0x000000018BED8920-0x000000018BED8954
		private static Texture GetReflectionProbeArrayInternal() => default; // 0x000000018BED8E88-0x000000018BED8EB4
		private bool GetIsStaticShadowCaster() => default; // 0x000000018BED8C28-0x000000018BED8C5C
		private void SetIsStaticShadowCaster(bool value) {} // 0x000000018BED9038-0x000000018BED907C
		private bool GetIsRealtimeShadowCaster() => default; // 0x000000018510A890-0x000000018510A8D0
		private void SetIsRealtimeShadowCaster(bool value) {} // 0x0000000185251540-0x0000000185251650
		private bool GetRenderFoliageOccluder() => default; // 0x000000018BED8EF4-0x000000018BED8F28
		private void SetRenderFoliageOccluder(bool value) {} // 0x000000018BED919C-0x000000018BED91E0
		internal void SetStaticBatchInfo(int firstSubMesh, int subMeshCount) {} // 0x000000018BED91E0-0x000000018BED9230
		private int GetLightmapIndex(LightmapType lt) => default; // 0x000000018BED8C5C-0x000000018BED8C9C
		private void SetLightmapIndex(int index, LightmapType lt) {} // 0x000000018BED907C-0x000000018BED90CC
		private Vector4 GetLightmapST(LightmapType lt) => default; // 0x000000018BED8CEC-0x000000018BED8D1C
		private void SetLightmapST(Vector4 st, LightmapType lt) {} // 0x000000018BED9120-0x000000018BED9134
		private int GetMaterialCount() => default; // 0x0000000183F9C260-0x0000000183F9C2A0
		private Material[] GetSharedMaterialArray() => default; // 0x00000001851729F0-0x0000000185172A30
		public void GetMaterials(List<Material> m) {} // 0x000000018BED8D50-0x000000018BED8E38
		public void GetInstantiatedMaterials(List<Material> m) {} // 0x000000018BED8B40-0x000000018BED8C28
		public void GetSharedMaterials(List<Material> m) {} // 0x0000000183F9C180-0x0000000183F9C260
		public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result) {} // 0x000000018BED8A84-0x000000018BED8A8C
		public static void GetClosestReflectionProbes(in Bounds aabb, Transform anchor, ReflectionProbeUsage usage, List<ReflectionProbeBlendInfo> result) {} // 0x000000018BED8A74-0x000000018BED8A84
		public static void GetAllReflectionProbes(List<ReflectionProbeBlendInfo> result) {} // 0x000000018BED8990-0x000000018BED8998
		public static void GetAllProbeTextureIndices(int[] result) {} // 0x000000018BED8954-0x000000018BED895C
		public static Texture GetReflectionProbeArray() => default; // 0x000000018BED8EB4-0x000000018BED8EC0
		public void SetCustomPerDrawData(int index, Vector4 param) {} // 0x000000018646E3B8-0x000000018646E3CC
		public Vector4 GetCustomPerDrawData(int index) => default; // 0x000000018BED8B10-0x000000018BED8B40
		public unsafe Vector4* GetCustomPerDrawDataPtr() => default; // 0x000000018BED8A8C-0x000000018BED8AC0
		internal void SetPlatformSpecificCastShadowsInternal(IntPtr value) {} // 0x000000018BED9134-0x000000018BED9178
		internal IntPtr GetPlatformSpecificCastShadowsInternal() => default; // 0x000000018BED8E38-0x000000018BED8E6C
		public void SetPlatformSpecificCastShadows(PlatformSpecificParam<uint> value) {} // 0x000000018BED9178-0x000000018BED9194
		public PlatformSpecificParam<uint> GetPlatformSpecificCastShadows() => default; // 0x000000018BED8E6C-0x000000018BED8E80
		private void get_bounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x00000001841332A0-0x0000000184133370
		private void set_bounds_Injected(ref Bounds value) {} // 0x000000018BED9B50-0x000000018BED9B94
		private void get_localBounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x000000018BED9518-0x000000018BED955C
		private void set_localBounds_Injected(ref Bounds value) {} // 0x000000018BED9DCC-0x000000018BED9E10
		private void SetStaticLightmapST_Injected(ref Vector4 st) {} // 0x000000018BED9230-0x000000018BED9274
		private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BED9A90-0x000000018BED9AD4
		private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BED958C-0x000000018BED95D0
		private void GetLightmapST_Injected(LightmapType lt, out Vector4 ret) {
			ret = default;
		} // 0x000000018BED8C9C-0x000000018BED8CEC
		private void SetLightmapST_Injected(ref Vector4 st, LightmapType lt) {} // 0x000000018BED90CC-0x000000018BED9120
		private void SetCustomPerDrawData_Injected(int index, ref Vector4 param) {} // 0x0000000184A8AF70-0x0000000184A8AFD0
		private void GetCustomPerDrawData_Injected(int index, out Vector4 ret) {
			ret = default;
		} // 0x000000018BED8AC0-0x000000018BED8B10
		private void get_perRendererLightingOffset_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BED966C-0x000000018BED96B0
		private void set_perRendererLightingOffset_Injected(ref Vector3 value) {} // 0x00000001851D0C10-0x00000001851D0C60
	}

	public sealed class RenderSettings : UnityEngine.Object // TypeDefIndex: 47402
	{
		// Properties
		public static float fogStartDistance { get => default; set {} } // 0x000000018BED7718-0x000000018BED7744 0x000000018BED7880-0x000000018BED78BC
		public static float fogEndDistance { get => default; set {} } // 0x000000018BED76EC-0x000000018BED7718 0x000000018BED7844-0x000000018BED7880
		public static UnityEngine.Color fogColor { get => default; set {} } // 0x000000018BED76A0-0x000000018BED76C0 0x000000018BED77F8-0x000000018BED7808
		public static float fogDensity { get => default; set {} } // 0x000000018BED76C0-0x000000018BED76EC 0x000000018BED7808-0x000000018BED7844
		public static AmbientMode ambientMode { set {} } // 0x000000018451A390-0x000000018451A3D0
		public static float ambientIntensity { get => default; set {} } // 0x000000018BED757C-0x000000018BED75A8 0x000000018BED7744-0x000000018BED7780
		public static UnityEngine.Color ambientLight { get => default; set {} } // 0x000000018BED75DC-0x000000018BED75FC 0x000000018BED77B4-0x000000018BED77C4
		public static Material skybox { set {} } // 0x000000018451A410-0x000000018451A450
		public static Light sun { set {} } // 0x000000018451A3D0-0x000000018451A410
		public static SphericalHarmonicsL2 ambientProbe { get => default; set {} } // 0x000000018BED7630-0x000000018BED766C 0x000000018646F168-0x000000018646F178
		public static DefaultReflectionMode defaultReflectionMode { set {} } // 0x000000018451A350-0x000000018451A390
	
		// Constructors
		public RenderSettings() {} // Dummy constructor
	
		// Methods
		private static void get_fogColor_Injected(out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BED766C-0x000000018BED76A0
		private static void set_fogColor_Injected(ref UnityEngine.Color value) {} // 0x000000018BED77C4-0x000000018BED77F8
		private static void get_ambientLight_Injected(out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BED75A8-0x000000018BED75DC
		private static void set_ambientLight_Injected(ref UnityEngine.Color value) {} // 0x000000018BED7780-0x000000018BED77B4
		private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) {
			ret = default;
		} // 0x000000018BED75FC-0x000000018BED7630
		private static void set_ambientProbe_Injected(ref SphericalHarmonicsL2 value) {} // 0x000000018512D810-0x000000018512D850
	}

	public sealed class Shader : UnityEngine.Object // TypeDefIndex: 47403
	{
		// Fields
		private static Action<string> onCompileShader; // 0x00
		private static Action<string, string, string, string> onKeywordNotBestMatch; // 0x08
		private static Action<string, float, int, bool> onRenderPipelineUpload; // 0x10
	
		// Properties
		public static int globalMaximumLOD { get => default; set {} } // 0x000000018525BB00-0x000000018525BB40 0x0000000185EF5960-0x0000000185EF59A0
		public bool isSupported { get => default; } // 0x000000018BEDA614-0x000000018BEDA648 
		public static string globalRenderPipeline { set {} } // 0x00000001852C84F0-0x00000001852C8530
		public LocalKeywordSpace keywordSpace { get => default; } // 0x000000018BEDA68C-0x000000018BEDA6B0 
		public static bool forceSubShaderReload { set {} } // 0x000000018BEDA6B0-0x000000018BEDA6E4
	
		// Constructors
		private Shader() {} // 0x000000018BEDA5D4-0x000000018BEDA614
	
		// Methods
		public static Shader Find(string name) => default; // 0x0000000185625330-0x0000000185625390
		public static void EnableKeyword(string keyword) {} // 0x000000018BEDA3CC-0x000000018BEDA400
		public static void DisableKeyword(string keyword) {} // 0x00000001850F9420-0x00000001850F9460
		internal static int TagToID(string name) => default; // 0x00000001859EF140-0x00000001859EF180
		public static int PropertyToID(string name) => default; // 0x0000000184246C90-0x0000000184246CD0
		private static void SetGlobalFloatImpl(int name, float value) {} // 0x0000000185F5F520-0x0000000185F5F570
		private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) {} // 0x0000000186474180-0x0000000186474194
		private static void SetGlobalTextureImpl(int name, Texture value) {} // 0x0000000184BD1C50-0x0000000184BD1CA0
		private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) {} // 0x000000018BEDA564-0x000000018BEDA5C4
		internal static void InvokeOnCompileShader(string url) {} // 0x000000018BEDA400-0x000000018BEDA450
		internal static void InvokeOnKeywordNotBestMatch(string shaderName, string passInfo, string requestKeyword, string foundKeyword) {} // 0x000000018BEDA450-0x000000018BEDA4DC
		public static void InvokeOnRenderPipelineUpload(string infoJson, float time, int codeSize, bool isMissing) {} // 0x000000018BEDA4DC-0x000000018BEDA564
		public static void SetGlobalFloat(int nameID, float value) {} // 0x0000000186472008-0x0000000186472010
		public static void SetGlobalMatrix(string name, Matrix4x4 value) {} // 0x0000000185621BE0-0x0000000185621C60
		public static void SetGlobalTexture(int nameID, Texture value) {} // 0x0000000186472010-0x0000000186472018
		public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) {} // 0x000000018BEDA5C4-0x000000018BEDA5D4
		private void get_keywordSpace_Injected(out LocalKeywordSpace ret) {
			ret = default;
		} // 0x000000018BEDA648-0x000000018BEDA68C
		private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) {} // 0x0000000185621C60-0x0000000185621CB0
	}

	public class Material : UnityEngine.Object // TypeDefIndex: 47404
	{
		// Properties
		public Shader shader { get => default; set {} } // 0x00000001845E9F70-0x00000001845E9FB0 0x0000000184514430-0x0000000184514480
		public UnityEngine.Color color { get => default; set {} } // 0x000000018BED2E30-0x000000018BED2EAC 0x000000018BED3044-0x000000018BED30B8
		public Texture mainTexture { get => default; set {} } // 0x00000001842463B0-0x0000000184246480 0x0000000184F21A40-0x0000000184F21AB0
		public Vector2 mainTextureOffset { get => default; set {} } // 0x000000018BED2EE0-0x000000018BED2F44 0x000000018BED3100-0x000000018BED3170
		public Vector2 mainTextureScale { get => default; set {} } // 0x000000018BED2F44-0x000000018BED2FA8 0x000000018BED3170-0x000000018BED31E0
		public int renderQueue { get => default; set {} } // 0x000000018BED2FDC-0x000000018BED3010 0x00000001845158A0-0x00000001845158F0
		public LocalKeyword[] enabledKeywords { set {} } // 0x000000018BED30B8-0x000000018BED30C0
		public MaterialGlobalIlluminationFlags globalIlluminationFlags { set {} } // 0x000000018BED30C0-0x000000018BED3100
		public bool enableInstancing { get => default; set {} } // 0x000000018BED2EAC-0x000000018BED2EE0 0x0000000184A74C30-0x0000000184A74C80
		public int passCount { get => default; } // 0x000000018BED2FA8-0x000000018BED2FDC 
		public string[] shaderKeywords { get => default; set {} } // 0x000000018646F638-0x000000018646F644 0x000000018BED31E0-0x000000018BED31E8
		public HGSubsurfaceProfile subsurfaceProfile { get => default; } // 0x000000018BED3010-0x000000018BED3044 
	
		// Constructors
		public Material() {} // Dummy constructor
		public Material(Shader shader) {} // 0x0000000184A74C80-0x0000000184A74CE0
		public Material(Material source) {} // 0x0000000184514040-0x00000001845140A0
		public Material(string contents) {} // 0x000000018BED2DE4-0x000000018BED2E30
	
		// Methods
		public IntPtr HGGetPtrUnchecked() => default; // 0x0000000185FC7990-0x0000000185FC79A0
		private static void CreateWithShader(Material self, Shader shader) {} // 0x0000000184A74CE0-0x0000000184A74D30
		private static void CreateWithMaterial(Material self, Material source) {} // 0x00000001845140A0-0x00000001845140F0
		private static void CreateWithString(Material self) {} // 0x000000018BED1FB0-0x000000018BED1FE4
		private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) => default; // 0x0000000184246480-0x00000001842464D0
		public bool HasProperty(int nameID) => default; // 0x00000001845E94A0-0x00000001845E94F0
		public bool HasProperty(string name) => default; // 0x00000001845E7620-0x00000001845E7650
		private bool HasFloatImpl(int name) => default; // 0x00000001845EDBF0-0x00000001845EDC40
		public bool HasFloat(string name) => default; // 0x00000001845EDBC0-0x00000001845EDBF0
		public bool HasFloat(int nameID) => default; // 0x0000000186474604-0x0000000186474610
		public bool HasInt(string name) => default; // 0x00000001845EDBC0-0x00000001845EDBF0
		private bool HasVectorImpl(int name) => default; // 0x000000018BED25F0-0x000000018BED2630
		public bool HasColor(string name) => default; // 0x000000018BED25C8-0x000000018BED25F0
		public void EnableKeyword(string keyword) {} // 0x00000001845162F0-0x0000000184516340
		public void DisableKeyword(string keyword) {} // 0x00000001845158F0-0x00000001845159A0
		public bool IsKeywordEnabled(string keyword) => default; // 0x00000001845EDC40-0x00000001845EDC90
		private void EnableLocalKeyword(LocalKeyword keyword) {} // 0x000000018BED20D8-0x000000018BED20EC
		private void DisableLocalKeyword(LocalKeyword keyword) {} // 0x000000018BED2054-0x000000018BED2068
		private void SetLocalKeyword(LocalKeyword keyword, bool value) {} // 0x000000018BED28D0-0x000000018BED28E4
		public void EnableKeyword(in LocalKeyword keyword) {} // 0x000000018BED2068-0x000000018BED2094
		public void DisableKeyword(in LocalKeyword keyword) {} // 0x000000018BED1FE4-0x000000018BED2010
		public void SetKeyword(in LocalKeyword keyword, bool value) {} // 0x000000018BED2850-0x000000018BED287C
		private void SetEnabledKeywords(LocalKeyword[] keywords) {} // 0x000000018BED2774-0x000000018BED27B8
		public void SetShaderPassEnabled(string passName, bool enabled) {} // 0x0000000185725890-0x00000001857258F0
		public bool GetShaderPassEnabledAndExisted(string passName) => default; // 0x000000018BED21F8-0x000000018BED223C
		public int FindPass(string passName) => default; // 0x000000018BED20EC-0x000000018BED2130
		public void SetOverrideTag(string tag, string val) {} // 0x000000018BED2B6C-0x000000018BED2BC0
		private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) => default; // 0x000000018BED223C-0x000000018BED22A0
		public string GetTag(string tag, bool searchFallbacks) => default; // 0x000000018BED22A0-0x000000018BED2304
		public bool SetPass(int pass) => default; // 0x000000018BED2BC0-0x000000018BED2C00
		public void CopyPropertiesFromMaterial(Material mat) {} // 0x0000000184515F20-0x0000000184515F70
		private string[] GetShaderKeywords() => default; // 0x000000018511DAB0-0x000000018511DAF0
		private void SetShaderKeywords(string[] names) {} // 0x000000018BED2C00-0x000000018BED2C44
		public int ComputeCRC() => default; // 0x0000000184513D40-0x0000000184513D80
		public int[] GetTexturePropertyNameIDs() => default; // 0x000000018BED2364-0x000000018BED2398
		private void GetTexturePropertyNamesInternal(object outNames) {} // 0x000000018BED2398-0x000000018BED23DC
		public void GetTexturePropertyNames(List<string> outNames) {} // 0x000000018BED23DC-0x000000018BED2448
		private void SetIntImpl(int name, int value) {} // 0x000000018BED27B8-0x000000018BED2808
		private void SetFloatImpl(int name, float value) {} // 0x0000000184246CD0-0x0000000184246D30
		private void SetColorImpl(int name, UnityEngine.Color value) {} // 0x000000018646F658-0x000000018646F66C
		private void SetMatrixImpl(int name, Matrix4x4 value) {} // 0x000000018BED2AF8-0x000000018BED2B0C
		private void SetTextureImpl(int name, Texture value) {} // 0x0000000184F21AF0-0x0000000184F21B50
		private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) {} // 0x000000018BED26F4-0x000000018BED2754
		private void SetConstantBufferImpl0(int name, uint bufferId, int offset, int size) {} // 0x000000018BED2694-0x000000018BED26F4
		private int GetIntImpl(int name) => default; // 0x000000018BED2178-0x000000018BED21B8
		private float GetFloatImpl(int name) => default; // 0x00000001845EDB70-0x00000001845EDBC0
		private UnityEngine.Color GetColorImpl(int name) => default; // 0x00000001845EA110-0x00000001845EA180
		private Texture GetTextureImpl(int name) => default; // 0x0000000184246540-0x0000000184246590
		private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) {} // 0x000000018BED28E4-0x000000018BED2944
		private Vector4 GetTextureScaleAndOffsetImpl(int name) => default; // 0x000000018BED2498-0x000000018BED24C8
		private void SetTextureOffsetImpl(int name, Vector2 offset) {} // 0x000000018BED2C94-0x000000018BED2CB0
		private void SetTextureScaleImpl(int name, Vector2 scale) {} // 0x000000018BED2D34-0x000000018BED2D50
		private void SetMatrixArray(int name, Matrix4x4[] values, int count) {} // 0x000000018BED29D4-0x000000018BED2AF8
		public void SetInt(string name, int value) {} // 0x0000000184A753C0-0x0000000184A75400
		public void SetInt(int nameID, int value) {} // 0x000000018BED2808-0x000000018BED2818
		public void SetFloat(string name, float value) {} // 0x0000000184246C00-0x0000000184246C90
		public void SetFloat(int nameID, float value) {} // 0x000000018646F650-0x000000018646F658
		public void SetInteger(string name, int value) {} // 0x000000018BED2818-0x000000018BED2850
		public void SetColor(string name, UnityEngine.Color value) {} // 0x000000018BED2650-0x000000018BED2694
		public void SetColor(int nameID, UnityEngine.Color value) {} // 0x000000018BED2630-0x000000018BED2650
		public void SetVector(string name, Vector4 value) {} // 0x000000018BED2D84-0x000000018BED2DE4
		public void SetVector(int nameID, Vector4 value) {} // 0x00000001845EA770-0x00000001845EA7E0
		public void SetMatrix(string name, Matrix4x4 value) {} // 0x000000018BED2B0C-0x000000018BED2B6C
		public void SetMatrix(int nameID, Matrix4x4 value) {} // 0x000000018646F674-0x000000018646F6B4
		public void SetTexture(string name, Texture value) {} // 0x0000000184F21AB0-0x0000000184F21AF0
		public void SetTexture(int nameID, Texture value) {} // 0x000000018646F66C-0x000000018646F674
		public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) {} // 0x000000018BED2764-0x000000018BED2774
		public void SetConstantBuffer(int nameID, uint bufferId, int offset, int size) {} // 0x000000018BED2754-0x000000018BED2764
		public void SetMatrixArray(string name, List<Matrix4x4> values) {} // 0x000000018BED2944-0x000000018BED29D4
		public int GetInt(string name) => default; // 0x00000001845EDB40-0x00000001845EDB70
		public int GetInt(int nameID) => default; // 0x000000018BED21B8-0x000000018BED21D0
		public float GetFloat(string name) => default; // 0x00000001858C3640-0x00000001858C3670
		public float GetFloat(int nameID) => default; // 0x000000018646F644-0x000000018646F650
		public int GetInteger(string name) => default; // 0x000000018BED21D0-0x000000018BED21F8
		public UnityEngine.Color GetColor(string name) => default; // 0x000000018BED2130-0x000000018BED2178
		public UnityEngine.Color GetColor(int nameID) => default; // 0x00000001845EA090-0x00000001845EA110
		public Vector4 GetVector(string name) => default; // 0x000000018BED2524-0x000000018BED2584
		public Vector4 GetVector(int nameID) => default; // 0x000000018BED2584-0x000000018BED25C8
		public Texture GetTexture(string name) => default; // 0x00000001842464D0-0x0000000184246540
		public Texture GetTexture(int nameID) => default; // 0x000000018646E438-0x000000018646E444
		public void SetTextureOffset(string name, Vector2 value) {} // 0x000000018BED2CB0-0x000000018BED2CE4
		public void SetTextureOffset(int nameID, Vector2 value) {} // 0x000000018BED2C94-0x000000018BED2CB0
		public void SetTextureScale(string name, Vector2 value) {} // 0x000000018BED2D50-0x000000018BED2D84
		public void SetTextureScale(int nameID, Vector2 value) {} // 0x000000018BED2D34-0x000000018BED2D50
		public Vector2 GetTextureOffset(string name) => default; // 0x000000018BED2338-0x000000018BED2364
		public Vector2 GetTextureOffset(int nameID) => default; // 0x000000018BED2304-0x000000018BED2338
		public Vector2 GetTextureScale(string name) => default; // 0x000000018BED24F8-0x000000018BED2524
		public Vector2 GetTextureScale(int nameID) => default; // 0x000000018BED24C8-0x000000018BED24F8
		private void EnableLocalKeyword_Injected(ref LocalKeyword keyword) {} // 0x000000018BED2094-0x000000018BED20D8
		private void DisableLocalKeyword_Injected(ref LocalKeyword keyword) {} // 0x000000018BED2010-0x000000018BED2054
		private void SetLocalKeyword_Injected(ref LocalKeyword keyword, bool value) {} // 0x000000018BED287C-0x000000018BED28D0
		private void SetColorImpl_Injected(int name, ref UnityEngine.Color value) {} // 0x0000000184FE3740-0x0000000184FE37A0
		private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) {} // 0x000000018531B2C0-0x000000018531B320
		private void GetColorImpl_Injected(int name, out UnityEngine.Color ret) {
			ret = default;
		} // 0x00000001845EA180-0x00000001845EA1E0
		private void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret) {
			ret = default;
		} // 0x000000018BED2448-0x000000018BED2498
		private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) {} // 0x000000018BED2C44-0x000000018BED2C94
		private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) {} // 0x000000018BED2CE4-0x000000018BED2D34
	}

	public sealed class GraphicsBuffer : IDisposable // TypeDefIndex: 47406
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public int count { get => default; } // 0x000000018BECBF24-0x000000018BECBF58 
		public int stride { get => default; } // 0x000000018BECBF58-0x000000018BECBF8C 
		public Target target { get => default; } // 0x000000018BECBF8C-0x000000018BECBFC0 
	
		// Nested types
		public enum Target // TypeDefIndex: 47405
		{
			Vertex = 1,
			Index = 2,
			CopySource = 4,
			CopyDestination = 8,
			Structured = 16,
			Raw = 32,
			Append = 64,
			Counter = 128,
			IndirectArguments = 256,
			Constant = 512
		}
	
		// Constructors
		public GraphicsBuffer() {} // Dummy constructor
		public GraphicsBuffer(Target target, int count, int stride) {} // 0x000000018BECBB7C-0x000000018BECBF24
	
		// Methods
		~GraphicsBuffer() {} // 0x000000018BECB884-0x000000018BECB8F8
		public void Dispose() {} // 0x000000018BECB7B8-0x000000018BECB808
		private void Dispose(bool disposing) {} // 0x000000018BECB808-0x000000018BECB884
		private static bool RequiresCompute(Target target) => default; // 0x000000018BECBA24-0x000000018BECBA30
		private static bool IsVertexIndexOrCopyOnly(Target target) => default; // 0x000000018BECBA10-0x000000018BECBA1C
		private static IntPtr InitBuffer(Target target, int count, int stride) => default; // 0x000000018BECB8F8-0x000000018BECB948
		private static void DestroyBuffer(GraphicsBuffer buf) {} // 0x000000018BECB784-0x000000018BECB7B8
		public void Release() {} // 0x000000018BECBA1C-0x000000018BECBA24
		public void SetData(Array data) {} // 0x000000018BECBA30-0x000000018BECBB7C
		public void SetData<T>(NativeArray<T> data)
			where T : struct {}
		private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) {} // 0x000000018BECB9AC-0x000000018BECBA10
		private void InternalSetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) {} // 0x000000018BECB948-0x000000018BECB9AC
	}

	public sealed class Flare : UnityEngine.Object // TypeDefIndex: 47407
	{
		// Constructors
		public Flare() {} // 0x000000018BECB14C-0x000000018BECB198
	
		// Methods
		private static void Internal_Create(Flare self) {} // 0x000000018BECB118-0x000000018BECB14C
	}

	public struct LightBakingOutput // TypeDefIndex: 47408
	{
		// Fields
		public int probeOcclusionLightIndex; // 0x00
		public int occlusionMaskChannel; // 0x04
		public LightmapBakeType lightmapBakeType; // 0x08
		public MixedLightingMode mixedLightingMode; // 0x0C
		public bool isBaked; // 0x10
	}

	public enum LightShadowCasterMode // TypeDefIndex: 47409
	{
		Default = 0,
		NonLightmappedOnly = 1,
		Everything = 2
	}

	public sealed class Light : UnityEngine.Behaviour // TypeDefIndex: 47410
	{
		// Fields
		private int m_BakedIndex; // 0x18
	
		// Properties
		public LightType type { get => default; set {} } // 0x000000018BECF3AC-0x000000018BECF3E0 0x000000018BED028C-0x000000018BED02CC
		public LightShape shape { get => default; set {} } // 0x000000018BECF344-0x000000018BECF378 0x000000018BED01C4-0x000000018BED0204
		public float spotAngle { get => default; set {} } // 0x000000018BECF378-0x000000018BECF3AC 0x000000018BED0248-0x000000018BED028C
		public float innerSpotAngle { get => default; set {} } // 0x000000018BECED2C-0x000000018BECED60 0x000000018BECFA6C-0x000000018BECFAB0
		public UnityEngine.Color color { get => default; set {} } // 0x0000000184F0F920-0x0000000184F0F980 0x0000000186472A94-0x0000000186472AA8
		public float colorTemperature { get => default; set {} } // 0x000000018BECE938-0x000000018BECE96C 0x000000018BECF67C-0x000000018BECF6C0
		public bool useColorTemperature { get => default; set {} } // 0x000000018BECF414-0x000000018BECF448 0x000000018BED0310-0x000000018BED0354
		public bool isSunSourceLight { get => default; set {} } // 0x000000018BECEDDC-0x000000018BECEE10 0x000000018BECFB2C-0x000000018BECFB70
		public bool shadowOnly { get => default; set {} } // 0x000000018BECF274-0x000000018BECF2A8 0x000000018BED00BC-0x000000018BED0100
		public bool enableOBBCullingBox { get => default; set {} } // 0x000000018BECEC28-0x000000018BECEC5C 0x000000018BECF95C-0x000000018BECF9A0
		public bool obbCullingBoxMode { get => default; set {} } // 0x000000018BECEF14-0x000000018BECEF48 0x000000018BECFCB8-0x000000018BECFCFC
		public Vector3 cullingBoxRelativePosition { get => default; set {} } // 0x000000018BECEB60-0x000000018BECEB8C 0x000000018BECF880-0x000000018BECF894
		public Vector3 cullingBoxHalfExtents { get => default; set {} } // 0x000000018BECEA80-0x000000018BECEAAC 0x000000018BECF7D0-0x000000018BECF7E4
		public Vector3 cullingBoxOrientation { get => default; set {} } // 0x000000018BECEAF0-0x000000018BECEB1C 0x000000018BECF828-0x000000018BECF83C
		public float cullingBoxFalloffThreshold { get => default; set {} } // 0x000000018BECEA08-0x000000018BECEA3C 0x000000018BECF748-0x000000018BECF78C
		public float length { get => default; set {} } // 0x000000018BECEE44-0x000000018BECEE78 0x000000018BECFBB4-0x000000018BECFBF8
		public float intensity { get => default; set {} } // 0x000000018502B000-0x000000018502B040 0x000000018502B040-0x000000018502B090
		public float specularIntensity { get => default; set {} } // 0x000000018502B170-0x000000018502B1B0 0x000000018502B1B0-0x000000018502B200
		public float softSourceRadius { get => default; set {} } // 0x000000018502B330-0x000000018502B370 0x000000018BED0204-0x000000018BED0248
		public float bounceIntensity { get => default; set {} } // 0x000000018BECE864-0x000000018BECE898 0x000000018BECF570-0x000000018BECF5B4
		public bool useBoundingSphereOverride { get => default; set {} } // 0x000000018BECF3E0-0x000000018BECF414 0x000000018BED02CC-0x000000018BED0310
		public Vector4 boundingSphereOverride { get => default; set {} } // 0x000000018BECE8DC-0x000000018BECE908 0x000000018BECF5F8-0x000000018BECF60C
		public bool useViewFrustumForShadowCasterCull { get => default; set {} } // 0x000000018BECF4E4-0x000000018BECF518 0x000000018BED0420-0x000000018BED0464
		public int shadowCustomResolution { get => default; set {} } // 0x000000018BECF0C0-0x000000018BECF0F4 0x000000018BECFED0-0x000000018BECFF10
		public float shadowBias { get => default; set {} } // 0x000000018BECF024-0x000000018BECF058 0x000000018BECFE08-0x000000018BECFE4C
		public float shadowNormalBias { get => default; set {} } // 0x000000018BECF240-0x000000018BECF274 0x000000018BED0078-0x000000018BED00BC
		public float shadowNearPlane { get => default; set {} } // 0x000000018BECF20C-0x000000018BECF240 0x000000018BED0034-0x000000018BED0078
		public bool useShadowMatrixOverride { get => default; set {} } // 0x000000018BECF4B0-0x000000018BECF4E4 0x000000018BED03DC-0x000000018BED0420
		public Matrix4x4 shadowMatrixOverride { get => default; set {} } // 0x000000018BECF1D4-0x000000018BECF20C 0x000000018BED0020-0x000000018BED0034
		public float shadowFarPlane { get => default; set {} } // 0x000000018BECF128-0x000000018BECF15C 0x000000018BECFF54-0x000000018BECFF98
		public float shadowCullDistance { get => default; set {} } // 0x000000018BECF08C-0x000000018BECF0C0 0x000000018BECFE8C-0x000000018BECFED0
		public float shadowFadeRatio { get => default; set {} } // 0x000000018BECF0F4-0x000000018BECF128 0x000000018BECFF10-0x000000018BECFF54
		public float shadowGuardAngle { get => default; set {} } // 0x000000018BECF15C-0x000000018BECF190 0x000000018BECFF98-0x000000018BECFFDC
		public int pointLightShadowCasterFaces { get => default; set {} } // 0x000000018BECEF54-0x000000018BECEF88 0x000000018BECFD04-0x000000018BECFD44
		public int shadowCasterProperties { get => default; set {} } // 0x000000018BECF058-0x000000018BECF08C 0x000000018BECFE4C-0x000000018BECFE8C
		public bool isRuntimeShadowBaked { get => default; set {} } // 0x000000018BECEDA8-0x000000018BECEDDC 0x000000018BECFAE8-0x000000018BECFB2C
		public int lightPriority { get => default; set {} } // 0x000000018BECEE78-0x000000018BECEEAC 0x000000018BECFBF8-0x000000018BECFC38
		public float range { get => default; set {} } // 0x000000018BECEF88-0x000000018BECEFBC 0x000000018BECFD44-0x000000018BECFD88
		public Flare flare { get => default; set {} } // 0x000000018BECECF8-0x000000018BECED2C 0x000000018BECFA28-0x000000018BECFA6C
		public LightBakingOutput bakingOutput { get => default; set {} } // 0x000000018BECE834-0x000000018BECE864 0x000000018BECF55C-0x000000018BECF570
		public int cullingMask { get => default; set {} } // 0x000000018BECEBC0-0x000000018BECEBF4 0x000000018BECF8D8-0x000000018BECF918
		public int renderingLayerMask { get => default; set {} } // 0x000000018BECEFF0-0x000000018BECF024 0x000000018BECFDC8-0x000000018BECFE08
		public LightShadowCasterMode lightShadowCasterMode { get => default; set {} } // 0x000000018BECEEAC-0x000000018BECEEE0 0x000000018BECFC38-0x000000018BECFC78
		public bool useCullingDistance { get => default; set {} } // 0x000000018BECF448-0x000000018BECF47C 0x000000018BED0354-0x000000018BED0398
		public float cullingDistance { get => default; set {} } // 0x000000018BECEB8C-0x000000018BECEBC0 0x000000018BECF894-0x000000018BECF8D8
		public float falloffDistance { get => default; set {} } // 0x000000018BECEC90-0x000000018BECECC4 0x000000018BECF9A0-0x000000018BECF9E4
		public bool useFarDistanceShow { get => default; set {} } // 0x000000018BECF47C-0x000000018BECF4B0 0x000000018BED0398-0x000000018BED03DC
		public float farDistanceShowDistance { get => default; set {} } // 0x000000018BECECC4-0x000000018BECECF8 0x000000018BECF9E4-0x000000018BECFA28
		public ulong entityID { get => default; } // 0x000000018BECEC5C-0x000000018BECEC90 
		public bool enableLightAnimation { get => default; set {} } // 0x000000018BECEBF4-0x000000018BECEC28 0x000000018BECF918-0x000000018BECF95C
		public bool isInTransition { get => default; } // 0x000000018BECED74-0x000000018BECEDA8 
		public int lightStateEntryIdx { get => default; set {} } // 0x000000018BECEEE0-0x000000018BECEF14 0x000000018BECFC78-0x000000018BECFCB8
		public LightShadows shadows { get => default; set {} } // 0x000000018BECF310-0x000000018BECF344 0x000000018BED0184-0x000000018BED01C4
		public float shadowStrength { get => default; set {} } // 0x000000018BECF2DC-0x000000018BECF310 0x000000018BED0140-0x000000018BED0184
		public LightShadowResolution shadowResolution { get => default; set {} } // 0x000000018BECF2A8-0x000000018BECF2DC 0x000000018BED0100-0x000000018BED0140
		public float shadowSoftness { get => default; set {} } // 0x0000000185FE6C40-0x0000000185FE6C50 0x0000000185492010-0x0000000185492020
		public float shadowSoftnessFade { get => default; set {} } // 0x0000000185FE67A0-0x0000000185FE67B0 0x0000000185492010-0x0000000185492020
		public float[] layerShadowCullDistances { get => default; set {} } // 0x000000018BECEE10-0x000000018BECEE44 0x000000018BECFB70-0x000000018BECFBB4
		public float cookieSize { get => default; set {} } // 0x000000018BECE9A0-0x000000018BECE9D4 0x000000018BECF6C0-0x000000018BECF704
		public Texture cookie { get => default; set {} } // 0x000000018BECE9D4-0x000000018BECEA08 0x000000018BECF704-0x000000018BECF748
		public LightRenderMode renderMode { get => default; set {} } // 0x000000018BECEFBC-0x000000018BECEFF0 0x000000018BECFD88-0x000000018BECFDC8
		public int bakedIndex { get => default; set {} } // 0x0000000185FC9940-0x0000000185FC9950 0x00000001813AE9C0-0x00000001813AE9D0
		public int commandBufferCount { get => default; } // 0x000000018BECE96C-0x000000018BECE9A0 
		public static int pixelLightCount { get => default; set {} } // 0x000000018BECEF48-0x000000018BECEF54 0x000000018BECFCFC-0x000000018BECFD04
		public bool isDynamicShadowCaster { get => default; set {} } // 0x000000018BECED60-0x000000018BECED74 0x000000018BECFAB0-0x000000018BECFAE8
		public bool castStaticObjects { get => default; set {} } // 0x000000018BECE920-0x000000018BECE938 0x000000018BECF644-0x000000018BECF67C
		public bool castDynamicObjects { get => default; set {} } // 0x000000018BECE908-0x000000018BECE920 0x000000018BECF60C-0x000000018BECF644
		public float shadowConstantBias { get => default; set {} } // 0x0000000185FE6C30-0x0000000185FE6C40 0x0000000185492010-0x0000000185492020
		public float shadowObjectSizeBias { get => default; set {} } // 0x0000000185FE6C30-0x0000000185FE6C40 0x0000000185492010-0x0000000185492020
		public bool attenuate { get => default; set {} } // 0x0000000185FC71B0-0x0000000185FC71C0 0x0000000185492010-0x0000000185492020
		public HGLightAdditionalData lightAdditionalData { set {} } // 0x0000000186472FCC-0x0000000186472FE0
	
		// Constructors
		public Light() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void ResetLightAnimation() {} // 0x000000018BECE5B8-0x000000018BECE5EC
		public void UpdateAdditionalMeshRendererBindData() {} // 0x000000018BECE7BC-0x000000018BECE7F0
		public void SetLightCurState(uint stateIdx) {} // 0x000000018BECE620-0x000000018BECE660
		public void CopyLightToState(uint stateIdx) {} // 0x000000018BECE348-0x000000018BECE388
		public void AddLightStateTransitionPreset(LightStateTransition preset) {} // 0x000000018BECE334-0x000000018BECE348
		public void TransitionLightStateTo(string dstStateTagName, string transitionTagName) {} // 0x000000018BECE768-0x000000018BECE7BC
		public void Reset() {} // 0x000000018BECE5EC-0x000000018BECE620
		internal void SetPlatformSpecificLightBakeTypeInternal(IntPtr value) {} // 0x000000018BECE660-0x000000018BECE6A4
		internal IntPtr GetPlatformSpecificLightBakeTypeInternal() => default; // 0x000000018BECE408-0x000000018BECE43C
		public void SetPlatformSpecificLightBakeType(PlatformSpecificParam<LightmapBakeType> value) {} // 0x000000018BECE6A4-0x000000018BECE6C0
		public PlatformSpecificParam<LightmapBakeType> GetPlatformSpecificLightBakeType() => default; // 0x000000018BECE43C-0x000000018BECE450
		internal void SetPlatformSpecificShadowTypeInternal(IntPtr value) {} // 0x000000018BECE6C0-0x000000018BECE704
		internal IntPtr GetPlatformSpecificShadowTypeInternal() => default; // 0x000000018BECE450-0x000000018BECE484
		public void SetPlatformSpecificShadowType(PlatformSpecificParam<int> value) {} // 0x000000018BECE704-0x000000018BECE720
		public PlatformSpecificParam<int> GetPlatformSpecificShadowType() => default; // 0x000000018BECE484-0x000000018BECE498
		public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) {} // 0x000000018BECE2D0-0x000000018BECE2F0
		public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) {} // 0x000000018BECE270-0x000000018BECE2D0
		public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ComputeQueueType queueType) {} // 0x000000018BECE1EC-0x000000018BECE210
		public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType) {} // 0x000000018BECE210-0x000000018BECE270
		public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) {} // 0x000000018BECE528-0x000000018BECE578
		public void RemoveCommandBuffers(LightEvent evt) {} // 0x000000018BECE578-0x000000018BECE5B8
		public void RemoveAllCommandBuffers() {} // 0x000000018BECE4F4-0x000000018BECE528
		public CommandBuffer[] GetCommandBuffers(LightEvent evt) => default; // 0x000000018BECE388-0x000000018BECE3C8
		public static Light[] GetLights(LightType type, int layer) => default; // 0x000000018BECE3C8-0x000000018BECE408
		public static Light GetSunSourceLight() => default; // 0x000000018451A810-0x000000018451A850
		public void SetPointLightShadowCasterFace(CubemapFace face, bool enabled) {} // 0x000000018BECE720-0x000000018BECE768
		public bool GetPointLightShadowCasterFace(CubemapFace face) => default; // 0x000000018BECE498-0x000000018BECE4CC
		public bool IsPointLightHasExactlyOneCaster() => default; // 0x000000018BECE4CC-0x000000018BECE4F4
		private void get_color_Injected(out UnityEngine.Color ret) {
			ret = default;
		} // 0x0000000184F0F980-0x0000000184F0F9D0
		private void set_color_Injected(ref UnityEngine.Color value) {} // 0x0000000184F0F9D0-0x0000000184F0FA20
		private void get_cullingBoxRelativePosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BECEB1C-0x000000018BECEB60
		private void set_cullingBoxRelativePosition_Injected(ref Vector3 value) {} // 0x000000018BECF83C-0x000000018BECF880
		private void get_cullingBoxHalfExtents_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BECEA3C-0x000000018BECEA80
		private void set_cullingBoxHalfExtents_Injected(ref Vector3 value) {} // 0x000000018BECF78C-0x000000018BECF7D0
		private void get_cullingBoxOrientation_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BECEAAC-0x000000018BECEAF0
		private void set_cullingBoxOrientation_Injected(ref Vector3 value) {} // 0x000000018BECF7E4-0x000000018BECF828
		private void get_boundingSphereOverride_Injected(out Vector4 ret) {
			ret = default;
		} // 0x000000018BECE898-0x000000018BECE8DC
		private void set_boundingSphereOverride_Injected(ref Vector4 value) {} // 0x000000018BECF5B4-0x000000018BECF5F8
		private void get_shadowMatrixOverride_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BECF190-0x000000018BECF1D4
		private void set_shadowMatrixOverride_Injected(ref Matrix4x4 value) {} // 0x000000018BECFFDC-0x000000018BED0020
		private void get_bakingOutput_Injected(out LightBakingOutput ret) {
			ret = default;
		} // 0x000000018BECE7F0-0x000000018BECE834
		private void set_bakingOutput_Injected(ref LightBakingOutput value) {} // 0x000000018BECF518-0x000000018BECF55C
		private void AddLightStateTransitionPreset_Injected(ref LightStateTransition preset) {} // 0x000000018BECE2F0-0x000000018BECE334
		private void set_lightAdditionalData_Injected(ref HGLightAdditionalData value) {} // 0x0000000185623AB0-0x0000000185623B00
	}

	public sealed class MeshFilter : Component // TypeDefIndex: 47411
	{
		// Properties
		public Mesh sharedMesh { get => default; set {} } // 0x000000018416FFD0-0x0000000184170010 0x0000000183FE0C20-0x0000000183FE0C70
	
		// Constructors
		public MeshFilter() {} // Dummy constructor
	
		// Methods
		private void DontStripMeshFilter() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum RenderingPath // TypeDefIndex: 47412
	{
		UsePlayerSettings = -1,
		VertexLit = 0,
		Forward = 1,
		DeferredLighting = 2,
		DeferredShading = 3
	}

	public enum TransparencySortMode // TypeDefIndex: 47413
	{
		Default = 0,
		Perspective = 1,
		Orthographic = 2,
		CustomAxis = 3
	}

	public enum StereoTargetEyeMask // TypeDefIndex: 47414
	{
		None = 0,
		Left = 1,
		Right = 2,
		Both = 3
	}

	public enum CameraType // TypeDefIndex: 47415
	{
		Game = 1,
		SceneView = 2,
		Preview = 4,
		VR = 8,
		Reflection = 16,
		Shadow = 32,
		VTPage = 64,
		RayTracing = 128,
		Unknown = 256
	}

	public enum ComputeBufferType // TypeDefIndex: 47416
	{
		Default = 0,
		Raw = 1,
		Append = 2,
		Counter = 4,
		Constant = 8,
		Structured = 16,
		DrawIndirect = 256,
		IndirectArguments = 256,
		GPUMemory = 512
	}

	public enum LightType // TypeDefIndex: 47417
	{
		Spot = 0,
		Directional = 1,
		Point = 2,
		Area = 3,
		Rectangle = 3,
		Disc = 4
	}

	public enum LightShape // TypeDefIndex: 47418
	{
		Cone = 0,
		Pyramid = 1,
		Box = 2
	}

	public enum LightRenderMode // TypeDefIndex: 47419
	{
		Auto = 0,
		ForcePixel = 1,
		ForceVertex = 2
	}

	public enum LightShadows // TypeDefIndex: 47420
	{
		None = 0,
		Hard = 1,
		Soft = 2
	}

	public enum LightmapBakeType // TypeDefIndex: 47421
	{
		Mixed = 1,
		Baked = 2,
		Realtime = 4
	}

	public enum MixedLightingMode // TypeDefIndex: 47422
	{
		IndirectOnly = 0,
		Subtractive = 1,
		Shadowmask = 2
	}

	public enum QualityLevel // TypeDefIndex: 47423
	{
		Fastest = 0,
		Fast = 1,
		Simple = 2,
		Good = 3,
		Beautiful = 4,
		Fantastic = 5
	}

	public enum ShadowProjection // TypeDefIndex: 47424
	{
		CloseFit = 0,
		StableFit = 1
	}

	public enum ShadowQuality // TypeDefIndex: 47425
	{
		Disable = 0,
		HardOnly = 1,
		All = 2
	}

	public enum ShadowResolution // TypeDefIndex: 47426
	{
		Low = 0,
		Medium = 1,
		High = 2,
		VeryHigh = 3
	}

	public enum ShadowmaskMode // TypeDefIndex: 47427
	{
		Shadowmask = 0,
		DistanceShadowmask = 1
	}

	public enum ShadowObjectsFilter // TypeDefIndex: 47428
	{
		AllObjects = 0,
		DynamicOnly = 1,
		StaticOnly = 2
	}

	public enum CameraClearFlags // TypeDefIndex: 47429
	{
		Skybox = 1,
		Color = 2,
		SolidColor = 2,
		Depth = 3,
		Nothing = 4
	}

	public enum DepthTextureMode // TypeDefIndex: 47430
	{
		None = 0,
		Depth = 1,
		DepthNormals = 2,
		MotionVectors = 4
	}

	public enum AnisotropicFiltering // TypeDefIndex: 47431
	{
		Disable = 0,
		Enable = 1,
		ForceEnable = 2
	}

	public enum BlendWeights // TypeDefIndex: 47432
	{
		OneBone = 1,
		TwoBones = 2,
		FourBones = 4
	}

	public enum SkinWeights // TypeDefIndex: 47433
	{
		OneBone = 1,
		TwoBones = 2,
		FourBones = 4,
		Unlimited = 255
	}

	public enum MeshTopology // TypeDefIndex: 47434
	{
		Triangles = 0,
		Quads = 2,
		Lines = 3,
		LineStrip = 4,
		Points = 5
	}

	public enum SkinQuality // TypeDefIndex: 47435
	{
		Auto = 0,
		Bone1 = 1,
		Bone2 = 2,
		Bone4 = 4
	}

	public enum ColorSpace // TypeDefIndex: 47436
	{
		Uninitialized = -1,
		Gamma = 0,
		Linear = 1
	}

	public enum ColorGamut // TypeDefIndex: 47437
	{
		sRGB = 0,
		Rec709 = 1,
		Rec2020 = 2,
		DisplayP3 = 3,
		HDR10 = 4,
		DolbyHDR = 5
	}

	public enum ScreenOrientation // TypeDefIndex: 47438
	{
		Unknown = 0,
		Portrait = 1,
		PortraitUpsideDown = 2,
		Landscape = 3,
		LandscapeLeft = 3,
		LandscapeRight = 4,
		AutoRotation = 5
	}

	public enum FilterMode // TypeDefIndex: 47439
	{
		Point = 0,
		Bilinear = 1,
		Trilinear = 2
	}

	public enum TextureWrapMode // TypeDefIndex: 47440
	{
		Repeat = 0,
		Clamp = 1,
		Mirror = 2,
		MirrorOnce = 3
	}

	public enum TextureFormat // TypeDefIndex: 47441
	{
		Alpha8 = 1,
		ARGB4444 = 2,
		RGB24 = 3,
		RGBA32 = 4,
		ARGB32 = 5,
		RGB565 = 7,
		R16 = 9,
		DXT1 = 10,
		DXT5 = 12,
		RGBA4444 = 13,
		BGRA32 = 14,
		RHalf = 15,
		RGHalf = 16,
		RGBAHalf = 17,
		RFloat = 18,
		RGFloat = 19,
		RGBAFloat = 20,
		YUY2 = 21,
		RGB9e5Float = 22,
		BC6H = 24,
		BC7 = 25,
		BC4 = 26,
		BC5 = 27,
		DXT1Crunched = 28,
		DXT5Crunched = 29,
		PVRTC_RGB2 = 30,
		PVRTC_RGBA2 = 31,
		PVRTC_RGB4 = 32,
		PVRTC_RGBA4 = 33,
		ETC_RGB4 = 34,
		EAC_R = 41,
		EAC_R_SIGNED = 42,
		EAC_RG = 43,
		EAC_RG_SIGNED = 44,
		ETC2_RGB = 45,
		ETC2_RGBA1 = 46,
		ETC2_RGBA8 = 47,
		ASTC_4x4 = 48,
		ASTC_RGB_4x4 = 48,
		ASTC_5x5 = 49,
		ASTC_RGB_5x5 = 49,
		ASTC_6x6 = 50,
		ASTC_RGB_6x6 = 50,
		ASTC_8x8 = 51,
		ASTC_RGB_8x8 = 51,
		ASTC_10x10 = 52,
		ASTC_RGB_10x10 = 52,
		ASTC_12x12 = 53,
		ASTC_RGB_12x12 = 53,
		ASTC_RGBA_4x4 = 54,
		ASTC_RGBA_5x5 = 55,
		ASTC_RGBA_6x6 = 56,
		ASTC_RGBA_8x8 = 57,
		ASTC_RGBA_10x10 = 58,
		ASTC_RGBA_12x12 = 59,
		ETC_RGB4_3DS = 60,
		ETC_RGBA8_3DS = 61,
		RG16 = 62,
		R8 = 63,
		ETC_RGB4Crunched = 64,
		ETC2_RGBA8Crunched = 65,
		ASTC_HDR_4x4 = 66,
		ASTC_HDR_5x5 = 67,
		ASTC_HDR_6x6 = 68,
		ASTC_HDR_8x8 = 69,
		ASTC_HDR_10x10 = 70,
		ASTC_HDR_12x12 = 71,
		RG32 = 72,
		RGB48 = 73,
		RGBA64 = 74
	}

	internal enum TextureColorSpace // TypeDefIndex: 47442
	{
		Linear = 0,
		sRGB = 1
	}

	public enum CubemapFace // TypeDefIndex: 47443
	{
		Unknown = -1,
		PositiveX = 0,
		NegativeX = 1,
		PositiveY = 2,
		NegativeY = 3,
		PositiveZ = 4,
		NegativeZ = 5
	}

	public enum RenderTextureFormat // TypeDefIndex: 47444
	{
		ARGB32 = 0,
		Depth = 1,
		ARGBHalf = 2,
		Shadowmap = 3,
		RGB565 = 4,
		ARGB4444 = 5,
		ARGB1555 = 6,
		Default = 7,
		ARGB2101010 = 8,
		DefaultHDR = 9,
		ARGB64 = 10,
		ARGBFloat = 11,
		RGFloat = 12,
		RGHalf = 13,
		RFloat = 14,
		RHalf = 15,
		R8 = 16,
		ARGBInt = 17,
		RGInt = 18,
		RInt = 19,
		BGRA32 = 20,
		RGB111110Float = 22,
		RG32 = 23,
		RGBAUShort = 24,
		RG16 = 25,
		BGRA10101010_XR = 26,
		BGR101010_XR = 27,
		R16 = 28
	}

	public enum VRTextureUsage // TypeDefIndex: 47445
	{
		None = 0,
		OneEye = 1,
		TwoEyes = 2,
		DeviceSpecific = 3
	}

	public enum RenderTextureCreationFlags // TypeDefIndex: 47446
	{
		MipMap = 1,
		AutoGenerateMips = 2,
		SRGB = 4,
		EyeTexture = 8,
		EnableRandomWrite = 16,
		CreatedFromScript = 32,
		AllowVerticalFlip = 128,
		NoResolvedColorSurface = 256,
		DynamicallyScalable = 1024,
		BindMS = 2048
	}

	public enum RenderTextureReadWrite // TypeDefIndex: 47447
	{
		Default = 0,
		Linear = 1,
		sRGB = 2
	}

	public enum RenderTextureMemoryless // TypeDefIndex: 47448
	{
		None = 0,
		Color = 1,
		Depth = 2,
		MSAA = 4
	}

	public enum HDRDisplaySupportFlags // TypeDefIndex: 47449
	{
		None = 0,
		Supported = 1,
		RuntimeSwitchable = 2,
		AutomaticTonemapping = 4
	}

	public enum LightmapsMode // TypeDefIndex: 47450
	{
		NonDirectional = 0,
		CombinedDirectional = 1
	}

	public enum MaterialGlobalIlluminationFlags // TypeDefIndex: 47451
	{
		None = 0,
		RealtimeEmissive = 1,
		BakedEmissive = 2,
		AnyEmissive = 3,
		EmissiveIsBlack = 4
	}

	public sealed class LightProbeProxyVolume : UnityEngine.Behaviour // TypeDefIndex: 47452
	{
		// Constructors
		public LightProbeProxyVolume() {} // Dummy constructor
	}

	public enum MotionVectorGenerationMode // TypeDefIndex: 47453
	{
		Camera = 0,
		Object = 1,
		ForceNoMotion = 2
	}

	public enum LineTextureMode // TypeDefIndex: 47454
	{
		Stretch = 0,
		Tile = 1,
		DistributePerSegment = 2,
		RepeatPerSegment = 3
	}

	public enum LineAlignment // TypeDefIndex: 47455
	{
		View = 0,
		Local = 1,
		TransformZ = 1
	}

	public enum PipelineCacheLoadResult // TypeDefIndex: 47456
	{
		Unknown = 0,
		Success = 1,
		FailureFileIOError = 2,
		FailureInvalidCacheData = 3
	}

	public sealed class HGTextureGroupSettings : UnityEngine.Object // TypeDefIndex: 47457
	{
		// Constructors
		public HGTextureGroupSettings() {} // Dummy constructor
	
		// Methods
		public static void SetSkippedMipsAt(int textureGroupIndex, int skippedMips) {} // 0x000000018BECCD00-0x000000018BECCD40
	}

	public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 47458
	{
		// Properties
		public SkinQuality quality { get => default; set {} } // 0x000000018BEDAA5C-0x000000018BEDAA90 0x000000018BEDAC1C-0x000000018BEDAC5C
		public bool updateWhenOffscreen { get => default; set {} } // 0x000000018BEDAB2C-0x000000018BEDAB60 0x0000000185281920-0x0000000185281970
		public bool forceMatrixRecalculationPerRender { get => default; set {} } // 0x000000018BEDAA28-0x000000018BEDAA5C 0x000000018BEDABD8-0x000000018BEDAC1C
		public Transform rootBone { get => default; set {} } // 0x000000018BEDAA90-0x000000018BEDAAC4 0x0000000184267D10-0x0000000184267D60
		public Transform skinningRoot { get => default; set {} } // 0x000000018BEDAAF8-0x000000018BEDAB2C 0x0000000184267CC0-0x0000000184267D10
		public Transform[] bones { get => default; set {} } // 0x000000018BEDA9F4-0x000000018BEDAA28 0x000000018BEDAB94-0x000000018BEDABD8
		public Mesh sharedMesh { get => default; set {} } // 0x0000000184876090-0x00000001848760D0 0x0000000185281970-0x00000001852819C0
		public bool skinnedMotionVectors { get => default; set {} } // 0x000000018BEDAAC4-0x000000018BEDAAF8 0x000000018BEDAC5C-0x000000018BEDACA0
		public GraphicsBuffer.Target vertexBufferTarget { get => default; set {} } // 0x000000018BEDAB60-0x000000018BEDAB94 0x000000018BEDACA0-0x000000018BEDACE0
	
		// Constructors
		public SkinnedMeshRenderer() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public float GetBlendShapeWeight(int index) => default; // 0x000000018BEDA744-0x000000018BEDA784
		public void SetBlendShapeWeight(int index, float value) {} // 0x000000018BEDA970-0x000000018BEDA9C0
		public void BakeMesh(Mesh mesh) {} // 0x000000018BEDA6E4-0x000000018BEDA6F0
		public void BakeMesh(Mesh mesh, bool useScale) {} // 0x000000018BEDA6F0-0x000000018BEDA744
		public GraphicsBuffer GetVertexBuffer() => default; // 0x000000018BEDA884-0x000000018BEDA91C
		public GraphicsBuffer GetPreviousVertexBuffer() => default; // 0x000000018BEDA7B8-0x000000018BEDA850
		private GraphicsBuffer GetVertexBufferImpl() => default; // 0x000000018BEDA850-0x000000018BEDA884
		private GraphicsBuffer GetPreviousVertexBufferImpl() => default; // 0x000000018BEDA784-0x000000018BEDA7B8
		public unsafe bool RequestCurrentFrameSkinMatrices(void* ptr, int size) => default; // 0x000000018BEDA91C-0x000000018BEDA970
		public bool SkinMatricesRequestFinished() => default; // 0x000000018BEDA9C0-0x000000018BEDA9F4
	}

	public class MeshRenderer : Renderer // TypeDefIndex: 47459
	{
		// Properties
		public int subMeshStartIndex { get => default; } // 0x000000018BED3B5C-0x000000018BED3B90 
	
		// Constructors
		public MeshRenderer() {} // Dummy constructor
	
		// Methods
		private void DontStripMeshRenderer() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum HGLightNPRType // TypeDefIndex: 47460
	{
		Default = 0,
		Ramped = 1,
		SpecularOnly = 2,
		RimOnly = 3,
		FogFade = 4,
		IgnoreCharacter = 16
	}

	public struct HGLightAdditionalData // TypeDefIndex: 47461
	{
		// Fields
		public Vector4 lightNPRData; // 0x00
		public HGLightNPRType lightNPRType; // 0x10
		public bool LightCharacterOnly; // 0x14
		public float volumetricScatteringIntensity; // 0x18
		public float falloffExponent; // 0x1C
	}

	public struct HGSharedLightData : IEquatable<HGSharedLightData> // TypeDefIndex: 47462
	{
		// Fields
		private uint m_Padding1; // 0x00
		private uint m_Padding2; // 0x04
	
		// Properties
		public LightType type { get => default; } // 0x000000018BECCBEC-0x000000018BECCBF4 
		public UnityEngine.Color color { get => default; } // 0x000000018BECC26C-0x000000018BECC298 
		public float spotAngle { get => default; } // 0x000000018BECCBB0-0x000000018BECCBB8 
		public float innerSpotAngle { get => default; } // 0x000000018BECC5FC-0x000000018BECC604 
		public bool shadowOnly { get => default; } // 0x000000018BECCA84-0x000000018BECCA8C 
		public bool enableOBBCullingBox { get => default; } // 0x000000018BECC4D0-0x000000018BECC4D8 
		public Vector3 cullingBoxRelativePosition { get => default; } // 0x000000018BECC434-0x000000018BECC460 
		public Vector3 cullingBoxHalfExtents { get => default; } // 0x000000018BECC354-0x000000018BECC380 
		public Vector3 cullingBoxOrientation { get => default; } // 0x000000018BECC3C4-0x000000018BECC3F0 
		public float cullingBoxFalloffThreshold { get => default; } // 0x000000018BECC308-0x000000018BECC310 
		public float length { get => default; } // 0x000000018BECC700-0x000000018BECC708 
		public float intensity { get => default; } // 0x000000018BECC638-0x000000018BECC640 
		public float specularIntensity { get => default; } // 0x000000018BECCB74-0x000000018BECCB7C 
		public float shadowBias { get => default; } // 0x000000018BECC8A4-0x000000018BECC8AC 
		public float shadowNormalBias { get => default; } // 0x000000018BECCA48-0x000000018BECCA50 
		public float shadowNearPlane { get => default; } // 0x000000018BECCA0C-0x000000018BECCA14 
		public float range { get => default; } // 0x000000018BECC868-0x000000018BECC870 
		public float softSourceRadius { get => default; } // 0x000000018BECCB38-0x000000018BECCB40 
		public int instanceID { get => default; } // 0x000000018646E540-0x000000018646E548 
		public LightShadows shadows { get => default; } // 0x000000018BECCAFC-0x000000018BECCB04 
		public float shadowStrength { get => default; } // 0x000000018BECCAC0-0x000000018BECCAC8 
		public Matrix4x4 localToWorldMatrix { get => default; } // 0x000000018BECC7C0-0x000000018BECC7F8 
		public float shadowFarPlane { get => default; } // 0x000000018BECC994-0x000000018BECC99C 
		public float shadowCullDistance { get => default; } // 0x000000018BECC91C-0x000000018BECC924 
		public float shadowFadeRatio { get => default; } // 0x000000018BECC958-0x000000018BECC960 
		public float shadowGuardAngle { get => default; } // 0x000000018BECC9D0-0x000000018BECC9D8 
		public int pointLightShadowCasterFaces { get => default; } // 0x000000018BECC82C-0x000000018BECC834 
		public int shadowCasterProperties { get => default; } // 0x000000018BECC8E0-0x000000018BECC8E8 
		public bool useCullingDistance { get => default; } // 0x000000018BECCC28-0x000000018BECCC30 
		public float cullingDistance { get => default; } // 0x000000018BECC494-0x000000018BECC49C 
		public float falloffDistance { get => default; } // 0x000000018BECC584-0x000000018BECC58C 
		public bool useFarDistanceShow { get => default; } // 0x0000000183F865C0-0x0000000183F86610 
		public float farDistanceShowDistance { get => default; } // 0x0000000183F86520-0x0000000183F86570 
		public float farDistanceShowFalloffDistance { get => default; } // 0x0000000183F86570-0x0000000183F865C0 
		public Light light { get => default; } // 0x0000000184294B20-0x0000000184294BE0 
		public uint entityIndex { get => default; } // 0x000000018BECC50C-0x000000018BECC514 
		public uint entityVersion { get => default; } // 0x000000018BECC548-0x000000018BECC550 
		public bool isVaild { get => default; } // 0x000000018BECC6C4-0x000000018BECC6CC 
		public Vector3 worldPosition { get => default; } // 0x000000018BECCC74-0x000000018BECCCA0 
		public HGLightAdditionalData lightAdditionalData { get => default; set {} } // 0x000000018BECC74C-0x000000018BECC77C 0x000000018BECCCEC-0x000000018BECCD00
		public bool isRuntimeShadowBaked { get => default; set {} } // 0x000000018BECC688-0x000000018BECC690 0x000000018BECCCE4-0x000000018BECCCEC
		public bool isDynamicShadowCaster { get => default; } // 0x000000018BECC640-0x000000018BECC654 
		public bool castStaticObjects { get => default; } // 0x000000018BECC210-0x000000018BECC228 
		public bool castDynamicObjects { get => default; } // 0x000000018BECC1F8-0x000000018BECC210 
		public Texture cookie { get => default; } // 0x000000018BECC2CC-0x000000018BECC2D4 
		public float flickerScale { get => default; } // 0x000000018BECC5C0-0x000000018BECC5C8 
	
		// Constructors
		public HGSharedLightData(uint entityIdx, uint entityVersion) : this() {
			m_Padding1 = default;
			m_Padding2 = default;
		} // 0x000000018357CB90-0x000000018357CBA0
	
		// Methods
		public bool Equals(HGSharedLightData rhs) => default; // 0x000000018BECBFC0-0x000000018BECC018
		public override bool Equals(object obj) => default; // 0x000000018BECC018-0x000000018BECC088
		public override int GetHashCode() => default; // 0x000000018BECC16C-0x000000018BECC19C
		public bool GetPointLightShadowCasterFace(CubemapFace face) => default; // 0x000000018BECC19C-0x000000018BECC1D0
		public bool IsPointLightHasExactlyOneCaster() => default; // 0x000000018BECC1D0-0x000000018BECC1F8
		public string GetDebugName() => default; // 0x000000018BECC088-0x000000018BECC16C
		private static LightType get_type_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECCBB8-0x000000018BECCBEC
		private static void get_color_Injected(ref HGSharedLightData _unity_self, out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BECC228-0x000000018BECC26C
		private static float get_spotAngle_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECCB7C-0x000000018BECCBB0
		private static float get_innerSpotAngle_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC5C8-0x000000018BECC5FC
		private static bool get_shadowOnly_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECCA50-0x000000018BECCA84
		private static bool get_enableOBBCullingBox_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC49C-0x000000018BECC4D0
		private static void get_cullingBoxRelativePosition_Injected(ref HGSharedLightData _unity_self, out Vector3 ret) {
			ret = default;
		} // 0x000000018BECC3F0-0x000000018BECC434
		private static void get_cullingBoxHalfExtents_Injected(ref HGSharedLightData _unity_self, out Vector3 ret) {
			ret = default;
		} // 0x000000018BECC310-0x000000018BECC354
		private static void get_cullingBoxOrientation_Injected(ref HGSharedLightData _unity_self, out Vector3 ret) {
			ret = default;
		} // 0x000000018BECC380-0x000000018BECC3C4
		private static float get_cullingBoxFalloffThreshold_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC2D4-0x000000018BECC308
		private static float get_length_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC6CC-0x000000018BECC700
		private static float get_intensity_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC604-0x000000018BECC638
		private static float get_specularIntensity_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECCB40-0x000000018BECCB74
		private static float get_shadowBias_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC870-0x000000018BECC8A4
		private static float get_shadowNormalBias_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECCA14-0x000000018BECCA48
		private static float get_shadowNearPlane_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC9D8-0x000000018BECCA0C
		private static float get_range_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC834-0x000000018BECC868
		private static float get_softSourceRadius_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECCB04-0x000000018BECCB38
		private static int get_instanceID_Injected(ref HGSharedLightData _unity_self) => default; // 0x0000000184E8FCA0-0x0000000184E8FCE0
		private static LightShadows get_shadows_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECCAC8-0x000000018BECCAFC
		private static float get_shadowStrength_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECCA8C-0x000000018BECCAC0
		private static void get_localToWorldMatrix_Injected(ref HGSharedLightData _unity_self, out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BECC77C-0x000000018BECC7C0
		private static float get_shadowFarPlane_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC960-0x000000018BECC994
		private static float get_shadowCullDistance_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC8E8-0x000000018BECC91C
		private static float get_shadowFadeRatio_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC924-0x000000018BECC958
		private static float get_shadowGuardAngle_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC99C-0x000000018BECC9D0
		private static int get_pointLightShadowCasterFaces_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC7F8-0x000000018BECC82C
		private static int get_shadowCasterProperties_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC8AC-0x000000018BECC8E0
		private static bool get_useCullingDistance_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECCBF4-0x000000018BECCC28
		private static float get_cullingDistance_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC460-0x000000018BECC494
		private static float get_falloffDistance_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC550-0x000000018BECC584
		private static bool get_useFarDistanceShow_Injected(ref HGSharedLightData _unity_self) => default; // 0x0000000183F865C0-0x0000000183F86610
		private static float get_farDistanceShowDistance_Injected(ref HGSharedLightData _unity_self) => default; // 0x0000000183F86520-0x0000000183F86570
		private static float get_farDistanceShowFalloffDistance_Injected(ref HGSharedLightData _unity_self) => default; // 0x0000000183F86570-0x0000000183F865C0
		private static uint get_entityIndex_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC4D8-0x000000018BECC50C
		private static uint get_entityVersion_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC514-0x000000018BECC548
		private static bool get_isVaild_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC690-0x000000018BECC6C4
		private static void get_worldPosition_Injected(ref HGSharedLightData _unity_self, out Vector3 ret) {
			ret = default;
		} // 0x000000018BECCC30-0x000000018BECCC74
		private static void get_lightAdditionalData_Injected(ref HGSharedLightData _unity_self, out HGLightAdditionalData ret) {
			ret = default;
		} // 0x000000018BECC708-0x000000018BECC74C
		private static void set_lightAdditionalData_Injected(ref HGSharedLightData _unity_self, ref HGLightAdditionalData value) {} // 0x0000000184F3FB00-0x0000000184F3FD70
		private static bool get_isRuntimeShadowBaked_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC654-0x000000018BECC688
		private static void set_isRuntimeShadowBaked_Injected(ref HGSharedLightData _unity_self, bool value) {} // 0x000000018BECCCA0-0x000000018BECCCE4
		private static Texture get_cookie_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC298-0x000000018BECC2CC
		private static float get_flickerScale_Injected(ref HGSharedLightData _unity_self) => default; // 0x000000018BECC58C-0x000000018BECC5C0
	}

	public enum LightStateIntensityTransition // TypeDefIndex: 47463
	{
		FadeToBlack = 0,
		IntensityBlend = 1
	}

	public class LightFlickerStyle : UnityEngine.Object // TypeDefIndex: 47464
	{
		// Constructors
		public LightFlickerStyle() {} // 0x000000018BECD1BC-0x000000018BECD208
	
		// Methods
		private static void Internal_Create(LightFlickerStyle self) {} // 0x000000018BECD188-0x000000018BECD1BC
	}

	public struct LightFlickerData // TypeDefIndex: 47465
	{
		// Fields
		private float flickeringSpeed; // 0x00
		private float flickerTimeDelay; // 0x04
		private bool randomDelay; // 0x08
		private bool enableFlicker; // 0x09
	}

	public struct LightSpinData // TypeDefIndex: 47466
	{
		// Fields
		private Vector3 spinAxis; // 0x00
		private Vector3 spinAnchor; // 0x0C
		private float spinSpeed; // 0x18
		private float spinTimeDelay; // 0x1C
		private bool randomDelay; // 0x20
		private bool enableSpin; // 0x21
	}

	public struct LightAnimatedData // TypeDefIndex: 47467
	{
		// Fields
		private LightFlickerData flickerData; // 0x00
		private LightSpinData spinData; // 0x0C
	}

	public struct LightStateTransitionData // TypeDefIndex: 47468
	{
		// Fields
		public LightStateIntensityTransition IntensityTransition; // 0x00
		public LightAnimatedData AnimatedData; // 0x04
	}

	public class LightStateTransitionPreset : UnityEngine.Object // TypeDefIndex: 47469
	{
		// Fields
		private LightStateTransitionData _transitionData_k__BackingField; // 0x18
	
		// Properties
		public LightStateTransitionData transitionData { get; set; } // 0x0000000185FE6BE0-0x0000000185FE6C10 0x0000000185FE6C10-0x0000000185FE6C30
	
		// Constructors
		public LightStateTransitionPreset() {} // 0x000000018BECE1A0-0x000000018BECE1EC
	
		// Methods
		private static void Internal_Create(LightStateTransitionPreset self) {} // 0x000000018BECE16C-0x000000018BECE1A0
	}

	public struct LightStateTransition // TypeDefIndex: 47470
	{
		// Fields
		public string tagName; // 0x00
		public LightStateTransitionPreset transitionPreset; // 0x08
	}

	public sealed class LightProbeGroup : UnityEngine.Behaviour // TypeDefIndex: 47471
	{
		// Properties
		public Vector3[] probePositions { get => default; } // 0x0000000185FE67B0-0x0000000185FE67C0 
	
		// Constructors
		public LightProbeGroup() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public enum LODFadeMode // TypeDefIndex: 47472
	{
		None = 0,
		CrossFade = 1,
		SpeedTree = 2,
		Disabled = 3
	}

	public struct LOD // TypeDefIndex: 47473
	{
		// Fields
		public float screenRelativeTransitionHeight; // 0x00
		public float fadeTransitionWidth; // 0x04
		public Renderer[] renderers; // 0x08
	
		// Constructors
		public LOD(float screenRelativeTransitionHeight, Renderer[] renderers) {
			this.screenRelativeTransitionHeight = default;
			fadeTransitionWidth = default;
			this.renderers = default;
		} // 0x000000018BECD170-0x000000018BECD188
	}

	public class LODGroup : Component // TypeDefIndex: 47474
	{
		// Properties
		public float size { get => default; set {} } // 0x0000000184124730-0x0000000184124770 0x00000001848C2080-0x00000001848C20D0
		public int lodCount { get => default; } // 0x000000018BECD13C-0x000000018BECD170 
		public LODFadeMode fadeMode { get => default; set {} } // 0x0000000184A97D70-0x0000000184A97DB0 0x0000000184A97DB0-0x0000000184A97E00
		public bool animateCrossFading { get => default; set {} } // 0x000000018BECD108-0x000000018BECD13C 0x00000001856D8290-0x00000001856D82E0
	
		// Constructors
		public LODGroup() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void RecalculateBounds() {} // 0x000000018574F190-0x000000018574F3D0
		public LOD[] GetLODs(bool getPlatformLODs = false /* Metadata: 0x0206056D */) => default; // 0x0000000184A97170-0x0000000184A971C0
		public void SetLODs(LOD[] lods) {} // 0x000000018452F020-0x000000018452F070
		public void ForceLOD(int index) {} // 0x000000018BECD0C8-0x000000018BECD108
		public bool CalculateLOD(Camera camera, out int lodIndex, out float fadeValue) {
			lodIndex = default;
			fadeValue = default;
			return default;
		} // 0x0000000184CE8890-0x0000000184CE8900
	}

	public sealed class Mesh : UnityEngine.Object // TypeDefIndex: 47477
	{
		// Properties
		public IndexFormat indexFormat { get => default; set {} } // 0x000000018BED3FB8-0x000000018BED4008 0x000000018BED3F58-0x000000018BED3FB8
		public GraphicsBuffer.Target vertexBufferTarget { get => default; set {} } // 0x0000000183F99AB0-0x0000000183F99AF0 0x000000018BED6218-0x000000018BED624C
		public int blendShapeCount { get => default; } // 0x0000000183F99CD0-0x0000000183F99D10 
		public Matrix4x4[] bindposes { get => default; set {} } // 0x000000018BED5614-0x000000018BED5914 
		public bool isReadable { get => default; }
		internal bool canAccess { get => default; }
		public int vertexCount { get => default; }
		public int subMeshCount { get => default; set {} } // 0x00000001849729D0-0x0000000184972A10
		public Bounds bounds { get => default; set {} } // 0x0000000184970810-0x00000001849708F0 0x000000018BED5F58-0x000000018BED5F98
		public Vector3[] vertices { get => default; set {} } // 0x000000018BED5D4C-0x000000018BED5D8C 0x000000018BED5E04-0x000000018BED5E20
		public Vector3[] normals { get => default; set {} } // 0x000000018BED5D8C-0x000000018BED5E04 
		public Vector4[] tangents { get => default; set {} }
		public Vector2[] uv { get => default; set {} } // 0x000000018BED457C-0x000000018BED4650 0x0000000183F97D90-0x0000000183F97F00
		public Vector2[] uv2 { get => default; set {} } // 0x000000018646D284-0x000000018646D2A0 0x0000000184C21000-0x0000000184C21120
		public Vector2[] uv3 { get => default; } // 0x000000018BED5540-0x000000018BED5580 
		public Vector2[] uv4 { get => default; } // 0x000000018BED5580-0x000000018BED559C 
		public Vector2[] uv5 { get => default; } // 0x000000018BED559C-0x000000018BED5614 
		public Vector2[] uv6 { get => default; }
		public Vector2[] uv7 { get => default; }
		public Vector2[] uv8 { get => default; }
		public UnityEngine.Color[] colors { get => default; set {} } // 0x000000018BED4650-0x000000018BED4738 0x0000000183F97C20-0x0000000183F97D90
		public Color32[] colors32 { get => default; set {} } // 0x000000018646D268-0x000000018646D284 0x0000000184D0A200-0x0000000184D0A320
		public int vertexAttributeCount { get => default; } // 0x0000000183F97F00-0x0000000183F98100 
		public int[] triangles { get => default; set {} } // 0x000000018BED52D0-0x000000018BED53BC 0x000000018BED4104-0x000000018BED41F8
		public BoneWeight[] boneWeights { get => default; set {} } // 0x000000018BED3860-0x000000018BED3898 0x000000018BED3B50-0x000000018BED3B5C
	
		// Nested types
		public struct MeshData // TypeDefIndex: 47475
		{
			// Fields
			internal IntPtr m_Ptr; // 0x00
	
			// Properties
			public int vertexCount { get => default; } // 0x000000018BED4C0C-0x000000018BED4C3C 
			public int subMeshCount { get => default; } // 0x000000018BED4E8C-0x000000018BED4ECC 
	
			// Methods
			private static bool HasVertexAttribute(IntPtr self, VertexAttribute attr) => default; // 0x0000000185FC7990-0x0000000185FC79A0
			private static int GetVertexCount(IntPtr self) => default; // 0x00000001842454D0-0x0000000184245510
			private static void CopyAttributeIntoPtr(IntPtr self, VertexAttribute attr, VertexAttributeFormat format, int dim, IntPtr dst) {} // 0x0000000184245450-0x00000001842454D0
			private static void CopyIndicesIntoPtr(IntPtr self, int submesh, bool applyBaseVertex, int dstStride, IntPtr dst) {} // 0x000000018BED3CC4-0x000000018BED3CF8
			private static int GetIndexCount(IntPtr self, int submesh) => default; // 0x000000018BED5EF0-0x000000018BED5F24
			private static int GetSubMeshCount(IntPtr self) => default; // 0x000000018BED62F0-0x000000018BED6330
			private static SubMeshDescriptor GetSubMesh(IntPtr self, int index) => default; // 0x000000018BED4B88-0x000000018BED4BBC
			public bool HasVertexAttribute(VertexAttribute attr) => default; // 0x000000018BED43D8-0x000000018BED4418
			public void GetVertices(NativeArray<Vector3> outVertices) {} // 0x000000018BED4808-0x000000018BED4848
			public void GetNormals(NativeArray<Vector3> outNormals) {} // 0x000000018BED3E4C-0x000000018BED3E8C
			public void GetTangents(NativeArray<Vector4> outTangents) {} // 0x0000000184972A70-0x0000000184972AD0
			public void GetUVs(int channel, NativeArray<Vector2> outUVs) {} // 0x000000018BED44A4-0x000000018BED44F8
			private void CopyAttributeInto<T>(NativeArray<T> buffer, VertexAttribute channel, VertexAttributeFormat format, int dim)
				where T : struct {} // 0x0000000183F97940-0x0000000183F979C0
			public void GetIndices(NativeArray<int> outIndices, int submesh, bool applyBaseVertex = true /* Metadata: 0x0206057E */) {} // 0x000000018BED4848-0x000000018BED48AC
			public SubMeshDescriptor GetSubMesh(int index) => default; // 0x0000000185BA8DC0-0x0000000185BA8E10
			private static void GetSubMesh_Injected(IntPtr self, int index, out SubMeshDescriptor ret) {
				ret = default;
			} // 0x0000000183F99AF0-0x0000000183F99B60
		}
	
		public struct MeshDataArray : IDisposable // TypeDefIndex: 47476
		{
			// Fields
			private unsafe IntPtr* m_Ptrs; // 0x00
			internal int m_Length; // 0x08
	
			// Properties
			public int Length { get => default; } // 0x000000018BED3DEC-0x000000018BED3E4C 
			public MeshData this[int index] { get => default; } // 0x000000018BED4C3C-0x000000018BED4C7C 
	
			// Constructors
			internal unsafe MeshDataArray(Mesh mesh, bool checkReadWrite = true /* Metadata: 0x0206057F */) : this() {
				m_Ptrs = default;
				m_Length = default;
			} // 0x000000018BED6370-0x000000018BED63B0
	
			// Methods
			private static unsafe void AcquireReadOnlyMeshData(Mesh mesh, IntPtr* datas) {} // 0x000000018BED54E0-0x000000018BED5540
			private static unsafe void ReleaseMeshDatas(IntPtr* datas, int count) {} // 0x0000000185BA8D50-0x0000000185BA8DC0
			public void Dispose() {} // 0x000000018BED61E4-0x000000018BED6218
		}
	
		// Constructors
		public Mesh() {} // 0x000000018BED4008-0x000000018BED404C
	
		// Methods
		public IntPtr HGGetPtrUnchecked() => default; // 0x00000001848760D0-0x0000000184876110
		private static void Internal_Create(Mesh mono) {} // 0x000000018BED404C-0x000000018BED408C
		public static Mesh FromInstanceID(int id) => default; // 0x000000018BED3F18-0x000000018BED3F58
		private int GetVertexAttributeCountImpl() => default; // 0x000000018BED3BC8-0x000000018BED3C2C
		public VertexAttributeDescriptor GetVertexAttribute(int index) => default; // 0x000000018BED4DF4-0x000000018BED4E28
		private uint GetIndexCountImpl(int submesh) => default; // 0x000000018BED408C-0x000000018BED40C0
		private uint GetTrianglesCountImpl(int submesh) => default; // 0x000000018BED4F44-0x000000018BED4F88
		private uint GetBaseVertexImpl(int submesh) => default; // 0x000000018BED4F88-0x000000018BED4FF8
		private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) => default; // 0x000000018BED4E28-0x000000018BED4E8C
		private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) => default; // 0x000000018BED3D60-0x000000018BED3DEC
		private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) {} // 0x000000018BED4260-0x000000018BED42FC
		private void GetTrianglesNonAllocImpl(out int[] values, int submesh, bool applyBaseVertex) {
			values = default;
		} // 0x000000018BED3CF8-0x000000018BED3D2C
		private void PrintErrorCantAccessChannel(VertexAttribute ch) {} // 0x000000018BED3D2C-0x000000018BED3D60
		public bool HasVertexAttribute(VertexAttribute attr) => default; // 0x000000018BED41F8-0x000000018BED422C
		private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) {} // 0x000000018BED422C-0x000000018BED4260
		private void SetNativeArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) {} // 0x000000018BED5E20-0x000000018BED5E54
		private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) => default; // 0x000000018BED624C-0x000000018BED6290
		private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) {} // 0x000000018BED40C0-0x000000018BED4104
		private GraphicsBuffer GetVertexBufferImpl(int index) => default; // 0x000000018BED5F24-0x000000018BED5F58
		public string GetBlendShapeName(int shapeIndex) => default; // 0x000000018BED6330-0x000000018BED6370
		public int GetBlendShapeIndex(string blendShapeName) => default; // 0x0000000184135210-0x0000000184135270
		public int GetBlendShapeFrameCount(int shapeIndex) => default; // 0x000000018646D588-0x000000018646D59C
		public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex) => default; // 0x0000000184E6C080-0x0000000184E6C0D0
		public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) {} // 0x0000000183F99BB0-0x0000000183F99C00
		public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) {} // 0x0000000185A83330-0x0000000185A83380
		private bool HasBoneWeights() => default; // 0x0000000185BCABA0-0x0000000185BCABF0
		private BoneWeight[] GetBoneWeightsImpl() => default; // 0x000000018514E0F0-0x000000018514E130
		private void SetBoneWeightsImpl(BoneWeight[] weights) {} // 0x000000018496FAC0-0x000000018496FB10
		public void SetBoneWeights(NativeArray<byte> bonesPerVertex, NativeArray<BoneWeight1> weights) {} // 0x000000018BED4738-0x000000018BED4778
		private void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize) {} // 0x000000018BED3C44-0x000000018BED3CA8
		public NativeArray<BoneWeight1> GetAllBoneWeights() => default; // 0x0000000185C4DD20-0x0000000185C4DD60
		public NativeArray<byte> GetBonesPerVertex() => default; // 0x000000018484AE50-0x000000018484AE70
		private int GetAllBoneWeightsArraySize() => default; // 0x0000000183F99B60-0x0000000183F99BB0
		private IntPtr GetAllBoneWeightsArray() => default;
		private IntPtr GetBonesPerVertexArray() => default;
		public int GetBonesPerVertexValue() => default; // 0x0000000183F99950-0x0000000183F99AB0
		private void GetBoneWeightsNonAllocImpl(out BoneWeight[] values) {
			values = default;
		}
		private void ClearImpl(bool keepVertexLayout) {} // 0x00000001849707B0-0x0000000184970810
		private void RecalculateBoundsImpl(MeshUpdateFlags flags) {} // 0x000000018BED5F98-0x000000018BED5FD8
		private void RecalculateNormalsImpl(MeshUpdateFlags flags) {} // 0x00000001849708F0-0x0000000184970950
		private void RecalculateTangentsImpl(MeshUpdateFlags flags) {} // 0x000000018BED6198-0x000000018BED61D8
		private void MarkDynamicImpl() {} // 0x000000018496E910-0x000000018496EA00
		private void UploadMeshDataImpl(bool markNoLongerReadable) {} // 0x000000018BED5FD8-0x000000018BED6018
		private MeshTopology GetTopologyImpl(int submesh) => default; // 0x000000018496EA00-0x000000018496EAF0
		private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) {} // 0x000000018BED6018-0x000000018BED6058
		private void OptimizeImpl() {} // 0x000000018BED6058-0x000000018BED6098
		internal static VertexAttribute GetUVChannel(int uvIndex) => default; // 0x000000018BED6098-0x000000018BED60D8
		internal static int DefaultDimensionForChannel(VertexAttribute channel) => default; // 0x000000018BED60D8-0x000000018BED6118
		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) => default; // 0x000000018BED6118-0x000000018BED6158
		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) => default; // 0x000000018BED6158-0x000000018BED6198
		private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) {} // 0x000000018BED5EB0-0x000000018BED5EF0
		private void SetSizedNativeArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) {} // 0x000000018BED6298-0x000000018BED62F0
		private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = MeshUpdateFlags.Default /* Metadata: 0x0206056E */) {} // 0x000000018BED5E60-0x000000018BED5EB0
		private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = MeshUpdateFlags.Default /* Metadata: 0x0206056F */) {} // 0x0000000185171EF0-0x0000000185171F70
		private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) {} // 0x000000018BED4D20-0x000000018BED4DF4
		private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) {} // 0x0000000183F984D0-0x0000000183F98640
		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim) {} // 0x000000018646D2C4-0x000000018646D2E0
		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) {} // 0x0000000184C21120-0x0000000184C21230
		public void GetVertices(List<Vector3> vertices) {}
		public void SetVertices(List<Vector3> inVertices) {}
		public void SetVertices(List<Vector3> inVertices, int start, int length) {}
		public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) {} // 0x000000018BED5090-0x000000018BED50F0
		public void SetVertices(Vector3[] inVertices) {} // 0x000000018BED4FF8-0x000000018BED5014
		public void SetVertices(Vector3[] inVertices, int start, int length) {} // 0x000000018BED5014-0x000000018BED5090
		public void SetVertices(Vector3[] inVertices, int start, int length, MeshUpdateFlags flags) {} // 0x000000018BED42FC-0x000000018BED43D8
		public void SetVertices<T>(NativeArray<T> inVertices)
			where T : struct {} // 0x0000000183F98240-0x0000000183F983B0
		public void SetVertices<T>(NativeArray<T> inVertices, int start, int length)
			where T : struct {} // 0x000000018646D2E0-0x000000018646D2FC
		public void SetVertices<T>(NativeArray<T> inVertices, int start, int length, MeshUpdateFlags flags)
			where T : struct {} // 0x0000000184CFD6B0-0x0000000184CFD7D0
		public void GetNormals(List<Vector3> normals) {}
		public void SetNormals(List<Vector3> inNormals) {} // 0x000000018496F920-0x000000018496F9A0
		public void SetNormals(List<Vector3> inNormals, int start, int length) {} // 0x0000000183F995F0-0x0000000183F997E0
		public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) {} // 0x0000000186470F1C-0x0000000186470F40
		public void SetNormals(Vector3[] inNormals) {} // 0x0000000185556390-0x00000001855564B0
		public void SetNormals(Vector3[] inNormals, int start, int length) {} // 0x000000018646D2A0-0x000000018646D2C4
		public void SetNormals(Vector3[] inNormals, int start, int length, MeshUpdateFlags flags) {} // 0x000000018484AE70-0x000000018484B060
		public void SetNormals<T>(NativeArray<T> inNormals)
			where T : struct {} // 0x000000018BED5C30-0x000000018BED5D4C
		public void SetNormals<T>(NativeArray<T> inNormals, int start, int length)
			where T : struct {} // 0x000000018BED5AE4-0x000000018BED5B34
		public void SetNormals<T>(NativeArray<T> inNormals, int start, int length, MeshUpdateFlags flags)
			where T : struct {} // 0x000000018BED5B34-0x000000018BED5B84
		public void GetTangents(List<Vector4> tangents) {} // 0x000000018BED5BA8-0x000000018BED5BF8
		public void SetTangents(List<Vector4> inTangents) {} // 0x000000018BED5AC0-0x000000018BED5AE4
		public void SetTangents(List<Vector4> inTangents, int start, int length) {} // 0x000000018BED5A88-0x000000018BED5AC0
		public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) {} // 0x000000018BED5A2C-0x000000018BED5A50
		public void SetTangents<T>(NativeArray<T> inTangents)
			where T : struct {} // 0x000000018BED5BF8-0x000000018BED5C30
		public void SetTangents<T>(NativeArray<T> inTangents, int start, int length)
			where T : struct {} // 0x000000018BED5B84-0x000000018BED5BA8
		public void SetTangents<T>(NativeArray<T> inTangents, int start, int length, MeshUpdateFlags flags)
			where T : struct {} // 0x000000018BED5A50-0x000000018BED5A88
		public void SetColors(List<UnityEngine.Color> inColors) {}
		public void SetColors(List<UnityEngine.Color> inColors, int start, int length) {} // 0x000000018BED4B24-0x000000018BED4B88
		public void SetColors(List<UnityEngine.Color> inColors, int start, int length, MeshUpdateFlags flags) {} // 0x000000018BED4AC0-0x000000018BED4B24
		public void GetColors(List<Color32> colors) {} // 0x000000018BED61D8-0x000000018BED61E4
		public void SetColors(List<Color32> inColors) {} // 0x000000018BED3B90-0x000000018BED3BC8
		public void SetColors(List<Color32> inColors, int start, int length) {} // 0x000000018BED4C7C-0x000000018BED4D20
		public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) {} // 0x000000018BED4ECC-0x000000018BED4F38
		private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) {} // 0x0000000183F99C00-0x0000000183F99CD0
		public void SetUVs(int channel, List<Vector2> uvs) {} // 0x000000018646D314-0x000000018646D324
		public void SetUVs(int channel, List<Vector4> uvs) {} // 0x000000018BED3C2C-0x000000018BED3C3C
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length) {} // 0x0000000184972A10-0x0000000184972A70
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length, MeshUpdateFlags flags) {} // 0x0000000184970950-0x0000000184970A10
		public void SetUVs(int channel, List<Vector4> uvs, int start, int length) {} // 0x000000018BED48AC-0x000000018BED48BC
		public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) {} // 0x000000018BED4A4C-0x000000018BED4AC0
		private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags) {} // 0x000000018BED4A30-0x000000018BED4A4C
		public void SetUVs(int channel, Vector2[] uvs) {} // 0x000000018BED48BC-0x000000018BED4A30
		public void SetUVs(int channel, Vector3[] uvs) {} // 0x000000018BED44F8-0x000000018BED4508
		public void SetUVs(int channel, Vector4[] uvs) {} // 0x000000018BED4508-0x000000018BED457C
		public void SetUVs(int channel, Vector2[] uvs, int start, int length) {} // 0x000000018BED4418-0x000000018BED44A4
		public void SetUVs(int channel, Vector2[] uvs, int start, int length, MeshUpdateFlags flags) {} // 0x000000018BED3E8C-0x000000018BED3F18
		public void SetUVs(int channel, Vector3[] uvs, int start, int length) {} // 0x0000000183F978F0-0x0000000183F97940
		public void SetUVs(int channel, Vector3[] uvs, int start, int length, MeshUpdateFlags flags) {} // 0x0000000183F97820-0x0000000183F978F0
		public void SetUVs(int channel, Vector4[] uvs, int start, int length) {} // 0x000000018BED597C-0x000000018BED5998
		public void SetUVs(int channel, Vector4[] uvs, int start, int length, MeshUpdateFlags flags) {} // 0x000000018BED5914-0x000000018BED597C
		private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim) {} // 0x000000018BED5998-0x000000018BED5A2C
		public void GetUVs(int channel, List<Vector3> uvs) {} // 0x000000018646D324-0x000000018646D340
		public void GetUVs(int channel, List<Vector4> uvs) {} // 0x0000000183F979C0-0x0000000183F97C20
		public static MeshDataArray AcquireReadOnlyMeshData(Mesh mesh) => default; // 0x000000018BED5218-0x000000018BED5238
		public GraphicsBuffer GetVertexBuffer(int index) => default; // 0x000000018BED53BC-0x000000018BED5434
		private void PrintErrorCantAccessIndices() {} // 0x000000018BED5168-0x000000018BED5218
		private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) => default; // 0x000000018BED50F0-0x000000018BED5168
		private bool CheckCanAccessSubmeshTriangles(int submesh) => default; // 0x000000018BED5434-0x000000018BED54E0
		private bool CheckCanAccessSubmeshIndices(int submesh) => default; // 0x000000018BED5238-0x000000018BED52D0
		public int[] GetTriangles(int submesh) => default; // 0x000000018BED5E54-0x000000018BED5E60
		public int[] GetTriangles(int submesh, bool applyBaseVertex) => default; // 0x000000018BED6290-0x000000018BED6298
		public void GetTriangles(List<int> triangles, int submesh) {} // 0x000000018BED3C3C-0x000000018BED3C44
		public void GetTriangles(List<int> triangles, int submesh, bool applyBaseVertex) {} // 0x000000018646D308-0x000000018646D314
		public int[] GetIndices(int submesh) => default; // 0x000000018646D2FC-0x000000018646D308
		public int[] GetIndices(int submesh, bool applyBaseVertex) => default; // 0x0000000186471040-0x000000018647104C
		public uint GetIndexCount(int submesh) => default; // 0x000000018BED4F38-0x000000018BED4F44
		public uint GetBaseVertex(int submesh) => default; // 0x0000000183F98640-0x0000000183F986E0
		private void CheckIndicesArrayRange(int valuesLength, int start, int length) {} // 0x0000000185A832C0-0x0000000185A83330
		private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) {} // 0x0000000185BCAB30-0x0000000185BCABA0
		public void SetTriangles(int[] triangles, int submesh) {} // 0x000000018514E090-0x000000018514E0F0
		public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) {} // 0x000000018496FA80-0x000000018496FAC0
		public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true /* Metadata: 0x02060570 */, int baseVertex = 0 /* Metadata: 0x02060571 */) {} // 0x0000000185C4DCC0-0x0000000185C4DD20
		public void SetTriangles(List<int> triangles, int submesh) {} // 0x000000018BED4778-0x000000018BED4808
		public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) {} // 0x000000018BED3CA8-0x000000018BED3CC4
		public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true /* Metadata: 0x02060572 */, int baseVertex = 0 /* Metadata: 0x02060573 */) {} // 0x000000018BED4BBC-0x000000018BED4C0C
		public void SetIndices(int[] indices, MeshTopology topology, int submesh) {} // 0x0000000184135270-0x00000001841352C0
		public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) {} // 0x000000018518B2F0-0x000000018518B340
		public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true /* Metadata: 0x02060574 */, int baseVertex = 0 /* Metadata: 0x02060575 */) {} // 0x000000018BED3AF4-0x000000018BED3B34
		public void SetIndices(ushort[] indices, MeshTopology topology, int submesh, bool calculateBounds = true /* Metadata: 0x02060576 */, int baseVertex = 0 /* Metadata: 0x02060577 */) {} // 0x000000018BED3A58-0x000000018BED3A8C
		public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true /* Metadata: 0x02060578 */, int baseVertex = 0 /* Metadata: 0x02060579 */) {} // 0x000000018BED3474-0x000000018BED34D4
		public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = true /* Metadata: 0x0206057A */, int baseVertex = 0 /* Metadata: 0x0206057B */) {} // 0x000000018BED34D4-0x000000018BED3534
		public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true /* Metadata: 0x0206057C */, int baseVertex = 0 /* Metadata: 0x0206057D */) {} // 0x000000018BED3534-0x000000018BED3574
		public void GetBoneWeights(List<BoneWeight> boneWeights) {} // 0x000000018BED37DC-0x000000018BED3810
		public void Clear(bool keepVertexLayout) {} // 0x000000018BED3B34-0x000000018BED3B44
		public void Clear() {} // 0x000000018BED3A8C-0x000000018BED3AF4
		public void RecalculateBounds() {} // 0x000000018BED3774-0x000000018BED37DC
		public void RecalculateNormals() {} // 0x000000018BED38E0-0x000000018BED3948
		public void RecalculateTangents() {} // 0x000000018BED3948-0x000000018BED3A58
		public void RecalculateBounds(MeshUpdateFlags flags) {}
		public void RecalculateNormals(MeshUpdateFlags flags) {} // 0x000000018BED3574-0x000000018BED3774
		public void RecalculateTangents(MeshUpdateFlags flags) {} // 0x000000018BED3B44-0x000000018BED3B50
		public void MarkDynamic() {} // 0x000000018BED3898-0x000000018BED38E0
		public void UploadMeshData(bool markNoLongerReadable) {} // 0x000000018BED3810-0x000000018BED3860
		public void Optimize() {} // 0x000000018BED31E8-0x000000018BED322C
		public MeshTopology GetTopology(int submesh) => default; // 0x000000018BED3268-0x000000018BED32A8
		public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) {} // 0x0000000181B7E450-0x0000000181B7E460
		private void GetVertexAttribute_Injected(int index, out VertexAttributeDescriptor ret) {
			ret = default;
		} // 0x0000000185FE6C50-0x0000000185FE6C60
		private void get_bounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x000000018BED322C-0x000000018BED3268
		private void set_bounds_Injected(ref Bounds value) {} // 0x000000018BED32A8-0x000000018BED3474
	}

	[Serializable]
	public struct BoneWeight : IEquatable<BoneWeight> // TypeDefIndex: 47478
	{
		// Fields
		private float m_Weight0; // 0x00
		private float m_Weight1; // 0x04
		private float m_Weight2; // 0x08
		private float m_Weight3; // 0x0C
		private int m_BoneIndex0; // 0x10
		private int m_BoneIndex1; // 0x14
		private int m_BoneIndex2; // 0x18
		private int m_BoneIndex3; // 0x1C
	
		// Properties
		public float weight0 { get => default; set {} } // 0x0000000185FE6770-0x0000000185FE6780 0x0000000185FBA160-0x0000000185FBA170
		public float weight1 { get => default; set {} } // 0x0000000185FE64E0-0x0000000185FE64F0 0x0000000185FBA180-0x0000000185FBA190
		public float weight2 { get => default; set {} } // 0x0000000185FE64D0-0x0000000185FE64E0 0x0000000185FBA170-0x0000000185FBA180
		public float weight3 { get => default; set {} } // 0x0000000185FE66F0-0x0000000185FE6700 0x0000000185FBF770-0x0000000185FBF780
		public int boneIndex0 { get => default; set {} } // 0x0000000185FE6790-0x0000000185FE67A0 0x0000000181378230-0x0000000181378240
		public int boneIndex1 { get => default; set {} } // 0x0000000185FB1090-0x0000000185FB10A0 0x0000000185FBB0B0-0x0000000185FBB0C0
		public int boneIndex2 { get => default; set {} } // 0x0000000185FC9940-0x0000000185FC9950 0x00000001813AE9C0-0x00000001813AE9D0
		public int boneIndex3 { get => default; set {} } // 0x0000000185FC79A0-0x0000000185FC79B0 0x00000001813AE9D0-0x00000001813AE9E0
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018BECA08C-0x000000018BECA15C
		public override bool Equals(object other) => default; // 0x000000018BECA00C-0x000000018BECA08C
		public bool Equals(BoneWeight other) => default; // 0x000000018BEC9FB8-0x000000018BECA00C
	}

	[Serializable]
	public struct BoneWeight1 : IEquatable<BoneWeight1> // TypeDefIndex: 47479
	{
		// Fields
		private float m_Weight; // 0x00
		private int m_BoneIndex; // 0x04
	
		// Properties
		public float weight { get => default; set {} } // 0x0000000185FE6770-0x0000000185FE6780 0x0000000185FBA160-0x0000000185FBA170
		public int boneIndex { get => default; set {} } // 0x0000000185FCA560-0x0000000185FCA570 0x0000000185FB2BA0-0x0000000185FB2BB0
	
		// Methods
		public override bool Equals(object other) => default; // 0x000000018BEC9F20-0x000000018BEC9F90
		public bool Equals(BoneWeight1 other) => default; // 0x000000018BEC9EE8-0x000000018BEC9F20
		public override int GetHashCode() => default; // 0x000000018BEC9F90-0x000000018BEC9FB8
	}

	public struct CombineInstance // TypeDefIndex: 47480
	{
		// Fields
		private int m_MeshInstanceID; // 0x00
		private int m_SubMeshIndex; // 0x04
		private Matrix4x4 m_Transform; // 0x08
		private Vector4 m_LightmapScaleOffset; // 0x48
		private Vector4 m_RealtimeLightmapScaleOffset; // 0x58
	
		// Properties
		public Mesh mesh { get => default; set {} } // 0x000000018BECA15C-0x000000018BECA168 0x000000018BECA168-0x000000018BECA1E0
		public int subMeshIndex { set {} } // 0x0000000185FB2BA0-0x0000000185FB2BB0
		public Matrix4x4 transform { set {} } // 0x0000000185FE6BA0-0x0000000185FE6BC0
	}

	public class Texture : UnityEngine.Object // TypeDefIndex: 47481
	{
		// Fields
		public static readonly int GenerateAllMips; // 0x00
	
		// Properties
		public static int masterTextureLimit { get => default; set {} } // 0x000000018BEDEF00-0x000000018BEDEF2C 0x000000018BEDF308-0x000000018BEDF33C
		public int mipmapCount { get => default; } // 0x0000000183FDB4C0-0x0000000183FDB500 
		public static AnisotropicFiltering anisotropicFiltering { get => default; set {} } // 0x000000018BEDEDE0-0x000000018BEDEE0C 0x000000018BEDF1F8-0x000000018BEDF22C
		public virtual GraphicsFormat graphicsFormat { get => default; } // 0x000000018BEDEE4C-0x000000018BEDEE98 
		public virtual int width { get => default; set {} } // 0x000000018505F4B0-0x000000018505F4F0 0x000000018BEDF3A4-0x000000018BEDF3F0
		public virtual int height { get => default; set {} } // 0x000000018505F4F0-0x000000018505F530 0x000000018BEDF2BC-0x000000018BEDF308
		public virtual TextureDimension dimension { get => default; set {} } // 0x000000018BEDEE40-0x000000018BEDEE4C 0x000000018BEDF270-0x000000018BEDF2BC
		internal bool isNativeTexture { get => default; } // 0x000000018BEDEE98-0x000000018BEDEECC 
		public virtual bool isReadable { get => default; } // 0x000000018BEDEECC-0x000000018BEDEF00 
		public TextureWrapMode wrapMode { get => default; set {} } // 0x0000000184DE0040-0x0000000184DE0080 0x0000000185C58150-0x0000000185C581A0
		public TextureWrapMode wrapModeU { get => default; set {} } // 0x000000018BEDF128-0x000000018BEDF15C 0x0000000183FDA8D0-0x0000000183FDA920
		public TextureWrapMode wrapModeV { get => default; set {} } // 0x000000018BEDF15C-0x000000018BEDF190 0x0000000183FDA920-0x0000000183FDA970
		public TextureWrapMode wrapModeW { get => default; set {} } // 0x000000018BEDF190-0x000000018BEDF1C4 0x0000000183FDA970-0x0000000183FDA9C0
		public UnityEngine.FilterMode filterMode { get => default; set {} } // 0x0000000185F9B430-0x0000000185F9B470 0x0000000183FDAA60-0x0000000183FDAAB0
		public int anisoLevel { get => default; set {} } // 0x0000000185F9B470-0x0000000185F9B4B0 0x0000000183FDA9C0-0x0000000183FDAA10
		public float mipMapBias { get => default; set {} } // 0x000000018BEDEF2C-0x000000018BEDEF60 0x0000000183FDAA10-0x0000000183FDAA60
		public Vector2 texelSize { get => default; } // 0x00000001840E06D0-0x00000001840E0720 
		public int textureGroup { get => default; } // 0x000000018BEDF0C0-0x000000018BEDF0F4 
		public bool cubicSample { get => default; set {} } // 0x000000018BEDEE0C-0x000000018BEDEE40 0x000000018BEDF22C-0x000000018BEDF270
		public uint updateCount { get => default; } // 0x000000018BEDF0F4-0x000000018BEDF128 
		internal ColorSpace activeTextureColorSpace { get => default; } // 0x000000018BEDED98-0x000000018BEDEDB4 
		public bool isDataSRGB { get => default; } // 0x0000000183FD9C00-0x0000000183FD9C20 
		public static ulong totalTextureMemory { get => default; } // 0x0000000185F8BD00-0x0000000185F8BD40 
		public static ulong desiredTextureMemory { get => default; } // 0x0000000185F8BDC0-0x0000000185F8BE00 
		public static ulong targetTextureMemory { get => default; } // 0x0000000185F8BD40-0x0000000185F8BD80 
		public static ulong currentTextureMemory { get => default; } // 0x0000000185F8BE00-0x0000000185F8BE40 
		public static ulong nonStreamingTextureMemory { get => default; } // 0x0000000185F8BD80-0x0000000185F8BDC0 
		public static ulong streamingMipmapUploadCount { get => default; } // 0x000000018BEDEF8C-0x000000018BEDEFB8 
		public static ulong streamingRendererCount { get => default; } // 0x000000018BEDEFB8-0x000000018BEDEFE4 
		public static ulong streamingTextureCount { get => default; } // 0x000000018BEDEFE4-0x000000018BEDF010 
		public static ulong nonStreamingTextureCount { get => default; } // 0x000000018BEDEF60-0x000000018BEDEF8C 
		public static ulong streamingTexturePendingLoadCount { get => default; } // 0x000000018BEDF094-0x000000018BEDF0C0 
		public static ulong streamingTextureLoadingCount { get => default; } // 0x000000018BEDF068-0x000000018BEDF094 
		public static bool streamingTextureForceLoadAll { get => default; set {} } // 0x000000018BEDF03C-0x000000018BEDF068 0x000000018BEDF370-0x000000018BEDF3A4
		public static bool streamingTextureDiscardUnusedMips { get => default; set {} } // 0x000000018BEDF010-0x000000018BEDF03C 0x000000018BEDF33C-0x000000018BEDF370
		public static bool allowThreadedTextureCreation { get => default; set {} } // 0x000000018BEDEDB4-0x000000018BEDEDE0 0x000000018BEDF1C4-0x000000018BEDF1F8
	
		// Constructors
		protected Texture() {} // 0x00000001840155F0-0x0000000184015630
		static Texture() {} // 0x0000000185FA3E20-0x0000000185FA3E60
	
		// Methods
		internal static IntPtr HGGetPtrUnchecked_Texture(int instanceID) => default; // 0x000000018BEDEBCC-0x000000018BEDEC00
		public IntPtr HGGetPtrUnchecked() => default; // 0x0000000185FC7990-0x0000000185FC79A0
		public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) {} // 0x000000018BEDEC68-0x000000018BEDECA8
		private int GetDataWidth() => default; // 0x000000018505F4B0-0x000000018505F4F0
		private int GetDataHeight() => default; // 0x000000018505F4F0-0x000000018505F530
		private TextureDimension GetDimension() => default; // 0x000000018BEDEAB8-0x000000018BEDEAEC
		public IntPtr GetNativeTexturePtr() => default; // 0x000000018BEDEAF8-0x000000018BEDEB2C
		public int GetNativeTextureID() => default; // 0x000000018BEDEAEC-0x000000018BEDEAF8
		public void IncrementUpdateCount() {} // 0x000000018BEDEC00-0x000000018BEDEC34
		private int Internal_GetActiveTextureColorSpace() => default; // 0x000000018BEDEC34-0x000000018BEDEC68
		private TextureColorSpace Internal_GetStoredColorSpace() => default; // 0x0000000183FD9C20-0x0000000183FD9C60
		public static void DumpStreamingTextureInfo() {} // 0x000000018BEDEA8C-0x000000018BEDEAB8
		public static void SetStreamingTextureMaterialDebugProperties() {} // 0x000000018BEDECA8-0x000000018BEDECD4
		internal ulong GetPixelDataSize(int mipLevel, int element = 0 /* Metadata: 0x02060580 */) => default; // 0x000000018BEDEB7C-0x000000018BEDEBCC
		internal ulong GetPixelDataOffset(int mipLevel, int element = 0 /* Metadata: 0x02060581 */) => default; // 0x000000018BEDEB2C-0x000000018BEDEB7C
		internal TextureColorSpace GetTextureColorSpace(bool linear) => default; // 0x00000001840155E0-0x00000001840155F0
		internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) => default; // 0x0000000184015580-0x00000001840155E0
		internal bool ValidateFormat(RenderTextureFormat format) => default; // 0x000000018BEDECD4-0x000000018BEDED98
		internal bool ValidateFormat(TextureFormat format) => default; // 0x0000000184016050-0x00000001840160D0
		internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) => default; // 0x0000000184015840-0x0000000184015900
		internal UnityException CreateNonReadableException(Texture t) => default; // 0x000000018BEDE9FC-0x000000018BEDEA8C
		internal UnityException CreateNativeArrayLengthOverflowException() => default; // 0x000000018BEDE998-0x000000018BEDE9FC
		private void get_texelSize_Injected(out Vector2 ret) {
			ret = default;
		} // 0x00000001840E0680-0x00000001840E06D0
	}

	public sealed class Texture2D : Texture // TypeDefIndex: 47483
	{
		// Fields
		internal const int streamingMipmapsPriorityMin = -128; // Metadata: 0x02060586
		internal const int streamingMipmapsPriorityMax = 127; // Metadata: 0x02060588
	
		// Properties
		public TextureFormat format { get => default; } // 0x0000000183FD9C60-0x0000000183FD9CA0 
		public bool ignoreMipmapLimit { get => default; set {} } // 0x000000018BEDDCE4-0x000000018BEDDD18 0x000000018BEDDF18-0x000000018BEDDF5C
		public static Texture2D whiteTexture { get => default; } // 0x0000000184A14680-0x0000000184A146C0 
		public static Texture2D blackTexture { get => default; } // 0x0000000183FDCA30-0x0000000183FDCA70 
		public static Texture2D redTexture { get => default; } // 0x0000000185F7DB30-0x0000000185F7DB70 
		public static Texture2D blueTexture { get => default; } // 0x000000018BEDDC24-0x000000018BEDDC50 
		public static Texture2D grayTexture { get => default; } // 0x000000018BEDDCB8-0x000000018BEDDCE4 
		public static Texture2D linearGrayTexture { get => default; } // 0x000000018BEDDD4C-0x000000018BEDDD78 
		public static Texture2D normalTexture { get => default; } // 0x0000000184B34F60-0x0000000184B34FA0 
		public override bool isReadable { get => default; } // 0x0000000185BC1ED0-0x0000000185BC1F10 
		public bool vtOnly { get => default; } // 0x000000018BEDDEE4-0x000000018BEDDF18 
		internal bool isPreProcessed { get => default; } // 0x000000018BEDDD18-0x000000018BEDDD4C 
		public bool streamingMipmaps { get => default; } // 0x000000018BEDDEB0-0x000000018BEDDEE4 
		public int streamingMipmapsPriority { get => default; } // 0x000000018BEDDE7C-0x000000018BEDDEB0 
		public int requestedMipmapLevel { get => default; set {} } // 0x000000018BEDDE48-0x000000018BEDDE7C 0x000000018BEDDFE0-0x000000018BEDE020
		public int minimumMipmapLevel { get => default; set {} } // 0x000000018BEDDE14-0x000000018BEDDE48 0x000000018BEDDFA0-0x000000018BEDDFE0
		internal bool loadAllMips { get => default; set {} } // 0x000000018BEDDD78-0x000000018BEDDDAC 0x000000018BEDDF5C-0x000000018BEDDFA0
		public int calculatedMipmapLevel { get => default; } // 0x000000018BEDDC50-0x000000018BEDDC84 
		public int desiredMipmapLevel { get => default; } // 0x000000018BEDDC84-0x000000018BEDDCB8 
		public int loadingMipmapLevel { get => default; } // 0x000000018BEDDDE0-0x000000018BEDDE14 
		public int loadedMipmapLevel { get => default; } // 0x000000018BEDDDAC-0x000000018BEDDDE0 
	
		// Nested types
		public enum EXRFlags // TypeDefIndex: 47482
		{
			None = 0,
			OutputAsFloat = 1,
			CompressZIP = 2,
			CompressRLE = 4,
			CompressPIZ = 8
		}
	
		// Constructors
		public Texture2D() {} // Dummy constructor
		internal Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex) {} // 0x0000000184015470-0x0000000184015580
		public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags) {} // 0x000000018BEDDB6C-0x000000018BEDDBB8
		public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags) {} // 0x00000001840153C0-0x0000000184015470
		public Texture2D(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags) {} // 0x000000018BEDDA8C-0x000000018BEDDAB8
		internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) {} // 0x000000018BEDD958-0x000000018BEDDA8C
		public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) {} // 0x000000018BEDDB40-0x000000018BEDDB6C
		public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) {} // 0x000000018BEDDBB8-0x000000018BEDDBF0
		public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) {} // 0x000000018BEDDBF0-0x000000018BEDDC24
		public Texture2D(int width, int height) {} // 0x000000018BEDDAB8-0x000000018BEDDB40
	
		// Methods
		public void Compress(bool highQuality) {} // 0x000000018BEDC34C-0x000000018BEDC390
		private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) => default; // 0x00000001840156C0-0x0000000184015730
		private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) {} // 0x0000000184015670-0x00000001840156C0
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x00000001859D9400-0x00000001859D9460
		private bool ReinitializeImpl(int width, int height) => default; // 0x000000018BEDD11C-0x000000018BEDD16C
		private void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color) {} // 0x000000018BEDD58C-0x000000018BEDD5B8
		private UnityEngine.Color GetPixelImpl(int image, int mip, int x, int y) => default; // 0x000000018BEDC988-0x000000018BEDC9D8
		private UnityEngine.Color GetPixelBilinearImpl(int image, int mip, float u, float v) => default; // 0x000000018BEDC794-0x000000018BEDC7DC
		private bool ReinitializeWithFormatImpl(int width, int height, GraphicsFormat format, bool hasMipMap) => default; // 0x000000018BEDD16C-0x000000018BEDD1CC
		private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) {} // 0x000000018BEDD038-0x000000018BEDD058
		private void SetPixelsImpl(int x, int y, int w, int h, UnityEngine.Color[] pixel, int miplevel, int frame) {} // 0x00000001857DB6D0-0x00000001857DB740
		private bool LoadRawTextureDataImpl(IntPtr data, ulong size) => default; // 0x000000018BEDCCB0-0x000000018BEDCD04
		private bool LoadRawTextureDataImplArray(byte[] data) => default; // 0x000000018BEDCC6C-0x000000018BEDCCB0
		private bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0 /* Metadata: 0x02060582 */) => default; // 0x000000018BEDD464-0x000000018BEDD4C8
		private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0 /* Metadata: 0x02060583 */) => default; // 0x000000018BEDD4C8-0x000000018BEDD52C
		private IntPtr GetWritableImageData(int frame) => default; // 0x000000018BEDCBF8-0x000000018BEDCC38
		private ulong GetRawImageDataSize() => default; // 0x000000018BEDCB90-0x000000018BEDCBC4
		private static void GenerateAtlasImpl(Vector2[] sizes, int padding, int atlasSize, out Rect[] rect) {
			rect = default;
		} // 0x000000018BEDC498-0x000000018BEDC4F8
		public void ClearRequestedMipmapLevel() {} // 0x000000018BEDC318-0x000000018BEDC34C
		public bool IsRequestedMipmapLevelLoaded() => default; // 0x000000018BEDCC38-0x000000018BEDCC6C
		public void ClearMinimumMipmapLevel() {} // 0x000000018BEDC2E4-0x000000018BEDC318
		public void UpdateExternalTexture(IntPtr nativeTex) {} // 0x000000018BEDD80C-0x000000018BEDD850
		private void SetAllPixels32(Color32[] colors, int miplevel) {} // 0x000000018BEDD3B0-0x000000018BEDD404
		private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) {} // 0x000000018BEDD404-0x000000018BEDD464
		public byte[] GetRawTextureData() => default; // 0x000000018BEDCBC4-0x000000018BEDCBF8
		public UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) => default; // 0x0000000185A95ED0-0x0000000185A95F40
		public UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) => default; // 0x000000018BEDCB60-0x000000018BEDCB84
		private void GetPixelsNonAllocImpl(UnityEngine.Color[] pixels, int x, int y, int blockWidth, int blockHeight, int miplevel) {} // 0x0000000183F87120-0x0000000183F871B0
		public void GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel, List<UnityEngine.Color> pixels) {} // 0x0000000183F871B0-0x0000000183F87940
		public void GetPixels(int x, int y, int blockWidth, int blockHeight, List<UnityEngine.Color> pixels) {} // 0x0000000183F87950-0x0000000183F87980
		public Color32[] GetPixels32(int miplevel) => default; // 0x000000018BEDCB14-0x000000018BEDCB54
		public Color32[] GetPixels32() => default; // 0x000000018BEDCB54-0x000000018BEDCB60
		private void GetPixels32NonAllocImpl(Color32[] pixels, int miplevel) {} // 0x0000000183F86670-0x0000000183F866E0
		public void GetPixels32(int miplevel, List<Color32> pixels) {} // 0x0000000183F866E0-0x0000000183F87110
		public void GetPixels32(List<Color32> pixels) {} // 0x0000000183F87110-0x0000000183F87120
		private int GetPixels32Count(int miplevel) => default; // 0x0000000183F86610-0x0000000183F86670
		public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) => default; // 0x000000018BEDCF70-0x000000018BEDCFD4
		public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize) => default; // 0x000000018BEDCF34-0x000000018BEDCF50
		public Rect[] PackTextures(Texture2D[] textures, int padding) => default; // 0x000000018BEDCF50-0x000000018BEDCF70
		internal bool ValidateFormat(TextureFormat format, int width, int height) => default; // 0x000000018BEDD850-0x000000018BEDD958
		internal bool ValidateFormat(GraphicsFormat format, int width, int height) => default; // 0x0000000184015730-0x00000001840157D0
		public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex) => default; // 0x000000018BEDC390-0x000000018BEDC498
		public void SetPixel(int x, int y, UnityEngine.Color color) {} // 0x000000018BEDD5B8-0x000000018BEDD650
		public void SetPixel(int x, int y, UnityEngine.Color color, int mipLevel) {} // 0x000000018BEDD650-0x000000018BEDD6F0
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors, int miplevel) {} // 0x00000001857DB640-0x00000001857DB6D0
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors) {} // 0x000000018BEDD740-0x000000018BEDD76C
		public void SetPixels(UnityEngine.Color[] colors, int miplevel) {} // 0x000000018BEDD76C-0x000000018BEDD80C
		public void SetPixels(UnityEngine.Color[] colors) {} // 0x00000001857DB5D0-0x00000001857DB640
		public UnityEngine.Color GetPixel(int x, int y) => default; // 0x000000018BEDC9D8-0x000000018BEDCA74
		public UnityEngine.Color GetPixel(int x, int y, int mipLevel) => default; // 0x000000018BEDCA74-0x000000018BEDCB14
		public UnityEngine.Color GetPixelBilinear(float u, float v) => default; // 0x000000018BEDC884-0x000000018BEDC928
		public UnityEngine.Color GetPixelBilinear(float u, float v, int mipLevel) => default; // 0x000000018BEDC7DC-0x000000018BEDC884
		public void LoadRawTextureData(IntPtr data, int size) {} // 0x000000018BEDCE14-0x000000018BEDCF34
		public void LoadRawTextureData(byte[] data) {} // 0x000000018BEDCD04-0x000000018BEDCE14
		public void LoadRawTextureData<T>(NativeArray<T> data)
			where T : struct {}
		public void SetPixelData<T>(T[] data, int mipLevel, int sourceDataStartIndex = 0 /* Metadata: 0x02060584 */) {}
		public void SetPixelData<T>(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0 /* Metadata: 0x02060585 */)
			where T : struct {}
		public NativeArray<T> GetPixelData<T>(int mipLevel)
			where T : struct => default;
		public NativeArray<T> GetRawTextureData<T>()
			where T : struct => default;
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x00000001859D93B0-0x00000001859D9400
		public void Apply(bool updateMipmaps) {} // 0x000000018BEDC2D8-0x000000018BEDC2E4
		public void Apply() {} // 0x000000018BEDC2C8-0x000000018BEDC2D8
		public bool Reinitialize(int width, int height) => default; // 0x000000018BEDD1CC-0x000000018BEDD23C
		public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) => default; // 0x000000018BEDD2C8-0x000000018BEDD36C
		public bool Reinitialize(int width, int height, GraphicsFormat format, bool hasMipMap) => default; // 0x000000018BEDD23C-0x000000018BEDD2C8
		public bool Resize(int width, int height) => default; // 0x000000018BEDD388-0x000000018BEDD394
		public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) => default; // 0x000000018BEDD394-0x000000018BEDD3B0
		public bool Resize(int width, int height, GraphicsFormat format, bool hasMipMap) => default; // 0x000000018BEDD36C-0x000000018BEDD388
		public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) {} // 0x000000018BEDD084-0x000000018BEDD11C
		public void ReadPixels(Rect source, int destX, int destY) {} // 0x000000018BEDD058-0x000000018BEDD084
		public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results) => default; // 0x000000018BEDC4F8-0x000000018BEDC734
		public void SetPixels32(Color32[] colors, int miplevel) {} // 0x000000018BEDD6FC-0x000000018BEDD704
		public void SetPixels32(Color32[] colors) {} // 0x000000018BEDD6F0-0x000000018BEDD6FC
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) {} // 0x000000018BEDD704-0x000000018BEDD714
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) {} // 0x000000018BEDD714-0x000000018BEDD740
		public UnityEngine.Color[] GetPixels(int miplevel) => default; // 0x0000000185A95E40-0x0000000185A95ED0
		public UnityEngine.Color[] GetPixels() => default; // 0x000000018BEDCB84-0x000000018BEDCB90
		public void GetPixels(int miplevel, List<UnityEngine.Color> pixels) {} // 0x0000000183F87980-0x0000000183F87A30
		public void GetPixels(List<UnityEngine.Color> pixels) {} // 0x0000000183F87940-0x0000000183F87950
		private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref UnityEngine.Color color) {} // 0x000000018BEDD52C-0x000000018BEDD58C
		private void GetPixelImpl_Injected(int image, int mip, int x, int y, out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BEDC928-0x000000018BEDC988
		private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BEDC734-0x000000018BEDC794
		private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) {} // 0x000000018BEDCFD4-0x000000018BEDD038
	}

	public sealed class Cubemap : Texture // TypeDefIndex: 47484
	{
		// Properties
		public override bool isReadable { get => default; } // 0x000000018BECB0E4-0x000000018BECB118 
	
		// Constructors
		public Cubemap() {} // Dummy constructor
		public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags) {} // 0x000000018BECAD80-0x000000018BECADCC
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags) {} // 0x000000018BECADCC-0x000000018BECAEA0
		public Cubemap(int width, TextureFormat format, int mipCount) {} // 0x000000018BECAF64-0x000000018BECAF80
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) {} // 0x000000018BECAEA0-0x000000018BECAF64
		internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) {} // 0x000000018BECAFAC-0x000000018BECB0C4
		internal Cubemap(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) {} // 0x000000018BECB0C4-0x000000018BECB0E4
		public Cubemap(int width, TextureFormat textureFormat, bool mipChain) {} // 0x000000018BECAF80-0x000000018BECAFAC
	
		// Methods
		private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) => default; // 0x000000018BECA8C8-0x000000018BECA928
		private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) {} // 0x000000018BECA928-0x000000018BECA9B4
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x000000018BECA7F0-0x000000018BECA848
		private void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color) {} // 0x000000018BECAA14-0x000000018BECAA40
		internal bool ValidateFormat(TextureFormat format, int width) => default; // 0x000000018BECAB1C-0x000000018BECAC04
		internal bool ValidateFormat(GraphicsFormat format, int width) => default; // 0x000000018BECAC04-0x000000018BECAD20
		public void SetPixel(CubemapFace face, int x, int y, UnityEngine.Color color) {} // 0x000000018BECAA40-0x000000018BECAA74
		public void SetPixel(CubemapFace face, int x, int y, UnityEngine.Color color, int mip) {} // 0x000000018BECAA74-0x000000018BECAB1C
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x000000018BECA858-0x000000018BECA8C8
		public void Apply() {} // 0x000000018BECA848-0x000000018BECA858
		private static void ValidateIsNotCrunched(TextureCreationFlags flags) {} // 0x000000018BECAD20-0x000000018BECAD80
		private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref UnityEngine.Color color) {} // 0x000000018BECA9B4-0x000000018BECAA14
	}

	public sealed class Texture3D : Texture // TypeDefIndex: 47485
	{
		// Properties
		public int depth { get => default; } // 0x000000018BEDE930-0x000000018BEDE964 
		public override bool isReadable { get => default; } // 0x000000018BEDE964-0x000000018BEDE998 
		public static Texture3D blackTexture3D { get => default; } // 0x0000000184406510-0x0000000184406550 
	
		// Constructors
		public Texture3D() {} // Dummy constructor
		public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) {} // 0x000000018BEDE644-0x000000018BEDE6A8
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) {} // 0x000000018BEDE5AC-0x000000018BEDE644
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) {} // 0x000000018BEDE4C4-0x000000018BEDE5AC
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount) {} // 0x000000018BEDE804-0x000000018BEDE930
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) {} // 0x000000018BEDE6D0-0x000000018BEDE804
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) {} // 0x000000018BEDE4A0-0x000000018BEDE4C4
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) {} // 0x000000018BEDE6A8-0x000000018BEDE6D0
	
		// Methods
		private void SetPixelImpl(int mip, int x, int y, int z, UnityEngine.Color color) {} // 0x000000018BEDE26C-0x000000018BEDE298
		private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) => default; // 0x000000018BEDE104-0x000000018BEDE164
		private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) {} // 0x000000018BEDE164-0x000000018BEDE20C
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x000000018BEDE020-0x000000018BEDE078
		public void SetPixels(UnityEngine.Color[] colors, int miplevel) {} // 0x000000018BEDE3E0-0x000000018BEDE434
		public void SetPixels(UnityEngine.Color[] colors) {} // 0x000000018BEDE434-0x000000018BEDE440
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x000000018BEDE094-0x000000018BEDE104
		public void Apply(bool updateMipmaps) {} // 0x000000018BEDE088-0x000000018BEDE094
		public void Apply() {} // 0x000000018BEDE078-0x000000018BEDE088
		public void SetPixel(int x, int y, int z, UnityEngine.Color color) {} // 0x000000018BEDE340-0x000000018BEDE3E0
		public void SetPixel(int x, int y, int z, UnityEngine.Color color, int mipLevel) {} // 0x000000018BEDE298-0x000000018BEDE340
		private static void ValidateIsNotCrunched(TextureCreationFlags flags) {} // 0x000000018BEDE440-0x000000018BEDE4A0
		private void SetPixelImpl_Injected(int mip, int x, int y, int z, ref UnityEngine.Color color) {} // 0x000000018BEDE20C-0x000000018BEDE26C
	}

	public sealed class Texture2DArray : Texture // TypeDefIndex: 47486
	{
		// Properties
		public static int allSlices { get => default; } // 0x000000018BEDC268-0x000000018BEDC294 
		public override bool isReadable { get => default; } // 0x000000018BEDC294-0x000000018BEDC2C8 
	
		// Constructors
		public Texture2DArray() {} // Dummy constructor
		public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) {} // 0x000000018BEDC204-0x000000018BEDC268
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) {} // 0x000000018BEDC080-0x000000018BEDC118
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) {} // 0x000000018BEDC118-0x000000018BEDC204
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) {} // 0x0000000184014D50-0x0000000184014F10
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) {} // 0x0000000184014460-0x00000001840144A0
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) {} // 0x0000000184014250-0x0000000184014290
	
		// Methods
		private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) => default; // 0x0000000184015FE0-0x0000000184016050
		private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) {} // 0x0000000184015F30-0x0000000184015F80
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x000000018BEDBE70-0x000000018BEDBEC8
		internal bool ValidateFormat(TextureFormat format, int width, int height) => default; // 0x0000000184015F80-0x0000000184015FE0
		internal bool ValidateFormat(GraphicsFormat format, int width, int height) => default; // 0x000000018BEDBF38-0x000000018BEDC080
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x000000018BEDBEC8-0x000000018BEDBF38
		private static void ValidateIsNotCrunched(TextureCreationFlags flags) {} // 0x0000000184015EC0-0x0000000184015EE0
	}

	public sealed class CubemapArray : Texture // TypeDefIndex: 47487
	{
		// Properties
		public override bool isReadable { get => default; } // 0x000000018BECA7BC-0x000000018BECA7F0 
	
		// Constructors
		public CubemapArray() {} // Dummy constructor
		public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) {} // 0x000000018BECA680-0x000000018BECA6CC
		public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) {} // 0x000000018BECA6FC-0x000000018BECA78C
		public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) {} // 0x000000018BECA484-0x000000018BECA558
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) {} // 0x000000018BECA558-0x000000018BECA680
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) {} // 0x000000018BECA6CC-0x000000018BECA6FC
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) {} // 0x000000018BECA78C-0x000000018BECA7BC
	
		// Methods
		private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) => default; // 0x000000018BECA2B8-0x000000018BECA318
		private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) {} // 0x000000018BECA318-0x000000018BECA3A4
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x000000018BECA1E0-0x000000018BECA238
		public void SetPixels(UnityEngine.Color[] colors, CubemapFace face, int arrayElement, int miplevel) {} // 0x000000018BECA3A4-0x000000018BECA408
		public void SetPixels(UnityEngine.Color[] colors, CubemapFace face, int arrayElement) {} // 0x000000018BECA408-0x000000018BECA424
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x000000018BECA238-0x000000018BECA2A8
		public void Apply() {} // 0x000000018BECA2A8-0x000000018BECA2B8
		private static void ValidateIsNotCrunched(TextureCreationFlags flags) {} // 0x000000018BECA424-0x000000018BECA484
	}

	public class RenderTexture : Texture // TypeDefIndex: 47488
	{
		// Properties
		public override int width { get => default; set {} } // 0x0000000185251A00-0x0000000185251A40 0x0000000185BA5D00-0x0000000185BA5D50
		public override int height { get => default; set {} } // 0x000000018594CB80-0x000000018594CBC0 0x0000000185BA5D50-0x0000000185BA5DA0
		public override TextureDimension dimension { get => default; set {} } // 0x000000018BED8638-0x000000018BED866C 0x0000000185BB75C0-0x0000000185BB7710
		public new GraphicsFormat graphicsFormat { get => default; set {} } // 0x000000018BED8740-0x000000018BED8774 0x0000000184015DA0-0x0000000184015DF0
		public bool useMipMap { get => default; set {} } // 0x000000018BED87A8-0x000000018BED87DC 0x0000000183FDA880-0x0000000183FDA8D0
		public bool sRGB { get => default; } // 0x000000018BED8774-0x000000018BED87A8 
		public RenderTextureMemoryless memorylessMode { set {} } // 0x0000000183FDA740-0x0000000183FDA790
		public RenderTextureFormat format { get => default; } // 0x000000018BED86A0-0x000000018BED8740 
		public GraphicsFormat stencilFormat { set {} } // 0x0000000183FD9BB0-0x0000000183FD9C00
		public GraphicsFormat depthStencilFormat { get => default; set {} } // 0x000000018BED8580-0x000000018BED85B4 0x0000000184015D50-0x0000000184015DA0
		public bool autoGenerateMips { get => default; set {} } // 0x000000018BED84F4-0x000000018BED8528 0x0000000183FDA830-0x0000000183FDA880
		public int volumeDepth { get => default; set {} } // 0x000000018BED87DC-0x000000018BED8810 0x0000000183FDA7E0-0x0000000183FDA830
		public int antiAliasing { set {} } // 0x0000000183FDA650-0x0000000183FDA6A0
		public bool bindTextureMS { set {} } // 0x0000000183FDA6A0-0x0000000183FDA6F0
		public bool enableRandomWrite { get => default; set {} } // 0x000000018BED866C-0x000000018BED86A0 0x0000000183FDA790-0x0000000183FDA7E0
		public bool useDynamicScale { set {} } // 0x0000000183FDA6F0-0x0000000183FDA740
		public static RenderTexture active { get => default; set {} } // 0x00000001864C22D0-0x00000001864C22DC 0x00000001864C4328-0x00000001864C4330
		public RenderBuffer colorBuffer { get => default; } // 0x000000018BED8528-0x000000018BED8554 
		public RenderBuffer depthBuffer { get => default; } // 0x000000018BED8554-0x000000018BED8580 
		public int depth { get => default; } // 0x000000018BED85B4-0x000000018BED85E8 
		public RenderTextureDescriptor descriptor { get => default; set {} } // 0x000000018BED85E8-0x000000018BED8638 0x000000018BED8810-0x000000018BED8898
	
		// Constructors
		protected internal RenderTexture() {} // 0x000000018BED8218-0x000000018BED8264
		public RenderTexture(RenderTextureDescriptor desc) {} // 0x0000000184016260-0x0000000184016360
		public RenderTexture(RenderTexture textureToCopy) {} // 0x000000018BED8388-0x000000018BED84F4
		public RenderTexture(int width, int height, int depth, DefaultFormat format) {} // 0x000000018BED8164-0x000000018BED8218
		public RenderTexture(int width, int height, int depth, GraphicsFormat format) {} // 0x0000000184015050-0x0000000184015100
		public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount) {} // 0x0000000184015100-0x0000000184015290
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) {} // 0x000000018BED7F94-0x000000018BED80B4
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) {} // 0x000000018BED82F8-0x000000018BED8388
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) {} // 0x00000001840146B0-0x0000000184014770
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format) {} // 0x000000018BED80D4-0x000000018BED8164
		public RenderTexture(int width, int height, int depth) {} // 0x000000018BED80B4-0x000000018BED80D4
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) {} // 0x000000018BED8264-0x000000018BED82F8
	
		// Methods
		private static RenderTexture GetActive() => default; // 0x000000018BED7BC0-0x000000018BED7BEC
		private static void SetActive(RenderTexture rt) {} // 0x000000018BED7F60-0x000000018BED7F94
		private RenderBuffer GetColorBuffer() => default; // 0x000000018BED7C30-0x000000018BED7C5C
		private RenderBuffer GetDepthBuffer() => default; // 0x000000018BED7CF0-0x000000018BED7D1C
		private void SetMipMapCount(int count) {} // 0x0000000184015D00-0x0000000184015D50
		public void DiscardContents(bool discardColor, bool discardDepth) {} // 0x000000018BED7B34-0x000000018BED7B8C
		public void DiscardContents() {} // 0x000000018BED7B24-0x000000018BED7B34
		public bool Create() => default; // 0x0000000183FDA610-0x0000000183FDA650
		public void Release() {} // 0x0000000184F21A00-0x0000000184F21A40
		public bool IsCreated() => default; // 0x0000000184013730-0x0000000184013770
		public void GenerateMips() {} // 0x000000018BED7B8C-0x000000018BED7BC0
		internal void SetSRGBReadWrite(bool srgb) {} // 0x0000000184015CB0-0x0000000184015D00
		private static void Internal_Create(RenderTexture rt) {} // 0x0000000184015C70-0x0000000184015CB0
		private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) {} // 0x000000018646D7A4-0x000000018646D7B8
		private RenderTextureDescriptor GetDescriptor() => default; // 0x000000018BED7D60-0x000000018BED7D98
		private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) => default; // 0x000000018646D734-0x000000018646D744
		public static void ReleaseTemporary(RenderTexture temp) {} // 0x0000000183FD9A50-0x0000000183FD9A90
		private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) {} // 0x0000000184014770-0x00000001840148A0
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) => default; // 0x00000001840152C0-0x0000000184015330
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format) => default; // 0x00000001840148A0-0x00000001840148B0
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) => default; // 0x00000001840148A0-0x00000001840148B0
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) => default; // 0x00000001840148B0-0x0000000184014930
		private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) {} // 0x0000000184014510-0x0000000184014630
		internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) => default; // 0x000000018BED7C5C-0x000000018BED7C7C
		internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) => default; // 0x000000018BED7C7C-0x000000018BED7CAC
		internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) => default; // 0x0000000184014930-0x00000001840149D0
		public static RenderTexture GetTemporary(RenderTextureDescriptor desc) => default; // 0x00000001840135A0-0x0000000184013640
		private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1 /* Metadata: 0x0206058F */, RenderTextureMemoryless memorylessMode = RenderTextureMemoryless.None /* Metadata: 0x02060590 */, VRTextureUsage vrUsage = VRTextureUsage.None /* Metadata: 0x02060591 */, bool useDynamicScale = false /* Metadata: 0x02060592 */) => default; // 0x00000001840134F0-0x00000001840135A0
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) => default; // 0x0000000184013480-0x00000001840134F0
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) => default; // 0x0000000184013440-0x0000000184013480
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode) => default; // 0x0000000184013410-0x0000000184013440
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing) => default; // 0x00000001840133E0-0x0000000184013410
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format) => default; // 0x00000001840133B0-0x00000001840133E0
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) => default; // 0x000000018BED7EBC-0x000000018BED7F60
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) => default; // 0x000000018BED7E04-0x000000018BED7E4C
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) => default; // 0x000000018BED7DB8-0x000000018BED7DF4
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) => default; // 0x000000018BED7E4C-0x000000018BED7E78
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) => default; // 0x000000018BED7E78-0x000000018BED7EA0
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) => default; // 0x000000018BED7EA0-0x000000018BED7EBC
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer) => default; // 0x000000018BED7D98-0x000000018BED7DB8
		public static RenderTexture GetTemporary(int width, int height) => default; // 0x000000018BED7DF4-0x000000018BED7E04
		private void GetColorBuffer_Injected(out RenderBuffer ret) {
			ret = default;
		} // 0x000000018BED7BEC-0x000000018BED7C30
		private void GetDepthBuffer_Injected(out RenderBuffer ret) {
			ret = default;
		} // 0x000000018BED7CAC-0x000000018BED7CF0
		private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) {} // 0x0000000184016360-0x0000000184016410
		private void GetDescriptor_Injected(out RenderTextureDescriptor ret) {
			ret = default;
		} // 0x000000018BED7D1C-0x000000018BED7D60
		private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) => default; // 0x0000000184013640-0x0000000184013680
	}

	public sealed class CustomRenderTexture : RenderTexture // TypeDefIndex: 47489
	{
		// Constructors
		public CustomRenderTexture() {} // Dummy constructor
	}

	public struct RenderTextureDescriptor // TypeDefIndex: 47490
	{
		// Fields
		private int _width_k__BackingField; // 0x00
		private int _height_k__BackingField; // 0x04
		private int _msaaSamples_k__BackingField; // 0x08
		private int _volumeDepth_k__BackingField; // 0x0C
		private int _mipCount_k__BackingField; // 0x10
		private GraphicsFormat _graphicsFormat; // 0x14
		private GraphicsFormat _stencilFormat_k__BackingField; // 0x18
		private GraphicsFormat _depthStencilFormat_k__BackingField; // 0x1C
		private TextureDimension _dimension_k__BackingField; // 0x20
		private ShadowSamplingMode _shadowSamplingMode_k__BackingField; // 0x24
		private VRTextureUsage _vrUsage_k__BackingField; // 0x28
		private RenderTextureCreationFlags _flags; // 0x2C
		private RenderTextureMemoryless _memoryless_k__BackingField; // 0x30
	
		// Properties
		public int width { get; set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int height { get; set; } // 0x000000018357CBC0-0x000000018357CBD0 0x0000000185FB2BA0-0x0000000185FB2BB0
		public int msaaSamples { get; set; } // 0x0000000181B7E450-0x0000000181B7E460 0x0000000185FB2B90-0x0000000185FB2BA0
		public int volumeDepth { get; set; } // 0x00000001834AFB70-0x00000001834AFB80 0x0000000185FB6960-0x0000000185FB6970
		public int mipCount { get; set; } // 0x0000000181378230-0x0000000181378240
		public GraphicsFormat graphicsFormat { get => default; set {} } // 0x0000000185FB1090-0x0000000185FB10A0 0x0000000184014F10-0x0000000184014FA0
		public GraphicsFormat depthStencilFormat { get; set; } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
		public RenderTextureFormat colorFormat { get => default; set {} } // 0x000000018BED79E8-0x000000018BED7A50 0x0000000184013E30-0x0000000184013EC0
		public bool sRGB { get => default; set {} } // 0x00000001840138B0-0x0000000184013900 0x000000018BED7A80-0x000000018BED7B24
		public int depthBufferBits { get => default; set {} } // 0x0000000184014FA0-0x0000000184014FF0 0x0000000184015290-0x00000001840152C0
		public TextureDimension dimension { get; set; } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public ShadowSamplingMode shadowSamplingMode { get; set; } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		public VRTextureUsage vrUsage { get; set; } // 0x0000000181C9A5C0-0x0000000181C9A5D0
		public RenderTextureMemoryless memoryless { get; set; } // 0x00000001813D0A90-0x00000001813D0AA0
		public bool useMipMap { get => default; set {} } // 0x000000018BED7A58-0x000000018BED7A60 0x000000018646D774-0x000000018646D784
		public bool autoGenerateMips { get => default; set {} } // 0x000000018BED79E0-0x000000018BED79E8 0x000000018646D764-0x000000018646D774
		public bool enableRandomWrite { get => default; set {} } // 0x000000018BED7A50-0x000000018BED7A58 0x000000018BED7A70-0x000000018BED7A80
		public bool bindMS { set {} } // 0x000000018BED7A60-0x000000018BED7A70
		internal bool createdFromScript { set {} } // 0x000000018646D754-0x000000018646D764
		public bool useDynamicScale { set {} } // 0x000000018646D744-0x000000018646D754
	
		// Constructors
		public RenderTextureDescriptor(int width, int height) : this() {
			<width>k__BackingField = default;
			<height>k__BackingField = default;
			<msaaSamples>k__BackingField = default;
			<volumeDepth>k__BackingField = default;
			<mipCount>k__BackingField = default;
			_graphicsFormat = default;
			<stencilFormat>k__BackingField = default;
			<depthStencilFormat>k__BackingField = default;
			<dimension>k__BackingField = default;
			<shadowSamplingMode>k__BackingField = default;
			<vrUsage>k__BackingField = default;
			_flags = default;
			<memoryless>k__BackingField = default;
		} // 0x000000018646D784-0x000000018646D7A4
		public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat) : this() {
			<width>k__BackingField = default;
			<height>k__BackingField = default;
			<msaaSamples>k__BackingField = default;
			<volumeDepth>k__BackingField = default;
			<mipCount>k__BackingField = default;
			_graphicsFormat = default;
			<stencilFormat>k__BackingField = default;
			<depthStencilFormat>k__BackingField = default;
			<dimension>k__BackingField = default;
			<shadowSamplingMode>k__BackingField = default;
			<vrUsage>k__BackingField = default;
			_flags = default;
			<memoryless>k__BackingField = default;
		} // 0x000000018BED794C-0x000000018BED7968
		public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) : this() {
			<width>k__BackingField = default;
			<height>k__BackingField = default;
			<msaaSamples>k__BackingField = default;
			<volumeDepth>k__BackingField = default;
			<mipCount>k__BackingField = default;
			_graphicsFormat = default;
			<stencilFormat>k__BackingField = default;
			<depthStencilFormat>k__BackingField = default;
			<dimension>k__BackingField = default;
			<shadowSamplingMode>k__BackingField = default;
			<vrUsage>k__BackingField = default;
			_flags = default;
			<memoryless>k__BackingField = default;
		} // 0x0000000185EBB180-0x0000000185EBB220
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) : this() {
			<width>k__BackingField = default;
			<height>k__BackingField = default;
			<msaaSamples>k__BackingField = default;
			<volumeDepth>k__BackingField = default;
			<mipCount>k__BackingField = default;
			_graphicsFormat = default;
			<stencilFormat>k__BackingField = default;
			<depthStencilFormat>k__BackingField = default;
			<dimension>k__BackingField = default;
			<shadowSamplingMode>k__BackingField = default;
			<vrUsage>k__BackingField = default;
			_flags = default;
			<memoryless>k__BackingField = default;
		} // 0x000000018BED78BC-0x000000018BED794C
		public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount) : this() {
			<width>k__BackingField = default;
			<height>k__BackingField = default;
			<msaaSamples>k__BackingField = default;
			<volumeDepth>k__BackingField = default;
			<mipCount>k__BackingField = default;
			_graphicsFormat = default;
			<stencilFormat>k__BackingField = default;
			<depthStencilFormat>k__BackingField = default;
			<dimension>k__BackingField = default;
			<shadowSamplingMode>k__BackingField = default;
			<vrUsage>k__BackingField = default;
			_flags = default;
			<memoryless>k__BackingField = default;
		} // 0x000000018647528C-0x00000001864752BC
		public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, RenderTextureReadWrite readWrite) : this() {
			<width>k__BackingField = default;
			<height>k__BackingField = default;
			<msaaSamples>k__BackingField = default;
			<volumeDepth>k__BackingField = default;
			<mipCount>k__BackingField = default;
			_graphicsFormat = default;
			<stencilFormat>k__BackingField = default;
			<depthStencilFormat>k__BackingField = default;
			<dimension>k__BackingField = default;
			<shadowSamplingMode>k__BackingField = default;
			<vrUsage>k__BackingField = default;
			_flags = default;
			<memoryless>k__BackingField = default;
		} // 0x0000000184013EC0-0x0000000184013FE0
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) : this() {
			<width>k__BackingField = default;
			<height>k__BackingField = default;
			<msaaSamples>k__BackingField = default;
			<volumeDepth>k__BackingField = default;
			<mipCount>k__BackingField = default;
			_graphicsFormat = default;
			<stencilFormat>k__BackingField = default;
			<depthStencilFormat>k__BackingField = default;
			<dimension>k__BackingField = default;
			<shadowSamplingMode>k__BackingField = default;
			<vrUsage>k__BackingField = default;
			_flags = default;
			<memoryless>k__BackingField = default;
		} // 0x000000018BED7968-0x000000018BED79E0
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) : this() {
			<width>k__BackingField = default;
			<height>k__BackingField = default;
			<msaaSamples>k__BackingField = default;
			<volumeDepth>k__BackingField = default;
			<mipCount>k__BackingField = default;
			_graphicsFormat = default;
			<stencilFormat>k__BackingField = default;
			<depthStencilFormat>k__BackingField = default;
			<dimension>k__BackingField = default;
			<shadowSamplingMode>k__BackingField = default;
			<vrUsage>k__BackingField = default;
			_flags = default;
			<memoryless>k__BackingField = default;
		} // 0x0000000184013770-0x0000000184013810
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) : this() {
			<width>k__BackingField = default;
			<height>k__BackingField = default;
			<msaaSamples>k__BackingField = default;
			<volumeDepth>k__BackingField = default;
			<mipCount>k__BackingField = default;
			_graphicsFormat = default;
			<stencilFormat>k__BackingField = default;
			<depthStencilFormat>k__BackingField = default;
			<dimension>k__BackingField = default;
			<shadowSamplingMode>k__BackingField = default;
			<vrUsage>k__BackingField = default;
			_flags = default;
			<memoryless>k__BackingField = default;
		} // 0x00000001840144A0-0x0000000184014510
	
		// Methods
		private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) {} // 0x0000000184015030-0x0000000184015050
	}

	[Serializable]
	public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128> // TypeDefIndex: 47491
	{
		// Fields
		internal ulong u64_0; // 0x00
		internal ulong u64_1; // 0x08
		private const ulong kConst = 16045690984833335023; // Metadata: 0x02060593
	
		// Constructors
		public Hash128(ulong u64_0, ulong u64_1) {
			this.u64_0 = default;
			this.u64_1 = default;
		} // 0x0000000183680100-0x0000000183680110
	
		// Methods
		public int CompareTo(Hash128 rhs) => default; // 0x000000018BECCDBC-0x000000018BECCE38
		public override string ToString() => default; // 0x000000018BECCF38-0x000000018BECCF58
		private static string Hash128ToStringImpl(Hash128 hash) => default; // 0x000000018BECCF28-0x000000018BECCF38
		public override bool Equals(object obj) => default; // 0x000000018BECCE38-0x000000018BECCEC8
		public bool Equals(Hash128 obj) => default; // 0x000000018BECCEC8-0x000000018BECCEF4
		public override int GetHashCode() => default; // 0x0000000185FE6BC0-0x0000000185FE6BE0
		public int CompareTo(object obj) => default; // 0x000000018BECCD40-0x000000018BECCDBC
		public static bool operator ==(Hash128 hash1, Hash128 hash2) => default; // 0x0000000187783A50-0x0000000187783A68
		public static bool operator <(Hash128 x, Hash128 y) => default; // 0x000000018BECCFD0-0x000000018BECCFE4
		public static bool operator >(Hash128 x, Hash128 y) => default; // 0x000000018BECCF58-0x000000018BECCFD0
		private static string Hash128ToStringImpl_Injected(ref Hash128 hash) => default; // 0x000000018BECCEF4-0x000000018BECCF28
	}

	public static class HashUtilities // TypeDefIndex: 47492
	{
		// Methods
		public static void AppendHash(ref Hash128 inHash, ref Hash128 outHash) {} // 0x000000018BECD0B8-0x000000018BECD0C8
		public static void ComputeHash128<T>(ref ref T value, ref Hash128 hash)
			where T : struct {}
	}

	public static class HashUnsafeUtilities // TypeDefIndex: 47493
	{
		// Methods
		public static unsafe void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2) {} // 0x000000018BECD044-0x000000018BECD0B8
		public static unsafe void ComputeHash128(void* data, ulong dataSize, Hash128* hash) {} // 0x000000018BECCFE4-0x000000018BECD044
	}

	internal static class SpookyHash // TypeDefIndex: 47495
	{
		// Fields
		private static readonly bool AllowUnalignedRead; // 0x00
	
		// Nested types
		private struct U // TypeDefIndex: 47494
		{
			// Fields
			public unsafe byte* p8; // 0x00
			public unsafe uint* p32; // 0x00
			public unsafe ulong* p64; // 0x00
			public ulong i; // 0x00
	
			// Constructors
			public unsafe U(ushort* p8) {
				this.p8 = default;
				p32 = default;
				p64 = default;
				i = default;
			} // 0x000000018BEDACE0-0x000000018BEDAD58
		}
	
		// Constructors
		static SpookyHash() {} // 0x0000000185FB2BB0-0x0000000185FB2BC0
	
		// Methods
		private static bool AttemptDetectAllowUnalignedRead() => default; // 0x000000018BEDB178-0x000000018BEDB4A8
		public static unsafe void Hash(void* message, ulong length, ulong* hash1, ulong* hash2) {} // 0x000000018BEDAF70-0x000000018BEDB178
		private static unsafe void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) {} // 0x000000018BEDAD58-0x000000018BEDAF70
		private static void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) {} // 0x0000000185FE6C60-0x0000000185FE6C90
		private static void Rot64(ref ulong x, int k) {} // 0x000000018BEDBAE8-0x000000018BEDBDB8
		private static unsafe void Short(void* message, ulong length, ulong* hash1, ulong* hash2) {} // 0x000000018BEDB908-0x000000018BEDBAE8
		private static void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) {} // 0x000000018BEDB768-0x000000018BEDB908
		private static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) {} // 0x000000018BEDB4A8-0x000000018BEDB768
		private static unsafe void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11) {} // 0x000000018BEDBDF4-0x000000018BEDBE70
		private static unsafe void memset(void* dst, int value, ulong numberOfBytes) {} // 0x000000018BEDBDB8-0x000000018BEDBDF4
	}

	[Serializable]
	public struct StringHash : IEquatable<StringHash>, IFormattable // TypeDefIndex: 47496
	{
		// Fields
		public long hashValue; // 0x00
		public string stringValue; // 0x08
	
		// Methods
		public override string ToString() => default; // 0x000000018BEE332C-0x000000018BEE3374
		public override int GetHashCode() => default; // 0x0000000185FE73C0-0x0000000185FE73D0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEE3374-0x000000018BEE3480
		public override bool Equals(object obj) => default; // 0x000000018BEE32C4-0x000000018BEE332C
		public bool Equals(StringHash other) => default; // 0x0000000188095DD0-0x0000000188095DDC
	}

	public enum CursorMode // TypeDefIndex: 47497
	{
		Auto = 0,
		ForceSoftware = 1
	}

	public enum CursorLockMode // TypeDefIndex: 47498
	{
		None = 0,
		Locked = 1,
		Confined = 2
	}

	public class Cursor // TypeDefIndex: 47499
	{
		// Properties
		public static bool visible { get => default; set {} } // 0x000000018558AB60-0x000000018558ABA0 0x000000018558ABA0-0x000000018558ABE0
		public static CursorLockMode lockState { get => default; set {} } // 0x0000000184212710-0x0000000184212750 0x000000018558ABE0-0x000000018558AC20
	
		// Constructors
		public Cursor() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static void SetCursor(Texture2D texture, UnityEngine.CursorMode cursorMode) {} // 0x000000018BEE012C-0x000000018BEE0154
		public static void SetCursor(Texture2D texture, Vector2 hotspot, UnityEngine.CursorMode cursorMode) {} // 0x0000000186474330-0x000000018647434C
		private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, UnityEngine.CursorMode cursorMode) {} // 0x0000000185BAB8F0-0x0000000185BAB950
	}

	public enum KeyCode // TypeDefIndex: 47500
	{
		None = 0,
		Backspace = 8,
		Tab = 9,
		Clear = 12,
		Return = 13,
		Pause = 19,
		Escape = 27,
		Space = 32,
		Exclaim = 33,
		DoubleQuote = 34,
		Hash = 35,
		Dollar = 36,
		Percent = 37,
		Ampersand = 38,
		Quote = 39,
		LeftParen = 40,
		RightParen = 41,
		Asterisk = 42,
		Plus = 43,
		Comma = 44,
		Minus = 45,
		Period = 46,
		Slash = 47,
		Alpha0 = 48,
		Alpha1 = 49,
		Alpha2 = 50,
		Alpha3 = 51,
		Alpha4 = 52,
		Alpha5 = 53,
		Alpha6 = 54,
		Alpha7 = 55,
		Alpha8 = 56,
		Alpha9 = 57,
		Colon = 58,
		Semicolon = 59,
		Less = 60,
		Equals = 61,
		Greater = 62,
		Question = 63,
		At = 64,
		LeftBracket = 91,
		Backslash = 92,
		RightBracket = 93,
		Caret = 94,
		Underscore = 95,
		BackQuote = 96,
		A = 97,
		B = 98,
		C = 99,
		D = 100,
		E = 101,
		F = 102,
		G = 103,
		H = 104,
		I = 105,
		J = 106,
		K = 107,
		L = 108,
		M = 109,
		N = 110,
		O = 111,
		P = 112,
		Q = 113,
		R = 114,
		S = 115,
		T = 116,
		U = 117,
		V = 118,
		W = 119,
		X = 120,
		Y = 121,
		Z = 122,
		LeftCurlyBracket = 123,
		Pipe = 124,
		RightCurlyBracket = 125,
		Tilde = 126,
		Delete = 127,
		Keypad0 = 256,
		Keypad1 = 257,
		Keypad2 = 258,
		Keypad3 = 259,
		Keypad4 = 260,
		Keypad5 = 261,
		Keypad6 = 262,
		Keypad7 = 263,
		Keypad8 = 264,
		Keypad9 = 265,
		KeypadPeriod = 266,
		KeypadDivide = 267,
		KeypadMultiply = 268,
		KeypadMinus = 269,
		KeypadPlus = 270,
		KeypadEnter = 271,
		KeypadEquals = 272,
		UpArrow = 273,
		DownArrow = 274,
		RightArrow = 275,
		LeftArrow = 276,
		Insert = 277,
		Home = 278,
		End = 279,
		PageUp = 280,
		PageDown = 281,
		F1 = 282,
		F2 = 283,
		F3 = 284,
		F4 = 285,
		F5 = 286,
		F6 = 287,
		F7 = 288,
		F8 = 289,
		F9 = 290,
		F10 = 291,
		F11 = 292,
		F12 = 293,
		F13 = 294,
		F14 = 295,
		F15 = 296,
		Numlock = 300,
		CapsLock = 301,
		ScrollLock = 302,
		RightShift = 303,
		LeftShift = 304,
		RightControl = 305,
		LeftControl = 306,
		RightAlt = 307,
		LeftAlt = 308,
		RightMeta = 309,
		RightCommand = 309,
		RightApple = 309,
		LeftMeta = 310,
		LeftCommand = 310,
		LeftApple = 310,
		LeftWindows = 311,
		RightWindows = 312,
		AltGr = 313,
		Help = 315,
		Print = 316,
		SysReq = 317,
		Break = 318,
		Menu = 319,
		Mouse0 = 323,
		Mouse1 = 324,
		Mouse2 = 325,
		Mouse3 = 326,
		Mouse4 = 327,
		Mouse5 = 328,
		Mouse6 = 329,
		JoystickButton0 = 330,
		JoystickButton1 = 331,
		JoystickButton2 = 332,
		JoystickButton3 = 333,
		JoystickButton4 = 334,
		JoystickButton5 = 335,
		JoystickButton6 = 336,
		JoystickButton7 = 337,
		JoystickButton8 = 338,
		JoystickButton9 = 339,
		JoystickButton10 = 340,
		JoystickButton11 = 341,
		JoystickButton12 = 342,
		JoystickButton13 = 343,
		JoystickButton14 = 344,
		JoystickButton15 = 345,
		JoystickButton16 = 346,
		JoystickButton17 = 347,
		JoystickButton18 = 348,
		JoystickButton19 = 349,
		Joystick1Button0 = 350,
		Joystick1Button1 = 351,
		Joystick1Button2 = 352,
		Joystick1Button3 = 353,
		Joystick1Button4 = 354,
		Joystick1Button5 = 355,
		Joystick1Button6 = 356,
		Joystick1Button7 = 357,
		Joystick1Button8 = 358,
		Joystick1Button9 = 359,
		Joystick1Button10 = 360,
		Joystick1Button11 = 361,
		Joystick1Button12 = 362,
		Joystick1Button13 = 363,
		Joystick1Button14 = 364,
		Joystick1Button15 = 365,
		Joystick1Button16 = 366,
		Joystick1Button17 = 367,
		Joystick1Button18 = 368,
		Joystick1Button19 = 369,
		Joystick2Button0 = 370,
		Joystick2Button1 = 371,
		Joystick2Button2 = 372,
		Joystick2Button3 = 373,
		Joystick2Button4 = 374,
		Joystick2Button5 = 375,
		Joystick2Button6 = 376,
		Joystick2Button7 = 377,
		Joystick2Button8 = 378,
		Joystick2Button9 = 379,
		Joystick2Button10 = 380,
		Joystick2Button11 = 381,
		Joystick2Button12 = 382,
		Joystick2Button13 = 383,
		Joystick2Button14 = 384,
		Joystick2Button15 = 385,
		Joystick2Button16 = 386,
		Joystick2Button17 = 387,
		Joystick2Button18 = 388,
		Joystick2Button19 = 389,
		Joystick3Button0 = 390,
		Joystick3Button1 = 391,
		Joystick3Button2 = 392,
		Joystick3Button3 = 393,
		Joystick3Button4 = 394,
		Joystick3Button5 = 395,
		Joystick3Button6 = 396,
		Joystick3Button7 = 397,
		Joystick3Button8 = 398,
		Joystick3Button9 = 399,
		Joystick3Button10 = 400,
		Joystick3Button11 = 401,
		Joystick3Button12 = 402,
		Joystick3Button13 = 403,
		Joystick3Button14 = 404,
		Joystick3Button15 = 405,
		Joystick3Button16 = 406,
		Joystick3Button17 = 407,
		Joystick3Button18 = 408,
		Joystick3Button19 = 409,
		Joystick4Button0 = 410,
		Joystick4Button1 = 411,
		Joystick4Button2 = 412,
		Joystick4Button3 = 413,
		Joystick4Button4 = 414,
		Joystick4Button5 = 415,
		Joystick4Button6 = 416,
		Joystick4Button7 = 417,
		Joystick4Button8 = 418,
		Joystick4Button9 = 419,
		Joystick4Button10 = 420,
		Joystick4Button11 = 421,
		Joystick4Button12 = 422,
		Joystick4Button13 = 423,
		Joystick4Button14 = 424,
		Joystick4Button15 = 425,
		Joystick4Button16 = 426,
		Joystick4Button17 = 427,
		Joystick4Button18 = 428,
		Joystick4Button19 = 429,
		Joystick5Button0 = 430,
		Joystick5Button1 = 431,
		Joystick5Button2 = 432,
		Joystick5Button3 = 433,
		Joystick5Button4 = 434,
		Joystick5Button5 = 435,
		Joystick5Button6 = 436,
		Joystick5Button7 = 437,
		Joystick5Button8 = 438,
		Joystick5Button9 = 439,
		Joystick5Button10 = 440,
		Joystick5Button11 = 441,
		Joystick5Button12 = 442,
		Joystick5Button13 = 443,
		Joystick5Button14 = 444,
		Joystick5Button15 = 445,
		Joystick5Button16 = 446,
		Joystick5Button17 = 447,
		Joystick5Button18 = 448,
		Joystick5Button19 = 449,
		Joystick6Button0 = 450,
		Joystick6Button1 = 451,
		Joystick6Button2 = 452,
		Joystick6Button3 = 453,
		Joystick6Button4 = 454,
		Joystick6Button5 = 455,
		Joystick6Button6 = 456,
		Joystick6Button7 = 457,
		Joystick6Button8 = 458,
		Joystick6Button9 = 459,
		Joystick6Button10 = 460,
		Joystick6Button11 = 461,
		Joystick6Button12 = 462,
		Joystick6Button13 = 463,
		Joystick6Button14 = 464,
		Joystick6Button15 = 465,
		Joystick6Button16 = 466,
		Joystick6Button17 = 467,
		Joystick6Button18 = 468,
		Joystick6Button19 = 469,
		Joystick7Button0 = 470,
		Joystick7Button1 = 471,
		Joystick7Button2 = 472,
		Joystick7Button3 = 473,
		Joystick7Button4 = 474,
		Joystick7Button5 = 475,
		Joystick7Button6 = 476,
		Joystick7Button7 = 477,
		Joystick7Button8 = 478,
		Joystick7Button9 = 479,
		Joystick7Button10 = 480,
		Joystick7Button11 = 481,
		Joystick7Button12 = 482,
		Joystick7Button13 = 483,
		Joystick7Button14 = 484,
		Joystick7Button15 = 485,
		Joystick7Button16 = 486,
		Joystick7Button17 = 487,
		Joystick7Button18 = 488,
		Joystick7Button19 = 489,
		Joystick8Button0 = 490,
		Joystick8Button1 = 491,
		Joystick8Button2 = 492,
		Joystick8Button3 = 493,
		Joystick8Button4 = 494,
		Joystick8Button5 = 495,
		Joystick8Button6 = 496,
		Joystick8Button7 = 497,
		Joystick8Button8 = 498,
		Joystick8Button9 = 499,
		Joystick8Button10 = 500,
		Joystick8Button11 = 501,
		Joystick8Button12 = 502,
		Joystick8Button13 = 503,
		Joystick8Button14 = 504,
		Joystick8Button15 = 505,
		Joystick8Button16 = 506,
		Joystick8Button17 = 507,
		Joystick8Button18 = 508,
		Joystick8Button19 = 509
	}

	public interface ILogger : ILogHandler // TypeDefIndex: 47501
	{
		// Properties
		ILogHandler logHandler { get; }
		bool logEnabled { get; set; }
		UnityEngine.LogType filterLogType { get; set; }
	
		// Methods
		bool IsLogTypeAllowed(UnityEngine.LogType logType);
		void Log(UnityEngine.LogType logType, object message);
		void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
		void Log(UnityEngine.LogType logType, string tag, object message, UnityEngine.Object context);
		void Log(string tag, object message);
		void LogWarning(string tag, object message);
		void LogError(string tag, object message);
		void LogFormat(UnityEngine.LogType logType, string format, object[] args);
		void LogException(Exception exception);
	}

	public interface ILogHandler // TypeDefIndex: 47502
	{
		// Methods
		void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
		void LogException(Exception exception, UnityEngine.Object context);
	}

	public class Logger : ILogger // TypeDefIndex: 47503
	{
		// Fields
		private ILogHandler _logHandler_k__BackingField; // 0x10
		private bool _logEnabled_k__BackingField; // 0x18
		private UnityEngine.LogType _filterLogType_k__BackingField; // 0x1C
	
		// Properties
		public ILogHandler logHandler { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public bool logEnabled { get; set; } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public UnityEngine.LogType filterLogType { get; set; } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
	
		// Constructors
		public Logger() {} // Dummy constructor
		public Logger(ILogHandler logHandler) {} // 0x0000000185D4C780-0x0000000185D4C8A0
	
		// Methods
		public bool IsLogTypeAllowed(UnityEngine.LogType logType) => default; // 0x00000001841C9CF0-0x00000001841C9D10
		private static string GetString(object message) => default; // 0x00000001856B5A20-0x00000001856B5B40
		public void Log(UnityEngine.LogType logType, object message) {} // 0x00000001856B5770-0x00000001856B5840
		public void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context) {} // 0x00000001856B5940-0x00000001856B5A20
		public void Log(UnityEngine.LogType logType, string tag, object message, UnityEngine.Object context) {} // 0x000000018BEE08E8-0x000000018BEE09E0
		public void Log(string tag, object message) {} // 0x000000018BEE07EC-0x000000018BEE08E8
		public void LogWarning(string tag, object message) {} // 0x000000018BEE06F0-0x000000018BEE07EC
		public void LogError(string tag, object message) {} // 0x000000018BEE04CC-0x000000018BEE05C8
		public void LogException(Exception exception) {} // 0x000000018BEE05F4-0x000000018BEE0620
		public void LogException(Exception exception, UnityEngine.Object context) {} // 0x000000018BEE05C8-0x000000018BEE05F4
		public void LogFormat(UnityEngine.LogType logType, string format, object[] args) {} // 0x000000018BEE0620-0x000000018BEE0684
		public void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args) {} // 0x000000018BEE0684-0x000000018BEE06F0
	}

	internal class UnityLogWriter : TextWriter // TypeDefIndex: 47504
	{
		// Properties
		public override Encoding Encoding { get => default; } // 0x000000018BEE3618-0x000000018BEE3624 
	
		// Constructors
		public UnityLogWriter() {} // 0x000000018BEE35CC-0x000000018BEE3618
	
		// Methods
		public static void WriteStringToUnityLog(string s) {} // 0x000000018BEE3524-0x000000018BEE3534
		private static void WriteStringToUnityLogImpl(string s) {} // 0x000000018BEE34F0-0x000000018BEE3524
		public static void Init() {} // 0x000000018BEE3480-0x000000018BEE34F0
		public override void Write(char value) {} // 0x000000018BEE3548-0x000000018BEE35A8
		public override void Write(string s) {} // 0x000000018BEE3534-0x000000018BEE3548
		public override void Write(char[] buffer, int index, int count) {} // 0x000000018BEE35A8-0x000000018BEE35CC
	}

	public struct Color : IEquatable<UnityEngine.Color>, IFormattable // TypeDefIndex: 47505
	{
		// Fields
		public float r; // 0x00
		public float g; // 0x04
		public float b; // 0x08
		public float a; // 0x0C
	
		// Properties
		public static Color red { get => default; } // 0x0000000185FE6F10-0x0000000185FE6F20 
		public static Color green { get => default; } // 0x0000000185FE6EF0-0x0000000185FE6F00 
		public static Color blue { get => default; } // 0x0000000185FE6E70-0x0000000185FE6E80 
		public static Color white { get => default; } // 0x0000000185FE6F20-0x0000000185FE6F30 
		public static Color black { get => default; } // 0x0000000184D2D2C0-0x0000000184D2D2D0 
		public static Color yellow { get => default; } // 0x0000000185FE6F30-0x0000000185FE6F40 
		public static Color cyan { get => default; } // 0x0000000185FE6E90-0x0000000185FE6EA0 
		public static Color magenta { get => default; } // 0x0000000185FE6F00-0x0000000185FE6F10 
		public static Color gray { get => default; } // 0x0000000185FE6EA0-0x0000000185FE6EB0 
		public static Color grey { get => default; } // 0x0000000185FE6EA0-0x0000000185FE6EB0 
		public static Color clear { get => default; } // 0x0000000185FE6E80-0x0000000185FE6E90 
		public float grayscale { get => default; } // 0x0000000185FE6EB0-0x0000000185FE6EF0 
		public Color linear { get => default; } // 0x000000018BEDFFAC-0x000000018BEE0028 
		public Color gamma { get => default; } // 0x00000001864BC720-0x00000001864BC79C 
		public float maxColorComponent { get => default; } // 0x000000018BEE0028-0x000000018BEE003C 
		public float this[int index] { get => default; set {} } // 0x0000000186DA5760-0x0000000186DA583C 0x0000000186DA583C-0x0000000186DA5918
	
		// Constructors
		public Color(float r, float g, float b, float a) : this() {
			this.r = default;
			this.g = default;
			this.b = default;
			this.a = default;
		} // 0x0000000185FB2B40-0x0000000185FB2B60
		public Color(float r, float g, float b) : this() {
			this.r = default;
			this.g = default;
			this.b = default;
			a = default;
		} // 0x0000000185FE6E50-0x0000000185FE6E70
	
		// Methods
		public override string ToString() => default; // 0x000000018BEDFDE4-0x000000018BEDFDF4
		public string ToString(string format) => default; // 0x000000018BEDFF9C-0x000000018BEDFFAC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEDFDF4-0x000000018BEDFF9C
		public override int GetHashCode() => default; // 0x0000000186DA572C-0x0000000186DA5760
		public override bool Equals(object other) => default; // 0x000000018BEDFC6C-0x000000018BEDFCE4
		public bool Equals(Color other) => default; // 0x000000018BEDFCE4-0x000000018BEDFD5C
		public static Color operator +(Color a, Color b) => default; // 0x00000001846E4F00-0x00000001846E4F60
		public static Color operator -(Color a, Color b) => default; // 0x00000001846E5380-0x00000001846E53E0
		public static Color operator *(Color a, Color b) => default; // 0x0000000185FE6F90-0x0000000185FE6FF0
		public static Color operator *(Color a, float b) => default; // 0x0000000183FB3A20-0x0000000183FB3A70
		public static Color operator *(float b, Color a) => default; // 0x0000000185FE6F40-0x0000000185FE6F90
		public static Color operator /(Color a, float b) => default; // 0x000000018BEE003C-0x000000018BEE005C
		public static bool operator ==(Color lhs, Color rhs) => default; // 0x000000018BEE005C-0x000000018BEE0100
		public static bool operator !=(Color lhs, Color rhs) => default; // 0x000000018BEE0100-0x000000018BEE012C
		public static Color Lerp(Color a, Color b, float t) => default; // 0x000000018BEDFD5C-0x000000018BEDFDE4
		public static Color LerpUnclamped(Color a, Color b, float t) => default; // 0x0000000185FE6D30-0x0000000185FE6DB0
		internal Color RGBMultiplied(float multiplier) => default; // 0x0000000185FE6E00-0x0000000185FE6E50
		internal Color AlphaMultiplied(float multiplier) => default; // 0x0000000185FE6CF0-0x0000000185FE6D30
		internal Color RGBMultiplied(Color multiplier) => default; // 0x0000000185FE6DB0-0x0000000185FE6E00
		public static implicit operator Vector4(Color c) => default; // 0x0000000184170910-0x0000000184170930
		public static implicit operator Color(Vector4 v) => default; // 0x0000000184170910-0x0000000184170930
		public static void RGBToHSV(Color rgbColor, out float H, out float S, out float V) {
			H = default;
			S = default;
			V = default;
		} // 0x000000018596CC10-0x000000018596CC80
		private static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, out float H, out float S, out float V) {
			H = default;
			S = default;
			V = default;
		} // 0x000000018596CC80-0x000000018596CD00
		public static Color HSVToRGB(float H, float S, float V) => default; // 0x000000018596CB30-0x000000018596CB70
		public static Color HSVToRGB(float H, float S, float V, bool hdr) => default; // 0x000000018596CB70-0x000000018596CC10
	}

	public struct Color32 : IFormattable // TypeDefIndex: 47506
	{
		// Fields
		private int rgba; // 0x00
		public byte r; // 0x00
		public byte g; // 0x01
		public byte b; // 0x02
		public byte a; // 0x03
	
		// Constructors
		public Color32(byte r, byte g, byte b, byte a) {
			rgba = default;
			this.r = default;
			this.g = default;
			this.b = default;
			this.a = default;
		} // 0x0000000185FD7200-0x0000000185FD7220
	
		// Methods
		public static implicit operator Color32(UnityEngine.Color c) => default; // 0x000000018BEDF934-0x000000018BEDF9F8
		public static implicit operator UnityEngine.Color(Color32 c) => default; // 0x000000018BEDF8BC-0x000000018BEDF934
		public static Color32 Lerp(Color32 a, Color32 b, float t) => default; // 0x000000018BEDF624-0x000000018BEDF724
		public override string ToString() => default; // 0x000000018BEDF8AC-0x000000018BEDF8BC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEDF724-0x000000018BEDF8AC
	}

	public class ColorUtility // TypeDefIndex: 47507
	{
		// Constructors
		public ColorUtility() {} // Dummy constructor
	
		// Methods
		internal static bool DoTryParseHtmlColor(string htmlString, out Color32 color) {
			color = default;
			return default;
		} // 0x000000018BEDF9F8-0x000000018BEDFA3C
		public static bool TryParseHtmlString(string htmlString, out UnityEngine.Color color) {
			color = default;
			return default;
		} // 0x000000018BEDFC2C-0x000000018BEDFC6C
		public static string ToHtmlStringRGBA(UnityEngine.Color color) => default; // 0x000000018BEDFA3C-0x000000018BEDFC2C
	}

	public struct GradientColorKey // TypeDefIndex: 47508
	{
		// Fields
		public UnityEngine.Color color; // 0x00
		public float time; // 0x10
	
		// Constructors
		public GradientColorKey(UnityEngine.Color col, float time) {
			color = default;
			this.time = default;
		} // 0x0000000185FCC200-0x0000000185FCC210
	}

	public struct GradientAlphaKey // TypeDefIndex: 47509
	{
		// Fields
		public float alpha; // 0x00
		public float time; // 0x04
	
		// Constructors
		public GradientAlphaKey(float alpha, float time) {
			this.alpha = default;
			this.time = default;
		} // 0x0000000185FB1970-0x0000000185FB1980
	}

	public enum GradientMode // TypeDefIndex: 47510
	{
		Blend = 0,
		Fixed = 1
	}

	public class Gradient : IEquatable<Gradient> // TypeDefIndex: 47511
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public GradientColorKey[] colorKeys { get => default; set {} } // 0x000000018BEE039C-0x000000018BEE03D0 0x000000018BEE0448-0x000000018BEE048C
		public GradientAlphaKey[] alphaKeys { get => default; set {} } // 0x000000018BEE0368-0x000000018BEE039C 0x000000018BEE0404-0x000000018BEE0448
		public GradientMode mode { get => default; set {} } // 0x000000018BEE03D0-0x000000018BEE0404 0x000000018BEE048C-0x000000018BEE04CC
	
		// Constructors
		public Gradient() {} // 0x0000000184B36B30-0x0000000184B36B50
	
		// Methods
		private static IntPtr Init() => default; // 0x0000000184B36B50-0x0000000184B36B90
		private void Cleanup() {} // 0x000000018BEE0154-0x000000018BEE0188
		private bool Internal_Equals(IntPtr other) => default; // 0x000000018BEE0324-0x000000018BEE0368
		~Gradient() {} // 0x000000018BEE02B4-0x000000018BEE0324
		public UnityEngine.Color Evaluate(float time) => default; // 0x0000000184A6FB00-0x0000000184A6FB30
		public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) {} // 0x0000000184B363B0-0x0000000184B36410
		public override bool Equals(object o) => default; // 0x000000018BEE0188-0x000000018BEE0224
		public bool Equals(Gradient other) => default; // 0x000000018BEE0224-0x000000018BEE02B4
		public override int GetHashCode() => default; // 0x0000000185FE6790-0x0000000185FE67A0
		private void Evaluate_Injected(float time, out UnityEngine.Color ret) {
			ret = default;
		} // 0x0000000184A6FB30-0x0000000184A6FC20
	}

	[Serializable]
	public struct FrustumPlanes // TypeDefIndex: 47512
	{
		// Fields
		public float left; // 0x00
		public float right; // 0x04
		public float bottom; // 0x08
		public float top; // 0x0C
		public float zNear; // 0x10
		public float zFar; // 0x14
	}

	public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable // TypeDefIndex: 47513
	{
		// Fields
		public float m00; // 0x00
		public float m10; // 0x04
		public float m20; // 0x08
		public float m30; // 0x0C
		public float m01; // 0x10
		public float m11; // 0x14
		public float m21; // 0x18
		public float m31; // 0x1C
		public float m02; // 0x20
		public float m12; // 0x24
		public float m22; // 0x28
		public float m32; // 0x2C
		public float m03; // 0x30
		public float m13; // 0x34
		public float m23; // 0x38
		public float m33; // 0x3C
		private static readonly Matrix4x4 zeroMatrix; // 0x00
		private static readonly Matrix4x4 identityMatrix; // 0x40
	
		// Properties
		public Quaternion rotation { get => default; } // 0x00000001853A07B0-0x00000001853A0820 
		public Vector3 lossyScale { get => default; } // 0x00000001853700D0-0x0000000185370150 
		public float determinant { get => default; } // 0x000000018646ECD4-0x000000018646ECE0 
		public FrustumPlanes decomposeProjection { get => default; } // 0x0000000184235940-0x00000001842359C0 
		public Matrix4x4 inverse { get => default; } // 0x000000018429E960-0x000000018429EA20 
		public Matrix4x4 transpose { get => default; } // 0x0000000184401B00-0x0000000184401BC0 
		public float this[int row, int column] { get => default; set {} } // 0x000000018BEE1F00-0x000000018BEE1F10 0x000000018BEE1FD0-0x000000018BEE1FE0
		public float this[int index] { get => default; set {} } // 0x00000001843F52D0-0x00000001843F5360 0x00000001845EC3F0-0x00000001845EC500
		public static Matrix4x4 zero { get => default; } // 0x000000018448F520-0x000000018448F580 
		public static Matrix4x4 identity { get => default; } // 0x000000018BEE1F10-0x000000018BEE1F6C 
	
		// Constructors
		public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) : this() {
			m00 = default;
			m10 = default;
			m20 = default;
			m30 = default;
			m01 = default;
			m11 = default;
			m21 = default;
			m31 = default;
			m02 = default;
			m12 = default;
			m22 = default;
			m32 = default;
			m03 = default;
			m13 = default;
			m23 = default;
			m33 = default;
		} // 0x0000000184401C80-0x0000000184401CF0
		static Matrix4x4() {
			zeroMatrix = default;
			identityMatrix = default;
		} // 0x0000000185D4C0B0-0x0000000185D4C200
	
		// Methods
		private Quaternion GetRotation() => default; // 0x00000001853A0820-0x00000001853A0850
		private Vector3 GetLossyScale() => default; // 0x0000000185370150-0x0000000185370180
		private float GetDeterminant() => default; // 0x000000018BEE1AA8-0x000000018BEE1AB0
		private FrustumPlanes DecomposeProjection() => default; // 0x00000001842359C0-0x0000000184235A20
		public Matrix4x4 HGMultiplyMatrix4x4Fast(Matrix4x4 rhs) => default; // 0x000000018416CEE0-0x000000018416CF60
		public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) => default; // 0x00000001840EA110-0x00000001840EA1A0
		public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) {} // 0x00000001846E71E0-0x00000001846E7290
		public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) => default; // 0x000000018BEE1AF4-0x000000018BEE1B08
		public static Matrix4x4 Inverse(Matrix4x4 m) => default; // 0x000000018429EA20-0x000000018429EA90
		public static Matrix4x4 Transpose(Matrix4x4 m) => default; // 0x0000000184401BC0-0x0000000184401C30
		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) => default; // 0x0000000184400EE0-0x0000000184400F90
		public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) => default; // 0x0000000184D00320-0x0000000184D003C0
		public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up) => default; // 0x0000000184400E50-0x0000000184400EE0
		public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) => default; // 0x00000001842353A0-0x0000000184235450
		public static Matrix4x4 Frustum(FrustumPlanes fp) => default; // 0x0000000184235260-0x00000001842353A0
		public override int GetHashCode() => default; // 0x00000001890D4454-0x00000001890D4534
		public override bool Equals(object other) => default; // 0x000000018BEE1A18-0x000000018BEE1AA8
		public bool Equals(Matrix4x4 other) => default; // 0x00000001886FAF20-0x00000001886FB0E4
		public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs) => default; // 0x000000018416CE10-0x000000018416CEE0
		public static Vector4 operator *(Matrix4x4 lhs, Vector4 vector) => default; // 0x0000000185FE7280-0x0000000185FE73A0
		public static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs) => default; // 0x0000000184214AA0-0x0000000184214D10
		public static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs) => default; // 0x000000018BEE1F6C-0x000000018BEE1FD0
		public Vector4 GetColumn(int index) => default; // 0x0000000184214D10-0x0000000184214D90
		public Vector4 GetRow(int index) => default; // 0x0000000184402100-0x0000000184402150
		public Vector3 GetPosition() => default; // 0x0000000185FE7010-0x0000000185FE7030
		public void SetColumn(int index, Vector4 column) {} // 0x00000001845EC370-0x00000001845EC3F0
		public void SetRow(int index, Vector4 row) {} // 0x00000001845EC500-0x00000001845EC5D0
		public Vector3 MultiplyPoint(Vector3 point) => default; // 0x00000001840EC570-0x00000001840ECA90
		public Vector3 MultiplyPoint3x4(Vector3 point) => default; // 0x0000000184265CC0-0x0000000184265D60
		public Vector3 MultiplyVector(Vector3 vector) => default; // 0x00000001849EF9D0-0x00000001849EFA60
		public static Matrix4x4 Scale(Vector3 vector) => default; // 0x0000000184401A60-0x0000000184401B00
		public static Matrix4x4 Translate(Vector3 vector) => default; // 0x0000000185FE71E0-0x0000000185FE7280
		public static Matrix4x4 Rotate(Quaternion q) => default; // 0x0000000185FE7030-0x0000000185FE71E0
		public override string ToString() => default; // 0x000000018BEE1B08-0x000000018BEE1B18
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEE1B18-0x000000018BEE1F00
		private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) {
			ret = default;
		} // 0x00000001853A0850-0x00000001853A08A0
		private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) {
			ret = default;
		} // 0x0000000185370180-0x00000001853701D0
		private static float GetDeterminant_Injected(ref Matrix4x4 _unity_self) => default; // 0x000000018512D850-0x000000018512D890
		private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) {
			ret = default;
		} // 0x0000000184235150-0x00000001842351A0
		private static void HGMultiplyMatrix4x4Fast_Injected(ref Matrix4x4 _unity_self, ref Matrix4x4 rhs, out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018416CF60-0x000000018416CFC0
		private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) {
			ret = default;
		} // 0x00000001840EA1A0-0x00000001840EB0A0
		private static bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result) => default; // 0x000000018BEE1AB0-0x000000018BEE1AF4
		private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018429EA90-0x000000018429EB40
		private static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000184401C30-0x0000000184401C80
		private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000184401000-0x0000000184401090
		private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000184D003C0-0x0000000184D00440
		private static void LookAt_Injected(ref Vector3 from, ref Vector3 to, ref Vector3 up, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000184400F90-0x0000000184401000
		private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000184235060-0x0000000184235150
	}

	public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 47514
	{
		// Fields
		public const float kEpsilon = 1E-05f; // Metadata: 0x0206080B
		public const float kEpsilonNormalSqrt = 1E-15f; // Metadata: 0x0206080F
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		private static readonly Vector3 positiveInfinityVector; // 0x00
		private static readonly Vector3 negativeInfinityVector; // 0x0C
	
		// Properties
		public float this[int index] { get => default; set {} } // 0x000000018BEE5508-0x000000018BEE5588 0x000000018BEE5788-0x000000018BEE5808
		public Vector3 normalized { get => default; } // 0x000000018BEE5694-0x000000018BEE56DC 
		public float magnitude { get => default; } // 0x000000018BEE5588-0x000000018BEE5648 
		public float sqrMagnitude { get => default; } // 0x0000000184FCD210-0x0000000184FCD240 
		public static Vector3 zero { get => default; } // 0x00000001848E6230-0x00000001848E6250 
		public static Vector3 one { get => default; } // 0x0000000185FE7960-0x0000000185FE7980 
		public static Vector3 forward { get => default; } // 0x000000018472D400-0x000000018472D420 
		public static Vector3 back { get => default; } // 0x0000000185FE7900-0x0000000185FE7920 
		public static Vector3 up { get => default; } // 0x0000000185FE7980-0x0000000185FE79A0 
		public static Vector3 down { get => default; } // 0x0000000185FE7920-0x0000000185FE7940 
		public static Vector3 left { get => default; } // 0x0000000185FE7940-0x0000000185FE7960 
		public static Vector3 right { get => default; } // 0x000000018472D570-0x000000018472D590 
		public static Vector3 positiveInfinity { get => default; } // 0x000000018BEE56DC-0x000000018BEE5728 
		public static Vector3 negativeInfinity { get => default; } // 0x000000018BEE5648-0x000000018BEE5694 
		public static Vector3 fwd { get => default; } // 0x000000018472D400-0x000000018472D420 
	
		// Constructors
		public Vector3(float x, float y, float z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000185FB2F40-0x0000000185FB2F50
		public Vector3(float x, float y) : this() {
			this.x = default;
			this.y = default;
			z = default;
		} // 0x0000000185FE78E0-0x0000000185FE7900
		static Vector3() {
			positiveInfinityVector = default;
			negativeInfinityVector = default;
		} // 0x000000018496D0C0-0x000000018496D130
	
		// Methods
		public static Vector3 Slerp(Vector3 a, Vector3 b, float t) => default; // 0x00000001842861F0-0x0000000184286270
		public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t) => default; // 0x000000018BEE5408-0x000000018BEE543C
		private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) {} // 0x000000018BEE50D0-0x000000018BEE5114
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) {} // 0x000000018BEE5170-0x000000018BEE5178
		private static void OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c) {} // 0x000000018BEE5114-0x000000018BEE5168
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal) {} // 0x000000018BEE5168-0x000000018BEE5170
		public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) => default; // 0x000000018428C070-0x000000018428C0F0
		public static Vector3 Lerp(Vector3 a, Vector3 b, float t) => default; // 0x000000018BEE4D30-0x000000018BEE4D8C
		public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) => default; // 0x00000001844AC930-0x00000001844AC980
		public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) => default; // 0x000000018BEE4E5C-0x000000018BEE4FB0
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed) => default; // 0x0000000186EED838-0x0000000186EEDB0C
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) => default; // 0x000000018BEE543C-0x000000018BEE54F8
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) => default; // 0x0000000184F9F370-0x0000000184F9F650
		public void Set(float newX, float newY, float newZ) {} // 0x0000000185FB2F40-0x0000000185FB2F50
		public static Vector3 Scale(Vector3 a, Vector3 b) => default; // 0x0000000185FE7880-0x0000000185FE78B0
		public void Scale(Vector3 scale) {} // 0x0000000185FE78B0-0x0000000185FE78E0
		public static Vector3 Cross(Vector3 lhs, Vector3 rhs) => default; // 0x00000001840CEF10-0x00000001840CEF70
		public override int GetHashCode() => default; // 0x0000000184CDA520-0x0000000184CDA580
		public override bool Equals(object other) => default; // 0x000000018BEE4C50-0x000000018BEE4CD0
		public bool Equals(Vector3 other) => default; // 0x00000001843884A0-0x00000001843884D0
		public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) => default; // 0x00000001847F8960-0x00000001847F89F0
		public static Vector3 Normalize(Vector3 value) => default; // 0x000000018BEE5034-0x000000018BEE50D0
		public void Normalize() {} // 0x000000018BEE4FB0-0x000000018BEE5034
		public static float Dot(Vector3 lhs, Vector3 rhs) => default; // 0x0000000185FE7850-0x0000000185FE7880
		public static Vector3 Project(Vector3 vector, Vector3 onNormal) => default; // 0x000000018BEE5294-0x000000018BEE53A4
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) => default; // 0x000000018BEE5178-0x000000018BEE5294
		public static float Angle(Vector3 from, Vector3 to) => default; // 0x000000018BEE49D4-0x000000018BEE4AD8
		public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) => default; // 0x00000001840CCCB0-0x00000001840CCD70
		public static float Distance(Vector3 a, Vector3 b) => default; // 0x000000018BEE4BAC-0x000000018BEE4C50
		public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) => default; // 0x000000018BEE4AD8-0x000000018BEE4BAC
		public static float Magnitude(Vector3 vector) => default; // 0x000000018BEE4D8C-0x000000018BEE4DF4
		public static float SqrMagnitude(Vector3 vector) => default; // 0x0000000184FCD210-0x0000000184FCD240
		public static Vector3 Min(Vector3 lhs, Vector3 rhs) => default; // 0x000000018BEE4E28-0x000000018BEE4E5C
		public static Vector3 Max(Vector3 lhs, Vector3 rhs) => default; // 0x000000018BEE4DF4-0x000000018BEE4E28
		public static Vector3 operator +(Vector3 a, Vector3 b) => default; // 0x000000018472FB00-0x000000018472FB30
		public static Vector3 operator -(Vector3 a, Vector3 b) => default; // 0x000000018472FAD0-0x000000018472FB00
		public static Vector3 operator -(Vector3 a) => default; // 0x00000001847FE180-0x00000001847FE1F0
		public static Vector3 operator *(Vector3 a, float d) => default; // 0x000000018472FB30-0x000000018472FB60
		public static Vector3 operator *(float d, Vector3 a) => default; // 0x0000000185FE79A0-0x0000000185FE79D0
		public static Vector3 operator /(Vector3 a, float d) => default; // 0x000000018406B300-0x000000018406B820
		public static bool operator ==(Vector3 lhs, Vector3 rhs) => default; // 0x00000001842155D0-0x0000000184215610
		public static bool operator !=(Vector3 lhs, Vector3 rhs) => default; // 0x000000018BEE5728-0x000000018BEE5788
		public override string ToString() => default; // 0x0000000186475080-0x0000000186475090
		public string ToString(string format) => default; // 0x000000018BEE54F8-0x000000018BEE5508
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000184D06DA0-0x0000000184D06F50
		public static float AngleBetween(Vector3 from, Vector3 to) => default; // 0x000000018BEE4904-0x000000018BEE49D4
		public static Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat) => default; // 0x000000018BEE4CD0-0x000000018BEE4D30
		private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) {
			ret = default;
		} // 0x0000000184286270-0x00000001842862E0
		private static void SlerpUnclamped_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEE53A4-0x000000018BEE5408
		private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) {
			ret = default;
		} // 0x000000018428C0F0-0x000000018428C280
	}

	public struct Quaternion : IEquatable<Quaternion>, IFormattable // TypeDefIndex: 47515
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
		public const float kEpsilon = 1E-06f; // Metadata: 0x02060813
	
		// Properties
		public float this[int index] { get => default; set {} } // 0x0000000186E365B0-0x0000000186E3663C 0x0000000186E3663C-0x0000000186E366C8
		public static Quaternion identity { get => default; } // 0x0000000184D2D2C0-0x0000000184D2D2D0 
		public Vector3 eulerAngles { get => default; set {} } // 0x000000018BEE2E68-0x000000018BEE2EF8 0x0000000186E366C8-0x0000000186E3672C
		public Quaternion normalized { get => default; } // 0x0000000184329A30-0x0000000184329B80 
	
		// Constructors
		public Quaternion(float x, float y, float z, float w) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000185FB2B40-0x0000000185FB2B60
	
		// Methods
		public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) => default; // 0x00000001840D0070-0x00000001840D00E0
		public static Quaternion Inverse(Quaternion rotation) => default; // 0x00000001841EFAD0-0x00000001841EFB30
		public static Quaternion Slerp(Quaternion a, Quaternion b, float t) => default; // 0x00000001844E3800-0x00000001844E3880
		public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) => default; // 0x00000001844AC980-0x00000001844ACA00
		public static Quaternion Lerp(Quaternion a, Quaternion b, float t) => default; // 0x00000001840D0140-0x00000001840D01C0
		public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) => default; // 0x000000018BEE29DC-0x000000018BEE2A14
		private static Quaternion Internal_FromEulerRad(Vector3 euler) => default; // 0x000000018416CCA0-0x000000018416CD00
		private static Vector3 Internal_ToEulerRad(Quaternion rotation) => default; // 0x000000018416CA20-0x000000018416CA80
		private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle) {
			axis = default;
			angle = default;
		} // 0x000000018BEE2958-0x000000018BEE296C
		public static Quaternion AngleAxis(float angle, Vector3 axis) => default; // 0x00000001841F1C90-0x00000001841F1D00
		public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) => default; // 0x00000001840CFDB0-0x00000001840CFE20
		public static Quaternion LookRotation(Vector3 forward) => default; // 0x0000000184329EA0-0x0000000184329F20
		public void Set(float newX, float newY, float newZ, float newW) {} // 0x0000000185FB2B40-0x0000000185FB2B60
		public static Quaternion operator *(Quaternion lhs, Quaternion rhs) => default; // 0x00000001840D0260-0x00000001840D0370
		public static Vector3 operator *(Quaternion rotation, Vector3 point) => default; // 0x00000001840D0890-0x00000001840D0A00
		private static bool IsEqualUsingDot(float dot) => default; // 0x000000018BEE296C-0x000000018BEE2978
		public static bool operator ==(Quaternion lhs, Quaternion rhs) => default; // 0x000000018BEE2EF8-0x000000018BEE2F2C
		public static bool operator !=(Quaternion lhs, Quaternion rhs) => default; // 0x000000018BEE2F2C-0x000000018BEE2F58
		public static float Dot(Quaternion a, Quaternion b) => default; // 0x0000000183F917E0-0x0000000183F91820
		public void SetLookRotation(Vector3 view) {} // 0x0000000186E36524-0x0000000186E36570
		public void SetLookRotation(Vector3 view, Vector3 up) {} // 0x0000000186E364D0-0x0000000186E36524
		public static float Angle(Quaternion a, Quaternion b) => default; // 0x000000018BEE2720-0x000000018BEE2778
		private static Vector3 Internal_MakePositive(Vector3 euler) => default; // 0x000000018416CA80-0x000000018416CB10
		public static Quaternion Euler(float x, float y, float z) => default; // 0x000000018BEE289C-0x000000018BEE2904
		public static Quaternion Euler(Vector3 euler) => default; // 0x000000018BEE2830-0x000000018BEE289C
		public void ToAngleAxis(out float angle, out Vector3 axis) {
			angle = default;
			axis = default;
		} // 0x0000000186E36570-0x0000000186E365B0
		public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection) {} // 0x0000000186E3647C-0x0000000186E364D0
		public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) => default; // 0x000000018BEE2ABC-0x000000018BEE2B70
		public static Quaternion Normalize(Quaternion q) => default; // 0x000000018BEE2A14-0x000000018BEE2ABC
		public void Normalize() {} // 0x000000018646E8B0-0x000000018646E8DC
		public override int GetHashCode() => default; // 0x0000000186DA5918-0x0000000186DA5984
		public override bool Equals(object other) => default; // 0x000000018BEE2778-0x000000018BEE27F0
		public bool Equals(Quaternion other) => default; // 0x000000018BEDFCE4-0x000000018BEDFD5C
		public override string ToString() => default; // 0x000000018BEE2E58-0x000000018BEE2E68
		public string ToString(string format) => default; // 0x000000018BEE2CA0-0x000000018BEE2CB0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEE2CB0-0x000000018BEE2E58
		public static Quaternion EulerRotation(float x, float y, float z) => default; // 0x000000018BEE27F0-0x000000018BEE2830
		public static Quaternion EulerRotation(Vector3 euler) => default; // 0x000000018BEDF5A8-0x000000018BEDF5EC
		public void SetEulerRotation(float x, float y, float z) {} // 0x000000018BEE2C04-0x000000018BEE2C3C
		public void SetEulerRotation(Vector3 euler) {} // 0x000000018BEDF5EC-0x000000018BEDF624
		public Vector3 ToEuler() => default; // 0x000000018BEE2C5C-0x000000018BEE2CA0
		public static Quaternion EulerAngles(float x, float y, float z) => default; // 0x000000018BEE27F0-0x000000018BEE2830
		public static Quaternion EulerAngles(Vector3 euler) => default; // 0x000000018BEDF5A8-0x000000018BEDF5EC
		public void ToAxisAngle(out Vector3 axis, out float angle) {
			axis = default;
			angle = default;
		} // 0x000000018BEE2C3C-0x000000018BEE2C5C
		public void SetEulerAngles(float x, float y, float z) {} // 0x000000018BEE2BE0-0x000000018BEE2C04
		public void SetEulerAngles(Vector3 euler) {} // 0x000000018BEE2BA8-0x000000018BEE2BE0
		public static Vector3 ToEulerAngles(Quaternion rotation) => default; // 0x000000018BEE2C5C-0x000000018BEE2CA0
		public Vector3 ToEulerAngles() => default; // 0x000000018BEE2C5C-0x000000018BEE2CA0
		public void SetAxisAngle(Vector3 axis, float angle) {} // 0x000000018BEE2B70-0x000000018BEE2BA8
		public static Quaternion AxisAngle(Vector3 axis, float angle) => default; // 0x000000018BEDF558-0x000000018BEDF5A8
		private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) {
			ret = default;
		} // 0x00000001840D00E0-0x00000001840D0140
		private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) {
			ret = default;
		} // 0x00000001841EFB30-0x00000001841EFB80
		private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) {
			ret = default;
		} // 0x00000001844E3880-0x00000001844E38F0
		private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) {
			ret = default;
		} // 0x00000001844ADC50-0x00000001844ADCC0
		private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) {
			ret = default;
		} // 0x00000001840D0370-0x00000001840D03E0
		private static void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) {
			ret = default;
		} // 0x000000018BEE2978-0x000000018BEE29DC
		private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) {
			ret = default;
		} // 0x000000018416CD00-0x000000018416CD50
		private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) {
			ret = default;
		} // 0x000000018416CB10-0x000000018416CCA0
		private static void Internal_ToAxisAngleRad_Injected(ref Quaternion q, out Vector3 axis, out float angle) {
			axis = default;
			angle = default;
		} // 0x000000018BEE2904-0x000000018BEE2958
		private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) {
			ret = default;
		} // 0x00000001841F1D00-0x00000001841F1D60
		private static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) {
			ret = default;
		} // 0x00000001840CFE20-0x00000001840CFE80
	}

	public struct Mathf // TypeDefIndex: 47516
	{
		// Fields
		public const float PI = 3.1415927f; // Metadata: 0x02060817
		public const float Infinity = 1F / 0F; // Metadata: 0x0206081B
		public const float NegativeInfinity = -1F / 0F; // Metadata: 0x0206081F
		public const float Deg2Rad = 0.017453292f; // Metadata: 0x02060823
		public const float Rad2Deg = 57.29578f; // Metadata: 0x02060827
		public static readonly float Epsilon; // 0x00
	
		// Constructors
		static Mathf() {
			Epsilon = default;
		} // 0x0000000185F63B60-0x0000000185F63BD0
	
		// Methods
		public static int ClosestPowerOfTwo(int value) => default; // 0x000000018BEE0DD4-0x000000018BEE0E08
		public static bool IsPowerOfTwo(int value) => default; // 0x000000018BEE10A4-0x000000018BEE10D8
		public static int NextPowerOfTwo(int value) => default; // 0x00000001844030E0-0x0000000184403120
		public static float GammaToLinearSpace(float value) => default; // 0x0000000184DCF540-0x0000000184DCF670
		public static float LinearToGammaSpace(float value) => default; // 0x000000018BEE134C-0x000000018BEE1388
		public static UnityEngine.Color CorrelatedColorTemperatureToRGB(float kelvin) => default; // 0x000000018BEE0E4C-0x000000018BEE0E74
		public static ushort FloatToHalf(float val) => default; // 0x000000018BEE0F58-0x000000018BEE0F94
		public static float HalfToFloat(ushort val) => default; // 0x000000018BEE1044-0x000000018BEE1078
		public static float PerlinNoise(float x, float y) => default; // 0x000000018BEE1508-0x000000018BEE1554
		public static float Sin(float f) => default; // 0x000000018BEE177C-0x000000018BEE17D4
		public static float Cos(float f) => default; // 0x000000018BEE0E74-0x000000018BEE0ECC
		public static float Tan(float f) => default; // 0x000000018BEE19C0-0x000000018BEE1A18
		public static float Asin(float f) => default; // 0x000000018BEE0B5C-0x000000018BEE0BB4
		public static float Acos(float f) => default; // 0x000000018BEE0A7C-0x000000018BEE0AD4
		public static float Atan(float f) => default; // 0x000000018BEE0C18-0x000000018BEE0C70
		public static float Atan2(float y, float x) => default; // 0x000000018BEE0BB4-0x000000018BEE0C18
		public static float Sqrt(float f) => default; // 0x000000018BEE1970-0x000000018BEE19C0
		public static float Abs(float f) => default; // 0x000000018BEE09E0-0x000000018BEE0A34
		public static int Abs(int value) => default; // 0x000000018BEE0A34-0x000000018BEE0A7C
		public static float Min(float a, float b) => default; // 0x00000001840EC230-0x00000001840EC240
		public static float Min(float[] values) => default; // 0x0000000186DDA0CC-0x0000000186DDA11C
		public static int Min(int a, int b) => default; // 0x000000018429BE10-0x000000018429BE20
		public static int Min(int[] values) => default; // 0x0000000186DDA11C-0x0000000186DDA168
		public static float Max(float a, float b) => default; // 0x00000001840EC240-0x00000001840EC250
		public static float Max(float[] values) => default; // 0x0000000186DDA078-0x0000000186DDA0CC
		public static int Max(int a, int b) => default; // 0x00000001841FA300-0x00000001841FA310
		public static int Max(int[] values) => default; // 0x0000000186DDA02C-0x0000000186DDA078
		public static float Pow(float f, float p) => default; // 0x000000018BEE1588-0x000000018BEE15EC
		public static float Exp(float power) => default; // 0x000000018BEE0F00-0x000000018BEE0F58
		public static float Log(float f, float p) => default; // 0x000000018BEE13E0-0x000000018BEE1448
		public static float Log(float f) => default; // 0x000000018BEE1448-0x000000018BEE14A0
		public static float Log10(float f) => default; // 0x000000018BEE1388-0x000000018BEE13E0
		public static float Ceil(float f) => default; // 0x000000018BEE0CC8-0x000000018BEE0D20
		public static float Floor(float f) => default; // 0x000000018BEE0FEC-0x000000018BEE1044
		public static float Round(float f) => default; // 0x000000018BEE1724-0x000000018BEE177C
		public static int CeilToInt(float f) => default; // 0x000000018BEE0C70-0x000000018BEE0CC8
		public static int FloorToInt(float f) => default; // 0x000000018BEE0F94-0x000000018BEE0FEC
		public static int RoundToInt(float f) => default; // 0x000000018BEE16CC-0x000000018BEE1724
		public static float Sign(float f) => default; // 0x00000001840CDD90-0x00000001840CDDB0
		public static float Clamp(float value, float min, float max) => default; // 0x000000018BEE0DC0-0x000000018BEE0DD4
		public static int Clamp(int value, int min, int max) => default; // 0x000000018BEE0DAC-0x000000018BEE0DC0
		public static float Clamp01(float value) => default; // 0x000000018B5EA184-0x000000018B5EA1A4
		public static float Lerp(float a, float b, float t) => default; // 0x000000018BEE1138-0x000000018BEE115C
		public static float LerpUnclamped(float a, float b, float t) => default; // 0x0000000185FE6FF0-0x0000000185FE7010
		public static float LerpAngle(float a, float b, float t) => default; // 0x000000018BEE10D8-0x000000018BEE1138
		public static float MoveTowards(float current, float target, float maxDelta) => default; // 0x0000000186DDA168-0x0000000186DDA1A4
		public static float MoveTowardsAngle(float current, float target, float maxDelta) => default; // 0x000000018BEE14A0-0x000000018BEE1508
		public static float SmoothStep(float from, float to, float t) => default; // 0x000000018BEE1918-0x000000018BEE1970
		public static float Gamma(float value, float absmax, float gamma) => default; // 0x0000000186DD9FE0-0x0000000186DDA02C
		public static bool Approximately(float a, float b) => default; // 0x000000018BEE0AD4-0x000000018BEE0B5C
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed) => default; // 0x000000018BEE18A8-0x000000018BEE1918
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime) => default; // 0x000000018BEE183C-0x000000018BEE18A8
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) => default; // 0x00000001842186B0-0x0000000184218820
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed) => default; // 0x0000000186DDA1A4-0x0000000186DDA20C
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime) => default; // 0x0000000186DDA20C-0x0000000186DDA274
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) => default; // 0x000000018BEE17D4-0x000000018BEE183C
		public static float Repeat(float t, float length) => default; // 0x000000018BEE1680-0x000000018BEE16CC
		public static float PingPong(float t, float length) => default; // 0x000000018BEE1554-0x000000018BEE1588
		public static float InverseLerp(float a, float b, float value) => default; // 0x000000018BEE1078-0x000000018BEE10A4
		public static float DeltaAngle(float current, float target) => default; // 0x000000018BEE0ECC-0x000000018BEE0F00
		internal static bool LineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result) => default; // 0x000000018BEE115C-0x000000018BEE1228
		internal static bool LineSegmentIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result) => default; // 0x000000018BEE1228-0x000000018BEE134C
		internal static long RandomToLong(System.Random r) => default; // 0x000000018BEE15EC-0x000000018BEE1680
		internal static float ClampToFloat(double value) => default; // 0x000000018BEE0D20-0x000000018BEE0D80
		internal static int ClampToInt(long value) => default; // 0x000000018BEE0D80-0x000000018BEE0D98
		internal static uint ClampToUInt(long value) => default; // 0x000000018BEE0D98-0x000000018BEE0DAC
		private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BEE0E08-0x000000018BEE0E4C
	}

	public struct Vector2 : IEquatable<Vector2>, IFormattable // TypeDefIndex: 47517
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		private static readonly Vector2 positiveInfinityVector; // 0x00
		private static readonly Vector2 negativeInfinityVector; // 0x08
		public const float kEpsilon = 1E-05f; // Metadata: 0x0206082B
		public const float kEpsilonNormalSqrt = 1E-15f; // Metadata: 0x0206082F
	
		// Properties
		public float this[int index] { get => default; set {} } // 0x000000018BEE41F8-0x000000018BEE426C 0x000000018BEE440C-0x000000018BEE4480
		public Vector2 normalized { get => default; } // 0x000000018BEE4344-0x000000018BEE4374 
		public float magnitude { get => default; } // 0x000000018BEE426C-0x000000018BEE42FC 
		public float sqrMagnitude { get => default; } // 0x0000000185FE76A0-0x0000000185FE76C0 
		public static Vector2 zero { get => default; } // 0x0000000185FBF3B0-0x0000000185FBF3C0 
		public static Vector2 one { get => default; } // 0x0000000185FE7700-0x0000000185FE7720 
		public static Vector2 up { get => default; } // 0x0000000185FE7740-0x0000000185FE7760 
		public static Vector2 down { get => default; } // 0x0000000185FE76C0-0x0000000185FE76E0 
		public static Vector2 left { get => default; } // 0x0000000185FE76E0-0x0000000185FE7700 
		public static Vector2 right { get => default; } // 0x0000000185FE7720-0x0000000185FE7740 
		public static Vector2 positiveInfinity { get => default; } // 0x000000018BEE4374-0x000000018BEE43B8 
		public static Vector2 negativeInfinity { get => default; } // 0x000000018BEE42FC-0x000000018BEE4344 
	
		// Constructors
		public Vector2(float x, float y) : this() {
			this.x = default;
			this.y = default;
		} // 0x0000000185FB1970-0x0000000185FB1980
		static Vector2() {
			positiveInfinityVector = default;
			negativeInfinityVector = default;
		} // 0x0000000185F85C10-0x0000000185F85C70
	
		// Methods
		public void Set(float newX, float newY) {} // 0x0000000185FB1970-0x0000000185FB1980
		public static Vector2 Lerp(Vector2 a, Vector2 b, float t) => default; // 0x000000018BEE3E50-0x000000018BEE3EA0
		public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) => default; // 0x0000000185FE7590-0x0000000185FE75E0
		public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) => default; // 0x000000018BEE3F08-0x000000018BEE4020
		public static Vector2 Scale(Vector2 a, Vector2 b) => default; // 0x0000000185FD4100-0x0000000185FD4140
		public void Scale(Vector2 scale) {} // 0x0000000185FE7670-0x0000000185FE76A0
		public void Normalize() {} // 0x000000018BEE4020-0x000000018BEE4090
		public override string ToString() => default; // 0x000000018BEE40A0-0x000000018BEE40B0
		public string ToString(string format) => default; // 0x000000018BEE4090-0x000000018BEE40A0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEE40B0-0x000000018BEE41F8
		public override int GetHashCode() => default; // 0x0000000186EED27C-0x0000000186EED4DC
		public override bool Equals(object other) => default; // 0x000000018BEE3DE4-0x000000018BEE3E50
		public bool Equals(Vector2 other) => default; // 0x000000018B631440-0x000000018B631468
		public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal) => default; // 0x0000000185FE7610-0x0000000185FE7670
		public static Vector2 Perpendicular(Vector2 inDirection) => default; // 0x0000000185FE75E0-0x0000000185FE7610
		public static float Dot(Vector2 lhs, Vector2 rhs) => default; // 0x0000000185FE7560-0x0000000185FE7590
		public static float Angle(Vector2 from, Vector2 to) => default; // 0x000000018BEE3B84-0x000000018BEE3C80
		public static float SignedAngle(Vector2 from, Vector2 to) => default; // 0x00000001840F74D0-0x00000001840F76E0
		public static float Distance(Vector2 a, Vector2 b) => default; // 0x000000018BEE3D64-0x000000018BEE3DE4
		public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) => default; // 0x000000018BEE3C80-0x000000018BEE3D64
		public static float SqrMagnitude(Vector2 a) => default; // 0x0000000185FB5650-0x0000000185FB5670
		public float SqrMagnitude() => default; // 0x0000000185FE76A0-0x0000000185FE76C0
		public static Vector2 Min(Vector2 lhs, Vector2 rhs) => default; // 0x000000018BEE3ED4-0x000000018BEE3F08
		public static Vector2 Max(Vector2 lhs, Vector2 rhs) => default; // 0x000000018BEE3EA0-0x000000018BEE3ED4
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed) => default; // 0x0000000186EED4DC-0x0000000186EED554
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime) => default; // 0x0000000186EED554-0x0000000186EED838
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) => default; // 0x0000000184CB56B0-0x0000000184CB5930
		public static Vector2 operator +(Vector2 a, Vector2 b) => default; // 0x0000000185FD4060-0x0000000185FD40A0
		public static Vector2 operator -(Vector2 a, Vector2 b) => default; // 0x0000000185FD4170-0x0000000185FD41B0
		public static Vector2 operator *(Vector2 a, Vector2 b) => default; // 0x0000000185FD4100-0x0000000185FD4140
		public static Vector2 operator /(Vector2 a, Vector2 b) => default; // 0x000000018B63140C-0x000000018B631440
		public static Vector2 operator -(Vector2 a) => default; // 0x0000000185FE0740-0x0000000185FE0770
		public static Vector2 operator *(Vector2 a, float d) => default; // 0x0000000185FD40D0-0x0000000185FD4100
		public static Vector2 operator *(float d, Vector2 a) => default; // 0x0000000185FE06F0-0x0000000185FE0720
		public static Vector2 operator /(Vector2 a, float d) => default; // 0x000000018B6318F8-0x000000018B63191C
		public static bool operator ==(Vector2 lhs, Vector2 rhs) => default; // 0x000000018BEE43B8-0x000000018BEE43FC
		public static bool operator !=(Vector2 lhs, Vector2 rhs) => default; // 0x000000018BEE43FC-0x000000018BEE440C
		public static implicit operator Vector2(Vector3 v) => default; // 0x0000000185FE6AE0-0x0000000185FE6B00
		public static implicit operator Vector3(Vector2 v) => default; // 0x0000000185FE7760-0x0000000185FE7790
	}

	public struct Vector2Int : IEquatable<Vector2Int>, IFormattable // TypeDefIndex: 47518
	{
		// Fields
		private int m_X; // 0x00
		private int m_Y; // 0x04
		private static readonly Vector2Int s_Zero; // 0x00
		private static readonly Vector2Int s_One; // 0x08
		private static readonly Vector2Int s_Up; // 0x10
		private static readonly Vector2Int s_Down; // 0x18
		private static readonly Vector2Int s_Left; // 0x20
		private static readonly Vector2Int s_Right; // 0x28
	
		// Properties
		public int x { get => default; set {} } // 0x0000000185FE64F0-0x0000000185FE6500 0x00000001818AA390-0x00000001818AA3A0
		public int y { get => default; set {} } // 0x0000000185FCA560-0x0000000185FCA570 0x0000000185FB2BA0-0x0000000185FB2BB0
		public int this[int index] { get => default; set {} } // 0x0000000186ED30F8-0x0000000186ED3248 0x0000000186ED3248-0x0000000186ED32F4
		public float magnitude { get => default; } // 0x0000000185FE7430-0x0000000185FE7460 
		public int sqrMagnitude { get => default; } // 0x0000000185FE7460-0x0000000185FE7470 
		public static Vector2Int zero { get => default; } // 0x000000018BEE3B10-0x000000018BEE3B48 
		public static Vector2Int one { get => default; } // 0x000000018BEE3A68-0x000000018BEE3AA0 
		public static Vector2Int up { get => default; } // 0x000000018BEE3AD8-0x000000018BEE3B10 
		public static Vector2Int down { get => default; } // 0x000000018BEE39F8-0x000000018BEE3A30 
		public static Vector2Int left { get => default; } // 0x000000018BEE3A30-0x000000018BEE3A68 
		public static Vector2Int right { get => default; } // 0x000000018BEE3AA0-0x000000018BEE3AD8 
	
		// Constructors
		public Vector2Int(int x, int y) : this() {
			m_X = default;
			m_Y = default;
		} // 0x000000018357CB90-0x000000018357CBA0
		static Vector2Int() {
			s_Zero = default;
			s_One = default;
			s_Up = default;
			s_Down = default;
			s_Left = default;
			s_Right = default;
		} // 0x0000000185DB0AE0-0x0000000185DB0BD0
	
		// Methods
		public void Set(int x, int y) {} // 0x000000018357CB90-0x000000018357CBA0
		public static float Distance(Vector2Int a, Vector2Int b) => default; // 0x000000018BEE36D8-0x000000018BEE3768
		public static Vector2Int Min(Vector2Int lhs, Vector2Int rhs) => default; // 0x000000018BEE384C-0x000000018BEE3878
		public static Vector2Int Max(Vector2Int lhs, Vector2Int rhs) => default; // 0x000000018BEE3820-0x000000018BEE384C
		public static Vector2Int Scale(Vector2Int a, Vector2Int b) => default; // 0x0000000185FE7410-0x0000000185FE7430
		public void Scale(Vector2Int scale) {} // 0x0000000185FE73F0-0x0000000185FE7410
		public void Clamp(Vector2Int min, Vector2Int max) {} // 0x000000018BEE3658-0x000000018BEE36D8
		public static implicit operator Vector2(Vector2Int v) => default; // 0x0000000185FE74C0-0x0000000185FE74E0
		public static explicit operator Vector3Int(Vector2Int v) => default; // 0x0000000185FE7490-0x0000000185FE74C0
		public static Vector2Int FloorToInt(Vector2 v) => default; // 0x000000018BEE37EC-0x000000018BEE3820
		public static Vector2Int CeilToInt(Vector2 v) => default; // 0x000000018BEE3624-0x000000018BEE3658
		public static Vector2Int RoundToInt(Vector2 v) => default; // 0x000000018BEE3878-0x000000018BEE38AC
		public static Vector2Int operator -(Vector2Int v) => default; // 0x0000000185FE7540-0x0000000185FE7560
		public static Vector2Int operator +(Vector2Int a, Vector2Int b) => default; // 0x0000000185FE7470-0x0000000185FE7490
		public static Vector2Int operator -(Vector2Int a, Vector2Int b) => default; // 0x0000000185FE7520-0x0000000185FE7540
		public static Vector2Int operator *(Vector2Int a, Vector2Int b) => default; // 0x0000000185FE7410-0x0000000185FE7430
		public static Vector2Int operator *(int a, Vector2Int b) => default; // 0x0000000185FE7500-0x0000000185FE7520
		public static Vector2Int operator *(Vector2Int a, int b) => default; // 0x0000000185FE74E0-0x0000000185FE7500
		public static Vector2Int operator /(Vector2Int a, int b) => default; // 0x000000018BEE3B48-0x000000018BEE3B6C
		public static bool operator ==(Vector2Int lhs, Vector2Int rhs) => default; // 0x000000018781C0E8-0x000000018781C100
		public static bool operator !=(Vector2Int lhs, Vector2Int rhs) => default; // 0x000000018BEE3B6C-0x000000018BEE3B84
		public override bool Equals(object other) => default; // 0x000000018BEE377C-0x000000018BEE37EC
		public bool Equals(Vector2Int other) => default; // 0x000000018BEE3768-0x000000018BEE377C
		public override int GetHashCode() => default; // 0x0000000185FE73E0-0x0000000185FE73F0
		public override string ToString() => default; // 0x000000018BEE39D8-0x000000018BEE39E8
		public string ToString(string format) => default; // 0x000000018BEE39E8-0x000000018BEE39F8
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEE38AC-0x000000018BEE39D8
	}

	public struct Vector3Int : IEquatable<Vector3Int>, IFormattable // TypeDefIndex: 47519
	{
		// Fields
		private int m_X; // 0x00
		private int m_Y; // 0x04
		private int m_Z; // 0x08
		private static readonly Vector3Int s_Zero; // 0x00
		private static readonly Vector3Int s_One; // 0x0C
		private static readonly Vector3Int s_Up; // 0x18
		private static readonly Vector3Int s_Down; // 0x24
		private static readonly Vector3Int s_Left; // 0x30
		private static readonly Vector3Int s_Right; // 0x3C
		private static readonly Vector3Int s_Forward; // 0x48
		private static readonly Vector3Int s_Back; // 0x54
	
		// Properties
		public int x { get => default; set {} } // 0x0000000185FE64F0-0x0000000185FE6500 0x00000001818AA390-0x00000001818AA3A0
		public int y { get => default; set {} } // 0x0000000185FCA560-0x0000000185FCA570 0x0000000185FB2BA0-0x0000000185FB2BB0
		public int z { get => default; set {} } // 0x00000001835DC780-0x00000001835DC790 0x0000000185FB2B90-0x0000000185FB2BA0
		public int this[int index] { get => default; set {} } // 0x00000001882587B8-0x00000001882588B8 0x00000001882588B8-0x00000001882589BC
		public float magnitude { get => default; } // 0x0000000185FE77A0-0x0000000185FE77E0 
		public static Vector3Int zero { get => default; } // 0x000000018BEE4824-0x000000018BEE4870 
		public static Vector3Int one { get => default; } // 0x000000018BEE478C-0x000000018BEE47D8 
		public static Vector3Int up { get => default; } // 0x000000018BEE47D8-0x000000018BEE4824 
		public static Vector3Int down { get => default; } // 0x000000018BEE4740-0x000000018BEE478C 
	
		// Constructors
		public Vector3Int(int x, int y) : this() {
			m_X = default;
			m_Y = default;
			m_Z = default;
		} // 0x0000000185FE7790-0x0000000185FE77A0
		public Vector3Int(int x, int y, int z) : this() {
			m_X = default;
			m_Y = default;
			m_Z = default;
		} // 0x0000000185FB0130-0x0000000185FB0140
		static Vector3Int() {
			s_Zero = default;
			s_One = default;
			s_Up = default;
			s_Down = default;
			s_Left = default;
			s_Right = default;
			s_Forward = default;
			s_Back = default;
		} // 0x0000000185D55E40-0x0000000185D55F90
	
		// Methods
		public static float Distance(Vector3Int a, Vector3Int b) => default; // 0x00000001882A6800-0x00000001882A828C
		public static Vector3Int Min(Vector3Int lhs, Vector3Int rhs) => default; // 0x000000018BEE4584-0x000000018BEE45CC
		public static Vector3Int Max(Vector3Int lhs, Vector3Int rhs) => default; // 0x000000018BEE453C-0x000000018BEE4584
		public static implicit operator Vector3(Vector3Int v) => default; // 0x0000000185FE77E0-0x0000000185FE7810
		public static Vector3Int operator +(Vector3Int a, Vector3Int b) => default; // 0x000000018410B210-0x000000018410B250
		public static Vector3Int operator -(Vector3Int a, Vector3Int b) => default; // 0x0000000185704720-0x0000000185704760
		public static Vector3Int operator *(Vector3Int a, int b) => default; // 0x0000000184CEC630-0x0000000184CEC6C0
		public static Vector3Int operator *(int a, Vector3Int b) => default; // 0x0000000185FE7810-0x0000000185FE7850
		public static Vector3Int operator /(Vector3Int a, int b) => default; // 0x000000018BEE4870-0x000000018BEE48A8
		public static bool operator ==(Vector3Int lhs, Vector3Int rhs) => default; // 0x000000018BEE48A8-0x000000018BEE48C8
		public static bool operator !=(Vector3Int lhs, Vector3Int rhs) => default; // 0x000000018BEE48C8-0x000000018BEE4904
		public override bool Equals(object other) => default; // 0x000000018BEE4480-0x000000018BEE4500
		public bool Equals(Vector3Int other) => default; // 0x000000018BEE4500-0x000000018BEE453C
		public override int GetHashCode() => default; // 0x00000001841E2730-0x00000001841E2760
		public override string ToString() => default; // 0x000000018BEE45CC-0x000000018BEE45DC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEE45DC-0x000000018BEE4740
	}

	public struct Vector4 : IEquatable<Vector4>, IFormattable // TypeDefIndex: 47520
	{
		// Fields
		public const float kEpsilon = 1E-05f; // Metadata: 0x02060833
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
		private static readonly Vector4 positiveInfinityVector; // 0x00
		private static readonly Vector4 negativeInfinityVector; // 0x10
	
		// Properties
		public float this[int index] { get => default; set {} } // 0x000000018BEE60DC-0x000000018BEE6168 0x000000018BEE6358-0x000000018BEE63E4
		public Vector4 normalized { get => default; } // 0x000000018BEE6220-0x000000018BEE6258 
		public float magnitude { get => default; } // 0x000000018BEE6168-0x000000018BEE61DC 
		public float sqrMagnitude { get => default; } // 0x000000018BEE5EEC-0x000000018BEE5F14 
		public static Vector4 zero { get => default; } // 0x0000000185FE6E80-0x0000000185FE6E90 
		public static Vector4 one { get => default; } // 0x0000000185FE6F20-0x0000000185FE6F30 
		public static Vector4 positiveInfinity { get => default; } // 0x000000018BEE6258-0x000000018BEE629C 
		public static Vector4 negativeInfinity { get => default; } // 0x000000018BEE61DC-0x000000018BEE6220 
	
		// Constructors
		public Vector4(float x, float y, float z, float w) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000185FB2B40-0x0000000185FB2B60
		public Vector4(float x, float y, float z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
			w = default;
		} // 0x0000000185FE7A50-0x0000000185FE7A70
		public Vector4(float x, float y) : this() {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000185FCEE40-0x0000000185FCEE50
		static Vector4() {
			positiveInfinityVector = default;
			negativeInfinityVector = default;
		} // 0x0000000185F7C600-0x0000000185F7C660
	
		// Methods
		public void Set(float newX, float newY, float newZ, float newW) {} // 0x0000000185FB2B40-0x0000000185FB2B60
		public static Vector4 Lerp(Vector4 a, Vector4 b, float t) => default; // 0x000000018BEDFD5C-0x000000018BEDFDE4
		public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t) => default; // 0x0000000185FE6D30-0x0000000185FE6DB0
		public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta) => default; // 0x000000018BEE5C38-0x000000018BEE5DD4
		public static Vector4 Scale(Vector4 a, Vector4 b) => default; // 0x0000000185FE6F90-0x0000000185FE6FF0
		public void Scale(Vector4 scale) {} // 0x0000000185FE7A10-0x0000000185FE7A50
		public override int GetHashCode() => default; // 0x0000000186DA5918-0x0000000186DA5984
		public override bool Equals(object other) => default; // 0x000000018BEE5A9C-0x000000018BEE5B14
		public bool Equals(Vector4 other) => default; // 0x0000000184A6EB60-0x0000000184A6EBA0
		public static Vector4 Normalize(Vector4 a) => default; // 0x000000018BEE5DD4-0x000000018BEE5E74
		public void Normalize() {} // 0x0000000186EEDB0C-0x0000000186EEDC84
		public static float Dot(Vector4 a, Vector4 b) => default; // 0x0000000183F917E0-0x0000000183F91820
		public static Vector4 Project(Vector4 a, Vector4 b) => default; // 0x000000018BEE5E74-0x000000018BEE5EEC
		public static float Distance(Vector4 a, Vector4 b) => default; // 0x000000018BEE5A5C-0x000000018BEE5A9C
		public static float Magnitude(Vector4 a) => default; // 0x000000018BEE5B14-0x000000018BEE5B88
		public static Vector4 Min(Vector4 lhs, Vector4 rhs) => default; // 0x000000018BEE5BE0-0x000000018BEE5C38
		public static Vector4 Max(Vector4 lhs, Vector4 rhs) => default; // 0x000000018BEE5B88-0x000000018BEE5BE0
		public static Vector4 operator +(Vector4 a, Vector4 b) => default; // 0x00000001846E4F00-0x00000001846E4F60
		public static Vector4 operator -(Vector4 a, Vector4 b) => default; // 0x00000001846E5380-0x00000001846E53E0
		public static Vector4 operator -(Vector4 a) => default; // 0x00000001844020A0-0x00000001844020C0
		public static Vector4 operator *(Vector4 a, float d) => default; // 0x0000000183FB3A20-0x0000000183FB3A70
		public static Vector4 operator *(float d, Vector4 a) => default; // 0x0000000185FE6F40-0x0000000185FE6F90
		public static Vector4 operator /(Vector4 a, float d) => default; // 0x000000018BEE003C-0x000000018BEE005C
		public static bool operator ==(Vector4 lhs, Vector4 rhs) => default; // 0x000000018BEE629C-0x000000018BEE62F0
		public static bool operator !=(Vector4 lhs, Vector4 rhs) => default; // 0x000000018BEE62F0-0x000000018BEE6358
		public static implicit operator Vector4(Vector3 v) => default; // 0x00000001845E8BE0-0x00000001845E8C30
		public static implicit operator Vector3(Vector4 v) => default; // 0x0000000185FE7A70-0x0000000185FE7A90
		public static implicit operator Vector4(Vector2 v) => default; // 0x0000000185FE7A90-0x0000000185FE7AD0
		public static implicit operator Vector2(Vector4 v) => default; // 0x0000000185FE6AE0-0x0000000185FE6B00
		public override string ToString() => default; // 0x000000018BEE60CC-0x000000018BEE60DC
		public string ToString(string format) => default; // 0x000000018BEE60BC-0x000000018BEE60CC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEE5F14-0x000000018BEE60BC
		public static float SqrMagnitude(Vector4 a) => default; // 0x000000018BEE5EEC-0x000000018BEE5F14
		public float SqrMagnitude() => default; // 0x000000018BEE5EEC-0x000000018BEE5F14
	}

	public struct Vector4Int : IEquatable<Vector4Int>, IFormattable // TypeDefIndex: 47521
	{
		// Fields
		private int m_X; // 0x00
		private int m_Y; // 0x04
		private int m_Z; // 0x08
		private int m_W; // 0x0C
		private static readonly Vector4Int s_Zero; // 0x00
		private static readonly Vector4Int s_One; // 0x10
	
		// Properties
		public int x { get => default; set {} } // 0x0000000185FE64F0-0x0000000185FE6500 0x00000001818AA390-0x00000001818AA3A0
		public int y { get => default; set {} } // 0x0000000185FCA560-0x0000000185FCA570 0x0000000185FB2BA0-0x0000000185FB2BB0
		public int z { get => default; set {} } // 0x00000001835DC780-0x00000001835DC790 0x0000000185FB2B90-0x0000000185FB2BA0
		public int w { get => default; set {} } // 0x0000000185FC9070-0x0000000185FC9080 0x0000000185FB6960-0x0000000185FB6970
		public static Vector4Int zero { get => default; } // 0x0000000183F87A30-0x0000000183F87DD0 
	
		// Constructors
		public Vector4Int(int x, int y, int z, int w) : this() {
			m_X = default;
			m_Y = default;
			m_Z = default;
			m_W = default;
		} // 0x0000000185FB2C50-0x0000000185FB2C70
		static Vector4Int() {
			s_Zero = default;
			s_One = default;
		} // 0x0000000185F80340-0x0000000185F803A0
	
		// Methods
		public static bool operator ==(Vector4Int lhs, Vector4Int rhs) => default; // 0x00000001887000F4-0x000000018870018C
		public override bool Equals(object other) => default; // 0x000000018BEE5808-0x000000018BEE5888
		public bool Equals(Vector4Int other) => default; // 0x000000018BEE5888-0x000000018BEE58B0
		public override int GetHashCode() => default; // 0x0000000185FE79D0-0x0000000185FE7A10
		public override string ToString() => default; // 0x000000018BEE58B0-0x000000018BEE58C0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BEE58C0-0x000000018BEE5A5C
	}

	internal interface IPlayerEditorConnectionNative // TypeDefIndex: 47522
	{
		// Methods
		void Initialize();
		void DisconnectAll();
		void SendMessage(Guid messageId, byte[] data, int playerId);
		bool TrySendMessage(Guid messageId, byte[] data, int playerId);
		void Poll();
		void RegisterInternal(Guid messageId);
		void UnregisterInternal(Guid messageId);
		bool IsConnected();
	}

	internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 47523
	{
		// Constructors
		public PlayerConnectionInternal() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		void IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) {} // 0x000000018BEE21DC-0x000000018BEE22DC
		bool IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) => default; // 0x000000018BEE22DC-0x000000018BEE23DC
		void IPlayerEditorConnectionNative.Poll() {} // 0x000000018BEE2188-0x000000018BEE2190
		void IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) {} // 0x000000018BEE2190-0x000000018BEE21DC
		void IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) {} // 0x000000018BEE23DC-0x000000018BEE2428
		void IPlayerEditorConnectionNative.Initialize() {} // 0x000000018BEE2174-0x000000018BEE217C
		bool IPlayerEditorConnectionNative.IsConnected() => default; // 0x000000018BEE217C-0x000000018BEE2188
		void IPlayerEditorConnectionNative.DisconnectAll() {} // 0x000000018BEE216C-0x000000018BEE2174
		private static bool IsConnected() => default; // 0x000000018BEE2038-0x000000018BEE2064
		private static void Initialize() {} // 0x000000018BEE200C-0x000000018BEE2038
		private static void RegisterInternal(string messageId) {} // 0x000000018BEE2090-0x000000018BEE20C4
		private static void UnregisterInternal(string messageId) {} // 0x000000018BEE2428-0x000000018BEE245C
		private static void SendMessage(string messageId, byte[] data, int playerId) {} // 0x000000018BEE20C4-0x000000018BEE2118
		private static bool TrySendMessage(string messageId, byte[] data, int playerId) => default; // 0x000000018BEE2118-0x000000018BEE216C
		private static void PollInternal() {} // 0x000000018BEE2064-0x000000018BEE2090
		private static void DisconnectAll() {} // 0x000000018BEE1FE0-0x000000018BEE200C
	}

	public class PlayerPrefsException : Exception // TypeDefIndex: 47524
	{
		// Constructors
		public PlayerPrefsException() {} // Dummy constructor
		public PlayerPrefsException(string error) {} // 0x000000018BEE245C-0x000000018BEE24B8
	}

	public class PlayerPrefs // TypeDefIndex: 47525
	{
		// Constructors
		public PlayerPrefs() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static bool TrySetInt(string key, int value) => default; // 0x0000000185F61D10-0x0000000185F61D60
		private static bool TrySetFloat(string key, float value) => default; // 0x000000018BEE2584-0x000000018BEE25C8
		private static bool TrySetSetString(string key, string value) => default; // 0x00000001855A6630-0x00000001855A6680
		public static void SetInt(string key, int value) {} // 0x0000000185F61CF0-0x0000000185F61D10
		public static int GetInt(string key, int defaultValue) => default; // 0x00000001845C7040-0x00000001845C7090
		public static int GetInt(string key) => default; // 0x000000018646E444-0x000000018646E450
		public static void SetFloat(string key, float value) {} // 0x000000018BEE2518-0x000000018BEE2584
		public static float GetFloat(string key, float defaultValue) => default; // 0x0000000185B6E790-0x0000000185B6E7E0
		public static float GetFloat(string key) => default; // 0x0000000186474354-0x0000000186474364
		public static void SetString(string key, string value) {} // 0x00000001855A6610-0x00000001855A6630
		public static string GetString(string key, string defaultValue) => default; // 0x000000018525C2D0-0x000000018525C320
		public static string GetString(string key) => default; // 0x000000018525C290-0x000000018525C2D0
		public static bool HasKey(string key) => default; // 0x0000000184247BF0-0x0000000184247C30
		public static void DeleteKey(string key) {} // 0x000000018BEE24E4-0x000000018BEE2518
		public static void DeleteAll() {} // 0x000000018BEE24B8-0x000000018BEE24E4
		public static void Save() {} // 0x00000001855A6680-0x00000001855A66C0
	}

	public abstract class PropertyAttribute : Attribute // TypeDefIndex: 47526
	{
		// Constructors
		protected PropertyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ContextMenuItemAttribute : PropertyAttribute // TypeDefIndex: 47527
	{
		// Fields
		public readonly string name; // 0x10
		public readonly string function; // 0x18
	
		// Constructors
		public ContextMenuItemAttribute() {} // Dummy constructor
		public ContextMenuItemAttribute(string name, string function) {} // 0x00000001841BC230-0x00000001841BC260
	}

	public class InspectorNameAttribute : PropertyAttribute // TypeDefIndex: 47528
	{
		// Fields
		public readonly string displayName; // 0x10
	
		// Constructors
		public InspectorNameAttribute() {} // Dummy constructor
		public InspectorNameAttribute(string displayName) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class TooltipAttribute : PropertyAttribute // TypeDefIndex: 47529
	{
		// Fields
		public readonly string tooltip; // 0x10
	
		// Constructors
		public TooltipAttribute() {} // Dummy constructor
		public TooltipAttribute(string tooltip) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class SpaceAttribute : PropertyAttribute // TypeDefIndex: 47530
	{
		// Fields
		public readonly float height; // 0x10
	
		// Constructors
		public SpaceAttribute() {} // 0x0000000185FE73B0-0x0000000185FE73C0
		public SpaceAttribute(float height) {} // 0x0000000181A6E380-0x0000000181A6E390
	}

	public class HeaderAttribute : PropertyAttribute // TypeDefIndex: 47531
	{
		// Fields
		public readonly string header; // 0x10
	
		// Constructors
		public HeaderAttribute() {} // Dummy constructor
		public HeaderAttribute(string header) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public sealed class RangeAttribute : PropertyAttribute // TypeDefIndex: 47532
	{
		// Fields
		public readonly float min; // 0x10
		public readonly float max; // 0x14
	
		// Constructors
		public RangeAttribute() {} // Dummy constructor
		public RangeAttribute(float min, float max) {} // 0x0000000185FBF890-0x0000000185FBF8A0
	}

	public sealed class MinAttribute : PropertyAttribute // TypeDefIndex: 47533
	{
		// Fields
		public readonly float min; // 0x10
	
		// Constructors
		public MinAttribute() {} // Dummy constructor
		public MinAttribute(float min) {} // 0x0000000181A6E380-0x0000000181A6E390
	}

	public sealed class MultilineAttribute : PropertyAttribute // TypeDefIndex: 47534
	{
		// Fields
		public readonly int lines; // 0x10
	
		// Constructors
		public MultilineAttribute() {} // 0x0000000185FE73A0-0x0000000185FE73B0
		public MultilineAttribute(int lines) {} // 0x0000000181378230-0x0000000181378240
	}

	public sealed class TextAreaAttribute : PropertyAttribute // TypeDefIndex: 47535
	{
		// Fields
		public readonly int minLines; // 0x10
		public readonly int maxLines; // 0x14
	
		// Constructors
		public TextAreaAttribute() {} // 0x0000000185FE73D0-0x0000000185FE73E0
		public TextAreaAttribute(int minLines, int maxLines) {} // 0x0000000185FB2190-0x0000000185FB21A0
	}

	public sealed class ColorUsageAttribute : PropertyAttribute // TypeDefIndex: 47536
	{
		// Fields
		public readonly bool showAlpha; // 0x10
		public readonly bool hdr; // 0x11
		public readonly float minBrightness; // 0x14
		public readonly float maxBrightness; // 0x18
		public readonly float minExposureValue; // 0x1C
		public readonly float maxExposureValue; // 0x20
	
		// Constructors
		public ColorUsageAttribute() {} // Dummy constructor
		public ColorUsageAttribute(bool showAlpha) {} // 0x0000000185FE6CC0-0x0000000185FE6CF0
		public ColorUsageAttribute(bool showAlpha, bool hdr) {} // 0x0000000185FE6C90-0x0000000185FE6CC0
	}

	internal class PropertyNameUtils // TypeDefIndex: 47537
	{
		// Constructors
		public PropertyNameUtils() {} // Dummy constructor
	
		// Methods
		public static PropertyName PropertyNameFromString(string name) => default; // 0x000000018BEE260C-0x000000018BEE2630
		private static void PropertyNameFromString_Injected(string name, out PropertyName ret) {
			ret = default;
		} // 0x000000018BEE25C8-0x000000018BEE260C
	}

	public struct PropertyName : IEquatable<PropertyName> // TypeDefIndex: 47538
	{
		// Fields
		internal int id; // 0x00
	
		// Constructors
		public PropertyName(string name) {
			id = default;
		} // 0x000000018BEE26F4-0x000000018BEE2714
		public PropertyName(PropertyName other) {
			id = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
	
		// Methods
		public static bool IsNullOrEmpty(PropertyName prop) => default; // 0x00000001878A7D38-0x00000001878A7D40
		public static bool operator ==(PropertyName lhs, PropertyName rhs) => default; // 0x0000000188645D08-0x0000000188645D10
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public override bool Equals(object other) => default; // 0x000000018BEE2630-0x000000018BEE2694
		public bool Equals(PropertyName other) => default; // 0x0000000183FAA6E0-0x0000000183FAA6F0
		public static implicit operator PropertyName(string name) => default; // 0x000000018BEE2714-0x000000018BEE2720
		public override string ToString() => default; // 0x000000018BEE2694-0x000000018BEE26F4
	}

	public static class Random // TypeDefIndex: 47540
	{
		// Properties
		public static State state { get; set; } // 0x000000018BEE3234-0x000000018BEE3254 0x000000018BEE32B4-0x000000018BEE32C4
		public static float value { get; } // 0x000000018BEE3254-0x000000018BEE3280 
		public static Vector3 insideUnitSphere { get; } // 0x000000018BEE3188-0x000000018BEE31AC 
		public static Vector2 insideUnitCircle { get; } // 0x000000018BEE3130-0x000000018BEE3154 
		public static Quaternion rotation { get; } // 0x000000018BEE31E0-0x000000018BEE3200 
	
		// Nested types
		[Serializable]
		public struct State // TypeDefIndex: 47539
		{
			// Fields
			private int s0; // 0x00
			private int s1; // 0x04
			private int s2; // 0x08
			private int s3; // 0x0C
		}
	
		// Methods
		public static void InitState(int seed) {} // 0x000000018BEE30FC-0x000000018BEE3130
		public static float Range(float minInclusive, float maxInclusive) => default; // 0x0000000184CE8830-0x0000000184CE8890
		public static int Range(int minInclusive, int maxExclusive) => default; // 0x000000018646F110-0x000000018646F15C
		private static int RandomRangeInt(int minInclusive, int maxExclusive) => default; // 0x0000000185689550-0x00000001856895A0
		private static void GetRandomUnitCircle(out Vector2 output) {
			output = default;
		} // 0x000000018BEE30C8-0x000000018BEE30FC
		public static UnityEngine.Color ColorHSV() => default; // 0x000000018BEE3070-0x000000018BEE30C8
		public static UnityEngine.Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) => default; // 0x000000018BEE2F58-0x000000018BEE3070
		private static void get_state_Injected(out State ret) {
			ret = default;
		} // 0x000000018BEE3200-0x000000018BEE3234
		private static void set_state_Injected(ref State value) {} // 0x000000018BEE3280-0x000000018BEE32B4
		private static void get_insideUnitSphere_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEE3154-0x000000018BEE3188
		private static void get_rotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x000000018BEE31AC-0x000000018BEE31E0
	}

	public class ResourceRequest : AsyncOperation // TypeDefIndex: 47541
	{
		// Fields
		internal string m_Path; // 0x20
		internal System.Type m_Type; // 0x28
	
		// Constructors
		public ResourceRequest() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected virtual UnityEngine.Object GetResult() => default; // 0x000000018BEEC170-0x000000018BEEC184
	}

	internal static class ResourcesAPIInternal // TypeDefIndex: 47542
	{
		// Methods
		public static UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type) => default; // 0x0000000185F9CAF0-0x0000000185F9CB30
		public static Shader FindShaderByName(string name) => default; // 0x0000000185F7DBF0-0x0000000185F7DC30
		public static UnityEngine.Object Load(string path, System.Type systemTypeInstance) => default; // 0x0000000185BAD6F0-0x0000000185BAD740
		public static UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance) => default; // 0x000000018BEEC184-0x000000018BEEC1C8
		internal static ResourceRequest LoadAsyncInternal(string path, System.Type type) => default; // 0x000000018BEEC1C8-0x000000018BEEC20C
		public static void UnloadAsset(UnityEngine.Object assetToUnload) {} // 0x000000018BEEC20C-0x000000018BEEC240
	}

	public class ResourcesAPI // TypeDefIndex: 47543
	{
		// Fields
		private static ResourcesAPI s_DefaultAPI; // 0x00
		private static ResourcesAPI _overrideAPI_k__BackingField; // 0x08
	
		// Properties
		internal static ResourcesAPI ActiveAPI { get => default; } // 0x0000000185625520-0x00000001856255E0 
		public static ResourcesAPI overrideAPI { get; } // 0x000000018BEEC2B4-0x000000018BEEC304 
	
		// Constructors
		protected internal ResourcesAPI() {} // 0x0000000185492010-0x0000000185492020
		static ResourcesAPI() {} // 0x0000000185F79BD0-0x0000000185F79C30
	
		// Methods
		protected internal virtual UnityEngine.Object[] FindObjectsOfTypeAll(System.Type systemTypeInstance) => default; // 0x00000001864741E0-0x00000001864741EC
		protected internal virtual Shader FindShaderByName(string name) => default; // 0x00000001864741EC-0x00000001864741F8
		protected internal virtual UnityEngine.Object Load(string path, System.Type systemTypeInstance) => default; // 0x00000001864741F8-0x000000018647420C
		protected internal virtual UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance) => default; // 0x000000018BEEC240-0x000000018BEEC254
		protected internal virtual ResourceRequest LoadAsync(string path, System.Type systemTypeInstance) => default; // 0x000000018BEEC254-0x000000018BEEC2A8
		protected internal virtual void UnloadAsset(UnityEngine.Object assetToUnload) {} // 0x000000018BEEC2A8-0x000000018BEEC2B4
	}

	public sealed class Resources // TypeDefIndex: 47545
	{
		// Nested types
		public enum ResourcesCPUAffinity // TypeDefIndex: 47544
		{
			kPCoreAffinity = 0,
			kECoreAffinity = 1
		}
	
		// Constructors
		public Resources() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal static T[] ConvertObjects<T>(UnityEngine.Object[] rawObjects)
			where T : UnityEngine.Object => default;
		public static UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type) => default; // 0x0000000185625200-0x0000000185625260
		public static T[] FindObjectsOfTypeAll<T>()
			where T : UnityEngine.Object => default;
		public static UnityEngine.Object Load(string path) => default; // 0x0000000185625390-0x0000000185625410
		public static T Load<T>(string path)
			where T : UnityEngine.Object => default;
		public static UnityEngine.Object Load(string path, System.Type systemTypeInstance) => default; // 0x00000001856254B0-0x0000000185625520
		public static ResourceRequest LoadAsync(string path) => default; // 0x000000018BEEC66C-0x000000018BEEC6D8
		public static ResourceRequest LoadAsync<T>(string path)
			where T : UnityEngine.Object => default;
		public static ResourceRequest LoadAsync(string path, System.Type type) => default; // 0x000000018BEEC604-0x000000018BEEC66C
		public static UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance) => default; // 0x000000018BEEC5A0-0x000000018BEEC604
		public static UnityEngine.Object[] LoadAll(string path) => default; // 0x000000018BEEC534-0x000000018BEEC5A0
		public static T[] LoadAll<T>(string path)
			where T : UnityEngine.Object => default;
		public static UnityEngine.Object GetBuiltinResource(System.Type type, string path) => default; // 0x000000018BEEC330-0x000000018BEEC374
		public static T GetBuiltinResource<T>(string path)
			where T : UnityEngine.Object => default;
		public static void UnloadAsset(UnityEngine.Object assetToUnload) {} // 0x000000018BEEC738-0x000000018BEEC78C
		private static void UnloadAssetImplResourceManager(UnityEngine.Object assetToUnload) {} // 0x000000018BEEC704-0x000000018BEEC738
		public static AsyncOperation UnloadUnusedAssets() => default; // 0x00000001852D5610-0x00000001852D5650
		public static void UpdateCPUAffinity(ResourcesCPUAffinity affinity) {} // 0x000000018BEEC78C-0x000000018BEEC7C0
		public static bool ReferenceChainSnapshot() => default; // 0x000000018BEEC6D8-0x000000018BEEC704
		public static string GetReferenceChainString(UnityEngine.Object targetObject) => default; // 0x000000018BEEC374-0x000000018BEEC3A8
		public static void ClearReferenceChainSnapshot() {} // 0x000000018BEEC304-0x000000018BEEC330
		public static UnityEngine.Object InstanceIDToObject(int instanceID) => default; // 0x0000000185044D00-0x0000000185044D40
		private static void InstanceIDToObjectList(IntPtr instanceIDs, int instanceCount, List<UnityEngine.Object> objects) {} // 0x000000018BEEC4E4-0x000000018BEEC534
		public static void InstanceIDToObjectList(NativeArray<int> instanceIDs, List<UnityEngine.Object> objects) {} // 0x000000018BEEC3A8-0x000000018BEEC4E4
	}

	public class AsyncInstantiateOperation : AsyncOperation // TypeDefIndex: 47546
	{
		// Fields
		internal UnityEngine.Object[] m_Result; // 0x20
	
		// Properties
		public UnityEngine.Object[] Result { get => default; } // 0x0000000185FE66B0-0x0000000185FE66C0 
		internal static float IntegrationTimeMS { set {} } // 0x00000001841CDF40-0x00000001841CDF90
	
		// Constructors
		public AsyncInstantiateOperation() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void WaitForCompletion() {} // 0x000000018BEE6744-0x000000018BEE6778
		public void Cancel() {} // 0x000000018BEE6710-0x000000018BEE6744
		public static void SetIntegrationTimeMS(float integrationTimeMS) {} // 0x00000001841CDEE0-0x00000001841CDF40
	}

	public class AsyncInstantiateOperation<T> : CustomYieldInstruction // TypeDefIndex: 47547
		where T : UnityEngine.Object
	{
		// Fields
		internal AsyncInstantiateOperation m_op;
	
		// Properties
		public override bool keepWaiting { get => default; }
		public bool isDone { get => default; }
		public T[] Result { get => default; }
	
		// Constructors
		public AsyncInstantiateOperation() {} // Dummy constructor
		internal AsyncInstantiateOperation(AsyncInstantiateOperation op) {}
	
		// Methods
		public void WaitForCompletion() {}
		public void Cancel() {}
	}

	internal class AsyncInstantiateOperationHelper // TypeDefIndex: 47548
	{
		// Constructors
		public AsyncInstantiateOperationHelper() {} // Dummy constructor
	
		// Methods
		public static void SetAsyncInstantiateOperationResult(AsyncInstantiateOperation op, UnityEngine.Object[] result) {} // 0x000000018BEE66F0-0x000000018BEE6710
	}

	public class AsyncOperation : YieldInstruction // TypeDefIndex: 47549
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		private Action<AsyncOperation> m_completeCallback; // 0x18
	
		// Properties
		public bool isDone { get => default; } // 0x0000000183FEEEC0-0x0000000183FEEF00 
		public float progress { get => default; } // 0x000000018BEE67E0-0x000000018BEE6814 
		public int priority { get => default; set {} } // 0x0000000184C56E30-0x0000000184C56E70 0x0000000184C56E70-0x0000000184C56EC0
		public bool allowSceneActivation { get => default; set {} } // 0x000000018BEE67AC-0x000000018BEE67E0 0x000000018BEE6814-0x000000018BEE6858
	
		// Constructors
		public AsyncOperation() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static void InternalDestroy(IntPtr ptr) {} // 0x000000018421AC10-0x000000018421AC50
		public bool TryCancel() => default; // 0x000000018BEE6778-0x000000018BEE67AC
		~AsyncOperation() {} // 0x000000018421AB90-0x000000018421AC10
		internal void InvokeCompletionEvent() {} // 0x000000018421AB70-0x000000018421AB90
	}

	internal class AttributeHelperEngine // TypeDefIndex: 47550
	{
		// Fields
		public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x00
		public static ExecuteInEditMode[] _executeInEditModeArray; // 0x08
		public static RequireComponent[] _requireComponentArray; // 0x10
	
		// Constructors
		public AttributeHelperEngine() {} // Dummy constructor
		static AttributeHelperEngine() {} // 0x000000018BEE6DF0-0x000000018BEE6EE4
	
		// Methods
		private static System.Type GetParentTypeDisallowingMultipleInclusion(System.Type type) => default; // 0x000000018BEE6A48-0x000000018BEE6B24
		private static System.Type[] GetRequiredComponents(System.Type klass) => default; // 0x000000018BEE6B24-0x000000018BEE6DF0
		private static int GetExecuteMode(System.Type klass) => default; // 0x000000018BEE6964-0x000000018BEE6A48
		private static int CheckIsEditorScript(System.Type klass) => default; // 0x000000018BEE6858-0x000000018BEE68FC
		private static int GetDefaultExecutionOrderFor(System.Type klass) => default; // 0x000000018BEE68FC-0x000000018BEE6964
		private static T GetCustomAttributeOfType<T>(System.Type klass)
			where T : Attribute => default;
	}

	public sealed class DisallowMultipleComponent : Attribute // TypeDefIndex: 47551
	{
		// Constructors
		public DisallowMultipleComponent() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class RequireComponent : Attribute // TypeDefIndex: 47552
	{
		// Fields
		public System.Type m_Type0; // 0x10
		public System.Type m_Type1; // 0x18
		public System.Type m_Type2; // 0x20
	
		// Constructors
		public RequireComponent() {} // Dummy constructor
		public RequireComponent(System.Type requiredComponent) {} // 0x0000000184096E30-0x0000000184096EF0
		public RequireComponent(System.Type requiredComponent, System.Type requiredComponent2) {} // 0x0000000185FA9060-0x0000000185FA9090
	}

	public sealed class AddComponentMenu : Attribute // TypeDefIndex: 47553
	{
		// Fields
		private string m_AddComponentMenu; // 0x10
		private int m_Ordering; // 0x18
	
		// Constructors
		public AddComponentMenu() {} // Dummy constructor
		public AddComponentMenu(string menuName) {} // 0x0000000185990F90-0x0000000185990FC0
		public AddComponentMenu(string menuName, int order) {} // 0x00000001845D7850-0x00000001845D7870
	}

	public sealed class CreateAssetMenuAttribute : Attribute // TypeDefIndex: 47554
	{
		// Fields
		private string _menuName_k__BackingField; // 0x10
		private string _fileName_k__BackingField; // 0x18
		private int _order_k__BackingField; // 0x20
	
		// Properties
		public string menuName { get; set; } // 0x0000000184096E30-0x0000000184096EF0
		public string fileName { get; set; } // 0x0000000184088E70-0x0000000184088E80
		public int order { get; set; } // 0x00000001813B9430-0x00000001813B9440
	
		// Constructors
		public CreateAssetMenuAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class ContextMenu : Attribute // TypeDefIndex: 47555
	{
		// Fields
		public readonly string menuItem; // 0x10
		public readonly bool validate; // 0x18
		public readonly int priority; // 0x1C
	
		// Constructors
		public ContextMenu() {} // Dummy constructor
		public ContextMenu(string itemName) {} // 0x000000018BEE7F14-0x000000018BEE7F20
		public ContextMenu(string itemName, bool isValidateFunction) {} // 0x000000018BEE7EF4-0x000000018BEE7F14
		public ContextMenu(string itemName, bool isValidateFunction, int priority) {} // 0x000000018B5BE6F4-0x000000018B5BE71C
	}

	public sealed class ExecuteInEditMode : Attribute // TypeDefIndex: 47556
	{
		// Constructors
		public ExecuteInEditMode() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class ExecuteAlways : Attribute // TypeDefIndex: 47557
	{
		// Constructors
		public ExecuteAlways() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class HideInInspector : Attribute // TypeDefIndex: 47558
	{
		// Constructors
		public HideInInspector() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HelpURLAttribute : Attribute // TypeDefIndex: 47559
	{
		// Fields
		internal readonly string m_Url; // 0x10
		internal readonly bool m_Dispatcher; // 0x18
		internal readonly string m_DispatchingFieldName; // 0x20
	
		// Properties
		public string URL { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public HelpURLAttribute() {} // Dummy constructor
		public HelpURLAttribute(string url) {} // 0x00000001855241F0-0x0000000185524250
	}

	public class DefaultExecutionOrder : Attribute // TypeDefIndex: 47560
	{
		// Fields
		private int m_Order; // 0x10
	
		// Properties
		public int order { get => default; } // 0x0000000185FE6790-0x0000000185FE67A0 
	
		// Constructors
		public DefaultExecutionOrder() {} // Dummy constructor
		public DefaultExecutionOrder(int order) {} // 0x0000000181378230-0x0000000181378240
	}

	public class AssemblyIsEditorAssembly : Attribute // TypeDefIndex: 47561
	{
		// Constructors
		public AssemblyIsEditorAssembly() {} // Dummy constructor
	}

	public class ExcludeFromPresetAttribute : Attribute // TypeDefIndex: 47562
	{
		// Constructors
		public ExcludeFromPresetAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class Behaviour : Component // TypeDefIndex: 47563
	{
		// Properties
		public bool enabled { get => default; set {} } // 0x0000000183FD2CB0-0x0000000183FD2CF0 0x00000001848D1950-0x00000001848D19A0
		public bool isActiveAndEnabled { get => default; } // 0x0000000183FCDC30-0x0000000183FCDD70 
	
		// Constructors
		public Behaviour() {} // 0x000000018646DB20-0x000000018646DB28
	}

	internal struct CastHelper<T> // TypeDefIndex: 47564
	{
		// Fields
		public T t;
		public IntPtr onePointerFurtherThanT;
	}

	internal static class ClassLibraryInitializer // TypeDefIndex: 47565
	{
		// Methods
		private static void Init() {} // 0x000000018BEE70B0-0x000000018BEE70B8
	}

	public class Component : UnityEngine.Object // TypeDefIndex: 47566
	{
		// Properties
		public Transform transform { get => default; } // 0x00000001840E8150-0x00000001840E8190 
		public GameObject gameObject { get => default; } // 0x0000000183FD1750-0x0000000183FD1790 
		public string tag { get => default; set {} } // 0x000000018BEE744C-0x000000018BEE7470 0x000000018BEE7470-0x000000018BEE74A0
	
		// Constructors
		public Component() {} // 0x0000000184DE1440-0x0000000184DE1480
	
		// Methods
		public Component GetComponent(System.Type type) => default; // 0x0000000183FD3150-0x0000000183FD31C0
		public Component GetComponent(System.Type type, int multiComponentIndex) => default; // 0x000000018BEE71EC-0x000000018BEE7218
		public T GetComponent<T>() => default;
		public T GetComponent<T>(int multiComponentIndex) => default;
		internal void GetComponentFastPath(System.Type type, int multiComponentIndex, IntPtr resultValue) {} // 0x0000000183FD32C0-0x0000000183FD3330
		public bool TryGetComponent(System.Type type, out Component component) {
			component = default;
			return default;
		} // 0x000000018BEE740C-0x000000018BEE744C
		public bool TryGetComponent<T>(out ref T component) {
			component = default;
			return default;
		}
		public Component GetComponent(string type) => default; // 0x000000018491FE90-0x000000018491FEE0
		public Component GetComponentInChildren(System.Type t, bool includeInactive) => default; // 0x0000000185076CB0-0x0000000185076CF0
		public Component GetComponentInChildren(System.Type t) => default; // 0x000000018BEE71A8-0x000000018BEE71B8
		public T GetComponentInChildren<T>(bool includeInactive) => default;
		public T GetComponentInChildren<T>() => default;
		public Component[] GetComponentsInChildren(System.Type t, bool includeInactive) => default; // 0x000000018BEE7218-0x000000018BEE7258
		public Component[] GetComponentsInChildren(System.Type t) => default; // 0x000000018BEE7258-0x000000018BEE728C
		public T[] GetComponentsInChildren<T>(bool includeInactive) => default;
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) {}
		public T[] GetComponentsInChildren<T>() => default;
		public void GetComponentsInChildren<T>(List<T> results) {}
		public Component GetComponentInParent(System.Type t, bool includeInactive) => default; // 0x000000018491F750-0x000000018491F7E0
		public Component GetComponentInParent(System.Type t) => default; // 0x000000018BEE71B8-0x000000018BEE71EC
		public T GetComponentInParent<T>(bool includeInactive) => default;
		public T GetComponentInParent<T>() => default;
		public Component[] GetComponentsInParent(System.Type t, bool includeInactive) => default; // 0x000000018BEE728C-0x000000018BEE72CC
		public Component[] GetComponentsInParent(System.Type t) => default; // 0x000000018BEE72CC-0x000000018BEE72DC
		public T[] GetComponentsInParent<T>(bool includeInactive) => default;
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results) {}
		public T[] GetComponentsInParent<T>() => default;
		public Component[] GetComponents(System.Type type) => default; // 0x000000018BEE72DC-0x000000018BEE730C
		private void GetComponentsForListInternal(System.Type searchType, object resultList) {} // 0x000000018473BA00-0x000000018473BA60
		public void GetComponents(System.Type type, List<Component> results) {} // 0x000000018646D528-0x000000018646D530
		public void GetComponents<T>(List<T> results) {}
		public T[] GetComponents<T>() => default;
		public bool CompareTag(string tag) => default; // 0x000000018BEE7178-0x000000018BEE71A8
		public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) {} // 0x000000018BEE730C-0x000000018BEE7370
		public void SendMessageUpwards(string methodName, object value) {} // 0x000000018BEE73B0-0x000000018BEE73CC
		public void SendMessageUpwards(string methodName) {} // 0x000000018BEE7370-0x000000018BEE7390
		public void SendMessageUpwards(string methodName, SendMessageOptions options) {} // 0x000000018BEE7390-0x000000018BEE73B0
		public void SendMessage(string methodName, object value) {} // 0x0000000186472A34-0x0000000186472A50
		public void SendMessage(string methodName) {} // 0x000000018BEE73CC-0x000000018BEE73EC
		public void SendMessage(string methodName, object value, SendMessageOptions options) {} // 0x0000000185D90E60-0x0000000185D90ED0
		public void SendMessage(string methodName, SendMessageOptions options) {} // 0x000000018BEE73EC-0x000000018BEE740C
		public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) {} // 0x000000018BEE70F4-0x000000018BEE7158
		public void BroadcastMessage(string methodName, object parameter) {} // 0x000000018BEE70B8-0x000000018BEE70D4
		public void BroadcastMessage(string methodName) {} // 0x000000018BEE7158-0x000000018BEE7178
		public void BroadcastMessage(string methodName, SendMessageOptions options) {} // 0x000000018BEE70D4-0x000000018BEE70F4
	}

	public sealed class Coroutine : YieldInstruction // TypeDefIndex: 47567
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		private Coroutine() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		~Coroutine() {} // 0x0000000184FEB920-0x0000000184FEB9A0
		private static void ReleaseCoroutine(IntPtr ptr) {} // 0x0000000184FEB9A0-0x0000000184FEB9E0
	}

	internal class SetupCoroutine // TypeDefIndex: 47568
	{
		// Constructors
		public SetupCoroutine() {} // Dummy constructor
	
		// Methods
		public static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress) {} // 0x0000000184BF5170-0x0000000184BF5480
		public static object InvokeMember(object behaviour, string name, object variable) => default; // 0x000000018BEED030-0x000000018BEED104
	}

	public abstract class CustomYieldInstruction : IEnumerator // TypeDefIndex: 47569
	{
		// Properties
		public abstract bool keepWaiting { get; }
		public object Current { get; } // 0x0000000185FE67B0-0x0000000185FE67C0 
	
		// Constructors
		protected CustomYieldInstruction() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool MoveNext() => default; // 0x0000000185682AB0-0x0000000185682AC0
		public virtual void Reset() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ExcludeFromObjectFactoryAttribute : Attribute // TypeDefIndex: 47570
	{
		// Constructors
		public ExcludeFromObjectFactoryAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal sealed class ExtensionOfNativeClassAttribute : Attribute // TypeDefIndex: 47571
	{
		// Constructors
		public ExtensionOfNativeClassAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class FailedToLoadScriptObject : UnityEngine.Object // TypeDefIndex: 47572
	{
		// Constructors
		public FailedToLoadScriptObject() {} // Dummy constructor
	}

	public enum PlatformLayers // TypeDefIndex: 47573
	{
		None = 0,
		PC = 1,
		Mobile = 2,
		Other = 4,
		AllPlatforms = 255
	}

	public sealed class GameObject : UnityEngine.Object // TypeDefIndex: 47574
	{
		// Properties
		public Transform transform { get => default; } // 0x000000018421BA70-0x000000018421BAB0 
		public int layer { get => default; set {} } // 0x000000018421AA70-0x000000018421AAB0 0x0000000184A9B850-0x0000000184A9B980
		public int artTag { get => default; set {} } // 0x0000000185146980-0x00000001851469C0 0x0000000184FB2540-0x0000000184FB2590
		public bool active { get => default; set {} } // 0x000000018BEE8760-0x000000018BEE8794 0x000000018BEE8934-0x000000018BEE8978
		public bool activeSelf { get => default; } // 0x00000001840CEB70-0x00000001840CEBB0 
		public bool activeInHierarchy { get => default; } // 0x000000018421C250-0x000000018421C290 
		public bool isStatic { get => default; set {} } // 0x000000018BEE87FC-0x000000018BEE8830 0x000000018BEE8978-0x000000018BEE89BC
		internal bool isStaticBatchable { get => default; } // 0x000000018BEE87C8-0x000000018BEE87FC 
		public string tag { get => default; set {} } // 0x000000018BEE8900-0x000000018BEE8934 0x00000001848CC8D0-0x00000001848CC920
		public int tagInt { get => default; set {} } // 0x000000018BEE88CC-0x000000018BEE8900 0x000000018BEE89BC-0x000000018BEE89FC
		public Scene scene { get => default; } // 0x000000018BEE88A8-0x000000018BEE88CC 
		public bool isInPreviewScene { get => default; } // 0x000000018BEE8794-0x000000018BEE87C8 
		public ulong sceneCullingMask { get => default; } // 0x000000018BEE8830-0x000000018BEE8864 
		public GameObject gameObject { get => default; } // 0x0000000185FE7B10-0x0000000185FE7B20 
	
		// Constructors
		public GameObject(string name) {} // 0x00000001840F73F0-0x00000001840F7480
		public GameObject() {} // 0x00000001840F57F0-0x00000001840F5840
		public GameObject(string name, System.Type[] components) {} // 0x0000000184A135C0-0x0000000184A13660
	
		// Methods
		public static GameObject CreatePrimitive(PrimitiveType type) => default; // 0x000000018BEE81A0-0x000000018BEE81D4
		public T GetComponent<T>() => default;
		public T GetComponent<T>(int multiComponentIndex) => default;
		public Component GetComponent(System.Type type) => default; // 0x000000018491FEE0-0x000000018491FF10
		public Component GetComponent(System.Type type, int multiComponentIndex) => default; // 0x000000018BEE8304-0x000000018BEE8330
		public Component GetComponentInternal(System.Type type) => default; // 0x000000018BEE82C0-0x000000018BEE8304
		internal void GetComponentFastPath(System.Type type, int multiComponentIndex, IntPtr resultValue) {} // 0x000000018491FFD0-0x0000000184920040
		internal Component GetComponentByName(string type) => default; // 0x000000018539FD60-0x000000018539FDB0
		public Component GetComponent(string type) => default; // 0x0000000186470E38-0x0000000186470E44
		public Component GetComponentInChildren(System.Type type, bool includeInactive) => default; // 0x0000000185076DD0-0x0000000185076E30
		public Component GetComponentInChildren(System.Type type) => default; // 0x000000018BEE82A0-0x000000018BEE82B0
		public T GetComponentInChildren<T>() => default;
		public T GetComponentInChildren<T>(bool includeInactive) => default;
		public Component GetComponentInParent(System.Type type, bool includeInactive) => default; // 0x000000018491F7E0-0x000000018491F840
		public Component GetComponentInParent(System.Type type) => default; // 0x000000018BEE82B0-0x000000018BEE82C0
		public T GetComponentInParent<T>() => default;
		public T GetComponentInParent<T>(bool includeInactive) => default;
		private Array GetComponentsInternal(System.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) => default; // 0x000000018484A9A0-0x000000018484AA30
		public Component[] GetComponents(System.Type type) => default; // 0x000000018BEE83F4-0x000000018BEE8460
		public T[] GetComponents<T>() => default;
		public void GetComponents(System.Type type, List<Component> results) {} // 0x000000018BEE83C8-0x000000018BEE83F4
		public void GetComponents<T>(List<T> results) {}
		public Component[] GetComponentsInChildren(System.Type type) => default; // 0x000000018BEE8330-0x000000018BEE8340
		public Component[] GetComponentsInChildren(System.Type type, bool includeInactive) => default; // 0x000000018484A3B0-0x000000018484A430
		public T[] GetComponentsInChildren<T>(bool includeInactive) => default;
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) {}
		public T[] GetComponentsInChildren<T>() => default;
		public void GetComponentsInChildren<T>(List<T> results) {}
		public Component[] GetComponentsInParent(System.Type type) => default; // 0x000000018BEE8340-0x000000018BEE8350
		public Component[] GetComponentsInParent(System.Type type, bool includeInactive) => default; // 0x000000018BEE8350-0x000000018BEE83C8
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results) {}
		public T[] GetComponentsInParent<T>(bool includeInactive) => default;
		public T[] GetComponentsInParent<T>() => default;
		public bool TryGetComponent<T>(out ref T component) {
			component = default;
			return default;
		}
		public bool TryGetComponent<T>(int multiComponentIndex, out ref T component) {
			component = default;
			return default;
		}
		public bool TryGetComponent(System.Type type, out Component component) {
			component = default;
			return default;
		} // 0x0000000184920040-0x00000001849200E0
		public bool TryGetComponent(System.Type type, int multiComponentIndex, out Component component) {
			component = default;
			return default;
		} // 0x000000018BEE86C0-0x000000018BEE8760
		internal Component TryGetComponentInternal(System.Type type) => default; // 0x000000018BEE867C-0x000000018BEE86C0
		internal void TryGetComponentFastPath(System.Type type, int multiComponentIndex, IntPtr resultValue) {} // 0x0000000184920240-0x0000000184920300
		public static GameObject FindWithTag(string tag) => default; // 0x000000018BEE823C-0x000000018BEE8248
		public void SendMessageUpwards(string methodName, SendMessageOptions options) {} // 0x000000018BEE8534-0x000000018BEE8554
		public void SendMessage(string methodName, SendMessageOptions options) {} // 0x000000018BEE8590-0x000000018BEE85B0
		public void BroadcastMessage(string methodName, SendMessageOptions options) {} // 0x000000018BEE80B8-0x000000018BEE80D8
		internal Component AddComponentInternal(string className) => default; // 0x000000018BEE8058-0x000000018BEE809C
		private Component Internal_AddComponentWithType(System.Type componentType) => default; // 0x0000000184A11F20-0x0000000184A11F70
		public Component AddComponent(System.Type componentType) => default; // 0x0000000186471704-0x0000000186471710
		public T AddComponent<T>()
			where T : Component => default;
		public bool SyncLayerRecursive(GameObject source) => default; // 0x000000018BEE8638-0x000000018BEE867C
		public bool SetLayerRecursive(int layer) => default; // 0x00000001852967E0-0x0000000185296830
		public void SetActive(bool value) {} // 0x00000001844E3700-0x00000001844E3750
		public void SetActiveRecursively(bool state) {} // 0x000000018BEE85B0-0x000000018BEE85F4
		public static int GetTagInt(string tag) => default; // 0x000000018BEE8460-0x000000018BEE8494
		public bool CompareTag(string tag) => default; // 0x000000018BEE815C-0x000000018BEE81A0
		public static GameObject FindGameObjectWithTag(string tag) => default; // 0x000000018BEE81D4-0x000000018BEE8208
		public static GameObject[] FindGameObjectsWithTag(string tag) => default; // 0x000000018BEE8208-0x000000018BEE823C
		public static string[] GetAllArtTagsStr() => default; // 0x000000018BEE8274-0x000000018BEE82A0
		public static int[] GetAllArtTagsInt() => default; // 0x000000018BEE8248-0x000000018BEE8274
		public static void SetArtTags(string[] tagStr, int[] tagInt) {} // 0x000000018BEE85F4-0x000000018BEE8638
		public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) {} // 0x000000018BEE8494-0x000000018BEE84F8
		public void SendMessageUpwards(string methodName, object value) {} // 0x000000018BEE8518-0x000000018BEE8534
		public void SendMessageUpwards(string methodName) {} // 0x000000018BEE84F8-0x000000018BEE8518
		public void SendMessage(string methodName, object value, SendMessageOptions options) {} // 0x0000000185781970-0x00000001857819E0
		public void SendMessage(string methodName, object value) {} // 0x000000018BEE8574-0x000000018BEE8590
		public void SendMessage(string methodName) {} // 0x000000018BEE8554-0x000000018BEE8574
		public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) {} // 0x000000018BEE80D8-0x000000018BEE813C
		public void BroadcastMessage(string methodName, object parameter) {} // 0x000000018BEE809C-0x000000018BEE80B8
		public void BroadcastMessage(string methodName) {} // 0x000000018BEE813C-0x000000018BEE815C
		private static void Internal_CreateGameObject(GameObject self, string name) {} // 0x00000001840F7480-0x00000001840F74D0
		public static GameObject Find(string name) => default; // 0x0000000184A84470-0x0000000184A844B0
		private void get_scene_Injected(out Scene ret) {
			ret = default;
		} // 0x000000018BEE8864-0x000000018BEE88A8
	}

	public struct LayerMask // TypeDefIndex: 47575
	{
		// Fields
		private int m_Mask; // 0x00
	
		// Properties
		public int value { get => default; set {} } // 0x0000000185FE64F0-0x0000000185FE6500 0x00000001818AA390-0x00000001818AA3A0
	
		// Methods
		public static implicit operator int(LayerMask mask) => default; // 0x0000000185FE7B20-0x0000000185FE7B30
		public static implicit operator LayerMask(int intVal) => default; // 0x0000000185FE7B20-0x0000000185FE7B30
		public static string LayerToName(int layer) => default; // 0x000000018BEE909C-0x000000018BEE90D0
		public static int NameToLayer(string layerName) => default; // 0x0000000184B47C30-0x0000000184B47C70
		public static int GetMask(string[] layerNames) => default; // 0x0000000184B47D00-0x0000000184B47D60
	}

	internal static class ManagedStreamHelpers // TypeDefIndex: 47576
	{
		// Methods
		internal static void ValidateLoadFromStream(Stream stream) {} // 0x000000018BEE9310-0x000000018BEE9484
		internal static void ManagedStreamRead(byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) {} // 0x000000018BEE9174-0x000000018BEE924C
		internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) {} // 0x000000018BEE924C-0x000000018BEE9310
		internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) {} // 0x000000018BEE90D0-0x000000018BEE9174
	}

	public class MonoBehaviour : UnityEngine.Behaviour // TypeDefIndex: 47577
	{
		// Properties
		public bool useGUILayout { get => default; set {} } // 0x000000018BEE9C9C-0x000000018BEE9CD0 0x000000018BEE9D1C-0x000000018BEE9D60
	
		// Constructors
		public MonoBehaviour() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public bool IsInvoking() => default; // 0x000000018BEE9AB8-0x000000018BEE9AC4
		public void CancelInvoke() {} // 0x000000018BEE9874-0x000000018BEE987C
		public void Invoke(string methodName, float time) {} // 0x000000018BEE9A4C-0x000000018BEE9A68
		public void InvokeRepeating(string methodName, float time, float repeatRate) {} // 0x000000018BEE99C8-0x000000018BEE9A4C
		public void CancelInvoke(string methodName) {} // 0x000000018BEE987C-0x000000018BEE9884
		public bool IsInvoking(string methodName) => default; // 0x000000018BEE9AAC-0x000000018BEE9AB8
		public Coroutine StartCoroutine(string methodName) => default; // 0x000000018BEE9B24-0x000000018BEE9B34
		public Coroutine StartCoroutine(string methodName, object value) => default; // 0x000000018BEE9B34-0x000000018BEE9C24
		public Coroutine StartCoroutine(IEnumerator routine) => default; // 0x000000018442FD10-0x000000018442FDA0
		public Coroutine StartCoroutine_Auto(IEnumerator routine) => default; // 0x000000018BEE9B18-0x000000018BEE9B24
		public void StopCoroutine(IEnumerator routine) {} // 0x000000018442EAC0-0x000000018442EB00
		public void StopCoroutine(Coroutine routine) {} // 0x000000018442FB10-0x000000018442FB50
		public void StopCoroutine(string methodName) {} // 0x000000018BEE9C58-0x000000018BEE9C9C
		public void StopAllCoroutines() {} // 0x000000018BEE9C24-0x000000018BEE9C58
		public static void print(object message) {} // 0x000000018BEE9CD0-0x000000018BEE9D1C
		private static void Internal_CancelInvokeAll(MonoBehaviour self) {} // 0x000000018BEE98FC-0x000000018BEE9930
		private static bool Internal_IsInvokingAll(MonoBehaviour self) => default; // 0x000000018BEE9930-0x000000018BEE9964
		private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) {} // 0x000000018BEE9964-0x000000018BEE99C8
		private static void CancelInvoke(MonoBehaviour self, string methodName) {} // 0x000000018BEE9884-0x000000018BEE98C8
		private static bool IsInvoking(MonoBehaviour self, string methodName) => default; // 0x000000018BEE9A68-0x000000018BEE9AAC
		private static bool IsObjectMonoBehaviour(UnityEngine.Object obj) => default; // 0x000000018442FDF0-0x000000018442FE30
		private Coroutine StartCoroutineManaged(string methodName, object value) => default; // 0x000000018BEE9AC4-0x000000018BEE9B18
		private Coroutine StartCoroutineManaged2(IEnumerator enumerator) => default; // 0x000000018442FDA0-0x000000018442FDF0
		private void StopCoroutineManaged(Coroutine routine) {} // 0x000000018442FE30-0x000000018442FE80
		private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) {} // 0x000000018442EA20-0x000000018442EA70
		internal string GetScriptClassName() => default; // 0x000000018BEE98C8-0x000000018BEE98FC
	}

	public sealed class NoAllocHelpers // TypeDefIndex: 47578
	{
		// Constructors
		public NoAllocHelpers() {} // Dummy constructor
	
		// Methods
		public static void ResizeList<T>(List<T> list, int size) {}
		public static void EnsureListElemCount<T>(List<T> list, int count) {}
		public static int SafeLength(Array values) => default; // 0x0000000183F99ED0-0x0000000183F99F40
		public static int SafeLength<T>(List<T> values) => default;
		public static T[] ExtractArrayFromListT<T>(List<T> list) => default;
		internal static void Internal_ResizeList(object list, int size) {} // 0x0000000183F8FB90-0x0000000183F8FBE0
		public static Array ExtractArrayFromList(object list) => default; // 0x0000000183F99910-0x0000000183F99950
	}

	public struct PlatformSpecificParam<T> // TypeDefIndex: 47579
	{
		// Fields
		public T defaultParam;
	}

	public struct RangeInt // TypeDefIndex: 47580
	{
		// Fields
		public int start; // 0x00
		public int length; // 0x04
	
		// Properties
		public int end { get => default; } // 0x0000000185FE7B70-0x0000000185FE7B80 
	
		// Constructors
		public RangeInt(int start, int length) : this() {
			this.start = default;
			this.length = default;
		} // 0x000000018357CB90-0x000000018357CBA0
	}

	public enum RuntimeInitializeLoadType // TypeDefIndex: 47581
	{
		AfterSceneLoad = 0,
		BeforeSceneLoad = 1,
		AfterAssembliesLoaded = 2,
		BeforeSplashScreen = 3,
		SubsystemRegistration = 4
	}

	public class RuntimeInitializeOnLoadMethodAttribute : UnityEngine.Scripting.PreserveAttribute // TypeDefIndex: 47582
	{
		// Fields
		private RuntimeInitializeLoadType m_LoadType; // 0x10
	
		// Properties
		private RuntimeInitializeLoadType loadType { set {} } // 0x0000000181378230-0x0000000181378240
	
		// Constructors
		public RuntimeInitializeOnLoadMethodAttribute() {} // 0x0000000185FBA4D0-0x0000000185FBA4E0
		public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType) {} // 0x0000000181378230-0x0000000181378240
	}

	public class ScriptableObject : UnityEngine.Object // TypeDefIndex: 47583
	{
		// Constructors
		public ScriptableObject() {} // 0x0000000184BBD7C0-0x0000000184BBD840
	
		// Methods
		public void SetDirty() {} // 0x000000018BEECFD0-0x000000018BEED004
		public static ScriptableObject CreateInstance(string className) => default; // 0x000000018BEECF5C-0x000000018BEECF68
		public static ScriptableObject CreateInstance(System.Type type) => default; // 0x000000018646D530-0x000000018646D53C
		public static T CreateInstance<T>()
			where T : ScriptableObject => default;
		internal static ScriptableObject CreateInstance(System.Type type, Action<ScriptableObject> initialize) => default; // 0x000000018BEECDD4-0x000000018BEECF5C
		private static void CreateScriptableObject(ScriptableObject self) {} // 0x0000000184BBD840-0x0000000184BBD880
		private static ScriptableObject CreateScriptableObjectInstanceFromName(string className) => default; // 0x000000018BEECF68-0x000000018BEECF9C
		internal static ScriptableObject CreateScriptableObjectInstanceFromType(System.Type type, bool applyDefaultsAndReset) => default; // 0x0000000185409020-0x0000000185409070
		internal static void ResetAndApplyDefaultInstances(UnityEngine.Object obj) {} // 0x000000018BEECF9C-0x000000018BEECFD0
	}

	internal class ScriptingRuntime // TypeDefIndex: 47584
	{
		// Constructors
		public ScriptingRuntime() {} // Dummy constructor
	
		// Methods
		public static string[] GetAllUserAssemblies() => default; // 0x000000018BEED004-0x000000018BEED030
	}

	internal class ScriptingUtility // TypeDefIndex: 47586
	{
		// Nested types
		private struct TestClass // TypeDefIndex: 47585
		{
			// Fields
			public int value; // 0x00
		}
	
		// Constructors
		public ScriptingUtility() {} // Dummy constructor
	
		// Methods
		private static bool IsManagedCodeWorking() => default; // 0x0000000185FC71B0-0x0000000185FC71C0
	}

	public class SelectionBaseAttribute : Attribute // TypeDefIndex: 47587
	{
		// Constructors
		public SelectionBaseAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class StackTraceUtility // TypeDefIndex: 47588
	{
		// Fields
		private static string projectFolder; // 0x00
	
		// Constructors
		static StackTraceUtility() {} // 0x0000000185F7C7E0-0x0000000185F7C840
	
		// Methods
		internal static void SetProjectFolder(string folder) {} // 0x0000000184ED1230-0x0000000184ED1340
		public static string ExtractStackTrace() => default; // 0x00000001843D7F30-0x00000001843D8070
		internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) {
			message = default;
			stackTrace = default;
		} // 0x000000018BEEE984-0x000000018BEEED08
		internal static string ExtractFormattedStackTrace(StackTrace stackTrace) => default; // 0x00000001841C40B0-0x00000001841C4420
	}

	[Serializable]
	public class UnityException : Exception // TypeDefIndex: 47589
	{
		// Constructors
		public UnityException() {} // 0x000000018BEF2548-0x000000018BEF25A4
		public UnityException(string message) {} // 0x000000018BEF2610-0x000000018BEF2668
		protected UnityException(SerializationInfo info, StreamingContext context) {} // 0x000000018BEF25A4-0x000000018BEF2610
	}

	[Serializable]
	public class UnassignedReferenceException : Exception // TypeDefIndex: 47590
	{
		// Constructors
		public UnassignedReferenceException() {} // 0x000000018BEF19D0-0x000000018BEF1A2C
		public UnassignedReferenceException(string message) {} // 0x000000018BEF190C-0x000000018BEF1964
		protected UnassignedReferenceException(SerializationInfo info, StreamingContext context) {} // 0x000000018BEF1964-0x000000018BEF19D0
	}

	public class TextAsset : UnityEngine.Object // TypeDefIndex: 47593
	{
		// Properties
		public byte[] bytes { get => default; } // 0x000000018BEEF2E8-0x000000018BEEF328 
		public string text { get => default; } // 0x000000018BEEF420-0x000000018BEEF428 
		public long dataSize { get => default; } // 0x000000018BEEF390-0x000000018BEEF39C 
	
		// Nested types
		internal enum CreateOptions // TypeDefIndex: 47591
		{
			None = 0,
			CreateNativeObject = 1
		}
	
		private static class EncodingUtility // TypeDefIndex: 47592
		{
			// Fields
			internal static readonly KeyValuePair<byte[], Encoding>[] encodingLookup; // 0x00
			internal static readonly Encoding targetEncoding; // 0x08
	
			// Constructors
			static EncodingUtility() {} // 0x0000000184579D40-0x0000000184579D80
		}
	
		// Constructors
		public TextAsset() {} // 0x000000018BEEF3AC-0x000000018BEEF3BC
		public TextAsset(string text) {} // 0x000000018BEEF3BC-0x000000018BEEF420
		internal TextAsset(CreateOptions options, string text) {}
	
		// Methods
		private byte[] GetPreviewBytes(int maxByteCount) => default; // 0x000000018BEEF34C-0x000000018BEEF390
		private static void Internal_CreateInstance(TextAsset self, string text) {} // 0x000000018457AE90-0x000000018457AED0
		private IntPtr GetDataPtr() => default; // 0x000000018457AED0-0x000000018457AF10
		private long GetDataSize() => default; // 0x0000000184579D20-0x0000000184579D40
		public override string ToString() => default; // 0x000000018BEEF39C-0x000000018BEEF3AC
		public NativeArray<T> GetData<T>()
			where T : struct => default; // 0x000000018BEEF328-0x000000018BEEF34C
		internal string GetPreview(int maxChars) => default; // 0x0000000184579D80-0x0000000184579FC0
		internal static string DecodeString(byte[] bytes) => default; // 0x00000001844B7F10-0x00000001844B8370
	}

	public class TrackedReference // TypeDefIndex: 47594
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Constructors
		protected TrackedReference() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static bool operator ==(TrackedReference x, TrackedReference y) => default; // 0x00000001844A9850-0x00000001844A9870
		public static bool operator !=(TrackedReference x, TrackedReference y) => default; // 0x00000001844A8AB0-0x00000001844A8AD0
		public override bool Equals(object o) => default; // 0x000000018BEEFEC4-0x000000018BEEFF44
		public override int GetHashCode() => default; // 0x0000000185FE6790-0x0000000185FE67A0
		public static implicit operator bool(TrackedReference exists) => default; // 0x000000018646E3E4-0x000000018646E3F0
	}

	internal sealed class UnhandledExceptionHandler // TypeDefIndex: 47596
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 47595
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static UnhandledExceptionEventHandler __9__0_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000184A8D710-0x0000000184A8D820
			public __c() {} // 0x0000000185F70930-0x0000000185F70990
	
			// Methods
			internal void _RegisterUECatcher_b__0_0(object sender, UnhandledExceptionEventArgs e) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public UnhandledExceptionHandler() {} // Dummy constructor
	
		// Methods
		private static void RegisterUECatcher() {} // 0x000000018BEF18A0-0x000000018BEF190C
	}

	public class UnityAPICompatibilityVersionAttribute : Attribute // TypeDefIndex: 47597
	{
		// Fields
		private string _version; // 0x10
		private string[] _configurationAssembliesHashes; // 0x18
	
		// Constructors
		public UnityAPICompatibilityVersionAttribute() {} // Dummy constructor
		public UnityAPICompatibilityVersionAttribute(string version, string[] configurationAssembliesHashes) {} // 0x00000001841BC230-0x00000001841BC260
	}

	public enum HideFlags // TypeDefIndex: 47598
	{
		None = 0,
		HideInHierarchy = 1,
		HideInInspector = 2,
		DontSaveInEditor = 4,
		NotEditable = 8,
		DontSaveInBuild = 16,
		DontUnloadUnusedAsset = 32,
		DontSave = 52,
		HideAndDontSave = 61
	}

	public enum FindObjectsSortMode // TypeDefIndex: 47599
	{
		None = 0,
		InstanceID = 1
	}

	public enum FindObjectsInactive // TypeDefIndex: 47600
	{
		Exclude = 0,
		Include = 1
	}

	public class Object // TypeDefIndex: 47601
	{
		// Fields
		private IntPtr m_CachedPtr; // 0x10
		internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x00
		private const string objectIsNullMessage = "The Object you want to instantiate is null."; // Metadata: 0x02060853
		private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."; // Metadata: 0x0206087F
	
		// Properties
		public string name { get => default; set {} } // 0x000000018463B6D0-0x000000018463B750 0x0000000184B451B0-0x0000000184B45240
		public HideFlags hideFlags { get => default; set {} } // 0x0000000184FC81F0-0x0000000184FC8230 0x0000000184245400-0x0000000184245450
	
		// Constructors
		public Object() {} // 0x0000000185492010-0x0000000185492020
		static Object() {} // 0x0000000185FA4460-0x0000000185FA44A0
	
		// Methods
		public int GetInstanceID() => default; // 0x00000001841427A0-0x0000000184142870
		public override int GetHashCode() => default; // 0x0000000185FE7B30-0x0000000185FE7B40
		public override bool Equals(object other) => default; // 0x000000018474B620-0x000000018474B860
		public static implicit operator bool(Object exists) => default; // 0x0000000183FF10A0-0x0000000183FF1130
		private static bool CompareBaseObjects(Object lhs, Object rhs) => default; // 0x0000000183FF1510-0x0000000183FF15E0
		private void EnsureRunningOnMainThread() {} // 0x000000018BEE9E6C-0x000000018BEE9F00
		private static bool IsNativeObjectAlive(Object o) => default; // 0x0000000183FF15E0-0x0000000183FF1600
		public IntPtr GetCachedPtr() => default; // 0x0000000185FC7990-0x0000000185FC79A0
		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Vector3 position, Quaternion rotation)
			where T : Object => default;
		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Transform parent, Vector3 position, Quaternion rotation)
			where T : Object => default;
		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Vector3 position, Quaternion rotation)
			where T : Object => default;
		public static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent, Vector3 position, Quaternion rotation)
			where T : Object => default;
		public static T InstantiateAsyncImmediately<T>(T original, Transform parent)
			where T : Object => default;
		public static T InstantiateAsyncImmediately<T>(T original, Transform parent, bool worldPositionStays)
			where T : Object => default;
		public int GetNameHashCode() => default; // 0x00000001850403B0-0x0000000185040430
		public static int GetNameHashCode(string name) => default; // 0x000000018BEEA33C-0x000000018BEEA398
		public static unsafe int GetNameHashCode(byte* name) => default; // 0x000000018BEEA398-0x000000018BEEA3EC
		public void GetNameNoAlloc(string name) {} // 0x000000018BEEA3EC-0x000000018BEEA47C
		public bool CompareName(string name) => default; // 0x00000001845E9FB0-0x00000001845EA040
		public bool NameContains(string substring) => default; // 0x00000001845CD580-0x00000001845CD5F0
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) => default; // 0x000000018BEEA4D0-0x000000018BEEA6A4
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) => default; // 0x0000000184DA1820-0x0000000184DA19B0
		public static Object Instantiate(Object original) => default; // 0x0000000184DA1590-0x0000000184DA1620
		public static Object Instantiate(Object original, Transform parent) => default; // 0x000000018BEEA47C-0x000000018BEEA4D0
		public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) => default; // 0x0000000184DA1480-0x0000000184DA1590
		public static T Instantiate<T>(T original)
			where T : Object => default;
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation)
			where T : Object => default;
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent)
			where T : Object => default;
		public static T Instantiate<T>(T original, Transform parent)
			where T : Object => default;
		public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays)
			where T : Object => default;
		public static void Destroy(Object obj, float t) {} // 0x00000001840F7760-0x00000001840F77B0
		public static void Destroy(Object obj) {} // 0x00000001840F76E0-0x00000001840F7760
		public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) {} // 0x0000000184243300-0x0000000184243350
		public static void DestroyImmediate(Object obj) {} // 0x00000001842432B0-0x0000000184243300
		public static Object[] FindObjectsOfType(System.Type type) => default; // 0x000000018BEEA23C-0x000000018BEEA288
		public static Object[] FindObjectsOfType(System.Type type, bool includeInactive) => default; // 0x00000001856251B0-0x0000000185625200
		public static Object[] FindObjectsByType(System.Type type, FindObjectsSortMode sortMode) => default; // 0x000000018BEEA1A8-0x000000018BEEA1FC
		public static Object[] FindObjectsByType(System.Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) => default; // 0x000000018BEEA158-0x000000018BEEA1A8
		public static void DontDestroyOnLoad(Object target) {} // 0x0000000184B454A0-0x0000000184B454E0
		public static void DestroyObject(Object obj, float t) {} // 0x000000018BEE9D8C-0x000000018BEE9DE8
		public static void DestroyObject(Object obj) {} // 0x000000018BEE9DE8-0x000000018BEE9E38
		public static Object[] FindSceneObjectsOfType(System.Type type) => default; // 0x000000018BEEA288-0x000000018BEEA2D4
		public static Object[] FindObjectsOfTypeIncludingAssets(System.Type type) => default; // 0x000000018BEEA208-0x000000018BEEA23C
		public static T[] FindObjectsOfType<T>()
			where T : Object => default;
		public static T[] FindObjectsByType<T>(FindObjectsSortMode sortMode)
			where T : Object => default;
		public static T[] FindObjectsOfType<T>(bool includeInactive)
			where T : Object => default;
		public static T[] FindObjectsByType<T>(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode)
			where T : Object => default;
		public static T FindObjectOfType<T>()
			where T : Object => default;
		public static T FindObjectOfType<T>(bool includeInactive)
			where T : Object => default;
		public static T FindFirstObjectByType<T>()
			where T : Object => default;
		public static T FindAnyObjectByType<T>()
			where T : Object => default;
		public static T FindFirstObjectByType<T>(FindObjectsInactive findObjectsInactive)
			where T : Object => default;
		public static T FindAnyObjectByType<T>(FindObjectsInactive findObjectsInactive)
			where T : Object => default;
		public static Object[] FindObjectsOfTypeAll(System.Type type) => default; // 0x000000018BEEA1FC-0x000000018BEEA208
		private static void CheckNullArgument(object arg, string message) {} // 0x0000000184DA1CE0-0x0000000184DA1D20
		public static Object FindObjectOfType(System.Type type) => default; // 0x000000018BEEA0F0-0x000000018BEEA158
		public static Object FindFirstObjectByType(System.Type type) => default; // 0x000000018BEE9FF4-0x000000018BEEA06C
		public static Object FindAnyObjectByType(System.Type type) => default; // 0x000000018BEE9F00-0x000000018BEE9F74
		public static Object FindObjectOfType(System.Type type, bool includeInactive) => default; // 0x0000000185625000-0x0000000185625080
		public static Object FindFirstObjectByType(System.Type type, FindObjectsInactive findObjectsInactive) => default; // 0x000000018BEEA06C-0x000000018BEEA0F0
		public static Object FindAnyObjectByType(System.Type type, FindObjectsInactive findObjectsInactive) => default; // 0x000000018BEE9F74-0x000000018BEE9FF4
		public override string ToString() => default; // 0x0000000185F56620-0x0000000185F56670
		public static bool operator ==(Object x, Object y) => default; // 0x0000000183FF12F0-0x0000000183FF1400
		public static bool operator !=(Object x, Object y) => default; // 0x0000000183FF1400-0x0000000183FF1510
		private static int GetOffsetOfInstanceIDInCPlusPlusObject() => default; // 0x0000000185FA7340-0x0000000185FA7380
		private static bool CurrentThreadIsMainThread() => default; // 0x000000018BEE9D60-0x000000018BEE9D8C
		private static Object Internal_CloneSingle(Object data) => default; // 0x0000000184DA16F0-0x0000000184DA1730
		private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) => default; // 0x0000000184DA1D20-0x0000000184DA1D80
		private static AsyncInstantiateOperation Internal_InstantiateAsyncWithParent(Object original, int count, Transform parent, IntPtr position, IntPtr rotation) => default; // 0x000000018BEEA6E8-0x000000018BEEA748
		private static Object Internal_InstantiateAsyncImmediatelyWithParent(Object original, Transform parent, bool worldPositionStays) => default; // 0x0000000184DA1C80-0x0000000184DA1CE0
		private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) => default; // 0x000000018BEEA79C-0x000000018BEEA800
		private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) => default; // 0x0000000184DA19B0-0x0000000184DA1A60
		private static string ToString(Object obj) => default; // 0x0000000185F56670-0x0000000185F566B0
		private static string GetName(Object obj) => default; // 0x000000018463B750-0x000000018463B790
		private static int GetNameHashCode(Object obj) => default; // 0x0000000185040430-0x0000000185040470
		private static int GetHashCodeByName(string name) => default; // 0x000000018BEEA308-0x000000018BEEA33C
		private static unsafe int UnsafeGetHashCodeByName(byte* name) => default; // 0x000000018BEEA834-0x000000018BEEA868
		private static bool Internal_CompareName(Object obj, string name) => default; // 0x00000001845EA040-0x00000001845EA090
		private static bool Internal_NameContains(Object obj, string substring) => default; // 0x00000001845CD5F0-0x00000001845CD640
		private static void Internal_GetNameNoAlloc(Object obj, string name) {} // 0x000000018BEEA6A4-0x000000018BEEA6E8
		internal static bool IsPersistent(Object obj) => default; // 0x000000018BEEA800-0x000000018BEEA834
		private static void SetName(Object obj, string name) {} // 0x0000000184B45240-0x0000000184B45290
		internal static bool DoesObjectWithInstanceIDExist(int instanceID) => default; // 0x000000018BEE9E38-0x000000018BEE9E6C
		internal static Object FindObjectFromInstanceID(int instanceID) => default; // 0x0000000184295090-0x00000001842950D0
		internal static Object ForceLoadFromInstanceID(int instanceID) => default; // 0x000000018BEEA2D4-0x000000018BEEA308
		private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) => default; // 0x000000018BEEA748-0x000000018BEEA79C
		private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) => default; // 0x0000000184DA1A60-0x0000000184DA1AD0
	}

	internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 47603
	{
		// Fields
		private readonly List<WorkRequest> m_AsyncWorkQueue; // 0x18
		private readonly List<WorkRequest> m_CurrentFrameWork; // 0x20
		private readonly int m_MainThreadID; // 0x28
		private int m_TrackedCount; // 0x2C
	
		// Nested types
		private struct WorkRequest // TypeDefIndex: 47602
		{
			// Fields
			private readonly SendOrPostCallback m_DelagateCallback; // 0x00
			private readonly object m_DelagateState; // 0x08
			private readonly ManualResetEvent m_WaitHandle; // 0x10
	
			// Constructors
			public WorkRequest(SendOrPostCallback callback, object state, ManualResetEvent waitHandle = null) {
				m_DelagateCallback = default;
				m_DelagateState = default;
				m_WaitHandle = default;
			} // 0x0000000185503E40-0x0000000185503F50
	
			// Methods
			public void Invoke() {} // 0x0000000185503FD0-0x00000001855040B0
		}
	
		// Constructors
		public UnitySynchronizationContext() {} // Dummy constructor
		private UnitySynchronizationContext(int mainThreadID) {} // 0x000000018BEF2788-0x000000018BEF29C8
		private UnitySynchronizationContext(List<WorkRequest> queue, int mainThreadID) {} // 0x0000000185FAE940-0x0000000185FAE950
	
		// Methods
		public override void Send(SendOrPostCallback callback, object state) {} // 0x0000000185FAE950-0x0000000185FAE960
		public override void OperationStarted() {} // 0x000000018476B890-0x000000018476BBB0
		public override void OperationCompleted() {} // 0x0000000185503F50-0x0000000185503FD0
		public override void Post(SendOrPostCallback callback, object state) {} // 0x0000000184CBCFF0-0x0000000184CBD2F0
		public override SynchronizationContext CreateCopy() => default; // 0x000000018BEF2734-0x000000018BEF2788
		private void Exec() {} // 0x0000000185503DB0-0x0000000185503E40
		private bool HasPendingTasks() => default; // 0x0000000184CBCFA0-0x0000000184CBCFF0
		private static void InitializeSynchronizationContext() {} // 0x000000018BEF2668-0x000000018BEF2734
		private static void ExecuteTasks() {} // 0x000000018476BBB0-0x000000018476BBE0
		private static bool ExecutePendingTasks(long millisecondsTimeout) => default; // 0x0000000184CBD2F0-0x0000000184CBD410
	}

	public sealed class WaitForEndOfFrame : YieldInstruction // TypeDefIndex: 47604
	{
		// Constructors
		public WaitForEndOfFrame() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class WaitForFixedUpdate : YieldInstruction // TypeDefIndex: 47605
	{
		// Constructors
		public WaitForFixedUpdate() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class WaitForSeconds : YieldInstruction // TypeDefIndex: 47606
	{
		// Fields
		internal float m_Seconds; // 0x10
	
		// Constructors
		public WaitForSeconds() {} // Dummy constructor
		public WaitForSeconds(float seconds) {} // 0x0000000181A6E380-0x0000000181A6E390
	}

	public class WaitForSecondsRealtime : CustomYieldInstruction // TypeDefIndex: 47607
	{
		// Fields
		private float _waitTime_k__BackingField; // 0x10
		private float m_WaitUntilTime; // 0x14
	
		// Properties
		public float waitTime { get; set; } // 0x0000000181DCCCE0-0x0000000181DCCCF0 0x0000000181A6E380-0x0000000181A6E390
		public override bool keepWaiting { get => default; } // 0x000000018BEF2C30-0x000000018BEF2C8C 
	
		// Constructors
		public WaitForSecondsRealtime() {} // Dummy constructor
		public WaitForSecondsRealtime(float time) {} // 0x0000000185FE7B80-0x0000000185FE7B90
	
		// Methods
		public override void Reset() {} // 0x0000000185FB9910-0x0000000185FB9920
	}

	public sealed class WaitUntil : CustomYieldInstruction // TypeDefIndex: 47608
	{
		// Fields
		private Func<bool> m_Predicate; // 0x10
	
		// Properties
		public override bool keepWaiting { get => default; } // 0x00000001856F2CB0-0x00000001856F2CE0 
	
		// Constructors
		public WaitUntil() {} // Dummy constructor
		public WaitUntil(Func<bool> predicate) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public sealed class WaitWhile : CustomYieldInstruction // TypeDefIndex: 47609
	{
		// Fields
		private Func<bool> m_Predicate; // 0x10
	
		// Properties
		public override bool keepWaiting { get => default; } // 0x000000018BEF2C8C-0x000000018BEF2D08 
	
		// Constructors
		public WaitWhile() {} // Dummy constructor
		public WaitWhile(Func<bool> predicate) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class YieldInstruction // TypeDefIndex: 47610
	{
		// Constructors
		public YieldInstruction() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class SerializeField : Attribute // TypeDefIndex: 47611
	{
		// Constructors
		public SerializeField() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class SerializeReference : Attribute // TypeDefIndex: 47612
	{
		// Constructors
		public SerializeReference() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class PreferBinarySerialization : Attribute // TypeDefIndex: 47613
	{
		// Constructors
		public PreferBinarySerialization() {} // 0x0000000185492010-0x0000000185492020
	}

	public interface ISerializationCallbackReceiver // TypeDefIndex: 47614
	{
		// Methods
		void OnBeforeSerialize();
		void OnAfterDeserialize();
	}

	public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 47615
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public int count { get => default; } // 0x000000018BEE799C-0x000000018BEE79D0 
		public int stride { get => default; } // 0x000000018BEE79D0-0x000000018BEE7A04 
		private ComputeBufferMode usage { get => default; } // 0x000000018BEE7A04-0x000000018BEE7A38 
		public string name { set {} } // 0x000000018BEE7A38-0x000000018BEE7A40
	
		// Constructors
		public ComputeBuffer() {} // Dummy constructor
		public ComputeBuffer(int count, int stride) {} // 0x000000018BEE7978-0x000000018BEE799C
		public ComputeBuffer(int count, int stride, ComputeBufferType type) {} // 0x00000001864740BC-0x00000001864740E0
		public ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) {} // 0x000000018BEE7950-0x000000018BEE7978
		private ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) {} // 0x0000000185D74580-0x0000000185D74610
	
		// Methods
		~ComputeBuffer() {} // 0x000000018BEE7630-0x000000018BEE76A4
		public void Dispose() {} // 0x000000018BEE7524-0x000000018BEE7574
		private void Dispose(bool disposing) {} // 0x000000018BEE7574-0x000000018BEE75F0
		private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) => default; // 0x0000000185D74610-0x0000000185D74680
		private static void DestroyBuffer(ComputeBuffer buf) {} // 0x000000018BEE74F0-0x000000018BEE7524
		public void Release() {} // 0x000000018BEE77B8-0x000000018BEE77C0
		private static bool IsValidBuffer(ComputeBuffer buf) => default; // 0x000000018BEE776C-0x000000018BEE77A0
		public bool IsValid() => default; // 0x000000018BEE77A0-0x000000018BEE77B8
		public void SetData(Array data) {} // 0x000000018BEE77C0-0x000000018BEE790C
		public void SetData<T>(List<T> data)
			where T : struct {}
		public void SetData<T>(NativeArray<T> data)
			where T : struct {}
		public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count)
			where T : struct {}
		private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) {} // 0x000000018BEE7708-0x000000018BEE776C
		private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) {} // 0x000000018BEE76A4-0x000000018BEE7708
		private unsafe void* BeginBufferWrite(int offset = 0 /* Metadata: 0x0206090A */, int size = 0 /* Metadata: 0x0206090B */) => default; // 0x000000018BEE74A0-0x000000018BEE74F0
		public NativeArray<T> BeginWrite<T>(int computeBufferStartIndex, int count)
			where T : struct => default;
		private void EndBufferWrite(int bytesWritten = 0 /* Metadata: 0x0206090C */) {} // 0x000000018BEE75F0-0x000000018BEE7630
		public void EndWrite<T>(int countWritten)
			where T : struct {}
		private void SetName(string name) {} // 0x000000018BEE790C-0x000000018BEE7950
	}

	public sealed class ComputeShader : UnityEngine.Object // TypeDefIndex: 47616
	{
		// Properties
		public LocalKeywordSpace keywordSpace { get => default; } // 0x0000000184490900-0x0000000184490960 
		public string[] shaderKeywords { set {} } // 0x000000018BEE7EEC-0x000000018BEE7EF4
	
		// Constructors
		public ComputeShader() {} // Dummy constructor
	
		// Methods
		public int FindKernel(string name) => default; // 0x00000001844907A0-0x00000001844907F0
		public void SetInt(int nameID, int val) {} // 0x000000018BEE7E20-0x000000018BEE7E70
		private void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) {} // 0x000000018BEE7BF8-0x000000018BEE7C58
		private void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer) {} // 0x000000018BEE7C58-0x000000018BEE7CB8
		private void Internal_HGSetBuffer(int kernelIndex, int nameID, uint gfxBufferID) {} // 0x000000018BEE7B98-0x000000018BEE7BF8
		public void HGSetBuffer(int kernelIndex, int nameID, uint gfxBufferID) {} // 0x000000018BEE7B88-0x000000018BEE7B98
		public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) {} // 0x000000018BEE7D54-0x000000018BEE7D64
		public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer) {} // 0x000000018BEE7CF8-0x000000018BEE7D08
		private void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size) {} // 0x000000018BEE7DC0-0x000000018BEE7E20
		public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BEE7B28-0x000000018BEE7B88
		public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) {} // 0x000000018BEE7A84-0x000000018BEE7AE4
		public void EnableKeyword(string keyword) {} // 0x000000018BEE7AE4-0x000000018BEE7B28
		public void DisableKeyword(string keyword) {} // 0x000000018BEE7A40-0x000000018BEE7A84
		public bool IsSupported(int kernelIndex) => default; // 0x000000018BEE7CB8-0x000000018BEE7CF8
		private void SetShaderKeywords(string[] names) {} // 0x000000018BEE7EA8-0x000000018BEE7EEC
		public void SetInt(string name, int val) {} // 0x000000018BEE7E70-0x000000018BEE7EA8
		public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) {} // 0x000000018BEE7D08-0x000000018BEE7D54
		public void SetBuffer(int kernelIndex, string name, GraphicsBuffer buffer) {} // 0x000000018BEE7D64-0x000000018BEE7DB0
		public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size) {} // 0x000000018BEE7DB0-0x000000018BEE7DC0
		private void get_keywordSpace_Injected(out LocalKeywordSpace ret) {
			ret = default;
		} // 0x00000001844909F0-0x0000000184490A40
	}

	public struct HGPsoExtInfo // TypeDefIndex: 47617
	{
		// Fields
		public float createTime; // 0x00
		public int codeSize; // 0x04
		public bool isMissing; // 0x08
		public string levelId; // 0x10
	}

	public class HGPsoUtil // TypeDefIndex: 47619
	{
		// Fields
		private static Action<string, HGPsoExtInfo> onRenderPipelineUpload; // 0x00
		private static GetLevelIdDelegate onUpdateGameInfo; // 0x08
	
		// Events
		public static event Action<string, HGPsoExtInfo> onRenderPipelineUpload;
		public static event GetLevelIdDelegate onUpdateGameInfo;
	
		// Nested types
		public delegate string GetLevelIdDelegate(); // TypeDefIndex: 47618; 0x00000001859916F0-0x0000000185991790
	
		// Constructors
		public HGPsoUtil() {} // Dummy constructor
	
		// Methods
		internal static void InvokeOnRenderPipelineUploadV2(string infoJson, float createTime, int codeSize, bool isMissing, string levelId) {} // 0x0000000185991840-0x00000001859918F0
		internal static string GetLevelId() => default; // 0x00000001859915C0-0x0000000185991650
		public static bool IsPsoRecordEnabled() => default; // 0x0000000183683B30-0x0000000183683B40
	}

	public class HGPsoWarmupCollection : UnityEngine.Object // TypeDefIndex: 47621
	{
		// Nested types
		public class AutoDispatcher : IDisposable // TypeDefIndex: 47620
		{
			// Fields
			private HGPsoWarmupCollection m_Psoc; // 0x10
	
			// Constructors
			public AutoDispatcher() {} // Dummy constructor
			private AutoDispatcher(HGPsoWarmupCollection psoc) {} // 0x00000001854B2720-0x00000001854B2760
	
			// Methods
			public static AutoDispatcher Create(HGPsoWarmupCollection psoc) => default; // 0x000000018BEE8B3C-0x000000018BEE8B68
			public void ScheduleIndex(int index, bool background = true /* Metadata: 0x0206090E */) {} // 0x000000018BEE8AF0-0x000000018BEE8B30
			public void Dispose() {} // 0x000000018BEE8A30-0x000000018BEE8A64
		}
	
		// Constructors
		public HGPsoWarmupCollection() {} // Dummy constructor
	
		// Methods
		private static void UploadPipelineCreatedInfoInternal(int maxUploadCount) {} // 0x000000018BEE8A70-0x000000018BEE8AA4
		private static void SavePipelineCacheInternal() {} // 0x000000018BEE8B70-0x000000018BEE8BC4
		private bool IsCompilingStageInternal(int index) => default; // 0x000000018BEE89FC-0x000000018BEE8A30
		private int GetCompilingCountInternal() => default; // 0x000000018BEE8AB0-0x000000018BEE8AE4
		private int GetInfoCountInternal() => default; // 0x0000000186473C80-0x0000000186473C88
		private void ScheduleIndexInternal(int index, bool background) {} // 0x000000018BEE8B68-0x000000018BEE8B70
		private void DispatchAllInternal() {} // 0x000000018BEE8B30-0x000000018BEE8B3C
		private int GetRemainingJobCountInternal() => default; // 0x000000018BEE8A64-0x000000018BEE8A70
		public static void UploadPipelineCreatedInfo(int maxUploadCount = -1 /* Metadata: 0x0206090D */) {} // 0x000000018BEE8AA4-0x000000018BEE8AB0
		public static void SavePipelineCache() {} // 0x000000018BEE8AE4-0x000000018BEE8AF0
		public bool IsCompilingStage(int index) => default; // 0x0000000184096E30-0x0000000184096EF0
		public int GetCompilingCount() => default; // 0x000000018BEE6EE4-0x000000018BEE6F44
		public int GetInfoCount() => default; // 0x000000018BEE6F64-0x000000018BEE6F84
		public int GetRemainingJobCount() => default; // 0x000000018BEE6F44-0x000000018BEE6F64
	}

	public class HGSubsurfaceProfile : UnityEngine.Object // TypeDefIndex: 47622
	{
		// Fields
		public const int LutSize = 64; // Metadata: 0x0206090F
	
		// Properties
		public Vector3 subsurfaceNormalLerp { get => default; } // 0x000000018BEE8E14-0x000000018BEE8E40 
		public float curvatureScale { get => default; } // 0x000000018BEE8CCC-0x000000018BEE8D00 
		public float penumbraScale { get => default; } // 0x000000018BEE8D68-0x000000018BEE8D9C 
		public Texture2D scatterLut { get => default; } // 0x000000018BEE8D9C-0x000000018BEE8DD0 
		public Texture2D penumbraLut { get => default; } // 0x000000018BEE8D34-0x000000018BEE8D68 
		public Texture2D indirectLut { get => default; } // 0x000000018BEE8D00-0x000000018BEE8D34 
	
		// Constructors
		public HGSubsurfaceProfile() {} // 0x000000018BEE8C80-0x000000018BEE8CCC
	
		// Methods
		private static void Internal_Create(HGSubsurfaceProfile self) {} // 0x000000018BEE8C4C-0x000000018BEE8C80
		private void get_subsurfaceNormalLerp_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEE8DD0-0x000000018BEE8E14
	}

	public class SubShaderBinaryData : UnityEngine.Object // TypeDefIndex: 47623
	{
		// Constructors
		public SubShaderBinaryData() {} // 0x000000018BEEED3C-0x000000018BEEED88
	
		// Methods
		private static void Create(SubShaderBinaryData self) {} // 0x000000018BEEED08-0x000000018BEEED3C
	}

	internal class LowerResBlitTexture : UnityEngine.Object // TypeDefIndex: 47624
	{
		// Constructors
		public LowerResBlitTexture() {} // Dummy constructor
	
		// Methods
		internal void LowerResBlitTextureDontStripMe() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class PreloadData : UnityEngine.Object // TypeDefIndex: 47625
	{
		// Constructors
		public PreloadData() {} // Dummy constructor
	
		// Methods
		internal void PreloadDataDontStripMe() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum BatteryStatus // TypeDefIndex: 47626
	{
		Unknown = 0,
		Charging = 1,
		Discharging = 2,
		NotCharging = 3,
		Full = 4
	}

	public enum OperatingSystemFamily // TypeDefIndex: 47627
	{
		Other = 0,
		MacOSX = 1,
		Windows = 2,
		Linux = 3
	}

	public enum DeviceType // TypeDefIndex: 47628
	{
		Unknown = 0,
		Handheld = 1,
		Console = 2,
		Desktop = 3
	}

	public sealed class SystemInfo // TypeDefIndex: 47629
	{
		// Properties
		public static float batteryLevel { get => default; } // 0x000000018BEEF138-0x000000018BEEF144 
		public static BatteryStatus batteryStatus { get => default; } // 0x0000000186470C50-0x0000000186470C5C 
		public static string operatingSystem { get => default; } // 0x000000018647177C-0x0000000186471788 
		public static OperatingSystemFamily operatingSystemFamily { get => default; } // 0x0000000186471718-0x0000000186471724 
		public static string bootParameters { get => default; } // 0x000000018646D4C0-0x000000018646D4CC 
		public static string processorType { get => default; } // 0x000000018646D4CC-0x000000018646D4D8 
		public static int processorCount { get => default; } // 0x00000001864717A0-0x00000001864717AC 
		public static int systemMemorySize { get => default; } // 0x00000001864717C4-0x00000001864717D0 
		public static string deviceUniqueIdentifier { get => default; } // 0x000000018646D498-0x000000018646D4A4 
		public static string deviceName { get => default; } // 0x0000000186471794-0x00000001864717A0 
		public static string deviceModel { get => default; } // 0x0000000186471788-0x0000000186471794 
		public static bool supportsAccelerometer { get => default; } // 0x000000018BEEF1D4-0x000000018BEEF1E0 
		public static bool supportsGyroscope { get => default; } // 0x000000018BEEF210-0x000000018BEEF21C 
		public static bool supportsLocationService { get => default; } // 0x000000018BEEF234-0x000000018BEEF240 
		public static bool supportsVibration { get => default; } // 0x000000018BEEF2C4-0x000000018BEEF2D0 
		public static bool supportsAudio { get => default; } // 0x000000018BEEF1EC-0x000000018BEEF1F8 
		public static UnityEngine.DeviceType deviceType { get => default; } // 0x000000018646D47C-0x000000018646D488 
		public static int graphicsMemorySize { get => default; } // 0x00000001864717AC-0x00000001864717B8 
		public static string graphicsDeviceName { get => default; } // 0x0000000186471764-0x0000000186471770 
		public static string graphicsDeviceVendor { get => default; } // 0x000000018646D4E0-0x000000018646D4EC 
		public static int graphicsDeviceVendorID { get => default; } // 0x0000000183F87DD0-0x0000000183F87E20 
		public static GraphicsDeviceType graphicsDeviceType { get => default; } // 0x00000001864717B8-0x00000001864717C4 
		public static string nvidiaDriverVersion { get => default; } // 0x000000018646D4B4-0x000000018646D4C0 
		public static bool graphicsUVStartsAtTop { get => default; } // 0x000000018BEEF168-0x000000018BEEF174 
		public static string graphicsDeviceVersion { get => default; } // 0x0000000186471770-0x000000018647177C 
		public static int graphicsShaderLevel { get => default; } // 0x000000018646F15C-0x000000018646F168 
		public static bool graphicsMultiThreaded { get => default; } // 0x000000018BEEF15C-0x000000018BEEF168 
		public static bool hasHiddenSurfaceRemovalOnGPU { get => default; } // 0x000000018BEEF180-0x000000018BEEF18C 
		public static bool hasDynamicUniformArrayIndexingInFragmentShaders { get => default; } // 0x000000018BEEF174-0x000000018BEEF180 
		public static bool supportsShadows { get => default; } // 0x000000018BEEF2A0-0x000000018BEEF2AC 
		public static bool supportsRawShadowDepthSampling { get => default; } // 0x000000018BEEF27C-0x000000018BEEF288 
		public static bool supportsMotionVectors { get => default; } // 0x000000018BEEF258-0x000000018BEEF264 
		public static bool supportsRenderToCubemap { get => default; } // 0x0000000185FC71B0-0x0000000185FC71C0 
		public static bool supportsImageEffects { get => default; } // 0x0000000185FC71B0-0x0000000185FC71C0 
		public static bool supports3DTextures { get => default; } // 0x000000018BEEF1C8-0x000000018BEEF1D4 
		public static bool supports2DArrayTextures { get => default; } // 0x000000018BEEF1B0-0x000000018BEEF1BC 
		public static bool supports3DRenderTextures { get => default; } // 0x000000018BEEF1BC-0x000000018BEEF1C8 
		public static bool supportsCubemapArrayTextures { get => default; } // 0x000000018BEEF1F8-0x000000018BEEF204 
		public static CopyTextureSupport copyTextureSupport { get => default; } // 0x000000018BEEF150-0x000000018BEEF15C 
		public static bool supportsComputeShaders { get => default; } // 0x00000001864725FC-0x0000000186472608 
		public static bool supportsRenderTargetArrayIndexFromVertexShader { get => default; } // 0x000000018BEEF288-0x000000018BEEF294 
		public static bool supportsInstancing { get => default; } // 0x000000018BEEF228-0x000000018BEEF234 
		public static bool supportsHardwareQuadTopology { get => default; } // 0x000000018BEEF21C-0x000000018BEEF228 
		public static bool supports32bitsIndexBuffer { get => default; } // 0x00000001864C6C74-0x00000001864C6C80 
		public static bool supportsSparseTextures { get => default; } // 0x000000018BEEF2AC-0x000000018BEEF2B8 
		public static int supportedRenderTargetCount { get => default; } // 0x000000018BEEF1A4-0x000000018BEEF1B0 
		public static bool supportsSeparatedRenderTargetsBlend { get => default; } // 0x000000018BEEF294-0x000000018BEEF2A0 
		public static int supportedRandomWriteTargetCount { get => default; } // 0x000000018BEEF198-0x000000018BEEF1A4 
		public static int supportsMultisampledTextures { get => default; } // 0x000000018BEEF264-0x000000018BEEF270 
		public static int supportsTextureWrapMirrorOnce { get => default; } // 0x000000018BEEF2B8-0x000000018BEEF2C4 
		public static bool usesReversedZBuffer { get => default; } // 0x0000000186472018-0x0000000186472024 
		public static int maxTextureSize { get => default; } // 0x00000001864C7F9C-0x00000001864C7FA8 
		internal static int maxRenderTextureSize { get => default; } // 0x000000018BEEF18C-0x000000018BEEF198 
		public static bool supportsGraphicsFence { get => default; } // 0x000000018BEEF204-0x000000018BEEF210 
		public static bool supportsAsyncGPUReadback { get => default; } // 0x000000018BEEF1E0-0x000000018BEEF1EC 
		public static bool supportsRayTracing { get => default; } // 0x0000000186475074-0x0000000186475080 
		public static uint waveIntrinsicsSupportedStages { get => default; } // 0x000000018BEEF2DC-0x000000018BEEF2E8 
		public static uint waveIntrinsicsSupportedOperations { get => default; } // 0x000000018BEEF2D0-0x000000018BEEF2DC 
		public static bool supportsMetalFXSpatialScaler { get => default; } // 0x000000018BEEF24C-0x000000018BEEF258 
		public static bool supportsMetalFXTemporalScaler { get => default; } // 0x000000018646EC8C-0x000000018646EC98 
		public static bool supportsQualcommAFME { get => default; } // 0x000000018BEEF270-0x000000018BEEF27C 
		public static bool supportsMediaTekMFRC { get => default; } // 0x000000018BEEF240-0x000000018BEEF24C 
		public static bool supportsCubicFilter { get => default; } // 0x00000001864717DC-0x00000001864717E8 
		public static int constantBufferOffsetAlignment { get => default; } // 0x000000018BEEF144-0x000000018BEEF150 
		public static long maxGraphicsBufferSize { get => default; } // 0x000000018647526C-0x0000000186475278 
		public static HDRDisplaySupportFlags hdrDisplaySupportFlags { get => default; } // 0x00000001864728B8-0x00000001864728C4 
	
		// Constructors
		public SystemInfo() {} // Dummy constructor
	
		// Methods
		private static bool IsValidEnumValue(Enum value) => default; // 0x0000000184016170-0x00000001840161F0
		public static bool SupportsRenderTextureFormat(RenderTextureFormat format) => default; // 0x000000018BEEF08C-0x000000018BEEF138
		public static bool SupportsTextureFormat(TextureFormat format) => default; // 0x00000001840160D0-0x0000000184016130
		private static float GetBatteryLevel() => default; // 0x0000000185F662B0-0x0000000185F662F0
		private static BatteryStatus GetBatteryStatus() => default; // 0x0000000185F569A0-0x0000000185F569E0
		private static string GetOperatingSystem() => default; // 0x0000000185B6E830-0x0000000185B6E870
		private static OperatingSystemFamily GetOperatingSystemFamily() => default; // 0x0000000185F56960-0x0000000185F569A0
		private static string HGGetBootParameters() => default; // 0x0000000185FA6F80-0x0000000185FA6FC0
		private static string GetProcessorType() => default; // 0x0000000185F5FA40-0x0000000185F5FA80
		private static int GetProcessorCount() => default; // 0x0000000185F5FA80-0x0000000185F5FAC0
		private static int GetPhysicalMemoryMB() => default; // 0x0000000185F37580-0x0000000185F375C0
		private static string GetDeviceUniqueIdentifier() => default; // 0x0000000185F5FAC0-0x0000000185F5FB00
		private static string GetDeviceName() => default; // 0x0000000185B3D200-0x0000000185B3D240
		private static string GetDeviceModel() => default; // 0x0000000185AD2050-0x0000000185AD2090
		private static bool SupportsAccelerometer() => default; // 0x0000000185FA6D00-0x0000000185FA6D40
		private static bool IsGyroAvailable() => default; // 0x0000000185FA6EC0-0x0000000185FA6F00
		private static bool SupportsLocationService() => default; // 0x0000000185FA6BC0-0x0000000185FA6C00
		private static bool SupportsVibration() => default; // 0x0000000185FA6980-0x0000000185FA69C0
		private static bool SupportsAudio() => default; // 0x0000000185FA6CC0-0x0000000185FA6D00
		private static UnityEngine.DeviceType GetDeviceType() => default; // 0x0000000185F7DBB0-0x0000000185F7DBF0
		private static int GetGraphicsMemorySize() => default; // 0x000000018519DCC0-0x000000018519DD00
		private static string GetGraphicsDeviceName() => default; // 0x0000000185B6E8B0-0x0000000185B6E8F0
		private static string GetGraphicsDeviceVendor() => default; // 0x0000000185BA6190-0x0000000185BA61D0
		private static int GetGraphicsDeviceVendorID() => default; // 0x0000000183F87DD0-0x0000000183F87E20
		private static GraphicsDeviceType GetGraphicsDeviceType() => default; // 0x0000000185BC9260-0x0000000185BC92A0
		private static string GetNvidiaDriverVersion() => default; // 0x0000000185FA6FC0-0x0000000185FA7000
		private static bool GetGraphicsUVStartsAtTop() => default; // 0x0000000185FA7080-0x0000000185FA70C0
		private static string GetGraphicsDeviceVersion() => default; // 0x0000000185B6E870-0x0000000185B6E8B0
		private static int GetGraphicsShaderLevel() => default; // 0x0000000185F7DB70-0x0000000185F7DBB0
		private static bool GetGraphicsMultiThreaded() => default; // 0x0000000185FA70C0-0x0000000185FA7100
		private static bool HasHiddenSurfaceRemovalOnGPU() => default; // 0x0000000185FA6F00-0x0000000185FA6F40
		private static bool HasDynamicUniformArrayIndexingInFragmentShaders() => default; // 0x0000000185FA6F40-0x0000000185FA6F80
		private static bool SupportsShadows() => default; // 0x0000000185FA6A40-0x0000000185FA6A80
		private static bool SupportsRawShadowDepthSampling() => default; // 0x0000000185FA6B00-0x0000000185FA6B40
		private static bool SupportsMotionVectors() => default; // 0x0000000185FA6B80-0x0000000185FA6BC0
		private static bool Supports3DTextures() => default; // 0x0000000185FA6D40-0x0000000185FA6D80
		private static bool Supports2DArrayTextures() => default; // 0x0000000185FA6E00-0x0000000185FA6E40
		private static bool Supports3DRenderTextures() => default; // 0x0000000185FA6D80-0x0000000185FA6DC0
		private static bool SupportsCubemapArrayTextures() => default; // 0x0000000185FA6C80-0x0000000185FA6CC0
		private static CopyTextureSupport GetCopyTextureSupport() => default; // 0x0000000185FA7100-0x0000000185FA7140
		private static bool SupportsComputeShaders() => default; // 0x0000000185292FB0-0x0000000185292FF0
		private static bool SupportsRenderTargetArrayIndexFromVertexShader() => default; // 0x000000018BEEF060-0x000000018BEEF08C
		private static bool SupportsInstancing() => default; // 0x0000000185FA6C00-0x0000000185FA6C40
		private static bool SupportsHardwareQuadTopology() => default; // 0x0000000185FA6C40-0x0000000185FA6C80
		private static bool Supports32bitsIndexBuffer() => default; // 0x0000000185FA6DC0-0x0000000185FA6E00
		private static bool SupportsSparseTextures() => default; // 0x0000000185FA6A00-0x0000000185FA6A40
		private static int SupportedRenderTargetCount() => default; // 0x0000000185FA6E40-0x0000000185FA6E80
		private static bool SupportsSeparatedRenderTargetsBlend() => default; // 0x0000000185FA6A80-0x0000000185FA6AC0
		private static int SupportedRandomWriteTargetCount() => default; // 0x000000018BEEEF58-0x000000018BEEEF84
		private static int SupportsMultisampledTextures() => default; // 0x0000000185FA6B40-0x0000000185FA6B80
		private static int SupportsTextureWrapMirrorOnce() => default; // 0x0000000185FA69C0-0x0000000185FA6A00
		private static bool UsesReversedZBuffer() => default; // 0x0000000185F8BE40-0x0000000185F8BE80
		private static bool HasRenderTextureNative(RenderTextureFormat format) => default; // 0x000000018BEEEEF8-0x000000018BEEEF2C
		private static bool SupportsTextureFormatNative(TextureFormat format) => default; // 0x0000000184016130-0x0000000184016170
		private static int GetMaxTextureSize() => default; // 0x0000000185FA7000-0x0000000185FA7040
		private static int GetMaxRenderTextureSize() => default; // 0x000000018BEEEE74-0x000000018BEEEEA0
		private static bool SupportsGPUFence() => default; // 0x000000018BEEEFB0-0x000000018BEEEFDC
		private static bool SupportsAsyncGPUReadback() => default; // 0x000000018BEEEF84-0x000000018BEEEFB0
		private static bool SupportsRayTracing() => default; // 0x0000000185FA6AC0-0x0000000185FA6B00
		private static uint GetWaveIntrinsicsSupportedStages() => default; // 0x000000018BEEEECC-0x000000018BEEEEF8
		private static uint GetWaveIntrinsicsSupportedOperations() => default; // 0x000000018BEEEEA0-0x000000018BEEEECC
		private static bool SupportsMetalFXSpatialScaler() => default; // 0x000000018BEEF008-0x000000018BEEF034
		private static bool SupportsMetalFXTemporalScaler() => default; // 0x000000018545AE00-0x000000018545AE40
		private static bool SupportsQualcommAFME() => default; // 0x000000018BEEF034-0x000000018BEEF060
		private static bool SupportsMediaTekMFRC() => default; // 0x000000018BEEEFDC-0x000000018BEEF008
		private static bool SupportsCubicFilter() => default; // 0x000000018519DFE0-0x000000018519E020
		private static int MinConstantBufferOffsetAlignment() => default; // 0x000000018BEEEF2C-0x000000018BEEEF58
		private static long MaxGraphicsBufferSize() => default; // 0x0000000185FA6E80-0x0000000185FA6EC0
		public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) => default; // 0x0000000184015C20-0x0000000184015C70
		public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) => default; // 0x00000001840149D0-0x0000000184014A20
		public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) => default; // 0x000000018BEEEE40-0x000000018BEEEE74
		private static HDRDisplaySupportFlags GetHDRDisplaySupportFlags() => default; // 0x0000000185FA7040-0x0000000185FA7080
	}

	internal class SystemClock // TypeDefIndex: 47630
	{
		// Fields
		private static readonly System.DateTime s_Epoch; // 0x00
	
		// Properties
		public static System.DateTime now { get => default; } // 0x000000018BEEEE00-0x000000018BEEEE40 
	
		// Constructors
		public SystemClock() {} // Dummy constructor
		static SystemClock() {} // 0x000000018BEEED88-0x000000018BEEEE00
	}

	public class Time // TypeDefIndex: 47631
	{
		// Properties
		public static float time { get => default; } // 0x00000001844C7770-0x00000001844C77B0 
		public static double timeAsDouble { get => default; } // 0x00000001843FB220-0x00000001843FB260 
		public static float timeSinceLevelLoad { get => default; } // 0x0000000184634530-0x0000000184634570 
		public static double timeSinceLevelLoadAsDouble { get => default; } // 0x000000018BEEF620-0x000000018BEEF64C 
		public static float deltaTime { get => default; } // 0x00000001844B3750-0x00000001844B3790 
		public static float fixedTime { get => default; } // 0x000000018BEEF4C0-0x000000018BEEF4EC 
		public static double fixedTimeAsDouble { get => default; } // 0x000000018BEEF494-0x000000018BEEF4C0 
		public static float unscaledTime { get => default; } // 0x000000018429F4A0-0x000000018429F4E0 
		public static double unscaledTimeAsDouble { get => default; } // 0x000000018BEEF64C-0x000000018BEEF678 
		public static float fixedUnscaledTime { get => default; } // 0x000000018BEEF544-0x000000018BEEF570 
		public static double fixedUnscaledTimeAsDouble { get => default; } // 0x000000018BEEF518-0x000000018BEEF544 
		public static float unscaledDeltaTime { get => default; } // 0x0000000183F9ED00-0x0000000183F9ED40 
		public static float fixedUnscaledDeltaTime { get => default; } // 0x000000018BEEF4EC-0x000000018BEEF518 
		public static float fixedDeltaTime { get => default; set {} } // 0x0000000184407A40-0x0000000184407A80 0x0000000185428320-0x0000000185428370
		public static float maximumDeltaTime { get => default; set {} } // 0x000000018BEEF59C-0x000000018BEEF5C8 0x00000001854282D0-0x0000000185428320
		public static float smoothDeltaTime { get => default; } // 0x00000001850D0FA0-0x00000001850D0FE0 
		public static float maximumParticleDeltaTime { get => default; set {} } // 0x000000018BEEF5C8-0x000000018BEEF5F4 0x000000018BEEF6D8-0x000000018BEEF714
		public static float timeScale { get => default; set {} } // 0x0000000184E74F90-0x0000000184E74FD0 0x000000018BEEF714-0x000000018BEEF750
		public static int frameCount { get => default; } // 0x000000018406D470-0x000000018406D820 
		public static int renderedFrameCount { get => default; } // 0x000000018BEEF5F4-0x000000018BEEF620 
		public static float realtimeSinceStartup { get => default; } // 0x00000001841B0E20-0x00000001841B0E60 
		public static double realtimeSinceStartupAsDouble { get => default; } // 0x00000001841CF2D0-0x00000001841CF370 
		public static float captureDeltaTime { get => default; set {} } // 0x000000018BEEF428-0x000000018BEEF454 0x000000018BEEF678-0x000000018BEEF6B4
		public static int captureFramerate { get => default; set {} } // 0x000000018BEEF454-0x000000018BEEF494 0x000000018BEEF6B4-0x000000018BEEF6D8
		public static bool inFixedTimeStep { get => default; } // 0x000000018BEEF570-0x000000018BEEF59C 
	
		// Constructors
		public Time() {} // 0x0000000185492010-0x0000000185492020
	}

	internal struct TouchScreenKeyboard_InternalConstructorHelperArguments // TypeDefIndex: 47632
	{
		// Fields
		public uint keyboardType; // 0x00
		public uint autocorrection; // 0x04
		public uint multiline; // 0x08
		public uint secure; // 0x0C
		public uint alert; // 0x10
		public int characterLimit; // 0x14
	}

	public class TouchScreenKeyboard // TypeDefIndex: 47634
	{
		// Fields
		[NonSerialized]
		internal IntPtr m_Ptr; // 0x10
		private static bool _disableInPlaceEditing_k__BackingField; // 0x00
	
		// Properties
		public static bool isSupported { get => default; } // 0x0000000184A17800-0x0000000184A17830 
		internal static bool disableInPlaceEditing { get; } // 0x000000018BEEFC14-0x000000018BEEFC4C 
		public static bool isInPlaceEditingAllowed { get => default; } // 0x000000018BEEFC4C-0x000000018BEEFC74 
		internal static bool isRequiredToForceOpen { get => default; } // 0x000000018BEEFC74-0x000000018BEEFC80 
		public string text { get => default; set {} } // 0x000000018BEEFCE0-0x000000018BEEFD14 0x000000018BEEFE80-0x000000018BEEFEC4
		public static bool hideInput { set {} } // 0x000000018BEEFD98-0x000000018BEEFDCC
		public bool active { get => default; set {} } // 0x000000018BEEFB78-0x000000018BEEFBAC 0x000000018BEEFD14-0x000000018BEEFD58
		public Status status { get => default; } // 0x000000018BEEFCAC-0x000000018BEEFCE0 
		public int characterLimit { set {} } // 0x000000018BEEFD58-0x000000018BEEFD98
		public bool canGetSelection { get => default; } // 0x000000018BEEFBAC-0x000000018BEEFBE0 
		public bool canSetSelection { get => default; } // 0x000000018BEEFBE0-0x000000018BEEFC14 
		public RangeInt selection { get => default; set {} } // 0x000000018BEEFC80-0x000000018BEEFCAC 0x000000018BEEFDCC-0x000000018BEEFE80
	
		// Nested types
		public enum Status // TypeDefIndex: 47633
		{
			Visible = 0,
			Done = 1,
			Canceled = 2,
			LostFocus = 3
		}
	
		// Constructors
		public TouchScreenKeyboard() {} // Dummy constructor
		public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) {} // 0x000000018BEEFA9C-0x000000018BEEFB78
	
		// Methods
		private static void Internal_Destroy(IntPtr ptr) {} // 0x000000018BEEF85C-0x000000018BEEF890
		private void Destroy() {} // 0x000000018BEEF750-0x000000018BEEF7A8
		~TouchScreenKeyboard() {} // 0x000000018BEEF7A8-0x000000018BEEF818
		private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) => default; // 0x000000018BEEFA48-0x000000018BEEFA9C
		private static bool IsRequiredToForceOpen() => default; // 0x000000018BEEF890-0x000000018BEEF8BC
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) => default; // 0x000000018BEEF8BC-0x000000018BEEF980
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) => default; // 0x000000018BEEF980-0x000000018BEEFA08
		private static void GetSelection(out int start, out int length) {
			start = default;
			length = default;
		} // 0x000000018BEEF818-0x000000018BEEF85C
		private static void SetSelection(int start, int length) {} // 0x000000018BEEFA08-0x000000018BEEFA48
	}

	public enum TouchScreenKeyboardType // TypeDefIndex: 47635
	{
		Default = 0,
		ASCIICapable = 1,
		NumbersAndPunctuation = 2,
		URL = 3,
		NumberPad = 4,
		PhonePad = 5,
		NamePhonePad = 6,
		EmailAddress = 7,
		NintendoNetworkAccount = 8,
		Social = 9,
		Search = 10,
		DecimalPad = 11,
		OneTimeCode = 12
	}

	public static class FrameDebugger // TypeDefIndex: 47636
	{
		// Properties
		public static bool enabled { get; } // 0x0000000184235220-0x0000000184235250 
	
		// Methods
		internal static bool IsLocalEnabled() => default; // 0x00000001842351A0-0x00000001842351E0
		internal static bool IsRemoteEnabled() => default; // 0x00000001842351E0-0x0000000184235220
	}

	public enum DrivenTransformProperties // TypeDefIndex: 47637
	{
		All = -1,
		None = 0,
		AnchoredPositionX = 2,
		AnchoredPositionY = 4,
		AnchoredPosition = 6,
		AnchoredPositionZ = 8,
		AnchoredPosition3D = 14,
		Rotation = 16,
		ScaleX = 32,
		ScaleY = 64,
		ScaleZ = 128,
		Scale = 224,
		AnchorMinX = 256,
		AnchorMinY = 512,
		AnchorMin = 768,
		AnchorMaxX = 1024,
		AnchorMaxY = 2048,
		AnchorMax = 3072,
		Anchors = 3840,
		SizeDeltaX = 4096,
		SizeDeltaY = 8192,
		SizeDelta = 12288,
		PivotX = 16384,
		PivotY = 32768,
		Pivot = 49152
	}

	public struct DrivenRectTransformTracker // TypeDefIndex: 47638
	{
		// Methods
		public void Add(UnityEngine.Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties) {} // 0x0000000185492010-0x0000000185492020
		public void Clear() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class RectTransform : Transform // TypeDefIndex: 47642
	{
		// Fields
		private static ReapplyDrivenProperties reapplyDrivenProperties; // 0x00
	
		// Properties
		public Rect rect { get => default; } // 0x000000018646ED88-0x000000018646EDA4 
		public Vector2 anchorMin { get => default; set {} } // 0x0000000183F90500-0x0000000183F90550 0x000000018646ED6C-0x000000018646ED88
		public Vector2 anchorMax { get => default; set {} } // 0x0000000184432530-0x0000000184432580 0x000000018646ED50-0x000000018646ED6C
		public Vector2 anchoredPosition { get => default; set {} } // 0x00000001844325D0-0x0000000184432620 0x000000018646EF40-0x000000018646EF5C
		public Vector2 sizeDelta { get => default; set {} } // 0x0000000184432050-0x00000001844320A0 0x000000018646F588-0x000000018646F5A4
		public Vector2 pivot { get => default; set {} } // 0x000000018BEEBF70-0x000000018BEEBFDC 0x0000000184D85170-0x0000000184D851F0
		public Vector3 anchoredPosition3D { get => default; set {} } // 0x00000001845A7440-0x00000001845A74B0 0x00000001845A74B0-0x00000001845A75D0
		public Vector2 offsetMin { get => default; set {} } // 0x00000001845A7640-0x00000001845A76D0 0x00000001845A76D0-0x00000001845A7800
		public Vector2 offsetMax { get => default; set {} } // 0x000000018BEEBFDC-0x000000018BEEC010 0x000000018BEEC0EC-0x000000018BEEC130
		public UnityEngine.Object drivenByObject { get => default; internal set {} } // 0x000000018BEEC010-0x000000018BEEC044 0x000000018BEEC130-0x000000018BEEC170
		internal DrivenTransformProperties drivenProperties { get => default; set {} } // 0x000000018BEEBBB8-0x000000018BEEBBEC 0x00000001840ECB30-0x00000001840ECC80
	
		// Events
		public static event ReapplyDrivenProperties reapplyDrivenProperties;
	
		// Nested types
		public enum Edge // TypeDefIndex: 47639
		{
			Left = 0,
			Right = 1,
			Top = 2,
			Bottom = 3
		}
	
		public enum Axis // TypeDefIndex: 47640
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		public delegate void ReapplyDrivenProperties(RectTransform driven); // TypeDefIndex: 47641; 0x000000018BEEC044-0x000000018BEEC0EC
	
		// Constructors
		public RectTransform() {} // 0x0000000183F904B0-0x0000000183F90500
	
		// Methods
		public void ForceUpdateRectTransforms() {} // 0x00000001840EC250-0x00000001840EC570
		public void GetLocalCorners(Vector3[] fourCornersArray) {} // 0x000000018BEEBDF8-0x000000018BEEBF70
		public void GetWorldCorners(Vector3[] fourCornersArray) {} // 0x0000000183F90300-0x0000000183F90460
		public void SetInsetAndSizeFromParentEdge(Edge edge, float inset, float size) {} // 0x0000000184C746C0-0x0000000184C74820
		public void SetSizeWithCurrentAnchors(Axis axis, float size) {} // 0x000000018BEEBBEC-0x000000018BEEBDF8
		internal static void SendReapplyDrivenProperties(RectTransform driven) {} // 0x0000000183F905A0-0x0000000183F90670
		internal Rect GetRectInParentSpace() => default; // 0x000000018646DB20-0x000000018646DB28
		private Vector2 GetParentSize() => default; // 0x00000001840E2D20-0x00000001840E2D70
		private void get_rect_Injected(out Rect ret) {
			ret = default;
		} // 0x0000000184F70540-0x0000000184F70590
		private void get_anchorMin_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000183F90550-0x0000000183F905A0
		private void set_anchorMin_Injected(ref Vector2 value) {} // 0x0000000184F5EE70-0x0000000184F5EEC0
		private void get_anchorMax_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000184432580-0x00000001844325D0
		private void set_anchorMax_Injected(ref Vector2 value) {} // 0x0000000184EE5320-0x0000000184EE5370
		private void get_anchoredPosition_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000184432620-0x0000000184432670
		private void set_anchoredPosition_Injected(ref Vector2 value) {} // 0x0000000184DE0E20-0x0000000184DE0E70
		private void get_sizeDelta_Injected(out Vector2 ret) {
			ret = default;
		} // 0x00000001844320A0-0x00000001844320F0
		private void set_sizeDelta_Injected(ref Vector2 value) {} // 0x0000000185800250-0x00000001858002A0
		private void get_pivot_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000185A88B70-0x0000000185A88C00
		private void set_pivot_Injected(ref Vector2 value) {} // 0x00000001833EEC70-0x00000001833EEC80
	}

	internal enum RotationOrder // TypeDefIndex: 47643
	{
		OrderXYZ = 0,
		OrderXZY = 1,
		OrderYZX = 2,
		OrderYXZ = 3,
		OrderZXY = 4,
		OrderZYX = 5
	}

	public class Transform : Component, IEnumerable // TypeDefIndex: 47645
	{
		// Properties
		public Vector3 position { get => default; set {} } // 0x000000018BEF061C-0x000000018BEF064C 0x000000018BEF1144-0x000000018BEF1158
		public Vector3 localPosition { get => default; set {} } // 0x000000018BEF119C-0x000000018BEF11B0 0x000000018421AD30-0x000000018421AE30
		public Vector3 eulerAngles { get => default; set {} } // 0x000000018428D280-0x000000018428D320 0x000000018BEF17C0-0x000000018BEF182C
		public Vector3 localEulerAngles { get => default; set {} } // 0x00000001844E2790-0x00000001844E2830 0x000000018BEF1834-0x000000018BEF18A0
		public Vector3 right { get => default; set {} } // 0x00000001840EDD90-0x00000001840EDE50 0x0000000184329E10-0x0000000184329EA0
		public Vector3 up { get => default; set {} } // 0x00000001840EDE50-0x00000001840EDEB0 0x000000018646E3A4-0x000000018646E3B8
		public Vector3 forward { get => default; set {} } // 0x00000001842156C0-0x0000000184215720 0x000000018646E37C-0x000000018646E390
		public Quaternion rotation { get => default; set {} } // 0x000000018BEF16FC-0x000000018BEF1708 0x000000018BEF182C-0x000000018BEF1834
		public Quaternion localRotation { get => default; set {} } // 0x000000018BEF081C-0x000000018BEF0850 0x000000018BEF1218-0x000000018BEF1258
		internal UnityEngine.RotationOrder rotationOrder { get => default; set {} } // 0x00000001844C3740-0x00000001844C37A0 0x000000018646DBAC-0x000000018646DBC0
		public Vector3 localScale { get => default; set {} } // 0x000000018646D51C-0x000000018646D528 0x000000018646DC88-0x000000018646DC94
		public Transform parent { get => default; set {} } // 0x0000000183FD1710-0x0000000183FD1750 0x000000018646DC88-0x000000018646DC94
		internal Transform parentInternal { get => default; set {} } // 0x0000000184266AE0-0x0000000184266B40 0x00000001840E1290-0x00000001840E1300
		public Matrix4x4 worldToLocalMatrix { get => default; } // 0x00000001864729FC-0x0000000186472A10 
		public Matrix4x4 localToWorldMatrix { get => default; } // 0x00000001844E8870-0x00000001844E88D0 
		public Transform root { get => default; } // 0x0000000184A15A50-0x0000000184A15A90 
		public int childCount { get => default; } // 0x00000001850AAC60-0x00000001850AACB0 
		public Vector3 lossyScale { get => default; } // 0x000000018BEF04F0-0x000000018BEF0564 
		public bool hasChanged { get => default; set {} } // 0x000000018BEF0D94-0x000000018BEF0DA8 0x000000018BEF0BCC-0x000000018BEF0BE0
		public int hierarchyCapacity { get => default; set {} } // 0x000000018BEF16A0-0x000000018BEF16AC 0x000000018BEF173C-0x000000018BEF1770
		public int hierarchyCount { get => default; } // 0x000000018BEF17B0-0x000000018BEF17B8 
		internal bool constrainProportionsScale { get => default; set {} } // 0x0000000184217520-0x0000000184217570 0x0000000184786DA0-0x0000000184786DF0
	
		// Nested types
		private class Enumerator : IEnumerator // TypeDefIndex: 47644
		{
			// Fields
			private Transform outer; // 0x10
			private int currentIndex; // 0x18
	
			// Properties
			public object Current { get => default; } // 0x00000001842174C0-0x0000000184217520 
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			internal Enumerator(Transform outer) {} // 0x000000018646DB20-0x000000018646DB28
	
			// Methods
			public bool MoveNext() => default; // 0x000000018646E390-0x000000018646E3A4
			public void Reset() {} // 0x0000000184215610-0x0000000184215670
		}
	
		// Constructors
		protected Transform() {} // 0x000000018646DC94-0x000000018646DCA8
	
		// Methods
		internal Vector3 GetLocalEulerAngles(UnityEngine.RotationOrder order) => default; // 0x00000001845F1F20-0x00000001845F1FC0
		internal void SetLocalEulerAngles(Vector3 euler, UnityEngine.RotationOrder order) {} // 0x000000018BEF16AC-0x000000018BEF16FC
		internal void SetLocalEulerHint(Vector3 euler) {} // 0x0000000184382090-0x0000000184382130
		internal int GetRotationOrderInternal() => default; // 0x0000000183FD1710-0x0000000183FD1750
		internal void SetRotationOrderInternal(UnityEngine.RotationOrder rotationOrder) {} // 0x00000001840F7350-0x00000001840F73F0
		private Transform GetParent() => default; // 0x000000018416CD50-0x000000018416CDC0
		public void SetParent(Transform p) {} // 0x000000018BEF06F4-0x000000018BEF0730
		public void SetParent(Transform parent, bool worldPositionStays) {} // 0x000000018646EFEC-0x000000018646F000
		public Matrix4x4 GetLocalToRelativeMatrix(Transform relativeT) => default; // 0x000000018BEF064C-0x000000018BEF06A0
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation) {} // 0x000000018BEF1204-0x000000018BEF1218
		public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) {} // 0x000000018BEF0730-0x000000018BEF0794
		public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x000000018BEF07E8-0x000000018BEF081C
		public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation) {
			localPosition = default;
			localRotation = default;
		} // 0x000000018BEF0598-0x000000018BEF05CC
		public void SetRelativePosition(Transform relativeT, Vector3 position) {} // 0x000000018BEF1548-0x000000018BEF1634
		public void GetRelativePositionAndRotation(Transform relativeT, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x000000018BEF13D0-0x000000018BEF1400
		public Vector3 GetRelativePosition(Transform relativeT) => default; // 0x000000018BEF1634-0x000000018BEF1660
		public int GetHierarchyIndex() => default; // 0x000000018BEF1660-0x000000018BEF168C
		public void Translate(Vector3 translation, UnityEngine.Space relativeTo) {} // 0x000000018BEF1400-0x000000018BEF151C
		public void Translate(Vector3 translation) {} // 0x000000018BEF151C-0x000000018BEF1548
		public void Translate(float x, float y, float z, UnityEngine.Space relativeTo) {} // 0x000000018BEF0EE4-0x000000018BEF104C
		public void Translate(float x, float y, float z) {} // 0x000000018BEF0DA8-0x000000018BEF0DD8
		public void Translate(Vector3 translation, Transform relativeTo) {} // 0x000000018BEF104C-0x000000018BEF1078
		public void Translate(float x, float y, float z, Transform relativeTo) {} // 0x000000018BEF0EB8-0x000000018BEF0EE4
		public void Rotate(Vector3 eulers, UnityEngine.Space relativeTo) {} // 0x000000018BEF0B64-0x000000018BEF0B78
		public void Rotate(Vector3 eulers) {} // 0x000000018BEF0E0C-0x000000018BEF0EB8
		public void Rotate(float xAngle, float yAngle, float zAngle, UnityEngine.Space relativeTo) {} // 0x000000018BEF0DD8-0x000000018BEF0E0C
		public void Rotate(float xAngle, float yAngle, float zAngle) {} // 0x000000018BEF0C34-0x000000018BEF0D94
		internal void RotateAroundInternal(Vector3 axis, float angle) {} // 0x000000018BEF09BC-0x000000018BEF0A6C
		public void Rotate(Vector3 axis, float angle, UnityEngine.Space relativeTo) {} // 0x00000001845A94F0-0x00000001845A95D0
		public void Rotate(Vector3 axis, float angle) {} // 0x000000018646F5A4-0x000000018646F5E4
		public void RotateAround(Vector3 point, Vector3 axis, float angle) {} // 0x000000018BEF0A6C-0x000000018BEF0ABC
		public void LookAt(Transform target, Vector3 worldUp) {} // 0x000000018BEF0850-0x000000018BEF0864
		public void LookAt(Transform target) {} // 0x00000001844E7430-0x00000001844E74A0
		public void LookAt(Vector3 worldPosition, Vector3 worldUp) {} // 0x000000018BEF1258-0x000000018BEF12A8
		public void LookAt(Vector3 worldPosition) {} // 0x000000018503B410-0x000000018503B480
		private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) {} // 0x000000018BEF0864-0x000000018BEF08B4
		public Vector3 TransformDirection(Vector3 direction) => default; // 0x000000018BEF139C-0x000000018BEF13D0
		public Vector3 TransformDirection(float x, float y, float z) => default; // 0x000000018BEF134C-0x000000018BEF139C
		public Vector3 InverseTransformDirection(Vector3 direction) => default; // 0x000000018489A250-0x000000018489A2C0
		public Vector3 InverseTransformDirection(float x, float y, float z) => default; // 0x000000018BEF0904-0x000000018BEF0954
		public Vector3 TransformVector(Vector3 vector) => default; // 0x000000018421CFF0-0x000000018421D060
		public Vector3 TransformVector(float x, float y, float z) => default; // 0x000000018BEF12A8-0x000000018BEF12F8
		public Vector3 InverseTransformVector(Vector3 vector) => default; // 0x00000001840E87E0-0x00000001840E8850
		public Vector3 InverseTransformVector(float x, float y, float z) => default; // 0x000000018BEF08B4-0x000000018BEF0904
		public Vector3 TransformPoint(Vector3 position) => default; // 0x0000000186474670-0x000000018647467C
		public Vector3 TransformPoint(float x, float y, float z) => default; // 0x0000000185F7DAF0-0x0000000185F7DB30
		public Vector3 InverseTransformPoint(Vector3 position) => default; // 0x0000000183FD2A60-0x0000000183FD2AA0
		public Vector3 InverseTransformPoint(float x, float y, float z) => default; // 0x000000018BEF04BC-0x000000018BEF04F0
		private Transform GetRoot() => default; // 0x000000018530E580-0x000000018530E5C0
		public void DetachChildren() {} // 0x000000018BEF0ABC-0x000000018BEF0B10
		public void SetAsFirstSibling() {} // 0x0000000185673820-0x00000001856738F0
		public void SetAsLastSibling() {} // 0x0000000184B45850-0x0000000184B458B0
		public void SetSiblingIndex(int index) {} // 0x0000000184B45830-0x0000000184B45850
		internal void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty) {} // 0x0000000184267C70-0x0000000184267CC0
		public int GetSiblingIndex() => default; // 0x0000000184267C10-0x0000000184267C70
		private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) => default; // 0x000000018BEF1078-0x000000018BEF10AC
		public Transform Find(string n) => default; // 0x00000001840E77A0-0x00000001840E7800
		private static Transform FindTransformWithName(Transform transform, string name) => default; // 0x0000000184D81C40-0x0000000184D81C90
		public Transform FindRecursiveWithName(string name) => default; // 0x000000018416FCD0-0x000000018416FD10
		internal void SendTransformChangedScale() {} // 0x0000000184384F70-0x0000000184384FC0
		public bool IsChildOf(Transform parent) => default; // 0x0000000184FC80C0-0x0000000184FC8120
		public Transform FindChild(string n) => default; // 0x0000000183FD2BE0-0x0000000183FD2C30
		public IEnumerator GetEnumerator() => default; // 0x000000018BEF0564-0x000000018BEF0598
		public void RotateAround(Vector3 axis, float angle) {} // 0x000000018BEF1694-0x000000018BEF16A0
		public void RotateAroundLocal(Vector3 axis, float angle) {} // 0x000000018BEF17B8-0x000000018BEF17C0
		public Transform GetChild(int index) => default; // 0x000000018BEF1708-0x000000018BEF173C
		public int GetChildCount() => default; // 0x000000018BEF1770-0x000000018BEF17B0
		private int internal_getHierarchyCapacity() => default; // 0x000000018BEF0988-0x000000018BEF09BC
		private void internal_setHierarchyCapacity(int value) {} // 0x000000018BEF168C-0x000000018BEF1694
		private int internal_getHierarchyCount() => default; // 0x000000018BEF10AC-0x000000018BEF10F0
		internal bool IsNonUniformScaleTransform() => default; // 0x000000018BEF0954-0x000000018BEF0988
		private void SetConstrainProportionsScale(bool isLinked) {} // 0x0000000184215670-0x00000001842156C0
		private bool IsConstrainProportionsScale() => default; // 0x0000000184D86780-0x0000000184D867D0
		private void get_position_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEF05CC-0x000000018BEF061C
		private void set_position_Injected(ref Vector3 value) {} // 0x000000018BEF10F0-0x000000018BEF1144
		private void get_localPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEF1158-0x000000018BEF119C
		private void set_localPosition_Injected(ref Vector3 value) {} // 0x00000001840EDEB0-0x00000001840EE8F0
		private void GetLocalEulerAngles_Injected(UnityEngine.RotationOrder order, out Vector3 ret) {
			ret = default;
		} // 0x0000000184784C90-0x0000000184784CE0
		private void SetLocalEulerAngles_Injected(ref Vector3 euler, UnityEngine.RotationOrder order) {} // 0x0000000184215720-0x0000000184215770
		private void SetLocalEulerHint_Injected(ref Vector3 euler) {} // 0x000000018494CD20-0x000000018494CD70
		private void get_rotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x00000001844C37A0-0x00000001844C37F0
		private void set_rotation_Injected(ref Quaternion value) {} // 0x0000000184A113D0-0x0000000184A11420
		private void get_localRotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x00000001840E1300-0x00000001840E1350
		private void set_localRotation_Injected(ref Quaternion value) {} // 0x000000018416CDC0-0x000000018416CE10
		private void get_localScale_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BEF06A0-0x000000018BEF06F4
		private void set_localScale_Injected(ref Vector3 value) {} // 0x0000000184F43250-0x0000000184F432B0
		private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000185F50E40-0x0000000185F50EA0
		private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BEF11B0-0x000000018BEF1204
		private void GetLocalToRelativeMatrix_Injected(Transform relativeT, out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BEF0794-0x000000018BEF07E8
		private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) {} // 0x000000018BEF0B10-0x000000018BEF0B64
		private void SetLocalPositionAndRotation_Injected(ref Vector3 localPosition, ref Quaternion localRotation) {} // 0x00000001851703F0-0x0000000185170450
		private void SetRelativePosition_Injected(Transform relativeT, ref Vector3 position) {} // 0x00000001844E74A0-0x00000001844E7500
		private void GetRelativePosition_Injected(Transform relativeT, out Vector3 ret) {
			ret = default;
		} // 0x000000018503B480-0x000000018503B4E0
		private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) {} // 0x000000018BEF12F8-0x000000018BEF134C
		private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) {} // 0x000000018489A2C0-0x000000018489A320
		private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) {
			ret = default;
		} // 0x000000018421D060-0x000000018421D0C0
		private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) {
			ret = default;
		} // 0x00000001840E8850-0x00000001840E88B0
		private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) {
			ret = default;
		} // 0x00000001840E7800-0x00000001840E7850
		private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEF0BE0-0x000000018BEF0C34
		private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x000000018BEF0B78-0x000000018BEF0BCC
		private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x00000001844A9C00-0x00000001844A9C20
		private void get_lossyScale_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001857A7C20-0x00000001857A7C50
		private void RotateAround_Injected(ref Vector3 axis, float angle) {} // 0x000000018568B370-0x000000018568B3B0
		private void RotateAroundLocal_Injected(ref Vector3 axis, float angle) {} // 0x0000000185FB1880-0x0000000185FB1890
	}

	public enum SpriteMaskInteraction // TypeDefIndex: 47646
	{
		None = 0,
		VisibleInsideMask = 1,
		VisibleOutsideMask = 2
	}

	public sealed class SpriteRenderer : Renderer // TypeDefIndex: 47647
	{
		// Fields
		private UnityEvent<SpriteRenderer> m_SpriteChangeEvent; // 0x18
	
		// Properties
		public Sprite sprite { get => default; set {} } // 0x000000018BEED580-0x000000018BEED5B4 0x000000018BEED694-0x000000018BEED6D8
		public UnityEngine.Color color { get => default; set {} } // 0x000000018BEED4EC-0x000000018BEED518 0x000000018BEED5F8-0x000000018BEED60C
		public bool flipX { get => default; set {} } // 0x000000018BEED518-0x000000018BEED54C 0x000000018BEED60C-0x000000018BEED650
		public bool flipY { get => default; set {} } // 0x000000018BEED54C-0x000000018BEED580 0x000000018BEED650-0x000000018BEED694
	
		// Constructors
		public SpriteRenderer() {} // Dummy constructor
	
		// Methods
		private void InvokeSpriteChanged() {} // 0x000000018BEED3D0-0x000000018BEED4A8
		private void get_color_Injected(out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BEED4A8-0x000000018BEED4EC
		private void set_color_Injected(ref UnityEngine.Color value) {} // 0x000000018BEED5B4-0x000000018BEED5F8
	}

	public enum SpriteMeshType // TypeDefIndex: 47648
	{
		FullRect = 0,
		Tight = 1
	}

	public enum SpritePackingMode // TypeDefIndex: 47649
	{
		Tight = 0,
		Rectangle = 1
	}

	public enum SpritePackingRotation // TypeDefIndex: 47650
	{
		None = 0,
		FlipHorizontal = 1,
		FlipVertical = 2,
		Rotate180 = 3,
		Any = 15
	}

	public sealed class Sprite : UnityEngine.Object // TypeDefIndex: 47651
	{
		// Fields
		private static Action<List<Sprite>> dynamicAtlasFinishCallback; // 0x00
	
		// Properties
		public Bounds bounds { get => default; } // 0x000000018BEEE6BC-0x000000018BEEE6EC 
		public Rect rect { get => default; } // 0x0000000184045100-0x0000000184045160 
		public Vector4 border { get => default; } // 0x0000000183F91820-0x0000000183F91880 
		public Texture2D texture { get => default; } // 0x0000000184047700-0x0000000184047740 
		public float pixelsPerUnit { get => default; } // 0x0000000183F91D90-0x0000000183F91DD0 
		public float spriteAtlasTextureScale { get => default; } // 0x000000018BEEE76C-0x000000018BEEE7A0 
		public Texture2D associatedAlphaSplitTexture { get => default; } // 0x0000000184044FA0-0x0000000184044FE0 
		public Vector2 pivot { get => default; } // 0x000000018BEEE748-0x000000018BEEE76C 
		public bool packed { get => default; } // 0x000000018404BC60-0x000000018404BCB0 
		public bool dynamicPacked { get => default; } // 0x000000018404B1C0-0x000000018404B200 
		public SpritePackingMode packingMode { get => default; } // 0x000000018BEEE6EC-0x000000018BEEE6F8 
		public SpritePackingRotation packingRotation { get => default; } // 0x000000018BEEE6F8-0x000000018BEEE704 
		public Rect textureRect { get => default; } // 0x000000018BEEE7EC-0x000000018BEEE84C 
		public Vector2 textureRectOffset { get => default; } // 0x000000018BEEE7A0-0x000000018BEEE7EC 
		public Vector2[] vertices { get => default; } // 0x000000018BEEE8B4-0x000000018BEEE8E8 
		public ushort[] triangles { get => default; } // 0x000000018BEEE84C-0x000000018BEEE880 
		public Vector2[] uv { get => default; } // 0x000000018BEEE880-0x000000018BEEE8B4 
	
		// Events
		public static event Action<List<Sprite>> dynamicAtlasFinishCallback;
	
		// Constructors
		private Sprite() {} // 0x000000018BEEE59C-0x000000018BEEE5DC
	
		// Methods
		internal int GetPackingMode() => default; // 0x000000018BEEDD58-0x000000018BEEDD8C
		internal int GetPackingRotation() => default; // 0x000000018BEEDD8C-0x000000018BEEDDC0
		internal int GetPacked() => default; // 0x000000018404BCB0-0x000000018404BCF0
		internal Rect GetTextureRect() => default; // 0x000000018BEEE144-0x000000018BEEE170
		internal Vector2 GetTextureRectOffset() => default; // 0x000000018BEEE0DC-0x000000018BEEE100
		internal Vector4 GetInnerUVs() => default; // 0x0000000183F91480-0x0000000183F914B0
		internal Vector4 GetOuterUVs() => default; // 0x0000000183F91570-0x0000000183F915D0
		internal Vector4 GetPadding() => default; // 0x0000000184045050-0x00000001840450B0
		internal static Sprite CreateSpriteWithoutTextureScripting(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) => default; // 0x000000018BEED73C-0x000000018BEED760
		internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) => default; // 0x000000018BEED7C4-0x000000018BEED814
		internal Texture2D GetSecondaryTexture(int index) => default; // 0x000000018BEEE058-0x000000018BEEE098
		public int GetPhysicsShapeCount() => default; // 0x000000018BEEDDC0-0x000000018BEEDDF4
		public int GetPhysicsShapePointCount(int shapeIdx) => default; // 0x000000018BEEDE44-0x000000018BEEDF30
		private int Internal_GetPhysicsShapePointCount(int shapeIdx) => default; // 0x000000018BEEE170-0x000000018BEEE1B0
		public void RegisterDynamicAtlas(int panelLevel) {} // 0x000000018646D87C-0x000000018646D884
		public void UnRegisterDynamicAtlas() {} // 0x000000018646D874-0x000000018646D87C
		private void InternalRegisterDynamicAtlas(int panelLevel) {} // 0x000000018509A410-0x000000018509A460
		private void Internal_UnRegisterDynamicAtlas() {} // 0x00000001851D0620-0x00000001851D0660
		private static bool PostRegisteredAtlasFinish(List<Sprite> sprites) => default; // 0x000000018BEEE544-0x000000018BEEE594
		public static void RegisterSpriteAtlasList(List<Sprite> cacheCallBack) {} // 0x000000018BEEE594-0x000000018BEEE59C
		private static void Internal_RegisterSpriteCacheCallBack(List<Sprite> cacheCallBac) {} // 0x000000018BEEE1B0-0x000000018BEEE1E4
		public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape) => default; // 0x000000018BEEDF30-0x000000018BEEE058
		private static void GetPhysicsShapeImpl(Sprite sprite, int shapeIdx, List<Vector2> physicsShape) {} // 0x000000018BEEDDF4-0x000000018BEEDE44
		public void OverridePhysicsShape(IList<Vector2[]> physicsShapes) {} // 0x000000018BEEE2CC-0x000000018BEEE544
		private static void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount) {} // 0x000000018BEEE238-0x000000018BEEE278
		private static void OverridePhysicsShape(Sprite sprite, Vector2[] physicsShape, int idx) {} // 0x000000018BEEE278-0x000000018BEEE2CC
		public void OverrideGeometry(Vector2[] vertices, ushort[] triangles) {} // 0x000000018BEEE1E4-0x000000018BEEE238
		internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) => default; // 0x000000018BEEDCFC-0x000000018BEEDD20
		internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits) => default; // 0x000000018BEEDCD4-0x000000018BEEDCFC
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) => default; // 0x000000018BEED91C-0x000000018BEEDCD4
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) => default; // 0x000000018BEED814-0x000000018BEED86C
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) => default; // 0x000000018BEED86C-0x000000018BEED8C8
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) => default; // 0x000000018BEEDD20-0x000000018BEEDD58
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) => default; // 0x000000018BEED8F4-0x000000018BEED91C
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) => default; // 0x000000018BEED8C8-0x000000018BEED8F4
		private void GetTextureRect_Injected(out Rect ret) {
			ret = default;
		} // 0x000000018BEEE100-0x000000018BEEE144
		private void GetTextureRectOffset_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BEEE098-0x000000018BEEE0DC
		private void GetInnerUVs_Injected(out Vector4 ret) {
			ret = default;
		} // 0x0000000183F914B0-0x0000000183F91500
		private void GetOuterUVs_Injected(out Vector4 ret) {
			ret = default;
		} // 0x0000000183F915D0-0x0000000183F916C0
		private void GetPadding_Injected(out Vector4 ret) {
			ret = default;
		} // 0x00000001840450B0-0x0000000184045100
		private static Sprite CreateSpriteWithoutTextureScripting_Injected(ref Rect rect, ref Vector2 pivot, float pixelsToUnits, Texture2D texture) => default; // 0x000000018BEED6D8-0x000000018BEED73C
		private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape) => default; // 0x000000018BEED760-0x000000018BEED7C4
		private void get_bounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x000000018BEEE678-0x000000018BEEE6BC
		private void get_rect_Injected(out Rect ret) {
			ret = default;
		} // 0x0000000184045160-0x00000001840451B0
		private void get_border_Injected(out Vector4 ret) {
			ret = default;
		} // 0x0000000183F91880-0x0000000183F918D0
		private void get_pivot_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BEEE704-0x000000018BEEE748
	}
}

namespace UnityEngine.Assertions
{
	public static class Assert // TypeDefIndex: 48123
	{
		// Fields
		public static bool raiseExceptions; // 0x00
	
		// Constructors
		static Assert() {} // 0x0000000185FA5160-0x0000000185FA51A0
	
		// Methods
		private static void Fail(string message, string userMessage) {} // 0x000000018BF048B4-0x000000018BF049C4
		public static void IsTrue(bool condition) {} // 0x00000001840BEE60-0x00000001840BEEA0
		public static void IsTrue(bool condition, string message) {} // 0x00000001840BEE10-0x00000001840BEE60
		public static void IsFalse(bool condition, string message) {} // 0x000000018BF049C4-0x000000018BF04A24
		public static void AreEqual<T>(T expected, T actual) {}
		public static void AreEqual<T>(T expected, T actual, string message) {}
		public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer) {}
		public static void AreEqual(UnityEngine.Object expected, UnityEngine.Object actual, string message) {} // 0x000000018BF04818-0x000000018BF048B4
		public static void IsNull<T>(T value)
			where T : class {}
		public static void IsNull<T>(T value, string message)
			where T : class {}
		public static void IsNull(UnityEngine.Object value, string message) {} // 0x000000018BF04AB0-0x000000018BF04B3C
		public static void IsNotNull<T>(T value)
			where T : class {}
		public static void IsNotNull<T>(T value, string message)
			where T : class {}
		public static void IsNotNull(UnityEngine.Object value, string message) {} // 0x000000018BF04A24-0x000000018BF04AB0
		public static void AreEqual(int expected, int actual) {} // 0x000000018BF047B4-0x000000018BF04818
	}

	public class AssertionException : Exception // TypeDefIndex: 48124
	{
		// Fields
		private string m_UserMessage; // 0x90
	
		// Properties
		public override string Message { get => default; } // 0x000000018BF04BAC-0x000000018BF04C04 
	
		// Constructors
		public AssertionException() {} // Dummy constructor
		public AssertionException(string message, string userMessage) {} // 0x000000018BF04B3C-0x000000018BF04BAC
	}

	internal class AssertionMessageUtil // TypeDefIndex: 48125
	{
		// Constructors
		public AssertionMessageUtil() {} // Dummy constructor
	
		// Methods
		public static string GetMessage(string failureMessage) => default; // 0x000000018BF04F4C-0x000000018BF05004
		public static string GetMessage(string failureMessage, string expected) => default; // 0x000000018BF04E3C-0x000000018BF04F4C
		public static string GetEqualityMessage(object actual, object expected, bool expectEqual) => default; // 0x000000018BF04C8C-0x000000018BF04E3C
		public static string NullFailureMessage(object value, bool expectNull) => default; // 0x000000018BF05004-0x000000018BF05148
		public static string BooleanFailureMessage(bool expected) => default; // 0x000000018BF04C04-0x000000018BF04C8C
	}
}

namespace UnityEngine.Device
{
	public static class SystemInfo // TypeDefIndex: 48090
	{
		// Properties
		public static int systemMemorySize { get; } // 0x00000001864717C4-0x00000001864717D0 
	}
}

namespace UnityEngine.Diagnostics
{
	public enum ForcedCrashCategory // TypeDefIndex: 48087
	{
		AccessViolation = 0,
		FatalError = 1,
		Abort = 2,
		PureVirtualFunction = 3,
		MonoAbort = 4
	}

	public enum AddressSanitizerCategory // TypeDefIndex: 48088
	{
		HeapBufferOverFlow = 0,
		HeapUseAfterFree = 1,
		MemcpyParamOverlap = 2,
		DoubleFree = 3
	}

	public static class Utils // TypeDefIndex: 48089
	{
		// Methods
		public static void ForceCrash(ForcedCrashCategory crashCategory) {} // 0x000000018BF0A8A8-0x000000018BF0A8DC
		public static void NativeAssert(string message) {} // 0x000000018BF0A8DC-0x000000018BF0A910
		public static void NativeError(string message) {} // 0x000000018BF0A910-0x000000018BF0A944
		public static void NativeWarning(string message) {} // 0x000000018BF0A944-0x000000018BF0A978
		public static void AddressSanitizer(AddressSanitizerCategory crashCategory) {} // 0x000000018BF0A874-0x000000018BF0A8A8
	}
}

namespace UnityEngine.Events
{
	[Serializable]
	public enum PersistentListenerMode // TypeDefIndex: 47713
	{
		EventDefined = 0,
		Void = 1,
		Object = 2,
		Int = 3,
		Float = 4,
		String = 5,
		Bool = 6
	}

	internal class UnityEventTools // TypeDefIndex: 47714
	{
		// Constructors
		public UnityEventTools() {} // Dummy constructor
	
		// Methods
		internal static string TidyAssemblyTypeName(string assemblyTypeName) => default; // 0x000000018BEF22D8-0x000000018BEF2480
	}

	[Serializable]
	internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 47715
	{
		// Fields
		private UnityEngine.Object m_ObjectArgument; // 0x10
		private string m_ObjectArgumentAssemblyTypeName; // 0x18
		private int m_IntArgument; // 0x20
		private float m_FloatArgument; // 0x24
		private string m_StringArgument; // 0x28
		private bool m_BoolArgument; // 0x30
	
		// Properties
		public UnityEngine.Object unityObjectArgument { get => default; } // 0x0000000185FC7990-0x0000000185FC79A0 
		public string unityObjectArgumentAssemblyTypeName { get => default; } // 0x0000000185FC2A70-0x0000000185FC2A80 
		public int intArgument { get => default; } // 0x0000000185FE7AF0-0x0000000185FE7B00 
		public float floatArgument { get => default; } // 0x0000000185FE7AE0-0x0000000185FE7AF0 
		public string stringArgument { get => default; } // 0x0000000185FE7B00-0x0000000185FE7B10 
		public bool boolArgument { get => default; } // 0x0000000185FE7AD0-0x0000000185FE7AE0 
	
		// Constructors
		public ArgumentCache() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018BEE66C8-0x000000018BEE66F0
		public void OnAfterDeserialize() {} // 0x000000018BEE66C8-0x000000018BEE66F0
	}

	internal abstract class BaseInvokableCall // TypeDefIndex: 47716
	{
		// Constructors
		protected BaseInvokableCall() {} // 0x0000000185492010-0x0000000185492020
		protected BaseInvokableCall(object target, MethodInfo function) {} // 0x000000018BEE6F84-0x000000018BEE70B0
	
		// Methods
		public abstract void Invoke(object[] args);
		protected static void ThrowOnInvalidArg<T>(object arg) {}
		protected static bool AllowInvoke(Delegate @delegate) => default; // 0x000000018440A640-0x000000018440A9C0
		public abstract bool Find(object targetObj, MethodInfo method);
	}

	internal class InvokableCall : BaseInvokableCall // TypeDefIndex: 47717
	{
		// Fields
		private UnityAction Delegate; // 0x10
	
		// Events
		private event UnityAction Delegate;
	
		// Constructors
		public InvokableCall() {} // Dummy constructor
		public InvokableCall(object target, MethodInfo theFunction) {} // 0x000000018BEE8F2C-0x000000018BEE9008
		public InvokableCall(UnityAction action) {} // 0x00000001849D0910-0x00000001849D0920
	
		// Methods
		public override void Invoke(object[] args) {} // 0x000000018BEE8EF4-0x000000018BEE8F2C
		public void Invoke() {} // 0x000000018440A380-0x000000018440A4B0
		public override bool Find(object targetObj, MethodInfo method) => default; // 0x000000018521A380-0x000000018521A3D0
	}

	internal class InvokableCall<T1> : BaseInvokableCall // TypeDefIndex: 47718
	{
		// Fields
		private UnityAction<T1> Delegate;
	
		// Events
		protected event UnityAction<T1> Delegate;
	
		// Constructors
		public InvokableCall() {} // Dummy constructor
		public InvokableCall(object target, MethodInfo theFunction) {}
		public InvokableCall(UnityAction<T1> action) {}
	
		// Methods
		public override void Invoke(object[] args) {}
		public virtual void Invoke(T1 args0) {}
		public override bool Find(object targetObj, MethodInfo method) => default;
	}

	internal class InvokableCall<T1, T2> : BaseInvokableCall // TypeDefIndex: 47719
	{
		// Fields
		private UnityAction<T1, T2> Delegate;
	
		// Events
		protected event UnityAction<T1, T2> Delegate;
	
		// Constructors
		public InvokableCall() {} // Dummy constructor
		public InvokableCall(object target, MethodInfo theFunction) {}
		public InvokableCall(UnityAction<T1, T2> action) {}
	
		// Methods
		public override void Invoke(object[] args) {}
		public void Invoke(T1 args0, T2 args1) {}
		public override bool Find(object targetObj, MethodInfo method) => default;
	}

	internal class InvokableCall<T1, T2, T3> : BaseInvokableCall // TypeDefIndex: 47720
	{
		// Fields
		private UnityAction<T1, T2, T3> Delegate;
	
		// Events
		protected event UnityAction<T1, T2, T3> Delegate;
	
		// Constructors
		public InvokableCall() {} // Dummy constructor
		public InvokableCall(object target, MethodInfo theFunction) {}
		public InvokableCall(UnityAction<T1, T2, T3> action) {}
	
		// Methods
		public override void Invoke(object[] args) {}
		public void Invoke(T1 args0, T2 args1, T3 args2) {}
		public override bool Find(object targetObj, MethodInfo method) => default;
	}

	internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall // TypeDefIndex: 47721
	{
		// Fields
		private UnityAction<T1, T2, T3, T4> Delegate;
	
		// Constructors
		public InvokableCall() {} // Dummy constructor
		public InvokableCall(object target, MethodInfo theFunction) {}
	
		// Methods
		public override void Invoke(object[] args) {}
		public override bool Find(object targetObj, MethodInfo method) => default;
	}

	internal class CachedInvokableCall<T> : InvokableCall<T> // TypeDefIndex: 47722
	{
		// Fields
		private readonly T m_Arg1;
	
		// Constructors
		public CachedInvokableCall() {} // Dummy constructor
		public CachedInvokableCall(UnityEngine.Object target, MethodInfo theFunction, T argument) {}
	
		// Methods
		public override void Invoke(object[] args) {}
		public override void Invoke(T arg0) {}
	}

	public enum UnityEventCallState // TypeDefIndex: 47723
	{
		Off = 0,
		EditorAndRuntime = 1,
		RuntimeOnly = 2
	}

	[Serializable]
	internal class PersistentCall : ISerializationCallbackReceiver // TypeDefIndex: 47724
	{
		// Fields
		private UnityEngine.Object m_Target; // 0x10
		private string m_TargetAssemblyTypeName; // 0x18
		private string m_MethodName; // 0x20
		private PersistentListenerMode m_Mode; // 0x28
		private ArgumentCache m_Arguments; // 0x30
		private UnityEventCallState m_CallState; // 0x38
	
		// Properties
		public UnityEngine.Object target { get => default; } // 0x0000000185FC7990-0x0000000185FC79A0 
		public string targetAssemblyTypeName { get => default; } // 0x000000018BEEAFE0-0x000000018BEEB088 
		public string methodName { get => default; } // 0x0000000185FE66B0-0x0000000185FE66C0 
		public PersistentListenerMode mode { get => default; } // 0x0000000185FE7B60-0x0000000185FE7B70 
		public ArgumentCache arguments { get => default; } // 0x0000000185FE7B40-0x0000000185FE7B50 
		public UnityEventCallState callState { get => default; set {} } // 0x0000000185FE7B50-0x0000000185FE7B60 0x00000001813E6F50-0x00000001813E6F60
	
		// Constructors
		public PersistentCall() {} // 0x000000018BEEAF84-0x000000018BEEAFE0
	
		// Methods
		public bool IsValid() => default; // 0x000000018BEEAF4C-0x000000018BEEAF84
		public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) => default; // 0x000000018BEEAC54-0x000000018BEEAF4C
		private static BaseInvokableCall GetObjectCall(UnityEngine.Object target, MethodInfo method, ArgumentCache arguments) => default; // 0x000000018BEEA8FC-0x000000018BEEAC54
		public void OnBeforeSerialize() {} // 0x000000018BEE66C8-0x000000018BEE66F0
		public void OnAfterDeserialize() {} // 0x000000018BEE66C8-0x000000018BEE66F0
	}

	[Serializable]
	internal class PersistentCallGroup // TypeDefIndex: 47725
	{
		// Fields
		private List<PersistentCall> m_Calls; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x000000018BEEA8BC-0x000000018BEEA8FC 
	
		// Constructors
		public PersistentCallGroup() {} // 0x0000000184565690-0x0000000184565800
	
		// Methods
		public PersistentCall GetListener(int index) => default; // 0x000000018BEEA868-0x000000018BEEA8BC
		public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) {} // 0x000000018440B2D0-0x000000018440B430
	}

	internal class InvokableCallList // TypeDefIndex: 47726
	{
		// Fields
		private List<BaseInvokableCall> m_PersistentCalls; // 0x10
		private List<BaseInvokableCall> m_RuntimeCalls; // 0x18
		private List<BaseInvokableCall> m_ExecutingCalls; // 0x20
		private bool m_NeedsUpdate; // 0x28
		private static List<BaseInvokableCall> s_Empty; // 0x00
	
		// Constructors
		public InvokableCallList() {} // 0x0000000184565590-0x0000000184565690
		static InvokableCallList() {} // 0x0000000185F3F9A0-0x0000000185F3FA30
	
		// Methods
		public void AddPersistentInvokableCall(BaseInvokableCall call) {} // 0x000000018BEE8E40-0x000000018BEE8EF4
		public void AddListener(BaseInvokableCall call) {} // 0x00000001849D0990-0x00000001849D0A50
		public void RemoveListener(object targetObj, MethodInfo method) {} // 0x00000001849D16A0-0x00000001849D1930
		public void Clear() {} // 0x00000001849D5F70-0x00000001849D6000
		public void ClearPersistent() {} // 0x000000018421A790-0x000000018421A890
		public List<BaseInvokableCall> PrepareInvoke() => default; // 0x000000018440A1A0-0x000000018440A340
	}

	[Serializable]
	public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 47727
	{
		// Fields
		private InvokableCallList m_Calls; // 0x10
		private PersistentCallGroup m_PersistentCalls; // 0x18
		private bool m_CallsDirty; // 0x20
	
		// Constructors
		protected UnityEventBase() {} // 0x0000000184564CB0-0x0000000184565590
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018421A550-0x000000018421A670
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018421A550-0x000000018421A670
		protected MethodInfo FindMethod_Impl(string name, object targetObj) => default; // 0x000000018BEF1A64-0x000000018BEF1AA4
		protected abstract MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
		internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);
		internal MethodInfo FindMethod(PersistentCall call) => default; // 0x000000018BEF1AA4-0x000000018BEF1C30
		internal MethodInfo FindMethod(string name, System.Type listenerType, PersistentListenerMode mode, System.Type argumentType) => default; // 0x000000018BEF1C30-0x000000018BEF1E20
		public int GetPersistentEventCount() => default; // 0x000000018BEF1E20-0x000000018BEF1E40
		public UnityEngine.Object GetPersistentTarget(int index) => default; // 0x000000018BEF1FC4-0x000000018BEF1FF0
		public string GetPersistentMethodName(int index) => default; // 0x000000018BEF1F58-0x000000018BEF1FC4
		private void DirtyPersistentCalls() {} // 0x000000018421A670-0x000000018421A790
		private void RebuildPersistentCallsIfNeeded() {} // 0x000000018440A340-0x000000018440A380
		public void SetPersistentListenerState(int index, UnityEventCallState state) {} // 0x000000018BEF221C-0x000000018BEF2260
		public UnityEventCallState GetPersistentListenerState(int index) => default; // 0x000000018BEF1E40-0x000000018BEF1F58
		protected void AddListener(object targetObj, MethodInfo method) {} // 0x000000018BEF1A2C-0x000000018BEF1A64
		internal void AddCall(BaseInvokableCall call) {} // 0x00000001849D0970-0x00000001849D0990
		protected void RemoveListener(object targetObj, MethodInfo method) {} // 0x00000001849D1680-0x00000001849D16A0
		public void RemoveAllListeners() {} // 0x00000001849D5ED0-0x00000001849D5F70
		internal List<BaseInvokableCall> PrepareInvoke() => default; // 0x000000018440A150-0x000000018440A1A0
		protected void Invoke(object[] parameters) {} // 0x000000018BEF2188-0x000000018BEF221C
		public override string ToString() => default; // 0x000000018BEF2260-0x000000018BEF22D8
		public static MethodInfo GetValidMethodInfo(object obj, string functionName, System.Type[] argumentTypes) => default; // 0x000000018BEF1FF0-0x000000018BEF2034
		public static MethodInfo GetValidMethodInfo(System.Type objectType, string functionName, System.Type[] argumentTypes) => default; // 0x000000018BEF2034-0x000000018BEF2188
	}

	public delegate void UnityAction(); // TypeDefIndex: 47728; 0x00000001864BC320-0x00000001864BC330

	[Serializable]
	public class UnityEvent : UnityEventBase // TypeDefIndex: 47729
	{
		// Fields
		private object[] m_InvokeArray; // 0x28
	
		// Constructors
		public UnityEvent() {} // 0x0000000184564C20-0x0000000184564C50
	
		// Methods
		public void AddListener(UnityAction call) {} // 0x00000001849D0860-0x00000001849D08A0
		public void RemoveListener(UnityAction call) {} // 0x00000001849D1630-0x00000001849D1680
		protected override MethodInfo FindMethod_Impl(string name, System.Type targetObjType) => default; // 0x000000018BEF2480-0x000000018BEF24D8
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) => default; // 0x000000018BEF24D8-0x000000018BEF2548
		private static BaseInvokableCall GetDelegate(UnityAction action) => default; // 0x00000001849D08A0-0x00000001849D0910
		public void Invoke() {} // 0x0000000184409E90-0x0000000184409FC0
	}

	public delegate void UnityAction<T0>(T0 arg0); // TypeDefIndex: 47730; 0x00000000-0x00000000

	[Serializable]
	public class UnityEvent<T0> : UnityEventBase // TypeDefIndex: 47731
	{
		// Fields
		private object[] m_InvokeArray;
	
		// Constructors
		public UnityEvent() {}
	
		// Methods
		public void AddListener(UnityAction<T0> call) {}
		public void RemoveListener(UnityAction<T0> call) {}
		protected override MethodInfo FindMethod_Impl(string name, System.Type targetObjType) => default;
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) => default;
		private static BaseInvokableCall GetDelegate(UnityAction<T0> action) => default;
		public void Invoke(T0 arg0) {}
	}

	public delegate void UnityAction<T0, T1>(T0 arg0, T1 arg1); // TypeDefIndex: 47732; 0x00000000-0x00000000

	[Serializable]
	public class UnityEvent<T0, T1> : UnityEventBase // TypeDefIndex: 47733
	{
		// Fields
		private object[] m_InvokeArray;
	
		// Constructors
		public UnityEvent() {}
	
		// Methods
		public void AddListener(UnityAction<T0, T1> call) {}
		public void RemoveListener(UnityAction<T0, T1> call) {}
		protected override MethodInfo FindMethod_Impl(string name, System.Type targetObjType) => default;
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) => default;
		private static BaseInvokableCall GetDelegate(UnityAction<T0, T1> action) => default;
		public void Invoke(T0 arg0, T1 arg1) {}
	}

	public delegate void UnityAction<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2); // TypeDefIndex: 47734; 0x00000000-0x00000000

	[Serializable]
	public class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 47735
	{
		// Fields
		private object[] m_InvokeArray;
	
		// Constructors
		public UnityEvent() {}
	
		// Methods
		public void AddListener(UnityAction<T0, T1, T2> call) {}
		public void RemoveListener(UnityAction<T0, T1, T2> call) {}
		protected override MethodInfo FindMethod_Impl(string name, System.Type targetObjType) => default;
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) => default;
		private static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action) => default;
		public void Invoke(T0 arg0, T1 arg1, T2 arg2) {}
	}

	public delegate void UnityAction<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3); // TypeDefIndex: 47736; 0x00000000-0x00000000

	[Serializable]
	public class UnityEvent<T0, T1, T2, T3> : UnityEventBase // TypeDefIndex: 47737
	{
		// Fields
		private object[] m_InvokeArray;
	
		// Constructors
		public UnityEvent() {}
	
		// Methods
		protected override MethodInfo FindMethod_Impl(string name, System.Type targetObjType) => default;
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) => default;
	}
}

namespace UnityEngine.Experimental.GlobalIllumination
{
	public enum LightType : byte // TypeDefIndex: 48093
	{
		Directional = 0,
		Point = 1,
		Spot = 2,
		Rectangle = 3,
		Disc = 4,
		SpotPyramidShape = 5,
		SpotBoxShape = 6
	}

	public enum LightMode : byte // TypeDefIndex: 48094
	{
		Realtime = 0,
		Mixed = 1,
		Baked = 2,
		Unknown = 3
	}

	public enum FalloffType : byte // TypeDefIndex: 48095
	{
		InverseSquared = 0,
		InverseSquaredNoRangeAttenuation = 1,
		Linear = 2,
		Legacy = 3,
		Undefined = 4
	}

	public enum AngularFalloffType : byte // TypeDefIndex: 48096
	{
		LUT = 0,
		AnalyticAndInnerAngle = 1
	}

	public struct LinearColor // TypeDefIndex: 48097
	{
		// Fields
		private float m_red; // 0x00
		private float m_green; // 0x04
		private float m_blue; // 0x08
		private float m_intensity; // 0x0C
	
		// Properties
		public float red { get => default; set {} } // 0x0000000185FE6770-0x0000000185FE6780 0x000000018BF06CE8-0x000000018BF06DA0
		public float green { get => default; set {} } // 0x0000000185FE64E0-0x0000000185FE64F0 0x000000018BF06C30-0x000000018BF06CE8
		public float blue { get => default; set {} } // 0x0000000185FE64D0-0x0000000185FE64E0 0x000000018BF06B78-0x000000018BF06C30
	
		// Methods
		public static LinearColor Convert(UnityEngine.Color color, float intensity) => default; // 0x000000018BF06908-0x000000018BF06B78
		public static LinearColor Black() => default; // 0x0000000185FE8760-0x0000000185FE8790
	}

	public struct DirectionalLight // TypeDefIndex: 48098
	{
		// Fields
		public int instanceID; // 0x00
		public bool shadow; // 0x04
		public LightMode mode; // 0x05
		public Vector3 position; // 0x08
		public Quaternion orientation; // 0x14
		public LinearColor color; // 0x24
		public LinearColor indirectColor; // 0x34
		public float penumbraWidthRadian; // 0x44
		public Vector3 direction; // 0x48
	}

	public struct PointLight // TypeDefIndex: 48099
	{
		// Fields
		public int instanceID; // 0x00
		public bool shadow; // 0x04
		public LightMode mode; // 0x05
		public Vector3 position; // 0x08
		public Quaternion orientation; // 0x14
		public LinearColor color; // 0x24
		public LinearColor indirectColor; // 0x34
		public float range; // 0x44
		public float sphereRadius; // 0x48
		public FalloffType falloff; // 0x4C
	}

	public struct SpotLight // TypeDefIndex: 48100
	{
		// Fields
		public int instanceID; // 0x00
		public bool shadow; // 0x04
		public LightMode mode; // 0x05
		public Vector3 position; // 0x08
		public Quaternion orientation; // 0x14
		public LinearColor color; // 0x24
		public LinearColor indirectColor; // 0x34
		public float range; // 0x44
		public float sphereRadius; // 0x48
		public float coneAngle; // 0x4C
		public float innerConeAngle; // 0x50
		public FalloffType falloff; // 0x54
		public AngularFalloffType angularFalloff; // 0x55
	}

	public struct RectangleLight // TypeDefIndex: 48101
	{
		// Fields
		public int instanceID; // 0x00
		public bool shadow; // 0x04
		public LightMode mode; // 0x05
		public Vector3 position; // 0x08
		public Quaternion orientation; // 0x14
		public LinearColor color; // 0x24
		public LinearColor indirectColor; // 0x34
		public float range; // 0x44
		public float width; // 0x48
		public float height; // 0x4C
		public FalloffType falloff; // 0x50
	}

	public struct DiscLight // TypeDefIndex: 48102
	{
		// Fields
		public int instanceID; // 0x00
		public bool shadow; // 0x04
		public LightMode mode; // 0x05
		public Vector3 position; // 0x08
		public Quaternion orientation; // 0x14
		public LinearColor color; // 0x24
		public LinearColor indirectColor; // 0x34
		public float range; // 0x44
		public float radius; // 0x48
		public FalloffType falloff; // 0x4C
	}

	public struct Cookie // TypeDefIndex: 48103
	{
		// Fields
		public int instanceID; // 0x00
		public float scale; // 0x04
		public Vector2 sizes; // 0x08
	}

	public struct LightDataGI // TypeDefIndex: 48104
	{
		// Fields
		public int instanceID; // 0x00
		public int cookieID; // 0x04
		public float cookieScale; // 0x08
		public LinearColor color; // 0x0C
		public LinearColor indirectColor; // 0x1C
		public Quaternion orientation; // 0x2C
		public Vector3 position; // 0x3C
		public float range; // 0x48
		public float coneAngle; // 0x4C
		public float innerConeAngle; // 0x50
		public float shape0; // 0x54
		public float shape1; // 0x58
		public LightType type; // 0x5C
		public LightMode mode; // 0x5D
		public byte shadow; // 0x5E
		public FalloffType falloff; // 0x5F
	
		// Methods
		public void Init(ref DirectionalLight light, ref Cookie cookie) {} // 0x000000018BF05A9C-0x000000018BF05B14
		public void Init(ref PointLight light, ref Cookie cookie) {} // 0x000000018BF05B14-0x000000018BF05B88
		public void Init(ref SpotLight light, ref Cookie cookie) {} // 0x000000018BF05A18-0x000000018BF05A9C
		public void Init(ref RectangleLight light, ref Cookie cookie) {} // 0x000000018BF05BFC-0x000000018BF05C70
		public void Init(ref DiscLight light, ref Cookie cookie) {} // 0x000000018BF05B88-0x000000018BF05BFC
		public void InitNoBake(int lightInstanceID) {} // 0x0000000185FE8750-0x0000000185FE8760
	}

	public static class LightmapperUtils // TypeDefIndex: 48105
	{
		// Methods
		public static LightMode Extract(LightmapBakeType baketype) => default; // 0x000000018BF06324-0x000000018BF06338
		public static LinearColor ExtractIndirect(Light l) => default; // 0x000000018BF05D44-0x000000018BF05DD8
		public static float ExtractInnerCone(Light l) => default; // 0x000000018BF05DD8-0x000000018BF05E24
		private static UnityEngine.Color ExtractColorTemperature(Light l) => default; // 0x000000018BF05CC8-0x000000018BF05D44
		private static void ApplyColorTemperature(UnityEngine.Color cct, ref LinearColor lightColor) {} // 0x000000018BF05C70-0x000000018BF05CC8
		public static void Extract(Light l, ref DirectionalLight dir) {} // 0x000000018BF05FD8-0x000000018BF06174
		public static void Extract(Light l, ref PointLight point) {} // 0x000000018BF06174-0x000000018BF06324
		public static void Extract(Light l, ref SpotLight spot) {} // 0x000000018BF06338-0x000000018BF06510
		public static void Extract(Light l, ref RectangleLight rect) {} // 0x000000018BF05E24-0x000000018BF05FD8
		public static void Extract(Light l, ref DiscLight disc) {} // 0x000000018BF06174-0x000000018BF06324
		public static void Extract(Light l, out Cookie cookie) {
			cookie = default;
		} // 0x000000018BF06510-0x000000018BF06634
	}

	public static class Lightmapping // TypeDefIndex: 48108
	{
		// Fields
		private static readonly RequestLightsDelegate s_DefaultDelegate; // 0x00
		private static RequestLightsDelegate s_RequestLightsDelegate; // 0x08
	
		// Nested types
		public delegate void RequestLightsDelegate(Light[] requests, NativeArray<LightDataGI> lightsOutput); // TypeDefIndex: 48106; 0x000000018BF06634-0x000000018BF06684
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 48107
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018BF06740-0x000000018BF0679C
			public __c() {} // 0x000000018BF06684-0x000000018BF06740
	
			// Methods
			internal void _.cctor_b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) {} // 0x000000018BF06818-0x000000018BF06908
		}
	
		// Constructors
		static Lightmapping() {} // 0x000000018BF0A580-0x000000018BF0A810
	
		// Methods
		public static void SetDelegate(RequestLightsDelegate del) {} // 0x000000018B7ADE38-0x000000018B7ADF0C
		public static RequestLightsDelegate GetDelegate() => default; // 0x00000001844DB850-0x00000001844DB880
		public static void ResetDelegate() {} // 0x000000018BF0A810-0x000000018BF0A874
		internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.Experimental.Playables
{
	public struct CameraPlayable : IPlayable, IEquatable<CameraPlayable> // TypeDefIndex: 48109
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Methods
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public bool Equals(CameraPlayable other) => default; // 0x000000018BF05148-0x000000018BF051BC
	}

	public struct MaterialEffectPlayable : IPlayable, IEquatable<MaterialEffectPlayable> // TypeDefIndex: 48110
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Methods
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public bool Equals(MaterialEffectPlayable other) => default; // 0x000000018BF07090-0x000000018BF07104
	}

	public struct TextureMixerPlayable : IPlayable, IEquatable<TextureMixerPlayable> // TypeDefIndex: 48111
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
	
		// Methods
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public bool Equals(TextureMixerPlayable other) => default; // 0x000000018BF0A50C-0x000000018BF0A580
	}

	public struct TexturePlayableOutput : IPlayableOutput // TypeDefIndex: 48112
	{
		// Fields
		private PlayableOutputHandle m_Handle; // 0x00
	
		// Methods
		public PlayableOutputHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
	}
}

namespace UnityEngine.Experimental.Rendering
{
	internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem // TypeDefIndex: 48113
	{
		// Constructors
		public BuiltinRuntimeReflectionSystem() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool TickRealtimeProbes() => default; // 0x0000000186472AF4-0x0000000186472B00
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
		private void Dispose(bool disposing) {} // 0x0000000185492010-0x0000000185492020
		private static bool BuiltinUpdate() => default; // 0x00000001851983F0-0x0000000185198430
		private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() => default; // 0x00000001851E0720-0x00000001851E0760
	}

	public interface IScriptableRuntimeReflectionSystem : IDisposable // TypeDefIndex: 48114
	{
		// Methods
		bool TickRealtimeProbes();
	}

	public static class ScriptableRuntimeReflectionSystemSettings // TypeDefIndex: 48115
	{
		// Fields
		private static ScriptableRuntimeReflectionSystemWrapper s_Instance; // 0x00
	
		// Properties
		private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system { get; set; } // 0x0000000184ED1150-0x0000000184ED1230
		private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance { get; } // 0x00000001851E0760-0x00000001851E07B0 
	
		// Constructors
		static ScriptableRuntimeReflectionSystemSettings() {} // 0x0000000185F5E3B0-0x0000000185F5E420
	
		// Methods
		private static void ScriptingDirtyReflectionSystemInstance() {} // 0x000000018BF09F10-0x000000018BF09F3C
	}

	internal class ScriptableRuntimeReflectionSystemWrapper // TypeDefIndex: 48116
	{
		// Fields
		private IScriptableRuntimeReflectionSystem _implementation_k__BackingField; // 0x10
	
		// Properties
		internal IScriptableRuntimeReflectionSystem implementation { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public ScriptableRuntimeReflectionSystemWrapper() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out bool result) {
			result = default;
		} // 0x0000000184F48DE0-0x0000000184F48E50
	}

	public enum TextureCreationFlags // TypeDefIndex: 48117
	{
		None = 0,
		MipChain = 1,
		Crunch = 64,
		HGDisableDefragmentation = 1024
	}

	public enum FormatUsage // TypeDefIndex: 48118
	{
		Sample = 0,
		Linear = 1,
		Sparse = 2,
		Render = 4,
		Blend = 5,
		GetPixels = 6,
		SetPixels = 7,
		SetPixels32 = 8,
		ReadPixels = 9,
		LoadStore = 10,
		MSAA2x = 11,
		MSAA4x = 12,
		MSAA8x = 13,
		StencilSampling = 16
	}

	public enum DefaultFormat // TypeDefIndex: 48119
	{
		LDR = 0,
		HDR = 1,
		DepthStencil = 2,
		Shadow = 3,
		Video = 4
	}

	public enum GraphicsFormat // TypeDefIndex: 48120
	{
		None = 0,
		R8_SRGB = 1,
		R8G8_SRGB = 2,
		R8G8B8_SRGB = 3,
		R8G8B8A8_SRGB = 4,
		R8_UNorm = 5,
		R8G8_UNorm = 6,
		R8G8B8_UNorm = 7,
		R8G8B8A8_UNorm = 8,
		R8_SNorm = 9,
		R8G8_SNorm = 10,
		R8G8B8_SNorm = 11,
		R8G8B8A8_SNorm = 12,
		R8_UInt = 13,
		R8G8_UInt = 14,
		R8G8B8_UInt = 15,
		R8G8B8A8_UInt = 16,
		R8_SInt = 17,
		R8G8_SInt = 18,
		R8G8B8_SInt = 19,
		R8G8B8A8_SInt = 20,
		R16_UNorm = 21,
		R16G16_UNorm = 22,
		R16G16B16_UNorm = 23,
		R16G16B16A16_UNorm = 24,
		R16_SNorm = 25,
		R16G16_SNorm = 26,
		R16G16B16_SNorm = 27,
		R16G16B16A16_SNorm = 28,
		R16_UInt = 29,
		R16G16_UInt = 30,
		R16G16B16_UInt = 31,
		R16G16B16A16_UInt = 32,
		R16_SInt = 33,
		R16G16_SInt = 34,
		R16G16B16_SInt = 35,
		R16G16B16A16_SInt = 36,
		R32_UInt = 37,
		R32G32_UInt = 38,
		R32G32B32_UInt = 39,
		R32G32B32A32_UInt = 40,
		R32_SInt = 41,
		R32G32_SInt = 42,
		R32G32B32_SInt = 43,
		R32G32B32A32_SInt = 44,
		R16_SFloat = 45,
		R16G16_SFloat = 46,
		R16G16B16_SFloat = 47,
		R16G16B16A16_SFloat = 48,
		R32_SFloat = 49,
		R32G32_SFloat = 50,
		R32G32B32_SFloat = 51,
		R32G32B32A32_SFloat = 52,
		B8G8R8_SRGB = 56,
		B8G8R8A8_SRGB = 57,
		B8G8R8_UNorm = 58,
		B8G8R8A8_UNorm = 59,
		B8G8R8_SNorm = 60,
		B8G8R8A8_SNorm = 61,
		B8G8R8_UInt = 62,
		B8G8R8A8_UInt = 63,
		B8G8R8_SInt = 64,
		B8G8R8A8_SInt = 65,
		R4G4B4A4_UNormPack16 = 66,
		B4G4R4A4_UNormPack16 = 67,
		R5G6B5_UNormPack16 = 68,
		B5G6R5_UNormPack16 = 69,
		R5G5B5A1_UNormPack16 = 70,
		B5G5R5A1_UNormPack16 = 71,
		A1R5G5B5_UNormPack16 = 72,
		E5B9G9R9_UFloatPack32 = 73,
		B10G11R11_UFloatPack32 = 74,
		A2B10G10R10_UNormPack32 = 75,
		A2B10G10R10_UIntPack32 = 76,
		A2B10G10R10_SIntPack32 = 77,
		A2R10G10B10_UNormPack32 = 78,
		A2R10G10B10_UIntPack32 = 79,
		A2R10G10B10_SIntPack32 = 80,
		A2R10G10B10_XRSRGBPack32 = 81,
		A2R10G10B10_XRUNormPack32 = 82,
		R10G10B10_XRSRGBPack32 = 83,
		R10G10B10_XRUNormPack32 = 84,
		A10R10G10B10_XRSRGBPack32 = 85,
		A10R10G10B10_XRUNormPack32 = 86,
		D16_UNorm = 90,
		D24_UNorm = 91,
		D24_UNorm_S8_UInt = 92,
		D32_SFloat = 93,
		D32_SFloat_S8_UInt = 94,
		S8_UInt = 95,
		RGB_DXT1_SRGB = 96,
		RGBA_DXT1_SRGB = 96,
		RGB_DXT1_UNorm = 97,
		RGBA_DXT1_UNorm = 97,
		RGBA_DXT3_SRGB = 98,
		RGBA_DXT3_UNorm = 99,
		RGBA_DXT5_SRGB = 100,
		RGBA_DXT5_UNorm = 101,
		R_BC4_UNorm = 102,
		R_BC4_SNorm = 103,
		RG_BC5_UNorm = 104,
		RG_BC5_SNorm = 105,
		RGB_BC6H_UFloat = 106,
		RGB_BC6H_SFloat = 107,
		RGBA_BC7_SRGB = 108,
		RGBA_BC7_UNorm = 109,
		RGB_PVRTC_2Bpp_SRGB = 110,
		RGB_PVRTC_2Bpp_UNorm = 111,
		RGB_PVRTC_4Bpp_SRGB = 112,
		RGB_PVRTC_4Bpp_UNorm = 113,
		RGBA_PVRTC_2Bpp_SRGB = 114,
		RGBA_PVRTC_2Bpp_UNorm = 115,
		RGBA_PVRTC_4Bpp_SRGB = 116,
		RGBA_PVRTC_4Bpp_UNorm = 117,
		RGB_ETC_UNorm = 118,
		RGB_ETC2_SRGB = 119,
		RGB_ETC2_UNorm = 120,
		RGB_A1_ETC2_SRGB = 121,
		RGB_A1_ETC2_UNorm = 122,
		RGBA_ETC2_SRGB = 123,
		RGBA_ETC2_UNorm = 124,
		R_EAC_UNorm = 125,
		R_EAC_SNorm = 126,
		RG_EAC_UNorm = 127,
		RG_EAC_SNorm = 128,
		RGBA_ASTC4X4_SRGB = 129,
		RGBA_ASTC4X4_UNorm = 130,
		RGBA_ASTC5X5_SRGB = 131,
		RGBA_ASTC5X5_UNorm = 132,
		RGBA_ASTC6X6_SRGB = 133,
		RGBA_ASTC6X6_UNorm = 134,
		RGBA_ASTC8X8_SRGB = 135,
		RGBA_ASTC8X8_UNorm = 136,
		RGBA_ASTC10X10_SRGB = 137,
		RGBA_ASTC10X10_UNorm = 138,
		RGBA_ASTC12X12_SRGB = 139,
		RGBA_ASTC12X12_UNorm = 140,
		YUV2 = 141,
		DepthAuto = 142,
		ShadowAuto = 143,
		VideoAuto = 144,
		RGBA_ASTC4X4_UFloat = 145,
		RGBA_ASTC5X5_UFloat = 146,
		RGBA_ASTC6X6_UFloat = 147,
		RGBA_ASTC8X8_UFloat = 148,
		RGBA_ASTC10X10_UFloat = 149,
		RGBA_ASTC12X12_UFloat = 150
	}

	public enum RayTracingMode // TypeDefIndex: 48121
	{
		Off = 0,
		Static = 1,
		DynamicTransform = 2,
		DynamicGeometry = 3
	}

	public class GraphicsFormatUtility // TypeDefIndex: 48122
	{
		// Fields
		private static readonly GraphicsFormat[] tableNoStencil; // 0x00
		private static readonly GraphicsFormat[] tableStencil; // 0x08
	
		// Constructors
		public GraphicsFormatUtility() {} // Dummy constructor
		static GraphicsFormatUtility() {} // 0x0000000185BBC7A0-0x0000000185BBC8D0
	
		// Methods
		internal static GraphicsFormat GetFormat(Texture texture) => default; // 0x000000018BF05810-0x000000018BF05844
		public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) => default; // 0x0000000184015DF0-0x0000000184015E50
		private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) => default; // 0x0000000184015E50-0x0000000184015EA0
		public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) => default; // 0x0000000184014AF0-0x0000000184014B50
		private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) => default; // 0x0000000184014B50-0x0000000184014BA0
		public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) => default; // 0x0000000184014A20-0x0000000184014AB0
		private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) => default; // 0x0000000184015380-0x00000001840153C0
		internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits) => default; // 0x0000000184015330-0x0000000184015380
		public static int GetDepthBits(GraphicsFormat format) => default; // 0x0000000184014FF0-0x0000000184015030
		public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) => default; // 0x0000000184014BA0-0x0000000184014D50
		public static bool IsSRGBFormat(GraphicsFormat format) => default; // 0x0000000184015630-0x0000000184015670
		public static GraphicsFormat GetSRGBFormat(GraphicsFormat format) => default; // 0x000000018BF058AC-0x000000018BF058E0
		public static GraphicsFormat GetLinearFormat(GraphicsFormat format) => default; // 0x000000018BF05844-0x000000018BF05878
		public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) => default; // 0x000000018BF05878-0x000000018BF058AC
		public static uint GetComponentCount(GraphicsFormat format) => default; // 0x000000018BF057DC-0x000000018BF05810
		internal static bool IsCompressedTextureFormat(TextureFormat format) => default; // 0x000000018BF059E4-0x000000018BF05A18
		private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) => default; // 0x000000018BF05768-0x000000018BF057A8
		internal static bool CanDecompressFormat(GraphicsFormat format) => default; // 0x000000018BF0571C-0x000000018BF05768
		public static bool IsAlphaOnlyFormat(GraphicsFormat format) => default; // 0x000000018BF059B0-0x000000018BF059E4
		public static bool IsDepthFormat(GraphicsFormat format) => default; // 0x0000000184014630-0x0000000184014670
		public static bool IsStencilFormat(GraphicsFormat format) => default; // 0x0000000184014670-0x00000001840146B0
		public static bool IsPVRTCFormat(GraphicsFormat format) => default; // 0x00000001840157D0-0x0000000184015810
		public static bool IsCrunchFormat(TextureFormat format) => default; // 0x0000000184015EA0-0x0000000184015EC0
		public static FormatSwizzle GetSwizzleR(GraphicsFormat format) => default; // 0x000000018BF0597C-0x000000018BF059B0
		public static FormatSwizzle GetSwizzleG(GraphicsFormat format) => default; // 0x000000018BF05948-0x000000018BF0597C
		public static FormatSwizzle GetSwizzleB(GraphicsFormat format) => default; // 0x000000018BF05914-0x000000018BF05948
		public static FormatSwizzle GetSwizzleA(GraphicsFormat format) => default; // 0x000000018BF058E0-0x000000018BF05914
		public static uint GetBlockSize(GraphicsFormat format) => default; // 0x000000018BF057A8-0x000000018BF057DC
	}
}

namespace UnityEngine.Experimental.U2D
{
	internal struct SpriteIntermediateRendererInfo // TypeDefIndex: 48091
	{
		// Fields
		public int SpriteID; // 0x00
		public int TextureID; // 0x04
		public int MaterialID; // 0x08
		public UnityEngine.Color Color; // 0x0C
		public Matrix4x4 Transform; // 0x1C
		public Bounds Bounds; // 0x5C
		public int Layer; // 0x74
		public int SortingLayer; // 0x78
		public int SortingOrder; // 0x7C
		public ulong SceneCullingMask; // 0x80
		public IntPtr IndexData; // 0x88
		public IntPtr VertexData; // 0x90
		public int IndexCount; // 0x98
		public int VertexCount; // 0x9C
		public int ShaderChannelMask; // 0xA0
	}

	internal class SpriteRendererGroup // TypeDefIndex: 48092
	{
		// Constructors
		public SpriteRendererGroup() {} // Dummy constructor
	}
}

namespace UnityEngine.HyperGryph
{
	public enum ManagerContextType // TypeDefIndex: 47925
	{
		HGManagerContext = 0,
		GameplayManagerContext = 1,
		Count = 2
	}

	public abstract class HGGlobalGameManagerAssetBase : ScriptableObject // TypeDefIndex: 47926
	{
		// Constructors
		protected HGGlobalGameManagerAssetBase() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		internal HGManagerContextBase InternalCreateManagerContext() => default; // 0x0000000185EE62C0-0x0000000185EE62F0
		protected abstract HGManagerContextBase CreateManagerContext();
		protected virtual void OnDisable() {} // 0x000000018BEFC53C-0x000000018BEFC584
	}

	public static class HGGlobalGameManager // TypeDefIndex: 47927
	{
		// Fields
		internal static HGGlobalGameManagerAssetBase[] currentManagerAssets; // 0x00
		public static HGManagerContextBase[] currentManagerContexts; // 0x08
	
		// Constructors
		static HGGlobalGameManager() {} // 0x0000000185F099B0-0x0000000185F09A60
	
		// Methods
		private static ScriptableObject GetGlobalGameManagerAsset(ManagerContextType contextType) => default; // 0x00000001843FE150-0x00000001843FE190
		public static HGGlobalGameManagerAssetBase GetManagerAsset(ManagerContextType contextType) => default; // 0x00000001843FE0E0-0x00000001843FE150
		internal static void HandleManagerAssetChange(ManagerContextType contextType, HGGlobalGameManagerAssetBase asset) {} // 0x00000001843FEBD0-0x00000001843FECE0
		internal static void CleanupManagerContext(ManagerContextType contextType) {} // 0x0000000185D21FA0-0x0000000185D22040
		public static bool InitializeManagerContext(ManagerContextType contextType, HGGlobalGameManagerAssetBase asset) => default; // 0x00000001843FE190-0x00000001843FE2E0
		internal static void ManagerContextEarlyUpdate() {} // 0x00000001843FE730-0x00000001843FE7D0
		internal static void ManagerContextGameplayUpdate() {} // 0x00000001843FE5F0-0x00000001843FE690
		internal static void ManagerContextPipelineUpdate() {} // 0x00000001843FE690-0x00000001843FE730
	}

	public abstract class HGManagerContextBase // TypeDefIndex: 47928
	{
		// Fields
		private bool _disposed_k__BackingField; // 0x10
	
		// Properties
		public bool disposed { get; private set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		protected HGManagerContextBase() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected abstract void EarlyUpdate();
		protected abstract void GameplayUpdate();
		protected abstract void PipelineUpdate();
		internal void InternalEarlyUpdate() {} // 0x00000001843FE7D0-0x00000001843FE800
		internal void InternalGameplayUpdate() {} // 0x00000001843FE830-0x00000001843FE860
		internal void InternalPipelineUpdate() {} // 0x00000001843FE800-0x00000001843FE830
		internal void Dispose() {} // 0x000000018BEFC584-0x000000018BEFC5DC
		protected virtual void Dispose(bool disposing) {} // 0x0000000185492010-0x0000000185492020
	}

	public struct LODCrossFadeConfig // TypeDefIndex: 47929
	{
		// Fields
		public Vector3 cameraPosition; // 0x00
		public Vector3 c0; // 0x0C
		public Vector3 c1; // 0x18
		public float fraction; // 0x24
		public float currMaxProjFactorSquared; // 0x28
		public float maxProjFactorSquared0; // 0x2C
		public float maxProjFactorSquared1; // 0x30
		public bool enableDither; // 0x34
		public bool isOrtho; // 0x35
		public byte lodBias; // 0x36
	}

	public struct HGShadowCullData // TypeDefIndex: 47930
	{
		// Fields
		public bool orthographic; // 0x00
		public float cameraNear; // 0x04
		public float projectionNear; // 0x08
		public float projectionFar; // 0x0C
		public float cameraFov; // 0x10
		public float shadowNearPlaneOffset; // 0x14
		public float shadowDistance; // 0x18
		public float baseFarDistance; // 0x1C
		public Matrix4x4 cameraClipToWorld; // 0x20
		public Matrix4x4 implicitProjection; // 0x60
		public Matrix4x4 cameraToWorld; // 0xA0
		public Vector3 eyePos; // 0xE0
		public Plane cullingPlaneLeft; // 0xEC
		public Plane cullingPlanesRight; // 0xFC
		public Plane cullingPlanesBottom; // 0x10C
		public Plane cullingPlanesTop; // 0x11C
		public Plane cullingPlanesNear; // 0x12C
		public Plane cullingPlanesFar; // 0x13C
		public Matrix4x4 lightLocalToWorld; // 0x14C
		public Vector3 center; // 0x18C
		public float radius; // 0x198
	}

	public struct LightCullResult // TypeDefIndex: 47931
	{
		// Fields
		public IntPtr visibleLightsPtr; // 0x00
		public int visibleLightCount; // 0x08
	
		// Properties
		public NativeArray<VisibleLight> visibleLights { get => default; } // 0x000000018BEFC794-0x000000018BEFC7FC 
	}

	public static class HGCullingSystem // TypeDefIndex: 47932
	{
		// Properties
		public static float parentLODBias { get; set; } // 0x000000018531ECB0-0x000000018531ED00
	
		// Methods
		public static void SetArtTagLODBias(uint artTag, float lodBias) {} // 0x000000018531EC60-0x000000018531ECB0
		public static uint AddCullViewByMatrix(in Matrix4x4 viewProj, int cameraInstantId, ulong sceneMask, uint cullingLayerMask, uint objectFlagsValue, uint objectFlagsMask, in LODCrossFadeConfig config, float viewScreenSizeMinSquared, CameraType viewType = CameraType.Unknown /* Metadata: 0x020609C6 */, uint uniqueId = 0 /* Metadata: 0x020609C8 */, int depthBufferWidth = 0 /* Metadata: 0x020609C9 */, int depthBufferHeight = 0 /* Metadata: 0x020609CA */, in Vector3 cameraDir = null, in Vector4 cameraProjInfo = null, float cullingRadius = 0f /* Metadata: 0x020609CB */, float ocScreenSizeMinSquared = 0.05f /* Metadata: 0x020609CF */) => default; // 0x000000018BEFC094-0x000000018BEFC100
		public static uint AddCullViewByPlanes(NativeArray<Plane> planes, int cameraInstantId, ulong sceneMask, uint cullingLayerMask, uint objectFlagsValue, uint objectFlagsMask, in LODCrossFadeConfig config, float viewScreenSizeMinSquared, CameraType viewType = CameraType.Unknown /* Metadata: 0x020609D3 */) => default; // 0x000000018BEFC100-0x000000018BEFC25C
		public static uint RegisterCullViewUniqueId(int instanceId) => default; // 0x0000000185EFB7F0-0x0000000185EFB830
		public static void UnregisterCullViewUniqueId(uint cullViewUniqueId) {} // 0x0000000185F56BA0-0x0000000185F56BE0
		public static uint AddCullViewByPlanes(IntPtr planes, int planeCount, int cameraInstantId, ulong sceneMask, uint cullingLayerMask, uint objectFlagsValue, uint objectFlagsMask, in LODCrossFadeConfig config, float viewScreenSizeMinSquared, CameraType viewType = CameraType.Unknown /* Metadata: 0x020609D5 */, uint uniqueId = 0 /* Metadata: 0x020609D7 */, int depthBufferWidth = 0 /* Metadata: 0x020609D8 */, int depthBufferHeight = 0 /* Metadata: 0x020609D9 */, in Matrix4x4 cullingMatrix = null, in Vector3 cameraDir = null, in Vector4 cameraProjInfo = null, float cullingRadius = 0f /* Metadata: 0x020609DA */, float ocScreenSizeMinSquared = 0.05f /* Metadata: 0x020609DE */) => default; // 0x000000018BEFC25C-0x000000018BEFC2C8
		public static void DispatchBatchCullingJobs() {} // 0x000000018BEFC3BC-0x000000018BEFC3E8
		public static JobHandle GetCullingViewFence(uint viewHandle) => default; // 0x000000018BEFC4B0-0x000000018BEFC4D8
		public static void ExtractShadowCullDataForDirLight(Camera camera, Matrix4x4 lightLocalToWorld, float shadowMaxDistance, float nearPlaneOffset, out HGShadowCullData shadowCullData) {
			shadowCullData = default;
		} // 0x000000018BEFC44C-0x000000018BEFC470
		public static void GetPSSMSplitMatrices(in HGShadowCullData shadowCullData, float splitPercentage0, float splitPercentage1, int shadowResolution, out Matrix4x4 outViewMatrix, out Matrix4x4 outProjMatrix, out Matrix4x4 outProjFlipYMatrix, out ShadowSplitData outSplitData) {
			outViewMatrix = default;
			outProjMatrix = default;
			outProjFlipYMatrix = default;
			outSplitData = default;
		} // 0x000000018BEFC4D8-0x000000018BEFC53C
		public static LightCullResult CullLights(uint viewHandle, Vector3 cameraPosition, uint maxCount, int cameraInstanceId) => default; // 0x000000018BEFC34C-0x000000018BEFC3BC
		private static void CullLightsInternal(uint viewHandle, Vector3 cameraPosition, uint maxCount, int cameraInstanceId, IntPtr result) {} // 0x000000018BEFC328-0x000000018BEFC34C
		private static void GetCullingViewFence_Injected(uint viewHandle, out JobHandle ret) {
			ret = default;
		} // 0x000000018BEFC470-0x000000018BEFC4B0
		private static void ExtractShadowCullDataForDirLight_Injected(Camera camera, ref Matrix4x4 lightLocalToWorld, float shadowMaxDistance, float nearPlaneOffset, out HGShadowCullData shadowCullData) {
			shadowCullData = default;
		} // 0x000000018BEFC3E8-0x000000018BEFC44C
		private static void CullLightsInternal_Injected(uint viewHandle, ref Vector3 cameraPosition, uint maxCount, int cameraInstanceId, IntPtr result) {} // 0x000000018BEFC2C8-0x000000018BEFC328
	}
}

namespace UnityEngine.Internal
{
	[Serializable]
	public class DefaultValueAttribute : Attribute // TypeDefIndex: 47923
	{
		// Fields
		private object DefaultValue; // 0x10
	
		// Properties
		public object Value { get => default; } // 0x0000000185FC7990-0x0000000185FC79A0 
	
		// Constructors
		public DefaultValueAttribute() {} // Dummy constructor
		public DefaultValueAttribute(string value) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BEFB07C-0x000000018BEFB0F4
		public override int GetHashCode() => default; // 0x000000018BEFB0F4-0x000000018BEFB120
	}

	[Serializable]
	public class ExcludeFromDocsAttribute : Attribute // TypeDefIndex: 47924
	{
		// Constructors
		public ExcludeFromDocsAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.Jobs
{
	public interface IJobParallelForTransform // TypeDefIndex: 47667
	{
		// Methods
		void Execute(int index, TransformAccess transform);
	}

	public interface IJobCrossFrameTransform // TypeDefIndex: 47668
	{
		// Methods
		void Execute(int index, TransformAccess transform);
	}

	public static class IJobParallelForTransformExtensions // TypeDefIndex: 47675
	{
		// Nested types
		internal struct TransformCrossFrameStruct<T> // TypeDefIndex: 47671
			where T : struct, IJobCrossFrameTransform
		{
			// Fields
			public static IntPtr jobReflectionData;
	
			// Nested types
			private struct TransformJobData // TypeDefIndex: 47669
			{
				// Fields
				public IntPtr TransformAccessArray;
				public int IsReadOnly;
			}
	
			public delegate void ExecuteJobFunction(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 47670; 0x00000000-0x00000000
	
			// Methods
			public static IntPtr Initialize() => default;
			public static void Execute(ref ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	
		internal struct TransformParallelForLoopStruct<T> // TypeDefIndex: 47674
			where T : struct, IJobParallelForTransform
		{
			// Fields
			public static IntPtr jobReflectionData;
	
			// Nested types
			private struct TransformJobData // TypeDefIndex: 47672
			{
				// Fields
				public IntPtr TransformAccessArray;
				public int IsReadOnly;
			}
	
			public delegate void ExecuteJobFunction(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 47673; 0x00000000-0x00000000
	
			// Methods
			public static IntPtr Initialize() => default;
			public static void Execute(ref ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	
		// Methods
		public static JobHandle Schedule<T>(T jobData, TransformAccessArray transforms, JobHandle dependsOn = default)
			where T : struct, IJobParallelForTransform => default;
		public static JobHandle ScheduleReadOnly<T>(T jobData, TransformAccessArray transforms, int batchSize, JobHandle dependsOn = default)
			where T : struct, IJobParallelForTransform => default;
		public static void RunReadOnly<T>(T jobData, TransformAccessArray transforms)
			where T : struct, IJobParallelForTransform {}
		public static JobHandle ScheduleCrossFrameReadOnly<T>(T jobData, TransformAccessArray transforms, JobHandle dependsOn = default)
			where T : struct, IJobCrossFrameTransform => default;
	}

	public struct TransformAccess // TypeDefIndex: 47676
	{
		// Fields
		private IntPtr hierarchy; // 0x00
		private int index; // 0x08
	
		// Properties
		public Vector3 position { get => default; set {} } // 0x000000018BEF03D4-0x000000018BEF041C 0x000000018BEF0494-0x000000018BEF04A8
		public Quaternion rotation { get => default; set {} } // 0x000000018BEF041C-0x000000018BEF0458 0x000000018BEF04A8-0x000000018BEF04BC
		public Vector3 localPosition { get => default; set {} } // 0x000000018BEF0298-0x000000018BEF02E0 0x000000018BEF0458-0x000000018BEF046C
		public Quaternion localRotation { get => default; set {} } // 0x000000018BEF02E0-0x000000018BEF031C 0x000000018BEF046C-0x000000018BEF0480
		public Vector3 localScale { get => default; set {} } // 0x000000018BEF031C-0x000000018BEF0364 0x000000018BEF0480-0x000000018BEF0494
		public Matrix4x4 localToWorldMatrix { get => default; } // 0x000000018BEF0364-0x000000018BEF03D4 
		public bool isValid { get => default; } // 0x0000000184443DF0-0x0000000184443E00 
	
		// Methods
		private static void GetPosition(ref TransformAccess access, out Vector3 p) {
			p = default;
		} // 0x000000018BEF00BC-0x000000018BEF0100
		private static void SetPosition(ref TransformAccess access, ref Vector3 p) {} // 0x000000018BEF0210-0x000000018BEF0254
		private static void GetRotation(ref TransformAccess access, out Quaternion r) {
			r = default;
		} // 0x000000018BEF0100-0x000000018BEF0144
		private static void SetRotation(ref TransformAccess access, ref Quaternion r) {} // 0x000000018BEF0254-0x000000018BEF0298
		private static void GetLocalPosition(ref TransformAccess access, out Vector3 p) {
			p = default;
		} // 0x000000018BEEFFAC-0x000000018BEEFFF0
		private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) {} // 0x000000018BEF0144-0x000000018BEF0188
		private static void GetLocalRotation(ref TransformAccess access, out Quaternion r) {
			r = default;
		} // 0x000000018BEEFFF0-0x000000018BEF0034
		private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) {} // 0x000000018BEF0188-0x000000018BEF01CC
		private static void GetLocalScale(ref TransformAccess access, out Vector3 r) {
			r = default;
		} // 0x000000018BEF0034-0x000000018BEF0078
		private static void SetLocalScale(ref TransformAccess access, ref Vector3 r) {} // 0x000000018BEF01CC-0x000000018BEF0210
		private static void GetLocalToWorldMatrix(ref TransformAccess access, out Matrix4x4 m) {
			m = default;
		} // 0x000000018BEF0078-0x000000018BEF00BC
	}

	public struct TransformAccessArray : IDisposable // TypeDefIndex: 47677
	{
		// Fields
		private IntPtr m_TransformArray; // 0x00
	
		// Properties
		public bool isCreated { get => default; } // 0x0000000186470EB8-0x0000000186470EC4 
		public Transform this[int index] { get => default; set {} } // 0x0000000186472698-0x00000001864726A8 0x0000000186471EBC-0x0000000186471EC8
		public int length { get => default; } // 0x0000000186471EA4-0x0000000186471EB0 
	
		// Constructors
		public TransformAccessArray(Transform[] transforms, int desiredJobCount = -1 /* Metadata: 0x02060985 */) : this() {
			m_TransformArray = default;
		} // 0x00000001848781C0-0x0000000184878210
		public TransformAccessArray(int capacity, int desiredJobCount = -1 /* Metadata: 0x02060986 */) : this() {
			m_TransformArray = default;
		} // 0x0000000186471DE0-0x0000000186471E08
	
		// Methods
		public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) {
			array = default;
		} // 0x0000000186470C00-0x0000000186470C1C
		public void Dispose() {} // 0x0000000186470E98-0x0000000186470EB8
		internal IntPtr GetTransformAccessArrayForSchedule() => default; // 0x0000000184142CB0-0x0000000184142CC0
		public void Add(Transform transform) {} // 0x0000000186471EB0-0x0000000186471EBC
		private static IntPtr Create(int capacity, int desiredJobCount) => default; // 0x00000001859D9360-0x00000001859D93B0
		private static void DestroyTransformAccessArray(IntPtr transformArray) {} // 0x0000000185BBA630-0x0000000185BBA670
		private static void SetTransforms(IntPtr transformArrayIntPtr, Transform[] transforms) {} // 0x0000000184878210-0x0000000184878260
		private static void Add(IntPtr transformArrayIntPtr, Transform transform) {} // 0x0000000185497670-0x00000001854976C0
		internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) => default; // 0x000000018BEEFF78-0x000000018BEEFFAC
		internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) => default; // 0x000000018BEEFF44-0x000000018BEEFF78
		internal static int GetLength(IntPtr transformArrayIntPtr) => default; // 0x00000001857B8E70-0x00000001857B8EB0
		internal static Transform GetTransform(IntPtr transformArrayIntPtr, int index) => default; // 0x0000000185FAA8A0-0x0000000185FAA8F0
		internal static void SetTransform(IntPtr transformArrayIntPtr, int index, Transform transform) {} // 0x00000001856CD380-0x00000001856CD3E0
	}
}

namespace UnityEngine.LowLevel
{
	internal struct PlayerLoopSystemInternal // TypeDefIndex: 47753
	{
		// Fields
		public System.Type type; // 0x00
		public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x08
		public IntPtr updateFunction; // 0x10
		public IntPtr loopConditionFunction; // 0x18
		public int numSubSystems; // 0x20
	}

	public struct PlayerLoopSystem // TypeDefIndex: 47755
	{
		// Fields
		public System.Type type; // 0x00
		public PlayerLoopSystem[] subSystemList; // 0x08
		public UpdateFunction updateDelegate; // 0x10
		public IntPtr updateFunction; // 0x18
		public IntPtr loopConditionFunction; // 0x20
	
		// Nested types
		public delegate void UpdateFunction(); // TypeDefIndex: 47754; 0x0000000184B27A10-0x0000000184B27AC0
	
		// Methods
		public override string ToString() => default; // 0x0000000184408540-0x00000001844086E0
	}

	public class PlayerLoop // TypeDefIndex: 47756
	{
		// Constructors
		public PlayerLoop() {} // Dummy constructor
	
		// Methods
		public static PlayerLoopSystem GetCurrentPlayerLoop() => default; // 0x0000000184B28270-0x0000000184B282D0
		public static void SetPlayerLoop(PlayerLoopSystem loop) {} // 0x0000000184B288E0-0x0000000184B289C0
		private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal> internalSys) => default; // 0x0000000184B28C20-0x0000000184B290E0
		private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset) => default; // 0x0000000184B28310-0x0000000184B288E0
		private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() => default; // 0x0000000184B282D0-0x0000000184B28310
		private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) {} // 0x0000000184B290E0-0x0000000184B29120
	}
}

namespace UnityEngine.Networking.PlayerConnection
{
	[Serializable]
	public class MessageEventArgs // TypeDefIndex: 47910
	{
		// Fields
		public int playerId; // 0x10
		public byte[] data; // 0x18
	
		// Constructors
		public MessageEventArgs() {} // 0x0000000185492010-0x0000000185492020
	}

	public interface IEditorPlayerConnection // TypeDefIndex: 47911
	{
		// Methods
		void Register(Guid messageId, UnityAction<MessageEventArgs> callback);
		void RegisterConnection(UnityAction<int> callback);
		void RegisterDisconnection(UnityAction<int> callback);
		void Send(Guid messageId, byte[] data);
	}

	[Serializable]
	public class PlayerConnection : ScriptableObject, IEditorPlayerConnection // TypeDefIndex: 47915
	{
		// Fields
		internal static IPlayerEditorConnectionNative connectionNative; // 0x00
		private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
		private List<int> m_connectedPlayers; // 0x20
		private bool m_IsInitilized; // 0x28
		private static PlayerConnection s_Instance; // 0x08
	
		// Properties
		public static PlayerConnection instance { get => default; } // 0x000000018BEFD7D0-0x000000018BEFD964 
		public bool isConnected { get => default; } // 0x000000018BEFD008-0x000000018BEFD17C 
	
		// Nested types
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 47912
		{
			// Fields
			public Guid messageId; // 0x10
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x000000018BEFDA1C-0x000000018BEFDAA0
	
			// Methods
			internal bool _Register_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) => default; // 0x000000018BEFDAA0-0x000000018BEFDB0C
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 47913
		{
			// Fields
			public Guid messageId; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x000000018BEFCC58-0x000000018BEFCCFC
	
			// Methods
			internal bool _Unregister_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) => default; // 0x000000018BEFCF88-0x000000018BEFD008
		}
	
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 47914
		{
			// Fields
			public bool msgReceived; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x000000018BEFCDF8-0x000000018BEFCE58
	
			// Methods
			internal void _BlockUntilRecvMsg_b__0(MessageEventArgs args) {} // 0x000000018BEFD1DC-0x000000018BEFD448
		}
	
		// Constructors
		public PlayerConnection() {} // 0x0000000181B9A230-0x0000000181B9A240
	
		// Methods
		private static PlayerConnection CreateInstance() => default; // 0x000000018BEFD17C-0x000000018BEFD1DC
		public void OnEnable() {} // 0x000000018BEFD710-0x000000018BEFD770
		private IPlayerEditorConnectionNative GetConnectionNativeApi() => default; // 0x000000018BEFD770-0x000000018BEFD7D0
		public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) {} // 0x000000018BEFD448-0x000000018BEFD5AC
		public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) {} // 0x000000018BEFD5AC-0x000000018BEFD710
		public void RegisterConnection(UnityAction<int> callback) {} // 0x000000018BEFCA2C-0x000000018BEFCBCC
		public void RegisterDisconnection(UnityAction<int> callback) {} // 0x000000018BEFCCFC-0x000000018BEFCD6C
		public void UnregisterConnection(UnityAction<int> callback) {} // 0x000000018BEFCE58-0x000000018BEFCF88
		public void UnregisterDisconnection(UnityAction<int> callback) {} // 0x000000018BEFCBCC-0x000000018BEFCC58
		public void Send(Guid messageId, byte[] data) {} // 0x000000018BEFCD6C-0x000000018BEFCDF8
		public bool TrySend(Guid messageId, byte[] data) => default; // 0x000000018BEFD964-0x000000018BEFDA1C
		public bool BlockUntilRecvMsg(Guid messageId, int timeout) => default; // 0x0000000185492010-0x0000000185492020
		public void DisconnectAll() {} // 0x000000018BF0457C-0x000000018BF045C8
		private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) {} // 0x0000000185492010-0x0000000185492020
		private static void ConnectedCallbackInternal(int playerId) {} // 0x000000018BF0457C-0x000000018BF045C8
		private static void DisconnectedCallback(int playerId) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	internal class PlayerEditorConnectionEvents // TypeDefIndex: 47922
	{
		// Fields
		public List<MessageTypeSubscribers> messageTypeSubscribers; // 0x10
		public ConnectionChangeEvent connectionEvent; // 0x18
		public ConnectionChangeEvent disconnectionEvent; // 0x20
	
		// Nested types
		[Serializable]
		public class MessageEvent : UnityEvent<MessageEventArgs> // TypeDefIndex: 47916
		{
			// Constructors
			public MessageEvent() {} // 0x000000018BEFDC9C-0x000000018BEFDF68
		}
	
		[Serializable]
		public class ConnectionChangeEvent : UnityEvent<int> // TypeDefIndex: 47917
		{
			// Constructors
			public ConnectionChangeEvent() {} // 0x000000018BEFDB0C-0x000000018BEFDC9C
		}
	
		[Serializable]
		public class MessageTypeSubscribers // TypeDefIndex: 47918
		{
			// Fields
			private string m_messageTypeId; // 0x10
			public int subscriberCount; // 0x18
			public MessageEvent messageCallback; // 0x20
	
			// Properties
			public Guid MessageTypeId { get => default; set {} } // 0x000000018BEFDF68-0x000000018BEFE0A8 0x000000018BEFE0A8-0x000000018BEFE180
	
			// Constructors
			public MessageTypeSubscribers() {} // 0x000000018BEFC7FC-0x000000018BEFC838
		}
	
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 47919
		{
			// Fields
			public Guid messageId; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0() {} // 0x000000018BEFAD30-0x000000018BEFAD6C
	
			// Methods
			internal bool _InvokeMessageIdSubscribers_b__0(MessageTypeSubscribers x) => default; // 0x000000018BEFC8A0-0x000000018BEFC8D8
		}
	
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 47920
		{
			// Fields
			public Guid messageId; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x000000018BEFC8D8-0x000000018BEFC904
	
			// Methods
			internal bool _AddAndCreate_b__0(MessageTypeSubscribers x) => default; // 0x000000018BEFC838-0x000000018BEFC8A0
		}
	
		private sealed class __c__DisplayClass8_0 // TypeDefIndex: 47921
		{
			// Fields
			public Guid messageId; // 0x10
	
			// Constructors
			public __c__DisplayClass8_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal bool _UnregisterManagedCallback_b__0(MessageTypeSubscribers x) => default; // 0x000000018BF0457C-0x000000018BF045C8
		}
	
		// Constructors
		public PlayerEditorConnectionEvents() {} // 0x000000018BF0457C-0x000000018BF045C8
	
		// Methods
		public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) {} // 0x0000000185492010-0x0000000185492020
		public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) => default; // 0x000000018BF0457C-0x000000018BF045C8
		public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.Playables
{
	public struct FrameData // TypeDefIndex: 48061
	{
		// Fields
		internal ulong m_FrameID; // 0x00
		internal double m_DeltaTime; // 0x08
		internal float m_Weight; // 0x10
		internal float m_EffectiveWeight; // 0x14
		internal double m_EffectiveParentDelay; // 0x18
		internal float m_EffectiveParentSpeed; // 0x20
		internal float m_EffectiveSpeed; // 0x24
		internal Flags m_Flags; // 0x28
		internal PlayableOutput m_Output; // 0x30
	
		// Properties
		public float deltaTime { get => default; } // 0x0000000185FE8730-0x0000000185FE8740 
		public float weight { get => default; } // 0x0000000185FE64C0-0x0000000185FE64D0 
		public float effectiveWeight { get => default; } // 0x0000000185FC40E0-0x0000000185FC40F0 
		public float effectiveSpeed { get => default; } // 0x0000000185FE7AE0-0x0000000185FE7AF0 
		public EvaluationType evaluationType { get => default; } // 0x000000018BF051E0-0x000000018BF051EC 
		public bool seekOccurred { get => default; } // 0x000000018BF051EC-0x000000018BF051F4 
		public bool timeLooped { get => default; } // 0x000000018BF05200-0x000000018BF0520C 
		public bool timeHeld { get => default; } // 0x000000018BF051F4-0x000000018BF05200 
		public PlayableOutput output { get => default; } // 0x0000000185FE8740-0x0000000185FE8750 
		public PlayState effectivePlayState { get => default; } // 0x000000018BF051C8-0x000000018BF051E0 
	
		// Nested types
		internal enum Flags // TypeDefIndex: 48059
		{
			Evaluate = 1,
			SeekOccured = 2,
			Loop = 4,
			Hold = 8,
			EffectivePlayStateDelayed = 16,
			EffectivePlayStatePlaying = 32
		}
	
		public enum EvaluationType // TypeDefIndex: 48060
		{
			Evaluate = 0,
			Playback = 1
		}
	
		// Methods
		private bool HasFlags(Flags flag) => default; // 0x000000018BF051BC-0x000000018BF051C8
	}

	internal struct FrameRate : IEquatable<FrameRate> // TypeDefIndex: 48062
	{
		// Fields
		public static readonly FrameRate k_24Fps; // 0x00
		public static readonly FrameRate k_23_976Fps; // 0x04
		public static readonly FrameRate k_25Fps; // 0x08
		public static readonly FrameRate k_30Fps; // 0x0C
		public static readonly FrameRate k_29_97Fps; // 0x10
		public static readonly FrameRate k_50Fps; // 0x14
		public static readonly FrameRate k_60Fps; // 0x18
		public static readonly FrameRate k_59_94Fps; // 0x1C
		private int m_Rate; // 0x00
	
		// Properties
		public bool dropFrame { get => default; } // 0x000000018B3AF13C-0x000000018B3AF144 
		public double rate { get => default; } // 0x000000018BF05508-0x000000018BF05564 
	
		// Constructors
		public FrameRate(uint frameRate = 0 /* Metadata: 0x02060BC1 */, bool drop = false /* Metadata: 0x02060BC2 */) : this() {
			m_Rate = default;
		} // 0x000000018BF054F0-0x000000018BF05508
		static FrameRate() {
			k_24Fps = default;
			k_23_976Fps = default;
			k_25Fps = default;
			k_30Fps = default;
			k_29_97Fps = default;
			k_50Fps = default;
			k_60Fps = default;
			k_59_94Fps = default;
		} // 0x000000018BF05424-0x000000018BF054F0
	
		// Methods
		public bool Equals(FrameRate other) => default; // 0x0000000183FAA6E0-0x0000000183FAA6F0
		public override bool Equals(object obj) => default; // 0x000000018BF0520C-0x000000018BF0527C
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public override string ToString() => default; // 0x000000018BF053D4-0x000000018BF05424
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BF0527C-0x000000018BF053D4
	}

	public interface INotification // TypeDefIndex: 48063
	{
		// Properties
		PropertyName id { get; }
	}

	public interface INotificationReceiver // TypeDefIndex: 48064
	{
		// Methods
		void OnNotify(Playable origin, INotification notification, object context);
	}

	public interface IPlayable // TypeDefIndex: 48065
	{
		// Methods
		PlayableHandle GetHandle();
	}

	public interface IPlayableBehaviour // TypeDefIndex: 48066
	{
		// Methods
		void OnGraphStart(Playable playable);
		void OnGraphStop(Playable playable);
		void OnPlayableCreate(Playable playable);
		void OnPlayableDestroy(Playable playable);
		void OnBehaviourPlay(Playable playable, FrameData info);
		void OnBehaviourPause(Playable playable, FrameData info);
		void PrepareFrame(Playable playable, FrameData info);
		void ProcessFrame(Playable playable, FrameData info, object playerData);
	}

	public interface IPlayableOutput // TypeDefIndex: 48067
	{
		// Methods
		PlayableOutputHandle GetHandle();
	}

	public enum DirectorWrapMode // TypeDefIndex: 48068
	{
		Hold = 0,
		Loop = 1,
		None = 2
	}

	public struct Playable : IPlayable, IEquatable<Playable> // TypeDefIndex: 48069
	{
		// Fields
		private PlayableHandle m_Handle; // 0x00
		private static readonly Playable m_NullPlayable; // 0x00
	
		// Properties
		public static Playable Null { get => default; } // 0x000000018484B700-0x000000018484B770 
	
		// Constructors
		internal Playable(PlayableHandle handle) : this() {
			m_Handle = default;
		} // 0x0000000185FBFA60-0x0000000185FBFA70
		static Playable() {
			m_NullPlayable = default;
		} // 0x0000000185F63930-0x0000000185F639A0
	
		// Methods
		public static Playable Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x02060BC6 */) => default; // 0x000000018BF08F70-0x000000018BF09010
		public PlayableHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public bool IsPlayableOfType<T>()
			where T : struct, IPlayable => default;
		public System.Type GetPlayableType() => default; // 0x000000018BF0909C-0x000000018BF09108
		public bool Equals(Playable other) => default; // 0x000000018BF09010-0x000000018BF0909C
	}

	public interface IPlayableAsset // TypeDefIndex: 48070
	{
		// Properties
		double duration { get; }
	
		// Methods
		Playable CreatePlayable(PlayableGraph graph, GameObject owner);
	}

	[Serializable]
	public abstract class PlayableAsset : ScriptableObject, IPlayableAsset // TypeDefIndex: 48071
	{
		// Properties
		public virtual double duration { get; } // 0x000000018BF071FC-0x000000018BF0724C 
		public virtual IEnumerable<PlayableBinding> outputs { get; } // 0x000000018BF0724C-0x000000018BF0729C 
	
		// Constructors
		protected PlayableAsset() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);
		internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) {} // 0x000000018BF07104-0x000000018BF071D0
		internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) {} // 0x000000018BF071D0-0x000000018BF071FC
	}

	[Serializable]
	public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable // TypeDefIndex: 48072
	{
		// Constructors
		public PlayableBehaviour() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual void OnGraphStart(Playable playable) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnGraphStop(Playable playable) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnPlayableCreate(Playable playable) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnPlayableDestroy(Playable playable) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public virtual void PrepareData(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public virtual void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000185492010-0x0000000185492020
		public virtual object Clone() => default; // 0x000000018BF0729C-0x000000018BF072A4
	}

	public struct PlayableBinding // TypeDefIndex: 48074
	{
		// Fields
		private string m_StreamName; // 0x00
		private UnityEngine.Object m_SourceObject; // 0x08
		private System.Type m_SourceBindingType; // 0x10
		private CreateOutputMethod m_CreateOutputMethod; // 0x18
		public static readonly PlayableBinding[] None; // 0x00
		public static readonly double DefaultDuration; // 0x08
	
		// Properties
		public UnityEngine.Object sourceObject { get => default; } // 0x000000018BF072A4-0x000000018BF0731C 
	
		// Nested types
		internal delegate PlayableOutput CreateOutputMethod(PlayableGraph graph, string name); // TypeDefIndex: 48073; 0x000000018BF0731C-0x000000018BF073CC
	
		// Constructors
		static PlayableBinding() {
			None = default;
			DefaultDuration = default;
		} // 0x00000001872130A0-0x00000001872130E0
	
		// Methods
		internal PlayableOutput CreateOutput(PlayableGraph graph) => default; // 0x000000018BF073CC-0x000000018BF0744C
		internal static PlayableBinding CreateInternal(string name, UnityEngine.Object sourceObject, System.Type sourceType, CreateOutputMethod createFunction) => default; // 0x0000000188FD75D8-0x0000000188FD76A0
	}

	public enum PlayableTraversalMode // TypeDefIndex: 48075
	{
		Mix = 0,
		Passthrough = 1
	}

	public static class PlayableExtensions // TypeDefIndex: 48076
	{
		// Methods
		public static bool IsNull<U>(U playable)
			where U : struct, IPlayable => default;
		public static bool IsValid<U>(U playable)
			where U : struct, IPlayable => default;
		public static void Destroy<U>(U playable)
			where U : struct, IPlayable {}
		public static PlayableGraph GetGraph<U>(U playable)
			where U : struct, IPlayable => default;
		public static PlayState GetPlayState<U>(U playable)
			where U : struct, IPlayable => default;
		public static void Play<U>(U playable)
			where U : struct, IPlayable {}
		public static void Pause<U>(U playable)
			where U : struct, IPlayable {}
		public static void SetSpeed<U>(U playable, double value)
			where U : struct, IPlayable {}
		public static double GetSpeed<U>(U playable)
			where U : struct, IPlayable => default;
		public static void SetDuration<U>(U playable, double value)
			where U : struct, IPlayable {}
		public static double GetDuration<U>(U playable)
			where U : struct, IPlayable => default;
		public static void SetTime<U>(U playable, double value)
			where U : struct, IPlayable {}
		public static void SetTimeUncheck<U>(U playable, double value)
			where U : struct, IPlayable {}
		public static double GetTime<U>(U playable)
			where U : struct, IPlayable => default;
		public static double GetPreviousTime<U>(U playable)
			where U : struct, IPlayable => default;
		public static bool IsDone<U>(U playable)
			where U : struct, IPlayable => default;
		public static void SetPropagateSetTime<U>(U playable, bool value)
			where U : struct, IPlayable {}
		public static bool CanDestroy<U>(U playable)
			where U : struct, IPlayable => default;
		public static void SetInputCount<U>(U playable, int value)
			where U : struct, IPlayable {}
		public static int GetInputCount<U>(U playable)
			where U : struct, IPlayable => default;
		public static Playable GetInput<U>(U playable, int inputPort)
			where U : struct, IPlayable => default;
		public static void SetInputWeight<U>(U playable, int inputIndex, float weight)
			where U : struct, IPlayable {}
		public static void SetInputWeightUncheck<U>(U playable, int inputIndex, float weight)
			where U : struct, IPlayable {}
		public static void SetInputWeight<U, V>(U playable, V input, float weight)
			where U : struct, IPlayable
			where V : struct, IPlayable {}
		public static float GetInputWeight<U>(U playable, int inputIndex)
			where U : struct, IPlayable => default;
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex)
			where U : struct, IPlayable
			where V : struct, IPlayable {}
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight)
			where U : struct, IPlayable
			where V : struct, IPlayable {}
		public static void DisconnectInput<U>(U playable, int inputPort)
			where U : struct, IPlayable {}
		public static int AddInput<U, V>(U playable, V sourcePlayable, int sourceOutputIndex, float weight = 0f /* Metadata: 0x02060BC9 */)
			where U : struct, IPlayable
			where V : struct, IPlayable => default;
		public static float GetLeadTime<U>(U playable)
			where U : struct, IPlayable => default;
		public static void SetTraversalMode<U>(U playable, PlayableTraversalMode mode)
			where U : struct, IPlayable {}
		internal static DirectorWrapMode GetTimeWrapMode<U>(U playable)
			where U : struct, IPlayable => default;
		internal static void SetTimeWrapMode<U>(U playable, DirectorWrapMode value)
			where U : struct, IPlayable {}
	}

	public enum DirectorUpdateMode // TypeDefIndex: 48077
	{
		DSPClock = 0,
		GameTime = 1,
		UnscaledGameTime = 2,
		Manual = 3
	}

	public struct PlayableGraph // TypeDefIndex: 48078
	{
		// Fields
		internal IntPtr m_Handle; // 0x00
		internal uint m_Version; // 0x08
	
		// Methods
		public Playable GetRootPlayable(int index) => default; // 0x000000018442E160-0x000000018442E1E0
		public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort)
			where U : struct, IPlayable
			where V : struct, IPlayable => default;
		public void Disconnect<U>(U input, int inputPort)
			where U : struct, IPlayable {}
		public void DestroyPlayable<U>(U playable)
			where U : struct, IPlayable {}
		public PlayableOutput GetOutput(int index) => default; // 0x000000018484B680-0x000000018484B700
		public void Evaluate() {} // 0x000000018646F6D8-0x000000018646F6E4
		public static PlayableGraph Create() => default; // 0x0000000184D40430-0x0000000184D40490
		public static PlayableGraph Create(string name) => default; // 0x0000000184D40490-0x0000000184D404C0
		public void Destroy() {} // 0x000000018646EF5C-0x000000018646EF64
		public bool IsValid() => default; // 0x000000018646F6BC-0x000000018646F6C4
		public bool IsPlaying() => default; // 0x000000018BF0772C-0x000000018BF07734
		public void Play() {} // 0x000000018646F6B4-0x000000018646F6BC
		public void Stop() {} // 0x000000018646FF90-0x000000018646FF98
		public void Evaluate(float deltaTime) {} // 0x000000018646E960-0x000000018646E968
		public void SetTimeUpdateMode(DirectorUpdateMode value) {} // 0x0000000186472648-0x0000000186472650
		public IExposedPropertyTable GetResolver() => default; // 0x000000018BF0763C-0x000000018BF07644
		public int GetPlayableCount() => default; // 0x000000018BF07600-0x000000018BF07608
		public int GetRootPlayableCount() => default; // 0x000000018BF07678-0x000000018BF07680
		internal void SynchronizeEvaluation(PlayableGraph playable) {} // 0x000000018BF077C4-0x000000018BF077D8
		public int GetOutputCount() => default; // 0x000000018647044C-0x0000000186470454
		public void SetEarlyPrepareFrame(bool enable) {} // 0x000000018BF07778-0x000000018BF07780
		public bool IsEarlyPrepareFrame() => default; // 0x000000018BF076B4-0x000000018BF076BC
		internal PlayableHandle CreatePlayableHandle() => default; // 0x000000018BF07490-0x000000018BF074BC
		internal bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle) {
			handle = default;
			return default;
		} // 0x000000018BF07510-0x000000018BF07518
		internal PlayableHandle GetRootPlayableInternal(int index) => default; // 0x000000018442E1E0-0x000000018442E210
		internal bool IsMatchFrameRateEnabled() => default; // 0x000000018BF076F0-0x000000018BF076F8
		internal FrameRate GetFrameRate() => default; // 0x000000018BF075A8-0x000000018BF075CC
		private bool GetOutputInternal(int index, out PlayableOutputHandle handle) {
			handle = default;
			return default;
		} // 0x0000000186470454-0x000000018647045C
		private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort) => default; // 0x000000018647334C-0x000000018647336C
		private void DisconnectInternal(PlayableHandle playable, int inputPort) {} // 0x0000000186473B04-0x0000000186473B18
		private void DestroyPlayableInternal(PlayableHandle playable) {} // 0x0000000186473B60-0x0000000186473B74
		public void EnableFixedFrameRate(float sampleRatio) {} // 0x000000018BF0755C-0x000000018BF07564
		private static void Create_Injected(string name, out PlayableGraph ret) {
			ret = default;
		} // 0x0000000184D404C0-0x0000000184D40510
		private static void Destroy_Injected(ref PlayableGraph _unity_self) {} // 0x000000018577B130-0x000000018577B170
		private static bool IsValid_Injected(ref PlayableGraph _unity_self) => default; // 0x0000000185352060-0x00000001853520A0
		private static bool IsPlaying_Injected(ref PlayableGraph _unity_self) => default; // 0x000000018BF076F8-0x000000018BF0772C
		private static void Play_Injected(ref PlayableGraph _unity_self) {} // 0x00000001855DA150-0x00000001855DA1C0
		private static void Stop_Injected(ref PlayableGraph _unity_self) {} // 0x0000000185709A00-0x0000000185709B30
		private static void Evaluate_Injected(ref PlayableGraph _unity_self, float deltaTime) {} // 0x0000000184F806A0-0x0000000184F806F0
		private static void SetTimeUpdateMode_Injected(ref PlayableGraph _unity_self, DirectorUpdateMode value) {} // 0x0000000184D3E720-0x0000000184D3E770
		private static IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self) => default; // 0x000000018BF07608-0x000000018BF0763C
		private static int GetPlayableCount_Injected(ref PlayableGraph _unity_self) => default; // 0x000000018BF075CC-0x000000018BF07600
		private static int GetRootPlayableCount_Injected(ref PlayableGraph _unity_self) => default; // 0x000000018BF07644-0x000000018BF07678
		private static void SynchronizeEvaluation_Injected(ref PlayableGraph _unity_self, ref PlayableGraph playable) {} // 0x000000018BF07780-0x000000018BF077C4
		private static int GetOutputCount_Injected(ref PlayableGraph _unity_self) => default; // 0x0000000185F5FB80-0x0000000185F5FBC0
		private static void SetEarlyPrepareFrame_Injected(ref PlayableGraph _unity_self, bool enable) {} // 0x000000018BF07734-0x000000018BF07778
		private static bool IsEarlyPrepareFrame_Injected(ref PlayableGraph _unity_self) => default; // 0x000000018BF07680-0x000000018BF076B4
		private static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret) {
			ret = default;
		} // 0x000000018BF0744C-0x000000018BF07490
		private static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle) {
			handle = default;
			return default;
		} // 0x000000018BF074BC-0x000000018BF07510
		private static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret) {
			ret = default;
		} // 0x000000018442E210-0x000000018442E270
		private static bool IsMatchFrameRateEnabled_Injected(ref PlayableGraph _unity_self) => default; // 0x000000018BF076BC-0x000000018BF076F0
		private static void GetFrameRate_Injected(ref PlayableGraph _unity_self, out FrameRate ret) {
			ret = default;
		} // 0x000000018BF07564-0x000000018BF075A8
		private static bool GetOutputInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableOutputHandle handle) {
			handle = default;
			return default;
		} // 0x0000000185D90ED0-0x0000000185D90F30
		private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort) => default; // 0x00000001850B6C20-0x00000001850B6C90
		private static void DisconnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable, int inputPort) {} // 0x000000018530A8B0-0x000000018530A910
		private static void DestroyPlayableInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable) {} // 0x0000000185351D90-0x0000000185351DE0
		private static void EnableFixedFrameRate_Injected(ref PlayableGraph _unity_self, float sampleRatio) {} // 0x000000018BF07518-0x000000018BF0755C
	}

	public enum PlayState // TypeDefIndex: 48079
	{
		Paused = 0,
		Playing = 1,
		Delayed = 2
	}

	public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 48080
	{
		// Fields
		internal IntPtr m_Handle; // 0x00
		internal uint m_Version; // 0x08
		private static readonly PlayableHandle m_Null; // 0x00
	
		// Properties
		public static PlayableHandle Null { get => default; } // 0x00000001845F0120-0x00000001845F0190 
	
		// Constructors
		static PlayableHandle() {
			m_Null = default;
		} // 0x0000000185F9D170-0x0000000185F9D1B0
	
		// Methods
		internal T GetObject<T>()
			where T : class, IPlayableBehaviour => default;
		public object GetWrapScriptObject() => default; // 0x000000018BF0813C-0x000000018BF081A8
		internal bool IsPlayableOfType<T>() => default;
		internal Playable GetInput(int inputPort) => default; // 0x00000001856D7F00-0x00000001856D7F80
		internal bool SetInputWeight(int inputIndex, float weight) => default; // 0x00000001849AAF90-0x00000001849AB0F0
		internal bool SetInputWeightUncheck(int inputIndex, float weight) => default; // 0x000000018BF08498-0x000000018BF08524
		internal float GetInputWeight(int inputIndex) => default; // 0x000000018BF07CC8-0x000000018BF07D3C
		internal void Destroy() {} // 0x00000001851D10F0-0x00000001851D1180
		public static bool operator ==(PlayableHandle x, PlayableHandle y) => default; // 0x000000018BF088EC-0x000000018BF08954
		public override bool Equals(object p) => default; // 0x000000018BF07A38-0x000000018BF07ABC
		public bool Equals(PlayableHandle other) => default; // 0x000000018BF07ABC-0x000000018BF07B30
		public override int GetHashCode() => default; // 0x0000000185FE87A0-0x0000000185FE87B0
		internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) => default; // 0x00000001835DAFD0-0x00000001835DAFF0
		internal bool CheckInputBounds(int inputIndex) => default; // 0x00000001849AB0F0-0x00000001849AB150
		internal bool CheckInputBounds(int inputIndex, bool acceptAny) => default; // 0x00000001849AB240-0x00000001849AB340
		internal bool CheckInputBoundsUncheck(int inputIndex) => default; // 0x000000018BF07858-0x000000018BF07A38
		internal bool IsNull() => default; // 0x000000018BF0825C-0x000000018BF082A8
		internal bool IsValid() => default; // 0x00000001845F0300-0x00000001845F0380
		internal System.Type GetPlayableType() => default; // 0x0000000185062A10-0x0000000185062A90
		internal System.Type GetJobType() => default; // 0x000000018BF07DF0-0x000000018BF07E3C
		internal void SetScriptInstance(object scriptInstance) {} // 0x000000018BF086C0-0x000000018BF0871C
		internal bool CanDestroy() => default; // 0x000000018BF0780C-0x000000018BF07858
		internal PlayState GetPlayState() => default; // 0x000000018BF07EF0-0x000000018BF07F3C
		internal void Play() {} // 0x0000000185459A50-0x0000000185459AA0
		internal void Pause() {} // 0x000000018514C3D0-0x000000018514C420
		internal double GetSpeed() => default; // 0x000000018BF08070-0x000000018BF080BC
		internal void SetSpeed(double value) {} // 0x0000000184DFB3F0-0x0000000184DFB480
		internal double GetTime() => default; // 0x0000000184ADA9A0-0x0000000184ADAA20
		internal void SetTime(double value) {} // 0x0000000184EBE570-0x0000000184EBE600
		internal bool IsDone() => default; // 0x000000018BF081DC-0x000000018BF08228
		internal void SetDone(bool value) {} // 0x000000018BF082EC-0x000000018BF08348
		internal double GetDuration() => default; // 0x000000018BF07B64-0x000000018BF07BB0
		internal void SetDuration(double value) {} // 0x000000018BF0838C-0x000000018BF083E8
		internal void SetPropagateSetTime(bool value) {} // 0x000000018BF08620-0x000000018BF0867C
		internal PlayableGraph GetGraph() => default; // 0x00000001851D1180-0x00000001851D11F0
		internal int GetInputCount() => default; // 0x00000001849AB340-0x00000001849AB3C0
		internal void SetInputCount(int value) {} // 0x00000001845EEC00-0x00000001845EEC60
		internal void SetInputWeight(PlayableHandle input, float weight) {} // 0x000000018BF08578-0x000000018BF085DC
		internal double GetPreviousTime() => default; // 0x000000018BF07F70-0x000000018BF07FBC
		internal float GetLeadTime() => default; // 0x000000018BF07E70-0x000000018BF07EBC
		internal void SetTraversalMode(PlayableTraversalMode mode) {} // 0x000000018BF08894-0x000000018BF088EC
		internal IntPtr GetJobData() => default; // 0x000000018BF07D70-0x000000018BF07DBC
		internal DirectorWrapMode GetTimeWrapMode() => default; // 0x000000018BF080F0-0x000000018BF0813C
		internal void SetTimeWrapMode(DirectorWrapMode mode) {} // 0x000000018BF087FC-0x000000018BF08854
		private object GetScriptInstance() => default; // 0x000000018BF07FF0-0x000000018BF0803C
		private PlayableHandle GetInputHandle(int index) => default; // 0x00000001856D7F80-0x00000001856D8000
		private void SetInputWeightFromIndex(int index, float weight) {} // 0x00000001849AB150-0x00000001849AB1E0
		private float GetInputWeightFromIndex(int index) => default; // 0x000000018BF07C70-0x000000018BF07CC8
		private void SetInputWeightFromIndexUncheck(int index, float weight) {} // 0x000000018BF08438-0x000000018BF08498
		internal int GetInputCountUncheck() => default; // 0x000000018BF07BE4-0x000000018BF07C30
		internal void SetTimeUncheck(double value) {} // 0x000000018BF08760-0x000000018BF087BC
		private static bool IsNull_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF08228-0x000000018BF0825C
		private static bool IsValid_Injected(ref PlayableHandle _unity_self) => default; // 0x00000001845F0380-0x00000001845F03C0
		private static System.Type GetPlayableType_Injected(ref PlayableHandle _unity_self) => default; // 0x0000000185062A90-0x0000000185062AD0
		private static System.Type GetJobType_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF07DBC-0x000000018BF07DF0
		private static void SetScriptInstance_Injected(ref PlayableHandle _unity_self, object scriptInstance) {} // 0x000000018BF0867C-0x000000018BF086C0
		private static bool CanDestroy_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF077D8-0x000000018BF0780C
		private static PlayState GetPlayState_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF07EBC-0x000000018BF07EF0
		private static void Play_Injected(ref PlayableHandle _unity_self) {} // 0x0000000185459AA0-0x0000000185459AE0
		private static void Pause_Injected(ref PlayableHandle _unity_self) {} // 0x000000018514C420-0x000000018514C460
		private static double GetSpeed_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF0803C-0x000000018BF08070
		private static void SetSpeed_Injected(ref PlayableHandle _unity_self, double value) {} // 0x0000000184DFB480-0x0000000184DFB4D0
		private static double GetTime_Injected(ref PlayableHandle _unity_self) => default; // 0x0000000184ADAA20-0x0000000184ADAC40
		private static void SetTime_Injected(ref PlayableHandle _unity_self, double value) {} // 0x0000000184EBE600-0x0000000184EBE650
		private static bool IsDone_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF081A8-0x000000018BF081DC
		private static void SetDone_Injected(ref PlayableHandle _unity_self, bool value) {} // 0x000000018BF082A8-0x000000018BF082EC
		private static double GetDuration_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF07B30-0x000000018BF07B64
		private static void SetDuration_Injected(ref PlayableHandle _unity_self, double value) {} // 0x000000018BF08348-0x000000018BF0838C
		private static void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, bool value) {} // 0x000000018BF085DC-0x000000018BF08620
		private static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret) {
			ret = default;
		} // 0x00000001851D11F0-0x00000001851D1240
		private static int GetInputCount_Injected(ref PlayableHandle _unity_self) => default; // 0x00000001849AB3C0-0x00000001849AB400
		private static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value) {} // 0x00000001845EEC60-0x00000001845EECB0
		private static void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, float weight) {} // 0x000000018BF08524-0x000000018BF08578
		private static double GetPreviousTime_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF07F3C-0x000000018BF07F70
		private static float GetLeadTime_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF07E3C-0x000000018BF07E70
		private static void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode) {} // 0x000000018BF08854-0x000000018BF08894
		private static IntPtr GetJobData_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF07D3C-0x000000018BF07D70
		private static DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF080BC-0x000000018BF080F0
		private static void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode) {} // 0x000000018BF087BC-0x000000018BF087FC
		private static object GetScriptInstance_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF07FBC-0x000000018BF07FF0
		private static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret) {
			ret = default;
		} // 0x00000001856D8000-0x00000001856D8060
		private static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight) {} // 0x00000001849AB1E0-0x00000001849AB240
		private static float GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index) => default; // 0x000000018BF07C30-0x000000018BF07C70
		private static void SetInputWeightFromIndexUncheck_Injected(ref PlayableHandle _unity_self, int index, float weight) {} // 0x000000018BF083E8-0x000000018BF08438
		private static int GetInputCountUncheck_Injected(ref PlayableHandle _unity_self) => default; // 0x000000018BF07BB0-0x000000018BF07BE4
		private static void SetTimeUncheck_Injected(ref PlayableHandle _unity_self, double value) {} // 0x000000018BF0871C-0x000000018BF08760
	}

	public struct PlayableOutput : IPlayableOutput, IEquatable<PlayableOutput> // TypeDefIndex: 48081
	{
		// Fields
		private PlayableOutputHandle m_Handle; // 0x00
		private static readonly PlayableOutput m_NullPlayableOutput; // 0x00
	
		// Properties
		public static PlayableOutput Null { get => default; } // 0x000000018BF08F18-0x000000018BF08F70 
	
		// Constructors
		internal PlayableOutput(PlayableOutputHandle handle) : this() {
			m_Handle = default;
		} // 0x0000000185FBFA60-0x0000000185FBFA70
		static PlayableOutput() {
			m_NullPlayableOutput = default;
		} // 0x0000000185F672D0-0x0000000185F67340
	
		// Methods
		public PlayableOutputHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public bool IsPlayableOutputOfType<T>()
			where T : struct, IPlayableOutput => default;
		public bool Equals(PlayableOutput other) => default; // 0x000000018BF08E8C-0x000000018BF08F18
	}

	public static class PlayableOutputExtensions // TypeDefIndex: 48082
	{
		// Methods
		public static bool IsOutputValid<U>(U output)
			where U : struct, IPlayableOutput => default;
		public static void SetReferenceObject<U>(U output, UnityEngine.Object value)
			where U : struct, IPlayableOutput {}
		public static UnityEngine.Object GetUserData<U>(U output)
			where U : struct, IPlayableOutput => default;
		public static Playable GetSourcePlayable<U>(U output)
			where U : struct, IPlayableOutput => default;
		public static void SetSourcePlayable<U, V>(U output, V value)
			where U : struct, IPlayableOutput
			where V : struct, IPlayable {}
		public static void SetSourcePlayable<U, V>(U output, V value, int port)
			where U : struct, IPlayableOutput
			where V : struct, IPlayable {}
		public static int GetSourceOutputPort<U>(U output)
			where U : struct, IPlayableOutput => default;
		public static void SetWeight<U>(U output, float value)
			where U : struct, IPlayableOutput {}
		public static void PushNotification<U>(U output, Playable origin, INotification notification, object context = null)
			where U : struct, IPlayableOutput {}
		public static void AddNotificationReceiver<U>(U output, INotificationReceiver receiver)
			where U : struct, IPlayableOutput {}
	}

	public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 48083
	{
		// Fields
		internal IntPtr m_Handle; // 0x00
		internal uint m_Version; // 0x08
		private static readonly PlayableOutputHandle m_Null; // 0x00
	
		// Properties
		public static PlayableOutputHandle Null { get => default; } // 0x0000000185F67340-0x0000000185F673A0 
	
		// Constructors
		static PlayableOutputHandle() {
			m_Null = default;
		} // 0x0000000185F9D130-0x0000000185F9D170
	
		// Methods
		internal bool IsPlayableOutputOfType<T>() => default;
		public override int GetHashCode() => default; // 0x0000000185FE87A0-0x0000000185FE87B0
		public static bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs) => default; // 0x000000018BF08E24-0x000000018BF08E8C
		public override bool Equals(object p) => default; // 0x000000018BF089F4-0x000000018BF08A78
		public bool Equals(PlayableOutputHandle other) => default; // 0x000000018BF08A78-0x000000018BF08AEC
		internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) => default; // 0x00000001835DAFD0-0x00000001835DAFF0
		internal bool IsValid() => default; // 0x0000000184D40830-0x0000000184D40880
		internal System.Type GetPlayableOutputType() => default; // 0x000000018533C520-0x000000018533C570
		internal void SetReferenceObject(UnityEngine.Object target) {} // 0x000000018BF08D28-0x000000018BF08D84
		internal UnityEngine.Object GetUserData() => default; // 0x000000018BF08BC0-0x000000018BF08C0C
		internal PlayableHandle GetSourcePlayable() => default; // 0x000000018BF08B30-0x000000018BF08B8C
		internal void SetSourcePlayable(PlayableHandle target, int port) {} // 0x00000001852A4EF0-0x00000001852A4F60
		internal int GetSourceOutputPort() => default; // 0x000000018548EEF0-0x000000018548EF40
		internal void SetWeight(float weight) {} // 0x000000018BF08DC8-0x000000018BF08E24
		internal void PushNotification(PlayableHandle origin, INotification notification, object context) {} // 0x000000018BF08C70-0x000000018BF08CE4
		internal void AddNotificationReceiver(INotificationReceiver receiver) {} // 0x000000018BF08998-0x000000018BF089F4
		private static bool IsValid_Injected(ref PlayableOutputHandle _unity_self) => default; // 0x0000000184D40880-0x0000000184D408C0
		private static System.Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self) => default; // 0x000000018533C570-0x000000018533C5B0
		private static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, UnityEngine.Object target) {} // 0x000000018BF08CE4-0x000000018BF08D28
		private static UnityEngine.Object GetUserData_Injected(ref PlayableOutputHandle _unity_self) => default; // 0x000000018BF08B8C-0x000000018BF08BC0
		private static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret) {
			ret = default;
		} // 0x000000018BF08AEC-0x000000018BF08B30
		private static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port) {} // 0x00000001852A4F60-0x00000001852A4FC0
		private static int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self) => default; // 0x000000018548EF40-0x000000018548EF80
		private static void SetWeight_Injected(ref PlayableOutputHandle _unity_self, float weight) {} // 0x000000018BF08D84-0x000000018BF08DC8
		private static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, object context) {} // 0x000000018BF08C0C-0x000000018BF08C70
		private static void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver) {} // 0x000000018BF08954-0x000000018BF08998
	}

	public struct ScriptPlayable<T> : IPlayable, IEquatable<ScriptPlayable<T>> // TypeDefIndex: 48084
		where T : class, IPlayableBehaviour, new()
	{
		// Fields
		private PlayableHandle m_Handle;
		private static readonly ScriptPlayable<T> m_NullPlayable;
	
		// Properties
		public static ScriptPlayable<T> Null { get => default; }
	
		// Constructors
		internal ScriptPlayable(PlayableHandle handle) : this() {
			m_Handle = default;
		}
		static ScriptPlayable() {
			m_NullPlayable = default;
		}
	
		// Methods
		public static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0 /* Metadata: 0x02060BD4 */) => default;
		public static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0 /* Metadata: 0x02060BD5 */) => default;
		private static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount) => default;
		private static object CreateScriptInstance() => default;
		private static object CloneScriptInstance(IPlayableBehaviour source) => default;
		private static object CloneScriptInstanceFromEngineObject(UnityEngine.Object source) => default;
		private static object CloneScriptInstanceFromIClonable(ICloneable source) => default;
		public PlayableHandle GetHandle() => default;
		public T GetBehaviour() => default;
		public static implicit operator Playable(ScriptPlayable<T> playable) => default;
		public static explicit operator ScriptPlayable<T>(Playable playable) => default;
		public bool Equals(ScriptPlayable<T> other) => default;
	}

	public static class ScriptPlayableBinding // TypeDefIndex: 48085
	{
		// Methods
		public static PlayableBinding Create(string name, UnityEngine.Object key, System.Type type) => default; // 0x000000018BF09C5C-0x000000018BF09D44
		private static PlayableOutput CreateScriptOutput(PlayableGraph graph, string name) => default; // 0x000000018BF09C20-0x000000018BF09C5C
	}

	public struct ScriptPlayableOutput : IPlayableOutput // TypeDefIndex: 48086
	{
		// Fields
		private PlayableOutputHandle m_Handle; // 0x00
	
		// Properties
		public static ScriptPlayableOutput Null { get => default; } // 0x000000018BF09E98-0x000000018BF09F10 
	
		// Constructors
		internal ScriptPlayableOutput(PlayableOutputHandle handle) : this() {
			m_Handle = default;
		} // 0x000000018BF09DC0-0x000000018BF09E98
	
		// Methods
		public static ScriptPlayableOutput Create(PlayableGraph graph, string name) => default; // 0x000000018BF09D44-0x000000018BF09DC0
		public PlayableOutputHandle GetHandle() => default; // 0x0000000185FCA260-0x0000000185FCA270
		public static implicit operator PlayableOutput(ScriptPlayableOutput output) => default; // 0x0000000185FE6690-0x0000000185FE66A0
	}
}

namespace UnityEngine.PlayerLoop
{
	public struct TimeUpdate // TypeDefIndex: 47758
	{
		// Nested types
		public struct WaitForLastPresentationAndUpdateTime // TypeDefIndex: 47757
		{
		}
	}

	public struct Initialization // TypeDefIndex: 47766
	{
		// Nested types
		public struct ProfilerStartFrame // TypeDefIndex: 47759
		{
		}
	
		public struct UpdateCameraMotionVectors // TypeDefIndex: 47760
		{
		}
	
		public struct DirectorSampleTime // TypeDefIndex: 47761
		{
		}
	
		public struct AsyncUploadTimeSlicedUpdate // TypeDefIndex: 47762
		{
		}
	
		public struct SynchronizeState // TypeDefIndex: 47763
		{
		}
	
		public struct SynchronizeInputs // TypeDefIndex: 47764
		{
		}
	
		public struct XREarlyUpdate // TypeDefIndex: 47765
		{
		}
	}

	public struct EarlyUpdate // TypeDefIndex: 47800
	{
		// Nested types
		public struct PollPlayerConnection // TypeDefIndex: 47767
		{
		}
	
		public struct PollHtcsPlayerConnection // TypeDefIndex: 47768
		{
		}
	
		public struct GpuTimestamp // TypeDefIndex: 47769
		{
		}
	
		public struct AnalyticsCoreStatsUpdate // TypeDefIndex: 47770
		{
		}
	
		public struct UnityWebRequestUpdate // TypeDefIndex: 47771
		{
		}
	
		public struct UpdateStreamingManager // TypeDefIndex: 47772
		{
		}
	
		public struct ExecuteMainThreadJobs // TypeDefIndex: 47773
		{
		}
	
		public struct ProcessMouseInWindow // TypeDefIndex: 47774
		{
		}
	
		public struct ClearIntermediateRenderers // TypeDefIndex: 47775
		{
		}
	
		public struct ClearLines // TypeDefIndex: 47776
		{
		}
	
		public struct PresentBeforeUpdate // TypeDefIndex: 47777
		{
		}
	
		public struct ResetFrameStatsAfterPresent // TypeDefIndex: 47778
		{
		}
	
		public struct UpdateAsyncReadbackManager // TypeDefIndex: 47779
		{
		}
	
		public struct UpdateTextureStreamingManager // TypeDefIndex: 47780
		{
		}
	
		public struct HGGlobalGameManagerEarlyUpdate // TypeDefIndex: 47781
		{
		}
	
		public struct UpdatePreloading // TypeDefIndex: 47782
		{
		}
	
		public struct UpdateAsyncInstantiate // TypeDefIndex: 47783
		{
		}
	
		public struct RendererNotifyInvisible // TypeDefIndex: 47784
		{
		}
	
		public struct PlayerCleanupCachedData // TypeDefIndex: 47785
		{
		}
	
		public struct UpdateMainGameViewRect // TypeDefIndex: 47786
		{
		}
	
		public struct UpdateCanvasRectTransform // TypeDefIndex: 47787
		{
		}
	
		public struct UpdateInputManager // TypeDefIndex: 47788
		{
		}
	
		public struct ProcessRemoteInput // TypeDefIndex: 47789
		{
		}
	
		public struct XRUpdate // TypeDefIndex: 47790
		{
		}
	
		public struct ScriptRunDelayedStartupFrame // TypeDefIndex: 47791
		{
		}
	
		public struct UpdateKinect // TypeDefIndex: 47792
		{
		}
	
		public struct DeliverIosPlatformEvents // TypeDefIndex: 47793
		{
		}
	
		public struct DispatchEventQueueEvents // TypeDefIndex: 47794
		{
		}
	
		public struct PhysicsResetInterpolatedTransformPosition // TypeDefIndex: 47795
		{
		}
	
		public struct SpriteAtlasManagerUpdate // TypeDefIndex: 47796
		{
		}
	
		public struct TangoUpdate // TypeDefIndex: 47797
		{
		}
	
		public struct ARCoreUpdate // TypeDefIndex: 47798
		{
		}
	
		public struct PerformanceAnalyticsUpdate // TypeDefIndex: 47799
		{
		}
	}

	public struct FixedUpdate // TypeDefIndex: 47814
	{
		// Nested types
		public struct ClearLines // TypeDefIndex: 47801
		{
		}
	
		public struct DirectorFixedSampleTime // TypeDefIndex: 47802
		{
		}
	
		public struct AudioFixedUpdate // TypeDefIndex: 47803
		{
		}
	
		public struct ScriptRunBehaviourFixedUpdate // TypeDefIndex: 47804
		{
		}
	
		public struct DirectorFixedUpdate // TypeDefIndex: 47805
		{
		}
	
		public struct LegacyFixedAnimationUpdate // TypeDefIndex: 47806
		{
		}
	
		public struct XRFixedUpdate // TypeDefIndex: 47807
		{
		}
	
		public struct PhysicsFixedUpdate // TypeDefIndex: 47808
		{
		}
	
		public struct Physics2DFixedUpdate // TypeDefIndex: 47809
		{
		}
	
		private struct PhysicsClothFixedUpdate // TypeDefIndex: 47810
		{
		}
	
		public struct DirectorFixedUpdatePostPhysics // TypeDefIndex: 47811
		{
		}
	
		public struct ScriptRunDelayedFixedFrameRate // TypeDefIndex: 47812
		{
		}
	
		public struct NewInputFixedUpdate // TypeDefIndex: 47813
		{
		}
	}

	public struct PreUpdate // TypeDefIndex: 47826
	{
		// Nested types
		public struct PhysicsUpdate // TypeDefIndex: 47815
		{
		}
	
		public struct Physics2DUpdate // TypeDefIndex: 47816
		{
		}
	
		public struct HGGlobalGameManagerPreGameplayUpdate // TypeDefIndex: 47817
		{
		}
	
		public struct CheckTexFieldInput // TypeDefIndex: 47818
		{
		}
	
		public struct IMGUISendQueuedEvents // TypeDefIndex: 47819
		{
		}
	
		public struct SendMouseEvents // TypeDefIndex: 47820
		{
		}
	
		public struct AIUpdate // TypeDefIndex: 47821
		{
		}
	
		public struct WindUpdate // TypeDefIndex: 47822
		{
		}
	
		public struct UpdateVideo // TypeDefIndex: 47823
		{
		}
	
		public struct NewInputUpdate // TypeDefIndex: 47824
		{
		}
	
		public struct DirectorPreUpdate // TypeDefIndex: 47825
		{
		}
	}

	public struct Update // TypeDefIndex: 47832
	{
		// Nested types
		public struct ScriptRunBehaviourUpdate // TypeDefIndex: 47827
		{
		}
	
		public struct HGGlobalGameManagerGameplayUpdate // TypeDefIndex: 47828
		{
		}
	
		public struct DirectorUpdate // TypeDefIndex: 47829
		{
		}
	
		public struct ScriptRunDelayedDynamicFrameRate // TypeDefIndex: 47830
		{
		}
	
		public struct ScriptRunDelayedTasks // TypeDefIndex: 47831
		{
		}
	}

	public struct PreLateUpdate // TypeDefIndex: 47849
	{
		// Nested types
		public struct HGGlobalGameManagerPreLateUpdate // TypeDefIndex: 47833
		{
		}
	
		public struct Physics2DLateUpdate // TypeDefIndex: 47834
		{
		}
	
		public struct AIUpdatePostScript // TypeDefIndex: 47835
		{
		}
	
		public struct DirectorUpdateAnimationBegin // TypeDefIndex: 47836
		{
		}
	
		public struct LegacyAnimationUpdate // TypeDefIndex: 47837
		{
		}
	
		public struct DirectorUpdateAnimationEnd // TypeDefIndex: 47838
		{
		}
	
		public struct DirectorDeferredEvaluate // TypeDefIndex: 47839
		{
		}
	
		public struct UIElementsUpdatePanels // TypeDefIndex: 47840
		{
		}
	
		public struct UpdateNetworkManager // TypeDefIndex: 47841
		{
		}
	
		public struct UpdateMasterServerInterface // TypeDefIndex: 47842
		{
		}
	
		public struct UNetUpdate // TypeDefIndex: 47843
		{
		}
	
		public struct EndGraphicsJobsAfterScriptUpdate // TypeDefIndex: 47844
		{
		}
	
		public struct ParticleSystemBeginUpdateAll // TypeDefIndex: 47845
		{
		}
	
		public struct ScriptRunBehaviourLateUpdate // TypeDefIndex: 47846
		{
		}
	
		public struct UIAtlasManagerUpdate // TypeDefIndex: 47847
		{
		}
	
		public struct ConstraintManagerUpdate // TypeDefIndex: 47848
		{
		}
	}

	public struct PostLateUpdate // TypeDefIndex: 47904
	{
		// Nested types
		public struct PlayerSendFrameStarted // TypeDefIndex: 47850
		{
		}
	
		public struct UpdateRectTransform // TypeDefIndex: 47851
		{
		}
	
		public struct UpdateCanvasRectTransform // TypeDefIndex: 47852
		{
		}
	
		public struct PlayerUpdateCanvases // TypeDefIndex: 47853
		{
		}
	
		public struct UpdateAudio // TypeDefIndex: 47854
		{
		}
	
		public struct UpdateVideo // TypeDefIndex: 47855
		{
		}
	
		public struct DirectorLateUpdate // TypeDefIndex: 47856
		{
		}
	
		public struct ScriptRunDelayedDynamicFrameRate // TypeDefIndex: 47857
		{
		}
	
		public struct VFXUpdate // TypeDefIndex: 47858
		{
		}
	
		public struct ParticleSystemEndUpdateAll // TypeDefIndex: 47859
		{
		}
	
		public struct EndGraphicsJobsAfterScriptLateUpdate // TypeDefIndex: 47860
		{
		}
	
		public struct UpdateSubstance // TypeDefIndex: 47861
		{
		}
	
		public struct UpdateCustomRenderTextures // TypeDefIndex: 47862
		{
		}
	
		public struct XRPostLateUpdate // TypeDefIndex: 47863
		{
		}
	
		public struct UpdateAllRenderers // TypeDefIndex: 47864
		{
		}
	
		public struct HGGlobalGameManagerLateUpdate // TypeDefIndex: 47865
		{
		}
	
		public struct HGGlobalGameManagerPostLateUpdate // TypeDefIndex: 47866
		{
		}
	
		public struct HGGlobalGameManagerPipelineUpdate // TypeDefIndex: 47867
		{
		}
	
		public struct HGGlobalGameManagerUpdateAfterTransformSyncToEcs // TypeDefIndex: 47868
		{
		}
	
		public struct UpdateLightProbeProxyVolumes // TypeDefIndex: 47869
		{
		}
	
		public struct EnlightenRuntimeUpdate // TypeDefIndex: 47870
		{
		}
	
		public struct UpdateAllSkinnedMeshes // TypeDefIndex: 47871
		{
		}
	
		public struct ProcessWebSendMessages // TypeDefIndex: 47872
		{
		}
	
		public struct SortingGroupsUpdate // TypeDefIndex: 47873
		{
		}
	
		public struct UpdateVideoTextures // TypeDefIndex: 47874
		{
		}
	
		public struct DirectorRenderImage // TypeDefIndex: 47875
		{
		}
	
		public struct PlayerEmitCanvasGeometry // TypeDefIndex: 47876
		{
		}
	
		internal struct PlayerRenderUIEBatchModeOffscreen // TypeDefIndex: 47877
		{
		}
	
		public struct FinishFrameRendering // TypeDefIndex: 47878
		{
		}
	
		public struct BatchModeUpdate // TypeDefIndex: 47879
		{
		}
	
		public struct PlayerSendFrameComplete // TypeDefIndex: 47880
		{
		}
	
		public struct UpdateCaptureScreenshot // TypeDefIndex: 47881
		{
		}
	
		public struct PresentAfterDraw // TypeDefIndex: 47882
		{
		}
	
		public struct ClearImmediateRenderers // TypeDefIndex: 47883
		{
		}
	
		public struct XRPostPresent // TypeDefIndex: 47884
		{
		}
	
		public struct UpdateResolution // TypeDefIndex: 47885
		{
		}
	
		public struct InputEndFrame // TypeDefIndex: 47886
		{
		}
	
		public struct GUIClearEvents // TypeDefIndex: 47887
		{
		}
	
		public struct ShaderHandleErrors // TypeDefIndex: 47888
		{
		}
	
		public struct ResetInputAxis // TypeDefIndex: 47889
		{
		}
	
		public struct ThreadedLoadingDebug // TypeDefIndex: 47890
		{
		}
	
		public struct ProfilerSynchronizeStats // TypeDefIndex: 47891
		{
		}
	
		public struct MemoryFrameMaintenance // TypeDefIndex: 47892
		{
		}
	
		public struct ExecuteGameCenterCallbacks // TypeDefIndex: 47893
		{
		}
	
		public struct XRPreEndFrame // TypeDefIndex: 47894
		{
		}
	
		public struct ProfilerEndFrame // TypeDefIndex: 47895
		{
		}
	
		public struct GraphicsWarmupPreloadedShaders // TypeDefIndex: 47896
		{
		}
	
		public struct PlayerSendFramePostPresent // TypeDefIndex: 47897
		{
		}
	
		public struct PhysicsSkinnedClothBeginUpdate // TypeDefIndex: 47898
		{
		}
	
		public struct PhysicsSkinnedClothFinishUpdate // TypeDefIndex: 47899
		{
		}
	
		public struct DirectorManagerNextFrameEnd // TypeDefIndex: 47900
		{
		}
	
		public struct TriggerEndOfFrameCallbacks // TypeDefIndex: 47901
		{
		}
	
		public struct WaitForLastPresentationAndUpdateTimeAfterFrame // TypeDefIndex: 47902
		{
		}
	
		internal struct HGGlobalGameManagerPreParticleUpdate // TypeDefIndex: 47903
		{
		}
	}
}

namespace UnityEngine.Pool
{
	public class CollectionPool<TCollection, TItem> // TypeDefIndex: 47906
		where TCollection : class, ICollection<TItem>, new()
	{
		// Fields
		internal static readonly ObjectPool<TCollection> s_Pool;
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 47905
		{
			// Fields
			public static readonly __c<TCollection, TItem> __9;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal TCollection _.cctor_b__5_0() => default;
			internal void _.cctor_b__5_1(TCollection l) {}
		}
	
		// Constructors
		public CollectionPool() {} // Dummy constructor
		static CollectionPool() {}
	
		// Methods
		public static TCollection Get() => default;
		public static PooledObject<TCollection> Get(out ref TCollection value) {
			value = default;
			return default;
		}
		public static void Release(TCollection toRelease) {}
	}

	public interface IObjectPool<T> // TypeDefIndex: 47907
		where T : class
	{
		// Methods
		void Release(T element);
	}

	public class ObjectPool<T> : IDisposable, IObjectPool<T> // TypeDefIndex: 47908
		where T : class
	{
		// Fields
		internal readonly List<T> m_List;
		private readonly Func<T> m_CreateFunc;
		private readonly Action<T> m_ActionOnGet;
		private readonly Action<T> m_ActionOnRelease;
		private readonly Action<T> m_ActionOnDestroy;
		private readonly int m_MaxSize;
		internal bool m_CollectionCheck;
		private int _CountAll_k__BackingField;
	
		// Properties
		public int CountAll { get; private set; }
		public int CountInactive { get => default; }
	
		// Constructors
		public ObjectPool() {} // Dummy constructor
		public ObjectPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true /* Metadata: 0x020609BD */, int defaultCapacity = 10 /* Metadata: 0x020609BE */, int maxSize = 10000 /* Metadata: 0x020609BF */) {}
	
		// Methods
		public T Get() => default;
		public PooledObject<T> Get(out ref T v) {
			v = default;
			return default;
		}
		public void Release(T element) {}
		public void Clear() {}
		public void Dispose() {}
	}

	public struct PooledObject<T> : IDisposable // TypeDefIndex: 47909
		where T : class
	{
		// Fields
		private readonly T m_ToReturn;
		private readonly IObjectPool<T> m_Pool;
	
		// Constructors
		internal PooledObject(T value, IObjectPool<T> pool) {
			m_ToReturn = default;
			m_Pool = default;
		}
	
		// Methods
		void IDisposable.Dispose() {}
	}
}

namespace UnityEngine.Profiling
{
	public enum ProfilingHGPass // TypeDefIndex: 47657
	{
		None = 0,
		PreDepth = 1,
		GBuffer = 2,
		Shadow = 3,
		ForwardOpaque = 4,
		ForwardTransparent = 5,
		Distortion = 6
	}

	public sealed class Profiler // TypeDefIndex: 47658
	{
		// Properties
		public static bool supported { get => default; } // 0x000000018BEEBA30-0x000000018BEEBA5C 
		public static bool enabled { get => default; set {} } // 0x000000018BEEBA04-0x000000018BEEBA30 0x000000018BEEBA5C-0x000000018BEEBA90
	
		// Constructors
		public Profiler() {} // Dummy constructor
	
		// Methods
		public static long GetRuntimeMemorySizeLong(UnityEngine.Object o) => default; // 0x000000018BEEB98C-0x000000018BEEB9C0
		public static long GetMonoHeapSizeLong() => default; // 0x0000000184BDAF70-0x0000000184BDAFB0
		public static long GetMonoUsedSizeLong() => default; // 0x0000000185F8BFC0-0x0000000185F8C000
		public static long GetTotalAllocatedMemoryLong() => default; // 0x0000000185F8BF80-0x0000000185F8BFC0
		public static long GetTotalReservedMemoryLong() => default; // 0x0000000185F8BF40-0x0000000185F8BF80
		public static void ReleaseMonoSnapShot(string filePath, bool bCompress = true /* Metadata: 0x02060981 */) {} // 0x000000018BEEB9C0-0x000000018BEEBA04
	}

	public sealed class HGSingleFrameProfiler // TypeDefIndex: 47660
	{
		// Fields
		public static FinishFrameCallback finishFrameCallback; // 0x00
	
		// Nested types
		public delegate void FinishFrameCallback(double frameTimeMS, bool overflow, IntPtr frameDataPtr, int size); // TypeDefIndex: 47659; 0x000000018BEE7F90-0x000000018BEE8058
	
		// Constructors
		public HGSingleFrameProfiler() {} // Dummy constructor
	
		// Methods
		private static void CallFinishFrameCallback(double frameTimeMS, bool overflow, IntPtr frameDataPtr, int size) {} // 0x000000018A1D6C08-0x000000018A1D6C1C
	}

	public sealed class Recorder // TypeDefIndex: 47661
	{
		// Fields
		private const ProfilerRecorderOptions s_RecorderDefaultOptions = (ProfilerRecorderOptions) 153; // Metadata: 0x02060982
		internal static Recorder s_InvalidRecorder; // 0x00
		private ProfilerRecorder m_RecorderCPU; // 0x10
		private ProfilerRecorder m_RecorderGPU; // 0x18
	
		// Properties
		public bool enabled { get => default; set {} } // 0x000000018BEEBAC0-0x000000018BEEBAD0 0x0000000186471DAC-0x0000000186471DB4
		public long elapsedNanoseconds { get => default; } // 0x000000018BEEBA90-0x000000018BEEBAC0 
		public long gpuElapsedNanoseconds { get => default; } // 0x000000018BEEBAD0-0x000000018BEEBB00 
		public int sampleBlockCount { get => default; } // 0x000000018BEEBB5C-0x000000018BEEBBB8 
		public int gpuSampleBlockCount { get => default; } // 0x000000018BEEBB00-0x000000018BEEBB5C 
	
		// Constructors
		internal Recorder() {} // 0x0000000185492010-0x0000000185492020
		internal Recorder(ProfilerRecorderHandle handle) {} // 0x0000000184B30E00-0x0000000184B30E80
		static Recorder() {} // 0x0000000185F79C90-0x0000000185F79CF0
	
		// Methods
		~Recorder() {} // 0x0000000185225AB0-0x0000000185225BB0
		private void SetEnabled(bool state) {} // 0x0000000185225BF0-0x0000000185225C40
	}

	public class Sampler // TypeDefIndex: 47662
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		internal static Sampler s_InvalidSampler; // 0x00
	
		// Properties
		public bool isValid { get => default; } // 0x000000018BEEC7C0-0x000000018BEEC7CC 
	
		// Constructors
		internal Sampler() {} // 0x0000000185492010-0x0000000185492020
		static Sampler() {} // 0x0000000185F798D0-0x0000000185F79930
	
		// Methods
		public Recorder GetRecorder() => default; // 0x0000000184B30C20-0x0000000184B30C90
	}

	public sealed class CustomSampler : Sampler // TypeDefIndex: 47663
	{
		// Fields
		internal static CustomSampler s_InvalidCustomSampler; // 0x00
	
		// Constructors
		internal CustomSampler() {} // 0x0000000185F36E50-0x0000000185F36F00
		internal CustomSampler(IntPtr ptr) {} // 0x0000000184B30DA0-0x0000000184B30E00
		static CustomSampler() {} // 0x0000000185F36DE0-0x0000000185F36E50
	
		// Methods
		public static CustomSampler Create(string name, bool collectGpuData = false /* Metadata: 0x02060984 */) => default; // 0x0000000184B30C90-0x0000000184B30D30
	}
}

namespace UnityEngine.Profiling.Experimental
{
	public struct DebugScreenCapture // TypeDefIndex: 47664
	{
		// Fields
		private NativeArray<byte> _rawImageDataReference_k__BackingField; // 0x00
		private TextureFormat _imageFormat_k__BackingField; // 0x10
		private int _width_k__BackingField; // 0x14
		private int _height_k__BackingField; // 0x18
	
		// Properties
		public NativeArray<byte> rawImageDataReference { get; set; } // 0x0000000185FBFA60-0x0000000185FBFA70
		public TextureFormat imageFormat { get; set; } // 0x0000000181378230-0x0000000181378240
		public int width { get; set; } // 0x0000000185FBB0B0-0x0000000185FBB0C0
		public int height { get; set; } // 0x00000001813AE9C0-0x00000001813AE9D0
	}
}

namespace UnityEngine.Profiling.Memory.Experimental
{
	public class MetaData // TypeDefIndex: 47665
	{
		// Fields
		[NonSerialized]
		public string content; // 0x10
		[NonSerialized]
		public string platform; // 0x18
	
		// Constructors
		public MetaData() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class MemoryProfiler // TypeDefIndex: 47666
	{
		// Fields
		private static Action<string, bool> m_SnapshotFinished; // 0x00
		private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x08
		private static Action<MetaData> createMetaData; // 0x10
	
		// Constructors
		public MemoryProfiler() {} // Dummy constructor
	
		// Methods
		private static byte[] PrepareMetadata() => default; // 0x000000018BEE94FC-0x000000018BEE9680
		internal static int WriteIntToByteArray(byte[] array, int offset, int value) => default; // 0x000000018BEE9798-0x000000018BEE980C
		internal static int WriteStringToByteArray(byte[] array, int offset, string value) => default; // 0x000000018BEE980C-0x000000018BEE9874
		private static void FinalizeSnapshot(string path, bool result) {} // 0x000000018BEE9484-0x000000018BEE94FC
		private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) {} // 0x000000018BEE9680-0x000000018BEE9798
	}
}

namespace UnityEngine.Rendering
{
	public struct AsyncGPUReadbackRequest // TypeDefIndex: 47933
	{
		// Fields
		internal IntPtr m_Ptr; // 0x00
		internal int m_Version; // 0x08
	
		// Properties
		public bool done { get => default; } // 0x000000018BEF2F6C-0x000000018BEF2F78 
		public bool hasError { get => default; } // 0x000000018BEF2F78-0x000000018BEF2F84 
		public int layerCount { get => default; } // 0x000000018BEF2F84-0x000000018BEF2F90 
		public int layerDataSize { get => default; } // 0x000000018BEF2F90-0x000000018BEF2F9C 
	
		// Methods
		public void WaitForCompletion() {} // 0x000000018BEF2F64-0x000000018BEF2F6C
		public NativeArray<T> GetData<T>(int layer = 0 /* Metadata: 0x020609E2 */)
			where T : struct => default;
		private bool IsDone() => default; // 0x000000018BEF2EDC-0x000000018BEF2EE4
		private bool HasError() => default; // 0x000000018BEF2EA0-0x000000018BEF2EA8
		private int GetLayerCount() => default; // 0x000000018BEF2E28-0x000000018BEF2E30
		private int GetLayerDataSize() => default; // 0x000000018BEF2E64-0x000000018BEF2E6C
		internal void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback) {} // 0x000000018BEF2F28-0x000000018BEF2F30
		private IntPtr GetDataRaw(int layer) => default; // 0x000000018BEF2DEC-0x000000018BEF2DF4
		private static void WaitForCompletion_Injected(ref AsyncGPUReadbackRequest _unity_self) {} // 0x000000018BEF2F30-0x000000018BEF2F64
		private static bool IsDone_Injected(ref AsyncGPUReadbackRequest _unity_self) => default; // 0x000000018BEF2EA8-0x000000018BEF2EDC
		private static bool HasError_Injected(ref AsyncGPUReadbackRequest _unity_self) => default; // 0x000000018BEF2E6C-0x000000018BEF2EA0
		private static int GetLayerCount_Injected(ref AsyncGPUReadbackRequest _unity_self) => default; // 0x000000018BEF2DF4-0x000000018BEF2E28
		private static int GetLayerDataSize_Injected(ref AsyncGPUReadbackRequest _unity_self) => default; // 0x000000018BEF2E30-0x000000018BEF2E64
		private static void SetScriptingCallback_Injected(ref AsyncGPUReadbackRequest _unity_self, Action<AsyncGPUReadbackRequest> callback) {} // 0x000000018BEF2EE4-0x000000018BEF2F28
		private static IntPtr GetDataRaw_Injected(ref AsyncGPUReadbackRequest _unity_self, int layer) => default; // 0x000000018BEF2DAC-0x000000018BEF2DEC
	}

	internal struct AsyncRequestNativeArrayData // TypeDefIndex: 47934
	{
		// Fields
		public unsafe void* nativeArrayBuffer; // 0x00
		public long lengthInBytes; // 0x08
	
		// Methods
		public static AsyncRequestNativeArrayData CreateAndCheckAccess<T>(NativeArray<T> array)
			where T : struct => default;
	}

	public static class AsyncGPUReadback // TypeDefIndex: 47935
	{
		// Methods
		internal static void ValidateFormat(Texture src, GraphicsFormat dstformat) {} // 0x000000018BEF3274-0x000000018BEF3330
		public static AsyncGPUReadbackRequest Request(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback = null) => default; // 0x000000018BEF3214-0x000000018BEF3274
		public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) => default; // 0x000000018BEF3160-0x000000018BEF3214
		public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback = null) => default; // 0x000000018BEF30C4-0x000000018BEF3160
		public static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback = null)
			where T : struct => default;
		private static unsafe AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_1(ComputeBuffer buffer, AsyncRequestNativeArrayData* data) => default; // 0x000000018BEF2FF0-0x000000018BEF3020
		private static unsafe AsyncGPUReadbackRequest Request_Internal_Texture_2(Texture src, int mipIndex, GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data) => default; // 0x000000018BEF3080-0x000000018BEF30C4
		private static unsafe void Request_Internal_ComputeBuffer_1_Injected(ComputeBuffer buffer, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret) {
			ret = default;
		} // 0x000000018BEF2F9C-0x000000018BEF2FF0
		private static unsafe void Request_Internal_Texture_2_Injected(Texture src, int mipIndex, GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret) {
			ret = default;
		} // 0x000000018BEF3020-0x000000018BEF3080
	}

	public enum SynchronisationStage // TypeDefIndex: 47936
	{
		VertexProcessing = 0,
		PixelProcessing = 1
	}

	public enum IndexFormat // TypeDefIndex: 47937
	{
		UInt16 = 0,
		UInt32 = 1
	}

	public enum MeshUpdateFlags // TypeDefIndex: 47938
	{
		Default = 0,
		DontValidateIndices = 1,
		DontResetBoneBounds = 2,
		DontNotifyMeshUsers = 4,
		DontRecalculateBounds = 8
	}

	public enum VertexAttributeFormat // TypeDefIndex: 47939
	{
		Float32 = 0,
		Float16 = 1,
		UNorm8 = 2,
		SNorm8 = 3,
		UNorm16 = 4,
		SNorm16 = 5,
		UInt8 = 6,
		SInt8 = 7,
		UInt16 = 8,
		SInt16 = 9,
		UInt32 = 10,
		SInt32 = 11
	}

	public enum VertexAttribute // TypeDefIndex: 47940
	{
		Position = 0,
		Normal = 1,
		Tangent = 2,
		Color = 3,
		TexCoord0 = 4,
		TexCoord1 = 5,
		TexCoord2 = 6,
		TexCoord3 = 7,
		TexCoord4 = 8,
		TexCoord5 = 9,
		TexCoord6 = 10,
		TexCoord7 = 11,
		BlendWeight = 12,
		BlendIndices = 13
	}

	public enum OpaqueSortMode // TypeDefIndex: 47941
	{
		Default = 0,
		FrontToBack = 1,
		NoDistanceSort = 2
	}

	public enum RenderBufferLoadAction // TypeDefIndex: 47942
	{
		Load = 0,
		Clear = 1,
		DontCare = 2
	}

	public enum RenderBufferStoreAction // TypeDefIndex: 47943
	{
		Store = 0,
		Resolve = 1,
		StoreAndResolve = 2,
		DontCare = 3
	}

	public enum FastMemoryFlags // TypeDefIndex: 47944
	{
		None = 0,
		SpillTop = 1,
		SpillBottom = 2
	}

	public enum BlendMode // TypeDefIndex: 47945
	{
		Zero = 0,
		One = 1,
		DstColor = 2,
		SrcColor = 3,
		OneMinusDstColor = 4,
		SrcAlpha = 5,
		OneMinusSrcColor = 6,
		DstAlpha = 7,
		OneMinusDstAlpha = 8,
		SrcAlphaSaturate = 9,
		OneMinusSrcAlpha = 10
	}

	public enum CompareFunction // TypeDefIndex: 47946
	{
		Disabled = 0,
		Never = 1,
		Less = 2,
		Equal = 3,
		LessEqual = 4,
		Greater = 5,
		NotEqual = 6,
		GreaterEqual = 7,
		Always = 8
	}

	public enum CullMode // TypeDefIndex: 47947
	{
		Off = 0,
		Front = 1,
		Back = 2
	}

	public enum ColorWriteMask // TypeDefIndex: 47948
	{
		Alpha = 1,
		Blue = 2,
		Green = 4,
		Red = 8,
		All = 15
	}

	public enum StencilOp // TypeDefIndex: 47949
	{
		Keep = 0,
		Zero = 1,
		Replace = 2,
		IncrementSaturate = 3,
		DecrementSaturate = 4,
		Invert = 5,
		IncrementWrap = 6,
		DecrementWrap = 7
	}

	public enum AmbientMode // TypeDefIndex: 47950
	{
		Skybox = 0,
		Trilight = 1,
		Flat = 3,
		Custom = 4
	}

	public enum DefaultReflectionMode // TypeDefIndex: 47951
	{
		Skybox = 0,
		Custom = 1
	}

	public enum CameraEvent // TypeDefIndex: 47952
	{
		BeforeDepthTexture = 0,
		AfterDepthTexture = 1,
		BeforeDepthNormalsTexture = 2,
		AfterDepthNormalsTexture = 3,
		BeforeGBuffer = 4,
		AfterGBuffer = 5,
		BeforeLighting = 6,
		AfterLighting = 7,
		BeforeFinalPass = 8,
		AfterFinalPass = 9,
		BeforeForwardOpaque = 10,
		AfterForwardOpaque = 11,
		BeforeImageEffectsOpaque = 12,
		AfterImageEffectsOpaque = 13,
		BeforeSkybox = 14,
		AfterSkybox = 15,
		BeforeForwardAlpha = 16,
		AfterForwardAlpha = 17,
		BeforeImageEffects = 18,
		AfterImageEffects = 19,
		AfterEverything = 20,
		BeforeReflections = 21,
		AfterReflections = 22,
		BeforeHaloAndLensFlares = 23,
		AfterHaloAndLensFlares = 24
	}

	internal static class CameraEventUtils // TypeDefIndex: 47953
	{
		// Methods
		public static bool IsValid(CameraEvent value) => default; // 0x000000018BEF3C8C-0x000000018BEF3C9C
	}

	public enum LightEvent // TypeDefIndex: 47954
	{
		BeforeShadowMap = 0,
		AfterShadowMap = 1,
		BeforeScreenspaceMask = 2,
		AfterScreenspaceMask = 3,
		BeforeShadowMapPass = 4,
		AfterShadowMapPass = 5
	}

	public enum ShadowMapPass // TypeDefIndex: 47955
	{
		PointlightPositiveX = 1,
		PointlightNegativeX = 2,
		PointlightPositiveY = 4,
		PointlightNegativeY = 8,
		PointlightPositiveZ = 16,
		PointlightNegativeZ = 32,
		Pointlight = 63,
		DirectionalCascade0 = 64,
		DirectionalCascade1 = 128,
		DirectionalCascade2 = 256,
		DirectionalCascade3 = 512,
		Directional = 960,
		Spotlight = 1024,
		All = 2047
	}

	public enum BuiltinRenderTextureType // TypeDefIndex: 47956
	{
		PropertyName = -4,
		BufferPtr = -3,
		RenderTexture = -2,
		BindableTexture = -1,
		None = 0,
		CurrentActive = 1,
		CameraTarget = 2,
		Depth = 3,
		DepthNormals = 4,
		ResolvedDepth = 5,
		PrepassNormalsSpec = 7,
		PrepassLight = 8,
		PrepassLightSpec = 9,
		GBuffer0 = 10,
		GBuffer1 = 11,
		GBuffer2 = 12,
		GBuffer3 = 13,
		Reflections = 14,
		MotionVectors = 15,
		GBuffer4 = 16,
		GBuffer5 = 17,
		GBuffer6 = 18,
		GBuffer7 = 19
	}

	public enum ShadowCastingMode // TypeDefIndex: 47957
	{
		Off = 0,
		On = 1,
		TwoSided = 2,
		ShadowsOnly = 3,
		ShadowsOnlyTwoSided = 4
	}

	public enum LightShadowResolution // TypeDefIndex: 47958
	{
		FromQualitySettings = -1,
		Low = 0,
		Medium = 1,
		High = 2,
		VeryHigh = 3
	}

	public enum SubMeshRenderMode // TypeDefIndex: 47959
	{
		SubMeshRenderModeDefault = 0,
		SubMeshRenderModeLoop = 1
	}

	public enum GraphicsDeviceType // TypeDefIndex: 47960
	{
		GameCoreScarlett = -1,
		OpenGL2 = 0,
		Direct3D9 = 1,
		Direct3D11 = 2,
		PlayStation3 = 3,
		Null = 4,
		Xbox360 = 6,
		OpenGLES2 = 8,
		OpenGLES3 = 11,
		PlayStationVita = 12,
		PlayStation4 = 13,
		XboxOne = 14,
		PlayStationMobile = 15,
		Metal = 16,
		OpenGLCore = 17,
		Direct3D12 = 18,
		N3DS = 19,
		Vulkan = 21,
		Switch = 22,
		XboxOneD3D12 = 23,
		GameCoreXboxOne = 24,
		GameCoreXboxSeries = 25,
		PlayStation5 = 26,
		PlayStation5NGGC = 27
	}

	public enum GraphicsTier // TypeDefIndex: 47961
	{
		Tier1 = 0,
		Tier2 = 1,
		Tier3 = 2
	}

	public struct SubMeshDescriptor // TypeDefIndex: 47962
	{
		// Fields
		private Bounds _bounds_k__BackingField; // 0x00
		private MeshTopology _topology_k__BackingField; // 0x18
		private int _indexStart_k__BackingField; // 0x1C
		private int _indexCount_k__BackingField; // 0x20
		private int _baseVertex_k__BackingField; // 0x24
		private int _firstVertex_k__BackingField; // 0x28
		private int _vertexCount_k__BackingField; // 0x2C
	
		// Properties
		public Bounds bounds { get; } // 0x0000000185FBFEC0-0x0000000185FBFEE0 
		public MeshTopology topology { get; } // 0x00000001813AE560-0x00000001813AE570 
		public int indexStart { get; } // 0x00000001813AE570-0x00000001813AE580 
		public int indexCount { get; } // 0x00000001813B88B0-0x00000001813B88C0 
		public int baseVertex { get; } // 0x0000000181424480-0x0000000181424490 
		public int firstVertex { get; } // 0x0000000181C9AC80-0x0000000181C9AC90 
		public int vertexCount { get; } // 0x0000000185FB0630-0x0000000185FB0640 
	
		// Methods
		public override string ToString() => default; // 0x000000018BF0435C-0x000000018BF0457C
	}

	public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor> // TypeDefIndex: 47963
	{
		// Fields
		private VertexAttribute _attribute_k__BackingField; // 0x00
		private VertexAttributeFormat _format_k__BackingField; // 0x04
		private int _dimension_k__BackingField; // 0x08
		private int _stream_k__BackingField; // 0x0C
	
		// Properties
		public VertexAttribute attribute { get; set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public VertexAttributeFormat format { get; set; } // 0x000000018357CBC0-0x000000018357CBD0 0x0000000185FB2BA0-0x0000000185FB2BB0
		public int dimension { get; set; } // 0x0000000181B7E450-0x0000000181B7E460 0x0000000185FB2B90-0x0000000185FB2BA0
		public int stream { get; set; } // 0x00000001834AFB70-0x00000001834AFB80 0x0000000185FB6960-0x0000000185FB6970
	
		// Constructors
		public VertexAttributeDescriptor(VertexAttribute attribute = VertexAttribute.Position /* Metadata: 0x02060AAF */, VertexAttributeFormat format = VertexAttributeFormat.Float32 /* Metadata: 0x02060AB0 */, int dimension = 3 /* Metadata: 0x02060AB1 */, int stream = 0 /* Metadata: 0x02060AB2 */) : this() {
			<attribute>k__BackingField = default;
			<format>k__BackingField = default;
			<dimension>k__BackingField = default;
			<stream>k__BackingField = default;
		} // 0x0000000185FB2C50-0x0000000185FB2C70
	
		// Methods
		public override string ToString() => default; // 0x000000018BF04640-0x000000018BF047B4
		public override int GetHashCode() => default; // 0x0000000185FE8710-0x0000000185FE8730
		public override bool Equals(object other) => default; // 0x000000018BF045C8-0x000000018BF04640
		public bool Equals(VertexAttributeDescriptor other) => default; // 0x0000000187841394-0x00000001878413B8
	}

	public enum FormatSwizzle // TypeDefIndex: 47964
	{
		FormatSwizzleR = 0,
		FormatSwizzleG = 1,
		FormatSwizzleB = 2,
		FormatSwizzleA = 3,
		FormatSwizzle0 = 4,
		FormatSwizzle1 = 5
	}

	public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier> // TypeDefIndex: 47965
	{
		// Fields
		public const int AllDepthSlices = -1; // Metadata: 0x02060AC1
		private BuiltinRenderTextureType m_Type; // 0x00
		private int m_NameID; // 0x04
		private int m_InstanceID; // 0x08
		private IntPtr m_BufferPointer; // 0x10
		private int m_MipLevel; // 0x18
		private CubemapFace m_CubeFace; // 0x1C
		private int m_DepthSlice; // 0x20
	
		// Constructors
		public RenderTargetIdentifier(BuiltinRenderTextureType type) {
			m_Type = default;
			m_NameID = default;
			m_InstanceID = default;
			m_BufferPointer = default;
			m_MipLevel = default;
			m_CubeFace = default;
			m_DepthSlice = default;
		} // 0x0000000185FE7E40-0x0000000185FE7E60
		public RenderTargetIdentifier(int nameID) {
			m_Type = default;
			m_NameID = default;
			m_InstanceID = default;
			m_BufferPointer = default;
			m_MipLevel = default;
			m_CubeFace = default;
			m_DepthSlice = default;
		} // 0x0000000185FE7DC0-0x0000000185FE7DE0
		public RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = CubemapFace.Unknown /* Metadata: 0x02060AB9 */, int depthSlice = 0 /* Metadata: 0x02060ABA */) {
			m_Type = default;
			m_NameID = default;
			m_InstanceID = default;
			m_BufferPointer = default;
			m_MipLevel = default;
			m_CubeFace = default;
			m_DepthSlice = default;
		} // 0x0000000185FE7E10-0x0000000185FE7E40
		public RenderTargetIdentifier(Texture tex) {
			m_Type = default;
			m_NameID = default;
			m_InstanceID = default;
			m_BufferPointer = default;
			m_MipLevel = default;
			m_CubeFace = default;
			m_DepthSlice = default;
		} // 0x0000000183FDB3C0-0x0000000183FDB4C0
		public RenderTargetIdentifier(Texture tex, int mipLevel = 0 /* Metadata: 0x02060ABB */, CubemapFace cubeFace = CubemapFace.Unknown /* Metadata: 0x02060ABC */, int depthSlice = 0 /* Metadata: 0x02060ABD */) {
			m_Type = default;
			m_NameID = default;
			m_InstanceID = default;
			m_BufferPointer = default;
			m_MipLevel = default;
			m_CubeFace = default;
			m_DepthSlice = default;
		} // 0x000000018BEFF170-0x000000018BEFF25C
		public RenderTargetIdentifier(RenderBuffer buf, int mipLevel = 0 /* Metadata: 0x02060ABE */, CubemapFace cubeFace = CubemapFace.Unknown /* Metadata: 0x02060ABF */, int depthSlice = 0 /* Metadata: 0x02060AC0 */) {
			m_Type = default;
			m_NameID = default;
			m_InstanceID = default;
			m_BufferPointer = default;
			m_MipLevel = default;
			m_CubeFace = default;
			m_DepthSlice = default;
		} // 0x0000000185FE7DE0-0x0000000185FE7E10
	
		// Methods
		public static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type) => default; // 0x00000001852C8F80-0x00000001852C8FD0
		public static implicit operator RenderTargetIdentifier(int nameID) => default; // 0x0000000185FE7E60-0x0000000185FE7EB0
		public static implicit operator RenderTargetIdentifier(Texture tex) => default; // 0x0000000183FDB360-0x0000000183FDB3C0
		public override string ToString() => default; // 0x000000018BEFEF4C-0x000000018BEFF170
		public override int GetHashCode() => default; // 0x0000000185FE7DB0-0x0000000185FE7DC0
		public bool Equals(RenderTargetIdentifier rhs) => default; // 0x000000018BEFEECC-0x000000018BEFEF4C
		public override bool Equals(object obj) => default; // 0x000000018BEFEE40-0x000000018BEFEECC
	}

	public enum RenderTargetFlags // TypeDefIndex: 47966
	{
		None = 0,
		ReadOnlyDepth = 1,
		ReadOnlyStencil = 2,
		ReadOnlyDepthStencil = 3
	}

	public struct RenderTargetBinding // TypeDefIndex: 47967
	{
		// Fields
		private RenderTargetIdentifier[] m_ColorRenderTargets; // 0x00
		private RenderTargetIdentifier m_DepthRenderTarget; // 0x08
		private RenderBufferLoadAction[] m_ColorLoadActions; // 0x30
		private RenderBufferStoreAction[] m_ColorStoreActions; // 0x38
		private RenderBufferLoadAction m_DepthLoadAction; // 0x40
		private RenderBufferStoreAction m_DepthStoreAction; // 0x44
		private RenderTargetFlags m_Flags; // 0x48
	
		// Properties
		public RenderTargetIdentifier[] colorRenderTargets { get => default; set {} } // 0x0000000184142CB0-0x0000000184142CC0 0x000000018646FE2C-0x000000018646FE34
		public RenderTargetIdentifier depthRenderTarget { get => default; set {} } // 0x0000000185FE7CF0-0x0000000185FE7D10 0x0000000185FE7D30-0x0000000185FE7D50
		public RenderBufferLoadAction[] colorLoadActions { get => default; set {} } // 0x0000000185FE7B40-0x0000000185FE7B50 0x00000001864721F0-0x0000000186472200
		public RenderBufferStoreAction[] colorStoreActions { get => default; set {} } // 0x0000000185FE7CE0-0x0000000185FE7CF0 0x0000000185A16440-0x0000000185A16450
		public RenderBufferLoadAction depthLoadAction { get => default; set {} } // 0x0000000185FE65D0-0x0000000185FE65E0 0x00000001813EE9C0-0x00000001813EE9D0
		public RenderBufferStoreAction depthStoreAction { get => default; set {} } // 0x0000000185FE7D10-0x0000000185FE7D20 0x0000000183909010-0x0000000183909020
		public RenderTargetFlags flags { get => default; } // 0x0000000185FE7D20-0x0000000185FE7D30 
	
		// Constructors
		public RenderTargetBinding(RenderTargetIdentifier[] colorRenderTargets, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderTargetIdentifier depthRenderTarget, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) : this() {
			m_ColorRenderTargets = default;
			m_DepthRenderTarget = default;
			m_ColorLoadActions = default;
			m_ColorStoreActions = default;
			m_DepthLoadAction = default;
			m_DepthStoreAction = default;
			m_Flags = default;
		} // 0x000000018BEFED18-0x000000018BEFED80
	}

	public enum ReflectionProbeUsage // TypeDefIndex: 47968
	{
		Off = 0,
		BlendProbes = 1,
		BlendProbesAndSkybox = 2,
		Simple = 3
	}

	public enum ReflectionProbeType // TypeDefIndex: 47969
	{
		Cube = 0,
		Card = 1
	}

	public enum ReflectionProbeClearFlags // TypeDefIndex: 47970
	{
		Skybox = 1,
		SolidColor = 2
	}

	public enum ReflectionProbeOrientedMode // TypeDefIndex: 47971
	{
		None = 0,
		Center = 1,
		Axis = 2
	}

	public enum ReflectionProbeShapeType // TypeDefIndex: 47972
	{
		Box = 0,
		Sphere = 1
	}

	public enum ReflectionProbeMode // TypeDefIndex: 47973
	{
		Baked = 0,
		Realtime = 1,
		Custom = 2
	}

	public struct ReflectionProbeBlendInfo // TypeDefIndex: 47974
	{
		// Fields
		public ReflectionProbe probe; // 0x00
		public float weight; // 0x08
	}

	public enum ReflectionProbeRefreshMode // TypeDefIndex: 47975
	{
		OnAwake = 0,
		EveryFrame = 1,
		ViaScripting = 2
	}

	public enum ReflectionProbeTimeSlicingMode // TypeDefIndex: 47976
	{
		AllFacesAtOnce = 0,
		IndividualFaces = 1,
		NoTimeSlicing = 2
	}

	public enum ShadowSamplingMode // TypeDefIndex: 47977
	{
		CompareDepths = 0,
		RawDepth = 1,
		None = 2
	}

	public enum LightProbeUsage // TypeDefIndex: 47978
	{
		Off = 0,
		BlendProbes = 1,
		UseProxyVolume = 2,
		CustomProvided = 4
	}

	public enum BuiltinShaderDefine // TypeDefIndex: 47979
	{
		UNITY_NO_DXT5nm = 0,
		UNITY_NO_RGBM = 1,
		UNITY_USE_NATIVE_HDR = 2,
		UNITY_ENABLE_REFLECTION_BUFFERS = 3,
		UNITY_FRAMEBUFFER_FETCH_AVAILABLE = 4,
		UNITY_ENABLE_NATIVE_SHADOW_LOOKUPS = 5,
		UNITY_METAL_SHADOWS_USE_POINT_FILTERING = 6,
		UNITY_NO_CUBEMAP_ARRAY = 7,
		UNITY_NO_SCREENSPACE_SHADOWS = 8,
		UNITY_USE_DITHER_MASK_FOR_ALPHABLENDED_SHADOWS = 9,
		UNITY_PBS_USE_BRDF1 = 10,
		UNITY_PBS_USE_BRDF2 = 11,
		UNITY_PBS_USE_BRDF3 = 12,
		UNITY_NO_FULL_STANDARD_SHADER = 13,
		UNITY_SPECCUBE_BOX_PROJECTION = 14,
		UNITY_SPECCUBE_BLENDING = 15,
		UNITY_ENABLE_DETAIL_NORMALMAP = 16,
		SHADER_API_MOBILE = 17,
		SHADER_API_DESKTOP = 18,
		UNITY_HARDWARE_TIER1 = 19,
		UNITY_HARDWARE_TIER2 = 20,
		UNITY_HARDWARE_TIER3 = 21,
		UNITY_COLORSPACE_GAMMA = 22,
		UNITY_LIGHT_PROBE_PROXY_VOLUME = 23,
		UNITY_HALF_PRECISION_FRAGMENT_SHADER_REGISTERS = 24,
		UNITY_LIGHTMAP_DLDR_ENCODING = 25,
		UNITY_LIGHTMAP_RGBM_ENCODING = 26,
		UNITY_LIGHTMAP_FULL_HDR = 27,
		UNITY_VIRTUAL_TEXTURING = 28,
		UNITY_PRETRANSFORM_TO_DISPLAY_ORIENTATION = 29,
		UNITY_ASTC_NORMALMAP_ENCODING = 30,
		SHADER_API_GLES30 = 31,
		UNITY_UNIFIED_SHADER_PRECISION_MODEL = 32,
		HG_RENDER_PATH_MOBILE = 33,
		HG_RENDER_PATH_DESKTOP = 34,
		HG_RENDER_PATH_FORWARD = 35,
		HG_RENDER_PATH_DEFAULT_DEFERRED = 36,
		HG_RENDER_PATH_ONE_PASS_DEFERRED = 37,
		HG_DEVICE_TIER_1000 = 38,
		HG_DEVICE_TIER_2000 = 39,
		HG_DEVICE_TIER_3000 = 40,
		HG_DEVICE_TIER_4000 = 41,
		HG_DEVICE_TIER_5000 = 42
	}

	public enum TextureDimension // TypeDefIndex: 47980
	{
		Unknown = -1,
		None = 0,
		Any = 1,
		Tex2D = 2,
		Tex3D = 3,
		Cube = 4,
		Tex2DArray = 5,
		CubeArray = 6
	}

	public enum CopyTextureSupport // TypeDefIndex: 47981
	{
		None = 0,
		Basic = 1,
		Copy3D = 2,
		DifferentTypes = 4,
		TextureToRT = 8,
		RTToTexture = 16
	}

	public enum ComputeQueueType // TypeDefIndex: 47982
	{
		Default = 0,
		Background = 1,
		Urgent = 2
	}

	public enum CommandBufferExecutionFlags // TypeDefIndex: 47983
	{
		None = 0,
		AsyncCompute = 2
	}

	public enum RTClearFlags // TypeDefIndex: 47984
	{
		None = 0,
		Color = 1,
		Depth = 2,
		ColorDepth = 3,
		Stencil = 4,
		ColorStencil = 5,
		DepthStencil = 6,
		All = 7
	}

	public enum RenderTextureSubElement // TypeDefIndex: 47985
	{
		Color = 0,
		Depth = 1,
		Stencil = 2,
		Default = 3
	}

	public enum OpenGLESVersion // TypeDefIndex: 47986
	{
		None = 0,
		OpenGLES20 = 1,
		OpenGLES30 = 2,
		OpenGLES31 = 3,
		OpenGLES31AEP = 4,
		OpenGLES32 = 5
	}

	public enum SynchronisationStageFlags // TypeDefIndex: 47987
	{
		VertexProcessing = 1,
		PixelProcessing = 2,
		ComputeProcessing = 4,
		AllGPUOperations = 7
	}

	public enum GraphicsFenceType // TypeDefIndex: 47988
	{
		AsyncQueueSynchronisation = 0,
		CPUSynchronisation = 1
	}

	public struct GraphicsFence // TypeDefIndex: 47989
	{
		// Fields
		internal IntPtr m_Ptr; // 0x00
		internal int m_Version; // 0x08
		internal GraphicsFenceType m_FenceType; // 0x0C
	
		// Methods
		internal static SynchronisationStageFlags TranslateSynchronizationStageToFlags(SynchronisationStage s) => default; // 0x000000018BEFBFCC-0x000000018BEFBFD8
		internal void InitPostAllocation() {} // 0x000000018BEFBF1C-0x000000018BEFBFA4
		internal bool IsFencePending() => default; // 0x000000018BEFBFA4-0x000000018BEFBFCC
		internal void Validate() {} // 0x000000018BEFBFD8-0x000000018BEFC060
		private int GetPlatformNotSupportedVersion() => default; // 0x0000000185FE7CA0-0x0000000185FE7CB0
		private static int GetVersionNumber(IntPtr fencePtr) => default; // 0x000000018BEFBEE8-0x000000018BEFBF1C
	}

	public sealed class GraphicsSettings : UnityEngine.Object // TypeDefIndex: 47990
	{
		// Properties
		public static bool lightsUseLinearIntensity { get => default; } // 0x000000018519E1A0-0x000000018519E1E0 
		public static bool useScriptableRenderPipelineBatching { set {} } // 0x0000000185F7DE70-0x0000000185F7DEB0
		public static bool enableSRPBatchInstancing { set {} } // 0x0000000185F7DEB0-0x0000000185F7DEF0
		private static ScriptableObject INTERNAL_currentRenderPipeline { get => default; } // 0x0000000184A790B0-0x0000000184A790F0 
		public static RenderPipelineAsset currentRenderPipeline { get => default; } // 0x0000000184A79050-0x0000000184A790B0 
		public static RenderPipelineAsset renderPipelineAsset { get => default; set {} } // 0x000000018646D7B8-0x000000018646D7C4 0x000000018646D7C4-0x000000018646D7CC
		private static ScriptableObject INTERNAL_defaultRenderPipeline { get => default; set {} } // 0x0000000185F0F4C0-0x0000000185F0F500 0x0000000185F7DEF0-0x0000000185F7DF30
		public static RenderPipelineAsset defaultRenderPipeline { get => default; set {} } // 0x0000000185F0F480-0x0000000185F0F4C0 0x000000018646D7C4-0x000000018646D7CC
	
		// Constructors
		public GraphicsSettings() {} // Dummy constructor
	
		// Methods
		public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash) => default; // 0x000000018429EFF0-0x000000018429F040
		public static bool HasShaderDefine(BuiltinShaderDefine defineHash) => default; // 0x000000018429EEF0-0x000000018429EFB0
		public static void RegisterRenderPipelineSettings<T>(RenderPipelineGlobalSettings settings)
			where T : UnityEngine.Rendering.RenderPipeline {}
		private static void RegisterRenderPipeline(string renderpipelineName, UnityEngine.Object settings) {} // 0x0000000185EDAE50-0x0000000185EDAEA0
		public static void UnregisterRenderPipelineSettings<T>()
			where T : UnityEngine.Rendering.RenderPipeline {}
		private static void UnregisterRenderPipeline(string renderpipelineName) {} // 0x000000018BEFC060-0x000000018BEFC094
		public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>()
			where T : UnityEngine.Rendering.RenderPipeline => default;
		private static UnityEngine.Object GetSettingsForRenderPipeline(string renderpipelineName) => default; // 0x0000000185ECAD90-0x0000000185ECADD0
		public static void INTERNAL_AddShaderToSRPInstancingWhiteList(string shaderName) {} // 0x0000000185BA61D0-0x0000000185BA6210
		public static void AddShaderToSRPInstancingWhiteList(string shaderName) {} // 0x00000001864744FC-0x0000000186474504
	}

	public class OnDemandRendering // TypeDefIndex: 47991
	{
		// Fields
		private static int m_RenderFrameInterval; // 0x00
	
		// Properties
		public static int renderFrameInterval { get => default; } // 0x0000000184FE1090-0x0000000184FE10F0 
	
		// Constructors
		public OnDemandRendering() {} // Dummy constructor
		static OnDemandRendering() {} // 0x0000000185FA4420-0x0000000185FA4460
	
		// Methods
		internal static void GetRenderFrameInterval(out int frameInterval) {
			frameInterval = default;
		} // 0x0000000184FE1040-0x0000000184FE1090
	}

	public class CommandBuffer : IDisposable // TypeDefIndex: 47992
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public string name { set {} } // 0x00000001840C3820-0x00000001840C3870
		public int sizeInBytes { get => default; } // 0x000000018BEFACFC-0x000000018BEFAD30 
	
		// Constructors
		public CommandBuffer() {} // 0x0000000185AEE560-0x0000000185AEE580
	
		// Methods
		public void SetInvertCulling(bool invertCulling) {} // 0x0000000184FA3EC0-0x0000000184FA3F10
		private static IntPtr InitBuffer() => default; // 0x0000000185AEE580-0x0000000185AEE5C0
		private static IntPtr InitBufferTempJobAlloc() => default; // 0x0000000183F8EF10-0x0000000183F8EF50
		public void HGSetFragmentShadingRate(uint fragmentSizeX, uint fragmentSizeY) {} // 0x000000018BEF82D8-0x000000018BEF8328
		public void HGSetTransparentOffscreenBlend(bool offscreenBlend) {} // 0x000000018BEF8328-0x000000018BEF836C
		private IntPtr CreateGPUFence_Internal(GraphicsFenceType fenceType, SynchronisationStageFlags stage) => default; // 0x000000018BEF62C8-0x000000018BEF6318
		private void WaitOnGPUFence_Internal(IntPtr fencePtr, SynchronisationStageFlags stage) {} // 0x000000018BEFACA8-0x000000018BEFACFC
		private void ReleaseBuffer() {} // 0x000000018502BCC0-0x000000018502BD00
		public void SetComputeIntParam(ComputeShader computeShader, int nameID, int val) {} // 0x000000018BEF8CB0-0x000000018BEF8D14
		public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) {} // 0x000000018646D54C-0x000000018646D564
		public void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Vector4[] values) {} // 0x000000018BEF9014-0x000000018BEF9078
		public void SetComputeValueParam(ComputeShader computeShader, int nameID, UIntPtr data, int byteCount) {} // 0x000000018BEF8FB0-0x000000018BEF9014
		public void SetComputeMatrixParam(ComputeShader computeShader, int nameID, Matrix4x4 val) {} // 0x000000018BEF8E64-0x000000018BEF8E7C
		private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element, int slice) {} // 0x0000000183FDB650-0x0000000183FDB6C0
		private void Internal_SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer, int offset, int size) {} // 0x000000018BEF8884-0x000000018BEF88E8
		private void Internal_SetComputeBufferIDParam(ComputeShader computeShader, int kernelIndex, int nameID, uint bufferID, int offset, int size) {} // 0x000000018BEF8820-0x000000018BEF8884
		private void Internal_SetComputeConstantComputeBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) {} // 0x000000018BEF894C-0x000000018BEF89B0
		private void Internal_SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, uint bufferId, int offset, int size) {} // 0x000000018BEF88E8-0x000000018BEF894C
		private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) {} // 0x00000001856F3E20-0x00000001856F3E90
		public void Clear() {} // 0x000000018BEF6040-0x000000018BEF6074
		private unsafe void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties, RenderStateBlock* overrideState = null) {} // 0x000000018BEF8560-0x000000018BEF85A8
		private void Internal_DrawRendererList(UnityEngine.Rendering.RendererUtils.RendererList rendererList) {} // 0x000000018BEF87A8-0x000000018BEF87BC
		internal void AddDrawECSMeshRendererList(uint rendererList) {} // 0x000000018BEF5ADC-0x000000018BEF5B1C
		internal void AddDrawECSMeshRendererListWithSRPRendererList(uint ecsList, UnityEngine.Rendering.RendererUtils.RendererList srpList) {} // 0x000000018BEF5AC8-0x000000018BEF5ADC
		internal void AddDrawECSGrassRendererList(uint rendererList) {} // 0x000000018BEF5A38-0x000000018BEF5A78
		internal void AddDrawECSDecalRendererList(uint rendererList) {} // 0x000000018BEF59B8-0x000000018BEF59F8
		internal void AddDrawECSFoliageOccluderRendererList(uint rendererList) {} // 0x000000018BEF59F8-0x000000018BEF5A38
		internal void Add_GPUDriven_DrawRendererList(uint rendererList, bool renderDepthOnly) {} // 0x000000018BEF5B1C-0x000000018BEF5B70
		private void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) {} // 0x000000018BEF871C-0x000000018BEF8764
		private void Internal_DrawProceduralIndexedIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) {} // 0x000000018BEF8664-0x000000018BEF86B8
		private unsafe void Internal_DrawMeshInstancedNativeMatrixArray(Mesh mesh, int submeshIndex, Material material, int shaderPass, IntPtr matrices, int count, MaterialPropertyBlock properties, RenderStateBlock* overrideState = null) {} // 0x000000018BEF8434-0x000000018BEF8498
		private void Internal_HGDrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties) {} // 0x000000018BEF87BC-0x000000018BEF8820
		private void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties) {} // 0x000000018BEF8498-0x000000018BEF84FC
		private unsafe void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, RenderStateBlock* overrideState = null) {} // 0x000000018BEF83D0-0x000000018BEF8434
		private void Internal_DrawOcclusionMesh(RectInt normalizedCamViewport) {} // 0x000000018BEF85EC-0x000000018BEF8600
		private void SetRandomWriteTarget_Buffer(int index, ComputeBuffer uav, bool preserveCounterValue) {} // 0x000000018BEF977C-0x000000018BEF97DC
		public void SetViewport(Rect pixelRect) {} // 0x000000018BEFAB44-0x000000018BEFAB58
		public void EnableScissorRect(Rect scissor) {} // 0x000000018BEF7C04-0x000000018BEF7C18
		public void DisableScissorRect() {} // 0x000000018BEF651C-0x000000018BEF6550
		private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) {} // 0x0000000183FDB7B0-0x0000000183FDB820
		private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) {} // 0x000000018BEF5D14-0x000000018BEF5D60
		private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) {} // 0x000000018BEF5C64-0x000000018BEF5CB0
		public void EncodeMetalFXSpatialScaler(uint spatialScalerHandle, RenderTargetIdentifier colorTexture, RenderTargetIdentifier outputTexture) {} // 0x000000018BEF7CBC-0x000000018BEF7CD4
		public void EncodeMetalFXTemporalScaler(uint temporalScalerHandle, bool resetHistory, RenderTargetIdentifier colorTexture, RenderTargetIdentifier depthTexture, RenderTargetIdentifier motionTexture, RenderTargetIdentifier outputTexture, bool reversedDepth, float jitterOffsetX, float jitterOffsetY) {} // 0x000000018BEF7D34-0x000000018BEF7D9C
		private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, UnityEngine.FilterMode filter) {} // 0x000000018BEF7E8C-0x000000018BEF7EA4
		public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, UnityEngine.FilterMode filter) {} // 0x000000018BEF7EE8-0x000000018BEF7F2C
		public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc) {} // 0x000000018BEF7EA4-0x000000018BEF7EE8
		public void ReleaseTemporaryRT(int nameID) {} // 0x000000018BEF89B0-0x000000018BEF89F0
		public void ClearRenderTarget(RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil) {} // 0x000000018BEF6020-0x000000018BEF6040
		public void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor) {} // 0x000000018BEF5F9C-0x000000018BEF6020
		public void SetGlobalFloat(int nameID, float value) {} // 0x000000018BEF92E0-0x000000018BEF9330
		public void SetGlobalInt(int nameID, int value) {} // 0x000000018BEF9330-0x000000018BEF9380
		public void SetGlobalVector(int nameID, Vector4 value) {} // 0x000000018BEF961C-0x000000018BEF9630
		public void SetGlobalColor(int nameID, UnityEngine.Color value) {} // 0x000000018BEF91B8-0x000000018BEF91CC
		public void SetGlobalMatrix(int nameID, Matrix4x4 value) {} // 0x000000018BEF9438-0x000000018BEF944C
		public void EnableShaderKeyword(string keyword) {} // 0x000000018BEF7C18-0x000000018BEF7C5C
		private void EnableGlobalKeyword(GlobalKeyword keyword) {} // 0x000000018BEF7ACC-0x000000018BEF7AE0
		private void EnableMaterialKeyword(Material material, LocalKeyword keyword) {} // 0x000000018BEF7BAC-0x000000018BEF7BC0
		private void EnableComputeKeyword(ComputeShader computeShader, LocalKeyword keyword) {} // 0x000000018BEF7A74-0x000000018BEF7A88
		public void EnableKeyword(in GlobalKeyword keyword) {} // 0x000000018BEF7AE0-0x000000018BEF7B00
		public void EnableKeyword(Material material, in LocalKeyword keyword) {} // 0x000000018BEF7B2C-0x000000018BEF7B58
		public void EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) {} // 0x000000018BEF7B00-0x000000018BEF7B2C
		public void DisableShaderKeyword(string keyword) {} // 0x000000018BEF6550-0x000000018BEF6594
		private void DisableGlobalKeyword(GlobalKeyword keyword) {} // 0x000000018BEF6428-0x000000018BEF643C
		private void DisableMaterialKeyword(Material material, LocalKeyword keyword) {} // 0x000000018BEF6508-0x000000018BEF651C
		private void DisableComputeKeyword(ComputeShader computeShader, LocalKeyword keyword) {} // 0x000000018BEF63D0-0x000000018BEF63E4
		public void DisableKeyword(in GlobalKeyword keyword) {} // 0x000000018BEF6494-0x000000018BEF64B4
		public void DisableKeyword(Material material, in LocalKeyword keyword) {} // 0x000000018BEF643C-0x000000018BEF6468
		public void DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) {} // 0x000000018BEF6468-0x000000018BEF6494
		private void SetGlobalKeyword(GlobalKeyword keyword, bool value) {} // 0x000000018BEF93D4-0x000000018BEF93E8
		private void SetMaterialKeyword(Material material, LocalKeyword keyword, bool value) {} // 0x000000018BEF971C-0x000000018BEF9734
		private void SetComputeKeyword(ComputeShader computeShader, LocalKeyword keyword, bool value) {} // 0x000000018BEF8D78-0x000000018BEF8D90
		public void SetKeyword(in GlobalKeyword keyword, bool value) {} // 0x000000018BEF9664-0x000000018BEF9684
		public void SetKeyword(Material material, in LocalKeyword keyword, bool value) {} // 0x000000018BEF9684-0x000000018BEF96B8
		public void SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) {} // 0x000000018BEF9630-0x000000018BEF9664
		public void SetGlobalDepthBias(float bias, float slopeBias) {} // 0x000000018BEF928C-0x000000018BEF92E0
		public void SetExecutionFlags(CommandBufferExecutionFlags flags) {} // 0x000000018BEF9078-0x000000018BEF90B8
		private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) => default; // 0x000000018BEFAB58-0x000000018BEFABA8
		public void SetGlobalVectorArray(int nameID, Vector4[] values) {} // 0x000000018BEF9544-0x000000018BEF9594
		private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) {} // 0x000000018BEF944C-0x000000018BEF94AC
		private void SetGlobalBufferInternal(int nameID, ComputeBuffer value) {} // 0x000000018BEF9108-0x000000018BEF9158
		private void SetGlobalBufferIDInternal(int nameID, uint bufferID) {} // 0x000000018BEF90B8-0x000000018BEF9108
		public void BeginSample(string name) {} // 0x000000018BEF5BBC-0x000000018BEF5C00
		public void EndSample(string name) {} // 0x000000018BEF7DE0-0x000000018BEF7E24
		public void BeginSample(CustomSampler sampler) {} // 0x000000018BEF5BB4-0x000000018BEF5BBC
		public void EndSample(CustomSampler sampler) {} // 0x000000018BEF7E24-0x000000018BEF7E2C
		private void BeginSample_CustomSampler(CustomSampler sampler) {} // 0x000000018BEF5B70-0x000000018BEF5BB4
		private void EndSample_CustomSampler(CustomSampler sampler) {} // 0x000000018BEF7D9C-0x000000018BEF7DE0
		private void SetGlobalConstantBufferInternal(ComputeBuffer buffer, int nameID, int offset, int size) {} // 0x000000018BEF91CC-0x000000018BEF9230
		private void SetGlobalConstantBufferInternal0(uint bufferId, int nameID, int offset, int size) {} // 0x0000000184BB4370-0x0000000184BB43E0
		public void SetRenderTarget(RenderTargetIdentifier rt) {} // 0x000000018BEFA448-0x000000018BEFA4B4
		public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) {} // 0x000000018BEFA804-0x000000018BEFA8E0
		public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) {} // 0x000000018BEF9AF8-0x000000018BEF9BE8
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel) {} // 0x000000018BEFA4B4-0x000000018BEFA610
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) {} // 0x000000018BEFA610-0x000000018BEFA804
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) {} // 0x000000018BEFA8E0-0x000000018BEFAB00
		public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) {} // 0x000000018BEF9E00-0x000000018BEF9F3C
		public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) {} // 0x000000018BEF9BE8-0x000000018BEF9E00
		public void SetRenderTarget(RenderTargetBinding binding) {} // 0x000000018BEF9F3C-0x000000018BEFA448
		private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) {} // 0x000000018BEF9AD0-0x000000018BEF9AF8
		private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) {} // 0x000000018BEF98BC-0x000000018BEF9900
		private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) {} // 0x000000018BEF9A24-0x000000018BEF9A6C
		private void SetRenderTargetMultiSubtarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) {} // 0x000000018BEF9964-0x000000018BEF99C0
		public void SetBufferData(ComputeBuffer buffer, Array data) {} // 0x000000018BEF8A44-0x000000018BEF8BA4
		private void InternalSetComputeBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) {} // 0x000000018BEF836C-0x000000018BEF83D0
		private void CopyBufferToImageImpl(ComputeBuffer source, int bufferOffset, Texture dest, int texOffsetX, int texOffsetY, int texOffsetZ, int texExtentX, int texExtentY, int texExtentZ, int mipLevel, int layer) {} // 0x000000018BEF6074-0x000000018BEF60DC
		private void SetProfilingHGPassImpl(int pass) {} // 0x000000018BEF9734-0x000000018BEF9774
		public void SetProfilingHGPass(ProfilingHGPass pass) {} // 0x000000018BEF9774-0x000000018BEF977C
		private void RenderUIOverlayImpl(Camera camera) {} // 0x000000018BEF89F8-0x000000018BEF8A3C
		private void HGDrawUIRendererListImpl(uint listHandle) {} // 0x000000018BEF8290-0x000000018BEF82D0
		public IntPtr GetNativePtr() => default; // 0x0000000185FC7990-0x0000000185FC79A0
		~CommandBuffer() {} // 0x0000000185F4E270-0x0000000185F4E300
		public void Dispose() {} // 0x000000018BEF6594-0x000000018BEF65E4
		private void Dispose(bool disposing) {} // 0x000000018646D168-0x000000018646D188
		public void Release() {} // 0x000000018BEF89F0-0x000000018BEF89F8
		public void InitWithTempJobAlloc() {} // 0x0000000183F8EE90-0x0000000183F8EF10
		public void ReleaseInternalPtr() {} // 0x0000000183F8EF50-0x0000000183F8EFA0
		public GraphicsFence CreateAsyncGraphicsFence() => default; // 0x000000018BEF628C-0x000000018BEF62C8
		public GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage) => default; // 0x000000018BEF6318-0x000000018BEF637C
		public void WaitOnAsyncGraphicsFence(GraphicsFence fence) {} // 0x000000018BEFABA8-0x000000018BEFABCC
		public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStage stage) {} // 0x000000018BEFABCC-0x000000018BEFABFC
		public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStageFlags stage) {} // 0x000000018BEFABFC-0x000000018BEFACA8
		public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) {} // 0x0000000183FDB500-0x0000000183FDB560
		public void SetComputeValueParam<T>(ComputeShader computeShader, int nameID, NativeArray<T> data)
			where T : struct {}
		public void SetComputeMatrixParam(ComputeShader computeShader, string name, Matrix4x4 val) {} // 0x000000018BEF8DF4-0x000000018BEF8E64
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) {} // 0x0000000183FDB5E0-0x0000000183FDB650
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt) {} // 0x000000018BEF8EF4-0x000000018BEF8F2C
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel) {} // 0x0000000183FDB560-0x0000000183FDB5E0
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel) {} // 0x000000018BEF8F70-0x000000018BEF8FB0
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) {} // 0x000000018BEF8E7C-0x000000018BEF8EF4
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) {} // 0x000000018BEF8F2C-0x000000018BEF8F70
		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer, int offset = 0 /* Metadata: 0x02060B39 */, int size = -1 /* Metadata: 0x02060B3A */) {} // 0x000000018BEF8C20-0x000000018BEF8C30
		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer, int offset = 0 /* Metadata: 0x02060B3B */, int size = -1 /* Metadata: 0x02060B3C */) {} // 0x000000018BEF8BA4-0x000000018BEF8C10
		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, uint bufferID, int offset = 0 /* Metadata: 0x02060B3D */, int size = -1 /* Metadata: 0x02060B3E */) {} // 0x000000018BEF8C10-0x000000018BEF8C20
		public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) {} // 0x000000018BEF8C30-0x000000018BEF8C40
		public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, uint bufferId, int offset, int size) {} // 0x000000018BEF8CA0-0x000000018BEF8CB0
		public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, uint bufferId, int offset, int size) {} // 0x000000018BEF8C40-0x000000018BEF8CA0
		public void SetGlobalConstantBuffer(uint bufferId, int nameID, int offset, int size) {} // 0x0000000186471FD4-0x0000000186471FE4
		public void SetGlobalConstantBuffer(uint bufferId, string name, int offset, int size) {} // 0x000000018BEF9230-0x000000018BEF927C
		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) {} // 0x000000018646D53C-0x000000018646D54C
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties, RenderStateBlock? overrideState = default) {} // 0x000000018BEF72C4-0x000000018BEF75B4
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) {} // 0x000000018BEF71D4-0x000000018BEF72C4
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) {} // 0x000000018BEF7174-0x000000018BEF71D4
		public void DrawRendererList(UnityEngine.Rendering.RendererUtils.RendererList rendererList) {} // 0x000000018BEF7A00-0x000000018BEF7A20
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) {} // 0x000000018BEF78B4-0x000000018BEF7A00
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) {} // 0x000000018BEF75D4-0x000000018BEF77D0
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) {} // 0x000000018BEF77D0-0x000000018BEF7848
		public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) {} // 0x000000018BEF7848-0x000000018BEF78B4
		public void HGDrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties) {} // 0x000000018BEF7F2C-0x000000018BEF8290
		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, NativeArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, RenderStateBlock? overrideState = default) {} // 0x000000018BEF6CD4-0x000000018BEF7174
		public void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties = null) {} // 0x000000018BEF6A10-0x000000018BEF6CD4
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, RenderStateBlock? overrideState = default) {} // 0x000000018BEF65E4-0x000000018BEF6940
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs) {} // 0x000000018BEF6940-0x000000018BEF6A10
		public void DrawOcclusionMesh(RectInt normalizedCamViewport) {} // 0x000000018BEF75B4-0x000000018BEF75D4
		public void SetRandomWriteTarget(int index, ComputeBuffer buffer, bool preserveCounterValue) {} // 0x000000018BEF97F8-0x000000018BEF9858
		public void SetRandomWriteTarget(int index, ComputeBuffer buffer) {} // 0x000000018BEF97DC-0x000000018BEF97F8
		public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) {} // 0x000000018BEF6148-0x000000018BEF61B4
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement) {} // 0x000000018BEF6218-0x000000018BEF628C
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) {} // 0x000000018BEF61B4-0x000000018BEF6218
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY) {} // 0x0000000183FDB6C0-0x0000000183FDB7B0
		public void Blit(Texture source, RenderTargetIdentifier dest) {} // 0x000000018BEF5EA0-0x000000018BEF5F3C
		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) {} // 0x000000018BEF5D60-0x000000018BEF5E0C
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, int sourceDepthSlice, int destDepthSlice) {} // 0x000000018BEF5E0C-0x000000018BEF5EA0
		public void SetGlobalVectorArray(string propertyName, Vector4[] values) {} // 0x000000018BEF9594-0x000000018BEF95CC
		public void SetGlobalTexture(string name, RenderTargetIdentifier value) {} // 0x000000018BEF94E4-0x000000018BEF9544
		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) {} // 0x000000018BEF94C4-0x000000018BEF94E4
		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) {} // 0x000000018BEF94AC-0x000000018BEF94C4
		public void SetGlobalBuffer(int nameID, ComputeBuffer value) {} // 0x000000018BEF9160-0x000000018BEF9168
		public void SetGlobalBuffer(int nameID, uint bufferID) {} // 0x000000018BEF9158-0x000000018BEF9160
		public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size) {} // 0x000000018BEF927C-0x000000018BEF928C
		public void CopyBufferToImage(ComputeBuffer source, int offset, Texture dest, int texOffsetX, int texOffsetY, int texOffsetZ, int texExtentX, int texExtentY, int texExtentZ, int mipLevel, int layer) {} // 0x000000018BEF60DC-0x000000018BEF6148
		public void RenderUIOverlay(Camera camera) {} // 0x000000018BEF8A3C-0x000000018BEF8A44
		public void HGDrawUIRendererList(uint listHandle) {} // 0x000000018BEF82D0-0x000000018BEF82D8
		private void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val) {} // 0x0000000185769980-0x00000001857699F0
		private void SetComputeMatrixParam_Injected(ComputeShader computeShader, int nameID, ref Matrix4x4 val) {} // 0x000000018BEF8D90-0x000000018BEF8DF4
		private unsafe void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties, RenderStateBlock* overrideState = null) {} // 0x000000018BEF84FC-0x000000018BEF8560
		private void Internal_DrawRendererList_Injected(ref UnityEngine.Rendering.RendererUtils.RendererList rendererList) {} // 0x000000018BEF8764-0x000000018BEF87A8
		private void AddDrawECSMeshRendererListWithSRPRendererList_Injected(uint ecsList, ref UnityEngine.Rendering.RendererUtils.RendererList srpList) {} // 0x000000018BEF5A78-0x000000018BEF5AC8
		private void Internal_DrawProcedural_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) {} // 0x000000018BEF86B8-0x000000018BEF871C
		private void Internal_DrawProceduralIndexedIndirect_Injected(GraphicsBuffer indexBuffer, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) {} // 0x000000018BEF8600-0x000000018BEF8664
		private void Internal_DrawOcclusionMesh_Injected(ref RectInt normalizedCamViewport) {} // 0x000000018BEF85A8-0x000000018BEF85EC
		private void SetViewport_Injected(ref Rect pixelRect) {} // 0x000000018BEFAB00-0x000000018BEFAB44
		private void EnableScissorRect_Injected(ref Rect scissor) {} // 0x000000018BEF7BC0-0x000000018BEF7C04
		private void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) {} // 0x000000018BEF5CB0-0x000000018BEF5D14
		private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) {} // 0x000000018BEF5C00-0x000000018BEF5C64
		private void EncodeMetalFXSpatialScaler_Injected(uint spatialScalerHandle, ref RenderTargetIdentifier colorTexture, ref RenderTargetIdentifier outputTexture) {} // 0x000000018BEF7C5C-0x000000018BEF7CBC
		private void EncodeMetalFXTemporalScaler_Injected(uint temporalScalerHandle, bool resetHistory, ref RenderTargetIdentifier colorTexture, ref RenderTargetIdentifier depthTexture, ref RenderTargetIdentifier motionTexture, ref RenderTargetIdentifier outputTexture, bool reversedDepth, float jitterOffsetX, float jitterOffsetY) {} // 0x000000018BEF7CD4-0x000000018BEF7D34
		private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, UnityEngine.FilterMode filter) {} // 0x000000018BEF7E2C-0x000000018BEF7E8C
		private void ClearRenderTarget_Injected(RTClearFlags clearFlags, ref UnityEngine.Color backgroundColor, float depth, uint stencil) {} // 0x000000018BEF5F3C-0x000000018BEF5F9C
		private void SetGlobalVector_Injected(int nameID, ref Vector4 value) {} // 0x000000018BEF95CC-0x000000018BEF961C
		private void SetGlobalColor_Injected(int nameID, ref UnityEngine.Color value) {} // 0x000000018BEF9168-0x000000018BEF91B8
		private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value) {} // 0x000000018BEF93E8-0x000000018BEF9438
		private void EnableGlobalKeyword_Injected(ref GlobalKeyword keyword) {} // 0x000000018BEF7A88-0x000000018BEF7ACC
		private void EnableMaterialKeyword_Injected(Material material, ref LocalKeyword keyword) {} // 0x000000018BEF7B58-0x000000018BEF7BAC
		private void EnableComputeKeyword_Injected(ComputeShader computeShader, ref LocalKeyword keyword) {} // 0x000000018BEF7A20-0x000000018BEF7A74
		private void DisableGlobalKeyword_Injected(ref GlobalKeyword keyword) {} // 0x000000018BEF63E4-0x000000018BEF6428
		private void DisableMaterialKeyword_Injected(Material material, ref LocalKeyword keyword) {} // 0x000000018BEF64B4-0x000000018BEF6508
		private void DisableComputeKeyword_Injected(ComputeShader computeShader, ref LocalKeyword keyword) {} // 0x000000018BEF637C-0x000000018BEF63D0
		private void SetGlobalKeyword_Injected(ref GlobalKeyword keyword, bool value) {} // 0x000000018BEF9380-0x000000018BEF93D4
		private void SetMaterialKeyword_Injected(Material material, ref LocalKeyword keyword, bool value) {} // 0x000000018BEF96B8-0x000000018BEF971C
		private void SetComputeKeyword_Injected(ComputeShader computeShader, ref LocalKeyword keyword, bool value) {} // 0x000000018BEF8D14-0x000000018BEF8D78
		private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) {} // 0x000000018BEF9A6C-0x000000018BEF9AD0
		private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) {} // 0x000000018BEF9858-0x000000018BEF98BC
		private void SetRenderTargetMulti_Internal_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) {} // 0x000000018BEF99C0-0x000000018BEF9A24
		private void SetRenderTargetMultiSubtarget_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) {} // 0x000000018BEF9900-0x000000018BEF9964
	}

	public static class CommandBufferExtensions // TypeDefIndex: 47993
	{
		// Methods
		private static void Internal_SwitchIntoFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents) {} // 0x000000018BEF58CC-0x000000018BEF5930
		private static void Internal_SwitchOutOfFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, bool copyContents) {} // 0x000000018BEF5930-0x000000018BEF5984
		public static void SwitchIntoFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents) {} // 0x000000018BEF5984-0x000000018BEF59A4
		public static void SwitchOutOfFastMemory(CommandBuffer cmd, RenderTargetIdentifier rid, bool copyContents) {} // 0x000000018BEF59A4-0x000000018BEF59B8
	}

	public class SplashScreen // TypeDefIndex: 47994
	{
		// Properties
		public static bool isFinished { get => default; } // 0x000000018BF04204-0x000000018BF04230 
	
		// Constructors
		public SplashScreen() {} // Dummy constructor
	}

	public struct SphericalHarmonicsL2 : IEquatable<SphericalHarmonicsL2> // TypeDefIndex: 47995
	{
		// Fields
		private float shr0; // 0x00
		private float shr1; // 0x04
		private float shr2; // 0x08
		private float shr3; // 0x0C
		private float shr4; // 0x10
		private float shr5; // 0x14
		private float shr6; // 0x18
		private float shr7; // 0x1C
		private float shr8; // 0x20
		private float shg0; // 0x24
		private float shg1; // 0x28
		private float shg2; // 0x2C
		private float shg3; // 0x30
		private float shg4; // 0x34
		private float shg5; // 0x38
		private float shg6; // 0x3C
		private float shg7; // 0x40
		private float shg8; // 0x44
		private float shb0; // 0x48
		private float shb1; // 0x4C
		private float shb2; // 0x50
		private float shb3; // 0x54
		private float shb4; // 0x58
		private float shb5; // 0x5C
		private float shb6; // 0x60
		private float shb7; // 0x64
		private float shb8; // 0x68
	
		// Properties
		public float this[int rgb, int coefficient] { get => default; set {} } // 0x0000000184A2ED10-0x0000000184A2EE20 0x000000018BF04000-0x000000018BF04204
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018BF03A78-0x000000018BF03C48
		public override bool Equals(object other) => default; // 0x000000018BF0390C-0x000000018BF039D0
		public bool Equals(SphericalHarmonicsL2 other) => default; // 0x000000018BF039D0-0x000000018BF03A78
		public static SphericalHarmonicsL2 operator *(SphericalHarmonicsL2 lhs, float rhs) => default; // 0x0000000185FE8350-0x0000000185FE8650
		public static SphericalHarmonicsL2 operator +(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) => default; // 0x0000000185FE8010-0x0000000185FE8350
		public static bool operator ==(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) => default; // 0x000000018BF03C48-0x000000018BF04000
	}

	public struct BatchVisibility // TypeDefIndex: 47996
	{
		// Fields
		public readonly int offset; // 0x00
		public readonly int instancesCount; // 0x04
		public int visibleCount; // 0x08
	}

	public struct BatchCullingContext // TypeDefIndex: 47997
	{
		// Fields
		public readonly NativeArray<Plane> cullingPlanes; // 0x00
		public NativeArray<BatchVisibility> batchVisibility; // 0x10
		public NativeArray<int> visibleIndices; // 0x20
		public NativeArray<int> visibleIndicesY; // 0x30
		public readonly LODParameters lodParameters; // 0x40
		public readonly Matrix4x4 cullingMatrix; // 0x5C
		public readonly float nearPlane; // 0x9C
	
		// Constructors
		internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, NativeArray<int> outVisibleIndicesY, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane) {
			cullingPlanes = default;
			batchVisibility = default;
			visibleIndices = default;
			visibleIndicesY = default;
			lodParameters = default;
			cullingMatrix = default;
			nearPlane = default;
		} // 0x0000000185FE7BB0-0x0000000185FE7C30
	}

	internal struct BatchRendererCullingOutput // TypeDefIndex: 47998
	{
		// Fields
		public JobHandle cullingJobsFence; // 0x00
		public Matrix4x4 cullingMatrix; // 0x10
		public unsafe Plane* cullingPlanes; // 0x50
		public unsafe BatchVisibility* batchVisibility; // 0x58
		public unsafe int* visibleIndices; // 0x60
		public unsafe int* visibleIndicesY; // 0x68
		public int cullingPlanesCount; // 0x70
		public int batchVisibilityCount; // 0x74
		public int visibleIndicesCount; // 0x78
		public float nearPlane; // 0x7C
	}

	public class BatchRendererGroup // TypeDefIndex: 48000
	{
		// Fields
		private IntPtr m_GroupHandle; // 0x10
		private OnPerformCulling m_PerformCulling; // 0x18
	
		// Nested types
		public delegate JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext); // TypeDefIndex: 47999; 0x000000018BEFC904-0x000000018BEFCA2C
	
		// Constructors
		public BatchRendererGroup() {} // Dummy constructor
	
		// Methods
		private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters) {} // 0x000000018BEF2D08-0x000000018BEF2DAC
	}

	public struct AttachmentDescriptor : IEquatable<AttachmentDescriptor> // TypeDefIndex: 48001
	{
		// Fields
		private RenderBufferLoadAction m_LoadAction; // 0x00
		private RenderBufferStoreAction m_StoreAction; // 0x04
		private GraphicsFormat m_Format; // 0x08
		private RenderTargetIdentifier m_LoadStoreTarget; // 0x10
		private RenderTargetIdentifier m_ResolveTarget; // 0x38
		private UnityEngine.Color m_ClearColor; // 0x60
		private float m_ClearDepth; // 0x70
		private uint m_ClearStencil; // 0x74
	
		// Properties
		public RenderBufferLoadAction loadAction { set {} } // 0x00000001818AA390-0x00000001818AA3A0
		public RenderBufferStoreAction storeAction { set {} } // 0x0000000185FB2BA0-0x0000000185FB2BB0
		public GraphicsFormat graphicsFormat { set {} } // 0x0000000185FB2B90-0x0000000185FB2BA0
	
		// Methods
		public void ConfigureTarget(RenderTargetIdentifier target, bool loadExistingContents, bool storeResults) {} // 0x000000018BEF3330-0x000000018BEF3374
		public void ConfigureClear(UnityEngine.Color clearColor, float clearDepth = 1f /* Metadata: 0x02060B3F */, uint clearStencil = 0 /* Metadata: 0x02060B43 */) {} // 0x0000000185FE7B90-0x0000000185FE7BB0
		public bool Equals(AttachmentDescriptor other) => default; // 0x000000018BEF343C-0x000000018BEF35E8
		public override bool Equals(object obj) => default; // 0x000000018BEF3374-0x000000018BEF343C
		public override int GetHashCode() => default; // 0x000000018BEF35E8-0x000000018BEF3678
	}

	public struct BlendState : IEquatable<BlendState> // TypeDefIndex: 48002
	{
		// Fields
		private RenderTargetBlendState m_BlendState0; // 0x00
		private RenderTargetBlendState m_BlendState1; // 0x08
		private RenderTargetBlendState m_BlendState2; // 0x10
		private RenderTargetBlendState m_BlendState3; // 0x18
		private RenderTargetBlendState m_BlendState4; // 0x20
		private RenderTargetBlendState m_BlendState5; // 0x28
		private RenderTargetBlendState m_BlendState6; // 0x30
		private RenderTargetBlendState m_BlendState7; // 0x38
		private byte m_SeparateMRTBlendStates; // 0x40
		private byte m_AlphaToMask; // 0x41
		private short m_Padding; // 0x42
	
		// Methods
		public bool Equals(BlendState other) => default; // 0x000000018BEF3968-0x000000018BEF3B34
		public override bool Equals(object obj) => default; // 0x000000018BEF3B34-0x000000018BEF3BD0
		public override int GetHashCode() => default; // 0x000000018BEF3BD0-0x000000018BEF3C8C
	}

	internal struct CoreCameraValues : IEquatable<CoreCameraValues> // TypeDefIndex: 48003
	{
		// Fields
		private int filterMode; // 0x00
		private uint cullingMask; // 0x04
		private int instanceID; // 0x08
		private int uiInstanceID; // 0x0C
	
		// Methods
		public bool Equals(CoreCameraValues other) => default; // 0x0000000187841394-0x00000001878413B8
		public override bool Equals(object obj) => default; // 0x000000018BEFAD6C-0x000000018BEFADE4
		public override int GetHashCode() => default; // 0x0000000185FE7C30-0x0000000185FE7C50
	}

	public struct CameraProperties : IEquatable<CameraProperties> // TypeDefIndex: 48007
	{
		// Fields
		private Rect screenRect; // 0x00
		private Vector3 viewDir; // 0x10
		private float projectionNear; // 0x1C
		private float projectionFar; // 0x20
		private float cameraNear; // 0x24
		private float cameraFar; // 0x28
		private float cameraAspect; // 0x2C
		private Matrix4x4 cameraToWorld; // 0x30
		private Matrix4x4 actualWorldToClip; // 0x70
		private Matrix4x4 cameraClipToWorld; // 0xB0
		private Matrix4x4 cameraWorldToClip; // 0xF0
		private Matrix4x4 implicitProjection; // 0x130
		private Matrix4x4 stereoWorldToClipLeft; // 0x170
		private Matrix4x4 stereoWorldToClipRight; // 0x1B0
		private Matrix4x4 worldToCamera; // 0x1F0
		private Vector3 up; // 0x230
		private Vector3 right; // 0x23C
		private Vector3 transformDirection; // 0x248
		private Vector3 cameraEuler; // 0x254
		private Vector3 velocity; // 0x260
		private float farPlaneWorldSpaceLength; // 0x26C
		private uint rendererCount; // 0x270
		internal _m_ShadowCullPlanes_e__FixedBuffer m_ShadowCullPlanes; // 0x274
		internal _m_CameraCullPlanes_e__FixedBuffer m_CameraCullPlanes; // 0x2D4
		private float baseFarDistance; // 0x334
		private Vector3 shadowCullCenter; // 0x338
		internal _layerCullDistances_e__FixedBuffer layerCullDistances; // 0x344
		private int layerCullSpherical; // 0x3C4
		private CoreCameraValues coreCameraValues; // 0x3C8
		private uint cameraType; // 0x3D8
		private int projectionIsOblique; // 0x3DC
		private int isImplicitProjectionMatrix; // 0x3E0
	
		// Nested types
		public struct _m_ShadowCullPlanes_e__FixedBuffer // TypeDefIndex: 48004
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _m_CameraCullPlanes_e__FixedBuffer // TypeDefIndex: 48005
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _layerCullDistances_e__FixedBuffer // TypeDefIndex: 48006
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		// Methods
		public Plane GetShadowCullingPlane(int index) => default; // 0x000000018BEF57C8-0x000000018BEF58CC
		public Plane GetCameraCullingPlane(int index) => default; // 0x000000018BEF5384-0x000000018BEF5488
		public bool Equals(CameraProperties other) => default; // 0x000000018BEF3C9C-0x000000018BEF5278
		public override bool Equals(object obj) => default; // 0x000000018BEF5278-0x000000018BEF5384
		public override int GetHashCode() => default; // 0x000000018BEF5488-0x000000018BEF57C8
	}

	public enum CullingOptions // TypeDefIndex: 48008
	{
		None = 0,
		ForceEvenIfCameraIsNotActive = 1,
		OcclusionCull = 2,
		NeedsLighting = 4,
		NeedsReflectionProbes = 8,
		Stereo = 16,
		DisablePerObjectCulling = 32,
		ShadowCasters = 64
	}

	public struct ScriptableCullingParameters : IEquatable<ScriptableCullingParameters> // TypeDefIndex: 48011
	{
		// Fields
		private int m_IsOrthographic; // 0x00
		private LODParameters m_LODParameters; // 0x04
		public static readonly int maximumCullingPlaneCount; // 0x00
		internal _m_CullingPlanes_e__FixedBuffer m_CullingPlanes; // 0x20
		private int m_CullingPlaneCount; // 0xC0
		private uint m_CullingMask; // 0xC4
		private ulong m_SceneMask; // 0xC8
		public static readonly int layerCount; // 0x04
		internal _m_LayerFarCullDistances_e__FixedBuffer m_LayerFarCullDistances; // 0xD0
		private int m_LayerCull; // 0x150
		private Matrix4x4 m_CullingMatrix; // 0x154
		private Vector3 m_Origin; // 0x194
		private float m_ShadowDistance; // 0x1A0
		private float m_ShadowNearPlaneOffset; // 0x1A4
		private CullingOptions m_CullingOptions; // 0x1A8
		private ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria; // 0x1AC
		private CameraProperties m_CameraProperties; // 0x1B0
		private float m_AccurateOcclusionThreshold; // 0x594
		private int m_MaximumPortalCullingJobs; // 0x598
		private Matrix4x4 m_StereoViewMatrix; // 0x59C
		private Matrix4x4 m_StereoProjectionMatrix; // 0x5DC
		private float m_StereoSeparationDistance; // 0x61C
		private int m_maximumVisibleLights; // 0x620
		private bool m_ConservativeEnclosingSphere; // 0x624
		private int m_NumIterationsEnclosingSphere; // 0x628
		private uint m_HGCullingViewHandle; // 0x62C
		private uint m_HGCullingViewUniqueID; // 0x630
		private float m_LightCullScreenSpaceArea; // 0x634
	
		// Properties
		public int maximumVisibleLights { set {} } // 0x0000000185FE7F30-0x0000000185FE7F40
		public int cullingPlaneCount { get => default; } // 0x0000000185FE7EC0-0x0000000185FE7ED0 
		public bool isOrthographic { set {} } // 0x000000018BF00C4C-0x000000018BF00C9C
		public uint cullingMask { set {} } // 0x0000000185FC9D40-0x0000000185FC9D50
		public Matrix4x4 cullingMatrix { set {} } // 0x0000000185FE7ED0-0x0000000185FE7F00
		public float shadowDistance { set {} } // 0x0000000185FB9DD0-0x0000000185FB9DE0
		public CullingOptions cullingOptions { get => default; set {} } // 0x0000000185FE7EB0-0x0000000185FE7EC0 0x0000000185FE7F00-0x0000000185FE7F10
		public uint hgCullingViewHandle { set {} } // 0x0000000185FE7F10-0x0000000185FE7F20
		public uint hgCullingViewUniqueID { set {} } // 0x0000000185FE7F20-0x0000000185FE7F30
	
		// Nested types
		public struct _m_CullingPlanes_e__FixedBuffer // TypeDefIndex: 48009
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _m_LayerFarCullDistances_e__FixedBuffer // TypeDefIndex: 48010
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		// Constructors
		static ScriptableCullingParameters() {
			maximumCullingPlaneCount = default;
			layerCount = default;
		} // 0x0000000185F8B0F0-0x0000000185F8B140
	
		// Methods
		public float GetLayerCullingDistance(int layerIndex) => default; // 0x000000018BF00A18-0x000000018BF00B08
		public Plane GetCullingPlane(int index) => default; // 0x000000018BF006D8-0x000000018BF00830
		public void SetCullingPlane(int index, Plane plane) {} // 0x000000018BF00B08-0x000000018BF00C4C
		public bool Equals(ScriptableCullingParameters other) => default; // 0x000000018BF00048-0x000000018BF00640
		public override bool Equals(object obj) => default; // 0x000000018BF00640-0x000000018BF006D8
		public override int GetHashCode() => default; // 0x000000018BF00830-0x000000018BF00A18
	}

	public struct CullingResults : IEquatable<CullingResults> // TypeDefIndex: 48012
	{
		// Fields
		public IntPtr ptr; // 0x00
		private unsafe CullingAllocationInfo* m_AllocationInfo; // 0x08
	
		// Methods
		private static bool GetShadowCasterBounds(IntPtr cullingResultsPtr, int lightIndex, out Bounds bounds) {
			bounds = default;
			return default;
		} // 0x000000018BEFB02C-0x000000018BEFB07C
		private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) {
			viewMatrix = default;
			projMatrix = default;
			shadowSplitData = default;
			return default;
		} // 0x000000018BEFAEC0-0x000000018BEFAF28
		public bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds) {
			outBounds = default;
			return default;
		} // 0x000000018BEFB01C-0x000000018BEFB02C
		public bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) {
			viewMatrix = default;
			projMatrix = default;
			shadowSplitData = default;
			return default;
		} // 0x000000018BEFAE48-0x000000018BEFAEC0
		public bool Equals(CullingResults other) => default; // 0x000000018BEFAFA0-0x000000018BEFB01C
		public override bool Equals(object obj) => default; // 0x000000018BEFAF28-0x000000018BEFAFA0
		public override int GetHashCode() => default; // 0x00000001835DB280-0x00000001835DB290
		private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, ref Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) {
			viewMatrix = default;
			projMatrix = default;
			shadowSplitData = default;
			return default;
		} // 0x000000018BEFADE4-0x000000018BEFAE48
	}

	internal struct CullingAllocationInfo // TypeDefIndex: 48013
	{
		// Fields
		public unsafe VisibleLight* visibleLightsPtr; // 0x00
		public unsafe VisibleLight* visibleOffscreenVertexLightsPtr; // 0x08
		public unsafe VisibleReflectionProbe* visibleReflectionProbesPtr; // 0x10
		public int visibleLightCount; // 0x18
		public int visibleOffscreenVertexLightCount; // 0x1C
		public int visibleReflectionProbeCount; // 0x20
	}

	public struct DepthState : IEquatable<DepthState> // TypeDefIndex: 48014
	{
		// Fields
		private byte m_WriteEnabled; // 0x00
		private sbyte m_CompareFunction; // 0x01
	
		// Methods
		public bool Equals(DepthState other) => default; // 0x000000018BD78CD0-0x000000018BD78CE4
		public override bool Equals(object obj) => default; // 0x000000018BEFB120-0x000000018BEFB190
		public override int GetHashCode() => default; // 0x0000000185FE7C50-0x0000000185FE7C70
	}

	public struct DrawingSettings : IEquatable<DrawingSettings> // TypeDefIndex: 48016
	{
		// Fields
		public static readonly int maxShaderPasses; // 0x00
		private SortingSettings m_SortingSettings; // 0x00
		internal _shaderPassNames_e__FixedBuffer shaderPassNames; // 0xE4
		private PerObjectData m_PerObjectData; // 0x124
		private DrawRendererFlags m_Flags; // 0x128
		private int m_OverrideMaterialInstanceId; // 0x12C
		private int m_OverrideMaterialPassIndex; // 0x130
		private int m_fallbackMaterialInstanceId; // 0x134
		private int m_MainLightIndex; // 0x138
		private float m_ScreenCullingRatio; // 0x13C
		private float m_ScreenRatioCullingDistance; // 0x140
		private uint m_ScreenCullingLayerMask; // 0x144
		private int m_UseSrpBatcher; // 0x148
	
		// Properties
		public PerObjectData perObjectData { set {} } // 0x0000000185FD4F30-0x0000000185FD4F40
		public Material overrideMaterial { set {} } // 0x000000018BEFBC60-0x000000018BEFBC94
		public int overrideMaterialPassIndex { set {} } // 0x0000000185FB8070-0x0000000185FB8080
		public float screenCullingRatio { set {} } // 0x0000000185FE7C80-0x0000000185FE7C90
		public float screenRatioCullingDistance { set {} } // 0x0000000185FB8C60-0x0000000185FB8C70
		public uint screenCullingLayerMask { set {} } // 0x0000000185FE7C70-0x0000000185FE7C80
	
		// Nested types
		public struct _shaderPassNames_e__FixedBuffer // TypeDefIndex: 48015
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		// Constructors
		public DrawingSettings(ShaderTagId shaderPassName, SortingSettings sortingSettings) : this() {
			m_SortingSettings = default;
			shaderPassNames = default;
			m_PerObjectData = default;
			m_Flags = default;
			m_OverrideMaterialInstanceId = default;
			m_OverrideMaterialPassIndex = default;
			m_fallbackMaterialInstanceId = default;
			m_MainLightIndex = default;
			m_ScreenCullingRatio = default;
			m_ScreenRatioCullingDistance = default;
			m_ScreenCullingLayerMask = default;
			m_UseSrpBatcher = default;
		} // 0x000000018BEFBB08-0x000000018BEFBC60
		static DrawingSettings() {
			maxShaderPasses = default;
		} // 0x000000018BEFBACC-0x000000018BEFBB08
	
		// Methods
		public ShaderTagId GetShaderPassName(int index) => default; // 0x000000018BEFB83C-0x000000018BEFB97C
		public void SetShaderPassName(int index, ShaderTagId shaderPassName) {} // 0x000000018BEFB97C-0x000000018BEFBACC
		public bool Equals(DrawingSettings other) => default; // 0x000000018BEFB2A4-0x000000018BEFB7DC
		public override bool Equals(object obj) => default; // 0x000000018BEFB190-0x000000018BEFB2A4
		public override int GetHashCode() => default; // 0x000000018BEFB7DC-0x000000018BEFB83C
	}

	internal enum DrawRendererFlags // TypeDefIndex: 48017
	{
		None = 0,
		EnableDynamicBatching = 1,
		EnableInstancing = 2
	}

	public struct FilteringSettings : IEquatable<FilteringSettings> // TypeDefIndex: 48018
	{
		// Fields
		private RenderQueueRange m_RenderQueueRange; // 0x00
		private int m_LayerMask; // 0x08
		private uint m_RenderingLayerMask; // 0x0C
		private int m_ExcludeMotionVectorObjects; // 0x10
		private SortingLayerRange m_SortingLayerRange; // 0x14
		private short m_SortingOrderMin; // 0x18
		private short m_SortingOrderMax; // 0x1A
		private ushort m_CharacterIndex; // 0x1C
	
		// Properties
		public bool excludeMotionVectorObjects { set {} } // 0x000000018BEFBEDC-0x000000018BEFBEE8
		public SortingLayerRange sortingLayerRange { set {} } // 0x0000000185FBB0B0-0x0000000185FBB0C0
		public short sortingOrderMin { set {} } // 0x0000000185FD4B10-0x0000000185FD4B20
		public short sortingOrderMax { set {} } // 0x0000000185FD4B50-0x0000000185FD4B60
		public ushort characterIndex { set {} } // 0x0000000185FE7C90-0x0000000185FE7CA0
	
		// Constructors
		public FilteringSettings(RenderQueueRange? renderQueueRange = default, int layerMask = -1 /* Metadata: 0x02060B50 */, uint renderingLayerMask = 4294967295 /* Metadata: 0x02060B51 */, int excludeMotionVectorObjects = 0 /* Metadata: 0x02060B52 */) : this() {
			m_RenderQueueRange = default;
			m_LayerMask = default;
			m_RenderingLayerMask = default;
			m_ExcludeMotionVectorObjects = default;
			m_SortingLayerRange = default;
			m_SortingOrderMin = default;
			m_SortingOrderMax = default;
			m_CharacterIndex = default;
		} // 0x000000018BEFBE00-0x000000018BEFBEDC
	
		// Methods
		public bool Equals(FilteringSettings other) => default; // 0x000000018BEFBC94-0x000000018BEFBD24
		public override bool Equals(object obj) => default; // 0x000000018BEFBD24-0x000000018BEFBDA4
		public override int GetHashCode() => default; // 0x000000018BEFBDA4-0x000000018BEFBE00
	}

	public enum GizmoSubset // TypeDefIndex: 48019
	{
		PreImageEffects = 0,
		PostImageEffects = 1
	}

	public struct LODParameters : IEquatable<LODParameters> // TypeDefIndex: 48020
	{
		// Fields
		private int m_IsOrthographic; // 0x00
		private Vector3 m_CameraPosition; // 0x04
		private float m_FieldOfView; // 0x10
		private float m_OrthoSize; // 0x14
		private int m_CameraPixelHeight; // 0x18
	
		// Methods
		public bool Equals(LODParameters other) => default; // 0x000000018BEFC5DC-0x000000018BEFC6A0
		public override bool Equals(object obj) => default; // 0x000000018BEFC6A0-0x000000018BEFC72C
		public override int GetHashCode() => default; // 0x000000018BEFC72C-0x000000018BEFC794
	}

	public enum PerObjectData // TypeDefIndex: 48021
	{
		None = 0,
		LightProbe = 1,
		ReflectionProbes = 2,
		LightProbeProxyVolume = 4,
		Lightmaps = 8,
		LightData = 16,
		MotionVectors = 32,
		LightIndices = 64,
		ReflectionProbeData = 128,
		OcclusionProbe = 256,
		OcclusionProbeProxyVolume = 512,
		ShadowMask = 1024,
		CastShadow = 2048,
		StaticShadowCaster = 4096,
		DynamicShadowCaster = 8192,
		CullNonRealtimeShadowCaster = 16384,
		ParticleLightingIndex = 32768
	}

	public struct RasterState : IEquatable<RasterState> // TypeDefIndex: 48022
	{
		// Fields
		public static readonly RasterState defaultValue; // 0x00
		private CullMode m_CullingMode; // 0x00
		private int m_OffsetUnits; // 0x04
		private float m_OffsetFactor; // 0x08
		private byte m_DepthClip; // 0x0C
		private byte m_Conservative; // 0x0D
		private byte m_Padding1; // 0x0E
		private byte m_Padding2; // 0x0F
	
		// Constructors
		public RasterState(CullMode cullingMode = CullMode.Back /* Metadata: 0x02060B76 */, int offsetUnits = 0 /* Metadata: 0x02060B77 */, float offsetFactor = 0f /* Metadata: 0x02060B78 */, bool depthClip = true /* Metadata: 0x02060B7C */) {
			m_CullingMode = default;
			m_OffsetUnits = default;
			m_OffsetFactor = default;
			m_DepthClip = default;
			m_Conservative = default;
			m_Padding1 = default;
			m_Padding2 = default;
		} // 0x000000018BEFE334-0x000000018BEFE3AC
		static RasterState() {
			defaultValue = default;
		} // 0x000000018BEFE2D0-0x000000018BEFE334
	
		// Methods
		public bool Equals(RasterState other) => default; // 0x000000018BEFE1A0-0x000000018BEFE200
		public override bool Equals(object obj) => default; // 0x000000018BEFE200-0x000000018BEFE284
		public override int GetHashCode() => default; // 0x000000018BEFE284-0x000000018BEFE2D0
	}

	public enum ReflectionProbeSortingCriteria // TypeDefIndex: 48023
	{
		None = 0,
		Importance = 1,
		Size = 2,
		ImportanceThenSize = 3
	}

	public abstract class RenderPipeline // TypeDefIndex: 48024
	{
		// Fields
		private bool _disposed_k__BackingField; // 0x10
	
		// Properties
		public bool disposed { get; private set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
		public virtual RenderPipelineGlobalSettings defaultSettings { get; } // 0x0000000185FE67B0-0x0000000185FE67C0 
	
		// Constructors
		protected RenderPipeline() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);
		protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, List<Camera.RenderRequest> renderRequests) {} // 0x0000000185492010-0x0000000185492020
		protected static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras) {} // 0x0000000184DE0CB0-0x0000000184DE0D10
		protected static void BeginCameraRendering(ScriptableRenderContext context, Camera camera) {} // 0x0000000184EA3420-0x0000000184EA34D0
		protected static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras) {} // 0x0000000184E50420-0x0000000184E50570
		protected static void EndCameraRendering(ScriptableRenderContext context, Camera camera) {} // 0x0000000184F20360-0x0000000184F20400
		protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras) {} // 0x000000018BEFE740-0x000000018BEFE7C4
		internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras) {} // 0x0000000184F48E50-0x0000000184F48EB0
		internal void InternalRenderWithRequests(ScriptableRenderContext context, List<Camera> cameras, List<Camera.RenderRequest> renderRequests) {} // 0x000000018BEFE674-0x000000018BEFE740
		internal void Dispose() {} // 0x0000000184D09E10-0x0000000184D09E70
		protected virtual void Dispose(bool disposing) {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class RenderPipelineAsset : ScriptableObject // TypeDefIndex: 48025
	{
		// Properties
		public virtual string[] renderingLayerMaskNames { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual string[] prefixedRenderingLayerMaskNames { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Material defaultMaterial { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Shader autodeskInteractiveShader { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Shader autodeskInteractiveTransparentShader { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Shader autodeskInteractiveMaskedShader { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Shader terrainDetailLitShader { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Shader terrainDetailGrassShader { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Shader terrainDetailGrassBillboardShader { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Material defaultParticleMaterial { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Material defaultLineMaterial { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Material defaultTerrainMaterial { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Material defaultUIMaterial { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Material defaultUIOverdrawMaterial { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Material defaultUIETC1SupportedMaterial { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Material default2DMaterial { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Material default2DMaskMaterial { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Shader defaultShader { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Shader defaultSpeedTree7Shader { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Shader defaultSpeedTree8Shader { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Mesh defaultQuadMesh { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Mesh defaultPlaneMesh { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Mesh defaultCylinderMesh { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Mesh defaultCapsuleMesh { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Mesh defaultSphereMesh { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual Mesh defaultCubeMesh { get; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		protected RenderPipelineAsset() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		internal UnityEngine.Rendering.RenderPipeline InternalCreatePipeline() => default; // 0x0000000184D09B50-0x0000000184D09B80
		protected abstract UnityEngine.Rendering.RenderPipeline CreatePipeline();
		protected virtual void OnValidate() {} // 0x000000018BEFE3AC-0x000000018BEFE444
		protected virtual void OnDisable() {} // 0x0000000184D09890-0x0000000184D098D0
	}

	public abstract class RenderPipelineGlobalSettings : ScriptableObject // TypeDefIndex: 48026
	{
		// Constructors
		protected RenderPipelineGlobalSettings() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	}

	public static class RenderPipelineManager // TypeDefIndex: 48027
	{
		// Fields
		internal static RenderPipelineAsset s_CurrentPipelineAsset; // 0x00
		private static List<Camera> s_Cameras; // 0x08
		private static string s_currentPipelineType; // 0x10
		private static UnityEngine.Rendering.RenderPipeline s_currentPipeline; // 0x18
		private static Action<ScriptableRenderContext, List<Camera>> beginContextRendering; // 0x20
		private static Action<ScriptableRenderContext, List<Camera>> endContextRendering; // 0x28
		private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering; // 0x30
		private static Action<ScriptableRenderContext, Camera> beginCameraRendering; // 0x38
		private static Action<ScriptableRenderContext, Camera[]> endFrameRendering; // 0x40
		private static Action<ScriptableRenderContext, Camera> endCameraRendering; // 0x48
		private static Action<ScriptableRenderContext, List<Camera>> beginFrameRenderingNoAlloc; // 0x50
		private static Action<ScriptableRenderContext, List<Camera>> endFrameRenderingNoAlloc; // 0x58
		private static Action activeRenderPipelineTypeChanged; // 0x60
		private static Action activeRenderPipelineCreated; // 0x68
		private static Action activeRenderPipelineDisposed; // 0x70
	
		// Properties
		public static UnityEngine.Rendering.RenderPipeline currentPipeline { get; private set; } // 0x000000018BEFE55C-0x000000018BEFE5AC 0x0000000184D09B80-0x0000000184D09C80
	
		// Events
		public static event Action<ScriptableRenderContext, Camera> beginCameraRendering;
		public static event Action<ScriptableRenderContext, Camera> endCameraRendering;
		public static event Action<ScriptableRenderContext, List<Camera>> beginFrameRenderingNoAlloc;
	
		// Constructors
		static RenderPipelineManager() {} // 0x000000018448F580-0x000000018448F680
	
		// Methods
		internal static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras) {} // 0x0000000184DE0D10-0x0000000184DE0E20
		internal static void BeginCameraRendering(ScriptableRenderContext context, Camera camera) {} // 0x0000000184EA34D0-0x0000000184EA3550
		internal static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras) {} // 0x0000000184E50570-0x0000000184E50660
		internal static void EndCameraRendering(ScriptableRenderContext context, Camera camera) {} // 0x0000000184F20400-0x0000000184F20470
		internal static void OnActiveRenderPipelineTypeChanged() {} // 0x000000018BEFE444-0x000000018BEFE494
		internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) {} // 0x0000000184D09AB0-0x0000000184D09B50
		internal static void CleanupRenderPipeline() {} // 0x0000000184D09C80-0x0000000184D09E10
		private static string GetCurrentPipelineAssetType() => default; // 0x0000000185121E90-0x0000000185121EF0
		private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, List<Camera.RenderRequest> renderRequests) {} // 0x000000018429F4E0-0x000000018429F970
		internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) {} // 0x0000000184D09940-0x0000000184D09AB0
		private static bool IsPipelineRequireCreation() => default; // 0x000000018429F040-0x000000018429F1E0
	}

	public struct RenderQueueRange : IEquatable<RenderQueueRange> // TypeDefIndex: 48028
	{
		// Fields
		private int m_LowerBound; // 0x00
		private int m_UpperBound; // 0x04
		public static readonly int minimumBound; // 0x00
		public static readonly int maximumBound; // 0x04
	
		// Properties
		public static RenderQueueRange all { get => default; } // 0x0000000185FE7CC0-0x0000000185FE7CE0 
		public int lowerBound { get => default; set {} } // 0x0000000185FE64F0-0x0000000185FE6500 0x000000018BEFE890-0x000000018BEFE95C
		public int upperBound { get => default; set {} } // 0x0000000185FCA560-0x0000000185FCA570 0x000000018BEFE95C-0x000000018BEFEA28
	
		// Constructors
		static RenderQueueRange() {
			minimumBound = default;
			maximumBound = default;
		} // 0x000000018BEFE840-0x000000018BEFE890
	
		// Methods
		public bool Equals(RenderQueueRange other) => default; // 0x0000000187333DF8-0x0000000187333E0C
		public override bool Equals(object obj) => default; // 0x000000018BEFE7C4-0x000000018BEFE840
		public override int GetHashCode() => default; // 0x0000000185FE7CB0-0x0000000185FE7CC0
	}

	public struct RenderStateBlock : IEquatable<RenderStateBlock> // TypeDefIndex: 48029
	{
		// Fields
		private BlendState m_BlendState; // 0x00
		private RasterState m_RasterState; // 0x44
		private DepthState m_DepthState; // 0x54
		private StencilState m_StencilState; // 0x56
		private int m_StencilReference; // 0x64
		private RenderStateMask m_Mask; // 0x68
	
		// Methods
		public bool Equals(RenderStateBlock other) => default; // 0x000000018BEFEA28-0x000000018BEFEB9C
		public override bool Equals(object obj) => default; // 0x000000018BEFEB9C-0x000000018BEFEC60
		public override int GetHashCode() => default; // 0x000000018BEFEC60-0x000000018BEFED18
	}

	public enum RenderStateMask // TypeDefIndex: 48030
	{
		Nothing = 0,
		Blend = 1,
		Raster = 2,
		Depth = 4,
		Stencil = 8,
		Everything = 15
	}

	public struct RenderTargetBlendState : IEquatable<RenderTargetBlendState> // TypeDefIndex: 48031
	{
		// Fields
		private byte m_WriteMask; // 0x00
		private byte m_SourceColorBlendMode; // 0x01
		private byte m_DestinationColorBlendMode; // 0x02
		private byte m_SourceAlphaBlendMode; // 0x03
		private byte m_DestinationAlphaBlendMode; // 0x04
		private byte m_ColorBlendOperation; // 0x05
		private byte m_AlphaBlendOperation; // 0x06
		private byte m_Padding; // 0x07
	
		// Methods
		public bool Equals(RenderTargetBlendState other) => default; // 0x000000018BEFED80-0x000000018BEFEDD0
		public override bool Equals(object obj) => default; // 0x000000018BEFEDD0-0x000000018BEFEE40
		public override int GetHashCode() => default; // 0x0000000185FE7D50-0x0000000185FE7DB0
	}

	public struct CBHandle // TypeDefIndex: 48032
	{
		// Fields
		public uint bufferId; // 0x00
		public uint offset; // 0x04
		public uint size; // 0x08
		public IntPtr ptr; // 0x10
	}

	public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 48033
	{
		// Fields
		private static readonly ShaderTagId kRenderTypeTag; // 0x00
		private IntPtr m_Ptr; // 0x00
	
		// Constructors
		internal ScriptableRenderContext(IntPtr ptr) {
			m_Ptr = default;
		} // 0x0000000185FB2BB0-0x0000000185FB2BC0
		static ScriptableRenderContext() {
			kRenderTypeTag = default;
		} // 0x000000018579EF30-0x000000018579EF80
	
		// Methods
		private static void BeginRenderPass_Internal(IntPtr self, int width, int height, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex) {} // 0x000000018BF00C9C-0x000000018BF00CFC
		private static void BeginSubPass_Internal(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly) {} // 0x000000018BF00DB8-0x000000018BF00E1C
		private static void EndSubPass_Internal(IntPtr self) {} // 0x000000018BF01A90-0x000000018BF01AC4
		private static void EndRenderPass_Internal(IntPtr self) {} // 0x000000018BF01A10-0x000000018BF01A44
		private static void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) {} // 0x0000000184DE2020-0x0000000184DE20B0
		internal static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings) {
			sortingSettings = default;
		} // 0x000000018BF01F78-0x000000018BF01FBC
		private void Submit_Internal() {} // 0x0000000184F0E5D0-0x0000000184F0E650
		private void GetCameras_Internal(System.Type listType, object resultList) {} // 0x0000000184DE0BB0-0x0000000184DE0C50
		private void DrawRenderers_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) {} // 0x000000018BF016B8-0x000000018BF0176C
		private void DrawShadows_Internal(IntPtr shadowDrawingSettings) {} // 0x000000018BF01924-0x000000018BF01980
		public static void EmitGeometryForCamera(Camera camera) {} // 0x000000018BF019DC-0x000000018BF01A10
		public CBHandle AllocateConstantBuffer(int size) => default; // 0x0000000184BB4270-0x0000000184BB4310
		private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer) {} // 0x00000001840C39C0-0x00000001840C3A50
		private void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType) {} // 0x000000018BF01E04-0x000000018BF01E64
		private void ExecuteCommandBufferNoCopy_Internal(CommandBuffer commandBuffer) {} // 0x000000018451C7E0-0x000000018451C870
		private void ExecuteCommandBufferAsyncNoCopy_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType) {} // 0x000000018BF01C3C-0x000000018BF01C9C
		private void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye) {} // 0x000000018BF02314-0x000000018BF02388
		private void DrawGizmos_Internal(Camera camera, GizmoSubset gizmoSubset) {} // 0x000000018BF01594-0x000000018BF015F4
		private UnityEngine.Rendering.RendererUtils.RendererList CreateRendererList_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount, IntPtr drawableFeedbackPtr) => default; // 0x000000018BF00FC0-0x000000018BF01094
		private void PrepareRendererListsAsync_Internal(object rendererLists) {} // 0x000000018BF02000-0x000000018BF0205C
		private RendererListStatus QueryRendererListStatus_Internal(UnityEngine.Rendering.RendererUtils.RendererList handle) => default; // 0x000000018BF021F8-0x000000018BF02254
		private int QueryRendererListObjCount_Internal(UnityEngine.Rendering.RendererUtils.RendererList handle) => default; // 0x000000018BF020FC-0x000000018BF02158
		public void BeginRenderPass(int width, int height, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex = -1 /* Metadata: 0x02060B87 */) {} // 0x000000018BF00CFC-0x000000018BF00DB8
		public void BeginSubPass(NativeArray<int> colors, NativeArray<int> inputs, bool isDepthStencilReadOnly = false /* Metadata: 0x02060B88 */) {} // 0x000000018BF00E1C-0x000000018BF00EC8
		public void BeginSubPass(NativeArray<int> colors, bool isDepthStencilReadOnly = false /* Metadata: 0x02060B89 */) {} // 0x000000018BF00EC8-0x000000018BF00F58
		public void EndSubPass() {} // 0x000000018BF01AC4-0x000000018BF01B10
		public void EndRenderPass() {} // 0x000000018BF01A44-0x000000018BF01A90
		public void Submit() {} // 0x0000000184F0E520-0x0000000184F0E5D0
		internal void GetCameras(List<Camera> results) {} // 0x0000000184DE0A80-0x0000000184DE0BB0
		public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings) {} // 0x000000018BF0176C-0x000000018BF01824
		public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock stateBlock) {} // 0x000000018BF01824-0x000000018BF018E0
		public void DrawShadows(ref ShadowDrawingSettings settings) {} // 0x000000018BF01980-0x000000018BF019DC
		public void ExecuteCommandBuffer(CommandBuffer commandBuffer) {} // 0x00000001840C38E0-0x00000001840C39C0
		public void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType) {} // 0x000000018BF01E64-0x000000018BF01F78
		public void ExecuteCommandBufferNoCopy(CommandBuffer commandBuffer) {} // 0x000000018451C700-0x000000018451C7E0
		public void ExecuteCommandBufferAsyncNoCopy(CommandBuffer commandBuffer, ComputeQueueType queueType) {} // 0x000000018BF01C9C-0x000000018BF01DB0
		public void SetupCameraProperties(Camera camera, bool stereoSetup = false /* Metadata: 0x02060B8A */) {} // 0x000000018BF023FC-0x000000018BF02464
		public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye) {} // 0x000000018BF02388-0x000000018BF023FC
		public void DrawGizmos(Camera camera, GizmoSubset gizmoSubset) {} // 0x000000018BF015F4-0x000000018BF01654
		public CullingResults Cull(ref ScriptableCullingParameters parameters) => default; // 0x0000000184DE1F20-0x0000000184DE2020
		public bool Equals(ScriptableRenderContext other) => default; // 0x000000018BF01B8C-0x000000018BF01BE8
		public override bool Equals(object obj) => default; // 0x000000018BF01B10-0x000000018BF01B8C
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public UnityEngine.Rendering.RendererUtils.RendererList CreateRendererList(UnityEngine.Rendering.RendererUtils.RendererListDesc desc) => default; // 0x000000018BF01094-0x000000018BF01540
		public void PrepareRendererListsAsync(List<UnityEngine.Rendering.RendererUtils.RendererList> rendererLists) {} // 0x000000018BF0205C-0x000000018BF020B8
		public RendererListStatus QueryRendererListStatus(UnityEngine.Rendering.RendererUtils.RendererList rendererList) => default; // 0x000000018BF02254-0x000000018BF022B0
		public int QueryRendererListObjCount(UnityEngine.Rendering.RendererUtils.RendererList rendererList) => default; // 0x000000018BF02158-0x000000018BF021B4
		public IntPtr GetNativePtr() => default; // 0x0000000184142CB0-0x0000000184142CC0
		private static void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, ref ScriptableRenderContext renderLoop, IntPtr results) {} // 0x0000000184DE20B0-0x0000000184DE2110
		private static void Submit_Internal_Injected(ref ScriptableRenderContext _unity_self) {} // 0x0000000184F0E650-0x0000000184F0E690
		private static void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, System.Type listType, object resultList) {} // 0x0000000184DE0C50-0x0000000184DE0CB0
		private static void DrawRenderers_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) {} // 0x000000018BF01654-0x000000018BF016B8
		private static void DrawShadows_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawingSettings) {} // 0x000000018BF018E0-0x000000018BF01924
		private static void AllocateConstantBuffer_Injected(ref ScriptableRenderContext _unity_self, int size, out CBHandle ret) {
			ret = default;
		} // 0x0000000184BB4310-0x0000000184BB4370
		private static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer) {} // 0x00000001840C3A50-0x00000001840C3AA0
		private static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer, ComputeQueueType queueType) {} // 0x000000018BF01DB0-0x000000018BF01E04
		private static void ExecuteCommandBufferNoCopy_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer) {} // 0x000000018451C870-0x000000018451C8C0
		private static void ExecuteCommandBufferAsyncNoCopy_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer, ComputeQueueType queueType) {} // 0x000000018BF01BE8-0x000000018BF01C3C
		private static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye) {} // 0x000000018BF022B0-0x000000018BF02314
		private static void DrawGizmos_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, GizmoSubset gizmoSubset) {} // 0x000000018BF01540-0x000000018BF01594
		private static void CreateRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount, IntPtr drawableFeedbackPtr, out UnityEngine.Rendering.RendererUtils.RendererList ret) {
			ret = default;
		} // 0x000000018BF00F58-0x000000018BF00FC0
		private static void PrepareRendererListsAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, object rendererLists) {} // 0x000000018BF01FBC-0x000000018BF02000
		private static RendererListStatus QueryRendererListStatus_Internal_Injected(ref ScriptableRenderContext _unity_self, ref UnityEngine.Rendering.RendererUtils.RendererList handle) => default; // 0x000000018BF021B4-0x000000018BF021F8
		private static int QueryRendererListObjCount_Internal_Injected(ref ScriptableRenderContext _unity_self, ref UnityEngine.Rendering.RendererUtils.RendererList handle) => default; // 0x000000018BF020B8-0x000000018BF020FC
	}

	public struct ShaderTagId : IEquatable<ShaderTagId> // TypeDefIndex: 48034
	{
		// Fields
		public static readonly ShaderTagId none; // 0x00
		private int m_Id; // 0x00
	
		// Properties
		internal int id { get => default; set {} } // 0x0000000185FE64F0-0x0000000185FE6500 0x00000001818AA390-0x00000001818AA3A0
	
		// Constructors
		public ShaderTagId(string name) : this() {
			m_Id = default;
		} // 0x00000001864744CC-0x00000001864744EC
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BF02464-0x000000018BF024C8
		public bool Equals(ShaderTagId other) => default; // 0x0000000183FAA6E0-0x0000000183FAA6F0
		public override int GetHashCode() => default; // 0x0000000185FE7F40-0x0000000185FE7F50
		public static bool operator ==(ShaderTagId tag1, ShaderTagId tag2) => default; // 0x0000000188645D08-0x0000000188645D10
		public static bool operator !=(ShaderTagId tag1, ShaderTagId tag2) => default; // 0x000000018BEECDB4-0x000000018BEECDBC
	}

	public struct ShadowDrawingSettings : IEquatable<ShadowDrawingSettings> // TypeDefIndex: 48035
	{
		// Fields
		private CullingResults m_CullingResults; // 0x00
		private int m_LightIndex; // 0x10
		private int m_UseRenderingLayerMaskTest; // 0x14
		private ShadowSplitData m_SplitData; // 0x18
		private ShadowObjectsFilter m_ObjectsFilter; // 0xD4
		private bool m_CullNonRealtimeCasters; // 0xD8
	
		// Properties
		public bool useRenderingLayerMaskTest { set {} } // 0x000000018BF02AC0-0x000000018BF02ACC
		public ShadowSplitData splitData { set {} } // 0x0000000185FE7F50-0x0000000185FE7FD0
		public ShadowObjectsFilter objectsFilter { set {} } // 0x0000000185FB2440-0x0000000185FB2450
		public bool cullNonRealtimeCasters { set {} } // 0x0000000185FB2670-0x0000000185FB2680
	
		// Constructors
		public ShadowDrawingSettings(CullingResults cullingResults, int lightIndex) : this() {
			m_CullingResults = default;
			m_LightIndex = default;
			m_UseRenderingLayerMaskTest = default;
			m_SplitData = default;
			m_ObjectsFilter = default;
			m_CullNonRealtimeCasters = default;
		} // 0x000000018BF02A2C-0x000000018BF02AC0
	
		// Methods
		public bool Equals(ShadowDrawingSettings other) => default; // 0x000000018BF024C8-0x000000018BF028B0
		public override bool Equals(object obj) => default; // 0x000000018BF028B0-0x000000018BF029B0
		public override int GetHashCode() => default; // 0x000000018BF029B0-0x000000018BF02A2C
	}

	public struct ShadowSplitData : IEquatable<ShadowSplitData> // TypeDefIndex: 48037
	{
		// Fields
		private const int k_MaximumCullingPlaneCount = 10; // Metadata: 0x02060B8B
		public static readonly int maximumCullingPlaneCount; // 0x00
		private int m_CullingPlaneCount; // 0x00
		public _m_CullingPlanes_e__FixedBuffer m_CullingPlanes; // 0x04
		private Vector4 m_CullingSphere; // 0xA4
		private float m_ShadowCascadeBlendCullingFactor; // 0xB4
		private float m_CullingNearPlane; // 0xB8
	
		// Properties
		public int cullingPlaneCount { get => default; set {} } // 0x0000000185FE64F0-0x0000000185FE6500 0x000000018BF02FC4-0x000000018BF030C0
		public Vector4 cullingSphere { get => default; } // 0x0000000185FE7FD0-0x0000000185FE7FE0 
		public float shadowCascadeBlendCullingFactor { set {} } // 0x000000018BF030C0-0x000000018BF031D8
	
		// Nested types
		public struct _m_CullingPlanes_e__FixedBuffer // TypeDefIndex: 48036
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Constructors
		static ShadowSplitData() {
			maximumCullingPlaneCount = default;
		} // 0x000000018BF02F88-0x000000018BF02FC4
	
		// Methods
		public Plane GetCullingPlane(int index) => default; // 0x000000018BF02DF0-0x000000018BF02F64
		public bool Equals(ShadowSplitData other) => default; // 0x000000018BF02BCC-0x000000018BF02DF0
		public override bool Equals(object obj) => default; // 0x000000018BF02ACC-0x000000018BF02BCC
		public override int GetHashCode() => default; // 0x000000018BF02F64-0x000000018BF02F88
	}

	public enum SortingCriteria // TypeDefIndex: 48038
	{
		None = 0,
		SortingLayer = 1,
		RenderQueue = 2,
		BackToFront = 4,
		QuantizedFrontToBack = 8,
		OptimizeStateChanges = 16,
		CommonTransparent = 23,
		CanvasOrder = 32,
		CommonOpaque = 59,
		RendererPriority = 64
	}

	public struct SortingLayerRange : IEquatable<SortingLayerRange> // TypeDefIndex: 48039
	{
		// Fields
		private short m_LowerBound; // 0x00
		private short m_UpperBound; // 0x02
	
		// Properties
		public static SortingLayerRange all { get => default; } // 0x0000000185FE7FF0-0x0000000185FE8000 
	
		// Constructors
		public SortingLayerRange(short lowerBound, short upperBound) : this() {
			m_LowerBound = default;
			m_UpperBound = default;
		} // 0x0000000185FCFBE0-0x0000000185FCFBF0
	
		// Methods
		public bool Equals(SortingLayerRange other) => default; // 0x000000018BD8B2A4-0x000000018BD8B2B8
		public override bool Equals(object obj) => default; // 0x000000018BF031D8-0x000000018BF03244
		public override int GetHashCode() => default; // 0x0000000185FE7FE0-0x0000000185FE7FF0
	}

	public enum DistanceMetric // TypeDefIndex: 48040
	{
		Perspective = 0,
		Orthographic = 1,
		CustomAxis = 2
	}

	public struct SortingSettings : IEquatable<SortingSettings> // TypeDefIndex: 48041
	{
		// Fields
		private Matrix4x4 m_WorldToCameraMatrix; // 0x00
		private Vector3 m_CameraPosition; // 0x40
		private Vector3 m_CustomAxis; // 0x4C
		private SortingCriteria m_Criteria; // 0x58
		private DistanceMetric m_DistanceMetric; // 0x5C
		private Matrix4x4 m_PreviousVPMatrix; // 0x60
		private Matrix4x4 m_NonJitteredVPMatrix; // 0xA0
		private float m_FOV; // 0xE0
	
		// Properties
		public SortingCriteria criteria { get => default; set {} } // 0x0000000185FE8000-0x0000000185FE8010 0x0000000183F804E0-0x0000000183F804F0
	
		// Constructors
		public SortingSettings(Camera camera) : this() {
			m_WorldToCameraMatrix = default;
			m_CameraPosition = default;
			m_CustomAxis = default;
			m_Criteria = default;
			m_DistanceMetric = default;
			m_PreviousVPMatrix = default;
			m_NonJitteredVPMatrix = default;
			m_FOV = default;
		} // 0x000000018BF038B0-0x000000018BF0390C
	
		// Methods
		public bool Equals(SortingSettings other) => default; // 0x000000018BF03244-0x000000018BF03724
		public override bool Equals(object obj) => default; // 0x000000018BF03724-0x000000018BF03828
		public override int GetHashCode() => default; // 0x000000018BF03828-0x000000018BF038B0
	}

	public struct StencilState : IEquatable<StencilState> // TypeDefIndex: 48042
	{
		// Fields
		private byte m_Enabled; // 0x00
		private byte m_ReadMask; // 0x01
		private byte m_WriteMask; // 0x02
		private byte m_Padding; // 0x03
		private byte m_CompareFunctionFront; // 0x04
		private byte m_PassOperationFront; // 0x05
		private byte m_FailOperationFront; // 0x06
		private byte m_ZFailOperationFront; // 0x07
		private byte m_CompareFunctionBack; // 0x08
		private byte m_PassOperationBack; // 0x09
		private byte m_FailOperationBack; // 0x0A
		private byte m_ZFailOperationBack; // 0x0B
	
		// Properties
		public bool enabled { set {} } // 0x000000018BF0430C-0x000000018BF0435C
		public byte readMask { set {} } // 0x00000001838F1DE0-0x00000001838F1DF0
		public byte writeMask { set {} } // 0x0000000185FBD060-0x0000000185FBD070
		public CompareFunction compareFunctionFront { set {} } // 0x0000000185FBF450-0x0000000185FBF460
		public StencilOp passOperationFront { set {} } // 0x0000000185FBF5D0-0x0000000185FBF5E0
		public StencilOp failOperationFront { set {} } // 0x0000000185FBF5B0-0x0000000185FBF5C0
		public StencilOp zFailOperationFront { set {} } // 0x0000000185FBF5C0-0x0000000185FBF5D0
		public CompareFunction compareFunctionBack { set {} } // 0x0000000185FB6A90-0x0000000185FB6AA0
		public StencilOp passOperationBack { set {} } // 0x0000000185FE86F0-0x0000000185FE8700
		public StencilOp failOperationBack { set {} } // 0x0000000185FE86E0-0x0000000185FE86F0
		public StencilOp zFailOperationBack { set {} } // 0x0000000185FE8700-0x0000000185FE8710
	
		// Methods
		public bool Equals(StencilState other) => default; // 0x000000018BF04230-0x000000018BF0428C
		public override bool Equals(object obj) => default; // 0x000000018BF0428C-0x000000018BF0430C
		public override int GetHashCode() => default; // 0x0000000185FE8650-0x0000000185FE86E0
	}

	public class SupportedRenderingFeatures // TypeDefIndex: 48045
	{
		// Fields
		private static SupportedRenderingFeatures s_Active; // 0x00
		private ReflectionProbeModes _reflectionProbeModes_k__BackingField; // 0x10
		private LightmapMixedBakeModes _defaultMixedLightingModes_k__BackingField; // 0x14
		private LightmapMixedBakeModes _mixedLightingModes_k__BackingField; // 0x18
		private LightmapBakeType _lightmapBakeTypes_k__BackingField; // 0x1C
		private LightmapsMode _lightmapsModes_k__BackingField; // 0x20
		private bool _enlightenLightmapper_k__BackingField; // 0x24
		private bool _enlighten_k__BackingField; // 0x25
		private bool _lightProbeProxyVolumes_k__BackingField; // 0x26
		private bool _motionVectors_k__BackingField; // 0x27
		private bool _receiveShadows_k__BackingField; // 0x28
		private bool _reflectionProbes_k__BackingField; // 0x29
		private bool _reflectionProbesBlendDistance_k__BackingField; // 0x2A
		private bool _rendererPriority_k__BackingField; // 0x2B
		private bool _rendersUIOverlay_k__BackingField; // 0x2C
		private bool _overridesEnvironmentLighting_k__BackingField; // 0x2D
		private bool _overridesFog_k__BackingField; // 0x2E
		private bool _overridesRealtimeReflectionProbes_k__BackingField; // 0x2F
		private bool _overridesOtherLightingSettings_k__BackingField; // 0x30
		private bool _editableMaterialRenderQueue_k__BackingField; // 0x31
		private bool _overridesLODBias_k__BackingField; // 0x32
		private bool _overridesMaximumLODLevel_k__BackingField; // 0x33
		private bool _rendererProbes_k__BackingField; // 0x34
		private bool _particleSystemInstancing_k__BackingField; // 0x35
		private bool _autoAmbientProbeBaking_k__BackingField; // 0x36
		private bool _autoDefaultReflectionProbeBaking_k__BackingField; // 0x37
		private bool _overridesShadowmask_k__BackingField; // 0x38
		private string _overrideShadowmaskMessage_k__BackingField; // 0x40
	
		// Properties
		public static SupportedRenderingFeatures active { get => default; set {} } // 0x0000000184EBA900-0x0000000184EBA990 0x0000000184D09E70-0x0000000184D09EE0
		public ReflectionProbeModes reflectionProbeModes { get; set; } // 0x0000000181378230-0x0000000181378240
		public LightmapMixedBakeModes defaultMixedLightingModes { get; set; } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
		public LightmapMixedBakeModes mixedLightingModes { get; set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public LightmapBakeType lightmapBakeTypes { get; set; } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
		public LightmapsMode lightmapsModes { get; set; } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public bool enlightenLightmapper { get; set; } // 0x0000000185FB0810-0x0000000185FB0820 0x0000000185FB0820-0x0000000185FB0830
		public bool enlighten { get; set; } // 0x0000000185FB0860-0x0000000185FB0870 0x0000000185FB0880-0x0000000185FB0890
		public bool lightProbeProxyVolumes { get; set; } // 0x0000000185FB0890-0x0000000185FB08A0
		public bool motionVectors { get; set; } // 0x0000000185FE8810-0x0000000185FE8820
		public bool receiveShadows { get; set; } // 0x00000001813B4840-0x00000001813B4850
		public bool reflectionProbes { get; set; } // 0x00000001813B4850-0x00000001813B4860
		public bool rendererPriority { get; set; } // 0x0000000185FB0AE0-0x0000000185FB0AF0
		public bool rendersUIOverlay { get; set; } // 0x0000000185FB08C0-0x0000000185FB08D0 0x0000000185FB08D0-0x0000000185FB08E0
		public bool overridesFog { get; set; } // 0x0000000185FBA480-0x0000000185FBA490
		public bool overridesRealtimeReflectionProbes { get; set; } // 0x0000000185FD46D0-0x0000000185FD46E0
		public bool overridesOtherLightingSettings { get; set; } // 0x000000018142A360-0x000000018142A370
		public bool editableMaterialRenderQueue { get; set; } // 0x0000000185FB0990-0x0000000185FB09A0
		public bool overridesLODBias { get; set; } // 0x0000000185FB0C50-0x0000000185FB0C60
		public bool overridesMaximumLODLevel { get; set; } // 0x0000000185FD5CA0-0x0000000185FD5CB0
		public bool autoAmbientProbeBaking { get; set; } // 0x0000000185FE87E0-0x0000000185FE87F0 0x0000000185FE6780-0x0000000185FE6790
		public bool autoDefaultReflectionProbeBaking { get; set; } // 0x0000000185FE87F0-0x0000000185FE8800 0x0000000185FE8800-0x0000000185FE8810
		public bool overridesShadowmask { get; set; } // 0x0000000185FAFE20-0x0000000185FAFE30
		public string overrideShadowmaskMessage { get; set; } // 0x0000000185F05C80-0x0000000185F05C90
	
		// Nested types
		public enum ReflectionProbeModes // TypeDefIndex: 48043
		{
			None = 0,
			Rotation = 1
		}
	
		public enum LightmapMixedBakeModes // TypeDefIndex: 48044
		{
			None = 0,
			IndirectOnly = 1,
			Subtractive = 2,
			Shadowmask = 4
		}
	
		// Constructors
		public SupportedRenderingFeatures() {} // 0x0000000184D09EE0-0x0000000184D09F60
		static SupportedRenderingFeatures() {} // 0x0000000184D098D0-0x0000000184D09940
	
		// Methods
		internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) {} // 0x000000018BF0A038-0x000000018BF0A168
		internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) => default; // 0x000000018BF0A4BC-0x000000018BF0A50C
		internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) {} // 0x000000018BF0A3E4-0x000000018BF0A4BC
		internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) => default; // 0x000000018BF0A2CC-0x000000018BF0A31C
		internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) {} // 0x000000018BF0A208-0x000000018BF0A2CC
		internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) {} // 0x000000018BF0A384-0x000000018BF0A3E4
		internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) {} // 0x000000018BF0A31C-0x000000018BF0A384
		internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) {} // 0x0000000184EBA8A0-0x0000000184EBA900
		internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr) {} // 0x000000018BF0A168-0x000000018BF0A1B8
		internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) {} // 0x000000018BF0A1B8-0x000000018BF0A208
		internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) {} // 0x0000000185FE87D0-0x0000000185FE87E0
	}

	public struct VisibleLight : IEquatable<VisibleLight> // TypeDefIndex: 48046
	{
		// Fields
		private LightType m_LightType; // 0x00
		private UnityEngine.Color m_FinalColor; // 0x04
		private Rect m_ScreenRect; // 0x14
		private Matrix4x4 m_LocalToWorldMatrix; // 0x24
		private float m_SpecularIntensity; // 0x64
		private float m_Range; // 0x68
		private float m_SpotAngle; // 0x6C
		private int m_LightPriority; // 0x70
		private Vector3 m_WorldPosition; // 0x74
		private int m_InstanceId; // 0x80
		private VisibleLightFlags m_Flags; // 0x84
		public HGSharedLightData hgSharedLightData; // 0x88
		private float m_ScreenSpaceArea; // 0x90
	
		// Properties
		public Light light { get => default; } // 0x000000018BF0AED8-0x000000018BF0AF58 
		public LightType lightType { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
		public UnityEngine.Color finalColor { get => default; } // 0x0000000185FE8820-0x0000000185FE8830 
		public Matrix4x4 localToWorldMatrix { get => default; } // 0x0000000185FE8840-0x0000000185FE8870 
		public float range { get => default; } // 0x0000000185FE8870-0x0000000185FE8880 
		public float spotAngle { get => default; } // 0x0000000185FE8880-0x0000000185FE8890 
		public int lightPriority { get => default; } // 0x0000000185FE8830-0x0000000185FE8840 
		public Vector3 worldPosition { get => default; } // 0x0000000185FE8890-0x0000000185FE88B0 
	
		// Methods
		public bool Equals(VisibleLight other) => default; // 0x000000018BF0A978-0x000000018BF0AD68
		public override bool Equals(object obj) => default; // 0x000000018BF0AD68-0x000000018BF0AE38
		public override int GetHashCode() => default; // 0x000000018BF0AE38-0x000000018BF0AED8
	}

	internal enum VisibleLightFlags // TypeDefIndex: 48047
	{
		IntersectsNearPlane = 1,
		IntersectsFarPlane = 2
	}

	public struct VisibleReflectionProbe : IEquatable<VisibleReflectionProbe> // TypeDefIndex: 48048
	{
		// Fields
		private Bounds m_Bounds; // 0x00
		private Matrix4x4 m_LocalToWorldMatrix; // 0x18
		private Vector4 m_HdrData; // 0x58
		private Vector3 m_Center; // 0x68
		private float m_BlendDistance; // 0x74
		private int m_Importance; // 0x78
		private int m_BoxProjection; // 0x7C
		private int m_InstanceId; // 0x80
		private int m_TextureId; // 0x84
	
		// Methods
		public bool Equals(VisibleReflectionProbe other) => default; // 0x000000018BF0B020-0x000000018BF0B420
		public override bool Equals(object obj) => default; // 0x000000018BF0AF58-0x000000018BF0B020
		public override int GetHashCode() => default; // 0x000000018BF0B420-0x000000018BF0B4C4
	}

	public struct GlobalKeyword // TypeDefIndex: 48049
	{
		// Fields
		internal readonly string m_Name; // 0x00
		internal readonly uint m_Index; // 0x08
	
		// Properties
		public string name { get => default; } // 0x0000000184142CB0-0x0000000184142CC0 
	
		// Constructors
		public GlobalKeyword(string name) : this() {
			m_Name = default;
			m_Index = default;
		} // 0x000000018BF05648-0x000000018BF0571C
	
		// Methods
		private static uint GetGlobalKeywordCount() => default; // 0x000000018BF055E8-0x000000018BF05614
		private static uint GetGlobalKeywordIndex(string keyword) => default; // 0x000000018BF05614-0x000000018BF05648
		private static void CreateGlobalKeyword(string keyword) {} // 0x000000018BF05564-0x000000018BF05598
		public static GlobalKeyword Create(string name) => default; // 0x000000018BF05598-0x000000018BF055E8
		public override string ToString() => default; // 0x0000000184142CB0-0x0000000184142CC0
	}

	public struct LocalKeyword : IEquatable<LocalKeyword> // TypeDefIndex: 48050
	{
		// Fields
		internal readonly LocalKeywordSpace m_SpaceInfo; // 0x00
		internal readonly string m_Name; // 0x08
		internal readonly uint m_Index; // 0x10
	
		// Constructors
		public LocalKeyword(Shader shader, string name) {
			m_SpaceInfo = default;
			m_Name = default;
			m_Index = default;
		} // 0x000000018BF06F3C-0x000000018BF07090
		public LocalKeyword(ComputeShader shader, string name) {
			m_SpaceInfo = default;
			m_Name = default;
			m_Index = default;
		} // 0x00000001844907F0-0x0000000184490900
	
		// Methods
		private static uint GetShaderKeywordCount(Shader shader) => default; // 0x000000018BF06EC4-0x000000018BF06EF8
		private static uint GetShaderKeywordIndex(Shader shader, string keyword) => default; // 0x000000018BF06EF8-0x000000018BF06F3C
		private static uint GetComputeShaderKeywordCount(ComputeShader shader) => default; // 0x0000000184490960-0x00000001844909A0
		private static uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword) => default; // 0x00000001844909A0-0x00000001844909F0
		public override string ToString() => default; // 0x0000000185FE6720-0x0000000185FE6730
		public override bool Equals(object o) => default; // 0x000000018BF06E08-0x000000018BF06E8C
		public bool Equals(LocalKeyword rhs) => default; // 0x000000018BF06E8C-0x000000018BF06EC4
		public override int GetHashCode() => default; // 0x0000000185FE8790-0x0000000185FE87A0
	}

	public struct LocalKeywordSpace : IEquatable<LocalKeywordSpace> // TypeDefIndex: 48051
	{
		// Fields
		private readonly IntPtr m_KeywordSpace; // 0x00
	
		// Methods
		public override bool Equals(object o) => default; // 0x000000018BF06DA0-0x000000018BF06E08
		public bool Equals(LocalKeywordSpace rhs) => default; // 0x0000000183FAA6F0-0x0000000183FAA700
		public static bool operator ==(LocalKeywordSpace lhs, LocalKeywordSpace rhs) => default; // 0x000000018406FBE0-0x000000018406FBF0
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
	}

	public struct ShaderKeyword // TypeDefIndex: 48052
	{
		// Fields
		internal string m_Name; // 0x00
		internal uint m_Index; // 0x08
		internal bool m_IsLocal; // 0x0C
		internal bool m_IsCompute; // 0x0D
		internal bool m_IsValid; // 0x0E
	
		// Constructors
		public ShaderKeyword(string keywordName) {
			m_Name = default;
			m_Index = default;
			m_IsLocal = default;
			m_IsCompute = default;
			m_IsValid = default;
		} // 0x000000018BF09FD0-0x000000018BF0A038
	
		// Methods
		internal static uint GetGlobalKeywordCount() => default; // 0x000000018BF09F70-0x000000018BF09F9C
		internal static uint GetGlobalKeywordIndex(string keyword) => default; // 0x000000018BF09F9C-0x000000018BF09FD0
		internal static void CreateGlobalKeyword(string keyword) {} // 0x000000018BF09F3C-0x000000018BF09F70
		public override string ToString() => default; // 0x0000000184142CB0-0x0000000184142CC0
	}

	public enum ShaderPropertyType // TypeDefIndex: 48053
	{
		Color = 0,
		Vector = 1,
		Float = 2,
		Range = 3,
		Texture = 4,
		Int = 5
	}

	public enum ShaderPropertyFlags // TypeDefIndex: 48054
	{
		None = 0,
		HideInInspector = 1,
		PerRendererData = 2,
		NoScaleOffset = 4,
		Normal = 8,
		HDR = 16,
		Gamma = 32,
		NonModifiableTextureData = 64,
		MainTexture = 128,
		MainColor = 256
	}
}

namespace UnityEngine.Rendering.RendererUtils
{
	public enum RendererListStatus // TypeDefIndex: 48055
	{
		kRendererListInvalid = -2,
		kRendererListProcessing = -1,
		kRendererListEmpty = 0,
		kRendererListPopulated = 1
	}

	public struct RendererList // TypeDefIndex: 48056
	{
		// Fields
		internal UIntPtr context; // 0x00
		internal uint index; // 0x08
		internal uint frame; // 0x0C
		public static readonly RendererList nullRendererList; // 0x00
	
		// Properties
		public bool isValid { get => default; } // 0x000000018BF09BD4-0x000000018BF09C20 
	
		// Constructors
		internal RendererList(UIntPtr ctx, uint indx) : this() {
			context = default;
			index = default;
			frame = default;
		} // 0x0000000185FE87C0-0x0000000185FE87D0
		static RendererList() {
			nullRendererList = default;
		} // 0x000000018BF09B50-0x000000018BF09BA0
	
		// Methods
		private static bool get_isValid_Injected(ref RendererList _unity_self) => default; // 0x000000018BF09BA0-0x000000018BF09BD4
	}

	public struct RendererListDesc // TypeDefIndex: 48057
	{
		// Fields
		public SortingCriteria sortingCriteria; // 0x00
		public PerObjectData rendererConfiguration; // 0x04
		public RenderQueueRange renderQueueRange; // 0x08
		public RenderStateBlock? stateBlock; // 0x10
		public Material overrideMaterial; // 0x80
		public bool excludeObjectMotionVectors; // 0x88
		public int layerMask; // 0x8C
		public int overrideMaterialPassIndex; // 0x90
		public float screenCullingRatio; // 0x94
		public float screenRatioCullingDistance; // 0x98
		public uint screenCullingLayerMask; // 0x9C
		public short sortingLayerMin; // 0xA0
		public short sortingLayerMax; // 0xA2
		public short sortingOrderMin; // 0xA4
		public short sortingOrderMax; // 0xA6
		public ushort characterIndex; // 0xA8
		public IntPtr drawableFeedbackPtr; // 0xB0
		private CullingResults _cullingResult_k__BackingField; // 0xB8
		private Camera _camera_k__BackingField; // 0xC8
		private ShaderTagId _passName_k__BackingField; // 0xD0
		private ShaderTagId[] _passNames_k__BackingField; // 0xD8
	
		// Properties
		internal CullingResults cullingResult { get; private set; } // 0x0000000185FCD370-0x0000000185FCD380 0x0000000185FE87B0-0x0000000185FE87C0
		internal Camera camera { get; set; } // 0x0000000185FB0300-0x0000000185FB0310 0x0000000187A47C30-0x0000000187A47C44
		internal ShaderTagId passName { get; private set; } // 0x0000000185FB2380-0x0000000185FB2390 0x0000000185FB2450-0x0000000185FB2460
		internal ShaderTagId[] passNames { get; private set; } // 0x0000000185FB02F0-0x0000000185FB0300 0x00000001873368EC-0x0000000187336900
	
		// Constructors
		public RendererListDesc(ShaderTagId passName, CullingResults cullingResult, Camera camera) : this() {
			sortingCriteria = default;
			rendererConfiguration = default;
			renderQueueRange = default;
			stateBlock = default;
			overrideMaterial = default;
			excludeObjectMotionVectors = default;
			layerMask = default;
			overrideMaterialPassIndex = default;
			screenCullingRatio = default;
			screenRatioCullingDistance = default;
			screenCullingLayerMask = default;
			sortingLayerMin = default;
			sortingLayerMax = default;
			sortingOrderMin = default;
			sortingOrderMax = default;
			characterIndex = default;
			drawableFeedbackPtr = default;
			<cullingResult>k__BackingField = default;
			<camera>k__BackingField = default;
			<passName>k__BackingField = default;
			<passNames>k__BackingField = default;
		} // 0x000000018BF091C0-0x000000018BF09270
		public RendererListDesc(ShaderTagId[] passNames, CullingResults cullingResult, Camera camera) : this() {
			sortingCriteria = default;
			rendererConfiguration = default;
			renderQueueRange = default;
			stateBlock = default;
			overrideMaterial = default;
			excludeObjectMotionVectors = default;
			layerMask = default;
			overrideMaterialPassIndex = default;
			screenCullingRatio = default;
			screenRatioCullingDistance = default;
			screenCullingLayerMask = default;
			sortingLayerMin = default;
			sortingLayerMax = default;
			sortingOrderMin = default;
			sortingOrderMax = default;
			characterIndex = default;
			drawableFeedbackPtr = default;
			<cullingResult>k__BackingField = default;
			<camera>k__BackingField = default;
			<passName>k__BackingField = default;
			<passNames>k__BackingField = default;
		} // 0x000000018BF09270-0x000000018BF09368
	
		// Methods
		public bool IsValid() => default; // 0x000000018BF09108-0x000000018BF091C0
	}

	internal struct RendererListParams // TypeDefIndex: 48058
	{
		// Fields
		private static readonly ShaderTagId s_EmptyName; // 0x00
		public static readonly RendererListParams nullRendererList; // 0x08
		private bool _isValid_k__BackingField; // 0x00
		internal CullingResults cullingResult; // 0x08
		internal DrawingSettings drawSettings; // 0x18
		internal FilteringSettings filteringSettings; // 0x164
		internal RenderStateBlock? stateBlock; // 0x184
	
		// Properties
		private bool isValid { get; set; } // 0x0000000185FB0F60-0x0000000185FB0F70
	
		// Constructors
		static RendererListParams() {
			s_EmptyName = default;
			nullRendererList = default;
		} // 0x000000018BF09AD4-0x000000018BF09B50
	
		// Methods
		internal static RendererListParams Create(in UnityEngine.Rendering.RendererUtils.RendererListDesc desc) => default; // 0x000000018BF09368-0x000000018BF09AD4
	}
}

namespace UnityEngine.SceneManagement
{
	[Serializable]
	public struct Scene // TypeDefIndex: 47744
	{
		// Fields
		private int m_Handle; // 0x00
	
		// Properties
		public int handle { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
		internal LoadingState loadingState { get => default; } // 0x000000018BEECD7C-0x000000018BEECD88 
		internal string guid { get => default; } // 0x000000018BEECD4C-0x000000018BEECD58 
		public string path { get => default; } // 0x000000018BEECD94-0x000000018BEECDA0 
		public string name { get => default; set {} } // 0x000000018BEECD88-0x000000018BEECD94 0x000000018BEECDC8-0x000000018BEECDD4
		public bool isLoaded { get => default; } // 0x000000018BEECD64-0x000000018BEECD70 
		public int buildIndex { get => default; } // 0x000000018BEECD34-0x000000018BEECD40 
		public bool isDirty { get => default; } // 0x000000018BEECD58-0x000000018BEECD64 
		internal int dirtyID { get => default; } // 0x000000018BEECD40-0x000000018BEECD4C 
		public int rootCount { get => default; } // 0x000000018BEECDA0-0x000000018BEECDAC 
		public bool isSubScene { get => default; set {} } // 0x000000018BEECD70-0x000000018BEECD7C 0x000000018BEECDBC-0x000000018BEECDC8
	
		// Nested types
		internal enum LoadingState // TypeDefIndex: 47743
		{
			NotLoaded = 0,
			Loading = 1,
			Loaded = 2,
			Unloading = 3
		}
	
		// Constructors
		internal Scene(int handle) : this() {
			m_Handle = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
	
		// Methods
		private static bool IsValidInternal(int sceneHandle) => default; // 0x0000000185758AF0-0x0000000185758B30
		private static string GetPathInternal(int sceneHandle) => default; // 0x000000018BEEC99C-0x000000018BEEC9D0
		private static string GetNameInternal(int sceneHandle) => default; // 0x000000018BEEC968-0x000000018BEEC99C
		private static void SetNameInternal(int sceneHandle, string name) {} // 0x000000018BEECCF4-0x000000018BEECD34
		private static string GetGUIDInternal(int sceneHandle) => default; // 0x000000018BEEC898-0x000000018BEEC8CC
		private static bool IsSubScene(int sceneHandle) => default; // 0x000000018BEECC80-0x000000018BEECCB4
		private static void SetIsSubScene(int sceneHandle, bool value) {} // 0x000000018BEECCB4-0x000000018BEECCF4
		private static bool GetIsLoadedInternal(int sceneHandle) => default; // 0x000000018BEEC900-0x000000018BEEC934
		private static LoadingState GetLoadingStateInternal(int sceneHandle) => default; // 0x000000018BEEC934-0x000000018BEEC968
		private static bool GetIsDirtyInternal(int sceneHandle) => default; // 0x000000018BEEC8CC-0x000000018BEEC900
		private static int GetDirtyID(int sceneHandle) => default; // 0x000000018BEEC864-0x000000018BEEC898
		private static int GetBuildIndexInternal(int sceneHandle) => default; // 0x000000018BEEC830-0x000000018BEEC864
		private static int GetRootCountInternal(int sceneHandle) => default; // 0x000000018BEEC9D0-0x000000018BEECA04
		private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) {} // 0x000000018BEECA04-0x000000018BEECA44
		public bool IsValid() => default; // 0x0000000185758AE0-0x0000000185758AF0
		public GameObject[] GetRootGameObjects() => default; // 0x000000018BEECBD8-0x000000018BEECC80
		public void GetRootGameObjects(List<GameObject> rootGameObjects) {} // 0x000000018BEECA44-0x000000018BEECBD8
		public static bool operator ==(Scene lhs, Scene rhs) => default; // 0x000000018BEECDAC-0x000000018BEECDB4
		public static bool operator !=(Scene lhs, Scene rhs) => default; // 0x000000018BEECDB4-0x000000018BEECDBC
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public override bool Equals(object other) => default; // 0x000000018BEEC7CC-0x000000018BEEC830
	}

	internal static class SceneManagerAPIInternal // TypeDefIndex: 47745
	{
		// Methods
		public static int GetNumScenesInBuildSettings() => default; // 0x000000018BEFF25C-0x000000018BEFF288
		public static Scene GetSceneByBuildIndex(int buildIndex) => default; // 0x000000018BEFF2C8-0x000000018BEFF2EC
		public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) => default; // 0x000000018BEFF2EC-0x000000018BEFF310
		public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) {
			outSuccess = default;
			return default;
		} // 0x0000000185F63770-0x0000000185F637E0
		private static void GetSceneByBuildIndex_Injected(int buildIndex, out Scene ret) {
			ret = default;
		} // 0x000000018BEFF288-0x000000018BEFF2C8
		private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) => default; // 0x0000000185F7C240-0x0000000185F7C2B0
	}

	public class SceneManagerAPI // TypeDefIndex: 47746
	{
		// Fields
		private static SceneManagerAPI s_DefaultAPI; // 0x00
		private static SceneManagerAPI _overrideAPI_k__BackingField; // 0x08
	
		// Properties
		internal static SceneManagerAPI ActiveAPI { get => default; } // 0x0000000185758590-0x0000000185758650 
		public static SceneManagerAPI overrideAPI { get; } // 0x000000018BEFF324-0x000000018BEFF374 
	
		// Constructors
		protected internal SceneManagerAPI() {} // 0x0000000185492010-0x0000000185492020
		static SceneManagerAPI() {} // 0x0000000185F79870-0x0000000185F798D0
	
		// Methods
		protected internal virtual int GetNumScenesInBuildSettings() => default; // 0x000000018BEFF310-0x000000018BEFF318
		protected internal virtual Scene GetSceneByBuildIndex(int buildIndex) => default; // 0x000000018BEFF318-0x000000018BEFF324
		protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) => default; // 0x000000018647441C-0x0000000186474448
		protected internal virtual AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) {
			outSuccess = default;
			return default;
		} // 0x0000000186474448-0x000000018647447C
		protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync) => default; // 0x00000001813AE580-0x00000001813AE590
	}

	public class SceneManager // TypeDefIndex: 47747
	{
		// Fields
		internal static bool s_AllowLoadScene; // 0x00
		private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x08
		private static UnityAction<Scene> sceneUnloaded; // 0x10
		private static UnityAction<Scene, Scene> activeSceneChanged; // 0x18
	
		// Properties
		public static int sceneCount { get => default; } // 0x0000000185758650-0x0000000185758690 
		public static int sceneCountInBuildSettings { get => default; } // 0x000000018BEFFE64-0x000000018BEFFEB8 
	
		// Events
		public static event UnityAction<Scene, LoadSceneMode> sceneLoaded;
		public static event UnityAction<Scene> sceneUnloaded;
		public static event UnityAction<Scene, Scene> activeSceneChanged;
	
		// Constructors
		public SceneManager() {} // 0x0000000185492010-0x0000000185492020
		static SceneManager() {} // 0x0000000185FA40A0-0x0000000185FA40E0
	
		// Methods
		public static Scene GetActiveScene() => default; // 0x000000018BEFF3A8-0x000000018BEFF3FC
		public static bool SetActiveScene(Scene scene) => default; // 0x0000000185BBFF80-0x0000000185BBFFD0
		public static Scene GetSceneByPath(string scenePath) => default; // 0x0000000185758A10-0x0000000185758A90
		public static Scene GetSceneByName(string name) => default; // 0x0000000185758690-0x0000000185758710
		public static Scene GetSceneByBuildIndex(int buildIndex) => default; // 0x000000018BEFF4B0-0x000000018BEFF500
		public static Scene GetSceneAt(int index) => default; // 0x0000000185758760-0x00000001857587E0
		public static Scene CreateScene(string sceneName, CreateSceneParameters parameters) => default; // 0x0000000185BBFE90-0x0000000185BBFF20
		private static bool UnloadSceneInternal(Scene scene, UnloadSceneOptions options) => default; // 0x000000018BEFFC28-0x000000018BEFFC7C
		private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) => default; // 0x0000000185758960-0x00000001857589C0
		private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) => default; // 0x00000001857583D0-0x00000001857584B0
		private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) {
			outSuccess = default;
			return default;
		} // 0x00000001857584B0-0x0000000185758590
		public static void MergeScenes(Scene sourceScene, Scene destinationScene) {} // 0x000000018BEFF958-0x000000018BEFF9AC
		public static void MoveGameObjectToScene(GameObject go, Scene scene) {} // 0x000000018BEFF9F0-0x000000018BEFFA44
		internal static AsyncOperation LoadFirstScene_Internal(bool async) => default; // 0x000000018BEFF500-0x000000018BEFF550
		public static Scene[] GetAllScenes() => default; // 0x000000018BEFF3FC-0x000000018BEFF4B0
		public static Scene CreateScene(string sceneName) => default; // 0x0000000185BBFE40-0x0000000185BBFE90
		public static void LoadScene(string sceneName, LoadSceneMode mode) {} // 0x000000018BEFF7A8-0x000000018BEFF804
		public static void LoadScene(string sceneName) {} // 0x000000018BEFF86C-0x000000018BEFF8BC
		public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) => default; // 0x0000000185758350-0x00000001857583D0
		public static void LoadScene(int sceneBuildIndex, LoadSceneMode mode) {} // 0x000000018BEFF8BC-0x000000018BEFF914
		public static void LoadScene(int sceneBuildIndex) {} // 0x000000018BEFF758-0x000000018BEFF7A8
		public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters) => default; // 0x000000018BEFF804-0x000000018BEFF86C
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode) => default; // 0x000000018BEFF550-0x000000018BEFF5A8
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex) => default; // 0x000000018BEFF6AC-0x000000018BEFF6FC
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneParameters parameters) => default; // 0x000000018BEFF604-0x000000018BEFF65C
		public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) => default; // 0x000000018BEFF5A8-0x000000018BEFF604
		public static AsyncOperation LoadSceneAsync(string sceneName) => default; // 0x000000018BEFF65C-0x000000018BEFF6AC
		public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) => default; // 0x000000018BEFF6FC-0x000000018BEFF758
		public static bool UnloadScene(Scene scene) => default; // 0x000000018BEFFC7C-0x000000018BEFFCC8
		public static bool UnloadScene(int sceneBuildIndex) => default; // 0x000000018BEFFD2C-0x000000018BEFFD9C
		public static bool UnloadScene(string sceneName) => default; // 0x000000018BEFFCC8-0x000000018BEFFD2C
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex) => default; // 0x000000018BEFFB24-0x000000018BEFFB90
		public static AsyncOperation UnloadSceneAsync(string sceneName) => default; // 0x00000001857582E0-0x0000000185758350
		public static AsyncOperation UnloadSceneAsync(Scene scene) => default; // 0x0000000185758910-0x0000000185758960
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex, UnloadSceneOptions options) => default; // 0x000000018BEFFAAC-0x000000018BEFFB24
		public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options) => default; // 0x000000018BEFFA44-0x000000018BEFFAAC
		public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options) => default; // 0x000000018BEFFB90-0x000000018BEFFBE8
		private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) {} // 0x0000000185D90450-0x0000000185D90500
		private static void Internal_SceneUnloaded(Scene scene) {} // 0x0000000185D67FA0-0x0000000185D68040
		private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) {} // 0x0000000185D90D10-0x0000000185D90D80
		private static void GetActiveScene_Injected(out Scene ret) {
			ret = default;
		} // 0x000000018BEFF374-0x000000018BEFF3A8
		private static bool SetActiveScene_Injected(ref Scene scene) => default; // 0x0000000185BBFFD0-0x0000000185BC0010
		private static void GetSceneByPath_Injected(string scenePath, out Scene ret) {
			ret = default;
		} // 0x0000000185758A90-0x0000000185758AE0
		private static void GetSceneByName_Injected(string name, out Scene ret) {
			ret = default;
		} // 0x0000000185758710-0x0000000185758760
		private static void GetSceneAt_Injected(int index, out Scene ret) {
			ret = default;
		} // 0x00000001857587E0-0x0000000185758830
		private static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret) {
			ret = default;
		} // 0x0000000185BBFF20-0x0000000185BBFF80
		private static bool UnloadSceneInternal_Injected(ref Scene scene, UnloadSceneOptions options) => default; // 0x000000018BEFFBE8-0x000000018BEFFC28
		private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) => default; // 0x00000001857589C0-0x0000000185758A10
		private static void MergeScenes_Injected(ref Scene sourceScene, ref Scene destinationScene) {} // 0x000000018BEFF914-0x000000018BEFF958
		private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene) {} // 0x000000018BEFF9AC-0x000000018BEFF9F0
	}

	public enum LoadSceneMode // TypeDefIndex: 47748
	{
		Single = 0,
		Additive = 1
	}

	public enum LocalPhysicsMode // TypeDefIndex: 47749
	{
		None = 0,
		Physics2D = 1,
		Physics3D = 2
	}

	[Serializable]
	public struct LoadSceneParameters // TypeDefIndex: 47750
	{
		// Fields
		private LoadSceneMode m_LoadSceneMode; // 0x00
		private LocalPhysicsMode m_LocalPhysicsMode; // 0x04
	
		// Properties
		public LoadSceneMode loadSceneMode { set {} } // 0x00000001818AA390-0x00000001818AA3A0
	
		// Constructors
		public LoadSceneParameters(LoadSceneMode mode) : this() {
			m_LoadSceneMode = default;
			m_LocalPhysicsMode = default;
		} // 0x0000000185FB69F0-0x0000000185FB6A00
	}

	[Serializable]
	public struct CreateSceneParameters // TypeDefIndex: 47751
	{
		// Fields
		private LocalPhysicsMode m_LocalPhysicsMode; // 0x00
	
		// Constructors
		public CreateSceneParameters(LocalPhysicsMode physicsMode) {
			m_LocalPhysicsMode = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
	}

	public enum UnloadSceneOptions // TypeDefIndex: 47752
	{
		None = 0,
		UnloadAllEmbeddedSceneObjects = 1
	}
}

namespace UnityEngine.Scripting
{
	public class AlwaysLinkAssemblyAttribute : Attribute // TypeDefIndex: 47739
	{
		// Constructors
		public AlwaysLinkAssemblyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class PreserveAttribute : Attribute // TypeDefIndex: 47740
	{
		// Constructors
		public PreserveAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.Scripting.APIUpdating
{
	internal struct MovedFromAttributeData // TypeDefIndex: 47741
	{
		// Fields
		public string className; // 0x00
		public string nameSpace; // 0x08
		public string assembly; // 0x10
		public bool classHasChanged; // 0x18
		public bool nameSpaceHasChanged; // 0x19
		public bool assemblyHasChanged; // 0x1A
		public bool autoUdpateAPI; // 0x1B
	
		// Methods
		public void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null) {} // 0x00000001855FDB70-0x00000001855FDBE0
	}

	public class MovedFromAttribute : Attribute // TypeDefIndex: 47742
	{
		// Fields
		internal MovedFromAttributeData data; // 0x10
	
		// Constructors
		public MovedFromAttribute() {} // Dummy constructor
		public MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null) {} // 0x00000001855FDB20-0x00000001855FDB40
		public MovedFromAttribute(string sourceNamespace) {} // 0x00000001855FDB40-0x00000001855FDB70
	}
}

namespace UnityEngine.Serialization
{
	public class FormerlySerializedAsAttribute : Attribute // TypeDefIndex: 47738
	{
		// Fields
		private string m_oldName; // 0x10
	
		// Constructors
		public FormerlySerializedAsAttribute() {} // Dummy constructor
		public FormerlySerializedAsAttribute(string oldName) {} // 0x0000000184096E30-0x0000000184096EF0
	}
}

namespace UnityEngine.Sprites
{
	public sealed class DataUtility // TypeDefIndex: 47653
	{
		// Constructors
		public DataUtility() {} // Dummy constructor
	
		// Methods
		public static Vector4 GetInnerUV(Sprite sprite) => default; // 0x0000000183F91410-0x0000000183F91480
		public static Vector4 GetOuterUV(Sprite sprite) => default; // 0x0000000183F91500-0x0000000183F91570
		public static Vector4 GetPadding(Sprite sprite) => default; // 0x0000000184044FE0-0x0000000184045050
		public static Vector2 GetMinSize(Sprite sprite) => default; // 0x0000000183F90670-0x0000000183F907B0
	}
}

namespace UnityEngine.U2D
{
	[Serializable]
	public struct SpriteBone // TypeDefIndex: 47654
	{
		// Fields
		private string m_Name; // 0x00
		private string m_Guid; // 0x08
		private Vector3 m_Position; // 0x10
		private Quaternion m_Rotation; // 0x1C
		private float m_Length; // 0x2C
		private int m_ParentId; // 0x30
		private Color32 m_Color; // 0x34
	}

	public class SpriteAtlasManager // TypeDefIndex: 47655
	{
		// Fields
		private static Action<string, Action<SpriteAtlas>> atlasRequested; // 0x00
		private static Action<SpriteAtlas> atlasRegistered; // 0x08
	
		// Events
		public static event Action<SpriteAtlas> atlasRegistered;
	
		// Constructors
		public SpriteAtlasManager() {} // Dummy constructor
	
		// Methods
		private static bool RequestAtlas(string tag) => default; // 0x000000018BEED188-0x000000018BEED244
		private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) {} // 0x000000018BEED104-0x000000018BEED154
		internal static void Register(SpriteAtlas spriteAtlas) {} // 0x000000018BEED154-0x000000018BEED188
	}

	public class SpriteAtlas : UnityEngine.Object // TypeDefIndex: 47656
	{
		// Constructors
		public SpriteAtlas() {} // Dummy constructor
	
		// Methods
		public bool CanBindTo(Sprite sprite) => default; // 0x000000018BEED38C-0x000000018BEED3D0
	}
}

namespace UnityEngine.Windows
{
	public static class Input // TypeDefIndex: 47678
	{
		// Methods
		private static unsafe void ForwardRawInputImpl(uint* rawInputHeaderIndices, uint* rawInputDataIndices, uint indicesCount, byte* rawInputData, uint rawInputDataSize) {} // 0x00000001851D0D60-0x00000001851D0DD0
		public static unsafe void ForwardRawInput(uint* rawInputHeaderIndices, uint* rawInputDataIndices, uint indicesCount, byte* rawInputData, uint rawInputDataSize) {} // 0x00000001851D0D20-0x00000001851D0D60
	}
}

namespace UnityEngine.Windows.Speech
{
	public static class PhraseRecognitionSystem // TypeDefIndex: 47681
	{
		// Fields
		private static ErrorDelegate OnError; // 0x00
		private static StatusDelegate OnStatusChanged; // 0x08
	
		// Nested types
		public delegate void ErrorDelegate(SpeechError errorCode); // TypeDefIndex: 47679; 0x000000018BEEB65C-0x000000018BEEB6AC
	
		public delegate void StatusDelegate(SpeechSystemStatus status); // TypeDefIndex: 47680; 0x00000001833EEC70-0x00000001833EEC80
	
		// Methods
		private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) {} // 0x000000018789F4A4-0x000000018789F56C
		private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) {} // 0x00000001833EEC70-0x00000001833EEC80
	}

	public abstract class PhraseRecognizer // TypeDefIndex: 47683
	{
		// Fields
		protected IntPtr m_Recognizer; // 0x10
		private PhraseRecognizedDelegate OnPhraseRecognized; // 0x18
	
		// Nested types
		public delegate void PhraseRecognizedDelegate(PhraseRecognizedEventArgs args); // TypeDefIndex: 47682; 0x000000018BEEB808-0x000000018BEEB98C
	
		// Constructors
		protected PhraseRecognizer() {} // Dummy constructor
	
		// Methods
		private void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks) {} // 0x00000001889CB108-0x00000001889CB1D0
		private static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount) => default; // 0x00000001833DBC00-0x00000001833DBC40
	}

	public sealed class DictationRecognizer // TypeDefIndex: 47688
	{
		// Fields
		private IntPtr m_Recognizer; // 0x10
		private DictationHypothesisDelegate DictationHypothesis; // 0x18
		private DictationResultDelegate DictationResult; // 0x20
		private DictationCompletedDelegate DictationComplete; // 0x28
		private DictationErrorHandler DictationError; // 0x30
	
		// Nested types
		public delegate void DictationHypothesisDelegate(string text); // TypeDefIndex: 47684; 0x000000018BEE7F70-0x000000018BEE7F90
	
		public delegate void DictationResultDelegate(string text, ConfidenceLevel confidence); // TypeDefIndex: 47685; 0x000000018BEE7F38-0x000000018BEE7F58
	
		public delegate void DictationCompletedDelegate(DictationCompletionCause cause); // TypeDefIndex: 47686; 0x00000001833EEC70-0x00000001833EEC80
	
		public delegate void DictationErrorHandler(string error, int hresult); // TypeDefIndex: 47687; 0x00000001831C5680-0x00000001831C5690
	
		// Constructors
		public DictationRecognizer() {} // Dummy constructor
	
		// Methods
		private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword) {} // 0x000000018789F4A4-0x000000018789F56C
		private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence) {} // 0x00000001833EEC70-0x00000001833EEC80
		private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause) {} // 0x0000000189AE6CB0-0x0000000189AE6D84
		private void DictationRecognizer_InvokeErrorEvent(string error, int hresult) {} // 0x00000001831C5680-0x00000001831C5690
	}

	public enum ConfidenceLevel // TypeDefIndex: 47689
	{
		High = 0,
		Medium = 1,
		Low = 2,
		Rejected = 3
	}

	public enum SpeechSystemStatus // TypeDefIndex: 47690
	{
		Stopped = 0,
		Running = 1,
		Failed = 2
	}

	public enum SpeechError // TypeDefIndex: 47691
	{
		NoError = 0,
		TopicLanguageNotSupported = 1,
		GrammarLanguageMismatch = 2,
		GrammarCompilationFailure = 3,
		AudioQualityFailure = 4,
		PauseLimitExceeded = 5,
		TimeoutExceeded = 6,
		NetworkFailure = 7,
		MicrophoneUnavailable = 8,
		UnknownError = 9
	}

	public enum DictationCompletionCause // TypeDefIndex: 47692
	{
		Complete = 0,
		AudioQualityFailure = 1,
		Canceled = 2,
		TimeoutExceeded = 3,
		PauseLimitExceeded = 4,
		NetworkFailure = 5,
		MicrophoneUnavailable = 6,
		UnknownError = 7
	}

	public struct SemanticMeaning // TypeDefIndex: 47693
	{
		// Fields
		public string key; // 0x00
		public string[] values; // 0x08
	}

	public struct PhraseRecognizedEventArgs // TypeDefIndex: 47694
	{
		// Fields
		public readonly ConfidenceLevel confidence; // 0x00
		public readonly SemanticMeaning[] semanticMeanings; // 0x08
		public readonly string text; // 0x10
		public readonly System.DateTime phraseStartTime; // 0x18
		public readonly TimeSpan phraseDuration; // 0x20
	
		// Constructors
		internal PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, System.DateTime phraseStartTime, TimeSpan phraseDuration) {
			this.confidence = default;
			this.semanticMeanings = default;
			this.text = default;
			this.phraseStartTime = default;
			this.phraseDuration = default;
		} // 0x000000018BEEB6AC-0x000000018BEEB6EC
	}
}

namespace UnityEngine.Windows.WebCam
{
	public class PhotoCapture : IDisposable // TypeDefIndex: 47702
	{
		// Fields
		internal IntPtr m_NativePtr; // 0x10
		private static readonly long HR_SUCCESS; // 0x00
	
		// Nested types
		public enum CaptureResultType // TypeDefIndex: 47695
		{
			Success = 0,
			UnknownError = 1
		}
	
		public struct PhotoCaptureResult // TypeDefIndex: 47696
		{
			// Fields
			public CaptureResultType resultType; // 0x00
			public long hResult; // 0x08
		}
	
		public delegate void OnCaptureResourceCreatedCallback(PhotoCapture captureObject); // TypeDefIndex: 47697; 0x000000018BEEB528-0x000000018BEEB59C
	
		public delegate void OnPhotoModeStartedCallback(PhotoCaptureResult result); // TypeDefIndex: 47698; 0x000000018BEEB438-0x000000018BEEB478
	
		public delegate void OnPhotoModeStoppedCallback(PhotoCaptureResult result); // TypeDefIndex: 47699; 0x000000018BEEB438-0x000000018BEEB478
	
		public delegate void OnCapturedToDiskCallback(PhotoCaptureResult result); // TypeDefIndex: 47700; 0x000000018BEEB35C-0x000000018BEEB3B4
	
		public delegate void OnCapturedToMemoryCallback(PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame); // TypeDefIndex: 47701; 0x000000018BEEB3B4-0x000000018BEEB438
	
		// Constructors
		public PhotoCapture() {} // Dummy constructor
		private PhotoCapture(IntPtr nativeCaptureObject) {} // 0x00000001833EEC70-0x00000001833EEC80
	
		// Methods
		private static PhotoCaptureResult MakeCaptureResult(long hResult) => default; // 0x000000018BEEB2F4-0x000000018BEEB328
		private static void InvokeOnCreatedResourceDelegate(OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) {} // 0x0000000187893E40-0x0000000187893F64
		private static void InvokeOnPhotoModeStartedDelegate(OnPhotoModeStartedCallback callback, long hResult) {} // 0x00000001889CC0A8-0x00000001889CC170
		private static void InvokeOnPhotoModeStoppedDelegate(OnPhotoModeStoppedCallback callback, long hResult) {} // 0x0000000185FA9450-0x0000000185FA9480
		private static void InvokeOnCapturedPhotoToDiskDelegate(OnCapturedToDiskCallback callback, long hResult) {} // 0x00000001889CC0A8-0x00000001889CC170
		private static void InvokeOnCapturedPhotoToMemoryDelegate(OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) {} // 0x0000000185FA9450-0x0000000185FA9480
		public void Dispose() {} // 0x00000001889CC0A8-0x00000001889CC170
		private void Dispose_Internal() {} // 0x0000000185FA9450-0x0000000185FA9480
		~PhotoCapture() {} // 0x0000000188FD5A08-0x0000000188FD5AD0
		private void DisposeThreaded_Internal() {} // 0x0000000183508F90-0x0000000183508FC0
	}

	public sealed class PhotoCaptureFrame : IDisposable // TypeDefIndex: 47703
	{
		// Fields
		private IntPtr m_NativePtr; // 0x10
		private int _dataLength_k__BackingField; // 0x18
		private bool _hasLocationData_k__BackingField; // 0x1C
		private CapturePixelFormat _pixelFormat_k__BackingField; // 0x20
	
		// Properties
		public int dataLength { get; private set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		private bool hasLocationData { get; set; } // 0x0000000181408D10-0x0000000181408D20
		private CapturePixelFormat pixelFormat { get; set; } // 0x00000001813B9430-0x00000001813B9440
	
		// Constructors
		public PhotoCaptureFrame() {} // Dummy constructor
		internal PhotoCaptureFrame(IntPtr nativePtr) {} // 0x000000018BEEB278-0x000000018BEEB2F4
	
		// Methods
		private int GetDataLength() => default; // 0x000000018BEEB210-0x000000018BEEB244
		private bool GetHasLocationData() => default; // 0x000000018BEEB244-0x000000018BEEB278
		private CapturePixelFormat GetCapturePixelFormat() => default; // 0x000000018BEEB1DC-0x000000018BEEB210
		private void Cleanup() {} // 0x000000018BEEB088-0x000000018BEEB0EC
		private void Dispose_Internal() {} // 0x000000018BEEB0EC-0x000000018BEEB120
		public void Dispose() {} // 0x000000018BEEB120-0x000000018BEEB16C
		~PhotoCaptureFrame() {} // 0x000000018BEEB16C-0x000000018BEEB1DC
	}

	public class VideoCapture : IDisposable // TypeDefIndex: 47711
	{
		// Fields
		internal IntPtr m_NativePtr; // 0x10
		private static readonly long HR_SUCCESS; // 0x00
	
		// Nested types
		public enum CaptureResultType // TypeDefIndex: 47704
		{
			Success = 0,
			UnknownError = 1
		}
	
		public struct VideoCaptureResult // TypeDefIndex: 47705
		{
			// Fields
			public CaptureResultType resultType; // 0x00
			public long hResult; // 0x08
		}
	
		public delegate void OnVideoCaptureResourceCreatedCallback(VideoCapture captureObject); // TypeDefIndex: 47706; 0x000000018BEF2B0C-0x000000018BEF2B80
	
		public delegate void OnVideoModeStartedCallback(VideoCaptureResult result); // TypeDefIndex: 47707; 0x000000018BEF2B80-0x000000018BEF2BC0
	
		public delegate void OnVideoModeStoppedCallback(VideoCaptureResult result); // TypeDefIndex: 47708; 0x000000018BEF2B80-0x000000018BEF2BC0
	
		public delegate void OnStartedRecordingVideoCallback(VideoCaptureResult result); // TypeDefIndex: 47709; 0x000000018BEF2A30-0x000000018BEF2A88
	
		public delegate void OnStoppedRecordingVideoCallback(VideoCaptureResult result); // TypeDefIndex: 47710; 0x000000018BEF2A88-0x000000018BEF2B0C
	
		// Constructors
		public VideoCapture() {} // Dummy constructor
		private VideoCapture(IntPtr nativeCaptureObject) {} // 0x00000001833EEC70-0x00000001833EEC80
	
		// Methods
		private static VideoCaptureResult MakeCaptureResult(long hResult) => default; // 0x000000018BEF29C8-0x000000018BEF29FC
		private static void InvokeOnCreatedVideoCaptureResourceDelegate(OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) {} // 0x0000000187893E40-0x0000000187893F64
		private static void InvokeOnVideoModeStartedDelegate(OnVideoModeStartedCallback callback, long hResult) {} // 0x00000001889CC0A8-0x00000001889CC170
		private static void InvokeOnVideoModeStoppedDelegate(OnVideoModeStoppedCallback callback, long hResult) {} // 0x0000000185FA9450-0x0000000185FA9480
		private static void InvokeOnStartedRecordingVideoToDiskDelegate(OnStartedRecordingVideoCallback callback, long hResult) {} // 0x00000001889CC0A8-0x00000001889CC170
		private static void InvokeOnStoppedRecordingVideoToDiskDelegate(OnStoppedRecordingVideoCallback callback, long hResult) {} // 0x0000000185FA9450-0x0000000185FA9480
		public void Dispose() {} // 0x00000001889CC0A8-0x00000001889CC170
		private void Dispose_Internal() {} // 0x0000000185FA9450-0x0000000185FA9480
		~VideoCapture() {} // 0x00000001889CC0A8-0x00000001889CC170
		private void DisposeThreaded_Internal() {} // 0x0000000185FA9450-0x0000000185FA9480
	}

	public enum CapturePixelFormat // TypeDefIndex: 47712
	{
		BGRA32 = 0,
		NV12 = 1,
		JPEG = 2,
		PNG = 3
	}
}

namespace UnityEngine._Scripting.APIUpdating
{
	internal class APIUpdaterRuntimeHelpers // TypeDefIndex: 47652
	{
		// Constructors
		public APIUpdaterRuntimeHelpers() {} // Dummy constructor
	
		// Methods
		internal static bool GetMovedFromAttributeDataForType(System.Type sourceType, out string assembly, out string nsp, out string klass) {
			assembly = default;
			nsp = default;
			klass = default;
			return default;
		} // 0x0000000185509FC0-0x000000018550A120
		internal static bool GetObsoleteTypeRedirection(System.Type sourceType, out string assemblyName, out string nsp, out string className) {
			assemblyName = default;
			nsp = default;
			className = default;
			return default;
		} // 0x000000018BEE63E4-0x000000018BEE66C8
	}
}

namespace UnityEngineInternal
{
	internal enum LightmapType // TypeDefIndex: 47193
	{
		NoLightmap = -1,
		StaticLightmap = 0,
		DynamicLightmap = 1
	}

	public struct MathfInternal // TypeDefIndex: 47194
	{
		// Fields
		public static float FloatMinNormal; // 0x00
		public static float FloatMinDenormal; // 0x04
		public static bool IsFlushToZeroEnabled; // 0x08
	
		// Constructors
		static MathfInternal() {
			FloatMinNormal = default;
			FloatMinDenormal = default;
			IsFlushToZeroEnabled = default;
		} // 0x0000000185EEE520-0x0000000185EEE600
	}

	public enum TypeInferenceRules // TypeDefIndex: 47195
	{
		TypeReferencedByFirstArgument = 0,
		TypeReferencedBySecondArgument = 1,
		ArrayOfTypeReferencedByFirstArgument = 2,
		TypeOfFirstArgument = 3
	}

	[Serializable]
	public class TypeInferenceRuleAttribute : Attribute // TypeDefIndex: 47196
	{
		// Fields
		private readonly string _rule; // 0x10
	
		// Constructors
		public TypeInferenceRuleAttribute() {} // Dummy constructor
		public TypeInferenceRuleAttribute(TypeInferenceRules rule) {} // 0x000000018BEC9B4C-0x000000018BEC9BB4
		public TypeInferenceRuleAttribute(string rule) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override string ToString() => default; // 0x0000000185FC7990-0x0000000185FC79A0
	}

	public class GenericStack : Stack // TypeDefIndex: 47197
	{
		// Constructors
		public GenericStack() {} // 0x000000018BEB9B58-0x000000018BEB9B60
	}
}
