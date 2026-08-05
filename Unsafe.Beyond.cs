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
using UnityEngine;
using UnityEngine.Pool;

// Image 57: Unsafe.Beyond.dll - Assembly: Unsafe.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61218-61318
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Reflection
{
	public class MethodPointerManager // TypeDefIndex: 61310
	{
		// Constructors
		public MethodPointerManager(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static T2 CallPointer<T1, T2>(IntPtr ptr, T1 param);
		public static TRet CallDelegatePointer<TParam1, TRet>(IntPtr ptr, TParam1 target);
		public static TRet CallDelegatePointer<TParam1, TParam2, TRet>(IntPtr ptr, TParam1 target, TParam2 param);
		public static ValueTuple<IntPtr, T1> GetDelegatePointer<T1>(Delegate d);
		public static IntPtr GetDelegatePointer(MethodInfo d); // 0x000000018B5A7980-0x000000018B5A79D0
	}

	public static class ObjectPointerHelper // TypeDefIndex: 61311
	{
		// Methods
		public static IntPtr GetIntPtr<T>(ref ref T value)
			where T : struct;
		public static IntPtr GetArrayPtr<T>(T[] value)
			where T : struct;
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
		public static unsafe void SetValue(IntPtr ptr, int offset, byte* data, int size); // 0x000000018B5A7B9C-0x000000018B5A7BB0
		public static object GetObj(IntPtr ptr, int offset); // 0x000000018B5A7A3C-0x000000018B5A7A78
		public static void SetObj(IntPtr ptr, int offset, object value); // 0x000000018B5A7B4C-0x000000018B5A7B9C
		public static void CopyValue(IntPtr target, IntPtr source, int size); // 0x000000018B5A7A34-0x000000018B5A7A3C
		public static unsafe void CopyValue(void* target, void* source, int size); // 0x000000018B5A7A34-0x000000018B5A7A3C
		public static unsafe void CopyValue(byte* to, byte* from, int size); // 0x000000018B5A79D0-0x000000018B5A7A34
		public static ReadOnlySpan<byte> GetReadOnlySpan(IntPtr ptr, int maxLength); // 0x000000018B5A7A78-0x000000018B5A7B4C
	}

	public class StructMemManager // TypeDefIndex: 61312
	{
		// Fields
		private static Dictionary<int, ValueTuple<HashSet<long>, List<IntPtr>>> s_structMemDict; // 0x00
	
		// Constructors
		public StructMemManager(); // 0x00000001841E1670-0x00000001841E1680
		static StructMemManager(); // 0x000000018B5A870C-0x000000018B5A8798
	
		// Methods
		public static IntPtr GetMemoryBySize(int size); // 0x000000018B5A84AC-0x000000018B5A870C
		public static void FreeMemory(int size, IntPtr ptr); // 0x000000018B5A837C-0x000000018B5A84AC
		public static void ClearMemory(); // 0x000000018B5A7C44-0x000000018B5A7F84
		public static string DumpMemory(); // 0x000000018B5A7F84-0x000000018B5A837C
	}

	public class StructPtrRefrenceManager // TypeDefIndex: 61313
	{
		// Fields
		private static Dictionary<object, object> s_refDic; // 0x00
		private static Dictionary<System.Type, List<int>> s_structPtrOffsetDic; // 0x08
	
		// Constructors
		public StructPtrRefrenceManager(); // 0x00000001841E1670-0x00000001841E1680
		static StructPtrRefrenceManager(); // 0x0000000184CA3A20-0x0000000184CA3B10
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _RunOnStart(); // 0x0000000183B7D0C0-0x0000000183B7D180
		public static void AddObjInPtrRef(System.Type type, IntPtr ptr); // 0x000000018B5A8798-0x000000018B5A8A64
		public static void RemoveObjInPtrRef(System.Type type, IntPtr ptr); // 0x000000018B5A8A64-0x000000018B5A8CEC
	}

	public class StructPtrWrapper // TypeDefIndex: 61314
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
		public StructPtrWrapper(IntPtr ptr, int size, System.Type type); // 0x000000018B5A9A18-0x000000018B5A9AA4
		public StructPtrWrapper(object structObj); // 0x000000018B5A9AA4-0x000000018B5A9B84
		static StructPtrWrapper(); // 0x000000018B5A9884-0x000000018B5A9A18
	
		// Methods
		[IDTag(0)]
		public static StructPtrWrapper GetStructPtrWrapper(IntPtr ptr, int size, System.Type type); // 0x000000018B5A90EC-0x000000018B5A9288
		[IDTag(1)]
		public static StructPtrWrapper GetStructPtrWrapper(object structObj); // 0x000000018B5A8FA0-0x000000018B5A90EC
		public static void Release(StructPtrWrapper obj); // 0x000000018B5A92D4-0x000000018B5A93B8
		[IDTag(0)]
		public object GetStructObj(); // 0x000000018B5A8EC0-0x000000018B5A8F4C
		[IDTag(1)]
		public static object GetStructObj(IntPtr ptr, System.Type type, int size); // 0x000000018B5A8E1C-0x000000018B5A8EC0
		public void SetStructObjValue(object structObj); // 0x000000018B5A93B8-0x000000018B5A943C
		public override int GetHashCode(); // 0x000000018B5A8DBC-0x000000018B5A8E1C
		public override bool Equals(object obj); // 0x000000018B5A8CEC-0x000000018B5A8DBC
		public override string ToString(); // 0x000000018B5A943C-0x000000018B5A949C
		public new System.Type GetType(); // 0x000000018B5A9288-0x000000018B5A92D4
		[IDTag(2)]
		public static object GetStructObj(StructPtrWrapper obj); // 0x000000018B5A8F4C-0x000000018B5A8FA0
		private static StructPtrWrapper _OnCreate(); // 0x000000018B5A949C-0x000000018B5A95D0
		private static void _OnGet(StructPtrWrapper o); // 0x000000018B5A95D0-0x000000018B5A97D4
		private static void _OnRealse(StructPtrWrapper obj); // 0x000000018B5A97D4-0x000000018B5A9884
		public int __iFixBaseProxy_GetHashCode(); // 0x0000000184D87100-0x0000000184D87110
		public bool __iFixBaseProxy_Equals(object P0); // 0x0000000182FB1840-0x0000000182FB1850
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}
}

namespace Beyond.SparkBuffer
{
	public enum SparkType : byte // TypeDefIndex: 61221
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

	public static class Common // TypeDefIndex: 61222
	{
		// Fields
		public const int NULL_PLACEHOLDER = -1; // Metadata: 0x0234F7E9
		public const int BOOL_MEM_SIZE = 1; // Metadata: 0x0234F7EA
		public const int BYTE_MEM_SIZE = 1; // Metadata: 0x0234F7EB
		public const int INT_MEM_SIZE = 4; // Metadata: 0x0234F7EC
		public const int LONG_MEM_SIZE = 8; // Metadata: 0x0234F7ED
		public const int FLOAT_MEM_SIZE = 4; // Metadata: 0x0234F7EE
		public const int DOUBLE_MEM_SIZE = 8; // Metadata: 0x0234F7EF
	}

	public static class Utils // TypeDefIndex: 61223
	{
		// Methods
		public static int Align4Bytes(int position); // 0x000000018B5A6F70-0x000000018B5A6F84
		public static int Align8Bytes(int position); // 0x000000018B5A6F84-0x000000018B5A6F98
		public static int AlignBytesForSize(int position, int size); // 0x000000018B5A6F98-0x000000018B5A6FC0
		public static int GetMemSizeForType(SparkType sparkType); // 0x0000000183293C50-0x0000000183293CC0
		public static int GetFieldOffset(SparkType sparkType, ref int postion); // 0x0000000183292FE0-0x0000000183293080
		public static bool IsEnumOrBean(SparkType sparkType); // 0x000000018B5A6FF8-0x000000018B5A7008
		public static bool IsArrayOrMap(SparkType sparkType); // 0x000000018B5A6FE8-0x000000018B5A6FF8
		public static bool CheckValidMapKeyType(SparkType sparkType); // 0x000000018B5A6FC0-0x000000018B5A6FD4
		public static bool CheckValidRootType(SparkType sparkType); // 0x000000018B5A6FD4-0x000000018B5A6FE8
	}
}

namespace Beyond.SparkBuffer.Runtime
{
	public class ByteReader : IDisposable // TypeDefIndex: 61224
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
		public int position { get; } // 0x00000001811F2A90-0x00000001811F2AA0 
		public NativeArray<byte> buffer { get; } // 0x0000000182B2D510-0x0000000182B2D520 
	
		// Constructors
		public ByteReader(byte[] buffer); // 0x0000000182F218C0-0x0000000182F21940
	
		// Methods
		public void Dispose(); // 0x000000018B595A14-0x000000018B595A5C
		public void SeekTo(int pos); // 0x00000001811F2AA0-0x00000001811F2AB0
		public bool ReadBool(); // 0x000000018B595A5C-0x000000018B595A74
		public byte ReadByte(); // 0x0000000184DBF440-0x0000000184DBF460
		public int ReadInt(); // 0x000000018B595ACC-0x000000018B595AF8
		public long ReadLong(); // 0x000000018B595AF8-0x000000018B595B28
		public float ReadFloat(); // 0x000000018B595AA0-0x000000018B595ACC
		public double ReadDouble(); // 0x000000018B595A74-0x000000018B595AA0
		public string ReadString(); // 0x000000018B595B28-0x000000018B595BF0
		public Beyond.SparkBuffer.Runtime.Wrapper.HashSlot ReadHashSlot(); // 0x0000000184DBF460-0x0000000184DBF470
		public SparkType ReadSparkType(); // 0x0000000184DBF440-0x0000000184DBF460
		public int ReadTypeHash(); // 0x000000018B595BF0-0x000000018B595BF8
	}

	public class ByteWriter : IDisposable // TypeDefIndex: 61225
	{
		// Fields
		private static readonly byte[] BUFFER_0; // 0x00
		private readonly BinaryWriter m_writer; // 0x10
		private readonly Stream m_stream; // 0x18
		public static IStringPool s_stringPool; // 0x08
	
		// Properties
		public int position { get; } // 0x000000018B59625C-0x000000018B596280 
	
		// Constructors
		public ByteWriter(Stream stream); // 0x000000018B5961D8-0x000000018B59625C
		static ByteWriter(); // 0x000000018B596170-0x000000018B5961D8
	
		// Methods
		public void Dispose(); // 0x000000018B595BF8-0x000000018B595C34
		public void SeekTo(int pos); // 0x000000018B595C78-0x000000018B595CA4
		public void WriteBool(bool v); // 0x000000018B595CA4-0x000000018B595CC4
		public void WriteByte(byte v); // 0x000000018B595CC4-0x000000018B595CE4
		public void WriteInt(int v); // 0x000000018B595DF8-0x000000018B595E34
		public void WriteLong(long v); // 0x000000018B595E34-0x000000018B595E70
		public void WriteFloat(float v); // 0x000000018B595DBC-0x000000018B595DF8
		public void WriteDouble(double v); // 0x000000018B595D80-0x000000018B595DBC
		public void WriteStringAlignment(string v); // 0x000000018B595E70-0x000000018B595F5C
		public void WriteString(string v); // 0x000000018B595F5C-0x000000018B596038
		public void WriteBytes(ReadOnlySpan<byte> buffer, int index, int count); // 0x000000018B595CE4-0x000000018B595D80
		public void WriteSparkType(SparkType sparkType); // 0x000000018B595CC4-0x000000018B595CE4
		internal int FillAlignment(int align); // 0x000000018B595C34-0x000000018B595C78
		private void _FillAlignment4(); // 0x000000018B596038-0x000000018B5960D4
		private void _FillAlignment8(); // 0x000000018B5960D4-0x000000018B596170
	}

	public struct Array // TypeDefIndex: 61226
	{
		// Fields
		private readonly ArrayType m_arrayType; // 0x00
		private readonly Root m_root; // 0x18
		private readonly int m_dataOffset; // 0x20
		private readonly int m_length; // 0x24
	
		// Properties
		public int length { get; } // 0x00000001811F0020-0x00000001811F0030 
	
		// Constructors
		internal Array(ArrayType arrayType, int offset, Root root); // 0x000000018305EE00-0x000000018305EF30
	
		// Methods
		public bool GetBool(int index); // 0x000000018B594D2C-0x000000018B594D98
		public byte GetByte(int index); // 0x000000018B594B48-0x000000018B594BB4
		public int GetInt(int index); // 0x000000018B594EE8-0x000000018B594F58
		public long GetLong(int index); // 0x000000018B594BB4-0x000000018B594C64
		public float GetFloat(int index); // 0x000000018B594E78-0x000000018B594EE8
		public double GetDouble(int index); // 0x000000018B594D98-0x000000018B594E08
		public string GetString(int index); // 0x000000018B594F58-0x000000018B594FC8
		public int GetEnum(int index); // 0x000000018B594E08-0x000000018B594E78
		public Bean? GetBean(int index); // 0x000000018B594C9C-0x000000018B594D2C
	}

	public struct Bean // TypeDefIndex: 61227
	{
		// Fields
		private readonly BeanType m_beanType; // 0x00
		private readonly Root m_root; // 0x08
		private readonly int m_dataOffset; // 0x10
	
		// Constructors
		internal Bean(BeanType beanType, int offset, Root root); // 0x000000018305FE10-0x000000018305FED0
	
		// Methods
		public bool GetBool(string key, out int offset); // 0x000000018B595180-0x000000018B5951F0
		public bool GetBool(int offset); // 0x000000018B5951F0-0x000000018B595218
		public byte GetByte(string key, out int offset); // 0x000000018B595218-0x000000018B595288
		public byte GetByte(int offset); // 0x000000018B595288-0x000000018B5952B0
		public int GetInt(string key, out int offset); // 0x000000018B595370-0x000000018B5953E0
		public int GetInt(int offset); // 0x000000018B595348-0x000000018B595370
		public long GetLong(string key, out int offset); // 0x000000018B595478-0x000000018B5954E8
		public long GetLong(int offset); // 0x000000018B5954E8-0x000000018B595510
		public float GetFloat(string key, out int offset); // 0x000000018B595408-0x000000018B595478
		public float GetFloat(int offset); // 0x000000018B5953E0-0x000000018B595408
		public double GetDouble(string key, out int offset); // 0x000000018B5952B0-0x000000018B595320
		public double GetDouble(int offset); // 0x000000018B595320-0x000000018B595348
		public string GetString(string key, out int offset); // 0x000000018B595510-0x000000018B595580
		public string GetString(int offset); // 0x000000018B595580-0x000000018B5955A8
		public int GetEnum(string key, out int offset); // 0x000000018B595370-0x000000018B5953E0
		public int GetEnum(int offset); // 0x000000018B595348-0x000000018B595370
		public Bean? GetBean(string key); // 0x000000018305F690-0x000000018305FE10
		public Beyond.SparkBuffer.Runtime.Array? GetArray(string key); // 0x000000018305EF30-0x000000018305F690
		public Beyond.SparkBuffer.Runtime.Map? GetMap(string key); // 0x0000000183293520-0x0000000183293AA0
	}

	public struct Map : IEnumerable<Beyond.SparkBuffer.Runtime.Map.UnionKey> // TypeDefIndex: 61230
	{
		// Fields
		private const int INT_KEY_MEM_SIZE = 4; // Metadata: 0x0234F7F0
		private const int LONG_KEY_MEM_SIZE = 8; // Metadata: 0x0234F7F1
		private readonly MapType m_mapType; // 0x00
		private readonly Root m_root; // 0x28
		private readonly int m_valueMemSize; // 0x30
		private readonly int m_keyMemSize; // 0x34
		private readonly int m_dataOffset; // 0x38
		private readonly int m_count; // 0x3C
		private readonly int m_slotsOffset; // 0x40
	
		// Properties
		public int count { get; } // 0x0000000184D86640-0x0000000184D86650 
	
		// Nested types
		public struct UnionKey // TypeDefIndex: 61228
		{
			// Fields
			public int intKey; // 0x00
			public long longKey; // 0x08
			public string stringKey; // 0x10
	
			// Constructors
			public UnionKey(int key); // 0x000000018B5A6F28-0x000000018B5A6F40
			public UnionKey(long key); // 0x000000018B5A6F58-0x000000018B5A6F70
			public UnionKey(string key); // 0x000000018B5A6F40-0x000000018B5A6F58
		}
	
		public struct UnionKeyEnumerator : IEnumerator<UnionKey> // TypeDefIndex: 61229
		{
			// Fields
			private readonly Map m_parent; // 0x00
			private int m_index; // 0x48
			private int m_currentSlotIndex; // 0x4C
			private int m_currentSlotStartIndex; // 0x50
			private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot m_currentSlot; // 0x54
	
			// Properties
			public UnionKey Current { get; } // 0x000000018B5A6D48-0x000000018B5A6F28 
			object IEnumerator.Current { get; } // 0x000000018B5A6C94-0x000000018B5A6CF4 
	
			// Constructors
			public UnionKeyEnumerator(Map parent); // 0x000000018B5A6CF4-0x000000018B5A6D48
	
			// Methods
			public bool MoveNext(); // 0x000000018B5A6BA8-0x000000018B5A6C94
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
			void IEnumerator.Reset(); // 0x0000000184DBF490-0x0000000184DBF4B0
		}
	
		// Constructors
		internal Map(MapType mapType, int offset, Root root); // 0x0000000183293AA0-0x0000000183293C50
	
		// Methods
		public UnionKeyEnumerator GetEnumerator(); // 0x000000018B59D430-0x000000018B59D4D0
		IEnumerator<UnionKey> System.Collections.Generic.IEnumerable<Beyond.SparkBuffer.Runtime.Map.UnionKey>.GetEnumerator(); // 0x000000018B59DCA0-0x000000018B59DD2C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59DD2C-0x000000018B59DDB8
		private static int GetHash(string str); // 0x000000018B59D604-0x000000018B59D624
		private static int GetHash(int value); // 0x0000000184D88BE0-0x0000000184D88BF0
		private static int GetHash(long value); // 0x0000000184D88BE0-0x0000000184D88BF0
		private Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(int slotIndex); // 0x000000018B59D588-0x000000018B59D604
		private int _FindHashIndexByKey(int intKey); // 0x000000018B59E35C-0x000000018B59E434
		private int _FindHashIndexByKey(long longKey); // 0x000000018B59E280-0x000000018B59E35C
		private int _FindHashIndexByKey(string stringKey); // 0x000000018B59E434-0x000000018B59E524
		internal int GetIntKeyByIndex(int index); // 0x000000018B59D624-0x000000018B59D720
		internal long GetLongKeyByIndex(int index); // 0x000000018B59D878-0x000000018B59D974
		internal string GetStringKeyByIndex(int index); // 0x000000018B59DA2C-0x000000018B59DB28
		internal int GetIntKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex); // 0x000000018B59D720-0x000000018B59D830
		internal long GetLongKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex); // 0x00000001886D4544-0x00000001886D4654
		internal string GetStringKeyBySlotAndLocalIndex(Beyond.SparkBuffer.Runtime.Wrapper.HashSlot slot, int localIndex); // 0x000000018B59DB28-0x000000018B59DC38
		public bool ContainsKey(string key); // 0x0000000183291800-0x0000000183291CE0
		public bool GetBool(string key); // 0x000000018B59D11C-0x000000018B59D150
		public bool TryGetBool(string key, out bool value); // 0x00000001837534D0-0x0000000183753520
		public byte GetByte(string key); // 0x000000018B59D200-0x000000018B59D234
		public bool TryGetByte(string key, out byte value); // 0x000000018B59DE90-0x000000018B59DED8
		public int GetInt(string key); // 0x0000000183BAFE50-0x0000000183BAFEC0
		public bool TryGetInt(string key, out int value); // 0x000000018353C320-0x000000018353C370
		public long GetLong(string key); // 0x000000018B59D9A8-0x000000018B59D9DC
		public bool TryGetLong(string key, out long value); // 0x000000018B59E238-0x000000018B59E280
		public float GetFloat(string key); // 0x000000018B59D4EC-0x000000018B59D520
		public bool TryGetFloat(string key, out float value); // 0x000000018B59E0D0-0x000000018B59E118
		public double GetDouble(string key); // 0x000000018B59D2B0-0x000000018B59D2E4
		public bool TryGetDouble(string key, out double value); // 0x000000018B59DF20-0x000000018B59DF68
		public string GetString(string key); // 0x000000018B59DC38-0x000000018B59DC6C
		public bool TryGetString(string key, out string value); // 0x00000001841EF060-0x00000001841EF0C0
		public int GetEnum(string key); // 0x000000018B59D394-0x000000018B59D3C8
		public bool TryGetEnum(string key, out int value); // 0x000000018B59E088-0x000000018B59E0D0
		public Bean? GetBean(string key); // 0x00000001838C2C50-0x00000001838C2ED0
		public bool TryGetBean(string key, out Bean? bean); // 0x00000001838C3170-0x00000001838C36C0
		public bool ContainsKey(int key); // 0x000000018331BB50-0x000000018331BB70
		public bool GetBool(int key); // 0x000000018B59D150-0x000000018B59D184
		public bool TryGetBool(int key, out bool value); // 0x000000018B59DDB8-0x000000018B59DE00
		public byte GetByte(int key); // 0x000000018B59D1CC-0x000000018B59D200
		public bool TryGetByte(int key, out byte value); // 0x000000018B59DE48-0x000000018B59DE90
		public int GetInt(int key); // 0x000000018B59D3FC-0x000000018B59D430
		public bool TryGetInt(int key, out int value); // 0x0000000183EBB2B0-0x0000000183EBB340
		public long GetLong(int key); // 0x000000018B59D9DC-0x000000018B59DA10
		public bool TryGetLong(int key, out long value); // 0x000000018B59E1F0-0x000000018B59E238
		public float GetFloat(int key); // 0x000000018B59D520-0x000000018B59D554
		public bool TryGetFloat(int key, out float value); // 0x000000018B59E160-0x000000018B59E1A8
		public double GetDouble(int key); // 0x000000018B59D2E4-0x000000018B59D318
		public bool TryGetDouble(int key, out double value); // 0x000000018B59DFB0-0x000000018B59DFF8
		public string GetString(int key); // 0x0000000183062620-0x0000000183062660
		public bool TryGetString(int key, out string value); // 0x000000018397BAB0-0x000000018397BB10
		public int GetEnum(int key); // 0x000000018B59D3FC-0x000000018B59D430
		public bool TryGetEnum(int key, out int value); // 0x000000018B59E040-0x000000018B59E088
		public Bean? GetBean(int key); // 0x00000001838C1150-0x00000001838C11B0
		public bool TryGetBean(int key, out Bean? bean); // 0x00000001838C20D0-0x00000001838C2140
		public bool ContainsKey(long key); // 0x000000018B59CFE4-0x000000018B59CFF8
		public bool GetBool(long key); // 0x000000018B59D0E8-0x000000018B59D11C
		public bool TryGetBool(long key, out bool value); // 0x000000018B59DE00-0x000000018B59DE48
		public byte GetByte(long key); // 0x000000018B59D234-0x000000018B59D268
		public bool TryGetByte(long key, out byte value); // 0x000000018B59DED8-0x000000018B59DF20
		public int GetInt(long key); // 0x000000018B59D3C8-0x000000018B59D3FC
		public bool TryGetInt(long key, out int value); // 0x000000018B59DFF8-0x000000018B59E040
		public long GetLong(long key); // 0x000000018B59D974-0x000000018B59D9A8
		public bool TryGetLong(long key, out long value); // 0x000000018B59E1A8-0x000000018B59E1F0
		public float GetFloat(long key); // 0x000000018B59D554-0x000000018B59D588
		public bool TryGetFloat(long key, out float value); // 0x000000018B59E118-0x000000018B59E160
		public double GetDouble(long key); // 0x000000018B59D318-0x000000018B59D34C
		public bool TryGetDouble(long key, out double value); // 0x000000018B59DF68-0x000000018B59DFB0
		public string GetString(long key); // 0x000000018B59DC6C-0x000000018B59DCA0
		public bool TryGetString(long key, out string value); // 0x00000001839CE830-0x00000001839CEA70
		public int GetEnum(long key); // 0x000000018B59D3C8-0x000000018B59D3FC
		public bool TryGetEnum(long key, out int value); // 0x000000018B59DFF8-0x000000018B59E040
		public Bean? GetBean(long key); // 0x000000018B59D038-0x000000018B59D0A0
		public bool TryGetBean(long key, out Bean? bean); // 0x00000001839CE7F0-0x00000001839CE830
		internal bool GetBoolByIndex(int index); // 0x000000018B59D0A0-0x000000018B59D0CC
		internal byte GetByteByIndex(int index); // 0x000000018B59D184-0x000000018B59D1B0
		internal int GetIntByIndex(int index); // 0x000000018B59D34C-0x000000018B59D378
		internal long GetLongByIndex(int index); // 0x000000018B59D830-0x000000018B59D85C
		internal float GetFloatByIndex(int index); // 0x0000000183E31D60-0x0000000183E31E30
		internal double GetDoubleByIndex(int index); // 0x000000018B59D268-0x000000018B59D294
		internal string GetStringByIndex(int index); // 0x00000001836A33B0-0x00000001836A33E0
		internal int GetEnumByIndex(int index); // 0x000000018B59D34C-0x000000018B59D378
		internal Bean? GetBeanByIndex(int index); // 0x00000001838C2650-0x00000001838C26C0
		private int _GetOffsetByIndex(int index); // 0x000000018B59E524-0x000000018B59E684
		internal bool GetBoolByOffset(int offset); // 0x000000018B59D0CC-0x000000018B59D0E8
		internal byte GetByteByOffset(int offset); // 0x000000018B59D1B0-0x000000018B59D1CC
		internal int GetIntByOffset(int offset); // 0x000000018B59D378-0x000000018B59D394
		internal long GetLongByOffset(int offset); // 0x000000018B59D85C-0x000000018B59D878
		internal float GetFloatByOffset(int offset); // 0x000000018B59D4D0-0x000000018B59D4EC
		internal double GetDoubleByOffset(int offset); // 0x000000018B59D294-0x000000018B59D2B0
		internal string GetStringByOffset(int offset); // 0x000000018B59DA10-0x000000018B59DA2C
		internal int GetEnumByOffset(int offset); // 0x000000018B59D378-0x000000018B59D394
		internal Bean? GetBeanByOffset(int offset); // 0x000000018B59CFF8-0x000000018B59D038
	}

	public class Root : IDisposable // TypeDefIndex: 61232
	{
		// Fields
		private ByteReader m_reader; // 0x10
		private readonly Options m_options; // 0x18
		private readonly int m_dataOffset; // 0x40
		private Dictionary<int, string> m_cachedString; // 0x48
	
		// Properties
		public string name { get; } // 0x000000018385B100-0x000000018385B110 
		public NativeArray<byte> bytes { get; } // 0x0000000183FA9AE0-0x0000000183FA9B10 
	
		// Nested types
		internal struct Options // TypeDefIndex: 61231
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
		internal Root(int dataOffset, Options options, ByteReader reader); // 0x0000000182F20A00-0x0000000182F20AB0
	
		// Methods
		~Root(); // 0x000000018B5A1184-0x000000018B5A124C
		public override string ToString(); // 0x000000018B5A180C-0x000000018B5A187C
		public void Dispose(); // 0x000000018B5A1154-0x000000018B5A1184
		public bool IsValid(); // 0x000000018A77DD74-0x000000018A77DD80
		public Bean? AsBean(); // 0x000000018B5A0EEC-0x000000018B5A0FA8
		public Beyond.SparkBuffer.Runtime.Array? AsArray(); // 0x000000018B5A0DC8-0x000000018B5A0EEC
		public Beyond.SparkBuffer.Runtime.Map? AsMap(); // 0x000000018B5A0FA8-0x000000018B5A1154
		internal int GetCurReaderPosition(); // 0x000000018B5A14F4-0x000000018B5A1510
		internal bool GetBool(int offset); // 0x000000018B5A14B8-0x000000018B5A14F4
		internal byte GetByte(int offset); // 0x000000018B594C64-0x000000018B594C9C
		internal int GetInt(int offset); // 0x000000018B5A1538-0x000000018B5A1560
		internal long GetLong(int offset); // 0x00000001839CEA70-0x00000001839CEBF0
		internal float GetFloat(int offset); // 0x0000000183E31E30-0x0000000183E31E80
		internal double GetDouble(int offset); // 0x000000018B5A1510-0x000000018B5A1538
		internal int GetEnum(int offset); // 0x000000018B5A1538-0x000000018B5A1560
		internal string GetString(int offset); // 0x000000018B5A1704-0x000000018B5A180C
		internal Bean? GetBean(int offset, BeanType beanType); // 0x000000018B5A1394-0x000000018B5A14B8
		internal Beyond.SparkBuffer.Runtime.Array? GetArray(int offset, ArrayType arrayType); // 0x000000018B5A124C-0x000000018B5A1394
		internal Beyond.SparkBuffer.Runtime.Map? GetMap(int offset, MapType mapType); // 0x000000018B5A1560-0x000000018B5A1704
		internal Beyond.SparkBuffer.Runtime.Wrapper.HashSlot GetHashSlot(int offset); // 0x0000000183060940-0x0000000183060970
	}

	public static class Error // TypeDefIndex: 61233
	{
		// Methods
		public static Exception TypeNotFoundError(int typeHash, SparkType sparkType); // 0x000000018B596830-0x000000018B5968FC
		public static Exception InvalidTypeError(SparkType sparkType); // 0x000000018B59668C-0x000000018B59672C
		public static Exception InvalidMapKeyError(SparkType sparkType); // 0x000000018B5965EC-0x000000018B59668C
		public static Exception NullTypeError(SparkType sparkType); // 0x000000018B59672C-0x000000018B5967CC
		public static Exception GetEndOfFile(); // 0x000000018B596588-0x000000018B5965EC
		public static Exception SeekAheadOfFile(); // 0x000000018B5967CC-0x000000018B596830
		public static Exception DisposedException(); // 0x000000018B596524-0x000000018B596588
	}

	public abstract class SparkManager // TypeDefIndex: 61236
	{
		// Fields
		private readonly Dictionary<int, BeanType> m_beanTypeMap; // 0x10
		private readonly Dictionary<int, EnumType> m_enumTypeMap; // 0x18
		protected readonly Dictionary<string, Root> m_namedRoots; // 0x20
		private readonly List<Root> m_anonymousRoots; // 0x28
		private readonly Queue<BeanType> m_beanTypeQueue; // 0x30
	
		// Nested types
		private class JsonLoader : IDisposable // TypeDefIndex: 61235
		{
			// Fields
			private ByteWriter m_writer; // 0x10
			private Dictionary<string, int> m_stringMap; // 0x18
	
			// Nested types
			private struct ReservedField // TypeDefIndex: 61234
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
			private JsonLoader(ByteWriter writer); // 0x000000018B59B2AC-0x000000018B59B334
	
			// Methods
			public void Dispose(); // 0x00000001840E20A0-0x00000001840E20C0
			internal static void PopulateJsonDataWithoutTypeAndRootDef(ByteWriter writer, JToken rootObj, Root.Options rootOptions, out int dataOffset); // 0x000000018B597A64-0x000000018B597BA0
			private void _LoadJsonContentWithoutTypeAndRootDef(JToken rootObj, Root.Options rootOptions, out int dataOffset); // 0x000000018B59B218-0x000000018B59B2AC
			private void _ExportStrings(JToken rootJson, Root.Options rootOptions); // 0x000000018B59AAEC-0x000000018B59AFD8
			private void _CollectBeanStrings(HashSet<string> stringSet, JObject obj, BeanType beanType); // 0x000000018B597DB4-0x000000018B59827C
			private void _CollectArrayStrings(HashSet<string> stringSet, JArray obj, ArrayType arrayType); // 0x000000018B597BA0-0x000000018B597DB4
			private void _CollectMapStrings(HashSet<string> stringSet, JObject obj, MapType mapType); // 0x000000018B59827C-0x000000018B5984F0
			private int _ExportRootData(JToken rootJson, Root.Options rootOptions); // 0x000000018B59A740-0x000000018B59A9E8
			private int _ExportBeanData(JObject beanObj, BeanType beanType); // 0x000000018B598D50-0x000000018B599540
			private int _ExportArrayData(JArray arrayObj, ArrayType arrayType); // 0x000000018B5988F0-0x000000018B598D50
			private int _ExportMapData(JObject mapObj, MapType mapType); // 0x000000018B599978-0x000000018B599FC4
			private Dictionary<int, List<KeyValuePair<string, JToken>>> _CreateMapHashEntry(JObject mapObj, SparkType keyType); // 0x000000018B5984F0-0x000000018B598800
			private int _GetMapKeyHash(string key, SparkType keyType); // 0x000000018B59AFD8-0x000000018B59B178
			private void _ExportMapKey(string key, SparkType keyType); // 0x000000018B599FC4-0x000000018B59A194
			private void _ExportMapValue(JToken valueToken, MapType mapType, List<ReservedField> reservedFields); // 0x000000018B59A194-0x000000018B59A334
			private void _ExportReservedFields(List<ReservedField> reservedFields); // 0x000000018B59A334-0x000000018B59A740
			private void _ExportStringByLoc(string strVal); // 0x000000018B59A9E8-0x000000018B59AAEC
			private void _ExportEnumData(JToken token, EnumType enumType); // 0x000000018B5997E4-0x000000018B599978
			private void _ExportCommonDataOrThrow(JToken token, SparkType type, List<ReservedField> reservedFields); // 0x000000018B599540-0x000000018B5997E4
			private static void _EnsureJTokenType(JToken token, JTokenType requiredType); // 0x000000018B598800-0x000000018B5988F0
			private static Exception _InvalidRootTypeError(SparkType rootType); // 0x000000018B59B178-0x000000018B59B218
		}
	
		// Constructors
		protected SparkManager(); // 0x0000000184A1E470-0x0000000184A1E610
	
		// Methods
		public Root Load(byte[] bytes, string overrideRootName); // 0x0000000182F212C0-0x0000000182F21400
		public Root Load(byte[] bytes); // 0x000000018B5A2ED0-0x000000018B5A2EDC
		public Root LoadFromJson_EditorOnly(byte[] bytes, JToken jsonData, string overrideRootName); // 0x000000018B5A29F0-0x000000018B5A2ED0
		public Root LoadFromJson_EditorOnly(byte[] bytes, JToken jsonData); // 0x000000018B5A29D4-0x000000018B5A29F0
		public virtual bool Unload(Root root); // 0x000000018B5A3098-0x000000018B5A30EC
		public virtual void UnloadAndClearAll(); // 0x000000018B5A2EDC-0x000000018B5A3098
		internal bool TryGetEnumType(int typeHash, out EnumType enumType); // 0x0000000183D6EB00-0x0000000183D6EB30
		internal bool TryGetBeanType(int typeHash, out BeanType beanType); // 0x0000000183D6EA90-0x0000000183D6EAC0
		protected virtual bool _AddRoot(Root root); // 0x000000018408E180-0x000000018408E1D0
		private void _ReadTypeDefs(ByteReader reader); // 0x0000000183D6E700-0x0000000183D6E890
		private Root.Options _ReadRootDef(ByteReader reader, string overrideRootName); // 0x0000000182F21400-0x0000000182F218C0
	}

	public class RuntimeSparkManager : SparkManager // TypeDefIndex: 61238
	{
		// Fields
		private static RuntimeSparkManager s_instance; // 0x00
		private Action<Root> m_onRootLoaded; // 0x38
		private Action<Root> m_onRootUnloaded; // 0x40
		private Action m_onUnloadAll; // 0x48
		private const string LUADLL = "__Internal"; // Metadata: 0x0234F7F2
	
		// Properties
		public static RuntimeSparkManager instance { get; } // 0x00000001842D25E0-0x00000001842D2660 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 61237
		{
			// Fields
			public IntPtr L; // 0x10
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RegisterToLua_b__0(Root root); // 0x0000000183FA9A90-0x0000000183FA9AE0
			internal void _RegisterToLua_b__1(Root root); // 0x000000018B5A6B14-0x000000018B5A6B38
			internal void _RegisterToLua_b__2(); // 0x000000018B5A6B38-0x000000018B5A6B44
		}
	
		// Constructors
		private RuntimeSparkManager(); // 0x000000018B5A1A3C-0x000000018B5A1A44
	
		// Methods
		public override bool Unload(Root root); // 0x000000018B5A1994-0x000000018B5A19FC
		public void ReloadTableToLua(string name); // 0x000000018B5A18C4-0x000000018B5A1944
		public override void UnloadAndClearAll(); // 0x000000018B5A1944-0x000000018B5A1994
		private static extern bool LuaSpark_LoadRoot(IntPtr L, string rootName, IntPtr data, int size); // 0x0000000183FA9B10-0x0000000183FA9B80
		private static extern bool LuaSpark_UnloadRoot(IntPtr L, string rootName); // 0x000000018B5A1884-0x000000018B5A18C4
		private static extern void LuaSpark_UnloadAll(IntPtr L); // 0x000000018B5A187C-0x000000018B5A1884
		public void RegisterToLua(IntPtr L); // 0x0000000184175010-0x0000000184175490
		public void UnregisterFromLua(IntPtr L); // 0x000000018B5A19FC-0x000000018B5A1A3C
		protected override bool _AddRoot(Root root); // 0x000000018408E110-0x000000018408E180
	}

	public interface IStringPool // TypeDefIndex: 61239
	{
		// Methods
		int AddString(string str);
		string GetString(int index);
		void Clear();
	}

	internal abstract class Field // TypeDefIndex: 61240
	{
		// Fields
		[CompilerGenerated]
		private readonly string _name_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly int _offset_k__BackingField; // 0x18
	
		// Properties
		public string name { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public int offset { [CompilerGenerated] get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public abstract SparkType type { get; }
	
		// Constructors
		protected Field(string fieldName, int fieldOffset); // 0x0000000183B46FF0-0x0000000183B47040
	
		// Methods
		public abstract void Unmarshal(ByteReader reader);
		public abstract void Resolve(SparkManager manager);
	}

	internal class SimpleField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 61241
	{
		// Fields
		[CompilerGenerated]
		private readonly SparkType _type_k__BackingField; // 0x20
	
		// Properties
		public override SparkType type { [CompilerGenerated] get; } // 0x0000000184D866B0-0x0000000184D866C0 
	
		// Constructors
		public SimpleField(SparkType type, string fieldName, int fieldOffset); // 0x0000000185391C28-0x0000000185391C50
	
		// Methods
		public override void Unmarshal(ByteReader reader); // 0x00000001841E1670-0x00000001841E1680
		public override void Resolve(SparkManager manager); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class EnumField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 61242
	{
		// Fields
		private int m_typeHash; // 0x20
		private EnumType m_enumType; // 0x28
	
		// Properties
		public override SparkType type { get; } // 0x0000000184DBF470-0x0000000184DBF480 
		public EnumType enumType { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Constructors
		public EnumField(string fieldName, int fieldOffset); // 0x0000000183B46FF0-0x0000000183B47040
	
		// Methods
		public override void Unmarshal(ByteReader reader); // 0x000000018403C2E0-0x000000018403C310
		public override void Resolve(SparkManager manager); // 0x0000000183D6EAC0-0x0000000183D6EB00
	}

	internal class BeanField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 61243
	{
		// Fields
		private int m_typeHash; // 0x20
		private BeanType m_beanType; // 0x28
	
		// Properties
		public override SparkType type { get; } // 0x0000000184D920C0-0x0000000184D920D0 
		public BeanType beanType { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Constructors
		public BeanField(string fieldName, int fieldOffset); // 0x0000000183B46FF0-0x0000000183B47040
	
		// Methods
		public override void Unmarshal(ByteReader reader); // 0x000000018403C310-0x000000018403C340
		public override void Resolve(SparkManager manager); // 0x0000000183D6EA50-0x0000000183D6EA90
	}

	internal class ArrayField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 61244
	{
		// Fields
		private ArrayType m_arrayType; // 0x20
		private int m_elementTypeHash; // 0x38
	
		// Properties
		public override SparkType type { get; } // 0x0000000184DBF430-0x0000000184DBF440 
		public ArrayType arrayType { get; } // 0x0000000184D9E6A0-0x0000000184D9E6C0 
	
		// Constructors
		public ArrayField(string fieldName, int fieldOffset); // 0x0000000183B46FF0-0x0000000183B47040
	
		// Methods
		public override void Unmarshal(ByteReader reader); // 0x000000018403C250-0x000000018403C2E0
		public override void Resolve(SparkManager manager); // 0x0000000183D6E9E0-0x0000000183D6EA50
	}

	internal class MapField : Beyond.SparkBuffer.Runtime.Field // TypeDefIndex: 61245
	{
		// Fields
		private MapType m_mapInfo; // 0x20
		private int m_keyTypeHash; // 0x48
		private int m_valueTypeHash; // 0x4C
	
		// Properties
		public override SparkType type { get; } // 0x0000000184DBF480-0x0000000184DBF490 
		public MapType mapType { get; } // 0x0000000184D8E8C0-0x0000000184D8E8E0 
	
		// Constructors
		public MapField(string fieldName, int fieldOffset); // 0x0000000183B46FF0-0x0000000183B47040
	
		// Methods
		public override void Unmarshal(ByteReader reader); // 0x000000018403C1E0-0x000000018403C250
		public override void Resolve(SparkManager manager); // 0x0000000183D6E980-0x0000000183D6E9E0
	}

	internal struct ArrayType // TypeDefIndex: 61246
	{
		// Fields
		public SparkType elementType; // 0x00
		public BeanType elementBeanType; // 0x08
		public EnumType elementEnumType; // 0x10
	}

	internal struct MapType // TypeDefIndex: 61247
	{
		// Fields
		public SparkType keyType; // 0x00
		public EnumType keyEnumType; // 0x08
		public SparkType valueType; // 0x10
		public BeanType valueBeanType; // 0x18
		public EnumType valueEnumType; // 0x20
	}

	internal class EnumType // TypeDefIndex: 61249
	{
		// Fields
		private List<EnumItem> m_enums; // 0x10
		[CompilerGenerated]
		private int _typeHash_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x20
	
		// Properties
		public int typeHash { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
		// Nested types
		private struct EnumItem // TypeDefIndex: 61248
		{
			// Fields
			public string name; // 0x00
			public int value; // 0x08
		}
	
		// Constructors
		public EnumType(ByteReader reader); // 0x0000000183292CE0-0x0000000183292ED0
	
		// Methods
		public bool TryGetValue(string enumName, out int enumVal); // 0x000000018B596458-0x000000018B596524
	}

	internal class BeanType : IEnumerable<KeyValuePair<string, Beyond.SparkBuffer.Runtime.Field>> // TypeDefIndex: 61250
	{
		// Fields
		private Dictionary<string, Beyond.SparkBuffer.Runtime.Field> m_fields; // 0x10
		[CompilerGenerated]
		private int _typeHash_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x20
	
		// Properties
		public int typeHash { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
	
		// Constructors
		public BeanType(ByteReader reader); // 0x0000000183292A70-0x0000000183292CE0
	
		// Methods
		public override string ToString(); // 0x000000018B595110-0x000000018B595180
		public void Resolve(SparkManager manager); // 0x0000000183D6E890-0x0000000183D6E980
		public bool TryGetField(string fieldName, out Beyond.SparkBuffer.Runtime.Field field); // 0x000000018305FED0-0x00000001830601D0
		public Dictionary<string, Beyond.SparkBuffer.Runtime.Field> GetEnumerator(); // 0x000000018B594FC8-0x000000018B595040
		IEnumerator<KeyValuePair<string, Beyond.SparkBuffer.Runtime.Field>> IEnumerable<KeyValuePair<string, Field>>.GetEnumerator(); // 0x000000018B595040-0x000000018B5950A8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5950A8-0x000000018B595110
		private Beyond.SparkBuffer.Runtime.Field _NewField(string name, SparkType type, int offset); // 0x0000000183292ED0-0x0000000183292FE0
	}
}

namespace Beyond.SparkBuffer.Runtime.Wrapper
{
	public interface IArrayWrapper<T> // TypeDefIndex: 61251
	{
		// Properties
		int length { get; }
		int Count { get; }
		T this[int index] { get => default; }
	}

	public struct ArrayEnumerator<TElement, TArray> : IEnumerator<TElement> // TypeDefIndex: 61252
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

	public struct NullableBeanArray<TBean> : IArrayWrapper<TBean?>, IEnumerable<TBean?> // TypeDefIndex: 61253
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

	public struct BeanArray<TBean> : IArrayWrapper<TBean>, IEnumerable<TBean> // TypeDefIndex: 61254
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

	public struct EnumArray<TEnum> : IArrayWrapper<TEnum>, IEnumerable<TEnum> // TypeDefIndex: 61255
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

	public struct BoolArray : IArrayWrapper<bool>, IEnumerable<bool> // TypeDefIndex: 61256
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x00000001811F0020-0x00000001811F0030 
		public int Count { get; } // 0x00000001811F0020-0x00000001811F0030 
		public bool this[int index] { get => default; } // 0x000000018B5957E8-0x000000018B5957F0 
	
		// Constructors
		public BoolArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018B5957C4-0x000000018B5957E8
	
		// Methods
		public ArrayEnumerator<bool, BoolArray> GetEnumerator(); // 0x000000018B5955F0-0x000000018B595664
		public bool[] ToArray(); // 0x000000018B59573C-0x000000018B5957C4
		public bool Contains(bool item); // 0x000000018B5955A8-0x000000018B5955F0
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator(); // 0x000000018B595664-0x000000018B5956D0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5956D0-0x000000018B59573C
	}

	public struct ByteArray : IArrayWrapper<byte>, IEnumerable<byte> // TypeDefIndex: 61257
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x00000001811F0020-0x00000001811F0030 
		public int Count { get; } // 0x00000001811F0020-0x00000001811F0030 
		public byte this[int index] { get => default; } // 0x000000018B595A0C-0x000000018B595A14 
	
		// Constructors
		public ByteArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018B5957C4-0x000000018B5957E8
	
		// Methods
		public ArrayEnumerator<byte, ByteArray> GetEnumerator(); // 0x000000018B595838-0x000000018B5958AC
		public byte[] ToArray(); // 0x000000018B595984-0x000000018B595A0C
		public bool Contains(byte item); // 0x000000018B5957F0-0x000000018B595838
		IEnumerator<byte> IEnumerable<byte>.GetEnumerator(); // 0x000000018B5958AC-0x000000018B595918
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B595918-0x000000018B595984
	}

	public struct IntArray : IArrayWrapper<int>, IEnumerable<int> // TypeDefIndex: 61258
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x00000001811F0020-0x00000001811F0030 
		public int Count { get; } // 0x00000001811F0020-0x00000001811F0030 
		public int this[int index] { get => default; } // 0x000000018539316C-0x0000000185393174 
	
		// Constructors
		public IntArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018B5957C4-0x000000018B5957E8
	
		// Methods
		public ArrayEnumerator<int, IntArray> GetEnumerator(); // 0x00000001846AB220-0x00000001846AB290
		public int[] ToArray(); // 0x000000018B5979DC-0x000000018B597A64
		public bool Contains(int item); // 0x000000018B597928-0x000000018B597970
		IEnumerator<int> IEnumerable<int>.GetEnumerator(); // 0x00000001846AB1B0-0x00000001846AB220
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B597970-0x000000018B5979DC
	}

	public struct LongArray : IArrayWrapper<long>, IEnumerable<long> // TypeDefIndex: 61259
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x00000001811F0020-0x00000001811F0030 
		public int Count { get; } // 0x00000001811F0020-0x00000001811F0030 
		public long this[int index] { get => default; } // 0x000000018B59CFDC-0x000000018B59CFE4 
	
		// Constructors
		public LongArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018B5957C4-0x000000018B5957E8
	
		// Methods
		public ArrayEnumerator<long, LongArray> GetEnumerator(); // 0x000000018B59CE04-0x000000018B59CE78
		public long[] ToArray(); // 0x000000018B59CF50-0x000000018B59CFDC
		public bool Contains(long item); // 0x000000018B59CDBC-0x000000018B59CE04
		IEnumerator<long> IEnumerable<long>.GetEnumerator(); // 0x000000018B59CE78-0x000000018B59CEE4
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59CEE4-0x000000018B59CF50
	}

	public struct FloatArray : IArrayWrapper<float>, IEnumerable<float> // TypeDefIndex: 61260
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x00000001811F0020-0x00000001811F0030 
		public int Count { get; } // 0x00000001811F0020-0x00000001811F0030 
		public float this[int index] { get => default; } // 0x0000000185397784-0x000000018539778C 
	
		// Constructors
		public FloatArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018B5957C4-0x000000018B5957E8
	
		// Methods
		public ArrayEnumerator<float, FloatArray> GetEnumerator(); // 0x00000001845FA690-0x00000001845FA700
		public float[] ToArray(); // 0x000000018B596988-0x000000018B596A14
		IEnumerator<float> IEnumerable<float>.GetEnumerator(); // 0x00000001845FA620-0x00000001845FA690
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59691C-0x000000018B596988
	}

	public struct DoubleArray : IArrayWrapper<double>, IEnumerable<double> // TypeDefIndex: 61261
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x00000001811F0020-0x00000001811F0030 
		public int Count { get; } // 0x00000001811F0020-0x00000001811F0030 
		public double this[int index] { get => default; } // 0x00000001853938D4-0x00000001853938DC 
	
		// Constructors
		public DoubleArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018B5957C4-0x000000018B5957E8
	
		// Methods
		public ArrayEnumerator<double, DoubleArray> GetEnumerator(); // 0x000000018B596280-0x000000018B5962F4
		public double[] ToArray(); // 0x000000018B5963CC-0x000000018B596458
		IEnumerator<double> IEnumerable<double>.GetEnumerator(); // 0x000000018B5962F4-0x000000018B596360
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B596360-0x000000018B5963CC
	}

	public struct StringArray : IArrayWrapper<string>, IEnumerable<string> // TypeDefIndex: 61262
	{
		// Fields
		private Beyond.SparkBuffer.Runtime.Array m_array; // 0x00
	
		// Properties
		public int length { get; } // 0x00000001811F0020-0x00000001811F0030 
		public int Count { get; } // 0x00000001811F0020-0x00000001811F0030 
		public string this[int index] { get => default; } // 0x000000018539378C-0x0000000185393794 
	
		// Constructors
		public StringArray(Beyond.SparkBuffer.Runtime.Array array); // 0x000000018B5957C4-0x000000018B5957E8
	
		// Methods
		public ArrayEnumerator<string, StringArray> GetEnumerator(); // 0x00000001832F23B0-0x00000001832F23F0
		public string[] ToArray(); // 0x0000000183756AF0-0x0000000183756B80
		public bool Contains(string item); // 0x0000000183756B80-0x0000000183756C30
		IEnumerator<string> IEnumerable<string>.GetEnumerator(); // 0x00000001846D98E0-0x00000001846D9980
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5A6954-0x000000018B5A69C0
	}

	public interface IBeanWrapper // TypeDefIndex: 61263
	{
		// Methods
		void SetBean(ref Bean bean);
	}

	public struct HashSlot // TypeDefIndex: 61264
	{
		// Fields
		public int offset; // 0x00
		public int bucketsSize; // 0x04
		public static readonly int size; // 0x00
	
		// Constructors
		static HashSlot(); // 0x0000000184D7A490-0x0000000184D7A4D0
	}

	public interface IMapWrapper<TKey, TValue, TMap> // TypeDefIndex: 61265
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

	public struct MapEnumerator<TKey, TValue, TMap> : IEnumerator<KeyValuePair<TKey, TValue>> // TypeDefIndex: 61266
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

	public struct S2NullableBeanMap<TBean> : IMapWrapper<string, TBean?, S2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<string, TBean?>> // TypeDefIndex: 61267
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

	public struct S2BeanMap<TBean> : IMapWrapper<string, TBean, S2BeanMap<TBean>>, IEnumerable<KeyValuePair<string, TBean>> // TypeDefIndex: 61268
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

	public struct S2EnumMap<TEnum> : IMapWrapper<string, TEnum, S2EnumMap<TEnum>>, IEnumerable<KeyValuePair<string, TEnum>> // TypeDefIndex: 61269
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

	public struct S2BoolMap : IMapWrapper<string, bool, S2BoolMap>, IEnumerable<KeyValuePair<string, bool>> // TypeDefIndex: 61270
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public bool this[string key] { get => default; } // 0x000000018B5A1B1C-0x000000018B5A1B60 
	
		// Constructors
		public S2BoolMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(string key); // 0x0000000183290380-0x00000001832903D0
		public string GetKeyByIndex(int index); // 0x0000000184240900-0x0000000184240950
		public bool GetValue(string key); // 0x000000018B5A1B1C-0x000000018B5A1B60
		public bool TryGetValue(string key, out bool value); // 0x0000000183753440-0x00000001837534D0
		public bool GetValueByIndex(int index); // 0x000000018B596AE4-0x000000018B596B28
		public MapEnumerator<string, bool, S2BoolMap> GetEnumerator(); // 0x000000018B5A1A44-0x000000018B5A1B1C
		IEnumerator<KeyValuePair<string, bool>> IEnumerable<KeyValuePair<string, bool>>.GetEnumerator(); // 0x000000018B5A1B60-0x000000018B5A1BE0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5A1BE0-0x000000018B5A1C60
	}

	public struct S2ByteMap : IMapWrapper<string, byte, S2ByteMap>, IEnumerable<KeyValuePair<string, byte>> // TypeDefIndex: 61271
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public byte this[string key] { get => default; } // 0x000000018B5A1D38-0x000000018B5A1D7C 
	
		// Constructors
		public S2ByteMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(string key); // 0x0000000183290380-0x00000001832903D0
		public string GetKeyByIndex(int index); // 0x0000000184240900-0x0000000184240950
		public byte GetValue(string key); // 0x000000018B5A1D38-0x000000018B5A1D7C
		public bool TryGetValue(string key, out byte value); // 0x000000018B5A1E7C-0x000000018B5A1EC0
		public byte GetValueByIndex(int index); // 0x000000018B596D80-0x000000018B596DC4
		public MapEnumerator<string, byte, S2ByteMap> GetEnumerator(); // 0x000000018B5A1C60-0x000000018B5A1D38
		IEnumerator<KeyValuePair<string, byte>> IEnumerable<KeyValuePair<string, byte>>.GetEnumerator(); // 0x000000018B5A1D7C-0x000000018B5A1DFC
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5A1DFC-0x000000018B5A1E7C
	}

	public struct S2IntMap : IMapWrapper<string, int, S2IntMap>, IEnumerable<KeyValuePair<string, int>> // TypeDefIndex: 61272
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int this[string key] { get => default; } // 0x0000000183BAFD90-0x0000000183BAFE50 
	
		// Constructors
		public S2IntMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(string key); // 0x0000000183290380-0x00000001832903D0
		public string GetKeyByIndex(int index); // 0x0000000184240900-0x0000000184240950
		public int GetValue(string key); // 0x0000000183BAFD90-0x0000000183BAFE50
		public bool TryGetValue(string key, out int value); // 0x000000018353C290-0x000000018353C320
		public int GetValueByIndex(int index); // 0x000000018B5973C0-0x000000018B597404
		public MapEnumerator<string, int, S2IntMap> GetEnumerator(); // 0x000000018B5A2380-0x000000018B5A2458
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator(); // 0x000000018B5A2458-0x000000018B5A24D8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5A24D8-0x000000018B5A2558
	}

	public struct S2LongMap : IMapWrapper<string, long, S2LongMap>, IEnumerable<KeyValuePair<string, long>> // TypeDefIndex: 61273
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public long this[string key] { get => default; } // 0x000000018B5A2630-0x000000018B5A2674 
	
		// Constructors
		public S2LongMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(string key); // 0x0000000183290380-0x00000001832903D0
		public string GetKeyByIndex(int index); // 0x0000000184240900-0x0000000184240950
		public long GetValue(string key); // 0x000000018B5A2630-0x000000018B5A2674
		public bool TryGetValue(string key, out long value); // 0x000000018B5A2774-0x000000018B5A27B8
		public long GetValueByIndex(int index); // 0x000000018B59765C-0x000000018B5976A0
		public MapEnumerator<string, long, S2LongMap> GetEnumerator(); // 0x000000018B5A2558-0x000000018B5A2630
		IEnumerator<KeyValuePair<string, long>> IEnumerable<KeyValuePair<string, long>>.GetEnumerator(); // 0x000000018B5A2674-0x000000018B5A26F4
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5A26F4-0x000000018B5A2774
	}

	public struct S2FloatMap : IMapWrapper<string, float, S2FloatMap>, IEnumerable<KeyValuePair<string, float>> // TypeDefIndex: 61274
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public float this[string key] { get => default; } // 0x000000018B5A21F8-0x000000018B5A223C 
	
		// Constructors
		public S2FloatMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(string key); // 0x0000000183290380-0x00000001832903D0
		public string GetKeyByIndex(int index); // 0x0000000184240900-0x0000000184240950
		public float GetValue(string key); // 0x000000018B5A21F8-0x000000018B5A223C
		public bool TryGetValue(string key, out float value); // 0x000000018B5A233C-0x000000018B5A2380
		public float GetValueByIndex(int index); // 0x000000018B59C568-0x000000018B59C5AC
		public MapEnumerator<string, float, S2FloatMap> GetEnumerator(); // 0x000000018B5A2120-0x000000018B5A21F8
		IEnumerator<KeyValuePair<string, float>> IEnumerable<KeyValuePair<string, float>>.GetEnumerator(); // 0x000000018B5A223C-0x000000018B5A22BC
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5A22BC-0x000000018B5A233C
	}

	public struct S2DoubleMap : IMapWrapper<string, double, S2DoubleMap>, IEnumerable<KeyValuePair<string, double>> // TypeDefIndex: 61275
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public double this[string key] { get => default; } // 0x000000018B5A1F98-0x000000018B5A1FDC 
	
		// Constructors
		public S2DoubleMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(string key); // 0x0000000183290380-0x00000001832903D0
		public string GetKeyByIndex(int index); // 0x0000000184240900-0x0000000184240950
		public double GetValue(string key); // 0x000000018B5A1F98-0x000000018B5A1FDC
		public bool TryGetValue(string key, out double value); // 0x000000018B5A20DC-0x000000018B5A2120
		public double GetValueByIndex(int index); // 0x000000018B59701C-0x000000018B597060
		public MapEnumerator<string, double, S2DoubleMap> GetEnumerator(); // 0x000000018B5A1EC0-0x000000018B5A1F98
		IEnumerator<KeyValuePair<string, double>> IEnumerable<KeyValuePair<string, double>>.GetEnumerator(); // 0x000000018B5A1FDC-0x000000018B5A205C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5A205C-0x000000018B5A20DC
	}

	public struct S2StringMap : IMapWrapper<string, string, S2StringMap>, IEnumerable<KeyValuePair<string, string>> // TypeDefIndex: 61276
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public string this[string key] { get => default; } // 0x000000018B5A2890-0x000000018B5A28D4 
	
		// Constructors
		public S2StringMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(string key); // 0x0000000183290380-0x00000001832903D0
		public string GetKeyByIndex(int index); // 0x0000000184240900-0x0000000184240950
		public string GetValue(string key); // 0x000000018B5A2890-0x000000018B5A28D4
		public bool TryGetValue(string key, out string value); // 0x00000001841EEFC0-0x00000001841EF060
		public string GetValueByIndex(int index); // 0x000000018B59CC34-0x000000018B59CC78
		public MapEnumerator<string, string, S2StringMap> GetEnumerator(); // 0x000000018B5A27B8-0x000000018B5A2890
		IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator(); // 0x000000018B5A28D4-0x000000018B5A2954
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5A2954-0x000000018B5A29D4
	}

	public struct I2NullableBeanMap<TBean> : IMapWrapper<int, TBean?, I2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<int, TBean?>> // TypeDefIndex: 61277
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

	public struct I2BeanMap<TBean> : IMapWrapper<int, TBean, I2BeanMap<TBean>>, IEnumerable<KeyValuePair<int, TBean>> // TypeDefIndex: 61278
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

	public struct I2EnumMap<TEnum> : IMapWrapper<int, TEnum, I2EnumMap<TEnum>>, IEnumerable<KeyValuePair<int, TEnum>> // TypeDefIndex: 61279
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

	public struct I2BoolMap : IMapWrapper<int, bool, I2BoolMap>, IEnumerable<KeyValuePair<int, bool>> // TypeDefIndex: 61280
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public bool this[int key] { get => default; } // 0x000000018B596B28-0x000000018B596B6C 
	
		// Constructors
		public I2BoolMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018856A078-0x000000018856A0BC
		public int GetKeyByIndex(int index); // 0x00000001836A33E0-0x00000001836A3430
		public bool GetValue(int key); // 0x000000018B596B28-0x000000018B596B6C
		public bool TryGetValue(int key, out bool value); // 0x000000018B596C6C-0x000000018B596CB0
		public bool GetValueByIndex(int index); // 0x000000018B596AE4-0x000000018B596B28
		public MapEnumerator<int, bool, I2BoolMap> GetEnumerator(); // 0x000000018B596A14-0x000000018B596AE4
		IEnumerator<KeyValuePair<int, bool>> IEnumerable<KeyValuePair<int, bool>>.GetEnumerator(); // 0x000000018B596B6C-0x000000018B596BEC
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B596BEC-0x000000018B596C6C
	}

	public struct I2ByteMap : IMapWrapper<int, byte, I2ByteMap>, IEnumerable<KeyValuePair<int, byte>> // TypeDefIndex: 61281
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public byte this[int key] { get => default; } // 0x000000018B596DC4-0x000000018B596E08 
	
		// Constructors
		public I2ByteMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018856A078-0x000000018856A0BC
		public int GetKeyByIndex(int index); // 0x00000001836A33E0-0x00000001836A3430
		public byte GetValue(int key); // 0x000000018B596DC4-0x000000018B596E08
		public bool TryGetValue(int key, out byte value); // 0x000000018B596F08-0x000000018B596F4C
		public byte GetValueByIndex(int index); // 0x000000018B596D80-0x000000018B596DC4
		public MapEnumerator<int, byte, I2ByteMap> GetEnumerator(); // 0x000000018B596CB0-0x000000018B596D80
		IEnumerator<KeyValuePair<int, byte>> IEnumerable<KeyValuePair<int, byte>>.GetEnumerator(); // 0x000000018B596E08-0x000000018B596E88
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B596E88-0x000000018B596F08
	}

	public struct I2IntMap : IMapWrapper<int, int, I2IntMap>, IEnumerable<KeyValuePair<int, int>> // TypeDefIndex: 61282
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int this[int key] { get => default; } // 0x000000018B597404-0x000000018B597448 
	
		// Constructors
		public I2IntMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018856A078-0x000000018856A0BC
		public int GetKeyByIndex(int index); // 0x00000001836A33E0-0x00000001836A3430
		public int GetValue(int key); // 0x000000018B597404-0x000000018B597448
		public bool TryGetValue(int key, out int value); // 0x000000018B597548-0x000000018B59758C
		public int GetValueByIndex(int index); // 0x000000018B5973C0-0x000000018B597404
		public MapEnumerator<int, int, I2IntMap> GetEnumerator(); // 0x000000018B5972F0-0x000000018B5973C0
		IEnumerator<KeyValuePair<int, int>> IEnumerable<KeyValuePair<int, int>>.GetEnumerator(); // 0x000000018B597448-0x000000018B5974C8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5974C8-0x000000018B597548
	}

	public struct I2LongMap : IMapWrapper<int, long, I2LongMap>, IEnumerable<KeyValuePair<int, long>> // TypeDefIndex: 61283
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public long this[int key] { get => default; } // 0x000000018B5976A0-0x000000018B5976E4 
	
		// Constructors
		public I2LongMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018856A078-0x000000018856A0BC
		public int GetKeyByIndex(int index); // 0x00000001836A33E0-0x00000001836A3430
		public long GetValue(int key); // 0x000000018B5976A0-0x000000018B5976E4
		public bool TryGetValue(int key, out long value); // 0x000000018B5977E4-0x000000018B597828
		public long GetValueByIndex(int index); // 0x000000018B59765C-0x000000018B5976A0
		public MapEnumerator<int, long, I2LongMap> GetEnumerator(); // 0x000000018B59758C-0x000000018B59765C
		IEnumerator<KeyValuePair<int, long>> IEnumerable<KeyValuePair<int, long>>.GetEnumerator(); // 0x000000018B5976E4-0x000000018B597764
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B597764-0x000000018B5977E4
	}

	public struct I2FloatMap : IMapWrapper<int, float, I2FloatMap>, IEnumerable<KeyValuePair<int, float>> // TypeDefIndex: 61284
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public float this[int key] { get => default; } // 0x000000018B5971E8-0x000000018B59722C 
	
		// Constructors
		public I2FloatMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018856A078-0x000000018856A0BC
		public int GetKeyByIndex(int index); // 0x00000001836A33E0-0x00000001836A3430
		public float GetValue(int key); // 0x000000018B5971E8-0x000000018B59722C
		public bool TryGetValue(int key, out float value); // 0x000000018B5972AC-0x000000018B5972F0
		public float GetValueByIndex(int index); // 0x0000000183E31CF0-0x0000000183E31D60
		public MapEnumerator<int, float, I2FloatMap> GetEnumerator(); // 0x0000000184B880E0-0x0000000184B88160
		IEnumerator<KeyValuePair<int, float>> IEnumerable<KeyValuePair<int, float>>.GetEnumerator(); // 0x0000000184B88060-0x0000000184B880E0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59722C-0x000000018B5972AC
	}

	public struct I2DoubleMap : IMapWrapper<int, double, I2DoubleMap>, IEnumerable<KeyValuePair<int, double>> // TypeDefIndex: 61285
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public double this[int key] { get => default; } // 0x000000018B597060-0x000000018B5970A4 
	
		// Constructors
		public I2DoubleMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018856A078-0x000000018856A0BC
		public int GetKeyByIndex(int index); // 0x00000001836A33E0-0x00000001836A3430
		public double GetValue(int key); // 0x000000018B597060-0x000000018B5970A4
		public bool TryGetValue(int key, out double value); // 0x000000018B5971A4-0x000000018B5971E8
		public double GetValueByIndex(int index); // 0x000000018B59701C-0x000000018B597060
		public MapEnumerator<int, double, I2DoubleMap> GetEnumerator(); // 0x000000018B596F4C-0x000000018B59701C
		IEnumerator<KeyValuePair<int, double>> IEnumerable<KeyValuePair<int, double>>.GetEnumerator(); // 0x000000018B5970A4-0x000000018B597124
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B597124-0x000000018B5971A4
	}

	public struct I2StringMap : IMapWrapper<int, string, I2StringMap>, IEnumerable<KeyValuePair<int, string>> // TypeDefIndex: 61286
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public string this[int key] { get => default; } // 0x0000000183062660-0x00000001830627F0 
	
		// Constructors
		public I2StringMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(int key); // 0x000000018331BB00-0x000000018331BB50
		public int GetKeyByIndex(int index); // 0x00000001836A33E0-0x00000001836A3430
		public string GetValue(int key); // 0x0000000184060770-0x00000001840607F0
		public bool TryGetValue(int key, out string value); // 0x000000018397BA10-0x000000018397BAB0
		public string GetValueByIndex(int index); // 0x00000001836A3340-0x00000001836A33B0
		public MapEnumerator<int, string, I2StringMap> GetEnumerator(); // 0x00000001847F9D50-0x00000001847F9DD0
		IEnumerator<KeyValuePair<int, string>> IEnumerable<KeyValuePair<int, string>>.GetEnumerator(); // 0x000000018B597828-0x000000018B5978A8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5978A8-0x000000018B597928
	}

	public struct L2BoolMap : IMapWrapper<long, bool, L2BoolMap>, IEnumerable<KeyValuePair<long, bool>> // TypeDefIndex: 61287
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public bool this[long key] { get => default; } // 0x000000018B59BC08-0x000000018B59BC4C 
	
		// Constructors
		public L2BoolMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(long key); // 0x00000001886D7B08-0x00000001886D7B4C
		public long GetKeyByIndex(int index); // 0x00000001886D7B4C-0x00000001886D7B90
		public bool GetValue(long key); // 0x000000018B59BC08-0x000000018B59BC4C
		public bool TryGetValue(long key, out bool value); // 0x000000018B59BD4C-0x000000018B59BD90
		public bool GetValueByIndex(int index); // 0x000000018B596AE4-0x000000018B596B28
		public MapEnumerator<long, bool, L2BoolMap> GetEnumerator(); // 0x000000018B59BB38-0x000000018B59BC08
		IEnumerator<KeyValuePair<long, bool>> IEnumerable<KeyValuePair<long, bool>>.GetEnumerator(); // 0x000000018B59BC4C-0x000000018B59BCCC
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59BCCC-0x000000018B59BD4C
	}

	public struct L2ByteMap : IMapWrapper<long, byte, L2ByteMap>, IEnumerable<KeyValuePair<long, byte>> // TypeDefIndex: 61288
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public byte this[long key] { get => default; } // 0x000000018B59BE60-0x000000018B59BEA4 
	
		// Constructors
		public L2ByteMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(long key); // 0x00000001886D7B08-0x00000001886D7B4C
		public long GetKeyByIndex(int index); // 0x00000001886D7B4C-0x00000001886D7B90
		public byte GetValue(long key); // 0x000000018B59BE60-0x000000018B59BEA4
		public bool TryGetValue(long key, out byte value); // 0x000000018B59BFA4-0x000000018B59BFE8
		public byte GetValueByIndex(int index); // 0x000000018B596D80-0x000000018B596DC4
		public MapEnumerator<long, byte, L2ByteMap> GetEnumerator(); // 0x000000018B59BD90-0x000000018B59BE60
		IEnumerator<KeyValuePair<long, byte>> IEnumerable<KeyValuePair<long, byte>>.GetEnumerator(); // 0x000000018B59BEA4-0x000000018B59BF24
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59BF24-0x000000018B59BFA4
	}

	public struct L2IntMap : IMapWrapper<long, int, L2IntMap>, IEnumerable<KeyValuePair<long, int>> // TypeDefIndex: 61289
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int this[long key] { get => default; } // 0x000000018B59C310-0x000000018B59C354 
	
		// Constructors
		public L2IntMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(long key); // 0x00000001886D7B08-0x00000001886D7B4C
		public long GetKeyByIndex(int index); // 0x00000001886D7B4C-0x00000001886D7B90
		public int GetValue(long key); // 0x000000018B59C310-0x000000018B59C354
		public bool TryGetValue(long key, out int value); // 0x000000018B59C454-0x000000018B59C498
		public int GetValueByIndex(int index); // 0x000000018B5973C0-0x000000018B597404
		public MapEnumerator<long, int, L2IntMap> GetEnumerator(); // 0x000000018B59C734-0x000000018B59C804
		IEnumerator<KeyValuePair<long, int>> IEnumerable<KeyValuePair<long, int>>.GetEnumerator(); // 0x000000018B59C804-0x000000018B59C884
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59C884-0x000000018B59C904
	}

	public struct L2LongMap : IMapWrapper<long, long, L2LongMap>, IEnumerable<KeyValuePair<long, long>> // TypeDefIndex: 61290
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public long this[long key] { get => default; } // 0x000000018B59C9D4-0x000000018B59CA18 
	
		// Constructors
		public L2LongMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(long key); // 0x00000001886D7B08-0x00000001886D7B4C
		public long GetKeyByIndex(int index); // 0x00000001886D7B4C-0x00000001886D7B90
		public long GetValue(long key); // 0x000000018B59C9D4-0x000000018B59CA18
		public bool TryGetValue(long key, out long value); // 0x000000018B59CB18-0x000000018B59CB5C
		public long GetValueByIndex(int index); // 0x000000018B59765C-0x000000018B5976A0
		public MapEnumerator<long, long, L2LongMap> GetEnumerator(); // 0x000000018B59C904-0x000000018B59C9D4
		IEnumerator<KeyValuePair<long, long>> IEnumerable<KeyValuePair<long, long>>.GetEnumerator(); // 0x000000018B59CA18-0x000000018B59CA98
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59CA98-0x000000018B59CB18
	}

	public struct L2FloatMap : IMapWrapper<long, float, L2FloatMap>, IEnumerable<KeyValuePair<long, float>> // TypeDefIndex: 61291
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public float this[long key] { get => default; } // 0x000000018B59C5AC-0x000000018B59C5F0 
	
		// Constructors
		public L2FloatMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(long key); // 0x00000001886D7B08-0x00000001886D7B4C
		public long GetKeyByIndex(int index); // 0x00000001886D7B4C-0x00000001886D7B90
		public float GetValue(long key); // 0x000000018B59C5AC-0x000000018B59C5F0
		public bool TryGetValue(long key, out float value); // 0x000000018B59C6F0-0x000000018B59C734
		public float GetValueByIndex(int index); // 0x000000018B59C568-0x000000018B59C5AC
		public MapEnumerator<long, float, L2FloatMap> GetEnumerator(); // 0x000000018B59C498-0x000000018B59C568
		IEnumerator<KeyValuePair<long, float>> IEnumerable<KeyValuePair<long, float>>.GetEnumerator(); // 0x000000018B59C5F0-0x000000018B59C670
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59C670-0x000000018B59C6F0
	}

	public struct L2DoubleMap : IMapWrapper<long, double, L2DoubleMap>, IEnumerable<KeyValuePair<long, double>> // TypeDefIndex: 61292
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public double this[long key] { get => default; } // 0x000000018B59C0B8-0x000000018B59C0FC 
	
		// Constructors
		public L2DoubleMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(long key); // 0x00000001886D7B08-0x00000001886D7B4C
		public long GetKeyByIndex(int index); // 0x00000001886D7B4C-0x00000001886D7B90
		public double GetValue(long key); // 0x000000018B59C0B8-0x000000018B59C0FC
		public bool TryGetValue(long key, out double value); // 0x000000018B59C1FC-0x000000018B59C240
		public double GetValueByIndex(int index); // 0x000000018B59701C-0x000000018B597060
		public MapEnumerator<long, double, L2DoubleMap> GetEnumerator(); // 0x000000018B59BFE8-0x000000018B59C0B8
		IEnumerator<KeyValuePair<long, double>> IEnumerable<KeyValuePair<long, double>>.GetEnumerator(); // 0x000000018B59C0FC-0x000000018B59C17C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59C17C-0x000000018B59C1FC
	}

	public struct L2StringMap : IMapWrapper<long, string, L2StringMap>, IEnumerable<KeyValuePair<long, string>> // TypeDefIndex: 61293
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public string this[long key] { get => default; } // 0x000000018B59CC78-0x000000018B59CCBC 
	
		// Constructors
		public L2StringMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(long key); // 0x00000001886D7B08-0x00000001886D7B4C
		public long GetKeyByIndex(int index); // 0x00000001886D7B4C-0x00000001886D7B90
		public string GetValue(long key); // 0x000000018B59CC78-0x000000018B59CCBC
		public bool TryGetValue(long key, out string value); // 0x00000001839CE6C0-0x00000001839CE760
		public string GetValueByIndex(int index); // 0x000000018B59CC34-0x000000018B59CC78
		public MapEnumerator<long, string, L2StringMap> GetEnumerator(); // 0x000000018B59CB5C-0x000000018B59CC34
		IEnumerator<KeyValuePair<long, string>> IEnumerable<KeyValuePair<long, string>>.GetEnumerator(); // 0x000000018B59CCBC-0x000000018B59CD3C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59CD3C-0x000000018B59CDBC
	}

	public struct L2EnumMap : IMapWrapper<long, int, L2EnumMap>, IEnumerable<KeyValuePair<long, int>> // TypeDefIndex: 61294
	{
		// Fields
		private readonly Beyond.SparkBuffer.Runtime.Map m_map; // 0x00
	
		// Properties
		public int count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int Count { get; } // 0x0000000182BB2A50-0x0000000182BB2A70 
		public int this[long key] { get => default; } // 0x000000018B59C310-0x000000018B59C354 
	
		// Constructors
		public L2EnumMap(Beyond.SparkBuffer.Runtime.Map map); // 0x0000000189DC2B6C-0x0000000189DC2BA0
	
		// Methods
		public bool ContainsKey(long key); // 0x00000001886D7B08-0x00000001886D7B4C
		public long GetKeyByIndex(int index); // 0x00000001886D7B4C-0x00000001886D7B90
		public int GetValue(long key); // 0x000000018B59C310-0x000000018B59C354
		public bool TryGetValue(long key, out int value); // 0x000000018B59C454-0x000000018B59C498
		public int GetValueByIndex(int index); // 0x000000018B5973C0-0x000000018B597404
		public MapEnumerator<long, int, L2EnumMap> GetEnumerator(); // 0x000000018B59C240-0x000000018B59C310
		IEnumerator<KeyValuePair<long, int>> IEnumerable<KeyValuePair<long, int>>.GetEnumerator(); // 0x000000018B59C354-0x000000018B59C3D4
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B59C3D4-0x000000018B59C454
	}

	public struct L2NullableBeanMap<TBean> : IMapWrapper<long, TBean?, L2NullableBeanMap<TBean>>, IEnumerable<KeyValuePair<long, TBean?>> // TypeDefIndex: 61295
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

	public struct L2BeanMap<TBean> : IMapWrapper<long, TBean, L2BeanMap<TBean>>, IEnumerable<KeyValuePair<long, TBean>> // TypeDefIndex: 61296
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
	internal static class Extensions // TypeDefIndex: 61297
	{
		// Extension methods
		public static bool Contains<T>(this IList<T> list, T element);
		public static bool IsNullOrEmpty<T>(this IList<T> list);
		public static bool IsNullOrEmpty<T>(this ICollection<T> list);
		public static bool IsNullOrEmpty(this OrderedDictionary dict); // 0x000000018B5968FC-0x000000018B59691C
		public static T[] ToArrayE<T>(this IEnumerable<T> enumerable);
		public static T GetValue<T>(this DictionaryEntry entry)
			where T : class;
	}

	public class JsonSerializer // TypeDefIndex: 61298
	{
		// Constructors
		public JsonSerializer(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static string Serialize<T>(T obj, bool indented);
		public static string Serialize(object obj, bool indented); // 0x000000018B59B334-0x000000018B59B364
		private static string _SerializeDirect(ObjectReflector.ReflectObject reflectObj, bool indented); // 0x000000018B59B364-0x000000018B59B558
		private static void _WriteReflectObj(JsonWriter writer, ObjectReflector.ReflectObject reflectObj); // 0x000000018B59B558-0x000000018B59BB38
	}

	internal class ObjectReflector // TypeDefIndex: 61304
	{
		// Fields
		private List<object> m_tempList; // 0x10
		private Dictionary<System.Type, ReflectType> m_typeMap; // 0x18
	
		// Nested types
		public struct ReflectResult // TypeDefIndex: 61299
		{
			// Fields
			public ReflectType[] types; // 0x00
			public ReflectObject rootObj; // 0x08
		}
	
		public class ReflectType // TypeDefIndex: 61301
		{
			// Fields
			public SparkType sparkType; // 0x10
			public System.Type concreteType; // 0x18
			public ReflectType subType1; // 0x20
			public ReflectType subType2; // 0x28
			public List<FieldInfo> beanFields; // 0x30
	
			// Nested types
			public struct FieldInfo // TypeDefIndex: 61300
			{
				// Fields
				public string name; // 0x00
				public ReflectType type; // 0x08
			}
	
			// Constructors
			public ReflectType(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class ReflectObject // TypeDefIndex: 61302
		{
			// Fields
			public object originObj; // 0x10
			public ReflectType reflectType; // 0x18
			public OrderedDictionary beanElements; // 0x20
			public List<ReflectObject> arrayElements; // 0x28
			public List<KeyValuePair<ReflectObject, ReflectObject>> mapElements; // 0x30
	
			// Constructors
			public ReflectObject(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61303
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<ReflectType> __9__7_0; // 0x08
			public static Comparison<ReflectType.FieldInfo> __9__9_0; // 0x10
			public static Comparison<KeyValuePair<ReflectObject, ReflectObject>> __9__13_0; // 0x18
			public static Func<System.Reflection.FieldInfo, int> __9__14_0; // 0x20
	
			// Constructors
			static __c(); // 0x000000018B5A6B44-0x000000018B5A6BA8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int __ParseInternal_b__7_0(ReflectType lhs, ReflectType rhs); // 0x000000018B5A69E0-0x000000018B5A6A28
			internal int __TryParseType_b__9_0(ReflectType.FieldInfo lhs, ReflectType.FieldInfo rhs); // 0x000000018B5A6AFC-0x000000018B5A6B14
			internal int __ReflectMap_b__13_0(KeyValuePair<ReflectObject, ReflectObject> lhs, KeyValuePair<ReflectObject, ReflectObject> rhs); // 0x000000018B5A6A28-0x000000018B5A6AFC
			internal int __GetFields_b__14_0(System.Reflection.FieldInfo field); // 0x000000018B5A69C0-0x000000018B5A69E0
		}
	
		// Constructors
		private ObjectReflector(); // 0x000000018B5A0D08-0x000000018B5A0DC8
	
		// Methods
		public static ReflectResult Parse(object obj); // 0x000000018B59E684-0x000000018B59E708
		private ReflectResult _ParseInternal(object obj); // 0x000000018B59E9FC-0x000000018B59ED08
		private ReflectType _ParseTypeMap(System.Type rootType); // 0x000000018B59ED08-0x000000018B59EDE0
		private bool _TryParseType(System.Type type, out ReflectType reflectType); // 0x000000018B59FD60-0x000000018B5A0D08
		private ReflectObject _ReflectObject(object obj, ReflectType reflectType); // 0x000000018B59FBD0-0x000000018B59FD60
		private ReflectObject _ReflectBean(object obj, ReflectType reflectType); // 0x000000018B59F340-0x000000018B59F87C
		private ReflectObject _ReflectArray(object obj, ReflectType reflectType); // 0x000000018B59EDE0-0x000000018B59F340
		private ReflectObject _ReflectMap(object obj, ReflectType reflectType); // 0x000000018B59F87C-0x000000018B59FBD0
		private IEnumerable<System.Reflection.FieldInfo> _GetFields(System.Type type); // 0x000000018B59E8D8-0x000000018B59E9FC
		private object[] _ConvertICollectionToArray(ICollection collection); // 0x000000018B59E708-0x000000018B59E8D8
	}

	public class SparkSerializer : IDisposable // TypeDefIndex: 61309
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
		private struct ReservedField // TypeDefIndex: 61305
		{
			// Fields
			public int position; // 0x00
			public ObjectReflector.ReflectObject reflectObj; // 0x08
		}
	
		public struct Options // TypeDefIndex: 61306
		{
			// Fields
			public static readonly Options DEFAULT; // 0x00
			public string rootName; // 0x00
			public string stripTypeNamePrefix; // 0x08
	
			// Constructors
			public Options(string rootName); // 0x00000001833928A0-0x0000000183392930
			public Options(string rootName, string stripTypeNamePrefix); // 0x00000001839CF630-0x00000001839CF660
			static Options(); // 0x000000018B5A7BB0-0x000000018B5A7C44
		}
	
		private struct HashSlot // TypeDefIndex: 61307
		{
			// Fields
			public int offset; // 0x00
			public int bucketsSize; // 0x04
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 61308
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<string> __9__23_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B5A9B84-0x000000018B5A9BE8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int __ExportStrings_b__23_0(string lhs, string rhs); // 0x000000018A7BA4E0-0x000000018A7BA4F4
		}
	
		// Constructors
		private SparkSerializer(Options options); // 0x000000018B5A6760-0x000000018B5A6954
	
		// Methods
		public static byte[] Serialize<T>(T obj);
		public static byte[] Serialize<T>(T obj, Options options);
		public static byte[] Serialize(object obj); // 0x000000018B5A3138-0x000000018B5A3198
		public static byte[] Serialize(object obj, Options options); // 0x000000018B5A3198-0x000000018B5A32AC
		public void Dispose(); // 0x000000018B5A30EC-0x000000018B5A310C
		private byte[] _SerializeInternal(object obj); // 0x000000018B5A6514-0x000000018B5A6684
		private void _PreprocessTypes(ObjectReflector.ReflectType[] reflectTypes); // 0x000000018B5A6308-0x000000018B5A6514
		private void _ExportTypeDefs(); // 0x000000018B5A5DA0-0x000000018B5A6028
		private void _ExportEnumType(ObjectReflector.ReflectType enumType); // 0x000000018B5A4C34-0x000000018B5A5088
		private void _ExportBeanType(ObjectReflector.ReflectType beanType); // 0x000000018B5A442C-0x000000018B5A4768
		private string _ParseTypeName(System.Type reflectType); // 0x000000018B5A629C-0x000000018B5A6308
		private static HashSet<string> _CollectAllStrings(ObjectReflector.ReflectObject rootObj); // 0x000000018B5A3338-0x000000018B5A39F0
		private List<List<string>> _GenStringHashList(HashSet<string> strings); // 0x000000018B5A6028-0x000000018B5A629C
		private void _ExportStrings(ObjectReflector.ReflectObject rootObj); // 0x000000018B5A5B08-0x000000018B5A5DA0
		private void _ExportElementData(ObjectReflector.ReflectObject elementObj, List<ReservedField> reservedFields); // 0x000000018B5A485C-0x000000018B5A4C34
		private int _ExportBeanData(ObjectReflector.ReflectObject beanObj); // 0x000000018B5A4050-0x000000018B5A442C
		private int _ExportArrayData(ObjectReflector.ReflectObject arrayObj); // 0x000000018B5A3DFC-0x000000018B5A4050
		private int _ExportMapData(ObjectReflector.ReflectObject mapObj); // 0x000000018B5A5088-0x000000018B5A56BC
		private Dictionary<int, List<KeyValuePair<ObjectReflector.ReflectObject, ObjectReflector.ReflectObject>>> _CreateMapHashEntry(List<KeyValuePair<ObjectReflector.ReflectObject, ObjectReflector.ReflectObject>> mapElements, SparkType keyType); // 0x000000018B5A39F0-0x000000018B5A3DFC
		private void _ExportRootDef(ObjectReflector.ReflectType rootType); // 0x000000018B5A5928-0x000000018B5A5B08
		private int _ExportDataFromRoot(ObjectReflector.ReflectObject rootObj); // 0x000000018B5A4768-0x000000018B5A485C
		private void _ExportReservedFields(List<ReservedField> reservedFields); // 0x000000018B5A56BC-0x000000018B5A5928
		public static int GetStableStringHash(string str); // 0x0000000182F05D70-0x0000000182F05E20
		public static int GetStableTypeHash(System.Type type); // 0x000000018B5A310C-0x000000018B5A3138
		private void _WriteConcreteType(System.Type type); // 0x000000018B5A6684-0x000000018B5A6760
		[CompilerGenerated]
		private int __ExportTypeDefs_b__17_0(ObjectReflector.ReflectType lhs, ObjectReflector.ReflectType rhs); // 0x000000018B5A32AC-0x000000018B5A3338
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61315
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D372C0-0x0000000184D37330
	
		// Methods
		public IntPtr __Gen_Wrap_0(object P0); // 0x00000001867CDB90-0x00000001867CDC4C
		public ReadOnlySpan<byte> __Gen_Wrap_1(IntPtr P0, int P1); // 0x000000018B5A7468-0x000000018B5A757C
		public IntPtr __Gen_Wrap_2(int P0); // 0x00000001863606FC-0x00000001863607B4
		public void __Gen_Wrap_3(int P0, IntPtr P1); // 0x000000018B5A757C-0x000000018B5A7644
		public void __Gen_Wrap_4(); // 0x00000001863761FC-0x0000000186376284
		public string __Gen_Wrap_5(); // 0x000000018B5A7644-0x000000018B5A76FC
		public void __Gen_Wrap_6(object P0, IntPtr P1); // 0x0000000189CC7624-0x0000000189CC76EC
		public StructPtrWrapper __Gen_Wrap_7(IntPtr P0, int P1, object P2); // 0x000000018B5A76FC-0x000000018B5A7810
		public StructPtrWrapper __Gen_Wrap_8(object P0); // 0x000000018B5A7810-0x000000018B5A78EC
		public void __Gen_Wrap_9(object P0); // 0x00000001866C296C-0x00000001866C2A18
		public object __Gen_Wrap_10(object P0); // 0x000000018B5A7008-0x000000018B5A70E4
		public object __Gen_Wrap_11(IntPtr P0, object P1, int P2); // 0x000000018B5A70E4-0x000000018B5A71F8
		public void __Gen_Wrap_12(object P0, object P1); // 0x0000000189C8B45C-0x0000000189C8B524
		public int __Gen_Wrap_13(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public bool __Gen_Wrap_14(object P0, object P1); // 0x000000018A8A1EF4-0x000000018A8A1FCC
		public string __Gen_Wrap_15(object P0); // 0x000000018B5A71F8-0x000000018B5A72D4
		public System.Type __Gen_Wrap_16(object P0); // 0x000000018B5A72D4-0x000000018B5A73B0
		public StructPtrWrapper __Gen_Wrap_17(); // 0x000000018B5A73B0-0x000000018B5A7468
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 61316
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018B5A78EC-0x000000018B5A7980
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61317
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018B5A9DD0-0x000000018B5A9E34
		public static bool IsPatched(int id); // 0x000000018328E430-0x000000018328E480
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018B5A9C8C-0x000000018B5A9D58
		public object CreateWrapper(int id); // 0x000000018B5A9D58-0x000000018B5A9DD0
		public object InitWrapperArray(int len); // 0x000000018B5A9E34-0x000000018B5A9EC0
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018B5A9BE8-0x000000018B5A9C8C
	}

	public enum IDMAP0 // TypeDefIndex: 61318
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
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 61219
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 61220
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
