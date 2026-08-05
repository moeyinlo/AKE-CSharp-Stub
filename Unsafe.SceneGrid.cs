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

// Image 114: Unsafe.SceneGrid.dll - Assembly: Unsafe.SceneGrid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63525-63549
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Gameplay.Core
{
	public struct FDictionary4<Tk, Tv> // TypeDefIndex: 63535
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
		public struct FDictionaryEnumerator // TypeDefIndex: 63534
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

	public struct FDictionary16<Tk, Tv> // TypeDefIndex: 63537
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
		public struct FDictionaryEnumerator // TypeDefIndex: 63536
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

	public class MemFriendSetContextManager<T> // TypeDefIndex: 63538
		where T : struct
	{
		// Fields
		private const int ARRAY_CACHE_SIZE = 32; // Metadata: 0x02352853
		private const int SEQ_SET_MAX = 8; // Metadata: 0x02352854
		private const int INIT_SET_CAP = 2048; // Metadata: 0x02352855
		private const int MAX_SET_CAP = 65536; // Metadata: 0x02352857
		private const int INIT_MIN_CAP = 2; // Metadata: 0x0235285B
		public const int MAX_CONTENT_SIZE = 2097152; // Metadata: 0x0235285C
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

	public struct PureEnumerator<T> // TypeDefIndex: 63539
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

	public struct MemFriendHashSet // TypeDefIndex: 63540
	{
		// Fields
		public int start; // 0x00
		public int cap; // 0x04
		public int count; // 0x08
		public int bitStart; // 0x0C
	
		// Methods
		public void CopyFrom(ref MemFriendHashSet other); // 0x00000001836B5F60-0x00000001836B5FB0
		public void Clear(); // 0x00000001836B6220-0x00000001836B6250
	}

	public abstract class MemFriendSetContextBase<T> : IDisposable // TypeDefIndex: 63541
		where T : struct
	{
		// Fields
		protected NativeArray<T> m_content;
		protected readonly int m_singleElementSize;
		public const int INVALID_CONTENT_INDEX = -1; // Metadata: 0x02352860
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

	public class BitContext : IDisposable // TypeDefIndex: 63542
	{
		// Fields
		public NativeArray<byte> bits; // 0x10
		public const int ONE_SLOT_BIT_NUM = 8; // Metadata: 0x02352861
		public const int ONE_STATE_BIT_NUM = 2; // Metadata: 0x02352862
		public const int ONE_SLOT_ELEMENT_NUM = 4; // Metadata: 0x02352863
		public const byte MASK = 3; // Metadata: 0x02352864
		public const byte FREE = 0; // Metadata: 0x02352865
		public const byte OCCUPIED = 1; // Metadata: 0x02352866
		public const byte USED = 2; // Metadata: 0x02352867
		private readonly int m_elementBitSlot; // 0x20
		private unsafe byte* m_ptr; // 0x28
	
		// Constructors
		public BitContext(int initSize, int singleElementSize); // 0x00000001836B52A0-0x00000001836B5350
	
		// Methods
		private int _ComputePropBitArrayLength(int contentLength); // 0x00000001836B5350-0x00000001836B53A0
		public void EnLarge(int contentSize); // 0x000000018B5A9F4C-0x000000018B5AA040
		public void Recycle(int bitIndex); // 0x00000001836B5830-0x00000001836B5880
		public int GetBitStartIndex(int index); // 0x000000018B5AA040-0x000000018B5AA04C
		private void _CalculateBitIndexAndMask(int bitStateStartIndex, int index, out int finalIndex, out int offsetInternal); // 0x0000000184DBF4B0-0x0000000184DBF4E0
		public byte GetState(int bitStateStartIndex, int index); // 0x00000001836B6590-0x00000001836B6630
		public void SetState(int bitStateStartIndex, int index, byte state); // 0x00000001836B6250-0x00000001836B62E0
		public void Dispose(); // 0x000000018B5A9EC0-0x000000018B5A9F4C
	}

	public class MemFriendNormalSetContext<T> : MemFriendSetContextBase<T> // TypeDefIndex: 63543
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

	public class MemFriendSeqSetContext<T> : MemFriendSetContextBase<T> // TypeDefIndex: 63544
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

	public static class GameplayUnsafeUtil // TypeDefIndex: 63545
	{
		// Methods
		public static byte[] NativeArrayToBytes<T>(NativeArray<T> nativeArray)
			where T : struct;
		public static NativeArray<byte> GetNativeArrayFromStream(Stream stream); // 0x000000018B5AA04C-0x000000018B5AA17C
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 63529
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 63530
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 63531
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 63532
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 63533
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 63528
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63546
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D371E0-0x0000000184D37250
	
		// Methods
		public void __Gen_Wrap_0(ref MemFriendHashSet P0, ref MemFriendHashSet P1); // 0x000000018B5AA17C-0x000000018B5AA314
		public void __Gen_Wrap_1(ref MemFriendHashSet P0); // 0x000000018B5AA314-0x000000018B5AA448
		public int __Gen_Wrap_2(object P0, int P1); // 0x00000001866C13F0-0x00000001866C14DC
		public void __Gen_Wrap_3(object P0, int P1); // 0x00000001866F3838-0x00000001866F3914
		public byte __Gen_Wrap_4(object P0, int P1, int P2); // 0x000000018698CC40-0x000000018698CD44
		public void __Gen_Wrap_5(object P0, int P1, int P2, byte P3); // 0x000000018B5AA448-0x000000018B5AA550
		public void __Gen_Wrap_6(object P0); // 0x00000001866C296C-0x00000001866C2A18
		public NativeArray<byte> __Gen_Wrap_7(object P0); // 0x000000018B5AA550-0x000000018B5AA648
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63547
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018B5AA648-0x000000018B5AA6DC
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63548
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018B5AA8C4-0x000000018B5AA928
		public static bool IsPatched(int id); // 0x00000001836B6630-0x00000001836B6680
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018B5AA780-0x000000018B5AA84C
		public object CreateWrapper(int id); // 0x000000018B5AA84C-0x000000018B5AA8C4
		public object InitWrapperArray(int len); // 0x000000018B5AA928-0x000000018B5AA9B4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018B5AA6DC-0x000000018B5AA780
	}

	public enum IDMAP0 // TypeDefIndex: 63549
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
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 63526
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 63527
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
