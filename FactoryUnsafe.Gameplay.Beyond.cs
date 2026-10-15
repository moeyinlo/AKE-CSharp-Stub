/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Beyond;
using Beyond.Cfg;
using Beyond.Gameplay;
using Beyond.Gameplay.Factory;
using Beyond.Gameplay.Factory.ECSVATFSM;
using Beyond.Gameplay.Factory.Unsafe;
using Beyond.GEnums;
using Beyond.ManifestBinary;
using Beyond.PoolCore;
using Beyond.SourceGenerator;
using Beyond.SparkBuffer.Runtime.Wrapper;
using Beyond.VFS;
using FactoryUIAtlas;
using IFix;
using Microsoft.CodeAnalysis;
using Sirenix.OdinInspector;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IL2CPP.CompilerServices;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Serialization;

// Image 20: FactoryUnsafe.Gameplay.Beyond.dll - Assembly: FactoryUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 79285-79982

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 79980
{
	// Methods
	internal static uint ComputeStringHash(string s); // 0x0000000185072450-0x00000001850724B0
}

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2851003627 // TypeDefIndex: 79981
{
	// Methods
	public static void CreateJobReflectionData(); // 0x0000000182888DD0-0x000000018288EB40
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit(); // 0x000000018288EB40-0x000000018288EB50
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 79982
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize(); // 0x0000000186BCA140-0x0000000186BCAA30
}

namespace Beyond
{
	public struct FixedStack<T> : IDisposable // TypeDefIndex: 79324
		where T : struct
	{
		// Fields
		private unsafe T* m_items;
		private readonly int m_capacity;
		private int m_size;
		private bool m_disposed;
	
		// Properties
		public int count { [IsReadOnly] get; }
		public int capacity { [IsReadOnly] get; }
		public bool isEmpty { [IsReadOnly] get; }
		public bool isFull { [IsReadOnly] get; }
	
		// Constructors
		public unsafe FixedStack(int capacity);
	
		// Methods
		public void Push(T item);
		public T Pop();
		[IsReadOnly]
		public T Peek();
		public void Clear();
		public void Dispose();
	}

	public struct HGArray<T> // TypeDefIndex: 79325
		where T : struct
	{
		// Fields
		private unsafe T* m_ptr;
		private readonly Unity.Collections.Allocator m_allocator;
		private uint m_size;
		private uint m_capacity;
		private unsafe void** m_pendingFree;
		private int m_pendingFreeCount;
		private int m_pendingFreeCapacity;
	
		// Properties
		public ref T this[int index] { get => default; }
		public ref T this[uint index] { get => default; }
	
		// Constructors
		public unsafe HGArray(Unity.Collections.Allocator label);
	
		// Methods
		public uint Size();
		public uint Capacity();
		public unsafe T* Ptr();
		private unsafe void _DeferFree(void* oldPtr);
		public void FlushPendingFree();
		private void _Grow(uint targetSize);
		public void Dispose();
		public void Resize(uint newSize);
		public void PushBack(ref ref T v0);
		public void PushBack(T v0);
		public ref ref T EmplaceBack();
		public void Clear();
		public void PopBack();
		public ref ref T Back();
		public void SwapAndPopBack(uint indexA);
		public void Reserve(uint newCapacity);
		public Span<T> AsSpan();
	}

	public static class AssetInstanceParseUtil // TypeDefIndex: 79326
	{
		// Methods
		public static NativeArray<int> Parse(UnityEngine.Object[] objects); // 0x0000000188CCFF98-0x0000000188CD005C
		public static int Parse(UnityEngine.Object obj); // 0x0000000188CD005C-0x0000000188CD00C0
		public static object Get(int id); // 0x000000018783B66C-0x000000018783B674
		public static T Get<T>(int id);
	}
}

namespace Beyond.Gameplay
{
	public class FactorySetting : ScriptableObject // TypeDefIndex: 79335
	{
		// Fields
		public GlobalSharedData.CullingDisSetting cullingDisSetting; // 0x18
		public FactoryEffectSetting lowFactoryEffectSetting; // 0x28
		public FactoryEffectSetting midFactoryEffectSetting; // 0x30
		public FactoryEffectSetting highFactoryEffectSetting; // 0x38
		public FactoryEffectSetting highestFactoryEffectSetting; // 0x40
		public float uiEffectOffsetY; // 0x48
		public float uiFactoryOutputOffsetY; // 0x4C
		[Range(0f, 0.2f)]
		public float conveyorOffsetY; // 0x50
		[Range(0f, 3f)]
		public float conveyorPortBlockOffsetY; // 0x54
		[Range(0f, 3f)]
		public float pipePortBlockOffsetY; // 0x58
		public int outputPoolSize; // 0x5C
		public int envGeneratorPoolSize; // 0x60
		public int buildingStatePoolSize; // 0x64
		public int portBlockPoolSize; // 0x68
		public int portArrowPoolSize; // 0x6C
		public int cargoPoolSize; // 0x70
		public int3 conveyorPoolSize; // 0x74
		public int3 pipePoolSize; // 0x80
		public int3 figurePoolSize; // 0x8C
		public int figurePipeHolderPoolSize; // 0x98
		public int wirePoolSize; // 0x9C
		public int pipeRendererMaxSize; // 0xA0
		public int portRendererMaxSize; // 0xA4
		public bool disableSystemInterval; // 0xA8
		[HideInInspector]
		public GlobalSharedData.SystemIntervalSetting systemIntervalSetting; // 0xAC
		public GlobalSharedData.NearByDistanceSetting nearByDistanceSetting; // 0xD4
		public FactoryBaseColorLutConfig factoryLutConfig; // 0xF0
		public FFactoryStateColorConfig factoryStateIconColorConfig; // 0xF8
		public FactoryUIAtlasSOData factoryItemIconAtlasUVConfig; // 0x118
		public FactoryUIAtlasSOData factoryStateIconAtlasUVConfig; // 0x120
		public FactoryUIAtlasSOData factorySocialIconAtlasUVConfig; // 0x128
		public FactoryUIAtlasSOData factoryGasStateIconAtlasUVConfig; // 0x130
		public FactoryLiquidAtlasSOData factoryLiquidAtlasUVConfig; // 0x138
		public FactoryLiquidAtlasSOData factoryGasAtlasUVConfig; // 0x140
		public int liquidAtlasMaxIndex; // 0x148
		public int gasAtlasMaxIndex; // 0x14C
		public AnimationCurve buildCutoffYCurve; // 0x150
		public AnimationCurve buildAlphaCurveType0; // 0x158
		public AnimationCurve buildAlphaCurveType1; // 0x160
		public AnimationCurve repairCurve0; // 0x168
		public AnimationCurve repairCurve1; // 0x170
		[Range(0f, 1f)]
		public float snowCoverageIntensity; // 0x178
		[Range(0f, 1f)]
		public float poweredBuildingSnowCoverageIntensityScale; // 0x17C
		public float snowCoverageDuration; // 0x180
		public float poweredSnowCoverageDuration; // 0x184
		public AnimationCurve snowCoverageCurve; // 0x188
		public float snowCoverageSystemInterval; // 0x190
		public float snowCoverageQueryRadius; // 0x194
		public int snowCoverageProcessBatchCount; // 0x198
		[Range(0f, 1f)]
		public float snowCoverageMinSnowIntensity; // 0x19C
		[Range(0f, 1f)]
		public float snowCoverageIntensityChangeThreshold; // 0x1A0
		public float snowCoverageSkyRaycastStartOffset; // 0x1A4
		public float snowCoverageSkyRaycastDistance; // 0x1A8
		[Range(0.001f, 1f)]
		public float buildingDither; // 0x1AC
		[Range(0.001f, 1f)]
		public float pedestalDither; // 0x1B0
		[Unit(Units.Meter)]
		public float ditherTargetField; // 0x1B4
		[Unit(Units.Meter)]
		public float ditherDistance; // 0x1B8
		public float soilAutoOpHarvestHideDelay; // 0x1BC
		public float soilAutoOpEmptyHoldDuration; // 0x1C0
		public float soilAutoOpPlantShowDelay; // 0x1C4
		[Range(0f, 1f)]
		public float lowFrameRate; // 0x1C8
	
		// Constructors
		public FactorySetting(); // 0x00000001870F0C20-0x00000001870F0D50
	
		// Methods
		private void OnEnable(); // 0x00000001872313B0-0x00000001872313C0
	}

	[Serializable]
	public struct FactoryEffectSetting // TypeDefIndex: 79336
	{
		// Fields
		public int maxEffectCount; // 0x00
		public float effectInterval; // 0x04
	}
}

namespace Beyond.Gameplay.Factory
{
	public static class Archetypes // TypeDefIndex: 79337
	{
		// Properties
		public static NativeArray<ComponentType> empty { get; } // 0x00000001863AF9E0-0x00000001863AFAB0 
		public static NativeArray<ComponentType> env { get; } // 0x00000001865EEDE0-0x00000001865EEEE0 
		public static NativeArray<ComponentType> connection { get; } // 0x00000001855CE240-0x00000001855CE340 
		public static NativeArray<ComponentType> buildingUnit { get; } // 0x00000001857391D0-0x00000001857395D0 
		public static NativeArray<ComponentType> powerStation { get; } // 0x0000000186C6CE70-0x0000000186C6CF30 
		public static NativeArray<ComponentType> furnace { get; } // 0x00000001863B18E0-0x00000001863B1A00 
		public static NativeArray<ComponentType> grinder { get; } // 0x00000001863B1A00-0x00000001863B1AC0 
		public static NativeArray<ComponentType> winder { get; } // 0x00000001863B01E0-0x00000001863B02E0 
		public static NativeArray<ComponentType> componentMc { get; } // 0x00000001863B1130-0x00000001863B1250 
		public static NativeArray<ComponentType> shaper { get; } // 0x00000001863B1250-0x00000001863B1370 
		public static NativeArray<ComponentType> fillingPowderMc { get; } // 0x00000001863B0B80-0x00000001863B0CA0 
		public static NativeArray<ComponentType> thickener { get; } // 0x00000001863B16A0-0x00000001863B17C0 
		public static NativeArray<ComponentType> hub { get; } // 0x00000001864D5F10-0x00000001864D5F90 
		public static NativeArray<ComponentType> subHub { get; } // 0x00000001864D6010-0x00000001864D6090 
		public static NativeArray<ComponentType> miner { get; } // 0x00000001863B1B50-0x00000001863B1C00 
		public static NativeArray<ComponentType> toolsAssemblingMc { get; } // 0x00000001863B0CA0-0x00000001863B0DC0 
		public static NativeArray<ComponentType> seedCollector { get; } // 0x00000001863B1580-0x00000001863B16A0 
		public static NativeArray<ComponentType> planter { get; } // 0x00000001863B17C0-0x00000001863B18E0 
		public static NativeArray<ComponentType> powerDiffuser { get; } // 0x00000001864D6310-0x00000001864D6370 
		public static NativeArray<ComponentType> powerPole { get; } // 0x00000001864D6310-0x00000001864D6370 
		public static NativeArray<ComponentType> travelPole { get; } // 0x00000001864D6310-0x00000001864D6370 
		public static NativeArray<ComponentType> loader { get; } // 0x0000000188CCFA84-0x0000000188CCFAFC 
		public static NativeArray<ComponentType> unloader { get; } // 0x00000001863B1AC0-0x00000001863B1B50 
		public static NativeArray<ComponentType> storage { get; } // 0x00000001864D6210-0x00000001864D6290 
		public static NativeArray<ComponentType> powerTerminal { get; } // 0x0000000188CCFC1C-0x0000000188CCFC94 
		public static NativeArray<ComponentType> powerPort { get; } // 0x00000001864D6190-0x00000001864D6210 
		public static NativeArray<ComponentType> facBattle { get; } // 0x0000000186777620-0x00000001867776E0 
		public static NativeArray<ComponentType> pump { get; } // 0x00000001863B1490-0x00000001863B1580 
		public static NativeArray<ComponentType> liquidStorage { get; } // 0x00000001863B0630-0x00000001863B06F0 
		public static NativeArray<ComponentType> mixPool { get; } // 0x00000001863B1370-0x00000001863B1490 
		public static NativeArray<ComponentType> gasReactor { get; } // 0x0000000188CCF7EC-0x0000000188CCF90C 
		public static NativeArray<ComponentType> squirter { get; } // 0x0000000188CCFC94-0x0000000188CCFD50 
		public static NativeArray<ComponentType> dumper { get; } // 0x00000001863B0DC0-0x00000001863B0EB0 
		public static NativeArray<ComponentType> liquidCleaner { get; } // 0x00000001864D6090-0x00000001864D6110 
		public static NativeArray<ComponentType> xiraniteOven { get; } // 0x00000001863B0A40-0x00000001863B0B80 
		public static NativeArray<ComponentType> liquidPurifier { get; } // 0x00000001863B02E0-0x00000001863B0450 
		public static NativeArray<ComponentType> dismantler { get; } // 0x0000000188CCF6EC-0x0000000188CCF7EC 
		public static NativeArray<ComponentType> transmuter { get; } // 0x0000000188CCFD50-0x0000000188CCFE98 
		public static NativeArray<ComponentType> vaporizer { get; } // 0x0000000188CCFE98-0x0000000188CCFF98 
		public static NativeArray<ComponentType> bus { get; } // 0x0000000186B6E630-0x0000000186B6E6F0 
		public static NativeArray<ComponentType> busRootRender { get; } // 0x0000000188CCF21C-0x0000000188CCF2F8 
		public static NativeArray<ComponentType> busSubRender { get; } // 0x0000000188CCF2F8-0x0000000188CCF3D4 
		public static NativeArray<ComponentType> hsBus { get; } // 0x0000000186B6E570-0x0000000186B6E630 
		public static NativeArray<ComponentType> hsBusSource { get; } // 0x00000001864D5F90-0x00000001864D6010 
		public static NativeArray<ComponentType> udPipeLoader { get; } // 0x00000001863B0FF0-0x00000001863B1130 
		public static NativeArray<ComponentType> udPipeUnloader { get; } // 0x00000001863B0EB0-0x00000001863B0FF0 
		public static NativeArray<ComponentType> liquidCleanGate { get; } // 0x0000000188CCF90C-0x0000000188CCF9C8 
		public static NativeArray<ComponentType> liquidRecycleGate { get; } // 0x0000000188CCF9C8-0x0000000188CCFA84 
		public static NativeArray<ComponentType> carrier { get; } // 0x00000001864D6110-0x00000001864D6190 
		public static NativeArray<ComponentType> marker { get; } // 0x00000001864D6290-0x00000001864D6310 
		public static NativeArray<ComponentType> decoration { get; } // 0x0000000188CCF3D4-0x0000000188CCF6EC 
		public static NativeArray<ComponentType> pipeConditioner { get; } // 0x0000000188CCFAFC-0x0000000188CCFC1C 
		public static NativeArray<ComponentType> conveyorLogistics { get; } // 0x00000001863B0570-0x00000001863B0630 
		public static NativeArray<ComponentType> pipeLogistics { get; } // 0x00000001852C4010-0x00000001852C40D0 
		public static NativeArray<ComponentType> logConditioner { get; } // 0x00000001863B0450-0x00000001863B0570 
		public static NativeArray<ComponentType> buildingFakeUnit { get; } // 0x0000000186CE8130-0x0000000186CE84B0 
		public static NativeArray<ComponentType> buildingRenderOnlyUnit { get; } // 0x0000000186D34640-0x0000000186D34930 
		public static NativeArray<ComponentType> buildingPreviewUnit { get; } // 0x0000000186CFD790-0x0000000186CFDAE0 
		public static NativeArray<ComponentType> buildingGuideHintUnit { get; } // 0x0000000186D23A50-0x0000000186D23F30 
		public static NativeArray<ComponentType> conveyor { get; } // 0x0000000185739930-0x0000000185739BF0 
		public static NativeArray<ComponentType> guideConveyor { get; } // 0x0000000186DFD230-0x0000000186DFD490 
		public static NativeArray<ComponentType> pipe { get; } // 0x000000018543DD80-0x000000018543DF10 
		public static NativeArray<ComponentType> pipeHolder { get; } // 0x00000001852C4680-0x00000001852C4970 
		public static NativeArray<ComponentType> cargo { get; } // 0x00000001857395D0-0x0000000185739930 
		public static NativeArray<ComponentType> buildingRender { get; } // 0x0000000185738DB0-0x00000001857391D0 
		public static NativeArray<ComponentType> buildingRootRender { get; } // 0x00000001857379D0-0x0000000185737A60 
		public static NativeArray<ComponentType> buildingSubRender { get; } // 0x0000000186585230-0x00000001865852C0 
		public static NativeArray<ComponentType> pedestalRender { get; } // 0x0000000185737CA0-0x00000001857380A0 
		public static NativeArray<ComponentType> conveyorLeftRender { get; } // 0x000000018543EED0-0x000000018543F0D0 
		public static NativeArray<ComponentType> conveyorRightRender { get; } // 0x000000018543F2D0-0x000000018543F4D0 
		public static NativeArray<ComponentType> conveyorMidRender { get; } // 0x000000018543DB80-0x000000018543DD80 
		public static NativeArray<ComponentType> figureConveyorLogisticsRender { get; } // 0x00000001863AD820-0x00000001863AD9E0 
		public static NativeArray<ComponentType> figurePipeHolderRender { get; } // 0x00000001863AD9E0-0x00000001863ADBA0 
		public static NativeArray<ComponentType> figureLeftRender { get; } // 0x00000001863ADBA0-0x00000001863ADD60 
		public static NativeArray<ComponentType> figureRightRender { get; } // 0x00000001863ADD60-0x00000001863ADF20 
		public static NativeArray<ComponentType> figureMidRender { get; } // 0x00000001863ADF20-0x00000001863AE0E0 
		public static NativeArray<ComponentType> conveyorPreviewRender { get; } // 0x00000001863AE0E0-0x00000001863AE2A0 
		public static NativeArray<ComponentType> pipePreviewRender { get; } // 0x00000001863AE740-0x00000001863AE8E0 
		public static NativeArray<ComponentType> pipeComRender { get; } // 0x000000018543F6C0-0x000000018543F830 
		public static NativeArray<ComponentType> pipeSplashRender { get; } // 0x0000000186DBD630-0x0000000186DBD7A0 
		public static NativeArray<ComponentType> pipeLeftRender { get; } // 0x000000018543F0D0-0x000000018543F2D0 
		public static NativeArray<ComponentType> pipeMidRender { get; } // 0x000000018543D980-0x000000018543DB80 
		public static NativeArray<ComponentType> pipeRightRender { get; } // 0x000000018543ECD0-0x000000018543EED0 
		public static NativeArray<ComponentType> pipeTrackLeftPreviewRender { get; } // 0x000000018543B6F0-0x000000018543B8B0 
		public static NativeArray<ComponentType> pipeTrackMidPreviewRender { get; } // 0x000000018543B8B0-0x000000018543BA70 
		public static NativeArray<ComponentType> pipeTrackRightPreviewRender { get; } // 0x000000018543BA70-0x000000018543BC30 
		public static NativeArray<ComponentType> outputUIRenderer { get; } // 0x00000001863B0070-0x00000001863B01E0 
		public static NativeArray<ComponentType> envGeneratorUIRenderer { get; } // 0x00000001863AFF00-0x00000001863B0070 
		public static NativeArray<ComponentType> wireRenderer { get; } // 0x000000018543E130-0x000000018543E2A0 
		public static NativeArray<ComponentType> unitStatusUIRenderer { get; } // 0x00000001863AFD90-0x00000001863AFF00 
		public static NativeArray<ComponentType> portPreviewUIRenderer { get; } // 0x00000001863AFC20-0x00000001863AFD90 
		public static NativeArray<ComponentType> gridRenderer { get; } // 0x00000001863AE2A0-0x00000001863AE460 
		public static NativeArray<ComponentType> gridMainRegionRenderer { get; } // 0x00000001863AE460-0x00000001863AE620 
		public static NativeArray<ComponentType> portStatusUIRenderer { get; } // 0x00000001863AFAB0-0x00000001863AFC20 
		public static NativeArray<ComponentType> scope { get; } // 0x00000001856E8D20-0x00000001856E8E30 
		public static NativeArray<ComponentType> soil { get; } // 0x00000001863B06F0-0x00000001863B0A40 
		public static NativeArray<ComponentType> cropRender { get; } // 0x0000000186583AF0-0x0000000186585230 
	
		// Methods
		public static NativeArray<ComponentType> CreateArchetype(NativeArray<ComponentType> baseArchetype, params ComponentType[] extraTypes); // 0x0000000185739BF0-0x0000000185739D80
		public static NativeArray<ComponentType> Select(string templateId); // 0x00000001850B1570-0x00000001850B22A0
	}

	[DataN(capacity = 16, tSize = 4, ring = false)]
	[NoAlias]
	public struct AdditiveEffectRequestStack<T> : IEnumerable<T> // TypeDefIndex: 79340
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x0263B816
		public const int CAPACITY = 16; // Metadata: 0x0263B817
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x0263B818
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B819
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79338
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private AdditiveEffectRequestStack<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in AdditiveEffectRequestStack<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79339
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe AdditiveEffectRequestStack(int initialCapacity = 16 /* Metadata: 0x0263B814 */, bool autoExtend = false /* Metadata: 0x0263B815 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	public struct BlueprintSlotContainer // TypeDefIndex: 79342
	{
		// Fields
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref BlueprintSlotInfo this[uint index] { get => default; } // 0x00000001870D3DD0-0x00000001870D3E10 
	
		// Nested types
		internal struct Node // TypeDefIndex: 79341
		{
			// Fields
			public BlueprintSlotInfo value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public BlueprintSlotContainer(Unity.Collections.Allocator allocator); // 0x00000001861FB590-0x00000001861FB630
	
		// Methods
		public void Dispose(); // 0x0000000188CD0118-0x0000000188CD0154
		public void FlushPendingFree(); // 0x0000000185F71E70-0x0000000185F71EC0
		public uint Create(ref BlueprintSlotInfo value); // 0x00000001856E8F20-0x00000001856E8FE0
		public void Destroy(uint handle); // 0x0000000188CD00C0-0x0000000188CD0118
		public void Reset(); // 0x0000000188CD0154-0x0000000188CD01A8
	}

	public struct ConveyorExtContainer // TypeDefIndex: 79345
	{
		// Fields
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref ConveyorExt this[int index] { get => default; } // 0x0000000188CD06F4-0x0000000188CD0738 
		public ref ConveyorExt this[uint index] { get => default; } // 0x00000001872399C0-0x00000001872399D0 
	
		// Nested types
		public struct ConveyorExt // TypeDefIndex: 79343
		{
			// Fields
			public int outCargoIndex; // 0x00
			public int cargoBeginIndex; // 0x04
			public int cargoEndIndex; // 0x08
	
			// Methods
			public void Reset(); // 0x00000001872399D0-0x00000001872399E0
		}
	
		internal struct Node // TypeDefIndex: 79344
		{
			// Fields
			public ConveyorExt value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public ConveyorExtContainer(Unity.Collections.Allocator allocator); // 0x00000001861FB4F0-0x00000001861FB590
	
		// Methods
		public void Dispose(); // 0x0000000188CD05E8-0x0000000188CD0624
		public void FlushPendingFree(); // 0x0000000185F71FC0-0x0000000185F72040
		public uint Size(); // 0x0000000188CD06C0-0x0000000188CD06F4
		public Span<ConveyorExt> AsSpan(); // 0x0000000188CD0520-0x0000000188CD0590
		public uint Create(ref ConveyorExt value); // 0x00000001858710B0-0x0000000185871100
		public void Destroy(uint handle); // 0x0000000188CD0590-0x0000000188CD05E8
		public void Reset(); // 0x0000000188CD066C-0x0000000188CD06C0
		public void Reserve(uint newCapacity); // 0x0000000188CD0624-0x0000000188CD066C
		public IntPtr Data(); // 0x0000000184431970-0x0000000184431980
		public ref ConveyorExt Get(uint handle); // 0x00000001872399C0-0x00000001872399D0
	}

	public struct ConveyorInfoAllocator // TypeDefIndex: 79347
	{
		// Fields
		private LinearAllocatorUnmanaged m_allocator; // 0x00
	
		// Properties
		public unsafe void* memoryPtr { get; } // 0x0000000188CD07C4-0x0000000188CD07D0 
	
		// Nested types
		public struct Info // TypeDefIndex: 79346
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
		public static unsafe ConveyorInfoAllocator* Create(int capacity); // 0x000000018708FBF0-0x0000000187090010
		public static unsafe void Destroy(ConveyorInfoAllocator* allocator); // 0x0000000188CD0750-0x0000000188CD077C
		public LinearAllocator.Allocation Allocate(int count); // 0x0000000185FF20F0-0x0000000185FF2130
		public LinearAllocator.Allocation Resize(LinearAllocator.Allocation allocation, int newCount); // 0x0000000188CD0784-0x0000000188CD07C4
		public void Free(uint memoryOffset); // 0x0000000188CD077C-0x0000000188CD0784
		public long CalculateSize(uint memoryOffset); // 0x0000000188CD0738-0x0000000188CD0750
		public unsafe Info* GetInfo(long offset); // 0x0000000187837D84-0x0000000187837D8C
	}

	public struct Data2<T> // TypeDefIndex: 79348
		where T : struct
	{
		// Fields
		public T port0;
		public T port1;
	
		// Properties
		public int length { get; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data4<T> // TypeDefIndex: 79349
		where T : struct
	{
		// Fields
		public Data2<T> port0;
		public Data2<T> port1;
	
		// Properties
		public int length { get; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data8<T> // TypeDefIndex: 79350
		where T : struct
	{
		// Fields
		public Data4<T> port0;
		public Data4<T> port1;
	
		// Properties
		public int length { get; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data16<T> // TypeDefIndex: 79351
		where T : struct
	{
		// Fields
		public Data8<T> port0;
		public Data8<T> port1;
	
		// Properties
		public int length { get; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data32<T> // TypeDefIndex: 79352
		where T : struct
	{
		// Fields
		public Data16<T> port0;
		public Data16<T> port1;
	
		// Properties
		public int length { get; }
		public T this[int idx] { get => default; set {} }
	}

	[DataN(capacity = 4, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData4<T> : IEnumerable<T> // TypeDefIndex: 79355
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0263B81C
		public const int CAPACITY = 4; // Metadata: 0x0263B81D
		public const int CAPACITY_MINUS_ONE = 3; // Metadata: 0x0263B81E
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B81F
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79353
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData4<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in EntityData4<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79354
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData4(int initialCapacity = 4 /* Metadata: 0x0263B81A */, bool autoExtend = false /* Metadata: 0x0263B81B */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 8, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData8<T> : IEnumerable<T> // TypeDefIndex: 79358
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0263B822
		public const int CAPACITY = 8; // Metadata: 0x0263B823
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x0263B824
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B825
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79356
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData8<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in EntityData8<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79357
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData8(int initialCapacity = 8 /* Metadata: 0x0263B820 */, bool autoExtend = false /* Metadata: 0x0263B821 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 32, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData32<T> : IEnumerable<T> // TypeDefIndex: 79361
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0263B828
		public const int CAPACITY = 32; // Metadata: 0x0263B829
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x0263B82A
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B82B
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79359
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData32<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in EntityData32<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79360
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData32(int initialCapacity = 32 /* Metadata: 0x0263B826 */, bool autoExtend = false /* Metadata: 0x0263B827 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 64, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData64<T> : IEnumerable<T> // TypeDefIndex: 79364
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0263B82F
		public const int CAPACITY = 64; // Metadata: 0x0263B830
		public const int CAPACITY_MINUS_ONE = 63; // Metadata: 0x0263B832
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B833
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79362
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData64<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in EntityData64<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79363
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData64(int initialCapacity = 64 /* Metadata: 0x0263B82C */, bool autoExtend = false /* Metadata: 0x0263B82E */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 128, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData128<T> : IEnumerable<T> // TypeDefIndex: 79367
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0263B837
		public const int CAPACITY = 128; // Metadata: 0x0263B838
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x0263B83A
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B83C
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79365
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData128<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in EntityData128<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79366
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData128(int initialCapacity = 128 /* Metadata: 0x0263B834 */, bool autoExtend = false /* Metadata: 0x0263B836 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 256, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData256<T> : IEnumerable<T> // TypeDefIndex: 79370
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0263B840
		public const int CAPACITY = 256; // Metadata: 0x0263B841
		public const int CAPACITY_MINUS_ONE = 255; // Metadata: 0x0263B843
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B845
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79368
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData256<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in EntityData256<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79369
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData256(int initialCapacity = 256 /* Metadata: 0x0263B83D */, bool autoExtend = false /* Metadata: 0x0263B83F */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 512, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData512<T> : IEnumerable<T> // TypeDefIndex: 79373
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0263B849
		public const int CAPACITY = 512; // Metadata: 0x0263B84A
		public const int CAPACITY_MINUS_ONE = 511; // Metadata: 0x0263B84C
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B84E
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79371
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData512<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in EntityData512<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79372
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData512(int initialCapacity = 512 /* Metadata: 0x0263B846 */, bool autoExtend = false /* Metadata: 0x0263B848 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 1024, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData1024<T> : IEnumerable<T> // TypeDefIndex: 79376
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0263B852
		public const int CAPACITY = 1024; // Metadata: 0x0263B853
		public const int CAPACITY_MINUS_ONE = 1023; // Metadata: 0x0263B855
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B857
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79374
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private EntityData1024<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in EntityData1024<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79375
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData1024(int initialCapacity = 1024 /* Metadata: 0x0263B84F */, bool autoExtend = false /* Metadata: 0x0263B851 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	public struct EnvGeneratorRendererInfo // TypeDefIndex: 79377
	{
		// Fields
		public float3 pos; // 0x00
		public float placeHolder; // 0x0C
		public float4 atlasUV; // 0x10
	}

	[DataN(capacity = 6, tSize = 16, ring = false)]
	[NoAlias]
	public struct Float4Data6<T> : IEnumerable<T> // TypeDefIndex: 79380
		where T : struct
	{
		// Fields
		public const int T_SIZE = 16; // Metadata: 0x0263B85A
		public const int CAPACITY = 8; // Metadata: 0x0263B85B
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x0263B85C
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B85D
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79378
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private Float4Data6<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in Float4Data6<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79379
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe Float4Data6(int initialCapacity = 8 /* Metadata: 0x0263B858 */, bool autoExtend = false /* Metadata: 0x0263B859 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 16, tSize = 16, ring = false)]
	[NoAlias]
	public struct Float4Data16<T> : IEnumerable<T> // TypeDefIndex: 79383
		where T : struct
	{
		// Fields
		public const int T_SIZE = 16; // Metadata: 0x0263B860
		public const int CAPACITY = 16; // Metadata: 0x0263B861
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x0263B862
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B863
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79381
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private Float4Data16<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in Float4Data16<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79382
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe Float4Data16(int initialCapacity = 16 /* Metadata: 0x0263B85E */, bool autoExtend = false /* Metadata: 0x0263B85F */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 8, tSize = 4, ring = false)]
	[NoAlias]
	public struct IntData8<T> : IEnumerable<T> // TypeDefIndex: 79386
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x0263B866
		public const int CAPACITY = 8; // Metadata: 0x0263B867
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x0263B868
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B869
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79384
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private IntData8<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in IntData8<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79385
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe IntData8(int initialCapacity = 8 /* Metadata: 0x0263B864 */, bool autoExtend = false /* Metadata: 0x0263B865 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 32, tSize = 4, ring = false)]
	[NoAlias]
	public struct IntData32<T> : IEnumerable<T> // TypeDefIndex: 79389
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x0263B86C
		public const int CAPACITY = 32; // Metadata: 0x0263B86D
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x0263B86E
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B86F
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79387
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private IntData32<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in IntData32<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79388
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe IntData32(int initialCapacity = 32 /* Metadata: 0x0263B86A */, bool autoExtend = false /* Metadata: 0x0263B86B */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	public struct LogisticsExtContainer // TypeDefIndex: 79391
	{
		// Nested types
		public struct LogisticsExtData // TypeDefIndex: 79390
		{
		}
	}

	public struct OutputRendererInfo // TypeDefIndex: 79392
	{
		// Fields
		public float3 outputPos; // 0x00
		public bool enableLiquidIcon; // 0x0C
		public bool depthBlendDisabled; // 0x0D
		public half4 color; // 0x10
		public half4 atlasRect; // 0x18
		public half4 liquidAtlasUV; // 0x20
	}

	[DataN(capacity = 16, tSize = 64, ring = false)]
	[NoAlias]
	public struct PortData16<T> : IEnumerable<T> // TypeDefIndex: 79395
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0263B872
		public const int CAPACITY = 16; // Metadata: 0x0263B874
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x0263B875
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B876
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79393
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PortData16<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in PortData16<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79394
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe PortData16(int initialCapacity = 16 /* Metadata: 0x0263B870 */, bool autoExtend = false /* Metadata: 0x0263B871 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 32, tSize = 64, ring = false)]
	[NoAlias]
	public struct PortData32<T> : IEnumerable<T> // TypeDefIndex: 79398
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0263B879
		public const int CAPACITY = 32; // Metadata: 0x0263B87B
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x0263B87C
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B87D
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79396
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PortData32<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in PortData32<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79397
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe PortData32(int initialCapacity = 32 /* Metadata: 0x0263B877 */, bool autoExtend = false /* Metadata: 0x0263B878 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 128, tSize = 64, ring = false)]
	[NoAlias]
	public struct PortData128<T> : IEnumerable<T> // TypeDefIndex: 79401
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0263B881
		public const int CAPACITY = 128; // Metadata: 0x0263B883
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x0263B885
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B887
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79399
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PortData128<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in PortData128<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79400
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe PortData128(int initialCapacity = 128 /* Metadata: 0x0263B87E */, bool autoExtend = false /* Metadata: 0x0263B880 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 256, tSize = 64, ring = false)]
	[NoAlias]
	public struct PortData256<T> : IEnumerable<T> // TypeDefIndex: 79404
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0263B88B
		public const int CAPACITY = 256; // Metadata: 0x0263B88D
		public const int CAPACITY_MINUS_ONE = 255; // Metadata: 0x0263B88F
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B891
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79402
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PortData256<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in PortData256<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79403
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe PortData256(int initialCapacity = 256 /* Metadata: 0x0263B888 */, bool autoExtend = false /* Metadata: 0x0263B88A */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	public struct SharedDataContainer // TypeDefIndex: 79408
	{
		// Fields
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref SharedExtData this[int index] { get => default; } // 0x0000000188CD40A8-0x0000000188CD40EC 
		public ref SharedExtData this[uint index] { get => default; } // 0x0000000187239B30-0x0000000187239B40 
	
		// Nested types
		public struct SharedExtData // TypeDefIndex: 79405
		{
			// Fields
			public uint next; // 0x00
			public int pendingSlotId; // 0x04
			public uint nodeId; // 0x08
			public ChapterTagFragment chapter; // 0x0C
			[NativeDisableContainerSafetyRestriction]
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
			public Visibility colliderVisibility; // 0x568
			public AdditiveEffectFragment additiveEffect; // 0x580
			public bool inMainRegion; // 0xDD0
	
			// Properties
			public bool visible { get; } // 0x000000018509B9B0-0x000000018509BA40 
			public bool visibleAdditiveMat { get; } // 0x00000001850AE980-0x00000001850AEA10 
			public bool visibleCollider { get; } // 0x00000001864A1420-0x00000001864A1480 
	
			// Methods
			public bool IsDirty(DirtyFlag f); // 0x0000000188CD40EC-0x0000000188CD40F8
			public void SetDirty(DirtyFlag f, bool d); // 0x0000000186722A80-0x0000000186722AA0
			public bool IsPendingUnit(); // 0x00000001857A37E0-0x00000001857A37F0
		}
	
		[Flags]
		public enum DirtyFlag // TypeDefIndex: 79406
		{
			NONE = 0,
			STATUS_CHANGE = 1,
			VAT_UPDATE = 2,
			UPDATE_STATUS_EFFECT = 4,
			CULL_STATUS_CHANGE = 8,
			RENDERER_VISIBLE = 16,
			ALL = 255
		}
	
		internal struct Node // TypeDefIndex: 79407
		{
			// Fields
			public SharedExtData value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public SharedDataContainer(Unity.Collections.Allocator allocator); // 0x00000001861FB6D0-0x00000001861FB780
	
		// Methods
		public void Dispose(); // 0x0000000188CD3F00-0x0000000188CD3F3C
		public void FlushPendingFree(); // 0x0000000185F71F40-0x0000000185F71FC0
		public uint Size(); // 0x0000000184431980-0x0000000184431990
		public Span<SharedExtData> AsSpan(); // 0x0000000188CD3E7C-0x0000000188CD3EEC
		public uint Create(ref SharedExtData value); // 0x000000018565EE50-0x000000018565EF00
		public void Destroy(uint handle); // 0x0000000185869220-0x0000000185869280
		public void Reset(); // 0x0000000188CD3FE4-0x0000000188CD404C
		public void Reserve(uint newCapacity); // 0x0000000188CD3F9C-0x0000000188CD3FE4
		public IntPtr Data(); // 0x0000000184431970-0x0000000184431980
		public ref SharedExtData Get(uint handle); // 0x0000000187239B30-0x0000000187239B40
		public SharedExtData GetValue(uint handle); // 0x0000000188CD3F3C-0x0000000188CD3F9C
		public void SetValue(uint handle, SharedExtData v); // 0x0000000188CD404C-0x0000000188CD40A8
		public uint CreateValue(SharedExtData value); // 0x0000000188CD3EEC-0x0000000188CD3F00
	}

	public struct StaticMountInfo // TypeDefIndex: 79409
	{
		// Fields
		public Entity rendererEntity; // 0x00
		public FactoryUnitExtendConfig mountConfig; // 0x08
	}

	[DataN(capacity = 16, tSize = 80, ring = false)]
	[NoAlias]
	public struct StaticMountInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 79412
		where T : struct
	{
		// Fields
		public const int T_SIZE = 80; // Metadata: 0x0263B89C
		public const int CAPACITY = 16; // Metadata: 0x0263B89E
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x0263B89F
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B8A0
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79410
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private StaticMountInfoCollection<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in StaticMountInfoCollection<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79411
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe StaticMountInfoCollection(int initialCapacity = 16 /* Metadata: 0x0263B89A */, bool autoExtend = false /* Metadata: 0x0263B89B */);
	
		// Methods
		public unsafe T* GetDataPtr();
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 12, tSize = 128, ring = false)]
	[NoAlias]
	public struct UnitExtendConfig12<T> : IEnumerable<T> // TypeDefIndex: 79415
		where T : struct
	{
		// Fields
		public const int T_SIZE = 128; // Metadata: 0x0263B8A3
		public const int CAPACITY = 16; // Metadata: 0x0263B8A5
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x0263B8A6
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B8A7
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79413
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private UnitExtendConfig12<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in UnitExtendConfig12<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79414
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe UnitExtendConfig12(int initialCapacity = 16 /* Metadata: 0x0263B8A1 */, bool autoExtend = false /* Metadata: 0x0263B8A2 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	public struct WireRendererInfo // TypeDefIndex: 79416
	{
		// Fields
		public float3 fromPos; // 0x00
		public float3 toPos; // 0x0C
		public ulong connectionId; // 0x18
		public float alpha; // 0x20
	
		// Properties
		public float3 pos { get; } // 0x0000000188CD40F8-0x0000000188CD4178 
		public quaternion rot { get; } // 0x0000000188CD4178-0x0000000188CD4268 
		public float scale { get; } // 0x0000000188CD4268-0x0000000188CD42A4 
	}

	[DataN(capacity = 512, tSize = 48, ring = false, native = true)]
	[NoAlias]
	public struct WireRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 79418
		where T : struct
	{
		// Fields
		public const int T_SIZE = 48; // Metadata: 0x0263B8AB
		public const int CAPACITY = 512; // Metadata: 0x0263B8AC
		public const int CAPACITY_MINUS_ONE = 511; // Metadata: 0x0263B8AE
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B8B0
		private int m_beginIndex;
		private int m_endIndex;
		private unsafe byte* m_data;
		private Unity.Collections.Allocator m_allocator;
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79417
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private WireRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in WireRendererInfoCollection<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		// Constructors
		public unsafe WireRendererInfoCollection(int initialCapacity = 512 /* Metadata: 0x0263B8A8 */, bool autoExtend = false /* Metadata: 0x0263B8AA */);
	
		// Methods
		public unsafe T* GetDataPtr();
		public static unsafe WireRendererInfoCollection<T>* Create(Unity.Collections.Allocator allocator);
		public void SafeDispose();
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	public class EntitySearcher // TypeDefIndex: 79419
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private NativeParallelHashMap<UnitId, Entity> m_logicEntityMap; // 0x10
	
		// Constructors
		public EntitySearcher(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public NativeParallelHashMap<UnitId, Entity> GetLogicEntityMap(); // 0x0000000184430480-0x0000000184430490
		public void RegisterLogicEntity(int chapterId, uint nodeId, Entity entity); // 0x00000001858BC280-0x00000001858BC390
		public bool UnregisterLogicEntity(int chapterId, uint nodeId); // 0x0000000186B198E0-0x0000000186B19970
		public bool GetLogicEntity(int chapterId, uint nodeId, out Entity entity); // 0x0000000185145580-0x0000000185145730
		private void _DestroyAllEntities(); // 0x0000000188CD2840-0x0000000188CD28B8
		public void DestroyAll(); // 0x0000000188CD2838-0x0000000188CD2840
	}

	public struct EventChannel<T> : IDisposable // TypeDefIndex: 79422
		where T : struct
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		private unsafe T* m_buffer;
		private int m_count;
		private int m_capacity;
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		private unsafe T* m_concurrentBuffer;
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		private unsafe int* m_concurrentCountPtr;
		private int m_concurrentCapacity;
		private static readonly int S_SIZE_OF_T;
		private static readonly int S_ALIGN_OF_T;
	
		// Properties
		public int count { get; }
		public bool hasEvents { get; }
	
		// Nested types
		[IsReadOnly]
		public struct Reader // TypeDefIndex: 79420
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			[NoAlias]
			internal readonly unsafe T* mBuffer;
			internal readonly int mLength;
	
			// Properties
			public int length { get; }
			public T this[int index] { get => default; }
	
			// Constructors
			internal unsafe Reader(T* buffer, int length);
		}
	
		public struct ParallelWriter // TypeDefIndex: 79421
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			[NoAlias]
			internal unsafe T* mBuffer;
			internal int mCapacity;
			[NativeDisableUnsafePtrRestriction]
			[NoAlias]
			internal unsafe int* mCountPtr;
	
			// Methods
			public void Enqueue(T evt);
		}
	
		// Constructors
		static EventChannel();
	
		// Methods
		public static EventChannel<T> Create(int initialCapacity = 16 /* Metadata: 0x0263B8B1 */);
		public void Enqueue(T evt);
		private void _Grow(int newCapacity);
		public void PrepareConcurrentWrites(int capacity);
		public ParallelWriter AsParallelWriter();
		public void FlushConcurrentWrites();
		private void _EnsureCapacity(int required);
		public NativeArray<T> GetEvents();
		public Reader AsReader();
		public void Clear();
		public void Dispose();
	}

	public static class EventChannelAccessor // TypeDefIndex: 79423
	{
		// Methods
		public static void InitEventChannels(ref GlobalEnv env); // 0x0000000186BE2F60-0x0000000186BE3100
		public static void DisposeEventChannels(ref GlobalEnv env); // 0x0000000188CD7D34-0x0000000188CD7D88
		public static void ClearAll(ref GlobalEnv env); // 0x0000000188CD7D24-0x0000000188CD7D34
		public static bool HasStatusChangeEvents(ref GlobalEnv env); // 0x0000000186124AD0-0x0000000186124B10
		public static bool HasUpdatePipeEffectEvents(ref GlobalEnv env); // 0x0000000186124BB0-0x0000000186124BF0
		public static bool HasChangeTemplateEvents(ref GlobalEnv env); // 0x0000000185C9CCD0-0x0000000185C9CD10
		public static bool HasCreateUnitRendererEvents(ref GlobalEnv env); // 0x0000000185C9CDD0-0x0000000185C9CE10
		public static bool HasPendingCreateRendererEvents(ref GlobalEnv env); // 0x0000000188CD7E40-0x0000000188CD7EA0
		public static bool HasUpdateStatusEffectEvents(ref GlobalEnv env); // 0x0000000185C9CEE0-0x0000000185C9CF20
		public static bool HasUpdateRendererPropertyEvents(ref GlobalEnv env); // 0x00000001856246C0-0x0000000185624700
		public static bool HasUpdatePedestalColorLUTEvents(ref GlobalEnv env); // 0x0000000186124C90-0x0000000186124CD0
		public static bool HasChangeCropTemplateEvents(ref GlobalEnv env); // 0x0000000185C9CBA0-0x0000000185C9CC10
		public static bool HasCreateInteractEvents(ref GlobalEnv env); // 0x0000000186124D70-0x0000000186124DB0
		public static EventChannel<EvtStatusChange> GetStatusChangeEventReader(ref GlobalEnv env); // 0x0000000185676BA0-0x0000000185676C60
		public static NativeArray<EvtStatusChange> GetStatusChangeEvents(ref GlobalEnv env); // 0x0000000188CD7DDC-0x0000000188CD7E40
		public static NativeArray<EvtAudio> GetAudioEvents(ref GlobalEnv env); // 0x000000018598D2D0-0x000000018598D380
		public static NativeArray<EvtChangeTemplate> GetChangeTemplateEvents(ref GlobalEnv env); // 0x0000000187186D60-0x0000000187186DF0
		public static NativeArray<EvtUpdatePipeEffect> GetUpdatePipeEffectEvents(ref GlobalEnv env); // 0x00000001869FADF0-0x00000001869FAE80
		public static NativeArray<EvtCreateUnitRenderer> GetCreateUnitRendererEvents(ref GlobalEnv env); // 0x0000000186F82620-0x0000000186F826B0
		public static NativeArray<EvtVatUpdate> GetVatUpdateEvents(ref GlobalEnv env); // 0x00000001857AA0E0-0x00000001857AA190
		public static NativeArray<EvtUpdateStatusEffect> GetUpdateStatusEffectEvents(ref GlobalEnv env); // 0x00000001863EA470-0x00000001863EA500
		public static NativeArray<EvtUpdateRendererProperty> GetUpdateRendererPropertyEvents(ref GlobalEnv env); // 0x0000000187186CD0-0x0000000187186D60
		public static NativeArray<EvtUpdatePedestalColorLUT> GetUpdatePedestalColorLUTEvents(ref GlobalEnv env); // 0x00000001870BF440-0x00000001870BF4D0
		public static NativeArray<EvtCreateInteract> GetCreateInteractEvents(ref GlobalEnv env); // 0x0000000186C3F170-0x0000000186C3F210
		public static NativeArray<EvtPendingCreateRenderer> GetPendingCreateRendererEvents(ref GlobalEnv env); // 0x00000001857ADEC0-0x00000001857ADF70
		public static NativeArray<EvtChangeCropTemplate> GetChangeCropTemplateEvents(ref GlobalEnv env); // 0x0000000185E55840-0x0000000185E55910
		public static void PrepareVatUpdateConcurrentWrites(ref GlobalEnv env, int capacity); // 0x00000001856762E0-0x0000000185676340
		public static void PrepareUpdateStatusEffectConcurrentWrites(ref GlobalEnv env, int capacity); // 0x0000000185676340-0x00000001856763A0
		public static void PrepareAudioConcurrentWrites(ref GlobalEnv env, int capacity); // 0x00000001856763A0-0x0000000185676400
		public static EventChannel<EvtVatUpdate> GetVatUpdateParallelWriter(ref GlobalEnv env); // 0x0000000185676B10-0x0000000185676BA0
		public static EventChannel<EvtUpdateStatusEffect> GetUpdateStatusEffectParallelWriter(ref GlobalEnv env); // 0x0000000185676A80-0x0000000185676B10
		public static EventChannel<EvtAudio> GetAudioParallelWriter(ref GlobalEnv env); // 0x00000001856769F0-0x0000000185676A80
		public static void FlushVatUpdateConcurrentWrites(ref GlobalEnv env); // 0x0000000185676400-0x0000000185676450
		public static void FlushUpdateStatusEffectConcurrentWrites(ref GlobalEnv env); // 0x0000000185676450-0x00000001856764A0
		public static void FlushAudioConcurrentWrites(ref GlobalEnv env); // 0x00000001856764A0-0x00000001856764F0
		public static int GetPendingCreateRendererCount(); // 0x0000000188CD7D88-0x0000000188CD7DDC
	}

	public struct FactoryEventChannels : IDisposable // TypeDefIndex: 79424
	{
		// Fields
		[CompilerGenerated]
		private static unsafe FactoryEventChannels* _instance_k__BackingField; // 0x00
		public EventChannel<EvtUpdatePipeEffect> updatePipeEffect; // 0x00
		public EventChannel<EvtChangeTemplate> changeTemplate; // 0x28
		public EventChannel<EvtCreateUnitRenderer> createUnitRenderer; // 0x50
		public EventChannel<EvtUpdateStatusEffect> updateStatusEffect; // 0x78
		public EventChannel<EvtPendingCreateRenderer> pendingCreateRenderer; // 0xA0
		public EventChannel<EvtUpdateRendererProperty> updateRendererProperty; // 0xC8
		public EventChannel<EvtStatusChange> statusChange; // 0xF0
		public EventChannel<EvtCreateInteract> createInteract; // 0x118
		public EventChannel<EvtVatUpdate> vatUpdate; // 0x140
		public EventChannel<EvtUpdatePedestalColorLUT> updatePedestalColorLUT; // 0x168
		public EventChannel<EvtAudio> audio; // 0x190
		public EventChannel<EvtChangeCropTemplate> changeCropTemplate; // 0x1B8
	
		// Properties
		public static unsafe FactoryEventChannels* instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000188CD82C4-0x0000000188CD82FC 0x0000000188CD82FC-0x0000000188CD8338
	
		// Methods
		public static unsafe void SetInstance(FactoryEventChannels* ptr); // 0x000000018783D304-0x000000018783D30C
		public static void ClearInstance(); // 0x0000000188CD8010-0x0000000188CD8018
		public static FactoryEventChannels Create(); // 0x0000000186BE3100-0x0000000186BE35E0
		public void ClearAll(); // 0x0000000185FC4010-0x0000000185FC4230
		public void Dispose(); // 0x0000000188CD8018-0x0000000188CD82C4
		public void Enqueue<T>(T evt)
			where T : struct, IFactoryEvent;
	}

	public static class MiscExtensions // TypeDefIndex: 79425
	{
		// Methods
		public static unsafe void SafeDestroy<T>(ref UnsafeList<T>* list)
			where T : struct;
		public static unsafe void SafeDestroy(ref ConveyorInfoAllocator* allocator); // 0x0000000188CDCD20-0x0000000188CDCD48
	
		// Extension methods
		public static void SafeDispose<T>(this NativeList<T> list)
			where T : struct;
		public static void SafeDispose<T>(this NativeArray<T> array)
			where T : struct;
		public static void SafeDispose<T>(this NativeQueue<T> queue)
			where T : struct;
		public static void SafeDispose<T>(this UnsafeList<T> list)
			where T : struct;
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> list)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct;
		public static void SafeDispose<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> list)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct;
	}

	public class FacBoneTRSBinary : IDisposable // TypeDefIndex: 79426
	{
		// Fields
		private static FacBoneTRSBinary s_instance; // 0x00
		private RefMultiHashTable<long, FacBoneTRSUnitEntry> m_unitTable; // 0x10
		private MMapHelper.MMapViewInfo m_mmpHandle; // 0x30
		private IntPtr m_basePtr; // 0x38
		private bool m_isReady; // 0x40
	
		// Properties
		public static FacBoneTRSBinary instance { get; } // 0x00000001860E7520-0x00000001860E75A0 
		public bool isReady { get; } // 0x000000018225DFB0-0x000000018225DFC0 
	
		// Constructors
		public FacBoneTRSBinary(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void InitMain(); // 0x0000000186D10CE0-0x0000000186D113C0
		private void _InitTable(); // 0x0000000186D11400-0x0000000186D114C0
		public bool TryGetBoneTRS(int guid, ulong boneNameHash, uint frame, out Matrix4x4 trs); // 0x00000001860E7E20-0x00000001860E7F70
		private void _DisposeResources(); // 0x0000000186D113C0-0x0000000186D11400
		public void Dispose(); // 0x0000000188CD7F78-0x0000000188CD7F94
		~FacBoneTRSBinary(); // 0x0000000188CD7F94-0x0000000188CD8010
	}

	public struct FacBoneTRSUnitEntry // TypeDefIndex: 79427
	{
		// Fields
		public long hashKey; // 0x00
		public int boneCount; // 0x08
		public int bonesOffset; // 0x0C
	}

	public struct FacBoneTRSBoneEntry // TypeDefIndex: 79428
	{
		// Fields
		public ulong boneNameHash; // 0x00
		public int trsCount; // 0x08
		public int trsOffset; // 0x0C
	}

	public sealed class LongComparer : IRefComparer<long> // TypeDefIndex: 79429
	{
		// Constructors
		public LongComparer(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public long GetHashCode(long key); // 0x000000018459BB50-0x000000018459BB60
	}

	public static class FactoryProfilerMakers // TypeDefIndex: 79430
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
		static FactoryProfilerMakers(); // 0x0000000186C42FC0-0x0000000186C434C0
	}

	public static class FactorySharedDataManager // TypeDefIndex: 79431
	{
		// Fields
		private static ConveyorExtContainer s_conveyorExtData; // 0x00
		private static SharedDataContainer s_sharedData; // 0x28
		private static EntityHierarchyContainer s_hierarchy; // 0x50
		private static VATFSMDefinitionContainer s_vatFsm; // 0x58
		private static BlueprintSlotContainer s_blueprintSlot; // 0x80
	
		// Methods
		public static void InitExtData(); // 0x00000001861FA780-0x00000001861FA950
		public static void ResetExtData(); // 0x0000000188CD852C-0x0000000188CD85D4
		public static void ReleaseExtData(); // 0x0000000188CD8484-0x0000000188CD852C
		public static void FlushDeferredFree(); // 0x0000000185F71C20-0x0000000185F71E70
		public static uint CreateConveyorExtHandle(); // 0x0000000185871050-0x00000001858710B0
		public static void DestroyConveyorExtHandle(uint handle); // 0x0000000188CD8380-0x0000000188CD83C4
		public static ref ConveyorExtContainer.ConveyorExt GetConveyorExt(uint handle); // 0x0000000187239E60-0x0000000187239E80
		public static IntPtr GetConveyorExtData(); // 0x0000000187239E40-0x0000000187239E60
		public static uint CreateSharedData(bool adjustMapValid = true /* Metadata: 0x0263B8B2 */); // 0x000000018565EDD0-0x000000018565EE50
		public static ref SharedDataContainer.SharedExtData GetSharedData(uint handle); // 0x0000000187239EC0-0x0000000187239EE0
		public static SharedDataContainer.SharedExtData GetSharedDataCopy(uint handle); // 0x0000000188CD840C-0x0000000188CD8484
		public static void SetSharedDataValue(uint handle, SharedDataContainer.SharedExtData value); // 0x0000000188CD85D4-0x0000000188CD8648
		public static void DestroySharedData(uint handle); // 0x0000000185869280-0x00000001858692D0
		public static IntPtr GetSharedData(); // 0x0000000187239EA0-0x0000000187239EC0
		public static int GetSharedDataSize(); // 0x0000000187239E80-0x0000000187239EA0
		public static uint CreateTransHierarchy(); // 0x0000000185967640-0x00000001859676C0
		public static ref EntityHierarchyContainer.EntityTransformData GetHierarchyData(uint handle); // 0x0000000185736100-0x0000000185736140
		public static ref EntityHierarchyContainer.EntityTransformData GetHierarchyData(int handle); // 0x00000001859675B0-0x00000001859675F0
		public static float4x4 WorldTrans([IsReadOnly] in EntityHierarchyContainer.EntityTransformData transform); // 0x0000000188CD8648-0x0000000188CD8738
		public static void DestroyHierarchyData(uint handle); // 0x00000001867C49D0-0x00000001867C4A00
		public static IntPtr GetHierarchyData(); // 0x0000000185167C10-0x0000000185167C40
		public static int GetHierarchySize(); // 0x0000000186308850-0x0000000186308880
		public static uint CreateVATFSMDefinitionContainer(ref VATFSMDefinition definition); // 0x00000001861FB3E0-0x00000001861FB430
		public static ref VATFSMDefinition GetVATFSMDefinition(uint handle); // 0x0000000187239EE0-0x0000000187239F00
		public static void DestroyVATFSMDefinition(uint handle); // 0x0000000188CD83C4-0x0000000188CD840C
		public static IntPtr GetVATFSMDefinition(); // 0x0000000187239F00-0x0000000187239F20
		public static uint CreateBlueprintSlotInfo(); // 0x00000001856E8E30-0x00000001856E8EC0
		public static ref BlueprintSlotInfo GetBlueprintSlotInfo(uint handle); // 0x00000001870D3D80-0x00000001870D3DD0
		public static void DestroyBlueprintSlotInfo(uint handle); // 0x0000000188CD8338-0x0000000188CD8380
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ActivatorCostFragment : IComponentECS // TypeDefIndex: 79432
	{
		// Fields
		public bool isActive; // 0x00
		public int costItemFastId; // 0x04
		public int readyFormulaFastId; // 0x08
		public const int ID = 1; // Metadata: 0x0263B8B3
	
		// Properties
		public int id { get; } // 0x00000001872328C0-0x00000001872328D0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD4B80-0x0000000188CD4C5C
	}

	public struct AdditiveEffectFragment // TypeDefIndex: 79435
	{
		// Fields
		public byte entityType; // 0x00
		public uint lightMode; // 0x04
		public SoloSelectState soloSelectState; // 0x08
		public BuildDismissState buildDismissState; // 0x88
		public CutoffState cutoffState; // 0xA0
		public RepairState repairState; // 0xB0
		public HighLightState highLightState; // 0xD8
		public HintState hintState; // 0x164
		public FigureState figureState; // 0x170
		public OverloadState overloadState; // 0x17C
		public OverloadInvalidState overloadInvalidState; // 0x188
		public BlueprintState blueprintState; // 0x198
		public PreSelectState preSelectState; // 0x3C8
		public ContinuationState continuationState; // 0x5CA
		public SocialSharingState socialSharingState; // 0x7CC
		public PowerInteractionState powerInteractionState; // 0x7CD
		public InvalidOverlapPlaceState invalidOverlapPlaceState; // 0x7D0
		public SnowCoverageState snowCoverageState; // 0x7E0
		public BorderState borderState; // 0x800
		public Request curEffectRequest; // 0x802
		public AdditiveEffectRequestStack<Request> stateWaitStack; // 0x808
	
		// Properties
		public AdditiveEffectType curEffectType { get; set; } // 0x0000000187239B40-0x0000000187239B50 0x0000000187239B50-0x0000000187239B70
	
		// Nested types
		public struct Request // TypeDefIndex: 79433
		{
			// Fields
			public AdditiveEffectType type; // 0x00
			public short typeValue; // 0x00
			public AdditiveEffectType lastType; // 0x02
			public short lastTypeValue; // 0x02
		}
	
		public enum AdditiveEffectType : short // TypeDefIndex: 79434
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
			POWER_INTERACTION = 15,
			INVALID_OVERLAP_PLACE = 16,
			BORDER = 17,
			SNOW_COVERAGE = 18
		}
	
		// Methods
		public void PushState(AdditiveEffectType state); // 0x000000018586AE70-0x000000018586AEF0
		public void InsertState(int index, AdditiveEffectType state); // 0x000000018586ACC0-0x000000018586ADC0
		public AdditiveEffectType ShiftState(); // 0x0000000188CD4CC0-0x0000000188CD4D18
		public AdditiveEffectType PopState(); // 0x0000000188CD4C5C-0x0000000188CD4CC0
		public AdditiveEffectType PeekState(); // 0x0000000187837D10-0x0000000187837D24
		public void DisableState(AdditiveEffectType state); // 0x00000001850AE5D0-0x00000001850AE660
		private void _Shrink(); // 0x00000001850AE660-0x00000001850AE7D0
		[BurstDiscard]
		public override string ToString(); // 0x0000000188CD4D18-0x0000000188CD4E24
	}

	public struct CutoffState // TypeDefIndex: 79436
	{
		// Fields
		private bool m_enable; // 0x00
		public uint mode; // 0x04
		public float cutOffY; // 0x08
		[CompilerGenerated]
		private bool _enable_k__BackingField; // 0x0C
	
		// Properties
		public bool enable { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235A80-0x0000000187235A90 0x0000000187235A90-0x0000000187235AA0
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187235A90-0x0000000187235AA0
		public void SetCutoffY(float v); // 0x0000000188CD7A50-0x0000000188CD7AA8
		public void SetMode(uint v); // 0x0000000187235AB0-0x0000000187235AC0
	}

	public struct BuildDismissState // TypeDefIndex: 79438
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
		public enum BuildEffectType : byte // TypeDefIndex: 79437
		{
			DEFAULT = 0,
			TYPE1 = 1
		}
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
	}

	public struct RepairState // TypeDefIndex: 79439
	{
		// Fields
		public bool enable; // 0x00
		public RepairState0 state0; // 0x08
		public RepairState1 state1; // 0x18
	}

	public struct RepairState0 // TypeDefIndex: 79440
	{
		// Fields
		public bool enable; // 0x00
		public float duration; // 0x04
		public long startTms; // 0x08
	}

	public struct RepairState1 // TypeDefIndex: 79441
	{
		// Fields
		public bool enable; // 0x00
		public float duration; // 0x04
		public long startTms; // 0x08
	}

	public struct HighLightState // TypeDefIndex: 79442
	{
		// Fields
		public bool enable; // 0x00
		public bool invalid; // 0x01
		public bool social; // 0x02
		public FixedList128Bytes<byte> indexList; // 0x04
		public DitherState ditherState; // 0x84
	
		// Methods
		public void SetEnable(bool isEnable); // 0x0000000187233BE0-0x0000000187233BF0
		public void SetData(bool isInvalid, bool isSocial); // 0x0000000188CDB3F0-0x0000000188CDB404
		public LogicEntityState GetEffectType(); // 0x0000000188CDB2C0-0x0000000188CDB2DC
		public bool IsHighlight(byte index); // 0x0000000188CDB37C-0x0000000188CDB3F0
		public void HighlightWithSubIndex(byte index, bool en); // 0x0000000188CDB2DC-0x0000000188CDB37C
		public void ClearHighlightableIndexList(); // 0x0000000188CDB27C-0x0000000188CDB2C0
	}

	public struct HintState // TypeDefIndex: 79443
	{
		// Fields
		public bool enable; // 0x00
		public bool showSelf; // 0x01
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
	}

	public struct FigureState // TypeDefIndex: 79444
	{
		// Fields
		public bool valid; // 0x00
		public bool enable; // 0x01
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187239F70-0x0000000187239F80
	}

	public struct OverloadState // TypeDefIndex: 79445
	{
		// Fields
		public bool enable; // 0x00
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
	}

	public struct OverloadInvalidState // TypeDefIndex: 79446
	{
		// Fields
		public bool enable; // 0x00
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
	}

	public struct DitherState // TypeDefIndex: 79447
	{
		// Fields
		public bool enable; // 0x00
		public float ditherVal; // 0x04
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
	}

	public struct BlueprintState // TypeDefIndex: 79449
	{
		// Fields
		public bool enable; // 0x00
		public EffectType effectType; // 0x01
		public FixedList512Bytes<byte> indexList; // 0x02
		public CutoffState cutoffState; // 0x204
		public BuildDismissState buildState; // 0x218
	
		// Nested types
		public enum EffectType : byte // TypeDefIndex: 79448
		{
			NONE = 0,
			TO_BE_BUILD = 1,
			TO_BE_BUILD_SELECT = 2,
			MOVING = 3,
			MOVING_INVALID = 4,
			TO_BUILD_INVALID = 5
		}
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
		public void SetEnable(bool v, EffectType type); // 0x00000001844AD090-0x00000001844AD0A0
		public bool IsLighten(byte index); // 0x0000000188CD558C-0x0000000188CD5600
		public void LightenWithSubIndex(byte index, bool en); // 0x0000000188CD5600-0x0000000188CD56A0
		public void ClearLightenIndexList(); // 0x0000000188CD5564-0x0000000188CD558C
	}

	public struct PreSelectState // TypeDefIndex: 79450
	{
		// Fields
		public bool enable; // 0x00
		public FixedList512Bytes<byte> indexList; // 0x02
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
		public bool IsLighten(byte index); // 0x0000000188CDED90-0x0000000188CDEE04
		public void LightenWithSubIndex(byte index, bool en); // 0x0000000188CDEE04-0x0000000188CDEEA4
		public void ClearLightenIndexList(); // 0x0000000188CDED4C-0x0000000188CDED90
	}

	public struct SoloSelectState // TypeDefIndex: 79451
	{
		// Fields
		public FixedList128Bytes<byte> indexList; // 0x00
	
		// Properties
		public bool enable { get; } // 0x0000000188CDF78C-0x0000000188CDF7C8 
	
		// Methods
		public void SetEnable(bool v); // 0x0000000185D2FD20-0x0000000185D2FD80
		public bool IsLighten(byte index); // 0x0000000188CDF5A4-0x0000000188CDF5F4
		public void SelectWithSubIndex(byte index, bool en); // 0x0000000188CDF5F4-0x0000000188CDF694
		public void SelectWithSubIndices(byte[] indices, bool en); // 0x0000000188CDF694-0x0000000188CDF704
		public void SelectWithSubIndices(Span<byte> indices, bool en); // 0x0000000188CDF704-0x0000000188CDF78C
		public void ClearSelectedIndexList(); // 0x0000000188CDF564-0x0000000188CDF5A4
	}

	public struct ContinuationState // TypeDefIndex: 79452
	{
		// Fields
		public bool enable; // 0x00
		public FixedList512Bytes<byte> indexList; // 0x02
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
		public bool IsLighten(byte index); // 0x0000000188CD6BF0-0x0000000188CD6C64
		public void LightenWithSubIndex(byte index, bool en); // 0x0000000188CD6C64-0x0000000188CD6D04
		public void ClearLightenIndexList(); // 0x0000000188CD6BAC-0x0000000188CD6BF0
	}

	public struct SocialSharingState // TypeDefIndex: 79453
	{
		// Fields
		public bool enable; // 0x00
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
	}

	public struct PowerInteractionState // TypeDefIndex: 79454
	{
		// Fields
		public bool enable; // 0x00
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
	}

	public struct InvalidOverlapPlaceState // TypeDefIndex: 79455
	{
		// Fields
		public bool enable; // 0x00
		public DitherState ditherState; // 0x04
		public bool isTemporary; // 0x0C
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
	}

	public struct SnowCoverageState // TypeDefIndex: 79456
	{
		// Fields
		public bool enable; // 0x00
		public bool started; // 0x01
		public bool accumulate; // 0x02
		public bool hasSnow; // 0x03
		public float startIntensity; // 0x04
		public float targetIntensity; // 0x08
		public float currentIntensity; // 0x0C
		public float duration; // 0x10
		public long startTms; // 0x18
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
	}

	public struct BorderState // TypeDefIndex: 79457
	{
		// Fields
		public bool enable; // 0x00
	
		// Methods
		public void SetEnable(bool v); // 0x0000000187233BE0-0x0000000187233BF0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct AdditiveEffectRendererFragment : IComponentECS // TypeDefIndex: 79458
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
		private bool m_invalidOverlapPlaceState; // 0x12
		private bool m_snowCoverageEnabledState; // 0x13
		private bool m_snowCoveragePresentState; // 0x14
		private bool m_borderEnabledState; // 0x15
		public const int ID = 2; // Metadata: 0x0263B8E2
	
		// Properties
		public bool buildDismissEnabled { get; set; } // 0x00000001844AD300-0x00000001844AD310 0x0000000188CD4FA0-0x0000000188CD4FAC
		public bool blueprintBuildEnabled { get; set; } // 0x0000000187239B80-0x0000000187239B90 0x0000000188CD4F7C-0x0000000188CD4F88
		public bool blueprintBuildCutoffYEnabled { get; set; } // 0x0000000187239B70-0x0000000187239B80 0x0000000188CD4F70-0x0000000188CD4F7C
		public bool cutOffYIgnored { get; set; } // 0x0000000187239BC0-0x0000000187239BD0 0x0000000188CD4FB8-0x0000000188CD4FC4
		public bool cutoffYEnabled { get; set; } // 0x0000000187239BD0-0x0000000187239BE0 0x0000000188CD4FC4-0x0000000188CD4FD0
		public bool highLightEnabled { get; set; } // 0x0000000187239BF0-0x0000000187239C00 0x0000000188CD4FDC-0x0000000188CD4FE8
		public bool figureEnabled { get; set; } // 0x0000000187239BE0-0x0000000187239BF0 0x0000000188CD4FD0-0x0000000188CD4FDC
		public bool hintEnabled { get; set; } // 0x00000001844AD2B0-0x00000001844AD2C0 0x0000000188CD4FE8-0x0000000188CD4FF4
		public bool overloadEnabled { get; set; } // 0x0000000187239C00-0x0000000187239C10 0x0000000188CD5000-0x0000000188CD500C
		public bool overloadInvalidEnabled { get; set; } // 0x0000000187239C10-0x0000000187239C20 0x0000000188CD500C-0x0000000188CD5018
		public bool repair0Enabled { get; set; } // 0x0000000187239C30-0x0000000187239C40 0x0000000188CD5030-0x0000000188CD503C
		public bool repair1Enabled { get; set; } // 0x0000000187235A80-0x0000000187235A90 0x0000000188CD503C-0x0000000188CD5048
		public bool blueprintEnabled { get; set; } // 0x0000000187239B90-0x0000000187239BA0 0x0000000188CD4F88-0x0000000188CD4F94
		public bool preSelectEnabled { get; set; } // 0x0000000187239C20-0x0000000187239C30 0x0000000188CD5024-0x0000000188CD5030
		public bool continuationEnabled { get; set; } // 0x0000000187239BB0-0x0000000187239BC0 0x0000000188CD4FAC-0x0000000188CD4FB8
		public bool socialSharingEnabled { get; set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000188CD5060-0x0000000188CD506C
		public bool powerInteractionEnabled { get; set; } // 0x0000000187235410-0x0000000187235420 0x0000000188CD5018-0x0000000188CD5024
		public bool invalidOverlapPlaceEnabled { get; set; } // 0x0000000187235CB0-0x0000000187235CC0 0x0000000188CD4FF4-0x0000000188CD5000
		public bool snowCoverageEnabled { get; set; } // 0x0000000187239C40-0x0000000187239C50 0x0000000188CD5048-0x0000000188CD5054
		public bool snowCoveragePresent { get; set; } // 0x0000000187239C50-0x0000000187239C60 0x0000000188CD5054-0x0000000188CD5060
		public bool borderEnabled { get; set; } // 0x0000000187239BA0-0x0000000187239BB0 0x0000000188CD4F94-0x0000000188CD4FA0
		public bool anyEffect { get; } // 0x0000000188CD4F08-0x0000000188CD4F70 
		public int id { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD4E24-0x0000000188CD4F08
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BattleFragment : IComponentECS // TypeDefIndex: 79459
	{
		// Fields
		public bool overload; // 0x00
		public float currentEnergy; // 0x04
		public float maxEnergy; // 0x08
		public const int ID = 3; // Metadata: 0x0263B8E3
	
		// Properties
		public int id { get; } // 0x00000001872396E0-0x00000001872396F0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD5148-0x0000000188CD5224
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BindRenderEntityFragment : IComponentECS // TypeDefIndex: 79460
	{
		// Fields
		public EntityData512<Entity> renderEntities; // 0x00
		public const int ID = 4; // Metadata: 0x0263B8E4
	
		// Properties
		public int id { get; } // 0x00000001845BA780-0x00000001845BA790 
	
		// Methods
		public void BindRenderEntity(Entity renderEntity); // 0x00000001859681F0-0x0000000185968230
		public void BindRenderEntities(Entity[] renderEntityList); // 0x0000000188CD5224-0x0000000188CD5280
		public void BindRenderEntities(NativeArray<Entity> renderEntityList); // 0x0000000188CD5280-0x0000000188CD5394
		public void UnbindRenderEntity(Entity renderEntity); // 0x0000000188CD5394-0x0000000188CD5460
		public void ClearBindRenderEntities(); // 0x00000001872340E0-0x00000001872340F0
		public bool Binded(Entity renderEntity); // 0x0000000185968230-0x00000001859682C0
		public bool HasRenderer(); // 0x00000001857A8820-0x00000001857A8830
		private void __AOT_FOR_FIX__(); // 0x0000000188CD5460-0x0000000188CD5564
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BurnPowerFragment : IComponentECS // TypeDefIndex: 79461
	{
		// Fields
		public long currentLeastProgress; // 0x00
		public long powerGenPerSec; // 0x08
		public StringIntern.FastId burningItemIdFastId; // 0x10
		public const int ID = 5; // Metadata: 0x0263B8E5
	
		// Properties
		public string burningItemId { get; set; } // 0x0000000188CD5780-0x0000000188CD5788 0x0000000186B4BF90-0x0000000186B4BFF0
		public int id { get; } // 0x0000000187239C70-0x0000000187239C80 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD56A0-0x0000000188CD5780
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BusFragment : IComponentECS // TypeDefIndex: 79462
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 6; // Metadata: 0x0263B8E6
	
		// Properties
		public int id { get; } // 0x0000000187239C80-0x0000000187239C90 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD5788-0x0000000188CD5858
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BusFreeFragment : IComponentECS // TypeDefIndex: 79463
	{
		// Fields
		public bool connectToStart; // 0x00
		public bool enabled; // 0x01
		public const int ID = 7; // Metadata: 0x0263B8E7
	
		// Properties
		public int id { get; } // 0x0000000187239C90-0x0000000187239CA0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD5858-0x0000000188CD5930
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct CacheFragment : IComponentECS // TypeDefIndex: 79471
	{
		// Fields
		private const int CONTAINER_OFFSET = 16; // Metadata: 0x0263B8E8
		private const int ITEM_SIZE = 16; // Metadata: 0x0263B8E9
		public unsafe fixed /* 0x00000000-0x00000000 */ byte cacheSizePtr[0]; // 0x00
		public byte cacheIn0Size; // 0x00
		public byte cacheIn1Size; // 0x01
		public byte cacheIn2Size; // 0x02
		public byte cacheIn3Size; // 0x03
		public byte cacheOut0Size; // 0x04
		public byte cacheOut1Size; // 0x05
		public byte cacheOut2Size; // 0x06
		public byte cacheOut3Size; // 0x07
		public unsafe fixed /* 0x00000000-0x00000000 */ byte cacheFluidSizePtr[0]; // 0x08
		public byte cacheFluidIn0Size; // 0x08
		public byte cacheFluidIn1Size; // 0x09
		public byte cacheFluidIn2Size; // 0x0A
		public byte cacheFluidIn3Size; // 0x0B
		public byte cacheFluidOut0Size; // 0x0C
		public byte cacheFluidOut1Size; // 0x0D
		public byte cacheFluidOut2Size; // 0x0E
		public byte cacheFluidOut3Size; // 0x0F
		public unsafe fixed /* 0x00000000-0x00000000 */ int cacheContentPtr[0]; // 0x10
		public unsafe fixed /* 0x00000000-0x00000000 */ int itemInPtr[0]; // 0x10
		public FactoryItem in0; // 0x10
		public FactoryItem in1; // 0x20
		public FactoryItem in2; // 0x30
		public FactoryItem in3; // 0x40
		public FactoryItem in4; // 0x50
		public FactoryItem in5; // 0x60
		public FactoryItem in6; // 0x70
		public FactoryItem in7; // 0x80
		public unsafe fixed /* 0x00000000-0x00000000 */ int itemOutPtr[0]; // 0x90
		public FactoryItem out0; // 0x90
		public FactoryItem out1; // 0xA0
		public FactoryItem out2; // 0xB0
		public FactoryItem out3; // 0xC0
		public FactoryItem out4; // 0xD0
		public FactoryItem out5; // 0xE0
		public FactoryItem out6; // 0xF0
		public FactoryItem out7; // 0x100
		public unsafe fixed /* 0x00000000-0x00000000 */ int fluidInPtr[0]; // 0x110
		public FactoryItem fluidIn0; // 0x110
		public FactoryItem fluidIn1; // 0x120
		public FactoryItem fluidIn2; // 0x130
		public FactoryItem fluidIn3; // 0x140
		public FactoryItem fluidIn4; // 0x150
		public FactoryItem fluidIn5; // 0x160
		public FactoryItem fluidIn6; // 0x170
		public FactoryItem fluidIn7; // 0x180
		public unsafe fixed /* 0x00000000-0x00000000 */ int fluidOutPtr[0]; // 0x190
		public FactoryItem fluidOut0; // 0x190
		public FactoryItem fluidOut1; // 0x1A0
		public FactoryItem fluidOut2; // 0x1B0
		public FactoryItem fluidOut3; // 0x1C0
		public FactoryItem fluidOut4; // 0x1D0
		public FactoryItem fluidOut5; // 0x1E0
		public FactoryItem fluidOut6; // 0x1F0
		public FactoryItem fluidOut7; // 0x200
		public const int ID = 8; // Metadata: 0x0263B8EA
	
		// Properties
		public int id { get; } // 0x0000000187239CB0-0x0000000187239CC0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _cacheSizePtr_e__FixedBuffer // TypeDefIndex: 79464
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _cacheFluidSizePtr_e__FixedBuffer // TypeDefIndex: 79465
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _cacheContentPtr_e__FixedBuffer // TypeDefIndex: 79466
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _itemInPtr_e__FixedBuffer // TypeDefIndex: 79467
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _itemOutPtr_e__FixedBuffer // TypeDefIndex: 79468
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _fluidInPtr_e__FixedBuffer // TypeDefIndex: 79469
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _fluidOutPtr_e__FixedBuffer // TypeDefIndex: 79470
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		// Methods
		public void GetCacheItem(bool inOut, bool isFluid, int cacheIndex, int indexInCache, out uint itemId, out int itemAmount, out long tms); // 0x00000001865BCF20-0x00000001865BCFB0
		public void SetCacheItem(bool inOut, bool isFluid, int cacheIndex, int indexInCache, uint itemId, int itemAmount, long tms); // 0x000000018593DD80-0x000000018593DE10
		public void SetCacheSize(bool inOut, bool isFluid, int cacheIndex, int sizeCount); // 0x000000018593DE80-0x000000018593DEB0
		public unsafe int CalcIndex(bool inOut, bool isFluid, int cacheIndex, int indexInCache, out FactoryItem* ptr); // 0x000000018593DE10-0x000000018593DE80
		private void __AOT_FOR_FIX__(); // 0x0000000188CD5A04-0x0000000188CD5B00
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CacheTransportFragment : IComponentECS // TypeDefIndex: 79472
	{
		// Fields
		public bool autoTransport; // 0x00
		public bool inUse; // 0x01
		public float currentProgress; // 0x04
		public float totalProgress; // 0x08
		public const int ID = 9; // Metadata: 0x0263B8EB
	
		// Properties
		public int id { get; } // 0x0000000187239CC0-0x0000000187239CD0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD5B00-0x0000000188CD5BDC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CargoFragment : IComponentECS, IUnitConfigRef, IComparable<CargoFragment> // TypeDefIndex: 79474
	{
		// Fields
		public bool arrived; // 0x00
		public bool enter; // 0x01
		public float predictPos; // 0x04
		public long tms; // 0x08
		public float adjustTms; // 0x10
		public float moveSpeed; // 0x14
		public int minDist; // 0x18
		public int conveyorLength; // 0x1C
		public float3 position; // 0x20
		public quaternion rotation; // 0x2C
		public bool serverArrived; // 0x3C
		public bool isLiquidItem; // 0x3D
		public uint conveyorExtHandle; // 0x40
		public int cargoIndex; // 0x44
		public float4 itemUV; // 0x48
		public float4 itemLiquidUV; // 0x58
		public int indexInRendererList; // 0x68
		public uint conveyorId; // 0x6C
		public StringIntern.FastId itemFastId; // 0x70
		public int unitConfigAssetInstanceId; // 0x74
		public const int ID = 10; // Metadata: 0x0263B8EC
	
		// Properties
		public string itemId { get; set; } // 0x0000000188CD5D7C-0x0000000188CD5D84 0x0000000187837104-0x0000000187837120
		public int unitAssetInstanceId { get; set; } // 0x0000000187233390-0x00000001872333A0 0x00000001872333F0-0x0000000187233400
		public bool recyclable { get; } // 0x0000000188CD5D84-0x0000000188CD5D94 
		public int id { get; } // 0x0000000187239CD0-0x0000000187239CE0 
	
		// Nested types
		public struct ItemUV // TypeDefIndex: 79473
		{
			// Fields
			public bool isLiquid; // 0x00
			public int4 itemAtlasRect; // 0x04
			public int4 liquidAtlasRect; // 0x14
		}
	
		// Methods
		public float PredictPos(long serverTime); // 0x0000000188CD5C54-0x0000000188CD5C90
		public float PredictPosWithDeltaTime(long deltaTime); // 0x0000000188CD5C38-0x0000000188CD5C54
		public int CompareTo(CargoFragment other); // 0x0000000188CD5BDC-0x0000000188CD5BEC
		public unsafe bool GetVisible(CargoRendererInfoCollection<CargoRendererInfo>* rendererList); // 0x0000000188CD5BEC-0x0000000188CD5C38
		public static CargoFragment Create(uint unitId, int4 itemAtlasRect, int4 liquidAtlasRect, string itemId, int conveyorSpeed, long tms, int conveyorLength, float minDis, bool isLiquidItem); // 0x0000000185663060-0x00000001856631A0
		private void __AOT_FOR_FIX__(); // 0x0000000188CD5C90-0x0000000188CD5D7C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CargoRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79475
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 11; // Metadata: 0x0263B8ED
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x0000000187239CE0-0x0000000187239CF0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD5D94-0x0000000188CD5E68
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ChapterFragment : IComponentECS // TypeDefIndex: 79476
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
		public uint blueprintSlotHandle; // 0x3C
		public const int ID = 12; // Metadata: 0x0263B8EE
	
		// Properties
		public ref BlueprintSlotInfo blueprintSlotInfo { get; } // 0x00000001878373BC-0x00000001878373C8 
		public int id { get; } // 0x0000000187239CF0-0x0000000187239D00 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD5E68-0x0000000188CD5F48
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CollectorFragment : IComponentECS // TypeDefIndex: 79477
	{
		// Fields
		public long currentProgress; // 0x00
		public uint collectItem; // 0x08
		public const int ID = 13; // Metadata: 0x0263B8EF
	
		// Properties
		public int id { get; } // 0x0000000187239D00-0x0000000187239D10 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD5F48-0x0000000188CD6020
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct ConnectionFragment : IComponentECS // TypeDefIndex: 79479
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
		public const int ID = 14; // Metadata: 0x0263B8F0
	
		// Properties
		public bool valid { get; } // 0x0000000185A5A7B0-0x0000000185A5A890 
		public int id { get; } // 0x0000000187239D20-0x0000000187239D30 
	
		// Nested types
		public enum RendererType : byte // TypeDefIndex: 79478
		{
			NORMAL = 0,
			HS = 1
		}
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD6AC8-0x0000000188CD6BAC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorFragment : IComponentECS, ILogisticSample // TypeDefIndex: 79481
	{
		// Fields
		public uint factoryUnitId; // 0x00
		public float speed; // 0x04
		public UnityEngine.Rect bounds; // 0x08
		[CompilerGenerated]
		private int _length_k__BackingField; // 0x18
		public uint startMemoryOffsetHandle; // 0x1C
		public uint endMemoryOffsetHandle; // 0x20
		public const int ID = 15; // Metadata: 0x0263B8F7
	
		// Properties
		public int length { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public int id { get; } // 0x0000000187239D30-0x0000000187239D40 
	
		// Nested types
		public enum ProtoType : byte // TypeDefIndex: 79480
		{
			LEFT = 0,
			MID = 1,
			RIGHT = 2
		}
	
		// Methods
		public void SetInflection(ref GlobalEnv env, ref NativeList<float3> p, ref NativeList<float3> r, ref NativeArray<byte> proto); // 0x0000000185870CE0-0x0000000185870E70
		public static void CalcRect(NativeList<float3> posList, ref UnityEngine.Rect b); // 0x0000000185870E70-0x0000000185870FE0
		public bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInConveyor); // 0x0000000188CD71A8-0x0000000188CD72BC
		public bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax); // 0x0000000188CD7068-0x0000000188CD71A8
		public bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex); // 0x0000000188CD6EC4-0x0000000188CD7068
		public bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets); // 0x0000000188CD6D04-0x0000000188CD6EC4
		public void DrawDebug(float groundY = 0f /* Metadata: 0x0263B8F3 */); // 0x0000000186805BA0-0x0000000186805BB0
		private void __AOT_FOR_FIX__(); // 0x0000000188CD72BC-0x0000000188CD73A0
	}

	public interface ILogisticSample // TypeDefIndex: 79482
	{
		// Methods
		bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInLogistic);
		bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax);
		bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex);
		bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets);
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorLogisticsUnitFragment : IComponentECS // TypeDefIndex: 79483
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 16; // Metadata: 0x0263B8FB
	
		// Properties
		public int id { get; } // 0x0000000187239D50-0x0000000187239D60 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD7470-0x0000000188CD7540
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct ConveyorRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79484
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int indexInConveyor; // 0x04
		public HGFactoryEntityTransformData transformData; // 0x08
		public float3 position; // 0x08
		public float scale; // 0x14
		public quaternion rotation; // 0x18
		public const int ID = 17; // Metadata: 0x0263B8FC
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x0000000187239D80-0x0000000187239D90 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD76F0-0x0000000188CD77D4
	}

	public enum EDirectionType : byte // TypeDefIndex: 79485
	{
		LEFT = 0,
		MID = 1,
		RIGHT = 2
	}

	[BurstCompatible]
	[ECSComponent]
	public struct DirectionFragment : IComponentECS // TypeDefIndex: 79486
	{
		// Fields
		public EDirectionType direction; // 0x00
		public const int ID = 18; // Metadata: 0x0263B900
	
		// Properties
		public bool isLeft { get; } // 0x00000001857A8050-0x00000001857A8060 
		public bool isMid { get; } // 0x0000000185D35600-0x0000000185D35640 
		public bool isRight { get; } // 0x0000000188CD7C48-0x0000000188CD7C50 
		public int id { get; } // 0x0000000187239DD0-0x0000000187239DE0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD7B78-0x0000000188CD7C48
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CropRenderFragment : IComponentECS // TypeDefIndex: 79488
	{
		// Fields
		public RenderStatus status; // 0x00
		public Entity soilLogicEntity; // 0x04
		public uint index; // 0x0C
		public StringIntern.FastId matureCropTemplateIdFastString; // 0x10
		public StringIntern.FastId immatureCropTemplateIdFastString; // 0x14
		public StringIntern.FastId variantCropTemplateIdFastString; // 0x18
		public bool useVariantCropTemplate; // 0x1C
		public const int ID = 19; // Metadata: 0x0263B901
	
		// Properties
		public StringIntern.FastId cropTemplateIdFastString { get; } // 0x0000000185E55580-0x0000000185E55600 
		public int id { get; } // 0x0000000187239D90-0x0000000187239DA0 
	
		// Nested types
		public enum RenderStatus // TypeDefIndex: 79487
		{
			HIDE = 0,
			IMMATURE = 1,
			MATURE = 2
		}
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD77D4-0x0000000188CD78B0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CullResultFragment : IComponentECS // TypeDefIndex: 79489
	{
		// Fields
		public bool culled; // 0x00
		public const int ID = 22; // Metadata: 0x0263B905
	
		// Properties
		public int id { get; } // 0x0000000187239DA0-0x0000000187239DB0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD78B0-0x0000000188CD7980
	}

	[BurstCompatible]
	[ECSComponent]
	public struct DebugFragment : IComponentECS // TypeDefIndex: 79490
	{
		// Fields
		public const int ID = 26; // Metadata: 0x0263B906
	
		// Properties
		public int id { get; } // 0x0000000187239DC0-0x0000000187239DD0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD7AA8-0x0000000188CD7B78
	}

	[BurstCompatible]
	[ECSComponent]
	public struct EvtDestroyUnit : IReactiveComponent // TypeDefIndex: 79491
	{
		// Fields
		public long targetDestroyTime; // 0x00
		public long checkedTime; // 0x08
		public const int ID = 27; // Metadata: 0x0263B907
	
		// Properties
		public bool timeout { get; } // 0x000000018663A1A0-0x000000018663A1B0 
		public int id { get; } // 0x0000000187239E30-0x0000000187239E40 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD7EA0-0x0000000188CD7F78
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ShowStateUI : IComponentECS // TypeDefIndex: 79492
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 28; // Metadata: 0x0263B908
	
		// Properties
		public int id { get; } // 0x000000018723A840-0x000000018723A850 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDF264-0x0000000188CDF334
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ShowNameUI : IComponentECS // TypeDefIndex: 79493
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 29; // Metadata: 0x0263B909
	
		// Properties
		public int id { get; } // 0x000000018723A830-0x000000018723A840 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDF194-0x0000000188CDF264
	}

	[BurstCompatible]
	[ECSComponent]
	public struct HasRenderer : IComponentECS // TypeDefIndex: 79494
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 30; // Metadata: 0x0263B90A
	
		// Properties
		public int id { get; } // 0x000000018723A470-0x000000018723A480 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDB0D4-0x0000000188CDB1A4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct EnvGeneratorUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79495
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 31; // Metadata: 0x0263B90B
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x0000000187239DE0-0x0000000187239DF0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD7C50-0x0000000188CD7D24
	}

	public struct EvtUpdatePipeEffect : IFactoryEvent // TypeDefIndex: 79496
	{
		// Fields
		public Entity evtEntity; // 0x00
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000184431970-0x0000000184431980 0x000000018561B5B0-0x000000018561B5C0
	}

	public struct EvtChangeTemplate : IFactoryEvent // TypeDefIndex: 79497
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
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000187239E10-0x0000000187239E20 0x0000000187239E20-0x0000000187239E30
	}

	public struct EvtCreateUnitRenderer : IFactoryEvent // TypeDefIndex: 79498
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000184431970-0x0000000184431980 0x000000018561B5B0-0x000000018561B5C0
	}

	public struct EvtUpdateStatusEffect : IFactoryEvent // TypeDefIndex: 79499
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000184431970-0x0000000184431980 0x000000018561B5B0-0x000000018561B5C0
	}

	public struct EvtPendingCreateRenderer : IFactoryEvent // TypeDefIndex: 79500
	{
		// Fields
		public Entity evtEntity; // 0x00
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000184431970-0x0000000184431980 0x000000018561B5B0-0x000000018561B5C0
	}

	public struct EvtUpdateRendererProperty : IFactoryEvent // TypeDefIndex: 79501
	{
		// Fields
		public bool evtColliderToggle; // 0x00
		public bool colliderToggle; // 0x01
		public bool evtVisible; // 0x02
		public bool visible; // 0x03
		public bool additiveVisible; // 0x04
		public Entity evtEntity; // 0x08
	
		// Properties
		public Entity eventEntity { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x000000018561B590-0x000000018561B5A0
	}

	public struct EvtStatusChange : IFactoryEvent // TypeDefIndex: 79502
	{
		// Fields
		public bool forceUpdate; // 0x00
		public Entity evtEntity; // 0x04
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000187239DF0-0x0000000187239E00 0x0000000187239E00-0x0000000187239E10
	}

	public struct EvtCreateInteract : IFactoryEvent // TypeDefIndex: 79503
	{
		// Fields
		public ulong interactObjectId; // 0x00
		public Entity evtEntity; // 0x08
		public ulong evtEntityId; // 0x08
	
		// Properties
		public Entity eventEntity { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x000000018561B590-0x000000018561B5A0
	}

	public struct EvtVatUpdate : IFactoryEvent // TypeDefIndex: 79504
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public byte placeHolder; // 0x08
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000184431970-0x0000000184431980 0x000000018561B5B0-0x000000018561B5C0
	}

	public struct EvtUpdatePedestalColorLUT : IFactoryEvent // TypeDefIndex: 79505
	{
		// Fields
		public bool light; // 0x00
		public Entity evtEntity; // 0x04
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000187239DF0-0x0000000187239E00 0x0000000187239E00-0x0000000187239E10
	}

	public struct EvtChangeCropTemplate : IFactoryEvent // TypeDefIndex: 79506
	{
		// Fields
		public bool forceSyncPresentation; // 0x00
		public Entity evtEntity; // 0x04
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000187239DF0-0x0000000187239E00 0x0000000187239E00-0x0000000187239E10
	}

	public enum EvtAudioType : short // TypeDefIndex: 79507
	{
		BUILDING_STATUS = 1,
		BUILDING_DESTROY = 2
	}

	[Flags]
	public enum AudioCullingState : byte // TypeDefIndex: 79508
	{
		AUDIBLE = 1,
		PENDING_CULL = 2,
		CULLED = 4,
		CULLED_CUR_FRAME = 6,
		PENDING_RESTORE = 8,
		AUDIBLE_CUR_FRAME = 9
	}

	public enum AudioDebugGizmosType : byte // TypeDefIndex: 79509
	{
		NONE = 0,
		GROUP_EMITTER_AREA1 = 1,
		GROUP_EMITTER_AREA2 = 2,
		GROUP_EMITTER_AREA3 = 3,
		GROUP_EMITTER_OUT_OF_RANGE = 4,
		GROUP_EMITTER_NOT_CONSIDERED_TYPE = 5,
		GROUP_EMITTER_NOT_CONSIDERED_STATUS = 6
	}

	public struct EvtAudio : IFactoryEvent // TypeDefIndex: 79510
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public EvtAudioType evtType; // 0x08
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000184431970-0x0000000184431980 0x000000018561B5B0-0x000000018561B5C0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct AudioFragment : IComponentECS // TypeDefIndex: 79511
	{
		// Fields
		public uint audioFragmentId; // 0x00
		public float distSqToListener; // 0x04
		public AudioCullingState cullingState; // 0x08
		public const int ID = 32; // Metadata: 0x0263B91D
	
		// Properties
		public int id { get; } // 0x0000000187239C60-0x0000000187239C70 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD506C-0x0000000188CD5148
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ReleaseTagFragment : IComponentECS // TypeDefIndex: 79512
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 33; // Metadata: 0x0263B91E
	
		// Properties
		public int id { get; } // 0x000000018723A7F0-0x000000018723A800 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDEF84-0x0000000188CDF054
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CurMapUnitTag : IComponentECS // TypeDefIndex: 79513
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 34; // Metadata: 0x0263B91F
	
		// Properties
		public int id { get; } // 0x0000000187239DB0-0x0000000187239DC0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD7980-0x0000000188CD7A50
	}

	public struct StaticMountOffset // TypeDefIndex: 79514
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

	[BurstCompatible]
	[ECSComponent]
	public struct UnitFragment : IComponentECS // TypeDefIndex: 79515
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
		public int formulaManModeRaw; // 0x20
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
		public bool hasPedestal; // 0x1D4
		public const int ID = 35; // Metadata: 0x0263B930
	
		// Properties
		public FCNodeMode formulaManMode { get; set; } // 0x000000018226A850-0x000000018226A860 0x000000018723A890-0x000000018723A8A0
		public bool needRepair { get; } // 0x0000000188CDF99C-0x0000000188CDF9A4 
		public bool battleBroken { get; } // 0x0000000188CDF994-0x0000000188CDF99C 
		public bool socialUnit { get; } // 0x00000001857A4300-0x00000001857A4310 
		public bool isInvalidPlaced { get; } // 0x00000001850AEC30-0x00000001850AEC40 
		public bool isPrefabBuilding { get; } // 0x00000001850AF1B0-0x00000001850AF1E0 
		public string templateId { get; set; } // 0x0000000187837054-0x000000018783705C 0x00000001878370DC-0x00000001878370F8
		public string rendererTemplateId { get; set; } // 0x000000018783705C-0x0000000187837064 0x0000000187837064-0x0000000187837080
		public string logisticBaseRendererTemplateId { get; set; } // 0x000000018783B018-0x000000018783B020 0x00000001878370B4-0x00000001878370D0
		public string nonLogisticBaseRendererTemplateId { get; set; } // 0x000000018783B010-0x000000018783B018 0x0000000187837098-0x00000001878370B4
		public string instKey { get; set; } // 0x0000000187834A40-0x0000000187834A48 0x0000000187837038-0x0000000187837054
		public bool pipeValid { get; } // 0x0000000188CDF9A4-0x0000000188CDF9AC 
		public int id { get; } // 0x000000018723A880-0x000000018723A890 
	
		// Methods
		public static UnitFragment Create(uint nodeId, string templateId, int nodeType, bool2 buildDismissEnabled, int level = 0 /* Metadata: 0x0263B920 */, uint nodeFlag = 0 /* Metadata: 0x0263B921 */, string rendererTemplateId = "" /* Metadata: 0x0263B922 */, bool inBlock = false /* Metadata: 0x0263B923 */, bool inPower = false /* Metadata: 0x0263B924 */, bool inActive = true /* Metadata: 0x0263B925 */, long powerCost = 0 /* Metadata: 0x0263B926 */, FCNodeMode formulaManMode = FCNodeMode.None | FCNodeMode.normal /* Metadata: 0x0263B92E */, string instKey = "" /* Metadata: 0x0263B92F */); // 0x000000018565EAD0-0x000000018565EBB0
		private void __AOT_FOR_FIX__(); // 0x0000000188CDF898-0x0000000188CDF994
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitRenderPipeLogisticsFigureReplaceFragment : IComponentECS // TypeDefIndex: 79516
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 36; // Metadata: 0x0263B931
	
		// Properties
		public int id { get; } // 0x000000018723A8B0-0x000000018723A8C0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDFD28-0x0000000188CDFDF8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BusRenderFragment : IComponentECS // TypeDefIndex: 79517
	{
		// Fields
		public int idx; // 0x00
		public const int ID = 37; // Metadata: 0x0263B932
	
		// Properties
		public int id { get; } // 0x0000000187239CA0-0x0000000187239CB0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD5930-0x0000000188CD5A04
	}

	public enum EUnitRenderType : byte // TypeDefIndex: 79518
	{
		BUILDING = 0,
		PEDESTAL = 1,
		ONLY = 2
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitRenderTypeFragment : IComponentECS // TypeDefIndex: 79519
	{
		// Fields
		public EUnitRenderType renderType; // 0x00
		public const int ID = 38; // Metadata: 0x0263B936
	
		// Properties
		public bool isBuilding { get; } // 0x00000001857A8050-0x00000001857A8060 
		public bool isPedestal { get; } // 0x0000000185D35600-0x0000000185D35640 
		public bool isOnly { get; } // 0x0000000188CD7C48-0x0000000188CD7C50 
		public bool isRegular { get; } // 0x0000000188CDFEC8-0x0000000188CDFED8 
		public int id { get; } // 0x000000018723A8C0-0x000000018723A8D0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDFDF8-0x0000000188CDFEC8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FakeUnitFragment : IComponentECS // TypeDefIndex: 79520
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 39; // Metadata: 0x0263B937
	
		// Properties
		public int id { get; } // 0x0000000187239F20-0x0000000187239F30 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD8738-0x0000000188CD8808
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UIUnitFragment : IComponentECS // TypeDefIndex: 79521
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 40; // Metadata: 0x0263B938
	
		// Properties
		public int id { get; } // 0x000000018723A870-0x000000018723A880 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDF7C8-0x0000000188CDF898
	}

	[BurstCompatible]
	[ECSComponent]
	public struct GuideHintFragment : IComponentECS // TypeDefIndex: 79522
	{
		// Fields
		public int hashKey; // 0x00
		public const int ID = 41; // Metadata: 0x0263B939
	
		// Properties
		public int id { get; } // 0x000000018723A460-0x000000018723A470 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDB000-0x0000000188CDB0D4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitPreviewFragment : IComponentECS // TypeDefIndex: 79525
	{
		// Fields
		public int templateIdFastId; // 0x00
		public int previewRendererTemplateIdFastId; // 0x04
		public int logisticPedestalRendererTemplateIdFastId; // 0x08
		public int nonLogisticPedestalRendererTemplateIdFastId; // 0x0C
		public FCNodeMode formulaManMode; // 0x10
		public bool logisticPreviewIndicator; // 0x14
		public EntityTarget entityTarget; // 0x18
		public EntityType entityType; // 0x1C
		public const int ID = 42; // Metadata: 0x0263B93A
	
		// Properties
		public string templateId { get; set; } // 0x0000000188CDFB74-0x0000000188CDFBBC 0x0000000188CDFCD0-0x0000000188CDFD28
		public string previewRendererTemplateId { get; set; } // 0x0000000188CDFB28-0x0000000188CDFB74 0x0000000188CDFC74-0x0000000188CDFCD0
		public string logisticPedestalRendererTemplateId { get; set; } // 0x0000000188CDFA88-0x0000000188CDFAD4 0x0000000188CDFBBC-0x0000000188CDFC18
		public string nonLogisticPedestalRendererTemplateId { get; set; } // 0x0000000188CDFAD4-0x0000000188CDFB20 0x0000000188CDFC18-0x0000000188CDFC74
		public bool pipeValid { get; } // 0x0000000188CDFB20-0x0000000188CDFB28 
		public int id { get; } // 0x000000018723A8A0-0x000000018723A8B0 
	
		// Nested types
		public enum EntityTarget // TypeDefIndex: 79523
		{
			BUILDING = 0,
			PEDESTAL = 1
		}
	
		public enum EntityType // TypeDefIndex: 79524
		{
			NORMAL = 0,
			BLUEPRINT = 1
		}
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDF9AC-0x0000000188CDFA88
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorRegularFragment : IComponentECS // TypeDefIndex: 79526
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 43; // Metadata: 0x0263B93F
	
		// Properties
		public int id { get; } // 0x0000000187239D70-0x0000000187239D80 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD7620-0x0000000188CD76F0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorGuideFragment : IComponentECS // TypeDefIndex: 79527
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 45; // Metadata: 0x0263B940
	
		// Properties
		public int id { get; } // 0x0000000187239D40-0x0000000187239D50 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD73A0-0x0000000188CD7470
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeRegularFragment : IComponentECS // TypeDefIndex: 79528
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 46; // Metadata: 0x0263B941
	
		// Properties
		public int id { get; } // 0x000000018723A790-0x000000018723A7A0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDE1C0-0x0000000188CDE290
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorPreviewRendererFragment : IComponentECS // TypeDefIndex: 79529
	{
		// Fields
		public bool valid; // 0x00
		public UnitPreviewFragment.EntityType entityType; // 0x04
		public int length; // 0x08
		public uint startMemoryOffsetHandle; // 0x0C
		public uint endMemoryOffsetHandle; // 0x10
		public const int ID = 47; // Metadata: 0x0263B942
	
		// Properties
		public int id { get; } // 0x0000000187239D60-0x0000000187239D70 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD7540-0x0000000188CD7620
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipePreviewRendererFragment : IComponentECS // TypeDefIndex: 79530
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
		public const int ID = 48; // Metadata: 0x0263B943
	
		// Properties
		public int id { get; } // 0x000000018723A780-0x000000018723A790 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDE0E4-0x0000000188CDE1C0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipePreviewFragment : IComponentECS // TypeDefIndex: 79531
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 49; // Metadata: 0x0263B944
	
		// Properties
		public int id { get; } // 0x000000018723A770-0x000000018723A780 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDE014-0x0000000188CDE0E4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79532
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 50; // Metadata: 0x0263B945
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x0000000187239F50-0x0000000187239F60 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD89A8-0x0000000188CD8A84
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderDirectionFragment : IComponentECS // TypeDefIndex: 79533
	{
		// Fields
		public EDirectionType direction; // 0x00
		public const int ID = 51; // Metadata: 0x0263B946
	
		// Properties
		public bool isLeft { get; } // 0x00000001857A8050-0x00000001857A8060 
		public bool isMid { get; } // 0x0000000185D35600-0x0000000185D35640 
		public bool isRight { get; } // 0x0000000188CD7C48-0x0000000188CD7C50 
		public int id { get; } // 0x0000000187239F40-0x0000000187239F50 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD88D8-0x0000000188CD89A8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderPipeHolderFragment : IComponentECS // TypeDefIndex: 79534
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 52; // Metadata: 0x0263B947
	
		// Properties
		public int id { get; } // 0x0000000187239F60-0x0000000187239F70 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD8A84-0x0000000188CD8B54
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderConveyorLogisticsFragment : IComponentECS // TypeDefIndex: 79535
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 53; // Metadata: 0x0263B948
	
		// Properties
		public int id { get; } // 0x0000000187239F30-0x0000000187239F40 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD8808-0x0000000188CD88D8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidConsumeFragment : IComponentECS // TypeDefIndex: 79536
	{
		// Fields
		public long progress; // 0x00
		public const int ID = 54; // Metadata: 0x0263B949
	
		// Properties
		public int id { get; } // 0x0000000187239F80-0x0000000187239F90 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD8B54-0x0000000188CD8C28
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct FluidContainerFragment : IComponentECS // TypeDefIndex: 79537
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
		public int4x2 itemSubType; // 0x60
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
		public int isGas; // 0xA0
		public const int GAS_PACK_SLOT_COUNT = 6; // Metadata: 0x0263B94A
		public const int ID = 55; // Metadata: 0x0263B94B
	
		// Properties
		public int id { get; } // 0x0000000187239FC0-0x0000000187239FD0 
	
		// Methods
		public void Set(int index, int itemId, int itemAmount, int itemSubType); // 0x0000000187239FA0-0x0000000187239FC0
		public void SetCapacity(int index, int cap); // 0x0000000187239F90-0x0000000187239FA0
		public void SetAmount(int index, int amount); // 0x0000000185743050-0x0000000185743060
		public void SetRenderAmount(int index, float amount); // 0x0000000188CD929C-0x0000000188CD92AC
		public bool Get(int index, out int itemId, out int itemAmount, out float renderItemAmount, out int itemSubType, out int cap); // 0x0000000185310750-0x00000001853107E0
		public bool HasLiquid(); // 0x0000000188CD91D8-0x0000000188CD91F8
		public void CalcRenderItemAmount(float step); // 0x0000000188CD8C28-0x0000000188CD8F5C
		public ValueTuple<int, uint> GetOffsetData(); // 0x0000000188CD9088-0x0000000188CD91D8
		public ValueTuple<int, uint> GetGasOffsetData(); // 0x0000000188CD8F5C-0x0000000188CD9088
		public void Reset(); // 0x0000000188CD91F8-0x0000000188CD929C
		public override string ToString(); // 0x0000000188CD92AC-0x0000000188CD9C4C
		private void __AOT_FOR_FIX__(); // 0x0000000188CD9C4C-0x0000000188CD9D48
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidPumpInFragment : IComponentECS // TypeDefIndex: 79538
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 56; // Metadata: 0x0263B94C
	
		// Properties
		public int id { get; } // 0x0000000187239FD0-0x0000000187239FE0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD9D48-0x0000000188CD9E18
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidPumpOutFragment : IComponentECS // TypeDefIndex: 79539
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 57; // Metadata: 0x0263B94D
	
		// Properties
		public int id { get; } // 0x0000000187239FE0-0x0000000187239FF0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD9E18-0x0000000188CD9EE8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidReactionFragment : IComponentECS // TypeDefIndex: 79540
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 58; // Metadata: 0x0263B94E
	
		// Properties
		public int id { get; } // 0x0000000187239FF0-0x000000018723A000 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD9EE8-0x0000000188CD9FB8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidSprayFragment : IComponentECS // TypeDefIndex: 79541
	{
		// Fields
		public long progress; // 0x00
		public const int ID = 59; // Metadata: 0x0263B94F
	
		// Properties
		public int id { get; } // 0x000000018723A000-0x000000018723A010 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CD9FB8-0x0000000188CDA08C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FormulaManualFragment : IComponentECS // TypeDefIndex: 79542
	{
		// Fields
		public int currentGroup; // 0x00
		public int currentMode; // 0x04
		public int lockedFormulaId; // 0x08
		public const int ID = 60; // Metadata: 0x0263B950
	
		// Properties
		public int id { get; } // 0x000000018723A010-0x000000018723A020 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDA08C-0x0000000188CDA168
	}

	public struct EvtLogisticFigureRenderer // TypeDefIndex: 79543
	{
		// Fields
		public bool triggered; // 0x00
		public int figureType; // 0x04
		public static readonly byte S_NONE; // 0x00
		public static readonly byte S_PIPE; // 0x01
		public static readonly byte S_CONVEYOR; // 0x02
		public static readonly byte S_CONVEYOR_GUIDE; // 0x03
	
		// Constructors
		static EvtLogisticFigureRenderer(); // 0x00000001871DBAC0-0x00000001871DBB30
	}

	public struct OutOfBufferWarning // TypeDefIndex: 79544
	{
		// Fields
		public bool pipe; // 0x00
		public bool wire; // 0x01
		public bool conveyor; // 0x02
		public bool cargo; // 0x03
		public bool operated; // 0x04
	
		// Methods
		public void ResetFlags(); // 0x00000001872397E0-0x00000001872397F0
		public override string ToString(); // 0x0000000188CDCD48-0x0000000188CDCED8
	}

	[Flags]
	public enum FacSystemTickSkipSource : byte // TypeDefIndex: 79545
	{
		NONE = 0,
		MAP = 1,
		UI = 2,
		GM = 128,
		ALL = 255
	}

	[BurstCompatible]
	[ECSComponent]
	public struct GlobalEnv : IComponentECS // TypeDefIndex: 79546
	{
		// Fields
		public OutOfBufferWarning outOfBufferWarning; // 0x00
		public float3 remoteTopViewOffset; // 0x08
		public bool teardown; // 0x14
		public bool isSquadInFight; // 0x15
		public bool isTowerDefence; // 0x16
		public FacSystemTickSkipSource facSystemTickSkip; // 0x17
		public byte facSystemMapSkipGraceFramesRemaining; // 0x18
		public byte facSystemUISkipGraceFramesRemaining; // 0x19
		public float3 playerPosition; // 0x1C
		public float3 playerForward; // 0x28
		public float3 playerRight; // 0x34
		public float3 cameraPosition; // 0x40
		public Entity currentScopeEntity; // 0x4C
		public EntityQueryV2.QueryResultDefer unitPreviewQueryResult; // 0x58
		public EntityQueryV2.QueryResultDefer cargoPredictQueryResult; // 0x70
		public EntityQueryV2.QueryResultDefer lookAtQueryResult; // 0x88
		public EntityQueryV2.QueryResultDefer pipeThicknessQueryResult; // 0xA0
		public EntityQueryV2.QueryResultDefer l2wQueryResult; // 0xB8
		public EntityQueryV2.QueryResultDefer unitRendererQueryResult; // 0xD0
		public EntityQueryV2.QueryResultDefer liquidRendererQueryResult; // 0xE8
		public EntityQueryV2.QueryResultDefer pumpRendererQueryResult; // 0x100
		public EntityQueryV2.QueryResultDefer envReceiverRendererQueryResult; // 0x118
		public EntityQueryV2.QueryResultDefer additiveEffectQueryResult; // 0x130
		public EntityQueryV2.QueryResultDefer hintEffectQueryResult; // 0x148
		public EntityQueryV2.QueryResultDefer additiveEffectRendererQueryResult; // 0x160
		public EntityQueryV2.QueryResultDefer vatfsmStateQueryResult; // 0x178
		public EntityQueryV2.QueryResultDefer logisticEffectQueryResult; // 0x190
		public EntityQueryV2.QueryResultDefer pedestalFlashQueryResult; // 0x1A8
		public JobHandle baseTickChainJobHandle; // 0x1C0
		public JobHandle crossFrameJobHandle; // 0x1D0
		public JobHandle cullingJobHandle; // 0x1E0
		public JobHandle l2wJobHandle; // 0x1F0
		public JobHandle cargoPredictJobHandle; // 0x200
		public JobHandle cargoRenderJobHandle; // 0x210
		public JobHandle lookAtJobHandle; // 0x220
		public JobHandle conveyorFigureRenderJobHandle; // 0x230
		public JobHandle portArrowRenderJobHandle; // 0x240
		public JobHandle portConveyorInsideRenderJobHandle; // 0x250
		public long anyTransChangedFrame; // 0x260
		public bool evtLevelLoadStatus; // 0x268
		public bool evtTopViewChanged; // 0x269
		public bool evtForceUpdatePreviewPortRenderer; // 0x26A
		public bool firstEnterGameScene; // 0x26B
		public EvtLogisticFigureRenderer evtLogisticFigureRenderer; // 0x26C
		public bool systemUnlockedPipe; // 0x274
		public bool systemUnlockedConveyor; // 0x275
		public bool useDistanceFilter; // 0x276
		public float2 distanceFilterCenterPos; // 0x278
		public float distanceThreshold; // 0x280
		public unsafe FactoryEventChannels* eventChannels; // 0x288
		public float4x4 arrowUV; // 0x290
		public float2 arrowOffset; // 0x2D0
		public float conveyorOffsetY; // 0x2D8
		public bool UIBuildingAnimationEnabled; // 0x2DC
		public bool vatEnableEnvDirty; // 0x2DD
		public bool buildingNameInvalid; // 0x2DE
		public bool topViewEnable; // 0x2DF
		public bool showOutputUI; // 0x2E0
		public bool showEnvGeneratorUI; // 0x2E1
		public bool inBuildMode; // 0x2E2
		public bool inBlueprintMode; // 0x2E3
		public bool buildConveyor; // 0x2E4
		public bool buildPipe; // 0x2E5
		public bool simpleConveyor; // 0x2E6
		public bool simplePipe; // 0x2E7
		public bool inputDisable; // 0x2E8
		public bool outputDisable; // 0x2E9
		public bool inputFluidDisable; // 0x2EA
		public bool outputFluidDisable; // 0x2EB
		public unsafe InteractFacCollectJob.BuildingInfoWrap* interactBuilding; // 0x2F0
		public unsafe InteractFacCollectJob.LogisticInfo* conveyorInfo; // 0x2F8
		public unsafe InteractFacCollectJob.LogisticInfo* pipeInfo; // 0x300
		public unsafe InteractFacCollectJob.BuildingInfoWrap* interactBuildingLast; // 0x308
		public unsafe InteractFacCollectJob.LogisticInfo* conveyorInfoLast; // 0x310
		public unsafe InteractFacCollectJob.LogisticInfo* pipeInfoLast; // 0x318
		public unsafe UnsafeList<float4x4>* portBlockPosListPtr; // 0x320
		public unsafe UnsafeList<OutputRendererInfo>* outputUIPosListPtr; // 0x328
		public unsafe UnsafeList<EnvGeneratorRendererInfo>* envGeneratorUIPosListPtr; // 0x330
		public unsafe UnsafeList<float4x4>* buildingStatePosListPtr; // 0x338
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* cargoMatricesBufferWriter; // 0x340
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* cargoMatricesBufferReader; // 0x348
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorLPosMatricesBufferWriter; // 0x350
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorMPosMatricesBufferWriter; // 0x358
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorRPosMatricesBufferWriter; // 0x360
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorLPosMatricesBufferReader; // 0x368
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorMPosMatricesBufferReader; // 0x370
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorRPosMatricesBufferReader; // 0x378
		public unsafe UnsafeList<Matrix4x4>* conveyorLogPosMatricesPtr; // 0x380
		public bool bConflictCheck; // 0x388
		public IntPtr arrowPlacedDicPtr; // 0x390
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* portArrowMatricesWriter; // 0x398
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* portArrowMatricesReader; // 0x3A0
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewLPosMatricesWriter; // 0x3A8
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewMPosMatricesWriter; // 0x3B0
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewRPosMatricesWriter; // 0x3B8
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewLPosMatricesReader; // 0x3C0
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewMPosMatricesReader; // 0x3C8
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewRPosMatricesReader; // 0x3D0
		public unsafe UnsafeList<float4x4>* conveyorInsideMatricesPtr; // 0x3D8
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureLPosMatricesBufferWriter; // 0x3E0
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureMPosMatricesBufferWriter; // 0x3E8
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureRPosMatricesBufferWriter; // 0x3F0
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureLPosMatricesBufferReader; // 0x3F8
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureMPosMatricesBufferReader; // 0x400
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureRPosMatricesBufferReader; // 0x408
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeLPosMatricesBufferWriter; // 0x410
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeMPosMatricesBufferWriter; // 0x418
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeRPosMatricesBufferWriter; // 0x420
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeLPosMatricesBufferReader; // 0x428
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeMPosMatricesBufferReader; // 0x430
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeRPosMatricesBufferReader; // 0x438
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeSplashPosMatricesBufferWriter; // 0x440
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeSplashPosMatricesBufferReader; // 0x448
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeLPosMatricesBufferWriter; // 0x450
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeMPosMatricesBufferWriter; // 0x458
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeRPosMatricesBufferWriter; // 0x460
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeLPosMatricesBufferReader; // 0x468
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeMPosMatricesBufferReader; // 0x470
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeRPosMatricesBufferReader; // 0x478
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackLPosMatricesBufferWriter; // 0x480
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackMPosMatricesBufferWriter; // 0x488
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackRPosMatricesBufferWriter; // 0x490
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackLPosMatricesBufferReader; // 0x498
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackMPosMatricesBufferReader; // 0x4A0
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackRPosMatricesBufferReader; // 0x4A8
		public unsafe UnsafeList<Matrix4x4>* pipeHolderPosMatricesPtr; // 0x4B0
		public unsafe UnsafeList<float4x4>* comPosMatricesPtr; // 0x4B8
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireNormalBufferWriter; // 0x4C0
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsNormalBufferWriter; // 0x4C8
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireDisableBufferWriter; // 0x4D0
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenBufferWriter; // 0x4D8
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsStrengthenBufferWriter; // 0x4E0
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenDisableBufferWriter; // 0x4E8
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireNormalBufferReader; // 0x4F0
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsNormalBufferReader; // 0x4F8
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireDisableBufferReader; // 0x500
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenBufferReader; // 0x508
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsStrengthenBufferReader; // 0x510
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenDisableBufferReader; // 0x518
		public bool levelShowForceUpdate; // 0x520
		public bool conveyorEffectDirty; // 0x521
		public bool pipeEffectDirty; // 0x522
		public unsafe ConveyorInfoAllocator* conveyorInfoAllocator; // 0x528
		public unsafe UnsafeList<VATFSMProcessor.SetAnimatorParamRequest>* animatorParamRequestQueue; // 0x530
		public unsafe UnsafeList<VATFSMProcessor.VATFSMAudioData>* animatorAudioQueue; // 0x538
		public const int ID = 62; // Metadata: 0x0263B959
	
		// Properties
		public bool facSystemTickEnabled { get; } // 0x00000001861D51E0-0x00000001861D5200 
		public UnsafeList<float4x4> portBlockPosListReader { get; } // 0x000000018783BE8C-0x000000018783BEC0 
		public UnsafeList<OutputRendererInfo> outputUIPosListReader { get; } // 0x000000018783BEE0-0x000000018783BF14 
		public UnsafeList<EnvGeneratorRendererInfo> envGeneratorUIPosListReader { get; } // 0x000000018783BF14-0x000000018783BF48 
		public UnsafeList<float4x4> buildingStatePosListReader { get; } // 0x000000018783B8C8-0x000000018783B8FC 
		public IntPtr cargoMatricesBufferIntPtrReader { get; } // 0x000000018723A170-0x000000018723A180 
		public int cargoRendererCount { get; } // 0x000000018723A180-0x000000018723A190 
		public bool cargoDirty { get; } // 0x0000000185C9C130-0x0000000185C9C2E0 
		public IntPtr conveyorLPosMatricesBufferIntPtrReader { get; } // 0x000000018723A190-0x000000018723A1A0 
		public IntPtr conveyorMPosMatricesBufferIntPtrReader { get; } // 0x000000018723A1A0-0x000000018723A1B0 
		public IntPtr conveyorRPosMatricesBufferIntPtrReader { get; } // 0x000000018723A1E0-0x000000018723A1F0 
		public int lConveyorRenderCount { get; } // 0x000000018723A270-0x000000018723A280 
		public int mConveyorRenderCount { get; } // 0x000000018723A2D0-0x000000018723A2E0 
		public int rConveyorRenderCount { get; } // 0x000000018723A3A0-0x000000018723A3B0 
		public bool conveyorDirty { get; } // 0x00000001853B0490-0x00000001853B0640 
		public UnsafeList<Matrix4x4> conveyorLogPosMatricesReader { get; } // 0x0000000188CDADF4-0x0000000188CDAE28 
		public IntPtr portArrowMatricesIntPtrReader { get; } // 0x00000001828CD540-0x00000001828CD550 
		public int portArrowRenderCount { get; } // 0x000000018723A380-0x000000018723A390 
		public bool portArrowDirty { get; } // 0x0000000188CDAE5C-0x0000000188CDAF88 
		public IntPtr conveyorPreviewLPosMatricesIntPtrReader { get; } // 0x000000018723A1B0-0x000000018723A1C0 
		public IntPtr conveyorPreviewMPosMatricesIntPtrReader { get; } // 0x000000018723A1C0-0x000000018723A1D0 
		public IntPtr conveyorPreviewRPosMatricesIntPtrReader { get; } // 0x000000018723A1D0-0x000000018723A1E0 
		public int lConveyorPreviewRenderCount { get; } // 0x000000018723A260-0x000000018723A270 
		public int mConveyorPreviewRenderCount { get; } // 0x000000018723A2C0-0x000000018723A2D0 
		public int rConveyorPreviewRenderCount { get; } // 0x000000018723A390-0x000000018723A3A0 
		public UnsafeList<float4x4> conveyorInsideMatricesReader { get; } // 0x0000000187836F78-0x0000000187836FAC 
		public bool previewConveyorDirty { get; } // 0x00000001853B0920-0x00000001853B0AD0 
		public IntPtr guideFigureLPosMatricesBufferIntPtrReader { get; } // 0x000000018723A220-0x000000018723A230 
		public IntPtr guideFigureMPosMatricesBufferIntPtrReader { get; } // 0x000000018723A230-0x000000018723A240 
		public IntPtr guideFigureRPosMatricesBufferIntPtrReader { get; } // 0x000000018723A240-0x000000018723A250 
		public int lGuideFigureRenderCount { get; } // 0x000000018723A290-0x000000018723A2A0 
		public int mGuideFigureRenderCount { get; } // 0x000000018723A2F0-0x000000018723A300 
		public int rGuideFigureRenderCount { get; } // 0x000000018723A3C0-0x000000018723A3D0 
		public bool guideFigureDirty { get; } // 0x00000001853B0120-0x00000001853B0400 
		public IntPtr pipeLPosMatricesBufferIntPtrReader { get; } // 0x000000018723A320-0x000000018723A330 
		public IntPtr pipeMPosMatricesBufferIntPtrReader { get; } // 0x000000018723A330-0x000000018723A340 
		public IntPtr pipeRPosMatricesBufferIntPtrReader { get; } // 0x000000018723A340-0x000000018723A350 
		public int lPipeRenderCount { get; } // 0x000000018723A2A0-0x000000018723A2B0 
		public int mPipeRenderCount { get; } // 0x000000018723A300-0x000000018723A310 
		public int rPipeRenderCount { get; } // 0x000000018723A3D0-0x000000018723A3E0 
		public IntPtr pipeSplashPosMatricesBufferIntPtrReader { get; } // 0x000000018723A350-0x000000018723A360 
		public int pipeSplashRenderCount { get; } // 0x0000000186393E80-0x0000000186393EC0 
		public IntPtr gasPipeLPosMatricesBufferIntPtrReader { get; } // 0x000000018723A1F0-0x000000018723A200 
		public IntPtr gasPipeMPosMatricesBufferIntPtrReader { get; } // 0x000000018723A200-0x000000018723A210 
		public IntPtr gasPipeRPosMatricesBufferIntPtrReader { get; } // 0x000000018723A210-0x000000018723A220 
		public int lGasPipeRenderCount { get; } // 0x000000018723A280-0x000000018723A290 
		public int mGasPipeRenderCount { get; } // 0x000000018723A2E0-0x000000018723A2F0 
		public int rGasPipeRenderCount { get; } // 0x000000018723A3B0-0x000000018723A3C0 
		public IntPtr pipeTrackLPosMatricesBufferIntPtrReader { get; } // 0x000000018723A360-0x000000018723A370 
		public IntPtr pipeTrackMPosMatricesBufferIntPtrReader { get; } // 0x0000000184736940-0x0000000184736950 
		public IntPtr pipeTrackRPosMatricesBufferIntPtrReader { get; } // 0x000000018723A370-0x000000018723A380 
		public int lPipeTrackRenderCount { get; } // 0x000000018723A2B0-0x000000018723A2C0 
		public int mPipeTrackRenderCount { get; } // 0x000000018723A310-0x000000018723A320 
		public int rPipeTrackRenderCount { get; } // 0x000000018723A3E0-0x000000018723A3F0 
		public bool anyPipeDirty { get; } // 0x00000001860FE770-0x00000001860FE7B0 
		public bool pipeDirty { get; } // 0x00000001853B0640-0x00000001853B0920 
		public bool pipeSplashDirty { get; } // 0x00000001860FE7B0-0x00000001860FE890 
		public bool gasPipeDirty { get; } // 0x00000001853B1470-0x00000001853B1750 
		public UnsafeList<Matrix4x4> pipeHolderPosMatricesReader { get; } // 0x0000000188CDAE28-0x0000000188CDAE5C 
		public UnsafeList<float4x4> comPosMatricesReader { get; } // 0x0000000188CDADC0-0x0000000188CDADF4 
		public IntPtr wireNormalBufferIntPtrReader { get; } // 0x000000018723A420-0x000000018723A430 
		public IntPtr wireHsNormalBufferIntPtrReader { get; } // 0x000000018723A400-0x000000018723A410 
		public IntPtr wireDisableBufferIntPtrReader { get; } // 0x000000018723A3F0-0x000000018723A400 
		public IntPtr wireStrengthenBufferIntPtrReader { get; } // 0x000000018723A430-0x000000018723A440 
		public IntPtr wireHsStrengthenBufferIntPtrReader { get; } // 0x000000018723A410-0x000000018723A420 
		public IntPtr wireStrengthenDisableBufferIntPtrReader { get; } // 0x000000018723A440-0x000000018723A450 
		public int wireNormalRendererCount { get; } // 0x0000000185C60F10-0x0000000185C60F50 
		public int wireHsNormalRendererCount { get; } // 0x0000000185C60F50-0x0000000185C60F90 
		public int wireDisableRendererCount { get; } // 0x0000000188CDAF88-0x0000000188CDAFC4 
		public int wireStrengthenRendererCount { get; } // 0x000000018723A450-0x000000018723A460 
		public int wireHsStrengthenRendererCount { get; } // 0x0000000185C60F90-0x0000000185C60FD0 
		public int wireStrengthenDisableRendererCount { get; } // 0x0000000188CDAFC4-0x0000000188CDB000 
		public bool wireNormalDirty { get; } // 0x0000000185C60FD0-0x0000000185C61180 
		public bool wireHsNormalDirty { get; } // 0x0000000185C61180-0x0000000185C61330 
		public bool wireDisableDirty { get; } // 0x0000000185C61330-0x0000000185C614E0 
		public bool wireStrengthenDirty { get; } // 0x0000000185C614E0-0x0000000185C61690 
		public bool wireHsStrengthenDirty { get; } // 0x0000000185C61690-0x0000000185C61840 
		public bool wireStrengthenDisableDirty { get; } // 0x0000000185C61840-0x0000000185C619F0 
		public UnsafeList<VATFSMProcessor.SetAnimatorParamRequest> animatorParamRequestQueueReader { get; } // 0x0000000188CDAD64-0x0000000188CDADC0 
		public UnsafeList<VATFSMProcessor.VATFSMAudioData> animatorAudioQueueWriter { get; } // 0x0000000187836FAC-0x0000000187836FD4 
		public int id { get; } // 0x000000018723A250-0x000000018723A260 
	
		// Methods
		public void InitSkipFlag(); // 0x000000018723A060-0x000000018723A070
		public void CreateQueryResult(); // 0x0000000186A9FAD0-0x0000000186A9FC60
		public void DisposeQueryResult(); // 0x0000000188CDA210-0x0000000188CDA2DC
		public void SwapCargoBuffer(); // 0x0000000188CDA34C-0x0000000188CDA3AC
		public unsafe void SetConveyorBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1); // 0x000000018723A0D0-0x000000018723A110
		public void SwapConveyorBuffer(); // 0x0000000188CDA3AC-0x0000000188CDA444
		private static unsafe bool _IsConveyorRendererInfoBufferDirty(ConveyorRendererInfoCollection<ConveyorRendererInfo>* writer, ConveyorRendererInfoCollection<ConveyorRendererInfo>* reader); // 0x00000001827C6D60-0x00000001827C7350
		public unsafe void SetPortArrowBuffers(void* buffer0, void* buffer1); // 0x000000018723A120-0x000000018723A130
		public void SwapPortArrowBuffer(); // 0x0000000188CDA644-0x0000000188CDA6A4
		public unsafe void SetPreviewConveyorBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1); // 0x000000018723A130-0x000000018723A170
		public void SwapPreviewConveyorBuffer(); // 0x0000000188CDA6A4-0x0000000188CDA73C
		public unsafe void SeGuideFigureBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1); // 0x000000018723A090-0x000000018723A0D0
		public void SwapGuideFigureBuffer(); // 0x0000000188CDA444-0x0000000188CDA4DC
		public unsafe void SetPipeBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1, void* gasLBuffer0, void* gasLBuffer1, void* gasMBuffer0, void* gasMBuffer1, void* gasRBuffer0, void* gasRBuffer1, void* trackLBuffer0, void* trackLBuffer1, void* trackMBuffer0, void* trackMBuffer1, void* trackRBuffer0, void* trackRBuffer1); // 0x0000000185D61370-0x0000000185D61450
		public unsafe void SetPipeSplashBuffers(void* splashBuffer0, void* splashBuffer1); // 0x000000018723A110-0x000000018723A120
		public void SwapPipeBuffer(); // 0x0000000188CDA4DC-0x0000000188CDA644
		public unsafe void SetWireBuffer(void* normal0, void* normal1, void* hsNormal0, void* hsNormal1, void* disable0, void* disable1, void* strengthen0, void* strengthen1, void* hsStrengthen0, void* hsStrengthen1, void* strengthenDisable0, void* strengthenDisable1); // 0x0000000185D614F0-0x0000000185D61580
		public void SwapWireBuffer(); // 0x0000000188CDA73C-0x0000000188CDA828
		public unsafe void GetConveyorRendererInfo(uint memoryStartOffset, int countIdx, out ConveyorInfoAllocator.Info* info); // 0x0000000185870FE0-0x0000000185871050
		public ref ConveyorInfoAllocator.Info GetConveyorRendererInfo(uint memoryStartOffset, int countIdx); // 0x0000000185870CA0-0x0000000185870CE0
		public LinearAllocator.Allocation AllocateConveyorInfo(int count); // 0x0000000187837D8C-0x0000000187837DC0
		public long CalculateConveyorInfoSize(uint memoryOffset); // 0x0000000188CD0738-0x0000000188CD0750
		public LinearAllocator.Allocation ResizeConveyorInfo(uint startIndex, int count); // 0x0000000188CDA2EC-0x0000000188CDA34C
		public void FreeConveyorInfo(uint startIndex); // 0x0000000188CDA2DC-0x0000000188CDA2EC
		public void AddSetAnimatorParamRequest(Entity logicEntity, VATFSMProcessor.SetAnimatorParamRequest rq); // 0x00000001857A75F0-0x00000001857A8050
		public void AddSetAnimatorParamRequestToPedestal(Entity entity, PooledList<VATFSMProcessor.SetAnimatorParamRequest> rqList, bool isPreviewBuilding = false /* Metadata: 0x0263B956 */); // 0x0000000185D34810-0x0000000185D35600
		public bool AddSetAnimatorClipSlotRequest(Entity entity, byte clipSlot, bool isPreviewBuilding = false /* Metadata: 0x0263B957 */); // 0x0000000188CDA168-0x0000000188CDA210
		public bool AddSetAnimatorClipSlotRequestByMode(Entity entity, FCNodeMode mode, bool isPreviewBuilding = false /* Metadata: 0x0263B958 */); // 0x0000000185873970-0x0000000185873E90
		private bool _AddAnimatorClipSlotRequestToBoundRenders(Entity entity, [IsReadOnly] in VATFSMProcessor.SetAnimatorParamRequest rq); // 0x0000000188CDA828-0x0000000188CDAC68
		private bool _AddAnimatorClipSlotRequestByModeToRender(ref EntityManager em, Entity renderEntity, FCNodeMode mode); // 0x00000001870A7A40-0x00000001870A7B40
		private bool _AddAnimatorParamRequest(ref EntityManager em, Entity renderEntity, [IsReadOnly] in VATFSMProcessor.SetAnimatorParamRequest rq); // 0x00000001857A8060-0x00000001857A8820
		public ref VATFSMProcessor.VATFSMAudioData GetAudioVATDataAt(int index); // 0x000000018723A030-0x000000018723A050
		public int GetAudioVATDataLength(); // 0x000000018723A050-0x000000018723A060
		public void ClearAudioVATData(); // 0x000000018723A020-0x000000018723A030
		public void ResetFlags(); // 0x000000018723A070-0x000000018723A090
		private void __AOT_FOR_FIX__(); // 0x0000000188CDAC68-0x0000000188CDAD64
	}

	[BurstCompatible]
	[ECSComponent]
	public struct HealthPoleFragment : IComponentECS // TypeDefIndex: 79547
	{
		// Fields
		public long currentProgress; // 0x00
		public int currentPoint; // 0x08
		public const int ID = 63; // Metadata: 0x0263B95A
	
		// Properties
		public int id { get; } // 0x000000018723A480-0x000000018723A490 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDB1A4-0x0000000188CDB27C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct InventoryFragment : IComponentECS // TypeDefIndex: 79548
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 64; // Metadata: 0x0263B95B
	
		// Properties
		public int id { get; } // 0x000000018723A490-0x000000018723A4A0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDB404-0x0000000188CDB4D4
	}

	public interface IPositionFragment // TypeDefIndex: 79549
	{
		// Properties
		float3 Position { get; }
	}

	public interface IReactiveComponent : IComponentECS // TypeDefIndex: 79550
	{
	}

	public interface IFactoryEvent // TypeDefIndex: 79551
	{
		// Properties
		Entity eventEntity { get; set; }
	}

	[Obsolete("Use IFactoryEvent instead. INotificationComponent will be removed.")]
	public interface INotificationComponent : IReactiveComponent // TypeDefIndex: 79552
	{
		// Properties
		Entity eventEntity { get; set; }
	}

	public interface IRotateFragment // TypeDefIndex: 79553
	{
		// Properties
		float3 Rotation { get; }
		quaternion RotationQuaternion { get; }
	}

	public interface IUnitConfigRef // TypeDefIndex: 79554
	{
		// Properties
		int unitAssetInstanceId { get; set; }
	}

	[BurstCompatible]
	[ECSComponent]
	public struct LiquidPurifierFragment : IComponentECS // TypeDefIndex: 79555
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 65; // Metadata: 0x0263B95D
	
		// Properties
		public int id { get; } // 0x000000018723A4A0-0x000000018723A4B0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDB4D4-0x0000000188CDB5A4
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct LogisticEffectFragment : IComponentECS // TypeDefIndex: 79556
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
		public const int ID = 66; // Metadata: 0x0263B95F
	
		// Properties
		public int id { get; } // 0x000000018723A5F0-0x000000018723A600 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDC9BC-0x0000000188CDCAA0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct LogisticEntityBindFragment : IComponentECS // TypeDefIndex: 79557
	{
		// Fields
		public EntityData256<Entity> cargoEntities; // 0x00
		public uint conveyorExtHandle; // 0x808
		public const int ID = 67; // Metadata: 0x0263B961
	
		// Properties
		public int cargoCount { get; } // 0x000000018723A600-0x000000018723A610 
		public int id { get; } // 0x000000018723A610-0x000000018723A620 
	
		// Methods
		public void EnqueueCargoEntityImpl(Entity cargoEntity, uint conveyorSharedDataIndex); // 0x0000000185663B90-0x0000000185663E10
		public bool DequeueCargoEntityImpl(out Entity cargoEntity); // 0x0000000185663670-0x00000001856638C0
		public unsafe void Arrive(ref CargoFragment cargo, ConveyorExtContainer.ConveyorExt* conveyorExtData); // 0x0000000188CDCB18-0x0000000188CDCB48
		public unsafe void Arrive(Entity cargoEntity, ConveyorExtContainer.ConveyorExt* conveyorExtData); // 0x0000000188CDCAA0-0x0000000188CDCB18
		private void __AOT_FOR_FIX__(); // 0x0000000188CDCB48-0x0000000188CDCC4C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct MapGridRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79558
	{
		// Fields
		[CompilerGenerated]
		private int _unitAssetInstanceId_k__BackingField; // 0x00
		public const int ID = 68; // Metadata: 0x0263B963
	
		// Properties
		public int unitAssetInstanceId { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x000000018723A620-0x000000018723A630 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDCC4C-0x0000000188CDCD20
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct OutputFragment : IComponentECS // TypeDefIndex: 79559
	{
		// Fields
		public int item; // 0x00
		public float4 rarityColor; // 0x04
		public float4 atlasRect; // 0x14
		public byte enableLiquidIcon; // 0x24
		public float4 liquidAtlasUV; // 0x25
		public static readonly int MAX_OUTPUT; // 0x00
		public const int ID = 69; // Metadata: 0x0263B965
	
		// Properties
		public bool hasOutput { get; } // 0x00000001889F343C-0x00000001889F3444 
		public int id { get; } // 0x000000018723A670-0x000000018723A680 
	
		// Constructors
		static OutputFragment(); // 0x000000018721FF30-0x000000018721FF70
	
		// Methods
		public void Clean(); // 0x000000018723A630-0x000000018723A650
		public void SetColor(float4 color); // 0x000000018723A660-0x000000018723A670
		public void SetColor(UnityEngine.Color color); // 0x0000000185B393C0-0x0000000185B393E0
		public void SetAtlasRect(float4 rect); // 0x000000018723A650-0x000000018723A660
		public void SetAtlasRect(RectInt rect); // 0x0000000185B39AA0-0x0000000185B39B20
		public bool GetEnableLiquidIcon(); // 0x0000000188CDCED8-0x0000000188CDCEE0
		public void SetEnableLiquidIcon(bool enable); // 0x0000000185B393E0-0x0000000185B393F0
		public void SetLiquidIconUV(RectInt rect); // 0x0000000185B39370-0x0000000185B393C0
		private void __AOT_FOR_FIX__(); // 0x0000000188CDCEE0-0x0000000188CDCFC8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct OutputUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79560
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 70; // Metadata: 0x0263B967
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x000000018723A680-0x000000018723A690 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDCFC8-0x0000000188CDD09C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PedestalLightFlashFragment : IComponentECS // TypeDefIndex: 79561
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
		public const int ID = 71; // Metadata: 0x0263B969
	
		// Properties
		public int id { get; } // 0x000000018723A710-0x000000018723A720 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDD3A8-0x0000000188CDD494
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PedestalLightFlashConfigFragment : IComponentECS // TypeDefIndex: 79566
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ float intensity[0]; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ float flashIntensity[0]; // 0x40
		public unsafe fixed /* 0x00000000-0x00000000 */ float flashDuration[0]; // 0x80
		public unsafe fixed /* 0x00000000-0x00000000 */ bool flash[0]; // 0xC0
		public Float4Data16<float4> color; // 0xD0
		public Float4Data16<float4> flashColor; // 0x1D8
		public const int ID = 72; // Metadata: 0x0263B96B
	
		// Properties
		public int id { get; } // 0x000000018723A700-0x000000018723A710 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _intensity_e__FixedBuffer // TypeDefIndex: 79562
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _flashIntensity_e__FixedBuffer // TypeDefIndex: 79563
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _flashDuration_e__FixedBuffer // TypeDefIndex: 79564
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _flash_e__FixedBuffer // TypeDefIndex: 79565
		{
			// Fields
			public bool FixedElementField; // 0x00
		}
	
		// Methods
		public bool IsValid(); // 0x0000000188CDD26C-0x0000000188CDD2AC
		public void SetIntensity(int idx, float value); // 0x000000018723A6F0-0x000000018723A700
		public void SetFlashIntensity(int idx, float value); // 0x000000018723A6D0-0x000000018723A6E0
		public void SetFlash(int idx, bool value); // 0x000000018723A6E0-0x000000018723A6F0
		public void SetFlashDuration(int idx, float value); // 0x000000018723A6C0-0x000000018723A6D0
		public void SetColor(int idx, UnityEngine.Color value); // 0x0000000185EDBAF0-0x0000000185EDBB80
		public void SetFlashColor(int idx, UnityEngine.Color value); // 0x0000000185EDBB80-0x0000000185EDBC10
		public float GetIntensity(int idx); // 0x000000018723A6B0-0x000000018723A6C0
		public float GetFlashIntensity(int idx); // 0x000000018723A6A0-0x000000018723A6B0
		public bool GetFlash(int idx); // 0x0000000188CDD25C-0x0000000188CDD26C
		public float GetFlashDuration(int idx); // 0x000000018723A690-0x000000018723A6A0
		public float4 GetColor(int idx); // 0x0000000188CDD09C-0x0000000188CDD17C
		public float4 GetFlashColor(int idx); // 0x0000000188CDD17C-0x0000000188CDD25C
		private void __AOT_FOR_FIX__(); // 0x0000000188CDD2AC-0x0000000188CDD3A8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeEffectFragment : IComponentECS // TypeDefIndex: 79567
	{
		// Fields
		public IntData32<uint> pipeEffectInstanceId; // 0x00
		public StringIntern.FastId inEffectNameFastId; // 0x88
		public StringIntern.FastId outEffectNameFastId; // 0x8C
		public StringIntern.FastId inEffectConnectedNameFastId; // 0x90
		public StringIntern.FastId outEffectConnectedNameFastId; // 0x94
		public StringIntern.FastId activateInEffectNameFastId; // 0x98
		public StringIntern.FastId activateInEffectConnectedNameFastId; // 0x9C
		public const int ID = 73; // Metadata: 0x0263B96D
	
		// Properties
		public string inEffectName { get; set; } // 0x0000000188CDD690-0x0000000188CDD69C 0x0000000187838C4C-0x0000000187838C6C
		public string outEffectName { get; set; } // 0x0000000188CDD6A8-0x0000000188CDD6B4 0x0000000187838C2C-0x0000000187838C4C
		public string inEffectConnectedName { get; set; } // 0x0000000188CDD684-0x0000000188CDD690 0x0000000187838C0C-0x0000000187838C2C
		public string outEffectConnectedName { get; set; } // 0x0000000188CDD69C-0x0000000188CDD6A8 0x0000000187838BEC-0x0000000187838C0C
		public string activateInEffectName { get; set; } // 0x0000000188CDD678-0x0000000188CDD684 0x0000000187838BCC-0x0000000187838BEC
		public string activateInEffectConnectedName { get; set; } // 0x0000000188CDD66C-0x0000000188CDD678 0x0000000187838BAC-0x0000000187838BCC
		public int id { get; } // 0x000000018723A730-0x000000018723A740 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDD570-0x0000000188CDD66C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeFragment : IComponentECS, ILogisticSample // TypeDefIndex: 79568
	{
		// Fields
		public static readonly float PIPE_HEIGHT; // 0x00
		public uint factoryUnitId; // 0x00
		public bool validMode; // 0x04
		public float pipeHeight; // 0x08
		public float currentWaterThickness; // 0x0C
		public float waterFlowDeltaTime; // 0x10
		public float waterThickness; // 0x14
		public float fluidHeight; // 0x18
		public float speed; // 0x1C
		public int waterDirection; // 0x20
		public int subItemType; // 0x24
		public float firstIndex; // 0x28
		public long firstItemTms; // 0x30
		public bool entranceConnected; // 0x38
		public bool exitConnected; // 0x39
		public float3 entranceGroundAdjustPos; // 0x3C
		public float3 exitGroundAdjustPos; // 0x48
		public float3 entrancePortDirection; // 0x54
		public float3 exitPortDirection; // 0x60
		public float bend; // 0x6C
		public UnityEngine.Rect bounds; // 0x70
		public uint itemId; // 0x80
		public bool isGas; // 0x84
		[CompilerGenerated]
		private int _length_k__BackingField; // 0x88
		public uint startMemoryOffsetHandle; // 0x8C
		public uint endMemoryOffsetHandle; // 0x90
		public const int ID = 74; // Metadata: 0x0263B979
	
		// Properties
		public int length { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000187233450-0x0000000187233460 0x0000000185B8E410-0x0000000185B8E660
		public int id { get; } // 0x000000018723A740-0x000000018723A750 
	
		// Constructors
		static PipeFragment(); // 0x000000018721FE30-0x000000018721FE70
	
		// Methods
		public bool SetInflection(ref GlobalEnv env, ref NativeList<float3> p, ref NativeList<float3> r, ref NativeList<byte> proto); // 0x0000000185870950-0x0000000185870CA0
		public static void Bend(ref GlobalEnv env, int pipeLength, uint startMemoryOffsetHandle, float pipeHeight, bool bOverrideEntranceY = false /* Metadata: 0x0263B96F */, float overrideEntranceY = 0f /* Metadata: 0x0263B970 */, bool bOverrideExitY = false /* Metadata: 0x0263B974 */, float overrideExitY = 0f /* Metadata: 0x0263B975 */); // 0x000000018586FBB0-0x000000018586FD10
		public static ValueTuple<int[], int> GetCornerIndexList(ref GlobalEnv env, uint startMemoryOffsetHandle, int length); // 0x000000018586FAA0-0x000000018586FBB0
		public bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInPipe); // 0x0000000188CDDC0C-0x0000000188CDDD6C
		public bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax); // 0x0000000188CDDA84-0x0000000188CDDC0C
		public bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex); // 0x0000000188CDD8A0-0x0000000188CDDA84
		public bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets); // 0x0000000188CDD6B4-0x0000000188CDD8A0
		public void SetFluidHeightAndRefreshThickness(float value); // 0x0000000185D31E70-0x0000000185D31F10
		public void RefreshWaterThicknessByFirstIndex(); // 0x0000000185D31F10-0x0000000185D31FE0
		public bool ShouldPreserveFill(uint incomingItemId); // 0x00000001827C73B0-0x00000001827C73D0
		public void RememberItem(uint incomingItemId); // 0x00000001827C7380-0x00000001827C7390
		public void ResetFill(long tms); // 0x00000001827C73A0-0x00000001827C73B0
		public void MergeSnapshotFill(float computedFirstIndex, long incomingFirstItemTms); // 0x00000001827C7350-0x00000001827C7380
		public void ReplaceSnapshotFill(float computedFirstIndex, long incomingFirstItemTms); // 0x00000001827C7390-0x00000001827C73A0
		private void __AOT_FOR_FIX__(); // 0x0000000188CDDD6C-0x0000000188CDDE68
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeHolderFragment : IComponentECS // TypeDefIndex: 79569
	{
		// Fields
		public int indexInPipe; // 0x00
		public Entity pipeEntity; // 0x04
		public const int ID = 75; // Metadata: 0x0263B97B
	
		// Properties
		public int id { get; } // 0x000000018723A750-0x000000018723A760 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDDE68-0x0000000188CDDF44
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeLogisticsUnitFragment : IComponentECS // TypeDefIndex: 79570
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 76; // Metadata: 0x0263B97D
	
		// Properties
		public int id { get; } // 0x000000018723A760-0x000000018723A770 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDDF44-0x0000000188CDE014
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeComRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79571
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 77; // Metadata: 0x0263B97F
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x000000018723A720-0x000000018723A730 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDD494-0x0000000188CDD570
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct PipeRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79572
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int indexInPipe; // 0x04
		public FixedString32Bytes prototype; // 0x08
		public float3 position; // 0x28
		public float scale; // 0x34
		public quaternion rotation; // 0x38
		public HGFactoryEntityTransformData transformData; // 0x28
		public const int ID = 78; // Metadata: 0x0263B981
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x000000018723A7A0-0x000000018723A7B0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDE290-0x0000000188CDE370
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeTrackRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79573
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 79; // Metadata: 0x0263B983
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x000000018723A7B0-0x000000018723A7C0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDE370-0x0000000188CDE44C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ComplexPortFragment : IComponentECS, IEquatable<ComplexPortFragment> // TypeDefIndex: 79574
	{
		// Fields
		public PortData32<Beyond.Gameplay.Factory.PortData> ports; // 0x00
		public int2 pedestalPortCount; // 0x808
		public int2 pipePortCount; // 0x810
		public bool dataInit; // 0x818
		public const int ID = 80; // Metadata: 0x0263B98B
	
		// Properties
		public int id { get; } // 0x0000000187239D10-0x0000000187239D20 
	
		// Methods
		public void ResetBannedState(); // 0x00000001855D2170-0x00000001855D21D0
		public void AllowAdditivePort(int additivePortIdx, bool input = true /* Metadata: 0x0263B985 */, bool bPipe = true /* Metadata: 0x0263B986 */); // 0x0000000188CD6020-0x0000000188CD60D0
		public void BanPort(bool input, bool bPipe, List<int> allowedPortIndexList); // 0x00000001855D2AE0-0x00000001855D2B90
		public bool BindComponentId(uint componentId, int idx, bool isInput, bool isBlock, uint touchComId, out bool pipeChanged); // 0x00000001855D29E0-0x00000001855D2AE0
		public bool BlockPortsWithComponentId(uint componentId, bool isBlock, int[] portIndices); // 0x0000000188CD61E0-0x0000000188CD62C0
		public bool BlockPorts(bool isBlock, List<int> portIndices, bool input); // 0x00000001855D32C0-0x00000001855D34F0
		public void FollowUnit(float3 worldPos, float3 worldDir, ref GlobalSharedData.UnitPortConfig portConfig, ref UnitConfigFragment unitConfig, float effectOffset = 0.5f /* Metadata: 0x0263B987 */); // 0x00000001855D2C40-0x00000001855D32C0
		public bool AnyPortBlocked(); // 0x0000000188CD60D0-0x0000000188CD6164
		public bool AnyPortConnected(); // 0x0000000188CD6164-0x0000000188CD61E0
		public bool Equals(ComplexPortFragment other); // 0x0000000188CD6340-0x0000000188CD64E8
		public override bool Equals(object obj); // 0x0000000188CD62C0-0x0000000188CD6340
		public override int GetHashCode(); // 0x0000000188CD64E8-0x0000000188CD66B0
		public static bool operator ==(ComplexPortFragment left, ComplexPortFragment right); // 0x0000000188CD6A58-0x0000000188CD6A90
		public static bool operator !=(ComplexPortFragment left, ComplexPortFragment right); // 0x0000000188CD6A90-0x0000000188CD6AC8
		public override string ToString(); // 0x0000000188CD66B0-0x0000000188CD6954
		private void __AOT_FOR_FIX__(); // 0x0000000188CD6954-0x0000000188CD6A58
	}

	public struct PortData : IEquatable<Beyond.Gameplay.Factory.PortData> // TypeDefIndex: 79575
	{
		// Fields
		public byte idx; // 0x00
		public bool isInput; // 0x01
		public bool isPipe; // 0x02
		public bool isBlock; // 0x03
		public bool valid; // 0x04
		public bool evaluated; // 0x05
		public bool banned; // 0x06
		public uint touchComId; // 0x08
		public uint bindComId; // 0x0C
		public uint touchNodeId; // 0x10
		public float3 worldPos; // 0x14
		public quaternion worldDir; // 0x20
		public quaternion localDir; // 0x30
	
		// Properties
		public bool isUsable { get; } // 0x00000001855D34F0-0x00000001855D3510 
	
		// Methods
		public float4x4 TRS(); // 0x0000000188CDE774-0x0000000188CDE7F8
		public bool Equals(PortData other); // 0x0000000188CDE4D4-0x0000000188CDE5D4
		public override bool Equals(object obj); // 0x0000000188CDE44C-0x0000000188CDE4D4
		public override int GetHashCode(); // 0x0000000188CDE5D4-0x0000000188CDE774
		public static bool operator ==(PortData left, PortData right); // 0x0000000188CDEB2C-0x0000000188CDEB68
		public static bool operator !=(PortData left, PortData right); // 0x0000000188CDEB68-0x0000000188CDEBA4
		public override string ToString(); // 0x0000000188CDE7F8-0x0000000188CDEB2C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PortPreviewUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79576
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 81; // Metadata: 0x0263B98D
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x000000018723A7C0-0x000000018723A7D0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDEBA4-0x0000000188CDEC78
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PortStatusUIFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79577
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 82; // Metadata: 0x0263B98F
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x000000018723A7D0-0x000000018723A7E0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDEC78-0x0000000188CDED4C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ProducerFragment : IComponentECS // TypeDefIndex: 79578
	{
		// Fields
		public uint componentId; // 0x00
		public long currentProgress; // 0x08
		public uint formulaId; // 0x10
		public uint lastFormulaId; // 0x14
		public const int ID = 83; // Metadata: 0x0263B991
	
		// Properties
		public uint outputFormulaId { get; } // 0x00000001852CAAB0-0x00000001852CAAC0 
		public int id { get; } // 0x000000018723A7E0-0x000000018723A7F0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CDEEA4-0x0000000188CDEF84
	}

	[BurstCompatible]
	[ECSComponent]
	public struct SharedDataFragment : IComponentECS // TypeDefIndex: 79579
	{
		// Fields
		public uint dataHandle; // 0x00
		public const int ID = 84; // Metadata: 0x0263B993
	
		// Properties
		public int id { get; } // 0x000000018723A820-0x000000018723A830 
	
		// Methods
		public ref SharedDataContainer.SharedExtData GetExtData(); // 0x000000018723A800-0x000000018723A820
		public SharedDataContainer.SharedExtData GetExtDataCopy(); // 0x0000000188CDF054-0x0000000188CDF08C
		public void SetExtDataValue(SharedDataContainer.SharedExtData value); // 0x0000000188CDF08C-0x0000000188CDF0C0
		public void DestroyData(); // 0x00000001858692D0-0x0000000185869300
		private void __AOT_FOR_FIX__(); // 0x0000000188CDF0C0-0x0000000188CDF194
	}

	public enum SocialBuildingStates : uint // TypeDefIndex: 79580
	{
		Invalid = 0,
		Disable = 1,
		Unlocked = 2,
		Activated = 3,
		Locked = 4
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct SocialFragment : IComponentECS // TypeDefIndex: 79582
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
		public const int ID = 85; // Metadata: 0x0263B99A
	
		// Properties
		public int id { get; } // 0x000000018723A850-0x000000018723A860 
	
		// Nested types
		[Flags]
		public enum EOwner // TypeDefIndex: 79581
		{
			MINE = 1,
			OTHERS = 2,
			ALL = 3
		}
	
		// Methods
		public static SocialFragment Create(ulong ownerId, uint socialNodeId, ulong like, long lastSetLikeTs, long expirationTs, uint socialState, bool isPreset); // 0x000000018662AAE0-0x000000018662AB20
		public bool IsHighLiked(); // 0x0000000185C93DA0-0x0000000185C93E50
		public bool IsLiked(); // 0x0000000188CDF334-0x0000000188CDF380
		private void __AOT_FOR_FIX__(); // 0x0000000188CDF380-0x0000000188CDF468
	}

	public struct SignData // TypeDefIndex: 79583
	{
		// Fields
		public uint3 content; // 0x00
		public const int CONTENT_LENGTH = 3; // Metadata: 0x0263B99F
	
		// Methods
		public string GetText(); // 0x00000001857305E0-0x0000000185730740
		public static float GetCustomPerDrawData(FactoryUIAtlasSOData config, uint3 content); // 0x0000000185731E80-0x0000000185732050
		public static void SetSignBuildingIcon(FactoryUIAtlasSOData data, ref EntityManager em, Entity logicEntity); // 0x0000000185731B40-0x0000000185731E80
		public static void SetSignBuildingIconWithRenderEntity(FactoryUIAtlasSOData config, Entity rEntity, uint3 iconId); // 0x0000000185732150-0x0000000185732890
	}

	[BurstCompatible]
	[ECSComponent]
	public struct SoilFragment : IComponentECS // TypeDefIndex: 79585
	{
		// Fields
		public const int EXTRA_STATUS_MUTATION = 1; // Metadata: 0x0263B9A0
		public const int EXTRA_STATUS_NEIGHBOR_INCREASE = 2; // Metadata: 0x0263B9A1
		public const int EXTRA_STATUS_MUTATIONING = 4; // Metadata: 0x0263B9A2
		public const int EXTRA_STATUS_NEIGHBOR_INCREASING = 8; // Metadata: 0x0263B9A3
		public int curStep; // 0x00
		public CropRenderFragment.RenderStatus cropRenderStatus; // 0x04
		public bool isSoilWet; // 0x08
		public long soilSyncTimestampMs; // 0x10
		public int autoOpProgress; // 0x18
		public int soilExtraStatus; // 0x1C
		public SoilStatus neighborStatus; // 0x20
		public int neighboringEffectInstanceId; // 0x24
		public int neighborIncreaseProgress; // 0x28
		public SoilStatus mutatingStatus; // 0x2C
		public int mutatingEffectInstanceId; // 0x30
		public int mutationProgress; // 0x34
		public int increasedType; // 0x38
		public int fertilizeEffectInstanceId; // 0x3C
		public FixedList128Bytes<Entity> parkedCropRenderEntities; // 0x40
		public const int ID = 86; // Metadata: 0x0263B9A4
	
		// Properties
		public int id { get; } // 0x000000018723A860-0x000000018723A870 
	
		// Nested types
		public enum SoilStatus // TypeDefIndex: 79584
		{
			UNSTARTED = 0,
			PROGRESS = 1,
			PAUSE = 2,
			FINISHED = 3
		}
	
		// Methods
		public void SetSoilExtraStatus(int value, int newMutationProgress, int newNeighborIncreaseProgress); // 0x00000001827C73D0-0x00000001827C7430
		private static SoilStatus _GetSoilStatus(int value, int progressingBit, int finishedBit, int progress); // 0x00000001827C7430-0x00000001827C7460
		private void __AOT_FOR_FIX__(); // 0x0000000188CDF468-0x0000000188CDF564
	}

	[Serializable]
	[BurstCompatible]
	[BurstCompile]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct LocalTransform : IComponentECS // TypeDefIndex: 79586
	{
		// Fields
		public float3 position; // 0x00
		public float scale; // 0x0C
		public quaternion rotation; // 0x10
		public HGFactoryEntityTransformData entityTransformData; // 0x00
		public static readonly LocalTransform IDENTITY; // 0x00
		public const int ID = 87; // Metadata: 0x0263B9AA
	
		// Properties
		public int id { get; } // 0x000000018723A5E0-0x000000018723A5F0 
	
		// Constructors
		static LocalTransform(); // 0x0000000187113E00-0x0000000187113EA0
	
		// Methods
		public static LocalTransform FromMatrix(float4x4 matrix); // 0x0000000188CDBBA0-0x0000000188CDBDD0
		public static LocalTransform FromMatrixSafe(float4x4 matrix); // 0x0000000188CDB6A4-0x0000000188CDBBA0
		public static LocalTransform FromPositionRotation(float3 position, quaternion rotation); // 0x000000018723A500-0x000000018723A530
		public static LocalTransform FromPositionRotationScale(float3 position, quaternion rotation, float scale); // 0x000000018723A4E0-0x000000018723A500
		public static LocalTransform FromPosition(float3 position); // 0x0000000188CDBE54-0x0000000188CDBEBC
		public static LocalTransform FromPosition(float x, float y, float z); // 0x0000000188CDBDD0-0x0000000188CDBE54
		public static LocalTransform FromRotation(quaternion rotation); // 0x0000000188CDBEBC-0x0000000188CDBF24
		public static LocalTransform FromScale(float scale); // 0x0000000188CDBF24-0x0000000188CDBFA4
		public override string ToString(); // 0x0000000188CDC650-0x0000000188CDC778
		public float3 Right(); // 0x0000000188CDC308-0x0000000188CDC398
		public float3 Up(); // 0x0000000188CDC844-0x0000000188CDC8E0
		public float3 Forward(); // 0x0000000188CDB608-0x0000000188CDB6A4
		public float3 TransformPoint(float3 point); // 0x0000000185733A90-0x0000000185733B50
		public float3 InverseTransformPoint(float3 point); // 0x0000000188CDC010-0x0000000188CDC0E0
		public float3 TransformDirection(float3 direction); // 0x0000000188CDC778-0x0000000188CDC7CC
		public float3 InverseTransformDirection(float3 direction); // 0x0000000188CDBFA4-0x0000000188CDC010
		public quaternion TransformRotation(quaternion rotation); // 0x0000000185733A50-0x0000000185733A90
		public quaternion InverseTransformRotation(quaternion rotation); // 0x0000000188CDC0E0-0x0000000188CDC138
		public float TransformScale(float scale); // 0x000000018723A530-0x000000018723A540
		public float InverseTransformScale(float scale); // 0x0000000188CDC138-0x0000000188CDC144
		public LocalTransform TransformTransform([IsReadOnly] in LocalTransform transformData); // 0x0000000185733970-0x0000000185733A50
		public LocalTransform InverseTransformTransform([IsReadOnly] in LocalTransform transformData); // 0x0000000188CDC144-0x0000000188CDC220
		public LocalTransform Inverse(); // 0x0000000188CDC220-0x0000000188CDC308
		public float4x4 ToMatrix(); // 0x0000000185734F80-0x0000000185735100
		public float4x4 ToInverseMatrix(); // 0x0000000188CDC5B0-0x0000000188CDC650
		public LocalTransform WithPosition(float3 p); // 0x000000018723A540-0x000000018723A570
		public LocalTransform WithPosition(float x, float y, float z); // 0x000000018723A570-0x000000018723A5A0
		public LocalTransform WithRotation(quaternion r); // 0x000000018723A5A0-0x000000018723A5C0
		public LocalTransform WithScale(float s); // 0x000000018723A5C0-0x000000018723A5E0
		public LocalTransform Translate(float3 translation); // 0x0000000188CDC7CC-0x0000000188CDC844
		public LocalTransform ApplyScale(float scale); // 0x000000018723A4B0-0x000000018723A4E0
		public LocalTransform Rotate(quaternion rotation); // 0x0000000188CDC548-0x0000000188CDC5B0
		public LocalTransform RotateX(float angle); // 0x0000000188CDC398-0x0000000188CDC428
		public LocalTransform RotateY(float angle); // 0x0000000188CDC428-0x0000000188CDC4B8
		public LocalTransform RotateZ(float angle); // 0x0000000188CDC4B8-0x0000000188CDC548
		public bool Equals([IsReadOnly] in LocalTransform other); // 0x0000000188CDB5A4-0x0000000188CDB608
		private void __AOT_FOR_FIX__(); // 0x0000000188CDC8E0-0x0000000188CDC9BC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct Root : IComponentECS // TypeDefIndex: 79587
	{
		// Fields
		public const int ID = 88; // Metadata: 0x0263B9AC
	
		// Properties
		public int id { get; } // 0x000000018723ACB0-0x000000018723ACC0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE8804-0x0000000188CE88D4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct Parent : IComponentECS // TypeDefIndex: 79588
	{
		// Fields
		public Entity value; // 0x00
		public const int ID = 89; // Metadata: 0x0263B9AE
	
		// Properties
		public int id { get; } // 0x000000018723AB60-0x000000018723AB70 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE8208-0x0000000188CE82DC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct Child : IComponentECS // TypeDefIndex: 79589
	{
		// Fields
		public EntityData32<Entity> value; // 0x00
		public const int ID = 90; // Metadata: 0x0263B9B0
	
		// Properties
		public int id { get; } // 0x000000018723A950-0x000000018723A960 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE7814-0x0000000188CE7910
	}

	[BurstCompatible]
	[ECSComponent]
	public struct LocalToWorld : IComponentECS // TypeDefIndex: 79590
	{
		// Fields
		public float4x4 READ_ONLY_VAL; // 0x00
		public float4x4 PRE_FRAME_READ_ONLY_VAL; // 0x40
		public uint hierarchyHandle; // 0x80
		public bool dirty; // 0x84
		public int calcFrameCount; // 0x88
		public const int ID = 91; // Metadata: 0x0263B9B2
	
		// Properties
		public float3 right { get; } // 0x0000000187235870-0x0000000187235890 
		public float3 up { get; } // 0x000000018723AA40-0x000000018723AA60 
		public float3 forward { get; } // 0x000000018723A9D0-0x000000018723A9F0 
		public float3 position { get; } // 0x000000018723AA00-0x000000018723AA20 
		public quaternion rotation { get; } // 0x000000018598A010-0x000000018598A0D0 
		public float3 prePosition { get; } // 0x000000018723AA20-0x000000018723AA40 
		public quaternion preRotation { get; } // 0x0000000188CE8150-0x0000000188CE8208 
		public unsafe float4x4* READ_ONLY_VAL_PTR { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		public unsafe float4x4* PRE_FRAME_READ_ONLY_VAL_PTR { get; } // 0x000000018723A9C0-0x000000018723A9D0 
		public int id { get; } // 0x000000018723A9F0-0x000000018723AA00 
	
		// Methods
		public bool SetValue(float4x4 value, int frameCount); // 0x0000000185735280-0x00000001857352E0
		private void __AOT_FOR_FIX__(); // 0x0000000188CE8054-0x0000000188CE8150
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UdPipeFragment : IComponentECS // TypeDefIndex: 79591
	{
		// Fields
		public ulong connectedCompId; // 0x00
		public int offset; // 0x08
		public int lastPassItemId; // 0x0C
		public const int ID = 92; // Metadata: 0x0263B9B4
	
		// Properties
		public int id { get; } // 0x000000018723ADA0-0x000000018723ADB0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE8BA0-0x0000000188CE8C78
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitConfigFragment : IComponentECS // TypeDefIndex: 79592
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int powerCost; // 0x04
		public bool isShowOutputUI; // 0x08
		public bool needPower; // 0x09
		public bool bypassPowerCheck; // 0x0A
		public bool hidePreviewArrow; // 0x0B
		public bool enableSnowCoverage; // 0x0C
		public bool suppressExternalAutoDither; // 0x0D
		public short inputPortCount; // 0x0E
		public short outputPortCount; // 0x10
		public int facBuildingType; // 0x14
		public float3 bounds; // 0x18
		public int unitNameFastString; // 0x24
		public int iconOnPanelFastString; // 0x28
		public UnitConfigInternal baseConfig; // 0x2C
		public const int ID = 93; // Metadata: 0x0263B9B6
	
		// Properties
		public string iconOnPanel { get; set; } // 0x000000018519BAE0-0x000000018519BB30 0x00000001850B0530-0x00000001850B05A0
		public string unitName { get; set; } // 0x0000000188CE8D60-0x0000000188CE8DAC 0x00000001850B06F0-0x00000001850B0730
		public int id { get; } // 0x000000018723ADB0-0x000000018723ADC0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE8C78-0x0000000188CE8D60
	}

	[Serializable]
	public struct UnitConfigInternal // TypeDefIndex: 79593
	{
		// Fields
		public Bounds bounds; // 0x00
		public Bounds buildingBounds; // 0x18
	}

	[Serializable]
	public struct FactoryUnitPortConfig // TypeDefIndex: 79594
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
	public struct FactoryUnitExtendConfig // TypeDefIndex: 79595
	{
		// Fields
		[HideInInspector]
		public FixedString32Bytes nameRaw; // 0x00
		public float3 pos; // 0x20
		public quaternion rot; // 0x2C
		[CompilerGenerated]
		private int _unLoaderIndex_k__BackingField; // 0x3C
		[CompilerGenerated]
		private bool _isUnLoader_k__BackingField; // 0x40
	
		// Properties
		public string name { get; } // 0x000000018783B020-0x000000018783B02C 
		public int unLoaderIndex { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x000000018226F000-0x000000018226F010 0x000000018226F010-0x000000018226F020
		public bool isUnLoader { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
	
		// Methods
		public override string ToString(); // 0x0000000188CE7D68-0x0000000188CE7F20
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitEnvironmentRelation : IComponentECS // TypeDefIndex: 79596
	{
		// Fields
		public int envTypeRaw; // 0x00
		public byte envRenderAtlasIdx; // 0x04
		public int envEffectInstanceId; // 0x08
		public byte envParam; // 0x0C
		public bool generatorOrReceiver; // 0x0D
		public float4 rendererUV; // 0x10
		public const int ID = 94; // Metadata: 0x0263B9B8
	
		// Properties
		public FacEnvGenEnvType envType { get; } // 0x00000001844AD290-0x00000001844AD2A0 
		public int id { get; } // 0x000000018723ADC0-0x000000018723ADD0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE8DAC-0x0000000188CE8E88
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitInteractFragment : IComponentECS // TypeDefIndex: 79597
	{
		// Fields
		public ulong interactObjectId; // 0x00
		public const int ID = 95; // Metadata: 0x0263B9BA
	
		// Properties
		public int id { get; } // 0x000000018723AE00-0x000000018723AE10 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE8EEC-0x0000000188CE8FC0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79598
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
		public const int ID = 96; // Metadata: 0x0263B9BC
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001872336F0-0x0000000187233700 0x0000000187233700-0x0000000187233710
		public int id { get; } // 0x000000018723AE20-0x000000018723AE30 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE9284-0x0000000188CE936C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct RenderLookAtFragment : IComponentECS // TypeDefIndex: 79599
	{
		// Fields
		public bool lookAtEnable; // 0x00
		public bool lookAtArrived; // 0x01
		public bool yawEnabled; // 0x02
		public bool pitchEnabled; // 0x03
		public quaternion deltaQuaternion; // 0x04
		public float3 targetPos; // 0x14
		public half interpolation; // 0x20
		public const int ID = 97; // Metadata: 0x0263B9BE
	
		// Properties
		public int id { get; } // 0x000000018723ACA0-0x000000018723ACB0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE8720-0x0000000188CE8804
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ChapterTagFragment : IComponentECS // TypeDefIndex: 79600
	{
		// Fields
		public int chapterId; // 0x00
		public int mapId; // 0x04
		public int panelIndex; // 0x08
		public int sceneId; // 0x0C
		public const int ID = 98; // Metadata: 0x0263B9C0
	
		// Properties
		public int id { get; } // 0x000000018723A940-0x000000018723A950 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE773C-0x0000000188CE7814
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitStatusFragment : IComponentECS // TypeDefIndex: 79601
	{
		// Fields
		public byte preStatus; // 0x00
		public byte status; // 0x01
		public byte subStatus; // 0x02
		public const int ID = 99; // Metadata: 0x0263B9C2
	
		// Properties
		public int id { get; } // 0x000000018723AE40-0x000000018723AE50 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE9444-0x0000000188CE951C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitOverrideStatusFragment : IComponentECS // TypeDefIndex: 79602
	{
		// Fields
		public bool working; // 0x00
		public const int ID = 100; // Metadata: 0x0263B9C4
	
		// Properties
		public int id { get; } // 0x000000018723AE10-0x000000018723AE20 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE8FC0-0x0000000188CE9090
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitStatusEffectFragment : IComponentECS // TypeDefIndex: 79603
	{
		// Fields
		public const int MAX_EFFECT_COUNT = 3; // Metadata: 0x0263B9C6
		public int effectConfigInstanceId; // 0x00
		public int3 effectInstanceIdList; // 0x04
		public const int ID = 101; // Metadata: 0x0263B9C7
	
		// Properties
		public int id { get; } // 0x000000018723AE30-0x000000018723AE40 
	
		// Methods
		public void SetEffectConfig(int instanceId, SerializeFieldDictionary<FacBuildingState, FacEffectCfgList> effectCfgs); // 0x00000001864353D0-0x0000000186435410
		public List<StatusSingleEffect> GetEffect(FacBuildingState status); // 0x000000018519D400-0x000000018519D5B0
		private void __AOT_FOR_FIX__(); // 0x0000000188CE936C-0x0000000188CE9444
	}

	public static class StatusEffectConfigCache // TypeDefIndex: 79604
	{
		// Fields
		private static readonly Dictionary<int, SerializeFieldDictionary<FacBuildingState, FacEffectCfgList>> s_cache; // 0x00
	
		// Constructors
		static StatusEffectConfigCache(); // 0x0000000187176BB0-0x0000000187176C40
	
		// Methods
		public static void Register(int instanceId, SerializeFieldDictionary<FacBuildingState, FacEffectCfgList> configs); // 0x0000000186435410-0x0000000186435470
		public static List<StatusSingleEffect> GetEffects(int instanceId, FacBuildingState state); // 0x000000018519D5B0-0x000000018519D750
		public static void Clear(); // 0x0000000188CE8994-0x0000000188CE89F8
	}

	[Serializable]
	public struct StatusSingleEffect // TypeDefIndex: 79605
	{
		// Fields
		public BuildingNodeMode mode; // 0x00
		public BuildingSubState subState; // 0x01
		[HideInInspector]
		public FixedString64Bytes name; // 0x02
		public float3 offset; // 0x44
		public bool needAlignToBuilding; // 0x50
	
		// Properties
		public string effectName { get; set; } // 0x000000018519FF80-0x000000018519FFC0 0x0000000188CE89F8-0x0000000188CE8A50
	}

	[Serializable]
	public class FacEffectCfgList // TypeDefIndex: 79606
	{
		// Fields
		public List<StatusSingleEffect> list; // 0x10
	
		// Properties
		public int cfgCount { get; } // 0x0000000188CE7C68-0x0000000188CE7CA8 
	
		// Constructors
		public FacEffectCfgList(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public enum BuildingStatus // TypeDefIndex: 79607
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
		PORT_DISCONNECT = 12,
		INACTIVE = 13,
		MAX = 16
	}

	[Flags]
	public enum BuildingSubState : byte // TypeDefIndex: 79608
	{
		NONE = 0,
		SUB_STATE_1 = 1,
		SUB_STATE_2 = 2,
		SUB_STATE_3 = 4,
		SUB_STATE_4 = 8,
		ANY = 15
	}

	[Flags]
	public enum BuildingNodeMode : byte // TypeDefIndex: 79609
	{
		None = 0,
		NORMAL = 1,
		LIQUID = 2,
		GAS = 4,
		GAS_LIQUID = 8,
		GAS_TRANS = 16,
		LIQUID_TRANS = 32,
		SOLID_TRANS = 64,
		All = 127
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitStatusUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79610
	{
		// Fields
		[CompilerGenerated]
		private int _unitConfigAssetInstanceId_k__BackingField; // 0x00
		public const int ID = 102; // Metadata: 0x0263B9E7
	
		// Properties
		public int unitConfigAssetInstanceId { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x000000018723AE50-0x000000018723AE60 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE951C-0x0000000188CE95F0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitTransFragment : IComponentECS, IRotateFragment, IPositionFragment // TypeDefIndex: 79611
	{
		// Fields
		public float3 __position; // 0x00
		public float3 __rotation; // 0x0C
		public float3 cornerLD; // 0x18
		public float3 cornerRU; // 0x24
		public const int ID = 103; // Metadata: 0x0263B9EA
	
		// Properties
		public quaternion RotationQuaternion { get; } // 0x000000018509D8F0-0x000000018509DAB0 
		public float3 Position { get; set; } // 0x000000018723AE60-0x000000018723AE80 0x000000018723AEB0-0x000000018723AEC0
		public float3 Rotation { get; set; } // 0x000000018723AE80-0x000000018723AEA0 0x000000018723AEC0-0x000000018723AED0
		public int id { get; } // 0x000000018723AEA0-0x000000018723AEB0 
	
		// Methods
		public bool InBound(float3 pos, bool ignoreY = true /* Metadata: 0x0263B9E9 */); // 0x0000000188CE95F0-0x0000000188CE96F8
		public RectInt Get2DRectInt(); // 0x00000001850ADBD0-0x00000001850ADC90
		private void __AOT_FOR_FIX__(); // 0x0000000188CE96F8-0x0000000188CE97D8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ValveFragment : IComponentECS // TypeDefIndex: 79612
	{
		// Fields
		public bool enable; // 0x00
		public uint selectedItemId; // 0x04
		public int passed; // 0x08
		public int currentPassed; // 0x0C
		public bool speedLimitEnable; // 0x10
		public int speedLimitValue; // 0x14
		public FactoryItem holdItem; // 0x18
		public const int ID = 104; // Metadata: 0x0263B9EC
	
		// Properties
		public int id { get; } // 0x000000018723AED0-0x000000018723AEE0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE9F90-0x0000000188CEA074
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BoxValve : IComponentECS // TypeDefIndex: 79613
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 105; // Metadata: 0x0263B9EE
	
		// Properties
		public int id { get; } // 0x000000018723A930-0x000000018723A940 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE766C-0x0000000188CE773C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidValve : IComponentECS // TypeDefIndex: 79614
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 106; // Metadata: 0x0263B9F0
	
		// Properties
		public int id { get; } // 0x000000018723A9B0-0x000000018723A9C0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CE7F20-0x0000000188CE7FF0
	}

	public struct BlueprintSlotInfo // TypeDefIndex: 79622
	{
		// Fields
		public const int RELATED_SLOT_ID = -1; // Metadata: 0x0263B9F3
		public const int SLOT_MAX_COUNT = 6; // Metadata: 0x0263B9F4
		public const int UNIT_MAX_COUNT_PER_SLOT = 256; // Metadata: 0x0263B9F5
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo0[0]; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo1[0]; // 0x800
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo2[0]; // 0x1000
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo3[0]; // 0x1800
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo4[0]; // 0x2000
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo5[0]; // 0x2800
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintRelatedSlotInfo[0]; // 0x3000
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintSlotInfo0_e__FixedBuffer // TypeDefIndex: 79615
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintSlotInfo1_e__FixedBuffer // TypeDefIndex: 79616
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintSlotInfo2_e__FixedBuffer // TypeDefIndex: 79617
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintSlotInfo3_e__FixedBuffer // TypeDefIndex: 79618
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintSlotInfo4_e__FixedBuffer // TypeDefIndex: 79619
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintSlotInfo5_e__FixedBuffer // TypeDefIndex: 79620
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintRelatedSlotInfo_e__FixedBuffer // TypeDefIndex: 79621
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		// Methods
		public bool ContainsNodeId(ref EntityManager em, int slotId, int nodeId); // 0x0000000188CE6E2C-0x0000000188CE6F1C
		public void RemoveEntityFromSlot(ref EntityManager em, int slotId, Entity overdueEntity); // 0x0000000188CE70EC-0x0000000188CE71A8
		public int FindEmptySlotIdx(); // 0x0000000188CE6F1C-0x0000000188CE6F58
		public int GetSuitableSlotIdx(int slotId); // 0x0000000188CE70A8-0x0000000188CE70EC
		public void SetSlotId(int index, int slotId); // 0x0000000188CE71A8-0x0000000188CE71CC
		public ulong[] GetSlotIds(); // 0x00000001856E7AE0-0x00000001856E7B70
		public void AppendSlotInfo(int slotId, Entity logicEntity); // 0x0000000188CE6D3C-0x0000000188CE6DE4
		public Entity[] ClearSlotInfo(int slotId); // 0x0000000188CE6DE4-0x0000000188CE6E2C
		private unsafe Entity[] _ClearSlotInfo(ulong* slotGroupPtr); // 0x0000000188CE7538-0x0000000188CE766C
		public void DiffSlotInfo(ref EntityManager em, int slotId, ref PooledList<uint> baseList, ref PooledList<uint> newList, ref PooledList<Entity> overdueList); // 0x00000001856E78E0-0x00000001856E7A90
		public NativeArray<Entity> GetAllPendingEntitiesInSlot(int slotId); // 0x0000000188CE6F58-0x0000000188CE7028
		public Entity GetSlotInfo(int slotId, int index); // 0x0000000188CE7058-0x0000000188CE70A8
		public ulong GetPendingEntityCountInSlot(int slotId); // 0x0000000188CE7028-0x0000000188CE7058
		public unsafe ulong* GetSlotGroupWithSlotId(int slotId, out int slotIdx, bool includeInvalid = true /* Metadata: 0x0263B9F2 */); // 0x00000001856E7A90-0x00000001856E7AE0
		public unsafe ulong* GetRelatedSlotGroup(); // 0x000000018723A920-0x000000018723A930
		public unsafe ulong* GetSlotGroup(int index); // 0x00000001856E7B70-0x00000001856E7C00
		public static BlueprintSlotInfo CreateDefault(); // 0x00000001856E8EC0-0x00000001856E8F20
		public override string ToString(); // 0x0000000188CE71CC-0x0000000188CE7538
	}

	[DataN(capacity = 4096, tSize = 72, ring = false, native = true)]
	[NoAlias]
	public struct CargoRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 79624
		where T : struct
	{
		// Fields
		public const int T_SIZE = 72; // Metadata: 0x0263B9FA
		public const int CAPACITY = 4096; // Metadata: 0x0263B9FC
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x0263B9FE
		public const int INVALID_INDEX = -1; // Metadata: 0x0263BA00
		private int m_beginIndex;
		private int m_endIndex;
		private unsafe byte* m_data;
		private Unity.Collections.Allocator m_allocator;
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79623
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private CargoRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in CargoRendererInfoCollection<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		// Constructors
		public unsafe CargoRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x0263B9F7 */, bool autoExtend = false /* Metadata: 0x0263B9F9 */);
	
		// Methods
		public unsafe T* GetDataPtr();
		public static unsafe CargoRendererInfoCollection<T>* Create(Unity.Collections.Allocator allocator);
		public void SafeDispose();
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	public struct CargoRendererInfo // TypeDefIndex: 79625
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

	[DataN(capacity = 4096, tSize = 64, ring = false, native = true)]
	[NoAlias]
	public struct ConveyorRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 79627
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0263BA04
		public const int CAPACITY = 4096; // Metadata: 0x0263BA06
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x0263BA08
		public const int INVALID_INDEX = -1; // Metadata: 0x0263BA0A
		private int m_beginIndex;
		private int m_endIndex;
		private unsafe byte* m_data;
		private Unity.Collections.Allocator m_allocator;
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79626
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private ConveyorRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in ConveyorRendererInfoCollection<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		// Constructors
		public unsafe ConveyorRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x0263BA01 */, bool autoExtend = false /* Metadata: 0x0263BA03 */);
	
		// Methods
		public unsafe T* GetDataPtr();
		public static unsafe ConveyorRendererInfoCollection<T>* Create(Unity.Collections.Allocator allocator);
		public void SafeDispose();
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	public struct ConveyorRendererInfo // TypeDefIndex: 79628
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
		public override string ToString(); // 0x0000000188CE7910-0x0000000188CE7C68
	}

	public struct FactoryItem // TypeDefIndex: 79629
	{
		// Fields
		public uint itemId; // 0x00
		public int itemAmount; // 0x04
		public long tms; // 0x08
	}

	[DataN(capacity = 4096, tSize = 64, ring = false, native = true)]
	[NoAlias]
	public struct PipeRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 79631
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0263BA0E
		public const int CAPACITY = 4096; // Metadata: 0x0263BA10
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x0263BA12
		public const int INVALID_INDEX = -1; // Metadata: 0x0263BA14
		private int m_beginIndex;
		private int m_endIndex;
		private unsafe byte* m_data;
		private Unity.Collections.Allocator m_allocator;
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79630
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PipeRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in PipeRendererInfoCollection<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		// Constructors
		public unsafe PipeRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x0263BA0B */, bool autoExtend = false /* Metadata: 0x0263BA0D */);
	
		// Methods
		public unsafe T* GetDataPtr();
		public static unsafe PipeRendererInfoCollection<T>* Create(Unity.Collections.Allocator allocator);
		public void SafeDispose();
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	[DataN(capacity = 128, tSize = 64, ring = false, native = true)]
	[NoAlias]
	public struct PipeTrackRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 79633
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0263BA18
		public const int CAPACITY = 128; // Metadata: 0x0263BA1A
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x0263BA1C
		public const int INVALID_INDEX = -1; // Metadata: 0x0263BA1E
		private int m_beginIndex;
		private int m_endIndex;
		private unsafe byte* m_data;
		private Unity.Collections.Allocator m_allocator;
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79632
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PipeTrackRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in PipeTrackRendererInfoCollection<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		// Constructors
		public unsafe PipeTrackRendererInfoCollection(int initialCapacity = 128 /* Metadata: 0x0263BA15 */, bool autoExtend = false /* Metadata: 0x0263BA17 */);
	
		// Methods
		public unsafe T* GetDataPtr();
		public static unsafe PipeTrackRendererInfoCollection<T>* Create(Unity.Collections.Allocator allocator);
		public void SafeDispose();
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	public struct PipeRendererInfo // TypeDefIndex: 79634
	{
		// Fields
		public int index; // 0x00
		public int totalLength; // 0x04
		public float waterDirection; // 0x08
		public float waterThickness; // 0x0C
		public float waterFlowDeltaTime; // 0x10
		public float firstIndex; // 0x14
		public uint sharedDataHandle; // 0x18
		public float bend; // 0x1C
		public uint lightMode; // 0x20
		public short subItemType; // 0x24
		public byte packedMeta; // 0x26
		public float3 position; // 0x28
		public float3 rotation; // 0x34
	
		// Methods
		public static byte PackPackedMeta(byte proto, bool isPreview, bool valid, bool highLight, BlueprintState.EffectType blueprint); // 0x0000000188CE8554-0x0000000188CE8578
		[IsReadOnly]
		public byte GetProto(); // 0x000000018723AC70-0x000000018723AC80
		[IsReadOnly]
		public bool GetIsPreview(); // 0x0000000188CE8544-0x0000000188CE854C
		[IsReadOnly]
		public bool GetValid(); // 0x0000000188CE854C-0x0000000188CE8554
		[IsReadOnly]
		public bool GetHighLight(); // 0x0000000188CE853C-0x0000000188CE8544
		[IsReadOnly]
		public BlueprintState.EffectType GetBlueprintType(); // 0x000000018723AC60-0x000000018723AC70
	}

	public struct PipeTrackRendererInfo // TypeDefIndex: 79635
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

	[DataN(capacity = 2048, tSize = 64, ring = false, native = true)]
	[NoAlias]
	public struct PortArrowRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 79637
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0263BA22
		public const int CAPACITY = 2048; // Metadata: 0x0263BA24
		public const int CAPACITY_MINUS_ONE = 2047; // Metadata: 0x0263BA26
		public const int INVALID_INDEX = -1; // Metadata: 0x0263BA28
		private int m_beginIndex;
		private int m_endIndex;
		private unsafe byte* m_data;
		private Unity.Collections.Allocator m_allocator;
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79636
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private PortArrowRendererInfoCollection<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in PortArrowRendererInfoCollection<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		// Constructors
		public unsafe PortArrowRendererInfoCollection(int initialCapacity = 2048 /* Metadata: 0x0263BA1F */, bool autoExtend = false /* Metadata: 0x0263BA21 */);
	
		// Methods
		public unsafe T* GetDataPtr();
		public static unsafe PortArrowRendererInfoCollection<T>* Create(Unity.Collections.Allocator allocator);
		public void SafeDispose();
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	public struct PortArrowRendererInfo // TypeDefIndex: 79638
	{
		// Fields
		public float3 pos; // 0x00
		public bool isForbidden; // 0x0C
		public bool isPreview; // 0x0D
		public quaternion rot; // 0x10
		public float4 renderColor; // 0x20
		public float4 atlasUV; // 0x30
	
		// Methods
		public static bool IsPreviewArrow(IntPtr arrowMatricesReaderIntPtr, int index); // 0x00000001827D0460-0x00000001827D07A0
	}

	public struct UnitId : IEquatable<UnitId> // TypeDefIndex: 79639
	{
		// Fields
		public int mapId; // 0x00
		public uint factoryUnitId; // 0x04
	
		// Methods
		public bool Equals(UnitId other); // 0x0000000185BEFFE0-0x0000000185BF0000
		public override bool Equals(object obj); // 0x0000000188CE8E88-0x0000000188CE8EEC
		public override int GetHashCode(); // 0x000000018723ADE0-0x000000018723AE00
		public static UnitId Create(int mapId, uint factoryUnitId); // 0x000000018723ADD0-0x000000018723ADE0
	}

	public struct Visibility // TypeDefIndex: 79643
	{
		// Fields
		public static Visibility s_defaultVal; // 0x00
		public uint visibleFlags; // 0x00
		public short invisibleSubCount; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte invisibleSubBits[0]; // 0x06
		public const int SUB_INDEX_MAX_COUNT = 128; // Metadata: 0x0263BA29
		public const int SUB_BIT_BYTE_COUNT = 16; // Metadata: 0x0263BA2B
	
		// Properties
		public bool isVisible { get; } // 0x000000018509BA40-0x000000018509BAB0 
	
		// Nested types
		[Flags]
		public enum EFlag // TypeDefIndex: 79640
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
	
		[Flags]
		public enum Type : byte // TypeDefIndex: 79641
		{
			BASE = 1,
			ADDITIVE_MAT = 2,
			COLLIDER = 4,
			ALL = 7
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _invisibleSubBits_e__FixedBuffer // TypeDefIndex: 79642
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Constructors
		static Visibility(); // 0x00000001871E4520-0x00000001871E4580
	
		// Methods
		public bool SetVisible(EFlag flag, bool visible); // 0x0000000188CEA0E4-0x0000000188CEA15C
		public unsafe bool SetVisible(EFlag flag, bool visible, short* invisibleIndexListPtr, short invisibleIndexCount); // 0x0000000185665E80-0x0000000185666030
		public bool GetVisible(EFlag flag); // 0x000000018509BAB0-0x000000018509BAC0
		public bool IsSubRendererInvisible(int subIndex); // 0x0000000188CEA074-0x0000000188CEA0E4
		private static unsafe void _SetSubInvisible(byte* head, int index, bool invisible); // 0x0000000188CEA17C-0x0000000188CEA1A8
		private static unsafe bool _GetSubInvisible(byte* head, int index); // 0x0000000188CEA15C-0x0000000188CEA17C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct WireRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 79645
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 107; // Metadata: 0x0263BA3F
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public int id { get; } // 0x000000018723AEE0-0x000000018723AEF0 
	
		// Nested types
		public enum Type : byte // TypeDefIndex: 79644
		{
			NORMAL = 0,
			HS_NORMAL = 1,
			DISABLE = 2,
			STRENGTHEN = 3,
			HS_STRENGTHEN = 4,
			STRENGTHEN_DISABLE = 5
		}
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x0000000188CEA1A8-0x0000000188CEB7FC
	}

	public struct GlobalSharedData // TypeDefIndex: 79670
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
		public struct CullingGlobalSetting // TypeDefIndex: 79646
		{
			// Fields
			public bool bOverride; // 0x00
			public CullingDisSetting setting; // 0x04
			public CullingDisSetting overrideSetting; // 0x14
	
			// Properties
			public float sqrCullDis { get; set; } // 0x00000001855D95F0-0x00000001855D9670 0x000000018723A980-0x000000018723A990
			public float sqrUI { get; set; } // 0x00000001855D95D0-0x00000001855D95F0 0x000000018723A990-0x000000018723A9A0
			public float sqrBuildingName { get; set; } // 0x00000001855D95B0-0x00000001855D95D0 0x000000018723A970-0x000000018723A980
			public float sqrWireCullDis { get; set; } // 0x00000001855D8A30-0x00000001855D8A50 0x000000018723A9A0-0x000000018723A9B0
	
			// Methods
			public void ResetOverride(); // 0x000000018723A960-0x000000018723A970
		}
	
		[Serializable]
		public struct CullingDisSetting // TypeDefIndex: 79647
		{
			// Fields
			public float sqrCullDis; // 0x00
			public float sqrBuildingName; // 0x04
			public float sqrUI; // 0x08
			public float sqrWireCullDis; // 0x0C
		}
	
		public struct NearByDistanceGlobalSetting // TypeDefIndex: 79648
		{
			// Fields
			public bool bOverride; // 0x00
			public NearByDistanceSetting setting; // 0x04
			public NearByDistanceSetting overrideSetting; // 0x20
	
			// Properties
			public bool nearByCheck { get; set; } // 0x000000018561C6F0-0x000000018561C700 0x000000018723AB20-0x000000018723AB30
			public float portPreviewCheckDistance { get; set; } // 0x000000018561B1F0-0x000000018561B210 0x000000018723AB40-0x000000018723AB50
			public float pedestalFlashCheckDistance { get; set; } // 0x0000000186405410-0x0000000186405430 0x000000018723AB30-0x000000018723AB40
			public float logisticEffectCheckDistance { get; set; } // 0x0000000186405430-0x0000000186405570 0x000000018723AB10-0x000000018723AB20
			public float unitRendererCheckDistance { get; set; } // 0x00000001863C1510-0x00000001863C1530 0x000000018723AB50-0x000000018723AB60
			public float l2wCheckDistance { get; set; } // 0x00000001863DE9C0-0x00000001863DE9E0 0x000000018723AB00-0x000000018723AB10
			public float additiveEffectCheckDistance { get; set; } // 0x000000018561C6D0-0x000000018561C6F0 0x000000018723AAF0-0x000000018723AB00
	
			// Methods
			public void ResetOverride(); // 0x000000018723AAD0-0x000000018723AAF0
			public void Disable(); // 0x000000018723AAB0-0x000000018723AAD0
		}
	
		[Serializable]
		public struct NearByDistanceSetting // TypeDefIndex: 79649
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
	
		public struct World3DUiGlobalSetting // TypeDefIndex: 79650
		{
			// Fields
			public bool bOverride; // 0x00
			public World3DUiSetting setting; // 0x01
			public World3DUiSetting overrideSetting; // 0x02
	
			// Properties
			public bool buildingNameShadowDisable { get; set; } // 0x00000001857A33D0-0x00000001857A33E0 0x000000018723AF10-0x000000018723AF20
	
			// Methods
			public void Disable(); // 0x000000018723AEF0-0x000000018723AF00
			public void ResetOverride(); // 0x000000018723AF00-0x000000018723AF10
		}
	
		[Serializable]
		public struct World3DUiSetting // TypeDefIndex: 79651
		{
			// Fields
			public bool buildingNameShadowDisable; // 0x00
		}
	
		[Serializable]
		public struct CurveGlobalSetting // TypeDefIndex: 79652
		{
			// Fields
			public unsafe void* buildCurve; // 0x00
			public unsafe void* buildAlphaCurve0; // 0x08
			public unsafe void* buildAlphaCurve1; // 0x10
			public unsafe void* repairCurve0; // 0x18
			public unsafe void* repairCurve1; // 0x20
	
			// Methods
			public void SetBuildCurve(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1); // 0x0000000187238E20-0x0000000187238E30
			public void SetRepairCurve0(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve); // 0x000000018561CBD0-0x000000018561CBE0
			public void SetRepairCurve1(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve); // 0x000000018561BB30-0x000000018561BB40
		}
	
		[NoAlias]
		public struct MapGridRendererData // TypeDefIndex: 79657
		{
			// Fields
			public const int MAX_COUNT = 3200; // Metadata: 0x0263BA47
			public short gridCountRegion; // 0x00
			public short gridCountField; // 0x02
			public short gridCount; // 0x04
			public unsafe fixed /* 0x00000000-0x00000000 */ byte infos[0]; // 0x06
	
			// Properties
			public MapGridInfo this[int idx] { get => default; } // 0x000000018723AA80-0x000000018723AAB0 
	
			// Nested types
			public struct MapGridInfo // TypeDefIndex: 79655
			{
				// Fields
				public LocalTransform trans; // 0x00
				public int3 gridVoxelIndex; // 0x20
				public bool selected; // 0x2C
				public SelectType selectedRenderType; // 0x30
				public bool hover; // 0x34
				public GridVoxelType gridVoxelType; // 0x38
				public bool invalid; // 0x3C
	
				// Nested types
				public enum SelectType // TypeDefIndex: 79653
				{
					NORMAL = 0,
					BLUEPRINT = 1
				}
	
				public enum GridVoxelType // TypeDefIndex: 79654
				{
					NORMAL = 0,
					WATER = 1,
					RIFT = 2
				}
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _infos_e__FixedBuffer // TypeDefIndex: 79656
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			// Methods
			public void UpdateGrid([NoAlias] ref MapGridInfo[] gridInfosRegion, int regionCount, [NoAlias] ref MapGridInfo[] gridInfosField, int fieldCount); // 0x00000001827D0300-0x00000001827D0460
			public void Reset(); // 0x000000018723AA70-0x000000018723AA80
			public unsafe MapGridInfo* GetGridInfoPtr(int idx); // 0x000000018723AA60-0x000000018723AA70
		}
	
		[Serializable]
		public struct UnitPortConfigDB // TypeDefIndex: 79658
		{
			// Fields
			public NativeParallelHashMap<int, UnitPortConfig> configMap; // 0x00
	
			// Methods
			public void Initialize(int capacity = 128 /* Metadata: 0x0263BA4E */); // 0x0000000185D61450-0x0000000185D614F0
			public void Dispose(); // 0x0000000188CE9158-0x0000000188CE91B4
			public bool EnsureValue(string unitName, out UnitPortConfig value); // 0x00000001850B0770-0x00000001850B08E0
			public bool EnsureValue(int unitNameFastId, out UnitPortConfig value); // 0x0000000185661F40-0x0000000185661F90
			public bool TryGetValue(string unitName, out UnitPortConfig value); // 0x00000001850B08E0-0x00000001850B0940
			public bool TryGetValue(int unitNameFastId, out UnitPortConfig value); // 0x00000001878370F8-0x0000000187837104
			public void Add(string unitName, [IsReadOnly] in UnitPortConfig value); // 0x000000018698D760-0x000000018698D7E0
			public void Add(int unitNameFastId, [IsReadOnly] in UnitPortConfig value); // 0x000000018698D7E0-0x000000018698D9F0
			public bool ContainsKey(string unitName); // 0x0000000188CE90EC-0x0000000188CE9158
			public void Clear(); // 0x0000000188CE9090-0x0000000188CE90EC
			private UnitPortConfig _CreateWithTable(int unitNameFastId); // 0x0000000188CE91B4-0x0000000188CE9284
			private UnitPortConfig _CreateWithTable(string unitName); // 0x00000001850AB760-0x00000001850ABF40
			private static void _ParseGlobalPortIdx(string templateName, ref FactoryUnitPortConfig port, int inPortCount); // 0x00000001850B4CD0-0x00000001850B4DE0
			[CompilerGenerated]
			internal static void __CreateWithTable_g__FillBuildingPorts_12_0(string templateName, FactoryBuildingData data, ref UnitPortConfig target); // 0x00000001850B4E10-0x00000001850B6470
			[CompilerGenerated]
			internal static void __CreateWithTable_g__ParsePort_12_1(ref UnitPortConfig target, string templateName, Vector3IntData range, BeanArray<TransformInt> inputPorts, BeanArray<TransformInt> outputPorts, bool isPipePort); // 0x00000001850AB070-0x00000001850AB760
		}
	
		public struct UnitPortConfig // TypeDefIndex: 79659
		{
			// Fields
			public ushort inputPortCount; // 0x00
			public ushort outputPortCount; // 0x02
			public FixedList512Bytes<FactoryUnitPortConfig> portIn; // 0x04
			public FixedList512Bytes<FactoryUnitPortConfig> portOut; // 0x204
		}
	
		[Serializable]
		public struct PerDrawGlobalSetting // TypeDefIndex: 79666
		{
			// Fields
			public const int COLOR_DATA_CAPACITY = 60895; // Metadata: 0x0263BA50
			public const int PASS_DATA_CAPACITY = 60800; // Metadata: 0x0263BA54
			public unsafe fixed /* 0x00000000-0x00000000 */ byte colorData[0]; // 0x00
			public unsafe fixed /* 0x00000000-0x00000000 */ byte passData[0]; // 0xEDDF
	
			// Nested types
			public struct PerDrawPassGlobalSetting // TypeDefIndex: 79661
			{
				// Fields
				public int count; // 0x00
				public unsafe fixed /* 0x00000000-0x00000000 */ byte config[0]; // 0x04
	
				// Properties
				public PerDrawPassConfig this[int idx] { get => default; set {} } // 0x000000018723AC00-0x000000018723AC30 0x000000018723AC30-0x000000018723AC60
	
				// Nested types
				[CompilerGenerated]
				[UnsafeValueType]
				public struct _config_e__FixedBuffer // TypeDefIndex: 79660
				{
					// Fields
					public byte FixedElementField; // 0x00
				}
	
				// Methods
				public PerDrawPassConfig GetPerDrawPassConfig(int idx); // 0x000000018723AC00-0x000000018723AC30
			}
	
			public struct PerDrawColorGlobalSetting // TypeDefIndex: 79663
			{
				// Fields
				public int count; // 0x00
				public unsafe fixed /* 0x00000000-0x00000000 */ byte configs[0]; // 0x04
	
				// Properties
				public PerDrawConfig this[int idx] { get => default; set {} } // 0x000000018723AB70-0x000000018723ABB0 0x000000018723ABB0-0x000000018723ABF0
	
				// Nested types
				[CompilerGenerated]
				[UnsafeValueType]
				public struct _configs_e__FixedBuffer // TypeDefIndex: 79662
				{
					// Fields
					public byte FixedElementField; // 0x00
				}
	
				// Methods
				public PerDrawConfig GetPerDrawConfig(int idx); // 0x000000018723AB70-0x000000018723ABB0
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _colorData_e__FixedBuffer // TypeDefIndex: 79664
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _passData_e__FixedBuffer // TypeDefIndex: 79665
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			// Methods
			public unsafe void Apply(HGFactoryRendererBinderComponent* binder, LogicEntityState entityState, LogicEntityType entityType); // 0x0000000188CE8498-0x0000000188CE8504
			public void Apply(ref HGFactoryRendererBinderComponent binder, LogicEntityState entityState, LogicEntityType entityType); // 0x0000000188CE8504-0x0000000188CE853C
			public static unsafe void Apply(ref HGFactoryRendererBinderComponent binder, PerDrawConfig* perDrawConfigs, int length); // 0x0000000188CE8418-0x0000000188CE8498
			public unsafe void ApplyPass(HGFactoryRendererBinderComponent* binder, LogicEntityState entityState, LogicEntityType entityType, uint currentLightMode); // 0x0000000188CE8328-0x0000000188CE8394
			public void ApplyPass(ref HGFactoryRendererBinderComponent binder, LogicEntityState entityState, LogicEntityType entityType, uint currentLightMode); // 0x0000000188CE82DC-0x0000000188CE8328
			public static unsafe void ApplyPass(ref HGFactoryRendererBinderComponent binder, PerDrawPassConfig* perDrawConfigs, int length, uint currentLightMode); // 0x0000000188CE8394-0x0000000188CE8418
			public void Parse(SerializeFieldDictionary<LogicEntityState, SerializeFieldDictionary<LogicEntityType, PerDrawConfigArray>> setting); // 0x0000000185D60F50-0x0000000185D61370
			private int _GetKey(LogicEntityState entityState, LogicEntityType entityType); // 0x000000018723ABF0-0x000000018723AC00
		}
	
		public struct SystemIntervalGlobalSetting // TypeDefIndex: 79667
		{
			// Fields
			public bool bOverride; // 0x00
			public SystemIntervalSetting setting; // 0x04
			public SystemIntervalSetting overrideSetting; // 0x2C
	
			// Properties
			public int crossCollectFrameInterval { get; set; } // 0x0000000185D62DF0-0x0000000185D62E00 0x000000018723AD30-0x000000018723AD40
			public int cullingSystemInterval { get; set; } // 0x0000000185D62C80-0x0000000185D62C90 0x000000018723AD40-0x000000018723AD50
			public int unitPreviewSystemInterval { get; set; } // 0x0000000185D62C30-0x0000000185D62C40 0x000000018723AD90-0x000000018723ADA0
			public int portPreviewRenderSystemInterval { get; set; } // 0x0000000185D62C50-0x0000000185D62C60 0x000000018723AD80-0x000000018723AD90
			public int buildingStateSystemInterval { get; set; } // 0x0000000185D62C90-0x0000000185D62CA0 0x000000018723AD20-0x000000018723AD30
			public int portBlockSystemInterval { get; set; } // 0x0000000185D62C40-0x0000000185D62C50 0x000000018723AD70-0x000000018723AD80
			public int outputUISystemInterval { get; set; } // 0x0000000185D62C60-0x0000000185D62C70 0x000000018723AD60-0x000000018723AD70
			public int envGeneratorUISystemInterval { get; } // 0x000000018783A574-0x000000018783A584 
			public int buildingNameSystemInterval { get; set; } // 0x0000000188CE8A50-0x0000000188CE8A60 0x000000018723AD10-0x000000018723AD20
			public int adjustGroundSystemInterval { get; set; } // 0x0000000185D62CA0-0x0000000185D62CB0 0x000000018723AD00-0x000000018723AD10
			public int gridSystemInterval { get; set; } // 0x0000000185D62C70-0x0000000185D62C80 0x000000018723AD50-0x000000018723AD60
	
			// Methods
			public void Disable(); // 0x000000018723ACC0-0x000000018723ACE0
			public void ResetOverride(); // 0x000000018723ACE0-0x000000018723AD00
		}
	
		[Serializable]
		public struct SystemIntervalSetting // TypeDefIndex: 79668
		{
			// Fields
			private const int MIN_INTERVAL = 0; // Metadata: 0x0263BA58
			private const int MAX_INTERVAL = 60; // Metadata: 0x0263BA59
			[Range(0f, 60f)]
			public int crossCollectFrameInterval; // 0x00
			[Range(0f, 60f)]
			public int cullingSystemInterval; // 0x04
			[Range(0f, 60f)]
			public int unitPreviewSystemInterval; // 0x08
			[Range(0f, 60f)]
			public int portPreviewRenderSystemInterval; // 0x0C
			[Range(0f, 60f)]
			public int buildingStateSystemInterval; // 0x10
			[Range(0f, 60f)]
			public int portBlockSystemInterval; // 0x14
			[Range(0f, 60f)]
			public int outputUISystemInterval; // 0x18
			[Range(0f, 60f)]
			public int buildingNameSystemInterval; // 0x1C
			[Range(0f, 60f)]
			public int adjustGroundSystemInterval; // 0x20
			[Range(0f, 60f)]
			public int gridSystemInterval; // 0x24
		}
	
		[Serializable]
		public struct UIEffectPathConfig // TypeDefIndex: 79669
		{
			// Fields
			public static int s_max; // 0x00
			public NativeParallelHashMap<int, FixedString32Bytes> atlasNames; // 0x00
			public NativeParallelHashMap<int, float4> atlasColors; // 0x10
			public NativeParallelHashMap<int, float4> atlasUVs; // 0x20
	
			// Constructors
			static UIEffectPathConfig(); // 0x000000018721F7B0-0x000000018721F7F0
	
			// Methods
			public void Parse(SerializeFieldDictionary<FacBuildingState, string> config, SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryStateIconColorConfig, FactoryUIAtlasSOData uvConfig); // 0x0000000185D62E70-0x0000000185D63FE0
			public bool Get(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // 0x0000000188CE8A60-0x0000000188CE8BA0
		}
	
		// Constructors
		static GlobalSharedData(); // 0x0000000186E447E0-0x0000000186E44A20
	
		// Methods
		public void Reset(); // 0x0000000188CE7FF0-0x0000000188CE8054
	}

	public struct ProcessorJob // TypeDefIndex: 79671
	{
		// Fields
		private JobHandle m_jobHandle; // 0x00
	
		// Constructors
		private ProcessorJob(JobHandle outputHandle, JobHandle upstreamMainChainHandle); // 0x000000018723AC90-0x000000018723ACA0
	
		// Methods
		public static ProcessorJob Track(JobHandle outputHandle, JobHandle upstreamMainChainHandle); // 0x000000018723AC80-0x000000018723AC90
		public void Complete(); // 0x0000000185677EB0-0x0000000185677EE0
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public abstract class BaseProcessor : IProcessor // TypeDefIndex: 79672
	{
		// Fields
		protected FactorySetting m_factorySetting; // 0x10
		[CompilerGenerated]
		private float _interval_k__BackingField; // 0x18
		[CompilerGenerated]
		private float _curInterval_k__BackingField; // 0x1C
	
		// Properties
		public virtual float interval { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187233050-0x0000000187233060 0x0000000187233060-0x0000000187233070
		public virtual float curInterval { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public abstract string name { get; }
		public virtual bool lowFrameEnable { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		protected BaseProcessor(); // 0x000000018723A910-0x000000018723A920
	
		// Methods
		public virtual void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting); // 0x000000018783C4EC-0x000000018783C4FC
		public virtual JobHandle PreExecute(ref EntityManager em, long time, long deltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies); // 0x000000018723A900-0x000000018723A910
		public virtual JobHandle Execute(ref EntityManager em, long time, long deltaTime, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies); // 0x000000018723A8E0-0x000000018723A8F0
		public virtual JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle); // 0x000000018723A8F0-0x000000018723A900
		public virtual void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void TearDown(ref EntityManager em, ref GlobalEnv env); // 0x0000000186805BA0-0x0000000186805BB0
		protected void StructuralSync(ref JobHandle jh, ref NativeList<JobHandle> noneDependencies); // 0x0000000185C9D180-0x0000000185C9D290
		protected void ScheduleNoneDependencies(ref NativeList<JobHandle> noneDependencies); // 0x0000000185C9D290-0x0000000185C9D360
		protected void CompleteMainChainJob(JobHandle jobHandle); // 0x0000000187839F48-0x0000000187839F5C
		public bool InLowFrameMode(ref GlobalEnv env); // 0x0000000185620BC0-0x0000000185620BF0
		protected bool SpecialEntityExisted(ref EntityManager em); // 0x000000018561C700-0x000000018561C910
	}

	public interface IProcessor // TypeDefIndex: 79673
	{
		// Properties
		float interval { get; }
		float curInterval { get; set; }
		string name { get; }
		bool lowFrameEnable { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Methods
		void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting);
		JobHandle PreExecute(ref EntityManager em, long time, long dt, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies);
		JobHandle Execute(ref EntityManager em, long time, long dt, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies);
		JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle);
		void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null);
		void TearDown(ref EntityManager em, ref GlobalEnv env);
		bool InLowFrameMode(ref GlobalEnv env);
	}

	public class StructuralChangedAttribute : Attribute // TypeDefIndex: 79674
	{
		// Constructors
		public StructuralChangedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[BurstCompile]
	public class UnsafeJobFuncPointers // TypeDefIndex: 79690
	{
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void ApplyRender(HGFactoryRendererBinderComponent* binder, PerDrawConfig* perDrawConfigs, int length); // TypeDefIndex: 79675; 0x00000001811DF7F0-0x00000001811DF810
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate bool FacRegionPosValid(EntityManager* entityManager, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // TypeDefIndex: 79676; 0x00000001827CD430-0x00000001827CD450
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool QueryStateIconPath(FacBuildingState stateUI, out FixedString32Bytes path, out float4 uv, out float4 color); // TypeDefIndex: 79677; 0x00000001811CDB70-0x00000001811CDB90
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate FacBuildingState QueryBuildingState(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // TypeDefIndex: 79678; 0x00000001811DF7F0-0x00000001811DF810
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetEntityFlashStatue(ref EntityManager em, ref Entity entity, FacBuildingState statue); // TypeDefIndex: 79679; 0x00000001811DF7F0-0x00000001811DF810
	
		public unsafe delegate void ApplyPerDrawRender_00000936_PostfixBurstDelegate(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length); // TypeDefIndex: 79680; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class ApplyPerDrawRender_00000936_BurstDirectCall // TypeDefIndex: 79681
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static ApplyPerDrawRender_00000936_BurstDirectCall(); // 0x00000001827CA3D0-0x00000001827CA3E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab03c); // 0x00000001827C8BC0-0x00000001827C9820
			private static IntPtr GetFunctionPointer(); // 0x00000001827C9820-0x00000001827C9B20
			public static void Constructor(); // 0x00000001827C8340-0x00000001827C8BC0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length); // 0x00000001827C9B20-0x00000001827CA3D0
		}
	
		public delegate bool GetQueryStateIconPath_00000938_PostfixBurstDelegate(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // TypeDefIndex: 79682; 0x00000001811CDB70-0x00000001811CDB90
	
		internal static class GetQueryStateIconPath_00000938_BurstDirectCall // TypeDefIndex: 79683
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static GetQueryStateIconPath_00000938_BurstDirectCall(); // 0x00000001827CF380-0x00000001827CF390
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab04d); // 0x00000001827CDE00-0x00000001827CEA60
			private static IntPtr GetFunctionPointer(); // 0x00000001827CEA60-0x00000001827CED60
			public static void Constructor(); // 0x00000001827CD580-0x00000001827CDE00
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static bool Invoke(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // 0x00000001827CED60-0x00000001827CF380
		}
	
		public unsafe delegate bool GetLogicEntityWithPos_0000093A_PostfixBurstDelegate([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // TypeDefIndex: 79684; 0x00000001827CD430-0x00000001827CD450
	
		internal static class GetLogicEntityWithPos_0000093A_BurstDirectCall // TypeDefIndex: 79685
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static GetLogicEntityWithPos_0000093A_BurstDirectCall(); // 0x00000001827CCB00-0x00000001827CCB10
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab063); // 0x00000001827CB540-0x00000001827CC1A0
			private static IntPtr GetFunctionPointer(); // 0x00000001827CC1A0-0x00000001827CC4A0
			public static void Constructor(); // 0x00000001827CACC0-0x00000001827CB540
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe bool Invoke([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // 0x00000001827CC4A0-0x00000001827CCB00
		}
	
		public delegate FacBuildingState QueryBuildingStateFunc_0000093C_PostfixBurstDelegate(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // TypeDefIndex: 79686; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class QueryBuildingStateFunc_0000093C_BurstDirectCall // TypeDefIndex: 79687
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static QueryBuildingStateFunc_0000093C_BurstDirectCall(); // 0x00000001827D2850-0x00000001827D2860
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab075); // 0x00000001827D1020-0x00000001827D1C80
			private static IntPtr GetFunctionPointer(); // 0x00000001827D1C80-0x00000001827D1F80
			public static void Constructor(); // 0x00000001827D07A0-0x00000001827D1020
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static FacBuildingState Invoke(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // 0x00000001827D1F80-0x00000001827D2850
		}
	
		public delegate void SetEntityFlashStatueFunc_0000093E_PostfixBurstDelegate(ref EntityManager em, ref Entity entity, FacBuildingState statue); // TypeDefIndex: 79688; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class SetEntityFlashStatueFunc_0000093E_BurstDirectCall // TypeDefIndex: 79689
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SetEntityFlashStatueFunc_0000093E_BurstDirectCall(); // 0x00000001827D58B0-0x00000001827D58C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab084); // 0x00000001827D4080-0x00000001827D4CE0
			private static IntPtr GetFunctionPointer(); // 0x00000001827D4CE0-0x00000001827D4FE0
			public static void Constructor(); // 0x00000001827D3800-0x00000001827D4080
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager em, ref Entity entity, FacBuildingState statue); // 0x00000001827D4FE0-0x00000001827D58B0
		}
	
		// Constructors
		public UnsafeJobFuncPointers(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static FunctionPointer<ApplyRender> GetApplyRenderPointer(); // 0x00000001865EE430-0x00000001865EE4D0
		public static FunctionPointer<FacRegionPosValid> GetFacRegionValid(); // 0x0000000185D62D50-0x0000000185D62DF0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(ApplyRender))]
		public static unsafe void ApplyPerDrawRender(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length); // 0x0000000188CE982C-0x0000000188CE988C
		public static FunctionPointer<QueryStateIconPath> GetQueryStateIconPathFuncPtr(); // 0x0000000185D62CB0-0x0000000185D62D50
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryStateIconPath))]
		public static bool GetQueryStateIconPath(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // 0x0000000188CE9E34-0x0000000188CE9EA8
		public static bool GetLogicEntityWithPosAdapter(ref EntityManager em, float x, float y, float z, out UnitFragment unitFragment); // 0x0000000188CE988C-0x0000000188CE99F0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(FacRegionPosValid))]
		public static unsafe bool GetLogicEntityWithPos([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // 0x0000000188CE9CE8-0x0000000188CE9D68
		public static FunctionPointer<QueryBuildingState> GetQueryBuildingStatePointer(); // 0x00000001865EB580-0x00000001865EB620
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryBuildingState))]
		public static FacBuildingState QueryBuildingStateFunc(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // 0x0000000188CE9EBC-0x0000000188CE9F1C
		public static FunctionPointer<SetEntityFlashStatue> GetSetEntityFlashStatuePointer(); // 0x00000001865EB4E0-0x00000001865EB580
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(SetEntityFlashStatue))]
		public static void SetEntityFlashStatueFunc(ref EntityManager em, ref Entity entity, FacBuildingState statue); // 0x0000000188CE9F30-0x0000000188CE9F90
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(ApplyRender))]
		public static unsafe void ApplyPerDrawRender_BurstManaged(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length); // 0x0000000188CE97D8-0x0000000188CE982C
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryStateIconPath))]
		public static bool GetQueryStateIconPath_BurstManaged(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // 0x0000000188CE9D68-0x0000000188CE9E34
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(FacRegionPosValid))]
		public static unsafe bool GetLogicEntityWithPos_BurstManaged([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // 0x0000000188CE99F0-0x0000000188CE9CE8
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryBuildingState))]
		public static FacBuildingState QueryBuildingStateFunc_BurstManaged(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // 0x0000000188CE9EA8-0x0000000188CE9EBC
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(SetEntityFlashStatue))]
		public static void SetEntityFlashStatueFunc_BurstManaged(ref EntityManager em, ref Entity entity, FacBuildingState statue); // 0x0000000188CE9F1C-0x0000000188CE9F30
	}

	[BurstCompile(FloatPrecision = FloatPrecision.High, FloatMode = FloatMode.Fast)]
	public struct AdditiveEffectJob : IJobParallelForDefer // TypeDefIndex: 79699
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x00
		public long time; // 0x08
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildCurve; // 0x10
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve0; // 0x28
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve1; // 0x40
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve0; // 0x58
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve1; // 0x70
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve snowCoverageCurve; // 0x88
		[ReadOnly]
		public EntityManager em; // 0xA0
		[NativeSetThreadIndex]
		public int threadId; // 0xB0
		public int frameCount; // 0xB4
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedExtDataPtr; // 0xB8
		public NativeQueue<FactoryBuildingEffectData> finishedEffectQueue; // 0xC0
	
		// Nested types
		public delegate bool _BuildDismissState_0000095C_PostfixBurstDelegate(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 79691; 0x00000001811C5A40-0x00000001811C5A60
	
		internal static class _BuildDismissState_0000095C_BurstDirectCall // TypeDefIndex: 79692
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BuildDismissState_0000095C_BurstDirectCall(); // 0x00000001827EA110-0x00000001827EA120
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab0d5); // 0x00000001827E8B90-0x00000001827E97F0
			private static IntPtr GetFunctionPointer(); // 0x00000001827E97F0-0x00000001827E9AF0
			public static void Constructor(); // 0x00000001827E8310-0x00000001827E8B90
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static bool Invoke(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001827E9AF0-0x00000001827EA110
		}
	
		public delegate bool _Repair0_0000095E_PostfixBurstDelegate(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 79693; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _Repair0_0000095E_BurstDirectCall // TypeDefIndex: 79694
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair0_0000095E_BurstDirectCall(); // 0x000000018280D730-0x000000018280D740
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab0e8); // 0x000000018280C1D0-0x000000018280CE30
			private static IntPtr GetFunctionPointer(); // 0x000000018280CE30-0x000000018280D130
			public static void Constructor(); // 0x000000018280B950-0x000000018280C1D0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static bool Invoke(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x000000018280D130-0x000000018280D730
		}
	
		public delegate bool _Repair1_0000095F_PostfixBurstDelegate(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 79695; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _Repair1_0000095F_BurstDirectCall // TypeDefIndex: 79696
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1_0000095F_BurstDirectCall(); // 0x00000001828104A0-0x00000001828104B0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab0f7); // 0x000000018280EF40-0x000000018280FBA0
			private static IntPtr GetFunctionPointer(); // 0x000000018280FBA0-0x000000018280FEA0
			public static void Constructor(); // 0x000000018280E6C0-0x000000018280EF40
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static bool Invoke(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x000000018280FEA0-0x00000001828104A0
		}
	
		public delegate bool _SnowCoverageState_00000960_PostfixBurstDelegate(ref SnowCoverageState snowState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 79697; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _SnowCoverageState_00000960_BurstDirectCall // TypeDefIndex: 79698
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SnowCoverageState_00000960_BurstDirectCall(); // 0x00000001828130F0-0x0000000182813100
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab106); // 0x0000000182811B80-0x00000001828127E0
			private static IntPtr GetFunctionPointer(); // 0x00000001828127E0-0x0000000182812AE0
			public static void Constructor(); // 0x0000000182811300-0x0000000182811B80
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static bool Invoke(ref SnowCoverageState snowState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000182812AE0-0x00000001828130F0
		}
	
		// Methods
		public void SetSharedExtData(IntPtr data); // 0x000000018561EF00-0x000000018561EF10
		public void Execute(int startIndex, int count); // 0x0000000188CE1A7C-0x0000000188CE1ABC
		public void Execute(int index); // 0x0000000188CE1798-0x0000000188CE1A7C
		private void _OnStackEmpty(ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData); // 0x0000000188CE1C04-0x0000000188CE1C44
		private void _CancelPreState(AdditiveEffectFragment.AdditiveEffectType preState, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData); // 0x0000000188CDFFE0-0x0000000188CDFFF4
		private void _ResumeState(AdditiveEffectFragment.AdditiveEffectType state, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData); // 0x0000000188CE005C-0x0000000188CE028C
		private void _SetStateValid(AdditiveEffectFragment.AdditiveEffectType state, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData, bool valid); // 0x0000000188CE1D04-0x0000000188CE1F74
		private void _UpdateInternalStateLifeCycle(ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData); // 0x0000000188CE1FD4-0x0000000188CE214C
		[BurstCompile]
		private static bool _BuildDismissState(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CE1B88-0x0000000188CE1C04
		private static void _InitBuildState(ref CutoffState cutoffState, ref BuildDismissState buildDismissState); // 0x000000018723A8D0-0x000000018723A8E0
		[BurstCompile]
		private static bool _Repair0(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000188CE1C44-0x0000000188CE1CA4
		[BurstCompile]
		private static bool _Repair1(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000188CE1CA4-0x0000000188CE1D04
		[BurstCompile]
		private static bool _SnowCoverageState(ref SnowCoverageState snowState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000188CE1F74-0x0000000188CE1FD4
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B5B0-0x000000018561B5C0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BA5A */); // 0x000000018561ED80-0x000000018561EEE0
		public JobHandle ScheduleDefer(JobHandle jobHandleDep0, JobHandle jobHandleDep1, int innerLoopBatchCount = 1 /* Metadata: 0x0263BA5B */); // 0x0000000188CE1ABC-0x0000000188CE1B88
		[BurstCompile]
		public static bool _BuildDismissState_BurstManaged(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CDFED8-0x0000000188CDFFE0
		[BurstCompile]
		public static bool _Repair0_BurstManaged(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000188CDFFF4-0x0000000188CE0028
		[BurstCompile]
		public static bool _Repair1_BurstManaged(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000188CE0028-0x0000000188CE005C
		[BurstCompile]
		public static bool _SnowCoverageState_BurstManaged(ref SnowCoverageState snowState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000188CE028C-0x0000000188CE036C
	}

	[BurstCompile]
	public struct AdditiveEffectQueryJob : IJob // TypeDefIndex: 79700
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_additiveEffectQr; // 0x18
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_hintEffectQr; // 0x20
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_additiveEffectRendererQr; // 0x28
	
		// Methods
		public void Execute(); // 0x0000000188CE214C-0x0000000188CE22A0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer additiveEffectQr, ref EntityQueryV2.QueryResultDefer hintQr, ref EntityQueryV2.QueryResultDefer additiveEffectRendererQr, bool resetQr = true /* Metadata: 0x0263BA5C */); // 0x000000018561CA30-0x000000018561CAC0
	}

	[BurstCompile]
	public struct AdditiveEffectRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 79801
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x00
		public long time; // 0x08
		public EntityManager rEntityManager; // 0x10
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildCurve; // 0x20
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve0; // 0x38
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve buildAlphaCurve1; // 0x50
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve0; // 0x68
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve repairCurve1; // 0x80
		[ReadOnly]
		public Beyond.Gameplay.Factory.FPtrNativeCurve snowCoverageCurve; // 0x98
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedExtDataPtr; // 0xB0
	
		// Nested types
		public delegate void _BPBuildStart_00000969_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 79701; 0x00000001811C5A40-0x00000001811C5A60
	
		internal static class _BPBuildStart_00000969_BurstDirectCall // TypeDefIndex: 79702
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildStart_00000969_BurstDirectCall(); // 0x00000001827E6F90-0x00000001827E6FA0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab2b1); // 0x00000001827E5A10-0x00000001827E6670
			private static IntPtr GetFunctionPointer(); // 0x00000001827E6670-0x00000001827E6970
			public static void Constructor(); // 0x00000001827E5190-0x00000001827E5A10
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001827E6970-0x00000001827E6F90
		}
	
		public delegate void _BPBuildProcess_0000096A_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 79703; 0x00000001811C5A40-0x00000001811C5A60
	
		internal static class _BPBuildProcess_0000096A_BurstDirectCall // TypeDefIndex: 79704
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildProcess_0000096A_BurstDirectCall(); // 0x00000001827E3E10-0x00000001827E3E20
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab2cc); // 0x00000001827E2890-0x00000001827E34F0
			private static IntPtr GetFunctionPointer(); // 0x00000001827E34F0-0x00000001827E37F0
			public static void Constructor(); // 0x00000001827E2010-0x00000001827E2890
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001827E37F0-0x00000001827E3E10
		}
	
		public delegate void _BPBuildEnd_0000096B_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 79705; 0x00000001811C5A40-0x00000001811C5A60
	
		internal static class _BPBuildEnd_0000096B_BurstDirectCall // TypeDefIndex: 79706
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildEnd_0000096B_BurstDirectCall(); // 0x00000001827E0B60-0x00000001827E0B70
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab2e7); // 0x00000001827DF5E0-0x00000001827E0240
			private static IntPtr GetFunctionPointer(); // 0x00000001827E0240-0x00000001827E0540
			public static void Constructor(); // 0x00000001827DED60-0x00000001827DF5E0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001827E0540-0x00000001827E0B60
		}
	
		public delegate void _BPBuildCutoffStateStart_0000096C_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 79707; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _BPBuildCutoffStateStart_0000096C_BurstDirectCall // TypeDefIndex: 79708
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateStart_0000096C_BurstDirectCall(); // 0x00000001827DDEE0-0x00000001827DDEF0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab2fa); // 0x00000001827DC980-0x00000001827DD5E0
			private static IntPtr GetFunctionPointer(); // 0x00000001827DD5E0-0x00000001827DD8E0
			public static void Constructor(); // 0x00000001827DC100-0x00000001827DC980
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001827DD8E0-0x00000001827DDEE0
		}
	
		public delegate void _BPBuildCutoffStateEnd_0000096D_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 79709; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _BPBuildCutoffStateEnd_0000096D_BurstDirectCall // TypeDefIndex: 79710
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateEnd_0000096D_BurstDirectCall(); // 0x00000001827D8620-0x00000001827D8630
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab309); // 0x00000001827D70C0-0x00000001827D7D20
			private static IntPtr GetFunctionPointer(); // 0x00000001827D7D20-0x00000001827D8020
			public static void Constructor(); // 0x00000001827D6840-0x00000001827D70C0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001827D8020-0x00000001827D8620
		}
	
		public delegate void _BPBuildCutoffStateProcess_0000096E_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 79711; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _BPBuildCutoffStateProcess_0000096E_BurstDirectCall // TypeDefIndex: 79712
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateProcess_0000096E_BurstDirectCall(); // 0x00000001827DB280-0x00000001827DB290
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab318); // 0x00000001827D9D20-0x00000001827DA980
			private static IntPtr GetFunctionPointer(); // 0x00000001827DA980-0x00000001827DAC80
			public static void Constructor(); // 0x00000001827D94A0-0x00000001827D9D20
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001827DAC80-0x00000001827DB280
		}
	
		public delegate void _CutoffStateStart_00000972_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 79713; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _CutoffStateStart_00000972_BurstDirectCall // TypeDefIndex: 79714
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateStart_00000972_BurstDirectCall(); // 0x00000001827F5DE0-0x00000001827F5DF0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab327); // 0x00000001827F4880-0x00000001827F54E0
			private static IntPtr GetFunctionPointer(); // 0x00000001827F54E0-0x00000001827F57E0
			public static void Constructor(); // 0x00000001827F4000-0x00000001827F4880
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001827F57E0-0x00000001827F5DE0
		}
	
		public delegate void _CutoffStateEnd_00000973_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 79715; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _CutoffStateEnd_00000973_BurstDirectCall // TypeDefIndex: 79716
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateEnd_00000973_BurstDirectCall(); // 0x00000001827F0520-0x00000001827F0530
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab336); // 0x00000001827EEFC0-0x00000001827EFC20
			private static IntPtr GetFunctionPointer(); // 0x00000001827EFC20-0x00000001827EFF20
			public static void Constructor(); // 0x00000001827EE740-0x00000001827EEFC0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001827EFF20-0x00000001827F0520
		}
	
		public delegate void _CutoffStateProcess_00000974_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 79717; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _CutoffStateProcess_00000974_BurstDirectCall // TypeDefIndex: 79718
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateProcess_00000974_BurstDirectCall(); // 0x00000001827F3180-0x00000001827F3190
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab345); // 0x00000001827F1C20-0x00000001827F2880
			private static IntPtr GetFunctionPointer(); // 0x00000001827F2880-0x00000001827F2B80
			public static void Constructor(); // 0x00000001827F13A0-0x00000001827F1C20
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001827F2B80-0x00000001827F3180
		}
	
		public delegate void _BuildStateProcess_00000977_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 79719; 0x00000001811C5A40-0x00000001811C5A60
	
		internal static class _BuildStateProcess_00000977_BurstDirectCall // TypeDefIndex: 79720
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BuildStateProcess_00000977_BurstDirectCall(); // 0x00000001827ED3C0-0x00000001827ED3D0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab35c); // 0x00000001827EBE40-0x00000001827ECAA0
			private static IntPtr GetFunctionPointer(); // 0x00000001827ECAA0-0x00000001827ECDA0
			public static void Constructor(); // 0x00000001827EB5C0-0x00000001827EBE40
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001827ECDA0-0x00000001827ED3C0
		}
	
		public delegate void _HighLightStart_00000978_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79721; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _HighLightStart_00000978_BurstDirectCall // TypeDefIndex: 79722
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightStart_00000978_BurstDirectCall(); // 0x0000000182806870-0x0000000182806880
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab36f); // 0x0000000182805310-0x0000000182805F70
			private static IntPtr GetFunctionPointer(); // 0x0000000182805F70-0x0000000182806270
			public static void Constructor(); // 0x0000000182804A90-0x0000000182805310
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182806270-0x0000000182806870
		}
	
		public delegate void _HighLightEnd_00000979_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79723; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _HighLightEnd_00000979_BurstDirectCall // TypeDefIndex: 79724
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightEnd_00000979_BurstDirectCall(); // 0x0000000182800FA0-0x0000000182800FB0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab37e); // 0x00000001827FFA30-0x0000000182800690
			private static IntPtr GetFunctionPointer(); // 0x0000000182800690-0x0000000182800990
			public static void Constructor(); // 0x00000001827FF1B0-0x00000001827FFA30
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182800990-0x0000000182800FA0
		}
	
		public delegate void _HighLightProcess_0000097A_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79725; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _HighLightProcess_0000097A_BurstDirectCall // TypeDefIndex: 79726
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightProcess_0000097A_BurstDirectCall(); // 0x0000000182803C10-0x0000000182803C20
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab38d); // 0x00000001828026A0-0x0000000182803300
			private static IntPtr GetFunctionPointer(); // 0x0000000182803300-0x0000000182803600
			public static void Constructor(); // 0x0000000182801E20-0x00000001828026A0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182803600-0x0000000182803C10
		}
	
		public delegate void _FigureStart_0000097B_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79727; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _FigureStart_0000097B_BurstDirectCall // TypeDefIndex: 79728
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureStart_0000097B_BurstDirectCall(); // 0x00000001827FE330-0x00000001827FE340
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab39c); // 0x00000001827FCDC0-0x00000001827FDA20
			private static IntPtr GetFunctionPointer(); // 0x00000001827FDA20-0x00000001827FDD20
			public static void Constructor(); // 0x00000001827FC540-0x00000001827FCDC0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001827FDD20-0x00000001827FE330
		}
	
		public delegate void _FigureProcess_0000097C_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79729; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _FigureProcess_0000097C_BurstDirectCall // TypeDefIndex: 79730
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureProcess_0000097C_BurstDirectCall(); // 0x00000001827FB6C0-0x00000001827FB6D0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab3ab); // 0x00000001827FA150-0x00000001827FADB0
			private static IntPtr GetFunctionPointer(); // 0x00000001827FADB0-0x00000001827FB0B0
			public static void Constructor(); // 0x00000001827F98D0-0x00000001827FA150
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001827FB0B0-0x00000001827FB6C0
		}
	
		public delegate void _FigureEnd_0000097D_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79731; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _FigureEnd_0000097D_BurstDirectCall // TypeDefIndex: 79732
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureEnd_0000097D_BurstDirectCall(); // 0x00000001827F8A50-0x00000001827F8A60
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab3ba); // 0x00000001827F74E0-0x00000001827F8140
			private static IntPtr GetFunctionPointer(); // 0x00000001827F8140-0x00000001827F8440
			public static void Constructor(); // 0x00000001827F6C60-0x00000001827F74E0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001827F8440-0x00000001827F8A50
		}
	
		public delegate void _HintStart_0000097E_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha); // TypeDefIndex: 79733; 0x00000001811CDB70-0x00000001811CDB90
	
		internal static class _HintStart_0000097E_BurstDirectCall // TypeDefIndex: 79734
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintStart_0000097E_BurstDirectCall(); // 0x000000018280A720-0x000000018280A730
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab3cb); // 0x0000000182809190-0x0000000182809DF0
			private static IntPtr GetFunctionPointer(); // 0x0000000182809DF0-0x000000018280A0F0
			public static void Constructor(); // 0x0000000182808910-0x0000000182809190
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha); // 0x000000018280A0F0-0x000000018280A720
		}
	
		public delegate void _HintEnd_0000097F_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, bool restoreOwnerVisibility); // TypeDefIndex: 79735; 0x0000000181217F60-0x0000000181217F80
	
		internal static class _HintEnd_0000097F_BurstDirectCall // TypeDefIndex: 79736
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintEnd_0000097F_BurstDirectCall(); // 0x0000000182839530-0x0000000182839540
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab3dd); // 0x0000000182837FB0-0x0000000182838C10
			private static IntPtr GetFunctionPointer(); // 0x0000000182838C10-0x0000000182838F10
			public static void Constructor(); // 0x0000000182837730-0x0000000182837FB0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, bool restoreOwnerVisibility); // 0x0000000182838F10-0x0000000182839530
		}
	
		public delegate void _HintProcess_00000980_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79737; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _HintProcess_00000980_BurstDirectCall // TypeDefIndex: 79738
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintProcess_00000980_BurstDirectCall(); // 0x000000018283B310-0x000000018283B320
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab3ed); // 0x0000000182839DC0-0x000000018283AA20
			private static IntPtr GetFunctionPointer(); // 0x000000018283AA20-0x000000018283AD20
			public static void Constructor(); // 0x0000000182839540-0x0000000182839DC0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x000000018283AD20-0x000000018283B310
		}
	
		public delegate void _BorderStart_00000981_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79739; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _BorderStart_00000981_BurstDirectCall // TypeDefIndex: 79740
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BorderStart_00000981_BurstDirectCall(); // 0x000000018282E3B0-0x000000018282E3C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab3fc); // 0x000000018282CE50-0x000000018282DAB0
			private static IntPtr GetFunctionPointer(); // 0x000000018282DAB0-0x000000018282DDB0
			public static void Constructor(); // 0x000000018282C5D0-0x000000018282CE50
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x000000018282DDB0-0x000000018282E3B0
		}
	
		public delegate void _BorderEnd_00000982_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79741; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _BorderEnd_00000982_BurstDirectCall // TypeDefIndex: 79742
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BorderEnd_00000982_BurstDirectCall(); // 0x0000000182828B00-0x0000000182828B10
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab40b); // 0x00000001828275A0-0x0000000182828200
			private static IntPtr GetFunctionPointer(); // 0x0000000182828200-0x0000000182828500
			public static void Constructor(); // 0x0000000182826D20-0x00000001828275A0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182828500-0x0000000182828B00
		}
	
		public delegate void _BorderProcess_00000983_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79743; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _BorderProcess_00000983_BurstDirectCall // TypeDefIndex: 79744
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BorderProcess_00000983_BurstDirectCall(); // 0x000000018282B750-0x000000018282B760
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab41a); // 0x000000018282A200-0x000000018282AE60
			private static IntPtr GetFunctionPointer(); // 0x000000018282AE60-0x000000018282B160
			public static void Constructor(); // 0x0000000182829980-0x000000018282A200
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x000000018282B160-0x000000018282B750
		}
	
		public delegate void _OverloadStart_00000984_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79745; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _OverloadStart_00000984_BurstDirectCall // TypeDefIndex: 79746
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadStart_00000984_BurstDirectCall(); // 0x00000001828542F0-0x0000000182854300
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab429); // 0x0000000182852D80-0x00000001828539E0
			private static IntPtr GetFunctionPointer(); // 0x00000001828539E0-0x0000000182853CE0
			public static void Constructor(); // 0x0000000182852500-0x0000000182852D80
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182853CE0-0x00000001828542F0
		}
	
		public delegate void _OverloadEnd_00000985_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79747; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _OverloadEnd_00000985_BurstDirectCall // TypeDefIndex: 79748
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadEnd_00000985_BurstDirectCall(); // 0x0000000182846500-0x0000000182846510
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab438); // 0x0000000182844F90-0x0000000182845BF0
			private static IntPtr GetFunctionPointer(); // 0x0000000182845BF0-0x0000000182845EF0
			public static void Constructor(); // 0x0000000182844710-0x0000000182844F90
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182845EF0-0x0000000182846500
		}
	
		public delegate void _OverloadProcess_00000986_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79749; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _OverloadProcess_00000986_BurstDirectCall // TypeDefIndex: 79750
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadProcess_00000986_BurstDirectCall(); // 0x0000000182851680-0x0000000182851690
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab447); // 0x0000000182850130-0x0000000182850D90
			private static IntPtr GetFunctionPointer(); // 0x0000000182850D90-0x0000000182851090
			public static void Constructor(); // 0x000000018284F8B0-0x0000000182850130
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182851090-0x0000000182851680
		}
	
		public delegate void _OverloadInvalidStart_00000987_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79751; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _OverloadInvalidStart_00000987_BurstDirectCall // TypeDefIndex: 79752
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidStart_00000987_BurstDirectCall(); // 0x000000018284EA30-0x000000018284EA40
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab456); // 0x000000018284D4C0-0x000000018284E120
			private static IntPtr GetFunctionPointer(); // 0x000000018284E120-0x000000018284E420
			public static void Constructor(); // 0x000000018284CC40-0x000000018284D4C0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x000000018284E420-0x000000018284EA30
		}
	
		public delegate void _OverloadInvalidEnd_00000988_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79753; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _OverloadInvalidEnd_00000988_BurstDirectCall // TypeDefIndex: 79754
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidEnd_00000988_BurstDirectCall(); // 0x0000000182849170-0x0000000182849180
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab465); // 0x0000000182847C00-0x0000000182848860
			private static IntPtr GetFunctionPointer(); // 0x0000000182848860-0x0000000182848B60
			public static void Constructor(); // 0x0000000182847380-0x0000000182847C00
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182848B60-0x0000000182849170
		}
	
		public delegate void _OverloadInvalidProcess_00000989_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79755; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _OverloadInvalidProcess_00000989_BurstDirectCall // TypeDefIndex: 79756
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidProcess_00000989_BurstDirectCall(); // 0x000000018284BDC0-0x000000018284BDD0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab474); // 0x000000018284A870-0x000000018284B4D0
			private static IntPtr GetFunctionPointer(); // 0x000000018284B4D0-0x000000018284B7D0
			public static void Constructor(); // 0x0000000182849FF0-0x000000018284A870
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x000000018284B7D0-0x000000018284BDC0
		}
	
		public delegate void _Repair0Process_0000098C_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 79757; 0x00000001812083C0-0x00000001812083E0
	
		internal static class _Repair0Process_0000098C_BurstDirectCall // TypeDefIndex: 79758
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair0Process_0000098C_BurstDirectCall(); // 0x0000000182864D50-0x0000000182864D60
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab487); // 0x00000001828637D0-0x0000000182864430
			private static IntPtr GetFunctionPointer(); // 0x0000000182864430-0x0000000182864730
			public static void Constructor(); // 0x0000000182862F50-0x00000001828637D0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000182864730-0x0000000182864D50
		}
	
		public delegate void _Repair1Start_0000098D_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79759; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _Repair1Start_0000098D_BurstDirectCall // TypeDefIndex: 79760
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1Start_0000098D_BurstDirectCall(); // 0x000000018286DD40-0x000000018286DD50
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab498); // 0x000000018286C7E0-0x000000018286D440
			private static IntPtr GetFunctionPointer(); // 0x000000018286D440-0x000000018286D740
			public static void Constructor(); // 0x000000018286BF60-0x000000018286C7E0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x000000018286D740-0x000000018286DD40
		}
	
		public delegate void _Repair1End_0000098E_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79761; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _Repair1End_0000098E_BurstDirectCall // TypeDefIndex: 79762
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1End_0000098E_BurstDirectCall(); // 0x0000000182867FA0-0x0000000182867FB0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab4a7); // 0x0000000182866A40-0x00000001828676A0
			private static IntPtr GetFunctionPointer(); // 0x00000001828676A0-0x00000001828679A0
			public static void Constructor(); // 0x00000001828661C0-0x0000000182866A40
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001828679A0-0x0000000182867FA0
		}
	
		public delegate void _Repair1Process_0000098F_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 79763; 0x00000001812083C0-0x00000001812083E0
	
		internal static class _Repair1Process_0000098F_BurstDirectCall // TypeDefIndex: 79764
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1Process_0000098F_BurstDirectCall(); // 0x000000018286AC20-0x000000018286AC30
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab4ba); // 0x00000001828696A0-0x000000018286A300
			private static IntPtr GetFunctionPointer(); // 0x000000018286A300-0x000000018286A600
			public static void Constructor(); // 0x0000000182868E20-0x00000001828696A0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x000000018286A600-0x000000018286AC20
		}
	
		public delegate void _BlueprintProcessInternal_00000991_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79765; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _BlueprintProcessInternal_00000991_BurstDirectCall // TypeDefIndex: 79766
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintProcessInternal_00000991_BurstDirectCall(); // 0x0000000182823230-0x0000000182823240
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab4cb); // 0x0000000182821CC0-0x0000000182822920
			private static IntPtr GetFunctionPointer(); // 0x0000000182822920-0x0000000182822C20
			public static void Constructor(); // 0x0000000182821440-0x0000000182821CC0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182822C20-0x0000000182823230
		}
	
		public delegate void _BlueprintEnd_00000992_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // TypeDefIndex: 79767; 0x00000001811CDB70-0x00000001811CDB90
	
		internal static class _BlueprintEnd_00000992_BurstDirectCall // TypeDefIndex: 79768
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintEnd_00000992_BurstDirectCall(); // 0x0000000182820210-0x0000000182820220
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab4dc); // 0x000000018281EC90-0x000000018281F8F0
			private static IntPtr GetFunctionPointer(); // 0x000000018281F8F0-0x000000018281FBF0
			public static void Constructor(); // 0x000000018281E410-0x000000018281EC90
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // 0x000000018281FBF0-0x0000000182820210
		}
	
		public delegate void _BlueprintStart_00000993_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79769; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _BlueprintStart_00000993_BurstDirectCall // TypeDefIndex: 79770
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintStart_00000993_BurstDirectCall(); // 0x0000000182825EA0-0x0000000182825EB0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab4ec); // 0x0000000182824930-0x0000000182825590
			private static IntPtr GetFunctionPointer(); // 0x0000000182825590-0x0000000182825890
			public static void Constructor(); // 0x00000001828240B0-0x0000000182824930
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182825890-0x0000000182825EA0
		}
	
		public delegate void _PreSelectStart_00000994_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79771; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _PreSelectStart_00000994_BurstDirectCall // TypeDefIndex: 79772
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectStart_00000994_BurstDirectCall(); // 0x00000001828620D0-0x00000001828620E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab4fb); // 0x0000000182860B70-0x00000001828617D0
			private static IntPtr GetFunctionPointer(); // 0x00000001828617D0-0x0000000182861AD0
			public static void Constructor(); // 0x00000001828602F0-0x0000000182860B70
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182861AD0-0x00000001828620D0
		}
	
		public delegate void _PreSelectEnd_00000995_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79773; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _PreSelectEnd_00000995_BurstDirectCall // TypeDefIndex: 79774
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectEnd_00000995_BurstDirectCall(); // 0x000000018285C820-0x000000018285C830
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab50a); // 0x000000018285B2C0-0x000000018285BF20
			private static IntPtr GetFunctionPointer(); // 0x000000018285BF20-0x000000018285C220
			public static void Constructor(); // 0x000000018285AA40-0x000000018285B2C0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x000000018285C220-0x000000018285C820
		}
	
		public delegate void _PreSelectProcess_00000996_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79775; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _PreSelectProcess_00000996_BurstDirectCall // TypeDefIndex: 79776
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectProcess_00000996_BurstDirectCall(); // 0x000000018285F470-0x000000018285F480
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab519); // 0x000000018285DF20-0x000000018285EB80
			private static IntPtr GetFunctionPointer(); // 0x000000018285EB80-0x000000018285EE80
			public static void Constructor(); // 0x000000018285D6A0-0x000000018285DF20
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x000000018285EE80-0x000000018285F470
		}
	
		public delegate void _ContinuationStart_00000997_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79777; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _ContinuationStart_00000997_BurstDirectCall // TypeDefIndex: 79778
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationStart_00000997_BurstDirectCall(); // 0x00000001828368B0-0x00000001828368C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab528); // 0x0000000182835350-0x0000000182835FB0
			private static IntPtr GetFunctionPointer(); // 0x0000000182835FB0-0x00000001828362B0
			public static void Constructor(); // 0x0000000182834AD0-0x0000000182835350
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001828362B0-0x00000001828368B0
		}
	
		public delegate void _ContinuationEnd_00000998_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79779; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _ContinuationEnd_00000998_BurstDirectCall // TypeDefIndex: 79780
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationEnd_00000998_BurstDirectCall(); // 0x0000000182831000-0x0000000182831010
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab537); // 0x000000018282FAB0-0x0000000182830710
			private static IntPtr GetFunctionPointer(); // 0x0000000182830710-0x0000000182830A10
			public static void Constructor(); // 0x000000018282F230-0x000000018282FAB0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182830A10-0x0000000182831000
		}
	
		public delegate void _ContinuationProcess_00000999_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79781; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _ContinuationProcess_00000999_BurstDirectCall // TypeDefIndex: 79782
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationProcess_00000999_BurstDirectCall(); // 0x0000000182833C50-0x0000000182833C60
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab546); // 0x0000000182832700-0x0000000182833360
			private static IntPtr GetFunctionPointer(); // 0x0000000182833360-0x0000000182833660
			public static void Constructor(); // 0x0000000182831E80-0x0000000182832700
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182833660-0x0000000182833C50
		}
	
		public delegate void _SocialSharingStart_0000099A_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79783; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _SocialSharingStart_0000099A_BurstDirectCall // TypeDefIndex: 79784
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SocialSharingStart_0000099A_BurstDirectCall(); // 0x000000018287B8A0-0x000000018287B8B0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab555); // 0x000000018287A340-0x000000018287AFA0
			private static IntPtr GetFunctionPointer(); // 0x000000018287AFA0-0x000000018287B2A0
			public static void Constructor(); // 0x0000000182879AC0-0x000000018287A340
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x000000018287B2A0-0x000000018287B8A0
		}
	
		public delegate void _PowerInteractionStart_0000099B_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79785; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _PowerInteractionStart_0000099B_BurstDirectCall // TypeDefIndex: 79786
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PowerInteractionStart_0000099B_BurstDirectCall(); // 0x0000000182859BC0-0x0000000182859BD0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab564); // 0x0000000182858650-0x00000001828592B0
			private static IntPtr GetFunctionPointer(); // 0x00000001828592B0-0x00000001828595B0
			public static void Constructor(); // 0x0000000182857DD0-0x0000000182858650
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001828595B0-0x0000000182859BC0
		}
	
		public delegate void _PowerInteractionEnd_0000099C_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79787; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _PowerInteractionEnd_0000099C_BurstDirectCall // TypeDefIndex: 79788
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PowerInteractionEnd_0000099C_BurstDirectCall(); // 0x0000000182856F50-0x0000000182856F60
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab573); // 0x00000001828559F0-0x0000000182856650
			private static IntPtr GetFunctionPointer(); // 0x0000000182856650-0x0000000182856950
			public static void Constructor(); // 0x0000000182855170-0x00000001828559F0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182856950-0x0000000182856F50
		}
	
		public delegate void _InvalidOverlapPlaceStart_0000099D_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79789; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _InvalidOverlapPlaceStart_0000099D_BurstDirectCall // TypeDefIndex: 79790
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _InvalidOverlapPlaceStart_0000099D_BurstDirectCall(); // 0x0000000182840BF0-0x0000000182840C00
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab582); // 0x000000018283F680-0x00000001828402E0
			private static IntPtr GetFunctionPointer(); // 0x00000001828402E0-0x00000001828405E0
			public static void Constructor(); // 0x000000018283EE00-0x000000018283F680
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001828405E0-0x0000000182840BF0
		}
	
		public delegate void _InvalidOverlapPlaceEnd_0000099E_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79791; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _InvalidOverlapPlaceEnd_0000099E_BurstDirectCall // TypeDefIndex: 79792
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _InvalidOverlapPlaceEnd_0000099E_BurstDirectCall(); // 0x000000018283DF80-0x000000018283DF90
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab591); // 0x000000018283CA10-0x000000018283D670
			private static IntPtr GetFunctionPointer(); // 0x000000018283D670-0x000000018283D970
			public static void Constructor(); // 0x000000018283C190-0x000000018283CA10
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x000000018283D970-0x000000018283DF80
		}
	
		public delegate void _SnowCoverageStart_0000099F_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79793; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _SnowCoverageStart_0000099F_BurstDirectCall // TypeDefIndex: 79794
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SnowCoverageStart_0000099F_BurstDirectCall(); // 0x0000000182878C40-0x0000000182878C50
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab5a0); // 0x00000001828776D0-0x0000000182878330
			private static IntPtr GetFunctionPointer(); // 0x0000000182878330-0x0000000182878630
			public static void Constructor(); // 0x0000000182876E50-0x00000001828776D0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182878630-0x0000000182878C40
		}
	
		public delegate void _SnowCoverageProcess_000009A0_PostfixBurstDelegate(ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79795; 0x00000001859B7730-0x00000001859B7740
	
		internal static class _SnowCoverageProcess_000009A0_BurstDirectCall // TypeDefIndex: 79796
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SnowCoverageProcess_000009A0_BurstDirectCall(); // 0x0000000182876290-0x00000001828762A0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab5ad); // 0x0000000182874D20-0x0000000182875980
			private static IntPtr GetFunctionPointer(); // 0x0000000182875980-0x0000000182875C80
			public static void Constructor(); // 0x00000001828744A0-0x0000000182874D20
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182875C80-0x0000000182876290
		}
	
		public delegate void _SnowCoverageMaintain_000009A1_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79797; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _SnowCoverageMaintain_000009A1_BurstDirectCall // TypeDefIndex: 79798
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SnowCoverageMaintain_000009A1_BurstDirectCall(); // 0x0000000182873620-0x0000000182873630
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab5bb); // 0x00000001828720B0-0x0000000182872D10
			private static IntPtr GetFunctionPointer(); // 0x0000000182872D10-0x0000000182873010
			public static void Constructor(); // 0x0000000182871830-0x00000001828720B0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000182873010-0x0000000182873620
		}
	
		public delegate void _SnowCoverageEnd_000009A2_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 79799; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _SnowCoverageEnd_000009A2_BurstDirectCall // TypeDefIndex: 79800
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SnowCoverageEnd_000009A2_BurstDirectCall(); // 0x00000001828709B0-0x00000001828709C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab5ca); // 0x000000018286F440-0x00000001828700A0
			private static IntPtr GetFunctionPointer(); // 0x00000001828700A0-0x00000001828703A0
			public static void Constructor(); // 0x000000018286EBC0-0x000000018286F440
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001828703A0-0x00000001828709B0
		}
	
		// Methods
		private void _BPNormalEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE3670-0x0000000188CE370C
		private void _BPBuildEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE31BC-0x0000000188CE32C8
		private void _BPBuildCutoffEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE2E8C-0x0000000188CE2F24
		[BurstCompile]
		private static void _BPBuildStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CE35F4-0x0000000188CE3670
		[BurstCompile]
		private static void _BPBuildProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CE34D4-0x0000000188CE3550
		[BurstCompile]
		private static void _BPBuildEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CE33E4-0x0000000188CE3460
		[BurstCompile]
		private static void _BPBuildCutoffStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE315C-0x0000000188CE31BC
		[BurstCompile]
		private static void _BPBuildCutoffStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE2FC4-0x0000000188CE3024
		[BurstCompile]
		private static void _BPBuildCutoffStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE30A4-0x0000000188CE3104
		public void SetSharedExtData(IntPtr data); // 0x00000001865C0760-0x00000001865C0770
		public void Execute(int startIndex, int count); // 0x0000000188CE2C44-0x0000000188CE2C84
		public void Execute(int index); // 0x0000000188CE22A0-0x0000000188CE2C44
		[BurstCompile]
		private static void _CutoffStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE46FC-0x0000000188CE475C
		[BurstCompile]
		private static void _CutoffStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE4528-0x0000000188CE4588
		[BurstCompile]
		private static void _CutoffStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE4608-0x0000000188CE4668
		private static void _BuildStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CE412C-0x0000000188CE425C
		private static void _BuildStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CE3E78-0x0000000188CE3FB0
		[BurstCompile]
		private static void _BuildStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CE40B0-0x0000000188CE412C
		[BurstCompile]
		private static void _HighLightStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5064-0x0000000188CE50C4
		[BurstCompile]
		private static void _HighLightEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE4B7C-0x0000000188CE4BDC
		[BurstCompile]
		private static void _HighLightProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE4E38-0x0000000188CE4E98
		[BurstCompile]
		private static void _FigureStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE49FC-0x0000000188CE4A5C
		[BurstCompile]
		private static void _FigureProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE499C-0x0000000188CE49FC
		[BurstCompile]
		private static void _FigureEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE4818-0x0000000188CE4878
		[BurstCompile]
		private static void _HintStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha); // 0x0000000188CE52C8-0x0000000188CE5340
		[BurstCompile]
		private static void _HintEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, bool restoreOwnerVisibility); // 0x00000001827C8010-0x00000001827C8340
		[BurstCompile]
		private static void _HintProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE50C4-0x0000000188CE5124
		[BurstCompile]
		private static void _BorderStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE3E18-0x0000000188CE3E78
		[BurstCompile]
		private static void _BorderEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE3CDC-0x0000000188CE3D3C
		[BurstCompile]
		private static void _BorderProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE3D3C-0x0000000188CE3D9C
		[BurstCompile]
		private static void _OverloadStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5B60-0x0000000188CE5BC0
		[BurstCompile]
		private static void _OverloadEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE563C-0x0000000188CE569C
		[BurstCompile]
		private static void _OverloadProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5A0C-0x0000000188CE5A6C
		[BurstCompile]
		private static void _OverloadInvalidStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE59AC-0x0000000188CE5A0C
		[BurstCompile]
		private static void _OverloadInvalidEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5764-0x0000000188CE57C4
		[BurstCompile]
		private static void _OverloadInvalidProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE57C4-0x0000000188CE5824
		private static void _Repair0Start(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE631C-0x0000000188CE6398
		private static void _Repair0End(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE615C-0x0000000188CE61DC
		[BurstCompile]
		private static void _Repair0Process(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000188CE62A4-0x0000000188CE631C
		[BurstCompile]
		private static void _Repair1Start(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE663C-0x0000000188CE669C
		[BurstCompile]
		private static void _Repair1End(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE6438-0x0000000188CE6498
		[BurstCompile]
		private static void _Repair1Process(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000188CE6528-0x0000000188CE65A0
		private static void _BlueprintProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // 0x0000000188CE0768-0x0000000188CE0C1C
		[BurstCompile]
		private static void _BlueprintProcessInternal(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE3B60-0x0000000188CE3BC0
		[BurstCompile]
		private static void _BlueprintEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // 0x0000000188CE3800-0x0000000188CE3878
		[BurstCompile]
		private static void _BlueprintStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE3C10-0x0000000188CE3C70
		[BurstCompile]
		private static void _PreSelectStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE60FC-0x0000000188CE615C
		[BurstCompile]
		private static void _PreSelectEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5EF0-0x0000000188CE5F50
		[BurstCompile]
		private static void _PreSelectProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5F50-0x0000000188CE5FB0
		[BurstCompile]
		private static void _ContinuationStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE4410-0x0000000188CE4470
		[BurstCompile]
		private static void _ContinuationEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE425C-0x0000000188CE42BC
		[BurstCompile]
		private static void _ContinuationProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE42BC-0x0000000188CE431C
		[BurstCompile]
		private static void _SocialSharingStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE6C50-0x0000000188CE6CB0
		[BurstCompile]
		private static void _PowerInteractionStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5E1C-0x0000000188CE5E7C
		[BurstCompile]
		private static void _PowerInteractionEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5C54-0x0000000188CE5CB4
		[BurstCompile]
		private static void _InvalidOverlapPlaceStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5520-0x0000000188CE5580
		[BurstCompile]
		private static void _InvalidOverlapPlaceEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5384-0x0000000188CE53E4
		[BurstCompile]
		private static void _SnowCoverageStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE6AC4-0x0000000188CE6B24
		[BurstCompile]
		private static void _SnowCoverageProcess(ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE69A0-0x0000000188CE69FC
		[BurstCompile]
		private static void _SnowCoverageMaintain(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE68E0-0x0000000188CE6940
		[BurstCompile]
		private static void _SnowCoverageEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE6790-0x0000000188CE67F0
		public static bool ShouldDisplaySnowCoverage(AdditiveEffectFragment.AdditiveEffectType curEffectType, bool snowEnabled, bool hasSnow); // 0x0000000188CE036C-0x0000000188CE037C
		private static void _ApplySnowCoverageRendererVisibility(ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE037C-0x0000000188CE0768
		public static unsafe void ResetMaterial(HGFactoryRendererBinderComponent* rendererBinder, ref SharedDataContainer.SharedExtData extData, bool resetRenderPass = true /* Metadata: 0x0263BA5D */, bool resetAdditiveMat = true /* Metadata: 0x0263BA5E */); // 0x0000000188CE2C94-0x0000000188CE2E00
		public static void ResetMaterial(ref HGFactoryRendererBinderComponent rendererBinder, ref SharedDataContainer.SharedExtData extData, bool resetRenderPass = true /* Metadata: 0x0263BA5F */, bool resetAdditiveMat = true /* Metadata: 0x0263BA60 */); // 0x0000000188CE2C84-0x0000000188CE2C94
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B5B0-0x000000018561B5C0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BA61 */); // 0x0000000188CE2E00-0x0000000188CE2E8C
		public JobHandle ScheduleDefer(JobHandle jobHandleDep0, JobHandle jobHandleDep1, int innerLoopBatchCount = 1 /* Metadata: 0x0263BA62 */); // 0x0000000185678460-0x0000000185678610
		[BurstCompile]
		public static void _BPBuildStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CE3550-0x0000000188CE35F4
		[BurstCompile]
		public static void _BPBuildProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CE3460-0x0000000188CE34D4
		[BurstCompile]
		public static void _BPBuildEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CE32C8-0x0000000188CE33E4
		[BurstCompile]
		public static void _BPBuildCutoffStateStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE3104-0x0000000188CE315C
		[BurstCompile]
		public static void _BPBuildCutoffStateEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE2F24-0x0000000188CE2FC4
		[BurstCompile]
		public static void _BPBuildCutoffStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE3024-0x0000000188CE30A4
		[BurstCompile]
		public static void _CutoffStateStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE4668-0x0000000188CE46FC
		[BurstCompile]
		public static void _CutoffStateEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE4470-0x0000000188CE4528
		[BurstCompile]
		public static void _CutoffStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x0000000188CE4588-0x0000000188CE4608
		[BurstCompile]
		public static void _BuildStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x0000000188CE3FB0-0x0000000188CE40B0
		[BurstCompile]
		public static void _HighLightStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE4E98-0x0000000188CE5064
		[BurstCompile]
		public static void _HighLightEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE4A5C-0x0000000188CE4B7C
		[BurstCompile]
		public static void _HighLightProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE4BDC-0x0000000188CE4E38
		[BurstCompile]
		public static void _FigureStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE0C1C-0x0000000188CE1798
		[BurstCompile]
		public static void _FigureProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE4878-0x0000000188CE499C
		[BurstCompile]
		public static void _FigureEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE475C-0x0000000188CE4818
		[BurstCompile]
		public static void _HintStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha); // 0x0000000188CE5124-0x0000000188CE52C8
		[BurstCompile]
		public static void _HintEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, bool restoreOwnerVisibility); // 0x00000001827C7460-0x00000001827C8010
		[BurstCompile]
		public static void _HintProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000186805BA0-0x0000000186805BB0
		[BurstCompile]
		public static void _BorderStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE3D9C-0x0000000188CE3E18
		[BurstCompile]
		public static void _BorderEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE3C70-0x0000000188CE3CDC
		[BurstCompile]
		public static void _BorderProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000186805BA0-0x0000000186805BB0
		[BurstCompile]
		public static void _OverloadStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5A6C-0x0000000188CE5B60
		[BurstCompile]
		public static void _OverloadEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5580-0x0000000188CE563C
		[BurstCompile]
		public static void _OverloadProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000186805BA0-0x0000000186805BB0
		[BurstCompile]
		public static void _OverloadInvalidStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5824-0x0000000188CE59AC
		[BurstCompile]
		public static void _OverloadInvalidEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE569C-0x0000000188CE5764
		[BurstCompile]
		public static void _OverloadInvalidProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000186805BA0-0x0000000186805BB0
		[BurstCompile]
		public static void _Repair0Process_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000188CE61DC-0x0000000188CE62A4
		[BurstCompile]
		public static void _Repair1Start_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE65A0-0x0000000188CE663C
		[BurstCompile]
		public static void _Repair1End_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE6398-0x0000000188CE6438
		[BurstCompile]
		public static void _Repair1Process_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x0000000188CE6498-0x0000000188CE6528
		[BurstCompile]
		public static void _BlueprintProcessInternal_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE3878-0x0000000188CE3B60
		[BurstCompile]
		public static void _BlueprintEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // 0x0000000188CE370C-0x0000000188CE3800
		[BurstCompile]
		public static void _BlueprintStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE3BC0-0x0000000188CE3C10
		[BurstCompile]
		public static void _PreSelectStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5FB0-0x0000000188CE60FC
		[BurstCompile]
		public static void _PreSelectEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5E7C-0x0000000188CE5EF0
		[BurstCompile]
		public static void _PreSelectProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000186805BA0-0x0000000186805BB0
		[BurstCompile]
		public static void _ContinuationStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE431C-0x0000000188CE4410
		[BurstCompile]
		public static void _ContinuationEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000186805BA0-0x0000000186805BB0
		[BurstCompile]
		public static void _ContinuationProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000186805BA0-0x0000000186805BB0
		[BurstCompile]
		public static void _SocialSharingStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE6B24-0x0000000188CE6C50
		[BurstCompile]
		public static void _PowerInteractionStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5CB4-0x0000000188CE5E1C
		[BurstCompile]
		public static void _PowerInteractionEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5BC0-0x0000000188CE5C54
		[BurstCompile]
		public static void _InvalidOverlapPlaceStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE53E4-0x0000000188CE5520
		[BurstCompile]
		public static void _InvalidOverlapPlaceEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE5340-0x0000000188CE5384
		[BurstCompile]
		public static void _SnowCoverageStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE69FC-0x0000000188CE6AC4
		[BurstCompile]
		public static void _SnowCoverageProcess_BurstManaged(ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE6940-0x0000000188CE69A0
		[BurstCompile]
		public static void _SnowCoverageMaintain_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE67F0-0x0000000188CE68E0
		[BurstCompile]
		public static void _SnowCoverageEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x0000000188CE669C-0x0000000188CE6790
	}

	public static class AudioJobs // TypeDefIndex: 79809
	{
		// Nested types
		public struct FAggregateEmitterTempData // TypeDefIndex: 79802
		{
			// Fields
			public float3 sumPos; // 0x00
			public float sumWeight; // 0x0C
			public int count; // 0x10
		}
	
		public struct FPipeEmitterData // TypeDefIndex: 79803
		{
			// Fields
			public float3 posData; // 0x00
			public float2 extraData; // 0x0C
			public float sumWeight; // 0x14
			public int count; // 0x18
		}
	
		public struct FPipeEmitterTempData // TypeDefIndex: 79804
		{
			// Fields
			public FPipeEmitterData waterPipeData; // 0x00
			public FPipeEmitterData gasPipeData; // 0x1C
		}
	
		public struct FGroupEmitterTempData // TypeDefIndex: 79805
		{
			// Fields
			public float3x3 sumPos; // 0x00
			public float3 sumWeight; // 0x24
			public float3 count; // 0x30
			public int inMainRegionActiveCount; // 0x3C
		}
	
		[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
		public struct AudioDistanceAndCullingJob : IJobParallelFor // TypeDefIndex: 79806
		{
			// Fields
			[ReadOnly]
			public float cullingCullDistanceSq; // 0x00
			[ReadOnly]
			public float cullingRestoreDistanceSq; // 0x04
			[ReadOnly]
			public float3 listenerPos; // 0x08
			[NoAlias]
			public EntityQueryV2.QueryResult qr; // 0x18
	
			// Methods
			public void Execute(int index); // 0x0000000188CEBC68-0x0000000188CEBE38
		}
	
		[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
		public struct AudioGroupEmitterJob : IJobParallelFor // TypeDefIndex: 79807
		{
			// Fields
			[ReadOnly]
			public float3 listenerPos; // 0x00
			[ReadOnly]
			public float innerRadiusSq; // 0x0C
			[ReadOnly]
			public float outerRadiusSq; // 0x10
			[NoAlias]
			public EntityQueryV2.QueryResult qr; // 0x18
			[NativeDisableParallelForRestriction]
			public NativeArray<FGroupEmitterTempData> tempEmitterData; // 0x38
			[NativeDisableUnsafePtrRestriction]
			public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x48
	
			// Methods
			public void Execute(int index); // 0x0000000188CEBE38-0x0000000188CEC428
			public void SetSharedExtData(IntPtr data); // 0x00000001857AFED0-0x00000001857AFEE0
		}
	
		[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
		public struct WaterPipeEmitterJob : IJobParallelFor // TypeDefIndex: 79808
		{
			// Fields
			[ReadOnly]
			public float3 listenerPos; // 0x00
			[NoAlias]
			public EntityQueryV2.QueryResult qr; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<FPipeEmitterTempData> tempEmitterData; // 0x30
			[ReadOnly]
			public float outerRadiusSq; // 0x40
			[NativeDisableUnsafePtrRestriction]
			public unsafe GlobalEnv* envPtr; // 0x48
	
			// Methods
			public void Execute(int index); // 0x0000000188CF6BF4-0x0000000188CF6D7C
			private void _DoCalculate(ref FPipeEmitterTempData tempData, ref PipeFragment unit); // 0x0000000188CF6F6C-0x0000000188CF6F88
			private void _DoCalculatePipe(ref FPipeEmitterData emitterData, ref PipeFragment unit); // 0x0000000188CF6D7C-0x0000000188CF6F6C
			public void SetGlobalEnv(ref GlobalEnv env); // 0x00000001857AFED0-0x00000001857AFEE0
		}
	
		// Methods
		private static void _EntityIdx(int groupIdx, EntityQueryV2.BlockRange blockRange, GroupType group, out int startEntityIdx, out int endEntityIdx); // 0x0000000188CEB7FC-0x0000000188CEB838
		[Conditional("BEYOND_DEBUG")]
		private static void _SetDebugGizmosType(ref AudioFragment audioFrag, AudioDebugGizmosType t); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[BurstCompile]
	public struct BatchArrowJob : IJob // TypeDefIndex: 79810
	{
		// Fields
		[NoAlias]
		public EntityManager em; // 0x00
		public float4 forbiddenColor; // 0x10
		public float4 evaluatedColor; // 0x20
		public EntityQueryV2.QueryResult normalQr; // 0x30
		public EntityQueryV2.QueryResult previewQr; // 0x50
		[NativeDisableUnsafePtrRestriction]
		public GlobalEnv globalEnv; // 0x70
		[NativeDisableUnsafePtrRestriction]
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x5B0
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x5B8
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x5C0
		public float4 normalColor; // 0x5C8
		public Beyond.Gameplay.Factory.FrustumPlanes frustum; // 0x5D8
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x63C
	
		// Methods
		private void _ExecutePort(int index, EntityQueryV2.QueryResult qr); // 0x0000000188CECF00-0x0000000188CED5E0
		private void _ExecutePreview(int index, EntityQueryV2.QueryResult qr); // 0x0000000188CED5E0-0x0000000188CEDB40
		public void Execute(int index); // 0x0000000188CEC4AC-0x0000000188CEC538
		private void _BatchPortArrow(ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, bool pipeValid, float mapHeightValue, bool inOut, bool preview = false /* Metadata: 0x0263BA63 */, bool inBuildMode = false /* Metadata: 0x0263BA64 */, bool inMainRegion = true /* Metadata: 0x0263BA65 */, bool buildingBelt = true /* Metadata: 0x0263BA66 */, bool buildingPipe = true /* Metadata: 0x0263BA67 */, bool blueprintSelectedUnit = false /* Metadata: 0x0263BA68 */, bool inputDisabled = false /* Metadata: 0x0263BA69 */, bool outputDisabled = false /* Metadata: 0x0263BA6A */, bool inputFluidDisabled = false /* Metadata: 0x0263BA6B */, bool outputFluidDisabled = false /* Metadata: 0x0263BA6C */); // 0x0000000188CEC538-0x0000000188CECF00
		public void SetSharedExtData(IntPtr data); // 0x00000001865CDA30-0x00000001865CDA40
		public void Execute(); // 0x0000000188CEC428-0x0000000188CEC4AC
	}

	[BurstCompile]
	public struct BatchInsideConveyorJob : IJob // TypeDefIndex: 79811
	{
		// Fields
		public EntityQueryV2.QueryResult normalQr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public GlobalEnv globalEnv; // 0x20
		public UnsafeList<float4x4> conveyorInsideMatrices; // 0x560
		public Beyond.Gameplay.Factory.FrustumPlanes frustum; // 0x568
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x5D0
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x5D8
	
		// Methods
		public void Execute(int index); // 0x0000000188CEDB40-0x0000000188CEDB68
		private void _CollectInsideConveyor(int index, EntityQueryV2.QueryResult qr); // 0x0000000188CEDF30-0x0000000188CEE458
		private void _BatchPortInside(uint nodeId, float3 pos, quaternion rot, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, ref ComplexPortFragment ports, bool bInOut, float mapHeightValue, bool blueprintSelectedUnit); // 0x0000000188CEDBD0-0x0000000188CEDF30
		public void SetSharedExtData(IntPtr data); // 0x00000001865CDA20-0x00000001865CDA30
		public void Execute(); // 0x0000000188CEDB68-0x0000000188CEDBD0
	}

	[BurstCompile]
	public struct BatchNormalArrowJob : IJob // TypeDefIndex: 79812
	{
		// Fields
		[NoAlias]
		public EntityManager em; // 0x00
		public float4 forbiddenColor; // 0x10
		public float4 evaluatedColor; // 0x20
		public EntityQueryV2.QueryResult normalQr; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public GlobalEnv globalEnv; // 0x50
		[NativeDisableUnsafePtrRestriction]
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x590
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x598
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x5A0
		public float4 normalColor; // 0x5A8
		public Beyond.Gameplay.Factory.FrustumPlanes frustum; // 0x5B8
		public UnsafeParallelHashMap<int, bool> arrowPlacedDic; // 0x620
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x630
		private int m_arrowPlacedCount; // 0x634
	
		// Methods
		public static bool UseBuildModeArrowLayout(bool inBuildMode, bool inBlueprintMode); // 0x0000000182814B20-0x0000000182814B30
		public static bool ShouldUsePreviewArrowRenderer(bool inBuildMode, bool inBlueprintMode, bool isPreviewArrow, PlatformLayers platformLayer); // 0x0000000182814B00-0x0000000182814B20
		private void _ExecutePort(int index, EntityQueryV2.QueryResult qr); // 0x0000000188CEEFBC-0x0000000188CEF674
		private void _BatchPortArrow(uint nodeId, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, bool pipeValid, float mapHeightValue, bool inOut, bool inBuildMode = false /* Metadata: 0x0263BA6D */, bool inMainRegion = true /* Metadata: 0x0263BA6E */, bool buildingBelt = true /* Metadata: 0x0263BA6F */, bool buildingPipe = true /* Metadata: 0x0263BA70 */, bool inputDisabled = false /* Metadata: 0x0263BA71 */, bool outputDisabled = false /* Metadata: 0x0263BA72 */, bool inputFluidDisabled = false /* Metadata: 0x0263BA73 */, bool outputFluidDisabled = false /* Metadata: 0x0263BA74 */); // 0x0000000188CEE4E8-0x0000000188CEEFBC
		public void Execute(int index); // 0x0000000188CEE4C0-0x0000000188CEE4E8
		public void Execute(); // 0x0000000188CEE458-0x0000000188CEE4C0
		public void SetSharedExtData(IntPtr data); // 0x000000018723AF20-0x000000018723AF30
	}

	[BurstCompile]
	public struct BatchPreviewArrowJob : IJob // TypeDefIndex: 79813
	{
		// Fields
		[NoAlias]
		public EntityManager em; // 0x00
		public EntityQueryV2.QueryResult previewQr; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public GlobalEnv globalEnv; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x570
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x578
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x580
		public float4 normalColor; // 0x588
		public UnsafeParallelHashMap<int, bool> arrowPlacedDic; // 0x598
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x5A8
	
		// Methods
		public void Execute(); // 0x0000000188CEF674-0x0000000188CEF6DC
		private void _ExecutePreview(int index, EntityQueryV2.QueryResult qr); // 0x0000000188CF0030-0x0000000188CF053C
		private void _BatchPortArrow(ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, bool pipeValid, float mapHeightValue, bool inOut, bool inBuildMode = false /* Metadata: 0x0263BA75 */, bool inMainRegion = true /* Metadata: 0x0263BA76 */); // 0x0000000188CEF6DC-0x0000000188CF0030
		public void SetSharedExtData(IntPtr data); // 0x000000018723AF30-0x000000018723AF40
	}

	[BurstCompile]
	public struct BufferSwapJob : IJob // TypeDefIndex: 79814
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* globalEnvPtr; // 0x00
		public bool bConveyorSwap; // 0x08
		public bool bGuideFigureSwap; // 0x09
		public bool bPreviewConveyorSwap; // 0x0A
		public bool bPipeSwap; // 0x0B
		public bool bPortArrowSwap; // 0x0C
		public bool bCargoSwap; // 0x0D
		public bool bWireSwap; // 0x0E
	
		// Methods
		public void Execute(); // 0x0000000188CF053C-0x0000000188CF05BC
	}

	[BurstCompile]
	public struct BuildingEnvRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 79815
	{
		// Fields
		[NoAlias]
		public EntityManager em; // 0x00
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x18
	
		// Methods
		public void Execute(int index); // 0x0000000188CF05FC-0x0000000188CF0BBC
		private void _RenderEnv(Entity rEntity, ref UnitEnvironmentRelation receiver); // 0x0000000188CF0BBC-0x0000000188CF0CC4
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B5A0-0x000000018561B5B0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BA77 */); // 0x0000000185FFAD10-0x0000000185FFAE80
		public void Execute(int startIndex, int count); // 0x0000000188CF05BC-0x0000000188CF05FC
		public void SetSharedExtData(IntPtr data); // 0x000000018561CBD0-0x000000018561CBE0
	}

	[BurstCompile]
	public struct BuildingLiquidRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 79816
	{
		// Fields
		[NoAlias]
		public EntityManager em; // 0x00
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x18
	
		// Methods
		public void Execute(int index); // 0x0000000188CF0CC4-0x0000000188CF12D4
		private void _ApplyLiquidPerDraw(Entity rEntity, ValueTuple<int, uint> liquidData); // 0x0000000188CF1314-0x0000000188CF141C
		public void Execute(int startIndex, int count); // 0x0000000188CF12D4-0x0000000188CF1314
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B5A0-0x000000018561B5B0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BA78 */); // 0x0000000185FFA8B0-0x0000000185FFAA20
		public void SetSharedExtData(IntPtr data); // 0x000000018561CBD0-0x000000018561CBE0
	}

	[BurstCompile]
	public struct BuildingStatePosCollectJob : IJob // TypeDefIndex: 79817
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		public float offsetY; // 0x20
		public FunctionPointer<UnsafeJobFuncPointers.QueryStateIconPath> queryStateIconPath; // 0x28
		public UnsafeList<float4x4> statePosList; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
		public bool isInFight; // 0x40
		public Beyond.Gameplay.Factory.FrustumPlanes frustum; // 0x44
	
		// Methods
		public void Execute(int index); // 0x0000000188CF141C-0x0000000188CF1620
		private void _Collect(ref UnitFragment unit, ref UnitTransFragment trans, ref UnitConfigFragment config, ref UnitStatusFragment status, ref SharedDataFragment sharedData); // 0x0000000188CF16D4-0x0000000188CF1C88
		private bool _ShouldAddStatePos(float3 pos); // 0x0000000188CEB838-0x0000000188CEBAAC
		public void Execute(int startIndex, int count); // 0x0000000188CF1620-0x0000000188CF166C
		public void Execute(); // 0x0000000188CF166C-0x0000000188CF16D4
		public void SetSharedExtData(IntPtr data); // 0x00000001855D8A50-0x00000001855D8A60
	}

	[BurstCompile]
	public struct BuildingStateRendererJob : IJobParallelFor // TypeDefIndex: 79818
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<float4x4> statePosList; // 0x20
	
		// Methods
		public void Execute(int index); // 0x0000000188CF1C88-0x0000000188CF1DFC
	}

	[BurstCompile]
	public struct CargoCollectJob : IJob // TypeDefIndex: 79819
	{
		// Fields
		public float offsetY; // 0x00
		public Beyond.Gameplay.Factory.FrustumPlanes frustum; // 0x04
		public float frustumPadding; // 0x68
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x70
		[NativeDisableUnsafePtrRestriction]
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* rendererList; // 0x90
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* env; // 0x98
		[NativeDisableUnsafePtrRestriction]
		public unsafe ConveyorExtContainer.ConveyorExt* conveyorExtData; // 0xA0
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0xA8
	
		// Methods
		public void Execute(int index); // 0x0000000188CF1DFC-0x0000000188CF1FD8
		private unsafe void _Collect(CargoFragment* cargoFrag, ref SharedDataContainer.SharedExtData extData, ref ConveyorExtContainer.ConveyorExt conveyorExt); // 0x0000000188CF2054-0x0000000188CF2270
		public void Execute(); // 0x0000000188CF1FD8-0x0000000188CF2054
		public void SetGlobalEnvRef(ref GlobalEnv envRef); // 0x0000000185D49920-0x0000000185D49930
		public void SetConveyorExtData(IntPtr data); // 0x00000001865CCBD0-0x00000001865CCBE0
		public void SetSharedExtData(IntPtr data); // 0x00000001865CCBC0-0x00000001865CCBD0
	}

	[BurstCompile]
	public struct CargoPredictJob : IJobParallelFor, IJobParallelForDefer // TypeDefIndex: 79820
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x00
		[NoAlias]
		public EntityManager em; // 0x08
		public long serverTime; // 0x18
		[NativeDisableUnsafePtrRestriction]
		public unsafe ConveyorExtContainer.ConveyorExt* conveyorExtData; // 0x20
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x28
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* env; // 0x30
	
		// Methods
		public void Execute(int index); // 0x0000000188CF2270-0x0000000188CF2678
		public void SetConveyorExtData(IntPtr data); // 0x000000018561BB30-0x000000018561BB40
		public void SetSharedExtData(IntPtr data); // 0x000000018561BB40-0x000000018561BB50
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B5B0-0x000000018561B5C0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 4 /* Metadata: 0x0263BA79 */); // 0x000000018561BE30-0x000000018561BF90
	}

	[BurstCompile]
	public struct CargoPredictQueryJob : IJob // TypeDefIndex: 79821
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute(); // 0x0000000188CF2678-0x0000000188CF2720
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x0263BA7A */); // 0x000000018561B210-0x000000018561B250
	}

	[BurstCompile]
	public struct CargoRenderJob : IJobParallelForBatch // TypeDefIndex: 79822
	{
		// Fields
		public PreResolvedComponentAccess<HGFactoryRendererBinderComponent> binderAccess; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x18
		[NativeDisableUnsafePtrRestriction]
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* rendererList; // 0x28
	
		// Methods
		public void Execute(int startIndex, int count); // 0x0000000188CF2720-0x0000000188CF2890
		public void SetRendererList(IntPtr data); // 0x000000018561BB40-0x000000018561BB50
		public void ResolveAccess([IsReadOnly] in EntityManager em, int count); // 0x0000000185C9C2E0-0x0000000185C9C490
	}

	[BurstCompile]
	public struct CargoRenderQueryJob : IJob // TypeDefIndex: 79823
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute(); // 0x0000000188CF2890-0x0000000188CF2918
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x0263BA7B */); // 0x0000000188CF2918-0x0000000188CF2930
	}

	[BurstCompile]
	public struct ClearRendererVisibleDirtyJob : IJob // TypeDefIndex: 79824
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x00
		public int count; // 0x08
	
		// Methods
		public void Execute(); // 0x0000000188CF2930-0x0000000188CF295C
		public void SetSharedExtData(IntPtr data); // 0x000000018561B5B0-0x000000018561B5C0
	}

	[BurstCompile]
	public struct ConveyorCollectJob : IJob // TypeDefIndex: 79825
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* lPosList; // 0x20
		[NativeDisableUnsafePtrRestriction]
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* mPosList; // 0x28
		[NativeDisableUnsafePtrRestriction]
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* rPosList; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* globalEnvPtr; // 0x40
		public Beyond.Gameplay.Factory.FrustumPlanes frustum; // 0x48
		public float frustumPadding; // 0xAC
	
		// Methods
		public void Execute(int index); // 0x0000000188CF295C-0x0000000188CF2AD8
		private void _Collect(ref ConveyorFragment conveyor, ref SharedDataFragment sharedDataFrag, bool preview, bool valid); // 0x0000000188CF2B8C-0x0000000188CF2F58
		public void Execute(int startIndex, int count); // 0x0000000188CF2AD8-0x0000000188CF2B24
		public void Execute(); // 0x0000000188CF2B24-0x0000000188CF2B8C
		public void SetSharedExtData(IntPtr data); // 0x00000001855D8A50-0x00000001855D8A60
	}

	[BurstCompile]
	public struct ConveyorFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 79826
	{
		// Fields
		public PreResolvedComponentAccess<FigureRenderFragment, HGFactoryRendererBinderComponent> componentAccess; // 0x00
		public int startOffsetIndex; // 0x28
		public float conveyorOffsetY; // 0x2C
		public float simpleDrawingType; // 0x30
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public IntPtr dataMatrices; // 0x38
		public NativeArray<Entity> rendererEntities; // 0x40
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x50
	
		// Methods
		public void Execute(int startIndex, int count); // 0x0000000188CF2F58-0x0000000188CF30F8
		private void _UpdateCachedConveyor(Entity cachedEntity, uint sharedDataHandle, float adjustGroundHeight, float3 pos, float3 rot, float conveyorIdx, float conveyorLength, float speed, bool preview, float offsetY, bool valid = true /* Metadata: 0x0263BA7C */, bool highlight = false /* Metadata: 0x0263BA7D */); // 0x0000000188CF3168-0x0000000188CF33B8
		public void SetSharedExtData(IntPtr data); // 0x00000001872335D0-0x00000001872335E0
		public void ResolveAccess([IsReadOnly] in EntityManager em, int count); // 0x0000000188CF30F8-0x0000000188CF3168
	}

	[BurstCompile]
	public struct ConveyorInsideRenderJob : IJobParallelFor // TypeDefIndex: 79827
	{
		// Fields
		[ReadOnly]
		public UnsafeList<float4x4> matrices; // 0x00
		[ReadOnly]
		public NativeArray<Entity> renderEntities; // 0x10
		public UnityEngine.Color beltInsideColor; // 0x20
		public float speed; // 0x30
		public float offsetY; // 0x34
		public EntityManager em; // 0x38
		public NativeArray<PerDrawConfig> perDrawConfigs; // 0x48
		public NativeArray<PerDrawConfig> blueprintPerDrawConfigs; // 0x58
		public FunctionPointer<UnsafeJobFuncPointers.ApplyRender> applyRenderFunc; // 0x68
	
		// Methods
		public void Execute(int index); // 0x0000000188CF33B8-0x0000000188CF3618
	}

	[BurstCompile]
	public struct ConveyorPreviewCollectJob : IJob // TypeDefIndex: 79828
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* lPosList; // 0x20
		[NativeDisableUnsafePtrRestriction]
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* mPosList; // 0x28
		[NativeDisableUnsafePtrRestriction]
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* rPosList; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* globalEnvPtr; // 0x40
		[NativeDisableUnsafePtrRestriction]
		public unsafe void* conveyorInfoAllocatorPtr; // 0x48
	
		// Methods
		public void Execute(int index); // 0x0000000188CF3618-0x0000000188CF37C4
		private void _Collect(ref ConveyorPreviewRendererFragment conveyor, ref SharedDataFragment sharedData, bool preview, bool valid); // 0x0000000188CF382C-0x0000000188CF39F0
		public void Execute(); // 0x0000000188CF37C4-0x0000000188CF382C
		public void SetSharedExtData(IntPtr data); // 0x00000001855D8A50-0x00000001855D8A60
	}

	[BurstCompile]
	public struct ConveyorRendererJob : IJobParallelForBatch // TypeDefIndex: 79829
	{
		// Fields
		public PreResolvedComponentAccess<SharedDataFragment, ConveyorRenderFragment, HGFactoryRendererBinderComponent> componentAccess; // 0x00
		public float conveyorOffsetY; // 0x38
		public bool useDistanceFilter; // 0x3C
		public float2 distanceFilterCenterPos; // 0x40
		public float distanceThresholdSq; // 0x48
		public NativeArray<Entity> rendererEntities; // 0x50
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public IntPtr dataMatrices; // 0x60
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public IntPtr previewDataMatrices; // 0x68
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x70
		public int sharedDataSize; // 0x78
	
		// Methods
		public void Execute(int startIndex, int count); // 0x0000000188CF39F0-0x0000000188CF3CF4
		private void _HideInvalid(Entity cachedEntity); // 0x0000000182814B40-0x0000000182814E90
		private void _HideConveyorOutOfDistance(Entity cachedEntity, uint sharedDataHandle); // 0x0000000188CF3CF4-0x0000000188CF3D98
		private void _UpdateCachedConveyor(Entity cachedEntity, float adjustGroundHeight, uint sharedDataHandle, float3 pos, float3 rot, float conveyorIdx, float conveyorLength, float speed, bool preview, BlueprintState.EffectType blueprintRenderType, float offsetY, uint lightMode, bool valid = true /* Metadata: 0x0263BA7E */, bool highlight = false /* Metadata: 0x0263BA7F */); // 0x0000000188CF3D98-0x0000000188CF428C
		public void SetSharedExtData(IntPtr data, int size); // 0x0000000182814B30-0x0000000182814B40
		public void ResolveAccess([IsReadOnly] in EntityManager em, int count); // 0x0000000185C9BBF0-0x0000000185C9BD70
	}

	[BurstCompile]
	public struct EnvGeneratorCollectJob : IJob // TypeDefIndex: 79830
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		public float offsetY; // 0x20
		public UnsafeList<EnvGeneratorRendererInfo> posList; // 0x28
		public Beyond.Gameplay.Factory.FrustumPlanes frustum; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x98
	
		// Methods
		public void Execute(int index); // 0x0000000188CF428C-0x0000000188CF4474
		private void _Collect(ref UnitFragment unit, ref UnitTransFragment trans, ref UnitEnvironmentRelation envGenerator, ref SharedDataFragment sharedData); // 0x0000000188CF4538-0x0000000188CF4830
		private bool _ShouldCullByFrustum(float3 pos); // 0x0000000188CEBB0C-0x0000000188CEBC68
		public void Execute(int startIndex, int count); // 0x0000000188CF44EC-0x0000000188CF4538
		public void Execute(); // 0x0000000188CF4474-0x0000000188CF44EC
		public void SetSharedExtData(IntPtr data); // 0x0000000185D49920-0x0000000185D49930
	}

	[BurstCompile]
	public struct EnvGeneratorRenderJob : IJobParallelFor // TypeDefIndex: 79831
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<EnvGeneratorRendererInfo> posList; // 0x20
	
		// Methods
		public void Execute(int index); // 0x0000000188CF4830-0x0000000188CF49C4
	}

	public struct FrustumPlanes // TypeDefIndex: 79832
	{
		// Fields
		public bool useFilter; // 0x00
		public float4 plane0; // 0x04
		public float4 plane1; // 0x14
		public float4 plane2; // 0x24
		public float4 plane3; // 0x34
		public float4 plane4; // 0x44
		public float4 plane5; // 0x54
	
		// Properties
		public static FrustumPlanes Disabled { get; } // 0x000000018723AF40-0x000000018723AF70 
	
		// Methods
		public static FrustumPlanes Calculate(Camera camera, Plane[] planeCache, bool enabled); // 0x000000018515A220-0x000000018515A690
		public bool IsPointInside([IsReadOnly] in float3 point, float padding = 0f /* Metadata: 0x0263BA80 */); // 0x0000000188CF4D24-0x0000000188CF4D74
		public bool ShouldCullPoint([IsReadOnly] in float3 point, float padding = 0f /* Metadata: 0x0263BA84 */); // 0x0000000188CF4D74-0x0000000188CF4D90
		public bool ShouldKeepPoint([IsReadOnly] in float3 point, float padding = 0f /* Metadata: 0x0263BA88 */); // 0x0000000188CF4D90-0x0000000188CF4DA0
	}

	[BurstCompile]
	internal static class FrustumCullingUtils // TypeDefIndex: 79841
	{
		// Nested types
		public delegate bool ShouldCullPoint_00000A11_PostfixBurstDelegate(bool useFrustumFilter, [IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5); // TypeDefIndex: 79833; 0x00000001812458F0-0x0000000181245910
	
		internal static class ShouldCullPoint_00000A11_BurstDirectCall // TypeDefIndex: 79834
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static ShouldCullPoint_00000A11_BurstDirectCall(); // 0x000000018281A410-0x000000018281A420
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab6f3); // 0x0000000182818B70-0x00000001828197D0
			private static IntPtr GetFunctionPointer(); // 0x00000001828197D0-0x0000000182819AD0
			public static void Constructor(); // 0x00000001828182F0-0x0000000182818B70
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static bool Invoke(bool useFrustumFilter, [IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5); // 0x0000000182819AD0-0x000000018281A410
		}
	
		public delegate bool ShouldKeepPoint_00000A12_PostfixBurstDelegate(bool useFrustumFilter, [IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5); // TypeDefIndex: 79835; 0x00000001812458F0-0x0000000181245910
	
		internal static class ShouldKeepPoint_00000A12_BurstDirectCall // TypeDefIndex: 79836
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static ShouldKeepPoint_00000A12_BurstDirectCall(); // 0x000000018281D530-0x000000018281D540
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab711); // 0x000000018281BC90-0x000000018281C8F0
			private static IntPtr GetFunctionPointer(); // 0x000000018281C8F0-0x000000018281CBF0
			public static void Constructor(); // 0x000000018281B410-0x000000018281BC90
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static bool Invoke(bool useFrustumFilter, [IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5); // 0x000000018281CBF0-0x000000018281D530
		}
	
		public delegate bool IsPointInsideFrustum_00000A13_PostfixBurstDelegate([IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5, float padding = 0f /* Metadata: 0x0263BA9C */); // TypeDefIndex: 79837; 0x00000001812458F0-0x0000000181245910
	
		internal static class IsPointInsideFrustum_00000A13_BurstDirectCall // TypeDefIndex: 79838
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static IsPointInsideFrustum_00000A13_BurstDirectCall(); // 0x00000001828172D0-0x00000001828172E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab72f); // 0x0000000182815710-0x0000000182816370
			private static IntPtr GetFunctionPointer(); // 0x0000000182816370-0x0000000182816670
			public static void Constructor(); // 0x0000000182814E90-0x0000000182815710
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static bool Invoke([IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5, float padding = 0f /* Metadata: 0x0263BAA4 */); // 0x0000000182816670-0x00000001828172D0
		}
	
		public delegate bool _IsPointInsidePlane_00000A14_PostfixBurstDelegate([IsReadOnly] in float4 plane, [IsReadOnly] in float3 point, float padding = 0f /* Metadata: 0x0263BAA8 */); // TypeDefIndex: 79839; 0x000000018124EAD0-0x000000018124EAF0
	
		internal static class _IsPointInsidePlane_00000A14_BurstDirectCall // TypeDefIndex: 79840
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _IsPointInsidePlane_00000A14_BurstDirectCall(); // 0x00000001828438B0-0x00000001828438C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab743); // 0x00000001828422F0-0x0000000182842F50
			private static IntPtr GetFunctionPointer(); // 0x0000000182842F50-0x0000000182843250
			public static void Constructor(); // 0x0000000182841A70-0x00000001828422F0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static bool Invoke([IsReadOnly] in float4 plane, [IsReadOnly] in float3 point, float padding = 0f /* Metadata: 0x0263BAB0 */); // 0x0000000182843250-0x00000001828438B0
		}
	
		// Methods
		[BurstCompile]
		public static bool ShouldCullPoint(bool useFrustumFilter, [IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5); // 0x0000000188CF4AF8-0x0000000188CF4B74
		[BurstCompile]
		public static bool ShouldKeepPoint(bool useFrustumFilter, [IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5); // 0x0000000188CF4BE0-0x0000000188CF4C5C
		[BurstCompile]
		public static bool IsPointInsideFrustum([IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5, float padding = 0f /* Metadata: 0x0263BA8C */); // 0x0000000185F5BE60-0x0000000185F5BEF0
		[BurstCompile]
		private static bool _IsPointInsidePlane([IsReadOnly] in float4 plane, [IsReadOnly] in float3 point, float padding = 0f /* Metadata: 0x0263BA90 */); // 0x0000000188CF4CC4-0x0000000188CF4D24
		[BurstCompile]
		public static bool ShouldCullPoint_BurstManaged(bool useFrustumFilter, [IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5); // 0x0000000188CF4A88-0x0000000188CF4AF8
		[BurstCompile]
		public static bool ShouldKeepPoint_BurstManaged(bool useFrustumFilter, [IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5); // 0x0000000188CF4B74-0x0000000188CF4BE0
		[BurstCompile]
		public static bool IsPointInsideFrustum_BurstManaged([IsReadOnly] in float3 point, [IsReadOnly] in float4 frustumPlane0, [IsReadOnly] in float4 frustumPlane1, [IsReadOnly] in float4 frustumPlane2, [IsReadOnly] in float4 frustumPlane3, [IsReadOnly] in float4 frustumPlane4, [IsReadOnly] in float4 frustumPlane5, float padding = 0f /* Metadata: 0x0263BA94 */); // 0x0000000188CF49C4-0x0000000188CF4A88
		[BurstCompile]
		public static bool _IsPointInsidePlane_BurstManaged([IsReadOnly] in float4 plane, [IsReadOnly] in float3 point, float padding = 0f /* Metadata: 0x0263BA98 */); // 0x0000000188CF4C5C-0x0000000188CF4CC4
	}

	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public struct InteractFacCollectJob : IJob // TypeDefIndex: 79845
	{
		// Fields
		public float3 targetPosition; // 0x00
		public float3 targetForward; // 0x0C
		public float maxAngle; // 0x18
		public float maxDist; // 0x1C
		public float radiusExpand; // 0x20
		public const float ROLE_HIGH_ADDED_VALUE = 2f; // Metadata: 0x0263BAB4
		public const float PIPE_HEIGHT_RANGE = 4f; // Metadata: 0x0263BAB8
		public EntityManager em; // 0x28
		[ReadOnly]
		public EntityQueryV2.QueryResult buildingQr; // 0x38
		[ReadOnly]
		public EntityQueryV2.QueryResult pipeRendererQr; // 0x58
		[ReadOnly]
		public EntityQueryV2.QueryResult conveyorRendererQr; // 0x78
		[NativeDisableUnsafePtrRestriction]
		public unsafe BuildingInfoWrap* mNearBuildingInfo; // 0x98
		[NativeDisableUnsafePtrRestriction]
		public unsafe LogisticInfo* mConveyorInfo; // 0xA0
		[NativeDisableUnsafePtrRestriction]
		public unsafe LogisticInfo* mPipeInfo; // 0xA8
		[NativeDisableUnsafePtrRestriction]
		public unsafe BuildingInfoWrap* mNearBuildingInfoLast; // 0xB0
		[NativeDisableUnsafePtrRestriction]
		public unsafe LogisticInfo* mConveyorInfoLast; // 0xB8
		[NativeDisableUnsafePtrRestriction]
		public unsafe LogisticInfo* mPipeInfoLast; // 0xC0
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0xC8
		private static readonly FixedList512Bytes<float3> LOGISTIC_INTERACT_SAMPLE_OFFSETS; // 0x00
	
		// Nested types
		public struct BuildingInfoWrap // TypeDefIndex: 79842
		{
			// Fields
			public BuildingInfo buildingInfo; // 0x00
			[CompilerGenerated]
			private UnitConfigFragment _unitConfig_k__BackingField; // 0x58
	
			// Properties
			public UnitConfigFragment unitConfig { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x000000018723AF70-0x000000018723AFC0 0x000000018723AFC0-0x000000018723B010
	
			// Methods
			public unsafe void SwapTo(BuildingInfoWrap* other); // 0x0000000188CF7394-0x0000000188CF73D8
		}
	
		public struct BuildingInfo // TypeDefIndex: 79843
		{
			// Fields
			public bool valid; // 0x00
			public int chapterId; // 0x04
			public int sceneId; // 0x08
			public int pendingSlotId; // 0x0C
			public uint nodeId; // 0x10
			public uint sharedDataHandle; // 0x14
			public int subIndex; // 0x18
			public float adjustMapHeight; // 0x1C
			public float3 position; // 0x20
			public float3 rotation; // 0x2C
			public float3 subPosition; // 0x38
			public float3 subRotation; // 0x44
			public float subDist; // 0x50
			public int templateNameFastString; // 0x54
	
			// Properties
			public string templateName { get; set; } // 0x000000018519B2B0-0x000000018519B470 0x0000000188CF74FC-0x0000000188CF7558
	
			// Methods
			public override string ToString(); // 0x0000000188CF73D8-0x0000000188CF74FC
			public void SetData([IsReadOnly] in BuildingInfo info); // 0x000000018723B010-0x000000018723B090
			public bool IsPending(); // 0x0000000185961910-0x0000000185961920
		}
	
		public struct LogisticInfo // TypeDefIndex: 79844
		{
			// Fields
			public bool valid; // 0x00
			public bool isConveyor; // 0x01
			public int pendingSlotId; // 0x04
			public int chapterId; // 0x08
			public int sceneId; // 0x0C
			public uint nodeId; // 0x10
			public int uintIndex; // 0x14
			public float3 position; // 0x18
	
			// Methods
			public bool IsPending(); // 0x0000000185B1CEC0-0x0000000185B1CED0
			public unsafe void SwapTo(LogisticInfo* other); // 0x0000000188CF8930-0x0000000188CF897C
		}
	
		// Constructors
		static InteractFacCollectJob(); // 0x0000000186D470D0-0x0000000186D47620
	
		// Methods
		private void _SwapBuffer(); // 0x0000000188CF6BA4-0x0000000188CF6BF4
		public void Execute(); // 0x0000000188CF4DA0-0x0000000188CF4E00
		private void _ExecuteBuilding(); // 0x0000000188CF520C-0x0000000188CF63F4
		private void _ExecuteConveyor(); // 0x0000000188CF63F4-0x0000000188CF66D0
		private void _ExecutePipe(); // 0x0000000188CF66D0-0x0000000188CF69E8
		private bool _CheckDist(float3 pos, float distSqThreshold, ref int minSearchIndex); // 0x0000000188CF4E00-0x0000000188CF520C
		private static float3 _SnapDirectionToAxis(float3 direction); // 0x0000000188CF69E8-0x0000000188CF6BA4
		public void SetSharedExtData(IntPtr data); // 0x000000018655EDD0-0x000000018655EE60
	}

	[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
	public struct LocalToWorldJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 79846
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe EntityHierarchyContainer.EntityTransformData* hierarchyDataPtr; // 0x08
		public int frameCount; // 0x10
	
		// Methods
		public void Execute(int index); // 0x0000000188CF83E4-0x0000000188CF8500
		public static void TransTRS(ref LocalToWorld localToWorld, IntPtr hierarchyIntPtr, int frameCount = -1 /* Metadata: 0x0263BABC */); // 0x0000000185734D50-0x0000000185734D70
		public static unsafe void TransTRS(ref LocalToWorld localToWorld, EntityHierarchyContainer.EntityTransformData* hierarchyPtr, int frameCount = -1 /* Metadata: 0x0263BABD */); // 0x0000000185734D70-0x0000000185734F80
		public void Execute(int startIndex, int count); // 0x0000000188CF83A4-0x0000000188CF83E4
		public void SetHierarchyData(IntPtr data); // 0x000000018561B590-0x000000018561B5A0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B5B0-0x000000018561B5C0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BABE */); // 0x000000018615F3A0-0x000000018615F500
	}

	[BurstCompile]
	public struct LocalToWorldQueryJob : IJob // TypeDefIndex: 79847
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute(); // 0x0000000188CF8500-0x0000000188CF85A8
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x0263BABF */); // 0x000000018561B210-0x000000018561B250
	}

	[BurstCompile]
	public struct LogisticEffectJob : IJobParallelForDefer // TypeDefIndex: 79848
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x00
		public long deltaTime; // 0x08
	
		// Methods
		public void Execute(int index); // 0x0000000188CF85A8-0x0000000188CF88A8
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer logisticEffectQr); // 0x000000018561B5B0-0x000000018561B5C0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BAC0 */); // 0x00000001861985C0-0x0000000186198770
	}

	[BurstCompile]
	public struct LogisticEffectQueryJob : IJob // TypeDefIndex: 79849
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_logisticEffectQr; // 0x18
	
		// Methods
		public void Execute(); // 0x0000000188CF88A8-0x0000000188CF8930
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer logisticEffectQr, bool resetQr = true /* Metadata: 0x0263BAC1 */); // 0x000000018561B210-0x000000018561B250
	}

	[BurstCompile]
	public struct LogisticsFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 79850
	{
		// Fields
		public EntityManager em; // 0x00
		public float offsetY; // 0x10
		public UnsafeList<Matrix4x4> dataMatrices; // 0x18
		public NativeArray<Entity> rendererEntities; // 0x28
	
		// Methods
		public void Execute(int index); // 0x0000000188CF89C8-0x0000000188CF8C00
		public void Execute(int startIndex, int count); // 0x0000000188CF897C-0x0000000188CF89C8
	}

	[BurstCompile]
	public struct LogisticsHideRendererJob : IJobParallelForBatch // TypeDefIndex: 79851
	{
		// Fields
		public bool hidden; // 0x00
		public EntityQueryV2.QueryResult qr; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x28
	
		// Methods
		public void Execute(int index); // 0x0000000188CF8C00-0x0000000188CF8D50
		public void Execute(int startIndex, int count); // 0x0000000188CF8D50-0x0000000188CF8D9C
		public void SetSharedExtData(IntPtr data); // 0x000000018561BB40-0x000000018561BB50
	}

	[BurstCompile]
	public struct LookAtJob : IJobParallelFor, IJobParallelForDefer // TypeDefIndex: 79852
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityHierarchyContainer.EntityTransformData* hierarchyDataPtr; // 0x08
	
		// Methods
		public void Execute(int index); // 0x0000000188CF8D9C-0x0000000188CF958C
		public void SetHierarchyData(IntPtr data); // 0x000000018561B590-0x000000018561B5A0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B5B0-0x000000018561B5C0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BAC2 */); // 0x000000018561E1F0-0x000000018561E350
	}

	[BurstCompile]
	public struct LookAtQueryJob : IJob // TypeDefIndex: 79853
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute(); // 0x0000000188CF958C-0x0000000188CF9614
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x0263BAC3 */); // 0x000000018561B210-0x000000018561B250
	}

	[BurstCompile]
	public struct OutputCollectJob : IJob // TypeDefIndex: 79854
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		public float offsetY; // 0x20
		public UnsafeList<OutputRendererInfo> posList; // 0x28
		public Beyond.Gameplay.Factory.FrustumPlanes frustum; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x98
	
		// Methods
		public void Execute(int index); // 0x0000000188CF96D8-0x0000000188CF98FC
		private void _Collect(ref UnitFragment unit, ref UnitTransFragment trans, ref UnitConfigFragment config, ref OutputFragment output, ref SharedDataFragment sharedData); // 0x0000000188CF98FC-0x0000000188CF9CF4
		private bool _ShouldCullByFrustum(float3 pos); // 0x0000000188CEBB0C-0x0000000188CEBC68
		public void Execute(int startIndex, int count); // 0x0000000188CF9614-0x0000000188CF9660
		public void Execute(); // 0x0000000188CF9660-0x0000000188CF96D8
		public void SetSharedExtData(IntPtr data); // 0x0000000185D49920-0x0000000185D49930
	}

	[BurstCompile]
	public struct OutputRenderJob : IJobParallelFor // TypeDefIndex: 79855
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<OutputRendererInfo> posList; // 0x20
	
		// Methods
		public void Execute(int index); // 0x0000000188CF9CF4-0x0000000188CFA070
	}

	[BurstCompile]
	public struct PedestalFlashJob : IJobParallelForDefer // TypeDefIndex: 79856
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x00
		public long time; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedExtDataPtr; // 0x10
	
		// Methods
		public void Execute(int index); // 0x0000000188CFA070-0x0000000188CFA298
		private float4 _Flash(ref PedestalLightFlashFragment flashConfig, float deltaTime); // 0x0000000188CFA298-0x0000000188CFA368
		public void SetSharedExtData(IntPtr data); // 0x000000018561B5A0-0x000000018561B5B0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer pedestalFlashQr); // 0x000000018561B5B0-0x000000018561B5C0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BAC4 */); // 0x00000001861D0FD0-0x00000001861D1180
	}

	[BurstCompile]
	public struct PedestalFlashQueryJob : IJob // TypeDefIndex: 79857
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_pedestalFlashQr; // 0x18
	
		// Methods
		public void Execute(); // 0x0000000188CFA368-0x0000000188CFA3F0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer pedestalFlashQr, bool resetQr = true /* Metadata: 0x0263BAC5 */); // 0x000000018561B210-0x000000018561B250
	}

	[BurstCompile]
	public struct PipeCollectJob : IJob // TypeDefIndex: 79858
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult pipeQr; // 0x00
		[NoAlias]
		public EntityQueryV2.QueryResult previewPipeQr; // 0x20
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeLPosMatrices; // 0x40
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeMPosMatrices; // 0x48
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeRPosMatrices; // 0x50
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeLPosMatrices; // 0x58
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeMPosMatrices; // 0x60
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeRPosMatrices; // 0x68
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* trackLPosMatrices; // 0x70
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* trackMPosMatrices; // 0x78
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* trackRPosMatrices; // 0x80
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeSplashPosMatrices; // 0x88
		public UnsafeList<float4x4> comPosMatrices; // 0x90
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x98
		public int sharedDataSize; // 0xA0
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* envPtr; // 0xA8
		public Beyond.Gameplay.Factory.FrustumPlanes frustum; // 0xB0
		public float frustumPadding; // 0x114
	
		// Properties
		public int pipeCount { get; } // 0x0000000188CFBC28-0x0000000188CFBC7C 
	
		// Methods
		public void Execute(int index); // 0x0000000188CFA66C-0x0000000188CFA744
		private void _ExecutePipe(EntityQueryV2.BlockRange blockRange, NativeList<GroupType> groups); // 0x0000000188CFB74C-0x0000000188CFBA00
		private void _ExecutePreviewPipe(EntityQueryV2.BlockRange blockRange, NativeList<GroupType> groups); // 0x0000000188CFBA00-0x0000000188CFBC28
		private void _CollectPipe(int pipeLength, uint memoryStartOffset, uint memoryEndOffset, int subItemType, bool isGas, float waterThickness, float waterFlowDeltaTime, float firstIndex, float waterDirection, float pipeHeight, uint sharedDataHandle, bool isPreview = false /* Metadata: 0x0263BAC6 */, bool valid = true /* Metadata: 0x0263BAC7 */, bool highLight = false /* Metadata: 0x0263BAC8 */); // 0x0000000188CFB0F4-0x0000000188CFB550
		private void _CollectPipeSplash([IsReadOnly] in PipeFragment pipe, uint sharedDataHandle); // 0x0000000188CFACE8-0x0000000188CFB0F4
		private void _CollectPipeCom([IsReadOnly] in PipeFragment pipe, uint sharedDataHandle); // 0x0000000188CFA790-0x0000000188CFACE8
		private void _CollectTrack(int pipeLength, uint memoryStartOffset, uint memoryEndOffset, float pipeHeight, float gridPathHeightStart, float gridPathHeightEnd, uint sharedDataHandle, bool pipeValid); // 0x0000000188CFB550-0x0000000188CFB74C
		public void Execute(int startIndex, int count); // 0x0000000188CFA744-0x0000000188CFA790
		public void Execute(); // 0x0000000188CFA628-0x0000000188CFA66C
		public void SetGlobalEnvRef(ref GlobalEnv envRef); // 0x00000001865CCBC0-0x00000001865CCBD0
		public void SetSharedExtData(IntPtr data, int size); // 0x00000001864A6690-0x00000001864A66A0
	}

	[BurstCompile]
	public struct PipeComRendererJob : IJobParallelForBatch // TypeDefIndex: 79859
	{
		// Fields
		public EntityManager em; // 0x00
		public UnsafeList<float4x4> comPosArr; // 0x10
		public NativeArray<Entity> rendererEntities; // 0x20
		public bool useDistanceFilter; // 0x30
		public float2 distanceFilterCenterPos; // 0x34
		public float distanceThresholdSq; // 0x3C
	
		// Methods
		public void Execute(int startIndex, int count); // 0x0000000188CFBC7C-0x0000000188CFBF34
	}

	[BurstCompile]
	public struct PipeFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 79860
	{
		// Fields
		public PreResolvedComponentAccess<FigureRenderFragment, HGFactoryRendererBinderComponent> componentAccess; // 0x00
		public int startOffsetIndex; // 0x28
		public float simpleDrawingType; // 0x2C
		[NativeDisableUnsafePtrRestriction]
		public IntPtr dataMatrices; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public IntPtr dataMatrices2; // 0x38
		public NativeArray<Entity> rendererEntities; // 0x40
	
		// Methods
		public void Execute(int startIndex, int count); // 0x0000000188CFBF34-0x0000000188CFC15C
		private void _UpdateCachedPipe(Entity cachedEntity, byte protoType, float3 pos, float3 rot, float indexInPipe, float pipeLength, float waterDirection, float waterThickness, short subItemType, bool isPreview = false /* Metadata: 0x0263BAC9 */, bool valid = true /* Metadata: 0x0263BACA */, bool highLight = false /* Metadata: 0x0263BACB */); // 0x0000000188CFC15C-0x0000000188CFC370
		public void ResolveAccess([IsReadOnly] in EntityManager em, int count); // 0x0000000188CF30F8-0x0000000188CF3168
	}

	[BurstCompile]
	public struct PipeLogisticsPosCollectJob : IJob // TypeDefIndex: 79861
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x20
		public UnsafeList<Matrix4x4> posList; // 0x28
	
		// Methods
		public void Execute(int index); // 0x0000000188CFC424-0x0000000188CFC754
		public void Execute(int startIndex, int count); // 0x0000000188CFC3D8-0x0000000188CFC424
		public void SetSharedExtData(IntPtr data); // 0x000000018561BB30-0x000000018561BB40
		public void Execute(); // 0x0000000188CFC370-0x0000000188CFC3D8
	}

	public static class PipeRendererBinderUpdate // TypeDefIndex: 79862
	{
		// Methods
		public static unsafe void Apply([IsReadOnly] in PreResolvedComponentAccess<SharedDataFragment, PipeRenderFragment, HGFactoryRendererBinderComponent> componentAccess, EntityManager rendererEm, Entity cachedEntity, byte protoType, float3 pos, float3 rot, float bend, uint sharedDataHandle, int indexInPipe, int pipeLength, float waterDirection, float firstIndex, float waterThickness, float subItemType, BlueprintState.EffectType blueprintRenderType, float waterFlowDeltaTime, uint lightMode, bool inTopView, float atlasMaxIndex, SharedDataContainer.SharedExtData* sharedDataPtr, bool isPreview = false /* Metadata: 0x0263BACC */, bool valid = true /* Metadata: 0x0263BACD */, bool highLight = false /* Metadata: 0x0263BACE */); // 0x0000000188CFC754-0x0000000188CFCF7C
	}

	[BurstCompile]
	public struct PipeRendererJob : IJobParallelForBatch // TypeDefIndex: 79863
	{
		// Fields
		public PreResolvedComponentAccess<SharedDataFragment, PipeRenderFragment, HGFactoryRendererBinderComponent> componentAccess; // 0x00
		public EntityManager rendererEm; // 0x38
		public bool inTopView; // 0x48
		public bool useDistanceFilter; // 0x49
		public float2 distanceFilterCenterPos; // 0x4C
		public float distanceThresholdSq; // 0x54
		public float atlasMaxIndex; // 0x58
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public IntPtr dataMatrices; // 0x60
		public NativeArray<Entity> rendererEntities; // 0x68
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x78
		public int sharedDataSize; // 0x80
	
		// Methods
		public void Execute(int startIndex, int count); // 0x0000000188CFCF7C-0x0000000188CFD2B8
		private void _HideInvalid(Entity cachedEntity); // 0x000000018287C720-0x000000018287CD40
		private void _HidePipeOutOfDistance(Entity cachedEntity, uint sharedDataHandle); // 0x0000000188CFD2B8-0x0000000188CFD35C
		public void SetSharedExtData(IntPtr data, int size); // 0x0000000185667890-0x00000001856678A0
		public void ResolveAccess([IsReadOnly] in EntityManager em, [IsReadOnly] in EntityManager rEm, int count); // 0x00000001856677A0-0x0000000185667890
	}

	[BurstCompile]
	public struct PipeSplashRendererJob : IJobParallelForBatch // TypeDefIndex: 79864
	{
		// Fields
		public PreResolvedComponentAccess<SharedDataFragment, PipeRenderFragment, HGFactoryRendererBinderComponent> componentAccess; // 0x00
		public bool useDistanceFilter; // 0x38
		public float2 distanceFilterCenterPos; // 0x3C
		public float distanceThresholdSq; // 0x44
		public float atlasMaxIndex; // 0x48
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public IntPtr dataMatrices; // 0x50
		public NativeArray<Entity> rendererEntities; // 0x58
		[NativeDisableUnsafePtrRestriction]
		[NoAlias]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x68
		public int sharedDataSize; // 0x70
	
		// Methods
		public void Execute(int startIndex, int count); // 0x0000000188CFD35C-0x0000000188CFD4E8
		private void _UpdateSplash(Entity cachedEntity, [IsReadOnly] in PipeRendererInfo arg); // 0x0000000188CFD628-0x0000000188CFDAAC
		private void _HideOutOfDistance(Entity cachedEntity, uint sharedDataHandle); // 0x0000000188CFD584-0x0000000188CFD628
		private void _HideInvalid(Entity cachedEntity); // 0x0000000188CFD4E8-0x0000000188CFD584
		public void SetSharedExtData(IntPtr data, int size); // 0x000000018658F060-0x000000018658F070
		public void ResolveAccess([IsReadOnly] in EntityManager em, int count); // 0x0000000185C9BB40-0x0000000185C9BBF0
	}

	[BurstCompile]
	public struct PipeTrackRendererJob : IJob // TypeDefIndex: 79865
	{
		// Fields
		public EntityManager em; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public IntPtr leftArr; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public IntPtr rightArr; // 0x18
		[NativeDisableUnsafePtrRestriction]
		public IntPtr middleArr; // 0x20
		public NativeArray<Entity> rendererLEntities; // 0x28
		public NativeArray<Entity> rendererREntities; // 0x38
		public NativeArray<Entity> rendererMEntities; // 0x48
		public bool useDistanceFilter; // 0x58
		public float2 distanceFilterCenterPos; // 0x5C
		public float distanceThreshold; // 0x64
		public bool inTopView; // 0x68
	
		// Methods
		public void Execute(); // 0x0000000188CFDAAC-0x0000000188CFDEB0
		private void _UpdateCachedTrack(Entity cachedEntity, float3 pos, float3 rot, float indexInPipe, float pipeLength, float pipeHeight, float gridPathHeight, float gridPathHeightEnd, bool valid); // 0x0000000188CFDEB0-0x0000000188CFE19C
	}

	[BurstCompile]
	public struct PipeWaterThicknessQueryJob : IJob // TypeDefIndex: 79866
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute(); // 0x0000000188CFE19C-0x0000000188CFE224
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x0263BACF */); // 0x000000018561B210-0x000000018561B250
	}

	[BurstCompile]
	public struct PipeWaterThicknessRiseJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 79867
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		public float deltaTime; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* globalEnv; // 0x10
	
		// Methods
		public void Execute(int startIndex, int count); // 0x0000000188CFE224-0x0000000188CFE264
		public void Execute(int index); // 0x0000000188CFE264-0x0000000188CFE4A4
		public void SetGlobalEnv(ref GlobalEnv env); // 0x000000018561B5A0-0x000000018561B5B0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B5B0-0x000000018561B5C0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BAD0 */); // 0x000000018561C260-0x000000018561C3C0
	}

	[BurstCompile]
	public struct PortArrowRenderJob : IJobParallelFor // TypeDefIndex: 79868
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public IntPtr arrowMatricesReaderIntPtr; // 0x00
		[ReadOnly]
		public NativeArray<Entity> renderEntities; // 0x08
		[ReadOnly]
		public bool buildMode; // 0x18
		public EntityManager em; // 0x20
		[NativeDisableUnsafePtrRestriction]
		public IntPtr arrowPlacedDicPtr; // 0x30
		public bool bConflictCheck; // 0x38
	
		// Methods
		public void Execute(int index); // 0x0000000188CFE4A4-0x0000000188CFE740
	}

	[BurstCompile]
	public struct PortStateCollectJob : IJob // TypeDefIndex: 79869
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		public UnsafeList<float4x4> portStatePosList; // 0x20
		public float pipePortBlockOffsetY; // 0x28
		public float conveyorPortBlockOffsetY; // 0x2C
		public Beyond.Gameplay.Factory.FrustumPlanes frustum; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x98
	
		// Methods
		public void Execute(int index); // 0x0000000188CFE7F4-0x0000000188CFE954
		private void _Collect(ref ComplexPortFragment complexPortFrag, ref SharedDataContainer.SharedExtData extData); // 0x0000000188CFE954-0x0000000188CFEBDC
		private bool _ShouldAddStatePos(float3 pos); // 0x0000000188CF6F88-0x0000000188CF7088
		public void SetSharedExtData(IntPtr data); // 0x0000000185D49920-0x0000000185D49930
		public void Execute(); // 0x0000000188CFE78C-0x0000000188CFE7F4
		public void Execute(int startIndex, int count); // 0x0000000188CFE740-0x0000000188CFE78C
	}

	[BurstCompile]
	public struct PortStateRendererJob : IJobParallelFor // TypeDefIndex: 79870
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<float4x4> posList; // 0x20
	
		// Methods
		public void Execute(int index); // 0x0000000188CFEBDC-0x0000000188CFEDB0
	}

	[BurstCompile]
	public struct PreviewUnitQueryJob : IJob // TypeDefIndex: 79871
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_previewUnitQr; // 0x18
	
		// Methods
		public void Execute(); // 0x0000000188CFEDB0-0x0000000188CFEE38
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer previewUnitQr, bool resetQr = true /* Metadata: 0x0263BAD1 */); // 0x000000018561B210-0x000000018561B250
	}

	[BurstCompile]
	public struct PumpInEffectJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 79872
	{
		// Fields
		[NoAlias]
		[ReadOnly]
		public EntityManager em; // 0x00
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x18
	
		// Methods
		public void Execute(int index); // 0x0000000188CFEE78-0x0000000188CFF2AC
		public void Execute(int startIndex, int count); // 0x0000000188CFEE38-0x0000000188CFEE78
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B5A0-0x000000018561B5B0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BAD2 */); // 0x0000000185FFAAE0-0x0000000185FFAC50
		public void SetSharedExtData(IntPtr data); // 0x000000018561CBD0-0x000000018561CBE0
	}

	[BurstCompile]
	public struct ResetHierarchyDirtyJob : IJob // TypeDefIndex: 79873
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityHierarchyContainer.EntityTransformData* hierarchyDataPtr; // 0x00
		public int count; // 0x08
	
		// Methods
		public void Execute(); // 0x0000000188CFF2AC-0x0000000188CFF2EC
		public void SetHierarchyData(IntPtr data); // 0x000000018561B5B0-0x000000018561B5C0
	}

	[BurstCompile]
	public struct StatusChangeJob : IJobParallelFor // TypeDefIndex: 79874
	{
		// Fields
		public EntityManager em; // 0x00
		public EventChannel<EvtStatusChange> events; // 0x10
		public EventChannel<EvtVatUpdate> vatUpdateWriter; // 0x20
		public EventChannel<EvtUpdateStatusEffect> updateStatusEffectWriter; // 0x38
		public EventChannel<EvtAudio> audioWriter; // 0x50
		public FunctionPointer<UnsafeJobFuncPointers.QueryBuildingState> queryBuildingState; // 0x68
		public FunctionPointer<UnsafeJobFuncPointers.SetEntityFlashStatue> setEntityFlashStatue; // 0x70
	
		// Methods
		public void Execute(int index); // 0x0000000188CFF2EC-0x0000000188CFF588
	}

	[BurstCompile]
	public struct UnitCullingJob : IJobParallelForBatch // TypeDefIndex: 79875
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
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* env; // 0x30
		[ReadOnly]
		public EntityQueryV2.QueryResult qr; // 0x38
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x58
	
		// Methods
		public void Execute(int startIndex, int count); // 0x0000000188CFFB18-0x0000000188CFFB58
		public void Execute(int index); // 0x0000000188CFF760-0x0000000188CFFB18
		public void SetGlobalEnvRef(ref GlobalEnv envRef); // 0x00000001855D8A60-0x00000001855D8A70
		public void SetSharedExtData(IntPtr data); // 0x00000001855D97D0-0x00000001855D97E0
	}

	[BurstCompile]
	public struct UnitPreviewRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 79876
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* env; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x10
	
		// Methods
		public void Execute(int startIndex, int count); // 0x0000000188CFFD60-0x0000000188CFFDA0
		public void Execute(int index); // 0x0000000188CFFB58-0x0000000188CFFD60
		public void SetGlobalEnvRef(ref GlobalEnv envRef); // 0x000000018561B5B0-0x000000018561B5C0
		public void SetSharedExtData(IntPtr data); // 0x000000018561B5A0-0x000000018561B5B0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B590-0x000000018561B5A0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BAD3 */); // 0x000000018561B420-0x000000018561B590
	}

	[BurstCompile]
	public struct UnitRendererQueryJob : IJob // TypeDefIndex: 79877
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_unitQueryResult; // 0x18
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_liquidQueryResult; // 0x20
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_liquidPumpQueryResult; // 0x28
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_envReceiverQueryResult; // 0x30
	
		// Methods
		public void Execute(); // 0x0000000188CFFDA0-0x0000000188CFFF48
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer unitQr, ref EntityQueryV2.QueryResultDefer liquidQr, ref EntityQueryV2.QueryResultDefer pumpQr, ref EntityQueryV2.QueryResultDefer envReceiverQr, bool resetQr = true /* Metadata: 0x0263BAD4 */); // 0x000000018561CAC0-0x000000018561CB80
	}

	[BurstCompile]
	public struct UpdateUnitRendererTRSJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 79878
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x08
	
		// Methods
		public void Execute(int index); // 0x0000000188CFFF94-0x0000000188D0010C
		private void _Transform(ref HGFactoryRendererBinderComponent rendererBinder, ref LocalToWorld localToWorld, ref SharedDataFragment sharedData); // 0x0000000188D0010C-0x0000000188D001EC
		public void Execute(int startIndex, int count); // 0x0000000188CFFF48-0x0000000188CFFF94
		public void SetSharedExtData(IntPtr data); // 0x000000018561B590-0x000000018561B5A0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B5B0-0x000000018561B5C0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BAD5 */); // 0x000000018615F240-0x000000018615F3A0
	}

	[BurstCompile]
	public struct WireCollectJob : IJob // TypeDefIndex: 79879
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		public EntityManager em; // 0x20
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* env; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
		[NativeDisableUnsafePtrRestriction]
		public unsafe WireRendererInfoCollection<WireRendererInfo>* normalRenderers; // 0x40
		[NativeDisableUnsafePtrRestriction]
		public unsafe WireRendererInfoCollection<WireRendererInfo>* hsNormalRenderers; // 0x48
		[NativeDisableUnsafePtrRestriction]
		public unsafe WireRendererInfoCollection<WireRendererInfo>* hsStrengthenRenderers; // 0x50
		[NativeDisableUnsafePtrRestriction]
		public unsafe WireRendererInfoCollection<WireRendererInfo>* strengthenRenderers; // 0x58
		[NativeDisableUnsafePtrRestriction]
		public unsafe WireRendererInfoCollection<WireRendererInfo>* disableRenderers; // 0x60
		[NativeDisableUnsafePtrRestriction]
		public unsafe WireRendererInfoCollection<WireRendererInfo>* strengthenDisableRenderers; // 0x68
		public FixedString32Bytes factoryPowerPoleMountPoint; // 0x70
		public float wireCullDistance; // 0x90
	
		// Methods
		public void Execute(int index); // 0x0000000188D001EC-0x0000000188D007F0
		private bool _IsNormalConnection(FacBuildingState state); // 0x0000000188CF7098-0x0000000188CF7100
		private bool _IsDisabledConnection(FacBuildingState state); // 0x0000000188CF7088-0x0000000188CF7098
		public void Execute(); // 0x0000000188D007F0-0x0000000188D00868
		public void SetGlobalEnvRef(ref GlobalEnv envRef); // 0x00000001855D8A60-0x00000001855D8A70
		public void SetSharedExtData(IntPtr data); // 0x00000001855D8A50-0x00000001855D8A60
	}

	[BurstCompile]
	public struct WireRenderJob : IJobParallelForBatch // TypeDefIndex: 79880
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public IntPtr dataMatrices; // 0x00
		public EntityManager em; // 0x08
		public NativeArray<Entity> rendererEntities; // 0x18
	
		// Methods
		public void Execute(int index); // 0x0000000188D008B4-0x0000000188D00988
		private void _UpdateCachedWire(Entity cachedEntity, WireRendererInfo arg); // 0x0000000188D00988-0x0000000188D00AF0
		public void Execute(int startIndex, int count); // 0x0000000188D00868-0x0000000188D008B4
	}

	public struct FactoryBuildingEffectData : IEventData // TypeDefIndex: 79881
	{
		// Fields
		public Entity buildingLogicEntity; // 0x00
		public AdditiveEffectFragment.AdditiveEffectType effectType; // 0x08
	}

	public struct FPtrNativeCurve // TypeDefIndex: 79882
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe float* m_values; // 0x00
		private int m_valuesLength; // 0x08
		private UnityEngine.WrapMode m_preWrapMode; // 0x0C
		private UnityEngine.WrapMode m_postWrapMode; // 0x10
	
		// Methods
		public bool IsValid(); // 0x00000001853CC6D0-0x00000001853CC6E0
		public NativeArray<float> CreateCurve(AnimationCurve curve, int resolution); // 0x00000001865CE770-0x00000001865CE9A0
		public float Evaluate(float t); // 0x000000018783EDD8-0x000000018783EF34
		private float _Repeat(float t, float length); // 0x000000018783DA84-0x000000018783DAD0
		private float _Pingpong(float t, float length); // 0x000000018783EF34-0x000000018783EF68
	}

	public static class StringIntern // TypeDefIndex: 79885
	{
		// Nested types
		[IsReadOnly]
		public struct FastId : IEquatable<FastId> // TypeDefIndex: 79883
		{
			// Fields
			public readonly int id; // 0x00
			public static readonly FastId INVALID; // 0x00
	
			// Properties
			public bool isValid { get; } // 0x0000000188A26D34-0x0000000188A26D3C 
	
			// Constructors
			public FastId(int value); // 0x0000000184547F40-0x0000000184547F50
			static FastId(); // 0x00000001872207F0-0x0000000187220830
	
			// Methods
			public static implicit operator FastId(int value); // 0x0000000187235A70-0x0000000187235A80
			public static implicit operator int(FastId fastId); // 0x0000000187235A70-0x0000000187235A80
			public bool Equals(FastId other); // 0x0000000184FF20D0-0x0000000184FF20E0
			public override bool Equals(object obj); // 0x0000000188CF833C-0x0000000188CF83A4
			public override int GetHashCode(); // 0x00000001844AD290-0x00000001844AD2A0
		}
	
		private static class StringTable // TypeDefIndex: 79884
		{
			// Fields
			private const int INITIAL_SIZE = 512; // Metadata: 0x0263BAD6
			private static readonly Dictionary<string, int> STR_TO_INDEX; // 0x00
			private static readonly Dictionary<int, string> INDEX_TO_STR; // 0x08
			private static int s_nextId; // 0x10
	
			// Constructors
			static StringTable(); // 0x00000001856B1040-0x00000001856B1150
	
			// Methods
			internal static int GetOrAddIndex(string s); // 0x00000001857A7460-0x00000001857A75F0
			internal static bool TryGetIndex(string s, out int id); // 0x0000000188CFF6E4-0x0000000188CFF760
			internal static string IndexToString(int id); // 0x000000018519B470-0x000000018519B5D0
		}
	
		// Methods
		public static FastId StringToIndex(string key); // 0x0000000188CFF5D0-0x0000000188CFF650
		public static bool TryGetIndex(string key, out FastId id); // 0x0000000188CFF650-0x0000000188CFF6E4
		public static string IndexToString(FastId id); // 0x0000000188CFF588-0x0000000188CFF5D0
	}

	public static class IndexHashMap<T> // TypeDefIndex: 79888
		where T : struct
	{
		// Fields
		private static readonly SharedStatic<Holder> HOLDER;
	
		// Properties
		private static ref Holder H { get; }
		public static int count { get; }
	
		// Nested types
		private struct Holder // TypeDefIndex: 79886
		{
			// Fields
			public NativeParallelHashMap<int, T> map;
		}
	
		private struct Context // TypeDefIndex: 79887
		{
		}
	
		// Constructors
		static IndexHashMap();
	
		// Methods
		public static void Initialize(int capacity, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0263BAD8 */);
		public static void Dispose();
		public static bool TryGetValue(string key, out ref T value);
		public static bool TryGetValue(StringIntern.FastId keyId, out ref T value);
		public static void Add(string key, T value);
		public static void Add(StringIntern.FastId keyId, T value);
		public static bool ContainsKey(string key);
		public static bool ContainsKey(StringIntern.FastId keyId);
		public static bool Remove(string key);
		public static bool Remove(StringIntern.FastId keyId);
		public static void Clear();
		public static string KeyIndexToString(StringIntern.FastId keyId);
	}

	public struct OctAABB // TypeDefIndex: 79889
	{
		// Fields
		public float3 center; // 0x00
		public float3 extents; // 0x0C
	
		// Constructors
		public OctAABB(float3 center, float3 size); // 0x0000000185141470-0x00000001851414D0
	
		// Methods
		public bool Intersects([IsReadOnly] in OctAABB other); // 0x0000000185210820-0x0000000185210900
		public bool Contains(float3 p); // 0x0000000185210900-0x00000001852109A0
	}

	public struct NativeOctNode // TypeDefIndex: 79890
	{
		// Fields
		public OctAABB bounds; // 0x00
		public int childBase; // 0x18
		public int pointStart; // 0x1C
		public int pointEnd; // 0x20
	}

	public struct NativeOctData<T> // TypeDefIndex: 79891
		where T : struct
	{
		// Fields
		public float3 pos;
		public T data;
	}

	public struct NativeOctree<T> : IDisposable // TypeDefIndex: 79892
		where T : struct
	{
		// Fields
		private NativeList<NativeOctNode> m_nodes;
		private NativeList<NativeOctData<T>> m_datas;
		private OctAABB m_rootBounds;
		private int m_maxDepth;
		private int m_maxCap;
		private bool m_created;
	
		// Properties
		public bool isCreated { get; }
		public int nodeCount { get; }
		public int dataCount { get; }
	
		// Constructors
		public NativeOctree([IsReadOnly] in OctAABB rootBounds, int maxDepth, int maxCap, Unity.Collections.Allocator allocator);
	
		// Methods
		public NativeArray<NativeOctNode> AsNodes();
		public NativeArray<NativeOctData<T>> AsDatas();
		public void Build([IsReadOnly] in NativeArray<NativeOctData<T>> src, int srcCount);
		public void Build([IsReadOnly] in NativeList<NativeOctData<T>> src);
		public void Query([IsReadOnly] in OctAABB range, ref NativeList<T> result);
		public void QueryWithPos([IsReadOnly] in OctAABB range, ref NativeList<NativeOctData<T>> result);
		public bool Has([IsReadOnly] in OctAABB range);
		public int Count([IsReadOnly] in OctAABB range);
		public void Dispose();
		private void _BuildInto(int nodeIndex, [IsReadOnly] in OctAABB bounds, [IsReadOnly] in NativeArray<NativeOctData<T>> src, NativeList<int> ptIdx, int depth);
		private static OctAABB _ChildBounds([IsReadOnly] in OctAABB b, int k);
	}

	[BurstCompile]
	public static class NativeOctreeQuery // TypeDefIndex: 79893
	{
		// Fields
		private const int STACK_CAP = 256; // Metadata: 0x0263BAD9
	
		// Methods
		[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
		public static void QueryRange<T>([IsReadOnly] in NativeArray<NativeOctNode> nodes, [IsReadOnly] in NativeArray<NativeOctData<T>> datas, [IsReadOnly] in OctAABB range, ref NativeList<T> result)
			where T : struct;
		[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
		public static void QueryRangeWithPos<T>([IsReadOnly] in NativeArray<NativeOctNode> nodes, [IsReadOnly] in NativeArray<NativeOctData<T>> datas, [IsReadOnly] in OctAABB range, ref NativeList<NativeOctData<T>> result)
			where T : struct;
		[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
		public static bool HasRange<T>([IsReadOnly] in NativeArray<NativeOctNode> nodes, [IsReadOnly] in NativeArray<NativeOctData<T>> datas, [IsReadOnly] in OctAABB range)
			where T : struct;
		[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
		public static int CountRange<T>([IsReadOnly] in NativeArray<NativeOctNode> nodes, [IsReadOnly] in NativeArray<NativeOctData<T>> datas, [IsReadOnly] in OctAABB range)
			where T : struct;
	}

	[BurstCompile]
	public struct OctreeBatchQueryJob<T> : IJobParallelFor // TypeDefIndex: 79894
		where T : struct
	{
		// Fields
		private const int STACK_CAP = 256; // Metadata: 0x0263BADB
		[ReadOnly]
		public NativeArray<OctAABB> queryRanges;
		[ReadOnly]
		public NativeArray<NativeOctNode> nodes;
		[ReadOnly]
		public NativeArray<NativeOctData<T>> datas;
		public NativeStream.Writer resultWriter;
	
		// Methods
		public void Execute(int index);
	}

	[BurstCompile]
	public struct OctreeBatchHasJob<T> : IJobParallelFor // TypeDefIndex: 79895
		where T : struct
	{
		// Fields
		[ReadOnly]
		public NativeArray<OctAABB> queryRanges;
		[ReadOnly]
		public NativeArray<NativeOctNode> nodes;
		[ReadOnly]
		public NativeArray<NativeOctData<T>> datas;
		[NativeDisableParallelForRestriction]
		public NativeArray<bool> results;
	
		// Methods
		public void Execute(int index);
	}

	[BurstCompile]
	public struct OctreeBatchCountJob<T> : IJobParallelFor // TypeDefIndex: 79896
		where T : struct
	{
		// Fields
		[ReadOnly]
		public NativeArray<OctAABB> queryRanges;
		[ReadOnly]
		public NativeArray<NativeOctNode> nodes;
		[ReadOnly]
		public NativeArray<NativeOctData<T>> datas;
		[NativeDisableParallelForRestriction]
		public NativeArray<int> results;
	
		// Methods
		public void Execute(int index);
	}

	[Serializable]
	public struct PerDrawConfigArray // TypeDefIndex: 79897
	{
		// Fields
		public const int MAX_COUNT = 10; // Metadata: 0x0263BADD
		public PerDrawConfig[] perDrawConfigArray; // 0x00
		public PerDrawPassConfig[] passConfigArray; // 0x08
	}

	[Serializable]
	public struct PerDrawPassConfig // TypeDefIndex: 79898
	{
		// Fields
		public bool enable; // 0x00
		[HideInInspector]
		public uint lightModeRaw; // 0x01
	
		// Properties
		public PerDrawLightMode lightMode { get; set; } // 0x000000018723B0F0-0x000000018723B100 0x000000018723B100-0x000000018723B110
	
		// Methods
		public int Size(); // 0x000000018723A490-0x000000018723A4A0
		public void Apply(Entity rendererEntity, ref uint currentLightMode); // 0x0000000188CFA448-0x0000000188CFA498
		public void Apply(HGFactoryRendererBinderComponent binder, ref uint currentLightMode); // 0x0000000188CFA498-0x0000000188CFA4A4
		private HGShaderLightMode _ParseToHGShaderLightMode(PerDrawLightMode value); // 0x0000000188CFA4A4-0x0000000188CFA628
	}

	[Serializable]
	public struct PerDrawConfig // TypeDefIndex: 79899
	{
		// Fields
		[FormerlySerializedAs("Offset")]
		public PerDrawOffset offset; // 0x00
		[HideInInspector]
		public int valueType; // 0x04
		[HideInInspector]
		public float4 valueRaw; // 0x08
		private float4 m_value0; // 0x18
		private float m_value1; // 0x28
		[ColorUsage(true, false)]
		private UnityEngine.Color m_value2; // 0x2C
	
		// Methods
		public static int Size(); // 0x000000018723A010-0x000000018723A020
		public void OnValidate(); // 0x00000001854FBF40-0x00000001854FBF70
		private void _OnPerDrawTypeChanged(); // 0x00000001854FBAE0-0x00000001854FBB80
		private void _OnColorChanged(UnityEngine.Color c); // 0x000000018723B090-0x000000018723B0B0
		private void _OnFloat4Changed(float4 f); // 0x000000018723B0B0-0x000000018723B0C0
		private void _OnFloatChanged(float f); // 0x000000018723B0C0-0x000000018723B0F0
		public void Apply(HGFactoryRendererBinderComponent binder); // 0x0000000188CFA3F0-0x0000000188CFA448
	}

	public enum LogicEntityState // TypeDefIndex: 79900
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
		RIFT_AREA = 18,
		MAX = 19
	}

	public class PerDrawDataOffsetAttribute : Attribute // TypeDefIndex: 79901
	{
		// Fields
		public System.Type type; // 0x10
		public int typeValue; // 0x18
	
		// Constructors
		public PerDrawDataOffsetAttribute(System.Type type, int typeValue); // 0x00000001856B50C0-0x00000001856B50E0
	}

	public enum LogicEntityType // TypeDefIndex: 79902
	{
		CONVEYOR = 0,
		PIPE = 1,
		BUILDING = 2,
		INDICATOR = 3,
		GRID = 4,
		MAX = 5
	}

	public enum PerDrawOffset // TypeDefIndex: 79903
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

	[Flags]
	public enum PerDrawLightMode : uint // TypeDefIndex: 79904
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

	public static class PerDrawDataOffset // TypeDefIndex: 79905
	{
		// Fields
		public const int BASE_COLOR = 0; // Metadata: 0x0263BB40
		public const int EMISSIVE_COLOR = 16; // Metadata: 0x0263BB41
		public const int SOCIAL_SIGN_ICON_INDEX = 60; // Metadata: 0x0263BB42
		public const int CUTOFF_POS_Y = 32; // Metadata: 0x0263BB43
		public const int EMISSIVE_LUT_INDEX = 36; // Metadata: 0x0263BB44
		public const int SNOW_THICKNESS = 36; // Metadata: 0x0263BB45
		public const int EMISSIVE_LUT_BIT_MASK = 40; // Metadata: 0x0263BB46
		public const int LIQUID_HEIGHT_INDEX = 44; // Metadata: 0x0263BB47
		public const int FACTORY_COLOR_TYPE = 48; // Metadata: 0x0263BB48
		public const int ENABLE_CUTOFF = 52; // Metadata: 0x0263BB49
		public const int EMISSIVE_ANIMATION_MODE = 56; // Metadata: 0x0263BB4A
		public const int LIQUID_COLOR_INDEX = 60; // Metadata: 0x0263BB4B
		public const int UI_ATLAS_UV = 0; // Metadata: 0x0263BB4C
		public const int UI_LIQUID_ATLAS_UV = 16; // Metadata: 0x0263BB4D
		public const int ENABLE_LIQUID_ICON = 68; // Metadata: 0x0263BB4E
		public const int RARITY_COLOR = 48; // Metadata: 0x0263BB50
		public const int TINT_COLOR = 32; // Metadata: 0x0263BB51
		public const int INDICATOR_DATA = 64; // Metadata: 0x0263BB52
		public const int DISABLE_ICON_DEPTH_BLEND = 72; // Metadata: 0x0263BB54
		public const int GRID_MODE = 16; // Metadata: 0x0263BB56
		public const int RENDER_ON_WATER = 20; // Metadata: 0x0263BB57
		public const int OVERLOOK = 44; // Metadata: 0x0263BB58
		public const int ARROW_STEP_COUNT = 8; // Metadata: 0x0263BB59
		public const int SIMPLE_DRAWING_TYPE = 12; // Metadata: 0x0263BB5A
		public const int TIME_OFFSET = 0; // Metadata: 0x0263BB5B
		public const int ARROW_UV_SPEED = 4; // Metadata: 0x0263BB5C
		public const int ENABLE_CONVEYOR_INDICATOR = 12; // Metadata: 0x0263BB5D
		public const int ARROW_DATA = 16; // Metadata: 0x0263BB5E
		public const int BELT_COLOR = 32; // Metadata: 0x0263BB5F
		public const int FLOW_INTENSITY = 48; // Metadata: 0x0263BB60
		public const int BELT_COLOR_INTENSITY = 52; // Metadata: 0x0263BB61
		public const int BELT_COLOR_ALPHA = 56; // Metadata: 0x0263BB62
		public const int ELECTRIC_WIRE_ALPHA = 12; // Metadata: 0x0263BB63
		public const int VFX_TINT_COLOR_ALPHA = 44; // Metadata: 0x0263BB64
		public const int ELECTRIC_WIRE_LENGTH = 56; // Metadata: 0x0263BB65
		public const int WATER_THICKNESS = 0; // Metadata: 0x0263BB66
		public const int WATER_DELTA_TIME = 4; // Metadata: 0x0263BB67
		public const int TUBE_INDEX = 8; // Metadata: 0x0263BB68
		public const int TUBE_COUNT = 12; // Metadata: 0x0263BB69
		public const int WATER_DIRECTION = 16; // Metadata: 0x0263BB6A
		public const int ENABLE_OVERLOOK_ARROW = 20; // Metadata: 0x0263BB6B
		public const int TUBE_BEND_X_DEGREE = 24; // Metadata: 0x0263BB6C
		public const int TUBE_BEND_TAG = 28; // Metadata: 0x0263BB6D
		public const int GLASS_COLOR = 32; // Metadata: 0x0263BB6E
		public const int ATLAS_UV_INDEX = 48; // Metadata: 0x0263BB6F
		public const int ENABLE_TUBE_INDICATOR = 52; // Metadata: 0x0263BB70
		public const int FIRST_INDEX = 56; // Metadata: 0x0263BB71
		public const int FIELD_INDEX_COL = 36; // Metadata: 0x0263BB72
		public const int DITHER_TRANSPARENT_ALPHA = 64; // Metadata: 0x0263BB73
		public const int BLUEPRINT_NOISE_ALPHA = 68; // Metadata: 0x0263BB75
		public const int FACTORY_VAT_FRAME = 72; // Metadata: 0x0263BB77
		public const int FACTORY_VAT_LAST_FRAME = 76; // Metadata: 0x0263BB79
	}

	public class ProcessorInterval // TypeDefIndex: 79906
	{
		// Constructors
		public ProcessorInterval(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static bool CheckInterval(ref IProcessor processor, float delta = 1f /* Metadata: 0x0263BB7B */, float rate = 1f /* Metadata: 0x0263BB7F */); // 0x00000001856209B0-0x0000000185620B90
		private static bool _CheckInterval(float frameInterval, float intervalSetting, out float curInterval, float delta = 1f /* Metadata: 0x0263BB83 */, float rate = 1f /* Metadata: 0x0263BB87 */); // 0x0000000185620B90-0x0000000185620BC0
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public class CargoPredictProcessor : BaseProcessor // TypeDefIndex: 79907
	{
		// Properties
		public override bool lowFrameEnable { get; } // 0x00000001851A4410-0x00000001851A4420 
		public override string name { get; } // 0x0000000188CF7558-0x0000000188CF7584 
	
		// Constructors
		public CargoPredictProcessor(); // 0x000000018723A910-0x000000018723A920
	
		// Methods
		public override JobHandle Execute(ref EntityManager em, long time, long dt, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies); // 0x000000018561BB50-0x000000018561BE30
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public class CrossFrameProcessor : BaseProcessor // TypeDefIndex: 79908
	{
		// Fields
		private InteractFacCollectJob.BuildingInfo m_nearBuildingInfo; // 0x20
		private InteractFacCollectJob.LogisticInfo m_nearConveyorInfo; // 0x78
		private InteractFacCollectJob.LogisticInfo m_nearPipeInfo; // 0x9C
		private InteractFacCollectJob.BuildingInfo m_nearBuildingInfoLast; // 0xC0
		private InteractFacCollectJob.LogisticInfo m_nearConveyorInfoLast; // 0x118
		private InteractFacCollectJob.LogisticInfo m_nearPipeInfoLast; // 0x13C
		private const float MAX_BUILDING_INTERACT_RADIUS = 1.5f; // Metadata: 0x0263BB8B
		private const float BUILDING_INTERACT_RADIUS_EXPAND = 0.6f; // Metadata: 0x0263BB8F
	
		// Properties
		public override string name { get; } // 0x0000000188CF75C8-0x0000000188CF75F4 
		public override bool lowFrameEnable { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public CrossFrameProcessor(); // 0x000000018723A910-0x000000018723A920
	
		// Methods
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting); // 0x00000001871E40B0-0x00000001871E4120
		public override JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle); // 0x000000018515F3C0-0x00000001851603B0
		public override void TearDown(ref EntityManager em, ref GlobalEnv env); // 0x0000000188CF7584-0x0000000188CF75C8
	}

	public abstract class EntityDestroyReactiveProcessor<T> : ReactiveProcessor<T> // TypeDefIndex: 79909
		where T : struct, IReactiveComponent, IComponentECS
	{
		// Fields
		private NativeList<Entity> m_removedEntities;
	
		// Constructors
		protected EntityDestroyReactiveProcessor();
	
		// Methods
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting);
		public override void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null);
		public override void TearDown(ref EntityManager em, ref GlobalEnv env);
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public class FacRendererCollectProcessor : BaseProcessor // TypeDefIndex: 79910
	{
		// Fields
		private const float CONVEYOR_FRUSTUM_PADDING = 2f; // Metadata: 0x0263BB93
		public static bool s_statusRenderEnabled; // 0x00
		public static bool s_portStatusRenderEnabled; // 0x01
		public static bool s_frustumFilterEnabled; // 0x02
		private float m_conveyorOffsetY; // 0x20
		private float m_conveyorPortBlockOffsetY; // 0x24
		private float m_pipePortBlockOffsetY; // 0x28
		private readonly Plane[] m_frustumPlanes; // 0x30
		private float4 m_portForbiddenColor; // 0x38
		private float4 m_portEvaluatedColor; // 0x48
		private float4 m_portNormalColor; // 0x58
		private unsafe UnsafeList<float4x4>* m_portBlockPosList; // 0x68
		private unsafe UnsafeList<OutputRendererInfo>* m_outputPosList; // 0x70
		private unsafe UnsafeList<EnvGeneratorRendererInfo>* m_envGeneratorPosList; // 0x78
		private unsafe UnsafeList<float4x4>* m_buildingStatePosList; // 0x80
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorLPosList0; // 0x88
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorMPosList0; // 0x90
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorRPosList0; // 0x98
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorLPosList1; // 0xA0
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorMPosList1; // 0xA8
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorRPosList1; // 0xB0
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorPreviewLPosList0; // 0xB8
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorPreviewMPosList0; // 0xC0
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorPreviewRPosList0; // 0xC8
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorPreviewLPosList1; // 0xD0
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorPreviewMPosList1; // 0xD8
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorPreviewRPosList1; // 0xE0
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorGuideLPosList0; // 0xE8
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorGuideMPosList0; // 0xF0
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorGuideRPosList0; // 0xF8
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorGuideLPosList1; // 0x100
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorGuideMPosList1; // 0x108
		private unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* m_conveyorGuideRPosList1; // 0x110
		private unsafe CargoRendererInfoCollection<CargoRendererInfo>* m_cargoList0; // 0x118
		private unsafe CargoRendererInfoCollection<CargoRendererInfo>* m_cargoList1; // 0x120
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_pipeLPosList0; // 0x128
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_pipeMPosList0; // 0x130
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_pipeRPosList0; // 0x138
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_pipeLPosList1; // 0x140
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_pipeMPosList1; // 0x148
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_pipeRPosList1; // 0x150
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_pipeSplashPosList0; // 0x158
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_pipeSplashPosList1; // 0x160
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_gasPipeLPosList0; // 0x168
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_gasPipeMPosList0; // 0x170
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_gasPipeRPosList0; // 0x178
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_gasPipeLPosList1; // 0x180
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_gasPipeMPosList1; // 0x188
		private unsafe PipeRendererInfoCollection<PipeRendererInfo>* m_gasPipeRPosList1; // 0x190
		private unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* m_trackLPosList0; // 0x198
		private unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* m_trackMPosList0; // 0x1A0
		private unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* m_trackRPosList0; // 0x1A8
		private unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* m_trackLPosList1; // 0x1B0
		private unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* m_trackMPosList1; // 0x1B8
		private unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* m_trackRPosList1; // 0x1C0
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireNormalList0; // 0x1C8
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireNormalList1; // 0x1D0
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireHsNormalList0; // 0x1D8
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireHsNormalList1; // 0x1E0
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireDisableList0; // 0x1E8
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireDisableList1; // 0x1F0
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireStrengthenList0; // 0x1F8
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireStrengthenList1; // 0x200
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireHsStrengthenList0; // 0x208
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireHsStrengthenList1; // 0x210
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireStrengthenDisableList0; // 0x218
		private unsafe WireRendererInfoCollection<WireRendererInfo>* m_wireStrengthenDisableList1; // 0x220
		private unsafe UnsafeList<Matrix4x4>* m_pipeHolderPosList; // 0x228
		private unsafe UnsafeList<Matrix4x4>* m_conveyorLogPosList; // 0x230
		private unsafe UnsafeList<float4x4>* m_comPosList; // 0x238
		private unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* m_portArrowList0; // 0x240
		private unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* m_portArrowList1; // 0x248
		private unsafe UnsafeList<float4x4>* m_conveyorInsideMatrices; // 0x250
		private FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> m_facRegionPosValidFuncPtr; // 0x258
		public FunctionPointer<UnsafeJobFuncPointers.QueryStateIconPath> queryStateIconPathFuncPtr; // 0x260
		private int m_lowFrameInterval; // 0x268
		private Unity.Collections.Allocator m_defaultAllocator; // 0x26C
		private const float PIPE_FRUSTUM_PADDING = 2f; // Metadata: 0x0263BB97
		private const int ARROW_PLACED_DIC_CAPACITY = 4096; // Metadata: 0x0263BB9B
		private UnsafeParallelHashMap<int, bool> m_arrowPlacedDic; // 0x270
	
		// Properties
		public override string name { get; } // 0x0000000188CF81B8-0x0000000188CF81E4 
	
		// Constructors
		public FacRendererCollectProcessor(); // 0x00000001871EDE00-0x00000001871EDE70
		static FacRendererCollectProcessor(); // 0x00000001871F06B0-0x00000001871F0710
	
		// Methods
		private JobHandle _CollectConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorCollectJobHandle, [IsReadOnly] in Beyond.Gameplay.Factory.FrustumPlanes frustum); // 0x0000000185D4B8D0-0x0000000185D4BC90
		private JobHandle _CollectPreviewConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorPreviewCollectJobHandle); // 0x0000000185F30410-0x0000000185F306B0
		private JobHandle _CollectGuideConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorCollectJobHandle, [IsReadOnly] in Beyond.Gameplay.Factory.FrustumPlanes frustum); // 0x0000000185D4BC90-0x0000000185D4C050
		private JobHandle _CollectConveyorLogistics(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle collectJobHandle); // 0x00000001861DD330-0x00000001861DD3A0
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting); // 0x0000000185D61FB0-0x0000000185D62250
		private void _CreateAllocator(ref GlobalEnv env); // 0x000000018783A584-0x000000018783A5A8
		private void _CreateCurrent(ref GlobalEnv env); // 0x0000000185D61660-0x0000000185D61FB0
		private JobHandle _CollectPortState(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portCollectJobHandle, [IsReadOnly] in Beyond.Gameplay.Factory.FrustumPlanes frustum); // 0x0000000185D490B0-0x0000000185D494D0
		private JobHandle _CollectBuildingState(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle buildingStateCollectJobHandle, [IsReadOnly] in Beyond.Gameplay.Factory.FrustumPlanes frustum); // 0x0000000185D494D0-0x0000000185D49920
		private Beyond.Gameplay.Factory.FrustumPlanes _GetFactoryFrustumPlanes(); // 0x000000018515A090-0x000000018515A220
		private JobHandle _CollectCargo(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle cargoCollectJobHandle, [IsReadOnly] in Beyond.Gameplay.Factory.FrustumPlanes frustum); // 0x000000018515CEA0-0x000000018515D250
		private JobHandle _CollectWire(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle wireCollectJobHandle); // 0x00000001855D84F0-0x00000001855D8A30
		public override JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle); // 0x000000018515B260-0x000000018515CEA0
		private static unsafe void _DestroyUnsafeList<T>(ref UnsafeList<T>* owner, ref UnsafeList<T>* published)
			where T : struct;
		public override void TearDown(ref EntityManager em, ref GlobalEnv env); // 0x0000000188CF75F4-0x0000000188CF7BC8
		private JobHandle _CollectEnvGenerator(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle envGeneratorCollectJobHandle, [IsReadOnly] in Beyond.Gameplay.Factory.FrustumPlanes frustum); // 0x0000000185E702A0-0x0000000185E70680
		private JobHandle _CollectOutput(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle outputCollectJobHandle, [IsReadOnly] in Beyond.Gameplay.Factory.FrustumPlanes frustum); // 0x0000000185E6FEC0-0x0000000185E702A0
		private JobHandle _CollectPipe(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle pipeCollectJobHandle, [IsReadOnly] in Beyond.Gameplay.Factory.FrustumPlanes frustum); // 0x000000018515D250-0x000000018515D860
		private JobHandle _CollectPipeLogistics(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle pipeHolderCollectJobHandle); // 0x00000001861DD2C0-0x00000001861DD330
		private void _InitArrowPlaced(ref GlobalEnv env); // 0x0000000185D61580-0x0000000185D61600
		private JobHandle _CollectPortArrow(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portArrowCollectJobHandle, [IsReadOnly] in Beyond.Gameplay.Factory.FrustumPlanes frustum); // 0x000000018515D860-0x000000018515E090
		private JobHandle _CollectPortArrowWithDiff(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portArrowCollectJobHandle, [IsReadOnly] in Beyond.Gameplay.Factory.FrustumPlanes frustum); // 0x0000000188CF7BC8-0x0000000188CF81B8
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public abstract class ReactiveProcessor<T> : BaseProcessor // TypeDefIndex: 79911
		where T : struct, IReactiveComponent, IComponentECS
	{
		// Fields
		[CompilerGenerated]
		private readonly string _name_k__BackingField;
	
		// Properties
		public override string name { [CompilerGenerated] get; }
	
		// Constructors
		protected ReactiveProcessor();
	
		// Methods
		public override JobHandle PreExecute(ref EntityManager em, long time, long dt, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies);
		public override JobHandle Execute(ref EntityManager em, long time, long dt, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies);
		protected virtual void Perform(ref EntityManager em, ref EntityCommandBufferV2.EntityCommandBufferParallelWriter ecb, [IsReadOnly] in ECSSpan<T> dataSpans, ref GlobalEnv env, GroupType group, long time);
		protected virtual bool CleanUpEntityFilter(ref EntityManager em, Entity entity);
		public override void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null);
		public override void TearDown(ref EntityManager em, ref GlobalEnv env);
	}

	public class AdditiveMaterialBitIndex // TypeDefIndex: 79912
	{
		// Fields
		public static readonly int PREVIEW; // 0x00
		public static readonly int HIGHLIGHT; // 0x04
		public static readonly int BORDER; // 0x08
		public static readonly int OUTLINE; // 0x0C
		public static readonly int CUTOFF; // 0x10
		public static readonly int PRECESS; // 0x14
		public static readonly int REPAIR1; // 0x18
		public static readonly int REPAIR2; // 0x1C
		public static readonly int REPAIR3; // 0x20
		public static readonly int OVERLOAD; // 0x24
		public static readonly int BLUEPRINT_BUILD; // 0x28
		public static readonly int BLUEPRINT_MOVE; // 0x2C
		public static readonly int BLUEPRINT_BUILD_OUTLINE; // 0x30
		public static readonly int BLUEPRINT_MOVE_OUTLINE; // 0x34
		public static readonly int PRESELECT_PREVIEW; // 0x38
		public static readonly int SOCIAL_SHARING; // 0x3C
		public static readonly int POWER_INTERACTION; // 0x40
		public static readonly int SNOW_COVERAGE; // 0x44
		public static readonly int MAX; // 0x48
	
		// Constructors
		public AdditiveMaterialBitIndex(); // 0x0000000186805BA0-0x0000000186805BB0
		static AdditiveMaterialBitIndex(); // 0x0000000188CF71E0-0x0000000188CF7394
	}

	public class FactoryBaseColorLutConfig : ScriptableObject // TypeDefIndex: 79913
	{
		// Fields
		public SerializeFieldDictionary<FacBuildingBaseBuffer, UnityEngine.Color> factoryBuildingBaseStateConfig; // 0x18
		public SerializeFieldDictionary<string, int> factoryBuildingCrafterData; // 0x20
		public int factoryBuildingCount; // 0x28
	
		// Constructors
		public FactoryBaseColorLutConfig(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public bool GetColor(int sort, out UnityEngine.Color col); // 0x0000000188CF82D8-0x0000000188CF833C
		public bool GetIndex(string key, out int index); // 0x00000001865F0D00-0x00000001865F0D30
		public static FactoryBaseColorLutConfig CreateOrGet(string path); // 0x0000000188CF81E4-0x0000000188CF82D8
	}

	public enum FacBuildingBaseBuffer // TypeDefIndex: 79914
	{
		InputBuffer1 = 0,
		InputBuffer2 = 1,
		InputBuffer3 = 2,
		OutputBuffer1 = 3,
		OutputBuffer2 = 4,
		OutputBuffer3 = 5
	}

	[Serializable]
	public struct FFactoryStateColorConfig // TypeDefIndex: 79916
	{
		// Fields
		public SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryStateIconColorConfig; // 0x00
		public SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryIndicatorColorConfig; // 0x08
		public SerializeFieldDictionary<FacBuildingState, string> factoryUIEffectConfig; // 0x10
		public SerializeFieldDictionary<LogicEntityState, SerializeFieldDictionary<LogicEntityType, PerDrawConfigArray>> factoryLogicEntityColorConfig2; // 0x18
	
		// Nested types
		[Serializable]
		public struct LogicStateConfig // TypeDefIndex: 79915
		{
			// Fields
			public UnityEngine.Color color; // 0x00
			public float intensity; // 0x10
			public float alpha; // 0x14
			public float flowAlpha; // 0x18
			[ColorUsage(true, true)]
			public UnityEngine.Color c; // 0x1C
	
			// Methods
			private void _OnColorChanged(); // 0x000000018723B1A0-0x000000018723B1F0
		}
	
		// Methods
		public bool GetStateColor(FacBuildingState enumKey, out UnityEngine.Color col); // 0x0000000185D62E00-0x0000000185D62E70
		public bool GetIndicatorColor(FacBuildingState enumKey, out UnityEngine.Color col); // 0x0000000188D05354-0x0000000188D053B8
		public bool GetStateName(FacBuildingState enumKey, out string name); // 0x0000000188D053B8-0x0000000188D0541C
		public bool GetPerDrawList(LogicEntityState entityState, LogicEntityType entityType, out PerDrawConfigArray perDrawList); // 0x00000001865EE370-0x00000001865EE430
		public void OnEnable(); // 0x00000001854FBB80-0x00000001854FBF40
	}
}

namespace Beyond.Gameplay.Factory.ECSVATFSM
{
	[BurstCompatible]
	[ECSComponent]
	public struct VATFSMStateFragment : IComponentECS // TypeDefIndex: 79917
	{
		// Fields
		public byte activeClipSlot; // 0x00
		public FSMState currentState; // 0x04
		public FSMState nextState; // 0x20
		public FSMParameterSet parameters; // 0x3C
		public FSMTransition transition; // 0x60
		public float speed; // 0x6C
		public uint definitionHandle; // 0x70
		public uint binderSharedDataIndex; // 0x74
		public bool isTransitioning; // 0x78
		public bool isPause; // 0x79
		public bool audioEnabled; // 0x7A
		public const int ID = 61; // Metadata: 0x0263BBA3
	
		// Properties
		public ref VATFSMDefinition def { get; } // 0x000000018723B210-0x000000018723B230 
		public int id { get; } // 0x000000018723B230-0x000000018723B240 
	
		// Methods
		public ref FSMStateDefinition GetCurrentStateDefinition(); // 0x0000000188D09494-0x0000000188D094B8
		public ref FSMStateDefinition GetCurrentStateDefinitionUnsafe(ref VATFSMDefinition definition); // 0x000000018783A2F8-0x000000018783A310
		public ref FSMClipDefinition GetCurrentClipDefinition(); // 0x0000000185D30670-0x0000000185D306A0
		public ref FSMClipDefinition GetCurrentClipDefinitionUnsafe(ref VATFSMDefinition definition); // 0x0000000185D32590-0x0000000185D32600
		public void SetActiveClipSlotUnsafe(byte clipSlot, ref VATFSMDefinition definition); // 0x0000000188D094B8-0x0000000188D094FC
		public void Init(uint defHandle, uint binderHandle); // 0x0000000185D306A0-0x0000000185D307D0
		public void SetStateUnsafe(ref FSMStateDefinition stateDef, ref VATFSMDefinition fsmDef); // 0x0000000185D32520-0x0000000185D32590
		public void SetState(ref FSMStateDefinition stateDef); // 0x0000000188D094FC-0x0000000188D09520
		public void ToNextState(); // 0x0000000188D095EC-0x0000000188D09634
		public void SetTransition([IsReadOnly] in FSMTransitionDefinition transDef, [IsReadOnly] in FSMStateDefinition nextStateDef); // 0x0000000188D09520-0x0000000188D095EC
		private void __AOT_FOR_FIX__(); // 0x0000000188D09634-0x0000000188D09720
	}

	public struct FSMState // TypeDefIndex: 79918
	{
		// Fields
		public const uint INVALID_PREV_FRAME = 4294967295; // Metadata: 0x0263BBA4
		public byte index; // 0x00
		public float duration; // 0x04
		public float speed; // 0x08
		public bool isLoop; // 0x0C
		public bool mvSettled; // 0x0D
		public uint prevFrame; // 0x10
		private float m_elapsedTime; // 0x14
		private bool m_isFinish; // 0x18
	
		// Properties
		public float process { get; } // 0x0000000185E69E90-0x0000000185E69ED0 
		public bool isFinished { get; } // 0x000000018225E050-0x000000018225E060 
	
		// Methods
		public void Enter(); // 0x000000018723B130-0x000000018723B150
		public void Update(float deltaTime, float fsmSpeed); // 0x0000000188D05804-0x0000000188D05830
		public void Exit(); // 0x0000000186805BA0-0x0000000186805BB0
		public void SetProgress(float normalized); // 0x0000000185D32500-0x0000000185D32520
		private void _InvalidateMotion(); // 0x000000018287CD40-0x000000018287CD50
	}

	public struct FSMTransition // TypeDefIndex: 79919
	{
		// Fields
		public float duration; // 0x00
		private float m_elapsedTime; // 0x04
		private bool m_isFinish; // 0x08
	
		// Properties
		public bool isFinished { get; } // 0x0000000188D05890-0x0000000188D05898 
		public float fromStateWeight { get; } // 0x0000000188D05850-0x0000000188D05890 
		public float toStateWeight { get; } // 0x0000000188D05898-0x0000000188D058B8 
	
		// Methods
		public void Enter(); // 0x000000018723B150-0x000000018723B160
		public void Update(float deltaTime, float fsmSpeed); // 0x0000000188D05830-0x0000000188D05850
		public void Exit(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public struct FSMParameterSet // TypeDefIndex: 79920
	{
		// Fields
		public FixedList32Bytes<float> floats; // 0x00
		public byte bools; // 0x20
		public byte triggers; // 0x21
	
		// Methods
		[IsReadOnly]
		public float GetFloat(byte index); // 0x0000000188D05560-0x0000000188D055BC
		public void SetFloat(byte index, float value); // 0x0000000188D056B4-0x0000000188D0570C
		[IsReadOnly]
		public int GetInt(byte index); // 0x0000000188D055BC-0x0000000188D05620
		public void SetInt(byte index, int value); // 0x0000000188D0570C-0x0000000188D05768
		[IsReadOnly]
		public bool GetBool(byte index); // 0x0000000188D05550-0x0000000188D05560
		public void SetBool(byte index, bool value); // 0x0000000188D0569C-0x0000000188D056B4
		[IsReadOnly]
		public bool GetTrigger(byte index); // 0x0000000188D05620-0x0000000188D05630
		public void SetTrigger(byte index); // 0x000000018723B120-0x000000018723B130
		public void ResetTrigger(byte index); // 0x000000018723B110-0x000000018723B120
		public void ResetAllTriggers(); // 0x0000000187233040-0x0000000187233050
		public void SetValue(byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type, float value); // 0x0000000188D05768-0x0000000188D05804
		[IsReadOnly]
		public float GetValue(byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type); // 0x0000000188D05630-0x0000000188D0569C
		public void ResetParametersByDef([IsReadOnly] in VATFSMDefinition def); // 0x0000000185D304A0-0x0000000185D305A0
	}

	[BurstCompile]
	public struct VATFSMSetParamRequestHandlerJob : IJobFor // TypeDefIndex: 79921
	{
		// Fields
		public EntityManager renderEm; // 0x00
		public NativeArray<VATFSMProcessor.SetAnimatorParamRequest> setParamRequestList; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public unsafe VATFSMDefinition* sharedDataPtr; // 0x20
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* envPtr; // 0x28
	
		// Methods
		public void Execute(int index); // 0x0000000188D09384-0x0000000188D09494
	}

	[BurstCompile]
	public struct VATFSMStateQueryJob : IJob // TypeDefIndex: 79922
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x18
	
		// Methods
		public void Execute(); // 0x0000000188D09720-0x0000000188D097C8
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x0263BBA5 */); // 0x000000018561B210-0x000000018561B250
	}

	[BurstCompile]
	public struct VATFSMStateUpdateJob : IJobParallelForDefer // TypeDefIndex: 79923
	{
		// Fields
		public float deltaTime; // 0x00
		public bool enableFactoryRayTracing; // 0x04
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe VATFSMDefinition* fsmDefinitionPtr; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x18
		public UnsafeList<VATFSMProcessor.VATFSMAudioData> animatorAudioQueue; // 0x20
		private const int S_CURRENT_FRAME_OFFSET = 72; // Metadata: 0x0263BBA7
		private const int S_PREVIOUS_FRAME_OFFSET = 76; // Metadata: 0x0263BBA9
		private const int S_VAT_CLIP_START_FRAME_OFFSET = 124; // Metadata: 0x0263BBAB
		private const int S_VAT_CLIP_TOTAL_FRAMES_OFFSET = 128; // Metadata: 0x0263BBAD
		private const int S_VAT_PROCESS_OFFSET = 132; // Metadata: 0x0263BBAF
		private const int S_VAT_SPEED_OFFSET = 136; // Metadata: 0x0263BBB1
	
		// Methods
		public void Execute(int index); // 0x0000000188D097C8-0x0000000188D09ADC
		private bool _CheckTransitions(ref VATFSMStateFragment fsm, ref VATFSMDefinition fsmDef); // 0x0000000188D09ADC-0x0000000188D09BB0
		private void _ComputeVATFrameData(ref VATFSMStateFragment fsm, ref VATFSMDefinition fsmDef); // 0x0000000188D09BB0-0x0000000188D09D7C
		public void SetSharedExtData(IntPtr data); // 0x000000018561CBD0-0x000000018561CBE0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x000000018561B590-0x000000018561B5A0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0263BBA6 */); // 0x000000018561E350-0x000000018561E500
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public class VATFSMProcessor : BaseProcessor // TypeDefIndex: 79927
	{
		// Fields
		private ProfilerMarker m_pRemoveDup; // 0x20
		private ProfilerMarker m_pHandleReq; // 0x28
		private ProfilerMarker m_pJobSchedule; // 0x30
		public NativeList<SetAnimatorParamRequest> animatorParamRequestQueue; // 0x38
		private NativeList<SetAnimatorParamRequest> m_waitForStateFinishRequests; // 0x48
		private NativeList<SetAnimatorParamRequest> m_readyWaitForStateFinishRequests; // 0x58
		private NativeParallelHashMap<Entity, int> m_requestMaskPerEntity; // 0x68
		private const int S_RESET_REQUEST_MASK = 64; // Metadata: 0x0263BBB3
		private const int S_INITIAL_ANIMATOR_AUDIO_QUEUE_CAPACITY = 512; // Metadata: 0x0263BBB5
	
		// Properties
		public override string name { get; } // 0x0000000188D09358-0x0000000188D09384 
		public unsafe VATFSMDefinition* fsmDefinitionPtr { get; } // 0x0000000187239F00-0x0000000187239F20 
	
		// Nested types
		public enum VATAnimatorRequestType : byte // TypeDefIndex: 79924
		{
			SetParameter = 1,
			PauseOrResume = 2,
			SetSpeed = 3,
			ForceSetState = 4,
			SetStateLoop = 5,
			Reset = 6,
			SetActiveClipSlot = 7
		}
	
		public struct SetAnimatorParamRequest // TypeDefIndex: 79925
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
			public byte activeClipSlot; // 0x18
	
			// Methods
			public unsafe void SetParamToAnimator(GlobalEnv* envPtr, ref VATFSMStateFragment fragment, VATFSMDefinition* sharedDataPtr); // 0x0000000185D32190-0x0000000185D32500
		}
	
		public struct VATFSMAudioData // TypeDefIndex: 79926
		{
			// Fields
			public Entity entity; // 0x00
			public int hashStateName; // 0x08
		}
	
		// Constructors
		public VATFSMProcessor(); // 0x000000018723A910-0x000000018723A920
	
		// Methods
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting); // 0x0000000186C7E690-0x0000000186C7E8E0
		public override JobHandle Execute(ref EntityManager em, long time, long deltaTime, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies); // 0x000000018561DC70-0x000000018561E030
		public override void TearDown(ref EntityManager em, ref GlobalEnv env); // 0x0000000188D09184-0x0000000188D092E0
		private JobHandle _HandleSetAnimatorParamRequest(ref EntityManager em, ref GlobalEnv env, JobHandle jobHandle); // 0x000000018561D3B0-0x000000018561D6E0
		private void _PrepareSetAnimatorParamRequests(ref EntityManager em); // 0x000000018561CBE0-0x000000018561CCA0
		private void _MoveUnfinishedNewRequestsToWaitQueue(ref EntityManager em); // 0x000000018561D6E0-0x000000018561DC70
		private void _DrainWaitForStateFinishRequests(ref EntityManager em, int waitQueueInputCount); // 0x000000018509CE80-0x000000018509D600
		private void _HandleReadyRequestList(ref EntityManager em, ref GlobalEnv env, ref NativeList<SetAnimatorParamRequest> copiedRequests, ref NativeList<SetAnimatorParamRequest> readyRequests, bool useJob); // 0x0000000185D31FE0-0x0000000185D32190
		private void _RemoveDuplicationRequest(ref EntityManager em); // 0x000000018561CCA0-0x000000018561D3B0
		private void _EnsureRequestMaskCapacity(int requestCount); // 0x000000018561C910-0x000000018561C9F0
		private bool _IsCoveredByCurrentFrameRequest([IsReadOnly] in SetAnimatorParamRequest request); // 0x000000018509D6B0-0x000000018509D8F0
		public static bool TryAddAnimatorAudio(UnsafeList<VATFSMAudioData> writer, VATFSMAudioData data); // 0x0000000188D092E0-0x0000000188D09358
	}

	[Serializable]
	public class ECSVATFSMDefinitionData // TypeDefIndex: 79929
	{
		// Fields
		public string fsmName; // 0x10
		public string defaultStateName; // 0x18
		public List<StateData> states; // 0x20
		public List<TransitionData> transitions; // 0x28
		public List<ParameterData> parameters; // 0x30
		public List<AnimationClipData> animationClips; // 0x38
		public VATClipSlotModeMapping[] modeClipSlotMappings; // 0x40
	
		// Nested types
		[Serializable]
		public struct VATClipSlotModeMapping // TypeDefIndex: 79928
		{
			// Fields
			public FCNodeMode mode; // 0x00
			public byte clipSlot; // 0x04
		}
	
		// Constructors
		public ECSVATFSMDefinitionData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class StateData // TypeDefIndex: 79930
	{
		// Fields
		public string name; // 0x10
		public float speed; // 0x18
		public string[] clipNames; // 0x20
	
		// Constructors
		public StateData(); // 0x000000018723A910-0x000000018723A920
	}

	public enum TransitionInterruptionSource // TypeDefIndex: 79931
	{
		None = 0,
		Source = 1,
		Destination = 2,
		SourceThenDestination = 3,
		DestinationThenSource = 4
	}

	[Serializable]
	public class TransitionData // TypeDefIndex: 79932
	{
		// Fields
		public string fromState; // 0x10
		public string toState; // 0x18
		public float exitTime; // 0x20
		public float duration; // 0x24
		public TransitionInterruptionSource interruptionSource; // 0x28
		public List<Beyond.Gameplay.Factory.ECSVATFSM.ConditionData> condition; // 0x30
	
		// Constructors
		public TransitionData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public enum AnimatorConditionMode // TypeDefIndex: 79933
	{
		If = 1,
		IfNot = 2,
		Greater = 3,
		Less = 4,
		Equals = 6,
		NotEqual = 7
	}

	[Serializable]
	public class ConditionData // TypeDefIndex: 79934
	{
		// Fields
		public string parameterName; // 0x10
		public AnimatorConditionMode comparison; // 0x18
		public float threshold; // 0x1C
	
		// Constructors
		public ConditionData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class ParameterData // TypeDefIndex: 79935
	{
		// Fields
		public string name; // 0x10
		public AnimatorControllerParameterType type; // 0x18
		public float defaultFloat; // 0x1C
		public int defaultInt; // 0x20
		public bool defaultBool; // 0x24
	
		// Constructors
		public ParameterData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class AnimationClipData // TypeDefIndex: 79936
	{
		// Fields
		public string name; // 0x10
		public bool isLoop; // 0x18
		public float length; // 0x1C
		public int startFrame; // 0x20
		public int totalFrames; // 0x24
	
		// Constructors
		public AnimationClipData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public string GetClipDesStr(); // 0x0000000188D01F70-0x0000000188D02130
	}

	public struct VATFSMDefinition // TypeDefIndex: 79937
	{
		// Fields
		public byte defaultStateIndex; // 0x00
		public byte defaultClipSlotIndex; // 0x01
		public FixedList32Bytes<FSMModeClipSlotDefinition> modeClipSlots; // 0x02
		public FixedList512Bytes<FSMStateDefinition> states; // 0x22
		public FSMTransitionDefinition20<FSMTransitionDefinition> transitions; // 0x224
		public FixedList128Bytes<FSMParameterDefinition> parameters; // 0xA2C
		public FixedList512Bytes<FSMClipDefinition> clips; // 0xAAC
	}

	public struct FSMModeClipSlotDefinition // TypeDefIndex: 79938
	{
		// Fields
		public byte modeRaw; // 0x00
		public byte clipSlot; // 0x01
	}

	public enum ConditionMode : byte // TypeDefIndex: 79939
	{
		If = 1,
		IfNot = 2,
		Greater = 3,
		Less = 4,
		Equals = 6,
		NotEqual = 7
	}

	public struct FSMCondition // TypeDefIndex: 79940
	{
		// Fields
		public byte parameterIndex; // 0x00
		public ConditionMode comparison; // 0x01
		public float threshold; // 0x04
	}

	[DataN(capacity = 20, tSize = 64, ring = false)]
	[NoAlias]
	public struct FSMTransitionDefinition20<T> : IEnumerable<T> // TypeDefIndex: 79943
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0263BBD1
		public const int CAPACITY = 32; // Metadata: 0x0263BBD3
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x0263BBD4
		public const int INVALID_INDEX = -1; // Metadata: 0x0263BBD5
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get; }
		public bool ring { get; }
		public int beginIndex { get; }
		public int endIndex { get; }
		public bool isEmpty { get; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 79941
		{
			// Fields
			private int m_count;
			private int m_beginIndex;
			private int m_index;
			private FSMTransitionDefinition20<T> m_data;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator([IsReadOnly] in FSMTransitionDefinition20<T> data, int count);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 79942
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe FSMTransitionDefinition20(int initialCapacity = 32 /* Metadata: 0x0263BBCF */, bool autoExtend = false /* Metadata: 0x0263BBD0 */);
	
		// Methods
		public unsafe byte* GetPtr();
		public IntPtr GetDataAsIntPtr();
		public int Enqueue(T value);
		public T Dequeue();
		public int Unshift(T value);
		public T Shift();
		public int Push(T value);
		public T Pop();
		public T First();
		public T Last();
		public void InsertAt(int index, T value);
		public T RemoveAt(int index);
		public int Find(T value);
		public void Extend(int count);
		public void Extend();
		public void Clear();
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public unsafe T* GetElementAt(int index);
		public T GetValue(int index);
		public T GetValueWithGlobalIndex(int globalIndex);
	}

	public struct FSMTransitionDefinition // TypeDefIndex: 79944
	{
		// Fields
		public byte fromStateIndex; // 0x00
		public byte toStateIndex; // 0x01
		public float exitTime; // 0x02
		public float duration; // 0x06
		public FixedList32Bytes<FSMCondition> conditions; // 0x0A
	}

	public enum ParameterType : byte // TypeDefIndex: 79945
	{
		Float = 1,
		Int = 3,
		Bool = 4,
		Trigger = 9
	}

	public struct FSMParameterDefinition // TypeDefIndex: 79946
	{
		// Fields
		public int nameHash; // 0x00
		public Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type; // 0x04
		public byte index; // 0x05
		public float defaultFloat; // 0x08
		public int defaultInt; // 0x08
		public byte defaultBool; // 0x08
	}

	public struct FSMStateDefinition // TypeDefIndex: 79947
	{
		// Fields
		public int nameHash; // 0x00
		public float speed; // 0x04
		public byte index; // 0x08
		public byte clipSlot0; // 0x09
		public byte clipSlot1; // 0x0A
		public byte clipSlot2; // 0x0B
	
		// Methods
		[IsReadOnly]
		public byte GetClipIndex(byte slotIndex); // 0x0000000185D32600-0x0000000185D326D0
		public void SetClipIndex(byte slotIndex, byte clipIndex); // 0x00000001861FB3C0-0x00000001861FB3E0
	}

	public struct FSMClipDefinition // TypeDefIndex: 79948
	{
		// Fields
		public int nameHash; // 0x00
		public float length; // 0x04
		public uint startFrame; // 0x08
		public uint totalFrames; // 0x0C
		public byte index; // 0x10
		public bool isLoop; // 0x11
	}

	public struct VATFSMDefinitionContainer // TypeDefIndex: 79950
	{
		// Fields
		public const int INVALID_INDEX = -1; // Metadata: 0x0263BBDA
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref VATFSMDefinition this[int index] { get => default; } // 0x0000000188D08B84-0x0000000188D08BC8 
		public ref VATFSMDefinition this[uint index] { get => default; } // 0x000000018723B200-0x000000018723B210 
	
		// Nested types
		internal struct Node // TypeDefIndex: 79949
		{
			// Fields
			public VATFSMDefinition value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public VATFSMDefinitionContainer(Unity.Collections.Allocator allocator); // 0x00000001861FA950-0x00000001861FA9F0
	
		// Methods
		public void Dispose(); // 0x0000000188D08A70-0x0000000188D08AAC
		public void FlushPendingFree(); // 0x0000000185F71EC0-0x0000000185F71F40
		public uint Size(); // 0x0000000188D08B50-0x0000000188D08B84
		public Span<VATFSMDefinition> AsSpan(); // 0x0000000188D089A8-0x0000000188D08A18
		public uint Create(ref VATFSMDefinition value); // 0x00000001861FB430-0x00000001861FB4F0
		public void Destroy(uint handle); // 0x0000000188D08A18-0x0000000188D08A70
		public void Reset(); // 0x0000000188D08AFC-0x0000000188D08B50
		public void Reserve(uint newCapacity); // 0x0000000188D08AB4-0x0000000188D08AFC
		public IntPtr Data(); // 0x0000000184431970-0x0000000184431980
		public ref VATFSMDefinition Get(uint handle); // 0x000000018723B200-0x000000018723B210
		public ref VATFSMDefinition Get(int handle); // 0x0000000188D08AAC-0x0000000188D08AB4
	}

	public static class VATFSMDefinitionHelper // TypeDefIndex: 79951
	{
		// Methods
		private static bool _Evaluate([IsReadOnly] in FSMCondition cond, [IsReadOnly] in FSMParameterSet param, [IsReadOnly] in FixedList128Bytes<FSMParameterDefinition> paramDefs); // 0x0000000188D08F84-0x0000000188D09184
	
		// Extension methods
		public static bool TryGetValidTransition(this ref VATFSMStateFragment state, ref VATFSMDefinition def, out int transitionIndex); // 0x0000000188D08E28-0x0000000188D08F84
		public static bool TryGetParameterIndexAndType(this VATFSMDefinition def, int nameHash, out byte index, out Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type); // 0x0000000188D08D20-0x0000000188D08E28
		public static bool TryGetClipSlotByMode(this ref VATFSMDefinition def, FCNodeMode mode, out byte clipSlot); // 0x0000000185986DD0-0x0000000185986E40
		public static void ResetUsedTriggers(this ref FSMParameterSet param, [IsReadOnly] in FSMTransitionDefinition transition, [IsReadOnly] in FixedList128Bytes<FSMParameterDefinition> paramDefs); // 0x0000000188D08BC8-0x0000000188D08D20
	}

	public static class FSMDefinitionLibrary // TypeDefIndex: 79952
	{
		// Fields
		public const int MAX_FSM_DEFINITION_COUNT = 128; // Metadata: 0x0263BBDB
		public const int MAX_STATE_COUNT = 15; // Metadata: 0x0263BBDD
		public const int MAX_TRANSITION_COUNT = 20; // Metadata: 0x0263BBDE
		public const int MAX_CONDITION_PRE_TRANSITION_COUNT = 3; // Metadata: 0x0263BBDF
		public const int MAX_PARAMETER_COUNT = 7; // Metadata: 0x0263BBE0
		public const int MAX_CLIP_PRE_STATE_COUNT = 3; // Metadata: 0x0263BBE1
		public const int MAX_CLIP_COUNT = 20; // Metadata: 0x0263BBE2
		public const byte ANY_STATE_INDEX = 255; // Metadata: 0x0263BBE3
		public const string PEDESTAL_ADJUST_GROUND = "adjust_ground"; // Metadata: 0x0263BBE4
		public static readonly float2 PEDESTAL_ADJUST_GROUND_RANGE; // 0x00
		public static readonly float PEDESTAL_ADJUST_GROUND_OFFSET; // 0x08
		public static NativeParallelHashMap<int, uint> s_assetHashGuidToHandle; // 0x10
		public static NativeParallelHashMap<int2, byte> s_stateNameHashToIndex; // 0x20
		public static NativeParallelHashMap<int2, byte> s_parameterNameHashToIndex; // 0x30
		public static NativeParallelHashMap<int2, byte> s_clipNameHashToIndex; // 0x40
	
		// Constructors
		static FSMDefinitionLibrary(); // 0x00000001871F9980-0x00000001871F99E0
	
		// Methods
		public static void Initialize(); // 0x0000000186C7E8E0-0x0000000186C7EAD0
		public static void InitFSMDefinition(int guid, ECSVATFSMDefinitionData data); // 0x00000001861FA9F0-0x00000001861FB3C0
		private static void _DisableFSM(Entity rEntity, ref EntityManager em); // 0x0000000185986CA0-0x0000000185986DD0
		public static string GetStateName(uint fsmHandler, byte stateIndex); // 0x0000000188D0541C-0x0000000188D05550
		public static byte GetStateIndex(uint fsmHandler, int stateNameHash); // 0x00000001857A8EE0-0x00000001857A9200
		public static void Dispose(); // 0x0000000186C7EAD0-0x0000000186C7EC20
	
		// Extension methods
		public static void RegisterFSM(this Entity rEntity, ref EntityManager em); // 0x000000018598A340-0x000000018598A3D0
		public static void SyncFSMDefinition(this Entity rEntity, ref EntityManager em); // 0x000000018598BF60-0x000000018598C480
	}
}

namespace Beyond.Gameplay.Factory.Unsafe
{
	public enum BuildingStateQueryGroup : byte // TypeDefIndex: 79954
	{
		Default = 0,
		Battle = 1,
		BurnPower = 2,
		Collector = 3,
		Decorate = 4,
		DepositBeacon = 5,
		FluidContainer = 6,
		FluidPumpIn = 7,
		FluidSpray = 8,
		FreeBus = 9,
		Hub = 10,
		LiquidCleanGate = 11,
		LiquidRecycleGate = 12,
		PowerPole = 13,
		Producer = 14,
		Sign = 15,
		Soil = 16,
		Storage = 17,
		Transmuter = 18,
		UdPipe = 19,
		Vaporizer = 20,
		WarehousePort = 21
	}

	public static class BuildingStateQueryRegistry // TypeDefIndex: 79955
	{
		// Methods
		public static BuildingStateQueryGroup GetGroup(int templateIdFastId); // 0x0000000188D02130-0x0000000188D02E14
	}

	public static class BuildingTemplateIds // TypeDefIndex: 79958
	{
		// Fields
		private static bool s_inited; // 0x00
		private static readonly SharedStatic<Holder> HOLDER; // 0x08
	
		// Properties
		private static ref Holder Ids { get; } // 0x000000018656BCC0-0x000000018656BD10 
		public static ref StringIntern.FastId MINER_1 { get; } // 0x000000018656D3D0-0x000000018656D410 
		public static ref StringIntern.FastId MINER_2 { get; } // 0x000000018656C210-0x000000018656C260 
		public static ref StringIntern.FastId MINER_3 { get; } // 0x000000018656C1C0-0x000000018656C210 
		public static ref StringIntern.FastId MINER_4 { get; } // 0x000000018656C170-0x000000018656C1C0 
		public static ref StringIntern.FastId POWER_STATION_1 { get; } // 0x000000018656C120-0x000000018656C170 
		public static ref StringIntern.FastId FURNANCE_1 { get; } // 0x000000018656C0D0-0x000000018656C120 
		public static ref StringIntern.FastId FURNANCE_NOP_1 { get; } // 0x000000018656C080-0x000000018656C0D0 
		public static ref StringIntern.FastId GRINDER_1 { get; } // 0x000000018656C030-0x000000018656C080 
		public static ref StringIntern.FastId WINDER_1 { get; } // 0x000000018656BFE0-0x000000018656C030 
		public static ref StringIntern.FastId COMPONENT_MC_1 { get; } // 0x000000018656BF90-0x000000018656BFE0 
		public static ref StringIntern.FastId SHAPER_1 { get; } // 0x000000018656BF40-0x000000018656BF90 
		public static ref StringIntern.FastId FILLING_POWDER_MC_1 { get; } // 0x000000018656BEF0-0x000000018656BF40 
		public static ref StringIntern.FastId THICKENER_1 { get; } // 0x000000018656BEA0-0x000000018656BEF0 
		public static ref StringIntern.FastId TOOLS_ASSEBLING_MC_1 { get; } // 0x000000018656BE50-0x000000018656BEA0 
		public static ref StringIntern.FastId SEEDCOLLECTOR_1 { get; } // 0x000000018656BE00-0x000000018656BE50 
		public static ref StringIntern.FastId PLANTER_1 { get; } // 0x000000018656BDB0-0x000000018656BE00 
		public static ref StringIntern.FastId POWER_DIFFUSER_1 { get; } // 0x000000018656BD60-0x000000018656BDB0 
		public static ref StringIntern.FastId POWER_DIFFUSER_2 { get; } // 0x000000018656BD10-0x000000018656BD60 
		public static ref StringIntern.FastId POWER_POLE_2 { get; } // 0x0000000186569CE0-0x0000000186569D30 
		public static ref StringIntern.FastId POWER_POLE_3 { get; } // 0x0000000186569D30-0x0000000186569D80 
		public static ref StringIntern.FastId TRAVEL_POLE_1 { get; } // 0x0000000186569D80-0x0000000186569DD0 
		public static ref StringIntern.FastId TRAVEL_POLE_NOP_1 { get; } // 0x0000000186569DD0-0x0000000186569E20 
		public static ref StringIntern.FastId TRAVEL_POLE_2 { get; } // 0x0000000186569E20-0x0000000186569E70 
		public static ref StringIntern.FastId LOADER_1 { get; } // 0x0000000186569E70-0x0000000186569EC0 
		public static ref StringIntern.FastId UNLOADER_1 { get; } // 0x0000000186569EC0-0x0000000186569F10 
		public static ref StringIntern.FastId STORAGER_1 { get; } // 0x0000000186569F10-0x0000000186569F60 
		public static ref StringIntern.FastId STORAGER_NOP_1 { get; } // 0x0000000186569F60-0x0000000186569FB0 
		public static ref StringIntern.FastId POWER_TERMINAL_1 { get; } // 0x0000000186569FB0-0x000000018656A000 
		public static ref StringIntern.FastId POWER_PORT_1 { get; } // 0x000000018656A000-0x000000018656A050 
		public static ref StringIntern.FastId SOIL_1 { get; } // 0x000000018656A050-0x000000018656A0A0 
		public static ref StringIntern.FastId SOIL_2 { get; } // 0x000000018656A0A0-0x000000018656A0F0 
		public static ref StringIntern.FastId SOIL_MOSS_1 { get; } // 0x000000018656A0F0-0x000000018656A140 
		public static ref StringIntern.FastId SOIL_MOSS_2 { get; } // 0x000000018656A140-0x000000018656A190 
		public static ref StringIntern.FastId SOIL_MOSS_3 { get; } // 0x000000018656A190-0x000000018656A1E0 
		public static ref StringIntern.FastId SOIL_BBFLOWER_1 { get; } // 0x000000018656A1E0-0x000000018656A230 
		public static ref StringIntern.FastId SOIL_GRASS_1 { get; } // 0x000000018656A230-0x000000018656A280 
		public static ref StringIntern.FastId SOIL_GRASS_2 { get; } // 0x000000018656A280-0x000000018656A2D0 
		public static ref StringIntern.FastId SOIL_SP_1 { get; } // 0x000000018656A2D0-0x000000018656A320 
		public static ref StringIntern.FastId SOIL_SP_2 { get; } // 0x000000018656A320-0x000000018656A370 
		public static ref StringIntern.FastId SOIL_SP_3 { get; } // 0x000000018656A370-0x000000018656A3C0 
		public static ref StringIntern.FastId SOIL_SP_4 { get; } // 0x000000018656A3C0-0x000000018656A410 
		public static ref StringIntern.FastId SOIL_GRASS_FAST_1 { get; } // 0x000000018656A410-0x000000018656A460 
		public static ref StringIntern.FastId SOIL_GRASS_FAST_2 { get; } // 0x000000018656A460-0x000000018656A4B0 
		public static ref StringIntern.FastId SOIL_SP_FAST_3 { get; } // 0x000000018656A4B0-0x000000018656A500 
		public static ref StringIntern.FastId SOIL_SP_FAST_4 { get; } // 0x000000018656A500-0x000000018656A550 
		public static ref StringIntern.FastId SOIL_CORP_BEAN_1 { get; } // 0x000000018656A550-0x000000018656A5A0 
		public static ref StringIntern.FastId SOIL_CORP_CABBAGE_1 { get; } // 0x000000018656A5A0-0x000000018656A5F0 
		public static ref StringIntern.FastId SOIL_CORP_CABBAGE_2 { get; } // 0x000000018656A5F0-0x000000018656A640 
		public static ref StringIntern.FastId SOIL_CORP_CANOLAFLOWER_1 { get; } // 0x000000018656A640-0x000000018656A690 
		public static ref StringIntern.FastId SOIL_CORP_MUSHROOM_1 { get; } // 0x000000018656A690-0x000000018656A6E0 
		public static ref StringIntern.FastId SOIL_CORP_MUSHROOM_2 { get; } // 0x000000018656A6E0-0x000000018656A730 
		public static ref StringIntern.FastId SOIL_CORP_POTATO_1 { get; } // 0x000000018656A730-0x000000018656A780 
		public static ref StringIntern.FastId SOIL_CORP_STRAWBERRY_1 { get; } // 0x000000018656A780-0x000000018656A7D0 
		public static ref StringIntern.FastId SOIL_CORP_STRAWBERRY_2 { get; } // 0x000000018656A7D0-0x000000018656A820 
		public static ref StringIntern.FastId SOIL_CORP_SUGARCANE_1 { get; } // 0x000000018656A820-0x000000018656A870 
		public static ref StringIntern.FastId SOIL_CORP_TOMATO_1 { get; } // 0x000000018656A870-0x000000018656A8C0 
		public static ref StringIntern.FastId SOIL_CORP_WHITEGOURD_1 { get; } // 0x000000018656A8C0-0x000000018656A910 
		public static ref StringIntern.FastId BATTLE_LIGHTNING_1 { get; } // 0x000000018656A910-0x000000018656A960 
		public static ref StringIntern.FastId BATTLE_CANNON_1 { get; } // 0x000000018656A960-0x000000018656A9B0 
		public static ref StringIntern.FastId BATTLE_CANNON_2 { get; } // 0x000000018656A9B0-0x000000018656AA00 
		public static ref StringIntern.FastId BATTLE_TURRET_1 { get; } // 0x000000018656AA00-0x000000018656AA50 
		public static ref StringIntern.FastId BATTLE_TURRET_2 { get; } // 0x000000018656AA50-0x000000018656AAA0 
		public static ref StringIntern.FastId BATTLE_MEDIC_1 { get; } // 0x000000018656AAA0-0x000000018656AAF0 
		public static ref StringIntern.FastId BATTLE_SHOCKWAVE_1 { get; } // 0x000000018656AAF0-0x000000018656AB40 
		public static ref StringIntern.FastId BATTLE_FROST_1 { get; } // 0x000000018656AB40-0x000000018656AB90 
		public static ref StringIntern.FastId BATTLE_SNIPER_1 { get; } // 0x000000018656AB90-0x000000018656ABE0 
		public static ref StringIntern.FastId BATTLE_LASER_1 { get; } // 0x000000018656ABE0-0x000000018656AC30 
		public static ref StringIntern.FastId BATTLE_LASER_2 { get; } // 0x000000018656AC30-0x000000018656AC80 
		public static ref StringIntern.FastId BATTLE_JET_1 { get; } // 0x000000018656AC80-0x000000018656ACD0 
		public static ref StringIntern.FastId BATTLE_TRAP_1 { get; } // 0x000000018656ACD0-0x000000018656AD20 
		public static ref StringIntern.FastId BATTLE_FOG_1 { get; } // 0x000000018656AD20-0x000000018656AD70 
		public static ref StringIntern.FastId BATTLE_DEBUFF_1 { get; } // 0x000000018656AD70-0x000000018656ADC0 
		public static ref StringIntern.FastId BATTLE_ROCKET_1 { get; } // 0x000000018656ADC0-0x000000018656AE10 
		public static ref StringIntern.FastId BATTLE_TURRET_3 { get; } // 0x000000018656AE10-0x000000018656AE60 
		public static ref StringIntern.FastId BATTLE_LIGHTNING_2 { get; } // 0x000000018656AE60-0x000000018656AEB0 
		public static ref StringIntern.FastId BATTLE_CANNON_1_DG002 { get; } // 0x000000018656AEB0-0x000000018656AF00 
		public static ref StringIntern.FastId V_FLUID_CONTAINER_1 { get; } // 0x000000018656AF00-0x000000018656AF50 
		public static ref StringIntern.FastId PUMP_1 { get; } // 0x000000018656AF50-0x000000018656AFA0 
		public static ref StringIntern.FastId PUMP_2 { get; } // 0x000000018656AFA0-0x000000018656AFF0 
		public static ref StringIntern.FastId LIQUID_STORAGER_1 { get; } // 0x000000018656AFF0-0x000000018656B040 
		public static ref StringIntern.FastId LIQUID_STORAGER_NOP_1 { get; } // 0x000000018656B040-0x000000018656B090 
		public static ref StringIntern.FastId MIX_POOL_1 { get; } // 0x000000018656B090-0x000000018656B0E0 
		public static ref StringIntern.FastId MIX_POOL_2 { get; } // 0x000000018656B0E0-0x000000018656B130 
		public static ref StringIntern.FastId SQUIRTER_1 { get; } // 0x000000018656B130-0x000000018656B180 
		public static ref StringIntern.FastId SQUIRTER_NOP_1 { get; } // 0x000000018656B180-0x000000018656B1D0 
		public static ref StringIntern.FastId DUMPER_1 { get; } // 0x000000018656B1D0-0x000000018656B220 
		public static ref StringIntern.FastId DUMPER_NOP_1 { get; } // 0x000000018656B220-0x000000018656B270 
		public static ref StringIntern.FastId LIQUID_CLEANER_1 { get; } // 0x000000018656B270-0x000000018656B2C0 
		public static ref StringIntern.FastId LIQUID_CLEAN_GATE_1 { get; } // 0x000000018656B2C0-0x000000018656B310 
		public static ref StringIntern.FastId LIQUID_RECYCLE_GATE_1 { get; } // 0x000000018656B310-0x000000018656B360 
		public static ref StringIntern.FastId XIRANITE_OVEN_1 { get; } // 0x000000018656B360-0x000000018656B3B0 
		public static ref StringIntern.FastId LIQUID_PURIFIER_1 { get; } // 0x000000018656B3B0-0x000000018656B400 
		public static ref StringIntern.FastId DISMANTLER_1 { get; } // 0x000000018656B400-0x000000018656B450 
		public static ref StringIntern.FastId LOG_HONGS_BUS { get; } // 0x000000018656B450-0x000000018656B4A0 
		public static ref StringIntern.FastId LOG_HONGS_BUS_SOURCE { get; } // 0x000000018656B4A0-0x000000018656B4F0 
		public static ref StringIntern.FastId UDPIPE_LOADER_1 { get; } // 0x000000018656B4F0-0x000000018656B540 
		public static ref StringIntern.FastId UDPIPE_LOADER_2 { get; } // 0x000000018656B540-0x000000018656B590 
		public static ref StringIntern.FastId UDPIPE_UNLOADER_1 { get; } // 0x000000018656B590-0x000000018656B5E0 
		public static ref StringIntern.FastId UDPIPE_UNLOADER_2 { get; } // 0x000000018656B5E0-0x000000018656B630 
		public static ref StringIntern.FastId VAPORIZER_1 { get; } // 0x000000018656B630-0x000000018656B680 
		public static ref StringIntern.FastId TRANSMUTER_1 { get; } // 0x000000018656B680-0x000000018656B6D0 
		public static ref StringIntern.FastId TRANSMUTER_2 { get; } // 0x000000018656B6D0-0x000000018656B720 
		public static ref StringIntern.FastId GAS_REACTOR_1 { get; } // 0x000000018656B720-0x000000018656B770 
		public static ref StringIntern.FastId GAS_STORAGER_1 { get; } // 0x000000018656B770-0x000000018656B7C0 
		public static ref StringIntern.FastId GAS_PUMP_1 { get; } // 0x000000018656B7C0-0x000000018656B810 
		public static ref StringIntern.FastId SP_HUB_1 { get; } // 0x000000018656B810-0x000000018656B860 
		public static ref StringIntern.FastId SP_HUB_2 { get; } // 0x000000018656B860-0x000000018656B8B0 
		public static ref StringIntern.FastId SP_SUB_HUB_1 { get; } // 0x000000018656B8B0-0x000000018656B900 
		public static ref StringIntern.FastId CARRIER_1 { get; } // 0x000000018656B900-0x000000018656B950 
		public static ref StringIntern.FastId MARKER_1 { get; } // 0x000000018656B950-0x000000018656B9A0 
		public static ref StringIntern.FastId AIR_DANCER_1 { get; } // 0x000000018656B9A0-0x000000018656B9F0 
		public static ref StringIntern.FastId CHUBBY_LUNG_STONE_1 { get; } // 0x000000018656B9F0-0x000000018656BA40 
		public static ref StringIntern.FastId CHUBBY_LUNG_BALLOON_1 { get; } // 0x000000018656BA40-0x000000018656BA90 
		public static ref StringIntern.FastId PEAR_BLOSSOM_BONSAI_1 { get; } // 0x000000018656BA90-0x000000018656BAE0 
		public static ref StringIntern.FastId JAIL_1 { get; } // 0x000000018656BAE0-0x000000018656BB30 
		public static ref StringIntern.FastId PHOTO_FRAME_1 { get; } // 0x000000018656BB30-0x000000018656BB80 
		public static ref StringIntern.FastId SIGNBOARD_1 { get; } // 0x000000018656BB80-0x000000018656BBD0 
		public static ref StringIntern.FastId CAT_TREE_1 { get; } // 0x000000018656BBD0-0x000000018656BC20 
		public static ref StringIntern.FastId DISPLAY_STAND_1 { get; } // 0x000000018656BC20-0x000000018656BC70 
		public static ref StringIntern.FastId MICROPHONE_1 { get; } // 0x000000018656BC70-0x000000018656BCC0 
	
		// Nested types
		private struct Holder // TypeDefIndex: 79956
		{
			// Fields
			public StringIntern.FastId MINER_1; // 0x00
			public StringIntern.FastId MINER_2; // 0x04
			public StringIntern.FastId MINER_3; // 0x08
			public StringIntern.FastId MINER_4; // 0x0C
			public StringIntern.FastId POWER_STATION_1; // 0x10
			public StringIntern.FastId FURNANCE_1; // 0x14
			public StringIntern.FastId FURNANCE_NOP_1; // 0x18
			public StringIntern.FastId GRINDER_1; // 0x1C
			public StringIntern.FastId WINDER_1; // 0x20
			public StringIntern.FastId COMPONENT_MC_1; // 0x24
			public StringIntern.FastId SHAPER_1; // 0x28
			public StringIntern.FastId FILLING_POWDER_MC_1; // 0x2C
			public StringIntern.FastId THICKENER_1; // 0x30
			public StringIntern.FastId TOOLS_ASSEBLING_MC_1; // 0x34
			public StringIntern.FastId SEEDCOLLECTOR_1; // 0x38
			public StringIntern.FastId PLANTER_1; // 0x3C
			public StringIntern.FastId POWER_DIFFUSER_1; // 0x40
			public StringIntern.FastId POWER_DIFFUSER_2; // 0x44
			public StringIntern.FastId POWER_POLE_2; // 0x48
			public StringIntern.FastId POWER_POLE_3; // 0x4C
			public StringIntern.FastId TRAVEL_POLE_1; // 0x50
			public StringIntern.FastId TRAVEL_POLE_NOP_1; // 0x54
			public StringIntern.FastId TRAVEL_POLE_2; // 0x58
			public StringIntern.FastId LOADER_1; // 0x5C
			public StringIntern.FastId UNLOADER_1; // 0x60
			public StringIntern.FastId STORAGER_1; // 0x64
			public StringIntern.FastId STORAGER_NOP_1; // 0x68
			public StringIntern.FastId POWER_TERMINAL_1; // 0x6C
			public StringIntern.FastId POWER_PORT_1; // 0x70
			public StringIntern.FastId SOIL_1; // 0x74
			public StringIntern.FastId SOIL_2; // 0x78
			public StringIntern.FastId SOIL_MOSS_1; // 0x7C
			public StringIntern.FastId SOIL_MOSS_2; // 0x80
			public StringIntern.FastId SOIL_MOSS_3; // 0x84
			public StringIntern.FastId SOIL_BBFLOWER_1; // 0x88
			public StringIntern.FastId SOIL_GRASS_1; // 0x8C
			public StringIntern.FastId SOIL_GRASS_2; // 0x90
			public StringIntern.FastId SOIL_SP_1; // 0x94
			public StringIntern.FastId SOIL_SP_2; // 0x98
			public StringIntern.FastId SOIL_SP_3; // 0x9C
			public StringIntern.FastId SOIL_SP_4; // 0xA0
			public StringIntern.FastId SOIL_GRASS_FAST_1; // 0xA4
			public StringIntern.FastId SOIL_GRASS_FAST_2; // 0xA8
			public StringIntern.FastId SOIL_SP_FAST_3; // 0xAC
			public StringIntern.FastId SOIL_SP_FAST_4; // 0xB0
			public StringIntern.FastId SOIL_CORP_BEAN_1; // 0xB4
			public StringIntern.FastId SOIL_CORP_CABBAGE_1; // 0xB8
			public StringIntern.FastId SOIL_CORP_CABBAGE_2; // 0xBC
			public StringIntern.FastId SOIL_CORP_CANOLAFLOWER_1; // 0xC0
			public StringIntern.FastId SOIL_CORP_MUSHROOM_1; // 0xC4
			public StringIntern.FastId SOIL_CORP_MUSHROOM_2; // 0xC8
			public StringIntern.FastId SOIL_CORP_POTATO_1; // 0xCC
			public StringIntern.FastId SOIL_CORP_STRAWBERRY_1; // 0xD0
			public StringIntern.FastId SOIL_CORP_STRAWBERRY_2; // 0xD4
			public StringIntern.FastId SOIL_CORP_SUGARCANE_1; // 0xD8
			public StringIntern.FastId SOIL_CORP_TOMATO_1; // 0xDC
			public StringIntern.FastId SOIL_CORP_WHITEGOURD_1; // 0xE0
			public StringIntern.FastId BATTLE_LIGHTNING_1; // 0xE4
			public StringIntern.FastId BATTLE_CANNON_1; // 0xE8
			public StringIntern.FastId BATTLE_CANNON_2; // 0xEC
			public StringIntern.FastId BATTLE_TURRET_1; // 0xF0
			public StringIntern.FastId BATTLE_TURRET_2; // 0xF4
			public StringIntern.FastId BATTLE_MEDIC_1; // 0xF8
			public StringIntern.FastId BATTLE_SHOCKWAVE_1; // 0xFC
			public StringIntern.FastId BATTLE_FROST_1; // 0x100
			public StringIntern.FastId BATTLE_SNIPER_1; // 0x104
			public StringIntern.FastId BATTLE_LASER_1; // 0x108
			public StringIntern.FastId BATTLE_LASER_2; // 0x10C
			public StringIntern.FastId BATTLE_JET_1; // 0x110
			public StringIntern.FastId BATTLE_TRAP_1; // 0x114
			public StringIntern.FastId BATTLE_FOG_1; // 0x118
			public StringIntern.FastId BATTLE_DEBUFF_1; // 0x11C
			public StringIntern.FastId BATTLE_ROCKET_1; // 0x120
			public StringIntern.FastId BATTLE_TURRET_3; // 0x124
			public StringIntern.FastId BATTLE_LIGHTNING_2; // 0x128
			public StringIntern.FastId BATTLE_CANNON_1_DG002; // 0x12C
			public StringIntern.FastId V_FLUID_CONTAINER_1; // 0x130
			public StringIntern.FastId PUMP_1; // 0x134
			public StringIntern.FastId PUMP_2; // 0x138
			public StringIntern.FastId LIQUID_STORAGER_1; // 0x13C
			public StringIntern.FastId LIQUID_STORAGER_NOP_1; // 0x140
			public StringIntern.FastId MIX_POOL_1; // 0x144
			public StringIntern.FastId MIX_POOL_2; // 0x148
			public StringIntern.FastId SQUIRTER_1; // 0x14C
			public StringIntern.FastId SQUIRTER_NOP_1; // 0x150
			public StringIntern.FastId DUMPER_1; // 0x154
			public StringIntern.FastId DUMPER_NOP_1; // 0x158
			public StringIntern.FastId LIQUID_CLEANER_1; // 0x15C
			public StringIntern.FastId LIQUID_CLEAN_GATE_1; // 0x160
			public StringIntern.FastId LIQUID_RECYCLE_GATE_1; // 0x164
			public StringIntern.FastId XIRANITE_OVEN_1; // 0x168
			public StringIntern.FastId LIQUID_PURIFIER_1; // 0x16C
			public StringIntern.FastId DISMANTLER_1; // 0x170
			public StringIntern.FastId LOG_HONGS_BUS; // 0x174
			public StringIntern.FastId LOG_HONGS_BUS_SOURCE; // 0x178
			public StringIntern.FastId UDPIPE_LOADER_1; // 0x17C
			public StringIntern.FastId UDPIPE_LOADER_2; // 0x180
			public StringIntern.FastId UDPIPE_UNLOADER_1; // 0x184
			public StringIntern.FastId UDPIPE_UNLOADER_2; // 0x188
			public StringIntern.FastId VAPORIZER_1; // 0x18C
			public StringIntern.FastId TRANSMUTER_1; // 0x190
			public StringIntern.FastId TRANSMUTER_2; // 0x194
			public StringIntern.FastId GAS_REACTOR_1; // 0x198
			public StringIntern.FastId GAS_STORAGER_1; // 0x19C
			public StringIntern.FastId GAS_PUMP_1; // 0x1A0
			public StringIntern.FastId SP_HUB_1; // 0x1A4
			public StringIntern.FastId SP_HUB_2; // 0x1A8
			public StringIntern.FastId SP_SUB_HUB_1; // 0x1AC
			public StringIntern.FastId CARRIER_1; // 0x1B0
			public StringIntern.FastId MARKER_1; // 0x1B4
			public StringIntern.FastId AIR_DANCER_1; // 0x1B8
			public StringIntern.FastId CHUBBY_LUNG_STONE_1; // 0x1BC
			public StringIntern.FastId CHUBBY_LUNG_BALLOON_1; // 0x1C0
			public StringIntern.FastId PEAR_BLOSSOM_BONSAI_1; // 0x1C4
			public StringIntern.FastId JAIL_1; // 0x1C8
			public StringIntern.FastId PHOTO_FRAME_1; // 0x1CC
			public StringIntern.FastId SIGNBOARD_1; // 0x1D0
			public StringIntern.FastId CAT_TREE_1; // 0x1D4
			public StringIntern.FastId DISPLAY_STAND_1; // 0x1D8
			public StringIntern.FastId MICROPHONE_1; // 0x1DC
		}
	
		private struct HolderContext // TypeDefIndex: 79957
		{
		}
	
		// Constructors
		static BuildingTemplateIds(); // 0x00000001871E82A0-0x00000001871E8300
	
		// Methods
		public static void EnsureInit(); // 0x000000018656C260-0x000000018656D3D0
	}

	[BurstCompile]
	public static class BurstBridge // TypeDefIndex: 79961
	{
		// Nested types
		public unsafe delegate void SamplePredictCargo_00000C34_PostfixBurstDelegate(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation); // TypeDefIndex: 79959; 0x00000001811DB3F0-0x00000001811DB410
	
		internal static class SamplePredictCargo_00000C34_BurstDirectCall // TypeDefIndex: 79960
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SamplePredictCargo_00000C34_BurstDirectCall(); // 0x00000001828817D0-0x00000001828817E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000ab9db); // 0x0000000182880240-0x0000000182880EA0
			private static IntPtr GetFunctionPointer(); // 0x0000000182880EA0-0x00000001828811A0
			public static void Constructor(); // 0x000000018287F9C0-0x0000000182880240
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation); // 0x00000001828811A0-0x00000001828817D0
		}
	
		// Methods
		[BurstDiscard]
		public static void BeginProfilerSample(string name); // 0x0000000186805BA0-0x0000000186805BB0
		[BurstDiscard]
		public static void EndProfilerSample(); // 0x0000000186805BA0-0x0000000186805BB0
		[BurstCompile]
		public static unsafe void SamplePredictCargo(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation); // 0x0000000188D02E14-0x0000000188D02E8C
		[BurstCompile]
		public static unsafe void SamplePredictCargo_BurstManaged(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation); // 0x0000000188D00AF0-0x0000000188D01D6C
	}

	[BurstCompile]
	public static class EntityExtensions // TypeDefIndex: 79968
	{
		// Nested types
		public delegate FacBuildingState QueryBuildingState_00000C38_PostfixBurstDelegate(ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState); // TypeDefIndex: 79962; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class QueryBuildingState_00000C38_BurstDirectCall // TypeDefIndex: 79963
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static QueryBuildingState_00000C38_BurstDirectCall(); // 0x000000018287EB40-0x000000018287EB50
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000aba88); // 0x000000018287D5D0-0x000000018287E230
			private static IntPtr GetFunctionPointer(); // 0x000000018287E230-0x000000018287E530
			public static void Constructor(); // 0x000000018287CD50-0x000000018287D5D0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static FacBuildingState Invoke(ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState); // 0x000000018287E530-0x000000018287EB40
		}
	
		public delegate void SetFlashStatue_00000C4B_PostfixBurstDelegate(ref Entity logicEntity, ref EntityManager em, FacBuildingState statue); // TypeDefIndex: 79964; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class SetFlashStatue_00000C4B_BurstDirectCall // TypeDefIndex: 79965
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SetFlashStatue_00000C4B_BurstDirectCall(); // 0x0000000182884550-0x0000000182884560
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000aba97); // 0x0000000182882FE0-0x0000000182883C40
			private static IntPtr GetFunctionPointer(); // 0x0000000182883C40-0x0000000182883F40
			public static void Constructor(); // 0x0000000182882760-0x0000000182882FE0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref Entity logicEntity, ref EntityManager em, FacBuildingState statue); // 0x0000000182883F40-0x0000000182884550
		}
	
		public delegate void _SetRenderEntityFlashStatue_00000C4C_PostfixBurstDelegate(ref EntityManager em, ref Entity rendererEntity, byte statue); // TypeDefIndex: 79966; 0x00000001811DF7F0-0x00000001811DF810
	
		internal static class _SetRenderEntityFlashStatue_00000C4C_BurstDirectCall // TypeDefIndex: 79967
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SetRenderEntityFlashStatue_00000C4C_BurstDirectCall(); // 0x0000000182887E40-0x0000000182887E50
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000abaa6); // 0x0000000182885C30-0x0000000182886890
			private static IntPtr GetFunctionPointer(); // 0x0000000182886890-0x0000000182886B90
			public static void Constructor(); // 0x00000001828853B0-0x0000000182885C30
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static void Invoke(ref EntityManager em, ref Entity rendererEntity, byte statue); // 0x0000000182886B90-0x0000000182887E40
		}
	
		// Methods
		private static FacBuildingState _QueryHubBuildingState(); // 0x00000001845BA780-0x00000001845BA790
		private static FacBuildingState _QuerySignBuildingState(); // 0x00000001845BA780-0x00000001845BA790
		private static unsafe FacBuildingState _QueryDepositBeaconBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000188D04540-0x0000000188D04614
		[IFixIgnore]
		private static unsafe FacBuildingState _QueryCollectorBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag, out FacBuildingSubState subState); // 0x0000000188D043C4-0x0000000188D04540
		[IFixIgnore]
		private static unsafe FacBuildingState _QueryOverrideWorkingBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000188D04764-0x0000000188D048A0
		private static unsafe FacBuildingState _QueryWarehousePortBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000188D05050-0x0000000188D05128
		[IFixIgnore]
		private static unsafe FacBuildingState _QueryStorageBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag, out FacBuildingSubState subState); // 0x0000000188D04AB0-0x0000000188D04BF4
		private static unsafe FacBuildingState _QueryFluidContainerBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag); // 0x0000000188D04614-0x0000000188D046EC
		[IFixIgnore]
		private static unsafe FacBuildingState _QueryBattleBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000188D04130-0x0000000188D04274
		private static FacBuildingState _QueryDecorateBuildingState(); // 0x00000001845BA780-0x00000001845BA790
		private static FacBuildingState _QueryFreeBusBuildingState(ref Entity logicEntity, ref EntityManager em); // 0x0000000188D046EC-0x0000000188D04764
		[IFixIgnore]
		private static unsafe FacBuildingState _QueryUdPipeBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000188D04D54-0x0000000188D04EC0
		[IFixIgnore]
		private static unsafe FacBuildingState _QueryProducerBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag, out FacBuildingSubState subState); // 0x0000000188D048A0-0x0000000188D04AB0
		[IFixIgnore]
		private static unsafe FacBuildingState _QueryBurnPowerBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000188D04274-0x0000000188D043C4
		private static unsafe FacBuildingState _QueryPowerPoleBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000188D04540-0x0000000188D04614
		[IFixIgnore]
		private static unsafe FacBuildingState _QueryVaporizerBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag, out FacBuildingSubState subState); // 0x0000000188D04EC0-0x0000000188D05050
		[IFixIgnore]
		private static unsafe FacBuildingState _QueryTransmuterBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, UnitConfigFragment* unitConfigFrag, ChapterTagFragment* chapterTag); // 0x0000000188D04BF4-0x0000000188D04D54
		private static bool _IsPowerBuilding(ref EntityManager em, ref Entity logicEntity); // 0x0000000188D040A8-0x0000000188D04130
		[BurstCompile]
		private static void _SetRenderEntityFlashStatue(ref EntityManager em, ref Entity rendererEntity, byte statue); // 0x0000000188D052F4-0x0000000188D05354
		[BurstCompile]
		public static void _SetRenderEntityFlashStatue_BurstManaged(ref EntityManager em, ref Entity rendererEntity, byte statue); // 0x0000000188D05128-0x0000000188D052F4
	
		// Extension methods
		public static ref SharedDataContainer.SharedExtData GetExtData(this Entity entity, ref EntityManager em); // 0x000000018509CD00-0x000000018509CE80
		public static unsafe ref SharedDataContainer.SharedExtData GetExtData(this Entity entity, ref EntityManager em, SharedDataContainer.SharedExtData* sharedDataPtr); // 0x0000000188D035B0-0x0000000188D0376C
		public static bool QueryBuildingStateIsClosed(this Entity logicEntity); // 0x0000000185AB3A30-0x0000000185AB3C20
		[BurstCompile]
		public static FacBuildingState QueryBuildingState(this ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState); // 0x0000000188D03C5C-0x0000000188D03CBC
		[BurstCompile]
		public static void SetFlashStatue(this ref Entity logicEntity, ref EntityManager em, FacBuildingState statue); // 0x0000000188D03EA8-0x0000000188D03F08
		public static bool CulledWithLogicEntity(this Entity logicEntity, ref EntityManager em); // 0x0000000188D02E8C-0x0000000188D02F50
		public static bool CulledWithRendererEntity(this Entity rendererEntity, ref EntityManager em); // 0x0000000188D02F50-0x0000000188D0304C
		public static bool GetVisibility(this Entity logicEntity, Visibility.Type type); // 0x0000000188D0376C-0x0000000188D037B8
		public static bool GetVisibility(this Entity logicEntity, ref EntityManager em, Visibility.Type type); // 0x00000001859682C0-0x00000001859683A0
		public static unsafe bool GetVisibility(this Entity logicEntity, ref EntityManager em, SharedDataContainer.SharedExtData* sharedDataPtr, Visibility.Type type); // 0x0000000188D037B8-0x0000000188D03884
		public static bool SetVisibility(this Entity logicEntity, ref EntityManager em, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short[] invisibleSubIndexList = null); // 0x0000000185665860-0x0000000185665920
		public static unsafe bool SetVisibility(this ref SharedDataContainer.SharedExtData extData, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short* subIndexListPtr = null, short subIndexCount = 0 /* Metadata: 0x0263BC08 */); // 0x0000000185665920-0x0000000185665D70
		public static void SetVisibilityWithNotify(this Entity logicEntity, ref EntityManager em, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short[] invisibleSubIndexList = null); // 0x0000000188D03F08-0x0000000188D040A8
		public static bool SetVisibility(this Entity logicEntity, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, ref EntityCommandBuffer ecb); // 0x0000000185665650-0x0000000185665860
		public static void SetInMainRegion(this Entity logicEntity, bool value); // 0x00000001850B0BC0-0x00000001850B0C30
		public static bool IsInMainRegionFuzzy(this Entity logicEntity, ref EntityManager em); // 0x0000000187834A6C-0x0000000187834A90
		public static unsafe bool IsInMainRegion(this SharedDataFragment sharedData, SharedDataContainer.SharedExtData* sharedDataPtr); // 0x0000000188D03884-0x0000000188D038B4
		public static void UpdatePipeEffect(this Entity logicEntity, ref EntityManager em); // 0x00000001857AA190-0x00000001857AA730
		public static unsafe bool GetBuildingExtendConfig(this Entity logicEntity, ref EntityManager em, FixedString32Bytes extendKey, SharedDataContainer.SharedExtData* sharedDataPtr, out float3 pos, out quaternion rot, out Entity posRendererEntity); // 0x0000000188D0304C-0x0000000188D032FC
		public static bool GetBuildingExtendConfig(this Entity logicEntity, ref EntityManager em, FixedString32Bytes extendKey, out float3 pos, out quaternion rot, out Entity posRendererEntity); // 0x00000001855D76C0-0x00000001855D7B10
		public static bool GetBuildingStaticMountWorldTRS(this Entity entity, string extendKey, out float3 pos, out quaternion rot); // 0x00000001855D70A0-0x00000001855D7260
		public static bool GetBuildingStaticMountWorldTRS(this Entity entity, ref EntityManager em, FixedString32Bytes extendKey, out float3 pos, out quaternion rot); // 0x00000001855D5BF0-0x00000001855D60D0
		public static unsafe bool GetBuildingStaticMountWorldTRS(this Entity entity, ref EntityManager em, FixedString32Bytes extendKey, SharedDataContainer.SharedExtData* sharedDataPtr, out float3 pos, out quaternion rot); // 0x0000000188D032FC-0x0000000188D035B0
		[BurstCompile]
		public static FacBuildingState QueryBuildingState_BurstManaged(this ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState); // 0x0000000188D038B4-0x0000000188D03C5C
		[BurstCompile]
		public static void SetFlashStatue_BurstManaged(this ref Entity logicEntity, ref EntityManager em, FacBuildingState statue); // 0x0000000188D03CBC-0x0000000188D03EA8
	}

	public static class GameplayExtensions // TypeDefIndex: 79969
	{
		// Extension methods
		[Conditional("UNITY_EDITOR")]
		public static void FacUnitAssertComponent<T>(this EntityManager em, Entity entity)
			where T : struct, IComponentECS;
		public static ref ChapterFragment GetChapterEntity(this EntityManager em, int chapterId, out bool existed, out Entity chapterEntity); // 0x00000001856E84B0-0x00000001856E8760
	}

	public static class GlobalEnvExtensions // TypeDefIndex: 79970
	{
		// Extension methods
		public static unsafe GlobalEnv* GetGlobalEnv(this EntityManager em); // 0x00000001858BB810-0x00000001858BB960
		public static IntPtr GetGlobalEnvPtr(this EntityManager em); // 0x00000001878379D0-0x00000001878379F0
		public static bool IsGlobalEnvValid(this EntityManager em); // 0x00000001858BB6D0-0x00000001858BB810
		public static ref GlobalEnv GetGlobalEnvRef(this EntityManager em); // 0x00000001878379D0-0x00000001878379F0
		public static void SetNearBuildingPtr(this ref GlobalEnv env, ref InteractFacCollectJob.BuildingInfo info, ref InteractFacCollectJob.BuildingInfo infoLast); // 0x000000018723B160-0x000000018723B170
		public static void SetNearConveyorPtr(this ref GlobalEnv env, ref InteractFacCollectJob.LogisticInfo info, ref InteractFacCollectJob.LogisticInfo infoLast); // 0x000000018723B170-0x000000018723B180
		public static void SetNearPipePtr(this ref GlobalEnv env, ref InteractFacCollectJob.LogisticInfo info, ref InteractFacCollectJob.LogisticInfo infoLast); // 0x000000018723B180-0x000000018723B190
		public static bool GetInteractFac(this ref GlobalEnv env, out InteractFacCollectJob.BuildingInfo info); // 0x0000000185961850-0x00000001859618C0
		public static bool GetInteractConveyor(this ref GlobalEnv env, out InteractFacCollectJob.LogisticInfo info); // 0x00000001863C5640-0x00000001863C5680
		public static bool GetInteractPipe(this ref GlobalEnv env, out InteractFacCollectJob.LogisticInfo info); // 0x00000001863C5990-0x00000001863C59D0
	}

	public interface IAllocator : IDisposable // TypeDefIndex: 79971
	{
		// Methods
		LinearAllocator.Allocation Allocate(int size);
		void Reserve(int newCapacity);
		LinearAllocator.Allocation Expand(int startIndex, int additionalSize);
		LinearAllocator.Allocation Resize(int startIndex, int newSize);
		void Free(int startIndex);
	}

	public class LinearAllocator : Beyond.Gameplay.Factory.Unsafe.IAllocator // TypeDefIndex: 79974
	{
		// Fields
		private const int INITIAL_CAPACITY = 512; // Metadata: 0x0263BC0C
		private int m_totalCapacity; // 0x10
		private unsafe byte* m_memory; // 0x18
		[CompilerGenerated]
		private readonly Dictionary<int, int> _freeBlocks_k__BackingField; // 0x20
		private readonly Dictionary<int, int> m_allocations; // 0x28
	
		// Properties
		public Dictionary<int, int> freeBlocks { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
	
		// Nested types
		public struct Allocation // TypeDefIndex: 79972
		{
			// Fields
			public int start; // 0x00
			public int end; // 0x04
			public bool reallocated; // 0x08
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 79973
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<int, int>, int> __9__10_0; // 0x08
			public static Func<KeyValuePair<int, int>, int> __9__10_1; // 0x10
			public static Func<KeyValuePair<int, int>, int> __9__18_0; // 0x18
			public static Func<KeyValuePair<int, int>, int> __9__18_1; // 0x20
	
			// Constructors
			static __c(); // 0x0000000188D08944-0x0000000188D089A8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _Allocate_b__10_0(KeyValuePair<int, int> b); // 0x0000000188D08884-0x0000000188D088B4
			internal int _Allocate_b__10_1(KeyValuePair<int, int> b); // 0x0000000188D088B4-0x0000000188D088E4
			internal int _PrintAllocations_b__18_0(KeyValuePair<int, int> a); // 0x0000000188D088E4-0x0000000188D08914
			internal int _PrintAllocations_b__18_1(KeyValuePair<int, int> b); // 0x0000000188D08914-0x0000000188D08944
		}
	
		// Constructors
		public LinearAllocator(int capacity = 512 /* Metadata: 0x0263BC0A */); // 0x0000000188D08054-0x0000000188D08144
	
		// Methods
		private void _ExpandMemory(); // 0x0000000188D07DBC-0x0000000188D07EE8
		public Allocation Allocate(int size); // 0x0000000188D05F58-0x0000000188D06770
		public void Reserve(int newCapacity); // 0x0000000188D0784C-0x0000000188D07920
		public Allocation Expand(int startIndex, int additionalSize); // 0x0000000188D067F0-0x0000000188D06B40
		public Allocation Resize(int startIndex, int newSize); // 0x0000000188D07920-0x0000000188D07DBC
		private void _MergeAdjacentFreeBlocks(); // 0x0000000188D07EE8-0x0000000188D08054
		public void Free(int startIndex); // 0x0000000188D06BB4-0x0000000188D06F84
		public unsafe void* GetPointer(int offset); // 0x000000018723B190-0x000000018723B1A0
		public void Dispose(); // 0x0000000188D06770-0x0000000188D067F0
		public void PrintAllocations(); // 0x0000000188D06F84-0x0000000188D0784C
		~LinearAllocator(); // 0x0000000188D06B40-0x0000000188D06BB4
	}

	public struct LinearAllocatorUnmanaged : Beyond.Gameplay.Factory.Unsafe.IAllocator // TypeDefIndex: 79975
	{
		// Fields
		private const int INITIAL_CAPACITY = 512; // Metadata: 0x0263BC11
		private int m_totalCapacity; // 0x00
		private unsafe byte* m_memory; // 0x08
		[CompilerGenerated]
		private NativeParallelHashMap<int, int> _freeBlocks_k__BackingField; // 0x10
		private NativeParallelHashMap<int, int> m_allocations; // 0x20
		private bool m_initialized; // 0x30
		private Unity.Collections.Allocator m_allocator; // 0x34
	
		// Properties
		public NativeParallelHashMap<int, int> freeBlocks { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184430480-0x0000000184430490 0x0000000187239680-0x0000000187239690
	
		// Methods
		public void Initialize(int capacity = 512 /* Metadata: 0x0263BC0E */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0263BC10 */); // 0x00000001864DEBF0-0x00000001864DED50
		private void _ExpandMemory(); // 0x0000000185FF1B10-0x0000000185FF1C70
		public LinearAllocator.Allocation Allocate(int size); // 0x0000000185FF2130-0x0000000185FF28C0
		public void Reserve(int newCapacity); // 0x0000000188D05CAC-0x0000000188D05D78
		public LinearAllocator.Allocation Expand(int startIndex, int additionalSize); // 0x0000000188D059A0-0x0000000188D05BFC
		public LinearAllocator.Allocation Resize(int startIndex, int newSize); // 0x0000000188D05D78-0x0000000188D05F58
		private void _MergeAdjacentFreeBlocks(); // 0x0000000185FF1C70-0x0000000185FF20F0
		public void Free(int startIndex); // 0x0000000188D05BFC-0x0000000188D05CAC
		public unsafe void* GetPointer(long offset); // 0x0000000186326020-0x0000000186326040
		public void Dispose(); // 0x0000000188D058DC-0x0000000188D059A0
	}

	internal struct TLSFBlockHeader // TypeDefIndex: 79976
	{
		// Fields
		public const int ALIGNMENT = 8; // Metadata: 0x0263BC13
		public unsafe TLSFBlockHeader* prev; // 0x00
		public unsafe TLSFBlockHeader* next; // 0x08
		public unsafe TLSFBlockHeader* prePhys; // 0x10
		public uint size; // 0x18
		public bool isFree; // 0x1C
	}

	public class TLSFAllocator // TypeDefIndex: 79977
	{
		// Fields
		private const int FIRST_LEVEL_INDEX_COUNT = 32; // Metadata: 0x0263BC14
		private const int SECOND_LEVEL_INDEX_COUNT = 32; // Metadata: 0x0263BC15
		private const int SMALL_BLOCK_SIZE = 256; // Metadata: 0x0263BC16
		private const int ALIGNMENT = 8; // Metadata: 0x0263BC18
		private uint m_flBitmap; // 0x10
		private uint[] m_slBitmap; // 0x18
		private unsafe TLSFBlockHeader*[,] m_freeList; // 0x20
		private IntPtr m_memoryPool; // 0x28
		private uint m_poolSize; // 0x30
		private unsafe TLSFBlockHeader* m_firstBlock; // 0x38
	
		// Constructors
		public TLSFAllocator(uint size); // 0x0000000188D08754-0x0000000188D08884
	
		// Methods
		~TLSFAllocator(); // 0x0000000188D081B0-0x0000000188D08268
		public unsafe void* Allocate(uint size); // 0x0000000188D08144-0x0000000188D081B0
		public unsafe void Free(void* ptr); // 0x0000000188D08268-0x0000000188D082A4
		public uint GetFreeSpace(); // 0x0000000188D082A4-0x0000000188D08310
		private unsafe TLSFBlockHeader* _FindSuitableBlock(uint size); // 0x0000000188D08310-0x0000000188D083C0
		private unsafe void _InsertFreeBlock(TLSFBlockHeader* block); // 0x0000000188D083C0-0x0000000188D084C8
		private unsafe void _RemoveFreeBlock(TLSFBlockHeader* block); // 0x0000000188D085E4-0x0000000188D086E4
		private unsafe void _SplitBlock(TLSFBlockHeader* block, uint size); // 0x0000000188D086E4-0x0000000188D08754
		private unsafe TLSFBlockHeader* _MergeBlock(TLSFBlockHeader* block); // 0x0000000188D08504-0x0000000188D085E4
		private void _MappingInsert(uint size, out int fl, out int sl); // 0x0000000188D084C8-0x0000000188D08504
		private static int _MostSignificantBit(uint value); // 0x0000000188D01E5C-0x0000000188D01EB8
		private static int _FindFirstSet(uint value); // 0x0000000188D01E3C-0x0000000188D01E5C
		private static uint _AlignSize(uint size); // 0x000000018723B1F0-0x000000018723B200
	}

	public class FactoryUnsafeUtil // TypeDefIndex: 79978
	{
		// Fields
		private const uint NO_NODE_ID_RANGE_MIN = 4000000000; // Metadata: 0x0263BC1A
		private const uint NO_NODE_ID_RANGE_MAX = 4294967294; // Metadata: 0x0263BC1F
		private static uint s_nodeId; // 0x00
	
		// Constructors
		public FactoryUnsafeUtil(); // 0x0000000186805BA0-0x0000000186805BB0
		static FactoryUnsafeUtil(); // 0x0000000187220830-0x0000000187220870
	
		// Methods
		public static bool IsManualNodeId(uint id); // 0x0000000188D09D7C-0x0000000188D09D90
		public static uint AllocManualNodeId(); // 0x00000001852C4970-0x00000001852C4A00
		public static bool IsPointInSector(float3 point, float3 center, float3 dir, float checkRad, float checkDist, out float curDistanceSq, out float curCosTheta, bool ignoreY = true /* Metadata: 0x0263BC19 */); // 0x0000000188D09D90-0x0000000188D09F80
		public static unsafe void SwapPointer<T>(ref ref T* p1, ref ref T* p2)
			where T : struct;
		public static IntPtr AddressOf(ref GlobalEnv env); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static void CallFromLuaCheck(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class StructMarshal // TypeDefIndex: 79979
	{
		// Methods
		public static byte[] StructToBytes<T>(T str)
			where T : struct;
		public static byte[] UnmanagedStructToBytes<T>(T value)
			where T : struct;
		public static T BytesToStruct<T>(byte[] bytes, int offset)
			where T : struct;
		public static T BytesToUnmanagedStruct<T>(byte[] bytes, int offset = 0 /* Metadata: 0x0263BC20 */)
			where T : struct;
		public static byte[] FixedList512BytesToBytes<T>([IsReadOnly] in FixedList512Bytes<T> list)
			where T : struct;
		public static FixedList512Bytes<T> BytesToFixedList512Bytes<T>([IsReadOnly] in byte[] bytes)
			where T : struct;
	}
}

namespace Beyond.Gameplay.Factory.Util
{
	public static class JobHandlerExtensions // TypeDefIndex: 79953
	{
		// Extension methods
		public static void SafeComplete(this JobHandle jobHandle); // 0x0000000188D058B8-0x0000000188D058DC
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond // TypeDefIndex: 79327
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime(); // 0x00000001871C7680-0x00000001871C7690
		private static void Initialize(); // 0x00000001871C7690-0x00000001871C7700
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 79328
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 79329
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 79330
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 79331
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 79332
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 79333
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 79334
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace FactoryUIAtlas
{
	public class FactoryLiquidAtlasSOData : ScriptableObject // TypeDefIndex: 79289
	{
		// Fields
		public SerializeFieldDictionary<string, FacItemSubType> m_liquidMaterial; // 0x18
		public SerializeFieldDictionary<FacItemSubType, int> m_liquidMatIndex; // 0x20
	
		// Constructors
		public FactoryLiquidAtlasSOData(); // 0x0000000186F88330-0x0000000186F88400
	
		// Methods
		public bool GetMaterial(string mat, out FacItemSubType matName); // 0x0000000188CD2A10-0x0000000188CD2A74
		public bool GetAtlasMaterialSort(FacItemSubType matName, out int sort); // 0x0000000188CD29AC-0x0000000188CD2A10
		public static FactoryLiquidAtlasSOData CreateOrGet(string path); // 0x0000000188CD28B8-0x0000000188CD29AC
	}

	public class FactoryUIAtlasSOData : ScriptableObject // TypeDefIndex: 79290
	{
		// Fields
		public SerializeFieldDictionary<string, RectInt> m_insertName; // 0x18
		public SerializeFieldDictionary<string, int> m_insertIndex; // 0x20
	
		// Constructors
		public FactoryUIAtlasSOData(); // 0x0000000186DFC260-0x0000000186DFC330
	
		// Methods
		public bool GetRect(string texName, out RectInt rect); // 0x0000000185B399D0-0x0000000185B39AA0
		public bool GetIndex(string texName, out int index); // 0x0000000185732050-0x00000001857320F0
		public static FactoryUIAtlasSOData CreateOrGet(string path); // 0x0000000188CD2A74-0x0000000188CD2B68
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 79288
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 79286
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 79287
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine.HyperGryph.ECS
{
	public static class ColliderComponentExtensions // TypeDefIndex: 79292
	{
		// Nested types
		[CompilerGenerated]
		private struct __c__DisplayClass0_0 // TypeDefIndex: 79291
		{
			// Fields
			public bool enable; // 0x00
		}
	
		// Methods
		[CompilerGenerated]
		internal static void _ToggleCollision_g__Toggle_0_0(Entity rendererEntity, ref EntityManager em, ref __c__DisplayClass0_0 param_000aa90a); // 0x00000001857ABA10-0x00000001857ABB40
		[CompilerGenerated]
		internal static void _UpdateCollisionTRS_g__UpdateTRS_2_0(Entity rendererEntity, [IsReadOnly] in EntityManager em); // 0x000000018586F500-0x000000018586F6E0
	
		// Extension methods
		public static void ToggleCollision(this Entity logicEntity, bool enable, ref EntityManager em); // 0x00000001857AB2D0-0x00000001857ABA10
		public static void Toggle(this ref ECSColliderComponent collision, bool enable); // 0x00000001863636B0-0x00000001863636E0
		public static void UpdateCollisionTRS(this Entity logicEntity, [IsReadOnly] in EntityManager em); // 0x000000018586EDC0-0x000000018586F500
		public static void UpdateCollisionTRS(this ECSColliderComponent c, float3 pos, quaternion rot); // 0x000000018598B920-0x000000018598BA10
		public static void DestroyCollisionWithRenderEntity(this Entity rEntity, ref EntityManager em); // 0x0000000185966F50-0x0000000185967020
		public static void DestroyCollision(this Entity logicEntity, ref EntityManager em); // 0x0000000188CD01A8-0x0000000188CD0520
	}

	public static class ECSExtensions // TypeDefIndex: 79293
	{
		// Methods
		private static unsafe byte* _GetComponentPtrImpl(ref EntityInstanceData entityData, ref EntityTypeInstanceData entityTypeData, int componentId, int componentSize); // 0x0000000188CD0E68-0x0000000188CD0F00
		private static void _SetComponentImpl(ref EntityInstanceData entityData, ref EntityTypeInstanceData entityTypeData, int componentId, [IsReadOnly] in IntPtr component, int componentSize); // 0x00000001859902C0-0x00000001859903A0
	
		// Extension methods
		public static Entity GetEntity(this GroupType group, int index); // 0x00000001857ABF60-0x00000001857ABF80
		public static bool HasComponent([IsReadOnly] this in EntityManager entityManager, [IsReadOnly] in Entity entity, int componentId); // 0x000000018586D390-0x000000018586D3D0
		public static void CreateEntities([IsReadOnly] this in EntityManager em, NativeArray<ComponentType> archetypes, NativeArray<Entity> result); // 0x000000018543E490-0x000000018543E4E0
		public static Entity CreateEntity([IsReadOnly] this in EntityManager entityManager); // 0x0000000188CD07D0-0x0000000188CD0810
		public static Entity CreateEntity([IsReadOnly] this in EntityManager entityManager, NativeArray<ComponentType> archetypes); // 0x000000018573A730-0x000000018573A800
		public static void Is<T>([IsReadOnly] this in EntityManager entityManager, Entity entity, bool flag)
			where T : struct, IComponentECS;
		public static void AddComponent<T>([IsReadOnly] this in EntityManager entityManager, Entity entity)
			where T : struct, IComponentECS;
		public static void AddComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId, [IsReadOnly] in IntPtr component, int componentSize); // 0x0000000185990140-0x00000001859902C0
		public static void AddOrSetComponent<T>([IsReadOnly] this in EntityManager entityManager, Entity entity, T t)
			where T : struct, IComponentECS;
		public static void AddOrSetComponent<T1, T2>([IsReadOnly] this in EntityManager entityManager, Entity entity, T1 t1, T2 t2)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public static void SetComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId, [IsReadOnly] in IntPtr component, int componentSize); // 0x0000000186E62420-0x0000000186E62450
		public static void SetComponents<T0, T1, T2>([IsReadOnly] this in EntityManager entityManager, [IsReadOnly] in Entity entity, [IsReadOnly] in ref T0 t0, [IsReadOnly] in ref T1 t1, [IsReadOnly] in ref T2 t2)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public static void SetComponents<T0, T1, T2, T3>([IsReadOnly] this in EntityManager entityManager, [IsReadOnly] in Entity entity, [IsReadOnly] in ref T0 t0, [IsReadOnly] in ref T1 t1, [IsReadOnly] in ref T2 t2, [IsReadOnly] in ref T3 t3)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS;
		public static void SetComponents<T0, T1, T2, T3, T4>([IsReadOnly] this in EntityManager entityManager, [IsReadOnly] in Entity entity, [IsReadOnly] in ref T0 t0, [IsReadOnly] in ref T1 t1, [IsReadOnly] in ref T2 t2, [IsReadOnly] in ref T3 t3, [IsReadOnly] in ref T4 t4)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS;
		public static unsafe void GetComponentPtrs<T0, T1, T2>([IsReadOnly] this in EntityManager em, [IsReadOnly] in Entity entity, out ref T0* p0, out ref T1* p1, out ref T2* p2)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public static unsafe void GetComponentPtrs<T0, T1>([IsReadOnly] this in EntityManager em, [IsReadOnly] in Entity entity, out ref T0* p0, out ref T1* p1)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS;
		public static EntityManagerRange Iterate([IsReadOnly] this in EntityManager em, [IsReadOnly] in EntityQueryBuilder queryBuilder); // 0x0000000184FA5730-0x0000000184FA5890
		public static EntityManagerRange Iterate<T0, T1, T2>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public static EntityManagerRange Iterate<T0, T1, T2, T3>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5, T6>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5, T6, T7>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5, T6, T7, T8>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS
			where T8 : struct, IComponentECS;
		public static unsafe void GetComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId, int componentSize, void* componentPtr); // 0x0000000188CD0A4C-0x0000000188CD0B3C
		public static bool MoveComponent<T>([IsReadOnly] this in EntityManager entityManager, Entity src, Entity des)
			where T : struct, IComponentECS;
		public static void RemoveComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId); // 0x000000018598FA70-0x000000018598FAC0
		public static void SafeRemoveComponent<T>([IsReadOnly] this in EntityManager entityManager, Entity entity)
			where T : struct, IComponentECS;
		public static void RemoveComponent<T>([IsReadOnly] this in EntityManager entityManager)
			where T : struct, IComponentECS;
		public static bool GetInstance<T, TR>([IsReadOnly] this in EntityManager em, out Entity entity, out ref TR component)
			where T : struct, IComponentECS
			where TR : struct, IComponentECS;
		public static bool GetFirst<T, TR>([IsReadOnly] this in EntityManager entityManager, out Entity entity, out ref TR component)
			where T : struct, IComponentECS
			where TR : struct, IComponentECS;
		public static bool GetFirst<T1, T2, TR>([IsReadOnly] this in EntityManager entityManager, out Entity entity, out ref TR component)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where TR : struct, IComponentECS;
		public static void NotifyEvent<T>([IsReadOnly] this in EntityManager em, Entity logicEntity)
			where T : struct, IFactoryEvent;
		public static void NotifyEvent<T>([IsReadOnly] this in EntityManager em, Entity logicEntity, T t)
			where T : struct, IFactoryEvent;
		public static void NotifyEvent<T1, T2>([IsReadOnly] this in EntityManager em, Entity logicEntity, T1 t1, T2 t2)
			where T1 : struct, IFactoryEvent
			where T2 : struct, IFactoryEvent;
		public static void DispatchEvent<T>([IsReadOnly] this in EntityManager em, Entity entity)
			where T : struct, IReactiveComponent;
		public static void DispatchEvent<T>([IsReadOnly] this in EntityManager em, Entity entity, T t)
			where T : struct, IReactiveComponent;
		public static void DispatchEvent<T1, T2>([IsReadOnly] this in EntityManager em, Entity entity, T1 t1, T2 t2)
			where T1 : struct, IReactiveComponent
			where T2 : struct, IReactiveComponent;
		public static void DestroyEntitiesWithArchetype([IsReadOnly] this in EntityManager entityManager, ref ComponentMask entityMask); // 0x0000000188CD0810-0x0000000188CD0A4C
		public static void DestroyEntities<T>([IsReadOnly] this in EntityManager entityManager)
			where T : struct, IComponentECS;
		public static void DestroyEntities<T1, T2>([IsReadOnly] this in EntityManager entityManager)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public static bool HasEntity<T>([IsReadOnly] this in EntityManager em)
			where T : struct, IComponentECS;
		public static bool HasEntity<T1, T2>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public static int GetEntityCount([IsReadOnly] this in EntityManager em, int compId); // 0x0000000188CD0B3C-0x0000000188CD0CCC
		public static int GetEntityCount([IsReadOnly] this in EntityManager em, int compId0, int compId1); // 0x0000000188CD0CCC-0x0000000188CD0E68
		public static int GetEntityCount<T>([IsReadOnly] this in EntityManager em)
			where T : struct, IComponentECS;
		public static int GetEntityCount<T1, T2>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public static int GetEntityCount<T1, T2, T3>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS;
		public static int GetEntityCount<T1, T2, T3, T4>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS;
		public static int GetEntityCount<T1, T2, T3, T4, T5>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS;
		public static int GetEntityCount<T1, T2, T3, T4, T5, T6>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS;
		public static void EnsureComponent<T>([IsReadOnly] this in EntityManager em, Entity entity)
			where T : struct, IComponentECS;
		public static void EnsureComponent<T>([IsReadOnly] this in EntityManager em, Entity entity, out ref T comp)
			where T : struct, IComponentECS;
		public static ECSSpan<T> GetComponentAsSpan<T>(this GroupType groupType)
			where T : struct, IComponentECS;
		public static ECSSpan<T> GetComponentAsSpan<T>(this GroupType groupType, int componentId)
			where T : struct, IComponentECS;
		public static ComponentMask ComposeComponentMaskAll(this EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6); // 0x0000000186010D50-0x0000000186010E30
		public static ComponentMask ComposeComponentMaskAll(this EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6, int id7); // 0x0000000185E98880-0x0000000185E98980
		public static ComponentMask ComposeComponentMaskAll(this EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6, int id7, int id8); // 0x00000001872399E0-0x0000000187239B00
	}

	public static class HGFactoryRendererBinderExtensions // TypeDefIndex: 79294
	{
		// Extension methods
		public static void RenderWithTRS(this HGFactoryRendererBinderComponent binder, [IsReadOnly] in LocalToWorld localToWorld, float3 viewOffset = default); // 0x0000000188CD2B68-0x0000000188CD2D40
		public static void RenderWithTRS(this HGFactoryRendererBinderComponent binder, float4x4 value, float3 viewOffset = default); // 0x0000000188CD2D40-0x0000000188CD2EEC
		public static void EnableDither(this HGFactoryRendererBinderComponent binder, bool enable, float alphaValue, HGObjectFlags objectFlags); // 0x000000018598F180-0x000000018598F310
		public static void EnableDither(this HGFactoryRendererBinderComponent binder, ref EntityManager rEntityManager, bool enable, float alphaValue, HGObjectFlags objectFlags); // 0x000000018598F310-0x000000018598F460
	}

	public struct PreResolvedComponentAccess<T0> // TypeDefIndex: 79295
		where T0 : struct, IComponentECS
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityInstanceData* m_entitiesPtr;
		[NativeDisableUnsafePtrRestriction]
		private unsafe byte* m_base0;
		private int m_stride0;
	
		// Methods
		public static PreResolvedComponentAccess<T0> Create([IsReadOnly] in EntityManager em, [IsReadOnly] in Entity sampleEntity);
		public unsafe T0* Get([IsReadOnly] in Entity entity);
		private static unsafe void _ResolveBase(ref EntityTypeInstanceData entityTypeData, out byte* basePtr, out int stride);
	}

	public struct PreResolvedComponentAccess<T0, T1> // TypeDefIndex: 79296
		where T0 : struct, IComponentECS
		where T1 : struct, IComponentECS
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityInstanceData* m_entitiesPtr;
		[NativeDisableUnsafePtrRestriction]
		private unsafe byte* m_base0;
		private int m_stride0;
		[NativeDisableUnsafePtrRestriction]
		private unsafe byte* m_base1;
		private int m_stride1;
	
		// Methods
		public static PreResolvedComponentAccess<T0, T1> Create([IsReadOnly] in EntityManager em, [IsReadOnly] in Entity sampleEntity);
		public unsafe void Get([IsReadOnly] in Entity entity, out ref T0* p0, out ref T1* p1);
		private static unsafe void _ResolveBase<T>(ref EntityTypeInstanceData entityTypeData, out byte* basePtr, out int stride)
			where T : struct, IComponentECS;
	}

	public struct PreResolvedComponentAccess<T0, T1, T2> // TypeDefIndex: 79297
		where T0 : struct, IComponentECS
		where T1 : struct, IComponentECS
		where T2 : struct, IComponentECS
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityInstanceData* m_entitiesPtr;
		[NativeDisableUnsafePtrRestriction]
		private unsafe byte* m_base0;
		private int m_stride0;
		[NativeDisableUnsafePtrRestriction]
		private unsafe byte* m_base1;
		private int m_stride1;
		[NativeDisableUnsafePtrRestriction]
		private unsafe byte* m_base2;
		private int m_stride2;
	
		// Methods
		public static PreResolvedComponentAccess<T0, T1, T2> Create([IsReadOnly] in EntityManager em, [IsReadOnly] in Entity sampleEntity);
		public unsafe void Get([IsReadOnly] in Entity entity, out ref T0* p0, out ref T1* p1, out ref T2* p2);
		private static unsafe void _ResolveBase<T>(ref EntityTypeInstanceData entityTypeData, out byte* basePtr, out int stride)
			where T : struct, IComponentECS;
	}

	public struct EntityCommandBuffer // TypeDefIndex: 79300
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
		[CompilerGenerated]
		private readonly EntityManager _entityManager_k__BackingField; // 0x50
	
		// Properties
		public EntityManager entityManager { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000187239B00-0x0000000187239B10 
	
		// Nested types
		public delegate void EntityCommandCallback(Entity entity, ref EntityManager entityManager, ref EntityCommandBufferData buffer); // TypeDefIndex: 79298; 0x00000001811DF7F0-0x00000001811DF810
	
		public struct VirtualEntityMap // TypeDefIndex: 79299
		{
			// Fields
			public Entity virtualEntity; // 0x00
			public Entity realEntity; // 0x08
		}
	
		// Constructors
		public EntityCommandBuffer(ref EntityManager entityManager, Unity.Collections.Allocator allocator); // 0x00000001858B4530-0x00000001858B4650
	
		// Methods
		public ValueTuple<bool, Entity> GetRealEntity(Entity virtualEntity); // 0x000000018598F9B0-0x000000018598FA70
	}

	public static class EntityCommand // TypeDefIndex: 79301
	{
		// Methods
		private static unsafe void* _ComponentCpy<T>(T component)
			where T : struct, IComponentECS;
	
		// Extension methods
		public static EntityCommandBuffer CreateCommandBuffer(this EntityManager entityManager, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0263B7F0 */); // 0x00000001858B44F0-0x00000001858B4530
		public static Entity CreateEntity(this EntityCommandBuffer ecb); // 0x0000000188CD1ED4-0x0000000188CD2060
		public static void DestroyEntity(this EntityCommandBuffer ecb, Entity entity); // 0x0000000188CD2060-0x0000000188CD2104
		public static void AddComponent<T>(this EntityCommandBuffer ecb, Entity entity)
			where T : struct, IComponentECS;
		public static void AddComponent<T>(this EntityCommandBuffer ecb, Entity entity, T component)
			where T : struct, IComponentECS;
		public static void RemoveComponent<T>(this EntityCommandBuffer ecb, Entity entity)
			where T : struct, IComponentECS;
		public static void SetComponent<T>(this EntityCommandBuffer ecb, Entity entity, T component)
			where T : struct, IComponentECS;
		public static void Is<T>(this EntityCommandBuffer ecb, Entity entity, bool flag)
			where T : struct, IComponentECS;
		public static void GetComponent<T>(this EntityCommandBuffer ecb, Entity entity, ref ref T component)
			where T : struct, IComponentECS;
		[Obsolete("Use em.NotifyEvent<T>() (EventChannel route) instead.")]
		public static void NotifyEvent<T>(this EntityCommandBuffer ecb, Entity entity)
			where T : struct, INotificationComponent;
		[Obsolete("Use em.NotifyEvent<T>() (EventChannel route) instead.")]
		public static void NotifyEvent<T>(this EntityCommandBuffer ecb, Entity entity, T t)
			where T : struct, INotificationComponent;
		public static void DispatchEvent<T>(this EntityCommandBuffer ecb, Entity entity)
			where T : struct, IReactiveComponent;
		public static void DispatchEvent<T>(this EntityCommandBuffer ecb, Entity entity, T component)
			where T : struct, IReactiveComponent;
		public static void Playback(this EntityCommandBuffer ecb, bool autoDispose = true /* Metadata: 0x0263B7F1 */); // 0x000000018598F5A0-0x000000018598F9B0
		public static void Dispose(this EntityCommandBuffer ecb); // 0x00000001859911B0-0x00000001859911E0
	}

	public class EntityCommandOp // TypeDefIndex: 79302
	{
		// Fields
		public static readonly int CREATE; // 0x00
		public static readonly int ADD; // 0x04
		public static readonly int REMOVE; // 0x08
		public static readonly int MODIFY; // 0x0C
		public static readonly int DESTROY; // 0x10
		public static readonly int QUERY; // 0x14
	
		// Constructors
		public EntityCommandOp(); // 0x0000000186805BA0-0x0000000186805BB0
		static EntityCommandOp(); // 0x000000018717EF10-0x000000018717EFC0
	}

	public struct EntityCommandBufferData // TypeDefIndex: 79303
	{
		// Fields
		public int op; // 0x00
		public Entity entity; // 0x04
		public CommandBufferComponent componentData; // 0x10
	
		// Methods
		public void Free(); // 0x0000000188CD0F00-0x0000000188CD0F14
	}

	public struct CommandBufferComponent // TypeDefIndex: 79304
	{
		// Fields
		public int componentId; // 0x00
		public int componentSize; // 0x04
		public unsafe void* component; // 0x08
	}

	[BurstCompile]
	public struct EntityCommandBufferV2 : INativeDisposable // TypeDefIndex: 79307
	{
		// Fields
		public static int s_mapSize; // 0x00
		[ReadOnly]
		public NativeQueue<EntityCommandBufferData> buffers; // 0x00
		[ReadOnly]
		public NativeParallelHashMap<ulong, VirtualEntityMap> tempEntities; // 0x18
	
		// Properties
		public bool isEmpty { get; } // 0x0000000188CD1338-0x0000000188CD1374 
	
		// Nested types
		public struct VirtualEntityMap // TypeDefIndex: 79305
		{
			// Fields
			public Entity virtualEntity; // 0x00
			public Entity realEntity; // 0x08
		}
	
		public struct EntityCommandBufferParallelWriter // TypeDefIndex: 79306
		{
			// Fields
			public long tempIdx; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeQueue<EntityCommandBufferData> buffersWriter; // 0x08
			[NativeDisableParallelForRestriction]
			public NativeParallelHashMap<ulong, VirtualEntityMap> tempEntitiesWriter; // 0x20
		}
	
		// Constructors
		public EntityCommandBufferV2(Unity.Collections.Allocator allocator); // 0x0000000188CD124C-0x0000000188CD1338
		static EntityCommandBufferV2(); // 0x0000000188CD1210-0x0000000188CD124C
	
		// Methods
		public ValueTuple<bool, Entity> GetRealEntity(Entity virtualEntity); // 0x0000000188CD10FC-0x0000000188CD11B8
		public void Reset(); // 0x0000000188CD11B8-0x0000000188CD1210
		public void Dispose(); // 0x0000000188CD1090-0x0000000188CD10FC
		public JobHandle Dispose(JobHandle dependsOn); // 0x0000000188CD0FC4-0x0000000188CD1090
		public EntityCommandBufferParallelWriter AsParallelWriter(); // 0x0000000188CD0F14-0x0000000188CD0FC4
	}

	public static class EntityCommandV2 // TypeDefIndex: 79308
	{
		// Fields
		private static readonly Queue<EntityCommandBufferV2> S_POOL; // 0x00
	
		// Constructors
		static EntityCommandV2(); // 0x0000000188CD1E40-0x0000000188CD1ED4
	
		// Methods
		public static void DisposePool(); // 0x0000000188CD17B0-0x0000000188CD18B4
		public static void Recycle(ref EntityCommandBufferV2 buffer); // 0x0000000188CD1D90-0x0000000188CD1E40
		private static unsafe T* _ComponentCpy<T>(T component)
			where T : struct, IComponentECS;
	
		// Extension methods
		public static EntityCommandBufferV2 CreateConcurrentCommandBufferV2(this EntityManager em); // 0x0000000188CD14E4-0x0000000188CD15F0
		public static Entity CreateEntity(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer); // 0x0000000188CD15F0-0x0000000188CD170C
		public static void DestroyEntity(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity); // 0x0000000188CD170C-0x0000000188CD17B0
		public static void AddComponent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, IComponentECS;
		public static void AddComponent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T component)
			where T : struct, IComponentECS;
		public static void RemoveComponent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, IComponentECS;
		public static void SetComponent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T component)
			where T : struct, IComponentECS;
		public static void GetComponent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, ref ref T component)
			where T : struct, IComponentECS;
		[Obsolete("Use EventChannel<T>.ParallelWriter instead.")]
		public static void NotifyEvent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, INotificationComponent;
		[Obsolete("Use EventChannel<T>.ParallelWriter instead.")]
		public static void NotifyEvent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T t)
			where T : struct, INotificationComponent;
		public static void DispatchEvent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, IReactiveComponent;
		public static void DispatchEvent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T component)
			where T : struct, IReactiveComponent;
		public static void Playback(this EntityCommandBufferV2 ecb, bool autoRecycle = true /* Metadata: 0x0263B7F2 */); // 0x0000000188CD18B4-0x0000000188CD1D90
	}

	public struct ECSSpan<T> // TypeDefIndex: 79309
		where T : struct, IComponentECS
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe void* buffer;
		public int length;
	
		// Properties
		public ref T this[int index] { get => default; }
	}

	public struct EntityPool<T0, T1, T2> // TypeDefIndex: 79310
		where T0 : struct
		where T1 : struct
		where T2 : struct
	{
		// Fields
		[CompilerGenerated]
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
		public int defaultSize { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; }
		public Entity this[int index] { get => default; }
		private NativeArray<Entity> entities { get; }
		public bool initialized { get; }
		public int length { get; }
		public int cacheSize { get; }
	
		// Methods
		public bool DecreasePool();
		public bool NeedToResize(int count);
		public Entity Spawn(float3 pos, float3 rot, Matrix4x4 fArgs);
		public Entity Spawn(out bool resized);
		public bool Spawn(int n);
		public void Recycle(int count = 1 /* Metadata: 0x0263B7F3 */);
		public Entity Recycle(Entity entity);
		public static EntityPool<T0, T1, T2> Alloc(int count, Action<Entity, float3, float3, Matrix4x4, float4x4> onSpawn, Action<Entity, float4x4> onRecycle, Action<NativeArray<Entity>, int, float4x4> onAllocate, Action<NativeArray<Entity>, int, float4x4> onDeallocate = null, float4x4 customData = default, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0263B7F4 */, bool autoAllocate = true /* Metadata: 0x0263B7F5 */);
		public void Free();
		private void _Resize();
		public static implicit operator NativeArray<Entity>(EntityPool<T0, T1, T2> pool);
		public NativeArray<Entity> AsReadOnly();
	}

	public class EntityHierarchyContainer // TypeDefIndex: 79313
	{
		// Fields
		public const int INVALID_INDEX = -1; // Metadata: 0x0263B7F6
		private HGArray<Node> m_nodes; // 0x10
	
		// Properties
		public ref EntityTransformData this[int index] { get => default; } // 0x0000000187239B20-0x0000000187239B30 
		public ref EntityTransformData this[uint index] { get => default; } // 0x0000000187239B10-0x0000000187239B20 
	
		// Nested types
		public struct EntityTransformData // TypeDefIndex: 79311
		{
			// Fields
			public uint next; // 0x00
			public LocalTransform localTrans; // 0x04
			public int parentIndex; // 0x24
			public bool dirty; // 0x28
		}
	
		internal struct Node // TypeDefIndex: 79312
		{
			// Fields
			public EntityTransformData value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public EntityHierarchyContainer(Unity.Collections.Allocator allocator); // 0x00000001861FB630-0x00000001861FB6D0
	
		// Methods
		public void Dispose(); // 0x0000000188CD2174-0x0000000188CD21B0
		public void FlushPendingFree(); // 0x0000000185F72040-0x0000000185F720C0
		public uint Size(); // 0x0000000187233000-0x0000000187233010
		public Span<EntityTransformData> AsSpan(); // 0x0000000188CD2104-0x0000000188CD2174
		public LocalTransform WorldTrans(uint handle); // 0x0000000188CD23A4-0x0000000188CD240C
		public LocalTransform WorldTrans(EntityTransformData transform); // 0x0000000188CD224C-0x0000000188CD23A4
		public static unsafe LocalTransform WorldTrans(EntityTransformData transform, EntityTransformData* hierarchyContainer); // 0x0000000185735100-0x0000000185735280
		public uint Create(ref EntityTransformData value); // 0x00000001859676C0-0x0000000185967730
		public void Destroy(uint handle); // 0x00000001867C4A00-0x00000001867C4A20
		public void Reset(); // 0x0000000188CD21F8-0x0000000188CD224C
		public void Reserve(uint newCapacity); // 0x0000000188CD21B0-0x0000000188CD21F8
		public IntPtr Data(); // 0x00000001829260F0-0x0000000182926100
		public ref EntityTransformData Get(uint handle); // 0x0000000187239B10-0x0000000187239B20
		public ref EntityTransformData Get(int handle); // 0x0000000187239B20-0x0000000187239B30
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct EntityQueryBuilder // TypeDefIndex: 79316
	{
		// Fields
		internal unsafe BuilderData* builderDataPtr; // 0x00
	
		// Nested types
		internal struct BuilderData // TypeDefIndex: 79315
		{
			// Fields
			internal UnsafeList<ComponentType> all; // 0x00
			internal UnsafeList<ComponentType> none; // 0x20
	
			// Nested types
			internal enum Type // TypeDefIndex: 79314
			{
				INCLUDE = 0,
				EXCLUDE = 1
			}
	
			// Methods
			public ComponentMask ComponentMask([IsReadOnly] in EntityManager em, Type type); // 0x0000000184FA5890-0x0000000184FA5AD0
		}
	
		// Constructors
		public unsafe EntityQueryBuilder(int maxCount = 8 /* Metadata: 0x0263B7F7 */); // 0x0000000185160CA0-0x0000000185161550
	
		// Methods
		public static EntityQueryBuilder Create(int maxCount = 8 /* Metadata: 0x0263B7F8 */); // 0x00000001851603B0-0x0000000185160C50
		public EntityQueryBuilder WithAll<T>()
			where T : struct, IComponentECS;
		public EntityQueryBuilder WithAll<T1, T2>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public EntityQueryBuilder WithAll<T1, T2, T3>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS;
		public EntityQueryBuilder WithAll<T1, T2, T3, T4>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS;
		public EntityQueryBuilder WithAll<T1, T2, T3, T4, T5>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS;
		public EntityQueryBuilder WithAll<T1, T2, T3, T4, T5, T6>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS;
		public EntityQueryBuilder WithAll<T1, T2, T3, T4, T5, T6, T7>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS;
		public EntityQueryBuilder WithAll<T1, T2, T3, T4, T5, T6, T7, T8>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS
			where T8 : struct, IComponentECS;
		public EntityQueryBuilder WithNone<T>()
			where T : struct, IComponentECS;
		public EntityQueryBuilder WithNone<T1, T2>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public EntityQueryBuilder WithNone<T1, T2, T3>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS;
		public EntityQueryBuilder WithNone<T1, T2, T3, T4>()
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS;
		public EntityManagerRange Build(ref EntityManager em); // 0x0000000187834D8C-0x0000000187834DD4
	}

	public static class EntityQueryV2 // TypeDefIndex: 79320
	{
		// Nested types
		public struct BlockRange // TypeDefIndex: 79317
		{
			// Fields
			public int beginGroupIdx; // 0x00
			public int endGroupIdx; // 0x04
			public int beginGroupElemBeginIdx; // 0x08
			public int endGroupElemEndIdx; // 0x0C
		}
	
		[NoAlias]
		public struct QueryResultDefer : IDisposable // TypeDefIndex: 79318
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public unsafe UnsafeList<GroupType>* groups; // 0x00
			[NativeDisableUnsafePtrRestriction]
			public unsafe UnsafeList<BlockRange>* blockRanges; // 0x08
			[NativeDisableUnsafePtrRestriction]
			private unsafe UnsafeList<int>* m_rangeCountStore; // 0x10
	
			// Properties
			public int rangeCount { get; set; } // 0x0000000188CD35CC-0x0000000188CD35E8 0x000000018561CBB0-0x000000018561CBD0
			public bool valid { get; } // 0x0000000188CD35E8-0x0000000188CD3600 
			public unsafe int* rangeCountPtr { get; } // 0x000000018561EEE0-0x000000018561EF00 
	
			// Methods
			public void InitList(Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0263B810 */, int initialCapacity = 32 /* Metadata: 0x0263B811 */); // 0x0000000186A9FC60-0x0000000186A9FD60
			public void ReleaseList(); // 0x0000000188CD3304-0x0000000188CD33CC
			public void Reset(); // 0x000000018561CB80-0x000000018561CBB0
			public ref BlockRange BlockRangeAt(int index); // 0x0000000188CD2EEC-0x0000000188CD2F34
			public ref GroupType GroupAt(int index); // 0x0000000188CD32C0-0x0000000188CD3304
			public void Foreach(Func<GroupType, bool> callback); // 0x0000000188CD31E0-0x0000000188CD32C0
			public int EntityCount(); // 0x0000000188CD3104-0x0000000188CD31E0
			public void Dispose(); // 0x0000000188CD2F34-0x0000000188CD2F58
			public void Dispose(JobHandle jobHandle, bool inCrossFrame = false /* Metadata: 0x0263B812 */); // 0x0000000188CD2F58-0x0000000188CD3104
			public override string ToString(); // 0x0000000188CD33CC-0x0000000188CD35CC
		}
	
		[NoAlias]
		public struct QueryResult : IDisposable // TypeDefIndex: 79319
		{
			// Fields
			[ReadOnly]
			public NativeList<GroupType> groups; // 0x00
			[ReadOnly]
			public NativeList<BlockRange> blockRanges; // 0x10
	
			// Properties
			public int rangeCount { get; } // 0x00000001878379F0-0x0000000187837A20 
			public bool isEmpty { get; } // 0x0000000188CD3E54-0x0000000188CD3E7C 
	
			// Methods
			public override string ToString(); // 0x0000000188CD3C1C-0x0000000188CD3E54
			public void Foreach(Func<GroupType, bool> callback); // 0x0000000188CD3A8C-0x0000000188CD3C1C
			public int EntityCount(); // 0x0000000188CD390C-0x0000000188CD3A8C
			public void Dispose(); // 0x0000000188CD38E8-0x0000000188CD390C
			public void Dispose(JobHandle jobHandle, bool inCrossFrame = false /* Metadata: 0x0263B813 */); // 0x000000018515E090-0x000000018515E300
		}
	
		// Extension methods
		public static QueryResult Query(this EntityManager em, ref EntityQueryBuilder builder, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0263B7FB */, int jobCount = -1 /* Metadata: 0x0263B7FC */); // 0x000000018515E300-0x000000018515F3C0
		public static ref QueryResultDefer QueryDefer(this EntityManager em, ref EntityQueryBuilder builder, ref QueryResultDefer qrd, int jobCount = -1 /* Metadata: 0x0263B7FD */); // 0x0000000188CD2778-0x0000000188CD2838
		public static QueryResult Query<T>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0263B7FE */, int jobCount = -1 /* Metadata: 0x0263B7FF */)
			where T : struct, IComponentECS;
		public static QueryResult Query<T0, T1>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0263B800 */, int jobCount = -1 /* Metadata: 0x0263B801 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0263B802 */, int jobCount = -1 /* Metadata: 0x0263B803 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0263B804 */, int jobCount = -1 /* Metadata: 0x0263B805 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3, T4>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0263B806 */, int jobCount = -1 /* Metadata: 0x0263B807 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0263B808 */, int jobCount = -1 /* Metadata: 0x0263B809 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0263B80A */, int jobCount = -1 /* Metadata: 0x0263B80B */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6, T7>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0263B80C */, int jobCount = -1 /* Metadata: 0x0263B80D */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0263B80E */, int jobCount = -1 /* Metadata: 0x0263B80F */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS
			where T8 : struct, IComponentECS;
		public static QueryResultDefer GetBlockRangesDefer(this EntityManagerRange range, int jobCount, ref QueryResultDefer qr); // 0x0000000188CD240C-0x0000000188CD2778
		public static QueryResult GetBlockRanges(this EntityManagerRange range, Unity.Collections.Allocator allocator, int jobCount); // 0x0000000185162B40-0x0000000185163B80
	}

	[BurstCompile]
	public static class QueryResultWrapper // TypeDefIndex: 79323
	{
		// Nested types
		public unsafe delegate void Wrapper_000000E7_PostfixBurstDelegate(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount); // TypeDefIndex: 79321; 0x00000001811CDB70-0x00000001811CDB90
	
		internal static class Wrapper_000000E7_BurstDirectCall // TypeDefIndex: 79322
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Wrapper_000000E7_BurstDirectCall(); // 0x000000018633AD40-0x000000018633AD50
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000aaaa1); // 0x0000000184FEF780-0x0000000184FEF8C0
			private static IntPtr GetFunctionPointer(); // 0x0000000184FEF590-0x0000000184FEF710
			public static void Constructor(); // 0x000000018633C1E0-0x000000018633C270
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount); // 0x0000000184FEF300-0x0000000184FEF590
		}
	
		// Methods
		[BurstCompile]
		public static unsafe void Wrapper(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount); // 0x0000000184FEF040-0x0000000184FEF300
		[BurstCompile]
		public static unsafe void Wrapper_BurstManaged(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount); // 0x0000000188CD3600-0x0000000188CD38E8
	}
}
