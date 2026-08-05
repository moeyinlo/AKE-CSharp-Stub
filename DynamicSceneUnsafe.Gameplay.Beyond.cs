/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Beyond;
using Beyond.Gameplay.Core;
using Beyond.Gameplay.Core.DynamicScene;
using IFix.Core;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;

// Image 97: DynamicSceneUnsafe.Gameplay.Beyond.dll - Assembly: DynamicSceneUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63099-63132
[assembly: BurstCompiler.StaticTypeReinit(typeof(DynamicSceneVisibilityKernel.EvalBatch_00000020_BurstDirectCall))]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

internal static class _BurstDirectCallInitializer // TypeDefIndex: 63128
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize(); // 0x0000000184D7B4F0-0x0000000184D7B530
}

namespace Beyond.Gameplay.Core.DynamicScene
{
	public class CompEntityBridge : IDisposable // TypeDefIndex: 63108
	{
		// Fields
		private readonly EDynamicSystem m_systemType; // 0x10
		private readonly bool m_isRoot; // 0x11
		private readonly int m_selfStride; // 0x14
		private NativeSegmentPool m_selfPool; // 0x18
		private IndexedArray<int> m_selfGridStarts; // 0x20
		private IndexedArray<SegmentHandle> m_selfGridHandles; // 0x28
		private CompEntityLookup m_lookup; // 0x30
		private bool m_disposed; // 0x38
		private readonly GridSlotManager m_gridSlotManager; // 0x40
		private readonly NativeSegmentPool m_rootPoolInner; // 0x48
		private readonly IndexedArray<int> m_rootGridStarts; // 0x50
		private readonly int m_rootStride; // 0x58
	
		// Constructors
		public CompEntityBridge(EDynamicSystem systemType, int selfStride, GridSlotManager gridSlotManager, NativeSegmentPool<RootCompData> rootPool, IndexedArray<int> rootGridStarts); // 0x00000001834AFE40-0x00000001834B01C0
	
		// Methods
		public ulong GetEntityId(ulong compId); // 0x000000018698B010-0x000000018698B02C
		public ulong GetCompId(ulong entityId); // 0x000000018698AFF4-0x000000018698B010
		public bool HasRegisterComp(ulong compId); // 0x000000018698B0EC-0x000000018698B138
		public bool HasRegisterEntity(ulong entityId); // 0x000000018698B138-0x000000018698B184
		public void RegisterEntityToComp(ulong entityId, ulong compId); // 0x00000001833637D0-0x00000001833641B0
		public void UnRegisterCompToEntity(ulong entityId, ulong compId); // 0x0000000183364220-0x00000001833643D0
		public void EnsureSelfPoolSegment(ushort hotSlot, int minCapacity = 0 /* Metadata: 0x02352630 */); // 0x000000018698AFEC-0x000000018698AFF4
		public ref ref T GetSelfSlot<T>(ulong compId)
			where T : struct;
		public ref ref T GetSelfSlotDirect<T>(ushort hotSlot, uint gridIndex)
			where T : struct;
		public int GetSelfPoolCapacity(ushort hotSlot); // 0x000000018698B02C-0x000000018698B0EC
		public void FreeSelfPoolSegment(ushort hotSlot); // 0x00000001834B15F0-0x00000001834B1770
		private void _AllocSelfPoolSegment(ushort hotSlot, int minCapacity = 0 /* Metadata: 0x02352631 */); // 0x00000001834B1860-0x00000001834B1AD0
		private void _OnSelfSegmentRelocated(uint gridId, int newStart); // 0x00000001834B2240-0x00000001834B22E0
		public void Dispose(); // 0x000000018698AECC-0x000000018698AFEC
	}

	public class CompEntityLookup // TypeDefIndex: 63109
	{
		// Fields
		private static bool s_layoutVerified; // 0x00
		private readonly EDynamicSystem m_systemType; // 0x10
		private readonly bool m_isRoot; // 0x11
		private readonly int m_stride; // 0x14
		private readonly int m_rootStride; // 0x18
		private readonly NativeSegmentPool m_selfPool; // 0x20
		private readonly IndexedArray<int> m_selfGridStarts; // 0x28
		private readonly NativeSegmentPool m_rootPool; // 0x30
		private readonly IndexedArray<int> m_rootGridStarts; // 0x38
	
		// Constructors
		public CompEntityLookup(EDynamicSystem systemType, int stride, NativeSegmentPool selfPool, IndexedArray<int> selfGridStarts, int rootStride, NativeSegmentPool rootPool, IndexedArray<int> rootGridStarts); // 0x00000001834B01C0-0x00000001834B0260
	
		// Methods
		private static void _VerifyFArray8Layout(); // 0x00000001834B0260-0x00000001834B02F0
		public ulong GetCompId(ulong entityId); // 0x000000018698B184-0x000000018698B228
		public ulong GetEntityId(ulong compId); // 0x000000018698B228-0x000000018698B2F0
		public bool HasRegisterEntity(ulong entityId); // 0x000000018698B3E0-0x000000018698B4E4
		public bool HasRegisterComp(ulong compId); // 0x000000018698B2F0-0x000000018698B3E0
	}

	[IsReadOnly]
	public struct DynamicSceneVisCtx // TypeDefIndex: 63110
	{
		// Fields
		public readonly float ccx; // 0x00
		public readonly float ccz; // 0x04
		public readonly float g; // 0x08
		public readonly float gf; // 0x0C
		public readonly float oneMinusF; // 0x10
		public readonly float d; // 0x14
		public readonly float h; // 0x18
		public readonly float marginMin; // 0x1C
		public readonly float marginMax; // 0x20
	
		// Constructors
		public DynamicSceneVisCtx(float ccx, float ccz, float g, float gf, float oneMinusF, float d, float h, float marginMin, float marginMax); // 0x0000000184D8CB70-0x0000000184D8CBD0
	}

	[BurstCompile]
	public static class DynamicSceneVisibilityKernel // TypeDefIndex: 63114
	{
		// Fields
		private static FunctionPointer<EvalBatchDelegate> s_evalBatch; // 0x00
		private static EvalBatchDelegate s_evalBatchInvoke; // 0x08
		private static bool s_evalBatchCompiled; // 0x10
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void EvalBatchDelegate(float* cx, float* cz, float* br, int count, DynamicSceneVisCtx* ctxs, int centerCount, byte* outResult); // TypeDefIndex: 63111; 0x0000000182C394B0-0x0000000182C394D0
	
		public unsafe delegate void EvalBatch_00000020_PostfixBurstDelegate(float* cx, float* cz, float* br, int count, DynamicSceneVisCtx* ctxs, int centerCount, byte* outResult); // TypeDefIndex: 63112; 0x0000000182C394B0-0x0000000182C394D0
	
		internal static class EvalBatch_00000020_BurstDirectCall // TypeDefIndex: 63113
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static EvalBatch_00000020_BurstDirectCall(); // 0x0000000183FB2B60-0x0000000183FB2B70
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0008694b); // 0x000000018698B6D4-0x000000018698B7D8
			private static IntPtr GetFunctionPointer(); // 0x000000018698B7D8-0x000000018698B82C
			public static void Constructor(); // 0x0000000183FB1850-0x0000000183FB18E0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(float* cx, float* cz, float* br, int count, DynamicSceneVisCtx* ctxs, int centerCount, byte* outResult); // 0x000000018698B82C-0x000000018698B918
		}
	
		// Methods
		public static bool EvalCore(float cx, float cz, float br, [IsReadOnly] in DynamicSceneVisCtx ctx, bool useExpanded); // 0x000000018698B578-0x000000018698B604
		[BurstCompile(FloatPrecision.Standard, FloatMode.Default)]
		[AOT.MonoPInvokeCallback(typeof(EvalBatchDelegate))]
		public static unsafe void EvalBatch(float* cx, float* cz, float* br, int count, DynamicSceneVisCtx* ctxs, int centerCount, byte* outResult); // 0x000000018698B4E4-0x000000018698B578
		public static void RunBatch(NativeArray<float> cx, NativeArray<float> cz, NativeArray<float> br, int count, NativeArray<DynamicSceneVisCtx> ctxs, int centerCount, NativeArray<byte> result); // 0x0000000183E32EB0-0x0000000183E347F0
		[BurstCompile(FloatPrecision.Standard, FloatMode.Default)]
		[AOT.MonoPInvokeCallback(typeof(EvalBatchDelegate))]
		public static unsafe void EvalBatch_BurstManaged(float* cx, float* cz, float* br, int count, DynamicSceneVisCtx* ctxs, int centerCount, byte* outResult); // 0x000000018698AD9C-0x000000018698AECC
	}

	public enum EDynamicSystem : byte // TypeDefIndex: 63115
	{
		None = 0,
		Entity = 1,
		DynamicEntity = 2,
		Hittable = 3,
		Destruct = 4,
		Trigger = 5,
		SpaceShip = 6,
		Seat = 7,
		EnableLight = 8,
		NatureResource = 9,
		Tree = 11,
		Physic = 12,
		Erosion = 13,
		GlobalVarControl = 15,
		MissionControl = 16,
		DynamicEntityControl = 17,
		FactoryRegionControl = 18,
		SettlementControl = 19,
		ScriptControl = 20,
		InteractiveControl = 21,
		NavmeshModify = 23,
		BlockFactory = 24,
		ResourceGroup = 25,
		Model = 26,
		Ecs = 27,
		Effect = 28,
		ModelEcs = 29,
		ModelViewController = 30,
		Id = 31,
		ConveyorBelt = 32,
		ConveyorBeltBox = 33,
		ConveyorBeltGroup = 34,
		Sludge = 35,
		ExtraScene = 36,
		RemapScene = 37,
		WaterPipe = 38,
		StreamingArea = 39,
		NavmeshObstacle = 40,
		MapVarControl = 41,
		ActivityControl = 42,
		PoiControl = 43,
		BlightMiasma = 44,
		PureSystem = 46,
		Max = 47
	}

	public static class FArray8UlongOps // TypeDefIndex: 63116
	{
		// Methods
		public static unsafe void Add(byte* entityDataPtr, ulong compId); // 0x000000018698BABC-0x000000018698BB58
		public static unsafe void Remove(byte* entityDataPtr, ulong compId); // 0x000000018698BB84-0x000000018698BBC0
		public static unsafe ulong FindBySysType(byte* entityDataPtr, byte sysType); // 0x000000018698BB58-0x000000018698BB84
	}

	public static class GridSlotIdHelper // TypeDefIndex: 63117
	{
		// Fields
		private const int FREE_BIT_SHIFT_NUM = 20; // Metadata: 0x0235265E
		private const uint FREE_BIT_MASK = 4293918720; // Metadata: 0x0235265F
	
		// Methods
		public static uint GetUniqueIdFromGridId(uint gridId); // 0x0000000184D87570-0x0000000184D87580
		public static ulong Encode(byte uniqueId, byte sysType, ushort hotSlot, uint gridIndex); // 0x0000000184D8CBF0-0x0000000184D8CC20
		public static uint GetGridIndex(ulong compId); // 0x0000000184D88BE0-0x0000000184D88BF0
		public static ushort GetHotSlot(ulong compId); // 0x0000000184D8CC20-0x0000000184D8CC30
		public static byte GetSysType(ulong compId); // 0x0000000184D8CC30-0x0000000184D8CC40
		public static byte GetUniqueId(ulong compId); // 0x0000000184D8CC40-0x0000000184D8CC50
		public static void Decode(ulong compId, out ushort hotSlot, out int gridIndex); // 0x0000000184D8CBD0-0x0000000184D8CBE0
		public static void DecodeColdSlotEncodeId(ulong coldSlotEncode, out ushort coldSlot, out int gridIndex); // 0x0000000184D8CBD0-0x0000000184D8CBE0
		public static ulong EncodeSlotIndex(ushort hotSlot, int index); // 0x0000000184D8CBE0-0x0000000184D8CBF0
		public static ulong MakeEntityId(byte uniqueId, ushort hotSlot, uint rootGridIndex); // 0x0000000184D8CC50-0x0000000184D8CC80
	}

	public struct ColdGridData // TypeDefIndex: 63118
	{
		// Fields
		public uint gridId; // 0x00
		public ushort hotSlot; // 0x04
		public byte uniqueId; // 0x06
		public int refCount; // 0x08
	}

	public struct HotGridData // TypeDefIndex: 63119
	{
		// Fields
		public uint gridId; // 0x00
		public ushort coldSlot; // 0x04
		public byte uniqueId; // 0x06
		public int capacity; // 0x08
	}

	internal sealed class SlotPool<T> // TypeDefIndex: 63120
		where T : struct
	{
		// Fields
		private T[] m_pool;
		private ushort[] m_freeStack;
		private bool[] m_allocated;
		private int m_freeTop;
		private ushort m_nextSlot;
	
		// Properties
		public ushort NextSlot { get; }
	
		// Constructors
		public SlotPool(int capacity);
	
		// Methods
		public ushort Alloc();
		public void Free(ushort slot);
		public bool IsAllocated(ushort slot);
		public ref ref T Get(ushort slot);
		public bool IsValidIndex(ushort slot);
		public void Dispose();
	}

	public class GridSlotManager : IDisposable // TypeDefIndex: 63121
	{
		// Fields
		private readonly SlotPool<ColdGridData> m_coldSlots; // 0x10
		private readonly SlotPool<HotGridData> m_hotSlots; // 0x18
		private readonly Dictionary<uint, uint> m_gridToSlots; // 0x20
		private const int HOT_SHIFT = 16; // Metadata: 0x02352668
		private const uint COLD_MASK = 65535; // Metadata: 0x02352669
	
		// Constructors
		public GridSlotManager(int coldCapacity = 256 /* Metadata: 0x02352664 */, int hotCapacity = 128 /* Metadata: 0x02352666 */); // 0x0000000183FD58C0-0x0000000183FD59F0
	
		// Methods
		public ushort AllocCold(uint gridId); // 0x000000018328E930-0x000000018328EA30
		public void FreeCold(ushort coldSlot); // 0x0000000183587210-0x0000000183587380
		public ushort AddColdRef(uint gridId); // 0x00000001833643D0-0x00000001833644C0
		public void RemoveColdRef(uint gridId); // 0x0000000183587110-0x0000000183587210
		public bool IsColdRefFree(ushort coldSlot); // 0x000000018698C21C-0x000000018698C278
		public ushort TryGetOrAllocColdSlot(uint gridId); // 0x000000018698C320-0x000000018698C354
		public ushort AllocHot(uint gridId, int capacity); // 0x0000000183589840-0x0000000183589A00
		public void FreeHot(ushort hotSlot); // 0x0000000183586FF0-0x0000000183587110
		public ref HotGridData GetHotData(ushort hotSlot); // 0x000000018698C080-0x000000018698C0D4
		public ref ColdGridData GetColdData(ushort coldSlot); // 0x000000018698BD50-0x000000018698BDA4
		public ushort GetColdSlot(uint gridId); // 0x000000018698BE74-0x000000018698BEE8
		public ushort GetHotSlot(uint gridId); // 0x000000018698C1A4-0x000000018698C21C
		public void GetBothSlotForGrid(uint gridId, out ushort coldSlot, out ushort hotSlot); // 0x000000018698BCC0-0x000000018698BD50
		public uint GetGridIdByCold(ushort coldSlot); // 0x000000018698BEE8-0x000000018698BFB4
		public ushort GetHotSlotByCold(ushort coldSlot); // 0x000000018698C0D4-0x000000018698C1A4
		public ushort GetColdSlotByHot(ushort hotSlot); // 0x000000018698BDA4-0x000000018698BE74
		public uint GetGridIdByHot(ushort hotSlot); // 0x000000018698BFB4-0x000000018698C080
		public bool IsColdValid(ushort coldSlot); // 0x000000018698C278-0x000000018698C2CC
		public bool IsHotValid(ushort hotSlot); // 0x000000018698C2CC-0x000000018698C320
		public void Dispose(); // 0x000000018698BC08-0x000000018698BCC0
	}

	public class IndexedArray<T> : IDisposable // TypeDefIndex: 63122
		where T : struct
	{
		// Fields
		internal T[] data;
		private readonly T m_fill;
	
		// Properties
		public T this[int index] { get => default; set {} }
		public int Length { get; }
	
		// Constructors
		public IndexedArray(int initialCapacity, T fillValue = default);
	
		// Methods
		public ref ref T GetRef(int index);
		public void Dispose();
		public void EnsureCapacity(int minCapacity);
	}

	public struct RootCompData // TypeDefIndex: 63123
	{
		// Fields
		public FArray8<ulong> compIds; // 0x00
		public uint currentLogicState; // 0x48
		public EDynamicSystem rootSystem; // 0x4C
		public EDynamicSystem controlSys; // 0x4D
		public byte currentLoaded; // 0x4E
		public byte needLazyDestroy; // 0x4F
		public int level; // 0x50
		public byte occupied; // 0x54
		public byte stateEnable; // 0x55
		public byte areaEnable; // 0x56
		public byte _pad0; // 0x57
		public byte _pad1; // 0x58
		public byte _pad2; // 0x59
		public byte _pad3; // 0x5A
		public byte _pad4; // 0x5B
	
		// Properties
		public bool isSceneVisible { get; } // 0x00000001814F5220-0x00000001814F5A60 
	}

	public static class RootCompDataUtil // TypeDefIndex: 63124
	{
		// Fields
		public static readonly int STRIDE; // 0x00
	
		// Constructors
		static RootCompDataUtil(); // 0x0000000184D14A40-0x0000000184D14AA0
	
		// Methods
		public static bool IsSlotOccupied(ref RootCompData data); // 0x00000001843222F0-0x0000000184322320
		public static void ClearSlot(ref RootCompData data); // 0x00000001841CD8C0-0x00000001841CD900
	}

	public static class RootPoolUnsafeHelpers // TypeDefIndex: 63125
	{
		// Methods
		public static void ClearSegment(NativeSegmentPool<RootCompData> pool, SegmentHandle handle, int capacity); // 0x00000001834B0780-0x00000001834B08F0
	}

	public struct GridSegmentSlot // TypeDefIndex: 63126
	{
		// Fields
		public int start; // 0x00
		public SegmentHandle handle; // 0x04
	
		// Properties
		public bool IsAllocated { get; } // 0x000000018698BBC0-0x000000018698BC08 
	}

	public class SystemSegmentPool<T> : IDisposable // TypeDefIndex: 63127
		where T : struct
	{
		// Fields
		private static readonly int STRIDE;
		private NativeSegmentPool m_pool;
		private IndexedArray<GridSegmentSlot> m_gridSlots;
		private GridSlotManager m_gridSlotManager;
	
		// Constructors
		public SystemSegmentPool(GridSlotManager gridSlotManager, int initialElementCapacity = 128 /* Metadata: 0x0235266D */);
		static SystemSegmentPool();
	
		// Methods
		public void EnsureAllocated(uint gridId, ushort hotSlot, int elementCount);
		public void Free(ushort hotSlot);
		public ref ref T GetSlot(ushort hotSlot, int elementIndex);
		public void SetSlot(ushort hotSlot, int elementIndex, T data);
		public bool IsAllocated(ushort hotSlot);
		private void _OnSegmentRelocated(uint gridId, int newStart);
		public void Dispose();
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 63103
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 63104
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 63105
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 63106
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 63107
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
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 63102
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63129
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37B80-0x0000000184D37BF0
	
		// Methods
		public void __Gen_Wrap_0(object P0, ulong P1, ulong P2); // 0x000000018698C354-0x000000018698C44C
		public void __Gen_Wrap_1(object P0, ushort P1); // 0x000000018698C880-0x000000018698C95C
		public void __Gen_Wrap_2(object P0, ushort P1, int P2); // 0x000000018698C95C-0x000000018698CA54
		public void __Gen_Wrap_3(object P0, uint P1, int P2); // 0x00000001866C2400-0x00000001866C24F8
		public void __Gen_Wrap_4(object P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_5(); // 0x00000001863625A4-0x0000000186362640
		public void __Gen_Wrap_6(NativeArray<float> P0, NativeArray<float> P1, NativeArray<float> P2, int P3, NativeArray<DynamicSceneVisCtx> P4, int P5, NativeArray<byte> P6); // 0x000000018698CA54-0x000000018698CC40
		public ushort __Gen_Wrap_7(object P0, uint P1); // 0x00000001866C13F0-0x00000001866C14DC
		public void __Gen_Wrap_8(object P0, uint P1); // 0x00000001866F3838-0x00000001866F3914
		public ushort __Gen_Wrap_9(object P0, uint P1, int P2); // 0x000000018698CC40-0x000000018698CD44
		public bool __Gen_Wrap_10(ref RootCompData P0); // 0x000000018698C44C-0x000000018698C5E0
		public void __Gen_Wrap_11(ref RootCompData P0); // 0x000000018698C5E0-0x000000018698C764
		public void __Gen_Wrap_12(object P0, SegmentHandle P1, int P2); // 0x000000018698C764-0x000000018698C880
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63130
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018698CD44-0x000000018698CDD8
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63131
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018698CFC0-0x000000018698D024
		public static bool IsPatched(int id); // 0x00000001833641B0-0x0000000183364220
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018698CE7C-0x000000018698CF48
		public object CreateWrapper(int id); // 0x000000018698CF48-0x000000018698CFC0
		public object InitWrapperArray(int len); // 0x000000018698D024-0x000000018698D0B0
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018698CDD8-0x000000018698CE7C
	}

	public enum IDMAP0 // TypeDefIndex: 63132
	{
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-RegisterEntityToComp0 = 0,
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-UnRegisterCompToEntity0 = 1,
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-FreeSelfPoolSegment0 = 2,
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-_AllocSelfPoolSegment0 = 3,
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-_OnSelfSegmentRelocated0 = 4,
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-Dispose0 = 5,
		Beyond-Gameplay-Core-DynamicScene-CompEntityLookup-_VerifyFArray8Layout0 = 6,
		Beyond-Gameplay-Core-DynamicScene-DynamicSceneVisibilityKernel-RunBatch0 = 7,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-AllocCold0 = 8,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-FreeCold0 = 9,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-AddColdRef0 = 10,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-RemoveColdRef0 = 11,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-AllocHot0 = 12,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-FreeHot0 = 13,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-Dispose0 = 14,
		Beyond-Gameplay-Core-DynamicScene-RootCompData-get_isSceneVisible0 = 15,
		Beyond-Gameplay-Core-DynamicScene-RootCompDataUtil-IsSlotOccupied0 = 16,
		Beyond-Gameplay-Core-DynamicScene-RootCompDataUtil-ClearSlot0 = 17,
		Beyond-Gameplay-Core-DynamicScene-RootPoolUnsafeHelpers-ClearSegment0 = 18
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 63100
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 63101
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
