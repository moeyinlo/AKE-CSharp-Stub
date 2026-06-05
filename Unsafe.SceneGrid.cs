/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Beyond;
using Beyond.Gameplay.Core;
using IFix.Core;
using Unity.Collections;

// Image 104: Unsafe.SceneGrid.dll - Assembly: Unsafe.SceneGrid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60670-60695

namespace Beyond.Gameplay.Core
{
	public struct FDictionary4<Tk, Tv> // TypeDefIndex: 60680
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
		public struct FDictionaryEnumerator // TypeDefIndex: 60679
		{
			// Fields
			public unsafe FDictionary4<Tk, Tv>* ptr;
			private int m_pos;
	
			// Properties
			public ValueTuple<Tk, Tv> Current { get => default; }
	
			// Constructors
			public unsafe FDictionaryEnumerator(FDictionary4<Tk, Tv>* initPtr) : this() {
				ptr = default;
				m_pos = default;
			}
	
			// Methods
			public bool MoveNext() => default;
		}
	
		// Constructors
		public FDictionary4(int len) : this() {
			kArray = default;
			vArray = default;
			bitArray = default;
		}
		static FDictionary4() {
			CAPACITY = default;
		}
	
		// Methods
		public FDictionaryEnumerator GetEnumerator() => default;
		public void SetBitEnable(int bit) {}
		public void SetBitDisable(int bit) {}
		public bool IsBitEnable(int bit) => default;
		public bool TryGetValue(Tk k, out ref Tv v) {
			v = default;
			return default;
		}
		public bool TryRemove(Tk k) => default;
	}

	public struct FDictionary16<Tk, Tv> // TypeDefIndex: 60682
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
		public struct FDictionaryEnumerator // TypeDefIndex: 60681
		{
			// Fields
			public unsafe FDictionary16<Tk, Tv>* ptr;
			private int m_pos;
	
			// Properties
			public ValueTuple<Tk, Tv> Current { get => default; }
	
			// Constructors
			public unsafe FDictionaryEnumerator(FDictionary16<Tk, Tv>* initPtr) : this() {
				ptr = default;
				m_pos = default;
			}
	
			// Methods
			public bool MoveNext() => default;
		}
	
		// Constructors
		public FDictionary16(int len) : this() {
			kArray = default;
			vArray = default;
			bitArray = default;
		}
		static FDictionary16() {
			CAPACITY = default;
		}
	
		// Methods
		public FDictionaryEnumerator GetEnumerator() => default;
		public void SetBitEnable(int bit) {}
		public void SetBitDisable(int bit) {}
		public bool IsBitEnable(int bit) => default;
		public bool TryGetValue(Tk k, out ref Tv v) {
			v = default;
			return default;
		}
		public bool TryRemove(Tk k) => default;
	}

	public class MemFriendSetContextManager<T> // TypeDefIndex: 60683
		where T : struct
	{
		// Fields
		private const int ARRAY_CACHE_SIZE = 32; // Metadata: 0x02082ABE
		private const int SEQ_SET_MAX = 8; // Metadata: 0x02082ABF
		private const int INIT_SET_CAP = 2048; // Metadata: 0x02082AC0
		private const int MAX_SET_CAP = 65536; // Metadata: 0x02082AC2
		private const int INIT_MIN_CAP = 2; // Metadata: 0x02082AC6
		public const int MAX_CONTENT_SIZE = 2097152; // Metadata: 0x02082AC7
		public readonly int minCapSize;
		public readonly int initContentSize;
		public readonly int freeListPointerSize;
		private readonly MemFriendSetContextBase<T>[] m_setContexts;
		private readonly Dictionary<int, MemFriendSetContextBase<T>> m_setContextsMap;
	
		// Constructors
		public MemFriendSetContextManager() {}
	
		// Methods
		private MemFriendSetContextBase<T> _GetContext(int cap) => default;
		private MemFriendSetContextBase<T> _CreateContext(int cap) => default;
		public bool Insert(ref MemFriendHashSet set, T item) => default;
		public bool Remove(ref MemFriendHashSet set, T item) => default;
		public bool Contains(ref MemFriendHashSet set, T item) => default;
		public PureEnumerator<T> GetEnumerator(ref MemFriendHashSet set) => default;
		public void AddToMonoSet(ref MemFriendHashSet set, HashSet<T> monoSet) {}
		public void AddToMonoList(ref MemFriendHashSet set, List<T> monoList) {}
		public MemFriendHashSet AllocateSet(int cap) => default;
		public void Recycle(ref MemFriendHashSet set) {}
		public int GetContextSize(int cap) => default;
		public void OnRelease() {}
	}

	public struct PureEnumerator<T> // TypeDefIndex: 60684
		where T : struct
	{
		// Fields
		private int m_index;
		private int m_validCnt;
		private MemFriendHashSet m_set;
		private readonly MemFriendSetContextBase<T> m_context;
	
		// Properties
		public T current { get => default; }
	
		// Constructors
		public PureEnumerator(MemFriendHashSet set, MemFriendSetContextBase<T> context) : this() {
			m_index = default;
			m_validCnt = default;
			m_set = default;
			m_context = default;
		}
	
		// Methods
		public bool MoveNext() => default;
	}

	public struct MemFriendHashSet // TypeDefIndex: 60685
	{
		// Fields
		public int start; // 0x00
		public int cap; // 0x04
		public int count; // 0x08
		public int bitStart; // 0x0C
	
		// Methods
		public void CopyFrom(ref MemFriendHashSet other) {} // 0x00000001841E7950-0x00000001841E79A0
		public void Clear() {} // 0x00000001841E6B50-0x00000001841E6B80
	}

	public abstract class MemFriendSetContextBase<T> : IDisposable // TypeDefIndex: 60686
		where T : struct
	{
		// Fields
		protected NativeArray<T> m_content;
		protected readonly int m_singleElementSize;
		public const int INVALID_CONTENT_INDEX = -1; // Metadata: 0x02082ACB
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
		protected MemFriendSetContextBase() {} // Dummy constructor
		protected MemFriendSetContextBase(MemFriendSetContextManager<T> contextManager, int initSize, int singleElementSize) {}
	
		// Methods
		public void InitArrayFreeList(int baseIndex, int size) {}
		protected void _ReplaceWithNewCap(ref MemFriendHashSet set, int newCap) {}
		protected void _TryShrink(ref MemFriendHashSet set) {}
		protected bool _TryEnLarge(ref MemFriendHashSet set, T item) => default;
		protected virtual void EnLarge() {}
		public virtual MemFriendHashSet Allocate() => default;
		public virtual void Free(ref MemFriendHashSet set) {}
		public void CopyFromAnother(ref MemFriendHashSet desSet, ref MemFriendHashSet srcSet) {}
		public T GetElement(int index) => default;
		protected bool IsEqual(int index, T item) => default;
		protected int GetHashCodeOfElement(T item) => default;
		public PureEnumerator<T> GetEnumerator(ref MemFriendHashSet set) => default;
		public abstract int GetNextValidIndex(ref MemFriendHashSet set, int index, int validCnt);
		public abstract bool Insert(ref MemFriendHashSet set, T item);
		public abstract bool Remove(ref MemFriendHashSet set, T item);
		public abstract bool Contains(ref MemFriendHashSet set, T item);
		public abstract bool ShouldEnLarge(int count);
		public virtual void Dispose() {}
	}

	public class BitContext : IDisposable // TypeDefIndex: 60687
	{
		// Fields
		public NativeArray<byte> bits; // 0x10
		public const int ONE_SLOT_BIT_NUM = 8; // Metadata: 0x02082ACC
		public const int ONE_STATE_BIT_NUM = 2; // Metadata: 0x02082ACD
		public const int ONE_SLOT_ELEMENT_NUM = 4; // Metadata: 0x02082ACE
		public const byte MASK = 3; // Metadata: 0x02082ACF
		public const byte FREE = 0; // Metadata: 0x02082AD0
		public const byte OCCUPIED = 1; // Metadata: 0x02082AD1
		public const byte USED = 2; // Metadata: 0x02082AD2
		private readonly int m_elementBitSlot; // 0x20
		private unsafe byte* m_ptr; // 0x28
	
		// Constructors
		public BitContext() {} // Dummy constructor
		public BitContext(int initSize, int singleElementSize) {} // 0x00000001841E64E0-0x00000001841E6590
	
		// Methods
		private int _ComputePropBitArrayLength(int contentLength) => default; // 0x00000001841E6590-0x00000001841E65E0
		public void EnLarge(int contentSize) {} // 0x000000018C0BDC74-0x000000018C0BDD68
		public void Recycle(int bitIndex) {} // 0x00000001841E7AB0-0x00000001841E7B00
		public int GetBitStartIndex(int index) => default; // 0x000000018C0BDD68-0x000000018C0BDD74
		private void _CalculateBitIndexAndMask(int bitStateStartIndex, int index, out int finalIndex, out int offsetInternal) {
			finalIndex = default;
			offsetInternal = default;
		} // 0x0000000185FEAE40-0x0000000185FEAE70
		public byte GetState(int bitStateStartIndex, int index) => default; // 0x00000001841E7810-0x00000001841E78E0
		public void SetState(int bitStateStartIndex, int index, byte state) {} // 0x00000001841E74A0-0x00000001841E7530
		public void Dispose() {} // 0x000000018C0BDBE8-0x000000018C0BDC74
	}

	public class MemFriendNormalSetContext<T> : MemFriendSetContextBase<T> // TypeDefIndex: 60688
		where T : struct
	{
		// Fields
		private readonly BitContext m_bitContext;
	
		// Constructors
		public MemFriendNormalSetContext() {} // Dummy constructor
		public MemFriendNormalSetContext(MemFriendSetContextManager<T> contextManager, int initSize, int singleElementSize) {}
	
		// Methods
		protected override void EnLarge() {}
		public override void Dispose() {}
		public override int GetNextValidIndex(ref MemFriendHashSet set, int index, int validCnt) => default;
		public override MemFriendHashSet Allocate() => default;
		public override void Free(ref MemFriendHashSet set) {}
		public override bool ShouldEnLarge(int count) => default;
		public override bool Insert(ref MemFriendHashSet set, T item) => default;
		public override bool Remove(ref MemFriendHashSet set, T item) => default;
		public override bool Contains(ref MemFriendHashSet set, T item) => default;
	}

	public class MemFriendSeqSetContext<T> : MemFriendSetContextBase<T> // TypeDefIndex: 60689
		where T : struct
	{
		// Constructors
		public MemFriendSeqSetContext() {} // Dummy constructor
		public MemFriendSeqSetContext(MemFriendSetContextManager<T> contextManager, int initSize, int singleElementSize) {}
	
		// Methods
		public override int GetNextValidIndex(ref MemFriendHashSet set, int index, int validCnt) => default;
		public override bool ShouldEnLarge(int count) => default;
		public override bool Insert(ref MemFriendHashSet set, T item) => default;
		public override bool Remove(ref MemFriendHashSet set, T item) => default;
		public override bool Contains(ref MemFriendHashSet set, T item) => default;
	}

	public static class GameplayUnsafeUtil // TypeDefIndex: 60690
	{
		// Methods
		public static byte[] NativeArrayToBytes<T>(NativeArray<T> nativeArray)
			where T : struct => default;
		public static NativeArray<byte> GetNativeArrayFromStream(Stream stream) => default; // 0x000000018C0BDD74-0x000000018C0BDEA4
	}

	public class SparseNativeArray<T> // TypeDefIndex: 60691
		where T : struct
	{
		// Fields
		private NativeArray<T> m_rawArray;
		private int m_currentCount;
		private int m_emptyStartPos;
		private int m_marker;
		public readonly int typeSize;
		private unsafe byte* m_ptr;
		private unsafe T* m_validPtr;
	
		// Properties
		public T this[int i] { get => default; set {} }
	
		// Constructors
		public SparseNativeArray() {}
	
		// Methods
		public void Init(int initCap) {}
		public bool IsEmpty() => default;
		public ref ref T ElementAt(int index) => ref _refReturnTypeForElementAt;
		private ref T _refReturnTypeForElementAt; // Dummy field
		public int InsertValue(T v) => default;
		public void Clear() {}
		public int Allocate() => default;
		public void Remove(int v) {}
	}
}

namespace Beyond.SourceGenerator
{
	internal class DataNAttribute : Attribute // TypeDefIndex: 60674
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 60675
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 60676
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 60677
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 60678
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 60673
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60692
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64160-0x0000000185F641D0
	
		// Methods
		public void __Gen_Wrap_0(ref MemFriendHashSet P0, ref MemFriendHashSet P1) {} // 0x000000018C0BDEA4-0x000000018C0BE03C
		public void __Gen_Wrap_1(ref MemFriendHashSet P0) {} // 0x000000018C0BE03C-0x000000018C0BE170
		public int __Gen_Wrap_2(object P0, int P1) => default; // 0x0000000187677130-0x000000018767721C
		public void __Gen_Wrap_3(object P0, int P1) {} // 0x000000018769E90C-0x000000018769E9E8
		public byte __Gen_Wrap_4(object P0, int P1, int P2) => default; // 0x000000018C0BE170-0x000000018C0BE274
		public void __Gen_Wrap_5(object P0, int P1, int P2, byte P3) {} // 0x000000018C0BE274-0x000000018C0BE37C
		public void __Gen_Wrap_6(object P0) {} // 0x0000000187678964-0x0000000187678A10
		public NativeArray<byte> __Gen_Wrap_7(object P0) => default; // 0x000000018C0BE37C-0x000000018C0BE474
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60693
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018C0BE474-0x000000018C0BE508
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60694
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018C0BE6F0-0x000000018C0BE754
		public static bool IsPatched(int id) => default; // 0x00000001841E78E0-0x00000001841E7950
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018C0BE5AC-0x000000018C0BE678
		public object CreateWrapper(int id) => default; // 0x000000018C0BE678-0x000000018C0BE6F0
		public object InitWrapperArray(int len) => default; // 0x000000018C0BE754-0x000000018C0BE7E0
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018C0BE508-0x000000018C0BE5AC
	}

	public enum IDMAP0 // TypeDefIndex: 60695
	{
		Beyond-Gameplay-Core-MemFriendHashSet-CopyFrom0 = 0,
		Beyond-Gameplay-Core-MemFriendHashSet-Clear0 = 1,
		Beyond-Gameplay-Core-BitContext-_ComputePropBitArrayLength0 = 2,
		Beyond-Gameplay-Core-BitContext-EnLarge0 = 3,
		Beyond-Gameplay-Core-BitContext-Recycle0 = 4,
		Beyond-Gameplay-Core-BitContext-GetState0 = 5,
		Beyond-Gameplay-Core-BitContext-SetState0 = 6,
		Beyond-Gameplay-Core-BitContext-Dispose0 = 7,
		Beyond-Gameplay-Core-GameplayUnsafeUtil-GetNativeArrayFromStream0 = 8
	}
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60671
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 60672
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
