/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using Beyond.ManifestBinary;
using IFix.Core;
using Unity.Collections;

// Image 101: ManifestDataBinary.dll - Assembly: ManifestDataBinary, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60614-60629

namespace Beyond.ManifestBinary
{
	public struct RefHashSlot // TypeDefIndex: 60617
	{
		// Fields
		public int offset; // 0x00
		public int bucketsSize; // 0x04
	
		// Methods
		public static int GetSize() => default; // 0x000000018AAE6CA8-0x000000018AAE6CE8
	}

	public interface IRefComparer<in T> // TypeDefIndex: 60618
	{
		// Methods
		long GetHashCode(T obj);
	}

	public struct RefMultiHashTable<K, V> : IRefStructInterface // TypeDefIndex: 60620
		where V : struct
	{
		// Fields
		public int capacity;
		private unsafe byte* m_head;
		private unsafe byte* m_slotAddress;
		public IRefComparer<K> m_iComparer;
	
		// Properties
		public RefHashSlot[] slots { get => default; }
		public bool isCreated { get => default; }
	
		// Nested types
		public struct RefEnumerator<T> // TypeDefIndex: 60619
			where T : struct
		{
			// Fields
			private readonly unsafe byte* m_address;
			private readonly unsafe byte* m_slotAddress;
			private int m_currentIndex;
			private int m_slotIndex;
			private readonly int m_capacity;
	
			// Properties
			public int slotIndex { get => default; }
			public IntPtr ptrCurrent { get => default; }
			public unsafe T* current { get => default; }
			public T GetCurrent { get => default; }
	
			// Constructors
			public unsafe RefEnumerator(RefMultiHashTable<K, V> table) : this() {
				m_address = default;
				m_slotAddress = default;
				m_currentIndex = default;
				m_slotIndex = default;
				m_capacity = default;
			}
	
			// Methods
			public bool MoveNext() => default;
		}
	
		// Constructors
		public unsafe RefMultiHashTable(IRefComparer<K> iComparer) : this() {
			capacity = default;
			m_head = default;
			m_slotAddress = default;
			m_iComparer = default;
		}
	
		// Methods
		public unsafe void Init(byte* data) {}
		public void Init(IntPtr data) {}
		public bool ContainsKey(K key) => default;
		public bool ContainsKey(long hash) => default;
		public unsafe RefHashSlot* GetHashSlots(K key, out long hash) {
			hash = default;
			return default;
		}
		public unsafe RefHashSlot* GetHashSlots(long hash) => default;
		public unsafe bool TryGetValue(K key, out ref V* item, int valueKeyOffset = 0 /* Metadata: 0x02082A6C */) {
			item = default;
			return default;
		}
		public bool TryGetValue(K key, out ref V item, int valueKeyOffset = 0 /* Metadata: 0x02082A6D */) {
			item = default;
			return default;
		}
		public bool TryGetValue(K key, ref List<V> array) => default;
		public RefEnumerator GetEnumerator() => default;
		public static RefMultiHashTable<K, V> CreateDynamicTable(NativeArray<V> items, Func<V, int, long> getHash, IRefComparer<K> comparer, Func<string, IntPtr, int, int, IntPtr> createFunc = null) => default;
		public void DestroyRuntimeTable(Func<IntPtr, bool> freeMmapFunc = null) {}
	}

	public static class RefHashTableRuntimeTest // TypeDefIndex: 60624
	{
		// Nested types
		public struct TestValue // TypeDefIndex: 60621
		{
			// Fields
			public long hashKey; // 0x00
			public int payload; // 0x08
			public int extra; // 0x0C
	
			// Methods
			public override string ToString() => default; // 0x000000018AAE6DF4-0x000000018AAE6F44
			public string __iFixBaseProxy_ToString() => default; // 0x000000018AAE6CE8-0x000000018AAE6DF4
		}
	
		private class TestComparerLong : IRefComparer<long> // TypeDefIndex: 60622
		{
			// Constructors
			public TestComparerLong() {} // 0x000000018AAE990C-0x000000018AAE9CC4
	
			// Methods
			public long GetHashCode(long obj) => default; // 0x000000018AAE7264-0x000000018AAE7498
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 60623
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
			static __c() {} // 0x000000018AAE9258-0x000000018AAE963C
			public __c() {} // 0x000000018AAE7784-0x000000018AAE7C70
	
			// Methods
			internal long _Test_EmptyList_b__4_0(TestValue v, int i) => default; // 0x000000018AAE6F44-0x000000018AAE7264
			internal long _Test_SingleElement_b__5_0(TestValue v, int i) => default; // 0x000000018AAE963C-0x000000018AAE990C
			internal long _Test_MultipleElements_NoDuplicate_b__6_0(TestValue v, int i) => default; // 0x000000018AAE9CC4-0x000000018AAEA280
			internal long _Test_HashCollision_SameSlot_b__7_0(TestValue v, int i) => default; // 0x000000018AAE7498-0x000000018AAE7784
			internal long _Test_ContainsKey_b__8_0(TestValue v, int i) => default; // 0x000000018AAE8020-0x000000018AAE84E4
			internal long _Test_NotFoundKey_b__9_0(TestValue v, int i) => default; // 0x000000018AAE84E4-0x000000018AAE9258
			internal long _Test_TryGetValueList_MultiResult_b__10_0(TestValue v, int i) => default; // 0x000000018AAE7C70-0x000000018AAE8020
			internal long _Test_Enumerator_CountMatch_b__11_0(TestValue v, int i) => default; // 0x000000018AAEA2D4-0x000000018AAEA3C8
			internal long _Test_LargeScale_b__12_0(TestValue v, int i) => default; // 0x000000018AAEA3C8-0x000000018AAEA418
			internal long _Test_MassiveHashCollision_b__13_0(TestValue v, int i) => default; // 0x000000018AAEA280-0x000000018AAEA2D4
			internal long _Test_MassiveHashCollision_b__13_1(TestValue v, int i) => default; // 0x0000000185492010-0x0000000185492020
			internal long _Test_IndexAwareGetHash_b__14_0(TestValue v, int i) => default; // 0x000000018AAEA418-0x000000018AAEA47C
		}
	
		// Methods
		public static void RunAllTests() {} // 0x0000000185492010-0x0000000185492020
		private static bool Assert(bool condition, string testName, string msg = "" /* Metadata: 0x02082A6E */) => default; // 0x000000018305C9B0-0x000000018305C9C0
		private static bool Test_EmptyList() => default; // 0x000000018305C9B0-0x000000018305C9C0
		private static bool Test_SingleElement() => default; // 0x000000018305C9B0-0x000000018305C9C0
		private static bool Test_MultipleElements_NoDuplicate() => default; // 0x000000018305C9B0-0x000000018305C9C0
		private static bool Test_HashCollision_SameSlot() => default; // 0x000000018305C9B0-0x000000018305C9C0
		private static bool Test_ContainsKey() => default; // 0x000000018305C9B0-0x000000018305C9C0
		private static bool Test_NotFoundKey() => default; // 0x000000018305C9B0-0x000000018305C9C0
		private static bool Test_TryGetValueList_MultiResult() => default; // 0x000000018305C9B0-0x000000018305C9C0
		private static bool Test_Enumerator_CountMatch() => default; // 0x000000018305C9B0-0x000000018305C9C0
		private static bool Test_LargeScale() => default; // 0x000000018305C9B0-0x000000018305C9C0
		private static bool Test_MassiveHashCollision() => default; // 0x000000018305C9B0-0x000000018305C9C0
		private static bool Test_IndexAwareGetHash() => default; // 0x0000000185FCF080-0x0000000185FCF090
	}

	public interface IRefStructInterface // TypeDefIndex: 60625
	{
		// Methods
		void Init(byte* data);
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60626
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x000000018AAE6BB0-0x000000018AAE6C14
	
		// Methods
		public int __Gen_Wrap_0() => default; // 0x0000000187352750-0x00000001873527E8
		public long __Gen_Wrap_1(RefHashTableRuntimeTest.TestValue P0, int P1) => default; // 0x000000018AAE6794-0x000000018AAE68A0
		public bool __Gen_Wrap_2(bool P0, object P1, object P2) => default; // 0x000000018AAE68A0-0x000000018AAE6994
		public bool __Gen_Wrap_3() => default; // 0x0000000187352600-0x0000000187352698
		public void __Gen_Wrap_4() {} // 0x0000000187350FD4-0x000000018735105C
		public string __Gen_Wrap_5(ref RefHashTableRuntimeTest.TestValue P0) => default; // 0x000000018AAE6994-0x000000018AAE6AD8
		public long __Gen_Wrap_6(object P0, long P1) => default; // 0x000000018AAE6AD8-0x000000018AAE6BB0
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60627
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018AAE6C14-0x000000018AAE6CA8
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60628
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018AAEA664-0x000000018AAEA6C8
		public static bool IsPatched(int id) => default; // 0x000000018AAEA754-0x000000018AAEA834
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018AAEA520-0x000000018AAEA5EC
		public object CreateWrapper(int id) => default; // 0x000000018AAEA5EC-0x000000018AAEA664
		public object InitWrapperArray(int len) => default; // 0x000000018AAEA6C8-0x000000018AAEA754
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018AAEA47C-0x000000018AAEA520
	}

	public enum IDMAP0 // TypeDefIndex: 60629
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
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60615
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 60616
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
