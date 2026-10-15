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

// Image 96: DynamicSceneUnsafe.Gameplay.Beyond.dll - Assembly: DynamicSceneUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90448-90496

internal static class _BurstDirectCallInitializer // TypeDefIndex: 90479
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize(); // 0x00000001872219B0-0x00000001872219F0
}

namespace Beyond.Gameplay.Core.DynamicScene
{
	public class CompEntityBridge : IDisposable // TypeDefIndex: 90459
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
		public CompEntityBridge(EDynamicSystem systemType, int selfStride, GridSlotManager gridSlotManager, NativeSegmentPool<RootCompData> rootPool, IndexedArray<int> rootGridStarts); // 0x0000000185929B30-0x0000000185929EB0
	
		// Methods
		public ulong GetEntityId(ulong compId); // 0x0000000188CAA79C-0x0000000188CAA7B8
		public ulong GetCompId(ulong entityId); // 0x0000000188CAA780-0x0000000188CAA79C
		public bool HasRegisterComp(ulong compId); // 0x0000000188CAA878-0x0000000188CAA8C4
		public bool HasRegisterEntity(ulong entityId); // 0x0000000188CAA8C4-0x0000000188CAA910
		public void RegisterEntityToComp(ulong entityId, ulong compId); // 0x0000000185404410-0x0000000185404EE0
		public void UnRegisterCompToEntity(ulong entityId, ulong compId); // 0x0000000185402EC0-0x0000000185403020
		public void EnsureSelfPoolSegment(ushort hotSlot, int minCapacity = 0 /* Metadata: 0x0264AE71 */); // 0x0000000188CAA778-0x0000000188CAA780
		public ref ref T GetSelfSlot<T>(ulong compId)
			where T : struct;
		public ref ref T GetSelfSlotDirect<T>(ushort hotSlot, uint gridIndex)
			where T : struct;
		public int GetSelfPoolCapacity(ushort hotSlot); // 0x0000000188CAA7B8-0x0000000188CAA878
		public void FreeSelfPoolSegment(ushort hotSlot); // 0x000000018592BCB0-0x000000018592BE30
		private void _AllocSelfPoolSegment(ushort hotSlot, int minCapacity = 0 /* Metadata: 0x0264AE72 */); // 0x000000018592BE30-0x000000018592C0A0
		private void _OnSelfSegmentRelocated(uint gridId, int newStart); // 0x000000018592C820-0x000000018592C8D0
		public void Dispose(); // 0x0000000188CAA644-0x0000000188CAA778
	}

	public class CompEntityLookup // TypeDefIndex: 90460
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
		public CompEntityLookup(EDynamicSystem systemType, int stride, NativeSegmentPool selfPool, IndexedArray<int> selfGridStarts, int rootStride, NativeSegmentPool rootPool, IndexedArray<int> rootGridStarts); // 0x0000000185929EB0-0x0000000185929F50
	
		// Methods
		private static void _VerifyFArray8Layout(); // 0x0000000185929F50-0x0000000185929FE0
		public ulong GetCompId(ulong entityId); // 0x0000000188CAA910-0x0000000188CAA9B4
		public ulong GetEntityId(ulong compId); // 0x0000000188CAA9B4-0x0000000188CAAA7C
		public bool HasRegisterEntity(ulong entityId); // 0x0000000188CAAB50-0x0000000188CAAC50
		public bool HasRegisterComp(ulong compId); // 0x0000000188CAAA7C-0x0000000188CAAB50
	}

	[IsReadOnly]
	public struct DynamicSceneVisCtx // TypeDefIndex: 90461
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
		public DynamicSceneVisCtx(float ccx, float ccz, float g, float gf, float oneMinusF, float d, float h, float marginMin, float marginMax); // 0x0000000187239860-0x00000001872398C0
	}

	[BurstCompile]
	public static class DynamicSceneVisibilityKernel // TypeDefIndex: 90465
	{
		// Fields
		private static FunctionPointer<EvalBatchDelegate> s_evalBatch; // 0x00
		private static EvalBatchDelegate s_evalBatchInvoke; // 0x08
		private static bool s_evalBatchCompiled; // 0x10
	
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void EvalBatchDelegate(float* cx, float* cz, float* br, int count, DynamicSceneVisCtx* ctxs, int centerCount, byte* outResult); // TypeDefIndex: 90462; 0x00000001811C5A40-0x00000001811C5A60
	
		public unsafe delegate void EvalBatch_00000022_PostfixBurstDelegate(float* cx, float* cz, float* br, int count, DynamicSceneVisCtx* ctxs, int centerCount, byte* outResult); // TypeDefIndex: 90463; 0x00000001811C5A40-0x00000001811C5A60
	
		internal static class EvalBatch_00000022_BurstDirectCall // TypeDefIndex: 90464
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static EvalBatch_00000022_BurstDirectCall(); // 0x00000001827528A0-0x00000001827528B0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000bf870); // 0x0000000182751320-0x0000000182751F80
			private static IntPtr GetFunctionPointer(); // 0x0000000182751F80-0x0000000182752280
			public static void Constructor(); // 0x0000000182750AA0-0x0000000182751320
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(float* cx, float* cz, float* br, int count, DynamicSceneVisCtx* ctxs, int centerCount, byte* outResult); // 0x0000000182752280-0x00000001827528A0
		}
	
		// Methods
		public static bool EvalCore(float cx, float cz, float br, [IsReadOnly] in DynamicSceneVisCtx ctx, bool useExpanded); // 0x0000000188CAACCC-0x0000000188CAAD58
		[BurstCompile(FloatPrecision.Standard, FloatMode.Default)]
		[AOT.MonoPInvokeCallback(typeof(EvalBatchDelegate))]
		public static unsafe void EvalBatch(float* cx, float* cz, float* br, int count, DynamicSceneVisCtx* ctxs, int centerCount, byte* outResult); // 0x0000000188CAAC50-0x0000000188CAACCC
		public static void RunBatch(NativeArray<float> cx, NativeArray<float> cz, NativeArray<float> br, int count, NativeArray<DynamicSceneVisCtx> ctxs, int centerCount, NativeArray<byte> result); // 0x000000018592F960-0x000000018592FBD0
		[BurstCompile(FloatPrecision.Standard, FloatMode.Default)]
		[AOT.MonoPInvokeCallback(typeof(EvalBatchDelegate))]
		public static unsafe void EvalBatch_BurstManaged(float* cx, float* cz, float* br, int count, DynamicSceneVisCtx* ctxs, int centerCount, byte* outResult); // 0x0000000188CAA514-0x0000000188CAA644
	}

	public enum EDynamicSystem : byte // TypeDefIndex: 90466
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
		SnowFallTree = 45,
		PureSystem = 46,
		Max = 47
	}

	public static class FArray8UlongOps // TypeDefIndex: 90467
	{
		// Methods
		public static unsafe void Add(byte* entityDataPtr, ulong compId); // 0x0000000188CAAE2C-0x0000000188CAAEC8
		public static unsafe void Remove(byte* entityDataPtr, ulong compId); // 0x0000000188CAAEF4-0x0000000188CAAF2C
		public static unsafe ulong FindBySysType(byte* entityDataPtr, byte sysType); // 0x0000000188CAAEC8-0x0000000188CAAEF4
	}

	public static class GridSlotIdHelper // TypeDefIndex: 90468
	{
		// Fields
		private const int FREE_BIT_SHIFT_NUM = 20; // Metadata: 0x0264AEA0
		private const uint FREE_BIT_MASK = 4293918720; // Metadata: 0x0264AEA1
	
		// Methods
		public static uint GetUniqueIdFromGridId(uint gridId); // 0x00000001872341C0-0x00000001872341D0
		public static ulong Encode(byte uniqueId, byte sysType, ushort hotSlot, uint gridIndex); // 0x00000001872398E0-0x0000000187239910
		public static uint GetGridIndex(ulong compId); // 0x0000000187235A70-0x0000000187235A80
		public static ushort GetHotSlot(ulong compId); // 0x0000000187239910-0x0000000187239920
		public static byte GetSysType(ulong compId); // 0x0000000187239920-0x0000000187239930
		public static byte GetUniqueId(ulong compId); // 0x0000000187239930-0x0000000187239940
		public static void Decode(ulong compId, out ushort hotSlot, out int gridIndex); // 0x00000001872398C0-0x00000001872398D0
		public static void DecodeColdSlotEncodeId(ulong coldSlotEncode, out ushort coldSlot, out int gridIndex); // 0x00000001872398C0-0x00000001872398D0
		public static ulong EncodeSlotIndex(ushort hotSlot, int index); // 0x00000001872398D0-0x00000001872398E0
		public static ulong MakeEntityId(byte uniqueId, ushort hotSlot, uint rootGridIndex); // 0x0000000187239940-0x0000000187239970
	}

	public struct ColdGridData // TypeDefIndex: 90469
	{
		// Fields
		public uint gridId; // 0x00
		public ushort hotSlot; // 0x04
		public byte uniqueId; // 0x06
		public int refCount; // 0x08
	}

	public struct HotGridData // TypeDefIndex: 90470
	{
		// Fields
		public uint gridId; // 0x00
		public ushort coldSlot; // 0x04
		public byte uniqueId; // 0x06
		public int capacity; // 0x08
	}

	internal sealed class SlotPool<T> // TypeDefIndex: 90471
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

	public class GridSlotManager : IDisposable // TypeDefIndex: 90472
	{
		// Fields
		private readonly SlotPool<ColdGridData> m_coldSlots; // 0x10
		private readonly SlotPool<HotGridData> m_hotSlots; // 0x18
		private readonly Dictionary<uint, uint> m_gridToSlots; // 0x20
		private const int HOT_SHIFT = 16; // Metadata: 0x0264AEAA
		private const uint COLD_MASK = 65535; // Metadata: 0x0264AEAB
	
		// Constructors
		public GridSlotManager(int coldCapacity = 256 /* Metadata: 0x0264AEA6 */, int hotCapacity = 128 /* Metadata: 0x0264AEA8 */); // 0x000000018653CD00-0x000000018653CE30
	
		// Methods
		public ushort AllocCold(uint gridId); // 0x00000001862F86E0-0x00000001862F87E0
		public void FreeCold(ushort coldSlot); // 0x00000001863E02C0-0x00000001863E0490
		public ushort AddColdRef(uint gridId); // 0x00000001853FE280-0x00000001853FE490
		public void RemoveColdRef(uint gridId); // 0x0000000185409D50-0x0000000185409E60
		public bool IsColdRefFree(ushort coldSlot); // 0x0000000188CAB594-0x0000000188CAB5F0
		public ushort TryGetOrAllocColdSlot(uint gridId); // 0x0000000188CAB698-0x0000000188CAB6CC
		public ushort AllocHot(uint gridId, int capacity); // 0x0000000185216CF0-0x0000000185216EB0
		public void FreeHot(ushort hotSlot); // 0x0000000185217370-0x0000000185217490
		public ref HotGridData GetHotData(ushort hotSlot); // 0x0000000188CAB3F8-0x0000000188CAB44C
		public ref ColdGridData GetColdData(ushort coldSlot); // 0x0000000188CAB0C8-0x0000000188CAB11C
		public ushort GetColdSlot(uint gridId); // 0x0000000188CAB1EC-0x0000000188CAB260
		public ushort GetHotSlot(uint gridId); // 0x0000000188CAB51C-0x0000000188CAB594
		public void GetBothSlotForGrid(uint gridId, out ushort coldSlot, out ushort hotSlot); // 0x0000000188CAB038-0x0000000188CAB0C8
		public uint GetGridIdByCold(ushort coldSlot); // 0x0000000188CAB260-0x0000000188CAB32C
		public ushort GetHotSlotByCold(ushort coldSlot); // 0x0000000188CAB44C-0x0000000188CAB51C
		public ushort GetColdSlotByHot(ushort hotSlot); // 0x0000000188CAB11C-0x0000000188CAB1EC
		public uint GetGridIdByHot(ushort hotSlot); // 0x0000000188CAB32C-0x0000000188CAB3F8
		public bool IsColdValid(ushort coldSlot); // 0x0000000188CAB5F0-0x0000000188CAB644
		public bool IsHotValid(ushort hotSlot); // 0x0000000188CAB644-0x0000000188CAB698
		public void Dispose(); // 0x0000000188CAAF74-0x0000000188CAB038
	}

	public class IndexedArray<T> : IDisposable // TypeDefIndex: 90473
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

	public struct RootCompData // TypeDefIndex: 90474
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
		public bool isSceneVisible { get; } // 0x000000018643D870-0x000000018643D8B0 
	}

	public static class RootCompDataUtil // TypeDefIndex: 90475
	{
		// Fields
		public static readonly int STRIDE; // 0x00
	
		// Constructors
		static RootCompDataUtil(); // 0x0000000187172000-0x0000000187172060
	
		// Methods
		public static bool IsSlotOccupied(ref RootCompData data); // 0x0000000185013440-0x0000000185013470
		public static void ClearSlot(ref RootCompData data); // 0x0000000185013470-0x00000001850134B0
	}

	public static class RootPoolUnsafeHelpers // TypeDefIndex: 90476
	{
		// Methods
		public static void ClearSegment(NativeSegmentPool<RootCompData> pool, SegmentHandle handle, int capacity); // 0x000000018592A370-0x000000018592A440
	}

	public struct GridSegmentSlot // TypeDefIndex: 90477
	{
		// Fields
		public int start; // 0x00
		public SegmentHandle handle; // 0x04
	
		// Properties
		public bool IsAllocated { get; } // 0x0000000188CAAF2C-0x0000000188CAAF74 
	}

	public class SystemSegmentPool<T> : IDisposable // TypeDefIndex: 90478
		where T : struct
	{
		// Fields
		private static readonly int STRIDE;
		private NativeSegmentPool m_pool;
		private IndexedArray<GridSegmentSlot> m_gridSlots;
		private GridSlotManager m_gridSlotManager;
	
		// Constructors
		public SystemSegmentPool(GridSlotManager gridSlotManager, int initialElementCapacity = 128 /* Metadata: 0x0264AEAF */);
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
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 90452
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 90453
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 90454
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 90455
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 90456
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 90457
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 90458
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 90451
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 90480
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x0000000188CAC148-0x0000000188CAC1AC
	
		// Methods
		public void __Gen_Wrap_0(object P0, ulong P1, ulong P2); // 0x0000000188CAB6CC-0x0000000188CAB7B8
		public void __Gen_Wrap_1(object P0, ushort P1); // 0x0000000188CABBD0-0x0000000188CABCA0
		public void __Gen_Wrap_2(object P0, ushort P1, int P2); // 0x0000000188CABCA0-0x0000000188CABD88
		public void __Gen_Wrap_3(object P0, uint P1, int P2); // 0x0000000188CABD88-0x0000000188CABE70
		public void __Gen_Wrap_4(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public void __Gen_Wrap_5(); // 0x00000001887ED074-0x00000001887ED104
		public void __Gen_Wrap_6(NativeArray<float> P0, NativeArray<float> P1, NativeArray<float> P2, int P3, NativeArray<DynamicSceneVisCtx> P4, int P5, NativeArray<byte> P6); // 0x0000000188CABE70-0x0000000188CAC050
		public ushort __Gen_Wrap_7(object P0, uint P1); // 0x0000000188B4AE78-0x0000000188B4AF54
		public void __Gen_Wrap_8(object P0, uint P1); // 0x0000000188B4D6D0-0x0000000188B4D7A0
		public ushort __Gen_Wrap_9(object P0, uint P1, int P2); // 0x0000000188CAC050-0x0000000188CAC148
		public bool __Gen_Wrap_10(ref RootCompData P0); // 0x0000000188CAB7B8-0x0000000188CAB93C
		public void __Gen_Wrap_11(ref RootCompData P0); // 0x0000000188CAB93C-0x0000000188CABAB0
		public void __Gen_Wrap_12(object P0, SegmentHandle P1, int P2); // 0x0000000188CABAB0-0x0000000188CABBD0
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 90481
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000188CAC1AC-0x0000000188CAC244
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 90482
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000188CAC430-0x0000000188CAC494
		public static bool IsPatched(int id); // 0x0000000188CAC520-0x0000000188CAC5B8
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000188CAC2E8-0x0000000188CAC3B4
		public object CreateWrapper(int id); // 0x0000000188CAC3B4-0x0000000188CAC430
		public object InitWrapperArray(int len); // 0x0000000188CAC494-0x0000000188CAC520
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000188CAC244-0x0000000188CAC2E8
	}

	public delegate void __HotPatchDelegate_0(object P0, ulong P1, ulong P2); // TypeDefIndex: 90483; 0x00000001811DF7F0-0x00000001811DF810

	public enum HotPatchIDMAP0 // TypeDefIndex: 90484
	{
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-RegisterEntityToComp0 = 0,
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-UnRegisterCompToEntity0 = 0,
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-FreeSelfPoolSegment0 = 1,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-FreeCold0 = 1,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-FreeHot0 = 1,
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-_AllocSelfPoolSegment0 = 2,
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-_OnSelfSegmentRelocated0 = 3,
		Beyond-Gameplay-Core-DynamicScene-CompEntityBridge-Dispose0 = 4,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-Dispose0 = 4,
		Beyond-Gameplay-Core-DynamicScene-CompEntityLookup-_VerifyFArray8Layout0 = 5,
		Beyond-Gameplay-Core-DynamicScene-DynamicSceneVisibilityKernel-RunBatch0 = 6,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-AllocCold0 = 7,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-AddColdRef0 = 7,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-RemoveColdRef0 = 8,
		Beyond-Gameplay-Core-DynamicScene-GridSlotManager-AllocHot0 = 9,
		Beyond-Gameplay-Core-DynamicScene-RootCompData-get_isSceneVisible0 = 10,
		Beyond-Gameplay-Core-DynamicScene-RootCompDataUtil-IsSlotOccupied0 = 10,
		Beyond-Gameplay-Core-DynamicScene-RootCompDataUtil-ClearSlot0 = 11,
		Beyond-Gameplay-Core-DynamicScene-RootPoolUnsafeHelpers-ClearSegment0 = 12
	}

	public delegate void __HotPatchDelegate_1(object P0, ushort P1); // TypeDefIndex: 90485; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_2(object P0, ushort P1, int P2); // TypeDefIndex: 90486; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_3(object P0, uint P1, int P2); // TypeDefIndex: 90487; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_4(object P0); // TypeDefIndex: 90488; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_5(); // TypeDefIndex: 90489; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_6(NativeArray<float> P0, NativeArray<float> P1, NativeArray<float> P2, int P3, NativeArray<DynamicSceneVisCtx> P4, int P5, NativeArray<byte> P6); // TypeDefIndex: 90490; 0x00000001878B2120-0x00000001878B21B8

	public delegate ushort __HotPatchDelegate_7(object P0, uint P1); // TypeDefIndex: 90491; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_8(object P0, uint P1); // TypeDefIndex: 90492; 0x00000001859B7730-0x00000001859B7740

	public delegate ushort __HotPatchDelegate_9(object P0, uint P1, int P2); // TypeDefIndex: 90493; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_10(ref RootCompData P0); // TypeDefIndex: 90494; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_11(ref RootCompData P0); // TypeDefIndex: 90495; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_12(object P0, SegmentHandle P1, int P2); // TypeDefIndex: 90496; 0x00000001811DF7F0-0x00000001811DF810
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 90449
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 90450
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
