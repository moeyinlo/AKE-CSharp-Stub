/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using Unity.Mathematics;

// Image 54: Unity.Collections.dll - Assembly: Unity.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58176-58366

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 58364
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_192 _2CF2F88BF9B71283059B6DF53E5BCDE20ADBFD9E8D6CE2C1AB106262BB283BED; // 0x00 // Static value (base64): uP5sOSOkS758AYEs9yGtHN7UbemDkJfbckCkpLezZx/LeeZOzMDleIJa0H3M/3IhuAhGdPdDJI7gNZDmgTomTDwoUruRwwDLiNBlixtTLqNxZEiXog35TjgZ70ap3qzYqPp2P+OcND/53LvHxwtPHYpR4EvNtFkxyJ9+ydl4c2TqxayDNNPrw8WBoP/6E2PrFw3dUbfw2knTFlUmKdRonisWvlh9R6H8j/i40XrQMc5FyzqPlRYEKK/X+8q7S0B+ - Metadata: 0x0207F52C

	// Nested types
	private struct __StaticArrayInitTypeSize_192 // TypeDefIndex: 58363
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

internal class __JobReflectionRegistrationOutput__3948948251 // TypeDefIndex: 58365
{
	// Constructors
	public __JobReflectionRegistrationOutput__3948948251() {} // Dummy constructor

	// Methods
	public static void CreateJobReflectionData() {} // 0x0000000183F70B70-0x0000000183F72B60
	public static void EarlyInit() {} // 0x0000000183F72B60-0x0000000183F754D0
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 58366
{
	// Methods
	private static void Initialize() {} // 0x0000000185EC1FD0-0x0000000185EC2080
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 58177
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 58178
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.Collections
{
	public static class AllocatorManager // TypeDefIndex: 58221
	{
		// Fields
		public static readonly AllocatorHandle Invalid; // 0x00
		public static readonly AllocatorHandle None; // 0x04
		public static readonly AllocatorHandle Temp; // 0x08
		public static readonly AllocatorHandle TempJob; // 0x0C
		public static readonly AllocatorHandle Persistent; // 0x10
		public static readonly AllocatorHandle AudioKernel; // 0x14
	
		// Nested types
		public delegate int TryFunction(IntPtr allocatorState, ref Block block); // TypeDefIndex: 58202; 0x00000000-0x00000000
	
		public struct AllocatorHandle : IAllocator // TypeDefIndex: 58203
		{
			// Fields
			public ushort Index; // 0x00
			public ushort Version; // 0x02
	
			// Properties
			internal ref TableEntry TableEntry { get => default; }
			public int Value { get => default; }
			public AllocatorHandle Handle { get => default; } // 0x00000001840C8570-0x00000001840C8760 
			public Unity.Collections.Allocator ToAllocator { get => default; }
	
			// Methods
			internal void Rewind() {}
			public static implicit operator AllocatorHandle(Unity.Collections.Allocator a) => default;
			public int Try(ref Block block) => default;
			public void Dispose() {} // 0x000000018BC7CE58-0x000000018BC7CEB8
		}
	
		public struct Range : IDisposable // TypeDefIndex: 58204
		{
			// Fields
			public IntPtr Pointer; // 0x00
			public int Items; // 0x08
			public AllocatorHandle Allocator; // 0x0C
	
			// Methods
			public void Dispose() {}
		}
	
		public struct Block : IDisposable // TypeDefIndex: 58205
		{
			// Fields
			public Range Range; // 0x00
			public int BytesPerItem; // 0x10
			public int AllocatedItems; // 0x14
			public byte Log2Alignment; // 0x18
			public byte Padding0; // 0x19
			public ushort Padding1; // 0x1A
			public uint Padding2; // 0x1C
	
			// Properties
			public long Bytes { get => default; } // 0x0000000185FBD040-0x0000000185FBD050 
			public long AllocatedBytes { get => default; } // 0x000000018BC7CEB8-0x000000018BC7CEF4 
			public int Alignment { get => default; set {} } // 0x000000018BC7CEF4-0x000000018BC7CF84 0x000000018BC7CF84-0x000000018BC7D08C
	
			// Methods
			public void Dispose() {} // 0x0000000184B679C0-0x0000000184B679D0
			public int TryFree() => default; // 0x0000000184070890-0x0000000184070A20
		}
	
		public interface IAllocator : IDisposable // TypeDefIndex: 58206
		{
			// Properties
			AllocatorHandle Handle { get; } // 0x00000001840A6320-0x00000001840A6330 
	
			// Methods
			int Try(ref Block block); // 0x00000001840A6440-0x00000001840A64B0
		}
	
		internal struct StackAllocator : IAllocator // TypeDefIndex: 58209
		{
			// Fields
			internal AllocatorHandle m_handle; // 0x00
			internal Block m_storage; // 0x08
			internal long m_top; // 0x28
	
			// Properties
			public AllocatorHandle Handle { get => default; } // 0x0000000182FA7E40-0x0000000182FA7E50 
	
			// Nested types
			public delegate int Try_000000A0_PostfixBurstDelegate(IntPtr allocatorState, ref Block block); // TypeDefIndex: 58207; 0x0000000185EC20C0-0x0000000185EC2100
	
			internal static class Try_000000A0_BurstDirectCall // TypeDefIndex: 58208
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Try_000000A0_BurstDirectCall() {} // 0x0000000185492010-0x0000000185492020
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0007a985) {} // 0x0000000185EC2080-0x0000000185EC20C0
				private static IntPtr GetFunctionPointer() => default; // 0x000000018BC80F00-0x000000018BC80FC8
				public static void Constructor() {} // 0x0000000181B59400-0x0000000181B59410
				public static void Initialize() {} // 0x000000018BC7CDDC-0x000000018BC7CE58
				public static int Invoke(IntPtr allocatorState, ref Block block) => default; // 0x0000000185FD73B0-0x0000000185FD73D0
			}
	
			// Methods
			public int Try(ref Block block) => default; // 0x00000001840A6390-0x00000001840A6440
			public static int Try(IntPtr allocatorState, ref Block block) => default; // 0x00000001818226B0-0x00000001818226C0
			public void Dispose() {} // 0x0000000185FD73A0-0x0000000185FD73B0
			public static int Try_BurstManaged(IntPtr allocatorState, ref Block block) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		internal struct SlabAllocator : IAllocator // TypeDefIndex: 58212
		{
			// Fields
			internal AllocatorHandle m_handle; // 0x00
			internal Block Storage; // 0x08
			internal int Log2SlabSizeInBytes; // 0x28
			internal FixedList4096Bytes<int> Occupied; // 0x2C
			internal long budgetInBytes; // 0x1030
			internal long allocatedBytes; // 0x1038
	
			// Properties
			public AllocatorHandle Handle { get => default; }
			internal int SlabSizeInBytes { get => default; } // 0x00000001818226B0-0x00000001818226C0 
	
			// Nested types
			public delegate int Try_000000AE_PostfixBurstDelegate(IntPtr allocatorState, ref Block block); // TypeDefIndex: 58210; 0x0000000185FD74B0-0x0000000185FD74C0
	
			internal static class Try_000000AE_BurstDirectCall // TypeDefIndex: 58211
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Try_000000AE_BurstDirectCall() {} // 0x000000018BC7D138-0x000000018BC7D188
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0007a991) {} // 0x0000000185FD74A0-0x0000000185FD74B0
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185FD7490-0x0000000185FD74A0
				public static void Constructor() {} // 0x00000001840A6190-0x00000001840A61E0
				public static void Initialize() {} // 0x000000018BC7D130-0x000000018BC7D138
				public static int Invoke(IntPtr allocatorState, ref Block block) => default;
			}
	
			// Methods
			public int Try(ref Block block) => default; // 0x000000018BC80E14-0x000000018BC80EA0
			public static int Try(IntPtr allocatorState, ref Block block) => default; // 0x000000018BC80DB8-0x000000018BC80E14
			public void Dispose() {} // 0x0000000185492010-0x0000000185492020
			public static int Try_BurstManaged(IntPtr allocatorState, ref Block block) => default; // 0x000000018BC80DB0-0x000000018BC80DB8
		}
	
		internal struct TableEntry // TypeDefIndex: 58213
		{
			// Fields
			internal IntPtr function; // 0x00
			internal IntPtr state; // 0x08
		}
	
		internal struct Array16<T> // TypeDefIndex: 58214
			where T : struct
		{
			// Fields
			internal T f0;
			internal T f1;
			internal T f2;
			internal T f3;
			internal T f4;
			internal T f5;
			internal T f6;
			internal T f7;
			internal T f8;
			internal T f9;
			internal T f10;
			internal T f11;
			internal T f12;
			internal T f13;
			internal T f14;
			internal T f15;
		}
	
		internal struct Array256<T> // TypeDefIndex: 58215
			where T : struct
		{
			// Fields
			internal Array16<T> f0;
			internal Array16<T> f1;
			internal Array16<T> f2;
			internal Array16<T> f3;
			internal Array16<T> f4;
			internal Array16<T> f5;
			internal Array16<T> f6;
			internal Array16<T> f7;
			internal Array16<T> f8;
			internal Array16<T> f9;
			internal Array16<T> f10;
			internal Array16<T> f11;
			internal Array16<T> f12;
			internal Array16<T> f13;
			internal Array16<T> f14;
			internal Array16<T> f15;
		}
	
		internal struct Array4096<T> // TypeDefIndex: 58216
			where T : struct
		{
			// Fields
			internal Array256<T> f0;
			internal Array256<T> f1;
			internal Array256<T> f2;
			internal Array256<T> f3;
			internal Array256<T> f4;
			internal Array256<T> f5;
			internal Array256<T> f6;
			internal Array256<T> f7;
			internal Array256<T> f8;
			internal Array256<T> f9;
			internal Array256<T> f10;
			internal Array256<T> f11;
			internal Array256<T> f12;
			internal Array256<T> f13;
			internal Array256<T> f14;
			internal Array256<T> f15;
		}
	
		internal struct Array32768<T> : IIndexable<T> // TypeDefIndex: 58217
			where T : struct
		{
			// Fields
			internal Array4096<T> f0;
			internal Array4096<T> f1;
			internal Array4096<T> f2;
			internal Array4096<T> f3;
			internal Array4096<T> f4;
			internal Array4096<T> f5;
			internal Array4096<T> f6;
			internal Array4096<T> f7;
	
			// Properties
			public int Length { get => default; } // 0x000000018BC80F00-0x000000018BC80FC8 
	
			// Methods
			public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt; // 0x0000000181B59400-0x0000000181B59410
			private ref T _refReturnTypeForElementAt; // Dummy field
		}
	
		internal sealed class SharedStatics // TypeDefIndex: 58219
		{
			// Nested types
			internal sealed class TableEntry // TypeDefIndex: 58218
			{
				// Fields
				internal static readonly SharedStatic<Array32768<AllocatorManager.TableEntry>> Ref; // 0x00
	
				// Constructors
				public TableEntry() {} // Dummy constructor
				static TableEntry() {} // 0x000000018BC80FC8-0x000000018BC810CC
			}
	
			// Constructors
			public SharedStatics() {} // Dummy constructor
		}
	
		internal static class Managed // TypeDefIndex: 58220
		{
			// Fields
			internal static TryFunction[] TryFunctionDelegates; // 0x00
	
			// Constructors
			static Managed() {} // 0x000000018BC810CC-0x000000018BC81120
		}
	
		// Constructors
		static AllocatorManager() {}
	
		// Methods
		internal static Block AllocateBlock<T>(ref ref T t, int sizeOf, int alignOf, int items)
			where T : struct, IAllocator => default; // 0x0000000185F45640-0x0000000185F456D0
		internal static unsafe void* Allocate<T>(ref ref T t, int sizeOf, int alignOf, int items)
			where T : struct, IAllocator => default; // 0x0000000185492010-0x0000000185492020
		internal static unsafe U* Allocate<T, U>(ref ref T t, U u, int items)
			where T : struct, IAllocator
			where U : struct => default; // 0x0000000185F45630-0x0000000185F45640
		internal static unsafe void* AllocateStruct<T, U>(ref ref T t, U u, int items)
			where T : struct, IAllocator
			where U : struct => default; // 0x000000018BC81120-0x000000018BC811AC
		internal static void FreeBlock<T>(ref ref T t, ref Block block)
			where T : struct, IAllocator {} // 0x00000001818226B0-0x00000001818226C0
		internal static unsafe void Free<T>(ref ref T t, void* pointer, int sizeOf, int alignOf, int items)
			where T : struct, IAllocator {} // 0x0000000185FD7500-0x0000000185FD7510
		internal static unsafe void Free<T, U>(ref ref T t, U* pointer, int items)
			where T : struct, IAllocator
			where U : struct {} // 0x000000018BC80B94-0x000000018BC80D80
		public static unsafe void* Allocate(AllocatorHandle handle, int itemSizeInBytes, int alignmentInBytes, int items = 1 /* Metadata: 0x0207F500 */) => default; // 0x000000018BC80B38-0x000000018BC80B94
		public static unsafe T* Allocate<T>(AllocatorHandle handle, int items = 1 /* Metadata: 0x0207F501 */)
			where T : struct => default; // 0x0000000185492010-0x0000000185492020
		public static unsafe void Free(AllocatorHandle handle, void* pointer) {} // 0x000000018BC80B30-0x000000018BC80B38
		public static unsafe void Free<T>(AllocatorHandle handle, T* pointer, int items = 1 /* Metadata: 0x0207F502 */)
			where T : struct {} // 0x000000018BC80F00-0x000000018BC80FC8
		private static void CheckDelegate(ref bool useDelegate) {} // 0x0000000181B59400-0x0000000181B59410
		private static bool UseDelegate() => default; // 0x000000018BC811AC-0x000000018BC812B0
		private static int allocate_block(ref Block block) => default; // 0x000000018BC812B0-0x000000018BC81304
		private static void forward_mono_allocate_block(ref Block block, ref int error) {} // 0x0000000185F455A0-0x0000000185F45630
		internal static Unity.Collections.Allocator LegacyOf(AllocatorHandle handle) => default; // 0x0000000185492010-0x0000000185492020
		private static int TryLegacy(ref Block block) => default; // 0x0000000185F45590-0x0000000185F455A0
		public static int Try(ref Block block) => default; // 0x000000018BC81304-0x000000018BC81390
		internal static bool IsCustomAllocator(AllocatorHandle allocator) => default;
		public static void Initialize_StackAllocator_Try_000000A0_BurstDirectCall() {} // 0x000000018BC80EA0-0x000000018BC80F00
		public static void Initialize_SlabAllocator_Try_000000AE_BurstDirectCall() {} // 0x000000018BC803B8-0x000000018BC80420
	}

	internal class CreatePropertyAttribute : Attribute // TypeDefIndex: 58222
	{
		// Constructors
		public CreatePropertyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal struct Bitwise // TypeDefIndex: 58223
	{
		// Methods
		internal static int FromBool(bool value) => default; // 0x00000001849AA700-0x00000001849AA710
		internal static uint ExtractBits(uint input, int pos, uint mask) => default; // 0x0000000185FD7430-0x0000000185FD7440
		internal static uint ReplaceBits(uint input, int pos, uint mask, uint value) => default; // 0x0000000185FD7470-0x0000000185FD7490
		internal static uint SetBits(uint input, int pos, uint mask, bool value) => default; // 0x00000001849AA6B0-0x00000001849AA6D0
		internal static ulong ExtractBits(ulong input, int pos, ulong mask) => default; // 0x0000000185FD7420-0x0000000185FD7430
		internal static ulong ReplaceBits(ulong input, int pos, ulong mask, ulong value) => default; // 0x0000000185FD7440-0x0000000185FD7470
		internal static ulong SetBits(ulong input, int pos, ulong mask, bool value) => default; // 0x00000001849AA6D0-0x00000001849AA700
	}

	public struct BitField32 // TypeDefIndex: 58224
	{
		// Fields
		public uint Value; // 0x00
	
		// Methods
		public void SetBits(int pos, bool value) {} // 0x000000018646EE84-0x000000018646EEB0
		public uint GetBits(int pos, int numBits = 1 /* Metadata: 0x0207F503 */) => default; // 0x0000000185FD73D0-0x0000000185FD73F0
		public bool IsSet(int pos) => default; // 0x00000001844876C0-0x00000001844876D0
	}

	internal sealed class BitField32DebugView // TypeDefIndex: 58225
	{
		// Constructors
		public BitField32DebugView() {} // Dummy constructor
	}

	public struct BitField64 // TypeDefIndex: 58226
	{
		// Fields
		public ulong Value; // 0x00
	
		// Methods
		public void SetBits(int pos, bool value) {} // 0x000000018646EE50-0x000000018646EE84
		public ulong GetBits(int pos, int numBits = 1 /* Metadata: 0x0207F504 */) => default; // 0x0000000185FD73F0-0x0000000185FD7420
		public bool IsSet(int pos) => default; // 0x0000000185569120-0x0000000185569140
		public bool TestAny(int pos, int numBits = 1 /* Metadata: 0x0207F505 */) => default; // 0x0000000184091270-0x00000001840912A0
	}

	internal sealed class BitField64DebugView // TypeDefIndex: 58227
	{
		// Constructors
		public BitField64DebugView() {} // Dummy constructor
	}

	public class BurstCompatibleAttribute : Attribute // TypeDefIndex: 58228
	{
		// Fields
		private System.Type[] _GenericTypeArguments_k__BackingField; // 0x10
		public string RequiredUnityDefine; // 0x18
	
		// Properties
		public System.Type[] GenericTypeArguments { get; set; } // 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public BurstCompatibleAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class NotBurstCompatibleAttribute : Attribute // TypeDefIndex: 58229
	{
		// Constructors
		public NotBurstCompatibleAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public interface INativeDisposable : IDisposable // TypeDefIndex: 58230
	{
	}

	public static class CollectionHelper // TypeDefIndex: 58231
	{
		// Methods
		public static int Log2Floor(int value) => default; // 0x0000000186F1C644-0x0000000186F1CA94
		public static int Align(int size, int alignmentPowerOfTwo) => default; // 0x00000001844DD380-0x00000001844DD3A0
		public static unsafe uint Hash(void* ptr, int bytes) => default; // 0x0000000185533DA0-0x0000000185533DD0
		internal static bool ShouldDeallocate(AllocatorManager.AllocatorHandle allocator) => default; // 0x0000000185135790-0x00000001851357B0
		internal static int AssumePositive(int value) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public static NativeArray<T> CreateNativeArray<T>(int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x0207F506 */)
			where T : struct => default;
		public static NativeArray<T> CreateNativeArray<T>(T[] array, AllocatorManager.AllocatorHandle allocator)
			where T : struct => default;
	}

	internal struct FixedList // TypeDefIndex: 58232
	{
		// Methods
		internal static int PaddingBytes<T>()
			where T : struct => default;
		internal static int StorageBytes<BUFFER, T>()
			where BUFFER : struct
			where T : struct => default;
		internal static int Capacity<BUFFER, T>()
			where BUFFER : struct
			where T : struct => default;
	}

	[Serializable]
	public struct FixedList32Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 58233
		where T : struct
	{
		// Fields
		internal ushort length;
		internal FixedBytes30 buffer;
	
		// Properties
		public int Length { get => default; set {} }
		internal int LengthInBytes { get => default; }
		internal unsafe byte* Buffer { get => default; }
		public int Capacity { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Methods
		public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
		private ref T _refReturnTypeForElementAt; // Dummy field
		public override int GetHashCode() => default;
		public void Add(in ref T item) {}
		public void RemoveAtSwapBack(int index) {}
		public void RemoveRangeSwapBack(int index, int count) {}
		public void RemoveAt(int index) {}
		public void RemoveRange(int index, int count) {}
		public int CompareTo(FixedList32Bytes<T> other) => default;
		public bool Equals(FixedList32Bytes<T> other) => default;
		public int CompareTo(FixedList64Bytes<T> other) => default;
		public bool Equals(FixedList64Bytes<T> other) => default;
		public int CompareTo(FixedList128Bytes<T> other) => default;
		public bool Equals(FixedList128Bytes<T> other) => default;
		public int CompareTo(FixedList512Bytes<T> other) => default;
		public bool Equals(FixedList512Bytes<T> other) => default;
		public int CompareTo(FixedList4096Bytes<T> other) => default;
		public bool Equals(FixedList4096Bytes<T> other) => default;
		public override bool Equals(object obj) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	}

	public static class FixedList32BytesExtensions // TypeDefIndex: 58234
	{
		// Methods
		public static int IndexOf<T, U>(ref FixedList32Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		public static bool Contains<T, U>(ref FixedList32Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
	}

	internal sealed class FixedList32BytesDebugView<T> // TypeDefIndex: 58235
		where T : struct
	{
		// Constructors
		public FixedList32BytesDebugView() {} // Dummy constructor
	}

	[Serializable]
	public struct FixedList64Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 58236
		where T : struct
	{
		// Fields
		internal ushort length;
		internal FixedBytes62 buffer;
	
		// Properties
		public int Length { get => default; set {} }
		internal int LengthInBytes { get => default; }
		internal unsafe byte* Buffer { get => default; }
		public int Capacity { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Methods
		public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
		private ref T _refReturnTypeForElementAt; // Dummy field
		public override int GetHashCode() => default;
		public void Add(in ref T item) {}
		public void RemoveAtSwapBack(int index) {}
		public void RemoveRangeSwapBack(int index, int count) {}
		public void RemoveAt(int index) {}
		public void RemoveRange(int index, int count) {}
		public int CompareTo(FixedList32Bytes<T> other) => default;
		public bool Equals(FixedList32Bytes<T> other) => default;
		public int CompareTo(FixedList64Bytes<T> other) => default;
		public bool Equals(FixedList64Bytes<T> other) => default;
		public int CompareTo(FixedList128Bytes<T> other) => default;
		public bool Equals(FixedList128Bytes<T> other) => default;
		public int CompareTo(FixedList512Bytes<T> other) => default;
		public bool Equals(FixedList512Bytes<T> other) => default;
		public int CompareTo(FixedList4096Bytes<T> other) => default;
		public bool Equals(FixedList4096Bytes<T> other) => default;
		public override bool Equals(object obj) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	}

	public static class FixedList64BytesExtensions // TypeDefIndex: 58237
	{
		// Methods
		public static int IndexOf<T, U>(ref FixedList64Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		public static bool Contains<T, U>(ref FixedList64Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
	}

	internal sealed class FixedList64BytesDebugView<T> // TypeDefIndex: 58238
		where T : struct
	{
		// Constructors
		public FixedList64BytesDebugView() {} // Dummy constructor
	}

	[Serializable]
	public struct FixedList128Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 58239
		where T : struct
	{
		// Fields
		internal ushort length;
		internal FixedBytes126 buffer;
	
		// Properties
		public int Length { get => default; set {} }
		public bool IsEmpty { get => default; }
		internal int LengthInBytes { get => default; }
		internal unsafe byte* Buffer { get => default; }
		public int Capacity { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Methods
		public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
		private ref T _refReturnTypeForElementAt; // Dummy field
		public override int GetHashCode() => default;
		public void Add(in ref T item) {}
		public void AddNoResize(in ref T item) {}
		public void Clear() {}
		public void RemoveAtSwapBack(int index) {}
		public void RemoveRangeSwapBack(int index, int count) {}
		public void RemoveAt(int index) {}
		public void RemoveRange(int index, int count) {}
		public int CompareTo(FixedList32Bytes<T> other) => default;
		public bool Equals(FixedList32Bytes<T> other) => default;
		public int CompareTo(FixedList64Bytes<T> other) => default;
		public bool Equals(FixedList64Bytes<T> other) => default;
		public int CompareTo(FixedList128Bytes<T> other) => default;
		public bool Equals(FixedList128Bytes<T> other) => default;
		public int CompareTo(FixedList512Bytes<T> other) => default;
		public bool Equals(FixedList512Bytes<T> other) => default;
		public int CompareTo(FixedList4096Bytes<T> other) => default;
		public bool Equals(FixedList4096Bytes<T> other) => default;
		public override bool Equals(object obj) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	}

	public static class FixedList128BytesExtensions // TypeDefIndex: 58240
	{
		// Methods
		public static int IndexOf<T, U>(ref FixedList128Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		public static bool Contains<T, U>(ref FixedList128Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		public static bool Remove<T, U>(ref FixedList128Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
	}

	internal sealed class FixedList128BytesDebugView<T> // TypeDefIndex: 58241
		where T : struct
	{
		// Constructors
		public FixedList128BytesDebugView() {} // Dummy constructor
	}

	[Serializable]
	public struct FixedList512Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 58243
		where T : struct
	{
		// Fields
		internal ushort length;
		internal FixedBytes510 buffer;
	
		// Properties
		public int Length { get => default; set {} }
		public bool IsEmpty { get => default; }
		internal int LengthInBytes { get => default; }
		internal unsafe byte* Buffer { get => default; }
		public int Capacity { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 58242
		{
			// Fields
			private FixedList512Bytes<T> m_List;
			private int m_Index;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(ref FixedList512Bytes<T> list) : this() {
				m_List = default;
				m_Index = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		// Methods
		public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
		private ref T _refReturnTypeForElementAt; // Dummy field
		public override int GetHashCode() => default;
		public void Add(in ref T item) {}
		public void Clear() {}
		public void RemoveAtSwapBack(int index) {}
		public void RemoveRangeSwapBack(int index, int count) {}
		public void RemoveAt(int index) {}
		public void RemoveRange(int index, int count) {}
		public int CompareTo(FixedList32Bytes<T> other) => default;
		public bool Equals(FixedList32Bytes<T> other) => default;
		public int CompareTo(FixedList64Bytes<T> other) => default;
		public bool Equals(FixedList64Bytes<T> other) => default;
		public int CompareTo(FixedList128Bytes<T> other) => default;
		public bool Equals(FixedList128Bytes<T> other) => default;
		public int CompareTo(FixedList512Bytes<T> other) => default;
		public bool Equals(FixedList512Bytes<T> other) => default;
		public int CompareTo(FixedList4096Bytes<T> other) => default;
		public bool Equals(FixedList4096Bytes<T> other) => default;
		public override bool Equals(object obj) => default;
		public Enumerator GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	}

	public static class FixedList512BytesExtensions // TypeDefIndex: 58244
	{
		// Methods
		public static int IndexOf<T, U>(ref FixedList512Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		public static bool Contains<T, U>(ref FixedList512Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		public static bool Remove<T, U>(ref FixedList512Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
	}

	internal sealed class FixedList512BytesDebugView<T> // TypeDefIndex: 58245
		where T : struct
	{
		// Constructors
		public FixedList512BytesDebugView() {} // Dummy constructor
	}

	[Serializable]
	public struct FixedList4096Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 58246
		where T : struct
	{
		// Fields
		internal ushort length;
		internal FixedBytes4094 buffer;
	
		// Properties
		public int Length { get => default; set {} }
		public bool IsEmpty { get => default; }
		internal int LengthInBytes { get => default; }
		internal unsafe byte* Buffer { get => default; }
		public int Capacity { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Methods
		public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
		private ref T _refReturnTypeForElementAt; // Dummy field
		public override int GetHashCode() => default;
		public void Add(in ref T item) {}
		public void Clear() {}
		public void RemoveAtSwapBack(int index) {}
		public void RemoveRangeSwapBack(int index, int count) {}
		public void RemoveAt(int index) {}
		public void RemoveRange(int index, int count) {}
		public int CompareTo(FixedList32Bytes<T> other) => default;
		public bool Equals(FixedList32Bytes<T> other) => default;
		public int CompareTo(FixedList64Bytes<T> other) => default;
		public bool Equals(FixedList64Bytes<T> other) => default;
		public int CompareTo(FixedList128Bytes<T> other) => default;
		public bool Equals(FixedList128Bytes<T> other) => default;
		public int CompareTo(FixedList512Bytes<T> other) => default;
		public bool Equals(FixedList512Bytes<T> other) => default;
		public int CompareTo(FixedList4096Bytes<T> other) => default;
		public bool Equals(FixedList4096Bytes<T> other) => default;
		public override bool Equals(object obj) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	}

	public static class FixedList4096BytesExtensions // TypeDefIndex: 58247
	{
		// Methods
		public static int IndexOf<T, U>(ref FixedList4096Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		public static bool Contains<T, U>(ref FixedList4096Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
	}

	internal sealed class FixedList4096BytesDebugView<T> // TypeDefIndex: 58248
		where T : struct
	{
		// Constructors
		public FixedList4096BytesDebugView() {} // Dummy constructor
	}

	[Serializable]
	public struct FixedBytes16 // TypeDefIndex: 58249
	{
		// Fields
		public byte byte0000; // 0x00
		public byte byte0001; // 0x01
		public byte byte0002; // 0x02
		public byte byte0003; // 0x03
		public byte byte0004; // 0x04
		public byte byte0005; // 0x05
		public byte byte0006; // 0x06
		public byte byte0007; // 0x07
		public byte byte0008; // 0x08
		public byte byte0009; // 0x09
		public byte byte0010; // 0x0A
		public byte byte0011; // 0x0B
		public byte byte0012; // 0x0C
		public byte byte0013; // 0x0D
		public byte byte0014; // 0x0E
		public byte byte0015; // 0x0F
	}

	[Serializable]
	public struct FixedBytes30 // TypeDefIndex: 58250
	{
		// Fields
		public FixedBytes16 offset0000; // 0x00
		public byte byte0016; // 0x10
		public byte byte0017; // 0x11
		public byte byte0018; // 0x12
		public byte byte0019; // 0x13
		public byte byte0020; // 0x14
		public byte byte0021; // 0x15
		public byte byte0022; // 0x16
		public byte byte0023; // 0x17
		public byte byte0024; // 0x18
		public byte byte0025; // 0x19
		public byte byte0026; // 0x1A
		public byte byte0027; // 0x1B
		public byte byte0028; // 0x1C
		public byte byte0029; // 0x1D
	}

	[Serializable]
	public struct FixedString32Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 58251
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 29; // Metadata: 0x0207F508
		internal ushort utf8LengthInBytes; // 0x00
		internal FixedBytes30 bytes; // 0x02
	
		// Properties
		public string Value { get => default; } // 0x000000018646EC6C-0x000000018646EC74 
		public int Length { get => default; set {} } // 0x0000000182FA7E40-0x0000000182FA7E50 0x0000000185FD74D0-0x0000000185FD74E0
		public bool IsEmpty { get => default; } // 0x000000018BC7E0EC-0x000000018BC7E0F4 
	
		// Constructors
		public FixedString32Bytes(string source) : this() {
			utf8LengthInBytes = default;
			bytes = default;
		} // 0x00000001843E71C0-0x00000001843E71E0
	
		// Methods
		public unsafe byte* GetUnsafePtr() => default; // 0x0000000185FD74C0-0x0000000185FD74D0
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0207F507 */) => default; // 0x000000018BC7E080-0x000000018BC7E0EC
		public int CompareTo(string other) => default; // 0x000000018BC7DBD8-0x000000018BC7DC0C
		public bool Equals(string other) => default; // 0x000000018BC7DCF0-0x000000018BC7DD74
		internal int Initialize(string source) => default; // 0x00000001843E71E0-0x00000001843E7320
		public int CompareTo(FixedString32Bytes other) => default; // 0x000000018BC7DC58-0x000000018BC7DCA4
		public static bool operator ==(in FixedString32Bytes a, in FixedString32Bytes b) => default; // 0x000000018BC7E180-0x000000018BC7E200
		public bool Equals(FixedString32Bytes other) => default; // 0x000000018BC7DD9C-0x000000018BC7DDB0
		public int CompareTo(FixedString64Bytes other) => default; // 0x000000018BC7DCA4-0x000000018BC7DCF0
		public static bool operator ==(in FixedString32Bytes a, in FixedString64Bytes b) => default; // 0x000000018BC7E0F4-0x000000018BC7E180
		public bool Equals(FixedString64Bytes other) => default; // 0x000000018BC7DD88-0x000000018BC7DD9C
		public int CompareTo(FixedString128Bytes other) => default; // 0x000000018BC7DB8C-0x000000018BC7DBD8
		public static bool operator ==(in FixedString32Bytes a, in FixedString128Bytes b) => default; // 0x000000018BC7E28C-0x000000018BC7E318
		public bool Equals(FixedString128Bytes other) => default; // 0x000000018BC7DDB0-0x000000018BC7DDC4
		public int CompareTo(FixedString512Bytes other) => default; // 0x000000018BC7DB40-0x000000018BC7DB8C
		public static bool operator ==(in FixedString32Bytes a, in FixedString512Bytes b) => default; // 0x000000018BC7E200-0x000000018BC7E28C
		public bool Equals(FixedString512Bytes other) => default; // 0x000000018BC7DD74-0x000000018BC7DD88
		public int CompareTo(FixedString4096Bytes other) => default; // 0x000000018BC7DC0C-0x000000018BC7DC58
		public static bool operator ==(in FixedString32Bytes a, in FixedString4096Bytes b) => default; // 0x000000018BC7E318-0x000000018BC7E3A4
		public bool Equals(FixedString4096Bytes other) => default; // 0x000000018BC7E06C-0x000000018BC7E080
		public static implicit operator FixedString32Bytes(string b) => default; // 0x00000001843E7190-0x00000001843E71C0
		public override string ToString() => default; // 0x00000001851E7C10-0x00000001851E7C50
		public override int GetHashCode() => default; // 0x00000001851DDFC0-0x00000001851DE000
		public override bool Equals(object obj) => default; // 0x000000018BC7DDC4-0x000000018BC7E06C
	}

	[Serializable]
	public struct FixedBytes62 // TypeDefIndex: 58252
	{
		// Fields
		public FixedBytes16 offset0000; // 0x00
		public FixedBytes16 offset0016; // 0x10
		public FixedBytes16 offset0032; // 0x20
		public byte byte0048; // 0x30
		public byte byte0049; // 0x31
		public byte byte0050; // 0x32
		public byte byte0051; // 0x33
		public byte byte0052; // 0x34
		public byte byte0053; // 0x35
		public byte byte0054; // 0x36
		public byte byte0055; // 0x37
		public byte byte0056; // 0x38
		public byte byte0057; // 0x39
		public byte byte0058; // 0x3A
		public byte byte0059; // 0x3B
		public byte byte0060; // 0x3C
		public byte byte0061; // 0x3D
	}

	[Serializable]
	public struct FixedString64Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 58253
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 61; // Metadata: 0x0207F50B
		internal ushort utf8LengthInBytes; // 0x00
		internal FixedBytes62 bytes; // 0x02
	
		// Properties
		public string Value { get => default; } // 0x000000018646F880-0x000000018646F888 
		public int Length { get => default; set {} } // 0x0000000182FA7E40-0x0000000182FA7E50 0x0000000185FD74D0-0x0000000185FD74E0
		public bool IsEmpty { get => default; } // 0x000000018BC7E0EC-0x000000018BC7E0F4 
	
		// Constructors
		public FixedString64Bytes(string source) : this() {
			utf8LengthInBytes = default;
			bytes = default;
		} // 0x00000001843E85D0-0x00000001843E85F0
	
		// Methods
		public unsafe byte* GetUnsafePtr() => default; // 0x0000000185FD74C0-0x0000000185FD74D0
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0207F50A */) => default; // 0x000000018BC7FAD0-0x000000018BC7FB3C
		public int CompareTo(string other) => default; // 0x000000018BC7F638-0x000000018BC7F66C
		public bool Equals(string other) => default; // 0x000000018BC7F9E8-0x000000018BC7FA6C
		internal int Initialize(string source) => default; // 0x00000001843E85F0-0x00000001843E8730
		public int CompareTo(FixedString32Bytes other) => default; // 0x000000018BC7F66C-0x000000018BC7F6B8
		public static bool operator ==(in FixedString64Bytes a, in FixedString32Bytes b) => default; // 0x000000018BC7FC54-0x000000018BC7FCE0
		public bool Equals(FixedString32Bytes other) => default; // 0x000000018BC7F9AC-0x000000018BC7F9C0
		public int CompareTo(FixedString64Bytes other) => default; // 0x000000018BC7F6B8-0x000000018BC7F704
		public static bool operator ==(in FixedString64Bytes a, in FixedString64Bytes b) => default; // 0x000000018BC7FCE0-0x000000018BC7FD60
		public bool Equals(FixedString64Bytes other) => default; // 0x000000018BC7F9D4-0x000000018BC7F9E8
		public int CompareTo(FixedString128Bytes other) => default; // 0x000000018BC7F5A0-0x000000018BC7F5EC
		public static bool operator ==(in FixedString64Bytes a, in FixedString128Bytes b) => default; // 0x000000018BC7FBC8-0x000000018BC7FC54
		public bool Equals(FixedString128Bytes other) => default; // 0x000000018BC7F9C0-0x000000018BC7F9D4
		public int CompareTo(FixedString512Bytes other) => default; // 0x000000018BC7F554-0x000000018BC7F5A0
		public static bool operator ==(in FixedString64Bytes a, in FixedString512Bytes b) => default; // 0x000000018BC7FB3C-0x000000018BC7FBC8
		public bool Equals(FixedString512Bytes other) => default; // 0x000000018BC7FA6C-0x000000018BC7FA80
		public int CompareTo(FixedString4096Bytes other) => default; // 0x000000018BC7F5EC-0x000000018BC7F638
		public static bool operator ==(in FixedString64Bytes a, in FixedString4096Bytes b) => default; // 0x000000018BC7FD60-0x000000018BC7FDEC
		public bool Equals(FixedString4096Bytes other) => default; // 0x000000018BC7FA80-0x000000018BC7FA94
		public static implicit operator FixedString64Bytes(string b) => default; // 0x00000001843E85A0-0x00000001843E85D0
		public override string ToString() => default; // 0x000000018503AE40-0x000000018503AF70
		public override int GetHashCode() => default; // 0x000000018BC7FA94-0x000000018BC7FAD0
		public override bool Equals(object obj) => default; // 0x000000018BC7F704-0x000000018BC7F9AC
	}

	[Serializable]
	public struct FixedBytes126 // TypeDefIndex: 58254
	{
		// Fields
		public FixedBytes16 offset0000; // 0x00
		public FixedBytes16 offset0016; // 0x10
		public FixedBytes16 offset0032; // 0x20
		public FixedBytes16 offset0048; // 0x30
		public FixedBytes16 offset0064; // 0x40
		public FixedBytes16 offset0080; // 0x50
		public FixedBytes16 offset0096; // 0x60
		public byte byte0112; // 0x70
		public byte byte0113; // 0x71
		public byte byte0114; // 0x72
		public byte byte0115; // 0x73
		public byte byte0116; // 0x74
		public byte byte0117; // 0x75
		public byte byte0118; // 0x76
		public byte byte0119; // 0x77
		public byte byte0120; // 0x78
		public byte byte0121; // 0x79
		public byte byte0122; // 0x7A
		public byte byte0123; // 0x7B
		public byte byte0124; // 0x7C
		public byte byte0125; // 0x7D
	}

	[Serializable]
	public struct FixedString128Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 58255
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 125; // Metadata: 0x0207F50E
		internal ushort utf8LengthInBytes; // 0x00
		internal FixedBytes126 bytes; // 0x02
	
		// Properties
		public int Length { get => default; set {} } // 0x0000000182FA7E40-0x0000000182FA7E50 0x0000000185FD74D0-0x0000000185FD74E0
	
		// Constructors
		public FixedString128Bytes(string source) : this() {
			utf8LengthInBytes = default;
			bytes = default;
		} // 0x0000000184DE94E0-0x0000000184DE9510
	
		// Methods
		public unsafe byte* GetUnsafePtr() => default; // 0x0000000185FD74C0-0x0000000185FD74D0
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0207F50D */) => default; // 0x000000018BC7D824-0x000000018BC7D890
		public int CompareTo(string other) => default; // 0x000000018BC7D350-0x000000018BC7D384
		public bool Equals(string other) => default; // 0x000000018BC7D46C-0x000000018BC7D4F0
		internal int Initialize(string source) => default; // 0x0000000184DE9510-0x0000000184DE9590
		public int CompareTo(FixedString32Bytes other) => default; // 0x000000018BC7D3D0-0x000000018BC7D41C
		public static bool operator ==(in FixedString128Bytes a, in FixedString32Bytes b) => default; // 0x000000018BC7D91C-0x000000018BC7D9A8
		public bool Equals(FixedString32Bytes other) => default; // 0x000000018BC7D458-0x000000018BC7D46C
		public int CompareTo(FixedString64Bytes other) => default; // 0x000000018BC7D384-0x000000018BC7D3D0
		public static bool operator ==(in FixedString128Bytes a, in FixedString64Bytes b) => default; // 0x000000018BC7DA28-0x000000018BC7DAB4
		public bool Equals(FixedString64Bytes other) => default; // 0x000000018BC7D4F0-0x000000018BC7D504
		public int CompareTo(FixedString128Bytes other) => default; // 0x000000018BC7D2B8-0x000000018BC7D304
		public static bool operator ==(in FixedString128Bytes a, in FixedString128Bytes b) => default; // 0x000000018BC7D9A8-0x000000018BC7DA28
		public bool Equals(FixedString128Bytes other) => default; // 0x000000018BC7D444-0x000000018BC7D458
		public int CompareTo(FixedString512Bytes other) => default; // 0x000000018BC7D304-0x000000018BC7D350
		public static bool operator ==(in FixedString128Bytes a, in FixedString512Bytes b) => default; // 0x000000018BC7D890-0x000000018BC7D91C
		public bool Equals(FixedString512Bytes other) => default; // 0x000000018BC7D41C-0x000000018BC7D430
		public int CompareTo(FixedString4096Bytes other) => default; // 0x000000018BC7D26C-0x000000018BC7D2B8
		public static bool operator ==(in FixedString128Bytes a, in FixedString4096Bytes b) => default; // 0x000000018BC7DAB4-0x000000018BC7DB40
		public bool Equals(FixedString4096Bytes other) => default; // 0x000000018BC7D430-0x000000018BC7D444
		public static implicit operator FixedString128Bytes(string b) => default; // 0x0000000184DE94A0-0x0000000184DE94E0
		public override string ToString() => default; // 0x000000018BC7D7E8-0x000000018BC7D824
		public override int GetHashCode() => default; // 0x000000018BC7D7AC-0x000000018BC7D7E8
		public override bool Equals(object obj) => default; // 0x000000018BC7D504-0x000000018BC7D7AC
	}

	[Serializable]
	public struct FixedBytes510 // TypeDefIndex: 58256
	{
		// Fields
		public FixedBytes16 offset0000; // 0x00
		public FixedBytes16 offset0016; // 0x10
		public FixedBytes16 offset0032; // 0x20
		public FixedBytes16 offset0048; // 0x30
		public FixedBytes16 offset0064; // 0x40
		public FixedBytes16 offset0080; // 0x50
		public FixedBytes16 offset0096; // 0x60
		public FixedBytes16 offset0112; // 0x70
		public FixedBytes16 offset0128; // 0x80
		public FixedBytes16 offset0144; // 0x90
		public FixedBytes16 offset0160; // 0xA0
		public FixedBytes16 offset0176; // 0xB0
		public FixedBytes16 offset0192; // 0xC0
		public FixedBytes16 offset0208; // 0xD0
		public FixedBytes16 offset0224; // 0xE0
		public FixedBytes16 offset0240; // 0xF0
		public FixedBytes16 offset0256; // 0x100
		public FixedBytes16 offset0272; // 0x110
		public FixedBytes16 offset0288; // 0x120
		public FixedBytes16 offset0304; // 0x130
		public FixedBytes16 offset0320; // 0x140
		public FixedBytes16 offset0336; // 0x150
		public FixedBytes16 offset0352; // 0x160
		public FixedBytes16 offset0368; // 0x170
		public FixedBytes16 offset0384; // 0x180
		public FixedBytes16 offset0400; // 0x190
		public FixedBytes16 offset0416; // 0x1A0
		public FixedBytes16 offset0432; // 0x1B0
		public FixedBytes16 offset0448; // 0x1C0
		public FixedBytes16 offset0464; // 0x1D0
		public FixedBytes16 offset0480; // 0x1E0
		public byte byte0496; // 0x1F0
		public byte byte0497; // 0x1F1
		public byte byte0498; // 0x1F2
		public byte byte0499; // 0x1F3
		public byte byte0500; // 0x1F4
		public byte byte0501; // 0x1F5
		public byte byte0502; // 0x1F6
		public byte byte0503; // 0x1F7
		public byte byte0504; // 0x1F8
		public byte byte0505; // 0x1F9
		public byte byte0506; // 0x1FA
		public byte byte0507; // 0x1FB
		public byte byte0508; // 0x1FC
		public byte byte0509; // 0x1FD
	}

	[Serializable]
	public struct FixedString512Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 58257
	{
		// Fields
		internal ushort utf8LengthInBytes; // 0x00
		internal FixedBytes510 bytes; // 0x02
	
		// Properties
		public int Length { get => default; } // 0x0000000182FA7E40-0x0000000182FA7E50 
	
		// Methods
		public unsafe byte* GetUnsafePtr() => default; // 0x0000000185FD74C0-0x0000000185FD74D0
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0207F510 */) => default; // 0x000000018BC7F234-0x000000018BC7F2A4
		public int CompareTo(string other) => default; // 0x000000018BC7EDAC-0x000000018BC7EDE0
		public bool Equals(string other) => default; // 0x000000018BC7F138-0x000000018BC7F1BC
		public int CompareTo(FixedString32Bytes other) => default; // 0x000000018BC7EDE0-0x000000018BC7EE2C
		public static bool operator ==(in FixedString512Bytes a, in FixedString32Bytes b) => default; // 0x000000018BC7F4C8-0x000000018BC7F554
		public bool Equals(FixedString32Bytes other) => default; // 0x000000018BC7EE40-0x000000018BC7EE54
		public int CompareTo(FixedString64Bytes other) => default; // 0x000000018BC7ED14-0x000000018BC7ED60
		public static bool operator ==(in FixedString512Bytes a, in FixedString64Bytes b) => default; // 0x000000018BC7F43C-0x000000018BC7F4C8
		public bool Equals(FixedString64Bytes other) => default; // 0x000000018BC7EE2C-0x000000018BC7EE40
		public int CompareTo(FixedString128Bytes other) => default; // 0x000000018BC7ECC8-0x000000018BC7ED14
		public static bool operator ==(in FixedString512Bytes a, in FixedString128Bytes b) => default; // 0x000000018BC7F324-0x000000018BC7F3B0
		public bool Equals(FixedString128Bytes other) => default; // 0x000000018BC7F110-0x000000018BC7F124
		public int CompareTo(FixedString512Bytes other) => default; // 0x000000018BC7EC7C-0x000000018BC7ECC8
		public static bool operator ==(in FixedString512Bytes a, in FixedString512Bytes b) => default; // 0x000000018BC7F2A4-0x000000018BC7F324
		public bool Equals(FixedString512Bytes other) => default; // 0x000000018BC7F0FC-0x000000018BC7F110
		public int CompareTo(FixedString4096Bytes other) => default; // 0x000000018BC7ED60-0x000000018BC7EDAC
		public static bool operator ==(in FixedString512Bytes a, in FixedString4096Bytes b) => default; // 0x000000018BC7F3B0-0x000000018BC7F43C
		public bool Equals(FixedString4096Bytes other) => default; // 0x000000018BC7F124-0x000000018BC7F138
		public override string ToString() => default; // 0x000000018BC7F1F8-0x000000018BC7F234
		public override int GetHashCode() => default; // 0x000000018BC7F1BC-0x000000018BC7F1F8
		public override bool Equals(object obj) => default; // 0x000000018BC7EE54-0x000000018BC7F0FC
	}

	[Serializable]
	public struct FixedBytes4094 // TypeDefIndex: 58258
	{
		// Fields
		public FixedBytes16 offset0000; // 0x00
		public FixedBytes16 offset0016; // 0x10
		public FixedBytes16 offset0032; // 0x20
		public FixedBytes16 offset0048; // 0x30
		public FixedBytes16 offset0064; // 0x40
		public FixedBytes16 offset0080; // 0x50
		public FixedBytes16 offset0096; // 0x60
		public FixedBytes16 offset0112; // 0x70
		public FixedBytes16 offset0128; // 0x80
		public FixedBytes16 offset0144; // 0x90
		public FixedBytes16 offset0160; // 0xA0
		public FixedBytes16 offset0176; // 0xB0
		public FixedBytes16 offset0192; // 0xC0
		public FixedBytes16 offset0208; // 0xD0
		public FixedBytes16 offset0224; // 0xE0
		public FixedBytes16 offset0240; // 0xF0
		public FixedBytes16 offset0256; // 0x100
		public FixedBytes16 offset0272; // 0x110
		public FixedBytes16 offset0288; // 0x120
		public FixedBytes16 offset0304; // 0x130
		public FixedBytes16 offset0320; // 0x140
		public FixedBytes16 offset0336; // 0x150
		public FixedBytes16 offset0352; // 0x160
		public FixedBytes16 offset0368; // 0x170
		public FixedBytes16 offset0384; // 0x180
		public FixedBytes16 offset0400; // 0x190
		public FixedBytes16 offset0416; // 0x1A0
		public FixedBytes16 offset0432; // 0x1B0
		public FixedBytes16 offset0448; // 0x1C0
		public FixedBytes16 offset0464; // 0x1D0
		public FixedBytes16 offset0480; // 0x1E0
		public FixedBytes16 offset0496; // 0x1F0
		public FixedBytes16 offset0512; // 0x200
		public FixedBytes16 offset0528; // 0x210
		public FixedBytes16 offset0544; // 0x220
		public FixedBytes16 offset0560; // 0x230
		public FixedBytes16 offset0576; // 0x240
		public FixedBytes16 offset0592; // 0x250
		public FixedBytes16 offset0608; // 0x260
		public FixedBytes16 offset0624; // 0x270
		public FixedBytes16 offset0640; // 0x280
		public FixedBytes16 offset0656; // 0x290
		public FixedBytes16 offset0672; // 0x2A0
		public FixedBytes16 offset0688; // 0x2B0
		public FixedBytes16 offset0704; // 0x2C0
		public FixedBytes16 offset0720; // 0x2D0
		public FixedBytes16 offset0736; // 0x2E0
		public FixedBytes16 offset0752; // 0x2F0
		public FixedBytes16 offset0768; // 0x300
		public FixedBytes16 offset0784; // 0x310
		public FixedBytes16 offset0800; // 0x320
		public FixedBytes16 offset0816; // 0x330
		public FixedBytes16 offset0832; // 0x340
		public FixedBytes16 offset0848; // 0x350
		public FixedBytes16 offset0864; // 0x360
		public FixedBytes16 offset0880; // 0x370
		public FixedBytes16 offset0896; // 0x380
		public FixedBytes16 offset0912; // 0x390
		public FixedBytes16 offset0928; // 0x3A0
		public FixedBytes16 offset0944; // 0x3B0
		public FixedBytes16 offset0960; // 0x3C0
		public FixedBytes16 offset0976; // 0x3D0
		public FixedBytes16 offset0992; // 0x3E0
		public FixedBytes16 offset1008; // 0x3F0
		public FixedBytes16 offset1024; // 0x400
		public FixedBytes16 offset1040; // 0x410
		public FixedBytes16 offset1056; // 0x420
		public FixedBytes16 offset1072; // 0x430
		public FixedBytes16 offset1088; // 0x440
		public FixedBytes16 offset1104; // 0x450
		public FixedBytes16 offset1120; // 0x460
		public FixedBytes16 offset1136; // 0x470
		public FixedBytes16 offset1152; // 0x480
		public FixedBytes16 offset1168; // 0x490
		public FixedBytes16 offset1184; // 0x4A0
		public FixedBytes16 offset1200; // 0x4B0
		public FixedBytes16 offset1216; // 0x4C0
		public FixedBytes16 offset1232; // 0x4D0
		public FixedBytes16 offset1248; // 0x4E0
		public FixedBytes16 offset1264; // 0x4F0
		public FixedBytes16 offset1280; // 0x500
		public FixedBytes16 offset1296; // 0x510
		public FixedBytes16 offset1312; // 0x520
		public FixedBytes16 offset1328; // 0x530
		public FixedBytes16 offset1344; // 0x540
		public FixedBytes16 offset1360; // 0x550
		public FixedBytes16 offset1376; // 0x560
		public FixedBytes16 offset1392; // 0x570
		public FixedBytes16 offset1408; // 0x580
		public FixedBytes16 offset1424; // 0x590
		public FixedBytes16 offset1440; // 0x5A0
		public FixedBytes16 offset1456; // 0x5B0
		public FixedBytes16 offset1472; // 0x5C0
		public FixedBytes16 offset1488; // 0x5D0
		public FixedBytes16 offset1504; // 0x5E0
		public FixedBytes16 offset1520; // 0x5F0
		public FixedBytes16 offset1536; // 0x600
		public FixedBytes16 offset1552; // 0x610
		public FixedBytes16 offset1568; // 0x620
		public FixedBytes16 offset1584; // 0x630
		public FixedBytes16 offset1600; // 0x640
		public FixedBytes16 offset1616; // 0x650
		public FixedBytes16 offset1632; // 0x660
		public FixedBytes16 offset1648; // 0x670
		public FixedBytes16 offset1664; // 0x680
		public FixedBytes16 offset1680; // 0x690
		public FixedBytes16 offset1696; // 0x6A0
		public FixedBytes16 offset1712; // 0x6B0
		public FixedBytes16 offset1728; // 0x6C0
		public FixedBytes16 offset1744; // 0x6D0
		public FixedBytes16 offset1760; // 0x6E0
		public FixedBytes16 offset1776; // 0x6F0
		public FixedBytes16 offset1792; // 0x700
		public FixedBytes16 offset1808; // 0x710
		public FixedBytes16 offset1824; // 0x720
		public FixedBytes16 offset1840; // 0x730
		public FixedBytes16 offset1856; // 0x740
		public FixedBytes16 offset1872; // 0x750
		public FixedBytes16 offset1888; // 0x760
		public FixedBytes16 offset1904; // 0x770
		public FixedBytes16 offset1920; // 0x780
		public FixedBytes16 offset1936; // 0x790
		public FixedBytes16 offset1952; // 0x7A0
		public FixedBytes16 offset1968; // 0x7B0
		public FixedBytes16 offset1984; // 0x7C0
		public FixedBytes16 offset2000; // 0x7D0
		public FixedBytes16 offset2016; // 0x7E0
		public FixedBytes16 offset2032; // 0x7F0
		public FixedBytes16 offset2048; // 0x800
		public FixedBytes16 offset2064; // 0x810
		public FixedBytes16 offset2080; // 0x820
		public FixedBytes16 offset2096; // 0x830
		public FixedBytes16 offset2112; // 0x840
		public FixedBytes16 offset2128; // 0x850
		public FixedBytes16 offset2144; // 0x860
		public FixedBytes16 offset2160; // 0x870
		public FixedBytes16 offset2176; // 0x880
		public FixedBytes16 offset2192; // 0x890
		public FixedBytes16 offset2208; // 0x8A0
		public FixedBytes16 offset2224; // 0x8B0
		public FixedBytes16 offset2240; // 0x8C0
		public FixedBytes16 offset2256; // 0x8D0
		public FixedBytes16 offset2272; // 0x8E0
		public FixedBytes16 offset2288; // 0x8F0
		public FixedBytes16 offset2304; // 0x900
		public FixedBytes16 offset2320; // 0x910
		public FixedBytes16 offset2336; // 0x920
		public FixedBytes16 offset2352; // 0x930
		public FixedBytes16 offset2368; // 0x940
		public FixedBytes16 offset2384; // 0x950
		public FixedBytes16 offset2400; // 0x960
		public FixedBytes16 offset2416; // 0x970
		public FixedBytes16 offset2432; // 0x980
		public FixedBytes16 offset2448; // 0x990
		public FixedBytes16 offset2464; // 0x9A0
		public FixedBytes16 offset2480; // 0x9B0
		public FixedBytes16 offset2496; // 0x9C0
		public FixedBytes16 offset2512; // 0x9D0
		public FixedBytes16 offset2528; // 0x9E0
		public FixedBytes16 offset2544; // 0x9F0
		public FixedBytes16 offset2560; // 0xA00
		public FixedBytes16 offset2576; // 0xA10
		public FixedBytes16 offset2592; // 0xA20
		public FixedBytes16 offset2608; // 0xA30
		public FixedBytes16 offset2624; // 0xA40
		public FixedBytes16 offset2640; // 0xA50
		public FixedBytes16 offset2656; // 0xA60
		public FixedBytes16 offset2672; // 0xA70
		public FixedBytes16 offset2688; // 0xA80
		public FixedBytes16 offset2704; // 0xA90
		public FixedBytes16 offset2720; // 0xAA0
		public FixedBytes16 offset2736; // 0xAB0
		public FixedBytes16 offset2752; // 0xAC0
		public FixedBytes16 offset2768; // 0xAD0
		public FixedBytes16 offset2784; // 0xAE0
		public FixedBytes16 offset2800; // 0xAF0
		public FixedBytes16 offset2816; // 0xB00
		public FixedBytes16 offset2832; // 0xB10
		public FixedBytes16 offset2848; // 0xB20
		public FixedBytes16 offset2864; // 0xB30
		public FixedBytes16 offset2880; // 0xB40
		public FixedBytes16 offset2896; // 0xB50
		public FixedBytes16 offset2912; // 0xB60
		public FixedBytes16 offset2928; // 0xB70
		public FixedBytes16 offset2944; // 0xB80
		public FixedBytes16 offset2960; // 0xB90
		public FixedBytes16 offset2976; // 0xBA0
		public FixedBytes16 offset2992; // 0xBB0
		public FixedBytes16 offset3008; // 0xBC0
		public FixedBytes16 offset3024; // 0xBD0
		public FixedBytes16 offset3040; // 0xBE0
		public FixedBytes16 offset3056; // 0xBF0
		public FixedBytes16 offset3072; // 0xC00
		public FixedBytes16 offset3088; // 0xC10
		public FixedBytes16 offset3104; // 0xC20
		public FixedBytes16 offset3120; // 0xC30
		public FixedBytes16 offset3136; // 0xC40
		public FixedBytes16 offset3152; // 0xC50
		public FixedBytes16 offset3168; // 0xC60
		public FixedBytes16 offset3184; // 0xC70
		public FixedBytes16 offset3200; // 0xC80
		public FixedBytes16 offset3216; // 0xC90
		public FixedBytes16 offset3232; // 0xCA0
		public FixedBytes16 offset3248; // 0xCB0
		public FixedBytes16 offset3264; // 0xCC0
		public FixedBytes16 offset3280; // 0xCD0
		public FixedBytes16 offset3296; // 0xCE0
		public FixedBytes16 offset3312; // 0xCF0
		public FixedBytes16 offset3328; // 0xD00
		public FixedBytes16 offset3344; // 0xD10
		public FixedBytes16 offset3360; // 0xD20
		public FixedBytes16 offset3376; // 0xD30
		public FixedBytes16 offset3392; // 0xD40
		public FixedBytes16 offset3408; // 0xD50
		public FixedBytes16 offset3424; // 0xD60
		public FixedBytes16 offset3440; // 0xD70
		public FixedBytes16 offset3456; // 0xD80
		public FixedBytes16 offset3472; // 0xD90
		public FixedBytes16 offset3488; // 0xDA0
		public FixedBytes16 offset3504; // 0xDB0
		public FixedBytes16 offset3520; // 0xDC0
		public FixedBytes16 offset3536; // 0xDD0
		public FixedBytes16 offset3552; // 0xDE0
		public FixedBytes16 offset3568; // 0xDF0
		public FixedBytes16 offset3584; // 0xE00
		public FixedBytes16 offset3600; // 0xE10
		public FixedBytes16 offset3616; // 0xE20
		public FixedBytes16 offset3632; // 0xE30
		public FixedBytes16 offset3648; // 0xE40
		public FixedBytes16 offset3664; // 0xE50
		public FixedBytes16 offset3680; // 0xE60
		public FixedBytes16 offset3696; // 0xE70
		public FixedBytes16 offset3712; // 0xE80
		public FixedBytes16 offset3728; // 0xE90
		public FixedBytes16 offset3744; // 0xEA0
		public FixedBytes16 offset3760; // 0xEB0
		public FixedBytes16 offset3776; // 0xEC0
		public FixedBytes16 offset3792; // 0xED0
		public FixedBytes16 offset3808; // 0xEE0
		public FixedBytes16 offset3824; // 0xEF0
		public FixedBytes16 offset3840; // 0xF00
		public FixedBytes16 offset3856; // 0xF10
		public FixedBytes16 offset3872; // 0xF20
		public FixedBytes16 offset3888; // 0xF30
		public FixedBytes16 offset3904; // 0xF40
		public FixedBytes16 offset3920; // 0xF50
		public FixedBytes16 offset3936; // 0xF60
		public FixedBytes16 offset3952; // 0xF70
		public FixedBytes16 offset3968; // 0xF80
		public FixedBytes16 offset3984; // 0xF90
		public FixedBytes16 offset4000; // 0xFA0
		public FixedBytes16 offset4016; // 0xFB0
		public FixedBytes16 offset4032; // 0xFC0
		public FixedBytes16 offset4048; // 0xFD0
		public FixedBytes16 offset4064; // 0xFE0
		public byte byte4080; // 0xFF0
		public byte byte4081; // 0xFF1
		public byte byte4082; // 0xFF2
		public byte byte4083; // 0xFF3
		public byte byte4084; // 0xFF4
		public byte byte4085; // 0xFF5
		public byte byte4086; // 0xFF6
		public byte byte4087; // 0xFF7
		public byte byte4088; // 0xFF8
		public byte byte4089; // 0xFF9
		public byte byte4090; // 0xFFA
		public byte byte4091; // 0xFFB
		public byte byte4092; // 0xFFC
		public byte byte4093; // 0xFFD
	}

	[Serializable]
	public struct FixedString4096Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 58259
	{
		// Fields
		internal ushort utf8LengthInBytes; // 0x00
		internal FixedBytes4094 bytes; // 0x02
	
		// Properties
		public int Length { get => default; } // 0x0000000182FA7E40-0x0000000182FA7E50 
	
		// Methods
		public unsafe byte* GetUnsafePtr() => default; // 0x0000000185FD74C0-0x0000000185FD74D0
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0207F511 */) => default; // 0x000000018BC7E95C-0x000000018BC7E9CC
		public int CompareTo(string other) => default; // 0x000000018BC7E520-0x000000018BC7E554
		public bool Equals(string other) => default; // 0x000000018BC7E568-0x000000018BC7E5EC
		public int CompareTo(FixedString32Bytes other) => default; // 0x000000018BC7E488-0x000000018BC7E4D4
		public static bool operator ==(in FixedString4096Bytes a, in FixedString32Bytes b) => default; // 0x000000018BC7EAD8-0x000000018BC7EB64
		public bool Equals(FixedString32Bytes other) => default; // 0x000000018BC7E8BC-0x000000018BC7E8D0
		public int CompareTo(FixedString64Bytes other) => default; // 0x000000018BC7E4D4-0x000000018BC7E520
		public static bool operator ==(in FixedString4096Bytes a, in FixedString64Bytes b) => default; // 0x000000018BC7EA4C-0x000000018BC7EAD8
		public bool Equals(FixedString64Bytes other) => default; // 0x000000018BC7E8D0-0x000000018BC7E8E4
		public int CompareTo(FixedString128Bytes other) => default; // 0x000000018BC7E43C-0x000000018BC7E488
		public static bool operator ==(in FixedString4096Bytes a, in FixedString128Bytes b) => default; // 0x000000018BC7EB64-0x000000018BC7EBF0
		public bool Equals(FixedString128Bytes other) => default; // 0x000000018BC7E5EC-0x000000018BC7E600
		public int CompareTo(FixedString512Bytes other) => default; // 0x000000018BC7E3A4-0x000000018BC7E3F0
		public static bool operator ==(in FixedString4096Bytes a, in FixedString512Bytes b) => default; // 0x000000018BC7EBF0-0x000000018BC7EC7C
		public bool Equals(FixedString512Bytes other) => default; // 0x000000018BC7E600-0x000000018BC7E614
		public int CompareTo(FixedString4096Bytes other) => default; // 0x000000018BC7E3F0-0x000000018BC7E43C
		public static bool operator ==(in FixedString4096Bytes a, in FixedString4096Bytes b) => default; // 0x000000018BC7E9CC-0x000000018BC7EA4C
		public bool Equals(FixedString4096Bytes other) => default; // 0x000000018BC7E554-0x000000018BC7E568
		public override string ToString() => default; // 0x000000018BC7E920-0x000000018BC7E95C
		public override int GetHashCode() => default; // 0x000000018BC7E8E4-0x000000018BC7E920
		public override bool Equals(object obj) => default; // 0x000000018BC7E614-0x000000018BC7E8BC
	}

	public static class FixedStringMethods // TypeDefIndex: 58260
	{
		// Methods
		public static unsafe FormatError Append<T>(ref ref T fs, byte* utf8Bytes, int utf8BytesLength)
			where T : struct, INativeList<byte>, IUTF8Bytes => default;
		public static FormatError Append<T>(ref ref T fs, string s)
			where T : struct, INativeList<byte>, IUTF8Bytes => default;
		public static unsafe int CompareTo<T>(ref ref T fs, byte* bytes, int bytesLen)
			where T : struct, INativeList<byte>, IUTF8Bytes => default;
		public static int CompareTo<T, T2>(ref ref T fs, in ref T2 other)
			where T : struct, INativeList<byte>, IUTF8Bytes
			where T2 : struct, INativeList<byte>, IUTF8Bytes => default;
		public static string ConvertToString<T>(ref ref T fs)
			where T : struct, INativeList<byte>, IUTF8Bytes => default;
		public static int ComputeHashCode<T>(ref ref T fs)
			where T : struct, INativeList<byte>, IUTF8Bytes => default;
	}

	public interface IUTF8Bytes // TypeDefIndex: 58261
	{
		// Methods
		byte* GetUnsafePtr();
		bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0207F512 */);
	}

	public static class ListExtensions // TypeDefIndex: 58262
	{
		// Methods
		public static bool RemoveSwapBack<T>(List<T> list, T value) => default;
		public static void RemoveAtSwapBack<T>(List<T> list, int index) {}
		public static NativeArray<T> ToNativeArray<T>(List<T> list, AllocatorManager.AllocatorHandle allocator)
			where T : struct => default;
	}

	internal struct Memory // TypeDefIndex: 58265
	{
		// Nested types
		internal struct Unmanaged // TypeDefIndex: 58264
		{
			// Nested types
			internal struct Array // TypeDefIndex: 58263
			{
				// Methods
				private static bool IsCustom(AllocatorManager.AllocatorHandle allocator) => default; // 0x00000001840A61E0-0x00000001840A6210
				private static unsafe void* CustomResize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align) => default; // 0x00000001851357B0-0x00000001851357F0
				internal static unsafe void* Resize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align) => default;
				internal static unsafe T* Resize<T>(T* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator)
					where T : struct => default; // 0x00000001840A6320-0x00000001840A6330
			}
	
			// Methods
			internal static unsafe void* Allocate(long size, int align, AllocatorManager.AllocatorHandle allocator) => default; // 0x000000018BC7D08C-0x000000018BC7D130
			internal static unsafe void Free(void* pointer, AllocatorManager.AllocatorHandle allocator) {} // 0x00000001840A6210-0x00000001840A6320
			internal static unsafe void Free<T>(T* pointer, AllocatorManager.AllocatorHandle allocator)
				where T : struct {}
		}
	}

	public static class NativeArrayExtensions // TypeDefIndex: 58266
	{
		// Methods
		public static bool Contains<T, U>(NativeList<T> list, U value)
			where T : struct, IEquatable<U> => default;
		public static Span<T> AsSpan<T>(NativeArray<T> array)
			where T : struct => default;
		public static Span<T> AsSpanThread<T>(NativeArray<T> array)
			where T : struct => default;
		public static unsafe int IndexOf<T, U>(void* ptr, int length, U value)
			where T : struct, IEquatable<U> => default;
		public static NativeArray<U> Reinterpret<T, U>(NativeArray<T> array)
			where T : struct
			where U : struct => default;
		internal static void Initialize<T>(ref NativeArray<T> array, int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0207F513 */)
			where T : struct {}
	}

	public interface IIndexable<T> // TypeDefIndex: 58267
		where T : struct
	{
		// Properties
		int Length { get; }
	}

	public interface INativeList<T> : IIndexable<T> // TypeDefIndex: 58268
		where T : struct
	{
	}

	public struct NativeList<T> : INativeDisposable, INativeList<T>, IEnumerable<T> // TypeDefIndex: 58270
		where T : struct
	{
		// Fields
		internal unsafe UnsafeList<T>* m_ListData;
		internal AllocatorManager.AllocatorHandle m_DeprecatedAllocator;
	
		// Properties
		public T this[int index] { get => default; set {} }
		public int Length { get => default; }
		public int Capacity { get => default; set {} }
		public bool IsEmpty { get => default; }
		public bool IsCreated { get => default; }
	
		// Nested types
		public struct ParallelWriter // TypeDefIndex: 58269
		{
			// Fields
			public unsafe UnsafeList<T>* ListData;
	
			// Constructors
			internal unsafe ParallelWriter(UnsafeList<T>* listData) {
				ListData = default;
			}
	
			// Methods
			public void AddNoResize(T value) {}
		}
	
		// Constructors
		public unsafe NativeList(AllocatorManager.AllocatorHandle allocator) : this() {
			m_ListData = default;
			m_DeprecatedAllocator = default;
		}
		public unsafe NativeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator) : this() {
			m_ListData = default;
			m_DeprecatedAllocator = default;
		}
		private unsafe NativeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth) : this() {
			m_ListData = default;
			m_DeprecatedAllocator = default;
		}
	
		// Methods
		internal void Initialize<U>(int initialCapacity, ref ref U allocator, int disposeSentinelStackDepth)
			where U : struct, AllocatorManager.IAllocator {}
		public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
		private ref T _refReturnTypeForElementAt; // Dummy field
		public unsafe UnsafeList<T>* GetUnsafeList() => default;
		public void AddNoResize(T value) {}
		public unsafe void AddRangeNoResize(void* ptr, int count) {}
		public void Add(in ref T value) {}
		public void AddRange(NativeArray<T> array) {}
		public unsafe void AddRange(void* ptr, int count) {}
		public void RemoveAtSwapBack(int index) {}
		public void RemoveAt(int index) {}
		public void RemoveRange(int index, int count) {}
		public void Dispose() {}
		public JobHandle Dispose(JobHandle inputDeps) => default;
		public JobHandle CrossFrameDispose(JobHandle inputDeps, JobQueuePriority priority = JobQueuePriority.NormalJobPriority /* Metadata: 0x0207F514 */) => default;
		public void Clear() {}
		public static implicit operator NativeArray<T>(NativeList<T> nativeList) => default;
		public NativeArray<T> AsArray() => default;
		public NativeArray<T> AsDeferredJobArray() => default;
		public T[] ToArray() => default;
		public NativeArray<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		public void CopyFrom(NativeArray<T> array) {}
		public void Resize(int length, NativeArrayOptions options) {}
		public void ResizeUninitialized(int length) {}
		public NativeArray<T> AsParallelReader() => default;
		public ParallelWriter AsParallelWriter() => default;
	}

	internal struct NativeListDispose // TypeDefIndex: 58271
	{
		// Fields
		public unsafe UntypedUnsafeList* m_ListData; // 0x00
	
		// Methods
		public void Dispose() {} // 0x000000018BC805D0-0x000000018BC8060C
	}

	internal struct NativeListDisposeJob : IJob // TypeDefIndex: 58272
	{
		// Fields
		internal NativeListDispose Data; // 0x00
	
		// Methods
		public void Execute() {} // 0x000000018BC805C8-0x000000018BC805D0
	}

	internal sealed class NativeListDebugView<T> // TypeDefIndex: 58273
		where T : struct
	{
		// Constructors
		public NativeListDebugView() {} // Dummy constructor
	}

	public struct NativeParallelHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 58276
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData;
	
		// Properties
		public bool IsEmpty { get => default; }
		public int Capacity { get => default; set {} }
		public TValue this[TKey key] { get => default; set {} }
		public bool IsCreated { get => default; }
	
		// Nested types
		public struct ParallelWriter // TypeDefIndex: 58274
		{
			// Fields
			internal UnsafeParallelHashMap<TKey, TValue> m_Writer;
	
			// Methods
			public bool TryAdd(TKey key, TValue item) => default;
		}
	
		public struct Enumerator : IEnumerator<KeyValue<TKey, TValue>> // TypeDefIndex: 58275
		{
			// Fields
			internal UnsafeParallelHashMapDataEnumerator m_Enumerator;
	
			// Properties
			public KeyValue<TKey, TValue> Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		// Constructors
		public NativeParallelHashMap(int capacity, AllocatorManager.AllocatorHandle allocator) : this() {
			m_HashMapData = default;
		}
		private NativeParallelHashMap(int capacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth) : this() {
			m_HashMapData = default;
		}
	
		// Methods
		public int Count() => default;
		public void Clear() {}
		public bool TryAdd(TKey key, TValue item) => default;
		public void Add(TKey key, TValue item) {}
		public bool Remove(TKey key) => default;
		public bool TryGetValue(TKey key, out ref TValue item) {
			item = default;
			return default;
		}
		public bool ContainsKey(TKey key) => default;
		public void Dispose() {}
		public JobHandle Dispose(JobHandle inputDeps) => default;
		public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator) => default;
		public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator) => default;
		public ParallelWriter AsParallelWriter() => default;
		public Enumerator GetEnumerator() => default;
		IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal sealed class NativeParallelHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 58277
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Constructors
		public NativeParallelHashMapDebuggerTypeProxy() {} // Dummy constructor
	}

	public static class NativeParallelHashMapExtensions // TypeDefIndex: 58278
	{
		// Methods
		public static UnsafeParallelHashMap<TKey, TValue> GetUnsafeMap<TKey, TValue>(NativeParallelHashMap<TKey, TValue> container)
			where TKey : struct, IEquatable<TKey>, IComparable<TKey>
			where TValue : struct => default;
	}

	public struct NativeParallelHashSet<T> : INativeDisposable, IEnumerable<T> // TypeDefIndex: 58280
		where T : struct, IEquatable<T>
	{
		// Fields
		internal NativeParallelHashMap<T, bool> m_Data;
	
		// Properties
		public bool IsEmpty { get => default; }
		public bool IsCreated { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 58279
		{
			// Fields
			internal UnsafeParallelHashMapDataEnumerator m_Enumerator;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		// Constructors
		public NativeParallelHashSet(int capacity, AllocatorManager.AllocatorHandle allocator) : this() {
			m_Data = default;
		}
	
		// Methods
		public int Count() => default;
		public void Dispose() {}
		public void Clear() {}
		public bool Add(T item) => default;
		public bool Remove(T item) => default;
		public bool Contains(T item) => default;
		public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator) => default;
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal sealed class NativeHashSetDebuggerTypeProxy<T> // TypeDefIndex: 58281
		where T : struct, IEquatable<T>
	{
		// Constructors
		public NativeHashSetDebuggerTypeProxy() {} // Dummy constructor
	}

	public struct NativeParallelMultiHashMapIterator<TKey> // TypeDefIndex: 58282
		where TKey : struct
	{
		// Fields
		internal TKey key;
		internal int NextEntryIndex;
		internal int EntryIndex;
	}

	public struct NativeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 58285
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData;
	
		// Properties
		public bool IsEmpty { get => default; }
		public int Capacity { get => default; }
		public bool IsCreated { get => default; }
	
		// Nested types
		public struct ParallelWriter // TypeDefIndex: 58283
		{
			// Fields
			internal UnsafeParallelMultiHashMap<TKey, TValue> m_Writer;
	
			// Methods
			public void Add(TKey key, TValue item) {}
		}
	
		public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 58284
		{
			// Fields
			internal NativeParallelMultiHashMap<TKey, TValue> hashmap;
			internal TKey key;
			internal bool isFirst;
			private TValue value;
			private NativeParallelMultiHashMapIterator<TKey> iterator;
	
			// Properties
			public TValue Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
			public Enumerator<TKey, TValue> GetEnumerator() => default;
		}
	
		// Constructors
		public NativeParallelMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator) : this() {
			m_MultiHashMapData = default;
		}
		private NativeParallelMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth) : this() {
			m_MultiHashMapData = default;
		}
	
		// Methods
		internal void Initialize<U>(int capacity, ref ref U allocator, int disposeSentinelStackDepth)
			where U : struct, AllocatorManager.IAllocator {}
		public int Count() => default;
		public void Clear() {}
		public void Add(TKey key, TValue item) {}
		public int Remove(TKey key) => default;
		public void Remove(NativeParallelMultiHashMapIterator<TKey> it) {}
		public bool TryGetFirstValue(TKey key, out ref TValue item, out NativeParallelMultiHashMapIterator<TKey> it) {
			item = default;
			it = default;
			return default;
		}
		public bool TryGetNextValue(out ref TValue item, ref NativeParallelMultiHashMapIterator<TKey> it) {
			item = default;
			return default;
		}
		public bool ContainsKey(TKey key) => default;
		public int CountValuesForKey(TKey key) => default;
		public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it) => default;
		public void Dispose() {}
		public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator) => default;
		public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator) => default;
		public Enumerator GetValuesForKey(TKey key) => default;
		IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal sealed class NativeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 58286
		where TKey : struct, IEquatable<TKey>, IComparable<TKey>
		where TValue : struct
	{
		// Constructors
		public NativeParallelMultiHashMapDebuggerTypeProxy() {} // Dummy constructor
	}

	internal struct NativeQueueBlockHeader // TypeDefIndex: 58287
	{
		// Fields
		public unsafe NativeQueueBlockHeader* m_NextBlock; // 0x00
		public int m_NumItems; // 0x08
	}

	internal struct NativeQueueBlockPoolData // TypeDefIndex: 58288
	{
		// Fields
		internal IntPtr m_FirstBlock; // 0x00
		internal int m_NumBlocks; // 0x08
		internal int m_MaxBlocks; // 0x0C
		internal int m_AllocLock; // 0x10
	
		// Methods
		public unsafe NativeQueueBlockHeader* AllocateBlock() => default; // 0x0000000184F0A1F0-0x0000000184F0A270
		public unsafe void FreeBlock(NativeQueueBlockHeader* block) {} // 0x00000001844D67F0-0x00000001844D68C0
	}

	internal class NativeQueueBlockPool // TypeDefIndex: 58289
	{
		// Fields
		private static readonly SharedStatic<IntPtr> Data; // 0x00
	
		// Constructors
		public NativeQueueBlockPool() {} // Dummy constructor
		static NativeQueueBlockPool() {} // 0x00000001856DAF50-0x00000001856DAFB0
	
		// Methods
		internal static unsafe NativeQueueBlockPoolData* GetQueueBlockPool() => default; // 0x00000001851119F0-0x0000000185111B40
		private static void AppDomainOnDomainUnload() {} // 0x0000000184A8D680-0x0000000184A8D710
		private static void OnDomainUnload(object sender, EventArgs e) {} // 0x000000018BC8060C-0x000000018BC806E0
	}

	internal struct NativeQueueData // TypeDefIndex: 58290
	{
		// Fields
		public IntPtr m_FirstBlock; // 0x00
		public IntPtr m_LastBlock; // 0x08
		public int m_MaxItems; // 0x10
		public int m_CurrentRead; // 0x14
		public unsafe byte* m_CurrentWriteBlockTLS; // 0x18
	
		// Methods
		internal unsafe NativeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex) => default; // 0x0000000185FD74E0-0x0000000185FD74F0
		internal unsafe void SetCurrentWriteBlockTLS(int threadIndex, NativeQueueBlockHeader* currentWriteBlock) {} // 0x0000000185FD74F0-0x0000000185FD7500
		public static unsafe NativeQueueBlockHeader* AllocateWriteBlockMT<T>(NativeQueueData* data, NativeQueueBlockPoolData* pool, int threadIndex)
			where T : struct => default;
		public static unsafe void AllocateQueue<T>(AllocatorManager.AllocatorHandle label, out NativeQueueData* outBuf)
			where T : struct {
			outBuf = default;
		}
		public static unsafe void DeallocateQueue(NativeQueueData* data, NativeQueueBlockPoolData* pool, AllocatorManager.AllocatorHandle allocation) {} // 0x0000000185240F50-0x0000000185240FC0
	}

	public struct NativeQueue<T> : INativeDisposable // TypeDefIndex: 58292
		where T : struct
	{
		// Fields
		private unsafe NativeQueueData* m_Buffer;
		private unsafe NativeQueueBlockPoolData* m_QueuePool;
		private AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public int Count { get => default; }
		public bool IsCreated { get => default; }
	
		// Nested types
		public struct ParallelWriter // TypeDefIndex: 58291
		{
			// Fields
			internal unsafe NativeQueueData* m_Buffer;
			internal unsafe NativeQueueBlockPoolData* m_QueuePool;
			internal int m_ThreadIndex;
	
			// Methods
			public void Enqueue(T value) {}
		}
	
		// Constructors
		public unsafe NativeQueue(AllocatorManager.AllocatorHandle allocator) : this() {
			m_Buffer = default;
			m_QueuePool = default;
			m_AllocatorLabel = default;
		}
	
		// Methods
		public bool IsEmpty() => default;
		public void Enqueue(T value) {}
		public bool TryDequeue(out ref T item) {
			item = default;
			return default;
		}
		public NativeArray<T> ToArray(AllocatorManager.AllocatorHandle allocator) => default;
		public void Clear() {}
		public void Dispose() {}
		public JobHandle Dispose(JobHandle inputDeps) => default;
		public ParallelWriter AsParallelWriter() => default;
	}

	internal struct NativeQueueDispose // TypeDefIndex: 58293
	{
		// Fields
		internal unsafe NativeQueueData* m_Buffer; // 0x00
		internal unsafe NativeQueueBlockPoolData* m_QueuePool; // 0x08
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x10
	
		// Methods
		public void Dispose() {} // 0x000000018BC806E8-0x000000018BC806FC
	}

	internal struct NativeQueueDisposeJob : IJob // TypeDefIndex: 58294
	{
		// Fields
		public NativeQueueDispose Data; // 0x00
	
		// Methods
		public void Execute() {} // 0x000000018BC806E0-0x000000018BC806E8
	}

	public struct NativeReference<T> : INativeDisposable, IEquatable<NativeReference<T>> // TypeDefIndex: 58295
		where T : struct
	{
		// Fields
		internal unsafe void* m_Data;
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public T Value { get => default; set {} }
		public bool IsCreated { get => default; }
	
		// Constructors
		public unsafe NativeReference(AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x0207F515 */) : this() {
			m_Data = default;
			m_AllocatorLabel = default;
		}
		public unsafe NativeReference(T value, AllocatorManager.AllocatorHandle allocator) : this() {
			m_Data = default;
			m_AllocatorLabel = default;
		}
	
		// Methods
		private static void Allocate(AllocatorManager.AllocatorHandle allocator, out NativeReference<T> reference) {
			reference = default;
		}
		public void Dispose() {}
		public bool Equals(NativeReference<T> other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}

	internal struct NativeReferenceDispose // TypeDefIndex: 58296
	{
		// Fields
		internal unsafe void* m_Data; // 0x00
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x08
	
		// Methods
		public void Dispose() {} // 0x000000018BC80704-0x000000018BC80714
	}

	internal struct NativeReferenceDisposeJob : IJob // TypeDefIndex: 58297
	{
		// Fields
		internal NativeReferenceDispose Data; // 0x00
	
		// Methods
		public void Execute() {} // 0x000000018BC806FC-0x000000018BC80704
	}

	public static class NativeSortExtension // TypeDefIndex: 58299
	{
		// Nested types
		public struct DefaultComparer<T> : IComparer<T> // TypeDefIndex: 58298
			where T : IComparable<T>
		{
			// Methods
			public int Compare(T x, T y) => default;
		}
	
		// Methods
		public static unsafe void Sort<T>(T* array, int length)
			where T : struct, IComparable<T> {}
		public static unsafe void Sort<T, U>(T* array, int length, U comp)
			where T : struct
			where U : IComparer<T> {}
		public static unsafe SortJob<T, U> SortJob<T, U>(T* array, int length, U comp)
			where T : struct
			where U : IComparer<T> => default;
		public static unsafe int BinarySearch<T>(T* ptr, int length, T value)
			where T : struct, IComparable<T> => default;
		public static unsafe int BinarySearch<T, U>(T* ptr, int length, T value, U comp)
			where T : struct
			where U : IComparer<T> => default;
		public static SortJob<T, DefaultComparer<T>> SortJob<T>(NativeArray<T> array)
			where T : struct, IComparable<T> => default;
		public static void Sort<T>(NativeList<T> list)
			where T : struct, IComparable<T> {}
		public static void Sort<T, U>(NativeList<T> list, U comp)
			where T : struct
			where U : IComparer<T> {}
		internal static unsafe void IntroSort<T, U>(void* array, int length, U comp)
			where T : struct
			where U : IComparer<T> {}
		private static unsafe void IntroSort<T, U>(void* array, int lo, int hi, int depth, U comp)
			where T : struct
			where U : IComparer<T> {}
		private static unsafe void InsertionSort<T, U>(void* array, int lo, int hi, U comp)
			where T : struct
			where U : IComparer<T> {}
		private static unsafe int Partition<T, U>(void* array, int lo, int hi, U comp)
			where T : struct
			where U : IComparer<T> => default;
		private static unsafe void HeapSort<T, U>(void* array, int lo, int hi, U comp)
			where T : struct
			where U : IComparer<T> {}
		private static unsafe void Heapify<T, U>(void* array, int i, int n, int lo, U comp)
			where T : struct
			where U : IComparer<T> {}
		private static unsafe void Swap<T>(void* array, int lhs, int rhs)
			where T : struct {}
		private static unsafe void SwapIfGreaterWithItems<T, U>(void* array, int lhs, int rhs, U comp)
			where T : struct
			where U : IComparer<T> {}
	}

	public struct SortJob<T, U> // TypeDefIndex: 58302
		where T : struct
		where U : IComparer<T>
	{
		// Fields
		public unsafe T* Data;
		public U Comp;
		public int Length;
	
		// Nested types
		private struct SegmentSort : IJobParallelFor // TypeDefIndex: 58300
		{
			// Fields
			public unsafe T* Data;
			public U Comp;
			public int Length;
			public int SegmentWidth;
	
			// Methods
			public void Execute(int index) {}
		}
	
		private struct SegmentSortMerge : IJob // TypeDefIndex: 58301
		{
			// Fields
			public unsafe T* Data;
			public U Comp;
			public int Length;
			public int SegmentWidth;
	
			// Methods
			public void Execute() {}
		}
	
		// Methods
		public JobHandle Schedule(JobHandle inputDeps = default) => default;
	}

	public struct NativeStream : IDisposable // TypeDefIndex: 58305
	{
		// Fields
		private UnsafeStream m_Stream; // 0x00
	
		// Nested types
		private struct ConstructJobList : IJob // TypeDefIndex: 58303
		{
			// Fields
			public NativeStream Container; // 0x00
			public unsafe UntypedUnsafeList* List; // 0x10
	
			// Methods
			public void Execute() {} // 0x000000018BC7D1EC-0x000000018BC7D1F4
		}
	
		private struct ConstructJob : IJob // TypeDefIndex: 58304
		{
			// Fields
			public NativeStream Container; // 0x00
			public NativeArray<int> Length; // 0x10
	
			// Methods
			public void Execute() {} // 0x000000018BC80714-0x000000018BC8071C
		}
	
		// Methods
		public void Dispose() {} // 0x000000018BC7D1B8-0x000000018BC7D1DC
		private void AllocateForEach(int forEachCount) {} // 0x000000018BC7D1DC-0x000000018BC7D1EC
	}

	internal struct Spinner // TypeDefIndex: 58306
	{
		// Fields
		private int m_value; // 0x00
	
		// Methods
		public void Lock() {} // 0x000000018BC80D80-0x000000018BC80D94
		public void Unlock() {} // 0x000000018BC80D94-0x000000018BC80DB0
	}

	internal struct UnmanagedArray<T> : IDisposable // TypeDefIndex: 58307
		where T : struct
	{
		// Fields
		private IntPtr m_pointer;
		private int m_length;
		private AllocatorManager.AllocatorHandle m_allocator;
	
		// Properties
		public ref T this[int index] { get => default; }
	
		// Methods
		public void Dispose() {}
	}

	public struct RewindableAllocator : AllocatorManager.IAllocator // TypeDefIndex: 58311
	{
		// Fields
		private Spinner m_spinner; // 0x00
		private AllocatorManager.AllocatorHandle m_handle; // 0x04
		private UnmanagedArray<MemoryBlock> m_block; // 0x08
		private int m_best; // 0x18
		private int m_last; // 0x1C
		private int m_used; // 0x20
		private bool m_enableBlockFree; // 0x24
	
		// Properties
		public AllocatorManager.AllocatorHandle Handle { get => default; } // 0x0000000185F454F0-0x0000000185F45500 
	
		// Nested types
		internal struct MemoryBlock : IDisposable // TypeDefIndex: 58308
		{
			// Fields
			public unsafe byte* m_pointer; // 0x00
			public long m_bytes; // 0x08
			public long m_current; // 0x10
			public long m_allocations; // 0x18
	
			// Constructors
			public unsafe MemoryBlock(long bytes) {
				m_pointer = default;
				m_bytes = default;
				m_current = default;
				m_allocations = default;
			} // 0x000000018BC80820-0x000000018BC80904
	
			// Methods
			public void Rewind() {} // 0x000000018BC80754-0x000000018BC80820
			public void Dispose() {} // 0x000000018BC8090C-0x000000018BC80AD4
			public int TryAllocate(ref AllocatorManager.Block block) => default; // 0x000000018BC80AD4-0x000000018BC80B30
			public bool Contains(IntPtr ptr) => default; // 0x000000018357CBC0-0x000000018357CBD0
		}
	
		public delegate int Try_000008B6_PostfixBurstDelegate(IntPtr state, ref AllocatorManager.Block block); // TypeDefIndex: 58309; 0x000000018BC80574-0x000000018BC805C8
	
		internal static class Try_000008B6_BurstDirectCall // TypeDefIndex: 58310
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Try_000008B6_BurstDirectCall() {} // 0x000000018BC80F00-0x000000018BC80FC8
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_0007abcf) {} // 0x0000000185FBE170-0x0000000185FBE180
			private static IntPtr GetFunctionPointer() => default; // 0x000000018BC80438-0x000000018BC80498
			public static void Constructor() {} // 0x000000018BC80498-0x000000018BC80574
			public static void Initialize() {} // 0x000000018BC80420-0x000000018BC80438
			public static int Invoke(IntPtr state, ref AllocatorManager.Block block) => default; // 0x0000000181B59400-0x0000000181B59410
		}
	
		// Methods
		public void Rewind() {} // 0x000000018BC81390-0x000000018BC81494
		public void Dispose() {} // 0x000000018BC81494-0x000000018BC814E8
		public int Try(ref AllocatorManager.Block block) => default; // 0x0000000185F45500-0x0000000185F45590
		internal static int Try(IntPtr state, ref AllocatorManager.Block block) => default; // 0x0000000185492010-0x0000000185492020
		public static int Try_BurstManaged(IntPtr state, ref AllocatorManager.Block block) => default; // 0x000000018BC814E8-0x000000018BC81574
	}

	public enum FormatError // TypeDefIndex: 58312
	{
		None = 0,
		Overflow = 1
	}

	public enum CopyError // TypeDefIndex: 58313
	{
		None = 0,
		Truncation = 1
	}

	public enum ConversionError // TypeDefIndex: 58314
	{
		None = 0,
		Overflow = 1,
		Encoding = 2,
		CodePoint = 3
	}

	public struct Unicode // TypeDefIndex: 58316
	{
		// Properties
		public static Rune ReplacementCharacter { get => default; } // 0x0000000185FD7510-0x0000000185FD7520 
	
		// Nested types
		public struct Rune // TypeDefIndex: 58315
		{
			// Fields
			public int value; // 0x00
		}
	
		// Methods
		public static bool IsValidCodePoint(int codepoint) => default; // 0x00000001843E8BD0-0x00000001843E8BE0
		public static bool NotTrailer(byte b) => default; // 0x000000018BC816F4-0x000000018BC81700
		public static unsafe ConversionError Utf8ToUcs(out Rune rune, byte* buffer, ref int index, int capacity) {
			rune = default;
			return default;
		} // 0x00000001843E8B40-0x00000001843E8B80
		private static bool IsLeadingSurrogate(char c) => default; // 0x00000001843E8BE0-0x00000001843E8C00
		private static bool IsTrailingSurrogate(char c) => default; // 0x000000018B315188-0x000000018B3151A4
		public static unsafe ConversionError Utf16ToUcs(out Rune rune, char* buffer, ref int index, int capacity) {
			rune = default;
			return default;
		} // 0x00000001843E8A00-0x00000001843E8A80
		public static unsafe ConversionError UcsToUtf8(byte* buffer, ref int index, int capacity, Rune rune) => default; // 0x00000001843E89C0-0x00000001843E8A00
		public static unsafe ConversionError UcsToUtf16(char* buffer, ref int index, int capacity, Rune rune) => default; // 0x00000001843E8B80-0x00000001843E8BD0
		public static unsafe ConversionError Utf16ToUtf8(char* utf16Buffer, int utf16Length, byte* utf8Buffer, out int utf8Length, int utf8Capacity) {
			utf8Length = default;
			return default;
		} // 0x00000001843E8900-0x00000001843E89C0
		public static unsafe ConversionError Utf8ToUtf16(byte* utf8Buffer, int utf8Length, char* utf16Buffer, out int utf16Length, int utf16Capacity) {
			utf16Length = default;
			return default;
		} // 0x00000001843E8A80-0x00000001843E8B40
	}

	public static class UTF8ArrayUnsafeUtility // TypeDefIndex: 58318
	{
		// Nested types
		internal struct Comparison // TypeDefIndex: 58317
		{
			// Fields
			public bool terminates; // 0x00
			public int result; // 0x04
	
			// Constructors
			public Comparison(Unicode.Rune runeA, ConversionError errorA, Unicode.Rune runeB, ConversionError errorB) {
				terminates = default;
				result = default;
			} // 0x000000018BC81574-0x000000018BC815A8
		}
	
		// Methods
		public static unsafe CopyError Copy(byte* dest, out int destLength, int destUTF8MaxLengthInBytes, char* src, int srcLength) {
			destLength = default;
			return default;
		} // 0x00000001843E8730-0x00000001843E8800
		public static unsafe CopyError Copy(byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength) {
			destLength = default;
			return default;
		} // 0x000000018BC8165C-0x000000018BC816F4
		public static unsafe int StrCmp(byte* utf8BufferA, int utf8LengthInBytesA, byte* utf8BufferB, int utf8LengthInBytesB) => default; // 0x000000018BC815A8-0x000000018BC815C4
		public static unsafe bool EqualsUTF8Bytes(byte* aBytes, int aLength, byte* bBytes, int bLength) => default; // 0x000000018BC815C4-0x000000018BC8165C
		public static unsafe int StrCmp(byte* utf8Buffer, int utf8LengthInBytes, char* utf16Buffer, int utf16LengthInChars) => default; // 0x000000018BC7D188-0x000000018BC7D1B8
	}

	public static class xxHash3 // TypeDefIndex: 58324
	{
		// Nested types
		private struct ulong2 // TypeDefIndex: 58319
		{
			// Fields
			public ulong x; // 0x00
			public ulong y; // 0x08
	
			// Constructors
			public ulong2(ulong x, ulong y) {
				this.x = default;
				this.y = default;
			} // 0x0000000185FACE20-0x0000000185FACE30
		}
	
		public unsafe delegate ulong Hash64Long_000008F7_PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret); // TypeDefIndex: 58320; 0x0000000185FACE20-0x0000000185FACE30
	
		internal static class Hash64Long_000008F7_BurstDirectCall // TypeDefIndex: 58321
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Hash64Long_000008F7_BurstDirectCall() {} // 0x000000018BC81C64-0x000000018BC81DAC
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_0007acb6) {} // 0x0000000185FACE20-0x0000000185FACE30
			private static IntPtr GetFunctionPointer() => default; // 0x0000000184198600-0x0000000184198930
			public static void Constructor() {} // 0x000000018BC824A0-0x000000018BC82544
			public static void Initialize() {} // 0x0000000184199350-0x00000001841996A0
			public static unsafe ulong Invoke(byte* input, byte* dest, long length, byte* secret) => default; // 0x0000000185227BF0-0x0000000185227C30
		}
	
		public unsafe delegate void Hash128Long_000008FE_PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret, out uint4 result); // TypeDefIndex: 58322; 0x00000001850E7020-0x00000001850E7080
	
		internal static class Hash128Long_000008FE_BurstDirectCall // TypeDefIndex: 58323
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Hash128Long_000008FE_BurstDirectCall() {} // 0x000000018BC821E8-0x000000018BC82280
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_0007acc2) {} // 0x000000018419A3A0-0x000000018419A450
			private static IntPtr GetFunctionPointer() => default; // 0x000000018419A0A0-0x000000018419A2E0
			public static void Constructor() {} // 0x0000000185876BE0-0x0000000185876CC0
			public static void Initialize() {} // 0x000000018BC82544-0x000000018BC825B8
			public static unsafe void Invoke(byte* input, byte* dest, long length, byte* secret, out uint4 result) {
				result = default;
			} // 0x000000018BC82280-0x000000018BC82330
		}
	
		// Methods
		internal static unsafe void Avx2HashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64) {} // 0x000000018BC82330-0x000000018BC82420
		internal static unsafe void Avx2ScrambleAcc(ulong* acc, byte* secret) {} // 0x000000018BC81DAC-0x000000018BC81E50
		internal static unsafe void Avx2Accumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64) {} // 0x000000018BC82058-0x000000018BC821E8
		internal static unsafe void Avx2Accumulate512(ulong* acc, byte* input, byte* dest, byte* secret) {} // 0x000000018BC81E50-0x000000018BC82058
		public static unsafe uint2 Hash64(void* input, long length) => default; // 0x000000018BC82420-0x000000018BC824A0
		public static unsafe uint4 Hash128(void* input, long length) => default; // 0x0000000185FD75B0-0x0000000185FD75D0
		internal static unsafe ulong Hash64Internal(byte* input, byte* dest, long length, byte* secret, ulong seed) => default; // 0x0000000185FD75D0-0x0000000185FD75F0
		internal static unsafe void Hash128Internal(byte* input, byte* dest, long length, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x000000018BC81C34-0x000000018BC81C64
		private static unsafe ulong Hash64Len1To3(byte* input, long len, byte* secret, ulong seed) => default; // 0x00000001834AFB60-0x00000001834AFB70
		private static unsafe ulong Hash64Len4To8(byte* input, long length, byte* secret, ulong seed) => default; // 0x00000001818226B0-0x00000001818226C0
		private static unsafe ulong Hash64Len9To16(byte* input, long length, byte* secret, ulong seed) => default; // 0x0000000185FB2BB0-0x0000000185FB2BC0
		private static unsafe ulong Hash64Len0To16(byte* input, long length, byte* secret, ulong seed) => default; // 0x0000000185FD1700-0x0000000185FD1710
		private static unsafe ulong Hash64Len17To128(byte* input, long length, byte* secret, ulong seed) => default; // 0x0000000185FD75A0-0x0000000185FD75B0
		private static unsafe ulong Hash64Len129To240(byte* input, long length, byte* secret, ulong seed) => default; // 0x0000000185FD12B0-0x0000000185FD12C0
		private static unsafe ulong Hash64Long(byte* input, byte* dest, long length, byte* secret) => default; // 0x0000000185FB21D0-0x0000000185FB21F0
		private static unsafe void Hash128Len1To3(byte* input, long length, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x0000000185FD7580-0x0000000185FD75A0
		private static unsafe void Hash128Len4To8(byte* input, long len, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x0000000185FD75F0-0x0000000185FD7610
		private static unsafe void Hash128Len9To16(byte* input, long len, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x000000018BC82710-0x000000018BC82734
		private static unsafe void Hash128Len0To16(byte* input, long length, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x000000018BC82644-0x000000018BC82664
		private static unsafe void Hash128Len17To128(byte* input, long length, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x000000018BC82670-0x000000018BC82710
		private static unsafe void Hash128Len129To240(byte* input, long length, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x0000000185FD7550-0x0000000185FD7580
		private static unsafe void Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result) {
			result = default;
		} // 0x0000000185227C30-0x0000000185227C70
		internal static uint2 ToUint2(ulong u) => default; // 0x0000000185FD7610-0x0000000185FD7670
		internal static uint4 ToUint4(ulong ul0, ulong ul1) => default; // 0x000000018BC82664-0x000000018BC82670
		internal static unsafe void EncodeSecretKey(byte* dst, byte* secret, ulong seed) {} // 0x000000018BC825B8-0x000000018BC82644
		private static unsafe ulong Read64LE(void* addr) => default; // 0x000000018BC81A90-0x000000018BC81C04
		private static unsafe uint Read32LE(void* addr) => default; // 0x000000018BC819EC-0x000000018BC81A90
		private static unsafe void Write64LE(void* addr, ulong value) {} // 0x000000018BC8196C-0x000000018BC819EC
		private static ulong Mul32To64(uint x, uint y) => default; // 0x000000018BC81C04-0x000000018BC81C34
		private static ulong Swap64(ulong x) => default; // 0x000000018BC7CC30-0x000000018BC7CDDC
		private static uint Swap32(uint x) => default; // 0x000000018BC7CAF4-0x000000018BC7CC30
		private static uint RotL32(uint x, int r) => default; // 0x0000000183680100-0x0000000183680110
		private static ulong RotL64(ulong x, int r) => default; // 0x000000018BC802E4-0x000000018BC803B8
		private static ulong XorShift64(ulong v64, int shift) => default; // 0x00000001817B21C0-0x00000001817B21E0
		private static ulong Mul128Fold64(ulong lhs, ulong rhs) => default; // 0x000000018BC800DC-0x000000018BC801E0
		private static unsafe ulong Mix16(byte* input, byte* secret, ulong seed) => default; // 0x000000018BC801E0-0x000000018BC80234
		private static unsafe ulong2 Mix32(ulong2 acc, byte* input_1, byte* input_2, byte* secret, ulong seed) => default; // 0x0000000185F46E90-0x0000000185F46F20
		private static ulong Avalanche(ulong h64) => default; // 0x0000000185492010-0x0000000185492020
		private static ulong AvalancheH64(ulong h64) => default; // 0x0000000185F46E80-0x0000000185F46E90
		private static ulong rrmxmx(ulong h64, ulong length) => default; // 0x000000018BC80234-0x000000018BC802E4
		private static unsafe ulong Mix2Acc(ulong acc0, ulong acc1, byte* secret) => default; // 0x000000018BC80008-0x000000018BC800DC
		internal static unsafe ulong MergeAcc(ulong* acc, byte* secret, ulong start) => default; // 0x00000001817C0490-0x00000001817C04B0
		private static unsafe void DefaultHashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64) {} // 0x000000018BC7FDEC-0x000000018BC7FEF0
		internal static unsafe void DefaultAccumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64) {} // 0x000000018BC7FEF0-0x000000018BC7FF44
		internal static unsafe void DefaultAccumulate512(ulong* acc, byte* input, byte* dest, byte* secret, int isHash64) {} // 0x0000000185F46F30-0x0000000185F46FC0
		internal static unsafe void DefaultScrambleAcc(ulong* acc, byte* secret) {} // 0x0000000185492010-0x0000000185492020
		public static unsafe ulong Hash64Long_BurstManaged(byte* input, byte* dest, long length, byte* secret) => default; // 0x0000000185F46F20-0x0000000185F46F30
		public static unsafe void Hash128Long_BurstManaged(byte* input, byte* dest, long length, byte* secret, out uint4 result) {
			result = default;
		} // 0x000000018BC7FF44-0x000000018BC80008
	}

	internal static class xxHashDefaultKey // TypeDefIndex: 58325
	{
		// Fields
		public static readonly byte[] kSecret; // 0x00
	
		// Constructors
		static xxHashDefaultKey() {} // 0x0000000185F3E4D0-0x0000000185F3E560
	}
}

namespace Unity.Collections.LowLevel.Unsafe
{
	public static class NativeListUnsafeUtility // TypeDefIndex: 58327
	{
		// Methods
		public static unsafe void* GetUnsafePtr<T>(NativeList<T> list)
			where T : struct => default;
		public static unsafe void* GetUnsafeReadOnlyPtr<T>(NativeList<T> list)
			where T : struct => default;
		public static unsafe void* GetInternalListDataPtrUnchecked<T>(ref NativeList<T> list)
			where T : struct => default;
	}

	public static class NativeReferenceUnsafeUtility // TypeDefIndex: 58328
	{
		// Methods
		public static unsafe void* GetUnsafePtr<T>(NativeReference<T> reference)
			where T : struct => default;
		public static unsafe void* GetUnsafePtrWithoutChecks<T>(NativeReference<T> reference)
			where T : struct => default;
	}

	public struct UnsafeAppendBuffer : INativeDisposable // TypeDefIndex: 58329
	{
		// Fields
		public unsafe byte* Ptr; // 0x00
		public int Length; // 0x08
		public int Capacity; // 0x0C
		public AllocatorManager.AllocatorHandle Allocator; // 0x10
		public readonly int Alignment; // 0x14
	
		// Methods
		public void Dispose() {} // 0x000000018BC81700-0x000000018BC81784
	}

	internal struct UnsafeDisposeJob : IJob // TypeDefIndex: 58330
	{
		// Fields
		public unsafe void* Ptr; // 0x00
		public AllocatorManager.AllocatorHandle Allocator; // 0x08
	
		// Methods
		public void Execute() {} // 0x000000018BC81784-0x000000018BC817D8
	}

	internal struct UntypedUnsafeList // TypeDefIndex: 58331
	{
		// Fields
		public unsafe void* Ptr; // 0x00
		public int m_length; // 0x08
		public int m_capacity; // 0x0C
		public AllocatorManager.AllocatorHandle Allocator; // 0x10
		internal int obsolete_length; // 0x14
		internal int obsolete_capacity; // 0x18
	}

	public struct UnsafeList<T> : INativeDisposable, INativeList<T>, IEnumerable<T> // TypeDefIndex: 58334
		where T : struct
	{
		// Fields
		public unsafe T* Ptr;
		public int m_length;
		public int m_capacity;
		public AllocatorManager.AllocatorHandle Allocator;
		public int length;
		public int capacity;
	
		// Properties
		public int Length { get => default; }
		public int Capacity { get => default; set {} }
		public T this[int index] { get => default; set {} }
		public bool IsCreated { get => default; }
	
		// Nested types
		public struct ParallelReader // TypeDefIndex: 58332
		{
			// Fields
			public readonly unsafe T* Ptr;
			public readonly int Length;
	
			// Constructors
			internal unsafe ParallelReader(T* ptr, int length) {
				Ptr = default;
				Length = default;
			}
		}
	
		public struct ParallelWriter // TypeDefIndex: 58333
		{
			// Fields
			public unsafe UnsafeList<T>* ListData;
	
			// Constructors
			internal unsafe ParallelWriter(UnsafeList<T>* listData) {
				ListData = default;
			}
	
			// Methods
			public void AddNoResize(T value) {}
		}
	
		// Constructors
		public unsafe UnsafeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0207F51E */) : this() {
			Ptr = default;
			m_length = default;
			m_capacity = default;
			Allocator = default;
			length = default;
			capacity = default;
		}
	
		// Methods
		public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
		private ref T _refReturnTypeForElementAt; // Dummy field
		internal static unsafe UnsafeList<T>* Create<U>(int initialCapacity, ref ref U allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0207F51F */)
			where U : struct, AllocatorManager.IAllocator => default;
		public static unsafe UnsafeList<T>* Create(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0207F520 */) => default;
		public static unsafe void Destroy(UnsafeList<T>* listData) {}
		public void Dispose() {}
		public JobHandle Dispose(JobHandle inputDeps) => default;
		public JobHandle CrossFrameDispose(JobHandle inputDeps, JobQueuePriority priority = JobQueuePriority.NormalJobPriority /* Metadata: 0x0207F521 */) => default;
		public void Clear() {}
		public void Resize(int length, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0207F522 */) {}
		private void Realloc<U>(ref ref U allocator, int newCapacity)
			where U : struct, AllocatorManager.IAllocator {}
		private void SetCapacity<U>(ref ref U allocator, int capacity)
			where U : struct, AllocatorManager.IAllocator {}
		public void SetCapacity(int capacity) {}
		public void AddNoResize(T value) {}
		public unsafe void AddRangeNoResize(void* ptr, int count) {}
		public void Add(in ref T value) {}
		public unsafe void AddRange(void* ptr, int count) {}
		public void RemoveAtSwapBack(int index) {}
		public void RemoveRangeSwapBack(int index, int count) {}
		public void RemoveAt(int index) {}
		public void RemoveRange(int index, int count) {}
		public ParallelReader AsParallelReader() => default;
		public ParallelWriter AsParallelWriter() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	}

	internal sealed class UnsafeListTDebugView<T> // TypeDefIndex: 58335
		where T : struct
	{
		// Constructors
		public UnsafeListTDebugView() {} // Dummy constructor
	}

	internal struct UnsafeParallelHashMapData // TypeDefIndex: 58337
	{
		// Fields
		internal unsafe byte* values; // 0x00
		internal unsafe byte* keys; // 0x08
		internal unsafe byte* next; // 0x10
		internal unsafe byte* buckets; // 0x18
		internal int keyCapacity; // 0x20
		internal int bucketCapacityMask; // 0x24
		internal int allocatedIndexLength; // 0x28
		internal _firstFreeTLS_e__FixedBuffer firstFreeTLS; // 0x40
		internal const int IntsPerCacheLine = 16; // Metadata: 0x0207F523
	
		// Nested types
		public struct _firstFreeTLS_e__FixedBuffer // TypeDefIndex: 58336
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		// Methods
		internal static int GetBucketSize(int capacity) => default; // 0x0000000185FD7540-0x0000000185FD7550
		internal static int GrowCapacity(int capacity) => default; // 0x000000018412BC80-0x000000018412BC90
		internal static unsafe void AllocateHashMap<TKey, TValue>(int length, int bucketLength, AllocatorManager.AllocatorHandle label, out UnsafeParallelHashMapData* outBuf)
			where TKey : struct
			where TValue : struct {
			outBuf = default;
		}
		internal static unsafe void ReallocateHashMap<TKey, TValue>(UnsafeParallelHashMapData* data, int newCapacity, int newBucketCapacity, AllocatorManager.AllocatorHandle label)
			where TKey : struct
			where TValue : struct {}
		internal static unsafe void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorManager.AllocatorHandle allocator) {} // 0x00000001844DB6A0-0x00000001844DB710
		internal static int CalculateDataSize<TKey, TValue>(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset)
			where TKey : struct
			where TValue : struct {
			keyOffset = default;
			nextOffset = default;
			bucketOffset = default;
			return default;
		}
		internal static unsafe bool IsEmpty(UnsafeParallelHashMapData* data) => default; // 0x000000018445F550-0x000000018445F590
		internal static unsafe int GetCount(UnsafeParallelHashMapData* data) => default; // 0x00000001840C89A0-0x00000001840C8A10
		internal static unsafe bool MoveNext(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index) {
			index = default;
			return default;
		} // 0x0000000183FAB3F0-0x0000000183FAB4A0
		internal static unsafe void GetKeyArray<TKey>(UnsafeParallelHashMapData* data, NativeArray<TKey> result)
			where TKey : struct {}
		internal static unsafe void GetValueArray<TValue>(UnsafeParallelHashMapData* data, NativeArray<TValue> result)
			where TValue : struct {}
	}

	internal struct UnsafeParallelHashMapDataDispose // TypeDefIndex: 58338
	{
		// Fields
		internal unsafe UnsafeParallelHashMapData* m_Buffer; // 0x00
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x08
	
		// Methods
		public void Dispose() {} // 0x000000018BC817E0-0x000000018BC817F0
	}

	internal struct UnsafeParallelHashMapDataDisposeJob : IJob // TypeDefIndex: 58339
	{
		// Fields
		internal UnsafeParallelHashMapDataDispose Data; // 0x00
	
		// Methods
		public void Execute() {} // 0x000000018BC817D8-0x000000018BC817E0
	}

	internal struct UnsafeParallelHashMapBase<TKey, TValue> // TypeDefIndex: 58340
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Methods
		internal static unsafe void Clear(UnsafeParallelHashMapData* data) {}
		internal static unsafe int AllocEntry(UnsafeParallelHashMapData* data, int threadIndex) => default;
		internal static unsafe void FreeEntry(UnsafeParallelHashMapData* data, int idx, int threadIndex) {}
		internal static unsafe bool TryAddAtomic(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex) => default;
		internal static unsafe void AddAtomicMulti(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex) {}
		internal static unsafe bool TryAdd(UnsafeParallelHashMapData* data, TKey key, TValue item, bool isMultiHashMap, AllocatorManager.AllocatorHandle allocation) => default;
		internal static unsafe int Remove(UnsafeParallelHashMapData* data, TKey key, bool isMultiHashMap) => default;
		internal static unsafe void Remove(UnsafeParallelHashMapData* data, NativeParallelMultiHashMapIterator<TKey> it) {}
		internal static unsafe bool TryGetFirstValueAtomic(UnsafeParallelHashMapData* data, TKey key, out ref TValue item, out NativeParallelMultiHashMapIterator<TKey> it) {
			item = default;
			it = default;
			return default;
		}
		internal static unsafe bool TryGetNextValueAtomic(UnsafeParallelHashMapData* data, out ref TValue item, ref NativeParallelMultiHashMapIterator<TKey> it) {
			item = default;
			return default;
		}
		internal static unsafe bool SetValue(UnsafeParallelHashMapData* data, ref NativeParallelMultiHashMapIterator<TKey> it, ref ref TValue item) => default;
	}

	public struct KeyValue<TKey, TValue> // TypeDefIndex: 58341
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		internal unsafe UnsafeParallelHashMapData* m_Buffer;
		internal int m_Index;
		internal int m_Next;
	
		// Properties
		public TKey Key { get => default; }
		public ref TValue Value { get => default; }
	}

	internal struct UnsafeParallelHashMapDataEnumerator // TypeDefIndex: 58342
	{
		// Fields
		internal unsafe UnsafeParallelHashMapData* m_Buffer; // 0x00
		internal int m_Index; // 0x08
		internal int m_BucketIndex; // 0x0C
		internal int m_NextIndex; // 0x10
	
		// Constructors
		internal unsafe UnsafeParallelHashMapDataEnumerator(UnsafeParallelHashMapData* data) {
			m_Buffer = default;
			m_Index = default;
			m_BucketIndex = default;
			m_NextIndex = default;
		} // 0x0000000185FD7520-0x0000000185FD7540
	
		// Methods
		internal bool MoveNext() => default; // 0x0000000184284AA0-0x0000000184284AD0
		internal void Reset() {} // 0x0000000185FC2C80-0x0000000185FC2CA0
		internal KeyValue<TKey, TValue> GetCurrent<TKey, TValue>()
			where TKey : struct, IEquatable<TKey>
			where TValue : struct => default;
		internal TKey GetCurrentKey<TKey>()
			where TKey : struct, IEquatable<TKey> => default;
	}

	public struct UnsafeParallelHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 58344
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		internal unsafe UnsafeParallelHashMapData* m_Buffer;
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public bool IsEmpty { get => default; }
		public int Capacity { get => default; set {} }
		public TValue this[TKey key] { set {} }
		public bool IsCreated { get => default; }
	
		// Nested types
		public struct ParallelWriter // TypeDefIndex: 58343
		{
			// Fields
			internal unsafe UnsafeParallelHashMapData* m_Buffer;
			internal int m_ThreadIndex;
	
			// Methods
			public bool TryAdd(TKey key, TValue item) => default;
		}
	
		// Constructors
		public unsafe UnsafeParallelHashMap(int capacity, AllocatorManager.AllocatorHandle allocator) : this() {
			m_Buffer = default;
			m_AllocatorLabel = default;
		}
	
		// Methods
		public int Count() => default;
		public void Clear() {}
		public bool TryAdd(TKey key, TValue item) => default;
		public bool Remove(TKey key) => default;
		public bool TryGetValue(TKey key, out ref TValue item) {
			item = default;
			return default;
		}
		public bool ContainsKey(TKey key) => default;
		public void Dispose() {}
		public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator) => default;
		public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator) => default;
		public ParallelWriter AsParallelWriter() => default;
		IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal struct UnsafeParallelHashMapDisposeJob : IJob // TypeDefIndex: 58345
	{
		// Fields
		public unsafe UnsafeParallelHashMapData* Data; // 0x00
		public AllocatorManager.AllocatorHandle Allocator; // 0x08
	
		// Methods
		public void Execute() {} // 0x000000018BC817E0-0x000000018BC817F0
	}

	internal sealed class UnsafeParallelHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 58346
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Constructors
		public UnsafeParallelHashMapDebuggerTypeProxy() {} // Dummy constructor
	}

	public struct UnsafeParallelHashSet<T> : INativeDisposable, IEnumerable<T> // TypeDefIndex: 58348
		where T : struct, IEquatable<T>
	{
		// Fields
		internal UnsafeParallelHashMap<T, bool> m_Data;
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 58347
		{
			// Fields
			internal UnsafeParallelHashMapDataEnumerator m_Enumerator;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		// Constructors
		public UnsafeParallelHashSet(int capacity, AllocatorManager.AllocatorHandle allocator) {
			m_Data = default;
		}
	
		// Methods
		public void Dispose() {}
		public void Clear() {}
		public bool Add(T item) => default;
		public bool Remove(T item) => default;
		public bool Contains(T item) => default;
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal sealed class UnsafeHashSetDebuggerTypeProxy<T> // TypeDefIndex: 58349
		where T : struct, IEquatable<T>
	{
		// Constructors
		public UnsafeHashSetDebuggerTypeProxy() {} // Dummy constructor
	}

	public static class HashSetExtensions // TypeDefIndex: 58350
	{
		// Methods
		public static void UnionWith<T>(UnsafeParallelHashSet<T> container, UnsafeParallelHashSet<T> other)
			where T : struct, IEquatable<T> {}
	}

	public struct UnsafeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 58352
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		internal unsafe UnsafeParallelHashMapData* m_Buffer;
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public bool IsEmpty { get => default; }
		public int Capacity { get => default; }
		public bool IsCreated { get => default; }
	
		// Nested types
		public struct ParallelWriter // TypeDefIndex: 58351
		{
			// Fields
			internal unsafe UnsafeParallelHashMapData* m_Buffer;
			internal int m_ThreadIndex;
	
			// Methods
			public void Add(TKey key, TValue item) {}
		}
	
		// Constructors
		public unsafe UnsafeParallelMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator) : this() {
			m_Buffer = default;
			m_AllocatorLabel = default;
		}
	
		// Methods
		public int Count() => default;
		public void Clear() {}
		public void Add(TKey key, TValue item) {}
		public int Remove(TKey key) => default;
		public void Remove(NativeParallelMultiHashMapIterator<TKey> it) {}
		public bool TryGetFirstValue(TKey key, out ref TValue item, out NativeParallelMultiHashMapIterator<TKey> it) {
			item = default;
			it = default;
			return default;
		}
		public bool TryGetNextValue(out ref TValue item, ref NativeParallelMultiHashMapIterator<TKey> it) {
			item = default;
			return default;
		}
		public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it) => default;
		public void Dispose() {}
		public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator) => default;
		public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator) => default;
		IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal sealed class UnsafeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 58353
		where TKey : struct, IEquatable<TKey>, IComparable<TKey>
		where TValue : struct
	{
		// Constructors
		public UnsafeParallelMultiHashMapDebuggerTypeProxy() {} // Dummy constructor
	}

	internal struct UnsafeStreamBlock // TypeDefIndex: 58355
	{
		// Fields
		internal unsafe UnsafeStreamBlock* Next; // 0x00
		internal _Data_e__FixedBuffer Data; // 0x08
	
		// Nested types
		public struct _Data_e__FixedBuffer // TypeDefIndex: 58354
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	internal struct UnsafeStreamRange // TypeDefIndex: 58356
	{
		// Fields
		internal unsafe UnsafeStreamBlock* Block; // 0x00
		internal int OffsetInFirstBlock; // 0x08
		internal int ElementCount; // 0x0C
		internal int LastOffset; // 0x10
		internal int NumberOfBlocks; // 0x14
	}

	internal struct UnsafeStreamBlockData // TypeDefIndex: 58357
	{
		// Fields
		internal AllocatorManager.AllocatorHandle Allocator; // 0x00
		internal unsafe UnsafeStreamBlock** Blocks; // 0x08
		internal int BlockCount; // 0x10
		internal unsafe UnsafeStreamBlock* Free; // 0x18
		internal unsafe UnsafeStreamRange* Ranges; // 0x20
		internal int RangeCount; // 0x28
	}

	public struct UnsafeStream : INativeDisposable // TypeDefIndex: 58361
	{
		// Fields
		internal unsafe UnsafeStreamBlockData* m_Block; // 0x00
		internal AllocatorManager.AllocatorHandle m_Allocator; // 0x08
	
		// Nested types
		private struct DisposeJob : IJob // TypeDefIndex: 58358
		{
			// Fields
			public UnsafeStream Container; // 0x00
	
			// Methods
			public void Execute() {} // 0x000000018BC817F0-0x000000018BC81870
		}
	
		private struct ConstructJobList : IJob // TypeDefIndex: 58359
		{
			// Fields
			public UnsafeStream Container; // 0x00
			public unsafe UntypedUnsafeList* List; // 0x10
	
			// Methods
			public void Execute() {} // 0x000000018BC81870-0x000000018BC81964
		}
	
		private struct ConstructJob : IJob // TypeDefIndex: 58360
		{
			// Fields
			public UnsafeStream Container; // 0x00
			public NativeArray<int> Length; // 0x10
	
			// Methods
			public void Execute() {} // 0x000000018BC7D1EC-0x000000018BC7D1F4
		}
	
		// Methods
		internal void AllocateForEach(int forEachCount) {} // 0x000000018BC7D1EC-0x000000018BC7D1F4
		private void Deallocate() {} // 0x000000018BC7D1B8-0x000000018BC7D1DC
		public void Dispose() {} // 0x000000018BC7D1DC-0x000000018BC7D1EC
	}

	public static class UnsafeUtilityExtensions // TypeDefIndex: 58362
	{
		// Methods
		public static unsafe void* AddressOf<T>(in ref T value)
			where T : struct => default;
		public static ref ref T AsRef<T>(in ref T value)
			where T : struct => ref _refReturnTypeForAsRef;
		private ref T _refReturnTypeForAsRef; // Dummy field
		public static IntPtr Malloc(long size, int alignment, Unity.Collections.Allocator allocator) => default; // 0x000000018BC81964-0x000000018BC8196C
	}
}

namespace Unity.Collections.NotBurstCompatible
{
	public static class Extensions // TypeDefIndex: 58326
	{
		// Methods
		public static T[] ToArrayNBC<T>(NativeList<T> list)
			where T : struct => default;
	}
}

namespace Unity.Jobs
{
	public class EarlyInitHelpers // TypeDefIndex: 58179
	{
		// Constructors
		public EarlyInitHelpers() {} // Dummy constructor
	
		// Methods
		public static void JobReflectionDataCreationFailed(Exception ex, System.Type jobType) {} // 0x000000018BC7D1F4-0x000000018BC7D26C
	}

	public interface IJobBurstSchedulable // TypeDefIndex: 58180
	{
		// Methods
		void Execute();
	}

	public static class IJobBurstSchedulableExtensions // TypeDefIndex: 58183
	{
		// Nested types
		internal struct JobBurstSchedulableProducer<T> // TypeDefIndex: 58182
			where T : struct, IJobBurstSchedulable
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 58181; 0x00000000-0x00000000
	
			// Constructors
			static JobBurstSchedulableProducer() {
				jobReflectionData = default;
			}
	
			// Methods
			internal static void Initialize() {}
			public static void Execute(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	}

	public interface IJobParallelForBatch // TypeDefIndex: 58184
	{
		// Methods
		void Execute(int startIndex, int count);
	}

	public static class IJobParallelForBatchExtensions // TypeDefIndex: 58187
	{
		// Nested types
		internal struct JobParallelForBatchProducer<T> // TypeDefIndex: 58186
			where T : struct, IJobParallelForBatch
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 58185; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForBatchProducer() {
				jobReflectionData = default;
			}
	
			// Methods
			internal static void Initialize() {}
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	
		// Methods
		public static void EarlyJobInit<T>()
			where T : struct, IJobParallelForBatch {}
		public static JobHandle ScheduleBatch<T>(T jobData, int arrayLength, int minIndicesPerJobCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForBatch => default;
	}

	public interface IJobParallelForBurstSchedulable // TypeDefIndex: 58188
	{
		// Methods
		void Execute(int index);
	}

	public static class IJobParallelForExtensionsBurstSchedulable // TypeDefIndex: 58191
	{
		// Nested types
		internal struct JobParallelForBurstSchedulableProducer<T> // TypeDefIndex: 58190
			where T : struct, IJobParallelForBurstSchedulable
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 58189; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForBurstSchedulableProducer() {
				jobReflectionData = default;
			}
	
			// Methods
			internal static void Initialize() {}
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	}

	public interface IJobParallelForDefer // TypeDefIndex: 58192
	{
		// Methods
		void Execute(int index);
	}

	public static class IJobParallelForDeferExtensions // TypeDefIndex: 58195
	{
		// Nested types
		internal struct JobParallelForDeferProducer<T> // TypeDefIndex: 58194
			where T : struct, IJobParallelForDefer
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			public delegate void ExecuteJobFunction(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 58193; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForDeferProducer() {
				jobReflectionData = default;
			}
	
			// Methods
			internal static void Initialize() {}
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	
		// Methods
		public static void EarlyJobInit<T>()
			where T : struct, IJobParallelForDefer {}
		public static JobHandle Schedule<T, U>(T jobData, NativeList<U> list, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer
			where U : struct => default;
		public static unsafe JobHandle Schedule<T>(T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer => default;
		public static unsafe JobHandle ScheduleByRef<T>(ref ref T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer => default;
		private static unsafe JobHandle ScheduleInternal<T>(ref ref T jobData, int innerloopBatchCount, void* forEachListPtr, void* atomicSafetyHandlePtr, JobHandle dependsOn)
			where T : struct, IJobParallelForDefer => default;
	}

	public interface IJobParallelForFilter // TypeDefIndex: 58196
	{
		// Methods
		bool Execute(int index);
	}

	public static class JobParallelIndexListExtensions // TypeDefIndex: 58200
	{
		// Nested types
		internal struct JobParallelForFilterProducer<T> // TypeDefIndex: 58199
			where T : struct, IJobParallelForFilter
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			public struct JobWrapper // TypeDefIndex: 58197
			{
				// Fields
				public NativeList<int> outputIndices;
				public int appendCount;
				public T JobData;
			}
	
			public delegate void ExecuteJobFunction(ref JobWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 58198; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForFilterProducer() {
				jobReflectionData = default;
			}
	
			// Methods
			public static void Initialize() {}
			public static void Execute(ref JobWrapper jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
			public static void ExecuteAppend(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData) {}
			public static void ExecuteFilter(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData) {}
		}
	}

	internal class DOTSCompilerGeneratedAttribute : Attribute // TypeDefIndex: 58201
	{
		// Constructors
		public DOTSCompilerGeneratedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
