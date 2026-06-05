/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using Beyond.Reflection;
using Beyond.SparkBuffer;
using Beyond.SparkBuffer.Runtime;
using Beyond.SparkBuffer.Runtime.Wrapper;
using IFix.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Unity.Collections;
using UnityEngine.Pool;

// Image 57: Unsafe.Beyond.dll - Assembly: Unsafe.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58697-58797

namespace Beyond.Reflection
{
	public class MethodPointerManager // TypeDefIndex: 58789
	{
		// Constructors
		public MethodPointerManager() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static T2 CallPointer<T1, T2>(IntPtr ptr, T1 param) => default;
		public static TRet CallDelegatePointer<TParam1, TRet>(IntPtr ptr, TParam1 target) => default;
		public static TRet CallDelegatePointer<TParam1, TParam2, TRet>(IntPtr ptr, TParam1 target, TParam2 param) => default;
		public static ValueTuple<IntPtr, T1> GetDelegatePointer<T1>(Delegate d) => default;
		public static IntPtr GetDelegatePointer(MethodInfo d) => default; // 0x000000018C0BB6A8-0x000000018C0BB6F8
	}

	public static class ObjectPointerHelper // TypeDefIndex: 58790
	{
		// Methods
		public static IntPtr GetIntPtr<T>(ref ref T value)
			where T : struct => default;
		public static IntPtr GetArrayPtr<T>(T[] value)
			where T : struct => default;
		public static T GetStructByPointer<T>(IntPtr ptr)
			where T : struct => default;
		public static T GetValue<T>(IntPtr ptr, int offset)
			where T : struct => default;
		public static T GetArrayElement<T>(IntPtr array, int index)
			where T : struct => default;
		public static void SetValue<T>(IntPtr ptr, int offset, T value)
			where T : struct {}
		public static void SetArrayElement<T>(IntPtr array, int index, T value)
			where T : struct {}
		public static unsafe void SetValue(IntPtr ptr, int offset, byte* data, int size) {} // 0x000000018C0BB8C4-0x000000018C0BB8D8
		public static object GetObj(IntPtr ptr, int offset) => default; // 0x000000018C0BB764-0x000000018C0BB7A0
		public static void SetObj(IntPtr ptr, int offset, object value) {} // 0x000000018C0BB874-0x000000018C0BB8C4
		public static void CopyValue(IntPtr target, IntPtr source, int size) {} // 0x000000018C0BB75C-0x000000018C0BB764
		public static unsafe void CopyValue(void* target, void* source, int size) {} // 0x000000018C0BB75C-0x000000018C0BB764
		public static unsafe void CopyValue(byte* to, byte* from, int size) {} // 0x000000018C0BB6F8-0x000000018C0BB75C
		public static ReadOnlySpan<byte> GetReadOnlySpan(IntPtr ptr, int maxLength) => default; // 0x000000018C0BB7A0-0x000000018C0BB874
	}

	public class StructMemManager // TypeDefIndex: 58791
	{
		// Fields
		private static Dictionary<int, ValueTuple<HashSet<long>, List<IntPtr>>> s_structMemDict; // 0x00
	
		// Constructors
		public StructMemManager() {} // 0x0000000185492010-0x0000000185492020
		static StructMemManager() {} // 0x000000018C0BC434-0x000000018C0BC4C0
	
		// Methods
		public static IntPtr GetMemoryBySize(int size) => default; // 0x000000018C0BC1D4-0x000000018C0BC434
		public static void FreeMemory(int size, IntPtr ptr) {} // 0x000000018C0BC0A4-0x000000018C0BC1D4
		public static void ClearMemory() {} // 0x000000018C0BB96C-0x000000018C0BBCAC
		public static string DumpMemory() => default; // 0x000000018C0BBCAC-0x000000018C0BC0A4
	}

	public class StructPtrRefrenceManager // TypeDefIndex: 58792
	{
		// Fields
		private static Dictionary<object, object> s_refDic; // 0x00
		private static Dictionary<System.Type, List<int>> s_structPtrOffsetDic; // 0x08
	
		// Constructors
		public StructPtrRefrenceManager() {} // 0x0000000185492010-0x0000000185492020
		static StructPtrRefrenceManager() {} // 0x0000000185EB7670-0x0000000185EB7760
	
		// Methods
		private static void _RunOnStart() {} // 0x0000000184C1EE90-0x0000000184C1EF50
		public static void AddObjInPtrRef(System.Type type, IntPtr ptr) {} // 0x000000018C0BC4C0-0x000000018C0BC78C
		public static void RemoveObjInPtrRef(System.Type type, IntPtr ptr) {} // 0x000000018C0BC78C-0x000000018C0BCA14
	}

	public class StructPtrWrapper // TypeDefIndex: 58793
	{
		// Fields
		public IntPtr ptr; // 0x10
		public int size; // 0x18
		public System.Type type; // 0x20
		private static ObjectPool<StructPtrWrapper> s_pool; // 0x00
		private static IntPtr s_ptr; // 0x08
		private static int s_size; // 0x10
		private static System.Type s_type; // 0x18
		private static object s_structObj; // 0x20
	
		// Constructors
		public StructPtrWrapper() {} // Dummy constructor
		public StructPtrWrapper(IntPtr ptr, int size, System.Type type) {} // 0x000000018C0BD740-0x000000018C0BD7CC
		public StructPtrWrapper(object structObj) {} // 0x000000018C0BD7CC-0x000000018C0BD8AC
		static StructPtrWrapper() {} // 0x000000018C0BD5AC-0x000000018C0BD740
	
		// Methods
		public static StructPtrWrapper GetStructPtrWrapper(IntPtr ptr, int size, System.Type type) => default; // 0x000000018C0BCE14-0x000000018C0BCFB0
		public static StructPtrWrapper GetStructPtrWrapper(object structObj) => default; // 0x000000018C0BCCC8-0x000000018C0BCE14
		public static void Release(StructPtrWrapper obj) {} // 0x000000018C0BCFFC-0x000000018C0BD0E0
		public object GetStructObj() => default; // 0x000000018C0BCBE8-0x000000018C0BCC74
		public static object GetStructObj(IntPtr ptr, System.Type type, int size) => default; // 0x000000018C0BCB44-0x000000018C0BCBE8
		public void SetStructObjValue(object structObj) {} // 0x000000018C0BD0E0-0x000000018C0BD164
		public override int GetHashCode() => default; // 0x000000018C0BCAE4-0x000000018C0BCB44
		public override bool Equals(object obj) => default; // 0x000000018C0BCA14-0x000000018C0BCAE4
		public override string ToString() => default; // 0x000000018C0BD164-0x000000018C0BD1C4
		public new System.Type GetType() => default; // 0x000000018C0BCFB0-0x000000018C0BCFFC
		public static object GetStructObj(StructPtrWrapper obj) => default; // 0x000000018C0BCC74-0x000000018C0BCCC8
		private static StructPtrWrapper _OnCreate() => default; // 0x000000018C0BD1C4-0x000000018C0BD2F8
		private static void _OnGet(StructPtrWrapper o) {} // 0x000000018C0BD2F8-0x000000018C0BD4FC
		private static void _OnRealse(StructPtrWrapper obj) {} // 0x000000018C0BD4FC-0x000000018C0BD5AC
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000185FB0F10-0x0000000185FB0F20
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018406FBE0-0x000000018406FBF0
		public string __iFixBaseProxy_ToString() => default; // 0x000000018765AF34-0x000000018765AF3C
	}
}

namespace Beyond.SparkBuffer
{
	public enum SparkType : byte // TypeDefIndex: 58700
	{
		Bool = 0,
		Byte = 1,
		Int = 2,
		Long = 3,
		Float = 4,
		Double = 5,
		Enum = 6,
		String = 7,
		Bean = 8,
		Array = 9,
		Map = 10
	}

	public static class Common // TypeDefIndex: 58701
	{
		// Fields
		public const int NULL_PLACEHOLDER = -1; // Metadata: 0x0207FEE6
		public const int BOOL_MEM_SIZE = 1; // Metadata: 0x0207FEE7
		public const int BYTE_MEM_SIZE = 1; // Metadata: 0x0207FEE8
		public const int INT_MEM_SIZE = 4; // Metadata: 0x0207FEE9
		public const int LONG_MEM_SIZE = 8; // Metadata: 0x0207FEEA
		public const int FLOAT_MEM_SIZE = 4; // Metadata: 0x0207FEEB
		public const int DOUBLE_MEM_SIZE = 8; // Metadata: 0x0207FEEC
	}

	public static class Utils // TypeDefIndex: 58702
	{
		// Methods
		public static int Align4Bytes(int position) => default; // 0x000000018C0BAA40-0x000000018C0BAA54
		public static int Align8Bytes(int position) => default; // 0x000000018C0BAA54-0x000000018C0BAA68
		public static int AlignBytesForSize(int position, int size) => default; // 0x000000018C0BAA68-0x000000018C0BAA90
		public static int GetMemSizeForType(SparkType sparkType) => default; // 0x000000018409C560-0x000000018409C5D0
		public static int GetFieldOffset(SparkType sparkType, ref int postion) => default; // 0x000000018409AAE0-0x000000018409AB80
		public static bool IsEnumOrBean(SparkType sparkType) => default; // 0x000000018C0BAAC8-0x000000018C0BAAD8
		public static bool IsArrayOrMap(SparkType sparkType) => default; // 0x000000018C0BAAB8-0x000000018C0BAAC8
		public static bool CheckValidMapKeyType(SparkType sparkType) => default; // 0x000000018C0BAA90-0x000000018C0BAAA4
		public static bool CheckValidRootType(SparkType sparkType) => default; // 0x000000018C0BAAA4-0x000000018C0BAAB8
	}
}

namespace Beyond.SparkBuffer.Runtime
{
	public class ByteReader : IDisposable // TypeDefIndex: 58703
	{
		// Fields
		private NativeArray<byte> m_buffer; // 0x10
		private unsafe byte* m_bufferPtr; // 0x20
		private int m_position; // 0x28
		private readonly int m_length; // 0x2C
		public static IStringPool s_stringPool; // 0x00
		public static Action<IntPtr> s_freeMemory; // 0x08
		public static Func<byte[], IntPtr> s_mallocMemory; // 0x10
	
		// Properties
		public int position { get => default; } // 0x0000000181C9AC80-0x0000000181C9AC90 
		public NativeArray<byte> buffer { get => default; } // 0x00000001834A7540-0x00000001834A7550 
	
		// Constructors
		public ByteReader() {} // Dummy constructor
		public ByteReader(byte[] buffer) {} // 0x000000018457C640-0x000000018457C700
	
		// Methods
		public void Dispose() {} // 0x000000018C0A9158-0x000000018C0A91C4
		public void SeekTo(int pos) {} // 0x0000000181C9A5C0-0x0000000181C9A5D0
		public bool ReadBool() => default; // 0x000000018C0A91C4-0x000000018C0A91DC
		public byte ReadByte() => default; // 0x0000000185FEADE0-0x0000000185FEAE00
		public int ReadInt() => default; // 0x000000018C0A9234-0x000000018C0A9260
		public long ReadLong() => default; // 0x000000018C0A9260-0x000000018C0A9290
		public float ReadFloat() => default; // 0x000000018C0A9208-0x000000018C0A9234
		public double ReadDouble() => default; // 0x000000018C0A91DC-0x000000018C0A9208
		public string ReadString() => default; // 0x000000018C0A9290-0x000000018C0A9358
		public Beyond.SparkBuffer.Runtime.Wrapper.HashSlot ReadHashSlot() => default; // 0x0000000185FEAE00-0x0000000185FEAE10
		public SparkType ReadSparkType() => default; // 0x0000000185FEADE0-0x0000000185FEAE00
		public int ReadTypeHash() => default; // 0x000000018C0A9358-0x000000018C0A9360
	}

	public class ByteWriter : IDisposable // TypeDefIndex: 58704
	{
		// Fields
		private static readonly byte[] BUFFER_0; // 0x00
		private readonly BinaryWriter m_writer; // 0x10
		private readonly Stream m_stream; // 0x18
		public static IStringPool s_stringPool; // 0x08
	
		// Properties
		public int position { get => default; } // 0x000000018C0A99C4-0x000000018C0A99E8 
	
		// Constructors
		public ByteWriter() {} // Dummy constructor
		public ByteWriter(Stream stream) {} // 0x000000018C0A9940-0x000000018C0A99C4
		static ByteWriter() {} // 0x000000018C0A98D8-0x000000018C0A9940
	
		// Methods
		public void Dispose() {} // 0x000000018C0A9360-0x000000018C0A939C
		public void SeekTo(int pos) {} // 0x000000018C0A93E0-0x000000018C0A940C
		public void WriteBool(bool v) {} // 0x000000018C0A940C-0x000000018C0A942C
		public void WriteByte(byte v) {} // 0x000000018C0A942C-0x000000018C0A944C
		public void WriteInt(int v) {} // 0x000000018C0A9560-0x000000018C0A959C
		public void WriteLong(long v) {} // 0x000000018C0A959C-0x000000018C0A95D8
		public void WriteFloat(float v) {} // 0x000000018C0A9524-0x000000018C0A9560
		public void WriteDouble(double v) {} // 0x000000018C0A94E8-0x000000018C0A9524
		public void WriteStringAlignment(string v) {} // 0x000000018C0A95D8-0x000000018C0A96C4
		public void WriteString(string v) {} // 0x000000018C0A96C4-0x000000018C0A97A0
		public void WriteBytes(ReadOnlySpan<byte> buffer, int index, int count) {} // 0x000000018C0A944C-0x000000018C0A94E8
		public void WriteSparkType(SparkType sparkType) {} // 0x000000018C0A942C-0x000000018C0A944C
		internal int FillAlignment(int align) => default; // 0x000000018C0A939C-0x000000018C0A93E0
		private void _FillAlignment4() {} // 0x000000018C0A97A0-0x000000018C0A983C
		private void _FillAlignment8() {} // 0x000000018C0A983C-0x000000018C0A98D8
	}

	public struct Array // TypeDefIndex: 58705
	{
		// Fields
		private readonly ArrayType m_arrayType; // 0x00
		private readonly Root m_root; // 0x18
		private readonly int m_dataOffset; // 0x20
		private readonly int m_length; // 0x24
	
		// Properties
		public int length { get => default; } // 0x0000000181424480-0x0000000181424490 
	
		// Constructors
		internal Array(ArrayType arrayType, int offset, Root root) : this() {
			m_arrayType = default;
			m_root = default;
			m_dataOffset = default;
			m_length = default;
		} // 0x0000000183FA8180-0x0000000183FA82B0
	
		// Methods
		public bool GetBool(int index) => default; // 0x000000018C0A8478-0x000000018C0A84E4
		public byte GetByte(int index) => default; // 0x000000018C0A8268-0x000000018C0A82D4
		public int GetInt(int index) => default; // 0x000000018C0A8634-0x000000018C0A86A4
		public long GetLong(int index) => default; // 0x000000018C0A82D4-0x000000018C0A83B0
		public float GetFloat(int index) => default; // 0x000000018C0A85C4-0x000000018C0A8634
		public double GetDouble(int index) => default; // 0x000000018C0A84E4-0x000000018C0A8554
		public string GetString(int index) => default; // 0x000000018C0A86A4-0x000000018C0A8714
		public int GetEnum(int index) => default; // 0x000000018C0A8554-0x000000018C0A85C4
		public Bean? GetBean(int index) => default; // 0x000000018C0A83E8-0x000000018C0A8478
	}

	public struct Bean // TypeDefIndex: 58706
	{
		// Fields
		private readonly BeanType m_beanType; // 0x00
		private readonly Root m_root; // 0x08
		private readonly int m_dataOffset; // 0x10
	
		// Constructors
		internal Bean(BeanType beanType, int offset, Root root) {
			m_beanType = default;
			m_root = default;
			m_dataOffset = default;
		} // 0x0000000183FA8C30-0x0000000183FA8CF0
	
		// Methods
		public bool GetBool(string key, out int offset) {
			offset = default;
			return default;
		} // 0x000000018C0A88CC-0x000000018C0A893C
		public bool GetBool(int offset) => default; // 0x000000018C0A893C-0x000000018C0A8964
		public byte GetByte(string key, out int offset) {
			offset = default;
			return default;
		} // 0x000000018C0A8964-0x000000018C0A89D4
		public byte GetByte(int offset) => default; // 0x000000018C0A89D4-0x000000018C0A89FC
		public int GetInt(string key, out int offset) {
			offset = default;
			return default;
		} // 0x000000018C0A8ABC-0x000000018C0A8B2C
		public int GetInt(int offset) => default; // 0x000000018C0A8A94-0x000000018C0A8ABC
		public long GetLong(string key, out int offset) {
			offset = default;
			return default;
		} // 0x000000018C0A8BC4-0x000000018C0A8C34
		public long GetLong(int offset) => default; // 0x000000018C0A8C34-0x000000018C0A8C5C
		public float GetFloat(string key, out int offset) {
			offset = default;
			return default;
		} // 0x000000018C0A8B54-0x000000018C0A8BC4
		public float GetFloat(int offset) => default; // 0x000000018C0A8B2C-0x000000018C0A8B54
		public double GetDouble(string key, out int offset) {
			offset = default;
			return default;
		} // 0x000000018C0A89FC-0x000000018C0A8A6C
		public double GetDouble(int offset) => default; // 0x000000018C0A8A6C-0x000000018C0A8A94
		public string GetString(string key, out int offset) {
			offset = default;
			return default;
		} // 0x000000018C0A8C5C-0x000000018C0A8CCC
		public string GetString(int offset) => default; // 0x000000018C0A8CCC-0x000000018C0A8CF4
		public int GetEnum(string key, out int offset) {
			offset = default;
			return default;
		} // 0x000000018C0A8ABC-0x000000018C0A8B2C
		public int GetEnum(int offset) => default; // 0x000000018C0A8A94-0x000000018C0A8ABC
		public Bean? GetBean(string key) => default; // 0x0000000183FA8CF0-0x0000000183FA8ED0
		public Beyond.SparkBuffer.Runtime.Array? GetArray(string key) => default; // 0x0000000183FA82B0-0x0000000183FA8520
		public Beyond.SparkBuffer.Runtime.Map? GetMap(string key) => default; // 0x000000018409BD90-0x000000018409C390
	}

	public struct Map : IEnumerable<Beyond.SparkBuffer.Runtime.Map.UnionKey> // TypeDefIndex: 58709
	{
		// Fields
		private const int INT_KEY_MEM_SIZE = 4; // Metadata: 0x0207FEED
		private const int LONG_KEY_MEM_SIZE = 8; // Metadata: 0x0207FEEE
		private readonly MapType m_mapType; // 0x00
		private readonly Root m_root; // 0x28
		private readonly int m_valueMemSize; // 0x30
		private readonly int m_keyMemSize; // 0x34
		private readonly int m_dataOffset; // 0x38
		private readonly int m_count; // 0x3C
		private readonly int m_slotsOffset; // 0x40
	
		// Properties
		public int count { get => default; } // 0x000000018C0B1AC8-0x000000018C0B1BA0 
	
		// Nested types
		public struct UnionKey // TypeDefIndex: 58707
		{
			// Fields
			public int intKey; // 0x00
			public long longKey; // 0x08
			public string stringKey; // 0x10
	
			// Constructors
			public UnionKey(int key) {
				intKey = default;
				longKey = default;
				stringKey = default;
			} // 0x0000000185FB0790-0x0000000185FB07A0
			public UnionKey(long key) {
				intKey = default;
				longKey = default;
				stringKey = default;
			} // 0x000000018409C390-0x000000018409C560
			public UnionKey(string key) {
				intKey = default;
				longKey = default;
				stringKey = default;
			} // 0x000000018C0B0B9C-0x000000018C0B0C3C
		}
	
		public struct UnionKeyEnumerator : IEnumerator<UnionKey> // TypeDefIndex: 58708
		{
			// Fields
			private readonly Map m_parent; // 0x00
			private int m_index; // 0x48
			private int m_currentSlotIndex; // 0x4C
			private int m_currentSlotStartIndex; // 0x50
			private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot m_currentSlot; // 0x54
	
			// Properties
			public UnionKey Current { get => default; } // 0x000000018C0B140C-0x000000018C0B1498 
			object IEnumerator.Current { get => default; } // 0x000000018C0B1498-0x000000018C0B1524 
	
			// Constructors
			public UnionKeyEnumerator(Map parent) : this() {
				m_parent = default;
				m_index = default;
				m_currentSlotIndex = default;
				m_currentSlotStartIndex = default;
				m_currentSlot = default;
			} // 0x000000018C0B0D70-0x000000018C0B0D90
	
			// Methods
			public bool MoveNext() => default; // 0x0000000185FB2C30-0x0000000185FB2C40
			public void Dispose() {} // 0x0000000185FB2C30-0x0000000185FB2C40
			void IEnumerator.Reset() {} // 0x000000018C0B0CF4-0x000000018C0B0D70
		}
	
		// Constructors
		internal Map(MapType mapType, int offset, Root root) : this() {
			m_mapType = default;
			m_root = default;
			m_valueMemSize = default;
			m_keyMemSize = default;
			m_dataOffset = default;
			m_count = default;
			m_slotsOffset = default;
		} // 0x000000018C0B19EC-0x000000018C0B1AC8
	
		// Methods
		public UnionKeyEnumerator GetEnumerator() => default; // 0x000000018C0B1BA0-0x000000018C0B1C90
		IEnumerator<UnionKey> System.Collections.Generic.IEnumerable<Beyond.SparkBuffer.Runtime.Map.UnionKey>.GetEnumerator() => default; // 0x000000018C0B0D90-0x000000018C0B0E8C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0B0FE4-0x000000018C0B10E0
		private static int GetHash(string str) => default; // 0x000000018C0B1198-0x000000018C0B1294
		private static int GetHash(int value) => default; // 0x000000018C0B0E8C-0x000000018C0B0F9C
		private static int GetHash(long value) => default; // 0x000000018931EADC-0x000000018931EBEC
		private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(int slotIndex) => default; // 0x000000018C0B1294-0x000000018C0B13A4
		private int _FindHashIndexByKey(int intKey) => default; // 0x000000018409E260-0x000000018409E4C0
		private int _FindHashIndexByKey(long longKey) => default; // 0x000000018C0B0888-0x000000018C0B08BC
		private int _FindHashIndexByKey(string stringKey) => default; // 0x0000000184566380-0x0000000184566460
		internal int GetIntKeyByIndex(int index) => default; // 0x000000018C0B096C-0x000000018C0B09A0
		internal long GetLongKeyByIndex(int index) => default; // 0x000000018C0B15FC-0x000000018C0B1644
		internal string GetStringKeyByIndex(int index) => default; // 0x0000000184099E10-0x0000000184099EF0
		internal int GetIntKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex) => default; // 0x0000000184C67DB0-0x0000000184C67E00
		internal long GetLongKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex) => default; // 0x000000018C0B1114-0x000000018C0B1148
		internal string GetStringKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex) => default; // 0x000000018C0B19A4-0x000000018C0B19EC
		public bool ContainsKey(string key) => default; // 0x000000018C0B0C58-0x000000018C0B0C8C
		public bool GetBool(string key) => default; // 0x000000018C0B183C-0x000000018C0B1884
		public bool TryGetBool(string key, out bool value) {
			value = default;
			return default;
		} // 0x000000018C0B0A1C-0x000000018C0B0A50
		public byte GetByte(string key) => default; // 0x000000018C0B168C-0x000000018C0B16D4
		public bool TryGetByte(string key, out byte value) {
			value = default;
			return default;
		} // 0x000000018C0B13A4-0x000000018C0B13D8
		public int GetInt(string key) => default; // 0x000000018549A6E0-0x000000018549A740
		public bool TryGetInt(string key, out int value) {
			value = default;
			return default;
		} // 0x000000018C0B0B00-0x000000018C0B0B34
		public long GetLong(string key) => default; // 0x000000018C0B17F4-0x000000018C0B183C
		public bool TryGetLong(string key, out long value) {
			value = default;
			return default;
		} // 0x000000018485FFC0-0x0000000184860240
		public float GetFloat(string key) => default; // 0x000000018485F3B0-0x000000018485F900
		public bool TryGetFloat(string key, out float value) {
			value = default;
			return default;
		} // 0x000000018409C670-0x000000018409C690
		public double GetDouble(string key) => default; // 0x000000018C0B08BC-0x000000018C0B08F0
		public bool TryGetDouble(string key, out double value) {
			value = default;
			return default;
		} // 0x000000018C0B1524-0x000000018C0B156C
		public string GetString(string key) => default; // 0x000000018C0B0938-0x000000018C0B096C
		public bool TryGetString(string key, out string value) {
			value = default;
			return default;
		} // 0x000000018C0B15B4-0x000000018C0B15FC
		public int GetEnum(string key) => default; // 0x000000018C0B0B68-0x000000018C0B0B9C
		public bool TryGetEnum(string key, out int value) {
			value = default;
			return default;
		} // 0x000000018409DC30-0x000000018409DDD0
		public Bean? GetBean(string key) => default; // 0x000000018C0B1148-0x000000018C0B117C
		public bool TryGetBean(string key, out Bean? bean) {
			bean = default;
			return default;
		} // 0x000000018C0B195C-0x000000018C0B19A4
		public bool ContainsKey(int key) => default; // 0x000000018C0B0C8C-0x000000018C0B0CC0
		public bool GetBool(int key) => default; // 0x000000018C0B18CC-0x000000018C0B1914
		public bool TryGetBool(int key, out bool value) {
			value = default;
			return default;
		} // 0x000000018C0B0A50-0x000000018C0B0A84
		public byte GetByte(int key) => default; // 0x000000018C0B171C-0x000000018C0B1764
		public bool TryGetByte(int key, out byte value) {
			value = default;
			return default;
		} // 0x000000018409DE20-0x000000018409E260
		public int GetInt(int key) => default; // 0x0000000184BAA000-0x0000000184BAA060
		public bool TryGetInt(int key, out int value) {
			value = default;
			return default;
		} // 0x000000018C0B0B68-0x000000018C0B0B9C
		public long GetLong(int key) => default; // 0x000000018C0B17AC-0x000000018C0B17F4
		public bool TryGetLong(int key, out long value) {
			value = default;
			return default;
		} // 0x000000018485B610-0x000000018485B670
		public float GetFloat(int key) => default; // 0x000000018485B5A0-0x000000018485B610
		public bool TryGetFloat(int key, out float value) {
			value = default;
			return default;
		} // 0x000000018C0B0750-0x000000018C0B0764
		public double GetDouble(int key) => default; // 0x000000018C0B0854-0x000000018C0B0888
		public bool TryGetDouble(int key, out double value) {
			value = default;
			return default;
		} // 0x000000018C0B156C-0x000000018C0B15B4
		public string GetString(int key) => default; // 0x000000018C0B09A0-0x000000018C0B09D4
		public bool TryGetString(int key, out string value) {
			value = default;
			return default;
		} // 0x000000018C0B1644-0x000000018C0B168C
		public int GetEnum(int key) => default; // 0x000000018C0B0B34-0x000000018C0B0B68
		public bool TryGetEnum(int key, out int value) {
			value = default;
			return default;
		} // 0x000000018C0B1764-0x000000018C0B17AC
		public Bean? GetBean(int key) => default; // 0x000000018C0B10E0-0x000000018C0B1114
		public bool TryGetBean(int key, out Bean? bean) {
			bean = default;
			return default;
		} // 0x000000018C0B1914-0x000000018C0B195C
		public bool ContainsKey(long key) => default; // 0x000000018C0B0CC0-0x000000018C0B0CF4
		public bool GetBool(long key) => default; // 0x000000018C0B1884-0x000000018C0B18CC
		public bool TryGetBool(long key, out bool value) {
			value = default;
			return default;
		} // 0x000000018C0B0A84-0x000000018C0B0AB8
		public byte GetByte(long key) => default; // 0x000000018C0B16D4-0x000000018C0B171C
		public bool TryGetByte(long key, out byte value) {
			value = default;
			return default;
		} // 0x000000018C0B13D8-0x000000018C0B140C
		public int GetInt(long key) => default; // 0x0000000184974940-0x0000000184974D80
		public bool TryGetInt(long key, out int value) {
			value = default;
			return default;
		} // 0x000000018C0B0B34-0x000000018C0B0B68
		public long GetLong(long key) => default; // 0x000000018C0B1764-0x000000018C0B17AC
		public bool TryGetLong(long key, out long value) {
			value = default;
			return default;
		} // 0x000000018C0B07A4-0x000000018C0B080C
		public float GetFloat(long key) => default; // 0x0000000184974900-0x0000000184974940
		public bool TryGetFloat(long key, out float value) {
			value = default;
			return default;
		} // 0x000000018C0B080C-0x000000018C0B0838
		public double GetDouble(long key) => default; // 0x000000018C0B08F0-0x000000018C0B091C
		public bool TryGetDouble(long key, out double value) {
			value = default;
			return default;
		} // 0x000000018C0B0AB8-0x000000018C0B0AE4
		public string GetString(long key) => default; // 0x000000018C0B0F9C-0x000000018C0B0FC8
		public bool TryGetString(long key, out string value) {
			value = default;
			return default;
		} // 0x0000000184F89960-0x0000000184F89A30
		public int GetEnum(long key) => default; // 0x000000018C0B09D4-0x000000018C0B0A00
		public bool TryGetEnum(long key, out int value) {
			value = default;
			return default;
		} // 0x00000001846FFBC0-0x00000001846FFBF0
		public Bean? GetBean(long key) => default; // 0x000000018C0B0AB8-0x000000018C0B0AE4
		public bool TryGetBean(long key, out Bean? bean) {
			bean = default;
			return default;
		} // 0x000000018485D570-0x000000018485D5E0
		internal bool GetBoolByIndex(int index) => default; // 0x000000018C0B1C90-0x000000018C0B1DF0
		internal byte GetByteByIndex(int index) => default; // 0x000000018C0B0838-0x000000018C0B0854
		internal int GetIntByIndex(int index) => default; // 0x000000018C0B091C-0x000000018C0B0938
		internal long GetLongByIndex(int index) => default; // 0x000000018C0B0AE4-0x000000018C0B0B00
		internal float GetFloatByIndex(int index) => default; // 0x000000018C0B0FC8-0x000000018C0B0FE4
		internal double GetDoubleByIndex(int index) => default; // 0x000000018C0B0C3C-0x000000018C0B0C58
		internal string GetStringByIndex(int index) => default; // 0x000000018C0B0A00-0x000000018C0B0A1C
		internal int GetEnumByIndex(int index) => default; // 0x000000018C0B117C-0x000000018C0B1198
		internal Bean? GetBeanByIndex(int index) => default; // 0x000000018C0B0AE4-0x000000018C0B0B00
		private int _GetOffsetByIndex(int index) => default; // 0x000000018C0B0764-0x000000018C0B07A4
		internal bool GetBoolByOffset(int offset) => default; // 0x000000018C0BA9F8-0x000000018C0BAA10
		internal byte GetByteByOffset(int offset) => default; // 0x000000018C0BAA28-0x000000018C0BAA40
		internal int GetIntByOffset(int offset) => default; // 0x000000018C0BAA10-0x000000018C0BAA28
		internal long GetLongByOffset(int offset) => default; // 0x000000018C0BA818-0x000000018C0BA9F8
		internal float GetFloatByOffset(int offset) => default; // 0x000000018C0BA764-0x000000018C0BA7C4
		internal double GetDoubleByOffset(int offset) => default; // 0x000000018C0BA7C4-0x000000018C0BA818
		internal string GetStringByOffset(int offset) => default; // 0x000000018C0BA678-0x000000018C0BA764
		internal int GetEnumByOffset(int offset) => default; // 0x0000000185492010-0x0000000185492020
		internal Bean? GetBeanByOffset(int offset) => default; // 0x0000000185FEAE20-0x0000000185FEAE40
	}

	public class Root : IDisposable // TypeDefIndex: 58711
	{
		// Fields
		private ByteReader m_reader; // 0x10
		private readonly Options m_options; // 0x18
		private readonly int m_dataOffset; // 0x40
		private Dictionary<int, string> m_cachedString; // 0x48
	
		// Properties
		public string name { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public NativeArray<byte> bytes { get => default; } // 0x000000018510B220-0x000000018510B250 
	
		// Nested types
		internal struct Options // TypeDefIndex: 58710
		{
			// Fields
			public string rootName; // 0x00
			public SparkType rootType; // 0x08
			public SparkType subType1; // 0x09
			public SparkType subType2; // 0x0A
			public BeanType beanType; // 0x10
			public EnumType enumType; // 0x18
			public EnumType mapKeyEnumType; // 0x20
		}
	
		// Constructors
		public Root() {} // Dummy constructor
		internal Root(int dataOffset, Options options, ByteReader reader) {} // 0x000000018457B620-0x000000018457B700
	
		// Methods
		~Root() {} // 0x000000018C0B48F0-0x000000018C0B49B8
		public override string ToString() => default; // 0x000000018C0B4FA0-0x000000018C0B5010
		public void Dispose() {} // 0x000000018C0B48C0-0x000000018C0B48F0
		public bool IsValid() => default; // 0x00000001882E0F9C-0x00000001882E0FA8
		public Bean? AsBean() => default; // 0x000000018C0B4658-0x000000018C0B4714
		public Beyond.SparkBuffer.Runtime.Array? AsArray() => default; // 0x000000018C0B4534-0x000000018C0B4658
		public Beyond.SparkBuffer.Runtime.Map? AsMap() => default; // 0x000000018C0B4714-0x000000018C0B48C0
		internal int GetCurReaderPosition() => default; // 0x000000018C0B4C60-0x000000018C0B4C7C
		internal bool GetBool(int offset) => default; // 0x000000018C0B4C24-0x000000018C0B4C60
		internal byte GetByte(int offset) => default; // 0x000000018C0A83B0-0x000000018C0A83E8
		internal int GetInt(int offset) => default; // 0x000000018C0B4CA4-0x000000018C0B4CCC
		internal long GetLong(int offset) => default; // 0x000000018C0B4CCC-0x000000018C0B4CF4
		internal float GetFloat(int offset) => default; // 0x0000000184F89A30-0x0000000184F89A80
		internal double GetDouble(int offset) => default; // 0x000000018C0B4C7C-0x000000018C0B4CA4
		internal int GetEnum(int offset) => default; // 0x000000018C0B4CA4-0x000000018C0B4CCC
		internal string GetString(int offset) => default; // 0x000000018C0B4E98-0x000000018C0B4FA0
		internal Bean? GetBean(int offset, BeanType beanType) => default; // 0x000000018C0B4B00-0x000000018C0B4C24
		internal Beyond.SparkBuffer.Runtime.Array? GetArray(int offset, ArrayType arrayType) => default; // 0x000000018C0B49B8-0x000000018C0B4B00
		internal Beyond.SparkBuffer.Runtime.Map? GetMap(int offset, MapType mapType) => default; // 0x000000018C0B4CF4-0x000000018C0B4E98
		internal Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(int offset) => default; // 0x000000018409EBA0-0x000000018409EC80
	}

	public static class Error // TypeDefIndex: 58712
	{
		// Methods
		public static Exception TypeNotFoundError(int typeHash, SparkType sparkType) => default; // 0x000000018C0A9F98-0x000000018C0AA064
		public static Exception InvalidTypeError(SparkType sparkType) => default; // 0x000000018C0A9DF4-0x000000018C0A9E94
		public static Exception InvalidMapKeyError(SparkType sparkType) => default; // 0x000000018C0A9D54-0x000000018C0A9DF4
		public static Exception NullTypeError(SparkType sparkType) => default; // 0x000000018C0A9E94-0x000000018C0A9F34
		public static Exception GetEndOfFile() => default; // 0x000000018C0A9CF0-0x000000018C0A9D54
		public static Exception SeekAheadOfFile() => default; // 0x000000018C0A9F34-0x000000018C0A9F98
		public static Exception DisposedException() => default; // 0x000000018C0A9C8C-0x000000018C0A9CF0
	}

	public abstract class SparkManager // TypeDefIndex: 58715
	{
		// Fields
		private readonly Dictionary<int, BeanType> m_beanTypeMap; // 0x10
		private readonly Dictionary<int, EnumType> m_enumTypeMap; // 0x18
		protected readonly Dictionary<string, Root> m_namedRoots; // 0x20
		private readonly List<Root> m_anonymousRoots; // 0x28
		private readonly Queue<BeanType> m_beanTypeQueue; // 0x30
	
		// Nested types
		private class JsonLoader : IDisposable // TypeDefIndex: 58714
		{
			// Fields
			private ByteWriter m_writer; // 0x10
			private Dictionary<string, int> m_stringMap; // 0x18
	
			// Nested types
			private struct ReservedField // TypeDefIndex: 58713
			{
				// Fields
				public int position; // 0x00
				public JToken token; // 0x08
				public SparkType type; // 0x10
				public BeanType beanType; // 0x18
				public ArrayType arrayType; // 0x20
				public MapType mapType; // 0x38
			}
	
			// Constructors
			public JsonLoader() {} // Dummy constructor
			private JsonLoader(ByteWriter writer) {} // 0x0000000185C20F20-0x0000000185C210C0
	
			// Methods
			public void Dispose() {} // 0x000000018457BCF0-0x000000018457BEA0
			internal static void PopulateJsonDataWithoutTypeAndRootDef(ByteWriter writer, JToken rootObj, Root.Options rootOptions, out int dataOffset) {
				dataOffset = default;
			} // 0x000000018C0B6884-0x000000018C0B6890
			private void _LoadJsonContentWithoutTypeAndRootDef(JToken rootObj, Root.Options rootOptions, out int dataOffset) {
				dataOffset = default;
			} // 0x000000018C0B61C8-0x000000018C0B6884
			private void _ExportStrings(JToken rootJson, Root.Options rootOptions) {} // 0x000000018C0B61AC-0x000000018C0B61C8
			private void _CollectBeanStrings(HashSet<string> stringSet, JObject obj, BeanType beanType) {} // 0x000000018C0B6A4C-0x000000018C0B6ADC
			private void _CollectArrayStrings(HashSet<string> stringSet, JArray obj, ArrayType arrayType) {} // 0x000000018C0B6890-0x000000018C0B6A4C
			private void _CollectMapStrings(HashSet<string> stringSet, JObject obj, MapType mapType) {} // 0x000000018457B170-0x000000018457B2E0
			private int _ExportRootData(JToken rootJson, Root.Options rootOptions) => default; // 0x000000018457B5B0-0x000000018457B620
			private int _ExportBeanData(JObject beanObj, BeanType beanType) => default; // 0x00000001851C40D0-0x00000001851C4150
			private int _ExportArrayData(JArray arrayObj, ArrayType arrayType) => default; // 0x0000000184098830-0x0000000184098A30
			private int _ExportMapData(JObject mapObj, MapType mapType) => default; // 0x000000018457BEA0-0x000000018457C640
			private Dictionary<int, List<KeyValuePair<string, JToken>>> _CreateMapHashEntry(JObject mapObj, SparkType keyType) => default; // 0x000000018C0AEAF4-0x000000018C0AEB7C
			private int _GetMapKeyHash(string key, SparkType keyType) => default; // 0x0000000185633D30-0x0000000185633D50
			private void _ExportMapKey(string key, SparkType keyType) {} // 0x000000018C0AB2AC-0x000000018C0AB3E8
			private void _ExportMapValue(JToken valueToken, MapType mapType, List<ReservedField> reservedFields) {} // 0x000000018C0AEA60-0x000000018C0AEAF4
			private void _ExportReservedFields(List<ReservedField> reservedFields) {} // 0x000000018C0AE334-0x000000018C0AE820
			private void _ExportStringByLoc(string strVal) {} // 0x000000018C0AB5FC-0x000000018C0ABAC4
			private void _ExportEnumData(JToken token, EnumType enumType) {} // 0x000000018C0AB3E8-0x000000018C0AB5FC
			private void _ExportCommonDataOrThrow(JToken token, SparkType type, List<ReservedField> reservedFields) {} // 0x000000018C0ABAC4-0x000000018C0ABD38
			private static void _EnsureJTokenType(JToken token, JTokenType requiredType) {} // 0x000000018C0ADF88-0x000000018C0AE230
			private static Exception _InvalidRootTypeError(SparkType rootType) => default; // 0x000000018C0AC598-0x000000018C0ACD88
		}
	
		// Constructors
		protected SparkManager() {} // 0x000000018C0AC138-0x000000018C0AC598
	
		// Methods
		public Root Load(byte[] bytes, string overrideRootName) => default; // 0x000000018C0AD1C0-0x000000018C0AD80C
		public Root Load(byte[] bytes) => default; // 0x000000018C0ABD38-0x000000018C0AC048
		public Root LoadFromJson_EditorOnly(byte[] bytes, JToken jsonData, string overrideRootName) => default; // 0x000000018C0AE820-0x000000018C0AE9C0
		public Root LoadFromJson_EditorOnly(byte[] bytes, JToken jsonData) => default; // 0x000000018C0AD80C-0x000000018C0AD9DC
		public virtual bool Unload(Root root) => default; // 0x000000018C0AD9DC-0x000000018C0ADB7C
		public virtual void UnloadAndClearAll() {} // 0x000000018C0ADB7C-0x000000018C0ADF88
		internal bool TryGetEnumType(int typeHash, out EnumType enumType) {
			enumType = default;
			return default;
		} // 0x000000018C0AE230-0x000000018C0AE334
		internal bool TryGetBeanType(int typeHash, out BeanType beanType) {
			beanType = default;
			return default;
		} // 0x000000018C0AD02C-0x000000018C0AD1C0
		protected virtual bool _AddRoot(Root root) => default; // 0x000000018C0ACD88-0x000000018C0AD02C
		private void _ReadTypeDefs(ByteReader reader) {} // 0x000000018C0AC048-0x000000018C0AC138
		private Root.Options _ReadRootDef(ByteReader reader, string overrideRootName) => default; // 0x000000018C0AE9C0-0x000000018C0AEA60
	}

	public class RuntimeSparkManager : SparkManager // TypeDefIndex: 58717
	{
		// Fields
		private static RuntimeSparkManager s_instance; // 0x00
		private Action<Root> m_onRootLoaded; // 0x38
		private Action<Root> m_onRootUnloaded; // 0x40
		private Action m_onUnloadAll; // 0x48
		private const string LUADLL = "__Internal"; // Metadata: 0x0207FEEF
	
		// Properties
		public static RuntimeSparkManager instance { get => default; } // 0x000000018C0B511C-0x000000018C0B516C 
	
		// Nested types
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 58716
		{
			// Fields
			public IntPtr L; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0() {} // 0x00000001853DB800-0x00000001853DB8A0
	
			// Methods
			internal void _RegisterToLua_b__0(Root root) {} // 0x000000018C0B5214-0x000000018C0B521C
			internal void _RegisterToLua_b__1(Root root) {} // 0x000000018C0B516C-0x000000018C0B51D4
			internal void _RegisterToLua_b__2() {} // 0x000000018C0B5058-0x000000018C0B511C
		}
	
		// Constructors
		private RuntimeSparkManager() {} // 0x000000018510B250-0x000000018510B2C0
	
		// Methods
		public override bool Unload(Root root) => default; // 0x000000018C0B5018-0x000000018C0B5058
		public void ReloadTableToLua(string name) {} // 0x000000018C0B5010-0x000000018C0B5018
		public override void UnloadAndClearAll() {} // 0x00000001852E0500-0x00000001852E0900
		private static extern bool LuaSpark_LoadRoot(IntPtr L, string rootName, IntPtr data, int size); // 0x000000018C0B51D4-0x000000018C0B5214
		private static extern bool LuaSpark_UnloadRoot(IntPtr L, string rootName); // 0x00000001851C4060-0x00000001851C40D0
		private static extern void LuaSpark_UnloadAll(IntPtr L); // 0x0000000185492010-0x0000000185492020
		public void RegisterToLua(IntPtr L) {} // 0x000000018510B1A0-0x000000018510B220
		public void UnregisterFromLua(IntPtr L) {} // 0x000000018C0BA5E4-0x000000018C0BA608
		protected override bool _AddRoot(Root root) => default; // 0x000000018C0BA608-0x000000018C0BA614
	}

	public interface IStringPool // TypeDefIndex: 58718
	{
		// Methods
		int AddString(string str);
		string GetString(int index);
		void Clear();
	}

	internal abstract class Field // TypeDefIndex: 58719
	{
		// Fields
		private readonly string _name_k__BackingField; // 0x10
		private readonly int _offset_k__BackingField; // 0x18
	
		// Properties
		public string name { get; } // 0x000000018346D130-0x000000018346D140 
		public int offset { get; } // 0x00000001813AE560-0x00000001813AE570 
		public abstract SparkType type { get; }
	
		// Constructors
		protected Field() {} // Dummy constructor
		protected Field(string fieldName, int fieldOffset) {} // 0x00000001845D7850-0x00000001845D7870
	
		// Methods
		public abstract void Unmarshal(ByteReader reader);
		public abstract void Resolve(SparkManager manager);
	}

	internal class SimpleField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 58720
	{
		// Fields
		private readonly SparkType _type_k__BackingField; // 0x20
	
		// Properties
		public override SparkType type { get; } // 0x00000001813ECBF0-0x00000001813ECC00 
	
		// Constructors
		public SimpleField() {} // Dummy constructor
		public SimpleField(SparkType type, string fieldName, int fieldOffset) {} // 0x000000018646D9CC-0x000000018646D9F4
	
		// Methods
		public override void Unmarshal(ByteReader reader) {} // 0x0000000185492010-0x0000000185492020
		public override void Resolve(SparkManager manager) {} // 0x0000000185492010-0x0000000185492020
	}

	internal class EnumField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 58721
	{
		// Fields
		private int m_typeHash; // 0x20
		private EnumType m_enumType; // 0x28
	
		// Properties
		public override SparkType type { get => default; } // 0x0000000185FBDCF0-0x0000000185FBDD00 
		public EnumType enumType { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
	
		// Constructors
		public EnumField() {} // Dummy constructor
		public EnumField(string fieldName, int fieldOffset) {} // 0x00000001845D7850-0x00000001845D7870
	
		// Methods
		public override void Unmarshal(ByteReader reader) {} // 0x0000000185617240-0x0000000185617270
		public override void Resolve(SparkManager manager) {} // 0x000000018457B130-0x000000018457B170
	}

	internal class BeanField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 58722
	{
		// Fields
		private int m_typeHash; // 0x20
		private BeanType m_beanType; // 0x28
	
		// Properties
		public override SparkType type { get => default; } // 0x0000000185FBDB10-0x0000000185FBDB20 
		public BeanType beanType { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
	
		// Constructors
		public BeanField() {} // Dummy constructor
		public BeanField(string fieldName, int fieldOffset) {} // 0x00000001845D7850-0x00000001845D7870
	
		// Methods
		public override void Unmarshal(ByteReader reader) {} // 0x000000018551B3A0-0x000000018551B530
		public override void Resolve(SparkManager manager) {} // 0x000000018457B4E0-0x000000018457B520
	}

	internal class ArrayField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 58723
	{
		// Fields
		private ArrayType m_arrayType; // 0x20
		private int m_elementTypeHash; // 0x38
	
		// Properties
		public override SparkType type { get => default; } // 0x0000000185FBDCA0-0x0000000185FBDCB0 
		public ArrayType arrayType { get => default; } // 0x0000000183636BE0-0x0000000183636C00 
	
		// Constructors
		public ArrayField() {} // Dummy constructor
		public ArrayField(string fieldName, int fieldOffset) {} // 0x00000001845D7850-0x00000001845D7870
	
		// Methods
		public override void Unmarshal(ByteReader reader) {} // 0x000000018457B520-0x000000018457B5B0
		public override void Resolve(SparkManager manager) {} // 0x000000018457B470-0x000000018457B4E0
	}

	internal class MapField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 58724
	{
		// Fields
		private MapType m_mapInfo; // 0x20
		private int m_keyTypeHash; // 0x48
		private int m_valueTypeHash; // 0x4C
	
		// Properties
		public override SparkType type { get => default; } // 0x0000000185FEAE10-0x0000000185FEAE20 
		public MapType mapType { get => default; } // 0x0000000185FB9A00-0x0000000185FB9A20 
	
		// Constructors
		public MapField() {} // Dummy constructor
		public MapField(string fieldName, int fieldOffset) {} // 0x00000001845D7850-0x00000001845D7870
	
		// Methods
		public override void Unmarshal(ByteReader reader) {} // 0x000000018457B340-0x000000018457B470
		public override void Resolve(SparkManager manager) {} // 0x000000018457B2E0-0x000000018457B340
	}

	internal struct ArrayType // TypeDefIndex: 58725
	{
		// Fields
		public SparkType elementType; // 0x00
		public BeanType elementBeanType; // 0x08
		public EnumType elementEnumType; // 0x10
	}

	internal struct MapType // TypeDefIndex: 58726
	{
		// Fields
		public SparkType keyType; // 0x00
		public EnumType keyEnumType; // 0x08
		public SparkType valueType; // 0x10
		public BeanType valueBeanType; // 0x18
		public EnumType valueEnumType; // 0x20
	}

	internal class EnumType // TypeDefIndex: 58728
	{
		// Fields
		private List<EnumItem> m_enums; // 0x10
		private int _typeHash_k__BackingField; // 0x18
		private string _name_k__BackingField; // 0x20
	
		// Properties
		public int typeHash { get; private set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public string name { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
	
		// Nested types
		private struct EnumItem // TypeDefIndex: 58727
		{
			// Fields
			public string name; // 0x00
			public int value; // 0x08
		}
	
		// Constructors
		public EnumType() {} // Dummy constructor
		public EnumType(ByteReader reader) {} // 0x000000018409A570-0x000000018409A980
	
		// Methods
		public bool TryGetValue(string enumName, out int enumVal) {
			enumVal = default;
			return default;
		} // 0x000000018C0A9BC0-0x000000018C0A9C8C
	}

	internal class BeanType : IEnumerable<KeyValuePair<string, Beyond.SparkBuffer.Runtime.Field>> // TypeDefIndex: 58729
	{
		// Fields
		private Dictionary<string, Beyond.SparkBuffer.Runtime.Field> m_fields; // 0x10
		private int _typeHash_k__BackingField; // 0x18
		private string _name_k__BackingField; // 0x20
	
		// Properties
		public int typeHash { get; private set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public string name { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
	
		// Constructors
		public BeanType() {} // Dummy constructor
		public BeanType(ByteReader reader) {} // 0x000000018409A250-0x000000018409A570
	
		// Methods
		public override string ToString() => default; // 0x000000018C0A885C-0x000000018C0A88CC
		public void Resolve(SparkManager manager) {} // 0x0000000184096EF0-0x0000000184097030
		public bool TryGetField(string fieldName, out Beyond.SparkBuffer.Runtime.Field field) {
			field = default;
			return default;
		} // 0x0000000183FA8520-0x0000000183FA8C30
		public Dictionary<string, Beyond.SparkBuffer.Runtime.Field> GetEnumerator() => default; // 0x000000018C0A8714-0x000000018C0A878C
		IEnumerator<KeyValuePair<string, Beyond.SparkBuffer.Runtime.Field>> IEnumerable<KeyValuePair<string, Field>>.GetEnumerator() => default; // 0x000000018C0A878C-0x000000018C0A87F4
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0A87F4-0x000000018C0A885C
		private Beyond.SparkBuffer.Runtime.Field _NewField(string name, SparkType type, int offset) => default; // 0x000000018409A980-0x000000018409AAE0
	}
}

namespace Beyond.SparkBuffer.Runtime.Wrapper
{
	public interface IArrayWrapper<T> // TypeDefIndex: 58730
	{
		// Properties
		int length { get; }
		int Count { get; }
		T this[int index] { get => default; }
	}

	public struct ArrayEnumerator<TElement, TArray> : IEnumerator<TElement> // TypeDefIndex: 58731
		where TArray : IArrayWrapper<TElement>
	{
		// Fields
		private readonly TArray m_parent;
		private int m_index;
	
		// Properties
		public TElement Current { get => default; }
		object IEnumerator.Current { get => default; }
	
		// Constructors
		public ArrayEnumerator(TArray parent) : this() {
			m_parent = default;
			m_index = default;
		}
	
		// Methods
		public bool MoveNext() => default;
		public void Dispose() {}
		void IEnumerator.Reset() {}
	}

	public struct NullableBeanArray<TBean> : IArrayWrapper<TBean?>, IEnumerable<TBean?> // TypeDefIndex: 58732
		where TBean : struct
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array;
		private Func<Bean, TBean> m_creator;
	
		// Properties
		public int length { get => default; }
		public int Count { get => default; }
		public TBean? this[int index] { get => default; }
	
		// Constructors
		public NullableBeanArray(Beyond.SparkBuffer.Runtime.Array array, Func<Bean, TBean> creator) : this() {
			m_array = default;
			m_creator = default;
		}
	
		// Methods
		public ArrayEnumerator<TBean?, NullableBeanArray<TBean>> GetEnumerator() => default;
		IEnumerator<TBean?> IEnumerable<TBean?>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public struct BeanArray<TBean> : IArrayWrapper<TBean>, IEnumerable<TBean> // TypeDefIndex: 58733
		where TBean : struct
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array;
		private Func<Bean, TBean> m_creator;
	
		// Properties
		public int length { get => default; }
		public int Count { get => default; }
		public TBean this[int index] { get => default; }
	
		// Constructors
		public BeanArray(Beyond.SparkBuffer.Runtime.Array array, Func<Bean, TBean> creator) : this() {
			m_array = default;
			m_creator = default;
		}
	
		// Methods
		public ArrayEnumerator<TBean, BeanArray<TBean>> GetEnumerator() => default;
		IEnumerator<TBean> IEnumerable<TBean>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public struct EnumArray<TEnum> : IArrayWrapper<TEnum>, IEnumerable<TEnum> // TypeDefIndex: 58734
		where TEnum : struct
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array;
		private Func<int, TEnum> m_converter;
	
		// Properties
		public int length { get => default; }
		public int Count { get => default; }
		public TEnum this[int index] { get => default; }
	
		// Constructors
		public EnumArray(Beyond.SparkBuffer.Runtime.Array array, Func<int, TEnum> converter) : this() {
			m_array = default;
			m_converter = default;
		}
	
		// Methods
		public ArrayEnumerator<TEnum, EnumArray<TEnum>> GetEnumerator() => default;
		public TEnum[] ToArray() => default;
		public bool Contains(TEnum item) => default;
		IEnumerator<TEnum> IEnumerable<TEnum>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public struct BoolArray : IArrayWrapper<bool>, IEnumerable<bool> // TypeDefIndex: 58735
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000181424480-0x0000000181424490 
		public int Count { get => default; } // 0x0000000181424480-0x0000000181424490 
		public bool this[int index] { get => default; } // 0x0000000186473CF8-0x0000000186473D00 
	
		// Constructors
		public BoolArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x000000018C0A8F10-0x000000018C0A8F34
	
		// Methods
		public ArrayEnumerator<bool, BoolArray> GetEnumerator() => default; // 0x000000018C0A8D3C-0x000000018C0A8DB0
		public bool[] ToArray() => default; // 0x000000018C0A8E88-0x000000018C0A8F10
		public bool Contains(bool item) => default; // 0x000000018C0A8CF4-0x000000018C0A8D3C
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator() => default; // 0x000000018C0A8DB0-0x000000018C0A8E1C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0A8E1C-0x000000018C0A8E88
	}

	public struct ByteArray : IArrayWrapper<byte>, IEnumerable<byte> // TypeDefIndex: 58736
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000181424480-0x0000000181424490 
		public int Count { get => default; } // 0x0000000181424480-0x0000000181424490 
		public byte this[int index] { get => default; } // 0x000000018C0A9150-0x000000018C0A9158 
	
		// Constructors
		public ByteArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x000000018C0A8F10-0x000000018C0A8F34
	
		// Methods
		public ArrayEnumerator<byte, ByteArray> GetEnumerator() => default; // 0x000000018C0A8F7C-0x000000018C0A8FF0
		public byte[] ToArray() => default; // 0x000000018C0A90C8-0x000000018C0A9150
		public bool Contains(byte item) => default; // 0x000000018C0A8F34-0x000000018C0A8F7C
		IEnumerator<byte> IEnumerable<byte>.GetEnumerator() => default; // 0x000000018C0A8FF0-0x000000018C0A905C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0A905C-0x000000018C0A90C8
	}

	public struct IntArray : IArrayWrapper<int>, IEnumerable<int> // TypeDefIndex: 58737
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000181424480-0x0000000181424490 
		public int Count { get => default; } // 0x0000000181424480-0x0000000181424490 
		public int this[int index] { get => default; } // 0x00000001864729A0-0x00000001864729B0 
	
		// Constructors
		public IntArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x000000018C0A8F10-0x000000018C0A8F34
	
		// Methods
		public ArrayEnumerator<int, IntArray> GetEnumerator() => default; // 0x00000001858993F0-0x0000000185899460
		public int[] ToArray() => default; // 0x000000018C0AB224-0x000000018C0AB2AC
		public bool Contains(int item) => default; // 0x000000018C0AB170-0x000000018C0AB1B8
		IEnumerator<int> IEnumerable<int>.GetEnumerator() => default; // 0x0000000185899380-0x00000001858993F0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AB1B8-0x000000018C0AB224
	}

	public struct LongArray : IArrayWrapper<long>, IEnumerable<long> // TypeDefIndex: 58738
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000181424480-0x0000000181424490 
		public int Count { get => default; } // 0x0000000181424480-0x0000000181424490 
		public long this[int index] { get => default; } // 0x000000018C0B0748-0x000000018C0B0750 
	
		// Constructors
		public LongArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x000000018C0A8F10-0x000000018C0A8F34
	
		// Methods
		public ArrayEnumerator<long, LongArray> GetEnumerator() => default; // 0x000000018C0B0570-0x000000018C0B05E4
		public long[] ToArray() => default; // 0x000000018C0B06BC-0x000000018C0B0748
		public bool Contains(long item) => default; // 0x000000018C0B0528-0x000000018C0B0570
		IEnumerator<long> IEnumerable<long>.GetEnumerator() => default; // 0x000000018C0B05E4-0x000000018C0B0650
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0B0650-0x000000018C0B06BC
	}

	public struct FloatArray : IArrayWrapper<float>, IEnumerable<float> // TypeDefIndex: 58739
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000181424480-0x0000000181424490 
		public int Count { get => default; } // 0x0000000181424480-0x0000000181424490 
		public float this[int index] { get => default; } // 0x0000000186473D00-0x0000000186473D08 
	
		// Constructors
		public FloatArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x000000018C0A8F10-0x000000018C0A8F34
	
		// Methods
		public ArrayEnumerator<float, FloatArray> GetEnumerator() => default; // 0x000000018C0AA084-0x000000018C0AA0F8
		public float[] ToArray() => default; // 0x000000018C0AA1D0-0x000000018C0AA25C
		IEnumerator<float> IEnumerable<float>.GetEnumerator() => default; // 0x000000018C0AA0F8-0x000000018C0AA164
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AA164-0x000000018C0AA1D0
	}

	public struct DoubleArray : IArrayWrapper<double>, IEnumerable<double> // TypeDefIndex: 58740
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000181424480-0x0000000181424490 
		public int Count { get => default; } // 0x0000000181424480-0x0000000181424490 
		public double this[int index] { get => default; } // 0x0000000186471D90-0x0000000186471D98 
	
		// Constructors
		public DoubleArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x000000018C0A8F10-0x000000018C0A8F34
	
		// Methods
		public ArrayEnumerator<double, DoubleArray> GetEnumerator() => default; // 0x000000018C0A99E8-0x000000018C0A9A5C
		public double[] ToArray() => default; // 0x000000018C0A9B34-0x000000018C0A9BC0
		IEnumerator<double> IEnumerable<double>.GetEnumerator() => default; // 0x000000018C0A9A5C-0x000000018C0A9AC8
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0A9AC8-0x000000018C0A9B34
	}

	public struct StringArray : IArrayWrapper<string>, IEnumerable<string> // TypeDefIndex: 58741
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000181424480-0x0000000181424490 
		public int Count { get => default; } // 0x0000000181424480-0x0000000181424490 
		public string this[int index] { get => default; } // 0x0000000186471A68-0x0000000186471A70 
	
		// Constructors
		public StringArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x000000018C0A8F10-0x000000018C0A8F34
	
		// Methods
		public ArrayEnumerator<string, StringArray> GetEnumerator() => default; // 0x0000000184ABE910-0x0000000184ABE980
		public string[] ToArray() => default; // 0x0000000185B9B290-0x0000000185B9B320
		public bool Contains(string item) => default; // 0x0000000184AC42A0-0x0000000184AC4350
		IEnumerator<string> IEnumerable<string>.GetEnumerator() => default; // 0x0000000184ABE0C0-0x0000000184ABE130
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0BA424-0x000000018C0BA490
	}

	public interface IBeanWrapper // TypeDefIndex: 58742
	{
		// Methods
		void SetBean(ref Bean bean);
	}

	public struct HashSlot // TypeDefIndex: 58743
	{
		// Fields
		public int offset; // 0x00
		public int bucketsSize; // 0x04
		public static readonly int size; // 0x00
	
		// Constructors
		static HashSlot() {
			size = default;
		} // 0x0000000185FA4960-0x0000000185FA49A0
	}

	public interface IMapWrapper<TKey, TValue, TMap> // TypeDefIndex: 58744
		where TMap : IMapWrapper<TKey, TValue, TMap>
	{
		// Properties
		int count { get; }
		int Count { get; }
		TValue this[TKey key] { get => default; }
	
		// Methods
		bool ContainsKey(TKey key);
		TValue GetValue(TKey key);
		bool TryGetValue(TKey key, out ref TValue value);
		TKey GetKeyByIndex(int index);
		TValue GetValueByIndex(int index);
		MapEnumerator<TKey, TValue, TMap> GetEnumerator();
	}

	public struct MapEnumerator<TKey, TValue, TMap> : IEnumerator<KeyValuePair<TKey, TValue>> // TypeDefIndex: 58745
		where TMap : IMapWrapper<TKey, TValue, TMap>
	{
		// Fields
		private readonly TMap m_parent;
		private int m_index;
	
		// Properties
		public KeyValuePair<TKey, TValue> Current { get => default; }
		object IEnumerator.Current { get => default; }
	
		// Constructors
		public MapEnumerator(TMap parent) : this() {
			m_parent = default;
			m_index = default;
		}
	
		// Methods
		public bool MoveNext() => default;
		public void Dispose() {}
		void IEnumerator.Reset() {}
	}

	public struct S2NullableBeanMap<TBean> : IMapWrapper<string, TBean?, S2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<string, TBean?>> // TypeDefIndex: 58746
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get => default; }
		public int Count { get => default; }
		public TBean? this[string key] { get => default; }
	
		// Constructors
		public S2NullableBeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator) : this() {
			m_map = default;
			m_creator = default;
		}
	
		// Methods
		public bool ContainsKey(string key) => default;
		public string GetKeyByIndex(int index) => default;
		public TBean? GetValue(string key) => default;
		public bool TryGetValue(string key, out TBean? value) {
			value = default;
			return default;
		}
		public TBean? GetValueByIndex(int index) => default;
		public MapEnumerator<string, TBean?, S2NullableBeanMap<TBean>> GetEnumerator() => default;
		IEnumerator<KeyValuePair<string, TBean?>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TBean?>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public struct S2BeanMap<TBean> : IMapWrapper<string, TBean, S2BeanMap<TBean>>, IEnumerable<KeyValuePair<string, TBean>> // TypeDefIndex: 58747
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get => default; }
		public int Count { get => default; }
		public TBean this[string key] { get => default; }
	
		// Constructors
		public S2BeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator) : this() {
			m_map = default;
			m_creator = default;
		}
	
		// Methods
		public bool ContainsKey(string key) => default;
		public string GetKeyByIndex(int index) => default;
		public TBean GetValue(string key) => default;
		public bool TryGetValue(string key, out ref TBean value) {
			value = default;
			return default;
		}
		public TBean GetValueByIndex(int index) => default;
		public MapEnumerator<string, TBean, S2BeanMap<TBean>> GetEnumerator() => default;
		IEnumerator<KeyValuePair<string, TBean>> IEnumerable<KeyValuePair<string, TBean>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public struct S2EnumMap<TEnum> : IMapWrapper<string, TEnum, S2EnumMap<TEnum>>, IEnumerable<KeyValuePair<string, TEnum>> // TypeDefIndex: 58748
		where TEnum : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private Func<int, TEnum> m_converter;
	
		// Properties
		public int count { get => default; }
		public int Count { get => default; }
		public TEnum this[string key] { get => default; }
	
		// Constructors
		public S2EnumMap(Beyond.SparkBuffer.Runtime.Map map, Func<int, TEnum> converter) : this() {
			m_map = default;
			m_converter = default;
		}
	
		// Methods
		public bool ContainsKey(string key) => default;
		public string GetKeyByIndex(int index) => default;
		public TEnum GetValue(string key) => default;
		public bool TryGetValue(string key, out ref TEnum value) {
			value = default;
			return default;
		}
		public TEnum GetValueByIndex(int index) => default;
		public MapEnumerator<string, TEnum, S2EnumMap<TEnum>> GetEnumerator() => default;
		IEnumerator<KeyValuePair<string, TEnum>> IEnumerable<KeyValuePair<string, TEnum>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public struct S2BoolMap : IMapWrapper<string, bool, S2BoolMap>, IEnumerable<KeyValuePair<string, bool>> // TypeDefIndex: 58749
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public bool this[string key] { get => default; } // 0x000000018C0B52F4-0x000000018C0B5338 
	
		// Constructors
		public S2BoolMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000189CBE758-0x0000000189CBE79C
		public string GetKeyByIndex(int index) => default; // 0x000000018545A7E0-0x000000018545A830
		public bool GetValue(string key) => default; // 0x000000018C0B52F4-0x000000018C0B5338
		public bool TryGetValue(string key, out bool value) {
			value = default;
			return default;
		} // 0x0000000184566300-0x0000000184566380
		public bool GetValueByIndex(int index) => default; // 0x000000018C0AA32C-0x000000018C0AA370
		public MapEnumerator<string, bool, S2BoolMap> GetEnumerator() => default; // 0x000000018C0B521C-0x000000018C0B52F4
		IEnumerator<KeyValuePair<string, bool>> IEnumerable<KeyValuePair<string, bool>>.GetEnumerator() => default; // 0x000000018C0B5338-0x000000018C0B53B8
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0B53B8-0x000000018C0B5438
	}

	public struct S2ByteMap : IMapWrapper<string, byte, S2ByteMap>, IEnumerable<KeyValuePair<string, byte>> // TypeDefIndex: 58750
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public byte this[string key] { get => default; } // 0x000000018C0B5510-0x000000018C0B5554 
	
		// Constructors
		public S2ByteMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000189CBE758-0x0000000189CBE79C
		public string GetKeyByIndex(int index) => default; // 0x000000018545A7E0-0x000000018545A830
		public byte GetValue(string key) => default; // 0x000000018C0B5510-0x000000018C0B5554
		public bool TryGetValue(string key, out byte value) {
			value = default;
			return default;
		} // 0x000000018C0B5654-0x000000018C0B5698
		public byte GetValueByIndex(int index) => default; // 0x000000018C0AA5C8-0x000000018C0AA60C
		public MapEnumerator<string, byte, S2ByteMap> GetEnumerator() => default; // 0x000000018C0B5438-0x000000018C0B5510
		IEnumerator<KeyValuePair<string, byte>> IEnumerable<KeyValuePair<string, byte>>.GetEnumerator() => default; // 0x000000018C0B5554-0x000000018C0B55D4
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0B55D4-0x000000018C0B5654
	}

	public struct S2IntMap : IMapWrapper<string, int, S2IntMap>, IEnumerable<KeyValuePair<string, int>> // TypeDefIndex: 58751
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int this[string key] { get => default; } // 0x0000000184099D50-0x0000000184099E10 
	
		// Constructors
		public S2IntMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x000000018409C5D0-0x000000018409C620
		public string GetKeyByIndex(int index) => default; // 0x000000018545A7E0-0x000000018545A830
		public int GetValue(string key) => default; // 0x0000000184098DD0-0x0000000184098E90
		public bool TryGetValue(string key, out int value) {
			value = default;
			return default;
		} // 0x0000000184C67D20-0x0000000184C67DB0
		public int GetValueByIndex(int index) => default; // 0x000000018C0AAC08-0x000000018C0AAC4C
		public MapEnumerator<string, int, S2IntMap> GetEnumerator() => default; // 0x000000018C0B5B58-0x000000018C0B5C30
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator() => default; // 0x000000018C0B5C30-0x000000018C0B5CB0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0B5CB0-0x000000018C0B5D30
	}

	public struct S2LongMap : IMapWrapper<string, long, S2LongMap>, IEnumerable<KeyValuePair<string, long>> // TypeDefIndex: 58752
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public long this[string key] { get => default; } // 0x000000018C0B5E08-0x000000018C0B5E4C 
	
		// Constructors
		public S2LongMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000189CBE758-0x0000000189CBE79C
		public string GetKeyByIndex(int index) => default; // 0x000000018545A7E0-0x000000018545A830
		public long GetValue(string key) => default; // 0x000000018C0B5E08-0x000000018C0B5E4C
		public bool TryGetValue(string key, out long value) {
			value = default;
			return default;
		} // 0x000000018C0B5F4C-0x000000018C0B5F90
		public long GetValueByIndex(int index) => default; // 0x000000018C0AAEA4-0x000000018C0AAEE8
		public MapEnumerator<string, long, S2LongMap> GetEnumerator() => default; // 0x000000018C0B5D30-0x000000018C0B5E08
		IEnumerator<KeyValuePair<string, long>> IEnumerable<KeyValuePair<string, long>>.GetEnumerator() => default; // 0x000000018C0B5E4C-0x000000018C0B5ECC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0B5ECC-0x000000018C0B5F4C
	}

	public struct S2FloatMap : IMapWrapper<string, float, S2FloatMap>, IEnumerable<KeyValuePair<string, float>> // TypeDefIndex: 58753
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public float this[string key] { get => default; } // 0x000000018C0B59D0-0x000000018C0B5A14 
	
		// Constructors
		public S2FloatMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000189CBE758-0x0000000189CBE79C
		public string GetKeyByIndex(int index) => default; // 0x000000018545A7E0-0x000000018545A830
		public float GetValue(string key) => default; // 0x000000018C0B59D0-0x000000018C0B5A14
		public bool TryGetValue(string key, out float value) {
			value = default;
			return default;
		} // 0x000000018C0B5B14-0x000000018C0B5B58
		public float GetValueByIndex(int index) => default; // 0x000000018C0AFCD4-0x000000018C0AFD18
		public MapEnumerator<string, float, S2FloatMap> GetEnumerator() => default; // 0x000000018C0B58F8-0x000000018C0B59D0
		IEnumerator<KeyValuePair<string, float>> IEnumerable<KeyValuePair<string, float>>.GetEnumerator() => default; // 0x000000018C0B5A14-0x000000018C0B5A94
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0B5A94-0x000000018C0B5B14
	}

	public struct S2DoubleMap : IMapWrapper<string, double, S2DoubleMap>, IEnumerable<KeyValuePair<string, double>> // TypeDefIndex: 58754
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public double this[string key] { get => default; } // 0x000000018C0B5770-0x000000018C0B57B4 
	
		// Constructors
		public S2DoubleMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000189CBE758-0x0000000189CBE79C
		public string GetKeyByIndex(int index) => default; // 0x000000018545A7E0-0x000000018545A830
		public double GetValue(string key) => default; // 0x000000018C0B5770-0x000000018C0B57B4
		public bool TryGetValue(string key, out double value) {
			value = default;
			return default;
		} // 0x000000018C0B58B4-0x000000018C0B58F8
		public double GetValueByIndex(int index) => default; // 0x000000018C0AA864-0x000000018C0AA8A8
		public MapEnumerator<string, double, S2DoubleMap> GetEnumerator() => default; // 0x000000018C0B5698-0x000000018C0B5770
		IEnumerator<KeyValuePair<string, double>> IEnumerable<KeyValuePair<string, double>>.GetEnumerator() => default; // 0x000000018C0B57B4-0x000000018C0B5834
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0B5834-0x000000018C0B58B4
	}

	public struct S2StringMap : IMapWrapper<string, string, S2StringMap>, IEnumerable<KeyValuePair<string, string>> // TypeDefIndex: 58755
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public string this[string key] { get => default; } // 0x000000018C0B6068-0x000000018C0B60AC 
	
		// Constructors
		public S2StringMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000189CBE758-0x0000000189CBE79C
		public string GetKeyByIndex(int index) => default; // 0x000000018545A7E0-0x000000018545A830
		public string GetValue(string key) => default; // 0x000000018C0B6068-0x000000018C0B60AC
		public bool TryGetValue(string key, out string value) {
			value = default;
			return default;
		} // 0x000000018549A640-0x000000018549A6E0
		public string GetValueByIndex(int index) => default; // 0x000000018C0B03A0-0x000000018C0B03E4
		public MapEnumerator<string, string, S2StringMap> GetEnumerator() => default; // 0x000000018C0B5F90-0x000000018C0B6068
		IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator() => default; // 0x000000018C0B60AC-0x000000018C0B612C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0B612C-0x000000018C0B61AC
	}

	public struct I2NullableBeanMap<TBean> : IMapWrapper<int, TBean?, I2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<int, TBean?>> // TypeDefIndex: 58756
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get => default; }
		public int Count { get => default; }
		public TBean? this[int key] { get => default; }
	
		// Constructors
		public I2NullableBeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator) : this() {
			m_map = default;
			m_creator = default;
		}
	
		// Methods
		public bool ContainsKey(int key) => default;
		public int GetKeyByIndex(int index) => default;
		public TBean? GetValue(int key) => default;
		public bool TryGetValue(int key, out TBean? value) {
			value = default;
			return default;
		}
		public TBean? GetValueByIndex(int index) => default;
		public MapEnumerator<int, TBean?, I2NullableBeanMap<TBean>> GetEnumerator() => default;
		IEnumerator<KeyValuePair<int, TBean?>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,TBean?>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public struct I2BeanMap<TBean> : IMapWrapper<int, TBean, I2BeanMap<TBean>>, IEnumerable<KeyValuePair<int, TBean>> // TypeDefIndex: 58757
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get => default; }
		public int Count { get => default; }
		public TBean this[int key] { get => default; }
	
		// Constructors
		public I2BeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator) : this() {
			m_map = default;
			m_creator = default;
		}
	
		// Methods
		public bool ContainsKey(int key) => default;
		public int GetKeyByIndex(int index) => default;
		public TBean GetValue(int key) => default;
		public bool TryGetValue(int key, out ref TBean value) {
			value = default;
			return default;
		}
		public TBean GetValueByIndex(int index) => default;
		public MapEnumerator<int, TBean, I2BeanMap<TBean>> GetEnumerator() => default;
		IEnumerator<KeyValuePair<int, TBean>> IEnumerable<KeyValuePair<int, TBean>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public struct I2EnumMap<TEnum> : IMapWrapper<int, TEnum, I2EnumMap<TEnum>>, IEnumerable<KeyValuePair<int, TEnum>> // TypeDefIndex: 58758
		where TEnum : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private Func<int, TEnum> m_converter;
	
		// Properties
		public int count { get => default; }
		public int Count { get => default; }
		public TEnum this[int key] { get => default; }
	
		// Constructors
		public I2EnumMap(Beyond.SparkBuffer.Runtime.Map map, Func<int, TEnum> converter) : this() {
			m_map = default;
			m_converter = default;
		}
	
		// Methods
		public bool ContainsKey(int key) => default;
		public int GetKeyByIndex(int index) => default;
		public TEnum GetValue(int key) => default;
		public bool TryGetValue(int key, out ref TEnum value) {
			value = default;
			return default;
		}
		public TEnum GetValueByIndex(int index) => default;
		public MapEnumerator<int, TEnum, I2EnumMap<TEnum>> GetEnumerator() => default;
		IEnumerator<KeyValuePair<int, TEnum>> IEnumerable<KeyValuePair<int, TEnum>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public struct I2BoolMap : IMapWrapper<int, bool, I2BoolMap>, IEnumerable<KeyValuePair<int, bool>> // TypeDefIndex: 58759
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public bool this[int key] { get => default; } // 0x000000018C0AA370-0x000000018C0AA3B4 
	
		// Constructors
		public I2BoolMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x00000001891D5370-0x00000001891D53B4
		public int GetKeyByIndex(int index) => default; // 0x00000001846FFBF0-0x00000001846FFC40
		public bool GetValue(int key) => default; // 0x000000018C0AA370-0x000000018C0AA3B4
		public bool TryGetValue(int key, out bool value) {
			value = default;
			return default;
		} // 0x000000018C0AA4B4-0x000000018C0AA4F8
		public bool GetValueByIndex(int index) => default; // 0x000000018C0AA32C-0x000000018C0AA370
		public MapEnumerator<int, bool, I2BoolMap> GetEnumerator() => default; // 0x000000018C0AA25C-0x000000018C0AA32C
		IEnumerator<KeyValuePair<int, bool>> IEnumerable<KeyValuePair<int, bool>>.GetEnumerator() => default; // 0x000000018C0AA3B4-0x000000018C0AA434
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AA434-0x000000018C0AA4B4
	}

	public struct I2ByteMap : IMapWrapper<int, byte, I2ByteMap>, IEnumerable<KeyValuePair<int, byte>> // TypeDefIndex: 58760
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public byte this[int key] { get => default; } // 0x000000018C0AA60C-0x000000018C0AA650 
	
		// Constructors
		public I2ByteMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x00000001891D5370-0x00000001891D53B4
		public int GetKeyByIndex(int index) => default; // 0x00000001846FFBF0-0x00000001846FFC40
		public byte GetValue(int key) => default; // 0x000000018C0AA60C-0x000000018C0AA650
		public bool TryGetValue(int key, out byte value) {
			value = default;
			return default;
		} // 0x000000018C0AA750-0x000000018C0AA794
		public byte GetValueByIndex(int index) => default; // 0x000000018C0AA5C8-0x000000018C0AA60C
		public MapEnumerator<int, byte, I2ByteMap> GetEnumerator() => default; // 0x000000018C0AA4F8-0x000000018C0AA5C8
		IEnumerator<KeyValuePair<int, byte>> IEnumerable<KeyValuePair<int, byte>>.GetEnumerator() => default; // 0x000000018C0AA650-0x000000018C0AA6D0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AA6D0-0x000000018C0AA750
	}

	public struct I2IntMap : IMapWrapper<int, int, I2IntMap>, IEnumerable<KeyValuePair<int, int>> // TypeDefIndex: 58761
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int this[int key] { get => default; } // 0x000000018C0AAC4C-0x000000018C0AAC90 
	
		// Constructors
		public I2IntMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x00000001891D5370-0x00000001891D53B4
		public int GetKeyByIndex(int index) => default; // 0x00000001846FFBF0-0x00000001846FFC40
		public int GetValue(int key) => default; // 0x000000018C0AAC4C-0x000000018C0AAC90
		public bool TryGetValue(int key, out int value) {
			value = default;
			return default;
		} // 0x000000018C0AAD90-0x000000018C0AADD4
		public int GetValueByIndex(int index) => default; // 0x000000018C0AAC08-0x000000018C0AAC4C
		public MapEnumerator<int, int, I2IntMap> GetEnumerator() => default; // 0x000000018C0AAB38-0x000000018C0AAC08
		IEnumerator<KeyValuePair<int, int>> IEnumerable<KeyValuePair<int, int>>.GetEnumerator() => default; // 0x000000018C0AAC90-0x000000018C0AAD10
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AAD10-0x000000018C0AAD90
	}

	public struct I2LongMap : IMapWrapper<int, long, I2LongMap>, IEnumerable<KeyValuePair<int, long>> // TypeDefIndex: 58762
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public long this[int key] { get => default; } // 0x000000018C0AAEE8-0x000000018C0AAF2C 
	
		// Constructors
		public I2LongMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x00000001891D5370-0x00000001891D53B4
		public int GetKeyByIndex(int index) => default; // 0x00000001846FFBF0-0x00000001846FFC40
		public long GetValue(int key) => default; // 0x000000018C0AAEE8-0x000000018C0AAF2C
		public bool TryGetValue(int key, out long value) {
			value = default;
			return default;
		} // 0x000000018C0AB02C-0x000000018C0AB070
		public long GetValueByIndex(int index) => default; // 0x000000018C0AAEA4-0x000000018C0AAEE8
		public MapEnumerator<int, long, I2LongMap> GetEnumerator() => default; // 0x000000018C0AADD4-0x000000018C0AAEA4
		IEnumerator<KeyValuePair<int, long>> IEnumerable<KeyValuePair<int, long>>.GetEnumerator() => default; // 0x000000018C0AAF2C-0x000000018C0AAFAC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AAFAC-0x000000018C0AB02C
	}

	public struct I2FloatMap : IMapWrapper<int, float, I2FloatMap>, IEnumerable<KeyValuePair<int, float>> // TypeDefIndex: 58763
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public float this[int key] { get => default; } // 0x000000018C0AAA30-0x000000018C0AAA74 
	
		// Constructors
		public I2FloatMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x00000001891D5370-0x00000001891D53B4
		public int GetKeyByIndex(int index) => default; // 0x00000001846FFBF0-0x00000001846FFC40
		public float GetValue(int key) => default; // 0x000000018C0AAA30-0x000000018C0AAA74
		public bool TryGetValue(int key, out float value) {
			value = default;
			return default;
		} // 0x000000018C0AAAF4-0x000000018C0AAB38
		public float GetValueByIndex(int index) => default; // 0x0000000184F898F0-0x0000000184F89960
		public MapEnumerator<int, float, I2FloatMap> GetEnumerator() => default; // 0x0000000185F4C940-0x0000000185F4C9C0
		IEnumerator<KeyValuePair<int, float>> IEnumerable<KeyValuePair<int, float>>.GetEnumerator() => default; // 0x0000000185F4C8C0-0x0000000185F4C940
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AAA74-0x000000018C0AAAF4
	}

	public struct I2DoubleMap : IMapWrapper<int, double, I2DoubleMap>, IEnumerable<KeyValuePair<int, double>> // TypeDefIndex: 58764
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public double this[int key] { get => default; } // 0x000000018C0AA8A8-0x000000018C0AA8EC 
	
		// Constructors
		public I2DoubleMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x00000001891D5370-0x00000001891D53B4
		public int GetKeyByIndex(int index) => default; // 0x00000001846FFBF0-0x00000001846FFC40
		public double GetValue(int key) => default; // 0x000000018C0AA8A8-0x000000018C0AA8EC
		public bool TryGetValue(int key, out double value) {
			value = default;
			return default;
		} // 0x000000018C0AA9EC-0x000000018C0AAA30
		public double GetValueByIndex(int index) => default; // 0x000000018C0AA864-0x000000018C0AA8A8
		public MapEnumerator<int, double, I2DoubleMap> GetEnumerator() => default; // 0x000000018C0AA794-0x000000018C0AA864
		IEnumerator<KeyValuePair<int, double>> IEnumerable<KeyValuePair<int, double>>.GetEnumerator() => default; // 0x000000018C0AA8EC-0x000000018C0AA96C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AA96C-0x000000018C0AA9EC
	}

	public struct I2StringMap : IMapWrapper<int, string, I2StringMap>, IEnumerable<KeyValuePair<int, string>> // TypeDefIndex: 58765
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public string this[int key] { get => default; } // 0x000000018409DDD0-0x000000018409DE20 
	
		// Constructors
		public I2StringMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x000000018409C620-0x000000018409C670
		public int GetKeyByIndex(int index) => default; // 0x00000001846FFBF0-0x00000001846FFC40
		public string GetValue(int key) => default; // 0x000000018409DDD0-0x000000018409DE20
		public bool TryGetValue(int key, out string value) {
			value = default;
			return default;
		} // 0x0000000184BA9F60-0x0000000184BAA000
		public string GetValueByIndex(int index) => default; // 0x00000001846FFB50-0x00000001846FFBC0
		public MapEnumerator<int, string, I2StringMap> GetEnumerator() => default; // 0x0000000184F82D80-0x0000000184F82E00
		IEnumerator<KeyValuePair<int, string>> IEnumerable<KeyValuePair<int, string>>.GetEnumerator() => default; // 0x000000018C0AB070-0x000000018C0AB0F0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AB0F0-0x000000018C0AB170
	}

	public struct L2BoolMap : IMapWrapper<long, bool, L2BoolMap>, IEnumerable<KeyValuePair<long, bool>> // TypeDefIndex: 58766
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public bool this[long key] { get => default; } // 0x000000018C0AF374-0x000000018C0AF3B8 
	
		// Constructors
		public L2BoolMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x0000000189321D0C-0x0000000189321D50
		public long GetKeyByIndex(int index) => default; // 0x0000000189321D50-0x0000000189321D94
		public bool GetValue(long key) => default; // 0x000000018C0AF374-0x000000018C0AF3B8
		public bool TryGetValue(long key, out bool value) {
			value = default;
			return default;
		} // 0x000000018C0AF4B8-0x000000018C0AF4FC
		public bool GetValueByIndex(int index) => default; // 0x000000018C0AA32C-0x000000018C0AA370
		public MapEnumerator<long, bool, L2BoolMap> GetEnumerator() => default; // 0x000000018C0AF2A4-0x000000018C0AF374
		IEnumerator<KeyValuePair<long, bool>> IEnumerable<KeyValuePair<long, bool>>.GetEnumerator() => default; // 0x000000018C0AF3B8-0x000000018C0AF438
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AF438-0x000000018C0AF4B8
	}

	public struct L2ByteMap : IMapWrapper<long, byte, L2ByteMap>, IEnumerable<KeyValuePair<long, byte>> // TypeDefIndex: 58767
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public byte this[long key] { get => default; } // 0x000000018C0AF5CC-0x000000018C0AF610 
	
		// Constructors
		public L2ByteMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x0000000189321D0C-0x0000000189321D50
		public long GetKeyByIndex(int index) => default; // 0x0000000189321D50-0x0000000189321D94
		public byte GetValue(long key) => default; // 0x000000018C0AF5CC-0x000000018C0AF610
		public bool TryGetValue(long key, out byte value) {
			value = default;
			return default;
		} // 0x000000018C0AF710-0x000000018C0AF754
		public byte GetValueByIndex(int index) => default; // 0x000000018C0AA5C8-0x000000018C0AA60C
		public MapEnumerator<long, byte, L2ByteMap> GetEnumerator() => default; // 0x000000018C0AF4FC-0x000000018C0AF5CC
		IEnumerator<KeyValuePair<long, byte>> IEnumerable<KeyValuePair<long, byte>>.GetEnumerator() => default; // 0x000000018C0AF610-0x000000018C0AF690
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AF690-0x000000018C0AF710
	}

	public struct L2IntMap : IMapWrapper<long, int, L2IntMap>, IEnumerable<KeyValuePair<long, int>> // TypeDefIndex: 58768
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int this[long key] { get => default; } // 0x000000018C0AFA7C-0x000000018C0AFAC0 
	
		// Constructors
		public L2IntMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x0000000189321D0C-0x0000000189321D50
		public long GetKeyByIndex(int index) => default; // 0x0000000189321D50-0x0000000189321D94
		public int GetValue(long key) => default; // 0x000000018C0AFA7C-0x000000018C0AFAC0
		public bool TryGetValue(long key, out int value) {
			value = default;
			return default;
		} // 0x000000018C0AFBC0-0x000000018C0AFC04
		public int GetValueByIndex(int index) => default; // 0x000000018C0AAC08-0x000000018C0AAC4C
		public MapEnumerator<long, int, L2IntMap> GetEnumerator() => default; // 0x000000018C0AFEA0-0x000000018C0AFF70
		IEnumerator<KeyValuePair<long, int>> IEnumerable<KeyValuePair<long, int>>.GetEnumerator() => default; // 0x000000018C0AFF70-0x000000018C0AFFF0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AFFF0-0x000000018C0B0070
	}

	public struct L2LongMap : IMapWrapper<long, long, L2LongMap>, IEnumerable<KeyValuePair<long, long>> // TypeDefIndex: 58769
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public long this[long key] { get => default; } // 0x000000018C0B0140-0x000000018C0B0184 
	
		// Constructors
		public L2LongMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x0000000189321D0C-0x0000000189321D50
		public long GetKeyByIndex(int index) => default; // 0x0000000189321D50-0x0000000189321D94
		public long GetValue(long key) => default; // 0x000000018C0B0140-0x000000018C0B0184
		public bool TryGetValue(long key, out long value) {
			value = default;
			return default;
		} // 0x000000018C0B0284-0x000000018C0B02C8
		public long GetValueByIndex(int index) => default; // 0x000000018C0AAEA4-0x000000018C0AAEE8
		public MapEnumerator<long, long, L2LongMap> GetEnumerator() => default; // 0x000000018C0B0070-0x000000018C0B0140
		IEnumerator<KeyValuePair<long, long>> IEnumerable<KeyValuePair<long, long>>.GetEnumerator() => default; // 0x000000018C0B0184-0x000000018C0B0204
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0B0204-0x000000018C0B0284
	}

	public struct L2FloatMap : IMapWrapper<long, float, L2FloatMap>, IEnumerable<KeyValuePair<long, float>> // TypeDefIndex: 58770
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public float this[long key] { get => default; } // 0x000000018C0AFD18-0x000000018C0AFD5C 
	
		// Constructors
		public L2FloatMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x0000000189321D0C-0x0000000189321D50
		public long GetKeyByIndex(int index) => default; // 0x0000000189321D50-0x0000000189321D94
		public float GetValue(long key) => default; // 0x000000018C0AFD18-0x000000018C0AFD5C
		public bool TryGetValue(long key, out float value) {
			value = default;
			return default;
		} // 0x000000018C0AFE5C-0x000000018C0AFEA0
		public float GetValueByIndex(int index) => default; // 0x000000018C0AFCD4-0x000000018C0AFD18
		public MapEnumerator<long, float, L2FloatMap> GetEnumerator() => default; // 0x000000018C0AFC04-0x000000018C0AFCD4
		IEnumerator<KeyValuePair<long, float>> IEnumerable<KeyValuePair<long, float>>.GetEnumerator() => default; // 0x000000018C0AFD5C-0x000000018C0AFDDC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AFDDC-0x000000018C0AFE5C
	}

	public struct L2DoubleMap : IMapWrapper<long, double, L2DoubleMap>, IEnumerable<KeyValuePair<long, double>> // TypeDefIndex: 58771
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public double this[long key] { get => default; } // 0x000000018C0AF824-0x000000018C0AF868 
	
		// Constructors
		public L2DoubleMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x0000000189321D0C-0x0000000189321D50
		public long GetKeyByIndex(int index) => default; // 0x0000000189321D50-0x0000000189321D94
		public double GetValue(long key) => default; // 0x000000018C0AF824-0x000000018C0AF868
		public bool TryGetValue(long key, out double value) {
			value = default;
			return default;
		} // 0x000000018C0AF968-0x000000018C0AF9AC
		public double GetValueByIndex(int index) => default; // 0x000000018C0AA864-0x000000018C0AA8A8
		public MapEnumerator<long, double, L2DoubleMap> GetEnumerator() => default; // 0x000000018C0AF754-0x000000018C0AF824
		IEnumerator<KeyValuePair<long, double>> IEnumerable<KeyValuePair<long, double>>.GetEnumerator() => default; // 0x000000018C0AF868-0x000000018C0AF8E8
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AF8E8-0x000000018C0AF968
	}

	public struct L2StringMap : IMapWrapper<long, string, L2StringMap>, IEnumerable<KeyValuePair<long, string>> // TypeDefIndex: 58772
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public string this[long key] { get => default; } // 0x000000018C0B03E4-0x000000018C0B0428 
	
		// Constructors
		public L2StringMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x0000000189321D0C-0x0000000189321D50
		public long GetKeyByIndex(int index) => default; // 0x0000000189321D50-0x0000000189321D94
		public string GetValue(long key) => default; // 0x000000018C0B03E4-0x000000018C0B0428
		public bool TryGetValue(long key, out string value) {
			value = default;
			return default;
		} // 0x0000000184974770-0x0000000184974810
		public string GetValueByIndex(int index) => default; // 0x000000018C0B03A0-0x000000018C0B03E4
		public MapEnumerator<long, string, L2StringMap> GetEnumerator() => default; // 0x000000018C0B02C8-0x000000018C0B03A0
		IEnumerator<KeyValuePair<long, string>> IEnumerable<KeyValuePair<long, string>>.GetEnumerator() => default; // 0x000000018C0B0428-0x000000018C0B04A8
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0B04A8-0x000000018C0B0528
	}

	public struct L2EnumMap : IMapWrapper<long, int, L2EnumMap>, IEnumerable<KeyValuePair<long, int>> // TypeDefIndex: 58773
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int Count { get => default; } // 0x00000001835584E0-0x0000000183558500 
		public int this[long key] { get => default; } // 0x000000018C0AFA7C-0x000000018C0AFAC0 
	
		// Constructors
		public L2EnumMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018A971684-0x000000018A9716B8
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x0000000189321D0C-0x0000000189321D50
		public long GetKeyByIndex(int index) => default; // 0x0000000189321D50-0x0000000189321D94
		public int GetValue(long key) => default; // 0x000000018C0AFA7C-0x000000018C0AFAC0
		public bool TryGetValue(long key, out int value) {
			value = default;
			return default;
		} // 0x000000018C0AFBC0-0x000000018C0AFC04
		public int GetValueByIndex(int index) => default; // 0x000000018C0AAC08-0x000000018C0AAC4C
		public MapEnumerator<long, int, L2EnumMap> GetEnumerator() => default; // 0x000000018C0AF9AC-0x000000018C0AFA7C
		IEnumerator<KeyValuePair<long, int>> IEnumerable<KeyValuePair<long, int>>.GetEnumerator() => default; // 0x000000018C0AFAC0-0x000000018C0AFB40
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0AFB40-0x000000018C0AFBC0
	}

	public struct L2NullableBeanMap<TBean> : IMapWrapper<long, TBean?, L2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<long, TBean?>> // TypeDefIndex: 58774
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get => default; }
		public int Count { get => default; }
		public TBean? this[long key] { get => default; }
	
		// Constructors
		public L2NullableBeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator) : this() {
			m_map = default;
			m_creator = default;
		}
	
		// Methods
		public bool ContainsKey(long key) => default;
		public long GetKeyByIndex(int index) => default;
		public TBean? GetValue(long key) => default;
		public bool TryGetValue(long key, out TBean? value) {
			value = default;
			return default;
		}
		public TBean? GetValueByIndex(int index) => default;
		public MapEnumerator<long, TBean?, L2NullableBeanMap<TBean>> GetEnumerator() => default;
		IEnumerator<KeyValuePair<long, TBean?>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,TBean?>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public struct L2BeanMap<TBean> : IMapWrapper<long, TBean, L2BeanMap<TBean>>, IEnumerable<KeyValuePair<long, TBean>> // TypeDefIndex: 58775
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get => default; }
		public int Count { get => default; }
		public TBean this[long key] { get => default; }
	
		// Constructors
		public L2BeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator) : this() {
			m_map = default;
			m_creator = default;
		}
	
		// Methods
		public bool ContainsKey(long key) => default;
		public long GetKeyByIndex(int index) => default;
		public TBean GetValue(long key) => default;
		public bool TryGetValue(long key, out ref TBean value) {
			value = default;
			return default;
		}
		public TBean GetValueByIndex(int index) => default;
		public MapEnumerator<long, TBean, L2BeanMap<TBean>> GetEnumerator() => default;
		IEnumerator<KeyValuePair<long, TBean>> IEnumerable<KeyValuePair<long, TBean>>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}

namespace Beyond.SparkBuffer.Serialize
{
	internal static class Extensions // TypeDefIndex: 58776
	{
		// Methods
		public static bool Contains<T>(IList<T> list, T element) => default;
		public static bool IsNullOrEmpty<T>(IList<T> list) => default;
		public static bool IsNullOrEmpty<T>(ICollection<T> list) => default;
		public static bool IsNullOrEmpty(OrderedDictionary dict) => default; // 0x000000018C0AA064-0x000000018C0AA084
		public static T[] ToArrayE<T>(IEnumerable<T> enumerable) => default;
		public static T GetValue<T>(DictionaryEntry entry)
			where T : class => default;
	}

	public class JsonSerializer // TypeDefIndex: 58777
	{
		// Constructors
		public JsonSerializer() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private static JsonSerializerSettings _GenerateJsonSettings(bool indented) => default; // 0x000000018C0AF1E4-0x000000018C0AF2A4
		public static string Serialize<T>(T obj, bool indented) => default;
		public static string Serialize(object obj, bool indented) => default; // 0x000000018C0AEB7C-0x000000018C0AEBF8
		private static object _ConstructFromReflectObj(ObjectReflector.ReflectObject reflectObj) => default; // 0x000000018C0AEBF8-0x000000018C0AF1E4
	}

	internal class ObjectReflector // TypeDefIndex: 58783
	{
		// Fields
		private List<object> m_tempList; // 0x10
		private Dictionary<System.Type, ReflectType> m_typeMap; // 0x18
	
		// Nested types
		public struct ReflectResult // TypeDefIndex: 58778
		{
			// Fields
			public ReflectType[] types; // 0x00
			public ReflectObject rootObj; // 0x08
		}
	
		public class ReflectType // TypeDefIndex: 58780
		{
			// Fields
			public SparkType sparkType; // 0x10
			public System.Type concreteType; // 0x18
			public ReflectType subType1; // 0x20
			public ReflectType subType2; // 0x28
			public List<FieldInfo> beanFields; // 0x30
	
			// Nested types
			public struct FieldInfo // TypeDefIndex: 58779
			{
				// Fields
				public string name; // 0x00
				public ReflectType type; // 0x08
			}
	
			// Constructors
			public ReflectType() {} // 0x000000018C0B4474-0x000000018C0B4534
		}
	
		public class ReflectObject // TypeDefIndex: 58781
		{
			// Fields
			public object originObj; // 0x10
			public ReflectType reflectType; // 0x18
			public OrderedDictionary beanElements; // 0x20
			public List<ReflectObject> arrayElements; // 0x28
			public List<KeyValuePair<ReflectObject, ReflectObject>> mapElements; // 0x30
	
			// Constructors
			public ReflectObject() {} // 0x000000018C0B1DF0-0x000000018C0B1E74
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 58782
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<ReflectType> __9__7_0; // 0x08
			public static Comparison<ReflectType.FieldInfo> __9__9_0; // 0x10
			public static Comparison<KeyValuePair<ReflectObject, ReflectObject>> __9__13_0; // 0x18
			public static Func<System.Reflection.FieldInfo, int> __9__14_0; // 0x20
	
			// Constructors
			static __c() {} // 0x000000018C0B2168-0x000000018C0B2474
			public __c() {} // 0x000000018C0B2474-0x000000018C0B254C
	
			// Methods
			internal int __ParseInternal_b__7_0(ReflectType lhs, ReflectType rhs) => default; // 0x000000018C0B34CC-0x000000018C0B4474
			internal int __TryParseType_b__9_0(ReflectType.FieldInfo lhs, ReflectType.FieldInfo rhs) => default; // 0x000000018C0B333C-0x000000018C0B34CC
			internal int __ReflectMap_b__13_0(KeyValuePair<ReflectObject, ReflectObject> lhs, KeyValuePair<ReflectObject, ReflectObject> rhs) => default; // 0x000000018C0B2AAC-0x000000018C0B2FE8
			internal int __GetFields_b__14_0(System.Reflection.FieldInfo field) => default; // 0x000000018C0B254C-0x000000018C0B2AAC
		}
	
		// Constructors
		private ObjectReflector() {} // 0x000000018C0B2FE8-0x000000018C0B333C
	
		// Methods
		public static ReflectResult Parse(object obj) => default; // 0x000000018C0B2044-0x000000018C0B2168
		private ReflectResult _ParseInternal(object obj) => default; // 0x000000018C0B1E74-0x000000018C0B2044
		private ReflectType _ParseTypeMap(System.Type rootType) => default; // 0x0000000185492010-0x0000000185492020
		private bool _TryParseType(System.Type type, out ReflectType reflectType) {
			reflectType = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		private ReflectObject _ReflectObject(object obj, ReflectType reflectType) => default; // 0x000000018C0BA614-0x000000018C0BA678
		private ReflectObject _ReflectBean(object obj, ReflectType reflectType) => default; // 0x0000000185492010-0x0000000185492020
		private ReflectObject _ReflectArray(object obj, ReflectType reflectType) => default; // 0x000000018C0BA4B0-0x000000018C0BA4F8
		private ReflectObject _ReflectMap(object obj, ReflectType reflectType) => default; // 0x000000018C0BA5CC-0x000000018C0BA5E4
		private IEnumerable<System.Reflection.FieldInfo> _GetFields(System.Type type) => default; // 0x000000018C0BA4F8-0x000000018C0BA5CC
		private object[] _ConvertICollectionToArray(ICollection collection) => default; // 0x000000018C0BA490-0x000000018C0BA4B0
	}

	public class SparkSerializer : IDisposable // TypeDefIndex: 58788
	{
		// Fields
		private Options m_options; // 0x10
		private MemoryStream m_ms; // 0x20
		private ByteWriter m_writer; // 0x28
		private List<ObjectReflector.ReflectType> m_enumTypes; // 0x30
		private Dictionary<System.Type, ObjectReflector.ReflectType> m_beanMap; // 0x38
		private Dictionary<System.Type, int> m_typeHashMap; // 0x40
		private Dictionary<string, int> m_stringMap; // 0x48
	
		// Nested types
		private struct ReservedField // TypeDefIndex: 58784
		{
			// Fields
			public int position; // 0x00
			public ObjectReflector.ReflectObject reflectObj; // 0x08
		}
	
		public struct Options // TypeDefIndex: 58785
		{
			// Fields
			public static readonly Options DEFAULT; // 0x00
			public string rootName; // 0x00
			public string stripTypeNamePrefix; // 0x08
	
			// Constructors
			public Options(string rootName) {
				this.rootName = default;
				stripTypeNamePrefix = default;
			}
			public Options(string rootName, string stripTypeNamePrefix) {
				this.rootName = default;
				this.stripTypeNamePrefix = default;
			}
			static Options() {
				DEFAULT = default;
			} // 0x000000018C0B6B28-0x000000018C0B6B88
		}
	
		private struct HashSlot // TypeDefIndex: 58786
		{
			// Fields
			public int offset; // 0x00
			public int bucketsSize; // 0x04
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 58787
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<string> __9__23_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018C0B6B88-0x000000018C0B6C9C
			public __c() {} // 0x000000018C0BA230-0x000000018C0BA424
	
			// Methods
			internal int __ExportStrings_b__23_0(string lhs, string rhs) => default; // 0x000000018C0B6ADC-0x000000018C0B6AFC
		}
	
		// Constructors
		public SparkSerializer() {} // Dummy constructor
		private SparkSerializer(Options options) {} // 0x000000018C0B7E1C-0x000000018C0B8158
	
		// Methods
		public static byte[] Serialize<T>(T obj) => default; // 0x000000018C0B9FE4-0x000000018C0BA154
		public static byte[] Serialize<T>(T obj, Options options) => default; // 0x000000018C0B9DD8-0x000000018C0B9FE4
		public static byte[] Serialize(object obj) => default; // 0x000000018C0B9790-0x000000018C0B9AF8
		public static byte[] Serialize(object obj, Options options) => default; // 0x000000018C0B8624-0x000000018C0B8A78
		public void Dispose() {} // 0x000000018C0B9D6C-0x000000018C0B9DD8
		private byte[] _SerializeInternal(object obj) => default; // 0x000000018C0B6D28-0x000000018C0B73E0
		private void _PreprocessTypes(ObjectReflector.ReflectType[] reflectTypes) {} // 0x000000018C0B9AF8-0x000000018C0B9D6C
		private void _ExportTypeDefs() {} // 0x000000018C0B94F8-0x000000018C0B9790
		private void _ExportEnumType(ObjectReflector.ReflectType enumType) {} // 0x000000018C0B824C-0x000000018C0B8624
		private void _ExportBeanType(ObjectReflector.ReflectType beanType) {} // 0x000000018C0B7A40-0x000000018C0B7E1C
		private string _ParseTypeName(System.Type reflectType) => default; // 0x000000018C0B77EC-0x000000018C0B7A40
		private static HashSet<string> _CollectAllStrings(ObjectReflector.ReflectObject rootObj) => default; // 0x000000018C0B8A78-0x000000018C0B90AC
		private List<List<string>> _GenStringHashList(HashSet<string> strings) => default; // 0x000000018C0B73E0-0x000000018C0B77EC
		private void _ExportStrings(ObjectReflector.ReflectObject rootObj) {} // 0x000000018C0B9318-0x000000018C0B94F8
		private void _ExportElementData(ObjectReflector.ReflectObject elementObj, List<ReservedField> reservedFields) {} // 0x000000018C0B8158-0x000000018C0B824C
		private int _ExportBeanData(ObjectReflector.ReflectObject beanObj) => default; // 0x000000018C0B90AC-0x000000018C0B9318
		private int _ExportArrayData(ObjectReflector.ReflectObject arrayObj) => default; // 0x0000000184023180-0x0000000184023230
		private int _ExportMapData(ObjectReflector.ReflectObject mapObj) => default; // 0x000000018C0B6AFC-0x000000018C0B6B28
		private Dictionary<int, List<KeyValuePair<ObjectReflector.ReflectObject, ObjectReflector.ReflectObject>>> _CreateMapHashEntry(List<KeyValuePair<ObjectReflector.ReflectObject, ObjectReflector.ReflectObject>> mapElements, SparkType keyType) => default; // 0x000000018C0BA154-0x000000018C0BA230
		private void _ExportRootDef(ObjectReflector.ReflectType rootType) {} // 0x000000018C0B6C9C-0x000000018C0B6D28
		private int _ExportDataFromRoot(ObjectReflector.ReflectObject rootObj) => default; // 0x0000000184C0AB60-0x0000000184C0AB90
		private void _ExportReservedFields(List<ReservedField> reservedFields) {} // 0x000000018523F5B0-0x000000018523F5E0
		public static int GetStableStringHash(string str) => default; // 0x000000018C0BB8D8-0x000000018C0BB96C
		public static int GetStableTypeHash(System.Type type) => default; // 0x000000018C0BD8AC-0x000000018C0BD910
		private void _WriteConcreteType(System.Type type) {} // 0x0000000185492010-0x0000000185492020
		private int __ExportTypeDefs_b__17_0(ObjectReflector.ReflectType lhs, ObjectReflector.ReflectType rhs) => default; // 0x000000018B2EC90C-0x000000018B2EC920
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 58794
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64240-0x0000000185F642B0
	
		// Methods
		public IntPtr __Gen_Wrap_0(object P0) => default; // 0x000000018778763C-0x00000001877876F8
		public ReadOnlySpan<byte> __Gen_Wrap_1(IntPtr P0, int P1) => default; // 0x000000018C0BB010-0x000000018C0BB124
		public IntPtr __Gen_Wrap_2(int P0) => default; // 0x000000018C0BB124-0x000000018C0BB1DC
		public void __Gen_Wrap_3(int P0, IntPtr P1) {} // 0x000000018C0BB1DC-0x000000018C0BB2A4
		public void __Gen_Wrap_4() {} // 0x0000000187350FD4-0x000000018735105C
		public string __Gen_Wrap_5() => default; // 0x000000018C0BB2A4-0x000000018C0BB35C
		public void __Gen_Wrap_6(object P0, IntPtr P1) {} // 0x000000018C0BB35C-0x000000018C0BB424
		public StructPtrWrapper __Gen_Wrap_7(IntPtr P0, int P1, object P2) => default; // 0x000000018C0BB424-0x000000018C0BB538
		public StructPtrWrapper __Gen_Wrap_8(object P0) => default; // 0x000000018C0BB538-0x000000018C0BB614
		public void __Gen_Wrap_9(object P0) {} // 0x0000000187678964-0x0000000187678A10
		public object __Gen_Wrap_10(object P0) => default; // 0x000000018C0BAAD8-0x000000018C0BABB4
		public object __Gen_Wrap_11(IntPtr P0, object P1, int P2) => default; // 0x000000018C0BABB4-0x000000018C0BACC8
		public void __Gen_Wrap_12(object P0, object P1) {} // 0x000000018A80949C-0x000000018A809564
		public int __Gen_Wrap_13(object P0) => default; // 0x000000018767917C-0x0000000187679238
		public bool __Gen_Wrap_14(object P0, object P1) => default; // 0x000000018C0BACC8-0x000000018C0BADA0
		public string __Gen_Wrap_15(object P0) => default; // 0x000000018C0BADA0-0x000000018C0BAE7C
		public System.Type __Gen_Wrap_16(object P0) => default; // 0x000000018C0BAE7C-0x000000018C0BAF58
		public StructPtrWrapper __Gen_Wrap_17() => default; // 0x000000018C0BAF58-0x000000018C0BB010
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 58795
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018C0BB614-0x000000018C0BB6A8
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 58796
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018C0BDAF8-0x000000018C0BDB5C
		public static bool IsPatched(int id) => default; // 0x00000001848BE340-0x00000001848BE3B0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018C0BD9B4-0x000000018C0BDA80
		public object CreateWrapper(int id) => default; // 0x000000018C0BDA80-0x000000018C0BDAF8
		public object InitWrapperArray(int len) => default; // 0x000000018C0BDB5C-0x000000018C0BDBE8
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018C0BD910-0x000000018C0BD9B4
	}

	public enum IDMAP0 // TypeDefIndex: 58797
	{
		Beyond-Reflection-MethodPointerManager-GetDelegatePointer0 = 0,
		Beyond-Reflection-ObjectPointerHelper-GetReadOnlySpan0 = 1,
		Beyond-Reflection-StructMemManager-GetMemoryBySize0 = 2,
		Beyond-Reflection-StructMemManager-FreeMemory0 = 3,
		Beyond-Reflection-StructMemManager-ClearMemory0 = 4,
		Beyond-Reflection-StructMemManager-DumpMemory0 = 5,
		Beyond-Reflection-StructPtrRefrenceManager-_RunOnStart0 = 6,
		Beyond-Reflection-StructPtrRefrenceManager-AddObjInPtrRef0 = 7,
		Beyond-Reflection-StructPtrRefrenceManager-RemoveObjInPtrRef0 = 8,
		Beyond-Reflection-StructPtrWrapper-GetStructPtrWrapper0 = 9,
		Beyond-Reflection-StructPtrWrapper-GetStructPtrWrapper1 = 10,
		Beyond-Reflection-StructPtrWrapper-Release0 = 11,
		Beyond-Reflection-StructPtrWrapper-GetStructObj0 = 12,
		Beyond-Reflection-StructPtrWrapper-GetStructObj1 = 13,
		Beyond-Reflection-StructPtrWrapper-SetStructObjValue0 = 14,
		Beyond-Reflection-StructPtrWrapper-GetHashCode0 = 15,
		Beyond-Reflection-StructPtrWrapper-Equals0 = 16,
		Beyond-Reflection-StructPtrWrapper-ToString0 = 17,
		Beyond-Reflection-StructPtrWrapper-GetType0 = 18,
		Beyond-Reflection-StructPtrWrapper-GetStructObj2 = 19,
		Beyond-Reflection-StructPtrWrapper-_OnCreate0 = 20,
		Beyond-Reflection-StructPtrWrapper-_OnGet0 = 21,
		Beyond-Reflection-StructPtrWrapper-_OnRealse0 = 22
	}
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 58698
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 58699
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
