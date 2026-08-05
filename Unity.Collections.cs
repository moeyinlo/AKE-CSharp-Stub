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

// Image 54: Unity.Collections.dll - Assembly: Unity.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60687-60877
[assembly: BurstCompiler.StaticTypeReinit(typeof(xxHash3.Hash128Long_000008FE_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AllocatorManager.StackAllocator.Try_000000A0_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AllocatorManager.SlabAllocator.Try_000000AE_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(RewindableAllocator.Try_000008B6_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(xxHash3.Hash64Long_000008F7_BurstDirectCall))]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.Burst.Tests")]
[assembly: InternalsVisibleTo("Unity.Collections.BurstCompatibilityTestCodeGen")]
[assembly: InternalsVisibleTo("Unity.Collections.CodeGen")]
[assembly: InternalsVisibleTo("Unity.Collections.Tests")]
[assembly: InternalsVisibleTo("Unity.Entities")]
[assembly: InternalsVisibleTo("Unity.Entities.CodeGen")]
[assembly: InternalsVisibleTo("Unity.Entities.Tests")]
[assembly: InternalsVisibleTo("Unity.Entities.Editor")]
[assembly: InternalsVisibleTo("Unity.Entities.Editor.Tests")]
[assembly: InternalsVisibleTo("Unity.Rendering.Hybrid")]
[assembly: InternalsVisibleTo("Unity.Runtime")]
[assembly: InternalsVisibleTo("Unity.Runtime.Tests")]
[assembly: InternalsVisibleTo("Unity.Runtime.IO.Tests")]
[assembly: InternalsVisibleTo("Unity.Runtime.UnityInstance")]
[assembly: InternalsVisibleTo("Unity.Tiny.Animation")]
[assembly: InternalsVisibleTo("Unity.Tiny.Core.Tests")]
[assembly: InternalsVisibleTo("Unity.Tiny.GameSave")]
[assembly: InternalsVisibleTo("Unity.Tiny.GameSave.Tests")]
[assembly: InternalsVisibleTo("Unity.Tiny.Rendering.Native")]
[assembly: InternalsVisibleTo("Unity.Scenes")]
[assembly: InternalsVisibleTo("Unity.Scenes.Editor")]
[assembly: InternalsVisibleTo("Samples.GridPath.Tests")]
[assembly: InternalsVisibleTo("Unity.Entities.PerformanceTests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 60875
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_192 _2CF2F88BF9B71283059B6DF53E5BCDE20ADBFD9E8D6CE2C1AB106262BB283BED; // 0x00 // Static value (base64): uP5sOSOkS758AYEs9yGtHN7UbemDkJfbckCkpLezZx/LeeZOzMDleIJa0H3M/3IhuAhGdPdDJI7gNZDmgTomTDwoUruRwwDLiNBlixtTLqNxZEiXog35TjgZ70ap3qzYqPp2P+OcND/53LvHxwtPHYpR4EvNtFkxyJ9+ydl4c2TqxayDNNPrw8WBoP/6E2PrFw3dUbfw2knTFlUmKdRonisWvlh9R6H8j/i40XrQMc5FyzqPlRYEKK/X+8q7S0B+ - Metadata: 0x0234EDD4

	// Nested types
	private struct __StaticArrayInitTypeSize_192 // TypeDefIndex: 60874
	{
	}
}

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__486165037 // TypeDefIndex: 60876
{
	// Methods
	public static void CreateJobReflectionData(); // 0x0000000182EC09F0-0x0000000182EC2B20
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit(); // 0x0000000182EC2B20-0x0000000182EC6590
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 60877
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize(); // 0x0000000184CAF720-0x0000000184CAF7D0
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60688
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 60689
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Unity.Collections
{
	public static class AllocatorManager // TypeDefIndex: 60732
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
		public delegate int TryFunction(IntPtr allocatorState, ref Block block); // TypeDefIndex: 60713; 0x00000001815802E0-0x00000001815802F0
	
		public struct AllocatorHandle : IAllocator // TypeDefIndex: 60714
		{
			// Fields
			public ushort Index; // 0x00
			public ushort Version; // 0x02
	
			// Properties
			internal ref TableEntry TableEntry { get; } // 0x000000018B15FC48-0x000000018B15FCC4 
			public int Value { get; } // 0x0000000184D87110-0x0000000184D87120 
			public AllocatorHandle Handle { get; } // 0x0000000182B77620-0x0000000182B77630 
			public Unity.Collections.Allocator ToAllocator { get; } // 0x0000000184DAB3E0-0x0000000184DAB3F0 
	
			// Methods
			internal void Rewind(); // 0x00000001841E1670-0x00000001841E1680
			public static implicit operator AllocatorHandle(Unity.Collections.Allocator a); // 0x0000000184DAB3F0-0x0000000184DAB410
			public int Try(ref Block block); // 0x0000000183347A00-0x0000000183347A60
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public struct Range : IDisposable // TypeDefIndex: 60715
		{
			// Fields
			public IntPtr Pointer; // 0x00
			public int Items; // 0x08
			public AllocatorHandle Allocator; // 0x0C
	
			// Methods
			public void Dispose(); // 0x000000018B163650-0x000000018B163688
		}
	
		public struct Block : IDisposable // TypeDefIndex: 60716
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
			public long Bytes { get; } // 0x0000000184DAB4F0-0x0000000184DAB500 
			public long AllocatedBytes { get; } // 0x0000000184DAB4E0-0x0000000184DAB4F0 
			public int Alignment { get; set; } // 0x0000000184DAB4D0-0x0000000184DAB4E0 0x0000000183347C90-0x0000000183347CE0
	
			// Methods
			public void Dispose(); // 0x000000018B15FF9C-0x000000018B15FFA4
			public int TryFree(); // 0x000000018B15FFA4-0x000000018B15FFF4
		}
	
		public interface IAllocator : IDisposable // TypeDefIndex: 60717
		{
			// Properties
			AllocatorHandle Handle { get; }
	
			// Methods
			int Try(ref Block block);
		}
	
		[BurstCompile(CompileSynchronously = true)]
		internal struct StackAllocator : IAllocator // TypeDefIndex: 60720
		{
			// Fields
			internal AllocatorHandle m_handle; // 0x00
			internal Block m_storage; // 0x08
			internal long m_top; // 0x28
	
			// Properties
			public AllocatorHandle Handle { get; } // 0x0000000182B77620-0x0000000182B77630 
	
			// Nested types
			public delegate int Try_000000A0_PostfixBurstDelegate(IntPtr allocatorState, ref Block block); // TypeDefIndex: 60718; 0x00000001815802E0-0x00000001815802F0
	
			internal static class Try_000000A0_BurstDirectCall // TypeDefIndex: 60719
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Try_000000A0_BurstDirectCall(); // 0x0000000183FAEA50-0x0000000183FAEA60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00081eb6); // 0x000000018B163EFC-0x000000018B164000
				private static IntPtr GetFunctionPointer(); // 0x000000018B164000-0x000000018B164054
				public static void Constructor(); // 0x0000000183FB0750-0x0000000183FB07E0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static int Invoke(IntPtr allocatorState, ref Block block); // 0x000000018B164054-0x000000018B1640E0
			}
	
			// Methods
			public int Try(ref Block block); // 0x000000018B163D48-0x000000018B163DD4
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try(IntPtr allocatorState, ref Block block); // 0x000000018B163CEC-0x000000018B163D48
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try_BurstManaged(IntPtr allocatorState, ref Block block); // 0x000000018B163CE4-0x000000018B163CEC
		}
	
		[BurstCompile(CompileSynchronously = true)]
		internal struct SlabAllocator : IAllocator // TypeDefIndex: 60723
		{
			// Fields
			internal AllocatorHandle m_handle; // 0x00
			internal Block Storage; // 0x08
			internal int Log2SlabSizeInBytes; // 0x28
			internal FixedList4096Bytes<int> Occupied; // 0x2C
			internal long budgetInBytes; // 0x1030
			internal long allocatedBytes; // 0x1038
	
			// Properties
			public AllocatorHandle Handle { get; } // 0x0000000182B77620-0x0000000182B77630 
			internal int SlabSizeInBytes { get; } // 0x0000000184DAB540-0x0000000184DAB550 
	
			// Nested types
			public delegate int Try_000000AE_PostfixBurstDelegate(IntPtr allocatorState, ref Block block); // TypeDefIndex: 60721; 0x00000001815802E0-0x00000001815802F0
	
			internal static class Try_000000AE_BurstDirectCall // TypeDefIndex: 60722
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Try_000000AE_BurstDirectCall(); // 0x0000000183FAEA60-0x0000000183FAEA70
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00081ec2); // 0x000000018B1640E0-0x000000018B1641E4
				private static IntPtr GetFunctionPointer(); // 0x000000018B1641E4-0x000000018B164238
				public static void Constructor(); // 0x0000000183FB07E0-0x0000000183FB0870
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static int Invoke(IntPtr allocatorState, ref Block block); // 0x000000018B164238-0x000000018B1642C4
			}
	
			// Methods
			public int Try(ref Block block); // 0x000000018B163AC8-0x000000018B163CB4
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try(IntPtr allocatorState, ref Block block); // 0x000000018B163A6C-0x000000018B163AC8
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try_BurstManaged(IntPtr allocatorState, ref Block block); // 0x000000018B163A64-0x000000018B163A6C
		}
	
		internal struct TableEntry // TypeDefIndex: 60724
		{
			// Fields
			internal IntPtr function; // 0x00
			internal IntPtr state; // 0x08
		}
	
		internal struct Array16<T> // TypeDefIndex: 60725
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
	
		internal struct Array256<T> // TypeDefIndex: 60726
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
	
		internal struct Array4096<T> // TypeDefIndex: 60727
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
	
		internal struct Array32768<T> : IIndexable<T> // TypeDefIndex: 60728
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
	
		internal sealed class SharedStatics // TypeDefIndex: 60730
		{
			// Nested types
			internal sealed class TableEntry // TypeDefIndex: 60729
			{
				// Fields
				internal static readonly SharedStatic<Array32768<AllocatorManager.TableEntry>> Ref; // 0x00
	
				// Constructors
				static TableEntry(); // 0x000000018B163DD4-0x000000018B163E34
			}
		}
	
		internal static class Managed // TypeDefIndex: 60731
		{
			// Fields
			internal static TryFunction[] TryFunctionDelegates; // 0x00
	
			// Constructors
			static Managed(); // 0x000000018B1632EC-0x000000018B163354
		}
	
		// Constructors
		static AllocatorManager(); // 0x0000000184CA1340-0x0000000184CA1430
	
		// Methods
		public static unsafe void* Allocate(AllocatorHandle handle, int itemSizeInBytes, int alignmentInBytes, int items = 1 /* Metadata: 0x0234EDAA */); // 0x0000000183345120-0x0000000183345290
		public static unsafe T* Allocate<T>(AllocatorHandle handle, int items = 1 /* Metadata: 0x0234EDAB */)
			where T : struct;
		public static unsafe void Free(AllocatorHandle handle, void* pointer); // 0x000000018B15FCC4-0x000000018B15FD24
		public static unsafe void Free<T>(AllocatorHandle handle, T* pointer, int items = 1 /* Metadata: 0x0234EDAC */)
			where T : struct;
		[BurstDiscard]
		private static void CheckDelegate(ref bool useDelegate); // 0x0000000184D910F0-0x0000000184D91100
		private static bool UseDelegate(); // 0x000000018B15FD24-0x000000018B15FD60
		private static int allocate_block(ref Block block); // 0x000000018B15FD60-0x000000018B15FDF0
		[BurstDiscard]
		private static void forward_mono_allocate_block(ref Block block, ref int error); // 0x000000018B15FDF0-0x000000018B15FEF8
		internal static Unity.Collections.Allocator LegacyOf(AllocatorHandle handle); // 0x0000000183347C00-0x0000000183347C10
		private static int TryLegacy(ref Block block); // 0x0000000183347AA0-0x0000000183347C00
		public static int Try(ref Block block); // 0x0000000183347A60-0x0000000183347AA0
		internal static bool IsCustomAllocator(AllocatorHandle allocator); // 0x0000000183347DF0-0x0000000183347E00
		public static void Initialize_StackAllocator_Try_000000A0_BurstDirectCall(); // 0x0000000184CAF810-0x0000000184CAF850
		public static void Initialize_SlabAllocator_Try_000000AE_BurstDirectCall(); // 0x0000000184CAF7D0-0x0000000184CAF810
	
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

	internal class CreatePropertyAttribute : Attribute // TypeDefIndex: 60733
	{
		// Constructors
		public CreatePropertyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[BurstCompatible]
	internal struct Bitwise // TypeDefIndex: 60734
	{
		// Methods
		internal static int FromBool(bool value); // 0x00000001838C4530-0x00000001838C4540
		internal static uint ExtractBits(uint input, int pos, uint mask); // 0x0000000184DAB470-0x0000000184DAB480
		internal static uint ReplaceBits(uint input, int pos, uint mask, uint value); // 0x0000000184DAB4B0-0x0000000184DAB4D0
		internal static uint SetBits(uint input, int pos, uint mask, bool value); // 0x00000001838C44E0-0x00000001838C4500
		internal static ulong ExtractBits(ulong input, int pos, ulong mask); // 0x0000000184DAB460-0x0000000184DAB470
		internal static ulong ReplaceBits(ulong input, int pos, ulong mask, ulong value); // 0x0000000184DAB480-0x0000000184DAB4B0
		internal static ulong SetBits(ulong input, int pos, ulong mask, bool value); // 0x00000001838C4500-0x00000001838C4530
	}

	[BurstCompatible]
	[DebuggerTypeProxy(typeof(BitField32DebugView))]
	public struct BitField32 // TypeDefIndex: 60735
	{
		// Fields
		public uint Value; // 0x00
	
		// Methods
		public void SetBits(int pos, bool value); // 0x0000000185390AE8-0x0000000185390B14
		public uint GetBits(int pos, int numBits = 1 /* Metadata: 0x0234EDAD */); // 0x0000000184DAB410-0x0000000184DAB430
		public bool IsSet(int pos); // 0x0000000182F95910-0x0000000182F95920
	}

	internal sealed class BitField32DebugView // TypeDefIndex: 60736
	{
	}

	[BurstCompatible]
	[DebuggerTypeProxy(typeof(BitField64DebugView))]
	public struct BitField64 // TypeDefIndex: 60737
	{
		// Fields
		public ulong Value; // 0x00
	
		// Methods
		public void SetBits(int pos, bool value); // 0x0000000185390AB4-0x0000000185390AE8
		public ulong GetBits(int pos, int numBits = 1 /* Metadata: 0x0234EDAE */); // 0x0000000184DAB430-0x0000000184DAB460
		public bool IsSet(int pos); // 0x00000001837EBDF0-0x00000001837EBE10
		public bool TestAny(int pos, int numBits = 1 /* Metadata: 0x0234EDAF */); // 0x00000001837EDE40-0x00000001837EDE70
	}

	internal sealed class BitField64DebugView // TypeDefIndex: 60738
	{
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
	public class BurstCompatibleAttribute : Attribute // TypeDefIndex: 60739
	{
		// Fields
		[CompilerGenerated]
		private System.Type[] _GenericTypeArguments_k__BackingField; // 0x10
		public string RequiredUnityDefine; // 0x18
	
		// Properties
		public System.Type[] GenericTypeArguments { [CompilerGenerated] set; } // 0x00000001853908C0-0x00000001853908D0
	
		// Constructors
		public BurstCompatibleAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	public class NotBurstCompatibleAttribute : Attribute // TypeDefIndex: 60740
	{
		// Constructors
		public NotBurstCompatibleAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface INativeDisposable : IDisposable // TypeDefIndex: 60741
	{
	}

	[BurstCompatible]
	public static class CollectionHelper // TypeDefIndex: 60742
	{
		// Methods
		public static int Log2Floor(int value); // 0x0000000185F0E0A0-0x0000000185F0E4F0
		public static int Align(int size, int alignmentPowerOfTwo); // 0x00000001837F5AD0-0x00000001837F5AF0
		public static unsafe uint Hash(void* ptr, int bytes); // 0x00000001843CED80-0x00000001843CEDB0
		internal static bool ShouldDeallocate(AllocatorManager.AllocatorHandle allocator); // 0x0000000183CCB240-0x0000000183CCB260
		internal static int AssumePositive(int value); // 0x0000000184D88BE0-0x0000000184D88BF0
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static NativeArray<T> CreateNativeArray<T>(int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x0234EDB0 */)
			where T : struct;
		[NotBurstCompatible]
		public static NativeArray<T> CreateNativeArray<T>(T[] array, AllocatorManager.AllocatorHandle allocator)
			where T : struct;
	}

	[BurstCompatible]
	internal struct FixedList // TypeDefIndex: 60743
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
	public struct FixedList32Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 60744
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
	public static class FixedList32BytesExtensions // TypeDefIndex: 60745
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList32Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList32Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
	}

	internal sealed class FixedList32BytesDebugView<T> // TypeDefIndex: 60746
		where T : struct
	{
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList64BytesDebugView<T>))]
	public struct FixedList64Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 60747
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
	public static class FixedList64BytesExtensions // TypeDefIndex: 60748
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList64Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList64Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
	}

	internal sealed class FixedList64BytesDebugView<T> // TypeDefIndex: 60749
		where T : struct
	{
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList128BytesDebugView<T>))]
	public struct FixedList128Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 60750
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
	public static class FixedList128BytesExtensions // TypeDefIndex: 60751
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

	internal sealed class FixedList128BytesDebugView<T> // TypeDefIndex: 60752
		where T : struct
	{
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList512BytesDebugView<T>))]
	public struct FixedList512Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 60754
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 60753
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
	public static class FixedList512BytesExtensions // TypeDefIndex: 60755
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

	internal sealed class FixedList512BytesDebugView<T> // TypeDefIndex: 60756
		where T : struct
	{
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList4096BytesDebugView<T>))]
	public struct FixedList4096Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 60757
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
	public static class FixedList4096BytesExtensions // TypeDefIndex: 60758
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList4096Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList4096Bytes<T> list, U value)
			where T : struct, IEquatable<U>;
	}

	internal sealed class FixedList4096BytesDebugView<T> // TypeDefIndex: 60759
		where T : struct
	{
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes16 // TypeDefIndex: 60760
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
	public struct FixedBytes30 // TypeDefIndex: 60761
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
	public struct FixedString32Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 60762
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 29; // Metadata: 0x0234EDB2
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes30 bytes; // 0x02
	
		// Properties
		[CreateProperty]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[NotBurstCompatible]
		public string Value { get; } // 0x0000000185395BE4-0x0000000185395BF0 
		public int Length { get; set; } // 0x0000000184D87110-0x0000000184D87120 0x0000000184DAB510-0x0000000184DAB520
		public bool IsEmpty { get; } // 0x000000018B160F5C-0x000000018B160F64 
	
		// Constructors
		[NotBurstCompatible]
		public FixedString32Bytes(string source); // 0x00000001838759B0-0x00000001838759D0
	
		// Methods
		public unsafe byte* GetUnsafePtr(); // 0x0000000184DAB500-0x0000000184DAB510
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0234EDB1 */); // 0x000000018B160EF0-0x000000018B160F5C
		[NotBurstCompatible]
		public int CompareTo(string other); // 0x000000018B160A44-0x000000018B160A7C
		[NotBurstCompatible]
		public bool Equals(string other); // 0x000000018B160B60-0x000000018B160BE4
		[NotBurstCompatible]
		internal int Initialize(string source); // 0x00000001838759D0-0x0000000183875B10
		public int CompareTo(FixedString32Bytes other); // 0x000000018B160AC8-0x000000018B160B14
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString32Bytes b); // 0x000000018B160FF0-0x000000018B161070
		public bool Equals(FixedString32Bytes other); // 0x000000018B160C0C-0x000000018B160C20
		public int CompareTo(FixedString64Bytes other); // 0x000000018B160B14-0x000000018B160B60
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString64Bytes b); // 0x000000018B160F64-0x000000018B160FF0
		public bool Equals(FixedString64Bytes other); // 0x000000018B160BF8-0x000000018B160C0C
		public int CompareTo(FixedString128Bytes other); // 0x000000018B1609F8-0x000000018B160A44
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString128Bytes b); // 0x000000018B1610FC-0x000000018B161188
		public bool Equals(FixedString128Bytes other); // 0x000000018B160C20-0x000000018B160C34
		public int CompareTo(FixedString512Bytes other); // 0x000000018B1609AC-0x000000018B1609F8
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString512Bytes b); // 0x000000018B161070-0x000000018B1610FC
		public bool Equals(FixedString512Bytes other); // 0x000000018B160BE4-0x000000018B160BF8
		public int CompareTo(FixedString4096Bytes other); // 0x000000018B160A7C-0x000000018B160AC8
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString4096Bytes b); // 0x000000018B161188-0x000000018B161214
		public bool Equals(FixedString4096Bytes other); // 0x000000018B160EDC-0x000000018B160EF0
		[NotBurstCompatible]
		public static implicit operator FixedString32Bytes(string b); // 0x0000000183875980-0x00000001838759B0
		[NotBurstCompatible]
		public override string ToString(); // 0x0000000185395BE4-0x0000000185395BF0
		public override int GetHashCode(); // 0x00000001834D7A80-0x00000001834D7AC0
		[NotBurstCompatible]
		public override bool Equals(object obj); // 0x000000018B160C34-0x000000018B160EDC
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes62 // TypeDefIndex: 60763
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
	public struct FixedString64Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 60764
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 61; // Metadata: 0x0234EDB5
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes62 bytes; // 0x02
	
		// Properties
		[CreateProperty]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[NotBurstCompatible]
		public string Value { get; } // 0x00000001853945DC-0x00000001853945E8 
		public int Length { get; set; } // 0x0000000184D87110-0x0000000184D87120 0x0000000184DAB510-0x0000000184DAB520
	
		// Constructors
		[NotBurstCompatible]
		public FixedString64Bytes(string source); // 0x000000018B162A28-0x000000018B162A44
	
		// Methods
		public unsafe byte* GetUnsafePtr(); // 0x0000000184DAB500-0x0000000184DAB510
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0234EDB4 */); // 0x000000018B1629BC-0x000000018B162A28
		[NotBurstCompatible]
		public int CompareTo(string other); // 0x000000018B1624A8-0x000000018B1624E0
		[NotBurstCompatible]
		public bool Equals(string other); // 0x000000018B16285C-0x000000018B1628E0
		[NotBurstCompatible]
		internal int Initialize(string source); // 0x000000018B162944-0x000000018B1629BC
		public int CompareTo(FixedString32Bytes other); // 0x000000018B1624E0-0x000000018B16252C
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString32Bytes b); // 0x000000018B162B5C-0x000000018B162BE8
		public bool Equals(FixedString32Bytes other); // 0x000000018B162820-0x000000018B162834
		public int CompareTo(FixedString64Bytes other); // 0x000000018B16252C-0x000000018B162578
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString64Bytes b); // 0x000000018B162BE8-0x000000018B162C68
		public bool Equals(FixedString64Bytes other); // 0x000000018B162848-0x000000018B16285C
		public int CompareTo(FixedString128Bytes other); // 0x000000018B162410-0x000000018B16245C
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString128Bytes b); // 0x000000018B162AD0-0x000000018B162B5C
		public bool Equals(FixedString128Bytes other); // 0x000000018B162834-0x000000018B162848
		public int CompareTo(FixedString512Bytes other); // 0x000000018B1623C4-0x000000018B162410
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString512Bytes b); // 0x000000018B162A44-0x000000018B162AD0
		public bool Equals(FixedString512Bytes other); // 0x000000018B1628E0-0x000000018B1628F4
		public int CompareTo(FixedString4096Bytes other); // 0x000000018B16245C-0x000000018B1624A8
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString4096Bytes b); // 0x000000018B162C68-0x000000018B162CF4
		public bool Equals(FixedString4096Bytes other); // 0x000000018B1628F4-0x000000018B162908
		[NotBurstCompatible]
		public static implicit operator FixedString64Bytes(string b); // 0x000000018B162CF4-0x000000018B162D20
		[NotBurstCompatible]
		public override string ToString(); // 0x00000001853945DC-0x00000001853945E8
		public override int GetHashCode(); // 0x000000018B162908-0x000000018B162944
		[NotBurstCompatible]
		public override bool Equals(object obj); // 0x000000018B162578-0x000000018B162820
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes126 // TypeDefIndex: 60765
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
	public struct FixedString128Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 60766
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 125; // Metadata: 0x0234EDB8
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes126 bytes; // 0x02
	
		// Properties
		public int Length { get; set; } // 0x0000000184D87110-0x0000000184D87120 0x0000000184DAB510-0x0000000184DAB520
	
		// Constructors
		[NotBurstCompatible]
		public FixedString128Bytes(string source); // 0x0000000183875060-0x0000000183875090
	
		// Methods
		public unsafe byte* GetUnsafePtr(); // 0x0000000184DAB500-0x0000000184DAB510
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0234EDB7 */); // 0x000000018B160690-0x000000018B1606FC
		[NotBurstCompatible]
		public int CompareTo(string other); // 0x000000018B1601BC-0x000000018B1601F0
		[NotBurstCompatible]
		public bool Equals(string other); // 0x000000018B1602D8-0x000000018B16035C
		[NotBurstCompatible]
		internal int Initialize(string source); // 0x0000000183875090-0x0000000183875110
		public int CompareTo(FixedString32Bytes other); // 0x000000018B16023C-0x000000018B160288
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString32Bytes b); // 0x000000018B160788-0x000000018B160814
		public bool Equals(FixedString32Bytes other); // 0x000000018B1602C4-0x000000018B1602D8
		public int CompareTo(FixedString64Bytes other); // 0x000000018B1601F0-0x000000018B16023C
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString64Bytes b); // 0x000000018B160894-0x000000018B160920
		public bool Equals(FixedString64Bytes other); // 0x000000018B16035C-0x000000018B160370
		public int CompareTo(FixedString128Bytes other); // 0x000000018B160124-0x000000018B160170
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString128Bytes b); // 0x000000018B160814-0x000000018B160894
		public bool Equals(FixedString128Bytes other); // 0x000000018B1602B0-0x000000018B1602C4
		public int CompareTo(FixedString512Bytes other); // 0x000000018B160170-0x000000018B1601BC
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString512Bytes b); // 0x000000018B1606FC-0x000000018B160788
		public bool Equals(FixedString512Bytes other); // 0x000000018B160288-0x000000018B16029C
		public int CompareTo(FixedString4096Bytes other); // 0x000000018B1600D8-0x000000018B160124
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString4096Bytes b); // 0x000000018B160920-0x000000018B1609AC
		public bool Equals(FixedString4096Bytes other); // 0x000000018B16029C-0x000000018B1602B0
		[NotBurstCompatible]
		public static implicit operator FixedString128Bytes(string b); // 0x0000000183875020-0x0000000183875060
		[NotBurstCompatible]
		public override string ToString(); // 0x000000018B160654-0x000000018B160690
		public override int GetHashCode(); // 0x000000018B160618-0x000000018B160654
		[NotBurstCompatible]
		public override bool Equals(object obj); // 0x000000018B160370-0x000000018B160618
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes510 // TypeDefIndex: 60767
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
	public struct FixedString512Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 60768
	{
		// Fields
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes510 bytes; // 0x02
	
		// Properties
		public int Length { get; } // 0x0000000184D87110-0x0000000184D87120 
	
		// Methods
		public unsafe byte* GetUnsafePtr(); // 0x0000000184DAB500-0x0000000184DAB510
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0234EDBA */); // 0x000000018B1620A4-0x000000018B162114
		[NotBurstCompatible]
		public int CompareTo(string other); // 0x000000018B161C1C-0x000000018B161C50
		[NotBurstCompatible]
		public bool Equals(string other); // 0x000000018B161FA8-0x000000018B16202C
		public int CompareTo(FixedString32Bytes other); // 0x000000018B161C50-0x000000018B161C9C
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString32Bytes b); // 0x000000018B162338-0x000000018B1623C4
		public bool Equals(FixedString32Bytes other); // 0x000000018B161CB0-0x000000018B161CC4
		public int CompareTo(FixedString64Bytes other); // 0x000000018B161B84-0x000000018B161BD0
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString64Bytes b); // 0x000000018B1622AC-0x000000018B162338
		public bool Equals(FixedString64Bytes other); // 0x000000018B161C9C-0x000000018B161CB0
		public int CompareTo(FixedString128Bytes other); // 0x000000018B161B38-0x000000018B161B84
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString128Bytes b); // 0x000000018B162194-0x000000018B162220
		public bool Equals(FixedString128Bytes other); // 0x000000018B161F80-0x000000018B161F94
		public int CompareTo(FixedString512Bytes other); // 0x000000018B161AEC-0x000000018B161B38
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString512Bytes b); // 0x000000018B162114-0x000000018B162194
		public bool Equals(FixedString512Bytes other); // 0x000000018B161F6C-0x000000018B161F80
		public int CompareTo(FixedString4096Bytes other); // 0x000000018B161BD0-0x000000018B161C1C
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString4096Bytes b); // 0x000000018B162220-0x000000018B1622AC
		public bool Equals(FixedString4096Bytes other); // 0x000000018B161F94-0x000000018B161FA8
		[NotBurstCompatible]
		public override string ToString(); // 0x000000018B162068-0x000000018B1620A4
		public override int GetHashCode(); // 0x000000018B16202C-0x000000018B162068
		[NotBurstCompatible]
		public override bool Equals(object obj); // 0x000000018B161CC4-0x000000018B161F6C
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes4094 // TypeDefIndex: 60769
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
	public struct FixedString4096Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 60770
	{
		// Fields
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes4094 bytes; // 0x02
	
		// Properties
		public int Length { get; } // 0x0000000184D87110-0x0000000184D87120 
	
		// Methods
		public unsafe byte* GetUnsafePtr(); // 0x0000000184DAB500-0x0000000184DAB510
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0234EDBB */); // 0x000000018B1617CC-0x000000018B16183C
		[NotBurstCompatible]
		public int CompareTo(string other); // 0x000000018B161390-0x000000018B1613C4
		[NotBurstCompatible]
		public bool Equals(string other); // 0x000000018B1613D8-0x000000018B16145C
		public int CompareTo(FixedString32Bytes other); // 0x000000018B1612F8-0x000000018B161344
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString32Bytes b); // 0x000000018B161948-0x000000018B1619D4
		public bool Equals(FixedString32Bytes other); // 0x000000018B16172C-0x000000018B161740
		public int CompareTo(FixedString64Bytes other); // 0x000000018B161344-0x000000018B161390
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString64Bytes b); // 0x000000018B1618BC-0x000000018B161948
		public bool Equals(FixedString64Bytes other); // 0x000000018B161740-0x000000018B161754
		public int CompareTo(FixedString128Bytes other); // 0x000000018B1612AC-0x000000018B1612F8
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString128Bytes b); // 0x000000018B1619D4-0x000000018B161A60
		public bool Equals(FixedString128Bytes other); // 0x000000018B16145C-0x000000018B161470
		public int CompareTo(FixedString512Bytes other); // 0x000000018B161214-0x000000018B161260
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString512Bytes b); // 0x000000018B161A60-0x000000018B161AEC
		public bool Equals(FixedString512Bytes other); // 0x000000018B161470-0x000000018B161484
		public int CompareTo(FixedString4096Bytes other); // 0x000000018B161260-0x000000018B1612AC
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString4096Bytes b); // 0x000000018B16183C-0x000000018B1618BC
		public bool Equals(FixedString4096Bytes other); // 0x000000018B1613C4-0x000000018B1613D8
		[NotBurstCompatible]
		public override string ToString(); // 0x000000018B161790-0x000000018B1617CC
		public override int GetHashCode(); // 0x000000018B161754-0x000000018B161790
		[NotBurstCompatible]
		public override bool Equals(object obj); // 0x000000018B161484-0x000000018B16172C
	}

	[BurstCompatible]
	[BurstCompatible]
	[BurstCompatible]
	[BurstCompatible]
	public static class FixedStringMethods // TypeDefIndex: 60771
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

	public interface IUTF8Bytes // TypeDefIndex: 60772
	{
		// Methods
		byte* GetUnsafePtr();
		bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x0234EDBC */);
	}

	public static class ListExtensions // TypeDefIndex: 60773
	{
		// Extension methods
		public static bool RemoveSwapBack<T>(this List<T> list, T value);
		public static void RemoveAtSwapBack<T>(this List<T> list, int index);
		public static NativeArray<T> ToNativeArray<T>(this List<T> list, AllocatorManager.AllocatorHandle allocator)
			where T : struct;
	}

	[BurstCompatible]
	internal struct Memory // TypeDefIndex: 60776
	{
		// Nested types
		[BurstCompatible]
		internal struct Unmanaged // TypeDefIndex: 60775
		{
			// Nested types
			[BurstCompatible]
			internal struct Array // TypeDefIndex: 60774
			{
				// Methods
				private static bool IsCustom(AllocatorManager.AllocatorHandle allocator); // 0x0000000183347DF0-0x0000000183347E00
				private static unsafe void* CustomResize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align); // 0x000000018B15FEF8-0x000000018B15FF9C
				internal static unsafe void* Resize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align); // 0x0000000183347CE0-0x0000000183347DE0
				[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
				internal static unsafe T* Resize<T>(T* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator)
					where T : struct;
			}
	
			// Methods
			internal static unsafe void* Allocate(long size, int align, AllocatorManager.AllocatorHandle allocator); // 0x0000000183347C10-0x0000000183347C90
			internal static unsafe void Free(void* pointer, AllocatorManager.AllocatorHandle allocator); // 0x0000000183CCB260-0x0000000183CCB2A0
			[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
			internal static unsafe void Free<T>(T* pointer, AllocatorManager.AllocatorHandle allocator)
				where T : struct;
		}
	}

	[BurstCompatible]
	public static class NativeArrayExtensions // TypeDefIndex: 60777
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
		internal static void Initialize<T>(this ref NativeArray<T> array, int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0234EDBD */)
			where T : struct;
	}

	public interface IIndexable<T> // TypeDefIndex: 60778
		where T : struct
	{
		// Properties
		int Length { get; }
	}

	[DefaultMember("Item")]
	public interface INativeList<T> : IIndexable<T> // TypeDefIndex: 60779
		where T : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(NativeListDebugView<T>))]
	[NativeContainer]
	public struct NativeList<T> : INativeDisposable, INativeList<T>, IEnumerable<T> // TypeDefIndex: 60781
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
		public struct ParallelWriter // TypeDefIndex: 60780
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
		public JobHandle CrossFrameDispose(JobHandle inputDeps, JobQueuePriority priority = JobQueuePriority.NormalJobPriority /* Metadata: 0x0234EDBE */);
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
	internal struct NativeListDispose // TypeDefIndex: 60782
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe UntypedUnsafeList* m_ListData; // 0x00
	
		// Methods
		public void Dispose(); // 0x000000018B163504-0x000000018B163540
	}

	[BurstCompatible]
	[BurstCompile]
	internal struct NativeListDisposeJob : IJob // TypeDefIndex: 60783
	{
		// Fields
		internal NativeListDispose Data; // 0x00
	
		// Methods
		public void Execute(); // 0x000000018B1634FC-0x000000018B163504
	}

	internal sealed class NativeListDebugView<T> // TypeDefIndex: 60784
		where T : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy<TKey, TValue>))]
	[NativeContainer]
	public struct NativeParallelHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 60787
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
		public struct ParallelWriter // TypeDefIndex: 60785
		{
			// Fields
			internal UnsafeParallelHashMap<TKey, TValue> m_Writer;
	
			// Methods
			public bool TryAdd(TKey key, TValue item);
		}
	
		[NativeContainer]
		[NativeContainerIsReadOnly]
		public struct Enumerator : IEnumerator<KeyValue<TKey, TValue>> // TypeDefIndex: 60786
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

	internal sealed class NativeParallelHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 60788
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
	}

	[BurstCompatible]
	public static class NativeParallelHashMapExtensions // TypeDefIndex: 60789
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static UnsafeParallelHashMap<TKey, TValue> GetUnsafeMap<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> container)
			where TKey : struct, IEquatable<TKey>, IComparable<TKey>
			where TValue : struct;
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(NativeHashSetDebuggerTypeProxy<T>))]
	public struct NativeParallelHashSet<T> : INativeDisposable, IEnumerable<T> // TypeDefIndex: 60791
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 60790
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

	internal sealed class NativeHashSetDebuggerTypeProxy<T> // TypeDefIndex: 60792
		where T : struct, IEquatable<T>
	{
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	public struct NativeParallelMultiHashMapIterator<TKey> // TypeDefIndex: 60793
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
	public struct NativeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 60796
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
		public struct ParallelWriter // TypeDefIndex: 60794
		{
			// Fields
			internal UnsafeParallelMultiHashMap<TKey, TValue> m_Writer;
	
			// Methods
			public void Add(TKey key, TValue item);
		}
	
		public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 60795
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

	internal sealed class NativeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 60797
		where TKey : struct, IEquatable<TKey>, IComparable<TKey>
		where TValue : struct
	{
	}

	internal struct NativeQueueBlockHeader // TypeDefIndex: 60798
	{
		// Fields
		public unsafe NativeQueueBlockHeader* m_NextBlock; // 0x00
		public int m_NumItems; // 0x08
	}

	[BurstCompatible]
	internal struct NativeQueueBlockPoolData // TypeDefIndex: 60799
	{
		// Fields
		internal IntPtr m_FirstBlock; // 0x00
		internal int m_NumBlocks; // 0x08
		internal int m_MaxBlocks; // 0x0C
		internal int m_AllocLock; // 0x10
	
		// Methods
		public unsafe NativeQueueBlockHeader* AllocateBlock(); // 0x0000000183FA3AD0-0x0000000183FA3B50
		public unsafe void FreeBlock(NativeQueueBlockHeader* block); // 0x0000000183EE1D30-0x0000000183EE1E00
	}

	internal class NativeQueueBlockPool // TypeDefIndex: 60800
	{
		// Fields
		private static readonly SharedStatic<IntPtr> Data; // 0x00
	
		// Constructors
		static NativeQueueBlockPool(); // 0x000000018452F380-0x000000018452F3E0
	
		// Methods
		internal static unsafe NativeQueueBlockPoolData* GetQueueBlockPool(); // 0x0000000183FE6EC0-0x0000000183FE6FE0
		[BurstDiscard]
		private static void AppDomainOnDomainUnload(); // 0x0000000183B0D570-0x0000000183B0D600
		private static void OnDomainUnload(object sender, EventArgs e); // 0x000000018B163540-0x000000018B163614
	}

	[BurstCompatible]
	internal struct NativeQueueData // TypeDefIndex: 60801
	{
		// Fields
		public IntPtr m_FirstBlock; // 0x00
		public IntPtr m_LastBlock; // 0x08
		public int m_MaxItems; // 0x10
		public int m_CurrentRead; // 0x14
		public unsafe byte* m_CurrentWriteBlockTLS; // 0x18
	
		// Methods
		internal unsafe NativeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex); // 0x0000000184DAB520-0x0000000184DAB530
		internal unsafe void SetCurrentWriteBlockTLS(int threadIndex, NativeQueueBlockHeader* currentWriteBlock); // 0x0000000184DAB530-0x0000000184DAB540
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe NativeQueueBlockHeader* AllocateWriteBlockMT<T>(NativeQueueData* data, NativeQueueBlockPoolData* pool, int threadIndex)
			where T : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void AllocateQueue<T>(AllocatorManager.AllocatorHandle label, out NativeQueueData* outBuf)
			where T : struct;
		public static unsafe void DeallocateQueue(NativeQueueData* data, NativeQueueBlockPoolData* pool, AllocatorManager.AllocatorHandle allocation); // 0x00000001841649C0-0x0000000184164A10
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[NativeContainer]
	public struct NativeQueue<T> : INativeDisposable // TypeDefIndex: 60803
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
		public struct ParallelWriter // TypeDefIndex: 60802
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
	internal struct NativeQueueDispose // TypeDefIndex: 60804
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe NativeQueueData* m_Buffer; // 0x00
		[NativeDisableUnsafePtrRestriction]
		internal unsafe NativeQueueBlockPoolData* m_QueuePool; // 0x08
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x10
	
		// Methods
		public void Dispose(); // 0x000000018B16361C-0x000000018B163630
	}

	[BurstCompile]
	internal struct NativeQueueDisposeJob : IJob // TypeDefIndex: 60805
	{
		// Fields
		public NativeQueueDispose Data; // 0x00
	
		// Methods
		public void Execute(); // 0x000000018B163614-0x000000018B16361C
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[NativeContainer]
	public struct NativeReference<T> : INativeDisposable, IEquatable<NativeReference<T>> // TypeDefIndex: 60806
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
		public unsafe NativeReference(AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x0234EDBF */);
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
	internal struct NativeReferenceDispose // TypeDefIndex: 60807
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe void* m_Data; // 0x00
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x08
	
		// Methods
		public void Dispose(); // 0x000000018B163638-0x000000018B163648
	}

	[BurstCompile]
	internal struct NativeReferenceDisposeJob : IJob // TypeDefIndex: 60808
	{
		// Fields
		internal NativeReferenceDispose Data; // 0x00
	
		// Methods
		public void Execute(); // 0x000000018B163630-0x000000018B163638
	}

	[BurstCompatible]
	public static class NativeSortExtension // TypeDefIndex: 60810
	{
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public struct DefaultComparer<T> : IComparer<T> // TypeDefIndex: 60809
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
	public struct SortJob<T, U> // TypeDefIndex: 60813
		where T : struct
		where U : IComparer<T>
	{
		// Fields
		public unsafe T* Data;
		public U Comp;
		public int Length;
	
		// Nested types
		[BurstCompile]
		private struct SegmentSort : IJobParallelFor // TypeDefIndex: 60811
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
		private struct SegmentSortMerge : IJob // TypeDefIndex: 60812
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
	public struct NativeStream : IDisposable // TypeDefIndex: 60816
	{
		// Fields
		private UnsafeStream m_Stream; // 0x00
	
		// Nested types
		[BurstCompile]
		private struct ConstructJobList : IJob // TypeDefIndex: 60814
		{
			// Fields
			public NativeStream Container; // 0x00
			[NativeDisableUnsafePtrRestriction]
			[Unity.Collections.ReadOnly]
			public unsafe UntypedUnsafeList* List; // 0x10
	
			// Methods
			public void Execute(); // 0x000000018B160024-0x000000018B160048
		}
	
		[BurstCompile]
		private struct ConstructJob : IJob // TypeDefIndex: 60815
		{
			// Fields
			public NativeStream Container; // 0x00
			[Unity.Collections.ReadOnly]
			public NativeArray<int> Length; // 0x10
	
			// Methods
			public void Execute(); // 0x000000018B160048-0x000000018B160058
		}
	
		// Methods
		public void Dispose(); // 0x000000018B160058-0x000000018B160060
		private void AllocateForEach(int forEachCount); // 0x000000018B163648-0x000000018B163650
	}

	internal struct Spinner // TypeDefIndex: 60817
	{
		// Fields
		private int m_value; // 0x00
	
		// Methods
		public void Lock(); // 0x000000018B163CB4-0x000000018B163CC8
		public void Unlock(); // 0x000000018B163CC8-0x000000018B163CE4
	}

	internal struct UnmanagedArray<T> : IDisposable // TypeDefIndex: 60818
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
	public struct RewindableAllocator : AllocatorManager.IAllocator // TypeDefIndex: 60822
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
		public AllocatorManager.AllocatorHandle Handle { get; } // 0x0000000184D88B20-0x0000000184D88B30 
	
		// Nested types
		[BurstCompatible]
		internal struct MemoryBlock : IDisposable // TypeDefIndex: 60819
		{
			// Fields
			public unsafe byte* m_pointer; // 0x00
			public long m_bytes; // 0x08
			public long m_current; // 0x10
			public long m_allocations; // 0x18
	
			// Constructors
			public unsafe MemoryBlock(long bytes); // 0x000000018B1634A8-0x000000018B1634FC
	
			// Methods
			public void Rewind(); // 0x0000000184D92200-0x0000000184D92210
			public void Dispose(); // 0x000000018B16336C-0x000000018B1633CC
			public int TryAllocate(ref AllocatorManager.Block block); // 0x000000018B1633CC-0x000000018B1634A8
			public bool Contains(IntPtr ptr); // 0x000000018B163354-0x000000018B16336C
		}
	
		public delegate int Try_000008B6_PostfixBurstDelegate(IntPtr state, ref AllocatorManager.Block block); // TypeDefIndex: 60820; 0x00000001815802E0-0x00000001815802F0
	
		internal static class Try_000008B6_BurstDirectCall // TypeDefIndex: 60821
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Try_000008B6_BurstDirectCall(); // 0x0000000183FAEA70-0x0000000183FAEA80
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00082103); // 0x000000018B1642C4-0x000000018B1643C8
			private static IntPtr GetFunctionPointer(); // 0x000000018B1643C8-0x000000018B16441C
			public static void Constructor(); // 0x0000000183FB0870-0x0000000183FB0900
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static int Invoke(IntPtr state, ref AllocatorManager.Block block); // 0x000000018B16441C-0x000000018B1644A8
		}
	
		// Methods
		public void Rewind(); // 0x000000018B163754-0x000000018B163838
		public void Dispose(); // 0x000000018B163688-0x000000018B163754
		public int Try(ref AllocatorManager.Block block); // 0x000000018B163840-0x000000018B163A08
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		internal static int Try(IntPtr state, ref AllocatorManager.Block block); // 0x000000018B163A08-0x000000018B163A64
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		public static int Try_BurstManaged(IntPtr state, ref AllocatorManager.Block block); // 0x000000018B163838-0x000000018B163840
	}

	public enum FormatError // TypeDefIndex: 60823
	{
		None = 0,
		Overflow = 1
	}

	public enum CopyError // TypeDefIndex: 60824
	{
		None = 0,
		Truncation = 1
	}

	public enum ConversionError // TypeDefIndex: 60825
	{
		None = 0,
		Overflow = 1,
		Encoding = 2,
		CodePoint = 3
	}

	[BurstCompatible]
	public struct Unicode // TypeDefIndex: 60827
	{
		// Properties
		public static Rune ReplacementCharacter { get; } // 0x0000000184DAB550-0x0000000184DAB560 
	
		// Nested types
		[BurstCompatible]
		public struct Rune // TypeDefIndex: 60826
		{
			// Fields
			public int value; // 0x00
		}
	
		// Methods
		public static bool IsValidCodePoint(int codepoint); // 0x0000000183875EB0-0x0000000183875EC0
		public static bool NotTrailer(byte b); // 0x000000018B164628-0x000000018B164634
		public static unsafe ConversionError Utf8ToUcs(out Rune rune, byte* buffer, ref int index, int capacity); // 0x0000000183875E20-0x0000000183875E60
		private static bool IsLeadingSurrogate(char c); // 0x0000000183875EC0-0x0000000183875EE0
		private static bool IsTrailingSurrogate(char c); // 0x000000018A7E1B0C-0x000000018A7E1B28
		public static unsafe ConversionError Utf16ToUcs(out Rune rune, char* buffer, ref int index, int capacity); // 0x0000000183875CE0-0x0000000183875D60
		public static unsafe ConversionError UcsToUtf8(byte* buffer, ref int index, int capacity, Rune rune); // 0x0000000183875CA0-0x0000000183875CE0
		public static unsafe ConversionError UcsToUtf16(char* buffer, ref int index, int capacity, Rune rune); // 0x0000000183875E60-0x0000000183875EB0
		public static unsafe ConversionError Utf16ToUtf8(char* utf16Buffer, int utf16Length, byte* utf8Buffer, out int utf8Length, int utf8Capacity); // 0x0000000183875BE0-0x0000000183875CA0
		public static unsafe ConversionError Utf8ToUtf16(byte* utf8Buffer, int utf8Length, char* utf16Buffer, out int utf16Length, int utf16Capacity); // 0x0000000183875D60-0x0000000183875E20
	}

	[BurstCompatible]
	public static class UTF8ArrayUnsafeUtility // TypeDefIndex: 60829
	{
		// Nested types
		internal struct Comparison // TypeDefIndex: 60828
		{
			// Fields
			public bool terminates; // 0x00
			public int result; // 0x04
	
			// Constructors
			public Comparison(Unicode.Rune runeA, ConversionError errorA, Unicode.Rune runeB, ConversionError errorB); // 0x000000018B15FFF4-0x000000018B160024
		}
	
		// Methods
		public static unsafe CopyError Copy(byte* dest, out int destLength, int destUTF8MaxLengthInBytes, char* src, int srcLength); // 0x000000018B1644A8-0x000000018B1644DC
		public static unsafe CopyError Copy(byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength); // 0x0000000183875B10-0x0000000183875BE0
		public static unsafe int StrCmp(byte* utf8BufferA, int utf8LengthInBytesA, byte* utf8BufferB, int utf8LengthInBytesB); // 0x000000018B164590-0x000000018B164628
		public static unsafe bool EqualsUTF8Bytes(byte* aBytes, int aLength, byte* bBytes, int bLength); // 0x000000018B1644DC-0x000000018B1644F8
		public static unsafe int StrCmp(byte* utf8Buffer, int utf8LengthInBytes, char* utf16Buffer, int utf16LengthInChars); // 0x000000018B1644F8-0x000000018B164590
	}

	[BurstCompatible]
	[BurstCompatible]
	[BurstCompatible]
	[BurstCompile]
	public static class xxHash3 // TypeDefIndex: 60835
	{
		// Nested types
		private struct ulong2 // TypeDefIndex: 60830
		{
			// Fields
			public ulong x; // 0x00
			public ulong y; // 0x08
	
			// Constructors
			public ulong2(ulong x, ulong y); // 0x0000000184D861B0-0x0000000184D861C0
		}
	
		public unsafe delegate ulong Hash64Long_000008F7_PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret); // TypeDefIndex: 60831; 0x00000001814D0D00-0x00000001814D0D20
	
		internal static class Hash64Long_000008F7_BurstDirectCall // TypeDefIndex: 60832
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Hash64Long_000008F7_BurstDirectCall(); // 0x0000000183FAEA80-0x0000000183FAEA90
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000821ea); // 0x000000018B163010-0x000000018B163114
			private static IntPtr GetFunctionPointer(); // 0x000000018B163114-0x000000018B163168
			public static void Constructor(); // 0x0000000183FB0900-0x0000000183FB0990
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe ulong Invoke(byte* input, byte* dest, long length, byte* secret); // 0x000000018B163168-0x000000018B163218
		}
	
		public unsafe delegate void Hash128Long_000008FE_PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret, out uint4 result); // TypeDefIndex: 60833; 0x00000001814DD080-0x00000001814DD0A0
	
		internal static class Hash128Long_000008FE_BurstDirectCall // TypeDefIndex: 60834
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Hash128Long_000008FE_BurstDirectCall(); // 0x0000000183FAEA90-0x0000000183FAEAA0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000821f6); // 0x000000018B162D20-0x000000018B162E24
			private static IntPtr GetFunctionPointer(); // 0x000000018B162E24-0x000000018B162E78
			public static void Constructor(); // 0x0000000183FB0990-0x0000000183FB0A20
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(byte* input, byte* dest, long length, byte* secret, out uint4 result); // 0x000000018B162E78-0x000000018B162F3C
		}
	
		// Methods
		internal static unsafe void Avx2HashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64); // 0x0000000184D83230-0x0000000184D83240
		internal static unsafe void Avx2ScrambleAcc(ulong* acc, byte* secret); // 0x0000000184D83230-0x0000000184D83240
		internal static unsafe void Avx2Accumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64); // 0x0000000184D83230-0x0000000184D83240
		internal static unsafe void Avx2Accumulate512(ulong* acc, byte* input, byte* dest, byte* secret); // 0x0000000184D83230-0x0000000184D83240
		public static unsafe uint2 Hash64(void* input, long length); // 0x0000000182F835D0-0x0000000182F838B0
		public static unsafe uint4 Hash128(void* input, long length); // 0x000000018B1653CC-0x000000018B165470
		internal static unsafe ulong Hash64Internal(byte* input, byte* dest, long length, byte* secret, ulong seed); // 0x0000000182F838B0-0x0000000182F83BD0
		internal static unsafe void Hash128Internal(byte* input, byte* dest, long length, byte* secret, ulong seed, out uint4 result); // 0x000000018B164B90-0x000000018B164CD8
		private static unsafe ulong Hash64Len1To3(byte* input, long len, byte* secret, ulong seed); // 0x00000001840F2920-0x00000001840F2960
		private static unsafe ulong Hash64Len4To8(byte* input, long length, byte* secret, ulong seed); // 0x0000000182F84BC0-0x0000000182F84C00
		private static unsafe ulong Hash64Len9To16(byte* input, long length, byte* secret, ulong seed); // 0x0000000183F6B640-0x0000000183F6B6A0
		private static unsafe ulong Hash64Len0To16(byte* input, long length, byte* secret, ulong seed); // 0x0000000182F84B10-0x0000000182F84BC0
		private static unsafe ulong Hash64Len17To128(byte* input, long length, byte* secret, ulong seed); // 0x0000000182F84CB0-0x0000000182F84EF0
		private static unsafe ulong Hash64Len129To240(byte* input, long length, byte* secret, ulong seed); // 0x000000018461E140-0x000000018461E220
		[BurstCompile]
		private static unsafe ulong Hash64Long(byte* input, byte* dest, long length, byte* secret); // 0x000000018B165470-0x000000018B1654E4
		private static unsafe void Hash128Len1To3(byte* input, long length, byte* secret, ulong seed, out uint4 result); // 0x000000018B165114-0x000000018B1651AC
		private static unsafe void Hash128Len4To8(byte* input, long len, byte* secret, ulong seed, out uint4 result); // 0x000000018B1651AC-0x000000018B16525C
		private static unsafe void Hash128Len9To16(byte* input, long len, byte* secret, ulong seed, out uint4 result); // 0x000000018B16525C-0x000000018B16534C
		private static unsafe void Hash128Len0To16(byte* input, long length, byte* secret, ulong seed, out uint4 result); // 0x000000018B164CD8-0x000000018B164D7C
		private static unsafe void Hash128Len17To128(byte* input, long length, byte* secret, ulong seed, out uint4 result); // 0x000000018B164F84-0x000000018B165114
		private static unsafe void Hash128Len129To240(byte* input, long length, byte* secret, ulong seed, out uint4 result); // 0x000000018B164D7C-0x000000018B164F84
		[BurstCompile]
		private static unsafe void Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result); // 0x000000018B16534C-0x000000018B1653CC
		internal static uint2 ToUint2(ulong u); // 0x0000000184DAB5F0-0x0000000184DAB610
		internal static uint4 ToUint4(ulong ul0, ulong ul1); // 0x0000000184DAB610-0x0000000184DAB630
		internal static unsafe void EncodeSecretKey(byte* dst, byte* secret, ulong seed); // 0x000000018B164B60-0x000000018B164B90
		private static unsafe ulong Read64LE(void* addr); // 0x0000000182B76770-0x0000000182B76780
		private static unsafe uint Read32LE(void* addr); // 0x0000000182B77620-0x0000000182B77630
		private static unsafe void Write64LE(void* addr, ulong value); // 0x0000000184D88B60-0x0000000184D88B70
		private static ulong Mul32To64(uint x, uint y); // 0x0000000184DA5160-0x0000000184DA5170
		private static ulong Swap64(ulong x); // 0x0000000184DAB5E0-0x0000000184DAB5F0
		private static uint Swap32(uint x); // 0x0000000184DA4CD0-0x0000000184DA4CE0
		private static uint RotL32(uint x, int r); // 0x0000000184D882E0-0x0000000184D88300
		private static ulong RotL64(ulong x, int r); // 0x0000000184DAB5C0-0x0000000184DAB5E0
		private static ulong XorShift64(ulong v64, int shift); // 0x0000000184DAB630-0x0000000184DAB650
		private static ulong Mul128Fold64(ulong lhs, ulong rhs); // 0x000000018B16563C-0x000000018B165660
		private static unsafe ulong Mix16(byte* input, byte* secret, ulong seed); // 0x000000018B165570-0x000000018B165590
		private static unsafe ulong2 Mix32(ulong2 acc, byte* input_1, byte* input_2, byte* secret, ulong seed); // 0x000000018B16559C-0x000000018B16563C
		private static ulong Avalanche(ulong h64); // 0x0000000184DAB590-0x0000000184DAB5C0
		private static ulong AvalancheH64(ulong h64); // 0x00000001840F2960-0x00000001840F29A0
		private static ulong rrmxmx(ulong h64, ulong length); // 0x0000000184DAB650-0x0000000184DAB6B0
		private static unsafe ulong Mix2Acc(ulong acc0, ulong acc1, byte* secret); // 0x000000018B165590-0x000000018B16559C
		internal static unsafe ulong MergeAcc(ulong* acc, byte* secret, ulong start); // 0x000000018B1654E4-0x000000018B165570
		private static unsafe void DefaultHashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64); // 0x000000018B1649BC-0x000000018B164B30
		internal static unsafe void DefaultAccumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64); // 0x000000018B164918-0x000000018B1649BC
		internal static unsafe void DefaultAccumulate512(ulong* acc, byte* input, byte* dest, byte* secret, int isHash64); // 0x000000018B164898-0x000000018B164918
		internal static unsafe void DefaultScrambleAcc(ulong* acc, byte* secret); // 0x000000018B164B30-0x000000018B164B60
		[BurstCompile]
		public static unsafe ulong Hash64Long_BurstManaged(byte* input, byte* dest, long length, byte* secret); // 0x000000018B15FA9C-0x000000018B15FC48
		[BurstCompile]
		public static unsafe void Hash128Long_BurstManaged(byte* input, byte* dest, long length, byte* secret, out uint4 result); // 0x000000018B15F960-0x000000018B15FA9C
	}

	internal static class xxHashDefaultKey // TypeDefIndex: 60836
	{
		// Fields
		public static readonly byte[] kSecret; // 0x00
	
		// Constructors
		static xxHashDefaultKey(); // 0x0000000184D164D0-0x0000000184D16560
	}
}

namespace Unity.Collections.LowLevel.Unsafe
{
	[BurstCompatible]
	public static class NativeListUnsafeUtility // TypeDefIndex: 60838
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
	public static class NativeReferenceUnsafeUtility // TypeDefIndex: 60839
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
	public struct UnsafeAppendBuffer : INativeDisposable // TypeDefIndex: 60840
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe byte* Ptr; // 0x00
		public int Length; // 0x08
		public int Capacity; // 0x0C
		public AllocatorManager.AllocatorHandle Allocator; // 0x10
		public readonly int Alignment; // 0x14
	
		// Methods
		public void Dispose(); // 0x000000018B164634-0x000000018B1646B8
	}

	[BurstCompile]
	internal struct UnsafeDisposeJob : IJob // TypeDefIndex: 60841
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe void* Ptr; // 0x00
		public AllocatorManager.AllocatorHandle Allocator; // 0x08
	
		// Methods
		public void Execute(); // 0x000000018B1646B8-0x000000018B16470C
	}

	internal struct UntypedUnsafeList // TypeDefIndex: 60842
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
	public struct UnsafeList<T> : INativeDisposable, INativeList<T>, IEnumerable<T> // TypeDefIndex: 60845
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
		public struct ParallelReader // TypeDefIndex: 60843
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public readonly unsafe T* Ptr;
			public readonly int Length;
	
			// Constructors
			internal unsafe ParallelReader(T* ptr, int length);
		}
	
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public struct ParallelWriter // TypeDefIndex: 60844
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
		public unsafe UnsafeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0234EDC8 */);
	
		// Methods
		public ref ref T ElementAt(int index);
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(AllocatorManager.AllocatorHandle) })]
		internal static unsafe UnsafeList<T>* Create<U>(int initialCapacity, ref ref U allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0234EDC9 */)
			where U : struct, AllocatorManager.IAllocator;
		public static unsafe UnsafeList<T>* Create(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0234EDCA */);
		public static unsafe void Destroy(UnsafeList<T>* listData);
		public void Dispose();
		[NotBurstCompatible]
		public JobHandle Dispose(JobHandle inputDeps);
		[NotBurstCompatible]
		public JobHandle CrossFrameDispose(JobHandle inputDeps, JobQueuePriority priority = JobQueuePriority.NormalJobPriority /* Metadata: 0x0234EDCB */);
		public void Clear();
		public void Resize(int length, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0234EDCC */);
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

	internal sealed class UnsafeListTDebugView<T> // TypeDefIndex: 60846
		where T : struct
	{
	}

	[BurstCompatible]
	internal struct UnsafeParallelHashMapData // TypeDefIndex: 60848
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
		internal const int IntsPerCacheLine = 16; // Metadata: 0x0234EDCD
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _firstFreeTLS_e__FixedBuffer // TypeDefIndex: 60847
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		// Methods
		internal static int GetBucketSize(int capacity); // 0x0000000184DAB580-0x0000000184DAB590
		internal static int GrowCapacity(int capacity); // 0x000000018352EE60-0x000000018352EE70
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static unsafe void AllocateHashMap<TKey, TValue>(int length, int bucketLength, AllocatorManager.AllocatorHandle label, out UnsafeParallelHashMapData* outBuf)
			where TKey : struct
			where TValue : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static unsafe void ReallocateHashMap<TKey, TValue>(UnsafeParallelHashMapData* data, int newCapacity, int newBucketCapacity, AllocatorManager.AllocatorHandle label)
			where TKey : struct
			where TValue : struct;
		internal static unsafe void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorManager.AllocatorHandle allocator); // 0x00000001837F6580-0x00000001837F65D0
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static int CalculateDataSize<TKey, TValue>(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset)
			where TKey : struct
			where TValue : struct;
		internal static unsafe bool IsEmpty(UnsafeParallelHashMapData* data); // 0x000000018394D400-0x000000018394D450
		internal static unsafe int GetCount(UnsafeParallelHashMapData* data); // 0x0000000183A09AA0-0x0000000183A09B10
		internal static unsafe bool MoveNext(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index); // 0x00000001834ACF90-0x00000001834AD040
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		internal static unsafe void GetKeyArray<TKey>(UnsafeParallelHashMapData* data, NativeArray<TKey> result)
			where TKey : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		internal static unsafe void GetValueArray<TValue>(UnsafeParallelHashMapData* data, NativeArray<TValue> result)
			where TValue : struct;
	}

	[BurstCompatible]
	[NativeContainer]
	internal struct UnsafeParallelHashMapDataDispose // TypeDefIndex: 60849
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer; // 0x00
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x08
	
		// Methods
		public void Dispose(); // 0x000000018B164714-0x000000018B164724
	}

	[BurstCompile]
	internal struct UnsafeParallelHashMapDataDisposeJob : IJob // TypeDefIndex: 60850
	{
		// Fields
		internal UnsafeParallelHashMapDataDispose Data; // 0x00
	
		// Methods
		public void Execute(); // 0x000000018B16470C-0x000000018B164714
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	internal struct UnsafeParallelHashMapBase<TKey, TValue> // TypeDefIndex: 60851
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
	public struct KeyValue<TKey, TValue> // TypeDefIndex: 60852
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

	internal struct UnsafeParallelHashMapDataEnumerator // TypeDefIndex: 60853
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer; // 0x00
		internal int m_Index; // 0x08
		internal int m_BucketIndex; // 0x0C
		internal int m_NextIndex; // 0x10
	
		// Constructors
		internal unsafe UnsafeParallelHashMapDataEnumerator(UnsafeParallelHashMapData* data); // 0x0000000184DAB560-0x0000000184DAB580
	
		// Methods
		internal bool MoveNext(); // 0x0000000183824360-0x0000000183824390
		internal void Reset(); // 0x0000000184D95D70-0x0000000184D95D90
		internal KeyValue<TKey, TValue> GetCurrent<TKey, TValue>()
			where TKey : struct, IEquatable<TKey>
			where TValue : struct;
		internal TKey GetCurrentKey<TKey>()
			where TKey : struct, IEquatable<TKey>;
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerDisplay("Count = {Count()}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(UnsafeParallelHashMapDebuggerTypeProxy<TKey, TValue>))]
	public struct UnsafeParallelHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 60855
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
		public struct ParallelWriter // TypeDefIndex: 60854
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
	internal struct UnsafeParallelHashMapDisposeJob : IJob // TypeDefIndex: 60856
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeParallelHashMapData* Data; // 0x00
		public AllocatorManager.AllocatorHandle Allocator; // 0x08
	
		// Methods
		public void Execute(); // 0x000000018B164714-0x000000018B164724
	}

	internal sealed class UnsafeParallelHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 60857
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(UnsafeHashSetDebuggerTypeProxy<T>))]
	public struct UnsafeParallelHashSet<T> : INativeDisposable, IEnumerable<T> // TypeDefIndex: 60859
		where T : struct, IEquatable<T>
	{
		// Fields
		internal UnsafeParallelHashMap<T, bool> m_Data;
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 60858
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

	internal sealed class UnsafeHashSetDebuggerTypeProxy<T> // TypeDefIndex: 60860
		where T : struct, IEquatable<T>
	{
	}

	public static class HashSetExtensions // TypeDefIndex: 60861
	{
		// Extension methods
		public static void UnionWith<T>(this UnsafeParallelHashSet<T> container, UnsafeParallelHashSet<T> other)
			where T : struct, IEquatable<T>;
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerTypeProxy(typeof(UnsafeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue>))]
	public struct UnsafeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 60863
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
		public struct ParallelWriter // TypeDefIndex: 60862
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

	internal sealed class UnsafeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 60864
		where TKey : struct, IEquatable<TKey>, IComparable<TKey>
		where TValue : struct
	{
	}

	[BurstCompatible]
	internal struct UnsafeStreamBlock // TypeDefIndex: 60866
	{
		// Fields
		internal unsafe UnsafeStreamBlock* Next; // 0x00
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte Data[0]; // 0x08
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _Data_e__FixedBuffer // TypeDefIndex: 60865
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	[BurstCompatible]
	internal struct UnsafeStreamRange // TypeDefIndex: 60867
	{
		// Fields
		internal unsafe UnsafeStreamBlock* Block; // 0x00
		internal int OffsetInFirstBlock; // 0x08
		internal int ElementCount; // 0x0C
		internal int LastOffset; // 0x10
		internal int NumberOfBlocks; // 0x14
	}

	[BurstCompatible]
	internal struct UnsafeStreamBlockData // TypeDefIndex: 60868
	{
		// Fields
		internal AllocatorManager.AllocatorHandle Allocator; // 0x00
		internal unsafe UnsafeStreamBlock** Blocks; // 0x08
		internal int BlockCount; // 0x10
		internal unsafe UnsafeStreamBlock* Free; // 0x18
		internal unsafe UnsafeStreamRange* Ranges; // 0x20
		internal int RangeCount; // 0x28
	}

	[BurstCompatible]
	public struct UnsafeStream : INativeDisposable // TypeDefIndex: 60872
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeStreamBlockData* m_Block; // 0x00
		internal AllocatorManager.AllocatorHandle m_Allocator; // 0x08
	
		// Nested types
		[BurstCompile]
		private struct DisposeJob : IJob // TypeDefIndex: 60869
		{
			// Fields
			public UnsafeStream Container; // 0x00
	
			// Methods
			public void Execute(); // 0x000000018B160058-0x000000018B160060
		}
	
		[BurstCompile]
		private struct ConstructJobList : IJob // TypeDefIndex: 60870
		{
			// Fields
			public UnsafeStream Container; // 0x00
			[NativeDisableUnsafePtrRestriction]
			[Unity.Collections.ReadOnly]
			public unsafe UntypedUnsafeList* List; // 0x10
	
			// Methods
			public void Execute(); // 0x000000018B160024-0x000000018B160048
		}
	
		[BurstCompile]
		private struct ConstructJob : IJob // TypeDefIndex: 60871
		{
			// Fields
			public UnsafeStream Container; // 0x00
			[Unity.Collections.ReadOnly]
			public NativeArray<int> Length; // 0x10
	
			// Methods
			public void Execute(); // 0x000000018B160048-0x000000018B160058
		}
	
		// Methods
		internal void AllocateForEach(int forEachCount); // 0x000000018B164724-0x000000018B1647A4
		private void Deallocate(); // 0x000000018B1647A4-0x000000018B164898
		public void Dispose(); // 0x000000018B160058-0x000000018B160060
	}

	[BurstCompatible]
	public static class UnsafeUtilityExtensions // TypeDefIndex: 60873
	{
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* AddressOf<T>([IsReadOnly] in ref T value)
			where T : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static ref ref T AsRef<T>([IsReadOnly] in ref T value)
			where T : struct;
		public static IntPtr Malloc(long size, int alignment, Unity.Collections.Allocator allocator); // 0x0000000183116130-0x0000000183116140
	}
}

namespace Unity.Collections.NotBurstCompatible
{
	public static class Extensions // TypeDefIndex: 60837
	{
		// Extension methods
		[NotBurstCompatible]
		public static T[] ToArrayNBC<T>(this NativeList<T> list)
			where T : struct;
	}
}

namespace Unity.Jobs
{
	public class EarlyInitHelpers // TypeDefIndex: 60690
	{
		// Methods
		public static void JobReflectionDataCreationFailed(Exception ex, System.Type jobType); // 0x000000018B160060-0x000000018B1600D8
	}

	[JobProducerType(typeof(IJobBurstSchedulableExtensions.JobBurstSchedulableProducer<T>))]
	public interface IJobBurstSchedulable // TypeDefIndex: 60691
	{
		// Methods
		void Execute();
	}

	public static class IJobBurstSchedulableExtensions // TypeDefIndex: 60694
	{
		// Nested types
		internal struct JobBurstSchedulableProducer<T> // TypeDefIndex: 60693
			where T : struct, IJobBurstSchedulable
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 60692; 0x00000000-0x00000000
	
			// Constructors
			static JobBurstSchedulableProducer();
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			internal static void Initialize();
			public static void Execute(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);
		}
	}

	[JobProducerType(typeof(IJobParallelForBatchExtensions.JobParallelForBatchProducer<T>))]
	public interface IJobParallelForBatch // TypeDefIndex: 60695
	{
		// Methods
		void Execute(int startIndex, int count);
	}

	public static class IJobParallelForBatchExtensions // TypeDefIndex: 60698
	{
		// Nested types
		internal struct JobParallelForBatchProducer<T> // TypeDefIndex: 60697
			where T : struct, IJobParallelForBatch
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 60696; 0x00000000-0x00000000
	
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
	public interface IJobParallelForBurstSchedulable // TypeDefIndex: 60699
	{
		// Methods
		void Execute(int index);
	}

	public static class IJobParallelForExtensionsBurstSchedulable // TypeDefIndex: 60702
	{
		// Nested types
		internal struct JobParallelForBurstSchedulableProducer<T> // TypeDefIndex: 60701
			where T : struct, IJobParallelForBurstSchedulable
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 60700; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForBurstSchedulableProducer();
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			internal static void Initialize();
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex);
		}
	}

	[JobProducerType(typeof(IJobParallelForDeferExtensions.JobParallelForDeferProducer<T>))]
	public interface IJobParallelForDefer // TypeDefIndex: 60703
	{
		// Methods
		void Execute(int index);
	}

	public static class IJobParallelForDeferExtensions // TypeDefIndex: 60706
	{
		// Nested types
		internal struct JobParallelForDeferProducer<T> // TypeDefIndex: 60705
			where T : struct, IJobParallelForDefer
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			public delegate void ExecuteJobFunction(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 60704; 0x00000000-0x00000000
	
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
	public interface IJobParallelForFilter // TypeDefIndex: 60707
	{
		// Methods
		bool Execute(int index);
	}

	public static class JobParallelIndexListExtensions // TypeDefIndex: 60711
	{
		// Nested types
		internal struct JobParallelForFilterProducer<T> // TypeDefIndex: 60710
			where T : struct, IJobParallelForFilter
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			public struct JobWrapper // TypeDefIndex: 60708
			{
				// Fields
				[NativeDisableParallelForRestriction]
				public NativeList<int> outputIndices;
				public int appendCount;
				public T JobData;
			}
	
			public delegate void ExecuteJobFunction(ref JobWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 60709; 0x00000000-0x00000000
	
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
	internal class DOTSCompilerGeneratedAttribute : Attribute // TypeDefIndex: 60712
	{
		// Constructors
		public DOTSCompilerGeneratedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
