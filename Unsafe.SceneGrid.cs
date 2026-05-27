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
using Unity.Collections;

// Image 101: Unsafe.SceneGrid.dll - Assembly: Unsafe.SceneGrid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59566-59591
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Gameplay.Core
{
	public struct FDictionary4<Tk, Tv> // TypeDefIndex: 59576
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
		public struct FDictionaryEnumerator // TypeDefIndex: 59575
		{
			// Fields
			public unsafe FDictionary4<Tk, Tv>* ptr;
			private int m_pos;
	
			// Properties
			[TupleElementNames(new string[2] {"key", "v" })]
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

	public struct FDictionary16<Tk, Tv> // TypeDefIndex: 59578
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
		public struct FDictionaryEnumerator // TypeDefIndex: 59577
		{
			// Fields
			public unsafe FDictionary16<Tk, Tv>* ptr;
			private int m_pos;
	
			// Properties
			[TupleElementNames(new string[2] {"key", "v" })]
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

	public class MemFriendSetContextManager<T> // TypeDefIndex: 59579
		where T : struct
	{
		// Fields
		private const int ARRAY_CACHE_SIZE = 32; // Metadata: 0x01FDD1D2
		private const int SEQ_SET_MAX = 8; // Metadata: 0x01FDD1D3
		private const int INIT_SET_CAP = 2048; // Metadata: 0x01FDD1D4
		private const int MAX_SET_CAP = 65536; // Metadata: 0x01FDD1D6
		private const int INIT_MIN_CAP = 2; // Metadata: 0x01FDD1DA
		public const int MAX_CONTENT_SIZE = 2097152; // Metadata: 0x01FDD1DB
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

	public struct PureEnumerator<T> // TypeDefIndex: 59580
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

	public struct MemFriendHashSet // TypeDefIndex: 59581
	{
		// Fields
		public int start; // 0x00
		public int cap; // 0x04
		public int count; // 0x08
		public int bitStart; // 0x0C
	
		// Methods
		public void CopyFrom(ref MemFriendHashSet other) {} // 0x0000000182A251A0-0x0000000182A251F0
		public void Clear() {} // 0x0000000182A243A0-0x0000000182A243D0
	}

	public abstract class MemFriendSetContextBase<T> : IDisposable // TypeDefIndex: 59582
		where T : struct
	{
		// Fields
		protected NativeArray<T> m_content;
		protected readonly int m_singleElementSize;
		public const int INVALID_CONTENT_INDEX = -1; // Metadata: 0x01FDD1DF
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

	public class BitContext : IDisposable // TypeDefIndex: 59583
	{
		// Fields
		public NativeArray<byte> bits; // 0x10
		public const int ONE_SLOT_BIT_NUM = 8; // Metadata: 0x01FDD1E0
		public const int ONE_STATE_BIT_NUM = 2; // Metadata: 0x01FDD1E1
		public const int ONE_SLOT_ELEMENT_NUM = 4; // Metadata: 0x01FDD1E2
		public const byte MASK = 3; // Metadata: 0x01FDD1E3
		public const byte FREE = 0; // Metadata: 0x01FDD1E4
		public const byte OCCUPIED = 1; // Metadata: 0x01FDD1E5
		public const byte USED = 2; // Metadata: 0x01FDD1E6
		private readonly int m_elementBitSlot; // 0x20
		private unsafe byte* m_ptr; // 0x28
	
		// Constructors
		public BitContext() {} // Dummy constructor
		public BitContext(int initSize, int singleElementSize) {} // 0x000000018370C650-0x000000018370C700
	
		// Methods
		private int _ComputePropBitArrayLength(int contentLength) => default; // 0x000000018370C700-0x000000018370C830
		public void EnLarge(int contentSize) {} // 0x0000000189FA5CB8-0x0000000189FA5DAC
		public void Recycle(int bitIndex) {} // 0x0000000182514A80-0x0000000182514AD0
		public int GetBitStartIndex(int index) => default; // 0x0000000189FA5DAC-0x0000000189FA5DB8
		private void _CalculateBitIndexAndMask(int bitStateStartIndex, int index, out int finalIndex, out int offsetInternal) {
			finalIndex = default;
			offsetInternal = default;
		} // 0x0000000183D8A000-0x0000000183D8A030
		public byte GetState(int bitStateStartIndex, int index) => default; // 0x0000000182A25060-0x0000000182A25130
		public void SetState(int bitStateStartIndex, int index, byte state) {} // 0x0000000182A24CF0-0x0000000182A24D80
		public void Dispose() {} // 0x0000000189FA5C2C-0x0000000189FA5CB8
	}

	public class MemFriendNormalSetContext<T> : MemFriendSetContextBase<T> // TypeDefIndex: 59584
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

	public class MemFriendSeqSetContext<T> : MemFriendSetContextBase<T> // TypeDefIndex: 59585
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

	public static class GameplayUnsafeUtil // TypeDefIndex: 59586
	{
		// Methods
		public static byte[] NativeArrayToBytes<T>(NativeArray<T> nativeArray)
			where T : struct => default;
		public static NativeArray<byte> GetNativeArrayFromStream(Stream stream) => default; // 0x0000000189FA5DB8-0x0000000189FA5EE8
	}

	public class SparseNativeArray<T> // TypeDefIndex: 59587
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
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 59570
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 59571
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 59572
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 59573
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 59574
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 59569
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59588
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05870-0x0000000183D058E0
	
		// Methods
		public void __Gen_Wrap_0(ref MemFriendHashSet P0, ref MemFriendHashSet P1) {} // 0x0000000189FA5EE8-0x0000000189FA6080
		public void __Gen_Wrap_1(ref MemFriendHashSet P0) {} // 0x0000000189FA6080-0x0000000189FA61B4
		public int __Gen_Wrap_2(object P0, int P1) => default; // 0x00000001854761A8-0x0000000185476294
		public void __Gen_Wrap_3(object P0, int P1) {} // 0x000000018549D548-0x000000018549D624
		public byte __Gen_Wrap_4(object P0, int P1, int P2) => default; // 0x0000000185645B10-0x0000000185645C14
		public void __Gen_Wrap_5(object P0, int P1, int P2, byte P3) {} // 0x0000000189FA61B4-0x0000000189FA62BC
		public void __Gen_Wrap_6(object P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public NativeArray<byte> __Gen_Wrap_7(object P0) => default; // 0x0000000189FA62BC-0x0000000189FA63B4
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 59589
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000189FA63B4-0x0000000189FA6448
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 59590
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000189FA6630-0x0000000189FA6694
		public static bool IsPatched(int id) => default; // 0x0000000182A25130-0x0000000182A251A0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000189FA64EC-0x0000000189FA65B8
		public object CreateWrapper(int id) => default; // 0x0000000189FA65B8-0x0000000189FA6630
		public object InitWrapperArray(int len) => default; // 0x0000000189FA6694-0x0000000189FA6720
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000189FA6448-0x0000000189FA64EC
	}

	public enum IDMAP0 // TypeDefIndex: 59591
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
