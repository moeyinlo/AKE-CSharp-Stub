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
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Unity.Collections;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.Pool;

// Image 56: Unsafe.Beyond.dll - Assembly: Unsafe.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 88388-88507

namespace Beyond.Reflection
{
	public class MethodPointerManager // TypeDefIndex: 88480
	{
		// Constructors
		public MethodPointerManager(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static T2 CallPointer<T1, T2>(IntPtr ptr, T1 param);
		public static TRet CallDelegatePointer<TParam1, TRet>(IntPtr ptr, TParam1 target);
		public static TRet CallDelegatePointer<TParam1, TParam2, TRet>(IntPtr ptr, TParam1 target, TParam2 param);
		public static ValueTuple<IntPtr, T1> GetDelegatePointer<T1>(Delegate d);
		public static IntPtr GetDelegatePointer(MethodInfo d); // 0x000000018D6D020C-0x000000018D6D025C
	}

	[Il2CppEagerStaticClassConstruction]
	public static class ObjectPointerHelper // TypeDefIndex: 88481
	{
		// Methods
		public static IntPtr GetIntPtr<T>(ref ref T value)
			where T : struct;
		public static IntPtr GetArrayPtr<T>(T[] value)
			where T : struct;
		public static IntPtr GetSpanPtr(ReadOnlySpan<byte> span); // 0x000000018D6D03EC-0x000000018D6D0470
		public static T GetStructByPointer<T>(IntPtr ptr)
			where T : struct;
		public static T GetValue<T>(IntPtr ptr, int offset)
			where T : struct;
		public static T GetArrayElement<T>(IntPtr array, int index)
			where T : struct;
		public static void SetValue<T>(IntPtr ptr, int offset, T value)
			where T : struct;
		public static void SetArrayElement<T>(IntPtr array, int index, T value)
			where T : struct;
		public static unsafe void SetValue(IntPtr ptr, int offset, byte* data, int size); // 0x000000018D6D04C0-0x000000018D6D04D4
		public static object GetObj(IntPtr ptr, int offset); // 0x000000018D6D02C8-0x000000018D6D030C
		public static void SetObj(IntPtr ptr, int offset, object value); // 0x000000018D6D0470-0x000000018D6D04C0
		public static void CopyValue(IntPtr target, IntPtr source, int size); // 0x000000018D6D02C0-0x000000018D6D02C8
		public static unsafe void CopyValue(void* target, void* source, int size); // 0x000000018D6D02C0-0x000000018D6D02C8
		public static unsafe void CopyValue(byte* to, byte* from, int size); // 0x000000018D6D025C-0x000000018D6D02C0
		public static ReadOnlySpan<byte> GetReadOnlySpan(IntPtr ptr, int maxLength); // 0x000000018D6D030C-0x000000018D6D03EC
	}

	public class StructMemManager // TypeDefIndex: 88482
	{
		// Fields
		private static Dictionary<int, ValueTuple<HashSet<long>, List<IntPtr>>> s_structMemDict; // 0x00
	
		// Constructors
		public StructMemManager(); // 0x0000000186805BA0-0x0000000186805BB0
		static StructMemManager(); // 0x000000018D6D1070-0x000000018D6D10FC
	
		// Methods
		public static IntPtr GetMemoryBySize(int size); // 0x000000018D6D0E0C-0x000000018D6D1070
		public static void FreeMemory(int size, IntPtr ptr); // 0x000000018D6D0CCC-0x000000018D6D0E0C
		public static void ClearMemory(); // 0x000000018D6D056C-0x000000018D6D08C8
		public static string DumpMemory(); // 0x000000018D6D08C8-0x000000018D6D0CCC
	}

	public class StructPtrRefrenceManager // TypeDefIndex: 88483
	{
		// Fields
		private static Dictionary<object, object> s_refDic; // 0x00
		private static Dictionary<System.Type, List<int>> s_structPtrOffsetDic; // 0x08
	
		// Constructors
		public StructPtrRefrenceManager(); // 0x0000000186805BA0-0x0000000186805BB0
		static StructPtrRefrenceManager(); // 0x0000000187082720-0x0000000187082810
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _RunOnStart(); // 0x00000001870EBAA0-0x00000001870EBB70
		public static void AddObjInPtrRef(System.Type type, IntPtr ptr); // 0x000000018D6D10FC-0x000000018D6D13D0
		public static void RemoveObjInPtrRef(System.Type type, IntPtr ptr); // 0x000000018D6D13D0-0x000000018D6D1654
	}

	public class StructPtrWrapper // TypeDefIndex: 88484
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
		public StructPtrWrapper(IntPtr ptr, int size, System.Type type); // 0x000000018D6D23C4-0x000000018D6D2450
		public StructPtrWrapper(object structObj); // 0x000000018D6D2450-0x000000018D6D2530
		static StructPtrWrapper(); // 0x000000018D6D222C-0x000000018D6D23C4
	
		// Methods
		[IDTag(0)]
		public static StructPtrWrapper GetStructPtrWrapper(IntPtr ptr, int size, System.Type type); // 0x000000018D6D1A6C-0x000000018D6D1C1C
		[IDTag(1)]
		public static StructPtrWrapper GetStructPtrWrapper(object structObj); // 0x000000018D6D191C-0x000000018D6D1A6C
		public static void Release(StructPtrWrapper obj); // 0x000000018D6D1C5C-0x000000018D6D1D44
		[IDTag(0)]
		public object GetStructObj(); // 0x000000018D6D1840-0x000000018D6D18CC
		[IDTag(1)]
		public static object GetStructObj(IntPtr ptr, System.Type type, int size); // 0x000000018D6D1794-0x000000018D6D1840
		public void SetStructObjValue(object structObj); // 0x000000018D6D1D44-0x000000018D6D1DD0
		public override int GetHashCode(); // 0x000000018D6D1734-0x000000018D6D1794
		public override bool Equals(object obj); // 0x000000018D6D1654-0x000000018D6D1734
		public override string ToString(); // 0x000000018D6D1DD0-0x000000018D6D1E30
		public new System.Type GetType(); // 0x000000018D6D1C1C-0x000000018D6D1C5C
		[IDTag(2)]
		public static object GetStructObj(StructPtrWrapper obj); // 0x000000018D6D18CC-0x000000018D6D191C
		private static StructPtrWrapper _OnCreate(); // 0x000000018D6D1E30-0x000000018D6D1F6C
		private static void _OnGet(StructPtrWrapper o); // 0x000000018D6D1F6C-0x000000018D6D2170
		private static void _OnRealse(StructPtrWrapper obj); // 0x000000018D6D2170-0x000000018D6D222C
		public int __iFixBaseProxy_GetHashCode(); // 0x0000000187235B50-0x0000000187235B60
		public bool __iFixBaseProxy_Equals(object P0); // 0x0000000184F9DDF0-0x0000000184F9DE00
		public string __iFixBaseProxy_ToString(); // 0x0000000188ABB3B8-0x0000000188ABB3C0
	}
}

namespace Beyond.SparkBuffer
{
	public enum SparkType : byte // TypeDefIndex: 88391
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

	public static class Common // TypeDefIndex: 88392
	{
		// Fields
		public const int NULL_PLACEHOLDER = -1; // Metadata: 0x02648594
		public const int BOOL_MEM_SIZE = 1; // Metadata: 0x02648595
		public const int BYTE_MEM_SIZE = 1; // Metadata: 0x02648596
		public const int INT_MEM_SIZE = 4; // Metadata: 0x02648597
		public const int LONG_MEM_SIZE = 8; // Metadata: 0x02648598
		public const int FLOAT_MEM_SIZE = 4; // Metadata: 0x02648599
		public const int DOUBLE_MEM_SIZE = 8; // Metadata: 0x0264859A
	}

	public static class Utils // TypeDefIndex: 88393
	{
		// Methods
		public static int Align4Bytes(int position); // 0x000000018D6CF5B0-0x000000018D6CF5C4
		public static int Align8Bytes(int position); // 0x000000018D6CF5C4-0x000000018D6CF5D8
		public static int AlignBytesForSize(int position, int size); // 0x000000018D6CF5D8-0x000000018D6CF600
		public static int GetMemSizeForType(SparkType sparkType); // 0x0000000185748760-0x00000001857487D0
		public static int GetFieldOffset(SparkType sparkType, ref int postion); // 0x0000000185889950-0x00000001858899F0
		public static bool IsEnumOrBean(SparkType sparkType); // 0x000000018D6CF638-0x000000018D6CF648
		public static bool IsArrayOrMap(SparkType sparkType); // 0x000000018D6CF628-0x000000018D6CF638
		public static bool CheckValidMapKeyType(SparkType sparkType); // 0x000000018D6CF600-0x000000018D6CF614
		public static bool CheckValidRootType(SparkType sparkType); // 0x000000018D6CF614-0x000000018D6CF628
	}
}

namespace Beyond.SparkBuffer.Runtime
{
	public class ByteReader : IDisposable // TypeDefIndex: 88394
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
		public int position { get; } // 0x0000000182271A60-0x0000000182271A70 
		public NativeArray<byte> buffer { get; } // 0x0000000184430480-0x0000000184430490 
	
		// Constructors
		public ByteReader(byte[] buffer); // 0x0000000185888910-0x0000000185888990
	
		// Methods
		public void Dispose(); // 0x000000018D6BDE50-0x000000018D6BDE98
		public void SeekTo(int pos); // 0x0000000182271A90-0x0000000182271AA0
		public bool ReadBool(); // 0x000000018D6BDE98-0x000000018D6BDEB0
		public byte ReadByte(); // 0x00000001872642D0-0x00000001872642F0
		public int ReadInt(); // 0x000000018D6BDF08-0x000000018D6BDF30
		public long ReadLong(); // 0x000000018D6BDF30-0x000000018D6BDF58
		public float ReadFloat(); // 0x000000018D6BDEDC-0x000000018D6BDF08
		public double ReadDouble(); // 0x000000018D6BDEB0-0x000000018D6BDEDC
		public string ReadString(); // 0x000000018D6BDF58-0x000000018D6BE020
		public Beyond.SparkBuffer.Runtime.Wrapper.HashSlot ReadHashSlot(); // 0x00000001872642F0-0x0000000187264300
		public SparkType ReadSparkType(); // 0x00000001872642D0-0x00000001872642F0
		public int ReadTypeHash(); // 0x000000018D6BE020-0x000000018D6BE028
	}

	public class ByteWriter : IDisposable // TypeDefIndex: 88395
	{
		// Fields
		private static readonly byte[] BUFFER_0; // 0x00
		private readonly BinaryWriter m_writer; // 0x10
		private readonly Stream m_stream; // 0x18
		public static IStringPool s_stringPool; // 0x08
	
		// Properties
		public int position { get; } // 0x000000018D6BE684-0x000000018D6BE6A8 
	
		// Constructors
		public ByteWriter(Stream stream); // 0x000000018D6BE600-0x000000018D6BE684
		static ByteWriter(); // 0x000000018D6BE598-0x000000018D6BE600
	
		// Methods
		public void Dispose(); // 0x000000018D6BE028-0x000000018D6BE064
		public void SeekTo(int pos); // 0x000000018D6BE0A8-0x000000018D6BE0D4
		public void WriteBool(bool v); // 0x000000018D6BE0D4-0x000000018D6BE0F4
		public void WriteByte(byte v); // 0x000000018D6BE0F4-0x000000018D6BE114
		public void WriteInt(int v); // 0x000000018D6BE228-0x000000018D6BE264
		public void WriteLong(long v); // 0x000000018D6BE264-0x000000018D6BE2A0
		public void WriteFloat(float v); // 0x000000018D6BE1EC-0x000000018D6BE228
		public void WriteDouble(double v); // 0x000000018D6BE1B0-0x000000018D6BE1EC
		public void WriteStringAlignment(string v); // 0x000000018D6BE2A0-0x000000018D6BE38C
		public void WriteString(string v); // 0x000000018D6BE38C-0x000000018D6BE468
		public void WriteBytes(ReadOnlySpan<byte> buffer, int index, int count); // 0x000000018D6BE114-0x000000018D6BE1B0
		public void WriteSparkType(SparkType sparkType); // 0x000000018D6BE0F4-0x000000018D6BE114
		internal int FillAlignment(int align); // 0x000000018D6BE064-0x000000018D6BE0A8
		private void _FillAlignment4(); // 0x000000018D6BE468-0x000000018D6BE500
		private void _FillAlignment8(); // 0x000000018D6BE500-0x000000018D6BE598
	}

	public struct Array // TypeDefIndex: 88396
	{
		// Fields
		private readonly ArrayType m_arrayType; // 0x00
		private readonly Root m_root; // 0x18
		private readonly int m_dataOffset; // 0x20
		private readonly int m_length; // 0x24
	
		// Properties
		public int length { get; } // 0x0000000182A819B0-0x0000000182A819C0 
	
		// Constructors
		internal Array(ArrayType arrayType, int offset, Root root); // 0x00000001850B9720-0x00000001850B9850
	
		// Methods
		public bool GetBool(int index); // 0x000000018D6BCF2C-0x000000018D6BCF98
		public byte GetByte(int index); // 0x000000018D6BCF98-0x000000018D6BD004
		public int GetInt(int index); // 0x000000018D6BD2CC-0x000000018D6BD33C
		public long GetLong(int index); // 0x000000018D6BD004-0x000000018D6BD0B4
		public float GetFloat(int index); // 0x000000018D6BD25C-0x000000018D6BD2CC
		public double GetDouble(int index); // 0x000000018D6BD17C-0x000000018D6BD1EC
		public string GetString(int index); // 0x000000018D6BD33C-0x000000018D6BD3AC
		public int GetEnum(int index); // 0x000000018D6BD1EC-0x000000018D6BD25C
		public Bean? GetBean(int index); // 0x000000018D6BD0EC-0x000000018D6BD17C
	}

	public struct Bean // TypeDefIndex: 88397
	{
		// Fields
		private readonly BeanType m_beanType; // 0x00
		private readonly Root m_root; // 0x08
		private readonly int m_dataOffset; // 0x10
	
		// Constructors
		internal Bean(BeanType beanType, int offset, Root root); // 0x00000001850BA740-0x00000001850BA800
	
		// Methods
		public bool GetBool(string key, out int offset); // 0x000000018D6BD564-0x000000018D6BD5DC
		public bool GetBool(int offset); // 0x000000018D6BD5DC-0x000000018D6BD604
		public byte GetByte(string key, out int offset); // 0x000000018D6BD604-0x000000018D6BD67C
		public byte GetByte(int offset); // 0x000000018D6BD67C-0x000000018D6BD6A4
		public int GetInt(string key, out int offset); // 0x000000018D6BD76C-0x000000018D6BD7E4
		public int GetInt(int offset); // 0x000000018D6BD744-0x000000018D6BD76C
		public long GetLong(string key, out int offset); // 0x000000018D6BD884-0x000000018D6BD8FC
		public long GetLong(int offset); // 0x000000018D6BD8FC-0x000000018D6BD924
		public float GetFloat(string key, out int offset); // 0x000000018D6BD80C-0x000000018D6BD884
		public float GetFloat(int offset); // 0x000000018D6BD7E4-0x000000018D6BD80C
		public double GetDouble(string key, out int offset); // 0x000000018D6BD6A4-0x000000018D6BD71C
		public double GetDouble(int offset); // 0x000000018D6BD71C-0x000000018D6BD744
		public string GetString(string key, out int offset); // 0x000000018D6BD924-0x000000018D6BD99C
		public string GetString(int offset); // 0x000000018D6BD99C-0x000000018D6BD9C4
		public int GetEnum(string key, out int offset); // 0x000000018D6BD76C-0x000000018D6BD7E4
		public int GetEnum(int offset); // 0x000000018D6BD744-0x000000018D6BD76C
		public Bean? GetBean(string key); // 0x00000001850B9C50-0x00000001850BA740
		public Beyond.SparkBuffer.Runtime.Array? GetArray(string key); // 0x00000001850B9850-0x00000001850B9C50
		public Beyond.SparkBuffer.Runtime.Map? GetMap(string key); // 0x0000000185748190-0x00000001857485C0
	}

	public struct Map : IEnumerable<Beyond.SparkBuffer.Runtime.Map.UnionKey> // TypeDefIndex: 88400
	{
		// Fields
		private const int INT_KEY_MEM_SIZE = 4; // Metadata: 0x0264859B
		private const int LONG_KEY_MEM_SIZE = 8; // Metadata: 0x0264859C
		private readonly MapType m_mapType; // 0x00
		private readonly Root m_root; // 0x28
		private readonly int m_valueMemSize; // 0x30
		private readonly int m_keyMemSize; // 0x34
		private readonly int m_dataOffset; // 0x38
		private readonly int m_count; // 0x3C
		private readonly int m_slotsOffset; // 0x40
	
		// Properties
		public int count { get; } // 0x000000018226F000-0x000000018226F010 
	
		// Nested types
		public struct UnionKey // TypeDefIndex: 88398
		{
			// Fields
			public int intKey; // 0x00
			public long longKey; // 0x08
			public string stringKey; // 0x10
	
			// Constructors
			public UnionKey(int key); // 0x000000018D6CF568-0x000000018D6CF580
			public UnionKey(long key); // 0x000000018D6CF598-0x000000018D6CF5B0
			public UnionKey(string key); // 0x000000018D6CF580-0x000000018D6CF598
		}
	
		public struct UnionKeyEnumerator : IEnumerator<UnionKey> // TypeDefIndex: 88399
		{
			// Fields
			private readonly Map m_parent; // 0x00
			private int m_index; // 0x48
			private int m_currentSlotIndex; // 0x4C
			private int m_currentSlotStartIndex; // 0x50
			private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot m_currentSlot; // 0x54
	
			// Properties
			public UnionKey Current { get; } // 0x000000018D6CF388-0x000000018D6CF568 
			object IEnumerator.Current { get; } // 0x000000018D6CF2D0-0x000000018D6CF330 
	
			// Constructors
			public UnionKeyEnumerator(Map parent); // 0x000000018D6CF330-0x000000018D6CF388
	
			// Methods
			public bool MoveNext(); // 0x000000018D6CF1E0-0x000000018D6CF2D0
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			void IEnumerator.Reset(); // 0x0000000187264320-0x0000000187264340
		}
	
		// Constructors
		internal Map(MapType mapType, int offset, Root root); // 0x00000001857485C0-0x0000000185748760
	
		// Methods
		public UnionKeyEnumerator GetEnumerator(); // 0x000000018D6C5974-0x000000018D6C5A14
		IEnumerator<UnionKey> System.Collections.Generic.IEnumerable<Beyond.SparkBuffer.Runtime.Map.UnionKey>.GetEnumerator(); // 0x000000018D6C61E8-0x000000018D6C6274
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6C6274-0x000000018D6C6300
		private static int GetHash(string str); // 0x000000018D6C5B48-0x000000018D6C5B68
		private static int GetHash(int value); // 0x0000000187235A70-0x0000000187235A80
		private static int GetHash(long value); // 0x0000000187235A70-0x0000000187235A80
		private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(int slotIndex); // 0x000000018D6C5ACC-0x000000018D6C5B48
		private int _FindHashIndexByKey(int intKey); // 0x000000018D6C6880-0x000000018D6C6958
		private int _FindHashIndexByKey(long longKey); // 0x000000018D6C67A0-0x000000018D6C6880
		private int _FindHashIndexByKey(string stringKey); // 0x000000018D6C6958-0x000000018D6C6A48
		internal int GetIntKeyByIndex(int index); // 0x000000018D6C5B68-0x000000018D6C5C64
		internal long GetLongKeyByIndex(int index); // 0x000000018D6C5DBC-0x000000018D6C5EB8
		internal string GetStringKeyByIndex(int index); // 0x000000018D6C5F70-0x000000018D6C606C
		internal int GetIntKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex); // 0x000000018D6C5C64-0x000000018D6C5D74
		internal long GetLongKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex); // 0x000000018ABBB954-0x000000018ABBBA64
		internal string GetStringKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex); // 0x000000018D6C606C-0x000000018D6C617C
		public bool ContainsKey(string key); // 0x00000001857437F0-0x0000000185743840
		public bool GetBool(string key); // 0x000000018D6C5660-0x000000018D6C5694
		public bool TryGetBool(string key, out bool value); // 0x0000000185BF0470-0x0000000185BF0560
		public byte GetByte(string key); // 0x000000018D6C5744-0x000000018D6C5778
		public bool TryGetByte(string key, out byte value); // 0x000000018D6C63D8-0x000000018D6C6420
		public int GetInt(string key); // 0x0000000185744E60-0x0000000185744ED0
		public bool TryGetInt(string key, out int value); // 0x000000018584EFB0-0x000000018584F040
		public long GetLong(string key); // 0x000000018D6C5EEC-0x000000018D6C5F20
		public bool TryGetLong(string key, out long value); // 0x000000018D6C6754-0x000000018D6C67A0
		public float GetFloat(string key); // 0x000000018D6C5A30-0x000000018D6C5A64
		public bool TryGetFloat(string key, out float value); // 0x000000018D6C6624-0x000000018D6C6670
		public double GetDouble(string key); // 0x000000018D6C57F4-0x000000018D6C5828
		public bool TryGetDouble(string key, out double value); // 0x000000018D6C6468-0x000000018D6C64B4
		public string GetString(string key); // 0x000000018D6C617C-0x000000018D6C61B4
		public bool TryGetString(string key, out string value); // 0x0000000185FBE780-0x0000000185FBE7E0
		public int GetEnum(string key); // 0x000000018D6C58D8-0x000000018D6C590C
		public bool TryGetEnum(string key, out int value); // 0x000000018D6C65DC-0x000000018D6C6624
		public Bean? GetBean(string key); // 0x0000000185951400-0x0000000185951920
		public bool TryGetBean(string key, out Bean? bean); // 0x0000000185951000-0x00000001859512B0
		public bool ContainsKey(int key); // 0x00000001852CD450-0x00000001852CD6D0
		public bool GetBool(int key); // 0x000000018D6C5694-0x000000018D6C56C8
		public bool TryGetBool(int key, out bool value); // 0x000000018D6C6300-0x000000018D6C6348
		public byte GetByte(int key); // 0x000000018D6C5710-0x000000018D6C5744
		public bool TryGetByte(int key, out byte value); // 0x000000018D6C6390-0x000000018D6C63D8
		public int GetInt(int key); // 0x000000018D6C5940-0x000000018D6C5974
		public bool TryGetInt(int key, out int value); // 0x0000000185CCD600-0x0000000185CCD6D0
		public long GetLong(int key); // 0x000000018D6C5F20-0x000000018D6C5F54
		public bool TryGetLong(int key, out long value); // 0x000000018D6C6708-0x000000018D6C6754
		public float GetFloat(int key); // 0x000000018D6C5A64-0x000000018D6C5A98
		public bool TryGetFloat(int key, out float value); // 0x000000018D6C66BC-0x000000018D6C6708
		public double GetDouble(int key); // 0x000000018D6C5828-0x000000018D6C585C
		public bool TryGetDouble(int key, out double value); // 0x000000018D6C6500-0x000000018D6C654C
		public string GetString(int key); // 0x00000001852CD9B0-0x00000001852CDEC0
		public bool TryGetString(int key, out string value); // 0x00000001855CDAA0-0x00000001855CDB00
		public int GetEnum(int key); // 0x000000018D6C5940-0x000000018D6C5974
		public bool TryGetEnum(int key, out int value); // 0x000000018D6C6594-0x000000018D6C65DC
		public Bean? GetBean(int key); // 0x0000000185952F00-0x0000000185952F60
		public bool TryGetBean(int key, out Bean? bean); // 0x00000001852CD020-0x00000001852CD1A0
		public bool ContainsKey(long key); // 0x000000018D6C5528-0x000000018D6C553C
		public bool GetBool(long key); // 0x000000018D6C562C-0x000000018D6C5660
		public bool TryGetBool(long key, out bool value); // 0x000000018D6C6348-0x000000018D6C6390
		public byte GetByte(long key); // 0x000000018D6C5778-0x000000018D6C57AC
		public bool TryGetByte(long key, out byte value); // 0x000000018D6C6420-0x000000018D6C6468
		public int GetInt(long key); // 0x000000018D6C590C-0x000000018D6C5940
		public bool TryGetInt(long key, out int value); // 0x000000018D6C654C-0x000000018D6C6594
		public long GetLong(long key); // 0x000000018D6C5EB8-0x000000018D6C5EEC
		public bool TryGetLong(long key, out long value); // 0x0000000185C1EF30-0x0000000185C1EF70
		public float GetFloat(long key); // 0x000000018D6C5A98-0x000000018D6C5ACC
		public bool TryGetFloat(long key, out float value); // 0x000000018D6C6670-0x000000018D6C66BC
		public double GetDouble(long key); // 0x000000018D6C585C-0x000000018D6C5890
		public bool TryGetDouble(long key, out double value); // 0x000000018D6C64B4-0x000000018D6C6500
		public string GetString(long key); // 0x000000018D6C61B4-0x000000018D6C61E8
		public bool TryGetString(long key, out string value); // 0x0000000185C1EF70-0x0000000185C1F400
		public int GetEnum(long key); // 0x000000018D6C590C-0x000000018D6C5940
		public bool TryGetEnum(long key, out int value); // 0x000000018D6C654C-0x000000018D6C6594
		public Bean? GetBean(long key); // 0x000000018D6C557C-0x000000018D6C55E4
		public bool TryGetBean(long key, out Bean? bean); // 0x0000000185C1EEF0-0x0000000185C1EF30
		internal bool GetBoolByIndex(int index); // 0x000000018D6C55E4-0x000000018D6C5610
		internal byte GetByteByIndex(int index); // 0x000000018D6C56C8-0x000000018D6C56F4
		internal int GetIntByIndex(int index); // 0x000000018D6C5890-0x000000018D6C58BC
		internal long GetLongByIndex(int index); // 0x000000018D6C5D74-0x000000018D6C5DA0
		internal float GetFloatByIndex(int index); // 0x00000001860A1DD0-0x00000001860A1E80
		internal double GetDoubleByIndex(int index); // 0x000000018D6C57AC-0x000000018D6C57D8
		internal string GetStringByIndex(int index); // 0x00000001852A2CB0-0x00000001852A2CE0
		internal int GetEnumByIndex(int index); // 0x000000018D6C5890-0x000000018D6C58BC
		internal Bean? GetBeanByIndex(int index); // 0x0000000185951D30-0x0000000185951E80
		private int _GetOffsetByIndex(int index); // 0x000000018D6C6A48-0x000000018D6C6BA8
		internal bool GetBoolByOffset(int offset); // 0x000000018D6C5610-0x000000018D6C562C
		internal byte GetByteByOffset(int offset); // 0x000000018D6C56F4-0x000000018D6C5710
		internal int GetIntByOffset(int offset); // 0x000000018D6C58BC-0x000000018D6C58D8
		internal long GetLongByOffset(int offset); // 0x000000018D6C5DA0-0x000000018D6C5DBC
		internal float GetFloatByOffset(int offset); // 0x000000018D6C5A14-0x000000018D6C5A30
		internal double GetDoubleByOffset(int offset); // 0x000000018D6C57D8-0x000000018D6C57F4
		internal string GetStringByOffset(int offset); // 0x000000018D6C5F54-0x000000018D6C5F70
		internal int GetEnumByOffset(int offset); // 0x000000018D6C58BC-0x000000018D6C58D8
		internal Bean? GetBeanByOffset(int offset); // 0x000000018D6C553C-0x000000018D6C557C
	}

	public class Root : IDisposable // TypeDefIndex: 88402
	{
		// Fields
		private ByteReader m_reader; // 0x10
		private readonly Options m_options; // 0x18
		private readonly int m_dataOffset; // 0x40
		private Dictionary<int, string> m_cachedString; // 0x48
	
		// Properties
		public string name { get; } // 0x0000000182234E30-0x0000000182234E40 
		public NativeArray<byte> bytes { get; } // 0x00000001854C1200-0x00000001854C1230 
	
		// Nested types
		internal struct Options // TypeDefIndex: 88401
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
		internal Root(int dataOffset, Options options, ByteReader reader); // 0x000000018545D520-0x000000018545D5D0
	
		// Methods
		~Root(); // 0x000000018D6C96BC-0x000000018D6C978C
		public override string ToString(); // 0x000000018D6C9D7C-0x000000018D6C9DEC
		public void Dispose(); // 0x000000018D6C968C-0x000000018D6C96BC
		public bool IsValid(); // 0x000000018C93AE88-0x000000018C93AE94
		public Bean? AsBean(); // 0x000000018D6C9420-0x000000018D6C94DC
		public Beyond.SparkBuffer.Runtime.Array? AsArray(); // 0x000000018D6C92FC-0x000000018D6C9420
		public Beyond.SparkBuffer.Runtime.Map? AsMap(); // 0x000000018D6C94DC-0x000000018D6C968C
		internal int GetCurReaderPosition(); // 0x000000018D6C9A34-0x000000018D6C9A50
		internal bool GetBool(int offset); // 0x000000018D6C99F8-0x000000018D6C9A34
		internal byte GetByte(int offset); // 0x000000018D6BD0B4-0x000000018D6BD0EC
		internal int GetInt(int offset); // 0x000000018D6C9A78-0x000000018D6C9AA0
		internal long GetLong(int offset); // 0x000000018D6C9AA0-0x000000018D6C9AC8
		internal float GetFloat(int offset); // 0x00000001860A1E80-0x00000001860A1EE0
		internal double GetDouble(int offset); // 0x000000018D6C9A50-0x000000018D6C9A78
		internal int GetEnum(int offset); // 0x000000018D6C9A78-0x000000018D6C9AA0
		internal string GetString(int offset); // 0x000000018D6C9C70-0x000000018D6C9D7C
		internal Bean? GetBean(int offset, BeanType beanType); // 0x000000018D6C98D4-0x000000018D6C99F8
		internal Beyond.SparkBuffer.Runtime.Array? GetArray(int offset, ArrayType arrayType); // 0x000000018D6C978C-0x000000018D6C98D4
		internal Beyond.SparkBuffer.Runtime.Map? GetMap(int offset, MapType mapType); // 0x000000018D6C9AC8-0x000000018D6C9C70
		internal Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(int offset); // 0x00000001850BABB0-0x00000001850BABE0
	}

	public static class Error // TypeDefIndex: 88403
	{
		// Methods
		public static Exception TypeNotFoundError(int typeHash, SparkType sparkType); // 0x000000018D6BEC68-0x000000018D6BED34
		public static Exception InvalidTypeError(SparkType sparkType); // 0x000000018D6BEAC4-0x000000018D6BEB64
		public static Exception InvalidMapKeyError(SparkType sparkType); // 0x000000018D6BEA24-0x000000018D6BEAC4
		public static Exception NullTypeError(SparkType sparkType); // 0x000000018D6BEB64-0x000000018D6BEC04
		public static Exception GetEndOfFile(); // 0x000000018D6BE9C0-0x000000018D6BEA24
		public static Exception SeekAheadOfFile(); // 0x000000018D6BEC04-0x000000018D6BEC68
		public static Exception DisposedException(); // 0x000000018D6BE95C-0x000000018D6BE9C0
	}

	public abstract class SparkManager // TypeDefIndex: 88406
	{
		// Fields
		private readonly Dictionary<int, BeanType> m_beanTypeMap; // 0x10
		private readonly Dictionary<int, EnumType> m_enumTypeMap; // 0x18
		protected readonly Dictionary<string, Root> m_namedRoots; // 0x20
		private readonly List<Root> m_anonymousRoots; // 0x28
		private readonly Queue<BeanType> m_beanTypeQueue; // 0x30
	
		// Nested types
		private class JsonLoader : IDisposable // TypeDefIndex: 88405
		{
			// Fields
			private ByteWriter m_writer; // 0x10
			private Dictionary<string, int> m_stringMap; // 0x18
	
			// Nested types
			private struct ReservedField // TypeDefIndex: 88404
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
			private JsonLoader(ByteWriter writer); // 0x000000018D6C3818-0x000000018D6C38A0
	
			// Methods
			public void Dispose(); // 0x00000001863017D0-0x00000001863017F0
			internal static void PopulateJsonDataWithoutTypeAndRootDef(ByteWriter writer, JToken rootObj, Root.Options rootOptions, out int dataOffset); // 0x000000018D6BFEB8-0x000000018D6C0008
			private void _LoadJsonContentWithoutTypeAndRootDef(JToken rootObj, Root.Options rootOptions, out int dataOffset); // 0x000000018D6C3784-0x000000018D6C3818
			private void _ExportStrings(JToken rootJson, Root.Options rootOptions); // 0x000000018D6C3028-0x000000018D6C353C
			private void _CollectBeanStrings(HashSet<string> stringSet, JObject obj, BeanType beanType); // 0x000000018D6C0230-0x000000018D6C0710
			private void _CollectArrayStrings(HashSet<string> stringSet, JArray obj, ArrayType arrayType); // 0x000000018D6C0008-0x000000018D6C0230
			private void _CollectMapStrings(HashSet<string> stringSet, JObject obj, MapType mapType); // 0x000000018D6C0710-0x000000018D6C0994
			private int _ExportRootData(JToken rootJson, Root.Options rootOptions); // 0x000000018D6C2C5C-0x000000018D6C2F20
			private int _ExportBeanData(JObject beanObj, BeanType beanType); // 0x000000018D6C1218-0x000000018D6C1A0C
			private int _ExportArrayData(JArray arrayObj, ArrayType arrayType); // 0x000000018D6C0DA4-0x000000018D6C1218
			private int _ExportMapData(JObject mapObj, MapType mapType); // 0x000000018D6C1E48-0x000000018D6C24B4
			private Dictionary<int, List<KeyValuePair<string, JToken>>> _CreateMapHashEntry(JObject mapObj, SparkType keyType); // 0x000000018D6C0994-0x000000018D6C0CB4
			private int _GetMapKeyHash(string key, SparkType keyType); // 0x000000018D6C353C-0x000000018D6C36E4
			private void _ExportMapKey(string key, SparkType keyType); // 0x000000018D6C24B4-0x000000018D6C2688
			private void _ExportMapValue(JToken valueToken, MapType mapType, List<ReservedField> reservedFields); // 0x000000018D6C2688-0x000000018D6C283C
			private void _ExportReservedFields(List<ReservedField> reservedFields); // 0x000000018D6C283C-0x000000018D6C2C5C
			private void _ExportStringByLoc(string strVal); // 0x000000018D6C2F20-0x000000018D6C3028
			private void _ExportEnumData(JToken token, EnumType enumType); // 0x000000018D6C1CB0-0x000000018D6C1E48
			private void _ExportCommonDataOrThrow(JToken token, SparkType type, List<ReservedField> reservedFields); // 0x000000018D6C1A0C-0x000000018D6C1CB0
			private static void _EnsureJTokenType(JToken token, JTokenType requiredType); // 0x000000018D6C0CB4-0x000000018D6C0DA4
			private static Exception _InvalidRootTypeError(SparkType rootType); // 0x000000018D6C36E4-0x000000018D6C3784
		}
	
		// Constructors
		protected SparkManager(); // 0x0000000186EAA890-0x0000000186EAAA30
	
		// Methods
		public Root Load(byte[] bytes, string overrideRootName); // 0x0000000185888A10-0x0000000185888B60
		public Root Load(byte[] bytes); // 0x000000018D6CB458-0x000000018D6CB464
		public Root LoadFromJson_EditorOnly(byte[] bytes, JToken jsonData, string overrideRootName); // 0x000000018D6CAF6C-0x000000018D6CB458
		public Root LoadFromJson_EditorOnly(byte[] bytes, JToken jsonData); // 0x000000018D6CAF50-0x000000018D6CAF6C
		public virtual bool Unload(Root root); // 0x000000018D6CB634-0x000000018D6CB688
		public virtual void UnloadAndClearAll(); // 0x000000018D6CB464-0x000000018D6CB634
		internal bool TryGetEnumType(int typeHash, out EnumType enumType); // 0x00000001863B8770-0x00000001863B8830
		internal bool TryGetBeanType(int typeHash, out BeanType beanType); // 0x00000001863B8700-0x00000001863B8730
		protected virtual bool _AddRoot(Root root); // 0x00000001863EA850-0x00000001863EA8A0
		private void _ReadTypeDefs(ByteReader reader); // 0x0000000185889030-0x00000001858891C0
		private Root.Options _ReadRootDef(ByteReader reader, string overrideRootName); // 0x0000000185888B60-0x0000000185889030
	}

	public class RuntimeSparkManager : SparkManager // TypeDefIndex: 88408
	{
		// Fields
		private static RuntimeSparkManager s_instance; // 0x00
		private Action<Root> m_onRootLoaded; // 0x38
		private Action<Root> m_onRootUnloaded; // 0x40
		private Action m_onUnloadAll; // 0x48
		private const string LUADLL = "__Internal"; // Metadata: 0x0264859D
	
		// Properties
		public static RuntimeSparkManager instance { get; } // 0x00000001858D7070-0x00000001858D70F0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 88407
		{
			// Fields
			public IntPtr L; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RegisterToLua_b__0(Root root); // 0x00000001854C11B0-0x00000001854C1200
			internal void _RegisterToLua_b__1(Root root); // 0x000000018D6CF14C-0x000000018D6CF170
			internal void _RegisterToLua_b__2(); // 0x000000018D6CF170-0x000000018D6CF17C
		}
	
		// Constructors
		private RuntimeSparkManager(); // 0x000000018D6C9FB8-0x000000018D6C9FC0
	
		// Methods
		public override bool Unload(Root root); // 0x000000018D6C9F10-0x000000018D6C9F78
		public void ReloadTableToLua(string name); // 0x000000018D6C9E34-0x000000018D6C9EB4
		public override void UnloadAndClearAll(); // 0x000000018D6C9EB4-0x000000018D6C9F10
		private static extern bool LuaSpark_LoadRoot(IntPtr L, string rootName, IntPtr data, int size); // 0x00000001854C1140-0x00000001854C11B0
		private static extern bool LuaSpark_UnloadRoot(IntPtr L, string rootName); // 0x000000018D6C9DF4-0x000000018D6C9E34
		private static extern void LuaSpark_UnloadAll(IntPtr L); // 0x000000018D6C9DEC-0x000000018D6C9DF4
		public void RegisterToLua(IntPtr L); // 0x000000018650DF00-0x000000018650E210
		public void UnregisterFromLua(IntPtr L); // 0x000000018D6C9F78-0x000000018D6C9FB8
		protected override bool _AddRoot(Root root); // 0x00000001863EA7E0-0x00000001863EA850
	}

	public interface IStringPool // TypeDefIndex: 88409
	{
		// Methods
		int AddString(string str);
		string GetString(int index);
		void Clear();
	}

	internal abstract class Field // TypeDefIndex: 88410
	{
		// Fields
		[CompilerGenerated]
		private readonly string _name_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly int _offset_k__BackingField; // 0x18
	
		// Properties
		public string name { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		public int offset { [CompilerGenerated] get; } // 0x00000001844AF510-0x00000001844AF520 
		public abstract SparkType type { get; }
	
		// Constructors
		protected Field(string fieldName, int fieldOffset); // 0x00000001856B50C0-0x00000001856B50E0
	
		// Methods
		public abstract void Unmarshal(ByteReader reader);
		public abstract void Resolve(SparkManager manager);
	}

	internal class SimpleField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 88411
	{
		// Fields
		[CompilerGenerated]
		private readonly SparkType _type_k__BackingField; // 0x20
	
		// Properties
		public override SparkType type { [CompilerGenerated] get; } // 0x0000000182246E50-0x0000000182246E60 
	
		// Constructors
		public SimpleField(SparkType type, string fieldName, int fieldOffset); // 0x0000000187837F08-0x0000000187837F30
	
		// Methods
		public override void Unmarshal(ByteReader reader); // 0x0000000186805BA0-0x0000000186805BB0
		public override void Resolve(SparkManager manager); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class EnumField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 88412
	{
		// Fields
		private int m_typeHash; // 0x20
		private EnumType m_enumType; // 0x28
	
		// Properties
		public override SparkType type { get; } // 0x0000000187264300-0x0000000187264310 
		public EnumType enumType { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Constructors
		public EnumField(string fieldName, int fieldOffset); // 0x00000001856B50C0-0x00000001856B50E0
	
		// Methods
		public override void Unmarshal(ByteReader reader); // 0x000000018690F970-0x000000018690F9A0
		public override void Resolve(SparkManager manager); // 0x00000001863B8730-0x00000001863B8770
	}

	internal class BeanField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 88413
	{
		// Fields
		private int m_typeHash; // 0x20
		private BeanType m_beanType; // 0x28
	
		// Properties
		public override SparkType type { get; } // 0x0000000187233930-0x0000000187233940 
		public BeanType beanType { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Constructors
		public BeanField(string fieldName, int fieldOffset); // 0x00000001856B50C0-0x00000001856B50E0
	
		// Methods
		public override void Unmarshal(ByteReader reader); // 0x0000000186763FF0-0x0000000186764020
		public override void Resolve(SparkManager manager); // 0x00000001863B86C0-0x00000001863B8700
	}

	internal class ArrayField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 88414
	{
		// Fields
		private ArrayType m_arrayType; // 0x20
		private int m_elementTypeHash; // 0x38
	
		// Properties
		public override SparkType type { get; } // 0x00000001872642C0-0x00000001872642D0 
		public ArrayType arrayType { get; } // 0x0000000187235350-0x0000000187235370 
	
		// Constructors
		public ArrayField(string fieldName, int fieldOffset); // 0x00000001856B50C0-0x00000001856B50E0
	
		// Methods
		public override void Unmarshal(ByteReader reader); // 0x00000001863E1370-0x00000001863E1400
		public override void Resolve(SparkManager manager); // 0x00000001863B8650-0x00000001863B86C0
	}

	internal class MapField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 88415
	{
		// Fields
		private MapType m_mapInfo; // 0x20
		private int m_keyTypeHash; // 0x48
		private int m_valueTypeHash; // 0x4C
	
		// Properties
		public override SparkType type { get; } // 0x0000000187264310-0x0000000187264320 
		public MapType mapType { get; } // 0x000000018723C370-0x000000018723C390 
	
		// Constructors
		public MapField(string fieldName, int fieldOffset); // 0x00000001856B50C0-0x00000001856B50E0
	
		// Methods
		public override void Unmarshal(ByteReader reader); // 0x00000001863E1300-0x00000001863E1370
		public override void Resolve(SparkManager manager); // 0x00000001863B85F0-0x00000001863B8650
	}

	internal struct ArrayType // TypeDefIndex: 88416
	{
		// Fields
		public SparkType elementType; // 0x00
		public BeanType elementBeanType; // 0x08
		public EnumType elementEnumType; // 0x10
	}

	internal struct MapType // TypeDefIndex: 88417
	{
		// Fields
		public SparkType keyType; // 0x00
		public EnumType keyEnumType; // 0x08
		public SparkType valueType; // 0x10
		public BeanType valueBeanType; // 0x18
		public EnumType valueEnumType; // 0x20
	}

	internal class EnumType // TypeDefIndex: 88419
	{
		// Fields
		private List<EnumItem> m_enums; // 0x10
		[CompilerGenerated]
		private int _typeHash_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x20
	
		// Properties
		public int typeHash { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
		// Nested types
		private struct EnumItem // TypeDefIndex: 88418
		{
			// Fields
			public string name; // 0x00
			public int value; // 0x08
		}
	
		// Constructors
		public EnumType(ByteReader reader); // 0x0000000185889430-0x0000000185889840
	
		// Methods
		public bool TryGetValue(string enumName, out int enumVal); // 0x000000018D6BE88C-0x000000018D6BE95C
	}

	internal class BeanType : IEnumerable<KeyValuePair<string, Beyond.SparkBuffer.Runtime.Field>> // TypeDefIndex: 88420
	{
		// Fields
		private Dictionary<string, Beyond.SparkBuffer.Runtime.Field> m_fields; // 0x10
		[CompilerGenerated]
		private int _typeHash_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x20
	
		// Properties
		public int typeHash { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
		// Constructors
		public BeanType(ByteReader reader); // 0x00000001858891C0-0x0000000185889430
	
		// Methods
		public override string ToString(); // 0x000000018D6BD4F4-0x000000018D6BD564
		public void Resolve(SparkManager manager); // 0x00000001858899F0-0x0000000185889AF0
		public bool TryGetField(string fieldName, out Beyond.SparkBuffer.Runtime.Field field); // 0x00000001850BA800-0x00000001850BABB0
		public Dictionary<string, Beyond.SparkBuffer.Runtime.Field> GetEnumerator(); // 0x000000018D6BD3AC-0x000000018D6BD424
		IEnumerator<KeyValuePair<string, Beyond.SparkBuffer.Runtime.Field>> IEnumerable<KeyValuePair<string, Field>>.GetEnumerator(); // 0x000000018D6BD424-0x000000018D6BD48C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BD48C-0x000000018D6BD4F4
		private Beyond.SparkBuffer.Runtime.Field _NewField(string name, SparkType type, int offset); // 0x0000000185889840-0x0000000185889950
	}
}

namespace Beyond.SparkBuffer.Runtime.Wrapper
{
	public interface IArrayWrapper<T> // TypeDefIndex: 88421
	{
		// Properties
		int length { get; }
		int Count { get; }
		T this[int index] { get => default; }
	}

	public struct ArrayEnumerator<TElement, TArray> : IEnumerator<TElement> // TypeDefIndex: 88422
		where TArray : IArrayWrapper<TElement>
	{
		// Fields
		private readonly TArray m_parent;
		private int m_index;
	
		// Properties
		public TElement Current { get; }
		object IEnumerator.Current { get; }
	
		// Constructors
		public ArrayEnumerator(TArray parent);
	
		// Methods
		public bool MoveNext();
		public void Dispose();
		void IEnumerator.Reset();
	}

	public struct NullableBeanArray<TBean> : IArrayWrapper<TBean?>, IEnumerable<TBean?> // TypeDefIndex: 88423
		where TBean : struct
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array;
		private Func<Bean, TBean> m_creator;
	
		// Properties
		public int length { get; }
		public int Count { get; }
		public TBean? this[int index] { get => default; }
	
		// Constructors
		public NullableBeanArray(Beyond.SparkBuffer.Runtime.Array array, Func<Bean, TBean> creator);
	
		// Methods
		public ArrayEnumerator<TBean?, NullableBeanArray<TBean>> GetEnumerator();
		IEnumerator<TBean?> IEnumerable<TBean?>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public struct BeanArray<TBean> : IArrayWrapper<TBean>, IEnumerable<TBean> // TypeDefIndex: 88424
		where TBean : struct
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array;
		private Func<Bean, TBean> m_creator;
	
		// Properties
		public int length { get; }
		public int Count { get; }
		public TBean this[int index] { get => default; }
	
		// Constructors
		public BeanArray(Beyond.SparkBuffer.Runtime.Array array, Func<Bean, TBean> creator);
	
		// Methods
		public ArrayEnumerator<TBean, BeanArray<TBean>> GetEnumerator();
		IEnumerator<TBean> IEnumerable<TBean>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public struct EnumArray<TEnum> : IArrayWrapper<TEnum>, IEnumerable<TEnum> // TypeDefIndex: 88425
		where TEnum : struct
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array;
		private Func<int, TEnum> m_converter;
	
		// Properties
		public int length { get; }
		public int Count { get; }
		public TEnum this[int index] { get => default; }
	
		// Constructors
		public EnumArray(Beyond.SparkBuffer.Runtime.Array array, Func<int, TEnum> converter);
	
		// Methods
		public ArrayEnumerator<TEnum, EnumArray<TEnum>> GetEnumerator();
		public TEnum[] ToArray();
		public bool Contains(TEnum item);
		IEnumerator<TEnum> IEnumerable<TEnum>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public struct BoolArray : IArrayWrapper<bool>, IEnumerable<bool> // TypeDefIndex: 88426
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public int Count { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public bool this[int index] { get => default; } // 0x000000018D6BDC14-0x000000018D6BDC1C 
	
		// Constructors
		public BoolArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018D6BDBF0-0x000000018D6BDC14
	
		// Methods
		public ArrayEnumerator<bool, BoolArray> GetEnumerator(); // 0x000000018D6BDA0C-0x000000018D6BDA80
		public bool[] ToArray(); // 0x000000018D6BDB58-0x000000018D6BDBF0
		public bool Contains(bool item); // 0x000000018D6BD9C4-0x000000018D6BDA0C
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator(); // 0x000000018D6BDA80-0x000000018D6BDAEC
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BDAEC-0x000000018D6BDB58
	}

	public struct ByteArray : IArrayWrapper<byte>, IEnumerable<byte> // TypeDefIndex: 88427
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public int Count { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public byte this[int index] { get => default; } // 0x000000018D6BDE48-0x000000018D6BDE50 
	
		// Constructors
		public ByteArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018D6BDBF0-0x000000018D6BDC14
	
		// Methods
		public ArrayEnumerator<byte, ByteArray> GetEnumerator(); // 0x000000018D6BDC64-0x000000018D6BDCD8
		public byte[] ToArray(); // 0x000000018D6BDDB0-0x000000018D6BDE48
		public bool Contains(byte item); // 0x000000018D6BDC1C-0x000000018D6BDC64
		IEnumerator<byte> IEnumerable<byte>.GetEnumerator(); // 0x000000018D6BDCD8-0x000000018D6BDD44
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BDD44-0x000000018D6BDDB0
	}

	public struct IntArray : IArrayWrapper<int>, IEnumerable<int> // TypeDefIndex: 88428
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public int Count { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public int this[int index] { get => default; } // 0x0000000187837DC0-0x0000000187837DC8 
	
		// Constructors
		public IntArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018D6BDBF0-0x000000018D6BDC14
	
		// Methods
		public ArrayEnumerator<int, IntArray> GetEnumerator(); // 0x0000000186A9E800-0x0000000186A9E870
		public int[] ToArray(); // 0x000000018D6BFE20-0x000000018D6BFEB8
		public bool Contains(int item); // 0x000000018D6BFD6C-0x000000018D6BFDB4
		IEnumerator<int> IEnumerable<int>.GetEnumerator(); // 0x0000000186A9E790-0x0000000186A9E800
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BFDB4-0x000000018D6BFE20
	}

	public struct LongArray : IArrayWrapper<long>, IEnumerable<long> // TypeDefIndex: 88429
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public int Count { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public long this[int index] { get => default; } // 0x000000018D6C5520-0x000000018D6C5528 
	
		// Constructors
		public LongArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018D6BDBF0-0x000000018D6BDC14
	
		// Methods
		public ArrayEnumerator<long, LongArray> GetEnumerator(); // 0x000000018D6C533C-0x000000018D6C53B0
		public long[] ToArray(); // 0x000000018D6C5488-0x000000018D6C5520
		public bool Contains(long item); // 0x000000018D6C52F4-0x000000018D6C533C
		IEnumerator<long> IEnumerable<long>.GetEnumerator(); // 0x000000018D6C53B0-0x000000018D6C541C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6C541C-0x000000018D6C5488
	}

	public struct FloatArray : IArrayWrapper<float>, IEnumerable<float> // TypeDefIndex: 88430
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public int Count { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public float this[int index] { get => default; } // 0x000000018783C3A4-0x000000018783C3AC 
	
		// Constructors
		public FloatArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018D6BDBF0-0x000000018D6BDC14
	
		// Methods
		public ArrayEnumerator<float, FloatArray> GetEnumerator(); // 0x0000000186AA9860-0x0000000186AA98D0
		public float[] ToArray(); // 0x000000018D6BEDC0-0x000000018D6BEE58
		IEnumerator<float> IEnumerable<float>.GetEnumerator(); // 0x0000000186AA97F0-0x0000000186AA9860
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BED54-0x000000018D6BEDC0
	}

	public struct DoubleArray : IArrayWrapper<double>, IEnumerable<double> // TypeDefIndex: 88431
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public int Count { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public double this[int index] { get => default; } // 0x0000000187835B64-0x0000000187835B6C 
	
		// Constructors
		public DoubleArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018D6BDBF0-0x000000018D6BDC14
	
		// Methods
		public ArrayEnumerator<double, DoubleArray> GetEnumerator(); // 0x000000018D6BE6A8-0x000000018D6BE71C
		public double[] ToArray(); // 0x000000018D6BE7F4-0x000000018D6BE88C
		IEnumerator<double> IEnumerable<double>.GetEnumerator(); // 0x000000018D6BE71C-0x000000018D6BE788
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BE788-0x000000018D6BE7F4
	}

	public struct StringArray : IArrayWrapper<string>, IEnumerable<string> // TypeDefIndex: 88432
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public int Count { get; } // 0x0000000182A819B0-0x0000000182A819C0 
		public string this[int index] { get => default; } // 0x0000000187837024-0x000000018783702C 
	
		// Constructors
		public StringArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018D6BDBF0-0x000000018D6BDC14
	
		// Methods
		public ArrayEnumerator<string, StringArray> GetEnumerator(); // 0x000000018565CAC0-0x000000018565CB00
		public string[] ToArray(); // 0x000000018565E270-0x000000018565E330
		public bool Contains(string item); // 0x000000018565E330-0x000000018565E3E0
		IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x0000000186B60E00-0x0000000186B60EA0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6CEF8C-0x000000018D6CEFF8
	}

	public interface IBeanWrapper // TypeDefIndex: 88433
	{
		// Methods
		void SetBean(ref Bean bean);
	}

	public struct HashSlot // TypeDefIndex: 88434
	{
		// Fields
		public int offset; // 0x00
		public int bucketsSize; // 0x04
		public static readonly int size; // 0x00
	
		// Constructors
		static HashSlot(); // 0x00000001872203F0-0x0000000187220430
	}

	public interface IMapWrapper<TKey, TValue, TMap> // TypeDefIndex: 88435
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

	public struct MapEnumerator<TKey, TValue, TMap> : IEnumerator<KeyValuePair<TKey, TValue>> // TypeDefIndex: 88436
		where TMap : IMapWrapper<TKey, TValue, TMap>
	{
		// Fields
		private readonly TMap m_parent;
		private int m_index;
	
		// Properties
		public KeyValuePair<TKey, TValue> Current { get; }
		object IEnumerator.Current { get; }
	
		// Constructors
		public MapEnumerator(TMap parent);
	
		// Methods
		public bool MoveNext();
		public void Dispose();
		void IEnumerator.Reset();
	}

	public struct S2NullableBeanMap<TBean> : IMapWrapper<string, TBean?, S2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<string, TBean?>> // TypeDefIndex: 88437
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get; }
		public int Count { get; }
		public TBean? this[string key] { get => default; }
	
		// Constructors
		public S2NullableBeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator);
	
		// Methods
		public bool ContainsKey(string key);
		public string GetKeyByIndex(int index);
		public TBean? GetValue(string key);
		public bool TryGetValue(string key, out TBean? value);
		public TBean? GetValueByIndex(int index);
		public MapEnumerator<string, TBean?, S2NullableBeanMap<TBean>> GetEnumerator();
		IEnumerator<KeyValuePair<string, TBean?>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TBean?>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public struct S2BeanMap<TBean> : IMapWrapper<string, TBean, S2BeanMap<TBean>>, IEnumerable<KeyValuePair<string, TBean>> // TypeDefIndex: 88438
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get; }
		public int Count { get; }
		public TBean this[string key] { get => default; }
	
		// Constructors
		public S2BeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator);
	
		// Methods
		public bool ContainsKey(string key);
		public string GetKeyByIndex(int index);
		public TBean GetValue(string key);
		public bool TryGetValue(string key, out ref TBean value);
		public TBean GetValueByIndex(int index);
		public MapEnumerator<string, TBean, S2BeanMap<TBean>> GetEnumerator();
		IEnumerator<KeyValuePair<string, TBean>> IEnumerable<KeyValuePair<string, TBean>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public struct S2EnumMap<TEnum> : IMapWrapper<string, TEnum, S2EnumMap<TEnum>>, IEnumerable<KeyValuePair<string, TEnum>> // TypeDefIndex: 88439
		where TEnum : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private Func<int, TEnum> m_converter;
	
		// Properties
		public int count { get; }
		public int Count { get; }
		public TEnum this[string key] { get => default; }
	
		// Constructors
		public S2EnumMap(Beyond.SparkBuffer.Runtime.Map map, Func<int, TEnum> converter);
	
		// Methods
		public bool ContainsKey(string key);
		public string GetKeyByIndex(int index);
		public TEnum GetValue(string key);
		public bool TryGetValue(string key, out ref TEnum value);
		public TEnum GetValueByIndex(int index);
		public MapEnumerator<string, TEnum, S2EnumMap<TEnum>> GetEnumerator();
		IEnumerator<KeyValuePair<string, TEnum>> IEnumerable<KeyValuePair<string, TEnum>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public struct S2BoolMap : IMapWrapper<string, bool, S2BoolMap>, IEnumerable<KeyValuePair<string, bool>> // TypeDefIndex: 88440
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public bool this[string key] { get => default; } // 0x000000018D6CA098-0x000000018D6CA0DC 
	
		// Constructors
		public S2BoolMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(string key); // 0x000000018B63F580-0x000000018B63F5C4
		public string GetKeyByIndex(int index); // 0x00000001863912D0-0x0000000186391320
		public bool GetValue(string key); // 0x000000018D6CA098-0x000000018D6CA0DC
		public bool TryGetValue(string key, out bool value); // 0x0000000185BF03F0-0x0000000185BF0470
		public bool GetValueByIndex(int index); // 0x000000018D6BEF28-0x000000018D6BEF6C
		public MapEnumerator<string, bool, S2BoolMap> GetEnumerator(); // 0x000000018D6C9FC0-0x000000018D6CA098
		IEnumerator<KeyValuePair<string, bool>> IEnumerable<KeyValuePair<string, bool>>.GetEnumerator(); // 0x000000018D6CA0DC-0x000000018D6CA15C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6CA15C-0x000000018D6CA1DC
	}

	public struct S2ByteMap : IMapWrapper<string, byte, S2ByteMap>, IEnumerable<KeyValuePair<string, byte>> // TypeDefIndex: 88441
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public byte this[string key] { get => default; } // 0x000000018D6CA2B4-0x000000018D6CA2F8 
	
		// Constructors
		public S2ByteMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(string key); // 0x000000018B63F580-0x000000018B63F5C4
		public string GetKeyByIndex(int index); // 0x00000001863912D0-0x0000000186391320
		public byte GetValue(string key); // 0x000000018D6CA2B4-0x000000018D6CA2F8
		public bool TryGetValue(string key, out byte value); // 0x000000018D6CA3F8-0x000000018D6CA43C
		public byte GetValueByIndex(int index); // 0x000000018D6BF1C4-0x000000018D6BF208
		public MapEnumerator<string, byte, S2ByteMap> GetEnumerator(); // 0x000000018D6CA1DC-0x000000018D6CA2B4
		IEnumerator<KeyValuePair<string, byte>> IEnumerable<KeyValuePair<string, byte>>.GetEnumerator(); // 0x000000018D6CA2F8-0x000000018D6CA378
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6CA378-0x000000018D6CA3F8
	}

	public struct S2IntMap : IMapWrapper<string, int, S2IntMap>, IEnumerable<KeyValuePair<string, int>> // TypeDefIndex: 88442
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public int this[string key] { get => default; } // 0x0000000185744CD0-0x0000000185744DB0 
	
		// Constructors
		public S2IntMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(string key); // 0x0000000185742E60-0x0000000185742EB0
		public string GetKeyByIndex(int index); // 0x00000001863912D0-0x0000000186391320
		public int GetValue(string key); // 0x0000000185744DB0-0x0000000185744E60
		public bool TryGetValue(string key, out int value); // 0x000000018584EF00-0x000000018584EFB0
		public int GetValueByIndex(int index); // 0x000000018D6BF804-0x000000018D6BF848
		public MapEnumerator<string, int, S2IntMap> GetEnumerator(); // 0x000000018D6CA8FC-0x000000018D6CA9D4
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator(); // 0x000000018D6CA9D4-0x000000018D6CAA54
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6CAA54-0x000000018D6CAAD4
	}

	public struct S2LongMap : IMapWrapper<string, long, S2LongMap>, IEnumerable<KeyValuePair<string, long>> // TypeDefIndex: 88443
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public long this[string key] { get => default; } // 0x000000018D6CABAC-0x000000018D6CABF0 
	
		// Constructors
		public S2LongMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(string key); // 0x000000018B63F580-0x000000018B63F5C4
		public string GetKeyByIndex(int index); // 0x00000001863912D0-0x0000000186391320
		public long GetValue(string key); // 0x000000018D6CABAC-0x000000018D6CABF0
		public bool TryGetValue(string key, out long value); // 0x000000018D6CACF0-0x000000018D6CAD34
		public long GetValueByIndex(int index); // 0x000000018D6BFAA0-0x000000018D6BFAE4
		public MapEnumerator<string, long, S2LongMap> GetEnumerator(); // 0x000000018D6CAAD4-0x000000018D6CABAC
		IEnumerator<KeyValuePair<string, long>> IEnumerable<KeyValuePair<string, long>>.GetEnumerator(); // 0x000000018D6CABF0-0x000000018D6CAC70
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6CAC70-0x000000018D6CACF0
	}

	public struct S2FloatMap : IMapWrapper<string, float, S2FloatMap>, IEnumerable<KeyValuePair<string, float>> // TypeDefIndex: 88444
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public float this[string key] { get => default; } // 0x000000018D6CA774-0x000000018D6CA7B8 
	
		// Constructors
		public S2FloatMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(string key); // 0x000000018B63F580-0x000000018B63F5C4
		public string GetKeyByIndex(int index); // 0x00000001863912D0-0x0000000186391320
		public float GetValue(string key); // 0x000000018D6CA774-0x000000018D6CA7B8
		public bool TryGetValue(string key, out float value); // 0x000000018D6CA8B8-0x000000018D6CA8FC
		public float GetValueByIndex(int index); // 0x000000018D6C4AE4-0x000000018D6C4B28
		public MapEnumerator<string, float, S2FloatMap> GetEnumerator(); // 0x000000018D6CA69C-0x000000018D6CA774
		IEnumerator<KeyValuePair<string, float>> IEnumerable<KeyValuePair<string, float>>.GetEnumerator(); // 0x000000018D6CA7B8-0x000000018D6CA838
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6CA838-0x000000018D6CA8B8
	}

	public struct S2DoubleMap : IMapWrapper<string, double, S2DoubleMap>, IEnumerable<KeyValuePair<string, double>> // TypeDefIndex: 88445
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public double this[string key] { get => default; } // 0x000000018D6CA514-0x000000018D6CA558 
	
		// Constructors
		public S2DoubleMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(string key); // 0x000000018B63F580-0x000000018B63F5C4
		public string GetKeyByIndex(int index); // 0x00000001863912D0-0x0000000186391320
		public double GetValue(string key); // 0x000000018D6CA514-0x000000018D6CA558
		public bool TryGetValue(string key, out double value); // 0x000000018D6CA658-0x000000018D6CA69C
		public double GetValueByIndex(int index); // 0x000000018D6BF460-0x000000018D6BF4A4
		public MapEnumerator<string, double, S2DoubleMap> GetEnumerator(); // 0x000000018D6CA43C-0x000000018D6CA514
		IEnumerator<KeyValuePair<string, double>> IEnumerable<KeyValuePair<string, double>>.GetEnumerator(); // 0x000000018D6CA558-0x000000018D6CA5D8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6CA5D8-0x000000018D6CA658
	}

	public struct S2StringMap : IMapWrapper<string, string, S2StringMap>, IEnumerable<KeyValuePair<string, string>> // TypeDefIndex: 88446
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public string this[string key] { get => default; } // 0x000000018D6CAE0C-0x000000018D6CAE50 
	
		// Constructors
		public S2StringMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(string key); // 0x000000018B63F580-0x000000018B63F5C4
		public string GetKeyByIndex(int index); // 0x00000001863912D0-0x0000000186391320
		public string GetValue(string key); // 0x000000018D6CAE0C-0x000000018D6CAE50
		public bool TryGetValue(string key, out string value); // 0x0000000185FBE6F0-0x0000000185FBE780
		public string GetValueByIndex(int index); // 0x000000018D6C516C-0x000000018D6C51B0
		public MapEnumerator<string, string, S2StringMap> GetEnumerator(); // 0x000000018D6CAD34-0x000000018D6CAE0C
		IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator(); // 0x000000018D6CAE50-0x000000018D6CAED0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6CAED0-0x000000018D6CAF50
	}

	public struct I2NullableBeanMap<TBean> : IMapWrapper<int, TBean?, I2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<int, TBean?>> // TypeDefIndex: 88447
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get; }
		public int Count { get; }
		public TBean? this[int key] { get => default; }
	
		// Constructors
		public I2NullableBeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator);
	
		// Methods
		public bool ContainsKey(int key);
		public int GetKeyByIndex(int index);
		public TBean? GetValue(int key);
		public bool TryGetValue(int key, out TBean? value);
		public TBean? GetValueByIndex(int index);
		public MapEnumerator<int, TBean?, I2NullableBeanMap<TBean>> GetEnumerator();
		IEnumerator<KeyValuePair<int, TBean?>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,TBean?>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public struct I2BeanMap<TBean> : IMapWrapper<int, TBean, I2BeanMap<TBean>>, IEnumerable<KeyValuePair<int, TBean>> // TypeDefIndex: 88448
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get; }
		public int Count { get; }
		public TBean this[int key] { get => default; }
	
		// Constructors
		public I2BeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator);
	
		// Methods
		public bool ContainsKey(int key);
		public int GetKeyByIndex(int index);
		public TBean GetValue(int key);
		public bool TryGetValue(int key, out ref TBean value);
		public TBean GetValueByIndex(int index);
		public MapEnumerator<int, TBean, I2BeanMap<TBean>> GetEnumerator();
		IEnumerator<KeyValuePair<int, TBean>> IEnumerable<KeyValuePair<int, TBean>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public struct I2EnumMap<TEnum> : IMapWrapper<int, TEnum, I2EnumMap<TEnum>>, IEnumerable<KeyValuePair<int, TEnum>> // TypeDefIndex: 88449
		where TEnum : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private Func<int, TEnum> m_converter;
	
		// Properties
		public int count { get; }
		public int Count { get; }
		public TEnum this[int key] { get => default; }
	
		// Constructors
		public I2EnumMap(Beyond.SparkBuffer.Runtime.Map map, Func<int, TEnum> converter);
	
		// Methods
		public bool ContainsKey(int key);
		public int GetKeyByIndex(int index);
		public TEnum GetValue(int key);
		public bool TryGetValue(int key, out ref TEnum value);
		public TEnum GetValueByIndex(int index);
		public MapEnumerator<int, TEnum, I2EnumMap<TEnum>> GetEnumerator();
		IEnumerator<KeyValuePair<int, TEnum>> IEnumerable<KeyValuePair<int, TEnum>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public struct I2BoolMap : IMapWrapper<int, bool, I2BoolMap>, IEnumerable<KeyValuePair<int, bool>> // TypeDefIndex: 88450
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public bool this[int key] { get => default; } // 0x000000018D6BEF6C-0x000000018D6BEFB0 
	
		// Constructors
		public I2BoolMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018AA34664-0x000000018AA346A8
		public int GetKeyByIndex(int index); // 0x00000001852A2CE0-0x00000001852A2EE0
		public bool GetValue(int key); // 0x000000018D6BEF6C-0x000000018D6BEFB0
		public bool TryGetValue(int key, out bool value); // 0x000000018D6BF0B0-0x000000018D6BF0F4
		public bool GetValueByIndex(int index); // 0x000000018D6BEF28-0x000000018D6BEF6C
		public MapEnumerator<int, bool, I2BoolMap> GetEnumerator(); // 0x000000018D6BEE58-0x000000018D6BEF28
		IEnumerator<KeyValuePair<int, bool>> IEnumerable<KeyValuePair<int, bool>>.GetEnumerator(); // 0x000000018D6BEFB0-0x000000018D6BF030
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BF030-0x000000018D6BF0B0
	}

	public struct I2ByteMap : IMapWrapper<int, byte, I2ByteMap>, IEnumerable<KeyValuePair<int, byte>> // TypeDefIndex: 88451
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public byte this[int key] { get => default; } // 0x000000018D6BF208-0x000000018D6BF24C 
	
		// Constructors
		public I2ByteMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018AA34664-0x000000018AA346A8
		public int GetKeyByIndex(int index); // 0x00000001852A2CE0-0x00000001852A2EE0
		public byte GetValue(int key); // 0x000000018D6BF208-0x000000018D6BF24C
		public bool TryGetValue(int key, out byte value); // 0x000000018D6BF34C-0x000000018D6BF390
		public byte GetValueByIndex(int index); // 0x000000018D6BF1C4-0x000000018D6BF208
		public MapEnumerator<int, byte, I2ByteMap> GetEnumerator(); // 0x000000018D6BF0F4-0x000000018D6BF1C4
		IEnumerator<KeyValuePair<int, byte>> IEnumerable<KeyValuePair<int, byte>>.GetEnumerator(); // 0x000000018D6BF24C-0x000000018D6BF2CC
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BF2CC-0x000000018D6BF34C
	}

	public struct I2IntMap : IMapWrapper<int, int, I2IntMap>, IEnumerable<KeyValuePair<int, int>> // TypeDefIndex: 88452
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public int this[int key] { get => default; } // 0x000000018D6BF848-0x000000018D6BF88C 
	
		// Constructors
		public I2IntMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018AA34664-0x000000018AA346A8
		public int GetKeyByIndex(int index); // 0x00000001852A2CE0-0x00000001852A2EE0
		public int GetValue(int key); // 0x000000018D6BF848-0x000000018D6BF88C
		public bool TryGetValue(int key, out int value); // 0x000000018D6BF98C-0x000000018D6BF9D0
		public int GetValueByIndex(int index); // 0x000000018D6BF804-0x000000018D6BF848
		public MapEnumerator<int, int, I2IntMap> GetEnumerator(); // 0x000000018D6BF734-0x000000018D6BF804
		IEnumerator<KeyValuePair<int, int>> IEnumerable<KeyValuePair<int, int>>.GetEnumerator(); // 0x000000018D6BF88C-0x000000018D6BF90C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BF90C-0x000000018D6BF98C
	}

	public struct I2LongMap : IMapWrapper<int, long, I2LongMap>, IEnumerable<KeyValuePair<int, long>> // TypeDefIndex: 88453
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public long this[int key] { get => default; } // 0x000000018D6BFAE4-0x000000018D6BFB28 
	
		// Constructors
		public I2LongMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018AA34664-0x000000018AA346A8
		public int GetKeyByIndex(int index); // 0x00000001852A2CE0-0x00000001852A2EE0
		public long GetValue(int key); // 0x000000018D6BFAE4-0x000000018D6BFB28
		public bool TryGetValue(int key, out long value); // 0x000000018D6BFC28-0x000000018D6BFC6C
		public long GetValueByIndex(int index); // 0x000000018D6BFAA0-0x000000018D6BFAE4
		public MapEnumerator<int, long, I2LongMap> GetEnumerator(); // 0x000000018D6BF9D0-0x000000018D6BFAA0
		IEnumerator<KeyValuePair<int, long>> IEnumerable<KeyValuePair<int, long>>.GetEnumerator(); // 0x000000018D6BFB28-0x000000018D6BFBA8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BFBA8-0x000000018D6BFC28
	}

	public struct I2FloatMap : IMapWrapper<int, float, I2FloatMap>, IEnumerable<KeyValuePair<int, float>> // TypeDefIndex: 88454
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public float this[int key] { get => default; } // 0x000000018D6BF62C-0x000000018D6BF670 
	
		// Constructors
		public I2FloatMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018AA34664-0x000000018AA346A8
		public int GetKeyByIndex(int index); // 0x00000001852A2CE0-0x00000001852A2EE0
		public float GetValue(int key); // 0x000000018D6BF62C-0x000000018D6BF670
		public bool TryGetValue(int key, out float value); // 0x000000018D6BF6F0-0x000000018D6BF734
		public float GetValueByIndex(int index); // 0x00000001860A1D60-0x00000001860A1DD0
		public MapEnumerator<int, float, I2FloatMap> GetEnumerator(); // 0x0000000187066E70-0x0000000187066EF0
		IEnumerator<KeyValuePair<int, float>> IEnumerable<KeyValuePair<int, float>>.GetEnumerator(); // 0x0000000187066DF0-0x0000000187066E70
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BF670-0x000000018D6BF6F0
	}

	public struct I2DoubleMap : IMapWrapper<int, double, I2DoubleMap>, IEnumerable<KeyValuePair<int, double>> // TypeDefIndex: 88455
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public double this[int key] { get => default; } // 0x000000018D6BF4A4-0x000000018D6BF4E8 
	
		// Constructors
		public I2DoubleMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018AA34664-0x000000018AA346A8
		public int GetKeyByIndex(int index); // 0x00000001852A2CE0-0x00000001852A2EE0
		public double GetValue(int key); // 0x000000018D6BF4A4-0x000000018D6BF4E8
		public bool TryGetValue(int key, out double value); // 0x000000018D6BF5E8-0x000000018D6BF62C
		public double GetValueByIndex(int index); // 0x000000018D6BF460-0x000000018D6BF4A4
		public MapEnumerator<int, double, I2DoubleMap> GetEnumerator(); // 0x000000018D6BF390-0x000000018D6BF460
		IEnumerator<KeyValuePair<int, double>> IEnumerable<KeyValuePair<int, double>>.GetEnumerator(); // 0x000000018D6BF4E8-0x000000018D6BF568
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BF568-0x000000018D6BF5E8
	}

	public struct I2StringMap : IMapWrapper<int, string, I2StringMap>, IEnumerable<KeyValuePair<int, string>> // TypeDefIndex: 88456
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public string this[int key] { get => default; } // 0x00000001852CD6D0-0x00000001852CD9B0 
	
		// Constructors
		public I2StringMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(int key); // 0x00000001852CD1A0-0x00000001852CD450
		public int GetKeyByIndex(int index); // 0x00000001852A2CE0-0x00000001852A2EE0
		public string GetValue(int key); // 0x000000018635F770-0x000000018635F7C0
		public bool TryGetValue(int key, out string value); // 0x00000001855CDA00-0x00000001855CDAA0
		public string GetValueByIndex(int index); // 0x00000001852A2C40-0x00000001852A2CB0
		public MapEnumerator<int, string, I2StringMap> GetEnumerator(); // 0x0000000186136800-0x0000000186136880
		IEnumerator<KeyValuePair<int, string>> IEnumerable<KeyValuePair<int, string>>.GetEnumerator(); // 0x000000018D6BFC6C-0x000000018D6BFCEC
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6BFCEC-0x000000018D6BFD6C
	}

	public struct L2BoolMap : IMapWrapper<long, bool, L2BoolMap>, IEnumerable<KeyValuePair<long, bool>> // TypeDefIndex: 88457
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public bool this[long key] { get => default; } // 0x000000018D6C4184-0x000000018D6C41C8 
	
		// Constructors
		public L2BoolMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(long key); // 0x000000018ABC1614-0x000000018ABC1658
		public long GetKeyByIndex(int index); // 0x000000018ABC1658-0x000000018ABC169C
		public bool GetValue(long key); // 0x000000018D6C4184-0x000000018D6C41C8
		public bool TryGetValue(long key, out bool value); // 0x000000018D6C42C8-0x000000018D6C430C
		public bool GetValueByIndex(int index); // 0x000000018D6BEF28-0x000000018D6BEF6C
		public MapEnumerator<long, bool, L2BoolMap> GetEnumerator(); // 0x000000018D6C40B4-0x000000018D6C4184
		IEnumerator<KeyValuePair<long, bool>> IEnumerable<KeyValuePair<long, bool>>.GetEnumerator(); // 0x000000018D6C41C8-0x000000018D6C4248
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6C4248-0x000000018D6C42C8
	}

	public struct L2ByteMap : IMapWrapper<long, byte, L2ByteMap>, IEnumerable<KeyValuePair<long, byte>> // TypeDefIndex: 88458
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public byte this[long key] { get => default; } // 0x000000018D6C43DC-0x000000018D6C4420 
	
		// Constructors
		public L2ByteMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(long key); // 0x000000018ABC1614-0x000000018ABC1658
		public long GetKeyByIndex(int index); // 0x000000018ABC1658-0x000000018ABC169C
		public byte GetValue(long key); // 0x000000018D6C43DC-0x000000018D6C4420
		public bool TryGetValue(long key, out byte value); // 0x000000018D6C4520-0x000000018D6C4564
		public byte GetValueByIndex(int index); // 0x000000018D6BF1C4-0x000000018D6BF208
		public MapEnumerator<long, byte, L2ByteMap> GetEnumerator(); // 0x000000018D6C430C-0x000000018D6C43DC
		IEnumerator<KeyValuePair<long, byte>> IEnumerable<KeyValuePair<long, byte>>.GetEnumerator(); // 0x000000018D6C4420-0x000000018D6C44A0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6C44A0-0x000000018D6C4520
	}

	public struct L2IntMap : IMapWrapper<long, int, L2IntMap>, IEnumerable<KeyValuePair<long, int>> // TypeDefIndex: 88459
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public int this[long key] { get => default; } // 0x000000018D6C488C-0x000000018D6C48D0 
	
		// Constructors
		public L2IntMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(long key); // 0x000000018ABC1614-0x000000018ABC1658
		public long GetKeyByIndex(int index); // 0x000000018ABC1658-0x000000018ABC169C
		public int GetValue(long key); // 0x000000018D6C488C-0x000000018D6C48D0
		public bool TryGetValue(long key, out int value); // 0x000000018D6C49D0-0x000000018D6C4A14
		public int GetValueByIndex(int index); // 0x000000018D6BF804-0x000000018D6BF848
		public MapEnumerator<long, int, L2IntMap> GetEnumerator(); // 0x000000018D6C4CB0-0x000000018D6C4D80
		IEnumerator<KeyValuePair<long, int>> IEnumerable<KeyValuePair<long, int>>.GetEnumerator(); // 0x000000018D6C4D80-0x000000018D6C4E00
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6C4E00-0x000000018D6C4E80
	}

	public struct L2LongMap : IMapWrapper<long, long, L2LongMap>, IEnumerable<KeyValuePair<long, long>> // TypeDefIndex: 88460
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public long this[long key] { get => default; } // 0x000000018D6C4F50-0x000000018D6C4F94 
	
		// Constructors
		public L2LongMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(long key); // 0x000000018ABC1614-0x000000018ABC1658
		public long GetKeyByIndex(int index); // 0x000000018ABC1658-0x000000018ABC169C
		public long GetValue(long key); // 0x000000018D6C4F50-0x000000018D6C4F94
		public bool TryGetValue(long key, out long value); // 0x0000000185C1EE80-0x0000000185C1EEF0
		public long GetValueByIndex(int index); // 0x000000018D6BFAA0-0x000000018D6BFAE4
		public MapEnumerator<long, long, L2LongMap> GetEnumerator(); // 0x000000018D6C4E80-0x000000018D6C4F50
		IEnumerator<KeyValuePair<long, long>> IEnumerable<KeyValuePair<long, long>>.GetEnumerator(); // 0x000000018D6C4F94-0x000000018D6C5014
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6C5014-0x000000018D6C5094
	}

	public struct L2FloatMap : IMapWrapper<long, float, L2FloatMap>, IEnumerable<KeyValuePair<long, float>> // TypeDefIndex: 88461
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public float this[long key] { get => default; } // 0x000000018D6C4B28-0x000000018D6C4B6C 
	
		// Constructors
		public L2FloatMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(long key); // 0x000000018ABC1614-0x000000018ABC1658
		public long GetKeyByIndex(int index); // 0x000000018ABC1658-0x000000018ABC169C
		public float GetValue(long key); // 0x000000018D6C4B28-0x000000018D6C4B6C
		public bool TryGetValue(long key, out float value); // 0x000000018D6C4C6C-0x000000018D6C4CB0
		public float GetValueByIndex(int index); // 0x000000018D6C4AE4-0x000000018D6C4B28
		public MapEnumerator<long, float, L2FloatMap> GetEnumerator(); // 0x000000018D6C4A14-0x000000018D6C4AE4
		IEnumerator<KeyValuePair<long, float>> IEnumerable<KeyValuePair<long, float>>.GetEnumerator(); // 0x000000018D6C4B6C-0x000000018D6C4BEC
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6C4BEC-0x000000018D6C4C6C
	}

	public struct L2DoubleMap : IMapWrapper<long, double, L2DoubleMap>, IEnumerable<KeyValuePair<long, double>> // TypeDefIndex: 88462
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public double this[long key] { get => default; } // 0x000000018D6C4634-0x000000018D6C4678 
	
		// Constructors
		public L2DoubleMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(long key); // 0x000000018ABC1614-0x000000018ABC1658
		public long GetKeyByIndex(int index); // 0x000000018ABC1658-0x000000018ABC169C
		public double GetValue(long key); // 0x000000018D6C4634-0x000000018D6C4678
		public bool TryGetValue(long key, out double value); // 0x000000018D6C4778-0x000000018D6C47BC
		public double GetValueByIndex(int index); // 0x000000018D6BF460-0x000000018D6BF4A4
		public MapEnumerator<long, double, L2DoubleMap> GetEnumerator(); // 0x000000018D6C4564-0x000000018D6C4634
		IEnumerator<KeyValuePair<long, double>> IEnumerable<KeyValuePair<long, double>>.GetEnumerator(); // 0x000000018D6C4678-0x000000018D6C46F8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6C46F8-0x000000018D6C4778
	}

	public struct L2StringMap : IMapWrapper<long, string, L2StringMap>, IEnumerable<KeyValuePair<long, string>> // TypeDefIndex: 88463
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public string this[long key] { get => default; } // 0x000000018D6C51B0-0x000000018D6C51F4 
	
		// Constructors
		public L2StringMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(long key); // 0x000000018ABC1614-0x000000018ABC1658
		public long GetKeyByIndex(int index); // 0x000000018ABC1658-0x000000018ABC169C
		public string GetValue(long key); // 0x000000018D6C51B0-0x000000018D6C51F4
		public bool TryGetValue(long key, out string value); // 0x0000000185C1ED50-0x0000000185C1EDF0
		public string GetValueByIndex(int index); // 0x000000018D6C516C-0x000000018D6C51B0
		public MapEnumerator<long, string, L2StringMap> GetEnumerator(); // 0x000000018D6C5094-0x000000018D6C516C
		IEnumerator<KeyValuePair<long, string>> IEnumerable<KeyValuePair<long, string>>.GetEnumerator(); // 0x000000018D6C51F4-0x000000018D6C5274
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6C5274-0x000000018D6C52F4
	}

	public struct L2EnumMap : IMapWrapper<long, int, L2EnumMap>, IEnumerable<KeyValuePair<long, int>> // TypeDefIndex: 88464
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x000000018459A400-0x000000018459A420 
		public int Count { get; } // 0x000000018459A400-0x000000018459A420 
		public int this[long key] { get => default; } // 0x000000018D6C488C-0x000000018D6C48D0 
	
		// Constructors
		public L2EnumMap(Beyond.SparkBuffer.Runtime.Map map); // 0x000000018C20A594-0x000000018C20A5C8
	
		// Methods
		public bool ContainsKey(long key); // 0x000000018ABC1614-0x000000018ABC1658
		public long GetKeyByIndex(int index); // 0x000000018ABC1658-0x000000018ABC169C
		public int GetValue(long key); // 0x000000018D6C488C-0x000000018D6C48D0
		public bool TryGetValue(long key, out int value); // 0x000000018D6C49D0-0x000000018D6C4A14
		public int GetValueByIndex(int index); // 0x000000018D6BF804-0x000000018D6BF848
		public MapEnumerator<long, int, L2EnumMap> GetEnumerator(); // 0x000000018D6C47BC-0x000000018D6C488C
		IEnumerator<KeyValuePair<long, int>> IEnumerable<KeyValuePair<long, int>>.GetEnumerator(); // 0x000000018D6C48D0-0x000000018D6C4950
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6C4950-0x000000018D6C49D0
	}

	public struct L2NullableBeanMap<TBean> : IMapWrapper<long, TBean?, L2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<long, TBean?>> // TypeDefIndex: 88465
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get; }
		public int Count { get; }
		public TBean? this[long key] { get => default; }
	
		// Constructors
		public L2NullableBeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator);
	
		// Methods
		public bool ContainsKey(long key);
		public long GetKeyByIndex(int index);
		public TBean? GetValue(long key);
		public bool TryGetValue(long key, out TBean? value);
		public TBean? GetValueByIndex(int index);
		public MapEnumerator<long, TBean?, L2NullableBeanMap<TBean>> GetEnumerator();
		IEnumerator<KeyValuePair<long, TBean?>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,TBean?>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public struct L2BeanMap<TBean> : IMapWrapper<long, TBean, L2BeanMap<TBean>>, IEnumerable<KeyValuePair<long, TBean>> // TypeDefIndex: 88466
		where TBean : struct
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map;
		private readonly Func<Bean, TBean> m_creator;
	
		// Properties
		public int count { get; }
		public int Count { get; }
		public TBean this[long key] { get => default; }
	
		// Constructors
		public L2BeanMap(Beyond.SparkBuffer.Runtime.Map map, Func<Bean, TBean> creator);
	
		// Methods
		public bool ContainsKey(long key);
		public long GetKeyByIndex(int index);
		public TBean GetValue(long key);
		public bool TryGetValue(long key, out ref TBean value);
		public TBean GetValueByIndex(int index);
		public MapEnumerator<long, TBean, L2BeanMap<TBean>> GetEnumerator();
		IEnumerator<KeyValuePair<long, TBean>> IEnumerable<KeyValuePair<long, TBean>>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}
}

namespace Beyond.SparkBuffer.Serialize
{
	internal static class Extensions // TypeDefIndex: 88467
	{
		// Extension methods
		public static bool Contains<T>(this IList<T> list, T element);
		public static bool IsNullOrEmpty<T>(this IList<T> list);
		public static bool IsNullOrEmpty<T>(this ICollection<T> list);
		public static bool IsNullOrEmpty(this OrderedDictionary dict); // 0x000000018D6BED34-0x000000018D6BED54
		public static T[] ToArrayE<T>(this IEnumerable<T> enumerable);
		public static T GetValue<T>(this DictionaryEntry entry)
			where T : class;
	}

	public class JsonSerializer // TypeDefIndex: 88468
	{
		// Constructors
		public JsonSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static string Serialize<T>(T obj, bool indented);
		public static string Serialize(object obj, bool indented); // 0x000000018D6C38A0-0x000000018D6C38D0
		private static string _SerializeDirect(ObjectReflector.ReflectObject reflectObj, bool indented); // 0x000000018D6C38D0-0x000000018D6C3AD8
		private static void _WriteReflectObj(JsonWriter writer, ObjectReflector.ReflectObject reflectObj); // 0x000000018D6C3AD8-0x000000018D6C40B4
	}

	internal class ObjectReflector // TypeDefIndex: 88474
	{
		// Fields
		private List<object> m_tempList; // 0x10
		private Dictionary<System.Type, ReflectType> m_typeMap; // 0x18
	
		// Nested types
		public struct ReflectResult // TypeDefIndex: 88469
		{
			// Fields
			public ReflectType[] types; // 0x00
			public ReflectObject rootObj; // 0x08
		}
	
		public class ReflectType // TypeDefIndex: 88471
		{
			// Fields
			public SparkType sparkType; // 0x10
			public System.Type concreteType; // 0x18
			public ReflectType subType1; // 0x20
			public ReflectType subType2; // 0x28
			public List<FieldInfo> beanFields; // 0x30
	
			// Nested types
			public struct FieldInfo // TypeDefIndex: 88470
			{
				// Fields
				public string name; // 0x00
				public ReflectType type; // 0x08
			}
	
			// Constructors
			public ReflectType(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class ReflectObject // TypeDefIndex: 88472
		{
			// Fields
			public object originObj; // 0x10
			public ReflectType reflectType; // 0x18
			public OrderedDictionary beanElements; // 0x20
			public List<ReflectObject> arrayElements; // 0x28
			public List<KeyValuePair<ReflectObject, ReflectObject>> mapElements; // 0x30
	
			// Constructors
			public ReflectObject(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 88473
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<ReflectType> __9__7_0; // 0x08
			public static Comparison<ReflectType.FieldInfo> __9__9_0; // 0x10
			public static Comparison<KeyValuePair<ReflectObject, ReflectObject>> __9__13_0; // 0x18
			public static Func<System.Reflection.FieldInfo, int> __9__14_0; // 0x20
	
			// Constructors
			static __c(); // 0x000000018D6CF17C-0x000000018D6CF1E0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int __ParseInternal_b__7_0(ReflectType lhs, ReflectType rhs); // 0x000000018D6CF018-0x000000018D6CF060
			internal int __TryParseType_b__9_0(ReflectType.FieldInfo lhs, ReflectType.FieldInfo rhs); // 0x000000018D6CF134-0x000000018D6CF14C
			internal int __ReflectMap_b__13_0(KeyValuePair<ReflectObject, ReflectObject> lhs, KeyValuePair<ReflectObject, ReflectObject> rhs); // 0x000000018D6CF060-0x000000018D6CF134
			internal int __GetFields_b__14_0(System.Reflection.FieldInfo field); // 0x000000018D6CEFF8-0x000000018D6CF018
		}
	
		// Constructors
		private ObjectReflector(); // 0x000000018D6C923C-0x000000018D6C92FC
	
		// Methods
		public static ReflectResult Parse(object obj); // 0x000000018D6C6BA8-0x000000018D6C6C2C
		private ReflectResult _ParseInternal(object obj); // 0x000000018D6C6F20-0x000000018D6C7238
		private ReflectType _ParseTypeMap(System.Type rootType); // 0x000000018D6C7238-0x000000018D6C7314
		private bool _TryParseType(System.Type type, out ReflectType reflectType); // 0x000000018D6C82A0-0x000000018D6C923C
		private ReflectObject _ReflectObject(object obj, ReflectType reflectType); // 0x000000018D6C8110-0x000000018D6C82A0
		private ReflectObject _ReflectBean(object obj, ReflectType reflectType); // 0x000000018D6C7870-0x000000018D6C7DA8
		private ReflectObject _ReflectArray(object obj, ReflectType reflectType); // 0x000000018D6C7314-0x000000018D6C7870
		private ReflectObject _ReflectMap(object obj, ReflectType reflectType); // 0x000000018D6C7DA8-0x000000018D6C8110
		private IEnumerable<System.Reflection.FieldInfo> _GetFields(System.Type type); // 0x000000018D6C6DFC-0x000000018D6C6F20
		private object[] _ConvertICollectionToArray(ICollection collection); // 0x000000018D6C6C2C-0x000000018D6C6DFC
	}

	public class SparkSerializer : IDisposable // TypeDefIndex: 88479
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
		private struct ReservedField // TypeDefIndex: 88475
		{
			// Fields
			public int position; // 0x00
			public ObjectReflector.ReflectObject reflectObj; // 0x08
		}
	
		public struct Options // TypeDefIndex: 88476
		{
			// Fields
			public static readonly Options DEFAULT; // 0x00
			public string rootName; // 0x00
			public string stripTypeNamePrefix; // 0x08
	
			// Constructors
			public Options(string rootName); // 0x00000001857D1B40-0x00000001857D1BD0
			public Options(string rootName, string stripTypeNamePrefix); // 0x0000000185B2C340-0x0000000185B2C370
			static Options(); // 0x000000018D6D04D4-0x000000018D6D056C
		}
	
		private struct HashSlot // TypeDefIndex: 88477
		{
			// Fields
			public int offset; // 0x00
			public int bucketsSize; // 0x04
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 88478
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<string> __9__23_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D6D2530-0x000000018D6D2594
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int __ExportStrings_b__23_0(string lhs, string rhs); // 0x000000018C976C40-0x000000018C976C54
		}
	
		// Constructors
		private SparkSerializer(Options options); // 0x000000018D6CED98-0x000000018D6CEF8C
	
		// Methods
		public static byte[] Serialize<T>(T obj);
		public static byte[] Serialize<T>(T obj, Options options);
		public static byte[] Serialize(object obj); // 0x000000018D6CB6D4-0x000000018D6CB734
		public static byte[] Serialize(object obj, Options options); // 0x000000018D6CB734-0x000000018D6CB858
		public void Dispose(); // 0x000000018D6CB688-0x000000018D6CB6A8
		private byte[] _SerializeInternal(object obj); // 0x000000018D6CEB48-0x000000018D6CECB8
		private void _PreprocessTypes(ObjectReflector.ReflectType[] reflectTypes); // 0x000000018D6CE93C-0x000000018D6CEB48
		private void _ExportTypeDefs(); // 0x000000018D6CE3B0-0x000000018D6CE658
		private void _ExportEnumType(ObjectReflector.ReflectType enumType); // 0x000000018D6CD204-0x000000018D6CD64C
		private void _ExportBeanType(ObjectReflector.ReflectType beanType); // 0x000000018D6CC9E8-0x000000018D6CCD34
		private string _ParseTypeName(System.Type reflectType); // 0x000000018D6CE8D0-0x000000018D6CE93C
		private static HashSet<string> _CollectAllStrings(ObjectReflector.ReflectObject rootObj); // 0x000000018D6CB8E4-0x000000018D6CBF98
		private List<List<string>> _GenStringHashList(HashSet<string> strings); // 0x000000018D6CE658-0x000000018D6CE8D0
		private void _ExportStrings(ObjectReflector.ReflectObject rootObj); // 0x000000018D6CE114-0x000000018D6CE3B0
		private void _ExportElementData(ObjectReflector.ReflectObject elementObj, List<ReservedField> reservedFields); // 0x000000018D6CCE28-0x000000018D6CD204
		private int _ExportBeanData(ObjectReflector.ReflectObject beanObj); // 0x000000018D6CC614-0x000000018D6CC9E8
		private int _ExportArrayData(ObjectReflector.ReflectObject arrayObj); // 0x000000018D6CC3B0-0x000000018D6CC614
		private int _ExportMapData(ObjectReflector.ReflectObject mapObj); // 0x000000018D6CD64C-0x000000018D6CDCB8
		private Dictionary<int, List<KeyValuePair<ObjectReflector.ReflectObject, ObjectReflector.ReflectObject>>> _CreateMapHashEntry(List<KeyValuePair<ObjectReflector.ReflectObject, ObjectReflector.ReflectObject>> mapElements, SparkType keyType); // 0x000000018D6CBF98-0x000000018D6CC3B0
		private void _ExportRootDef(ObjectReflector.ReflectType rootType); // 0x000000018D6CDF34-0x000000018D6CE114
		private int _ExportDataFromRoot(ObjectReflector.ReflectObject rootObj); // 0x000000018D6CCD34-0x000000018D6CCE28
		private void _ExportReservedFields(List<ReservedField> reservedFields); // 0x000000018D6CDCB8-0x000000018D6CDF34
		public static int GetStableStringHash(string str); // 0x00000001850726F0-0x0000000185072790
		public static int GetStableTypeHash(System.Type type); // 0x000000018D6CB6A8-0x000000018D6CB6D4
		private void _WriteConcreteType(System.Type type); // 0x000000018D6CECB8-0x000000018D6CED98
		[CompilerGenerated]
		private int __ExportTypeDefs_b__17_0(ObjectReflector.ReflectType lhs, ObjectReflector.ReflectType rhs); // 0x000000018D6CB858-0x000000018D6CB8E4
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 88485
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018D6D0110-0x000000018D6D0174
	
		// Methods
		public IntPtr __Gen_Wrap_0(object P0); // 0x0000000188AB6D9C-0x0000000188AB6E5C
		public IntPtr __Gen_Wrap_1(ReadOnlySpan<byte> P0); // 0x000000018D6CFABC-0x000000018D6CFBB4
		public ReadOnlySpan<byte> __Gen_Wrap_2(IntPtr P0, int P1); // 0x000000018D6CFBB4-0x000000018D6CFCD0
		public IntPtr __Gen_Wrap_3(int P0); // 0x000000018D6CFCD0-0x000000018D6CFD90
		public void __Gen_Wrap_4(int P0, IntPtr P1); // 0x000000018D6CFD90-0x000000018D6CFE5C
		public void __Gen_Wrap_5(); // 0x00000001887ED074-0x00000001887ED104
		public string __Gen_Wrap_6(); // 0x000000018D6CFE5C-0x000000018D6CFF18
		public void __Gen_Wrap_7(object P0, IntPtr P1); // 0x0000000188B4B034-0x0000000188B4B104
		public StructPtrWrapper __Gen_Wrap_8(IntPtr P0, int P1, object P2); // 0x000000018D6CFF18-0x000000018D6D0030
		public StructPtrWrapper __Gen_Wrap_9(object P0); // 0x000000018D6D0030-0x000000018D6D0110
		public void __Gen_Wrap_10(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public object __Gen_Wrap_11(object P0); // 0x000000018D6CF648-0x000000018D6CF728
		public object __Gen_Wrap_12(IntPtr P0, object P1, int P2); // 0x000000018D6CF728-0x000000018D6CF840
		public void __Gen_Wrap_13(object P0, object P1); // 0x0000000188B47220-0x0000000188B472F0
		public int __Gen_Wrap_14(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public bool __Gen_Wrap_15(object P0, object P1); // 0x00000001887F2FB4-0x00000001887F3094
		public string __Gen_Wrap_16(object P0); // 0x000000018D6CF840-0x000000018D6CF920
		public System.Type __Gen_Wrap_17(object P0); // 0x000000018D6CF920-0x000000018D6CFA00
		public StructPtrWrapper __Gen_Wrap_18(); // 0x000000018D6CFA00-0x000000018D6CFABC
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 88486
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018D6D0174-0x000000018D6D020C
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 88487
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018D6D2780-0x000000018D6D27E4
		public static bool IsPatched(int id); // 0x000000018D6D2870-0x000000018D6D28EC
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018D6D2638-0x000000018D6D2704
		public object CreateWrapper(int id); // 0x000000018D6D2704-0x000000018D6D2780
		public object InitWrapperArray(int len); // 0x000000018D6D27E4-0x000000018D6D2870
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018D6D2594-0x000000018D6D2638
	}

	public delegate IntPtr __HotPatchDelegate_0(object P0); // TypeDefIndex: 88488; 0x0000000185B78EA0-0x0000000185B78EB0

	public enum HotPatchIDMAP0 // TypeDefIndex: 88489
	{
		Beyond-Reflection-MethodPointerManager-GetDelegatePointer0 = 0,
		Beyond-Reflection-ObjectPointerHelper-GetSpanPtr0 = 1,
		Beyond-Reflection-ObjectPointerHelper-GetReadOnlySpan0 = 2,
		Beyond-Reflection-StructMemManager-GetMemoryBySize0 = 3,
		Beyond-Reflection-StructMemManager-FreeMemory0 = 4,
		Beyond-Reflection-StructMemManager-ClearMemory0 = 5,
		Beyond-Reflection-StructPtrRefrenceManager-_RunOnStart0 = 5,
		Beyond-Reflection-StructMemManager-DumpMemory0 = 6,
		Beyond-Reflection-StructPtrRefrenceManager-AddObjInPtrRef0 = 7,
		Beyond-Reflection-StructPtrRefrenceManager-RemoveObjInPtrRef0 = 7,
		Beyond-Reflection-StructPtrWrapper-GetStructPtrWrapper0 = 8,
		Beyond-Reflection-StructPtrWrapper-GetStructPtrWrapper1 = 9,
		Beyond-Reflection-StructPtrWrapper-Release0 = 10,
		Beyond-Reflection-StructPtrWrapper-_OnGet0 = 10,
		Beyond-Reflection-StructPtrWrapper-_OnRealse0 = 10,
		Beyond-Reflection-StructPtrWrapper-GetStructObj0 = 11,
		Beyond-Reflection-StructPtrWrapper-GetStructObj2 = 11,
		Beyond-Reflection-StructPtrWrapper-GetStructObj1 = 12,
		Beyond-Reflection-StructPtrWrapper-SetStructObjValue0 = 13,
		Beyond-Reflection-StructPtrWrapper-GetHashCode0 = 14,
		Beyond-Reflection-StructPtrWrapper-Equals0 = 15,
		Beyond-Reflection-StructPtrWrapper-ToString0 = 16,
		Beyond-Reflection-StructPtrWrapper-GetType0 = 17,
		Beyond-Reflection-StructPtrWrapper-_OnCreate0 = 18
	}

	public delegate IntPtr __HotPatchDelegate_1(ReadOnlySpan<byte> P0); // TypeDefIndex: 88490; 0x0000000186A4F2D0-0x0000000186A4F300

	public delegate ReadOnlySpan<byte> __HotPatchDelegate_2(IntPtr P0, int P1); // TypeDefIndex: 88491; 0x00000001812C43A0-0x00000001812C43E0

	public delegate IntPtr __HotPatchDelegate_3(int P0); // TypeDefIndex: 88492; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_4(int P0, IntPtr P1); // TypeDefIndex: 88493; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_5(); // TypeDefIndex: 88494; 0x0000000185B44B70-0x0000000185B44B80

	public delegate string __HotPatchDelegate_6(); // TypeDefIndex: 88495; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_7(object P0, IntPtr P1); // TypeDefIndex: 88496; 0x00000001859B7730-0x00000001859B7740

	public delegate StructPtrWrapper __HotPatchDelegate_8(IntPtr P0, int P1, object P2); // TypeDefIndex: 88497; 0x00000001811DF7F0-0x00000001811DF810

	public delegate StructPtrWrapper __HotPatchDelegate_9(object P0); // TypeDefIndex: 88498; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_10(object P0); // TypeDefIndex: 88499; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate object __HotPatchDelegate_11(object P0); // TypeDefIndex: 88500; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate object __HotPatchDelegate_12(IntPtr P0, object P1, int P2); // TypeDefIndex: 88501; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_13(object P0, object P1); // TypeDefIndex: 88502; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_14(object P0); // TypeDefIndex: 88503; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_15(object P0, object P1); // TypeDefIndex: 88504; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_16(object P0); // TypeDefIndex: 88505; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate System.Type __HotPatchDelegate_17(object P0); // TypeDefIndex: 88506; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate StructPtrWrapper __HotPatchDelegate_18(); // TypeDefIndex: 88507; 0x0000000185B44B70-0x0000000185B44B80
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 88389
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 88390
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
