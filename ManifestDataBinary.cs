/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond.ManifestBinary;
using IFix.Core;
using Unity.Collections;

// Image 98: ManifestDataBinary.dll - Assembly: ManifestDataBinary, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59510-59525
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.ManifestBinary
{
	public struct RefHashSlot // TypeDefIndex: 59513
	{
		// Fields
		public int offset; // 0x00
		public int bucketsSize; // 0x04
	
		// Methods
		public static int GetSize() => default; // 0x00000001889D3A9C-0x00000001889D3ADC
	}

	public interface IRefComparer<in T> // TypeDefIndex: 59514
	{
		// Methods
		long GetHashCode(T obj);
	}

	public struct RefMultiHashTable<K, V> : IRefStructInterface // TypeDefIndex: 59516
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
		public struct RefEnumerator<T> // TypeDefIndex: 59515
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
		public unsafe bool TryGetValue(K key, out ref V* item, int valueKeyOffset = 0 /* Metadata: 0x01FDD180 */) {
			item = default;
			return default;
		}
		public bool TryGetValue(K key, out ref V item, int valueKeyOffset = 0 /* Metadata: 0x01FDD181 */) {
			item = default;
			return default;
		}
		public bool TryGetValue(K key, ref List<V> array) => default;
		public RefEnumerator GetEnumerator() => default;
		public static RefMultiHashTable<K, V> CreateDynamicTable(NativeArray<V> items, Func<V, int, long> getHash, IRefComparer<K> comparer, Func<string, IntPtr, int, int, IntPtr> createFunc = null) => default;
		public void DestroyRuntimeTable(Func<IntPtr, bool> freeMmapFunc = null) {}
	}

	public static class RefHashTableRuntimeTest // TypeDefIndex: 59520
	{
		// Nested types
		public struct TestValue // TypeDefIndex: 59517
		{
			// Fields
			public long hashKey; // 0x00
			public int payload; // 0x08
			public int extra; // 0x0C
	
			// Methods
			public override string ToString() => default; // 0x00000001889D70C8-0x00000001889D71BC
			public string __iFixBaseProxy_ToString() => default; // 0x00000001889D71BC-0x00000001889D720C
		}
	
		private class TestComparerLong : IRefComparer<long> // TypeDefIndex: 59518
		{
			// Constructors
			public TestComparerLong() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public long GetHashCode(long obj) => default; // 0x00000001889D7074-0x00000001889D70C8
		}
	
		// Methods
		public static void RunAllTests() {} // 0x00000001889D3BE8-0x00000001889D3D38
		private static bool Assert(bool condition, string testName, string msg = "" /* Metadata: 0x01FDD182 */) => default; // 0x00000001889D3ADC-0x00000001889D3BE8
		private static bool Test_EmptyList() => default; // 0x00000001889D4058-0x00000001889D428C
		private static bool Test_SingleElement() => default; // 0x00000001889D6700-0x00000001889D6AB8
		private static bool Test_MultipleElements_NoDuplicate() => default; // 0x00000001889D604C-0x00000001889D6430
		private static bool Test_HashCollision_SameSlot() => default; // 0x00000001889D4578-0x00000001889D4A64
		private static bool Test_ContainsKey() => default; // 0x00000001889D3D38-0x00000001889D4058
		private static bool Test_NotFoundKey() => default; // 0x00000001889D6430-0x00000001889D6700
		private static bool Test_TryGetValueList_MultiResult() => default; // 0x00000001889D6AB8-0x00000001889D7074
		private static bool Test_Enumerator_CountMatch() => default; // 0x00000001889D428C-0x00000001889D4578
		private static bool Test_LargeScale() => default; // 0x00000001889D4E14-0x00000001889D52D8
		private static bool Test_MassiveHashCollision() => default; // 0x00000001889D52D8-0x00000001889D604C
		private static bool Test_IndexAwareGetHash() => default; // 0x00000001889D4A64-0x00000001889D4E14
	}

	public interface IRefStructInterface // TypeDefIndex: 59521
	{
		// Methods
		void Init(byte* data);
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59522
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x00000001889D39A4-0x00000001889D3A08
	
		// Methods
		public int __Gen_Wrap_0() => default; // 0x00000001850F1DD4-0x00000001850F1E6C
		public long __Gen_Wrap_1(RefHashTableRuntimeTest.TestValue P0, int P1) => default; // 0x00000001889D3660-0x00000001889D376C
		public bool __Gen_Wrap_2(bool P0, object P1, object P2) => default; // 0x00000001889D376C-0x00000001889D3860
		public bool __Gen_Wrap_3() => default; // 0x00000001850F1D3C-0x00000001850F1DD4
		public void __Gen_Wrap_4() {} // 0x00000001851624BC-0x0000000185162544
		public string __Gen_Wrap_5(ref RefHashTableRuntimeTest.TestValue P0) => default; // 0x00000001889D3860-0x00000001889D39A4
		public long __Gen_Wrap_6(object P0, long P1) => default; // 0x0000000185606B44-0x0000000185606C1C
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 59523
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001889D3A08-0x00000001889D3A9C
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 59524
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001889D7458-0x00000001889D74BC
		public static bool IsPatched(int id) => default; // 0x00000001889D7548-0x00000001889D7628
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001889D7314-0x00000001889D73E0
		public object CreateWrapper(int id) => default; // 0x00000001889D73E0-0x00000001889D7458
		public object InitWrapperArray(int len) => default; // 0x00000001889D74BC-0x00000001889D7548
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001889D7270-0x00000001889D7314
	}

	public enum IDMAP0 // TypeDefIndex: 59525
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
