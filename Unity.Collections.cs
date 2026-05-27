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
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;

// Image 54: Unity.Collections.dll - Assembly: Unity.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57171-57361
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

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__147347369 // TypeDefIndex: 57360
{
	// Constructors
	public __JobReflectionRegistrationOutput__147347369() {} // Dummy constructor

	// Methods
	public static void CreateJobReflectionData() {} // 0x000000018228EEB0-0x0000000182290EA0
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit() {} // 0x0000000182290EA0-0x0000000182293810
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 57361
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize() {} // 0x0000000183C83F50-0x0000000183C84000
}

namespace Unity.Collections
{
	public static class AllocatorManager // TypeDefIndex: 57216
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
		public delegate int TryFunction(IntPtr allocatorState, ref Block block); // TypeDefIndex: 57197; 0x0000000181165340-0x0000000181165350
	
		public struct AllocatorHandle : IAllocator // TypeDefIndex: 57198
		{
			// Fields
			public ushort Index; // 0x00
			public ushort Version; // 0x02
	
			// Properties
			internal ref TableEntry TableEntry { get => default; } // 0x0000000189B63568-0x0000000189B635E4 
			public int Value { get => default; } // 0x0000000183D4F990-0x0000000183D4F9A0 
			public AllocatorHandle Handle { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
			public Unity.Collections.Allocator ToAllocator { get => default; } // 0x0000000183D76730-0x0000000183D76740 
	
			// Methods
			internal void Rewind() {} // 0x000000018350B670-0x000000018350B680
			public static implicit operator AllocatorHandle(Unity.Collections.Allocator a) => default; // 0x0000000183D76740-0x0000000183D76760
			public int Try(ref Block block) => default; // 0x0000000182419B00-0x0000000182419BB0
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public struct Range : IDisposable // TypeDefIndex: 57199
		{
			// Fields
			public IntPtr Pointer; // 0x00
			public int Items; // 0x08
			public AllocatorHandle Allocator; // 0x0C
	
			// Methods
			public void Dispose() {} // 0x0000000189B66EA8-0x0000000189B66EE0
		}
	
		public struct Block : IDisposable // TypeDefIndex: 57200
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
			public long Bytes { get => default; } // 0x0000000183D76840-0x0000000183D76850 
			public long AllocatedBytes { get => default; } // 0x0000000183D76830-0x0000000183D76840 
			public int Alignment { get => default; set {} } // 0x0000000183D76820-0x0000000183D76830 0x0000000182419C70-0x0000000182419CC0
	
			// Methods
			public void Dispose() {} // 0x0000000189B638BC-0x0000000189B638C4
			public int TryFree() => default; // 0x0000000189B638C4-0x0000000189B63914
		}
	
		public interface IAllocator : IDisposable // TypeDefIndex: 57201
		{
			// Properties
			AllocatorHandle Handle { get; }
	
			// Methods
			int Try(ref Block block);
		}
	
		[BurstCompile(CompileSynchronously = true)]
		internal struct StackAllocator : IAllocator // TypeDefIndex: 57204
		{
			// Fields
			internal AllocatorHandle m_handle; // 0x00
			internal Block m_storage; // 0x08
			internal long m_top; // 0x28
	
			// Properties
			public AllocatorHandle Handle { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
	
			// Nested types
			public delegate int Try_000000A0_PostfixBurstDelegate(IntPtr allocatorState, ref Block block); // TypeDefIndex: 57202; 0x0000000181165340-0x0000000181165350
	
			internal static class Try_000000A0_BurstDirectCall // TypeDefIndex: 57203
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Try_000000A0_BurstDirectCall() {} // 0x0000000183CE9B70-0x0000000183CE9B80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00078c08) {} // 0x0000000189B67754-0x0000000189B67858
				private static IntPtr GetFunctionPointer() => default; // 0x0000000189B67858-0x0000000189B678AC
				public static void Constructor() {} // 0x0000000183CE9B80-0x0000000183CE9C10
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static int Invoke(IntPtr allocatorState, ref Block block) => default; // 0x0000000189B678AC-0x0000000189B67938
			}
	
			// Methods
			public int Try(ref Block block) => default; // 0x0000000189B675A0-0x0000000189B6762C
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try(IntPtr allocatorState, ref Block block) => default; // 0x0000000189B67544-0x0000000189B675A0
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try_BurstManaged(IntPtr allocatorState, ref Block block) => default; // 0x0000000189B6753C-0x0000000189B67544
		}
	
		[BurstCompile(CompileSynchronously = true)]
		internal struct SlabAllocator : IAllocator // TypeDefIndex: 57207
		{
			// Fields
			internal AllocatorHandle m_handle; // 0x00
			internal Block Storage; // 0x08
			internal int Log2SlabSizeInBytes; // 0x28
			internal FixedList4096Bytes<int> Occupied; // 0x2C
			internal long budgetInBytes; // 0x1030
			internal long allocatedBytes; // 0x1038
	
			// Properties
			public AllocatorHandle Handle { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
			internal int SlabSizeInBytes { get => default; } // 0x0000000183D76890-0x0000000183D768A0 
	
			// Nested types
			public delegate int Try_000000AE_PostfixBurstDelegate(IntPtr allocatorState, ref Block block); // TypeDefIndex: 57205; 0x0000000181165340-0x0000000181165350
	
			internal static class Try_000000AE_BurstDirectCall // TypeDefIndex: 57206
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Try_000000AE_BurstDirectCall() {} // 0x0000000183CE9AD0-0x0000000183CE9AE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00078c14) {} // 0x0000000189B67938-0x0000000189B67A3C
				private static IntPtr GetFunctionPointer() => default; // 0x0000000189B67A3C-0x0000000189B67A90
				public static void Constructor() {} // 0x0000000183CE9AE0-0x0000000183CE9B70
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static int Invoke(IntPtr allocatorState, ref Block block) => default; // 0x0000000189B67A90-0x0000000189B67B1C
			}
	
			// Methods
			public int Try(ref Block block) => default; // 0x0000000189B67320-0x0000000189B6750C
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try(IntPtr allocatorState, ref Block block) => default; // 0x0000000189B672C4-0x0000000189B67320
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
			[BurstCompile(CompileSynchronously = true)]
			[AOT.MonoPInvokeCallback(typeof(TryFunction))]
			public static int Try_BurstManaged(IntPtr allocatorState, ref Block block) => default; // 0x0000000189B672BC-0x0000000189B672C4
		}
	
		internal struct TableEntry // TypeDefIndex: 57208
		{
			// Fields
			internal IntPtr function; // 0x00
			internal IntPtr state; // 0x08
		}
	
		internal struct Array16<T> // TypeDefIndex: 57209
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
	
		internal struct Array256<T> // TypeDefIndex: 57210
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
	
		internal struct Array4096<T> // TypeDefIndex: 57211
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
	
		internal struct Array32768<T> : IIndexable<T> // TypeDefIndex: 57212
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
			public int Length { get => default; }
	
			// Methods
			public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
			private ref T _refReturnTypeForElementAt; // Dummy field
		}
	
		internal sealed class SharedStatics // TypeDefIndex: 57214
		{
			// Nested types
			internal sealed class TableEntry // TypeDefIndex: 57213
			{
				// Fields
				internal static readonly SharedStatic<Array32768<AllocatorManager.TableEntry>> Ref; // 0x00
	
				// Constructors
				public TableEntry() {} // Dummy constructor
				static TableEntry() {} // 0x0000000189B6762C-0x0000000189B6768C
			}
	
			// Constructors
			public SharedStatics() {} // Dummy constructor
		}
	
		internal static class Managed // TypeDefIndex: 57215
		{
			// Fields
			internal static TryFunction[] TryFunctionDelegates; // 0x00
	
			// Constructors
			static Managed() {} // 0x0000000189B66B44-0x0000000189B66BAC
		}
	
		// Constructors
		static AllocatorManager() {} // 0x0000000183C788A0-0x0000000183C78A80
	
		// Methods
		public static unsafe void* Allocate(AllocatorHandle handle, int itemSizeInBytes, int alignmentInBytes, int items = 1 /* Metadata: 0x01FD9C4C */) => default; // 0x00000001826E9100-0x00000001826E92F0
		public static unsafe T* Allocate<T>(AllocatorHandle handle, int items = 1 /* Metadata: 0x01FD9C4D */)
			where T : struct => default;
		public static unsafe void Free(AllocatorHandle handle, void* pointer) {} // 0x0000000189B635E4-0x0000000189B63644
		public static unsafe void Free<T>(AllocatorHandle handle, T* pointer, int items = 1 /* Metadata: 0x01FD9C4E */)
			where T : struct {}
		[BurstDiscard]
		private static void CheckDelegate(ref bool useDelegate) {} // 0x0000000183D5BC00-0x0000000183D5BC10
		private static bool UseDelegate() => default; // 0x0000000189B63644-0x0000000189B63680
		private static int allocate_block(ref Block block) => default; // 0x0000000189B63680-0x0000000189B63710
		[BurstDiscard]
		private static void forward_mono_allocate_block(ref Block block, ref int error) {} // 0x0000000189B63710-0x0000000189B63818
		internal static Unity.Collections.Allocator LegacyOf(AllocatorHandle handle) => default; // 0x0000000182419AF0-0x0000000182419B00
		private static int TryLegacy(ref Block block) => default; // 0x00000001824183B0-0x0000000182418540
		public static int Try(ref Block block) => default; // 0x0000000182419BB0-0x0000000182419C70
		internal static bool IsCustomAllocator(AllocatorHandle allocator) => default; // 0x0000000182419E00-0x0000000182419E10
		public static void Initialize_StackAllocator_Try_000000A0_BurstDirectCall() {} // 0x0000000183C84040-0x0000000183C84080
		public static void Initialize_SlabAllocator_Try_000000AE_BurstDirectCall() {} // 0x0000000183C84000-0x0000000183C84040
	
		// Extension methods
		internal static Block AllocateBlock<T>(this ref ref T t, int sizeOf, int alignOf, int items)
			where T : struct, IAllocator => default;
		internal static unsafe void* Allocate<T>(this ref ref T t, int sizeOf, int alignOf, int items)
			where T : struct, IAllocator => default;
		internal static unsafe U* Allocate<T, U>(this ref ref T t, U u, int items)
			where T : struct, IAllocator
			where U : struct => default;
		internal static unsafe void* AllocateStruct<T, U>(this ref ref T t, U u, int items)
			where T : struct, IAllocator
			where U : struct => default;
		internal static void FreeBlock<T>(this ref ref T t, ref Block block)
			where T : struct, IAllocator {}
		internal static unsafe void Free<T>(this ref ref T t, void* pointer, int sizeOf, int alignOf, int items)
			where T : struct, IAllocator {}
		internal static unsafe void Free<T, U>(this ref ref T t, U* pointer, int items)
			where T : struct, IAllocator
			where U : struct {}
	}

	internal class CreatePropertyAttribute : Attribute // TypeDefIndex: 57217
	{
		// Constructors
		public CreatePropertyAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[BurstCompatible]
	internal struct Bitwise // TypeDefIndex: 57218
	{
		// Methods
		internal static int FromBool(bool value) => default; // 0x0000000182C9E0C0-0x0000000182C9E0D0
		internal static uint ExtractBits(uint input, int pos, uint mask) => default; // 0x0000000183D767C0-0x0000000183D767D0
		internal static uint ReplaceBits(uint input, int pos, uint mask, uint value) => default; // 0x0000000183D76800-0x0000000183D76820
		internal static uint SetBits(uint input, int pos, uint mask, bool value) => default; // 0x0000000182C9E070-0x0000000182C9E090
		internal static ulong ExtractBits(ulong input, int pos, ulong mask) => default; // 0x0000000183D767B0-0x0000000183D767C0
		internal static ulong ReplaceBits(ulong input, int pos, ulong mask, ulong value) => default; // 0x0000000183D767D0-0x0000000183D76800
		internal static ulong SetBits(ulong input, int pos, ulong mask, bool value) => default; // 0x0000000182C9E090-0x0000000182C9E0C0
	}

	[BurstCompatible]
	[DebuggerTypeProxy(typeof(BitField32DebugView))]
	public struct BitField32 // TypeDefIndex: 57219
	{
		// Fields
		public uint Value; // 0x00
	
		// Methods
		public void SetBits(int pos, bool value) {} // 0x0000000184271974-0x00000001842719A0
		public uint GetBits(int pos, int numBits = 1 /* Metadata: 0x01FD9C4F */) => default; // 0x0000000183D76760-0x0000000183D76780
		public bool IsSet(int pos) => default; // 0x00000001827B29B0-0x00000001827B29C0
	}

	internal sealed class BitField32DebugView // TypeDefIndex: 57220
	{
		// Constructors
		public BitField32DebugView() {} // Dummy constructor
	}

	[BurstCompatible]
	[DebuggerTypeProxy(typeof(BitField64DebugView))]
	public struct BitField64 // TypeDefIndex: 57221
	{
		// Fields
		public ulong Value; // 0x00
	
		// Methods
		public void SetBits(int pos, bool value) {} // 0x0000000184271940-0x0000000184271974
		public ulong GetBits(int pos, int numBits = 1 /* Metadata: 0x01FD9C50 */) => default; // 0x0000000183D76780-0x0000000183D767B0
		public bool IsSet(int pos) => default; // 0x0000000183522A10-0x0000000183522A30
		public bool TestAny(int pos, int numBits = 1 /* Metadata: 0x01FD9C51 */) => default; // 0x0000000182BB8B30-0x0000000182BB8B60
	}

	internal sealed class BitField64DebugView // TypeDefIndex: 57222
	{
		// Constructors
		public BitField64DebugView() {} // Dummy constructor
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
	public class BurstCompatibleAttribute : Attribute // TypeDefIndex: 57223
	{
		// Fields
		public string RequiredUnityDefine; // 0x18
	
		// Properties
		public System.Type[] GenericTypeArguments { get; set; } // 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public BurstCompatibleAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	public class NotBurstCompatibleAttribute : Attribute // TypeDefIndex: 57224
	{
		// Constructors
		public NotBurstCompatibleAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public interface INativeDisposable : IDisposable // TypeDefIndex: 57225
	{
	}

	[BurstCompatible]
	public static class CollectionHelper // TypeDefIndex: 57226
	{
		// Methods
		public static int Log2Floor(int value) => default; // 0x0000000184D32A74-0x0000000184D32EC4
		public static int Align(int size, int alignmentPowerOfTwo) => default; // 0x00000001829CFD40-0x00000001829CFD60
		public static unsafe uint Hash(void* ptr, int bytes) => default; // 0x00000001834F72D0-0x00000001834F7300
		internal static bool ShouldDeallocate(AllocatorManager.AllocatorHandle allocator) => default; // 0x00000001831BE040-0x00000001831BE060
		internal static int AssumePositive(int value) => default; // 0x0000000183D517B0-0x0000000183D517C0
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static NativeArray<T> CreateNativeArray<T>(int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x01FD9C52 */)
			where T : struct => default;
		[NotBurstCompatible]
		public static NativeArray<T> CreateNativeArray<T>(T[] array, AllocatorManager.AllocatorHandle allocator)
			where T : struct => default;
	}

	[BurstCompatible]
	internal struct FixedList // TypeDefIndex: 57227
	{
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		internal static int PaddingBytes<T>()
			where T : struct => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static int StorageBytes<BUFFER, T>()
			where BUFFER : struct
			where T : struct => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static int Capacity<BUFFER, T>()
			where BUFFER : struct
			where T : struct => default;
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList32BytesDebugView<T>))]
	public struct FixedList32Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 57228
		where T : struct
	{
		// Fields
		[SerializeField]
		internal ushort length;
		[SerializeField]
		internal FixedBytes30 buffer;
	
		// Properties
		[CreateProperty]
		public int Length { get => default; set {} }
		internal int LengthInBytes { get => default; }
		internal unsafe byte* Buffer { get => default; }
		public int Capacity { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Methods
		public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
		private ref T _refReturnTypeForElementAt; // Dummy field
		public override int GetHashCode() => default;
		public void Add([IsReadOnly] in ref T item) {}
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
		[NotBurstCompatible]
		public override bool Equals(object obj) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	}

	[BurstCompatible]
	public static class FixedList32BytesExtensions // TypeDefIndex: 57229
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList32Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList32Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
	}

	internal sealed class FixedList32BytesDebugView<T> // TypeDefIndex: 57230
		where T : struct
	{
		// Constructors
		public FixedList32BytesDebugView() {} // Dummy constructor
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList64BytesDebugView<T>))]
	public struct FixedList64Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 57231
		where T : struct
	{
		// Fields
		[SerializeField]
		internal ushort length;
		[SerializeField]
		internal FixedBytes62 buffer;
	
		// Properties
		[CreateProperty]
		public int Length { get => default; set {} }
		internal int LengthInBytes { get => default; }
		internal unsafe byte* Buffer { get => default; }
		public int Capacity { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Methods
		public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
		private ref T _refReturnTypeForElementAt; // Dummy field
		public override int GetHashCode() => default;
		public void Add([IsReadOnly] in ref T item) {}
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
		[NotBurstCompatible]
		public override bool Equals(object obj) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	}

	[BurstCompatible]
	public static class FixedList64BytesExtensions // TypeDefIndex: 57232
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList64Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList64Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
	}

	internal sealed class FixedList64BytesDebugView<T> // TypeDefIndex: 57233
		where T : struct
	{
		// Constructors
		public FixedList64BytesDebugView() {} // Dummy constructor
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList128BytesDebugView<T>))]
	public struct FixedList128Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 57234
		where T : struct
	{
		// Fields
		[SerializeField]
		internal ushort length;
		[SerializeField]
		internal FixedBytes126 buffer;
	
		// Properties
		[CreateProperty]
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
		public void Add([IsReadOnly] in ref T item) {}
		public void AddNoResize([IsReadOnly] in ref T item) {}
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
		[NotBurstCompatible]
		public override bool Equals(object obj) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	}

	[BurstCompatible]
	public static class FixedList128BytesExtensions // TypeDefIndex: 57235
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList128Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList128Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Remove<T, U>(this ref FixedList128Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
	}

	internal sealed class FixedList128BytesDebugView<T> // TypeDefIndex: 57236
		where T : struct
	{
		// Constructors
		public FixedList128BytesDebugView() {} // Dummy constructor
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList512BytesDebugView<T>))]
	public struct FixedList512Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 57238
		where T : struct
	{
		// Fields
		[SerializeField]
		internal ushort length;
		[SerializeField]
		internal FixedBytes510 buffer;
	
		// Properties
		[CreateProperty]
		public int Length { get => default; set {} }
		public bool IsEmpty { get => default; }
		internal int LengthInBytes { get => default; }
		internal unsafe byte* Buffer { get => default; }
		public int Capacity { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 57237
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
		public void Add([IsReadOnly] in ref T item) {}
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
		[NotBurstCompatible]
		public override bool Equals(object obj) => default;
		public Enumerator GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	}

	[BurstCompatible]
	public static class FixedList512BytesExtensions // TypeDefIndex: 57239
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList512Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList512Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Remove<T, U>(this ref FixedList512Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
	}

	internal sealed class FixedList512BytesDebugView<T> // TypeDefIndex: 57240
		where T : struct
	{
		// Constructors
		public FixedList512BytesDebugView() {} // Dummy constructor
	}

	[Serializable]
	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(FixedList4096BytesDebugView<T>))]
	public struct FixedList4096Bytes<T> : INativeList<T>, IEnumerable<T>, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 57241
		where T : struct
	{
		// Fields
		[SerializeField]
		internal ushort length;
		[SerializeField]
		internal FixedBytes4094 buffer;
	
		// Properties
		[CreateProperty]
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
		public void Add([IsReadOnly] in ref T item) {}
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
		[NotBurstCompatible]
		public override bool Equals(object obj) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	}

	[BurstCompatible]
	public static class FixedList4096BytesExtensions // TypeDefIndex: 57242
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static int IndexOf<T, U>(this ref FixedList4096Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this ref FixedList4096Bytes<T> list, U value)
			where T : struct, IEquatable<U> => default;
	}

	internal sealed class FixedList4096BytesDebugView<T> // TypeDefIndex: 57243
		where T : struct
	{
		// Constructors
		public FixedList4096BytesDebugView() {} // Dummy constructor
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes16 // TypeDefIndex: 57244
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
	public struct FixedBytes30 // TypeDefIndex: 57245
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
	public struct FixedString32Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 57246
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 29; // Metadata: 0x01FD9C54
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes30 bytes; // 0x02
	
		// Properties
		[CreateProperty]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[NotBurstCompatible]
		public string Value { get => default; } // 0x0000000184270A90-0x0000000184270A98 
		public int Length { get => default; set {} } // 0x0000000183D4F990-0x0000000183D4F9A0 0x0000000183D76860-0x0000000183D76870
		public bool IsEmpty { get => default; } // 0x0000000189B64878-0x0000000189B64880 
	
		// Constructors
		[NotBurstCompatible]
		public FixedString32Bytes(string source) : this() {
			utf8LengthInBytes = default;
			bytes = default;
		} // 0x0000000182765C00-0x0000000182765C20
	
		// Methods
		public unsafe byte* GetUnsafePtr() => default; // 0x0000000183D76850-0x0000000183D76860
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x01FD9C53 */) => default; // 0x0000000189B6480C-0x0000000189B64878
		[NotBurstCompatible]
		public int CompareTo(string other) => default; // 0x0000000189B64364-0x0000000189B64398
		[NotBurstCompatible]
		public bool Equals(string other) => default; // 0x0000000189B6447C-0x0000000189B64500
		[NotBurstCompatible]
		internal int Initialize(string source) => default; // 0x0000000182765C20-0x0000000182765D60
		public int CompareTo(FixedString32Bytes other) => default; // 0x0000000189B643E4-0x0000000189B64430
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString32Bytes b) => default; // 0x0000000189B6490C-0x0000000189B6498C
		public bool Equals(FixedString32Bytes other) => default; // 0x0000000189B64528-0x0000000189B6453C
		public int CompareTo(FixedString64Bytes other) => default; // 0x0000000189B64430-0x0000000189B6447C
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString64Bytes b) => default; // 0x0000000189B64880-0x0000000189B6490C
		public bool Equals(FixedString64Bytes other) => default; // 0x0000000189B64514-0x0000000189B64528
		public int CompareTo(FixedString128Bytes other) => default; // 0x0000000189B64318-0x0000000189B64364
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString128Bytes b) => default; // 0x0000000189B64A18-0x0000000189B64AA4
		public bool Equals(FixedString128Bytes other) => default; // 0x0000000189B6453C-0x0000000189B64550
		public int CompareTo(FixedString512Bytes other) => default; // 0x0000000189B642CC-0x0000000189B64318
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString512Bytes b) => default; // 0x0000000189B6498C-0x0000000189B64A18
		public bool Equals(FixedString512Bytes other) => default; // 0x0000000189B64500-0x0000000189B64514
		public int CompareTo(FixedString4096Bytes other) => default; // 0x0000000189B64398-0x0000000189B643E4
		public static bool operator ==([IsReadOnly] in FixedString32Bytes a, [IsReadOnly] in FixedString4096Bytes b) => default; // 0x0000000189B64AA4-0x0000000189B64B30
		public bool Equals(FixedString4096Bytes other) => default; // 0x0000000189B647F8-0x0000000189B6480C
		[NotBurstCompatible]
		public static implicit operator FixedString32Bytes(string b) => default; // 0x0000000182765BD0-0x0000000182765C00
		[NotBurstCompatible]
		public override string ToString() => default; // 0x0000000183282350-0x0000000183282390
		public override int GetHashCode() => default; // 0x00000001832807F0-0x0000000183280830
		[NotBurstCompatible]
		public override bool Equals(object obj) => default; // 0x0000000189B64550-0x0000000189B647F8
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes62 // TypeDefIndex: 57247
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
	public struct FixedString64Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 57248
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 61; // Metadata: 0x01FD9C57
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes62 bytes; // 0x02
	
		// Properties
		[CreateProperty]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[NotBurstCompatible]
		public string Value { get => default; } // 0x0000000184272580-0x0000000184272588 
		public int Length { get => default; set {} } // 0x0000000183D4F990-0x0000000183D4F9A0 0x0000000183D76860-0x0000000183D76870
		public bool IsEmpty { get => default; } // 0x0000000189B64878-0x0000000189B64880 
	
		// Constructors
		[NotBurstCompatible]
		public FixedString64Bytes(string source) : this() {
			utf8LengthInBytes = default;
			bytes = default;
		} // 0x0000000182767010-0x0000000182767030
	
		// Methods
		public unsafe byte* GetUnsafePtr() => default; // 0x0000000183D76850-0x0000000183D76860
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x01FD9C56 */) => default; // 0x0000000189B6625C-0x0000000189B662C8
		[NotBurstCompatible]
		public int CompareTo(string other) => default; // 0x0000000189B65DC4-0x0000000189B65DF8
		[NotBurstCompatible]
		public bool Equals(string other) => default; // 0x0000000189B66174-0x0000000189B661F8
		[NotBurstCompatible]
		internal int Initialize(string source) => default; // 0x0000000182767030-0x0000000182767170
		public int CompareTo(FixedString32Bytes other) => default; // 0x0000000189B65DF8-0x0000000189B65E44
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString32Bytes b) => default; // 0x0000000189B663E0-0x0000000189B6646C
		public bool Equals(FixedString32Bytes other) => default; // 0x0000000189B66138-0x0000000189B6614C
		public int CompareTo(FixedString64Bytes other) => default; // 0x0000000189B65E44-0x0000000189B65E90
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString64Bytes b) => default; // 0x0000000189B6646C-0x0000000189B664EC
		public bool Equals(FixedString64Bytes other) => default; // 0x0000000189B66160-0x0000000189B66174
		public int CompareTo(FixedString128Bytes other) => default; // 0x0000000189B65D2C-0x0000000189B65D78
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString128Bytes b) => default; // 0x0000000189B66354-0x0000000189B663E0
		public bool Equals(FixedString128Bytes other) => default; // 0x0000000189B6614C-0x0000000189B66160
		public int CompareTo(FixedString512Bytes other) => default; // 0x0000000189B65CE0-0x0000000189B65D2C
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString512Bytes b) => default; // 0x0000000189B662C8-0x0000000189B66354
		public bool Equals(FixedString512Bytes other) => default; // 0x0000000189B661F8-0x0000000189B6620C
		public int CompareTo(FixedString4096Bytes other) => default; // 0x0000000189B65D78-0x0000000189B65DC4
		public static bool operator ==([IsReadOnly] in FixedString64Bytes a, [IsReadOnly] in FixedString4096Bytes b) => default; // 0x0000000189B664EC-0x0000000189B66578
		public bool Equals(FixedString4096Bytes other) => default; // 0x0000000189B6620C-0x0000000189B66220
		[NotBurstCompatible]
		public static implicit operator FixedString64Bytes(string b) => default; // 0x0000000182766FE0-0x0000000182767010
		[NotBurstCompatible]
		public override string ToString() => default; // 0x0000000183113D70-0x0000000183113EA0
		public override int GetHashCode() => default; // 0x0000000189B66220-0x0000000189B6625C
		[NotBurstCompatible]
		public override bool Equals(object obj) => default; // 0x0000000189B65E90-0x0000000189B66138
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes126 // TypeDefIndex: 57249
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
	public struct FixedString128Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 57250
	{
		// Fields
		internal const ushort utf8MaxLengthInBytes = 125; // Metadata: 0x01FD9C5A
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes126 bytes; // 0x02
	
		// Properties
		public int Length { get => default; set {} } // 0x0000000183D4F990-0x0000000183D4F9A0 0x0000000183D76860-0x0000000183D76870
	
		// Constructors
		[NotBurstCompatible]
		public FixedString128Bytes(string source) : this() {
			utf8LengthInBytes = default;
			bytes = default;
		} // 0x0000000182CF9A60-0x0000000182CF9A90
	
		// Methods
		public unsafe byte* GetUnsafePtr() => default; // 0x0000000183D76850-0x0000000183D76860
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x01FD9C59 */) => default; // 0x0000000189B63FB0-0x0000000189B6401C
		[NotBurstCompatible]
		public int CompareTo(string other) => default; // 0x0000000189B63ADC-0x0000000189B63B10
		[NotBurstCompatible]
		public bool Equals(string other) => default; // 0x0000000189B63BF8-0x0000000189B63C7C
		[NotBurstCompatible]
		internal int Initialize(string source) => default; // 0x0000000182CF9A90-0x0000000182CF9B10
		public int CompareTo(FixedString32Bytes other) => default; // 0x0000000189B63B5C-0x0000000189B63BA8
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString32Bytes b) => default; // 0x0000000189B640A8-0x0000000189B64134
		public bool Equals(FixedString32Bytes other) => default; // 0x0000000189B63BE4-0x0000000189B63BF8
		public int CompareTo(FixedString64Bytes other) => default; // 0x0000000189B63B10-0x0000000189B63B5C
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString64Bytes b) => default; // 0x0000000189B641B4-0x0000000189B64240
		public bool Equals(FixedString64Bytes other) => default; // 0x0000000189B63C7C-0x0000000189B63C90
		public int CompareTo(FixedString128Bytes other) => default; // 0x0000000189B63A44-0x0000000189B63A90
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString128Bytes b) => default; // 0x0000000189B64134-0x0000000189B641B4
		public bool Equals(FixedString128Bytes other) => default; // 0x0000000189B63BD0-0x0000000189B63BE4
		public int CompareTo(FixedString512Bytes other) => default; // 0x0000000189B63A90-0x0000000189B63ADC
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString512Bytes b) => default; // 0x0000000189B6401C-0x0000000189B640A8
		public bool Equals(FixedString512Bytes other) => default; // 0x0000000189B63BA8-0x0000000189B63BBC
		public int CompareTo(FixedString4096Bytes other) => default; // 0x0000000189B639F8-0x0000000189B63A44
		public static bool operator ==([IsReadOnly] in FixedString128Bytes a, [IsReadOnly] in FixedString4096Bytes b) => default; // 0x0000000189B64240-0x0000000189B642CC
		public bool Equals(FixedString4096Bytes other) => default; // 0x0000000189B63BBC-0x0000000189B63BD0
		[NotBurstCompatible]
		public static implicit operator FixedString128Bytes(string b) => default; // 0x0000000182CF9A20-0x0000000182CF9A60
		[NotBurstCompatible]
		public override string ToString() => default; // 0x0000000189B63F74-0x0000000189B63FB0
		public override int GetHashCode() => default; // 0x0000000189B63F38-0x0000000189B63F74
		[NotBurstCompatible]
		public override bool Equals(object obj) => default; // 0x0000000189B63C90-0x0000000189B63F38
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes510 // TypeDefIndex: 57251
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
	public struct FixedString512Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 57252
	{
		// Fields
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes510 bytes; // 0x02
	
		// Properties
		public int Length { get => default; } // 0x0000000183D4F990-0x0000000183D4F9A0 
	
		// Methods
		public unsafe byte* GetUnsafePtr() => default; // 0x0000000183D76850-0x0000000183D76860
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x01FD9C5C */) => default; // 0x0000000189B659C0-0x0000000189B65A30
		[NotBurstCompatible]
		public int CompareTo(string other) => default; // 0x0000000189B65538-0x0000000189B6556C
		[NotBurstCompatible]
		public bool Equals(string other) => default; // 0x0000000189B658C4-0x0000000189B65948
		public int CompareTo(FixedString32Bytes other) => default; // 0x0000000189B6556C-0x0000000189B655B8
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString32Bytes b) => default; // 0x0000000189B65C54-0x0000000189B65CE0
		public bool Equals(FixedString32Bytes other) => default; // 0x0000000189B655CC-0x0000000189B655E0
		public int CompareTo(FixedString64Bytes other) => default; // 0x0000000189B654A0-0x0000000189B654EC
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString64Bytes b) => default; // 0x0000000189B65BC8-0x0000000189B65C54
		public bool Equals(FixedString64Bytes other) => default; // 0x0000000189B655B8-0x0000000189B655CC
		public int CompareTo(FixedString128Bytes other) => default; // 0x0000000189B65454-0x0000000189B654A0
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString128Bytes b) => default; // 0x0000000189B65AB0-0x0000000189B65B3C
		public bool Equals(FixedString128Bytes other) => default; // 0x0000000189B6589C-0x0000000189B658B0
		public int CompareTo(FixedString512Bytes other) => default; // 0x0000000189B65408-0x0000000189B65454
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString512Bytes b) => default; // 0x0000000189B65A30-0x0000000189B65AB0
		public bool Equals(FixedString512Bytes other) => default; // 0x0000000189B65888-0x0000000189B6589C
		public int CompareTo(FixedString4096Bytes other) => default; // 0x0000000189B654EC-0x0000000189B65538
		public static bool operator ==([IsReadOnly] in FixedString512Bytes a, [IsReadOnly] in FixedString4096Bytes b) => default; // 0x0000000189B65B3C-0x0000000189B65BC8
		public bool Equals(FixedString4096Bytes other) => default; // 0x0000000189B658B0-0x0000000189B658C4
		[NotBurstCompatible]
		public override string ToString() => default; // 0x0000000189B65984-0x0000000189B659C0
		public override int GetHashCode() => default; // 0x0000000189B65948-0x0000000189B65984
		[NotBurstCompatible]
		public override bool Equals(object obj) => default; // 0x0000000189B655E0-0x0000000189B65888
	}

	[Serializable]
	[BurstCompatible]
	public struct FixedBytes4094 // TypeDefIndex: 57253
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
	public struct FixedString4096Bytes : INativeList<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes> // TypeDefIndex: 57254
	{
		// Fields
		[SerializeField]
		internal ushort utf8LengthInBytes; // 0x00
		[SerializeField]
		internal FixedBytes4094 bytes; // 0x02
	
		// Properties
		public int Length { get => default; } // 0x0000000183D4F990-0x0000000183D4F9A0 
	
		// Methods
		public unsafe byte* GetUnsafePtr() => default; // 0x0000000183D76850-0x0000000183D76860
		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x01FD9C5D */) => default; // 0x0000000189B650E8-0x0000000189B65158
		[NotBurstCompatible]
		public int CompareTo(string other) => default; // 0x0000000189B64CAC-0x0000000189B64CE0
		[NotBurstCompatible]
		public bool Equals(string other) => default; // 0x0000000189B64CF4-0x0000000189B64D78
		public int CompareTo(FixedString32Bytes other) => default; // 0x0000000189B64C14-0x0000000189B64C60
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString32Bytes b) => default; // 0x0000000189B65264-0x0000000189B652F0
		public bool Equals(FixedString32Bytes other) => default; // 0x0000000189B65048-0x0000000189B6505C
		public int CompareTo(FixedString64Bytes other) => default; // 0x0000000189B64C60-0x0000000189B64CAC
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString64Bytes b) => default; // 0x0000000189B651D8-0x0000000189B65264
		public bool Equals(FixedString64Bytes other) => default; // 0x0000000189B6505C-0x0000000189B65070
		public int CompareTo(FixedString128Bytes other) => default; // 0x0000000189B64BC8-0x0000000189B64C14
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString128Bytes b) => default; // 0x0000000189B652F0-0x0000000189B6537C
		public bool Equals(FixedString128Bytes other) => default; // 0x0000000189B64D78-0x0000000189B64D8C
		public int CompareTo(FixedString512Bytes other) => default; // 0x0000000189B64B30-0x0000000189B64B7C
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString512Bytes b) => default; // 0x0000000189B6537C-0x0000000189B65408
		public bool Equals(FixedString512Bytes other) => default; // 0x0000000189B64D8C-0x0000000189B64DA0
		public int CompareTo(FixedString4096Bytes other) => default; // 0x0000000189B64B7C-0x0000000189B64BC8
		public static bool operator ==([IsReadOnly] in FixedString4096Bytes a, [IsReadOnly] in FixedString4096Bytes b) => default; // 0x0000000189B65158-0x0000000189B651D8
		public bool Equals(FixedString4096Bytes other) => default; // 0x0000000189B64CE0-0x0000000189B64CF4
		[NotBurstCompatible]
		public override string ToString() => default; // 0x0000000189B650AC-0x0000000189B650E8
		public override int GetHashCode() => default; // 0x0000000189B65070-0x0000000189B650AC
		[NotBurstCompatible]
		public override bool Equals(object obj) => default; // 0x0000000189B64DA0-0x0000000189B65048
	}

	[BurstCompatible]
	[BurstCompatible]
	[BurstCompatible]
	[BurstCompatible]
	public static class FixedStringMethods // TypeDefIndex: 57255
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(FixedString128Bytes) })]
		public static unsafe FormatError Append<T>(this ref ref T fs, byte* utf8Bytes, int utf8BytesLength)
			where T : struct, INativeList<byte>, IUTF8Bytes => default;
		[NotBurstCompatible]
		public static FormatError Append<T>(this ref ref T fs, string s)
			where T : struct, INativeList<byte>, IUTF8Bytes => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(FixedString128Bytes) })]
		public static unsafe int CompareTo<T>(this ref ref T fs, byte* bytes, int bytesLen)
			where T : struct, INativeList<byte>, IUTF8Bytes => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(FixedString128Bytes), typeof(FixedString128Bytes) })]
		public static int CompareTo<T, T2>(this ref ref T fs, [IsReadOnly] in ref T2 other)
			where T : struct, INativeList<byte>, IUTF8Bytes
			where T2 : struct, INativeList<byte>, IUTF8Bytes => default;
		[NotBurstCompatible]
		public static string ConvertToString<T>(this ref ref T fs)
			where T : struct, INativeList<byte>, IUTF8Bytes => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(FixedString128Bytes) })]
		public static int ComputeHashCode<T>(this ref ref T fs)
			where T : struct, INativeList<byte>, IUTF8Bytes => default;
	}

	public interface IUTF8Bytes // TypeDefIndex: 57256
	{
		// Methods
		byte* GetUnsafePtr();
		bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory /* Metadata: 0x01FD9C5E */);
	}

	public static class ListExtensions // TypeDefIndex: 57257
	{
		// Extension methods
		public static bool RemoveSwapBack<T>(this List<T> list, T value) => default;
		public static void RemoveAtSwapBack<T>(this List<T> list, int index) {}
		public static NativeArray<T> ToNativeArray<T>(this List<T> list, AllocatorManager.AllocatorHandle allocator)
			where T : struct => default;
	}

	[BurstCompatible]
	internal struct Memory // TypeDefIndex: 57260
	{
		// Nested types
		[BurstCompatible]
		internal struct Unmanaged // TypeDefIndex: 57259
		{
			// Nested types
			[BurstCompatible]
			internal struct Array // TypeDefIndex: 57258
			{
				// Methods
				private static bool IsCustom(AllocatorManager.AllocatorHandle allocator) => default; // 0x0000000182419E00-0x0000000182419E10
				private static unsafe void* CustomResize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align) => default; // 0x0000000189B63818-0x0000000189B638BC
				internal static unsafe void* Resize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align) => default; // 0x0000000182419CF0-0x0000000182419E00
				[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
				internal static unsafe T* Resize<T>(T* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator)
					where T : struct => default;
			}
	
			// Methods
			internal static unsafe void* Allocate(long size, int align, AllocatorManager.AllocatorHandle allocator) => default; // 0x0000000182419CC0-0x0000000182419CF0
			internal static unsafe void Free(void* pointer, AllocatorManager.AllocatorHandle allocator) {} // 0x00000001831BE060-0x00000001831BE0A0
			[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
			internal static unsafe void Free<T>(T* pointer, AllocatorManager.AllocatorHandle allocator)
				where T : struct {}
		}
	}

	[BurstCompatible]
	public static class NativeArrayExtensions // TypeDefIndex: 57261
	{
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static unsafe int IndexOf<T, U>(void* ptr, int length, U value)
			where T : struct, IEquatable<U> => default;
	
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static bool Contains<T, U>(this NativeList<T> list, U value)
			where T : struct, IEquatable<U> => default;
		public static Span<T> AsSpan<T>(this NativeArray<T> array)
			where T : struct => default;
		public static Span<T> AsSpanThread<T>(this NativeArray<T> array)
			where T : struct => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static NativeArray<U> Reinterpret<T, U>(this NativeArray<T> array)
			where T : struct
			where U : struct => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		internal static void Initialize<T>(this ref NativeArray<T> array, int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x01FD9C5F */)
			where T : struct {}
	}

	public interface IIndexable<T> // TypeDefIndex: 57262
		where T : struct
	{
		// Properties
		int Length { get; }
	}

	[DefaultMember("Item")]
	public interface INativeList<T> : IIndexable<T> // TypeDefIndex: 57263
		where T : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(NativeListDebugView<T>))]
	[NativeContainer]
	public struct NativeList<T> : INativeDisposable, INativeList<T>, IEnumerable<T> // TypeDefIndex: 57265
		where T : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeList<T>* m_ListData;
		internal AllocatorManager.AllocatorHandle m_DeprecatedAllocator;
	
		// Properties
		public T this[int index] { get => default; set {} }
		public int Length { get => default; }
		public int Capacity { get => default; set {} }
		public bool IsEmpty { get => default; }
		public bool IsCreated { get => default; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 57264
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
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
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(AllocatorManager.AllocatorHandle) })]
		internal void Initialize<U>(int initialCapacity, ref ref U allocator, int disposeSentinelStackDepth)
			where U : struct, AllocatorManager.IAllocator {}
		public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
		private ref T _refReturnTypeForElementAt; // Dummy field
		public unsafe UnsafeList<T>* GetUnsafeList() => default;
		public void AddNoResize(T value) {}
		public unsafe void AddRangeNoResize(void* ptr, int count) {}
		public void Add([IsReadOnly] in ref T value) {}
		public void AddRange(NativeArray<T> array) {}
		public unsafe void AddRange(void* ptr, int count) {}
		public void RemoveAtSwapBack(int index) {}
		public void RemoveAt(int index) {}
		public void RemoveRange(int index, int count) {}
		public void Dispose() {}
		[NotBurstCompatible]
		public JobHandle Dispose(JobHandle inputDeps) => default;
		[NotBurstCompatible]
		public JobHandle CrossFrameDispose(JobHandle inputDeps, JobQueuePriority priority = JobQueuePriority.NormalJobPriority /* Metadata: 0x01FD9C60 */) => default;
		public void Clear() {}
		public static implicit operator NativeArray<T>(NativeList<T> nativeList) => default;
		public NativeArray<T> AsArray() => default;
		public NativeArray<T> AsDeferredJobArray() => default;
		[NotBurstCompatible]
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

	[BurstCompatible]
	[NativeContainer]
	internal struct NativeListDispose // TypeDefIndex: 57266
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe UntypedUnsafeList* m_ListData; // 0x00
	
		// Methods
		public void Dispose() {} // 0x0000000189B66D5C-0x0000000189B66D98
	}

	[BurstCompatible]
	[BurstCompile]
	internal struct NativeListDisposeJob : IJob // TypeDefIndex: 57267
	{
		// Fields
		internal NativeListDispose Data; // 0x00
	
		// Methods
		public void Execute() {} // 0x0000000189B66D54-0x0000000189B66D5C
	}

	internal sealed class NativeListDebugView<T> // TypeDefIndex: 57268
		where T : struct
	{
		// Constructors
		public NativeListDebugView() {} // Dummy constructor
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy<TKey, TValue>))]
	[NativeContainer]
	public struct NativeParallelHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 57271
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
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		[DebuggerDisplay("Capacity = {m_Writer.Capacity}")]
		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 57269
		{
			// Fields
			internal UnsafeParallelHashMap<TKey, TValue> m_Writer;
	
			// Methods
			public bool TryAdd(TKey key, TValue item) => default;
		}
	
		[NativeContainer]
		[NativeContainerIsReadOnly]
		public struct Enumerator : IEnumerator<KeyValue<TKey, TValue>> // TypeDefIndex: 57270
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
		[NotBurstCompatible]
		public JobHandle Dispose(JobHandle inputDeps) => default;
		public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator) => default;
		public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator) => default;
		public ParallelWriter AsParallelWriter() => default;
		public Enumerator GetEnumerator() => default;
		IEnumerator<KeyValue<TKey, TValue>> IEnumerable<KeyValue<TKey, TValue>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal sealed class NativeParallelHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 57272
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Constructors
		public NativeParallelHashMapDebuggerTypeProxy() {} // Dummy constructor
	}

	[BurstCompatible]
	public static class NativeParallelHashMapExtensions // TypeDefIndex: 57273
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		public static UnsafeParallelHashMap<TKey, TValue> GetUnsafeMap<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> container)
			where TKey : struct, IEquatable<TKey>, IComparable<TKey>
			where TValue : struct => default;
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(NativeHashSetDebuggerTypeProxy<T>))]
	public struct NativeParallelHashSet<T> : INativeDisposable, IEnumerable<T> // TypeDefIndex: 57275
		where T : struct, IEquatable<T>
	{
		// Fields
		internal NativeParallelHashMap<T, bool> m_Data;
	
		// Properties
		public bool IsEmpty { get => default; }
		public bool IsCreated { get => default; }
	
		// Nested types
		[NativeContainer]
		[NativeContainerIsReadOnly]
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 57274
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

	internal sealed class NativeHashSetDebuggerTypeProxy<T> // TypeDefIndex: 57276
		where T : struct, IEquatable<T>
	{
		// Constructors
		public NativeHashSetDebuggerTypeProxy() {} // Dummy constructor
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	public struct NativeParallelMultiHashMapIterator<TKey> // TypeDefIndex: 57277
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
	public struct NativeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 57280
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
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 57278
		{
			// Fields
			internal UnsafeParallelMultiHashMap<TKey, TValue> m_Writer;
	
			// Methods
			public void Add(TKey key, TValue item) {}
		}
	
		public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 57279
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
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(AllocatorManager.AllocatorHandle) })]
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

	internal sealed class NativeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 57281
		where TKey : struct, IEquatable<TKey>, IComparable<TKey>
		where TValue : struct
	{
		// Constructors
		public NativeParallelMultiHashMapDebuggerTypeProxy() {} // Dummy constructor
	}

	internal struct NativeQueueBlockHeader // TypeDefIndex: 57282
	{
		// Fields
		public unsafe NativeQueueBlockHeader* m_NextBlock; // 0x00
		public int m_NumItems; // 0x08
	}

	[BurstCompatible]
	internal struct NativeQueueBlockPoolData // TypeDefIndex: 57283
	{
		// Fields
		internal IntPtr m_FirstBlock; // 0x00
		internal int m_NumBlocks; // 0x08
		internal int m_MaxBlocks; // 0x0C
		internal int m_AllocLock; // 0x10
	
		// Methods
		public unsafe NativeQueueBlockHeader* AllocateBlock() => default; // 0x000000018306B090-0x000000018306B110
		public unsafe void FreeBlock(NativeQueueBlockHeader* block) {} // 0x0000000182B3F180-0x0000000182B3F250
	}

	internal class NativeQueueBlockPool // TypeDefIndex: 57284
	{
		// Fields
		private static readonly SharedStatic<IntPtr> Data; // 0x00
	
		// Constructors
		public NativeQueueBlockPool() {} // Dummy constructor
		static NativeQueueBlockPool() {} // 0x0000000183628340-0x00000001836283A0
	
		// Methods
		internal static unsafe NativeQueueBlockPoolData* GetQueueBlockPool() => default; // 0x0000000183199900-0x0000000183199A50
		[BurstDiscard]
		private static void AppDomainOnDomainUnload() {} // 0x000000018267B020-0x000000018267B0B0
		private static void OnDomainUnload(object sender, EventArgs e) {} // 0x0000000189B66D98-0x0000000189B66E6C
	}

	[BurstCompatible]
	internal struct NativeQueueData // TypeDefIndex: 57285
	{
		// Fields
		public IntPtr m_FirstBlock; // 0x00
		public IntPtr m_LastBlock; // 0x08
		public int m_MaxItems; // 0x10
		public int m_CurrentRead; // 0x14
		public unsafe byte* m_CurrentWriteBlockTLS; // 0x18
	
		// Methods
		internal unsafe NativeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex) => default; // 0x0000000183D76870-0x0000000183D76880
		internal unsafe void SetCurrentWriteBlockTLS(int threadIndex, NativeQueueBlockHeader* currentWriteBlock) {} // 0x0000000183D76880-0x0000000183D76890
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe NativeQueueBlockHeader* AllocateWriteBlockMT<T>(NativeQueueData* data, NativeQueueBlockPoolData* pool, int threadIndex)
			where T : struct => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void AllocateQueue<T>(AllocatorManager.AllocatorHandle label, out NativeQueueData* outBuf)
			where T : struct {
			outBuf = default;
		}
		public static unsafe void DeallocateQueue(NativeQueueData* data, NativeQueueBlockPoolData* pool, AllocatorManager.AllocatorHandle allocation) {} // 0x00000001832C9FC0-0x00000001832CA030
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[NativeContainer]
	public struct NativeQueue<T> : INativeDisposable // TypeDefIndex: 57287
		where T : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe NativeQueueData* m_Buffer;
		[NativeDisableUnsafePtrRestriction]
		private unsafe NativeQueueBlockPoolData* m_QueuePool;
		private AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public int Count { get => default; }
		public bool IsCreated { get => default; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		[NativeContainer]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 57286
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			internal unsafe NativeQueueData* m_Buffer;
			[NativeDisableUnsafePtrRestriction]
			internal unsafe NativeQueueBlockPoolData* m_QueuePool;
			[NativeSetThreadIndex]
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
		[NotBurstCompatible]
		public JobHandle Dispose(JobHandle inputDeps) => default;
		public ParallelWriter AsParallelWriter() => default;
	}

	[BurstCompatible]
	[NativeContainer]
	internal struct NativeQueueDispose // TypeDefIndex: 57288
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe NativeQueueData* m_Buffer; // 0x00
		[NativeDisableUnsafePtrRestriction]
		internal unsafe NativeQueueBlockPoolData* m_QueuePool; // 0x08
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x10
	
		// Methods
		public void Dispose() {} // 0x0000000189B66E74-0x0000000189B66E88
	}

	[BurstCompile]
	internal struct NativeQueueDisposeJob : IJob // TypeDefIndex: 57289
	{
		// Fields
		public NativeQueueDispose Data; // 0x00
	
		// Methods
		public void Execute() {} // 0x0000000189B66E6C-0x0000000189B66E74
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[NativeContainer]
	public struct NativeReference<T> : INativeDisposable, IEquatable<NativeReference<T>> // TypeDefIndex: 57290
		where T : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe void* m_Data;
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public T Value { get => default; set {} }
		public bool IsCreated { get => default; }
	
		// Constructors
		public unsafe NativeReference(AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x01FD9C61 */) : this() {
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
		[NotBurstCompatible]
		public bool Equals(NativeReference<T> other) => default;
		[NotBurstCompatible]
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}

	[NativeContainer]
	internal struct NativeReferenceDispose // TypeDefIndex: 57291
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe void* m_Data; // 0x00
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x08
	
		// Methods
		public void Dispose() {} // 0x0000000189B66E90-0x0000000189B66EA0
	}

	[BurstCompile]
	internal struct NativeReferenceDisposeJob : IJob // TypeDefIndex: 57292
	{
		// Fields
		internal NativeReferenceDispose Data; // 0x00
	
		// Methods
		public void Execute() {} // 0x0000000189B66E88-0x0000000189B66E90
	}

	[BurstCompatible]
	public static class NativeSortExtension // TypeDefIndex: 57294
	{
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public struct DefaultComparer<T> : IComparer<T> // TypeDefIndex: 57293
			where T : IComparable<T>
		{
			// Methods
			public int Compare(T x, T y) => default;
		}
	
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void Sort<T>(T* array, int length)
			where T : struct, IComparable<T> {}
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(DefaultComparer<int>) })]
		public static unsafe void Sort<T, U>(T* array, int length, U comp)
			where T : struct
			where U : IComparer<T> {}
		[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new System.Type[2] {typeof(int), typeof(DefaultComparer<int>) })]
		public static unsafe SortJob<T, U> SortJob<T, U>(T* array, int length, U comp)
			where T : struct
			where U : IComparer<T> => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe int BinarySearch<T>(T* ptr, int length, T value)
			where T : struct, IComparable<T> => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(DefaultComparer<int>) })]
		public static unsafe int BinarySearch<T, U>(T* ptr, int length, T value, U comp)
			where T : struct
			where U : IComparer<T> => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(DefaultComparer<int>) })]
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
	
		// Extension methods
		[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static SortJob<T, DefaultComparer<T>> SortJob<T>(this NativeArray<T> array)
			where T : struct, IComparable<T> => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static void Sort<T>(this NativeList<T> list)
			where T : struct, IComparable<T> {}
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(DefaultComparer<int>) })]
		public static void Sort<T, U>(this NativeList<T> list, U comp)
			where T : struct
			where U : IComparer<T> {}
	}

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new System.Type[2] {typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	public struct SortJob<T, U> // TypeDefIndex: 57297
		where T : struct
		where U : IComparer<T>
	{
		// Fields
		public unsafe T* Data;
		public U Comp;
		public int Length;
	
		// Nested types
		[BurstCompile]
		private struct SegmentSort : IJobParallelFor // TypeDefIndex: 57295
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public unsafe T* Data;
			public U Comp;
			public int Length;
			public int SegmentWidth;
	
			// Methods
			public void Execute(int index) {}
		}
	
		[BurstCompile]
		private struct SegmentSortMerge : IJob // TypeDefIndex: 57296
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public unsafe T* Data;
			public U Comp;
			public int Length;
			public int SegmentWidth;
	
			// Methods
			public void Execute() {}
		}
	
		// Methods
		[NotBurstCompatible]
		public JobHandle Schedule(JobHandle inputDeps = default) => default;
	}

	[BurstCompatible]
	[NativeContainer]
	public struct NativeStream : IDisposable // TypeDefIndex: 57300
	{
		// Fields
		private UnsafeStream m_Stream; // 0x00
	
		// Nested types
		[BurstCompile]
		private struct ConstructJobList : IJob // TypeDefIndex: 57298
		{
			// Fields
			public NativeStream Container; // 0x00
			[NativeDisableUnsafePtrRestriction]
			[Unity.Collections.ReadOnly]
			public unsafe UntypedUnsafeList* List; // 0x10
	
			// Methods
			public void Execute() {} // 0x0000000189B63944-0x0000000189B63968
		}
	
		[BurstCompile]
		private struct ConstructJob : IJob // TypeDefIndex: 57299
		{
			// Fields
			public NativeStream Container; // 0x00
			[Unity.Collections.ReadOnly]
			public NativeArray<int> Length; // 0x10
	
			// Methods
			public void Execute() {} // 0x0000000189B63968-0x0000000189B63978
		}
	
		// Methods
		public void Dispose() {} // 0x0000000189B63978-0x0000000189B63980
		private void AllocateForEach(int forEachCount) {} // 0x0000000189B66EA0-0x0000000189B66EA8
	}

	internal struct Spinner // TypeDefIndex: 57301
	{
		// Fields
		private int m_value; // 0x00
	
		// Methods
		public void Lock() {} // 0x0000000189B6750C-0x0000000189B67520
		public void Unlock() {} // 0x0000000189B67520-0x0000000189B6753C
	}

	internal struct UnmanagedArray<T> : IDisposable // TypeDefIndex: 57302
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

	[BurstCompile]
	public struct RewindableAllocator : AllocatorManager.IAllocator // TypeDefIndex: 57306
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
		public AllocatorManager.AllocatorHandle Handle { get => default; } // 0x0000000183D4E990-0x0000000183D4E9A0 
	
		// Nested types
		[BurstCompatible]
		internal struct MemoryBlock : IDisposable // TypeDefIndex: 57303
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
			} // 0x0000000189B66D00-0x0000000189B66D54
	
			// Methods
			public void Rewind() {} // 0x0000000183D5CBF0-0x0000000183D5CC00
			public void Dispose() {} // 0x0000000189B66BC4-0x0000000189B66C24
			public int TryAllocate(ref AllocatorManager.Block block) => default; // 0x0000000189B66C24-0x0000000189B66D00
			public bool Contains(IntPtr ptr) => default; // 0x0000000189B66BAC-0x0000000189B66BC4
		}
	
		public delegate int Try_000008B6_PostfixBurstDelegate(IntPtr state, ref AllocatorManager.Block block); // TypeDefIndex: 57304; 0x0000000181165340-0x0000000181165350
	
		internal static class Try_000008B6_BurstDirectCall // TypeDefIndex: 57305
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Try_000008B6_BurstDirectCall() {} // 0x0000000183CE9A30-0x0000000183CE9A40
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00078e52) {} // 0x0000000189B67B1C-0x0000000189B67C20
			private static IntPtr GetFunctionPointer() => default; // 0x0000000189B67C20-0x0000000189B67C74
			public static void Constructor() {} // 0x0000000183CE9A40-0x0000000183CE9AD0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static int Invoke(IntPtr state, ref AllocatorManager.Block block) => default; // 0x0000000189B67C74-0x0000000189B67D00
		}
	
		// Methods
		public void Rewind() {} // 0x0000000189B66FAC-0x0000000189B67090
		public void Dispose() {} // 0x0000000189B66EE0-0x0000000189B66FAC
		public int Try(ref AllocatorManager.Block block) => default; // 0x0000000189B67098-0x0000000189B67260
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		internal static int Try(IntPtr state, ref AllocatorManager.Block block) => default; // 0x0000000189B67260-0x0000000189B672BC
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
		public static int Try_BurstManaged(IntPtr state, ref AllocatorManager.Block block) => default; // 0x0000000189B67090-0x0000000189B67098
	}

	public enum FormatError // TypeDefIndex: 57307
	{
		None = 0,
		Overflow = 1
	}

	public enum CopyError // TypeDefIndex: 57308
	{
		None = 0,
		Truncation = 1
	}

	public enum ConversionError // TypeDefIndex: 57309
	{
		None = 0,
		Overflow = 1,
		Encoding = 2,
		CodePoint = 3
	}

	[BurstCompatible]
	public struct Unicode // TypeDefIndex: 57311
	{
		// Properties
		public static Rune ReplacementCharacter { get => default; } // 0x0000000183D768A0-0x0000000183D768B0 
	
		// Nested types
		[BurstCompatible]
		public struct Rune // TypeDefIndex: 57310
		{
			// Fields
			public int value; // 0x00
		}
	
		// Methods
		public static bool IsValidCodePoint(int codepoint) => default; // 0x0000000182767610-0x0000000182767620
		public static bool NotTrailer(byte b) => default; // 0x0000000189B67E80-0x0000000189B67E8C
		public static unsafe ConversionError Utf8ToUcs(out Rune rune, byte* buffer, ref int index, int capacity) {
			rune = default;
			return default;
		} // 0x0000000182767580-0x00000001827675C0
		private static bool IsLeadingSurrogate(char c) => default; // 0x0000000182767620-0x0000000182767640
		private static bool IsTrailingSurrogate(char c) => default; // 0x00000001891EAE70-0x00000001891EAE8C
		public static unsafe ConversionError Utf16ToUcs(out Rune rune, char* buffer, ref int index, int capacity) {
			rune = default;
			return default;
		} // 0x0000000182767440-0x00000001827674C0
		public static unsafe ConversionError UcsToUtf8(byte* buffer, ref int index, int capacity, Rune rune) => default; // 0x0000000182767400-0x0000000182767440
		public static unsafe ConversionError UcsToUtf16(char* buffer, ref int index, int capacity, Rune rune) => default; // 0x00000001827675C0-0x0000000182767610
		public static unsafe ConversionError Utf16ToUtf8(char* utf16Buffer, int utf16Length, byte* utf8Buffer, out int utf8Length, int utf8Capacity) {
			utf8Length = default;
			return default;
		} // 0x0000000182767340-0x0000000182767400
		public static unsafe ConversionError Utf8ToUtf16(byte* utf8Buffer, int utf8Length, char* utf16Buffer, out int utf16Length, int utf16Capacity) {
			utf16Length = default;
			return default;
		} // 0x00000001827674C0-0x0000000182767580
	}

	[BurstCompatible]
	public static class UTF8ArrayUnsafeUtility // TypeDefIndex: 57313
	{
		// Nested types
		internal struct Comparison // TypeDefIndex: 57312
		{
			// Fields
			public bool terminates; // 0x00
			public int result; // 0x04
	
			// Constructors
			public Comparison(Unicode.Rune runeA, ConversionError errorA, Unicode.Rune runeB, ConversionError errorB) {
				terminates = default;
				result = default;
			} // 0x0000000189B63914-0x0000000189B63944
		}
	
		// Methods
		public static unsafe CopyError Copy(byte* dest, out int destLength, int destUTF8MaxLengthInBytes, char* src, int srcLength) {
			destLength = default;
			return default;
		} // 0x0000000189B67D00-0x0000000189B67D34
		public static unsafe CopyError Copy(byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength) {
			destLength = default;
			return default;
		} // 0x0000000182767170-0x0000000182767240
		public static unsafe int StrCmp(byte* utf8BufferA, int utf8LengthInBytesA, byte* utf8BufferB, int utf8LengthInBytesB) => default; // 0x0000000189B67DE8-0x0000000189B67E80
		public static unsafe bool EqualsUTF8Bytes(byte* aBytes, int aLength, byte* bBytes, int bLength) => default; // 0x0000000189B67D34-0x0000000189B67D50
		public static unsafe int StrCmp(byte* utf8Buffer, int utf8LengthInBytes, char* utf16Buffer, int utf16LengthInChars) => default; // 0x0000000189B67D50-0x0000000189B67DE8
	}

	[BurstCompatible]
	[BurstCompatible]
	[BurstCompatible]
	[BurstCompile]
	public static class xxHash3 // TypeDefIndex: 57319
	{
		// Nested types
		private struct ulong2 // TypeDefIndex: 57314
		{
			// Fields
			public ulong x; // 0x00
			public ulong y; // 0x08
	
			// Constructors
			public ulong2(ulong x, ulong y) {
				this.x = default;
				this.y = default;
			} // 0x0000000183D4EA10-0x0000000183D4EA20
		}
	
		public unsafe delegate ulong Hash64Long_000008F7_PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret); // TypeDefIndex: 57315; 0x000000018101C850-0x000000018101C870
	
		internal static class Hash64Long_000008F7_BurstDirectCall // TypeDefIndex: 57316
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Hash64Long_000008F7_BurstDirectCall() {} // 0x0000000183CEB3C0-0x0000000183CEB3D0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00078f39) {} // 0x0000000189B66868-0x0000000189B6696C
			private static IntPtr GetFunctionPointer() => default; // 0x0000000189B6696C-0x0000000189B669C0
			public static void Constructor() {} // 0x0000000183CEB3D0-0x0000000183CEB460
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe ulong Invoke(byte* input, byte* dest, long length, byte* secret) => default; // 0x0000000189B669C0-0x0000000189B66A70
		}
	
		public unsafe delegate void Hash128Long_000008FE_PostfixBurstDelegate(byte* input, byte* dest, long length, byte* secret, out uint4 result); // TypeDefIndex: 57317; 0x0000000181028930-0x0000000181028950
	
		internal static class Hash128Long_000008FE_BurstDirectCall // TypeDefIndex: 57318
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Hash128Long_000008FE_BurstDirectCall() {} // 0x0000000183CEB460-0x0000000183CEB470
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00078f45) {} // 0x0000000189B66578-0x0000000189B6667C
			private static IntPtr GetFunctionPointer() => default; // 0x0000000189B6667C-0x0000000189B666D0
			public static void Constructor() {} // 0x0000000183CEB470-0x0000000183CEB500
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(byte* input, byte* dest, long length, byte* secret, out uint4 result) {
				result = default;
			} // 0x0000000189B666D0-0x0000000189B66794
		}
	
		// Methods
		internal static unsafe void Avx2HashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64) {} // 0x0000000183D4B9D0-0x0000000183D4B9E0
		internal static unsafe void Avx2ScrambleAcc(ulong* acc, byte* secret) {} // 0x0000000183D4B9D0-0x0000000183D4B9E0
		internal static unsafe void Avx2Accumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64) {} // 0x0000000183D4B9D0-0x0000000183D4B9E0
		internal static unsafe void Avx2Accumulate512(ulong* acc, byte* input, byte* dest, byte* secret) {} // 0x0000000183D4B9D0-0x0000000183D4B9E0
		public static unsafe uint2 Hash64(void* input, long length) => default; // 0x00000001823BA370-0x00000001823BA6A0
		public static unsafe uint4 Hash128(void* input, long length) => default; // 0x0000000189B68C2C-0x0000000189B68CD0
		internal static unsafe ulong Hash64Internal(byte* input, byte* dest, long length, byte* secret, ulong seed) => default; // 0x00000001823BB0C0-0x00000001823BB410
		internal static unsafe void Hash128Internal(byte* input, byte* dest, long length, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x0000000189B683F0-0x0000000189B68538
		private static unsafe ulong Hash64Len1To3(byte* input, long len, byte* secret, ulong seed) => default; // 0x00000001832BA0D0-0x00000001832BA110
		private static unsafe ulong Hash64Len4To8(byte* input, long length, byte* secret, ulong seed) => default; // 0x00000001823BCFD0-0x00000001823BD010
		private static unsafe ulong Hash64Len9To16(byte* input, long length, byte* secret, ulong seed) => default; // 0x0000000183174530-0x0000000183174590
		private static unsafe ulong Hash64Len0To16(byte* input, long length, byte* secret, ulong seed) => default; // 0x00000001823BC110-0x00000001823BC1C0
		private static unsafe ulong Hash64Len17To128(byte* input, long length, byte* secret, ulong seed) => default; // 0x00000001823BBE10-0x00000001823BC050
		private static unsafe ulong Hash64Len129To240(byte* input, long length, byte* secret, ulong seed) => default; // 0x0000000183762620-0x0000000183762700
		[BurstCompile]
		private static unsafe ulong Hash64Long(byte* input, byte* dest, long length, byte* secret) => default; // 0x0000000189B68CD0-0x0000000189B68D44
		private static unsafe void Hash128Len1To3(byte* input, long length, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x0000000189B68974-0x0000000189B68A0C
		private static unsafe void Hash128Len4To8(byte* input, long len, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x0000000189B68A0C-0x0000000189B68ABC
		private static unsafe void Hash128Len9To16(byte* input, long len, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x0000000189B68ABC-0x0000000189B68BAC
		private static unsafe void Hash128Len0To16(byte* input, long length, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x0000000189B68538-0x0000000189B685DC
		private static unsafe void Hash128Len17To128(byte* input, long length, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x0000000189B687E4-0x0000000189B68974
		private static unsafe void Hash128Len129To240(byte* input, long length, byte* secret, ulong seed, out uint4 result) {
			result = default;
		} // 0x0000000189B685DC-0x0000000189B687E4
		[BurstCompile]
		private static unsafe void Hash128Long(byte* input, byte* dest, long length, byte* secret, out uint4 result) {
			result = default;
		} // 0x0000000189B68BAC-0x0000000189B68C2C
		internal static uint2 ToUint2(ulong u) => default; // 0x0000000183D76940-0x0000000183D76960
		internal static uint4 ToUint4(ulong ul0, ulong ul1) => default; // 0x0000000183D76960-0x0000000183D76980
		internal static unsafe void EncodeSecretKey(byte* dst, byte* secret, ulong seed) {} // 0x0000000189B683C0-0x0000000189B683F0
		private static unsafe ulong Read64LE(void* addr) => default; // 0x00000001820C61B0-0x00000001820C61C0
		private static unsafe uint Read32LE(void* addr) => default; // 0x0000000183D4E980-0x0000000183D4E990
		private static unsafe void Write64LE(void* addr, ulong value) {} // 0x0000000183D51730-0x0000000183D51740
		private static ulong Mul32To64(uint x, uint y) => default; // 0x0000000183D70AB0-0x0000000183D70AC0
		private static ulong Swap64(ulong x) => default; // 0x0000000183D76930-0x0000000183D76940
		private static uint Swap32(uint x) => default; // 0x0000000183D70660-0x0000000183D70670
		private static uint RotL32(uint x, int r) => default; // 0x0000000183D50D20-0x0000000183D50D40
		private static ulong RotL64(ulong x, int r) => default; // 0x0000000183D76910-0x0000000183D76930
		private static ulong XorShift64(ulong v64, int shift) => default; // 0x0000000183D76980-0x0000000183D769A0
		private static ulong Mul128Fold64(ulong lhs, ulong rhs) => default; // 0x0000000189B68E9C-0x0000000189B68EC0
		private static unsafe ulong Mix16(byte* input, byte* secret, ulong seed) => default; // 0x0000000189B68DD0-0x0000000189B68DF0
		private static unsafe ulong2 Mix32(ulong2 acc, byte* input_1, byte* input_2, byte* secret, ulong seed) => default; // 0x0000000189B68DFC-0x0000000189B68E9C
		private static ulong Avalanche(ulong h64) => default; // 0x0000000183D768E0-0x0000000183D76910
		private static ulong AvalancheH64(ulong h64) => default; // 0x00000001832BA110-0x00000001832BA150
		private static ulong rrmxmx(ulong h64, ulong length) => default; // 0x0000000183D769A0-0x0000000183D76A00
		private static unsafe ulong Mix2Acc(ulong acc0, ulong acc1, byte* secret) => default; // 0x0000000189B68DF0-0x0000000189B68DFC
		internal static unsafe ulong MergeAcc(ulong* acc, byte* secret, ulong start) => default; // 0x0000000189B68D44-0x0000000189B68DD0
		private static unsafe void DefaultHashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64) {} // 0x0000000189B6821C-0x0000000189B68390
		internal static unsafe void DefaultAccumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64) {} // 0x0000000189B68178-0x0000000189B6821C
		internal static unsafe void DefaultAccumulate512(ulong* acc, byte* input, byte* dest, byte* secret, int isHash64) {} // 0x0000000189B680F8-0x0000000189B68178
		internal static unsafe void DefaultScrambleAcc(ulong* acc, byte* secret) {} // 0x0000000189B68390-0x0000000189B683C0
		[BurstCompile]
		public static unsafe ulong Hash64Long_BurstManaged(byte* input, byte* dest, long length, byte* secret) => default; // 0x0000000189B633BC-0x0000000189B63568
		[BurstCompile]
		public static unsafe void Hash128Long_BurstManaged(byte* input, byte* dest, long length, byte* secret, out uint4 result) {
			result = default;
		} // 0x0000000189B63280-0x0000000189B633BC
	}

	internal static class xxHashDefaultKey // TypeDefIndex: 57320
	{
		// Fields
		public static readonly byte[] kSecret; // 0x00
	
		// Constructors
		static xxHashDefaultKey() {} // 0x0000000183CE28F0-0x0000000183CE2980
	}
}

namespace Unity.Collections.LowLevel.Unsafe
{
	[BurstCompatible]
	public static class NativeListUnsafeUtility // TypeDefIndex: 57322
	{
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* GetInternalListDataPtrUnchecked<T>(ref NativeList<T> list)
			where T : struct => default;
	
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* GetUnsafePtr<T>(this NativeList<T> list)
			where T : struct => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* GetUnsafeReadOnlyPtr<T>(this NativeList<T> list)
			where T : struct => default;
	}

	[BurstCompatible]
	public static class NativeReferenceUnsafeUtility // TypeDefIndex: 57323
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* GetUnsafePtr<T>(this NativeReference<T> reference)
			where T : struct => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* GetUnsafePtrWithoutChecks<T>(this NativeReference<T> reference)
			where T : struct => default;
	}

	[BurstCompatible]
	public struct UnsafeAppendBuffer : INativeDisposable // TypeDefIndex: 57324
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe byte* Ptr; // 0x00
		public int Length; // 0x08
		public int Capacity; // 0x0C
		public AllocatorManager.AllocatorHandle Allocator; // 0x10
		public readonly int Alignment; // 0x14
	
		// Methods
		public void Dispose() {} // 0x0000000189B67E8C-0x0000000189B67F10
	}

	[BurstCompile]
	internal struct UnsafeDisposeJob : IJob // TypeDefIndex: 57325
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe void* Ptr; // 0x00
		public AllocatorManager.AllocatorHandle Allocator; // 0x08
	
		// Methods
		public void Execute() {} // 0x0000000189B67F10-0x0000000189B67F64
	}

	internal struct UntypedUnsafeList // TypeDefIndex: 57326
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
	public struct UnsafeList<T> : INativeDisposable, INativeList<T>, IEnumerable<T> // TypeDefIndex: 57329
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
		public int Length { get => default; }
		public int Capacity { get => default; set {} }
		public T this[int index] { get => default; set {} }
		public bool IsCreated { get => default; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public struct ParallelReader // TypeDefIndex: 57327
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public readonly unsafe T* Ptr;
			public readonly int Length;
	
			// Constructors
			internal unsafe ParallelReader(T* ptr, int length) {
				Ptr = default;
				Length = default;
			}
		}
	
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public struct ParallelWriter // TypeDefIndex: 57328
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public unsafe UnsafeList<T>* ListData;
	
			// Constructors
			internal unsafe ParallelWriter(UnsafeList<T>* listData) {
				ListData = default;
			}
	
			// Methods
			[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
			public void AddNoResize(T value) {}
		}
	
		// Constructors
		public unsafe UnsafeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x01FD9C6A */) : this() {
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
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(AllocatorManager.AllocatorHandle) })]
		internal static unsafe UnsafeList<T>* Create<U>(int initialCapacity, ref ref U allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x01FD9C6B */)
			where U : struct, AllocatorManager.IAllocator => default;
		public static unsafe UnsafeList<T>* Create(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x01FD9C6C */) => default;
		public static unsafe void Destroy(UnsafeList<T>* listData) {}
		public void Dispose() {}
		[NotBurstCompatible]
		public JobHandle Dispose(JobHandle inputDeps) => default;
		[NotBurstCompatible]
		public JobHandle CrossFrameDispose(JobHandle inputDeps, JobQueuePriority priority = JobQueuePriority.NormalJobPriority /* Metadata: 0x01FD9C6D */) => default;
		public void Clear() {}
		public void Resize(int length, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x01FD9C6E */) {}
		private void Realloc<U>(ref ref U allocator, int newCapacity)
			where U : struct, AllocatorManager.IAllocator {}
		private void SetCapacity<U>(ref ref U allocator, int capacity)
			where U : struct, AllocatorManager.IAllocator {}
		public void SetCapacity(int capacity) {}
		public void AddNoResize(T value) {}
		public unsafe void AddRangeNoResize(void* ptr, int count) {}
		public void Add([IsReadOnly] in ref T value) {}
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

	internal sealed class UnsafeListTDebugView<T> // TypeDefIndex: 57330
		where T : struct
	{
		// Constructors
		public UnsafeListTDebugView() {} // Dummy constructor
	}

	[BurstCompatible]
	internal struct UnsafeParallelHashMapData // TypeDefIndex: 57332
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
		internal const int IntsPerCacheLine = 16; // Metadata: 0x01FD9C6F
	
		// Methods
		internal static int GetBucketSize(int capacity) => default; // 0x0000000183D768D0-0x0000000183D768E0
		internal static int GrowCapacity(int capacity) => default; // 0x0000000182482190-0x00000001824821A0
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static unsafe void AllocateHashMap<TKey, TValue>(int length, int bucketLength, AllocatorManager.AllocatorHandle label, out UnsafeParallelHashMapData* outBuf)
			where TKey : struct
			where TValue : struct {
			outBuf = default;
		}
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static unsafe void ReallocateHashMap<TKey, TValue>(UnsafeParallelHashMapData* data, int newCapacity, int newBucketCapacity, AllocatorManager.AllocatorHandle label)
			where TKey : struct
			where TValue : struct {}
		internal static unsafe void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorManager.AllocatorHandle allocator) {} // 0x00000001829CE030-0x00000001829CE0A0
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		internal static int CalculateDataSize<TKey, TValue>(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset)
			where TKey : struct
			where TValue : struct {
			keyOffset = default;
			nextOffset = default;
			bucketOffset = default;
			return default;
		}
		internal static unsafe bool IsEmpty(UnsafeParallelHashMapData* data) => default; // 0x00000001827A84A0-0x00000001827A84E0
		internal static unsafe int GetCount(UnsafeParallelHashMapData* data) => default; // 0x00000001826E9E10-0x00000001826E9E80
		internal static unsafe bool MoveNext(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index) {
			index = default;
			return default;
		} // 0x00000001822AA920-0x00000001822AA9D0
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		internal static unsafe void GetKeyArray<TKey>(UnsafeParallelHashMapData* data, NativeArray<TKey> result)
			where TKey : struct {}
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		internal static unsafe void GetValueArray<TValue>(UnsafeParallelHashMapData* data, NativeArray<TValue> result)
			where TValue : struct {}
	}

	[BurstCompatible]
	[NativeContainer]
	internal struct UnsafeParallelHashMapDataDispose // TypeDefIndex: 57333
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer; // 0x00
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x08
	
		// Methods
		public void Dispose() {} // 0x0000000189B67F6C-0x0000000189B67F7C
	}

	[BurstCompile]
	internal struct UnsafeParallelHashMapDataDisposeJob : IJob // TypeDefIndex: 57334
	{
		// Fields
		internal UnsafeParallelHashMapDataDispose Data; // 0x00
	
		// Methods
		public void Execute() {} // 0x0000000189B67F64-0x0000000189B67F6C
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	internal struct UnsafeParallelHashMapBase<TKey, TValue> // TypeDefIndex: 57335
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

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerDisplay("Key = {Key}, Value = {Value}")]
	public struct KeyValue<TKey, TValue> // TypeDefIndex: 57336
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

	internal struct UnsafeParallelHashMapDataEnumerator // TypeDefIndex: 57337
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
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
		} // 0x0000000183D768B0-0x0000000183D768D0
	
		// Methods
		internal bool MoveNext() => default; // 0x000000018257C5C0-0x000000018257C5F0
		internal void Reset() {} // 0x0000000183D61750-0x0000000183D61770
		internal KeyValue<TKey, TValue> GetCurrent<TKey, TValue>()
			where TKey : struct, IEquatable<TKey>
			where TValue : struct => default;
		internal TKey GetCurrentKey<TKey>()
			where TKey : struct, IEquatable<TKey> => default;
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerDisplay("Count = {Count()}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(UnsafeParallelHashMapDebuggerTypeProxy<TKey, TValue>))]
	public struct UnsafeParallelHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 57339
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer;
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public bool IsEmpty { get => default; }
		public int Capacity { get => default; set {} }
		public TValue this[TKey key] { set {} }
		public bool IsCreated { get => default; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 57338
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeParallelHashMapData* m_Buffer;
			[NativeSetThreadIndex]
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

	[BurstCompile]
	internal struct UnsafeParallelHashMapDisposeJob : IJob // TypeDefIndex: 57340
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeParallelHashMapData* Data; // 0x00
		public AllocatorManager.AllocatorHandle Allocator; // 0x08
	
		// Methods
		public void Execute() {} // 0x0000000189B67F6C-0x0000000189B67F7C
	}

	internal sealed class UnsafeParallelHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 57341
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Constructors
		public UnsafeParallelHashMapDebuggerTypeProxy() {} // Dummy constructor
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
	[DebuggerTypeProxy(typeof(UnsafeHashSetDebuggerTypeProxy<T>))]
	public struct UnsafeParallelHashSet<T> : INativeDisposable, IEnumerable<T> // TypeDefIndex: 57343
		where T : struct, IEquatable<T>
	{
		// Fields
		internal UnsafeParallelHashMap<T, bool> m_Data;
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 57342
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

	internal sealed class UnsafeHashSetDebuggerTypeProxy<T> // TypeDefIndex: 57344
		where T : struct, IEquatable<T>
	{
		// Constructors
		public UnsafeHashSetDebuggerTypeProxy() {} // Dummy constructor
	}

	public static class HashSetExtensions // TypeDefIndex: 57345
	{
		// Extension methods
		public static void UnionWith<T>(this UnsafeParallelHashSet<T> container, UnsafeParallelHashSet<T> other)
			where T : struct, IEquatable<T> {}
	}

	[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
	[DebuggerTypeProxy(typeof(UnsafeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue>))]
	public struct UnsafeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IEnumerable<KeyValue<TKey, TValue>> // TypeDefIndex: 57347
		where TKey : struct, IEquatable<TKey>
		where TValue : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer;
		internal AllocatorManager.AllocatorHandle m_AllocatorLabel;
	
		// Properties
		public bool IsEmpty { get => default; }
		public int Capacity { get => default; }
		public bool IsCreated { get => default; }
	
		// Nested types
		[BurstCompatible(GenericTypeArguments = new System.Type[2] {typeof(int), typeof(int) })]
		[NativeContainerIsAtomicWriteOnly]
		public struct ParallelWriter // TypeDefIndex: 57346
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			internal unsafe UnsafeParallelHashMapData* m_Buffer;
			[NativeSetThreadIndex]
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

	internal sealed class UnsafeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 57348
		where TKey : struct, IEquatable<TKey>, IComparable<TKey>
		where TValue : struct
	{
		// Constructors
		public UnsafeParallelMultiHashMapDebuggerTypeProxy() {} // Dummy constructor
	}

	[BurstCompatible]
	internal struct UnsafeStreamBlock // TypeDefIndex: 57350
	{
		// Fields
		internal unsafe UnsafeStreamBlock* Next; // 0x00
		internal unsafe fixed /* 0x00000000-0x00000000 */ byte Data[0]; // 0x08
	}

	[BurstCompatible]
	internal struct UnsafeStreamRange // TypeDefIndex: 57351
	{
		// Fields
		internal unsafe UnsafeStreamBlock* Block; // 0x00
		internal int OffsetInFirstBlock; // 0x08
		internal int ElementCount; // 0x0C
		internal int LastOffset; // 0x10
		internal int NumberOfBlocks; // 0x14
	}

	[BurstCompatible]
	internal struct UnsafeStreamBlockData // TypeDefIndex: 57352
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
	public struct UnsafeStream : INativeDisposable // TypeDefIndex: 57356
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeStreamBlockData* m_Block; // 0x00
		internal AllocatorManager.AllocatorHandle m_Allocator; // 0x08
	
		// Nested types
		[BurstCompile]
		private struct DisposeJob : IJob // TypeDefIndex: 57353
		{
			// Fields
			public UnsafeStream Container; // 0x00
	
			// Methods
			public void Execute() {} // 0x0000000189B63978-0x0000000189B63980
		}
	
		[BurstCompile]
		private struct ConstructJobList : IJob // TypeDefIndex: 57354
		{
			// Fields
			public UnsafeStream Container; // 0x00
			[NativeDisableUnsafePtrRestriction]
			[Unity.Collections.ReadOnly]
			public unsafe UntypedUnsafeList* List; // 0x10
	
			// Methods
			public void Execute() {} // 0x0000000189B63944-0x0000000189B63968
		}
	
		[BurstCompile]
		private struct ConstructJob : IJob // TypeDefIndex: 57355
		{
			// Fields
			public UnsafeStream Container; // 0x00
			[Unity.Collections.ReadOnly]
			public NativeArray<int> Length; // 0x10
	
			// Methods
			public void Execute() {} // 0x0000000189B63968-0x0000000189B63978
		}
	
		// Methods
		internal void AllocateForEach(int forEachCount) {} // 0x0000000189B67F7C-0x0000000189B67FFC
		private void Deallocate() {} // 0x0000000189B67FFC-0x0000000189B680F0
		public void Dispose() {} // 0x0000000189B63978-0x0000000189B63980
	}

	[BurstCompatible]
	public static class UnsafeUtilityExtensions // TypeDefIndex: 57357
	{
		// Methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static unsafe void* AddressOf<T>([IsReadOnly] in ref T value)
			where T : struct => default;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static ref ref T AsRef<T>([IsReadOnly] in ref T value)
			where T : struct => ref _refReturnTypeForAsRef;
		private ref T _refReturnTypeForAsRef; // Dummy field
		public static IntPtr Malloc(long size, int alignment, Unity.Collections.Allocator allocator) => default; // 0x0000000189B680F0-0x0000000189B680F8
	}
}

namespace Unity.Collections.NotBurstCompatible
{
	public static class Extensions // TypeDefIndex: 57321
	{
		// Extension methods
		[NotBurstCompatible]
		public static T[] ToArrayNBC<T>(this NativeList<T> list)
			where T : struct => default;
	}
}

namespace Unity.Jobs
{
	public class EarlyInitHelpers // TypeDefIndex: 57174
	{
		// Constructors
		public EarlyInitHelpers() {} // Dummy constructor
	
		// Methods
		public static void JobReflectionDataCreationFailed(Exception ex, System.Type jobType) {} // 0x0000000189B63980-0x0000000189B639F8
	}

	[JobProducerType(typeof(IJobBurstSchedulableExtensions.JobBurstSchedulableProducer<T>))]
	public interface IJobBurstSchedulable // TypeDefIndex: 57175
	{
		// Methods
		void Execute();
	}

	public static class IJobBurstSchedulableExtensions // TypeDefIndex: 57178
	{
		// Nested types
		internal struct JobBurstSchedulableProducer<T> // TypeDefIndex: 57177
			where T : struct, IJobBurstSchedulable
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 57176; 0x00000000-0x00000000
	
			// Constructors
			static JobBurstSchedulableProducer() {
				jobReflectionData = default;
			}
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			internal static void Initialize() {}
			public static void Execute(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	}

	[JobProducerType(typeof(IJobParallelForBatchExtensions.JobParallelForBatchProducer<T>))]
	public interface IJobParallelForBatch // TypeDefIndex: 57179
	{
		// Methods
		void Execute(int startIndex, int count);
	}

	public static class IJobParallelForBatchExtensions // TypeDefIndex: 57182
	{
		// Nested types
		internal struct JobParallelForBatchProducer<T> // TypeDefIndex: 57181
			where T : struct, IJobParallelForBatch
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 57180; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForBatchProducer() {
				jobReflectionData = default;
			}
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			internal static void Initialize() {}
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	
		// Methods
		public static void EarlyJobInit<T>()
			where T : struct, IJobParallelForBatch {}
	
		// Extension methods
		public static JobHandle ScheduleBatch<T>(this T jobData, int arrayLength, int minIndicesPerJobCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForBatch => default;
	}

	[JobProducerType(typeof(IJobParallelForExtensionsBurstSchedulable.JobParallelForBurstSchedulableProducer<T>))]
	public interface IJobParallelForBurstSchedulable // TypeDefIndex: 57183
	{
		// Methods
		void Execute(int index);
	}

	public static class IJobParallelForExtensionsBurstSchedulable // TypeDefIndex: 57186
	{
		// Nested types
		internal struct JobParallelForBurstSchedulableProducer<T> // TypeDefIndex: 57185
			where T : struct, IJobParallelForBurstSchedulable
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			internal delegate void ExecuteJobFunction(ref ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 57184; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForBurstSchedulableProducer() {
				jobReflectionData = default;
			}
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			internal static void Initialize() {}
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	}

	[JobProducerType(typeof(IJobParallelForDeferExtensions.JobParallelForDeferProducer<T>))]
	public interface IJobParallelForDefer // TypeDefIndex: 57187
	{
		// Methods
		void Execute(int index);
	}

	public static class IJobParallelForDeferExtensions // TypeDefIndex: 57190
	{
		// Nested types
		internal struct JobParallelForDeferProducer<T> // TypeDefIndex: 57189
			where T : struct, IJobParallelForDefer
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			public delegate void ExecuteJobFunction(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 57188; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForDeferProducer() {
				jobReflectionData = default;
			}
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			internal static void Initialize() {}
			public static void Execute(ref ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
		}
	
		// Methods
		public static void EarlyJobInit<T>()
			where T : struct, IJobParallelForDefer {}
		private static unsafe JobHandle ScheduleInternal<T>(ref ref T jobData, int innerloopBatchCount, void* forEachListPtr, void* atomicSafetyHandlePtr, JobHandle dependsOn)
			where T : struct, IJobParallelForDefer => default;
	
		// Extension methods
		public static JobHandle Schedule<T, U>(this T jobData, NativeList<U> list, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer
			where U : struct => default;
		public static unsafe JobHandle Schedule<T>(this T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer => default;
		public static unsafe JobHandle ScheduleByRef<T>(this ref ref T jobData, int* forEachCount, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer => default;
	}

	[JobProducerType(typeof(JobParallelIndexListExtensions.JobParallelForFilterProducer<T>))]
	public interface IJobParallelForFilter // TypeDefIndex: 57191
	{
		// Methods
		bool Execute(int index);
	}

	public static class JobParallelIndexListExtensions // TypeDefIndex: 57195
	{
		// Nested types
		internal struct JobParallelForFilterProducer<T> // TypeDefIndex: 57194
			where T : struct, IJobParallelForFilter
		{
			// Fields
			internal static readonly SharedStatic<IntPtr> jobReflectionData;
	
			// Nested types
			public struct JobWrapper // TypeDefIndex: 57192
			{
				// Fields
				[NativeDisableParallelForRestriction]
				public NativeList<int> outputIndices;
				public int appendCount;
				public T JobData;
			}
	
			public delegate void ExecuteJobFunction(ref JobWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex); // TypeDefIndex: 57193; 0x00000000-0x00000000
	
			// Constructors
			static JobParallelForFilterProducer() {
				jobReflectionData = default;
			}
	
			// Methods
			[UnityEngine.Scripting.Preserve]
			public static void Initialize() {}
			public static void Execute(ref JobWrapper jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) {}
			public static void ExecuteAppend(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData) {}
			public static void ExecuteFilter(ref JobWrapper jobWrapper, IntPtr bufferRangePatchData) {}
		}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class DOTSCompilerGeneratedAttribute : Attribute // TypeDefIndex: 57196
	{
		// Constructors
		public DOTSCompilerGeneratedAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}
