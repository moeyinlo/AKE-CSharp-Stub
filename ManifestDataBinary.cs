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

// Image 105: ManifestDataBinary.dll - Assembly: ManifestDataBinary, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90718-90739

namespace Beyond.ManifestBinary
{
	public struct RefHashSlot // TypeDefIndex: 90721
	{
		// Fields
		public int offset; // 0x00
		public int bucketsSize; // 0x04
	
		// Methods
		public static int GetSize(); // 0x000000018C36F770-0x000000018C36F7AC
	}

	public interface IRefComparer<in T> // TypeDefIndex: 90722
	{
		// Methods
		long GetHashCode(T obj);
	}

	public struct RefMultiHashTable<K, V> : IRefStructInterface // TypeDefIndex: 90724
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
		public struct RefEnumerator<T> // TypeDefIndex: 90723
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
		public unsafe bool TryGetValue(K key, out ref V* item, int valueKeyOffset = 0 /* Metadata: 0x0264B109 */);
		public bool TryGetValue(K key, out ref V item, int valueKeyOffset = 0 /* Metadata: 0x0264B10A */);
		public bool TryGetValue(K key, ref List<V> array);
		public RefEnumerator GetEnumerator();
		public static RefMultiHashTable<K, V> CreateDynamicTable(NativeArray<V> items, Func<V, int, long> getHash, IRefComparer<K> comparer, Func<string, IntPtr, int, int, IntPtr> createFunc = null);
		public void DestroyRuntimeTable(Func<IntPtr, bool> freeMmapFunc = null);
	}

	public static class RefHashTableRuntimeTest // TypeDefIndex: 90728
	{
		// Nested types
		public struct TestValue // TypeDefIndex: 90725
		{
			// Fields
			public long hashKey; // 0x00
			public int payload; // 0x08
			public int extra; // 0x0C
	
			// Methods
			public override string ToString(); // 0x000000018C372DE0-0x000000018C372ED8
			public string __iFixBaseProxy_ToString(); // 0x000000018C372ED8-0x000000018C372F28
		}
	
		private class TestComparerLong : IRefComparer<long> // TypeDefIndex: 90726
		{
			// Constructors
			public TestComparerLong(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public long GetHashCode(long obj); // 0x000000018C372DA4-0x000000018C372DE0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 90727
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
			static __c(); // 0x000000018C372F28-0x000000018C372F8C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal long _Test_EmptyList_b__4_0(TestValue v, int i); // 0x00000001841B1140-0x00000001841B1150
			internal long _Test_SingleElement_b__5_0(TestValue v, int i); // 0x00000001841B1140-0x00000001841B1150
			internal long _Test_MultipleElements_NoDuplicate_b__6_0(TestValue v, int i); // 0x00000001841B1140-0x00000001841B1150
			internal long _Test_HashCollision_SameSlot_b__7_0(TestValue v, int i); // 0x00000001841B1140-0x00000001841B1150
			internal long _Test_ContainsKey_b__8_0(TestValue v, int i); // 0x00000001841B1140-0x00000001841B1150
			internal long _Test_NotFoundKey_b__9_0(TestValue v, int i); // 0x00000001841B1140-0x00000001841B1150
			internal long _Test_TryGetValueList_MultiResult_b__10_0(TestValue v, int i); // 0x00000001841B1140-0x00000001841B1150
			internal long _Test_Enumerator_CountMatch_b__11_0(TestValue v, int i); // 0x00000001841B1140-0x00000001841B1150
			internal long _Test_LargeScale_b__12_0(TestValue v, int i); // 0x00000001841B1140-0x00000001841B1150
			internal long _Test_MassiveHashCollision_b__13_0(TestValue v, int i); // 0x00000001841B1140-0x00000001841B1150
			internal long _Test_MassiveHashCollision_b__13_1(TestValue v, int i); // 0x00000001841B1140-0x00000001841B1150
			internal long _Test_IndexAwareGetHash_b__14_0(TestValue v, int i); // 0x0000000187251460-0x0000000187251470
		}
	
		// Methods
		public static void RunAllTests(); // 0x000000018C36F8C4-0x000000018C36FA10
		private static bool Assert(bool condition, string testName, string msg = "" /* Metadata: 0x0264B10B */); // 0x000000018C36F7AC-0x000000018C36F8C4
		private static bool Test_EmptyList(); // 0x000000018C36FD34-0x000000018C36FF6C
		private static bool Test_SingleElement(); // 0x000000018C372420-0x000000018C3727E4
		private static bool Test_MultipleElements_NoDuplicate(); // 0x000000018C371D60-0x000000018C37214C
		private static bool Test_HashCollision_SameSlot(); // 0x000000018C370264-0x000000018C370758
		private static bool Test_ContainsKey(); // 0x000000018C36FA10-0x000000018C36FD34
		private static bool Test_NotFoundKey(); // 0x000000018C37214C-0x000000018C372420
		private static bool Test_TryGetValueList_MultiResult(); // 0x000000018C3727E4-0x000000018C372DA4
		private static bool Test_Enumerator_CountMatch(); // 0x000000018C36FF6C-0x000000018C370264
		private static bool Test_LargeScale(); // 0x000000018C370B14-0x000000018C370FE4
		private static bool Test_MassiveHashCollision(); // 0x000000018C370FE4-0x000000018C371D60
		private static bool Test_IndexAwareGetHash(); // 0x000000018C370758-0x000000018C370B14
	}

	public interface IRefStructInterface // TypeDefIndex: 90729
	{
		// Methods
		void Init(byte* data);
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 90730
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018C36F674-0x000000018C36F6D8
	
		// Methods
		public int __Gen_Wrap_0(); // 0x00000001887ECCD0-0x00000001887ECD6C
		public long __Gen_Wrap_1(RefHashTableRuntimeTest.TestValue P0, int P1); // 0x000000018C36F320-0x000000018C36F434
		public bool __Gen_Wrap_2(bool P0, object P1, object P2); // 0x000000018C36F434-0x000000018C36F52C
		public bool __Gen_Wrap_3(); // 0x00000001887ECE94-0x00000001887ECF30
		public void __Gen_Wrap_4(); // 0x00000001887ED074-0x00000001887ED104
		public string __Gen_Wrap_5(ref RefHashTableRuntimeTest.TestValue P0); // 0x000000018C36F52C-0x000000018C36F674
		public long __Gen_Wrap_6(object P0, long P1); // 0x0000000188B4AF54-0x0000000188B4B034
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 90731
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018C36F6D8-0x000000018C36F770
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 90732
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018C373178-0x000000018C3731DC
		public static bool IsPatched(int id); // 0x000000018C373268-0x000000018C373348
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018C373030-0x000000018C3730FC
		public object CreateWrapper(int id); // 0x000000018C3730FC-0x000000018C373178
		public object InitWrapperArray(int len); // 0x000000018C3731DC-0x000000018C373268
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018C372F8C-0x000000018C373030
	}

	public delegate int __HotPatchDelegate_0(); // TypeDefIndex: 90733; 0x0000000185B44B70-0x0000000185B44B80

	public enum HotPatchIDMAP0 // TypeDefIndex: 90734
	{
		Beyond-ManifestBinary-RefHashSlot-GetSize0 = 0,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Assert0 = 1,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_EmptyList0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_SingleElement0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_MultipleElements_NoDuplicate0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_HashCollision_SameSlot0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_ContainsKey0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_NotFoundKey0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_TryGetValueList_MultiResult0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_Enumerator_CountMatch0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_LargeScale0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_MassiveHashCollision0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-Test_IndexAwareGetHash0 = 2,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-RunAllTests0 = 3,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-TestValue-ToString0 = 4,
		Beyond-ManifestBinary-RefHashTableRuntimeTest-TestComparerLong-GetHashCode0 = 5
	}

	public delegate bool __HotPatchDelegate_1(bool P0, object P1, object P2); // TypeDefIndex: 90735; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_2(); // TypeDefIndex: 90736; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_3(); // TypeDefIndex: 90737; 0x0000000185B44B70-0x0000000185B44B80

	public delegate string __HotPatchDelegate_4(ref RefHashTableRuntimeTest.TestValue P0); // TypeDefIndex: 90738; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate long __HotPatchDelegate_5(object P0, long P1); // TypeDefIndex: 90739; 0x00000001859B7730-0x00000001859B7740
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 90719
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 90720
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
