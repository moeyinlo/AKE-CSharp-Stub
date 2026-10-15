/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.CodeAnalysis;
using Proto;
using ProtoBuf;
using ProtoBuf.Compiler;
using ProtoBuf.Internal;
using ProtoBuf.Internal.Serializers;
using ProtoBuf.Meta;
using ProtoBuf.Serializers;
using ProtoBuf.WellKnownTypes;

// Image 22: protobuf-net.dll - Assembly: protobuf-net, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 80463-80825

[CompilerGenerated]
internal sealed class __f__AnonymousType0<_method_j__TPar, _args_j__TPar> // TypeDefIndex: 80464
{
	// Fields
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _method_j__TPar _method_i__Field;
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _args_j__TPar _args_i__Field;

	// Properties
	public _method_j__TPar method { get; }
	public _args_j__TPar args { get; }

	// Constructors
	[DebuggerHidden]
	public __f__AnonymousType0(_method_j__TPar method, _args_j__TPar args);

	// Methods
	[DebuggerHidden]
	public override bool Equals(object value);
	[DebuggerHidden]
	public override int GetHashCode();
	[DebuggerHidden]
	public override string ToString();
}

[CompilerGenerated]
internal sealed class __f__AnonymousType1<___h__TransparentIdentifier0_j__TPar, _paramType_j__TPar> // TypeDefIndex: 80465
{
	// Fields
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ___h__TransparentIdentifier0_j__TPar ___h__TransparentIdentifier0_i__Field;
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _paramType_j__TPar _paramType_i__Field;

	// Properties
	public ___h__TransparentIdentifier0_j__TPar <>h__TransparentIdentifier0 { get; }
	public _paramType_j__TPar paramType { get; }

	// Constructors
	[DebuggerHidden]
	public __f__AnonymousType1(___h__TransparentIdentifier0_j__TPar __h__TransparentIdentifier0, _paramType_j__TPar paramType);

	// Methods
	[DebuggerHidden]
	public override bool Equals(object value);
	[DebuggerHidden]
	public override int GetHashCode();
	[DebuggerHidden]
	public override string ToString();
}

[CompilerGenerated]
internal sealed class __f__AnonymousType2<_Method_j__TPar, _Type_j__TPar> // TypeDefIndex: 80466
{
	// Fields
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _Method_j__TPar _Method_i__Field;
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _Type_j__TPar _Type_i__Field;

	// Properties
	public _Method_j__TPar Method { get; }
	public _Type_j__TPar Type { get; }

	// Constructors
	[DebuggerHidden]
	public __f__AnonymousType2(_Method_j__TPar Method, _Type_j__TPar Type);

	// Methods
	[DebuggerHidden]
	public override bool Equals(object value);
	[DebuggerHidden]
	public override int GetHashCode();
	[DebuggerHidden]
	public override string ToString();
}

[CompilerGenerated]
internal sealed class __f__AnonymousType3<_ArgCount_j__TPar, _Method_j__TPar> // TypeDefIndex: 80467
{
	// Fields
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _ArgCount_j__TPar _ArgCount_i__Field;
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _Method_j__TPar _Method_i__Field;

	// Properties
	public _ArgCount_j__TPar ArgCount { get; }
	public _Method_j__TPar Method { get; }

	// Constructors
	[DebuggerHidden]
	public __f__AnonymousType3(_ArgCount_j__TPar ArgCount, _Method_j__TPar Method);

	// Methods
	[DebuggerHidden]
	public override bool Equals(object value);
	[DebuggerHidden]
	public override int GetHashCode();
	[DebuggerHidden]
	public override string ToString();
}

[CompilerGenerated]
internal sealed class __f__AnonymousType4<_Count_j__TPar, _Method_j__TPar> // TypeDefIndex: 80468
{
	// Fields
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _Count_j__TPar _Count_i__Field;
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly _Method_j__TPar _Method_i__Field;

	// Properties
	public _Count_j__TPar Count { get; }
	public _Method_j__TPar Method { get; }

	// Constructors
	[DebuggerHidden]
	public __f__AnonymousType4(_Count_j__TPar Count, _Method_j__TPar Method);

	// Methods
	[DebuggerHidden]
	public override bool Equals(object value);
	[DebuggerHidden]
	public override int GetHashCode();
	[DebuggerHidden]
	public override string ToString();
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 80825
{
	// Methods
	internal static uint ComputeStringHash(string s); // 0x0000000188B56950-0x0000000188B569A4
}

namespace Google.Protobuf
{
	public static class ProtoBufNetCompatMessageExtensions // TypeDefIndex: 80471
	{
		// Extension methods
		public static void MergeFrom(this IExtensible msg, byte[] buffer); // 0x000000018CB5DBB4-0x000000018CB5DBFC
		public static void MergeFrom(this IExtensible msg, byte[] buffer, int offset, int length); // 0x000000018CB5DB44-0x000000018CB5DBB4
		public static void MergeFrom(this IExtensible msg, ReadOnlySpan<byte> source); // 0x000000018CB5DBFC-0x000000018CB5DC50
		public static void MergeFrom(this IExtensible msg, Span<byte> source); // 0x000000018CB5DAF0-0x000000018CB5DB44
		public static byte[] ToByteArray(this IExtensible msg); // 0x000000018CB5DC50-0x000000018CB5DC8C
		public static int WriteToByteArray(this IExtensible msg, byte[] buffer, int offset); // 0x000000018CB5DC8C-0x000000018CB5DCE4
		public static void WriteTo(this IExtensible msg, Stream output); // 0x000000018CB5DCE4-0x000000018CB5DD2C
		public static int CalculateSize(this IExtensible msg); // 0x000000018CB5DAB4-0x000000018CB5DAF0
		public static T DeepClone<T>(this T msg)
			where T : class, IExtensible;
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 80469
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Proto
{
	public interface IProtoPooledMessage : IExtensible, IDisposable // TypeDefIndex: 80472
	{
		// Properties
		bool IsFactoryPool { get; set; }
	
		// Methods
		void ClearForPool();
		void OnProtoAllocated();
		void CopyFromObject(IProtoPooledMessage src);
		IProtoPooledMessage AllocateClone();
	}

	public static class ProtoPooledMessageExtensions // TypeDefIndex: 80473
	{
		// Extension methods
		public static T AllocateCopy<T>(this T src)
			where T : class, IProtoPooledMessage, new();
		public static IProtoPooledMessage AllocateCopy(this IProtoPooledMessage src); // 0x000000018CB5EE68-0x000000018CB5EEB4
	}

	internal static class ProtoRepeatedFieldDiagnostics<T> // TypeDefIndex: 80474
	{
		// Fields
		public const bool IsDuplicateTraceEnabled = false; // Metadata: 0x0263CB8F
	}

	public static class ProtoOwnershipTracker // TypeDefIndex: 80475
	{
		// Methods
		public static void AssignChild<T>(ref ref T storage, T value, object owner, string fieldName)
			where T : class;
		[Conditional("UNITY_EDITOR")]
		public static void ClaimChild(object child, object owner, string fieldName); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("UNITY_EDITOR")]
		public static void MoveChild(object child, object owner, string oldFieldName, string newFieldName); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("UNITY_EDITOR")]
		public static void ReleaseChild(object child, object owner, string fieldName); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("UNITY_EDITOR")]
		public static void OnAllocated(object msg); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("UNITY_EDITOR")]
		public static void OnDoubleDispose(object msg); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("UNITY_EDITOR")]
		public static void OnRecycle(object msg); // 0x0000000186805BA0-0x0000000186805BB0
		[Conditional("UNITY_EDITOR")]
		public static void LogRepeatedInputDuplicates<T>(string source, ArraySegment<T> values, int existingCount);
		[Conditional("UNITY_EDITOR")]
		public static void LogRepeatedFieldDuplicates<T>(RepeatedField<T> values, string source);
		public static void PrewarmRepeatedFieldDiagnostics<T>();
	}

	public sealed class ProtoPoolBudget // TypeDefIndex: 80482
	{
		// Fields
		private readonly object m_syncRoot; // 0x10
		private static readonly ProtoPoolBudget s_shared; // 0x00
		private static readonly ProtoPoolBudget s_factory; // 0x08
		[ThreadStatic]
		private static bool s_useFactory; // 0x80000000
		private static readonly ConcurrentDictionary<System.Type, bool> s_factoryTypes; // 0x10
		private static readonly Func<System.Type, bool> s_factoryTypePredicate; // 0x18
		private const int ENTRY_BYTES = 48; // Metadata: 0x0263CB94
		private const int POOL_BYTES = 160; // Metadata: 0x0263CB95
		private const int GROUP_BYTES = 64; // Metadata: 0x0263CB97
		private readonly int m_maxSlots; // 0x18
		private long m_maxBytes; // 0x20
		private int m_minimumCount; // 0x28
		private Entry[] m_entries; // 0x30
		private int m_free; // 0x38
		private int m_oldest; // 0x3C
		private int m_newest; // 0x40
		private Pool m_pools; // 0x48
		private int m_poolCount; // 0x50
		private long m_payloadBytes; // 0x58
		private long m_metadataBytes; // 0x60
		private long m_evictions; // 0x68
		private long m_rejections; // 0x70
		private long m_hits; // 0x78
		private long m_misses; // 0x80
		private long m_pressureCount; // 0x88
		private long m_oversizedCount; // 0x90
		private long m_quotaRejections; // 0x98
		private long m_budgetRejections; // 0xA0
		private int m_idleCount; // 0xA8
		private int m_evictableCount; // 0xAC
	
		// Properties
		internal static ProtoPoolBudget Current { get; } // 0x0000000184DF0880-0x0000000184DF0C10 
		internal static object SyncRoot { get; } // 0x0000000184DF0F30-0x0000000184DF1240 
		internal static bool IsFactory { get; } // 0x0000000184DF0C10-0x0000000184DF0F30 
	
		// Nested types
		[IsReadOnly]
		public struct Scope : IDisposable // TypeDefIndex: 80476
		{
			// Fields
			private readonly bool m_previous; // 0x00
	
			// Constructors
			internal Scope(bool factory); // 0x0000000184DF36D0-0x0000000184DF3A50
	
			// Methods
			public void Dispose(); // 0x0000000184DF3390-0x0000000184DF36D0
		}
	
		internal sealed class Pool // TypeDefIndex: 80477
		{
			// Fields
			internal int capacity; // 0x10
			internal int count; // 0x14
			internal int oldest; // 0x18
			internal int newest; // 0x1C
			internal Group group; // 0x20
			internal System.Type type; // 0x28
			internal int capacityHint; // 0x30
			internal Pool next; // 0x38
			internal long hits; // 0x40
			internal long misses; // 0x48
			internal long returns; // 0x50
			internal long rejected; // 0x58
			internal long evicted; // 0x60
			internal int peakIdle; // 0x68
	
			// Constructors
			public Pool(); // 0x0000000184DE8230-0x0000000184DE8240
		}
	
		internal sealed class Group // TypeDefIndex: 80478
		{
			// Fields
			internal int capacity; // 0x10
			internal int count; // 0x14
	
			// Constructors
			public Group(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private struct Entry // TypeDefIndex: 80479
		{
			// Fields
			internal object value; // 0x00
			internal Pool pool; // 0x08
			internal long bytes; // 0x10
			internal int older; // 0x18
			internal int newer; // 0x1C
			internal int poolOlder; // 0x20
			internal int poolNewer; // 0x24
		}
	
		[IsReadOnly]
		public struct Snapshot // TypeDefIndex: 80480
		{
			// Fields
			public readonly long maxBytes; // 0x00
			public readonly long estimatedPayloadBytes; // 0x08
			public readonly long managementBytes; // 0x10
			public readonly int idleCount; // 0x18
			public readonly int minimumRetainedPerPool; // 0x1C
			public readonly long evictedCount; // 0x20
			public readonly long rejectedReturnCount; // 0x28
			public readonly long hitCount; // 0x30
			public readonly long missCount; // 0x38
			public readonly long pressureCount; // 0x40
			public readonly long oversizedReturnCount; // 0x48
			public readonly long quotaRejectedCount; // 0x50
			public readonly long budgetRejectedCount; // 0x58
			public readonly int slotCapacity; // 0x60
	
			// Properties
			public long estimatedRetainedBytes { get; } // 0x0000000184DF3B00-0x0000000184DF4050 
	
			// Constructors
			internal Snapshot(ProtoPoolBudget budget); // 0x0000000184DF3A50-0x0000000184DF3B00
		}
	
		[IsReadOnly]
		public struct PoolSnapshot // TypeDefIndex: 80481
		{
			// Fields
			public readonly System.Type type; // 0x00
			public readonly int capacityHint; // 0x08
			public readonly int idleCount; // 0x0C
			public readonly int countLimit; // 0x10
			public readonly long hits; // 0x18
			public readonly long misses; // 0x20
			public readonly long returns; // 0x28
			public readonly long rejected; // 0x30
			public readonly long evicted; // 0x38
			public readonly int peakIdleCount; // 0x40
	
			// Constructors
			internal PoolSnapshot(Pool pool); // 0x0000000184DE8170-0x0000000184DE8230
		}
	
		// Constructors
		private ProtoPoolBudget(long maxBytes, int maxSlots); // 0x0000000184DF0510-0x0000000184DF0880
		static ProtoPoolBudget(); // 0x0000000184DEF5E0-0x0000000184DF0510
	
		// Methods
		public static Scope EnterFactoryScope(); // 0x0000000184DEAA00-0x0000000184DEAA30
		internal static Scope EnterDomain(bool factory); // 0x0000000184DEA9D0-0x0000000184DEAA00
		internal static Scope EnterMessage<T>();
		internal static void RegisterMessage<T>(T message)
			where T : class, IProtoPooledMessage;
		internal static bool IsFactoryMessage<T>(T message)
			where T : class, IProtoPooledMessage;
		public static Scope EnterMessageScope(IProtoPooledMessage message); // 0x0000000184DEAA30-0x0000000184DEB030
		internal static bool IsFactoryMessageType(System.Type type); // 0x0000000184DED390-0x0000000184DED970
		private static bool ClassifyFactoryMessage(System.Type type); // 0x0000000184DE9200-0x0000000184DEA320
		public static Snapshot GetSnapshot(); // 0x0000000184DED020-0x0000000184DED390
		public static PoolSnapshot[] GetPoolSnapshots(); // 0x0000000184DECA80-0x0000000184DECDA0
		public static bool TryConfigure(long maxBytes, int minimumRetainedPerPool = 4 /* Metadata: 0x0263CB90 */); // 0x0000000184DEF100-0x0000000184DEF440
		public static void TrimToMinimum(); // 0x0000000184DEE7D0-0x0000000184DEEAF0
		public static Snapshot GetFactorySnapshot(); // 0x0000000184DEB440-0x0000000184DEB7B0
		public static PoolSnapshot[] GetFactoryPoolSnapshots(); // 0x0000000184DEB120-0x0000000184DEB440
		public static void TrimFactoryToMinimum(); // 0x0000000184DEE2F0-0x0000000184DEE610
		private Snapshot GetSnapshotCore(); // 0x0000000184DECDA0-0x0000000184DED020
		private PoolSnapshot[] GetPoolSnapshotsCore(); // 0x0000000184DEC480-0x0000000184DECA80
		private bool TryConfigureCore(long maxBytes, int minimumRetainedPerPool = 4 /* Metadata: 0x0263CB91 */); // 0x0000000184DEEAF0-0x0000000184DEF100
		private void TrimToMinimumCore(); // 0x0000000184DEE610-0x0000000184DEE7D0
		private bool EnsureArenaLocked(); // 0x0000000184DEA320-0x0000000184DEA9D0
		internal Pool GetPoolLocked(ref Pool pool, System.Type type = null, int capacityHint = 0 /* Metadata: 0x0263CB92 */); // 0x0000000184DEBC10-0x0000000184DEC480
		internal bool CanRegisterPoolWithoutEvictionLocked(bool needsGroup); // 0x0000000184DE90F0-0x0000000184DE9140
		internal Group GetGroupLocked(ref Group group, int capacity); // 0x0000000184DEB7B0-0x0000000184DEBC10
		internal bool TakeLocked(Pool pool, out object value); // 0x0000000184DEE1C0-0x0000000184DEE2F0
		internal bool CanStorePayloadLocked(long bytes); // 0x0000000184DE91F0-0x0000000184DE9200
		internal bool RejectOversizedLocked(long bytes); // 0x0000000184DEDBA0-0x0000000184DEDBC0
		internal void ObserveReturnLocked(Pool pool); // 0x0000000184DEDAC0-0x0000000184DEDAD0
		internal bool PrepareReturnRegistrationLocked(long bytes, bool needsGroup = false /* Metadata: 0x0263CB93 */); // 0x0000000184DEDAD0-0x0000000184DEDB80
		internal bool ReturnLocked(Pool pool, object value, long bytes); // 0x0000000184DEDBF0-0x0000000184DEE1C0
		private bool RejectQuotaLocked(Pool pool); // 0x0000000184DEDBC0-0x0000000184DEDBF0
		private bool RejectBudgetLocked(Pool pool); // 0x0000000184DEDB80-0x0000000184DEDBA0
		private bool CanMakeRoomLocked(long bytes, bool needSlot); // 0x0000000184DE90B0-0x0000000184DE90F0
		private bool CanRetainProtectedLocked(long availablePayload, int minimum); // 0x0000000184DE9140-0x0000000184DE91F0
		private bool MakeRoomLocked(long bytes, bool needSlot); // 0x0000000184DED970-0x0000000184DEDAC0
		private int FindEvictableLocked(Group group, int minimum); // 0x0000000184DEB080-0x0000000184DEB120
		private void EvictLocked(int index); // 0x0000000184DEB030-0x0000000184DEB080
		private void UnlinkLocked(int index); // 0x0000000184DEF440-0x0000000184DEF5E0
	}

	internal interface IProtoPoolStorage // TypeDefIndex: 80483
	{
		// Properties
		long RetainedStorageBytes { get; }
	}

	internal interface IProtoPoolCapacity // TypeDefIndex: 80484
	{
		// Properties
		bool IsLargePoolObject { get; }
	}

	internal static class ProtoCollectionPoolPolicy // TypeDefIndex: 80485
	{
		// Fields
		internal const int SMALL_MAX_CAPACITY = 4096; // Metadata: 0x0263CB99
		internal const int SMALL_TO_LARGE_RATIO = 5; // Metadata: 0x0263CB9B
	
		// Methods
		internal static int LargeCount(int smallCount); // 0x0000000184DE8260-0x0000000184DE8580
	}

	internal static class ProtoMapPoolPolicy // TypeDefIndex: 80486
	{
		// Fields
		internal static readonly int SMALL_MAX_CAPACITY; // 0x00
	
		// Constructors
		static ProtoMapPoolPolicy(); // 0x0000000184DE8580-0x0000000184DE90B0
	}

	internal static class ProtoPoolSize // TypeDefIndex: 80487
	{
		// Methods
		internal static long Align(long bytes); // 0x0000000184DF1240-0x0000000184DF1250
		internal static long FieldBytes(System.Type type); // 0x0000000184DF1250-0x0000000184DF3390
	}

	internal static class ProtoPoolSize<T> // TypeDefIndex: 80488
		where T : class
	{
		// Fields
		private static readonly long s_arrayElementBytes;
		private static readonly long s_objectBytes;
		private static readonly System.Reflection.FieldInfo[] s_bytesFields;
	
		// Constructors
		static ProtoPoolSize();
	
		// Methods
		private static long GetObjectBytes();
		private static System.Reflection.FieldInfo[] GetBytesFields();
		internal static long Estimate(T value);
	}

	internal static class ProtoPoolRoute<T> // TypeDefIndex: 80489
	{
		// Fields
		internal static readonly bool IsFactory;
	
		// Constructors
		static ProtoPoolRoute();
	}

	internal sealed class ProtoObjectPool<T> // TypeDefIndex: 80490
		where T : class
	{
		// Fields
		private static readonly ProtoObjectPool<T> s_shared;
		private static readonly ProtoObjectPool<T> s_factory;
		private ProtoPoolBudget.Pool m_pool;
		private ProtoPoolBudget.Pool m_largePool;
		private int m_capacity;
	
		// Properties
		internal static ProtoObjectPool<T> Current { get; }
	
		// Constructors
		private ProtoObjectPool(bool factory);
		static ProtoObjectPool();
	
		// Methods
		public void EnsureCapacity(int capacity);
		public bool TryTake(out ref T value);
		internal bool TryTake(out ref T value, bool large, bool registerIfMissing = true /* Metadata: 0x0263CB9C */);
		public bool TryReturn(T value);
	}

	public static class ProtoBufFactory // TypeDefIndex: 80493
	{
		// Fields
		private static readonly ConcurrentDictionary<System.Type, Func<object>> s_runtimeAllocators; // 0x00
		private static readonly Func<System.Type, Func<object>> s_runtimeAllocatorFactory; // 0x08
	
		// Nested types
		private static class ProtoMessagePool<T> // TypeDefIndex: 80491
			where T : class, IProtoPooledMessage, new()
		{
			// Methods
			public static T Allocate();
			public static void Recycle(T msg);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80492
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<object> __9__19_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB66A34-0x000000018CB66B74
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _CreateRuntimeAllocator_b__19_0(); // 0x0000000185829EC0-0x0000000185829ED0
		}
	
		// Constructors
		static ProtoBufFactory(); // 0x0000000187173610-0x0000000187174470
	
		// Methods
		public static object Allocate(System.Type type); // 0x00000001856C78E0-0x00000001856C8470
		public static T Allocate<T>()
			where T : class, IProtoPooledMessage, new();
		public static void Prewarm<T>(int count)
			where T : class, IProtoPooledMessage, new();
		public static T Allocate<T>(Action<T> initializer)
			where T : class, IProtoPooledMessage, new();
		public static void Recycle<T>(T msg)
			where T : class, IProtoPooledMessage, new();
		public static T Copy<T>(T src)
			where T : class, IProtoPooledMessage, new();
		public static IProtoPooledMessage Copy(IProtoPooledMessage src); // 0x0000000185840BF0-0x0000000185840C40
		public static void SetOneOfObject(ref DiscriminatedUnionObject value, DiscriminatedUnionObject next, object owner = null, string fieldName = null); // 0x0000000185940330-0x00000001859403F0
		public static void SetOneOfObject(ref DiscriminatedUnion32Object value, DiscriminatedUnion32Object next, object owner = null, string fieldName = null); // 0x000000018584F160-0x000000018584F260
		public static void SetOneOfObject(ref DiscriminatedUnion64Object value, DiscriminatedUnion64Object next, object owner = null, string fieldName = null); // 0x00000001863040E0-0x0000000186304180
		public static void SetOneOfObject(ref DiscriminatedUnion128Object value, DiscriminatedUnion128Object next, object owner = null, string fieldName = null); // 0x000000018CB5DA3C-0x000000018CB5DAB4
		public static void ResetOneOfObject(ref DiscriminatedUnionObject value, int discriminator, object owner = null, string fieldName = null); // 0x0000000185940290-0x0000000185940310
		public static void ResetOneOfObject(ref DiscriminatedUnion32Object value, int discriminator, object owner = null, string fieldName = null); // 0x0000000184FF2030-0x0000000184FF20B0
		public static void ResetOneOfObject(ref DiscriminatedUnion64Object value, int discriminator, object owner = null, string fieldName = null); // 0x0000000186305110-0x00000001863051A0
		public static void ResetOneOfObject(ref DiscriminatedUnion128Object value, int discriminator, object owner = null, string fieldName = null); // 0x000000018CB5D9CC-0x000000018CB5DA3C
		private static object RuntimeAllocate<T>()
			where T : class, IProtoPooledMessage, new();
		private static void DisposeOneOfObject(object current, object next); // 0x00000001859403F0-0x0000000185940480
		private static Func<object> CreateRuntimeAllocator(System.Type type); // 0x00000001854F4860-0x00000001854F4A60
	}

	public static class ProtoByteArrayAllocator // TypeDefIndex: 80494
	{
		// Fields
		public static readonly byte[] Empty; // 0x00
	
		// Constructors
		static ProtoByteArrayAllocator(); // 0x0000000186496810-0x0000000186496870
	
		// Methods
		public static byte[] Allocate(int length); // 0x000000018CB5DFCC-0x000000018CB5E038
		public static byte[] CopyFrom(byte[] source); // 0x000000018CB5E0F0-0x000000018CB5E18C
		public static byte[] CopyFrom(ReadOnlySpan<byte> source); // 0x000000018CB5E038-0x000000018CB5E0F0
		public static byte[] Add(byte[] current, byte value); // 0x000000018CB5DF18-0x000000018CB5DFCC
		public static byte[] AddRange(byte[] current, byte[] values); // 0x000000018CB5DD2C-0x000000018CB5DDE4
		public static byte[] AddRange(byte[] current, ReadOnlySpan<byte> values); // 0x000000018CB5DDE4-0x000000018CB5DF18
	}

	public static class ProtoBytesFactory // TypeDefIndex: 80495
	{
		// Methods
		public static ProtoBytes Allocate(); // 0x00000001858447A0-0x0000000185845330
		public static ProtoBytes Copy(ProtoBytes source); // 0x0000000185844750-0x00000001858447A0
		public static ProtoBytes Copy(ReadOnlySpan<byte> source); // 0x000000018CB5E280-0x000000018CB5E2C8
		public static void Recycle(ProtoBytes bytes); // 0x0000000185845330-0x0000000185845F20
	}

	public sealed class ProtoBytes : IDisposable, IProtoPoolStorage // TypeDefIndex: 80496
	{
		// Fields
		private const int DEFAULT_CAPACITY = 256; // Metadata: 0x0263CB9D
		internal readonly bool IsFactoryPool; // 0x10
		private byte[] m_buffer; // 0x18
		private int m_length; // 0x20
	
		// Properties
		public int Length { get; } // 0x000000018226A850-0x000000018226A860 
		long IProtoPoolStorage.RetainedStorageBytes { get; } // 0x0000000184DE8240-0x0000000184DE8260 
		public ReadOnlySpan<byte> Span { get; } // 0x0000000185844290-0x0000000185844320 
		public ReadOnlyMemory<byte> Memory { get; } // 0x000000018CB5E818-0x000000018CB5E884 
		public Memory<byte> WritableMemory { get; } // 0x00000001862AF890-0x00000001862AF920 
	
		// Constructors
		public ProtoBytes(); // 0x000000018CB5E518-0x000000018CB5E818
	
		// Methods
		public void CopyFrom(ProtoBytes source); // 0x0000000185844580-0x00000001858445E0
		public void CopyFrom(byte[] source); // 0x000000018CB5E31C-0x000000018CB5E39C
		public void CopyFrom(ReadOnlySpan<byte> source); // 0x0000000185844320-0x0000000185844360
		public void Append(byte value); // 0x000000018CB5E2C8-0x000000018CB5E31C
		public void Append(ReadOnlySpan<byte> values); // 0x0000000185843090-0x0000000185843140
		public Memory<byte> AppendUninitialized(int additionalCapacity); // 0x0000000185843140-0x00000001858431F0
		public byte[] ToArray(); // 0x00000001867D5200-0x00000001867D52B0
		public void Clear(); // 0x0000000185844360-0x00000001858443A0
		public void ClearForPool(); // 0x0000000187837C4C-0x0000000187837C54
		public void Dispose(); // 0x000000018CB5E39C-0x000000018CB5E518
		private void EnsureCapacity(int capacity); // 0x00000001858431F0-0x0000000185844290
	}

	public static class ProtoCollectionFactory // TypeDefIndex: 80499
	{
		// Nested types
		private static class RepeatedFieldPool<T> // TypeDefIndex: 80497
		{
			// Methods
			public static RepeatedField<T> Allocate();
			public static void Recycle(RepeatedField<T> field);
		}
	
		private static class MapFieldPool<TKey, TValue> // TypeDefIndex: 80498
		{
			// Methods
			public static MapField<TKey, TValue> Allocate(int minimumCapacity = 0 /* Metadata: 0x0263CB9F */);
			public static void Recycle(MapField<TKey, TValue> field);
		}
	
		// Methods
		public static void PrewarmRepeatedField<T>(int count, int capacity);
		public static void PrewarmMapField<TKey, TValue>(int count, int capacity);
		public static RepeatedField<T> CreateRepeatedField<T>();
		public static MapField<TKey, TValue> CreateMapField<TKey, TValue>();
		public static MapField<TKey, TValue> CreateMapField<TKey, TValue>(int minimumCapacity);
		internal static void RecycleRepeatedField<T>(RepeatedField<T> field);
		internal static void RecycleMapField<TKey, TValue>(MapField<TKey, TValue> field);
	}

	internal sealed class ProtoRepeatedArrayPool<T> // TypeDefIndex: 80500
	{
		// Fields
		private static readonly ProtoRepeatedArrayPool<T> s_shared;
		private static readonly ProtoRepeatedArrayPool<T> s_factory;
		private const int MIN_LENGTH = 16; // Metadata: 0x0263CBA1
		private const int MAX_LENGTH = 1048576; // Metadata: 0x0263CBA2
		private readonly ProtoPoolBudget.Pool[] m_buckets;
		private ProtoPoolBudget.Group m_smallGroup;
		private ProtoPoolBudget.Group m_largeGroup;
		private int m_smallCapacity;
		private readonly long m_elementBytes;
	
		// Properties
		internal static ProtoRepeatedArrayPool<T> Current { get; }
	
		// Constructors
		private ProtoRepeatedArrayPool(bool factory);
		static ProtoRepeatedArrayPool();
	
		// Methods
		private int GetBucketIndex(int length);
		private ProtoPoolBudget.Pool GetBucketLocked(int index, bool allowEviction = true /* Metadata: 0x0263CBA0 */);
		public void Prewarm(int count, int capacity);
		public T[] Rent(int minimumLength);
		public void Return(T[] array);
	}

	public class MapField<TKey, TValue> : Dictionary<TKey, TValue>, IDisposable, IProtoPoolStorage, IProtoPoolCapacity // TypeDefIndex: 80501
	{
		// Fields
		private static readonly bool s_trackValueOwnership;
		private bool m_isInPool;
		private bool m_factoryPool;
		private static readonly long s_budgetEntryBytes;
	
		// Properties
		internal bool IsFactoryPool { get; }
		bool IProtoPoolCapacity.IsLargePoolObject { get; }
		long IProtoPoolStorage.RetainedStorageBytes { get; }
		public new TValue this[TKey key] { get => default; set {} }
	
		// Constructors
		public MapField();
		public MapField(int capacity);
		public MapField(IDictionary<TKey, TValue> source);
		static MapField();
	
		// Methods
		public new void Add(TKey key, TValue value);
		public void AddRef(TKey key, TValue value);
		public void SetRef(TKey key, TValue value);
		public new bool Remove(TKey key);
		public new void Clear();
		internal void OnProtoAllocated();
		public void Dispose();
		private void DisposeOwnedValuesAndClear();
		private static void DisposeOnce(TValue value, TValue[] values, int index);
		public void Add(IDictionary<TKey, TValue> entries);
		private static string _GetOwnerFieldName(TKey key);
		private void _ClaimChild(TValue value, TKey key);
		private void _ReleaseChild(TValue value, TKey key);
	}

	public class RepeatedField<T> : IList<T>, IReadOnlyList<T>, IList, IDisposable // TypeDefIndex: 80503
	{
		// Fields
		private const int DEFAULT_CAPACITY = 4; // Metadata: 0x0263CBA6
		private const int MAX_ARRAY_LENGTH = 2146435071; // Metadata: 0x0263CBA7
		private static readonly T[] s_emptyArray;
		private static readonly bool s_trackItemOwnership;
		private T[] m_items;
		private int m_count;
		private int m_version;
		private bool m_isInPool;
		private bool m_factoryPool;
	
		// Properties
		internal bool IsFactoryPool { get; }
		public int Count { get; }
		public int Capacity { get; set; }
		public bool IsReadOnly { get; }
		bool IList.IsFixedSize { get; }
		bool IList.IsReadOnly { get; }
		bool ICollection.IsSynchronized { get; }
		object ICollection.SyncRoot { get; }
		public T this[int index] { get => default; set {} }
		object IList.this[int index] { get => default; set {} }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 80502
		{
			// Fields
			private readonly RepeatedField<T> m_list;
			private readonly int m_version;
			private int m_index;
			private T m_current;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			internal Enumerator(RepeatedField<T> list);
	
			// Methods
			public bool MoveNext();
			public void Reset();
			public void Dispose();
		}
	
		// Constructors
		public RepeatedField();
		public RepeatedField(int capacity);
		public RepeatedField(IEnumerable<T> collection);
		static RepeatedField();
	
		// Methods
		public void Add(T item);
		public void AddRef(T item);
		int IList.Add(object value);
		public void Add(IEnumerable<T> values);
		public void AddRange(IEnumerable<T> values);
		public void AddRangeRef(IEnumerable<T> values);
		public void Clear();
		internal void OnProtoAllocated();
		public void Dispose();
		private static void DisposeOwnedItems(T[] items, int count);
		private static void DisposeOnce(T value, T[] items, int index);
		public bool Contains(T item);
		bool IList.Contains(object value);
		public void CopyTo(T[] array, int arrayIndex);
		void ICollection.CopyTo(Array array, int index);
		public Enumerator GetEnumerator();
		public int IndexOf(T item);
		int IList.IndexOf(object value);
		public void Insert(int index, T item);
		public void InsertRef(int index, T item);
		public void SetRef(int index, T value);
		void IList.Insert(int index, object value);
		public bool Remove(T item);
		void IList.Remove(object value);
		public void RemoveAt(int index);
		public void RemoveRange(int index, int count);
		public T[] ToArray();
		public void SetCount(int newCount);
		private void EnsureCapacity(int min);
		private T[] RentArray(int minimumLength);
		private void ReturnArray(T[] array);
		private static bool IsCompatibleObject(object value);
		private static string _GetOwnerFieldName(int index);
		private void _ClaimChild(T value, int index);
		private void _ReleaseChild(T value, int index);
		private void _MoveChild(T value, int oldIndex, int newIndex);
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public static class ProtoRepeatedFieldExtensions // TypeDefIndex: 80504
	{
		// Extension methods
		public static T AddAllocate<T>(this RepeatedField<T> values)
			where T : class, IProtoPooledMessage, new();
		public static void AddCopy<T>(this RepeatedField<T> values, T src)
			where T : class, IProtoPooledMessage, new();
		public static void AddRangeCopy<T>(this RepeatedField<T> values, IEnumerable<T> src)
			where T : class, IProtoPooledMessage, new();
		public static void SetCopy<T>(this RepeatedField<T> values, int index, T src)
			where T : class, IProtoPooledMessage, new();
	}

	public static class ProtoMapFieldExtensions // TypeDefIndex: 80505
	{
		// Extension methods
		public static TValue AddAllocate<TKey, TValue>(this MapField<TKey, TValue> values, TKey key)
			where TValue : class, IProtoPooledMessage, new();
		public static TValue SetAllocate<TKey, TValue>(this MapField<TKey, TValue> values, TKey key)
			where TValue : class, IProtoPooledMessage, new();
		public static void AddCopy<TKey, TValue>(this MapField<TKey, TValue> values, TKey key, TValue src)
			where TValue : class, IProtoPooledMessage, new();
		public static void AddCopy<TKey, TValue>(this MapField<TKey, TValue> values, IDictionary<TKey, TValue> src)
			where TValue : class, IProtoPooledMessage, new();
		public static void SetCopy<TKey, TValue>(this MapField<TKey, TValue> values, TKey key, TValue src)
			where TValue : class, IProtoPooledMessage, new();
	}

	public static class ProtoMapExtensions // TypeDefIndex: 80506
	{
		// Extension methods
		public static void Merge<TKey, TValue>(this IDictionary<TKey, TValue> self, IDictionary<TKey, TValue> other);
		public static void Add<TKey, TValue>(this IDictionary<TKey, TValue> self, IDictionary<TKey, TValue> entries);
	}

	public static class ProtoBytesExtensions // TypeDefIndex: 80507
	{
		// Extension methods
		public static string ToStringUtf8(this ProtoBytes bytes); // 0x00000001867D4EC0-0x00000001867D4F40
		public static string ToStringUtf8(this byte[] bytes); // 0x000000018CB5E210-0x000000018CB5E280
		public static string ToStringUtf8(this byte[] bytes, int offset, int count); // 0x000000018CB5E18C-0x000000018CB5E210
	}
}

namespace ProtoBuf
{
	internal enum TimeSpanScale // TypeDefIndex: 80510
	{
		Days = 0,
		Hours = 1,
		Minutes = 2,
		Seconds = 3,
		Milliseconds = 4,
		Ticks = 5,
		MinMax = 15
	}

	public static class BclHelpers // TypeDefIndex: 80511
	{
		// Fields
		internal static readonly System.DateTime[] EpochOrigin; // 0x00
		private const int MAX_DECIMAL_BYTES = 32; // Metadata: 0x0263CBC9
	
		// Constructors
		static BclHelpers(); // 0x000000018CB5B040-0x000000018CB5B1A8
	
		// Methods
		public static object GetUninitializedObject(System.Type type); // 0x000000018CB5974C-0x000000018CB59798
		public static void WriteTimeSpan(TimeSpan timeSpan, ProtoWriter dest); // 0x000000018CB5AE58-0x000000018CB5AEF8
		public static void WriteTimeSpan(ref ProtoWriter.State state, TimeSpan value); // 0x000000018CB5ADFC-0x000000018CB5AE58
		private static void WriteTimeSpanImpl(ref ProtoWriter.State state, TimeSpan timeSpan, DateTimeKind kind); // 0x000000018CB5ACB0-0x000000018CB5ADFC
		public static TimeSpan ReadTimeSpan(ProtoReader source); // 0x000000018CB5A10C-0x000000018CB5A198
		public static TimeSpan ReadTimeSpan(ref ProtoReader.State state); // 0x000000018CB59F94-0x000000018CB5A10C
		public static TimeSpan ReadDuration(ProtoReader source); // 0x000000018CB59D0C-0x000000018CB59D98
		public static TimeSpan ReadDuration(ref ProtoReader.State state); // 0x000000018CB59D98-0x000000018CB59E2C
		public static void WriteDuration(TimeSpan value, ProtoWriter dest); // 0x000000018CB5AA38-0x000000018CB5AAD8
		public static void WriteDuration(ref ProtoWriter.State state, TimeSpan value); // 0x000000018CB5AAD8-0x000000018CB5AB68
		public static System.DateTime ReadTimestamp(ProtoReader source); // 0x000000018CB5A198-0x000000018CB5A224
		public static System.DateTime ReadTimestamp(ref ProtoReader.State state); // 0x000000018CB5A224-0x000000018CB5A2D0
		public static void WriteTimestamp(System.DateTime value, ProtoWriter dest); // 0x000000018CB5AEF8-0x000000018CB5AF98
		public static void WriteTimestamp(ref ProtoWriter.State state, System.DateTime value); // 0x000000018CB5AF98-0x000000018CB5B040
		public static System.DateTime ReadDateTime(ProtoReader source); // 0x000000018CB5997C-0x000000018CB59A08
		public static System.DateTime ReadDateTime(ref ProtoReader.State state); // 0x000000018CB59798-0x000000018CB5997C
		public static void WriteDateTime(System.DateTime value, ProtoWriter dest); // 0x000000018CB5A5F0-0x000000018CB5A690
		public static void WriteDateTime(ref ProtoWriter.State state, System.DateTime value); // 0x000000018CB5A594-0x000000018CB5A5F0
		public static void WriteDateTimeWithKind(System.DateTime value, ProtoWriter dest); // 0x000000018CB5A498-0x000000018CB5A538
		public static void WriteDateTimeWithKind(ref ProtoWriter.State state, System.DateTime value); // 0x000000018CB5A538-0x000000018CB5A594
		private static void WriteDateTimeImpl(ref ProtoWriter.State state, System.DateTime value, bool includeKind); // 0x000000018CB5A2D0-0x000000018CB5A498
		public static decimal ReadDecimal(ProtoReader reader); // 0x000000018CB59BA4-0x000000018CB59C50
		public static decimal ReadDecimal(ref ProtoReader.State state); // 0x000000018CB59C50-0x000000018CB59D0C
		public static decimal ReadDecimalString(ref ProtoReader.State state); // 0x000000018CB59A08-0x000000018CB59BA4
		public static void WriteDecimal(decimal value, ProtoWriter writer); // 0x000000018CB5A918-0x000000018CB5A9C0
		public static void WriteDecimal(ref ProtoWriter.State state, decimal value); // 0x000000018CB5A9C0-0x000000018CB5AA38
		public static void WriteDecimalString(ref ProtoWriter.State state, decimal value); // 0x000000018CB5A690-0x000000018CB5A918
		public static void WriteGuid(Guid value, ProtoWriter dest); // 0x000000018CB5AC08-0x000000018CB5ACB0
		public static void WriteGuid(ref ProtoWriter.State state, Guid value); // 0x000000018CB5AB90-0x000000018CB5AC08
		public static void WriteGuidBytes(ref ProtoWriter.State state, Guid value); // 0x000000018CB5AB68-0x000000018CB5AB7C
		public static void WriteGuidString(ref ProtoWriter.State state, Guid value); // 0x000000018CB5AB7C-0x000000018CB5AB90
		public static Guid ReadGuid(ProtoReader source); // 0x000000018CB59EE8-0x000000018CB59F94
		public static Guid ReadGuid(ref ProtoReader.State state); // 0x000000018CB59E54-0x000000018CB59EE8
		public static Guid ReadGuidBytes(ref ProtoReader.State state); // 0x000000018CB59E2C-0x000000018CB59E54
		public static Guid ReadGuidString(ref ProtoReader.State state); // 0x000000018CB59E2C-0x000000018CB59E54
	}

	public sealed class BufferExtension : IExtensionResettable // TypeDefIndex: 80512
	{
		// Fields
		private ArraySegment<byte> _buffer; // 0x10
		[CompilerGenerated]
		private System.Type _Type_k__BackingField; // 0x20
		[CompilerGenerated]
		private BufferExtension _Tail_k__BackingField; // 0x28
	
		// Properties
		internal System.Type Type { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		internal BufferExtension Tail { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
	
		// Constructors
		public BufferExtension(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal void SetTail(System.Type type, BufferExtension tail); // 0x000000018CB5B7A4-0x000000018CB5B7CC
		void IExtensionResettable.Reset(); // 0x00000001872514D0-0x00000001872514E0
		int IExtension.GetLength(); // 0x000000018CB5B754-0x000000018CB5B7A4
		Stream IExtension.BeginAppend(); // 0x000000018CB5B1A8-0x000000018CB5B1FC
		void IExtension.EndAppend(Stream stream, bool commit); // 0x000000018CB5B308-0x000000018CB5B6C4
		Stream IExtension.BeginQuery(); // 0x000000018CB5B1FC-0x000000018CB5B308
		void IExtension.EndQuery(Stream stream); // 0x000000018CB5B6C4-0x000000018CB5B754
	}

	internal static class BufferPool // TypeDefIndex: 80513
	{
		// Fields
		private static readonly ArrayPool<byte> _pool; // 0x00
		internal const int BUFFER_LENGTH = 1024; // Metadata: 0x0263CBCA
		private const int MaxByteArraySize = 2147483591; // Metadata: 0x0263CBCC
	
		// Constructors
		static BufferPool(); // 0x000000018718DF80-0x000000018718E010
	
		// Methods
		internal static byte[] GetBuffer(); // 0x0000000185C17850-0x0000000185C178A0
		internal static byte[] GetBuffer(int minSize); // 0x0000000185C178A0-0x0000000185C17910
		internal static byte[] GetCachedBuffer(int minSize); // 0x0000000185C17910-0x0000000185C179A0
		internal static void ResizeAndFlushLeft(ref byte[] buffer, int toFitAtLeastBytes, int copyFromIndex, int copyBytes); // 0x0000000185C17050-0x0000000185C17150
		internal static void ReleaseBufferToPool(ref byte[] buffer); // 0x0000000185C184C0-0x0000000185C18570
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[ImmutableObject(true)]
	public sealed class ProtoBeforeSerializationAttribute : Attribute // TypeDefIndex: 80514
	{
		// Constructors
		public ProtoBeforeSerializationAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[ImmutableObject(true)]
	public sealed class ProtoAfterSerializationAttribute : Attribute // TypeDefIndex: 80515
	{
		// Constructors
		public ProtoAfterSerializationAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[ImmutableObject(true)]
	public sealed class ProtoBeforeDeserializationAttribute : Attribute // TypeDefIndex: 80516
	{
		// Constructors
		public ProtoBeforeDeserializationAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[ImmutableObject(true)]
	public sealed class ProtoAfterDeserializationAttribute : Attribute // TypeDefIndex: 80517
	{
		// Constructors
		public ProtoAfterDeserializationAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public enum CompatibilityLevel // TypeDefIndex: 80518
	{
		NotSpecified = 0,
		Level200 = 200,
		Level240 = 240,
		Level300 = 300
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	[ImmutableObject(true)]
	public sealed class CompatibilityLevelAttribute : Attribute // TypeDefIndex: 80519
	{
		// Fields
		[CompilerGenerated]
		private readonly CompatibilityLevel _Level_k__BackingField; // 0x10
	
		// Properties
		public CompatibilityLevel Level { [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
	
		// Constructors
		public CompatibilityLevelAttribute(CompatibilityLevel level); // 0x0000000182234E90-0x0000000182234EA0
	
		// Methods
		internal static void AssertValid(CompatibilityLevel compatibilityLevel); // 0x0000000185859570-0x0000000185859590
		[CompilerGenerated]
		internal static void _AssertValid_g__Throw_4_0(CompatibilityLevel compatibilityLevel); // 0x000000018CB5B7CC-0x000000018CB5B86C
	}

	public enum DataFormat // TypeDefIndex: 80520
	{
		Default = 0,
		ZigZag = 1,
		TwosComplement = 2,
		FixedSize = 3,
		Group = 4,
		WellKnown = 5
	}

	[Serializable]
	[IsReadOnly]
	public struct DiscriminatedUnionObject : ISerializable // TypeDefIndex: 80521
	{
		// Fields
		public readonly object Object; // 0x00
		[CompilerGenerated]
		private readonly int _Discriminator_k__BackingField; // 0x08
	
		// Properties
		public int Discriminator { [CompilerGenerated] get; } // 0x0000000184431A70-0x0000000184431A80 
	
		// Constructors
		public DiscriminatedUnionObject(int discriminator, object value); // 0x0000000187836E28-0x0000000187836E34
		private DiscriminatedUnionObject(SerializationInfo info, StreamingContext context); // 0x000000018CB5CAA0-0x000000018CB5CBCC
	
		// Methods
		public bool Is(int discriminator); // 0x0000000185940320-0x0000000185940330
		public static void Reset(ref DiscriminatedUnionObject value, int discriminator); // 0x0000000185940310-0x0000000185940320
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context); // 0x000000018CB5CA14-0x000000018CB5CAA0
	}

	[Serializable]
	[IsReadOnly]
	public struct DiscriminatedUnion64 : ISerializable // TypeDefIndex: 80522
	{
		// Fields
		private readonly int _discriminator; // 0x00
		public readonly long Int64; // 0x08
		public readonly ulong UInt64; // 0x08
		public readonly int Int32; // 0x08
		public readonly uint UInt32; // 0x08
		public readonly bool Boolean; // 0x08
		public readonly float Single; // 0x08
		public readonly double Double; // 0x08
		public readonly System.DateTime DateTime; // 0x08
		public readonly TimeSpan TimeSpan; // 0x08
	
		// Properties
		public int Discriminator { get; } // 0x00000001844AD290-0x00000001844AD2A0 
	
		// Constructors
		private DiscriminatedUnion64(int discriminator); // 0x0000000187254930-0x0000000187254940
		public DiscriminatedUnion64(int discriminator, long value); // 0x00000001872549A0-0x00000001872549B0
		public DiscriminatedUnion64(int discriminator, int value); // 0x0000000187254970-0x0000000187254980
		public DiscriminatedUnion64(int discriminator, ulong value); // 0x00000001872549A0-0x00000001872549B0
		public DiscriminatedUnion64(int discriminator, uint value); // 0x0000000187254970-0x0000000187254980
		public DiscriminatedUnion64(int discriminator, float value); // 0x00000001872549B0-0x00000001872549C0
		public DiscriminatedUnion64(int discriminator, double value); // 0x0000000187254990-0x00000001872549A0
		public DiscriminatedUnion64(int discriminator, bool value); // 0x0000000187254980-0x0000000187254990
		public DiscriminatedUnion64(int discriminator, System.DateTime? value); // 0x000000018CB5C800-0x000000018CB5C868
		public DiscriminatedUnion64(int discriminator, TimeSpan? value); // 0x000000018CB5C868-0x000000018CB5C8D0
		private DiscriminatedUnion64(SerializationInfo info, StreamingContext context); // 0x000000018CB5C8D0-0x000000018CB5CA14
	
		// Methods
		public bool Is(int discriminator); // 0x000000018722B740-0x000000018722B750
		public static void Reset(ref DiscriminatedUnion64 value, int discriminator); // 0x0000000184FF20B0-0x0000000184FF20C0
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context); // 0x000000018CB5C774-0x000000018CB5C800
	}

	[Serializable]
	[IsReadOnly]
	public struct DiscriminatedUnion128Object : ISerializable // TypeDefIndex: 80523
	{
		// Fields
		private readonly int _discriminator; // 0x00
		public readonly long Int64; // 0x08
		public readonly ulong UInt64; // 0x08
		public readonly int Int32; // 0x08
		public readonly uint UInt32; // 0x08
		public readonly bool Boolean; // 0x08
		public readonly float Single; // 0x08
		public readonly double Double; // 0x08
		public readonly System.DateTime DateTime; // 0x08
		public readonly TimeSpan TimeSpan; // 0x08
		public readonly Guid Guid; // 0x08
		public readonly object Object; // 0x18
		private readonly long _lo; // 0x08
		private readonly long _hi; // 0x10
	
		// Properties
		public int Discriminator { get; } // 0x00000001844AD290-0x00000001844AD2A0 
	
		// Constructors
		private DiscriminatedUnion128Object(int discriminator); // 0x00000001872547E0-0x00000001872547F0
		public DiscriminatedUnion128Object(int discriminator, long value); // 0x0000000187254810-0x0000000187254830
		public DiscriminatedUnion128Object(int discriminator, int value); // 0x00000001872547F0-0x0000000187254810
		public DiscriminatedUnion128Object(int discriminator, ulong value); // 0x0000000187254810-0x0000000187254830
		public DiscriminatedUnion128Object(int discriminator, uint value); // 0x00000001872547F0-0x0000000187254810
		public DiscriminatedUnion128Object(int discriminator, float value); // 0x0000000187254850-0x0000000187254870
		public DiscriminatedUnion128Object(int discriminator, double value); // 0x0000000187254830-0x0000000187254850
		public DiscriminatedUnion128Object(int discriminator, bool value); // 0x00000001872547C0-0x00000001872547E0
		public DiscriminatedUnion128Object(int discriminator, object value); // 0x000000018CB5B9DC-0x000000018CB5BA00
		public DiscriminatedUnion128Object(int discriminator, System.DateTime? value); // 0x000000018CB5BC44-0x000000018CB5BCBC
		public DiscriminatedUnion128Object(int discriminator, TimeSpan? value); // 0x000000018CB5B964-0x000000018CB5B9DC
		public DiscriminatedUnion128Object(int discriminator, Guid? value); // 0x000000018CB5BA00-0x000000018CB5BA74
		private DiscriminatedUnion128Object(SerializationInfo info, StreamingContext context); // 0x000000018CB5BA74-0x000000018CB5BC44
	
		// Methods
		public bool Is(int discriminator); // 0x0000000184FF20D0-0x0000000184FF20E0
		public static void Reset(ref DiscriminatedUnion128Object value, int discriminator); // 0x000000018CB5B86C-0x000000018CB5B87C
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context); // 0x000000018CB5B87C-0x000000018CB5B964
	}

	[Serializable]
	[IsReadOnly]
	public struct DiscriminatedUnion128 : ISerializable // TypeDefIndex: 80524
	{
		// Fields
		private readonly int _discriminator; // 0x00
		public readonly long Int64; // 0x08
		public readonly ulong UInt64; // 0x08
		public readonly int Int32; // 0x08
		public readonly uint UInt32; // 0x08
		public readonly bool Boolean; // 0x08
		public readonly float Single; // 0x08
		public readonly double Double; // 0x08
		public readonly System.DateTime DateTime; // 0x08
		public readonly TimeSpan TimeSpan; // 0x08
		public readonly Guid Guid; // 0x08
		private readonly long _lo; // 0x08
		private readonly long _hi; // 0x10
	
		// Properties
		public int Discriminator { get; } // 0x00000001844AD290-0x00000001844AD2A0 
	
		// Constructors
		private DiscriminatedUnion128(int discriminator); // 0x00000001872548C0-0x00000001872548D0
		public DiscriminatedUnion128(int discriminator, long value); // 0x0000000187254870-0x0000000187254880
		public DiscriminatedUnion128(int discriminator, int value); // 0x00000001872548A0-0x00000001872548C0
		public DiscriminatedUnion128(int discriminator, ulong value); // 0x0000000187254870-0x0000000187254880
		public DiscriminatedUnion128(int discriminator, uint value); // 0x00000001872548A0-0x00000001872548C0
		public DiscriminatedUnion128(int discriminator, float value); // 0x0000000187254880-0x00000001872548A0
		public DiscriminatedUnion128(int discriminator, double value); // 0x00000001872548D0-0x00000001872548F0
		public DiscriminatedUnion128(int discriminator, bool value); // 0x00000001872548F0-0x0000000187254910
		public DiscriminatedUnion128(int discriminator, System.DateTime? value); // 0x000000018CB5BD88-0x000000018CB5BDF8
		public DiscriminatedUnion128(int discriminator, TimeSpan? value); // 0x000000018CB5BDF8-0x000000018CB5BE68
		public DiscriminatedUnion128(int discriminator, Guid? value); // 0x000000018CB5BE68-0x000000018CB5BED4
		private DiscriminatedUnion128(SerializationInfo info, StreamingContext context); // 0x000000018CB5BED4-0x000000018CB5C068
	
		// Methods
		public bool Is(int discriminator); // 0x0000000184FF20D0-0x0000000184FF20E0
		public static void Reset(ref DiscriminatedUnion128 value, int discriminator); // 0x000000018CB5BCBC-0x000000018CB5BCD0
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context); // 0x000000018CB5BCD0-0x000000018CB5BD88
	}

	[Serializable]
	[IsReadOnly]
	public struct DiscriminatedUnion64Object : ISerializable // TypeDefIndex: 80525
	{
		// Fields
		private readonly int _discriminator; // 0x00
		public readonly long Int64; // 0x08
		public readonly ulong UInt64; // 0x08
		public readonly int Int32; // 0x08
		public readonly uint UInt32; // 0x08
		public readonly bool Boolean; // 0x08
		public readonly float Single; // 0x08
		public readonly double Double; // 0x08
		public readonly System.DateTime DateTime; // 0x08
		public readonly TimeSpan TimeSpan; // 0x08
		public readonly object Object; // 0x10
	
		// Properties
		public int Discriminator { get; } // 0x00000001844AD290-0x00000001844AD2A0 
	
		// Constructors
		private DiscriminatedUnion64Object(int discriminator); // 0x00000001872548C0-0x00000001872548D0
		public DiscriminatedUnion64Object(int discriminator, long value); // 0x0000000187254870-0x0000000187254880
		public DiscriminatedUnion64Object(int discriminator, int value); // 0x00000001872548A0-0x00000001872548C0
		public DiscriminatedUnion64Object(int discriminator, ulong value); // 0x0000000187254870-0x0000000187254880
		public DiscriminatedUnion64Object(int discriminator, uint value); // 0x00000001872548A0-0x00000001872548C0
		public DiscriminatedUnion64Object(int discriminator, float value); // 0x0000000187254880-0x00000001872548A0
		public DiscriminatedUnion64Object(int discriminator, double value); // 0x00000001872548D0-0x00000001872548F0
		public DiscriminatedUnion64Object(int discriminator, bool value); // 0x00000001872548F0-0x0000000187254910
		public DiscriminatedUnion64Object(int discriminator, object value); // 0x0000000186302690-0x00000001863026C0
		public DiscriminatedUnion64Object(int discriminator, System.DateTime? value); // 0x000000018CB5C50C-0x000000018CB5C57C
		public DiscriminatedUnion64Object(int discriminator, TimeSpan? value); // 0x000000018CB5C57C-0x000000018CB5C5EC
		private DiscriminatedUnion64Object(SerializationInfo info, StreamingContext context); // 0x000000018CB5C5EC-0x000000018CB5C774
	
		// Methods
		public bool Is(int discriminator); // 0x0000000184FF20D0-0x0000000184FF20E0
		public static void Reset(ref DiscriminatedUnion64Object value, int discriminator); // 0x00000001863051A0-0x00000001863051C0
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context); // 0x000000018CB5C454-0x000000018CB5C50C
	}

	[Serializable]
	[IsReadOnly]
	public struct DiscriminatedUnion32 : ISerializable // TypeDefIndex: 80526
	{
		// Fields
		private readonly int _discriminator; // 0x00
		public readonly int Int32; // 0x04
		public readonly uint UInt32; // 0x04
		public readonly bool Boolean; // 0x04
		public readonly float Single; // 0x04
	
		// Properties
		public int Discriminator { get; } // 0x00000001844AD290-0x00000001844AD2A0 
	
		// Constructors
		private DiscriminatedUnion32(int discriminator); // 0x0000000187254950-0x0000000187254960
		public DiscriminatedUnion32(int discriminator, int value); // 0x00000001827241A0-0x00000001827241B0
		public DiscriminatedUnion32(int discriminator, uint value); // 0x00000001827241A0-0x00000001827241B0
		public DiscriminatedUnion32(int discriminator, float value); // 0x000000018724A510-0x000000018724A520
		public DiscriminatedUnion32(int discriminator, bool value); // 0x0000000187254960-0x0000000187254970
		private DiscriminatedUnion32(SerializationInfo info, StreamingContext context); // 0x000000018CB5C320-0x000000018CB5C454
	
		// Methods
		public bool Is(int discriminator); // 0x0000000184FF20D0-0x0000000184FF20E0
		public static void Reset(ref DiscriminatedUnion32 value, int discriminator); // 0x000000018722E9B0-0x000000018722E9C0
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context); // 0x000000018CB5C294-0x000000018CB5C320
	}

	[Serializable]
	[IsReadOnly]
	public struct DiscriminatedUnion32Object : ISerializable // TypeDefIndex: 80527
	{
		// Fields
		private readonly int _discriminator; // 0x00
		public readonly int Int32; // 0x04
		public readonly uint UInt32; // 0x04
		public readonly bool Boolean; // 0x04
		public readonly float Single; // 0x04
		public readonly object Object; // 0x08
	
		// Properties
		public int Discriminator { get; } // 0x00000001844AD290-0x00000001844AD2A0 
	
		// Constructors
		private DiscriminatedUnion32Object(int discriminator); // 0x0000000187254930-0x0000000187254940
		public DiscriminatedUnion32Object(int discriminator, int value); // 0x0000000187254910-0x0000000187254920
		public DiscriminatedUnion32Object(int discriminator, uint value); // 0x0000000187254910-0x0000000187254920
		public DiscriminatedUnion32Object(int discriminator, float value); // 0x0000000187254940-0x0000000187254950
		public DiscriminatedUnion32Object(int discriminator, bool value); // 0x0000000187254920-0x0000000187254930
		public DiscriminatedUnion32Object(int discriminator, object value); // 0x0000000186B309C0-0x0000000186B309E0
		private DiscriminatedUnion32Object(SerializationInfo info, StreamingContext context); // 0x000000018CB5C120-0x000000018CB5C294
	
		// Methods
		public bool Is(int discriminator); // 0x0000000184FF20D0-0x0000000184FF20E0
		public static void Reset(ref DiscriminatedUnion32Object value, int discriminator); // 0x0000000184FF20B0-0x0000000184FF20C0
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context); // 0x000000018CB5C068-0x000000018CB5C120
	}

	public abstract class Extensible : ITypedExtensible, IExtensible // TypeDefIndex: 80528
	{
		// Fields
		private IExtension extensionObject; // 0x10
	
		// Constructors
		protected Extensible(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		IExtension IExtensible.GetExtensionObject(bool createIfMissing); // 0x000000018CB5D29C-0x000000018CB5D2A4
		IExtension ITypedExtensible.GetExtensionObject(System.Type type, bool createIfMissing); // 0x000000018CB5D2A4-0x000000018CB5D2FC
		[Obsolete("This API is considered, and may no longer be used in all scenarios (in particular when inheritance is involved); it is not recommended to rely on this API")]
		protected virtual IExtension GetExtensionObject(bool createIfMissing); // 0x000000018CB5D10C-0x000000018CB5D148
		public static IExtension GetExtensionObject(ref IExtension extensionObject, System.Type type, bool createIfMissing); // 0x000000018CB5D148-0x000000018CB5D270
		public static IExtension GetExtensionObject(ref IExtension extensionObject, bool createIfMissing); // 0x0000000185C65E50-0x0000000185C65EB0
		public static void AppendValue<TValue>(IExtensible instance, int tag, TValue value);
		public static void AppendValue<TValue>(IExtensible instance, int tag, ProtoBuf.DataFormat format, TValue value);
		public static void AppendValue<TValue>(TypeModel model, IExtensible instance, int tag, TValue value, ProtoBuf.DataFormat format = ProtoBuf.DataFormat.Default /* Metadata: 0x0263CBDE */);
		public static TValue GetValue<TValue>(IExtensible instance, int tag);
		public static TValue GetValue<TValue>(IExtensible instance, int tag, ProtoBuf.DataFormat format);
		public static TValue GetValue<TValue>(TypeModel model, IExtensible instance, int tag, ProtoBuf.DataFormat format = ProtoBuf.DataFormat.Default /* Metadata: 0x0263CBDF */);
		public static bool TryGetValue<TValue>(IExtensible instance, int tag, out ref TValue value);
		public static bool TryGetValue<TValue>(IExtensible instance, int tag, ProtoBuf.DataFormat format, out ref TValue value);
		public static bool TryGetValue<TValue>(IExtensible instance, int tag, ProtoBuf.DataFormat format, bool allowDefinedTag, out ref TValue value);
		public static bool TryGetValue<TValue>(TypeModel model, IExtensible instance, int tag, out ref TValue value, ProtoBuf.DataFormat format = ProtoBuf.DataFormat.Default /* Metadata: 0x0263CBE0 */, bool allowDefinedTag = false /* Metadata: 0x0263CBE1 */);
		public static IEnumerable<TValue> GetValues<TValue>(IExtensible instance, int tag);
		public static IEnumerable<TValue> GetValues<TValue>(IExtensible instance, int tag, ProtoBuf.DataFormat format);
		public static IEnumerable<TValue> GetValues<TValue>(TypeModel model, IExtensible instance, int tag, ProtoBuf.DataFormat format = ProtoBuf.DataFormat.Default /* Metadata: 0x0263CBE2 */);
		public static bool TryGetValue(TypeModel model, System.Type type, IExtensible instance, int tag, ProtoBuf.DataFormat format, bool allowDefinedTag, out object value); // 0x000000018CB5D2FC-0x000000018CB5D528
		public static IEnumerable GetValues(TypeModel model, System.Type type, IExtensible instance, int tag, ProtoBuf.DataFormat format = ProtoBuf.DataFormat.Default /* Metadata: 0x0263CBE3 */); // 0x000000018CB5D270-0x000000018CB5D29C
		public static void AppendValue(TypeModel model, IExtensible instance, int tag, ProtoBuf.DataFormat format, object value); // 0x000000018CB5D0FC-0x000000018CB5D10C
	}

	internal static class ExtensibleUtil // TypeDefIndex: 80531
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _GetExtendedValues_d__0<TValue> : IEnumerable<TValue>, IEnumerator<TValue> // TypeDefIndex: 80529
		{
			// Fields
			private int __1__state;
			private TValue __2__current;
			private int __l__initialThreadId;
			private TypeModel model;
			public TypeModel __3__model;
			private IExtensible instance;
			public IExtensible __3__instance;
			private int tag;
			public int __3__tag;
			private ProtoBuf.DataFormat format;
			public ProtoBuf.DataFormat __3__format;
			private bool singleton;
			public bool __3__singleton;
			private bool allowDefinedTag;
			public bool __3__allowDefinedTag;
			private IEnumerator __7__wrap1;
	
			// Properties
			TValue IEnumerator<TValue>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetExtendedValues_d__0(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated]
		private sealed class _GetExtendedValues_d__2 : IEnumerable<object>, IEnumerator<object> // TypeDefIndex: 80530
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private TypeModel model; // 0x28
			public TypeModel __3__model; // 0x30
			private IExtension extn; // 0x38
			public IExtension __3__extn; // 0x40
			private bool singleton; // 0x48
			public bool __3__singleton; // 0x49
			private ProtoBuf.DataFormat format; // 0x4C
			public ProtoBuf.DataFormat __3__format; // 0x50
			private int tag; // 0x54
			public int __3__tag; // 0x58
			private System.Type type; // 0x60
			public System.Type __3__type; // 0x68
			private Stream _stream_5__2; // 0x70
			private ProtoReader.SolidState _state_5__3; // 0x78
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetExtendedValues_d__2(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018CB668FC-0x000000018CB669F4
			private bool MoveNext(); // 0x000000018CB66300-0x000000018CB667DC
			private void __m__Finally1(); // 0x000000018CB669F4-0x000000018CB66A20
			private void __m__Finally2(); // 0x000000018CB66A20-0x000000018CB66A34
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB668B0-0x000000018CB668FC
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator(); // 0x000000018CB667DC-0x000000018CB668A8
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018CB668A8-0x000000018CB668B0
		}
	
		// Methods
		[IteratorStateMachine(typeof(_GetExtendedValues_d__0<TValue>))]
		internal static IEnumerable<TValue> GetExtendedValues<TValue>(TypeModel model, IExtensible instance, int tag, ProtoBuf.DataFormat format, bool singleton, bool allowDefinedTag);
		internal static IEnumerable GetExtendedValues(TypeModel model, System.Type type, IExtensible instance, int tag, ProtoBuf.DataFormat format, bool singleton, bool allowDefinedTag); // 0x000000018CB5D03C-0x000000018CB5D0FC
		[IteratorStateMachine(typeof(_GetExtendedValues_d__2))]
		internal static IEnumerable GetExtendedValues(TypeModel model, System.Type type, IExtension extn, int tag, ProtoBuf.DataFormat format, bool singleton); // 0x000000018CB5CF7C-0x000000018CB5D03C
		internal static void AppendExtendValue(TypeModel model, IExtensible instance, int tag, ProtoBuf.DataFormat format, object value); // 0x000000018CB5CBCC-0x000000018CB5CC9C
		internal static void AppendExtendValue(TypeModel model, IExtension extn, int tag, ProtoBuf.DataFormat format, object value); // 0x000000018CB5CC9C-0x000000018CB5CF7C
	}

	internal static class Helpers // TypeDefIndex: 80532
	{
		// Methods
		internal static MethodInfo GetInstanceMethod(System.Type declaringType, string name); // 0x000000018CB5D588-0x000000018CB5D5AC
		internal static MethodInfo GetStaticMethod(System.Type declaringType, string name); // 0x000000018CB5D5AC-0x000000018CB5D5D0
		internal static MethodInfo GetInstanceMethod(System.Type declaringType, string name, System.Type[] types); // 0x0000000185370550-0x0000000185370690
		internal static bool IsSubclassOf(System.Type type, System.Type baseClass); // 0x000000018CB5D5D0-0x000000018CB5D5F4
		public static ProtoTypeCode GetTypeCode(System.Type type); // 0x00000001854C4610-0x00000001854C4A10
		internal static MethodInfo GetGetMethod(PropertyInfo property, bool nonPublic, bool allowInternal); // 0x00000001855B6260-0x00000001855B62E0
		internal static MethodInfo GetSetMethod(PropertyInfo property, bool nonPublic, bool allowInternal); // 0x00000001855B6190-0x00000001855B6210
		internal static ConstructorInfo GetConstructor(System.Type type, System.Type[] parameterTypes, bool nonPublic); // 0x0000000185E076D0-0x0000000185E077B0
		internal static ConstructorInfo[] GetConstructors(System.Type type, bool nonPublic); // 0x00000001858CB4B0-0x00000001858CB4F0
		internal static void GetBuffer(MemoryStream stream, out ArraySegment<byte> segment); // 0x000000018CB5D528-0x000000018CB5D588
		internal static PropertyInfo GetProperty(System.Type type, string name, bool nonPublic); // 0x0000000185371510-0x00000001853715A0
		internal static MemberInfo[] GetInstanceFieldsAndProperties(System.Type type, bool publicOnly); // 0x0000000185298900-0x0000000185298E90
		internal static System.Type GetMemberType(MemberInfo member); // 0x00000001853715A0-0x0000000185371670
	}

	internal enum ProtoTypeCode // TypeDefIndex: 80533
	{
		Empty = 0,
		Unknown = 1,
		Boolean = 3,
		Char = 4,
		SByte = 5,
		Byte = 6,
		Int16 = 7,
		UInt16 = 8,
		Int32 = 9,
		UInt32 = 10,
		Int64 = 11,
		UInt64 = 12,
		Single = 13,
		Double = 14,
		Decimal = 15,
		DateTime = 16,
		String = 18,
		TimeSpan = 100,
		ByteArray = 101,
		Guid = 102,
		Uri = 103,
		Type = 104,
		ByteArraySegment = 105,
		ByteMemory = 106,
		ByteReadOnlyMemory = 107,
		ProtoBytes = 108,
		IntPtr = 109,
		UIntPtr = 110
	}

	public interface IExtensible // TypeDefIndex: 80534
	{
		// Methods
		IExtension GetExtensionObject(bool createIfMissing);
	}

	public interface ITypedExtensible // TypeDefIndex: 80535
	{
		// Methods
		IExtension GetExtensionObject(System.Type type, bool createIfMissing);
	}

	public interface IExtension // TypeDefIndex: 80536
	{
		// Methods
		Stream BeginAppend();
		void EndAppend(Stream stream, bool commit);
		Stream BeginQuery();
		void EndQuery(Stream stream);
		int GetLength();
	}

	public interface IExtensionResettable : IExtension // TypeDefIndex: 80537
	{
		// Methods
		void Reset();
	}

	public enum ImplicitFields // TypeDefIndex: 80538
	{
		None = 0,
		AllPublic = 1,
		AllFields = 2
	}

	public interface IProtoInput<TInput> // TypeDefIndex: 80539
	{
		// Methods
		T Deserialize<T>(TInput source, T value = default, object userState = null);
	}

	public interface IProtoOutput<TOutput> // TypeDefIndex: 80540
	{
		// Methods
		void Serialize<T>(TOutput destination, T value, object userState = null);
	}

	public interface IMeasuredProtoOutput<TOutput> : IProtoOutput<TOutput> // TypeDefIndex: 80541
	{
		// Methods
		MeasureState<T> Measure<T>(T value, object userState = null);
		void Serialize<T>(MeasureState<T> measured, TOutput destination);
	}

	public interface ISerializationContext // TypeDefIndex: 80542
	{
		// Properties
		TypeModel Model { get; }
		object UserState { get; }
	}

	public struct MeasureState<T> : IDisposable // TypeDefIndex: 80543
	{
		// Fields
		private readonly TypeModel _model;
		private readonly T _value;
		private readonly object _userState;
		private ProtoWriter _writer;
		[CompilerGenerated]
		private readonly long _Length_k__BackingField;
	
		// Properties
		public long Length { [CompilerGenerated] [IsReadOnly] get; }
	
		// Constructors
		internal MeasureState(TypeModel model, [IsReadOnly] in ref T value, object userState, long abortAfter);
	
		// Methods
		public void Dispose();
		public long LengthOnly();
		[IsReadOnly]
		private void SerializeCore(ProtoWriter.State state);
		[IsReadOnly]
		internal int GetLengthHits(out int misses);
		[IsReadOnly]
		public void Serialize(Stream stream);
		[IsReadOnly]
		public void Serialize(IBufferWriter<byte> writer);
	}

	internal sealed class NetObjectCache // TypeDefIndex: 80545
	{
		// Fields
		private readonly Dictionary<ObjectKey, long> _knownLengths; // 0x10
		private int _hit; // 0x18
		private int _miss; // 0x1C
	
		// Properties
		internal int LengthHits { get; } // 0x00000001844AF510-0x00000001844AF520 
		internal int LengthMisses { get; } // 0x0000000187233000-0x0000000187233010 
	
		// Nested types
		[IsReadOnly]
		private struct ObjectKey : IEquatable<ObjectKey> // TypeDefIndex: 80544
		{
			// Fields
			private readonly object _obj; // 0x00
			private readonly System.Type _subTypeLevel; // 0x08
	
			// Constructors
			public ObjectKey(object obj, System.Type subTypeLevel); // 0x0000000185B2C340-0x0000000185B2C370
	
			// Methods
			public override string ToString(); // 0x000000018CB5D98C-0x000000018CB5D9CC
			public override int GetHashCode(); // 0x000000018CB5D958-0x000000018CB5D98C
			public override bool Equals(object obj); // 0x000000018CB5D888-0x000000018CB5D8F4
			public bool Equals(ObjectKey other); // 0x000000018CB5D8F4-0x000000018CB5D958
		}
	
		// Constructors
		public NetObjectCache(); // 0x0000000185C186A0-0x0000000185C18720
	
		// Methods
		public bool TryGetKnownLength(object obj, System.Type subTypeLevel, out long length); // 0x000000018CB5D7D4-0x000000018CB5D888
		public void SetKnownLength(object obj, System.Type subTypeLevel, long length); // 0x00000001854C6AB0-0x00000001854C6C40
		internal void Clear(); // 0x00000001851228B0-0x0000000185122960
		internal void InitializeFrom(NetObjectCache obj); // 0x000000018CB5D608-0x000000018CB5D7D4
		internal void CopyBack(NetObjectCache obj); // 0x000000018CB5D5F4-0x000000018CB5D608
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class NullWrappedValueAttribute : Attribute // TypeDefIndex: 80546
	{
		// Fields
		[CompilerGenerated]
		private bool _AsGroup_k__BackingField; // 0x10
	
		// Properties
		public bool AsGroup { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public NullWrappedValueAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class NullWrappedCollectionAttribute : Attribute // TypeDefIndex: 80547
	{
		// Fields
		[CompilerGenerated]
		private bool _AsGroup_k__BackingField; // 0x10
	
		// Properties
		public bool AsGroup { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public NullWrappedCollectionAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public enum PrefixStyle // TypeDefIndex: 80548
	{
		None = 0,
		Base128 = 1,
		Fixed32 = 2,
		Fixed32BigEndian = 3
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class ProtoContractAttribute : Attribute // TypeDefIndex: 80550
	{
		// Fields
		internal const string ReferenceDynamicDisabled = "Reference-tracking and dynamic-type are not currently implemented in this build; they may be reinstated later; this is partly due to doubts over whether the features are adviseable, and partly over confidence in testing all the scenarios (it takes time; that time hasn\'t get happened); feedback is invited"; // Metadata: 0x0263CC12
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _Origin_k__BackingField; // 0x18
		private int implicitFirstTag; // 0x20
		[CompilerGenerated]
		private ImplicitFields _ImplicitFields_k__BackingField; // 0x24
		[CompilerGenerated]
		private int _DataMemberOffset_k__BackingField; // 0x28
		private TypeOptions flags; // 0x2C
		[CompilerGenerated]
		private System.Type _Surrogate_k__BackingField; // 0x30
		[CompilerGenerated]
		private System.Type _Serializer_k__BackingField; // 0x38
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string Origin { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public int ImplicitFirstTag { get; set; } // 0x000000018226A850-0x000000018226A860 0x000000018CB5E934-0x000000018CB5E984
		public bool UseProtoMembersOnly { get; set; } // 0x00000001854733A0-0x00000001854733B0 0x000000018CB5E9D4-0x000000018CB5E9E8
		public bool IgnoreListHandling { get; set; } // 0x0000000185473350-0x0000000185473360 0x000000018CB5E90C-0x000000018CB5E920
		public ImplicitFields ImplicitFields { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public bool InferTagFromName { get; set; } // 0x000000018CB5E8A0-0x000000018CB5E8B0 0x000000018CB5E984-0x000000018CB5E9AC
		internal bool InferTagFromNameHasValue { get; } // 0x0000000185473340-0x0000000185473350 
		public int DataMemberOffset { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public bool SkipConstructor { get; set; } // 0x0000000185473330-0x0000000185473340 0x000000018CB5E9C0-0x000000018CB5E9D4
		public bool AsReferenceDefault { get; [Obsolete("Reference-tracking and dynamic-type are not currently implemented in this build; they may be reinstated later; this is partly due to doubts over whether the features are adviseable, and partly over confidence in testing all the scenarios (it takes time; that time hasn\'t get happened); feedback is invited", true)] set; } // 0x00000001843FFFF0-0x0000000184400000 0x000000018CB5E8B0-0x000000018CB5E8C8
		public bool IsGroup { get; set; } // 0x0000000185473360-0x0000000185473380 0x000000018CB5E9AC-0x000000018CB5E9C0
		public bool IgnoreUnknownSubTypes { get; set; } // 0x0000000185473380-0x00000001854733A0 0x000000018CB5E920-0x000000018CB5E934
		[Obsolete("Enum value maps have been deprecated and are no longer supported; all enums are now effectively pass-thru; custom maps should be applied via shadow properties; in C#, lambda-based \'switch expressions\' make for very convenient shadow properties", true)]
		public bool EnumPassthru { get; set; } // 0x00000001851A4410-0x00000001851A4420 0x000000018CB5E8C8-0x000000018CB5E90C
		public System.Type Surrogate { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicMethods)]
		public System.Type Serializer { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
	
		// Nested types
		[Flags]
		private enum TypeOptions : ushort // TypeDefIndex: 80549
		{
			InferTagFromName = 1,
			InferTagFromNameHasValue = 2,
			UseProtoMembersOnly = 4,
			SkipConstructor = 8,
			IgnoreListHandling = 16,
			IsGroup = 256,
			IgnoreUnknownSubTypes = 512
		}
	
		// Constructors
		public ProtoContractAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private bool HasFlag(TypeOptions flag); // 0x00000001854733B0-0x00000001854733D0
		private void SetFlag(TypeOptions flag, bool value); // 0x000000018CB5E884-0x000000018CB5E8A0
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public class ProtoConverterAttribute : Attribute // TypeDefIndex: 80551
	{
		// Constructors
		public ProtoConverterAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public sealed class ProtoEnumAttribute : Attribute // TypeDefIndex: 80552
	{
		// Fields
		internal const string EnumValueDeprecated = "Enum value maps have been deprecated and are no longer supported; all enums are now effectively pass-thru; custom maps should be applied via shadow properties; in C#, lambda-based \'switch expressions\' make for very convenient shadow properties"; // Metadata: 0x0263CD53
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x10
	
		// Properties
		public int Value { [Obsolete("Enum value maps have been deprecated and are no longer supported; all enums are now effectively pass-thru; custom maps should be applied via shadow properties; in C#, lambda-based \'switch expressions\' make for very convenient shadow properties", false)] get; [Obsolete("Enum value maps have been deprecated and are no longer supported; all enums are now effectively pass-thru; custom maps should be applied via shadow properties; in C#, lambda-based \'switch expressions\' make for very convenient shadow properties", true)] set; } // 0x0000000185829EC0-0x0000000185829ED0 0x0000000189CB8C38-0x0000000189CB8C44
		public string Name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public ProtoEnumAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[Obsolete("Enum value maps have been deprecated and are no longer supported; all enums are now effectively pass-thru; custom maps should be applied via shadow properties; in C#, lambda-based \'switch expressions\' make for very convenient shadow properties", false)]
		public bool HasValue(); // 0x00000001843FFFF0-0x0000000184400000
	}

	[Serializable]
	public class ProtoException : Exception // TypeDefIndex: 80553
	{
		// Constructors
		public ProtoException(); // 0x000000018CB5EB10-0x000000018CB5EB5C
		public ProtoException(string message); // 0x000000018CB5EA48-0x000000018CB5EAA4
		public ProtoException(string message, Exception innerException); // 0x000000018CB5E9E8-0x000000018CB5EA48
		protected ProtoException(SerializationInfo info, StreamingContext context); // 0x000000018CB5EAA4-0x000000018CB5EB10
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ProtoIgnoreAttribute : Attribute // TypeDefIndex: 80554
	{
		// Constructors
		public ProtoIgnoreAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	public sealed class ProtoPartialIgnoreAttribute : ProtoIgnoreAttribute // TypeDefIndex: 80555
	{
		// Fields
		[CompilerGenerated]
		private readonly string _MemberName_k__BackingField; // 0x10
	
		// Properties
		public string MemberName { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public ProtoPartialIgnoreAttribute(string memberName); // 0x000000018CB5ED90-0x000000018CB5EDF0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	public sealed class ProtoIncludeAttribute : Attribute // TypeDefIndex: 80556
	{
		// Fields
		[CompilerGenerated]
		private readonly int _Tag_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly string _KnownTypeName_k__BackingField; // 0x18
		[CompilerGenerated]
		private ProtoBuf.DataFormat _DataFormat_k__BackingField; // 0x20
	
		// Properties
		public int Tag { [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public string KnownTypeName { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)]
		public System.Type KnownType { get; } // 0x000000018CB5EC80-0x000000018CB5EC90 
		[DefaultValue(ProtoBuf.DataFormat.Default)]
		public ProtoBuf.DataFormat DataFormat { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
	
		// Constructors
		public ProtoIncludeAttribute(int tag, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type knownType); // 0x000000018CB5EB5C-0x000000018CB5EBCC
		public ProtoIncludeAttribute(int tag, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] string knownTypeName); // 0x000000018CB5EBCC-0x000000018CB5EC80
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ProtoMapAttribute : Attribute // TypeDefIndex: 80557
	{
		// Fields
		[CompilerGenerated]
		private ProtoBuf.DataFormat _KeyFormat_k__BackingField; // 0x10
		[CompilerGenerated]
		private ProtoBuf.DataFormat _ValueFormat_k__BackingField; // 0x14
		[CompilerGenerated]
		private bool _DisableMap_k__BackingField; // 0x18
	
		// Properties
		public ProtoBuf.DataFormat KeyFormat { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public ProtoBuf.DataFormat ValueFormat { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
		public bool DisableMap { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
	
		// Constructors
		public ProtoMapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ProtoMemberAttribute : Attribute, IComparable, IComparable<ProtoMemberAttribute> // TypeDefIndex: 80558
	{
		// Fields
		internal MemberInfo Member; // 0x10
		internal MemberInfo BackingMember; // 0x18
		internal bool TagIsPinned; // 0x20
		private string name; // 0x28
		private ProtoBuf.DataFormat dataFormat; // 0x30
		private int tag; // 0x34
		private MemberSerializationOptions options; // 0x38
	
		// Properties
		public string Name { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000186576BB0-0x0000000186576BC0
		public ProtoBuf.DataFormat DataFormat { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public int Tag { get; } // 0x0000000182271A70-0x0000000182271A80 
		public bool IsRequired { get; set; } // 0x0000000185473180-0x0000000185473190 0x00000001864488E0-0x0000000186448970
		public bool IsPacked { get; set; } // 0x0000000185473170-0x0000000185473180 0x0000000186447E60-0x0000000186447E80
		public bool OverwriteList { get; set; } // 0x0000000185473160-0x0000000185473170 0x00000001864488C0-0x00000001864488E0
		[Obsolete("Reference-tracking and dynamic-type are not currently implemented in this build; they may be reinstated later; this is partly due to doubts over whether the features are adviseable, and partly over confidence in testing all the scenarios (it takes time; that time hasn\'t get happened); feedback is invited", true)]
		public bool AsReference { get; set; } // 0x0000000186318180-0x0000000186318190 0x000000018CB5ED54-0x000000018CB5ED74
		[Obsolete("Reference-tracking and dynamic-type are not currently implemented in this build; they may be reinstated later; this is partly due to doubts over whether the features are adviseable, and partly over confidence in testing all the scenarios (it takes time; that time hasn\'t get happened); feedback is invited", true)]
		internal bool AsReferenceHasValue { get; set; } // 0x0000000185473150-0x0000000185473160 0x000000018CB5ED38-0x000000018CB5ED54
		[Obsolete("Reference-tracking and dynamic-type are not currently implemented in this build; they may be reinstated later; this is partly due to doubts over whether the features are adviseable, and partly over confidence in testing all the scenarios (it takes time; that time hasn\'t get happened); feedback is invited", true)]
		public bool DynamicType { get; set; } // 0x0000000185473140-0x0000000185473150 0x000000018CB5ED74-0x000000018CB5ED90
		public MemberSerializationOptions Options { get; set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
	
		// Constructors
		public ProtoMemberAttribute(int tag); // 0x00000001862338A0-0x00000001862338F0
		internal ProtoMemberAttribute(int tag, bool forced); // 0x00000001862338F0-0x0000000186233980
	
		// Methods
		public int CompareTo(object other); // 0x000000018CB5EC90-0x000000018CB5ECE4
		public int CompareTo(ProtoMemberAttribute other); // 0x000000018CB5ECE4-0x000000018CB5ED38
		internal void Rebase(int tag); // 0x0000000182271AA0-0x0000000182271AB0
	}

	[Flags]
	public enum MemberSerializationOptions // TypeDefIndex: 80559
	{
		None = 0,
		Packed = 1,
		Required = 2,
		AsReference = 4,
		DynamicType = 8,
		OverwriteList = 16,
		AsReferenceHasValue = 32
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	public sealed class ProtoPartialMemberAttribute : ProtoMemberAttribute // TypeDefIndex: 80560
	{
		// Fields
		[CompilerGenerated]
		private string _MemberName_k__BackingField; // 0x40
	
		// Properties
		public string MemberName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
	
		// Constructors
		public ProtoPartialMemberAttribute(int tag, string memberName); // 0x000000018CB5EDF0-0x000000018CB5EE68
	}

	public abstract class ProtoReader : IDisposable, ISerializationContext // TypeDefIndex: 80567
	{
		// Fields
		internal const string PreferStateAPI = "If possible, please use the State API; a transitionary implementation is provided, but this API may be removed in a future version"; // Metadata: 0x0263CE57
		internal const string PreferReadMessage = "If possible, please use the ReadMessage API; this API may not work correctly with all readers"; // Metadata: 0x0263CEDB
		private TypeModel _model; // 0x10
		private int _fieldNumber; // 0x18
		private int _depth; // 0x1C
		private long blockEnd64; // 0x20
		private readonly NetObjectCache netCache; // 0x28
		[CompilerGenerated]
		private WireType _WireType_k__BackingField; // 0x30
		internal const long TO_EOF = -1; // Metadata: 0x0263CF3A
		[CompilerGenerated]
		private bool _InternStrings_k__BackingField; // 0x34
		[CompilerGenerated]
		private object _UserState_k__BackingField; // 0x38
		private long _longPosition; // 0x40
		private Dictionary<string, string> stringInterner; // 0x48
		private protected static readonly UTF8Encoding UTF8; // 0x00
		internal static readonly byte[] EmptyBlob; // 0x08
		internal const MethodImplOptions HotPath = MethodImplOptions.AggressiveInlining; // Metadata: 0x0263CF42
		private static readonly System.Reflection.FieldInfo s_origin; // 0x10
		private static readonly System.Reflection.FieldInfo s_buffer; // 0x18
	
		// Properties
		public int FieldNumber { get; } // 0x00000001844AF510-0x00000001844AF520 
		public WireType WireType { [CompilerGenerated] get; [CompilerGenerated] private protected set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public bool InternStrings { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EBB0-0x000000018226EBC0 0x000000018226EBC0-0x000000018226EBD0
		public object UserState { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		[Obsolete("Prefer UserState")]
		public SerializationContext Context { get; } // 0x000000018CB60B40-0x000000018CB60B8C 
		public int Position { get; } // 0x000000018CB60B8C-0x000000018CB60BDC 
		public long LongPosition { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public TypeModel Model { get; internal set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Nested types
		private protected enum Read32VarintMode // TypeDefIndex: 80561
		{
			Signed = 0,
			Unsigned = 1,
			FieldHeader = 2
		}
	
		[IsByRefLike]
		[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		public struct State // TypeDefIndex: 80562
		{
			// Fields
			private ProtoReader _reader; // 0x00
			[CompilerGenerated]
			private ReadOnlySpan<byte> _Span_k__BackingField; // 0x08
			private ReadOnlyMemory<byte> _memory; // 0x18
			[CompilerGenerated]
			private int _OffsetInCurrent_k__BackingField; // 0x28
			[CompilerGenerated]
			private int _RemainingInCurrent_k__BackingField; // 0x2C
	
			// Properties
			internal ReadOnlySpan<byte> Span { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x000000018453CA30-0x000000018453CA40 0x000000018723B0B0-0x000000018723B0C0
			internal int OffsetInCurrent { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
			internal int RemainingInCurrent { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
			public WireType WireType { [IsReadOnly] get; } // 0x000000018CB65D98-0x000000018CB65DB4 
			public bool InternStrings { [IsReadOnly] get; [IsReadOnly] set; } // 0x000000018CB65D10-0x000000018CB65D2C 0x000000018CB65DD0-0x000000018CB65DEC
			public int FieldNumber { [IsReadOnly] get; } // 0x0000000187836540-0x000000018783655C 
			internal TypeModel Model { [IsReadOnly] get; [IsReadOnly] private set; } // 0x000000018CB65D2C-0x000000018CB65D3C 0x000000018CB65DEC-0x000000018CB65E10
			public ISerializationContext Context { [IsReadOnly] get; } // 0x0000000184431970-0x0000000184431980 
	
			// Constructors
			internal State(ProtoReader reader, ReadOnlyMemory<byte> memory); // 0x000000018CB65CA0-0x000000018CB65CD8
			internal State(ProtoReader reader); // 0x0000000187254B30-0x0000000187254B50
	
			// Methods
			public static State Create(ReadOnlySequence<byte> source, TypeModel model, object userState = null); // 0x0000000185121C00-0x00000001851220A0
			public static State Create(ReadOnlyMemory<byte> source, TypeModel model, object userState = null); // 0x0000000185121710-0x0000000185121C00
			public void Dispose(); // 0x0000000186049B30-0x0000000186049B60
			[IsReadOnly]
			internal SolidState Solidify(); // 0x000000018CB646C4-0x000000018CB64758
			internal void Init(ReadOnlyMemory<byte> memory); // 0x0000000184F8A2D0-0x0000000184F8A350
			internal void Skip(int bytes); // 0x0000000187254AD0-0x0000000187254AE0
			internal ReadOnlySpan<byte> Consume(int bytes); // 0x000000018CB63408-0x000000018CB6348C
			internal ReadOnlySpan<byte> Consume(int bytes, out int offset); // 0x0000000187254AA0-0x0000000187254AC0
			internal int ReadVarintUInt32(out uint value); // 0x0000000184FF8CB0-0x0000000184FF9980
			internal int ParseVarintUInt32(ReadOnlySpan<byte> span, out uint value); // 0x000000018CB637C0-0x000000018CB63808
			internal int ParseVarintUInt32(ReadOnlySpan<byte> span, int offset, out uint value); // 0x000000018CB63808-0x000000018CB638B0
			private int ParseVarintUInt32Tail(ReadOnlySpan<byte> span, ref uint value); // 0x00000001862C38A0-0x00000001862C38F0
			[IsReadOnly]
			internal void Advance(long count); // 0x000000018CB62AE0-0x000000018CB62AFC
			internal static int TryParseUInt64Varint(ReadOnlySpan<byte> span, int offset, out ulong value); // 0x0000000185B34720-0x0000000185B349E0
			[IsReadOnly]
			internal ProtoReader GetReader(); // 0x0000000184431970-0x0000000184431980
			public ushort ReadUInt16(); // 0x000000018CB642E4-0x000000018CB64338
			public short ReadInt16(); // 0x000000018CB63E70-0x000000018CB63EC4
			[IsReadOnly]
			public long GetPosition(); // 0x000000018783655C-0x0000000187836578
			public byte ReadByte(); // 0x000000018CB638C4-0x000000018CB63918
			public sbyte ReadSByte(); // 0x000000018CB64020-0x000000018CB64070
			public IntPtr ReadIntPtr(); // 0x000000018CB64010-0x000000018CB64018
			public UIntPtr ReadUIntPtr(); // 0x000000018CB64510-0x000000018CB6453C
			public uint ReadUInt32(); // 0x000000018CB643AC-0x000000018CB64454
			public int ReadInt32(); // 0x000000018CB63EC4-0x000000018CB63F88
			public long ReadInt64(); // 0x000000018CB63F88-0x000000018CB64010
			public double ReadDouble(); // 0x000000018CB63B14-0x000000018CB63B54
			public float ReadSingle(); // 0x000000018CB64070-0x000000018CB640F8
			private void PrepareToReadRepeated<T>(ref SerializerFeatures features, SerializerFeatures serializerFeatures, out SerializerFeatures category, out bool packed);
			private void ReadRepeatedCore<TSerializer, TList, T>(ref ref TList values, SerializerFeatures category, WireType wireType, [IsReadOnly] in ref TSerializer serializer, SerializerFeatures features)
				where TSerializer : ISerializer<T>
				where TList : ICollection<T>;
			private void ReadPackedScalar<TSerializer, TList, T>(ref ref TList list, WireType wireType, [IsReadOnly] in ref TSerializer serializer)
				where TSerializer : ISerializer<T>
				where TList : ICollection<T>;
			internal ReadBuffer<T> FillBuffer<TSerializer, T>(SerializerFeatures features, [IsReadOnly] in ref TSerializer serializer, T initialValue)
				where TSerializer : ISerializer<T>;
			public bool ReadBoolean(); // 0x000000018CB638B0-0x000000018CB638C4
			public ulong ReadUInt64(); // 0x000000018CB644B0-0x000000018CB64510
			public byte[] AppendBytes(byte[] value); // 0x000000018CB62CE4-0x000000018CB62D60
			public ReadOnlyMemory<byte> AppendBytes(ReadOnlyMemory<byte> value); // 0x000000018CB62AFC-0x000000018CB62BA4
			public Memory<byte> AppendBytes(Memory<byte> value); // 0x000000018CB62D60-0x000000018CB62E08
			public ArraySegment<byte> AppendBytes(ArraySegment<byte> value); // 0x000000018CB62BA4-0x000000018CB62C4C
			public ProtoBytes AppendBytes(ProtoBytes value); // 0x000000018CB62C4C-0x000000018CB62CE4
			public TStorage AppendBytes<TStorage>(TStorage value, IMemoryConverter<TStorage, byte> converter = null);
			private TStorage AppendBytesImpl<TStorage>(TStorage value, IMemoryConverter<TStorage, byte> converter);
			[Browsable(false)]
			public Span<byte> ReadBytes(Span<byte> destination); // 0x000000018CB63918-0x000000018CB639B0
			public void ReadBytes(Span<byte> destination, out int length); // 0x000000018CB639B0-0x000000018CB63B14
			public SubItemToken StartSubItem(); // 0x00000001854CA300-0x00000001854CA500
			public void EndSubItem(SubItemToken token); // 0x00000001854CA1A0-0x00000001854CA250
			internal object ReadObject(object value, System.Type type); // 0x000000018CB64018-0x000000018CB64020
			internal object ReadTypedObject(object value, System.Type type); // 0x000000018CB6419C-0x000000018CB642E4
			internal void SkipAllFields(); // 0x000000018CB6460C-0x000000018CB64638
			public string ReadString(StringMap map = null); // 0x000000018CB640F8-0x000000018CB6419C
			private uint ReadUInt32Varint(Read32VarintMode mode); // 0x000000018CB64338-0x000000018CB643AC
			private ulong ReadUInt64Varint(); // 0x000000018CB64454-0x000000018CB644B0
			public void Assert(WireType wireType); // 0x000000018CB5950C-0x000000018CB59640
			public void SkipField(); // 0x0000000189D859A4-0x0000000189D85A6C
			[IsReadOnly]
			internal System.Type DeserializeType(string typeName); // 0x000000018CB63568-0x000000018CB6358C
			private void SkipGroup(); // 0x000000018CB64638-0x000000018CB646C4
			public int ReadFieldHeader(); // 0x000000018CB63B54-0x000000018CB63BD4
			private int ReadFieldHeaderFallback(); // 0x00000001854CC6A0-0x00000001854CC8E0
			public bool TryReadFieldHeader(int field); // 0x000000018CB64F00-0x000000018CB64F98
			internal void CheckFullyConsumed(); // 0x000000018CB63348-0x000000018CB633A0
			[IsReadOnly]
			public void Hint(WireType wireType); // 0x000000018CB636D4-0x000000018CB63700
			internal void ThrowWireTypeException(); // 0x000000018CB64E78-0x000000018CB64F00
			internal void ThrowProtoException(string message); // 0x000000018CB64D54-0x000000018CB64DC8
			internal void ThrowEoF(); // 0x000000018CB64A84-0x000000018CB64AEC
			internal void ThrowTooDeep(); // 0x000000018CB64DC8-0x000000018CB64E28
			internal void ThrowInvalidOperationException(string message = null); // 0x000000018CB64B44-0x000000018CB64BE4
			internal void ThrowInvalidLength(long length); // 0x000000018CB64AEC-0x000000018CB64B44
			internal void ThrowArgumentException(string message); // 0x000000018CB64840-0x000000018CB648B4
			internal void ThrowOverflow(); // 0x000000018CB64CEC-0x000000018CB64D54
			internal static Exception AddErrorData(Exception exception, ProtoReader source, ref State state); // 0x000000018CB628D4-0x000000018CB62AE0
			private static int Zag(uint ziggedValue); // 0x0000000187254AE0-0x0000000187254AF0
			private static long Zag(ulong ziggedValue); // 0x0000000187254AF0-0x0000000187254B10
			public void ThrowEnumException(System.Type type, int value); // 0x000000018CB649A4-0x000000018CB64A84
			public void AppendExtensionData(IExtensible instance); // 0x000000018CB6315C-0x000000018CB631D4
			public void AppendExtensionData(ITypedExtensible instance, System.Type type); // 0x000000018CB630E8-0x000000018CB6315C
			private void AppendExtensionDataImpl(IExtension extn); // 0x000000018CB62E08-0x000000018CB6305C
			private void AppendExtensionField(ref ProtoWriter.State writeState); // 0x000000018CB631D4-0x000000018CB63314
			public System.Type ReadType(); // 0x000000018CB59640-0x000000018CB5974C
			public T ReadMessage<T>(T value = default);
			public T ReadMessage<T>(SerializerFeatures features, T value = default, ISerializer<T> serializer = null);
			internal T ReadMessage<TSerializer, T>(SerializerFeatures features, T value, [IsReadOnly] in ref TSerializer serializer)
				where TSerializer : ISerializer<T>;
			public T ReadAny<T>(T value = default);
			public T ReadAny<T>(SerializerFeatures features, T value = default, ISerializer<T> serializer = null);
			public T ReadWrapped<T>(SerializerFeatures features, T value, ISerializer<T> serializer = null);
			public ISerializer<T> GetSerializer<T>();
			public T ReadBaseType<TBaseType, T>(T value = default, ISubTypeSerializer<TBaseType> serializer = null)
				where TBaseType : class
				where T : class, TBaseType;
			public T DeserializeRoot<T>(T value = default, ISerializer<T> serializer = null);
			internal T ReadAsRoot<T>(T value, ISerializer<T> serializer);
			[IsReadOnly]
			public bool HasSubValue(WireType wireType); // 0x000000018CB63680-0x000000018CB636D4
			public T CreateInstance<T>(ISerializer<T> serializer = null);
			internal object DeserializeRootFallbackWithModel(object value, System.Type type, TypeModel overrideModel); // 0x000000018CB6348C-0x000000018CB63568
			internal object DeserializeRootFallback(object value, System.Type type); // 0x000000018511F760-0x000000018511FA10
			internal T DeserializeRootImpl<T>(T value = default);
			public static State Create(Stream source, TypeModel model, object userState = null, long length = -1 /* Metadata: 0x0263CF47 */); // 0x0000000185C163E0-0x0000000185C16490
			[CompilerGenerated]
			internal static T _ReadAsRoot_g__ReadFieldOne_111_0<T>(ref State state, SerializerFeatures features, T value, ISerializer<T> serializer);
		}
	
		private sealed class ReadOnlySequenceProtoReader : ProtoReader // TypeDefIndex: 80564
		{
			// Fields
			private ReadOnlySequence<byte> _source; // 0x50
	
			// Nested types
			[CompilerGenerated]
			private struct __c__DisplayClass14_0 // TypeDefIndex: 80563
			{
				// Fields
				public ReadOnlySequenceProtoReader __4__this; // 0x00
				public int bytesToRead; // 0x08
			}
	
			// Constructors
			public ReadOnlySequenceProtoReader(); // 0x0000000185C18840-0x0000000185C18890
	
			// Methods
			protected internal override State DefaultState(); // 0x000000018CB61F10-0x000000018CB61F58
			internal static string ToString(ReadOnlySpan<byte> span, int offset, int bytes); // 0x000000018CB62288-0x000000018CB62398
			internal static string ToString(ReadOnlySpan<byte> span); // 0x000000018CB62170-0x000000018CB62288
			internal static int TryParseUInt32Varint(ref State state, int offset, bool trimNegative, out uint value, ReadOnlySpan<byte> span); // 0x0000000184F8C1C0-0x0000000184F8C400
			public override void Dispose(); // 0x0000000185122470-0x0000000185122600
			internal void Init(ReadOnlySequence<byte> source, TypeModel model, object userState); // 0x00000001851220A0-0x0000000185122470
			private int GetSomeData(ref State state, bool throwIfEOF = true /* Metadata: 0x0263CF4F */); // 0x000000018CB61F58-0x000000018CB61F68
			private int ReadNextBuffer(ref State state, bool throwIfEOF); // 0x0000000184F8AE20-0x0000000184F8B580
			private protected override int ImplTryReadUInt64VarintWithoutMoving(ref State state, out ulong value); // 0x0000000185B346F0-0x0000000185B34720
			private protected override uint ImplReadUInt32Fixed(ref State state); // 0x000000018585FDE0-0x0000000185860220
			private protected override ulong ImplReadUInt64Fixed(ref State state); // 0x000000018585FD30-0x000000018585FDE0
			private protected override string ImplReadString(ref State state, int bytes); // 0x000000018588B5F0-0x000000018588B8A0
			private string ImplReadStringMultiSegment(ref State state, int bytes); // 0x000000018CB61F68-0x000000018CB620F4
			private void ImplReadBytes(ref State state, Span<byte> target, int bytesToRead); // 0x0000000186D245E0-0x0000000186D246A0
			private protected override void ImplReadBytes(ref State state, Span<byte> target); // 0x0000000186D24570-0x0000000186D245E0
			private ReadOnlySpan<byte> Consume(ref State state, int bytes); // 0x000000018CB61EA4-0x000000018CB61ED8
			private ReadOnlySpan<byte> Consume(ref State state, int bytes, out int offset); // 0x000000018CB61ED8-0x000000018CB61F10
			private static ReadOnlySpan<byte> Peek(ref State state, int bytes); // 0x000000018CB620F4-0x000000018CB62170
			private protected override int ImplTryReadUInt32VarintWithoutMoving(ref State state, Read32VarintMode mode, out uint value); // 0x0000000184F8C170-0x0000000184F8C1C0
			private protected override void ImplSkipBytes(ref State state, long count); // 0x00000001853ADD80-0x00000001853ADE50
			private void Skip(ref State state, int bytes); // 0x0000000187254A60-0x0000000187254A70
			private protected override bool IsFullyConsumed(ref State state); // 0x0000000184F8A3B0-0x0000000184F8A3E0
			[CompilerGenerated]
			internal static int _ImplTryReadUInt64VarintWithoutMoving_g__ViaStackAlloc_9_0(ReadOnlySequenceProtoReader reader, ref State s, out ulong val); // 0x0000000185B342E0-0x0000000185B346F0
			[CompilerGenerated]
			private uint _ImplReadUInt32Fixed_g__ViaStackAlloc_10_0(ref State st); // 0x000000018CB624C0-0x000000018CB62684
			[CompilerGenerated]
			private ulong _ImplReadUInt64Fixed_g__ViaStackAlloc_11_0(ref State st); // 0x000000018CB62684-0x000000018CB62848
			[CompilerGenerated]
			private void _ImplReadBytes_g__Looped_14_0(ref State st, Span<byte> ttarget, ref __c__DisplayClass14_0 param_000aca90); // 0x000000018CB62398-0x000000018CB624C0
			[CompilerGenerated]
			private int _ImplTryReadUInt32VarintWithoutMoving_g__ViaStackAlloc_19_0(ref State s, Read32VarintMode m, out uint val); // 0x0000000184F8B640-0x0000000184F8C170
			[CompilerGenerated]
			private void _ImplSkipBytes_g__Looped_20_0(ref State st, long ccount); // 0x00000001853ADE50-0x00000001853ADF00
		}
	
		[IsReadOnly]
		internal struct SolidState : IDisposable // TypeDefIndex: 80565
		{
			// Fields
			private readonly ReadOnlyMemory<byte> _memory; // 0x00
			private readonly ProtoReader _reader; // 0x10
	
			// Constructors
			internal SolidState(ProtoReader reader, ReadOnlyMemory<byte> memory); // 0x000000018CB6289C-0x000000018CB628C4
	
			// Methods
			public void Dispose(); // 0x000000018CB62848-0x000000018CB6285C
			internal State Liquify(); // 0x000000018CB6285C-0x000000018CB6289C
		}
	
		private sealed class StreamProtoReader : ProtoReader // TypeDefIndex: 80566
		{
			// Fields
			private Stream _source; // 0x50
			private byte[] _ioBuffer; // 0x58
			private bool _isFixedLength; // 0x60
			private int _ioIndex; // 0x64
			private int _available; // 0x68
			private long _dataRemaining64; // 0x70
	
			// Constructors
			[Obsolete("Please use ProtoReader.Create; this API may be removed in a future version", false)]
			public StreamProtoReader(Stream source, TypeModel model, SerializationContext context, int length); // 0x000000018CB66274-0x000000018CB66300
			[Obsolete("Please use ProtoReader.Create; this API may be removed in a future version", false)]
			public StreamProtoReader(Stream source, TypeModel model, SerializationContext context, long length); // 0x000000018CB66168-0x000000018CB661E8
			internal StreamProtoReader(); // 0x0000000185C159C0-0x0000000185C15A10
			[Obsolete("Please use ProtoReader.Create; this API may be removed in a future version", false)]
			public StreamProtoReader(Stream source, TypeModel model, SerializationContext context); // 0x000000018CB661E8-0x000000018CB66274
	
			// Methods
			protected internal override State DefaultState(); // 0x0000000187254B50-0x0000000187254B70
			internal void Init(Stream source, TypeModel model, object userState, long length); // 0x0000000185C15EE0-0x0000000185C16050
			public override void Dispose(); // 0x0000000186987C60-0x0000000186987D00
			private protected override int ImplTryReadUInt32VarintWithoutMoving(ref State state, Read32VarintMode mode, out uint value); // 0x0000000186435E00-0x0000000186435EE0
			private protected override ulong ImplReadUInt64Fixed(ref State state); // 0x000000018CB6609C-0x000000018CB66168
			private protected override void ImplReadBytes(ref State state, Span<byte> target); // 0x000000018CB65E2C-0x000000018CB65FD0
			private protected override int ImplTryReadUInt64VarintWithoutMoving(ref State state, out ulong value); // 0x0000000186435D70-0x0000000186435E00
			private protected override string ImplReadString(ref State state, int bytes); // 0x0000000186870D20-0x0000000186870E50
			private protected override bool IsFullyConsumed(ref State state); // 0x0000000186A5DB70-0x0000000186A5DB90
			private protected override uint ImplReadUInt32Fixed(ref State state); // 0x000000018CB65FD0-0x000000018CB6609C
			private void Ensure(ref State state, int count, bool strict); // 0x0000000186435EE0-0x0000000186435F50
			private protected override void ImplSkipBytes(ref State state, long count); // 0x0000000186558750-0x00000001865587D0
		}
	
		// Constructors
		private protected ProtoReader(); // 0x0000000185C185C0-0x0000000185C18630
		static ProtoReader(); // 0x0000000186496870-0x0000000186496A40
	
		// Methods
		private protected abstract int ImplTryReadUInt64VarintWithoutMoving(ref State state, out ulong value);
		private protected abstract uint ImplReadUInt32Fixed(ref State state);
		private protected abstract ulong ImplReadUInt64Fixed(ref State state);
		private protected abstract string ImplReadString(ref State state, int bytes);
		private protected abstract void ImplSkipBytes(ref State state, long count);
		private protected abstract int ImplTryReadUInt32VarintWithoutMoving(ref State state, Read32VarintMode mode, out uint value);
		private protected abstract void ImplReadBytes(ref State state, Span<byte> target);
		private protected virtual void ImplReadBytes(ref State state, ReadOnlySequence<byte> target); // 0x000000018CB5F4D0-0x000000018CB5F688
		private protected abstract bool IsFullyConsumed(ref State state);
		private bool IncrDepth(); // 0x000000018CB5F688-0x000000018CB5F6AC
		private void DecrDepth(); // 0x00000001872549D0-0x00000001872549E0
		internal void Init(TypeModel model, object userState); // 0x0000000185122600-0x0000000185122750
		public virtual void Dispose(); // 0x0000000185122750-0x00000001851228B0
		internal void Advance(long count); // 0x00000001872549C0-0x00000001872549D0
		public short ReadInt16(); // 0x000000018CB5FD48-0x000000018CB5FD9C
		public ushort ReadUInt16(); // 0x000000018CB60408-0x000000018CB6045C
		public byte ReadByte(); // 0x000000018CB5FC4C-0x000000018CB5FCA0
		public sbyte ReadSByte(); // 0x000000018CB602B8-0x000000018CB6030C
		public uint ReadUInt32(); // 0x000000018CB6045C-0x000000018CB604B0
		public int ReadInt32(); // 0x000000018CB5FD9C-0x000000018CB5FDF0
		public long ReadInt64(); // 0x000000018CB5FDF0-0x000000018CB5FE44
		private protected string Intern(string value); // 0x000000018CB5F6AC-0x000000018CB5F808
		public string ReadString(); // 0x000000018CB60360-0x000000018CB603B4
		public void ThrowEnumException(System.Type type, int value); // 0x000000018CB60900-0x000000018CB60950
		public double ReadDouble(); // 0x000000018CB5FCA0-0x000000018CB5FCF4
		public static object ReadObject(object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, ProtoReader reader); // 0x000000018CB60240-0x000000018CB602B8
		public static void EndSubItem(SubItemToken token, ProtoReader reader); // 0x000000018CB5F400-0x000000018CB5F458
		public static SubItemToken StartSubItem(ProtoReader reader); // 0x000000018CB608A0-0x000000018CB60900
		public int ReadFieldHeader(); // 0x000000018CB5FCF4-0x000000018CB5FD48
		private int SetTag(uint tag); // 0x000000018CB607BC-0x000000018CB6084C
		private static void ThrowInvalidField(int fieldNumber); // 0x000000018CB60950-0x000000018CB609A0
		private static void ThrowUnexpectedEndGroup(); // 0x000000018CB609A0-0x000000018CB609D4
		public bool TryReadFieldHeader(int field); // 0x000000018CB609D4-0x000000018CB60A2C
		public void Hint(WireType wireType); // 0x000000018CB5F4BC-0x000000018CB5F4D0
		public void Assert(WireType wireType); // 0x000000018CB5EF78-0x000000018CB5EFC0
		public void SkipField(); // 0x000000018CB6084C-0x000000018CB608A0
		public ulong ReadUInt64(); // 0x000000018CB604B0-0x000000018CB60504
		public float ReadSingle(); // 0x000000018CB6030C-0x000000018CB60360
		public bool ReadBoolean(); // 0x000000018CB5FB98-0x000000018CB5FBF0
		public static byte[] AppendBytes(byte[] value, ProtoReader reader); // 0x000000018CB5EEB4-0x000000018CB5EF1C
		private static int ReadByteOrThrow(Stream source); // 0x000000018CB5FBF0-0x000000018CB5FC4C
		public static int ReadLengthPrefix(Stream source, bool expectHeader, PrefixStyle style, out int fieldNumber); // 0x000000018CB5FF0C-0x000000018CB5FF98
		public static int DirectReadLittleEndianInt32(Stream source); // 0x000000018CB5F208-0x000000018CB5F29C
		public static int DirectReadBigEndianInt32(Stream source); // 0x000000018CB5F044-0x000000018CB5F0D8
		public static int DirectReadVarintInt32(Stream source); // 0x000000018CB5F364-0x000000018CB5F400
		public static void DirectReadBytes(Stream source, byte[] buffer, int offset, int count); // 0x000000018CB5F0D8-0x000000018CB5F180
		public static byte[] DirectReadBytes(Stream source, int count); // 0x000000018CB5F180-0x000000018CB5F208
		public static string DirectReadString(Stream source, int length); // 0x000000018CB5F29C-0x000000018CB5F364
		public static int ReadLengthPrefix(Stream source, bool expectHeader, PrefixStyle style, out int fieldNumber, out int bytesRead); // 0x000000018CB5FE44-0x000000018CB5FF0C
		public static long ReadLongLengthPrefix(Stream source, bool expectHeader, PrefixStyle style, out int fieldNumber, out int bytesRead); // 0x000000018CB5FF98-0x000000018CB60240
		private static void ThrowEoF(); // 0x000000018CB5FB50-0x000000018CB5FB74
		private static int TryReadUInt64Varint(Stream source, out ulong value); // 0x000000018CB60A2C-0x000000018CB60B40
		internal static void Seek(Stream source, long count, byte[] buffer); // 0x000000018CB60504-0x000000018CB607BC
		public void AppendExtensionData(IExtensible instance); // 0x000000018CB5EF1C-0x000000018CB5EF78
		public static bool HasSubValue(WireType wireType, ProtoReader source); // 0x000000018CB5F458-0x000000018CB5F4BC
		internal System.Type DeserializeType(string value); // 0x000000018CB5F038-0x000000018CB5F044
		public System.Type ReadType(); // 0x000000018CB603B4-0x000000018CB60408
		public static object Merge(ProtoReader parent, object from, object to); // 0x000000018CB5F808-0x000000018CB5FB50
		protected internal abstract State DefaultState();
		private static void NoContextThrowEoF(); // 0x000000018CB5FB50-0x000000018CB5FB74
		private static void NoContextThrowOverflow(); // 0x000000018CB5FB74-0x000000018CB5FB98
		[Obsolete("If possible, please use the State API; a transitionary implementation is provided, but this API may be removed in a future version", false)]
		public static ProtoReader Create(Stream source, TypeModel model, SerializationContext context = null, long length = -1 /* Metadata: 0x0263CE4F */); // 0x000000018CB5EFC0-0x000000018CB5F038
		internal static ProtoReader Create(Stream source, TypeModel model, object userState, long length); // 0x0000000185C16490-0x0000000185C165A0
		private static bool ReflectionTryGetBuffer(MemoryStream ms, out ArraySegment<byte> buffer); // 0x0000000185C15A10-0x0000000185C15C70
		internal static bool TryConsumeSegmentRespectingPosition(Stream source, out ArraySegment<byte> data, long length); // 0x0000000185C15C70-0x0000000185C15E90
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, AllowMultiple = true, Inherited = false)]
	public sealed class ProtoReservedAttribute : Attribute // TypeDefIndex: 80568
	{
		// Fields
		[CompilerGenerated]
		private readonly int _From_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly int _To_k__BackingField; // 0x14
		[CompilerGenerated]
		private readonly string _Name_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly string _Comment_k__BackingField; // 0x20
	
		// Properties
		public int From { [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		public int To { [CompilerGenerated] get; } // 0x0000000182971EE0-0x0000000182971EF0 
		public string Name { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
		public string Comment { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
	
		// Constructors
		public ProtoReservedAttribute(int field, string comment = null); // 0x000000018CB60CE0-0x000000018CB60D00
		public ProtoReservedAttribute(int from, int to, string comment = null); // 0x000000018CB60D28-0x000000018CB60D3C
		public ProtoReservedAttribute(string field, string comment = null); // 0x000000018CB60D00-0x000000018CB60D28
	
		// Methods
		internal void Verify(); // 0x000000018CB60BDC-0x000000018CB60CE0
	}

	public abstract class ProtoWriter : IDisposable, ISerializationContext // TypeDefIndex: 80574
	{
		// Fields
		private const MethodImplOptions HotPath = MethodImplOptions.AggressiveInlining; // Metadata: 0x0263CF50
		internal const string PreferWriteMessage = "If possible, please use the WriteMessage API; this API may not work correctly with all writers"; // Metadata: 0x0263CF52
		private TypeModel model; // 0x10
		private int packedFieldNumber; // 0x18
		private protected readonly NetObjectCache netCache; // 0x20
		private int fieldNumber; // 0x28
		[CompilerGenerated]
		private WireType _WireType_k__BackingField; // 0x2C
		private int _depth; // 0x30
		private const int RecursionCheckDepth = 25; // Metadata: 0x0263CFB2
		private List<object> recursionStack; // 0x38
		[CompilerGenerated]
		private object _UserState_k__BackingField; // 0x40
		private bool _needFlush; // 0x48
		private long _position64; // 0x50
		protected internal static readonly UTF8Encoding UTF8; // 0x00
	
		// Properties
		internal WireType WireType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
		[Obsolete("Prefer UserState")]
		public SerializationContext Context { get; } // 0x000000018CB61E2C-0x000000018CB61E78 
		public object UserState { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		internal int Depth { get; } // 0x000000018226EBA0-0x000000018226EBB0 
		public TypeModel Model { get; internal set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		private protected abstract bool ImplDemandFlushOnDispose { get; }
		[Obsolete("Please migrate to TypeModel.BufferSize")]
		public static int BufferSize { get; set; } // 0x000000018CB61E0C-0x000000018CB61E2C 0x000000018CB61E78-0x000000018CB61EA4
	
		// Nested types
		[IsByRefLike]
		[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		public struct State // TypeDefIndex: 80569
		{
			// Fields
			private Span<byte> _span; // 0x00
			private Memory<byte> _memory; // 0x10
			private ProtoWriter _writer; // 0x20
			[CompilerGenerated]
			private int _RemainingInCurrent_k__BackingField; // 0x28
			[CompilerGenerated]
			private int _OffsetInCurrent_k__BackingField; // 0x2C
	
			// Properties
			internal bool IsActive { [IsReadOnly] get; } // 0x00000001854C55C0-0x00000001854C5600 
			internal Span<byte> Remaining { [IsReadOnly] get; } // 0x000000018CB65D3C-0x000000018CB65D98 
			internal int RemainingInCurrent { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
			internal int OffsetInCurrent { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
			internal TypeModel Model { [IsReadOnly] get; } // 0x0000000185894090-0x00000001858940A0 
			internal WireType WireType { [IsReadOnly] get; [IsReadOnly] set; } // 0x0000000185C65AF0-0x0000000185C65B10 0x000000018CB65E10-0x000000018CB65E2C
			internal int Depth { [IsReadOnly] get; } // 0x000000018CB65CD8-0x000000018CB65CF4 
			internal int FieldNumber { [IsReadOnly] get; [IsReadOnly] private set; } // 0x000000018CB65CF4-0x000000018CB65D10 0x000000018CB65DB4-0x000000018CB65DD0
			public ISerializationContext Context { [IsReadOnly] get; } // 0x000000018225E800-0x000000018225E810 
	
			// Constructors
			internal State(ProtoWriter writer); // 0x0000000187254B10-0x0000000187254B30
	
			// Methods
			public static State Create(IBufferWriter<byte> writer, TypeModel model, object userState = null); // 0x0000000187839CC4-0x0000000187839D00
			internal void Init(Memory<byte> memory); // 0x00000001854C53A0-0x00000001854C5410
			public void Flush(); // 0x000000018CB63648-0x000000018CB63680
			internal int ConsiderWritten(); // 0x0000000187254A70-0x0000000187254AA0
			internal void LocalWriteFixed32(uint value); // 0x000000018CB63700-0x000000018CB63744
			[IsReadOnly]
			internal void ReverseLast32(); // 0x000000018CB6453C-0x000000018CB645B0
			internal void LocalAdvance(int bytes); // 0x0000000187254AC0-0x0000000187254AD0
			internal void LocalWriteBytes(ReadOnlySpan<byte> span); // 0x0000000185C16660-0x0000000185C166E0
			internal void LocalWriteFixed64(ulong value); // 0x000000018CB63744-0x000000018CB6378C
			internal void LocalWriteString(string value); // 0x000000018630B3D0-0x000000018630B4C0
			internal int LocalWriteVarint64(ulong value); // 0x000000018CB6378C-0x000000018CB637C0
			internal static int WriteVarint64(ulong value, Span<byte> span, int offset = 0 /* Metadata: 0x0263CFB3 */); // 0x000000018CB65C38-0x000000018CB65CA0
			internal int ReadFrom(Stream source); // 0x000000018CB63BD4-0x000000018CB63E70
			internal int LocalWriteVarint32(uint value); // 0x00000001854C4CA0-0x00000001854C4D30
			public void WriteString(int fieldNumber, string value, StringMap map = null); // 0x000000018CB65B48-0x000000018CB65B94
			private void WriteStringWithLengthPrefix(string value, StringMap map); // 0x00000001860A4B00-0x00000001860A4C10
			public void WriteString(string value, StringMap map = null); // 0x00000001860A4AD0-0x00000001860A4B00
			public void WriteType(System.Type value); // 0x000000018CB65B94-0x000000018CB65BD0
			public void WriteFieldHeader(int fieldNumber, WireType wireType); // 0x0000000184FF5690-0x0000000184FF58F0
			public void WriteInt32Varint(int fieldNumber, int value); // 0x000000018CB657B0-0x000000018CB657E4
			private void WriteInt32VarintImpl(int value); // 0x0000000184FF4850-0x0000000184FF4A80
			public void WriteInt32(int value); // 0x0000000184FF45E0-0x0000000184FF4850
			public void WriteSByte(sbyte value); // 0x000000018CB65B3C-0x000000018CB65B48
			public void WriteInt16(short value); // 0x000000018CB657A4-0x000000018CB657B0
			public void WriteUInt16(ushort value); // 0x000000018CB65BD0-0x000000018CB65BDC
			public void WriteByte(byte value); // 0x000000018CB653B0-0x000000018CB653BC
			public void WriteBoolean(bool value); // 0x0000000186349940-0x0000000186349990
			public void WriteIntPtr(IntPtr value); // 0x000000018CB657E4-0x000000018CB657F0
			public void WriteUIntPtr(UIntPtr value); // 0x000000018CB65BDC-0x000000018CB65C38
			public void WriteUInt32(uint value); // 0x0000000184FF4000-0x0000000184FF4050
			public void WriteDouble(double value); // 0x00000001861EFD10-0x00000001861EFD70
			public void WriteSingle(float value); // 0x0000000185E6B7E0-0x0000000185E6BA30
			public void WriteInt64(long value); // 0x00000001854C5480-0x00000001854C5510
			public void WriteUInt64(ulong value); // 0x00000001854C6890-0x00000001854C6AB0
			public void WriteMessage<T>(SerializerFeatures features, T value, ISerializer<T> serializer = null);
			public void WriteMessage<T>(int fieldNumber, SerializerFeatures features, T value, ISerializer<T> serializer = null);
			public void WriteGroup<T>(int fieldNumber, SerializerFeatures features, T value, ISerializer<T> serializer = null);
			public void WriteAny<T>(int fieldNumber, T value, ISerializer<T> serializer = null);
			internal static WireType AssertWrappedAndGetWireType(ref SerializerFeatures features, out bool fieldPresence); // 0x000000018CB63314-0x000000018CB63348
			public void WriteWrapped<T>(int fieldNumber, SerializerFeatures features, T value, ISerializer<T> serializer = null);
			public void WriteAny<T>(int fieldNumber, SerializerFeatures features, T value, ISerializer<T> serializer = null);
			public void WriteSubType<T>(T value, ISubTypeSerializer<T> serializer = null)
				where T : class;
			public void WriteSubType<T>(int fieldNumber, T value, ISubTypeSerializer<T> serializer = null)
				where T : class;
			public void WriteBaseType<T>([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] T value, ISubTypeSerializer<T> serializer = null)
				where T : class;
			public ISerializer<T> GetSerializer<T>();
			[IsReadOnly]
			internal long GetPosition(); // 0x0000000187836524-0x0000000187836540
			[IsReadOnly]
			internal ProtoWriter GetWriter(); // 0x000000018225E800-0x000000018225E810
			public void WriteBytes(ReadOnlySequence<byte> data); // 0x000000018CB654BC-0x000000018CB65670
			public void WriteBytes(ArraySegment<byte> data); // 0x000000018CB65670-0x000000018CB6571C
			public void WriteBytes(byte[] data); // 0x000000018CB6571C-0x000000018CB657A4
			public void WriteBytes(ProtoBytes data); // 0x000000018CB653BC-0x000000018CB65428
			public void WriteBytes<TStorage>(TStorage value, IMemoryConverter<TStorage, byte> converter = null);
			public void WriteBytes(Memory<byte> data); // 0x000000018CB65428-0x000000018CB654BC
			public void WriteBytes(ReadOnlyMemory<byte> data); // 0x00000001862AF920-0x00000001862AF990
			public void WriteBytes(ReadOnlySpan<byte> data); // 0x00000001862AF990-0x00000001862AFA50
			public long SerializeRoot<T>(T value, ISerializer<T> serializer = null);
			internal void WriteAsRoot<T>(T value, ISerializer<T> serializer);
			[IsReadOnly]
			public void Abandon(); // 0x000000018CB628C4-0x000000018CB628D4
			private void CheckClear(); // 0x00000001854C5600-0x00000001854C5700
			internal void WritePackedPrefix(int elementCount, WireType wireType); // 0x000000018CB659C8-0x000000018CB65B3C
			internal void WriteObject(object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, PrefixStyle style, int fieldNumber); // 0x000000018CB657F0-0x000000018CB659C8
			internal void WriteHeaderCore(int fieldNumber, WireType wireType); // 0x0000000184FF58F0-0x0000000184FF5AF0
			[Obsolete("If possible, please use the WriteMessage API; this API may not work correctly with all writers", false)]
			public SubItemToken StartSubItem(object instance); // 0x000000018CB64830-0x000000018CB64840
			public void Dispose(); // 0x000000018621FB30-0x000000018621FB60
			[Obsolete("If possible, please use the WriteMessage API; this API may not work correctly with all writers", false)]
			internal SubItemToken StartSubItem(object instance, PrefixStyle style); // 0x000000018CB64758-0x000000018CB64830
			[Obsolete("If possible, please use the WriteMessage API; this API may not work correctly with all writers", false)]
			internal void EndSubItem(SubItemToken token, PrefixStyle style); // 0x000000018CB6358C-0x000000018CB63638
			public void Close(); // 0x000000018CB633D8-0x000000018CB63408
			[Obsolete("If possible, please use the WriteMessage API; this API may not work correctly with all writers", false)]
			public void EndSubItem(SubItemToken token); // 0x000000018CB63638-0x000000018CB63648
			public void AppendExtensionData(IExtensible instance); // 0x0000000185C65910-0x0000000185C65AF0
			private void AppendExtensionDataImpl(IExtension extn); // 0x0000000185C65B10-0x0000000185C65D30
			public void AppendExtensionData(ITypedExtensible instance, System.Type type); // 0x000000018CB6305C-0x000000018CB630E8
			internal void ThrowInvalidSerializationOperation(); // 0x000000018CB64BE4-0x000000018CB64CEC
			[IsReadOnly]
			internal void ThrowTooDeep(int depth); // 0x000000018CB64E28-0x000000018CB64E78
			[IsReadOnly]
			public void SetPackedField(int fieldNumber); // 0x000000018CB645B0-0x000000018CB6460C
			[IsReadOnly]
			public void ClearPackedField(int fieldNumber); // 0x000000018CB633A0-0x000000018CB633D8
			public void ThrowEnumException(object enumValue); // 0x000000018CB648B4-0x000000018CB649A4
			public static State Create(Stream dest, TypeModel model, object userState = null); // 0x0000000185C17690-0x0000000185C176E0
			[CompilerGenerated]
			internal static void _WriteFieldHeader_g__FailPendingField_34_0(ProtoWriter writer, int fieldNumber, WireType wireType); // 0x000000018CB650FC-0x000000018CB65290
			[CompilerGenerated]
			internal static void _WriteFieldHeader_g__WritePackedField_34_1(ProtoWriter writer, int fieldNumber, WireType wireType); // 0x000000018CB65290-0x000000018CB653B0
			[CompilerGenerated]
			internal static WireType _AssertWrappedAndGetWireType_g__AssertWrappedAndGetWireType_54_0(ref SerializerFeatures features, SerializerFeatures demanded, SerializerFeatures group); // 0x000000018CB64F98-0x000000018CB65070
			[CompilerGenerated]
			internal static void _ClearPackedField_g__ThrowWrongPackedField_102_0(int fieldNumber, ProtoWriter writer); // 0x000000018CB65070-0x000000018CB650FC
		}
	
		private sealed class BufferWriterProtoWriter : ProtoWriter // TypeDefIndex: 80570
		{
			// Fields
			private IBufferWriter<byte> _writer; // 0x58
			private readonly NullProtoWriter _nullWriter; // 0x60
	
			// Properties
			private protected override bool ImplDemandFlushOnDispose { get; } // 0x00000001851A4410-0x00000001851A4420 
	
			// Constructors
			private BufferWriterProtoWriter(); // 0x0000000185C18720-0x0000000185C187D0
	
			// Methods
			internal static State CreateBufferWriterProtoWriter(IBufferWriter<byte> writer, TypeModel model, object userState); // 0x0000000185C17F80-0x0000000185C18200
			internal override void Init(TypeModel model, object userState, bool impactCount); // 0x0000000185C182D0-0x0000000185C18390
			private protected override void ClearKnownObjects(); // 0x0000000186805BA0-0x0000000186805BB0
			internal override void Dispose(); // 0x00000001861F4200-0x00000001861F4270
			private protected override void Cleanup(); // 0x0000000185C18200-0x0000000185C182D0
			protected internal override State DefaultState(); // 0x000000018CB6748C-0x000000018CB674D4
			private protected override bool TryFlush(ref State state); // 0x00000001854C5510-0x00000001854C55C0
			private protected override void ImplWriteFixed32(ref State state, uint value); // 0x0000000185C16B40-0x0000000185C16F90
			private protected override void ImplWriteFixed64(ref State state, ulong value); // 0x0000000185C168B0-0x0000000185C16900
			private protected override void ImplWriteString(ref State state, string value, int expectedBytes); // 0x000000018630B3A0-0x000000018630B3D0
			private void FallbackWriteString(ref State state, string value, int expectedBytes); // 0x000000018CB675CC-0x000000018CB677E8
			private void GetBuffer(ref State state); // 0x00000001854C5080-0x00000001854C5290
			private protected override void ImplWriteBytes(ref State state, ReadOnlySpan<byte> bytes); // 0x0000000185C165A0-0x0000000185C16660
			private protected override void ImplWriteBytes(ref State state, ReadOnlySequence<byte> data); // 0x000000018CB678A0-0x000000018CB67A90
			private void FallbackWriteBytes(ref State state, ReadOnlySpan<byte> span); // 0x000000018CB674D4-0x000000018CB675CC
			private protected override int ImplWriteVarint32(ref State state, uint value); // 0x00000001854C4C00-0x00000001854C4CA0
			internal override int ImplWriteVarint64(ref State state, ulong value); // 0x0000000185C984C0-0x0000000185C985C0
			protected internal override void WriteMessage<T>(ref State state, T value, ISerializer<T> serializer, PrefixStyle style, bool recursionCheck);
			internal override void WriteWrappedItem<T>(ref State state, SerializerFeatures features, T value, ISerializer<T> serializer);
			internal override void WriteWrappedCollection<TCollection, TItem>(ref State state, SerializerFeatures features, TCollection values, RepeatedSerializer<TCollection, TItem> serializer, ISerializer<TItem> valueSerializer);
			internal override void WriteWrappedMap<TCollection, TKey, TValue>(ref State state, SerializerFeatures features, TCollection values, MapSerializer<TCollection, TKey, TValue> serializer, SerializerFeatures keyFeatures, SerializerFeatures valueFeatures, ISerializer<TKey> keySerializer, ISerializer<TValue> valueSerializer);
			protected internal override void WriteSubType<T>(ref State state, T value, ISubTypeSerializer<T> serializer);
			private void WriteWithLengthPrefix<T>(ref State state, T value, ISerializer<T> serializer, PrefixStyle style);
			private void WriteWithLengthPrefix<T>(ref State state, T value, ISubTypeSerializer<T> serializer)
				where T : class;
			private protected override void ImplEndLengthPrefixedSubItem(ref State state, SubItemToken token, PrefixStyle style); // 0x000000018CB67840-0x000000018CB67870
			private protected override SubItemToken ImplStartLengthPrefixedSubItem(ref State state, object instance, PrefixStyle style); // 0x000000018CB67870-0x000000018CB678A0
			private protected override void ImplCopyRawFromStream(ref State state, Stream source); // 0x000000018CB677E8-0x000000018CB67840
			[CompilerGenerated]
			internal static void _GetBuffer_g__ThrowNoWriter_16_0(); // 0x000000018CB67A90-0x000000018CB67AEC
		}
	
		[IsReadOnly]
		internal struct WriteState // TypeDefIndex: 80571
		{
			// Fields
			internal readonly long Position; // 0x00
			internal readonly WireType WireType; // 0x08
			internal readonly int FieldNumber; // 0x0C
	
			// Constructors
			internal WriteState(long position, int fieldNumber, WireType wireType); // 0x0000000187254C30-0x0000000187254C40
		}
	
		internal sealed class NullProtoWriter : ProtoWriter // TypeDefIndex: 80572
		{
			// Fields
			private long _abortAfter; // 0x58
	
			// Properties
			private protected override bool ImplDemandFlushOnDispose { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
			// Constructors
			private NullProtoWriter(); // 0x0000000185C18890-0x0000000185C188E0
			internal NullProtoWriter(NetObjectCache knownObjects); // 0x0000000185C187D0-0x0000000185C18840
	
			// Methods
			protected internal override State DefaultState(); // 0x0000000187254B80-0x0000000187254BA0
			internal static State CreateNullProtoWriter(TypeModel model, object userState, long abortAfter); // 0x0000000185C17DF0-0x0000000185C17F10
			internal override void Dispose(); // 0x00000001861F4190-0x00000001861F4200
			private protected override void ImplCopyRawFromStream(ref State state, Stream source); // 0x000000018CB75424-0x000000018CB7557C
			internal static void CheckOversized(long max, long actual); // 0x0000000185C17F10-0x0000000185C17F80
			private void CheckOversized(ref State state); // 0x000000018CB753EC-0x000000018CB75424
			protected internal override void WriteMessage<T>(ref State state, T value, ISerializer<T> serializer, PrefixStyle style, bool recursionCheck);
			internal override void WriteWrappedItem<T>(ref State state, SerializerFeatures features, T value, ISerializer<T> serializer);
			internal override void WriteWrappedCollection<TCollection, TItem>(ref State state, SerializerFeatures features, TCollection values, RepeatedSerializer<TCollection, TItem> serializer, ISerializer<TItem> valueSerializer);
			internal override void WriteWrappedMap<TCollection, TKey, TValue>(ref State state, SerializerFeatures features, TCollection values, MapSerializer<TCollection, TKey, TValue> serializer, SerializerFeatures keyFeatures, SerializerFeatures valueFeatures, ISerializer<TKey> keySerializer, ISerializer<TValue> valueSerializer);
			private void AdvanceSubMessage(ref State state, long length, PrefixStyle style); // 0x00000001854C5DF0-0x00000001854C6060
			protected internal override void WriteSubType<T>(ref State state, T value, ISubTypeSerializer<T> serializer);
			private protected override SubItemToken ImplStartLengthPrefixedSubItem(ref State state, object instance, PrefixStyle style); // 0x0000000187254BA0-0x0000000187254BB0
			private protected override void ImplEndLengthPrefixedSubItem(ref State state, SubItemToken token, PrefixStyle style); // 0x000000018CB7557C-0x000000018CB755E8
			private protected override void ImplWriteBytes(ref State state, ReadOnlySpan<byte> data); // 0x0000000186805BA0-0x0000000186805BB0
			private protected override void ImplWriteBytes(ref State state, ReadOnlySequence<byte> data); // 0x0000000186805BA0-0x0000000186805BB0
			private protected override void ImplWriteFixed32(ref State state, uint value); // 0x0000000186805BA0-0x0000000186805BB0
			private protected override void ImplWriteFixed64(ref State state, ulong value); // 0x0000000186805BA0-0x0000000186805BB0
			private protected override void ImplWriteString(ref State state, string value, int expectedBytes); // 0x0000000186805BA0-0x0000000186805BB0
			private protected override int ImplWriteVarint32(ref State state, uint value); // 0x0000000187254BB0-0x0000000187254C10
			internal override int ImplWriteVarint64(ref State state, ulong value); // 0x0000000185FAC0E0-0x0000000185FAC170
			private protected override bool TryFlush(ref State state); // 0x00000001851A4410-0x00000001851A4420
		}
	
		private class StreamProtoWriter : ProtoWriter // TypeDefIndex: 80573
		{
			// Fields
			private Stream dest; // 0x58
			private int flushLock; // 0x60
			private byte[] ioBuffer; // 0x68
			private int ioIndex; // 0x70
	
			// Properties
			private protected override bool ImplDemandFlushOnDispose { get; } // 0x00000001851A4410-0x00000001851A4420 
	
			// Constructors
			private StreamProtoWriter(); // 0x0000000185C18570-0x0000000185C185C0
	
			// Methods
			protected internal override State DefaultState(); // 0x0000000187254B80-0x0000000187254BA0
			internal static StreamProtoWriter CreateStreamProtoWriter(Stream dest, TypeModel model, object userState); // 0x0000000185C176E0-0x0000000185C17850
			internal override void Init(TypeModel model, object userState, bool impactCount); // 0x0000000185C17B80-0x0000000185C17BB0
			internal override void Dispose(); // 0x00000001861F4120-0x00000001861F4190
			private protected override void Cleanup(); // 0x0000000185C17B10-0x0000000185C17B80
			private static void IncrementedAndReset(int length, StreamProtoWriter writer); // 0x000000018CB775E0-0x000000018CB77608
			private protected override bool TryFlush(ref State state); // 0x00000001863E0CC0-0x00000001863E0D10
			private static void DemandSpace(int required, StreamProtoWriter writer, ref State state); // 0x0000000185C16A20-0x0000000185C16A60
			private static void TryFlushOrResize(int required, StreamProtoWriter writer, ref State state); // 0x0000000185C16F90-0x0000000185C17050
			private protected override void ImplWriteBytes(ref State state, ReadOnlySpan<byte> bytes); // 0x000000018CB76FDC-0x000000018CB770E0
			private static void WriteFallback(ReadOnlySpan<byte> bytes, Stream stream); // 0x000000018CB77608-0x000000018CB77884
			private protected override void ImplWriteBytes(ref State state, ReadOnlySequence<byte> data); // 0x000000018CB770E0-0x000000018CB7754C
			private protected override void ImplWriteString(ref State state, string value, int expectedBytes); // 0x0000000185C16790-0x0000000185C168B0
			private static void WriteUInt32ToBuffer(uint value, byte[] buffer, int index); // 0x0000000185C16A60-0x0000000185C16B40
			private protected override void ImplWriteFixed32(ref State state, uint value); // 0x0000000185C16900-0x0000000185C16970
			private protected override void ImplWriteFixed64(ref State state, ulong value); // 0x000000018CB7754C-0x000000018CB775E0
			internal override int ImplWriteVarint64(ref State state, ulong value); // 0x0000000185C166E0-0x0000000185C16790
			private protected override int ImplWriteVarint32(ref State state, uint value); // 0x0000000185C16970-0x0000000185C16A20
			private protected override void ImplCopyRawFromStream(ref State state, Stream source); // 0x000000018CB76BE8-0x000000018CB76D2C
			private protected override SubItemToken ImplStartLengthPrefixedSubItem(ref State state, object instance, PrefixStyle style); // 0x000000018CB76F50-0x000000018CB76FDC
			private protected override void ImplEndLengthPrefixedSubItem(ref State state, SubItemToken token, PrefixStyle style); // 0x000000018CB76D2C-0x000000018CB76F50
		}
	
		// Constructors
		private protected ProtoWriter(); // 0x0000000185C18630-0x0000000185C186A0
		private protected ProtoWriter(NetObjectCache knownObjects); // 0x0000000187835950-0x0000000187835960
		static ProtoWriter(); // 0x0000000186496680-0x0000000186496710
	
		// Methods
		void IDisposable.Dispose(); // 0x000000018BD4B924-0x000000018BD4B934
		public static void WriteFieldHeader(int fieldNumber, WireType wireType, ProtoWriter writer); // 0x000000018CB618F8-0x000000018CB6196C
		public static void WriteBytes(byte[] data, ProtoWriter writer); // 0x000000018CB61790-0x000000018CB617F8
		public static void WriteBytes(byte[] data, int offset, int length, ProtoWriter writer); // 0x000000018CB616BC-0x000000018CB61790
		[Obsolete("If possible, please use the WriteMessage API; this API may not work correctly with all writers", false)]
		public static SubItemToken StartSubItem(object instance, ProtoWriter writer); // 0x000000018CB6152C-0x000000018CB6159C
		private void PreSubItem(ref State state, object instance); // 0x0000000185896040-0x00000001858960D0
		private void CheckRecursionStackAndPush(object instance); // 0x000000018CB60F9C-0x000000018CB611D0
		private void PopRecursionStack(); // 0x000000018CB6146C-0x000000018CB614C8
		[Obsolete("If possible, please use the WriteMessage API; this API may not work correctly with all writers", false)]
		public static void EndSubItem(SubItemToken token, ProtoWriter writer); // 0x000000018CB612E8-0x000000018CB61358
		private void PostSubItem(ref State state); // 0x0000000185895FF0-0x0000000185896040
		internal virtual void Init(TypeModel model, object userState, bool impactCount); // 0x0000000185C18390-0x0000000185C18420
		internal WriteState ResetWriteState(); // 0x0000000186202980-0x00000001862029B0
		internal void SetWriteState(WriteState state); // 0x0000000187254A20-0x0000000187254A40
		internal virtual void Dispose(); // 0x000000018783BBB0-0x000000018783BBC0
		private protected virtual void Cleanup(); // 0x0000000185C18420-0x0000000185C184C0
		private protected virtual void ClearKnownObjects(); // 0x0000000185122960-0x0000000185122A10
		protected internal virtual void WriteMessage<T>(ref State state, T value, ISerializer<T> serializer, PrefixStyle style, bool recursionCheck);
		internal virtual void WriteWrappedCollection<TCollection, TItem>(ref State state, SerializerFeatures features, TCollection values, RepeatedSerializer<TCollection, TItem> serializer, ISerializer<TItem> valueSerializer);
		internal virtual void WriteWrappedMap<TCollection, TKey, TValue>(ref State state, SerializerFeatures features, TCollection values, MapSerializer<TCollection, TKey, TValue> serializer, SerializerFeatures keyFeatures, SerializerFeatures valueFeatures, ISerializer<TKey> keySerializer, ISerializer<TValue> valueSerializer);
		internal void WriteEmptyWrappedItem(ref State state); // 0x000000018CB6186C-0x000000018CB618F8
		internal virtual void WriteWrappedItem<T>(ref State state, SerializerFeatures features, T value, ISerializer<T> serializer);
		protected internal virtual void WriteSubType<T>(ref State state, T value, ISubTypeSerializer<T> serializer)
			where T : class;
		public void Abandon(); // 0x00000001872549E0-0x00000001872549F0
		internal long GetPosition(ref State state); // 0x000000018226EBD0-0x000000018226EBE0
		private protected void Advance(long count); // 0x0000000187254A10-0x0000000187254A20
		internal void AdvanceAndReset(int count); // 0x00000001872549F0-0x0000000187254A00
		internal void AdvanceAndReset(long count); // 0x0000000187254A00-0x0000000187254A10
		public void Close(); // 0x000000018CB61228-0x000000018CB6127C
		internal void CheckClear(ref State state); // 0x000000018CB60DA8-0x000000018CB60F9C
		internal static uint Zig(int value); // 0x0000000187254A50-0x0000000187254A60
		internal static ulong Zig(long value); // 0x0000000187254A40-0x0000000187254A50
		public static void WriteString(string value, ProtoWriter writer); // 0x000000018CB61BF8-0x000000018CB61C64
		private protected abstract void ImplWriteString(ref State state, string value, int expectedBytes);
		private protected abstract int ImplWriteVarint32(ref State state, uint value);
		internal abstract int ImplWriteVarint64(ref State state, ulong value);
		private protected abstract void ImplWriteFixed32(ref State state, uint value);
		private protected abstract void ImplWriteFixed64(ref State state, ulong value);
		private protected abstract void ImplWriteBytes(ref State state, ReadOnlySpan<byte> data);
		private protected abstract void ImplWriteBytes(ref State state, ReadOnlySequence<byte> data);
		private protected abstract void ImplCopyRawFromStream(ref State state, Stream source);
		private protected abstract SubItemToken ImplStartLengthPrefixedSubItem(ref State state, object instance, PrefixStyle style);
		private protected abstract void ImplEndLengthPrefixedSubItem(ref State state, SubItemToken token, PrefixStyle style);
		private protected abstract bool TryFlush(ref State state);
		public static void WriteUInt64(ulong value, ProtoWriter writer); // 0x000000018CB61DA0-0x000000018CB61E0C
		public static void WriteInt64(long value, ProtoWriter writer); // 0x000000018CB61A3C-0x000000018CB61AA8
		public static void WriteUInt32(uint value, ProtoWriter writer); // 0x000000018CB61D38-0x000000018CB61DA0
		public static void WriteInt16(short value, ProtoWriter writer); // 0x000000018CB6196C-0x000000018CB619D4
		public static void WriteUInt16(ushort value, ProtoWriter writer); // 0x000000018CB61CD0-0x000000018CB61D38
		public static void WriteByte(byte value, ProtoWriter writer); // 0x000000018CB61654-0x000000018CB616BC
		public static void WriteSByte(sbyte value, ProtoWriter writer); // 0x000000018CB61B1C-0x000000018CB61B84
		public static void WriteInt32(int value, ProtoWriter writer); // 0x000000018CB619D4-0x000000018CB61A3C
		public static void WriteDouble(double value, ProtoWriter writer); // 0x000000018CB617F8-0x000000018CB6186C
		public static void WriteSingle(float value, ProtoWriter writer); // 0x000000018CB61B84-0x000000018CB61BF8
		public static void ThrowEnumException(ProtoWriter writer, object enumValue); // 0x000000018CB6159C-0x000000018CB615EC
		public static void WriteBoolean(bool value, ProtoWriter writer); // 0x000000018CB615EC-0x000000018CB61654
		public static void AppendExtensionData(IExtensible instance, ProtoWriter writer); // 0x000000018CB60D3C-0x000000018CB60DA8
		public static void SetPackedField(int fieldNumber, ProtoWriter writer); // 0x000000018CB614D4-0x000000018CB6152C
		public static void ClearPackedField(int fieldNumber, ProtoWriter writer); // 0x000000018CB611D0-0x000000018CB61228
		public static void WritePackedPrefix(int elementCount, WireType wireType, ProtoWriter writer); // 0x000000018CB61AA8-0x000000018CB61B1C
		internal string SerializeType(System.Type type); // 0x000000018CB614C8-0x000000018CB614D4
		public static void WriteType(System.Type value, ProtoWriter writer); // 0x000000018CB61C64-0x000000018CB61CD0
		internal static long MeasureRepeated<TCollection, TItem>(NullProtoWriter writer, int fieldNumber, SerializerFeatures features, TCollection values, RepeatedSerializer<TCollection, TItem> serializer, ISerializer<TItem> valueSerializer);
		internal static long MeasureMap<TCollection, TKey, TValue>(NullProtoWriter writer, int fieldNumber, SerializerFeatures features, TCollection values, MapSerializer<TCollection, TKey, TValue> serializer, SerializerFeatures keyFeatures, SerializerFeatures valueFeatures, ISerializer<TKey> keySerializer, ISerializer<TValue> valueSerializer);
		internal static long MeasureAny<T>(NullProtoWriter writer, int fieldNumber, SerializerFeatures features, T value, ISerializer<T> serializer);
		internal static long Measure<T>(NullProtoWriter writer, T value, ISerializer<T> serializer);
		internal static long Measure<T>(NullProtoWriter writer, T value, ISubTypeSerializer<T> serializer)
			where T : class;
		internal static State CreateNull(TypeModel model, object userState, long abortAfter); // 0x000000018CB612A4-0x000000018CB612E0
		internal static int MeasureInt32(int value); // 0x000000018CB6139C-0x000000018CB613E8
		internal static int MeasureUInt32(uint value); // 0x000000018CB61438-0x000000018CB61450
		internal static int MeasureInt64(long value); // 0x000000018CB613E8-0x000000018CB61438
		internal static int MeasureUInt64(ulong value); // 0x000000018CB61450-0x000000018CB6146C
		protected internal abstract State DefaultState();
		internal void InitializeFrom(ProtoWriter writer); // 0x000000018CB61374-0x000000018CB6139C
		internal void CopyBack(ProtoWriter writer); // 0x000000018CB6127C-0x000000018CB612A4
		internal int GetLengthHits(out int misses); // 0x000000018CB61358-0x000000018CB61374
		[Obsolete("If possible, please use the State API; a transitionary implementation is provided, but this API may be removed in a future version", false)]
		public static ProtoWriter Create(Stream dest, TypeModel model, SerializationContext context = null); // 0x000000018CB612E0-0x000000018CB612E8
	}

	public sealed class SerializationContext // TypeDefIndex: 80575
	{
		// Fields
		private bool frozen; // 0x10
		private object context; // 0x18
		[CompilerGenerated]
		private static readonly SerializationContext _Default_k__BackingField; // 0x00
		private StreamingContextStates state; // 0x20
	
		// Properties
		public object Context { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018CB75EF4-0x000000018CB75F2C
		internal static SerializationContext Default { [CompilerGenerated] get; } // 0x000000018CB75DEC-0x000000018CB75E3C 
		public StreamingContextStates State { get; set; } // 0x000000018226A850-0x000000018226A860 0x000000018CB75F2C-0x000000018CB75F58
	
		// Constructors
		public SerializationContext(); // 0x0000000187254C10-0x0000000187254C20
		static SerializationContext(); // 0x000000018CB75D7C-0x000000018CB75DEC
	
		// Methods
		internal void Freeze(); // 0x00000001829D07F0-0x00000001829D0800
		private void ThrowIfFrozen(); // 0x000000018CB75D38-0x000000018CB75D7C
		public static implicit operator StreamingContext(SerializationContext ctx); // 0x000000018CB75E3C-0x000000018CB75E80
		public static implicit operator SerializationContext(StreamingContext ctx); // 0x000000018CB75E80-0x000000018CB75EF4
		public static StreamingContext AsStreamingContext(ISerializationContext context); // 0x000000018CB75CB8-0x000000018CB75D38
		public static SerializationContext AsSerializationContext(ISerializationContext context); // 0x000000018CB75BF4-0x000000018CB75CB8
	}

	public sealed class StringMap // TypeDefIndex: 80576
	{
		// Constructors
		public StringMap(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[IsReadOnly]
	public struct SubItemToken // TypeDefIndex: 80577
	{
		// Fields
		internal readonly long value64; // 0x00
	
		// Constructors
		internal SubItemToken(long value); // 0x000000018561B5B0-0x000000018561B5C0
	
		// Methods
		public override string ToString(); // 0x000000018CB77A28-0x000000018CB77ACC
		public override int GetHashCode(); // 0x0000000187252ED0-0x0000000187252EE0
		public override bool Equals(object obj); // 0x000000018CB779C8-0x000000018CB77A28
	}

	public static class TypedExtensible // TypeDefIndex: 80578
	{
		// Methods
		private static IExtension GetExtension(ITypedExtensible instance, System.Type type, bool createIfMissing, ref TypeModel model); // 0x000000018CB7BCC4-0x000000018CB7BF68
	
		// Extension methods
		public static bool TryGetValue<TValue>(this ITypedExtensible instance, int tag, out ref TValue value, System.Type type = null, ProtoBuf.DataFormat format = ProtoBuf.DataFormat.Default /* Metadata: 0x0263CFB4 */, TypeModel model = null);
		public static TValue GetValue<TValue>(this ITypedExtensible instance, int tag, System.Type type = null, ProtoBuf.DataFormat format = ProtoBuf.DataFormat.Default /* Metadata: 0x0263CFB5 */, TypeModel model = null);
		public static IEnumerable<TValue> GetValues<TValue>(this ITypedExtensible instance, int tag, System.Type type = null, ProtoBuf.DataFormat format = ProtoBuf.DataFormat.Default /* Metadata: 0x0263CFB6 */, TypeModel model = null);
		public static void AppendValue<TValue>(this ITypedExtensible instance, int tag, TValue value, System.Type type = null, ProtoBuf.DataFormat format = ProtoBuf.DataFormat.Default /* Metadata: 0x0263CFB7 */, TypeModel model = null);
	}

	public delegate System.Type TypeResolver(int fieldNumber); // TypeDefIndex: 80579; 0x0000000185B78EA0-0x0000000185B78EB0

	public enum WireType // TypeDefIndex: 80580
	{
		None = -1,
		Variant = 0,
		Varint = 0,
		Fixed64 = 1,
		String = 2,
		StartGroup = 3,
		EndGroup = 4,
		Fixed32 = 5,
		SignedVariant = 8,
		SignedVarint = 8
	}

	public static class ProtoBufNetCompat // TypeDefIndex: 80581
	{
		// Methods
		public static byte[] BytesCopyFrom(byte[] bs); // 0x000000018CB755F0-0x000000018CB75614
		public static byte[] BytesCopyFrom(byte[] bs, int start, int length); // 0x000000018CB75614-0x000000018CB75740
		public static byte[] ByteCopyFrom(byte[] bs, int start, int length); // 0x000000018CB755E8-0x000000018CB755F0
	
		// Extension methods
		public static void MergeFrom<T>(this T msg, byte[] buffer)
			where T : class, IExtensible;
		public static void MergeFrom<T>(this T msg, byte[] buffer, int offset, int length)
			where T : class, IExtensible;
		public static void MergeFrom<T>(this T msg, ReadOnlySpan<byte> source)
			where T : class, IExtensible;
		public static void MergeFrom<T>(this T msg, Span<byte> source)
			where T : class, IExtensible;
		public static byte[] ToByteArray<T>(this T msg)
			where T : class, IExtensible;
		public static int WriteToByteArray<T>(this T msg, byte[] buffer, int offset)
			where T : class, IExtensible;
		public static void WriteTo<T>(this T msg, Stream output)
			where T : class, IExtensible;
		public static int CalculateSize<T>(this T msg)
			where T : class, IExtensible;
		public static T DeepClone<T>(this T msg)
			where T : class, IExtensible;
	}

	public static class Serializer // TypeDefIndex: 80585
	{
		// Fields
		private const string ProtoBinaryField = "proto"; // Metadata: 0x0263CFDA
		public const int ListItemTag = 1; // Metadata: 0x0263CFE0
	
		// Nested types
		public static class NonGeneric // TypeDefIndex: 80582
		{
			// Methods
			public static object DeepClone(object instance); // 0x000000018CB74F2C-0x000000018CB74F90
			public static void Serialize(Stream dest, object instance); // 0x0000000185C17540-0x0000000185C17690
			public static object Deserialize([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, Stream source); // 0x000000018CB750D0-0x000000018CB75154
			public static object Deserialize([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, Stream source, object instance = null, object userState = null, long length = -1 /* Metadata: 0x0263CFE1 */); // 0x000000018CB75154-0x000000018CB751EC
			public static object Deserialize([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, ReadOnlyMemory<byte> source, object instance = null, object userState = null); // 0x000000018CB75034-0x000000018CB750D0
			public static object Deserialize([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, ReadOnlySequence<byte> source, object instance = null, object userState = null); // 0x000000018CB74F90-0x000000018CB75034
			public static object Deserialize([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, ReadOnlySpan<byte> source, object instance = null, object userState = null); // 0x00000001851204A0-0x0000000185120550
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public static object Merge(Stream source, object instance); // 0x0000000185C16230-0x0000000185C163E0
			public static void SerializeWithLengthPrefix(Stream destination, object instance, PrefixStyle style, int fieldNumber); // 0x000000018CB75244-0x000000018CB75340
			public static bool TryDeserializeWithLengthPrefix(Stream source, PrefixStyle style, ProtoBuf.TypeResolver resolver, out object value); // 0x000000018CB75340-0x000000018CB753EC
			public static bool CanSerialize(System.Type type); // 0x000000018CB74ED0-0x000000018CB74F2C
			public static void PrepareSerializer([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type); // 0x000000018CB751EC-0x000000018CB75244
		}
	
		public static class GlobalOptions // TypeDefIndex: 80583
		{
			// Fields
			private static ProtoSyntax _defaultSyntax; // 0x00
	
			// Properties
			[Obsolete("Please use RuntimeTypeModel.Default.InferTagFromNameDefault instead (or on a per-model basis)", false)]
			public static bool InferTagFromName { get; set; } // 0x000000018CB6E4F0-0x000000018CB6E540 0x000000018CB6E5A8-0x000000018CB6E5FC
			public static ProtoSyntax DefaultSyntax { get; set; } // 0x000000018CB6E4A0-0x000000018CB6E4F0 0x000000018CB6E540-0x000000018CB6E5A8
	
			// Constructors
			static GlobalOptions(); // 0x000000018CB6E464-0x000000018CB6E4A0
	
			// Methods
			internal static ProtoSyntax Normalize(ProtoSyntax syntax); // 0x000000018CB6E3DC-0x000000018CB6E464
		}
	
		[Obsolete("Please use ProtoBuf.TypeResolver", true)]
		public delegate System.Type TypeResolver(int fieldNumber); // TypeDefIndex: 80584; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Methods
		public static string GetProto<T>();
		public static string GetProto<T>(ProtoSyntax syntax);
		public static string GetProto(SchemaGenerationOptions options); // 0x000000018CB76320-0x000000018CB76374
		public static T DeepClone<T>(T instance, SerializationContext context);
		public static T DeepClone<T>(T instance, object userState = null);
		public static MeasureState<T> Measure<T>(T value, object userState = null, long abortAfter = -1 /* Metadata: 0x0263CFC2 */);
		public static T Merge<T>(Stream source, T instance);
		public static TTo ChangeType<TFrom, TTo>(TFrom instance);
		public static void Merge<T>(XmlReader reader, T instance)
			where T : IXmlSerializable;
		public static void Merge<T>(SerializationInfo info, T instance)
			where T : class, ISerializable;
		public static void Merge<T>(SerializationInfo info, StreamingContext context, T instance)
			where T : class, ISerializable;
		public static void PrepareSerializer<T>();
		public static IFormatter CreateFormatter<T>();
		public static IEnumerable<T> DeserializeItems<T>(Stream source, PrefixStyle style, int fieldNumber);
		public static T DeserializeWithLengthPrefix<T>(Stream source, PrefixStyle style);
		public static T DeserializeWithLengthPrefix<T>(Stream source, PrefixStyle style, int fieldNumber);
		public static T MergeWithLengthPrefix<T>(Stream source, T instance, PrefixStyle style);
		public static bool TryReadLengthPrefix(Stream source, PrefixStyle style, out int length); // 0x000000018CB76374-0x000000018CB76404
		public static bool TryReadLengthPrefix(byte[] buffer, int index, int count, PrefixStyle style, out int length); // 0x000000018CB76404-0x000000018CB76530
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API is no longer required and may be removed in a future release")]
		public static void FlushPool(); // 0x0000000186805BA0-0x0000000186805BB0
		public static T Deserialize<T>(Stream source);
		public static T Deserialize<T>(Stream source, T value, SerializationContext context, long length = -1 /* Metadata: 0x0263CFCA */);
		public static T Deserialize<T>(Stream source, T value = default, object userState = null, long length = -1 /* Metadata: 0x0263CFD2 */);
		public static object Deserialize([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, Stream source); // 0x000000018CB761E8-0x000000018CB76320
		public static T Deserialize<T>(ReadOnlyMemory<byte> source, T value = default, object userState = null);
		public static T Deserialize<T>(ReadOnlySequence<byte> source, T value = default, object userState = null);
		public static T Deserialize<T>(ReadOnlySpan<byte> source, T value = default, object userState = null);
		public static void Serialize<T>(Stream destination, T instance);
		public static void Serialize<T>(Stream destination, T instance, object userState);
		public static void Serialize<T>(IBufferWriter<byte> destination, T instance, object userState = null);
		public static void Serialize<T>(SerializationInfo info, T instance)
			where T : class, ISerializable;
		public static void Serialize<T>(SerializationInfo info, StreamingContext context, T instance)
			where T : class, ISerializable;
		public static void Serialize<T>(XmlWriter writer, T instance)
			where T : IXmlSerializable;
		public static void SerializeWithLengthPrefix<T>(Stream destination, T instance, PrefixStyle style);
		public static void SerializeWithLengthPrefix<T>(Stream destination, T instance, PrefixStyle style, int fieldNumber);
	}
}

namespace ProtoBuf.Compiler
{
	[IsReadOnly]
	internal struct CodeLabel // TypeDefIndex: 80587
	{
		// Fields
		public readonly Label Value; // 0x00
		public readonly int Index; // 0x04
	
		// Constructors
		public CodeLabel(Label value, int index); // 0x00000001827241A0-0x00000001827241B0
	}

	internal sealed class CompilerContext : IDisposable // TypeDefIndex: 80593
	{
		// Fields
		[CompilerGenerated]
		private readonly TypeModel _Model_k__BackingField; // 0x10
		private readonly DynamicMethod method; // 0x18
		private static int next; // 0x00
		private static readonly MethodInfo s_CreateInstance; // 0x08
		[CompilerGenerated]
		private readonly bool _NonPublic_k__BackingField; // 0x20
		[CompilerGenerated]
		private readonly Local _InputValue_k__BackingField; // 0x28
		[CompilerGenerated]
		private readonly bool _IsStatic_k__BackingField; // 0x30
		private readonly string _traceName; // 0x38
		private readonly OpCode _state; // 0x40
		private readonly byte _inputArg; // 0x48
		private readonly SignatureType _signature; // 0x4C
		[CompilerGenerated]
		private readonly CompilerContextScope _Scope_k__BackingField; // 0x50
		private static readonly MethodInfo s_GetInbuiltSerializer; // 0x10
		private readonly ILGenerator il; // 0x58
		private readonly List<LocalBuilder> locals; // 0x60
		private int nextLabel; // 0x68
		private List<Assembly> knownTrustedAssemblies; // 0x70
		private List<Assembly> knownUntrustedAssemblies; // 0x78
	
		// Properties
		public TypeModel Model { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		internal bool NonPublic { [CompilerGenerated] get; } // 0x0000000182246E50-0x0000000182246E60 
		public Local InputValue { [CompilerGenerated] get; } // 0x0000000182262130-0x0000000182262140 
		public bool IsStatic { [CompilerGenerated] get; } // 0x00000001822434B0-0x00000001822434C0 
		internal CompilerContextScope Scope { [CompilerGenerated] get; } // 0x000000018226EBD0-0x000000018226EBE0 
		public bool IsService { get; } // 0x000000018CB6D718-0x000000018CB6D744 
		internal ILGenerator IL { get; } // 0x0000000187232F70-0x0000000187232F80 
	
		// Nested types
		internal enum SignatureType // TypeDefIndex: 80588
		{
			WriterScope_Input = 0,
			ReaderScope_Input = 1,
			Context = 2
		}
	
		internal static class StateBasedReadMethods // TypeDefIndex: 80589
		{
			// Fields
			internal static readonly System.Type ByRefStateType; // 0x00
			private static readonly Hashtable s_perTypeCache; // 0x08
	
			// Constructors
			static StateBasedReadMethods(); // 0x000000018CB76AFC-0x000000018CB76BE8
	
			// Methods
			private static Dictionary<string, MethodInfo> CreateAndAdd(System.Type parentType); // 0x000000018CB766A4-0x000000018CB76A24
			internal static bool Find(System.Type parentType, string methodName, out MethodInfo method); // 0x000000018CB76A24-0x000000018CB76AFC
		}
	
		private sealed class UsingBlock : IDisposable // TypeDefIndex: 80590
		{
			// Fields
			private Local local; // 0x10
			private CompilerContext ctx; // 0x18
			private CodeLabel label; // 0x20
	
			// Constructors
			public UsingBlock(CompilerContext ctx, Local local); // 0x000000018CB7D690-0x000000018CB7D834
	
			// Methods
			public void Dispose(); // 0x000000018CB7D610-0x000000018CB7D690
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0 // TypeDefIndex: 80591
		{
			// Fields
			public string methodName; // 0x10
			public System.Type argType; // 0x18
	
			// Constructors
			public __c__DisplayClass65_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _EmitStateBasedWrite_b__0(MethodInfo method); // 0x000000018CB7D410-0x000000018CB7D4C8
			internal bool _EmitStateBasedWrite_b__4(__f__AnonymousType1<__f__AnonymousType0<MethodInfo, ParameterInfo[]>, System.Type> __h__TransparentIdentifier1); // 0x000000018CB7D4C8-0x000000018CB7D548
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80592
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MethodInfo, __f__AnonymousType0<MethodInfo, ParameterInfo[]>> __9__65_1; // 0x08
			public static Func<__f__AnonymousType0<MethodInfo, ParameterInfo[]>, bool> __9__65_2; // 0x10
			public static Func<__f__AnonymousType0<MethodInfo, ParameterInfo[]>, __f__AnonymousType1<__f__AnonymousType0<MethodInfo, ParameterInfo[]>, System.Type>> __9__65_3; // 0x18
			public static Func<__f__AnonymousType1<__f__AnonymousType0<MethodInfo, ParameterInfo[]>, System.Type>, __f__AnonymousType2<MethodInfo, System.Type>> __9__65_5; // 0x20
	
			// Constructors
			static __c(); // 0x000000018CB7D5AC-0x000000018CB7D610
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal __f__AnonymousType0<MethodInfo, ParameterInfo[]> _EmitStateBasedWrite_b__65_1(MethodInfo method); // 0x000000018CB7BF68-0x000000018CB7BFFC
			internal bool _EmitStateBasedWrite_b__65_2(__f__AnonymousType0<MethodInfo, ParameterInfo[]> __h__TransparentIdentifier0); // 0x000000018CB7BFFC-0x000000018CB7C0FC
			internal __f__AnonymousType1<__f__AnonymousType0<MethodInfo, ParameterInfo[]>, System.Type> _EmitStateBasedWrite_b__65_3(__f__AnonymousType0<MethodInfo, ParameterInfo[]> __h__TransparentIdentifier0); // 0x000000018CB7C0FC-0x000000018CB7C1CC
			internal __f__AnonymousType2<MethodInfo, System.Type> _EmitStateBasedWrite_b__65_5(__f__AnonymousType1<__f__AnonymousType0<MethodInfo, ParameterInfo[]>, System.Type> __h__TransparentIdentifier1); // 0x000000018CB7C1CC-0x000000018CB7C284
		}
	
		// Constructors
		internal CompilerContext(CompilerContext parent, ILGenerator il, bool isStatic, SignatureType signature, System.Type inputType, string traceName); // 0x000000018CB6D130-0x000000018CB6D184
		internal CompilerContext(CompilerContextScope scope, ILGenerator il, bool isStatic, SignatureType signature, TypeModel model, System.Type inputType, string traceName); // 0x000000018CB6D4FC-0x000000018CB6D718
		private CompilerContext(CompilerContextScope scope, System.Type associatedType, SignatureType signature, bool isStatic, TypeModel model, System.Type inputType, System.Type returnType); // 0x000000018CB6D184-0x000000018CB6D4FC
		static CompilerContext(); // 0x000000018CB6D010-0x000000018CB6D130
	
		// Methods
		internal CodeLabel DefineLabel(); // 0x000000018CB696C4-0x000000018CB696E0
		[Conditional("DEBUG_COMPILE")]
		private void TraceCompile(string value); // 0x0000000186805BA0-0x0000000186805BB0
		internal void MarkLabel(CodeLabel label); // 0x000000018CB6C31C-0x000000018CB6C338
		public static ProtoSerializer<TActual> BuildSerializer<TActual>(CompilerContextScope scope, IRuntimeProtoSerializerNode head, TypeModel model);
		public static ProtoSubTypeDeserializer<T> BuildSubTypeDeserializer<T>(CompilerContextScope scope, IRuntimeProtoSerializerNode head, TypeModel model)
			where T : class;
		public static ProtoDeserializer<T> BuildDeserializer<T>(CompilerContextScope scope, IRuntimeProtoSerializerNode head, TypeModel model, bool isScalar = false /* Metadata: 0x0263CFEB */);
		public static Func<ISerializationContext, T> BuildFactory<T>(CompilerContextScope scope, IRuntimeProtoSerializerNode head, TypeModel model);
		internal void CreateInstance<T>();
		internal void Return(); // 0x000000018CB6C6DC-0x000000018CB6C730
		private static bool IsObject(System.Type type); // 0x000000018CB6AC6C-0x000000018CB6ACD0
		internal void CastToObject(System.Type type); // 0x000000018CB68904-0x000000018CB68A2C
		internal void CastFromObject(System.Type type); // 0x000000018CB68820-0x000000018CB68904
		internal void ThrowException(System.Type exceptionType); // 0x000000018CB6CCDC-0x000000018CB6CCF8
		public override string ToString(); // 0x0000000182986470-0x0000000182986480
		private static void GetOpCodes(SignatureType signature, bool isStatic, out OpCode state, out byte inputArg); // 0x000000018CB6A894-0x000000018CB6A924
		public void LoadSelfAsService<TService, T>(CompatibilityLevel compatibilityLevel, ProtoBuf.DataFormat dataFormat)
			where TService : class;
		internal void Emit(OpCode opcode); // 0x000000018CB6A5D4-0x000000018CB6A5F0
		public void LoadValue(string value); // 0x000000018CB6B414-0x000000018CB6B490
		public void LoadValue(float value); // 0x000000018CB6B794-0x000000018CB6B800
		public void LoadValue(double value); // 0x000000018CB6B334-0x000000018CB6B3A0
		public void LoadValue(ulong value); // 0x000000018CB6B324-0x000000018CB6B334
		public void LoadValue(long value); // 0x000000018CB6BBE4-0x000000018CB6BC50
		public void LoadValue(bool value); // 0x000000018CB6B3A0-0x000000018CB6B414
		public void LoadValue(int value); // 0x000000018CB6B890-0x000000018CB6BB58
		void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		internal LocalBuilder GetFromPool(System.Type type); // 0x000000018CB6A68C-0x000000018CB6A78C
		internal void ReleaseToPool(LocalBuilder value); // 0x000000018CB6C5FC-0x000000018CB6C6DC
		public void LoadState(); // 0x000000018CB6B310-0x000000018CB6B324
		public void StoreValue(Local local); // 0x000000018CB6C854-0x000000018CB6CA58
		public void LoadValue(Local local); // 0x000000018CB6B4D4-0x000000018CB6B794
		public Local GetLocalWithValue(System.Type type, Local fromValue); // 0x000000018CB6A78C-0x000000018CB6A894
		internal void EmitStateBasedRead(string methodName, System.Type expectedType); // 0x000000018CB69B30-0x000000018CB69BB0
		internal void EmitStateBasedRead(System.Type ownerType, string methodName, System.Type expectedType); // 0x000000018CB69BB0-0x000000018CB69E38
		internal void EmitStateBasedWrite(string methodName, Local fromValue, System.Type type = null, System.Type argType = null); // 0x000000018CB69E38-0x000000018CB6A5D4
		public void EmitCall(MethodInfo method); // 0x000000018CB69734-0x000000018CB69744
		public void EmitCall(MethodInfo method, System.Type targetType); // 0x000000018CB69744-0x000000018CB698CC
		public void LoadNullRef(); // 0x000000018CB6B204-0x000000018CB6B258
		internal void WriteNullCheckedTail(System.Type type, IRuntimeProtoSerializerNode tail, Local valueFrom); // 0x000000018CB6CE00-0x000000018CB6D010
		internal void ReadNullCheckedTail(System.Type type, IRuntimeProtoSerializerNode tail, Local valueFrom); // 0x000000018CB6C338-0x000000018CB6C5FC
		public void EmitCtor(System.Type type); // 0x000000018CB698CC-0x000000018CB69928
		public void EmitCtor(ConstructorInfo ctor); // 0x000000018CB69A5C-0x000000018CB69B30
		public void InitLocal(System.Type type, Local target); // 0x000000018CB6A924-0x000000018CB6A9B4
		public void EmitCtor(System.Type type, params System.Type[] parameterTypes); // 0x000000018CB69928-0x000000018CB69A5C
		private bool InternalsVisible(Assembly assembly); // 0x000000018CB6A9B4-0x000000018CB6AC6C
		internal void CheckAccessibility(ref MemberInfo member); // 0x000000018CB68A98-0x000000018CB69170
		public void LoadValue(System.Reflection.FieldInfo field, bool checkAccessibility = true /* Metadata: 0x0263CFEC */); // 0x000000018CB6BDA0-0x000000018CB6BE90
		public void StoreValue(System.Reflection.FieldInfo field); // 0x000000018CB6C774-0x000000018CB6C854
		public void LoadValue(PropertyInfo property); // 0x000000018CB6B490-0x000000018CB6B4D4
		public void StoreValue(PropertyInfo property); // 0x000000018CB6C730-0x000000018CB6C774
		internal static void LoadValue(ILGenerator il, int value); // 0x000000018CB6BE90-0x000000018CB6C1A4
		private static bool UseShortForm(Local local); // 0x000000018CB6CD64-0x000000018CB6CD90
		internal void LoadAddress(Local local, System.Type type, bool evenIfClass = false /* Metadata: 0x0263CFED */); // 0x000000018CB6ACD0-0x000000018CB6AE6C
		internal void Branch(CodeLabel label, bool @short); // 0x000000018CB687A0-0x000000018CB68820
		internal void BranchIfFalse(CodeLabel label, bool @short); // 0x000000018CB685A0-0x000000018CB68620
		internal void BranchIfTrue(CodeLabel label, bool @short); // 0x000000018CB68720-0x000000018CB687A0
		internal void BranchIfEqual(CodeLabel label, bool @short); // 0x000000018CB68520-0x000000018CB685A0
		internal void CopyValue(); // 0x000000018CB695EC-0x000000018CB69640
		internal void BranchIfGreater(CodeLabel label, bool @short); // 0x000000018CB68620-0x000000018CB686A0
		internal void BranchIfLess(CodeLabel label, bool @short); // 0x000000018CB686A0-0x000000018CB68720
		internal void DiscardValue(); // 0x000000018CB696E0-0x000000018CB69734
		public void Subtract(); // 0x000000018CB6CA58-0x000000018CB6CAAC
		public void Switch(CodeLabel[] jumpTable); // 0x000000018CB6CAAC-0x000000018CB6CCDC
		internal void EndFinally(); // 0x000000018CB6A5F0-0x000000018CB6A60C
		internal void BeginFinally(); // 0x000000018CB684E8-0x000000018CB68504
		internal void EndTry(CodeLabel label, bool @short); // 0x000000018CB6A60C-0x000000018CB6A68C
		internal CodeLabel BeginTry(); // 0x000000018CB68504-0x000000018CB68520
		internal void Constrain(System.Type type); // 0x000000018CB69170-0x000000018CB691DC
		internal void TryCast(System.Type type); // 0x000000018CB6CCF8-0x000000018CB6CD64
		internal void Cast(System.Type type); // 0x000000018CB68A2C-0x000000018CB68A98
		public IDisposable Using(Local local); // 0x000000018CB6CD90-0x000000018CB6CE00
		internal void Add(); // 0x000000018CB68440-0x000000018CB68494
		internal void LoadLength(Local arr, bool zeroIfNull); // 0x000000018CB6B188-0x000000018CB6B204
		internal void CreateArray(System.Type elementType, Local length); // 0x000000018CB69640-0x000000018CB696C4
		internal void LoadArrayValue(Local arr, Local i); // 0x000000018CB6AE6C-0x000000018CB6B188
		internal static void LoadValue(ILGenerator il, System.Type type); // 0x000000018CB6BB58-0x000000018CB6BBE4
		internal void LoadValue(System.Type type); // 0x000000018CB6B800-0x000000018CB6B890
		internal void ConvertToInt32(ProtoTypeCode typeCode, bool uint32Overflow); // 0x000000018CB693F8-0x000000018CB695EC
		internal void ConvertFromInt32(ProtoTypeCode typeCode, bool uint32Overflow); // 0x000000018CB691DC-0x000000018CB693F8
		internal void LoadValue(decimal value); // 0x000000018CB6BC50-0x000000018CB6BDA0
		internal void LoadValue(Guid value); // 0x000000018CB6C1A4-0x000000018CB6C31C
		internal void LoadSerializationContext(System.Type asType); // 0x000000018CB6B258-0x000000018CB6B310
		internal bool AllowInternal(PropertyInfo property); // 0x000000018CB68494-0x000000018CB684E8
	}

	internal sealed class CompilerContextScope // TypeDefIndex: 80596
	{
		// Fields
		[CompilerGenerated]
		private readonly string _AssemblyName_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly bool _IsFullEmit_k__BackingField; // 0x18
		private ModuleBuilder _module; // 0x20
		private readonly RuntimeTypeModel _model; // 0x28
		private int _localUniqueId; // 0x30
		private static int s_globalUniqueId; // 0x00
	
		// Properties
		internal string AssemblyName { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		public bool IsFullEmit { [CompilerGenerated] get; } // 0x000000018225E050-0x000000018225E060 
	
		// Nested types
		private static class SharedModule // TypeDefIndex: 80594
		{
			// Fields
			internal static readonly ModuleBuilder Shared; // 0x00
	
			// Constructors
			static SharedModule(); // 0x000000018CB7662C-0x000000018CB766A4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80595
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<ParameterInfo, System.Type> __9__14_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB7D548-0x000000018CB7D5AC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal System.Type _Implement_b__14_0(ParameterInfo x); // 0x0000000188E4BE2C-0x0000000188E4BE44
		}
	
		// Constructors
		private CompilerContextScope(RuntimeTypeModel model, ModuleBuilder module, bool isFullEmit, string assemblyName); // 0x0000000186BF8150-0x0000000186BF8190
	
		// Methods
		internal static CompilerContextScope CreateInProcess(); // 0x0000000186BF8060-0x0000000186BF80D0
		internal static CompilerContextScope CreateForModule(RuntimeTypeModel model, ModuleBuilder module, bool isFullEmit, string assemblyName); // 0x000000018CB68074-0x000000018CB6810C
		private ModuleBuilder GetModule(); // 0x000000018CB6810C-0x000000018CB68140
		private static ModuleBuilder GetSharedModule(); // 0x000000018CB68140-0x000000018CB68190
		internal static ILGenerator Implement(TypeBuilder type, System.Type interfaceType, string name, bool @explicit = true /* Metadata: 0x0263CFF1 */); // 0x000000018CB68190-0x000000018CB683E4
		private int Uniquify(); // 0x000000018CB683E4-0x000000018CB68440
		internal System.Reflection.FieldInfo DefineSubTypeStateCallbackField<T>(MethodInfo callback);
		internal bool ImplementsServiceFor<T>(CompatibilityLevel ambient);
		[CompilerGenerated]
		internal static void _DefineSubTypeStateCallbackField_g__WriteCall_18_0<T>(ILGenerator il, MethodInfo callback);
	}

	internal delegate void ProtoSerializer<T>(ref ProtoWriter.State state, T value); // TypeDefIndex: 80597; 0x00000000-0x00000000

	internal delegate T ProtoDeserializer<T>(ref ProtoReader.State state, T value); // TypeDefIndex: 80598; 0x00000000-0x00000000

	internal delegate T ProtoSubTypeDeserializer<T>(ref ProtoReader.State state, SubTypeState<T> value); // TypeDefIndex: 80599; 0x00000000-0x00000000

	internal sealed class Local : IDisposable // TypeDefIndex: 80600
	{
		// Fields
		private LocalBuilder value; // 0x10
		private readonly System.Type type; // 0x18
		private CompilerContext ctx; // 0x20
	
		// Properties
		internal LocalBuilder Value { get; } // 0x000000018CB6E734-0x000000018CB6E7B8 
		public System.Type Type { get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Constructors
		private Local(LocalBuilder value, System.Type type); // 0x0000000185381AC0-0x0000000185381AF0
		internal Local(CompilerContext ctx, System.Type type); // 0x000000018CB6E6DC-0x000000018CB6E734
	
		// Methods
		public Local AsCopy(); // 0x000000018CB6E5FC-0x000000018CB6E678
		public void Dispose(); // 0x000000018CB6E678-0x000000018CB6E6C0
		internal bool IsSame(Local other); // 0x000000018CB6E6C0-0x000000018CB6E6DC
	}

	internal static class WriterUtil // TypeDefIndex: 80601
	{
		// Fields
		internal static readonly System.Type ByRefStateType; // 0x00
	
		// Constructors
		static WriterUtil(); // 0x000000018CB7D834-0x000000018CB7E128
	}
}

namespace ProtoBuf.Extensions
{
	internal static class StringBuilderExtensions // TypeDefIndex: 80586
	{
		// Extension methods
		public static StringBuilder NewLine(this StringBuilder builder, ref int pos, int indent); // 0x000000018CB77940-0x000000018CB779C8
		public static StringBuilder Insert(this StringBuilder builder, string value, ref int pos, Func<bool> condition, int count = 1 /* Metadata: 0x0263CFE9 */); // 0x000000018CB778DC-0x000000018CB77940
		public static StringBuilder Insert(this StringBuilder builder, string value, ref int pos, int count = 1 /* Metadata: 0x0263CFEA */); // 0x000000018CB77884-0x000000018CB778DC
	}
}

namespace ProtoBuf.Internal
{
	internal sealed class DynamicAccess // TypeDefIndex: 80718
	{
		// Fields
		internal const DynamicallyAccessedMemberTypes ContractType = DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties; // Metadata: 0x0263D180
		internal const DynamicallyAccessedMemberTypes Serializer = DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicMethods; // Metadata: 0x0263D182
	
		// Constructors
		public DynamicAccess(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal enum ObjectScope // TypeDefIndex: 80719
	{
		Invalid = 0,
		NakedMessage = 1,
		LikeRoot = 2,
		WrappedMessage = 3,
		Scalar = 4
	}

	internal abstract class DynamicStub // TypeDefIndex: 80722
	{
		// Fields
		private static readonly Hashtable s_byType; // 0x00
	
		// Nested types
		private class NilStub : DynamicStub // TypeDefIndex: 80720
		{
			// Fields
			public static readonly NilStub Instance; // 0x00
	
			// Constructors
			protected NilStub(); // 0x000000018716C330-0x000000018716C370
			static NilStub(); // 0x000000018716C2C0-0x000000018716C330
	
			// Methods
			protected override bool TryDeserializeRoot(TypeModel model, ref ProtoReader.State state, ref object value, bool autoCreate); // 0x00000001843FFFF0-0x0000000184400000
			protected override bool TryDeserialize(ObjectScope scope, TypeModel model, ref ProtoReader.State state, ref object value); // 0x00000001843FFFF0-0x0000000184400000
			protected override bool TrySerializeRoot(TypeModel model, ref ProtoWriter.State state, object value); // 0x00000001843FFFF0-0x0000000184400000
			protected override bool TrySerializeAny(int fieldNumber, SerializerFeatures features, TypeModel model, ref ProtoWriter.State state, object value); // 0x00000001843FFFF0-0x0000000184400000
			protected override bool TryDeepClone(TypeModel model, ref object value); // 0x00000001843FFFF0-0x0000000184400000
			protected override bool IsKnownType(TypeModel model, CompatibilityLevel ambient); // 0x00000001843FFFF0-0x0000000184400000
			protected override bool CanSerialize(TypeModel model, out SerializerFeatures features); // 0x00000001872506D0-0x00000001872506E0
			protected override System.Type GetEffectiveType(); // 0x0000000185829EC0-0x0000000185829ED0
		}
	
		private sealed class ConcreteStub<T> : DynamicStub // TypeDefIndex: 80721
		{
			// Constructors
			public ConcreteStub();
	
			// Methods
			protected override System.Type GetEffectiveType();
			protected override bool TryDeserializeRoot(TypeModel model, ref ProtoReader.State state, ref object value, bool autoCreate);
			protected override bool TryDeserialize(ObjectScope scope, TypeModel model, ref ProtoReader.State state, ref object value);
			protected override bool IsKnownType(TypeModel model, CompatibilityLevel ambient);
			protected override bool CanSerialize(TypeModel model, out SerializerFeatures features);
			protected override bool TrySerializeRoot(TypeModel model, ref ProtoWriter.State state, object value);
			protected override bool TrySerializeAny(int fieldNumber, SerializerFeatures features, TypeModel model, ref ProtoWriter.State state, object value);
			private static void CheckAnyAuxFlow(SerializerFeatures features, ISerializer<T> serializer);
			protected override bool TryDeepClone(TypeModel model, ref object value);
		}
	
		// Constructors
		protected DynamicStub(); // 0x0000000186805BA0-0x0000000186805BB0
		static DynamicStub(); // 0x0000000186FD5360-0x0000000186FD5480
	
		// Methods
		internal static bool TryDeserializeRoot(System.Type type, TypeModel model, ref ProtoReader.State state, ref object value, bool autoCreate); // 0x000000018CB7EB24-0x000000018CB7EBB0
		internal static bool TrySerializeRoot(System.Type type, TypeModel model, ref ProtoWriter.State state, object value); // 0x000000018CB7ED50-0x000000018CB7EE3C
		internal static bool TryDeserialize(ObjectScope scope, System.Type type, TypeModel model, ref ProtoReader.State state, ref object value); // 0x000000018CB7EBB0-0x000000018CB7EC3C
		internal static bool TrySerializeAny(int fieldNumber, SerializerFeatures features, System.Type type, TypeModel model, ref ProtoWriter.State state, object value); // 0x000000018CB7EC3C-0x000000018CB7ED50
		internal static bool TryDeepClone(System.Type type, TypeModel model, ref object value); // 0x000000018CB7EA48-0x000000018CB7EB24
		internal static bool IsKnownType(System.Type type, TypeModel model, CompatibilityLevel ambient); // 0x000000018CB7E970-0x000000018CB7E9E0
		internal static bool CanSerialize(System.Type type, TypeModel model, out SerializerFeatures features); // 0x000000018CB7E858-0x000000018CB7E8E4
		private static DynamicStub Get(System.Type type); // 0x000000018CB7E8E4-0x000000018CB7E970
		private static DynamicStub SlowGet(System.Type type); // 0x000000018585BE60-0x000000018585C290
		protected abstract bool TryDeserializeRoot(TypeModel model, ref ProtoReader.State state, ref object value, bool autoCreate);
		protected abstract bool TryDeserialize(ObjectScope scope, TypeModel model, ref ProtoReader.State state, ref object value);
		protected abstract bool TrySerializeRoot(TypeModel model, ref ProtoWriter.State state, object value);
		protected abstract bool TrySerializeAny(int fieldNumber, SerializerFeatures features, TypeModel model, ref ProtoWriter.State state, object value);
		protected abstract bool TryDeepClone(TypeModel model, ref object value);
		protected abstract bool IsKnownType(TypeModel model, CompatibilityLevel ambient);
		protected abstract bool CanSerialize(TypeModel model, out SerializerFeatures features);
		internal static bool IsTypeEquivalent(System.Type expected, System.Type actual); // 0x000000018CB7E9E0-0x000000018CB7EA48
		internal static System.Type GetEffectiveType(System.Type type); // 0x000000018511F410-0x000000018511F760
		protected abstract System.Type GetEffectiveType();
		[CompilerGenerated]
		internal static DynamicStub _SlowGet_g__TryCreateConcrete_9_0(System.Type typeDef, System.Type[] args); // 0x000000018585C290-0x000000018585C350
		[CompilerGenerated]
		internal static System.Type _SlowGet_g__ResolveProxies_9_1(System.Type type); // 0x000000018585BC50-0x000000018585BE60
	}

	internal sealed class FixedMemoryManager : MemoryManager<byte> // TypeDefIndex: 80723
	{
		// Fields
		private unsafe byte* _pointer; // 0x10
		private int _length; // 0x18
	
		// Constructors
		public FixedMemoryManager(); // 0x000000018721E6B0-0x000000018721E6E0
	
		// Methods
		internal unsafe Memory<byte> Init(byte* pointer, int length); // 0x0000000185120F00-0x0000000185121710
		public override Span<byte> GetSpan(); // 0x0000000184F8C400-0x0000000184F8C490
		public override MemoryHandle Pin(int elementIndex = 0 /* Metadata: 0x0263D188 */); // 0x000000018CB7F2D4-0x000000018CB7F320
		public override void Unpin(); // 0x000000018CB7F320-0x000000018CB7F36C
		protected override void Dispose(bool disposing); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class GuidHelper // TypeDefIndex: 80724
	{
		// Fields
		internal const int WRITE_BYTES_LENGTH = 16; // Metadata: 0x0263D189
		internal const int WRITE_STRING_LENGTH = 36; // Metadata: 0x0263D18A
		internal const int MAX_LENGTH = 40; // Metadata: 0x0263D18B
	
		// Methods
		internal static Guid Read(ref ProtoReader.State state); // 0x000000018CB7F36C-0x000000018CB7F620
		internal static void Write(ref ProtoWriter.State state, [IsReadOnly] in Guid value, bool asBytes); // 0x000000018CB7F718-0x000000018CB7FB08
		[CompilerGenerated]
		internal static byte _Read_g__ToHex_3_0(int value); // 0x000000018CB7F620-0x000000018CB7F668
		[CompilerGenerated]
		internal static int _Write_g__FromHex_4_0(int value); // 0x000000018CB7F668-0x000000018CB7F6A0
		[CompilerGenerated]
		internal static void _Write_g__Throw_4_1(int value); // 0x000000018CB7F6A0-0x000000018CB7F718
	}

	[IsReadOnly]
	internal struct KeyValuePairSerializer<TKey, TValue> : ISerializer<KeyValuePair<TKey, TValue>> // TypeDefIndex: 80725
	{
		// Fields
		private readonly ISerializer<TKey> _keySerializer;
		private readonly ISerializer<TValue> _valueSerializer;
		private readonly SerializerFeatures _keyFeatures;
		private readonly SerializerFeatures _valueFeatures;
	
		// Properties
		public SerializerFeatures Features { get; }
	
		// Constructors
		internal KeyValuePairSerializer(ISerializer<TKey> keySerializer, SerializerFeatures keyFeatures, ISerializer<TValue> valueSerializer, SerializerFeatures valueFeatures);
	
		// Methods
		public KeyValuePair<TKey, TValue> Read(ref ProtoReader.State state, KeyValuePair<TKey, TValue> pair);
		private static T CreateDefault<T>(ISerializationContext context, ISerializer<T> serializer, SerializerFeatures features);
		public void Write(ref ProtoWriter.State state, KeyValuePair<TKey, TValue> value);
	}

	internal class Level240DefaultSerializer : ISerializer<System.DateTime>, ISerializer<System.DateTime?>, ISerializer<TimeSpan>, ISerializer<TimeSpan?> // TypeDefIndex: 80726
	{
		// Properties
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.TimeSpan>.Features { get; } // 0x000000018723A7D0-0x000000018723A7E0 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.TimeSpan?>.Features { get; } // 0x000000018723A7D0-0x000000018723A7E0 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.DateTime>.Features { get; } // 0x000000018723A7D0-0x000000018723A7E0 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.DateTime?>.Features { get; } // 0x000000018723A7D0-0x000000018723A7E0 
	
		// Constructors
		public Level240DefaultSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		System.DateTime? ProtoBuf.Serializers.ISerializer<System.DateTime?>.Read(ref ProtoReader.State state, System.DateTime? value); // 0x000000018CB7FC40-0x000000018CB7FCD0
		void ProtoBuf.Serializers.ISerializer<System.DateTime?>.Write(ref ProtoWriter.State state, System.DateTime? value); // 0x000000018CB7FCD0-0x000000018CB7FD40
		TimeSpan? ProtoBuf.Serializers.ISerializer<System.TimeSpan?>.Read(ref ProtoReader.State state, TimeSpan? value); // 0x000000018CB7FE48-0x000000018CB7FED8
		void ProtoBuf.Serializers.ISerializer<System.TimeSpan?>.Write(ref ProtoWriter.State state, TimeSpan? value); // 0x000000018CB7FED8-0x000000018CB7FF48
		System.DateTime ISerializer<DateTime>.Read(ref ProtoReader.State state, System.DateTime value); // 0x000000018CB7FB08-0x000000018CB7FBB0
		void ISerializer<DateTime>.Write(ref ProtoWriter.State state, System.DateTime value); // 0x000000018CB7FBB0-0x000000018CB7FC40
		TimeSpan ISerializer<TimeSpan>.Read(ref ProtoReader.State state, TimeSpan value); // 0x000000018CB7FD40-0x000000018CB7FDD0
		void ISerializer<TimeSpan>.Write(ref ProtoWriter.State state, TimeSpan value); // 0x000000018CB7FDD0-0x000000018CB7FE48
	}

	internal class Level300DefaultSerializer : Level240DefaultSerializer, ISerializer<decimal>, ISerializer<decimal?>, IValueChecker<decimal>, ISerializer<Guid>, ISerializer<Guid?>, IValueChecker<Guid> // TypeDefIndex: 80727
	{
		// Properties
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Guid>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Guid?>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Decimal>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Decimal?>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
	
		// Constructors
		public Level300DefaultSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		bool IValueChecker<decimal>.HasNonTrivialValue(decimal value); // 0x000000018CB7FF48-0x000000018CB7FFA8
		bool IValueChecker<decimal>.IsNull(decimal value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<Guid>.HasNonTrivialValue(Guid value); // 0x000000018CB7FFA8-0x000000018CB80008
		bool IValueChecker<Guid>.IsNull(Guid value); // 0x00000001843FFFF0-0x0000000184400000
		Guid ISerializer<Guid>.Read(ref ProtoReader.State state, Guid value); // 0x000000018CB801F8-0x000000018CB80220
		void ISerializer<Guid>.Write(ref ProtoWriter.State state, Guid value); // 0x000000018CB80220-0x000000018CB80240
		decimal ISerializer<decimal>.Read(ref ProtoReader.State state, decimal value); // 0x000000018CB80008-0x000000018CB80064
		void ISerializer<decimal>.Write(ref ProtoWriter.State state, decimal value); // 0x000000018CB80064-0x000000018CB800C0
		decimal? ProtoBuf.Serializers.ISerializer<System.Decimal?>.Read(ref ProtoReader.State state, decimal? value); // 0x000000018CB800C0-0x000000018CB8016C
		void ProtoBuf.Serializers.ISerializer<System.Decimal?>.Write(ref ProtoWriter.State state, decimal? value); // 0x000000018CB8016C-0x000000018CB801F8
		Guid? ProtoBuf.Serializers.ISerializer<System.Guid?>.Read(ref ProtoReader.State state, Guid? value); // 0x000000018CB80240-0x000000018CB802FC
		void ProtoBuf.Serializers.ISerializer<System.Guid?>.Write(ref ProtoWriter.State state, Guid? value); // 0x000000018CB802FC-0x000000018CB80388
	}

	internal sealed class Level300FixedSerializer : ISerializer<Guid>, ISerializer<Guid?>, IValueChecker<Guid> // TypeDefIndex: 80728
	{
		// Properties
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Guid>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Guid?>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
	
		// Constructors
		public Level300FixedSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		Guid ISerializer<Guid>.Read(ref ProtoReader.State state, Guid value); // 0x000000018CB801F8-0x000000018CB80220
		void ISerializer<Guid>.Write(ref ProtoWriter.State state, Guid value); // 0x000000018CB803E8-0x000000018CB80408
		Guid? ProtoBuf.Serializers.ISerializer<System.Guid?>.Read(ref ProtoReader.State state, Guid? value); // 0x000000018CB80408-0x000000018CB804C4
		void ProtoBuf.Serializers.ISerializer<System.Guid?>.Write(ref ProtoWriter.State state, Guid? value); // 0x000000018CB804C4-0x000000018CB80550
		bool IValueChecker<Guid>.HasNonTrivialValue(Guid value); // 0x000000018CB80388-0x000000018CB803E8
		bool IValueChecker<Guid>.IsNull(Guid value); // 0x00000001843FFFF0-0x0000000184400000
	}

	internal static class Pool<T> // TypeDefIndex: 80729
		where T : class
	{
		// Fields
		[ThreadStatic]
		private static T ts_local;
		private const int POOL_SIZE = 20; // Metadata: 0x0263D18C
		private static readonly Queue<T> s_pool;
	
		// Constructors
		static Pool();
	
		// Methods
		internal static T TryGet();
		internal static void Put(T obj);
		private static T GetShared();
		private static void PutShared(T obj);
	}

	internal class PrimaryTypeProvider : ISerializer<decimal>, ISerializer<decimal?>, ISerializer<Guid>, ISerializer<Guid?>, IMeasuringSerializer<string>, IMeasuringSerializer<int>, IMeasuringSerializer<long>, IMeasuringSerializer<bool>, IMeasuringSerializer<float>, IMeasuringSerializer<double>, IMeasuringSerializer<byte[]>, IMeasuringSerializer<ArraySegment<byte>>, IMeasuringSerializer<Memory<byte>>, IMeasuringSerializer<ReadOnlyMemory<byte>>, IMeasuringSerializer<ProtoBytes>, IMeasuringSerializer<byte>, IMeasuringSerializer<ushort>, IMeasuringSerializer<uint>, IMeasuringSerializer<ulong>, IMeasuringSerializer<sbyte>, IMeasuringSerializer<short>, IMeasuringSerializer<char>, IMeasuringSerializer<System.Uri>, IMeasuringSerializer<System.Type>, IMeasuringSerializer<IntPtr>, IMeasuringSerializer<UIntPtr>, IMemoryConverter<ProtoBytes, byte>, IFactory<string>, IFactory<byte[]>, IFactory<ProtoBytes>, IMeasuringSerializer<int?>, IMeasuringSerializer<long?>, IMeasuringSerializer<bool?>, IMeasuringSerializer<float?>, IMeasuringSerializer<double?>, IMeasuringSerializer<byte?>, IMeasuringSerializer<ushort?>, IMeasuringSerializer<uint?>, IMeasuringSerializer<ulong?>, IMeasuringSerializer<sbyte?>, IMeasuringSerializer<short?>, IMeasuringSerializer<char?>, IMeasuringSerializer<IntPtr?>, IMeasuringSerializer<UIntPtr?>, IValueChecker<string>, IValueChecker<int>, IValueChecker<long>, IValueChecker<bool>, IValueChecker<float>, IValueChecker<double>, IValueChecker<byte[]>, IValueChecker<ProtoBytes>, IValueChecker<byte>, IValueChecker<ushort>, IValueChecker<uint>, IValueChecker<ulong>, IValueChecker<sbyte>, IValueChecker<short>, IValueChecker<char>, IValueChecker<IntPtr>, IValueChecker<UIntPtr>, IValueChecker<System.Uri>, IValueChecker<System.Type>, IValueChecker<int?>, IValueChecker<long?>, IValueChecker<bool?>, IValueChecker<float?>, IValueChecker<double?>, IValueChecker<byte?>, IValueChecker<ushort?>, IValueChecker<uint?>, IValueChecker<ulong?>, IValueChecker<sbyte?>, IValueChecker<short?>, IValueChecker<char?>, IValueChecker<IntPtr?>, IValueChecker<UIntPtr?>, ISerializer<PrimaryTypeProvider.ScaledTicks>, ISerializer<TimeSpan>, ISerializer<TimeSpan?>, ISerializer<System.DateTime>, ISerializer<System.DateTime?>, ISerializer<Duration>, ISerializer<Duration?>, ISerializer<ProtoBuf.WellKnownTypes.Empty>, ISerializer<ProtoBuf.WellKnownTypes.Empty?>, ISerializer<Timestamp>, ISerializer<Timestamp?> // TypeDefIndex: 80733
	{
		// Fields
		private const int FieldDecimalLow = 1; // Metadata: 0x0263D18D
		private const int FieldDecimalHigh = 2; // Metadata: 0x0263D18E
		private const int FieldDecimalSignScale = 3; // Metadata: 0x0263D18F
		private static readonly bool s_decimalOptimized; // 0x00
		private static readonly bool s_guidOptimized; // 0x01
		private const int FieldGuidLow = 1; // Metadata: 0x0263D190
		private const int FieldGuidHigh = 2; // Metadata: 0x0263D191
	
		// Properties
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Decimal>.Features { get; } // 0x0000000187254C60-0x0000000187254C70 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Decimal?>.Features { get; } // 0x0000000187254C60-0x0000000187254C70 
		internal static bool DecimalOptimized { get; } // 0x000000018CB84EE4-0x000000018CB84F34 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Guid>.Features { get; } // 0x0000000187254C60-0x0000000187254C70 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Guid?>.Features { get; } // 0x0000000187254C60-0x0000000187254C70 
		internal static bool GuidOptimized { get; } // 0x000000018CB84F34-0x000000018CB84F84 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.String>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Int32>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Byte[]>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.ArraySegment<System.Byte>>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Memory<System.Byte>>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.ReadOnlyMemory<System.Byte>>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<Proto.ProtoBytes>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Byte>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.UInt16>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.UInt32>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.UInt64>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Int64>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Boolean>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Single>.Features { get; } // 0x0000000187239F30-0x0000000187239F40 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Double>.Features { get; } // 0x000000018723A770-0x000000018723A780 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.SByte>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Int16>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Uri>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Char>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Int32?>.Features { get; } // 0x000000018CB839B8-0x000000018CB839F8 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Int16?>.Features { get; } // 0x000000018CB83880-0x000000018CB838C0 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Int64?>.Features { get; } // 0x000000018CB83B04-0x000000018CB83B44 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.SByte?>.Features { get; } // 0x000000018CB83EC4-0x000000018CB83F04 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.UInt32?>.Features { get; } // 0x000000018CB8449C-0x000000018CB844DC 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.UInt16?>.Features { get; } // 0x000000018CB84364-0x000000018CB843A4 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.UInt64?>.Features { get; } // 0x000000018CB845E8-0x000000018CB84628 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Byte?>.Features { get; } // 0x000000018CB82A78-0x000000018CB82AB8 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Char?>.Features { get; } // 0x000000018CB82BD4-0x000000018CB82C14 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Boolean?>.Features { get; } // 0x000000018CB8293C-0x000000018CB8297C 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Single?>.Features { get; } // 0x000000018CB8401C-0x000000018CB8405C 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Double?>.Features { get; } // 0x000000018CB832B8-0x000000018CB832F8 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.Type>.Features { get; } // 0x0000000187239F50-0x0000000187239F60 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.IntPtr>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.UIntPtr>.Features { get; } // 0x000000018723A780-0x000000018723A790 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.IntPtr?>.Features { get; } // 0x000000018CB83C6C-0x000000018CB83CAC 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.UIntPtr?>.Features { get; } // 0x000000018CB84748-0x000000018CB84788 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.DateTime>.Features { get; } // 0x0000000187254C60-0x0000000187254C70 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.DateTime?>.Features { get; } // 0x0000000187254C60-0x0000000187254C70 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.TimeSpan>.Features { get; } // 0x0000000187254C60-0x0000000187254C70 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<System.TimeSpan?>.Features { get; } // 0x0000000187254C60-0x0000000187254C70 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<ProtoBuf.Internal.PrimaryTypeProvider.ScaledTicks>.Features { get; } // 0x000000018723A7D0-0x000000018723A7E0 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Duration>.Features { get; } // 0x000000018723A7D0-0x000000018723A7E0 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Duration?>.Features { get; } // 0x000000018723A7D0-0x000000018723A7E0 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Empty>.Features { get; } // 0x000000018723A7D0-0x000000018723A7E0 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Empty?>.Features { get; } // 0x000000018723A7D0-0x000000018723A7E0 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Timestamp>.Features { get; } // 0x000000018723A7D0-0x000000018723A7E0 
		SerializerFeatures ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Timestamp?>.Features { get; } // 0x000000018723A7D0-0x000000018723A7E0 
	
		// Nested types
		[IsReadOnly]
		private struct DecimalAccessor // TypeDefIndex: 80730
		{
			// Fields
			public readonly int Flags; // 0x00
			public readonly int Hi; // 0x04
			public readonly int Lo; // 0x08
			public readonly int Mid; // 0x0C
			public readonly decimal Decimal; // 0x00
	
			// Constructors
			public DecimalAccessor(decimal value); // 0x000000018723AC90-0x000000018723ACA0
		}
	
		[IsReadOnly]
		private struct GuidAccessor // TypeDefIndex: 80731
		{
			// Fields
			public readonly Guid Guid; // 0x00
			public readonly ulong Low; // 0x00
			public readonly ulong High; // 0x08
	
			// Constructors
			public GuidAccessor(Guid value); // 0x000000018723AC90-0x000000018723ACA0
			public GuidAccessor(ulong low, ulong high); // 0x0000000187232F10-0x0000000187232F20
		}
	
		[IsReadOnly]
		[ProtoContract(Name = ".bcl.TimeSpan")]
		internal struct ScaledTicks // TypeDefIndex: 80732
		{
			// Fields
			[CompilerGenerated]
			private readonly long _Value_k__BackingField; // 0x00
			[CompilerGenerated]
			private readonly TimeSpanScale _Scale_k__BackingField; // 0x08
			[CompilerGenerated]
			private readonly DateTimeKind _Kind_k__BackingField; // 0x0C
			internal const int FieldTimeSpanValue = 1; // Metadata: 0x0263D192
			internal const int FieldTimeSpanScale = 2; // Metadata: 0x0263D193
			internal const int FieldTimeSpanKind = 3; // Metadata: 0x0263D194
	
			// Properties
			[ProtoMember(1, DataFormat = ProtoBuf.DataFormat.ZigZag, Name = "value")]
			public long Value { [CompilerGenerated] get; } // 0x0000000184431970-0x0000000184431980 
			[ProtoMember(2, Name = "scale")]
			public TimeSpanScale Scale { [CompilerGenerated] get; } // 0x0000000184431A70-0x0000000184431A80 
			[ProtoMember(3, Name = "kind")]
			public DateTimeKind Kind { [CompilerGenerated] get; } // 0x0000000184431980-0x0000000184431990 
	
			// Constructors
			public ScaledTicks(long value, TimeSpanScale scale, DateTimeKind kind); // 0x000000018724EA40-0x000000018724EA50
			internal ScaledTicks(TimeSpan timeSpan, DateTimeKind kind); // 0x000000018CB8DFFC-0x000000018CB8E1B8
	
			// Methods
			public static ScaledTicks Create(System.DateTime value, bool includeKind); // 0x000000018CB8DA6C-0x000000018CB8DBCC
			public System.DateTime ToDateTime(); // 0x000000018CB8DBCC-0x000000018CB8DDD8
			public TimeSpan ToTimeSpan(); // 0x000000018CB8DDD8-0x000000018CB8DFFC
		}
	
		// Constructors
		public PrimaryTypeProvider(); // 0x0000000186805BA0-0x0000000186805BB0
		static PrimaryTypeProvider(); // 0x0000000186B05A20-0x0000000186B05A80
	
		// Methods
		decimal? ProtoBuf.Serializers.ISerializer<System.Decimal?>.Read(ref ProtoReader.State state, decimal? value); // 0x000000018CB83068-0x000000018CB83114
		void ProtoBuf.Serializers.ISerializer<System.Decimal?>.Write(ref ProtoWriter.State state, decimal? value); // 0x000000018CB83114-0x000000018CB831A0
		decimal ISerializer<decimal>.Read(ref ProtoReader.State state, decimal value); // 0x000000018CB82E20-0x000000018CB82EE4
		void ISerializer<decimal>.Write(ref ProtoWriter.State state, decimal value); // 0x000000018CB82EE4-0x000000018CB83068
		private static bool VerifyDecimalLayout(); // 0x0000000186B05A80-0x0000000186B05B70
		Guid? ProtoBuf.Serializers.ISerializer<System.Guid?>.Read(ref ProtoReader.State state, Guid? value); // 0x000000018CB83634-0x000000018CB836F0
		void ProtoBuf.Serializers.ISerializer<System.Guid?>.Write(ref ProtoWriter.State state, Guid? value); // 0x000000018CB836F0-0x000000018CB8377C
		Guid ISerializer<Guid>.Read(ref ProtoReader.State state, Guid value); // 0x000000018CB832F8-0x000000018CB83470
		void ISerializer<Guid>.Write(ref ProtoWriter.State state, Guid value); // 0x000000018CB83470-0x000000018CB83634
		private static bool VerifyGuidLayout(); // 0x0000000186B05BF0-0x0000000186B05D60
		string ISerializer<string>.Read(ref ProtoReader.State state, string value); // 0x0000000185DA2D50-0x0000000185DA3310
		void ISerializer<string>.Write(ref ProtoWriter.State state, string value); // 0x00000001860A4A00-0x00000001860A4A40
		int IMeasuringSerializer<string>.Measure(ISerializationContext context, WireType wireType, string value); // 0x000000018CB81AA8-0x000000018CB81B20
		int ISerializer<int>.Read(ref ProtoReader.State state, int value); // 0x00000001854C92F0-0x00000001854C9300
		void ISerializer<int>.Write(ref ProtoWriter.State state, int value); // 0x0000000186FB8970-0x0000000186FB8980
		int IMeasuringSerializer<int>.Measure(ISerializationContext context, WireType wireType, int value); // 0x000000018CB81554-0x000000018CB815E8
		byte[] ISerializer<byte[]>.Read(ref ProtoReader.State state, byte[] value); // 0x000000018CB82AB8-0x000000018CB82AC4
		void ISerializer<byte[]>.Write(ref ProtoWriter.State state, byte[] value); // 0x000000018CB82AC4-0x000000018CB82AD0
		int IMeasuringSerializer<byte[]>.Measure(ISerializationContext context, WireType wireType, byte[] value); // 0x000000018CB8128C-0x000000018CB812B4
		ArraySegment<byte> ISerializer<ArraySegment<byte>>.Read(ref ProtoReader.State state, ArraySegment<byte> value); // 0x000000018CB827F8-0x000000018CB8282C
		void ISerializer<ArraySegment<byte>>.Write(ref ProtoWriter.State state, ArraySegment<byte> value); // 0x000000018CB8282C-0x000000018CB8284C
		int IMeasuringSerializer<ArraySegment<byte>>.Measure(ISerializationContext context, WireType wireType, ArraySegment<byte> value); // 0x000000018CB81098-0x000000018CB810F4
		Memory<byte> ISerializer<Memory<byte>>.Read(ref ProtoReader.State state, Memory<byte> value); // 0x000000018CB83CAC-0x000000018CB83CE0
		void ISerializer<Memory<byte>>.Write(ref ProtoWriter.State state, Memory<byte> value); // 0x000000018CB83CE0-0x000000018CB83D70
		int IMeasuringSerializer<Memory<byte>>.Measure(ISerializationContext context, WireType wireType, Memory<byte> value); // 0x000000018CB8187C-0x000000018CB818C8
		ReadOnlyMemory<byte> ISerializer<ReadOnlyMemory<byte>>.Read(ref ProtoReader.State state, ReadOnlyMemory<byte> value); // 0x000000018CB83D70-0x000000018CB83DA4
		void ISerializer<ReadOnlyMemory<byte>>.Write(ref ProtoWriter.State state, ReadOnlyMemory<byte> value); // 0x000000018CB83DA4-0x000000018CB83DC8
		int IMeasuringSerializer<ReadOnlyMemory<byte>>.Measure(ISerializationContext context, WireType wireType, ReadOnlyMemory<byte> value); // 0x000000018CB818C8-0x000000018CB81914
		ProtoBytes ISerializer<ProtoBytes>.Read(ref ProtoReader.State state, ProtoBytes value); // 0x0000000187183C30-0x0000000187183C90
		void ISerializer<ProtoBytes>.Write(ref ProtoWriter.State state, ProtoBytes value); // 0x000000018CB827A0-0x000000018CB827F8
		int IMeasuringSerializer<ProtoBytes>.Measure(ISerializationContext context, WireType wireType, ProtoBytes value); // 0x000000018CB8107C-0x000000018CB81098
		byte ISerializer<byte>.Read(ref ProtoReader.State state, byte value); // 0x000000018CB8297C-0x000000018CB82984
		void ISerializer<byte>.Write(ref ProtoWriter.State state, byte value); // 0x000000018CB82984-0x000000018CB82994
		int IMeasuringSerializer<byte>.Measure(ISerializationContext context, WireType wireType, byte value); // 0x000000018CB811A4-0x000000018CB81210
		ushort ISerializer<ushort>.Read(ref ProtoReader.State state, ushort value); // 0x000000018CB82AD0-0x000000018CB82AD8
		void ISerializer<ushort>.Write(ref ProtoWriter.State state, ushort value); // 0x000000018CB82AD8-0x000000018CB82AE8
		int IMeasuringSerializer<ushort>.Measure(ISerializationContext context, WireType wireType, ushort value); // 0x000000018CB81B94-0x000000018CB81C00
		uint ISerializer<uint>.Read(ref ProtoReader.State state, uint value); // 0x00000001854CA500-0x00000001854CAFC0
		void ISerializer<uint>.Write(ref ProtoWriter.State state, uint value); // 0x0000000186AA87F0-0x0000000186AA8800
		int IMeasuringSerializer<uint>.Measure(ISerializationContext context, WireType wireType, uint value); // 0x000000018CB81C7C-0x000000018CB81CE4
		ulong ISerializer<ulong>.Read(ref ProtoReader.State state, ulong value); // 0x0000000187254C70-0x0000000187254C80
		void ISerializer<ulong>.Write(ref ProtoWriter.State state, ulong value); // 0x00000001867FED40-0x00000001867FED60
		int IMeasuringSerializer<ulong>.Measure(ISerializationContext context, WireType wireType, ulong value); // 0x000000018CB81D64-0x000000018CB81DD0
		long ISerializer<long>.Read(ref ProtoReader.State state, long value); // 0x0000000185F5A0C0-0x0000000185F5A0D0
		void ISerializer<long>.Write(ref ProtoWriter.State state, long value); // 0x0000000186F86510-0x0000000186F86530
		int IMeasuringSerializer<long>.Measure(ISerializationContext context, WireType wireType, long value); // 0x000000018CB8166C-0x000000018CB81700
		bool ISerializer<bool>.Read(ref ProtoReader.State state, bool value); // 0x0000000186165140-0x0000000186165160
		void ISerializer<bool>.Write(ref ProtoWriter.State state, bool value); // 0x0000000186349880-0x00000001863498A0
		int IMeasuringSerializer<bool>.Measure(ISerializationContext context, WireType wireType, bool value); // 0x000000018CB810F4-0x000000018CB81120
		float ISerializer<float>.Read(ref ProtoReader.State state, float value); // 0x000000018CB83F04-0x000000018CB83F0C
		void ISerializer<float>.Write(ref ProtoWriter.State state, float value); // 0x000000018CB83F0C-0x000000018CB83F1C
		int IMeasuringSerializer<float>.Measure(ISerializationContext context, WireType wireType, float value); // 0x000000018CB8139C-0x000000018CB813BC
		double ISerializer<double>.Read(ref ProtoReader.State state, double value); // 0x000000018CB831A0-0x000000018CB831A8
		void ISerializer<double>.Write(ref ProtoWriter.State state, double value); // 0x00000001861EFC90-0x00000001861EFCA0
		int IMeasuringSerializer<double>.Measure(ISerializationContext context, WireType wireType, double value); // 0x000000018CB8139C-0x000000018CB813BC
		sbyte ISerializer<sbyte>.Read(ref ProtoReader.State state, sbyte value); // 0x000000018CB83DC8-0x000000018CB83DD0
		void ISerializer<sbyte>.Write(ref ProtoWriter.State state, sbyte value); // 0x000000018CB83DD0-0x000000018CB83DE0
		int IMeasuringSerializer<sbyte>.Measure(ISerializationContext context, WireType wireType, sbyte value); // 0x000000018CB81914-0x000000018CB819A8
		short ISerializer<short>.Read(ref ProtoReader.State state, short value); // 0x000000018CB8377C-0x000000018CB83784
		void ISerializer<short>.Write(ref ProtoWriter.State state, short value); // 0x000000018CB83784-0x000000018CB83794
		int IMeasuringSerializer<short>.Measure(ISerializationContext context, WireType wireType, short value); // 0x000000018CB81444-0x000000018CB814D8
		System.Uri ISerializer<Uri>.Read(ref ProtoReader.State state, System.Uri value); // 0x000000018CB84788-0x000000018CB84810
		void ISerializer<Uri>.Write(ref ProtoWriter.State state, System.Uri value); // 0x000000018CB84810-0x000000018CB84844
		int IMeasuringSerializer<Uri>.Measure(ISerializationContext context, WireType wireType, System.Uri value); // 0x000000018CB81F80-0x000000018CB82008
		char ISerializer<char>.Read(ref ProtoReader.State state, char value); // 0x000000018CB82AD0-0x000000018CB82AD8
		void ISerializer<char>.Write(ref ProtoWriter.State state, char value); // 0x000000018CB82AD8-0x000000018CB82AE8
		int IMeasuringSerializer<char>.Measure(ISerializationContext context, WireType wireType, char value); // 0x000000018CB812B4-0x000000018CB81320
		string IFactory<string>.Create(ISerializationContext context); // 0x000000018CB81050-0x000000018CB8107C
		byte[] IFactory<byte[]>.Create(ISerializationContext context); // 0x000000018CB81020-0x000000018CB81050
		ProtoBytes IFactory<ProtoBytes>.Create(ISerializationContext context); // 0x000000018CB80FD0-0x000000018CB81020
		ProtoBytes IMemoryConverter<ProtoBytes, byte>.NonNull([IsReadOnly] in ProtoBytes value); // 0x000000018CB82018-0x000000018CB82074
		int IMemoryConverter<ProtoBytes, byte>.GetLength([IsReadOnly] in ProtoBytes value); // 0x000000018CB82008-0x000000018CB82018
		Memory<byte> IMemoryConverter<ProtoBytes, byte>.GetMemory([IsReadOnly] in ProtoBytes value); // 0x00000001862AF830-0x00000001862AF890
		Memory<byte> IMemoryConverter<ProtoBytes, byte>.Expand(ISerializationContext context, ref ProtoBytes value, int additionalCapacity); // 0x00000001858443A0-0x0000000185844440
		void ProtoBuf.Serializers.ISerializer<System.Int32?>.Write(ref ProtoWriter.State state, int? value); // 0x000000018CB83948-0x000000018CB839B8
		int? ProtoBuf.Serializers.ISerializer<System.Int32?>.Read(ref ProtoReader.State state, int? value); // 0x000000018CB838C0-0x000000018CB83948
		void ProtoBuf.Serializers.ISerializer<System.Int16?>.Write(ref ProtoWriter.State state, short? value); // 0x000000018CB83814-0x000000018CB83880
		short? ProtoBuf.Serializers.ISerializer<System.Int16?>.Read(ref ProtoReader.State state, short? value); // 0x000000018CB83794-0x000000018CB83814
		void ProtoBuf.Serializers.ISerializer<System.Int64?>.Write(ref ProtoWriter.State state, long? value); // 0x000000018CB83A8C-0x000000018CB83B04
		long? ProtoBuf.Serializers.ISerializer<System.Int64?>.Read(ref ProtoReader.State state, long? value); // 0x000000018CB839F8-0x000000018CB83A8C
		void ProtoBuf.Serializers.ISerializer<System.SByte?>.Write(ref ProtoWriter.State state, sbyte? value); // 0x000000018CB83E58-0x000000018CB83EC4
		sbyte? ProtoBuf.Serializers.ISerializer<System.SByte?>.Read(ref ProtoReader.State state, sbyte? value); // 0x000000018CB83DE0-0x000000018CB83E58
		void ProtoBuf.Serializers.ISerializer<System.UInt32?>.Write(ref ProtoWriter.State state, uint? value); // 0x000000018CB8442C-0x000000018CB8449C
		uint? ProtoBuf.Serializers.ISerializer<System.UInt32?>.Read(ref ProtoReader.State state, uint? value); // 0x000000018CB843A4-0x000000018CB8442C
		void ProtoBuf.Serializers.ISerializer<System.UInt16?>.Write(ref ProtoWriter.State state, ushort? value); // 0x000000018CB842F8-0x000000018CB84364
		ushort? ProtoBuf.Serializers.ISerializer<System.UInt16?>.Read(ref ProtoReader.State state, ushort? value); // 0x000000018CB84278-0x000000018CB842F8
		void ProtoBuf.Serializers.ISerializer<System.UInt64?>.Write(ref ProtoWriter.State state, ulong? value); // 0x000000018CB84570-0x000000018CB845E8
		ulong? ProtoBuf.Serializers.ISerializer<System.UInt64?>.Read(ref ProtoReader.State state, ulong? value); // 0x000000018CB844DC-0x000000018CB84570
		void ProtoBuf.Serializers.ISerializer<System.Byte?>.Write(ref ProtoWriter.State state, byte? value); // 0x000000018CB82A0C-0x000000018CB82A78
		byte? ProtoBuf.Serializers.ISerializer<System.Byte?>.Read(ref ProtoReader.State state, byte? value); // 0x000000018CB82994-0x000000018CB82A0C
		void ProtoBuf.Serializers.ISerializer<System.Char?>.Write(ref ProtoWriter.State state, char? value); // 0x000000018CB82B68-0x000000018CB82BD4
		char? ProtoBuf.Serializers.ISerializer<System.Char?>.Read(ref ProtoReader.State state, char? value); // 0x000000018CB82AE8-0x000000018CB82B68
		void ProtoBuf.Serializers.ISerializer<System.Boolean?>.Write(ref ProtoWriter.State state, bool? value); // 0x000000018CB828CC-0x000000018CB8293C
		bool? ProtoBuf.Serializers.ISerializer<System.Boolean?>.Read(ref ProtoReader.State state, bool? value); // 0x000000018CB8284C-0x000000018CB828CC
		void ProtoBuf.Serializers.ISerializer<System.Single?>.Write(ref ProtoWriter.State state, float? value); // 0x000000018CB83FA8-0x000000018CB8401C
		float? ProtoBuf.Serializers.ISerializer<System.Single?>.Read(ref ProtoReader.State state, float? value); // 0x000000018CB83F1C-0x000000018CB83FA8
		void ProtoBuf.Serializers.ISerializer<System.Double?>.Write(ref ProtoWriter.State state, double? value); // 0x000000018CB83240-0x000000018CB832B8
		double? ProtoBuf.Serializers.ISerializer<System.Double?>.Read(ref ProtoReader.State state, double? value); // 0x000000018CB831A8-0x000000018CB83240
		System.Type ISerializer<Type>.Read(ref ProtoReader.State state, System.Type value); // 0x000000018CB8425C-0x000000018CB84264
		void ISerializer<Type>.Write(ref ProtoWriter.State state, System.Type value); // 0x000000018CB84264-0x000000018CB84278
		int IMeasuringSerializer<Type>.Measure(ISerializationContext context, WireType wireType, System.Type value); // 0x000000018CB81B20-0x000000018CB81B94
		bool IValueChecker<string>.HasNonTrivialValue(string value); // 0x000000018686BEB0-0x000000018686BEC0
		bool IValueChecker<Uri>.HasNonTrivialValue(System.Uri value); // 0x000000018CB80FA4-0x000000018CB80FD0
		bool IValueChecker<Type>.HasNonTrivialValue(System.Type value); // 0x00000001894D8534-0x00000001894D853C
		bool IValueChecker<byte[]>.HasNonTrivialValue(byte[] value); // 0x00000001894D8534-0x00000001894D853C
		bool IValueChecker<ProtoBytes>.HasNonTrivialValue(ProtoBytes value); // 0x00000001894D8534-0x00000001894D853C
		bool IValueChecker<sbyte>.HasNonTrivialValue(sbyte value); // 0x000000018CB809C0-0x000000018CB809C8
		bool IValueChecker<short>.HasNonTrivialValue(short value); // 0x000000018CB80A2C-0x000000018CB80A34
		bool IValueChecker<int>.HasNonTrivialValue(int value); // 0x00000001895473C0-0x00000001895473C8
		bool IValueChecker<long>.HasNonTrivialValue(long value); // 0x00000001894D8534-0x00000001894D853C
		bool IValueChecker<byte>.HasNonTrivialValue(byte value); // 0x000000018CB809C0-0x000000018CB809C8
		bool IValueChecker<ushort>.HasNonTrivialValue(ushort value); // 0x000000018CB80A2C-0x000000018CB80A34
		bool IValueChecker<uint>.HasNonTrivialValue(uint value); // 0x00000001895473C0-0x00000001895473C8
		bool IValueChecker<ulong>.HasNonTrivialValue(ulong value); // 0x0000000186935170-0x0000000186935180
		bool IValueChecker<char>.HasNonTrivialValue(char value); // 0x000000018CB80A2C-0x000000018CB80A34
		bool IValueChecker<bool>.HasNonTrivialValue(bool value); // 0x0000000187248B30-0x0000000187248B40
		bool IValueChecker<float>.HasNonTrivialValue(float value); // 0x000000018CB80D28-0x000000018CB80D38
		bool IValueChecker<double>.HasNonTrivialValue(double value); // 0x000000018CB80A98-0x000000018CB80AAC
		bool IValueChecker<sbyte>.IsNull(sbyte value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<short>.IsNull(short value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<int>.IsNull(int value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<long>.IsNull(long value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<byte>.IsNull(byte value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<ushort>.IsNull(ushort value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<uint>.IsNull(uint value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<ulong>.IsNull(ulong value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<char>.IsNull(char value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<bool>.IsNull(bool value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<float>.IsNull(float value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<double>.IsNull(double value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<string>.IsNull(string value); // 0x0000000187254C50-0x0000000187254C60
		bool IValueChecker<byte[]>.IsNull(byte[] value); // 0x000000018CA46610-0x000000018CA46618
		bool IValueChecker<ProtoBytes>.IsNull(ProtoBytes value); // 0x000000018CA46610-0x000000018CA46618
		bool IValueChecker<Uri>.IsNull(System.Uri value); // 0x000000018CA46610-0x000000018CA46618
		bool IValueChecker<Type>.IsNull(System.Type value); // 0x000000018CA46610-0x000000018CA46618
		bool ProtoBuf.Internal.IValueChecker<System.Int32?>.HasNonTrivialValue(int? value); // 0x000000018CB80B90-0x000000018CB80BC4
		bool ProtoBuf.Internal.IValueChecker<System.Int32?>.IsNull(int? value); // 0x000000018CB80BC4-0x000000018CB80BF4
		bool ProtoBuf.Internal.IValueChecker<System.UInt32?>.HasNonTrivialValue(uint? value); // 0x000000018CB80E10-0x000000018CB80E44
		bool ProtoBuf.Internal.IValueChecker<System.UInt32?>.IsNull(uint? value); // 0x000000018CB80E44-0x000000018CB80E74
		bool ProtoBuf.Internal.IValueChecker<System.Int16?>.HasNonTrivialValue(short? value); // 0x000000018CB80B2C-0x000000018CB80B60
		bool ProtoBuf.Internal.IValueChecker<System.Int16?>.IsNull(short? value); // 0x000000018CB80B60-0x000000018CB80B90
		bool ProtoBuf.Internal.IValueChecker<System.UInt16?>.HasNonTrivialValue(ushort? value); // 0x000000018CB80DAC-0x000000018CB80DE0
		bool ProtoBuf.Internal.IValueChecker<System.UInt16?>.IsNull(ushort? value); // 0x000000018CB80DE0-0x000000018CB80E10
		bool ProtoBuf.Internal.IValueChecker<System.Int64?>.HasNonTrivialValue(long? value); // 0x000000018CB80BF4-0x000000018CB80C28
		bool ProtoBuf.Internal.IValueChecker<System.Int64?>.IsNull(long? value); // 0x000000018CB80C28-0x000000018CB80C5C
		bool ProtoBuf.Internal.IValueChecker<System.UInt64?>.HasNonTrivialValue(ulong? value); // 0x000000018CB80E74-0x000000018CB80EA8
		bool ProtoBuf.Internal.IValueChecker<System.UInt64?>.IsNull(ulong? value); // 0x000000018CB80EA8-0x000000018CB80EDC
		bool ProtoBuf.Internal.IValueChecker<System.Single?>.HasNonTrivialValue(float? value); // 0x000000018CB80D38-0x000000018CB80D7C
		bool ProtoBuf.Internal.IValueChecker<System.Single?>.IsNull(float? value); // 0x000000018CB80D7C-0x000000018CB80DAC
		bool ProtoBuf.Internal.IValueChecker<System.Double?>.HasNonTrivialValue(double? value); // 0x000000018CB80AAC-0x000000018CB80AF8
		bool ProtoBuf.Internal.IValueChecker<System.Double?>.IsNull(double? value); // 0x000000018CB80AF8-0x000000018CB80B2C
		bool ProtoBuf.Internal.IValueChecker<System.Byte?>.HasNonTrivialValue(byte? value); // 0x000000018CB809C8-0x000000018CB809FC
		bool ProtoBuf.Internal.IValueChecker<System.Byte?>.IsNull(byte? value); // 0x000000018CB809FC-0x000000018CB80A2C
		bool ProtoBuf.Internal.IValueChecker<System.SByte?>.HasNonTrivialValue(sbyte? value); // 0x000000018CB80CC4-0x000000018CB80CF8
		bool ProtoBuf.Internal.IValueChecker<System.SByte?>.IsNull(sbyte? value); // 0x000000018CB80CF8-0x000000018CB80D28
		bool ProtoBuf.Internal.IValueChecker<System.Boolean?>.HasNonTrivialValue(bool? value); // 0x000000018CB80960-0x000000018CB80990
		bool ProtoBuf.Internal.IValueChecker<System.Boolean?>.IsNull(bool? value); // 0x000000018CB80990-0x000000018CB809C0
		bool ProtoBuf.Internal.IValueChecker<System.Char?>.HasNonTrivialValue(char? value); // 0x000000018CB80A34-0x000000018CB80A68
		bool ProtoBuf.Internal.IValueChecker<System.Char?>.IsNull(char? value); // 0x000000018CB80A68-0x000000018CB80A98
		int ProtoBuf.Serializers.IMeasuringSerializer<System.Int32?>.Measure(ISerializationContext context, WireType wireType, int? value); // 0x000000018CB815E8-0x000000018CB8166C
		int ProtoBuf.Serializers.IMeasuringSerializer<System.Int64?>.Measure(ISerializationContext context, WireType wireType, long? value); // 0x000000018CB81700-0x000000018CB81788
		int ProtoBuf.Serializers.IMeasuringSerializer<System.Single?>.Measure(ISerializationContext context, WireType wireType, float? value); // 0x000000018CB81A24-0x000000018CB81AA8
		int ProtoBuf.Serializers.IMeasuringSerializer<System.Double?>.Measure(ISerializationContext context, WireType wireType, double? value); // 0x000000018CB813BC-0x000000018CB81444
		int ProtoBuf.Serializers.IMeasuringSerializer<System.Byte?>.Measure(ISerializationContext context, WireType wireType, byte? value); // 0x000000018CB81210-0x000000018CB8128C
		int ProtoBuf.Serializers.IMeasuringSerializer<System.UInt16?>.Measure(ISerializationContext context, WireType wireType, ushort? value); // 0x000000018CB81C00-0x000000018CB81C7C
		int ProtoBuf.Serializers.IMeasuringSerializer<System.UInt32?>.Measure(ISerializationContext context, WireType wireType, uint? value); // 0x000000018CB81CE4-0x000000018CB81D64
		int ProtoBuf.Serializers.IMeasuringSerializer<System.UInt64?>.Measure(ISerializationContext context, WireType wireType, ulong? value); // 0x000000018CB81DD0-0x000000018CB81E58
		int ProtoBuf.Serializers.IMeasuringSerializer<System.SByte?>.Measure(ISerializationContext context, WireType wireType, sbyte? value); // 0x000000018CB819A8-0x000000018CB81A24
		int ProtoBuf.Serializers.IMeasuringSerializer<System.Int16?>.Measure(ISerializationContext context, WireType wireType, short? value); // 0x000000018CB814D8-0x000000018CB81554
		int ProtoBuf.Serializers.IMeasuringSerializer<System.Char?>.Measure(ISerializationContext context, WireType wireType, char? value); // 0x000000018CB81320-0x000000018CB8139C
		int ProtoBuf.Serializers.IMeasuringSerializer<System.Boolean?>.Measure(ISerializationContext context, WireType wireType, bool? value); // 0x000000018CB81120-0x000000018CB811A4
		void ProtoBuf.Serializers.ISerializer<System.IntPtr?>.Write(ref ProtoWriter.State state, IntPtr? value); // 0x000000018CB83BF4-0x000000018CB83C6C
		IntPtr? ProtoBuf.Serializers.ISerializer<System.IntPtr?>.Read(ref ProtoReader.State state, IntPtr? value); // 0x000000018CB83B60-0x000000018CB83BF4
		void ProtoBuf.Serializers.ISerializer<System.UIntPtr?>.Write(ref ProtoWriter.State state, UIntPtr? value); // 0x000000018CB846D0-0x000000018CB84748
		UIntPtr? ProtoBuf.Serializers.ISerializer<System.UIntPtr?>.Read(ref ProtoReader.State state, UIntPtr? value); // 0x000000018CB8463C-0x000000018CB846D0
		void ISerializer<IntPtr>.Write(ref ProtoWriter.State state, IntPtr value); // 0x000000018CB83B4C-0x000000018CB83B60
		IntPtr ISerializer<IntPtr>.Read(ref ProtoReader.State state, IntPtr value); // 0x000000018CB83B44-0x000000018CB83B4C
		void ISerializer<UIntPtr>.Write(ref ProtoWriter.State state, UIntPtr value); // 0x000000018CB84630-0x000000018CB8463C
		UIntPtr ISerializer<UIntPtr>.Read(ref ProtoReader.State state, UIntPtr value); // 0x000000018CB84628-0x000000018CB84630
		int IMeasuringSerializer<IntPtr>.Measure(ISerializationContext context, WireType wireType, IntPtr value); // 0x000000018CB81788-0x000000018CB817F4
		int IMeasuringSerializer<UIntPtr>.Measure(ISerializationContext context, WireType wireType, UIntPtr value); // 0x000000018CB81E58-0x000000018CB81EDC
		int ProtoBuf.Serializers.IMeasuringSerializer<System.IntPtr?>.Measure(ISerializationContext context, WireType wireType, IntPtr? value); // 0x000000018CB817F4-0x000000018CB8187C
		int ProtoBuf.Serializers.IMeasuringSerializer<System.UIntPtr?>.Measure(ISerializationContext context, WireType wireType, UIntPtr? value); // 0x000000018CB81EDC-0x000000018CB81F80
		bool IValueChecker<IntPtr>.HasNonTrivialValue(IntPtr value); // 0x00000001894D8534-0x00000001894D853C
		bool IValueChecker<IntPtr>.IsNull(IntPtr value); // 0x00000001843FFFF0-0x0000000184400000
		bool IValueChecker<UIntPtr>.HasNonTrivialValue(UIntPtr value); // 0x000000018CB80EDC-0x000000018CB80F24
		bool IValueChecker<UIntPtr>.IsNull(UIntPtr value); // 0x00000001843FFFF0-0x0000000184400000
		bool ProtoBuf.Internal.IValueChecker<System.IntPtr?>.HasNonTrivialValue(IntPtr? value); // 0x000000018CB80C5C-0x000000018CB80C90
		bool ProtoBuf.Internal.IValueChecker<System.IntPtr?>.IsNull(IntPtr? value); // 0x000000018CB80C90-0x000000018CB80CC4
		bool ProtoBuf.Internal.IValueChecker<System.UIntPtr?>.HasNonTrivialValue(UIntPtr? value); // 0x000000018CB80F24-0x000000018CB80F70
		bool ProtoBuf.Internal.IValueChecker<System.UIntPtr?>.IsNull(UIntPtr? value); // 0x000000018CB80F70-0x000000018CB80FA4
		TimeSpan? ProtoBuf.Serializers.ISerializer<System.TimeSpan?>.Read(ref ProtoReader.State state, TimeSpan? value); // 0x000000018CB8415C-0x000000018CB841EC
		void ProtoBuf.Serializers.ISerializer<System.TimeSpan?>.Write(ref ProtoWriter.State state, TimeSpan? value); // 0x000000018CB841EC-0x000000018CB8425C
		System.DateTime? ProtoBuf.Serializers.ISerializer<System.DateTime?>.Read(ref ProtoReader.State state, System.DateTime? value); // 0x000000018CB82D20-0x000000018CB82DB0
		void ProtoBuf.Serializers.ISerializer<System.DateTime?>.Write(ref ProtoWriter.State state, System.DateTime? value); // 0x000000018CB82DB0-0x000000018CB82E20
		TimeSpan ISerializer<TimeSpan>.Read(ref ProtoReader.State state, TimeSpan value); // 0x000000018CB8405C-0x000000018CB840D4
		void ISerializer<TimeSpan>.Write(ref ProtoWriter.State state, TimeSpan value); // 0x000000018CB840D4-0x000000018CB8415C
		System.DateTime ISerializer<DateTime>.Read(ref ProtoReader.State state, System.DateTime value); // 0x000000018CB82C14-0x000000018CB82C8C
		void ISerializer<DateTime>.Write(ref ProtoWriter.State state, System.DateTime value); // 0x000000018CB82C8C-0x000000018CB82D20
		void ProtoBuf.Serializers.ISerializer<ProtoBuf.Internal.PrimaryTypeProvider.ScaledTicks>.Write(ref ProtoWriter.State state, ScaledTicks value); // 0x000000018CB82190-0x000000018CB82220
		ScaledTicks ProtoBuf.Serializers.ISerializer<ProtoBuf.Internal.PrimaryTypeProvider.ScaledTicks>.Read(ref ProtoReader.State state, ScaledTicks _); // 0x000000018CB82074-0x000000018CB82190
		Duration? ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Duration?>.Read(ref ProtoReader.State state, Duration? value); // 0x000000018CB822F8-0x000000018CB823A4
		void ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Duration?>.Write(ref ProtoWriter.State state, Duration? value); // 0x000000018CB823A4-0x000000018CB82430
		Duration ISerializer<Duration>.Read(ref ProtoReader.State state, Duration value); // 0x000000018CB82220-0x000000018CB82298
		internal static Duration ReadDuration(ref ProtoReader.State state, Duration value); // 0x000000018CB848C0-0x000000018CB84970
		private static bool TryReadDurationFast(ref ProtoReader.State state, ref Duration value); // 0x000000018CB84BDC-0x000000018CB84D58
		private static Duration ReadDurationFallback(ref ProtoReader.State state, Duration value); // 0x000000018CB84844-0x000000018CB848C0
		void ISerializer<Duration>.Write(ref ProtoWriter.State state, Duration value); // 0x000000018CB82298-0x000000018CB822F8
		internal static void WriteDuration(ref ProtoWriter.State state, Duration value); // 0x000000018CB84D58-0x000000018CB84DB8
		internal static long ToDurationSeconds(long ticks, out int nanos, bool isTimestamp); // 0x000000018CB84A2C-0x000000018CB84AE0
		internal static long ToTicks(long seconds, int nanos); // 0x000000018CB84AE0-0x000000018CB84BDC
		internal static void NormalizeSecondsNanoseconds(ref long seconds, ref int nanos, bool isTimestamp); // 0x000000018CB808DC-0x000000018CB80960
		private static void WriteSecondsNanos(ref ProtoWriter.State state, long seconds, int nanos, bool isTimestamp); // 0x000000018CB84DB8-0x000000018CB84E6C
		ProtoBuf.WellKnownTypes.Empty ISerializer<Empty>.Read(ref ProtoReader.State state, ProtoBuf.WellKnownTypes.Empty value); // 0x000000018CB82430-0x000000018CB82450
		void ISerializer<Empty>.Write(ref ProtoWriter.State state, ProtoBuf.WellKnownTypes.Empty value); // 0x0000000186805BA0-0x0000000186805BB0
		ProtoBuf.WellKnownTypes.Empty? ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Empty?>.Read(ref ProtoReader.State state, ProtoBuf.WellKnownTypes.Empty? value); // 0x000000018CB82450-0x000000018CB824C8
		void ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Empty?>.Write(ref ProtoWriter.State state, ProtoBuf.WellKnownTypes.Empty? value); // 0x000000018CB824C8-0x000000018CB82534
		Timestamp ISerializer<Timestamp>.Read(ref ProtoReader.State state, Timestamp value); // 0x000000018CB82534-0x000000018CB825F0
		internal static Timestamp ReadTimestamp(ref ProtoReader.State state, Timestamp value); // 0x000000018CB84970-0x000000018CB84A2C
		void ISerializer<Timestamp>.Write(ref ProtoWriter.State state, Timestamp value); // 0x000000018CB825F0-0x000000018CB82668
		internal static void WriteTimestamp(ref ProtoWriter.State state, Timestamp value); // 0x000000018CB84E6C-0x000000018CB84EE4
		Timestamp? ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Timestamp?>.Read(ref ProtoReader.State state, Timestamp? value); // 0x000000018CB82668-0x000000018CB82714
		void ProtoBuf.Serializers.ISerializer<ProtoBuf.WellKnownTypes.Timestamp?>.Write(ref ProtoWriter.State state, Timestamp? value); // 0x000000018CB82714-0x000000018CB827A0
	}

	internal struct ReadBuffer<T> : IDisposable, ICollection<T>, IReadOnlyCollection<T>, ICollection // TypeDefIndex: 80734
	{
		// Fields
		private T[] _arr;
		private int _count;
	
		// Properties
		bool ICollection<T>.IsReadOnly { [IsReadOnly] get; }
		bool ICollection.IsSynchronized { [IsReadOnly] get; }
		object ICollection.SyncRoot { [IsReadOnly] get; }
		public bool IsEmpty { [IsReadOnly] get; }
		public int Count { [IsReadOnly] get; }
		public ArraySegment<T> Segment { [IsReadOnly] get; }
		public Span<T> Span { [IsReadOnly] get; }
	
		// Constructors
		private ReadBuffer(int minimumLength);
	
		// Methods
		public void Clear();
		[IsReadOnly]
		public void CopyTo(T[] array, int arrayIndex = 0 /* Metadata: 0x0263D195 */);
		[IsReadOnly]
		void ICollection.CopyTo(Array array, int index);
		public T[] ToArray();
		public T[] ToArray(T[] prepend);
		[IsReadOnly]
		bool ICollection<T>.Contains(T item);
		bool ICollection<T>.Remove(T item);
		[IsReadOnly]
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public static ReadBuffer<T> Create(int minimumLength = 16 /* Metadata: 0x0263D196 */);
		private static void Recyle(ref ref T[] array);
		public void Dispose();
		private void Grow();
		public void Add(T value);
	}

	internal static class ThrowHelper // TypeDefIndex: 80736
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80735
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static TypeFilter __9__10_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018CB8FBC8-0x000000018CB8FC2C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _NoSerializerDefined_b__10_0(System.Type i, object _); // 0x000000018CB8FAEC-0x000000018CB8FB40
		}
	
		// Methods
		public static void ThrowArgumentOutOfRangeException(string paramName); // 0x000000018CB8EA20-0x000000018CB8EA78
		public static void ThrowArgumentOutOfRangeException(string paramName, string message); // 0x000000018CB8E9C0-0x000000018CB8EA20
		public static void ThrowArgumentNullException(string paramName); // 0x000000018CB8E968-0x000000018CB8E9C0
		public static void ThrowArgumentNullException(string paramName, string message); // 0x000000018CB8E908-0x000000018CB8E968
		public static void ThrowIndexOutOfRangeException(); // 0x000000018CB8EA78-0x000000018CB8EAC4
		internal static void ThrowArgumentException(string message, string paramName); // 0x000000018CB8E8A8-0x000000018CB8E908
		internal static void Format(string message); // 0x000000018CB8E598-0x000000018CB8E5F0
		internal static void ThrowArgumentException(string message); // 0x000000018CB8E850-0x000000018CB8E8A8
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(); // 0x000000018CB8EAC4-0x000000018CB8EB20
		internal static void ThrowInvalidOperationException(string message = null, Exception innerException = null); // 0x000000018CB8EB20-0x000000018CB8EC64
		internal static void NoSerializerDefined(System.Type type); // 0x000000018CB8E5F0-0x000000018CB8E850
		internal static void ThrowNotSupportedException(); // 0x000000018CB8EDDC-0x000000018CB8EE28
		internal static void ThrowNotSupportedException(string message); // 0x000000018CB8EE28-0x000000018CB8EE80
		internal static void ThrowProtoException(string message, Exception inner = null); // 0x000000018CB8EF18-0x000000018CB8EFA4
		internal static void ThrowOverflowException(); // 0x000000018CB8EECC-0x000000018CB8EF18
		internal static void ThrowNotImplementedException([CallerMemberName] string message = null); // 0x000000018CB8ED84-0x000000018CB8EDDC
		internal static void ThrowNullReferenceException(); // 0x000000018CB8EE80-0x000000018CB8EECC
		internal static void ThrowNullRepeatedContents<T>();
		internal static void ThrowTrackedObjects(object obj); // 0x000000018CB8EFA4-0x000000018CB8F034
		internal static void ThrowNestedDataNotSupported(System.Type declaringType); // 0x000000018CB8ED08-0x000000018CB8ED84
		internal static void ThrowInvalidPackedOperationException(WireType wireType, System.Type type); // 0x000000018CB8EC64-0x000000018CB8ED08
	}

	internal static class TypeHelper // TypeDefIndex: 80737
	{
		// Methods
		internal static bool CanBePacked(System.Type type); // 0x000000018654D720-0x000000018654D7C0
		internal static bool IsBytesLike(System.Type type); // 0x00000001854C0E40-0x00000001854C0F90
		[Obsolete("Prefer list provider")]
		internal static bool ResolveUniqueEnumerableT(System.Type type, out System.Type t); // 0x000000018CB8F118-0x000000018CB8F370
		internal static object GetValueTypeChecker(System.Type type); // 0x000000018654D5F0-0x000000018654D720
		internal static object CreateNonTrivialDefault(System.Type type); // 0x00000001859E4CC0-0x00000001859E4DC0
		[CompilerGenerated]
		internal static bool _ResolveUniqueEnumerableT_g__IsEnumerableT_3_0(System.Type type, out System.Type t); // 0x000000018CB8F370-0x000000018CB8F470
	
		// Extension methods
		internal static string NormalizeName(this System.Type type); // 0x000000018CB8F0CC-0x000000018CB8F118
	}

	internal static class TypeHelper<T> // TypeDefIndex: 80739
	{
		// Fields
		public static readonly bool IsReferenceType;
		public static readonly bool CanBeNull;
		public static readonly IValueChecker<T> ValueChecker;
		public static readonly bool CanBePacked;
		public static readonly T Default;
		public static readonly T NonTrivialDefault;
		public static readonly Func<ISerializationContext, T> Factory;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80738
		{
			// Fields
			public static readonly __c<T> __9;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal T _.cctor_b__8_0(ISerializationContext ctx);
		}
	
		// Constructors
		static TypeHelper();
	
		// Methods
		public static T FromObject(object value);
	}

	internal interface IValueChecker<in T> // TypeDefIndex: 80740
	{
		// Methods
		bool HasNonTrivialValue(T value);
		bool IsNull(T value);
	}

	internal sealed class ReferenceValueChecker : IValueChecker<object> // TypeDefIndex: 80741
	{
		// Fields
		public static readonly ReferenceValueChecker Instance; // 0x00
	
		// Constructors
		private ReferenceValueChecker(); // 0x0000000186805BA0-0x0000000186805BB0
		static ReferenceValueChecker(); // 0x00000001871E7B20-0x00000001871E7B80
	
		// Methods
		bool IValueChecker<object>.HasNonTrivialValue(object value); // 0x000000018686BEB0-0x000000018686BEC0
		bool IValueChecker<object>.IsNull(object value); // 0x0000000187254C80-0x0000000187254C90
	}

	internal sealed class StructValueChecker<T> : IValueChecker<T?>, IValueChecker<T> // TypeDefIndex: 80742
		where T : struct
	{
		// Fields
		public static readonly StructValueChecker<T> Instance;
	
		// Constructors
		private StructValueChecker();
		static StructValueChecker();
	
		// Methods
		bool IValueChecker<T?>.HasNonTrivialValue(T? value);
		bool IValueChecker<T?>.IsNull(T? value);
		bool IValueChecker<T>.HasNonTrivialValue(T value);
		bool IValueChecker<T>.IsNull(T value);
	}

	internal sealed class BasicList : IEnumerable // TypeDefIndex: 80747
	{
		// Fields
		private static readonly Node nil; // 0x00
		private Node head; // 0x10
	
		// Properties
		public object this[int index] { get => default; } // 0x0000000187838034-0x0000000187838040 
		public int Count { get; } // 0x00000001844AF510-0x00000001844AF520 
	
		// Nested types
		public struct NodeEnumerator : IEnumerator // TypeDefIndex: 80743
		{
			// Fields
			private int position; // 0x00
			private readonly Node node; // 0x08
	
			// Properties
			public object Current { [IsReadOnly] get; } // 0x0000000187837C54-0x0000000187837C64 
	
			// Constructors
			internal NodeEnumerator(Node node); // 0x0000000187837C64-0x0000000187837C7C
	
			// Methods
			void IEnumerator.Reset(); // 0x0000000187254C40-0x0000000187254C50
			public bool MoveNext(); // 0x0000000185848100-0x0000000185848120
		}
	
		[IsReadOnly]
		internal struct Node // TypeDefIndex: 80744
		{
			// Fields
			private readonly object[] data; // 0x00
			[CompilerGenerated]
			private readonly int _Length_k__BackingField; // 0x08
	
			// Properties
			public object this[int index] { get => default; set {} } // 0x000000018599B4E0-0x000000018599B520 0x000000018CB805F8-0x000000018CB8069C
			public int Length { [CompilerGenerated] get; } // 0x0000000184431A70-0x0000000184431A80 
	
			// Constructors
			internal Node(object[] data, int length); // 0x000000018783B33C-0x000000018783B358
	
			// Methods
			public Node Append(object value); // 0x0000000186252630-0x0000000186252740
			internal int IndexOfReference(object instance); // 0x000000018CB805A8-0x000000018CB805F8
			internal int IndexOf(MatchPredicate predicate, object ctx); // 0x00000001854B32D0-0x00000001854B3500
		}
	
		internal delegate bool MatchPredicate(object value, object ctx); // TypeDefIndex: 80745; 0x00000001859B7730-0x00000001859B7740
	
		[IsReadOnly]
		internal struct Group<T> // TypeDefIndex: 80746
		{
			// Fields
			public readonly int First;
			public readonly List<T> Items;
	
			// Properties
			public bool IsEmpty { get; }
	
			// Constructors
			public Group(int first);
		}
	
		// Constructors
		public BasicList(); // 0x0000000186BF8000-0x0000000186BF8060
		static BasicList(); // 0x0000000186252570-0x00000001862525E0
	
		// Methods
		public int Add(object value); // 0x00000001862525E0-0x0000000186252630
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018CB7E190-0x000000018CB7E210
		public NodeEnumerator GetEnumerator(); // 0x0000000185848120-0x0000000185848150
		internal int IndexOf(MatchPredicate predicate, object ctx); // 0x0000000187838040-0x000000018783804C
		internal bool Contains(object value); // 0x000000018CB7E128-0x000000018CB7E190
		internal static List<Group<T>> GetContiguousGroups<T>(int[] keys, T[] values);
		internal bool Any(); // 0x0000000188A59C18-0x0000000188A59C20
	}

	internal static class TypeCompatibilityHelper // TypeDefIndex: 80748
	{
		// Fields
		private static readonly Dictionary<Module, CompatibilityLevel> s_ByModule; // 0x00
	
		// Constructors
		static TypeCompatibilityHelper(); // 0x00000001871767C0-0x0000000187176850
	
		// Methods
		internal static CompatibilityLevel GetModuleCompatibilityLevel(Module module); // 0x000000018595A9D0-0x000000018595B930
		internal static CompatibilityLevel GetTypeCompatibilityLevel(System.Type type, CompatibilityLevel defaultLevel); // 0x000000018595A890-0x000000018595A9D0
		internal static CompatibilityLevel GetMemberCompatibilityLevel(MemberInfo member, CompatibilityLevel typeLevel); // 0x0000000184FD4AE0-0x0000000184FD4BC0
		[CompilerGenerated]
		internal static CompatibilityLevel _GetModuleCompatibilityLevel_g__Calculate_1_0(Module module); // 0x0000000186BAB680-0x0000000186BAB790
	}
}

namespace ProtoBuf.Internal.Serializers
{
	internal sealed class AnyTypeSerializer<T> : IRuntimeProtoSerializerNode, IDirectWriteNode, IDirectRuntimeWriteNode // TypeDefIndex: 80749
	{
		// Fields
		private readonly SerializerFeatures _features;
		private readonly CompatibilityLevel _compatibilityLevel;
		private readonly ProtoBuf.DataFormat _dataFormat;
		private static readonly MethodInfo ReadAnyT;
		private static readonly MethodInfo WriteAnyT;
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; }
		public System.Type ExpectedType { get; }
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; }
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; }
	
		// Constructors
		public AnyTypeSerializer(SerializerFeatures features, CompatibilityLevel compatibilityLevel, ProtoBuf.DataFormat dataFormat);
		static AnyTypeSerializer();
	
		// Methods
		public object Read(ref ProtoReader.State state, object value);
		public void Write(ref ProtoWriter.State state, object value);
		void IDirectRuntimeWriteNode.DirectWrite(int fieldNumber, WireType wireType, ref ProtoWriter.State state, object value);
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom);
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity);
		bool IDirectWriteNode.CanEmitDirectWrite(WireType wireType);
		bool IDirectRuntimeWriteNode.CanDirectWrite(WireType wireType);
		void IDirectWriteNode.EmitDirectWrite(int fieldNumber, WireType wireType, CompilerContext ctx, Local valueFrom);
	}

	internal static class AnyTypeSerializer // TypeDefIndex: 80750
	{
		// Fields
		internal static readonly MethodInfo ReadAnyT; // 0x00
		internal static readonly MethodInfo WriteAnyT; // 0x08
	
		// Constructors
		static AnyTypeSerializer(); // 0x000000018CB90470-0x000000018CB90570
	
		// Methods
		private static bool FindSerializerFeaturesMethodFilter(MemberInfo member, object state); // 0x000000018CB9025C-0x000000018CB9039C
		private static MethodInfo FindSerializerFeaturesMethod(System.Type type, string name); // 0x000000018CB9039C-0x000000018CB90470
		internal static IRuntimeProtoSerializerNode Create(System.Type memberType, SerializerFeatures features, CompatibilityLevel compatibilityLevel, ProtoBuf.DataFormat dataFormat); // 0x000000018CB90068-0x000000018CB9025C
	}

	internal sealed class BlobSerializer<T> : IRuntimeProtoSerializerNode // TypeDefIndex: 80751
	{
		// Fields
		private static readonly System.Type expectedType;
		private readonly bool overwriteList;
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; }
		public System.Type ExpectedType { get; }
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; }
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; }
	
		// Constructors
		public BlobSerializer(bool overwriteList);
		static BlobSerializer();
	
		// Methods
		public object Read(ref ProtoReader.State state, object value);
		public void Write(ref ProtoWriter.State state, object value);
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom);
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity);
	}

	internal sealed class BooleanSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80752
	{
		// Fields
		internal static readonly BooleanSerializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB90628-0x000000018CB90678 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private BooleanSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static BooleanSerializer(); // 0x00000001870E1D80-0x00000001870E1F40
	
		// Methods
		public void Write(ref ProtoWriter.State state, object value); // 0x00000001863498A0-0x0000000186349940
		public object Read(ref ProtoReader.State state, object value); // 0x0000000186165160-0x0000000186165270
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB905BC-0x000000018CB90628
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB90570-0x000000018CB905BC
	}

	internal sealed class ByteSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80753
	{
		// Fields
		internal static readonly ByteSerializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB90898-0x000000018CB908E8 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private ByteSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static ByteSerializer(); // 0x000000018CB907D4-0x000000018CB90898
	
		// Methods
		public void Write(ref ProtoWriter.State state, object value); // 0x000000018CB90780-0x000000018CB907D4
		public object Read(ref ProtoReader.State state, object value); // 0x000000018CB90730-0x000000018CB90780
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB906C4-0x000000018CB90730
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB90678-0x000000018CB906C4
	}

	internal sealed class CharSerializer : UInt16Serializer // TypeDefIndex: 80754
	{
		// Fields
		internal static readonly CharSerializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		public override System.Type ExpectedType { get; } // 0x000000018CB90A9C-0x000000018CB90AEC 
	
		// Constructors
		private CharSerializer(); // 0x000000018CB90A5C-0x000000018CB90A9C
		static CharSerializer(); // 0x000000018CB9098C-0x000000018CB90A5C
	
		// Methods
		public override void Write(ref ProtoWriter.State state, object value); // 0x000000018CB90938-0x000000018CB9098C
		public override object Read(ref ProtoReader.State state, object value); // 0x000000018CB908E8-0x000000018CB90938
	}

	internal sealed class InheritanceCompiledSerializer<TBase, T> : CompiledSerializer, ISerializer<T>, ISubTypeSerializer<T>, IFactory<T> // TypeDefIndex: 80755
		where TBase : class
		where T : class, TBase
	{
		// Fields
		private readonly ProtoSerializer<T> subTypeSerializer;
		private readonly ProtoSubTypeDeserializer<T> subTypeDeserializer;
		private readonly Func<ISerializationContext, T> factory;
	
		// Constructors
		public InheritanceCompiledSerializer(IProtoTypeSerializer head, RuntimeTypeModel model);
	
		// Methods
		T ISerializer<T>.Read(ref ProtoReader.State state, T value);
		T IFactory<T>.Create(ISerializationContext context);
		public override object Read(ref ProtoReader.State state, object value);
		void ISerializer<T>.Write(ref ProtoWriter.State state, T value);
		public override void Write(ref ProtoWriter.State state, object value);
		void ISubTypeSerializer<T>.WriteSubType(ref ProtoWriter.State state, T value);
		T ISubTypeSerializer<T>.ReadSubType(ref ProtoReader.State state, SubTypeState<T> value);
	}

	internal class SimpleCompiledSerializer<T> : CompiledSerializer, ISerializer<T>, IFactory<T> // TypeDefIndex: 80756
	{
		// Fields
		protected readonly ProtoSerializer<T> serializer;
		protected readonly ProtoDeserializer<T> deserializer;
		private readonly Func<ISerializationContext, T> factory;
	
		// Constructors
		public SimpleCompiledSerializer(IProtoTypeSerializer head, RuntimeTypeModel model);
	
		// Methods
		T ISerializer<T>.Read(ref ProtoReader.State state, T value);
		public override object Read(ref ProtoReader.State state, object value);
		void ISerializer<T>.Write(ref ProtoWriter.State state, T value);
		public override void Write(ref ProtoWriter.State state, object value);
		T IFactory<T>.Create(ISerializationContext context);
	}

	internal interface ICompiledSerializer // TypeDefIndex: 80757
	{
		// Properties
		System.Type ExpectedType { get; }
	}

	internal abstract class CompiledSerializer : IProtoTypeSerializer, ICompiledSerializer // TypeDefIndex: 80758
	{
		// Fields
		protected readonly IProtoTypeSerializer head; // 0x10
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x000000018CB90CBC-0x000000018CB90CDC 
		public SerializerFeatures Features { get; } // 0x000000018CB9140C-0x000000018CB9142C 
		bool IProtoTypeSerializer.IsSubType { get; } // 0x000000018CB90C3C-0x000000018CB90C5C 
		System.Type IProtoTypeSerializer.BaseType { get; } // 0x000000018CB90BFC-0x000000018CB90C1C 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x000000018CB90CDC-0x000000018CB90CFC 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x000000018CB90CFC-0x000000018CB90D1C 
		public System.Type ExpectedType { get; } // 0x000000018CB913EC-0x000000018CB9140C 
		bool IProtoTypeSerializer.HasInheritance { get; } // 0x000000018CB90C1C-0x000000018CB90C3C 
		bool IProtoTypeSerializer.ShouldEmitCreateInstance { get; } // 0x000000018CB90C5C-0x000000018CB90C7C 
	
		// Constructors
		protected CompiledSerializer(IProtoTypeSerializer head); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		bool IProtoTypeSerializer.HasCallbacks(TypeModel.CallbackType callbackType); // 0x000000018CB90BDC-0x000000018CB90BFC
		bool IProtoTypeSerializer.CanCreateInstance(); // 0x000000018CB90B14-0x000000018CB90B34
		object IProtoTypeSerializer.CreateInstance(ISerializationContext context); // 0x000000018CB90B34-0x000000018CB90B54
		public void Callback(object value, TypeModel.CallbackType callbackType, ISerializationContext context); // 0x000000018CB90AEC-0x000000018CB90B14
		public static ICompiledSerializer Wrap(IProtoTypeSerializer head, RuntimeTypeModel model); // 0x000000018CB90D1C-0x000000018CB913EC
		public abstract void Write(ref ProtoWriter.State state, object value);
		public abstract object Read(ref ProtoReader.State state, object value);
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB90C9C-0x000000018CB90CBC
		void IProtoTypeSerializer.EmitWriteRoot(CompilerContext ctx, Local valueFrom); // 0x000000018CB90BBC-0x000000018CB90BDC
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local valueFrom); // 0x000000018CB90C7C-0x000000018CB90C9C
		void IProtoTypeSerializer.EmitReadRoot(CompilerContext ctx, Local valueFrom); // 0x000000018CB90B9C-0x000000018CB90BBC
		void IProtoTypeSerializer.EmitCallback(CompilerContext ctx, Local valueFrom, TypeModel.CallbackType callbackType); // 0x000000018CB90B54-0x000000018CB90B7C
		void IProtoTypeSerializer.EmitCreateInstance(CompilerContext ctx, bool callNoteObject); // 0x000000018CB90B7C-0x000000018CB90B9C
	}

	internal sealed class DateTimeSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80759
	{
		// Fields
		private static readonly System.Type expectedType; // 0x00
		private static DateTimeSerializer s_Timestamp; // 0x08
		private readonly bool _includeKind; // 0x10
		private readonly bool _useTimestamp; // 0x11
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public System.Type ExpectedType { get; } // 0x000000018CB918E8-0x000000018CB91938 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private DateTimeSerializer(bool useTimestamp, bool includeKind); // 0x0000000187254CA0-0x0000000187254CB0
		static DateTimeSerializer(); // 0x000000018CB91868-0x000000018CB918E8
	
		// Methods
		public static DateTimeSerializer Create(CompatibilityLevel compatibilityLevel, TypeModel model); // 0x000000018CB9142C-0x000000018CB91508
		public object Read(ref ProtoReader.State state, object value); // 0x000000018CB916C8-0x000000018CB9174C
		public void Write(ref ProtoWriter.State state, object value); // 0x000000018CB9174C-0x000000018CB91868
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB915DC-0x000000018CB916C8
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB91508-0x000000018CB915DC
	}

	internal sealed class DecimalSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80761
	{
		// Fields
		private static DecimalSerializer s_BclDecimal; // 0x00
		private static DecimalSerializer s_String; // 0x08
		private readonly Variant _variant; // 0x10
		private static readonly System.Type expectedType; // 0x10
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x000000018B3F5DF0-0x000000018B3F5DF8 
		public System.Type ExpectedType { get; } // 0x000000018CB91D80-0x000000018CB91DD0 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Nested types
		private enum Variant // TypeDefIndex: 80760
		{
			BclDecimal = 0,
			String = 1
		}
	
		// Constructors
		private DecimalSerializer(Variant variant); // 0x0000000182234E90-0x0000000182234EA0
		static DecimalSerializer(); // 0x000000018CB91CF8-0x000000018CB91D80
	
		// Methods
		public static DecimalSerializer Create(CompatibilityLevel compatibilityLevel); // 0x000000018CB91938-0x000000018CB91A2C
		public object Read(ref ProtoReader.State state, object value); // 0x000000018CB91BB4-0x000000018CB91C44
		public void Write(ref ProtoWriter.State state, object value); // 0x000000018CB91C44-0x000000018CB91CF8
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB91AE4-0x000000018CB91BB4
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB91A2C-0x000000018CB91AE4
	}

	internal sealed class DefaultValueDecorator : ProtoDecoratorBase // TypeDefIndex: 80762
	{
		// Fields
		private readonly object defaultValue; // 0x18
	
		// Properties
		public override System.Type ExpectedType { get; } // 0x000000018CB913EC-0x000000018CB9140C 
		public override bool RequiresOldValue { get; } // 0x00000001854DD000-0x00000001854DD020 
		public override bool ReturnsValue { get; } // 0x00000001862AF4D0-0x00000001862AF4F0 
	
		// Constructors
		public DefaultValueDecorator(object defaultValue, IRuntimeProtoSerializerNode tail); // 0x0000000185E077B0-0x0000000185E07870
	
		// Methods
		public override void Write(ref ProtoWriter.State state, object value); // 0x0000000184FF5AF0-0x0000000184FF5B60
		public override object Read(ref ProtoReader.State state, object value); // 0x0000000185C68910-0x0000000185C68930
		protected override void EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB927C8-0x000000018CB92804
		private static void EmitBeq(CompilerContext ctx, CodeLabel label, System.Type type); // 0x000000018CB91DD0-0x000000018CB91FAC
		private void EmitBranchIfDefaultValue(CompilerContext ctx, CodeLabel label); // 0x000000018CB91FAC-0x000000018CB927AC
		protected override void EmitRead(CompilerContext ctx, Local valueFrom); // 0x000000018CB927AC-0x000000018CB927C8
	}

	internal sealed class DoubleSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80763
	{
		// Fields
		internal static readonly DoubleSerializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB928BC-0x000000018CB9290C 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private DoubleSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static DoubleSerializer(); // 0x00000001870E1CA0-0x00000001870E1D80
	
		// Methods
		public object Read(ref ProtoReader.State state, object value); // 0x0000000185F5A0D0-0x0000000185F5A1E0
		public void Write(ref ProtoWriter.State state, object value); // 0x00000001861EFCA0-0x00000001861EFD10
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB92850-0x000000018CB928BC
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB92804-0x000000018CB92850
	}

	internal interface IEnumMemberSerializerAdapter // TypeDefIndex: 80764
	{
		// Methods
		object Read(ref ProtoReader.State state, object value);
		void Write(ref ProtoWriter.State state, object value);
	}

	internal static class EnumMemberSerializerRegistry // TypeDefIndex: 80766
	{
		// Fields
		private static readonly object s_sync; // 0x00
		private static readonly Dictionary<System.Type, IEnumMemberSerializerAdapter> s_adapters; // 0x08
	
		// Nested types
		private sealed class Adapter<TEnum> : IEnumMemberSerializerAdapter // TypeDefIndex: 80765
			where TEnum : struct
		{
			// Fields
			private readonly EnumSerializer<TEnum> serializer;
	
			// Constructors
			public Adapter(EnumSerializer<TEnum> serializer);
	
			// Methods
			public object Read(ref ProtoReader.State state, object value);
			public void Write(ref ProtoWriter.State state, object value);
		}
	
		// Constructors
		static EnumMemberSerializerRegistry(); // 0x00000001870A9280-0x00000001870A9360
	
		// Methods
		public static void Register<TEnum>(EnumSerializer<TEnum> serializer)
			where TEnum : struct;
		public static IEnumMemberSerializerAdapter TryGet(System.Type enumType); // 0x00000001864A50F0-0x00000001864A5390
	}

	internal class EnumMemberSerializer : IRuntimeProtoSerializerNode, IDirectWriteNode // TypeDefIndex: 80767
	{
		// Fields
		private readonly IRuntimeProtoSerializerNode _tail; // 0x10
		private readonly IEnumMemberSerializerAdapter _adapter; // 0x18
		[CompilerGenerated]
		private readonly System.Type _ExpectedType_k__BackingField; // 0x20
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		public EnumMemberSerializer(System.Type enumType); // 0x00000001864A4F40-0x00000001864A50F0
	
		// Methods
		internal static object EnumToWire(object value, System.Type type); // 0x00000001854C4AB0-0x00000001854C4BE0
		private object EnumToWire(object value); // 0x00000001854C4BE0-0x00000001854C4C00
		public object Read(ref ProtoReader.State state, object value); // 0x0000000185EC24A0-0x0000000185EC2570
		public void Write(ref ProtoWriter.State state, object value); // 0x00000001854C5980-0x00000001854C5A00
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB90C9C-0x000000018CB90CBC
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB90C7C-0x000000018CB90C9C
		bool IDirectWriteNode.CanEmitDirectWrite(WireType wireType); // 0x000000018CB9290C-0x000000018CB92968
		void IDirectWriteNode.EmitDirectWrite(int fieldNumber, WireType wireType, CompilerContext ctx, Local valueFrom); // 0x000000018CB92968-0x000000018CB92A00
	}

	internal class ExternalSerializer // TypeDefIndex: 80768
	{
		// Constructors
		public ExternalSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal static IProtoTypeSerializer Create(System.Type target, System.Type serializer); // 0x000000018CB92A00-0x000000018CB92B14
	}

	internal interface IExternalSerializer // TypeDefIndex: 80769
	{
		// Properties
		object Service { get; }
	}

	internal sealed class ExternalSerializer<TProvider, T> : IExternalSerializer, ICompiledSerializer, IProtoTypeSerializer // TypeDefIndex: 80770
		where TProvider : class
	{
		// Properties
		object IExternalSerializer.Service { get; }
		private static ISerializer<T> Serializer { get; }
		public System.Type ExpectedType { get; }
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; }
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; }
		SerializerFeatures IProtoTypeSerializer.Features { get; }
		bool IRuntimeProtoSerializerNode.IsScalar { get; }
		System.Type IProtoTypeSerializer.BaseType { get; }
		bool IProtoTypeSerializer.ShouldEmitCreateInstance { get; }
		bool IProtoTypeSerializer.HasInheritance { get; }
		bool IProtoTypeSerializer.IsSubType { get; }
	
		// Constructors
		public ExternalSerializer();
	
		// Methods
		void IRuntimeProtoSerializerNode.Write(ref ProtoWriter.State state, object value);
		object IRuntimeProtoSerializerNode.Read(ref ProtoReader.State state, object value);
		bool IProtoTypeSerializer.CanCreateInstance();
		object IProtoTypeSerializer.CreateInstance(ISerializationContext context);
		void IProtoTypeSerializer.Callback(object value, TypeModel.CallbackType callbackType, ISerializationContext context);
		bool IProtoTypeSerializer.HasCallbacks(TypeModel.CallbackType callbackType);
		void IProtoTypeSerializer.EmitCreateInstance(CompilerContext ctx, bool callNoteObject);
		void IProtoTypeSerializer.EmitCallback(CompilerContext ctx, Local valueFrom, TypeModel.CallbackType callbackType);
		void IProtoTypeSerializer.EmitReadRoot(CompilerContext ctx, Local entity);
		void IProtoTypeSerializer.EmitWriteRoot(CompilerContext ctx, Local entity);
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom);
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity);
	}

	internal sealed class FieldDecorator : ProtoDecoratorBase // TypeDefIndex: 80771
	{
		// Fields
		[CompilerGenerated]
		private readonly System.Type _ExpectedType_k__BackingField; // 0x18
		private readonly System.Reflection.FieldInfo field; // 0x20
	
		// Properties
		public override System.Type ExpectedType { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
		public override bool RequiresOldValue { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override bool ReturnsValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public FieldDecorator(System.Type forType, System.Reflection.FieldInfo field, IRuntimeProtoSerializerNode tail); // 0x000000018CB93AEC-0x000000018CB93BB8
	
		// Methods
		public override void Write(ref ProtoWriter.State state, object value); // 0x000000018CB93A9C-0x000000018CB93AEC
		public override object Read(ref ProtoReader.State state, object value); // 0x000000018CB93A04-0x000000018CB93A9C
		protected override void EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB939A4-0x000000018CB93A04
		protected override void EmitRead(CompilerContext ctx, Local valueFrom); // 0x000000018CB92B14-0x000000018CB939A4
	}

	internal sealed class GuidSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80773
	{
		// Fields
		private readonly Variant _variant; // 0x10
		private static GuidSerializer s_Legacy; // 0x00
		private static GuidSerializer s_String; // 0x08
		private static GuidSerializer s_Bytes; // 0x10
		private static readonly System.Type expectedType; // 0x18
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x000000018CB93EDC-0x000000018CB93EEC 
		public System.Type ExpectedType { get; } // 0x000000018CB940EC-0x000000018CB9413C 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Nested types
		private enum Variant // TypeDefIndex: 80772
		{
			BclGuid = 0,
			GuidString = 1,
			GuidBytes = 2
		}
	
		// Constructors
		private GuidSerializer(Variant variant); // 0x0000000182234E90-0x0000000182234EA0
		static GuidSerializer(); // 0x000000018CB94064-0x000000018CB940EC
	
		// Methods
		internal static GuidSerializer Create(CompatibilityLevel compatibilityLevel, ProtoBuf.DataFormat dataFormat); // 0x000000018CB93BB8-0x000000018CB93D1C
		public void Write(ref ProtoWriter.State state, object value); // 0x000000018CB93F88-0x000000018CB94064
		public object Read(ref ProtoReader.State state, object value); // 0x000000018CB93EEC-0x000000018CB93F88
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB93DF0-0x000000018CB93EDC
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB93D1C-0x000000018CB93DF0
	}

	internal interface IDirectWriteNode // TypeDefIndex: 80774
	{
		// Methods
		bool CanEmitDirectWrite(WireType wireType);
		void EmitDirectWrite(int fieldNumber, WireType wireType, CompilerContext ctx, Local valueFrom);
	}

	internal interface IDirectRuntimeWriteNode // TypeDefIndex: 80775
	{
		// Methods
		bool CanDirectWrite(WireType wireType);
		void DirectWrite(int fieldNumber, WireType wireType, ref ProtoWriter.State state, object value);
	}

	internal sealed class Int16Serializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80776
	{
		// Fields
		internal static readonly Int16Serializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB9435C-0x000000018CB943AC 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private Int16Serializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static Int16Serializer(); // 0x000000018CB94298-0x000000018CB9435C
	
		// Methods
		public object Read(ref ProtoReader.State state, object value); // 0x000000018CB941F4-0x000000018CB94244
		public void Write(ref ProtoWriter.State state, object value); // 0x000000018CB94244-0x000000018CB94298
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB94188-0x000000018CB941F4
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB9413C-0x000000018CB94188
	}

	internal sealed class Int32Serializer : IRuntimeProtoSerializerNode, IDirectWriteNode // TypeDefIndex: 80777
	{
		// Fields
		internal static readonly Int32Serializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB94588-0x000000018CB945D8 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private Int32Serializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static Int32Serializer(); // 0x00000001870E1BC0-0x00000001870E1CA0
	
		// Methods
		public object Read(ref ProtoReader.State state, object value); // 0x00000001854C9C00-0x00000001854CA1A0
		public void Write(ref ProtoWriter.State state, object value); // 0x0000000184FF4330-0x0000000184FF45E0
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB9451C-0x000000018CB94588
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB944D0-0x000000018CB9451C
		bool IDirectWriteNode.CanEmitDirectWrite(WireType wireType); // 0x0000000186B3D980-0x0000000186B3D990
		void IDirectWriteNode.EmitDirectWrite(int fieldNumber, WireType wireType, CompilerContext ctx, Local valueFrom); // 0x000000018CB943AC-0x000000018CB944D0
	}

	internal sealed class Int64Serializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80778
	{
		// Fields
		internal static readonly Int64Serializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB94690-0x000000018CB946E0 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private Int64Serializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static Int64Serializer(); // 0x00000001870E1AE0-0x00000001870E1BC0
	
		// Methods
		public object Read(ref ProtoReader.State state, object value); // 0x0000000185F5A1E0-0x0000000185F5A3D0
		public void Write(ref ProtoWriter.State state, object value); // 0x00000001854C5410-0x00000001854C5480
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB94624-0x000000018CB94690
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB945D8-0x000000018CB94624
	}

	internal sealed class IntPtrSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80779
	{
		// Fields
		internal static readonly IntPtrSerializer Instance; // 0x00
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB948A8-0x000000018CB948F8 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private IntPtrSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static IntPtrSerializer(); // 0x000000018CB94844-0x000000018CB948A8
	
		// Methods
		public void Write(ref ProtoWriter.State state, object value); // 0x000000018CB947F0-0x000000018CB94844
		public object Read(ref ProtoReader.State state, object value); // 0x000000018CB947A4-0x000000018CB947F0
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB94738-0x000000018CB947A4
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB946E0-0x000000018CB94738
	}

	internal interface IRuntimeProtoSerializerNode // TypeDefIndex: 80780
	{
		// Properties
		bool IsScalar { get; }
		System.Type ExpectedType { get; }
		bool RequiresOldValue { get; }
		bool ReturnsValue { get; }
	
		// Methods
		void Write(ref ProtoWriter.State state, object value);
		object Read(ref ProtoReader.State state, object value);
		void EmitWrite(CompilerContext ctx, Local valueFrom);
		void EmitRead(CompilerContext ctx, Local entity);
	}

	internal interface IProtoTypeSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80781
	{
		// Properties
		System.Type BaseType { get; }
		bool ShouldEmitCreateInstance { get; }
		bool HasInheritance { get; }
		bool IsSubType { get; }
		SerializerFeatures Features { get; }
	
		// Methods
		bool HasCallbacks(TypeModel.CallbackType callbackType);
		bool CanCreateInstance();
		object CreateInstance(ISerializationContext context);
		void Callback(object value, TypeModel.CallbackType callbackType, ISerializationContext context);
		void EmitCallback(CompilerContext ctx, Local valueFrom, TypeModel.CallbackType callbackType);
		void EmitCreateInstance(CompilerContext ctx, bool callNoteObject = true /* Metadata: 0x0263D19C */);
		void EmitReadRoot(CompilerContext ctx, Local entity);
		void EmitWriteRoot(CompilerContext ctx, Local entity);
	}

	internal interface ISerializerProxy // TypeDefIndex: 80782
	{
		// Properties
		IRuntimeProtoSerializerNode Serializer { get; }
	}

	internal static class MapDecorator // TypeDefIndex: 80783
	{
		// Methods
		public static IRuntimeProtoSerializerNode Create(RepeatedSerializerStub provider, System.Type keyType, System.Type valueType, int fieldNumber, SerializerFeatures features, SerializerFeatures keyFeatures, CompatibilityLevel keyCompatibilityLevel, ProtoBuf.DataFormat keyDataFormat, SerializerFeatures valueFeatures, CompatibilityLevel valueCompatibilityLevel, ProtoBuf.DataFormat valueDataFormat); // 0x00000001854EBCC0-0x00000001854EC080
	}

	internal class MapDecorator<TCollection, TKey, TValue> : IRuntimeProtoSerializerNode, ICompiledSerializer // TypeDefIndex: 80784
	{
		// Fields
		private readonly int _fieldNumber;
		private readonly SerializerFeatures _features;
		private readonly SerializerFeatures _keyFeatures;
		private readonly SerializerFeatures _valueFeatures;
		private readonly CompatibilityLevel _keyCompatibilityLevel;
		private readonly CompatibilityLevel _valueCompatibilityLevel;
		private readonly ProtoBuf.DataFormat _keyDataFormat;
		private readonly ProtoBuf.DataFormat _valueDataFormat;
		private readonly RepeatedSerializerStub _provider;
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; }
		private MapSerializer<TCollection, TKey, TValue> Serializer { get; }
		public System.Type ExpectedType { get; }
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; }
		public bool RequiresOldValue { get; }
	
		// Constructors
		public MapDecorator(int fieldNumber, SerializerFeatures features, SerializerFeatures keyFeatures, CompatibilityLevel keyCompatibilityLevel, ProtoBuf.DataFormat keyDataFormat, SerializerFeatures valueFeatures, CompatibilityLevel valueCompatibilityLevel, ProtoBuf.DataFormat valueDataFormat, RepeatedSerializerStub provider);
	
		// Methods
		public object Read(ref ProtoReader.State state, object value);
		public void Write(ref ProtoWriter.State state, object value);
		public void EmitWrite(CompilerContext ctx, Local valueFrom);
		public void EmitRead(CompilerContext ctx, Local valueFrom);
	}

	public interface IMemberSpecifiedAccessor // TypeDefIndex: 80785
	{
		// Methods
		bool IsSpecified(string methodName);
	}

	internal sealed class MemberSpecifiedDecorator : ProtoDecoratorBase // TypeDefIndex: 80786
	{
		// Fields
		private readonly MethodInfo getSpecified; // 0x18
		private readonly MethodInfo setSpecified; // 0x20
		private readonly string getSpecifiedName; // 0x28
		private readonly bool useMemberSpecifiedAccessor; // 0x30
	
		// Properties
		public override System.Type ExpectedType { get; } // 0x0000000185E076B0-0x0000000185E076D0 
		public override bool RequiresOldValue { get; } // 0x000000018CB90CDC-0x000000018CB90CFC 
		public override bool ReturnsValue { get; } // 0x00000001862AF4D0-0x00000001862AF4F0 
	
		// Constructors
		public MemberSpecifiedDecorator(MethodInfo getSpecified, MethodInfo setSpecified, IRuntimeProtoSerializerNode tail); // 0x0000000186435840-0x0000000186435960
	
		// Methods
		public override void Write(ref ProtoWriter.State state, object value); // 0x0000000184FF65B0-0x0000000184FF66C0
		public override object Read(ref ProtoReader.State state, object value); // 0x0000000186165340-0x00000001861653D0
		protected override void EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB94A64-0x000000018CB94BAC
		protected override void EmitRead(CompilerContext ctx, Local valueFrom); // 0x000000018CB948F8-0x000000018CB94A64
	}

	internal sealed class ParseableSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80787
	{
		// Fields
		private readonly MethodInfo parse; // 0x10
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018C968AFC-0x000000018C968B20 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private ParseableSerializer(MethodInfo parse); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ParseableSerializer TryCreate(System.Type type); // 0x000000018CB94E90-0x000000018CB95080
		private static MethodInfo GetCustomToString(System.Type type); // 0x000000018CB94BAC-0x000000018CB94C3C
		public object Read(ref ProtoReader.State state, object value); // 0x000000018CB94DF4-0x000000018CB94E90
		public void Write(ref ProtoWriter.State state, object value); // 0x000000018CB95080-0x000000018CB950B8
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB94CA8-0x000000018CB94DF4
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB94C3C-0x000000018CB94CA8
	}

	public interface IProtoPropertyAccessor // TypeDefIndex: 80788
	{
		// Methods
		object GetValue(int fieldNumber, bool forRead);
		void SetValue(int fieldNumber, object value);
	}

	public interface IValueTypePropertyAccessor // TypeDefIndex: 80789
	{
		// Methods
		object GetBoxedValue(int fieldNumber, bool forRead);
		void SetBoxedValue(int fieldNumber, object value);
	}

	public static class ValueTypeBox // TypeDefIndex: 80790
	{
		// Methods
		public static bool IsCompatible<T>(object box)
			where T : struct;
		public static object Get<T>(T value)
			where T : struct;
		public static object GetRead<T>(T value)
			where T : struct;
		public static T GetValue<T>(object box)
			where T : struct;
		public static object Set<T>(object box, T value)
			where T : struct;
		public static void Warmup<T>()
			where T : struct;
	}

	internal sealed class ValueTypeReadBox<T> // TypeDefIndex: 80791
		where T : struct
	{
		// Fields
		public T Value;
	
		// Constructors
		public ValueTypeReadBox();
	}

	internal static class ValueTypeBox<T> // TypeDefIndex: 80792
		where T : struct
	{
		// Fields
		[ThreadStatic]
		private static object s_box;
		[ThreadStatic]
		private static ValueTypeReadBox<T> s_readBox;
	
		// Methods
		public static object Get(T value);
		public static object GetRead(T value);
		public static void Warmup();
		public static object Set(object box, T value);
	}

	internal sealed class PropertyDecorator : ProtoDecoratorBase // TypeDefIndex: 80793
	{
		// Fields
		[CompilerGenerated]
		private readonly System.Type _ExpectedType_k__BackingField; // 0x18
		private readonly PropertyInfo property; // 0x20
		private readonly bool usePropertyAccessor; // 0x28
		private readonly bool useValueTypeAccessor; // 0x29
		private readonly int propertyFieldNumber; // 0x2C
		private readonly bool readOptionsWriteValue; // 0x30
		private readonly MethodInfo shadowSetter; // 0x38
	
		// Properties
		public override System.Type ExpectedType { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
		public override bool RequiresOldValue { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override bool ReturnsValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public PropertyDecorator(System.Type forType, PropertyInfo property, IRuntimeProtoSerializerNode tail); // 0x0000000184FD4BC0-0x0000000184FD4E60
	
		// Methods
		private static void SanityCheck(PropertyInfo property, IRuntimeProtoSerializerNode tail, out bool writeValue, bool nonPublic, bool allowInternal); // 0x00000001855B5CA0-0x00000001855B5DD0
		private static MethodInfo GetShadowSetter(PropertyInfo property); // 0x0000000185370300-0x0000000185370550
		public override void Write(ref ProtoWriter.State state, object value); // 0x0000000184FF66C0-0x0000000184FF7E00
		public override object Read(ref ProtoReader.State state, object value); // 0x0000000184FF9980-0x0000000184FF9E80
		protected override void EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB95684-0x000000018CB956E0
		internal static System.Type ChooseReadLocalType(System.Type memberType, System.Type tailType); // 0x000000018CB950B8-0x000000018CB95180
		protected override void EmitRead(CompilerContext ctx, Local valueFrom); // 0x000000018CB95180-0x000000018CB95684
	}

	internal abstract class ProtoDecoratorBase : IRuntimeProtoSerializerNode // TypeDefIndex: 80794
	{
		// Fields
		protected readonly IRuntimeProtoSerializerNode Tail; // 0x10
	
		// Properties
		public virtual bool IsScalar { get; } // 0x000000018CB90CBC-0x000000018CB90CDC 
		public abstract System.Type ExpectedType { get; }
		public abstract bool ReturnsValue { get; }
		public abstract bool RequiresOldValue { get; }
	
		// Constructors
		protected ProtoDecoratorBase(IRuntimeProtoSerializerNode tail); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public abstract void Write(ref ProtoWriter.State state, object value);
		public abstract object Read(ref ProtoReader.State state, object value);
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB956F8-0x000000018CB95710
		protected abstract void EmitWrite(CompilerContext ctx, Local valueFrom);
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB956E0-0x000000018CB956F8
		protected abstract void EmitRead(CompilerContext ctx, Local valueFrom);
	}

	internal static class RepeatedDecorator // TypeDefIndex: 80795
	{
		// Methods
		public static IRuntimeProtoSerializerNode Create(RepeatedSerializerStub stub, int fieldNumber, SerializerFeatures features, CompatibilityLevel compatibilityLevel, ProtoBuf.DataFormat dataFormat); // 0x00000001854EC140-0x00000001854EC440
		internal static IRepeatedSerializer<T> GetSerializer<T>(MemberInfo original);
	}

	internal sealed class RepeatedDecorator<TCollection, T> : IRuntimeProtoSerializerNode, ICompiledSerializer // TypeDefIndex: 80796
	{
		// Fields
		private readonly int _fieldNumber;
		private readonly SerializerFeatures _features;
		private readonly CompatibilityLevel _compatibilityLevel;
		private readonly ProtoBuf.DataFormat _dataFormat;
		private readonly RepeatedSerializerStub _stub;
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; }
		private RepeatedSerializer<TCollection, T> Serializer { get; }
		public System.Type ExpectedType { get; }
		public bool RequiresOldValue { get; }
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; }
	
		// Constructors
		public RepeatedDecorator(int fieldNumber, SerializerFeatures features, CompatibilityLevel compatibilityLevel, ProtoBuf.DataFormat dataFormat, RepeatedSerializerStub stub);
	
		// Methods
		public object Read(ref ProtoReader.State state, object value);
		public void EmitRead(CompilerContext ctx, Local valueFrom);
		public void Write(ref ProtoWriter.State state, object value);
		public void EmitWrite(CompilerContext ctx, Local valueFrom);
	}

	internal sealed class SByteSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80797
	{
		// Fields
		internal static readonly SByteSerializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB95930-0x000000018CB95980 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private SByteSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static SByteSerializer(); // 0x000000018CB9586C-0x000000018CB95930
	
		// Methods
		public object Read(ref ProtoReader.State state, object value); // 0x000000018CB957C8-0x000000018CB95818
		public void Write(ref ProtoWriter.State state, object value); // 0x000000018CB95818-0x000000018CB9586C
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB9575C-0x000000018CB957C8
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB95710-0x000000018CB9575C
	}

	internal sealed class SingleSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80798
	{
		// Fields
		internal static readonly SingleSerializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB95A38-0x000000018CB95A88 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private SingleSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static SingleSerializer(); // 0x00000001870E1920-0x00000001870E1A00
	
		// Methods
		public object Read(ref ProtoReader.State state, object value); // 0x00000001860FEDC0-0x00000001860FEEE0
		public void Write(ref ProtoWriter.State state, object value); // 0x0000000185E6B540-0x0000000185E6B7E0
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB959CC-0x000000018CB95A38
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB95980-0x000000018CB959CC
	}

	internal sealed class StringSerializer : IRuntimeProtoSerializerNode, IDirectWriteNode // TypeDefIndex: 80799
	{
		// Fields
		internal static readonly StringSerializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB95D6C-0x000000018CB95DBC 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private StringSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static StringSerializer(); // 0x00000001870E1840-0x00000001870E1920
	
		// Methods
		public void Write(ref ProtoWriter.State state, object value); // 0x00000001860A4A40-0x00000001860A4AD0
		public object Read(ref ProtoReader.State state, object value); // 0x0000000185DA2D50-0x0000000185DA3310
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB95C30-0x000000018CB95D6C
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB95BC4-0x000000018CB95C30
		bool IDirectWriteNode.CanEmitDirectWrite(WireType wireType); // 0x000000018B855354-0x000000018B85535C
		void IDirectWriteNode.EmitDirectWrite(int fieldNumber, WireType wireType, CompilerContext ctx, Local valueFrom); // 0x000000018CB95A88-0x000000018CB95BC4
	}

	internal sealed class SubTypeSerializer<TParent, TChild> : SubItemSerializer, IDirectWriteNode // TypeDefIndex: 80801
		where TParent : class
		where TChild : class, TParent
	{
		// Fields
		private static readonly Dictionary<int, MethodInfo> s_WriteSubType;
	
		// Properties
		public override bool IsSubType { get; }
		public override System.Type ExpectedType { get; }
		public override System.Type BaseType { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80800
		{
			// Fields
			public static readonly __c<TParent, TChild> __9;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _.cctor_b__14_0(MethodInfo method);
			internal __f__AnonymousType3<int, MethodInfo> _.cctor_b__14_1(MethodInfo method);
			internal int _.cctor_b__14_2(__f__AnonymousType3<int, MethodInfo> x);
			internal MethodInfo _.cctor_b__14_3(__f__AnonymousType3<int, MethodInfo> x);
		}
	
		// Constructors
		public SubTypeSerializer();
		static SubTypeSerializer();
	
		// Methods
		public override void Write(ref ProtoWriter.State state, object value);
		public override object Read(ref ProtoReader.State state, object value);
		public override void EmitWrite(CompilerContext ctx, Local valueFrom);
		bool IDirectWriteNode.CanEmitDirectWrite(WireType wireType);
		void IDirectWriteNode.EmitDirectWrite(int fieldNumber, WireType wireType, CompilerContext ctx, Local valueFrom);
		public override void EmitRead(CompilerContext ctx, Local valueFrom);
	}

	internal class SubValueSerializer<T> : SubItemSerializer, IDirectWriteNode // TypeDefIndex: 80802
	{
		// Fields
		private ISerializer<T> _customSerializer;
	
		// Properties
		public override bool IsSubType { get; }
		public override System.Type ExpectedType { get; }
		private ISerializer<T> CustomSerializer { get; }
	
		// Constructors
		public SubValueSerializer();
	
		// Methods
		private ISerializer<T> CreateExternal();
		public override void Write(ref ProtoWriter.State state, object value);
		private SerializerFeatures GetCategory();
		public override object Read(ref ProtoReader.State state, object value);
		protected override WireType GetDefaultWireType(ref ProtoBuf.DataFormat dataFormat);
		public override void EmitWrite(CompilerContext ctx, Local valueFrom);
		public override void EmitRead(CompilerContext ctx, Local valueFrom);
		bool IDirectWriteNode.CanEmitDirectWrite(WireType wireType);
		void IDirectWriteNode.EmitDirectWrite(int fieldNumber, WireType wireType, CompilerContext ctx, Local valueFrom);
	}

	internal abstract class SubItemSerializer : IProtoTypeSerializer // TypeDefIndex: 80804
	{
		// Fields
		private static readonly Dictionary<int, MethodInfo> s_WriteMessage; // 0x00
		private static readonly Dictionary<int, MethodInfo> s_WriteGroup; // 0x08
		private static readonly MethodInfo s_ReadMessage; // 0x10
		[CompilerGenerated]
		private MetaType _MetaType_k__BackingField; // 0x10
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001843FFFF0-0x0000000184400000 
		SerializerFeatures IProtoTypeSerializer.Features { get; } // 0x000000018CB962F8-0x000000018CB96328 
		public abstract bool IsSubType { get; }
		public abstract System.Type ExpectedType { get; }
		public virtual System.Type BaseType { get; } // 0x000000018CB9638C-0x000000018CB9639C 
		bool IProtoTypeSerializer.HasInheritance { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IProtoTypeSerializer.ShouldEmitCreateInstance { get; } // 0x000000018CB96328-0x000000018CB9638C 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001851A4410-0x00000001851A4420 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
		protected ISerializerProxy Proxy { get; } // 0x00000001829260F0-0x0000000182926100 
		protected MetaType MetaType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80803
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x00000001871E5F60-0x00000001871E5FC0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _.cctor_b__47_0(MethodInfo method); // 0x0000000186A6C1F0-0x0000000186A6C280
			internal __f__AnonymousType3<int, MethodInfo> _.cctor_b__47_1(MethodInfo method); // 0x0000000186EC9340-0x0000000186EC93D0
			internal int _.cctor_b__47_2(__f__AnonymousType3<int, MethodInfo> x); // 0x00000001860B51F0-0x00000001860B5230
			internal MethodInfo _.cctor_b__47_3(__f__AnonymousType3<int, MethodInfo> x); // 0x00000001871EABE0-0x00000001871EAC20
			internal bool _.cctor_b__47_4(MethodInfo method); // 0x0000000186A71190-0x0000000186A71220
			internal __f__AnonymousType3<int, MethodInfo> _.cctor_b__47_5(MethodInfo method); // 0x0000000186EC92B0-0x0000000186EC9340
			internal int _.cctor_b__47_6(__f__AnonymousType3<int, MethodInfo> x); // 0x00000001860B5230-0x00000001860B5270
			internal MethodInfo _.cctor_b__47_7(__f__AnonymousType3<int, MethodInfo> x); // 0x0000000187213CA0-0x0000000187213CE0
			internal bool _.cctor_b__47_8(MethodInfo method); // 0x0000000186A5A410-0x0000000186A5A4C0
		}
	
		// Constructors
		protected SubItemSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static SubItemSerializer(); // 0x00000001867FCE00-0x00000001867FD330
	
		// Methods
		public abstract void Write(ref ProtoWriter.State state, object value);
		public abstract object Read(ref ProtoReader.State state, object value);
		public abstract void EmitWrite(CompilerContext ctx, Local valueFrom);
		public abstract void EmitRead(CompilerContext ctx, Local valueFrom);
		void IProtoTypeSerializer.EmitReadRoot(CompilerContext ctx, Local valueFrom); // 0x000000018CB96278-0x000000018CB96280
		void IProtoTypeSerializer.EmitWriteRoot(CompilerContext ctx, Local valueFrom); // 0x000000018CB96280-0x000000018CB96288
		bool IProtoTypeSerializer.HasCallbacks(TypeModel.CallbackType callbackType); // 0x000000018CB96288-0x000000018CB962F8
		bool IProtoTypeSerializer.CanCreateInstance(); // 0x000000018CB96060-0x000000018CB960C4
		void IProtoTypeSerializer.EmitCallback(CompilerContext ctx, Local valueFrom, TypeModel.CallbackType callbackType); // 0x000000018CB96144-0x000000018CB961E8
		void IProtoTypeSerializer.EmitCreateInstance(CompilerContext ctx, bool callNoteObject); // 0x000000018CB961E8-0x000000018CB96278
		void IProtoTypeSerializer.Callback(object value, TypeModel.CallbackType callbackType, ISerializationContext context); // 0x000000018CB95FBC-0x000000018CB96060
		object IProtoTypeSerializer.CreateInstance(ISerializationContext source); // 0x000000018CB960C4-0x000000018CB96144
		protected static void EmitLoadCustomSerializer(CompilerContext ctx, System.Type serializerType, System.Type forType); // 0x000000018CB95F50-0x000000018CB95FBC
		public static void EmitWriteMessage<T>(int? fieldNumber, WireType wireType, CompilerContext ctx, Local value = null, System.Reflection.FieldInfo serializer = null, bool applyRecursionCheck = true /* Metadata: 0x0263D19D */, System.Type serializerType = null);
		private static void LoadSerializer<T>(CompilerContext ctx, System.Reflection.FieldInfo serializer, System.Type serializerType);
		public static void EmitReadMessage<T>(CompilerContext ctx, Local value = null, System.Reflection.FieldInfo serializer = null, System.Type serializerType = null);
		internal static IRuntimeProtoSerializerNode Create(System.Type type, MetaType metaType, ref ProtoBuf.DataFormat dataFormat, out WireType defaultWireType); // 0x00000001854C26F0-0x00000001854C2850
		protected virtual WireType GetDefaultWireType(ref ProtoBuf.DataFormat dataFormat); // 0x00000001858920C0-0x00000001858920D0
		internal static IRuntimeProtoSerializerNode Create(System.Type actualType, MetaType metaType, System.Type parentType); // 0x000000018CB95DBC-0x000000018CB95F50
	}

	internal sealed class SurrogateSerializer<T> : IProtoTypeSerializer, ISerializer<T> // TypeDefIndex: 80805
	{
		// Fields
		private readonly System.Type declaredType;
		private readonly MethodInfo toTail;
		private readonly MethodInfo fromTail;
		private readonly IRuntimeProtoSerializerNode rootTail;
		private readonly SerializerFeatures features;
	
		// Properties
		public SerializerFeatures Features { get; }
		bool IProtoTypeSerializer.IsSubType { get; }
		bool IProtoTypeSerializer.ShouldEmitCreateInstance { get; }
		bool IRuntimeProtoSerializerNode.IsScalar { get; }
		public bool ReturnsValue { get; }
		public bool RequiresOldValue { get; }
		public System.Type ExpectedType { get; }
		System.Type IProtoTypeSerializer.BaseType { get; }
		bool IProtoTypeSerializer.HasInheritance { get; }
	
		// Constructors
		public SurrogateSerializer(System.Type declaredType, MethodInfo toTail, MethodInfo fromTail, IRuntimeProtoSerializerNode rootTail, SerializerFeatures features);
	
		// Methods
		bool IProtoTypeSerializer.HasCallbacks(TypeModel.CallbackType callbackType);
		void IProtoTypeSerializer.EmitCallback(CompilerContext ctx, Local valueFrom, TypeModel.CallbackType callbackType);
		void IProtoTypeSerializer.EmitCreateInstance(CompilerContext ctx, bool callNoteObject);
		bool IProtoTypeSerializer.CanCreateInstance();
		object IProtoTypeSerializer.CreateInstance(ISerializationContext source);
		void IProtoTypeSerializer.Callback(object value, TypeModel.CallbackType callbackType, ISerializationContext context);
		T ISerializer<T>.Read(ref ProtoReader.State state, T value);
		void ISerializer<T>.Write(ref ProtoWriter.State state, T value);
		private static bool HasCast(System.Type type, System.Type from, System.Type to, out MethodInfo op);
		public MethodInfo GetConversion(bool toTail);
		public void Write(ref ProtoWriter.State state, object value);
		public object Read(ref ProtoReader.State state, object value);
		void IProtoTypeSerializer.EmitReadRoot(CompilerContext ctx, Local valueFrom);
		void IProtoTypeSerializer.EmitWriteRoot(CompilerContext ctx, Local valueFrom);
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local valueFrom);
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom);
	}

	internal sealed class SystemTypeSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80806
	{
		// Fields
		internal static readonly SystemTypeSerializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB9656C-0x000000018CB965BC 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private SystemTypeSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static SystemTypeSerializer(); // 0x000000018CB964A8-0x000000018CB9656C
	
		// Methods
		void IRuntimeProtoSerializerNode.Write(ref ProtoWriter.State state, object value); // 0x000000018CB96454-0x000000018CB964A8
		object IRuntimeProtoSerializerNode.Read(ref ProtoReader.State state, object value); // 0x000000018CB8425C-0x000000018CB84264
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB963E8-0x000000018CB96454
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB9639C-0x000000018CB963E8
	}

	internal sealed class TagDecorator : ProtoDecoratorBase, IProtoTypeSerializer // TypeDefIndex: 80807
	{
		// Fields
		private readonly bool strict; // 0x18
		private readonly int fieldNumber; // 0x1C
		private readonly WireType wireType; // 0x20
	
		// Properties
		SerializerFeatures IProtoTypeSerializer.Features { get; } // 0x000000018CB96B04-0x000000018CB96B18 
		bool IProtoTypeSerializer.IsSubType { get; } // 0x000000018CB96B18-0x000000018CB96B68 
		bool IProtoTypeSerializer.ShouldEmitCreateInstance { get; } // 0x000000018CB96B68-0x000000018CB96BB8 
		public override System.Type ExpectedType { get; } // 0x0000000185E076B0-0x0000000185E076D0 
		System.Type IProtoTypeSerializer.BaseType { get; } // 0x000000018CB96AF4-0x000000018CB96B04 
		public override bool RequiresOldValue { get; } // 0x00000001854DD000-0x00000001854DD020 
		public override bool ReturnsValue { get; } // 0x00000001862AF4D0-0x00000001862AF4F0 
		private bool NeedsHint { get; } // 0x0000000185B57620-0x0000000185B57630 
		bool IProtoTypeSerializer.HasInheritance { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public TagDecorator(int fieldNumber, WireType wireType, bool strict, IRuntimeProtoSerializerNode tail); // 0x0000000184FD4A70-0x0000000184FD4AB0
	
		// Methods
		public bool HasCallbacks(TypeModel.CallbackType callbackType); // 0x000000018CB96A98-0x000000018CB96AF4
		public bool CanCreateInstance(); // 0x000000018CB9663C-0x000000018CB9668C
		public object CreateInstance(ISerializationContext source); // 0x000000018CB966DC-0x000000018CB96750
		public void Callback(object value, TypeModel.CallbackType callbackType, ISerializationContext context); // 0x000000018CB965BC-0x000000018CB9663C
		public void EmitCallback(CompilerContext ctx, Local valueFrom, TypeModel.CallbackType callbackType); // 0x000000018CB96750-0x000000018CB967E8
		public void EmitCreateInstance(CompilerContext ctx, bool callNoteObject); // 0x000000018CB967E8-0x000000018CB9686C
		public override object Read(ref ProtoReader.State state, object value); // 0x0000000185B575C0-0x0000000185B57620
		public override void Write(ref ProtoWriter.State state, object value); // 0x0000000184FF53B0-0x0000000184FF5690
		void IProtoTypeSerializer.EmitReadRoot(CompilerContext ctx, Local valueFrom); // 0x000000018CB956E0-0x000000018CB956F8
		void IProtoTypeSerializer.EmitWriteRoot(CompilerContext ctx, Local valueFrom); // 0x000000018CB956F8-0x000000018CB95710
		protected override void EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB969D0-0x000000018CB96A98
		public bool CanEmitDirectWrite(); // 0x000000018CB9668C-0x000000018CB966DC
		public void EmitDirectWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB9686C-0x000000018CB96910
		protected override void EmitRead(CompilerContext ctx, Local valueFrom); // 0x000000018CB96910-0x000000018CB969D0
	}

	internal sealed class TimeSpanSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80808
	{
		// Fields
		private static TimeSpanSerializer s_Legacy; // 0x00
		private static TimeSpanSerializer s_Duration; // 0x08
		private static readonly System.Type expectedType; // 0x10
		private readonly bool _useDuration; // 0x10
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public System.Type ExpectedType { get; } // 0x000000018CB97024-0x000000018CB97074 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private TimeSpanSerializer(bool useDuration); // 0x0000000182A819C0-0x0000000182A819D0
		static TimeSpanSerializer(); // 0x000000018CB96F9C-0x000000018CB97024
	
		// Methods
		public static TimeSpanSerializer Create(CompatibilityLevel compatibilityLevel); // 0x000000018CB96BB8-0x000000018CB96CA8
		public object Read(ref ProtoReader.State state, object value); // 0x000000018CB96E4C-0x000000018CB96ED0
		public void Write(ref ProtoWriter.State state, object value); // 0x000000018CB96ED0-0x000000018CB96F9C
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB96D7C-0x000000018CB96E4C
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB96CA8-0x000000018CB96D7C
	}

	internal sealed class TupleSerializer<T> : IProtoTypeSerializer, ISerializer<T> // TypeDefIndex: 80809
	{
		// Fields
		[CompilerGenerated]
		private SerializerFeatures _Features_k__BackingField;
		private readonly MemberInfo[] members;
		private readonly ConstructorInfo ctor;
		private readonly IRuntimeProtoSerializerNode[] tails;
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; }
		public SerializerFeatures Features { [CompilerGenerated] get; [CompilerGenerated] private set; }
		bool IProtoTypeSerializer.IsSubType { get; }
		public System.Type ExpectedType { get; }
		System.Type IProtoTypeSerializer.BaseType { get; }
		public bool RequiresOldValue { get; }
		public bool ReturnsValue { get; }
		bool IProtoTypeSerializer.ShouldEmitCreateInstance { get; }
		bool IProtoTypeSerializer.HasInheritance { get; }
	
		// Constructors
		public TupleSerializer(RuntimeTypeModel model, ConstructorInfo ctor, MemberInfo[] members, SerializerFeatures features, CompatibilityLevel compatibilityLevel);
	
		// Methods
		public bool HasCallbacks(TypeModel.CallbackType callbackType);
		public void EmitCallback(CompilerContext ctx, Local valueFrom, TypeModel.CallbackType callbackType);
		void IProtoTypeSerializer.Callback(object value, TypeModel.CallbackType callbackType, ISerializationContext context);
		object IProtoTypeSerializer.CreateInstance(ISerializationContext source);
		private object GetValue(object obj, int index);
		T ISerializer<T>.Read(ref ProtoReader.State state, T value);
		void ISerializer<T>.Write(ref ProtoWriter.State state, T value);
		public object Read(ref ProtoReader.State state, object value);
		public void Write(ref ProtoWriter.State state, object value);
		bool IProtoTypeSerializer.CanCreateInstance();
		private System.Type GetMemberType(int index);
		public void EmitWrite(CompilerContext ctx, Local valueFrom);
		void IProtoTypeSerializer.EmitCreateInstance(CompilerContext ctx, bool callNoteObject);
		void IProtoTypeSerializer.EmitReadRoot(CompilerContext ctx, Local valueFrom);
		void IProtoTypeSerializer.EmitWriteRoot(CompilerContext ctx, Local valueFrom);
		public void EmitRead(CompilerContext ctx, Local incoming);
	}

	internal abstract class TypeSerializer // TypeDefIndex: 80810
	{
		// Constructors
		protected TypeSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static IProtoTypeSerializer Create(System.Type forType, int[] fieldNumbers, IRuntimeProtoSerializerNode[] serializers, MethodInfo[] baseCtorCallbacks, bool isRootType, bool useConstructor, bool assertKnownType, CallbackSet callbacks, System.Type constructType, MethodInfo factory, System.Type rootType, SerializerFeatures features); // 0x000000018585AE50-0x000000018585B050
		internal abstract void Init(int[] fieldNumbers, IRuntimeProtoSerializerNode[] serializers, MethodInfo[] baseCtorCallbacks, bool isRootType, bool useConstructor, bool assertKnownType, CallbackSet callbacks, System.Type constructType, MethodInfo factory, SerializerFeatures features);
	}

	internal sealed class InheritanceTypeSerializer<TBase, T> : TypeSerializer<T>, ISubTypeSerializer<T> // TypeDefIndex: 80812
		where TBase : class
		where T : class, TBase
	{
		// Properties
		public override bool HasInheritance { get; }
		internal override System.Type BaseType { get; }
		public override bool IsSubType { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80811
		{
			// Fields
			public static readonly __c<TBase, T> __9;
			public static TypeSerializer<T, SubTypeState<T>> __9__6_0;
			public static TypeSerializer<T, SubTypeState<T>> __9__6_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal T _ProtoBuf.Serializers.ISubTypeSerializer_T_.ReadSubType_b__6_0(ref SubTypeState<T> s);
			internal void _ProtoBuf.Serializers.ISubTypeSerializer_T_.ReadSubType_b__6_1(ref SubTypeState<T> s, T v);
		}
	
		// Constructors
		public InheritanceTypeSerializer();
	
		// Methods
		public override void Write(ref ProtoWriter.State state, T value);
		public override T Read(ref ProtoReader.State state, T value);
		T ISubTypeSerializer<T>.ReadSubType(ref ProtoReader.State state, SubTypeState<T> value);
		void ISubTypeSerializer<T>.WriteSubType(ref ProtoWriter.State state, T value);
		public override void EmitReadRoot(CompilerContext context, Local valueFrom);
		public override void EmitWriteRoot(CompilerContext context, Local valueFrom);
	}

	internal class TypeSerializer<T> : TypeSerializer, ISerializer<T>, IFactory<T>, IProtoTypeSerializer // TypeDefIndex: 80817
	{
		// Fields
		private System.Type constructType;
		private IRuntimeProtoSerializerNode[] serializers;
		private int[] fieldNumbers;
		private StateFlags flags;
		private CallbackSet callbacks;
		private MethodInfo[] baseCtorCallbacks;
		private MethodInfo factory;
		[CompilerGenerated]
		private SerializerFeatures _Features_k__BackingField;
		protected Action<T, ISerializationContext> _subTypeOnBeforeDeserialize;
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; }
		public virtual bool HasInheritance { get; }
		public virtual bool IsSubType { get; }
		public System.Type ExpectedType { get; }
		internal virtual System.Type BaseType { get; }
		System.Type IProtoTypeSerializer.BaseType { get; }
		public SerializerFeatures Features { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private bool CanHaveInheritance { get; }
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; }
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; }
		private bool UseTypedExtensible { get; }
		bool IProtoTypeSerializer.ShouldEmitCreateInstance { get; }
	
		// Nested types
		private enum StateFlags // TypeDefIndex: 80813
		{
			None = 0,
			IsRootType = 1,
			HasConstructor = 2,
			UseConstructor = 4,
			IsExtensible = 8,
			IsTypedExtensible = 16,
			AssertKnownType = 32
		}
	
		protected delegate T StateGetter<TState>(ref ref TState state); // TypeDefIndex: 80814; 0x00000000-0x00000000
	
		protected delegate void StateSetter<TState>(ref ref TState state, T value); // TypeDefIndex: 80815; 0x00000000-0x00000000
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80816
		{
			// Fields
			public static readonly __c<T> __9;
			public static StateGetter<T, T> __9__8_0;
			public static StateSetter<T, T> __9__8_1;
			public static Func<IRuntimeProtoSerializerNode, bool> __9__55_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal T _Read_b__8_0(ref ref T o);
			internal void _Read_b__8_1(ref ref T o, T v);
			internal bool _ProtoBuf.Internal.Serializers.IRuntimeProtoSerializerNode.EmitWrite_b__55_0(IRuntimeProtoSerializerNode x);
		}
	
		// Constructors
		public TypeSerializer();
	
		// Methods
		public virtual void EmitReadRoot(CompilerContext context, Local valueFrom);
		public virtual void EmitWriteRoot(CompilerContext context, Local valueFrom);
		T IFactory<T>.Create(ISerializationContext context);
		public virtual void Write(ref ProtoWriter.State state, T value);
		public virtual T Read(ref ProtoReader.State state, T value);
		void IRuntimeProtoSerializerNode.Write(ref ProtoWriter.State state, object value);
		object IRuntimeProtoSerializerNode.Read(ref ProtoReader.State state, object value);
		public bool HasCallbacks(TypeModel.CallbackType callbackType);
		private void SetFlag(StateFlags flag, bool value);
		private bool GetFlag(StateFlags flag);
		internal override void Init(int[] fieldNumbers, IRuntimeProtoSerializerNode[] serializers, MethodInfo[] baseCtorCallbacks, bool isRootType, bool useConstructor, bool assertKnownType, CallbackSet callbacks, System.Type constructType, MethodInfo factory, SerializerFeatures features);
		bool IProtoTypeSerializer.CanCreateInstance();
		object IProtoTypeSerializer.CreateInstance(ISerializationContext context);
		void IProtoTypeSerializer.Callback(object value, TypeModel.CallbackType callbackType, ISerializationContext context);
		public void Callback(ref ref T value, TypeModel.CallbackType callbackType, ISerializationContext context);
		private IRuntimeProtoSerializerNode GetMoreSpecificSerializer(object value);
		protected void SerializeImpl(ref ProtoWriter.State state, T value);
		protected void DeserializeBody<TState>(ref ProtoReader.State state, ref ref TState bodyState, StateGetter<TState> getter, StateSetter<TState> setter);
		private object InvokeCallback(MethodInfo method, object obj, ISerializationContext serializationContext);
		private object CreateInstance(ISerializationContext context);
		private void LoadFromState(CompilerContext ctx, Local value);
		private void WriteToState(CompilerContext ctx, Local state, Local value, System.Type type);
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom);
		private static void EmitInvokeCallback(CompilerContext ctx, MethodInfo method, System.Type constructType, System.Type type, Local valueFrom);
		private void EmitCallbackIfNeeded(CompilerContext ctx, Local valueFrom, TypeModel.CallbackType callbackType);
		void IProtoTypeSerializer.EmitCallback(CompilerContext ctx, Local valueFrom, TypeModel.CallbackType callbackType);
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local valueFrom);
		private void WriteFieldHandler(CompilerContext ctx, System.Type expected, Local loc, CodeLabel handler, CodeLabel @continue, IRuntimeProtoSerializerNode serializer);
		void IProtoTypeSerializer.EmitCreateInstance(CompilerContext ctx, bool callNoteObject);
		private void EmitCreateIfNull(CompilerContext ctx, Local storage);
		[CompilerGenerated]
		private void _Init_b__34_0(T val, ISerializationContext ctx);
	}

	internal static class TypeSerializerMethodCache // TypeDefIndex: 80819
	{
		// Fields
		internal static readonly System.Type Type_IExtensible; // 0x00
		internal static readonly System.Type Type_ITypedIExtensible; // 0x08
		internal static readonly MethodInfo Method_Write_AppendExtensionData_IExtensible; // 0x10
		internal static readonly MethodInfo Method_Write_AppendExtensionData_ITypedExtensible; // 0x18
		internal static readonly MethodInfo Method_Read_AppendExtensionData_IExtensible; // 0x20
		internal static readonly MethodInfo Method_Read_AppendExtensionData_ITypedExtensible; // 0x28
		internal static readonly Dictionary<int, MethodInfo> ThrowUnexpectedSubtype; // 0x30
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80818
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x00000001871E6920-0x00000001871E6980
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _.cctor_b__7_0(MethodInfo method); // 0x0000000186D42840-0x0000000186D428B0
			internal bool _.cctor_b__7_1(MethodInfo method); // 0x000000018717AE40-0x000000018717AE70
			internal __f__AnonymousType0<MethodInfo, System.Type[]> _.cctor_b__7_2(MethodInfo method); // 0x0000000187083E10-0x0000000187083EB0
			internal __f__AnonymousType4<int, MethodInfo> _.cctor_b__7_3(__f__AnonymousType0<MethodInfo, System.Type[]> __h__TransparentIdentifier0); // 0x0000000186FC2500-0x0000000186FC25A0
			internal int _.cctor_b__7_4(__f__AnonymousType4<int, MethodInfo> x); // 0x00000001860B51B0-0x00000001860B51F0
			internal MethodInfo _.cctor_b__7_5(__f__AnonymousType4<int, MethodInfo> x); // 0x00000001871EABA0-0x00000001871EABE0
		}
	
		// Constructors
		static TypeSerializerMethodCache(); // 0x00000001867FBE00-0x00000001867FC510
	}

	internal class UInt16Serializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80820
	{
		// Fields
		internal static readonly UInt16Serializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public virtual System.Type ExpectedType { get; } // 0x000000018CB972C8-0x000000018CB97318 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		protected UInt16Serializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static UInt16Serializer(); // 0x000000018CB97204-0x000000018CB972C8
	
		// Methods
		public virtual object Read(ref ProtoReader.State state, object value); // 0x000000018CB97160-0x000000018CB971B0
		public virtual void Write(ref ProtoWriter.State state, object value); // 0x000000018CB971B0-0x000000018CB97204
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB970F4-0x000000018CB97160
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB97074-0x000000018CB970F4
	}

	internal sealed class UInt32Serializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80821
	{
		// Fields
		internal static readonly UInt32Serializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB97404-0x000000018CB97454 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private UInt32Serializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static UInt32Serializer(); // 0x00000001870E15A0-0x00000001870E1680
	
		// Methods
		public object Read(ref ProtoReader.State state, object value); // 0x00000001854C9300-0x00000001854C9C00
		public void Write(ref ProtoWriter.State state, object value); // 0x0000000184FF3F60-0x0000000184FF4000
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB97398-0x000000018CB97404
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB97318-0x000000018CB97398
	}

	internal sealed class UInt64Serializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80822
	{
		// Fields
		internal static readonly UInt64Serializer Instance; // 0x00
		private static readonly System.Type expectedType; // 0x08
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB9750C-0x000000018CB9755C 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private UInt64Serializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static UInt64Serializer(); // 0x00000001870E14C0-0x00000001870E15A0
	
		// Methods
		public object Read(ref ProtoReader.State state, object value); // 0x00000001854C91B0-0x00000001854C92E0
		public void Write(ref ProtoWriter.State state, object value); // 0x00000001854C6620-0x00000001854C6890
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB974A0-0x000000018CB9750C
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB97454-0x000000018CB974A0
	}

	internal sealed class UIntPtrSerializer : IRuntimeProtoSerializerNode // TypeDefIndex: 80823
	{
		// Fields
		internal static readonly UIntPtrSerializer Instance; // 0x00
	
		// Properties
		bool IRuntimeProtoSerializerNode.IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public System.Type ExpectedType { get; } // 0x000000018CB97720-0x000000018CB97770 
		bool IRuntimeProtoSerializerNode.RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		bool IRuntimeProtoSerializerNode.ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		private UIntPtrSerializer(); // 0x0000000186805BA0-0x0000000186805BB0
		static UIntPtrSerializer(); // 0x000000018CB976BC-0x000000018CB97720
	
		// Methods
		public void Write(ref ProtoWriter.State state, object value); // 0x000000018CB9766C-0x000000018CB976BC
		public object Read(ref ProtoReader.State state, object value); // 0x000000018CB97620-0x000000018CB9766C
		void IRuntimeProtoSerializerNode.EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB975B4-0x000000018CB97620
		void IRuntimeProtoSerializerNode.EmitRead(CompilerContext ctx, Local entity); // 0x000000018CB9755C-0x000000018CB975B4
	}

	internal sealed class UriDecorator : ProtoDecoratorBase // TypeDefIndex: 80824
	{
		// Fields
		private static readonly System.Type expectedType; // 0x00
	
		// Properties
		public override bool IsScalar { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override System.Type ExpectedType { get; } // 0x000000018CB97A74-0x000000018CB97AC4 
		public override bool RequiresOldValue { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override bool ReturnsValue { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		public UriDecorator(IRuntimeProtoSerializerNode tail); // 0x0000000184FD2410-0x0000000184FD2420
		static UriDecorator(); // 0x000000018CB979F4-0x000000018CB97A74
	
		// Methods
		public override void Write(ref ProtoWriter.State state, object value); // 0x000000018CB97964-0x000000018CB979F4
		public override object Read(ref ProtoReader.State state, object value); // 0x000000018CB978AC-0x000000018CB97964
		protected override void EmitWrite(CompilerContext ctx, Local valueFrom); // 0x000000018CB9780C-0x000000018CB978AC
		protected override void EmitRead(CompilerContext ctx, Local valueFrom); // 0x000000018CB97770-0x000000018CB9780C
	}
}

namespace ProtoBuf.Meta
{
	public enum ProtoSyntax // TypeDefIndex: 80666
	{
		Default = -1,
		Proto2 = 0,
		Proto3 = 1
	}

	public sealed class SchemaGenerationOptions // TypeDefIndex: 80667
	{
		// Fields
		internal static readonly SchemaGenerationOptions Default; // 0x00
		[CompilerGenerated]
		private ProtoSyntax _Syntax_k__BackingField; // 0x10
		[CompilerGenerated]
		private SchemaGenerationFlags _Flags_k__BackingField; // 0x14
		[CompilerGenerated]
		private string _Package_k__BackingField; // 0x18
		private List<ProtoBuf.Meta.Service> _services; // 0x20
		private List<System.Type> _types; // 0x28
		[CompilerGenerated]
		private string _Origin_k__BackingField; // 0x30
	
		// Properties
		public ProtoSyntax Syntax { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public SchemaGenerationFlags Flags { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
		public string Package { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public List<ProtoBuf.Meta.Service> Services { get; } // 0x000000018CB75AEC-0x000000018CB75B70 
		public List<System.Type> Types { get; } // 0x000000018CB75B70-0x000000018CB75BF4 
		internal bool HasServices { get; } // 0x000000018CB75A74-0x000000018CB75AB0 
		internal bool HasTypes { get; } // 0x000000018CB75AB0-0x000000018CB75AEC 
		public string Origin { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
	
		// Constructors
		public SchemaGenerationOptions(); // 0x000000018442FC80-0x000000018442FC90
		static SchemaGenerationOptions(); // 0x000000018CB75A08-0x000000018CB75A74
	}

	[Flags]
	public enum SchemaGenerationFlags // TypeDefIndex: 80668
	{
		None = 0,
		MultipleNamespaceSupport = 1,
		PreserveSubType = 2,
		IncludeEnumNamePrefix = 4
	}

	public sealed class Service // TypeDefIndex: 80669
	{
		// Fields
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly List<ServiceMethod> _Methods_k__BackingField; // 0x18
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public List<ServiceMethod> Methods { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Constructors
		public Service(); // 0x000000018CB765B4-0x000000018CB7662C
	}

	public sealed class ServiceMethod // TypeDefIndex: 80670
	{
		// Fields
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated]
		private System.Type _InputType_k__BackingField; // 0x18
		[CompilerGenerated]
		private System.Type _OutputType_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _ServerStreaming_k__BackingField; // 0x28
		[CompilerGenerated]
		private bool _ClientStreaming_k__BackingField; // 0x29
	
		// Properties
		public string Name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public System.Type InputType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public System.Type OutputType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public bool ServerStreaming { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public bool ClientStreaming { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E0D0-0x000000018225E0E0 0x000000018225E0E0-0x000000018225E0F0
	
		// Constructors
		public ServiceMethod(); // 0x000000018CB76530-0x000000018CB765B4
	}

	public class TypeFormatEventArgs : EventArgs // TypeDefIndex: 80671
	{
		// Fields
		private System.Type type; // 0x10
		private string formattedName; // 0x18
		private readonly bool typeFixed; // 0x20
	
		// Properties
		public System.Type Type { get; set; } // 0x00000001829260F0-0x0000000182926100 0x000000018CB7802C-0x000000018CB780B4
		public string FormattedName { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018CB77FBC-0x000000018CB7802C
	
		// Constructors
		internal TypeFormatEventArgs(string formattedName); // 0x000000018CB77ED0-0x000000018CB77F48
		internal TypeFormatEventArgs(System.Type type); // 0x000000018CB77F48-0x000000018CB77FBC
	}

	public delegate void TypeFormatEventHandler(object sender, TypeFormatEventArgs args); // TypeDefIndex: 80672; 0x00000001859B7730-0x00000001859B7740

	internal static class TypeModelExtensions // TypeDefIndex: 80673
	{
		// Extension methods
		internal static bool HasOption(this TypeModel model, TypeModel.TypeModelOptions options); // 0x000000018CB780B4-0x000000018CB780DC
		internal static bool OmitsOption(this TypeModel model, TypeModel.TypeModelOptions options); // 0x000000018CB780DC-0x000000018CB78104
	}

	public abstract class TypeModel : IProtoInput<Stream>, IProtoInput<ArraySegment<byte>>, IProtoInput<byte[]>, IProtoInput<ReadOnlyMemory<byte>>, IProtoInput<ReadOnlySequence<byte>>, IMeasuredProtoOutput<Stream>, IMeasuredProtoOutput<IBufferWriter<byte>> // TypeDefIndex: 80680
	{
		// Fields
		private int _bufferSize; // 0x10
		private int _maxDepth; // 0x14
		internal const int DefaultMaxDepth = 512; // Metadata: 0x0263D036
		internal const TypeModelOptions DefaultOptions = TypeModelOptions.None; // Metadata: 0x0263D038
		internal const SerializerFeatures FromAux = SerializerFeatures.CategoryRepeated; // Metadata: 0x0263D039
		private static TypeModel s_defaultModel; // 0x00
		[CompilerGenerated]
		private TypeFormatEventHandler DynamicTypeFormatting; // 0x18
		public const int ListItemTag = 1; // Metadata: 0x0263D03E
	
		// Properties
		public int BufferSize { get; set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x000000018CB7BB84-0x000000018CB7BBA8
		public int MaxDepth { get; set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018CB7BBA8-0x000000018CB7BBCC
		public virtual TypeModelOptions Options { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		internal static TypeModel DefaultModel { get; } // 0x00000001851206D0-0x0000000185120720 
	
		// Events
		public event TypeFormatEventHandler DynamicTypeFormatting {
			add; // 0x000000018CB7BA5C-0x000000018CB7BAF0
			remove; // 0x000000018CB7BAF0-0x000000018CB7BB84
		}
	
		// Nested types
		[Flags]
		public enum TypeModelOptions // TypeDefIndex: 80674
		{
			None = 0,
			InternStrings = 1,
			IncludeDateTimeKind = 2,
			SkipZeroLengthPackedArrays = 4,
			AllowPackedEncodingAtRoot = 8
		}
	
		private sealed class DeserializeItemsIterator<T> : DeserializeItemsIterator, IEnumerator<T>, IEnumerable<T> // TypeDefIndex: 80675
		{
			// Properties
			public new T Current { get; }
	
			// Constructors
			public DeserializeItemsIterator(TypeModel model, Stream source, PrefixStyle style, int expectedField, SerializationContext context);
	
			// Methods
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			void IDisposable.Dispose();
		}
	
		private class DeserializeItemsIterator : IEnumerator, IEnumerable // TypeDefIndex: 80676
		{
			// Fields
			private bool haveObject; // 0x10
			private object current; // 0x18
			private readonly Stream source; // 0x20
			private readonly System.Type type; // 0x28
			private readonly PrefixStyle style; // 0x30
			private readonly int expectedField; // 0x34
			private readonly ProtoBuf.TypeResolver resolver; // 0x38
			private readonly TypeModel model; // 0x40
			private readonly SerializationContext context; // 0x48
	
			// Properties
			public object Current { get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			public DeserializeItemsIterator(TypeModel model, Stream source, System.Type type, PrefixStyle style, int expectedField, ProtoBuf.TypeResolver resolver, SerializationContext context); // 0x000000018CB6D7CC-0x000000018CB6D83C
	
			// Methods
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000185BD80B0-0x0000000185BD80C0
			public bool MoveNext(); // 0x000000018CB6D744-0x000000018CB6D7CC
			void IEnumerator.Reset(); // 0x0000000189CB8C38-0x0000000189CB8C44
		}
	
		internal sealed class NullModel : TypeModel // TypeDefIndex: 80677
		{
			// Fields
			private static readonly NullModel s_Singleton; // 0x00
	
			// Properties
			public static TypeModel Singleton { get; } // 0x0000000186BF7DA0-0x0000000186BF7DF0 
	
			// Constructors
			private NullModel(); // 0x0000000187254B70-0x0000000187254B80
			static NullModel(); // 0x00000001871D3F40-0x00000001871D3FB0
	
			// Methods
			protected override ISerializer<T> GetSerializer<T>();
		}
	
		protected internal enum CallbackType // TypeDefIndex: 80678
		{
			BeforeSerialize = 0,
			AfterSerialize = 1,
			BeforeDeserialize = 2,
			AfterDeserialize = 3
		}
	
		internal sealed class Formatter : IFormatter // TypeDefIndex: 80679
		{
			// Fields
			private readonly TypeModel model; // 0x10
			private readonly System.Type type; // 0x18
			[CompilerGenerated]
			private SerializationBinder _Binder_k__BackingField; // 0x20
			[CompilerGenerated]
			private StreamingContext _Context_k__BackingField; // 0x28
			[CompilerGenerated]
			private ISurrogateSelector _SurrogateSelector_k__BackingField; // 0x38
	
			// Properties
			public SerializationBinder Binder { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
			public StreamingContext Context { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723D770-0x000000018723D780 0x0000000189041A4C-0x0000000189041A5C
			public ISurrogateSelector SurrogateSelector { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
	
			// Constructors
			internal Formatter(TypeModel model, System.Type type); // 0x000000018CB6E354-0x000000018CB6E3DC
	
			// Methods
			public object Deserialize(Stream serializationStream); // 0x000000018CB6E0C8-0x000000018CB6E214
			public void Serialize(Stream serializationStream, object graph); // 0x000000018CB6E214-0x000000018CB6E354
		}
	
		// Constructors
		protected TypeModel(); // 0x0000000187254B70-0x0000000187254B80
	
		// Methods
		protected static ISerializer<T> GetSerializer<TProvider, T>()
			where TProvider : class;
		[Obsolete("This API is no longer required and may be removed in a future release")]
		protected internal System.Type MapType(System.Type type); // 0x000000018459BB50-0x000000018459BB60
		[Obsolete("This API is no longer required and may be removed in a future release")]
		protected internal System.Type MapType(System.Type type, bool demand); // 0x000000018459BB50-0x000000018459BB60
		internal static WireType GetWireType(TypeModel model, ProtoBuf.DataFormat format, System.Type type); // 0x000000018CB79EFC-0x000000018CB7A004
		internal virtual bool IsKnownType<T>(CompatibilityLevel ambient);
		internal bool TrySerializeAuxiliaryType(ref ProtoWriter.State state, System.Type type, ProtoBuf.DataFormat format, int tag, object value, bool isInsideList, object parentList, bool isRoot); // 0x000000018CB7B444-0x000000018CB7B9AC
		private static ObjectScope NormalizeAuxScope(SerializerFeatures features, bool isInsideList, System.Type type, bool isRoot); // 0x000000018CB7A010-0x000000018CB7A0D4
		public void Serialize(Stream dest, object value); // 0x000000018CB7A850-0x000000018CB7A92C
		public void Serialize(Stream dest, object value, SerializationContext context); // 0x000000018CB7A778-0x000000018CB7A850
		public void Serialize(IBufferWriter<byte> dest, object value, object userState = null); // 0x000000018CB7A6A0-0x000000018CB7A778
		internal void SerializeRootFallback(ref ProtoWriter.State state, object value); // 0x0000000185C179A0-0x0000000185C17B10
		public long Serialize<T>(Stream dest, T value, object userState = null);
		public long Serialize<T>(IBufferWriter<byte> dest, T value, object userState = null);
		public MeasureState<T> Measure<T>(T value, object userState = null, long abortAfter = -1 /* Metadata: 0x0263D023 */);
		[Obsolete("If possible, please use the State API; a transitionary implementation is provided, but this API may be removed in a future version", false)]
		public void Serialize(ProtoWriter dest, object value); // 0x000000018CB7A624-0x000000018CB7A6A0
		internal static long SerializeImpl<T>(ref ProtoWriter.State state, T value);
		public object DeserializeWithLengthPrefix(Stream source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, PrefixStyle style, int fieldNumber); // 0x000000018CB78CC4-0x000000018CB78D04
		public object DeserializeWithLengthPrefix(Stream source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, PrefixStyle style, int expectedField, ProtoBuf.TypeResolver resolver); // 0x000000018CB78DF8-0x000000018CB78E44
		public object DeserializeWithLengthPrefix(Stream source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, PrefixStyle style, int expectedField, ProtoBuf.TypeResolver resolver, out int bytesRead); // 0x000000018CB78D04-0x000000018CB78DF8
		public object DeserializeWithLengthPrefix(Stream source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, PrefixStyle style, int expectedField, ProtoBuf.TypeResolver resolver, out long bytesRead); // 0x000000018CB78C6C-0x000000018CB78CC4
		private object DeserializeWithLengthPrefix(Stream source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, PrefixStyle style, int expectedField, ProtoBuf.TypeResolver resolver, out long bytesRead, out bool haveObject, SerializationContext context); // 0x000000018CB78E44-0x000000018CB79208
		public IEnumerable DeserializeItems(Stream source, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, PrefixStyle style, int expectedField, ProtoBuf.TypeResolver resolver); // 0x000000018CB78B5C-0x000000018CB78B88
		public IEnumerable DeserializeItems(Stream source, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, PrefixStyle style, int expectedField, ProtoBuf.TypeResolver resolver, SerializationContext context); // 0x000000018CB78AA0-0x000000018CB78B5C
		public IEnumerable<T> DeserializeItems<T>(Stream source, PrefixStyle style, int expectedField);
		public IEnumerable<T> DeserializeItems<T>(Stream source, PrefixStyle style, int expectedField, SerializationContext context);
		public void SerializeWithLengthPrefix(Stream dest, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, PrefixStyle style, int fieldNumber); // 0x000000018CB7A5F8-0x000000018CB7A624
		public void SerializeWithLengthPrefix(Stream dest, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, PrefixStyle style, int fieldNumber, SerializationContext context); // 0x000000018CB7A398-0x000000018CB7A5F8
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Deserialize(Stream source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type); // 0x000000018CB793A4-0x000000018CB794A8
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Deserialize(Stream source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, SerializationContext context); // 0x000000018CB79760-0x000000018CB79868
		public T Deserialize<T>(Stream source, T value = default, object userState = null);
		public T Deserialize<T>(ReadOnlyMemory<byte> source, T value = default, object userState = null);
		public T Deserialize<T>(ReadOnlySpan<byte> source, T value = default, object userState = null);
		public T Deserialize<T>(ReadOnlySequence<byte> source, T value = default, object userState = null);
		public object Deserialize([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, Stream source, object value = null, object userState = null, long length = -1 /* Metadata: 0x0263D02B */); // 0x000000018CB79A78-0x000000018CB79B8C
		public object Deserialize([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, ReadOnlyMemory<byte> source, object value = null, object userState = null); // 0x000000018CB79208-0x000000018CB79314
		public object Deserialize([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, ReadOnlySpan<byte> source, object value = null, object userState = null); // 0x0000000185120720-0x0000000185120920
		public object Deserialize([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, ReadOnlySequence<byte> source, object value = null, object userState = null); // 0x000000018CB794A8-0x000000018CB795C4
		internal static bool PrepareDeserialize(object value, ref System.Type type); // 0x000000018511F1E0-0x000000018511F410
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Deserialize(Stream source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, int length); // 0x000000018CB79A54-0x000000018CB79A78
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Deserialize(Stream source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, long length); // 0x000000018CB79DF8-0x000000018CB79E1C
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Deserialize(Stream source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, int length, SerializationContext context); // 0x000000018CB79A10-0x000000018CB79A54
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Deserialize(Stream source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, long length, SerializationContext context); // 0x000000018CB79B8C-0x000000018CB79D28
		public object Deserialize(ReadOnlyMemory<byte> source, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, object value = null, object userState = null); // 0x000000018CB795C4-0x000000018CB79760
		public object Deserialize(ReadOnlySequence<byte> source, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, object value = null, object userState = null); // 0x000000018CB79868-0x000000018CB79A10
		[Obsolete("If possible, please use the State API; a transitionary implementation is provided, but this API may be removed in a future version", false)]
		public object Deserialize(ProtoReader source, object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type); // 0x000000018CB79314-0x000000018CB793A4
		internal object DeserializeRootAny(ref ProtoReader.State state, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, object value, bool autoCreate); // 0x000000018511FA10-0x000000018511FC90
		private bool TryDeserializeList(ref ProtoReader.State state, ProtoBuf.DataFormat format, int tag, System.Type listType, System.Type itemType, ref object value, bool isRoot); // 0x000000018CB7B140-0x000000018CB7B444
		private static object CreateListInstance(System.Type listType, System.Type itemType); // 0x000000018CB78328-0x000000018CB785D4
		internal bool TryDeserializeAuxiliaryType(ref ProtoReader.SolidState state, ProtoBuf.DataFormat format, int tag, System.Type type, ref object value, bool skipOtherFields, bool asListItem, bool autoCreate, bool insideList, object parentListOrType, bool isRoot); // 0x000000018CB7B014-0x000000018CB7B140
		internal bool TryDeserializeAuxiliaryType(ref ProtoReader.State state, ProtoBuf.DataFormat format, int tag, System.Type type, ref object value, bool skipOtherFields, bool asListItem, bool autoCreate, bool insideList, object parentListOrType, bool isRoot); // 0x000000018CB7AC5C-0x000000018CB7B014
		internal static TypeModel SetDefaultModel(TypeModel newValue); // 0x0000000186BF7CF0-0x0000000186BF7DA0
		internal static void ResetDefaultModel(); // 0x000000018CB7A0D4-0x000000018CB7A118
		[Obsolete("Use RuntimeTypeModel.Create", true)]
		public static TypeModel Create(); // 0x0000000189CB8C38-0x0000000189CB8C44
		[Obsolete("Use RuntimeTypeModel.CreateForAssembly", true)]
		public static TypeModel CreateForAssembly<T>();
		[Obsolete("Use RuntimeTypeModel.CreateForAssembly", true)]
		public static TypeModel CreateForAssembly(System.Type type); // 0x0000000189CB8C38-0x0000000189CB8C44
		[Obsolete("Use RuntimeTypeModel.CreateForAssembly", true)]
		public static TypeModel CreateForAssembly(Assembly assembly); // 0x0000000189CB8C38-0x0000000189CB8C44
		public bool IsDefined(System.Type type); // 0x000000018CB7A004-0x000000018CB7A010
		internal bool IsDefined(System.Type type, CompatibilityLevel ambient); // 0x00000001854C2620-0x00000001854C26E0
		protected virtual ISerializer<T> GetSerializer<T>();
		internal virtual ISerializer<T> GetSerializerCore<T>(CompatibilityLevel ambient);
		private static ISerializer<T> NoSerializer<T>(TypeModel model);
		private static ISubTypeSerializer<T> NoSubTypeSerializer<T>(TypeModel model)
			where T : class;
		internal static T CreateInstance<T>(ISerializationContext context, ISerializer<T> serializer = null);
		internal static T ActivatorCreate<T>();
		internal static ISerializer<T> GetSerializer<T>(TypeModel model, CompatibilityLevel ambient = CompatibilityLevel.NotSpecified /* Metadata: 0x0263D033 */);
		public static ISerializer<T> GetInbuiltSerializer<T>(CompatibilityLevel compatibilityLevel = CompatibilityLevel.NotSpecified /* Metadata: 0x0263D034 */, ProtoBuf.DataFormat dataFormat = ProtoBuf.DataFormat.Default /* Metadata: 0x0263D035 */);
		internal static IRepeatedSerializer<T> GetRepeatedSerializer<T>(TypeModel model);
		internal static ISerializer<T> TryGetSerializer<T>(TypeModel model);
		internal static ISubTypeSerializer<T> GetSubTypeSerializer<T>(TypeModel model)
			where T : class;
		internal object Deserialize(ObjectScope scope, ref ProtoReader.State state, System.Type type, object value); // 0x000000018CB79D28-0x000000018CB79DF8
		public T DeepClone<T>(T value, object userState = null);
		public object DeepClone(object value); // 0x000000018CB78A10-0x000000018CB78AA0
		private object DeepCloneFallback(System.Type type, object value); // 0x000000018CB785D4-0x000000018CB78A10
		protected internal static void ThrowUnexpectedSubtype(System.Type expected, System.Type actual); // 0x000000018CB7A9B8-0x000000018CB7AA54
		public static void ThrowUnexpectedSubtype<T>(T value)
			where T : class;
		public static void ThrowUnexpectedSubtype<T, TConstruct>(T value)
			where T : class
			where TConstruct : class, T;
		public static bool IsSubType<T>(T value)
			where T : class;
		protected internal static void ThrowUnexpectedType(System.Type type, TypeModel model); // 0x000000018CB7AA54-0x000000018CB7AC5C
		internal static void ThrowNestedListsNotSupported(System.Type type); // 0x000000018CB7A9AC-0x000000018CB7A9B8
		public static void ThrowCannotCreateInstance(System.Type type, Exception inner = null); // 0x000000018CB7A92C-0x000000018CB7A9AC
		internal static string SerializeType(TypeModel model, System.Type type); // 0x000000018CB7A2E0-0x000000018CB7A398
		internal static System.Type DeserializeType(TypeModel model, string value); // 0x000000018CB78B88-0x000000018CB78C6C
		public bool CanSerializeContractType(System.Type type); // 0x000000018CB78134-0x000000018CB78164
		public bool CanSerialize(System.Type type); // 0x000000018CB78164-0x000000018CB78194
		public bool CanSerializeBasicType(System.Type type); // 0x000000018CB78104-0x000000018CB78134
		internal bool CanSerialize(System.Type type, bool allowBasic, bool allowContract, bool allowLists, out SerializerFeatures category); // 0x000000018CB78194-0x000000018CB782B8
		public string GetSchema([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type); // 0x000000018CB79E1C-0x000000018CB79E2C
		public string GetSchema([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type, ProtoSyntax syntax); // 0x000000018CB79E2C-0x000000018CB79EFC
		public virtual string GetSchema(SchemaGenerationOptions options); // 0x0000000189CB8C38-0x0000000189CB8C44
		public IFormatter CreateFormatter([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.None | DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] System.Type type); // 0x000000018CB782B8-0x000000018CB78328
		internal static System.Type ResolveKnownType(string name, Assembly assembly); // 0x000000018CB7A118-0x000000018CB7A2E0
		T IProtoInput<Stream>.Deserialize<T>(Stream source, T value, object userState);
		T IProtoInput<ArraySegment<byte>>.Deserialize<T>(ArraySegment<byte> source, T value, object userState);
		T IProtoInput<byte[]>.Deserialize<T>(byte[] source, T value, object userState);
		void IProtoOutput<Stream>.Serialize<T>(Stream destination, T value, object userState);
		void IProtoOutput<IBufferWriter<byte>>.Serialize<T>(IBufferWriter<byte> destination, T value, object userState);
		void IMeasuredProtoOutput<Stream>.Serialize<T>(MeasureState<T> measured, Stream destination);
		void IMeasuredProtoOutput<IBufferWriter<byte>>.Serialize<T>(MeasureState<T> measured, IBufferWriter<byte> destination);
		MeasureState<T> IMeasuredProtoOutput<Stream>.Measure<T>(T value, object userState);
		MeasureState<T> IMeasuredProtoOutput<IBufferWriter<byte>>.Measure<T>(T value, object userState);
		[CompilerGenerated]
		internal static bool _CanSerialize_g__CheckIfNullableT_106_0(ref System.Type type); // 0x000000018CB7B9AC-0x000000018CB7B9DC
		[CompilerGenerated]
		internal static bool _CanSerialize_g__DoCheckLists_106_1(System.Type type, TypeModel model, bool allowBasic, bool allowContract); // 0x000000018CB7B9DC-0x000000018CB7BA5C
	}

	internal abstract class AttributeMap // TypeDefIndex: 80682
	{
		// Properties
		public abstract System.Type AttributeType { get; }
		public abstract object Target { get; }
	
		// Nested types
		private sealed class ReflectionAttributeMap : AttributeMap // TypeDefIndex: 80681
		{
			// Fields
			private readonly Attribute attribute; // 0x10
	
			// Properties
			public override object Target { get; } // 0x00000001829260F0-0x0000000182926100 
			public override System.Type AttributeType { get; } // 0x0000000185F03090-0x0000000185F030C0 
	
			// Constructors
			public ReflectionAttributeMap(Attribute attribute); // 0x00000001858CD4F0-0x00000001858CD550
	
			// Methods
			public override bool TryGet(string key, bool publicOnly, out object value); // 0x00000001850486A0-0x0000000185048EF0
		}
	
		// Constructors
		protected AttributeMap(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[Obsolete("Please use AttributeType instead")]
		public new System.Type GetType(); // 0x000000018CB66C8C-0x000000018CB66C9C
		public override string ToString(); // 0x000000018CB66C9C-0x000000018CB66CF4
		public abstract bool TryGet(string key, bool publicOnly, out object value);
		public bool TryGet(string key, out object value); // 0x000000018783B52C-0x000000018783B548
		public static AttributeMap[] Create(System.Type type, bool inherit); // 0x00000001858CC030-0x00000001858CC1E0
		public static AttributeMap[] Create(MemberInfo member, bool inherit); // 0x00000001858CD620-0x00000001858CDAE0
		public static AttributeMap[] Create(Assembly assembly); // 0x000000018CB66B74-0x000000018CB66C8C
	}

	public sealed class AutoCompileTypeModel : TypeModel // TypeDefIndex: 80683
	{
		// Fields
		private static readonly Hashtable s_assemblyModels; // 0x00
		[CompilerGenerated]
		private static readonly TypeModel _Instance_k__BackingField; // 0x08
	
		// Properties
		public static TypeModel Instance { [CompilerGenerated] get; } // 0x000000018CB6743C-0x000000018CB6748C 
	
		// Constructors
		private AutoCompileTypeModel(); // 0x0000000187254B70-0x0000000187254B80
		static AutoCompileTypeModel(); // 0x000000018CB67378-0x000000018CB6743C
	
		// Methods
		public static new TypeModel CreateForAssembly<T>();
		public static new TypeModel CreateForAssembly(System.Type type); // 0x000000018CB671EC-0x000000018CB67260
		public static new TypeModel CreateForAssembly(Assembly assembly); // 0x000000018CB670D4-0x000000018CB67120
		public static TypeModel CreateForAssembly(Assembly assembly, RuntimeTypeModel.CompilerOptions options); // 0x000000018CB67120-0x000000018CB671EC
		private static TypeModel ForAssembly(System.Type type); // 0x000000018CB67260-0x000000018CB672DC
		public override string GetSchema(SchemaGenerationOptions options); // 0x000000018CB672DC-0x000000018CB67378
		protected override ISerializer<T> GetSerializer<T>();
		internal override bool IsKnownType<T>(CompatibilityLevel ambient);
		private static TypeModel CreateForAssemblyImpl(Assembly assembly, RuntimeTypeModel.CompilerOptions options); // 0x000000018CB66CF4-0x000000018CB670D4
	}

	public class CallbackSet // TypeDefIndex: 80684
	{
		// Fields
		private readonly MetaType metaType; // 0x10
		private MethodInfo beforeSerialize; // 0x18
		private MethodInfo afterSerialize; // 0x20
		private MethodInfo beforeDeserialize; // 0x28
		private MethodInfo afterDeserialize; // 0x30
	
		// Properties
		internal MethodInfo this[TypeModel.CallbackType callbackType] { get => default; } // 0x000000018CB67ECC-0x000000018CB67FC4 
		public MethodInfo BeforeSerialize { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018CB68050-0x000000018CB68074
		public MethodInfo BeforeDeserialize { get; set; } // 0x0000000182262130-0x0000000182262140 0x000000018CB6802C-0x000000018CB68050
		public MethodInfo AfterSerialize { get; set; } // 0x000000018225E800-0x000000018225E810 0x000000018CB68008-0x000000018CB6802C
		public MethodInfo AfterDeserialize { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018CB67FE4-0x000000018CB68008
		public bool NonTrivial { get; } // 0x000000018CB67FC4-0x000000018CB67FE4 
	
		// Constructors
		internal CallbackSet(MetaType metaType); // 0x000000018CB67E54-0x000000018CB67ECC
	
		// Methods
		internal static bool CheckCallbackParameters(MethodInfo method); // 0x000000018CB67AEC-0x000000018CB67C30
		private MethodInfo SanityCheckCallback(MethodInfo callback); // 0x000000018CB67D04-0x000000018CB67E54
		internal static Exception CreateInvalidCallbackSignature(MethodInfo method); // 0x000000018CB67C30-0x000000018CB67D04
	}

	[IsReadOnly]
	public struct EnumMember : IEquatable<EnumMember>, IComparable<EnumMember> // TypeDefIndex: 80685
	{
		// Fields
		[CompilerGenerated]
		private readonly string _Name_k__BackingField; // 0x00
		[CompilerGenerated]
		private readonly object _Value_k__BackingField; // 0x08
	
		// Properties
		public string Name { [CompilerGenerated] get; } // 0x0000000184431970-0x0000000184431980 
		public object Value { [CompilerGenerated] get; } // 0x00000001844AFA30-0x00000001844AFA40 
		internal bool HasValue { get; } // 0x00000001858CBE20-0x00000001858CBE50 
	
		// Constructors
		public EnumMember(object value, string name); // 0x0000000186DB0DC0-0x0000000186DB0DF0
	
		// Methods
		internal int? TryGetInt32(); // 0x000000018CB6DFE0-0x000000018CB6DFEC
		internal static int? TryGetInt32(object value); // 0x000000018CB6DD8C-0x000000018CB6DFE0
		public EnumMember WithName(string name); // 0x000000018CB6E038-0x000000018CB6E05C
		public EnumMember WithValue(object value); // 0x000000018CB6E05C-0x000000018CB6E088
		public EnumMember Normalize(System.Type type); // 0x000000018CB6DD00-0x000000018CB6DD4C
		public bool Equals<T>(T value)
			where T : struct;
		public override string ToString(); // 0x000000018CB6DD4C-0x000000018CB6DD8C
		public override int GetHashCode(); // 0x000000018CB6DC18-0x000000018CB6DC6C
		public override bool Equals(object obj); // 0x000000018CB6DBA8-0x000000018CB6DC18
		public bool Equals(EnumMember other); // 0x000000018CB6DB68-0x000000018CB6DBA8
		public static bool operator ==(EnumMember x, EnumMember y); // 0x000000018CB6E088-0x000000018CB6E0A8
		public static bool operator !=(EnumMember x, EnumMember y); // 0x000000018CB6E0A8-0x000000018CB6E0C8
		private static object Normalize(object value, System.Type type); // 0x000000018CB6DC6C-0x000000018CB6DD00
		public static EnumMember Create<T>(T value)
			where T : struct;
		internal void Validate(); // 0x000000018CB6DFEC-0x000000018CB6E038
		public int CompareTo(EnumMember other); // 0x000000018CB6DA54-0x000000018CB6DB68
	}

	public sealed class MetaType : ISerializerProxy // TypeDefIndex: 80697
	{
		// Fields
		private MetaType baseType; // 0x10
		private CompatibilityLevel _compatibilityLevel; // 0x18
		private List<SubType> _subTypes; // 0x20
		private CallbackSet callbacks; // 0x28
		private string name; // 0x30
		private string origin; // 0x38
		private MethodInfo factory; // 0x40
		private readonly RuntimeTypeModel model; // 0x48
		[CompilerGenerated]
		private readonly System.Type _Type_k__BackingField; // 0x50
		private IProtoTypeSerializer _serializer; // 0x58
		private System.Type constructType; // 0x60
		internal System.Type surrogateType; // 0x68
		internal ProtoBuf.DataFormat surrogateDataFormat; // 0x70
		private MethodInfo underlyingToSurrogate; // 0x78
		private MethodInfo surrogateToUnderlying; // 0x80
		private List<ValueMember> _fields; // 0x88
		private List<EnumMember> _enums; // 0x90
		private TypeOptions flags; // 0x98
		private System.Type _serializerType; // 0xA0
		private List<ProtoReservedAttribute> _reservations; // 0xA8
	
		// Properties
		IRuntimeProtoSerializerNode ISerializerProxy.Serializer { get; } // 0x000000018CB6FF14-0x000000018CB6FF1C 
		public MetaType BaseType { get; } // 0x00000001829260F0-0x0000000182926100 
		internal RuntimeTypeModel Model { get; } // 0x000000018226EE80-0x000000018226EE90 
		public CompatibilityLevel CompatibilityLevel { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x0000000185859190-0x0000000185859230
		public bool IncludeSerializerMethod { get; set; } // 0x000000018CB74A98-0x000000018CB74AB0 0x000000018CB74E24-0x000000018CB74E4C
		public bool AsReferenceDefault { get; [Obsolete("Reference-tracking and dynamic-type are not currently implemented in this build; they may be reinstated later; this is partly due to doubts over whether the features are adviseable, and partly over confidence in testing all the scenarios (it takes time; that time hasn\'t get happened); feedback is invited", true)] set; } // 0x00000001843FFFF0-0x0000000184400000 0x000000018CB5E8B0-0x000000018CB5E8C8
		public bool HasCallbacks { get; } // 0x000000018CB74A2C-0x000000018CB74A44 
		public bool HasSubtypes { get; } // 0x000000018CB74A44-0x000000018CB74A88 
		public int SubtypesCount { get; } // 0x000000018CB74D74-0x000000018CB74DAC 
		public CallbackSet Callbacks { get; } // 0x000000018CB74990-0x000000018CB74A08 
		private bool IsValueType { get; } // 0x000000018CB74AB0-0x000000018CB74AD4 
		public string Name { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018CB74E70-0x000000018CB74EA0
		public string Origin { get; set; } // 0x0000000182986470-0x0000000182986480 0x000000018CB74EA0-0x000000018CB74ED0
		public System.Type Type { [CompilerGenerated] get; } // 0x000000018226EBD0-0x000000018226EBE0 
		internal IProtoTypeSerializer Serializer { get; } // 0x000000018585ACF0-0x000000018585AE50 
		public bool UseConstructor { get; set; } // 0x0000000185859650-0x0000000185859670 0x0000000185859030-0x00000001858590B0
		public System.Type ConstructType { get; set; } // 0x0000000187232FA0-0x0000000187232FB0 0x000000018CB74DAC-0x000000018CB74DDC
		internal bool HasSurrogate { get; } // 0x00000001854C26E0-0x00000001854C26F0 
		public ValueMember this[int fieldNumber] { get => default; } // 0x000000018CB74AD4-0x000000018CB74C08 
		public ValueMember this[MemberInfo member] { get => default; } // 0x000000018CB74C08-0x000000018CB74D74 
		internal bool HasFields { get; } // 0x00000001858595B0-0x0000000185859600 
		internal List<ValueMember> Fields { get; } // 0x00000001858CA200-0x00000001858CA290 
		internal List<EnumMember> Enums { get; } // 0x0000000186D429E0-0x0000000186D42A40 
		internal bool HasEnums { get; } // 0x0000000185859600-0x0000000185859650 
		public bool EnumPassthru { [Obsolete("Enum value maps have been deprecated and are no longer supported; all enums are now effectively pass-thru; custom maps should be applied via shadow properties; in C#, lambda-based \'switch expressions\' make for very convenient shadow properties", false)] get; [Obsolete("Enum value maps have been deprecated and are no longer supported; all enums are now effectively pass-thru; custom maps should be applied via shadow properties; in C#, lambda-based \'switch expressions\' make for very convenient shadow properties", true)] set; } // 0x000000018CB74A08-0x000000018CB74A2C 0x000000018CB74DDC-0x000000018CB74E00
		public bool IgnoreListHandling { get; set; } // 0x000000018CB74A88-0x000000018CB74A98 0x00000001858590B0-0x0000000185859140
		public bool IgnoreUnknownSubTypes { get; set; } // 0x0000000187837CAC-0x0000000187837CBC 0x000000018CB74E00-0x000000018CB74E24
		internal bool Pending { get; set; } // 0x0000000187838024-0x0000000187838034 0x0000000187837FC4-0x0000000187837FE8
		public System.Type SerializerType { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x00000001864195E0-0x0000000186419670
		internal bool IsAutoTuple { get; } // 0x0000000187837CBC-0x0000000187837CCC 
		public bool IsGroup { get; set; } // 0x0000000187837C9C-0x0000000187837CAC 0x000000018CB74E4C-0x000000018CB74E70
		internal bool HasReservations { get; } // 0x00000001862E9D40-0x00000001862E9DF0 
	
		// Nested types
		internal sealed class Comparer : System.Collections.IComparer, IComparer<MetaType> // TypeDefIndex: 80686
		{
			// Fields
			private readonly HashSet<System.Type> _callstack; // 0x10
	
			// Constructors
			internal Comparer(HashSet<System.Type> callstack); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			public int Compare(object x, object y); // 0x000000018CB7E3C8-0x000000018CB7E448
			public int Compare(MetaType x, MetaType y); // 0x000000018CB7E254-0x000000018CB7E2D0
		}
	
		[Flags]
		internal enum AttributeFamily // TypeDefIndex: 80687
		{
			None = 0,
			ProtoBuf = 1,
			DataContractSerializer = 2,
			XmlSerializer = 4,
			AutoTuple = 8
		}
	
		private enum TypeOptions : ushort // TypeDefIndex: 80688
		{
			None = 0,
			Pending = 1,
			Frozen = 4,
			PrivateOnApi = 8,
			SkipConstructor = 16,
			AutoTuple = 64,
			IgnoreListHandling = 128,
			IsGroup = 256,
			IgnoreUnknownSubTypes = 512
		}
	
		private class ExtraLayerValueMembers : IEnumerable<NullWrappedValueMemberData> // TypeDefIndex: 80689
		{
			// Fields
			private readonly Dictionary<string, System.Type> _schemaMemberTypeMap; // 0x10
			private readonly Dictionary<string, NullWrappedValueMemberData> _wrappedSchemaMembers; // 0x18
	
			// Constructors
			public ExtraLayerValueMembers(); // 0x000000018CB7F214-0x000000018CB7F2D4
	
			// Methods
			public bool IsEmpty(); // 0x000000018CB7F1C8-0x000000018CB7F20C
			public NullWrappedValueMemberData Add(string schemaTypeName, ValueMember valueMember); // 0x000000018CB7EE3C-0x000000018CB7F128
			public IEnumerator<NullWrappedValueMemberData> GetEnumerator(); // 0x000000018CB7F128-0x000000018CB7F1C8
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018CB7F20C-0x000000018CB7F214
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass41_0 // TypeDefIndex: 80690
		{
			// Fields
			public MetaType __4__this; // 0x00
			public HashSet<System.Type> callstack; // 0x08
		}
	
		[CompilerGenerated]
		private sealed class _GetAllGenericArguments_d__139 : IEnumerable<System.Type>, IEnumerator<System.Type> // TypeDefIndex: 80691
		{
			// Fields
			private int __1__state; // 0x10
			private System.Type __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private System.Type type; // 0x28
			public System.Type __3__type; // 0x30
			private System.Type[] __7__wrap1; // 0x38
			private int __7__wrap2; // 0x40
			private System.Type _arg_5__4; // 0x48
			private IEnumerator<System.Type> __7__wrap4; // 0x50
	
			// Properties
			System.Type IEnumerator<System.Type>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetAllGenericArguments_d__139(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018CB8FA28-0x000000018CB8FAA0
			private bool MoveNext(); // 0x000000018CB8F470-0x000000018CB8F940
			private void __m__Finally1(); // 0x000000018CB8FAA0-0x000000018CB8FAEC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CB8F9DC-0x000000018CB8FA28
			[DebuggerHidden]
			IEnumerator<System.Type> IEnumerable<Type>.GetEnumerator(); // 0x000000018CB8F940-0x000000018CB8F9D4
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018CB8F9D4-0x000000018CB8F9DC
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass170_0 // TypeDefIndex: 80692
		{
			// Fields
			public ProtoSyntax syntax; // 0x00
			public StringBuilder builder; // 0x08
			public int indent; // 0x10
			public MetaType __4__this; // 0x18
			public HashSet<string> imports; // 0x20
			public bool multipleNamespaceSupport; // 0x28
			public string package; // 0x30
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass170_1 // TypeDefIndex: 80693
		{
			// Fields
			public ValueMember member; // 0x00
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass170_2 // TypeDefIndex: 80694
		{
			// Fields
			public bool hasOption; // 0x00
			public string altName; // 0x08
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass170_3 // TypeDefIndex: 80695
		{
			// Fields
			public int pos; // 0x00
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass170_4 // TypeDefIndex: 80696
		{
			// Fields
			public NullWrappedValueMemberData wrappedValueMember; // 0x00
		}
	
		// Constructors
		internal MetaType(RuntimeTypeModel model, System.Type type, MethodInfo factory); // 0x00000001854BF820-0x00000001854BF940
	
		// Methods
		public override string ToString(); // 0x000000018CB71D78-0x000000018CB71D9C
		private bool IsValidSubType(System.Type subType); // 0x000000018CB7161C-0x000000018CB7166C
		public MetaType AddSubType(int fieldNumber, System.Type derivedType); // 0x000000018CB6F674-0x000000018CB6F690
		private static void ThrowSubTypeWithSurrogate(System.Type type); // 0x000000018CB71CD8-0x000000018CB71D28
		public MetaType AddSubType(int fieldNumber, System.Type derivedType, ProtoBuf.DataFormat dataFormat); // 0x000000018CB6F0F0-0x000000018CB6F674
		private static void ThrowTupleTypeWithInheritance(System.Type type); // 0x000000018CB71D28-0x000000018CB71D78
		private void SetBaseType(MetaType baseType); // 0x000000018CB716CC-0x000000018CB71810
		public MetaType SetCallbacks(MethodInfo beforeSerialize, MethodInfo afterSerialize, MethodInfo beforeDeserialize, MethodInfo afterDeserialize); // 0x000000018CB71810-0x000000018CB718AC
		private void CheckSetCallbacks(); // 0x000000018CB6FE84-0x000000018CB6FEA4
		public MetaType SetCallbacks(string beforeSerialize, string afterSerialize, string beforeDeserialize, string afterDeserialize); // 0x000000018CB718AC-0x000000018CB7198C
		public string GetSchemaTypeName(); // 0x000000018CB70BE4-0x000000018CB70BF0
		internal string GetSchemaTypeName(HashSet<System.Type> callstack); // 0x000000018CB70528-0x000000018CB70BE4
		internal string GuessPackage(); // 0x000000018CB70D38-0x000000018CB70DC4
		public MetaType SetFactory(MethodInfo factory); // 0x000000018CB71BF0-0x000000018CB71C74
		public MetaType SetFactory(string factory); // 0x000000018CB71C74-0x000000018CB71C9C
		private MethodInfo ResolveMethod(string name, bool instance); // 0x000000018CB716A4-0x000000018CB716CC
		internal static Exception InbuiltType(System.Type type, Exception innerException = null); // 0x000000018CB70DC4-0x000000018CB70E80
		internal void ThrowIfFrozen(); // 0x00000001858CA290-0x00000001858CA2B0
		internal System.Type GetInheritanceRoot(); // 0x000000018585AC80-0x000000018585ACF0
		private SerializerFeatures GetFeatures(); // 0x0000000185859710-0x0000000185859790
		private bool HasRealInheritance(); // 0x0000000185859140-0x0000000185859190
		private IProtoTypeSerializer BuildSerializer(); // 0x0000000185859790-0x000000018585AC40
		private static System.Type GetBaseType(MetaType type); // 0x00000001864D5B30-0x00000001864D5B60
		internal static bool GetAsReferenceDefault(System.Type type); // 0x000000018CB6FF98-0x000000018CB70144
		internal void ApplyDefaultBehaviour(CompatibilityLevel ambient); // 0x000000018618FF00-0x000000018618FFB0
		private void ApplyDefaultBehaviourImpl(CompatibilityLevel ambient); // 0x00000001858CEFD0-0x00000001858D2370
		internal void Assert(CompatibilityLevel expected); // 0x000000018CB6FDA4-0x000000018CB6FE60
		private static void ApplyDefaultBehaviour_AddMembers(AttributeFamily family, bool isEnum, List<AttributeMap> partialMembers, int dataMemberOffset, bool inferTagByName, ImplicitFields implicitMode, List<ProtoMemberAttribute> members, MemberInfo member, ref bool forced, bool isPublic, bool isField, ref System.Type effectiveType, List<EnumMember> enumMembers, MemberInfo backingMember = null); // 0x00000001858CBE50-0x00000001858CC030
		private static MethodInfo Coalesce(MethodInfo[] arr, int x, int y); // 0x000000018CB6FED8-0x000000018CB6FF14
		internal static AttributeFamily GetContractFamily(RuntimeTypeModel model, System.Type type, AttributeMap[] attributes); // 0x00000001858CBB30-0x00000001858CBDE0
		internal static ConstructorInfo ResolveTupleConstructor(System.Type type, out MemberInfo[] mappedMembers); // 0x00000001858CB4F0-0x00000001858CB7A0
		private static void CheckForCallback(MethodInfo method, AttributeMap[] attributes, string callbackTypeName, ref MethodInfo[] callbacks, int index); // 0x00000001858CEEC0-0x00000001858CEFD0
		private static bool HasFamily(AttributeFamily value, AttributeFamily required); // 0x00000001858CC1E0-0x00000001858CC1F0
		private static ProtoMemberAttribute NormalizeProtoMember(MemberInfo member, AttributeFamily family, bool forced, bool isEnum, List<AttributeMap> partialMembers, int dataMemberOffset, bool inferByTagName, out EnumMember enumMember, MemberInfo backingMember = null); // 0x00000001858CC1F0-0x00000001858CD4F0
		private ValueMember ApplyDefaultBehaviour(bool isEnum, ProtoMemberAttribute normalizedAttribute); // 0x000000018536F7E0-0x0000000185370300
		private static void GetDataFormat(ref ProtoBuf.DataFormat value, AttributeMap attrib, string memberName); // 0x0000000185FF6280-0x0000000185FF6340
		private static void GetIgnore(ref bool ignore, AttributeMap attrib, AttributeMap[] attribs, string fullName); // 0x00000001858CBDE0-0x00000001858CBE20
		private static void GetFieldBoolean(ref bool value, AttributeMap attrib, string memberName); // 0x000000018783804C-0x0000000187838068
		private static bool GetFieldBoolean(ref bool value, AttributeMap attrib, string memberName, bool publicOnly); // 0x00000001850485C0-0x00000001850486A0
		private static void GetFieldNumber(ref int value, AttributeMap attrib, string memberName); // 0x0000000185FF6340-0x0000000185FF6400
		private static void GetFieldName(ref string name, AttributeMap attrib, string memberName); // 0x0000000185FF6400-0x0000000185FF64E0
		private static AttributeMap GetAttribute(AttributeMap[] attribs, string fullName); // 0x00000001858CDAE0-0x00000001858CDBB0
		public MetaType Add(int fieldNumber, string memberName); // 0x000000018CB6F7F4-0x000000018CB6F820
		public ValueMember AddField(int fieldNumber, string memberName); // 0x000000018CB6E7B8-0x000000018CB6E7DC
		public MetaType Add(string memberName); // 0x000000018CB6F760-0x000000018CB6F798
		public void SetSurrogate(System.Type surrogateType); // 0x000000018CB71C9C-0x000000018CB71CBC
		internal void SetSurrogate(System.Type surrogateType, MethodInfo underlyingToSurrogate, MethodInfo surrogateToUnderlying, ProtoBuf.DataFormat dataFormat); // 0x0000000185858B10-0x0000000185859030
		internal MetaType GetSurrogateOrSelf(); // 0x000000018CB70D00-0x000000018CB70D38
		internal MetaType GetSurrogateOrBaseOrSelf(bool deep); // 0x000000018CB70CB0-0x000000018CB70D00
		private int GetNextFieldNumber(); // 0x000000018CB702A4-0x000000018CB70528
		public MetaType Add(params string[] memberNames); // 0x000000018CB6F690-0x000000018CB6F760
		public MetaType Add(int fieldNumber, string memberName, object defaultValue); // 0x000000018CB6F798-0x000000018CB6F7C4
		public MetaType Add(int fieldNumber, string memberName, System.Type itemType, System.Type defaultType); // 0x000000018CB6F7C4-0x000000018CB6F7F4
		public ValueMember AddField(int fieldNumber, string memberName, System.Type itemType, System.Type defaultType); // 0x000000018CB6ECE0-0x000000018CB6ED04
		private void ThrowIfAutoTuple(); // 0x000000018CB71CBC-0x000000018CB71CD8
		private ValueMember AddField(int fieldNumber, string memberName, System.Type itemType, System.Type defaultType, object defaultValue); // 0x000000018CB6E7DC-0x000000018CB6ECE0
		private void Add(ValueMember member); // 0x00000001858C9FB0-0x00000001858CA200
		public ValueMember[] GetFields(); // 0x000000018CB701E0-0x000000018CB702A4
		public EnumMember[] GetEnumValues(); // 0x000000018CB70144-0x000000018CB701E0
		public void SetEnumValues(EnumMember[] values); // 0x000000018CB7198C-0x000000018CB71BF0
		internal bool IsValidEnum(); // 0x000000018CB7160C-0x000000018CB7161C
		internal static bool IsValidEnum(IList<EnumMember> values); // 0x000000018CB714A0-0x000000018CB7160C
		public SubType[] GetSubtypes(); // 0x000000018CB70BF0-0x000000018CB70CB0
		internal IEnumerable<System.Type> GetAllGenericArguments(); // 0x000000018CB6FF1C-0x000000018CB6FF28
		[IteratorStateMachine(typeof(_GetAllGenericArguments_d__139))]
		private static IEnumerable<System.Type> GetAllGenericArguments(System.Type type); // 0x000000018CB6FF28-0x000000018CB6FF98
		public void CompileInPlace(); // 0x000000018CB6FF14-0x000000018CB6FF1C
		internal bool IsDefined(int fieldNumber); // 0x000000018CB70E80-0x000000018CB70FB8
		private bool HasFlag(TypeOptions flag); // 0x00000001858596F0-0x0000000185859710
		private void SetFlag(TypeOptions flag, bool value, bool throwIfFrozen); // 0x0000000185859670-0x00000001858596F0
		internal static MetaType GetRootType(MetaType source); // 0x00000001858C9EC0-0x00000001858C9FB0
		internal bool IsPrepared(); // 0x000000018CB7145C-0x000000018CB714A0
		internal static StringBuilder NewLine(StringBuilder builder, int indent); // 0x000000018CB7166C-0x000000018CB716A4
		internal void WriteSchema(HashSet<System.Type> callstack, StringBuilder builder, int indent, HashSet<string> imports, ProtoSyntax syntax, string package, SchemaGenerationFlags flags); // 0x000000018CB73214-0x000000018CB74990
		private static StringBuilder AddOption(StringBuilder builder, ref bool hasOption); // 0x000000018CB6ED04-0x000000018CB6ED7C
		private static StringBuilder CloseOption(StringBuilder builder, ref bool hasOption); // 0x000000018CB6FEA4-0x000000018CB6FED8
		private static bool IsImplicitDefault(object value); // 0x000000018CB70FB8-0x000000018CB7145C
		private static bool CanPack(System.Type type); // 0x000000018CB6FE60-0x000000018CB6FE84
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void ApplyFieldOffset(int offset); // 0x000000018CB6F820-0x000000018CB6FDA4
		internal static void AssertValidFieldNumber(int fieldNumber); // 0x0000000185859590-0x00000001858595B0
		public MetaType AddReservation(int field, string comment = null); // 0x000000018CB6F06C-0x000000018CB6F0F0
		public MetaType AddReservation(int from, int to, string comment = null); // 0x000000018CB6EFD0-0x000000018CB6F06C
		public MetaType AddReservation(string field, string comment = null); // 0x000000018CB6EF48-0x000000018CB6EFD0
		private MetaType AddReservation(ProtoReservedAttribute reservation); // 0x000000018CB6ED7C-0x000000018CB6EF48
		internal void Validate(); // 0x0000000187837CCC-0x0000000187837CD4
		internal void ValidateReservations(); // 0x00000001862E8FE0-0x00000001862E9D40
		[CompilerGenerated]
		private string _GetSchemaTypeName_g__GetArrayName_41_1(System.Type elementType, ref __c__DisplayClass41_0 param_000ad30d); // 0x000000018CB71D9C-0x000000018CB71E50
		[CompilerGenerated]
		internal static string _GetSchemaTypeName_g__LastPart_41_0(string value); // 0x000000018CB71E50-0x000000018CB71EA0
		[CompilerGenerated]
		internal static bool _ResolveTupleConstructor_g__IsPublicSetter_78_0(MethodInfo method); // 0x00000001858CA540-0x00000001858CA550
		[CompilerGenerated]
		internal static void _ThrowIfAutoTuple_g__Throw_115_0(); // 0x000000018CB71ED0-0x000000018CB71F2C
		[CompilerGenerated]
		private EnumMember _SetEnumValues_b__134_0(EnumMember val); // 0x000000018CB71EA0-0x000000018CB71ED0
		[CompilerGenerated]
		private void _WriteSchema_g__WriteValueMember_170_3(string schemaModelTypeName, bool hasGroupModifier, ref __c__DisplayClass170_0 param_000ad313, ref __c__DisplayClass170_1 param_000ad314, ref __c__DisplayClass170_2 param_000ad315); // 0x000000018CB727FC-0x000000018CB73154
		[CompilerGenerated]
		private void _WriteSchema_g__AddExtraLayerSchemaModels_170_0(ExtraLayerValueMembers extraLayerValueMembers, int pos, ref __c__DisplayClass170_0 param_000ad318); // 0x000000018CB71FC0-0x000000018CB72340
		[CompilerGenerated]
		private void _WriteSchema_g__WriteWrappedFieldPayload_170_4(ref __c__DisplayClass170_0 param_000ad319, ref __c__DisplayClass170_3 param_000ad31a, ref __c__DisplayClass170_4 param_000ad31b); // 0x000000018CB73154-0x000000018CB73214
		[CompilerGenerated]
		private void _WriteSchema_g__AddNamespace_170_1(HashSet<string> imports, ref __c__DisplayClass170_0 param_000ad31d); // 0x000000018CB72340-0x000000018CB72510
		[CompilerGenerated]
		private void _WriteSchema_g__AppendReservations_170_2(ref __c__DisplayClass170_0 param_000ad31e); // 0x000000018CB72510-0x000000018CB727FC
		[CompilerGenerated]
		internal static string _ValidateReservations_g__CommentSuffix_185_0(ProtoReservedAttribute reservation); // 0x000000018CB71F2C-0x000000018CB71FC0
	}

	internal class NullWrappedValueMemberData // TypeDefIndex: 80698
	{
		// Fields
		private readonly string _originalSchemaTypeName; // 0x10
		private readonly string _alternativeTypeName; // 0x18
		private readonly bool _hasSchemaTypeNameCollision; // 0x20
		private readonly ValueMember _valueMember; // 0x28
	
		// Properties
		public string SchemaTypeName { get; } // 0x00000001829260F0-0x0000000182926100 
		public string WrappedSchemaTypeName { get; } // 0x000000018CB80838-0x000000018CB808DC 
		public bool HasSchemaTypeNameCollision { get; } // 0x000000018CB8081C-0x000000018CB80838 
		public System.Type ItemType { get; } // 0x000000018CA8E178-0x000000018CA8E194 
		public bool HasGroupModifier { get; } // 0x000000018CB807FC-0x000000018CB8081C 
	
		// Constructors
		public NullWrappedValueMemberData(ValueMember valueMember, string originalSchemaTypeName, string alternativeTypeName = null, bool hasSchemaTypeNameCollision = false /* Metadata: 0x0263D05F */); // 0x000000018CB807BC-0x000000018CB807FC
	
		// Methods
		private bool HasKnownTypeSchema(); // 0x000000018CB8069C-0x000000018CB807BC
	}

	public sealed class RuntimeTypeModel : TypeModel // TypeDefIndex: 80710
	{
		// Fields
		private RuntimeTypeModelOptions _options; // 0x20
		[CompilerGenerated]
		private readonly CompilerContextScope _Scope_k__BackingField; // 0x28
		private CompatibilityLevel _defaultCompatibilityLevel; // 0x30
		private static readonly BasicList.MatchPredicate BasicTypeFinder; // 0x00
		private static readonly BasicList.MatchPredicate MetaTypeFinder; // 0x08
		private readonly BasicList types; // 0x38
		private readonly BasicList basicTypes; // 0x40
		[CompilerGenerated]
		private EventHandler<TypeAddedEventArgs> BeforeApplyDefaultBehaviour; // 0x48
		[CompilerGenerated]
		private EventHandler<TypeAddedEventArgs> AfterApplyDefaultBehaviour; // 0x50
		private readonly Hashtable _serviceCache; // 0x58
		private int metadataTimeoutMilliseconds; // 0x60
		private int contentionCounter; // 0x64
		[CompilerGenerated]
		private LockContentedEventHandler LockContended; // 0x68
		private MethodInfo defaultFactory; // 0x70
		private readonly string _name; // 0x78
		private static readonly object s_ModelSyncLock; // 0x10
		private Hashtable _externalProviders; // 0x80
	
		// Properties
		public override TypeModelOptions Options { get; } // 0x00000001862ABA50-0x00000001862ABA60 
		internal CompilerContextScope Scope { [CompilerGenerated] get; } // 0x0000000182262130-0x0000000182262140 
		public bool InferTagFromNameDefault { get; set; } // 0x00000001889D38B4-0x00000001889D38C0 0x000000018CB8D9C8-0x000000018CB8D9DC
		public bool AutoAddProtoContractTypesOnly { get; set; } // 0x000000018CB8D704-0x000000018CB8D710 0x000000018CB8D900-0x000000018CB8D914
		public bool UseImplicitZeroDefaults { get; set; } // 0x000000018CB8D720-0x000000018CB8D72C 0x0000000186BF7DF0-0x0000000186BF7E50
		public bool AllowParseableTypes { get; set; } // 0x0000000187836518-0x0000000187836524 0x000000018CB8D8EC-0x000000018CB8D900
		public bool IncludeDateTimeKind { get; set; } // 0x000000018CB8D710-0x000000018CB8D718 0x000000018CB8D9B4-0x000000018CB8D9C8
		public bool SkipZeroLengthPackedArrays { get; set; } // 0x000000018CB8D718-0x000000018CB8D720 0x000000018CB8DA58-0x000000018CB8DA6C
		public bool AllowPackedEncodingAtRoot { get; set; } // 0x000000018CB8D6FC-0x000000018CB8D704 0x000000018CB8D8D8-0x000000018CB8D8EC
		public bool InternStrings { get; set; } // 0x00000001878365AC-0x00000001878365B4 0x000000018CB8D9DC-0x000000018CB8D9F0
		public static RuntimeTypeModel Default { get; } // 0x0000000185120630-0x00000001851206D0 
		public CompatibilityLevel DefaultCompatibilityLevel { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x000000018CB8D914-0x000000018CB8D9B4
		public MetaType this[System.Type type] { get => default; } // 0x00000001858C9DF0-0x00000001858C9EC0 
		public bool AutoCompile { get; set; } // 0x0000000187837C90-0x0000000187837C9C 0x000000018783BB8C-0x000000018783BBA0
		public bool AutoAddMissingTypes { get; set; } // 0x0000000187838018-0x0000000187838024 0x0000000186BF80D0-0x0000000186BF8130
		public int MetadataTimeoutMilliseconds { get; set; } // 0x00000001872332A0-0x00000001872332B0 0x000000018CB8D9F0-0x000000018CB8DA58
	
		// Events
		public event EventHandler<TypeAddedEventArgs> BeforeApplyDefaultBehaviour {
			add; // 0x000000018CB8D5DC-0x000000018CB8D668
			remove; // 0x000000018CB8D7B8-0x000000018CB8D844
		}
		public event EventHandler<TypeAddedEventArgs> AfterApplyDefaultBehaviour {
			add; // 0x000000018CB8D550-0x000000018CB8D5DC
			remove; // 0x000000018CB8D72C-0x000000018CB8D7B8
		}
		public event LockContentedEventHandler LockContended {
			add; // 0x000000018CB8D668-0x000000018CB8D6FC
			remove; // 0x000000018CB8D844-0x000000018CB8D8D8
		}
	
		// Nested types
		private enum RuntimeTypeModelOptions // TypeDefIndex: 80699
		{
			None = 0,
			InternStrings = 1,
			IncludeDateTimeKind = 2,
			SkipZeroLengthPackedArrays = 4,
			AllowPackedEncodingAtRoot = 8,
			TypeModelMask = 15,
			InferTagFromNameDefault = 1024,
			IsDefaultModel = 2048,
			Frozen = 4096,
			AutoAddMissingTypes = 8192,
			AutoCompile = 16384,
			UseImplicitZeroDefaults = 32768,
			AllowParseableTypes = 65536,
			AutoAddProtoContractTypesOnly = 131072
		}
	
		internal static class CommonImports // TypeDefIndex: 80700
		{
			// Fields
			public const string Bcl = "protobuf-net/bcl.proto"; // Metadata: 0x0263D088
			public const string WrappersProto = "google/protobuf/wrappers.proto"; // Metadata: 0x0263D09F
			public const string Timestamp = "google/protobuf/timestamp.proto"; // Metadata: 0x0263D0BE
			public const string Duration = "google/protobuf/duration.proto"; // Metadata: 0x0263D0DE
			public const string Protogen = "protobuf-net/protogen.proto"; // Metadata: 0x0263D0FD
			public const string Empty = "google/protobuf/empty.proto"; // Metadata: 0x0263D119
		}
	
		private sealed class BasicType // TypeDefIndex: 80701
		{
			// Fields
			[CompilerGenerated]
			private readonly System.Type _Type_k__BackingField; // 0x10
			[CompilerGenerated]
			private readonly IRuntimeProtoSerializerNode _Serializer_k__BackingField; // 0x18
	
			// Properties
			public System.Type Type { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
			public IRuntimeProtoSerializerNode Serializer { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			public BasicType(System.Type type, IRuntimeProtoSerializerNode serializer); // 0x0000000185381AC0-0x0000000185381AF0
		}
	
		internal sealed class SerializerPair : IComparable // TypeDefIndex: 80702
		{
			// Fields
			public readonly int MetaKey; // 0x10
			public readonly int BaseKey; // 0x14
			public readonly MetaType Type; // 0x18
			public readonly MethodBuilder Serialize; // 0x20
			public readonly MethodBuilder Deserialize; // 0x28
			public readonly ILGenerator SerializeBody; // 0x30
			public readonly ILGenerator DeserializeBody; // 0x38
	
			// Constructors
			public SerializerPair(int metaKey, int baseKey, MetaType type, MethodBuilder serialize, MethodBuilder deserialize, ILGenerator serializeBody, ILGenerator deserializeBody); // 0x000000018CB8E2A0-0x000000018CB8E310
	
			// Methods
			int IComparable.CompareTo(object obj); // 0x000000018CB8E1B8-0x000000018CB8E2A0
		}
	
		public sealed class CompilerOptions // TypeDefIndex: 80703
		{
			// Fields
			[CompilerGenerated]
			private string _TargetFrameworkName_k__BackingField; // 0x10
			[CompilerGenerated]
			private string _TargetFrameworkDisplayName_k__BackingField; // 0x18
			[CompilerGenerated]
			private string _TypeName_k__BackingField; // 0x20
			internal const string NoPersistence = "Assembly persistence not supported on this runtime"; // Metadata: 0x0263D135
			[CompilerGenerated]
			private string _OutputPath_k__BackingField; // 0x28
			[CompilerGenerated]
			private string _ImageRuntimeVersion_k__BackingField; // 0x30
			[CompilerGenerated]
			private int _MetaDataVersion_k__BackingField; // 0x38
			[CompilerGenerated]
			private string _AssemblyCompanyName_k__BackingField; // 0x40
			[CompilerGenerated]
			private string _AssemblyCopyright_k__BackingField; // 0x48
			[CompilerGenerated]
			private string _AssemblyDescription_k__BackingField; // 0x50
			[CompilerGenerated]
			private string _AssemblyProductName_k__BackingField; // 0x58
			[CompilerGenerated]
			private string _AssemblyTitle_k__BackingField; // 0x60
			[CompilerGenerated]
			private string _AssemblyTrademark_k__BackingField; // 0x68
			[CompilerGenerated]
			private System.Version _AssemblyVersion_k__BackingField; // 0x70
			[CompilerGenerated]
			private System.Version _AssemblyProductVersion_k__BackingField; // 0x78
			[CompilerGenerated]
			private Accessibility _Accessibility_k__BackingField; // 0x80
			[CompilerGenerated]
			private Func<System.Type, bool> IncludeType; // 0x88
	
			// Properties
			public string TargetFrameworkName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
			public string TargetFrameworkDisplayName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			public string TypeName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
			[Obsolete("Assembly persistence not supported on this runtime")]
			public string OutputPath { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
			public string ImageRuntimeVersion { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
			public int MetaDataVersion { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
			public string AssemblyCompanyName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
			public string AssemblyCopyright { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
			public string AssemblyDescription { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
			public string AssemblyProductName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
			public string AssemblyTitle { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
			public string AssemblyTrademark { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
			public System.Version AssemblyVersion { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
			public System.Version AssemblyProductVersion { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829CD170-0x00000001829CD180 0x0000000188800CC0-0x0000000188800CD0
			public Accessibility Accessibility { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233080-0x0000000187233090 0x00000001872330F0-0x0000000187233100
	
			// Events
			public event Func<System.Type, bool> IncludeType {
				add; // 0x000000018CB7E738-0x000000018CB7E7C8
				remove; // 0x000000018CB7E7C8-0x000000018CB7E858
			}
	
			// Constructors
			public CompilerOptions(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void SetFrameworkOptions(MetaType from); // 0x000000018CB7E52C-0x000000018CB7E738
			internal bool OnIncludeType(System.Type type); // 0x000000018CB7E510-0x000000018CB7E52C
		}
	
		public enum Accessibility // TypeDefIndex: 80704
		{
			Public = 0,
			Internal = 1
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass41_0 // TypeDefIndex: 80705
		{
			// Fields
			public HashSet<System.Type> forceGenerationTypes; // 0x00
			public RuntimeTypeModel __4__this; // 0x08
			public string origin; // 0x10
			public string package; // 0x18
			public HashSet<string> imports; // 0x20
			public List<MetaType> requiredTypes; // 0x28
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80706
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, string> __9__41_3; // 0x08
			public static Converter<System.Type, string> __9__95_0; // 0x10
	
			// Constructors
			static __c(); // 0x00000001871E59C0-0x00000001871E5A20
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _GetSchema_b__41_3(string _); // 0x000000018459BB50-0x000000018459BB60
			internal string _Override_b__95_0(System.Type x); // 0x000000018CB8FB40-0x000000018CB8FB60
			internal bool _.cctor_b__144_0(object value, object ctx); // 0x000000018613A870-0x000000018613AAA0
			internal bool _.cctor_b__144_1(object value, object ctx); // 0x0000000184FFC810-0x0000000184FFC8E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass90_0<TActual> // TypeDefIndex: 80707
		{
			// Fields
			public IRuntimeProtoSerializerNode serializer;
	
			// Constructors
			public __c__DisplayClass90_0();
	
			// Methods
			internal void _GetSerializer_b__0(ref ProtoWriter.State state, TActual val);
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass105_0 // TypeDefIndex: 80708
		{
			// Fields
			public Dictionary<SerializerFeatures, MethodInfo> featuresLookup; // 0x00
			public TypeBuilder type; // 0x08
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass143_0 // TypeDefIndex: 80709
		{
			// Fields
			public System.Type serializerType; // 0x10
	
			// Constructors
			public __c__DisplayClass143_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal MemberInfo _AddSerializer_b__0(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB8FB60-0x000000018CB8FBC8
		}
	
		// Constructors
		internal RuntimeTypeModel(bool isDefault, string name); // 0x0000000186BF7E50-0x0000000186BF8000
		static RuntimeTypeModel(); // 0x0000000186DD7220-0x0000000186DD73B0
	
		// Methods
		public static void Initialize(); // 0x000000018CB8ABD0-0x000000018CB8AC10
		private bool GetOption(RuntimeTypeModelOptions option); // 0x00000001854BF810-0x00000001854BF820
		private void SetOption(RuntimeTypeModelOptions option, bool value); // 0x0000000186BF8130-0x0000000186BF8150
		public IEnumerable GetTypes(); // 0x0000000182986470-0x0000000182986480
		public override string GetSchema(SchemaGenerationOptions options); // 0x000000018CB86DA8-0x000000018CB8ABD0
		private void CascadeRepeated(List<MetaType> list, RepeatedSerializerStub provider, CompatibilityLevel ambient, ProtoBuf.DataFormat keyFormat, HashSet<string> imports, string origin); // 0x000000018CB85F2C-0x000000018CB86078
		private void CascadeDependents(List<MetaType> list, MetaType metaType, HashSet<string> imports, string origin); // 0x000000018CB85830-0x000000018CB85F2C
		private void TryGetCoreSerializer(List<MetaType> list, System.Type itemType, CompatibilityLevel ambient, HashSet<string> imports, string origin); // 0x000000018CB8BA44-0x000000018CB8BC60
		internal static bool EnableAutoCompile(); // 0x000000018CB863A8-0x000000018CB86544
		internal MetaType FindWithAmbientCompatibility(System.Type type, CompatibilityLevel ambient); // 0x00000001854C2850-0x00000001854C2920
		internal MetaType FindWithoutAdd(System.Type type); // 0x0000000185847F70-0x0000000185848100
		private void WaitOnLock(); // 0x000000018CB8C6F8-0x000000018CB8C784
		internal IRuntimeProtoSerializerNode TryGetBasicTypeSerializer(System.Type type); // 0x00000001858CB080-0x00000001858CB4B0
		internal int FindOrAddAuto(System.Type type, bool demand, bool addWithContractOnly, bool addEvenIfAutoDisabled, CompatibilityLevel ambient); // 0x00000001858CA550-0x00000001858CB080
		private MetaType RecogniseCommonTypes(System.Type type); // 0x0000000185829EC0-0x0000000185829ED0
		private MetaType Create(System.Type type); // 0x00000001854BF750-0x00000001854BF7F0
		public MetaType Add<T>(bool applyDefaultBehaviour = true /* Metadata: 0x0263D060 */, CompatibilityLevel compatibilityLevel = CompatibilityLevel.NotSpecified /* Metadata: 0x0263D061 */);
		public MetaType Add(System.Type type, bool applyDefaultBehaviour); // 0x000000018CB8536C-0x000000018CB85388
		public MetaType Add(System.Type type, bool applyDefaultBehaviour = true /* Metadata: 0x0263D062 */, CompatibilityLevel compatibilityLevel = CompatibilityLevel.NotSpecified /* Metadata: 0x0263D063 */); // 0x000000018CB85388-0x000000018CB85718
		internal static void OnBeforeApplyDefaultBehaviour(MetaType metaType, ref TypeAddedEventArgs args); // 0x0000000186190050-0x00000001861900F0
		internal static void OnAfterApplyDefaultBehaviour(MetaType metaType, ref TypeAddedEventArgs args); // 0x000000018618FFB0-0x0000000186190050
		private static void OnApplyDefaultBehaviour(EventHandler<TypeAddedEventArgs> handler, MetaType metaType, ref TypeAddedEventArgs args); // 0x00000001861900F0-0x0000000186190140
		private void ThrowIfFrozen(); // 0x00000001854BF7F0-0x00000001854BF810
		public void Freeze(); // 0x000000018CB86544-0x000000018CB86594
		protected override ISerializer<T> GetSerializer<T>();
		internal override ISerializer<T> GetSerializerCore<T>(CompatibilityLevel ambient);
		internal override bool IsKnownType<T>(CompatibilityLevel ambient);
		private object GetServices<T>(CompatibilityLevel ambient);
		internal void ResetServiceCache(System.Type type); // 0x00000001858589C0-0x0000000185858B10
		private object GetServicesSlow(System.Type type, CompatibilityLevel ambient); // 0x000000018585B610-0x000000018585B980
		public override string ToString(); // 0x000000018CB8BA30-0x000000018CB8BA44
		internal ProtoSerializer<TActual> GetSerializer<TActual>(IRuntimeProtoSerializerNode serializer, bool compiled);
		public void CompileInPlace(); // 0x000000018CB86078-0x000000018CB86114
		private void BuildAllSerializers(); // 0x000000018CB85718-0x000000018CB85830
		internal static ILGenerator Override(TypeBuilder type, string name); // 0x000000018CB8B538-0x000000018CB8B584
		internal static ILGenerator Override(TypeBuilder type, string name, out System.Type[] genericArgs); // 0x000000018CB8B584-0x000000018CB8B8C0
		public TypeModel Compile(CompilerOptions options = null); // 0x000000018CB86114-0x000000018CB86170
		private void WriteConstructorsAndOverrides(TypeBuilder type, System.Type serviceType); // 0x000000018CB8CFC0-0x000000018CB8D0A8
		private void WriteEnumsAndProxies(TypeBuilder type); // 0x000000018CB8D0A8-0x000000018CB8D204
		internal static MemberInfo GetUnderlyingProvider(MemberInfo provider, System.Type forType); // 0x00000001854EC710-0x00000001854EC7D0
		internal static void EmitProvider(MemberInfo provider, ILGenerator il); // 0x000000018CB8626C-0x000000018CB863A8
		internal RepeatedSerializerStub TryGetRepeatedProvider(System.Type type, CompatibilityLevel ambient = CompatibilityLevel.NotSpecified /* Metadata: 0x0263D064 */); // 0x0000000185371670-0x0000000185371750
		private static void AddProxy(TypeBuilder building, System.Type proxying, MemberInfo provider, bool includeNullable); // 0x000000018CB84F84-0x000000018CB850B8
		private void WriteSerializers(CompilerContextScope scope, TypeBuilder type); // 0x000000018CB8D204-0x000000018CB8D550
		private static TypeBuilder WriteBasicTypeModel(string typeName, ModuleBuilder module, System.Type baseType, bool @internal); // 0x000000018CB8CF54-0x000000018CB8CFC0
		private void WriteAssemblyAttributes(CompilerOptions options, string assemblyName, AssemblyBuilder asm); // 0x000000018CB8C784-0x000000018CB8CF54
		internal bool IsPrepared(System.Type type); // 0x000000018CB8AD94-0x000000018CB8ADBC
		internal void TakeLock(ref int opaqueToken); // 0x00000001858CA2B0-0x00000001858CA410
		private int GetContention(); // 0x0000000187837FE8-0x0000000187837FF8
		private void AddContention(); // 0x0000000187254C90-0x0000000187254CA0
		internal void ReleaseLock(int opaqueToken); // 0x00000001858CA410-0x00000001858CA540
		internal string GetSchemaTypeName(HashSet<System.Type> callstack, System.Type effectiveType, ProtoBuf.DataFormat dataFormat, CompatibilityLevel compatibilityLevel, bool asReference, bool dynamicType, HashSet<string> imports); // 0x000000018CB86594-0x000000018CB865E8
		private static bool IsWrappersProtoType(System.Type type, out string name, HashSet<string> imports); // 0x000000018CB8AFB0-0x000000018CB8B304
		private static bool IsWellKnownType(System.Type type, out string name, HashSet<string> imports); // 0x000000018CB8ADBC-0x000000018CB8AFB0
		internal string GetSchemaTypeName(HashSet<System.Type> callstack, System.Type effectiveType, ProtoBuf.DataFormat dataFormat, CompatibilityLevel compatibilityLevel, bool asReference, bool dynamicType, HashSet<string> imports, out string altName, bool considerWrappersProtoTypes = false /* Metadata: 0x0263D065 */); // 0x000000018CB865E8-0x000000018CB86DA8
		public void SetDefaultFactory(MethodInfo methodInfo); // 0x000000018CB8B8C0-0x000000018CB8B91C
		internal static void VerifyFactory(MethodInfo factory, System.Type type); // 0x000000018CB8C3F4-0x000000018CB8C6F8
		public static RuntimeTypeModel Create([CallerMemberName] string name = null); // 0x000000018CB86208-0x000000018CB8626C
		internal static bool IsFullyPublic(System.Type type); // 0x000000018CB8AD38-0x000000018CB8AD94
		internal static bool IsFullyPublic(System.Type type, out System.Type cause); // 0x000000018CB8AC10-0x000000018CB8AD38
		public static new TypeModel CreateForAssembly<T>();
		public static new TypeModel CreateForAssembly(System.Type type); // 0x000000018CB86170-0x000000018CB861BC
		public static new TypeModel CreateForAssembly(Assembly assembly); // 0x000000018CB861BC-0x000000018CB86208
		public void MakeDefault(); // 0x000000018CB8B304-0x000000018CB8B538
		private static void ThrowDefaultAutoAddMissingTypes(); // 0x000000018CB8B91C-0x000000018CB8B978
		private static void ThrowDefaultUseImplicitZeroDefaults(); // 0x000000018CB8B9D4-0x000000018CB8BA30
		private static void ThrowDefaultFrozen(); // 0x000000018CB8B978-0x000000018CB8B9D4
		private static RuntimeTypeModel CreateDefaultModelInstance(); // 0x0000000186BF7A60-0x0000000186BF7CF0
		public RuntimeTypeModel SetSurrogate<TUnderlying, TSurrogate>(Func<TUnderlying, TSurrogate> underlyingToSurrogate = null, Func<TSurrogate, TUnderlying> surrogateToUnderlying = null, ProtoBuf.DataFormat dataFormat = ProtoBuf.DataFormat.Default /* Metadata: 0x0263D066 */, CompatibilityLevel compatibilityLevel = CompatibilityLevel.NotSpecified /* Metadata: 0x0263D067 */);
		public RuntimeTypeModel AddSerializer(System.Type collectionType, System.Type serializerType); // 0x000000018CB850B8-0x000000018CB8536C
		[CompilerGenerated]
		private bool _GetSchema_g__IsOutputForcedFor_41_0(System.Type type, ref __c__DisplayClass41_0 param_000ad3ba); // 0x000000018CB8BFC4-0x000000018CB8C018
		[CompilerGenerated]
		private MetaType _GetSchema_g__AddType_41_1(System.Type type, bool forceOutput, bool inferPackageAndOrigin, ref __c__DisplayClass41_0 param_000ad3be); // 0x000000018CB8BD64-0x000000018CB8BFC4
		[CompilerGenerated]
		private void _GetSchema_g__AddMetaType_41_2(MetaType toAdd, ref __c__DisplayClass41_0 param_000ad3c0); // 0x000000018CB8BC60-0x000000018CB8BD64
		[CompilerGenerated]
		internal static object _GetServicesSlow_g__GetServicesImpl_88_0(RuntimeTypeModel model, System.Type type, CompatibilityLevel ambient); // 0x000000018585B980-0x000000018585BAF0
		[CompilerGenerated]
		internal static bool _WriteEnumsAndProxies_g__ShouldEmitCustomSerializerProxy_100_0(System.Type serializerType); // 0x000000018CB8C1C8-0x000000018CB8C290
		[CompilerGenerated]
		internal static MethodInfo _WriteSerializers_g__GetFeaturesMethod_105_0(SerializerFeatures features, ref __c__DisplayClass105_0 param_000ad3c6); // 0x000000018CB8C290-0x000000018CB8C3F4
		[CompilerGenerated]
		internal static void _WriteAssemblyAttributes_g__WriteAssemblyInfoAttributes_107_0(CompilerOptions options, AssemblyBuilder asm); // 0x000000018CB8C018-0x000000018CB8C1C8
		[CompilerGenerated]
		internal static void _WriteAssemblyAttributes_g__WriteAssemblyInfoAttribute_107_1<TAttribute>(CompilerOptions options, AssemblyBuilder asm, string value)
			where TAttribute : Attribute;
		[CompilerGenerated]
		internal static MethodInfo _SetSurrogate_g__GetMethod_141_0<TUnderlying, TSurrogate>(Delegate value, string paramName);
	}

	public sealed class LockContentedEventArgs : EventArgs // TypeDefIndex: 80711
	{
		// Fields
		[CompilerGenerated]
		private readonly string _OwnerStackTrace_k__BackingField; // 0x10
	
		// Properties
		public string OwnerStackTrace { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		internal LockContentedEventArgs(string ownerStackTrace); // 0x000000018CB80550-0x000000018CB805A8
	}

	public delegate void LockContentedEventHandler(object sender, LockContentedEventArgs args); // TypeDefIndex: 80712; 0x00000001859B7730-0x00000001859B7740

	public sealed class SubType // TypeDefIndex: 80714
	{
		// Fields
		private int _fieldNumber; // 0x10
		private readonly MetaType derivedType; // 0x18
		private readonly ProtoBuf.DataFormat dataFormat; // 0x20
		private IRuntimeProtoSerializerNode serializer; // 0x28
	
		// Properties
		public int FieldNumber { get; internal set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x000000018CB8E560-0x000000018CB8E598
		public MetaType DerivedType { get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Nested types
		internal sealed class Comparer : System.Collections.IComparer, IComparer<SubType> // TypeDefIndex: 80713
		{
			// Fields
			public static readonly Comparer Default; // 0x00
	
			// Constructors
			public Comparer(); // 0x0000000186805BA0-0x0000000186805BB0
			static Comparer(); // 0x000000018CB7E448-0x000000018CB7E4AC
	
			// Methods
			public int Compare(object x, object y); // 0x000000018CB7E2D0-0x000000018CB7E350
			public int Compare(SubType x, SubType y); // 0x000000018CB7E210-0x000000018CB7E254
		}
	
		// Constructors
		public SubType(int fieldNumber, MetaType derivedType, ProtoBuf.DataFormat format); // 0x000000018CB8E490-0x000000018CB8E560
	
		// Methods
		private void ThrowIfFrozen(); // 0x000000018CB8E428-0x000000018CB8E490
		internal IRuntimeProtoSerializerNode GetSerializer(System.Type parentType); // 0x000000018CB8E3F4-0x000000018CB8E428
		private IRuntimeProtoSerializerNode BuildSerializer(System.Type parentType); // 0x000000018CB8E310-0x000000018CB8E3F4
	}

	public sealed class TypeAddedEventArgs : EventArgs // TypeDefIndex: 80715
	{
		// Fields
		[CompilerGenerated]
		private bool _ApplyDefaultBehaviour_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly MetaType _MetaType_k__BackingField; // 0x18
	
		// Properties
		public bool ApplyDefaultBehaviour { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
		public MetaType MetaType { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
		public System.Type Type { get; } // 0x000000018CB8F0B0-0x000000018CB8F0CC 
		public RuntimeTypeModel Model { get; } // 0x000000018CB8F094-0x000000018CB8F0B0 
	
		// Constructors
		internal TypeAddedEventArgs(MetaType metaType); // 0x000000018CB8F034-0x000000018CB8F094
	}

	public class ValueMember // TypeDefIndex: 80717
	{
		// Fields
		private int _fieldNumber; // 0x10
		private MemberInfo backingMember; // 0x18
		[CompilerGenerated]
		private readonly MemberInfo _Member_k__BackingField; // 0x20
		private object _defaultValue; // 0x28
		[CompilerGenerated]
		private readonly System.Type _ItemType_k__BackingField; // 0x30
		[CompilerGenerated]
		private readonly System.Type _MemberType_k__BackingField; // 0x38
		[CompilerGenerated]
		private readonly System.Type _DefaultType_k__BackingField; // 0x40
		[CompilerGenerated]
		private readonly System.Type _ParentType_k__BackingField; // 0x48
		private CompatibilityLevel _compatibilityLevel; // 0x50
		private readonly RuntimeTypeModel model; // 0x58
		private IRuntimeProtoSerializerNode serializer; // 0x60
		private ProtoBuf.DataFormat dataFormat; // 0x68
		private ProtoBuf.DataFormat mapKeyFormat; // 0x6C
		private ProtoBuf.DataFormat mapValueFormat; // 0x70
		private MethodInfo getSpecified; // 0x78
		private MethodInfo setSpecified; // 0x80
		private string name; // 0x88
		private const ushort OPTIONS_IsStrict = 1; // Metadata: 0x0263D16C
		private const ushort OPTIONS_IsPacked = 2; // Metadata: 0x0263D16E
		private const ushort OPTIONS_IsRequired = 4; // Metadata: 0x0263D170
		private const ushort OPTIONS_OverwriteList = 8; // Metadata: 0x0263D172
		private const ushort OPTIONS_NullWrappedValue = 16; // Metadata: 0x0263D174
		private const ushort OPTIONS_NullWrappedValueGroup = 32; // Metadata: 0x0263D176
		private const ushort OPTIONS_IsMap = 64; // Metadata: 0x0263D178
		private const ushort OPTIONS_NullWrappedCollection = 128; // Metadata: 0x0263D17A
		private const ushort OPTIONS_NullWrappedCollectionGroup = 256; // Metadata: 0x0263D17C
		private const ushort OPTIONS_SupportNull = 512; // Metadata: 0x0263D17E
		private ushort flags; // 0x90
	
		// Properties
		public int FieldNumber { get; internal set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000185859470-0x00000001858594A0
		public MemberInfo Member { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
		public MemberInfo BackingMember { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000184FD4AB0-0x0000000184FD4AE0
		public System.Type ItemType { [CompilerGenerated] get; } // 0x00000001829600D0-0x00000001829600E0 
		public System.Type MemberType { [CompilerGenerated] get; } // 0x0000000182986470-0x0000000182986480 
		public System.Type DefaultType { [CompilerGenerated] get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public System.Type ParentType { [CompilerGenerated] get; } // 0x000000018226EE80-0x000000018226EE90 
		public object DefaultValue { get; set; } // 0x0000000182262130-0x0000000182262140 0x000000018CB8FE88-0x000000018CB8FEC0
		public CompatibilityLevel CompatibilityLevel { get; set; } // 0x0000000187233280-0x0000000187233290 0x0000000185859520-0x0000000185859550
		internal IRuntimeProtoSerializerNode Serializer { get; } // 0x000000018585AC40-0x000000018585AC80 
		public ProtoBuf.DataFormat DataFormat { get; set; } // 0x0000000182271AE0-0x0000000182271AF0 0x000000018CB8FE5C-0x000000018CB8FE88
		public bool IsStrict { get; set; } // 0x000000018CB8FDDC-0x000000018CB8FDE8 0x000000018CB8FF2C-0x000000018CB8FF50
		public bool IsPacked { get; set; } // 0x00000001878366AC-0x00000001878366C0 0x000000018CB8FEE4-0x000000018CB8FF08
		public bool OverwriteList { get; set; } // 0x000000018783667C-0x000000018783668C 0x000000018CB8FFE8-0x000000018CB9000C
		public bool IsRequired { get; set; } // 0x000000018CB8FDCC-0x000000018CB8FDDC 0x000000018CB8FF08-0x000000018CB8FF2C
		public bool AsReference { get; [Obsolete("Reference-tracking and dynamic-type are not currently implemented in this build; they may be reinstated later; this is partly due to doubts over whether the features are adviseable, and partly over confidence in testing all the scenarios (it takes time; that time hasn\'t get happened); feedback is invited", true)] set; } // 0x00000001843FFFF0-0x0000000184400000 0x000000018CB5E8B0-0x000000018CB5E8C8
		public bool DynamicType { get; [Obsolete("Reference-tracking and dynamic-type are not currently implemented in this build; they may be reinstated later; this is partly due to doubts over whether the features are adviseable, and partly over confidence in testing all the scenarios (it takes time; that time hasn\'t get happened); feedback is invited", true)] set; } // 0x00000001843FFFF0-0x0000000184400000 0x000000018CB5E8B0-0x000000018CB5E8C8
		public bool IsMap { get; set; } // 0x000000018CB8FDBC-0x000000018CB8FDCC 0x000000018CB8FEC0-0x000000018CB8FEE4
		public ProtoBuf.DataFormat MapKeyFormat { get; set; } // 0x00000001872333A0-0x00000001872333B0 0x0000000186A404D0-0x0000000186A40500
		public ProtoBuf.DataFormat MapValueFormat { get; set; } // 0x0000000187233370-0x0000000187233380 0x0000000186A404A0-0x0000000186A404D0
		public string Name { get; set; } // 0x000000018CB8FDE8-0x000000018CB8FE20 0x000000018CB8FF50-0x000000018CB8FF58
		public bool SupportNull { get; set; } // 0x000000018783666C-0x000000018783667C 0x000000018CB9000C-0x000000018CB90068
		internal bool NullWrappedValue { get; set; } // 0x000000018783669C-0x00000001878366AC 0x000000018CB8FFC4-0x000000018CB8FFE8
		internal bool NullWrappedValueGroup { get; set; } // 0x000000018CB8FE2C-0x000000018CB8FE3C 0x000000018CB8FFA0-0x000000018CB8FFC4
		internal bool NullWrappedCollection { get; set; } // 0x000000018783668C-0x000000018783669C 0x000000018CB8FF7C-0x000000018CB8FFA0
		internal bool NullWrappedCollectionGroup { get; set; } // 0x000000018CB8FE20-0x000000018CB8FE2C 0x000000018CB8FF58-0x000000018CB8FF7C
		internal bool RequiresGroupModifier { get; } // 0x000000018CB8FE3C-0x000000018CB8FE5C 
	
		// Nested types
		internal sealed class Comparer : System.Collections.IComparer, IComparer<ValueMember> // TypeDefIndex: 80716
		{
			// Fields
			public static readonly Comparer Default; // 0x00
	
			// Constructors
			public Comparer(); // 0x0000000186805BA0-0x0000000186805BB0
			static Comparer(); // 0x000000018CB7E4AC-0x000000018CB7E510
	
			// Methods
			public int Compare(object x, object y); // 0x000000018CB7E350-0x000000018CB7E3C8
			public int Compare(ValueMember x, ValueMember y); // 0x000000018CB7E210-0x000000018CB7E254
		}
	
		// Constructors
		public ValueMember(RuntimeTypeModel model, System.Type parentType, int fieldNumber, MemberInfo member, System.Type memberType, System.Type itemType, System.Type defaultType, ProtoBuf.DataFormat dataFormat, object defaultValue); // 0x0000000185859230-0x00000001858593C0
		internal ValueMember(RuntimeTypeModel model, int fieldNumber, System.Type memberType, System.Type itemType, System.Type defaultType, ProtoBuf.DataFormat dataFormat); // 0x00000001858593C0-0x0000000185859470
	
		// Methods
		internal static CompatibilityLevel GetEffectiveCompatibilityLevel(CompatibilityLevel compatibilityLevel, ProtoBuf.DataFormat dataFormat); // 0x00000001854C45F0-0x00000001854C4610
		internal object GetRawEnumValue(); // 0x000000018CB8FCAC-0x000000018CB8FD10
		private static object ParseDefaultValue(System.Type type, object value); // 0x0000000185858620-0x00000001858587F0
		public void SetSpecified(MethodInfo getSpecified, MethodInfo setSpecified); // 0x00000001858587F0-0x0000000185858940
		private void ThrowIfFrozen(); // 0x0000000185859550-0x0000000185859570
		internal static IRuntimeProtoSerializerNode CreateMap(RepeatedSerializerStub repeated, RuntimeTypeModel model, ProtoBuf.DataFormat dataFormat, CompatibilityLevel compatibilityLevel, ProtoBuf.DataFormat keyFormat, ProtoBuf.DataFormat valueFormat, bool asReference, bool dynamicType, bool isMap, bool overwriteList, int fieldNumber, ValueMember member); // 0x00000001854EB9F0-0x00000001854EBC50
		private void ComposeListFeatures(ref SerializerFeatures listFeatures); // 0x00000001854EC7D0-0x00000001854EC860
		private IRuntimeProtoSerializerNode BuildSerializer(); // 0x0000000185371DB0-0x0000000185375E10
		private static WireType GetIntWireType(ProtoBuf.DataFormat format, int width); // 0x00000001854C38A0-0x00000001854C38C0
		private static WireType GetDateTimeWireType(ProtoBuf.DataFormat format); // 0x000000018CB8FC2C-0x000000018CB8FCAC
		internal static IRuntimeProtoSerializerNode TryGetCoreSerializer(RuntimeTypeModel model, ProtoBuf.DataFormat dataFormat, CompatibilityLevel compatibilityLevel, System.Type type, out WireType defaultWireType, bool asReference, bool dynamicType, bool overwriteList, bool allowComplexTypes); // 0x00000001854C3F50-0x00000001854C45F0
		internal void SetName(string name); // 0x00000001858594A0-0x0000000185859520
		private bool HasFlag(ushort flag); // 0x00000001858589A0-0x00000001858589C0
		private void SetFlag(ushort flag, bool value, bool throwIfFrozen = true /* Metadata: 0x0263D16A */); // 0x0000000185858940-0x00000001858589A0
		internal bool HasExtendedNullSupport(); // 0x000000018CB8FD80-0x000000018CB8FDA8
		internal bool RequiresExtraLayerInSchema(); // 0x000000018CB8FDA8-0x000000018CB8FDBC
		internal string GetSchemaTypeName(HashSet<System.Type> callstack, bool applyNetObjectProxy, HashSet<string> imports, out string altName, bool considerWrappersProtoTypes = false /* Metadata: 0x0263D16B */); // 0x000000018CB8FD10-0x000000018CB8FD80
		[CompilerGenerated]
		internal static System.Type _CreateMap_g__FlattenRepeated_77_0(RuntimeTypeModel model, System.Type type); // 0x00000001854EBC50-0x00000001854EBCC0
	}
}

namespace ProtoBuf.Serializers
{
	public static class EnumSerializer // TypeDefIndex: 80605
	{
		// Methods
		public static EnumSerializer<T> CreateSByte<T>()
			where T : struct;
		public static EnumSerializer<T> CreateInt16<T>()
			where T : struct;
		public static EnumSerializer<T> CreateInt32<T>()
			where T : struct;
		public static EnumSerializer<T> CreateInt64<T>()
			where T : struct;
		public static EnumSerializer<T> CreateByte<T>()
			where T : struct;
		public static EnumSerializer<T> CreateUInt16<T>()
			where T : struct;
		public static EnumSerializer<T> CreateUInt32<T>()
			where T : struct;
		public static EnumSerializer<T> CreateUInt64<T>()
			where T : struct;
	}

	public abstract class EnumSerializer<TEnum> : ISerializer<TEnum>, ISerializer<TEnum?> // TypeDefIndex: 80606
		where TEnum : struct
	{
		// Properties
		SerializerFeatures ISerializer<TEnum>.Features { get; }
		SerializerFeatures ISerializer<TEnum?>.Features { get; }
	
		// Constructors
		private protected EnumSerializer();
	
		// Methods
		TEnum? ISerializer<TEnum?>.Read(ref ProtoReader.State state, TEnum? value);
		void ISerializer<TEnum?>.Write(ref ProtoWriter.State state, TEnum? value);
		public abstract TEnum Read(ref ProtoReader.State state, TEnum value);
		public abstract void Write(ref ProtoWriter.State state, TEnum value);
	}

	internal abstract class EnumSerializer<TEnum, TRaw> : EnumSerializer<TEnum>, IMeasuringSerializer<TEnum>, IMeasuringSerializer<TEnum?> // TypeDefIndex: 80607
		where TEnum : struct
		where TRaw : struct
	{
		// Fields
		private protected const int NegLength = 10; // Metadata: 0x0263CFF2
	
		// Constructors
		private protected EnumSerializer();
	
		// Methods
		protected abstract TRaw Read(ref ProtoReader.State state);
		protected abstract void Write(ref ProtoWriter.State state, TRaw value);
		public abstract int MeasureVarint(TRaw value);
		public virtual int MeasureSignedVarint(TRaw value);
		public override TEnum Read(ref ProtoReader.State state, TEnum value);
		public override void Write(ref ProtoWriter.State state, TEnum value);
		public int Measure(ISerializationContext context, WireType wireType, TEnum value);
		int IMeasuringSerializer<TEnum?>.Measure(ISerializationContext context, WireType wireType, TEnum? value);
	}

	internal sealed class EnumSerializerSByte<T> : EnumSerializer<T, sbyte> // TypeDefIndex: 80608
		where T : struct
	{
		// Constructors
		public EnumSerializerSByte();
	
		// Methods
		protected override sbyte Read(ref ProtoReader.State state);
		protected override void Write(ref ProtoWriter.State state, sbyte value);
		public override int MeasureVarint(sbyte value);
		public override int MeasureSignedVarint(sbyte value);
	}

	internal sealed class EnumSerializerInt16<T> : EnumSerializer<T, short> // TypeDefIndex: 80609
		where T : struct
	{
		// Constructors
		public EnumSerializerInt16();
	
		// Methods
		protected override short Read(ref ProtoReader.State state);
		protected override void Write(ref ProtoWriter.State state, short value);
		public override int MeasureVarint(short value);
		public override int MeasureSignedVarint(short value);
	}

	internal sealed class EnumSerializerInt32<T> : EnumSerializer<T, int> // TypeDefIndex: 80610
		where T : struct
	{
		// Constructors
		public EnumSerializerInt32();
	
		// Methods
		protected override int Read(ref ProtoReader.State state);
		protected override void Write(ref ProtoWriter.State state, int value);
		public override int MeasureVarint(int value);
		public override int MeasureSignedVarint(int value);
	}

	internal sealed class EnumSerializerInt64<T> : EnumSerializer<T, long> // TypeDefIndex: 80611
		where T : struct
	{
		// Constructors
		public EnumSerializerInt64();
	
		// Methods
		protected override long Read(ref ProtoReader.State state);
		protected override void Write(ref ProtoWriter.State state, long value);
		public override int MeasureVarint(long value);
		public override int MeasureSignedVarint(long value);
	}

	internal sealed class EnumSerializerByte<T> : EnumSerializer<T, byte> // TypeDefIndex: 80612
		where T : struct
	{
		// Constructors
		public EnumSerializerByte();
	
		// Methods
		protected override byte Read(ref ProtoReader.State state);
		protected override void Write(ref ProtoWriter.State state, byte value);
		public override int MeasureVarint(byte value);
	}

	internal sealed class EnumSerializerUInt16<T> : EnumSerializer<T, ushort> // TypeDefIndex: 80613
		where T : struct
	{
		// Constructors
		public EnumSerializerUInt16();
	
		// Methods
		protected override ushort Read(ref ProtoReader.State state);
		protected override void Write(ref ProtoWriter.State state, ushort value);
		public override int MeasureVarint(ushort value);
	}

	internal sealed class EnumSerializerUInt32<T> : EnumSerializer<T, uint> // TypeDefIndex: 80614
		where T : struct
	{
		// Constructors
		public EnumSerializerUInt32();
	
		// Methods
		protected override uint Read(ref ProtoReader.State state);
		protected override void Write(ref ProtoWriter.State state, uint value);
		public override int MeasureVarint(uint value);
	}

	internal sealed class EnumSerializerUInt64<T> : EnumSerializer<T, ulong> // TypeDefIndex: 80615
		where T : struct
	{
		// Constructors
		public EnumSerializerUInt64();
	
		// Methods
		protected override ulong Read(ref ProtoReader.State state);
		protected override void Write(ref ProtoWriter.State state, ulong value);
		public override int MeasureVarint(ulong value);
	}

	public interface IMemoryConverter<TStorage, TElement> // TypeDefIndex: 80616
	{
		// Methods
		TStorage NonNull([IsReadOnly] in ref TStorage value);
		int GetLength([IsReadOnly] in ref TStorage value);
		Memory<TElement> GetMemory([IsReadOnly] in ref TStorage value);
		Memory<TElement> Expand(ISerializationContext context, ref ref TStorage value, int additionalCapacity);
	}

	public sealed class DefaultMemoryConverter<T> : IMemoryConverter<T[], T>, IMemoryConverter<ArraySegment<T>, T>, IMemoryConverter<Memory<T>, T>, IMemoryConverter<ReadOnlyMemory<T>, T> // TypeDefIndex: 80618
	{
		// Fields
		[CompilerGenerated]
		private static readonly DefaultMemoryConverter<T> _Instance_k__BackingField;
	
		// Properties
		public static DefaultMemoryConverter<T> Instance { [CompilerGenerated] get; }
	
		// Nested types
		private static class ProtoBytesMemoryConverter<TStorage> // TypeDefIndex: 80617
		{
			// Fields
			internal static readonly IMemoryConverter<TStorage, T> Instance;
	
			// Constructors
			static ProtoBytesMemoryConverter();
	
			// Methods
			private static IMemoryConverter<TStorage, T> _Create();
		}
	
		// Constructors
		private DefaultMemoryConverter();
		static DefaultMemoryConverter();
	
		// Methods
		internal static IMemoryConverter<TStorage, T> GetFor<TStorage>(TypeModel model);
		private static IMemoryConverter<TStorage, T> NotSupported<TStorage>();
		T[] ProtoBuf.Serializers.IMemoryConverter<T[],T>.NonNull([IsReadOnly] in ref T[] value);
		int ProtoBuf.Serializers.IMemoryConverter<T[],T>.GetLength([IsReadOnly] in ref T[] value);
		Memory<T> ProtoBuf.Serializers.IMemoryConverter<T[],T>.GetMemory([IsReadOnly] in ref T[] value);
		Memory<T> ProtoBuf.Serializers.IMemoryConverter<T[],T>.Expand(ISerializationContext context, ref ref T[] value, int additionalCapacity);
		ArraySegment<T> IMemoryConverter<ArraySegment<T>, T>.NonNull([IsReadOnly] in ArraySegment<T> value);
		int IMemoryConverter<ArraySegment<T>, T>.GetLength([IsReadOnly] in ArraySegment<T> value);
		Memory<T> IMemoryConverter<ArraySegment<T>, T>.GetMemory([IsReadOnly] in ArraySegment<T> value);
		Memory<T> IMemoryConverter<ArraySegment<T>, T>.Expand(ISerializationContext context, ref ArraySegment<T> value, int additionalCapacity);
		Memory<T> IMemoryConverter<Memory<T>, T>.NonNull([IsReadOnly] in Memory<T> value);
		int IMemoryConverter<Memory<T>, T>.GetLength([IsReadOnly] in Memory<T> value);
		Memory<T> IMemoryConverter<Memory<T>, T>.GetMemory([IsReadOnly] in Memory<T> value);
		Memory<T> IMemoryConverter<Memory<T>, T>.Expand(ISerializationContext context, ref Memory<T> value, int additionalCapacity);
		ReadOnlyMemory<T> IMemoryConverter<ReadOnlyMemory<T>, T>.NonNull([IsReadOnly] in ReadOnlyMemory<T> value);
		int IMemoryConverter<ReadOnlyMemory<T>, T>.GetLength([IsReadOnly] in ReadOnlyMemory<T> value);
		Memory<T> IMemoryConverter<ReadOnlyMemory<T>, T>.GetMemory([IsReadOnly] in ReadOnlyMemory<T> value);
		Memory<T> IMemoryConverter<ReadOnlyMemory<T>, T>.Expand(ISerializationContext context, ref ReadOnlyMemory<T> value, int additionalCapacity);
	}

	[Flags]
	public enum SerializerFeatures // TypeDefIndex: 80619
	{
		CategoryRepeated = 0,
		WireTypeVarint = 16,
		WireTypeSpecified = 16,
		WireTypeFixed64 = 17,
		WireTypeString = 18,
		WireTypeStartGroup = 19,
		WireTypeFixed32 = 21,
		WireTypeSignedVarint = 24,
		CategoryScalar = 32,
		CategoryMessage = 64,
		CategoryMessageWrappedAtRoot = 96,
		OptionPackedDisabled = 128,
		OptionClearCollection = 256,
		OptionFailOnDuplicateKey = 512,
		OptionSkipRecursionCheck = 1024,
		OptionWrappedValue = 2048,
		OptionWrappedValueGroup = 4096,
		OptionWrappedValueFieldPresence = 8192,
		OptionWrappedCollection = 16384,
		OptionWrappedCollectionGroup = 32768
	}

	internal static class SerializerFeaturesExtensions // TypeDefIndex: 80620
	{
		// Fields
		private const SerializerFeatures CategoryMask = SerializerFeatures.CategoryRepeated | SerializerFeatures.CategoryScalar | SerializerFeatures.CategoryMessage | SerializerFeatures.CategoryMessageWrappedAtRoot; // Metadata: 0x0263D018
		private const SerializerFeatures WireTypeMask = SerializerFeatures.CategoryRepeated; // Metadata: 0x0263D01A
	
		// Methods
		private static void ThrowWireTypeNotSpecified(); // 0x000000018CB761B4-0x000000018CB761E8
	
		// Extension methods
		public static SerializerFeatures AsFeatures(this WireType wireType); // 0x000000018CB7608C-0x000000018CB760A0
		public static SerializerFeatures GetCategory(this SerializerFeatures features); // 0x0000000187254C20-0x0000000187254C30
		public static void InheritFrom(this ref SerializerFeatures features, SerializerFeatures overrides); // 0x000000018CB760BC-0x000000018CB760D4
		public static void HintIfNeeded(this SerializerFeatures features, ref ProtoReader.State state); // 0x000000018CB760A0-0x000000018CB760BC
		public static void ThrowInvalidCategory(this SerializerFeatures features); // 0x000000018CB76100-0x000000018CB761B4
		public static bool IsPackedDisabled(this SerializerFeatures features); // 0x000000018CB760E0-0x000000018CB760EC
		public static bool IsScalar(this SerializerFeatures features); // 0x000000018CB760F4-0x000000018CB76100
		public static bool IsRepeated(this SerializerFeatures features); // 0x000000018CB760EC-0x000000018CB760F4
		public static bool IsGroup(this SerializerFeatures features); // 0x000000018CB760D4-0x000000018CB760E0
		public static bool HasAny(this SerializerFeatures features, SerializerFeatures values); // 0x00000001892560F4-0x00000001892560FC
		public static T DefaultFor<T>(this SerializerFeatures features);
		public static WireType GetWireType(this SerializerFeatures features); // 0x0000000185894070-0x0000000185894090
		public static bool ApplyRecursionCheck(this SerializerFeatures features); // 0x000000018CB76080-0x000000018CB7608C
	}

	public interface ISerializer<T> // TypeDefIndex: 80621
	{
		// Properties
		SerializerFeatures Features { get; }
	
		// Methods
		T Read(ref ProtoReader.State state, T value);
		void Write(ref ProtoWriter.State state, T value);
	}

	public interface ISerializerProxy<T> // TypeDefIndex: 80622
	{
		// Properties
		ISerializer<T> Serializer { get; }
	}

	internal interface IMeasuringSerializer<T> : ISerializer<T> // TypeDefIndex: 80623
	{
		// Methods
		int Measure(ISerializationContext context, WireType wireType, T value);
	}

	public interface IRepeatedSerializer<T> : ISerializer<T> // TypeDefIndex: 80624
	{
		// Methods
		void WriteRepeated(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures features, T values);
		T ReadRepeated(ref ProtoReader.State state, SerializerFeatures features, T values);
	}

	[Obsolete("This API is deprecated and is never used; it will be removed soon", true)]
	public interface IObjectSerializer<T> : ISerializer<T> // TypeDefIndex: 80625
	{
		// Properties
		System.Type BaseType { get; }
	}

	public interface ISubTypeSerializer<T> // TypeDefIndex: 80626
		where T : class
	{
		// Methods
		void WriteSubType(ref ProtoWriter.State state, T value);
		T ReadSubType(ref ProtoReader.State state, SubTypeState<T> value);
	}

	public struct SubTypeState<T> // TypeDefIndex: 80627
		where T : class
	{
		// Fields
		private readonly ISerializationContext _context;
		private readonly Func<ISerializationContext, object> _ctor;
		private object _value;
		private Action<T, ISerializationContext> _onBeforeDeserialize;
	
		// Properties
		public T Value { get; set; }
		internal object RawValue { [IsReadOnly] get; }
		public bool HasValue { [IsReadOnly] get; }
	
		// Constructors
		private SubTypeState(ISerializationContext context, Func<ISerializationContext, object> ctor, object value, Action<T, ISerializationContext> onBeforeDeserialize);
	
		// Methods
		public static SubTypeState<T> Create<TValue>(ISerializationContext context, TValue value)
			where TValue : class, T;
		public void CreateIfNeeded();
		private T Cast();
		public void ReadSubType<TSubType>(ref ProtoReader.State state, ISubTypeSerializer<TSubType> serializer = null)
			where TSubType : class, T;
		public void OnBeforeDeserialize(Action<T, ISerializationContext> callback);
		[CompilerGenerated]
		internal static T _Cast_g__Merge_14_0(ISerializationContext context, object value, T typed);
	}

	public interface IFactory<T> // TypeDefIndex: 80628
	{
		// Methods
		T Create(ISerializationContext context);
	}

	public static class MapSerializer // TypeDefIndex: 80629
	{
		// Methods
		public static MapSerializer<TCollection, TKey, TValue> CreateConcurrentDictionary<TCollection, TKey, TValue>()
			where TCollection : ConcurrentDictionary<TKey, TValue>;
		public static MapSerializer<Dictionary<TKey, TValue>, TKey, TValue> CreateDictionary<TKey, TValue>();
		public static MapSerializer<TCollection, TKey, TValue> CreateDictionary<TCollection, TKey, TValue>()
			where TCollection : IDictionary<TKey, TValue>;
		public static MapSerializer<IReadOnlyDictionary<TKey, TValue>, TKey, TValue> CreateIReadOnlyDictionary<TKey, TValue>();
	}

	internal sealed class ConcurrentDictionarySerializer<TCollection, TKey, TValue> : MapSerializer<TCollection, TKey, TValue> // TypeDefIndex: 80630
		where TCollection : ConcurrentDictionary<TKey, TValue>
	{
		// Constructors
		public ConcurrentDictionarySerializer();
	
		// Methods
		protected override TCollection Clear(TCollection values, ISerializationContext context);
		protected override TCollection Initialize(TCollection values, ISerializationContext context);
		protected override TCollection AddRange(TCollection values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		protected override TCollection SetValues(TCollection values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, WireType wireType, TCollection values, [IsReadOnly] in KeyValuePairSerializer<TKey, TValue> pairSerializer);
	}

	public abstract class MapSerializer<TCollection, TKey, TValue> : IRepeatedSerializer<TCollection>, IFactory<TCollection> // TypeDefIndex: 80631
	{
		// Properties
		SerializerFeatures ISerializer<TCollection>.Features { get; }
	
		// Constructors
		protected MapSerializer();
	
		// Methods
		TCollection IFactory<TCollection>.Create(ISerializationContext context);
		TCollection ISerializer<TCollection>.Read(ref ProtoReader.State state, TCollection value);
		void ISerializer<TCollection>.Write(ref ProtoWriter.State state, TCollection value);
		void IRepeatedSerializer<TCollection>.WriteRepeated(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures features, TCollection values);
		TCollection IRepeatedSerializer<TCollection>.ReadRepeated(ref ProtoReader.State state, SerializerFeatures features, TCollection values);
		private static KeyValuePairSerializer<TKey, TValue> GetSerializer(TypeModel model, SerializerFeatures keyFeatures, SerializerFeatures valueFeatures, ISerializer<TKey> keySerializer, ISerializer<TValue> valueSerializer);
		public void WriteMap(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures features, TCollection values, SerializerFeatures keyFeatures, SerializerFeatures valueFeatures, ISerializer<TKey> keySerializer = null, ISerializer<TValue> valueSerializer = null);
		private void WriteNullWrapped(ref ProtoWriter.State state, SerializerFeatures features, int fieldNumber, TCollection values, SerializerFeatures keyFeatures, SerializerFeatures valueFeatures, ISerializer<TKey> keySerializer, ISerializer<TValue> valueSerializer);
		internal abstract void Write(ref ProtoWriter.State state, int fieldNumber, WireType wireType, TCollection values, [IsReadOnly] in KeyValuePairSerializer<TKey, TValue> pairSerializer);
		internal static void Write<TEnumerator>(ref ProtoWriter.State state, int fieldNumber, WireType wireType, ref ref TEnumerator enumerator, [IsReadOnly] in KeyValuePairSerializer<TKey, TValue> pairSerializer)
			where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>>;
		protected virtual TCollection Initialize(TCollection values, ISerializationContext context);
		protected abstract TCollection Clear(TCollection values, ISerializationContext context);
		protected abstract TCollection AddRange(TCollection values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		protected abstract TCollection SetValues(TCollection values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		public TCollection ReadMap(ref ProtoReader.State state, SerializerFeatures features, TCollection values, SerializerFeatures keyFeatures, SerializerFeatures valueFeatures, ISerializer<TKey> keySerializer = null, ISerializer<TValue> valueSerializer = null);
		private TCollection ReadNullWrapped(ref ProtoReader.State state, SerializerFeatures features, TCollection values, SerializerFeatures keyFeatures, SerializerFeatures valueFeatures, ISerializer<TKey> keySerializer, ISerializer<TValue> valueSerializer);
	}

	internal sealed class DictionarySerializer<TKey, TValue> : MapSerializer<Dictionary<TKey, TValue>, TKey, TValue> // TypeDefIndex: 80632
	{
		// Constructors
		public DictionarySerializer();
	
		// Methods
		protected override Dictionary<TKey, TValue> Initialize(Dictionary<TKey, TValue> values, ISerializationContext context);
		protected override Dictionary<TKey, TValue> Clear(Dictionary<TKey, TValue> values, ISerializationContext context);
		protected override Dictionary<TKey, TValue> AddRange(Dictionary<TKey, TValue> values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		protected override Dictionary<TKey, TValue> SetValues(Dictionary<TKey, TValue> values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, WireType wireType, Dictionary<TKey, TValue> values, [IsReadOnly] in KeyValuePairSerializer<TKey, TValue> pairSerializer);
	}

	internal class DictionarySerializer<TCollection, TKey, TValue> : MapSerializer<TCollection, TKey, TValue> // TypeDefIndex: 80633
		where TCollection : IDictionary<TKey, TValue>
	{
		// Constructors
		public DictionarySerializer();
	
		// Methods
		protected override TCollection Initialize(TCollection values, ISerializationContext context);
		protected override TCollection Clear(TCollection values, ISerializationContext context);
		protected override TCollection AddRange(TCollection values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		protected override TCollection SetValues(TCollection values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, WireType wireType, TCollection values, [IsReadOnly] in KeyValuePairSerializer<TKey, TValue> pairSerializer);
	}

	internal sealed class DictionaryOfIReadOnlyDictionarySerializer<TKey, TValue> : MapSerializer<IReadOnlyDictionary<TKey, TValue>, TKey, TValue> // TypeDefIndex: 80634
	{
		// Constructors
		public DictionaryOfIReadOnlyDictionarySerializer();
	
		// Methods
		protected override IReadOnlyDictionary<TKey, TValue> Initialize(IReadOnlyDictionary<TKey, TValue> values, ISerializationContext context);
		protected override IReadOnlyDictionary<TKey, TValue> Clear(IReadOnlyDictionary<TKey, TValue> values, ISerializationContext context);
		protected override IReadOnlyDictionary<TKey, TValue> AddRange(IReadOnlyDictionary<TKey, TValue> values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		protected override IReadOnlyDictionary<TKey, TValue> SetValues(IReadOnlyDictionary<TKey, TValue> values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, WireType wireType, IReadOnlyDictionary<TKey, TValue> values, [IsReadOnly] in KeyValuePairSerializer<TKey, TValue> pairSerializer);
	}

	public abstract class ExternalMapSerializer<TCollection, TKey, TValue> : MapSerializer<TCollection, TKey, TValue> // TypeDefIndex: 80635
		where TCollection : IEnumerable<KeyValuePair<TKey, TValue>>
	{
		// Constructors
		protected ExternalMapSerializer();
	
		// Methods
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, WireType wireType, TCollection values, [IsReadOnly] in KeyValuePairSerializer<TKey, TValue> pairSerializer);
	}

	public static class RepeatedSerializer // TypeDefIndex: 80636
	{
		// Methods
		public static RepeatedSerializer<TCollection, T> CreateConcurrentBag<TCollection, T>()
			where TCollection : ConcurrentBag<T>;
		public static RepeatedSerializer<TCollection, T> CreateConcurrentStack<TCollection, T>()
			where TCollection : ConcurrentStack<T>;
		public static RepeatedSerializer<TCollection, T> CreateConcurrentQueue<TCollection, T>()
			where TCollection : ConcurrentQueue<T>;
		public static RepeatedSerializer<TCollection, T> CreateIProducerConsumerCollection<TCollection, T>()
			where TCollection : class, IProducerConsumerCollection<T>;
		[Obsolete("Since this isn\'t supported, you probably shouldn\'t be doing it...", false)]
		public static RepeatedSerializer<TCollection, T> CreateNestedDataNotSupported<TCollection, T>();
		[Obsolete("Since this isn\'t supported, you probably shouldn\'t be doing it...", false)]
		public static RepeatedSerializer<TCollection, T> CreateNotSupported<TCollection, T>();
		public static RepeatedSerializer<List<T>, T> CreateList<T>();
		public static RepeatedSerializer<TList, T> CreateList<TList, T>()
			where TList : List<T>;
		public static RepeatedSerializer<TCollection, T> CreateEnumerable<TCollection, T>()
			where TCollection : class, IEnumerable<T>;
		public static RepeatedSerializer<TCollection, T> CreateEnumerable<TCollection, TCreate, T>()
			where TCollection : class, IEnumerable<T>
			where TCreate : TCollection;
		public static RepeatedSerializer<T[], T> CreateVector<T>();
		public static RepeatedSerializer<TCollection, T> CreateQueue<TCollection, T>()
			where TCollection : Queue<T>;
		public static RepeatedSerializer<TCollection, T> CreateStack<TCollection, T>()
			where TCollection : Stack<T>;
		public static RepeatedSerializer<TCollection, T> CreateSet<TCollection, T>()
			where TCollection : ISet<T>;
	
		// Extension methods
		internal static void ReverseInPlace<T>(this ref ArraySegment<T> values);
		internal static ref ref T Singleton<T>(this ref ArraySegment<T> values);
	}

	internal class ProducerConsumerSerializer<TCollection, T> : RepeatedSerializer<TCollection, T> // TypeDefIndex: 80637
		where TCollection : class, IProducerConsumerCollection<T>
	{
		// Constructors
		public ProducerConsumerSerializer();
	
		// Methods
		protected override TCollection Clear(TCollection values, ISerializationContext context);
		protected override TCollection AddRange(TCollection values, ref ArraySegment<T> newValues, ISerializationContext context);
		protected override TCollection Initialize(TCollection values, ISerializationContext context);
		protected override int TryGetCount(TCollection values);
		internal override long Measure(TCollection values, IMeasuringSerializer<T> serializer, ISerializationContext context, WireType wireType);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures category, WireType wireType, TCollection values, ISerializer<T> serializer, SerializerFeatures features);
		internal override void WritePacked(ref ProtoWriter.State state, TCollection values, IMeasuringSerializer<T> serializer, WireType wireType);
	}

	internal sealed class ConcurrentBagSerializer<TCollection, T> : ProducerConsumerSerializer<TCollection, T> // TypeDefIndex: 80638
		where TCollection : ConcurrentBag<T>
	{
		// Constructors
		public ConcurrentBagSerializer();
	
		// Methods
		protected override TCollection AddRange(TCollection values, ref ArraySegment<T> newValues, ISerializationContext context);
	}

	internal sealed class ConcurrentQueueSerializer<TCollection, T> : ProducerConsumerSerializer<TCollection, T> // TypeDefIndex: 80639
		where TCollection : ConcurrentQueue<T>
	{
		// Constructors
		public ConcurrentQueueSerializer();
	
		// Methods
		protected override TCollection AddRange(TCollection values, ref ArraySegment<T> newValues, ISerializationContext context);
	}

	internal sealed class ConcurrentStackSerializer<TCollection, T> : ProducerConsumerSerializer<TCollection, T> // TypeDefIndex: 80640
		where TCollection : ConcurrentStack<T>
	{
		// Constructors
		public ConcurrentStackSerializer();
	
		// Methods
		protected override TCollection Clear(TCollection values, ISerializationContext context);
		protected override TCollection AddRange(TCollection values, ref ArraySegment<T> newValues, ISerializationContext context);
	}

	public abstract class RepeatedSerializer<TCollection, TItem> : IRepeatedSerializer<TCollection>, IFactory<TCollection> // TypeDefIndex: 80641
	{
		// Properties
		SerializerFeatures ISerializer<TCollection>.Features { get; }
	
		// Constructors
		protected RepeatedSerializer();
	
		// Methods
		TCollection IFactory<TCollection>.Create(ISerializationContext context);
		void IRepeatedSerializer<TCollection>.WriteRepeated(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures features, TCollection values);
		TCollection IRepeatedSerializer<TCollection>.ReadRepeated(ref ProtoReader.State state, SerializerFeatures features, TCollection values);
		TCollection ISerializer<TCollection>.Read(ref ProtoReader.State state, TCollection value);
		void ISerializer<TCollection>.Write(ref ProtoWriter.State state, TCollection value);
		private void WriteNullWrapped(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures features, TCollection values, ISerializer<TItem> serializer);
		public void WriteRepeated(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures features, TCollection values, ISerializer<TItem> serializer = null);
		private static void WriteZeroLengthPackedHeader(ref ProtoWriter.State state, int fieldNumber);
		internal abstract void Write(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures category, WireType wireType, TCollection values, ISerializer<TItem> serializer, SerializerFeatures features);
		internal static void Write<TEnumerator>(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures category, WireType wireType, ref ref TEnumerator values, ISerializer<TItem> serializer, SerializerFeatures features)
			where TEnumerator : IEnumerator<TItem>;
		internal abstract long Measure(TCollection values, IMeasuringSerializer<TItem> serializer, ISerializationContext context, WireType wireType);
		internal static long Measure<TEnumerator>(ref ref TEnumerator values, IMeasuringSerializer<TItem> serializer, ISerializationContext context, WireType wireType)
			where TEnumerator : IEnumerator<TItem>;
		internal abstract void WritePacked(ref ProtoWriter.State state, TCollection values, IMeasuringSerializer<TItem> serializer, WireType wireType);
		internal static void WritePacked<TEnumerator>(ref ProtoWriter.State state, ref ref TEnumerator values, IMeasuringSerializer<TItem> serializer, WireType wireType)
			where TEnumerator : IEnumerator<TItem>;
		private void WritePacked(ref ProtoWriter.State state, int fieldNumber, WireType wireType, TCollection values, int count, IMeasuringSerializer<TItem> serializer);
		protected abstract int TryGetCount(TCollection values);
		protected int TryGetCountDefault(TCollection values);
		private TCollection ReadNullWrapped(ref ProtoReader.State state, SerializerFeatures features, TCollection values, ISerializer<TItem> serializer);
		public TCollection ReadRepeated(ref ProtoReader.State state, SerializerFeatures features, TCollection values, ISerializer<TItem> serializer = null);
		protected virtual TCollection Initialize(TCollection values, ISerializationContext context);
		protected abstract TCollection Clear(TCollection values, ISerializationContext context);
		protected abstract TCollection AddRange(TCollection values, ref ArraySegment<TItem> newValues, ISerializationContext context);
	}

	internal sealed class StackSerializer<TCollection, T> : RepeatedSerializer<TCollection, T> // TypeDefIndex: 80642
		where TCollection : Stack<T>
	{
		// Constructors
		public StackSerializer();
	
		// Methods
		protected override TCollection Initialize(TCollection values, ISerializationContext context);
		protected override TCollection Clear(TCollection values, ISerializationContext context);
		protected override int TryGetCount(TCollection values);
		protected override TCollection AddRange(TCollection values, ref ArraySegment<T> newValues, ISerializationContext context);
		internal override long Measure(TCollection values, IMeasuringSerializer<T> serializer, ISerializationContext context, WireType wireType);
		internal override void WritePacked(ref ProtoWriter.State state, TCollection values, IMeasuringSerializer<T> serializer, WireType wireType);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures category, WireType wireType, TCollection values, ISerializer<T> serializer, SerializerFeatures features);
	}

	internal sealed class ListSerializer<T> : ListSerializer<List<T>, T> // TypeDefIndex: 80643
	{
		// Constructors
		public ListSerializer();
	
		// Methods
		protected override List<T> Initialize(List<T> values, ISerializationContext context);
	}

	internal class ListSerializer<TList, T> : RepeatedSerializer<TList, T> // TypeDefIndex: 80644
		where TList : List<T>
	{
		// Constructors
		public ListSerializer();
	
		// Methods
		protected override TList Initialize(TList values, ISerializationContext context);
		protected override TList Clear(TList values, ISerializationContext context);
		protected override TList AddRange(TList values, ref ArraySegment<T> newValues, ISerializationContext context);
		protected override int TryGetCount(TList values);
		internal override long Measure(TList values, IMeasuringSerializer<T> serializer, ISerializationContext context, WireType wireType);
		internal override void WritePacked(ref ProtoWriter.State state, TList values, IMeasuringSerializer<T> serializer, WireType wireType);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures category, WireType wireType, TList values, ISerializer<T> serializer, SerializerFeatures features);
	}

	internal class EnumerableSerializer<TCollection, TCreate, T> : RepeatedSerializer<TCollection, T> // TypeDefIndex: 80645
		where TCollection : class, IEnumerable<T>
		where TCreate : TCollection
	{
		// Constructors
		public EnumerableSerializer();
	
		// Methods
		protected override TCollection Initialize(TCollection values, ISerializationContext context);
		protected override int TryGetCount(TCollection values);
		internal override long Measure(TCollection values, IMeasuringSerializer<T> serializer, ISerializationContext context, WireType wireType);
		internal override void WritePacked(ref ProtoWriter.State state, TCollection values, IMeasuringSerializer<T> serializer, WireType wireType);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures category, WireType wireType, TCollection values, ISerializer<T> serializer, SerializerFeatures features);
		private static void ThrowInvalidCollectionType(object collection);
		protected override TCollection Clear(TCollection values, ISerializationContext context);
		protected override TCollection AddRange(TCollection values, ref ArraySegment<T> newValues, ISerializationContext context);
	}

	internal sealed class VectorSerializer<T> : RepeatedSerializer<T[], T> // TypeDefIndex: 80647
	{
		// Nested types
		private struct Enumerator : IEnumerator<T> // TypeDefIndex: 80646
		{
			// Fields
			private readonly T[] _array;
			private int _index;
	
			// Properties
			public T Current { [IsReadOnly] get; }
			object IEnumerator.Current { [IsReadOnly] get; }
	
			// Constructors
			public Enumerator(T[] array);
	
			// Methods
			[IsReadOnly]
			public void Reset();
			public bool MoveNext();
			[IsReadOnly]
			public void Dispose();
		}
	
		// Constructors
		public VectorSerializer();
	
		// Methods
		protected override T[] Initialize(T[] values, ISerializationContext context);
		protected override T[] Clear(T[] values, ISerializationContext context);
		protected override T[] AddRange(T[] values, ref ArraySegment<T> newValues, ISerializationContext context);
		protected override int TryGetCount(T[] values);
		internal override long Measure(T[] values, IMeasuringSerializer<T> serializer, ISerializationContext context, WireType wireType);
		internal override void WritePacked(ref ProtoWriter.State state, T[] values, IMeasuringSerializer<T> serializer, WireType wireType);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures category, WireType wireType, T[] values, ISerializer<T> serializer, SerializerFeatures features);
	}

	internal sealed class QueueSerializer<TCollection, T> : RepeatedSerializer<TCollection, T> // TypeDefIndex: 80648
		where TCollection : Queue<T>
	{
		// Constructors
		public QueueSerializer();
	
		// Methods
		protected override TCollection Initialize(TCollection values, ISerializationContext context);
		protected override TCollection Clear(TCollection values, ISerializationContext context);
		protected override int TryGetCount(TCollection values);
		protected override TCollection AddRange(TCollection values, ref ArraySegment<T> newValues, ISerializationContext context);
		internal override long Measure(TCollection values, IMeasuringSerializer<T> serializer, ISerializationContext context, WireType wireType);
		internal override void WritePacked(ref ProtoWriter.State state, TCollection values, IMeasuringSerializer<T> serializer, WireType wireType);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures category, WireType wireType, TCollection values, ISerializer<T> serializer, SerializerFeatures features);
	}

	internal sealed class SetSerializer<TCollection, T> : RepeatedSerializer<TCollection, T> // TypeDefIndex: 80649
		where TCollection : ISet<T>
	{
		// Constructors
		public SetSerializer();
	
		// Methods
		protected override TCollection Initialize(TCollection values, ISerializationContext context);
		protected override TCollection Clear(TCollection values, ISerializationContext context);
		protected override int TryGetCount(TCollection values);
		protected override TCollection AddRange(TCollection values, ref ArraySegment<T> newValues, ISerializationContext context);
		internal override long Measure(TCollection values, IMeasuringSerializer<T> serializer, ISerializationContext context, WireType wireType);
		internal override void WritePacked(ref ProtoWriter.State state, TCollection values, IMeasuringSerializer<T> serializer, WireType wireType);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures category, WireType wireType, TCollection values, ISerializer<T> serializer, SerializerFeatures features);
	}

	public abstract class ExternalSerializer<TCollection, T> : RepeatedSerializer<TCollection, T> // TypeDefIndex: 80650
		where TCollection : IEnumerable<T>
	{
		// Constructors
		protected ExternalSerializer();
	
		// Methods
		internal override long Measure(TCollection values, IMeasuringSerializer<T> serializer, ISerializationContext context, WireType wireType);
		internal override void WritePacked(ref ProtoWriter.State state, TCollection values, IMeasuringSerializer<T> serializer, WireType wireType);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures category, WireType wireType, TCollection values, ISerializer<T> serializer, SerializerFeatures features);
	}

	internal static class SerializerCache<TProvider> // TypeDefIndex: 80651
		where TProvider : class
	{
		// Fields
		internal static readonly TProvider InstanceField;
	
		// Constructors
		static SerializerCache();
	
		// Methods
		public static ISerializer<T> GetSerializer<T>();
	}

	internal static class SerializerCache<TProvider, T> // TypeDefIndex: 80652
		where TProvider : class
	{
		// Fields
		internal static readonly ISerializer<T> InstanceField;
	
		// Properties
		public static ISerializer<T> Instance { get; }
	
		// Constructors
		static SerializerCache();
	}

	public static class SerializerCache // TypeDefIndex: 80653
	{
		// Methods
		private static void ThrowInvalidSerializer<T>(ISerializer<T> serializer, string message, Exception innerException = null);
		internal static ISerializer<T> Verify<T>(ISerializer<T> serializer);
		public static ISerializer<T> Get<TProvider, T>()
			where TProvider : class;
		internal static object GetInstance(System.Type providerType, System.Type type); // 0x000000018CB75F58-0x000000018CB76080
	}

	public static class ProtoRepeatedFieldSerializer // TypeDefIndex: 80654
	{
		// Methods
		public static RepeatedSerializer<RepeatedField<T>, T> Create<T>();
	}

	internal sealed class ProtoRepeatedFieldSerializer<T> : RepeatedSerializer<RepeatedField<T>, T> // TypeDefIndex: 80655
	{
		// Constructors
		public ProtoRepeatedFieldSerializer();
	
		// Methods
		protected override RepeatedField<T> Initialize(RepeatedField<T> values, ISerializationContext context);
		protected override RepeatedField<T> Clear(RepeatedField<T> values, ISerializationContext context);
		protected override RepeatedField<T> AddRange(RepeatedField<T> values, ref ArraySegment<T> newValues, ISerializationContext context);
		protected override int TryGetCount(RepeatedField<T> values);
		internal override long Measure(RepeatedField<T> values, IMeasuringSerializer<T> serializer, ISerializationContext context, WireType wireType);
		internal override void WritePacked(ref ProtoWriter.State state, RepeatedField<T> values, IMeasuringSerializer<T> serializer, WireType wireType);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, SerializerFeatures category, WireType wireType, RepeatedField<T> values, ISerializer<T> serializer, SerializerFeatures features);
	}

	public static class ProtoMapFieldSerializer // TypeDefIndex: 80656
	{
		// Methods
		public static MapSerializer<MapField<TKey, TValue>, TKey, TValue> Create<TKey, TValue>();
	}

	public static class ProtoAotSerializerBootstrap // TypeDefIndex: 80657
	{
		// Methods
		public static void TouchEnumSByte<TEnum>()
			where TEnum : struct;
		public static void TouchEnumInt16<TEnum>()
			where TEnum : struct;
		public static void TouchEnumInt32<TEnum>()
			where TEnum : struct;
		public static void TouchEnumInt64<TEnum>()
			where TEnum : struct;
		public static void TouchEnumByte<TEnum>()
			where TEnum : struct;
		public static void TouchEnumUInt16<TEnum>()
			where TEnum : struct;
		public static void TouchEnumUInt32<TEnum>()
			where TEnum : struct;
		public static void TouchEnumUInt64<TEnum>()
			where TEnum : struct;
		public static void TouchValueTypeBox<T>()
			where T : struct;
		public static void TouchStructValueChecker<T>()
			where T : struct;
		public static void TouchRepeatedFieldSerializer<T>();
		public static void TouchMapFieldSerializer<TKey, TValue>();
		public static void TouchMapFieldKeyValuePairChecker<TKey, TValue>();
		public static void TouchRepeatedFieldDecorator<T>();
		public static void TouchMapFieldDecorator<TKey, TValue>();
	}

	internal sealed class ProtoMapFieldSerializer<TKey, TValue> : MapSerializer<MapField<TKey, TValue>, TKey, TValue> // TypeDefIndex: 80658
	{
		// Constructors
		public ProtoMapFieldSerializer();
	
		// Methods
		protected override MapField<TKey, TValue> Initialize(MapField<TKey, TValue> values, ISerializationContext context);
		protected override MapField<TKey, TValue> Clear(MapField<TKey, TValue> values, ISerializationContext context);
		protected override MapField<TKey, TValue> AddRange(MapField<TKey, TValue> values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		protected override MapField<TKey, TValue> SetValues(MapField<TKey, TValue> values, ref ArraySegment<KeyValuePair<TKey, TValue>> newValues, ISerializationContext context);
		internal override void Write(ref ProtoWriter.State state, int fieldNumber, WireType wireType, MapField<TKey, TValue> values, [IsReadOnly] in KeyValuePairSerializer<TKey, TValue> pairSerializer);
	}

	internal static class EnumSerializers // TypeDefIndex: 80659
	{
		// Methods
		internal static object GetSerializer(System.Type type); // 0x0000000186B56B30-0x0000000186B56C00
		internal static MemberInfo GetProvider(System.Type type); // 0x0000000186B56C00-0x0000000186B56DD0
	}

	internal static class RepeatedSerializers // TypeDefIndex: 80664
	{
		// Fields
		private static readonly Hashtable s_providers; // 0x00
		private static readonly Hashtable s_methodsPerDeclaringType; // 0x08
		private static readonly Hashtable s_knownTypes; // 0x10
		private static readonly Registration s_Array; // 0x18
		private static readonly System.Type[] NotSupportedFlavors; // 0x20
		private static readonly MethodInfo s_NestedNotSupported; // 0x28
		private static readonly MethodInfo s_GeneralNotSupported; // 0x30
	
		// Nested types
		[IsReadOnly]
		private struct MethodTuple // TypeDefIndex: 80660
		{
			// Fields
			[CompilerGenerated]
			private readonly MethodInfo _Method_k__BackingField; // 0x00
			[CompilerGenerated]
			private readonly int _GenericArgCount_k__BackingField; // 0x08
	
			// Properties
			public string Name { get; } // 0x00000001854F5F40-0x00000001854F5F60 
			private MethodInfo Method { [CompilerGenerated] get; } // 0x0000000184431970-0x0000000184431980 
			public int GenericArgCount { [CompilerGenerated] get; } // 0x0000000184431A70-0x0000000184431A80 
	
			// Constructors
			public MethodTuple(MethodInfo method); // 0x0000000186ECFE40-0x0000000186ECFEA0
	
			// Methods
			public MethodInfo Construct(System.Type[] targs); // 0x00000001854F5F60-0x00000001854F5F90
		}
	
		private sealed class Registration // TypeDefIndex: 80661
		{
			// Fields
			[CompilerGenerated]
			private readonly bool _ExactOnly_k__BackingField; // 0x10
			[CompilerGenerated]
			private readonly int _Priority_k__BackingField; // 0x14
			[CompilerGenerated]
			private readonly Func<System.Type, System.Type, System.Type[], MemberInfo> _Implementation_k__BackingField; // 0x18
	
			// Properties
			public bool ExactOnly { [CompilerGenerated] get; } // 0x00000001829D0800-0x00000001829D0810 
			public int Priority { [CompilerGenerated] get; } // 0x0000000182971EE0-0x0000000182971EF0 
			private Func<System.Type, System.Type, System.Type[], MemberInfo> Implementation { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			public Registration(int priority, Func<System.Type, System.Type, System.Type[], MemberInfo> implementation, bool exactOnly); // 0x000000018680AF90-0x000000018680AFB0
	
			// Methods
			public MemberInfo Resolve(System.Type root, System.Type current); // 0x0000000186582400-0x00000001865824D0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 80662
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Converter<MethodInfo, MethodTuple> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E5D20-0x00000001871E5D80
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal MethodTuple _Resolve_b__3_0(MethodInfo m); // 0x0000000186ECFE10-0x0000000186ECFE40
			internal MemberInfo _.cctor_b__6_0(System.Type root, System.Type current, System.Type[] targs); // 0x00000001854F47A0-0x00000001854F4860
			internal MemberInfo _.cctor_b__6_1(System.Type root, System.Type current, System.Type[] targs); // 0x00000001869F50D0-0x00000001869F5190
			internal MemberInfo _.cctor_b__6_2(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7C9E0-0x000000018CB7CB1C
			internal MemberInfo _.cctor_b__6_3(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7CB1C-0x000000018CB7CC78
			internal MemberInfo _.cctor_b__6_4(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7CC78-0x000000018CB7CDAC
			internal MemberInfo _.cctor_b__6_5(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7CDAC-0x000000018CB7CEE0
			internal MemberInfo _.cctor_b__6_6(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7CEE0-0x000000018CB7D014
			internal MemberInfo _.cctor_b__6_7(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7D014-0x000000018CB7D148
			internal MemberInfo _.cctor_b__6_8(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7D148-0x000000018CB7D2B4
			internal MemberInfo _.cctor_b__6_9(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7D2B4-0x000000018CB7D410
			internal MemberInfo _.cctor_b__6_10(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7C284-0x000000018CB7C31C
			internal MemberInfo _.cctor_b__6_11(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7C31C-0x000000018CB7C450
			internal MemberInfo _.cctor_b__6_12(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7C450-0x000000018CB7C584
			internal MemberInfo _.cctor_b__6_13(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7C584-0x000000018CB7C6B8
			internal MemberInfo _.cctor_b__6_14(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7C6B8-0x000000018CB7C7EC
			internal MemberInfo _.cctor_b__6_15(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7C7EC-0x000000018CB7C920
			internal MemberInfo _.cctor_b__6_16(System.Type root, System.Type current, System.Type[] targs); // 0x000000018CB7C920-0x000000018CB7C9E0
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass14_0 // TypeDefIndex: 80663
		{
			// Fields
			public int bestMatchPriority; // 0x00
			public MemberInfo bestMatch; // 0x08
			public bool bestIsAmbiguous; // 0x10
		}
	
		// Constructors
		static RepeatedSerializers(); // 0x0000000186809E70-0x000000018680AB40
	
		// Methods
		internal static MemberInfo Resolve(System.Type declaringType, string methodName, System.Type[] targs); // 0x00000001854F5A90-0x00000001854F5F40
		public static void Add(System.Type type, Func<System.Type, System.Type, System.Type[], MemberInfo> implementation, bool exactOnly = true /* Metadata: 0x0263D01B */, Hashtable externalProviders = null); // 0x000000018680AB40-0x000000018680AF90
		internal static RepeatedSerializerStub TryGetRepeatedProvider(System.Type type, Hashtable externalProvders = null); // 0x0000000185371750-0x0000000185371DA0
		internal static RepeatedSerializerStub NotSupported(MethodInfo kind, System.Type collectionType, System.Type itemType); // 0x000000018CB757C0-0x000000018CB75898
		private static bool TestIfNestedNotSupported(RepeatedSerializerStub repeated); // 0x000000018653AA30-0x000000018653AAF0
		private static MemberInfo GetProviderForType(System.Type type, Hashtable externalProviders); // 0x00000001854BF940-0x00000001854C0000
		private static bool TryGetProvider(System.Type root, System.Type current, int bestMatchPriority, out MemberInfo member, out int priority); // 0x00000001854C0000-0x00000001854C0200
		private static bool TryGetExternalProvider(System.Type root, System.Type current, int bestMatchPriority, out MemberInfo member, out int priority, Hashtable externalProviders); // 0x000000018CB75898-0x000000018CB75A08
		[CompilerGenerated]
		internal static void _GetProviderForType_g__Consider_14_0(MemberInfo member, int priority, ref __c__DisplayClass14_0 param_000ad08d); // 0x00000001867C8190-0x00000001867C81C0
	}

	internal sealed class RepeatedSerializerStub // TypeDefIndex: 80665
	{
		// Fields
		internal static readonly RepeatedSerializerStub Empty; // 0x00
		[CompilerGenerated]
		private readonly MemberInfo _Provider_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly bool _IsMap_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly System.Type _ForType_k__BackingField; // 0x20
		[CompilerGenerated]
		private readonly System.Type _ItemType_k__BackingField; // 0x28
		private object _serializer; // 0x30
	
		// Properties
		public MemberInfo Provider { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		public bool IsMap { [CompilerGenerated] get; } // 0x000000018225E050-0x000000018225E060 
		public bool IsEmpty { get; } // 0x0000000185371DA0-0x0000000185371DB0 
		public object Serializer { get; } // 0x00000001854EC5F0-0x00000001854EC610 
		public System.Type ForType { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
		public System.Type ItemType { [CompilerGenerated] get; } // 0x0000000182262130-0x0000000182262140 
	
		// Constructors
		private RepeatedSerializerStub(System.Type forType, MemberInfo provider); // 0x0000000186326D70-0x0000000186326E20
		static RepeatedSerializerStub(); // 0x0000000186326C70-0x0000000186326CF0
	
		// Methods
		internal bool IsValidProtobufMap(RuntimeTypeModel model, CompatibilityLevel compatibilityLevel, ProtoBuf.DataFormat dataFormat); // 0x00000001854EC860-0x00000001854EC9D0
		private object CreateSerializer(); // 0x00000001854EC610-0x00000001854EC710
		internal void EmitProvider(CompilerContext ctx); // 0x000000018CB757A4-0x000000018CB757C0
		private void EmitProvider(ILGenerator il); // 0x000000018CB75740-0x000000018CB757A4
		public static RepeatedSerializerStub Create(System.Type forType, MemberInfo provider); // 0x0000000186326CF0-0x0000000186326D70
		private static bool CheckIsMap(MemberInfo provider, out System.Type itemType); // 0x0000000186326E20-0x0000000186327150
		internal void ResolveMapTypes(out System.Type keyType, out System.Type valueType); // 0x00000001854EC9D0-0x00000001854ECA60
		[CompilerGenerated]
		internal static bool _IsValidProtobufMap_g__IsValidKey_7_0(System.Type type, CompatibilityLevel compatibilityLevel, ProtoBuf.DataFormat dataFormat); // 0x00000001854ECA60-0x00000001854ECB80
	}
}

namespace ProtoBuf.WellKnownTypes
{
	[IsReadOnly]
	[ProtoContract(Name = ".google.protobuf.Duration", Serializer = typeof(PrimaryTypeProvider), Origin = "google/protobuf/duration.proto")]
	public struct Duration // TypeDefIndex: 80602
	{
		// Fields
		[CompilerGenerated]
		private readonly long _Seconds_k__BackingField; // 0x00
		[CompilerGenerated]
		private readonly int _Nanoseconds_k__BackingField; // 0x08
	
		// Properties
		[ProtoMember(1, Name = "seconds", DataFormat = ProtoBuf.DataFormat.Default)]
		public long Seconds { [CompilerGenerated] get; } // 0x0000000184431970-0x0000000184431980 
		[ProtoMember(2, Name = "nanos", DataFormat = ProtoBuf.DataFormat.Default)]
		public int Nanoseconds { [CompilerGenerated] get; } // 0x0000000184431A70-0x0000000184431A80 
	
		// Constructors
		public Duration(long seconds, int nanoseconds); // 0x0000000184547F50-0x0000000184547F60
		public Duration(TimeSpan value); // 0x000000018CB6D960-0x000000018CB6D9BC
		internal Duration(long ticks); // 0x000000018CB6D9BC-0x000000018CB6DA24
	
		// Methods
		public TimeSpan AsTimeSpan(); // 0x000000018CB6D83C-0x000000018CB6D88C
		internal long ToTicks(); // 0x000000018CB6D90C-0x000000018CB6D960
		public static implicit operator TimeSpan(Duration value); // 0x000000018CB6DA44-0x000000018CB6DA54
		public static implicit operator Duration(TimeSpan value); // 0x000000018CB6DA24-0x000000018CB6DA44
		public Duration Normalize(); // 0x000000018CB6D88C-0x000000018CB6D90C
	}

	[IsReadOnly]
	[ProtoContract(Name = ".google.protobuf.Empty", Serializer = typeof(PrimaryTypeProvider), Origin = "google/protobuf/empty.proto")]
	public struct Empty // TypeDefIndex: 80603
	{
	}

	[IsReadOnly]
	[ProtoContract(Name = ".google.protobuf.Timestamp", Serializer = typeof(PrimaryTypeProvider), Origin = "google/protobuf/timestamp.proto")]
	public struct Timestamp : IComparable<Timestamp>, IEquatable<Timestamp> // TypeDefIndex: 80604
	{
		// Fields
		[CompilerGenerated]
		private readonly long _Seconds_k__BackingField; // 0x00
		[CompilerGenerated]
		private readonly int _Nanoseconds_k__BackingField; // 0x08
		private static readonly System.DateTime TimestampEpoch; // 0x00
	
		// Properties
		[ProtoMember(1, Name = "seconds", DataFormat = ProtoBuf.DataFormat.Default)]
		public long Seconds { [CompilerGenerated] get; } // 0x0000000184431970-0x0000000184431980 
		[ProtoMember(2, Name = "nanos", DataFormat = ProtoBuf.DataFormat.Default)]
		public int Nanoseconds { [CompilerGenerated] get; } // 0x0000000184431A70-0x0000000184431A80 
	
		// Constructors
		public Timestamp(long seconds, int nanoseconds); // 0x0000000184547F50-0x0000000184547F60
		public Timestamp(System.DateTime value); // 0x000000018CB77D88-0x000000018CB77E64
		static Timestamp(); // 0x000000018CB77CF8-0x000000018CB77D88
	
		// Methods
		public Timestamp Normalize(); // 0x000000018CB77C60-0x000000018CB77CF8
		public System.DateTime AsDateTime(); // 0x000000018CB77ACC-0x000000018CB77B6C
		public int CompareTo(Timestamp other); // 0x000000018CB77B6C-0x000000018CB77BFC
		public bool Equals(Timestamp other); // 0x000000018CB77BFC-0x000000018CB77C60
		public static implicit operator System.DateTime(Timestamp value); // 0x000000018CB77E84-0x000000018CB77ED0
		public static implicit operator Timestamp(System.DateTime value); // 0x000000018CB77E64-0x000000018CB77E84
	}
}

namespace System.Diagnostics.CodeAnalysis
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, Inherited = false)]
	internal sealed class DynamicallyAccessedMembersAttribute : Attribute // TypeDefIndex: 80508
	{
		// Fields
		[CompilerGenerated]
		private readonly DynamicallyAccessedMemberTypes _MemberTypes_k__BackingField; // 0x10
	
		// Properties
		public DynamicallyAccessedMemberTypes MemberTypes { [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
	
		// Constructors
		public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes); // 0x0000000182234E90-0x0000000182234EA0
	}

	[Flags]
	internal enum DynamicallyAccessedMemberTypes // TypeDefIndex: 80509
	{
		All = -1,
		None = 0,
		PublicParameterlessConstructor = 1,
		PublicConstructors = 3,
		NonPublicConstructors = 4,
		PublicMethods = 8,
		NonPublicMethods = 16,
		PublicFields = 32,
		NonPublicFields = 64,
		PublicNestedTypes = 128,
		NonPublicNestedTypes = 256,
		PublicProperties = 512,
		NonPublicProperties = 1024,
		PublicEvents = 2048,
		NonPublicEvents = 4096
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 80470
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
