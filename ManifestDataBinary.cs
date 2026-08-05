/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond.ManifestBinary;
using IFix.Core;
using Microsoft.CodeAnalysis;
using Unity.Collections;

// Image 104: ManifestDataBinary.dll - Assembly: ManifestDataBinary, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63266-63281
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.ManifestBinary
{
	public struct RefHashSlot // TypeDefIndex: 63269
	{
		// Fields
		public int offset; // 0x00
		public int bucketsSize; // 0x04
	
		// Methods
		public static int GetSize(); // 0x0000000189F4CF14-0x0000000189F4CF54
	}

	public interface IRefComparer<in T> // TypeDefIndex: 63270
	{
		// Methods
		long GetHashCode(T obj);
	}

	public struct RefMultiHashTable<K, V> : IRefStructInterface // TypeDefIndex: 63272
		where V : struct
	{
		// Fields
		public int capacity;
		private unsafe byte* m_head;
		private unsafe byte* m_slotAddress;
		public IRefComparer<K> m_iComparer;
	
		// Properties
		public RefHashSlot[] slots { get; }
		public bool isCreated { get; }
	
		// Nested types
		public struct RefEnumerator<T> // TypeDefIndex: 63271
			where T : struct
		{
			// Fields
			private readonly unsafe byte* m_address;
			private readonly unsafe byte* m_slotAddress;
			private int m_currentIndex;
			private int m_slotIndex;
			private readonly int m_capacity;
	
			// Properties
			public int slotIndex { get; }
			public IntPtr ptrCurrent { get; }
			public unsafe T* current { get; }
			public T GetCurrent { get; }
	
			// Constructors
			public unsafe RefEnumerator(RefMultiHashTable<K, V> table);
	
			// Methods
			public bool MoveNext();
		}
	
		// Constructors
		public unsafe RefMultiHashTable(IRefComparer<K> iComparer);
	
		// Methods
		public unsafe void Init(byte* data);
		public void Init(IntPtr data);
		public bool ContainsKey(K key);
		public bool ContainsKey(long hash);
		public unsafe RefHashSlot* GetHashSlots(K key, out long hash);
		public unsafe RefHashSlot* GetHashSlots(long hash);
		public unsafe bool TryGetValue(K key, out ref V* item, int valueKeyOffset = 0 /* Metadata: 0x02352754 */);
		public bool TryGetValue(K key, out ref V item, int valueKeyOffset = 0 /* Metadata: 0x02352755 */);
		public bool TryGetValue(K key, ref List<V> array);
		public RefEnumerator GetEnumerator();
		public static RefMultiHashTable<K, V> CreateDynamicTable(NativeArray<V> items, Func<V, int, long> getHash, IRefComparer<K> comparer, Func<string, IntPtr, int, int, IntPtr> createFunc = null);
		public void DestroyRuntimeTable(Func<IntPtr, bool> freeMmapFunc = null);
	}

	public static class RefHashTableRuntimeTest // TypeDefIndex: 63276
	{
		// Nested types
		public struct TestValue // TypeDefIndex: 63273
		{
			// Fields
			public long hashKey; // 0x00
			public int payload; // 0x08
			public int extra; // 0x0C
	
			// Methods
			public override string ToString(); // 0x0000000189F50540-0x0000000189F50634
			public string __iFixBaseProxy_ToString(); // 0x0000000189F50634-0x0000000189F50684
		}
	
		private class TestComparerLong : IRefComparer<long> // TypeDefIndex: 63274
		{
			// Constructors
			public TestComparerLong(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public long GetHashCode(long obj); // 0x0000000189F504EC-0x0000000189F50540
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 63275
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<TestValue, int, long> __9__4_0; // 0x08
			public static Func<TestValue, int, long> __9__5_0; // 0x10
			public static Func<TestValue, int, long> __9__6_0; // 0x18
			public static Func<TestValue, int, long> __9__7_0; // 0x20
			public static Func<TestValue, int, long> __9__8_0; // 0x28
			public static Func<TestValue, int, long> __9__9_0; // 0x30
			public static Func<TestValue, int, long> __9__10_0; // 0x38
			public static Func<TestValue, int, long> __9__11_0; // 0x40
			public static Func<TestValue, int, long> __9__12_0; // 0x48
			public static Func<TestValue, int, long> __9__13_0; // 0x50
			public static Func<TestValue, int, long> __9__13_1; // 0x58
			public static Func<TestValue, int, long> __9__14_0; // 0x60
	
			// Constructors
			static __c(); // 0x0000000189F50684-0x0000000189F506E8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal long _Test_EmptyList_b__4_0(TestValue v, int i); // 0x0000000182A55C30-0x0000000182A55C40
			internal long _Test_SingleElement_b__5_0(TestValue v, int i); // 0x0000000182A55C30-0x0000000182A55C40
			internal long _Test_MultipleElements_NoDuplicate_b__6_0(TestValue v, int i); // 0x0000000182A55C30-0x0000000182A55C40
			internal long _Test_HashCollision_SameSlot_b__7_0(TestValue v, int i); // 0x0000000182A55C30-0x0000000182A55C40
			internal long _Test_ContainsKey_b__8_0(TestValue v, int i); // 0x0000000182A55C30-0x0000000182A55C40
			internal long _Test_NotFoundKey_b__9_0(TestValue v, int i); // 0x0000000182A55C30-0x0000000182A55C40
			internal long _Test_TryGetValueList_MultiResult_b__10_0(TestValue v, int i); // 0x0000000182A55C30-0x0000000182A55C40
			internal long _Test_Enumerator_CountMatch_b__11_0(TestValue v, int i); // 0x0000000182A55C30-0x0000000182A55C40
			internal long _Test_LargeScale_b__12_0(TestValue v, int i); // 0x0000000182A55C30-0x0000000182A55C40
			internal long _Test_MassiveHashCollision_b__13_0(TestValue v, int i); // 0x0000000182A55C30-0x0000000182A55C40
			internal long _Test_MassiveHashCollision_b__13_1(TestValue v, int i); // 0x0000000182A55C30-0x0000000182A55C40
			internal long _Test_IndexAwareGetHash_b__14_0(TestValue v, int i); // 0x0000000184DA38C0-0x0000000184DA38D0
		}
	
		// Methods
		public static void RunAllTests(); // 0x0000000189F4D060-0x0000000189F4D1B0
		private static bool Assert(bool condition, string testName, string msg = "" /* Metadata: 0x02352756 */); // 0x0000000189F4CF54-0x0000000189F4D060
		private static bool Test_EmptyList(); // 0x0000000189F4D4D0-0x0000000189F4D704
		private static bool Test_SingleElement(); // 0x0000000189F4FB78-0x0000000189F4FF30
		private static bool Test_MultipleElements_NoDuplicate(); // 0x0000000189F4F4C4-0x0000000189F4F8A8
		private static bool Test_HashCollision_SameSlot(); // 0x0000000189F4D9F0-0x0000000189F4DEDC
		private static bool Test_ContainsKey(); // 0x0000000189F4D1B0-0x0000000189F4D4D0
		private static bool Test_NotFoundKey(); // 0x0000000189F4F8A8-0x0000000189F4FB78
		private static bool Test_TryGetValueList_MultiResult(); // 0x0000000189F4FF30-0x0000000189F504EC
		private static bool Test_Enumerator_CountMatch(); // 0x0000000189F4D704-0x0000000189F4D9F0
		private static bool Test_LargeScale(); // 0x0000000189F4E28C-0x0000000189F4E750
		private static bool Test_MassiveHashCollision(); // 0x0000000189F4E750-0x0000000189F4F4C4
		private static bool Test_IndexAwareGetHash(); // 0x0000000189F4DEDC-0x0000000189F4E28C
	}

	public interface IRefStructInterface // TypeDefIndex: 63277
	{
		// Methods
		void Init(byte* data);
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63278
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000189F4CE1C-0x0000000189F4CE80
	
		// Methods
		public int __Gen_Wrap_0(); // 0x0000000186377214-0x00000001863772AC
		public long __Gen_Wrap_1(RefHashTableRuntimeTest.TestValue P0, int P1); // 0x0000000189F4CA00-0x0000000189F4CB0C
		public bool __Gen_Wrap_2(bool P0, object P1, object P2); // 0x0000000189F4CB0C-0x0000000189F4CC00
		public bool __Gen_Wrap_3(); // 0x00000001863770B0-0x0000000186377148
		public void __Gen_Wrap_4(); // 0x00000001863761FC-0x0000000186376284
		public string __Gen_Wrap_5(ref RefHashTableRuntimeTest.TestValue P0); // 0x0000000189F4CC00-0x0000000189F4CD44
		public long __Gen_Wrap_6(object P0, long P1); // 0x0000000189F4CD44-0x0000000189F4CE1C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63279
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000189F4CE80-0x0000000189F4CF14
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63280
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000189F508D0-0x0000000189F50934
		public static bool IsPatched(int id); // 0x0000000189F509C0-0x0000000189F50AA0
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000189F5078C-0x0000000189F50858
		public object CreateWrapper(int id); // 0x0000000189F50858-0x0000000189F508D0
		public object InitWrapperArray(int len); // 0x0000000189F50934-0x0000000189F509C0
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000189F506E8-0x0000000189F5078C
	}

	public enum IDMAP0 // TypeDefIndex: 63281
	{
		Beyond-ManifestBinary-RefHashSlot-GetSize0 = 0,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-RunAllTests0 = 1,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_EmptyList0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Assert0 = 17,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_SingleElement0 = 18,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_MultipleElements_NoDuplicate0 = 19,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_HashCollision_SameSlot0 = 20,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_ContainsKey0 = 21,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_NotFoundKey0 = 22,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_TryGetValueList_MultiResult0 = 23,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_Enumerator_CountMatch0 = 24,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_LargeScale0 = 25,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_MassiveHashCollision0 = 26,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_IndexAwareGetHash0 = 27,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-TestValue-ToString0 = 28,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-TestComparerLong-GetHashCode0 = 29
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 63267
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 63268
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
