/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Beyond;
using Beyond.Gameplay.Core;
using IFix.Core;
using Microsoft.CodeAnalysis;
using Unity.Collections;

// Image 114: Unsafe.SceneGrid.dll - Assembly: Unsafe.SceneGrid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90959-90993

namespace Beyond.Gameplay.Core
{
	public struct FDictionary4<Tk, Tv> // TypeDefIndex: 90971
		where Tk : struct, IEquatable<Tk>
		where Tv : struct
	{
		// Fields
		public FArray4<Tk> kArray;
		public FArray4<Tv> vArray;
		public uint bitArray;
		public static readonly int CAPACITY;
	
		// Properties
		public Tv this[Tk k] { get => default; set {} }
	
		// Nested types
		public struct FDictionaryEnumerator // TypeDefIndex: 90970
		{
			// Fields
			public unsafe FDictionary4<Tk, Tv>* ptr;
			private int m_pos;
	
			// Properties
			[TupleElementNames(new string[2] {"key", "v" })]
			public ValueTuple<Tk, Tv> Current { get; }
	
			// Constructors
			public unsafe FDictionaryEnumerator(FDictionary4<Tk, Tv>* initPtr);
	
			// Methods
			public bool MoveNext();
		}
	
		// Constructors
		public FDictionary4(int len);
		static FDictionary4();
	
		// Methods
		public FDictionaryEnumerator GetEnumerator();
		public void SetBitEnable(int bit);
		public void SetBitDisable(int bit);
		public bool IsBitEnable(int bit);
		public bool TryGetValue(Tk k, out ref Tv v);
		public bool TryRemove(Tk k);
	}

	public struct FDictionary16<Tk, Tv> // TypeDefIndex: 90973
		where Tk : struct, IEquatable<Tk>
		where Tv : struct
	{
		// Fields
		public FArray16<Tk> kArray;
		public FArray16<Tv> vArray;
		public uint bitArray;
		public static readonly int CAPACITY;
	
		// Properties
		public Tv this[Tk k] { get => default; set {} }
	
		// Nested types
		public struct FDictionaryEnumerator // TypeDefIndex: 90972
		{
			// Fields
			public unsafe FDictionary16<Tk, Tv>* ptr;
			private int m_pos;
	
			// Properties
			[TupleElementNames(new string[2] {"key", "v" })]
			public ValueTuple<Tk, Tv> Current { get; }
	
			// Constructors
			public unsafe FDictionaryEnumerator(FDictionary16<Tk, Tv>* initPtr);
	
			// Methods
			public bool MoveNext();
		}
	
		// Constructors
		public FDictionary16(int len);
		static FDictionary16();
	
		// Methods
		public FDictionaryEnumerator GetEnumerator();
		public void SetBitEnable(int bit);
		public void SetBitDisable(int bit);
		public bool IsBitEnable(int bit);
		public bool TryGetValue(Tk k, out ref Tv v);
		public bool TryRemove(Tk k);
	}

	public class MemFriendSetContextManager<T> // TypeDefIndex: 90974
		where T : struct
	{
		// Fields
		private const int ARRAY_CACHE_SIZE = 32; // Metadata: 0x0264B1D9
		private const int SEQ_SET_MAX = 8; // Metadata: 0x0264B1DA
		private const int INIT_SET_CAP = 2048; // Metadata: 0x0264B1DB
		private const int MAX_SET_CAP = 65536; // Metadata: 0x0264B1DD
		private const int INIT_MIN_CAP = 2; // Metadata: 0x0264B1E1
		public const int MAX_CONTENT_SIZE = 2097152; // Metadata: 0x0264B1E2
		public readonly int minCapSize;
		public readonly int initContentSize;
		public readonly int freeListPointerSize;
		private readonly MemFriendSetContextBase<T>[] m_setContexts;
		private readonly Dictionary<int, MemFriendSetContextBase<T>> m_setContextsMap;
	
		// Constructors
		public MemFriendSetContextManager();
	
		// Methods
		private MemFriendSetContextBase<T> _GetContext(int cap);
		private MemFriendSetContextBase<T> _CreateContext(int cap);
		public bool Insert(ref MemFriendHashSet set, T item);
		public bool Remove(ref MemFriendHashSet set, T item);
		public bool Contains(ref MemFriendHashSet set, T item);
		public PureEnumerator<T> GetEnumerator(ref MemFriendHashSet set);
		public void AddToMonoSet(ref MemFriendHashSet set, HashSet<T> monoSet);
		public void AddToMonoList(ref MemFriendHashSet set, List<T> monoList);
		public MemFriendHashSet AllocateSet(int cap);
		public void Recycle(ref MemFriendHashSet set);
		public int GetContextSize(int cap);
		public void OnRelease();
	}

	public struct PureEnumerator<T> // TypeDefIndex: 90975
		where T : struct
	{
		// Fields
		private int m_index;
		private int m_validCnt;
		private MemFriendHashSet m_set;
		private readonly MemFriendSetContextBase<T> m_context;
	
		// Properties
		public T current { get; }
	
		// Constructors
		public PureEnumerator(MemFriendHashSet set, MemFriendSetContextBase<T> context);
	
		// Methods
		public bool MoveNext();
	}

	public struct MemFriendHashSet // TypeDefIndex: 90976
	{
		// Fields
		public int start; // 0x00
		public int cap; // 0x04
		public int count; // 0x08
		public int bitStart; // 0x0C
	
		// Methods
		public void CopyFrom(ref MemFriendHashSet other); // 0x0000000185F46720-0x0000000185F46760
		public void Clear(); // 0x0000000185F466F0-0x0000000185F46720
	}

	public abstract class MemFriendSetContextBase<T> : IDisposable // TypeDefIndex: 90977
		where T : struct
	{
		// Fields
		protected NativeArray<T> m_content;
		protected readonly int m_singleElementSize;
		public const int INVALID_CONTENT_INDEX = -1; // Metadata: 0x0264B1E6
		public readonly int typeSize;
		public readonly int stride;
		public readonly MemFriendSetContextManager<T> contextManager;
		private int m_freeListHead;
		private int m_freeListTail;
		private unsafe byte* m_ptr;
		public int currentCount;
	
		// Properties
		public int singleElementSize { get; }
	
		// Constructors
		protected MemFriendSetContextBase(MemFriendSetContextManager<T> contextManager, int initSize, int singleElementSize);
	
		// Methods
		public void InitArrayFreeList(int baseIndex, int size);
		protected void _ReplaceWithNewCap(ref MemFriendHashSet set, int newCap);
		protected void _TryShrink(ref MemFriendHashSet set);
		protected bool _TryEnLarge(ref MemFriendHashSet set, T item);
		protected virtual void EnLarge();
		public virtual MemFriendHashSet Allocate();
		public virtual void Free(ref MemFriendHashSet set);
		public void CopyFromAnother(ref MemFriendHashSet desSet, ref MemFriendHashSet srcSet);
		public T GetElement(int index);
		protected bool IsEqual(int index, T item);
		protected int GetHashCodeOfElement(T item);
		public PureEnumerator<T> GetEnumerator(ref MemFriendHashSet set);
		public abstract int GetNextValidIndex(ref MemFriendHashSet set, int index, int validCnt);
		public abstract bool Insert(ref MemFriendHashSet set, T item);
		public abstract bool Remove(ref MemFriendHashSet set, T item);
		public abstract bool Contains(ref MemFriendHashSet set, T item);
		public abstract bool ShouldEnLarge(int count);
		public virtual void Dispose();
	}

	public class BitContext : IDisposable // TypeDefIndex: 90978
	{
		// Fields
		public NativeArray<byte> bits; // 0x10
		public const int ONE_SLOT_BIT_NUM = 8; // Metadata: 0x0264B1E7
		public const int ONE_STATE_BIT_NUM = 2; // Metadata: 0x0264B1E8
		public const int ONE_SLOT_ELEMENT_NUM = 4; // Metadata: 0x0264B1E9
		public const byte MASK = 3; // Metadata: 0x0264B1EA
		public const byte FREE = 0; // Metadata: 0x0264B1EB
		public const byte OCCUPIED = 1; // Metadata: 0x0264B1EC
		public const byte USED = 2; // Metadata: 0x0264B1ED
		private readonly int m_elementBitSlot; // 0x20
		private unsafe byte* m_ptr; // 0x28
	
		// Constructors
		public BitContext(int initSize, int singleElementSize); // 0x0000000186AE0B40-0x0000000186AE0BF0
	
		// Methods
		private int _ComputePropBitArrayLength(int contentLength); // 0x0000000186AE0BF0-0x0000000186AE0C40
		public void EnLarge(int contentSize); // 0x000000018D6D2980-0x000000018D6D2A7C
		public void Recycle(int bitIndex); // 0x0000000186A41EE0-0x0000000186A41F20
		public int GetBitStartIndex(int index); // 0x000000018D6D2A7C-0x000000018D6D2A88
		private void _CalculateBitIndexAndMask(int bitStateStartIndex, int index, out int finalIndex, out int offsetInternal); // 0x0000000187264340-0x0000000187264370
		public byte GetState(int bitStateStartIndex, int index); // 0x00000001858D59C0-0x00000001858D5A30
		public void SetState(int bitStateStartIndex, int index, byte state); // 0x00000001858D63D0-0x00000001858D6450
		public void Dispose(); // 0x000000018D6D28EC-0x000000018D6D2980
	}

	public class MemFriendNormalSetContext<T> : MemFriendSetContextBase<T> // TypeDefIndex: 90979
		where T : struct
	{
		// Fields
		private readonly BitContext m_bitContext;
	
		// Constructors
		public MemFriendNormalSetContext(MemFriendSetContextManager<T> contextManager, int initSize, int singleElementSize);
	
		// Methods
		protected override void EnLarge();
		public override void Dispose();
		public override int GetNextValidIndex(ref MemFriendHashSet set, int index, int validCnt);
		public override MemFriendHashSet Allocate();
		public override void Free(ref MemFriendHashSet set);
		public override bool ShouldEnLarge(int count);
		public override bool Insert(ref MemFriendHashSet set, T item);
		public override bool Remove(ref MemFriendHashSet set, T item);
		public override bool Contains(ref MemFriendHashSet set, T item);
	}

	public class MemFriendSeqSetContext<T> : MemFriendSetContextBase<T> // TypeDefIndex: 90980
		where T : struct
	{
		// Constructors
		public MemFriendSeqSetContext(MemFriendSetContextManager<T> contextManager, int initSize, int singleElementSize);
	
		// Methods
		public override int GetNextValidIndex(ref MemFriendHashSet set, int index, int validCnt);
		public override bool ShouldEnLarge(int count);
		public override bool Insert(ref MemFriendHashSet set, T item);
		public override bool Remove(ref MemFriendHashSet set, T item);
		public override bool Contains(ref MemFriendHashSet set, T item);
	}

	public static class GameplayUnsafeUtil // TypeDefIndex: 90981
	{
		// Methods
		public static byte[] NativeArrayToBytes<T>(NativeArray<T> nativeArray)
			where T : struct;
		public static NativeArray<byte> GetNativeArrayFromStream(Stream stream); // 0x000000018D6D2A88-0x000000018D6D2BC4
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 90963
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 90964
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 90965
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 90966
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 90967
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 90968
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 90969
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 90962
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 90982
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018D6D3074-0x000000018D6D30D8
	
		// Methods
		public void __Gen_Wrap_0(ref MemFriendHashSet P0, ref MemFriendHashSet P1); // 0x000000018D6D2BC4-0x000000018D6D2D50
		public void __Gen_Wrap_1(ref MemFriendHashSet P0); // 0x000000018D6D2D50-0x000000018D6D2E78
		public int __Gen_Wrap_2(object P0, int P1); // 0x0000000188B4AE78-0x0000000188B4AF54
		public void __Gen_Wrap_3(object P0, int P1); // 0x0000000188B4D6D0-0x0000000188B4D7A0
		public byte __Gen_Wrap_4(object P0, int P1, int P2); // 0x0000000188CAC050-0x0000000188CAC148
		public void __Gen_Wrap_5(object P0, int P1, int P2, byte P3); // 0x000000018D6D2E78-0x000000018D6D2F74
		public void __Gen_Wrap_6(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public NativeArray<byte> __Gen_Wrap_7(object P0); // 0x000000018D6D2F74-0x000000018D6D3074
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 90983
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018D6D30D8-0x000000018D6D3170
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 90984
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018D6D335C-0x000000018D6D33C0
		public static bool IsPatched(int id); // 0x000000018D6D344C-0x000000018D6D34C8
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018D6D3214-0x000000018D6D32E0
		public object CreateWrapper(int id); // 0x000000018D6D32E0-0x000000018D6D335C
		public object InitWrapperArray(int len); // 0x000000018D6D33C0-0x000000018D6D344C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018D6D3170-0x000000018D6D3214
	}

	public delegate void __HotPatchDelegate_0(ref MemFriendHashSet P0, ref MemFriendHashSet P1); // TypeDefIndex: 90985; 0x00000001859B7730-0x00000001859B7740

	public enum HotPatchIDMAP0 // TypeDefIndex: 90986
	{
		Beyond-Gameplay-Core-MemFriendHashSet-CopyFrom0 = 0,
		Beyond-Gameplay-Core-MemFriendHashSet-Clear0 = 1,
		Beyond-Gameplay-Core-BitContext-_ComputePropBitArrayLength0 = 2,
		Beyond-Gameplay-Core-BitContext-EnLarge0 = 3,
		Beyond-Gameplay-Core-BitContext-Recycle0 = 3,
		Beyond-Gameplay-Core-BitContext-GetState0 = 4,
		Beyond-Gameplay-Core-BitContext-SetState0 = 5,
		Beyond-Gameplay-Core-BitContext-Dispose0 = 6,
		Beyond-Gameplay-Core-GameplayUnsafeUtil-GetNativeArrayFromStream0 = 7
	}

	public delegate void __HotPatchDelegate_1(ref MemFriendHashSet P0); // TypeDefIndex: 90987; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_2(object P0, int P1); // TypeDefIndex: 90988; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_3(object P0, int P1); // TypeDefIndex: 90989; 0x00000001859B7730-0x00000001859B7740

	public delegate byte __HotPatchDelegate_4(object P0, int P1, int P2); // TypeDefIndex: 90990; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_5(object P0, int P1, int P2, byte P3); // TypeDefIndex: 90991; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_6(object P0); // TypeDefIndex: 90992; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate NativeArray<byte> __HotPatchDelegate_7(object P0); // TypeDefIndex: 90993; 0x0000000186464680-0x00000001864646B0
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 90960
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 90961
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
