/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;

// Image 54: Unity.Collections.dll - Assembly: Unity.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 88036-88230

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 88228
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_192 _2CF2F88BF9B71283059B6DF53E5BCDE20ADBFD9E8D6CE2C1AB106262BB283BED; // 0x00 // Static value (base64): uP5sOSOkS758AYEs9yGtHN7UbemDkJfbckCkpLezZx/LeeZOzMDleIJa0H3M/3IhuAhGdPdDJI7gNZDmgTomTDwoUruRwwDLiNBlixtTLqNxZEiXog35TjgZ70ap3qzYqPp2P+OcND/53LvHxwtPHYpR4EvNtFkxyJ9+ydl4c2TqxayDNNPrw8WBoP/6E2PrFw3dUbfw2knTFlUmKdRonisWvlh9R6H8j/i40XrQMc5FyzqPlRYEKK/X+8q7S0B+ - Metadata: 0x02647F60

	// Nested types
	private struct __StaticArrayInitTypeSize_192 // TypeDefIndex: 88227
	{
	}
}

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3703794347 // TypeDefIndex: 88229
{
	// Methods
	public static void CreateJobReflectionData(); // 0x0000000184F4AEA0-0x0000000184F4CEA0
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit(); // 0x0000000184F4CEA0-0x0000000184F50750
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 88230
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize(); // 0x000000018709F1F0-0x000000018709F2A0
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 88037
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 88038
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Unity.Collections
{
	public static class AllocatorManager // TypeDefIndex: 88081
	{
		// Fields
		public static readonly AllocatorHandle Invalid; // 0x00
		public static readonly AllocatorHandle None; // 0x04
		public static readonly AllocatorHandle Temp; // 0x08
		public static readonly AllocatorHandle TempJob; // 0x0C
		public static readonly AllocatorHandle Persistent; // 0x10
		public static readonly AllocatorHandle AudioKernel; // 0x14
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int TryFunction(IntPtr allocatorState, ref Block block); // TypeDefIndex: 88062; 0x00000001859B7730-0x00000001859B7740
	
		public struct AllocatorHandle : IAllocator // TypeDefIndex: 88063
		{
			// Fields
			public ushort Index; // 0x00
			public ushort Version; // 0x02
	
			// Properties
			internal ref TableEntry TableEntry { get; } // 0x000000018D2A9344-0x000000018D2A93C0 
			public int Value { get; } // 0x000000018448B780-0x000000018448B790 
			public AllocatorHandle Handle { get; } // 0x00000001844AD290-0x00000001844AD2A0 
			public Unity.Collections.Allocator ToAllocator { get; } // 0x00000001872592A0-0x00000001872592B0 
	
			// Methods
			internal void Rewind(); // 0x0000000186805BA0-0x0000000186805BB0
			public static implicit operator AllocatorHandle(Unity.Collections.Allocator a); // 0x00000001872592B0-0x00000001872592D0
			public int Try(ref Block block); // 0x0000000185163E00-0x0000000185163E60
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public struct Range : IDisposable // TypeDefIndex: 88064
		{
			// Fields
			public IntPtr Pointer; // 0x00
			public int Items; // 0x08
			public AllocatorHandle Allocator; // 0x0C
	
			// Methods
			public void Dispose(); // 0x000000018D2ACC8C-0x000000018D2ACCC4
		}
	
		public struct Block : IDisposable // TypeDefIndex: 88065
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
			public long Bytes { get; } // 0x00000001872593B0-0x00000001872593C0 
			public long AllocatedBytes { get; } // 0x00000001872593A0-0x00000001872593B0 
			public int Alignment { get; set; } // 0x0000000187259390-0x00000001872593A0 0x0000000185164010-0x0000000185164060
	
			// Methods
			public void Dispose(); // 0x000000018D2A96A0-0x000000018D2A96A8
			public int TryFree(); // 0x000000018D2A96A8-0x000000018D2A96F8
		}
	
		public interface IAllocator : IDisposable // TypeDefIndex: 88066
		{
			// Properties
			AllocatorHandle Handle { get; }
	
			// Methods
			int Try(ref Block block);
		}
	
		[BurstCompile(CompileSynchronously = true)]
		internal struct StackAllocator : IAllocator // TypeDefIndex: 88069
		{
			// Fields
			internal AllocatorHandle m_handle; // 0x00
			internal Block m_storage; // 0x08
			internal long m_top; // 0x28
	
			// Properties
			public AllocatorHandle Handle { get; } // 0x00000001844AD290-0x00000001844AD2A0 
	
			// Nested types
			public delegate int Try_000000A0_PostfixBurstDelegate(IntPtr allocatorState, ref Block block); // TypeDefIndex: 88067; 0x00000001859B7730-0x00000001859B7740
	
			internal static class Try_000000A0_BurstDirectCall // TypeDefIndex: 88068
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Try_000000A0_BurstDirectCall(); // 0x000000018633AD50-0x000000018633AD60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000bada3); // 0x000000018D2AD484-0x000000018D2AD588
				private static IntPtr GetFunctionPointer(); // 0x000000018D2AD588-0x000000018D2AD5DC
				public static void Constructor(); // 0x000000018633C270-0x000000018633C300
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static int Invoke(IntPtr allocatorState, ref Block block); // 0x000000018D2AD5DC-0x000000018D2AD668
			}
	
			// Methods
			public int Try(ref Block block); // 0x000000018D2AD390-0x000000018D2AD424
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try(IntPtr allocatorState, ref Block block); // 0x000000018D2AD334-0x000000018D2AD390
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try_BurstManaged(IntPtr allocatorState, ref Block block); // 0x000000018D2AD32C-0x000000018D2AD334
		}
	
		[BurstCompile(CompileSynchronously = true)]
		internal struct SlabAllocator : IAllocator // TypeDefIndex: 88072
		{
			// Fields
			internal AllocatorHandle m_handle; // 0x00
			internal Block Storage; // 0x08
			internal int Log2SlabSizeInBytes; // 0x28
			internal FixedList4096Bytes<int> Occupied; // 0x2C
			internal long budgetInBytes; // 0x1030
			internal long allocatedBytes; // 0x1038
	
			// Properties
			public AllocatorHandle Handle { get; } // 0x00000001844AD290-0x00000001844AD2A0 
			internal int SlabSizeInBytes { get; } // 0x0000000187259460-0x0000000187259470 
	
			// Nested types
			public delegate int Try_000000AE_PostfixBurstDelegate(IntPtr allocatorState, ref Block block); // TypeDefIndex: 88070; 0x00000001859B7730-0x00000001859B7740
	
			internal static class Try_000000AE_BurstDirectCall // TypeDefIndex: 88071
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Try_000000AE_BurstDirectCall(); // 0x000000018633AD60-0x000000018633AD70
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000badaf); // 0x000000018D2AD668-0x000000018D2AD76C
				private static IntPtr GetFunctionPointer(); // 0x000000018D2AD76C-0x000000018D2AD7C0
				public static void Constructor(); // 0x000000018633C300-0x000000018633C390
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static int Invoke(IntPtr allocatorState, ref Block block); // 0x000000018D2AD7C0-0x000000018D2AD84C
			}
	
			// Methods
			public int Try(ref Block block); // 0x000000018D2AD124-0x000000018D2AD2FC
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try(IntPtr allocatorState, ref Block block); // 0x000000018D2AD0C8-0x000000018D2AD124
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try_BurstManaged(IntPtr allocatorState, ref Block block); // 0x000000018D2AD0C0-0x000000018D2AD0C8
		}
	
		internal struct TableEntry // TypeDefIndex: 88073
		{
			// Fields
			internal IntPtr function; // 0x00
			internal IntPtr state; // 0x08
		}
	
		internal struct Array16<T> // TypeDefIndex: 88074
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
	
		internal struct Array256<T> // TypeDefIndex: 88075
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
	
		internal struct Array4096<T> // TypeDefIndex: 88076
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
	
		internal struct Array32768<T> : IIndexable<T> // TypeDefIndex: 88077
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
			public int Length { get; }
	
			// Methods
			public ref ref T ElementAt(int index);
		}
	
		internal sealed class SharedStatics // TypeDefIndex: 88079
		{
			// Nested types
			internal sealed class TableEntry // TypeDefIndex: 88078
			{
				// Fields
				internal static readonly SharedStatic<Array32768<AllocatorManager.TableEntry>> Ref; // 0x00
	
				// Constructors
				static TableEntry(); // 0x000000018D2AD424-0x000000018D2AD484
			}
		}
	
		internal static class Managed // TypeDefIndex: 88080
		{
			// Fields
			internal static TryFunction[] TryFunctionDelegates; // 0x00
	
			// Constructors
			static Managed(); // 0x000000018D2AC92C-0x000000018D2AC994
		}
	
		// Constructors
		static AllocatorManager(); // 0x000000018707BE70-0x000000018707C050
	
		// Methods
		public static unsafe void* Allocate(AllocatorHandle handle, int itemSizeInBytes, int alignmentInBytes, int items = 1 /* Metadata: 0x02647F35 */); // 0x0000000185161550-0x00000001851616C0
		public static unsafe T* Allocate<T>(AllocatorHandle handle, int items = 1 /* Metadata: 0x02647F36 */)
			where T : struct;
		public static unsafe void Free(AllocatorHandle handle, void* pointer); // 0x000000018D2A93C0-0x000000018D2A9420
		public static unsafe void Free<T>(AllocatorHandle handle, T* pointer, int items = 1 /* Metadata: 0x02647F37 */)
			where T : struct;
		[BurstDiscard]
		private static void CheckDelegate(ref bool useDelegate); // 0x000000018723EE00-0x000000018723EE10
		private static bool UseDelegate(); // 0x000000018D2A9420-0x000000018D2A945C
		private static int allocate_block(ref Block block); // 0x000000018D2A945C-0x000000018D2A94EC
		[BurstDiscard]
		private static void forward_mono_allocate_block(ref Block block, ref int error); // 0x000000018D2A94EC-0x000000018D2A95F4
		internal static Unity.Collections.Allocator LegacyOf(AllocatorHandle handle); // 0x0000000185164000-0x0000000185164010
		private static int TryLegacy(ref Block block); // 0x0000000185163EA0-0x0000000185164000
		public static int Try(ref Block block); // 0x0000000185163E60-0x0000000185163EA0
		internal static bool IsCustomAllocator(AllocatorHandle allocator); // 0x00000001851641B0-0x00000001851641C0
		public static void Initialize_StackAllocator_Try_000000A0_BurstDirectCall(); // 0x000000018709F2E0-0x000000018709F320
		public static void Initialize_SlabAllocator_Try_000000AE_BurstDirectCall(); // 0x000000018709F2A0-0x000000018709F2E0
	
		// Extension methods
		internal static Block AllocateBlock<T>(this ref ref T t, int sizeOf, int alignOf, int items)
			where T : struct, IAllocator;
		internal static unsafe void* Allocate<T>(this ref ref T t, int sizeOf, int alignOf, int items)
			where T : struct, IAllocator;
		internal static unsafe U* Allocate<T, U>(this ref ref T t, U u, int items)
			where T : struct, IAllocator
			where U : struct;
		internal static unsafe void* AllocateStruct<T, U>(this ref ref T t, U u, int items)
			where T : struct, IAllocator
			where U : struct;
		internal static void FreeBlock<T>(this ref ref T t, ref Block block)
			where T : struct, IAllocator;
		internal static unsafe void Free<T>(this ref ref T t, void* pointer, int sizeOf, int alignOf, int items)
			where T : struct, IAllocator;
		internal static unsafe void Free<T, U>(this ref ref T t, U* pointer, int items)
			where T : struct, IAllocator
			where U : struct;
	}

	internal class CreatePropertyAttribute : Attribute // TypeDefIndex: 88082
	{
		// Constructors
		public CreatePropertyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[BurstCompatible]
	internal struct Bitwise // TypeDefIndex: 88083
	{
		// Methods
		internal static int FromBool(bool value); // 0x0000000185A250B0-0x0000000185A250C0
		internal static uint ExtractBits(uint input, int pos, uint mask); // 0x0000000187259330-0x0000000187259340
		internal static uint ReplaceBits(uint input, int pos, uint mask, uint value); // 0x0000000187259370-0x0000000187259390
		internal static uint SetBits(uint input, int pos, uint mask, bool value); // 0x0000000185A25050-0x0000000185A25080
		internal static ulong ExtractBits(ulong input, int pos, ulong mask); // 0x0000000187259320-0x0000000187259330
		internal static ulong ReplaceBits(ulong input, int pos, ulong mask, ulong value); // 0x0000000187259340-0x0000000187259370
		internal static ulong SetBits(ulong input, int pos, ulong mask, bool value); // 0x0000000185A25080-0x0000000185A250B0
	}

	[BurstCompatible]
	[DebuggerTypeProxy(typeof(BitField32DebugView))]
	public struct BitField32 // TypeDefIndex: 88084
	{
		// Fields
		public uint Value; // 0x00
	
		// Methods
		public void SetBits(int pos, bool value); // 0x0000000187836580-0x00000001878365AC
		public uint GetBits(int pos, int numBits = 1 /* Metadata: 0x02647F38 */); // 0x00000001872592D0-0x00000001872592F0
		public bool IsSet(int pos); // 0x0000000185BF03E0-0x0000000185BF03F0
	}

	internal sealed class BitField32DebugView // TypeDefIndex: 88085
	{
	}

	[BurstCompatible]
	[DebuggerTypeProxy(typeof(BitField64DebugView))]
	public struct BitField64 // TypeDefIndex: 88086
	{
		// Fields
		public ulong Value; // 0x00
	
		// Methods
		public void SetBits(int pos, bool value); // 0x00000001878365BC-0x00000001878365EC
		public ulong GetBits(int pos, int numBits = 1 /* Metadata: 0x02647F39 */); // 0x00000001872592F0-0x0000000187259320
		public bool IsSet(int pos); // 0x0000000185B1AFA0-0x0000000185B1AFC0
		public bool TestAny(int pos, int numBits = 1 /* Metadata: 0x02647F3A */); // 0x0000000185B1D160-0x0000000185B1D190
	}

	internal sealed class BitField64DebugView // TypeDefIndex: 88087
	{
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
	public class BurstCompatibleAttribute : Attribute // TypeDefIndex: 88088
	{
		// Fields
		[CompilerGenerated]
		private System.Type[] _GenericTypeArguments_k__BackingField; // 0x10
		public string RequiredUnityDefine; // 0x18
	
		// Properties
		public System.Type[] GenericTypeArguments { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public BurstCompatibleAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	public class NotBurstCompatibleAttribute : Attribute // TypeDefIndex: 88089
	{
		// Constructors
		public NotBurstCompatibleAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface INativeDisposable : IDisposable // TypeDefIndex: 88090
	{
	}

	[BurstCompatible]
	public static class CollectionHelper // TypeDefIndex: 88091
	{
		// Methods
		public static int Log2Floor(int value); // 0x000000018D2A96F8-0x000000018D2A9710
		public static int Align(int size, int alignmentPowerOfTwo); // 0x00000001859358B0-0x00000001859358D0
		public static unsafe uint Hash(void* ptr, int bytes); // 0x00000001867F9520-0x00000001867F9550
		internal static bool ShouldDeallocate(AllocatorManager.AllocatorHandle allocator); // 0x0000000185E695A0-0x0000000185E695C0
		internal static int AssumePositive(int value); // 0x0000000187235A70-0x0000000187235A80
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static NativeArray<T> CreateNativeArray<T>(int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x02647F3B */)
			where T : struct;
		[NotBurstCompatible]
		public static NativeArray<T> CreateNativeArray<T>(T[] array, AllocatorManager.AllocatorHandle allocator)
			where T : struct;
	}

	[BurstCompatible]
	internal struct FixedList // TypeDefIndex: 88092
	{
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		internal static int PaddingBytes<T>()
			where T : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static int StorageBytes<BUFFER, T>()
			where BUFFER : struct
			where T : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static int Capacity<BUFFER, T>()
			where BUFFER : struct
			where T : struct;
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList32BytesDebugView<T>))]
	public struct FixedList32Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 88093
		where T : struct
	{
		// Fields
		[SerializeField]
		internal ushort length;
		[SerializeField]
		internal FixedBytes30 buffer;
	
		// Properties
		[CreateProperty]
		public int Length { get; set; }
		internal int LengthInBytes { get; }
		internal unsafe byte* Buffer { get; }
		public int Capacity { get; }
		public T this[int index] { get => default; set {} }
	
		// Methods
		public ref ref T ElementAt(int index);
		public override int GetHashCode();
		public void Add([IsReadOnly] in ref T item);
		public void RemoveAtSwapBack(int index);
		public void RemoveRangeSwapBack(int index, int count);
		public void RemoveAt(int index);
		public void RemoveRange(int index, int count);
		public int CompareTo(FixedList32Bytes<T> other);
		public bool Equals(FixedList32Bytes<T> other);
		public int CompareTo(FixedList64Bytes<T> other);
		public bool Equals(FixedList64Bytes<T> other);
		public int CompareTo(FixedList128Bytes<T> other);
		public bool Equals(FixedList128Bytes<T> other);
		public int CompareTo(FixedList512Bytes<T> other);
		public bool Equals(FixedList512Bytes<T> other);
		public int CompareTo(FixedList4096Bytes<T> other);
		public bool Equals(FixedList4096Bytes<T> other);
		[NotBurstCompatible]
		public override bool Equals(object obj);
		IEnumerator IEnumerable.GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
	}

	[BurstCompatible]
	public static class FixedList32BytesExtensions // TypeDefIndex: 88094
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList32Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList32Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
	}

	internal sealed class FixedList32BytesDebugView<T> // TypeDefIndex: 88095
		where T : struct
	{
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList64BytesDebugView<T>))]
	public struct FixedList64Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 88096
		where T : struct
	{
		// Fields
		[SerializeField]
		internal ushort length;
		[SerializeField]
		internal FixedBytes62 buffer;
	
		// Properties
		[CreateProperty]
		public int Length { get; set; }
		internal int LengthInBytes { get; }
		internal unsafe byte* Buffer { get; }
		public int Capacity { get; }
		public T this[int index] { get => default; set {} }
	
		// Methods
		public ref ref T ElementAt(int index);
		public override int GetHashCode();
		public void Add([IsReadOnly] in ref T item);
		public void RemoveAtSwapBack(int index);
		public void RemoveRangeSwapBack(int index, int count);
		public void RemoveAt(int index);
		public void RemoveRange(int index, int count);
		public int CompareTo(FixedList32Bytes<T> other);
		public bool Equals(FixedList32Bytes<T> other);
		public int CompareTo(FixedList64Bytes<T> other);
		public bool Equals(FixedList64Bytes<T> other);
		public int CompareTo(FixedList128Bytes<T> other);
		public bool Equals(FixedList128Bytes<T> other);
		public int CompareTo(FixedList512Bytes<T> other);
		public bool Equals(FixedList512Bytes<T> other);
		public int CompareTo(FixedList4096Bytes<T> other);
		public bool Equals(FixedList4096Bytes<T> other);
		[NotBurstCompatible]
		public override bool Equals(object obj);
		IEnumerator IEnumerable.GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
	}

	[BurstCompatible]
	public static class FixedList64BytesExtensions // TypeDefIndex: 88097
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList64Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList64Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
	}

	internal sealed class FixedList64BytesDebugView<T> // TypeDefIndex: 88098
		where T : struct
	{
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList128BytesDebugView<T>))]
	public struct FixedList128Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 88099
		where T : struct
	{
		// Fields
		[SerializeField]
		internal ushort length;
		[SerializeField]
		internal FixedBytes126 buffer;
	
		// Properties
		[CreateProperty]
		public int Length { get; set; }
		public bool IsEmpty { get; }
		internal int LengthInBytes { get; }
		internal unsafe byte* Buffer { get; }
		public int Capacity { get; }
		public T this[int index] { get => default; set {} }
	
		// Methods
		public ref ref T ElementAt(int index);
		public override int GetHashCode();
		public void Add([IsReadOnly] in ref T item);
		public void AddNoResize([IsReadOnly] in ref T item);
		public void Clear();
		public void RemoveAtSwapBack(int index);
		public void RemoveRangeSwapBack(int index, int count);
		public void RemoveAt(int index);
		public void RemoveRange(int index, int count);
		public int CompareTo(FixedList32Bytes<T> other);
		public bool Equals(FixedList32Bytes<T> other);
		public int CompareTo(FixedList64Bytes<T> other);
		public bool Equals(FixedList64Bytes<T> other);
		public int CompareTo(FixedList128Bytes<T> other);
		public bool Equals(FixedList128Bytes<T> other);
		public int CompareTo(FixedList512Bytes<T> other);
		public bool Equals(FixedList512Bytes<T> other);
		public int CompareTo(FixedList4096Bytes<T> other);
		public bool Equals(FixedList4096Bytes<T> other);
		[NotBurstCompatible]
		public override bool Equals(object obj);
		IEnumerator IEnumerable.GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
	}

	[BurstCompatible]
	public static class FixedList128BytesExtensions // TypeDefIndex: 88100
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList128Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList128Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Remove<T, U>(this ref FixedList128Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
	}

	internal sealed class FixedList128BytesDebugView<T> // TypeDefIndex: 88101
		where T : struct
	{
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList512BytesDebugView<T>))]
	public struct FixedList512Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 88103
		where T : struct
	{
		// Fields
		[SerializeField]
		internal ushort length;
		[SerializeField]
		internal FixedBytes510 buffer;
	
		// Properties
		[CreateProperty]
		public int Length { get; set; }
		public bool IsEmpty { get; }
		internal int LengthInBytes { get; }
		internal unsafe byte* Buffer { get; }
		public int Capacity { get; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 88102
		{
			// Fields
			private FixedList512Bytes<T> m_List;
			private int m_Index;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator(ref FixedList512Bytes<T> list);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		// Constructors
		public FixedList512Bytes([IsReadOnly] in FixedList128Bytes<T> other);
	
		// Methods
		public ref ref T ElementAt(int index);
		public override int GetHashCode();
		public void Add([IsReadOnly] in ref T item);
		public void Clear();
		public void RemoveAtSwapBack(int index);
		public void RemoveRangeSwapBack(int index, int count);
		public void RemoveAt(int index);
		public void RemoveRange(int index, int count);
		public int CompareTo(FixedList32Bytes<T> other);
		public bool Equals(FixedList32Bytes<T> other);
		public int CompareTo(FixedList64Bytes<T> other);
		public bool Equals(FixedList64Bytes<T> other);
		public int CompareTo(FixedList128Bytes<T> other);
		public bool Equals(FixedList128Bytes<T> other);
		internal int Initialize([IsReadOnly] in FixedList128Bytes<T> other);
		public static implicit operator FixedList512Bytes<T>([IsReadOnly] in FixedList128Bytes<T> other);
		public int CompareTo(FixedList512Bytes<T> other);
		public bool Equals(FixedList512Bytes<T> other);
		public int CompareTo(FixedList4096Bytes<T> other);
		public bool Equals(FixedList4096Bytes<T> other);
		[NotBurstCompatible]
		public override bool Equals(object obj);
		public Enumerator GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
	}

	[BurstCompatible]
	public static class FixedList512BytesExtensions // TypeDefIndex: 88104
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList512Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList512Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Remove<T, U>(this ref FixedList512Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
	}

	internal sealed class FixedList512BytesDebugView<T> // TypeDefIndex: 88105
		where T : struct
	{
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList4096BytesDebugView<T>))]
	public struct FixedList4096Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 88106
		where T : struct
	{
		// Fields
		[SerializeField]
		internal ushort length;
		[SerializeField]
		internal FixedBytes4094 buffer;
	
		// Properties
		[CreateProperty]
		public int Length { get; set; }
		public bool IsEmpty { get; }
		internal int LengthInBytes { get; }
		internal unsafe byte* Buffer { get; }
		public int Capacity { get; }
		public T this[int index] { get => default; set {} }
	
		// Methods
		public ref ref T ElementAt(int index);
		public override int GetHashCode();
		public void Add([IsReadOnly] in ref T item);
		public void Clear();
		public void RemoveAtSwapBack(int index);
		public void RemoveRangeSwapBack(int index, int count);
		public void RemoveAt(int index);
		public void RemoveRange(int index, int count);
		public int CompareTo(FixedList32Bytes<T> other);
		public bool Equals(FixedList32Bytes<T> other);
		public int CompareTo(FixedList64Bytes<T> other);
		public bool Equals(FixedList64Bytes<T> other);
		public int CompareTo(FixedList128Bytes<T> other);
		public bool Equals(FixedList128Bytes<T> other);
		public int CompareTo(FixedList512Bytes<T> other);
		public bool Equals(FixedList512Bytes<T> other);
		public int CompareTo(FixedList4096Bytes<T> other);
		public bool Equals(FixedList4096Bytes<T> other);
		[NotBurstCompatible]
		public override bool Equals(object obj);
		IEnumerator IEnumerable.GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
	}

	[BurstCompatible]
	public static class FixedList4096BytesExtensions // TypeDefIndex: 88107
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList4096Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList4096Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
	}

	internal sealed class FixedList4096BytesDebugView<T> // TypeDefIndex: 88108
		where T : struct
	{
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes16 // TypeDefIndex: 88109
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
	[BurstCompatible]
	public struct FixedBytes30 // TypeDefIndex: 88110
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
	[BurstCompatible]
	[DefaultMember("Item")]
	public struct FixedString32Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 88111
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 29; // Metadata: 0x02647F3D
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes30 bytes; // 0x02
	
		// Properties
		[CreateProperty]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[NotBurstCompatible]
		public string Value { get; } // 0x000000018783B020-0x000000018783B02C 
		public int Length { get; set; } // 0x000000018448B780-0x000000018448B790 0x00000001872593D0-0x00000001872593E0
		public bool IsEmpty { get; } // 0x000000018D2AA648-0x000000018D2AA650 
	
		// Constructors
		[NotBurstCompatible]
		public FixedString32Bytes(string source); // 0x00000001855D7380-0x00000001855D74B0
	
		// Methods
		public unsafe byte* GetUnsafePtr(); // 0x00000001872593C0-0x00000001872593D0
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x02647F3C */); // 0x000000018D2AA5DC-0x000000018D2AA648
		[NotBurstCompatible]
		public int CompareTo(string other); // 0x000000018D2AA130-0x000000018D2AA168
		[NotBurstCompatible]
		public bool Equals(string other); // 0x000000018D2AA24C-0x000000018D2AA2D0
		[NotBurstCompatible]
		internal int Initialize(string source); // 0x00000001855D74B0-0x00000001855D75D0
		public int CompareTo(FixedString32Bytes other); // 0x000000018D2AA1B4-0x000000018D2AA200
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString32Bytes b); // 0x00000001855D7B10-0x00000001855D7C20
		public bool Equals(FixedString32Bytes other); // 0x000000018D2AA2F8-0x000000018D2AA30C
		public int CompareTo(FixedString64Bytes other); // 0x000000018D2AA200-0x000000018D2AA24C
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString64Bytes b); // 0x000000018D2AA650-0x000000018D2AA6DC
		public bool Equals(FixedString64Bytes other); // 0x000000018D2AA2E4-0x000000018D2AA2F8
		public int CompareTo(FixedString128Bytes other); // 0x000000018D2AA0E4-0x000000018D2AA130
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString128Bytes b); // 0x000000018D2AA768-0x000000018D2AA7F4
		public bool Equals(FixedString128Bytes other); // 0x000000018D2AA30C-0x000000018D2AA320
		public int CompareTo(FixedString512Bytes other); // 0x000000018D2AA098-0x000000018D2AA0E4
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString512Bytes b); // 0x000000018D2AA6DC-0x000000018D2AA768
		public bool Equals(FixedString512Bytes other); // 0x000000018D2AA2D0-0x000000018D2AA2E4
		public int CompareTo(FixedString4096Bytes other); // 0x000000018D2AA168-0x000000018D2AA1B4
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString4096Bytes b); // 0x000000018D2AA7F4-0x000000018D2AA880
		public bool Equals(FixedString4096Bytes other); // 0x000000018D2AA5C8-0x000000018D2AA5DC
		[NotBurstCompatible]
		public static implicit operator FixedString32Bytes(string b); // 0x00000001855D7260-0x00000001855D7380
		[NotBurstCompatible]
		public override string ToString(); // 0x000000018783B020-0x000000018783B02C
		public override int GetHashCode(); // 0x0000000185D63FE0-0x0000000185D64020
		[NotBurstCompatible]
		public override bool Equals(object obj); // 0x000000018D2AA320-0x000000018D2AA5C8
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes62 // TypeDefIndex: 88112
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
	[BurstCompatible]
	[DefaultMember("Item")]
	public struct FixedString64Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 88113
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 61; // Metadata: 0x02647F40
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes62 bytes; // 0x02
	
		// Properties
		[CreateProperty]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[NotBurstCompatible]
		public string Value { get; } // 0x0000000187834F10-0x0000000187834F1C 
		public int Length { get; set; } // 0x000000018448B780-0x000000018448B790 0x00000001872593D0-0x00000001872593E0
	
		// Constructors
		[NotBurstCompatible]
		public FixedString64Bytes(string source); // 0x000000018D2AC090-0x000000018D2AC0AC
	
		// Methods
		public unsafe byte* GetUnsafePtr(); // 0x00000001872593C0-0x00000001872593D0
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x02647F3F */); // 0x000000018D2AC024-0x000000018D2AC090
		[NotBurstCompatible]
		public int CompareTo(string other); // 0x000000018D2ABB14-0x000000018D2ABB4C
		[NotBurstCompatible]
		public bool Equals(string other); // 0x000000018D2ABEC8-0x000000018D2ABF4C
		[NotBurstCompatible]
		internal int Initialize(string source); // 0x000000018D2ABFB0-0x000000018D2AC024
		public int CompareTo(FixedString32Bytes other); // 0x000000018D2ABB4C-0x000000018D2ABB98
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString32Bytes b); // 0x000000018D2AC1C4-0x000000018D2AC250
		public bool Equals(FixedString32Bytes other); // 0x000000018D2ABE8C-0x000000018D2ABEA0
		public int CompareTo(FixedString64Bytes other); // 0x000000018D2ABB98-0x000000018D2ABBE4
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString64Bytes b); // 0x000000018D2AC250-0x000000018D2AC2D0
		public bool Equals(FixedString64Bytes other); // 0x000000018D2ABEB4-0x000000018D2ABEC8
		public int CompareTo(FixedString128Bytes other); // 0x000000018D2ABA7C-0x000000018D2ABAC8
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString128Bytes b); // 0x000000018D2AC138-0x000000018D2AC1C4
		public bool Equals(FixedString128Bytes other); // 0x000000018D2ABEA0-0x000000018D2ABEB4
		public int CompareTo(FixedString512Bytes other); // 0x000000018D2ABA30-0x000000018D2ABA7C
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString512Bytes b); // 0x000000018D2AC0AC-0x000000018D2AC138
		public bool Equals(FixedString512Bytes other); // 0x000000018D2ABF4C-0x000000018D2ABF60
		public int CompareTo(FixedString4096Bytes other); // 0x000000018D2ABAC8-0x000000018D2ABB14
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString4096Bytes b); // 0x000000018D2AC2D0-0x000000018D2AC35C
		public bool Equals(FixedString4096Bytes other); // 0x000000018D2ABF60-0x000000018D2ABF74
		[NotBurstCompatible]
		public static implicit operator FixedString64Bytes(string b); // 0x000000018D2AC35C-0x000000018D2AC388
		[NotBurstCompatible]
		public override string ToString(); // 0x0000000187834F10-0x0000000187834F1C
		public override int GetHashCode(); // 0x000000018D2ABF74-0x000000018D2ABFB0
		[NotBurstCompatible]
		public override bool Equals(object obj); // 0x000000018D2ABBE4-0x000000018D2ABE8C
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes126 // TypeDefIndex: 88114
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
	[BurstCompatible]
	[DefaultMember("Item")]
	public struct FixedString128Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 88115
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 125; // Metadata: 0x02647F43
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes126 bytes; // 0x02
	
		// Properties
		public int Length { get; set; } // 0x000000018448B780-0x000000018448B790 0x00000001872593D0-0x00000001872593E0
	
		// Constructors
		[NotBurstCompatible]
		public FixedString128Bytes(string source); // 0x00000001859D2E80-0x00000001859D2EB0
	
		// Methods
		public unsafe byte* GetUnsafePtr(); // 0x00000001872593C0-0x00000001872593D0
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x02647F42 */); // 0x000000018D2A9D7C-0x000000018D2A9DE8
		[NotBurstCompatible]
		public int CompareTo(string other); // 0x000000018D2A98A8-0x000000018D2A98DC
		[NotBurstCompatible]
		public bool Equals(string other); // 0x000000018D2A99C4-0x000000018D2A9A48
		[NotBurstCompatible]
		internal int Initialize(string source); // 0x00000001859D2EB0-0x00000001859D2F30
		public int CompareTo(FixedString32Bytes other); // 0x000000018D2A9928-0x000000018D2A9974
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString32Bytes b); // 0x000000018D2A9E74-0x000000018D2A9F00
		public bool Equals(FixedString32Bytes other); // 0x000000018D2A99B0-0x000000018D2A99C4
		public int CompareTo(FixedString64Bytes other); // 0x000000018D2A98DC-0x000000018D2A9928
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString64Bytes b); // 0x000000018D2A9F80-0x000000018D2AA00C
		public bool Equals(FixedString64Bytes other); // 0x000000018D2A9A48-0x000000018D2A9A5C
		public int CompareTo(FixedString128Bytes other); // 0x000000018D2A9810-0x000000018D2A985C
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString128Bytes b); // 0x000000018D2A9F00-0x000000018D2A9F80
		public bool Equals(FixedString128Bytes other); // 0x000000018D2A999C-0x000000018D2A99B0
		public int CompareTo(FixedString512Bytes other); // 0x000000018D2A985C-0x000000018D2A98A8
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString512Bytes b); // 0x000000018D2A9DE8-0x000000018D2A9E74
		public bool Equals(FixedString512Bytes other); // 0x000000018D2A9974-0x000000018D2A9988
		public int CompareTo(FixedString4096Bytes other); // 0x000000018D2A97C4-0x000000018D2A9810
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString4096Bytes b); // 0x000000018D2AA00C-0x000000018D2AA098
		public bool Equals(FixedString4096Bytes other); // 0x000000018D2A9988-0x000000018D2A999C
		[NotBurstCompatible]
		public static implicit operator FixedString128Bytes(string b); // 0x00000001859D2E40-0x00000001859D2E80
		[NotBurstCompatible]
		public override string ToString(); // 0x000000018D2A9D40-0x000000018D2A9D7C
		public override int GetHashCode(); // 0x000000018D2A9D04-0x000000018D2A9D40
		[NotBurstCompatible]
		public override bool Equals(object obj); // 0x000000018D2A9A5C-0x000000018D2A9D04
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes510 // TypeDefIndex: 88116
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
	[BurstCompatible]
	[DefaultMember("Item")]
	public struct FixedString512Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 88117
	{
		// Fields
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes510 bytes; // 0x02
	
		// Properties
		public int Length { get; } // 0x000000018448B780-0x000000018448B790 
	
		// Methods
		public unsafe byte* GetUnsafePtr(); // 0x00000001872593C0-0x00000001872593D0
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x02647F45 */); // 0x000000018D2AB710-0x000000018D2AB780
		[NotBurstCompatible]
		public int CompareTo(string other); // 0x000000018D2AB288-0x000000018D2AB2BC
		[NotBurstCompatible]
		public bool Equals(string other); // 0x000000018D2AB614-0x000000018D2AB698
		public int CompareTo(FixedString32Bytes other); // 0x000000018D2AB2BC-0x000000018D2AB308
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString32Bytes b); // 0x000000018D2AB9A4-0x000000018D2ABA30
		public bool Equals(FixedString32Bytes other); // 0x000000018D2AB31C-0x000000018D2AB330
		public int CompareTo(FixedString64Bytes other); // 0x000000018D2AB1F0-0x000000018D2AB23C
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString64Bytes b); // 0x000000018D2AB918-0x000000018D2AB9A4
		public bool Equals(FixedString64Bytes other); // 0x000000018D2AB308-0x000000018D2AB31C
		public int CompareTo(FixedString128Bytes other); // 0x000000018D2AB1A4-0x000000018D2AB1F0
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString128Bytes b); // 0x000000018D2AB800-0x000000018D2AB88C
		public bool Equals(FixedString128Bytes other); // 0x000000018D2AB5EC-0x000000018D2AB600
		public int CompareTo(FixedString512Bytes other); // 0x000000018D2AB158-0x000000018D2AB1A4
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString512Bytes b); // 0x000000018D2AB780-0x000000018D2AB800
		public bool Equals(FixedString512Bytes other); // 0x000000018D2AB5D8-0x000000018D2AB5EC
		public int CompareTo(FixedString4096Bytes other); // 0x000000018D2AB23C-0x000000018D2AB288
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString4096Bytes b); // 0x000000018D2AB88C-0x000000018D2AB918
		public bool Equals(FixedString4096Bytes other); // 0x000000018D2AB600-0x000000018D2AB614
		[NotBurstCompatible]
		public override string ToString(); // 0x000000018D2AB6D4-0x000000018D2AB710
		public override int GetHashCode(); // 0x000000018D2AB698-0x000000018D2AB6D4
		[NotBurstCompatible]
		public override bool Equals(object obj); // 0x000000018D2AB330-0x000000018D2AB5D8
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes4094 // TypeDefIndex: 88118
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
	[BurstCompatible]
	[DefaultMember("Item")]
	public struct FixedString4096Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 88119
	{
		// Fields
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes4094 bytes; // 0x02
	
		// Properties
		public int Length { get; } // 0x000000018448B780-0x000000018448B790 
	
		// Methods
		public unsafe byte* GetUnsafePtr(); // 0x00000001872593C0-0x00000001872593D0
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x02647F46 */); // 0x000000018D2AAE38-0x000000018D2AAEA8
		[NotBurstCompatible]
		public int CompareTo(string other); // 0x000000018D2AA9FC-0x000000018D2AAA30
		[NotBurstCompatible]
		public bool Equals(string other); // 0x000000018D2AAA44-0x000000018D2AAAC8
		public int CompareTo(FixedString32Bytes other); // 0x000000018D2AA964-0x000000018D2AA9B0
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString32Bytes b); // 0x000000018D2AAFB4-0x000000018D2AB040
		public bool Equals(FixedString32Bytes other); // 0x000000018D2AAD98-0x000000018D2AADAC
		public int CompareTo(FixedString64Bytes other); // 0x000000018D2AA9B0-0x000000018D2AA9FC
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString64Bytes b); // 0x000000018D2AAF28-0x000000018D2AAFB4
		public bool Equals(FixedString64Bytes other); // 0x000000018D2AADAC-0x000000018D2AADC0
		public int CompareTo(FixedString128Bytes other); // 0x000000018D2AA918-0x000000018D2AA964
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString128Bytes b); // 0x000000018D2AB040-0x000000018D2AB0CC
		public bool Equals(FixedString128Bytes other); // 0x000000018D2AAAC8-0x000000018D2AAADC
		public int CompareTo(FixedString512Bytes other); // 0x000000018D2AA880-0x000000018D2AA8CC
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString512Bytes b); // 0x000000018D2AB0CC-0x000000018D2AB158
		public bool Equals(FixedString512Bytes other); // 0x000000018D2AAADC-0x000000018D2AAAF0
		public int CompareTo(FixedString4096Bytes other); // 0x000000018D2AA8CC-0x000000018D2AA918
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString4096Bytes b); // 0x000000018D2AAEA8-0x000000018D2AAF28
		public bool Equals(FixedString4096Bytes other); // 0x000000018D2AAA30-0x000000018D2AAA44
		[NotBurstCompatible]
		public override string ToString(); // 0x000000018D2AADFC-0x000000018D2AAE38
		public override int GetHashCode(); // 0x000000018D2AADC0-0x000000018D2AADFC
		[NotBurstCompatible]
		public override bool Equals(object obj); // 0x000000018D2AAAF0-0x000000018D2AAD98
	}

	[BurstCompatible]
	[BurstCompatible]
	[BurstCompatible]
	[BurstCompatible]
	public static class FixedStringMethods // TypeDefIndex: 88120
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(FixedString128Bytes) })]
		public static unsafe FormatError Append<T>(this ref ref T fs, byte* utf8Bytes, int utf8BytesLength)
			where T : struct, INativeList<byte>, IUTF8Bytes;
		[NotBurstCompatible]
		public static FormatError Append<T>(this ref ref T fs, string s)
			where T : struct, INativeList<byte>, IUTF8Bytes;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(FixedString128Bytes) })]
		public static unsafe int CompareTo<T>(this ref ref T fs, byte* bytes, int bytesLen)
			where T : struct, INativeList<byte>, IUTF8Bytes;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(FixedString128Bytes), typeof(FixedString128Bytes) })]
		public static int CompareTo<T, T2>(this ref ref T fs, [IsReadOnly] in ref T2 other)
			where T : struct, INativeList<byte>, IUTF8Bytes
			where T2 : struct, INativeList<byte>, IUTF8Bytes;
		[NotBurstCompatible]
		public static string ConvertToString<T>(this ref ref T fs)
			where T : struct, INativeList<byte>, IUTF8Bytes;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(FixedString128Bytes) })]
		public static int ComputeHashCode<T>(this ref ref T fs)
			where T : struct, INativeList<byte>, IUTF8Bytes;
	}

	public interface IUTF8Bytes // TypeDefIndex: 88121
	{
		// Methods
		byte* GetUnsafePtr();
		bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x02647F47 */);
	}

	public static class ListExtensions // TypeDefIndex: 88122
	{
		// Extension methods
		public static void RemoveAtSwapBack<T>(this List<T> list, int index);
		public static NativeArray<T> ToNativeArray<T>(this List<T> list, AllocatorManager.AllocatorHandle allocator)
			where T : struct;
	}

	[BurstCompatible]
	internal struct Memory // TypeDefIndex: 88125
	{
		// Nested types
		[BurstCompatible]
		internal struct Unmanaged // TypeDefIndex: 88124
		{
			// Nested types
			[BurstCompatible]
			internal struct Array // TypeDefIndex: 88123
			{
				// Methods
				private static bool IsCustom(AllocatorManager.AllocatorHandle allocator); // 0x00000001851641B0-0x00000001851641C0
				private static unsafe void* CustomResize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align); // 0x000000018D2A95F4-0x000000018D2A96A0
				internal static unsafe void* Resize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align); // 0x0000000185164090-0x00000001851641B0
				[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
				internal static unsafe T* Resize<T>(T* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator)
					where T : struct;
			}
	
			// Methods
			internal static unsafe void* Allocate(long size, int align, AllocatorManager.AllocatorHandle allocator); // 0x0000000185164060-0x0000000185164090
			internal static unsafe void Free(void* pointer, AllocatorManager.AllocatorHandle allocator); // 0x0000000185E695C0-0x0000000185E69600
			[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
			internal static unsafe void Free<T>(T* pointer, AllocatorManager.AllocatorHandle allocator)
				where T : struct;
		}
	}

	[BurstCompatible]
	public static class NativeArrayExtensions // TypeDefIndex: 88126
	{
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static unsafe int IndexOf<T, U>(void* ptr, int length, U value)
			where T : struct, IEquatable<U>;
	
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this NativeList<T> list, U value)
			where T : struct, IEquatable<U>;
		public static Span<T> AsSpan<T>(this NativeArray<T> array)
			where T : struct;
		public static Span<T> AsSpanThread<T>(this NativeArray<T> array)
			where T : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static NativeArray<U> Reinterpret<T, U>(this NativeArray<T> array)
			where T : struct
			where U : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		internal static void Initialize<T>(this ref NativeArray<T> array, int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x02647F48 */)
			where T : struct;
	}

	public interface IIndexable<T> // TypeDefIndex: 88127
		where T : struct
	{
		// Properties
		int Length { get; }
	}

	[DefaultMember("Item")]
	public interface INativeList<T> : IIndexable<T> // TypeDefIndex: 88128
		where T : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(NativeListDebugView<T>))]
	[NativeContainer]
	public struct NativeList<T> : INativeDisposable, INativeList<T>, IEnumerable<T> // TypeDefIndex: 88130
		where T : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<T>* m_ListData;
		internal AllocatorManager.AllocatorHandle m_DeprecatedAllocator;
	
		// Properties
		public T this[int index] { get => default; set {} }
		public int Length { get; }
		public int Capacity { get; set; }
		public bool IsEmpty { get; }
		public bool IsCreated { get; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 88129
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public unsafe UnsafeList<T>* ListData;
	
			// Constructors
			internal unsafe ParallelWriter(UnsafeList<T>* listData);
	
			// Methods
			public void AddNoResize(T value);
		}
	
		// Constructors
		public unsafe NativeList(AllocatorManager.AllocatorHandle allocator);
		public unsafe NativeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator);
		private unsafe NativeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth);
	
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(AllocatorManager.AllocatorHandle) })]
		internal void Initialize<U>(int initialCapacity, ref ref U allocator, int disposeSentinelStackDepth)
			where U : struct, AllocatorManager.IAllocator;
		public ref ref T ElementAt(int index);
		public unsafe UnsafeList<T>* GetUnsafeList();
		public void AddNoResize(T value);
		public unsafe void AddRangeNoResize(void* ptr, int count);
		public void Add([IsReadOnly] in ref T value);
		public void AddRange(NativeArray<T> array);
		public unsafe void AddRange(void* ptr, int count);
		public void RemoveAtSwapBack(int index);
		public void RemoveAt(int index);
		public void RemoveRange(int index, int count);
		public void Dispose();
		[NotBurstCompatible]
		public JobHandle Dispose(JobHandle inputDeps);
		[NotBurstCompatible]
		public JobHandle CrossFrameDispose(JobHandle inputDeps, JobQueuePriority priority = JobQueuePriority.NormalJobPriority /* Metadata: 0x02647F49 */);
		public void Clear();
		public static implicit operator NativeArray<T>(NativeList<T> nativeList);
		public NativeArray<T> AsArray();
		public NativeArray<T> AsDeferredJobArray();
		[NotBurstCompatible]
		public T[] ToArray();
		public NativeArray<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		public void CopyFrom(NativeArray<T> array);
		public void Resize(int length, NativeArrayOptions options);
		public void ResizeUninitialized(int length);
		public NativeArray<T> AsParallelReader();
		public ParallelWriter AsParallelWriter();
	}

	[BurstCompatible]
	[NativeContainer]
	internal struct NativeListDispose // TypeDefIndex: 88131
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe UntypedUnsafeList* m_ListData; // 0x00
	
		// Methods
		public void Dispose(); // 0x000000018D2ACB40-0x000000018D2ACB7C
	}

	[BurstCompatible]
	[BurstCompile]
	internal struct NativeListDisposeJob : IJob // TypeDefIndex: 88132
	{
		// Fields
		internal NativeListDispose Data; // 0x00
	
		// Methods
		public void Execute(); // 0x000000018D2ACB38-0x000000018D2ACB40
	}

	internal sealed class NativeListDebugView<T> // TypeDefIndex: 88133
		where T : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy<TKey, TValue>))]
	[NativeContainer]
	public struct NativeParallelHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 88136
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData;
	
		// Properties
		public bool IsEmpty { get; }
		public int Capacity { get; set; }
		public TValue this[TKey key] { get => default; set {} }
		public bool IsCreated { get; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		[DebuggerDisplay("Capacity = {m_Writer.Capacity}")]
		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 88134
		{
			// Fields
			internal UnsafeParallelHashMap<TKey, TValue> m_Writer;
	
			// Methods
			public bool TryAdd(TKey key, TValue item);
		}
	
		[NativeContainer]
		[NativeContainerIsReadOnly]
		public struct Enumerator : IEnumerator<KeyValue<TKey, TValue>> // TypeDefIndex: 88135
		{
			// Fields
			internal UnsafeParallelHashMapDataEnumerator m_Enumerator;
	
			// Properties
			public KeyValue<TKey, TValue> Current { get; }
			object IEnumerator.Current { get; }
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		// Constructors
		public NativeParallelHashMap(int capacity, AllocatorManager.AllocatorHandle allocator);
		private NativeParallelHashMap(int capacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth);
	
		// Methods
		public int Count();
		public void Clear();
		public bool TryAdd(TKey key, [IsReadOnly] in ref TValue item);
		public void Add(TKey key, TValue item);
		public bool Remove(TKey key);
		public bool TryGetValue(TKey key, out ref TValue item);
		public bool ContainsKey(TKey key);
		public void Dispose();
		[NotBurstCompatible]
		public JobHandle Dispose(JobHandle inputDeps);
		public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator);
		public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator);
		public ParallelWriter AsParallelWriter();
		public Enumerator GetEnumerator();
		IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	internal sealed class NativeParallelHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 88137
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
	}

	[BurstCompatible]
	public static class NativeParallelHashMapExtensions // TypeDefIndex: 88138
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static UnsafeParallelHashMap<TKey, TValue> GetUnsafeMap<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> container)
			where TKey : struct, IEquatable<TKey>, IComparable<TKey>
			where TValue : struct;
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(NativeHashSetDebuggerTypeProxy<T>))]
	public struct NativeParallelHashSet<T> : INativeDisposable, IEnumerable<T> // TypeDefIndex: 88140
		where T : struct, IEquatable<T>
	{
		// Fields
		internal NativeParallelHashMap<T, bool> m_Data;
	
		// Properties
		public bool IsEmpty { get; }
		public bool IsCreated { get; }
	
		// Nested types
		[NativeContainer]
		[NativeContainerIsReadOnly]
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 88139
		{
			// Fields
			internal UnsafeParallelHashMapDataEnumerator m_Enumerator;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		// Constructors
		public NativeParallelHashSet(int capacity, AllocatorManager.AllocatorHandle allocator);
	
		// Methods
		public int Count();
		public void Dispose();
		public void Clear();
		public bool Add(T item);
		public bool Remove(T item);
		public bool Contains(T item);
		public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator);
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	internal sealed class NativeHashSetDebuggerTypeProxy<T> // TypeDefIndex: 88141
		where T : struct, IEquatable<T>
	{
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	public struct NativeParallelMultiHashMapIterator<TKey> // TypeDefIndex: 88142
		where TKey : struct
	{
		// Fields
		internal TKey key;
		internal int NextEntryIndex;
		internal int EntryIndex;
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerTypeProxy(typeof(NativeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue>))]
	[NativeContainer]
	public struct NativeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 88145
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData;
	
		// Properties
		public bool IsEmpty { get; }
		public int Capacity { get; }
		public bool IsCreated { get; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 88143
		{
			// Fields
			internal UnsafeParallelMultiHashMap<TKey, TValue> m_Writer;
	
			// Methods
			public void Add(TKey key, TValue item);
		}
	
		public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 88144
		{
			// Fields
			internal NativeParallelMultiHashMap<TKey, TValue> hashmap;
			internal TKey key;
			internal bool isFirst;
			private TValue value;
			private NativeParallelMultiHashMapIterator<TKey> iterator;
	
			// Properties
			public TValue Current { get; }
			object IEnumerator.Current { get; }
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
			public Enumerator<TKey, TValue> GetEnumerator();
		}
	
		// Constructors
		public NativeParallelMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator);
		private NativeParallelMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth);
	
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(AllocatorManager.AllocatorHandle) })]
		internal void Initialize<U>(int capacity, ref ref U allocator, int disposeSentinelStackDepth)
			where U : struct, AllocatorManager.IAllocator;
		public int Count();
		public void Clear();
		public void Add(TKey key, TValue item);
		public int Remove(TKey key);
		public void Remove(NativeParallelMultiHashMapIterator<TKey> it);
		public bool TryGetFirstValue(TKey key, out ref TValue item, out NativeParallelMultiHashMapIterator<TKey> it);
		public bool TryGetNextValue(out ref TValue item, ref NativeParallelMultiHashMapIterator<TKey> it);
		public bool ContainsKey(TKey key);
		public int CountValuesForKey(TKey key);
		public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it);
		public void Dispose();
		public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator);
		public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator);
		public ParallelWriter AsParallelWriter();
		public Enumerator GetValuesForKey(TKey key);
		IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	internal sealed class NativeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 88146
		where TKey : struct, IEquatable<TKey>, IComparable<TKey>
		where TValue : struct
	{
	}

	internal struct NativeQueueBlockHeader // TypeDefIndex: 88147
	{
		// Fields
		public unsafe NativeQueueBlockHeader* m_NextBlock; // 0x00
		public int m_NumItems; // 0x08
	}

	[BurstCompatible]
	internal struct NativeQueueBlockPoolData // TypeDefIndex: 88148
	{
		// Fields
		internal IntPtr m_FirstBlock; // 0x00
		internal int m_NumBlocks; // 0x08
		internal int m_MaxBlocks; // 0x0C
		internal int m_AllocLock; // 0x10
	
		// Methods
		public unsafe NativeQueueBlockHeader* AllocateBlock(); // 0x000000018630B940-0x000000018630B9C0
		public unsafe void FreeBlock(NativeQueueBlockHeader* block); // 0x0000000186228850-0x0000000186228920
	}

	internal class NativeQueueBlockPool // TypeDefIndex: 88149
	{
		// Fields
		private static readonly SharedStatic<IntPtr> Data; // 0x00
	
		// Constructors
		static NativeQueueBlockPool(); // 0x00000001869F0F60-0x00000001869F0FC0
	
		// Methods
		internal static unsafe NativeQueueBlockPoolData* GetQueueBlockPool(); // 0x00000001865B56D0-0x00000001865B57F0
		[BurstDiscard]
		private static void AppDomainOnDomainUnload(); // 0x0000000185B800E0-0x0000000185B80170
		private static void OnDomainUnload(object sender, EventArgs e); // 0x000000018D2ACB7C-0x000000018D2ACC50
	}

	[BurstCompatible]
	internal struct NativeQueueData // TypeDefIndex: 88150
	{
		// Fields
		public IntPtr m_FirstBlock; // 0x00
		public IntPtr m_LastBlock; // 0x08
		public int m_MaxItems; // 0x10
		public int m_CurrentRead; // 0x14
		public unsafe byte* m_CurrentWriteBlockTLS; // 0x18
	
		// Methods
		internal unsafe NativeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex); // 0x00000001872593E0-0x00000001872593F0
		internal unsafe void SetCurrentWriteBlockTLS(int threadIndex, NativeQueueBlockHeader* currentWriteBlock); // 0x00000001872593F0-0x0000000187259400
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe NativeQueueBlockHeader* AllocateWriteBlockMT<T>(NativeQueueData* data, NativeQueueBlockPoolData* pool, int threadIndex)
			where T : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void AllocateQueue<T>(AllocatorManager.AllocatorHandle label, out NativeQueueData* outBuf)
			where T : struct;
		public static unsafe void DeallocateQueue(NativeQueueData* data, NativeQueueBlockPoolData* pool, AllocatorManager.AllocatorHandle allocation); // 0x000000018674A070-0x000000018674A0C0
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[NativeContainer]
	public struct NativeQueue<T> : INativeDisposable // TypeDefIndex: 88152
		where T : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe NativeQueueData* m_Buffer;
		[NativeDisableUnsafePtrRestriction]
		private unsafe NativeQueueBlockPoolData* m_QueuePool;
		private AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public int Count { get; }
		public bool IsCreated { get; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 88151
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			internal unsafe NativeQueueData* m_Buffer;
			[NativeDisableUnsafePtrRestriction]
			internal unsafe NativeQueueBlockPoolData* m_QueuePool;
			[NativeSetThreadIndex]
			internal int m_ThreadIndex;
	
			// Methods
			public void Enqueue(T value);
		}
	
		// Constructors
		public unsafe NativeQueue(AllocatorManager.AllocatorHandle allocator);
	
		// Methods
		public bool IsEmpty();
		public void Enqueue(T value);
		public bool TryDequeue(out ref T item);
		public NativeArray<T> ToArray(AllocatorManager.AllocatorHandle allocator);
		public void Clear();
		public void Dispose();
		[NotBurstCompatible]
		public JobHandle Dispose(JobHandle inputDeps);
		public ParallelWriter AsParallelWriter();
	}

	[BurstCompatible]
	[NativeContainer]
	internal struct NativeQueueDispose // TypeDefIndex: 88153
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe NativeQueueData* m_Buffer; // 0x00
		[NativeDisableUnsafePtrRestriction]
		internal unsafe NativeQueueBlockPoolData* m_QueuePool; // 0x08
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x10
	
		// Methods
		public void Dispose(); // 0x000000018D2ACC58-0x000000018D2ACC6C
	}

	[BurstCompile]
	internal struct NativeQueueDisposeJob : IJob // TypeDefIndex: 88154
	{
		// Fields
		public NativeQueueDispose Data; // 0x00
	
		// Methods
		public void Execute(); // 0x000000018D2ACC50-0x000000018D2ACC58
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[NativeContainer]
	public struct NativeReference<T> : INativeDisposable, IEquatable<NativeReference<T>> // TypeDefIndex: 88155
		where T : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe void* m_Data;
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public T Value { get; set; }
		public bool IsCreated { get; }
	
		// Constructors
		public unsafe NativeReference(AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x02647F4A */);
		public unsafe NativeReference(T value, AllocatorManager.AllocatorHandle allocator);
	
		// Methods
		private static void Allocate(AllocatorManager.AllocatorHandle allocator, out NativeReference<T> reference);
		public void Dispose();
		[NotBurstCompatible]
		public bool Equals(NativeReference<T> other);
		[NotBurstCompatible]
		public override bool Equals(object obj);
		public override int GetHashCode();
	}

	[NativeContainer]
	internal struct NativeReferenceDispose // TypeDefIndex: 88156
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe void* m_Data; // 0x00
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x08
	
		// Methods
		public void Dispose(); // 0x000000018D2ACC74-0x000000018D2ACC84
	}

	[BurstCompile]
	internal struct NativeReferenceDisposeJob : IJob // TypeDefIndex: 88157
	{
		// Fields
		internal NativeReferenceDispose Data; // 0x00
	
		// Methods
		public void Execute(); // 0x000000018D2ACC6C-0x000000018D2ACC74
	}

	[BurstCompatible]
	public static class NativeSortExtension // TypeDefIndex: 88159
	{
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public struct DefaultComparer<T> : IComparer<T> // TypeDefIndex: 88158
			where T : IComparable<T>
		{
			// Methods
			public int Compare(T x, T y);
		}
	
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void Sort<T>(T* array, int length)
			where T : struct, IComparable<T>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(DefaultComparer<int>) })]
		public static unsafe void Sort<T, U>(T* array, int length, U comp)
			where T : struct
			where U : IComparer<T>;
		[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new System.Type[2] {typeof(int), typeof(DefaultComparer<int>) })]
		public static unsafe SortJob<T, U> SortJob<T, U>(T* array, int length, U comp)
			where T : struct
			where U : IComparer<T>;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe int BinarySearch<T>(T* ptr, int length, T value)
			where T : struct, IComparable<T>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(DefaultComparer<int>) })]
		public static unsafe int BinarySearch<T, U>(T* ptr, int length, T value, U comp)
			where T : struct
			where U : IComparer<T>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(DefaultComparer<int>) })]
		internal static unsafe void IntroSort<T, U>(void* array, int length, U comp)
			where T : struct
			where U : IComparer<T>;
		private static unsafe void IntroSort<T, U>(void* array, int lo, int hi, int depth, U comp)
			where T : struct
			where U : IComparer<T>;
		private static unsafe void InsertionSort<T, U>(void* array, int lo, int hi, U comp)
			where T : struct
			where U : IComparer<T>;
		private static unsafe int Partition<T, U>(void* array, int lo, int hi, U comp)
			where T : struct
			where U : IComparer<T>;
		private static unsafe void HeapSort<T, U>(void* array, int lo, int hi, U comp)
			where T : struct
			where U : IComparer<T>;
		private static unsafe void Heapify<T, U>(void* array, int i, int n, int lo, U comp)
			where T : struct
			where U : IComparer<T>;
		private static unsafe void Swap<T>(void* array, int lhs, int rhs)
			where T : struct;
		private static unsafe void SwapIfGreaterWithItems<T, U>(void* array, int lhs, int rhs, U comp)
			where T : struct
			where U : IComparer<T>;
	
		// Extension methods
		[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static SortJob<T, DefaultComparer<T>> SortJob<T>(this NativeArray<T> array)
			where T : struct, IComparable<T>;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static void Sort<T>(this NativeList<T> list)
			where T : struct, IComparable<T>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(DefaultComparer<int>) })]
		public static void Sort<T, U>(this NativeList<T> list, U comp)
			where T : struct
			where U : IComparer<T>;
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new System.Type[2] {typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	public struct SortJob<T, U> // TypeDefIndex: 88162
		where T : struct
		where U : IComparer<T>
	{
		// Fields
		public unsafe T* Data;
		public U Comp;
		public int Length;
	
		// Nested types
		[BurstCompile]
		private struct SegmentSort : IJobParallelFor // TypeDefIndex: 88160
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public unsafe T* Data;
			public U Comp;
			public int Length;
			public int SegmentWidth;
	
			// Methods
			public void Execute(int index);
		}
	
		[BurstCompile]
		private struct SegmentSortMerge : IJob // TypeDefIndex: 88161
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public unsafe T* Data;
			public U Comp;
			public int Length;
			public int SegmentWidth;
	
			// Methods
			public void Execute();
		}
	
		// Methods
		[NotBurstCompatible]
		public JobHandle Schedule(JobHandle inputDeps = default);
	}

	[BurstCompatible]
	[NativeContainer]
	public struct NativeStream : IDisposable // TypeDefIndex: 88167
	{
		// Fields
		private UnsafeStream m_Stream; // 0x00
	
		// Properties
		public bool IsCreated { get; } // 0x00000001853AE700-0x00000001853AE710 
	
		// Nested types
		[BurstCompile]
		private struct ConstructJobList : IJob // TypeDefIndex: 88163
		{
			// Fields
			public NativeStream Container; // 0x00
			[NativeDisableUnsafePtrRestriction]
			[Unity.Collections.ReadOnly]
			public unsafe UntypedUnsafeList* List; // 0x10
	
			// Methods
			public void Execute(); // 0x000000018D2A9710-0x000000018D2A9734
		}
	
		[BurstCompile]
		private struct ConstructJob : IJob // TypeDefIndex: 88164
		{
			// Fields
			public NativeStream Container; // 0x00
			[Unity.Collections.ReadOnly]
			public NativeArray<int> Length; // 0x10
	
			// Methods
			public void Execute(); // 0x000000018D2A9734-0x000000018D2A9744
		}
	
		[BurstCompatible]
		[NativeContainer]
		[NativeContainerSupportsMinMaxWriteRestriction]
		public struct Writer // TypeDefIndex: 88165
		{
			// Fields
			private UnsafeStream.Writer m_Writer; // 0x00
	
			// Constructors
			internal Writer(ref NativeStream stream); // 0x0000000187839D00-0x0000000187839D3C
	
			// Methods
			public void BeginForEachIndex(int foreachIndex); // 0x00000001872594D0-0x00000001872594F0
			public void EndForEachIndex(); // 0x0000000187835620-0x0000000187835628
			[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
			public void Write<T>(T value)
				where T : struct;
			[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
			public ref ref T Allocate<T>()
				where T : struct;
			public unsafe byte* Allocate(int size); // 0x0000000187834DF0-0x0000000187834DF8
		}
	
		[BurstCompatible]
		[NativeContainer]
		[NativeContainerIsReadOnly]
		public struct Reader // TypeDefIndex: 88166
		{
			// Fields
			private UnsafeStream.Reader m_Reader; // 0x00
	
			// Constructors
			internal Reader(ref NativeStream stream); // 0x0000000187259400-0x0000000187259440
	
			// Methods
			public int BeginForEachIndex(int foreachIndex); // 0x000000018D2ACCC4-0x000000018D2ACCCC
			public void EndForEachIndex(); // 0x0000000186805BA0-0x0000000186805BB0
			public unsafe byte* ReadUnsafePtr(int size); // 0x0000000185167440-0x0000000185167470
			[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
			public ref ref T Read<T>()
				where T : struct;
		}
	
		// Constructors
		public NativeStream(int bufferCount, AllocatorManager.AllocatorHandle allocator); // 0x0000000185167980-0x0000000185167A80
	
		// Methods
		public Reader AsReader(); // 0x0000000185679070-0x00000001856790A0
		public Writer AsWriter(); // 0x0000000185C1B370-0x0000000185C1B3E0
		public void Dispose(); // 0x000000018D2A9744-0x000000018D2A974C
		[NotBurstCompatible]
		public JobHandle Dispose(JobHandle inputDeps); // 0x000000018783799C-0x00000001878379D0
		private static void AllocateBlock(out NativeStream stream, AllocatorManager.AllocatorHandle allocator); // 0x0000000187834DF8-0x0000000187834E00
		private void AllocateForEach(int forEachCount); // 0x000000018D2ACC84-0x000000018D2ACC8C
	}

	internal struct Spinner // TypeDefIndex: 88168
	{
		// Fields
		private int m_value; // 0x00
	
		// Methods
		public void Lock(); // 0x000000018D2AD2FC-0x000000018D2AD310
		public void Unlock(); // 0x000000018D2AD310-0x000000018D2AD32C
	}

	internal struct UnmanagedArray<T> : IDisposable // TypeDefIndex: 88169
		where T : struct
	{
		// Fields
		private IntPtr m_pointer;
		private int m_length;
		private AllocatorManager.AllocatorHandle m_allocator;
	
		// Properties
		public ref T this[int index] { get => default; }
	
		// Methods
		public void Dispose();
	}

	[BurstCompile]
	public struct RewindableAllocator : AllocatorManager.IAllocator // TypeDefIndex: 88173
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
		public AllocatorManager.AllocatorHandle Handle { get; } // 0x00000001872342E0-0x00000001872342F0 
	
		// Nested types
		[BurstCompatible]
		internal struct MemoryBlock : IDisposable // TypeDefIndex: 88170
		{
			// Fields
			public unsafe byte* m_pointer; // 0x00
			public long m_bytes; // 0x08
			public long m_current; // 0x10
			public long m_allocations; // 0x18
	
			// Constructors
			public unsafe MemoryBlock(long bytes); // 0x000000018D2ACAE4-0x000000018D2ACB38
	
			// Methods
			public void Rewind(); // 0x00000001872401F0-0x0000000187240200
			public void Dispose(); // 0x000000018D2AC9AC-0x000000018D2ACA0C
			public int TryAllocate(ref AllocatorManager.Block block); // 0x000000018D2ACA0C-0x000000018D2ACAE4
			public bool Contains(IntPtr ptr); // 0x000000018D2AC994-0x000000018D2AC9AC
		}
	
		public delegate int Try_000008B6_PostfixBurstDelegate(IntPtr state, ref AllocatorManager.Block block); // TypeDefIndex: 88171; 0x00000001859B7730-0x00000001859B7740
	
		internal static class Try_000008B6_BurstDirectCall // TypeDefIndex: 88172
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Try_000008B6_BurstDirectCall(); // 0x000000018633AD70-0x000000018633AD80
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000baffa); // 0x000000018D2AD84C-0x000000018D2AD950
			private static IntPtr GetFunctionPointer(); // 0x000000018D2AD950-0x000000018D2AD9A4
			public static void Constructor(); // 0x000000018633C390-0x000000018633C420
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static int Invoke(IntPtr state, ref AllocatorManager.Block block); // 0x000000018D2AD9A4-0x000000018D2ADA30
		}
	
		// Methods
		public void Rewind(); // 0x000000018D2ACDA0-0x000000018D2ACE98
		public void Dispose(); // 0x000000018D2ACCCC-0x000000018D2ACDA0
		public int Try(ref AllocatorManager.Block block); // 0x000000018D2ACEA0-0x000000018D2AD064
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		internal static int Try(IntPtr state, ref AllocatorManager.Block block); // 0x000000018D2AD064-0x000000018D2AD0C0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		public static int Try_BurstManaged(IntPtr state, ref AllocatorManager.Block block); // 0x000000018D2ACE98-0x000000018D2ACEA0
	}

	public enum FormatError // TypeDefIndex: 88174
	{
		None = 0,
		Overflow = 1
	}

	public enum CopyError // TypeDefIndex: 88175
	{
		None = 0,
		Truncation = 1
	}

	public enum ConversionError // TypeDefIndex: 88176
	{
		None = 0,
		Overflow = 1,
		Encoding = 2,
		CodePoint = 3
	}

	[BurstCompatible]
	public struct Unicode // TypeDefIndex: 88178
	{
		// Properties
		public static Rune ReplacementCharacter { get; } // 0x0000000187259470-0x0000000187259480 
	
		// Nested types
		[BurstCompatible]
		public struct Rune // TypeDefIndex: 88177
		{
			// Fields
			public int value; // 0x00
		}
	
		// Methods
		public static bool IsValidCodePoint(int codepoint); // 0x00000001855D8480-0x00000001855D8490
		public static bool NotTrailer(byte b); // 0x000000018D2ADB14-0x000000018D2ADB20
		public static unsafe ConversionError Utf8ToUcs(out Rune rune, byte* buffer, ref int index, int capacity); // 0x00000001855D8430-0x00000001855D8480
		private static bool IsLeadingSurrogate(char c); // 0x00000001855D8490-0x00000001855D84B0
		private static bool IsTrailingSurrogate(char c); // 0x000000018C99D5F4-0x000000018C99D610
		public static unsafe ConversionError Utf16ToUcs(out Rune rune, char* buffer, ref int index, int capacity); // 0x00000001855D8200-0x00000001855D8270
		public static unsafe ConversionError UcsToUtf8(byte* buffer, ref int index, int capacity, Rune rune); // 0x00000001855D81C0-0x00000001855D8200
		public static unsafe ConversionError UcsToUtf16(char* buffer, ref int index, int capacity, Rune rune); // 0x00000001855D83E0-0x00000001855D8430
		public static unsafe ConversionError Utf16ToUtf8(char* utf16Buffer, int utf16Length, byte* utf8Buffer, out int utf8Length, int utf8Capacity); // 0x00000001855D80E0-0x00000001855D81C0
		public static unsafe ConversionError Utf8ToUtf16(byte* utf8Buffer, int utf8Length, char* utf16Buffer, out int utf16Length, int utf16Capacity); // 0x00000001855D8320-0x00000001855D83E0
	}

	[BurstCompatible]
	public static class UTF8ArrayUnsafeUtility // TypeDefIndex: 88180
	{
		// Nested types
		internal struct Comparison // TypeDefIndex: 88179
		{
			// Fields
			public bool terminates; // 0x00
			public int result; // 0x04
	
			// Constructors
			public Comparison(Unicode.Rune runeA, ConversionError errorA, Unicode.Rune runeB, ConversionError errorB); // 0x00000001855D84B0-0x00000001855D84F0
		}
	
		// Methods
		public static unsafe CopyError Copy(byte* dest, out int destLength, int destUTF8MaxLengthInBytes, char* src, int srcLength); // 0x000000018D2ADA30-0x000000018D2ADA64
		public static unsafe CopyError Copy(byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength); // 0x00000001855D75D0-0x00000001855D76C0
		public static unsafe int StrCmp(byte* utf8BufferA, int utf8LengthInBytesA, byte* utf8BufferB, int utf8LengthInBytesB); // 0x00000001855D8270-0x00000001855D8320
		public static unsafe bool EqualsUTF8Bytes(byte* aBytes, int aLength, byte* bBytes, int bLength); // 0x00000001855D7C20-0x00000001855D7CD0
		public static unsafe int StrCmp(byte* utf8Buffer, int utf8LengthInBytes, char* utf16Buffer, int utf16LengthInChars); // 0x000000018D2ADA64-0x000000018D2ADB14
	}

	[BurstCompatible]
	[BurstCompatible]
	[BurstCompatible]
	[BurstCompile]
	public static class xxHash3 // TypeDefIndex: 88186
	{
		// Nested types
		private struct ulong2 // TypeDefIndex: 88181
		{
			// Fields
			public ulong x; // 0x00
			public ulong y; // 0x08
	
			// Constructors
			public ulong2(ulong x, ulong y); // 0x0000000187232F10-0x0000000187232F20
		}
	
		public unsafe delegate ulong Hash64Long_000008F7_PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret); // TypeDefIndex: 88182; 0x00000001811CDB70-0x00000001811CDB90
	
		internal static class Hash64Long_000008F7_BurstDirectCall // TypeDefIndex: 88183
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Hash64Long_000008F7_BurstDirectCall(); // 0x000000018633AD80-0x000000018633AD90
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000bb0e1); // 0x000000018D2AC664-0x000000018D2AC768
			private static IntPtr GetFunctionPointer(); // 0x000000018D2AC768-0x000000018D2AC7BC
			public static void Constructor(); // 0x000000018633C420-0x000000018633C4B0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe ulong Invoke(byte* input, byte* dest, long length, byte* secret); // 0x000000018D2AC7BC-0x000000018D2AC86C
		}
	
		public unsafe delegate void Hash128Long_000008FE_PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret, out uint4 result); // TypeDefIndex: 88184; 0x00000001812083C0-0x00000001812083E0
	
		internal static class Hash128Long_000008FE_BurstDirectCall // TypeDefIndex: 88185
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Hash128Long_000008FE_BurstDirectCall(); // 0x000000018633AD90-0x000000018633ADA0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000bb0ed); // 0x000000018D2AC388-0x000000018D2AC48C
			private static IntPtr GetFunctionPointer(); // 0x000000018D2AC48C-0x000000018D2AC4E0
			public static void Constructor(); // 0x000000018633C4B0-0x000000018633C540
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(byte* input, byte* dest, long length, byte* secret, out uint4 result); // 0x000000018D2AC4E0-0x000000018D2AC5A4
		}
	
		// Methods
		internal static unsafe void Avx2HashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64); // 0x000000018722B770-0x000000018722B780
		internal static unsafe void Avx2ScrambleAcc(ulong* acc, byte* secret); // 0x000000018722B770-0x000000018722B780
		internal static unsafe void Avx2Accumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64); // 0x000000018722B770-0x000000018722B780
		internal static unsafe void Avx2Accumulate512(ulong* acc, byte* input, byte* dest, byte* secret); // 0x000000018722B770-0x000000018722B780
		public static unsafe uint2 Hash64(void* input, long length); // 0x000000018529A440-0x000000018529A730
		public static unsafe uint4 Hash128(void* input, long length); // 0x000000018D2AE764-0x000000018D2AE810
		internal static unsafe ulong Hash64Internal(byte* input, byte* dest, long length, byte* secret, ulong seed); // 0x000000018529A730-0x000000018529AA50
		internal static unsafe void Hash128Internal(byte* input, byte* dest, long length, byte* secret, ulong seed, out uint4 result); // 0x000000018D2ADF24-0x000000018D2AE078
		private static unsafe ulong Hash64Len1To3(byte* input, long len, byte* secret, ulong seed); // 0x0000000185B42F70-0x0000000185B42FB0
		private static unsafe ulong Hash64Len4To8(byte* input, long length, byte* secret, ulong seed); // 0x0000000185B42C90-0x0000000185B42CD0
		private static unsafe ulong Hash64Len9To16(byte* input, long length, byte* secret, ulong seed); // 0x0000000185B42CD0-0x0000000185B42D30
		private static unsafe ulong Hash64Len0To16(byte* input, long length, byte* secret, ulong seed); // 0x0000000185B42BE0-0x0000000185B42C90
		private static unsafe ulong Hash64Len17To128(byte* input, long length, byte* secret, ulong seed); // 0x0000000185B42D30-0x0000000185B42F70
		private static unsafe ulong Hash64Len129To240(byte* input, long length, byte* secret, ulong seed); // 0x0000000185B42B00-0x0000000185B42BE0
		[BurstCompile]
		private static unsafe ulong Hash64Long(byte* input, byte* dest, long length, byte* secret); // 0x000000018D2AE810-0x000000018D2AE888
		private static unsafe void Hash128Len1To3(byte* input, long length, byte* secret, ulong seed, out uint4 result); // 0x000000018D2AE4AC-0x000000018D2AE544
		private static unsafe void Hash128Len4To8(byte* input, long len, byte* secret, ulong seed, out uint4 result); // 0x000000018D2AE544-0x000000018D2AE5F8
		private static unsafe void Hash128Len9To16(byte* input, long len, byte* secret, ulong seed, out uint4 result); // 0x000000018D2AE5F8-0x000000018D2AE6EC
		private static unsafe void Hash128Len0To16(byte* input, long length, byte* secret, ulong seed, out uint4 result); // 0x000000018D2AE078-0x000000018D2AE10C
		private static unsafe void Hash128Len17To128(byte* input, long length, byte* secret, ulong seed, out uint4 result); // 0x000000018D2AE318-0x000000018D2AE4AC
		private static unsafe void Hash128Len129To240(byte* input, long length, byte* secret, ulong seed, out uint4 result); // 0x000000018D2AE10C-0x000000018D2AE318
		[BurstCompile]
		private static unsafe void Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result); // 0x000000018D2AE6EC-0x000000018D2AE764
		internal static uint2 ToUint2(ulong u); // 0x0000000187259580-0x00000001872595A0
		internal static uint4 ToUint4(ulong ul0, ulong ul1); // 0x00000001872595A0-0x00000001872595C0
		internal static unsafe void EncodeSecretKey(byte* dst, byte* secret, ulong seed); // 0x000000018D2ADEF4-0x000000018D2ADF24
		private static unsafe ulong Read64LE(void* addr); // 0x0000000184431970-0x0000000184431980
		private static unsafe uint Read32LE(void* addr); // 0x00000001844AD290-0x00000001844AD2A0
		private static unsafe void Write64LE(void* addr, ulong value); // 0x000000018561B5B0-0x000000018561B5C0
		private static ulong Mul32To64(uint x, uint y); // 0x0000000187253020-0x0000000187253030
		private static ulong Swap64(ulong x); // 0x0000000187259570-0x0000000187259580
		private static uint Swap32(uint x); // 0x0000000187252C60-0x0000000187252C70
		private static uint RotL32(uint x, int r); // 0x0000000187235270-0x0000000187235290
		private static ulong RotL64(ulong x, int r); // 0x0000000187259550-0x0000000187259570
		private static ulong XorShift64(ulong v64, int shift); // 0x00000001872595C0-0x00000001872595E0
		private static ulong Mul128Fold64(ulong lhs, ulong rhs); // 0x000000018D2AE9E0-0x000000018D2AEA04
		private static unsafe ulong Mix16(byte* input, byte* secret, ulong seed); // 0x000000018D2AE914-0x000000018D2AE934
		private static unsafe ulong2 Mix32(ulong2 acc, byte* input_1, byte* input_2, byte* secret, ulong seed); // 0x000000018D2AE940-0x000000018D2AE9E0
		private static ulong Avalanche(ulong h64); // 0x0000000187259520-0x0000000187259550
		private static ulong AvalancheH64(ulong h64); // 0x0000000185B42FB0-0x0000000185B42FF0
		private static ulong rrmxmx(ulong h64, ulong length); // 0x00000001872595E0-0x0000000187259640
		private static unsafe ulong Mix2Acc(ulong acc0, ulong acc1, byte* secret); // 0x000000018D2AE934-0x000000018D2AE940
		internal static unsafe ulong MergeAcc(ulong* acc, byte* secret, ulong start); // 0x000000018D2AE888-0x000000018D2AE914
		private static unsafe void DefaultHashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64); // 0x000000018D2ADD38-0x000000018D2ADEC4
		internal static unsafe void DefaultAccumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64); // 0x000000018D2ADC94-0x000000018D2ADD38
		internal static unsafe void DefaultAccumulate512(ulong* acc, byte* input, byte* dest, byte* secret, int isHash64); // 0x000000018D2ADC14-0x000000018D2ADC94
		internal static unsafe void DefaultScrambleAcc(ulong* acc, byte* secret); // 0x000000018D2ADEC4-0x000000018D2ADEF4
		[BurstCompile]
		public static unsafe ulong Hash64Long_BurstManaged(byte* input, byte* dest, long length, byte* secret); // 0x000000018D2A9194-0x000000018D2A9344
		[BurstCompile]
		public static unsafe void Hash128Long_BurstManaged(byte* input, byte* dest, long length, byte* secret, out uint4 result); // 0x000000018D2A9054-0x000000018D2A9194
	}

	internal static class xxHashDefaultKey // TypeDefIndex: 88187
	{
		// Fields
		public static readonly byte[] kSecret; // 0x00
	
		// Constructors
		static xxHashDefaultKey(); // 0x00000001871762B0-0x0000000187176340
	}
}

namespace Unity.Collections.LowLevel.Unsafe
{
	[BurstCompatible]
	public static class NativeListUnsafeUtility // TypeDefIndex: 88189
	{
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* GetInternalListDataPtrUnchecked<T>(ref NativeList<T> list)
			where T : struct;
	
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* GetUnsafePtr<T>(this NativeList<T> list)
			where T : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* GetUnsafeReadOnlyPtr<T>(this NativeList<T> list)
			where T : struct;
	}

	[BurstCompatible]
	public static class NativeReferenceUnsafeUtility // TypeDefIndex: 88190
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* GetUnsafePtr<T>(this NativeReference<T> reference)
			where T : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* GetUnsafePtrWithoutChecks<T>(this NativeReference<T> reference)
			where T : struct;
	}

	[BurstCompatible]
	public struct UnsafeAppendBuffer : INativeDisposable // TypeDefIndex: 88191
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe byte* Ptr; // 0x00
		public int Length; // 0x08
		public int Capacity; // 0x0C
		public AllocatorManager.AllocatorHandle Allocator; // 0x10
		public readonly int Alignment; // 0x14
	
		// Methods
		public void Dispose(); // 0x000000018D2ADB20-0x000000018D2ADBA8
	}

	[BurstCompile]
	internal struct UnsafeDisposeJob : IJob // TypeDefIndex: 88192
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe void* Ptr; // 0x00
		public AllocatorManager.AllocatorHandle Allocator; // 0x08
	
		// Methods
		public void Execute(); // 0x000000018D2ADBA8-0x000000018D2ADBFC
	}

	internal struct UntypedUnsafeList // TypeDefIndex: 88193
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe void* Ptr; // 0x00
		public int m_length; // 0x08
		public int m_capacity; // 0x0C
		public AllocatorManager.AllocatorHandle Allocator; // 0x10
		internal int obsolete_length; // 0x14
		internal int obsolete_capacity; // 0x18
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(UnsafeListTDebugView<T>))]
	public struct UnsafeList<T> : INativeDisposable, INativeList<T>, IEnumerable<T> // TypeDefIndex: 88196
		where T : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe T* Ptr;
		public int m_length;
		public int m_capacity;
		public AllocatorManager.AllocatorHandle Allocator;
		[Obsolete("Use Length property (UnityUpgradable) -> Length", true)]
		public int length;
		[Obsolete("Use Capacity property (UnityUpgradable) -> Capacity", true)]
		public int capacity;
	
		// Properties
		public int Length { get; }
		public int Capacity { get; set; }
		public T this[int index] { get => default; set {} }
		public bool IsCreated { get; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public struct ParallelReader // TypeDefIndex: 88194
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public readonly unsafe T* Ptr;
			public readonly int Length;
	
			// Constructors
			internal unsafe ParallelReader(T* ptr, int length);
		}
	
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public struct ParallelWriter // TypeDefIndex: 88195
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public unsafe UnsafeList<T>* ListData;
	
			// Constructors
			internal unsafe ParallelWriter(UnsafeList<T>* listData);
	
			// Methods
			[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
			public void AddNoResize(T value);
		}
	
		// Constructors
		public unsafe UnsafeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x02647F53 */);
	
		// Methods
		public ref ref T ElementAt(int index);
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(AllocatorManager.AllocatorHandle) })]
		internal static unsafe UnsafeList<T>* Create<U>(int initialCapacity, ref ref U allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x02647F54 */)
			where U : struct, AllocatorManager.IAllocator;
		public static unsafe UnsafeList<T>* Create(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x02647F55 */);
		public static unsafe void Destroy(UnsafeList<T>* listData);
		public void Dispose();
		[NotBurstCompatible]
		public JobHandle Dispose(JobHandle inputDeps);
		[NotBurstCompatible]
		public JobHandle CrossFrameDispose(JobHandle inputDeps, JobQueuePriority priority = JobQueuePriority.NormalJobPriority /* Metadata: 0x02647F56 */);
		public void Clear();
		public void Resize(int length, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x02647F57 */);
		private void Realloc<U>(ref ref U allocator, int newCapacity)
			where U : struct, AllocatorManager.IAllocator;
		private void SetCapacity<U>(ref ref U allocator, int capacity)
			where U : struct, AllocatorManager.IAllocator;
		public void SetCapacity(int capacity);
		public void AddNoResize(T value);
		public unsafe void AddRangeNoResize(void* ptr, int count);
		public void Add([IsReadOnly] in ref T value);
		public unsafe void AddRange(void* ptr, int count);
		public void RemoveAtSwapBack(int index);
		public void RemoveRangeSwapBack(int index, int count);
		public void RemoveAt(int index);
		public void RemoveRange(int index, int count);
		public ParallelReader AsParallelReader();
		public ParallelWriter AsParallelWriter();
		IEnumerator IEnumerable.GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
	}

	internal sealed class UnsafeListTDebugView<T> // TypeDefIndex: 88197
		where T : struct
	{
	}

	[BurstCompatible]
	internal struct UnsafeParallelHashMapData // TypeDefIndex: 88199
	{
		// Fields
		internal unsafe byte* values; // 0x00
		internal unsafe byte* keys; // 0x08
		internal unsafe byte* next; // 0x10
		internal unsafe byte* buckets; // 0x18
		internal int keyCapacity; // 0x20
		internal int bucketCapacityMask; // 0x24
		internal int allocatedIndexLength; // 0x28
		internal unsafe fixed /* 0x00000000-0x00000000 */ int firstFreeTLS[0]; // 0x40
		internal const int IntsPerCacheLine = 16; // Metadata: 0x02647F58
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _firstFreeTLS_e__FixedBuffer // TypeDefIndex: 88198
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		// Methods
		internal static int GetBucketSize(int capacity); // 0x00000001872594A0-0x00000001872594B0
		internal static int GrowCapacity(int capacity); // 0x00000001857FABE0-0x00000001857FABF0
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static unsafe void AllocateHashMap<TKey, TValue>(int length, int bucketLength, AllocatorManager.AllocatorHandle label, out UnsafeParallelHashMapData* outBuf)
			where TKey : struct
			where TValue : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static unsafe void ReallocateHashMap<TKey, TValue>(UnsafeParallelHashMapData* data, int newCapacity, int newBucketCapacity, AllocatorManager.AllocatorHandle label)
			where TKey : struct
			where TValue : struct;
		internal static unsafe void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorManager.AllocatorHandle allocator); // 0x0000000185935990-0x00000001859359E0
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static int CalculateDataSize<TKey, TValue>(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset)
			where TKey : struct
			where TValue : struct;
		internal static unsafe bool IsEmpty(UnsafeParallelHashMapData* data); // 0x0000000185ABBB40-0x0000000185ABBC20
		internal static unsafe int GetCount(UnsafeParallelHashMapData* data); // 0x0000000185C1EB90-0x0000000185C1EC40
		internal static unsafe bool MoveNext(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index); // 0x0000000185848290-0x0000000185848460
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		internal static unsafe void GetKeyArray<TKey>(UnsafeParallelHashMapData* data, NativeArray<TKey> result)
			where TKey : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		internal static unsafe void GetValueArray<TValue>(UnsafeParallelHashMapData* data, NativeArray<TValue> result)
			where TValue : struct;
	}

	[BurstCompatible]
	[NativeContainer]
	internal struct UnsafeParallelHashMapDataDispose // TypeDefIndex: 88200
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer; // 0x00
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x08
	
		// Methods
		public void Dispose(); // 0x000000018D2ADC04-0x000000018D2ADC14
	}

	[BurstCompile]
	internal struct UnsafeParallelHashMapDataDisposeJob : IJob // TypeDefIndex: 88201
	{
		// Fields
		internal UnsafeParallelHashMapDataDispose Data; // 0x00
	
		// Methods
		public void Execute(); // 0x000000018D2ADBFC-0x000000018D2ADC04
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	internal struct UnsafeParallelHashMapBase<TKey, TValue> // TypeDefIndex: 88202
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Methods
		internal static unsafe void Clear(UnsafeParallelHashMapData* data);
		internal static unsafe int AllocEntry(UnsafeParallelHashMapData* data, int threadIndex);
		internal static unsafe void FreeEntry(UnsafeParallelHashMapData* data, int idx, int threadIndex);
		internal static unsafe bool TryAddAtomic(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex);
		internal static unsafe void AddAtomicMulti(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex);
		internal static unsafe bool TryAdd(UnsafeParallelHashMapData* data, TKey key, [IsReadOnly] in ref TValue item, bool isMultiHashMap, AllocatorManager.AllocatorHandle allocation);
		internal static unsafe int Remove(UnsafeParallelHashMapData* data, TKey key, bool isMultiHashMap);
		internal static unsafe void Remove(UnsafeParallelHashMapData* data, NativeParallelMultiHashMapIterator<TKey> it);
		internal static unsafe bool TryGetFirstValueAtomic(UnsafeParallelHashMapData* data, TKey key, out ref TValue item, out NativeParallelMultiHashMapIterator<TKey> it);
		internal static unsafe bool TryGetNextValueAtomic(UnsafeParallelHashMapData* data, out ref TValue item, ref NativeParallelMultiHashMapIterator<TKey> it);
		internal static unsafe bool SetValue(UnsafeParallelHashMapData* data, ref NativeParallelMultiHashMapIterator<TKey> it, ref ref TValue item);
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerDisplay("Key = {Key}, Value = {Value}")]
	public struct KeyValue<TKey, TValue> // TypeDefIndex: 88203
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		internal unsafe UnsafeParallelHashMapData* m_Buffer;
		internal int m_Index;
		internal int m_Next;
	
		// Properties
		public TKey Key { get; }
		public ref TValue Value { get; }
	}

	internal struct UnsafeParallelHashMapDataEnumerator // TypeDefIndex: 88204
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer; // 0x00
		internal int m_Index; // 0x08
		internal int m_BucketIndex; // 0x0C
		internal int m_NextIndex; // 0x10
	
		// Constructors
		internal unsafe UnsafeParallelHashMapDataEnumerator(UnsafeParallelHashMapData* data); // 0x0000000187259480-0x00000001872594A0
	
		// Methods
		internal bool MoveNext(); // 0x0000000185B570C0-0x0000000185B570F0
		internal void Reset(); // 0x0000000187243FD0-0x0000000187243FF0
		internal KeyValue<TKey, TValue> GetCurrent<TKey, TValue>()
			where TKey : struct, IEquatable<TKey>
			where TValue : struct;
		internal TKey GetCurrentKey<TKey>()
			where TKey : struct, IEquatable<TKey>;
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerDisplay("Count = {Count()}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(UnsafeParallelHashMapDebuggerTypeProxy<TKey, TValue>))]
	public struct UnsafeParallelHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 88206
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer;
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public bool IsEmpty { get; }
		public int Capacity { get; set; }
		public TValue this[TKey key] { set {} }
		public bool IsCreated { get; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 88205
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeParallelHashMapData* m_Buffer;
			[NativeSetThreadIndex]
			internal int m_ThreadIndex;
	
			// Properties
			public int Capacity { get; }
	
			// Methods
			public bool TryAdd(TKey key, TValue item);
		}
	
		// Constructors
		public unsafe UnsafeParallelHashMap(int capacity, AllocatorManager.AllocatorHandle allocator);
	
		// Methods
		public int Count();
		public void Clear();
		public bool TryAdd(TKey key, [IsReadOnly] in ref TValue item);
		public bool Remove(TKey key);
		public bool TryGetValue(TKey key, out ref TValue item);
		public bool ContainsKey(TKey key);
		public void Dispose();
		public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator);
		public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator);
		public ParallelWriter AsParallelWriter();
		IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	[BurstCompile]
	internal struct UnsafeParallelHashMapDisposeJob : IJob // TypeDefIndex: 88207
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeParallelHashMapData* Data; // 0x00
		public AllocatorManager.AllocatorHandle Allocator; // 0x08
	
		// Methods
		public void Execute(); // 0x000000018D2ADC04-0x000000018D2ADC14
	}

	internal sealed class UnsafeParallelHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 88208
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(UnsafeHashSetDebuggerTypeProxy<T>))]
	public struct UnsafeParallelHashSet<T> : INativeDisposable, IEnumerable<T> // TypeDefIndex: 88210
		where T : struct, IEquatable<T>
	{
		// Fields
		internal UnsafeParallelHashMap<T, bool> m_Data;
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 88209
		{
			// Fields
			internal UnsafeParallelHashMapDataEnumerator m_Enumerator;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		// Constructors
		public UnsafeParallelHashSet(int capacity, AllocatorManager.AllocatorHandle allocator);
	
		// Methods
		public void Dispose();
		public void Clear();
		public bool Add(T item);
		public bool Remove(T item);
		public bool Contains(T item);
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	internal sealed class UnsafeHashSetDebuggerTypeProxy<T> // TypeDefIndex: 88211
		where T : struct, IEquatable<T>
	{
	}

	public static class HashSetExtensions // TypeDefIndex: 88212
	{
		// Extension methods
		public static void UnionWith<T>(this UnsafeParallelHashSet<T> container, UnsafeParallelHashSet<T> other)
			where T : struct, IEquatable<T>;
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerTypeProxy(typeof(UnsafeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue>))]
	public struct UnsafeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 88214
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer;
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public bool IsEmpty { get; }
		public int Capacity { get; }
		public bool IsCreated { get; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 88213
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeParallelHashMapData* m_Buffer;
			[NativeSetThreadIndex]
			internal int m_ThreadIndex;
	
			// Methods
			public void Add(TKey key, TValue item);
		}
	
		// Constructors
		public unsafe UnsafeParallelMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator);
	
		// Methods
		public int Count();
		public void Clear();
		public void Add(TKey key, TValue item);
		public int Remove(TKey key);
		public void Remove(NativeParallelMultiHashMapIterator<TKey> it);
		public bool TryGetFirstValue(TKey key, out ref TValue item, out NativeParallelMultiHashMapIterator<TKey> it);
		public bool TryGetNextValue(out ref TValue item, ref NativeParallelMultiHashMapIterator<TKey> it);
		public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it);
		public void Dispose();
		public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator);
		public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator);
		public ParallelWriter AsParallelWriter();
		IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	internal sealed class UnsafeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 88215
		where TKey : struct, IEquatable<TKey>, IComparable<TKey>
		where TValue : struct
	{
	}

	[BurstCompatible]
	internal struct UnsafeStreamBlock // TypeDefIndex: 88217
	{
		// Fields
		internal unsafe UnsafeStreamBlock* Next; // 0x00
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte Data[0]; // 0x08
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _Data_e__FixedBuffer // TypeDefIndex: 88216
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	[BurstCompatible]
	internal struct UnsafeStreamRange // TypeDefIndex: 88218
	{
		// Fields
		internal unsafe UnsafeStreamBlock* Block; // 0x00
		internal int OffsetInFirstBlock; // 0x08
		internal int ElementCount; // 0x0C
		internal int LastOffset; // 0x10
		internal int NumberOfBlocks; // 0x14
	}

	[BurstCompatible]
	internal struct UnsafeStreamBlockData // TypeDefIndex: 88219
	{
		// Fields
		internal AllocatorManager.AllocatorHandle Allocator; // 0x00
		internal unsafe UnsafeStreamBlock** Blocks; // 0x08
		internal int BlockCount; // 0x10
		internal unsafe UnsafeStreamBlock* Free; // 0x18
		internal unsafe UnsafeStreamRange* Ranges; // 0x20
		internal int RangeCount; // 0x28
	
		// Methods
		internal unsafe UnsafeStreamBlock* Allocate(UnsafeStreamBlock* oldBlock, int threadIndex); // 0x0000000185DEB0D0-0x0000000185DEB140
	}

	[BurstCompatible]
	public struct UnsafeStream : INativeDisposable // TypeDefIndex: 88225
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeStreamBlockData* m_Block; // 0x00
		internal AllocatorManager.AllocatorHandle m_Allocator; // 0x08
	
		// Properties
		public bool IsCreated { get; } // 0x00000001853AE700-0x00000001853AE710 
	
		// Nested types
		[BurstCompile]
		private struct DisposeJob : IJob // TypeDefIndex: 88220
		{
			// Fields
			public UnsafeStream Container; // 0x00
	
			// Methods
			public void Execute(); // 0x000000018D2A9744-0x000000018D2A974C
		}
	
		[BurstCompile]
		private struct ConstructJobList : IJob // TypeDefIndex: 88221
		{
			// Fields
			public UnsafeStream Container; // 0x00
			[NativeDisableUnsafePtrRestriction]
			[Unity.Collections.ReadOnly]
			public unsafe UntypedUnsafeList* List; // 0x10
	
			// Methods
			public void Execute(); // 0x000000018D2A9710-0x000000018D2A9734
		}
	
		[BurstCompile]
		private struct ConstructJob : IJob // TypeDefIndex: 88222
		{
			// Fields
			public UnsafeStream Container; // 0x00
			[Unity.Collections.ReadOnly]
			public NativeArray<int> Length; // 0x10
	
			// Methods
			public void Execute(); // 0x000000018D2A9734-0x000000018D2A9744
		}
	
		[BurstCompatible]
		public struct Writer // TypeDefIndex: 88223
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeStreamBlockData* m_BlockStream; // 0x00
			[NativeDisableUnsafePtrRestriction]
			private unsafe UnsafeStreamBlock* m_CurrentBlock; // 0x08
			[NativeDisableUnsafePtrRestriction]
			private unsafe byte* m_CurrentPtr; // 0x10
			[NativeDisableUnsafePtrRestriction]
			private unsafe byte* m_CurrentBlockEnd; // 0x18
			internal int m_ForeachIndex; // 0x20
			private int m_ElementCount; // 0x24
			[NativeDisableUnsafePtrRestriction]
			private unsafe UnsafeStreamBlock* m_FirstBlock; // 0x28
			private int m_FirstOffset; // 0x30
			private int m_NumberOfBlocks; // 0x34
			[NativeSetThreadIndex]
			private int m_ThreadIndex; // 0x38
	
			// Constructors
			internal unsafe Writer(ref UnsafeStream stream); // 0x00000001872594F0-0x0000000187259520
	
			// Methods
			public void BeginForEachIndex(int foreachIndex); // 0x00000001872594D0-0x00000001872594F0
			public void EndForEachIndex(); // 0x0000000185C69E20-0x0000000185C69F20
			public unsafe byte* Allocate(int size); // 0x0000000185DEAFF0-0x0000000185DEB0D0
		}
	
		[BurstCompatible]
		public struct Reader // TypeDefIndex: 88224
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeStreamBlockData* m_BlockStream; // 0x00
			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeStreamBlock* m_CurrentBlock; // 0x08
			[NativeDisableUnsafePtrRestriction]
			internal unsafe byte* m_CurrentPtr; // 0x10
			[NativeDisableUnsafePtrRestriction]
			internal unsafe byte* m_CurrentBlockEnd; // 0x18
			internal int m_RemainingItemCount; // 0x20
			internal int m_LastBlockSize; // 0x24
	
			// Constructors
			internal unsafe Reader(ref UnsafeStream stream); // 0x0000000187259440-0x0000000187259460
	
			// Methods
			public int BeginForEachIndex(int foreachIndex); // 0x0000000186079790-0x0000000186079860
			public void EndForEachIndex(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Methods
		internal static void AllocateBlock(out UnsafeStream stream, AllocatorManager.AllocatorHandle allocator); // 0x00000001851678F0-0x0000000185167980
		internal void AllocateForEach(int forEachCount); // 0x0000000185167860-0x00000001851678F0
		public Reader AsReader(); // 0x00000001872594B0-0x00000001872594D0
		public Writer AsWriter(); // 0x0000000185FF0770-0x0000000185FF07A0
		private void Deallocate(); // 0x0000000185A76220-0x0000000185A76500
		public void Dispose(); // 0x000000018D2A9744-0x000000018D2A974C
		[NotBurstCompatible]
		public JobHandle Dispose(JobHandle inputDeps); // 0x0000000186077460-0x0000000186077560
	}

	[BurstCompatible]
	public static class UnsafeUtilityExtensions // TypeDefIndex: 88226
	{
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* AddressOf<T>([IsReadOnly] in ref T value)
			where T : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static ref ref T AsRef<T>([IsReadOnly] in ref T value)
			where T : struct;
		public static IntPtr Malloc(long size, int alignment, Unity.Collections.Allocator allocator); // 0x00000001869A6780-0x00000001869A6790
	}
}

namespace Unity.Collections.NotBurstCompatible
{
	public static class Extensions // TypeDefIndex: 88188
	{
		// Extension methods
		[NotBurstCompatible]
		public static T[] ToArrayNBC<T>(this NativeList<T> list)
			where T : struct;
	}
}

namespace Unity.Jobs
{
	public class EarlyInitHelpers // TypeDefIndex: 88039
	{
		// Methods
		public static void JobReflectionDataCreationFailed(Exception ex, System.Type jobType); // 0x000000018D2A974C-0x000000018D2A97C4
	}

	[JobProducerType(typeof(IJobBurstSchedulableExtensions.JobBurstSchedulableProducer<T>))]
	public interface IJobBurstSchedulable // TypeDefIndex: 88040
	{
		// Methods
		void Execute();
	}

	public static class IJobBurstSchedulableExtensions // TypeDefIndex: 88043
	{
		// Nested types
		internal struct JobBurstSchedulableProducer<T> // TypeDefIndex: 88042
			where T : struct, IJobBurstSchedulable
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 88041; 0x00000000-0x00000000
	
			// Constructors
			static JobBurstSchedulableProducer();
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			internal static void Initialize();
			public static void Execute(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);
		}
	}

	[JobProducerType(typeof(IJobParallelForBatchExtensions.JobParallelForBatchProducer<T>))]
	public interface IJobParallelForBatch // TypeDefIndex: 88044
	{
		// Methods
		void Execute(int startIndex, int count);
	}

	public static class IJobParallelForBatchExtensions // TypeDefIndex: 88047
	{
		// Nested types
		internal struct JobParallelForBatchProducer<T> // TypeDefIndex: 88046
			where T : struct, IJobParallelForBatch
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 88045; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForBatchProducer();
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			internal static void Initialize();
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);
		}
	
		// Methods
		public static void EarlyJobInit<T>()
			where T : struct, IJobParallelForBatch;
	
		// Extension methods
		public static JobHandle ScheduleBatch<T>(this T jobData, int arrayLength, int minIndicesPerJobCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForBatch;
	}

	[JobProducerType(typeof(IJobParallelForExtensionsBurstSchedulable.JobParallelForBurstSchedulableProducer<T>))]
	public interface IJobParallelForBurstSchedulable // TypeDefIndex: 88048
	{
		// Methods
		void Execute(int index);
	}

	public static class IJobParallelForExtensionsBurstSchedulable // TypeDefIndex: 88051
	{
		// Nested types
		internal struct JobParallelForBurstSchedulableProducer<T> // TypeDefIndex: 88050
			where T : struct, IJobParallelForBurstSchedulable
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 88049; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForBurstSchedulableProducer();
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			internal static void Initialize();
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);
		}
	}

	[JobProducerType(typeof(IJobParallelForDeferExtensions.JobParallelForDeferProducer<T>))]
	public interface IJobParallelForDefer // TypeDefIndex: 88052
	{
		// Methods
		void Execute(int index);
	}

	public static class IJobParallelForDeferExtensions // TypeDefIndex: 88055
	{
		// Nested types
		internal struct JobParallelForDeferProducer<T> // TypeDefIndex: 88054
			where T : struct, IJobParallelForDefer
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			public delegate void ExecuteJobFunction(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 88053; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForDeferProducer();
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			internal static void Initialize();
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);
		}
	
		// Methods
		public static void EarlyJobInit<T>()
			where T : struct, IJobParallelForDefer;
		private static unsafe JobHandle ScheduleInternal<T>(ref ref T jobData, int innerloopBatchCount, void* forEachListPtr, void* atomicSafetyHandlePtr, JobHandle dependsOn)
			where T : struct, IJobParallelForDefer;
	
		// Extension methods
		public static JobHandle Schedule<T, U>(this T jobData, NativeList<U> list, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer
			where U : struct;
		public static unsafe JobHandle Schedule<T>(this T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer;
		public static unsafe JobHandle ScheduleByRef<T>(this ref ref T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer;
	}

	[JobProducerType(typeof(JobParallelIndexListExtensions.JobParallelForFilterProducer<T>))]
	public interface IJobParallelForFilter // TypeDefIndex: 88056
	{
		// Methods
		bool Execute(int index);
	}

	public static class JobParallelIndexListExtensions // TypeDefIndex: 88060
	{
		// Nested types
		internal struct JobParallelForFilterProducer<T> // TypeDefIndex: 88059
			where T : struct, IJobParallelForFilter
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			public struct JobWrapper // TypeDefIndex: 88057
			{
				// Fields
				[NativeDisableParallelForRestriction]
				public NativeList<int> outputIndices;
				public int appendCount;
				public T JobData;
			}
	
			public delegate void ExecuteJobFunction(ref JobWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 88058; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForFilterProducer();
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			public static void Initialize();
			public static void Execute(ref JobWrapper jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);
			public static void ExecuteAppend(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData);
			public static void ExecuteFilter(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData);
		}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class DOTSCompilerGeneratedAttribute : Attribute // TypeDefIndex: 88061
	{
		// Constructors
		public DOTSCompilerGeneratedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
