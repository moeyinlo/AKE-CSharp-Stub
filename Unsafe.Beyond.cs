/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Beyond.Reflection;
using Beyond.SparkBuffer;
using Beyond.SparkBuffer.Runtime;
using Beyond.SparkBuffer.Runtime.Wrapper;
using IFix.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Pool;

// Image 56: Unsafe.Beyond.dll - Assembly: Unsafe.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57601-57701
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Reflection
{
	public class MethodPointerManager // TypeDefIndex: 57693
	{
		// Constructors
		public MethodPointerManager() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static T2 CallPointer<T1, T2>(IntPtr ptr, T1 param) => default;
		public static TRet CallDelegatePointer<TParam1, TRet>(IntPtr ptr, TParam1 target) => default;
		public static TRet CallDelegatePointer<TParam1, TParam2, TRet>(IntPtr ptr, TParam1 target, TParam2 param) => default;
		public static ValueTuple<IntPtr, T1> GetDelegatePointer<T1>(Delegate d) => default;
		public static IntPtr GetDelegatePointer(MethodInfo d) => default; // 0x0000000189FA36EC-0x0000000189FA373C
	}

	public static class ObjectPointerHelper // TypeDefIndex: 57694
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
		public static unsafe void SetValue(IntPtr ptr, int offset, byte* data, int size) {} // 0x0000000189FA3908-0x0000000189FA391C
		public static object GetObj(IntPtr ptr, int offset) => default; // 0x0000000189FA37A8-0x0000000189FA37E4
		public static void SetObj(IntPtr ptr, int offset, object value) {} // 0x0000000189FA38B8-0x0000000189FA3908
		public static void CopyValue(IntPtr target, IntPtr source, int size) {} // 0x0000000189FA37A0-0x0000000189FA37A8
		public static unsafe void CopyValue(void* target, void* source, int size) {} // 0x0000000189FA37A0-0x0000000189FA37A8
		public static unsafe void CopyValue(byte* to, byte* from, int size) {} // 0x0000000189FA373C-0x0000000189FA37A0
		public static ReadOnlySpan<byte> GetReadOnlySpan(IntPtr ptr, int maxLength) => default; // 0x0000000189FA37E4-0x0000000189FA38B8
	}

	public class StructMemManager // TypeDefIndex: 57695
	{
		// Fields
		private static Dictionary<int, ValueTuple<HashSet<long>, List<IntPtr>>> s_structMemDict; // 0x00
	
		// Constructors
		public StructMemManager() {} // 0x000000018350B670-0x000000018350B680
		static StructMemManager() {} // 0x0000000189FA4478-0x0000000189FA4504
	
		// Methods
		public static IntPtr GetMemoryBySize(int size) => default; // 0x0000000189FA4218-0x0000000189FA4478
		public static void FreeMemory(int size, IntPtr ptr) {} // 0x0000000189FA40E8-0x0000000189FA4218
		public static void ClearMemory() {} // 0x0000000189FA39B0-0x0000000189FA3CF0
		public static string DumpMemory() => default; // 0x0000000189FA3CF0-0x0000000189FA40E8
	}

	public class StructPtrRefrenceManager // TypeDefIndex: 57696
	{
		// Fields
		private static Dictionary<object, object> s_refDic; // 0x00
		private static Dictionary<System.Type, List<int>> s_structPtrOffsetDic; // 0x08
	
		// Constructors
		public StructPtrRefrenceManager() {} // 0x000000018350B670-0x000000018350B680
		static StructPtrRefrenceManager() {} // 0x0000000183C7A8E0-0x0000000183C7A9D0
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _RunOnStart() {} // 0x0000000183CA3380-0x0000000183CA3440
		public static void AddObjInPtrRef(System.Type type, IntPtr ptr) {} // 0x0000000189FA4504-0x0000000189FA47D0
		public static void RemoveObjInPtrRef(System.Type type, IntPtr ptr) {} // 0x0000000189FA47D0-0x0000000189FA4A58
	}

	public class StructPtrWrapper // TypeDefIndex: 57697
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
		public StructPtrWrapper(IntPtr ptr, int size, System.Type type) {} // 0x0000000189FA5784-0x0000000189FA5810
		public StructPtrWrapper(object structObj) {} // 0x0000000189FA5810-0x0000000189FA58F0
		static StructPtrWrapper() {} // 0x0000000189FA55F0-0x0000000189FA5784
	
		// Methods
		[IDTag(0)]
		public static StructPtrWrapper GetStructPtrWrapper(IntPtr ptr, int size, System.Type type) => default; // 0x0000000189FA4E58-0x0000000189FA4FF4
		[IDTag(1)]
		public static StructPtrWrapper GetStructPtrWrapper(object structObj) => default; // 0x0000000189FA4D0C-0x0000000189FA4E58
		public static void Release(StructPtrWrapper obj) {} // 0x0000000189FA5040-0x0000000189FA5124
		[IDTag(0)]
		public object GetStructObj() => default; // 0x0000000189FA4C2C-0x0000000189FA4CB8
		[IDTag(1)]
		public static object GetStructObj(IntPtr ptr, System.Type type, int size) => default; // 0x0000000189FA4B88-0x0000000189FA4C2C
		public void SetStructObjValue(object structObj) {} // 0x0000000189FA5124-0x0000000189FA51A8
		public override int GetHashCode() => default; // 0x0000000189FA4B28-0x0000000189FA4B88
		public override bool Equals(object obj) => default; // 0x0000000189FA4A58-0x0000000189FA4B28
		public override string ToString() => default; // 0x0000000189FA51A8-0x0000000189FA5208
		public new System.Type GetType() => default; // 0x0000000189FA4FF4-0x0000000189FA5040
		[IDTag(2)]
		public static object GetStructObj(StructPtrWrapper obj) => default; // 0x0000000189FA4CB8-0x0000000189FA4D0C
		private static StructPtrWrapper _OnCreate() => default; // 0x0000000189FA5208-0x0000000189FA533C
		private static void _OnGet(StructPtrWrapper o) {} // 0x0000000189FA533C-0x0000000189FA5540
		private static void _OnRealse(StructPtrWrapper obj) {} // 0x0000000189FA5540-0x0000000189FA55F0
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018232CE30-0x000000018232CE40
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}
}

namespace Beyond.SparkBuffer
{
	public enum SparkType : byte // TypeDefIndex: 57604
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

	public static class Common // TypeDefIndex: 57605
	{
		// Fields
		public const int NULL_PLACEHOLDER = -1; // Metadata: 0x01FDA048
		public const int BOOL_MEM_SIZE = 1; // Metadata: 0x01FDA049
		public const int BYTE_MEM_SIZE = 1; // Metadata: 0x01FDA04A
		public const int INT_MEM_SIZE = 4; // Metadata: 0x01FDA04B
		public const int LONG_MEM_SIZE = 8; // Metadata: 0x01FDA04C
		public const int FLOAT_MEM_SIZE = 4; // Metadata: 0x01FDA04D
		public const int DOUBLE_MEM_SIZE = 8; // Metadata: 0x01FDA04E
	}

	public static class Utils // TypeDefIndex: 57606
	{
		// Methods
		public static int Align4Bytes(int position) => default; // 0x0000000189FA2CDC-0x0000000189FA2CF0
		public static int Align8Bytes(int position) => default; // 0x0000000189FA2CF0-0x0000000189FA2D04
		public static int AlignBytesForSize(int position, int size) => default; // 0x0000000189FA2D04-0x0000000189FA2D2C
		public static int GetMemSizeForType(SparkType sparkType) => default; // 0x00000001827589B0-0x0000000182758A20
		public static int GetFieldOffset(SparkType sparkType, ref int postion) => default; // 0x0000000182756F30-0x0000000182756FD0
		public static bool IsEnumOrBean(SparkType sparkType) => default; // 0x0000000189FA2D64-0x0000000189FA2D74
		public static bool IsArrayOrMap(SparkType sparkType) => default; // 0x0000000189FA2D54-0x0000000189FA2D64
		public static bool CheckValidMapKeyType(SparkType sparkType) => default; // 0x0000000189FA2D2C-0x0000000189FA2D40
		public static bool CheckValidRootType(SparkType sparkType) => default; // 0x0000000189FA2D40-0x0000000189FA2D54
	}
}

namespace Beyond.SparkBuffer.Runtime
{
	public class ByteReader : IDisposable // TypeDefIndex: 57607
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
		public int position { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
		public NativeArray<byte> buffer { get => default; } // 0x00000001820B7B30-0x00000001820B7B40 
	
		// Constructors
		public ByteReader() {} // Dummy constructor
		public ByteReader(byte[] buffer) {} // 0x000000018298B0A0-0x000000018298B160
	
		// Methods
		public void Dispose() {} // 0x0000000189F913F4-0x0000000189F91460
		public void SeekTo(int pos) {} // 0x0000000183D4EBA0-0x0000000183D4EBB0
		public bool ReadBool() => default; // 0x0000000189F91460-0x0000000189F91478
		public byte ReadByte() => default; // 0x0000000183D89FA0-0x0000000183D89FC0
		public int ReadInt() => default; // 0x0000000189F914D0-0x0000000189F914FC
		public long ReadLong() => default; // 0x0000000189F914FC-0x0000000189F9152C
		public float ReadFloat() => default; // 0x0000000189F914A4-0x0000000189F914D0
		public double ReadDouble() => default; // 0x0000000189F91478-0x0000000189F914A4
		public string ReadString() => default; // 0x0000000189F9152C-0x0000000189F915F4
		public Beyond.SparkBuffer.Runtime.Wrapper.HashSlot ReadHashSlot() => default; // 0x0000000183D89FC0-0x0000000183D89FD0
		public SparkType ReadSparkType() => default; // 0x0000000183D89FA0-0x0000000183D89FC0
		public int ReadTypeHash() => default; // 0x0000000189F915F4-0x0000000189F915FC
	}

	public class ByteWriter : IDisposable // TypeDefIndex: 57608
	{
		// Fields
		private static readonly byte[] BUFFER_0; // 0x00
		private readonly BinaryWriter m_writer; // 0x10
		private readonly Stream m_stream; // 0x18
		public static IStringPool s_stringPool; // 0x08
	
		// Properties
		public int position { get => default; } // 0x0000000189F91C60-0x0000000189F91C84 
	
		// Constructors
		public ByteWriter() {} // Dummy constructor
		public ByteWriter(Stream stream) {} // 0x0000000189F91BDC-0x0000000189F91C60
		static ByteWriter() {} // 0x0000000189F91B74-0x0000000189F91BDC
	
		// Methods
		public void Dispose() {} // 0x0000000189F915FC-0x0000000189F91638
		public void SeekTo(int pos) {} // 0x0000000189F9167C-0x0000000189F916A8
		public void WriteBool(bool v) {} // 0x0000000189F916A8-0x0000000189F916C8
		public void WriteByte(byte v) {} // 0x0000000189F916C8-0x0000000189F916E8
		public void WriteInt(int v) {} // 0x0000000189F917FC-0x0000000189F91838
		public void WriteLong(long v) {} // 0x0000000189F91838-0x0000000189F91874
		public void WriteFloat(float v) {} // 0x0000000189F917C0-0x0000000189F917FC
		public void WriteDouble(double v) {} // 0x0000000189F91784-0x0000000189F917C0
		public void WriteStringAlignment(string v) {} // 0x0000000189F91874-0x0000000189F91960
		public void WriteString(string v) {} // 0x0000000189F91960-0x0000000189F91A3C
		public void WriteBytes(ReadOnlySpan<byte> buffer, int index, int count) {} // 0x0000000189F916E8-0x0000000189F91784
		public void WriteSparkType(SparkType sparkType) {} // 0x0000000189F916C8-0x0000000189F916E8
		internal int FillAlignment(int align) => default; // 0x0000000189F91638-0x0000000189F9167C
		private void _FillAlignment4() {} // 0x0000000189F91A3C-0x0000000189F91AD8
		private void _FillAlignment8() {} // 0x0000000189F91AD8-0x0000000189F91B74
	}

	public struct Array // TypeDefIndex: 57609
	{
		// Fields
		private readonly ArrayType m_arrayType; // 0x00
		private readonly Root m_root; // 0x18
		private readonly int m_dataOffset; // 0x20
		private readonly int m_length; // 0x24
	
		// Properties
		public int length { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
	
		// Constructors
		internal Array(ArrayType arrayType, int offset, Root root) : this() {
			m_arrayType = default;
			m_root = default;
			m_dataOffset = default;
			m_length = default;
		} // 0x0000000182328250-0x0000000182328380
	
		// Methods
		public bool GetBool(int index) => default; // 0x0000000189F90714-0x0000000189F90780
		public byte GetByte(int index) => default; // 0x0000000189F90504-0x0000000189F90570
		public int GetInt(int index) => default; // 0x0000000189F908D0-0x0000000189F90940
		public long GetLong(int index) => default; // 0x0000000189F90570-0x0000000189F9064C
		public float GetFloat(int index) => default; // 0x0000000189F90860-0x0000000189F908D0
		public double GetDouble(int index) => default; // 0x0000000189F90780-0x0000000189F907F0
		public string GetString(int index) => default; // 0x0000000189F90940-0x0000000189F909B0
		public int GetEnum(int index) => default; // 0x0000000189F907F0-0x0000000189F90860
		public Bean? GetBean(int index) => default; // 0x0000000189F90684-0x0000000189F90714
	}

	public struct Bean // TypeDefIndex: 57610
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
		} // 0x0000000182329450-0x0000000182329510
	
		// Methods
		public bool GetBool(string key, out int offset) {
			offset = default;
			return default;
		} // 0x0000000189F90B68-0x0000000189F90BD8
		public bool GetBool(int offset) => default; // 0x0000000189F90BD8-0x0000000189F90C00
		public byte GetByte(string key, out int offset) {
			offset = default;
			return default;
		} // 0x0000000189F90C00-0x0000000189F90C70
		public byte GetByte(int offset) => default; // 0x0000000189F90C70-0x0000000189F90C98
		public int GetInt(string key, out int offset) {
			offset = default;
			return default;
		} // 0x0000000189F90D58-0x0000000189F90DC8
		public int GetInt(int offset) => default; // 0x0000000189F90D30-0x0000000189F90D58
		public long GetLong(string key, out int offset) {
			offset = default;
			return default;
		} // 0x0000000189F90E60-0x0000000189F90ED0
		public long GetLong(int offset) => default; // 0x0000000189F90ED0-0x0000000189F90EF8
		public float GetFloat(string key, out int offset) {
			offset = default;
			return default;
		} // 0x0000000189F90DF0-0x0000000189F90E60
		public float GetFloat(int offset) => default; // 0x0000000189F90DC8-0x0000000189F90DF0
		public double GetDouble(string key, out int offset) {
			offset = default;
			return default;
		} // 0x0000000189F90C98-0x0000000189F90D08
		public double GetDouble(int offset) => default; // 0x0000000189F90D08-0x0000000189F90D30
		public string GetString(string key, out int offset) {
			offset = default;
			return default;
		} // 0x0000000189F90EF8-0x0000000189F90F68
		public string GetString(int offset) => default; // 0x0000000189F90F68-0x0000000189F90F90
		public int GetEnum(string key, out int offset) {
			offset = default;
			return default;
		} // 0x0000000189F90D58-0x0000000189F90DC8
		public int GetEnum(int offset) => default; // 0x0000000189F90D30-0x0000000189F90D58
		public Bean? GetBean(string key) => default; // 0x00000001823285F0-0x00000001823287D0
		public Beyond.SparkBuffer.Runtime.Array? GetArray(string key) => default; // 0x0000000182328380-0x00000001823285F0
		public Beyond.SparkBuffer.Runtime.Map? GetMap(string key) => default; // 0x00000001827581E0-0x00000001827587E0
	}

	public struct Map : IEnumerable<Beyond.SparkBuffer.Runtime.Map.UnionKey> // TypeDefIndex: 57613
	{
		// Fields
		private const int INT_KEY_MEM_SIZE = 4; // Metadata: 0x01FDA04F
		private const int LONG_KEY_MEM_SIZE = 8; // Metadata: 0x01FDA050
		private readonly MapType m_mapType; // 0x00
		private readonly Root m_root; // 0x28
		private readonly int m_valueMemSize; // 0x30
		private readonly int m_keyMemSize; // 0x34
		private readonly int m_dataOffset; // 0x38
		private readonly int m_count; // 0x3C
		private readonly int m_slotsOffset; // 0x40
	
		// Properties
		public int count { get => default; } // 0x0000000183D4ED90-0x0000000183D4EDA0 
	
		// Nested types
		public struct UnionKey // TypeDefIndex: 57611
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
			} // 0x0000000189FA2C94-0x0000000189FA2CAC
			public UnionKey(long key) {
				intKey = default;
				longKey = default;
				stringKey = default;
			} // 0x0000000189FA2CC4-0x0000000189FA2CDC
			public UnionKey(string key) {
				intKey = default;
				longKey = default;
				stringKey = default;
			} // 0x0000000189FA2CAC-0x0000000189FA2CC4
		}
	
		public struct UnionKeyEnumerator : IEnumerator<UnionKey> // TypeDefIndex: 57612
		{
			// Fields
			private readonly Map m_parent; // 0x00
			private int m_index; // 0x48
			private int m_currentSlotIndex; // 0x4C
			private int m_currentSlotStartIndex; // 0x50
			private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot m_currentSlot; // 0x54
	
			// Properties
			public UnionKey Current { get => default; } // 0x0000000189FA2AB4-0x0000000189FA2C94 
			object IEnumerator.Current { get => default; } // 0x0000000189FA2A00-0x0000000189FA2A60 
	
			// Constructors
			public UnionKeyEnumerator(Map parent) : this() {
				m_parent = default;
				m_index = default;
				m_currentSlotIndex = default;
				m_currentSlotStartIndex = default;
				m_currentSlot = default;
			} // 0x0000000189FA2A60-0x0000000189FA2AB4
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189FA2914-0x0000000189FA2A00
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
			void IEnumerator.Reset() {} // 0x0000000183D89FE0-0x0000000183D8A000
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
		} // 0x00000001827587E0-0x00000001827589B0
	
		// Methods
		public UnionKeyEnumerator GetEnumerator() => default; // 0x0000000189F98E38-0x0000000189F98ED8
		IEnumerator<UnionKey> System.Collections.Generic.IEnumerable<Beyond.SparkBuffer.Runtime.Map.UnionKey>.GetEnumerator() => default; // 0x0000000189F996A8-0x0000000189F99734
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F99734-0x0000000189F997C0
		private static int GetHash(string str) => default; // 0x0000000189F9900C-0x0000000189F9902C
		private static int GetHash(int value) => default; // 0x0000000183D517B0-0x0000000183D517C0
		private static int GetHash(long value) => default; // 0x0000000183D517B0-0x0000000183D517C0
		private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(int slotIndex) => default; // 0x0000000189F98F90-0x0000000189F9900C
		private int _FindHashIndexByKey(int intKey) => default; // 0x0000000189F99D64-0x0000000189F99E3C
		private int _FindHashIndexByKey(long longKey) => default; // 0x0000000189F99C88-0x0000000189F99D64
		private int _FindHashIndexByKey(string stringKey) => default; // 0x0000000189F99E3C-0x0000000189F99F2C
		internal int GetIntKeyByIndex(int index) => default; // 0x0000000189F9902C-0x0000000189F99128
		internal long GetLongKeyByIndex(int index) => default; // 0x0000000189F99280-0x0000000189F9937C
		internal string GetStringKeyByIndex(int index) => default; // 0x0000000189F99434-0x0000000189F99530
		internal int GetIntKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex) => default; // 0x0000000189F99128-0x0000000189F99238
		internal long GetLongKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex) => default; // 0x00000001871B2740-0x00000001871B2850
		internal string GetStringKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex) => default; // 0x0000000189F99530-0x0000000189F99640
		public bool ContainsKey(string key) => default; // 0x0000000182755E70-0x0000000182755E90
		public bool GetBool(string key) => default; // 0x0000000189F98B24-0x0000000189F98B58
		public bool TryGetBool(string key, out bool value) {
			value = default;
			return default;
		} // 0x0000000182A53A90-0x0000000182A53B70
		public byte GetByte(string key) => default; // 0x0000000189F98C08-0x0000000189F98C3C
		public bool TryGetByte(string key, out byte value) {
			value = default;
			return default;
		} // 0x0000000189F99898-0x0000000189F998E0
		public int GetInt(string key) => default; // 0x0000000182755F50-0x00000001827560C0
		public bool TryGetInt(string key, out int value) {
			value = default;
			return default;
		} // 0x00000001823C81F0-0x00000001823C8240
		public long GetLong(string key) => default; // 0x0000000189F993B0-0x0000000189F993E4
		public bool TryGetLong(string key, out long value) {
			value = default;
			return default;
		} // 0x0000000189F99C40-0x0000000189F99C88
		public float GetFloat(string key) => default; // 0x0000000189F98EF4-0x0000000189F98F28
		public bool TryGetFloat(string key, out float value) {
			value = default;
			return default;
		} // 0x0000000189F99AD8-0x0000000189F99B20
		public double GetDouble(string key) => default; // 0x0000000189F98CB8-0x0000000189F98CEC
		public bool TryGetDouble(string key, out double value) {
			value = default;
			return default;
		} // 0x0000000189F99928-0x0000000189F99970
		public string GetString(string key) => default; // 0x0000000189F99640-0x0000000189F99674
		public bool TryGetString(string key, out string value) {
			value = default;
			return default;
		} // 0x00000001834960D0-0x0000000183496130
		public int GetEnum(string key) => default; // 0x0000000189F98D9C-0x0000000189F98DD0
		public bool TryGetEnum(string key, out int value) {
			value = default;
			return default;
		} // 0x0000000189F99A90-0x0000000189F99AD8
		public Bean? GetBean(string key) => default; // 0x0000000182BAC160-0x0000000182BAC3E0
		public bool TryGetBean(string key, out Bean? bean) {
			bean = default;
			return default;
		} // 0x0000000182BAB550-0x0000000182BABAA0
		public bool ContainsKey(int key) => default; // 0x0000000182758A70-0x0000000182758A90
		public bool GetBool(int key) => default; // 0x0000000189F98B58-0x0000000189F98B8C
		public bool TryGetBool(int key, out bool value) {
			value = default;
			return default;
		} // 0x0000000189F997C0-0x0000000189F99808
		public byte GetByte(int key) => default; // 0x0000000189F98BD4-0x0000000189F98C08
		public bool TryGetByte(int key, out byte value) {
			value = default;
			return default;
		} // 0x0000000189F99850-0x0000000189F99898
		public int GetInt(int key) => default; // 0x0000000189F98E04-0x0000000189F98E38
		public bool TryGetInt(int key, out int value) {
			value = default;
			return default;
		} // 0x000000018275A030-0x000000018275A1D0
		public long GetLong(int key) => default; // 0x0000000189F993E4-0x0000000189F99418
		public bool TryGetLong(int key, out long value) {
			value = default;
			return default;
		} // 0x0000000189F99BF8-0x0000000189F99C40
		public float GetFloat(int key) => default; // 0x0000000189F98F28-0x0000000189F98F5C
		public bool TryGetFloat(int key, out float value) {
			value = default;
			return default;
		} // 0x0000000189F99B68-0x0000000189F99BB0
		public double GetDouble(int key) => default; // 0x0000000189F98CEC-0x0000000189F98D20
		public bool TryGetDouble(int key, out double value) {
			value = default;
			return default;
		} // 0x0000000189F999B8-0x0000000189F99A00
		public string GetString(int key) => default; // 0x000000018275A220-0x000000018275ACF0
		public bool TryGetString(int key, out string value) {
			value = default;
			return default;
		} // 0x0000000182CF1CD0-0x0000000182CF1D30
		public int GetEnum(int key) => default; // 0x0000000189F98E04-0x0000000189F98E38
		public bool TryGetEnum(int key, out int value) {
			value = default;
			return default;
		} // 0x0000000189F99A48-0x0000000189F99A90
		public Bean? GetBean(int key) => default; // 0x0000000182BA77B0-0x0000000182BA7810
		public bool TryGetBean(int key, out Bean? bean) {
			bean = default;
			return default;
		} // 0x0000000182BA7740-0x0000000182BA77B0
		public bool ContainsKey(long key) => default; // 0x0000000189F989EC-0x0000000189F98A00
		public bool GetBool(long key) => default; // 0x0000000189F98AF0-0x0000000189F98B24
		public bool TryGetBool(long key, out bool value) {
			value = default;
			return default;
		} // 0x0000000189F99808-0x0000000189F99850
		public byte GetByte(long key) => default; // 0x0000000189F98C3C-0x0000000189F98C70
		public bool TryGetByte(long key, out byte value) {
			value = default;
			return default;
		} // 0x0000000189F998E0-0x0000000189F99928
		public int GetInt(long key) => default; // 0x0000000189F98DD0-0x0000000189F98E04
		public bool TryGetInt(long key, out int value) {
			value = default;
			return default;
		} // 0x0000000189F99A00-0x0000000189F99A48
		public long GetLong(long key) => default; // 0x0000000189F9937C-0x0000000189F993B0
		public bool TryGetLong(long key, out long value) {
			value = default;
			return default;
		} // 0x0000000189F99BB0-0x0000000189F99BF8
		public float GetFloat(long key) => default; // 0x0000000189F98F5C-0x0000000189F98F90
		public bool TryGetFloat(long key, out float value) {
			value = default;
			return default;
		} // 0x0000000189F99B20-0x0000000189F99B68
		public double GetDouble(long key) => default; // 0x0000000189F98D20-0x0000000189F98D54
		public bool TryGetDouble(long key, out double value) {
			value = default;
			return default;
		} // 0x0000000189F99970-0x0000000189F999B8
		public string GetString(long key) => default; // 0x0000000189F99674-0x0000000189F996A8
		public bool TryGetString(long key, out string value) {
			value = default;
			return default;
		} // 0x0000000182C5A740-0x0000000182C5AB80
		public int GetEnum(long key) => default; // 0x0000000189F98DD0-0x0000000189F98E04
		public bool TryGetEnum(long key, out int value) {
			value = default;
			return default;
		} // 0x0000000189F99A00-0x0000000189F99A48
		public Bean? GetBean(long key) => default; // 0x0000000189F98A40-0x0000000189F98AA8
		public bool TryGetBean(long key, out Bean? bean) {
			bean = default;
			return default;
		} // 0x0000000182C5A700-0x0000000182C5A740
		internal bool GetBoolByIndex(int index) => default; // 0x0000000189F98AA8-0x0000000189F98AD4
		internal byte GetByteByIndex(int index) => default; // 0x0000000189F98B8C-0x0000000189F98BB8
		internal int GetIntByIndex(int index) => default; // 0x0000000189F98D54-0x0000000189F98D80
		internal long GetLongByIndex(int index) => default; // 0x0000000189F99238-0x0000000189F99264
		internal float GetFloatByIndex(int index) => default; // 0x00000001830B49B0-0x00000001830B4A80
		internal double GetDoubleByIndex(int index) => default; // 0x0000000189F98C70-0x0000000189F98C9C
		internal string GetStringByIndex(int index) => default; // 0x0000000183495670-0x00000001834956A0
		internal int GetEnumByIndex(int index) => default; // 0x0000000189F98D54-0x0000000189F98D80
		internal Bean? GetBeanByIndex(int index) => default; // 0x0000000182BA9710-0x0000000182BA9780
		private int _GetOffsetByIndex(int index) => default; // 0x0000000189F99F2C-0x0000000189F9A08C
		internal bool GetBoolByOffset(int offset) => default; // 0x0000000189F98AD4-0x0000000189F98AF0
		internal byte GetByteByOffset(int offset) => default; // 0x0000000189F98BB8-0x0000000189F98BD4
		internal int GetIntByOffset(int offset) => default; // 0x0000000189F98D80-0x0000000189F98D9C
		internal long GetLongByOffset(int offset) => default; // 0x0000000189F99264-0x0000000189F99280
		internal float GetFloatByOffset(int offset) => default; // 0x0000000189F98ED8-0x0000000189F98EF4
		internal double GetDoubleByOffset(int offset) => default; // 0x0000000189F98C9C-0x0000000189F98CB8
		internal string GetStringByOffset(int offset) => default; // 0x0000000189F99418-0x0000000189F99434
		internal int GetEnumByOffset(int offset) => default; // 0x0000000189F98D80-0x0000000189F98D9C
		internal Bean? GetBeanByOffset(int offset) => default; // 0x0000000189F98A00-0x0000000189F98A40
	}

	public class Root : IDisposable // TypeDefIndex: 57615
	{
		// Fields
		private ByteReader m_reader; // 0x10
		private readonly Options m_options; // 0x18
		private readonly int m_dataOffset; // 0x40
		private Dictionary<int, string> m_cachedString; // 0x48
	
		// Properties
		public string name { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public NativeArray<byte> bytes { get => default; } // 0x0000000183191BD0-0x0000000183191C00 
	
		// Nested types
		internal struct Options // TypeDefIndex: 57614
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
		internal Root(int dataOffset, Options options, ByteReader reader) {} // 0x0000000182902810-0x00000001829028F0
	
		// Methods
		~Root() {} // 0x0000000189F9CB8C-0x0000000189F9CC54
		public override string ToString() => default; // 0x0000000189F9D23C-0x0000000189F9D2AC
		public void Dispose() {} // 0x0000000189F9CB5C-0x0000000189F9CB8C
		public bool IsValid() => default; // 0x000000018246CF60-0x000000018246CF70
		public Bean? AsBean() => default; // 0x0000000189F9C8F4-0x0000000189F9C9B0
		public Beyond.SparkBuffer.Runtime.Array? AsArray() => default; // 0x0000000189F9C7D0-0x0000000189F9C8F4
		public Beyond.SparkBuffer.Runtime.Map? AsMap() => default; // 0x0000000189F9C9B0-0x0000000189F9CB5C
		internal int GetCurReaderPosition() => default; // 0x0000000189F9CEFC-0x0000000189F9CF18
		internal bool GetBool(int offset) => default; // 0x0000000189F9CEC0-0x0000000189F9CEFC
		internal byte GetByte(int offset) => default; // 0x0000000189F9064C-0x0000000189F90684
		internal int GetInt(int offset) => default; // 0x0000000189F9CF40-0x0000000189F9CF68
		internal long GetLong(int offset) => default; // 0x0000000189F9CF68-0x0000000189F9CF90
		internal float GetFloat(int offset) => default; // 0x00000001830B4A80-0x00000001830B4AD0
		internal double GetDouble(int offset) => default; // 0x0000000189F9CF18-0x0000000189F9CF40
		internal int GetEnum(int offset) => default; // 0x0000000189F9CF40-0x0000000189F9CF68
		internal string GetString(int offset) => default; // 0x0000000189F9D134-0x0000000189F9D23C
		internal Bean? GetBean(int offset, BeanType beanType) => default; // 0x0000000189F9CD9C-0x0000000189F9CEC0
		internal Beyond.SparkBuffer.Runtime.Array? GetArray(int offset, ArrayType arrayType) => default; // 0x0000000189F9CC54-0x0000000189F9CD9C
		internal Beyond.SparkBuffer.Runtime.Map? GetMap(int offset, MapType mapType) => default; // 0x0000000189F9CF90-0x0000000189F9D134
		internal Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(int offset) => default; // 0x000000018275ACF0-0x000000018275AD20
	}

	public static class Error // TypeDefIndex: 57616
	{
		// Methods
		public static Exception TypeNotFoundError(int typeHash, SparkType sparkType) => default; // 0x0000000189F92234-0x0000000189F92300
		public static Exception InvalidTypeError(SparkType sparkType) => default; // 0x0000000189F92090-0x0000000189F92130
		public static Exception InvalidMapKeyError(SparkType sparkType) => default; // 0x0000000189F91FF0-0x0000000189F92090
		public static Exception NullTypeError(SparkType sparkType) => default; // 0x0000000189F92130-0x0000000189F921D0
		public static Exception GetEndOfFile() => default; // 0x0000000189F91F8C-0x0000000189F91FF0
		public static Exception SeekAheadOfFile() => default; // 0x0000000189F921D0-0x0000000189F92234
		public static Exception DisposedException() => default; // 0x0000000189F91F28-0x0000000189F91F8C
	}

	public abstract class SparkManager // TypeDefIndex: 57619
	{
		// Fields
		private readonly Dictionary<int, BeanType> m_beanTypeMap; // 0x10
		private readonly Dictionary<int, EnumType> m_enumTypeMap; // 0x18
		protected readonly Dictionary<string, Root> m_namedRoots; // 0x20
		private readonly List<Root> m_anonymousRoots; // 0x28
		private readonly Queue<BeanType> m_beanTypeQueue; // 0x30
	
		// Nested types
		private class JsonLoader : IDisposable // TypeDefIndex: 57618
		{
			// Fields
			private ByteWriter m_writer; // 0x10
			private Dictionary<string, int> m_stringMap; // 0x18
	
			// Nested types
			private struct ReservedField // TypeDefIndex: 57617
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
			private JsonLoader(ByteWriter writer) {} // 0x0000000189F96D90-0x0000000189F96E18
	
			// Methods
			public void Dispose() {} // 0x00000001835ACAA0-0x00000001835ACAC0
			internal static void PopulateJsonDataWithoutTypeAndRootDef(ByteWriter writer, JToken rootObj, Root.Options rootOptions, out int dataOffset) {
				dataOffset = default;
			} // 0x0000000189F93548-0x0000000189F93684
			private void _LoadJsonContentWithoutTypeAndRootDef(JToken rootObj, Root.Options rootOptions, out int dataOffset) {
				dataOffset = default;
			} // 0x0000000189F96CFC-0x0000000189F96D90
			private void _ExportStrings(JToken rootJson, Root.Options rootOptions) {} // 0x0000000189F965D0-0x0000000189F96ABC
			private void _CollectBeanStrings(HashSet<string> stringSet, JObject obj, BeanType beanType) {} // 0x0000000189F93898-0x0000000189F93D60
			private void _CollectArrayStrings(HashSet<string> stringSet, JArray obj, ArrayType arrayType) {} // 0x0000000189F93684-0x0000000189F93898
			private void _CollectMapStrings(HashSet<string> stringSet, JObject obj, MapType mapType) {} // 0x0000000189F93D60-0x0000000189F93FD4
			private int _ExportRootData(JToken rootJson, Root.Options rootOptions) => default; // 0x0000000189F96224-0x0000000189F964CC
			private int _ExportBeanData(JObject beanObj, BeanType beanType) => default; // 0x0000000189F94834-0x0000000189F95024
			private int _ExportArrayData(JArray arrayObj, ArrayType arrayType) => default; // 0x0000000189F943D4-0x0000000189F94834
			private int _ExportMapData(JObject mapObj, MapType mapType) => default; // 0x0000000189F9545C-0x0000000189F95AA8
			private Dictionary<int, List<KeyValuePair<string, JToken>>> _CreateMapHashEntry(JObject mapObj, SparkType keyType) => default; // 0x0000000189F93FD4-0x0000000189F942E4
			private int _GetMapKeyHash(string key, SparkType keyType) => default; // 0x0000000189F96ABC-0x0000000189F96C5C
			private void _ExportMapKey(string key, SparkType keyType) {} // 0x0000000189F95AA8-0x0000000189F95C78
			private void _ExportMapValue(JToken valueToken, MapType mapType, List<ReservedField> reservedFields) {} // 0x0000000189F95C78-0x0000000189F95E18
			private void _ExportReservedFields(List<ReservedField> reservedFields) {} // 0x0000000189F95E18-0x0000000189F96224
			private void _ExportStringByLoc(string strVal) {} // 0x0000000189F964CC-0x0000000189F965D0
			private void _ExportEnumData(JToken token, EnumType enumType) {} // 0x0000000189F952C8-0x0000000189F9545C
			private void _ExportCommonDataOrThrow(JToken token, SparkType type, List<ReservedField> reservedFields) {} // 0x0000000189F95024-0x0000000189F952C8
			private static void _EnsureJTokenType(JToken token, JTokenType requiredType) {} // 0x0000000189F942E4-0x0000000189F943D4
			private static Exception _InvalidRootTypeError(SparkType rootType) => default; // 0x0000000189F96C5C-0x0000000189F96CFC
		}
	
		// Constructors
		protected SparkManager() {} // 0x0000000183A1EF40-0x0000000183A1F0E0
	
		// Methods
		public Root Load(byte[] bytes, string overrideRootName) => default; // 0x000000018298B310-0x000000018298B4C0
		public Root Load(byte[] bytes) => default; // 0x0000000189F9EB20-0x0000000189F9EB2C
		public Root LoadFromJson_EditorOnly(byte[] bytes, JToken jsonData, string overrideRootName) => default; // 0x0000000189F9E464-0x0000000189F9EB20
		public Root LoadFromJson_EditorOnly(byte[] bytes, JToken jsonData) => default; // 0x0000000189F9E448-0x0000000189F9E464
		public virtual bool Unload(Root root) => default; // 0x0000000189F9ECE8-0x0000000189F9ED78
		public virtual void UnloadAndClearAll() {} // 0x0000000189F9EB2C-0x0000000189F9ECE8
		internal bool TryGetEnumType(int typeHash, out EnumType enumType) {
			enumType = default;
			return default;
		} // 0x000000018298C700-0x000000018298C770
		internal bool TryGetBeanType(int typeHash, out BeanType beanType) {
			beanType = default;
			return default;
		} // 0x000000018298C3E0-0x000000018298C460
		protected virtual bool _AddRoot(Root root) => default; // 0x0000000183267870-0x00000001832678F0
		private void _ReadTypeDefs(ByteReader reader) {} // 0x000000018298C0A0-0x000000018298C2A0
		private Root.Options _ReadRootDef(ByteReader reader, string overrideRootName) => default; // 0x000000018298B4C0-0x000000018298BC60
	}

	public class RuntimeSparkManager : SparkManager // TypeDefIndex: 57621
	{
		// Fields
		private static RuntimeSparkManager s_instance; // 0x00
		private Action<Root> m_onRootLoaded; // 0x38
		private Action<Root> m_onRootUnloaded; // 0x40
		private Action m_onUnloadAll; // 0x48
		private const string LUADLL = "__Internal"; // Metadata: 0x01FDA051
	
		// Properties
		public static RuntimeSparkManager instance { get => default; } // 0x000000018298C7B0-0x000000018298C850 
	
		// Constructors
		private RuntimeSparkManager() {} // 0x0000000189F9D4B0-0x0000000189F9D4B8
	
		// Methods
		public override bool Unload(Root root) => default; // 0x0000000189F9D408-0x0000000189F9D470
		public void ReloadTableToLua(string name) {} // 0x0000000189F9D2F4-0x0000000189F9D3B8
		public override void UnloadAndClearAll() {} // 0x0000000189F9D3B8-0x0000000189F9D408
		private static extern bool LuaSpark_LoadRoot(IntPtr L, string rootName, IntPtr data, int size); // 0x0000000183191C00-0x0000000183191C70
		private static extern bool LuaSpark_UnloadRoot(IntPtr L, string rootName); // 0x0000000189F9D2B4-0x0000000189F9D2F4
		private static extern void LuaSpark_UnloadAll(IntPtr L); // 0x0000000189F9D2AC-0x0000000189F9D2B4
		public void RegisterToLua(IntPtr L) {} // 0x000000018332F450-0x000000018332F850
		public void UnregisterFromLua(IntPtr L) {} // 0x0000000189F9D470-0x0000000189F9D4B0
		protected override bool _AddRoot(Root root) => default; // 0x0000000183267800-0x0000000183267870
	}

	public interface IStringPool // TypeDefIndex: 57622
	{
		// Methods
		int AddString(string str);
		string GetString(int index);
		void Clear();
	}

	internal abstract class Field // TypeDefIndex: 57623
	{
		// Properties
		public string name { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public int offset { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public abstract SparkType type { get; }
	
		// Constructors
		protected Field() {} // Dummy constructor
		protected Field(string fieldName, int fieldOffset) {} // 0x0000000182738A30-0x0000000182738A50
	
		// Methods
		public abstract void Unmarshal(ByteReader reader);
		public abstract void Resolve(SparkManager manager);
	}

	internal class SimpleField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 57624
	{
		// Properties
		public override SparkType type { get; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
	
		// Constructors
		public SimpleField() {} // Dummy constructor
		public SimpleField(SparkType type, string fieldName, int fieldOffset) {} // 0x0000000184271728-0x0000000184271750
	
		// Methods
		public override void Unmarshal(ByteReader reader) {} // 0x000000018350B670-0x000000018350B680
		public override void Resolve(SparkManager manager) {} // 0x000000018350B670-0x000000018350B680
	}

	internal class EnumField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 57625
	{
		// Fields
		private int m_typeHash; // 0x20
		private EnumType m_enumType; // 0x28
	
		// Properties
		public override SparkType type { get => default; } // 0x0000000183D5C620-0x0000000183D5C630 
		public EnumType enumType { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public EnumField() {} // Dummy constructor
		public EnumField(string fieldName, int fieldOffset) {} // 0x0000000182738A30-0x0000000182738A50
	
		// Methods
		public override void Unmarshal(ByteReader reader) {} // 0x000000018298C550-0x000000018298C580
		public override void Resolve(SparkManager manager) {} // 0x000000018298C6C0-0x000000018298C700
	}

	internal class BeanField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 57626
	{
		// Fields
		private int m_typeHash; // 0x20
		private BeanType m_beanType; // 0x28
	
		// Properties
		public override SparkType type { get => default; } // 0x0000000183D5C520-0x0000000183D5C530 
		public BeanType beanType { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public BeanField() {} // Dummy constructor
		public BeanField(string fieldName, int fieldOffset) {} // 0x0000000182738A30-0x0000000182738A50
	
		// Methods
		public override void Unmarshal(ByteReader reader) {} // 0x000000018298C4E0-0x000000018298C510
		public override void Resolve(SparkManager manager) {} // 0x000000018298C510-0x000000018298C550
	}

	internal class ArrayField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 57627
	{
		// Fields
		private ArrayType m_arrayType; // 0x20
		private int m_elementTypeHash; // 0x38
	
		// Properties
		public override SparkType type { get => default; } // 0x0000000183D5C5B0-0x0000000183D5C5C0 
		public ArrayType arrayType { get => default; } // 0x0000000183D50E20-0x0000000183D50E40 
	
		// Constructors
		public ArrayField() {} // Dummy constructor
		public ArrayField(string fieldName, int fieldOffset) {} // 0x0000000182738A30-0x0000000182738A50
	
		// Methods
		public override void Unmarshal(ByteReader reader) {} // 0x000000018298C460-0x000000018298C4E0
		public override void Resolve(SparkManager manager) {} // 0x000000018298C580-0x000000018298C5F0
	}

	internal class MapField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 57628
	{
		// Fields
		private MapType m_mapInfo; // 0x20
		private int m_keyTypeHash; // 0x48
		private int m_valueTypeHash; // 0x4C
	
		// Properties
		public override SparkType type { get => default; } // 0x0000000183D89FD0-0x0000000183D89FE0 
		public MapType mapType { get => default; } // 0x0000000183D581B0-0x0000000183D581D0 
	
		// Constructors
		public MapField() {} // Dummy constructor
		public MapField(string fieldName, int fieldOffset) {} // 0x0000000182738A30-0x0000000182738A50
	
		// Methods
		public override void Unmarshal(ByteReader reader) {} // 0x000000018298C5F0-0x000000018298C660
		public override void Resolve(SparkManager manager) {} // 0x000000018298C660-0x000000018298C6C0
	}

	internal struct ArrayType // TypeDefIndex: 57629
	{
		// Fields
		public SparkType elementType; // 0x00
		public BeanType elementBeanType; // 0x08
		public EnumType elementEnumType; // 0x10
	}

	internal struct MapType // TypeDefIndex: 57630
	{
		// Fields
		public SparkType keyType; // 0x00
		public EnumType keyEnumType; // 0x08
		public SparkType valueType; // 0x10
		public BeanType valueBeanType; // 0x18
		public EnumType valueEnumType; // 0x20
	}

	internal class EnumType // TypeDefIndex: 57632
	{
		// Fields
		private List<EnumItem> m_enums; // 0x10
	
		// Properties
		public int typeHash { get; private set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public string name { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Nested types
		private struct EnumItem // TypeDefIndex: 57631
		{
			// Fields
			public string name; // 0x00
			public int value; // 0x08
		}
	
		// Constructors
		public EnumType() {} // Dummy constructor
		public EnumType(ByteReader reader) {} // 0x00000001827569C0-0x0000000182756DD0
	
		// Methods
		public bool TryGetValue(string enumName, out int enumVal) {
			enumVal = default;
			return default;
		} // 0x0000000189F91E5C-0x0000000189F91F28
	}

	internal class BeanType : IEnumerable<KeyValuePair<string, Beyond.SparkBuffer.Runtime.Field>> // TypeDefIndex: 57633
	{
		// Fields
		private Dictionary<string, Beyond.SparkBuffer.Runtime.Field> m_fields; // 0x10
	
		// Properties
		public int typeHash { get; private set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public string name { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
	
		// Constructors
		public BeanType() {} // Dummy constructor
		public BeanType(ByteReader reader) {} // 0x00000001827566A0-0x00000001827569C0
	
		// Methods
		public override string ToString() => default; // 0x0000000189F90AF8-0x0000000189F90B68
		public void Resolve(SparkManager manager) {} // 0x000000018298C2A0-0x000000018298C3E0
		public bool TryGetField(string fieldName, out Beyond.SparkBuffer.Runtime.Field field) {
			field = default;
			return default;
		} // 0x0000000182329510-0x0000000182329650
		public Dictionary<string, Beyond.SparkBuffer.Runtime.Field> GetEnumerator() => default; // 0x0000000189F909B0-0x0000000189F90A28
		IEnumerator<KeyValuePair<string, Beyond.SparkBuffer.Runtime.Field>> IEnumerable<KeyValuePair<string, Field>>.GetEnumerator() => default; // 0x0000000189F90A28-0x0000000189F90A90
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F90A90-0x0000000189F90AF8
		private Beyond.SparkBuffer.Runtime.Field _NewField(string name, SparkType type, int offset) => default; // 0x0000000182756DD0-0x0000000182756F30
	}
}

namespace Beyond.SparkBuffer.Runtime.Wrapper
{
	public interface IArrayWrapper<T> // TypeDefIndex: 57634
	{
		// Properties
		int length { get; }
		int Count { get; }
		T this[int index] { get => default; }
	}

	public struct ArrayEnumerator<TElement, TArray> : IEnumerator<TElement> // TypeDefIndex: 57635
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

	public struct NullableBeanArray<TBean> : IArrayWrapper<TBean?>, IEnumerable<TBean?> // TypeDefIndex: 57636
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

	public struct BeanArray<TBean> : IArrayWrapper<TBean>, IEnumerable<TBean> // TypeDefIndex: 57637
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

	public struct EnumArray<TEnum> : IArrayWrapper<TEnum>, IEnumerable<TEnum> // TypeDefIndex: 57638
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

	public struct BoolArray : IArrayWrapper<bool>, IEnumerable<bool> // TypeDefIndex: 57639
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int Count { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public bool this[int index] { get => default; } // 0x0000000184273FC8-0x0000000184273FD0 
	
		// Constructors
		public BoolArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x0000000189F911AC-0x0000000189F911D0
	
		// Methods
		public ArrayEnumerator<bool, BoolArray> GetEnumerator() => default; // 0x0000000189F90FD8-0x0000000189F9104C
		public bool[] ToArray() => default; // 0x0000000189F91124-0x0000000189F911AC
		public bool Contains(bool item) => default; // 0x0000000189F90F90-0x0000000189F90FD8
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator() => default; // 0x0000000189F9104C-0x0000000189F910B8
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F910B8-0x0000000189F91124
	}

	public struct ByteArray : IArrayWrapper<byte>, IEnumerable<byte> // TypeDefIndex: 57640
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int Count { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public byte this[int index] { get => default; } // 0x0000000189F913EC-0x0000000189F913F4 
	
		// Constructors
		public ByteArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x0000000189F911AC-0x0000000189F911D0
	
		// Methods
		public ArrayEnumerator<byte, ByteArray> GetEnumerator() => default; // 0x0000000189F91218-0x0000000189F9128C
		public byte[] ToArray() => default; // 0x0000000189F91364-0x0000000189F913EC
		public bool Contains(byte item) => default; // 0x0000000189F911D0-0x0000000189F91218
		IEnumerator<byte> IEnumerable<byte>.GetEnumerator() => default; // 0x0000000189F9128C-0x0000000189F912F8
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F912F8-0x0000000189F91364
	}

	public struct IntArray : IArrayWrapper<int>, IEnumerable<int> // TypeDefIndex: 57641
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int Count { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int this[int index] { get => default; } // 0x0000000184273FF4-0x0000000184273FFC 
	
		// Constructors
		public IntArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x0000000189F911AC-0x0000000189F911D0
	
		// Methods
		public ArrayEnumerator<int, IntArray> GetEnumerator() => default; // 0x000000018377C7C0-0x000000018377C830
		public int[] ToArray() => default; // 0x0000000189F934C0-0x0000000189F93548
		public bool Contains(int item) => default; // 0x0000000189F9340C-0x0000000189F93454
		IEnumerator<int> IEnumerable<int>.GetEnumerator() => default; // 0x000000018377C750-0x000000018377C7C0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F93454-0x0000000189F934C0
	}

	public struct LongArray : IArrayWrapper<long>, IEnumerable<long> // TypeDefIndex: 57642
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int Count { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public long this[int index] { get => default; } // 0x0000000189F989E4-0x0000000189F989EC 
	
		// Constructors
		public LongArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x0000000189F911AC-0x0000000189F911D0
	
		// Methods
		public ArrayEnumerator<long, LongArray> GetEnumerator() => default; // 0x0000000189F9880C-0x0000000189F98880
		public long[] ToArray() => default; // 0x0000000189F98958-0x0000000189F989E4
		public bool Contains(long item) => default; // 0x0000000189F987C4-0x0000000189F9880C
		IEnumerator<long> IEnumerable<long>.GetEnumerator() => default; // 0x0000000189F98880-0x0000000189F988EC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F988EC-0x0000000189F98958
	}

	public struct FloatArray : IArrayWrapper<float>, IEnumerable<float> // TypeDefIndex: 57643
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int Count { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public float this[int index] { get => default; } // 0x0000000184273FC0-0x0000000184273FC8 
	
		// Constructors
		public FloatArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x0000000189F911AC-0x0000000189F911D0
	
		// Methods
		public ArrayEnumerator<float, FloatArray> GetEnumerator() => default; // 0x0000000189F92320-0x0000000189F92394
		public float[] ToArray() => default; // 0x0000000189F9246C-0x0000000189F924F8
		IEnumerator<float> IEnumerable<float>.GetEnumerator() => default; // 0x0000000189F92394-0x0000000189F92400
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F92400-0x0000000189F9246C
	}

	public struct DoubleArray : IArrayWrapper<double>, IEnumerable<double> // TypeDefIndex: 57644
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int Count { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public double this[int index] { get => default; } // 0x00000001842733E0-0x00000001842733E8 
	
		// Constructors
		public DoubleArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x0000000189F911AC-0x0000000189F911D0
	
		// Methods
		public ArrayEnumerator<double, DoubleArray> GetEnumerator() => default; // 0x0000000189F91C84-0x0000000189F91CF8
		public double[] ToArray() => default; // 0x0000000189F91DD0-0x0000000189F91E5C
		IEnumerator<double> IEnumerable<double>.GetEnumerator() => default; // 0x0000000189F91CF8-0x0000000189F91D64
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F91D64-0x0000000189F91DD0
	}

	public struct StringArray : IArrayWrapper<string>, IEnumerable<string> // TypeDefIndex: 57645
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int Count { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public string this[int index] { get => default; } // 0x00000001842719E0-0x00000001842719E8 
	
		// Constructors
		public StringArray(Beyond.SparkBuffer.Runtime.Array array) : this() {
			m_array = default;
		} // 0x0000000189F911AC-0x0000000189F911D0
	
		// Methods
		public ArrayEnumerator<string, StringArray> GetEnumerator() => default; // 0x00000001827CCDD0-0x00000001827CCE40
		public string[] ToArray() => default; // 0x00000001839B86C0-0x00000001839B8750
		public bool Contains(string item) => default; // 0x00000001827D2FF0-0x00000001827D30A0
		IEnumerator<string> IEnumerable<string>.GetEnumerator() => default; // 0x0000000183B38EA0-0x0000000183B38F10
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189FA26C0-0x0000000189FA272C
	}

	public interface IBeanWrapper // TypeDefIndex: 57646
	{
		// Methods
		void SetBean(ref Bean bean);
	}

	public struct HashSlot // TypeDefIndex: 57647
	{
		// Fields
		public int offset; // 0x00
		public int bucketsSize; // 0x04
		public static readonly int size; // 0x00
	
		// Constructors
		static HashSlot() {
			size = default;
		} // 0x0000000183D44520-0x0000000183D44560
	}

	public interface IMapWrapper<TKey, TValue, TMap> // TypeDefIndex: 57648
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

	public struct MapEnumerator<TKey, TValue, TMap> : IEnumerator<KeyValuePair<TKey, TValue>> // TypeDefIndex: 57649
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

	public struct S2NullableBeanMap<TBean> : IMapWrapper<string, TBean?, S2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<string, TBean?>> // TypeDefIndex: 57650
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

	public struct S2BeanMap<TBean> : IMapWrapper<string, TBean, S2BeanMap<TBean>>, IEnumerable<KeyValuePair<string, TBean>> // TypeDefIndex: 57651
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

	public struct S2EnumMap<TEnum> : IMapWrapper<string, TEnum, S2EnumMap<TEnum>>, IEnumerable<KeyValuePair<string, TEnum>> // TypeDefIndex: 57652
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

	public struct S2BoolMap : IMapWrapper<string, bool, S2BoolMap>, IEnumerable<KeyValuePair<string, bool>> // TypeDefIndex: 57653
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public bool this[string key] { get => default; } // 0x0000000189F9D590-0x0000000189F9D5D4 
	
		// Constructors
		public S2BoolMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000187B4F6B8-0x0000000187B4F6FC
		public string GetKeyByIndex(int index) => default; // 0x000000018346C010-0x000000018346C060
		public bool GetValue(string key) => default; // 0x0000000189F9D590-0x0000000189F9D5D4
		public bool TryGetValue(string key, out bool value) {
			value = default;
			return default;
		} // 0x0000000182A53A10-0x0000000182A53A90
		public bool GetValueByIndex(int index) => default; // 0x0000000189F925C8-0x0000000189F9260C
		public MapEnumerator<string, bool, S2BoolMap> GetEnumerator() => default; // 0x0000000189F9D4B8-0x0000000189F9D590
		IEnumerator<KeyValuePair<string, bool>> IEnumerable<KeyValuePair<string, bool>>.GetEnumerator() => default; // 0x0000000189F9D5D4-0x0000000189F9D654
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F9D654-0x0000000189F9D6D4
	}

	public struct S2ByteMap : IMapWrapper<string, byte, S2ByteMap>, IEnumerable<KeyValuePair<string, byte>> // TypeDefIndex: 57654
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public byte this[string key] { get => default; } // 0x0000000189F9D7AC-0x0000000189F9D7F0 
	
		// Constructors
		public S2ByteMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000187B4F6B8-0x0000000187B4F6FC
		public string GetKeyByIndex(int index) => default; // 0x000000018346C010-0x000000018346C060
		public byte GetValue(string key) => default; // 0x0000000189F9D7AC-0x0000000189F9D7F0
		public bool TryGetValue(string key, out byte value) {
			value = default;
			return default;
		} // 0x0000000189F9D8F0-0x0000000189F9D934
		public byte GetValueByIndex(int index) => default; // 0x0000000189F92864-0x0000000189F928A8
		public MapEnumerator<string, byte, S2ByteMap> GetEnumerator() => default; // 0x0000000189F9D6D4-0x0000000189F9D7AC
		IEnumerator<KeyValuePair<string, byte>> IEnumerable<KeyValuePair<string, byte>>.GetEnumerator() => default; // 0x0000000189F9D7F0-0x0000000189F9D870
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F9D870-0x0000000189F9D8F0
	}

	public struct S2IntMap : IMapWrapper<string, int, S2IntMap>, IEnumerable<KeyValuePair<string, int>> // TypeDefIndex: 57655
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int this[string key] { get => default; } // 0x0000000182755E90-0x0000000182755F50 
	
		// Constructors
		public S2IntMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x00000001827541A0-0x00000001827541F0
		public string GetKeyByIndex(int index) => default; // 0x000000018346C010-0x000000018346C060
		public int GetValue(string key) => default; // 0x0000000182D33A20-0x0000000182D33AE0
		public bool TryGetValue(string key, out int value) {
			value = default;
			return default;
		} // 0x00000001823C8160-0x00000001823C81F0
		public int GetValueByIndex(int index) => default; // 0x0000000189F92EA4-0x0000000189F92EE8
		public MapEnumerator<string, int, S2IntMap> GetEnumerator() => default; // 0x0000000189F9DDF4-0x0000000189F9DECC
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator() => default; // 0x0000000189F9DECC-0x0000000189F9DF4C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F9DF4C-0x0000000189F9DFCC
	}

	public struct S2LongMap : IMapWrapper<string, long, S2LongMap>, IEnumerable<KeyValuePair<string, long>> // TypeDefIndex: 57656
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public long this[string key] { get => default; } // 0x0000000189F9E0A4-0x0000000189F9E0E8 
	
		// Constructors
		public S2LongMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000187B4F6B8-0x0000000187B4F6FC
		public string GetKeyByIndex(int index) => default; // 0x000000018346C010-0x000000018346C060
		public long GetValue(string key) => default; // 0x0000000189F9E0A4-0x0000000189F9E0E8
		public bool TryGetValue(string key, out long value) {
			value = default;
			return default;
		} // 0x0000000189F9E1E8-0x0000000189F9E22C
		public long GetValueByIndex(int index) => default; // 0x0000000189F93140-0x0000000189F93184
		public MapEnumerator<string, long, S2LongMap> GetEnumerator() => default; // 0x0000000189F9DFCC-0x0000000189F9E0A4
		IEnumerator<KeyValuePair<string, long>> IEnumerable<KeyValuePair<string, long>>.GetEnumerator() => default; // 0x0000000189F9E0E8-0x0000000189F9E168
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F9E168-0x0000000189F9E1E8
	}

	public struct S2FloatMap : IMapWrapper<string, float, S2FloatMap>, IEnumerable<KeyValuePair<string, float>> // TypeDefIndex: 57657
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public float this[string key] { get => default; } // 0x0000000189F9DC6C-0x0000000189F9DCB0 
	
		// Constructors
		public S2FloatMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000187B4F6B8-0x0000000187B4F6FC
		public string GetKeyByIndex(int index) => default; // 0x000000018346C010-0x000000018346C060
		public float GetValue(string key) => default; // 0x0000000189F9DC6C-0x0000000189F9DCB0
		public bool TryGetValue(string key, out float value) {
			value = default;
			return default;
		} // 0x0000000189F9DDB0-0x0000000189F9DDF4
		public float GetValueByIndex(int index) => default; // 0x0000000189F97F70-0x0000000189F97FB4
		public MapEnumerator<string, float, S2FloatMap> GetEnumerator() => default; // 0x0000000189F9DB94-0x0000000189F9DC6C
		IEnumerator<KeyValuePair<string, float>> IEnumerable<KeyValuePair<string, float>>.GetEnumerator() => default; // 0x0000000189F9DCB0-0x0000000189F9DD30
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F9DD30-0x0000000189F9DDB0
	}

	public struct S2DoubleMap : IMapWrapper<string, double, S2DoubleMap>, IEnumerable<KeyValuePair<string, double>> // TypeDefIndex: 57658
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public double this[string key] { get => default; } // 0x0000000189F9DA0C-0x0000000189F9DA50 
	
		// Constructors
		public S2DoubleMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000187B4F6B8-0x0000000187B4F6FC
		public string GetKeyByIndex(int index) => default; // 0x000000018346C010-0x000000018346C060
		public double GetValue(string key) => default; // 0x0000000189F9DA0C-0x0000000189F9DA50
		public bool TryGetValue(string key, out double value) {
			value = default;
			return default;
		} // 0x0000000189F9DB50-0x0000000189F9DB94
		public double GetValueByIndex(int index) => default; // 0x0000000189F92B00-0x0000000189F92B44
		public MapEnumerator<string, double, S2DoubleMap> GetEnumerator() => default; // 0x0000000189F9D934-0x0000000189F9DA0C
		IEnumerator<KeyValuePair<string, double>> IEnumerable<KeyValuePair<string, double>>.GetEnumerator() => default; // 0x0000000189F9DA50-0x0000000189F9DAD0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F9DAD0-0x0000000189F9DB50
	}

	public struct S2StringMap : IMapWrapper<string, string, S2StringMap>, IEnumerable<KeyValuePair<string, string>> // TypeDefIndex: 57659
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public string this[string key] { get => default; } // 0x0000000189F9E304-0x0000000189F9E348 
	
		// Constructors
		public S2StringMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(string key) => default; // 0x0000000187B4F6B8-0x0000000187B4F6FC
		public string GetKeyByIndex(int index) => default; // 0x000000018346C010-0x000000018346C060
		public string GetValue(string key) => default; // 0x0000000189F9E304-0x0000000189F9E348
		public bool TryGetValue(string key, out string value) {
			value = default;
			return default;
		} // 0x0000000183496030-0x00000001834960D0
		public string GetValueByIndex(int index) => default; // 0x0000000189F9863C-0x0000000189F98680
		public MapEnumerator<string, string, S2StringMap> GetEnumerator() => default; // 0x0000000189F9E22C-0x0000000189F9E304
		IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator() => default; // 0x0000000189F9E348-0x0000000189F9E3C8
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F9E3C8-0x0000000189F9E448
	}

	public struct I2NullableBeanMap<TBean> : IMapWrapper<int, TBean?, I2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<int, TBean?>> // TypeDefIndex: 57660
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

	public struct I2BeanMap<TBean> : IMapWrapper<int, TBean, I2BeanMap<TBean>>, IEnumerable<KeyValuePair<int, TBean>> // TypeDefIndex: 57661
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

	public struct I2EnumMap<TEnum> : IMapWrapper<int, TEnum, I2EnumMap<TEnum>>, IEnumerable<KeyValuePair<int, TEnum>> // TypeDefIndex: 57662
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

	public struct I2BoolMap : IMapWrapper<int, bool, I2BoolMap>, IEnumerable<KeyValuePair<int, bool>> // TypeDefIndex: 57663
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public bool this[int key] { get => default; } // 0x0000000189F9260C-0x0000000189F92650 
	
		// Constructors
		public I2BoolMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x000000018706BA28-0x000000018706BA6C
		public int GetKeyByIndex(int index) => default; // 0x00000001830B48F0-0x00000001830B4940
		public bool GetValue(int key) => default; // 0x0000000189F9260C-0x0000000189F92650
		public bool TryGetValue(int key, out bool value) {
			value = default;
			return default;
		} // 0x0000000189F92750-0x0000000189F92794
		public bool GetValueByIndex(int index) => default; // 0x0000000189F925C8-0x0000000189F9260C
		public MapEnumerator<int, bool, I2BoolMap> GetEnumerator() => default; // 0x0000000189F924F8-0x0000000189F925C8
		IEnumerator<KeyValuePair<int, bool>> IEnumerable<KeyValuePair<int, bool>>.GetEnumerator() => default; // 0x0000000189F92650-0x0000000189F926D0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F926D0-0x0000000189F92750
	}

	public struct I2ByteMap : IMapWrapper<int, byte, I2ByteMap>, IEnumerable<KeyValuePair<int, byte>> // TypeDefIndex: 57664
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public byte this[int key] { get => default; } // 0x0000000189F928A8-0x0000000189F928EC 
	
		// Constructors
		public I2ByteMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x000000018706BA28-0x000000018706BA6C
		public int GetKeyByIndex(int index) => default; // 0x00000001830B48F0-0x00000001830B4940
		public byte GetValue(int key) => default; // 0x0000000189F928A8-0x0000000189F928EC
		public bool TryGetValue(int key, out byte value) {
			value = default;
			return default;
		} // 0x0000000189F929EC-0x0000000189F92A30
		public byte GetValueByIndex(int index) => default; // 0x0000000189F92864-0x0000000189F928A8
		public MapEnumerator<int, byte, I2ByteMap> GetEnumerator() => default; // 0x0000000189F92794-0x0000000189F92864
		IEnumerator<KeyValuePair<int, byte>> IEnumerable<KeyValuePair<int, byte>>.GetEnumerator() => default; // 0x0000000189F928EC-0x0000000189F9296C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F9296C-0x0000000189F929EC
	}

	public struct I2IntMap : IMapWrapper<int, int, I2IntMap>, IEnumerable<KeyValuePair<int, int>> // TypeDefIndex: 57665
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int this[int key] { get => default; } // 0x0000000189F92EE8-0x0000000189F92F2C 
	
		// Constructors
		public I2IntMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x000000018706BA28-0x000000018706BA6C
		public int GetKeyByIndex(int index) => default; // 0x00000001830B48F0-0x00000001830B4940
		public int GetValue(int key) => default; // 0x0000000189F92EE8-0x0000000189F92F2C
		public bool TryGetValue(int key, out int value) {
			value = default;
			return default;
		} // 0x0000000189F9302C-0x0000000189F93070
		public int GetValueByIndex(int index) => default; // 0x0000000189F92EA4-0x0000000189F92EE8
		public MapEnumerator<int, int, I2IntMap> GetEnumerator() => default; // 0x0000000189F92DD4-0x0000000189F92EA4
		IEnumerator<KeyValuePair<int, int>> IEnumerable<KeyValuePair<int, int>>.GetEnumerator() => default; // 0x0000000189F92F2C-0x0000000189F92FAC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F92FAC-0x0000000189F9302C
	}

	public struct I2LongMap : IMapWrapper<int, long, I2LongMap>, IEnumerable<KeyValuePair<int, long>> // TypeDefIndex: 57666
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public long this[int key] { get => default; } // 0x0000000189F93184-0x0000000189F931C8 
	
		// Constructors
		public I2LongMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x000000018706BA28-0x000000018706BA6C
		public int GetKeyByIndex(int index) => default; // 0x00000001830B48F0-0x00000001830B4940
		public long GetValue(int key) => default; // 0x0000000189F93184-0x0000000189F931C8
		public bool TryGetValue(int key, out long value) {
			value = default;
			return default;
		} // 0x0000000189F932C8-0x0000000189F9330C
		public long GetValueByIndex(int index) => default; // 0x0000000189F93140-0x0000000189F93184
		public MapEnumerator<int, long, I2LongMap> GetEnumerator() => default; // 0x0000000189F93070-0x0000000189F93140
		IEnumerator<KeyValuePair<int, long>> IEnumerable<KeyValuePair<int, long>>.GetEnumerator() => default; // 0x0000000189F931C8-0x0000000189F93248
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F93248-0x0000000189F932C8
	}

	public struct I2FloatMap : IMapWrapper<int, float, I2FloatMap>, IEnumerable<KeyValuePair<int, float>> // TypeDefIndex: 57667
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public float this[int key] { get => default; } // 0x0000000189F92CCC-0x0000000189F92D10 
	
		// Constructors
		public I2FloatMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x000000018706BA28-0x000000018706BA6C
		public int GetKeyByIndex(int index) => default; // 0x00000001830B48F0-0x00000001830B4940
		public float GetValue(int key) => default; // 0x0000000189F92CCC-0x0000000189F92D10
		public bool TryGetValue(int key, out float value) {
			value = default;
			return default;
		} // 0x0000000189F92D90-0x0000000189F92DD4
		public float GetValueByIndex(int index) => default; // 0x00000001830B4940-0x00000001830B49B0
		public MapEnumerator<int, float, I2FloatMap> GetEnumerator() => default; // 0x0000000183CF02F0-0x0000000183CF0370
		IEnumerator<KeyValuePair<int, float>> IEnumerable<KeyValuePair<int, float>>.GetEnumerator() => default; // 0x0000000183CF0270-0x0000000183CF02F0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F92D10-0x0000000189F92D90
	}

	public struct I2DoubleMap : IMapWrapper<int, double, I2DoubleMap>, IEnumerable<KeyValuePair<int, double>> // TypeDefIndex: 57668
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public double this[int key] { get => default; } // 0x0000000189F92B44-0x0000000189F92B88 
	
		// Constructors
		public I2DoubleMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x000000018706BA28-0x000000018706BA6C
		public int GetKeyByIndex(int index) => default; // 0x00000001830B48F0-0x00000001830B4940
		public double GetValue(int key) => default; // 0x0000000189F92B44-0x0000000189F92B88
		public bool TryGetValue(int key, out double value) {
			value = default;
			return default;
		} // 0x0000000189F92C88-0x0000000189F92CCC
		public double GetValueByIndex(int index) => default; // 0x0000000189F92B00-0x0000000189F92B44
		public MapEnumerator<int, double, I2DoubleMap> GetEnumerator() => default; // 0x0000000189F92A30-0x0000000189F92B00
		IEnumerator<KeyValuePair<int, double>> IEnumerable<KeyValuePair<int, double>>.GetEnumerator() => default; // 0x0000000189F92B88-0x0000000189F92C08
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F92C08-0x0000000189F92C88
	}

	public struct I2StringMap : IMapWrapper<int, string, I2StringMap>, IEnumerable<KeyValuePair<int, string>> // TypeDefIndex: 57669
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public string this[int key] { get => default; } // 0x000000018275A1D0-0x000000018275A220 
	
		// Constructors
		public I2StringMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(int key) => default; // 0x0000000182758A20-0x0000000182758A70
		public int GetKeyByIndex(int index) => default; // 0x00000001830B48F0-0x00000001830B4940
		public string GetValue(int key) => default; // 0x000000018275A1D0-0x000000018275A220
		public bool TryGetValue(int key, out string value) {
			value = default;
			return default;
		} // 0x0000000182CF1C30-0x0000000182CF1CD0
		public string GetValueByIndex(int index) => default; // 0x0000000183495600-0x0000000183495670
		public MapEnumerator<int, string, I2StringMap> GetEnumerator() => default; // 0x00000001830A3CB0-0x00000001830A3D30
		IEnumerator<KeyValuePair<int, string>> IEnumerable<KeyValuePair<int, string>>.GetEnumerator() => default; // 0x0000000189F9330C-0x0000000189F9338C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F9338C-0x0000000189F9340C
	}

	public struct L2BoolMap : IMapWrapper<long, bool, L2BoolMap>, IEnumerable<KeyValuePair<long, bool>> // TypeDefIndex: 57670
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public bool this[long key] { get => default; } // 0x0000000189F97610-0x0000000189F97654 
	
		// Constructors
		public L2BoolMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x00000001871B8AA0-0x00000001871B8AE4
		public long GetKeyByIndex(int index) => default; // 0x00000001871B8AE4-0x00000001871B8B28
		public bool GetValue(long key) => default; // 0x0000000189F97610-0x0000000189F97654
		public bool TryGetValue(long key, out bool value) {
			value = default;
			return default;
		} // 0x0000000189F97754-0x0000000189F97798
		public bool GetValueByIndex(int index) => default; // 0x0000000189F925C8-0x0000000189F9260C
		public MapEnumerator<long, bool, L2BoolMap> GetEnumerator() => default; // 0x0000000189F97540-0x0000000189F97610
		IEnumerator<KeyValuePair<long, bool>> IEnumerable<KeyValuePair<long, bool>>.GetEnumerator() => default; // 0x0000000189F97654-0x0000000189F976D4
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F976D4-0x0000000189F97754
	}

	public struct L2ByteMap : IMapWrapper<long, byte, L2ByteMap>, IEnumerable<KeyValuePair<long, byte>> // TypeDefIndex: 57671
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public byte this[long key] { get => default; } // 0x0000000189F97868-0x0000000189F978AC 
	
		// Constructors
		public L2ByteMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x00000001871B8AA0-0x00000001871B8AE4
		public long GetKeyByIndex(int index) => default; // 0x00000001871B8AE4-0x00000001871B8B28
		public byte GetValue(long key) => default; // 0x0000000189F97868-0x0000000189F978AC
		public bool TryGetValue(long key, out byte value) {
			value = default;
			return default;
		} // 0x0000000189F979AC-0x0000000189F979F0
		public byte GetValueByIndex(int index) => default; // 0x0000000189F92864-0x0000000189F928A8
		public MapEnumerator<long, byte, L2ByteMap> GetEnumerator() => default; // 0x0000000189F97798-0x0000000189F97868
		IEnumerator<KeyValuePair<long, byte>> IEnumerable<KeyValuePair<long, byte>>.GetEnumerator() => default; // 0x0000000189F978AC-0x0000000189F9792C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F9792C-0x0000000189F979AC
	}

	public struct L2IntMap : IMapWrapper<long, int, L2IntMap>, IEnumerable<KeyValuePair<long, int>> // TypeDefIndex: 57672
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int this[long key] { get => default; } // 0x0000000189F97D18-0x0000000189F97D5C 
	
		// Constructors
		public L2IntMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x00000001871B8AA0-0x00000001871B8AE4
		public long GetKeyByIndex(int index) => default; // 0x00000001871B8AE4-0x00000001871B8B28
		public int GetValue(long key) => default; // 0x0000000189F97D18-0x0000000189F97D5C
		public bool TryGetValue(long key, out int value) {
			value = default;
			return default;
		} // 0x0000000189F97E5C-0x0000000189F97EA0
		public int GetValueByIndex(int index) => default; // 0x0000000189F92EA4-0x0000000189F92EE8
		public MapEnumerator<long, int, L2IntMap> GetEnumerator() => default; // 0x0000000189F9813C-0x0000000189F9820C
		IEnumerator<KeyValuePair<long, int>> IEnumerable<KeyValuePair<long, int>>.GetEnumerator() => default; // 0x0000000189F9820C-0x0000000189F9828C
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F9828C-0x0000000189F9830C
	}

	public struct L2LongMap : IMapWrapper<long, long, L2LongMap>, IEnumerable<KeyValuePair<long, long>> // TypeDefIndex: 57673
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public long this[long key] { get => default; } // 0x0000000189F983DC-0x0000000189F98420 
	
		// Constructors
		public L2LongMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x00000001871B8AA0-0x00000001871B8AE4
		public long GetKeyByIndex(int index) => default; // 0x00000001871B8AE4-0x00000001871B8B28
		public long GetValue(long key) => default; // 0x0000000189F983DC-0x0000000189F98420
		public bool TryGetValue(long key, out long value) {
			value = default;
			return default;
		} // 0x0000000189F98520-0x0000000189F98564
		public long GetValueByIndex(int index) => default; // 0x0000000189F93140-0x0000000189F93184
		public MapEnumerator<long, long, L2LongMap> GetEnumerator() => default; // 0x0000000189F9830C-0x0000000189F983DC
		IEnumerator<KeyValuePair<long, long>> IEnumerable<KeyValuePair<long, long>>.GetEnumerator() => default; // 0x0000000189F98420-0x0000000189F984A0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F984A0-0x0000000189F98520
	}

	public struct L2FloatMap : IMapWrapper<long, float, L2FloatMap>, IEnumerable<KeyValuePair<long, float>> // TypeDefIndex: 57674
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public float this[long key] { get => default; } // 0x0000000189F97FB4-0x0000000189F97FF8 
	
		// Constructors
		public L2FloatMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x00000001871B8AA0-0x00000001871B8AE4
		public long GetKeyByIndex(int index) => default; // 0x00000001871B8AE4-0x00000001871B8B28
		public float GetValue(long key) => default; // 0x0000000189F97FB4-0x0000000189F97FF8
		public bool TryGetValue(long key, out float value) {
			value = default;
			return default;
		} // 0x0000000189F980F8-0x0000000189F9813C
		public float GetValueByIndex(int index) => default; // 0x0000000189F97F70-0x0000000189F97FB4
		public MapEnumerator<long, float, L2FloatMap> GetEnumerator() => default; // 0x0000000189F97EA0-0x0000000189F97F70
		IEnumerator<KeyValuePair<long, float>> IEnumerable<KeyValuePair<long, float>>.GetEnumerator() => default; // 0x0000000189F97FF8-0x0000000189F98078
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F98078-0x0000000189F980F8
	}

	public struct L2DoubleMap : IMapWrapper<long, double, L2DoubleMap>, IEnumerable<KeyValuePair<long, double>> // TypeDefIndex: 57675
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public double this[long key] { get => default; } // 0x0000000189F97AC0-0x0000000189F97B04 
	
		// Constructors
		public L2DoubleMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x00000001871B8AA0-0x00000001871B8AE4
		public long GetKeyByIndex(int index) => default; // 0x00000001871B8AE4-0x00000001871B8B28
		public double GetValue(long key) => default; // 0x0000000189F97AC0-0x0000000189F97B04
		public bool TryGetValue(long key, out double value) {
			value = default;
			return default;
		} // 0x0000000189F97C04-0x0000000189F97C48
		public double GetValueByIndex(int index) => default; // 0x0000000189F92B00-0x0000000189F92B44
		public MapEnumerator<long, double, L2DoubleMap> GetEnumerator() => default; // 0x0000000189F979F0-0x0000000189F97AC0
		IEnumerator<KeyValuePair<long, double>> IEnumerable<KeyValuePair<long, double>>.GetEnumerator() => default; // 0x0000000189F97B04-0x0000000189F97B84
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F97B84-0x0000000189F97C04
	}

	public struct L2StringMap : IMapWrapper<long, string, L2StringMap>, IEnumerable<KeyValuePair<long, string>> // TypeDefIndex: 57676
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public string this[long key] { get => default; } // 0x0000000189F98680-0x0000000189F986C4 
	
		// Constructors
		public L2StringMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x00000001871B8AA0-0x00000001871B8AE4
		public long GetKeyByIndex(int index) => default; // 0x00000001871B8AE4-0x00000001871B8B28
		public string GetValue(long key) => default; // 0x0000000189F98680-0x0000000189F986C4
		public bool TryGetValue(long key, out string value) {
			value = default;
			return default;
		} // 0x0000000182C5A570-0x0000000182C5A610
		public string GetValueByIndex(int index) => default; // 0x0000000189F9863C-0x0000000189F98680
		public MapEnumerator<long, string, L2StringMap> GetEnumerator() => default; // 0x0000000189F98564-0x0000000189F9863C
		IEnumerator<KeyValuePair<long, string>> IEnumerable<KeyValuePair<long, string>>.GetEnumerator() => default; // 0x0000000189F986C4-0x0000000189F98744
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F98744-0x0000000189F987C4
	}

	public struct L2EnumMap : IMapWrapper<long, int, L2EnumMap>, IEnumerable<KeyValuePair<long, int>> // TypeDefIndex: 57677
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int Count { get => default; } // 0x0000000183D67110-0x0000000183D67130 
		public int this[long key] { get => default; } // 0x0000000189F97D18-0x0000000189F97D5C 
	
		// Constructors
		public L2EnumMap(Beyond.SparkBuffer.Runtime.Map map) : this() {
			m_map = default;
		} // 0x000000018885EB78-0x000000018885EBAC
	
		// Methods
		public bool ContainsKey(long key) => default; // 0x00000001871B8AA0-0x00000001871B8AE4
		public long GetKeyByIndex(int index) => default; // 0x00000001871B8AE4-0x00000001871B8B28
		public int GetValue(long key) => default; // 0x0000000189F97D18-0x0000000189F97D5C
		public bool TryGetValue(long key, out int value) {
			value = default;
			return default;
		} // 0x0000000189F97E5C-0x0000000189F97EA0
		public int GetValueByIndex(int index) => default; // 0x0000000189F92EA4-0x0000000189F92EE8
		public MapEnumerator<long, int, L2EnumMap> GetEnumerator() => default; // 0x0000000189F97C48-0x0000000189F97D18
		IEnumerator<KeyValuePair<long, int>> IEnumerable<KeyValuePair<long, int>>.GetEnumerator() => default; // 0x0000000189F97D5C-0x0000000189F97DDC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F97DDC-0x0000000189F97E5C
	}

	public struct L2NullableBeanMap<TBean> : IMapWrapper<long, TBean?, L2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<long, TBean?>> // TypeDefIndex: 57678
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

	public struct L2BeanMap<TBean> : IMapWrapper<long, TBean, L2BeanMap<TBean>>, IEnumerable<KeyValuePair<long, TBean>> // TypeDefIndex: 57679
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
	internal static class Extensions // TypeDefIndex: 57680
	{
		// Extension methods
		public static bool Contains<T>(this IList<T> list, T element) => default;
		public static bool IsNullOrEmpty<T>(this IList<T> list) => default;
		public static bool IsNullOrEmpty<T>(this ICollection<T> list) => default;
		public static bool IsNullOrEmpty(this OrderedDictionary dict) => default; // 0x0000000189F92300-0x0000000189F92320
		public static T[] ToArrayE<T>(this IEnumerable<T> enumerable) => default;
		public static T GetValue<T>(this DictionaryEntry entry)
			where T : class => default;
	}

	public class JsonSerializer // TypeDefIndex: 57681
	{
		// Constructors
		public JsonSerializer() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static JsonSerializerSettings _GenerateJsonSettings(bool indented) => default; // 0x0000000189F97480-0x0000000189F97540
		public static string Serialize<T>(T obj, bool indented) => default;
		public static string Serialize(object obj, bool indented) => default; // 0x0000000189F96E18-0x0000000189F96E94
		private static object _ConstructFromReflectObj(ObjectReflector.ReflectObject reflectObj) => default; // 0x0000000189F96E94-0x0000000189F97480
	}

	internal class ObjectReflector // TypeDefIndex: 57687
	{
		// Fields
		private List<object> m_tempList; // 0x10
		private Dictionary<System.Type, ReflectType> m_typeMap; // 0x18
	
		// Nested types
		public struct ReflectResult // TypeDefIndex: 57682
		{
			// Fields
			public ReflectType[] types; // 0x00
			public ReflectObject rootObj; // 0x08
		}
	
		public class ReflectType // TypeDefIndex: 57684
		{
			// Fields
			public SparkType sparkType; // 0x10
			public System.Type concreteType; // 0x18
			public ReflectType subType1; // 0x20
			public ReflectType subType2; // 0x28
			public List<FieldInfo> beanFields; // 0x30
	
			// Nested types
			public struct FieldInfo // TypeDefIndex: 57683
			{
				// Fields
				public string name; // 0x00
				public ReflectType type; // 0x08
			}
	
			// Constructors
			public ReflectType() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class ReflectObject // TypeDefIndex: 57685
		{
			// Fields
			public object originObj; // 0x10
			public ReflectType reflectType; // 0x18
			public OrderedDictionary beanElements; // 0x20
			public List<ReflectObject> arrayElements; // 0x28
			public List<KeyValuePair<ReflectObject, ReflectObject>> mapElements; // 0x30
	
			// Constructors
			public ReflectObject() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		private ObjectReflector() {} // 0x0000000189F9C710-0x0000000189F9C7D0
	
		// Methods
		public static ReflectResult Parse(object obj) => default; // 0x0000000189F9A08C-0x0000000189F9A110
		private ReflectResult _ParseInternal(object obj) => default; // 0x0000000189F9A404-0x0000000189F9A710
		private ReflectType _ParseTypeMap(System.Type rootType) => default; // 0x0000000189F9A710-0x0000000189F9A7E8
		private bool _TryParseType(System.Type type, out ReflectType reflectType) {
			reflectType = default;
			return default;
		} // 0x0000000189F9B768-0x0000000189F9C710
		private ReflectObject _ReflectObject(object obj, ReflectType reflectType) => default; // 0x0000000189F9B5D8-0x0000000189F9B768
		private ReflectObject _ReflectBean(object obj, ReflectType reflectType) => default; // 0x0000000189F9AD48-0x0000000189F9B284
		private ReflectObject _ReflectArray(object obj, ReflectType reflectType) => default; // 0x0000000189F9A7E8-0x0000000189F9AD48
		private ReflectObject _ReflectMap(object obj, ReflectType reflectType) => default; // 0x0000000189F9B284-0x0000000189F9B5D8
		private IEnumerable<System.Reflection.FieldInfo> _GetFields(System.Type type) => default; // 0x0000000189F9A2E0-0x0000000189F9A404
		private object[] _ConvertICollectionToArray(ICollection collection) => default; // 0x0000000189F9A110-0x0000000189F9A2E0
	}

	public class SparkSerializer : IDisposable // TypeDefIndex: 57692
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
		private struct ReservedField // TypeDefIndex: 57688
		{
			// Fields
			public int position; // 0x00
			public ObjectReflector.ReflectObject reflectObj; // 0x08
		}
	
		public struct Options // TypeDefIndex: 57689
		{
			// Fields
			public static readonly Options DEFAULT; // 0x00
			public string rootName; // 0x00
			public string stripTypeNamePrefix; // 0x08
	
			// Constructors
			public Options(string rootName) {
				this.rootName = default;
				stripTypeNamePrefix = default;
			} // 0x0000000182DFD450-0x0000000182DFD4E0
			public Options(string rootName, string stripTypeNamePrefix) {
				this.rootName = default;
				this.stripTypeNamePrefix = default;
			} // 0x00000001832C7BF0-0x00000001832C7C20
			static Options() {
				DEFAULT = default;
			} // 0x0000000189FA391C-0x0000000189FA39B0
		}
	
		private struct HashSlot // TypeDefIndex: 57690
		{
			// Fields
			public int offset; // 0x00
			public int bucketsSize; // 0x04
		}
	
		// Constructors
		public SparkSerializer() {} // Dummy constructor
		private SparkSerializer(Options options) {} // 0x0000000189FA24CC-0x0000000189FA26C0
	
		// Methods
		public static byte[] Serialize<T>(T obj) => default;
		public static byte[] Serialize<T>(T obj, Options options) => default;
		public static byte[] Serialize(object obj) => default; // 0x0000000189F9EDC4-0x0000000189F9EE24
		public static byte[] Serialize(object obj, Options options) => default; // 0x0000000189F9EE24-0x0000000189F9EF38
		public void Dispose() {} // 0x0000000189F9ED78-0x0000000189F9ED98
		private byte[] _SerializeInternal(object obj) => default; // 0x0000000189FA2280-0x0000000189FA23F0
		private void _PreprocessTypes(ObjectReflector.ReflectType[] reflectTypes) {} // 0x0000000189FA2074-0x0000000189FA2280
		private void _ExportTypeDefs() {} // 0x0000000189FA1A2C-0x0000000189FA1D94
		private void _ExportEnumType(ObjectReflector.ReflectType enumType) {} // 0x0000000189FA08C0-0x0000000189FA0D14
		private void _ExportBeanType(ObjectReflector.ReflectType beanType) {} // 0x0000000189FA00B8-0x0000000189FA03F4
		private string _ParseTypeName(System.Type reflectType) => default; // 0x0000000189FA2008-0x0000000189FA2074
		private static HashSet<string> _CollectAllStrings(ObjectReflector.ReflectObject rootObj) => default; // 0x0000000189F9EFC4-0x0000000189F9F67C
		private List<List<string>> _GenStringHashList(HashSet<string> strings) => default; // 0x0000000189FA1D94-0x0000000189FA2008
		private void _ExportStrings(ObjectReflector.ReflectObject rootObj) {} // 0x0000000189FA1794-0x0000000189FA1A2C
		private void _ExportElementData(ObjectReflector.ReflectObject elementObj, List<ReservedField> reservedFields) {} // 0x0000000189FA04E8-0x0000000189FA08C0
		private int _ExportBeanData(ObjectReflector.ReflectObject beanObj) => default; // 0x0000000189F9FCDC-0x0000000189FA00B8
		private int _ExportArrayData(ObjectReflector.ReflectObject arrayObj) => default; // 0x0000000189F9FA88-0x0000000189F9FCDC
		private int _ExportMapData(ObjectReflector.ReflectObject mapObj) => default; // 0x0000000189FA0D14-0x0000000189FA1348
		private Dictionary<int, List<KeyValuePair<ObjectReflector.ReflectObject, ObjectReflector.ReflectObject>>> _CreateMapHashEntry(List<KeyValuePair<ObjectReflector.ReflectObject, ObjectReflector.ReflectObject>> mapElements, SparkType keyType) => default; // 0x0000000189F9F67C-0x0000000189F9FA88
		private void _ExportRootDef(ObjectReflector.ReflectType rootType) {} // 0x0000000189FA15B4-0x0000000189FA1794
		private int _ExportDataFromRoot(ObjectReflector.ReflectObject rootObj) => default; // 0x0000000189FA03F4-0x0000000189FA04E8
		private void _ExportReservedFields(List<ReservedField> reservedFields) {} // 0x0000000189FA1348-0x0000000189FA15B4
		public static int GetStableStringHash(string str) => default; // 0x000000018236BF20-0x000000018236BFD0
		public static int GetStableTypeHash(System.Type type) => default; // 0x0000000189F9ED98-0x0000000189F9EDC4
		private void _WriteConcreteType(System.Type type) {} // 0x0000000189FA23F0-0x0000000189FA24CC
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 57698
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05950-0x0000000183D059C0
	
		// Methods
		public IntPtr __Gen_Wrap_0(object P0) => default; // 0x00000001855871C0-0x000000018558727C
		public ReadOnlySpan<byte> __Gen_Wrap_1(IntPtr P0, int P1) => default; // 0x0000000189FA31D4-0x0000000189FA32E8
		public IntPtr __Gen_Wrap_2(int P0) => default; // 0x000000018514CEAC-0x000000018514CF64
		public void __Gen_Wrap_3(int P0, IntPtr P1) {} // 0x0000000189FA32E8-0x0000000189FA33B0
		public void __Gen_Wrap_4() {} // 0x00000001851624BC-0x0000000185162544
		public string __Gen_Wrap_5() => default; // 0x0000000189FA33B0-0x0000000189FA3468
		public void __Gen_Wrap_6(object P0, IntPtr P1) {} // 0x0000000185606C1C-0x0000000185606CE4
		public StructPtrWrapper __Gen_Wrap_7(IntPtr P0, int P1, object P2) => default; // 0x0000000189FA3468-0x0000000189FA357C
		public StructPtrWrapper __Gen_Wrap_8(object P0) => default; // 0x0000000189FA357C-0x0000000189FA3658
		public void __Gen_Wrap_9(object P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public object __Gen_Wrap_10(object P0) => default; // 0x0000000189FA2D74-0x0000000189FA2E50
		public object __Gen_Wrap_11(IntPtr P0, object P1, int P2) => default; // 0x0000000189FA2E50-0x0000000189FA2F64
		public void __Gen_Wrap_12(object P0, object P1) {} // 0x00000001850EF54C-0x00000001850EF614
		public int __Gen_Wrap_13(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public bool __Gen_Wrap_14(object P0, object P1) => default; // 0x00000001892AB024-0x00000001892AB0FC
		public string __Gen_Wrap_15(object P0) => default; // 0x0000000189FA2F64-0x0000000189FA3040
		public System.Type __Gen_Wrap_16(object P0) => default; // 0x0000000189FA3040-0x0000000189FA311C
		public StructPtrWrapper __Gen_Wrap_17() => default; // 0x0000000189FA311C-0x0000000189FA31D4
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 57699
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000189FA3658-0x0000000189FA36EC
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 57700
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000189FA5B3C-0x0000000189FA5BA0
		public static bool IsPatched(int id) => default; // 0x0000000182831BD0-0x0000000182831C40
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000189FA59F8-0x0000000189FA5AC4
		public object CreateWrapper(int id) => default; // 0x0000000189FA5AC4-0x0000000189FA5B3C
		public object InitWrapperArray(int len) => default; // 0x0000000189FA5BA0-0x0000000189FA5C2C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000189FA5954-0x0000000189FA59F8
	}

	public enum IDMAP0 // TypeDefIndex: 57701
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
