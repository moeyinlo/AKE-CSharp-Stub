/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Beyond;
using Beyond.Cfg;
using Beyond.GEnums;
using Beyond.Gameplay;
using Beyond.Gameplay.Factory;
using Beyond.Gameplay.Factory.ECSVATFSM;
using Beyond.Gameplay.Factory.Unsafe;
using Beyond.PoolCore;
using Beyond.SparkBuffer.Runtime.Wrapper;
using FactoryUIAtlas;
using IFix.Core;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryph.ECS;

// Image 16: FactoryUnsafe.Gameplay.Beyond.dll - Assembly: FactoryUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 49461-50095

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 50089
{
	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor

	// Methods
	internal static uint ComputeStringHash(string s) => default; // 0x0000000184AA6560-0x0000000184AA65C0
}

internal class __JobReflectionRegistrationOutput__2882750677 // TypeDefIndex: 50090
{
	// Constructors
	public __JobReflectionRegistrationOutput__2882750677() {} // Dummy constructor

	// Methods
	public static void CreateJobReflectionData() {} // 0x0000000181A5A7A0-0x0000000181A5FEB0
	public static void EarlyInit() {} // 0x0000000181A5FEB0-0x0000000181A5FEC0
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 50091
{
	// Methods
	private static void Initialize() {} // 0x000000018595F000-0x000000018595F720
}

namespace Beyond
{
	public struct FixedStack<T> : IDisposable // TypeDefIndex: 49497
		where T : struct
	{
		// Fields
		private unsafe T* m_items;
		private readonly int m_capacity;
		private int m_size;
		private bool m_disposed;
	
		// Properties
		public int count { get => default; }
		public int capacity { get => default; }
		public bool isEmpty { get => default; }
		public bool isFull { get => default; }
	
		// Constructors
		public unsafe FixedStack(int capacity) : this() {
			m_items = default;
			m_capacity = default;
			m_size = default;
			m_disposed = default;
		}
	
		// Methods
		public void Push(T item) {}
		public T Pop() => default;
		public T Peek() => default;
		public void Clear() {}
		public void Dispose() {}
	}

	public struct HGArray<T> // TypeDefIndex: 49498
		where T : struct
	{
		// Fields
		private unsafe T* m_ptr;
		private readonly Unity.Collections.Allocator m_allocator;
		private uint m_size;
		private uint m_capacity;
	
		// Properties
		public ref T this[int index] { get => default; }
		public ref T this[uint index] { get => default; }
	
		// Constructors
		public unsafe HGArray(Unity.Collections.Allocator label) : this() {
			m_ptr = default;
			m_allocator = default;
			m_size = default;
			m_capacity = default;
		}
	
		// Methods
		public uint Size() => default;
		public uint Capacity() => default;
		public unsafe T* Ptr() => default;
		private void _Grow(uint targetSize) {}
		public void Dispose() {}
		public void Resize(uint newSize) {}
		public void PushBack(ref ref T v0) {}
		public void PushBack(T v0) {}
		public ref ref T EmplaceBack() => ref _refReturnTypeForEmplaceBack;
		private ref T _refReturnTypeForEmplaceBack; // Dummy field
		public void Clear() {}
		public void PopBack() {}
		public ref ref T Back() => ref _refReturnTypeForBack;
		private ref T _refReturnTypeForBack; // Dummy field
		public void SwapAndPopBack(uint indexA) {}
		public void Reserve(uint newCapacity) {}
		public Span<T> AsSpan() => default;
	}

	public static class AssetInstanceParseUtil // TypeDefIndex: 49499
	{
		// Methods
		public static NativeArray<int> Parse(UnityEngine.Object[] objects) => default; // 0x000000018793EA1C-0x000000018793EB0C
		public static int Parse(UnityEngine.Object obj) => default; // 0x000000018793EB0C-0x000000018793EBA0
		public static object Get(int id) => default; // 0x0000000185044CA0-0x0000000185044D00
		public static T Get<T>(int id) => default;
	}
}

namespace Beyond.Gameplay
{
	public class FactorySetting : ScriptableObject // TypeDefIndex: 49506
	{
		// Fields
		public GlobalSharedData.CullingDisSetting cullingDisSetting; // 0x18
		public FactoryEffectSetting lowFactoryEffectSetting; // 0x28
		public FactoryEffectSetting midFactoryEffectSetting; // 0x30
		public FactoryEffectSetting highFactoryEffectSetting; // 0x38
		public FactoryEffectSetting highestFactoryEffectSetting; // 0x40
		public float uiEffectOffsetY; // 0x48
		public float uiFactoryOutputOffsetY; // 0x4C
		public float conveyorOffsetY; // 0x50
		public float conveyorPortBlockOffsetY; // 0x54
		public float pipePortBlockOffsetY; // 0x58
		public int outputPoolSize; // 0x5C
		public int buildingStatePoolSize; // 0x60
		public int portBlockPoolSize; // 0x64
		public int portArrowPoolSize; // 0x68
		public int cargoPoolSize; // 0x6C
		public int3 conveyorPoolSize; // 0x70
		public int3 pipePoolSize; // 0x7C
		public int3 figurePoolSize; // 0x88
		public int figurePipeHolderPoolSize; // 0x94
		public int wirePoolSize; // 0x98
		public int pipeRendererMaxSize; // 0x9C
		public int portRendererMaxSize; // 0xA0
		public bool disableSystemInterval; // 0xA4
		public GlobalSharedData.SystemIntervalSetting systemIntervalSetting; // 0xA8
		public GlobalSharedData.NearByDistanceSetting nearByDistanceSetting; // 0xD0
		public FactoryBaseColorLutConfig factoryLutConfig; // 0xF0
		public FFactoryStateColorConfig factoryStateIconColorConfig; // 0xF8
		public FactoryUIAtlasSOData factoryItemIconAtlasUVConfig; // 0x118
		public FactoryUIAtlasSOData factoryStateIconAtlasUVConfig; // 0x120
		public FactoryUIAtlasSOData factorySocialIconAtlasUVConfig; // 0x128
		public FactoryLiquidAtlasSOData factoryLiquidAtlasUVConfig; // 0x130
		public AnimationCurve buildCutoffYCurve; // 0x138
		public AnimationCurve buildAlphaCurveType0; // 0x140
		public AnimationCurve buildAlphaCurveType1; // 0x148
		public AnimationCurve repairCurve0; // 0x150
		public AnimationCurve repairCurve1; // 0x158
		public float buildingDither; // 0x160
		public float pedestalDither; // 0x164
		public float ditherTargetField; // 0x168
		public float ditherDistance; // 0x16C
		public float lowFrameRate; // 0x170
	
		// Constructors
		public FactorySetting() {} // 0x0000000185F9A910-0x0000000185F9A960
	
		// Methods
		private void OnEnable() {} // 0x0000000185F9F570-0x0000000185F9F5B0
	}

	[Serializable]
	public struct FactoryEffectSetting // TypeDefIndex: 49507
	{
		// Fields
		public int maxEffectCount; // 0x00
		public float effectInterval; // 0x04
	}
}

namespace Beyond.Gameplay.Factory
{
	public static class Archetypes // TypeDefIndex: 49508
	{
		// Properties
		public static NativeArray<ComponentType> empty { get; } // 0x00000001840BDB30-0x00000001840BE5A0 
		public static NativeArray<ComponentType> env { get; } // 0x00000001845D1180-0x00000001845D12A0 
		public static NativeArray<ComponentType> connection { get; } // 0x00000001840965B0-0x00000001840966D0 
		public static NativeArray<ComponentType> buildingUnit { get; } // 0x00000001840BCF20-0x00000001840BD4E0 
		public static NativeArray<ComponentType> powerStation { get; } // 0x0000000184AA4E30-0x0000000184AA4F10 
		public static NativeArray<ComponentType> furnace { get; } // 0x0000000184AA6D80-0x0000000184AA6EB0 
		public static NativeArray<ComponentType> grinder { get; } // 0x0000000184AA6FB0-0x0000000184AA70E0 
		public static NativeArray<ComponentType> winder { get; } // 0x0000000184AA7F20-0x0000000184AA8040 
		public static NativeArray<ComponentType> componentMc { get; } // 0x0000000184AA76C0-0x0000000184AA77F0 
		public static NativeArray<ComponentType> shaper { get; } // 0x0000000184AA7590-0x0000000184AA76C0 
		public static NativeArray<ComponentType> fillingPowderMc { get; } // 0x0000000184AA7A50-0x0000000184AA7B80 
		public static NativeArray<ComponentType> thickener { get; } // 0x0000000184AA6B20-0x0000000184AA6C50 
		public static NativeArray<ComponentType> hub { get; } // 0x0000000184AA4B60-0x0000000184AA4BF0 
		public static NativeArray<ComponentType> subHub { get; } // 0x0000000184AA4D10-0x0000000184AA4DA0 
		public static NativeArray<ComponentType> miner { get; } // 0x0000000184AA6EB0-0x0000000184AA6FB0 
		public static NativeArray<ComponentType> toolsAssemblingMc { get; } // 0x0000000184AA7920-0x0000000184AA7A50 
		public static NativeArray<ComponentType> seedCollector { get; } // 0x0000000184AA5330-0x0000000184AA5460 
		public static NativeArray<ComponentType> planter { get; } // 0x0000000184AA6C50-0x0000000184AA6D80 
		public static NativeArray<ComponentType> powerDiffuser { get; } // 0x0000000184AA65C0-0x0000000184AA6650 
		public static NativeArray<ComponentType> powerPole { get; } // 0x0000000184AA54F0-0x0000000184AA5580 
		public static NativeArray<ComponentType> travelPole { get; } // 0x0000000184AA5460-0x0000000184AA54F0 
		public static NativeArray<ComponentType> loader { get; } // 0x0000000184AA4BF0-0x0000000184AA4C80 
		public static NativeArray<ComponentType> unloader { get; } // 0x0000000184AA6A40-0x0000000184AA6B20 
		public static NativeArray<ComponentType> storage { get; } // 0x0000000184AA5110-0x0000000184AA51A0 
		public static NativeArray<ComponentType> powerTerminal { get; } // 0x000000018793E888-0x000000018793E934 
		public static NativeArray<ComponentType> powerPort { get; } // 0x0000000184AA4FA0-0x0000000184AA5030 
		public static NativeArray<ComponentType> facBattle { get; } // 0x0000000184AA70E0-0x0000000184AA71C0 
		public static NativeArray<ComponentType> pump { get; } // 0x0000000184AA5230-0x0000000184AA5330 
		public static NativeArray<ComponentType> liquidStorage { get; } // 0x0000000184AA8040-0x0000000184AA8110 
		public static NativeArray<ComponentType> mixPool { get; } // 0x0000000184AA7460-0x0000000184AA7590 
		public static NativeArray<ComponentType> squirter { get; } // 0x000000018793E934-0x000000018793EA1C 
		public static NativeArray<ComponentType> dumper { get; } // 0x0000000184AA7B80-0x0000000184AA7C80 
		public static NativeArray<ComponentType> liquidCleaner { get; } // 0x0000000184AA4F10-0x0000000184AA4FA0 
		public static NativeArray<ComponentType> xiraniteOven { get; } // 0x0000000184AA77F0-0x0000000184AA7920 
		public static NativeArray<ComponentType> liquidPurifier { get; } // 0x0000000184AA7DD0-0x0000000184AA7F20 
		public static NativeArray<ComponentType> dismantler { get; } // 0x000000018793E438-0x000000018793E568 
		public static NativeArray<ComponentType> hsBus { get; } // 0x0000000184AA5030-0x0000000184AA5110 
		public static NativeArray<ComponentType> hsBusSource { get; } // 0x0000000184AA4C80-0x0000000184AA4D10 
		public static NativeArray<ComponentType> udPipeLoader { get; } // 0x0000000184AA71C0-0x0000000184AA7310 
		public static NativeArray<ComponentType> udPipeUnloader { get; } // 0x0000000184AA7310-0x0000000184AA7460 
		public static NativeArray<ComponentType> liquidCleanGate { get; } // 0x000000018793E568-0x000000018793E650 
		public static NativeArray<ComponentType> liquidRecycleGate { get; } // 0x000000018793E650-0x000000018793E738 
		public static NativeArray<ComponentType> carrier { get; } // 0x0000000184AA4DA0-0x0000000184AA4E30 
		public static NativeArray<ComponentType> marker { get; } // 0x0000000184AA51A0-0x0000000184AA5230 
		public static NativeArray<ComponentType> decoration { get; } // 0x000000018793E118-0x000000018793E438 
		public static NativeArray<ComponentType> pipeConditioner { get; } // 0x0000000184AA7C80-0x0000000184AA7DD0 
		public static NativeArray<ComponentType> logConditioner { get; } // 0x000000018793E738-0x000000018793E888 
		public static NativeArray<ComponentType> buildingFakeUnit { get; } // 0x0000000185A1FC20-0x0000000185A1FFB0 
		public static NativeArray<ComponentType> buildingRenderOnlyUnit { get; } // 0x0000000185A97380-0x0000000185A97650 
		public static NativeArray<ComponentType> buildingPreviewUnit { get; } // 0x0000000184AE3FF0-0x0000000184AE4320 
		public static NativeArray<ComponentType> buildingGuideHintUnit { get; } // 0x0000000185A7F590-0x0000000185A7F890 
		public static NativeArray<ComponentType> conveyor { get; } // 0x0000000184095370-0x0000000184095610 
		public static NativeArray<ComponentType> guideConveyor { get; } // 0x0000000185B55FD0-0x0000000185B56240 
		public static NativeArray<ComponentType> pipe { get; } // 0x00000001847E6B90-0x00000001847E7340 
		public static NativeArray<ComponentType> pipeHolder { get; } // 0x00000001849844F0-0x00000001849847F0 
		public static NativeArray<ComponentType> cargo { get; } // 0x00000001840BD4E0-0x00000001840BDA60 
		public static NativeArray<ComponentType> buildingRender { get; } // 0x00000001840BEEA0-0x00000001840BF230 
		public static NativeArray<ComponentType> pedestalRender { get; } // 0x0000000184095010-0x0000000184095370 
		public static NativeArray<ComponentType> conveyorLeftRender { get; } // 0x00000001847E5C40-0x00000001847E5E50 
		public static NativeArray<ComponentType> conveyorRightRender { get; } // 0x00000001847E5850-0x00000001847E5A60 
		public static NativeArray<ComponentType> conveyorMidRender { get; } // 0x00000001847E6770-0x00000001847E6980 
		public static NativeArray<ComponentType> figurePipeHolderRender { get; } // 0x0000000185724CF0-0x0000000185724ED0 
		public static NativeArray<ComponentType> figureLeftRender { get; } // 0x0000000185724ED0-0x00000001857250B0 
		public static NativeArray<ComponentType> figureRightRender { get; } // 0x00000001857250B0-0x0000000185725290 
		public static NativeArray<ComponentType> figureMidRender { get; } // 0x0000000185725290-0x0000000185725470 
		public static NativeArray<ComponentType> conveyorPreviewRender { get; } // 0x0000000184D610A0-0x0000000184D61280 
		public static NativeArray<ComponentType> pipePreviewRender { get; } // 0x000000018478E500-0x000000018478E6B0 
		public static NativeArray<ComponentType> pipeComRender { get; } // 0x00000001847E6030-0x00000001847E61C0 
		public static NativeArray<ComponentType> pipeLeftRender { get; } // 0x00000001847E5430-0x00000001847E5640 
		public static NativeArray<ComponentType> pipeMidRender { get; } // 0x00000001847E6980-0x00000001847E6B90 
		public static NativeArray<ComponentType> pipeRightRender { get; } // 0x00000001847E5640-0x00000001847E5850 
		public static NativeArray<ComponentType> pipeTrackLeftPreviewRender { get; } // 0x00000001847E48F0-0x00000001847E4AD0 
		public static NativeArray<ComponentType> pipeTrackMidPreviewRender { get; } // 0x00000001847E4AD0-0x00000001847E4CB0 
		public static NativeArray<ComponentType> pipeTrackRightPreviewRender { get; } // 0x00000001847E4CB0-0x00000001847E4E90 
		public static NativeArray<ComponentType> outputUIRenderer { get; } // 0x000000018478D6E0-0x000000018478D860 
		public static NativeArray<ComponentType> wireRenderer { get; } // 0x00000001847E7560-0x00000001847E76F0 
		public static NativeArray<ComponentType> unitStatusUIRenderer { get; } // 0x000000018478D560-0x000000018478D6E0 
		public static NativeArray<ComponentType> portPreviewUIRenderer { get; } // 0x000000018478DFA0-0x000000018478E130 
		public static NativeArray<ComponentType> gridRenderer { get; } // 0x00000001858D7C80-0x00000001858D7E60 
		public static NativeArray<ComponentType> gridMainRegionRenderer { get; } // 0x00000001858D7E60-0x00000001858D8040 
		public static NativeArray<ComponentType> portStatusUIRenderer { get; } // 0x000000018478D3E0-0x000000018478D560 
		public static NativeArray<ComponentType> scope { get; } // 0x000000018478CCD0-0x000000018478CDF0 
	
		// Methods
		public static NativeArray<ComponentType> CreateArchetype(NativeArray<ComponentType> baseArchetype, ComponentType[] extraTypes) => default; // 0x0000000184AA6650-0x0000000184AA6810
		public static NativeArray<ComponentType> Select(string templateId) => default; // 0x0000000184AA5580-0x0000000184AA6560
	}

	public struct AdditiveEffectRequestStack<T> : IEnumerable<T> // TypeDefIndex: 49511
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x02060F81
		public const int CAPACITY = 16; // Metadata: 0x02060F82
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x02060F83
		public const int INVALID_INDEX = -1; // Metadata: 0x02060F84
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49509
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private AdditiveEffectRequestStack<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in AdditiveEffectRequestStack<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49510
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public AdditiveEffectRequestStack(int initialCapacity = 16 /* Metadata: 0x02060F7F */, bool autoExtend = false /* Metadata: 0x02060F80 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct ConveyorExtContainer // TypeDefIndex: 49514
	{
		// Fields
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref ConveyorExt this[int index] { get => default; } // 0x0000000184796AC0-0x0000000184796B10 
		public ref ConveyorExt this[uint index] { get => default; } // 0x000000018793F09C-0x000000018793F0FC 
	
		// Nested types
		public struct ConveyorExt // TypeDefIndex: 49512
		{
			// Fields
			public int outCargoIndex; // 0x00
			public int cargoBeginIndex; // 0x04
			public int cargoEndIndex; // 0x08
	
			// Methods
			public void Reset() {} // 0x00000001852D2F60-0x00000001852D3000
		}
	
		internal struct Node // TypeDefIndex: 49513
		{
			// Fields
			public ConveyorExt value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public ConveyorExtContainer(Unity.Collections.Allocator allocator) : this() {
			m_nodes = default;
		} // 0x000000018793F034-0x000000018793F09C
	
		// Methods
		public void Dispose() {} // 0x000000018793F17C-0x000000018793F1E0
		public uint Size() => default; // 0x000000018793EEF8-0x000000018793EFA8
		public Span<ConveyorExt> AsSpan() => default; // 0x0000000184793130-0x00000001847931E0
		public uint Create(ref ConveyorExt value) => default; // 0x000000018793EFA8-0x000000018793F034
		public void Destroy(uint handle) {} // 0x00000001852D2E50-0x00000001852D2EC0
		public void Reset() {} // 0x000000018793F0FC-0x000000018793F17C
		public void Reserve(uint newCapacity) {} // 0x00000001843EB710-0x00000001843EB7A0
		public IntPtr Data() => default; // 0x000000018793F1E0-0x000000018793F224
		public ref ConveyorExt Get(uint handle) => ref _refReturnTypeForGet; // 0x00000001841CB6D0-0x00000001841CB700
		private ref ConveyorExt _refReturnTypeForGet; // Dummy field
	}

	public struct ConveyorInfoAllocator // TypeDefIndex: 49516
	{
		// Fields
		private LinearAllocatorUnmanaged m_allocator; // 0x00
	
		// Properties
		public unsafe void* memoryPtr { get => default; } // 0x000000018793F300-0x000000018793F30C 
	
		// Nested types
		public struct Info // TypeDefIndex: 49515
		{
			// Fields
			public byte protoType; // 0x00
			public bool isCorner; // 0x01
			public float adjustHeight; // 0x04
			public float3 position; // 0x08
			public float3 rotation; // 0x14
			public float bend; // 0x20
			public uint lightMode; // 0x24
		}
	
		// Methods
		public static unsafe ConveyorInfoAllocator* Create(int capacity) => default; // 0x00000001851DE800-0x00000001851DE8B0
		public static unsafe void Destroy(ConveyorInfoAllocator* allocator) {} // 0x000000018793F274-0x000000018793F2A0
		public LinearAllocator.Allocation Allocate(int count) => default; // 0x0000000184D62360-0x0000000184D623D0
		public LinearAllocator.Allocation Resize(LinearAllocator.Allocation allocation, int newCount) => default; // 0x0000000185B936C0-0x0000000185B93740
		public void Free(uint memoryOffset) {} // 0x000000018793F2A0-0x000000018793F300
		public long CalculateSize(uint memoryOffset) => default; // 0x000000018478FDF0-0x000000018478FE40
		public unsafe Info* GetInfo(long offset) => default; // 0x000000018646DE3C-0x000000018646DE44
		public void DebugPrint() {} // 0x000000018793F224-0x000000018793F274
	}

	public struct Data2<T> // TypeDefIndex: 49517
		where T : struct
	{
		// Fields
		public T port0;
		public T port1;
	
		// Properties
		public int length { get => default; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data4<T> // TypeDefIndex: 49518
		where T : struct
	{
		// Fields
		public Data2<T> port0;
		public Data2<T> port1;
	
		// Properties
		public int length { get => default; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data8<T> // TypeDefIndex: 49519
		where T : struct
	{
		// Fields
		public Data4<T> port0;
		public Data4<T> port1;
	
		// Properties
		public int length { get => default; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data16<T> // TypeDefIndex: 49520
		where T : struct
	{
		// Fields
		public Data8<T> port0;
		public Data8<T> port1;
	
		// Properties
		public int length { get => default; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data32<T> // TypeDefIndex: 49521
		where T : struct
	{
		// Fields
		public Data16<T> port0;
		public Data16<T> port1;
	
		// Properties
		public int length { get => default; }
		public T this[int idx] { get => default; set {} }
	}

	public struct EntityData4<T> : IEnumerable<T> // TypeDefIndex: 49524
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x02060F87
		public const int CAPACITY = 4; // Metadata: 0x02060F88
		public const int CAPACITY_MINUS_ONE = 3; // Metadata: 0x02060F89
		public const int INVALID_INDEX = -1; // Metadata: 0x02060F8A
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49522
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData4<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in EntityData4<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49523
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public EntityData4(int initialCapacity = 4 /* Metadata: 0x02060F85 */, bool autoExtend = false /* Metadata: 0x02060F86 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct EntityData8<T> : IEnumerable<T> // TypeDefIndex: 49527
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x02060F8D
		public const int CAPACITY = 8; // Metadata: 0x02060F8E
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x02060F8F
		public const int INVALID_INDEX = -1; // Metadata: 0x02060F90
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49525
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData8<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in EntityData8<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49526
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public EntityData8(int initialCapacity = 8 /* Metadata: 0x02060F8B */, bool autoExtend = false /* Metadata: 0x02060F8C */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct EntityData32<T> : IEnumerable<T> // TypeDefIndex: 49530
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x02060F93
		public const int CAPACITY = 32; // Metadata: 0x02060F94
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x02060F95
		public const int INVALID_INDEX = -1; // Metadata: 0x02060F96
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49528
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData32<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in EntityData32<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49529
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public EntityData32(int initialCapacity = 32 /* Metadata: 0x02060F91 */, bool autoExtend = false /* Metadata: 0x02060F92 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct EntityData64<T> : IEnumerable<T> // TypeDefIndex: 49533
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x02060F9A
		public const int CAPACITY = 64; // Metadata: 0x02060F9B
		public const int CAPACITY_MINUS_ONE = 63; // Metadata: 0x02060F9D
		public const int INVALID_INDEX = -1; // Metadata: 0x02060F9E
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49531
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData64<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in EntityData64<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49532
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public EntityData64(int initialCapacity = 64 /* Metadata: 0x02060F97 */, bool autoExtend = false /* Metadata: 0x02060F99 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct EntityData128<T> : IEnumerable<T> // TypeDefIndex: 49536
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x02060FA2
		public const int CAPACITY = 128; // Metadata: 0x02060FA3
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x02060FA5
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FA7
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49534
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData128<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in EntityData128<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49535
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public EntityData128(int initialCapacity = 128 /* Metadata: 0x02060F9F */, bool autoExtend = false /* Metadata: 0x02060FA1 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct EntityData256<T> : IEnumerable<T> // TypeDefIndex: 49539
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x02060FAB
		public const int CAPACITY = 256; // Metadata: 0x02060FAC
		public const int CAPACITY_MINUS_ONE = 255; // Metadata: 0x02060FAE
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FB0
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49537
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData256<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in EntityData256<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49538
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public EntityData256(int initialCapacity = 256 /* Metadata: 0x02060FA8 */, bool autoExtend = false /* Metadata: 0x02060FAA */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct EntityData512<T> : IEnumerable<T> // TypeDefIndex: 49542
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x02060FB4
		public const int CAPACITY = 512; // Metadata: 0x02060FB5
		public const int CAPACITY_MINUS_ONE = 511; // Metadata: 0x02060FB7
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FB9
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49540
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData512<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in EntityData512<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49541
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public EntityData512(int initialCapacity = 512 /* Metadata: 0x02060FB1 */, bool autoExtend = false /* Metadata: 0x02060FB3 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct EntityData1024<T> : IEnumerable<T> // TypeDefIndex: 49545
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x02060FBD
		public const int CAPACITY = 1024; // Metadata: 0x02060FBE
		public const int CAPACITY_MINUS_ONE = 1023; // Metadata: 0x02060FC0
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FC2
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49543
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData1024<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in EntityData1024<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49544
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public EntityData1024(int initialCapacity = 1024 /* Metadata: 0x02060FBA */, bool autoExtend = false /* Metadata: 0x02060FBC */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct Float4Data6<T> : IEnumerable<T> // TypeDefIndex: 49548
		where T : struct
	{
		// Fields
		public const int T_SIZE = 16; // Metadata: 0x02060FC5
		public const int CAPACITY = 8; // Metadata: 0x02060FC6
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x02060FC7
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FC8
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49546
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private Float4Data6<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in Float4Data6<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49547
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public Float4Data6(int initialCapacity = 8 /* Metadata: 0x02060FC3 */, bool autoExtend = false /* Metadata: 0x02060FC4 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct Float4Data16<T> : IEnumerable<T> // TypeDefIndex: 49551
		where T : struct
	{
		// Fields
		public const int T_SIZE = 16; // Metadata: 0x02060FCB
		public const int CAPACITY = 16; // Metadata: 0x02060FCC
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x02060FCD
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FCE
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49549
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private Float4Data16<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in Float4Data16<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49550
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public Float4Data16(int initialCapacity = 16 /* Metadata: 0x02060FC9 */, bool autoExtend = false /* Metadata: 0x02060FCA */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct IntData8<T> : IEnumerable<T> // TypeDefIndex: 49554
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x02060FD1
		public const int CAPACITY = 8; // Metadata: 0x02060FD2
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x02060FD3
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FD4
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49552
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private IntData8<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in IntData8<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49553
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public IntData8(int initialCapacity = 8 /* Metadata: 0x02060FCF */, bool autoExtend = false /* Metadata: 0x02060FD0 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct IntData32<T> : IEnumerable<T> // TypeDefIndex: 49557
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x02060FD7
		public const int CAPACITY = 32; // Metadata: 0x02060FD8
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x02060FD9
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FDA
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49555
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private IntData32<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in IntData32<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49556
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public IntData32(int initialCapacity = 32 /* Metadata: 0x02060FD5 */, bool autoExtend = false /* Metadata: 0x02060FD6 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct LogisticsExtContainer // TypeDefIndex: 49559
	{
		// Nested types
		public struct LogisticsExtData // TypeDefIndex: 49558
		{
		}
	}

	public struct OutputRendererInfo // TypeDefIndex: 49560
	{
		// Fields
		public float3 outputPos; // 0x00
		public bool enableLiquidIcon; // 0x0C
		public bool depthBlendDisabled; // 0x0D
		public half4 color; // 0x10
		public half4 atlasRect; // 0x18
		public half4 liquidAtlasUV; // 0x20
	}

	public struct PortData16<T> : IEnumerable<T> // TypeDefIndex: 49563
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x02060FDD
		public const int CAPACITY = 16; // Metadata: 0x02060FDF
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x02060FE0
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FE1
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49561
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PortData16<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in PortData16<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49562
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public PortData16(int initialCapacity = 16 /* Metadata: 0x02060FDB */, bool autoExtend = false /* Metadata: 0x02060FDC */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct PortData32<T> : IEnumerable<T> // TypeDefIndex: 49566
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x02060FE4
		public const int CAPACITY = 32; // Metadata: 0x02060FE6
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x02060FE7
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FE8
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49564
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PortData32<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in PortData32<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49565
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public PortData32(int initialCapacity = 32 /* Metadata: 0x02060FE2 */, bool autoExtend = false /* Metadata: 0x02060FE3 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct PortData128<T> : IEnumerable<T> // TypeDefIndex: 49569
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x02060FEC
		public const int CAPACITY = 128; // Metadata: 0x02060FEE
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x02060FF0
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FF2
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49567
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PortData128<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in PortData128<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49568
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public PortData128(int initialCapacity = 128 /* Metadata: 0x02060FE9 */, bool autoExtend = false /* Metadata: 0x02060FEB */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct PortData256<T> : IEnumerable<T> // TypeDefIndex: 49572
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x02060FF6
		public const int CAPACITY = 256; // Metadata: 0x02060FF8
		public const int CAPACITY_MINUS_ONE = 255; // Metadata: 0x02060FFA
		public const int INVALID_INDEX = -1; // Metadata: 0x02060FFC
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49570
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PortData256<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in PortData256<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49571
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public PortData256(int initialCapacity = 256 /* Metadata: 0x02060FF3 */, bool autoExtend = false /* Metadata: 0x02060FF5 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct SharedDataContainer // TypeDefIndex: 49576
	{
		// Fields
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref SharedExtData this[int index] { get => default; } // 0x0000000187941F38-0x0000000187941F98 
		public ref SharedExtData this[uint index] { get => default; } // 0x0000000187941F98-0x0000000187942020 
	
		// Nested types
		public struct SharedExtData // TypeDefIndex: 49573
		{
			// Fields
			public uint next; // 0x00
			public int pendingSlotId; // 0x04
			public uint nodeId; // 0x08
			public ChapterTagFragment chapter; // 0x0C
			public StaticMountInfoCollection<StaticMountInfo> staticMountInfos; // 0x1C
			public bool adjustMapValid; // 0x524
			public float adjustMapHeight; // 0x528
			public bool bAdjustedMap; // 0x52C
			public bool bAdjustedOnce; // 0x52D
			public bool culled; // 0x52E
			public bool buildingNameCulled; // 0x52F
			public bool stateUICulled; // 0x530
			public uint dirtyBitmask; // 0x534
			public Visibility visibility; // 0x538
			public Visibility additiveMatVisibility; // 0x550
			public AdditiveEffectFragment additiveEffect; // 0x568
			public bool inMainRegion; // 0xD10
	
			// Properties
			public bool visible { get => default; } // 0x00000001852D2EC0-0x00000001852D2F60 
			public bool visibleAdditiveMat { get => default; } // 0x0000000187941D40-0x0000000187941DA8 
	
			// Methods
			public bool IsDirty(DirtyFlag f) => default; // 0x0000000187941E90-0x0000000187941EF4
			public void SetDirty(DirtyFlag f, bool d) {} // 0x0000000187941C90-0x0000000187941D40
			public bool IsPendingUnit() => default; // 0x0000000184795170-0x0000000184795320
		}
	
		public enum DirtyFlag // TypeDefIndex: 49574
		{
			NONE = 0,
			STATUS_CHANGE = 1,
			VAT_UPDATE = 2,
			UPDATE_STATUS_EFFECT = 4,
			CULL_STATUS_CHANGE = 8,
			ALL = 255
		}
	
		internal struct Node // TypeDefIndex: 49575
		{
			// Fields
			public SharedExtData value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public SharedDataContainer(Unity.Collections.Allocator allocator) : this() {
			m_nodes = default;
		} // 0x000000018479D550-0x000000018479D5C0
	
		// Methods
		public void Dispose() {} // 0x00000001852D2DE0-0x00000001852D2E50
		public uint Size() => default; // 0x0000000187941E0C-0x0000000187941E90
		public Span<SharedExtData> AsSpan() => default; // 0x00000001843ECF90-0x00000001843ED030
		public uint Create(ref SharedExtData value) => default; // 0x0000000187941EF4-0x0000000187941F38
		public void Destroy(uint handle) {} // 0x0000000184165110-0x0000000184165160
		public void Reset() {} // 0x0000000187941DA8-0x0000000187941E0C
		public void Reserve(uint newCapacity) {} // 0x0000000184163610-0x00000001841637E0
		public IntPtr Data() => default; // 0x0000000184984AC0-0x0000000184984B20
		public ref SharedExtData Get(uint handle) => ref _refReturnTypeForGet; // 0x000000018415FE70-0x000000018415FEF0
		private ref SharedExtData _refReturnTypeForGet; // Dummy field
	}

	public struct StaticMountInfo // TypeDefIndex: 49577
	{
		// Fields
		public Entity rendererEntity; // 0x00
		public FactoryUnitExtendConfig mountConfig; // 0x08
	}

	public struct StaticMountInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49580
		where T : struct
	{
		// Fields
		public const int T_SIZE = 80; // Metadata: 0x02061006
		public const int CAPACITY = 16; // Metadata: 0x02061008
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x02061009
		public const int INVALID_INDEX = -1; // Metadata: 0x0206100A
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49578
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private StaticMountInfoCollection<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in StaticMountInfoCollection<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49579
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public StaticMountInfoCollection(int initialCapacity = 16 /* Metadata: 0x02061004 */, bool autoExtend = false /* Metadata: 0x02061005 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe T* GetDataPtr() => default;
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct UnitExtendConfig12<T> : IEnumerable<T> // TypeDefIndex: 49583
		where T : struct
	{
		// Fields
		public const int T_SIZE = 128; // Metadata: 0x0206100D
		public const int CAPACITY = 16; // Metadata: 0x0206100F
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x02061010
		public const int INVALID_INDEX = -1; // Metadata: 0x02061011
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49581
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private UnitExtendConfig12<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in UnitExtendConfig12<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49582
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public UnitExtendConfig12(int initialCapacity = 16 /* Metadata: 0x0206100B */, bool autoExtend = false /* Metadata: 0x0206100C */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct WireRendererInfo // TypeDefIndex: 49584
	{
		// Fields
		public float3 fromPos; // 0x00
		public float3 toPos; // 0x0C
		public ulong connectionId; // 0x18
		public float alpha; // 0x20
	
		// Properties
		public float3 pos { get => default; } // 0x0000000187942020-0x00000001879420E8 
		public quaternion rot { get => default; } // 0x00000001879420E8-0x0000000187942224 
		public float scale { get => default; } // 0x0000000187942224-0x0000000187942260 
	}

	public struct WireRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49587
		where T : struct
	{
		// Fields
		public const int T_SIZE = 48; // Metadata: 0x02061015
		public const int CAPACITY = 512; // Metadata: 0x02061016
		public const int CAPACITY_MINUS_ONE = 511; // Metadata: 0x02061018
		public const int INVALID_INDEX = -1; // Metadata: 0x0206101A
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49585
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private WireRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in WireRendererInfoCollection<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49586
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public WireRendererInfoCollection(int initialCapacity = 512 /* Metadata: 0x02061012 */, bool autoExtend = false /* Metadata: 0x02061014 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe T* GetDataPtr() => default;
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public class EntitySearcher // TypeDefIndex: 49588
	{
		// Fields
		private NativeParallelHashMap<UnitId, Entity> m_logicEntityMap; // 0x10
	
		// Constructors
		public EntitySearcher() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public NativeParallelHashMap<UnitId, Entity> GetLogicEntityMap() => default; // 0x000000018794066C-0x00000001879406D4
		public void RegisterLogicEntity(int chapterId, uint nodeId, Entity entity) {} // 0x0000000184650800-0x00000001846509E0
		public bool UnregisterLogicEntity(int chapterId, uint nodeId) => default; // 0x000000018479D4B0-0x000000018479D550
		public bool GetLogicEntity(int chapterId, uint nodeId, out Entity entity) {
			entity = default;
			return default;
		} // 0x00000001841643C0-0x0000000184164860
		private void _DestroyAllEntities() {} // 0x00000001879406D4-0x0000000187940788
		public void DestroyAll() {} // 0x000000018794061C-0x000000018794066C
	}

	public static class MiscExtensions // TypeDefIndex: 49589
	{
		// Methods
		public static void SafeDispose<T>(NativeList<T> list)
			where T : struct {}
		public static void SafeDispose<T>(NativeArray<T> array)
			where T : struct {}
		public static void SafeDispose<T>(NativeQueue<T> queue)
			where T : struct {}
		public static void SafeDispose<T>(UnsafeList<T> list)
			where T : struct {}
		public static void SafeDispose<TKey, TValue>(NativeParallelHashMap<TKey, TValue> list)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct {}
		public static void SafeDispose<TKey, TValue>(UnsafeParallelHashMap<TKey, TValue> list)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct {}
	}

	public static class FactoryProfilerMakers // TypeDefIndex: 49590
	{
		// Fields
		public static readonly ProfilerMarker S_PROFILER_PRE_EXECUTE; // 0x00
		public static readonly ProfilerMarker S_PROFILER_EXECUTE; // 0x08
		public static readonly ProfilerMarker S_PROFILER_FLUSH_REPEATER; // 0x10
		public static readonly ProfilerMarker S_PROFILER_BLUEPRINT_UPDATE; // 0x18
		public static readonly ProfilerMarker S_PROFILER_LATE_EXECUTE; // 0x20
		public static readonly ProfilerMarker S_PROFILER_CLEAN; // 0x28
		public static readonly ProfilerMarker S_MODIFY_REGION_NODES; // 0x30
		public static readonly ProfilerMarker S_DITHER_PREPARE_ENTITY_POS; // 0x38
		public static readonly ProfilerMarker S_SEARCH_DITHER_ENTITY; // 0x40
		public static readonly ProfilerMarker S_EXECUTE_DITHER; // 0x48
		public static readonly ProfilerMarker S_PROTO_LOGISTIC; // 0x50
		public static readonly ProfilerMarker S_PROTO_EXECUTE_LOGISTIC_EFFECT; // 0x58
		public static readonly ProfilerMarker S_PROTO_CARGO; // 0x60
		public static readonly ProfilerMarker S_PROTO_PARSE_CARGO; // 0x68
		public static readonly ProfilerMarker S_PROTO_PARSE_CARGO_PREPARE; // 0x70
		public static readonly ProfilerMarker S_CARGO_ENQUEUE; // 0x78
		public static readonly ProfilerMarker S_CARGO_DEQUEUE; // 0x80
		public static readonly ProfilerMarker S_CARGO_ADJUST; // 0x88
		public static readonly ProfilerMarker S_ECS_INSTANCE; // 0x90
		public static readonly ProfilerMarker S_TRY_NUM_TO_STR_ITEM; // 0x98
		public static readonly ProfilerMarker S_TRY_STR_TO_NUM_ITEM; // 0xA0
	
		// Constructors
		static FactoryProfilerMakers() {} // 0x00000001859710E0-0x00000001859715E0
	}

	public static class FactorySharedDataManager // TypeDefIndex: 49591
	{
		// Fields
		private static ConveyorExtContainer s_conveyorExtData; // 0x00
		private static SharedDataContainer s_sharedData; // 0x18
		private static EntityHierarchyContainer s_hierarchy; // 0x30
		private static VATFSMDefinitionContainer s_vatFsm; // 0x38
	
		// Methods
		public static void InitExtData() {} // 0x00000001852D2900-0x00000001852D2A70
		public static void ResetExtData() {} // 0x00000001852D2A70-0x00000001852D2B20
		public static void ReleaseExtData() {} // 0x0000000187940A30-0x0000000187940AEC
		public static uint CreateConveyorExtHandle() => default; // 0x00000001847931E0-0x0000000184793250
		public static void DestroyConveyorExtHandle(uint handle) {} // 0x0000000187940934-0x00000001879409B0
		public static ref ConveyorExtContainer.ConveyorExt GetConveyorExt(uint handle) => ref _refReturnTypeForGetConveyorExt; // 0x00000001847969D0-0x0000000184796AC0
		private ref ConveyorExtContainer.ConveyorExt _refReturnTypeForGetConveyorExt; // Dummy field
		public static IntPtr GetConveyorExtData() => default; // 0x00000001843EB660-0x00000001843EB710
		public static uint CreateSharedData(bool adjustMapValid = true /* Metadata: 0x0206101B */) => default; // 0x0000000184795060-0x0000000184795170
		public static ref SharedDataContainer.SharedExtData GetSharedData(uint handle) => ref _refReturnTypeForGetSharedData; // 0x0000000184165030-0x0000000184165110
		private ref SharedDataContainer.SharedExtData _refReturnTypeForGetSharedData; // Dummy field
		public static void DestroySharedData(uint handle) {} // 0x000000018479D5C0-0x000000018479D630
		public static IntPtr GetSharedData() => default; // 0x00000001843ECE40-0x00000001843ECF90
		public static uint CreateTransHierarchy() => default; // 0x00000001843E6E50-0x00000001843E6EF0
		public static ref EntityHierarchyContainer.EntityTransformData GetHierarchyData(uint handle) => ref _refReturnTypeForGetHierarchyData; // 0x0000000184094EE0-0x0000000184094FD0
		private ref EntityHierarchyContainer.EntityTransformData _refReturnTypeForGetHierarchyData; // Dummy field
		public static ref EntityHierarchyContainer.EntityTransformData GetHierarchyData(int handle) => ref _refReturnTypeForGetHierarchyData; // 0x00000001843E7030-0x00000001843E70C0
		private ref EntityHierarchyContainer.EntityTransformData _refReturnTypeForGetHierarchyData; // Dummy field
		public static float4x4 WorldTrans(in EntityHierarchyContainer.EntityTransformData transform) => default; // 0x0000000187940AEC-0x0000000187940C10
		public static void DestroyHierarchyData(uint handle) {} // 0x000000018479D670-0x000000018479D6E0
		public static IntPtr GetHierarchyData() => default; // 0x00000001843EE340-0x00000001843EE420
		public static uint CreateVATFSMDefinitionContainer(ref VATFSMDefinition definition) => default; // 0x00000001852D2C90-0x00000001852D2D00
		public static ref VATFSMDefinition GetVATFSMDefinition(uint handle) => ref _refReturnTypeForGetVATFSMDefinition; // 0x000000018511E790-0x000000018511E810
		private ref VATFSMDefinition _refReturnTypeForGetVATFSMDefinition; // Dummy field
		public static void DestroyVATFSMDefinition(uint handle) {} // 0x00000001879409B0-0x0000000187940A30
		public static IntPtr GetVATFSMDefinition() => default; // 0x00000001843EBCF0-0x00000001843EBE40
	}

	public struct AdditiveEffectFragment // TypeDefIndex: 49594
	{
		// Fields
		public byte entityType; // 0x00
		public uint lightMode; // 0x04
		public SoloSelectState soloSelectState; // 0x08
		public BuildDismissState buildDismissState; // 0x10
		public CutoffState cutoffState; // 0x28
		public RepairState repairState; // 0x38
		public HighLightState highLightState; // 0x60
		public HintState hintState; // 0xEC
		public FigureState figureState; // 0xF8
		public OverloadState overloadState; // 0x104
		public OverloadInvalidState overloadInvalidState; // 0x110
		public BlueprintState blueprintState; // 0x120
		public PreSelectState preSelectState; // 0x350
		public ContinuationState continuationState; // 0x552
		public SocialSharingState socialSharingState; // 0x754
		public PowerInteractionState powerInteractionState; // 0x755
		public Request curEffectRequest; // 0x756
		public AdditiveEffectRequestStack<Request> stateWaitStack; // 0x75C
	
		// Properties
		public AdditiveEffectType curEffectType { get => default; set {} } // 0x0000000185FB6BF0-0x0000000185FB6C00 0x0000000185FB6C00-0x0000000185FB6C20
	
		// Nested types
		public struct Request // TypeDefIndex: 49592
		{
			// Fields
			public AdditiveEffectType type; // 0x00
			public short typeValue; // 0x00
			public AdditiveEffectType lastType; // 0x02
			public short lastTypeValue; // 0x02
		}
	
		public enum AdditiveEffectType : short // TypeDefIndex: 49593
		{
			NONE = 0,
			SOLO_SELECT = 1,
			BUILD_DISMISS = 2,
			BLUEPRINT_BUILD = 3,
			CUTOFF = 4,
			REPAIR = 5,
			HIGH_LIGHT = 6,
			HINT = 7,
			FIGURE = 8,
			OVERLOAD = 9,
			OVERLOAD_INVALID = 10,
			BLUEPRINT = 11,
			PRE_SELECT = 12,
			CONTINUATION = 13,
			SOCIAL_SHARING = 14,
			POWER_INTERACTION = 15
		}
	
		// Methods
		public void PushState(AdditiveEffectType state) {} // 0x00000001840B5B50-0x00000001840B5C10
		public void InsertState(int index, AdditiveEffectType state) {} // 0x0000000185A173F0-0x0000000185A175D0
		public AdditiveEffectType ShiftState() => default; // 0x00000001879424D0-0x000000018794255C
		public AdditiveEffectType PopState() => default; // 0x0000000187942428-0x00000001879424D0
		public AdditiveEffectType PeekState() => default; // 0x00000001840B5A10-0x00000001840B5A70
		public void DisableState(AdditiveEffectType state) {} // 0x00000001840B5930-0x00000001840B5A10
		private void _Shrink() {} // 0x00000001840B5C10-0x00000001840B5DE0
		public override string ToString() => default; // 0x000000018794255C-0x00000001879426A0
		public string __iFixBaseProxy_ToString() => default; // 0x00000001879426A0-0x0000000187942700
	}

	public struct CutoffState // TypeDefIndex: 49595
	{
		// Fields
		private bool m_enable; // 0x00
		public uint mode; // 0x04
		public float cutOffY; // 0x08
		private bool _enable_k__BackingField; // 0x0C
	
		// Properties
		public bool enable { get; private set; } // 0x0000000185FB2B70-0x0000000185FB2B80 0x0000000185FB2B80-0x0000000185FB2B90
	
		// Methods
		public void SetEnable(bool v) {} // 0x0000000187945CE0-0x0000000187945D38
		public void SetCutoffY(float v) {} // 0x0000000187945C74-0x0000000187945CE0
		public void SetMode(uint v) {} // 0x0000000187945D38-0x0000000187945D90
	}

	public struct BuildDismissState // TypeDefIndex: 49597
	{
		// Fields
		public bool enable; // 0x00
		public bool started; // 0x01
		public bool build; // 0x02
		public byte effectType; // 0x03
		public float duration; // 0x04
		public float startY; // 0x08
		public float deltaY; // 0x0C
		public long startTms; // 0x10
	
		// Nested types
		public enum BuildEffectType : byte // TypeDefIndex: 49596
		{
			DEFAULT = 0,
			TYPE1 = 1
		}
	
		// Methods
		public void SetEnable(bool v) {} // 0x00000001879430C0-0x0000000187943118
	}

	public struct RepairState // TypeDefIndex: 49598
	{
		// Fields
		public bool enable; // 0x00
		public RepairState0 state0; // 0x08
		public RepairState1 state1; // 0x18
	}

	public struct RepairState0 // TypeDefIndex: 49599
	{
		// Fields
		public bool enable; // 0x00
		public float duration; // 0x04
		public long startTms; // 0x08
	}

	public struct RepairState1 // TypeDefIndex: 49600
	{
		// Fields
		public bool enable; // 0x00
		public float duration; // 0x04
		public long startTms; // 0x08
	}

	public struct HighLightState // TypeDefIndex: 49601
	{
		// Fields
		public bool enable; // 0x00
		public bool invalid; // 0x01
		public bool social; // 0x02
		public FixedList128Bytes<byte> indexList; // 0x04
		public DitherState ditherState; // 0x84
	
		// Methods
		public void SetEnable(bool isEnable) {} // 0x0000000185FA4920-0x0000000185FA4960
		public void SetData(bool isInvalid, bool isSocial) {} // 0x0000000184984A50-0x0000000184984AC0
		public LogicEntityState GetEffectType() => default; // 0x00000001879499D0-0x0000000187949A34
		public bool IsHighlight(byte index) => default; // 0x0000000187949B14-0x0000000187949BC4
		public void HighlightWithSubIndex(byte index, bool en) {} // 0x0000000187949A34-0x0000000187949B14
		public void ClearHighlightableIndexList() {} // 0x00000001849849F0-0x0000000184984A50
	}

	public struct HintState // TypeDefIndex: 49602
	{
		// Fields
		public bool enable; // 0x00
		public bool showSelf; // 0x01
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x0000000187949BC4-0x0000000187949C1C
	}

	public struct FigureState // TypeDefIndex: 49603
	{
		// Fields
		public bool valid; // 0x00
		public bool enable; // 0x01
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x0000000187947268-0x00000001879472C0
	}

	public struct OverloadState // TypeDefIndex: 49604
	{
		// Fields
		public bool enable; // 0x00
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x000000018794AC34-0x000000018794AC8C
	}

	public struct OverloadInvalidState // TypeDefIndex: 49605
	{
		// Fields
		public bool enable; // 0x00
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x000000018794ABDC-0x000000018794AC34
	}

	public struct DitherState // TypeDefIndex: 49606
	{
		// Fields
		public bool enable; // 0x00
		public float ditherVal; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x0000000187945E9C-0x0000000187945EF4
	}

	public struct BlueprintState // TypeDefIndex: 49608
	{
		// Fields
		public bool enable; // 0x00
		public EffectType effectType; // 0x01
		public FixedList512Bytes<byte> indexList; // 0x02
		public CutoffState cutoffState; // 0x204
		public BuildDismissState buildState; // 0x218
	
		// Nested types
		public enum EffectType : byte // TypeDefIndex: 49607
		{
			NONE = 0,
			TO_BE_BUILD = 1,
			TO_BE_BUILD_SELECT = 2,
			MOVING = 3,
			MOVING_INVALID = 4,
			TO_BUILD_INVALID = 5
		}
	
		// Methods
		public void SetEnable(bool v) {} // 0x00000001840B6130-0x00000001840B6170
		public void SetEnable(bool v, EffectType type) {} // 0x00000001840B60E0-0x00000001840B6130
		public bool IsLighten(byte index) => default; // 0x0000000187943010-0x00000001879430C0
		public void LightenWithSubIndex(byte index, bool en) {} // 0x00000001840B5580-0x00000001840B5630
		public void ClearLightenIndexList() {} // 0x00000001840B6080-0x00000001840B60E0
	}

	public struct PreSelectState // TypeDefIndex: 49609
	{
		// Fields
		public bool enable; // 0x00
		public FixedList512Bytes<byte> indexList; // 0x02
	
		// Methods
		public void SetEnable(bool v) {} // 0x0000000185FA4260-0x0000000185FA42A0
		public bool IsLighten(byte index) => default; // 0x000000018794C348-0x000000018794C3F8
		public void LightenWithSubIndex(byte index, bool en) {} // 0x000000018794C3F8-0x000000018794C4D8
		public void ClearLightenIndexList() {} // 0x000000018794C2D4-0x000000018794C348
	}

	public struct SoloSelectState // TypeDefIndex: 49610
	{
		// Fields
		public bool enable; // 0x00
		public int selectedIndex; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x000000018794C9C0-0x000000018794CA18
		public bool IsLighten(int index) => default; // 0x000000018794C960-0x000000018794C9C0
	}

	public struct ContinuationState // TypeDefIndex: 49611
	{
		// Fields
		public bool enable; // 0x00
		public FixedList512Bytes<byte> indexList; // 0x02
	
		// Methods
		public void SetEnable(bool v) {} // 0x0000000185FA4DA0-0x0000000185FA4DE0
		public bool IsLighten(byte index) => default; // 0x0000000187944E48-0x0000000187944EF8
		public void LightenWithSubIndex(byte index, bool en) {} // 0x0000000187944EF8-0x0000000187944FD8
		public void ClearLightenIndexList() {} // 0x0000000187944DD4-0x0000000187944E48
	}

	public struct SocialSharingState // TypeDefIndex: 49612
	{
		// Fields
		public bool enable; // 0x00
	
		// Methods
		public void SetEnable(bool v) {} // 0x000000018794C908-0x000000018794C960
	}

	public struct PowerInteractionState // TypeDefIndex: 49613
	{
		// Fields
		public bool enable; // 0x00
	
		// Methods
		public void SetEnable(bool v) {} // 0x000000018794C27C-0x000000018794C2D4
	}

	public struct AdditiveEffectRendererFragment : IComponentECS // TypeDefIndex: 49614
	{
		// Fields
		public bool anyEffectStateChanged; // 0x00
		private bool m_buildDismissEnabledState; // 0x01
		private bool m_blueprintBuildEnabledState; // 0x02
		private bool m_blueprintBuildCutoffYEnabledState; // 0x03
		private bool m_cutOffYIgnoredState; // 0x04
		private bool m_cutoffYEnabledState; // 0x05
		private bool m_highLightEnabledState; // 0x06
		private bool m_figureEnabledState; // 0x07
		private bool m_hintEnabledState; // 0x08
		private bool m_overloadEnabledState; // 0x09
		private bool m_overloadInvalidEnabledState; // 0x0A
		private bool m_repair0EnabledState; // 0x0B
		private bool m_repair1EnabledState; // 0x0C
		private bool m_blueprintEnabledState; // 0x0D
		private bool m_preSelectEnabledState; // 0x0E
		private bool m_continuationEnabledState; // 0x0F
		private bool m_socialSharingEnabledState; // 0x10
		private bool m_powerInteractionEnabledState; // 0x11
		public const int ID = 1; // Metadata: 0x02061044
	
		// Properties
		public bool buildDismissEnabled { get => default; set {} } // 0x00000001838F1DD0-0x00000001838F1DE0 0x00000001879428F8-0x0000000187942904
		public bool blueprintBuildEnabled { get => default; set {} } // 0x0000000185FB6C30-0x0000000185FB6C40 0x00000001879428E0-0x00000001879428EC
		public bool blueprintBuildCutoffYEnabled { get => default; set {} } // 0x0000000185FB6C20-0x0000000185FB6C30 0x00000001879428D4-0x00000001879428E0
		public bool cutOffYIgnored { get => default; set {} } // 0x0000000185FB6C60-0x0000000185FB6C70 0x0000000187942910-0x000000018794291C
		public bool cutoffYEnabled { get => default; set {} } // 0x0000000185FB6C70-0x0000000185FB6C80 0x000000018794291C-0x0000000187942928
		public bool highLightEnabled { get => default; set {} } // 0x0000000185FB6C90-0x0000000185FB6CA0 0x0000000187942934-0x0000000187942940
		public bool figureEnabled { get => default; set {} } // 0x0000000185FB6C80-0x0000000185FB6C90 0x0000000187942928-0x0000000187942934
		public bool hintEnabled { get => default; set {} } // 0x0000000185FB6A80-0x0000000185FB6A90 0x0000000187942940-0x000000018794294C
		public bool overloadEnabled { get => default; set {} } // 0x0000000185FB6CA0-0x0000000185FB6CB0 0x000000018794294C-0x0000000187942958
		public bool overloadInvalidEnabled { get => default; set {} } // 0x0000000185FB6CB0-0x0000000185FB6CC0 0x0000000187942958-0x0000000187942964
		public bool repair0Enabled { get => default; set {} } // 0x0000000185FB6CD0-0x0000000185FB6CE0 0x000000018794297C-0x0000000187942988
		public bool repair1Enabled { get => default; set {} } // 0x0000000185FB2B70-0x0000000185FB2B80 0x0000000187942988-0x0000000187942994
		public bool blueprintEnabled { get => default; set {} } // 0x0000000185FB6C40-0x0000000185FB6C50 0x00000001879428EC-0x00000001879428F8
		public bool preSelectEnabled { get => default; set {} } // 0x0000000185FB6CC0-0x0000000185FB6CD0 0x0000000187942970-0x000000018794297C
		public bool continuationEnabled { get => default; set {} } // 0x0000000185FB6C50-0x0000000185FB6C60 0x0000000187942904-0x0000000187942910
		public bool socialSharingEnabled { get => default; set {} } // 0x0000000181C2FD60-0x0000000181C2FD70 0x0000000187942994-0x00000001879429A0
		public bool powerInteractionEnabled { get => default; set {} } // 0x0000000185FB22C0-0x0000000185FB22D0 0x0000000187942964-0x0000000187942970
		public bool anyEffect { get => default; } // 0x0000000187942820-0x00000001879428D4 
		public int id { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187942700-0x0000000187942820
	}

	public struct BattleFragment : IComponentECS // TypeDefIndex: 49615
	{
		// Fields
		public bool overload; // 0x00
		public float currentEnergy; // 0x04
		public float maxEnergy; // 0x08
		public const int ID = 2; // Metadata: 0x02061045
	
		// Properties
		public int id { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187942ABC-0x0000000187942BD8
	}

	public struct BindRenderEntityFragment : IComponentECS // TypeDefIndex: 49616
	{
		// Fields
		public EntityData512<Entity> renderEntities; // 0x00
		public const int ID = 3; // Metadata: 0x02061046
	
		// Properties
		public int id { get => default; } // 0x0000000181D1CE70-0x0000000181D1CE80 
	
		// Methods
		public void BindRenderEntity(Entity renderEntity) {} // 0x0000000184984DC0-0x0000000184984E40
		public void BindRenderEntities(Entity[] renderEntityList) {} // 0x0000000187942BD8-0x0000000187942C68
		public void BindRenderEntities(NativeArray<Entity> renderEntityList) {} // 0x0000000187942C68-0x0000000187942DBC
		public void UnbindRenderEntity(Entity renderEntity) {} // 0x0000000187942DBC-0x0000000187942EC4
		public void ClearBindRenderEntities() {} // 0x00000001847A0510-0x00000001847A0560
		public bool Binded(Entity renderEntity) => default; // 0x0000000184984E40-0x0000000184984F30
		public bool HasRenderer() => default; // 0x00000001846536A0-0x0000000184653740
		private void __AOT_FOR_FIX__() {} // 0x0000000187942EC4-0x0000000187943010
	}

	public struct BurnPowerFragment : IComponentECS // TypeDefIndex: 49617
	{
		// Fields
		public long currentLeastProgress; // 0x00
		public long powerGenPerSec; // 0x08
		public FixedString64Bytes burningItemId; // 0x10
		public const int ID = 4; // Metadata: 0x02061047
	
		// Properties
		public int id { get => default; } // 0x0000000181C44E90-0x0000000181C44EA0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187943118-0x000000018794323C
	}

	public struct BusFragment : IComponentECS // TypeDefIndex: 49618
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 5; // Metadata: 0x02061048
	
		// Properties
		public int id { get => default; } // 0x0000000181D27740-0x0000000181D27750 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794323C-0x0000000187943348
	}

	public struct BusFreeFragment : IComponentECS // TypeDefIndex: 49619
	{
		// Fields
		public bool connectToStart; // 0x00
		public bool enabled; // 0x01
		public const int ID = 6; // Metadata: 0x02061049
	
		// Properties
		public int id { get => default; } // 0x0000000181D409B0-0x0000000181D40CF0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187943348-0x000000018794345C
	}

	public struct CacheFragment : IComponentECS // TypeDefIndex: 49627
	{
		// Fields
		private const int CONTAINER_OFFSET = 16; // Metadata: 0x0206104A
		private const int ITEM_SIZE = 16; // Metadata: 0x0206104B
		public _cacheSizePtr_e__FixedBuffer cacheSizePtr; // 0x00
		public byte cacheIn0Size; // 0x00
		public byte cacheIn1Size; // 0x01
		public byte cacheIn2Size; // 0x02
		public byte cacheIn3Size; // 0x03
		public byte cacheOut0Size; // 0x04
		public byte cacheOut1Size; // 0x05
		public byte cacheOut2Size; // 0x06
		public byte cacheOut3Size; // 0x07
		public _cacheFluidSizePtr_e__FixedBuffer cacheFluidSizePtr; // 0x08
		public byte cacheFluidIn0Size; // 0x08
		public byte cacheFluidIn1Size; // 0x09
		public byte cacheFluidIn2Size; // 0x0A
		public byte cacheFluidIn3Size; // 0x0B
		public byte cacheFluidOut0Size; // 0x0C
		public byte cacheFluidOut1Size; // 0x0D
		public byte cacheFluidOut2Size; // 0x0E
		public byte cacheFluidOut3Size; // 0x0F
		public _cacheContentPtr_e__FixedBuffer cacheContentPtr; // 0x10
		public _itemInPtr_e__FixedBuffer itemInPtr; // 0x10
		public FactoryItem in0; // 0x10
		public FactoryItem in1; // 0x20
		public FactoryItem in2; // 0x30
		public FactoryItem in3; // 0x40
		public FactoryItem in4; // 0x50
		public FactoryItem in5; // 0x60
		public FactoryItem in6; // 0x70
		public FactoryItem in7; // 0x80
		public _itemOutPtr_e__FixedBuffer itemOutPtr; // 0x90
		public FactoryItem out0; // 0x90
		public FactoryItem out1; // 0xA0
		public FactoryItem out2; // 0xB0
		public FactoryItem out3; // 0xC0
		public FactoryItem out4; // 0xD0
		public FactoryItem out5; // 0xE0
		public FactoryItem out6; // 0xF0
		public FactoryItem out7; // 0x100
		public _fluidInPtr_e__FixedBuffer fluidInPtr; // 0x110
		public FactoryItem fluidIn0; // 0x110
		public FactoryItem fluidIn1; // 0x120
		public FactoryItem fluidIn2; // 0x130
		public FactoryItem fluidIn3; // 0x140
		public FactoryItem fluidIn4; // 0x150
		public FactoryItem fluidIn5; // 0x160
		public FactoryItem fluidIn6; // 0x170
		public FactoryItem fluidIn7; // 0x180
		public _fluidOutPtr_e__FixedBuffer fluidOutPtr; // 0x190
		public FactoryItem fluidOut0; // 0x190
		public FactoryItem fluidOut1; // 0x1A0
		public FactoryItem fluidOut2; // 0x1B0
		public FactoryItem fluidOut3; // 0x1C0
		public FactoryItem fluidOut4; // 0x1D0
		public FactoryItem fluidOut5; // 0x1E0
		public FactoryItem fluidOut6; // 0x1F0
		public FactoryItem fluidOut7; // 0x200
		public const int ID = 7; // Metadata: 0x0206104C
	
		// Properties
		public int id { get => default; } // 0x0000000181B9FE80-0x0000000181B9FE90 
	
		// Nested types
		public struct _cacheSizePtr_e__FixedBuffer // TypeDefIndex: 49620
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _cacheFluidSizePtr_e__FixedBuffer // TypeDefIndex: 49621
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _cacheContentPtr_e__FixedBuffer // TypeDefIndex: 49622
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _itemInPtr_e__FixedBuffer // TypeDefIndex: 49623
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _itemOutPtr_e__FixedBuffer // TypeDefIndex: 49624
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _fluidInPtr_e__FixedBuffer // TypeDefIndex: 49625
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _fluidOutPtr_e__FixedBuffer // TypeDefIndex: 49626
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		// Methods
		public void GetCacheItem(bool inOut, bool isFluid, int cacheIndex, int indexInCache, out uint itemId, out int itemAmount, out long tms) {
			itemId = default;
			itemAmount = default;
			tms = default;
		} // 0x0000000187943568-0x000000018794367C
		public void SetCacheItem(bool inOut, bool isFluid, int cacheIndex, int indexInCache, uint itemId, int itemAmount, long tms) {} // 0x0000000184099260-0x0000000184099320
		public void SetCacheSize(bool inOut, bool isFluid, int cacheIndex, int sizeCount) {} // 0x00000001840991F0-0x0000000184099260
		public unsafe int CalcIndex(bool inOut, bool isFluid, int cacheIndex, int indexInCache, out FactoryItem* ptr) {
			ptr = default;
			return default;
		} // 0x0000000184099320-0x00000001840993F0
		private void __AOT_FOR_FIX__() {} // 0x000000018794367C-0x00000001879437C0
	}

	public struct CacheTransportFragment : IComponentECS // TypeDefIndex: 49628
	{
		// Fields
		public bool autoTransport; // 0x00
		public bool inUse; // 0x01
		public float currentProgress; // 0x04
		public float totalProgress; // 0x08
		public const int ID = 8; // Metadata: 0x0206104D
	
		// Properties
		public int id { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879437C0-0x00000001879438DC
	}

	public struct CargoFragment : IComponentECS, IUnitConfigRef, IComparable<CargoFragment> // TypeDefIndex: 49630
	{
		// Fields
		public bool serverArrived; // 0x00
		public bool arrived; // 0x01
		public bool enter; // 0x02
		public bool isLiquidItem; // 0x03
		public uint conveyorId; // 0x04
		public float moveSpeed; // 0x08
		public int minDist; // 0x0C
		public int conveyorLength; // 0x10
		public float predictPos; // 0x14
		public float3 position; // 0x18
		public float4 itemUV; // 0x24
		public float4 itemLiquidUV; // 0x34
		public quaternion rotation; // 0x44
		public StringIntern.FastId itemFastId; // 0x54
		public long tms; // 0x58
		public float adjustTms; // 0x60
		public uint conveyorExtHandle; // 0x64
		public int cargoIndex; // 0x68
		public int indexInRendererList; // 0x6C
		public int unitConfigAssetInstanceId; // 0x70
		public const int ID = 9; // Metadata: 0x0206104E
	
		// Properties
		public string itemId { get => default; set {} } // 0x0000000187943C24-0x0000000187943C2C 0x0000000187943C3C-0x0000000187943C58
		public bool recyclable { get => default; } // 0x0000000187943C2C-0x0000000187943C3C 
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000185FB0690-0x0000000185FB06A0 0x0000000185FB06C0-0x0000000185FB06D0
		public int id { get => default; } // 0x0000000183056920-0x0000000183056930 
	
		// Nested types
		public struct ItemUV // TypeDefIndex: 49629
		{
			// Fields
			public bool isLiquid; // 0x00
			public int4 itemAtlasRect; // 0x04
			public int4 liquidAtlasRect; // 0x14
		}
	
		// Methods
		public float PredictPos(long serverTime) => default; // 0x0000000187943A58-0x0000000187943AE8
		public float PredictPosWithDeltaTime(long deltaTime) => default; // 0x00000001879439E8-0x0000000187943A58
		public int CompareTo(CargoFragment other) => default; // 0x00000001879438DC-0x000000018794399C
		public unsafe bool GetVisible(CargoRendererInfoCollection<CargoRendererInfo>* rendererList) => default; // 0x000000018794399C-0x00000001879439E8
		public static CargoFragment Create(uint unitId, int4 itemAtlasRect, int4 liquidAtlasRect, string itemId, int conveyorSpeed, long tms, int conveyorLength, float minDis, bool isLiquidItem) => default; // 0x00000001818A67F0-0x00000001818A70E0
		private void __AOT_FOR_FIX__() {} // 0x0000000187943AE8-0x0000000187943C24
	}

	public struct CargoRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49631
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 10; // Metadata: 0x0206104F
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x0000000185FB6A00-0x0000000185FB6A10 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187943C58-0x0000000187943D64
	}

	public struct ChapterFragment : IComponentECS // TypeDefIndex: 49632
	{
		// Fields
		public long powerCost; // 0x00
		public long powerGen; // 0x08
		public long powerSaveCurrent; // 0x10
		public long powerSaveMax; // 0x18
		public bool isStopByPower; // 0x20
		public int chapterId; // 0x24
		public long backupLastStartTs; // 0x28
		public long backupLastStopTs; // 0x30
		public bool isBackupPowerInUse; // 0x38
		public BlueprintSlotInfo blueprintSlotInfo; // 0x40
		public const int ID = 11; // Metadata: 0x02061050
	
		// Properties
		public int id { get => default; } // 0x0000000181DDC740-0x0000000181DDC750 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187943D64-0x0000000187943EB0
	}

	public struct CollectorFragment : IComponentECS // TypeDefIndex: 49633
	{
		// Fields
		public long currentProgress; // 0x00
		public uint collectItem; // 0x08
		public const int ID = 12; // Metadata: 0x02061051
	
		// Properties
		public int id { get => default; } // 0x0000000181B75290-0x0000000181B752A0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187943EB0-0x0000000187943FC8
	}

	public struct ConnectionFragment : IComponentECS // TypeDefIndex: 49635
	{
		// Fields
		public ulong connectionId; // 0x00
		public Entity fromEntity; // 0x08
		public long fromNodeEntityId; // 0x08
		public Entity toEntity; // 0x10
		public long toNodeEntityId; // 0x10
		public bool strengthenConnection; // 0x18
		public RendererType rendererType; // 0x19
		public int chapterId; // 0x1A
		public float alpha; // 0x1E
		public const int ID = 13; // Metadata: 0x02061052
	
		// Properties
		public bool valid { get => default; } // 0x0000000184AC4350-0x0000000184AC4470 
		public int id { get => default; } // 0x0000000181B75270-0x0000000181B75280 
	
		// Nested types
		public enum RendererType : byte // TypeDefIndex: 49634
		{
			NORMAL = 0,
			HS = 1
		}
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187944CB0-0x0000000187944DD4
	}

	public struct ConveyorFragment : IComponentECS, ILogisticSample // TypeDefIndex: 49637
	{
		// Fields
		public uint factoryUnitId; // 0x00
		public float speed; // 0x04
		public UnityEngine.Rect bounds; // 0x08
		private int _length_k__BackingField; // 0x18
		public uint startMemoryOffsetHandle; // 0x1C
		public uint endMemoryOffsetHandle; // 0x20
		public const int ID = 14; // Metadata: 0x02061059
	
		// Properties
		public int length { get; private set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public int id { get => default; } // 0x0000000181B70600-0x0000000181B70610 
	
		// Nested types
		public enum ProtoType : byte // TypeDefIndex: 49636
		{
			LEFT = 0,
			MID = 1,
			RIGHT = 2
		}
	
		// Methods
		public void SetInflection(ref GlobalEnv env, ref NativeList<float3> p, ref NativeList<float3> r, ref NativeArray<byte> proto) {} // 0x00000001847938D0-0x0000000184793BD0
		public static void CalcRect(NativeList<float3> posList, ref UnityEngine.Rect b) {} // 0x0000000184793700-0x00000001847938D0
		public bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInConveyor) {
			unitId = default;
			indexInConveyor = default;
			return default;
		} // 0x0000000184162CC0-0x0000000184162F80
		public bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax) => default; // 0x0000000187945248-0x00000001879453D0
		public bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex) => default; // 0x000000018415FEF0-0x00000001841600F0
		public bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets) => default; // 0x000000018794502C-0x0000000187945248
		public void DrawDebug(float groundY = 0f /* Metadata: 0x02061055 */) {} // 0x0000000187944FD8-0x000000018794502C
		private void __AOT_FOR_FIX__() {} // 0x00000001879453D0-0x00000001879454F4
	}

	public interface ILogisticSample // TypeDefIndex: 49638
	{
		// Methods
		bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInLogistic);
		bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax);
		bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex);
		bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets);
	}

	public struct ConveyorLogisticsUnitFragment : IComponentECS // TypeDefIndex: 49639
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 15; // Metadata: 0x0206105D
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6D20-0x0000000185FB6D30 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187945600-0x000000018794570C
	}

	public struct ConveyorRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49640
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int indexInConveyor; // 0x04
		public HGFactoryEntityTransformData transformData; // 0x08
		public float3 position; // 0x08
		public float scale; // 0x14
		public quaternion rotation; // 0x18
		public const int ID = 16; // Metadata: 0x0206105E
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x0000000181C3DA10-0x0000000181C3DA20 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187945938-0x0000000187945A5C
	}

	public struct LeftFragment : IComponentECS // TypeDefIndex: 49641
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 17; // Metadata: 0x0206105F
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7160-0x0000000185FB7170 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187949D28-0x0000000187949E34
	}

	public struct RightFragment : IComponentECS // TypeDefIndex: 49642
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 18; // Metadata: 0x02061060
	
		// Properties
		public int id { get => default; } // 0x0000000185FB72C0-0x0000000185FB72D0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794C5E4-0x000000018794C6F0
	}

	public struct MidFragment : IComponentECS // TypeDefIndex: 49643
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 19; // Metadata: 0x02061061
	
		// Properties
		public int id { get => default; } // 0x0000000185FB71B0-0x0000000185FB71C0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794A360-0x000000018794A46C
	}

	public struct CullResultFragment : IComponentECS // TypeDefIndex: 49644
	{
		// Fields
		public bool culled; // 0x00
		public const int ID = 22; // Metadata: 0x02061062
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6D50-0x0000000185FB6D60 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187945A5C-0x0000000187945B68
	}

	public struct DebugFragment : IComponentECS // TypeDefIndex: 49645
	{
		// Fields
		public const int ID = 26; // Metadata: 0x02061063
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6D70-0x0000000185FB6D80 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187945D90-0x0000000187945E9C
	}

	public struct EvtDestroyUnit : IReactiveComponent // TypeDefIndex: 49646
	{
		// Fields
		public long targetDestroyTime; // 0x00
		public long checkedTime; // 0x08
		public const int ID = 27; // Metadata: 0x02061064
	
		// Properties
		public bool timeout { get => default; } // 0x000000018479DC00-0x000000018479DC10 
		public int id { get => default; } // 0x0000000185FB6DE0-0x0000000185FB6DF0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794636C-0x0000000187946484
	}

	public struct ShowStateUI : IComponentECS // TypeDefIndex: 49647
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 28; // Metadata: 0x02061065
	
		// Properties
		public int id { get => default; } // 0x0000000185FB72D0-0x0000000185FB72E0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794C7FC-0x000000018794C908
	}

	public struct ShowNameUI : IComponentECS // TypeDefIndex: 49648
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 29; // Metadata: 0x02061066
	
		// Properties
		public int id { get => default; } // 0x0000000181B92E70-0x0000000181B92E80 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794C6F0-0x000000018794C7FC
	}

	public struct HasRenderer : IComponentECS // TypeDefIndex: 49649
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 30; // Metadata: 0x02061067
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6A40-0x0000000185FB6A50 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879497AC-0x00000001879498B8
	}

	public struct EvtUpdatePipeEffect : INotificationComponent // TypeDefIndex: 49650
	{
		// Fields
		public Entity evtEntity; // 0x00
		public const int ID = 31; // Metadata: 0x02061068
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		public int id { get => default; } // 0x0000000183214D00-0x0000000183214D10 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879467C8-0x00000001879468D4
	}

	public struct EvtChangeTemplate : INotificationComponent // TypeDefIndex: 49651
	{
		// Fields
		public bool playBuildEffect; // 0x00
		public float playBuildEffectDuration; // 0x04
		public bool updatePedestal; // 0x08
		public bool updateBuilding; // 0x09
		public FixedString32Bytes newTemplate; // 0x0A
		public FixedString32Bytes newLogisticPedestalTemplate; // 0x2A
		public FixedString32Bytes newNonLogisticPedestalTemplate; // 0x4A
		public Entity evtEntity; // 0x6C
		public const int ID = 32; // Metadata: 0x02061069
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x0000000185FB6D90-0x0000000185FB6DA0 0x0000000185FB6DB0-0x0000000185FB6DC0
		public int id { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794600C-0x0000000187946148
	}

	public struct EvtCreateUnitRenderer : INotificationComponent // TypeDefIndex: 49652
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public const int ID = 33; // Metadata: 0x0206106A
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		public int id { get => default; } // 0x00000001832DE760-0x00000001832DE770 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187946260-0x000000018794636C
	}

	public struct EvtUpdateStatusEffect : INotificationComponent // TypeDefIndex: 49653
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public const int ID = 34; // Metadata: 0x0206106B
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		public int id { get => default; } // 0x0000000185FB6E30-0x0000000185FB6E40 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879469EC-0x0000000187946AF8
	}

	public struct EvtPendingCreateRenderer : INotificationComponent // TypeDefIndex: 49654
	{
		// Fields
		public Entity evtEntity; // 0x00
		public const int ID = 35; // Metadata: 0x0206106C
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		public int id { get => default; } // 0x0000000185FB6DF0-0x0000000185FB6E00 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187946484-0x0000000187946590
	}

	public struct EvtUpdateRendererProperty : INotificationComponent // TypeDefIndex: 49655
	{
		// Fields
		public bool evtColliderToggle; // 0x00
		public bool colliderToggle; // 0x01
		public bool evtVisible; // 0x02
		public bool visible; // 0x03
		public bool additiveVisible; // 0x04
		public Entity evtEntity; // 0x08
		public const int ID = 36; // Metadata: 0x0206106D
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x0000000185FB6DD0-0x0000000185FB6DE0
		public int id { get => default; } // 0x0000000185FB6E20-0x0000000185FB6E30 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879468D4-0x00000001879469EC
	}

	public struct EvtStatusChange : INotificationComponent // TypeDefIndex: 49656
	{
		// Fields
		public bool forceUpdate; // 0x00
		public Entity evtEntity; // 0x04
		public const int ID = 37; // Metadata: 0x0206106E
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x000000018357A270-0x000000018357A280 0x0000000185FB6E10-0x0000000185FB6E20
		public int id { get => default; } // 0x0000000185FB6E00-0x0000000185FB6E10 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187946590-0x00000001879466AC
	}

	public struct EvtCreateInteract : INotificationComponent // TypeDefIndex: 49657
	{
		// Fields
		public ulong interactObjectId; // 0x00
		public Entity evtEntity; // 0x08
		public ulong evtEntityId; // 0x08
		public const int ID = 38; // Metadata: 0x0206106F
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x0000000185FB6DD0-0x0000000185FB6DE0
		public int id { get => default; } // 0x0000000185FB6DC0-0x0000000185FB6DD0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187946148-0x0000000187946260
	}

	public struct EvtVatUpdate : INotificationComponent // TypeDefIndex: 49658
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public byte placeHolder; // 0x08
		public const int ID = 39; // Metadata: 0x02061070
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		public int id { get => default; } // 0x0000000181BA5810-0x0000000181BA5820 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187946AF8-0x0000000187946C10
	}

	public struct EvtUpdatePedestalColorLUT : INotificationComponent // TypeDefIndex: 49659
	{
		// Fields
		public bool light; // 0x00
		public Entity evtEntity; // 0x04
		public const int ID = 40; // Metadata: 0x02061071
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x000000018357A270-0x000000018357A280 0x0000000185FB6E10-0x0000000185FB6E20
		public int id { get => default; } // 0x0000000185FB6A10-0x0000000185FB6A20 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879466AC-0x00000001879467C8
	}

	public enum EvtAudioType : short // TypeDefIndex: 49660
	{
		BUILDING_STATUS = 1,
		BUILDING_DESTROY = 2
	}

	public enum AudioCullingState : byte // TypeDefIndex: 49661
	{
		AUDIBLE = 1,
		PENDING_CULL = 2,
		CULLED = 4,
		CULLED_CUR_FRAME = 6,
		PENDING_RESTORE = 8,
		AUDIBLE_CUR_FRAME = 9
	}

	public enum AudioDebugGizmosType : byte // TypeDefIndex: 49662
	{
		NONE = 0,
		GROUP_EMITTER_AREA1 = 1,
		GROUP_EMITTER_AREA2 = 2,
		GROUP_EMITTER_AREA3 = 3,
		GROUP_EMITTER_OUT_OF_RANGE = 4,
		GROUP_EMITTER_NOT_CONSIDERED_TYPE = 5,
		GROUP_EMITTER_NOT_CONSIDERED_STATUS = 6
	}

	public struct EvtAudio : INotificationComponent // TypeDefIndex: 49663
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public EvtAudioType evtType; // 0x08
		public const int ID = 41; // Metadata: 0x02061083
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		public int id { get => default; } // 0x0000000185FB6D80-0x0000000185FB6D90 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187945EF4-0x000000018794600C
	}

	public struct AudioFragment : IComponentECS // TypeDefIndex: 49664
	{
		// Fields
		public uint audioFragmentId; // 0x00
		public float distSqToListener; // 0x04
		public AudioCullingState cullingState; // 0x08
		public const int ID = 42; // Metadata: 0x02061084
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6CE0-0x0000000185FB6CF0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879429A0-0x0000000187942ABC
	}

	public struct ReleaseTagFragment : IComponentECS // TypeDefIndex: 49665
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 43; // Metadata: 0x02061085
	
		// Properties
		public int id { get => default; } // 0x0000000185FB72B0-0x0000000185FB72C0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794C4D8-0x000000018794C5E4
	}

	public struct CurMapUnitTag : IComponentECS // TypeDefIndex: 49666
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 45; // Metadata: 0x02061086
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6D60-0x0000000185FB6D70 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187945B68-0x0000000187945C74
	}

	public struct StaticMountOffset // TypeDefIndex: 49667
	{
		// Fields
		public bool outputPosValid; // 0x00
		public float4x4 outputPos; // 0x04
		public bool nameUIPosValid; // 0x44
		public float4x4 nameUIPos; // 0x48
		public bool4 statusPosValid; // 0x88
		public float4x4 statusPos0; // 0x8C
		public float4x4 statusPos1; // 0xCC
		public float4x4 statusPos2; // 0x10C
		public float4x4 statusPos3; // 0x14C
	}

	public struct UnitFragment : IComponentECS // TypeDefIndex: 49668
	{
		// Fields
		public uint nodeId; // 0x00
		public int level; // 0x04
		public int nodeType; // 0x08
		public bool inPower; // 0x0C
		public long powerCost; // 0x10
		public bool inBlock; // 0x18
		public bool isActive; // 0x19
		public bool2 buildDismissEffectEnabled; // 0x1A
		public uint flag; // 0x1C
		public bool formulaManMode; // 0x20
		public int rvoObstacleId; // 0x24
		public int navObstacleId; // 0x28
		public int navSourceId; // 0x2C
		public int nameInstanceId; // 0x30
		public StringIntern.FastId templateIdFastString; // 0x34
		public StringIntern.FastId rendererTemplateIdFastString; // 0x38
		public StringIntern.FastId logisticBaseRendererTemplateIdFastString; // 0x3C
		public StringIntern.FastId nonLogisticBaseRendererTemplateIdFastString; // 0x40
		public StringIntern.FastId instKeyFastString; // 0x44
		public StaticMountOffset staticMountOffset; // 0x48
		public const int ID = 46; // Metadata: 0x02061097
	
		// Properties
		public bool needRepair { get => default; } // 0x000000018794CC70-0x000000018794CC78 
		public bool battleBroken { get => default; } // 0x000000018794CC68-0x000000018794CC70 
		public bool socialUnit { get => default; } // 0x0000000184160320-0x0000000184160330 
		public string templateId { get => default; set {} } // 0x000000018646F850-0x000000018646F858 0x000000018646FF08-0x000000018646FF24
		public string rendererTemplateId { get => default; set {} } // 0x000000018646F848-0x000000018646F850 0x000000018646F82C-0x000000018646F848
		public string logisticBaseRendererTemplateId { get => default; set {} } // 0x000000018646F7BC-0x000000018646F7C4 0x000000018646F7CC-0x000000018646F7E8
		public string nonLogisticBaseRendererTemplateId { get => default; set {} } // 0x000000018646F7C4-0x000000018646F7CC 0x000000018646F7E8-0x000000018646F810
		public string instKey { get => default; set {} } // 0x0000000186470170-0x0000000186470178 0x000000018646FF24-0x000000018646FF40
		public FCNodeMode formulaType { get => default; } // 0x0000000184643F50-0x0000000184643FC0 
		public int id { get => default; } // 0x0000000185FB72F0-0x0000000185FB7300 
	
		// Methods
		public static UnitFragment Create(uint nodeId, string templateId, int nodeType, bool2 buildDismissEnabled, int level = 0 /* Metadata: 0x02061087 */, uint nodeFlag = 0 /* Metadata: 0x02061088 */, string rendererTemplateId = "" /* Metadata: 0x02061089 */, bool inBlock = false /* Metadata: 0x0206108A */, bool inPower = false /* Metadata: 0x0206108B */, bool inActive = true /* Metadata: 0x0206108C */, long powerCost = 0 /* Metadata: 0x0206108D */, bool formulaManMode = false /* Metadata: 0x02061095 */, string instKey = "" /* Metadata: 0x02061096 */) => default; // 0x0000000184794EA0-0x0000000184795060
		private void __AOT_FOR_FIX__() {} // 0x000000018794CB24-0x000000018794CC68
	}

	public struct UnitRenderPipeLogisticsFigureReplaceFragment : IComponentECS // TypeDefIndex: 49669
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 47; // Metadata: 0x02061098
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7330-0x0000000185FB7340 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794DCE8-0x000000018794DDF4
	}

	public struct BusRenderFragment : IComponentECS // TypeDefIndex: 49670
	{
		// Fields
		public int idx; // 0x00
		public const int ID = 48; // Metadata: 0x02061099
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6CF0-0x0000000185FB6D00 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794345C-0x0000000187943568
	}

	public struct UnitRenderBuildingFragment : IComponentECS // TypeDefIndex: 49671
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 49; // Metadata: 0x0206109A
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7320-0x0000000185FB7330 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794DAD0-0x000000018794DBDC
	}

	public struct UnitRenderPedestalFragment : IComponentECS // TypeDefIndex: 49672
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 50; // Metadata: 0x0206109B
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6A30-0x0000000185FB6A40 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794DBDC-0x000000018794DCE8
	}

	public struct UnitRendererRegularFragment : IComponentECS // TypeDefIndex: 49673
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 51; // Metadata: 0x0206109C
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7340-0x0000000185FB7350 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794DDF4-0x000000018794DF00
	}

	public struct UnitOnlyRendererFragment : IComponentECS // TypeDefIndex: 49674
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 52; // Metadata: 0x0206109D
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7300-0x0000000185FB7310 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794CC78-0x000000018794CD84
	}

	public struct FakeUnitFragment : IComponentECS // TypeDefIndex: 49675
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 53; // Metadata: 0x0206109E
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6E40-0x0000000185FB6E50 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187946C10-0x0000000187946D1C
	}

	public struct UIUnitFragment : IComponentECS // TypeDefIndex: 49676
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 54; // Metadata: 0x0206109F
	
		// Properties
		public int id { get => default; } // 0x0000000185FB72E0-0x0000000185FB72F0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794CA18-0x000000018794CB24
	}

	public struct GuideHintFragment : IComponentECS // TypeDefIndex: 49677
	{
		// Fields
		public int hashKey; // 0x00
		public const int ID = 55; // Metadata: 0x020610A0
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7130-0x0000000185FB7140 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879496A0-0x00000001879497AC
	}

	public struct UnitPreviewFragment : IComponentECS // TypeDefIndex: 49680
	{
		// Fields
		public int templateIdFastId; // 0x00
		public int previewRendererTemplateIdFastId; // 0x04
		public int logisticPedestalRendererTemplateIdFastId; // 0x08
		public int nonLogisticPedestalRendererTemplateIdFastId; // 0x0C
		public bool formulaManMode; // 0x10
		public int nodeType; // 0x14
		public EntityTarget entityTarget; // 0x18
		public EntityType entityType; // 0x1C
		public const int ID = 56; // Metadata: 0x020610A1
	
		// Properties
		public string templateId { get => default; set {} } // 0x000000018794D7C4-0x000000018794DAD0 0x0000000184AE2630-0x0000000184AE2B80
		public string previewRendererTemplateId { get => default; set {} } // 0x000000018794D4B8-0x000000018794D7C4 0x0000000184AE2B80-0x0000000184AE30D0
		public string logisticPedestalRendererTemplateId { get => default; set {} } // 0x000000018794CEA0-0x000000018794D1AC 0x0000000184AE30D0-0x0000000184AE3620
		public string nonLogisticPedestalRendererTemplateId { get => default; set {} } // 0x000000018794D1AC-0x000000018794D4B8 0x0000000184AE3620-0x0000000184AE3B70
		public int id { get => default; } // 0x0000000185FB7310-0x0000000185FB7320 
	
		// Nested types
		public enum EntityTarget // TypeDefIndex: 49678
		{
			BUILDING = 0,
			PEDESTAL_LOGISTIC = 1,
			PEDESTAL_NO_LOGISTIC = 2
		}
	
		public enum EntityType // TypeDefIndex: 49679
		{
			NORMAL = 0,
			BLUEPRINT = 1
		}
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794CD84-0x000000018794CEA0
	}

	public struct ConveyorRegularFragment : IComponentECS // TypeDefIndex: 49681
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 57; // Metadata: 0x020610A7
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6D40-0x0000000185FB6D50 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794582C-0x0000000187945938
	}

	public struct ConveyorGuideFragment : IComponentECS // TypeDefIndex: 49682
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 58; // Metadata: 0x020610A8
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6D10-0x0000000185FB6D20 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879454F4-0x0000000187945600
	}

	public struct PipeRegularFragment : IComponentECS // TypeDefIndex: 49683
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 59; // Metadata: 0x020610A9
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7280-0x0000000185FB7290 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794BF30-0x000000018794C03C
	}

	public struct ConveyorPreviewRendererFragment : IComponentECS // TypeDefIndex: 49684
	{
		// Fields
		public bool valid; // 0x00
		public UnitPreviewFragment.EntityType entityType; // 0x04
		public int length; // 0x08
		public uint startMemoryOffsetHandle; // 0x0C
		public uint endMemoryOffsetHandle; // 0x10
		public const int ID = 60; // Metadata: 0x020610AA
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6D30-0x0000000185FB6D40 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794570C-0x000000018794582C
	}

	public struct PipePreviewRendererFragment : IComponentECS // TypeDefIndex: 49685
	{
		// Fields
		public bool valid; // 0x00
		public float pipeHeight; // 0x04
		public float gridPathHeightStart; // 0x08
		public float gridPathHeightEnd; // 0x0C
		public int length; // 0x10
		public uint startMemoryOffsetHandle; // 0x14
		public uint endMemoryOffsetHandle; // 0x18
		public bool trackValid; // 0x1C
		public const int ID = 61; // Metadata: 0x020610AB
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7270-0x0000000185FB7280 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794BE14-0x000000018794BF30
	}

	public struct PipePreviewFragment : IComponentECS // TypeDefIndex: 49686
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 62; // Metadata: 0x020610AC
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7260-0x0000000185FB7270 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794BD08-0x000000018794BE14
	}

	public struct FigureRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49687
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 63; // Metadata: 0x020610AD
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x0000000185FB6E50-0x0000000185FB6E60 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187946D1C-0x0000000187946E38
	}

	public struct FigureRenderLeftFragment : IComponentECS // TypeDefIndex: 49688
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 64; // Metadata: 0x020610AE
	
		// Properties
		public int id { get => default; } // 0x0000000181C44E80-0x0000000181C44E90 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187946E38-0x0000000187946F44
	}

	public struct FigureRenderRightFragment : IComponentECS // TypeDefIndex: 49689
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 65; // Metadata: 0x020610B0
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6E80-0x0000000185FB6E90 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794715C-0x0000000187947268
	}

	public struct FigureRenderMidFragment : IComponentECS // TypeDefIndex: 49690
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 66; // Metadata: 0x020610B2
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6E60-0x0000000185FB6E70 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187946F44-0x0000000187947050
	}

	public struct FigureRenderPipeHolderFragment : IComponentECS // TypeDefIndex: 49691
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 67; // Metadata: 0x020610B4
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6E70-0x0000000185FB6E80 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187947050-0x000000018794715C
	}

	public struct FluidConsumeFragment : IComponentECS // TypeDefIndex: 49692
	{
		// Fields
		public long progress; // 0x00
		public const int ID = 68; // Metadata: 0x020610B6
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6E90-0x0000000185FB6EA0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879472C0-0x00000001879473CC
	}

	public struct FluidContainerFragment : IComponentECS // TypeDefIndex: 49693
	{
		// Fields
		public int4x2 itemId; // 0x00
		public int itemId0; // 0x00
		public int itemId1; // 0x04
		public int itemId2; // 0x08
		public int itemId3; // 0x0C
		public int itemId4; // 0x10
		public int itemId5; // 0x14
		public int itemId6; // 0x18
		public int itemId7; // 0x1C
		public int4x2 itemAmount; // 0x20
		public int4 itemAmount_0; // 0x20
		public int4 itemAmount_1; // 0x30
		public int itemAmount0; // 0x20
		public int itemAmount1; // 0x24
		public int itemAmount2; // 0x28
		public int itemAmount3; // 0x2C
		public int itemAmount4; // 0x30
		public int itemAmount5; // 0x34
		public int itemAmount6; // 0x38
		public int itemAmount7; // 0x3C
		public float4x2 renderItemAmount; // 0x40
		public float4 renderItemAmount_0; // 0x40
		public float4 renderItemAmount_1; // 0x50
		public float renderItemAmount0; // 0x40
		public float renderItemAmount1; // 0x44
		public float renderItemAmount2; // 0x48
		public float renderItemAmount3; // 0x4C
		public float renderItemAmount4; // 0x50
		public float renderItemAmount5; // 0x54
		public float renderItemAmount6; // 0x58
		public float renderItemAmount7; // 0x5C
		public int itemSubType0; // 0x60
		public int itemSubType1; // 0x64
		public int itemSubType2; // 0x68
		public int itemSubType3; // 0x6C
		public int itemSubType4; // 0x70
		public int itemSubType5; // 0x74
		public int itemSubType6; // 0x78
		public int itemSubType7; // 0x7C
		public float4x2 capacity; // 0x80
		public int capacity0; // 0x80
		public int capacity1; // 0x84
		public int capacity2; // 0x88
		public int capacity3; // 0x8C
		public int capacity4; // 0x90
		public int capacity5; // 0x94
		public int capacity6; // 0x98
		public int capacity7; // 0x9C
		public const int ID = 69; // Metadata: 0x020610B8
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6EA0-0x0000000185FB6EB0 
	
		// Methods
		public void Set(int index, int itemId, int itemAmount, int itemSubType) {} // 0x0000000184A2AF40-0x0000000184A2AFA0
		public void SetCapacity(int index, int cap) {} // 0x0000000184A2AFA0-0x0000000184A2AFF0
		public void SetAmount(int index, int amount) {} // 0x000000018794799C-0x0000000187947A10
		public bool Get(int index, out int itemId, out int itemAmount, out float renderItemAmount, out int itemSubType, out int cap) {
			itemId = default;
			itemAmount = default;
			renderItemAmount = default;
			itemSubType = default;
			cap = default;
			return default;
		} // 0x00000001849AFA00-0x00000001849AFA90
		public bool HasLiquid() => default; // 0x0000000187947934-0x000000018794799C
		public void CalcRenderItemAmount(float step) {} // 0x00000001879473CC-0x00000001879477B4
		public ValueTuple<int, uint> GetOffsetData() => default; // 0x00000001879477B4-0x0000000187947934
		public void Reset() {} // 0x0000000185D535A0-0x0000000185D53620
		public override string ToString() => default; // 0x0000000187947A10-0x00000001879483E4
		private void __AOT_FOR_FIX__() {} // 0x000000018794848C-0x00000001879485CC
		public string __iFixBaseProxy_ToString() => default; // 0x00000001879483E4-0x000000018794848C
	}

	public struct FluidPumpInFragment : IComponentECS // TypeDefIndex: 49694
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 70; // Metadata: 0x020610BA
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6EB0-0x0000000185FB6EC0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879485CC-0x00000001879486D8
	}

	public struct FluidPumpOutFragment : IComponentECS // TypeDefIndex: 49695
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 71; // Metadata: 0x020610BC
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6EC0-0x0000000185FB6ED0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879486D8-0x00000001879487E4
	}

	public struct FluidReactionFragment : IComponentECS // TypeDefIndex: 49696
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 72; // Metadata: 0x020610BE
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6ED0-0x0000000185FB6EE0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879487E4-0x00000001879488F0
	}

	public struct FluidSprayFragment : IComponentECS // TypeDefIndex: 49697
	{
		// Fields
		public long progress; // 0x00
		public const int ID = 73; // Metadata: 0x020610C0
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6EE0-0x0000000185FB6EF0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879488F0-0x00000001879489FC
	}

	public struct FormulaManualFragment : IComponentECS // TypeDefIndex: 49698
	{
		// Fields
		public int currentGroup; // 0x00
		public int currentMode; // 0x04
		public int lockedFormulaId; // 0x08
		public const int ID = 74; // Metadata: 0x020610C2
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6EF0-0x0000000185FB6F00 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879489FC-0x0000000187948B18
	}

	public struct EvtLogisticFigureRenderer // TypeDefIndex: 49699
	{
		// Fields
		public bool triggered; // 0x00
		public int figureType; // 0x04
		public static readonly byte S_NONE; // 0x00
		public static readonly byte S_PIPE; // 0x01
		public static readonly byte S_CONVEYOR; // 0x02
		public static readonly byte S_CONVEYOR_GUIDE; // 0x03
	
		// Constructors
		static EvtLogisticFigureRenderer() {
			S_NONE = default;
			S_PIPE = default;
			S_CONVEYOR = default;
			S_CONVEYOR_GUIDE = default;
		} // 0x0000000185F64FD0-0x0000000185F65040
	}

	public struct OutOfBufferWarning // TypeDefIndex: 49700
	{
		// Fields
		public bool pipe; // 0x00
		public bool wire; // 0x01
		public bool conveyor; // 0x02
		public bool cargo; // 0x03
		public bool operated; // 0x04
	
		// Methods
		public void ResetFlags() {} // 0x0000000185D65E30-0x0000000185D65E60
		public override string ToString() => default; // 0x000000018794A46C-0x000000018794A638
		public string __iFixBaseProxy_ToString() => default; // 0x000000018794A638-0x000000018794A68C
	}

	public enum FacSystemTickSkipSource : byte // TypeDefIndex: 49701
	{
		NONE = 0,
		MAP = 1,
		UI = 2,
		GM = 128,
		ALL = 255
	}

	public struct GlobalEnv : IComponentECS // TypeDefIndex: 49702
	{
		// Fields
		public OutOfBufferWarning outOfBufferWarning; // 0x00
		public bool teardown; // 0x05
		public bool isSquadInFight; // 0x06
		public bool isTowerDefence; // 0x07
		public FacSystemTickSkipSource facSystemTickSkip; // 0x08
		public byte facSystemMapSkipGraceFramesRemaining; // 0x09
		public byte facSystemUISkipGraceFramesRemaining; // 0x0A
		public float3 playerPosition; // 0x0C
		public float3 playerForward; // 0x18
		public float3 playerRight; // 0x24
		public float3 cameraPosition; // 0x30
		public Entity currentScopeEntity; // 0x3C
		public EntityQueryV2.QueryResultDefer unitPreviewQueryResult; // 0x48
		public EntityQueryV2.QueryResultDefer cargoPredictQueryResult; // 0x60
		public EntityQueryV2.QueryResultDefer lookAtQueryResult; // 0x78
		public EntityQueryV2.QueryResultDefer pipeThicknessQueryResult; // 0x90
		public EntityQueryV2.QueryResultDefer l2wQueryResult; // 0xA8
		public EntityQueryV2.QueryResultDefer unitRendererQueryResult; // 0xC0
		public EntityQueryV2.QueryResultDefer liquidRendererQueryResult; // 0xD8
		public EntityQueryV2.QueryResultDefer pumpRendererQueryResult; // 0xF0
		public EntityQueryV2.QueryResultDefer additiveEffectQueryResult; // 0x108
		public EntityQueryV2.QueryResultDefer hintEffectQueryResult; // 0x120
		public EntityQueryV2.QueryResultDefer additiveEffectRendererQueryResult; // 0x138
		public JobHandle baseTickChainJobHandle; // 0x150
		public JobHandle crossFrameJobHandle; // 0x160
		public JobHandle cullingJobHandle; // 0x170
		public JobHandle l2wJobHandle; // 0x180
		public JobHandle cargoPredictJobHandle; // 0x190
		public JobHandle cargoRenderJobHandle; // 0x1A0
		public JobHandle lookAtJobHandle; // 0x1B0
		public JobHandle conveyorFigureRenderJobHandle; // 0x1C0
		public JobHandle portArrowRenderJobHandle; // 0x1D0
		public JobHandle portConveyorInsideRenderJobHandle; // 0x1E0
		public long anyTransChangedFrame; // 0x1F0
		public bool evtLevelLoadStatus; // 0x1F8
		public bool evtTopViewChanged; // 0x1F9
		public bool evtPipeDirty; // 0x1FA
		public bool evtOutputDirty; // 0x1FB
		public bool evtForceUpdatePreviewPortRenderer; // 0x1FC
		public bool firstEnterGameScene; // 0x1FD
		public EvtLogisticFigureRenderer evtLogisticFigureRenderer; // 0x200
		public bool systemUnlockedPipe; // 0x208
		public bool systemUnlockedConveyor; // 0x209
		public bool useDistanceFilter; // 0x20A
		public float2 distanceFilterCenterPos; // 0x20C
		public float distanceThreshold; // 0x214
		public float4x4 arrowUV; // 0x218
		public float2 arrowOffset; // 0x258
		public float conveyorOffsetY; // 0x260
		public bool UIBuildingAnimationEnabled; // 0x264
		public bool vatEnableEnvDirty; // 0x265
		public bool buildingNameInvalid; // 0x266
		public bool topViewEnable; // 0x267
		public bool showOutputUI; // 0x268
		public bool inBuildMode; // 0x269
		public bool buildConveyor; // 0x26A
		public bool buildPipe; // 0x26B
		public bool simpleConveyor; // 0x26C
		public bool simplePipe; // 0x26D
		public bool inputDisable; // 0x26E
		public bool outputDisable; // 0x26F
		public bool inputFluidDisable; // 0x270
		public bool outputFluidDisable; // 0x271
		public unsafe InteractFacCollectJob.BuildingInfoWrap* interactBuilding; // 0x278
		public unsafe InteractFacCollectJob.LogisticInfo* conveyorInfo; // 0x280
		public unsafe InteractFacCollectJob.LogisticInfo* pipeInfo; // 0x288
		public unsafe InteractFacCollectJob.BuildingInfoWrap* interactBuildingLast; // 0x290
		public unsafe InteractFacCollectJob.LogisticInfo* conveyorInfoLast; // 0x298
		public unsafe InteractFacCollectJob.LogisticInfo* pipeInfoLast; // 0x2A0
		public unsafe UnsafeList<float4x4>* portBlockPosListPtr; // 0x2A8
		public unsafe UnsafeList<OutputRendererInfo>* outputUIPosListPtr; // 0x2B0
		public unsafe UnsafeList<float4x4>* buildingStatePosListPtr; // 0x2B8
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* cargoMatricesBufferWriter; // 0x2C0
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* cargoMatricesBufferReader; // 0x2C8
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorLPosMatricesBufferWriter; // 0x2D0
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorMPosMatricesBufferWriter; // 0x2D8
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorRPosMatricesBufferWriter; // 0x2E0
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorLPosMatricesBufferReader; // 0x2E8
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorMPosMatricesBufferReader; // 0x2F0
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorRPosMatricesBufferReader; // 0x2F8
		public bool bConflictCheck; // 0x300
		public IntPtr arrowPlacedDicPtr; // 0x308
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* portArrowMatricesWriter; // 0x310
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* portArrowMatricesReader; // 0x318
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewLPosMatricesWriter; // 0x320
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewMPosMatricesWriter; // 0x328
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewRPosMatricesWriter; // 0x330
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewLPosMatricesReader; // 0x338
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewMPosMatricesReader; // 0x340
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewRPosMatricesReader; // 0x348
		public unsafe UnsafeList<float4x4>* conveyorInsideMatricesPtr; // 0x350
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureLPosMatricesBufferWriter; // 0x358
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureMPosMatricesBufferWriter; // 0x360
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureRPosMatricesBufferWriter; // 0x368
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureLPosMatricesBufferReader; // 0x370
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureMPosMatricesBufferReader; // 0x378
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureRPosMatricesBufferReader; // 0x380
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeLPosMatricesBufferWriter; // 0x388
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeMPosMatricesBufferWriter; // 0x390
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeRPosMatricesBufferWriter; // 0x398
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeLPosMatricesBufferReader; // 0x3A0
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeMPosMatricesBufferReader; // 0x3A8
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeRPosMatricesBufferReader; // 0x3B0
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackLPosMatricesBufferWriter; // 0x3B8
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackMPosMatricesBufferWriter; // 0x3C0
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackRPosMatricesBufferWriter; // 0x3C8
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackLPosMatricesBufferReader; // 0x3D0
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackMPosMatricesBufferReader; // 0x3D8
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackRPosMatricesBufferReader; // 0x3E0
		public unsafe UnsafeList<Matrix4x4>* pipeHolderPosMatricesPtr; // 0x3E8
		public unsafe UnsafeList<float4x4>* comPosMatricesPtr; // 0x3F0
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireNormalBufferWriter; // 0x3F8
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsNormalBufferWriter; // 0x400
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireDisableBufferWriter; // 0x408
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenBufferWriter; // 0x410
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsStrengthenBufferWriter; // 0x418
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenDisableBufferWriter; // 0x420
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireNormalBufferReader; // 0x428
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsNormalBufferReader; // 0x430
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireDisableBufferReader; // 0x438
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenBufferReader; // 0x440
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsStrengthenBufferReader; // 0x448
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenDisableBufferReader; // 0x450
		public bool levelShowForceUpdate; // 0x458
		public bool conveyorEffectDirty; // 0x459
		public bool pipeEffectDirty; // 0x45A
		public unsafe ConveyorInfoAllocator* conveyorInfoAllocator; // 0x460
		public unsafe UnsafeList<VATFSMProcessor.SetAnimatorParamRequest>* animatorParamRequestQueue; // 0x468
		public unsafe UnsafeList<VATFSMProcessor.VATFSMAudioData>* animatorAudioQueue; // 0x470
		public const int ID = 76; // Metadata: 0x020610C9
	
		// Properties
		public bool facSystemTickEnabled { get => default; } // 0x00000001850966F0-0x0000000185096780 
		public UnsafeList<float4x4> portBlockPosListReader { get => default; } // 0x0000000184C58EF0-0x0000000184C58F60 
		public UnsafeList<OutputRendererInfo> outputUIPosListReader { get => default; } // 0x000000018538D430-0x000000018538D4A0 
		public UnsafeList<float4x4> buildingStatePosListReader { get => default; } // 0x0000000184C5A1F0-0x0000000184C5A2B0 
		public IntPtr cargoMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB6FD0-0x0000000185FB6FE0 
		public int cargoRendererCount { get => default; } // 0x0000000184825520-0x0000000184825560 
		public bool cargoDirty { get => default; } // 0x0000000184824ED0-0x00000001848250F0 
		public IntPtr conveyorLPosMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB6FE0-0x0000000185FB6FF0 
		public IntPtr conveyorMPosMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB6FF0-0x0000000185FB7000 
		public IntPtr conveyorRPosMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB7020-0x0000000185FB7030 
		public int lConveyorRenderCount { get => default; } // 0x0000000184D39870-0x0000000184D398B0 
		public int mConveyorRenderCount { get => default; } // 0x0000000184D39830-0x0000000184D39870 
		public int rConveyorRenderCount { get => default; } // 0x0000000184D397F0-0x0000000184D39830 
		public bool conveyorDirty { get => default; } // 0x00000001845833D0-0x0000000184583710 
		public IntPtr portArrowMatricesIntPtrReader { get => default; } // 0x0000000185FB70C0-0x0000000185FB70D0 
		public int portArrowRenderCount { get => default; } // 0x0000000184C59A70-0x0000000184C59AB0 
		public bool portArrowDirty { get => default; } // 0x000000018794949C-0x00000001879495EC 
		public IntPtr conveyorPreviewLPosMatricesIntPtrReader { get => default; } // 0x0000000181ACF040-0x0000000181ACF050 
		public IntPtr conveyorPreviewMPosMatricesIntPtrReader { get => default; } // 0x0000000185FB7000-0x0000000185FB7010 
		public IntPtr conveyorPreviewRPosMatricesIntPtrReader { get => default; } // 0x0000000185FB7010-0x0000000185FB7020 
		public int lConveyorPreviewRenderCount { get => default; } // 0x0000000184D397B0-0x0000000184D397F0 
		public int mConveyorPreviewRenderCount { get => default; } // 0x0000000184D39770-0x0000000184D397B0 
		public int rConveyorPreviewRenderCount { get => default; } // 0x0000000184D39730-0x0000000184D39770 
		public UnsafeList<float4x4> conveyorInsideMatricesReader { get => default; } // 0x0000000184C59E90-0x0000000184C59F00 
		public bool previewConveyorDirty { get => default; } // 0x0000000184583710-0x0000000184583A50 
		public IntPtr guideFigureLPosMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB7030-0x0000000185FB7040 
		public IntPtr guideFigureMPosMatricesBufferIntPtrReader { get => default; } // 0x0000000181ACF0A0-0x0000000181ACF0B0 
		public IntPtr guideFigureRPosMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB7040-0x0000000185FB7050 
		public int lGuideFigureRenderCount { get => default; } // 0x0000000184D398B0-0x0000000184D398F0 
		public int mGuideFigureRenderCount { get => default; } // 0x0000000184D398F0-0x0000000184D39930 
		public int rGuideFigureRenderCount { get => default; } // 0x0000000184D39930-0x0000000184D39970 
		public bool guideFigureDirty { get => default; } // 0x0000000184580A50-0x0000000184580E20 
		public IntPtr pipeLPosMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB7060-0x0000000185FB7070 
		public IntPtr pipeMPosMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB7070-0x0000000185FB7080 
		public IntPtr pipeRPosMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB7080-0x0000000185FB7090 
		public int lPipeRenderCount { get => default; } // 0x0000000184D39970-0x0000000184D399B0 
		public int mPipeRenderCount { get => default; } // 0x0000000184D399B0-0x0000000184D399F0 
		public int rPipeRenderCount { get => default; } // 0x0000000184D399F0-0x0000000184D39A30 
		public IntPtr pipeTrackLPosMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB7090-0x0000000185FB70A0 
		public IntPtr pipeTrackMPosMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB70A0-0x0000000185FB70B0 
		public IntPtr pipeTrackRPosMatricesBufferIntPtrReader { get => default; } // 0x0000000185FB70B0-0x0000000185FB70C0 
		public int lPipeTrackRenderCount { get => default; } // 0x000000018531D920-0x000000018531D960 
		public int mPipeTrackRenderCount { get => default; } // 0x000000018531D8E0-0x000000018531D920 
		public int rPipeTrackRenderCount { get => default; } // 0x000000018531D8A0-0x000000018531D8E0 
		public bool pipeDirty { get => default; } // 0x0000000184583A50-0x0000000184583D90 
		public UnsafeList<Matrix4x4> pipeHolderPosMatricesReader { get => default; } // 0x0000000184D39B90-0x0000000184D39C00 
		public UnsafeList<float4x4> comPosMatricesReader { get => default; } // 0x0000000184C5A2B0-0x0000000184C5A3E0 
		public IntPtr wireNormalBufferIntPtrReader { get => default; } // 0x0000000185FB7100-0x0000000185FB7110 
		public IntPtr wireHsNormalBufferIntPtrReader { get => default; } // 0x0000000185FB70E0-0x0000000185FB70F0 
		public IntPtr wireDisableBufferIntPtrReader { get => default; } // 0x0000000185FB70D0-0x0000000185FB70E0 
		public IntPtr wireStrengthenBufferIntPtrReader { get => default; } // 0x0000000185FB7110-0x0000000185FB7120 
		public IntPtr wireHsStrengthenBufferIntPtrReader { get => default; } // 0x0000000185FB70F0-0x0000000185FB7100 
		public IntPtr wireStrengthenDisableBufferIntPtrReader { get => default; } // 0x0000000185FB7120-0x0000000185FB7130 
		public int wireNormalRendererCount { get => default; } // 0x0000000185D6B100-0x0000000185D6B140 
		public int wireHsNormalRendererCount { get => default; } // 0x0000000185D6B140-0x0000000185D6B180 
		public int wireDisableRendererCount { get => default; } // 0x00000001879495EC-0x0000000187949628 
		public int wireStrengthenRendererCount { get => default; } // 0x0000000187949664-0x00000001879496A0 
		public int wireHsStrengthenRendererCount { get => default; } // 0x0000000185AE8FA0-0x0000000185AE8FE0 
		public int wireStrengthenDisableRendererCount { get => default; } // 0x0000000187949628-0x0000000187949664 
		public bool wireNormalDirty { get => default; } // 0x0000000184824CB0-0x0000000184824ED0 
		public bool wireHsNormalDirty { get => default; } // 0x0000000184824A90-0x0000000184824CB0 
		public bool wireDisableDirty { get => default; } // 0x0000000184824870-0x0000000184824A90 
		public bool wireStrengthenDirty { get => default; } // 0x0000000184824650-0x0000000184824870 
		public bool wireHsStrengthenDirty { get => default; } // 0x0000000184824430-0x0000000184824650 
		public bool wireStrengthenDisableDirty { get => default; } // 0x0000000184824210-0x0000000184824430 
		public UnsafeList<VATFSMProcessor.SetAnimatorParamRequest> animatorParamRequestQueueReader { get => default; } // 0x0000000187949400-0x000000018794949C 
		public UnsafeList<VATFSMProcessor.VATFSMAudioData> animatorAudioQueueWriter { get => default; } // 0x00000001843EBEE0-0x00000001843EBF40 
		public int id { get => default; } // 0x0000000185FB7050-0x0000000185FB7060 
	
		// Methods
		public void InitSkipFlag() {} // 0x00000001851D76A0-0x00000001851D76D0
		public void CreateQueryResult() {} // 0x00000001851D4DD0-0x00000001851D4F10
		public void DisposeQueryResult() {} // 0x0000000187948B6C-0x0000000187948C3C
		public void SwapCargoBuffer() {} // 0x0000000187948CA4-0x0000000187948D40
		public unsafe void SetConveyorBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1) {} // 0x0000000185FB6F40-0x0000000185FB6F80
		public void SwapConveyorBuffer() {} // 0x0000000187948D40-0x0000000187948E14
		public unsafe void SetPortArrowBuffers(void* buffer0, void* buffer1) {} // 0x0000000185FB6F80-0x0000000185FB6F90
		public void SwapPortArrowBuffer() {} // 0x0000000187949020-0x00000001879490BC
		public unsafe void SetPreviewConveyorBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1) {} // 0x0000000185FB6F90-0x0000000185FB6FD0
		public void SwapPreviewConveyorBuffer() {} // 0x00000001879490BC-0x0000000187949190
		public unsafe void SeGuideFigureBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1) {} // 0x0000000185FB6F00-0x0000000185FB6F40
		public void SwapGuideFigureBuffer() {} // 0x0000000187948E14-0x0000000187948EE8
		public unsafe void SetPipeBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1, void* trackLBuffer0, void* trackLBuffer1, void* trackMBuffer0, void* trackMBuffer1, void* trackRBuffer0, void* trackRBuffer1) {} // 0x00000001851DE940-0x00000001851DE9D0
		public void SwapPipeBuffer() {} // 0x0000000187948EE8-0x0000000187949020
		public unsafe void SetWireBuffer(void* normal0, void* normal1, void* hsNormal0, void* hsNormal1, void* disable0, void* disable1, void* strengthen0, void* strengthen1, void* hsStrengthen0, void* hsStrengthen1, void* strengthenDisable0, void* strengthenDisable1) {} // 0x00000001851DE8B0-0x00000001851DE940
		public void SwapWireBuffer() {} // 0x0000000187949190-0x00000001879492BC
		public unsafe void GetConveyorRendererInfo(uint memoryStartOffset, int countIdx, out ConveyorInfoAllocator.Info* info) {
			info = default;
		} // 0x0000000184163540-0x0000000184163610
		public ref ConveyorInfoAllocator.Info GetConveyorRendererInfo(uint memoryStartOffset, int countIdx) => ref _refReturnTypeForGetConveyorRendererInfo; // 0x0000000184791F60-0x00000001847920C0
		private ref ConveyorInfoAllocator.Info _refReturnTypeForGetConveyorRendererInfo; // Dummy field
		public LinearAllocator.Allocation AllocateConveyorInfo(int count) => default; // 0x0000000184D622E0-0x0000000184D62360
		public long CalculateConveyorInfoSize(uint memoryOffset) => default; // 0x000000018478FDB0-0x000000018478FDF0
		public LinearAllocator.Allocation ResizeConveyorInfo(uint startIndex, int count) => default; // 0x0000000185B93610-0x0000000185B936C0
		public void FreeConveyorInfo(uint startIndex) {} // 0x0000000187948C3C-0x0000000187948CA4
		public void DebugAllocatorPrint() {} // 0x0000000187948B18-0x0000000187948B6C
		public void AddSetAnimatorParamRequest(Entity logicEntity, VATFSMProcessor.SetAnimatorParamRequest rq) {} // 0x0000000184654690-0x0000000184655270
		private void _AddAnimatorParamRequest(ref EntityManager em, Entity renderEntity, in VATFSMProcessor.SetAnimatorParamRequest rq) {} // 0x0000000184655270-0x0000000184657380
		public ref VATFSMProcessor.VATFSMAudioData GetAudioVATDataAt(int index) => ref _refReturnTypeForGetAudioVATDataAt; // 0x000000018459E770-0x000000018459E7D0
		private ref VATFSMProcessor.VATFSMAudioData _refReturnTypeForGetAudioVATDataAt; // Dummy field
		public int GetAudioVATDataLength() => default; // 0x000000018459E6D0-0x000000018459E720
		public void ClearAudioVATData() {} // 0x000000018459E720-0x000000018459E770
		public void ResetFlags() {} // 0x000000018527C990-0x000000018527C9D0
		private void __AOT_FOR_FIX__() {} // 0x00000001879492BC-0x0000000187949400
	}

	public struct HealthPoleFragment : IComponentECS // TypeDefIndex: 49703
	{
		// Fields
		public long currentProgress; // 0x00
		public int currentPoint; // 0x08
		public const int ID = 77; // Metadata: 0x020610CB
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7140-0x0000000185FB7150 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879498B8-0x00000001879499D0
	}

	public struct InventoryFragment : IComponentECS // TypeDefIndex: 49704
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 78; // Metadata: 0x020610CD
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7150-0x0000000185FB7160 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187949C1C-0x0000000187949D28
	}

	public interface IPositionFragment // TypeDefIndex: 49705
	{
		// Properties
		float3 Position { get; }
	}

	public interface IReactiveComponent : IComponentECS // TypeDefIndex: 49706
	{
	}

	public interface INotificationComponent : IReactiveComponent // TypeDefIndex: 49707
	{
		// Properties
		Entity eventEntity { get; set; }
	}

	public interface IRotateFragment // TypeDefIndex: 49708
	{
		// Properties
		float3 Rotation { get; }
		quaternion RotationQuaternion { get; }
	}

	public interface IUnitConfigRef // TypeDefIndex: 49709
	{
		// Properties
		int unitAssetInstanceId { get; set; }
	}

	public struct LiquidPurifierFragment : IComponentECS // TypeDefIndex: 49710
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 79; // Metadata: 0x020610CF
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7170-0x0000000185FB7180 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187949E34-0x0000000187949F40
	}

	public struct LogisticEffectFragment : IComponentECS // TypeDefIndex: 49711
	{
		// Fields
		public bool4 portStatusBits; // 0x00
		public bool port0; // 0x00
		public bool port1; // 0x01
		public bool port2; // 0x02
		public bool port3; // 0x03
		public bool4 portDirectionBits; // 0x04
		public bool portDirection0; // 0x04
		public bool portDirection1; // 0x05
		public bool portDirection2; // 0x06
		public bool portDirection3; // 0x07
		public bool4 currentPortStatusBits; // 0x08
		public bool currentPort0; // 0x08
		public bool currentPort1; // 0x09
		public bool currentPort2; // 0x0A
		public bool currentPort3; // 0x0B
		public float4 duration; // 0x0C
		public const int ID = 80; // Metadata: 0x020610D1
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7180-0x0000000185FB7190 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187949F40-0x000000018794A060
	}

	public struct LogisticEntityBindFragment : IComponentECS // TypeDefIndex: 49712
	{
		// Fields
		public EntityData256<Entity> cargoEntities; // 0x00
		public uint conveyorExtHandle; // 0x808
		public const int ID = 81; // Metadata: 0x020610D3
	
		// Properties
		public int cargoCount { get => default; } // 0x00000001841CBD00-0x00000001841CBD40 
		public int id { get => default; } // 0x0000000185FB7190-0x0000000185FB71A0 
	
		// Methods
		public void EnqueueCargoEntityImpl(Entity cargoEntity, uint conveyorSharedDataIndex) {} // 0x0000000184796B10-0x0000000184796EC0
		public bool DequeueCargoEntityImpl(out Entity cargoEntity) {
			cargoEntity = default;
			return default;
		} // 0x0000000184796680-0x0000000184796800
		public unsafe void Arrive(ref CargoFragment cargo, ConveyorExtContainer.ConveyorExt* conveyorExtData) {} // 0x000000018794A0D8-0x000000018794A108
		public unsafe void Arrive(Entity cargoEntity, ConveyorExtContainer.ConveyorExt* conveyorExtData) {} // 0x000000018794A060-0x000000018794A0D8
		private void __AOT_FOR_FIX__() {} // 0x000000018794A108-0x000000018794A254
	}

	public struct MapGridRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49713
	{
		// Fields
		private int _unitAssetInstanceId_k__BackingField; // 0x00
		public const int ID = 82; // Metadata: 0x020610D5
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x0000000185FB71A0-0x0000000185FB71B0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794A254-0x000000018794A360
	}

	public struct OutputFragment : IComponentECS // TypeDefIndex: 49714
	{
		// Fields
		public int3 itemAll; // 0x00
		public float4x3 rarityColorAll; // 0x0C
		public float4x3 atlasRectAll; // 0x3C
		public byte enableLiquidIcon; // 0x6C
		public float4x3 liquidAtlasUV; // 0x6D
		public static readonly int MAX_OUTPUT; // 0x00
		public const int ID = 83; // Metadata: 0x020610D7
	
		// Properties
		public int this[int index] { get => default; set {} } // 0x0000000185FB71C0-0x0000000185FB71D0 0x0000000185FB71E0-0x0000000185FB71F0
		public bool hasOutput { get => default; } // 0x000000018794AA6C-0x000000018794AAD0 
		public int id { get => default; } // 0x0000000185FB71D0-0x0000000185FB71E0 
	
		// Constructors
		static OutputFragment() {
			MAX_OUTPUT = default;
		} // 0x0000000185FA43E0-0x0000000185FA4420
	
		// Methods
		public void Clean() {} // 0x00000001849B14B0-0x00000001849B1590
		public ref float4 GetColor(int index) => ref _refReturnTypeForGetColor; // 0x000000018794A6F0-0x000000018794A754
		private ref float4 _refReturnTypeForGetColor; // Dummy field
		public void SetColor(int index, float4 color) {} // 0x000000018794A8A8-0x000000018794A92C
		public void SetColor(int index, UnityEngine.Color color) {} // 0x00000001849B40A0-0x00000001849B40F0
		public void SetAtlasRect(int index, float4 rect) {} // 0x000000018794A824-0x000000018794A8A8
		public void SetAtlasRect(int index, RectInt rect) {} // 0x00000001849B37D0-0x00000001849B38C0
		public ref float4 GetAtlasRect(int index) => ref _refReturnTypeForGetAtlasRect; // 0x000000018794A68C-0x000000018794A6F0
		private ref float4 _refReturnTypeForGetAtlasRect; // Dummy field
		public bool GetEnableLiquidIcon(int index) => default; // 0x000000018794A754-0x000000018794A7C0
		public void SetEnableLiquidIcon(int index, bool enable) {} // 0x00000001849B40F0-0x00000001849B4160
		public ref float4 GetLiquidIconUV(int index) => ref _refReturnTypeForGetLiquidIconUV; // 0x000000018794A7C0-0x000000018794A824
		private ref float4 _refReturnTypeForGetLiquidIconUV; // Dummy field
		public void SetLiquidIconUV(int index, RectInt rect) {} // 0x00000001849B4160-0x00000001849B41F0
		private void __AOT_FOR_FIX__() {} // 0x000000018794A92C-0x000000018794AA6C
	}

	public struct OutputUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49715
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 84; // Metadata: 0x020610D9
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x0000000185FB71F0-0x0000000185FB7200 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794AAD0-0x000000018794ABDC
	}

	public struct PedestalLightFlashFragment : IComponentECS // TypeDefIndex: 49716
	{
		// Fields
		public byte status; // 0x00
		public float intensity; // 0x04
		public float flashIntensity; // 0x08
		public float flashDuration; // 0x0C
		public bool flash; // 0x10
		public int flashSpeed; // 0x14
		public float flashStatusLerpTime; // 0x18
		public float4 color; // 0x1C
		public float4 flashColor; // 0x2C
		public const int ID = 85; // Metadata: 0x020610DB
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7210-0x0000000185FB7220 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794B214-0x000000018794B340
	}

	public struct PedestalLightFlashConfigFragment : IComponentECS // TypeDefIndex: 49721
	{
		// Fields
		public _intensity_e__FixedBuffer intensity; // 0x00
		public _flashIntensity_e__FixedBuffer flashIntensity; // 0x40
		public _flashDuration_e__FixedBuffer flashDuration; // 0x80
		public _flash_e__FixedBuffer flash; // 0xC0
		public Float4Data16<float4> color; // 0xD0
		public Float4Data16<float4> flashColor; // 0x1D8
		public const int ID = 86; // Metadata: 0x020610DD
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7200-0x0000000185FB7210 
	
		// Nested types
		public struct _intensity_e__FixedBuffer // TypeDefIndex: 49717
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		public struct _flashIntensity_e__FixedBuffer // TypeDefIndex: 49718
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		public struct _flashDuration_e__FixedBuffer // TypeDefIndex: 49719
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		public struct _flash_e__FixedBuffer // TypeDefIndex: 49720
		{
			// Fields
			public bool FixedElementField; // 0x00
		}
	
		// Methods
		public bool IsValid() => default; // 0x000000018794B054-0x000000018794B0D0
		public void SetIntensity(int idx, float value) {} // 0x0000000184093D50-0x0000000184093DE0
		public void SetFlashIntensity(int idx, float value) {} // 0x0000000184093CC0-0x0000000184093D50
		public void SetFlash(int idx, bool value) {} // 0x0000000184093DE0-0x0000000184093E80
		public void SetFlashDuration(int idx, float value) {} // 0x0000000184093C30-0x0000000184093CC0
		public void SetColor(int idx, UnityEngine.Color value) {} // 0x0000000184093E80-0x0000000184093FE0
		public void SetFlashColor(int idx, UnityEngine.Color value) {} // 0x0000000184093FE0-0x0000000184094140
		public float GetIntensity(int idx) => default; // 0x000000018794AFF8-0x000000018794B054
		public float GetFlashIntensity(int idx) => default; // 0x000000018794AF3C-0x000000018794AF98
		public bool GetFlash(int idx) => default; // 0x000000018794AF98-0x000000018794AFF8
		public float GetFlashDuration(int idx) => default; // 0x000000018794AEDC-0x000000018794AF3C
		public float4 GetColor(int idx) => default; // 0x000000018794AC8C-0x000000018794ADB4
		public float4 GetFlashColor(int idx) => default; // 0x000000018794ADB4-0x000000018794AEDC
		private void __AOT_FOR_FIX__() {} // 0x000000018794B0D0-0x000000018794B214
	}

	public struct PipeEffectFragment : IComponentECS // TypeDefIndex: 49722
	{
		// Fields
		public IntData32<uint> pipeEffectInstanceId; // 0x00
		public FixedString64Bytes inEffectName; // 0x88
		public FixedString64Bytes outEffectName; // 0xC8
		public FixedString64Bytes inEffectConnectedName; // 0x108
		public FixedString64Bytes outEffectConnectedName; // 0x148
		public const int ID = 87; // Metadata: 0x020610DF
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7230-0x0000000185FB7240 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794B45C-0x000000018794B5A0
	}

	public struct PipeFragment : IComponentECS, ILogisticSample // TypeDefIndex: 49723
	{
		// Fields
		public static readonly float PIPE_HEIGHT; // 0x00
		public uint factoryUnitId; // 0x00
		public bool validMode; // 0x04
		public float pipeHeight; // 0x08
		public float currentWaterThickness; // 0x0C
		public float waterFlowDeltaTime; // 0x10
		public float waterThickness; // 0x14
		public float speed; // 0x18
		public int waterDirection; // 0x1C
		public int subItemType; // 0x20
		public bool entranceConnected; // 0x24
		public bool exitConnected; // 0x25
		public float3 entranceGroundAdjustPos; // 0x28
		public float3 exitGroundAdjustPos; // 0x34
		public float3 entrancePortDirection; // 0x40
		public float3 exitPortDirection; // 0x4C
		public float bend; // 0x58
		public UnityEngine.Rect bounds; // 0x5C
		public uint itemId; // 0x6C
		private int _length_k__BackingField; // 0x70
		public uint startMemoryOffsetHandle; // 0x74
		public uint endMemoryOffsetHandle; // 0x78
		public const int ID = 88; // Metadata: 0x020610EB
	
		// Properties
		public int length { get; private set; } // 0x0000000185FB0690-0x0000000185FB06A0 0x0000000185FB06C0-0x0000000185FB06D0
		public int id { get => default; } // 0x0000000182FB55E0-0x0000000182FB55F0 
	
		// Constructors
		static PipeFragment() {
			PIPE_HEIGHT = default;
		} // 0x0000000185FA42E0-0x0000000185FA4320
	
		// Methods
		public bool SetInflection(ref GlobalEnv env, ref NativeList<float3> p, ref NativeList<float3> r, ref NativeList<byte> proto) => default; // 0x0000000184793250-0x0000000184793700
		public static void Bend(ref GlobalEnv env, int pipeLength, uint startMemoryOffsetHandle, float pipeHeight, bool bOverrideEntranceY = false /* Metadata: 0x020610E1 */, float overrideEntranceY = 0f /* Metadata: 0x020610E2 */, bool bOverrideExitY = false /* Metadata: 0x020610E6 */, float overrideExitY = 0f /* Metadata: 0x020610E7 */) {} // 0x0000000184791DF0-0x0000000184791F60
		public static ValueTuple<int[], int> GetCornerIndexList(ref GlobalEnv env, uint startMemoryOffsetHandle, int length) => default; // 0x0000000184790620-0x0000000184790740
		public bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInPipe) {
			unitId = default;
			indexInPipe = default;
			return default;
		} // 0x00000001841630B0-0x00000001841634B0
		public bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax) => default; // 0x000000018794B7E0-0x000000018794B9A4
		public bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex) => default; // 0x00000001840B4610-0x00000001840B4850
		public bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets) => default; // 0x000000018794B5A0-0x000000018794B7E0
		private void __AOT_FOR_FIX__() {} // 0x000000018794B9A4-0x000000018794BAE0
	}

	public struct PipeHolderFragment : IComponentECS // TypeDefIndex: 49724
	{
		// Fields
		public int indexInPipe; // 0x00
		public Entity pipeEntity; // 0x04
		public const int ID = 89; // Metadata: 0x020610ED
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7240-0x0000000185FB7250 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794BAE0-0x000000018794BBFC
	}

	public struct PipeLogisticsUnitFragment : IComponentECS // TypeDefIndex: 49725
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 90; // Metadata: 0x020610EF
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7250-0x0000000185FB7260 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794BBFC-0x000000018794BD08
	}

	public struct PipeComRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49726
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 91; // Metadata: 0x020610F1
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x0000000185FB7220-0x0000000185FB7230 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794B340-0x000000018794B45C
	}

	public struct PipeRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49727
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int indexInPipe; // 0x04
		public FixedString32Bytes prototype; // 0x08
		public float3 position; // 0x28
		public float scale; // 0x34
		public quaternion rotation; // 0x38
		public HGFactoryEntityTransformData transformData; // 0x28
		public const int ID = 92; // Metadata: 0x020610F3
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x0000000185FB7290-0x0000000185FB72A0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794C03C-0x000000018794C160
	}

	public struct PipeTrackRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49728
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 93; // Metadata: 0x020610F5
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x0000000185FB72A0-0x0000000185FB72B0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018794C160-0x000000018794C27C
	}

	public struct ComplexPortFragment : IComponentECS, IEquatable<ComplexPortFragment> // TypeDefIndex: 49729
	{
		// Fields
		public PortData32<Beyond.Gameplay.Factory.PortData> ports; // 0x00
		public int2 pedestalPortCount; // 0x808
		public int2 pipePortCount; // 0x810
		public bool dataInit; // 0x818
		public const int ID = 94; // Metadata: 0x020610FB
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6D00-0x0000000185FB6D10 
	
		// Methods
		public bool BindComponentId(uint componentId, int idx, bool isInput, bool isBlock, uint touchComId, out bool pipeChanged) {
			pipeChanged = default;
			return default;
		} // 0x00000001845BA790-0x00000001845BAA70
		public bool BlockPortsWithComponentId(uint componentId, bool isBlock, int[] portIndices) => default; // 0x000000018794413C-0x00000001879442BC
		public bool BlockPorts(bool isBlock, List<int> portIndices, bool input) => default; // 0x00000001845BB220-0x00000001845BB3F0
		public void FollowUnit(float3 worldPos, float3 worldDir, ref GlobalSharedData.UnitPortConfig portConfig, ref UnitConfigFragment unitConfig, float effectOffset = 0.5f /* Metadata: 0x020610F7 */) {} // 0x00000001845BAA70-0x00000001845BB220
		public bool AnyPortBlocked() => default; // 0x0000000187943FC8-0x0000000187944084
		public bool AnyPortConnected() => default; // 0x0000000187944084-0x000000018794413C
		public bool Equals(ComplexPortFragment other) => default; // 0x0000000187944378-0x000000018794456C
		public override bool Equals(object obj) => default; // 0x00000001879442BC-0x0000000187944378
		public override int GetHashCode() => default; // 0x000000018794456C-0x0000000187944760
		public static bool operator ==(ComplexPortFragment left, ComplexPortFragment right) => default; // 0x0000000187944B28-0x0000000187944BEC
		public static bool operator !=(ComplexPortFragment left, ComplexPortFragment right) => default; // 0x0000000187944BEC-0x0000000187944CB0
		public override string ToString() => default; // 0x0000000187944760-0x00000001879448A8
		private void __AOT_FOR_FIX__() {} // 0x00000001879449DC-0x0000000187944B28
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x00000001879448A8-0x000000018794491C
		public int __iFixBaseProxy_GetHashCode() => default; // 0x000000018794491C-0x000000018794497C
		public string __iFixBaseProxy_ToString() => default; // 0x000000018794497C-0x00000001879449DC
	}

	public struct PortData : IEquatable<Beyond.Gameplay.Factory.PortData> // TypeDefIndex: 49730
	{
		// Fields
		public byte idx; // 0x00
		public bool isInput; // 0x01
		public bool isPipe; // 0x02
		public bool isBlock; // 0x03
		public bool valid; // 0x04
		public bool evaluated; // 0x05
		public uint touchComId; // 0x08
		public uint bindComId; // 0x0C
		public uint touchNodeId; // 0x10
		public float3 worldPos; // 0x14
		public quaternion worldDir; // 0x20
	
		// Methods
		public float4x4 TRS() => default; // 0x0000000187958B58-0x0000000187958C28
		public bool Equals(PortData other) => default; // 0x0000000187958838-0x0000000187958990
		public override bool Equals(object obj) => default; // 0x0000000187958780-0x0000000187958838
		public override int GetHashCode() => default; // 0x0000000187958990-0x0000000187958B58
		public static bool operator ==(PortData left, PortData right) => default; // 0x000000018795900C-0x00000001879590CC
		public static bool operator !=(PortData left, PortData right) => default; // 0x00000001879590CC-0x0000000187959190
		public override string ToString() => default; // 0x0000000187958C28-0x0000000187958EDC
		public string __iFixBaseProxy_ToString() => default; // 0x0000000187958FAC-0x000000018795900C
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x0000000187958EDC-0x0000000187958F4C
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000187958F4C-0x0000000187958FAC
	}

	public struct PortPreviewUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49731
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 95; // Metadata: 0x020610FD
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x0000000185FB7510-0x0000000185FB7520 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187959190-0x000000018795929C
	}

	public struct PortStatusUIFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49732
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 96; // Metadata: 0x020610FF
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x0000000185FB7520-0x0000000185FB7530 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018795929C-0x00000001879593A8
	}

	public struct PowerPoleFragment : IComponentECS // TypeDefIndex: 49733
	{
		// Fields
		public const int ID = 97; // Metadata: 0x02061101
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7530-0x0000000185FB7540 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879593A8-0x00000001879594B4
	}

	public struct ProducerFragment : IComponentECS // TypeDefIndex: 49734
	{
		// Fields
		public uint componentId; // 0x00
		public long currentProgress; // 0x08
		public uint formulaId; // 0x10
		public uint lastFormulaId; // 0x14
		public const int ID = 98; // Metadata: 0x02061103
	
		// Properties
		public uint outputFormulaId { get => default; } // 0x000000018555E130-0x000000018555E140 
		public int id { get => default; } // 0x0000000185FB7540-0x0000000185FB7550 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879594B4-0x00000001879595D4
	}

	public struct SharedDataFragment : IComponentECS // TypeDefIndex: 49735
	{
		// Fields
		public uint dataHandle; // 0x00
		public const int ID = 99; // Metadata: 0x02061105
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7560-0x0000000185FB7570 
	
		// Methods
		public ref SharedDataContainer.SharedExtData GetExtData() => ref _refReturnTypeForGetExtData; // 0x0000000184164ED0-0x0000000184165030
		private ref SharedDataContainer.SharedExtData _refReturnTypeForGetExtData; // Dummy field
		public void DestroyData() {} // 0x000000018479D630-0x000000018479D670
		private void __AOT_FOR_FIX__() {} // 0x000000018795A1B0-0x000000018795A2BC
	}

	public enum SocialBuildingStates : uint // TypeDefIndex: 49736
	{
		Invalid = 0,
		Disable = 1,
		Unlocked = 2,
		Activated = 3,
		Locked = 4
	}

	public struct SocialFragment : IComponentECS // TypeDefIndex: 49738
	{
		// Fields
		public uint socialState; // 0x00
		public ulong ownerId; // 0x04
		public uint socialNodeId; // 0x0C
		public ulong like; // 0x10
		public long lastSetLikeTs; // 0x18
		public long expirationTs; // 0x20
		public SignData signData; // 0x28
		public bool isPreset; // 0x34
		public const int ID = 100; // Metadata: 0x0206110C
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7570-0x0000000185FB7580 
	
		// Nested types
		public enum EOwner // TypeDefIndex: 49737
		{
			MINE = 1,
			OTHERS = 2,
			ALL = 3
		}
	
		// Methods
		public static SocialFragment Create(ulong ownerId, uint socialNodeId, ulong like, long lastSetLikeTs, long expirationTs, uint socialState, bool isPreset) => default; // 0x000000018479F5F0-0x000000018479F6D0
		public bool IsHighLiked() => default; // 0x0000000184CBDFB0-0x0000000184CBE0A0
		public bool IsLiked() => default; // 0x000000018795A454-0x000000018795A4D0
		private void __AOT_FOR_FIX__() {} // 0x000000018795A4D0-0x000000018795A5F8
	}

	public struct SignData // TypeDefIndex: 49739
	{
		// Fields
		public uint3 content; // 0x00
		public const int CONTENT_LENGTH = 3; // Metadata: 0x02061111
	
		// Methods
		public string GetText() => default; // 0x000000018795A2BC-0x000000018795A454
		public static float GetCustomPerDrawData(FactoryUIAtlasSOData config, uint3 content) => default; // 0x0000000184CBFBB0-0x0000000184CBFD90
		public static void SetSignBuildingIcon(FactoryUIAtlasSOData data, ref EntityManager em, Entity logicEntity) {} // 0x0000000184CBF410-0x0000000184CBF690
		public static void SetSignBuildingIconWithRenderEntity(FactoryUIAtlasSOData config, Entity rEntity, uint3 iconId) {} // 0x0000000184CBF690-0x0000000184CBFBB0
	}

	[Serializable]
	public struct LocalTransform : IComponentECS // TypeDefIndex: 49740
	{
		// Fields
		public float3 position; // 0x00
		public float scale; // 0x0C
		public quaternion rotation; // 0x10
		public HGFactoryEntityTransformData entityTransformData; // 0x00
		public static readonly LocalTransform Identity; // 0x00
		public const int ID = 101; // Metadata: 0x02061112
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7430-0x0000000185FB7440 
	
		// Constructors
		static LocalTransform() {
			Identity = default;
		} // 0x0000000185F14050-0x0000000185F140F0
	
		// Methods
		public static LocalTransform FromMatrix(float4x4 matrix) => default; // 0x0000000187956758-0x0000000187956A04
		public static LocalTransform FromMatrixSafe(float4x4 matrix) => default; // 0x00000001879561F4-0x0000000187956758
		public static LocalTransform FromPositionRotation(float3 position, quaternion rotation) => default; // 0x0000000187956A04-0x0000000187956AD0
		public static LocalTransform FromPositionRotationScale(float3 position, quaternion rotation, float scale) => default; // 0x0000000184094140-0x00000001840941D0
		public static LocalTransform FromPosition(float3 position) => default; // 0x0000000187956BB8-0x0000000187956C88
		public static LocalTransform FromPosition(float x, float y, float z) => default; // 0x0000000187956AD0-0x0000000187956BB8
		public static LocalTransform FromRotation(quaternion rotation) => default; // 0x0000000187956C88-0x0000000187956D50
		public static LocalTransform FromScale(float scale) => default; // 0x0000000187956D50-0x0000000187956E28
		public override string ToString() => default; // 0x00000001879578DC-0x0000000187957A40
		public float3 Right() => default; // 0x00000001879573D4-0x00000001879574A0
		public float3 Up() => default; // 0x0000000187957C50-0x0000000187957D28
		public float3 Forward() => default; // 0x000000018795611C-0x00000001879561F4
		public float3 TransformPoint(float3 point) => default; // 0x0000000184F8B320-0x0000000184F8B400
		public float3 InverseTransformPoint(float3 point) => default; // 0x0000000187956F00-0x000000018795703C
		public float3 TransformDirection(float3 direction) => default; // 0x0000000187957A40-0x0000000187957B00
		public float3 InverseTransformDirection(float3 direction) => default; // 0x0000000187956E28-0x0000000187956F00
		public quaternion TransformRotation(quaternion rotation) => default; // 0x0000000184F8B2B0-0x0000000184F8B320
		public quaternion InverseTransformRotation(quaternion rotation) => default; // 0x000000018795703C-0x00000001879570FC
		public float TransformScale(float scale) => default; // 0x0000000184F8B270-0x0000000184F8B2B0
		public float InverseTransformScale(float scale) => default; // 0x00000001879570FC-0x000000018795715C
		public LocalTransform TransformTransform(in LocalTransform transformData) => default; // 0x0000000184F8B110-0x0000000184F8B270
		public LocalTransform InverseTransformTransform(in LocalTransform transformData) => default; // 0x000000018795715C-0x0000000187957294
		public LocalTransform Inverse() => default; // 0x0000000187957294-0x00000001879573D4
		public float4x4 ToMatrix() => default; // 0x00000001845B8C50-0x00000001845B8E60
		public float4x4 ToInverseMatrix() => default; // 0x0000000187957800-0x00000001879578DC
		public LocalTransform WithPosition(float3 p) => default; // 0x0000000187957D28-0x0000000187957DE4
		public LocalTransform WithPosition(float x, float y, float z) => default; // 0x0000000187957DE4-0x0000000187957EC4
		public LocalTransform WithRotation(quaternion r) => default; // 0x0000000187957EC4-0x0000000187957F7C
		public LocalTransform WithScale(float s) => default; // 0x0000000187957F7C-0x0000000187958020
		public LocalTransform Translate(float3 translation) => default; // 0x0000000187957B00-0x0000000187957BF8
		public LocalTransform ApplyScale(float scale) => default; // 0x0000000187955FC8-0x0000000187956074
		public LocalTransform Rotate(quaternion rotation) => default; // 0x000000018795771C-0x0000000187957800
		public LocalTransform RotateX(float angle) => default; // 0x00000001879574A0-0x0000000187957574
		public LocalTransform RotateY(float angle) => default; // 0x0000000187957574-0x0000000187957648
		public LocalTransform RotateZ(float angle) => default; // 0x0000000187957648-0x000000018795771C
		public bool Equals(in LocalTransform other) => default; // 0x0000000187956074-0x000000018795611C
		private void __AOT_FOR_FIX__() {} // 0x0000000187958020-0x000000018795813C
		public string __iFixBaseProxy_ToString() => default; // 0x0000000187957BF8-0x0000000187957C50
	}

	public struct Root : IComponentECS // TypeDefIndex: 49741
	{
		// Fields
		public const int ID = 102; // Metadata: 0x02061114
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7550-0x0000000185FB7560 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187959C60-0x0000000187959D6C
	}

	public struct Parent : IComponentECS // TypeDefIndex: 49742
	{
		// Fields
		public Entity value; // 0x00
		public const int ID = 103; // Metadata: 0x02061116
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7500-0x0000000185FB7510 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879581A0-0x00000001879582AC
	}

	public struct Child : IComponentECS // TypeDefIndex: 49743
	{
		// Fields
		public EntityData32<Entity> value; // 0x00
		public const int ID = 104; // Metadata: 0x02061118
	
		// Properties
		public int id { get => default; } // 0x0000000183272090-0x00000001832720A0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187954A1C-0x0000000187954B60
	}

	public struct LocalToWorld : IComponentECS // TypeDefIndex: 49744
	{
		// Fields
		public float4x4 READ_ONLY_VAL; // 0x00
		public float4x4 PRE_FRAME_READ_ONLY_VAL; // 0x40
		public uint hierarchyHandle; // 0x80
		public bool dirty; // 0x84
		public int calcFrameCount; // 0x88
		public const int ID = 105; // Metadata: 0x0206111A
	
		// Properties
		public float3 right { get => default; } // 0x0000000187955ED8-0x0000000187955F50 
		public float3 up { get => default; } // 0x0000000187955F50-0x0000000187955FC8 
		public float3 forward { get => default; } // 0x0000000187955D30-0x0000000187955DA8 
		public float3 position { get => default; } // 0x00000001845B81C0-0x00000001845B8250 
		public quaternion rotation { get => default; } // 0x00000001845B8E60-0x00000001845B92D0 
		public float3 prePosition { get => default; } // 0x0000000187955DA8-0x0000000187955E20 
		public quaternion preRotation { get => default; } // 0x0000000187955E20-0x0000000187955ED8 
		public unsafe float4x4* READ_ONLY_VAL_PTR { get => default; } // 0x0000000185779060-0x0000000185779070 
		public unsafe float4x4* PRE_FRAME_READ_ONLY_VAL_PTR { get => default; } // 0x0000000185FB7410-0x0000000185FB7420 
		public int id { get => default; } // 0x0000000185FB7420-0x0000000185FB7430 
	
		// Methods
		public bool SetValue(float4x4 value, int frameCount) => default; // 0x00000001845B87D0-0x00000001845B8890
		private void __AOT_FOR_FIX__() {} // 0x0000000187955BF0-0x0000000187955D30
	}

	public struct UdPipeFragment : IComponentECS // TypeDefIndex: 49745
	{
		// Fields
		public ulong connectedCompId; // 0x00
		public int offset; // 0x08
		public const int ID = 106; // Metadata: 0x0206111C
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7620-0x0000000185FB7630 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018795A8CC-0x000000018795A9E4
	}

	public struct UnitConfigFragment : IComponentECS // TypeDefIndex: 49746
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int powerCost; // 0x04
		public bool isShowOutputUI; // 0x08
		public bool needPower; // 0x09
		public bool hidePreviewArrow; // 0x0A
		public bool suppressExternalAutoDither; // 0x0B
		public short inputPortCount; // 0x0C
		public short outputPortCount; // 0x0E
		public int facBuildingType; // 0x10
		public float3 bounds; // 0x14
		public int unitNameFastString; // 0x20
		public int iconOnPanelFastString; // 0x24
		public UnitConfigInternal baseConfig; // 0x28
		public const int ID = 107; // Metadata: 0x0206111E
	
		// Properties
		public string iconOnPanel { get => default; set {} } // 0x0000000184EC7AE0-0x0000000184EC7DF0 0x000000018483CFB0-0x000000018483D500
		public string unitName { get => default; set {} } // 0x000000018795AB0C-0x000000018795AE18 0x0000000185FB7630-0x0000000185FB7B80
		public int id { get => default; } // 0x0000000183270770-0x0000000183270780 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018795A9E4-0x000000018795AB0C
	}

	[Serializable]
	public struct UnitConfigInternal // TypeDefIndex: 49747
	{
		// Fields
		public Bounds bounds; // 0x00
		public Bounds buildingBounds; // 0x18
	}

	[Serializable]
	public struct FactoryUnitPortConfig // TypeDefIndex: 49748
	{
		// Fields
		public int portIdx; // 0x00
		public int globalPortIdx; // 0x04
		public bool inOut; // 0x08
		public bool isPipe; // 0x09
		public float3 pos; // 0x0C
		public float3 dir; // 0x18
	}

	[Serializable]
	public struct FactoryUnitExtendConfig // TypeDefIndex: 49749
	{
		// Fields
		public FixedString32Bytes nameRaw; // 0x00
		public float3 pos; // 0x20
		public quaternion rot; // 0x2C
		private int _unLoaderIndex_k__BackingField; // 0x3C
		private bool _isUnLoader_k__BackingField; // 0x40
	
		// Properties
		public string name { get => default; } // 0x000000018646EC6C-0x000000018646EC74 
		public int unLoaderIndex { get; set; } // 0x0000000185FB0790-0x0000000185FB07A0 0x0000000185FB07A0-0x0000000185FB07B0
		public bool isUnLoader { get; set; } // 0x0000000185FB0650-0x0000000185FB0660 0x0000000185FB0660-0x0000000185FB0670
	
		// Methods
		public override string ToString() => default; // 0x0000000187955068-0x0000000187955258
		public string __iFixBaseProxy_ToString() => default; // 0x0000000187955258-0x00000001879552C8
	}

	public struct UnitInteractFragment : IComponentECS // TypeDefIndex: 49750
	{
		// Fields
		public ulong interactObjectId; // 0x00
		public const int ID = 108; // Metadata: 0x02061120
	
		// Properties
		public int id { get => default; } // 0x000000018327D070-0x000000018327D080 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018795AF64-0x000000018795B070
	}

	public struct UnitRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49751
	{
		// Fields
		public uint logicNodeId; // 0x00
		public int partGuid; // 0x04
		public Entity logicEntity; // 0x08
		public int assetHashGuid; // 0x10
		public bool isSkipVATAnimation; // 0x14
		public float frameRate; // 0x18
		public float3 bounds; // 0x1C
		public Bounds buildingBounds; // 0x28
		public bool2 buildDismissEffectEnabled; // 0x40
		public float4 customArg0; // 0x44
		public int unitConfigAssetInstanceId; // 0x54
		public const int ID = 109; // Metadata: 0x02061122
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000185FB0670-0x0000000185FB0680 0x0000000185FB06A0-0x0000000185FB06B0
		public int id { get => default; } // 0x000000018327E990-0x000000018327E9A0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018795B4D0-0x000000018795B5F8
	}

	public struct RenderLookAtFragment : IComponentECS // TypeDefIndex: 49752
	{
		// Fields
		public bool lookAtEnable; // 0x00
		public bool lookAtArrived; // 0x01
		public bool yawEnabled; // 0x02
		public bool pitchEnabled; // 0x03
		public quaternion deltaQuaternion; // 0x04
		public float3 targetPos; // 0x14
		public half interpolation; // 0x20
		public const int ID = 110; // Metadata: 0x02061124
	
		// Properties
		public int id { get => default; } // 0x0000000183276BF0-0x0000000183276C00 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187959B3C-0x0000000187959C60
	}

	public struct ChapterTagFragment : IComponentECS // TypeDefIndex: 49753
	{
		// Fields
		public int chapterId; // 0x00
		public int mapId; // 0x04
		public int panelIndex; // 0x08
		public int sceneId; // 0x0C
		public const int ID = 111; // Metadata: 0x02061126
	
		// Properties
		public int id { get => default; } // 0x0000000183278510-0x0000000183278520 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000187954904-0x0000000187954A1C
	}

	public struct UnitStatusFragment : IComponentECS // TypeDefIndex: 49754
	{
		// Fields
		public byte preStatus; // 0x00
		public byte status; // 0x01
		public byte subStatus; // 0x02
		public const int ID = 112; // Metadata: 0x02061128
	
		// Properties
		public int id { get => default; } // 0x00000001832739B0-0x00000001832739C0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018795B744-0x000000018795B858
	}

	public struct UnitOverrideStatusFragment : IComponentECS // TypeDefIndex: 49755
	{
		// Fields
		public bool working; // 0x00
		public const int ID = 113; // Metadata: 0x0206112A
	
		// Properties
		public int id { get => default; } // 0x00000001832752D0-0x00000001832752E0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018795B070-0x000000018795B17C
	}

	public struct UnitStatusEffectFragment : IComponentECS // TypeDefIndex: 49756
	{
		// Fields
		public StatusNormalEffect normal; // 0x00
		public StatusClosedEffect closed; // 0x200
		public StatusIdleEffect idle; // 0x400
		public StatusBlockedEffect blocked; // 0x600
		public StatusNoPowerEffect noPower; // 0x800
		public StatusNotInPowerNetEffect notInPowerNet; // 0xA00
		public StatusFixableEffect fixable; // 0xC00
		public StatusBrokenEffect broken; // 0xE00
		public StatusOverloadEffect overload; // 0x1000
		public StatusBusDisconnectEffect busDisconnect; // 0x1200
		public int3 effectInstanceIdList; // 0x1400
		public const int ID = 114; // Metadata: 0x0206112C
	
		// Properties
		public int id { get => default; } // 0x0000000183279E30-0x0000000183279E40 
	
		// Methods
		public void SetEffects(BuildingStatus buildingStatus, FacEffectCfgList cfgList) {} // 0x0000000184CB5F30-0x0000000184CB8590
		public FixedList512Bytes<StatusSingleEffect> GetEffect(FacBuildingState status) => default; // 0x0000000184EC4AE0-0x0000000184EC4ED0
		private void __AOT_FOR_FIX__() {} // 0x000000018795B5F8-0x000000018795B744
	}

	public struct StatusNormalEffect // TypeDefIndex: 49757
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusClosedEffect // TypeDefIndex: 49758
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusIdleEffect // TypeDefIndex: 49759
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusBlockedEffect // TypeDefIndex: 49760
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusNoPowerEffect // TypeDefIndex: 49761
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusNotInPowerNetEffect // TypeDefIndex: 49762
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusFixableEffect // TypeDefIndex: 49763
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusBrokenEffect // TypeDefIndex: 49764
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusOverloadEffect // TypeDefIndex: 49765
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusBusDisconnectEffect // TypeDefIndex: 49766
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	[Serializable]
	public struct StatusSingleEffect // TypeDefIndex: 49767
	{
		// Fields
		public BuildingSubState subState; // 0x00
		public FixedString64Bytes name; // 0x02
		public float3 offset; // 0x44
		public bool needAlignToBuilding; // 0x50
	
		// Properties
		public string effectName { get => default; set {} } // 0x000000018464E920-0x000000018464EA70 0x000000018795A5F8-0x000000018795A650
	}

	[Serializable]
	public class FacEffectCfgList // TypeDefIndex: 49768
	{
		// Fields
		public List<StatusSingleEffect> list; // 0x10
	
		// Properties
		public int cfgCount { get => default; } // 0x0000000187954F58-0x0000000187954F98 
	
		// Constructors
		public FacEffectCfgList() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public enum BuildingStatus // TypeDefIndex: 49769
	{
		INVALID = 0,
		CLOSED = 1,
		UNKNOWN = 2,
		IDLE = 3,
		NORMAL = 4,
		BLOCKED = 5,
		NO_POWER = 6,
		NOT_IN_POWER_NET = 7,
		FIXABLE = 8,
		BROKEN = 9,
		OVERLOAD = 10,
		BUS_DISCONNECT = 11,
		MAX = 16
	}

	public enum BuildingSubState : byte // TypeDefIndex: 49770
	{
		NONE = 0,
		SUB_STATE_1 = 1,
		SUB_STATE_2 = 2,
		SUB_STATE_3 = 4,
		SUB_STATE_4 = 8,
		ANY = 15
	}

	public struct UnitStatusUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49771
	{
		// Fields
		private int _unitConfigAssetInstanceId_k__BackingField; // 0x00
		public const int ID = 115; // Metadata: 0x02061141
	
		// Properties
		public int unitConfigAssetInstanceId { get; set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int unitAssetInstanceId { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x000000018327B750-0x000000018327B760 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018795B858-0x000000018795B964
	}

	public struct UnitTransFragment : IComponentECS, IRotateFragment, IPositionFragment // TypeDefIndex: 49772
	{
		// Fields
		public float3 __position; // 0x00
		public float3 __rotation; // 0x0C
		public float3 cornerLD; // 0x18
		public float3 cornerRU; // 0x24
		public const int ID = 116; // Metadata: 0x02061144
	
		// Properties
		public quaternion RotationQuaternion { get => default; } // 0x000000018416BDC0-0x000000018416BE60 
		public float3 Position { get => default; set {} } // 0x0000000185FB7B80-0x0000000185FB7BA0 0x0000000185FB7BD0-0x0000000185FB7BE0
		public float3 Rotation { get => default; set {} } // 0x0000000185FB7BA0-0x0000000185FB7BC0 0x0000000185FB7BE0-0x0000000185FB7BF0
		public int id { get => default; } // 0x0000000185FB7BC0-0x0000000185FB7BD0 
	
		// Methods
		public bool InBound(float3 pos, bool ignoreY = true /* Metadata: 0x02061143 */) => default; // 0x000000018795B964-0x000000018795BAF8
		private void __AOT_FOR_FIX__() {} // 0x000000018795BAF8-0x000000018795BC1C
	}

	public struct ValveFragment : IComponentECS // TypeDefIndex: 49773
	{
		// Fields
		public bool enable; // 0x00
		public uint selectedItemId; // 0x04
		public int passed; // 0x08
		public int currentPassed; // 0x0C
		public FactoryItem holdItem; // 0x10
		public const int ID = 117; // Metadata: 0x02061146
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7BF0-0x0000000185FB7C00 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018795C44C-0x000000018795C568
	}

	public struct BoxValve : IComponentECS // TypeDefIndex: 49774
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 118; // Metadata: 0x02061148
	
		// Properties
		public int id { get => default; } // 0x0000000185FB73B0-0x0000000185FB73C0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879547F8-0x0000000187954904
	}

	public struct FluidValve : IComponentECS // TypeDefIndex: 49775
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 119; // Metadata: 0x0206114A
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7400-0x0000000185FB7410 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001879552C8-0x00000001879553D4
	}

	public struct BlueprintSlotInfo // TypeDefIndex: 49783
	{
		// Fields
		public const int RELATED_SLOT_ID = -1; // Metadata: 0x0206114D
		public const int SLOT_MAX_COUNT = 6; // Metadata: 0x0206114E
		public const int UNIT_MAX_COUNT_PER_SLOT = 256; // Metadata: 0x0206114F
		private _m_blueprintSlotInfo0_e__FixedBuffer m_blueprintSlotInfo0; // 0x00
		private _m_blueprintSlotInfo1_e__FixedBuffer m_blueprintSlotInfo1; // 0x800
		private _m_blueprintSlotInfo2_e__FixedBuffer m_blueprintSlotInfo2; // 0x1000
		private _m_blueprintSlotInfo3_e__FixedBuffer m_blueprintSlotInfo3; // 0x1800
		private _m_blueprintSlotInfo4_e__FixedBuffer m_blueprintSlotInfo4; // 0x2000
		private _m_blueprintSlotInfo5_e__FixedBuffer m_blueprintSlotInfo5; // 0x2800
		private _m_blueprintRelatedSlotInfo_e__FixedBuffer m_blueprintRelatedSlotInfo; // 0x3000
	
		// Nested types
		public struct _m_blueprintSlotInfo0_e__FixedBuffer // TypeDefIndex: 49776
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		public struct _m_blueprintSlotInfo1_e__FixedBuffer // TypeDefIndex: 49777
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		public struct _m_blueprintSlotInfo2_e__FixedBuffer // TypeDefIndex: 49778
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		public struct _m_blueprintSlotInfo3_e__FixedBuffer // TypeDefIndex: 49779
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		public struct _m_blueprintSlotInfo4_e__FixedBuffer // TypeDefIndex: 49780
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		public struct _m_blueprintSlotInfo5_e__FixedBuffer // TypeDefIndex: 49781
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		public struct _m_blueprintRelatedSlotInfo_e__FixedBuffer // TypeDefIndex: 49782
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		// Methods
		public bool ContainsNodeId(ref EntityManager em, int slotId, int nodeId) => default; // 0x0000000187953CA8-0x0000000187953DD8
		public void RemoveEntityFromSlot(ref EntityManager em, int slotId, Entity overdueEntity) {} // 0x0000000187954128-0x000000018795422C
		public int FindEmptySlotIdx() => default; // 0x0000000187953DD8-0x0000000187953E4C
		public int GetSuitableSlotIdx(int slotId) => default; // 0x00000001879540A0-0x0000000187954128
		public void SetSlotId(int index, int slotId) {} // 0x000000018795422C-0x00000001879542A8
		public ulong[] GetSlotIds() => default; // 0x000000018478AA00-0x000000018478AAA0
		public void AppendSlotInfo(int slotId, Entity logicEntity) {} // 0x0000000187953B38-0x0000000187953C18
		public Entity[] ClearSlotInfo(int slotId) => default; // 0x0000000187953C18-0x0000000187953CA8
		private unsafe Entity[] _ClearSlotInfo(ulong* slotGroupPtr) => default; // 0x00000001879546C8-0x00000001879547F8
		public void DiffSlotInfo(ref EntityManager em, int slotId, ref PooledList<uint> baseList, ref PooledList<uint> newList, ref PooledList<Entity> overdueList) {} // 0x0000000184981E20-0x0000000184982000
		public NativeArray<Entity> GetAllPendingEntitiesInSlot(int slotId) => default; // 0x0000000187953E4C-0x0000000187953F5C
		public Entity GetSlotInfo(int slotId, int index) => default; // 0x0000000187953FDC-0x00000001879540A0
		public ulong GetPendingEntityCountInSlot(int slotId) => default; // 0x0000000187953F5C-0x0000000187953FDC
		public unsafe ulong* GetSlotGroupWithSlotId(int slotId, out int slotIdx, bool includeInvalid = true /* Metadata: 0x0206114C */) {
			slotIdx = default;
			return default;
		} // 0x0000000184982000-0x0000000184982050
		public unsafe ulong* GetRelatedSlotGroup() => default; // 0x0000000185FB73A0-0x0000000185FB73B0
		public unsafe ulong* GetSlotGroup(int index) => default; // 0x000000018478AAA0-0x000000018478AB30
		public static BlueprintSlotInfo CreateDefault() => default; // 0x000000018478CC50-0x000000018478CCD0
		public override string ToString() => default; // 0x00000001879542A8-0x0000000187954648
		public string __iFixBaseProxy_ToString() => default; // 0x0000000187954648-0x00000001879546C8
	}

	public struct CargoRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49786
		where T : struct
	{
		// Fields
		public const int T_SIZE = 72; // Metadata: 0x02061154
		public const int CAPACITY = 4096; // Metadata: 0x02061156
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x02061158
		public const int INVALID_INDEX = -1; // Metadata: 0x0206115A
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49784
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private CargoRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in CargoRendererInfoCollection<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49785
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public CargoRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x02061151 */, bool autoExtend = false /* Metadata: 0x02061153 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe T* GetDataPtr() => default;
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct CargoRendererInfo // TypeDefIndex: 49787
	{
		// Fields
		public float4 positionAndScale; // 0x00
		public float3 position; // 0x00
		public float scale; // 0x0C
		public quaternion rotation; // 0x10
		public HGFactoryEntityTransformData transform; // 0x00
		public float4 itemUV; // 0x20
		public float4 itemLiquidUV; // 0x30
		public float isLiquidItem; // 0x40
		public byte preFrameVisible; // 0x44
	}

	public struct ConveyorRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49790
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0206115E
		public const int CAPACITY = 4096; // Metadata: 0x02061160
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x02061162
		public const int INVALID_INDEX = -1; // Metadata: 0x02061164
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49788
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private ConveyorRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in ConveyorRendererInfoCollection<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49789
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public ConveyorRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x0206115B */, bool autoExtend = false /* Metadata: 0x0206115D */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe T* GetDataPtr() => default;
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct ConveyorRendererInfo // TypeDefIndex: 49791
	{
		// Fields
		public int index; // 0x00
		public int totalLength; // 0x04
		public float speed; // 0x08
		public float adjustMapHeight; // 0x0C
		public bool isPreview; // 0x10
		public bool isCorner; // 0x11
		public bool valid; // 0x12
		public bool highLight; // 0x13
		public uint sharedDataHandle; // 0x14
		public float3 position; // 0x18
		public float3 rotation; // 0x24
		public uint lightMode; // 0x30
		public BlueprintState.EffectType blueprintType; // 0x34
	
		// Methods
		public override string ToString() => default; // 0x0000000187954B60-0x0000000187954EF0
		public string __iFixBaseProxy_ToString() => default; // 0x0000000187954EF0-0x0000000187954F58
	}

	public struct FactoryItem // TypeDefIndex: 49792
	{
		// Fields
		public uint itemId; // 0x00
		public int itemAmount; // 0x04
		public long tms; // 0x08
	}

	public struct PipeRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49795
		where T : struct
	{
		// Fields
		public const int T_SIZE = 96; // Metadata: 0x02061168
		public const int CAPACITY = 4096; // Metadata: 0x0206116A
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x0206116C
		public const int INVALID_INDEX = -1; // Metadata: 0x0206116E
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49793
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PipeRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in PipeRendererInfoCollection<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49794
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public PipeRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x02061165 */, bool autoExtend = false /* Metadata: 0x02061167 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe T* GetDataPtr() => default;
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct PipeTrackRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49798
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x02061172
		public const int CAPACITY = 128; // Metadata: 0x02061174
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x02061176
		public const int INVALID_INDEX = -1; // Metadata: 0x02061178
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49796
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PipeTrackRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in PipeTrackRendererInfoCollection<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49797
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public PipeTrackRendererInfoCollection(int initialCapacity = 128 /* Metadata: 0x0206116F */, bool autoExtend = false /* Metadata: 0x02061171 */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe T* GetDataPtr() => default;
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct PipeRendererInfo // TypeDefIndex: 49799
	{
		// Fields
		public int index; // 0x00
		public int totalLength; // 0x04
		public float waterDirection; // 0x08
		public float pipeHeight; // 0x0C
		public float waterThickness; // 0x10
		public float waterFlowDeltaTime; // 0x14
		public bool isPreview; // 0x18
		public bool valid; // 0x19
		public bool highLight; // 0x1A
		public byte proto; // 0x1B
		public int subItemType; // 0x1C
		public uint sharedDataHandle; // 0x20
		public float bend; // 0x24
		public uint lightMode; // 0x28
		public float3 position; // 0x30
		public float3 rotation; // 0x3C
		public BlueprintState.EffectType blueprintType; // 0x48
	}

	public struct PipeTrackRendererInfo // TypeDefIndex: 49800
	{
		// Fields
		public int index; // 0x00
		public int totalLength; // 0x04
		public float pipeHeight; // 0x08
		public float gridPathHeight; // 0x0C
		public float gridPathHeightEnd; // 0x10
		public float3 position; // 0x14
		public float3 rotation; // 0x20
		public bool valid; // 0x2C
	}

	public struct PortArrowRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49803
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0206117C
		public const int CAPACITY = 2048; // Metadata: 0x0206117E
		public const int CAPACITY_MINUS_ONE = 2047; // Metadata: 0x02061180
		public const int INVALID_INDEX = -1; // Metadata: 0x02061182
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49801
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PortArrowRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in PortArrowRendererInfoCollection<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 49802
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public PortArrowRendererInfoCollection(int initialCapacity = 2048 /* Metadata: 0x02061179 */, bool autoExtend = false /* Metadata: 0x0206117B */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe T* GetDataPtr() => default;
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct PortArrowRendererInfo // TypeDefIndex: 49804
	{
		// Fields
		public float3 pos; // 0x00
		public bool isForbidden; // 0x0C
		public quaternion rot; // 0x10
		public float4 renderColor; // 0x20
		public float4 atlasUV; // 0x30
	}

	public struct UnitId : IEquatable<UnitId> // TypeDefIndex: 49805
	{
		// Fields
		public int mapId; // 0x00
		public uint factoryUnitId; // 0x04
	
		// Methods
		public bool Equals(UnitId other) => default; // 0x0000000184164E30-0x0000000184164ED0
		public override bool Equals(object obj) => default; // 0x000000018795AE18-0x000000018795AEB4
		public override int GetHashCode() => default; // 0x0000000184164BD0-0x0000000184164C60
		public static UnitId Create(int mapId, uint factoryUnitId) => default; // 0x0000000184164B40-0x0000000184164BD0
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018795AEB4-0x000000018795AF14
		public int __iFixBaseProxy_GetHashCode() => default; // 0x000000018795AF14-0x000000018795AF64
	}

	public struct Visibility // TypeDefIndex: 49809
	{
		// Fields
		public static Visibility s_defaultVal; // 0x00
		public uint visibleFlags; // 0x00
		public short invisibleSubCount; // 0x04
		public _invisibleSubBits_e__FixedBuffer invisibleSubBits; // 0x06
		public const int SUB_INDEX_MAX_COUNT = 128; // Metadata: 0x02061183
		public const int SUB_BIT_BYTE_COUNT = 16; // Metadata: 0x02061185
	
		// Properties
		public bool isVisible { get => default; } // 0x00000001841637E0-0x0000000184163960 
	
		// Nested types
		public enum EFlag // TypeDefIndex: 49806
		{
			BASIC = 1,
			FIGURE = 4,
			OTHER_MAP = 8,
			PHOTO = 16,
			BUILD_MODE = 32,
			UI = 64,
			HINT_EFFECT = 128,
			ALL = 255,
			EXTERNAL = 32768
		}
	
		public enum Type : byte // TypeDefIndex: 49807
		{
			BASE = 1,
			ADDITIVE_MAT = 2
		}
	
		public struct _invisibleSubBits_e__FixedBuffer // TypeDefIndex: 49808
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Constructors
		static Visibility() {
			s_defaultVal = default;
		} // 0x0000000185F6B4D0-0x0000000185F6B530
	
		// Methods
		public bool SetVisible(EFlag flag, bool visible) => default; // 0x0000000184983420-0x00000001849834B0
		public unsafe bool SetVisible(EFlag flag, bool visible, short* invisibleIndexListPtr, short invisibleIndexCount) => default; // 0x0000000184162B10-0x0000000184162CC0
		public bool GetVisible(EFlag flag) => default; // 0x0000000184163960-0x00000001841639F0
		public bool IsSubRendererInvisible(int subIndex) => default; // 0x000000018795C568-0x000000018795C5D8
		private static unsafe void _SetSubInvisible(byte* head, int index, bool invisible) {} // 0x000000018795C5F8-0x000000018795C624
		private static unsafe bool _GetSubInvisible(byte* head, int index) => default; // 0x000000018795C5D8-0x000000018795C5F8
	}

	public struct WireRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49811
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 120; // Metadata: 0x02061197
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public int id { get => default; } // 0x0000000185FB7C00-0x0000000185FB7C10 
	
		// Nested types
		public enum Type : byte // TypeDefIndex: 49810
		{
			NORMAL = 0,
			HS_NORMAL = 1,
			DISABLE = 2,
			STRENGTHEN = 3,
			HS_STRENGTHEN = 4,
			STRENGTHEN_DISABLE = 5
		}
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018795C624-0x000000018795C730
	}

	public struct GlobalSharedData // TypeDefIndex: 49835
	{
		// Fields
		public static readonly SharedStatic<CullingGlobalSetting> CULLING_SETTING; // 0x00
		public static readonly SharedStatic<NearByDistanceGlobalSetting> NEAR_BY_DISTANCE_SETTING; // 0x08
		public static readonly SharedStatic<World3DUiGlobalSetting> WORLD_3D_UI_SETTING; // 0x10
		public static readonly SharedStatic<CurveGlobalSetting> CURVE_SETTING; // 0x18
		public static readonly SharedStatic<MapGridRendererData> GRID_RENDERER_DATA; // 0x20
		public static readonly SharedStatic<UnitPortConfigDB> UNIT_PORT_DB; // 0x28
		public static readonly SharedStatic<PerDrawGlobalSetting> PERDRAW_SETTING; // 0x30
		public static readonly SharedStatic<SystemIntervalGlobalSetting> SYSTEM_INTERVAL_SETTING; // 0x38
		public static readonly SharedStatic<UIEffectPathConfig> STATE_UI_PATH; // 0x40
	
		// Nested types
		public struct CullingGlobalSetting // TypeDefIndex: 49812
		{
			// Fields
			public bool bOverride; // 0x00
			public CullingDisSetting setting; // 0x04
			public CullingDisSetting overrideSetting; // 0x14
	
			// Properties
			public float sqrCullDis { get => default; set {} } // 0x00000001846B1D10-0x00000001846B1D40 0x0000000185BAF850-0x0000000185BAFA90
			public float sqrUI { get => default; set {} } // 0x0000000184168C20-0x0000000184168CB0 0x0000000185FB73D0-0x0000000185FB73E0
			public float sqrBuildingName { get => default; set {} } // 0x000000018475A080-0x000000018475A0C0 0x0000000185FB73E0-0x0000000185FB73F0
			public float sqrWireCullDis { get => default; set {} } // 0x000000018475A040-0x000000018475A080 0x0000000185FB73C0-0x0000000185FB73D0
	
			// Methods
			public void ResetOverride() {} // 0x0000000187955B4C-0x0000000187955BF0
		}
	
		[Serializable]
		public struct CullingDisSetting // TypeDefIndex: 49813
		{
			// Fields
			public float sqrCullDis; // 0x00
			public float sqrBuildingName; // 0x04
			public float sqrUI; // 0x08
			public float sqrWireCullDis; // 0x0C
		}
	
		public struct NearByDistanceGlobalSetting // TypeDefIndex: 49814
		{
			// Fields
			public bool bOverride; // 0x00
			public NearByDistanceSetting setting; // 0x04
			public NearByDistanceSetting overrideSetting; // 0x20
	
			// Properties
			public bool nearByCheck { get => default; set {} } // 0x000000018795813C-0x00000001879581A0 0x00000001846B1C90-0x00000001846B1CD0
			public float portPreviewCheckDistance { get => default; set {} } // 0x0000000184820BB0-0x0000000184820C30 0x0000000185FB74C0-0x0000000185FB74D0
			public float pedestalFlashCheckDistance { get => default; set {} } // 0x0000000184C59E50-0x0000000184C59E90 0x0000000185FB74E0-0x0000000185FB74F0
			public float logisticEffectCheckDistance { get => default; set {} } // 0x0000000184820B30-0x0000000184820B70 0x0000000185FB74D0-0x0000000185FB74E0
			public float unitRendererCheckDistance { get => default; set {} } // 0x0000000184820B70-0x0000000184820BB0 0x0000000185FB74B0-0x0000000185FB74C0
			public float l2wCheckDistance { get => default; set {} } // 0x000000018481DC00-0x000000018481DC40 0x0000000185FB74F0-0x0000000185FB7500
			public float additiveEffectCheckDistance { get => default; set {} } // 0x00000001848214F0-0x00000001848216D0 0x0000000185FB74A0-0x0000000185FB74B0
	
			// Methods
			public void ResetOverride() {} // 0x0000000185FB73F0-0x0000000185FB7400
			public void Disable() {} // 0x00000001843E8C00-0x00000001843E8C40
		}
	
		[Serializable]
		public struct NearByDistanceSetting // TypeDefIndex: 49815
		{
			// Fields
			public bool nearByCheck; // 0x00
			public float portPreviewCheckDistance; // 0x04
			public float pedestalFlashCheckDistance; // 0x08
			public float logisticEffectCheckDistance; // 0x0C
			public float unitRendererCheckDistance; // 0x10
			public float l2wCheckDistance; // 0x14
			public float additiveEffectCheckDistance; // 0x18
		}
	
		public struct World3DUiGlobalSetting // TypeDefIndex: 49816
		{
			// Fields
			public bool bOverride; // 0x00
			public World3DUiSetting setting; // 0x01
			public World3DUiSetting overrideSetting; // 0x02
	
			// Properties
			public bool buildingNameShadowDisable { get => default; set {} } // 0x00000001846B1D40-0x00000001846B1D70 0x000000018795C730-0x000000018795C780
	
			// Methods
			public void Disable() {} // 0x0000000185FB7490-0x0000000185FB74A0
			public void ResetOverride() {} // 0x00000001848216D0-0x0000000184821710
		}
	
		[Serializable]
		public struct World3DUiSetting // TypeDefIndex: 49817
		{
			// Fields
			public bool buildingNameShadowDisable; // 0x00
		}
	
		[Serializable]
		public struct CurveGlobalSetting // TypeDefIndex: 49818
		{
			// Fields
			public unsafe void* buildCurve; // 0x00
			public unsafe void* buildAlphaCurve0; // 0x08
			public unsafe void* buildAlphaCurve1; // 0x10
			public unsafe void* repairCurve0; // 0x18
			public unsafe void* repairCurve1; // 0x20
	
			// Methods
			public void SetBuildCurve(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1) {} // 0x0000000185FB7C10-0x0000000185FB7C20
			public void SetRepairCurve0(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve) {} // 0x00000001846B2730-0x00000001846B2770
			public void SetRepairCurve1(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve) {} // 0x0000000185A13EB0-0x0000000185A13F10
		}
	
		public struct MapGridRendererData // TypeDefIndex: 49822
		{
			// Fields
			public const int MAX_COUNT = 3200; // Metadata: 0x0206119F
			public short gridCountRegion; // 0x00
			public short gridCountField; // 0x02
			public short gridCount; // 0x04
			public _infos_e__FixedBuffer infos; // 0x06
	
			// Properties
			public MapGridInfo this[int idx] { get => default; } // 0x00000001841013F0-0x0000000184101530 
	
			// Nested types
			public struct MapGridInfo // TypeDefIndex: 49820
			{
				// Fields
				public LocalTransform trans; // 0x00
				public int3 gridVoxelIndex; // 0x20
				public bool selected; // 0x2C
				public SelectType selectedRenderType; // 0x30
				public bool hover; // 0x34
				public bool water; // 0x35
				public bool invalid; // 0x36
	
				// Nested types
				public enum SelectType // TypeDefIndex: 49819
				{
					NORMAL = 0,
					BLUEPRINT = 1
				}
			}
	
			public struct _infos_e__FixedBuffer // TypeDefIndex: 49821
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			// Methods
			public void UpdateGrid(ref MapGridInfo[] gridInfosRegion, ref MapGridInfo[] gridInfosField) {} // 0x0000000185A13E70-0x0000000185A13EB0
			public void Reset() {} // 0x0000000185A13E30-0x0000000185A13E70
			public unsafe MapGridInfo* GetGridInfoPtr(int idx) => default; // 0x00000001851D87A0-0x00000001851D87D0
		}
	
		[Serializable]
		public struct UnitPortConfigDB // TypeDefIndex: 49823
		{
			// Fields
			public NativeParallelHashMap<int, UnitPortConfig> configMap; // 0x00
	
			// Methods
			public void Initialize(int capacity = 128 /* Metadata: 0x020611A3 */) {} // 0x0000000185FB7450-0x0000000185FB7490
			public void Dispose() {} // 0x0000000185FB7440-0x0000000185FB7450
			public bool EnsureValue(string unitName, out UnitPortConfig value) {
				value = default;
				return default;
			} // 0x00000001846B1BE0-0x00000001846B1C90
			public bool EnsureValue(int unitNameFastId, out UnitPortConfig value) {
				value = default;
				return default;
			} // 0x000000018795B2C0-0x000000018795B354
			public bool TryGetValue(string unitName, out UnitPortConfig value) {
				value = default;
				return default;
			} // 0x0000000184794CE0-0x0000000184794EA0
			public bool TryGetValue(int unitNameFastId, out UnitPortConfig value) {
				value = default;
				return default;
			} // 0x00000001846ED570-0x00000001846ED5D0
			public void Add(string unitName, UnitPortConfig value) {} // 0x00000001847941A0-0x0000000184794B20
			public void Add(int unitNameFastId, UnitPortConfig value) {} // 0x0000000184794B20-0x0000000184794CE0
			public bool ContainsKey(string unitName) => default; // 0x00000001854432D0-0x0000000185443D20
			public void Clear() {} // 0x0000000185443D20-0x0000000185443E00
			private UnitPortConfig _CreateWithTable(int unitNameFastId) => default; // 0x000000018795B210-0x000000018795B2C0
			private UnitPortConfig _CreateWithTable(string unitName) => default; // 0x000000018795B17C-0x000000018795B210
			private static void _ParseGlobalPortIdx(string templateName, ref FactoryUnitPortConfig port, int inPortCount) {} // 0x000000018795B354-0x000000018795B4D0
			internal static void __CreateWithTable_g__FillBuildingPorts_12_0(string templateName, FactoryBuildingData data, ref UnitPortConfig target) {} // 0x0000000184EE1140-0x0000000184EE1C30
			internal static void __CreateWithTable_g__ParsePort_12_1(ref UnitPortConfig target, string templateName, Vector3IntData range, BeanArray<TransformInt> inputPorts, BeanArray<TransformInt> outputPorts, bool isPipePort) {} // 0x0000000184EE2790-0x0000000184EE2940
		}
	
		public struct UnitPortConfig // TypeDefIndex: 49824
		{
			// Fields
			public ushort inputPortCount; // 0x00
			public ushort outputPortCount; // 0x02
			public FixedList512Bytes<FactoryUnitPortConfig> portIn; // 0x04
			public FixedList512Bytes<FactoryUnitPortConfig> portOut; // 0x204
		}
	
		[Serializable]
		public struct PerDrawGlobalSetting // TypeDefIndex: 49831
		{
			// Fields
			public const int COLOR_DATA_CAPACITY = 57690; // Metadata: 0x020611A5
			public const int PASS_DATA_CAPACITY = 57600; // Metadata: 0x020611A9
			public _colorData_e__FixedBuffer colorData; // 0x00
			public _passData_e__FixedBuffer passData; // 0xE15A
	
			// Nested types
			public struct PerDrawPassGlobalSetting // TypeDefIndex: 49826
			{
				// Fields
				public int count; // 0x00
				public _config_e__FixedBuffer config; // 0x04
	
				// Properties
				public PerDrawPassConfig this[int idx] { get => default; set {} } // 0x0000000184EE0A50-0x0000000184EE1140 0x00000001879585C8-0x0000000187958630
	
				// Nested types
				public struct _config_e__FixedBuffer // TypeDefIndex: 49825
				{
					// Fields
					public byte FixedElementField; // 0x00
				}
	
				// Methods
				public PerDrawPassConfig GetPerDrawPassConfig(int idx) => default; // 0x0000000184EE1C30-0x0000000184EE2790
			}
	
			public struct PerDrawColorGlobalSetting // TypeDefIndex: 49828
			{
				// Fields
				public int count; // 0x00
				public _configs_e__FixedBuffer configs; // 0x04
	
				// Properties
				public PerDrawConfig this[int idx] { get => default; set {} } // 0x00000001840FFC20-0x00000001840FFDD0 0x00000001879584D4-0x0000000187958544
	
				// Nested types
				public struct _configs_e__FixedBuffer // TypeDefIndex: 49827
				{
					// Fields
					public byte FixedElementField; // 0x00
				}
	
				// Methods
				public PerDrawConfig GetPerDrawConfig(int idx) => default; // 0x00000001840FFB50-0x00000001840FFBE0
			}
	
			public struct _colorData_e__FixedBuffer // TypeDefIndex: 49829
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			public struct _passData_e__FixedBuffer // TypeDefIndex: 49830
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			// Methods
			public unsafe void Apply(HGFactoryRendererBinderComponent* binder, LogicEntityState entityState, LogicEntityType entityType) {} // 0x0000000187958410-0x00000001879584D4
			public void Apply(ref HGFactoryRendererBinderComponent binder, LogicEntityState entityState, LogicEntityType entityType) {} // 0x0000000187958544-0x00000001879585C8
			public static unsafe void Apply(ref HGFactoryRendererBinderComponent binder, PerDrawConfig* perDrawConfigs, int length) {} // 0x00000001840FFF70-0x0000000184100FB0
			public unsafe void ApplyPass(HGFactoryRendererBinderComponent* binder, LogicEntityState entityState, LogicEntityType entityType, uint currentLightMode) {} // 0x00000001840FFBE0-0x00000001840FFC20
			public void ApplyPass(ref HGFactoryRendererBinderComponent binder, LogicEntityState entityState, LogicEntityType entityType, uint currentLightMode) {} // 0x0000000187958630-0x00000001879586D0
			public static unsafe void ApplyPass(ref HGFactoryRendererBinderComponent binder, PerDrawPassConfig* perDrawConfigs, int length, uint currentLightMode) {} // 0x00000001879586D0-0x0000000187958780
			public void Parse(SerializeFieldDictionary<LogicEntityState, SerializeFieldDictionary<LogicEntityType, PerDrawConfigArray>> setting) {} // 0x0000000184101720-0x0000000184101790
			private int _GetKey(LogicEntityState entityState, LogicEntityType entityType) => default; // 0x00000001879582AC-0x0000000187958354
		}
	
		public struct SystemIntervalGlobalSetting // TypeDefIndex: 49832
		{
			// Fields
			public bool bOverride; // 0x00
			public SystemIntervalSetting setting; // 0x04
			public SystemIntervalSetting overrideSetting; // 0x2C
	
			// Properties
			public int crossCollectFrameInterval { get => default; set {} } // 0x00000001846B1CD0-0x00000001846B1D10 0x000000018795A650-0x000000018795A6C8
			public int cullingSystemInterval { get => default; set {} } // 0x00000001851DE780-0x00000001851DE7B0 0x0000000185FB75B0-0x0000000185FB75C0
			public int unitPreviewSystemInterval { get => default; set {} } // 0x00000001846B34B0-0x00000001846B34F0 0x0000000185FB75C0-0x0000000185FB75D0
			public int portPreviewRenderSystemInterval { get => default; set {} } // 0x00000001846B35F0-0x00000001846B3630 0x0000000185FB7610-0x0000000185FB7620
			public int buildingStateSystemInterval { get => default; set {} } // 0x00000001846B3570-0x00000001846B35B0 0x0000000185FB7600-0x0000000185FB7610
			public int portBlockSystemInterval { get => default; set {} } // 0x00000001846B3470-0x00000001846B34B0 0x0000000185FB75A0-0x0000000185FB75B0
			public int outputUISystemInterval { get => default; set {} } // 0x00000001846B35B0-0x00000001846B35F0 0x0000000185FB75F0-0x0000000185FB7600
			public int buildingNameSystemInterval { get => default; set {} } // 0x00000001846B3530-0x00000001846B3570 0x0000000185FB75E0-0x0000000185FB75F0
			public int adjustGroundSystemInterval { get => default; set {} } // 0x000000018795A6C8-0x000000018795A724 0x0000000185FB7590-0x0000000185FB75A0
			public int gridSystemInterval { get => default; set {} } // 0x00000001846B3430-0x00000001846B3470 0x0000000185FB7580-0x0000000185FB7590
	
			// Methods
			public void Disable() {} // 0x0000000187958354-0x0000000187958410
			public void ResetOverride() {} // 0x0000000184100FB0-0x0000000184101240
		}
	
		[Serializable]
		public struct SystemIntervalSetting // TypeDefIndex: 49833
		{
			// Fields
			private const int MIN_INTERVAL = 0; // Metadata: 0x020611AD
			private const int MAX_INTERVAL = 60; // Metadata: 0x020611AE
			public int crossCollectFrameInterval; // 0x00
			public int cullingSystemInterval; // 0x04
			public int unitPreviewSystemInterval; // 0x08
			public int portPreviewRenderSystemInterval; // 0x0C
			public int buildingStateSystemInterval; // 0x10
			public int portBlockSystemInterval; // 0x14
			public int outputUISystemInterval; // 0x18
			public int buildingNameSystemInterval; // 0x1C
			public int adjustGroundSystemInterval; // 0x20
			public int gridSystemInterval; // 0x24
		}
	
		[Serializable]
		public struct UIEffectPathConfig // TypeDefIndex: 49834
		{
			// Fields
			public static int s_max; // 0x00
			public NativeParallelHashMap<int, FixedString32Bytes> atlasNames; // 0x00
			public NativeParallelHashMap<int, float4> atlasColors; // 0x10
			public NativeParallelHashMap<int, float4> atlasUVs; // 0x20
	
			// Constructors
			static UIEffectPathConfig() {
				s_max = default;
			} // 0x00000001851DCE70-0x00000001851DDFC0
	
			// Methods
			public void Parse(SerializeFieldDictionary<FacBuildingState, string> config, SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryStateIconColorConfig, FactoryUIAtlasSOData uvConfig) {} // 0x0000000185FB75D0-0x0000000185FB75E0
			public bool Get(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color) {
				path = default;
				uv = default;
				color = default;
				return default;
			} // 0x00000001846B34F0-0x00000001846B3530
		}
	
		// Constructors
		static GlobalSharedData() {
			CULLING_SETTING = default;
			NEAR_BY_DISTANCE_SETTING = default;
			WORLD_3D_UI_SETTING = default;
			CURVE_SETTING = default;
			GRID_RENDERER_DATA = default;
			UNIT_PORT_DB = default;
			PERDRAW_SETTING = default;
			SYSTEM_INTERVAL_SETTING = default;
			STATE_UI_PATH = default;
		} // 0x0000000185FA3CE0-0x0000000185FA3D20
	
		// Methods
		public void Reset() {} // 0x000000018795A724-0x000000018795A8CC
	}

	public abstract class BaseProcessor : IProcessor // TypeDefIndex: 49836
	{
		// Fields
		protected FactorySetting m_factorySetting; // 0x10
		private float _interval_k__BackingField; // 0x18
		private float _curInterval_k__BackingField; // 0x1C
	
		// Properties
		public virtual float interval { get; protected set; } // 0x0000000181C9AC50-0x0000000181C9AC60 0x0000000181C9A5A0-0x0000000181C9A5B0
		public virtual float curInterval { get; set; } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public abstract string name { get; }
		public virtual bool lowFrameEnable { get; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		protected BaseProcessor() {} // 0x0000000185FB7390-0x0000000185FB73A0
	
		// Methods
		public virtual void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting) {} // 0x00000001851D75E0-0x00000001851D7640
		public virtual JobHandle PreExecute(ref EntityManager em, long time, long deltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default; // 0x00000001846B4630-0x00000001846B46E0
		public virtual JobHandle Execute(ref EntityManager em, long time, long deltaTime, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default; // 0x00000001848861F0-0x00000001848862A0
		public virtual JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle) => default; // 0x0000000184163FA0-0x0000000184164050
		public virtual void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null) {} // 0x00000001846B46E0-0x00000001846B4D10
		public virtual void TearDown(ref EntityManager em, ref GlobalEnv env) {} // 0x0000000187953ADC-0x0000000187953B38
		protected void StructuralSync(ref JobHandle jh, ref NativeList<JobHandle> noneDependencies) {} // 0x00000001846B31F0-0x00000001846B3250
		protected void ScheduleNoneDependencies(ref NativeList<JobHandle> noneDependencies) {} // 0x00000001846B3250-0x00000001846B3360
		public bool InLowFrameMode(ref GlobalEnv env) => default; // 0x00000001841634B0-0x0000000184163540
		protected bool SpecialEntityExisted(ref EntityManager em) => default; // 0x000000018481DA90-0x000000018481DC00
	}

	public interface IProcessor // TypeDefIndex: 49837
	{
		// Properties
		float interval { get; }
		float curInterval { get; set; }
		string name { get; }
		bool lowFrameEnable { get; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Methods
		void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting);
		JobHandle PreExecute(ref EntityManager em, long time, long dt, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies);
		JobHandle Execute(ref EntityManager em, long time, long dt, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies);
		JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle);
		void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null);
		void TearDown(ref EntityManager em, ref GlobalEnv env);
		bool InLowFrameMode(ref GlobalEnv env);
	}

	public class StructuralChangedAttribute : Attribute // TypeDefIndex: 49838
	{
		// Constructors
		public StructuralChangedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UnsafeJobFuncPointers // TypeDefIndex: 49854
	{
		// Nested types
		public unsafe delegate void ApplyRender(HGFactoryRendererBinderComponent* binder, PerDrawConfig* perDrawConfigs, int length); // TypeDefIndex: 49839; 0x00000001851DE6B0-0x00000001851DE780
	
		public unsafe delegate bool FacRegionPosValid(EntityManager* entityManager, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // TypeDefIndex: 49840; 0x000000018795BCD0-0x000000018795BEB8
	
		public delegate bool QueryStateIconPath(FacBuildingState stateUI, out FixedString32Bytes path, out float4 uv, out float4 color); // TypeDefIndex: 49841; 0x0000000185A816B0-0x0000000185A81780
	
		public delegate FacBuildingState QueryBuildingState(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // TypeDefIndex: 49842; 0x000000018795C224-0x000000018795C2F0
	
		public delegate void SetEntityFlashStatue(ref EntityManager em, ref Entity entity, FacBuildingState statue); // TypeDefIndex: 49843; 0x0000000185F1ABF0-0x0000000185F1AC80
	
		public unsafe delegate void ApplyPerDrawRender_0000085C_PostfixBurstDelegate(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length); // TypeDefIndex: 49844; 0x00000001851DEB50-0x00000001851DEBE0
	
		internal static class ApplyPerDrawRender_0000085C_BurstDirectCall // TypeDefIndex: 49845
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static ApplyPerDrawRender_0000085C_BurstDirectCall() {} // 0x00000001872065E8-0x0000000187206620
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068671) {} // 0x0000000187207114-0x0000000187207140
			private static IntPtr GetFunctionPointer() => default; // 0x00000001851DEAC0-0x00000001851DEB50
			public static void Constructor() {} // 0x00000001817B21C0-0x00000001817B21E0
			public static void Initialize() {} // 0x0000000187959A60-0x0000000187959B3C
			public static unsafe void Invoke(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length) {} // 0x0000000185A818E0-0x0000000185A81970
		}
	
		public delegate bool GetQueryStateIconPath_0000085E_PostfixBurstDelegate(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // TypeDefIndex: 49846; 0x0000000187959964-0x0000000187959A28
	
		internal static class GetQueryStateIconPath_0000085E_BurstDirectCall // TypeDefIndex: 49847
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static GetQueryStateIconPath_0000085E_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068682) {} // 0x0000000181A578C0-0x0000000181A578E0
			private static IntPtr GetFunctionPointer() => default; // 0x000000018795A0F4-0x000000018795A1B0
			public static void Constructor() {} // 0x0000000187209F90-0x0000000187209FB0
			public static void Initialize() {} // 0x00000001876E3384-0x00000001876E3458
			public static bool Invoke(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color) {
				path = default;
				uv = default;
				color = default;
				return default;
			} // 0x00000001879539CC-0x0000000187953A54
		}
	
		public unsafe delegate bool GetLogicEntityWithPos_00000860_PostfixBurstDelegate(EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // TypeDefIndex: 49848; 0x00000001879537D8-0x00000001879538DC
	
		internal static class GetLogicEntityWithPos_00000860_BurstDirectCall // TypeDefIndex: 49849
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static GetLogicEntityWithPos_00000860_BurstDirectCall() {} // 0x00000001817B21C0-0x00000001817B21E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068698) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F485B0-0x0000000185F485C0
			public static void Constructor() {} // 0x0000000187953930-0x00000001879539CC
			public static void Initialize() {} // 0x0000000187955A84-0x0000000187955B4C
			public static unsafe bool Invoke(EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment) {
				unitFragment = default;
				return default;
			} // 0x00000001879559A8-0x0000000187955A84
		}
	
		public delegate FacBuildingState QueryBuildingStateFunc_00000862_PostfixBurstDelegate(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // TypeDefIndex: 49850; 0x00000001879557A4-0x00000001879558A8
	
		internal static class QueryBuildingStateFunc_00000862_BurstDirectCall // TypeDefIndex: 49851
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static QueryBuildingStateFunc_00000862_BurstDirectCall() {} // 0x0000000187955054-0x0000000187955068
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000686aa) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F46FD0-0x0000000185F46FE0
			public static void Constructor() {} // 0x00000001879558FC-0x00000001879559A8
			public static void Initialize() {} // 0x00000001879556D0-0x00000001879557A4
			public static FacBuildingState Invoke(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState) {
				subState = default;
				return default;
			} // 0x0000000187955614-0x00000001879556D0
		}
	
		public delegate void SetEntityFlashStatueFunc_00000864_PostfixBurstDelegate(ref EntityManager em, ref Entity entity, FacBuildingState statue); // TypeDefIndex: 49852; 0x00000001879553D4-0x00000001879554D8
	
		internal static class SetEntityFlashStatueFunc_00000864_BurstDirectCall // TypeDefIndex: 49853
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SetEntityFlashStatueFunc_00000864_BurstDirectCall() {} // 0x00000001817E31E0-0x00000001817E3200
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000686b9) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F47070-0x0000000185F47080
			public static void Constructor() {} // 0x000000018795552C-0x0000000187955614
			public static void Initialize() {} // 0x0000000187959890-0x0000000187959964
			public static void Invoke(ref EntityManager em, ref Entity entity, FacBuildingState statue) {} // 0x00000001879597CC-0x0000000187959890
		}
	
		// Constructors
		public UnsafeJobFuncPointers() {} // 0x0000000187959D6C-0x0000000187959E70
	
		// Methods
		public static FunctionPointer<ApplyRender> GetApplyRenderPointer() => default; // 0x0000000186477E54-0x0000000186477F84
		public static FunctionPointer<FacRegionPosValid> GetFacRegionValid() => default; // 0x00000001879595D4-0x00000001879596D8
		public static unsafe void ApplyPerDrawRender(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length) {} // 0x00000001879596D8-0x000000018795972C
		public static FunctionPointer<QueryStateIconPath> GetQueryStateIconPathFuncPtr() => default; // 0x0000000185F464A0-0x0000000185F46530
		public static bool GetQueryStateIconPath(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color) {
			path = default;
			uv = default;
			color = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public static bool GetLogicEntityWithPosAdapter(ref EntityManager em, float x, float y, float z, out UnitFragment unitFragment) {
			unitFragment = default;
			return default;
		} // 0x0000000185F46490-0x0000000185F464A0
		public static unsafe bool GetLogicEntityWithPos(EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment) {
			unitFragment = default;
			return default;
		} // 0x000000018795972C-0x00000001879597CC
		public static FunctionPointer<QueryBuildingState> GetQueryBuildingStatePointer() => default; // 0x000000018795A020-0x000000018795A0F4
		public static FacBuildingState QueryBuildingStateFunc(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState) {
			subState = default;
			return default;
		} // 0x0000000181A578C0-0x0000000181A578E0
		public static FunctionPointer<SetEntityFlashStatue> GetSetEntityFlashStatuePointer() => default; // 0x0000000187959F64-0x000000018795A020
		public static void SetEntityFlashStatueFunc(ref EntityManager em, ref Entity entity, FacBuildingState statue) {} // 0x00000001864BB614-0x00000001864BB734
		public static unsafe void ApplyPerDrawRender_BurstManaged(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length) {} // 0x0000000187959E70-0x0000000187959EC4
		public static bool GetQueryStateIconPath_BurstManaged(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color) {
			path = default;
			uv = default;
			color = default;
			return default;
		} // 0x0000000185F46400-0x0000000185F46490
		public static unsafe bool GetLogicEntityWithPos_BurstManaged(EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment) {
			unitFragment = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public static FacBuildingState QueryBuildingStateFunc_BurstManaged(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState) {
			subState = default;
			return default;
		} // 0x0000000185F463F0-0x0000000185F46400
		public static void SetEntityFlashStatueFunc_BurstManaged(ref EntityManager em, ref Entity entity, FacBuildingState statue) {} // 0x0000000187959EC4-0x0000000187959F64
	}

	public struct AdditiveEffectJob : IJobParallelForDefer // TypeDefIndex: 49861
	{
		// Fields
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x00
		public long time; // 0x08
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildCurve; // 0x10
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve0; // 0x28
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve1; // 0x40
		public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve0; // 0x58
		public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve1; // 0x70
		public EntityManager em; // 0x88
		public int threadId; // 0x98
		public int frameCount; // 0x9C
		public unsafe SharedDataContainer.SharedExtData* sharedExtDataPtr; // 0xA0
		public NativeQueue<FactoryBuildingEffectData> finishedEffectQueue; // 0xA8
	
		// Nested types
		public delegate bool _BuildDismissState_00000882_PostfixBurstDelegate(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 49855; 0x000000018794EA80-0x000000018794EB00
	
		internal static class _BuildDismissState_00000882_BurstDirectCall // TypeDefIndex: 49856
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BuildDismissState_00000882_BurstDirectCall() {} // 0x000000018794EC18-0x000000018794ECB0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068704) {} // 0x000000018794E010-0x000000018794E024
			private static IntPtr GetFunctionPointer() => default; // 0x000000018794E08C-0x000000018794E2EC
			public static void Constructor() {} // 0x000000018794EE78-0x000000018794F0F8
			public static void Initialize() {} // 0x000000018794F0F8-0x000000018794F26C
			public static bool Invoke(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) => default; // 0x000000018794ECB0-0x000000018794ED24
		}
	
		public delegate bool _Repair0_00000884_PostfixBurstDelegate(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 49857; 0x000000018794EE18-0x000000018794EE78
	
		internal static class _Repair0_00000884_BurstDirectCall // TypeDefIndex: 49858
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair0_00000884_BurstDirectCall() {} // 0x000000018795CAF8-0x000000018795CBCC
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068717) {} // 0x000000018794EB00-0x000000018794EC18
			private static IntPtr GetFunctionPointer() => default; // 0x000000018794DF00-0x000000018794E010
			public static void Constructor() {} // 0x000000018794E024-0x000000018794E058
			public static void Initialize() {} // 0x000000018794E058-0x000000018794E08C
			public static bool Invoke(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x000000018369F530-0x000000018369F550
		}
	
		public delegate bool _Repair1_00000885_PostfixBurstDelegate(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 49859; 0x00000001864BBBD0-0x00000001864BBD00
	
		internal static class _Repair1_00000885_BurstDirectCall // TypeDefIndex: 49860
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1_00000885_BurstDirectCall() {} // 0x000000018795CE78-0x000000018795CF4C
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068726) {} // 0x0000000185F43FC0-0x0000000185F44050
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185492010-0x0000000185492020
			public static void Constructor() {} // 0x0000000185F43FB0-0x0000000185F43FC0
			public static void Initialize() {} // 0x000000018795C8D8-0x000000018795C9B0
			public static bool Invoke(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x00000001817E31E0-0x00000001817E3200
		}
	
		// Methods
		public void SetSharedExtData(IntPtr data) {} // 0x000000018795CDBC-0x000000018795CE78
		public void Execute(int startIndex, int count) {} // 0x00000001864BBBD0-0x00000001864BBD00
		public void Execute(int index) {} // 0x000000018795CBCC-0x000000018795CCD0
		private void _OnStackEmpty(ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData) {} // 0x000000018795CCD0-0x000000018795CD24
		private void _CancelPreState(AdditiveEffectFragment.AdditiveEffectType preState, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData) {} // 0x0000000185F42D00-0x0000000185F42D90
		private void _ResumeState(AdditiveEffectFragment.AdditiveEffectType state, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData) {} // 0x0000000185492010-0x0000000185492020
		private void _SetStateValid(AdditiveEffectFragment.AdditiveEffectType state, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData, bool valid) {} // 0x0000000185F42CF0-0x0000000185F42D00
		private void _UpdateInternalStateLifeCycle(ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData) {} // 0x000000018795CD24-0x000000018795CDBC
		private static bool _BuildDismissState(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) => default; // 0x000000018795CE78-0x000000018795CF4C
		private static void _InitBuildState(ref CutoffState cutoffState, ref BuildDismissState buildDismissState) {} // 0x00000001817E31E0-0x00000001817E3200
		private static bool _Repair0(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x000000018795D13C-0x000000018795F184
		private static bool _Repair1(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x00000001864BBBD0-0x00000001864BBD00
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x000000018795CF4C-0x000000018795D050
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x020611AF */) => default; // 0x000000018795D050-0x000000018795D0A4
		public JobHandle ScheduleDefer(JobHandle jobHandleDep0, JobHandle jobHandleDep1, int innerLoopBatchCount = 1 /* Metadata: 0x020611B0 */) => default; // 0x0000000185F42A80-0x0000000185F42B10
		public static bool _BuildDismissState_BurstManaged(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) => default; // 0x0000000185492010-0x0000000185492020
		public static bool _Repair0_BurstManaged(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x0000000185F42A70-0x0000000185F42A80
		public static bool _Repair1_BurstManaged(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x000000018795D0A4-0x000000018795D13C
	}

	public struct AdditiveEffectQueryJob : IJob // TypeDefIndex: 49862
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		private unsafe EntityQueryV2.QueryResultDefer* m_additiveEffectQr; // 0x18
		private unsafe EntityQueryV2.QueryResultDefer* m_hintEffectQr; // 0x20
		private unsafe EntityQueryV2.QueryResultDefer* m_additiveEffectRendererQr; // 0x28
	
		// Methods
		public void Execute() {} // 0x000000018794F26C-0x000000018794F3F0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer additiveEffectQr, ref EntityQueryV2.QueryResultDefer hintQr, ref EntityQueryV2.QueryResultDefer additiveEffectRendererQr, bool resetQr = true /* Metadata: 0x020611B1 */) {} // 0x00000001843EDE40-0x00000001843EDF50
	}

	public struct AdditiveEffectRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 49945
	{
		// Fields
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x00
		public long time; // 0x08
		public EntityManager rEntityManager; // 0x10
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildCurve; // 0x20
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve0; // 0x38
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve1; // 0x50
		public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve0; // 0x68
		public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve1; // 0x80
		public unsafe SharedDataContainer.SharedExtData* sharedExtDataPtr; // 0x98
	
		// Nested types
		public delegate void _BPBuildStart_0000088E_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 49863; 0x00000001879502B4-0x0000000187950408
	
		internal static class _BPBuildStart_0000088E_BurstDirectCall // TypeDefIndex: 49864
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildStart_0000088E_BurstDirectCall() {} // 0x000000018795019C-0x00000001879501FC
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068892) {} // 0x000000018795062C-0x00000001879506C4
			private static IntPtr GetFunctionPointer() => default; // 0x0000000187950520-0x00000001879505B8
			public static void Constructor() {} // 0x0000000187950254-0x00000001879502B4
			public static void Initialize() {} // 0x00000001879500BC-0x000000018795011C
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x00000001843EDC00-0x00000001843EDC40
		}
	
		public delegate void _BPBuildProcess_0000088F_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 49865; 0x000000018794F3F0-0x000000018794FC28
	
		internal static class _BPBuildProcess_0000088F_BurstDirectCall // TypeDefIndex: 49866
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildProcess_0000088F_BurstDirectCall() {} // 0x00000001879520D0-0x0000000187952130
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000688ad) {} // 0x00000001879516A8-0x0000000187951708
			private static IntPtr GetFunctionPointer() => default; // 0x000000018795116C-0x0000000187951308
			public static void Constructor() {} // 0x0000000187950E38-0x0000000187950FF0
			public static void Initialize() {} // 0x00000001879510D4-0x000000018795116C
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x0000000187951C00-0x0000000187951C60
		}
	
		public delegate void _BPBuildEnd_00000890_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 49867; 0x0000000187951A80-0x0000000187951AE0
	
		internal static class _BPBuildEnd_00000890_BurstDirectCall // TypeDefIndex: 49868
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildEnd_00000890_BurstDirectCall() {} // 0x0000000187952588-0x00000001879525E8
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000688c8) {} // 0x0000000187952464-0x00000001879524D8
			private static IntPtr GetFunctionPointer() => default; // 0x000000018795221C-0x000000018795227C
			public static void Constructor() {} // 0x000000018795227C-0x00000001879522DC
			public static void Initialize() {} // 0x0000000187952A80-0x0000000187952AE0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x0000000187952934-0x0000000187952994
		}
	
		public delegate void _BPBuildCutoffStateStart_00000891_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49869; 0x0000000187952698-0x00000001879526F8
	
		internal static class _BPBuildCutoffStateStart_00000891_BurstDirectCall // TypeDefIndex: 49870
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateStart_00000891_BurstDirectCall() {} // 0x00000001879534DC-0x000000018795355C
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000688db) {} // 0x0000000187953064-0x000000018795313C
			private static IntPtr GetFunctionPointer() => default; // 0x0000000187953204-0x0000000187953284
			public static void Constructor() {} // 0x00000001879535F4-0x0000000187953654
			public static void Initialize() {} // 0x00000001879533EC-0x000000018795344C
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018794E2EC-0x000000018794E75C
		}
	
		public delegate void _BPBuildCutoffStateEnd_00000892_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49871; 0x00000001879509D8-0x0000000187950A4C
	
		internal static class _BPBuildCutoffStateEnd_00000892_BurstDirectCall // TypeDefIndex: 49872
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateEnd_00000892_BurstDirectCall() {} // 0x0000000187951368-0x00000001879513C8
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000688ea) {} // 0x0000000187952E04-0x0000000187952E64
			private static IntPtr GetFunctionPointer() => default; // 0x0000000187952E64-0x0000000187952EC4
			public static void Constructor() {} // 0x00000001879514B4-0x0000000187951514
			public static void Initialize() {} // 0x0000000187951308-0x0000000187951368
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x0000000187953778-0x00000001879537D8
		}
	
		public delegate void _BPBuildCutoffStateProcess_00000893_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49873; 0x0000000187952B74-0x0000000187952BD4
	
		internal static class _BPBuildCutoffStateProcess_00000893_BurstDirectCall // TypeDefIndex: 49874
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateProcess_00000893_BurstDirectCall() {} // 0x0000000187950408-0x0000000187950520
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000688f9) {} // 0x000000018794FE60-0x000000018794FF38
			private static IntPtr GetFunctionPointer() => default; // 0x00000001843ED360-0x00000001843ED490
			public static void Constructor() {} // 0x00000001879506C4-0x0000000187950768
			public static void Initialize() {} // 0x00000001879505B8-0x000000018795062C
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x00000001879501FC-0x0000000187950254
		}
	
		public delegate void _CutoffStateStart_00000897_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49875; 0x000000018795011C-0x000000018795019C
	
		internal static class _CutoffStateStart_00000897_BurstDirectCall // TypeDefIndex: 49876
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateStart_00000897_BurstDirectCall() {} // 0x0000000187951C60-0x0000000187951EB0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068908) {} // 0x0000000187951628-0x00000001879516A8
			private static IntPtr GetFunctionPointer() => default; // 0x0000000187950FF0-0x00000001879510D4
			public static void Constructor() {} // 0x0000000187951F10-0x00000001879520D0
			public static void Initialize() {} // 0x0000000187951AE0-0x0000000187951C00
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x0000000187951A78-0x0000000187951A80
		}
	
		public delegate void _CutoffStateEnd_00000898_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49877; 0x00000001879517FC-0x00000001879518B4
	
		internal static class _CutoffStateEnd_00000898_BurstDirectCall // TypeDefIndex: 49878
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateEnd_00000898_BurstDirectCall() {} // 0x0000000187952758-0x00000001879528D4
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068917) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000187952994-0x0000000187952A80
			public static void Constructor() {} // 0x00000001879524D8-0x0000000187952588
			public static void Initialize() {} // 0x0000000185492010-0x0000000185492020
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x00000001879525E8-0x0000000187952698
		}
	
		public delegate void _CutoffStateProcess_00000899_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49879; 0x000000018795313C-0x0000000187953204
	
		internal static class _CutoffStateProcess_00000899_BurstDirectCall // TypeDefIndex: 49880
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateProcess_00000899_BurstDirectCall() {} // 0x0000000187952EC4-0x0000000187953004
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068926) {} // 0x000000018795344C-0x00000001879534DC
			private static IntPtr GetFunctionPointer() => default; // 0x0000000187950A4C-0x0000000187950D28
			public static void Constructor() {} // 0x00000001879508E8-0x00000001879509D8
			public static void Initialize() {} // 0x0000000187950D88-0x0000000187950DD8
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x0000000187952D90-0x0000000187952E04
		}
	
		public delegate void _BuildStateProcess_0000089C_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 49881; 0x00000001879513C8-0x00000001879514B4
	
		internal static class _BuildStateProcess_0000089C_BurstDirectCall // TypeDefIndex: 49882
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BuildStateProcess_0000089C_BurstDirectCall() {} // 0x000000018771DA00-0x000000018771DA14
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006893d) {} // 0x0000000187953654-0x0000000187953778
			private static IntPtr GetFunctionPointer() => default; // 0x0000000187952BD4-0x0000000187952D30
			public static void Constructor() {} // 0x0000000187952AE0-0x0000000187952B74
			public static void Initialize() {} // 0x000000018796ADD8-0x000000018796AEAC
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018796B434-0x000000018796B57C
		}
	
		public delegate void _HighLightStart_0000089D_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49883; 0x000000018796B214-0x000000018796B318
	
		internal static class _HighLightStart_0000089D_BurstDirectCall // TypeDefIndex: 49884
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightStart_0000089D_BurstDirectCall() {} // 0x000000018771DA00-0x000000018771DA14
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068950) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F44230-0x0000000185F44240
			public static void Constructor() {} // 0x000000018796B36C-0x000000018796B434
			public static void Initialize() {} // 0x000000018796ADD8-0x000000018796AEAC
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796B0CC-0x000000018796B214
		}
	
		public delegate void _HighLightEnd_0000089E_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49885; 0x000000018796AEAC-0x000000018796AFB0
	
		internal static class _HighLightEnd_0000089E_BurstDirectCall // TypeDefIndex: 49886
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightEnd_0000089E_BurstDirectCall() {} // 0x000000018771DA00-0x000000018771DA14
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006895f) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F442D0-0x0000000185F442E0
			public static void Constructor() {} // 0x000000018796B004-0x000000018796B0CC
			public static void Initialize() {} // 0x000000018796ADD8-0x000000018796AEAC
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796AC90-0x000000018796ADD8
		}
	
		public delegate void _HighLightProcess_0000089F_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49887; 0x000000018796AA6C-0x000000018796AB70
	
		internal static class _HighLightProcess_0000089F_BurstDirectCall // TypeDefIndex: 49888
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightProcess_0000089F_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006896e) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F44370-0x0000000185F44380
			public static void Constructor() {} // 0x000000018796ABC4-0x000000018796AC90
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796A9A8-0x000000018796AA6C
		}
	
		public delegate void _FigureStart_000008A0_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49889; 0x000000018796A7BC-0x000000018796A8C0
	
		internal static class _FigureStart_000008A0_BurstDirectCall // TypeDefIndex: 49890
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureStart_000008A0_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006897d) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F44410-0x0000000185F44420
			public static void Constructor() {} // 0x000000018796A914-0x000000018796A9A8
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796A370-0x000000018796A434
		}
	
		public delegate void _FigureProcess_000008A1_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49891; 0x000000018796A180-0x000000018796A284
	
		internal static class _FigureProcess_000008A1_BurstDirectCall // TypeDefIndex: 49892
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureProcess_000008A1_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006898c) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F44550-0x0000000185F44560
			public static void Constructor() {} // 0x000000018796A2D8-0x000000018796A370
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796A6F8-0x000000018796A7BC
		}
	
		public delegate void _FigureEnd_000008A2_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49893; 0x000000018796A508-0x000000018796A60C
	
		internal static class _FigureEnd_000008A2_BurstDirectCall // TypeDefIndex: 49894
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureEnd_000008A2_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006899b) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F444B0-0x0000000185F444C0
			public static void Constructor() {} // 0x000000018796A660-0x000000018796A6F8
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796D198-0x000000018796D25C
		}
	
		public delegate void _HintStart_000008A3_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha); // TypeDefIndex: 49895; 0x000000018796CFA8-0x000000018796D0AC
	
		internal static class _HintStart_000008A3_BurstDirectCall // TypeDefIndex: 49896
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintStart_000008A3_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000689ac) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43B50-0x0000000185F43B60
			public static void Constructor() {} // 0x000000018796D100-0x000000018796D198
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha) {} // 0x000000018796CC30-0x000000018796CCF4
		}
	
		public delegate void _HintEnd_000008A4_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49897; 0x000000018796CA40-0x000000018796CB44
	
		internal static class _HintEnd_000008A4_BurstDirectCall // TypeDefIndex: 49898
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintEnd_000008A4_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000689bc) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43C90-0x0000000185F43CA0
			public static void Constructor() {} // 0x000000018796CB98-0x000000018796CC30
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796CEE4-0x000000018796CFA8
		}
	
		public delegate void _HintProcess_000008A5_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49899; 0x000000018796CCF4-0x000000018796CDF8
	
		internal static class _HintProcess_000008A5_BurstDirectCall // TypeDefIndex: 49900
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintProcess_000008A5_BurstDirectCall() {} // 0x000000018771DA00-0x000000018771DA14
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000689cb) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43BF0-0x0000000185F43C00
			public static void Constructor() {} // 0x000000018796CE4C-0x000000018796CEE4
			public static void Initialize() {} // 0x000000018796ADD8-0x000000018796AEAC
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796C0F4-0x000000018796C23C
		}
	
		public delegate void _OverloadStart_000008A6_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49901; 0x000000018796BEB0-0x000000018796BFB4
	
		internal static class _OverloadStart_000008A6_BurstDirectCall // TypeDefIndex: 49902
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadStart_000008A6_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000689da) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43F10-0x0000000185F43F20
			public static void Constructor() {} // 0x000000018796C008-0x000000018796C0F4
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796E1E4-0x000000018796E2A8
		}
	
		public delegate void _OverloadEnd_000008A7_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49903; 0x000000018796DFF4-0x000000018796E0F8
	
		internal static class _OverloadEnd_000008A7_BurstDirectCall // TypeDefIndex: 49904
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadEnd_000008A7_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000689e9) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F436F0-0x0000000185F43700
			public static void Constructor() {} // 0x000000018796E14C-0x000000018796E1E4
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796DC78-0x000000018796DD3C
		}
	
		public delegate void _OverloadProcess_000008A8_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49905; 0x000000018796DA84-0x000000018796DB88
	
		internal static class _OverloadProcess_000008A8_BurstDirectCall // TypeDefIndex: 49906
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadProcess_000008A8_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000689f8) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43830-0x0000000185F43840
			public static void Constructor() {} // 0x000000018796DBDC-0x000000018796DC78
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796DF30-0x000000018796DFF4
		}
	
		public delegate void _OverloadInvalidStart_000008A9_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49907; 0x000000018796DD3C-0x000000018796DE40
	
		internal static class _OverloadInvalidStart_000008A9_BurstDirectCall // TypeDefIndex: 49908
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidStart_000008A9_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068a07) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43790-0x0000000185F437A0
			public static void Constructor() {} // 0x000000018796DE94-0x000000018796DF30
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796D9C0-0x000000018796DA84
		}
	
		public delegate void _OverloadInvalidEnd_000008AA_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49909; 0x000000018796D7CC-0x000000018796D8D0
	
		internal static class _OverloadInvalidEnd_000008AA_BurstDirectCall // TypeDefIndex: 49910
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidEnd_000008AA_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068a16) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F438D0-0x0000000185F438E0
			public static void Constructor() {} // 0x000000018796D924-0x000000018796D9C0
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796D708-0x000000018796D7CC
		}
	
		public delegate void _OverloadInvalidProcess_000008AB_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49911; 0x000000018796D514-0x000000018796D618
	
		internal static class _OverloadInvalidProcess_000008AB_BurstDirectCall // TypeDefIndex: 49912
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidProcess_000008AB_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068a25) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43970-0x0000000185F43980
			public static void Constructor() {} // 0x000000018796D66C-0x000000018796D708
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796D450-0x000000018796D514
		}
	
		public delegate void _Repair0Process_000008AE_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 49913; 0x000000018796D25C-0x000000018796D360
	
		internal static class _Repair0Process_000008AE_BurstDirectCall // TypeDefIndex: 49914
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair0Process_000008AE_BurstDirectCall() {} // 0x00000001832D8120-0x00000001832D8140
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068a38) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43A10-0x0000000185F43A20
			public static void Constructor() {} // 0x000000018796D3B4-0x000000018796D450
			public static void Initialize() {} // 0x000000018796EB00-0x000000018796EBD4
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x000000018796EA10-0x000000018796EB00
		}
	
		public delegate void _Repair1Start_000008AF_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49915; 0x000000018796E808-0x000000018796E90C
	
		internal static class _Repair1Start_000008AF_BurstDirectCall // TypeDefIndex: 49916
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1Start_000008AF_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068a49) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43510-0x0000000185F43520
			public static void Constructor() {} // 0x000000018796E960-0x000000018796EA10
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796E49C-0x000000018796E560
		}
	
		public delegate void _Repair1End_000008B0_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49917; 0x000000018796E2A8-0x000000018796E3AC
	
		internal static class _Repair1End_000008B0_BurstDirectCall // TypeDefIndex: 49918
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1End_000008B0_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068a58) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43650-0x0000000185F43660
			public static void Constructor() {} // 0x000000018796E400-0x000000018796E49C
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796E744-0x000000018796E808
		}
	
		public delegate void _Repair1Process_000008B1_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 49919; 0x000000018796E560-0x000000018796E664
	
		internal static class _Repair1Process_000008B1_BurstDirectCall // TypeDefIndex: 49920
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1Process_000008B1_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068a6b) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F435B0-0x0000000185F435C0
			public static void Constructor() {} // 0x000000018796E6B8-0x000000018796E744
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x000000018796FB40-0x000000018796FC04
		}
	
		public delegate void _BlueprintProcessInternal_000008B3_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49921; 0x000000018796F94C-0x000000018796FA50
	
		internal static class _BlueprintProcessInternal_000008B3_BurstDirectCall // TypeDefIndex: 49922
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintProcessInternal_000008B3_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068a7c) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43150-0x0000000185F43160
			public static void Constructor() {} // 0x000000018796FAA4-0x000000018796FB40
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796EDC8-0x000000018796EE8C
		}
	
		public delegate void _BlueprintEnd_000008B4_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // TypeDefIndex: 49923; 0x000000018796EBD4-0x000000018796ECD8
	
		internal static class _BlueprintEnd_000008B4_BurstDirectCall // TypeDefIndex: 49924
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintEnd_000008B4_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068a8d) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43470-0x0000000185F43480
			public static void Constructor() {} // 0x000000018796ED2C-0x000000018796EDC8
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer) {} // 0x000000018796F888-0x000000018796F94C
		}
	
		public delegate void _BlueprintStart_000008B5_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49925; 0x000000018796F6A4-0x000000018796F7A8
	
		internal static class _BlueprintStart_000008B5_BurstDirectCall // TypeDefIndex: 49926
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintStart_000008B5_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068a9d) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F431F0-0x0000000185F43200
			public static void Constructor() {} // 0x000000018796F7FC-0x000000018796F888
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796F5E0-0x000000018796F6A4
		}
	
		public delegate void _PreSelectStart_000008B6_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49927; 0x000000018796F3EC-0x000000018796F4F0
	
		internal static class _PreSelectStart_000008B6_BurstDirectCall // TypeDefIndex: 49928
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectStart_000008B6_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068aac) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43290-0x0000000185F432A0
			public static void Constructor() {} // 0x000000018796F544-0x000000018796F5E0
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796F080-0x000000018796F144
		}
	
		public delegate void _PreSelectEnd_000008B7_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49929; 0x000000018796EE8C-0x000000018796EF90
	
		internal static class _PreSelectEnd_000008B7_BurstDirectCall // TypeDefIndex: 49930
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectEnd_000008B7_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068abb) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F433D0-0x0000000185F433E0
			public static void Constructor() {} // 0x000000018796EFE4-0x000000018796F080
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796F328-0x000000018796F3EC
		}
	
		public delegate void _PreSelectProcess_000008B8_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49931; 0x000000018796F144-0x000000018796F248
	
		internal static class _PreSelectProcess_000008B8_BurstDirectCall // TypeDefIndex: 49932
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectProcess_000008B8_BurstDirectCall() {} // 0x00000001817C0490-0x00000001817C04B0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068aca) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F43330-0x0000000185F43340
			public static void Constructor() {} // 0x000000018796F29C-0x000000018796F328
			public static void Initialize() {} // 0x0000000187970CA8-0x0000000187970D7C
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000187970B94-0x0000000187970CA8
		}
	
		public delegate void _ContinuationStart_000008B9_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49933; 0x000000018797097C-0x0000000187970A80
	
		internal static class _ContinuationStart_000008B9_BurstDirectCall // TypeDefIndex: 49934
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationStart_000008B9_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068ad9) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F42D90-0x0000000185F42DA0
			public static void Constructor() {} // 0x0000000187970AD4-0x0000000187970B94
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000187971548-0x000000018797160C
		}
	
		public delegate void _ContinuationEnd_000008BA_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49935; 0x0000000187971358-0x000000018797145C
	
		internal static class _ContinuationEnd_000008BA_BurstDirectCall // TypeDefIndex: 49936
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationEnd_000008BA_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068ae8) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F42B10-0x0000000185F42B20
			public static void Constructor() {} // 0x00000001879714B0-0x0000000187971548
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000187970F68-0x000000018797102C
		}
	
		public delegate void _ContinuationProcess_000008BB_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49937; 0x0000000187970D7C-0x0000000187970E80
	
		internal static class _ContinuationProcess_000008BB_BurstDirectCall // TypeDefIndex: 49938
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationProcess_000008BB_BurstDirectCall() {} // 0x00000001817C0490-0x00000001817C04B0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068af7) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F42C50-0x0000000185F42C60
			public static void Constructor() {} // 0x0000000187970ED4-0x0000000187970F68
			public static void Initialize() {} // 0x0000000187970CA8-0x0000000187970D7C
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000187971244-0x0000000187971358
		}
	
		public delegate void _SocialSharingStart_000008BC_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49939; 0x000000018797102C-0x0000000187971130
	
		internal static class _SocialSharingStart_000008BC_BurstDirectCall // TypeDefIndex: 49940
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SocialSharingStart_000008BC_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068b06) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F42BB0-0x0000000185F42BC0
			public static void Constructor() {} // 0x0000000187971184-0x0000000187971244
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796BB34-0x000000018796BBF8
		}
	
		public delegate void _PowerInteractionStart_000008BD_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49941; 0x000000018796B940-0x000000018796BA44
	
		internal static class _PowerInteractionStart_000008BD_BurstDirectCall // TypeDefIndex: 49942
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PowerInteractionStart_000008BD_BurstDirectCall() {} // 0x00000001832D8120-0x00000001832D8140
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068b15) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F440F0-0x0000000185F44100
			public static void Constructor() {} // 0x000000018796BA98-0x000000018796BB34
			public static void Initialize() {} // 0x000000018796B86C-0x000000018796B940
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796B77C-0x000000018796B86C
		}
	
		public delegate void _PowerInteractionEnd_000008BE_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49943; 0x000000018796B57C-0x000000018796B680
	
		internal static class _PowerInteractionEnd_000008BE_BurstDirectCall // TypeDefIndex: 49944
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PowerInteractionEnd_000008BE_BurstDirectCall() {} // 0x0000000181A578C0-0x0000000181A578E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068b24) {} // 0x0000000185492010-0x0000000185492020
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185F44190-0x0000000185F441A0
			public static void Constructor() {} // 0x000000018796B6D4-0x000000018796B77C
			public static void Initialize() {} // 0x000000018796A434-0x000000018796A508
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796BDEC-0x000000018796BEB0
		}
	
		// Methods
		private void _BPNormalEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001864BB614-0x00000001864BB734
		private void _BPBuildEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796BBF8-0x000000018796BCFC
		private void _BPBuildCutoffEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796BCFC-0x000000018796BD50
		private static void _BPBuildStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x0000000185F44060-0x0000000185F440F0
		private static void _BPBuildProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x0000000185492010-0x0000000185492020
		private static void _BPBuildEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x0000000185F44050-0x0000000185F44060
		private static void _BPBuildCutoffStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018796BD50-0x000000018796BDEC
		private static void _BPBuildCutoffStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018796A434-0x000000018796A508
		private static void _BPBuildCutoffStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x0000000181A578C0-0x0000000181A578E0
		public void SetSharedExtData(IntPtr data) {} // 0x00000001879708B8-0x000000018797097C
		public void Execute(int startIndex, int count) {} // 0x00000001864BB614-0x00000001864BB734
		public void Execute(int index) {} // 0x00000001879706C8-0x00000001879707CC
		private static void _CutoffStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x00000001879707CC-0x0000000187970820
		private static void _CutoffStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x0000000185F42E40-0x0000000185F42ED0
		private static void _CutoffStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x0000000185492010-0x0000000185492020
		private static void _BuildStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x0000000185F42E30-0x0000000185F42E40
		private static void _BuildStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x0000000187970820-0x00000001879708B8
		private static void _BuildStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018796A434-0x000000018796A508
		private static void _HighLightStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000181A578C0-0x0000000181A578E0
		private static void _HighLightEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018797035C-0x0000000187970420
		private static void _HighLightProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001864BB614-0x00000001864BB734
		private static void _FigureStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000187970170-0x0000000187970274
		private static void _FigureProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000187970274-0x00000001879702C8
		private static void _FigureEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185F42F80-0x0000000185F43010
		private static void _HintStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha) {} // 0x0000000185492010-0x0000000185492020
		private static void _HintEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185F42F70-0x0000000185F42F80
		private static void _HintProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001879702C8-0x000000018797035C
		private static void _OverloadStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796A434-0x000000018796A508
		private static void _OverloadEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000181A578C0-0x0000000181A578E0
		private static void _OverloadProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000187970604-0x00000001879706C8
		private static void _OverloadInvalidStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001864BB614-0x00000001864BB734
		private static void _OverloadInvalidEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000187970420-0x0000000187970524
		private static void _OverloadInvalidProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000187970524-0x0000000187970578
		private static void _Repair0Start(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185F42EE0-0x0000000185F42F70
		private static void _Repair0End(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185492010-0x0000000185492020
		private static void _Repair0Process(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x0000000185F42ED0-0x0000000185F42EE0
		private static void _Repair1Start(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000187970578-0x0000000187970604
		private static void _Repair1End(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796A434-0x000000018796A508
		private static void _Repair1Process(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x0000000181A578C0-0x0000000181A578E0
		private static void _BlueprintProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer) {} // 0x000000018796C97C-0x000000018796CA40
		private static void _BlueprintProcessInternal(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001864BB614-0x00000001864BB734
		private static void _BlueprintEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer) {} // 0x000000018796C78C-0x000000018796C890
		private static void _BlueprintStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796C890-0x000000018796C8E4
		private static void _PreSelectStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185F43D40-0x0000000185F43DD0
		private static void _PreSelectEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185492010-0x0000000185492020
		private static void _PreSelectProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185F43D30-0x0000000185F43D40
		private static void _ContinuationStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796C8E4-0x000000018796C97C
		private static void _ContinuationEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796A434-0x000000018796A508
		private static void _ContinuationProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000181A578C0-0x0000000181A578E0
		private static void _SocialSharingStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796C420-0x000000018796C4E4
		private static void _PowerInteractionStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001864BB614-0x00000001864BB734
		private static void _PowerInteractionEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796C23C-0x000000018796C340
		public static void ResetMaterial(ref HGFactoryRendererBinderComponent rendererBinder, ref SharedDataContainer.SharedExtData extData, bool resetRenderPass = true /* Metadata: 0x020611B2 */, bool resetAdditiveMat = true /* Metadata: 0x020611B3 */) {} // 0x000000018796C340-0x000000018796C394
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x0000000185F43E80-0x0000000185F43F10
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x020611B4 */) => default; // 0x0000000185492010-0x0000000185492020
		public JobHandle ScheduleDefer(JobHandle jobHandleDep0, JobHandle jobHandleDep1, int innerLoopBatchCount = 1 /* Metadata: 0x020611B5 */) => default; // 0x0000000185F43E70-0x0000000185F43E80
		public static void _BPBuildStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018796C394-0x000000018796C420
		public static void _BPBuildProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018796A434-0x000000018796A508
		public static void _BPBuildEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x0000000181A578C0-0x0000000181A578E0
		public static void _BPBuildCutoffStateStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018796C6C8-0x000000018796C78C
		public static void _BPBuildCutoffStateEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x00000001864BB614-0x00000001864BB734
		public static void _BPBuildCutoffStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018796C4E4-0x000000018796C5E8
		public static void _CutoffStateStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018796C5E8-0x000000018796C63C
		public static void _CutoffStateEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x0000000185F43DE0-0x0000000185F43E70
		public static void _CutoffStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x0000000185492010-0x0000000185492020
		public static void _BuildStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x0000000185F43DD0-0x0000000185F43DE0
		public static void _HighLightStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796C63C-0x000000018796C6C8
		public static void _HighLightEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796A434-0x000000018796A508
		public static void _HighLightProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000181A578C0-0x0000000181A578E0
		public static void _FigureStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001879717FC-0x0000000187971974
		public static void _FigureProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001864BB614-0x00000001864BB734
		public static void _FigureEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018797160C-0x0000000187971710
		public static void _HintStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha) {} // 0x0000000187971710-0x0000000187971764
		public static void _HintEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185F429E0-0x0000000185F42A70
		public static void _HintProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185492010-0x0000000185492020
		public static void _OverloadStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185F429D0-0x0000000185F429E0
		public static void _OverloadEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000187971764-0x00000001879717FC
		public static void _OverloadProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796A434-0x000000018796A508
		public static void _OverloadInvalidStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000181A578C0-0x0000000181A578E0
		public static void _OverloadInvalidEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001879700AC-0x0000000187970170
		public static void _OverloadInvalidProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001864BB614-0x00000001864BB734
		public static void _Repair0Process_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x000000018796FEB8-0x000000018796FFBC
		public static void _Repair1Start_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796FFBC-0x0000000187970010
		public static void _Repair1End_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185F43020-0x0000000185F430B0
		public static void _Repair1Process_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x0000000185492010-0x0000000185492020
		public static void _BlueprintProcessInternal_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185F43010-0x0000000185F43020
		public static void _BlueprintEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer) {} // 0x0000000187970010-0x00000001879700AC
		public static void _BlueprintStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796A434-0x000000018796A508
		public static void _PreSelectStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000181A578C0-0x0000000181A578E0
		public static void _PreSelectEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796FDF4-0x000000018796FEB8
		public static void _PreSelectProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001864BB614-0x00000001864BB734
		public static void _ContinuationStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796FC04-0x000000018796FD08
		public static void _ContinuationEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796FD08-0x000000018796FD5C
		public static void _ContinuationProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185F430C0-0x0000000185F43150
		public static void _SocialSharingStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185492010-0x0000000185492020
		public static void _PowerInteractionStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x0000000185F430B0-0x0000000185F430C0
		public static void _PowerInteractionEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018796FD5C-0x000000018796FDF4
	}

	public static class AudioJobs // TypeDefIndex: 49952
	{
		// Nested types
		public struct FAggregateEmitterTempData // TypeDefIndex: 49946
		{
			// Fields
			public float3 sumPos; // 0x00
			public float sumWeight; // 0x0C
			public int count; // 0x10
		}
	
		public struct FWaterPipeEmitterData // TypeDefIndex: 49947
		{
			// Fields
			public float3 posData; // 0x00
			public float2 extraData; // 0x0C
			public float sumWeight; // 0x14
			public int count; // 0x18
		}
	
		public struct FGroupEmitterTempData // TypeDefIndex: 49948
		{
			// Fields
			public float3x3 sumPos; // 0x00
			public float3 sumWeight; // 0x24
			public float3 count; // 0x30
			public int inMainRegionActiveCount; // 0x3C
		}
	
		public struct AudioDistanceAndCullingJob : IJobParallelFor // TypeDefIndex: 49949
		{
			// Fields
			public float cullingCullDistanceSq; // 0x00
			public float cullingRestoreDistanceSq; // 0x04
			public float3 listenerPos; // 0x08
			public EntityQueryV2.QueryResult qr; // 0x18
	
			// Methods
			public void Execute(int index) {} // 0x000000018795F184-0x000000018795F41C
		}
	
		public struct AudioGroupEmitterJob : IJobParallelFor // TypeDefIndex: 49950
		{
			// Fields
			public float3 listenerPos; // 0x00
			public float innerRadiusSq; // 0x0C
			public float outerRadiusSq; // 0x10
			public EntityQueryV2.QueryResult qr; // 0x18
			public NativeArray<FGroupEmitterTempData> tempEmitterData; // 0x38
			public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x48
	
			// Methods
			public void Execute(int index) {} // 0x0000000185492010-0x0000000185492020
			public void SetSharedExtData(IntPtr data) {} // 0x000000018795F5F8-0x000000018795F814
		}
	
		public struct WaterPipeEmitterJob : IJobParallelFor // TypeDefIndex: 49951
		{
			// Fields
			public float3 listenerPos; // 0x00
			public EntityQueryV2.QueryResult qr; // 0x10
			public NativeArray<FWaterPipeEmitterData> tempEmitterData; // 0x30
			public float outerRadiusSq; // 0x40
			public unsafe GlobalEnv* envPtr; // 0x48
	
			// Methods
			public void Execute(int index) {} // 0x000000018795F814-0x000000018795FE30
			private void _DoCalculate(int index, ref PipeFragment unit) {} // 0x0000000185197E30-0x0000000185197E70
			public void SetGlobalEnv(ref GlobalEnv env) {} // 0x0000000187969D54-0x0000000187969EC4
		}
	
		// Methods
		private static void _EntityIdx(int groupIdx, EntityQueryV2.BlockRange blockRange, GroupType group, out int startEntityIdx, out int endEntityIdx) {
			startEntityIdx = default;
			endEntityIdx = default;
		} // 0x0000000187969EC4-0x000000018796A180
		private static void _SetDebugGizmosType(ref AudioFragment audioFrag, AudioDebugGizmosType t) {} // 0x0000000185170130-0x0000000185170170
	}

	public struct BatchArrowJob : IJob // TypeDefIndex: 49953
	{
		// Fields
		public EntityManager em; // 0x00
		public float4 forbiddenColor; // 0x10
		public float4 evaluatedColor; // 0x20
		public EntityQueryV2.QueryResult normalQr; // 0x30
		public EntityQueryV2.QueryResult previewQr; // 0x50
		public GlobalEnv globalEnv; // 0x70
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x4E8
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x4F0
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x4F8
		public float4 normalColor; // 0x500
		private int m_threadIndex; // 0x510
	
		// Methods
		private void _ExecutePort(int index, EntityQueryV2.QueryResult qr) {} // 0x0000000187960B9C-0x0000000187961244
		private void _ExecutePreview(int index, EntityQueryV2.QueryResult qr) {} // 0x0000000187961244-0x00000001879617BC
		public void Execute(int index) {} // 0x000000018795FEE8-0x000000018795FFAC
		private void _BatchPortArrow(bool formulaManMode, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, float mapHeightValue, bool inOut, bool preview = false /* Metadata: 0x020611B6 */, bool inBuildMode = false /* Metadata: 0x020611B7 */, bool inMainRegion = true /* Metadata: 0x020611B8 */, bool buildingBelt = true /* Metadata: 0x020611B9 */, bool buildingPipe = true /* Metadata: 0x020611BA */, bool blueprintSelectedUnit = false /* Metadata: 0x020611BB */, bool inputDisabled = false /* Metadata: 0x020611BC */, bool outputDisabled = false /* Metadata: 0x020611BD */, bool inputFluidDisabled = false /* Metadata: 0x020611BE */, bool outputFluidDisabled = false /* Metadata: 0x020611BF */) {} // 0x000000018795FFAC-0x0000000187960B9C
		public void SetSharedExtData(IntPtr data) {} // 0x0000000185296B80-0x0000000185296BC0
		public void Execute() {} // 0x000000018795FE30-0x000000018795FEE8
	}

	public struct BatchInsideConveyorJob : IJob // TypeDefIndex: 49954
	{
		// Fields
		public EntityQueryV2.QueryResult normalQr; // 0x00
		public GlobalEnv globalEnv; // 0x20
		public UnsafeList<float4x4> conveyorInsideMatrices; // 0x498
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x4A0
		private int m_threadIndex; // 0x4A8
	
		// Methods
		public void Execute(int index) {} // 0x00000001879617BC-0x0000000187961834
		private void _CollectInsideConveyor(int index, EntityQueryV2.QueryResult qr) {} // 0x0000000187961CCC-0x00000001879621B8
		private void _BatchPortInside(uint nodeId, float3 pos, quaternion rot, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, ref ComplexPortFragment ports, bool bInOut, float mapHeightValue, bool blueprintSelectedUnit) {} // 0x00000001879618B0-0x0000000187961CCC
		public void SetSharedExtData(IntPtr data) {} // 0x0000000185296B40-0x0000000185296B80
		public void Execute() {} // 0x0000000187961834-0x00000001879618B0
	}

	public struct BatchNormalArrowJob : IJob // TypeDefIndex: 49955
	{
		// Fields
		public EntityManager em; // 0x00
		public float4 forbiddenColor; // 0x10
		public float4 evaluatedColor; // 0x20
		public EntityQueryV2.QueryResult normalQr; // 0x30
		public GlobalEnv globalEnv; // 0x50
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x4C8
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x4D0
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x4D8
		public float4 normalColor; // 0x4E0
		public UnsafeParallelHashMap<int, bool> arrowPlacedDic; // 0x4F0
		private int m_threadIndex; // 0x500
	
		// Methods
		private void _ExecutePort(int index, EntityQueryV2.QueryResult qr) {} // 0x0000000187962F58-0x00000001879635F0
		private void _BatchPortArrow(uint nodeId, bool formulaManMode, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, float mapHeightValue, bool inOut, bool inBuildMode = false /* Metadata: 0x020611C0 */, bool inMainRegion = true /* Metadata: 0x020611C1 */, bool buildingBelt = true /* Metadata: 0x020611C2 */, bool buildingPipe = true /* Metadata: 0x020611C3 */, bool inputDisabled = false /* Metadata: 0x020611C4 */, bool outputDisabled = false /* Metadata: 0x020611C5 */, bool inputFluidDisabled = false /* Metadata: 0x020611C6 */, bool outputFluidDisabled = false /* Metadata: 0x020611C7 */) {} // 0x0000000187962314-0x0000000187962F58
		public void Execute(int index) {} // 0x0000000187962240-0x00000001879622B8
		public void Execute() {} // 0x00000001879621B8-0x0000000187962240
		public void SetSharedExtData(IntPtr data) {} // 0x00000001879622B8-0x0000000187962314
	}

	public struct BatchPreviewArrowJob : IJob // TypeDefIndex: 49956
	{
		// Fields
		public EntityManager em; // 0x00
		public EntityQueryV2.QueryResult previewQr; // 0x10
		public GlobalEnv globalEnv; // 0x30
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x4A8
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x4B0
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x4B8
		public float4 normalColor; // 0x4C0
		public UnsafeParallelHashMap<int, bool> arrowPlacedDic; // 0x4D0
		private int m_threadIndex; // 0x4E0
	
		// Methods
		public void Execute() {} // 0x00000001879635F0-0x000000018796368C
		private void _ExecutePreview(int index, EntityQueryV2.QueryResult qr) {} // 0x00000001879640A8-0x00000001879645D4
		private void _BatchPortArrow(bool formulaManMode, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, float mapHeightValue, bool inOut, bool inBuildMode = false /* Metadata: 0x020611C8 */, bool inMainRegion = true /* Metadata: 0x020611C9 */) {} // 0x00000001879636E8-0x00000001879640A8
		public void SetSharedExtData(IntPtr data) {} // 0x000000018796368C-0x00000001879636E8
	}

	public struct BufferSwapJob : IJob // TypeDefIndex: 49957
	{
		// Fields
		public unsafe GlobalEnv* globalEnvPtr; // 0x00
		public bool bConveyorSwap; // 0x08
		public bool bGuideFigureSwap; // 0x09
		public bool bPreviewConveyorSwap; // 0x0A
		public bool bPipeSwap; // 0x0B
		public bool bPortArrowSwap; // 0x0C
		public bool bCargoSwap; // 0x0D
		public bool bWireSwap; // 0x0E
	
		// Methods
		public void Execute() {} // 0x00000001879645D4-0x000000018796468C
	}

	public struct BuildingLiquidRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 49958
	{
		// Fields
		public EntityManager em; // 0x00
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x10
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x18
	
		// Methods
		public void Execute(int index) {} // 0x000000018796468C-0x0000000187964CB4
		private void _ApplyLiquidPerDraw(Entity rEntity, ValueTuple<int, uint> liquidData) {} // 0x00000001818A70E0-0x00000001818A80D0
		public void Execute(int startIndex, int count) {} // 0x0000000187964CB4-0x0000000187964D34
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x000000018481D460-0x000000018481D4A0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x020611CA */) => default; // 0x000000018481D7B0-0x000000018481D860
		public void SetSharedExtData(IntPtr data) {} // 0x000000018481D4A0-0x000000018481D4E0
	}

	public struct BuildingStatePosCollectJob : IJob // TypeDefIndex: 49959
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public float offsetY; // 0x20
		public FunctionPointer<UnsafeJobFuncPointers.QueryStateIconPath> queryStateIconPath; // 0x28
		public UnsafeList<float4x4> statePosList; // 0x30
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
		public bool isInFight; // 0x40
	
		// Methods
		public void Execute(int index) {} // 0x0000000187964D34-0x0000000187964F8C
		private void _Collect(ref UnitFragment unit, ref UnitTransFragment trans, ref UnitConfigFragment config, ref UnitStatusFragment status, ref SharedDataFragment sharedData) {} // 0x0000000187965094-0x00000001879655EC
		public void Execute(int startIndex, int count) {} // 0x0000000187964F8C-0x0000000187965018
		public void Execute() {} // 0x0000000187965018-0x0000000187965094
		public void SetSharedExtData(IntPtr data) {} // 0x00000001852A3AA0-0x00000001852A3AE0
	}

	public struct BuildingStateRendererJob : IJobParallelFor // TypeDefIndex: 49960
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<float4x4> statePosList; // 0x20
	
		// Methods
		public void Execute(int index) {} // 0x00000001879655EC-0x000000018796579C
	}

	public struct CargoCollectJob : IJob // TypeDefIndex: 49961
	{
		// Fields
		public float offsetY; // 0x00
		public EntityQueryV2.QueryResult qr; // 0x08
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* rendererList; // 0x28
		public unsafe GlobalEnv* env; // 0x30
		public unsafe ConveyorExtContainer.ConveyorExt* conveyorExtData; // 0x38
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x40
	
		// Methods
		public void Execute(int index) {} // 0x000000018796579C-0x0000000187965970
		private unsafe void _Collect(CargoFragment* cargoFrag, ref SharedDataContainer.SharedExtData extData, ref ConveyorExtContainer.ConveyorExt conveyorExt) {} // 0x0000000187965A1C-0x0000000187965C4C
		public void Execute() {} // 0x0000000187965970-0x0000000187965A1C
		public void SetGlobalEnvRef(ref GlobalEnv envRef) {} // 0x0000000185296AC0-0x0000000185296B00
		public void SetConveyorExtData(IntPtr data) {} // 0x0000000185296B00-0x0000000185296B40
		public void SetSharedExtData(IntPtr data) {} // 0x0000000185296A80-0x0000000185296AC0
	}

	public struct CargoPredictJob : IJobParallelFor, IJobParallelForDefer // TypeDefIndex: 49962
	{
		// Fields
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x00
		public EntityManager em; // 0x08
		public long serverTime; // 0x18
		public unsafe ConveyorExtContainer.ConveyorExt* conveyorExtData; // 0x20
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x28
		public unsafe GlobalEnv* env; // 0x30
	
		// Methods
		public void Execute(int index) {} // 0x0000000187965C4C-0x0000000187966068
		public void SetConveyorExtData(IntPtr data) {} // 0x00000001843EB1E0-0x00000001843EB220
		public void SetSharedExtData(IntPtr data) {} // 0x00000001843EB220-0x00000001843EB260
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x00000001843EB260-0x00000001843EB2A0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x020611CB */) => default; // 0x00000001843EB5B0-0x00000001843EB660
	}

	public struct CargoPredictQueryJob : IJob // TypeDefIndex: 49963
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute() {} // 0x0000000187966068-0x0000000187966144
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x020611CC */) {} // 0x00000001843EDC40-0x00000001843EDCC0
	}

	public struct CargoRenderJob : IJobParallelForDefer, IJobParallelFor // TypeDefIndex: 49964
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* rendererList; // 0x20
	
		// Methods
		public void Execute(int index) {} // 0x0000000187966144-0x00000001879662D0
		public void SetRendererList(IntPtr data) {} // 0x0000000184825C00-0x0000000184825C40
	}

	public struct CargoRenderQueryJob : IJob // TypeDefIndex: 49965
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute() {} // 0x00000001879662D0-0x000000018796638C
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x020611CD */) {} // 0x000000018796638C-0x0000000187966408
	}

	public struct ConveyorCollectJob : IJob // TypeDefIndex: 49966
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* lPosList; // 0x20
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* mPosList; // 0x28
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* rPosList; // 0x30
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
		public unsafe GlobalEnv* globalEnvPtr; // 0x40
	
		// Methods
		public void Execute(int index) {} // 0x0000000187966408-0x00000001879665C0
		private void _Collect(ref ConveyorFragment conveyor, ref SharedDataFragment sharedDataFrag, bool preview, bool valid) {} // 0x00000001879666C8-0x0000000187966AAC
		public void Execute(int startIndex, int count) {} // 0x00000001879665C0-0x000000018796664C
		public void Execute() {} // 0x000000018796664C-0x00000001879666C8
		public void SetSharedExtData(IntPtr data) {} // 0x000000018518B340-0x000000018518B3C0
	}

	public struct ConveyorFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 49967
	{
		// Fields
		public int startOffsetIndex; // 0x00
		public float conveyorOffsetY; // 0x04
		public float simpleDrawingType; // 0x08
		public IntPtr dataMatrices; // 0x10
		public NativeArray<Entity> rendererEntities; // 0x18
		public EntityManager em; // 0x28
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
	
		// Methods
		public void Execute(int index) {} // 0x0000000187966B38-0x0000000187966D1C
		private void _UpdateCachedConveyor(Entity cachedEntity, uint sharedDataHandle, float adjustGroundHeight, float3 pos, float3 rot, float conveyorIdx, float conveyorLength, float speed, bool preview, float offsetY, bool valid = true /* Metadata: 0x020611CE */, bool highlight = false /* Metadata: 0x020611CF */, bool selectTypeInvalid = true /* Metadata: 0x020611D0 */) {} // 0x0000000187966D1C-0x0000000187966F78
		public void Execute(int startIndex, int count) {} // 0x0000000187966AAC-0x0000000187966B38
		public void SetSharedExtData(IntPtr data) {} // 0x0000000184D39C00-0x0000000184D39C40
	}

	public struct ConveyorInsideRenderJob : IJobParallelFor // TypeDefIndex: 49968
	{
		// Fields
		public UnsafeList<float4x4> matrices; // 0x00
		public NativeArray<Entity> renderEntities; // 0x10
		public UnityEngine.Color beltInsideColor; // 0x20
		public float speed; // 0x30
		public float offsetY; // 0x34
		public EntityManager em; // 0x38
		public NativeArray<PerDrawConfig> perDrawConfigs; // 0x48
		public NativeArray<PerDrawConfig> blueprintPerDrawConfigs; // 0x58
		public FunctionPointer<UnsafeJobFuncPointers.ApplyRender> applyRenderFunc; // 0x68
	
		// Methods
		public void Execute(int index) {} // 0x0000000187966F78-0x00000001879671FC
	}

	public struct ConveyorPreviewCollectJob : IJob // TypeDefIndex: 49969
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* lPosList; // 0x20
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* mPosList; // 0x28
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* rPosList; // 0x30
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
		public unsafe GlobalEnv* globalEnvPtr; // 0x40
		public unsafe void* conveyorInfoAllocatorPtr; // 0x48
	
		// Methods
		public void Execute(int index) {} // 0x00000001879671FC-0x00000001879673D0
		private void _Collect(ref ConveyorPreviewRendererFragment conveyor, ref SharedDataFragment sharedData, bool preview, bool valid) {} // 0x000000018796744C-0x000000018796766C
		public void Execute() {} // 0x00000001879673D0-0x000000018796744C
		public void SetSharedExtData(IntPtr data) {} // 0x0000000185296A40-0x0000000185296A80
	}

	public struct ConveyorRendererJob : IJobParallelForBatch // TypeDefIndex: 49970
	{
		// Fields
		public float conveyorOffsetY; // 0x00
		public EntityManager em; // 0x08
		public NativeArray<Entity> rendererEntities; // 0x18
		public IntPtr dataMatrices; // 0x28
		public IntPtr previewDataMatrices; // 0x30
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
	
		// Methods
		public void Execute(int index) {} // 0x00000001879676EC-0x000000018796793C
		private void _UpdateCachedConveyor(Entity cachedEntity, float adjustGroundHeight, uint sharedDataHandle, float3 pos, float3 rot, float conveyorIdx, float conveyorLength, float speed, bool preview, BlueprintState.EffectType blueprintRenderType, float offsetY, uint lightMode, bool valid = true /* Metadata: 0x020611D1 */, bool highlight = false /* Metadata: 0x020611D2 */, bool selectTypeInvalid = true /* Metadata: 0x020611D3 */) {} // 0x000000018796793C-0x0000000187967E14
		public void Execute(int startIndex, int count) {} // 0x000000018796766C-0x00000001879676EC
		public void SetSharedExtData(IntPtr data) {} // 0x0000000184D396F0-0x0000000184D39730
	}

	public struct InteractFacCollectJob : IJob // TypeDefIndex: 49974
	{
		// Fields
		public float3 targetPosition; // 0x00
		public float3 targetForward; // 0x0C
		public float maxAngle; // 0x18
		public float maxDist; // 0x1C
		public float radiusExpand; // 0x20
		public const float ROLE_HIGH_ADDED_VALUE = 2f; // Metadata: 0x020611D4
		public const float PIPE_HEIGHT_RANGE = 4f; // Metadata: 0x020611D8
		public EntityManager em; // 0x28
		public EntityQueryV2.QueryResult buildingQr; // 0x38
		public EntityQueryV2.QueryResult pipeRendererQr; // 0x58
		public EntityQueryV2.QueryResult conveyorRendererQr; // 0x78
		public unsafe BuildingInfoWrap* mNearBuildingInfo; // 0x98
		public unsafe LogisticInfo* mConveyorInfo; // 0xA0
		public unsafe LogisticInfo* mPipeInfo; // 0xA8
		public unsafe BuildingInfoWrap* mNearBuildingInfoLast; // 0xB0
		public unsafe LogisticInfo* mConveyorInfoLast; // 0xB8
		public unsafe LogisticInfo* mPipeInfoLast; // 0xC0
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0xC8
		private static readonly FixedList512Bytes<float3> LOGISTIC_INTERACT_SAMPLE_OFFSETS; // 0x00
	
		// Nested types
		public struct BuildingInfoWrap // TypeDefIndex: 49971
		{
			// Fields
			public BuildingInfo buildingInfo; // 0x00
			private UnitConfigFragment _unitConfig_k__BackingField; // 0x54
	
			// Properties
			public UnitConfigFragment unitConfig { get; set; } // 0x0000000187969CC8-0x0000000187969D54 0x0000000187967E14-0x0000000187967EAC
	
			// Methods
			public unsafe void SwapTo(BuildingInfoWrap* other) {} // 0x000000018796830C-0x000000018796946C
		}
	
		public struct BuildingInfo // TypeDefIndex: 49972
		{
			// Fields
			public bool valid; // 0x00
			public int chapterId; // 0x04
			public int pendingSlotId; // 0x08
			public uint nodeId; // 0x0C
			public uint sharedDataHandle; // 0x10
			public int subIndex; // 0x14
			public float adjustMapHeight; // 0x18
			public float3 position; // 0x1C
			public float3 rotation; // 0x28
			public float3 subPosition; // 0x34
			public float3 subRotation; // 0x40
			public float subDist; // 0x4C
			public int templateNameFastString; // 0x50
	
			// Properties
			public string templateName { get => default; set {} } // 0x000000018796946C-0x0000000187969764 0x0000000187969764-0x0000000187969A90
	
			// Methods
			public override string ToString() => default; // 0x0000000187967EAC-0x000000018796830C
			public void SetData(in BuildingInfo info) {} // 0x0000000187969A90-0x0000000187969CC8
			public bool IsPending() => default; // 0x000000018515D080-0x000000018515D110
			public string __iFixBaseProxy_ToString() => default; // 0x0000000185AE7410-0x0000000185AE7740
		}
	
		public struct LogisticInfo // TypeDefIndex: 49973
		{
			// Fields
			public bool valid; // 0x00
			public bool isConveyor; // 0x01
			public int pendingSlotId; // 0x04
			public int chapterId; // 0x08
			public uint nodeId; // 0x0C
			public int uintIndex; // 0x10
			public float3 position; // 0x14
	
			// Methods
			public bool IsPending() => default; // 0x0000000185FB7C20-0x0000000185FB7C60
			public unsafe void SwapTo(LogisticInfo* other) {} // 0x0000000185FB7C60-0x0000000185FB7CA0
		}
	
		// Constructors
		static InteractFacCollectJob() {
			LOGISTIC_INTERACT_SAMPLE_OFFSETS = default;
		} // 0x00000001879731E8-0x0000000187973230
	
		// Methods
		private void _SwapBuffer() {} // 0x00000001879719EC-0x0000000187971A2C
		public void Execute() {} // 0x0000000184E79C40-0x0000000184E79F50
		private void _ExecuteBuilding() {} // 0x00000001818A80D0-0x00000001818A83F0
		private void _ExecuteConveyor() {} // 0x0000000187971AF4-0x0000000187971C54
		private void _ExecutePipe() {} // 0x0000000187971A2C-0x0000000187971AF4
		private bool _CheckDist(float3 pos, float distSqThreshold, ref int minSearchIndex) => default; // 0x000000018478F900-0x000000018478F930
		private static float3 _SnapDirectionToAxis(float3 direction) => default; // 0x0000000187971C54-0x0000000187971CD4
		public void SetSharedExtData(IntPtr data) {} // 0x0000000187973198-0x00000001879731E8
	}

	public struct LocalToWorldJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 49975
	{
		// Fields
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x00
		public unsafe EntityHierarchyContainer.EntityTransformData* hierarchyDataPtr; // 0x08
		public int frameCount; // 0x10
	
		// Methods
		public void Execute(int index) {} // 0x0000000187972BDC-0x0000000187972D34
		public static void TransTRS(ref LocalToWorld localToWorld, IntPtr hierarchyIntPtr, int frameCount = -1 /* Metadata: 0x020611DC */) {} // 0x00000001845B8720-0x00000001845B87D0
		public static unsafe void TransTRS(ref LocalToWorld localToWorld, EntityHierarchyContainer.EntityTransformData* hierarchyPtr, int frameCount = -1 /* Metadata: 0x020611DD */) {} // 0x00000001845B8890-0x00000001845B8AE0
		public void Execute(int startIndex, int count) {} // 0x0000000187972B5C-0x0000000187972BDC
		public void SetHierarchyData(IntPtr data) {} // 0x0000000184821980-0x00000001848219C0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x0000000184821940-0x0000000184821980
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x020611DE */) => default; // 0x0000000184821890-0x0000000184821940
	}

	public struct LocalToWorldQueryJob : IJob // TypeDefIndex: 49976
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute() {} // 0x0000000187972D34-0x0000000187972E10
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x020611DF */) {} // 0x00000001848219C0-0x0000000184821A10
	}

	public struct LogisticEffectJob : IJobParallelFor // TypeDefIndex: 49977
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public long deltaTime; // 0x20
	
		// Methods
		public void Execute(int index) {} // 0x0000000187972E10-0x0000000187973198
	}

	public struct LookAtJob : IJobParallelFor, IJobParallelForDefer // TypeDefIndex: 49978
	{
		// Fields
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		public unsafe EntityHierarchyContainer.EntityTransformData* hierarchyDataPtr; // 0x08
	
		// Methods
		public void Execute(int index) {} // 0x0000000187973230-0x0000000187973A40
		public void SetHierarchyData(IntPtr data) {} // 0x00000001843EDFA0-0x00000001843EDFE0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x00000001843EDFE0-0x00000001843EE020
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x020611E0 */) => default; // 0x00000001843EE290-0x00000001843EE340
	}

	public struct LookAtQueryJob : IJob // TypeDefIndex: 49979
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute() {} // 0x0000000187973A40-0x0000000187973AFC
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x020611E1 */) {} // 0x00000001843EDCC0-0x00000001843EDD40
	}

	public struct OutputCollectJob : IJob // TypeDefIndex: 49980
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public float offsetY; // 0x20
		public UnsafeList<OutputRendererInfo> posList; // 0x28
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x30
	
		// Methods
		public void Execute(int index) {} // 0x0000000187973C34-0x0000000187973EB0
		private void _Collect(ref UnitFragment unit, ref UnitTransFragment trans, ref UnitConfigFragment config, ref OutputFragment output, ref SharedDataFragment sharedData) {} // 0x0000000187973EB0-0x00000001879742D0
		public void Execute(int startIndex, int count) {} // 0x0000000187973AFC-0x0000000187973B88
		public void Execute() {} // 0x0000000187973B88-0x0000000187973C34
		public void SetSharedExtData(IntPtr data) {} // 0x0000000185296A00-0x0000000185296A40
	}

	public struct OutputRenderJob : IJobParallelFor // TypeDefIndex: 49981
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<OutputRendererInfo> posList; // 0x20
	
		// Methods
		public void Execute(int index) {} // 0x00000001879742D0-0x000000018797468C
	}

	public struct PedestalFlashJob : IJobParallelForBatch // TypeDefIndex: 49982
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public long time; // 0x20
		public unsafe SharedDataContainer.SharedExtData* sharedExtDataPtr; // 0x28
	
		// Methods
		public void Execute(int index) {} // 0x000000018797470C-0x0000000187974980
		private float4 _Flash(ref PedestalLightFlashFragment flashConfig, float deltaTime) => default; // 0x0000000187974980-0x0000000187974AA4
		public void Execute(int startIndex, int count) {} // 0x000000018797468C-0x000000018797470C
		public void SetSharedExtData(IntPtr data) {} // 0x000000018545B2A0-0x000000018545B2E0
	}

	public struct PipeCollectJob : IJob // TypeDefIndex: 49983
	{
		// Fields
		public EntityQueryV2.QueryResult pipeQr; // 0x00
		public EntityQueryV2.QueryResult previewPipeQr; // 0x20
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeLPosMatrices; // 0x40
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeMPosMatrices; // 0x48
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeRPosMatrices; // 0x50
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* trackLPosMatrices; // 0x58
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* trackMPosMatrices; // 0x60
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* trackRPosMatrices; // 0x68
		public UnsafeList<float4x4> comPosMatrices; // 0x70
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x78
		public unsafe GlobalEnv* envPtr; // 0x80
	
		// Properties
		public int pipeCount { get => default; } // 0x0000000187976264-0x0000000187976294 
	
		// Methods
		public void Execute(int index) {} // 0x0000000187974FFC-0x0000000187975110
		private void _ExecutePipe(EntityQueryV2.BlockRange blockRange, NativeList<GroupType> groups) {} // 0x0000000187975D60-0x0000000187976004
		private void _ExecutePreviewPipe(EntityQueryV2.BlockRange blockRange, NativeList<GroupType> groups) {} // 0x0000000187976004-0x0000000187976264
		private void _CollectPipe(int pipeLength, uint memoryStartOffset, uint memoryEndOffset, int subItemType, float waterThickness, float waterFlowDeltaTime, float waterDirection, float pipeHeight, uint sharedDataHandle, bool isPreview = false /* Metadata: 0x020611E2 */, bool valid = true /* Metadata: 0x020611E3 */, bool highLight = false /* Metadata: 0x020611E4 */) {} // 0x0000000187975690-0x0000000187975AFC
		private void _CollectPipeCom(in PipeFragment pipe, uint sharedDataHandle) {} // 0x000000018797519C-0x0000000187975690
		private void _CollectTrack(int pipeLength, uint memoryStartOffset, uint memoryEndOffset, float pipeHeight, float gridPathHeightStart, float gridPathHeightEnd, uint sharedDataHandle, bool pipeValid) {} // 0x0000000187975AFC-0x0000000187975D60
		public void Execute(int startIndex, int count) {} // 0x0000000187975110-0x000000018797519C
		public void Execute() {} // 0x0000000187974F80-0x0000000187974FFC
		public void SetGlobalEnvRef(ref GlobalEnv envRef) {} // 0x00000001852969C0-0x0000000185296A00
		public void SetSharedExtData(IntPtr data) {} // 0x0000000185296980-0x00000001852969C0
	}

	public struct PipeComRendererJob : IJobParallelForBatch // TypeDefIndex: 49984
	{
		// Fields
		public EntityManager em; // 0x00
		public UnsafeList<float4x4> comPosArr; // 0x10
		public NativeArray<Entity> rendererEntities; // 0x20
		public bool useDistanceFilter; // 0x30
		public float2 distanceFilterCenterPos; // 0x34
		public float distanceThreshold; // 0x3C
	
		// Methods
		public void Execute(int startIndex, int count) {} // 0x0000000187976294-0x00000001879765B4
	}

	public struct PipeFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 49985
	{
		// Fields
		public int startOffsetIndex; // 0x00
		public float simpleDrawingType; // 0x04
		public IntPtr dataMatrices; // 0x08
		public NativeArray<Entity> rendererEntities; // 0x10
		public EntityManager em; // 0x20
	
		// Methods
		public void Execute(int index) {} // 0x00000001879765B4-0x0000000187976874
		private void _UpdateCachedPipe(Entity cachedEntity, byte protoType, float3 pos, float3 rot, float indexInPipe, float pipeLength, float waterDirection, float waterThickness, float pipeHeight, float subItemType, bool isPreview = false /* Metadata: 0x020611E5 */, bool valid = true /* Metadata: 0x020611E6 */, bool highLight = false /* Metadata: 0x020611E7 */) {} // 0x0000000187976900-0x0000000187976C0C
		public void Execute(int startIndex, int count) {} // 0x0000000187976874-0x0000000187976900
	}

	public struct PipeHolderFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 49986
	{
		// Fields
		public EntityManager em; // 0x00
		public float offsetY; // 0x10
		public UnsafeList<Matrix4x4> dataMatrices; // 0x18
		public NativeArray<Entity> rendererEntities; // 0x28
	
		// Methods
		public void Execute(int index) {} // 0x0000000187976C98-0x0000000187976F0C
		public void Execute(int startIndex, int count) {} // 0x0000000187976C0C-0x0000000187976C98
	}

	public struct PipeHolderHideRendererJob : IJobParallelForBatch // TypeDefIndex: 49987
	{
		// Fields
		public bool drawPipe; // 0x00
		public EntityQueryV2.QueryResult holderQr; // 0x08
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x28
	
		// Methods
		public void Execute(int index) {} // 0x0000000187976F0C-0x0000000187977098
		public void Execute(int startIndex, int count) {} // 0x0000000187977098-0x0000000187977124
		public void SetSharedExtData(IntPtr data) {} // 0x0000000184D38E00-0x0000000184D38E40
	}

	public struct PipeLogisticsPosCollectJob : IJob // TypeDefIndex: 49988
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x20
		public UnsafeList<Matrix4x4> posList; // 0x28
	
		// Methods
		public void Execute(int index) {} // 0x000000018797722C-0x0000000187977580
		public void Execute(int startIndex, int count) {} // 0x00000001879771A0-0x000000018797722C
		public void SetSharedExtData(IntPtr data) {} // 0x00000001857BE9F0-0x00000001857BEA30
		public void Execute() {} // 0x0000000187977124-0x00000001879771A0
	}

	public struct PipeRendererJob : IJobParallelForBatch // TypeDefIndex: 49989
	{
		// Fields
		public EntityManager em; // 0x00
		public EntityManager rendererEntityManager; // 0x10
		public bool inTopView; // 0x20
		public bool useDistanceFilter; // 0x21
		public float2 distanceFilterCenterPos; // 0x24
		public float distanceThreshold; // 0x2C
		public IntPtr dataMatrices; // 0x30
		public NativeArray<Entity> rendererEntities; // 0x38
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x48
	
		// Methods
		public void Execute(int startIndex, int count) {} // 0x0000000187977580-0x0000000187977858
		private void _UpdateCachedPipe(Entity cachedEntity, byte protoType, float3 pos, float3 rot, float bend, uint sharedDataHandle, int indexInPipe, int pipeLength, float waterDirection, float waterThickness, float subItemType, BlueprintState.EffectType blueprintRenderType, float waterFlowDeltaTime, uint lightMode, bool isPreview = false /* Metadata: 0x020611E8 */, bool valid = true /* Metadata: 0x020611E9 */, bool highLight = false /* Metadata: 0x020611EA */) {} // 0x0000000187977858-0x00000001879780AC
		public void SetSharedExtData(IntPtr data) {} // 0x000000018510A9A0-0x000000018510AA20
	}

	public struct PipeTrackRendererJob : IJob // TypeDefIndex: 49990
	{
		// Fields
		public EntityManager em; // 0x00
		public IntPtr leftArr; // 0x10
		public IntPtr rightArr; // 0x18
		public IntPtr middleArr; // 0x20
		public NativeArray<Entity> rendererLEntities; // 0x28
		public NativeArray<Entity> rendererREntities; // 0x38
		public NativeArray<Entity> rendererMEntities; // 0x48
		public bool useDistanceFilter; // 0x58
		public float2 distanceFilterCenterPos; // 0x5C
		public float distanceThreshold; // 0x64
		public bool inTopView; // 0x68
	
		// Methods
		public void Execute() {} // 0x00000001879780AC-0x00000001879784D0
		private void _UpdateCachedTrack(Entity cachedEntity, float3 pos, float3 rot, float indexInPipe, float pipeLength, float pipeHeight, float gridPathHeight, float gridPathHeightEnd, bool valid) {} // 0x00000001879784D0-0x0000000187978874
	}

	public struct PipeWaterThicknessQueryJob : IJob // TypeDefIndex: 49991
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute() {} // 0x0000000187978874-0x0000000187978930
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x020611EB */) {} // 0x00000001843EDD40-0x00000001843EDDC0
	}

	public struct PipeWaterThicknessRiseJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 49992
	{
		// Fields
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		public float deltaTime; // 0x08
		public unsafe GlobalEnv* globalEnv; // 0x10
	
		// Methods
		public void Execute(int startIndex, int count) {} // 0x0000000187978930-0x00000001879789B0
		public void Execute(int index) {} // 0x00000001879789B0-0x0000000187978B64
		public void SetGlobalEnv(ref GlobalEnv env) {} // 0x00000001843EDB80-0x00000001843EDBC0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x00000001843EDB40-0x00000001843EDB80
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x020611EC */) => default; // 0x00000001843EDA90-0x00000001843EDB40
	}

	public struct PortArrowRenderJob : IJobParallelFor // TypeDefIndex: 49993
	{
		// Fields
		public IntPtr arrowMatricesReaderIntPtr; // 0x00
		public NativeArray<Entity> renderEntities; // 0x08
		public bool buildMode; // 0x18
		public EntityManager em; // 0x20
		public IntPtr arrowPlacedDicPtr; // 0x30
		public bool bConflictCheck; // 0x38
	
		// Methods
		public void Execute(int index) {} // 0x0000000187978B64-0x0000000187978E38
	}

	public struct PortStateCollectJob : IJob // TypeDefIndex: 49994
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public UnsafeList<float4x4> portStatePosList; // 0x20
		public float pipePortBlockOffsetY; // 0x28
		public float conveyorPortBlockOffsetY; // 0x2C
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x30
	
		// Methods
		public void Execute(int index) {} // 0x0000000187978F40-0x00000001879790E4
		private void _Collect(ref ComplexPortFragment complexPortFrag, ref SharedDataContainer.SharedExtData extData) {} // 0x00000001879790E4-0x0000000187979368
		public void SetSharedExtData(IntPtr data) {} // 0x0000000185296940-0x0000000185296980
		public void Execute() {} // 0x0000000187978EC4-0x0000000187978F40
		public void Execute(int startIndex, int count) {} // 0x0000000187978E38-0x0000000187978EC4
	}

	public struct PortStateRendererJob : IJobParallelFor // TypeDefIndex: 49995
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<float4x4> posList; // 0x20
	
		// Methods
		public void Execute(int index) {} // 0x0000000187979368-0x0000000187979560
	}

	public struct PreviewUnitQueryJob : IJob // TypeDefIndex: 49996
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		private unsafe EntityQueryV2.QueryResultDefer* m_previewUnitQr; // 0x18
	
		// Methods
		public void Execute() {} // 0x0000000187979560-0x000000018797961C
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer previewUnitQr, bool resetQr = true /* Metadata: 0x020611ED */) {} // 0x0000000184F0F720-0x0000000184F0F770
	}

	public struct PumpInEffectJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 49997
	{
		// Fields
		public EntityManager em; // 0x00
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x10
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x18
	
		// Methods
		public void Execute(int index) {} // 0x000000018797969C-0x0000000187979B14
		public void Execute(int startIndex, int count) {} // 0x000000018797961C-0x000000018797969C
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x000000018481D4E0-0x000000018481D520
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x020611EE */) => default; // 0x000000018481D930-0x000000018481D9E0
		public void SetSharedExtData(IntPtr data) {} // 0x000000018481D520-0x000000018481D560
	}

	public struct StatusChangeJob : IJobParallelFor // TypeDefIndex: 49998
	{
		// Fields
		public EntityManager em; // 0x00
		public EntityQueryV2.QueryResult qr; // 0x10
		public EntityCommandBufferV2.EntityCommandBufferParallelWriter ecb; // 0x30
		public FunctionPointer<UnsafeJobFuncPointers.QueryBuildingState> queryBuildingState; // 0x60
		public FunctionPointer<UnsafeJobFuncPointers.SetEntityFlashStatue> setEntityFlashStatue; // 0x68
	
		// Methods
		public void Execute(int index) {} // 0x0000000187979B14-0x0000000187979EC8
	}

	public struct UnitCullingJob : IJobParallelForBatch // TypeDefIndex: 49999
	{
		// Fields
		public bool inTopView; // 0x00
		public float3 playerPos; // 0x04
		public float3 mainCameraPos; // 0x10
		public float stateDistanceSqrt; // 0x1C
		public float buildingNameDistanceSqrt; // 0x20
		public float renderDistanceSqr; // 0x24
		public float maxConveyorLengthSqr; // 0x28
		public float maxPipeLengthSqr; // 0x2C
		public unsafe GlobalEnv* env; // 0x30
		public EntityQueryV2.QueryResult qr; // 0x38
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x58
	
		// Methods
		public void Execute(int startIndex, int count) {} // 0x000000018797A2C8-0x000000018797A348
		public void Execute(int index) {} // 0x0000000187979EC8-0x000000018797A2C8
		public void SetGlobalEnvRef(ref GlobalEnv envRef) {} // 0x000000018475A100-0x000000018475A140
		public void SetSharedExtData(IntPtr data) {} // 0x000000018475A0C0-0x000000018475A100
	}

	public struct UnitPreviewRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 50000
	{
		// Fields
		public unsafe GlobalEnv* env; // 0x00
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x08
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x10
	
		// Methods
		public void Execute(int startIndex, int count) {} // 0x000000018797A684-0x000000018797A704
		public void Execute(int index) {} // 0x000000018797A348-0x000000018797A684
		public void SetGlobalEnvRef(ref GlobalEnv envRef) {} // 0x0000000184F0F6E0-0x0000000184F0F720
		public void SetSharedExtData(IntPtr data) {} // 0x0000000184F0F6A0-0x0000000184F0F6E0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x0000000184F0F660-0x0000000184F0F6A0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x020611EF */) => default; // 0x0000000184F0F570-0x0000000184F0F660
	}

	public struct UnitRendererQueryJob : IJob // TypeDefIndex: 50001
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		private unsafe EntityQueryV2.QueryResultDefer* m_unitQueryResult; // 0x18
		private unsafe EntityQueryV2.QueryResultDefer* m_liquidQueryResult; // 0x20
		private unsafe EntityQueryV2.QueryResultDefer* m_liquidPumpQueryResult; // 0x28
	
		// Methods
		public void Execute() {} // 0x000000018797A704-0x000000018797A888
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer unitQr, ref EntityQueryV2.QueryResultDefer liquidQr, ref EntityQueryV2.QueryResultDefer pumpQr, bool resetQr = true /* Metadata: 0x020611F0 */) {} // 0x00000001843EDDC0-0x00000001843EDE40
	}

	public struct UpdateUnitRendererTRSJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 50002
	{
		// Fields
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x08
	
		// Methods
		public void Execute(int index) {} // 0x000000018797A914-0x000000018797AAD4
		private void _Transform(ref HGFactoryRendererBinderComponent rendererBinder, ref LocalToWorld localToWorld, ref SharedDataFragment sharedData) {} // 0x000000018797AAD4-0x000000018797AB88
		public void Execute(int startIndex, int count) {} // 0x000000018797A888-0x000000018797A914
		public void SetSharedExtData(IntPtr data) {} // 0x000000018481D3E0-0x000000018481D420
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x000000018481D420-0x000000018481D460
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x020611F1 */) => default; // 0x000000018481D9E0-0x000000018481DA90
	}

	public struct WireCollectJob : IJob // TypeDefIndex: 50003
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public EntityManager em; // 0x20
		public unsafe GlobalEnv* env; // 0x30
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
		public unsafe WireRendererInfoCollection<WireRendererInfo>* normalRenderers; // 0x40
		public unsafe WireRendererInfoCollection<WireRendererInfo>* hsNormalRenderers; // 0x48
		public unsafe WireRendererInfoCollection<WireRendererInfo>* hsStrengthenRenderers; // 0x50
		public unsafe WireRendererInfoCollection<WireRendererInfo>* strengthenRenderers; // 0x58
		public unsafe WireRendererInfoCollection<WireRendererInfo>* disableRenderers; // 0x60
		public unsafe WireRendererInfoCollection<WireRendererInfo>* strengthenDisableRenderers; // 0x68
		public FixedString32Bytes factoryPowerPoleMountPoint; // 0x70
		public float wireCullDistance; // 0x90
	
		// Methods
		public void Execute(int index) {} // 0x000000018797AB88-0x000000018797B1C0
		private bool _IsNormalConnection(FacBuildingState state) => default; // 0x0000000187971984-0x00000001879719EC
		private bool _IsDisabledConnection(FacBuildingState state) => default; // 0x0000000187971974-0x0000000187971984
		public void Execute() {} // 0x000000018797B1C0-0x000000018797B26C
		public void SetGlobalEnvRef(ref GlobalEnv envRef) {} // 0x00000001843E7110-0x00000001843E7150
		public void SetSharedExtData(IntPtr data) {} // 0x00000001843E7150-0x00000001843E7190
	}

	public struct WireRenderJob : IJobParallelForBatch // TypeDefIndex: 50004
	{
		// Fields
		public IntPtr dataMatrices; // 0x00
		public EntityManager em; // 0x08
		public NativeArray<Entity> rendererEntities; // 0x18
	
		// Methods
		public void Execute(int index) {} // 0x000000018797B2F8-0x000000018797B3F4
		private void _UpdateCachedWire(Entity cachedEntity, WireRendererInfo arg) {} // 0x000000018797B3F4-0x000000018797B5CC
		public void Execute(int startIndex, int count) {} // 0x000000018797B26C-0x000000018797B2F8
	}

	public struct FactoryBuildingEffectData : IEventData // TypeDefIndex: 50005
	{
		// Fields
		public Entity buildingLogicEntity; // 0x00
		public AdditiveEffectFragment.AdditiveEffectType effectType; // 0x08
	}

	public struct FPtrNativeCurve // TypeDefIndex: 50006
	{
		// Fields
		private unsafe float* m_values; // 0x00
		private int m_valuesLength; // 0x08
		private UnityEngine.WrapMode m_preWrapMode; // 0x0C
		private UnityEngine.WrapMode m_postWrapMode; // 0x10
	
		// Methods
		public bool IsValid() => default; // 0x0000000187972080-0x00000001879720D0
		public NativeArray<float> CreateCurve(AnimationCurve curve, int resolution) => default; // 0x0000000184878610-0x0000000184878860
		public float Evaluate(float t) => default; // 0x0000000187971EEC-0x0000000187972080
		private float _Repeat(float t, float length) => default; // 0x0000000186475518-0x0000000186475564
		private float _Pingpong(float t, float length) => default; // 0x00000001864769A0-0x00000001864769D4
	}

	public static class StringIntern // TypeDefIndex: 50009
	{
		// Nested types
		public struct FastId : IEquatable<FastId> // TypeDefIndex: 50007
		{
			// Fields
			public readonly int id; // 0x00
			public static readonly FastId INVALID; // 0x00
	
			// Properties
			public bool isValid { get => default; } // 0x00000001818AB9C0-0x00000001818ABFD0 
	
			// Constructors
			public FastId(int value) : this() {
				id = default;
			} // 0x00000001818AB3A0-0x00000001818AB9C0
			static FastId() {
				INVALID = default;
			} // 0x00000001818A83F0-0x00000001818A8A80
	
			// Methods
			public static implicit operator FastId(int value) => default; // 0x00000001818AB0A0-0x00000001818AB3A0
			public static implicit operator int(FastId fastId) => default; // 0x00000001818AA390-0x00000001818AA3A0
			public bool Equals(FastId other) => default; // 0x00000001818AA3A0-0x00000001818AA3B0
			public override bool Equals(object obj) => default; // 0x00000001818AAA30-0x00000001818AB0A0
			public override int GetHashCode() => default; // 0x00000001818AA3B0-0x00000001818AAA30
			public bool __iFixBaseProxy_Equals(object P0) => default; // 0x00000001818A8A80-0x00000001818A9400
			public int __iFixBaseProxy_GetHashCode() => default; // 0x00000001818A9400-0x00000001818A9A70
		}
	
		private static class StringTable // TypeDefIndex: 50008
		{
			// Fields
			private const int INITIAL_SIZE = 512; // Metadata: 0x020611F2
			private static readonly Dictionary<string, int> STR_TO_INDEX; // 0x00
			private static readonly Dictionary<int, string> INDEX_TO_STR; // 0x08
			private static int s_nextId; // 0x10
	
			// Constructors
			static StringTable() {} // 0x00000001818ABFD0-0x00000001818AD090
	
			// Methods
			internal static int GetOrAddIndex(string s) => default; // 0x00000001818AA0A0-0x00000001818AA390
			internal static bool TryGetIndex(string s, out int id) {
				id = default;
				return default;
			} // 0x00000001818A9A70-0x00000001818A9D90
			internal static string IndexToString(int id) => default; // 0x00000001818A9D90-0x00000001818AA0A0
		}
	
		// Methods
		public static FastId StringToIndex(string key) => default; // 0x00000001818ADF30-0x00000001818AEB60
		public static bool TryGetIndex(string key, out FastId id) {
			id = default;
			return default;
		} // 0x00000001818AD090-0x00000001818ADF30
		public static string IndexToString(FastId id) => default; // 0x00000001818AEB60-0x00000001818B01F0
	}

	public static class IndexHashMap<T> // TypeDefIndex: 50012
		where T : struct
	{
		// Fields
		private static readonly SharedStatic<Holder> HOLDER;
	
		// Properties
		private static ref Holder H { get; }
		public static int count { get; }
	
		// Nested types
		private struct Holder // TypeDefIndex: 50010
		{
			// Fields
			public NativeParallelHashMap<int, T> map;
		}
	
		private struct Context // TypeDefIndex: 50011
		{
		}
	
		// Constructors
		static IndexHashMap() {}
	
		// Methods
		public static void Initialize(int capacity, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x020611F4 */) {}
		public static void Dispose() {}
		public static bool TryGetValue(string key, out ref T value) {
			value = default;
			return default;
		}
		public static bool TryGetValue(StringIntern.FastId keyId, out ref T value) {
			value = default;
			return default;
		}
		public static void Add(string key, T value) {}
		public static void Add(StringIntern.FastId keyId, T value) {}
		public static bool ContainsKey(string key) => default;
		public static bool ContainsKey(StringIntern.FastId keyId) => default;
		public static bool Remove(string key) => default;
		public static bool Remove(StringIntern.FastId keyId) => default;
		public static void Clear() {}
		public static string KeyIndexToString(StringIntern.FastId keyId) => default;
	}

	[Serializable]
	public struct PerDrawConfigArray // TypeDefIndex: 50013
	{
		// Fields
		public const int MAX_COUNT = 10; // Metadata: 0x020611F5
		public PerDrawConfig[] perDrawConfigArray; // 0x00
		public PerDrawPassConfig[] passConfigArray; // 0x08
	}

	[Serializable]
	public struct PerDrawPassConfig // TypeDefIndex: 50014
	{
		// Fields
		public bool enable; // 0x00
		public uint lightModeRaw; // 0x01
	
		// Properties
		public PerDrawLightMode lightMode { get => default; set {} } // 0x0000000185FB7CC0-0x0000000185FB7CD0 0x0000000185FB7CD0-0x0000000185FB7CE0
	
		// Methods
		public int Size() => default; // 0x0000000187974D60-0x0000000187974DB0
		public void Apply(Entity rendererEntity, ref uint currentLightMode) {} // 0x0000000187974C38-0x0000000187974CDC
		public void Apply(HGFactoryRendererBinderComponent binder, ref uint currentLightMode) {} // 0x0000000187974CDC-0x0000000187974D60
		private HGShaderLightMode _ParseToHGShaderLightMode(PerDrawLightMode value) => default; // 0x0000000187974DB0-0x0000000187974F80
	}

	[Serializable]
	public struct PerDrawConfig // TypeDefIndex: 50015
	{
		// Fields
		public PerDrawOffset offset; // 0x00
		public int valueType; // 0x04
		public float4 valueRaw; // 0x08
		private float4 m_value0; // 0x18
		private float m_value1; // 0x28
		private UnityEngine.Color m_value2; // 0x2C
	
		// Methods
		public static int Size() => default; // 0x0000000187974AA4-0x0000000187974AE8
		public void OnValidate() {} // 0x0000000184852470-0x00000001848524C0
		private void _OnPerDrawTypeChanged() {} // 0x00000001848524C0-0x00000001848525B0
		private void _OnColorChanged(UnityEngine.Color c) {} // 0x0000000187974AE8-0x0000000187974B58
		private void _OnFloat4Changed(float4 f) {} // 0x0000000187974B58-0x0000000187974BC0
		private void _OnFloatChanged(float f) {} // 0x0000000187974BC0-0x0000000187974C38
		public void Apply(HGFactoryRendererBinderComponent binder) {} // 0x00000001840FFDD0-0x00000001840FFF40
	}

	public enum LogicEntityState // TypeDefIndex: 50016
	{
		NORMAL = 0,
		INVALID = 1,
		PREVIEW = 2,
		MULTI_SELECT = 3,
		SOLO_SELECT = 4,
		PRE_SELECT = 5,
		WATER_AREA = 6,
		BLUEPRINT_TOBEBUILD = 7,
		BLUEPRINT_TOBEBUILD_SELECT = 8,
		BLUEPRINT_MOVING = 9,
		BLUEPRINT_MOVING_INVALID = 10,
		CONTINUATION = 11,
		DEFAULT = 12,
		SHARING = 13,
		SHARING_INVALID = 14,
		POWER_INTERACTION = 15,
		BLUEPRINT_TOBUILD_INVALID = 16,
		OVERLOAD_INVALID = 17,
		MAX = 18
	}

	public class PerDrawDataOffsetAttribute : Attribute // TypeDefIndex: 50017
	{
		// Fields
		public System.Type type; // 0x10
		public int typeValue; // 0x18
	
		// Constructors
		public PerDrawDataOffsetAttribute() {} // Dummy constructor
		public PerDrawDataOffsetAttribute(System.Type type, int typeValue) {} // 0x0000000185EBE0E0-0x0000000185EBE100
	}

	public enum LogicEntityType // TypeDefIndex: 50018
	{
		CONVEYOR = 0,
		PIPE = 1,
		BUILDING = 2,
		INDICATOR = 3,
		GRID = 4,
		MAX = 5
	}

	public enum PerDrawOffset // TypeDefIndex: 50019
	{
		BASE_COLOR = 0,
		CONVEYOR_INDICATOR = 12,
		GRID_MODE = 16,
		RENDER_ON_WATER = 20,
		TINT_COLOR = 32,
		FLOW_ALPHA = 48,
		BELT_COLOR_INTENSITY = 52,
		BELT_COLOR_ALPHA = 56,
		BLUEPRINT_NOISE_ALPHA = 68
	}

	public enum PerDrawLightMode : uint // TypeDefIndex: 50020
	{
		None = 0,
		GBuffer = 1,
		GBufferMobile = 2,
		Erosion = 4,
		ErosionMobile = 8,
		ErosionClear = 16,
		ForwardOnly = 32,
		Forward = 64,
		ForwardCharacterOnly = 128,
		ForwardReflection = 256,
		CharacterOutline = 512,
		ShadowCaster = 1024,
		DepthOnly = 2048,
		DepthCharacterOnly = 4096,
		SRPDefaultUnlit = 8192,
		ForwardDecal = 16384,
		VFXDecal = 32768,
		Distortion = 65536,
		FullScreenDebug = 131072,
		OccludedDisplay = 262144,
		TerrainVTDecal = 524288,
		TerrainVTDecalMobile = 1048576,
		RayTracingReflection = 2097152,
		StencilAlphaBlend = 4194304,
		WaterMarkUI = 8388608
	}

	public static class PerDrawDataOffset // TypeDefIndex: 50021
	{
		// Fields
		public const int BASE_COLOR = 0; // Metadata: 0x02061257
		public const int EMISSIVE_COLOR = 16; // Metadata: 0x02061258
		public const int SOCIAL_SIGN_ICON_INDEX = 60; // Metadata: 0x02061259
		public const int CUTOFF_POS_Y = 32; // Metadata: 0x0206125A
		public const int EMISSIVE_LUT_INDEX = 36; // Metadata: 0x0206125B
		public const int EMISSIVE_LUT_BIT_MASK = 40; // Metadata: 0x0206125C
		public const int LIQUID_HEIGHT_INDEX = 44; // Metadata: 0x0206125D
		public const int FACTORY_COLOR_TYPE = 48; // Metadata: 0x0206125E
		public const int ENABLE_CUTOFF = 52; // Metadata: 0x0206125F
		public const int EMISSIVE_ANIMATION_MODE = 56; // Metadata: 0x02061260
		public const int LIQUID_COLOR_INDEX = 60; // Metadata: 0x02061261
		public const int UI_ATLAS_UV = 0; // Metadata: 0x02061262
		public const int UI_LIQUID_ATLAS_UV = 16; // Metadata: 0x02061263
		public const int ENABLE_LIQUID_ICON = 68; // Metadata: 0x02061264
		public const int RARITY_COLOR = 48; // Metadata: 0x02061266
		public const int TINT_COLOR = 32; // Metadata: 0x02061267
		public const int INDICATOR_DATA = 64; // Metadata: 0x02061268
		public const int DISABLE_ICON_DEPTH_BLEND = 72; // Metadata: 0x0206126A
		public const int GRID_MODE = 16; // Metadata: 0x0206126C
		public const int RENDER_ON_WATER = 20; // Metadata: 0x0206126D
		public const int OVERLOOK = 44; // Metadata: 0x0206126E
		public const int ARROW_STEP_COUNT = 8; // Metadata: 0x0206126F
		public const int SIMPLE_DRAWING_TYPE = 12; // Metadata: 0x02061270
		public const int TIME_OFFSET = 0; // Metadata: 0x02061271
		public const int ARROW_UV_SPEED = 4; // Metadata: 0x02061272
		public const int ENABLE_CONVEYOR_INDICATOR = 12; // Metadata: 0x02061273
		public const int ARROW_DATA = 16; // Metadata: 0x02061274
		public const int BELT_COLOR = 32; // Metadata: 0x02061275
		public const int FLOW_INTENSITY = 48; // Metadata: 0x02061276
		public const int BELT_COLOR_INTENSITY = 52; // Metadata: 0x02061277
		public const int BELT_COLOR_ALPHA = 56; // Metadata: 0x02061278
		public const int ELECTRIC_WIRE_ALPHA = 12; // Metadata: 0x02061279
		public const int VFX_TINT_COLOR_ALPHA = 44; // Metadata: 0x0206127A
		public const int ELECTRIC_WIRE_LENGTH = 56; // Metadata: 0x0206127B
		public const int WATER_THICKNESS = 0; // Metadata: 0x0206127C
		public const int WATER_DELTA_TIME = 4; // Metadata: 0x0206127D
		public const int TUBE_INDEX = 8; // Metadata: 0x0206127E
		public const int TUBE_COUNT = 12; // Metadata: 0x0206127F
		public const int WATER_DIRECTION = 16; // Metadata: 0x02061280
		public const int ENABLE_OVERLOOK_ARROW = 20; // Metadata: 0x02061281
		public const int TUBE_BEND_X_DEGREE = 24; // Metadata: 0x02061282
		public const int TUBE_BEND_TAG = 28; // Metadata: 0x02061283
		public const int GLASS_COLOR = 32; // Metadata: 0x02061284
		public const int ATLAS_UV_INDEX = 48; // Metadata: 0x02061285
		public const int ENABLE_TUBE_INDICATOR = 52; // Metadata: 0x02061286
		public const int DITHER_TRANSPARENT_ALPHA = 64; // Metadata: 0x02061287
		public const int BLUEPRINT_NOISE_ALPHA = 68; // Metadata: 0x02061289
		public const int FACTORY_VAT_FRAME = 72; // Metadata: 0x0206128B
		public const int FACTORY_VAT_LAST_FRAME = 76; // Metadata: 0x0206128D
	}

	public class ProcessorInterval // TypeDefIndex: 50022
	{
		// Constructors
		public ProcessorInterval() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static bool CheckInterval(ref IProcessor processor, float delta = 1f /* Metadata: 0x0206128F */, float rate = 1f /* Metadata: 0x02061293 */) => default; // 0x00000001846B4D10-0x00000001846B5080
		private static bool _CheckInterval(float frameInterval, float intervalSetting, out float curInterval, float delta = 1f /* Metadata: 0x02061297 */, float rate = 1f /* Metadata: 0x0206129B */) {
			curInterval = default;
			return default;
		} // 0x00000001846B5080-0x00000001846B5EA0
	}

	public class CargoPredictProcessor : BaseProcessor // TypeDefIndex: 50023
	{
		// Properties
		public override bool lowFrameEnable { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public override string name { get => default; } // 0x0000000187971D80-0x0000000187971DAC 
	
		// Constructors
		public CargoPredictProcessor() {} // 0x0000000185FB7390-0x0000000185FB73A0
	
		// Methods
		public override JobHandle Execute(ref EntityManager em, long time, long dt, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default; // 0x00000001843EB2E0-0x00000001843EB5B0
		public JobHandle __iFixBaseProxy_Execute(ref EntityManager P0, long P1, long P2, float P3, int P4, int P5, int P6, ref GlobalEnv P7, JobHandle P8, NativeList<JobHandle> P9) => default; // 0x0000000187971CD4-0x0000000187971D80
	}

	public class CrossFrameProcessor : BaseProcessor // TypeDefIndex: 50024
	{
		// Fields
		private InteractFacCollectJob.BuildingInfo m_nearBuildingInfo; // 0x20
		private InteractFacCollectJob.LogisticInfo m_nearConveyorInfo; // 0x74
		private InteractFacCollectJob.LogisticInfo m_nearPipeInfo; // 0x94
		private InteractFacCollectJob.BuildingInfo m_nearBuildingInfoLast; // 0xB4
		private InteractFacCollectJob.LogisticInfo m_nearConveyorInfoLast; // 0x108
		private InteractFacCollectJob.LogisticInfo m_nearPipeInfoLast; // 0x128
		private const float MAX_BUILDING_INTERACT_RADIUS = 1.5f; // Metadata: 0x0206129F
		private const float BUILDING_INTERACT_RADIUS_EXPAND = 0.6f; // Metadata: 0x020612A3
	
		// Properties
		public override string name { get => default; } // 0x0000000187971EC0-0x0000000187971EEC 
		public override bool lowFrameEnable { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public CrossFrameProcessor() {} // 0x0000000185FB7390-0x0000000185FB73A0
	
		// Methods
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting) {} // 0x0000000185D52DF0-0x0000000185D52EA0
		public override JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle) => default; // 0x00000001840C77D0-0x00000001840C8170
		public override void TearDown(ref EntityManager em, ref GlobalEnv env) {} // 0x0000000187971DAC-0x0000000187971E44
		public void __iFixBaseProxy_Initialize(ref EntityManager P0, ref GlobalEnv P1, FactorySetting P2) {} // 0x0000000187971E44-0x0000000187971E54
		public JobHandle __iFixBaseProxy_LateExecute(ref EntityManager P0, ref GlobalEnv P1, int P2, int P3, int P4, JobHandle P5) => default; // 0x0000000187971E54-0x0000000187971EB8
		public void __iFixBaseProxy_TearDown(ref EntityManager P0, ref GlobalEnv P1) {} // 0x0000000187971EB8-0x0000000187971EC0
	}

	public abstract class EntityDestroyReactiveProcessor<T> : ReactiveProcessor<T> // TypeDefIndex: 50025
		where T : struct, IReactiveComponent, IComponentECS
	{
		// Fields
		private NativeList<Entity> m_removedEntities;
	
		// Constructors
		protected EntityDestroyReactiveProcessor() {}
	
		// Methods
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting) {}
		public override void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null) {}
		public override void TearDown(ref EntityManager em, ref GlobalEnv env) {}
	}

	public class FacRendererCollectProcessor : BaseProcessor // TypeDefIndex: 50026
	{
		// Fields
		public static bool s_statusRenderEnabled; // 0x00
		public static bool s_portStatusRenderEnabled; // 0x01
		private float m_conveyorOffsetY; // 0x20
		private float m_conveyorPortBlockOffsetY; // 0x24
		private float m_pipePortBlockOffsetY; // 0x28
		private float4 m_portForbiddenColor; // 0x2C
		private float4 m_portEvaluatedColor; // 0x3C
		private float4 m_portNormalColor; // 0x4C
		private unsafe UnsafeList<float4x4>* m_portBlockPosList; // 0x60
		private unsafe UnsafeList<OutputRendererInfo>* m_outputPosList; // 0x68
		private unsafe UnsafeList<float4x4>* m_buildingStatePosList; // 0x70
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorLPosList0; // 0x78
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorMPosList0; // 0x40080
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorRPosList0; // 0x80088
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorLPosList1; // 0xC0090
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorMPosList1; // 0x100098
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorRPosList1; // 0x1400A0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewLPosList0; // 0x1800A8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewMPosList0; // 0x1C00B0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewRPosList0; // 0x2000B8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewLPosList1; // 0x2400C0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewMPosList1; // 0x2800C8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewRPosList1; // 0x2C00D0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideLPosList0; // 0x3000D8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideMPosList0; // 0x3400E0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideRPosList0; // 0x3800E8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideLPosList1; // 0x3C00F0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideMPosList1; // 0x4000F8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideRPosList1; // 0x440100
		private CargoRendererInfoCollection<CargoRendererInfo> m_cargoList0; // 0x480108
		private CargoRendererInfoCollection<CargoRendererInfo> m_cargoList1; // 0x4C8110
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeLPosList0; // 0x510118
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeMPosList0; // 0x570120
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeRPosList0; // 0x5D0128
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeLPosList1; // 0x630130
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeMPosList1; // 0x690138
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeRPosList1; // 0x6F0140
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackLPosList0; // 0x750148
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackMPosList0; // 0x752150
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackRPosList0; // 0x754158
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackLPosList1; // 0x756160
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackMPosList1; // 0x758168
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackRPosList1; // 0x75A170
		private WireRendererInfoCollection<WireRendererInfo> m_wireNormalList0; // 0x75C178
		private WireRendererInfoCollection<WireRendererInfo> m_wireNormalList1; // 0x762180
		private WireRendererInfoCollection<WireRendererInfo> m_wireHsNormalList0; // 0x768188
		private WireRendererInfoCollection<WireRendererInfo> m_wireHsNormalList1; // 0x76E190
		private WireRendererInfoCollection<WireRendererInfo> m_wireDisableList0; // 0x774198
		private WireRendererInfoCollection<WireRendererInfo> m_wireDisableList1; // 0x77A1A0
		private WireRendererInfoCollection<WireRendererInfo> m_wireStrengthenList0; // 0x7801A8
		private WireRendererInfoCollection<WireRendererInfo> m_wireStrengthenList1; // 0x7861B0
		private WireRendererInfoCollection<WireRendererInfo> m_wireHsStrengthenList0; // 0x78C1B8
		private WireRendererInfoCollection<WireRendererInfo> m_wireHsStrengthenList1; // 0x7921C0
		private WireRendererInfoCollection<WireRendererInfo> m_wireStrengthenDisableList0; // 0x7981C8
		private WireRendererInfoCollection<WireRendererInfo> m_wireStrengthenDisableList1; // 0x79E1D0
		private unsafe UnsafeList<Matrix4x4>* m_pipeHolderPosList; // 0x7A41D8
		private unsafe UnsafeList<float4x4>* m_comPosList; // 0x7A41E0
		private PortArrowRendererInfoCollection<PortArrowRendererInfo> m_portArrowList0; // 0x7A41E8
		private PortArrowRendererInfoCollection<PortArrowRendererInfo> m_portArrowList1; // 0x7C41F0
		private unsafe UnsafeList<float4x4>* m_conveyorInsideMatrices; // 0x7E41F8
		private FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> m_facRegionPosValidFuncPtr; // 0x7E4200
		public FunctionPointer<UnsafeJobFuncPointers.QueryStateIconPath> queryStateIconPathFuncPtr; // 0x7E4208
		private int m_lowFrameInterval; // 0x7E4210
		private UnsafeParallelHashMap<int, bool> m_arrowPlacedDic; // 0x7E4218
	
		// Properties
		public override string name { get => default; } // 0x0000000187972B30-0x0000000187972B5C 
	
		// Constructors
		public FacRendererCollectProcessor() {} // 0x0000000185FB7CA0-0x0000000185FB7CC0
		static FacRendererCollectProcessor() {} // 0x0000000185F8B7D0-0x0000000185F8B820
	
		// Methods
		private JobHandle _CollectConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorCollectJobHandle) {
			conveyorCollectJobHandle = default;
			return default;
		} // 0x00000001843EA050-0x00000001843EA2E0
		private JobHandle _CollectPreviewConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorPreviewCollectJobHandle) {
			conveyorPreviewCollectJobHandle = default;
			return default;
		} // 0x00000001843E9740-0x00000001843E99E0
		private JobHandle _CollectGuideConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorCollectJobHandle) {
			conveyorCollectJobHandle = default;
			return default;
		} // 0x00000001843EA2E0-0x00000001843EA570
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting) {} // 0x00000001851DE390-0x00000001851DE5E0
		private void _CreateAllocator(ref GlobalEnv env) {} // 0x00000001851DE7B0-0x00000001851DE800
		private void _CreateCurrent(ref GlobalEnv env) {} // 0x00000001851DE000-0x00000001851DE390
		private JobHandle _CollectPortState(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portCollectJobHandle) {
			portCollectJobHandle = default;
			return default;
		} // 0x00000001843EA810-0x00000001843EAB40
		private JobHandle _CollectBuildingState(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle buildingStateCollectJobHandle) {
			buildingStateCollectJobHandle = default;
			return default;
		} // 0x00000001843E9110-0x00000001843E9470
		private JobHandle _CollectOutput(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle outputCollectJobHandle) {
			outputCollectJobHandle = default;
			return default;
		} // 0x00000001843E9470-0x00000001843E9740
		private JobHandle _CollectCargo(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle cargoCollectJobHandle) {
			cargoCollectJobHandle = default;
			return default;
		} // 0x00000001843EA570-0x00000001843EA810
		private JobHandle _CollectWire(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle wireCollectJobHandle) {
			wireCollectJobHandle = default;
			return default;
		} // 0x00000001843E8C40-0x00000001843E9110
		public override JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle) => default; // 0x00000001843E99E0-0x00000001843E9E20
		public override void TearDown(ref EntityManager em, ref GlobalEnv env) {} // 0x00000001879720D0-0x000000018797226C
		private JobHandle _CollectPipe(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle pipeCollectJobHandle) {
			pipeCollectJobHandle = default;
			return default;
		} // 0x00000001843EAB40-0x00000001843EB1E0
		private JobHandle _CollectPipeLogistics(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle pipeHolderCollectJobHandle) {
			pipeHolderCollectJobHandle = default;
			return default;
		} // 0x00000001843E9E20-0x00000001843EA050
		private void _InitArrowPlaced(ref GlobalEnv env) {} // 0x00000001851DE9D0-0x00000001851DEA60
		private JobHandle _CollectPortArrow(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portArrowCollectJobHandle) {
			portArrowCollectJobHandle = default;
			return default;
		} // 0x00000001843EBF40-0x00000001843EC680
		private JobHandle _CollectPortArrowWithDiff(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portArrowCollectJobHandle) {
			portArrowCollectJobHandle = default;
			return default;
		} // 0x000000018797226C-0x0000000187972B30
		public void __iFixBaseProxy_Initialize(ref EntityManager P0, ref GlobalEnv P1, FactorySetting P2) {} // 0x0000000187971E44-0x0000000187971E54
		public JobHandle __iFixBaseProxy_LateExecute(ref EntityManager P0, ref GlobalEnv P1, int P2, int P3, int P4, JobHandle P5) => default; // 0x0000000187971E54-0x0000000187971EB8
		public void __iFixBaseProxy_TearDown(ref EntityManager P0, ref GlobalEnv P1) {} // 0x0000000187971EB8-0x0000000187971EC0
	}

	public abstract class ReactiveProcessor<T> : BaseProcessor // TypeDefIndex: 50027
		where T : struct, IReactiveComponent, IComponentECS
	{
		// Fields
		private readonly string _name_k__BackingField;
	
		// Properties
		public override string name { get; }
	
		// Constructors
		protected ReactiveProcessor() {}
	
		// Methods
		public override JobHandle PreExecute(ref EntityManager em, long time, long dt, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default;
		public override JobHandle Execute(ref EntityManager em, long time, long dt, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default;
		protected virtual void Perform(ref EntityManager em, ref EntityCommandBufferV2.EntityCommandBufferParallelWriter ecb, in ECSSpan<T> dataSpans, ref GlobalEnv env, GroupType group, long time) {}
		protected virtual bool CleanUpEntityFilter(ref EntityManager em, Entity entity) => default;
		public override void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null) {}
		public override void TearDown(ref EntityManager em, ref GlobalEnv env) {}
	}

	public class AdditiveMaterialBitIndex // TypeDefIndex: 50028
	{
		// Fields
		public static readonly int PREVIEW; // 0x00
		public static readonly int HIGHLIGHT; // 0x04
		public static readonly int OUTLINE; // 0x08
		public static readonly int CUTOFF; // 0x0C
		public static readonly int PRECESS; // 0x10
		public static readonly int REPAIR1; // 0x14
		public static readonly int REPAIR2; // 0x18
		public static readonly int REPAIR3; // 0x1C
		public static readonly int OVERLOAD; // 0x20
		public static readonly int BLUEPRINT_BUILD; // 0x24
		public static readonly int BLUEPRINT_MOVE; // 0x28
		public static readonly int BLUEPRINT_BUILD_OUTLINE; // 0x2C
		public static readonly int BLUEPRINT_MOVE_OUTLINE; // 0x30
		public static readonly int PRESELECT_PREVIEW; // 0x34
		public static readonly int SOCIAL_SHARING; // 0x38
		public static readonly int POWER_INTERACTION; // 0x3C
		public static readonly int MAX; // 0x40
	
		// Constructors
		public AdditiveMaterialBitIndex() {} // 0x0000000185492010-0x0000000185492020
		static AdditiveMaterialBitIndex() {} // 0x0000000185F1D2B0-0x0000000185F1D440
	}

	public class FactoryBaseColorLutConfig : ScriptableObject // TypeDefIndex: 50029
	{
		// Fields
		public SerializeFieldDictionary<FacBuildingBaseBuffer, UnityEngine.Color> factoryBuildingBaseStateConfig; // 0x18
		public SerializeFieldDictionary<BuildAndMode, int> factoryBuildingCrafterData; // 0x20
		public int factoryBuildingCount; // 0x28
	
		// Constructors
		public FactoryBaseColorLutConfig() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public bool GetColor(int sort, out UnityEngine.Color col) {
			col = default;
			return default;
		} // 0x0000000187993B08-0x0000000187993BA8
		public bool GetIndex(string id, string group, out int index) {
			index = default;
			return default;
		} // 0x0000000185172C90-0x0000000185172F80
		public static FactoryBaseColorLutConfig CreateOrGet(string path) => default; // 0x00000001879939E8-0x0000000187993B08
	}

	public enum FacBuildingBaseBuffer // TypeDefIndex: 50030
	{
		InputBuffer1 = 0,
		InputBuffer2 = 1,
		InputBuffer3 = 2,
		OutputBuffer1 = 3,
		OutputBuffer2 = 4,
		OutputBuffer3 = 5
	}

	[Serializable]
	public struct BuildAndMode // TypeDefIndex: 50031
	{
		// Fields
		public string build; // 0x00
		public string mode; // 0x08
	}

	[Serializable]
	public struct FFactoryStateColorConfig // TypeDefIndex: 50033
	{
		// Fields
		public SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryStateIconColorConfig; // 0x00
		public SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryIndicatorColorConfig; // 0x08
		public SerializeFieldDictionary<FacBuildingState, string> factoryUIEffectConfig; // 0x10
		public SerializeFieldDictionary<LogicEntityState, SerializeFieldDictionary<LogicEntityType, PerDrawConfigArray>> factoryLogicEntityColorConfig2; // 0x18
	
		// Nested types
		[Serializable]
		public struct LogicStateConfig // TypeDefIndex: 50032
		{
			// Fields
			public UnityEngine.Color color; // 0x00
			public float intensity; // 0x10
			public float alpha; // 0x14
			public float flowAlpha; // 0x18
			public UnityEngine.Color c; // 0x1C
	
			// Methods
			private void _OnColorChanged() {} // 0x00000001851DCDF0-0x00000001851DCE70
		}
	
		// Methods
		public bool GetStateColor(FacBuildingState enumKey, out UnityEngine.Color col) {
			col = default;
			return default;
		} // 0x0000000187992BA8-0x0000000187992C48
		public bool GetIndicatorColor(FacBuildingState enumKey, out UnityEngine.Color col) {
			col = default;
			return default;
		} // 0x0000000187992C48-0x0000000187992CE8
		public bool GetStateName(FacBuildingState enumKey, out string name) {
			name = default;
			return default;
		} // 0x00000001851DCC50-0x00000001851DCD20
		public bool GetPerDrawList(LogicEntityState entityState, LogicEntityType entityType, out PerDrawConfigArray perDrawList) {
			perDrawList = default;
			return default;
		} // 0x0000000184851A70-0x0000000184852470
		public void OnEnable() {} // 0x0000000187997294-0x0000000187997328
	}
}

namespace Beyond.Gameplay.Factory.ECSVATFSM
{
	public struct VATFSMStateFragment : IComponentECS // TypeDefIndex: 50034
	{
		// Fields
		public FSMState currentState; // 0x00
		public FSMState nextState; // 0x1C
		public FSMParameterSet parameters; // 0x38
		public FSMTransition transition; // 0x5C
		public float speed; // 0x68
		public uint definitionHandle; // 0x6C
		public uint binderSharedDataIndex; // 0x70
		public bool isTransitioning; // 0x74
		public bool isPause; // 0x75
		public const int ID = 75; // Metadata: 0x020612AD
	
		// Properties
		public ref VATFSMDefinition def { get => default; } // 0x000000018647289C-0x00000001864728A8 
		public int id { get => default; } // 0x0000000185FB7D00-0x0000000185FB7D10 
	
		// Methods
		public void Init(uint defHandle, uint binderHandle) {} // 0x0000000184E6F530-0x0000000184E6F630
		public void SetState(in FSMStateDefinition stateDef) {} // 0x0000000187998C34-0x0000000187998CD4
		public void ToNextState() {} // 0x0000000187998D6C-0x0000000187998E0C
		public void SetTransition(in FSMTransitionDefinition transDef, in FSMStateDefinition nextStateDef) {} // 0x0000000187998CD4-0x0000000187998D6C
		private void __AOT_FOR_FIX__() {} // 0x0000000187998E0C-0x0000000187998F48
	}

	public struct FSMState // TypeDefIndex: 50035
	{
		// Fields
		public byte index; // 0x00
		public float duration; // 0x04
		public float speed; // 0x08
		public bool isLoop; // 0x0C
		public uint prevFrame; // 0x10
		private float m_elapsedTime; // 0x14
		private bool m_isFinish; // 0x18
	
		// Properties
		public float process { get => default; } // 0x00000001879937A8-0x0000000187993824 
		public bool isFinished { get => default; } // 0x00000001813C0430-0x00000001813C0440 
	
		// Methods
		public void Enter() {} // 0x0000000184E6F630-0x0000000184E6F660
		public void Update(float deltaTime, float fsmSpeed) {} // 0x0000000187993714-0x00000001879937A8
		public void Exit() {} // 0x0000000187993664-0x00000001879936A8
		public void SetProgress(float normalized) {} // 0x00000001879936A8-0x0000000187993714
	}

	public struct FSMTransition // TypeDefIndex: 50036
	{
		// Fields
		public float duration; // 0x00
		private float m_elapsedTime; // 0x04
		private bool m_isFinish; // 0x08
	
		// Properties
		public bool isFinished { get => default; } // 0x00000001879939C0-0x00000001879939C8 
		public float fromStateWeight { get => default; } // 0x0000000187993940-0x00000001879939C0 
		public float toStateWeight { get => default; } // 0x00000001879939C8-0x00000001879939E8 
	
		// Methods
		public void Enter() {} // 0x0000000187993824-0x0000000187993874
		public void Update(float deltaTime, float fsmSpeed) {} // 0x00000001879938B8-0x0000000187993940
		public void Exit() {} // 0x0000000187993874-0x00000001879938B8
	}

	public struct FSMParameterSet // TypeDefIndex: 50037
	{
		// Fields
		public FixedList32Bytes<float> floats; // 0x00
		public byte bools; // 0x20
		public byte triggers; // 0x21
	
		// Methods
		public float GetFloat(byte index) => default; // 0x0000000187992FF4-0x0000000187993098
		public void SetFloat(byte index, float value) {} // 0x00000001879933B4-0x000000018799344C
		public int GetInt(byte index) => default; // 0x0000000187993098-0x0000000187993144
		public void SetInt(byte index, int value) {} // 0x000000018799344C-0x00000001879934E8
		public bool GetBool(byte index) => default; // 0x0000000187992F94-0x0000000187992FF4
		public void SetBool(byte index, bool value) {} // 0x0000000187993330-0x00000001879933B4
		public bool GetTrigger(byte index) => default; // 0x0000000187993144-0x00000001879931A4
		public void SetTrigger(byte index) {} // 0x00000001879934E8-0x0000000187993550
		public void ResetTrigger(byte index) {} // 0x00000001879932C8-0x0000000187993330
		public void ResetAllTriggers() {} // 0x000000018799327C-0x00000001879932C8
		public void SetValue(byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type, float value) {} // 0x0000000187993550-0x0000000187993664
		public float GetValue(byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type) => default; // 0x00000001879931A4-0x000000018799327C
		public void ResetParametersByDef(in VATFSMDefinition def) {} // 0x0000000184E6F660-0x0000000184E6F7D0
	}

	public struct VATFSMSetParamRequestHandlerJob : IJobFor // TypeDefIndex: 50038
	{
		// Fields
		public EntityManager renderEm; // 0x00
		public NativeArray<VATFSMProcessor.SetAnimatorParamRequest> setParamRequestList; // 0x10
		public unsafe VATFSMDefinition* sharedDataPtr; // 0x20
		public unsafe GlobalEnv* envPtr; // 0x28
	
		// Methods
		public void Execute(int index) {} // 0x0000000187998AF0-0x0000000187998C34
	}

	public struct VATFSMStateUpdateJob : IJobFor // TypeDefIndex: 50039
	{
		// Fields
		public float deltaTime; // 0x00
		public EntityQueryV2.QueryResult qr; // 0x08
		public unsafe VATFSMDefinition* fsmDefinitionPtr; // 0x28
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x30
		public UnsafeList<VATFSMProcessor.VATFSMAudioData> animatorAudioQueue; // 0x38
		private const int S_CURRENT_FRAME_OFFSET = 72; // Metadata: 0x020612AF
		private const int S_PREVIOUS_FRAME_OFFSET = 76; // Metadata: 0x020612B1
	
		// Methods
		public void Execute() {} // 0x000000018799922C-0x00000001879992B4
		public void Execute(int index) {} // 0x0000000187998F48-0x000000018799922C
		private bool _CheckTransitions(ref VATFSMStateFragment fsm, ref VATFSMDefinition fsmDef) => default; // 0x00000001879993A0-0x00000001879994D8
		private void _ComputeVATFrameData(ref VATFSMStateFragment state, ref VATFSMDefinition fsmDef) {} // 0x00000001879994D8-0x0000000187999640
		private void _AddVATAudioData(Entity renderEntity, ref FSMState newState, ref VATFSMDefinition fsmDef) {} // 0x00000001879992B4-0x00000001879993A0
		public void SetSharedExtData(IntPtr data) {} // 0x00000001843EB2A0-0x00000001843EB2E0
	}

	public class VATFSMProcessor : BaseProcessor // TypeDefIndex: 50043
	{
		// Fields
		public NativeList<SetAnimatorParamRequest> animatorParamRequestQueue; // 0x20
		private NativeParallelHashMap<Entity, int> m_requestMaskPerEntity; // 0x30
	
		// Properties
		public override string name { get => default; } // 0x00000001843EBCE0-0x00000001843EBCF0 
		public unsafe VATFSMDefinition* fsmDefinitionPtr { get => default; } // 0x0000000185B97470-0x0000000185B975A0 
	
		// Nested types
		public enum VATAnimatorRequestType : byte // TypeDefIndex: 50040
		{
			SetParameter = 1,
			PauseOrResume = 2,
			SetSpeed = 3,
			ForceSetState = 4,
			SetStateLoop = 5,
			Reset = 6
		}
	
		public struct SetAnimatorParamRequest // TypeDefIndex: 50041
		{
			// Fields
			public Entity renderEntity; // 0x00
			public bool waitForStateFinish; // 0x08
			public VATAnimatorRequestType type; // 0x0C
			public bool isPause; // 0x10
			public float speed; // 0x10
			public int stateIndex; // 0x10
			public float stateProgress; // 0x14
			public bool isStateLoop; // 0x14
			public int paramIndex; // 0x10
			public float paramValue; // 0x14
	
			// Methods
			public unsafe void SetParamToAnimator(GlobalEnv* envPtr, ref VATFSMStateFragment fragment, VATFSMDefinition* sharedDataPtr) {} // 0x0000000187998AC4-0x0000000187998AF0
		}
	
		public struct VATFSMAudioData // TypeDefIndex: 50042
		{
			// Fields
			public Entity entity; // 0x00
			public int hashStateName; // 0x08
		}
	
		// Constructors
		public VATFSMProcessor() {} // 0x0000000187971E44-0x0000000187971E54
	
		// Methods
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting) {} // 0x00000001843EB7A0-0x00000001843EBC90
		public override JobHandle Execute(ref EntityManager em, long time, long deltaTime, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default; // 0x000000018799899C-0x0000000187998AC4
		public override void TearDown(ref EntityManager em, ref GlobalEnv env) {} // 0x00000001841651D0-0x0000000184165910
		private JobHandle _HandleSetAnimatorParamRequest(ref EntityManager em, ref GlobalEnv env, JobHandle jobHandle) => default; // 0x0000000184165910-0x0000000184165F10
		private void _RemoveDuplicationRequest(ref EntityManager em) {} // 0x0000000185FB7390-0x0000000185FB73A0
		public void __iFixBaseProxy_Initialize(ref EntityManager P0, ref GlobalEnv P1, FactorySetting P2) {} // 0x0000000187971CD4-0x0000000187971D80
		public JobHandle __iFixBaseProxy_Execute(ref EntityManager P0, long P1, long P2, float P3, int P4, int P5, int P6, ref GlobalEnv P7, JobHandle P8, NativeList<JobHandle> P9) => default; // 0x0000000187971EB8-0x0000000187971EC0
		public void __iFixBaseProxy_TearDown(ref EntityManager P0, ref GlobalEnv P1) {} // 0x0000000187997328-0x00000001879975E0
	}

	[Serializable]
	public class ECSVATFSMDefinitionData // TypeDefIndex: 50044
	{
		// Fields
		public string fsmName; // 0x10
		public string defaultStateName; // 0x18
		public List<StateData> states; // 0x20
		public List<TransitionData> transitions; // 0x28
		public List<ParameterData> parameters; // 0x30
		public List<AnimationClipData> animationClips; // 0x38
	
		// Constructors
		public ECSVATFSMDefinitionData() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class StateData // TypeDefIndex: 50045
	{
		// Fields
		public string name; // 0x10
		public float speed; // 0x18
		public string clipName; // 0x20
	
		// Constructors
		public StateData() {} // 0x0000000185FB7390-0x0000000185FB73A0
	}

	public enum TransitionInterruptionSource // TypeDefIndex: 50046
	{
		None = 0,
		Source = 1,
		Destination = 2,
		SourceThenDestination = 3,
		DestinationThenSource = 4
	}

	[Serializable]
	public class TransitionData // TypeDefIndex: 50047
	{
		// Fields
		public string fromState; // 0x10
		public string toState; // 0x18
		public float exitTime; // 0x20
		public float duration; // 0x24
		public TransitionInterruptionSource interruptionSource; // 0x28
		public List<Beyond.Gameplay.Factory.ECSVATFSM.ConditionData> condition; // 0x30
	
		// Constructors
		public TransitionData() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum AnimatorConditionMode // TypeDefIndex: 50048
	{
		If = 1,
		IfNot = 2,
		Greater = 3,
		Less = 4,
		Equals = 6,
		NotEqual = 7
	}

	[Serializable]
	public class ConditionData // TypeDefIndex: 50049
	{
		// Fields
		public string parameterName; // 0x10
		public AnimatorConditionMode comparison; // 0x18
		public float threshold; // 0x1C
	
		// Constructors
		public ConditionData() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class ParameterData // TypeDefIndex: 50050
	{
		// Fields
		public string name; // 0x10
		public AnimatorControllerParameterType type; // 0x18
		public float defaultFloat; // 0x1C
		public int defaultInt; // 0x20
		public bool defaultBool; // 0x24
	
		// Constructors
		public ParameterData() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class AnimationClipData // TypeDefIndex: 50051
	{
		// Fields
		public string name; // 0x10
		public bool isLoop; // 0x18
		public float length; // 0x1C
		public int startFrame; // 0x20
		public int totalFrames; // 0x24
	
		// Constructors
		public AnimationClipData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public string GetClipDesStr() => default; // 0x0000000187990A28-0x0000000187990C20
	}

	public struct VATFSMDefinition // TypeDefIndex: 50052
	{
		// Fields
		public byte defaultStateIndex; // 0x00
		public FixedList512Bytes<FSMStateDefinition> states; // 0x02
		public FSMTransitionDefinition20<FSMTransitionDefinition> transitions; // 0x204
		public FixedList128Bytes<FSMParameterDefinition> parameters; // 0xA0C
	}

	public enum ConditionMode : byte // TypeDefIndex: 50053
	{
		If = 1,
		IfNot = 2,
		Greater = 3,
		Less = 4,
		Equals = 6,
		NotEqual = 7
	}

	public struct FSMCondition // TypeDefIndex: 50054
	{
		// Fields
		public byte parameterIndex; // 0x00
		public ConditionMode comparison; // 0x01
		public float threshold; // 0x04
	}

	public struct FSMTransitionDefinition20<T> : IEnumerable<T> // TypeDefIndex: 50057
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x020612CC
		public const int CAPACITY = 32; // Metadata: 0x020612CE
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x020612CF
		public const int INVALID_INDEX = -1; // Metadata: 0x020612D0
		private int m_beginIndex;
		private int m_endIndex;
		public _data_e__FixedBuffer data;
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 50055
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private FSMTransitionDefinition20<T> m_data;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(in FSMTransitionDefinition20<T> data, int count) : this() {
				m_count = default;
				m_beginIndex = default;
				m_index = default;
				m_data = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		public struct _data_e__FixedBuffer // TypeDefIndex: 50056
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public FSMTransitionDefinition20(int initialCapacity = 32 /* Metadata: 0x020612CA */, bool autoExtend = false /* Metadata: 0x020612CB */) : this() {
			m_beginIndex = default;
			m_endIndex = default;
			data = default;
		}
	
		// Methods
		public unsafe byte* GetPtr() => default;
		public IntPtr GetDataAsIntPtr() => default;
		public int Enqueue(T value) => default;
		public T Dequeue() => default;
		public int Unshift(T value) => default;
		public T Shift() => default;
		public int Push(T value) => default;
		public T Pop() => default;
		public T First() => default;
		public T Last() => default;
		public void InsertAt(int index, T value) {}
		public T RemoveAt(int index) => default;
		public int Find(T value) => default;
		public void Extend(int count) {}
		public void Extend() {}
		public void Clear() {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public unsafe T* GetElementAt(int index) => default;
		public T GetValue(int index) => default;
		public T GetValueWithGlobalIndex(int globalIndex) => default;
	}

	public struct FSMTransitionDefinition // TypeDefIndex: 50058
	{
		// Fields
		public byte fromStateIndex; // 0x00
		public byte toStateIndex; // 0x01
		public float exitTime; // 0x02
		public float duration; // 0x06
		public FixedList32Bytes<FSMCondition> conditions; // 0x0A
	}

	public enum ParameterType : byte // TypeDefIndex: 50059
	{
		Float = 1,
		Int = 3,
		Bool = 4,
		Trigger = 9
	}

	public struct FSMParameterDefinition // TypeDefIndex: 50060
	{
		// Fields
		public int nameHash; // 0x00
		public Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type; // 0x04
		public byte index; // 0x05
		public float defaultFloat; // 0x08
		public int defaultInt; // 0x08
		public byte defaultBool; // 0x08
	}

	public struct FSMStateDefinition // TypeDefIndex: 50061
	{
		// Fields
		public int nameHash; // 0x00
		public float length; // 0x04
		public float speed; // 0x08
		public int clipNameHash; // 0x0C
		public uint startFrame; // 0x10
		public uint totalFrames; // 0x14
		public byte index; // 0x18
		public bool isLoop; // 0x19
	}

	public struct VATFSMDefinitionContainer // TypeDefIndex: 50063
	{
		// Fields
		public const int INVALID_INDEX = -1; // Metadata: 0x020612D5
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref VATFSMDefinition this[int index] { get => default; } // 0x00000001879982E8-0x000000018799832C 
		public ref VATFSMDefinition this[uint index] { get => default; } // 0x000000018511E810-0x000000018511E860 
	
		// Nested types
		internal struct Node // TypeDefIndex: 50062
		{
			// Fields
			public VATFSMDefinition value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public VATFSMDefinitionContainer(Unity.Collections.Allocator allocator) : this() {
			m_nodes = default;
		} // 0x00000001852D2BF0-0x00000001852D2C90
	
		// Methods
		public void Dispose() {} // 0x00000001879980C8-0x0000000187998134
		public uint Size() => default; // 0x0000000187998280-0x00000001879982E8
		public Span<VATFSMDefinition> AsSpan() => default; // 0x0000000187997F84-0x0000000187998038
		public uint Create(ref VATFSMDefinition value) => default; // 0x00000001852D2D00-0x00000001852D2DE0
		public void Destroy(uint handle) {} // 0x0000000187998038-0x00000001879980C8
		public void Reset() {} // 0x00000001852D2B80-0x00000001852D2BF0
		public void Reserve(uint newCapacity) {} // 0x00000001879981FC-0x0000000187998280
		public IntPtr Data() => default; // 0x00000001843EBE40-0x00000001843EBEE0
		public ref VATFSMDefinition Get(uint handle) => ref _refReturnTypeForGet; // 0x0000000187998198-0x00000001879981FC
		private ref VATFSMDefinition _refReturnTypeForGet; // Dummy field
		public ref VATFSMDefinition Get(int handle) => ref _refReturnTypeForGet; // 0x0000000187998134-0x0000000187998198
		private ref VATFSMDefinition _refReturnTypeForGet; // Dummy field
	}

	public static class VATFSMDefinitionHelper // TypeDefIndex: 50064
	{
		// Methods
		private static bool _Evaluate(in FSMCondition cond, in FSMParameterSet param, in FixedList128Bytes<FSMParameterDefinition> paramDefs) => default; // 0x00000001879987E8-0x000000018799899C
		public static bool TryGetValidTransition(ref VATFSMStateFragment state, ref VATFSMDefinition def, out int transitionIndex) {
			transitionIndex = default;
			return default;
		} // 0x0000000187998638-0x00000001879987E8
		public static bool TryGetParameterIndexAndType(VATFSMDefinition def, int nameHash, out byte index, out Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type) {
			index = default;
			type = default;
			return default;
		} // 0x00000001879984C8-0x0000000187998638
		public static void ResetUsedTriggers(ref FSMParameterSet param, in FSMTransitionDefinition transition, in FixedList128Bytes<FSMParameterDefinition> paramDefs) {} // 0x000000018799832C-0x00000001879984C8
	}

	public static class FSMDefinitionLibrary // TypeDefIndex: 50065
	{
		// Fields
		public const int MAX_FSM_DEFINITION_COUNT = 128; // Metadata: 0x020612D6
		public const int MAX_STATE_COUNT = 20; // Metadata: 0x020612D8
		public const int MAX_TRANSITION_COUNT = 20; // Metadata: 0x020612D9
		public const int MAX_CONDITION_PRE_TRANSITION_COUNT = 3; // Metadata: 0x020612DA
		public const int MAX_PARAMETER_COUNT = 7; // Metadata: 0x020612DB
		public const byte ANY_STATE_INDEX = 255; // Metadata: 0x020612DC
		public static NativeParallelHashMap<int, uint> s_assetHashGuidToHandle; // 0x00
		public static NativeParallelHashMap<int2, byte> s_stateNameHashToIndex; // 0x10
		public static NativeParallelHashMap<int2, byte> s_parameterNameHashToIndex; // 0x20
	
		// Methods
		public static void Initialize() {} // 0x0000000185B975A0-0x0000000185B97730
		public static void InitFSMDefinition(int guid, ECSVATFSMDefinitionData data) {} // 0x000000018459EBA0-0x00000001845A1C00
		public static void RegisterFSM(Entity rEntity, ref EntityManager em) {} // 0x000000018459E7D0-0x000000018459EBA0
		public static string GetStateName(uint fsmHandler, byte stateIndex) => default; // 0x0000000187992E30-0x0000000187992F94
		public static byte GetStateIndex(uint fsmHandler, int stateNameHash) => default; // 0x0000000184E53B80-0x0000000184E53D10
		public static void Dispose() {} // 0x0000000187992CE8-0x0000000187992E30
	}
}

namespace Beyond.Gameplay.Factory.Unsafe
{
	public static class BurstBridge // TypeDefIndex: 50069
	{
		// Nested types
		public unsafe delegate void SamplePredictCargo_00000A69_PostfixBurstDelegate(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation); // TypeDefIndex: 50067; 0x00000001840C67E0-0x00000001840C6850
	
		internal static class SamplePredictCargo_00000A69_BurstDirectCall // TypeDefIndex: 50068
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SamplePredictCargo_00000A69_BurstDirectCall() {} // 0x0000000181A52750-0x0000000181A533C0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068e14) {} // 0x0000000181A54B40-0x0000000181A54C80
			private static IntPtr GetFunctionPointer() => default; // 0x0000000181A54B20-0x0000000181A54B40
			public static void Constructor() {} // 0x0000000181A53D00-0x0000000181A54B20
			public static void Initialize() {} // 0x00000001817C0230-0x00000001817C0490
			public static unsafe void Invoke(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation) {
				position = default;
				rotation = default;
			} // 0x0000000181A533C0-0x0000000181A536C0
		}
	
		// Methods
		public static void BeginProfilerSample(string name) {} // 0x0000000181A51EB0-0x0000000181A52750
		public static void EndProfilerSample() {} // 0x0000000185492010-0x0000000185492020
		public static unsafe void SamplePredictCargo(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x0000000181A53CF0-0x0000000181A53D00
		public static unsafe void SamplePredictCargo_BurstManaged(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x0000000181A536C0-0x0000000181A53CF0
	}

	public static class EntityExtensions // TypeDefIndex: 50076
	{
		// Nested types
		public delegate FacBuildingState QueryBuildingState_00000A6D_PostfixBurstDelegate(ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState); // TypeDefIndex: 50070; 0x0000000187991A7C-0x0000000187991C38
	
		internal static class QueryBuildingState_00000A6D_BurstDirectCall // TypeDefIndex: 50071
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static QueryBuildingState_00000A6D_BurstDirectCall() {} // 0x0000000187990DA0-0x0000000187990EE4
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068e89) {} // 0x000000018799283C-0x00000001879928F0
			private static IntPtr GetFunctionPointer() => default; // 0x00000001879925C0-0x0000000187992620
			public static void Constructor() {} // 0x0000000187992B48-0x0000000187992BA8
			public static void Initialize() {} // 0x0000000187990CA0-0x0000000187990DA0
			public static FacBuildingState Invoke(ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState) {
				subState = default;
				return default;
			} // 0x0000000187991C38-0x0000000187991CBC
		}
	
		public delegate void SetFlashStatue_00000A6F_PostfixBurstDelegate(ref Entity logicEntity, ref EntityManager em, FacBuildingState statue); // TypeDefIndex: 50072; 0x0000000187991CBC-0x0000000187991D78
	
		internal static class SetFlashStatue_00000A6F_BurstDirectCall // TypeDefIndex: 50073
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SetFlashStatue_00000A6F_BurstDirectCall() {} // 0x0000000187991D78-0x0000000187991DA8
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068e98) {} // 0x00000001849839B0-0x0000000184983B60
			private static IntPtr GetFunctionPointer() => default; // 0x0000000184796310-0x0000000184796590
			public static void Constructor() {} // 0x00000001840929F0-0x0000000184092AC0
			public static void Initialize() {} // 0x0000000184092D20-0x0000000184092D70
			public static void Invoke(ref Entity logicEntity, ref EntityManager em, FacBuildingState statue) {} // 0x00000001843EFAA0-0x00000001843EFF90
		}
	
		public delegate void _SetRenderEntityFlashStatue_00000A70_PostfixBurstDelegate(ref EntityManager em, ref Entity rendererEntity, byte statue); // TypeDefIndex: 50074; 0x0000000187990EE4-0x0000000187991190
	
		internal static class _SetRenderEntityFlashStatue_00000A70_BurstDirectCall // TypeDefIndex: 50075
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SetRenderEntityFlashStatue_00000A70_BurstDirectCall() {} // 0x00000001879928F0-0x0000000187992B48
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068ea7) {} // 0x0000000187991488-0x0000000187991740
			private static IntPtr GetFunctionPointer() => default; // 0x0000000187991740-0x00000001879919A4
			public static void Constructor() {} // 0x0000000187991E6C-0x000000018799237C
			public static void Initialize() {} // 0x00000001879923DC-0x00000001879925C0
			public static void Invoke(ref EntityManager em, ref Entity rendererEntity, byte statue) {} // 0x0000000181A51D70-0x0000000181A51EB0
		}
	
		// Methods
		public static ref SharedDataContainer.SharedExtData GetExtData(Entity entity, ref EntityManager em) => ref _refReturnTypeForGetExtData; // 0x00000001817E31E0-0x00000001817E3200
		private ref SharedDataContainer.SharedExtData _refReturnTypeForGetExtData; // Dummy field
		public static unsafe ref SharedDataContainer.SharedExtData GetExtData(Entity entity, ref EntityManager em, SharedDataContainer.SharedExtData* sharedDataPtr) => ref _refReturnTypeForGetExtData; // 0x0000000181A50F00-0x0000000181A51D70
		private ref SharedDataContainer.SharedExtData _refReturnTypeForGetExtData; // Dummy field
		public static bool QueryBuildingStateIsClosed(Entity logicEntity) => default; // 0x00000001817C2D00-0x00000001817C2F70
		public static FacBuildingState QueryBuildingState(ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState) {
			subState = default;
			return default;
		} // 0x0000000181A4F970-0x0000000181A505E0
		private static bool _IsPowerBuilding(ref EntityManager em, ref Entity logicEntity) => default; // 0x0000000181A505E0-0x0000000181A508E0
		public static void SetFlashStatue(ref Entity logicEntity, ref EntityManager em, FacBuildingState statue) {} // 0x0000000181A4F0D0-0x0000000181A4F970
		private static void _SetRenderEntityFlashStatue(ref EntityManager em, ref Entity rendererEntity, byte statue) {} // 0x0000000185492010-0x0000000185492020
		public static bool CulledWithLogicEntity(Entity logicEntity, ref EntityManager em) => default; // 0x0000000181A50EF0-0x0000000181A50F00
		public static bool CulledWithRendererEntity(Entity rendererEntity, ref EntityManager em) => default; // 0x0000000181A508E0-0x0000000181A50EF0
		public static bool GetVisibility(Entity logicEntity, Visibility.Type type) => default; // 0x0000000181A578E0-0x0000000181A57A20
		public static bool GetVisibility(Entity logicEntity, ref EntityManager em, Visibility.Type type) => default; // 0x0000000181A578C0-0x0000000181A578E0
		public static unsafe bool GetVisibility(Entity logicEntity, ref EntityManager em, SharedDataContainer.SharedExtData* sharedDataPtr, Visibility.Type type) => default; // 0x0000000181A56AB0-0x0000000181A578C0
		public static bool SetVisibility(Entity logicEntity, ref EntityManager em, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short[] invisibleSubIndexList = null) => default; // 0x00000001817C0230-0x00000001817C0490
		public static unsafe bool SetVisibility(ref SharedDataContainer.SharedExtData extData, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short* subIndexListPtr = null, short subIndexCount = 0 /* Metadata: 0x020612DD */) => default; // 0x0000000181A55520-0x0000000181A56190
		public static void SetVisibilityWithNotify(Entity logicEntity, ref EntityManager em, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short[] invisibleSubIndexList = null) {} // 0x0000000181A56190-0x0000000181A56490
		public static bool SetVisibility(Entity logicEntity, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, ref EntityCommandBuffer ecb) => default; // 0x0000000181A54C80-0x0000000181A55520
		public static void SetInMainRegion(Entity logicEntity, bool value) {} // 0x0000000185492010-0x0000000185492020
		public static bool IsInMainRegionFuzzy(Entity logicEntity, ref EntityManager em) => default; // 0x0000000181A56AA0-0x0000000181A56AB0
		public static unsafe bool IsInMainRegion(SharedDataFragment sharedData, SharedDataContainer.SharedExtData* sharedDataPtr) => default; // 0x0000000181A56490-0x0000000181A56AA0
		public static void UpdatePipeEffect(Entity logicEntity, ref EntityManager em) {} // 0x0000000181A5A660-0x0000000181A5A7A0
		public static void UpdatePipeEffect(Entity logicEntity, ref EntityCommandBufferV2.EntityCommandBufferParallelWriter ecb) {} // 0x0000000181A578C0-0x0000000181A578E0
		public static unsafe bool GetBuildingExtendConfig(Entity logicEntity, ref EntityManager em, FixedString32Bytes extendKey, SharedDataContainer.SharedExtData* sharedDataPtr, out float3 pos, out quaternion rot, out Entity posRendererEntity) {
			pos = default;
			rot = default;
			posRendererEntity = default;
			return default;
		} // 0x0000000181A59850-0x0000000181A5A660
		public static bool GetBuildingExtendConfig(Entity logicEntity, ref EntityManager em, FixedString32Bytes extendKey, out float3 pos, out quaternion rot, out Entity posRendererEntity) {
			pos = default;
			rot = default;
			posRendererEntity = default;
			return default;
		} // 0x00000001817C0230-0x00000001817C0490
		public static bool GetBuildingStaticMountWorldTRS(Entity entity, string extendKey, out float3 pos, out quaternion rot) {
			pos = default;
			rot = default;
			return default;
		} // 0x0000000181A582C0-0x0000000181A58F30
		public static bool GetBuildingStaticMountWorldTRS(Entity entity, ref EntityManager em, FixedString32Bytes extendKey, out float3 pos, out quaternion rot) {
			pos = default;
			rot = default;
			return default;
		} // 0x0000000181A58F30-0x0000000181A59230
		public static unsafe bool GetBuildingStaticMountWorldTRS(Entity entity, ref EntityManager em, FixedString32Bytes extendKey, SharedDataContainer.SharedExtData* sharedDataPtr, out float3 pos, out quaternion rot) {
			pos = default;
			rot = default;
			return default;
		} // 0x0000000181A57A20-0x0000000181A582C0
		public static FacBuildingState QueryBuildingState_BurstManaged(ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState) {
			subState = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public static void SetFlashStatue_BurstManaged(ref Entity logicEntity, ref EntityManager em, FacBuildingState statue) {} // 0x0000000181A59840-0x0000000181A59850
		public static void _SetRenderEntityFlashStatue_BurstManaged(ref EntityManager em, ref Entity rendererEntity, byte statue) {} // 0x0000000181A59230-0x0000000181A59840
	}

	public static class GameplayExtensions // TypeDefIndex: 50077
	{
		// Methods
		public static void FacUnitAssertComponent<T>(EntityManager em, Entity entity)
			where T : struct, IComponentECS {}
		public static ref ChapterFragment GetChapterEntity(EntityManager em, int chapterId, out bool existed, out Entity chapterEntity) {
			existed = default;
			chapterEntity = default;
			return default;
		} // 0x000000018478ABB0-0x000000018478AF30
		private ref ChapterFragment _refReturnTypeForGetChapterEntity; // Dummy field
	}

	public static class GlobalEnvExtensions // TypeDefIndex: 50078
	{
		// Methods
		public static unsafe GlobalEnv* GetGlobalEnv(EntityManager em) => default; // 0x0000000184653510-0x00000001846536A0
		public static IntPtr GetGlobalEnvPtr(EntityManager em) => default; // 0x0000000187993E48-0x0000000187993EAC
		public static bool IsGlobalEnvValid(EntityManager em) => default; // 0x00000001846527F0-0x0000000184652880
		public static ref GlobalEnv GetGlobalEnvRef(EntityManager em) => ref _refReturnTypeForGetGlobalEnvRef; // 0x0000000184653310-0x0000000184653510
		private ref GlobalEnv _refReturnTypeForGetGlobalEnvRef; // Dummy field
		public static void SetNearBuildingPtr(ref GlobalEnv env, ref InteractFacCollectJob.BuildingInfo info, ref InteractFacCollectJob.BuildingInfo infoLast) {} // 0x0000000185D52EA0-0x0000000185D52EF0
		public static void SetNearConveyorPtr(ref GlobalEnv env, ref InteractFacCollectJob.LogisticInfo info, ref InteractFacCollectJob.LogisticInfo infoLast) {} // 0x0000000185D52EF0-0x0000000185D52F40
		public static void SetNearPipePtr(ref GlobalEnv env, ref InteractFacCollectJob.LogisticInfo info, ref InteractFacCollectJob.LogisticInfo infoLast) {} // 0x0000000185D52F40-0x0000000185D52F90
		public static bool GetInteractFac(ref GlobalEnv env, out InteractFacCollectJob.BuildingInfo info) {
			info = default;
			return default;
		} // 0x000000018478F800-0x000000018478F8A0
		public static bool GetInteractConveyor(ref GlobalEnv env, out InteractFacCollectJob.LogisticInfo info) {
			info = default;
			return default;
		} // 0x000000018478F790-0x000000018478F800
		public static bool GetInteractPipe(ref GlobalEnv env, out InteractFacCollectJob.LogisticInfo info) {
			info = default;
			return default;
		} // 0x000000018478F730-0x000000018478F790
	}

	public interface IAllocator : IDisposable // TypeDefIndex: 50079
	{
		// Methods
		LinearAllocator.Allocation Allocate(int size);
		void Reserve(int newCapacity);
		LinearAllocator.Allocation Expand(int startIndex, int additionalSize);
		LinearAllocator.Allocation Resize(int startIndex, int newSize);
		void Free(int startIndex);
	}

	public class LinearAllocator : Beyond.Gameplay.Factory.Unsafe.IAllocator // TypeDefIndex: 50082
	{
		// Fields
		private const int INITIAL_CAPACITY = 512; // Metadata: 0x020612E1
		private int m_totalCapacity; // 0x10
		private unsafe byte* m_memory; // 0x18
		private readonly Dictionary<int, int> _freeBlocks_k__BackingField; // 0x20
		private readonly Dictionary<int, int> m_allocations; // 0x28
	
		// Properties
		public Dictionary<int, int> freeBlocks { get; } // 0x00000001879969C0-0x0000000187996EAC 
	
		// Nested types
		public struct Allocation // TypeDefIndex: 50080
		{
			// Fields
			public int start; // 0x00
			public int end; // 0x04
			public bool reallocated; // 0x08
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 50081
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<int, int>, int> __9__10_0; // 0x08
			public static Func<KeyValuePair<int, int>, int> __9__10_1; // 0x10
			public static Func<KeyValuePair<int, int>, int> __9__18_0; // 0x18
			public static Func<KeyValuePair<int, int>, int> __9__18_1; // 0x20
	
			// Constructors
			static __c() {} // 0x00000001813B31A0-0x00000001813B31B0
			public __c() {} // 0x00000001879971A4-0x0000000187997294
	
			// Methods
			internal int _Allocate_b__10_0(KeyValuePair<int, int> b) => default; // 0x0000000187996EAC-0x0000000187997008
			internal int _Allocate_b__10_1(KeyValuePair<int, int> b) => default; // 0x0000000187994D58-0x00000001879956F4
			internal int _PrintAllocations_b__18_0(KeyValuePair<int, int> a) => default; // 0x00000001879968B8-0x00000001879969C0
			internal int _PrintAllocations_b__18_1(KeyValuePair<int, int> b) => default; // 0x00000001879957A8-0x0000000187995B54
		}
	
		// Constructors
		public LinearAllocator() {} // Dummy constructor
		public LinearAllocator(int capacity = 512 /* Metadata: 0x020612DF */) {} // 0x0000000187997008-0x00000001879971A4
	
		// Methods
		private void _ExpandMemory() {} // 0x0000000187995BC4-0x0000000187995FC4
		public Allocation Allocate(int size) => default; // 0x0000000185FB7CE0-0x0000000185FB7CF0
		public void Reserve(int newCapacity) {} // 0x00000001879956F4-0x00000001879957A8
		public Allocation Expand(int startIndex, int additionalSize) => default; // 0x0000000187995FC4-0x00000001879968B8
		public Allocation Resize(int startIndex, int newSize) => default; // 0x0000000187995B54-0x0000000187995BC4
		private void _MergeAdjacentFreeBlocks() {} // 0x0000000187997EBC-0x0000000187997F20
		public void Free(int startIndex) {} // 0x0000000185492010-0x0000000185492020
		public unsafe void* GetPointer(int offset) => default; // 0x0000000187997D9C-0x0000000187997DCC
		public void Dispose() {} // 0x0000000187997DCC-0x0000000187997DFC
		public void PrintAllocations() {} // 0x0000000187997DFC-0x0000000187997E2C
		~LinearAllocator() {} // 0x0000000187997E2C-0x0000000187997E5C
	}

	public struct LinearAllocatorUnmanaged : Beyond.Gameplay.Factory.Unsafe.IAllocator // TypeDefIndex: 50084
	{
		// Fields
		private const int INITIAL_CAPACITY = 512; // Metadata: 0x020612E6
		private int m_totalCapacity; // 0x00
		private unsafe byte* m_memory; // 0x08
		private NativeParallelHashMap<int, int> _freeBlocks_k__BackingField; // 0x10
		private NativeParallelHashMap<int, int> m_allocations; // 0x20
		private bool m_initialized; // 0x30
		private Unity.Collections.Allocator m_allocator; // 0x34
	
		// Properties
		public NativeParallelHashMap<int, int> freeBlocks { get; set; } // 0x0000000184D623D0-0x0000000184D638E0 0x0000000187994C48-0x0000000187994D58
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50083
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<int, int>, int> __9__20_1; // 0x08
			public static Func<KeyValuePair<int, int>, int> __9__20_0; // 0x10
	
			// Constructors
			static __c() {} // 0x00000001834A7540-0x00000001834A7550
			public __c() {} // 0x0000000185FB6860-0x0000000185FB6870
	
			// Methods
			internal int _PrintAllocations_b__20_1(KeyValuePair<int, int> a) => default; // 0x0000000184874060-0x00000001848741E0
			internal int _PrintAllocations_b__20_0(KeyValuePair<int, int> b) => default; // 0x0000000184D61E50-0x0000000184D61FA0
		}
	
		// Methods
		public void Initialize(int capacity = 512 /* Metadata: 0x020612E3 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x020612E5 */) {} // 0x0000000185B93860-0x0000000185B93A40
		private void _ExpandMemory() {} // 0x0000000185B93740-0x0000000185B93860
		public LinearAllocator.Allocation Allocate(int size) => default; // 0x00000001845CC5F0-0x00000001845CCFA0
		public void Reserve(int newCapacity) {} // 0x0000000185B93A40-0x0000000185B93B20
		public LinearAllocator.Allocation Expand(int startIndex, int additionalSize) => default; // 0x0000000184C41A00-0x0000000184C41A20
		public LinearAllocator.Allocation Resize(int startIndex, int newSize) => default; // 0x0000000187993FA8-0x00000001879940A4
		private void _MergeAdjacentFreeBlocks() {} // 0x00000001879940A4-0x0000000187994C48
		public void Free(int startIndex) {} // 0x0000000187997F20-0x0000000187997F84
		public unsafe void* GetPointer(long offset) => default; // 0x0000000185492010-0x0000000185492020
		public void Dispose() {} // 0x0000000187997E8C-0x0000000187997EBC
		public void PrintAllocations() {} // 0x0000000187997E5C-0x0000000187997E8C
	}

	internal struct TLSFBlockHeader // TypeDefIndex: 50085
	{
		// Fields
		public const int ALIGNMENT = 8; // Metadata: 0x020612E8
		public unsafe TLSFBlockHeader* prev; // 0x00
		public unsafe TLSFBlockHeader* next; // 0x08
		public unsafe TLSFBlockHeader* prePhys; // 0x10
		public uint size; // 0x18
		public bool isFree; // 0x1C
	}

	public class TLSFAllocator // TypeDefIndex: 50086
	{
		// Fields
		private const int FIRST_LEVEL_INDEX_COUNT = 32; // Metadata: 0x020612E9
		private const int SECOND_LEVEL_INDEX_COUNT = 32; // Metadata: 0x020612EA
		private const int SMALL_BLOCK_SIZE = 256; // Metadata: 0x020612EB
		private const int ALIGNMENT = 8; // Metadata: 0x020612ED
		private uint _flBitmap; // 0x10
		private uint[] _slBitmap; // 0x18
		private unsafe TLSFBlockHeader*[,] _freeList; // 0x20
		private IntPtr _memoryPool; // 0x28
		private uint _poolSize; // 0x30
		private unsafe TLSFBlockHeader* _firstBlock; // 0x38
	
		// Constructors
		public TLSFAllocator() {} // Dummy constructor
		public TLSFAllocator(uint size) {} // 0x0000000187997C78-0x0000000187997D9C
	
		// Methods
		~TLSFAllocator() {} // 0x000000018799764C-0x0000000187997704
		public unsafe void* Allocate(uint size) => default; // 0x00000001879975E0-0x000000018799764C
		public unsafe void Free(void* ptr) {} // 0x00000001879977B0-0x00000001879977EC
		public uint GetFreeSpace() => default; // 0x00000001879977EC-0x0000000187997888
		private unsafe TLSFBlockHeader* FindSuitableBlock(uint size) => default; // 0x0000000187997704-0x00000001879977B0
		private unsafe void InsertFreeBlock(TLSFBlockHeader* block) {} // 0x0000000187997888-0x0000000187997984
		private unsafe void RemoveFreeBlock(TLSFBlockHeader* block) {} // 0x0000000187997B10-0x0000000187997C08
		private unsafe void SplitBlock(TLSFBlockHeader* block, uint size) {} // 0x0000000187997C08-0x0000000187997C78
		private unsafe TLSFBlockHeader* MergeBlock(TLSFBlockHeader* block) => default; // 0x0000000187997A2C-0x0000000187997B10
		private void MappingInsert(uint size, out int fl, out int sl) {
			fl = default;
			sl = default;
		} // 0x0000000187997984-0x0000000187997A2C
		private static int MostSignificantBit(uint value) => default; // 0x0000000187990978-0x00000001879909D4
		private static int FindFirstSet(uint value) => default; // 0x0000000187990958-0x0000000187990978
		private static uint AlignSize(uint size) => default; // 0x0000000185FB7CF0-0x0000000185FB7D00
	}

	public class FactoryUnsafeUtil // TypeDefIndex: 50087
	{
		// Fields
		private const uint NO_NODE_ID_RANGE_MIN = 4000000000; // Metadata: 0x020612EF
		private const uint NO_NODE_ID_RANGE_MAX = 4294967294; // Metadata: 0x020612F4
		private static uint s_nodeId; // 0x00
	
		// Constructors
		public FactoryUnsafeUtil() {} // 0x0000000185492010-0x0000000185492020
		static FactoryUnsafeUtil() {} // 0x0000000185FA4C60-0x0000000185FA4CA0
	
		// Methods
		public static bool IsManualNodeId(uint id) => default; // 0x0000000187993BA8-0x0000000187993BBC
		public static uint AllocManualNodeId() => default; // 0x0000000184984130-0x00000001849841D0
		public static bool IsPointInSector(float3 point, float3 center, float3 dir, float checkRad, float checkDist, out float curDistanceSq, out float curCosTheta, bool ignoreY = true /* Metadata: 0x020612EE */) {
			curDistanceSq = default;
			curCosTheta = default;
			return default;
		} // 0x0000000187993BBC-0x0000000187993E48
		public static unsafe void SwapPointer<T>(ref ref T* p1, ref ref T* p2)
			where T : struct {}
		public static IntPtr AddressOf(ref GlobalEnv env) => default; // 0x000000018462D6F0-0x000000018462DBC0
		public static void CallFromLuaCheck() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class StructMarshal // TypeDefIndex: 50088
	{
		// Methods
		public static byte[] StructToBytes<T>(T str)
			where T : struct => default;
		public static byte[] UnmanagedStructToBytes<T>(T value)
			where T : struct => default;
		public static T BytesToStruct<T>(byte[] bytes, int offset)
			where T : struct => default;
		public static T BytesToUnmanagedStruct<T>(byte[] bytes, int offset = 0 /* Metadata: 0x020612F5 */)
			where T : struct => default;
		public static byte[] FixedList512BytesToBytes<T>(in FixedList512Bytes<T> list)
			where T : struct => default;
		public static FixedList512Bytes<T> BytesToFixedList512Bytes<T>(in byte[] bytes)
			where T : struct => default;
	}
}

namespace Beyond.Gameplay.Factory.Util
{
	public static class JobHandlerExtensions // TypeDefIndex: 50066
	{
		// Methods
		public static void SafeComplete(JobHandle jobHandle) {} // 0x0000000187993F40-0x0000000187993FA8
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond // TypeDefIndex: 49505
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		private static void InitializeAtRuntime() {} // 0x0000000185F05B60-0x0000000185F05B90
		private static void Initialize() {} // 0x0000000185F05B90-0x0000000185F05C10
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 49500
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 49501
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 49502
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 49503
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 49504
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace FactoryUIAtlas
{
	public class FactoryLiquidAtlasSOData : ScriptableObject // TypeDefIndex: 49465
	{
		// Fields
		public SerializeFieldDictionary<string, FacItemSubType> m_liquidMaterial; // 0x18
		public SerializeFieldDictionary<FacItemSubType, int> m_liquidMatIndex; // 0x20
	
		// Constructors
		public FactoryLiquidAtlasSOData() {} // 0x0000000185ECA3C0-0x0000000185ECA490
	
		// Methods
		public bool GetMaterial(string mat, out FacItemSubType matName) {
			matName = default;
			return default;
		} // 0x00000001879408D0-0x0000000187940934
		public bool GetAtlasMaterialSort(FacItemSubType matName, out int sort) {
			sort = default;
			return default;
		} // 0x000000018794086C-0x00000001879408D0
		public static FactoryLiquidAtlasSOData CreateOrGet(string path) => default; // 0x0000000187940788-0x000000018794086C
	}

	public class FactoryUIAtlasSOData : ScriptableObject // TypeDefIndex: 49466
	{
		// Fields
		public SerializeFieldDictionary<string, RectInt> m_insertName; // 0x18
		public SerializeFieldDictionary<string, int> m_insertIndex; // 0x20
	
		// Constructors
		public FactoryUIAtlasSOData() {} // 0x0000000185BC7C80-0x0000000185BC7D50
	
		// Methods
		public bool GetRect(string texName, out RectInt rect) {
			rect = default;
			return default;
		} // 0x00000001849B3760-0x00000001849B37D0
		public bool GetIndex(string texName, out int index) {
			index = default;
			return default;
		} // 0x0000000184CBFD90-0x0000000184CBFE30
		public static FactoryUIAtlasSOData CreateOrGet(string path) => default; // 0x0000000187940C10-0x0000000187940CF4
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 49464
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 50092
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64390-0x0000000185F64400
	
		// Methods
		public int __Gen_Wrap_0(object P0) => default; // 0x00000001873408C8-0x0000000187340998
		public NativeArray<int> __Gen_Wrap_1(object P0) => default; // 0x0000000187985F7C-0x0000000187986074
		public object __Gen_Wrap_2(int P0) => default; // 0x00000001879888EC-0x00000001879889D8
		public void __Gen_Wrap_3() {} // 0x0000000187678160-0x00000001876781FC
		public void __Gen_Wrap_4(ref PerDrawConfig P0) {} // 0x000000018798A088-0x000000018798A1E8
		public void __Gen_Wrap_5(ref FFactoryStateColorConfig P0) {} // 0x000000018798AE18-0x000000018798AF50
		public void __Gen_Wrap_6(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public NativeArray<ComponentType> __Gen_Wrap_7() => default; // 0x000000018798CE50-0x000000018798CF40
		public NativeArray<ComponentType> __Gen_Wrap_8(NativeArray<ComponentType> P0, object P1) => default; // 0x000000018798E3AC-0x000000018798E4F8
		public NativeArray<ComponentType> __Gen_Wrap_9(object P0) => default; // 0x000000018798F44C-0x000000018798F558
		public void __Gen_Wrap_10(ref ConveyorExtContainer P0) {} // 0x000000018797C52C-0x000000018797C674
		public uint __Gen_Wrap_11(ref ConveyorExtContainer P0) => default; // 0x000000018797D9AC-0x000000018797DAF0
		public Span<ConveyorExtContainer.ConveyorExt> __Gen_Wrap_12(ref ConveyorExtContainer P0) => default; // 0x000000018797F148-0x000000018797F2B8
		public uint __Gen_Wrap_13(ref ConveyorExtContainer P0, ref ConveyorExtContainer.ConveyorExt P1) => default; // 0x0000000187980378-0x0000000187980558
		public void __Gen_Wrap_14(ref ConveyorExtContainer P0, uint P1) {} // 0x00000001879810D4-0x0000000187981234
		public IntPtr __Gen_Wrap_15(ref ConveyorExtContainer P0) => default; // 0x0000000187981F30-0x0000000187982088
		public ref ConveyorExtContainer.ConveyorExt __Gen_Wrap_16(ref ConveyorExtContainer P0, uint P1) => ref _refReturnTypeFor__Gen_Wrap_16; // 0x0000000187982C94-0x0000000187982E04
		private ref ConveyorExtContainer.ConveyorExt _refReturnTypeFor__Gen_Wrap_16; // Dummy field
		public void __Gen_Wrap_17(ref ConveyorExtContainer.ConveyorExt P0) {} // 0x0000000187983950-0x0000000187983A94
		public void __Gen_Wrap_18(ref LinearAllocatorUnmanaged P0) {} // 0x0000000187984D5C-0x0000000187984EC4
		public LinearAllocator.Allocation __Gen_Wrap_19(ref LinearAllocatorUnmanaged P0, int P1) => default; // 0x0000000187985DB8-0x0000000187985F7C
		public LinearAllocator.Allocation __Gen_Wrap_20(ref ConveyorInfoAllocator P0, int P1) => default; // 0x00000001879879F0-0x0000000187987BB4
		public void __Gen_Wrap_21(ref LinearAllocatorUnmanaged P0, int P1) {} // 0x0000000187987BB4-0x0000000187987D34
		public LinearAllocator.Allocation __Gen_Wrap_22(ref LinearAllocatorUnmanaged P0, int P1, int P2) => default; // 0x0000000187987D34-0x0000000187987F08
		public LinearAllocator.Allocation __Gen_Wrap_23(ref ConveyorInfoAllocator P0, LinearAllocator.Allocation P1, int P2) => default; // 0x0000000187987F08-0x0000000187988108
		public void __Gen_Wrap_24(ref ConveyorInfoAllocator P0, uint P1) {} // 0x0000000187988108-0x0000000187988288
		public long __Gen_Wrap_25(ref ConveyorInfoAllocator P0, uint P1) => default; // 0x0000000187988288-0x0000000187988418
		public int __Gen_Wrap_26(KeyValuePair<int, int> P0) => default; // 0x0000000187988418-0x000000018798850C
		public void __Gen_Wrap_27(ref ConveyorInfoAllocator P0) {} // 0x000000018798850C-0x0000000187988660
		public void __Gen_Wrap_28(ref SharedDataContainer P0) {} // 0x0000000187988660-0x00000001879887A8
		public uint __Gen_Wrap_29(ref SharedDataContainer P0) => default; // 0x00000001879887A8-0x00000001879888EC
		public Span<SharedDataContainer.SharedExtData> __Gen_Wrap_30(ref SharedDataContainer P0) => default; // 0x00000001879889D8-0x0000000187988B48
		public uint __Gen_Wrap_31(ref SharedDataContainer P0, ref SharedDataContainer.SharedExtData P1) => default; // 0x0000000187988B48-0x0000000187988D48
		public void __Gen_Wrap_32(ref SharedDataContainer P0, uint P1) {} // 0x0000000187988D48-0x0000000187988EA8
		public IntPtr __Gen_Wrap_33(ref SharedDataContainer P0) => default; // 0x0000000187988EA8-0x0000000187989000
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_34(ref SharedDataContainer P0, uint P1) => ref _refReturnTypeFor__Gen_Wrap_34; // 0x0000000187989000-0x0000000187989170
		private ref SharedDataContainer.SharedExtData _refReturnTypeFor__Gen_Wrap_34; // Dummy field
		public bool __Gen_Wrap_35(ref SharedDataContainer.SharedExtData P0, SharedDataContainer.DirtyFlag P1) => default; // 0x0000000187989170-0x00000001879892E0
		public void __Gen_Wrap_36(ref SharedDataContainer.SharedExtData P0, SharedDataContainer.DirtyFlag P1, bool P2) {} // 0x00000001879892E0-0x000000018798945C
		public bool __Gen_Wrap_37(ref SharedDataContainer.SharedExtData P0) => default; // 0x000000018798945C-0x00000001879895C4
		public float3 __Gen_Wrap_38(ref WireRendererInfo P0) => default; // 0x00000001879895C4-0x0000000187989748
		public quaternion __Gen_Wrap_39(ref WireRendererInfo P0) => default; // 0x0000000187989748-0x00000001879898C4
		public NativeParallelHashMap<UnitId, Entity> __Gen_Wrap_40(object P0) => default; // 0x00000001879898C4-0x00000001879899BC
		public UnitId __Gen_Wrap_41(int P0, uint P1) => default; // 0x00000001879899BC-0x0000000187989AC4
		public void __Gen_Wrap_42(object P0, int P1, uint P2, Entity P3) {} // 0x0000000187989AC4-0x0000000187989BF4
		public bool __Gen_Wrap_43(object P0, int P1, uint P2) => default; // 0x0000000187989BF4-0x0000000187989CF8
		public bool __Gen_Wrap_44(object P0, int P1, uint P2, out Entity P3) {
			P3 = default;
			return default;
		} // 0x0000000187989CF8-0x0000000187989E54
		public void __Gen_Wrap_45(ref VATFSMDefinitionContainer P0) {} // 0x0000000187989E54-0x0000000187989F9C
		public uint __Gen_Wrap_46() => default; // 0x000000018735B550-0x000000018735B5FC
		public void __Gen_Wrap_47(uint P0) {} // 0x0000000187937E4C-0x0000000187937F0C
		public ref ConveyorExtContainer.ConveyorExt __Gen_Wrap_48(uint P0) => ref _refReturnTypeFor__Gen_Wrap_48; // 0x0000000187989F9C-0x000000018798A088
		private ref ConveyorExtContainer.ConveyorExt _refReturnTypeFor__Gen_Wrap_48; // Dummy field
		public IntPtr __Gen_Wrap_49() => default; // 0x000000018735B4A4-0x000000018735B550
		public uint __Gen_Wrap_50(bool P0) => default; // 0x000000018798A1E8-0x000000018798A2B8
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_51(uint P0) => ref _refReturnTypeFor__Gen_Wrap_51; // 0x000000018798A2B8-0x000000018798A3A4
		private ref SharedDataContainer.SharedExtData _refReturnTypeFor__Gen_Wrap_51; // Dummy field
		public ref EntityHierarchyContainer.EntityTransformData __Gen_Wrap_52(uint P0) => ref _refReturnTypeFor__Gen_Wrap_52; // 0x000000018798A3A4-0x000000018798A490
		private ref EntityHierarchyContainer.EntityTransformData _refReturnTypeFor__Gen_Wrap_52; // Dummy field
		public ref EntityHierarchyContainer.EntityTransformData __Gen_Wrap_53(int P0) => ref _refReturnTypeFor__Gen_Wrap_53; // 0x000000018798A490-0x000000018798A57C
		private ref EntityHierarchyContainer.EntityTransformData _refReturnTypeFor__Gen_Wrap_53; // Dummy field
		public float4x4 __Gen_Wrap_54(ref LocalTransform P0) => default; // 0x000000018798A57C-0x000000018798A710
		public float4x4 __Gen_Wrap_55(in EntityHierarchyContainer.EntityTransformData P0) => default; // 0x000000018798A710-0x000000018798A874
		public uint __Gen_Wrap_56(ref VATFSMDefinitionContainer P0, ref VATFSMDefinition P1) => default; // 0x000000018798A874-0x000000018798AA74
		public uint __Gen_Wrap_57(ref VATFSMDefinition P0) => default; // 0x000000018798AA74-0x000000018798ABDC
		public ref VATFSMDefinition __Gen_Wrap_58(uint P0) => ref _refReturnTypeFor__Gen_Wrap_58; // 0x000000018798ABDC-0x000000018798ACC8
		private ref VATFSMDefinition _refReturnTypeFor__Gen_Wrap_58; // Dummy field
		public void __Gen_Wrap_59(ref VATFSMDefinitionContainer P0, uint P1) {} // 0x000000018798ACC8-0x000000018798AE18
		public IntPtr __Gen_Wrap_60(ref VATFSMDefinitionContainer P0) => default; // 0x000000018798AF50-0x000000018798B0A8
		public AdditiveEffectFragment.AdditiveEffectType __Gen_Wrap_61(ref AdditiveEffectFragment P0) => default; // 0x000000018798B0A8-0x000000018798B210
		public void __Gen_Wrap_62(ref AdditiveEffectFragment P0) {} // 0x000000018798B210-0x000000018798B368
		public void __Gen_Wrap_63(ref AdditiveEffectFragment P0, AdditiveEffectFragment.AdditiveEffectType P1) {} // 0x000000018798B368-0x000000018798B4DC
		public void __Gen_Wrap_64(ref AdditiveEffectFragment P0, int P1, AdditiveEffectFragment.AdditiveEffectType P2) {} // 0x000000018798B4DC-0x000000018798B66C
		public string __Gen_Wrap_65(ref AdditiveEffectFragment P0) => default; // 0x000000018798B66C-0x000000018798B7E4
		public void __Gen_Wrap_66(ref CutoffState P0, bool P1) {} // 0x000000018798B7E4-0x000000018798B924
		public void __Gen_Wrap_67(ref CutoffState P0, float P1) {} // 0x000000018798B924-0x000000018798BA74
		public void __Gen_Wrap_68(ref CutoffState P0, uint P1) {} // 0x000000018798BA74-0x000000018798BBB0
		public void __Gen_Wrap_69(ref BuildDismissState P0, bool P1) {} // 0x000000018798BBB0-0x000000018798BD00
		public void __Gen_Wrap_70(ref HighLightState P0, bool P1) {} // 0x000000018798BD00-0x000000018798BF08
		public void __Gen_Wrap_71(ref HighLightState P0, bool P1, bool P2) {} // 0x000000018798BF08-0x000000018798C124
		public LogicEntityState __Gen_Wrap_72(ref HighLightState P0) => default; // 0x000000018798C124-0x000000018798C310
		public bool __Gen_Wrap_73(ref HighLightState P0, byte P1) => default; // 0x000000018798C310-0x000000018798C518
		public void __Gen_Wrap_74(ref HighLightState P0, byte P1, bool P2) {} // 0x000000018798C518-0x000000018798C734
		public void __Gen_Wrap_75(ref HighLightState P0) {} // 0x000000018798C734-0x000000018798C920
		public void __Gen_Wrap_76(ref HintState P0, bool P1) {} // 0x000000018798C920-0x000000018798CA6C
		public void __Gen_Wrap_77(ref FigureState P0, bool P1) {} // 0x000000018798CA6C-0x000000018798CBB8
		public void __Gen_Wrap_78(ref OverloadState P0, bool P1) {} // 0x000000018798CBB8-0x000000018798CD04
		public void __Gen_Wrap_79(ref OverloadInvalidState P0, bool P1) {} // 0x000000018798CD04-0x000000018798CE50
		public void __Gen_Wrap_80(ref DitherState P0, bool P1) {} // 0x000000018798CF40-0x000000018798D074
		public void __Gen_Wrap_81(ref BlueprintState P0, bool P1) {} // 0x000000018798D074-0x000000018798D2A0
		public void __Gen_Wrap_82(ref BlueprintState P0, bool P1, BlueprintState.EffectType P2) {} // 0x000000018798D2A0-0x000000018798D4E8
		public bool __Gen_Wrap_83(ref BlueprintState P0, byte P1) => default; // 0x000000018798D4E8-0x000000018798D714
		public void __Gen_Wrap_84(ref BlueprintState P0, byte P1, bool P2) {} // 0x000000018798D714-0x000000018798D95C
		public void __Gen_Wrap_85(ref BlueprintState P0) {} // 0x000000018798D95C-0x000000018798DB74
		public void __Gen_Wrap_86(ref PreSelectState P0, bool P1) {} // 0x000000018798DB74-0x000000018798DD80
		public bool __Gen_Wrap_87(ref PreSelectState P0, byte P1) => default; // 0x000000018798DD80-0x000000018798DF8C
		public void __Gen_Wrap_88(ref PreSelectState P0, byte P1, bool P2) {} // 0x000000018798DF8C-0x000000018798E1B4
		public void __Gen_Wrap_89(ref PreSelectState P0) {} // 0x000000018798E1B4-0x000000018798E3AC
		public void __Gen_Wrap_90(ref SoloSelectState P0, bool P1) {} // 0x000000018798E4F8-0x000000018798E62C
		public bool __Gen_Wrap_91(ref SoloSelectState P0, int P1) => default; // 0x000000018798E62C-0x000000018798E76C
		public void __Gen_Wrap_92(ref ContinuationState P0, bool P1) {} // 0x000000018798E76C-0x000000018798E978
		public bool __Gen_Wrap_93(ref ContinuationState P0, byte P1) => default; // 0x000000018798E978-0x000000018798EB84
		public void __Gen_Wrap_94(ref ContinuationState P0, byte P1, bool P2) {} // 0x000000018798EB84-0x000000018798ED98
		public void __Gen_Wrap_95(ref ContinuationState P0) {} // 0x000000018798ED98-0x000000018798EF7C
		public void __Gen_Wrap_96(ref SocialSharingState P0, bool P1) {} // 0x000000018798EF7C-0x000000018798F0AC
		public void __Gen_Wrap_97(ref PowerInteractionState P0, bool P1) {} // 0x000000018798F0AC-0x000000018798F1DC
		public bool __Gen_Wrap_98(ref AdditiveEffectRendererFragment P0) => default; // 0x000000018798F1DC-0x000000018798F31C
		public void __Gen_Wrap_99(ref AdditiveEffectRendererFragment P0) {} // 0x000000018798F31C-0x000000018798F44C
		public void __Gen_Wrap_100(ref BattleFragment P0) {} // 0x000000018797B5CC-0x000000018797B6FC
		public bool __Gen_Wrap_101(ref BindRenderEntityFragment P0, Entity P1) => default; // 0x000000018797B6FC-0x000000018797B8E4
		public void __Gen_Wrap_102(ref BindRenderEntityFragment P0, Entity P1) {} // 0x000000018797B8E4-0x000000018797BABC
		public void __Gen_Wrap_103(ref BindRenderEntityFragment P0, object P1) {} // 0x000000018797BABC-0x000000018797BC64
		public void __Gen_Wrap_104(ref BindRenderEntityFragment P0, NativeArray<Entity> P1) {} // 0x000000018797BC64-0x000000018797BE48
		public void __Gen_Wrap_105(ref BindRenderEntityFragment P0) {} // 0x000000018797BE48-0x000000018797BFE8
		public bool __Gen_Wrap_106(ref BindRenderEntityFragment P0) => default; // 0x000000018797BFE8-0x000000018797C198
		public void __Gen_Wrap_107(ref BurnPowerFragment P0) {} // 0x000000018797C198-0x000000018797C2F8
		public void __Gen_Wrap_108(ref BusFragment P0) {} // 0x000000018797C2F8-0x000000018797C410
		public void __Gen_Wrap_109(ref BusFreeFragment P0) {} // 0x000000018797C410-0x000000018797C52C
		public unsafe int __Gen_Wrap_110(ref CacheFragment P0, bool P1, bool P2, int P3, int P4, out FactoryItem* P5) {
			P5 = default;
			return default;
		} // 0x000000018797C674-0x000000018797C928
		public void __Gen_Wrap_111(ref CacheFragment P0, bool P1, bool P2, int P3, int P4, out uint P5, out int P6, out long P7) {
			P5 = default;
			P6 = default;
			P7 = default;
		} // 0x000000018797C928-0x000000018797CC28
		public void __Gen_Wrap_112(ref CacheFragment P0, bool P1, bool P2, int P3, int P4, uint P5, int P6, long P7) {} // 0x000000018797CC28-0x000000018797CEB0
		public void __Gen_Wrap_113(ref CacheFragment P0, bool P1, bool P2, int P3, int P4) {} // 0x000000018797CEB0-0x000000018797D100
		public void __Gen_Wrap_114(ref CacheFragment P0) {} // 0x000000018797D100-0x000000018797D2E4
		public void __Gen_Wrap_115(ref CacheTransportFragment P0) {} // 0x000000018797D2E4-0x000000018797D414
		public float __Gen_Wrap_116(ref CargoFragment P0, long P1) => default; // 0x000000018797D414-0x000000018797D5E4
		public int __Gen_Wrap_117(ref CargoFragment P0, CargoFragment P1) => default; // 0x000000018797D5E4-0x000000018797D808
		public CargoFragment __Gen_Wrap_118(uint P0, int4 P1, int4 P2, object P3, int P4, long P5, int P6, float P7, bool P8) => default; // 0x00000001818B01F0-0x00000001818B0EA0
		public void __Gen_Wrap_119(ref CargoFragment P0) {} // 0x000000018797D808-0x000000018797D9AC
		public void __Gen_Wrap_120(ref CargoRendererFragment P0) {} // 0x000000018797DAF0-0x000000018797DC08
		public void __Gen_Wrap_121(ref ChapterFragment P0) {} // 0x000000018797DC08-0x000000018797DD94
		public void __Gen_Wrap_122(ref CollectorFragment P0) {} // 0x000000018797DD94-0x000000018797DEB8
		public bool __Gen_Wrap_123(ref ConnectionFragment P0) => default; // 0x000000018797DEB8-0x000000018797E020
		public void __Gen_Wrap_124(ref ConnectionFragment P0) {} // 0x000000018797E020-0x000000018797E164
		public unsafe void __Gen_Wrap_125(ref GlobalEnv P0, uint P1, int P2, out ConveyorInfoAllocator.Info* P3) {
			P3 = default;
		} // 0x000000018797E164-0x000000018797E44C
		public void __Gen_Wrap_126(NativeList<float3> P0, ref UnityEngine.Rect P1) {} // 0x000000018797E44C-0x000000018797E5C0
		public void __Gen_Wrap_127(ref ConveyorFragment P0, ref GlobalEnv P1, ref NativeList<float3> P2, ref NativeList<float3> P3, ref NativeArray<byte> P4) {} // 0x000000018797E5C0-0x000000018797EA30
		public bool __Gen_Wrap_128(ref ConveyorFragment P0, ref GlobalEnv P1, float2 P2, out uint P3, out int P4) {
			P3 = default;
			P4 = default;
			return default;
		} // 0x000000018797EA30-0x000000018797EDEC
		public bool __Gen_Wrap_129(ref ConveyorFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5) => default; // 0x000000018797EDEC-0x000000018797F148
		public bool __Gen_Wrap_130(ref ConveyorFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref PooledList<int> P6) => default; // 0x000000018797F2B8-0x000000018797F670
		public bool __Gen_Wrap_131(ref ConveyorFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref ValueTuple<uint, int>[,] P6) => default; // 0x000000018797F670-0x000000018797FA28
		public void __Gen_Wrap_132(ref ConveyorFragment P0, float P1) {} // 0x000000018797FA28-0x000000018797FB80
		public void __Gen_Wrap_133(ref ConveyorFragment P0) {} // 0x000000018797FB80-0x000000018797FCBC
		public void __Gen_Wrap_134(ref ConveyorLogisticsUnitFragment P0) {} // 0x000000018797FCBC-0x000000018797FDD4
		public void __Gen_Wrap_135(ref ConveyorRenderFragment P0) {} // 0x000000018797FDD4-0x000000018797FF18
		public void __Gen_Wrap_136(ref LeftFragment P0) {} // 0x000000018797FF18-0x0000000187980030
		public void __Gen_Wrap_137(ref RightFragment P0) {} // 0x0000000187980030-0x0000000187980148
		public void __Gen_Wrap_138(ref MidFragment P0) {} // 0x0000000187980148-0x0000000187980260
		public void __Gen_Wrap_139(ref CullResultFragment P0) {} // 0x0000000187980260-0x0000000187980378
		public void __Gen_Wrap_140(ref DebugFragment P0) {} // 0x0000000187980558-0x000000018798065C
		public void __Gen_Wrap_141(ref EvtDestroyUnit P0) {} // 0x000000018798065C-0x0000000187980780
		public void __Gen_Wrap_142(ref ShowStateUI P0) {} // 0x0000000187980780-0x0000000187980898
		public void __Gen_Wrap_143(ref ShowNameUI P0) {} // 0x0000000187980898-0x00000001879809B0
		public void __Gen_Wrap_144(ref HasRenderer P0) {} // 0x00000001879809B0-0x0000000187980AC8
		public void __Gen_Wrap_145(ref EvtUpdatePipeEffect P0) {} // 0x0000000187980AC8-0x0000000187980BE4
		public void __Gen_Wrap_146(ref EvtChangeTemplate P0) {} // 0x0000000187980BE4-0x0000000187980D80
		public void __Gen_Wrap_147(ref EvtCreateUnitRenderer P0) {} // 0x0000000187980D80-0x0000000187980E9C
		public void __Gen_Wrap_148(ref EvtUpdateStatusEffect P0) {} // 0x0000000187980E9C-0x0000000187980FB8
		public void __Gen_Wrap_149(ref EvtPendingCreateRenderer P0) {} // 0x0000000187980FB8-0x00000001879810D4
		public void __Gen_Wrap_150(ref EvtUpdateRendererProperty P0) {} // 0x0000000187981234-0x0000000187981358
		public void __Gen_Wrap_151(ref EvtStatusChange P0) {} // 0x0000000187981358-0x0000000187981488
		public void __Gen_Wrap_152(ref EvtCreateInteract P0) {} // 0x0000000187981488-0x00000001879815AC
		public void __Gen_Wrap_153(ref EvtVatUpdate P0) {} // 0x00000001879815AC-0x00000001879816D0
		public void __Gen_Wrap_154(ref EvtUpdatePedestalColorLUT P0) {} // 0x00000001879816D0-0x0000000187981800
		public void __Gen_Wrap_155(ref EvtAudio P0) {} // 0x0000000187981800-0x0000000187981924
		public void __Gen_Wrap_156(ref AudioFragment P0) {} // 0x0000000187981924-0x0000000187981A54
		public void __Gen_Wrap_157(ref ReleaseTagFragment P0) {} // 0x0000000187981A54-0x0000000187981B6C
		public void __Gen_Wrap_158(ref CurMapUnitTag P0) {} // 0x0000000187981B6C-0x0000000187981C84
		public UnitFragment __Gen_Wrap_159(uint P0, object P1, int P2, bool2 P3, int P4, uint P5, object P6, bool P7, bool P8, bool P9, long P10, bool P11, object P12) => default; // 0x0000000187981C84-0x0000000187981F30
		public void __Gen_Wrap_160(ref UnitFragment P0) {} // 0x0000000187982088-0x00000001879822BC
		public void __Gen_Wrap_161(ref UnitRenderPipeLogisticsFigureReplaceFragment P0) {} // 0x00000001879822BC-0x00000001879823D4
		public void __Gen_Wrap_162(ref BusRenderFragment P0) {} // 0x00000001879823D4-0x00000001879824EC
		public void __Gen_Wrap_163(ref UnitRenderBuildingFragment P0) {} // 0x00000001879824EC-0x0000000187982604
		public void __Gen_Wrap_164(ref UnitRenderPedestalFragment P0) {} // 0x0000000187982604-0x000000018798271C
		public void __Gen_Wrap_165(ref UnitRendererRegularFragment P0) {} // 0x000000018798271C-0x0000000187982834
		public void __Gen_Wrap_166(ref UnitOnlyRendererFragment P0) {} // 0x0000000187982834-0x000000018798294C
		public void __Gen_Wrap_167(ref FakeUnitFragment P0) {} // 0x000000018798294C-0x0000000187982A64
		public void __Gen_Wrap_168(ref UIUnitFragment P0) {} // 0x0000000187982A64-0x0000000187982B7C
		public void __Gen_Wrap_169(ref GuideHintFragment P0) {} // 0x0000000187982B7C-0x0000000187982C94
		public void __Gen_Wrap_170(ref UnitPreviewFragment P0) {} // 0x0000000187982E04-0x0000000187982F34
		public void __Gen_Wrap_171(ref ConveyorRegularFragment P0) {} // 0x0000000187982F34-0x000000018798304C
		public void __Gen_Wrap_172(ref ConveyorGuideFragment P0) {} // 0x000000018798304C-0x0000000187983164
		public void __Gen_Wrap_173(ref PipeRegularFragment P0) {} // 0x0000000187983164-0x000000018798327C
		public void __Gen_Wrap_174(ref ConveyorPreviewRendererFragment P0) {} // 0x000000018798327C-0x00000001879833A8
		public void __Gen_Wrap_175(ref PipePreviewRendererFragment P0) {} // 0x00000001879833A8-0x00000001879834D8
		public void __Gen_Wrap_176(ref PipePreviewFragment P0) {} // 0x00000001879834D8-0x00000001879835F0
		public void __Gen_Wrap_177(ref FigureRenderFragment P0) {} // 0x00000001879835F0-0x0000000187983720
		public void __Gen_Wrap_178(ref FigureRenderLeftFragment P0) {} // 0x0000000187983720-0x0000000187983838
		public void __Gen_Wrap_179(ref FigureRenderRightFragment P0) {} // 0x0000000187983838-0x0000000187983950
		public void __Gen_Wrap_180(ref FigureRenderMidFragment P0) {} // 0x0000000187983A94-0x0000000187983BAC
		public void __Gen_Wrap_181(ref FigureRenderPipeHolderFragment P0) {} // 0x0000000187983BAC-0x0000000187983CC4
		public void __Gen_Wrap_182(ref FluidConsumeFragment P0) {} // 0x0000000187983CC4-0x0000000187983DE0
		public void __Gen_Wrap_183(ref FluidContainerFragment P0, int P1, int P2, int P3, int P4) {} // 0x0000000187983DE0-0x0000000187984020
		public void __Gen_Wrap_184(ref FluidContainerFragment P0, int P1, int P2) {} // 0x0000000187984020-0x0000000187984240
		public bool __Gen_Wrap_185(ref FluidContainerFragment P0, int P1, out int P2, out int P3, out float P4, out int P5, out int P6) {
			P2 = default;
			P3 = default;
			P4 = default;
			P5 = default;
			P6 = default;
			return default;
		} // 0x0000000187984240-0x0000000187984568
		public bool __Gen_Wrap_186(ref FluidContainerFragment P0) => default; // 0x0000000187984568-0x000000018798476C
		public void __Gen_Wrap_187(ref FluidContainerFragment P0, float P1) {} // 0x000000018798476C-0x0000000187984968
		public ValueTuple<int, uint> __Gen_Wrap_188(ref FluidContainerFragment P0) => default; // 0x0000000187984968-0x0000000187984B68
		public void __Gen_Wrap_189(ref FluidContainerFragment P0) {} // 0x0000000187984B68-0x0000000187984D5C
		public string __Gen_Wrap_190(ref FluidContainerFragment P0) => default; // 0x0000000187984EC4-0x00000001879850C4
		public void __Gen_Wrap_191(ref FluidPumpInFragment P0) {} // 0x00000001879850C4-0x00000001879851DC
		public void __Gen_Wrap_192(ref FluidPumpOutFragment P0) {} // 0x00000001879851DC-0x00000001879852F4
		public void __Gen_Wrap_193(ref FluidReactionFragment P0) {} // 0x00000001879852F4-0x000000018798540C
		public void __Gen_Wrap_194(ref FluidSprayFragment P0) {} // 0x000000018798540C-0x0000000187985528
		public void __Gen_Wrap_195(ref FormulaManualFragment P0) {} // 0x0000000187985528-0x0000000187985658
		public void __Gen_Wrap_196(ref OutOfBufferWarning P0) {} // 0x0000000187985658-0x0000000187985790
		public string __Gen_Wrap_197(ref OutOfBufferWarning P0) => default; // 0x0000000187985790-0x00000001879858D8
		public bool __Gen_Wrap_198(ref GlobalEnv P0) => default; // 0x00000001879858D8-0x0000000187985B50
		public void __Gen_Wrap_199(ref GlobalEnv P0) {} // 0x0000000187985B50-0x0000000187985DB8
		public UnsafeList<float4x4> __Gen_Wrap_200(ref GlobalEnv P0) => default; // 0x0000000187986074-0x0000000187986314
		public UnsafeList<OutputRendererInfo> __Gen_Wrap_201(ref GlobalEnv P0) => default; // 0x0000000187986314-0x00000001879865B4
		public UnsafeList<Matrix4x4> __Gen_Wrap_202(ref GlobalEnv P0) => default; // 0x00000001879865B4-0x0000000187986854
		public ref ConveyorInfoAllocator.Info __Gen_Wrap_203(ref GlobalEnv P0, uint P1, int P2) => ref _refReturnTypeFor__Gen_Wrap_203; // 0x0000000187986854-0x0000000187986B10
		private ref ConveyorInfoAllocator.Info _refReturnTypeFor__Gen_Wrap_203; // Dummy field
		public LinearAllocator.Allocation __Gen_Wrap_204(ref GlobalEnv P0, int P1) => default; // 0x0000000187986B10-0x0000000187986DD4
		public long __Gen_Wrap_205(ref GlobalEnv P0, uint P1) => default; // 0x0000000187986DD4-0x0000000187987060
		public LinearAllocator.Allocation __Gen_Wrap_206(ref GlobalEnv P0, uint P1, int P2) => default; // 0x0000000187987060-0x0000000187987338
		public void __Gen_Wrap_207(ref GlobalEnv P0, uint P1) {} // 0x0000000187987338-0x00000001879875B4
		public UnsafeList<VATFSMProcessor.SetAnimatorParamRequest> __Gen_Wrap_208(ref GlobalEnv P0) => default; // 0x00000001879875B4-0x0000000187987840
		public bool __Gen_Wrap_209(VATFSMDefinition P0, int P1, out byte P2, out Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P3) {
			P2 = default;
			P3 = default;
			return default;
		} // 0x0000000187987840-0x00000001879879F0
		public StringIntern.FastId __Gen_Wrap_210(int P0) => default; // 0x00000001818B0EA0-0x00000001818B16D0
		public byte __Gen_Wrap_211(uint P0, int P1) => default; // 0x00000001818B16D0-0x00000001818B18F0
		public void __Gen_Wrap_212(ref GlobalEnv P0, ref EntityManager P1, Entity P2, in VATFSMProcessor.SetAnimatorParamRequest P3) {} // 0x00000001818B18F0-0x00000001818B3030
		public void __Gen_Wrap_213(ref GlobalEnv P0, Entity P1, VATFSMProcessor.SetAnimatorParamRequest P2) {} // 0x00000001818B3030-0x00000001818B4120
		public UnsafeList<VATFSMProcessor.VATFSMAudioData> __Gen_Wrap_214(ref GlobalEnv P0) => default; // 0x00000001818B4120-0x00000001818B5210
		public ref VATFSMProcessor.VATFSMAudioData __Gen_Wrap_215(ref GlobalEnv P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_215; // 0x00000001818B5210-0x00000001818B6320
		private ref VATFSMProcessor.VATFSMAudioData _refReturnTypeFor__Gen_Wrap_215; // Dummy field
		public int __Gen_Wrap_216(ref GlobalEnv P0) => default; // 0x00000001818B6320-0x00000001818B7100
		public void __Gen_Wrap_217(ref HealthPoleFragment P0) {} // 0x00000001818B7100-0x00000001818B7CA0
		public void __Gen_Wrap_218(ref InventoryFragment P0) {} // 0x00000001818B7CA0-0x00000001818B8840
		public void __Gen_Wrap_219(ref LiquidPurifierFragment P0) {} // 0x00000001818B8840-0x00000001818B93E0
		public void __Gen_Wrap_220(ref LogisticEffectFragment P0) {} // 0x00000001818B93E0-0x00000001818B9FA0
		public void __Gen_Wrap_221(ref LogisticEntityBindFragment P0, Entity P1, uint P2) {} // 0x00000001818B9FA0-0x00000001818BAF90
		public bool __Gen_Wrap_222(ref LogisticEntityBindFragment P0, out Entity P1) {
			P1 = default;
			return default;
		} // 0x00000001818BAF90-0x00000001818BBD90
		public void __Gen_Wrap_223(ref LogisticEntityBindFragment P0) {} // 0x00000001818BBD90-0x00000001818BC960
		public void __Gen_Wrap_224(ref MapGridRendererFragment P0) {} // 0x00000001818BC960-0x00000001818BD500
		public void __Gen_Wrap_225(ref OutputFragment P0) {} // 0x00000001818BD500-0x00000001818BE1F0
		public ref float4 __Gen_Wrap_226(ref OutputFragment P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_226; // 0x00000001818BE1F0-0x00000001818BF1B0
		private ref float4 _refReturnTypeFor__Gen_Wrap_226; // Dummy field
		public void __Gen_Wrap_227(ref OutputFragment P0, int P1, float4 P2) {} // 0x00000001818BF1B0-0x00000001818C0200
		public void __Gen_Wrap_228(ref OutputFragment P0, int P1, UnityEngine.Color P2) {} // 0x00000001818C0200-0x00000001818C12F0
		public void __Gen_Wrap_229(ref OutputFragment P0, int P1, RectInt P2) {} // 0x00000001818C12F0-0x00000001818C23E0
		public bool __Gen_Wrap_230(ref OutputFragment P0, int P1) => default; // 0x00000001818C23E0-0x00000001818C30F0
		public void __Gen_Wrap_231(ref OutputFragment P0, int P1, bool P2) {} // 0x00000001818C30F0-0x00000001818C3E30
		public bool __Gen_Wrap_232(ref OutputFragment P0) => default; // 0x00000001818C3E30-0x00000001818C4B20
		public void __Gen_Wrap_233(ref OutputUIRendererFragment P0) {} // 0x00000001818C4B20-0x00000001818C56C0
		public void __Gen_Wrap_234(ref PedestalLightFlashFragment P0) {} // 0x00000001818C56C0-0x00000001818C62B0
		public bool __Gen_Wrap_235(ref PedestalLightFlashConfigFragment P0) => default; // 0x00000001818C62B0-0x00000001818C7060
		public void __Gen_Wrap_236(ref PedestalLightFlashConfigFragment P0, int P1, float P2) {} // 0x00000001818C7060-0x00000001818C7E90
		public void __Gen_Wrap_237(ref PedestalLightFlashConfigFragment P0, int P1, bool P2) {} // 0x00000001818C7E90-0x00000001818C8CA0
		public void __Gen_Wrap_238(ref PedestalLightFlashConfigFragment P0, int P1, UnityEngine.Color P2) {} // 0x00000001818C8CA0-0x00000001818C9E50
		public float __Gen_Wrap_239(ref PedestalLightFlashConfigFragment P0, int P1) => default; // 0x00000001818C9E50-0x00000001818CAC10
		public bool __Gen_Wrap_240(ref PedestalLightFlashConfigFragment P0, int P1) => default; // 0x00000001818CAC10-0x00000001818CB9D0
		public float4 __Gen_Wrap_241(ref PedestalLightFlashConfigFragment P0, int P1) => default; // 0x00000001818CB9D0-0x00000001818CCA90
		public void __Gen_Wrap_242(ref PedestalLightFlashConfigFragment P0) {} // 0x00000001818CCA90-0x00000001818CD830
		public void __Gen_Wrap_243(ref PipeEffectFragment P0) {} // 0x00000001818CD830-0x00000001818CE540
		public bool __Gen_Wrap_244(ref PipeFragment P0, ref GlobalEnv P1, ref NativeList<float3> P2, ref NativeList<float3> P3, ref NativeList<byte> P4) => default; // 0x00000001818CE540-0x00000001818D00D0
		public void __Gen_Wrap_245(ref GlobalEnv P0, int P1, uint P2, float P3, bool P4, float P5, bool P6, float P7) {} // 0x00000001818D00D0-0x00000001818D0DE0
		public ValueTuple<int[], int> __Gen_Wrap_246(ref GlobalEnv P0, uint P1, int P2) => default; // 0x00000001818D0DE0-0x00000001818D1EE0
		public bool __Gen_Wrap_247(ref PipeFragment P0, ref GlobalEnv P1, float2 P2, out uint P3, out int P4) {
			P3 = default;
			P4 = default;
			return default;
		} // 0x00000001818D1EE0-0x00000001818D3410
		public bool __Gen_Wrap_248(ref PipeFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5) => default; // 0x00000001818D3410-0x00000001818D4700
		public bool __Gen_Wrap_249(ref PipeFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref PooledList<int> P6) => default; // 0x00000001818D4700-0x00000001818D5CE0
		public bool __Gen_Wrap_250(ref PipeFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref ValueTuple<uint, int>[,] P6) => default; // 0x00000001818D5CE0-0x00000001818D72C0
		public void __Gen_Wrap_251(ref PipeFragment P0) {} // 0x00000001818D72C0-0x00000001818D7F30
		public void __Gen_Wrap_252(ref PipeHolderFragment P0) {} // 0x00000001818D7F30-0x00000001818D8AE0
		public void __Gen_Wrap_253(ref PipeLogisticsUnitFragment P0) {} // 0x00000001818D8AE0-0x00000001818D9680
		public void __Gen_Wrap_254(ref PipeComRenderFragment P0) {} // 0x00000001818D9680-0x00000001818DA230
		public void __Gen_Wrap_255(ref PipeRenderFragment P0) {} // 0x00000001818DA230-0x00000001818DAE20
		public void __Gen_Wrap_256(ref PipeTrackRenderFragment P0) {} // 0x00000001818DAE20-0x00000001818DB9D0
		public bool __Gen_Wrap_257(ref ComplexPortFragment P0, uint P1, int P2, bool P3, bool P4, uint P5, out bool P6) {
			P6 = default;
			return default;
		} // 0x00000001818DB9D0-0x00000001818DC530
		public bool __Gen_Wrap_258(ref ComplexPortFragment P0, uint P1, bool P2, object P3) => default; // 0x00000001818DC530-0x00000001818DD220
		public bool __Gen_Wrap_259(ref ComplexPortFragment P0, bool P1, object P2, bool P3) => default; // 0x00000001818DD220-0x00000001818DDFB0
		public void __Gen_Wrap_260(ref ComplexPortFragment P0, float3 P1, float3 P2, ref GlobalSharedData.UnitPortConfig P3, ref UnitConfigFragment P4, float P5) {} // 0x00000001818DDFB0-0x00000001818DF8B0
		public bool __Gen_Wrap_261(ref ComplexPortFragment P0) => default; // 0x00000001818DF8B0-0x00000001818E04D0
		public bool __Gen_Wrap_262(ref Beyond.Gameplay.Factory.PortData P0, Beyond.Gameplay.Factory.PortData P1) => default; // 0x00000001818E04D0-0x00000001818E11B0
		public bool __Gen_Wrap_263(ref ComplexPortFragment P0, ComplexPortFragment P1) => default; // 0x00000001818E11B0-0x00000001818E1E90
		public bool __Gen_Wrap_264(ref ComplexPortFragment P0, object P1) => default; // 0x00000001818E1E90-0x00000001818E2B50
		public int __Gen_Wrap_265(ref ComplexPortFragment P0) => default; // 0x00000001818E2B50-0x00000001818E3730
		public bool __Gen_Wrap_266(ComplexPortFragment P0, ComplexPortFragment P1) => default; // 0x00000001818E3730-0x00000001818E3DF0
		public string __Gen_Wrap_267(ref Beyond.Gameplay.Factory.PortData P0) => default; // 0x00000001818E3DF0-0x00000001818E4CB0
		public string __Gen_Wrap_268(ref ComplexPortFragment P0) => default; // 0x00000001818E4CB0-0x00000001818E5B80
		public void __Gen_Wrap_269(ref ComplexPortFragment P0) {} // 0x00000001818E5B80-0x00000001818E6750
		public float4x4 __Gen_Wrap_270(ref Beyond.Gameplay.Factory.PortData P0) => default; // 0x00000001818E6750-0x00000001818E7650
		public bool __Gen_Wrap_271(ref Beyond.Gameplay.Factory.PortData P0, object P1) => default; // 0x00000001818E7650-0x00000001818E8310
		public int __Gen_Wrap_272(ref Beyond.Gameplay.Factory.PortData P0) => default; // 0x00000001818E8310-0x00000001818E8EE0
		public bool __Gen_Wrap_273(Beyond.Gameplay.Factory.PortData P0, Beyond.Gameplay.Factory.PortData P1) => default; // 0x00000001818E8EE0-0x00000001818E95C0
		public void __Gen_Wrap_274(ref PortPreviewUIRendererFragment P0) {} // 0x00000001818E95C0-0x00000001818EA160
		public void __Gen_Wrap_275(ref PortStatusUIFragment P0) {} // 0x00000001818EA160-0x00000001818EAD00
		public void __Gen_Wrap_276(ref PowerPoleFragment P0) {} // 0x00000001818EAD00-0x00000001818EB890
		public void __Gen_Wrap_277(ref ProducerFragment P0) {} // 0x00000001818EB890-0x00000001818EC440
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_278(ref SharedDataFragment P0) => ref _refReturnTypeFor__Gen_Wrap_278; // 0x00000001818EC440-0x00000001818ED2E0
		private ref SharedDataContainer.SharedExtData _refReturnTypeFor__Gen_Wrap_278; // Dummy field
		public void __Gen_Wrap_279(ref SharedDataFragment P0) {} // 0x00000001818ED2E0-0x00000001818EDEA0
		public SocialFragment __Gen_Wrap_280(ulong P0, uint P1, ulong P2, long P3, long P4, uint P5, bool P6) => default; // 0x00000001818EDEA0-0x00000001818EE7E0
		public bool __Gen_Wrap_281(ref SocialFragment P0) => default; // 0x00000001818EE7E0-0x00000001818EF3E0
		public void __Gen_Wrap_282(ref SocialFragment P0) {} // 0x00000001818EF3E0-0x00000001818EFFB0
		public string __Gen_Wrap_283(ref SignData P0) => default; // 0x00000001818EFFB0-0x00000001818F0E70
		public float __Gen_Wrap_284(object P0, uint3 P1) => default; // 0x00000001818F0E70-0x00000001818F1520
		public void __Gen_Wrap_285(object P0, Entity P1, uint3 P2) {} // 0x00000001818F1520-0x00000001818F1F40
		public void __Gen_Wrap_286(object P0, ref EntityManager P1, Entity P2) {} // 0x00000001818F1F40-0x00000001818F2FB0
		public LocalTransform __Gen_Wrap_287(float4x4 P0) => default; // 0x00000001818F2FB0-0x00000001818F3B60
		public LocalTransform __Gen_Wrap_288(float3 P0, quaternion P1) => default; // 0x00000001818F3B60-0x00000001818F4A90
		public LocalTransform __Gen_Wrap_289(float3 P0, quaternion P1, float P2) => default; // 0x00000001818F4A90-0x00000001818F5A10
		public LocalTransform __Gen_Wrap_290(float3 P0) => default; // 0x00000001818F5A10-0x00000001818F65B0
		public LocalTransform __Gen_Wrap_291(float P0, float P1, float P2) => default; // 0x00000001818F65B0-0x00000001818F6E50
		public LocalTransform __Gen_Wrap_292(quaternion P0) => default; // 0x00000001818F6E50-0x00000001818F79E0
		public LocalTransform __Gen_Wrap_293(float P0) => default; // 0x00000001818F79E0-0x00000001818F8230
		public string __Gen_Wrap_294(ref LocalTransform P0) => default; // 0x00000001818F8230-0x00000001818F90E0
		public float3 __Gen_Wrap_295(ref LocalTransform P0, float3 P1) => default; // 0x00000001818F90E0-0x00000001818FA070
		public float3 __Gen_Wrap_296(ref LocalTransform P0) => default; // 0x00000001818FA070-0x00000001818FAF50
		public quaternion __Gen_Wrap_297(ref LocalTransform P0, quaternion P1) => default; // 0x00000001818FAF50-0x00000001818FBED0
		public float __Gen_Wrap_298(ref LocalTransform P0, float P1) => default; // 0x00000001818FBED0-0x00000001818FCAF0
		public LocalTransform __Gen_Wrap_299(ref LocalTransform P0, in LocalTransform P1) => default; // 0x00000001818FCAF0-0x00000001818FD890
		public LocalTransform __Gen_Wrap_300(ref LocalTransform P0) => default; // 0x00000001818FD890-0x00000001818FE4E0
		public LocalTransform __Gen_Wrap_301(ref LocalTransform P0, float3 P1) => default; // 0x00000001818FE4E0-0x00000001818FF4F0
		public LocalTransform __Gen_Wrap_302(ref LocalTransform P0, float P1, float P2, float P3) => default; // 0x00000001818FF4F0-0x00000001819001B0
		public LocalTransform __Gen_Wrap_303(ref LocalTransform P0, quaternion P1) => default; // 0x00000001819001B0-0x00000001819011B0
		public LocalTransform __Gen_Wrap_304(ref LocalTransform P0, float P1) => default; // 0x00000001819011B0-0x0000000181901E40
		public bool __Gen_Wrap_305(ref LocalTransform P0, in LocalTransform P1) => default; // 0x0000000181901E40-0x0000000181902B10
		public void __Gen_Wrap_306(ref LocalTransform P0) {} // 0x0000000181902B10-0x00000001819036C0
		public void __Gen_Wrap_307(ref Root P0) {} // 0x00000001819036C0-0x0000000181904250
		public void __Gen_Wrap_308(ref Parent P0) {} // 0x0000000181904250-0x0000000181904DF0
		public void __Gen_Wrap_309(ref Beyond.Gameplay.Factory.Child P0) {} // 0x0000000181904DF0-0x0000000181905B00
		public bool __Gen_Wrap_310(ref LocalToWorld P0, float4x4 P1, int P2) => default; // 0x0000000181905B00-0x0000000181906870
		public float3 __Gen_Wrap_311(ref LocalToWorld P0) => default; // 0x0000000181906870-0x0000000181907840
		public void __Gen_Wrap_312(ref LocalToWorld P0) {} // 0x0000000181907840-0x00000001819084E0
		public void __Gen_Wrap_313(ref UdPipeFragment P0) {} // 0x00000001819084E0-0x0000000181909080
		public void __Gen_Wrap_314(ref UnitConfigFragment P0) {} // 0x0000000181909080-0x0000000181909C80
		public string __Gen_Wrap_315(ref FactoryUnitExtendConfig P0) => default; // 0x0000000181909C80-0x000000018190AB60
		public void __Gen_Wrap_316(ref UnitInteractFragment P0) {} // 0x000000018190AB60-0x000000018190B700
		public void __Gen_Wrap_317(ref UnitRenderFragment P0) {} // 0x000000018190B700-0x000000018190C300
		public void __Gen_Wrap_318(ref RenderLookAtFragment P0) {} // 0x000000018190C300-0x000000018190CEC0
		public void __Gen_Wrap_319(ref ChapterTagFragment P0) {} // 0x000000018190CEC0-0x000000018190DA60
		public void __Gen_Wrap_320(ref UnitStatusFragment P0) {} // 0x000000018190DA60-0x000000018190E610
		public void __Gen_Wrap_321(ref UnitOverrideStatusFragment P0) {} // 0x000000018190E610-0x000000018190F1B0
		public void __Gen_Wrap_322(ref UnitStatusEffectFragment P0, BuildingStatus P1, object P2) {} // 0x000000018190F1B0-0x000000018190FBC0
		public FixedList512Bytes<StatusSingleEffect> __Gen_Wrap_323(ref UnitStatusEffectFragment P0, FacBuildingState P1) => default; // 0x000000018190FBC0-0x0000000181910B50
		public void __Gen_Wrap_324(ref UnitStatusEffectFragment P0) {} // 0x0000000181910B50-0x0000000181911420
		public void __Gen_Wrap_325(ref UnitStatusUIRendererFragment P0) {} // 0x0000000181911420-0x0000000181911FC0
		public bool __Gen_Wrap_326(ref UnitTransFragment P0, float3 P1, bool P2) => default; // 0x0000000181911FC0-0x0000000181912D70
		public void __Gen_Wrap_327(ref UnitTransFragment P0) {} // 0x0000000181912D70-0x0000000181913930
		public void __Gen_Wrap_328(ref ValveFragment P0) {} // 0x0000000181913930-0x00000001819144E0
		public void __Gen_Wrap_329(ref Beyond.Gameplay.Factory.BoxValve P0) {} // 0x00000001819144E0-0x0000000181915080
		public void __Gen_Wrap_330(ref Beyond.Gameplay.Factory.FluidValve P0) {} // 0x0000000181915080-0x0000000181915C20
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_331(Entity P0, ref EntityManager P1) => ref _refReturnTypeFor__Gen_Wrap_331; // 0x0000000181915C20-0x0000000181916B60
		private ref SharedDataContainer.SharedExtData _refReturnTypeFor__Gen_Wrap_331; // Dummy field
		public bool __Gen_Wrap_332(ref BlueprintSlotInfo P0, ref EntityManager P1, int P2, int P3) => default; // 0x0000000181916B60-0x0000000181917AE0
		public void __Gen_Wrap_333(ref BlueprintSlotInfo P0, ref EntityManager P1, int P2, Entity P3) {} // 0x0000000181917AE0-0x0000000181918BD0
		public int __Gen_Wrap_334(ref BlueprintSlotInfo P0) => default; // 0x0000000181918BD0-0x00000001819194D0
		public int __Gen_Wrap_335(ref BlueprintSlotInfo P0, int P1) => default; // 0x00000001819194D0-0x0000000181919E10
		public void __Gen_Wrap_336(ref BlueprintSlotInfo P0, int P1, int P2) {} // 0x0000000181919E10-0x000000018191A750
		public ulong[] __Gen_Wrap_337(ref BlueprintSlotInfo P0) => default; // 0x000000018191A750-0x000000018191B630
		public void __Gen_Wrap_338(ref BlueprintSlotInfo P0, int P1, Entity P2) {} // 0x000000018191B630-0x000000018191C2F0
		public Entity[] __Gen_Wrap_339(ref BlueprintSlotInfo P0, int P1) => default; // 0x000000018191C2F0-0x000000018191D1F0
		public void __Gen_Wrap_340(ref BlueprintSlotInfo P0, ref EntityManager P1, int P2, ref PooledList<uint> P3, ref PooledList<uint> P4, ref PooledList<Entity> P5) {} // 0x000000018191D1F0-0x000000018191E730
		public ulong __Gen_Wrap_341(ref BlueprintSlotInfo P0, int P1) => default; // 0x000000018191E730-0x000000018191F070
		public Entity __Gen_Wrap_342(ref BlueprintSlotInfo P0, int P1, int P2) => default; // 0x000000018191F070-0x000000018191FFD0
		public NativeArray<Entity> __Gen_Wrap_343(ref BlueprintSlotInfo P0, int P1) => default; // 0x000000018191FFD0-0x0000000181920F00
		public BlueprintSlotInfo __Gen_Wrap_344() => default; // 0x0000000181920F00-0x0000000181921400
		public string __Gen_Wrap_345(ref BlueprintSlotInfo P0) => default; // 0x0000000181921400-0x00000001819222C0
		public string __Gen_Wrap_346(ref ConveyorRendererInfo P0) => default; // 0x00000001819222C0-0x0000000181923190
		public bool __Gen_Wrap_347(ref UnitId P0, UnitId P1) => default; // 0x0000000181923190-0x0000000181923E80
		public bool __Gen_Wrap_348(ref UnitId P0, object P1) => default; // 0x0000000181923E80-0x0000000181924B20
		public int __Gen_Wrap_349(ref UnitId P0) => default; // 0x0000000181924B20-0x00000001819256F0
		public bool __Gen_Wrap_350(ref Visibility P0, Visibility.EFlag P1) => default; // 0x00000001819256F0-0x0000000181926300
		public bool __Gen_Wrap_351(ref Visibility P0) => default; // 0x0000000181926300-0x0000000181926EE0
		public bool __Gen_Wrap_352(ref Visibility P0, Visibility.EFlag P1, bool P2) => default; // 0x0000000181926EE0-0x0000000181927B10
		public void __Gen_Wrap_353(ref WireRendererFragment P0) {} // 0x0000000181927B10-0x00000001819286B0
		public void __Gen_Wrap_354(ref GlobalSharedData.MapGridRendererData P0) {} // 0x00000001819286B0-0x0000000181928FA0
		public void __Gen_Wrap_355(ref GlobalSharedData P0) {} // 0x0000000181928FA0-0x0000000181929B40
		public void __Gen_Wrap_356(ref GlobalSharedData.CullingGlobalSetting P0) {} // 0x0000000181929B40-0x000000018192A710
		public float __Gen_Wrap_357(ref GlobalSharedData.CullingGlobalSetting P0) => default; // 0x000000018192A710-0x000000018192B300
		public void __Gen_Wrap_358(ref GlobalSharedData.NearByDistanceGlobalSetting P0) {} // 0x000000018192B300-0x000000018192BF00
		public bool __Gen_Wrap_359(ref GlobalSharedData.NearByDistanceGlobalSetting P0) => default; // 0x000000018192BF00-0x000000018192CB20
		public float __Gen_Wrap_360(ref GlobalSharedData.NearByDistanceGlobalSetting P0) => default; // 0x000000018192CB20-0x000000018192D730
		public void __Gen_Wrap_361(ref GlobalSharedData.World3DUiGlobalSetting P0) {} // 0x000000018192D730-0x000000018192E2F0
		public bool __Gen_Wrap_362(ref GlobalSharedData.World3DUiGlobalSetting P0) => default; // 0x000000018192E2F0-0x000000018192EED0
		public void __Gen_Wrap_363(ref GlobalSharedData.CurveGlobalSetting P0, ref Beyond.Gameplay.Factory.FPtrNativeCurve P1, ref Beyond.Gameplay.Factory.FPtrNativeCurve P2, ref Beyond.Gameplay.Factory.FPtrNativeCurve P3) {} // 0x000000018192EED0-0x0000000181930260
		public void __Gen_Wrap_364(ref GlobalSharedData.CurveGlobalSetting P0, ref Beyond.Gameplay.Factory.FPtrNativeCurve P1) {} // 0x0000000181930260-0x0000000181931230
		public void __Gen_Wrap_365(ref GlobalSharedData.MapGridRendererData P0, ref GlobalSharedData.MapGridRendererData.MapGridInfo[] P1, ref GlobalSharedData.MapGridRendererData.MapGridInfo[] P2) {} // 0x0000000181931230-0x0000000181932310
		public void __Gen_Wrap_366(ref GlobalSharedData.UnitPortConfigDB P0, int P1) {} // 0x0000000181932310-0x0000000181932EF0
		public void __Gen_Wrap_367(ref GlobalSharedData.UnitPortConfigDB P0) {} // 0x0000000181932EF0-0x0000000181933A90
		public int __Gen_Wrap_368(StringIntern.FastId P0) => default; // 0x0000000181933A90-0x0000000181934030
		public bool __Gen_Wrap_369(ref GlobalSharedData.UnitPortConfigDB P0, int P1, out GlobalSharedData.UnitPortConfig P2) {
			P2 = default;
			return default;
		} // 0x0000000181934030-0x0000000181934F20
		public bool __Gen_Wrap_370(ref GlobalSharedData.UnitPortConfigDB P0, object P1, out GlobalSharedData.UnitPortConfig P2) {
			P2 = default;
			return default;
		} // 0x0000000181934F20-0x0000000181935F00
		public void __Gen_Wrap_371(object P0, ref FactoryUnitPortConfig P1, int P2) {} // 0x0000000181935F00-0x0000000181936BF0
		public GlobalSharedData.UnitPortConfig __Gen_Wrap_372(ref GlobalSharedData.UnitPortConfigDB P0, object P1) => default; // 0x0000000181936BF0-0x0000000181937C30
		public void __Gen_Wrap_373(ref GlobalSharedData.UnitPortConfigDB P0, int P1, GlobalSharedData.UnitPortConfig P2) {} // 0x0000000181937C30-0x0000000181938C70
		public void __Gen_Wrap_374(ref GlobalSharedData.UnitPortConfigDB P0, object P1, GlobalSharedData.UnitPortConfig P2) {} // 0x0000000181938C70-0x0000000181939DC0
		public GlobalSharedData.UnitPortConfig __Gen_Wrap_375(ref GlobalSharedData.UnitPortConfigDB P0, int P1) => default; // 0x0000000181939DC0-0x000000018193AD20
		public bool __Gen_Wrap_376(ref GlobalSharedData.UnitPortConfigDB P0, object P1) => default; // 0x000000018193AD20-0x000000018193B9C0
		public int __Gen_Wrap_377(ref GlobalSharedData.PerDrawGlobalSetting P0, LogicEntityState P1, LogicEntityType P2) => default; // 0x000000018193B9C0-0x000000018193C310
		public void __Gen_Wrap_378(ref GlobalSharedData.PerDrawGlobalSetting P0, ref HGFactoryRendererBinderComponent P1, LogicEntityState P2, LogicEntityType P3) {} // 0x000000018193C310-0x000000018193D1C0
		public void __Gen_Wrap_379(ref GlobalSharedData.PerDrawGlobalSetting P0, ref HGFactoryRendererBinderComponent P1, LogicEntityState P2, LogicEntityType P3, uint P4) {} // 0x000000018193D1C0-0x000000018193E150
		public void __Gen_Wrap_380(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting P0, int P1, PerDrawConfig P2) {} // 0x000000018193E150-0x000000018193F290
		public void __Gen_Wrap_381(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting P0, int P1, PerDrawPassConfig P2) {} // 0x000000018193F290-0x00000001819403D0
		public void __Gen_Wrap_382(ref GlobalSharedData.PerDrawGlobalSetting P0, object P1) {} // 0x00000001819403D0-0x0000000181940DD0
		public PerDrawPassConfig __Gen_Wrap_383(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting P0, int P1) => default; // 0x0000000181940DD0-0x0000000181941E00
		public PerDrawConfig __Gen_Wrap_384(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting P0, int P1) => default; // 0x0000000181941E00-0x0000000181942E40
		public void __Gen_Wrap_385(ref GlobalSharedData.SystemIntervalGlobalSetting P0) {} // 0x0000000181942E40-0x0000000181943A60
		public int __Gen_Wrap_386(ref GlobalSharedData.SystemIntervalGlobalSetting P0) => default; // 0x0000000181943A60-0x0000000181944690
		public void __Gen_Wrap_387(ref GlobalSharedData.UIEffectPathConfig P0, object P1, object P2, object P3) {} // 0x0000000181944690-0x0000000181945530
		public bool __Gen_Wrap_388(ref GlobalSharedData.UIEffectPathConfig P0, FacBuildingState P1, out FixedString32Bytes P2, out float4 P3, out float4 P4) {
			P2 = default;
			P3 = default;
			P4 = default;
			return default;
		} // 0x0000000181945530-0x0000000181946600
		public void __Gen_Wrap_389(object P0, ref EntityManager P1, ref GlobalEnv P2, object P3) {} // 0x0000000181946600-0x0000000181947A10
		public JobHandle __Gen_Wrap_390(object P0, ref EntityManager P1, long P2, long P3, int P4, int P5, int P6, ref GlobalEnv P7, JobHandle P8, NativeList<JobHandle> P9) => default; // 0x0000000181947A10-0x0000000181949190
		public JobHandle __Gen_Wrap_391(object P0, ref EntityManager P1, long P2, long P3, float P4, int P5, int P6, int P7, ref GlobalEnv P8, JobHandle P9, NativeList<JobHandle> P10) => default; // 0x0000000181949190-0x000000018194A960
		public JobHandle __Gen_Wrap_392(object P0, ref EntityManager P1, ref GlobalEnv P2, int P3, int P4, int P5, JobHandle P6) => default; // 0x000000018194A960-0x000000018194C140
		public void __Gen_Wrap_393(object P0, ref EntityManager P1, ref GlobalEnv P2) {} // 0x000000018194C140-0x000000018194D400
		public void __Gen_Wrap_394(object P0, ref NativeList<JobHandle> P1) {} // 0x000000018194D400-0x000000018194E0B0
		public void __Gen_Wrap_395(object P0, ref JobHandle P1, ref NativeList<JobHandle> P2) {} // 0x000000018194E0B0-0x000000018194F140
		public bool __Gen_Wrap_396(object P0, ref GlobalEnv P1) => default; // 0x000000018194F140-0x0000000181950050
		public bool __Gen_Wrap_397(object P0, ref EntityManager P1) => default; // 0x0000000181950050-0x0000000181950D10
		public FunctionPointer<UnsafeJobFuncPointers.ApplyRender> __Gen_Wrap_398() => default; // 0x0000000181950D10-0x0000000181951510
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> __Gen_Wrap_399() => default; // 0x0000000181951510-0x0000000181951D10
		public FunctionPointer<UnsafeJobFuncPointers.QueryStateIconPath> __Gen_Wrap_400() => default; // 0x0000000181951D10-0x0000000181952510
		public bool __Gen_Wrap_401(ref EntityManager P0, float P1, float P2, float P3, out UnitFragment P4) {
			P4 = default;
			return default;
		} // 0x0000000181952510-0x0000000181953460
		public FunctionPointer<UnsafeJobFuncPointers.QueryBuildingState> __Gen_Wrap_402() => default; // 0x0000000181953460-0x0000000181953C60
		public FunctionPointer<UnsafeJobFuncPointers.SetEntityFlashStatue> __Gen_Wrap_403() => default; // 0x0000000181953C60-0x0000000181954460
		public void __Gen_Wrap_404(ref AdditiveEffectJob P0, IntPtr P1) {} // 0x0000000181954460-0x00000001819551E0
		public void __Gen_Wrap_405(ref AdditiveEffectJob P0, ref AdditiveEffectFragment P1, ref SharedDataContainer.SharedExtData P2) {} // 0x00000001819551E0-0x0000000181956790
		public void __Gen_Wrap_406(ref CutoffState P0, ref BuildDismissState P1) {} // 0x0000000181956790-0x0000000181957750
		public void __Gen_Wrap_407(ref AdditiveEffectJob P0, int P1) {} // 0x0000000181957750-0x00000001819584A0
		public void __Gen_Wrap_408(ref AdditiveEffectJob P0, int P1, int P2) {} // 0x00000001819584A0-0x0000000181959200
		public void __Gen_Wrap_409(ref AdditiveEffectJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x0000000181959200-0x000000018195A340
		public JobHandle __Gen_Wrap_410(ref AdditiveEffectJob P0, JobHandle P1, int P2) => default; // 0x000000018195A340-0x000000018195B470
		public JobHandle __Gen_Wrap_411(ref AdditiveEffectJob P0, JobHandle P1, JobHandle P2, int P3) => default; // 0x000000018195B470-0x000000018195C670
		public void __Gen_Wrap_412(ref AdditiveEffectQueryJob P0) {} // 0x000000018195C670-0x000000018195D230
		public void __Gen_Wrap_413(ref AdditiveEffectQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, ref EntityQueryV2.QueryResultDefer P2, ref EntityQueryV2.QueryResultDefer P3, bool P4) {} // 0x000000018195D230-0x000000018195E5F0
		public void __Gen_Wrap_414(ref AdditiveEffectRenderJob P0, ref SharedDataContainer.SharedExtData P1, ref AdditiveEffectRendererFragment P2, ref HGFactoryRendererBinderComponent P3) {} // 0x000000018195E5F0-0x000000018195FF60
		public void __Gen_Wrap_415(ref AdditiveEffectRenderJob P0, IntPtr P1) {} // 0x000000018195FF60-0x0000000181960C80
		public void __Gen_Wrap_416(ref HGFactoryRendererBinderComponent P0, ref SharedDataContainer.SharedExtData P1, bool P2, bool P3) {} // 0x0000000181960C80-0x0000000181961CC0
		public void __Gen_Wrap_417(ref EntityManager P0, ref SharedDataContainer.SharedExtData P1, ref HGFactoryRendererBinderComponent P2, ref Beyond.Gameplay.Factory.FPtrNativeCurve P3, ref Beyond.Gameplay.Factory.FPtrNativeCurve P4, ref Beyond.Gameplay.Factory.FPtrNativeCurve P5, long P6) {} // 0x0000000181961CC0-0x0000000181963470
		public void __Gen_Wrap_418(ref EntityManager P0, ref SharedDataContainer.SharedExtData P1, ref HGFactoryRendererBinderComponent P2) {} // 0x0000000181963470-0x00000001819648B0
		public void __Gen_Wrap_419(ref AdditiveEffectRenderJob P0, int P1) {} // 0x00000001819648B0-0x00000001819655B0
		public void __Gen_Wrap_420(ref AdditiveEffectRenderJob P0, int P1, int P2) {} // 0x00000001819655B0-0x00000001819662B0
		public void __Gen_Wrap_421(ref AdditiveEffectRenderJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001819662B0-0x00000001819673A0
		public JobHandle __Gen_Wrap_422(ref AdditiveEffectRenderJob P0, JobHandle P1, int P2) => default; // 0x00000001819673A0-0x0000000181968470
		public JobHandle __Gen_Wrap_423(ref AdditiveEffectRenderJob P0, JobHandle P1, JobHandle P2, int P3) => default; // 0x0000000181968470-0x0000000181969650
		public void __Gen_Wrap_424(ref AudioJobs.AudioDistanceAndCullingJob P0, int P1) {} // 0x0000000181969650-0x000000018196A230
		public void __Gen_Wrap_425(ref AudioJobs.AudioGroupEmitterJob P0, int P1) {} // 0x000000018196A230-0x000000018196AE30
		public void __Gen_Wrap_426(ref AudioJobs.AudioGroupEmitterJob P0, IntPtr P1) {} // 0x000000018196AE30-0x000000018196BA60
		public void __Gen_Wrap_427(ref AudioJobs.WaterPipeEmitterJob P0, int P1, ref PipeFragment P2) {} // 0x000000018196BA60-0x000000018196CB10
		public void __Gen_Wrap_428(ref AudioJobs.WaterPipeEmitterJob P0, int P1) {} // 0x000000018196CB10-0x000000018196D710
		public void __Gen_Wrap_429(ref AudioJobs.WaterPipeEmitterJob P0, ref GlobalEnv P1) {} // 0x000000018196D710-0x000000018196E910
		public void __Gen_Wrap_430(ref BatchArrowJob P0, bool P1, ref FixedList512Bytes<FactoryUnitPortConfig> P2, quaternion P3, float3 P4, ComplexPortFragment P5, float4x4 P6, float P7, bool P8, bool P9, bool P10, bool P11, bool P12, bool P13, bool P14, bool P15, bool P16, bool P17, bool P18) {} // 0x000000018196E910-0x00000001819703E0
		public void __Gen_Wrap_431(ref BatchArrowJob P0, int P1, EntityQueryV2.QueryResult P2) {} // 0x00000001819703E0-0x0000000181971350
		public void __Gen_Wrap_432(ref BatchArrowJob P0, int P1) {} // 0x0000000181971350-0x0000000181971F30
		public void __Gen_Wrap_433(ref BatchArrowJob P0, IntPtr P1) {} // 0x0000000181971F30-0x0000000181972B60
		public void __Gen_Wrap_434(ref BatchArrowJob P0) {} // 0x0000000181972B60-0x0000000181973730
		public void __Gen_Wrap_435(ref BatchInsideConveyorJob P0, uint P1, float3 P2, quaternion P3, ref FixedList512Bytes<FactoryUnitPortConfig> P4, ref ComplexPortFragment P5, bool P6, float P7, bool P8) {} // 0x0000000181973730-0x0000000181975350
		public void __Gen_Wrap_436(ref BatchInsideConveyorJob P0, int P1, EntityQueryV2.QueryResult P2) {} // 0x0000000181975350-0x0000000181976450
		public void __Gen_Wrap_437(ref BatchInsideConveyorJob P0, int P1) {} // 0x0000000181976450-0x00000001819771B0
		public void __Gen_Wrap_438(ref BatchInsideConveyorJob P0, IntPtr P1) {} // 0x00000001819771B0-0x0000000181977F50
		public void __Gen_Wrap_439(ref BatchInsideConveyorJob P0) {} // 0x0000000181977F50-0x0000000181978CA0
		public void __Gen_Wrap_440(ref BatchNormalArrowJob P0, uint P1, bool P2, ref FixedList512Bytes<FactoryUnitPortConfig> P3, quaternion P4, float3 P5, ComplexPortFragment P6, float4x4 P7, float P8, bool P9, bool P10, bool P11, bool P12, bool P13, bool P14, bool P15, bool P16, bool P17) {} // 0x0000000181978CA0-0x000000018197A680
		public void __Gen_Wrap_441(ref BatchNormalArrowJob P0, int P1, EntityQueryV2.QueryResult P2) {} // 0x000000018197A680-0x000000018197B5F0
		public void __Gen_Wrap_442(ref BatchNormalArrowJob P0, int P1) {} // 0x000000018197B5F0-0x000000018197C1D0
		public void __Gen_Wrap_443(ref BatchNormalArrowJob P0) {} // 0x000000018197C1D0-0x000000018197CDA0
		public void __Gen_Wrap_444(ref BatchNormalArrowJob P0, IntPtr P1) {} // 0x000000018197CDA0-0x000000018197D9D0
		public void __Gen_Wrap_445(ref BatchPreviewArrowJob P0, bool P1, ref FixedList512Bytes<FactoryUnitPortConfig> P2, quaternion P3, float3 P4, ComplexPortFragment P5, float4x4 P6, float P7, bool P8, bool P9, bool P10) {} // 0x000000018197D9D0-0x000000018197F500
		public void __Gen_Wrap_446(ref BatchPreviewArrowJob P0, int P1, EntityQueryV2.QueryResult P2) {} // 0x000000018197F500-0x0000000181980650
		public void __Gen_Wrap_447(ref BatchPreviewArrowJob P0) {} // 0x0000000181980650-0x00000001819813D0
		public void __Gen_Wrap_448(ref BatchPreviewArrowJob P0, IntPtr P1) {} // 0x00000001819813D0-0x00000001819821D0
		public void __Gen_Wrap_449(ref BufferSwapJob P0) {} // 0x00000001819821D0-0x0000000181982D70
		public void __Gen_Wrap_450(ref BuildingLiquidRenderJob P0, Entity P1, ValueTuple<int, uint> P2) {} // 0x0000000181982D70-0x0000000181983D50
		public void __Gen_Wrap_451(ref BuildingLiquidRenderJob P0, int P1) {} // 0x0000000181983D50-0x0000000181984910
		public void __Gen_Wrap_452(ref BuildingLiquidRenderJob P0, int P1, int P2) {} // 0x0000000181984910-0x00000001819854E0
		public void __Gen_Wrap_453(ref BuildingLiquidRenderJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001819854E0-0x00000001819864B0
		public JobHandle __Gen_Wrap_454(ref BuildingLiquidRenderJob P0, JobHandle P1, int P2) => default; // 0x00000001819864B0-0x0000000181987450
		public void __Gen_Wrap_455(ref BuildingLiquidRenderJob P0, IntPtr P1) {} // 0x0000000181987450-0x0000000181988040
		public void __Gen_Wrap_456(ref BuildingStatePosCollectJob P0, ref UnitFragment P1, ref UnitTransFragment P2, ref UnitConfigFragment P3, ref UnitStatusFragment P4, ref SharedDataFragment P5) {} // 0x0000000181988040-0x0000000181989F70
		public void __Gen_Wrap_457(ref BuildingStatePosCollectJob P0, int P1) {} // 0x0000000181989F70-0x000000018198AB70
		public void __Gen_Wrap_458(ref BuildingStatePosCollectJob P0, int P1, int P2) {} // 0x000000018198AB70-0x000000018198B780
		public void __Gen_Wrap_459(ref BuildingStatePosCollectJob P0) {} // 0x000000018198B780-0x000000018198C370
		public void __Gen_Wrap_460(ref BuildingStatePosCollectJob P0, IntPtr P1) {} // 0x000000018198C370-0x000000018198CFB0
		public void __Gen_Wrap_461(ref BuildingStateRendererJob P0, int P1) {} // 0x000000018198CFB0-0x000000018198DB80
		public void __Gen_Wrap_462(ref CargoCollectJob P0, int P1) {} // 0x000000018198DB80-0x000000018198E780
		public void __Gen_Wrap_463(ref CargoCollectJob P0) {} // 0x000000018198E780-0x000000018198F370
		public void __Gen_Wrap_464(ref CargoCollectJob P0, ref GlobalEnv P1) {} // 0x000000018198F370-0x0000000181990570
		public void __Gen_Wrap_465(ref CargoCollectJob P0, IntPtr P1) {} // 0x0000000181990570-0x00000001819911B0
		public void __Gen_Wrap_466(ref CargoPredictJob P0, int P1) {} // 0x00000001819911B0-0x0000000181991D90
		public void __Gen_Wrap_467(ref CargoPredictJob P0, IntPtr P1) {} // 0x0000000181991D90-0x00000001819929B0
		public void __Gen_Wrap_468(ref CargoPredictJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001819929B0-0x00000001819939A0
		public JobHandle __Gen_Wrap_469(ref CargoPredictJob P0, JobHandle P1, int P2) => default; // 0x00000001819939A0-0x0000000181994980
		public void __Gen_Wrap_470(ref CargoPredictQueryJob P0) {} // 0x0000000181994980-0x0000000181995530
		public void __Gen_Wrap_471(ref CargoPredictQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x0000000181995530-0x0000000181996520
		public void __Gen_Wrap_472(ref CargoRenderJob P0, int P1) {} // 0x0000000181996520-0x0000000181997100
		public void __Gen_Wrap_473(ref CargoRenderJob P0, IntPtr P1) {} // 0x0000000181997100-0x0000000181997D10
		public void __Gen_Wrap_474(ref CargoRenderQueryJob P0) {} // 0x0000000181997D10-0x00000001819988C0
		public void __Gen_Wrap_475(ref CargoRenderQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x00000001819988C0-0x00000001819998B0
		public void __Gen_Wrap_476(ref ConveyorCollectJob P0, ref ConveyorFragment P1, ref SharedDataFragment P2, bool P3, bool P4) {} // 0x00000001819998B0-0x000000018199AD30
		public void __Gen_Wrap_477(ref ConveyorCollectJob P0, int P1) {} // 0x000000018199AD30-0x000000018199B930
		public void __Gen_Wrap_478(ref ConveyorCollectJob P0, int P1, int P2) {} // 0x000000018199B930-0x000000018199C540
		public void __Gen_Wrap_479(ref ConveyorCollectJob P0) {} // 0x000000018199C540-0x000000018199D130
		public void __Gen_Wrap_480(ref ConveyorCollectJob P0, IntPtr P1) {} // 0x000000018199D130-0x000000018199DD70
		public void __Gen_Wrap_481(ref ConveyorFigureRendererJob P0, int P1) {} // 0x000000018199DD70-0x000000018199E950
		public void __Gen_Wrap_482(ref ConveyorFigureRendererJob P0, int P1, int P2) {} // 0x000000018199E950-0x000000018199F550
		public void __Gen_Wrap_483(ref ConveyorFigureRendererJob P0, IntPtr P1) {} // 0x000000018199F550-0x00000001819A0170
		public void __Gen_Wrap_484(ref ConveyorInsideRenderJob P0, int P1) {} // 0x00000001819A0170-0x00000001819A0DB0
		public void __Gen_Wrap_485(ref ConveyorPreviewCollectJob P0, ref ConveyorPreviewRendererFragment P1, ref SharedDataFragment P2, bool P3, bool P4) {} // 0x00000001819A0DB0-0x00000001819A2210
		public void __Gen_Wrap_486(ref ConveyorPreviewCollectJob P0, int P1) {} // 0x00000001819A2210-0x00000001819A2E10
		public void __Gen_Wrap_487(ref ConveyorPreviewCollectJob P0) {} // 0x00000001819A2E10-0x00000001819A3A00
		public void __Gen_Wrap_488(ref ConveyorPreviewCollectJob P0, IntPtr P1) {} // 0x00000001819A3A00-0x00000001819A4630
		public void __Gen_Wrap_489(ref ConveyorRendererJob P0, Entity P1, float P2, uint P3, float3 P4, float3 P5, float P6, float P7, float P8, bool P9, BlueprintState.EffectType P10, float P11, uint P12, bool P13, bool P14, bool P15) {} // 0x00000001819A4630-0x00000001819A5770
		public void __Gen_Wrap_490(ref ConveyorRendererJob P0, int P1) {} // 0x00000001819A5770-0x00000001819A6350
		public void __Gen_Wrap_491(ref ConveyorRendererJob P0, int P1, int P2) {} // 0x00000001819A6350-0x00000001819A6F50
		public void __Gen_Wrap_492(ref ConveyorRendererJob P0, IntPtr P1) {} // 0x00000001819A6F50-0x00000001819A7B70
		public void __Gen_Wrap_493(ref InteractFacCollectJob P0) {} // 0x00000001819A7B70-0x00000001819A88C0
		public bool __Gen_Wrap_494(float3 P0, float3 P1, float3 P2, float P3, float P4, out float P5, out float P6, bool P7) {
			P5 = default;
			P6 = default;
			return default;
		} // 0x00000001819A88C0-0x00000001819A9140
		public void __Gen_Wrap_495(ref InteractFacCollectJob.BuildingInfo P0, in InteractFacCollectJob.BuildingInfo P1) {} // 0x00000001819A9140-0x00000001819A9E70
		public float3 __Gen_Wrap_496(float3 P0) => default; // 0x00000001819A9E70-0x00000001819AAA20
		public bool __Gen_Wrap_497(ref InteractFacCollectJob P0, float3 P1, float P2, ref int P3) => default; // 0x00000001819AAA20-0x00000001819AB9A0
		public void __Gen_Wrap_498(ref InteractFacCollectJob P0, IntPtr P1) {} // 0x00000001819AB9A0-0x00000001819AC730
		public string __Gen_Wrap_499(ref InteractFacCollectJob.BuildingInfo P0) => default; // 0x00000001819AC730-0x00000001819AD620
		public bool __Gen_Wrap_500(ref InteractFacCollectJob.BuildingInfo P0) => default; // 0x00000001819AD620-0x00000001819AE230
		public bool __Gen_Wrap_501(ref InteractFacCollectJob.LogisticInfo P0) => default; // 0x00000001819AE230-0x00000001819AEE00
		public void __Gen_Wrap_502(ref LocalToWorldJob P0, int P1) {} // 0x00000001819AEE00-0x00000001819AF9C0
		public void __Gen_Wrap_503(ref LocalToWorld P0, IntPtr P1, int P2) {} // 0x00000001819AF9C0-0x00000001819B06D0
		public void __Gen_Wrap_504(ref LocalToWorldJob P0, int P1, int P2) {} // 0x00000001819B06D0-0x00000001819B12A0
		public void __Gen_Wrap_505(ref LocalToWorldJob P0, IntPtr P1) {} // 0x00000001819B12A0-0x00000001819B1EA0
		public void __Gen_Wrap_506(ref LocalToWorldJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001819B1EA0-0x00000001819B2E70
		public JobHandle __Gen_Wrap_507(ref LocalToWorldJob P0, JobHandle P1, int P2) => default; // 0x00000001819B2E70-0x00000001819B3E20
		public void __Gen_Wrap_508(ref LocalToWorldQueryJob P0) {} // 0x00000001819B3E20-0x00000001819B49D0
		public void __Gen_Wrap_509(ref LocalToWorldQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x00000001819B49D0-0x00000001819B59C0
		public void __Gen_Wrap_510(ref LogisticEffectJob P0, int P1) {} // 0x00000001819B59C0-0x00000001819B65A0
		public void __Gen_Wrap_511(ref LookAtJob P0, int P1) {} // 0x00000001819B65A0-0x00000001819B7150
		public void __Gen_Wrap_512(ref LookAtJob P0, IntPtr P1) {} // 0x00000001819B7150-0x00000001819B7D30
		public void __Gen_Wrap_513(ref LookAtJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001819B7D30-0x00000001819B8CE0
		public JobHandle __Gen_Wrap_514(ref LookAtJob P0, JobHandle P1, int P2) => default; // 0x00000001819B8CE0-0x00000001819B9C80
		public void __Gen_Wrap_515(ref LookAtQueryJob P0) {} // 0x00000001819B9C80-0x00000001819BA830
		public void __Gen_Wrap_516(ref LookAtQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x00000001819BA830-0x00000001819BB820
		public void __Gen_Wrap_517(ref OutputCollectJob P0, ref UnitFragment P1, ref UnitTransFragment P2, ref UnitConfigFragment P3, ref OutputFragment P4, ref SharedDataFragment P5) {} // 0x00000001819BB820-0x00000001819BD840
		public void __Gen_Wrap_518(ref OutputCollectJob P0, int P1) {} // 0x00000001819BD840-0x00000001819BE420
		public void __Gen_Wrap_519(ref OutputCollectJob P0, int P1, int P2) {} // 0x00000001819BE420-0x00000001819BF020
		public void __Gen_Wrap_520(ref OutputCollectJob P0) {} // 0x00000001819BF020-0x00000001819BFBF0
		public void __Gen_Wrap_521(ref OutputCollectJob P0, IntPtr P1) {} // 0x00000001819BFBF0-0x00000001819C0810
		public void __Gen_Wrap_522(ref OutputRenderJob P0, int P1) {} // 0x00000001819C0810-0x00000001819C13E0
		public float4 __Gen_Wrap_523(ref PedestalFlashJob P0, ref PedestalLightFlashFragment P1, float P2) => default; // 0x00000001819C13E0-0x00000001819C2620
		public void __Gen_Wrap_524(ref PedestalFlashJob P0, int P1) {} // 0x00000001819C2620-0x00000001819C31F0
		public void __Gen_Wrap_525(ref PedestalFlashJob P0, int P1, int P2) {} // 0x00000001819C31F0-0x00000001819C3DD0
		public void __Gen_Wrap_526(ref PedestalFlashJob P0, IntPtr P1) {} // 0x00000001819C3DD0-0x00000001819C49D0
		public void __Gen_Wrap_527(ref PipeCollectJob P0, int P1, uint P2, uint P3, int P4, float P5, float P6, float P7, float P8, uint P9, bool P10, bool P11, bool P12) {} // 0x00000001819C49D0-0x00000001819C56D0
		public void __Gen_Wrap_528(ref PipeCollectJob P0, in PipeFragment P1, uint P2) {} // 0x00000001819C56D0-0x00000001819C6560
		public void __Gen_Wrap_529(ref PipeCollectJob P0, EntityQueryV2.BlockRange P1, NativeList<GroupType> P2) {} // 0x00000001819C6560-0x00000001819C75F0
		public void __Gen_Wrap_530(ref PipeCollectJob P0, int P1, uint P2, uint P3, float P4, float P5, float P6, uint P7, bool P8) {} // 0x00000001819C75F0-0x00000001819C8280
		public void __Gen_Wrap_531(ref PipeCollectJob P0, int P1) {} // 0x00000001819C8280-0x00000001819C8F10
		public void __Gen_Wrap_532(ref PipeCollectJob P0, int P1, int P2) {} // 0x00000001819C8F10-0x00000001819C9BC0
		public void __Gen_Wrap_533(ref PipeCollectJob P0) {} // 0x00000001819C9BC0-0x00000001819CA840
		public void __Gen_Wrap_534(ref PipeCollectJob P0, ref GlobalEnv P1) {} // 0x00000001819CA840-0x00000001819CBAD0
		public void __Gen_Wrap_535(ref PipeCollectJob P0, IntPtr P1) {} // 0x00000001819CBAD0-0x00000001819CC7B0
		public void __Gen_Wrap_536(ref PipeComRendererJob P0, int P1, int P2) {} // 0x00000001819CC7B0-0x00000001819CD3B0
		public void __Gen_Wrap_537(ref PipeFigureRendererJob P0, Entity P1, byte P2, float3 P3, float3 P4, float P5, float P6, float P7, float P8, float P9, float P10, bool P11, bool P12, bool P13) {} // 0x00000001819CD3B0-0x00000001819CE4A0
		public void __Gen_Wrap_538(ref PipeFigureRendererJob P0, int P1) {} // 0x00000001819CE4A0-0x00000001819CF070
		public void __Gen_Wrap_539(ref PipeFigureRendererJob P0, int P1, int P2) {} // 0x00000001819CF070-0x00000001819CFC50
		public void __Gen_Wrap_540(ref PipeHolderFigureRendererJob P0, int P1) {} // 0x00000001819CFC50-0x00000001819D0830
		public void __Gen_Wrap_541(ref PipeHolderFigureRendererJob P0, int P1, int P2) {} // 0x00000001819D0830-0x00000001819D1430
		public void __Gen_Wrap_542(ref PipeHolderHideRendererJob P0, int P1) {} // 0x00000001819D1430-0x00000001819D2000
		public void __Gen_Wrap_543(ref PipeHolderHideRendererJob P0, int P1, int P2) {} // 0x00000001819D2000-0x00000001819D2BE0
		public void __Gen_Wrap_544(ref PipeHolderHideRendererJob P0, IntPtr P1) {} // 0x00000001819D2BE0-0x00000001819D37E0
		public void __Gen_Wrap_545(ref PipeLogisticsPosCollectJob P0, int P1) {} // 0x00000001819D37E0-0x00000001819D43B0
		public void __Gen_Wrap_546(ref PipeLogisticsPosCollectJob P0, int P1, int P2) {} // 0x00000001819D43B0-0x00000001819D4F90
		public void __Gen_Wrap_547(ref PipeLogisticsPosCollectJob P0, IntPtr P1) {} // 0x00000001819D4F90-0x00000001819D5B90
		public void __Gen_Wrap_548(ref PipeLogisticsPosCollectJob P0) {} // 0x00000001819D5B90-0x00000001819D6750
		public void __Gen_Wrap_549(ref PipeRendererJob P0, Entity P1, byte P2, float3 P3, float3 P4, float P5, uint P6, int P7, int P8, float P9, float P10, float P11, BlueprintState.EffectType P12, float P13, uint P14, bool P15, bool P16, bool P17) {} // 0x00000001819D6750-0x00000001819D7870
		public void __Gen_Wrap_550(ref PipeRendererJob P0, int P1, int P2) {} // 0x00000001819D7870-0x00000001819D8480
		public void __Gen_Wrap_551(ref PipeRendererJob P0, IntPtr P1) {} // 0x00000001819D8480-0x00000001819D90B0
		public void __Gen_Wrap_552(ref PipeTrackRendererJob P0, Entity P1, float3 P2, float3 P3, float P4, float P5, float P6, float P7, float P8, bool P9) {} // 0x00000001819D90B0-0x00000001819DA280
		public void __Gen_Wrap_553(ref PipeTrackRendererJob P0) {} // 0x00000001819DA280-0x00000001819DAEA0
		public void __Gen_Wrap_554(ref PipeWaterThicknessQueryJob P0) {} // 0x00000001819DAEA0-0x00000001819DBA50
		public void __Gen_Wrap_555(ref PipeWaterThicknessQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x00000001819DBA50-0x00000001819DCA40
		public void __Gen_Wrap_556(ref PipeWaterThicknessRiseJob P0, int P1) {} // 0x00000001819DCA40-0x00000001819DD600
		public void __Gen_Wrap_557(ref PipeWaterThicknessRiseJob P0, int P1, int P2) {} // 0x00000001819DD600-0x00000001819DE1D0
		public void __Gen_Wrap_558(ref PipeWaterThicknessRiseJob P0, ref GlobalEnv P1) {} // 0x00000001819DE1D0-0x00000001819DF3B0
		public void __Gen_Wrap_559(ref PipeWaterThicknessRiseJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001819DF3B0-0x00000001819E0380
		public JobHandle __Gen_Wrap_560(ref PipeWaterThicknessRiseJob P0, JobHandle P1, int P2) => default; // 0x00000001819E0380-0x00000001819E1330
		public void __Gen_Wrap_561(ref PortArrowRenderJob P0, int P1) {} // 0x00000001819E1330-0x00000001819E1F10
		public void __Gen_Wrap_562(ref PortStateCollectJob P0, ref ComplexPortFragment P1, ref SharedDataContainer.SharedExtData P2) {} // 0x00000001819E1F10-0x00000001819E33A0
		public void __Gen_Wrap_563(ref PortStateCollectJob P0, int P1) {} // 0x00000001819E33A0-0x00000001819E3F80
		public void __Gen_Wrap_564(ref PortStateCollectJob P0, IntPtr P1) {} // 0x00000001819E3F80-0x00000001819E4BA0
		public void __Gen_Wrap_565(ref PortStateCollectJob P0) {} // 0x00000001819E4BA0-0x00000001819E5770
		public void __Gen_Wrap_566(ref PortStateCollectJob P0, int P1, int P2) {} // 0x00000001819E5770-0x00000001819E6370
		public void __Gen_Wrap_567(ref PortStateRendererJob P0, int P1) {} // 0x00000001819E6370-0x00000001819E6F40
		public void __Gen_Wrap_568(ref PreviewUnitQueryJob P0) {} // 0x00000001819E6F40-0x00000001819E7AF0
		public void __Gen_Wrap_569(ref PreviewUnitQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x00000001819E7AF0-0x00000001819E8AE0
		public void __Gen_Wrap_570(ref PumpInEffectJob P0, int P1) {} // 0x00000001819E8AE0-0x00000001819E96A0
		public void __Gen_Wrap_571(ref PumpInEffectJob P0, int P1, int P2) {} // 0x00000001819E96A0-0x00000001819EA270
		public void __Gen_Wrap_572(ref PumpInEffectJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001819EA270-0x00000001819EB240
		public JobHandle __Gen_Wrap_573(ref PumpInEffectJob P0, JobHandle P1, int P2) => default; // 0x00000001819EB240-0x00000001819EC1E0
		public void __Gen_Wrap_574(ref PumpInEffectJob P0, IntPtr P1) {} // 0x00000001819EC1E0-0x00000001819ECDD0
		public void __Gen_Wrap_575(ref StatusChangeJob P0, int P1) {} // 0x00000001819ECDD0-0x00000001819EDA10
		public void __Gen_Wrap_576(ref UnitCullingJob P0, int P1) {} // 0x00000001819EDA10-0x00000001819EE620
		public void __Gen_Wrap_577(ref UnitCullingJob P0, int P1, int P2) {} // 0x00000001819EE620-0x00000001819EF240
		public void __Gen_Wrap_578(ref UnitCullingJob P0, ref GlobalEnv P1) {} // 0x00000001819EF240-0x00000001819F0460
		public void __Gen_Wrap_579(ref UnitCullingJob P0, IntPtr P1) {} // 0x00000001819F0460-0x00000001819F10B0
		public void __Gen_Wrap_580(ref UnitPreviewRenderJob P0, int P1) {} // 0x00000001819F10B0-0x00000001819F1C70
		public void __Gen_Wrap_581(ref UnitPreviewRenderJob P0, int P1, int P2) {} // 0x00000001819F1C70-0x00000001819F2840
		public void __Gen_Wrap_582(ref UnitPreviewRenderJob P0, ref GlobalEnv P1) {} // 0x00000001819F2840-0x00000001819F3A20
		public void __Gen_Wrap_583(ref UnitPreviewRenderJob P0, IntPtr P1) {} // 0x00000001819F3A20-0x00000001819F4620
		public void __Gen_Wrap_584(ref UnitPreviewRenderJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001819F4620-0x00000001819F55F0
		public JobHandle __Gen_Wrap_585(ref UnitPreviewRenderJob P0, JobHandle P1, int P2) => default; // 0x00000001819F55F0-0x00000001819F65A0
		public void __Gen_Wrap_586(ref UnitRendererQueryJob P0) {} // 0x00000001819F65A0-0x00000001819F7160
		public void __Gen_Wrap_587(ref UnitRendererQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, ref EntityQueryV2.QueryResultDefer P2, ref EntityQueryV2.QueryResultDefer P3, bool P4) {} // 0x00000001819F7160-0x00000001819F8520
		public void __Gen_Wrap_588(ref UpdateUnitRendererTRSJob P0, int P1) {} // 0x00000001819F8520-0x00000001819F90D0
		public void __Gen_Wrap_589(ref UpdateUnitRendererTRSJob P0, int P1, int P2) {} // 0x00000001819F90D0-0x00000001819F9C80
		public void __Gen_Wrap_590(ref UpdateUnitRendererTRSJob P0, IntPtr P1) {} // 0x00000001819F9C80-0x00000001819FA860
		public void __Gen_Wrap_591(ref UpdateUnitRendererTRSJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001819FA860-0x00000001819FB810
		public JobHandle __Gen_Wrap_592(ref UpdateUnitRendererTRSJob P0, JobHandle P1, int P2) => default; // 0x00000001819FB810-0x00000001819FC7B0
		public void __Gen_Wrap_593(ref WireCollectJob P0, int P1) {} // 0x00000001819FC7B0-0x00000001819FD470
		public void __Gen_Wrap_594(ref WireCollectJob P0) {} // 0x00000001819FD470-0x00000001819FE120
		public void __Gen_Wrap_595(ref WireCollectJob P0, ref GlobalEnv P1) {} // 0x00000001819FE120-0x00000001819FF3D0
		public void __Gen_Wrap_596(ref WireCollectJob P0, IntPtr P1) {} // 0x00000001819FF3D0-0x0000000181A000D0
		public void __Gen_Wrap_597(ref WireRenderJob P0, Entity P1, WireRendererInfo P2) {} // 0x0000000181A000D0-0x0000000181A01090
		public void __Gen_Wrap_598(ref WireRenderJob P0, int P1) {} // 0x0000000181A01090-0x0000000181A01C70
		public void __Gen_Wrap_599(ref WireRenderJob P0, int P1, int P2) {} // 0x0000000181A01C70-0x0000000181A02860
		public bool __Gen_Wrap_600(ref Beyond.Gameplay.Factory.FPtrNativeCurve P0) => default; // 0x0000000181A02860-0x0000000181A03430
		public NativeArray<float> __Gen_Wrap_601(ref Beyond.Gameplay.Factory.FPtrNativeCurve P0, object P1, int P2) => default; // 0x0000000181A03430-0x0000000181A04430
		public float __Gen_Wrap_602(ref Beyond.Gameplay.Factory.FPtrNativeCurve P0, float P1) => default; // 0x0000000181A04430-0x0000000181A05020
		public bool __Gen_Wrap_603(ref StringIntern.FastId P0, StringIntern.FastId P1) => default; // 0x0000000181A05020-0x0000000181A05CC0
		public bool __Gen_Wrap_604(ref StringIntern.FastId P0, object P1) => default; // 0x0000000181A05CC0-0x0000000181A06960
		public int __Gen_Wrap_605(ref StringIntern.FastId P0) => default; // 0x0000000181A06960-0x0000000181A07510
		public bool __Gen_Wrap_606(object P0, out int P1) {
			P1 = default;
			return default;
		} // 0x00000001813553F0-0x00000001813556F0
		public string __Gen_Wrap_607(int P0) => default; // 0x0000000181A07510-0x0000000181A07D90
		public int __Gen_Wrap_608(ref PerDrawPassConfig P0) => default; // 0x0000000181A07D90-0x0000000181A08970
		public HGShaderLightMode __Gen_Wrap_609(ref PerDrawPassConfig P0, PerDrawLightMode P1) => default; // 0x0000000181A08970-0x0000000181A09560
		public void __Gen_Wrap_610(ref PerDrawPassConfig P0, Entity P1, ref uint P2) {} // 0x0000000181A09560-0x0000000181A0A320
		public void __Gen_Wrap_611(ref PerDrawPassConfig P0, HGFactoryRendererBinderComponent P1, ref uint P2) {} // 0x0000000181A0A320-0x0000000181A0B0E0
		public int __Gen_Wrap_612() => default; // 0x000000018136ACA0-0x000000018136AE70
		public void __Gen_Wrap_613(ref PerDrawConfig P0, UnityEngine.Color P1) {} // 0x0000000181A0B0E0-0x0000000181A0C040
		public void __Gen_Wrap_614(ref PerDrawConfig P0, float4 P1) {} // 0x0000000181A0C040-0x0000000181A0CFA0
		public void __Gen_Wrap_615(ref PerDrawConfig P0, float P1) {} // 0x0000000181A0CFA0-0x0000000181A0DBC0
		public void __Gen_Wrap_616(ref PerDrawConfig P0, HGFactoryRendererBinderComponent P1) {} // 0x0000000181A0DBC0-0x0000000181A0EB80
		public bool __Gen_Wrap_617(float P0, float P1, out float P2, float P3, float P4) {
			P2 = default;
			return default;
		} // 0x0000000181A0EB80-0x0000000181A0EE80
		public bool __Gen_Wrap_618(ref IProcessor P0, float P1, float P2) => default; // 0x0000000181A0EE80-0x0000000181A0F8D0
		public void __Gen_Wrap_619(ref GlobalEnv P0, ref InteractFacCollectJob.BuildingInfo P1, ref InteractFacCollectJob.BuildingInfo P2) {} // 0x0000000181A0F8D0-0x0000000181A10D10
		public void __Gen_Wrap_620(ref GlobalEnv P0, ref InteractFacCollectJob.LogisticInfo P1, ref InteractFacCollectJob.LogisticInfo P2) {} // 0x0000000181A10D10-0x0000000181A120C0
		public JobHandle __Gen_Wrap_621(object P0, ref EntityManager P1, ref GlobalEnv P2, ref JobHandle P3, out JobHandle P4) {
			P4 = default;
			return default;
		} // 0x0000000181A120C0-0x0000000181A13890
		public bool __Gen_Wrap_622(ref FFactoryStateColorConfig P0, FacBuildingState P1, out UnityEngine.Color P2) {
			P2 = default;
			return default;
		} // 0x0000000181A13890-0x0000000181A146C0
		public void __Gen_Wrap_623(object P0, ref GlobalEnv P1) {} // 0x0000000181A146C0-0x0000000181A155B0
		public bool __Gen_Wrap_624(object P0, int P1, out UnityEngine.Color P2) {
			P2 = default;
			return default;
		} // 0x0000000181A155B0-0x0000000181A15F10
		public bool __Gen_Wrap_625(object P0, object P1, object P2, out int P3) {
			P3 = default;
			return default;
		} // 0x0000000181A15F10-0x0000000181A16400
		public FactoryBaseColorLutConfig __Gen_Wrap_626(object P0) => default; // 0x0000000181A16400-0x0000000181A16D30
		public bool __Gen_Wrap_627(ref FFactoryStateColorConfig P0, FacBuildingState P1, out string P2) {
			P2 = default;
			return default;
		} // 0x0000000181A16D30-0x0000000181A17C00
		public bool __Gen_Wrap_628(ref FFactoryStateColorConfig P0, LogicEntityState P1, LogicEntityType P2, out PerDrawConfigArray P3) {
			P3 = default;
			return default;
		} // 0x0000000181A17C00-0x0000000181A18AA0
		public void __Gen_Wrap_629(ref FFactoryStateColorConfig.LogicStateConfig P0) {} // 0x0000000181A18AA0-0x0000000181A19670
		public void __Gen_Wrap_630(ref FSMParameterSet P0, byte P1, float P2) {} // 0x0000000181A19670-0x0000000181A1A2B0
		public void __Gen_Wrap_631(ref FSMParameterSet P0, byte P1, int P2) {} // 0x0000000181A1A2B0-0x0000000181A1AEE0
		public void __Gen_Wrap_632(ref FSMParameterSet P0, byte P1, bool P2) {} // 0x0000000181A1AEE0-0x0000000181A1BB10
		public void __Gen_Wrap_633(ref FSMParameterSet P0) {} // 0x0000000181A1BB10-0x0000000181A1C6F0
		public void __Gen_Wrap_634(ref FSMParameterSet P0, in VATFSMDefinition P1) {} // 0x0000000181A1C6F0-0x0000000181A1D6D0
		public void __Gen_Wrap_635(ref FSMState P0) {} // 0x0000000181A1D6D0-0x0000000181A1E2B0
		public void __Gen_Wrap_636(ref VATFSMStateFragment P0, uint P1, uint P2) {} // 0x0000000181A1E2B0-0x0000000181A1EF80
		public void __Gen_Wrap_637(ref FSMTransition P0) {} // 0x0000000181A1EF80-0x0000000181A1FB40
		public void __Gen_Wrap_638(ref VATFSMStateFragment P0, in FSMStateDefinition P1) {} // 0x0000000181A1FB40-0x0000000181A20BB0
		public void __Gen_Wrap_639(ref VATFSMStateFragment P0) {} // 0x0000000181A20BB0-0x0000000181A21800
		public void __Gen_Wrap_640(ref VATFSMStateFragment P0, in FSMTransitionDefinition P1, in FSMStateDefinition P2) {} // 0x0000000181A21800-0x0000000181A22880
		public float __Gen_Wrap_641(ref FSMState P0) => default; // 0x0000000181A22880-0x0000000181A23470
		public void __Gen_Wrap_642(ref FSMState P0, float P1, float P2) {} // 0x0000000181A23470-0x0000000181A24080
		public void __Gen_Wrap_643(ref FSMState P0, float P1) {} // 0x0000000181A24080-0x0000000181A24CA0
		public float __Gen_Wrap_644(ref FSMTransition P0) => default; // 0x0000000181A24CA0-0x0000000181A25870
		public void __Gen_Wrap_645(ref FSMTransition P0, float P1, float P2) {} // 0x0000000181A25870-0x0000000181A26460
		public float __Gen_Wrap_646(ref FSMParameterSet P0, byte P1) => default; // 0x0000000181A26460-0x0000000181A27050
		public int __Gen_Wrap_647(ref FSMParameterSet P0, byte P1) => default; // 0x0000000181A27050-0x0000000181A27C40
		public bool __Gen_Wrap_648(ref FSMParameterSet P0, byte P1) => default; // 0x0000000181A27C40-0x0000000181A28830
		public void __Gen_Wrap_649(ref FSMParameterSet P0, byte P1) {} // 0x0000000181A28830-0x0000000181A29430
		public void __Gen_Wrap_650(ref FSMParameterSet P0, byte P1, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P2, float P3) {} // 0x0000000181A29430-0x0000000181A2A0A0
		public float __Gen_Wrap_651(ref FSMParameterSet P0, byte P1, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P2) => default; // 0x0000000181A2A0A0-0x0000000181A2ACA0
		public void __Gen_Wrap_652(ref VATFSMSetParamRequestHandlerJob P0, int P1) {} // 0x0000000181A2ACA0-0x0000000181A2B870
		public bool __Gen_Wrap_653(in FSMCondition P0, in FSMParameterSet P1, in FixedList128Bytes<FSMParameterDefinition> P2) => default; // 0x0000000181A2B870-0x0000000181A2C590
		public bool __Gen_Wrap_654(ref VATFSMStateFragment P0, ref VATFSMDefinition P1, out int P2) {
			P2 = default;
			return default;
		} // 0x0000000181A2C590-0x0000000181A2D660
		public void __Gen_Wrap_655(ref FSMParameterSet P0, in FSMTransitionDefinition P1, in FixedList128Bytes<FSMParameterDefinition> P2) {} // 0x0000000181A2D660-0x0000000181A2E680
		public bool __Gen_Wrap_656(ref VATFSMStateUpdateJob P0, ref VATFSMStateFragment P1, ref VATFSMDefinition P2) => default; // 0x0000000181A2E680-0x0000000181A2FB80
		public void __Gen_Wrap_657(ref VATFSMStateUpdateJob P0, Entity P1, ref FSMState P2, ref VATFSMDefinition P3) {} // 0x0000000181A2FB80-0x0000000181A31250
		public void __Gen_Wrap_658(ref VATFSMStateUpdateJob P0, ref VATFSMStateFragment P1, ref VATFSMDefinition P2) {} // 0x0000000181A31250-0x0000000181A32740
		public void __Gen_Wrap_659(ref VATFSMStateUpdateJob P0, int P1) {} // 0x0000000181A32740-0x0000000181A33320
		public void __Gen_Wrap_660(ref VATFSMStateUpdateJob P0) {} // 0x0000000181A33320-0x0000000181A33EF0
		public void __Gen_Wrap_661(ref VATFSMStateUpdateJob P0, IntPtr P1) {} // 0x0000000181A33EF0-0x0000000181A34B10
		public void __Gen_Wrap_662(object P0, ref EntityManager P1) {} // 0x0000000181A34B10-0x0000000181A357C0
		public JobHandle __Gen_Wrap_663(object P0, ref EntityManager P1, ref GlobalEnv P2, JobHandle P3) => default; // 0x0000000181A357C0-0x0000000181A36F10
		public string __Gen_Wrap_664(object P0) => default; // 0x0000000181A36F10-0x0000000181A37840
		public uint __Gen_Wrap_665(ref VATFSMDefinitionContainer P0) => default; // 0x0000000181A37840-0x0000000181A38400
		public Span<VATFSMDefinition> __Gen_Wrap_666(ref VATFSMDefinitionContainer P0) => default; // 0x0000000181A38400-0x0000000181A392E0
		public ref VATFSMDefinition __Gen_Wrap_667(ref VATFSMDefinitionContainer P0, uint P1) => ref _refReturnTypeFor__Gen_Wrap_667; // 0x0000000181A392E0-0x0000000181A3A1B0
		private ref VATFSMDefinition _refReturnTypeFor__Gen_Wrap_667; // Dummy field
		public ref VATFSMDefinition __Gen_Wrap_668(ref VATFSMDefinitionContainer P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_668; // 0x0000000181A3A1B0-0x0000000181A3B080
		private ref VATFSMDefinition _refReturnTypeFor__Gen_Wrap_668; // Dummy field
		public void __Gen_Wrap_669(int P0, object P1) {} // 0x0000000181563F30-0x0000000181564220
		public void __Gen_Wrap_670(Entity P0, ref EntityManager P1) {} // 0x0000000181A3B080-0x0000000181A3BFF0
		public string __Gen_Wrap_671(uint P0, byte P1) => default; // 0x0000000181A3BFF0-0x0000000181A3C890
		public void __Gen_Wrap_672(JobHandle P0) {} // 0x0000000181A3C890-0x0000000181A3CE30
		public bool __Gen_Wrap_673(Entity P0) => default; // 0x0000000181A3CE30-0x0000000181A3D3E0
		public bool __Gen_Wrap_674(ref EntityManager P0, ref Entity P1) => default; // 0x0000000181A3D3E0-0x0000000181A3E390
		public bool __Gen_Wrap_675(Entity P0, ref EntityManager P1) => default; // 0x0000000181A3E390-0x0000000181A3F310
		public bool __Gen_Wrap_676(Entity P0, ref EntityManager P1, Visibility.Type P2) => default; // 0x0000000181A3F310-0x0000000181A3FF50
		public bool __Gen_Wrap_677(Entity P0, Visibility.Type P1) => default; // 0x0000000181A3FF50-0x0000000181A40500
		public bool __Gen_Wrap_678(Entity P0, ref EntityManager P1, bool P2, Visibility.EFlag P3, Visibility.Type P4, object P5) => default; // 0x0000000181A40500-0x0000000181A41280
		public void __Gen_Wrap_679(Entity P0, ref EntityManager P1, bool P2, Visibility.EFlag P3, Visibility.Type P4, object P5) {} // 0x0000000181A41280-0x0000000181A41FF0
		public bool __Gen_Wrap_680(Entity P0, bool P1, Visibility.EFlag P2, Visibility.Type P3, ref EntityCommandBuffer P4) => default; // 0x0000000181A41FF0-0x0000000181A42D50
		public void __Gen_Wrap_681(Entity P0, bool P1) {} // 0x0000000181A42D50-0x0000000181A43300
		public void __Gen_Wrap_682(Entity P0, ref EntityCommandBufferV2.EntityCommandBufferParallelWriter P1) {} // 0x0000000181A43300-0x0000000181A44260
		public bool __Gen_Wrap_683(Entity P0, ref EntityManager P1, FixedString32Bytes P2, out float3 P3, out quaternion P4, out Entity P5) {
			P3 = default;
			P4 = default;
			P5 = default;
			return default;
		} // 0x0000000181A44260-0x0000000181A456C0
		public bool __Gen_Wrap_684(Entity P0, ref EntityManager P1, FixedString32Bytes P2, out float3 P3, out quaternion P4) {
			P3 = default;
			P4 = default;
			return default;
		} // 0x0000000181A456C0-0x0000000181A46AD0
		public bool __Gen_Wrap_685(Entity P0, object P1, out float3 P2, out quaternion P3) {
			P2 = default;
			P3 = default;
			return default;
		} // 0x0000000181A46AD0-0x0000000181A479C0
		public ref ChapterFragment __Gen_Wrap_686(EntityManager P0, int P1, out bool P2, out Entity P3) {
			P2 = default;
			P3 = default;
			return default;
		} // 0x0000000181A479C0-0x0000000181A487A0
		private ref ChapterFragment _refReturnTypeFor__Gen_Wrap_686; // Dummy field
		public IntPtr __Gen_Wrap_687(EntityManager P0) => default; // 0x0000000181A487A0-0x0000000181A48D50
		public bool __Gen_Wrap_688(EntityManager P0) => default; // 0x0000000181A48D50-0x0000000181A49300
		public ref GlobalEnv __Gen_Wrap_689(EntityManager P0) => ref _refReturnTypeFor__Gen_Wrap_689; // 0x0000000181A49300-0x0000000181A49EE0
		private ref GlobalEnv _refReturnTypeFor__Gen_Wrap_689; // Dummy field
		public bool __Gen_Wrap_690(ref GlobalEnv P0, out InteractFacCollectJob.BuildingInfo P1) {
			P1 = default;
			return default;
		} // 0x0000000181A49EE0-0x0000000181A4AEC0
		public bool __Gen_Wrap_691(ref GlobalEnv P0, out InteractFacCollectJob.LogisticInfo P1) {
			P1 = default;
			return default;
		} // 0x0000000181A4AEC0-0x0000000181A4BE80
		public LinearAllocator.Allocation __Gen_Wrap_692(object P0, int P1) => default; // 0x0000000181A4BE80-0x0000000181A4C780
		public void __Gen_Wrap_693(object P0, int P1) {} // 0x000000018155EB40-0x000000018155EE10
		public LinearAllocator.Allocation __Gen_Wrap_694(object P0, int P1, int P2) => default; // 0x0000000181A4C780-0x0000000181A4D0A0
		public void __Gen_Wrap_695(ref LinearAllocatorUnmanaged P0, int P1, Unity.Collections.Allocator P2) {} // 0x0000000181A4D0A0-0x0000000181A4DCE0
		public uint __Gen_Wrap_696(object P0) => default; // 0x00000001815570F0-0x00000001815573B0
		public void __Gen_Wrap_697(object P0, uint P1, out int P2, out int P3) {
			P2 = default;
			P3 = default;
		} // 0x0000000181A4DCE0-0x0000000181A4E020
		public IntPtr __Gen_Wrap_698(ref GlobalEnv P0) => default; // 0x0000000181A4E020-0x0000000181A4F0D0
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 50093
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000187993EAC-0x0000000187993F40
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 50094
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000187999828-0x000000018799988C
		public static bool IsPatched(int id) => default; // 0x0000000184165160-0x00000001841651D0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001879996E4-0x00000001879997B0
		public object CreateWrapper(int id) => default; // 0x00000001879997B0-0x0000000187999828
		public object InitWrapperArray(int len) => default; // 0x000000018799988C-0x00000001879999B4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000187999640-0x00000001879996E4
	}

	public enum IDMAP0 // TypeDefIndex: 50095
	{
		Beyond-AssetInstanceParseUtil-Parse1 = 0,
		Beyond-AssetInstanceParseUtil-Parse0 = 1,
		Beyond-AssetInstanceParseUtil-Get0 = 2,
		Beyond-PoolCore-ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond-InitializeAtRuntime0 = 3,
		Beyond-PoolCore-ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond-Initialize0 = 4,
		Beyond-Gameplay-FactorySetting-OnEnable0 = 5,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-OnEnable0 = 6,
		Beyond-Gameplay-Factory-PerDrawConfig-OnValidate0 = 7,
		Beyond-Gameplay-Factory-PerDrawConfig-_OnPerDrawTypeChanged0 = 8,
		Beyond-Gameplay-Factory-Archetypes-get_empty0 = 9,
		Beyond-Gameplay-Factory-Archetypes-get_env0 = 10,
		Beyond-Gameplay-Factory-Archetypes-get_connection0 = 11,
		Beyond-Gameplay-Factory-Archetypes-get_buildingUnit0 = 12,
		Beyond-Gameplay-Factory-Archetypes-get_powerStation0 = 13,
		Beyond-Gameplay-Factory-Archetypes-CreateArchetype0 = 14,
		Beyond-Gameplay-Factory-Archetypes-get_furnace0 = 15,
		Beyond-Gameplay-Factory-Archetypes-get_grinder0 = 16,
		Beyond-Gameplay-Factory-Archetypes-get_winder0 = 17,
		Beyond-Gameplay-Factory-Archetypes-get_componentMc0 = 18,
		Beyond-Gameplay-Factory-Archetypes-get_shaper0 = 19,
		Beyond-Gameplay-Factory-Archetypes-get_fillingPowderMc0 = 20,
		Beyond-Gameplay-Factory-Archetypes-get_thickener0 = 21,
		Beyond-Gameplay-Factory-Archetypes-get_hub0 = 22,
		Beyond-Gameplay-Factory-Archetypes-get_subHub0 = 23,
		Beyond-Gameplay-Factory-Archetypes-get_miner0 = 24,
		Beyond-Gameplay-Factory-Archetypes-get_toolsAssemblingMc0 = 25,
		Beyond-Gameplay-Factory-Archetypes-get_seedCollector0 = 26,
		Beyond-Gameplay-Factory-Archetypes-get_planter0 = 27,
		Beyond-Gameplay-Factory-Archetypes-get_powerDiffuser0 = 28,
		Beyond-Gameplay-Factory-Archetypes-get_powerPole0 = 29,
		Beyond-Gameplay-Factory-Archetypes-get_travelPole0 = 30,
		Beyond-Gameplay-Factory-Archetypes-get_loader0 = 31,
		Beyond-Gameplay-Factory-Archetypes-get_unloader0 = 32,
		Beyond-Gameplay-Factory-Archetypes-get_storage0 = 33,
		Beyond-Gameplay-Factory-Archetypes-get_powerTerminal0 = 34,
		Beyond-Gameplay-Factory-Archetypes-get_powerPort0 = 35,
		Beyond-Gameplay-Factory-Archetypes-get_facBattle0 = 36,
		Beyond-Gameplay-Factory-Archetypes-get_pump0 = 37,
		Beyond-Gameplay-Factory-Archetypes-get_liquidStorage0 = 38,
		Beyond-Gameplay-Factory-Archetypes-get_mixPool0 = 39,
		Beyond-Gameplay-Factory-Archetypes-get_squirter0 = 40,
		Beyond-Gameplay-Factory-Archetypes-get_dumper0 = 41,
		Beyond-Gameplay-Factory-Archetypes-get_liquidCleaner0 = 42,
		Beyond-Gameplay-Factory-Archetypes-get_xiraniteOven0 = 43,
		Beyond-Gameplay-Factory-Archetypes-get_liquidPurifier0 = 44,
		Beyond-Gameplay-Factory-Archetypes-get_dismantler0 = 45,
		Beyond-Gameplay-Factory-Archetypes-get_hsBus0 = 46,
		Beyond-Gameplay-Factory-Archetypes-get_hsBusSource0 = 47,
		Beyond-Gameplay-Factory-Archetypes-get_udPipeLoader0 = 48,
		Beyond-Gameplay-Factory-Archetypes-get_udPipeUnloader0 = 49,
		Beyond-Gameplay-Factory-Archetypes-get_liquidCleanGate0 = 50,
		Beyond-Gameplay-Factory-Archetypes-get_liquidRecycleGate0 = 51,
		Beyond-Gameplay-Factory-Archetypes-get_carrier0 = 52,
		Beyond-Gameplay-Factory-Archetypes-get_marker0 = 53,
		Beyond-Gameplay-Factory-Archetypes-get_decoration0 = 54,
		Beyond-Gameplay-Factory-Archetypes-get_pipeConditioner0 = 55,
		Beyond-Gameplay-Factory-Archetypes-get_logConditioner0 = 56,
		Beyond-Gameplay-Factory-Archetypes-get_buildingFakeUnit0 = 57,
		Beyond-Gameplay-Factory-Archetypes-get_buildingRenderOnlyUnit0 = 58,
		Beyond-Gameplay-Factory-Archetypes-get_buildingPreviewUnit0 = 59,
		Beyond-Gameplay-Factory-Archetypes-get_buildingGuideHintUnit0 = 60,
		Beyond-Gameplay-Factory-Archetypes-get_conveyor0 = 61,
		Beyond-Gameplay-Factory-Archetypes-get_guideConveyor0 = 62,
		Beyond-Gameplay-Factory-Archetypes-get_pipe0 = 63,
		Beyond-Gameplay-Factory-Archetypes-get_pipeHolder0 = 64,
		Beyond-Gameplay-Factory-Archetypes-get_cargo0 = 65,
		Beyond-Gameplay-Factory-Archetypes-get_buildingRender0 = 66,
		Beyond-Gameplay-Factory-Archetypes-get_pedestalRender0 = 67,
		Beyond-Gameplay-Factory-Archetypes-get_conveyorLeftRender0 = 68,
		Beyond-Gameplay-Factory-Archetypes-get_conveyorRightRender0 = 69,
		Beyond-Gameplay-Factory-Archetypes-get_conveyorMidRender0 = 70,
		Beyond-Gameplay-Factory-Archetypes-get_figurePipeHolderRender0 = 71,
		Beyond-Gameplay-Factory-Archetypes-get_figureLeftRender0 = 72,
		Beyond-Gameplay-Factory-Archetypes-get_figureRightRender0 = 73,
		Beyond-Gameplay-Factory-Archetypes-get_figureMidRender0 = 74,
		Beyond-Gameplay-Factory-Archetypes-get_conveyorPreviewRender0 = 75,
		Beyond-Gameplay-Factory-Archetypes-get_pipePreviewRender0 = 76,
		Beyond-Gameplay-Factory-Archetypes-get_pipeComRender0 = 77,
		Beyond-Gameplay-Factory-Archetypes-get_pipeLeftRender0 = 78,
		Beyond-Gameplay-Factory-Archetypes-get_pipeMidRender0 = 79,
		Beyond-Gameplay-Factory-Archetypes-get_pipeRightRender0 = 80,
		Beyond-Gameplay-Factory-Archetypes-get_pipeTrackLeftPreviewRender0 = 81,
		Beyond-Gameplay-Factory-Archetypes-get_pipeTrackMidPreviewRender0 = 82,
		Beyond-Gameplay-Factory-Archetypes-get_pipeTrackRightPreviewRender0 = 83,
		Beyond-Gameplay-Factory-Archetypes-get_outputUIRenderer0 = 84,
		Beyond-Gameplay-Factory-Archetypes-get_wireRenderer0 = 85,
		Beyond-Gameplay-Factory-Archetypes-get_unitStatusUIRenderer0 = 86,
		Beyond-Gameplay-Factory-Archetypes-get_portPreviewUIRenderer0 = 87,
		Beyond-Gameplay-Factory-Archetypes-get_gridRenderer0 = 88,
		Beyond-Gameplay-Factory-Archetypes-get_gridMainRegionRenderer0 = 89,
		Beyond-Gameplay-Factory-Archetypes-get_portStatusUIRenderer0 = 90,
		Beyond-Gameplay-Factory-Archetypes-get_scope0 = 91,
		Beyond-Gameplay-Factory-Archetypes-Select0 = 92,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Dispose0 = 94,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Size0 = 95,
		Beyond-Gameplay-Factory-ConveyorExtContainer-AsSpan0 = 96,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Create0 = 97,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Destroy0 = 98,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Reset0 = 99,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Reserve0 = 100,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Data0 = 101,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Get0 = 102,
		Beyond-Gameplay-Factory-ConveyorExtContainer-ConveyorExt-Reset0 = 103,
		Beyond-Gameplay-Factory-ConveyorInfoAllocator-Allocate0 = 104,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Allocate0 = 105,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-_ExpandMemory0 = 107,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-_MergeAdjacentFreeBlocks0 = 108,
		Beyond-Gameplay-Factory-ConveyorInfoAllocator-Resize0 = 109,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Resize0 = 110,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Free0 = 111,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Expand0 = 112,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Reserve0 = 113,
		Beyond-Gameplay-Factory-ConveyorInfoAllocator-Free0 = 114,
		Beyond-Gameplay-Factory-ConveyorInfoAllocator-CalculateSize0 = 115,
		Beyond-Gameplay-Factory-ConveyorInfoAllocator-DebugPrint0 = 116,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-PrintAllocations0 = 117,
		Beyond-Gameplay-Factory-SharedDataContainer-Dispose0 = 122,
		Beyond-Gameplay-Factory-SharedDataContainer-Size0 = 123,
		Beyond-Gameplay-Factory-SharedDataContainer-AsSpan0 = 124,
		Beyond-Gameplay-Factory-SharedDataContainer-Create0 = 125,
		Beyond-Gameplay-Factory-SharedDataContainer-Destroy0 = 126,
		Beyond-Gameplay-Factory-SharedDataContainer-Reset0 = 127,
		Beyond-Gameplay-Factory-SharedDataContainer-Reserve0 = 128,
		Beyond-Gameplay-Factory-SharedDataContainer-Data0 = 129,
		Beyond-Gameplay-Factory-SharedDataContainer-Get0 = 130,
		Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-IsDirty0 = 131,
		Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-SetDirty0 = 132,
		Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-IsPendingUnit0 = 133,
		Beyond-Gameplay-Factory-WireRendererInfo-get_pos0 = 134,
		Beyond-Gameplay-Factory-WireRendererInfo-get_rot0 = 135,
		Beyond-Gameplay-Factory-EntitySearcher-GetLogicEntityMap0 = 136,
		Beyond-Gameplay-Factory-EntitySearcher-RegisterLogicEntity0 = 137,
		Beyond-Gameplay-Factory-UnitId-Create0 = 138,
		Beyond-Gameplay-Factory-EntitySearcher-UnregisterLogicEntity0 = 139,
		Beyond-Gameplay-Factory-EntitySearcher-GetLogicEntity0 = 140,
		Beyond-Gameplay-Factory-EntitySearcher-_DestroyAllEntities0 = 141,
		Beyond-Gameplay-Factory-EntitySearcher-DestroyAll0 = 142,
		Beyond-Gameplay-Factory-FactorySharedDataManager-InitExtData0 = 143,
		Beyond-Gameplay-Factory-FactorySharedDataManager-ResetExtData0 = 144,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Reset0 = 145,
		Beyond-Gameplay-Factory-FactorySharedDataManager-ReleaseExtData0 = 146,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Dispose0 = 147,
		Beyond-Gameplay-Factory-FactorySharedDataManager-CreateConveyorExtHandle0 = 148,
		Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyConveyorExtHandle0 = 149,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetConveyorExt0 = 150,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetConveyorExtData0 = 151,
		Beyond-Gameplay-Factory-FactorySharedDataManager-CreateSharedData0 = 152,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetSharedData0 = 153,
		Beyond-Gameplay-Factory-FactorySharedDataManager-DestroySharedData0 = 154,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetSharedData1 = 155,
		Beyond-Gameplay-Factory-FactorySharedDataManager-CreateTransHierarchy0 = 156,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData0 = 157,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData1 = 158,
		Beyond-Gameplay-Factory-FactorySharedDataManager-WorldTrans0 = 159,
		Beyond-Gameplay-Factory-LocalTransform-ToMatrix0 = 160,
		Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyHierarchyData0 = 161,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData2 = 162,
		Beyond-Gameplay-Factory-FactorySharedDataManager-CreateVATFSMDefinitionContainer0 = 163,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Create0 = 164,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetVATFSMDefinition0 = 165,
		Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyVATFSMDefinition0 = 166,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Destroy0 = 167,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetVATFSMDefinition1 = 168,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Data0 = 169,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-PushState0 = 170,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-PeekState0 = 171,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-_Shrink0 = 172,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-PopState0 = 173,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-ShiftState0 = 174,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-InsertState0 = 175,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-DisableState0 = 176,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-ToString0 = 177,
		Beyond-Gameplay-Factory-CutoffState-SetEnable0 = 178,
		Beyond-Gameplay-Factory-CutoffState-SetCutoffY0 = 180,
		Beyond-Gameplay-Factory-CutoffState-SetMode0 = 181,
		Beyond-Gameplay-Factory-BuildDismissState-SetEnable0 = 182,
		Beyond-Gameplay-Factory-HighLightState-SetEnable0 = 183,
		Beyond-Gameplay-Factory-HighLightState-SetData0 = 184,
		Beyond-Gameplay-Factory-HighLightState-GetEffectType0 = 185,
		Beyond-Gameplay-Factory-HighLightState-IsHighlight0 = 186,
		Beyond-Gameplay-Factory-HighLightState-HighlightWithSubIndex0 = 187,
		Beyond-Gameplay-Factory-HighLightState-ClearHighlightableIndexList0 = 188,
		Beyond-Gameplay-Factory-HintState-SetEnable0 = 189,
		Beyond-Gameplay-Factory-FigureState-SetEnable0 = 190,
		Beyond-Gameplay-Factory-OverloadState-SetEnable0 = 191,
		Beyond-Gameplay-Factory-OverloadInvalidState-SetEnable0 = 192,
		Beyond-Gameplay-Factory-DitherState-SetEnable0 = 193,
		Beyond-Gameplay-Factory-BlueprintState-SetEnable0 = 194,
		Beyond-Gameplay-Factory-BlueprintState-SetEnable1 = 195,
		Beyond-Gameplay-Factory-BlueprintState-IsLighten0 = 196,
		Beyond-Gameplay-Factory-BlueprintState-LightenWithSubIndex0 = 197,
		Beyond-Gameplay-Factory-BlueprintState-ClearLightenIndexList0 = 198,
		Beyond-Gameplay-Factory-PreSelectState-SetEnable0 = 199,
		Beyond-Gameplay-Factory-PreSelectState-IsLighten0 = 200,
		Beyond-Gameplay-Factory-PreSelectState-LightenWithSubIndex0 = 201,
		Beyond-Gameplay-Factory-PreSelectState-ClearLightenIndexList0 = 202,
		Beyond-Gameplay-Factory-SoloSelectState-SetEnable0 = 203,
		Beyond-Gameplay-Factory-SoloSelectState-IsLighten0 = 204,
		Beyond-Gameplay-Factory-ContinuationState-SetEnable0 = 205,
		Beyond-Gameplay-Factory-ContinuationState-IsLighten0 = 206,
		Beyond-Gameplay-Factory-ContinuationState-LightenWithSubIndex0 = 207,
		Beyond-Gameplay-Factory-ContinuationState-ClearLightenIndexList0 = 208,
		Beyond-Gameplay-Factory-SocialSharingState-SetEnable0 = 209,
		Beyond-Gameplay-Factory-PowerInteractionState-SetEnable0 = 210,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_anyEffect0 = 211,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-__AOT_FOR_FIX__0 = 212,
		Beyond-Gameplay-Factory-BattleFragment-__AOT_FOR_FIX__0 = 213,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntity0 = 214,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-Binded0 = 215,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntities0 = 216,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntities1 = 217,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-UnbindRenderEntity0 = 218,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-ClearBindRenderEntities0 = 219,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-HasRenderer0 = 220,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-__AOT_FOR_FIX__0 = 221,
		Beyond-Gameplay-Factory-BurnPowerFragment-__AOT_FOR_FIX__0 = 222,
		Beyond-Gameplay-Factory-BusFragment-__AOT_FOR_FIX__0 = 223,
		Beyond-Gameplay-Factory-BusFreeFragment-__AOT_FOR_FIX__0 = 224,
		Beyond-Gameplay-Factory-CacheFragment-GetCacheItem0 = 225,
		Beyond-Gameplay-Factory-CacheFragment-CalcIndex0 = 226,
		Beyond-Gameplay-Factory-CacheFragment-SetCacheItem0 = 227,
		Beyond-Gameplay-Factory-CacheFragment-SetCacheSize0 = 228,
		Beyond-Gameplay-Factory-CacheFragment-__AOT_FOR_FIX__0 = 229,
		Beyond-Gameplay-Factory-CacheTransportFragment-__AOT_FOR_FIX__0 = 230,
		Beyond-Gameplay-Factory-CargoFragment-PredictPos0 = 231,
		Beyond-Gameplay-Factory-CargoFragment-PredictPosWithDeltaTime0 = 232,
		Beyond-Gameplay-Factory-CargoFragment-CompareTo0 = 233,
		Beyond-Gameplay-Factory-CargoFragment-Create0 = 234,
		Beyond-Gameplay-Factory-CargoFragment-__AOT_FOR_FIX__0 = 235,
		Beyond-Gameplay-Factory-CargoRendererFragment-__AOT_FOR_FIX__0 = 236,
		Beyond-Gameplay-Factory-ChapterFragment-__AOT_FOR_FIX__0 = 237,
		Beyond-Gameplay-Factory-CollectorFragment-__AOT_FOR_FIX__0 = 238,
		Beyond-Gameplay-Factory-ConnectionFragment-get_valid0 = 239,
		Beyond-Gameplay-Factory-ConnectionFragment-__AOT_FOR_FIX__0 = 240,
		Beyond-Gameplay-Factory-ConveyorFragment-SetInflection0 = 241,
		Beyond-Gameplay-Factory-GlobalEnv-GetConveyorRendererInfo0 = 243,
		Beyond-Gameplay-Factory-ConveyorFragment-CalcRect0 = 244,
		Beyond-Gameplay-Factory-ConveyorFragment-Sample0 = 245,
		Beyond-Gameplay-Factory-ConveyorFragment-IsInRect0 = 247,
		Beyond-Gameplay-Factory-ConveyorFragment-GetInRectUnitIndex0 = 248,
		Beyond-Gameplay-Factory-ConveyorFragment-FillRectTargets0 = 249,
		Beyond-Gameplay-Factory-ConveyorFragment-DrawDebug0 = 250,
		Beyond-Gameplay-Factory-ConveyorFragment-__AOT_FOR_FIX__0 = 251,
		Beyond-Gameplay-Factory-ConveyorLogisticsUnitFragment-__AOT_FOR_FIX__0 = 252,
		Beyond-Gameplay-Factory-ConveyorRenderFragment-__AOT_FOR_FIX__0 = 253,
		Beyond-Gameplay-Factory-LeftFragment-__AOT_FOR_FIX__0 = 254,
		Beyond-Gameplay-Factory-RightFragment-__AOT_FOR_FIX__0 = 255,
		Beyond-Gameplay-Factory-MidFragment-__AOT_FOR_FIX__0 = 256,
		Beyond-Gameplay-Factory-CullResultFragment-__AOT_FOR_FIX__0 = 257,
		Beyond-Gameplay-Factory-DebugFragment-__AOT_FOR_FIX__0 = 258,
		Beyond-Gameplay-Factory-EvtDestroyUnit-__AOT_FOR_FIX__0 = 259,
		Beyond-Gameplay-Factory-ShowStateUI-__AOT_FOR_FIX__0 = 260,
		Beyond-Gameplay-Factory-ShowNameUI-__AOT_FOR_FIX__0 = 261,
		Beyond-Gameplay-Factory-HasRenderer-__AOT_FOR_FIX__0 = 262,
		Beyond-Gameplay-Factory-EvtUpdatePipeEffect-__AOT_FOR_FIX__0 = 263,
		Beyond-Gameplay-Factory-EvtChangeTemplate-__AOT_FOR_FIX__0 = 264,
		Beyond-Gameplay-Factory-EvtCreateUnitRenderer-__AOT_FOR_FIX__0 = 265,
		Beyond-Gameplay-Factory-EvtUpdateStatusEffect-__AOT_FOR_FIX__0 = 266,
		Beyond-Gameplay-Factory-EvtPendingCreateRenderer-__AOT_FOR_FIX__0 = 267,
		Beyond-Gameplay-Factory-EvtUpdateRendererProperty-__AOT_FOR_FIX__0 = 268,
		Beyond-Gameplay-Factory-EvtStatusChange-__AOT_FOR_FIX__0 = 269,
		Beyond-Gameplay-Factory-EvtCreateInteract-__AOT_FOR_FIX__0 = 270,
		Beyond-Gameplay-Factory-EvtVatUpdate-__AOT_FOR_FIX__0 = 271,
		Beyond-Gameplay-Factory-EvtUpdatePedestalColorLUT-__AOT_FOR_FIX__0 = 272,
		Beyond-Gameplay-Factory-EvtAudio-__AOT_FOR_FIX__0 = 273,
		Beyond-Gameplay-Factory-AudioFragment-__AOT_FOR_FIX__0 = 274,
		Beyond-Gameplay-Factory-ReleaseTagFragment-__AOT_FOR_FIX__0 = 275,
		Beyond-Gameplay-Factory-CurMapUnitTag-__AOT_FOR_FIX__0 = 276,
		Beyond-Gameplay-Factory-UnitFragment-Create0 = 277,
		Beyond-Gameplay-Factory-UnitFragment-__AOT_FOR_FIX__0 = 278,
		Beyond-Gameplay-Factory-UnitRenderPipeLogisticsFigureReplaceFragment-__AOT_FOR_FIX__0 = 279,
		Beyond-Gameplay-Factory-BusRenderFragment-__AOT_FOR_FIX__0 = 280,
		Beyond-Gameplay-Factory-UnitRenderBuildingFragment-__AOT_FOR_FIX__0 = 281,
		Beyond-Gameplay-Factory-UnitRenderPedestalFragment-__AOT_FOR_FIX__0 = 282,
		Beyond-Gameplay-Factory-UnitRendererRegularFragment-__AOT_FOR_FIX__0 = 283,
		Beyond-Gameplay-Factory-UnitOnlyRendererFragment-__AOT_FOR_FIX__0 = 284,
		Beyond-Gameplay-Factory-FakeUnitFragment-__AOT_FOR_FIX__0 = 285,
		Beyond-Gameplay-Factory-UIUnitFragment-__AOT_FOR_FIX__0 = 286,
		Beyond-Gameplay-Factory-GuideHintFragment-__AOT_FOR_FIX__0 = 287,
		Beyond-Gameplay-Factory-UnitPreviewFragment-__AOT_FOR_FIX__0 = 288,
		Beyond-Gameplay-Factory-ConveyorRegularFragment-__AOT_FOR_FIX__0 = 289,
		Beyond-Gameplay-Factory-ConveyorGuideFragment-__AOT_FOR_FIX__0 = 290,
		Beyond-Gameplay-Factory-PipeRegularFragment-__AOT_FOR_FIX__0 = 291,
		Beyond-Gameplay-Factory-ConveyorPreviewRendererFragment-__AOT_FOR_FIX__0 = 292,
		Beyond-Gameplay-Factory-PipePreviewRendererFragment-__AOT_FOR_FIX__0 = 293,
		Beyond-Gameplay-Factory-PipePreviewFragment-__AOT_FOR_FIX__0 = 294,
		Beyond-Gameplay-Factory-FigureRenderFragment-__AOT_FOR_FIX__0 = 295,
		Beyond-Gameplay-Factory-FigureRenderLeftFragment-__AOT_FOR_FIX__0 = 296,
		Beyond-Gameplay-Factory-FigureRenderRightFragment-__AOT_FOR_FIX__0 = 297,
		Beyond-Gameplay-Factory-FigureRenderMidFragment-__AOT_FOR_FIX__0 = 298,
		Beyond-Gameplay-Factory-FigureRenderPipeHolderFragment-__AOT_FOR_FIX__0 = 299,
		Beyond-Gameplay-Factory-FluidConsumeFragment-__AOT_FOR_FIX__0 = 300,
		Beyond-Gameplay-Factory-FluidContainerFragment-Set0 = 301,
		Beyond-Gameplay-Factory-FluidContainerFragment-SetCapacity0 = 302,
		Beyond-Gameplay-Factory-FluidContainerFragment-SetAmount0 = 303,
		Beyond-Gameplay-Factory-FluidContainerFragment-Get0 = 304,
		Beyond-Gameplay-Factory-FluidContainerFragment-HasLiquid0 = 305,
		Beyond-Gameplay-Factory-FluidContainerFragment-CalcRenderItemAmount0 = 306,
		Beyond-Gameplay-Factory-FluidContainerFragment-GetOffsetData0 = 307,
		Beyond-Gameplay-Factory-FluidContainerFragment-Reset0 = 308,
		Beyond-Gameplay-Factory-FluidContainerFragment-ToString0 = 309,
		Beyond-Gameplay-Factory-FluidContainerFragment-__AOT_FOR_FIX__0 = 310,
		Beyond-Gameplay-Factory-FluidPumpInFragment-__AOT_FOR_FIX__0 = 311,
		Beyond-Gameplay-Factory-FluidPumpOutFragment-__AOT_FOR_FIX__0 = 312,
		Beyond-Gameplay-Factory-FluidReactionFragment-__AOT_FOR_FIX__0 = 313,
		Beyond-Gameplay-Factory-FluidSprayFragment-__AOT_FOR_FIX__0 = 314,
		Beyond-Gameplay-Factory-FormulaManualFragment-__AOT_FOR_FIX__0 = 315,
		Beyond-Gameplay-Factory-OutOfBufferWarning-ResetFlags0 = 316,
		Beyond-Gameplay-Factory-OutOfBufferWarning-ToString0 = 317,
		Beyond-Gameplay-Factory-GlobalEnv-get_facSystemTickEnabled0 = 318,
		Beyond-Gameplay-Factory-GlobalEnv-InitSkipFlag0 = 319,
		Beyond-Gameplay-Factory-GlobalEnv-CreateQueryResult0 = 320,
		Beyond-Gameplay-Factory-GlobalEnv-DisposeQueryResult0 = 321,
		Beyond-Gameplay-Factory-GlobalEnv-get_portBlockPosListReader0 = 322,
		Beyond-Gameplay-Factory-GlobalEnv-get_outputUIPosListReader0 = 323,
		Beyond-Gameplay-Factory-GlobalEnv-get_buildingStatePosListReader0 = 324,
		Beyond-Gameplay-Factory-GlobalEnv-SwapCargoBuffer0 = 325,
		Beyond-Gameplay-Factory-GlobalEnv-get_cargoDirty0 = 326,
		Beyond-Gameplay-Factory-GlobalEnv-SwapConveyorBuffer0 = 327,
		Beyond-Gameplay-Factory-GlobalEnv-get_conveyorDirty0 = 328,
		Beyond-Gameplay-Factory-GlobalEnv-SwapPortArrowBuffer0 = 329,
		Beyond-Gameplay-Factory-GlobalEnv-get_portArrowDirty0 = 330,
		Beyond-Gameplay-Factory-GlobalEnv-get_conveyorInsideMatricesReader0 = 331,
		Beyond-Gameplay-Factory-GlobalEnv-SwapPreviewConveyorBuffer0 = 332,
		Beyond-Gameplay-Factory-GlobalEnv-get_previewConveyorDirty0 = 333,
		Beyond-Gameplay-Factory-GlobalEnv-SwapGuideFigureBuffer0 = 334,
		Beyond-Gameplay-Factory-GlobalEnv-get_guideFigureDirty0 = 335,
		Beyond-Gameplay-Factory-GlobalEnv-SwapPipeBuffer0 = 336,
		Beyond-Gameplay-Factory-GlobalEnv-get_pipeDirty0 = 337,
		Beyond-Gameplay-Factory-GlobalEnv-get_pipeHolderPosMatricesReader0 = 338,
		Beyond-Gameplay-Factory-GlobalEnv-get_comPosMatricesReader0 = 339,
		Beyond-Gameplay-Factory-GlobalEnv-SwapWireBuffer0 = 340,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireNormalDirty0 = 341,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireHsNormalDirty0 = 342,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireDisableDirty0 = 343,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenDirty0 = 344,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireHsStrengthenDirty0 = 345,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenDisableDirty0 = 346,
		Beyond-Gameplay-Factory-GlobalEnv-GetConveyorRendererInfo1 = 347,
		Beyond-Gameplay-Factory-GlobalEnv-AllocateConveyorInfo0 = 348,
		Beyond-Gameplay-Factory-GlobalEnv-CalculateConveyorInfoSize0 = 349,
		Beyond-Gameplay-Factory-GlobalEnv-ResizeConveyorInfo0 = 350,
		Beyond-Gameplay-Factory-GlobalEnv-FreeConveyorInfo0 = 351,
		Beyond-Gameplay-Factory-GlobalEnv-DebugAllocatorPrint0 = 352,
		Beyond-Gameplay-Factory-GlobalEnv-get_animatorParamRequestQueueReader0 = 353,
		Beyond-Gameplay-Factory-GlobalEnv-AddSetAnimatorParamRequest0 = 354,
		Beyond-Gameplay-Factory-GlobalEnv-_AddAnimatorParamRequest0 = 355,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-TryGetParameterIndexAndType0 = 356,
		Beyond-Gameplay-Factory-StringIntern-FastId-op_Implicit0 = 357,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-GetStateIndex0 = 358,
		Beyond-Gameplay-Factory-GlobalEnv-get_animatorAudioQueueWriter0 = 359,
		Beyond-Gameplay-Factory-GlobalEnv-GetAudioVATDataAt0 = 360,
		Beyond-Gameplay-Factory-GlobalEnv-GetAudioVATDataLength0 = 361,
		Beyond-Gameplay-Factory-GlobalEnv-ClearAudioVATData0 = 362,
		Beyond-Gameplay-Factory-GlobalEnv-ResetFlags0 = 363,
		Beyond-Gameplay-Factory-GlobalEnv-__AOT_FOR_FIX__0 = 364,
		Beyond-Gameplay-Factory-HealthPoleFragment-__AOT_FOR_FIX__0 = 365,
		Beyond-Gameplay-Factory-InventoryFragment-__AOT_FOR_FIX__0 = 366,
		Beyond-Gameplay-Factory-LiquidPurifierFragment-__AOT_FOR_FIX__0 = 367,
		Beyond-Gameplay-Factory-LogisticEffectFragment-__AOT_FOR_FIX__0 = 368,
		Beyond-Gameplay-Factory-LogisticEntityBindFragment-EnqueueCargoEntityImpl0 = 369,
		Beyond-Gameplay-Factory-LogisticEntityBindFragment-DequeueCargoEntityImpl0 = 370,
		Beyond-Gameplay-Factory-LogisticEntityBindFragment-__AOT_FOR_FIX__0 = 371,
		Beyond-Gameplay-Factory-MapGridRendererFragment-__AOT_FOR_FIX__0 = 372,
		Beyond-Gameplay-Factory-OutputFragment-Clean0 = 373,
		Beyond-Gameplay-Factory-OutputFragment-GetColor0 = 374,
		Beyond-Gameplay-Factory-OutputFragment-SetColor0 = 375,
		Beyond-Gameplay-Factory-OutputFragment-SetColor1 = 376,
		Beyond-Gameplay-Factory-OutputFragment-SetAtlasRect0 = 377,
		Beyond-Gameplay-Factory-OutputFragment-SetAtlasRect1 = 378,
		Beyond-Gameplay-Factory-OutputFragment-GetAtlasRect0 = 379,
		Beyond-Gameplay-Factory-OutputFragment-GetEnableLiquidIcon0 = 380,
		Beyond-Gameplay-Factory-OutputFragment-SetEnableLiquidIcon0 = 381,
		Beyond-Gameplay-Factory-OutputFragment-GetLiquidIconUV0 = 382,
		Beyond-Gameplay-Factory-OutputFragment-SetLiquidIconUV0 = 383,
		Beyond-Gameplay-Factory-OutputFragment-get_hasOutput0 = 384,
		Beyond-Gameplay-Factory-OutputFragment-__AOT_FOR_FIX__0 = 385,
		Beyond-Gameplay-Factory-OutputUIRendererFragment-__AOT_FOR_FIX__0 = 386,
		Beyond-Gameplay-Factory-PedestalLightFlashFragment-__AOT_FOR_FIX__0 = 387,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-IsValid0 = 388,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetIntensity0 = 389,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashIntensity0 = 390,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlash0 = 391,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashDuration0 = 392,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetColor0 = 393,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashColor0 = 394,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetIntensity0 = 395,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashIntensity0 = 396,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlash0 = 397,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashDuration0 = 398,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetColor0 = 399,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashColor0 = 400,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-__AOT_FOR_FIX__0 = 401,
		Beyond-Gameplay-Factory-PipeEffectFragment-__AOT_FOR_FIX__0 = 402,
		Beyond-Gameplay-Factory-PipeFragment-SetInflection0 = 403,
		Beyond-Gameplay-Factory-PipeFragment-Bend0 = 406,
		Beyond-Gameplay-Factory-PipeFragment-GetCornerIndexList0 = 407,
		Beyond-Gameplay-Factory-PipeFragment-Sample0 = 408,
		Beyond-Gameplay-Factory-PipeFragment-IsInRect0 = 409,
		Beyond-Gameplay-Factory-PipeFragment-GetInRectUnitIndex0 = 410,
		Beyond-Gameplay-Factory-PipeFragment-FillRectTargets0 = 411,
		Beyond-Gameplay-Factory-PipeFragment-__AOT_FOR_FIX__0 = 412,
		Beyond-Gameplay-Factory-PipeHolderFragment-__AOT_FOR_FIX__0 = 413,
		Beyond-Gameplay-Factory-PipeLogisticsUnitFragment-__AOT_FOR_FIX__0 = 414,
		Beyond-Gameplay-Factory-PipeComRenderFragment-__AOT_FOR_FIX__0 = 415,
		Beyond-Gameplay-Factory-PipeRenderFragment-__AOT_FOR_FIX__0 = 416,
		Beyond-Gameplay-Factory-PipeTrackRenderFragment-__AOT_FOR_FIX__0 = 417,
		Beyond-Gameplay-Factory-ComplexPortFragment-BindComponentId0 = 418,
		Beyond-Gameplay-Factory-ComplexPortFragment-BlockPortsWithComponentId0 = 419,
		Beyond-Gameplay-Factory-ComplexPortFragment-BlockPorts0 = 420,
		Beyond-Gameplay-Factory-ComplexPortFragment-FollowUnit0 = 421,
		Beyond-Gameplay-Factory-ComplexPortFragment-AnyPortBlocked0 = 422,
		Beyond-Gameplay-Factory-ComplexPortFragment-AnyPortConnected0 = 423,
		Beyond-Gameplay-Factory-ComplexPortFragment-Equals0 = 424,
		Beyond-Gameplay-Factory-PortData-Equals0 = 425,
		Beyond-Gameplay-Factory-ComplexPortFragment-Equals1 = 426,
		Beyond-Gameplay-Factory-ComplexPortFragment-GetHashCode0 = 427,
		Beyond-Gameplay-Factory-ComplexPortFragment-op_Equality0 = 428,
		Beyond-Gameplay-Factory-ComplexPortFragment-op_Inequality0 = 429,
		Beyond-Gameplay-Factory-ComplexPortFragment-ToString0 = 430,
		Beyond-Gameplay-Factory-PortData-ToString0 = 431,
		Beyond-Gameplay-Factory-ComplexPortFragment-__AOT_FOR_FIX__0 = 432,
		Beyond-Gameplay-Factory-PortData-TRS0 = 433,
		Beyond-Gameplay-Factory-PortData-Equals1 = 434,
		Beyond-Gameplay-Factory-PortData-GetHashCode0 = 435,
		Beyond-Gameplay-Factory-PortData-op_Equality0 = 436,
		Beyond-Gameplay-Factory-PortData-op_Inequality0 = 437,
		Beyond-Gameplay-Factory-PortPreviewUIRendererFragment-__AOT_FOR_FIX__0 = 438,
		Beyond-Gameplay-Factory-PortStatusUIFragment-__AOT_FOR_FIX__0 = 439,
		Beyond-Gameplay-Factory-PowerPoleFragment-__AOT_FOR_FIX__0 = 440,
		Beyond-Gameplay-Factory-ProducerFragment-__AOT_FOR_FIX__0 = 441,
		Beyond-Gameplay-Factory-SharedDataFragment-GetExtData0 = 442,
		Beyond-Gameplay-Factory-SharedDataFragment-DestroyData0 = 443,
		Beyond-Gameplay-Factory-SharedDataFragment-__AOT_FOR_FIX__0 = 444,
		Beyond-Gameplay-Factory-SocialFragment-Create0 = 445,
		Beyond-Gameplay-Factory-SocialFragment-IsHighLiked0 = 446,
		Beyond-Gameplay-Factory-SocialFragment-IsLiked0 = 447,
		Beyond-Gameplay-Factory-SocialFragment-__AOT_FOR_FIX__0 = 448,
		Beyond-Gameplay-Factory-SignData-GetText0 = 449,
		Beyond-Gameplay-Factory-SignData-GetCustomPerDrawData0 = 450,
		Beyond-Gameplay-Factory-SignData-SetSignBuildingIcon0 = 451,
		Beyond-Gameplay-Factory-SignData-SetSignBuildingIconWithRenderEntity0 = 452,
		Beyond-Gameplay-Factory-LocalTransform-FromMatrix0 = 453,
		Beyond-Gameplay-Factory-LocalTransform-FromMatrixSafe0 = 454,
		Beyond-Gameplay-Factory-LocalTransform-FromPositionRotation0 = 455,
		Beyond-Gameplay-Factory-LocalTransform-FromPositionRotationScale0 = 456,
		Beyond-Gameplay-Factory-LocalTransform-FromPosition0 = 457,
		Beyond-Gameplay-Factory-LocalTransform-FromPosition1 = 458,
		Beyond-Gameplay-Factory-LocalTransform-FromRotation0 = 459,
		Beyond-Gameplay-Factory-LocalTransform-FromScale0 = 460,
		Beyond-Gameplay-Factory-LocalTransform-ToString0 = 461,
		Beyond-Gameplay-Factory-LocalTransform-Right0 = 462,
		Beyond-Gameplay-Factory-LocalTransform-TransformDirection0 = 463,
		Beyond-Gameplay-Factory-LocalTransform-Up0 = 464,
		Beyond-Gameplay-Factory-LocalTransform-Forward0 = 465,
		Beyond-Gameplay-Factory-LocalTransform-TransformPoint0 = 466,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformPoint0 = 467,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformDirection0 = 468,
		Beyond-Gameplay-Factory-LocalTransform-TransformRotation0 = 469,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformRotation0 = 470,
		Beyond-Gameplay-Factory-LocalTransform-TransformScale0 = 471,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformScale0 = 472,
		Beyond-Gameplay-Factory-LocalTransform-TransformTransform0 = 473,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformTransform0 = 474,
		Beyond-Gameplay-Factory-LocalTransform-Inverse0 = 475,
		Beyond-Gameplay-Factory-LocalTransform-ToInverseMatrix0 = 476,
		Beyond-Gameplay-Factory-LocalTransform-WithPosition0 = 477,
		Beyond-Gameplay-Factory-LocalTransform-WithPosition1 = 478,
		Beyond-Gameplay-Factory-LocalTransform-WithRotation0 = 479,
		Beyond-Gameplay-Factory-LocalTransform-WithScale0 = 480,
		Beyond-Gameplay-Factory-LocalTransform-Translate0 = 481,
		Beyond-Gameplay-Factory-LocalTransform-ApplyScale0 = 482,
		Beyond-Gameplay-Factory-LocalTransform-Rotate0 = 483,
		Beyond-Gameplay-Factory-LocalTransform-RotateX0 = 484,
		Beyond-Gameplay-Factory-LocalTransform-RotateY0 = 485,
		Beyond-Gameplay-Factory-LocalTransform-RotateZ0 = 486,
		Beyond-Gameplay-Factory-LocalTransform-Equals0 = 487,
		Beyond-Gameplay-Factory-LocalTransform-__AOT_FOR_FIX__0 = 488,
		Beyond-Gameplay-Factory-Root-__AOT_FOR_FIX__0 = 489,
		Beyond-Gameplay-Factory-Parent-__AOT_FOR_FIX__0 = 490,
		Beyond-Gameplay-Factory-Child-__AOT_FOR_FIX__0 = 491,
		Beyond-Gameplay-Factory-LocalToWorld-SetValue0 = 492,
		Beyond-Gameplay-Factory-LocalToWorld-get_right0 = 493,
		Beyond-Gameplay-Factory-LocalToWorld-get_up0 = 494,
		Beyond-Gameplay-Factory-LocalToWorld-get_forward0 = 495,
		Beyond-Gameplay-Factory-LocalToWorld-get_position0 = 496,
		Beyond-Gameplay-Factory-LocalToWorld-get_prePosition0 = 497,
		Beyond-Gameplay-Factory-LocalToWorld-__AOT_FOR_FIX__0 = 498,
		Beyond-Gameplay-Factory-UdPipeFragment-__AOT_FOR_FIX__0 = 499,
		Beyond-Gameplay-Factory-UnitConfigFragment-__AOT_FOR_FIX__0 = 500,
		Beyond-Gameplay-Factory-FactoryUnitExtendConfig-ToString0 = 501,
		Beyond-Gameplay-Factory-UnitInteractFragment-__AOT_FOR_FIX__0 = 504,
		Beyond-Gameplay-Factory-UnitRenderFragment-__AOT_FOR_FIX__0 = 505,
		Beyond-Gameplay-Factory-RenderLookAtFragment-__AOT_FOR_FIX__0 = 506,
		Beyond-Gameplay-Factory-ChapterTagFragment-__AOT_FOR_FIX__0 = 507,
		Beyond-Gameplay-Factory-UnitStatusFragment-__AOT_FOR_FIX__0 = 508,
		Beyond-Gameplay-Factory-UnitOverrideStatusFragment-__AOT_FOR_FIX__0 = 509,
		Beyond-Gameplay-Factory-UnitStatusEffectFragment-SetEffects0 = 510,
		Beyond-Gameplay-Factory-UnitStatusEffectFragment-GetEffect0 = 511,
		Beyond-Gameplay-Factory-UnitStatusEffectFragment-__AOT_FOR_FIX__0 = 512,
		Beyond-Gameplay-Factory-UnitStatusUIRendererFragment-__AOT_FOR_FIX__0 = 513,
		Beyond-Gameplay-Factory-UnitTransFragment-InBound0 = 514,
		Beyond-Gameplay-Factory-UnitTransFragment-__AOT_FOR_FIX__0 = 515,
		Beyond-Gameplay-Factory-ValveFragment-__AOT_FOR_FIX__0 = 516,
		Beyond-Gameplay-Factory-BoxValve-__AOT_FOR_FIX__0 = 517,
		Beyond-Gameplay-Factory-FluidValve-__AOT_FOR_FIX__0 = 518,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-ContainsNodeId0 = 519,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetExtData0 = 520,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-RemoveEntityFromSlot0 = 521,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-FindEmptySlotIdx0 = 522,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSuitableSlotIdx0 = 523,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-SetSlotId0 = 524,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSlotIds0 = 525,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-AppendSlotInfo0 = 526,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-ClearSlotInfo0 = 527,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-DiffSlotInfo0 = 528,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetAllPendingEntitiesInSlot0 = 529,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetPendingEntityCountInSlot0 = 530,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSlotInfo0 = 531,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-CreateDefault0 = 532,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-ToString0 = 533,
		Beyond-Gameplay-Factory-ConveyorRendererInfo-ToString0 = 534,
		Beyond-Gameplay-Factory-UnitId-Equals0 = 535,
		Beyond-Gameplay-Factory-UnitId-Equals1 = 536,
		Beyond-Gameplay-Factory-UnitId-GetHashCode0 = 537,
		Beyond-Gameplay-Factory-Visibility-get_isVisible0 = 538,
		Beyond-Gameplay-Factory-Visibility-GetVisible0 = 539,
		Beyond-Gameplay-Factory-Visibility-SetVisible0 = 540,
		Beyond-Gameplay-Factory-WireRendererFragment-__AOT_FOR_FIX__0 = 541,
		Beyond-Gameplay-Factory-GlobalSharedData-Reset0 = 542,
		Beyond-Gameplay-Factory-GlobalSharedData-MapGridRendererData-Reset0 = 543,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-ResetOverride0 = 544,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrCullDis0 = 545,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrUI0 = 546,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrBuildingName0 = 547,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrWireCullDis0 = 548,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-ResetOverride0 = 549,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-Disable0 = 550,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_nearByCheck0 = 551,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_portPreviewCheckDistance0 = 552,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_pedestalFlashCheckDistance0 = 553,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_logisticEffectCheckDistance0 = 554,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_unitRendererCheckDistance0 = 555,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_l2wCheckDistance0 = 556,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_additiveEffectCheckDistance0 = 557,
		Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-Disable0 = 558,
		Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-ResetOverride0 = 559,
		Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-get_buildingNameShadowDisable0 = 560,
		Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetBuildCurve0 = 561,
		Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetRepairCurve00 = 562,
		Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetRepairCurve10 = 563,
		Beyond-Gameplay-Factory-GlobalSharedData-MapGridRendererData-UpdateGrid0 = 564,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Initialize0 = 565,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Dispose0 = 566,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-EnsureValue0 = 567,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-TryGetValue1 = 568,
		Beyond-Gameplay-Factory-StringIntern-FastId-op_Implicit1 = 569,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-TryGetValue0 = 570,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_CreateWithTable0 = 571,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_ParseGlobalPortIdx0 = 573,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Add1 = 575,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Add0 = 576,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-EnsureValue1 = 577,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_CreateWithTable1 = 578,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-ContainsKey0 = 579,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Clear0 = 580,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-Apply0 = 581,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-_GetKey0 = 582,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-ApplyPass0 = 583,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-Parse0 = 584,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-set_Item0 = 585,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-set_Item0 = 586,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-GetPerDrawPassConfig0 = 587,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-get_Item0 = 588,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-GetPerDrawConfig0 = 589,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-get_Item0 = 590,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-Disable0 = 591,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-ResetOverride0 = 592,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_crossCollectFrameInterval0 = 593,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_cullingSystemInterval0 = 594,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_unitPreviewSystemInterval0 = 595,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_portPreviewRenderSystemInterval0 = 596,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_buildingStateSystemInterval0 = 597,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_portBlockSystemInterval0 = 598,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_outputUISystemInterval0 = 599,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_buildingNameSystemInterval0 = 600,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_adjustGroundSystemInterval0 = 601,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_gridSystemInterval0 = 602,
		Beyond-Gameplay-Factory-GlobalSharedData-UIEffectPathConfig-Parse0 = 603,
		Beyond-Gameplay-Factory-GlobalSharedData-UIEffectPathConfig-Get0 = 604,
		Beyond-Gameplay-Factory-BaseProcessor-Initialize0 = 605,
		Beyond-Gameplay-Factory-BaseProcessor-PreExecute0 = 606,
		Beyond-Gameplay-Factory-BaseProcessor-Execute0 = 607,
		Beyond-Gameplay-Factory-BaseProcessor-LateExecute0 = 608,
		Beyond-Gameplay-Factory-BaseProcessor-CleanUp0 = 609,
		Beyond-Gameplay-Factory-BaseProcessor-TearDown0 = 610,
		Beyond-Gameplay-Factory-BaseProcessor-StructuralSync0 = 611,
		Beyond-Gameplay-Factory-BaseProcessor-ScheduleNoneDependencies0 = 612,
		Beyond-Gameplay-Factory-BaseProcessor-InLowFrameMode0 = 613,
		Beyond-Gameplay-Factory-BaseProcessor-SpecialEntityExisted0 = 614,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetApplyRenderPointer0 = 615,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetFacRegionValid0 = 616,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetQueryStateIconPathFuncPtr0 = 617,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetLogicEntityWithPosAdapter0 = 618,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetQueryBuildingStatePointer0 = 619,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetSetEntityFlashStatuePointer0 = 620,
		Beyond-Gameplay-Factory-AdditiveEffectJob-SetSharedExtData0 = 621,
		Beyond-Gameplay-Factory-AdditiveEffectJob-Execute1 = 622,
		Beyond-Gameplay-Factory-AdditiveEffectJob-Execute0 = 623,
		Beyond-Gameplay-Factory-AdditiveEffectJob-_OnStackEmpty0 = 624,
		Beyond-Gameplay-Factory-AdditiveEffectJob-_UpdateInternalStateLifeCycle0 = 625,
		Beyond-Gameplay-Factory-AdditiveEffectJob-_InitBuildState0 = 626,
		Beyond-Gameplay-Factory-AdditiveEffectJob-SetQueryResult0 = 627,
		Beyond-Gameplay-Factory-AdditiveEffectJob-ScheduleDefer0 = 628,
		Beyond-Gameplay-Factory-AdditiveEffectJob-ScheduleDefer1 = 629,
		Beyond-Gameplay-Factory-AdditiveEffectQueryJob-Execute0 = 630,
		Beyond-Gameplay-Factory-AdditiveEffectQueryJob-SetQueryResult0 = 631,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPNormalEffectExecute0 = 632,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPBuildEffectExecute0 = 633,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPBuildCutoffEffectExecute0 = 634,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-SetSharedExtData0 = 636,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-Execute1 = 637,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-Execute0 = 638,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BuildStateStart0 = 639,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ResetMaterial0 = 640,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BuildStateEnd0 = 641,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_Repair0Start0 = 642,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_Repair0End0 = 643,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-SetQueryResult0 = 644,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ScheduleDefer0 = 645,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ScheduleDefer1 = 646,
		Beyond-Gameplay-Factory-AudioJobs-AudioDistanceAndCullingJob-Execute0 = 647,
		Beyond-Gameplay-Factory-AudioJobs-AudioGroupEmitterJob-Execute0 = 648,
		Beyond-Gameplay-Factory-AudioJobs-AudioGroupEmitterJob-SetSharedExtData0 = 649,
		Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-Execute0 = 650,
		Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-_DoCalculate0 = 651,
		Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-SetGlobalEnv0 = 652,
		Beyond-Gameplay-Factory-BatchArrowJob-_ExecutePort0 = 653,
		Beyond-Gameplay-Factory-BatchArrowJob-_BatchPortArrow0 = 654,
		Beyond-Gameplay-Factory-BatchArrowJob-_ExecutePreview0 = 655,
		Beyond-Gameplay-Factory-BatchArrowJob-Execute0 = 656,
		Beyond-Gameplay-Factory-BatchArrowJob-SetSharedExtData0 = 657,
		Beyond-Gameplay-Factory-BatchArrowJob-Execute1 = 658,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-Execute0 = 659,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-_CollectInsideConveyor0 = 660,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-_BatchPortInside0 = 661,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-SetSharedExtData0 = 662,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-Execute1 = 663,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-_ExecutePort0 = 664,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-_BatchPortArrow0 = 665,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-Execute0 = 666,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-Execute1 = 667,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-SetSharedExtData0 = 668,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-Execute0 = 669,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-_ExecutePreview0 = 670,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-_BatchPortArrow0 = 671,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-SetSharedExtData0 = 672,
		Beyond-Gameplay-Factory-BufferSwapJob-Execute0 = 673,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-Execute0 = 674,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-_ApplyLiquidPerDraw0 = 675,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-Execute1 = 676,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-SetQueryResult0 = 677,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-ScheduleDefer0 = 678,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-SetSharedExtData0 = 679,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute0 = 680,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-_Collect0 = 681,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute1 = 682,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute2 = 683,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-SetSharedExtData0 = 684,
		Beyond-Gameplay-Factory-BuildingStateRendererJob-Execute0 = 685,
		Beyond-Gameplay-Factory-CargoCollectJob-Execute0 = 686,
		Beyond-Gameplay-Factory-CargoCollectJob-Execute1 = 687,
		Beyond-Gameplay-Factory-CargoCollectJob-SetGlobalEnvRef0 = 688,
		Beyond-Gameplay-Factory-CargoCollectJob-SetConveyorExtData0 = 689,
		Beyond-Gameplay-Factory-CargoCollectJob-SetSharedExtData0 = 690,
		Beyond-Gameplay-Factory-CargoPredictJob-Execute0 = 691,
		Beyond-Gameplay-Factory-CargoPredictJob-SetConveyorExtData0 = 692,
		Beyond-Gameplay-Factory-CargoPredictJob-SetSharedExtData0 = 693,
		Beyond-Gameplay-Factory-CargoPredictJob-SetQueryResult0 = 694,
		Beyond-Gameplay-Factory-CargoPredictJob-ScheduleDefer0 = 695,
		Beyond-Gameplay-Factory-CargoPredictQueryJob-Execute0 = 696,
		Beyond-Gameplay-Factory-CargoPredictQueryJob-SetQueryResult0 = 697,
		Beyond-Gameplay-Factory-CargoRenderJob-Execute0 = 698,
		Beyond-Gameplay-Factory-CargoRenderJob-SetRendererList0 = 699,
		Beyond-Gameplay-Factory-CargoRenderQueryJob-Execute0 = 700,
		Beyond-Gameplay-Factory-CargoRenderQueryJob-SetQueryResult0 = 701,
		Beyond-Gameplay-Factory-ConveyorCollectJob-Execute0 = 702,
		Beyond-Gameplay-Factory-ConveyorCollectJob-_Collect0 = 703,
		Beyond-Gameplay-Factory-ConveyorCollectJob-Execute1 = 704,
		Beyond-Gameplay-Factory-ConveyorCollectJob-Execute2 = 705,
		Beyond-Gameplay-Factory-ConveyorCollectJob-SetSharedExtData0 = 706,
		Beyond-Gameplay-Factory-ConveyorFigureRendererJob-Execute0 = 707,
		Beyond-Gameplay-Factory-ConveyorFigureRendererJob-Execute1 = 708,
		Beyond-Gameplay-Factory-ConveyorFigureRendererJob-SetSharedExtData0 = 709,
		Beyond-Gameplay-Factory-ConveyorInsideRenderJob-Execute0 = 710,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-Execute0 = 711,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-_Collect0 = 712,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-Execute1 = 713,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-SetSharedExtData0 = 714,
		Beyond-Gameplay-Factory-ConveyorRendererJob-Execute0 = 715,
		Beyond-Gameplay-Factory-ConveyorRendererJob-_UpdateCachedConveyor0 = 716,
		Beyond-Gameplay-Factory-ConveyorRendererJob-Execute1 = 717,
		Beyond-Gameplay-Factory-ConveyorRendererJob-SetSharedExtData0 = 718,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_SwapBuffer0 = 719,
		Beyond-Gameplay-Factory-InteractFacCollectJob-Execute0 = 720,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecuteBuilding0 = 721,
		Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-IsPointInSector0 = 723,
		Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-SetData0 = 724,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecuteConveyor0 = 725,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_CheckDist0 = 726,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_SnapDirectionToAxis0 = 727,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecutePipe0 = 728,
		Beyond-Gameplay-Factory-InteractFacCollectJob-SetSharedExtData0 = 729,
		Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-ToString0 = 730,
		Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-IsPending0 = 731,
		Beyond-Gameplay-Factory-InteractFacCollectJob-LogisticInfo-IsPending0 = 732,
		Beyond-Gameplay-Factory-LocalToWorldJob-Execute0 = 733,
		Beyond-Gameplay-Factory-LocalToWorldJob-TransTRS0 = 734,
		Beyond-Gameplay-Factory-LocalToWorldJob-Execute1 = 735,
		Beyond-Gameplay-Factory-LocalToWorldJob-SetHierarchyData0 = 736,
		Beyond-Gameplay-Factory-LocalToWorldJob-SetQueryResult0 = 737,
		Beyond-Gameplay-Factory-LocalToWorldJob-ScheduleDefer0 = 738,
		Beyond-Gameplay-Factory-LocalToWorldQueryJob-Execute0 = 739,
		Beyond-Gameplay-Factory-LocalToWorldQueryJob-SetQueryResult0 = 740,
		Beyond-Gameplay-Factory-LogisticEffectJob-Execute0 = 741,
		Beyond-Gameplay-Factory-LookAtJob-Execute0 = 742,
		Beyond-Gameplay-Factory-LookAtJob-SetHierarchyData0 = 743,
		Beyond-Gameplay-Factory-LookAtJob-SetQueryResult0 = 744,
		Beyond-Gameplay-Factory-LookAtJob-ScheduleDefer0 = 745,
		Beyond-Gameplay-Factory-LookAtQueryJob-Execute0 = 746,
		Beyond-Gameplay-Factory-LookAtQueryJob-SetQueryResult0 = 747,
		Beyond-Gameplay-Factory-OutputCollectJob-Execute0 = 748,
		Beyond-Gameplay-Factory-OutputCollectJob-_Collect0 = 749,
		Beyond-Gameplay-Factory-OutputCollectJob-Execute1 = 750,
		Beyond-Gameplay-Factory-OutputCollectJob-Execute2 = 751,
		Beyond-Gameplay-Factory-OutputCollectJob-SetSharedExtData0 = 752,
		Beyond-Gameplay-Factory-OutputRenderJob-Execute0 = 753,
		Beyond-Gameplay-Factory-PedestalFlashJob-Execute0 = 754,
		Beyond-Gameplay-Factory-PedestalFlashJob-_Flash0 = 755,
		Beyond-Gameplay-Factory-PedestalFlashJob-Execute1 = 756,
		Beyond-Gameplay-Factory-PedestalFlashJob-SetSharedExtData0 = 757,
		Beyond-Gameplay-Factory-PipeCollectJob-Execute0 = 758,
		Beyond-Gameplay-Factory-PipeCollectJob-_ExecutePipe0 = 759,
		Beyond-Gameplay-Factory-PipeCollectJob-_CollectPipe0 = 760,
		Beyond-Gameplay-Factory-PipeCollectJob-_CollectPipeCom0 = 761,
		Beyond-Gameplay-Factory-PipeCollectJob-_ExecutePreviewPipe0 = 762,
		Beyond-Gameplay-Factory-PipeCollectJob-_CollectTrack0 = 763,
		Beyond-Gameplay-Factory-PipeCollectJob-Execute1 = 764,
		Beyond-Gameplay-Factory-PipeCollectJob-Execute2 = 765,
		Beyond-Gameplay-Factory-PipeCollectJob-SetGlobalEnvRef0 = 766,
		Beyond-Gameplay-Factory-PipeCollectJob-SetSharedExtData0 = 767,
		Beyond-Gameplay-Factory-PipeComRendererJob-Execute0 = 768,
		Beyond-Gameplay-Factory-PipeFigureRendererJob-Execute0 = 769,
		Beyond-Gameplay-Factory-PipeFigureRendererJob-_UpdateCachedPipe0 = 770,
		Beyond-Gameplay-Factory-PipeFigureRendererJob-Execute1 = 771,
		Beyond-Gameplay-Factory-PipeHolderFigureRendererJob-Execute0 = 772,
		Beyond-Gameplay-Factory-PipeHolderFigureRendererJob-Execute1 = 773,
		Beyond-Gameplay-Factory-PipeHolderHideRendererJob-Execute0 = 774,
		Beyond-Gameplay-Factory-PipeHolderHideRendererJob-Execute1 = 775,
		Beyond-Gameplay-Factory-PipeHolderHideRendererJob-SetSharedExtData0 = 776,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute0 = 777,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute1 = 778,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-SetSharedExtData0 = 779,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute2 = 780,
		Beyond-Gameplay-Factory-PipeRendererJob-Execute0 = 781,
		Beyond-Gameplay-Factory-PipeRendererJob-_UpdateCachedPipe0 = 782,
		Beyond-Gameplay-Factory-PipeRendererJob-SetSharedExtData0 = 783,
		Beyond-Gameplay-Factory-PipeTrackRendererJob-Execute0 = 784,
		Beyond-Gameplay-Factory-PipeTrackRendererJob-_UpdateCachedTrack0 = 785,
		Beyond-Gameplay-Factory-PipeWaterThicknessQueryJob-Execute0 = 786,
		Beyond-Gameplay-Factory-PipeWaterThicknessQueryJob-SetQueryResult0 = 787,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-Execute1 = 788,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-Execute0 = 789,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-SetGlobalEnv0 = 790,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-SetQueryResult0 = 791,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-ScheduleDefer0 = 792,
		Beyond-Gameplay-Factory-PortArrowRenderJob-Execute0 = 793,
		Beyond-Gameplay-Factory-PortStateCollectJob-Execute0 = 794,
		Beyond-Gameplay-Factory-PortStateCollectJob-_Collect0 = 795,
		Beyond-Gameplay-Factory-PortStateCollectJob-SetSharedExtData0 = 796,
		Beyond-Gameplay-Factory-PortStateCollectJob-Execute1 = 797,
		Beyond-Gameplay-Factory-PortStateCollectJob-Execute2 = 798,
		Beyond-Gameplay-Factory-PortStateRendererJob-Execute0 = 799,
		Beyond-Gameplay-Factory-PreviewUnitQueryJob-Execute0 = 800,
		Beyond-Gameplay-Factory-PreviewUnitQueryJob-SetQueryResult0 = 801,
		Beyond-Gameplay-Factory-PumpInEffectJob-Execute0 = 802,
		Beyond-Gameplay-Factory-PumpInEffectJob-Execute1 = 803,
		Beyond-Gameplay-Factory-PumpInEffectJob-SetQueryResult0 = 804,
		Beyond-Gameplay-Factory-PumpInEffectJob-ScheduleDefer0 = 805,
		Beyond-Gameplay-Factory-PumpInEffectJob-SetSharedExtData0 = 806,
		Beyond-Gameplay-Factory-StatusChangeJob-Execute0 = 807,
		Beyond-Gameplay-Factory-UnitCullingJob-Execute1 = 808,
		Beyond-Gameplay-Factory-UnitCullingJob-Execute0 = 809,
		Beyond-Gameplay-Factory-UnitCullingJob-SetGlobalEnvRef0 = 810,
		Beyond-Gameplay-Factory-UnitCullingJob-SetSharedExtData0 = 811,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-Execute1 = 812,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-Execute0 = 813,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetGlobalEnvRef0 = 814,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetSharedExtData0 = 815,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetQueryResult0 = 816,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-ScheduleDefer0 = 817,
		Beyond-Gameplay-Factory-UnitRendererQueryJob-Execute0 = 818,
		Beyond-Gameplay-Factory-UnitRendererQueryJob-SetQueryResult0 = 819,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-Execute0 = 820,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-Execute1 = 821,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-SetSharedExtData0 = 822,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-SetQueryResult0 = 823,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-ScheduleDefer0 = 824,
		Beyond-Gameplay-Factory-WireCollectJob-Execute0 = 825,
		Beyond-Gameplay-Factory-WireCollectJob-Execute1 = 826,
		Beyond-Gameplay-Factory-WireCollectJob-SetGlobalEnvRef0 = 827,
		Beyond-Gameplay-Factory-WireCollectJob-SetSharedExtData0 = 828,
		Beyond-Gameplay-Factory-WireRenderJob-Execute0 = 829,
		Beyond-Gameplay-Factory-WireRenderJob-_UpdateCachedWire0 = 830,
		Beyond-Gameplay-Factory-WireRenderJob-Execute1 = 831,
		Beyond-Gameplay-Factory-FPtrNativeCurve-IsValid0 = 832,
		Beyond-Gameplay-Factory-FPtrNativeCurve-CreateCurve0 = 833,
		Beyond-Gameplay-Factory-FPtrNativeCurve-Evaluate0 = 834,
		Beyond-Gameplay-Factory-StringIntern-FastId-Equals0 = 835,
		Beyond-Gameplay-Factory-StringIntern-FastId-Equals1 = 836,
		Beyond-Gameplay-Factory-StringIntern-FastId-GetHashCode0 = 837,
		Beyond-Gameplay-Factory-StringIntern-StringTable-GetOrAddIndex0 = 838,
		Beyond-Gameplay-Factory-StringIntern-StringTable-TryGetIndex0 = 839,
		Beyond-Gameplay-Factory-StringIntern-StringTable-IndexToString0 = 840,
		Beyond-Gameplay-Factory-PerDrawPassConfig-Size0 = 841,
		Beyond-Gameplay-Factory-PerDrawPassConfig-Apply0 = 842,
		Beyond-Gameplay-Factory-PerDrawPassConfig-_ParseToHGShaderLightMode0 = 843,
		Beyond-Gameplay-Factory-PerDrawPassConfig-Apply1 = 844,
		Beyond-Gameplay-Factory-PerDrawConfig-Size0 = 845,
		Beyond-Gameplay-Factory-PerDrawConfig-_OnColorChanged0 = 846,
		Beyond-Gameplay-Factory-PerDrawConfig-_OnFloat4Changed0 = 847,
		Beyond-Gameplay-Factory-PerDrawConfig-_OnFloatChanged0 = 848,
		Beyond-Gameplay-Factory-PerDrawConfig-Apply0 = 849,
		Beyond-Gameplay-Factory-ProcessorInterval-CheckInterval0 = 850,
		Beyond-Gameplay-Factory-ProcessorInterval-_CheckInterval0 = 851,
		Beyond-Gameplay-Factory-CargoPredictProcessor-Execute0 = 852,
		Beyond-Gameplay-Factory-CrossFrameProcessor-Initialize0 = 853,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearBuildingPtr0 = 854,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearConveyorPtr0 = 855,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearPipePtr0 = 856,
		Beyond-Gameplay-Factory-CrossFrameProcessor-LateExecute0 = 857,
		Beyond-Gameplay-Factory-CrossFrameProcessor-TearDown0 = 858,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectConveyor0 = 859,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPreviewConveyor0 = 860,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectGuideConveyor0 = 861,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-Initialize0 = 862,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetStateColor0 = 863,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CreateCurrent0 = 864,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CreateAllocator0 = 865,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_InitArrowPlaced0 = 866,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortState0 = 867,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectBuildingState0 = 868,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectOutput0 = 869,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectCargo0 = 870,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectWire0 = 871,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-LateExecute0 = 872,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPipe0 = 873,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPipeLogistics0 = 874,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortArrowWithDiff0 = 875,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortArrow0 = 876,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-TearDown0 = 877,
		Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-GetColor0 = 878,
		Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-GetIndex0 = 879,
		Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-CreateOrGet0 = 880,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetIndicatorColor0 = 881,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetStateName0 = 882,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetPerDrawList0 = 883,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-LogicStateConfig-_OnColorChanged0 = 884,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-Init0 = 885,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetParametersByDef0 = 886,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetFloat0 = 887,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetInt0 = 888,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetBool0 = 889,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetAllTriggers0 = 890,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Enter0 = 891,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetState0 = 892,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Exit0 = 893,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-ToNextState0 = 894,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Exit0 = 895,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetTransition0 = 896,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Enter0 = 897,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-__AOT_FOR_FIX__0 = 898,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-get_process0 = 899,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Update0 = 900,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-SetProgress0 = 901,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-get_fromStateWeight0 = 902,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Update0 = 903,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetFloat0 = 904,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetInt0 = 905,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetBool0 = 906,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetTrigger0 = 907,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetTrigger0 = 908,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetTrigger0 = 909,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetValue0 = 910,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetValue0 = 911,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMSetParamRequestHandlerJob-Execute0 = 912,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-Execute1 = 913,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-Execute0 = 914,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_CheckTransitions0 = 915,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-TryGetValidTransition0 = 916,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-_Evaluate0 = 917,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-ResetUsedTriggers0 = 918,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_AddVATAudioData0 = 919,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_ComputeVATFrameData0 = 920,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-SetSharedExtData0 = 921,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-Initialize0 = 922,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-Initialize0 = 923,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-Execute0 = 924,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-_RemoveDuplicationRequest0 = 925,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-_HandleSetAnimatorParamRequest0 = 926,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-TearDown0 = 927,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-Dispose0 = 928,
		Beyond-Gameplay-Factory-ECSVATFSM-AnimationClipData-GetClipDesStr0 = 929,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Size0 = 930,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-AsSpan0 = 931,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Reserve0 = 932,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Get0 = 933,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Get1 = 934,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-InitFSMDefinition0 = 935,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-RegisterFSM0 = 936,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-GetStateName0 = 937,
		Beyond-Gameplay-Factory-Util-JobHandlerExtensions-SafeComplete0 = 938,
		Beyond-Gameplay-Factory-Unsafe-BurstBridge-BeginProfilerSample0 = 939,
		Beyond-Gameplay-Factory-Unsafe-BurstBridge-EndProfilerSample0 = 940,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-QueryBuildingStateIsClosed0 = 941,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-_IsPowerBuilding0 = 942,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-CulledWithLogicEntity0 = 943,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-CulledWithRendererEntity0 = 944,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetVisibility1 = 945,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetVisibility0 = 946,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibility0 = 947,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibilityWithNotify0 = 948,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-UpdatePipeEffect0 = 949,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibility1 = 950,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetInMainRegion0 = 952,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-IsInMainRegionFuzzy0 = 953,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-UpdatePipeEffect1 = 954,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingExtendConfig0 = 955,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingStaticMountWorldTRS1 = 956,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingStaticMountWorldTRS0 = 957,
		Beyond-Gameplay-Factory-Unsafe-GameplayExtensions-GetChapterEntity0 = 958,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetGlobalEnvPtr0 = 959,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-IsGlobalEnvValid0 = 960,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetGlobalEnvRef0 = 961,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractFac0 = 962,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractConveyor0 = 963,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractPipe0 = 964,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-_ExpandMemory0 = 965,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-_MergeAdjacentFreeBlocks0 = 967,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Allocate0 = 968,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Reserve0 = 975,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Expand0 = 976,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Free0 = 977,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Resize0 = 978,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Dispose0 = 979,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-PrintAllocations0 = 980,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Initialize0 = 981,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Dispose0 = 983,
		Beyond-Gameplay-Factory-Unsafe-TLSFAllocator-GetFreeSpace0 = 984,
		Beyond-Gameplay-Factory-Unsafe-TLSFAllocator-MappingInsert0 = 985,
		Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-AllocManualNodeId0 = 986,
		Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-AddressOf0 = 987
	}
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 49462
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 49463
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.HyperGryph.ECS
{
	public static class ColliderComponentExtensions // TypeDefIndex: 49468
	{
		// Nested types
		private struct __c__DisplayClass0_0 // TypeDefIndex: 49467
		{
			// Fields
			public bool enable; // 0x00
		}
	
		// Methods
		public static void ToggleCollision(Entity logicEntity, bool enable, ref EntityManager em) {} // 0x00000001843F0450-0x00000001843F0980
		public static void Toggle(ref ECSColliderComponent collision, bool enable) {} // 0x0000000184FF6E90-0x0000000184FF6F00
		public static void UpdateCollisionTRS(Entity logicEntity, in EntityManager em) {} // 0x00000001843F1D70-0x00000001843F22A0
		public static void UpdateCollisionTRS(ECSColliderComponent c, float3 pos, quaternion rot) {} // 0x000000018459C810-0x000000018459C910
		public static void DestroyCollisionWithRenderEntity(Entity rEntity, ref EntityManager em) {} // 0x000000018479E730-0x000000018479E800
		public static void DestroyCollision(Entity logicEntity, ref EntityManager em) {} // 0x000000018793EBA0-0x000000018793EEF8
		internal static void _ToggleCollision_g__Toggle_0_0(Entity rendererEntity, ref EntityManager em, ref __c__DisplayClass0_0 param_00067ffd) {} // 0x0000000184FF6D70-0x0000000184FF6E90
		internal static void _UpdateCollisionTRS_g__UpdateTRS_2_0(Entity rendererEntity, in EntityManager em) {} // 0x000000018459C910-0x000000018459CC40
	}

	public static class ECSExtensions // TypeDefIndex: 49469
	{
		// Methods
		public static Entity GetEntity(GroupType group, int index) => default; // 0x00000001840BF9E0-0x00000001840BFA00
		public static bool HasComponent(in EntityManager entityManager, in Entity entity, int componentId) => default; // 0x00000001841368E0-0x0000000184136920
		public static void CreateEntities(in EntityManager em, NativeArray<ComponentType> archetypes, NativeArray<Entity> result) {} // 0x00000001847E78E0-0x00000001847E7930
		public static Entity CreateEntity(in EntityManager entityManager) => default; // 0x00000001840BDA60-0x00000001840BDB30
		public static Entity CreateEntity(in EntityManager entityManager, NativeArray<ComponentType> archetypes) => default; // 0x0000000184795DF0-0x0000000184795EA0
		public static void Is<T>(in EntityManager entityManager, Entity entity, bool flag)
			where T : struct, IComponentECS {}
		public static void AddComponent<T>(in EntityManager entityManager, Entity entity)
			where T : struct, IComponentECS {}
		public static void AddComponent(in EntityManager entityManager, Entity entity, int componentId, in IntPtr component, int componentSize) {} // 0x00000001840BCAE0-0x00000001840BCF20
		public static void AddOrSetComponent<T>(in EntityManager entityManager, Entity entity, T t)
			where T : struct, IComponentECS {}
		public static void AddOrSetComponent<T1, T2>(in EntityManager entityManager, Entity entity, T1 t1, T2 t2)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS {}
		public static void SetComponent(in EntityManager entityManager, Entity entity, int componentId, in IntPtr component, int componentSize) {} // 0x00000001840BABF0-0x00000001840BAC20
		public static void SetComponents<T0, T1, T2>(in EntityManager entityManager, in Entity entity, in ref T0 t0, in ref T1 t1, in ref T2 t2)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS {}
		public static void SetComponents<T0, T1, T2, T3>(in EntityManager entityManager, in Entity entity, in ref T0 t0, in ref T1 t1, in ref T2 t2, in ref T3 t3)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS {}
		public static void SetComponents<T0, T1, T2, T3, T4>(in EntityManager entityManager, in Entity entity, in ref T0 t0, in ref T1 t1, in ref T2 t2, in ref T3 t3, in ref T4 t4)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS {}
		private static void _SetComponentImpl(ref EntityInstanceData entityData, ref EntityTypeInstanceData entityTypeData, int componentId, in IntPtr component, int componentSize) {} // 0x00000001840BE7D0-0x00000001840BE8E0
		public static EntityManagerRange Iterate(in EntityManager em, in EntityQueryBuilder queryBuilder) => default; // 0x00000001840C3140-0x00000001840C32E0
		public static EntityManagerRange Iterate<T0, T1, T2>(in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3>(in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4>(in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5>(in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5, T6>(in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5, T6, T7>(in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS
			where T8 : struct, IComponentECS => default;
		public static unsafe void GetComponent(in EntityManager entityManager, Entity entity, int componentId, int componentSize, void* componentPtr) {} // 0x000000018793F53C-0x000000018793F62C
		public static bool MoveComponent<T>(in EntityManager entityManager, Entity src, Entity des)
			where T : struct, IComponentECS => default;
		public static void RemoveComponent(in EntityManager entityManager, Entity entity, int componentId) {} // 0x00000001840BAE90-0x00000001840BAEE0
		public static void SafeRemoveComponent<T>(in EntityManager entityManager, Entity entity)
			where T : struct, IComponentECS {}
		public static void RemoveComponent<T>(in EntityManager entityManager)
			where T : struct, IComponentECS {}
		public static bool GetInstance<T, TR>(in EntityManager em, out Entity entity, out ref TR component)
			where T : struct, IComponentECS
			where TR : struct, IComponentECS {
			entity = default;
			component = default;
			return default;
		}
		public static bool GetFirst<T, TR>(in EntityManager entityManager, out Entity entity, out ref TR component)
			where T : struct, IComponentECS
			where TR : struct, IComponentECS {
			entity = default;
			component = default;
			return default;
		}
		public static bool GetFirst<T1, T2, TR>(in EntityManager entityManager, out Entity entity, out ref TR component)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where TR : struct, IComponentECS {
			entity = default;
			component = default;
			return default;
		}
		public static void NotifyEvent<T>(in EntityManager em, Entity logicEntity)
			where T : struct, INotificationComponent {}
		public static void NotifyEvent<T>(in EntityManager em, Entity logicEntity, T t)
			where T : struct, INotificationComponent {}
		public static void NotifyEvent<T1, T2>(in EntityManager em, Entity logicEntity, T1 t1, T2 t2)
			where T1 : struct, INotificationComponent
			where T2 : struct, INotificationComponent {}
		public static void DispatchEvent<T>(in EntityManager em, Entity entity)
			where T : struct, IReactiveComponent {}
		public static void DispatchEvent<T>(in EntityManager em, Entity entity, T t)
			where T : struct, IReactiveComponent {}
		public static void DispatchEvent<T1, T2>(in EntityManager em, Entity entity, T1 t1, T2 t2)
			where T1 : struct, IReactiveComponent
			where T2 : struct, IReactiveComponent {}
		public static void DestroyEntitiesWithArchetype(in EntityManager entityManager, ref ComponentMask entityMask) {} // 0x000000018793F30C-0x000000018793F53C
		public static void DestroyEntities<T>(in EntityManager entityManager)
			where T : struct, IComponentECS {}
		public static void DestroyEntities<T1, T2>(in EntityManager entityManager)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS {}
		public static bool HasEntity<T>(in EntityManager em)
			where T : struct, IComponentECS => default;
		public static bool HasEntity<T1, T2>(in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS => default;
		public static int GetEntityCount(in EntityManager em, int compId) => default; // 0x000000018793F62C-0x000000018793F7A0
		public static int GetEntityCount(in EntityManager em, int compId0, int compId1) => default; // 0x000000018793F7A0-0x000000018793F914
		public static int GetEntityCount<T>(in EntityManager em)
			where T : struct, IComponentECS => default;
		public static int GetEntityCount<T1, T2>(in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS => default;
		public static int GetEntityCount<T1, T2, T3>(in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS => default;
		public static int GetEntityCount<T1, T2, T3, T4>(in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS => default;
		public static int GetEntityCount<T1, T2, T3, T4, T5>(in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS => default;
		public static int GetEntityCount<T1, T2, T3, T4, T5, T6>(in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS => default;
		public static void EnsureComponent<T>(in EntityManager em, Entity entity)
			where T : struct, IComponentECS {}
		public static void EnsureComponent<T>(in EntityManager em, Entity entity, out ref T comp)
			where T : struct, IComponentECS {
			comp = default;
		}
		public static ECSSpan<T> GetComponentAsSpan<T>(GroupType groupType)
			where T : struct, IComponentECS => default;
		public static ECSSpan<T> GetComponentAsSpan<T>(GroupType groupType, int componentId)
			where T : struct, IComponentECS => default;
		public static ComponentMask ComposeComponentMaskAll(EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6) => default; // 0x0000000184D0DD90-0x0000000184D0DE70
		public static ComponentMask ComposeComponentMaskAll(EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6, int id7) => default; // 0x0000000184DA0A20-0x0000000184DA0B20
		public static ComponentMask ComposeComponentMaskAll(EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6, int id7, int id8) => default; // 0x0000000185FB6AB0-0x0000000185FB6BD0
	}

	public static class HGFactoryRendererBinderExtensions // TypeDefIndex: 49470
	{
		// Methods
		public static void RenderWithTRS(HGFactoryRendererBinderComponent binder, in LocalToWorld localToWorld) {} // 0x0000000187940CF4-0x0000000187940E90
		public static void RenderWithTRS(HGFactoryRendererBinderComponent binder, float4x4 value) {} // 0x0000000187940E90-0x0000000187941014
		public static void EnableDither(HGFactoryRendererBinderComponent binder, bool enable, float alphaValue, HGObjectFlags objectFlags) {} // 0x00000001843EFF90-0x00000001843F01B0
		public static void EnableDither(HGFactoryRendererBinderComponent binder, ref EntityManager rEntityManager, bool enable, float alphaValue, HGObjectFlags objectFlags) {} // 0x00000001843F01B0-0x00000001843F0390
	}

	public struct EntityCommandBuffer // TypeDefIndex: 49473
	{
		// Fields
		public EntityCommandCallback onEntityCreate; // 0x00
		public EntityCommandCallback onEntityDestroy; // 0x08
		public EntityCommandCallback onComponentUpdate; // 0x10
		public EntityCommandCallback onComponentAdd; // 0x18
		public EntityCommandCallback onComponentRemove; // 0x20
		public static uint TempIdx; // 0x00
		public NativeQueue<EntityCommandBufferData> buffers; // 0x28
		public NativeParallelHashMap<ulong, VirtualEntityMap> tempEntities; // 0x40
		private readonly EntityManager _entityManager_k__BackingField; // 0x50
	
		// Properties
		public EntityManager entityManager { get; } // 0x000000018793FA88-0x000000018793FB44 
	
		// Nested types
		public delegate void EntityCommandCallback(Entity entity, ref EntityManager entityManager, ref EntityCommandBufferData buffer); // TypeDefIndex: 49471; 0x0000000185FB6BD0-0x0000000185FB6BE0
	
		public struct VirtualEntityMap // TypeDefIndex: 49472
		{
			// Fields
			public Entity virtualEntity; // 0x00
			public Entity realEntity; // 0x08
		}
	
		// Constructors
		public EntityCommandBuffer(ref EntityManager entityManager, Unity.Collections.Allocator allocator) : this() {
			onEntityCreate = default;
			onEntityDestroy = default;
			onComponentUpdate = default;
			onComponentAdd = default;
			onComponentRemove = default;
			buffers = default;
			tempEntities = default;
			<entityManager>k__BackingField = default;
		} // 0x0000000181A578C0-0x0000000181A578E0
	
		// Methods
		public ValueTuple<bool, Entity> GetRealEntity(Entity virtualEntity) => default; // 0x0000000187209F90-0x0000000187209FB0
	}

	public static class EntityCommand // TypeDefIndex: 49474
	{
		// Methods
		public static EntityCommandBuffer CreateCommandBuffer(EntityManager entityManager, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x02060F5B */) => default; // 0x0000000184794020-0x0000000184794060
		public static Entity CreateEntity(EntityCommandBuffer ecb) => default; // 0x000000018479FDF0-0x000000018479FFC0
		public static void DestroyEntity(EntityCommandBuffer ecb, Entity entity) {} // 0x000000018479FB90-0x000000018479FC50
		public static void AddComponent<T>(EntityCommandBuffer ecb, Entity entity)
			where T : struct, IComponentECS {}
		public static void AddComponent<T>(EntityCommandBuffer ecb, Entity entity, T component)
			where T : struct, IComponentECS {}
		public static void RemoveComponent<T>(EntityCommandBuffer ecb, Entity entity)
			where T : struct, IComponentECS {}
		public static void SetComponent<T>(EntityCommandBuffer ecb, Entity entity, T component)
			where T : struct, IComponentECS {}
		public static void Is<T>(EntityCommandBuffer ecb, Entity entity, bool flag)
			where T : struct, IComponentECS {}
		public static void GetComponent<T>(EntityCommandBuffer ecb, Entity entity, ref ref T component)
			where T : struct, IComponentECS {}
		private static unsafe void* _ComponentCpy<T>(T component)
			where T : struct, IComponentECS => default;
		public static void NotifyEvent<T>(EntityCommandBuffer ecb, Entity entity)
			where T : struct, INotificationComponent {}
		public static void NotifyEvent<T>(EntityCommandBuffer ecb, Entity entity, T t)
			where T : struct, INotificationComponent {}
		public static void DispatchEvent<T>(EntityCommandBuffer ecb, Entity entity)
			where T : struct, IReactiveComponent {}
		public static void DispatchEvent<T>(EntityCommandBuffer ecb, Entity entity, T component)
			where T : struct, IReactiveComponent {}
		public static void Playback(EntityCommandBuffer ecb, bool autoDispose = true /* Metadata: 0x02060F5C */) {} // 0x00000001840BAFF0-0x00000001840BB770
		public static void Dispose(EntityCommandBuffer ecb) {} // 0x00000001840BAC20-0x00000001840BACE0
	}

	public class EntityCommandOp // TypeDefIndex: 49475
	{
		// Fields
		public static readonly int CREATE; // 0x00
		public static readonly int ADD; // 0x04
		public static readonly int REMOVE; // 0x08
		public static readonly int MODIFY; // 0x0C
		public static readonly int DESTROY; // 0x10
		public static readonly int QUERY; // 0x14
	
		// Constructors
		public EntityCommandOp() {} // 0x0000000185492010-0x0000000185492020
		static EntityCommandOp() {} // 0x0000000185F4D2C0-0x0000000185F4D370
	}

	public struct EntityCommandBufferData // TypeDefIndex: 49476
	{
		// Fields
		public int op; // 0x00
		public Entity entity; // 0x04
		public CommandBufferComponent componentData; // 0x10
	
		// Methods
		public void Free() {} // 0x000000018646DADC-0x000000018646DAF0
	}

	public struct CommandBufferComponent // TypeDefIndex: 49477
	{
		// Fields
		public int componentId; // 0x00
		public int componentSize; // 0x04
		public unsafe void* component; // 0x08
	}

	public struct EntityCommandBufferV2 : INativeDisposable // TypeDefIndex: 49480
	{
		// Fields
		public static int s_mapSize; // 0x00
		public NativeQueue<EntityCommandBufferData> buffers; // 0x00
		public NativeParallelHashMap<ulong, VirtualEntityMap> tempEntities; // 0x18
	
		// Properties
		public bool isEmpty { get => default; } // 0x000000018793FA4C-0x000000018793FA88 
	
		// Nested types
		public struct VirtualEntityMap // TypeDefIndex: 49478
		{
			// Fields
			public Entity virtualEntity; // 0x00
			public Entity realEntity; // 0x08
		}
	
		public struct EntityCommandBufferParallelWriter // TypeDefIndex: 49479
		{
			// Fields
			public long tempIdx; // 0x00
			public NativeQueue<EntityCommandBufferData> buffersWriter; // 0x08
			public NativeParallelHashMap<ulong, VirtualEntityMap> tempEntitiesWriter; // 0x20
		}
	
		// Constructors
		public EntityCommandBufferV2(Unity.Collections.Allocator allocator) : this() {
			buffers = default;
			tempEntities = default;
		} // 0x0000000185EB5500-0x0000000185EB55F0
		static EntityCommandBufferV2() {
			s_mapSize = default;
		} // 0x0000000185FA4D60-0x0000000185FA4DA0
	
		// Methods
		public ValueTuple<bool, Entity> GetRealEntity(Entity virtualEntity) => default; // 0x00000001840BBE40-0x00000001840BC0B0
		public void Reset() {} // 0x00000001840BBA80-0x00000001840BBC40
		public void Dispose() {} // 0x000000018793F9E0-0x000000018793FA4C
		public JobHandle Dispose(JobHandle dependsOn) => default; // 0x000000018793F914-0x000000018793F9E0
		public EntityCommandBufferParallelWriter AsParallelWriter() => default; // 0x0000000184884550-0x0000000184884620
	}

	public static class EntityCommandV2 // TypeDefIndex: 49481
	{
		// Fields
		private static readonly Queue<EntityCommandBufferV2> S_POOL; // 0x00
	
		// Constructors
		static EntityCommandV2() {} // 0x0000000185F3A2A0-0x0000000185F3A360
	
		// Methods
		public static EntityCommandBufferV2 CreateConcurrentCommandBufferV2(EntityManager em) => default; // 0x0000000184888910-0x0000000184888B20
		public static void DisposePool() {} // 0x000000018793FDC4-0x000000018793FEC8
		public static void Recycle(ref EntityCommandBufferV2 buffer) {} // 0x00000001840BB770-0x00000001840BBA80
		public static Entity CreateEntity(ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer) => default; // 0x000000018793FC0C-0x000000018793FD24
		public static void DestroyEntity(ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity) {} // 0x000000018793FD24-0x000000018793FDC4
		public static void AddComponent<T>(ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, IComponentECS {}
		public static void AddComponent<T>(ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T component)
			where T : struct, IComponentECS {}
		public static void RemoveComponent<T>(ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, IComponentECS {}
		public static void SetComponent<T>(ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T component)
			where T : struct, IComponentECS {}
		public static void GetComponent<T>(ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, ref ref T component)
			where T : struct, IComponentECS {}
		private static unsafe T* _ComponentCpy<T>(T component)
			where T : struct, IComponentECS => default;
		public static void NotifyEvent<T>(ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, INotificationComponent {}
		public static void NotifyEvent<T>(ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T t)
			where T : struct, INotificationComponent {}
		public static void DispatchEvent<T>(ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, IReactiveComponent {}
		public static void DispatchEvent<T>(ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T component)
			where T : struct, IReactiveComponent {}
		public static void Playback(EntityCommandBufferV2 ecb, bool autoRecycle = true /* Metadata: 0x02060F5D */) {} // 0x00000001840BC0B0-0x00000001840BCAE0
	}

	public struct ECSSpan<T> // TypeDefIndex: 49482
		where T : struct, IComponentECS
	{
		// Fields
		public unsafe void* buffer;
		public int length;
	
		// Properties
		public ref T this[int index] { get => default; }
	}

	public struct EntityPool<T0, T1, T2> // TypeDefIndex: 49483
		where T0 : struct
		where T1 : struct
		where T2 : struct
	{
		// Fields
		private int _defaultSize_k__BackingField;
		private int m_count;
		private int m_usedCount;
		public float4x4 customData;
		private NativeArray<Entity> m_pool;
		private Action<Entity, float3, float3, Matrix4x4, float4x4> m_onSpawn;
		private Action<Entity, float4x4> m_onRecycle;
		private Action<NativeArray<Entity>, int, float4x4> m_onAllocate;
		private Action<NativeArray<Entity>, int, float4x4> m_onDeallocate;
		private Unity.Collections.Allocator m_allocator;
	
		// Properties
		public int defaultSize { get; private set; }
		public Entity this[int index] { get => default; }
		private NativeArray<Entity> entities { get => default; }
		public bool initialized { get => default; }
		public int length { get => default; }
		public int cacheSize { get => default; }
	
		// Methods
		public bool DecreasePool() => default;
		public bool NeedToResize(int count) => default;
		public Entity Spawn(float3 pos, float3 rot, Matrix4x4 fArgs) => default;
		public Entity Spawn(out bool resized) {
			resized = default;
			return default;
		}
		public bool Spawn(int n) => default;
		public void Recycle(int count = 1 /* Metadata: 0x02060F5E */) {}
		public Entity Recycle(Entity entity) => default;
		public static EntityPool<T0, T1, T2> Alloc(int count, Action<Entity, float3, float3, Matrix4x4, float4x4> onSpawn, Action<Entity, float4x4> onRecycle, Action<NativeArray<Entity>, int, float4x4> onAllocate, Action<NativeArray<Entity>, int, float4x4> onDeallocate = null, float4x4 customData = default, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x02060F5F */, bool autoAllocate = true /* Metadata: 0x02060F60 */) => default;
		public void Free() {}
		private void _Resize() {}
		public static implicit operator NativeArray<Entity>(EntityPool<T0, T1, T2> pool) => default;
		public NativeArray<Entity> AsReadOnly() => default;
	}

	public class EntityHierarchyContainer // TypeDefIndex: 49486
	{
		// Fields
		public const int INVALID_INDEX = -1; // Metadata: 0x02060F61
		private HGArray<Node> m_nodes; // 0x10
	
		// Properties
		public ref EntityTransformData this[int index] { get => default; } // 0x00000001843E70C0-0x00000001843E7110 
		public ref EntityTransformData this[uint index] { get => default; } // 0x0000000184094FD0-0x0000000184095010 
	
		// Nested types
		public struct EntityTransformData // TypeDefIndex: 49484
		{
			// Fields
			public uint next; // 0x00
			public LocalTransform localTrans; // 0x04
			public int parentIndex; // 0x24
			public bool dirty; // 0x28
		}
	
		internal struct Node // TypeDefIndex: 49485
		{
			// Fields
			public EntityTransformData value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public EntityHierarchyContainer() {} // Dummy constructor
		public EntityHierarchyContainer(Unity.Collections.Allocator allocator) {} // 0x00000001852D3000-0x00000001852D30A0
	
		// Methods
		public void Dispose() {} // 0x000000018793FF38-0x000000018793FF7C
		public uint Size() => default; // 0x000000018793FFD4-0x0000000187940008
		public Span<EntityTransformData> AsSpan() => default; // 0x000000018793FEC8-0x000000018793FF38
		public LocalTransform WorldTrans(uint handle) => default; // 0x0000000187940154-0x00000001879401CC
		public LocalTransform WorldTrans(EntityTransformData transform) => default; // 0x0000000187940008-0x0000000187940154
		public static unsafe LocalTransform WorldTrans(EntityTransformData transform, EntityTransformData* hierarchyContainer) => default; // 0x00000001845B8AE0-0x00000001845B8C50
		public uint Create(ref EntityTransformData value) => default; // 0x00000001843E6EF0-0x00000001843E7030
		public void Destroy(uint handle) {} // 0x000000018479D6E0-0x000000018479D740
		public void Reset() {} // 0x00000001852D2B20-0x00000001852D2B80
		public void Reserve(uint newCapacity) {} // 0x000000018793FF8C-0x000000018793FFD4
		public IntPtr Data() => default; // 0x00000001843EE420-0x00000001843EE460
		public ref EntityTransformData Get(uint handle) => ref _refReturnTypeForGet; // 0x000000018793FF7C-0x000000018793FF84
		private ref EntityTransformData _refReturnTypeForGet; // Dummy field
		public ref EntityTransformData Get(int handle) => ref _refReturnTypeForGet; // 0x000000018793FF84-0x000000018793FF8C
		private ref EntityTransformData _refReturnTypeForGet; // Dummy field
	}

	public struct EntityQueryBuilder // TypeDefIndex: 49489
	{
		// Fields
		internal unsafe BuilderData* builderDataPtr; // 0x00
	
		// Nested types
		internal struct BuilderData // TypeDefIndex: 49488
		{
			// Fields
			internal UnsafeList<ComponentType> all; // 0x00
			internal UnsafeList<ComponentType> none; // 0x20
	
			// Nested types
			internal enum Type // TypeDefIndex: 49487
			{
				INCLUDE = 0,
				EXCLUDE = 1
			}
	
			// Methods
			public ComponentMask ComponentMask(in EntityManager em, Type type) => default; // 0x00000001840C81F0-0x00000001840C8570
		}
	
		// Constructors
		public unsafe EntityQueryBuilder(int maxCount = 8 /* Metadata: 0x02060F62 */) {
			builderDataPtr = default;
		} // 0x00000001840C8170-0x00000001840C81A0
	
		// Methods
		public static EntityQueryBuilder Create(int maxCount = 8 /* Metadata: 0x02060F63 */) => default;
		public EntityQueryBuilder WithAll<T>()
			where T : struct, IComponentECS => default;
		public EntityQueryBuilder WithAll<T1, T2>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS => default;
		public EntityQueryBuilder WithAll<T1, T2, T3>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS => default;
		public EntityQueryBuilder WithAll<T1, T2, T3, T4>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS => default;
		public EntityQueryBuilder WithAll<T1, T2, T3, T4, T5>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS => default;
		public EntityQueryBuilder WithAll<T1, T2, T3, T4, T5, T6>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS => default;
		public EntityQueryBuilder WithAll<T1, T2, T3, T4, T5, T6, T7>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS => default;
		public EntityQueryBuilder WithNone<T>()
			where T : struct, IComponentECS => default;
		public EntityQueryBuilder WithNone<T1, T2>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS => default;
		public EntityQueryBuilder WithNone<T1, T2, T3>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS => default;
		public EntityQueryBuilder WithNone<T1, T2, T3, T4>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS => default; // 0x000000018646DB3C-0x000000018646DB7C
		public EntityManagerRange Build(ref EntityManager em) => default; // 0x00000001840C32E0-0x00000001840C3550
	}

	public static class EntityQueryV2 // TypeDefIndex: 49493
	{
		// Nested types
		public struct BlockRange // TypeDefIndex: 49490
		{
			// Fields
			public int beginGroupIdx; // 0x00
			public int endGroupIdx; // 0x04
			public int beginGroupElemBeginIdx; // 0x08
			public int endGroupElemEndIdx; // 0x0C
		}
	
		public struct QueryResultDefer : IDisposable // TypeDefIndex: 49491
		{
			// Fields
			public unsafe UnsafeList<GroupType>* groups; // 0x00
			public unsafe UnsafeList<BlockRange>* blockRanges; // 0x08
			public int rangeCount; // 0x10
	
			// Properties
			public bool valid { get => default; } // 0x00000001840C6460-0x00000001840C6770 
			public unsafe int* rangeCountPtr { get => default; }
	
			// Methods
			public void InitList(Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x02060F7B */, int initialCapacity = 32 /* Metadata: 0x02060F7C */) {} // 0x000000018794051C-0x000000018794061C
			public void ReleaseList() {}
			public void Reset() {}
			public ref BlockRange BlockRangeAt(int index) => ref _refReturnTypeForBlockRangeAt;
			private ref BlockRange _refReturnTypeForBlockRangeAt; // Dummy field
			public ref GroupType GroupAt(int index) => ref _refReturnTypeForGroupAt;
			private ref GroupType _refReturnTypeForGroupAt; // Dummy field
			public void Foreach(Func<GroupType, bool> callback) {}
			public int EntityCount() => default;
			public void Dispose() {}
			public void Dispose(JobHandle jobHandle, bool inCrossFrame = false /* Metadata: 0x02060F7D */) {}
			public override string ToString() => default; // 0x00000001879401CC-0x000000018794051C
		}
	
		public struct QueryResult : IDisposable // TypeDefIndex: 49492
		{
			// Fields
			public NativeList<GroupType> groups; // 0x00
			public NativeList<BlockRange> blockRanges; // 0x10
	
			// Properties
			public int rangeCount { get => default; } // 0x00000001840C6850-0x00000001840C7220 
			public bool isEmpty { get => default; } // 0x00000001879415D0-0x00000001879415D8 
	
			// Methods
			public override string ToString() => default; // 0x00000001851D4F10-0x00000001851D4FC0
			public void Foreach(Func<GroupType, bool> callback) {} // 0x0000000187941394-0x00000001879413EC
			public int EntityCount() => default; // 0x00000001843EDF50-0x00000001843EDFA0
			public void Dispose() {} // 0x0000000187941014-0x000000018794105C
			public void Dispose(JobHandle jobHandle, bool inCrossFrame = false /* Metadata: 0x02060F7E */) {} // 0x0000000187941350-0x0000000187941394
		}
	
		// Methods
		public static QueryResult Query(EntityManager em, ref EntityQueryBuilder builder, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x02060F66 */, int jobCount = -1 /* Metadata: 0x02060F67 */) => default; // 0x0000000185FB6BE0-0x0000000185FB6BF0
		public static ref QueryResultDefer QueryDefer(EntityManager em, ref EntityQueryBuilder builder, ref QueryResultDefer qrd, int jobCount = -1 /* Metadata: 0x02060F68 */) => ref _refReturnTypeForQueryDefer; // 0x0000000187941280-0x0000000187941350
		private ref QueryResultDefer _refReturnTypeForQueryDefer; // Dummy field
		public static QueryResult Query<T>(EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x02060F69 */, int jobCount = -1 /* Metadata: 0x02060F6A */)
			where T : struct, IComponentECS => default; // 0x00000001879411B4-0x0000000187941280
		public static QueryResult Query<T0, T1>(EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x02060F6B */, int jobCount = -1 /* Metadata: 0x02060F6C */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS => default; // 0x000000018794105C-0x0000000187941080
		public static QueryResult Query<T0, T1, T2>(EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x02060F6D */, int jobCount = -1 /* Metadata: 0x02060F6E */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS => default; // 0x0000000187941080-0x00000001879411B4
		public static QueryResult Query<T0, T1, T2, T3>(EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x02060F6F */, int jobCount = -1 /* Metadata: 0x02060F70 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS => default; // 0x00000001879413EC-0x00000001879415D0
		public static QueryResult Query<T0, T1, T2, T3, T4>(EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x02060F71 */, int jobCount = -1 /* Metadata: 0x02060F72 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS => default; // 0x00000001843EBC90-0x00000001843EBCE0
		public static QueryResult Query<T0, T1, T2, T3, T4, T5>(EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x02060F73 */, int jobCount = -1 /* Metadata: 0x02060F74 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS => default; // 0x0000000187941C78-0x0000000187941C90
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6>(EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x02060F75 */, int jobCount = -1 /* Metadata: 0x02060F76 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS => default; // 0x0000000187941A40-0x0000000187941C78
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6, T7>(EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x02060F77 */, int jobCount = -1 /* Metadata: 0x02060F78 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS => default; // 0x00000001879418C8-0x0000000187941A40
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6, T7, T8>(EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x02060F79 */, int jobCount = -1 /* Metadata: 0x02060F7A */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS
			where T8 : struct, IComponentECS => default; // 0x00000001843ED5E0-0x00000001843ED7F0
		public static QueryResultDefer GetBlockRangesDefer(EntityManagerRange range, int jobCount, ref QueryResultDefer qr) => default; // 0x00000001879418A4-0x00000001879418C8
		public static QueryResult GetBlockRanges(EntityManagerRange range, Unity.Collections.Allocator allocator, int jobCount) => default; // 0x00000001840C5E10-0x00000001840C6170
	}

	public static class QueryResultWrapper // TypeDefIndex: 49496
	{
		// Nested types
		public unsafe delegate void Wrapper_000000D7_PostfixBurstDelegate(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount); // TypeDefIndex: 49494; 0x00000001879415D8-0x00000001879418A4
	
		internal static class Wrapper_000000D7_BurstDirectCall // TypeDefIndex: 49495
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Wrapper_000000D7_BurstDirectCall() {} // 0x0000000185F449C0-0x0000000185F44A50
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006816d) {} // 0x0000000187942260-0x00000001879422FC
			private static IntPtr GetFunctionPointer() => default; // 0x00000001864BB614-0x00000001864BB734
			public static void Constructor() {} // 0x00000001840C7620-0x00000001840C77D0
			public static void Initialize() {} // 0x00000001840C7400-0x00000001840C7590
			public static unsafe void Invoke(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Methods
		public static unsafe void Wrapper(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount) {} // 0x0000000185F449B0-0x0000000185F449C0
		public static unsafe void Wrapper_BurstManaged(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount) {} // 0x00000001840C7340-0x00000001840C7400
	}
}
