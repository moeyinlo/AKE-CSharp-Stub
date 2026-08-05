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
using IFix.Core;
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

// Image 14: FactoryUnsafe.Gameplay.Beyond.dll - Assembly: FactoryUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 49542-50200
[assembly: BurstCompiler.StaticTypeReinit(typeof(Beyond.Gameplay.Factory.Unsafe.EntityExtensions._SetRenderEntityFlashStatue_00000BB1_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(QueryResultWrapper.Wrapper_000000E7_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnsafeJobFuncPointers.ApplyPerDrawRender_000008F6_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnsafeJobFuncPointers.GetQueryStateIconPath_000008F8_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnsafeJobFuncPointers.GetLogicEntityWithPos_000008FA_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnsafeJobFuncPointers.QueryBuildingStateFunc_000008FC_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnsafeJobFuncPointers.SetEntityFlashStatueFunc_000008FE_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectJob._BuildDismissState_0000091C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectJob._Repair0_0000091E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectJob._Repair1_0000091F_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildStart_00000928_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildEnd_0000092A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildCutoffStateStart_0000092B_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildCutoffStateEnd_0000092C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildCutoffStateProcess_0000092D_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._CutoffStateStart_00000931_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._CutoffStateEnd_00000932_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._CutoffStateProcess_00000933_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BuildStateProcess_00000936_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HighLightStart_00000937_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HighLightEnd_00000938_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HighLightProcess_00000939_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._FigureStart_0000093A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildProcess_00000929_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._FigureProcess_0000093B_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._FigureEnd_0000093C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._PreSelectStart_00000950_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HintProcess_0000093F_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadStart_00000940_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadEnd_00000941_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadProcess_00000942_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadInvalidStart_00000943_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadInvalidEnd_00000944_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadInvalidProcess_00000945_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._Repair0Process_00000948_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._Repair1Start_00000949_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._Repair1End_0000094A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._Repair1Process_0000094B_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BlueprintProcessInternal_0000094D_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BlueprintEnd_0000094E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HintStart_0000093D_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BlueprintStart_0000094F_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._PreSelectProcess_00000952_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._ContinuationStart_00000953_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._ContinuationEnd_00000954_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._ContinuationProcess_00000955_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._SocialSharingStart_00000956_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._PowerInteractionStart_00000957_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._PowerInteractionEnd_00000958_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._InvalidOverlapPlaceStart_00000959_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._InvalidOverlapPlaceEnd_0000095A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(BurstBridge.SamplePredictCargo_00000B99_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(Beyond.Gameplay.Factory.Unsafe.EntityExtensions.QueryBuildingState_00000B9D_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(Beyond.Gameplay.Factory.Unsafe.EntityExtensions.SetFlashStatue_00000BB0_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HintEnd_0000093E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._PreSelectEnd_00000951_BurstDirectCall))]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 50194
{
	// Methods
	internal static uint ComputeStringHash(string s); // 0x000000018332B360-0x000000018332B3C0
}

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__156508394 // TypeDefIndex: 50195
{
	// Methods
	public static void CreateJobReflectionData(); // 0x000000018152AC60-0x0000000181530340
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit(); // 0x0000000181530340-0x0000000181530350
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 50196
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize(); // 0x000000018478C340-0x000000018478CAA0
}

namespace Beyond
{
	public struct FixedStack<T> : IDisposable // TypeDefIndex: 49581
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

	public struct HGArray<T> // TypeDefIndex: 49582
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

	public static class AssetInstanceParseUtil // TypeDefIndex: 49583
	{
		// Methods
		[IDTag(1)]
		public static NativeArray<int> Parse(UnityEngine.Object[] objects); // 0x00000001869B64A8-0x00000001869B6598
		[IDTag(0)]
		public static int Parse(UnityEngine.Object obj); // 0x00000001869B6598-0x00000001869B662C
		public static object Get(int id); // 0x0000000183DB9D80-0x0000000183DB9E00
		public static T Get<T>(int id);
	}
}

namespace Beyond.Gameplay
{
	public class FactorySetting : ScriptableObject // TypeDefIndex: 49590
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
		[Range(0.001f, 1f)]
		public float buildingDither; // 0x178
		[Range(0.001f, 1f)]
		public float pedestalDither; // 0x17C
		[Unit(Units.Meter)]
		public float ditherTargetField; // 0x180
		[Unit(Units.Meter)]
		public float ditherDistance; // 0x184
		[Range(0f, 1f)]
		public float lowFrameRate; // 0x188
	
		// Constructors
		public FactorySetting(); // 0x0000000184D5D120-0x0000000184D5D1E0
	
		// Methods
		private void OnEnable(); // 0x0000000184D73980-0x0000000184D739C0
	}

	[Serializable]
	public struct FactoryEffectSetting // TypeDefIndex: 49591
	{
		// Fields
		public int maxEffectCount; // 0x00
		public float effectInterval; // 0x04
	}
}

namespace Beyond.Gameplay.Factory
{
	public static class Archetypes // TypeDefIndex: 49592
	{
		// Properties
		public static NativeArray<ComponentType> empty { get; } // 0x0000000183F3F2D0-0x0000000183F3F3B0 
		public static NativeArray<ComponentType> env { get; } // 0x000000018473A0D0-0x000000018473A1F0 
		public static NativeArray<ComponentType> connection { get; } // 0x00000001837B14F0-0x00000001837B1600 
		public static NativeArray<ComponentType> buildingUnit { get; } // 0x00000001837AF9E0-0x00000001837AFCC0 
		public static NativeArray<ComponentType> powerStation { get; } // 0x0000000183F3FC70-0x0000000183F3FD50 
		public static NativeArray<ComponentType> furnace { get; } // 0x0000000183F41750-0x0000000183F41880 
		public static NativeArray<ComponentType> grinder { get; } // 0x0000000183F41880-0x0000000183F41950 
		public static NativeArray<ComponentType> winder { get; } // 0x00000001869B6378-0x00000001869B64A8 
		public static NativeArray<ComponentType> componentMc { get; } // 0x0000000183F40270-0x0000000183F403A0 
		public static NativeArray<ComponentType> shaper { get; } // 0x0000000183F405B0-0x0000000183F406E0 
		public static NativeArray<ComponentType> fillingPowderMc { get; } // 0x0000000183F3FB40-0x0000000183F3FC70 
		public static NativeArray<ComponentType> thickener { get; } // 0x0000000183F40F60-0x0000000183F41090 
		public static NativeArray<ComponentType> hub { get; } // 0x00000001841A2E20-0x00000001841A2EB0 
		public static NativeArray<ComponentType> subHub { get; } // 0x00000001841A2F40-0x00000001841A2FD0 
		public static NativeArray<ComponentType> miner { get; } // 0x0000000183F413F0-0x0000000183F414B0 
		public static NativeArray<ComponentType> toolsAssemblingMc { get; } // 0x0000000183F406E0-0x0000000183F40810 
		public static NativeArray<ComponentType> seedCollector { get; } // 0x0000000183F40C80-0x0000000183F40DB0 
		public static NativeArray<ComponentType> planter { get; } // 0x0000000183F411E0-0x0000000183F41310 
		public static NativeArray<ComponentType> powerDiffuser { get; } // 0x00000001841A3380-0x00000001841A33F0 
		public static NativeArray<ComponentType> powerPole { get; } // 0x00000001841A3310-0x00000001841A3380 
		public static NativeArray<ComponentType> travelPole { get; } // 0x00000001841A32A0-0x00000001841A3310 
		public static NativeArray<ComponentType> loader { get; } // 0x00000001869B6138-0x00000001869B61E4 
		public static NativeArray<ComponentType> unloader { get; } // 0x0000000183F40EB0-0x0000000183F40F60 
		public static NativeArray<ComponentType> storage { get; } // 0x00000001841A3180-0x00000001841A3210 
		public static NativeArray<ComponentType> powerTerminal { get; } // 0x00000001869B61E4-0x00000001869B6290 
		public static NativeArray<ComponentType> powerPort { get; } // 0x00000001841A3060-0x00000001841A30F0 
		public static NativeArray<ComponentType> facBattle { get; } // 0x0000000183F404D0-0x0000000183F405B0 
		public static NativeArray<ComponentType> pump { get; } // 0x0000000183F40DB0-0x0000000183F40EB0 
		public static NativeArray<ComponentType> liquidStorage { get; } // 0x0000000183F41B40-0x0000000183F41C20 
		public static NativeArray<ComponentType> mixPool { get; } // 0x0000000183F403A0-0x0000000183F404D0 
		public static NativeArray<ComponentType> gasReactor { get; } // 0x0000000183F41A00-0x0000000183F41B40 
		public static NativeArray<ComponentType> squirter { get; } // 0x00000001869B6290-0x00000001869B6378 
		public static NativeArray<ComponentType> dumper { get; } // 0x0000000183F41C20-0x0000000183F41D10 
		public static NativeArray<ComponentType> liquidCleaner { get; } // 0x00000001841A30F0-0x00000001841A3180 
		public static NativeArray<ComponentType> xiraniteOven { get; } // 0x0000000183F409B0-0x0000000183F40B00 
		public static NativeArray<ComponentType> liquidPurifier { get; } // 0x0000000183F40810-0x0000000183F409B0 
		public static NativeArray<ComponentType> dismantler { get; } // 0x00000001869B5E38-0x00000001869B5F68 
		public static NativeArray<ComponentType> transmuter { get; } // 0x0000000183F40B00-0x0000000183F40C80 
		public static NativeArray<ComponentType> vaporizer { get; } // 0x0000000183F3FF80-0x0000000183F400B0 
		public static NativeArray<ComponentType> bus { get; } // 0x0000000183F400B0-0x0000000183F40190 
		public static NativeArray<ComponentType> busRootRender { get; } // 0x00000001869B58D8-0x00000001869B59E0 
		public static NativeArray<ComponentType> busSubRender { get; } // 0x00000001869B59E0-0x00000001869B5AE8 
		public static NativeArray<ComponentType> hsBus { get; } // 0x0000000183F40190-0x0000000183F40270 
		public static NativeArray<ComponentType> hsBusSource { get; } // 0x00000001841A2EB0-0x00000001841A2F40 
		public static NativeArray<ComponentType> udPipeLoader { get; } // 0x0000000183F414B0-0x0000000183F41600 
		public static NativeArray<ComponentType> udPipeUnloader { get; } // 0x0000000183F41600-0x0000000183F41750 
		public static NativeArray<ComponentType> liquidCleanGate { get; } // 0x00000001869B5F68-0x00000001869B6050 
		public static NativeArray<ComponentType> liquidRecycleGate { get; } // 0x00000001869B6050-0x00000001869B6138 
		public static NativeArray<ComponentType> carrier { get; } // 0x00000001841A2FD0-0x00000001841A3060 
		public static NativeArray<ComponentType> marker { get; } // 0x00000001841A3210-0x00000001841A32A0 
		public static NativeArray<ComponentType> decoration { get; } // 0x00000001869B5AE8-0x00000001869B5E38 
		public static NativeArray<ComponentType> soil { get; } // 0x0000000183F41D10-0x0000000183F42070 
		public static NativeArray<ComponentType> pipeConditioner { get; } // 0x0000000183F41090-0x0000000183F411E0 
		public static NativeArray<ComponentType> conveyorLogistics { get; } // 0x0000000183F3FD50-0x0000000183F3FE30 
		public static NativeArray<ComponentType> pipeLogistics { get; } // 0x0000000183F41310-0x0000000183F413F0 
		public static NativeArray<ComponentType> logConditioner { get; } // 0x0000000183F3FE30-0x0000000183F3FF80 
		public static NativeArray<ComponentType> buildingFakeUnit { get; } // 0x00000001848507F0-0x0000000184850B80 
		public static NativeArray<ComponentType> buildingRenderOnlyUnit { get; } // 0x00000001848A9780-0x00000001848A9A80 
		public static NativeArray<ComponentType> buildingPreviewUnit { get; } // 0x0000000184861980-0x0000000184861CE0 
		public static NativeArray<ComponentType> buildingGuideHintUnit { get; } // 0x000000018488E3D0-0x000000018488E700 
		public static NativeArray<ComponentType> conveyor { get; } // 0x00000001837AEEF0-0x00000001837AF110 
		public static NativeArray<ComponentType> guideConveyor { get; } // 0x000000018496FB00-0x000000018496FD70 
		public static NativeArray<ComponentType> pipe { get; } // 0x00000001837AED10-0x00000001837AEEF0 
		public static NativeArray<ComponentType> pipeHolder { get; } // 0x00000001837B11F0-0x00000001837B14F0 
		public static NativeArray<ComponentType> cargo { get; } // 0x00000001837AF410-0x00000001837AF700 
		public static NativeArray<ComponentType> buildingRender { get; } // 0x00000001837AF700-0x00000001837AF9E0 
		public static NativeArray<ComponentType> buildingRootRender { get; } // 0x00000001837B1600-0x00000001837B16B0 
		public static NativeArray<ComponentType> buildingSubRender { get; } // 0x0000000183F41950-0x0000000183F41A00 
		public static NativeArray<ComponentType> pedestalRender { get; } // 0x00000001837AF110-0x00000001837AF410 
		public static NativeArray<ComponentType> conveyorLeftRender { get; } // 0x0000000183A27C30-0x0000000183A27E40 
		public static NativeArray<ComponentType> conveyorRightRender { get; } // 0x0000000183A27A20-0x0000000183A27C30 
		public static NativeArray<ComponentType> conveyorMidRender { get; } // 0x0000000183A25FD0-0x0000000183A261E0 
		public static NativeArray<ComponentType> figureConveyorLogisticsRender { get; } // 0x0000000183F3D020-0x0000000183F3D200 
		public static NativeArray<ComponentType> figurePipeHolderRender { get; } // 0x0000000183F3D200-0x0000000183F3D3E0 
		public static NativeArray<ComponentType> figureLeftRender { get; } // 0x0000000183F3D3E0-0x0000000183F3D5C0 
		public static NativeArray<ComponentType> figureRightRender { get; } // 0x0000000183F3D5C0-0x0000000183F3D7A0 
		public static NativeArray<ComponentType> figureMidRender { get; } // 0x0000000183F3D7A0-0x0000000183F3D980 
		public static NativeArray<ComponentType> conveyorPreviewRender { get; } // 0x0000000183F3D980-0x0000000183F3DB60 
		public static NativeArray<ComponentType> pipePreviewRender { get; } // 0x0000000183F3E030-0x0000000183F3E1E0 
		public static NativeArray<ComponentType> pipeComRender { get; } // 0x0000000184656D30-0x0000000184656EC0 
		public static NativeArray<ComponentType> pipeLeftRender { get; } // 0x0000000183A23650-0x0000000183A23860 
		public static NativeArray<ComponentType> pipeMidRender { get; } // 0x0000000183A25780-0x0000000183A25990 
		public static NativeArray<ComponentType> pipeRightRender { get; } // 0x0000000183A23860-0x0000000183A23A70 
		public static NativeArray<ComponentType> pipeTrackLeftPreviewRender { get; } // 0x0000000183A230B0-0x0000000183A23290 
		public static NativeArray<ComponentType> pipeTrackMidPreviewRender { get; } // 0x0000000183A23290-0x0000000183A23470 
		public static NativeArray<ComponentType> pipeTrackRightPreviewRender { get; } // 0x0000000183A23470-0x0000000183A23650 
		public static NativeArray<ComponentType> outputUIRenderer { get; } // 0x0000000183F3F830-0x0000000183F3F9B0 
		public static NativeArray<ComponentType> envGeneratorUIRenderer { get; } // 0x0000000183F3F6B0-0x0000000183F3F830 
		public static NativeArray<ComponentType> wireRenderer { get; } // 0x0000000183A26400-0x0000000183A26590 
		public static NativeArray<ComponentType> unitStatusUIRenderer { get; } // 0x0000000183F3F530-0x0000000183F3F6B0 
		public static NativeArray<ComponentType> portPreviewUIRenderer { get; } // 0x0000000183F3F9B0-0x0000000183F3FB40 
		public static NativeArray<ComponentType> gridRenderer { get; } // 0x0000000183F3DB60-0x0000000183F3DD40 
		public static NativeArray<ComponentType> gridMainRegionRenderer { get; } // 0x0000000183F3DD40-0x0000000183F3DF20 
		public static NativeArray<ComponentType> portStatusUIRenderer { get; } // 0x0000000183F3F3B0-0x0000000183F3F530 
		public static NativeArray<ComponentType> scope { get; } // 0x00000001836BA990-0x00000001836BAAB0 
	
		// Methods
		public static NativeArray<ComponentType> CreateArchetype(NativeArray<ComponentType> baseArchetype, params ComponentType[] extraTypes); // 0x00000001837B0BA0-0x00000001837B0D70
		public static NativeArray<ComponentType> Select(string templateId); // 0x000000018398E540-0x000000018398F2C0
	}

	[DataN(capacity = 16, tSize = 4, ring = false)]
	[NoAlias]
	public struct AdditiveEffectRequestStack<T> : IEnumerable<T> // TypeDefIndex: 49595
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x0232E9FC
		public const int CAPACITY = 16; // Metadata: 0x0232E9FD
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x0232E9FE
		public const int INVALID_INDEX = -1; // Metadata: 0x0232E9FF
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49593
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49594
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe AdditiveEffectRequestStack(int initialCapacity = 16 /* Metadata: 0x0232E9FA */, bool autoExtend = false /* Metadata: 0x0232E9FB */);
	
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

	public struct BlueprintSlotContainer // TypeDefIndex: 49597
	{
		// Fields
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref BlueprintSlotInfo this[uint index] { get => default; } // 0x00000001836B8770-0x00000001836B87D0 
	
		// Nested types
		internal struct Node // TypeDefIndex: 49596
		{
			// Fields
			public BlueprintSlotInfo value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public BlueprintSlotContainer(Unity.Collections.Allocator allocator); // 0x00000001844396A0-0x0000000184439740
	
		// Methods
		public void Dispose(); // 0x00000001869BBC38-0x00000001869BBCA8
		public void FlushPendingFree(); // 0x00000001834FEFB0-0x00000001834FF040
		public uint Create(ref BlueprintSlotInfo value); // 0x00000001836BABE0-0x00000001836BACC0
		public void Destroy(uint handle); // 0x00000001869BBBAC-0x00000001869BBC38
		public void Reset(); // 0x0000000184439590-0x0000000184439600
	}

	public struct ConveyorExtContainer // TypeDefIndex: 49600
	{
		// Fields
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref ConveyorExt this[int index] { [IDTag(0)] get => default; } // 0x00000001869BD598-0x00000001869BD610 
		public ref ConveyorExt this[uint index] { [IDTag(1)] get => default; } // 0x00000001834CDAB0-0x00000001834CDB20 
	
		// Nested types
		public struct ConveyorExt // TypeDefIndex: 49598
		{
			// Fields
			public int outCargoIndex; // 0x00
			public int cargoBeginIndex; // 0x04
			public int cargoEndIndex; // 0x08
	
			// Methods
			public void Reset(); // 0x00000001834CC450-0x00000001834CC480
		}
	
		internal struct Node // TypeDefIndex: 49599
		{
			// Fields
			public ConveyorExt value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public ConveyorExtContainer(Unity.Collections.Allocator allocator); // 0x0000000184439600-0x00000001844396A0
	
		// Methods
		public void Dispose(); // 0x00000001869BD3E4-0x00000001869BD454
		public void FlushPendingFree(); // 0x00000001834FF100-0x00000001834FF1C0
		public uint Size(); // 0x00000001869BD534-0x00000001869BD598
		public Span<ConveyorExt> AsSpan(); // 0x00000001869BD2A8-0x00000001869BD358
		public uint Create(ref ConveyorExt value); // 0x0000000183B2A120-0x0000000183B2A180
		public void Destroy(uint handle); // 0x00000001869BD358-0x00000001869BD3E4
		public void Reset(); // 0x0000000184439520-0x0000000184439590
		public void Reserve(uint newCapacity); // 0x00000001869BD4B4-0x00000001869BD534
		public IntPtr Data(); // 0x00000001838AC1F0-0x00000001838AC240
		public ref ConveyorExt Get(uint handle); // 0x00000001869BD454-0x00000001869BD4B4
	}

	public struct ConveyorInfoAllocator // TypeDefIndex: 49602
	{
		// Fields
		private LinearAllocatorUnmanaged m_allocator; // 0x00
	
		// Properties
		public unsafe void* memoryPtr { get; } // 0x00000001869BE1B4-0x00000001869BE1C0 
	
		// Nested types
		public struct Info // TypeDefIndex: 49601
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
		public static unsafe ConveyorInfoAllocator* Create(int capacity); // 0x00000001834D5D00-0x00000001834D5DB0
		public static unsafe void Destroy(ConveyorInfoAllocator* allocator); // 0x00000001869BE064-0x00000001869BE090
		public LinearAllocator.Allocation Allocate(int count); // 0x0000000183B296E0-0x0000000183B29750
		public LinearAllocator.Allocation Resize(LinearAllocator.Allocation allocation, int newCount); // 0x00000001869BE0F4-0x00000001869BE1B4
		public void Free(uint memoryOffset); // 0x00000001869BE090-0x00000001869BE0F4
		public long CalculateSize(uint memoryOffset); // 0x00000001869BDFAC-0x00000001869BE014
		public unsafe Info* GetInfo(long offset); // 0x0000000185392604-0x000000018539260C
		public void DebugPrint(); // 0x00000001869BE014-0x00000001869BE064
	}

	public struct Data2<T> // TypeDefIndex: 49603
		where T : struct
	{
		// Fields
		public T port0;
		public T port1;
	
		// Properties
		public int length { get; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data4<T> // TypeDefIndex: 49604
		where T : struct
	{
		// Fields
		public Data2<T> port0;
		public Data2<T> port1;
	
		// Properties
		public int length { get; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data8<T> // TypeDefIndex: 49605
		where T : struct
	{
		// Fields
		public Data4<T> port0;
		public Data4<T> port1;
	
		// Properties
		public int length { get; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data16<T> // TypeDefIndex: 49606
		where T : struct
	{
		// Fields
		public Data8<T> port0;
		public Data8<T> port1;
	
		// Properties
		public int length { get; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data32<T> // TypeDefIndex: 49607
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
	public struct EntityData4<T> : IEnumerable<T> // TypeDefIndex: 49610
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0232EA02
		public const int CAPACITY = 4; // Metadata: 0x0232EA03
		public const int CAPACITY_MINUS_ONE = 3; // Metadata: 0x0232EA04
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA05
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49608
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49609
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData4(int initialCapacity = 4 /* Metadata: 0x0232EA00 */, bool autoExtend = false /* Metadata: 0x0232EA01 */);
	
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
	public struct EntityData8<T> : IEnumerable<T> // TypeDefIndex: 49613
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0232EA08
		public const int CAPACITY = 8; // Metadata: 0x0232EA09
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x0232EA0A
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA0B
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49611
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49612
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData8(int initialCapacity = 8 /* Metadata: 0x0232EA06 */, bool autoExtend = false /* Metadata: 0x0232EA07 */);
	
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
	public struct EntityData32<T> : IEnumerable<T> // TypeDefIndex: 49616
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0232EA0E
		public const int CAPACITY = 32; // Metadata: 0x0232EA0F
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x0232EA10
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA11
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49614
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49615
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData32(int initialCapacity = 32 /* Metadata: 0x0232EA0C */, bool autoExtend = false /* Metadata: 0x0232EA0D */);
	
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
	public struct EntityData64<T> : IEnumerable<T> // TypeDefIndex: 49619
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0232EA15
		public const int CAPACITY = 64; // Metadata: 0x0232EA16
		public const int CAPACITY_MINUS_ONE = 63; // Metadata: 0x0232EA18
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA19
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49617
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49618
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData64(int initialCapacity = 64 /* Metadata: 0x0232EA12 */, bool autoExtend = false /* Metadata: 0x0232EA14 */);
	
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
	public struct EntityData128<T> : IEnumerable<T> // TypeDefIndex: 49622
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0232EA1D
		public const int CAPACITY = 128; // Metadata: 0x0232EA1E
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x0232EA20
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA22
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49620
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49621
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData128(int initialCapacity = 128 /* Metadata: 0x0232EA1A */, bool autoExtend = false /* Metadata: 0x0232EA1C */);
	
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
	public struct EntityData256<T> : IEnumerable<T> // TypeDefIndex: 49625
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0232EA26
		public const int CAPACITY = 256; // Metadata: 0x0232EA27
		public const int CAPACITY_MINUS_ONE = 255; // Metadata: 0x0232EA29
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA2B
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49623
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49624
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData256(int initialCapacity = 256 /* Metadata: 0x0232EA23 */, bool autoExtend = false /* Metadata: 0x0232EA25 */);
	
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
	public struct EntityData512<T> : IEnumerable<T> // TypeDefIndex: 49628
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0232EA2F
		public const int CAPACITY = 512; // Metadata: 0x0232EA30
		public const int CAPACITY_MINUS_ONE = 511; // Metadata: 0x0232EA32
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA34
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49626
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49627
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData512(int initialCapacity = 512 /* Metadata: 0x0232EA2C */, bool autoExtend = false /* Metadata: 0x0232EA2E */);
	
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
	public struct EntityData1024<T> : IEnumerable<T> // TypeDefIndex: 49631
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x0232EA38
		public const int CAPACITY = 1024; // Metadata: 0x0232EA39
		public const int CAPACITY_MINUS_ONE = 1023; // Metadata: 0x0232EA3B
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA3D
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49629
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49630
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe EntityData1024(int initialCapacity = 1024 /* Metadata: 0x0232EA35 */, bool autoExtend = false /* Metadata: 0x0232EA37 */);
	
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

	public struct EnvGeneratorRendererInfo // TypeDefIndex: 49632
	{
		// Fields
		public float3 pos; // 0x00
		public float placeHolder; // 0x0C
		public float4 atlasUV; // 0x10
	}

	[DataN(capacity = 6, tSize = 16, ring = false)]
	[NoAlias]
	public struct Float4Data6<T> : IEnumerable<T> // TypeDefIndex: 49635
		where T : struct
	{
		// Fields
		public const int T_SIZE = 16; // Metadata: 0x0232EA40
		public const int CAPACITY = 8; // Metadata: 0x0232EA41
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x0232EA42
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA43
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49633
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49634
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe Float4Data6(int initialCapacity = 8 /* Metadata: 0x0232EA3E */, bool autoExtend = false /* Metadata: 0x0232EA3F */);
	
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
	public struct Float4Data16<T> : IEnumerable<T> // TypeDefIndex: 49638
		where T : struct
	{
		// Fields
		public const int T_SIZE = 16; // Metadata: 0x0232EA46
		public const int CAPACITY = 16; // Metadata: 0x0232EA47
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x0232EA48
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA49
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49636
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49637
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe Float4Data16(int initialCapacity = 16 /* Metadata: 0x0232EA44 */, bool autoExtend = false /* Metadata: 0x0232EA45 */);
	
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
	public struct IntData8<T> : IEnumerable<T> // TypeDefIndex: 49641
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x0232EA4C
		public const int CAPACITY = 8; // Metadata: 0x0232EA4D
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x0232EA4E
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA4F
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49639
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49640
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe IntData8(int initialCapacity = 8 /* Metadata: 0x0232EA4A */, bool autoExtend = false /* Metadata: 0x0232EA4B */);
	
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
	public struct IntData32<T> : IEnumerable<T> // TypeDefIndex: 49644
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x0232EA52
		public const int CAPACITY = 32; // Metadata: 0x0232EA53
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x0232EA54
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA55
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49642
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49643
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe IntData32(int initialCapacity = 32 /* Metadata: 0x0232EA50 */, bool autoExtend = false /* Metadata: 0x0232EA51 */);
	
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

	public struct LogisticsExtContainer // TypeDefIndex: 49646
	{
		// Nested types
		public struct LogisticsExtData // TypeDefIndex: 49645
		{
		}
	}

	public struct OutputRendererInfo // TypeDefIndex: 49647
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
	public struct PortData16<T> : IEnumerable<T> // TypeDefIndex: 49650
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0232EA58
		public const int CAPACITY = 16; // Metadata: 0x0232EA5A
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x0232EA5B
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA5C
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49648
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49649
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe PortData16(int initialCapacity = 16 /* Metadata: 0x0232EA56 */, bool autoExtend = false /* Metadata: 0x0232EA57 */);
	
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
	public struct PortData32<T> : IEnumerable<T> // TypeDefIndex: 49653
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0232EA5F
		public const int CAPACITY = 32; // Metadata: 0x0232EA61
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x0232EA62
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA63
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49651
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49652
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe PortData32(int initialCapacity = 32 /* Metadata: 0x0232EA5D */, bool autoExtend = false /* Metadata: 0x0232EA5E */);
	
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
	public struct PortData128<T> : IEnumerable<T> // TypeDefIndex: 49656
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0232EA67
		public const int CAPACITY = 128; // Metadata: 0x0232EA69
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x0232EA6B
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA6D
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49654
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49655
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe PortData128(int initialCapacity = 128 /* Metadata: 0x0232EA64 */, bool autoExtend = false /* Metadata: 0x0232EA66 */);
	
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
	public struct PortData256<T> : IEnumerable<T> // TypeDefIndex: 49659
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0232EA71
		public const int CAPACITY = 256; // Metadata: 0x0232EA73
		public const int CAPACITY_MINUS_ONE = 255; // Metadata: 0x0232EA75
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA77
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49657
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49658
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe PortData256(int initialCapacity = 256 /* Metadata: 0x0232EA6E */, bool autoExtend = false /* Metadata: 0x0232EA70 */);
	
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

	public struct SharedDataContainer // TypeDefIndex: 49663
	{
		// Fields
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref SharedExtData this[int index] { [IDTag(0)] get => default; } // 0x00000001869C2910-0x00000001869C298C 
		public ref SharedExtData this[uint index] { [IDTag(1)] get => default; } // 0x00000001830569A0-0x0000000183056A10 
	
		// Nested types
		public struct SharedExtData // TypeDefIndex: 49660
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
			public AdditiveEffectFragment additiveEffect; // 0x568
			public bool inMainRegion; // 0xD98
	
			// Properties
			public bool visible { get; } // 0x0000000183054080-0x0000000183054200 
			public bool visibleAdditiveMat { get; } // 0x00000001834CC830-0x00000001834CC8B0 
	
			// Methods
			public bool IsDirty(DirtyFlag f); // 0x00000001869C298C-0x00000001869C29EC
			public void SetDirty(DirtyFlag f, bool d); // 0x000000018345C620-0x000000018345C680
			public bool IsPendingUnit(); // 0x0000000183475280-0x00000001834752B0
		}
	
		[Flags]
		public enum DirtyFlag // TypeDefIndex: 49661
		{
			NONE = 0,
			STATUS_CHANGE = 1,
			VAT_UPDATE = 2,
			UPDATE_STATUS_EFFECT = 4,
			CULL_STATUS_CHANGE = 8,
			RENDERER_VISIBLE = 16,
			ALL = 255
		}
	
		internal struct Node // TypeDefIndex: 49662
		{
			// Fields
			public SharedExtData value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public SharedDataContainer(Unity.Collections.Allocator allocator); // 0x00000001844397E0-0x000000018443A090
	
		// Methods
		public void Dispose(); // 0x00000001869C27B4-0x00000001869C2828
		public void FlushPendingFree(); // 0x00000001834FF1C0-0x00000001834FF290
		public uint Size(); // 0x00000001840E9590-0x00000001840E95C0
		public Span<SharedExtData> AsSpan(); // 0x00000001869C2670-0x00000001869C2724
		public uint Create(ref SharedExtData value); // 0x00000001834CCA30-0x00000001834CCB00
		public void Destroy(uint handle); // 0x00000001869C2724-0x00000001869C27B4
		public void Reset(); // 0x000000018443A090-0x000000018443ABE0
		public void Reserve(uint newCapacity); // 0x00000001869C288C-0x00000001869C2910
		public IntPtr Data(); // 0x00000001833435D0-0x0000000183343630
		public ref SharedExtData Get(uint handle); // 0x00000001869C2828-0x00000001869C288C
	}

	public struct StaticMountInfo // TypeDefIndex: 49664
	{
		// Fields
		public Entity rendererEntity; // 0x00
		public FactoryUnitExtendConfig mountConfig; // 0x08
	}

	[DataN(capacity = 16, tSize = 80, ring = false)]
	[NoAlias]
	public struct StaticMountInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49667
		where T : struct
	{
		// Fields
		public const int T_SIZE = 80; // Metadata: 0x0232EA82
		public const int CAPACITY = 16; // Metadata: 0x0232EA84
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x0232EA85
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA86
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49665
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49666
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe StaticMountInfoCollection(int initialCapacity = 16 /* Metadata: 0x0232EA80 */, bool autoExtend = false /* Metadata: 0x0232EA81 */);
	
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
	public struct UnitExtendConfig12<T> : IEnumerable<T> // TypeDefIndex: 49670
		where T : struct
	{
		// Fields
		public const int T_SIZE = 128; // Metadata: 0x0232EA89
		public const int CAPACITY = 16; // Metadata: 0x0232EA8B
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x0232EA8C
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA8D
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49668
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 49669
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe UnitExtendConfig12(int initialCapacity = 16 /* Metadata: 0x0232EA87 */, bool autoExtend = false /* Metadata: 0x0232EA88 */);
	
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

	public struct WireRendererInfo // TypeDefIndex: 49671
	{
		// Fields
		public float3 fromPos; // 0x00
		public float3 toPos; // 0x0C
		public ulong connectionId; // 0x18
		public float alpha; // 0x20
	
		// Properties
		public float3 pos { get; } // 0x00000001869C3C38-0x00000001869C3D00 
		public quaternion rot { get; } // 0x00000001869C3D00-0x00000001869C3E3C 
		public float scale { get; } // 0x00000001869C3E3C-0x00000001869C3EB8 
	}

	[DataN(capacity = 512, tSize = 48, ring = false)]
	[NoAlias]
	public struct WireRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49674
		where T : struct
	{
		// Fields
		public const int T_SIZE = 48; // Metadata: 0x0232EA91
		public const int CAPACITY = 512; // Metadata: 0x0232EA92
		public const int CAPACITY_MINUS_ONE = 511; // Metadata: 0x0232EA94
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EA96
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49672
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
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 49673
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe WireRendererInfoCollection(int initialCapacity = 512 /* Metadata: 0x0232EA8E */, bool autoExtend = false /* Metadata: 0x0232EA90 */);
	
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

	public class EntitySearcher // TypeDefIndex: 49675
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private NativeParallelHashMap<UnitId, Entity> m_logicEntityMap; // 0x10
	
		// Constructors
		public EntitySearcher(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public NativeParallelHashMap<UnitId, Entity> GetLogicEntityMap(); // 0x00000001869BEDDC-0x00000001869BEE44
		public void RegisterLogicEntity(int chapterId, uint nodeId, Entity entity); // 0x00000001838FEEA0-0x00000001838FF020
		public bool UnregisterLogicEntity(int chapterId, uint nodeId); // 0x00000001869BEE44-0x00000001869BEF0C
		public bool GetLogicEntity(int chapterId, uint nodeId, out Entity entity); // 0x0000000182EEFB30-0x0000000182EEFF00
		private void _DestroyAllEntities(); // 0x00000001869BEF0C-0x00000001869BEFC0
		public void DestroyAll(); // 0x00000001869BED8C-0x00000001869BEDDC
	}

	public struct EventChannel<T> : IDisposable // TypeDefIndex: 49677
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
		public struct ParallelWriter // TypeDefIndex: 49676
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
		public static EventChannel<T> Create(int initialCapacity = 16 /* Metadata: 0x0232EA97 */);
		public void Enqueue(T evt);
		private void _Grow(int newCapacity);
		public void PrepareConcurrentWrites(int capacity);
		public ParallelWriter AsParallelWriter();
		public void FlushConcurrentWrites();
		private void _EnsureCapacity(int required);
		public NativeArray<T> GetEvents();
		public void Clear();
		public void Dispose();
	}

	public static class EventChannelAccessor // TypeDefIndex: 49678
	{
		// Methods
		public static void InitEventChannels(ref GlobalEnv env); // 0x0000000184724A10-0x0000000184724BA0
		public static void DisposeEventChannels(ref GlobalEnv env); // 0x00000001869BF118-0x00000001869BF19C
		public static void ClearAll(ref GlobalEnv env); // 0x0000000183DC40B0-0x0000000183DC4120
		public static bool HasStatusChangeEvents(ref GlobalEnv env); // 0x00000001834D4D50-0x00000001834D4DD0
		public static bool HasUpdatePipeEffectEvents(ref GlobalEnv env); // 0x00000001834D4DD0-0x00000001834D4E50
		public static bool HasChangeTemplateEvents(ref GlobalEnv env); // 0x00000001834D4F50-0x00000001834D4FD0
		public static bool HasCreateUnitRendererEvents(ref GlobalEnv env); // 0x00000001834D4C50-0x00000001834D4CD0
		public static bool HasPendingCreateRendererEvents(ref GlobalEnv env); // 0x00000001869BF22C-0x00000001869BF2C0
		public static bool HasUpdateStatusEffectEvents(ref GlobalEnv env); // 0x00000001834D4CD0-0x00000001834D4D50
		public static bool HasUpdateRendererPropertyEvents(ref GlobalEnv env); // 0x00000001834D4BD0-0x00000001834D4C50
		public static bool HasUpdatePedestalColorLUTEvents(ref GlobalEnv env); // 0x00000001834D4E50-0x00000001834D4ED0
		public static bool HasCreateInteractEvents(ref GlobalEnv env); // 0x00000001834D4ED0-0x00000001834D4F50
		public static NativeArray<EvtStatusChange> GetStatusChangeEvents(ref GlobalEnv env); // 0x000000018470E200-0x000000018470E280
		public static NativeArray<EvtAudio> GetAudioEvents(ref GlobalEnv env); // 0x00000001830D4010-0x00000001830D4110
		public static NativeArray<EvtChangeTemplate> GetChangeTemplateEvents(ref GlobalEnv env); // 0x0000000183D69570-0x0000000183D69620
		public static NativeArray<EvtUpdatePipeEffect> GetUpdatePipeEffectEvents(ref GlobalEnv env); // 0x00000001846FDE50-0x00000001846FDF00
		public static NativeArray<EvtCreateUnitRenderer> GetCreateUnitRendererEvents(ref GlobalEnv env); // 0x0000000184B83180-0x0000000184B83230
		public static NativeArray<EvtVatUpdate> GetVatUpdateEvents(ref GlobalEnv env); // 0x00000001830D4730-0x00000001830D4830
		public static NativeArray<EvtUpdateStatusEffect> GetUpdateStatusEffectEvents(ref GlobalEnv env); // 0x0000000184CC4A40-0x0000000184CC4AC0
		public static NativeArray<EvtUpdateRendererProperty> GetUpdateRendererPropertyEvents(ref GlobalEnv env); // 0x0000000184CEC8C0-0x0000000184CEC970
		public static NativeArray<EvtUpdatePedestalColorLUT> GetUpdatePedestalColorLUTEvents(ref GlobalEnv env); // 0x0000000184CEC970-0x0000000184CECA20
		public static NativeArray<EvtCreateInteract> GetCreateInteractEvents(ref GlobalEnv env); // 0x0000000184CECA20-0x0000000184CECC30
		public static NativeArray<EvtPendingCreateRenderer> GetPendingCreateRendererEvents(ref GlobalEnv env); // 0x00000001838AEB50-0x00000001838AEC30
		public static void PrepareVatUpdateConcurrentWrites(ref GlobalEnv env, int capacity); // 0x00000001847753F0-0x0000000184775460
		public static void PrepareUpdateStatusEffectConcurrentWrites(ref GlobalEnv env, int capacity); // 0x0000000184775460-0x00000001847754D0
		public static void PrepareAudioConcurrentWrites(ref GlobalEnv env, int capacity); // 0x00000001847754D0-0x0000000184775540
		public static EventChannel<EvtVatUpdate> GetVatUpdateParallelWriter(ref GlobalEnv env); // 0x00000001846DC820-0x00000001846DC8C0
		public static EventChannel<EvtUpdateStatusEffect> GetUpdateStatusEffectParallelWriter(ref GlobalEnv env); // 0x00000001846DC8C0-0x00000001846DC960
		public static EventChannel<EvtAudio> GetAudioParallelWriter(ref GlobalEnv env); // 0x00000001846DC960-0x00000001846DCA00
		public static void FlushVatUpdateConcurrentWrites(ref GlobalEnv env); // 0x00000001847C46B0-0x00000001847C4720
		public static void FlushUpdateStatusEffectConcurrentWrites(ref GlobalEnv env); // 0x00000001847C4720-0x00000001847C4790
		public static void FlushAudioConcurrentWrites(ref GlobalEnv env); // 0x00000001847C4790-0x00000001847C4800
		public static int GetPendingCreateRendererCount(); // 0x00000001869BF19C-0x00000001869BF22C
	}

	public struct FactoryEventChannels : IDisposable // TypeDefIndex: 49679
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
	
		// Properties
		public static unsafe FactoryEventChannels* instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001869BFB14-0x00000001869BFB4C 0x00000001869BFB4C-0x00000001869BFB88
	
		// Methods
		public static unsafe void SetInstance(FactoryEventChannels* ptr); // 0x0000000185397B9C-0x0000000185397BA4
		public static void ClearInstance(); // 0x00000001869BF820-0x00000001869BF864
		public static FactoryEventChannels Create(); // 0x0000000184724BA0-0x00000001847250C0
		public void ClearAll(); // 0x0000000183DC4120-0x0000000183DC4360
		public void Dispose(); // 0x00000001869BF864-0x00000001869BFB14
		public void Enqueue<T>(T evt)
			where T : struct, IFactoryEvent;
	}

	public static class MiscExtensions // TypeDefIndex: 49680
	{
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

	public class FacBoneTRSBinary : IDisposable // TypeDefIndex: 49681
	{
		// Fields
		private static FacBoneTRSBinary s_instance; // 0x00
		private RefMultiHashTable<long, FacBoneTRSUnitEntry> m_unitTable; // 0x10
		private MMapHelper.MMapViewInfo m_mmpHandle; // 0x30
		private IntPtr m_basePtr; // 0x38
		private bool m_isReady; // 0x40
	
		// Properties
		public static FacBoneTRSBinary instance { get; } // 0x000000018449A200-0x000000018449A290 
		public bool isReady { get; } // 0x00000001869BF7D4-0x00000001869BF820 
	
		// Constructors
		public FacBoneTRSBinary(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void InitMain(); // 0x000000018449B330-0x000000018449BAE0
		private void _InitTable(); // 0x000000018449BB30-0x000000018449BC00
		public bool TryGetBoneTRS(int guid, ulong boneNameHash, uint frame, out Matrix4x4 trs); // 0x00000001869BF644-0x00000001869BF7D4
		private void _DisposeResources(); // 0x000000018449BAE0-0x000000018449BB30
		public void Dispose(); // 0x00000001869BF57C-0x00000001869BF5D4
		~FacBoneTRSBinary(); // 0x00000001869BF5D4-0x00000001869BF644
	}

	public struct FacBoneTRSUnitEntry // TypeDefIndex: 49682
	{
		// Fields
		public long hashKey; // 0x00
		public int boneCount; // 0x08
		public int bonesOffset; // 0x0C
	}

	public struct FacBoneTRSBoneEntry // TypeDefIndex: 49683
	{
		// Fields
		public ulong boneNameHash; // 0x00
		public int trsCount; // 0x08
		public int trsOffset; // 0x0C
	}

	public sealed class LongComparer : IRefComparer<long> // TypeDefIndex: 49684
	{
		// Constructors
		public LongComparer(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public long GetHashCode(long key); // 0x0000000184D88C30-0x0000000184D88C40
	}

	public static class FactoryProfilerMakers // TypeDefIndex: 49685
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
		static FactoryProfilerMakers(); // 0x00000001847AA300-0x00000001847AA800
	}

	public static class FactorySharedDataManager // TypeDefIndex: 49686
	{
		// Fields
		private static ConveyorExtContainer s_conveyorExtData; // 0x00
		private static SharedDataContainer s_sharedData; // 0x28
		private static EntityHierarchyContainer s_hierarchy; // 0x50
		private static VATFSMDefinitionContainer s_vatFsm; // 0x58
		private static BlueprintSlotContainer s_blueprintSlot; // 0x80
	
		// Methods
		public static void InitExtData(); // 0x0000000184438FB0-0x0000000184439190
		public static void ResetExtData(); // 0x0000000184439190-0x0000000184439260
		public static void ReleaseExtData(); // 0x00000001869BFDEC-0x00000001869BFEC8
		public static void FlushDeferredFree(); // 0x00000001834FECA0-0x00000001834FEF30
		public static uint CreateConveyorExtHandle(); // 0x0000000183B2A090-0x0000000183B2A120
		public static void DestroyConveyorExtHandle(uint handle); // 0x00000001869BFC08-0x00000001869BFC84
		public static ref ConveyorExtContainer.ConveyorExt GetConveyorExt(uint handle); // 0x00000001834CDA00-0x00000001834CDAB0
		public static IntPtr GetConveyorExtData(); // 0x00000001838AC150-0x00000001838AC1F0
		public static uint CreateSharedData(bool adjustMapValid = true /* Metadata: 0x0232EA98 */); // 0x00000001834CC960-0x00000001834CCA30
		[IDTag(0)]
		public static ref SharedDataContainer.SharedExtData GetSharedData(uint handle); // 0x00000001830568F0-0x00000001830569A0
		public static void DestroySharedData(uint handle); // 0x00000001869BFCEC-0x00000001869BFD6C
		[IDTag(1)]
		public static IntPtr GetSharedData(); // 0x0000000183343530-0x00000001833435D0
		public static int GetSharedDataSize(); // 0x00000001840E9540-0x00000001840E9590
		public static uint CreateTransHierarchy(); // 0x00000001837B22D0-0x00000001837B2370
		[IDTag(0)]
		public static ref EntityHierarchyContainer.EntityTransformData GetHierarchyData(uint handle); // 0x00000001834C6510-0x00000001834C6560
		[IDTag(1)]
		public static ref EntityHierarchyContainer.EntityTransformData GetHierarchyData(int handle); // 0x00000001837B24D0-0x00000001837B2520
		public static float4x4 WorldTrans([IsReadOnly] in EntityHierarchyContainer.EntityTransformData transform); // 0x00000001869BFEC8-0x00000001869BFFEC
		public static void DestroyHierarchyData(uint handle); // 0x00000001869BFC84-0x00000001869BFCEC
		[IDTag(2)]
		public static IntPtr GetHierarchyData(); // 0x00000001830D4E80-0x00000001830D4EF0
		public static int GetHierarchySize(); // 0x000000018418E0B0-0x000000018418E0F0
		public static uint CreateVATFSMDefinitionContainer(ref VATFSMDefinition definition); // 0x00000001844393D0-0x0000000184439440
		[IDTag(0)]
		public static ref VATFSMDefinition GetVATFSMDefinition(uint handle); // 0x0000000183CCC0C0-0x0000000183CCC170
		public static void DestroyVATFSMDefinition(uint handle); // 0x00000001869BFD6C-0x00000001869BFDEC
		[IDTag(1)]
		public static IntPtr GetVATFSMDefinition(); // 0x00000001838ACE10-0x00000001838ACEB0
		public static uint CreateBlueprintSlotInfo(); // 0x00000001836BAAB0-0x00000001836BAB60
		public static ref BlueprintSlotInfo GetBlueprintSlotInfo(uint handle); // 0x00000001836B8710-0x00000001836B8770
		public static void DestroyBlueprintSlotInfo(uint handle); // 0x00000001869BFB88-0x00000001869BFC08
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ActivatorCostFragment : IComponentECS // TypeDefIndex: 49687
	{
		// Fields
		public bool isActive; // 0x00
		public int costItemFastId; // 0x04
		public int readyFormulaFastId; // 0x08
		public const int ID = 1; // Metadata: 0x0232EA99
	
		// Properties
		public int id { get; } // 0x0000000183FE7620-0x0000000183FE7650 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BA164-0x00000001869BA280
	}

	public struct AdditiveEffectFragment // TypeDefIndex: 49690
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
		public Request curEffectRequest; // 0x7E0
		public AdditiveEffectRequestStack<Request> stateWaitStack; // 0x7E4
	
		// Properties
		public AdditiveEffectType curEffectType { get; set; } // 0x00000001869BA5B4-0x00000001869BA604 0x00000001869BA604-0x00000001869BA670
	
		// Nested types
		public struct Request // TypeDefIndex: 49688
		{
			// Fields
			public AdditiveEffectType type; // 0x00
			public short typeValue; // 0x00
			public AdditiveEffectType lastType; // 0x02
			public short lastTypeValue; // 0x02
		}
	
		public enum AdditiveEffectType : short // TypeDefIndex: 49689
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
			INVALID_OVERLAP_PLACE = 16
		}
	
		// Methods
		public void PushState(AdditiveEffectType state); // 0x00000001834A9300-0x00000001834A9380
		public void InsertState(int index, AdditiveEffectType state); // 0x00000001834A8FD0-0x00000001834A9080
		public AdditiveEffectType ShiftState(); // 0x00000001869BA384-0x00000001869BA410
		public AdditiveEffectType PopState(); // 0x00000001869BA2DC-0x00000001869BA384
		public AdditiveEffectType PeekState(); // 0x00000001869BA280-0x00000001869BA2DC
		public void DisableState(AdditiveEffectType state); // 0x000000018398C2E0-0x000000018398C380
		private void _Shrink(); // 0x000000018398C380-0x000000018398C4E0
		[BurstDiscard]
		public override string ToString(); // 0x00000001869BA410-0x00000001869BA554
		public string __iFixBaseProxy_ToString(); // 0x00000001869BA554-0x00000001869BA5B4
	}

	public struct CutoffState // TypeDefIndex: 49691
	{
		// Fields
		private bool m_enable; // 0x00
		public uint mode; // 0x04
		public float cutOffY; // 0x08
		[CompilerGenerated]
		private bool _enable_k__BackingField; // 0x0C
	
		// Properties
		public bool enable { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000184D88B00-0x0000000184D88B10 0x0000000184D88B30-0x0000000184D88B40
	
		// Methods
		public void SetEnable(bool v); // 0x00000001869BE92C-0x00000001869BE984
		public void SetCutoffY(float v); // 0x00000001869BE880-0x00000001869BE92C
		public void SetMode(uint v); // 0x00000001869BE984-0x00000001869BE9DC
	}

	public struct BuildDismissState // TypeDefIndex: 49693
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
		public enum BuildEffectType : byte // TypeDefIndex: 49692
		{
			DEFAULT = 0,
			TYPE1 = 1
		}
	
		// Methods
		public void SetEnable(bool v); // 0x00000001869BBF64-0x00000001869BBFBC
	}

	public struct RepairState // TypeDefIndex: 49694
	{
		// Fields
		public bool enable; // 0x00
		public RepairState0 state0; // 0x08
		public RepairState1 state1; // 0x18
	}

	public struct RepairState0 // TypeDefIndex: 49695
	{
		// Fields
		public bool enable; // 0x00
		public float duration; // 0x04
		public long startTms; // 0x08
	}

	public struct RepairState1 // TypeDefIndex: 49696
	{
		// Fields
		public bool enable; // 0x00
		public float duration; // 0x04
		public long startTms; // 0x08
	}

	public struct HighLightState // TypeDefIndex: 49697
	{
		// Fields
		public bool enable; // 0x00
		public bool invalid; // 0x01
		public bool social; // 0x02
		public FixedList128Bytes<byte> indexList; // 0x04
		public DitherState ditherState; // 0x84
	
		// Methods
		public void SetEnable(bool isEnable); // 0x0000000183F3C3D0-0x0000000183F3C410
		public void SetData(bool isInvalid, bool isSocial); // 0x00000001869C1DF8-0x00000001869C1E74
		public LogicEntityState GetEffectType(); // 0x00000001869C1C04-0x00000001869C1C68
		public bool IsHighlight(byte index); // 0x00000001869C1D48-0x00000001869C1DF8
		public void HighlightWithSubIndex(byte index, bool en); // 0x00000001869C1C68-0x00000001869C1D48
		public void ClearHighlightableIndexList(); // 0x00000001869C1B90-0x00000001869C1C04
	}

	public struct HintState // TypeDefIndex: 49698
	{
		// Fields
		public bool enable; // 0x00
		public bool showSelf; // 0x01
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v); // 0x00000001869C1E74-0x00000001869C1ECC
	}

	public struct FigureState // TypeDefIndex: 49699
	{
		// Fields
		public bool valid; // 0x00
		public bool enable; // 0x01
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v); // 0x00000001869C0674-0x00000001869C06CC
	}

	public struct OverloadState // TypeDefIndex: 49700
	{
		// Fields
		public bool enable; // 0x00
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v); // 0x00000001869C1F7C-0x00000001869C1FD4
	}

	public struct OverloadInvalidState // TypeDefIndex: 49701
	{
		// Fields
		public bool enable; // 0x00
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v); // 0x00000001869C1F24-0x00000001869C1F7C
	}

	public struct DitherState // TypeDefIndex: 49702
	{
		// Fields
		public bool enable; // 0x00
		public float ditherVal; // 0x04
	
		// Methods
		public void SetEnable(bool v); // 0x00000001869BED34-0x00000001869BED8C
	}

	public struct BlueprintState // TypeDefIndex: 49704
	{
		// Fields
		public bool enable; // 0x00
		public EffectType effectType; // 0x01
		public FixedList512Bytes<byte> indexList; // 0x02
		public CutoffState cutoffState; // 0x204
		public BuildDismissState buildState; // 0x218
	
		// Nested types
		public enum EffectType : byte // TypeDefIndex: 49703
		{
			NONE = 0,
			TO_BE_BUILD = 1,
			TO_BE_BUILD_SELECT = 2,
			MOVING = 3,
			MOVING_INVALID = 4,
			TO_BUILD_INVALID = 5
		}
	
		// Methods
		[IDTag(0)]
		public void SetEnable(bool v); // 0x00000001869BBE90-0x00000001869BBEE8
		[IDTag(1)]
		public void SetEnable(bool v, EffectType type); // 0x00000001869BBEE8-0x00000001869BBF64
		public bool IsLighten(byte index); // 0x00000001869BBD00-0x00000001869BBDB0
		public void LightenWithSubIndex(byte index, bool en); // 0x00000001869BBDB0-0x00000001869BBE90
		public void ClearLightenIndexList(); // 0x00000001869BBCA8-0x00000001869BBD00
	}

	public struct PreSelectState // TypeDefIndex: 49705
	{
		// Fields
		public bool enable; // 0x00
		public FixedList512Bytes<byte> indexList; // 0x02
	
		// Methods
		public void SetEnable(bool v); // 0x0000000183F3C410-0x0000000183F3C450
		public bool IsLighten(byte index); // 0x00000001869C23D4-0x00000001869C2484
		public void LightenWithSubIndex(byte index, bool en); // 0x00000001869C2484-0x00000001869C2564
		public void ClearLightenIndexList(); // 0x00000001869C2360-0x00000001869C23D4
	}

	public struct SoloSelectState // TypeDefIndex: 49706
	{
		// Fields
		public FixedList128Bytes<byte> indexList; // 0x00
	
		// Properties
		public bool enable { get; } // 0x00000001869C2FE8-0x00000001869C3060 
	
		// Methods
		public void SetEnable(bool v); // 0x00000001869C2F64-0x00000001869C2FE8
		public bool IsLighten(byte index); // 0x00000001869C2CD0-0x00000001869C2D58
		public void SelectWithSubIndex(byte index, bool en); // 0x00000001869C2D58-0x00000001869C2DF8
		[IDTag(0)]
		public void SelectWithSubIndices(byte[] indices, bool en); // 0x00000001869C2DF8-0x00000001869C2E94
		[IDTag(1)]
		public void SelectWithSubIndices(Span<byte> indices, bool en); // 0x00000001869C2E94-0x00000001869C2F64
		public void ClearSelectedIndexList(); // 0x00000001869C2C5C-0x00000001869C2CD0
	}

	public struct ContinuationState // TypeDefIndex: 49707
	{
		// Fields
		public bool enable; // 0x00
		public FixedList512Bytes<byte> indexList; // 0x02
	
		// Methods
		public void SetEnable(bool v); // 0x0000000183F3C450-0x0000000183F3C490
		public bool IsLighten(byte index); // 0x00000001869BD118-0x00000001869BD1C8
		public void LightenWithSubIndex(byte index, bool en); // 0x00000001869BD1C8-0x00000001869BD2A8
		public void ClearLightenIndexList(); // 0x00000001869BD0A4-0x00000001869BD118
	}

	public struct SocialSharingState // TypeDefIndex: 49708
	{
		// Fields
		public bool enable; // 0x00
	
		// Methods
		public void SetEnable(bool v); // 0x00000001869C2C04-0x00000001869C2C5C
	}

	public struct PowerInteractionState // TypeDefIndex: 49709
	{
		// Fields
		public bool enable; // 0x00
	
		// Methods
		public void SetEnable(bool v); // 0x00000001869C2308-0x00000001869C2360
	}

	public struct InvalidOverlapPlaceState // TypeDefIndex: 49710
	{
		// Fields
		public bool enable; // 0x00
		public DitherState ditherState; // 0x04
		public bool isTemporary; // 0x0C
	
		// Methods
		public void SetEnable(bool v); // 0x00000001869C1ECC-0x00000001869C1F24
	}

	[BurstCompatible]
	[ECSComponent]
	public struct AdditiveEffectRendererFragment : IComponentECS // TypeDefIndex: 49711
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
		public const int ID = 2; // Metadata: 0x0232EAC4
	
		// Properties
		public bool buildDismissEnabled { get; set; } // 0x00000001869BA9C8-0x00000001869BAA14 0x00000001869BAF68-0x00000001869BAFCC
		public bool blueprintBuildEnabled { get; set; } // 0x00000001869BA930-0x00000001869BA97C 0x00000001869BAEA0-0x00000001869BAF04
		public bool blueprintBuildCutoffYEnabled { get; set; } // 0x00000001869BA8E4-0x00000001869BA930 0x00000001869BAE3C-0x00000001869BAEA0
		public bool cutOffYIgnored { get; set; } // 0x00000001869BAA60-0x00000001869BAAAC 0x00000001869BB030-0x00000001869BB094
		public bool cutoffYEnabled { get; set; } // 0x00000001869BAAAC-0x00000001869BAAF8 0x00000001869BB094-0x00000001869BB0F8
		public bool highLightEnabled { get; set; } // 0x00000001869BAB44-0x00000001869BAB90 0x00000001869BB15C-0x00000001869BB1C0
		public bool figureEnabled { get; set; } // 0x00000001869BAAF8-0x00000001869BAB44 0x00000001869BB0F8-0x00000001869BB15C
		public bool hintEnabled { get; set; } // 0x00000001869BAB90-0x00000001869BABDC 0x00000001869BB1C0-0x00000001869BB224
		public bool overloadEnabled { get; set; } // 0x00000001869BAC28-0x00000001869BAC74 0x00000001869BB288-0x00000001869BB2EC
		public bool overloadInvalidEnabled { get; set; } // 0x00000001869BAC74-0x00000001869BACC0 0x00000001869BB2EC-0x00000001869BB348
		public bool repair0Enabled { get; set; } // 0x00000001869BAD58-0x00000001869BADA4 0x00000001869BB410-0x00000001869BB474
		public bool repair1Enabled { get; set; } // 0x00000001869BADA4-0x00000001869BADF0 0x00000001869BB474-0x00000001869BB4D8
		public bool blueprintEnabled { get; set; } // 0x00000001869BA97C-0x00000001869BA9C8 0x00000001869BAF04-0x00000001869BAF68
		public bool preSelectEnabled { get; set; } // 0x00000001869BAD0C-0x00000001869BAD58 0x00000001869BB3AC-0x00000001869BB410
		public bool continuationEnabled { get; set; } // 0x00000001869BAA14-0x00000001869BAA60 0x00000001869BAFCC-0x00000001869BB030
		public bool socialSharingEnabled { get; set; } // 0x00000001869BADF0-0x00000001869BAE3C 0x00000001869BB4D8-0x00000001869BB53C
		public bool powerInteractionEnabled { get; set; } // 0x00000001869BACC0-0x00000001869BAD0C 0x00000001869BB348-0x00000001869BB3AC
		public bool invalidOverlapPlaceEnabled { get; set; } // 0x00000001869BABDC-0x00000001869BAC28 0x00000001869BB224-0x00000001869BB288
		public bool anyEffect { get; } // 0x00000001869BA794-0x00000001869BA8E4 
		public int id { get; } // 0x0000000183FD2600-0x0000000183FD2630 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BA670-0x00000001869BA794
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BattleFragment : IComponentECS // TypeDefIndex: 49712
	{
		// Fields
		public bool overload; // 0x00
		public float currentEnergy; // 0x04
		public float maxEnergy; // 0x08
		public const int ID = 3; // Metadata: 0x0232EAC5
	
		// Properties
		public int id { get; } // 0x0000000183FAC4B0-0x0000000183FAC4E0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BB658-0x00000001869BB774
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BindRenderEntityFragment : IComponentECS // TypeDefIndex: 49713
	{
		// Fields
		public EntityData512<Entity> renderEntities; // 0x00
		public const int ID = 4; // Metadata: 0x0232EAC6
	
		// Properties
		public int id { get; } // 0x0000000183A632B0-0x0000000183A63310 
	
		// Methods
		public void BindRenderEntity(Entity renderEntity); // 0x000000018392BD50-0x000000018392BDB0
		[IDTag(0)]
		public void BindRenderEntities(Entity[] renderEntityList); // 0x00000001869BB774-0x00000001869BB804
		[IDTag(1)]
		public void BindRenderEntities(NativeArray<Entity> renderEntityList); // 0x00000001869BB804-0x00000001869BB958
		public void UnbindRenderEntity(Entity renderEntity); // 0x00000001869BB958-0x00000001869BBA60
		public void ClearBindRenderEntities(); // 0x00000001834A3680-0x00000001834A36B0
		public bool Binded(Entity renderEntity); // 0x000000018392BDB0-0x000000018392BE60
		public bool HasRenderer(); // 0x00000001837A9780-0x00000001837A97E0
		private void __AOT_FOR_FIX__(); // 0x00000001869BBA60-0x00000001869BBBAC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BurnPowerFragment : IComponentECS // TypeDefIndex: 49714
	{
		// Fields
		public long currentLeastProgress; // 0x00
		public long powerGenPerSec; // 0x08
		public StringIntern.FastId burningItemIdFastId; // 0x10
		public const int ID = 5; // Metadata: 0x0232EAC7
	
		// Properties
		public string burningItemId { get; set; } // 0x00000001869BC0DC-0x00000001869BC12C 0x00000001846097C0-0x000000018460A720
		public int id { get; } // 0x00000001844FE310-0x00000001844FE340 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BBFBC-0x00000001869BC0DC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BusFragment : IComponentECS // TypeDefIndex: 49715
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 6; // Metadata: 0x0232EAC8
	
		// Properties
		public int id { get; } // 0x0000000184198B60-0x0000000184198B90 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BC12C-0x00000001869BC238
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BusFreeFragment : IComponentECS // TypeDefIndex: 49716
	{
		// Fields
		public bool connectToStart; // 0x00
		public bool enabled; // 0x01
		public const int ID = 7; // Metadata: 0x0232EAC9
	
		// Properties
		public int id { get; } // 0x00000001842D2050-0x00000001842D2080 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BC238-0x00000001869BC34C
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct CacheFragment : IComponentECS // TypeDefIndex: 49724
	{
		// Fields
		private const int CONTAINER_OFFSET = 16; // Metadata: 0x0232EACA
		private const int ITEM_SIZE = 16; // Metadata: 0x0232EACB
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
		public const int ID = 8; // Metadata: 0x0232EACC
	
		// Properties
		public int id { get; } // 0x0000000183D6E6A0-0x0000000183D6E700 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _cacheSizePtr_e__FixedBuffer // TypeDefIndex: 49717
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _cacheFluidSizePtr_e__FixedBuffer // TypeDefIndex: 49718
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _cacheContentPtr_e__FixedBuffer // TypeDefIndex: 49719
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _itemInPtr_e__FixedBuffer // TypeDefIndex: 49720
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _itemOutPtr_e__FixedBuffer // TypeDefIndex: 49721
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _fluidInPtr_e__FixedBuffer // TypeDefIndex: 49722
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _fluidOutPtr_e__FixedBuffer // TypeDefIndex: 49723
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		// Methods
		public void GetCacheItem(bool inOut, bool isFluid, int cacheIndex, int indexInCache, out uint itemId, out int itemAmount, out long tms); // 0x0000000183BAEDD0-0x0000000183BAEE90
		public void SetCacheItem(bool inOut, bool isFluid, int cacheIndex, int indexInCache, uint itemId, int itemAmount, long tms); // 0x0000000183BAF410-0x0000000183BAF4D0
		public void SetCacheSize(bool inOut, bool isFluid, int cacheIndex, int sizeCount); // 0x0000000183BAF5D0-0x0000000183BAF640
		public unsafe int CalcIndex(bool inOut, bool isFluid, int cacheIndex, int indexInCache, out FactoryItem* ptr); // 0x0000000183BAF4D0-0x0000000183BAF5A0
		private void __AOT_FOR_FIX__(); // 0x00000001869BC4A8-0x00000001869BC5EC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CacheTransportFragment : IComponentECS // TypeDefIndex: 49725
	{
		// Fields
		public bool autoTransport; // 0x00
		public bool inUse; // 0x01
		public float currentProgress; // 0x04
		public float totalProgress; // 0x08
		public const int ID = 9; // Metadata: 0x0232EACD
	
		// Properties
		public int id { get; } // 0x00000001840C9A50-0x00000001840C9C00 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BC5EC-0x00000001869BC708
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CargoFragment : IComponentECS, IUnitConfigRef, IComparable<CargoFragment> // TypeDefIndex: 49727
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
		public const int ID = 10; // Metadata: 0x0232EACE
	
		// Properties
		public string itemId { get; set; } // 0x00000001869BCA50-0x00000001869BCAA0 0x00000001837ACC00-0x00000001837ACC70
		public int unitAssetInstanceId { get; set; } // 0x00000001869BCAF8-0x00000001869BCB44 0x00000001834CC540-0x00000001834CC580
		public bool recyclable { get; } // 0x00000001869BCAA0-0x00000001869BCAF8 
		public int id { get; } // 0x0000000183BDEE30-0x0000000183BDEE90 
	
		// Nested types
		public struct ItemUV // TypeDefIndex: 49726
		{
			// Fields
			public bool isLiquid; // 0x00
			public int4 itemAtlasRect; // 0x04
			public int4 liquidAtlasRect; // 0x14
		}
	
		// Methods
		public float PredictPos(long serverTime); // 0x00000001869BC884-0x00000001869BC914
		public float PredictPosWithDeltaTime(long deltaTime); // 0x00000001869BC814-0x00000001869BC884
		public int CompareTo(CargoFragment other); // 0x00000001869BC708-0x00000001869BC7C8
		public unsafe bool GetVisible(CargoRendererInfoCollection<CargoRendererInfo>* rendererList); // 0x00000001869BC7C8-0x00000001869BC814
		public static CargoFragment Create(uint unitId, int4 itemAtlasRect, int4 liquidAtlasRect, string itemId, int conveyorSpeed, long tms, int conveyorLength, float minDis, bool isLiquidItem); // 0x00000001837AC8E0-0x00000001837ACBD0
		private void __AOT_FOR_FIX__(); // 0x00000001869BC914-0x00000001869BCA50
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CargoRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49728
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 11; // Metadata: 0x0232EACF
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869BCCA0-0x00000001869BCCEC 0x00000001869BCCEC-0x00000001869BCD44
		public int id { get; } // 0x00000001869BCC50-0x00000001869BCCA0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BCB44-0x00000001869BCC50
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ChapterFragment : IComponentECS // TypeDefIndex: 49729
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
		public const int ID = 12; // Metadata: 0x0232EAD0
	
		// Properties
		public ref BlueprintSlotInfo blueprintSlotInfo { get; } // 0x00000001836B86D0-0x00000001836B8710 
		public int id { get; } // 0x000000018448E7D0-0x000000018448E800 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BCD44-0x00000001869BCE68
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CollectorFragment : IComponentECS // TypeDefIndex: 49730
	{
		// Fields
		public long currentProgress; // 0x00
		public uint collectItem; // 0x08
		public const int ID = 13; // Metadata: 0x0232EAD1
	
		// Properties
		public int id { get; } // 0x0000000184207F00-0x0000000184207F30 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BCE68-0x00000001869BCF80
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct ConnectionFragment : IComponentECS // TypeDefIndex: 49732
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
		public const int ID = 14; // Metadata: 0x0232EAD2
	
		// Properties
		public bool valid { get; } // 0x00000001839635A0-0x00000001839636A0 
		public int id { get; } // 0x0000000183E99D00-0x0000000183E99D60 
	
		// Nested types
		public enum RendererType : byte // TypeDefIndex: 49731
		{
			NORMAL = 0,
			HS = 1
		}
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BCF80-0x00000001869BD0A4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorFragment : IComponentECS, ILogisticSample // TypeDefIndex: 49734
	{
		// Fields
		public uint factoryUnitId; // 0x00
		public float speed; // 0x04
		public UnityEngine.Rect bounds; // 0x08
		[CompilerGenerated]
		private int _length_k__BackingField; // 0x18
		public uint startMemoryOffsetHandle; // 0x1C
		public uint endMemoryOffsetHandle; // 0x20
		public const int ID = 15; // Metadata: 0x0232EAD9
	
		// Properties
		public int length { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public int id { get; } // 0x0000000183CD0870-0x0000000183CD08D0 
	
		// Nested types
		public enum ProtoType : byte // TypeDefIndex: 49733
		{
			LEFT = 0,
			MID = 1,
			RIGHT = 2
		}
	
		// Methods
		public void SetInflection(ref GlobalEnv env, ref NativeList<float3> p, ref NativeList<float3> r, ref NativeArray<byte> proto); // 0x0000000183B28DE0-0x0000000183B29040
		public static void CalcRect(NativeList<float3> posList, ref UnityEngine.Rect b); // 0x0000000183B29040-0x0000000183B291F0
		public bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInConveyor); // 0x00000001869BDC10-0x00000001869BDD7C
		public bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax); // 0x00000001869BDA88-0x00000001869BDC10
		public bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex); // 0x00000001869BD880-0x00000001869BDA88
		public bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets); // 0x00000001869BD664-0x00000001869BD880
		public void DrawDebug(float groundY = 0f /* Metadata: 0x0232EAD5 */); // 0x00000001869BD610-0x00000001869BD664
		private void __AOT_FOR_FIX__(); // 0x00000001869BDD7C-0x00000001869BDEA0
	}

	public interface ILogisticSample // TypeDefIndex: 49735
	{
		// Methods
		bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInLogistic);
		bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax);
		bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex);
		bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets);
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorLogisticsUnitFragment : IComponentECS // TypeDefIndex: 49736
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 16; // Metadata: 0x0232EADD
	
		// Properties
		public int id { get; } // 0x0000000183E15CB0-0x0000000183E15D10 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BE1C0-0x00000001869BE2CC
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct ConveyorRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49737
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int indexInConveyor; // 0x04
		public HGFactoryEntityTransformData transformData; // 0x08
		public float3 position; // 0x08
		public float scale; // 0x14
		public quaternion rotation; // 0x18
		public const int ID = 17; // Metadata: 0x0232EADE
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869BE61C-0x00000001869BE668 0x0000000183E5BC70-0x0000000183E5BCA0
		public int id { get; } // 0x0000000183D4E4E0-0x0000000183D4E5C0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BE4F8-0x00000001869BE61C
	}

	public enum EDirectionType : byte // TypeDefIndex: 49738
	{
		LEFT = 0,
		MID = 1,
		RIGHT = 2
	}

	[BurstCompatible]
	[ECSComponent]
	public struct DirectionFragment : IComponentECS // TypeDefIndex: 49739
	{
		// Fields
		public EDirectionType direction; // 0x00
		public const int ID = 18; // Metadata: 0x0232EAE2
	
		// Properties
		public bool isLeft { get; } // 0x00000001869BEC44-0x00000001869BEC94 
		public bool isMid { get; } // 0x00000001869BEC94-0x00000001869BECE4 
		public bool isRight { get; } // 0x00000001869BECE4-0x00000001869BED34 
		public int id { get; } // 0x0000000183EB92A0-0x0000000183EB96F0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BEB38-0x00000001869BEC44
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CullResultFragment : IComponentECS // TypeDefIndex: 49740
	{
		// Fields
		public bool culled; // 0x00
		public const int ID = 19; // Metadata: 0x0232EAE3
	
		// Properties
		public int id { get; } // 0x0000000183DC0A90-0x0000000183DC0AF0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BE668-0x00000001869BE774
	}

	[BurstCompatible]
	[ECSComponent]
	public struct DebugFragment : IComponentECS // TypeDefIndex: 49741
	{
		// Fields
		public const int ID = 22; // Metadata: 0x0232EAE4
	
		// Properties
		public int id { get; } // 0x00000001869BEAE8-0x00000001869BEB38 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BE9DC-0x00000001869BEAE8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct EvtDestroyUnit : IReactiveComponent // TypeDefIndex: 49742
	{
		// Fields
		public long targetDestroyTime; // 0x00
		public long checkedTime; // 0x08
		public const int ID = 26; // Metadata: 0x0232EAE5
	
		// Properties
		public bool timeout { get; } // 0x00000001869BF480-0x00000001869BF4D4 
		public int id { get; } // 0x00000001837A03E0-0x00000001837A0440 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BF368-0x00000001869BF480
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ShowStateUI : IComponentECS // TypeDefIndex: 49743
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 27; // Metadata: 0x0232EAE6
	
		// Properties
		public int id { get; } // 0x0000000183E32900-0x0000000183E32960 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C2AF8-0x00000001869C2C04
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ShowNameUI : IComponentECS // TypeDefIndex: 49744
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 28; // Metadata: 0x0232EAE7
	
		// Properties
		public int id { get; } // 0x0000000183CE6D20-0x0000000183CE6D80 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C29EC-0x00000001869C2AF8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct HasRenderer : IComponentECS // TypeDefIndex: 49745
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 29; // Metadata: 0x0232EAE8
	
		// Properties
		public int id { get; } // 0x0000000183DF38F0-0x0000000183DF3950 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C1A84-0x00000001869C1B90
	}

	[BurstCompatible]
	[ECSComponent]
	public struct EnvGeneratorUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49746
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 30; // Metadata: 0x0232EAE9
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869BF0CC-0x00000001869BF118 0x00000001847B2220-0x00000001847B2250
		public int id { get; } // 0x00000001846E95A0-0x00000001846E95D0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BEFC0-0x00000001869BF0CC
	}

	public struct EvtUpdatePipeEffect : IFactoryEvent // TypeDefIndex: 49747
	{
		// Fields
		public Entity evtEntity; // 0x00
	
		// Properties
		public Entity eventEntity { get; set; } // 0x000000018415D6C0-0x000000018415D720 0x0000000183C6C9C0-0x0000000183C6CA20
	}

	public struct EvtChangeTemplate : IFactoryEvent // TypeDefIndex: 49748
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
		public Entity eventEntity { get; set; } // 0x0000000183D6B710-0x0000000183D6B740 0x0000000183C6CB60-0x0000000183C6CC60
	}

	public struct EvtCreateUnitRenderer : IFactoryEvent // TypeDefIndex: 49749
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
	
		// Properties
		public Entity eventEntity { get; set; } // 0x00000001834A8EF0-0x00000001834A8F20 0x0000000183C6CA60-0x0000000183C6CAA0
	}

	public struct EvtUpdateStatusEffect : IFactoryEvent // TypeDefIndex: 49750
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000184130CF0-0x0000000184130D50 0x00000001869BF524-0x00000001869BF57C
	}

	public struct EvtPendingCreateRenderer : IFactoryEvent // TypeDefIndex: 49751
	{
		// Fields
		public Entity evtEntity; // 0x00
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000184111860-0x00000001841118C0 0x0000000183C6C960-0x0000000183C6C9C0
	}

	public struct EvtUpdateRendererProperty : IFactoryEvent // TypeDefIndex: 49752
	{
		// Fields
		public bool evtColliderToggle; // 0x00
		public bool colliderToggle; // 0x01
		public bool evtVisible; // 0x02
		public bool visible; // 0x03
		public bool additiveVisible; // 0x04
		public Entity evtEntity; // 0x08
	
		// Properties
		public Entity eventEntity { get; set; } // 0x00000001834A4850-0x00000001834A4880 0x0000000183C6CA20-0x0000000183C6CA60
	}

	public struct EvtStatusChange : IFactoryEvent // TypeDefIndex: 49753
	{
		// Fields
		public bool forceUpdate; // 0x00
		public Entity evtEntity; // 0x04
	
		// Properties
		public Entity eventEntity { get; set; } // 0x00000001869BF4D4-0x00000001869BF524 0x0000000183C6C900-0x0000000183C6C960
	}

	public struct EvtCreateInteract : IFactoryEvent // TypeDefIndex: 49754
	{
		// Fields
		public ulong interactObjectId; // 0x00
		public Entity evtEntity; // 0x08
		public ulong evtEntityId; // 0x08
	
		// Properties
		public Entity eventEntity { get; set; } // 0x00000001869BF318-0x00000001869BF368 0x0000000183C6CB20-0x0000000183C6CB60
	}

	public struct EvtVatUpdate : IFactoryEvent // TypeDefIndex: 49755
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public byte placeHolder; // 0x08
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000184173630-0x0000000184173660 0x0000000183C6CAE0-0x0000000183C6CB20
	}

	public struct EvtUpdatePedestalColorLUT : IFactoryEvent // TypeDefIndex: 49756
	{
		// Fields
		public bool light; // 0x00
		public Entity evtEntity; // 0x04
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000184320900-0x0000000184320930 0x0000000183C6CAA0-0x0000000183C6CAE0
	}

	public enum EvtAudioType : short // TypeDefIndex: 49757
	{
		BUILDING_STATUS = 1,
		BUILDING_DESTROY = 2
	}

	[Flags]
	public enum AudioCullingState : byte // TypeDefIndex: 49758
	{
		AUDIBLE = 1,
		PENDING_CULL = 2,
		CULLED = 4,
		CULLED_CUR_FRAME = 6,
		PENDING_RESTORE = 8,
		AUDIBLE_CUR_FRAME = 9
	}

	public enum AudioDebugGizmosType : byte // TypeDefIndex: 49759
	{
		NONE = 0,
		GROUP_EMITTER_AREA1 = 1,
		GROUP_EMITTER_AREA2 = 2,
		GROUP_EMITTER_AREA3 = 3,
		GROUP_EMITTER_OUT_OF_RANGE = 4,
		GROUP_EMITTER_NOT_CONSIDERED_TYPE = 5,
		GROUP_EMITTER_NOT_CONSIDERED_STATUS = 6
	}

	public struct EvtAudio : IFactoryEvent // TypeDefIndex: 49760
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public EvtAudioType evtType; // 0x08
	
		// Properties
		public Entity eventEntity { get; set; } // 0x0000000184130D50-0x0000000184130DB0 0x00000001869BF2C0-0x00000001869BF318
	}

	[BurstCompatible]
	[ECSComponent]
	public struct AudioFragment : IComponentECS // TypeDefIndex: 49761
	{
		// Fields
		public uint audioFragmentId; // 0x00
		public float distSqToListener; // 0x04
		public AudioCullingState cullingState; // 0x08
		public const int ID = 31; // Metadata: 0x0232EAFB
	
		// Properties
		public int id { get; } // 0x0000000183AB3300-0x0000000183AB3360 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BB53C-0x00000001869BB658
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ReleaseTagFragment : IComponentECS // TypeDefIndex: 49762
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 32; // Metadata: 0x0232EAFC
	
		// Properties
		public int id { get; } // 0x0000000183E20A50-0x0000000183E20AB0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C2564-0x00000001869C2670
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CurMapUnitTag : IComponentECS // TypeDefIndex: 49763
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 33; // Metadata: 0x0232EAFD
	
		// Properties
		public int id { get; } // 0x00000001830C9930-0x00000001830C9990 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BE774-0x00000001869BE880
	}

	public struct StaticMountOffset // TypeDefIndex: 49764
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
	public struct UnitFragment : IComponentECS // TypeDefIndex: 49765
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
		public const int ID = 34; // Metadata: 0x0232EB0E
	
		// Properties
		public FCNodeMode formulaManMode { get; set; } // 0x00000001832912C0-0x0000000183291320 0x00000001837AC200-0x00000001837AC260
		public bool needRepair { get; } // 0x00000001869C3300-0x00000001869C3350 
		public bool battleBroken { get; } // 0x00000001869C32B0-0x00000001869C3300 
		public bool socialUnit { get; } // 0x00000001839661A0-0x0000000183966200 
		public bool isInvalidPlaced { get; } // 0x000000018398A700-0x000000018398A730 
		public bool isPrefabBuilding { get; } // 0x00000001830DD5F0-0x00000001830DD640 
		public string templateId { get; set; } // 0x0000000183290AC0-0x0000000183290D40 0x00000001837AC340-0x00000001837AC3B0
		public string rendererTemplateId { get; set; } // 0x0000000183291260-0x00000001832912C0 0x00000001837ACC70-0x00000001837ACCE0
		public string logisticBaseRendererTemplateId { get; set; } // 0x00000001837AA0F0-0x00000001837AA120 0x00000001837AC260-0x00000001837AC2D0
		public string nonLogisticBaseRendererTemplateId { get; set; } // 0x00000001837AA120-0x00000001837AA150 0x00000001837AC2D0-0x00000001837AC340
		public string instKey { get; set; } // 0x00000001830DD640-0x00000001830DD670 0x00000001837ACCE0-0x00000001837ACFE0
		public bool pipeValid { get; } // 0x00000001869C3350-0x00000001869C33A8 
		public int id { get; } // 0x00000001838C71D0-0x00000001838C7230 
	
		// Methods
		public static UnitFragment Create(uint nodeId, string templateId, int nodeType, bool2 buildDismissEnabled, int level = 0 /* Metadata: 0x0232EAFE */, uint nodeFlag = 0 /* Metadata: 0x0232EAFF */, string rendererTemplateId = "" /* Metadata: 0x0232EB00 */, bool inBlock = false /* Metadata: 0x0232EB01 */, bool inPower = false /* Metadata: 0x0232EB02 */, bool inActive = true /* Metadata: 0x0232EB03 */, long powerCost = 0 /* Metadata: 0x0232EB04 */, FCNodeMode formulaManMode = FCNodeMode.None | FCNodeMode.normal /* Metadata: 0x0232EB0C */, string instKey = "" /* Metadata: 0x0232EB0D */); // 0x00000001837ABF60-0x00000001837AC200
		private void __AOT_FOR_FIX__(); // 0x00000001869C316C-0x00000001869C32B0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitRenderPipeLogisticsFigureReplaceFragment : IComponentECS // TypeDefIndex: 49766
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 35; // Metadata: 0x0232EB0F
	
		// Properties
		public int id { get; } // 0x0000000183EB7AC0-0x0000000183EB7B20 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C3974-0x00000001869C3A80
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BusRenderFragment : IComponentECS // TypeDefIndex: 49767
	{
		// Fields
		public int idx; // 0x00
		public const int ID = 36; // Metadata: 0x0232EB10
	
		// Properties
		public int id { get; } // 0x00000001869BC458-0x00000001869BC4A8 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BC34C-0x00000001869BC458
	}

	public enum EUnitRenderType : byte // TypeDefIndex: 49768
	{
		BUILDING = 0,
		PEDESTAL = 1,
		ONLY = 2
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitRenderTypeFragment : IComponentECS // TypeDefIndex: 49769
	{
		// Fields
		public EUnitRenderType renderType; // 0x00
		public const int ID = 37; // Metadata: 0x0232EB14
	
		// Properties
		public bool isBuilding { get; } // 0x00000001837B2CC0-0x00000001837B2D20 
		public bool isPedestal { get; } // 0x0000000183923070-0x00000001839230A0 
		public bool isOnly { get; } // 0x00000001869C3B8C-0x00000001869C3BDC 
		public bool isRegular { get; } // 0x00000001869C3BDC-0x00000001869C3C38 
		public int id { get; } // 0x0000000183CB4750-0x0000000183CB47B0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C3A80-0x00000001869C3B8C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FakeUnitFragment : IComponentECS // TypeDefIndex: 49770
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 38; // Metadata: 0x0232EB15
	
		// Properties
		public int id { get; } // 0x0000000183DAE8F0-0x0000000183DAE950 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BFFEC-0x00000001869C00F8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UIUnitFragment : IComponentECS // TypeDefIndex: 49771
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 39; // Metadata: 0x0232EB16
	
		// Properties
		public int id { get; } // 0x0000000183A3DC90-0x0000000183A3DCF0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C3060-0x00000001869C316C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct GuideHintFragment : IComponentECS // TypeDefIndex: 49772
	{
		// Fields
		public int hashKey; // 0x00
		public const int ID = 40; // Metadata: 0x0232EB17
	
		// Properties
		public int id { get; } // 0x0000000183E59AA0-0x0000000183E59B00 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C1978-0x00000001869C1A84
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitPreviewFragment : IComponentECS // TypeDefIndex: 49775
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
		public const int ID = 41; // Metadata: 0x0232EB18
	
		// Properties
		public string templateId { get; set; } // 0x00000001869C36A0-0x00000001869C3724 0x00000001869C38E0-0x00000001869C3974
		public string previewRendererTemplateId { get; set; } // 0x00000001869C361C-0x00000001869C36A0 0x00000001869C384C-0x00000001869C38E0
		public string logisticPedestalRendererTemplateId { get; set; } // 0x00000001869C34C4-0x00000001869C3548 0x00000001869C3724-0x00000001869C37B8
		public string nonLogisticPedestalRendererTemplateId { get; set; } // 0x00000001869C3548-0x00000001869C35CC 0x00000001869C37B8-0x00000001869C384C
		public bool pipeValid { get; } // 0x00000001869C35CC-0x00000001869C361C 
		public int id { get; } // 0x0000000183DC24E0-0x0000000183DC2540 
	
		// Nested types
		public enum EntityTarget // TypeDefIndex: 49773
		{
			BUILDING = 0,
			PEDESTAL = 1
		}
	
		public enum EntityType // TypeDefIndex: 49774
		{
			NORMAL = 0,
			BLUEPRINT = 1
		}
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C33A8-0x00000001869C34C4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorRegularFragment : IComponentECS // TypeDefIndex: 49776
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 42; // Metadata: 0x0232EB1D
	
		// Properties
		public int id { get; } // 0x0000000183FFACF0-0x0000000183FFAD50 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BE3EC-0x00000001869BE4F8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorGuideFragment : IComponentECS // TypeDefIndex: 49777
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 43; // Metadata: 0x0232EB1E
	
		// Properties
		public int id { get; } // 0x0000000183F9B810-0x0000000183F9B870 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BDEA0-0x00000001869BDFAC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeRegularFragment : IComponentECS // TypeDefIndex: 49778
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 45; // Metadata: 0x0232EB1F
	
		// Properties
		public int id { get; } // 0x00000001840349D0-0x0000000184034A30 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C21FC-0x00000001869C2308
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorPreviewRendererFragment : IComponentECS // TypeDefIndex: 49779
	{
		// Fields
		public bool valid; // 0x00
		public UnitPreviewFragment.EntityType entityType; // 0x04
		public int length; // 0x08
		public uint startMemoryOffsetHandle; // 0x0C
		public uint endMemoryOffsetHandle; // 0x10
		public const int ID = 46; // Metadata: 0x0232EB20
	
		// Properties
		public int id { get; } // 0x0000000183FB3AC0-0x0000000183FB3B20 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869BE2CC-0x00000001869BE3EC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipePreviewRendererFragment : IComponentECS // TypeDefIndex: 49780
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
		public const int ID = 47; // Metadata: 0x0232EB21
	
		// Properties
		public int id { get; } // 0x0000000183D9E6B0-0x0000000183D9E710 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C20E0-0x00000001869C21FC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipePreviewFragment : IComponentECS // TypeDefIndex: 49781
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 48; // Metadata: 0x0232EB22
	
		// Properties
		public int id { get; } // 0x0000000184B0C270-0x0000000184B0C2A0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C1FD4-0x00000001869C20E0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49782
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 49; // Metadata: 0x0232EB23
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869C051C-0x00000001869C0568 0x0000000183E5C7B0-0x0000000183E5C7E0
		public int id { get; } // 0x000000018424C9D0-0x000000018424CA00 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C0400-0x00000001869C051C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderDirectionFragment : IComponentECS // TypeDefIndex: 49783
	{
		// Fields
		public EDirectionType direction; // 0x00
		public const int ID = 50; // Metadata: 0x0232EB24
	
		// Properties
		public bool isLeft { get; } // 0x00000001869C0310-0x00000001869C0360 
		public bool isMid { get; } // 0x00000001869C0360-0x00000001869C03B0 
		public bool isRight { get; } // 0x00000001869C03B0-0x00000001869C0400 
		public int id { get; } // 0x00000001843CBE90-0x00000001843CBF80 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C0204-0x00000001869C0310
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderPipeHolderFragment : IComponentECS // TypeDefIndex: 49784
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 51; // Metadata: 0x0232EB25
	
		// Properties
		public int id { get; } // 0x0000000184D274E0-0x0000000184D27510 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C0568-0x00000001869C0674
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderConveyorLogisticsFragment : IComponentECS // TypeDefIndex: 49785
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 52; // Metadata: 0x0232EB26
	
		// Properties
		public int id { get; } // 0x0000000184D27580-0x0000000184D275B0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C00F8-0x00000001869C0204
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidConsumeFragment : IComponentECS // TypeDefIndex: 49786
	{
		// Fields
		public long progress; // 0x00
		public const int ID = 53; // Metadata: 0x0232EB27
	
		// Properties
		public int id { get; } // 0x0000000184255600-0x0000000184255630 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C06CC-0x00000001869C07D8
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct FluidContainerFragment : IComponentECS // TypeDefIndex: 49787
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
		public const int ID = 54; // Metadata: 0x0232EB28
	
		// Properties
		public int id { get; } // 0x0000000183FD21F0-0x0000000183FD2220 
	
		// Methods
		public void Set(int index, int itemId, int itemAmount, int itemSubType); // 0x0000000183920A40-0x0000000183920AD0
		public void SetCapacity(int index, int cap); // 0x00000001839209F0-0x0000000183920A40
		public void SetAmount(int index, int amount); // 0x00000001869C0D48-0x00000001869C0DBC
		public void SetRenderAmount(int index, float amount); // 0x0000000183BAD380-0x0000000183BAD3D0
		public bool Get(int index, out int itemId, out int itemAmount, out float renderItemAmount, out int itemSubType, out int cap); // 0x00000001837A8E30-0x00000001837A8EC0
		public bool HasLiquid(); // 0x00000001869C0CE0-0x00000001869C0D48
		public void CalcRenderItemAmount(float step); // 0x00000001869C07D8-0x00000001869C0B5C
		public ValueTuple<int, uint> GetOffsetData(); // 0x00000001869C0B5C-0x00000001869C0CE0
		public void Reset(); // 0x0000000183BACAF0-0x0000000183BACBE0
		public override string ToString(); // 0x00000001869C0DBC-0x00000001869C1790
		private void __AOT_FOR_FIX__(); // 0x00000001869C1838-0x00000001869C1978
		public string __iFixBaseProxy_ToString(); // 0x00000001869C1790-0x00000001869C1838
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidPumpInFragment : IComponentECS // TypeDefIndex: 49788
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 55; // Metadata: 0x0232EB29
	
		// Properties
		public int id { get; } // 0x0000000184234170-0x00000001842341A0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C5144-0x00000001869C5250
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidPumpOutFragment : IComponentECS // TypeDefIndex: 49789
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 56; // Metadata: 0x0232EB2A
	
		// Properties
		public int id { get; } // 0x000000018480E8B0-0x000000018480E8E0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C5250-0x00000001869C535C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidReactionFragment : IComponentECS // TypeDefIndex: 49790
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 57; // Metadata: 0x0232EB2B
	
		// Properties
		public int id { get; } // 0x00000001846AA9E0-0x00000001846AAA10 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C535C-0x00000001869C5468
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidSprayFragment : IComponentECS // TypeDefIndex: 49791
	{
		// Fields
		public long progress; // 0x00
		public const int ID = 58; // Metadata: 0x0232EB2C
	
		// Properties
		public int id { get; } // 0x00000001869C5574-0x00000001869C55C4 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C5468-0x00000001869C5574
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FormulaManualFragment : IComponentECS // TypeDefIndex: 49792
	{
		// Fields
		public int currentGroup; // 0x00
		public int currentMode; // 0x04
		public int lockedFormulaId; // 0x08
		public const int ID = 59; // Metadata: 0x0232EB2D
	
		// Properties
		public int id { get; } // 0x0000000183F657B0-0x0000000183F657E0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C55C4-0x00000001869C56E0
	}

	public struct EvtLogisticFigureRenderer // TypeDefIndex: 49793
	{
		// Fields
		public bool triggered; // 0x00
		public int figureType; // 0x04
		public static readonly byte S_NONE; // 0x00
		public static readonly byte S_PIPE; // 0x01
		public static readonly byte S_CONVEYOR; // 0x02
		public static readonly byte S_CONVEYOR_GUIDE; // 0x03
	
		// Constructors
		static EvtLogisticFigureRenderer(); // 0x0000000184D38280-0x0000000184D382F0
	}

	public struct OutOfBufferWarning // TypeDefIndex: 49794
	{
		// Fields
		public bool pipe; // 0x00
		public bool wire; // 0x01
		public bool conveyor; // 0x02
		public bool cargo; // 0x03
		public bool operated; // 0x04
	
		// Methods
		public void ResetFlags(); // 0x0000000184CA2E30-0x0000000184CA2E60
		public override string ToString(); // 0x00000001869C9B34-0x00000001869C9D00
		public string __iFixBaseProxy_ToString(); // 0x00000001869C9D00-0x00000001869C9D54
	}

	[Flags]
	public enum FacSystemTickSkipSource : byte // TypeDefIndex: 49795
	{
		NONE = 0,
		MAP = 1,
		UI = 2,
		GM = 128,
		ALL = 255
	}

	[BurstCompatible]
	[ECSComponent]
	public struct GlobalEnv : IComponentECS // TypeDefIndex: 49796
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
		public EntityQueryV2.QueryResultDefer envReceiverRendererQueryResult; // 0x108
		public EntityQueryV2.QueryResultDefer additiveEffectQueryResult; // 0x120
		public EntityQueryV2.QueryResultDefer hintEffectQueryResult; // 0x138
		public EntityQueryV2.QueryResultDefer additiveEffectRendererQueryResult; // 0x150
		public JobHandle baseTickChainJobHandle; // 0x168
		public JobHandle crossFrameJobHandle; // 0x178
		public JobHandle cullingJobHandle; // 0x188
		public JobHandle l2wJobHandle; // 0x198
		public JobHandle cargoPredictJobHandle; // 0x1A8
		public JobHandle cargoRenderJobHandle; // 0x1B8
		public JobHandle lookAtJobHandle; // 0x1C8
		public JobHandle conveyorFigureRenderJobHandle; // 0x1D8
		public JobHandle portArrowRenderJobHandle; // 0x1E8
		public JobHandle portConveyorInsideRenderJobHandle; // 0x1F8
		public long anyTransChangedFrame; // 0x208
		public bool evtLevelLoadStatus; // 0x210
		public bool evtTopViewChanged; // 0x211
		public bool evtPipeDirty; // 0x212
		public bool evtForceUpdatePreviewPortRenderer; // 0x213
		public bool firstEnterGameScene; // 0x214
		public EvtLogisticFigureRenderer evtLogisticFigureRenderer; // 0x218
		public bool systemUnlockedPipe; // 0x220
		public bool systemUnlockedConveyor; // 0x221
		public bool useDistanceFilter; // 0x222
		public float2 distanceFilterCenterPos; // 0x224
		public float distanceThreshold; // 0x22C
		public unsafe FactoryEventChannels* eventChannels; // 0x230
		public float4x4 arrowUV; // 0x238
		public float2 arrowOffset; // 0x278
		public float conveyorOffsetY; // 0x280
		public bool UIBuildingAnimationEnabled; // 0x284
		public bool vatEnableEnvDirty; // 0x285
		public bool buildingNameInvalid; // 0x286
		public bool topViewEnable; // 0x287
		public bool showOutputUI; // 0x288
		public bool showEnvGeneratorUI; // 0x289
		public bool inBuildMode; // 0x28A
		public bool buildConveyor; // 0x28B
		public bool buildPipe; // 0x28C
		public bool simpleConveyor; // 0x28D
		public bool simplePipe; // 0x28E
		public bool inputDisable; // 0x28F
		public bool outputDisable; // 0x290
		public bool inputFluidDisable; // 0x291
		public bool outputFluidDisable; // 0x292
		public unsafe InteractFacCollectJob.BuildingInfoWrap* interactBuilding; // 0x298
		public unsafe InteractFacCollectJob.LogisticInfo* conveyorInfo; // 0x2A0
		public unsafe InteractFacCollectJob.LogisticInfo* pipeInfo; // 0x2A8
		public unsafe InteractFacCollectJob.BuildingInfoWrap* interactBuildingLast; // 0x2B0
		public unsafe InteractFacCollectJob.LogisticInfo* conveyorInfoLast; // 0x2B8
		public unsafe InteractFacCollectJob.LogisticInfo* pipeInfoLast; // 0x2C0
		public unsafe UnsafeList<float4x4>* portBlockPosListPtr; // 0x2C8
		public unsafe UnsafeList<OutputRendererInfo>* outputUIPosListPtr; // 0x2D0
		public unsafe UnsafeList<EnvGeneratorRendererInfo>* envGeneratorUIPosListPtr; // 0x2D8
		public unsafe UnsafeList<float4x4>* buildingStatePosListPtr; // 0x2E0
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* cargoMatricesBufferWriter; // 0x2E8
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* cargoMatricesBufferReader; // 0x2F0
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorLPosMatricesBufferWriter; // 0x2F8
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorMPosMatricesBufferWriter; // 0x300
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorRPosMatricesBufferWriter; // 0x308
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorLPosMatricesBufferReader; // 0x310
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorMPosMatricesBufferReader; // 0x318
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorRPosMatricesBufferReader; // 0x320
		public unsafe UnsafeList<Matrix4x4>* conveyorLogPosMatricesPtr; // 0x328
		public bool bConflictCheck; // 0x330
		public IntPtr arrowPlacedDicPtr; // 0x338
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* portArrowMatricesWriter; // 0x340
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* portArrowMatricesReader; // 0x348
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewLPosMatricesWriter; // 0x350
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewMPosMatricesWriter; // 0x358
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewRPosMatricesWriter; // 0x360
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewLPosMatricesReader; // 0x368
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewMPosMatricesReader; // 0x370
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* conveyorPreviewRPosMatricesReader; // 0x378
		public unsafe UnsafeList<float4x4>* conveyorInsideMatricesPtr; // 0x380
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureLPosMatricesBufferWriter; // 0x388
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureMPosMatricesBufferWriter; // 0x390
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureRPosMatricesBufferWriter; // 0x398
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureLPosMatricesBufferReader; // 0x3A0
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureMPosMatricesBufferReader; // 0x3A8
		public unsafe ConveyorRendererInfoCollection<ConveyorRendererInfo>* guideFigureRPosMatricesBufferReader; // 0x3B0
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeLPosMatricesBufferWriter; // 0x3B8
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeMPosMatricesBufferWriter; // 0x3C0
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeRPosMatricesBufferWriter; // 0x3C8
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeLPosMatricesBufferReader; // 0x3D0
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeMPosMatricesBufferReader; // 0x3D8
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* pipeRPosMatricesBufferReader; // 0x3E0
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeLPosMatricesBufferWriter; // 0x3E8
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeMPosMatricesBufferWriter; // 0x3F0
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeRPosMatricesBufferWriter; // 0x3F8
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeLPosMatricesBufferReader; // 0x400
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeMPosMatricesBufferReader; // 0x408
		public unsafe PipeRendererInfoCollection<PipeRendererInfo>* gasPipeRPosMatricesBufferReader; // 0x410
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackLPosMatricesBufferWriter; // 0x418
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackMPosMatricesBufferWriter; // 0x420
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackRPosMatricesBufferWriter; // 0x428
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackLPosMatricesBufferReader; // 0x430
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackMPosMatricesBufferReader; // 0x438
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* pipeTrackRPosMatricesBufferReader; // 0x440
		public unsafe UnsafeList<Matrix4x4>* pipeHolderPosMatricesPtr; // 0x448
		public unsafe UnsafeList<float4x4>* comPosMatricesPtr; // 0x450
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireNormalBufferWriter; // 0x458
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsNormalBufferWriter; // 0x460
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireDisableBufferWriter; // 0x468
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenBufferWriter; // 0x470
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsStrengthenBufferWriter; // 0x478
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenDisableBufferWriter; // 0x480
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireNormalBufferReader; // 0x488
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsNormalBufferReader; // 0x490
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireDisableBufferReader; // 0x498
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenBufferReader; // 0x4A0
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireHsStrengthenBufferReader; // 0x4A8
		public unsafe WireRendererInfoCollection<WireRendererInfo>* wireStrengthenDisableBufferReader; // 0x4B0
		public bool levelShowForceUpdate; // 0x4B8
		public bool conveyorEffectDirty; // 0x4B9
		public bool pipeEffectDirty; // 0x4BA
		public unsafe ConveyorInfoAllocator* conveyorInfoAllocator; // 0x4C0
		public unsafe UnsafeList<VATFSMProcessor.SetAnimatorParamRequest>* animatorParamRequestQueue; // 0x4C8
		public unsafe UnsafeList<VATFSMProcessor.VATFSMAudioData>* animatorAudioQueue; // 0x4D0
		public const int ID = 61; // Metadata: 0x0232EB36
	
		// Properties
		public bool facSystemTickEnabled { get; } // 0x00000001834CEB10-0x00000001834CEB80 
		public UnsafeList<float4x4> portBlockPosListReader { get; } // 0x00000001838AB060-0x00000001838AB0C0 
		public UnsafeList<OutputRendererInfo> outputUIPosListReader { get; } // 0x0000000184163030-0x0000000184163090 
		public UnsafeList<EnvGeneratorRendererInfo> envGeneratorUIPosListReader { get; } // 0x0000000184163280-0x00000001841632E0 
		public UnsafeList<float4x4> buildingStatePosListReader { get; } // 0x000000018345CFB0-0x000000018345D070 
		public IntPtr cargoMatricesBufferIntPtrReader { get; } // 0x0000000183D1F680-0x0000000183D1F6B0 
		public int cargoRendererCount { get; } // 0x0000000183D1F640-0x0000000183D1F680 
		public bool cargoDirty { get; } // 0x0000000183D1F3D0-0x0000000183D1F640 
		public IntPtr conveyorLPosMatricesBufferIntPtrReader { get; } // 0x0000000183D21520-0x0000000183D21550 
		public IntPtr conveyorMPosMatricesBufferIntPtrReader { get; } // 0x0000000183D21550-0x0000000183D21580 
		public IntPtr conveyorRPosMatricesBufferIntPtrReader { get; } // 0x0000000183D21580-0x0000000183D215B0 
		public int lConveyorRenderCount { get; } // 0x0000000183D21260-0x0000000183D212A0 
		public int mConveyorRenderCount { get; } // 0x0000000183D212A0-0x0000000183D212E0 
		public int rConveyorRenderCount { get; } // 0x0000000183D212E0-0x0000000183D21320 
		public bool conveyorDirty { get; } // 0x00000001830D1FC0-0x00000001830D2350 
		public UnsafeList<Matrix4x4> conveyorLogPosMatricesReader { get; } // 0x00000001869C6780-0x00000001869C6800 
		public IntPtr portArrowMatricesIntPtrReader { get; } // 0x000000018345A6F0-0x000000018345A720 
		public int portArrowRenderCount { get; } // 0x000000018345C470-0x000000018345C4D0 
		public bool portArrowDirty { get; } // 0x00000001869C6A20-0x00000001869C6B70 
		public IntPtr conveyorPreviewLPosMatricesIntPtrReader { get; } // 0x0000000183D215B0-0x0000000183D215E0 
		public IntPtr conveyorPreviewMPosMatricesIntPtrReader { get; } // 0x0000000183D215E0-0x0000000183D21610 
		public IntPtr conveyorPreviewRPosMatricesIntPtrReader { get; } // 0x0000000183D21610-0x0000000183D21640 
		public int lConveyorPreviewRenderCount { get; } // 0x0000000183D21320-0x0000000183D21360 
		public int mConveyorPreviewRenderCount { get; } // 0x0000000183D21360-0x0000000183D213A0 
		public int rConveyorPreviewRenderCount { get; } // 0x0000000183D213A0-0x0000000183D213E0 
		public UnsafeList<float4x4> conveyorInsideMatricesReader { get; } // 0x000000018345A720-0x000000018345A780 
		public bool previewConveyorDirty { get; } // 0x00000001830D2350-0x00000001830D26E0 
		public IntPtr guideFigureLPosMatricesBufferIntPtrReader { get; } // 0x00000001869C6800-0x00000001869C6850 
		public IntPtr guideFigureMPosMatricesBufferIntPtrReader { get; } // 0x00000001869C6850-0x00000001869C68A0 
		public IntPtr guideFigureRPosMatricesBufferIntPtrReader { get; } // 0x00000001869C68A0-0x00000001869C68F0 
		public int lGuideFigureRenderCount { get; } // 0x00000001869C68F0-0x00000001869C6948 
		public int mGuideFigureRenderCount { get; } // 0x00000001869C6948-0x00000001869C69A0 
		public int rGuideFigureRenderCount { get; } // 0x00000001869C6B70-0x00000001869C6BC8 
		public bool guideFigureDirty { get; } // 0x00000001830CFE60-0x00000001830D01F0 
		public IntPtr pipeLPosMatricesBufferIntPtrReader { get; } // 0x000000018345CAA0-0x000000018345CAD0 
		public IntPtr pipeMPosMatricesBufferIntPtrReader { get; } // 0x000000018345CAD0-0x000000018345CB00 
		public IntPtr pipeRPosMatricesBufferIntPtrReader { get; } // 0x000000018345CB00-0x000000018345CB30 
		public int lPipeRenderCount { get; } // 0x000000018345C7C0-0x000000018345C800 
		public int mPipeRenderCount { get; } // 0x000000018345C800-0x000000018345C840 
		public int rPipeRenderCount { get; } // 0x000000018345C840-0x000000018345C880 
		public IntPtr gasPipeLPosMatricesBufferIntPtrReader { get; } // 0x000000018345CB30-0x000000018345CB60 
		public IntPtr gasPipeMPosMatricesBufferIntPtrReader { get; } // 0x000000018345CB60-0x000000018345CB90 
		public IntPtr gasPipeRPosMatricesBufferIntPtrReader { get; } // 0x000000018345CB90-0x000000018345CBC0 
		public int lGasPipeRenderCount { get; } // 0x000000018345C880-0x000000018345C8C0 
		public int mGasPipeRenderCount { get; } // 0x000000018345C8C0-0x000000018345C900 
		public int rGasPipeRenderCount { get; } // 0x000000018345C900-0x000000018345C940 
		public IntPtr pipeTrackLPosMatricesBufferIntPtrReader { get; } // 0x000000018345CBC0-0x000000018345CBF0 
		public IntPtr pipeTrackMPosMatricesBufferIntPtrReader { get; } // 0x000000018345CBF0-0x000000018345CC20 
		public IntPtr pipeTrackRPosMatricesBufferIntPtrReader { get; } // 0x000000018345CC20-0x000000018345CC50 
		public int lPipeTrackRenderCount { get; } // 0x000000018345C940-0x000000018345C980 
		public int mPipeTrackRenderCount { get; } // 0x000000018345C980-0x000000018345C9C0 
		public int rPipeTrackRenderCount { get; } // 0x000000018345C9C0-0x000000018345CA00 
		public bool anyPipeDirty { get; } // 0x000000018345CC50-0x000000018345CCA0 
		public bool pipeDirty { get; } // 0x00000001830D2A20-0x00000001830D2D40 
		public bool gasPipeDirty { get; } // 0x00000001830D2D40-0x00000001830D3060 
		public UnsafeList<Matrix4x4> pipeHolderPosMatricesReader { get; } // 0x00000001869C69A0-0x00000001869C6A20 
		public UnsafeList<float4x4> comPosMatricesReader { get; } // 0x000000018345CCA0-0x000000018345CD60 
		public IntPtr wireNormalBufferIntPtrReader { get; } // 0x0000000184D26130-0x0000000184D26160 
		public IntPtr wireHsNormalBufferIntPtrReader { get; } // 0x0000000184D26190-0x0000000184D261C0 
		public IntPtr wireDisableBufferIntPtrReader { get; } // 0x00000001869C6BC8-0x00000001869C6C18 
		public IntPtr wireStrengthenBufferIntPtrReader { get; } // 0x00000001869C6C8C-0x00000001869C6CDC 
		public IntPtr wireHsStrengthenBufferIntPtrReader { get; } // 0x0000000184D26160-0x0000000184D26190 
		public IntPtr wireStrengthenDisableBufferIntPtrReader { get; } // 0x00000001869C6CDC-0x00000001869C6D2C 
		public int wireNormalRendererCount { get; } // 0x00000001848AC780-0x00000001848AC7D0 
		public int wireHsNormalRendererCount { get; } // 0x00000001848AC820-0x00000001848AC870 
		public int wireDisableRendererCount { get; } // 0x00000001869C6C18-0x00000001869C6C8C 
		public int wireStrengthenRendererCount { get; } // 0x00000001869C6DA0-0x00000001869C6DF8 
		public int wireHsStrengthenRendererCount { get; } // 0x00000001848AC7D0-0x00000001848AC820 
		public int wireStrengthenDisableRendererCount { get; } // 0x00000001869C6D2C-0x00000001869C6DA0 
		public bool wireNormalDirty { get; } // 0x0000000183E1DCA0-0x0000000183E1DF10 
		public bool wireHsNormalDirty { get; } // 0x0000000183E1DF10-0x0000000183E1E180 
		public bool wireDisableDirty { get; } // 0x0000000183E1E260-0x0000000183E1E4D0 
		public bool wireStrengthenDirty { get; } // 0x00000001830D3540-0x00000001830D37B0 
		public bool wireHsStrengthenDirty { get; } // 0x00000001830D32D0-0x00000001830D3540 
		public bool wireStrengthenDisableDirty { get; } // 0x00000001830D3060-0x00000001830D32D0 
		public UnsafeList<VATFSMProcessor.SetAnimatorParamRequest> animatorParamRequestQueueReader { get; } // 0x00000001869C66E4-0x00000001869C6780 
		public UnsafeList<VATFSMProcessor.VATFSMAudioData> animatorAudioQueueWriter { get; } // 0x00000001838ACF10-0x00000001838ACF80 
		public int id { get; } // 0x0000000183818850-0x00000001838188B0 
	
		// Methods
		public void InitSkipFlag(); // 0x00000001834D9AA0-0x00000001834D9AD0
		public void CreateQueryResult(); // 0x00000001845F5DA0-0x00000001845F5F00
		public void DisposeQueryResult(); // 0x00000001869C58A8-0x00000001869C5984
		public void SwapCargoBuffer(); // 0x00000001869C5AB8-0x00000001869C5B54
		public unsafe void SetConveyorBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1); // 0x0000000184D8CE90-0x0000000184D8CED0
		public void SwapConveyorBuffer(); // 0x00000001869C5B54-0x00000001869C5C28
		public unsafe void SetPortArrowBuffers(void* buffer0, void* buffer1); // 0x0000000184D8CED0-0x0000000184D8CEE0
		public void SwapPortArrowBuffer(); // 0x00000001869C5E88-0x00000001869C5F24
		public unsafe void SetPreviewConveyorBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1); // 0x0000000184D8CEE0-0x0000000184D8CF20
		public void SwapPreviewConveyorBuffer(); // 0x00000001869C5F24-0x00000001869C5FF8
		public unsafe void SeGuideFigureBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1); // 0x0000000184D8CE50-0x0000000184D8CE90
		public void SwapGuideFigureBuffer(); // 0x00000001869C5C28-0x00000001869C5CFC
		public unsafe void SetPipeBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1, void* gasLBuffer0, void* gasLBuffer1, void* gasMBuffer0, void* gasMBuffer1, void* gasRBuffer0, void* gasRBuffer1, void* trackLBuffer0, void* trackLBuffer1, void* trackMBuffer0, void* trackMBuffer1, void* trackRBuffer0, void* trackRBuffer1); // 0x0000000184CDEA70-0x0000000184CDEB50
		public void SwapPipeBuffer(); // 0x00000001869C5CFC-0x00000001869C5E88
		public unsafe void SetWireBuffer(void* normal0, void* normal1, void* hsNormal0, void* hsNormal1, void* disable0, void* disable1, void* strengthen0, void* strengthen1, void* hsStrengthen0, void* hsStrengthen1, void* strengthenDisable0, void* strengthenDisable1); // 0x0000000184D2CDF0-0x0000000184D2CE80
		public void SwapWireBuffer(); // 0x00000001869C5FF8-0x00000001869C6124
		[IDTag(0)]
		public unsafe void GetConveyorRendererInfo(uint memoryStartOffset, int countIdx, out ConveyorInfoAllocator.Info* info); // 0x0000000183445920-0x00000001834459D0
		[IDTag(1)]
		public ref ConveyorInfoAllocator.Info GetConveyorRendererInfo(uint memoryStartOffset, int countIdx); // 0x0000000183445830-0x0000000183445920
		public LinearAllocator.Allocation AllocateConveyorInfo(int count); // 0x0000000183B29660-0x0000000183B296E0
		public long CalculateConveyorInfoSize(uint memoryOffset); // 0x00000001869C57EC-0x00000001869C5854
		public LinearAllocator.Allocation ResizeConveyorInfo(uint startIndex, int count); // 0x00000001869C59EC-0x00000001869C5AB8
		public void FreeConveyorInfo(uint startIndex); // 0x00000001869C5984-0x00000001869C59EC
		public void DebugAllocatorPrint(); // 0x00000001869C5854-0x00000001869C58A8
		public void AddSetAnimatorParamRequest(Entity logicEntity, VATFSMProcessor.SetAnimatorParamRequest rq); // 0x00000001837B4B10-0x00000001837B51D0
		public void AddSetAnimatorParamRequestToPedestal(Entity entity, PooledList<VATFSMProcessor.SetAnimatorParamRequest> rqList, bool isPreviewBuilding = false /* Metadata: 0x0232EB33 */); // 0x0000000183921760-0x0000000183923070
		public bool AddSetAnimatorClipSlotRequest(Entity entity, byte clipSlot, bool isPreviewBuilding = false /* Metadata: 0x0232EB34 */); // 0x00000001869C56E0-0x00000001869C57EC
		public bool AddSetAnimatorClipSlotRequestByMode(Entity entity, FCNodeMode mode, bool isPreviewBuilding = false /* Metadata: 0x0232EB35 */); // 0x00000001837A91E0-0x00000001837A9780
		private bool _AddAnimatorClipSlotRequestToBoundRenders(Entity entity, [IsReadOnly] in VATFSMProcessor.SetAnimatorParamRequest rq); // 0x00000001869C6124-0x00000001869C65A0
		private bool _AddAnimatorClipSlotRequestByModeToRender(ref EntityManager em, Entity renderEntity, FCNodeMode mode); // 0x0000000183CCBA20-0x0000000183CCBB30
		private bool _AddAnimatorParamRequest(ref EntityManager em, Entity renderEntity, [IsReadOnly] in VATFSMProcessor.SetAnimatorParamRequest rq); // 0x00000001837B51D0-0x00000001837B5440
		public ref VATFSMProcessor.VATFSMAudioData GetAudioVATDataAt(int index); // 0x0000000183766620-0x0000000183766670
		public int GetAudioVATDataLength(); // 0x0000000183766560-0x00000001837665C0
		public void ClearAudioVATData(); // 0x00000001837665C0-0x0000000183766620
		public void ResetFlags(); // 0x000000018404DF70-0x000000018404DFD0
		private void __AOT_FOR_FIX__(); // 0x00000001869C65A0-0x00000001869C66E4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct HealthPoleFragment : IComponentECS // TypeDefIndex: 49797
	{
		// Fields
		public long currentProgress; // 0x00
		public int currentPoint; // 0x08
		public const int ID = 62; // Metadata: 0x0232EB37
	
		// Properties
		public int id { get; } // 0x00000001840F3A30-0x00000001840F3AF0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C6DF8-0x00000001869C6F10
	}

	[BurstCompatible]
	[ECSComponent]
	public struct InventoryFragment : IComponentECS // TypeDefIndex: 49798
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 63; // Metadata: 0x0232EB38
	
		// Properties
		public int id { get; } // 0x00000001869C701C-0x00000001869C706C 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C6F10-0x00000001869C701C
	}

	public interface IPositionFragment // TypeDefIndex: 49799
	{
		// Properties
		float3 Position { get; }
	}

	public interface IReactiveComponent : IComponentECS // TypeDefIndex: 49800
	{
	}

	public interface IFactoryEvent // TypeDefIndex: 49801
	{
		// Properties
		Entity eventEntity { get; set; }
	}

	[Obsolete("Use IFactoryEvent instead. INotificationComponent will be removed.")]
	public interface INotificationComponent : IReactiveComponent // TypeDefIndex: 49802
	{
		// Properties
		Entity eventEntity { get; set; }
	}

	public interface IRotateFragment // TypeDefIndex: 49803
	{
		// Properties
		float3 Rotation { get; }
		quaternion RotationQuaternion { get; }
	}

	public interface IUnitConfigRef // TypeDefIndex: 49804
	{
		// Properties
		int unitAssetInstanceId { get; set; }
	}

	[BurstCompatible]
	[ECSComponent]
	public struct LiquidPurifierFragment : IComponentECS // TypeDefIndex: 49805
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 64; // Metadata: 0x0232EB39
	
		// Properties
		public int id { get; } // 0x0000000184218BB0-0x0000000184218BE0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C706C-0x00000001869C7178
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct LogisticEffectFragment : IComponentECS // TypeDefIndex: 49806
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
		public const int ID = 65; // Metadata: 0x0232EB3B
	
		// Properties
		public int id { get; } // 0x0000000183F1ED30-0x0000000183F1ED90 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C9714-0x00000001869C9834
	}

	[BurstCompatible]
	[ECSComponent]
	public struct LogisticEntityBindFragment : IComponentECS // TypeDefIndex: 49807
	{
		// Fields
		public EntityData256<Entity> cargoEntities; // 0x00
		public uint conveyorExtHandle; // 0x808
		public const int ID = 66; // Metadata: 0x0232EB3D
	
		// Properties
		public int cargoCount { get; } // 0x00000001834CC390-0x00000001834CC3F0 
		public int id { get; } // 0x0000000183CCAB90-0x0000000183CCABF0 
	
		// Methods
		public void EnqueueCargoEntityImpl(Entity cargoEntity, uint conveyorSharedDataIndex); // 0x00000001834CDB20-0x00000001834CDC70
		public bool DequeueCargoEntityImpl(out Entity cargoEntity); // 0x00000001834CC480-0x00000001834CC540
		public unsafe void Arrive(ref CargoFragment cargo, ConveyorExtContainer.ConveyorExt* conveyorExtData); // 0x00000001869C98AC-0x00000001869C98DC
		public unsafe void Arrive(Entity cargoEntity, ConveyorExtContainer.ConveyorExt* conveyorExtData); // 0x00000001869C9834-0x00000001869C98AC
		private void __AOT_FOR_FIX__(); // 0x00000001869C98DC-0x00000001869C9A28
	}

	[BurstCompatible]
	[ECSComponent]
	public struct MapGridRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49808
	{
		// Fields
		[CompilerGenerated]
		private int _unitAssetInstanceId_k__BackingField; // 0x00
		public const int ID = 67; // Metadata: 0x0232EB3F
	
		// Properties
		public int unitAssetInstanceId { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public int id { get; } // 0x0000000184CA2410-0x0000000184CA2440 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C9A28-0x00000001869C9B34
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct OutputFragment : IComponentECS // TypeDefIndex: 49809
	{
		// Fields
		public int item; // 0x00
		public float4 rarityColor; // 0x04
		public float4 atlasRect; // 0x14
		public byte enableLiquidIcon; // 0x24
		public float4 liquidAtlasUV; // 0x25
		public static readonly int MAX_OUTPUT; // 0x00
		public const int ID = 68; // Metadata: 0x0232EB41
	
		// Properties
		public bool hasOutput { get; } // 0x00000001869C9F9C-0x00000001869C9FEC 
		public int id { get; } // 0x0000000183E5E490-0x0000000183E5E4F0 
	
		// Constructors
		static OutputFragment(); // 0x0000000184D79ED0-0x0000000184D79F10
	
		// Methods
		public void Clean(); // 0x0000000183BAED90-0x0000000183BAEDD0
		[IDTag(0)]
		public void SetColor(float4 color); // 0x00000001869C9E0C-0x00000001869C9E74
		[IDTag(1)]
		public void SetColor(UnityEngine.Color color); // 0x000000018331D500-0x000000018331D540
		[IDTag(0)]
		public void SetAtlasRect(float4 rect); // 0x00000001869C9DA4-0x00000001869C9E0C
		[IDTag(1)]
		public void SetAtlasRect(RectInt rect); // 0x000000018331D5B0-0x000000018331D620
		public bool GetEnableLiquidIcon(); // 0x00000001869C9D54-0x00000001869C9DA4
		public void SetEnableLiquidIcon(bool enable); // 0x000000018331D4C0-0x000000018331D500
		public void SetLiquidIconUV(RectInt rect); // 0x000000018331D540-0x000000018331D5B0
		private void __AOT_FOR_FIX__(); // 0x00000001869C9E74-0x00000001869C9F9C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct OutputUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49810
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 69; // Metadata: 0x0232EB43
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869CA0F8-0x00000001869CA144 0x00000001844ED9F0-0x00000001844EDA20
		public int id { get; } // 0x00000001843FAC20-0x00000001843FAC50 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C9FEC-0x00000001869CA0F8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PedestalLightFlashFragment : IComponentECS // TypeDefIndex: 49811
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
		public const int ID = 70; // Metadata: 0x0232EB45
	
		// Properties
		public int id { get; } // 0x0000000183FAAB80-0x0000000183FAABE0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CA7D8-0x00000001869CA904
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PedestalLightFlashConfigFragment : IComponentECS // TypeDefIndex: 49816
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ float intensity[0]; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ float flashIntensity[0]; // 0x40
		public unsafe fixed /* 0x00000000-0x00000000 */ float flashDuration[0]; // 0x80
		public unsafe fixed /* 0x00000000-0x00000000 */ bool flash[0]; // 0xC0
		public Float4Data16<float4> color; // 0xD0
		public Float4Data16<float4> flashColor; // 0x1D8
		public const int ID = 71; // Metadata: 0x0232EB47
	
		// Properties
		public int id { get; } // 0x0000000183DC18D0-0x0000000183DC1930 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _intensity_e__FixedBuffer // TypeDefIndex: 49812
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _flashIntensity_e__FixedBuffer // TypeDefIndex: 49813
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _flashDuration_e__FixedBuffer // TypeDefIndex: 49814
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _flash_e__FixedBuffer // TypeDefIndex: 49815
		{
			// Fields
			public bool FixedElementField; // 0x00
		}
	
		// Methods
		public bool IsValid(); // 0x00000001869CA618-0x00000001869CA694
		public void SetIntensity(int idx, float value); // 0x0000000183B21240-0x0000000183B212B0
		public void SetFlashIntensity(int idx, float value); // 0x0000000183B211D0-0x0000000183B21240
		public void SetFlash(int idx, bool value); // 0x0000000183B21160-0x0000000183B211D0
		public void SetFlashDuration(int idx, float value); // 0x0000000183B212B0-0x0000000183B21330
		public void SetColor(int idx, UnityEngine.Color value); // 0x0000000183B21330-0x0000000183B21440
		public void SetFlashColor(int idx, UnityEngine.Color value); // 0x0000000183B21440-0x0000000183B21550
		public float GetIntensity(int idx); // 0x00000001869CA5BC-0x00000001869CA618
		public float GetFlashIntensity(int idx); // 0x00000001869CA500-0x00000001869CA55C
		public bool GetFlash(int idx); // 0x00000001869CA55C-0x00000001869CA5BC
		public float GetFlashDuration(int idx); // 0x00000001869CA4A0-0x00000001869CA500
		public float4 GetColor(int idx); // 0x00000001869CA250-0x00000001869CA378
		public float4 GetFlashColor(int idx); // 0x00000001869CA378-0x00000001869CA4A0
		private void __AOT_FOR_FIX__(); // 0x00000001869CA694-0x00000001869CA7D8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeEffectFragment : IComponentECS // TypeDefIndex: 49817
	{
		// Fields
		public IntData32<uint> pipeEffectInstanceId; // 0x00
		public StringIntern.FastId inEffectNameFastId; // 0x88
		public StringIntern.FastId outEffectNameFastId; // 0x8C
		public StringIntern.FastId inEffectConnectedNameFastId; // 0x90
		public StringIntern.FastId outEffectConnectedNameFastId; // 0x94
		public StringIntern.FastId activateInEffectNameFastId; // 0x98
		public StringIntern.FastId activateInEffectConnectedNameFastId; // 0x9C
		public const int ID = 72; // Metadata: 0x0232EB49
	
		// Properties
		public string inEffectName { get; set; } // 0x00000001842827D0-0x0000000184282810 0x00000001837AB400-0x00000001837AB440
		public string outEffectName { get; set; } // 0x0000000184247840-0x0000000184247880 0x00000001837AB440-0x00000001837AB480
		public string inEffectConnectedName { get; set; } // 0x00000001841CBA30-0x00000001841CBA70 0x00000001837AB480-0x00000001837AB4C0
		public string outEffectConnectedName { get; set; } // 0x00000001841CB480-0x00000001841CB4C0 0x00000001837AB4C0-0x00000001837AB500
		public string activateInEffectName { get; set; } // 0x00000001869CABAC-0x00000001869CAC00 0x00000001837AB500-0x00000001837AB540
		public string activateInEffectConnectedName { get; set; } // 0x00000001848B6DC0-0x00000001848B6E00 0x00000001837AB540-0x00000001837AB580
		public int id { get; } // 0x00000001837AB0A0-0x00000001837AB100 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CAA6C-0x00000001869CABAC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeFragment : IComponentECS, ILogisticSample // TypeDefIndex: 49818
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
		public const int ID = 73; // Metadata: 0x0232EB55
	
		// Properties
		public int length { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86890-0x0000000184D868A0 0x0000000184D868C0-0x0000000184D868D0
		public int id { get; } // 0x0000000183BBC980-0x0000000183BBC9E0 
	
		// Constructors
		static PipeFragment(); // 0x0000000184D79DD0-0x0000000184D79E10
	
		// Methods
		public bool SetInflection(ref GlobalEnv env, ref NativeList<float3> p, ref NativeList<float3> r, ref NativeList<byte> proto); // 0x0000000183B291F0-0x0000000183B29660
		public static void Bend(ref GlobalEnv env, int pipeLength, uint startMemoryOffsetHandle, float pipeHeight, bool bOverrideEntranceY = false /* Metadata: 0x0232EB4B */, float overrideEntranceY = 0f /* Metadata: 0x0232EB4C */, bool bOverrideExitY = false /* Metadata: 0x0232EB50 */, float overrideExitY = 0f /* Metadata: 0x0232EB51 */); // 0x0000000183445590-0x0000000183445830
		public static ValueTuple<int[], int> GetCornerIndexList(ref GlobalEnv env, uint startMemoryOffsetHandle, int length); // 0x00000001869CAE48-0x00000001869CAF7C
		public bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInPipe); // 0x00000001869CB390-0x00000001869CB54C
		public bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax); // 0x00000001869CB1C0-0x00000001869CB390
		public bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex); // 0x00000001869CAF7C-0x00000001869CB1C0
		public bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets); // 0x00000001869CAC00-0x00000001869CAE48
		public void SetFluidHeightAndRefreshThickness(float value); // 0x000000018391FB30-0x000000018391FBC0
		public void RefreshWaterThicknessByFirstIndex(); // 0x000000018391FBC0-0x000000018391FCE0
		private void __AOT_FOR_FIX__(); // 0x00000001869CB54C-0x00000001869CB68C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeHolderFragment : IComponentECS // TypeDefIndex: 49819
	{
		// Fields
		public int indexInPipe; // 0x00
		public Entity pipeEntity; // 0x04
		public const int ID = 74; // Metadata: 0x0232EB57
	
		// Properties
		public int id { get; } // 0x0000000183D248A0-0x0000000183D24900 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CB68C-0x00000001869CB7A8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeLogisticsUnitFragment : IComponentECS // TypeDefIndex: 49820
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 75; // Metadata: 0x0232EB59
	
		// Properties
		public int id { get; } // 0x0000000183E0B360-0x0000000183E0B3C0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CB7A8-0x00000001869CB8B4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeComRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49821
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 76; // Metadata: 0x0232EB5B
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869CAA20-0x00000001869CAA6C 0x0000000183E5AB30-0x0000000183E5AB60
		public int id { get; } // 0x00000001840F2F20-0x00000001840F2F50 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CA904-0x00000001869CAA20
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct PipeRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49822
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int indexInPipe; // 0x04
		public FixedString32Bytes prototype; // 0x08
		public float3 position; // 0x28
		public float scale; // 0x34
		public quaternion rotation; // 0x38
		public HGFactoryEntityTransformData transformData; // 0x28
		public const int ID = 77; // Metadata: 0x0232EB5D
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869CB9D8-0x00000001869CBA24 0x00000001834A21E0-0x00000001834A2210
		public int id { get; } // 0x0000000183CC6860-0x0000000183CC68C0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CB8B4-0x00000001869CB9D8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeTrackRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49823
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 78; // Metadata: 0x0232EB5F
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869CBB40-0x00000001869CBB8C 0x0000000183E5A570-0x0000000183E5A5A0
		public int id { get; } // 0x00000001842FF770-0x00000001842FF7A0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CBA24-0x00000001869CBB40
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ComplexPortFragment : IComponentECS, IEquatable<ComplexPortFragment> // TypeDefIndex: 49824
	{
		// Fields
		public PortData32<Beyond.Gameplay.Factory.PortData> ports; // 0x00
		public int2 pedestalPortCount; // 0x808
		public int2 pipePortCount; // 0x810
		public bool dataInit; // 0x818
		public const int ID = 79; // Metadata: 0x0232EB67
	
		// Properties
		public int id { get; } // 0x0000000183AB5040-0x0000000183AB50A0 
	
		// Methods
		public void ResetBannedState(); // 0x00000001830E9EE0-0x00000001830E9F50
		public void AllowAdditivePort(int additivePortIdx, bool input = true /* Metadata: 0x0232EB61 */, bool bPipe = true /* Metadata: 0x0232EB62 */); // 0x00000001842EFF40-0x00000001842F0010
		public void BanPort(bool input, bool bPipe, List<int> allowedPortIndexList); // 0x00000001830EAD50-0x00000001830EAE10
		public bool BindComponentId(uint componentId, int idx, bool isInput, bool isBlock, uint touchComId, out bool pipeChanged); // 0x00000001830EABB0-0x00000001830EAD50
		public bool BlockPortsWithComponentId(uint componentId, bool isBlock, int[] portIndices); // 0x00000001869C4220-0x00000001869C4344
		public bool BlockPorts(bool isBlock, List<int> portIndices, bool input); // 0x000000018321D890-0x000000018321D960
		public void FollowUnit(float3 worldPos, float3 worldDir, ref GlobalSharedData.UnitPortConfig portConfig, ref UnitConfigFragment unitConfig, float effectOffset = 0.5f /* Metadata: 0x0232EB63 */); // 0x00000001830E9F50-0x00000001830EA5A0
		public bool AnyPortBlocked(); // 0x00000001869C40A8-0x00000001869C4170
		public bool AnyPortConnected(); // 0x00000001869C4170-0x00000001869C4220
		[IDTag(0)]
		public bool Equals(ComplexPortFragment other); // 0x00000001869C4400-0x00000001869C45FC
		[IDTag(1)]
		public override bool Equals(object obj); // 0x00000001869C4344-0x00000001869C4400
		public override int GetHashCode(); // 0x00000001869C45FC-0x00000001869C4800
		public static bool operator ==(ComplexPortFragment left, ComplexPortFragment right); // 0x00000001869C4D5C-0x00000001869C4E20
		public static bool operator !=(ComplexPortFragment left, ComplexPortFragment right); // 0x00000001869C4E20-0x00000001869C4EE4
		public override string ToString(); // 0x00000001869C4800-0x00000001869C4ADC
		private void __AOT_FOR_FIX__(); // 0x00000001869C4C10-0x00000001869C4D5C
		public bool __iFixBaseProxy_Equals(object P0); // 0x00000001869C4ADC-0x00000001869C4B50
		public int __iFixBaseProxy_GetHashCode(); // 0x00000001869C4B50-0x00000001869C4BB0
		public string __iFixBaseProxy_ToString(); // 0x00000001869C4BB0-0x00000001869C4C10
	}

	public struct PortData : IEquatable<Beyond.Gameplay.Factory.PortData> // TypeDefIndex: 49825
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
		public bool isUsable { get; } // 0x00000001830EB330-0x00000001830EB3A0 
	
		// Methods
		public float4x4 TRS(); // 0x00000001869CBFA4-0x00000001869CC074
		[IDTag(0)]
		public bool Equals(PortData other); // 0x00000001869CBC50-0x00000001869CBDC8
		[IDTag(1)]
		public override bool Equals(object obj); // 0x00000001869CBB8C-0x00000001869CBC50
		public override int GetHashCode(); // 0x00000001869CBDC8-0x00000001869CBFA4
		public static bool operator ==(PortData left, PortData right); // 0x00000001869CC524-0x00000001869CC600
		public static bool operator !=(PortData left, PortData right); // 0x00000001869CC600-0x00000001869CC6DC
		public override string ToString(); // 0x00000001869CC074-0x00000001869CC3DC
		public string __iFixBaseProxy_ToString(); // 0x00000001869CC4BC-0x00000001869CC524
		public bool __iFixBaseProxy_Equals(object P0); // 0x00000001869CC3DC-0x00000001869CC454
		public int __iFixBaseProxy_GetHashCode(); // 0x00000001869CC454-0x00000001869CC4BC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PortPreviewUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49826
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 80; // Metadata: 0x0232EB69
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869CC7E8-0x00000001869CC834 0x0000000183E5A850-0x0000000183E5A880
		public int id { get; } // 0x0000000184034C10-0x0000000184034C40 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CC6DC-0x00000001869CC7E8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PortStatusUIFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49827
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 81; // Metadata: 0x0232EB6B
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869CC940-0x00000001869CC98C 0x0000000183E5DA90-0x0000000183E5DAC0
		public int id { get; } // 0x0000000184301AB0-0x0000000184301AE0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CC834-0x00000001869CC940
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ProducerFragment : IComponentECS // TypeDefIndex: 49828
	{
		// Fields
		public uint componentId; // 0x00
		public long currentProgress; // 0x08
		public uint formulaId; // 0x10
		public uint lastFormulaId; // 0x14
		public const int ID = 82; // Metadata: 0x0232EB6D
	
		// Properties
		public uint outputFormulaId { get; } // 0x0000000183BAF870-0x0000000183BAF8B0 
		public int id { get; } // 0x00000001840061A0-0x00000001840061D0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CC98C-0x00000001869CCAAC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct SharedDataFragment : IComponentECS // TypeDefIndex: 49829
	{
		// Fields
		public uint dataHandle; // 0x00
		public const int ID = 83; // Metadata: 0x0232EB6F
	
		// Properties
		public int id { get; } // 0x00000001835C2230-0x00000001835C2290 
	
		// Methods
		public ref SharedDataContainer.SharedExtData GetExtData(); // 0x0000000183056800-0x00000001830568F0
		public void DestroyData(); // 0x00000001869CCBB8-0x00000001869CCC14
		private void __AOT_FOR_FIX__(); // 0x00000001869CCC14-0x00000001869CCD20
	}

	public enum SocialBuildingStates : uint // TypeDefIndex: 49830
	{
		Invalid = 0,
		Disable = 1,
		Unlocked = 2,
		Activated = 3,
		Locked = 4
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct SocialFragment : IComponentECS // TypeDefIndex: 49832
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
		public const int ID = 84; // Metadata: 0x0232EB76
	
		// Properties
		public int id { get; } // 0x0000000183E85940-0x0000000183E859A0 
	
		// Nested types
		[Flags]
		public enum EOwner // TypeDefIndex: 49831
		{
			MINE = 1,
			OTHERS = 2,
			ALL = 3
		}
	
		// Methods
		public static SocialFragment Create(ulong ownerId, uint socialNodeId, ulong like, long lastSetLikeTs, long expirationTs, uint socialState, bool isPreset); // 0x00000001839678B0-0x0000000183967990
		public bool IsHighLiked(); // 0x00000001834A9680-0x00000001834A9750
		public bool IsLiked(); // 0x00000001869CCEB8-0x00000001869CCF34
		private void __AOT_FOR_FIX__(); // 0x00000001869CCF34-0x00000001869CD05C
	}

	public struct SignData // TypeDefIndex: 49833
	{
		// Fields
		public uint3 content; // 0x00
		public const int CONTENT_LENGTH = 3; // Metadata: 0x0232EB7B
	
		// Methods
		public string GetText(); // 0x00000001869CCD20-0x00000001869CCEB8
		public static float GetCustomPerDrawData(FactoryUIAtlasSOData config, uint3 content); // 0x00000001845D6B10-0x00000001845D6D40
		public static void SetSignBuildingIcon(FactoryUIAtlasSOData data, ref EntityManager em, Entity logicEntity); // 0x00000001834A9380-0x00000001834A95B0
		public static void SetSignBuildingIconWithRenderEntity(FactoryUIAtlasSOData config, Entity rEntity, uint3 iconId); // 0x00000001845D6390-0x00000001845D6B10
	}

	[Serializable]
	[BurstCompatible]
	[BurstCompile]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct LocalTransform : IComponentECS // TypeDefIndex: 49834
	{
		// Fields
		public float3 position; // 0x00
		public float scale; // 0x0C
		public quaternion rotation; // 0x10
		public HGFactoryEntityTransformData entityTransformData; // 0x00
		public static readonly LocalTransform Identity; // 0x00
		public const int ID = 85; // Metadata: 0x0232EB7C
	
		// Properties
		public int id { get; } // 0x0000000183E42A80-0x0000000183E42C90 
	
		// Constructors
		static LocalTransform(); // 0x0000000184CED1D0-0x0000000184CED270
	
		// Methods
		public static LocalTransform FromMatrix(float4x4 matrix); // 0x00000001869C7D30-0x00000001869C7FDC
		public static LocalTransform FromMatrixSafe(float4x4 matrix); // 0x00000001869C77CC-0x00000001869C7D30
		public static LocalTransform FromPositionRotation(float3 position, quaternion rotation); // 0x00000001869C7FDC-0x00000001869C80A8
		public static LocalTransform FromPositionRotationScale(float3 position, quaternion rotation, float scale); // 0x00000001834C4C50-0x00000001834C4CE0
		[IDTag(0)]
		public static LocalTransform FromPosition(float3 position); // 0x00000001869C8190-0x00000001869C8260
		[IDTag(1)]
		public static LocalTransform FromPosition(float x, float y, float z); // 0x00000001869C80A8-0x00000001869C8190
		public static LocalTransform FromRotation(quaternion rotation); // 0x00000001869C8260-0x00000001869C8328
		public static LocalTransform FromScale(float scale); // 0x00000001869C8328-0x00000001869C8400
		public override string ToString(); // 0x00000001869C8EB4-0x00000001869C9018
		public float3 Right(); // 0x00000001869C89AC-0x00000001869C8A78
		public float3 Up(); // 0x00000001869C9228-0x00000001869C9300
		public float3 Forward(); // 0x00000001869C76F4-0x00000001869C77CC
		public float3 TransformPoint(float3 point); // 0x0000000183F50350-0x0000000183F50430
		public float3 InverseTransformPoint(float3 point); // 0x00000001869C84D8-0x00000001869C8614
		public float3 TransformDirection(float3 direction); // 0x00000001869C9018-0x00000001869C90D8
		public float3 InverseTransformDirection(float3 direction); // 0x00000001869C8400-0x00000001869C84D8
		public quaternion TransformRotation(quaternion rotation); // 0x0000000183F502E0-0x0000000183F50350
		public quaternion InverseTransformRotation(quaternion rotation); // 0x00000001869C8614-0x00000001869C86D4
		public float TransformScale(float scale); // 0x0000000183F502A0-0x0000000183F502E0
		public float InverseTransformScale(float scale); // 0x00000001869C86D4-0x00000001869C8734
		public LocalTransform TransformTransform([IsReadOnly] in LocalTransform transformData); // 0x0000000183F50170-0x0000000183F502A0
		public LocalTransform InverseTransformTransform([IsReadOnly] in LocalTransform transformData); // 0x00000001869C8734-0x00000001869C886C
		public LocalTransform Inverse(); // 0x00000001869C886C-0x00000001869C89AC
		public float4x4 ToMatrix(); // 0x00000001837B1FD0-0x00000001837B21B0
		public float4x4 ToInverseMatrix(); // 0x00000001869C8DD8-0x00000001869C8EB4
		[IDTag(0)]
		public LocalTransform WithPosition(float3 p); // 0x00000001869C9300-0x00000001869C93BC
		[IDTag(1)]
		public LocalTransform WithPosition(float x, float y, float z); // 0x00000001869C93BC-0x00000001869C949C
		public LocalTransform WithRotation(quaternion r); // 0x00000001869C949C-0x00000001869C9554
		public LocalTransform WithScale(float s); // 0x00000001869C9554-0x00000001869C95F8
		public LocalTransform Translate(float3 translation); // 0x00000001869C90D8-0x00000001869C91D0
		public LocalTransform ApplyScale(float scale); // 0x00000001869C75A0-0x00000001869C764C
		public LocalTransform Rotate(quaternion rotation); // 0x00000001869C8CF4-0x00000001869C8DD8
		public LocalTransform RotateX(float angle); // 0x00000001869C8A78-0x00000001869C8B4C
		public LocalTransform RotateY(float angle); // 0x00000001869C8B4C-0x00000001869C8C20
		public LocalTransform RotateZ(float angle); // 0x00000001869C8C20-0x00000001869C8CF4
		public bool Equals([IsReadOnly] in LocalTransform other); // 0x00000001869C764C-0x00000001869C76F4
		private void __AOT_FOR_FIX__(); // 0x00000001869C95F8-0x00000001869C9714
		public string __iFixBaseProxy_ToString(); // 0x00000001869C91D0-0x00000001869C9228
	}

	[BurstCompatible]
	[ECSComponent]
	public struct Root : IComponentECS // TypeDefIndex: 49835
	{
		// Fields
		public const int ID = 86; // Metadata: 0x0232EB7E
	
		// Properties
		public int id { get; } // 0x0000000183EF7780-0x0000000183EF7910 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CCAAC-0x00000001869CCBB8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct Parent : IComponentECS // TypeDefIndex: 49836
	{
		// Fields
		public Entity value; // 0x00
		public const int ID = 87; // Metadata: 0x0232EB80
	
		// Properties
		public int id { get; } // 0x0000000184048450-0x0000000184048480 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CA144-0x00000001869CA250
	}

	[BurstCompatible]
	[ECSComponent]
	public struct Child : IComponentECS // TypeDefIndex: 49837
	{
		// Fields
		public EntityData32<Entity> value; // 0x00
		public const int ID = 88; // Metadata: 0x0232EB82
	
		// Properties
		public int id { get; } // 0x0000000183C32DF0-0x0000000183C32E50 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869C3F64-0x00000001869C40A8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct LocalToWorld : IComponentECS // TypeDefIndex: 49838
	{
		// Fields
		public float4x4 READ_ONLY_VAL; // 0x00
		public float4x4 PRE_FRAME_READ_ONLY_VAL; // 0x40
		public uint hierarchyHandle; // 0x80
		public bool dirty; // 0x84
		public int calcFrameCount; // 0x88
		public const int ID = 89; // Metadata: 0x0232EB84
	
		// Properties
		public float3 right { get; } // 0x00000001869C74B0-0x00000001869C7528 
		public float3 up { get; } // 0x00000001869C7528-0x00000001869C75A0 
		public float3 forward { get; } // 0x00000001869C72B8-0x00000001869C7330 
		public float3 position { get; } // 0x00000001834C7EB0-0x00000001834C8110 
		public quaternion rotation { get; } // 0x00000001834C8E90-0x00000001834C93C0 
		public float3 prePosition { get; } // 0x00000001869C7330-0x00000001869C73A8 
		public quaternion preRotation { get; } // 0x00000001869C73A8-0x00000001869C74B0 
		public unsafe float4x4* READ_ONLY_VAL_PTR { get; } // 0x000000018464E630-0x000000018464E640 
		public unsafe float4x4* PRE_FRAME_READ_ONLY_VAL_PTR { get; } // 0x0000000184D8CF20-0x0000000184D8CF30 
		public int id { get; } // 0x0000000183BE2520-0x0000000183BE2580 
	
		// Methods
		public bool SetValue(float4x4 value, int frameCount); // 0x00000001837B21B0-0x00000001837B2250
		private void __AOT_FOR_FIX__(); // 0x00000001869C7178-0x00000001869C72B8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UdPipeFragment : IComponentECS // TypeDefIndex: 49839
	{
		// Fields
		public ulong connectedCompId; // 0x00
		public int offset; // 0x08
		public const int ID = 90; // Metadata: 0x0232EB86
	
		// Properties
		public int id { get; } // 0x00000001840F8280-0x00000001840F82B0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CD05C-0x00000001869CD174
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitConfigFragment : IComponentECS // TypeDefIndex: 49840
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int powerCost; // 0x04
		public bool isShowOutputUI; // 0x08
		public bool needPower; // 0x09
		public bool bypassPowerCheck; // 0x0A
		public bool hidePreviewArrow; // 0x0B
		public bool suppressExternalAutoDither; // 0x0C
		public short inputPortCount; // 0x0E
		public short outputPortCount; // 0x10
		public int facBuildingType; // 0x14
		public float3 bounds; // 0x18
		public int unitNameFastString; // 0x24
		public int iconOnPanelFastString; // 0x28
		public UnitConfigInternal baseConfig; // 0x2C
		public const int ID = 91; // Metadata: 0x0232EB88
	
		// Properties
		public string iconOnPanel { get; set; } // 0x000000018304E9A0-0x000000018304EA10 0x00000001837ABBB0-0x00000001837ABC10
		public string unitName { get; set; } // 0x00000001869CD29C-0x00000001869CD320 0x00000001837ABC10-0x00000001837ABC70
		public int id { get; } // 0x0000000182EEF610-0x0000000182EEF670 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869CD174-0x00000001869CD29C
	}

	[Serializable]
	public struct UnitConfigInternal // TypeDefIndex: 49841
	{
		// Fields
		public Bounds bounds; // 0x00
		public Bounds buildingBounds; // 0x18
	}

	[Serializable]
	public struct FactoryUnitPortConfig // TypeDefIndex: 49842
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
	public struct FactoryUnitExtendConfig // TypeDefIndex: 49843
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
		public string name { get; } // 0x0000000183D699D0-0x0000000183D69A10 
		public int unLoaderIndex { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184D86640-0x0000000184D86650 0x0000000184D86670-0x0000000184D86680
		public bool isUnLoader { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
	
		// Methods
		public override string ToString(); // 0x00000001869C4EE4-0x00000001869C50D4
		public string __iFixBaseProxy_ToString(); // 0x00000001869C50D4-0x00000001869C5144
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitEnvironmentRelation : IComponentECS // TypeDefIndex: 49844
	{
		// Fields
		public int envTypeRaw; // 0x00
		public byte envRenderAtlasIdx; // 0x04
		public int envEffectInstanceId; // 0x08
		public byte envParam; // 0x0C
		public bool generatorOrReceiver; // 0x0D
		public float4 rendererUV; // 0x10
		public const int ID = 92; // Metadata: 0x0232EB8A
	
		// Properties
		public FacEnvGenEnvType envType { get; } // 0x00000001836BB410-0x00000001836BB440 
		public int id { get; } // 0x0000000183F6DD70-0x0000000183F6DDD0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D74AC-0x00000001869D75C8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitInteractFragment : IComponentECS // TypeDefIndex: 49845
	{
		// Fields
		public ulong interactObjectId; // 0x00
		public const int ID = 93; // Metadata: 0x0232EB8C
	
		// Properties
		public int id { get; } // 0x0000000183FF2670-0x0000000183FF26A0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D7714-0x00000001869D7820
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49846
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
		public const int ID = 94; // Metadata: 0x0232EB8E
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869D7DA4-0x00000001869D7DF0 0x0000000183D6C640-0x0000000183D6C680
		public int id { get; } // 0x0000000183A572E0-0x0000000183A57340 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D7C7C-0x00000001869D7DA4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct RenderLookAtFragment : IComponentECS // TypeDefIndex: 49847
	{
		// Fields
		public bool lookAtEnable; // 0x00
		public bool lookAtArrived; // 0x01
		public bool yawEnabled; // 0x02
		public bool pitchEnabled; // 0x03
		public quaternion deltaQuaternion; // 0x04
		public float3 targetPos; // 0x14
		public half interpolation; // 0x20
		public const int ID = 95; // Metadata: 0x0232EB90
	
		// Properties
		public int id { get; } // 0x000000018413A9B0-0x000000018413A9E0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D67B0-0x00000001869D68D4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ChapterTagFragment : IComponentECS // TypeDefIndex: 49848
	{
		// Fields
		public int chapterId; // 0x00
		public int mapId; // 0x04
		public int panelIndex; // 0x08
		public int sceneId; // 0x0C
		public const int ID = 96; // Metadata: 0x0232EB92
	
		// Properties
		public int id { get; } // 0x0000000183824AE0-0x0000000183824B40 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D43EC-0x00000001869D4504
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitStatusFragment : IComponentECS // TypeDefIndex: 49849
	{
		// Fields
		public byte preStatus; // 0x00
		public byte status; // 0x01
		public byte subStatus; // 0x02
		public const int ID = 97; // Metadata: 0x0232EB94
	
		// Properties
		public int id { get; } // 0x0000000183B593E0-0x0000000183B59440 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D7F08-0x00000001869D8024
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitOverrideStatusFragment : IComponentECS // TypeDefIndex: 49850
	{
		// Fields
		public bool working; // 0x00
		public const int ID = 98; // Metadata: 0x0232EB96
	
		// Properties
		public int id { get; } // 0x0000000183F097C0-0x0000000183F09820 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D7820-0x00000001869D792C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitStatusEffectFragment : IComponentECS // TypeDefIndex: 49851
	{
		// Fields
		public const int MAX_EFFECT_COUNT = 3; // Metadata: 0x0232EB98
		public int effectConfigInstanceId; // 0x00
		public int3 effectInstanceIdList; // 0x04
		public const int ID = 99; // Metadata: 0x0232EB99
	
		// Properties
		public int id { get; } // 0x00000001837AA090-0x00000001837AA0F0 
	
		// Methods
		public void SetEffectConfig(int instanceId, SerializeFieldDictionary<FacBuildingState, FacEffectCfgList> effectCfgs); // 0x00000001840320F0-0x0000000184032160
		public List<StatusSingleEffect> GetEffect(FacBuildingState status); // 0x0000000183966750-0x00000001839667B0
		private void __AOT_FOR_FIX__(); // 0x00000001869D7DF0-0x00000001869D7F08
	}

	public static class StatusEffectConfigCache // TypeDefIndex: 49852
	{
		// Fields
		private static readonly Dictionary<int, SerializeFieldDictionary<FacBuildingState, FacEffectCfgList>> s_cache; // 0x00
	
		// Constructors
		static StatusEffectConfigCache(); // 0x0000000184D16C20-0x0000000184D16CB0
	
		// Methods
		public static void Register(int instanceId, SerializeFieldDictionary<FacBuildingState, FacEffectCfgList> configs); // 0x0000000184032160-0x0000000184032270
		public static List<StatusSingleEffect> GetEffects(int instanceId, FacBuildingState state); // 0x00000001839667B0-0x0000000183966880
		public static void Clear(); // 0x00000001869D6D18-0x00000001869D6DAC
	}

	[Serializable]
	public struct StatusSingleEffect // TypeDefIndex: 49853
	{
		// Fields
		public BuildingNodeMode mode; // 0x00
		public BuildingSubState subState; // 0x01
		[HideInInspector]
		public FixedString64Bytes name; // 0x02
		public float3 offset; // 0x44
		public bool needAlignToBuilding; // 0x50
	
		// Properties
		public string effectName { get; set; } // 0x0000000183966880-0x00000001839668E0 0x00000001869D6DAC-0x00000001869D6E40
	}

	[Serializable]
	public class FacEffectCfgList // TypeDefIndex: 49854
	{
		// Fields
		public List<StatusSingleEffect> list; // 0x10
	
		// Properties
		public int cfgCount { get; } // 0x00000001869D4A7C-0x00000001869D4AF0 
	
		// Constructors
		public FacEffectCfgList(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public enum BuildingStatus // TypeDefIndex: 49855
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
	public enum BuildingSubState : byte // TypeDefIndex: 49856
	{
		NONE = 0,
		SUB_STATE_1 = 1,
		SUB_STATE_2 = 2,
		SUB_STATE_3 = 4,
		SUB_STATE_4 = 8,
		ANY = 15
	}

	[Flags]
	public enum BuildingNodeMode : byte // TypeDefIndex: 49857
	{
		None = 0,
		normal = 1,
		liquid = 2,
		gas = 4,
		gasliquid = 8,
		gastrans = 16,
		liquidtrans = 32,
		solidtrans = 64,
		All = 127
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitStatusUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49858
	{
		// Fields
		[CompilerGenerated]
		private int _unitConfigAssetInstanceId_k__BackingField; // 0x00
		public const int ID = 100; // Metadata: 0x0232EBB9
	
		// Properties
		public int unitConfigAssetInstanceId { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public int unitAssetInstanceId { get; set; } // 0x00000001869D8130-0x00000001869D817C 0x0000000183E5D7C0-0x0000000183E5D7F0
		public int id { get; } // 0x00000001843FAA10-0x00000001843FAA40 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D8024-0x00000001869D8130
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitTransFragment : IComponentECS, IRotateFragment, IPositionFragment // TypeDefIndex: 49859
	{
		// Fields
		public float3 __position; // 0x00
		public float3 __rotation; // 0x0C
		public float3 cornerLD; // 0x18
		public float3 cornerRU; // 0x24
		public const int ID = 101; // Metadata: 0x0232EBBC
	
		// Properties
		public quaternion RotationQuaternion { get; } // 0x0000000183054670-0x0000000183054AE0 
		public float3 Position { get; set; } // 0x0000000182EF0BC0-0x0000000182EF0C30 0x00000001834CC8B0-0x00000001834CC920
		public float3 Rotation { get; set; } // 0x0000000182EF0E50-0x0000000182EF0F50 0x00000001834CC920-0x00000001834CC960
		public int id { get; } // 0x0000000182EEF860-0x0000000182EEF8C0 
	
		// Methods
		public bool InBound(float3 pos, bool ignoreY = true /* Metadata: 0x0232EBBB */); // 0x00000001869D817C-0x00000001869D8310
		public RectInt Get2DRectInt(); // 0x000000018398A430-0x000000018398A500
		private void __AOT_FOR_FIX__(); // 0x00000001869D8310-0x00000001869D8434
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ValveFragment : IComponentECS // TypeDefIndex: 49860
	{
		// Fields
		public bool enable; // 0x00
		public uint selectedItemId; // 0x04
		public int passed; // 0x08
		public int currentPassed; // 0x0C
		public bool speedLimitEnable; // 0x10
		public int speedLimitValue; // 0x14
		public FactoryItem holdItem; // 0x18
		public const int ID = 102; // Metadata: 0x0232EBBE
	
		// Properties
		public int id { get; } // 0x00000001843C9130-0x00000001843C9160 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D8C64-0x00000001869D8D88
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BoxValve : IComponentECS // TypeDefIndex: 49861
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 103; // Metadata: 0x0232EBC0
	
		// Properties
		public int id { get; } // 0x0000000184B0C310-0x0000000184B0C340 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D42E0-0x00000001869D43EC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidValve : IComponentECS // TypeDefIndex: 49862
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 104; // Metadata: 0x0232EBC2
	
		// Properties
		public int id { get; } // 0x0000000183E02890-0x0000000183E028F0 
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D4BC0-0x00000001869D4CCC
	}

	public struct BlueprintSlotInfo // TypeDefIndex: 49870
	{
		// Fields
		public const int RELATED_SLOT_ID = -1; // Metadata: 0x0232EBC5
		public const int SLOT_MAX_COUNT = 6; // Metadata: 0x0232EBC6
		public const int UNIT_MAX_COUNT_PER_SLOT = 256; // Metadata: 0x0232EBC7
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
		public struct _m_blueprintSlotInfo0_e__FixedBuffer // TypeDefIndex: 49863
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintSlotInfo1_e__FixedBuffer // TypeDefIndex: 49864
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintSlotInfo2_e__FixedBuffer // TypeDefIndex: 49865
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintSlotInfo3_e__FixedBuffer // TypeDefIndex: 49866
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintSlotInfo4_e__FixedBuffer // TypeDefIndex: 49867
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintSlotInfo5_e__FixedBuffer // TypeDefIndex: 49868
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_blueprintRelatedSlotInfo_e__FixedBuffer // TypeDefIndex: 49869
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		// Methods
		public bool ContainsNodeId(ref EntityManager em, int slotId, int nodeId); // 0x00000001869D37AC-0x00000001869D38DC
		public void RemoveEntityFromSlot(ref EntityManager em, int slotId, Entity overdueEntity); // 0x00000001869D3C10-0x00000001869D3D14
		public int FindEmptySlotIdx(); // 0x00000001869D38DC-0x00000001869D3950
		public int GetSuitableSlotIdx(int slotId); // 0x00000001869D3B88-0x00000001869D3C10
		public void SetSlotId(int index, int slotId); // 0x00000001869D3D14-0x00000001869D3D90
		public ulong[] GetSlotIds(); // 0x00000001836B87D0-0x00000001836B8870
		public void AppendSlotInfo(int slotId, Entity logicEntity); // 0x00000001869D363C-0x00000001869D371C
		public Entity[] ClearSlotInfo(int slotId); // 0x00000001869D371C-0x00000001869D37AC
		private unsafe Entity[] _ClearSlotInfo(ulong* slotGroupPtr); // 0x00000001869D41B0-0x00000001869D42E0
		public void DiffSlotInfo(ref EntityManager em, int slotId, ref PooledList<uint> baseList, ref PooledList<uint> newList, ref PooledList<Entity> overdueList); // 0x00000001836B8080-0x00000001836B8250
		public NativeArray<Entity> GetAllPendingEntitiesInSlot(int slotId); // 0x00000001869D3950-0x00000001869D3A60
		public Entity GetSlotInfo(int slotId, int index); // 0x00000001869D3AE0-0x00000001869D3B88
		public ulong GetPendingEntityCountInSlot(int slotId); // 0x00000001869D3A60-0x00000001869D3AE0
		public unsafe ulong* GetSlotGroupWithSlotId(int slotId, out int slotIdx, bool includeInvalid = true /* Metadata: 0x0232EBC4 */); // 0x00000001836B8250-0x00000001836B82A0
		public unsafe ulong* GetRelatedSlotGroup(); // 0x0000000184D8CF40-0x0000000184D8CF50
		public unsafe ulong* GetSlotGroup(int index); // 0x00000001836B8870-0x00000001836B8900
		public static BlueprintSlotInfo CreateDefault(); // 0x00000001836BAB60-0x00000001836BABE0
		public override string ToString(); // 0x00000001869D3D90-0x00000001869D4130
		public string __iFixBaseProxy_ToString(); // 0x00000001869D4130-0x00000001869D41B0
	}

	[DataN(capacity = 4096, tSize = 72, ring = false)]
	[NoAlias]
	public struct CargoRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49873
		where T : struct
	{
		// Fields
		public const int T_SIZE = 72; // Metadata: 0x0232EBCC
		public const int CAPACITY = 4096; // Metadata: 0x0232EBCE
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x0232EBD0
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EBD2
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49871
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
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 49872
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe CargoRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x0232EBC9 */, bool autoExtend = false /* Metadata: 0x0232EBCB */);
	
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

	public struct CargoRendererInfo // TypeDefIndex: 49874
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

	[DataN(capacity = 4096, tSize = 64, ring = false)]
	[NoAlias]
	public struct ConveyorRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49877
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0232EBD6
		public const int CAPACITY = 4096; // Metadata: 0x0232EBD8
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x0232EBDA
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EBDC
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49875
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
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 49876
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe ConveyorRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x0232EBD3 */, bool autoExtend = false /* Metadata: 0x0232EBD5 */);
	
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

	public struct ConveyorRendererInfo // TypeDefIndex: 49878
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
		public override string ToString(); // 0x00000001869D4504-0x00000001869D4894
		public string __iFixBaseProxy_ToString(); // 0x00000001869D4894-0x00000001869D48FC
	}

	public struct FactoryItem // TypeDefIndex: 49879
	{
		// Fields
		public uint itemId; // 0x00
		public int itemAmount; // 0x04
		public long tms; // 0x08
	}

	[DataN(capacity = 4096, tSize = 64, ring = false)]
	[NoAlias]
	public struct PipeRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49882
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0232EBE0
		public const int CAPACITY = 4096; // Metadata: 0x0232EBE2
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x0232EBE4
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EBE6
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49880
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
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 49881
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe PipeRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x0232EBDD */, bool autoExtend = false /* Metadata: 0x0232EBDF */);
	
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

	[DataN(capacity = 128, tSize = 64, ring = false)]
	[NoAlias]
	public struct PipeTrackRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49885
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0232EBEA
		public const int CAPACITY = 128; // Metadata: 0x0232EBEC
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x0232EBEE
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EBF0
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49883
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
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 49884
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe PipeTrackRendererInfoCollection(int initialCapacity = 128 /* Metadata: 0x0232EBE7 */, bool autoExtend = false /* Metadata: 0x0232EBE9 */);
	
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

	public struct PipeRendererInfo // TypeDefIndex: 49886
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
		public static byte PackPackedMeta(byte proto, bool isPreview, bool valid, bool highLight, BlueprintState.EffectType blueprint); // 0x00000001869D61A4-0x00000001869D6248
		[IsReadOnly]
		public byte GetProto(); // 0x00000001869D6104-0x00000001869D6154
		[IsReadOnly]
		public bool GetIsPreview(); // 0x00000001869D60B4-0x00000001869D6104
		[IsReadOnly]
		public bool GetValid(); // 0x00000001869D6154-0x00000001869D61A4
		[IsReadOnly]
		public bool GetHighLight(); // 0x00000001869D6064-0x00000001869D60B4
		[IsReadOnly]
		public BlueprintState.EffectType GetBlueprintType(); // 0x00000001869D6014-0x00000001869D6064
	}

	public struct PipeTrackRendererInfo // TypeDefIndex: 49887
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

	[DataN(capacity = 2048, tSize = 64, ring = false)]
	[NoAlias]
	public struct PortArrowRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 49890
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0232EBF4
		public const int CAPACITY = 2048; // Metadata: 0x0232EBF6
		public const int CAPACITY_MINUS_ONE = 2047; // Metadata: 0x0232EBF8
		public const int INVALID_INDEX = -1; // Metadata: 0x0232EBFA
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49888
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
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 49889
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe PortArrowRendererInfoCollection(int initialCapacity = 2048 /* Metadata: 0x0232EBF1 */, bool autoExtend = false /* Metadata: 0x0232EBF3 */);
	
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

	public struct PortArrowRendererInfo // TypeDefIndex: 49891
	{
		// Fields
		public float3 pos; // 0x00
		public bool isForbidden; // 0x0C
		public quaternion rot; // 0x10
		public float4 renderColor; // 0x20
		public float4 atlasUV; // 0x30
	}

	public struct UnitId : IEquatable<UnitId> // TypeDefIndex: 49892
	{
		// Fields
		public int mapId; // 0x00
		public uint factoryUnitId; // 0x04
	
		// Methods
		[IDTag(0)]
		public bool Equals(UnitId other); // 0x0000000182EEF3A0-0x0000000182EEF420
		[IDTag(1)]
		public override bool Equals(object obj); // 0x00000001869D75C8-0x00000001869D7664
		public override int GetHashCode(); // 0x0000000182EEFA50-0x0000000182EEFAC0
		public static UnitId Create(int mapId, uint factoryUnitId); // 0x0000000182EEFAC0-0x0000000182EEFB30
		public bool __iFixBaseProxy_Equals(object P0); // 0x00000001869D7664-0x00000001869D76C4
		public int __iFixBaseProxy_GetHashCode(); // 0x00000001869D76C4-0x00000001869D7714
	}

	public struct Visibility // TypeDefIndex: 49896
	{
		// Fields
		public static Visibility s_defaultVal; // 0x00
		public uint visibleFlags; // 0x00
		public short invisibleSubCount; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte invisibleSubBits[0]; // 0x06
		public const int SUB_INDEX_MAX_COUNT = 128; // Metadata: 0x0232EBFB
		public const int SUB_BIT_BYTE_COUNT = 16; // Metadata: 0x0232EBFD
	
		// Properties
		public bool isVisible { get; } // 0x0000000183054200-0x0000000183054320 
	
		// Nested types
		[Flags]
		public enum EFlag // TypeDefIndex: 49893
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
		public enum Type : byte // TypeDefIndex: 49894
		{
			BASE = 1,
			ADDITIVE_MAT = 2
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _invisibleSubBits_e__FixedBuffer // TypeDefIndex: 49895
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Constructors
		static Visibility(); // 0x0000000184D3E9B0-0x0000000184D3EA10
	
		// Methods
		public bool SetVisible(EFlag flag, bool visible); // 0x00000001869D8DF8-0x00000001869D8EAC
		public unsafe bool SetVisible(EFlag flag, bool visible, short* invisibleIndexListPtr, short invisibleIndexCount); // 0x000000018345D460-0x000000018345D570
		public bool GetVisible(EFlag flag); // 0x0000000183054320-0x0000000183054670
		public bool IsSubRendererInvisible(int subIndex); // 0x00000001869D8D88-0x00000001869D8DF8
		private static unsafe void _SetSubInvisible(byte* head, int index, bool invisible); // 0x00000001869D8ECC-0x00000001869D8EF8
		private static unsafe bool _GetSubInvisible(byte* head, int index); // 0x00000001869D8EAC-0x00000001869D8ECC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct WireRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 49898
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 105; // Metadata: 0x0232EC0F
	
		// Properties
		public int unitAssetInstanceId { get; set; } // 0x00000001869D9004-0x00000001869D9050 0x0000000183E5B370-0x0000000183E5B3A0
		public int id { get; } // 0x0000000184034720-0x0000000184034750 
	
		// Nested types
		public enum Type : byte // TypeDefIndex: 49897
		{
			NORMAL = 0,
			HS_NORMAL = 1,
			DISABLE = 2,
			STRENGTHEN = 3,
			HS_STRENGTHEN = 4,
			STRENGTHEN_DISABLE = 5
		}
	
		// Methods
		private void __AOT_FOR_FIX__(); // 0x00000001869D8EF8-0x00000001869D9004
	}

	public struct GlobalSharedData // TypeDefIndex: 49923
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
		public struct CullingGlobalSetting // TypeDefIndex: 49899
		{
			// Fields
			public bool bOverride; // 0x00
			public CullingDisSetting setting; // 0x04
			public CullingDisSetting overrideSetting; // 0x14
	
			// Properties
			public float sqrCullDis { get; set; } // 0x0000000183053CE0-0x0000000183053D40 0x00000001869D495C-0x00000001869D49BC
			public float sqrUI { get; set; } // 0x00000001841B61F0-0x00000001841B6230 0x00000001869D49BC-0x00000001869D4A1C
			public float sqrBuildingName { get; set; } // 0x00000001841B6230-0x00000001841B6270 0x00000001869D48FC-0x00000001869D495C
			public float sqrWireCullDis { get; set; } // 0x0000000183875920-0x0000000183875980 0x00000001869D4A1C-0x00000001869D4A7C
	
			// Methods
			public void ResetOverride(); // 0x00000001834D5C00-0x00000001834D5C30
		}
	
		[Serializable]
		public struct CullingDisSetting // TypeDefIndex: 49900
		{
			// Fields
			public float sqrCullDis; // 0x00
			public float sqrBuildingName; // 0x04
			public float sqrUI; // 0x08
			public float sqrWireCullDis; // 0x0C
		}
	
		public struct NearByDistanceGlobalSetting // TypeDefIndex: 49901
		{
			// Fields
			public bool bOverride; // 0x00
			public NearByDistanceSetting setting; // 0x04
			public NearByDistanceSetting overrideSetting; // 0x20
	
			// Properties
			public bool nearByCheck { get; set; } // 0x00000001830D9800-0x00000001830D9860 0x00000001869D5898-0x00000001869D58F4
			public float portPreviewCheckDistance { get; set; } // 0x000000018345A780-0x000000018345A820 0x00000001869D5954-0x00000001869D59B4
			public float pedestalFlashCheckDistance { get; set; } // 0x0000000184065030-0x0000000184065090 0x00000001869D58F4-0x00000001869D5954
			public float logisticEffectCheckDistance { get; set; } // 0x00000001830DAE70-0x00000001830DAED0 0x00000001869D5838-0x00000001869D5898
			public float unitRendererCheckDistance { get; set; } // 0x00000001830D6A30-0x00000001830D6A90 0x00000001869D59B4-0x00000001869D5A14
			public float l2wCheckDistance { get; set; } // 0x00000001830D97A0-0x00000001830D9800 0x00000001869D57D8-0x00000001869D5838
			public float additiveEffectCheckDistance { get; set; } // 0x000000018404DFD0-0x000000018404E030 0x00000001869D5778-0x00000001869D57D8
	
			// Methods
			public void ResetOverride(); // 0x00000001834D5C70-0x00000001834D5CB0
			public void Disable(); // 0x00000001869D56DC-0x00000001869D5778
		}
	
		[Serializable]
		public struct NearByDistanceSetting // TypeDefIndex: 49902
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
	
		public struct World3DUiGlobalSetting // TypeDefIndex: 49903
		{
			// Fields
			public bool bOverride; // 0x00
			public World3DUiSetting setting; // 0x01
			public World3DUiSetting overrideSetting; // 0x02
	
			// Properties
			public bool buildingNameShadowDisable { get; set; } // 0x0000000183967330-0x0000000183967370 0x00000001869D90A8-0x00000001869D9104
	
			// Methods
			public void Disable(); // 0x00000001869D9050-0x00000001869D90A8
			public void ResetOverride(); // 0x00000001834D5BD0-0x00000001834D5C00
		}
	
		[Serializable]
		public struct World3DUiSetting // TypeDefIndex: 49904
		{
			// Fields
			public bool buildingNameShadowDisable; // 0x00
		}
	
		[Serializable]
		public struct CurveGlobalSetting // TypeDefIndex: 49905
		{
			// Fields
			public unsafe void* buildCurve; // 0x00
			public unsafe void* buildAlphaCurve0; // 0x08
			public unsafe void* buildAlphaCurve1; // 0x10
			public unsafe void* repairCurve0; // 0x18
			public unsafe void* repairCurve1; // 0x20
	
			// Methods
			public void SetBuildCurve(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1); // 0x0000000183DF10D0-0x0000000183DF1130
			public void SetRepairCurve0(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve); // 0x0000000183DF1090-0x0000000183DF10D0
			public void SetRepairCurve1(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve); // 0x0000000183DF1050-0x0000000183DF1090
		}
	
		[NoAlias]
		public struct MapGridRendererData // TypeDefIndex: 49910
		{
			// Fields
			public const int MAX_COUNT = 3200; // Metadata: 0x0232EC17
			public short gridCountRegion; // 0x00
			public short gridCountField; // 0x02
			public short gridCount; // 0x04
			public unsafe fixed /* 0x00000000-0x00000000 */ byte infos[0]; // 0x06
	
			// Properties
			public MapGridInfo this[int idx] { get => default; } // 0x00000001869D562C-0x00000001869D56DC 
	
			// Nested types
			public struct MapGridInfo // TypeDefIndex: 49908
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
				public enum SelectType // TypeDefIndex: 49906
				{
					NORMAL = 0,
					BLUEPRINT = 1
				}
	
				public enum GridVoxelType // TypeDefIndex: 49907
				{
					NORMAL = 0,
					WATER = 1,
					RIFT = 2
				}
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _infos_e__FixedBuffer // TypeDefIndex: 49909
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			// Methods
			public void UpdateGrid([NoAlias] ref MapGridInfo[] gridInfosRegion, [NoAlias] ref MapGridInfo[] gridInfosField); // 0x00000001869D54E8-0x00000001869D562C
			public void Reset(); // 0x0000000184D776B0-0x0000000184D776E0
			public unsafe MapGridInfo* GetGridInfoPtr(int idx); // 0x0000000184D8CF50-0x0000000184D8CF60
		}
	
		[Serializable]
		public struct UnitPortConfigDB // TypeDefIndex: 49911
		{
			// Fields
			public NativeParallelHashMap<int, UnitPortConfig> configMap; // 0x00
	
			// Methods
			public void Initialize(int capacity = 128 /* Metadata: 0x0232EC1E */); // 0x0000000184CC7E30-0x0000000184CC7EE0
			public void Dispose(); // 0x00000001869D7A70-0x00000001869D7B04
			[IDTag(0)]
			public bool EnsureValue(string unitName, out UnitPortConfig value); // 0x00000001837ABD40-0x00000001837ABE90
			[IDTag(1)]
			public bool EnsureValue(int unitNameFastId, out UnitPortConfig value); // 0x000000018398C610-0x000000018398C670
			[IDTag(1)]
			public bool TryGetValue(string unitName, out UnitPortConfig value); // 0x00000001837ABE90-0x00000001837ABF10
			[IDTag(0)]
			public bool TryGetValue(int unitNameFastId, out UnitPortConfig value); // 0x00000001837ABC70-0x00000001837ABD40
			[IDTag(1)]
			public void Add(string unitName, [IsReadOnly] in UnitPortConfig value); // 0x0000000184403700-0x00000001844037A0
			[IDTag(0)]
			public void Add(int unitNameFastId, [IsReadOnly] in UnitPortConfig value); // 0x00000001844037A0-0x0000000184403810
			public bool ContainsKey(string unitName); // 0x00000001869D79C0-0x00000001869D7A70
			public void Clear(); // 0x00000001869D792C-0x00000001869D79C0
			[IDTag(1)]
			private UnitPortConfig _CreateWithTable(int unitNameFastId); // 0x00000001869D7B04-0x00000001869D7C7C
			[IDTag(0)]
			private UnitPortConfig _CreateWithTable(string unitName); // 0x0000000183058F50-0x0000000183059C80
			private static void _ParseGlobalPortIdx(string templateName, ref FactoryUnitPortConfig port, int inPortCount); // 0x000000018305AA80-0x000000018305AC00
			[CompilerGenerated]
			internal static void __CreateWithTable_g__FillBuildingPorts_12_0(string templateName, FactoryBuildingData data, ref UnitPortConfig target); // 0x0000000183059F20-0x000000018305AA80
			[CompilerGenerated]
			internal static void __CreateWithTable_g__ParsePort_12_1(ref UnitPortConfig target, string templateName, Vector3IntData range, BeanArray<TransformInt> inputPorts, BeanArray<TransformInt> outputPorts, bool isPipePort); // 0x000000018305AC00-0x000000018305B2F0
		}
	
		public struct UnitPortConfig // TypeDefIndex: 49912
		{
			// Fields
			public ushort inputPortCount; // 0x00
			public ushort outputPortCount; // 0x02
			public FixedList512Bytes<FactoryUnitPortConfig> portIn; // 0x04
			public FixedList512Bytes<FactoryUnitPortConfig> portOut; // 0x204
		}
	
		[Serializable]
		public struct PerDrawGlobalSetting // TypeDefIndex: 49919
		{
			// Fields
			public const int COLOR_DATA_CAPACITY = 60895; // Metadata: 0x0232EC20
			public const int PASS_DATA_CAPACITY = 60800; // Metadata: 0x0232EC24
			public unsafe fixed /* 0x00000000-0x00000000 */ byte colorData[0]; // 0x00
			public unsafe fixed /* 0x00000000-0x00000000 */ byte passData[0]; // 0xEDDF
	
			// Nested types
			public struct PerDrawPassGlobalSetting // TypeDefIndex: 49914
			{
				// Fields
				public int count; // 0x00
				public unsafe fixed /* 0x00000000-0x00000000 */ byte config[0]; // 0x04
	
				// Properties
				public PerDrawPassConfig this[int idx] { get => default; set {} } // 0x00000001869D5F64-0x00000001869D6014 0x00000001840FD4E0-0x00000001840FD550
	
				// Nested types
				[CompilerGenerated]
				[UnsafeValueType]
				public struct _config_e__FixedBuffer // TypeDefIndex: 49913
				{
					// Fields
					public byte FixedElementField; // 0x00
				}
	
				// Methods
				public PerDrawPassConfig GetPerDrawPassConfig(int idx); // 0x00000001869D5EC4-0x00000001869D5F64
			}
	
			public struct PerDrawColorGlobalSetting // TypeDefIndex: 49916
			{
				// Fields
				public int count; // 0x00
				public unsafe fixed /* 0x00000000-0x00000000 */ byte configs[0]; // 0x04
	
				// Properties
				public PerDrawConfig this[int idx] { get => default; set {} } // 0x00000001869D5ABC-0x00000001869D5B78 0x00000001840FD430-0x00000001840FD4A0
	
				// Nested types
				[CompilerGenerated]
				[UnsafeValueType]
				public struct _configs_e__FixedBuffer // TypeDefIndex: 49915
				{
					// Fields
					public byte FixedElementField; // 0x00
				}
	
				// Methods
				public PerDrawConfig GetPerDrawConfig(int idx); // 0x00000001869D5A14-0x00000001869D5ABC
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _colorData_e__FixedBuffer // TypeDefIndex: 49917
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			[CompilerGenerated]
			[UnsafeValueType]
			public struct _passData_e__FixedBuffer // TypeDefIndex: 49918
			{
				// Fields
				public byte FixedElementField; // 0x00
			}
	
			// Methods
			public unsafe void Apply(HGFactoryRendererBinderComponent* binder, LogicEntityState entityState, LogicEntityType entityType); // 0x00000001869D5DB0-0x00000001869D5E18
			public void Apply(ref HGFactoryRendererBinderComponent binder, LogicEntityState entityState, LogicEntityType entityType); // 0x00000001869D5E18-0x00000001869D5EC4
			public static unsafe void Apply(ref HGFactoryRendererBinderComponent binder, PerDrawConfig* perDrawConfigs, int length); // 0x00000001869D5D30-0x00000001869D5DB0
			public unsafe void ApplyPass(HGFactoryRendererBinderComponent* binder, LogicEntityState entityState, LogicEntityType entityType, uint currentLightMode); // 0x00000001869D5C3C-0x00000001869D5CAC
			public void ApplyPass(ref HGFactoryRendererBinderComponent binder, LogicEntityState entityState, LogicEntityType entityType, uint currentLightMode); // 0x00000001869D5B78-0x00000001869D5C3C
			public static unsafe void ApplyPass(ref HGFactoryRendererBinderComponent binder, PerDrawPassConfig* perDrawConfigs, int length, uint currentLightMode); // 0x00000001869D5CAC-0x00000001869D5D30
			public void Parse(SerializeFieldDictionary<LogicEntityState, SerializeFieldDictionary<LogicEntityType, PerDrawConfigArray>> setting); // 0x00000001840FBE80-0x00000001840FD430
			private int _GetKey(LogicEntityState entityState, LogicEntityType entityType); // 0x00000001840FD4A0-0x00000001840FD4E0
		}
	
		public struct SystemIntervalGlobalSetting // TypeDefIndex: 49920
		{
			// Fields
			public bool bOverride; // 0x00
			public SystemIntervalSetting setting; // 0x04
			public SystemIntervalSetting overrideSetting; // 0x2C
	
			// Properties
			public int crossCollectFrameInterval { get; set; } // 0x00000001834D5BA0-0x00000001834D5BD0 0x00000001869D7080-0x00000001869D70DC
			public int cullingSystemInterval { get; set; } // 0x00000001834D4A10-0x00000001834D4A70 0x00000001869D70DC-0x00000001869D7138
			public int unitPreviewSystemInterval { get; set; } // 0x00000001834D4830-0x00000001834D4890 0x00000001869D72A8-0x00000001869D7304
			public int portPreviewRenderSystemInterval { get; set; } // 0x00000001834D48F0-0x00000001834D4950 0x00000001869D724C-0x00000001869D72A8
			public int buildingStateSystemInterval { get; set; } // 0x00000001834D4A70-0x00000001834D4AD0 0x00000001869D7024-0x00000001869D7080
			public int portBlockSystemInterval { get; set; } // 0x00000001834D4890-0x00000001834D48F0 0x00000001869D71F0-0x00000001869D724C
			public int outputUISystemInterval { get; set; } // 0x00000001834D4950-0x00000001834D49B0 0x00000001869D7194-0x00000001869D71F0
			public int envGeneratorUISystemInterval { get; } // 0x00000001834D4B30-0x00000001834D4BD0 
			public int buildingNameSystemInterval { get; set; } // 0x00000001869D6F10-0x00000001869D6F6C 0x00000001869D6FC8-0x00000001869D7024
			public int adjustGroundSystemInterval { get; set; } // 0x00000001834D4AD0-0x00000001834D4B30 0x00000001869D6F6C-0x00000001869D6FC8
			public int gridSystemInterval { get; set; } // 0x00000001834D49B0-0x00000001834D4A10 0x00000001869D7138-0x00000001869D7194
	
			// Methods
			public void Disable(); // 0x00000001869D6E40-0x00000001869D6F10
			public void ResetOverride(); // 0x00000001834D5C30-0x00000001834D5C70
		}
	
		[Serializable]
		public struct SystemIntervalSetting // TypeDefIndex: 49921
		{
			// Fields
			private const int MIN_INTERVAL = 0; // Metadata: 0x0232EC28
			private const int MAX_INTERVAL = 60; // Metadata: 0x0232EC29
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
		public struct UIEffectPathConfig // TypeDefIndex: 49922
		{
			// Fields
			public static int s_max; // 0x00
			public NativeParallelHashMap<int, FixedString32Bytes> atlasNames; // 0x00
			public NativeParallelHashMap<int, float4> atlasColors; // 0x10
			public NativeParallelHashMap<int, float4> atlasUVs; // 0x20
	
			// Constructors
			static UIEffectPathConfig(); // 0x0000000184D79850-0x0000000184D79890
	
			// Methods
			public void Parse(SerializeFieldDictionary<FacBuildingState, string> config, SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryStateIconColorConfig, FactoryUIAtlasSOData uvConfig); // 0x00000001834D6920-0x00000001834D7A80
			public bool Get(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // 0x00000001869D7304-0x00000001869D74AC
		}
	
		// Constructors
		static GlobalSharedData(); // 0x00000001849D00D0-0x00000001849D0310
	
		// Methods
		public void Reset(); // 0x00000001869D5444-0x00000001869D54E8
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public abstract class BaseProcessor : IProcessor // TypeDefIndex: 49924
	{
		// Fields
		protected FactorySetting m_factorySetting; // 0x10
		[CompilerGenerated]
		private float _interval_k__BackingField; // 0x18
		[CompilerGenerated]
		private float _curInterval_k__BackingField; // 0x1C
	
		// Properties
		public virtual float interval { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86380-0x0000000184D86390 0x0000000184D86390-0x0000000184D863A0
		public virtual float curInterval { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public abstract string name { get; }
		public virtual bool lowFrameEnable { get; } // 0x0000000184150B60-0x0000000184150C30 
	
		// Constructors
		protected BaseProcessor(); // 0x0000000184D8CF30-0x0000000184D8CF40
	
		// Methods
		public virtual void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting); // 0x00000001834D9980-0x00000001834D99E0
		public virtual JobHandle PreExecute(ref EntityManager em, long time, long deltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies); // 0x00000001834D3270-0x00000001834D3300
		public virtual JobHandle Execute(ref EntityManager em, long time, long deltaTime, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies); // 0x00000001830D69A0-0x00000001830D6A30
		public virtual JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle); // 0x00000001834D0770-0x00000001834D0800
		public virtual void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null); // 0x00000001834CFAA0-0x00000001834CFB20
		public virtual void TearDown(ref EntityManager em, ref GlobalEnv env); // 0x00000001869D35E0-0x00000001869D363C
		protected void StructuralSync(ref JobHandle jh, ref NativeList<JobHandle> noneDependencies); // 0x00000001835BC950-0x00000001835BC9F0
		protected void ScheduleNoneDependencies(ref NativeList<JobHandle> noneDependencies); // 0x00000001835BC7A0-0x00000001835BC8B0
		public bool InLowFrameMode(ref GlobalEnv env); // 0x00000001834D0130-0x00000001834D01B0
		protected bool SpecialEntityExisted(ref EntityManager em); // 0x00000001830D9860-0x00000001830D9950
	}

	public interface IProcessor // TypeDefIndex: 49925
	{
		// Properties
		float interval { get; }
		float curInterval { get; set; }
		string name { get; }
		bool lowFrameEnable { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Methods
		void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting);
		JobHandle PreExecute(ref EntityManager em, long time, long dt, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies);
		JobHandle Execute(ref EntityManager em, long time, long dt, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies);
		JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle);
		void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null);
		void TearDown(ref EntityManager em, ref GlobalEnv env);
		bool InLowFrameMode(ref GlobalEnv env);
	}

	public class StructuralChangedAttribute : Attribute // TypeDefIndex: 49926
	{
		// Constructors
		public StructuralChangedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[BurstCompile]
	public class UnsafeJobFuncPointers // TypeDefIndex: 49942
	{
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void ApplyRender(HGFactoryRendererBinderComponent* binder, PerDrawConfig* perDrawConfigs, int length); // TypeDefIndex: 49927; 0x0000000181546280-0x00000001815462A0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate bool FacRegionPosValid(EntityManager* entityManager, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // TypeDefIndex: 49928; 0x00000001869D4BAC-0x00000001869D4BC0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool QueryStateIconPath(FacBuildingState stateUI, out FixedString32Bytes path, out float4 uv, out float4 color); // TypeDefIndex: 49929; 0x00000001814D0D00-0x00000001814D0D20
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate FacBuildingState QueryBuildingState(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // TypeDefIndex: 49930; 0x00000001814F3120-0x00000001814F3140
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetEntityFlashStatue(ref EntityManager em, ref Entity entity, FacBuildingState statue); // TypeDefIndex: 49931; 0x0000000181546280-0x00000001815462A0
	
		public unsafe delegate void ApplyPerDrawRender_000008F6_PostfixBurstDelegate(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length); // TypeDefIndex: 49932; 0x0000000181546280-0x00000001815462A0
	
		internal static class ApplyPerDrawRender_000008F6_BurstDirectCall // TypeDefIndex: 49933
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static ApplyPerDrawRender_000008F6_BurstDirectCall(); // 0x0000000183FB2B40-0x0000000183FB2B50
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006ba66); // 0x00000001869D32DC-0x00000001869D33E0
			private static IntPtr GetFunctionPointer(); // 0x00000001869D33E0-0x00000001869D3434
			public static void Constructor(); // 0x0000000183FB1730-0x0000000183FB17C0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length); // 0x00000001869D3434-0x00000001869D34D0
		}
	
		public delegate bool GetQueryStateIconPath_000008F8_PostfixBurstDelegate(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // TypeDefIndex: 49934; 0x00000001814D0D00-0x00000001814D0D20
	
		internal static class GetQueryStateIconPath_000008F8_BurstDirectCall // TypeDefIndex: 49935
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static GetQueryStateIconPath_000008F8_BurstDirectCall(); // 0x0000000183FB2B30-0x0000000183FB2B40
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006ba77); // 0x00000001869D509C-0x00000001869D51A0
			private static IntPtr GetFunctionPointer(); // 0x00000001869D51A0-0x00000001869D51F4
			public static void Constructor(); // 0x0000000183FB16A0-0x0000000183FB1730
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static bool Invoke(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // 0x00000001869D51F4-0x00000001869D52A0
		}
	
		public unsafe delegate bool GetLogicEntityWithPos_000008FA_PostfixBurstDelegate([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // TypeDefIndex: 49936; 0x00000001869D4BAC-0x00000001869D4BC0
	
		internal static class GetLogicEntityWithPos_000008FA_BurstDirectCall // TypeDefIndex: 49937
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static GetLogicEntityWithPos_000008FA_BurstDirectCall(); // 0x0000000183FB2B20-0x0000000183FB2B30
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006ba8d); // 0x00000001869D4CCC-0x00000001869D4DD0
			private static IntPtr GetFunctionPointer(); // 0x00000001869D4DD0-0x00000001869D4E24
			public static void Constructor(); // 0x0000000183FB1610-0x0000000183FB16A0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe bool Invoke([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // 0x00000001869D4E24-0x00000001869D4F0C
		}
	
		public delegate FacBuildingState QueryBuildingStateFunc_000008FC_PostfixBurstDelegate(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // TypeDefIndex: 49938; 0x00000001814F3120-0x00000001814F3140
	
		internal static class QueryBuildingStateFunc_000008FC_BurstDirectCall // TypeDefIndex: 49939
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static QueryBuildingStateFunc_000008FC_BurstDirectCall(); // 0x0000000183FB2B10-0x0000000183FB2B20
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006ba9f); // 0x00000001869D6248-0x00000001869D634C
			private static IntPtr GetFunctionPointer(); // 0x00000001869D634C-0x00000001869D63A0
			public static void Constructor(); // 0x0000000183FB1580-0x0000000183FB1610
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static FacBuildingState Invoke(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // 0x00000001869D63A0-0x00000001869D6440
		}
	
		public delegate void SetEntityFlashStatueFunc_000008FE_PostfixBurstDelegate(ref EntityManager em, ref Entity entity, FacBuildingState statue); // TypeDefIndex: 49940; 0x0000000181546280-0x00000001815462A0
	
		internal static class SetEntityFlashStatueFunc_000008FE_BurstDirectCall // TypeDefIndex: 49941
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SetEntityFlashStatueFunc_000008FE_BurstDirectCall(); // 0x0000000183FB2B00-0x0000000183FB2B10
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006baae); // 0x00000001869D68D4-0x00000001869D69D8
			private static IntPtr GetFunctionPointer(); // 0x00000001869D69D8-0x00000001869D6A2C
			public static void Constructor(); // 0x0000000183FB14F0-0x0000000183FB1580
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager em, ref Entity entity, FacBuildingState statue); // 0x00000001869D6A2C-0x00000001869D6ACC
		}
	
		// Constructors
		public UnsafeJobFuncPointers(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static FunctionPointer<ApplyRender> GetApplyRenderPointer(); // 0x00000001834D67D0-0x00000001834D68A0
		public static FunctionPointer<FacRegionPosValid> GetFacRegionValid(); // 0x00000001834D5AD0-0x00000001834D5BA0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(ApplyRender))]
		public static unsafe void ApplyPerDrawRender(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length); // 0x00000001869D8488-0x00000001869D84E8
		public static FunctionPointer<QueryStateIconPath> GetQueryStateIconPathFuncPtr(); // 0x00000001834D5A00-0x00000001834D5AD0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryStateIconPath))]
		public static bool GetQueryStateIconPath(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // 0x00000001869D8B08-0x00000001869D8B7C
		public static bool GetLogicEntityWithPosAdapter(ref EntityManager em, float x, float y, float z, out UnitFragment unitFragment); // 0x00000001869D84E8-0x00000001869D86D0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(FacRegionPosValid))]
		public static unsafe bool GetLogicEntityWithPos([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // 0x00000001869D89A8-0x00000001869D8A3C
		public static FunctionPointer<QueryBuildingState> GetQueryBuildingStatePointer(); // 0x00000001834D85F0-0x00000001834D86C0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryBuildingState))]
		public static FacBuildingState QueryBuildingStateFunc(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // 0x00000001869D8B90-0x00000001869D8BF0
		public static FunctionPointer<SetEntityFlashStatue> GetSetEntityFlashStatuePointer(); // 0x00000001834D8520-0x00000001834D85F0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(SetEntityFlashStatue))]
		public static void SetEntityFlashStatueFunc(ref EntityManager em, ref Entity entity, FacBuildingState statue); // 0x00000001869D8C04-0x00000001869D8C64
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(ApplyRender))]
		public static unsafe void ApplyPerDrawRender_BurstManaged(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length); // 0x00000001869D8434-0x00000001869D8488
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryStateIconPath))]
		public static bool GetQueryStateIconPath_BurstManaged(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // 0x00000001869D8A3C-0x00000001869D8B08
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(FacRegionPosValid))]
		public static unsafe bool GetLogicEntityWithPos_BurstManaged([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // 0x00000001869D86D0-0x00000001869D89A8
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryBuildingState))]
		public static FacBuildingState QueryBuildingStateFunc_BurstManaged(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // 0x00000001869D8B7C-0x00000001869D8B90
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(SetEntityFlashStatue))]
		public static void SetEntityFlashStatueFunc_BurstManaged(ref EntityManager em, ref Entity entity, FacBuildingState statue); // 0x00000001869D8BF0-0x00000001869D8C04
	}

	[BurstCompile(FloatPrecision = FloatPrecision.High, FloatMode = FloatMode.Fast)]
	public struct AdditiveEffectJob : IJobParallelForDefer // TypeDefIndex: 49949
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
		public EntityManager em; // 0x88
		[NativeSetThreadIndex]
		public int threadId; // 0x98
		public int frameCount; // 0x9C
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedExtDataPtr; // 0xA0
		public NativeQueue<FactoryBuildingEffectData> finishedEffectQueue; // 0xA8
	
		// Nested types
		public delegate bool _BuildDismissState_0000091C_PostfixBurstDelegate(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 49943; 0x0000000182C0A850-0x0000000182C0A870
	
		internal static class _BuildDismissState_0000091C_BurstDirectCall // TypeDefIndex: 49944
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BuildDismissState_0000091C_BurstDirectCall(); // 0x0000000183FB2AF0-0x0000000183FB2B00
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006baf9); // 0x00000001869D9104-0x00000001869D9208
			private static IntPtr GetFunctionPointer(); // 0x00000001869D9208-0x00000001869D925C
			public static void Constructor(); // 0x0000000183FB1460-0x0000000183FB14F0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static bool Invoke(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869D925C-0x00000001869D9334
		}
	
		public delegate bool _Repair0_0000091E_PostfixBurstDelegate(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 49945; 0x00000001814F3120-0x00000001814F3140
	
		internal static class _Repair0_0000091E_BurstDirectCall // TypeDefIndex: 49946
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair0_0000091E_BurstDirectCall(); // 0x0000000183FB2AE0-0x0000000183FB2AF0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bb0c); // 0x00000001869D9550-0x00000001869D9654
			private static IntPtr GetFunctionPointer(); // 0x00000001869D9654-0x00000001869D96A8
			public static void Constructor(); // 0x0000000183FB13D0-0x0000000183FB1460
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static bool Invoke(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869D96A8-0x00000001869D9740
		}
	
		public delegate bool _Repair1_0000091F_PostfixBurstDelegate(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 49947; 0x00000001814F3120-0x00000001814F3140
	
		internal static class _Repair1_0000091F_BurstDirectCall // TypeDefIndex: 49948
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1_0000091F_BurstDirectCall(); // 0x0000000183FAE750-0x0000000183FAE760
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bb1b); // 0x00000001869D98D0-0x00000001869D99D4
			private static IntPtr GetFunctionPointer(); // 0x00000001869D99D4-0x00000001869D9A28
			public static void Constructor(); // 0x0000000183FAEC50-0x0000000183FAECE0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static bool Invoke(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869D9A28-0x00000001869D9AC0
		}
	
		// Methods
		public void SetSharedExtData(IntPtr data); // 0x00000001830DAE00-0x00000001830DAE70
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869CDEF4-0x00000001869CDF74
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869CDBAC-0x00000001869CDEF4
		private void _OnStackEmpty(ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData); // 0x00000001869CE1A0-0x00000001869CE244
		private void _CancelPreState(AdditiveEffectFragment.AdditiveEffectType preState, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData); // 0x00000001869CD430-0x00000001869CD444
		private void _ResumeState(AdditiveEffectFragment.AdditiveEffectType state, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData); // 0x00000001869CD4AC-0x00000001869CD73C
		private void _SetStateValid(AdditiveEffectFragment.AdditiveEffectType state, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData, bool valid); // 0x00000001869CE304-0x00000001869CE5B4
		private void _UpdateInternalStateLifeCycle(ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData); // 0x00000001869CE5B4-0x00000001869CE738
		[BurstCompile]
		private static bool _BuildDismissState(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869CE094-0x00000001869CE12C
		private static void _InitBuildState(ref CutoffState cutoffState, ref BuildDismissState buildDismissState); // 0x00000001869CE12C-0x00000001869CE1A0
		[BurstCompile]
		private static bool _Repair0(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869CE244-0x00000001869CE2A4
		[BurstCompile]
		private static bool _Repair1(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869CE2A4-0x00000001869CE304
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x00000001830DADA0-0x00000001830DAE00
		[IDTag(0)]
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC2A */); // 0x00000001830DABD0-0x00000001830DADA0
		[IDTag(1)]
		public JobHandle ScheduleDefer(JobHandle jobHandleDep0, JobHandle jobHandleDep1, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC2B */); // 0x00000001869CDF74-0x00000001869CE094
		[BurstCompile]
		public static bool _BuildDismissState_BurstManaged(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869CD320-0x00000001869CD430
		[BurstCompile]
		public static bool _Repair0_BurstManaged(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869CD444-0x00000001869CD478
		[BurstCompile]
		public static bool _Repair1_BurstManaged(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869CD478-0x00000001869CD4AC
	}

	[BurstCompile]
	public struct AdditiveEffectQueryJob : IJob // TypeDefIndex: 49950
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
		public void Execute(); // 0x00000001869CE738-0x00000001869CE8BC
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer additiveEffectQr, ref EntityQueryV2.QueryResultDefer hintQr, ref EntityQueryV2.QueryResultDefer additiveEffectRendererQr, bool resetQr = true /* Metadata: 0x0232EC2C */); // 0x00000001830D3850-0x00000001830D3910
	}

	[BurstCompile]
	public struct AdditiveEffectRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 50037
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
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedExtDataPtr; // 0x98
	
		// Nested types
		public delegate void _BPBuildStart_00000928_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 49951; 0x0000000182C394B0-0x0000000182C394D0
	
		internal static class _BPBuildStart_00000928_BurstDirectCall // TypeDefIndex: 49952
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildStart_00000928_BurstDirectCall(); // 0x0000000183FAE760-0x0000000183FAE770
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bc97); // 0x00000001869E7130-0x00000001869E7234
			private static IntPtr GetFunctionPointer(); // 0x00000001869E7234-0x00000001869E7288
			public static void Constructor(); // 0x0000000183FAECE0-0x0000000183FAED70
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869E7288-0x00000001869E7350
		}
	
		public delegate void _BPBuildProcess_00000929_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 49953; 0x0000000182C394B0-0x0000000182C394D0
	
		internal static class _BPBuildProcess_00000929_BurstDirectCall // TypeDefIndex: 49954
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildProcess_00000929_BurstDirectCall(); // 0x0000000183FAE770-0x0000000183FAE780
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bcb2); // 0x00000001869E6DC8-0x00000001869E6ECC
			private static IntPtr GetFunctionPointer(); // 0x00000001869E6ECC-0x00000001869E6F20
			public static void Constructor(); // 0x0000000183FAED70-0x0000000183FAEE00
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869E6F20-0x00000001869E6FE8
		}
	
		public delegate void _BPBuildEnd_0000092A_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 49955; 0x0000000182C394B0-0x0000000182C394D0
	
		internal static class _BPBuildEnd_0000092A_BurstDirectCall // TypeDefIndex: 49956
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildEnd_0000092A_BurstDirectCall(); // 0x0000000183FAE780-0x0000000183FAE790
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bccd); // 0x00000001869E6988-0x00000001869E6A8C
			private static IntPtr GetFunctionPointer(); // 0x00000001869E6A8C-0x00000001869E6AE0
			public static void Constructor(); // 0x0000000183FAEE00-0x0000000183FAEE90
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869E6AE0-0x00000001869E6BAC
		}
	
		public delegate void _BPBuildCutoffStateStart_0000092B_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49957; 0x0000000181546280-0x00000001815462A0
	
		internal static class _BPBuildCutoffStateStart_0000092B_BurstDirectCall // TypeDefIndex: 49958
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateStart_0000092B_BurstDirectCall(); // 0x0000000183FAE790-0x0000000183FAE7A0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bce0); // 0x00000001869E66D8-0x00000001869E67DC
			private static IntPtr GetFunctionPointer(); // 0x00000001869E67DC-0x00000001869E6830
			public static void Constructor(); // 0x0000000183FAEE90-0x0000000183FAEF20
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869E6830-0x00000001869E68C4
		}
	
		public delegate void _BPBuildCutoffStateEnd_0000092C_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49959; 0x0000000181546280-0x00000001815462A0
	
		internal static class _BPBuildCutoffStateEnd_0000092C_BurstDirectCall // TypeDefIndex: 49960
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateEnd_0000092C_BurstDirectCall(); // 0x0000000183FAE7A0-0x0000000183FAE7B0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bcef); // 0x00000001869E609C-0x00000001869E61A0
			private static IntPtr GetFunctionPointer(); // 0x00000001869E61A0-0x00000001869E61F4
			public static void Constructor(); // 0x0000000183FAEF20-0x0000000183FAEFB0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869E61F4-0x00000001869E628C
		}
	
		public delegate void _BPBuildCutoffStateProcess_0000092D_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49961; 0x0000000181546280-0x00000001815462A0
	
		internal static class _BPBuildCutoffStateProcess_0000092D_BurstDirectCall // TypeDefIndex: 49962
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateProcess_0000092D_BurstDirectCall(); // 0x0000000183FAE7B0-0x0000000183FAE7C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bcfe); // 0x00000001869E6424-0x00000001869E6528
			private static IntPtr GetFunctionPointer(); // 0x00000001869E6528-0x00000001869E657C
			public static void Constructor(); // 0x0000000183FAEFB0-0x0000000183FAF040
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869E657C-0x00000001869E6614
		}
	
		public delegate void _CutoffStateStart_00000931_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49963; 0x0000000181546280-0x00000001815462A0
	
		internal static class _CutoffStateStart_00000931_BurstDirectCall // TypeDefIndex: 49964
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateStart_00000931_BurstDirectCall(); // 0x0000000183FAE7C0-0x0000000183FAE7D0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bd0d); // 0x00000001869E8EC4-0x00000001869E8FC8
			private static IntPtr GetFunctionPointer(); // 0x00000001869E8FC8-0x00000001869E901C
			public static void Constructor(); // 0x0000000183FAF040-0x0000000183FAF0D0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869E901C-0x00000001869E90B4
		}
	
		public delegate void _CutoffStateEnd_00000932_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49965; 0x0000000181546280-0x00000001815462A0
	
		internal static class _CutoffStateEnd_00000932_BurstDirectCall // TypeDefIndex: 49966
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateEnd_00000932_BurstDirectCall(); // 0x0000000183FAE7D0-0x0000000183FAE7E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bd1c); // 0x00000001869E895C-0x00000001869E8A60
			private static IntPtr GetFunctionPointer(); // 0x00000001869E8A60-0x00000001869E8AB4
			public static void Constructor(); // 0x0000000183FAF0D0-0x0000000183FAF160
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869E8AB4-0x00000001869E8B4C
		}
	
		public delegate void _CutoffStateProcess_00000933_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 49967; 0x0000000181546280-0x00000001815462A0
	
		internal static class _CutoffStateProcess_00000933_BurstDirectCall // TypeDefIndex: 49968
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateProcess_00000933_BurstDirectCall(); // 0x0000000183FAE7E0-0x0000000183FAE7F0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bd2b); // 0x00000001869E8C10-0x00000001869E8D14
			private static IntPtr GetFunctionPointer(); // 0x00000001869E8D14-0x00000001869E8D68
			public static void Constructor(); // 0x0000000183FAF160-0x0000000183FAF1F0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869E8D68-0x00000001869E8E00
		}
	
		public delegate void _BuildStateProcess_00000936_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 49969; 0x0000000182C394B0-0x0000000182C394D0
	
		internal static class _BuildStateProcess_00000936_BurstDirectCall // TypeDefIndex: 49970
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BuildStateProcess_00000936_BurstDirectCall(); // 0x0000000183FAE7F0-0x0000000183FAE800
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bd42); // 0x00000001869E7DCC-0x00000001869E7ED0
			private static IntPtr GetFunctionPointer(); // 0x00000001869E7ED0-0x00000001869E7F24
			public static void Constructor(); // 0x0000000183FAF1F0-0x0000000183FAF280
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869E7F24-0x00000001869E8010
		}
	
		public delegate void _HighLightStart_00000937_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49971; 0x0000000181546280-0x00000001815462A0
	
		internal static class _HighLightStart_00000937_BurstDirectCall // TypeDefIndex: 49972
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightStart_00000937_BurstDirectCall(); // 0x0000000183FAE800-0x0000000183FAE810
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bd55); // 0x00000001869E9F10-0x00000001869EA014
			private static IntPtr GetFunctionPointer(); // 0x00000001869EA014-0x00000001869EA068
			public static void Constructor(); // 0x0000000183FAF280-0x0000000183FAF310
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EA068-0x00000001869EA100
		}
	
		public delegate void _HighLightEnd_00000938_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49973; 0x0000000181546280-0x00000001815462A0
	
		internal static class _HighLightEnd_00000938_BurstDirectCall // TypeDefIndex: 49974
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightEnd_00000938_BurstDirectCall(); // 0x0000000183FAE810-0x0000000183FAE820
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bd64); // 0x00000001869E99A0-0x00000001869E9AA4
			private static IntPtr GetFunctionPointer(); // 0x00000001869E9AA4-0x00000001869E9AF8
			public static void Constructor(); // 0x0000000183FAF310-0x0000000183FAF3A0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869E9AF8-0x00000001869E9B94
		}
	
		public delegate void _HighLightProcess_00000939_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49975; 0x0000000181546280-0x00000001815462A0
	
		internal static class _HighLightProcess_00000939_BurstDirectCall // TypeDefIndex: 49976
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightProcess_00000939_BurstDirectCall(); // 0x0000000183FAE820-0x0000000183FAE830
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bd73); // 0x00000001869E9C58-0x00000001869E9D5C
			private static IntPtr GetFunctionPointer(); // 0x00000001869E9D5C-0x00000001869E9DB0
			public static void Constructor(); // 0x0000000183FAF3A0-0x0000000183FAF430
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869E9DB0-0x00000001869E9E4C
		}
	
		public delegate void _FigureStart_0000093A_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49977; 0x0000000181546280-0x00000001815462A0
	
		internal static class _FigureStart_0000093A_BurstDirectCall // TypeDefIndex: 49978
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureStart_0000093A_BurstDirectCall(); // 0x0000000183FAE830-0x0000000183FAE840
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bd82); // 0x00000001869E96E8-0x00000001869E97EC
			private static IntPtr GetFunctionPointer(); // 0x00000001869E97EC-0x00000001869E9840
			public static void Constructor(); // 0x0000000183FAF430-0x0000000183FAF4C0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869E9840-0x00000001869E98DC
		}
	
		public delegate void _FigureProcess_0000093B_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49979; 0x0000000181546280-0x00000001815462A0
	
		internal static class _FigureProcess_0000093B_BurstDirectCall // TypeDefIndex: 49980
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureProcess_0000093B_BurstDirectCall(); // 0x0000000183FAE840-0x0000000183FAE850
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bd91); // 0x00000001869E9430-0x00000001869E9534
			private static IntPtr GetFunctionPointer(); // 0x00000001869E9534-0x00000001869E9588
			public static void Constructor(); // 0x0000000183FAF4C0-0x0000000183FAF550
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869E9588-0x00000001869E9624
		}
	
		public delegate void _FigureEnd_0000093C_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49981; 0x0000000181546280-0x00000001815462A0
	
		internal static class _FigureEnd_0000093C_BurstDirectCall // TypeDefIndex: 49982
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureEnd_0000093C_BurstDirectCall(); // 0x0000000183FAE850-0x0000000183FAE860
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bda0); // 0x00000001869E9178-0x00000001869E927C
			private static IntPtr GetFunctionPointer(); // 0x00000001869E927C-0x00000001869E92D0
			public static void Constructor(); // 0x0000000183FAF550-0x0000000183FAF5E0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869E92D0-0x00000001869E936C
		}
	
		public delegate void _HintStart_0000093D_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha); // TypeDefIndex: 49983; 0x00000001815547C0-0x00000001815547E0
	
		internal static class _HintStart_0000093D_BurstDirectCall // TypeDefIndex: 49984
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintStart_0000093D_BurstDirectCall(); // 0x0000000183FAE860-0x0000000183FAE870
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bdb1); // 0x00000001869EA724-0x00000001869EA828
			private static IntPtr GetFunctionPointer(); // 0x00000001869EA828-0x00000001869EA87C
			public static void Constructor(); // 0x0000000183FAF5E0-0x0000000183FAF670
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha); // 0x00000001869EA87C-0x00000001869EA92C
		}
	
		public delegate void _HintEnd_0000093E_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49985; 0x0000000181546280-0x00000001815462A0
	
		internal static class _HintEnd_0000093E_BurstDirectCall // TypeDefIndex: 49986
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintEnd_0000093E_BurstDirectCall(); // 0x0000000183FAE870-0x0000000183FAE880
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bdc1); // 0x00000001869EA1C4-0x00000001869EA2C8
			private static IntPtr GetFunctionPointer(); // 0x00000001869EA2C8-0x00000001869EA31C
			public static void Constructor(); // 0x0000000183FAF670-0x0000000183FAF700
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EA31C-0x00000001869EA3B8
		}
	
		public delegate void _HintProcess_0000093F_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49987; 0x0000000181546280-0x00000001815462A0
	
		internal static class _HintProcess_0000093F_BurstDirectCall // TypeDefIndex: 49988
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintProcess_0000093F_BurstDirectCall(); // 0x0000000183FAE880-0x0000000183FAE890
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bdd0); // 0x00000001869EA47C-0x00000001869EA580
			private static IntPtr GetFunctionPointer(); // 0x00000001869EA580-0x00000001869EA5D4
			public static void Constructor(); // 0x0000000183FAF700-0x0000000183FAF790
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EA5D4-0x00000001869EA660
		}
	
		public delegate void _OverloadStart_00000940_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49989; 0x0000000181546280-0x00000001815462A0
	
		internal static class _OverloadStart_00000940_BurstDirectCall // TypeDefIndex: 49990
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadStart_00000940_BurstDirectCall(); // 0x0000000183FAE890-0x0000000183FAE8A0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bddf); // 0x00000001869EBDD8-0x00000001869EBEDC
			private static IntPtr GetFunctionPointer(); // 0x00000001869EBEDC-0x00000001869EBF30
			public static void Constructor(); // 0x0000000183FAF790-0x0000000183FAF820
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EBF30-0x00000001869EBFCC
		}
	
		public delegate void _OverloadEnd_00000941_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49991; 0x0000000181546280-0x00000001815462A0
	
		internal static class _OverloadEnd_00000941_BurstDirectCall // TypeDefIndex: 49992
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadEnd_00000941_BurstDirectCall(); // 0x0000000183FAE8A0-0x0000000183FAE8B0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bdee); // 0x00000001869EB060-0x00000001869EB164
			private static IntPtr GetFunctionPointer(); // 0x00000001869EB164-0x00000001869EB1B8
			public static void Constructor(); // 0x0000000183FAF820-0x0000000183FAF8B0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EB1B8-0x00000001869EB254
		}
	
		public delegate void _OverloadProcess_00000942_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49993; 0x0000000181546280-0x00000001815462A0
	
		internal static class _OverloadProcess_00000942_BurstDirectCall // TypeDefIndex: 49994
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadProcess_00000942_BurstDirectCall(); // 0x0000000183FAE8B0-0x0000000183FAE8C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bdfd); // 0x00000001869EBB30-0x00000001869EBC34
			private static IntPtr GetFunctionPointer(); // 0x00000001869EBC34-0x00000001869EBC88
			public static void Constructor(); // 0x0000000183FAF8B0-0x0000000183FAF940
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EBC88-0x00000001869EBD14
		}
	
		public delegate void _OverloadInvalidStart_00000943_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49995; 0x0000000181546280-0x00000001815462A0
	
		internal static class _OverloadInvalidStart_00000943_BurstDirectCall // TypeDefIndex: 49996
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidStart_00000943_BurstDirectCall(); // 0x0000000183FAE8C0-0x0000000183FAE8D0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006be0c); // 0x00000001869EB878-0x00000001869EB97C
			private static IntPtr GetFunctionPointer(); // 0x00000001869EB97C-0x00000001869EB9D0
			public static void Constructor(); // 0x0000000183FAF940-0x0000000183FAF9D0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EB9D0-0x00000001869EBA6C
		}
	
		public delegate void _OverloadInvalidEnd_00000944_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49997; 0x0000000181546280-0x00000001815462A0
	
		internal static class _OverloadInvalidEnd_00000944_BurstDirectCall // TypeDefIndex: 49998
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidEnd_00000944_BurstDirectCall(); // 0x0000000183FAE8D0-0x0000000183FAE8E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006be1b); // 0x00000001869EB318-0x00000001869EB41C
			private static IntPtr GetFunctionPointer(); // 0x00000001869EB41C-0x00000001869EB470
			public static void Constructor(); // 0x0000000183FAF9D0-0x0000000183FAFA60
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EB470-0x00000001869EB50C
		}
	
		public delegate void _OverloadInvalidProcess_00000945_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 49999; 0x0000000181546280-0x00000001815462A0
	
		internal static class _OverloadInvalidProcess_00000945_BurstDirectCall // TypeDefIndex: 50000
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidProcess_00000945_BurstDirectCall(); // 0x0000000183FAE8E0-0x0000000183FAE8F0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006be2a); // 0x00000001869EB5D0-0x00000001869EB6D4
			private static IntPtr GetFunctionPointer(); // 0x00000001869EB6D4-0x00000001869EB728
			public static void Constructor(); // 0x0000000183FAFA60-0x0000000183FAFAF0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EB728-0x00000001869EB7B4
		}
	
		public delegate void _Repair0Process_00000948_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 50001; 0x00000001814DD080-0x00000001814DD0A0
	
		internal static class _Repair0Process_00000948_BurstDirectCall // TypeDefIndex: 50002
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair0Process_00000948_BurstDirectCall(); // 0x0000000183FAE8F0-0x0000000183FAE900
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006be3d); // 0x00000001869ECE08-0x00000001869ECF0C
			private static IntPtr GetFunctionPointer(); // 0x00000001869ECF0C-0x00000001869ECF60
			public static void Constructor(); // 0x0000000183FAFAF0-0x0000000183FAFB80
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869ECF60-0x00000001869ED020
		}
	
		public delegate void _Repair1Start_00000949_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50003; 0x0000000181546280-0x00000001815462A0
	
		internal static class _Repair1Start_00000949_BurstDirectCall // TypeDefIndex: 50004
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1Start_00000949_BurstDirectCall(); // 0x0000000183FAE900-0x0000000183FAE910
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006be4e); // 0x00000001869ED7E4-0x00000001869ED8E8
			private static IntPtr GetFunctionPointer(); // 0x00000001869ED8E8-0x00000001869ED93C
			public static void Constructor(); // 0x0000000183FAFB80-0x0000000183FAFC10
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869ED93C-0x00000001869ED9D4
		}
	
		public delegate void _Repair1End_0000094A_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50005; 0x0000000181546280-0x00000001815462A0
	
		internal static class _Repair1End_0000094A_BurstDirectCall // TypeDefIndex: 50006
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1End_0000094A_BurstDirectCall(); // 0x0000000183FAE910-0x0000000183FAE920
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006be5d); // 0x00000001869ED208-0x00000001869ED30C
			private static IntPtr GetFunctionPointer(); // 0x00000001869ED30C-0x00000001869ED360
			public static void Constructor(); // 0x0000000183FAFC10-0x0000000183FAFCA0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869ED360-0x00000001869ED3F4
		}
	
		public delegate void _Repair1Process_0000094B_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 50007; 0x00000001814DD080-0x00000001814DD0A0
	
		internal static class _Repair1Process_0000094B_BurstDirectCall // TypeDefIndex: 50008
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1Process_0000094B_BurstDirectCall(); // 0x0000000183FAE920-0x0000000183FAE930
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006be70); // 0x00000001869ED4B8-0x00000001869ED5BC
			private static IntPtr GetFunctionPointer(); // 0x00000001869ED5BC-0x00000001869ED610
			public static void Constructor(); // 0x0000000183FAFCA0-0x0000000183FAFD30
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869ED610-0x00000001869ED6D0
		}
	
		public delegate void _BlueprintProcessInternal_0000094D_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50009; 0x0000000181546280-0x00000001815462A0
	
		internal static class _BlueprintProcessInternal_0000094D_BurstDirectCall // TypeDefIndex: 50010
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintProcessInternal_0000094D_BurstDirectCall(); // 0x0000000183FAE930-0x0000000183FAE940
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006be81); // 0x00000001869E785C-0x00000001869E7960
			private static IntPtr GetFunctionPointer(); // 0x00000001869E7960-0x00000001869E79B4
			public static void Constructor(); // 0x0000000183FAFD30-0x0000000183FAFDC0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869E79B4-0x00000001869E7A50
		}
	
		public delegate void _BlueprintEnd_0000094E_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // TypeDefIndex: 50011; 0x00000001815547C0-0x00000001815547E0
	
		internal static class _BlueprintEnd_0000094E_BurstDirectCall // TypeDefIndex: 50012
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintEnd_0000094E_BurstDirectCall(); // 0x0000000183FAE940-0x0000000183FAE950
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006be92); // 0x00000001869E7498-0x00000001869E759C
			private static IntPtr GetFunctionPointer(); // 0x00000001869E759C-0x00000001869E75F0
			public static void Constructor(); // 0x0000000183FAFDC0-0x0000000183FAFE50
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // 0x00000001869E75F0-0x00000001869E7698
		}
	
		public delegate void _BlueprintStart_0000094F_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50013; 0x0000000181546280-0x00000001815462A0
	
		internal static class _BlueprintStart_0000094F_BurstDirectCall // TypeDefIndex: 50014
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintStart_0000094F_BurstDirectCall(); // 0x0000000183FAE950-0x0000000183FAE960
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bea2); // 0x00000001869E7B14-0x00000001869E7C18
			private static IntPtr GetFunctionPointer(); // 0x00000001869E7C18-0x00000001869E7C6C
			public static void Constructor(); // 0x0000000183FAFE50-0x0000000183FAFEE0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869E7C6C-0x00000001869E7D08
		}
	
		public delegate void _PreSelectStart_00000950_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50015; 0x0000000181546280-0x00000001815462A0
	
		internal static class _PreSelectStart_00000950_BurstDirectCall // TypeDefIndex: 50016
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectStart_00000950_BurstDirectCall(); // 0x0000000183FAE960-0x0000000183FAE970
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006beb1); // 0x00000001869ECB54-0x00000001869ECC58
			private static IntPtr GetFunctionPointer(); // 0x00000001869ECC58-0x00000001869ECCAC
			public static void Constructor(); // 0x0000000183FAFEE0-0x0000000183FAFF70
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869ECCAC-0x00000001869ECD44
		}
	
		public delegate void _PreSelectEnd_00000951_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50017; 0x0000000181546280-0x00000001815462A0
	
		internal static class _PreSelectEnd_00000951_BurstDirectCall // TypeDefIndex: 50018
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectEnd_00000951_BurstDirectCall(); // 0x0000000183FAE970-0x0000000183FAE980
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bec0); // 0x00000001869EC5FC-0x00000001869EC700
			private static IntPtr GetFunctionPointer(); // 0x00000001869EC700-0x00000001869EC754
			public static void Constructor(); // 0x0000000183FAFF70-0x0000000183FB0000
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EC754-0x00000001869EC7E8
		}
	
		public delegate void _PreSelectProcess_00000952_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50019; 0x0000000181546280-0x00000001815462A0
	
		internal static class _PreSelectProcess_00000952_BurstDirectCall // TypeDefIndex: 50020
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectProcess_00000952_BurstDirectCall(); // 0x0000000183FAE980-0x0000000183FAE990
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006becf); // 0x00000001869EC8AC-0x00000001869EC9B0
			private static IntPtr GetFunctionPointer(); // 0x00000001869EC9B0-0x00000001869ECA04
			public static void Constructor(); // 0x0000000183FB0000-0x0000000183FB0090
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869ECA04-0x00000001869ECA90
		}
	
		public delegate void _ContinuationStart_00000953_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50021; 0x0000000181546280-0x00000001815462A0
	
		internal static class _ContinuationStart_00000953_BurstDirectCall // TypeDefIndex: 50022
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationStart_00000953_BurstDirectCall(); // 0x0000000183FAE990-0x0000000183FAE9A0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bede); // 0x00000001869E86A8-0x00000001869E87AC
			private static IntPtr GetFunctionPointer(); // 0x00000001869E87AC-0x00000001869E8800
			public static void Constructor(); // 0x0000000183FB0090-0x0000000183FB0120
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869E8800-0x00000001869E8898
		}
	
		public delegate void _ContinuationEnd_00000954_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50023; 0x0000000181546280-0x00000001815462A0
	
		internal static class _ContinuationEnd_00000954_BurstDirectCall // TypeDefIndex: 50024
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationEnd_00000954_BurstDirectCall(); // 0x0000000183FAE9A0-0x0000000183FAE9B0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006beed); // 0x00000001869E8158-0x00000001869E825C
			private static IntPtr GetFunctionPointer(); // 0x00000001869E825C-0x00000001869E82B0
			public static void Constructor(); // 0x0000000183FB0120-0x0000000183FB01B0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869E82B0-0x00000001869E833C
		}
	
		public delegate void _ContinuationProcess_00000955_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50025; 0x0000000181546280-0x00000001815462A0
	
		internal static class _ContinuationProcess_00000955_BurstDirectCall // TypeDefIndex: 50026
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationProcess_00000955_BurstDirectCall(); // 0x0000000183FAE9B0-0x0000000183FAE9C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006befc); // 0x00000001869E8400-0x00000001869E8504
			private static IntPtr GetFunctionPointer(); // 0x00000001869E8504-0x00000001869E8558
			public static void Constructor(); // 0x0000000183FB01B0-0x0000000183FB0240
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869E8558-0x00000001869E85E4
		}
	
		public delegate void _SocialSharingStart_00000956_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50027; 0x0000000181546280-0x00000001815462A0
	
		internal static class _SocialSharingStart_00000956_BurstDirectCall // TypeDefIndex: 50028
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SocialSharingStart_00000956_BurstDirectCall(); // 0x0000000183FAE9C0-0x0000000183FAE9D0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bf0b); // 0x00000001869EDA98-0x00000001869EDB9C
			private static IntPtr GetFunctionPointer(); // 0x00000001869EDB9C-0x00000001869EDBF0
			public static void Constructor(); // 0x0000000183FB0240-0x0000000183FB02D0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EDBF0-0x00000001869EDC88
		}
	
		public delegate void _PowerInteractionStart_00000957_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50029; 0x0000000181546280-0x00000001815462A0
	
		internal static class _PowerInteractionStart_00000957_BurstDirectCall // TypeDefIndex: 50030
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PowerInteractionStart_00000957_BurstDirectCall(); // 0x0000000183FAE9D0-0x0000000183FAE9E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bf1a); // 0x00000001869EC344-0x00000001869EC448
			private static IntPtr GetFunctionPointer(); // 0x00000001869EC448-0x00000001869EC49C
			public static void Constructor(); // 0x0000000183FB02D0-0x0000000183FB0360
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EC49C-0x00000001869EC538
		}
	
		public delegate void _PowerInteractionEnd_00000958_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50031; 0x0000000181546280-0x00000001815462A0
	
		internal static class _PowerInteractionEnd_00000958_BurstDirectCall // TypeDefIndex: 50032
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PowerInteractionEnd_00000958_BurstDirectCall(); // 0x0000000183FAE9E0-0x0000000183FAE9F0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bf29); // 0x00000001869EC090-0x00000001869EC194
			private static IntPtr GetFunctionPointer(); // 0x00000001869EC194-0x00000001869EC1E8
			public static void Constructor(); // 0x0000000183FB0360-0x0000000183FB03F0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EC1E8-0x00000001869EC280
		}
	
		public delegate void _InvalidOverlapPlaceStart_00000959_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50033; 0x0000000181546280-0x00000001815462A0
	
		internal static class _InvalidOverlapPlaceStart_00000959_BurstDirectCall // TypeDefIndex: 50034
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _InvalidOverlapPlaceStart_00000959_BurstDirectCall(); // 0x0000000183FAE9F0-0x0000000183FAEA00
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bf38); // 0x00000001869EADA8-0x00000001869EAEAC
			private static IntPtr GetFunctionPointer(); // 0x00000001869EAEAC-0x00000001869EAF00
			public static void Constructor(); // 0x0000000183FB03F0-0x0000000183FB0480
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EAF00-0x00000001869EAF9C
		}
	
		public delegate void _InvalidOverlapPlaceEnd_0000095A_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 50035; 0x0000000181546280-0x00000001815462A0
	
		internal static class _InvalidOverlapPlaceEnd_0000095A_BurstDirectCall // TypeDefIndex: 50036
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _InvalidOverlapPlaceEnd_0000095A_BurstDirectCall(); // 0x0000000183FAEA00-0x0000000183FAEA10
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006bf47); // 0x00000001869EAAF0-0x00000001869EABF4
			private static IntPtr GetFunctionPointer(); // 0x00000001869EABF4-0x00000001869EAC48
			public static void Constructor(); // 0x0000000183FB0480-0x0000000183FB0510
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869EAC48-0x00000001869EACE4
		}
	
		// Methods
		private void _BPNormalEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869CFDF0-0x00000001869CFEE0
		private void _BPBuildEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869CF89C-0x00000001869CF9F8
		private void _BPBuildCutoffEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869CF514-0x00000001869CF604
		[BurstCompile]
		private static void _BPBuildStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869CFD58-0x00000001869CFDF0
		[BurstCompile]
		private static void _BPBuildProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869CFC1C-0x00000001869CFCB4
		[BurstCompile]
		private static void _BPBuildEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869CFB10-0x00000001869CFBA8
		[BurstCompile]
		private static void _BPBuildCutoffStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869CF83C-0x00000001869CF89C
		[BurstCompile]
		private static void _BPBuildCutoffStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869CF6A4-0x00000001869CF704
		[BurstCompile]
		private static void _BPBuildCutoffStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869CF784-0x00000001869CF7E4
		public void SetSharedExtData(IntPtr data); // 0x00000001830DB280-0x00000001830DB2C0
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869CF1BC-0x00000001869CF23C
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869CE8BC-0x00000001869CF1BC
		[BurstCompile]
		private static void _CutoffStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869D0DD8-0x00000001869D0E38
		[BurstCompile]
		private static void _CutoffStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869D0C04-0x00000001869D0C64
		[BurstCompile]
		private static void _CutoffStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869D0CE4-0x00000001869D0D44
		private static void _BuildStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869D07A8-0x00000001869D0944
		private static void _BuildStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869D0430-0x00000001869D05E8
		[BurstCompile]
		private static void _BuildStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869D0710-0x00000001869D07A8
		[BurstCompile]
		private static void _HighLightStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1750-0x00000001869D17B0
		[BurstCompile]
		private static void _HighLightEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1280-0x00000001869D12E0
		[BurstCompile]
		private static void _HighLightProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1530-0x00000001869D1590
		[BurstCompile]
		private static void _FigureStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1100-0x00000001869D1160
		[BurstCompile]
		private static void _FigureProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1098-0x00000001869D10F8
		[BurstCompile]
		private static void _FigureEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D0EF0-0x00000001869D0F50
		[BurstCompile]
		private static void _HintStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha); // 0x00000001869D1B1C-0x00000001869D1B90
		[BurstCompile]
		private static void _HintEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D189C-0x00000001869D18FC
		[BurstCompile]
		private static void _HintProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D18FC-0x00000001869D195C
		[BurstCompile]
		private static void _OverloadStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2584-0x00000001869D25E4
		[BurstCompile]
		private static void _OverloadEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D208C-0x00000001869D20EC
		[BurstCompile]
		private static void _OverloadProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2438-0x00000001869D2498
		[BurstCompile]
		private static void _OverloadInvalidStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D23D8-0x00000001869D2438
		[BurstCompile]
		private static void _OverloadInvalidEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D219C-0x00000001869D21FC
		[BurstCompile]
		private static void _OverloadInvalidProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D21FC-0x00000001869D225C
		private static void _Repair0Start(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2D88-0x00000001869D2E50
		private static void _Repair0End(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2B68-0x00000001869D2C40
		[BurstCompile]
		private static void _Repair0Process(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869D2D08-0x00000001869D2D88
		[BurstCompile]
		private static void _Repair1Start(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D30F8-0x00000001869D3158
		[BurstCompile]
		private static void _Repair1End(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2EF0-0x00000001869D2F50
		[BurstCompile]
		private static void _Repair1Process(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869D2FE0-0x00000001869D3060
		private static void _BlueprintProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // 0x00000001869CD73C-0x00000001869CDBAC
		[BurstCompile]
		private static void _BlueprintProcessInternal(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D0320-0x00000001869D0380
		[BurstCompile]
		private static void _BlueprintEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // 0x00000001869CFFD0-0x00000001869D0044
		[BurstCompile]
		private static void _BlueprintStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D03D0-0x00000001869D0430
		[BurstCompile]
		private static void _PreSelectStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2B08-0x00000001869D2B68
		[BurstCompile]
		private static void _PreSelectEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2908-0x00000001869D2968
		[BurstCompile]
		private static void _PreSelectProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2968-0x00000001869D29C8
		[BurstCompile]
		private static void _ContinuationStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D0AF0-0x00000001869D0B50
		[BurstCompile]
		private static void _ContinuationEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D0944-0x00000001869D09A4
		[BurstCompile]
		private static void _ContinuationProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D09A4-0x00000001869D0A04
		[BurstCompile]
		private static void _SocialSharingStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D327C-0x00000001869D32DC
		[BurstCompile]
		private static void _PowerInteractionStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2834-0x00000001869D2894
		[BurstCompile]
		private static void _PowerInteractionEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2678-0x00000001869D26D8
		[BurstCompile]
		private static void _InvalidOverlapPlaceStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1F7C-0x00000001869D1FDC
		[BurstCompile]
		private static void _InvalidOverlapPlaceEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1DEC-0x00000001869D1E4C
		public static unsafe void ResetMaterial(HGFactoryRendererBinderComponent* rendererBinder, ref SharedDataContainer.SharedExtData extData, bool resetRenderPass = true /* Metadata: 0x0232EC2D */, bool resetAdditiveMat = true /* Metadata: 0x0232EC2E */); // 0x00000001869CF2CC-0x00000001869CF438
		public static void ResetMaterial(ref HGFactoryRendererBinderComponent rendererBinder, ref SharedDataContainer.SharedExtData extData, bool resetRenderPass = true /* Metadata: 0x0232EC2F */, bool resetAdditiveMat = true /* Metadata: 0x0232EC30 */); // 0x00000001869CF23C-0x00000001869CF2CC
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x00000001830DB240-0x00000001830DB280
		[IDTag(0)]
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC31 */); // 0x00000001869CF438-0x00000001869CF514
		[IDTag(1)]
		public JobHandle ScheduleDefer(JobHandle jobHandleDep0, JobHandle jobHandleDep1, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC32 */); // 0x00000001830DB000-0x00000001830DB0F0
		[BurstCompile]
		public static void _BPBuildStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869CFCB4-0x00000001869CFD58
		[BurstCompile]
		public static void _BPBuildProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869CFBA8-0x00000001869CFC1C
		[BurstCompile]
		public static void _BPBuildEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869CF9F8-0x00000001869CFB10
		[BurstCompile]
		public static void _BPBuildCutoffStateStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869CF7E4-0x00000001869CF83C
		[BurstCompile]
		public static void _BPBuildCutoffStateEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869CF604-0x00000001869CF6A4
		[BurstCompile]
		public static void _BPBuildCutoffStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869CF704-0x00000001869CF784
		[BurstCompile]
		public static void _CutoffStateStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869D0D44-0x00000001869D0DD8
		[BurstCompile]
		public static void _CutoffStateEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869D0B50-0x00000001869D0C04
		[BurstCompile]
		public static void _CutoffStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // 0x00000001869D0C64-0x00000001869D0CE4
		[BurstCompile]
		public static void _BuildStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // 0x00000001869D05E8-0x00000001869D0710
		[BurstCompile]
		public static void _HighLightStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1590-0x00000001869D1750
		[BurstCompile]
		public static void _HighLightEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1160-0x00000001869D1280
		[BurstCompile]
		public static void _HighLightProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D12E0-0x00000001869D1530
		[BurstCompile]
		public static void _FigureStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D10F8-0x00000001869D1100
		[BurstCompile]
		public static void _FigureProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D0F50-0x00000001869D1098
		[BurstCompile]
		public static void _FigureEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D0E38-0x00000001869D0EF0
		[BurstCompile]
		public static void _HintStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha); // 0x00000001869D195C-0x00000001869D1B1C
		[BurstCompile]
		public static void _HintEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D17B0-0x00000001869D189C
		[BurstCompile]
		public static void _HintProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001841E1670-0x00000001841E1680
		[BurstCompile]
		public static void _OverloadStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2498-0x00000001869D2584
		[BurstCompile]
		public static void _OverloadEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1FDC-0x00000001869D208C
		[BurstCompile]
		public static void _OverloadProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001841E1670-0x00000001841E1680
		[BurstCompile]
		public static void _OverloadInvalidStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D225C-0x00000001869D23D8
		[BurstCompile]
		public static void _OverloadInvalidEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D20EC-0x00000001869D219C
		[BurstCompile]
		public static void _OverloadInvalidProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001841E1670-0x00000001841E1680
		[BurstCompile]
		public static void _Repair0Process_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869D2C40-0x00000001869D2D08
		[BurstCompile]
		public static void _Repair1Start_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D3060-0x00000001869D30F8
		[BurstCompile]
		public static void _Repair1End_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2E50-0x00000001869D2EF0
		[BurstCompile]
		public static void _Repair1Process_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // 0x00000001869D2F50-0x00000001869D2FE0
		[BurstCompile]
		public static void _BlueprintProcessInternal_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D0044-0x00000001869D0320
		[BurstCompile]
		public static void _BlueprintEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // 0x00000001869CFEE0-0x00000001869CFFD0
		[BurstCompile]
		public static void _BlueprintStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D0380-0x00000001869D03D0
		[BurstCompile]
		public static void _PreSelectStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D29C8-0x00000001869D2B08
		[BurstCompile]
		public static void _PreSelectEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D2894-0x00000001869D2908
		[BurstCompile]
		public static void _PreSelectProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001841E1670-0x00000001841E1680
		[BurstCompile]
		public static void _ContinuationStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D0A04-0x00000001869D0AF0
		[BurstCompile]
		public static void _ContinuationEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001841E1670-0x00000001841E1680
		[BurstCompile]
		public static void _ContinuationProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001841E1670-0x00000001841E1680
		[BurstCompile]
		public static void _SocialSharingStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D3158-0x00000001869D327C
		[BurstCompile]
		public static void _PowerInteractionStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D26D8-0x00000001869D2834
		[BurstCompile]
		public static void _PowerInteractionEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D25E4-0x00000001869D2678
		[BurstCompile]
		public static void _InvalidOverlapPlaceStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1E4C-0x00000001869D1F7C
		[BurstCompile]
		public static void _InvalidOverlapPlaceEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // 0x00000001869D1B90-0x00000001869D1DEC
	}

	public static class AudioJobs // TypeDefIndex: 50045
	{
		// Nested types
		public struct FAggregateEmitterTempData // TypeDefIndex: 50038
		{
			// Fields
			public float3 sumPos; // 0x00
			public float sumWeight; // 0x0C
			public int count; // 0x10
		}
	
		public struct FPipeEmitterData // TypeDefIndex: 50039
		{
			// Fields
			public float3 posData; // 0x00
			public float2 extraData; // 0x0C
			public float sumWeight; // 0x14
			public int count; // 0x18
		}
	
		public struct FPipeEmitterTempData // TypeDefIndex: 50040
		{
			// Fields
			public FPipeEmitterData waterPipeData; // 0x00
			public FPipeEmitterData gasPipeData; // 0x1C
		}
	
		public struct FGroupEmitterTempData // TypeDefIndex: 50041
		{
			// Fields
			public float3x3 sumPos; // 0x00
			public float3 sumWeight; // 0x24
			public float3 count; // 0x30
			public int inMainRegionActiveCount; // 0x3C
		}
	
		[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
		public struct AudioDistanceAndCullingJob : IJobParallelFor // TypeDefIndex: 50042
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
			public void Execute(int index); // 0x00000001869DC320-0x00000001869DC540
		}
	
		[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
		public struct AudioGroupEmitterJob : IJobParallelFor // TypeDefIndex: 50043
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
			public void Execute(int index); // 0x00000001869DC540-0x00000001869DCB80
			public void SetSharedExtData(IntPtr data); // 0x0000000183FA3490-0x0000000183FA34D0
		}
	
		[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
		public struct WaterPipeEmitterJob : IJobParallelFor // TypeDefIndex: 50044
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
			public void Execute(int index); // 0x00000001869E5C1C-0x00000001869E5DE4
			private void _DoCalculate(ref FPipeEmitterTempData tempData, ref PipeFragment unit); // 0x00000001869E6014-0x00000001869E609C
			private void _DoCalculatePipe(ref FPipeEmitterData emitterData, ref PipeFragment unit); // 0x00000001869E5DE4-0x00000001869E6014
			public void SetGlobalEnv(ref GlobalEnv env); // 0x00000001838AB0C0-0x00000001838AB100
		}
	
		// Methods
		private static void _EntityIdx(int groupIdx, EntityQueryV2.BlockRange blockRange, GroupType group, out int startEntityIdx, out int endEntityIdx); // 0x00000001869DBF54-0x00000001869DC320
		[Conditional("BEYOND_DEBUG")]
		private static void _SetDebugGizmosType(ref AudioFragment audioFrag, AudioDebugGizmosType t); // 0x00000001841E1670-0x00000001841E1680
	}

	[BurstCompile]
	public struct BatchArrowJob : IJob // TypeDefIndex: 50046
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
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x548
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x550
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x558
		public float4 normalColor; // 0x560
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x570
	
		// Methods
		private void _ExecutePort(int index, EntityQueryV2.QueryResult qr); // 0x00000001869DD91C-0x00000001869DE088
		private void _ExecutePreview(int index, EntityQueryV2.QueryResult qr); // 0x00000001869DE088-0x00000001869DE668
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869DCC38-0x00000001869DCCFC
		private void _BatchPortArrow(ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, bool pipeValid, float mapHeightValue, bool inOut, bool preview = false /* Metadata: 0x0232EC33 */, bool inBuildMode = false /* Metadata: 0x0232EC34 */, bool inMainRegion = true /* Metadata: 0x0232EC35 */, bool buildingBelt = true /* Metadata: 0x0232EC36 */, bool buildingPipe = true /* Metadata: 0x0232EC37 */, bool blueprintSelectedUnit = false /* Metadata: 0x0232EC38 */, bool inputDisabled = false /* Metadata: 0x0232EC39 */, bool outputDisabled = false /* Metadata: 0x0232EC3A */, bool inputFluidDisabled = false /* Metadata: 0x0232EC3B */, bool outputFluidDisabled = false /* Metadata: 0x0232EC3C */); // 0x00000001869DCCFC-0x00000001869DD91C
		public void SetSharedExtData(IntPtr data); // 0x00000001840B7160-0x00000001840B71D0
		[IDTag(1)]
		public void Execute(); // 0x00000001869DCB80-0x00000001869DCC38
	}

	[BurstCompile]
	public struct BatchInsideConveyorJob : IJob // TypeDefIndex: 50047
	{
		// Fields
		public EntityQueryV2.QueryResult normalQr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public GlobalEnv globalEnv; // 0x20
		public UnsafeList<float4x4> conveyorInsideMatrices; // 0x4F8
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x500
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x508
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869DE668-0x00000001869DE6E0
		private void _CollectInsideConveyor(int index, EntityQueryV2.QueryResult qr); // 0x00000001869DEB5C-0x00000001869DF0A0
		private void _BatchPortInside(uint nodeId, float3 pos, quaternion rot, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, ref ComplexPortFragment ports, bool bInOut, float mapHeightValue, bool blueprintSelectedUnit); // 0x00000001869DE75C-0x00000001869DEB5C
		public void SetSharedExtData(IntPtr data); // 0x00000001840B70F0-0x00000001840B7160
		[IDTag(1)]
		public void Execute(); // 0x00000001869DE6E0-0x00000001869DE75C
	}

	[BurstCompile]
	public struct BatchNormalArrowJob : IJob // TypeDefIndex: 50048
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
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x528
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x530
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x538
		public float4 normalColor; // 0x540
		public UnsafeParallelHashMap<int, bool> arrowPlacedDic; // 0x550
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x560
		private int m_arrowPlacedCount; // 0x564
	
		// Methods
		private void _ExecutePort(int index, EntityQueryV2.QueryResult qr); // 0x00000001869DFE28-0x00000001869E0590
		private void _BatchPortArrow(uint nodeId, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, bool pipeValid, float mapHeightValue, bool inOut, bool inBuildMode = false /* Metadata: 0x0232EC3D */, bool inMainRegion = true /* Metadata: 0x0232EC3E */, bool buildingBelt = true /* Metadata: 0x0232EC3F */, bool buildingPipe = true /* Metadata: 0x0232EC40 */, bool inputDisabled = false /* Metadata: 0x0232EC41 */, bool outputDisabled = false /* Metadata: 0x0232EC42 */, bool inputFluidDisabled = false /* Metadata: 0x0232EC43 */, bool outputFluidDisabled = false /* Metadata: 0x0232EC44 */); // 0x00000001869DF1FC-0x00000001869DFE28
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869DF128-0x00000001869DF1A0
		[IDTag(1)]
		public void Execute(); // 0x00000001869DF0A0-0x00000001869DF128
		public void SetSharedExtData(IntPtr data); // 0x00000001869DF1A0-0x00000001869DF1FC
	}

	[BurstCompile]
	public struct BatchPreviewArrowJob : IJob // TypeDefIndex: 50049
	{
		// Fields
		[NoAlias]
		public EntityManager em; // 0x00
		public EntityQueryV2.QueryResult previewQr; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public GlobalEnv globalEnv; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x508
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x510
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x518
		public float4 normalColor; // 0x520
		public UnsafeParallelHashMap<int, bool> arrowPlacedDic; // 0x530
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x540
	
		// Methods
		public void Execute(); // 0x00000001869E0590-0x00000001869E062C
		private void _ExecutePreview(int index, EntityQueryV2.QueryResult qr); // 0x00000001869E1158-0x00000001869E16E4
		private void _BatchPortArrow(ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, bool pipeValid, float mapHeightValue, bool inOut, bool inBuildMode = false /* Metadata: 0x0232EC45 */, bool inMainRegion = true /* Metadata: 0x0232EC46 */); // 0x00000001869E0688-0x00000001869E1158
		public void SetSharedExtData(IntPtr data); // 0x00000001869E062C-0x00000001869E0688
	}

	[BurstCompile]
	public struct BufferSwapJob : IJob // TypeDefIndex: 50050
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
		public void Execute(); // 0x00000001869E16E4-0x00000001869E179C
	}

	[BurstCompile]
	public struct BuildingEnvRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 50051
	{
		// Fields
		[NoAlias]
		public EntityManager em; // 0x00
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x18
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869E181C-0x00000001869E1E14
		private void _RenderEnv(Entity rEntity, ref UnitEnvironmentRelation receiver); // 0x00000001869E1E14-0x00000001869E1F8C
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x0000000183EE38F0-0x0000000183EE3930
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC47 */); // 0x0000000183EE37D0-0x0000000183EE38B0
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869E179C-0x00000001869E181C
		public void SetSharedExtData(IntPtr data); // 0x0000000183EE38B0-0x0000000183EE38F0
	}

	[BurstCompile]
	public struct BuildingLiquidRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 50052
	{
		// Fields
		[NoAlias]
		public EntityManager em; // 0x00
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x18
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869E1F8C-0x00000001869E25C8
		private void _ApplyLiquidPerDraw(Entity rEntity, ValueTuple<int, uint> liquidData); // 0x00000001869E2648-0x00000001869E27B4
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869E25C8-0x00000001869E2648
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x0000000183EE3490-0x0000000183EE34D0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC48 */); // 0x0000000183EE3370-0x0000000183EE3450
		public void SetSharedExtData(IntPtr data); // 0x0000000183EE3450-0x0000000183EE3490
	}

	[BurstCompile]
	public struct BuildingStatePosCollectJob : IJob // TypeDefIndex: 50053
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
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869E27B4-0x00000001869E2A0C
		private void _Collect(ref UnitFragment unit, ref UnitTransFragment trans, ref UnitConfigFragment config, ref UnitStatusFragment status, ref SharedDataFragment sharedData); // 0x00000001869E2B14-0x00000001869E30B8
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869E2A0C-0x00000001869E2A98
		[IDTag(2)]
		public void Execute(); // 0x00000001869E2A98-0x00000001869E2B14
		public void SetSharedExtData(IntPtr data); // 0x0000000183341100-0x0000000183341160
	}

	[BurstCompile]
	public struct BuildingStateRendererJob : IJobParallelFor // TypeDefIndex: 50054
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<float4x4> statePosList; // 0x20
	
		// Methods
		public void Execute(int index); // 0x00000001869E30B8-0x00000001869E3268
	}

	[BurstCompile]
	public struct CargoCollectJob : IJob // TypeDefIndex: 50055
	{
		// Fields
		public float offsetY; // 0x00
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* rendererList; // 0x28
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* env; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe ConveyorExtContainer.ConveyorExt* conveyorExtData; // 0x38
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x40
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869E3268-0x00000001869E343C
		private unsafe void _Collect(CargoFragment* cargoFrag, ref SharedDataContainer.SharedExtData extData, ref ConveyorExtContainer.ConveyorExt conveyorExt); // 0x00000001869E34E8-0x00000001869E3718
		[IDTag(1)]
		public void Execute(); // 0x00000001869E343C-0x00000001869E34E8
		public void SetGlobalEnvRef(ref GlobalEnv envRef); // 0x00000001838AB7D0-0x00000001838AB830
		public void SetConveyorExtData(IntPtr data); // 0x00000001838AB830-0x00000001838AB890
		public void SetSharedExtData(IntPtr data); // 0x00000001838AB890-0x00000001838AB8F0
	}

	[BurstCompile]
	public struct CargoPredictJob : IJobParallelFor, IJobParallelForDefer // TypeDefIndex: 50056
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
		public void Execute(int index); // 0x00000001869E3718-0x00000001869E3B18
		public void SetConveyorExtData(IntPtr data); // 0x00000001838ABCC0-0x00000001838ABD20
		public void SetSharedExtData(IntPtr data); // 0x00000001838ABD20-0x00000001838ABD80
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x00000001838ABD80-0x00000001838ABDE0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 4 /* Metadata: 0x0232EC49 */); // 0x00000001838AC240-0x00000001838AC410
	}

	[BurstCompile]
	public struct CargoPredictQueryJob : IJob // TypeDefIndex: 50057
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute(); // 0x00000001869E3B18-0x00000001869E3BF4
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x0232EC4A */); // 0x00000001838ABB80-0x00000001838ABC20
	}

	[BurstCompile]
	public struct CargoRenderJob : IJobParallelForBatch // TypeDefIndex: 50058
	{
		// Fields
		public PreResolvedComponentAccess<HGFactoryRendererBinderComponent> binderAccess; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x18
		[NativeDisableUnsafePtrRestriction]
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* rendererList; // 0x28
	
		// Methods
		public void Execute(int startIndex, int count); // 0x00000001869E3BF4-0x00000001869E3DA8
		public void SetRendererList(IntPtr data); // 0x0000000183D1F6B0-0x0000000183D1F6F0
		public void ResolveAccess([IsReadOnly] in EntityManager em, int count); // 0x0000000183D1F6F0-0x0000000183D1F7D0
	}

	[BurstCompile]
	public struct CargoRenderQueryJob : IJob // TypeDefIndex: 50059
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute(); // 0x00000001869E3DA8-0x00000001869E3E64
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x0232EC4B */); // 0x00000001869E3E64-0x00000001869E3EE0
	}

	[BurstCompile]
	public struct ClearRendererVisibleDirtyJob : IJob // TypeDefIndex: 50060
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x00
		public int count; // 0x08
	
		// Methods
		public void Execute(); // 0x00000001869E3EE0-0x00000001869E3F7C
		public void SetSharedExtData(IntPtr data); // 0x00000001841FB6B0-0x00000001841FB6F0
	}

	[BurstCompile]
	public struct ConveyorCollectJob : IJob // TypeDefIndex: 50061
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
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869E3F7C-0x00000001869E4134
		private void _Collect(ref ConveyorFragment conveyor, ref SharedDataFragment sharedDataFrag, bool preview, bool valid); // 0x00000001869E423C-0x00000001869E4620
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869E4134-0x00000001869E41C0
		[IDTag(2)]
		public void Execute(); // 0x00000001869E41C0-0x00000001869E423C
		public void SetSharedExtData(IntPtr data); // 0x00000001834CCFE0-0x00000001834CD040
	}

	[BurstCompile]
	public struct ConveyorFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 50062
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
		public void Execute(int startIndex, int count); // 0x00000001869E4620-0x00000001869E47FC
		private void _UpdateCachedConveyor(Entity cachedEntity, uint sharedDataHandle, float adjustGroundHeight, float3 pos, float3 rot, float conveyorIdx, float conveyorLength, float speed, bool preview, float offsetY, bool valid = true /* Metadata: 0x0232EC4C */, bool highlight = false /* Metadata: 0x0232EC4D */); // 0x00000001869E4914-0x00000001869E4B5C
		public void SetSharedExtData(IntPtr data); // 0x00000001869E48B8-0x00000001869E4914
		public void ResolveAccess([IsReadOnly] in EntityManager em, int count); // 0x00000001869E47FC-0x00000001869E48B8
	}

	[BurstCompile]
	public struct ConveyorInsideRenderJob : IJobParallelFor // TypeDefIndex: 50063
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
		public void Execute(int index); // 0x00000001869E4B5C-0x00000001869E4DE0
	}

	[BurstCompile]
	public struct ConveyorPreviewCollectJob : IJob // TypeDefIndex: 50064
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
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869E4DE0-0x00000001869E4FB4
		private void _Collect(ref ConveyorPreviewRendererFragment conveyor, ref SharedDataFragment sharedData, bool preview, bool valid); // 0x00000001869E5030-0x00000001869E5250
		[IDTag(1)]
		public void Execute(); // 0x00000001869E4FB4-0x00000001869E5030
		public void SetSharedExtData(IntPtr data); // 0x00000001834CCF80-0x00000001834CCFE0
	}

	[BurstCompile]
	public struct ConveyorRendererJob : IJobParallelForBatch // TypeDefIndex: 50065
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
	
		// Methods
		public void Execute(int startIndex, int count); // 0x00000001869E5250-0x00000001869E5574
		private void _HideConveyorOutOfDistance(Entity cachedEntity, uint sharedDataHandle); // 0x00000001869E5574-0x00000001869E5658
		private void _UpdateCachedConveyor(Entity cachedEntity, float adjustGroundHeight, uint sharedDataHandle, float3 pos, float3 rot, float conveyorIdx, float conveyorLength, float speed, bool preview, BlueprintState.EffectType blueprintRenderType, float offsetY, uint lightMode, bool valid = true /* Metadata: 0x0232EC4E */, bool highlight = false /* Metadata: 0x0232EC4F */); // 0x00000001869E5658-0x00000001869E5C1C
		public void SetSharedExtData(IntPtr data); // 0x0000000183D235C0-0x0000000183D23600
		public void ResolveAccess([IsReadOnly] in EntityManager em, int count); // 0x0000000183D21640-0x0000000183D216E0
	}

	[BurstCompile]
	public struct EnvGeneratorCollectJob : IJob // TypeDefIndex: 50066
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		public float offsetY; // 0x20
		public UnsafeList<EnvGeneratorRendererInfo> posList; // 0x28
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x30
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869EE5AC-0x00000001869EE7E0
		private void _Collect(ref UnitFragment unit, ref UnitTransFragment trans, ref UnitEnvironmentRelation envGenerator, ref SharedDataFragment sharedData); // 0x00000001869EE918-0x00000001869EEC50
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869EE88C-0x00000001869EE918
		[IDTag(2)]
		public void Execute(); // 0x00000001869EE7E0-0x00000001869EE88C
		public void SetSharedExtData(IntPtr data); // 0x0000000183D684B0-0x0000000183D68510
	}

	[BurstCompile]
	public struct EnvGeneratorRenderJob : IJobParallelFor // TypeDefIndex: 50067
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<EnvGeneratorRendererInfo> posList; // 0x20
	
		// Methods
		public void Execute(int index); // 0x00000001869EEC50-0x00000001869EEE20
	}

	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public struct InteractFacCollectJob : IJob // TypeDefIndex: 50071
	{
		// Fields
		public float3 targetPosition; // 0x00
		public float3 targetForward; // 0x0C
		public float maxAngle; // 0x18
		public float maxDist; // 0x1C
		public float radiusExpand; // 0x20
		public const float ROLE_HIGH_ADDED_VALUE = 2f; // Metadata: 0x0232EC50
		public const float PIPE_HEIGHT_RANGE = 4f; // Metadata: 0x0232EC54
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
		public struct BuildingInfoWrap // TypeDefIndex: 50068
		{
			// Fields
			public BuildingInfo buildingInfo; // 0x00
			[CompilerGenerated]
			private UnitConfigFragment _unitConfig_k__BackingField; // 0x54
	
			// Properties
			public UnitConfigFragment unitConfig { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8CF60-0x0000000184D8CFB0 0x0000000184D8CFB0-0x0000000184D8D000
	
			// Methods
			public unsafe void SwapTo(BuildingInfoWrap* other); // 0x00000001869EDFA0-0x00000001869EDFE0
		}
	
		public struct BuildingInfo // TypeDefIndex: 50069
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
			public string templateName { get; set; } // 0x000000018449C0F0-0x000000018449C150 0x00000001869EE288-0x00000001869EE31C
	
			// Methods
			public override string ToString(); // 0x00000001869EE0A8-0x00000001869EE208
			public void SetData([IsReadOnly] in BuildingInfo info); // 0x00000001869EDFE0-0x00000001869EE0A8
			public bool IsPending(); // 0x0000000183D46FF0-0x0000000183D47020
			public string __iFixBaseProxy_ToString(); // 0x00000001869EE208-0x00000001869EE288
		}
	
		public struct LogisticInfo // TypeDefIndex: 50070
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
			public bool IsPending(); // 0x00000001869F17B8-0x00000001869F1808
			public unsafe void SwapTo(LogisticInfo* other); // 0x00000001869F1808-0x00000001869F1850
		}
	
		// Constructors
		static InteractFacCollectJob(); // 0x00000001848F4F30-0x00000001848F5260
	
		// Methods
		private void _SwapBuffer(); // 0x00000001869F10F0-0x00000001869F117C
		public void Execute(); // 0x00000001869EF250-0x00000001869EF2E8
		private void _ExecuteBuilding(); // 0x00000001869EF748-0x00000001869F0894
		private void _ExecuteConveyor(); // 0x00000001869F0894-0x00000001869F0B8C
		private void _ExecutePipe(); // 0x00000001869F0B8C-0x00000001869F0EB8
		private bool _CheckDist(float3 pos, float distSqThreshold, ref int minSearchIndex); // 0x00000001869EF2E8-0x00000001869EF748
		private static float3 _SnapDirectionToAxis(float3 direction); // 0x00000001869F0EB8-0x00000001869F10F0
		public void SetSharedExtData(IntPtr data); // 0x00000001833434C0-0x0000000183343530
	}

	[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
	public struct LocalToWorldJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 50072
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
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F11FC-0x00000001869F1354
		public static void TransTRS(ref LocalToWorld localToWorld, IntPtr hierarchyIntPtr, int frameCount = -1 /* Metadata: 0x0232EC58 */); // 0x00000001837B1BB0-0x00000001837B1C40
		public static unsafe void TransTRS(ref LocalToWorld localToWorld, EntityHierarchyContainer.EntityTransformData* hierarchyPtr, int frameCount = -1 /* Metadata: 0x0232EC59 */); // 0x00000001837B1C40-0x00000001837B1E90
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F117C-0x00000001869F11FC
		public void SetHierarchyData(IntPtr data); // 0x00000001841FB670-0x00000001841FB6B0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x00000001841FB630-0x00000001841FB670
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC5A */); // 0x0000000184045E90-0x0000000184045F70
	}

	[BurstCompile]
	public struct LocalToWorldQueryJob : IJob // TypeDefIndex: 50073
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute(); // 0x00000001869F1354-0x00000001869F1430
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x0232EC5B */); // 0x0000000184126160-0x00000001841261D0
	}

	[BurstCompile]
	public struct LogisticEffectJob : IJobParallelFor // TypeDefIndex: 50074
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public long deltaTime; // 0x20
	
		// Methods
		public void Execute(int index); // 0x00000001869F1430-0x00000001869F17B8
	}

	[BurstCompile]
	public struct LogisticsFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 50075
	{
		// Fields
		public EntityManager em; // 0x00
		public float offsetY; // 0x10
		public UnsafeList<Matrix4x4> dataMatrices; // 0x18
		public NativeArray<Entity> rendererEntities; // 0x28
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F18DC-0x00000001869F1B50
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F1850-0x00000001869F18DC
	}

	[BurstCompile]
	public struct LogisticsHideRendererJob : IJobParallelForBatch // TypeDefIndex: 50076
	{
		// Fields
		public bool hidden; // 0x00
		public EntityQueryV2.QueryResult qr; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x28
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F1B50-0x00000001869F1CD8
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F1CD8-0x00000001869F1D64
		public void SetSharedExtData(IntPtr data); // 0x00000001869F1D64-0x00000001869F1DC0
	}

	[BurstCompile]
	public struct LookAtJob : IJobParallelFor, IJobParallelForDefer // TypeDefIndex: 50077
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityHierarchyContainer.EntityTransformData* hierarchyDataPtr; // 0x08
	
		// Methods
		public void Execute(int index); // 0x00000001869F1DC0-0x00000001869F25EC
		public void SetHierarchyData(IntPtr data); // 0x00000001830D3A50-0x00000001830D3AB0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x00000001830D3AB0-0x00000001830D3B10
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC5C */); // 0x00000001830D4380-0x00000001830D4550
	}

	[BurstCompile]
	public struct LookAtQueryJob : IJob // TypeDefIndex: 50078
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute(); // 0x00000001869F25EC-0x00000001869F26A8
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x0232EC5D */); // 0x00000001830D37B0-0x00000001830D3850
	}

	[BurstCompile]
	public struct OutputCollectJob : IJob // TypeDefIndex: 50079
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		public float offsetY; // 0x20
		public UnsafeList<OutputRendererInfo> posList; // 0x28
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x30
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F27E0-0x00000001869F2A54
		private void _Collect(ref UnitFragment unit, ref UnitTransFragment trans, ref UnitConfigFragment config, ref OutputFragment output, ref SharedDataFragment sharedData); // 0x00000001869F2A54-0x00000001869F2E80
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F26A8-0x00000001869F2734
		[IDTag(2)]
		public void Execute(); // 0x00000001869F2734-0x00000001869F27E0
		public void SetSharedExtData(IntPtr data); // 0x0000000183D68190-0x0000000183D681F0
	}

	[BurstCompile]
	public struct OutputRenderJob : IJobParallelFor // TypeDefIndex: 50080
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<OutputRendererInfo> posList; // 0x20
	
		// Methods
		public void Execute(int index); // 0x00000001869F2E80-0x00000001869F323C
	}

	[BurstCompile]
	public struct PedestalFlashJob : IJobParallelForBatch // TypeDefIndex: 50081
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public long time; // 0x20
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedExtDataPtr; // 0x28
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F32BC-0x00000001869F3530
		private float4 _Flash(ref PedestalLightFlashFragment flashConfig, float deltaTime); // 0x00000001869F3530-0x00000001869F3654
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F323C-0x00000001869F32BC
		public void SetSharedExtData(IntPtr data); // 0x000000018437F200-0x000000018437F240
	}

	[BurstCompile]
	public struct PipeCollectJob : IJob // TypeDefIndex: 50082
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
		public UnsafeList<float4x4> comPosMatrices; // 0x88
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x90
		public int sharedDataSize; // 0x98
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* envPtr; // 0xA0
	
		// Properties
		public int pipeCount { get; } // 0x00000001869F5050-0x00000001869F50B8 
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F3D08-0x00000001869F3E1C
		private void _ExecutePipe(EntityQueryV2.BlockRange blockRange, NativeList<GroupType> groups); // 0x00000001869F4AD0-0x00000001869F4DCC
		private void _ExecutePreviewPipe(EntityQueryV2.BlockRange blockRange, NativeList<GroupType> groups); // 0x00000001869F4DCC-0x00000001869F5050
		private void _CollectPipe(int pipeLength, uint memoryStartOffset, uint memoryEndOffset, int subItemType, bool isGas, float waterThickness, float waterFlowDeltaTime, float firstIndex, float waterDirection, float pipeHeight, uint sharedDataHandle, bool isPreview = false /* Metadata: 0x0232EC5E */, bool valid = true /* Metadata: 0x0232EC5F */, bool highLight = false /* Metadata: 0x0232EC60 */); // 0x00000001869F439C-0x00000001869F4868
		private void _CollectPipeCom([IsReadOnly] in PipeFragment pipe, uint sharedDataHandle); // 0x00000001869F3EA8-0x00000001869F439C
		private void _CollectTrack(int pipeLength, uint memoryStartOffset, uint memoryEndOffset, float pipeHeight, float gridPathHeightStart, float gridPathHeightEnd, uint sharedDataHandle, bool pipeValid); // 0x00000001869F4868-0x00000001869F4AD0
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F3E1C-0x00000001869F3EA8
		[IDTag(2)]
		public void Execute(); // 0x00000001869F3C8C-0x00000001869F3D08
		public void SetGlobalEnvRef(ref GlobalEnv envRef); // 0x0000000183341030-0x00000001833410A0
		public void SetSharedExtData(IntPtr data, int size); // 0x0000000181528510-0x0000000181528910
	}

	[BurstCompile]
	public struct PipeComRendererJob : IJobParallelForBatch // TypeDefIndex: 50083
	{
		// Fields
		public EntityManager em; // 0x00
		public UnsafeList<float4x4> comPosArr; // 0x10
		public NativeArray<Entity> rendererEntities; // 0x20
		public bool useDistanceFilter; // 0x30
		public float2 distanceFilterCenterPos; // 0x34
		public float distanceThresholdSq; // 0x3C
	
		// Methods
		public void Execute(int startIndex, int count); // 0x00000001869F50B8-0x00000001869F5384
	}

	[BurstCompile]
	public struct PipeFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 50084
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
		public void Execute(int startIndex, int count); // 0x00000001869F5384-0x00000001869F563C
		private void _UpdateCachedPipe(Entity cachedEntity, byte protoType, float3 pos, float3 rot, float indexInPipe, float pipeLength, float waterDirection, float waterThickness, short subItemType, bool isPreview = false /* Metadata: 0x0232EC61 */, bool valid = true /* Metadata: 0x0232EC62 */, bool highLight = false /* Metadata: 0x0232EC63 */); // 0x00000001869F56F8-0x00000001869F59E4
		public void ResolveAccess([IsReadOnly] in EntityManager em, int count); // 0x00000001869F563C-0x00000001869F56F8
	}

	[BurstCompile]
	public struct PipeLogisticsPosCollectJob : IJob // TypeDefIndex: 50085
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x20
		public UnsafeList<Matrix4x4> posList; // 0x28
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F5AEC-0x00000001869F5E88
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F5A60-0x00000001869F5AEC
		public void SetSharedExtData(IntPtr data); // 0x00000001869F5E88-0x00000001869F5EE4
		[IDTag(2)]
		public void Execute(); // 0x00000001869F59E4-0x00000001869F5A60
	}

	[BurstCompile]
	public struct PipeRendererJob : IJobParallelForBatch // TypeDefIndex: 50086
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
		public void Execute(int startIndex, int count); // 0x00000001869F5EE4-0x00000001869F6268
		private void _HidePipeOutOfDistance(Entity cachedEntity, uint sharedDataHandle); // 0x00000001869F6268-0x00000001869F634C
		private void _UpdateCachedPipe(Entity cachedEntity, byte protoType, float3 pos, float3 rot, float bend, uint sharedDataHandle, int indexInPipe, int pipeLength, float waterDirection, float firstIndex, float waterThickness, float subItemType, BlueprintState.EffectType blueprintRenderType, float waterFlowDeltaTime, uint lightMode, bool isPreview = false /* Metadata: 0x0232EC64 */, bool valid = true /* Metadata: 0x0232EC65 */, bool highLight = false /* Metadata: 0x0232EC66 */); // 0x00000001869F634C-0x00000001869F6C40
		public void SetSharedExtData(IntPtr data, int size); // 0x0000000181528910-0x0000000181528D10
		public void ResolveAccess([IsReadOnly] in EntityManager em, [IsReadOnly] in EntityManager rEm, int count); // 0x000000018345D570-0x000000018345D780
	}

	[BurstCompile]
	public struct PipeTrackRendererJob : IJob // TypeDefIndex: 50087
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
		public void Execute(); // 0x00000001869F6C40-0x00000001869F7064
		private void _UpdateCachedTrack(Entity cachedEntity, float3 pos, float3 rot, float indexInPipe, float pipeLength, float pipeHeight, float gridPathHeight, float gridPathHeightEnd, bool valid); // 0x00000001869F7064-0x00000001869F7408
	}

	[BurstCompile]
	public struct PipeWaterThicknessQueryJob : IJob // TypeDefIndex: 50088
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute(); // 0x00000001869F7408-0x00000001869F74C4
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x0232EC67 */); // 0x00000001838ABC20-0x00000001838ABCC0
	}

	[BurstCompile]
	public struct PipeWaterThicknessRiseJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 50089
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		public float deltaTime; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* globalEnv; // 0x10
	
		// Methods
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F74C4-0x00000001869F7544
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F7544-0x00000001869F77CC
		public void SetGlobalEnv(ref GlobalEnv env); // 0x00000001838ABDE0-0x00000001838ABE40
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x00000001838ABE40-0x00000001838ABEA0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC68 */); // 0x00000001838AC650-0x00000001838AC820
	}

	[BurstCompile]
	public struct PortArrowRenderJob : IJobParallelFor // TypeDefIndex: 50090
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
		public void Execute(int index); // 0x00000001869F77CC-0x00000001869F7AA0
	}

	[BurstCompile]
	public struct PortStateCollectJob : IJob // TypeDefIndex: 50091
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		public UnsafeList<float4x4> portStatePosList; // 0x20
		public float pipePortBlockOffsetY; // 0x28
		public float conveyorPortBlockOffsetY; // 0x2C
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x30
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F7BA8-0x00000001869F7D4C
		private void _Collect(ref ComplexPortFragment complexPortFrag, ref SharedDataContainer.SharedExtData extData); // 0x00000001869F7D4C-0x00000001869F7F98
		public void SetSharedExtData(IntPtr data); // 0x00000001833410A0-0x0000000183341100
		[IDTag(1)]
		public void Execute(); // 0x00000001869F7B2C-0x00000001869F7BA8
		[IDTag(2)]
		public void Execute(int startIndex, int count); // 0x00000001869F7AA0-0x00000001869F7B2C
	}

	[BurstCompile]
	public struct PortStateRendererJob : IJobParallelFor // TypeDefIndex: 50092
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<float4x4> posList; // 0x20
	
		// Methods
		public void Execute(int index); // 0x00000001869F7F98-0x00000001869F81A0
	}

	[BurstCompile]
	public struct PreviewUnitQueryJob : IJob // TypeDefIndex: 50093
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_previewUnitQr; // 0x18
	
		// Methods
		public void Execute(); // 0x00000001869F81A0-0x00000001869F825C
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer previewUnitQr, bool resetQr = true /* Metadata: 0x0232EC69 */); // 0x00000001838AB3D0-0x00000001838AB440
	}

	[BurstCompile]
	public struct PumpInEffectJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 50094
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
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F82DC-0x00000001869F8754
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F825C-0x00000001869F82DC
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x0000000183EE36C0-0x0000000183EE3700
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC6A */); // 0x0000000183EE35A0-0x0000000183EE3680
		public void SetSharedExtData(IntPtr data); // 0x0000000183EE3680-0x0000000183EE36C0
	}

	[BurstCompile]
	public struct ResetHierarchyDirtyJob : IJob // TypeDefIndex: 50095
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityHierarchyContainer.EntityTransformData* hierarchyDataPtr; // 0x00
		public int count; // 0x08
	
		// Methods
		public void Execute(); // 0x00000001869F8754-0x00000001869F87D0
		public void SetHierarchyData(IntPtr data); // 0x00000001841FB5F0-0x00000001841FB630
	}

	[BurstCompile]
	public struct StatusChangeJob : IJobParallelFor // TypeDefIndex: 50096
	{
		// Fields
		public EntityManager em; // 0x00
		[NativeDisableContainerSafetyRestriction]
		public NativeArray<EvtStatusChange> events; // 0x10
		public EventChannel<EvtVatUpdate> vatUpdateWriter; // 0x20
		public EventChannel<EvtUpdateStatusEffect> updateStatusEffectWriter; // 0x38
		public EventChannel<EvtAudio> audioWriter; // 0x50
		public FunctionPointer<UnsafeJobFuncPointers.QueryBuildingState> queryBuildingState; // 0x68
		public FunctionPointer<UnsafeJobFuncPointers.SetEntityFlashStatue> setEntityFlashStatue; // 0x70
	
		// Methods
		public void Execute(int index); // 0x00000001869F87D0-0x00000001869F8AE0
	}

	[BurstCompile]
	public struct UnitCullingJob : IJobParallelForBatch // TypeDefIndex: 50097
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
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F90CC-0x00000001869F914C
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F8CFC-0x00000001869F90CC
		public void SetGlobalEnvRef(ref GlobalEnv envRef); // 0x00000001841EE480-0x00000001841EE4C0
		public void SetSharedExtData(IntPtr data); // 0x00000001841EE440-0x00000001841EE480
	}

	[BurstCompile]
	public struct UnitPreviewRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 50098
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* env; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x10
	
		// Methods
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F9380-0x00000001869F9400
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F914C-0x00000001869F9380
		public void SetGlobalEnvRef(ref GlobalEnv envRef); // 0x00000001838AB440-0x00000001838AB480
		public void SetSharedExtData(IntPtr data); // 0x00000001838AB480-0x00000001838AB4C0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x00000001838AB4C0-0x00000001838AB500
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC6B */); // 0x00000001838AB730-0x00000001838AB7D0
	}

	[BurstCompile]
	public struct UnitRendererQueryJob : IJob // TypeDefIndex: 50099
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
		public void Execute(); // 0x00000001869F9400-0x00000001869F95D4
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer unitQr, ref EntityQueryV2.QueryResultDefer liquidQr, ref EntityQueryV2.QueryResultDefer pumpQr, ref EntityQueryV2.QueryResultDefer envReceiverQr, bool resetQr = true /* Metadata: 0x0232EC6C */); // 0x00000001830D3910-0x00000001830D3A00
	}

	[BurstCompile]
	public struct UpdateUnitRendererTRSJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 50100
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x08
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F9660-0x00000001869F9820
		private void _Transform(ref HGFactoryRendererBinderComponent rendererBinder, ref LocalToWorld localToWorld, ref SharedDataFragment sharedData); // 0x00000001869F9820-0x00000001869F98E4
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F95D4-0x00000001869F9660
		public void SetSharedExtData(IntPtr data); // 0x00000001841FB570-0x00000001841FB5B0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data); // 0x00000001841FB5B0-0x00000001841FB5F0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x0232EC6D */); // 0x0000000184045DB0-0x0000000184045E90
	}

	[BurstCompile]
	public struct WireCollectJob : IJob // TypeDefIndex: 50101
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
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869F98E4-0x00000001869F9F1C
		private bool _IsNormalConnection(FacBuildingState state); // 0x00000001869EDF38-0x00000001869EDFA0
		private bool _IsDisabledConnection(FacBuildingState state); // 0x00000001869EDF28-0x00000001869EDF38
		[IDTag(1)]
		public void Execute(); // 0x00000001869F9F1C-0x00000001869F9FC8
		public void SetGlobalEnvRef(ref GlobalEnv envRef); // 0x0000000183875F40-0x0000000183875FA0
		public void SetSharedExtData(IntPtr data); // 0x0000000183875EE0-0x0000000183875F40
	}

	[BurstCompile]
	public struct WireRenderJob : IJobParallelForBatch // TypeDefIndex: 50102
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public IntPtr dataMatrices; // 0x00
		public EntityManager em; // 0x08
		public NativeArray<Entity> rendererEntities; // 0x18
	
		// Methods
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869FA054-0x00000001869FA150
		private void _UpdateCachedWire(Entity cachedEntity, WireRendererInfo arg); // 0x00000001869FA150-0x00000001869FA304
		[IDTag(1)]
		public void Execute(int startIndex, int count); // 0x00000001869F9FC8-0x00000001869FA054
	}

	public struct FactoryBuildingEffectData : IEventData // TypeDefIndex: 50103
	{
		// Fields
		public Entity buildingLogicEntity; // 0x00
		public AdditiveEffectFragment.AdditiveEffectType effectType; // 0x08
	}

	public struct FPtrNativeCurve // TypeDefIndex: 50104
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe float* m_values; // 0x00
		private int m_valuesLength; // 0x08
		private UnityEngine.WrapMode m_preWrapMode; // 0x0C
		private UnityEngine.WrapMode m_postWrapMode; // 0x10
	
		// Methods
		public bool IsValid(); // 0x00000001869EEFB4-0x00000001869EF004
		public NativeArray<float> CreateCurve(AnimationCurve curve, int resolution); // 0x0000000183DF0420-0x0000000183DF0670
		public float Evaluate(float t); // 0x00000001869EEE20-0x00000001869EEFB4
		private float _Repeat(float t, float length); // 0x0000000185398300-0x000000018539834C
		private float _Pingpong(float t, float length); // 0x000000018539978C-0x00000001853997C0
	}

	public static class StringIntern // TypeDefIndex: 50107
	{
		// Nested types
		[IsReadOnly]
		public struct FastId : IEquatable<FastId> // TypeDefIndex: 50105
		{
			// Fields
			public readonly int id; // 0x00
			public static readonly FastId INVALID; // 0x00
	
			// Properties
			public bool isValid { get; } // 0x00000001869EF200-0x00000001869EF250 
	
			// Constructors
			public FastId(int value); // 0x0000000184D86140-0x0000000184D86150
			static FastId(); // 0x0000000184D7A850-0x0000000184D7A890
	
			// Methods
			[IDTag(0)]
			public static implicit operator FastId(int value); // 0x00000001837ACFE0-0x00000001837AD030
			[IDTag(1)]
			public static implicit operator int(FastId fastId); // 0x00000001837ABF10-0x00000001837ABF60
			[IDTag(0)]
			public bool Equals(FastId other); // 0x00000001869EF004-0x00000001869EF060
			[IDTag(1)]
			public override bool Equals(object obj); // 0x00000001869EF060-0x00000001869EF10C
			public override int GetHashCode(); // 0x00000001869EF10C-0x00000001869EF158
			public bool __iFixBaseProxy_Equals(object P0); // 0x00000001869EF158-0x00000001869EF1B4
			public int __iFixBaseProxy_GetHashCode(); // 0x00000001869EF1B4-0x00000001869EF200
		}
	
		private static class StringTable // TypeDefIndex: 50106
		{
			// Fields
			private const int INITIAL_SIZE = 512; // Metadata: 0x0232EC6E
			private static readonly Dictionary<string, int> STR_TO_INDEX; // 0x00
			private static readonly Dictionary<int, string> INDEX_TO_STR; // 0x08
			private static int s_nextId; // 0x10
	
			// Constructors
			static StringTable(); // 0x0000000184B6AC00-0x0000000184B6AD10
	
			// Methods
			internal static int GetOrAddIndex(string s); // 0x00000001837AD030-0x00000001837AD200
			internal static bool TryGetIndex(string s, out int id); // 0x00000001869F8C48-0x00000001869F8CFC
			internal static string IndexToString(int id); // 0x0000000183290D40-0x0000000183290F80
		}
	
		// Methods
		public static FastId StringToIndex(string key); // 0x00000001869F8B28-0x00000001869F8BB4
		public static bool TryGetIndex(string key, out FastId id); // 0x00000001869F8BB4-0x00000001869F8C48
		public static string IndexToString(FastId id); // 0x00000001869F8AE0-0x00000001869F8B28
	}

	public static class IndexHashMap<T> // TypeDefIndex: 50110
		where T : struct
	{
		// Fields
		private static readonly SharedStatic<Holder> HOLDER;
	
		// Properties
		private static ref Holder H { get; }
		public static int count { get; }
	
		// Nested types
		private struct Holder // TypeDefIndex: 50108
		{
			// Fields
			public NativeParallelHashMap<int, T> map;
		}
	
		private struct Context // TypeDefIndex: 50109
		{
		}
	
		// Constructors
		static IndexHashMap();
	
		// Methods
		public static void Initialize(int capacity, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232EC70 */);
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

	[Serializable]
	public struct PerDrawConfigArray // TypeDefIndex: 50111
	{
		// Fields
		public const int MAX_COUNT = 10; // Metadata: 0x0232EC71
		public PerDrawConfig[] perDrawConfigArray; // 0x00
		public PerDrawPassConfig[] passConfigArray; // 0x08
	}

	[Serializable]
	public struct PerDrawPassConfig // TypeDefIndex: 50112
	{
		// Fields
		public bool enable; // 0x00
		[HideInInspector]
		public uint lightModeRaw; // 0x01
	
		// Properties
		public PerDrawLightMode lightMode { get; set; } // 0x00000001869F3BE8-0x00000001869F3C34 0x00000001869F3C34-0x00000001869F3C8C
	
		// Methods
		public int Size(); // 0x00000001869F39D0-0x00000001869F3A20
		[IDTag(0)]
		public void Apply(Entity rendererEntity, ref uint currentLightMode); // 0x00000001869F3894-0x00000001869F394C
		[IDTag(1)]
		public void Apply(HGFactoryRendererBinderComponent binder, ref uint currentLightMode); // 0x00000001869F394C-0x00000001869F39D0
		private HGShaderLightMode _ParseToHGShaderLightMode(PerDrawLightMode value); // 0x00000001869F3A20-0x00000001869F3BE8
	}

	[Serializable]
	public struct PerDrawConfig // TypeDefIndex: 50113
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
		public static int Size(); // 0x00000001869F3700-0x00000001869F3744
		public void OnValidate(); // 0x00000001836D61D0-0x00000001836D6220
		private void _OnPerDrawTypeChanged(); // 0x00000001836D6220-0x00000001836D62D0
		private void _OnColorChanged(UnityEngine.Color c); // 0x00000001869F3744-0x00000001869F37B4
		private void _OnFloat4Changed(float4 f); // 0x00000001869F37B4-0x00000001869F381C
		private void _OnFloatChanged(float f); // 0x00000001869F381C-0x00000001869F3894
		public void Apply(HGFactoryRendererBinderComponent binder); // 0x00000001869F3654-0x00000001869F3700
	}

	public enum LogicEntityState // TypeDefIndex: 50114
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

	public class PerDrawDataOffsetAttribute : Attribute // TypeDefIndex: 50115
	{
		// Fields
		public System.Type type; // 0x10
		public int typeValue; // 0x18
	
		// Constructors
		public PerDrawDataOffsetAttribute(System.Type type, int typeValue); // 0x0000000184CAB8C0-0x0000000184CAB8E0
	}

	public enum LogicEntityType // TypeDefIndex: 50116
	{
		CONVEYOR = 0,
		PIPE = 1,
		BUILDING = 2,
		INDICATOR = 3,
		GRID = 4,
		MAX = 5
	}

	public enum PerDrawOffset // TypeDefIndex: 50117
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
	public enum PerDrawLightMode : uint // TypeDefIndex: 50118
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

	public static class PerDrawDataOffset // TypeDefIndex: 50119
	{
		// Fields
		public const int BASE_COLOR = 0; // Metadata: 0x0232ECD4
		public const int EMISSIVE_COLOR = 16; // Metadata: 0x0232ECD5
		public const int SOCIAL_SIGN_ICON_INDEX = 60; // Metadata: 0x0232ECD6
		public const int CUTOFF_POS_Y = 32; // Metadata: 0x0232ECD7
		public const int EMISSIVE_LUT_INDEX = 36; // Metadata: 0x0232ECD8
		public const int EMISSIVE_LUT_BIT_MASK = 40; // Metadata: 0x0232ECD9
		public const int LIQUID_HEIGHT_INDEX = 44; // Metadata: 0x0232ECDA
		public const int FACTORY_COLOR_TYPE = 48; // Metadata: 0x0232ECDB
		public const int ENABLE_CUTOFF = 52; // Metadata: 0x0232ECDC
		public const int EMISSIVE_ANIMATION_MODE = 56; // Metadata: 0x0232ECDD
		public const int LIQUID_COLOR_INDEX = 60; // Metadata: 0x0232ECDE
		public const int UI_ATLAS_UV = 0; // Metadata: 0x0232ECDF
		public const int UI_LIQUID_ATLAS_UV = 16; // Metadata: 0x0232ECE0
		public const int ENABLE_LIQUID_ICON = 68; // Metadata: 0x0232ECE1
		public const int RARITY_COLOR = 48; // Metadata: 0x0232ECE3
		public const int TINT_COLOR = 32; // Metadata: 0x0232ECE4
		public const int INDICATOR_DATA = 64; // Metadata: 0x0232ECE5
		public const int DISABLE_ICON_DEPTH_BLEND = 72; // Metadata: 0x0232ECE7
		public const int GRID_MODE = 16; // Metadata: 0x0232ECE9
		public const int RENDER_ON_WATER = 20; // Metadata: 0x0232ECEA
		public const int OVERLOOK = 44; // Metadata: 0x0232ECEB
		public const int ARROW_STEP_COUNT = 8; // Metadata: 0x0232ECEC
		public const int SIMPLE_DRAWING_TYPE = 12; // Metadata: 0x0232ECED
		public const int TIME_OFFSET = 0; // Metadata: 0x0232ECEE
		public const int ARROW_UV_SPEED = 4; // Metadata: 0x0232ECEF
		public const int ENABLE_CONVEYOR_INDICATOR = 12; // Metadata: 0x0232ECF0
		public const int ARROW_DATA = 16; // Metadata: 0x0232ECF1
		public const int BELT_COLOR = 32; // Metadata: 0x0232ECF2
		public const int FLOW_INTENSITY = 48; // Metadata: 0x0232ECF3
		public const int BELT_COLOR_INTENSITY = 52; // Metadata: 0x0232ECF4
		public const int BELT_COLOR_ALPHA = 56; // Metadata: 0x0232ECF5
		public const int ELECTRIC_WIRE_ALPHA = 12; // Metadata: 0x0232ECF6
		public const int VFX_TINT_COLOR_ALPHA = 44; // Metadata: 0x0232ECF7
		public const int ELECTRIC_WIRE_LENGTH = 56; // Metadata: 0x0232ECF8
		public const int WATER_THICKNESS = 0; // Metadata: 0x0232ECF9
		public const int WATER_DELTA_TIME = 4; // Metadata: 0x0232ECFA
		public const int TUBE_INDEX = 8; // Metadata: 0x0232ECFB
		public const int TUBE_COUNT = 12; // Metadata: 0x0232ECFC
		public const int WATER_DIRECTION = 16; // Metadata: 0x0232ECFD
		public const int ENABLE_OVERLOOK_ARROW = 20; // Metadata: 0x0232ECFE
		public const int TUBE_BEND_X_DEGREE = 24; // Metadata: 0x0232ECFF
		public const int TUBE_BEND_TAG = 28; // Metadata: 0x0232ED00
		public const int GLASS_COLOR = 32; // Metadata: 0x0232ED01
		public const int ATLAS_UV_INDEX = 48; // Metadata: 0x0232ED02
		public const int ENABLE_TUBE_INDICATOR = 52; // Metadata: 0x0232ED03
		public const int FIRST_INDEX = 56; // Metadata: 0x0232ED04
		public const int DITHER_TRANSPARENT_ALPHA = 64; // Metadata: 0x0232ED05
		public const int BLUEPRINT_NOISE_ALPHA = 68; // Metadata: 0x0232ED07
		public const int FACTORY_VAT_FRAME = 72; // Metadata: 0x0232ED09
		public const int FACTORY_VAT_LAST_FRAME = 76; // Metadata: 0x0232ED0B
	}

	public class ProcessorInterval // TypeDefIndex: 50120
	{
		// Constructors
		public ProcessorInterval(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static bool CheckInterval(ref IProcessor processor, float delta = 1f /* Metadata: 0x0232ED0D */, float rate = 1f /* Metadata: 0x0232ED11 */); // 0x00000001834CFB20-0x00000001834CFDD0
		private static bool _CheckInterval(float frameInterval, float intervalSetting, out float curInterval, float delta = 1f /* Metadata: 0x0232ED15 */, float rate = 1f /* Metadata: 0x0232ED19 */); // 0x00000001834CFDD0-0x00000001834D0130
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public class CargoPredictProcessor : BaseProcessor // TypeDefIndex: 50121
	{
		// Properties
		public override bool lowFrameEnable { get; } // 0x00000001845B2180-0x00000001845B21B0 
		public override string name { get; } // 0x00000001869EE3D0-0x00000001869EE434 
	
		// Constructors
		public CargoPredictProcessor(); // 0x0000000184D8CF30-0x0000000184D8CF40
	
		// Methods
		public override JobHandle Execute(ref EntityManager em, long time, long dt, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies); // 0x00000001838ABEA0-0x00000001838AC150
		public JobHandle __iFixBaseProxy_Execute(ref EntityManager P0, long P1, long P2, float P3, int P4, int P5, int P6, ref GlobalEnv P7, JobHandle P8, NativeList<JobHandle> P9); // 0x00000001869EE31C-0x00000001869EE3C8
		public bool __iFixBaseProxy_get_lowFrameEnable(); // 0x00000001869EE3C8-0x00000001869EE3D0
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public class CrossFrameProcessor : BaseProcessor // TypeDefIndex: 50122
	{
		// Fields
		private InteractFacCollectJob.BuildingInfo m_nearBuildingInfo; // 0x20
		private InteractFacCollectJob.LogisticInfo m_nearConveyorInfo; // 0x74
		private InteractFacCollectJob.LogisticInfo m_nearPipeInfo; // 0x94
		private InteractFacCollectJob.BuildingInfo m_nearBuildingInfoLast; // 0xB4
		private InteractFacCollectJob.LogisticInfo m_nearConveyorInfoLast; // 0x108
		private InteractFacCollectJob.LogisticInfo m_nearPipeInfoLast; // 0x128
		private const float MAX_BUILDING_INTERACT_RADIUS = 1.5f; // Metadata: 0x0232ED1D
		private const float BUILDING_INTERACT_RADIUS_EXPAND = 0.6f; // Metadata: 0x0232ED21
	
		// Properties
		public override string name { get; } // 0x00000001869EE548-0x00000001869EE5AC 
		public override bool lowFrameEnable { get; } // 0x00000001845E1190-0x00000001845E11C0 
	
		// Constructors
		public CrossFrameProcessor(); // 0x0000000184D8CF30-0x0000000184D8CF40
	
		// Methods
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting); // 0x0000000184B2C740-0x0000000184B2C7F0
		public override JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle); // 0x0000000183343A10-0x0000000183344810
		public override void TearDown(ref EntityManager em, ref GlobalEnv env); // 0x00000001869EE434-0x00000001869EE4CC
		public void __iFixBaseProxy_Initialize(ref EntityManager P0, ref GlobalEnv P1, FactorySetting P2); // 0x00000001869EE4CC-0x00000001869EE4DC
		public JobHandle __iFixBaseProxy_LateExecute(ref EntityManager P0, ref GlobalEnv P1, int P2, int P3, int P4, JobHandle P5); // 0x00000001869EE4DC-0x00000001869EE540
		public void __iFixBaseProxy_TearDown(ref EntityManager P0, ref GlobalEnv P1); // 0x00000001869EE540-0x00000001869EE548
		public bool __iFixBaseProxy_get_lowFrameEnable(); // 0x00000001869EE3C8-0x00000001869EE3D0
	}

	public abstract class EntityDestroyReactiveProcessor<T> : ReactiveProcessor<T> // TypeDefIndex: 50123
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
	public class FacRendererCollectProcessor : BaseProcessor // TypeDefIndex: 50124
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
		private unsafe UnsafeList<EnvGeneratorRendererInfo>* m_envGeneratorPosList; // 0x70
		private unsafe UnsafeList<float4x4>* m_buildingStatePosList; // 0x78
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorLPosList0; // 0x80
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorMPosList0; // 0x40088
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorRPosList0; // 0x80090
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorLPosList1; // 0xC0098
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorMPosList1; // 0x1000A0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorRPosList1; // 0x1400A8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewLPosList0; // 0x1800B0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewMPosList0; // 0x1C00B8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewRPosList0; // 0x2000C0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewLPosList1; // 0x2400C8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewMPosList1; // 0x2800D0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorPreviewRPosList1; // 0x2C00D8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideLPosList0; // 0x3000E0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideMPosList0; // 0x3400E8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideRPosList0; // 0x3800F0
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideLPosList1; // 0x3C00F8
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideMPosList1; // 0x400100
		private ConveyorRendererInfoCollection<ConveyorRendererInfo> m_conveyorGuideRPosList1; // 0x440108
		private CargoRendererInfoCollection<CargoRendererInfo> m_cargoList0; // 0x480110
		private CargoRendererInfoCollection<CargoRendererInfo> m_cargoList1; // 0x4C8118
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeLPosList0; // 0x510120
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeMPosList0; // 0x550128
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeRPosList0; // 0x590130
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeLPosList1; // 0x5D0138
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeMPosList1; // 0x610140
		private PipeRendererInfoCollection<PipeRendererInfo> m_pipeRPosList1; // 0x650148
		private PipeRendererInfoCollection<PipeRendererInfo> m_gasPipeLPosList0; // 0x690150
		private PipeRendererInfoCollection<PipeRendererInfo> m_gasPipeMPosList0; // 0x6D0158
		private PipeRendererInfoCollection<PipeRendererInfo> m_gasPipeRPosList0; // 0x710160
		private PipeRendererInfoCollection<PipeRendererInfo> m_gasPipeLPosList1; // 0x750168
		private PipeRendererInfoCollection<PipeRendererInfo> m_gasPipeMPosList1; // 0x790170
		private PipeRendererInfoCollection<PipeRendererInfo> m_gasPipeRPosList1; // 0x7D0178
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackLPosList0; // 0x810180
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackMPosList0; // 0x812188
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackRPosList0; // 0x814190
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackLPosList1; // 0x816198
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackMPosList1; // 0x8181A0
		private PipeTrackRendererInfoCollection<PipeTrackRendererInfo> m_trackRPosList1; // 0x81A1A8
		private WireRendererInfoCollection<WireRendererInfo> m_wireNormalList0; // 0x81C1B0
		private WireRendererInfoCollection<WireRendererInfo> m_wireNormalList1; // 0x8221B8
		private WireRendererInfoCollection<WireRendererInfo> m_wireHsNormalList0; // 0x8281C0
		private WireRendererInfoCollection<WireRendererInfo> m_wireHsNormalList1; // 0x82E1C8
		private WireRendererInfoCollection<WireRendererInfo> m_wireDisableList0; // 0x8341D0
		private WireRendererInfoCollection<WireRendererInfo> m_wireDisableList1; // 0x83A1D8
		private WireRendererInfoCollection<WireRendererInfo> m_wireStrengthenList0; // 0x8401E0
		private WireRendererInfoCollection<WireRendererInfo> m_wireStrengthenList1; // 0x8461E8
		private WireRendererInfoCollection<WireRendererInfo> m_wireHsStrengthenList0; // 0x84C1F0
		private WireRendererInfoCollection<WireRendererInfo> m_wireHsStrengthenList1; // 0x8521F8
		private WireRendererInfoCollection<WireRendererInfo> m_wireStrengthenDisableList0; // 0x858200
		private WireRendererInfoCollection<WireRendererInfo> m_wireStrengthenDisableList1; // 0x85E208
		private unsafe UnsafeList<Matrix4x4>* m_pipeHolderPosList; // 0x864210
		private unsafe UnsafeList<Matrix4x4>* m_conveyorLogPosList; // 0x864218
		private unsafe UnsafeList<float4x4>* m_comPosList; // 0x864220
		private PortArrowRendererInfoCollection<PortArrowRendererInfo> m_portArrowList0; // 0x864228
		private PortArrowRendererInfoCollection<PortArrowRendererInfo> m_portArrowList1; // 0x884230
		private unsafe UnsafeList<float4x4>* m_conveyorInsideMatrices; // 0x8A4238
		private FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> m_facRegionPosValidFuncPtr; // 0x8A4240
		public FunctionPointer<UnsafeJobFuncPointers.QueryStateIconPath> queryStateIconPathFuncPtr; // 0x8A4248
		private int m_lowFrameInterval; // 0x8A4250
		private const int ARROW_PLACED_DIC_CAPACITY = 4096; // Metadata: 0x0232ED25
		private UnsafeParallelHashMap<int, bool> m_arrowPlacedDic; // 0x8A4258
	
		// Properties
		public override string name { get; } // 0x00000001869FCB54-0x00000001869FCBB8 
	
		// Constructors
		public FacRendererCollectProcessor(); // 0x0000000184D8D000-0x0000000184D8D020
		static FacRendererCollectProcessor(); // 0x0000000184D5E090-0x0000000184D5E0E0
	
		// Methods
		private JobHandle _CollectConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorCollectJobHandle); // 0x00000001834CD2D0-0x00000001834CD560
		private JobHandle _CollectPreviewConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorPreviewCollectJobHandle); // 0x00000001834CD040-0x00000001834CD2D0
		private JobHandle _CollectGuideConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorCollectJobHandle); // 0x00000001834CD560-0x00000001834CD7F0
		private JobHandle _CollectConveyorLogistics(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle collectJobHandle); // 0x00000001834CD7F0-0x00000001834CD8C0
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting); // 0x00000001834D5770-0x00000001834D5A00
		private void _CreateAllocator(ref GlobalEnv env); // 0x00000001834D5CB0-0x00000001834D5D00
		private void _CreateCurrent(ref GlobalEnv env); // 0x00000001834D5330-0x00000001834D5770
		private JobHandle _CollectPortState(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portCollectJobHandle); // 0x0000000183341160-0x0000000183341470
		private JobHandle _CollectBuildingState(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle buildingStateCollectJobHandle); // 0x0000000183341470-0x00000001833417A0
		private JobHandle _CollectCargo(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle cargoCollectJobHandle); // 0x00000001838AB8F0-0x00000001838ABB80
		private JobHandle _CollectWire(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle wireCollectJobHandle); // 0x0000000183875490-0x0000000183875920
		public override JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle); // 0x00000001834CEC30-0x00000001834CF190
		public override void TearDown(ref EntityManager em, ref GlobalEnv env); // 0x00000001869FC270-0x00000001869FC454
		private JobHandle _CollectEnvGenerator(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle envGeneratorCollectJobHandle); // 0x0000000183D681F0-0x0000000183D684B0
		private JobHandle _CollectOutput(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle outputCollectJobHandle); // 0x0000000183D67ED0-0x0000000183D68190
		private JobHandle _CollectPipe(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle pipeCollectJobHandle); // 0x00000001833417A0-0x0000000183342EE0
		private JobHandle _CollectPipeLogistics(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle pipeHolderCollectJobHandle); // 0x00000001834CD8C0-0x00000001834CD990
		private void _InitArrowPlaced(ref GlobalEnv env); // 0x0000000184822240-0x00000001848222D0
		private JobHandle _CollectPortArrow(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portArrowCollectJobHandle); // 0x0000000183342EE0-0x00000001833434C0
		private JobHandle _CollectPortArrowWithDiff(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portArrowCollectJobHandle); // 0x00000001869FC454-0x00000001869FCB54
		public void __iFixBaseProxy_Initialize(ref EntityManager P0, ref GlobalEnv P1, FactorySetting P2); // 0x00000001869EE4CC-0x00000001869EE4DC
		public JobHandle __iFixBaseProxy_LateExecute(ref EntityManager P0, ref GlobalEnv P1, int P2, int P3, int P4, JobHandle P5); // 0x00000001869EE4DC-0x00000001869EE540
		public void __iFixBaseProxy_TearDown(ref EntityManager P0, ref GlobalEnv P1); // 0x00000001869EE540-0x00000001869EE548
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public abstract class ReactiveProcessor<T> : BaseProcessor // TypeDefIndex: 50125
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

	public class AdditiveMaterialBitIndex // TypeDefIndex: 50126
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
		public AdditiveMaterialBitIndex(); // 0x00000001841E1670-0x00000001841E1680
		static AdditiveMaterialBitIndex(); // 0x00000001869FA430-0x00000001869FA5B4
	}

	public class FactoryBaseColorLutConfig : ScriptableObject // TypeDefIndex: 50127
	{
		// Fields
		public SerializeFieldDictionary<FacBuildingBaseBuffer, UnityEngine.Color> factoryBuildingBaseStateConfig; // 0x18
		public SerializeFieldDictionary<string, int> factoryBuildingCrafterData; // 0x20
		public int factoryBuildingCount; // 0x28
	
		// Constructors
		public FactoryBaseColorLutConfig(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public bool GetColor(int sort, out UnityEngine.Color col); // 0x00000001869FCCD8-0x00000001869FCD78
		public bool GetIndex(string key, out int index); // 0x0000000184207CF0-0x0000000184207D50
		public static FactoryBaseColorLutConfig CreateOrGet(string path); // 0x00000001869FCBB8-0x00000001869FCCD8
	}

	public enum FacBuildingBaseBuffer // TypeDefIndex: 50128
	{
		InputBuffer1 = 0,
		InputBuffer2 = 1,
		InputBuffer3 = 2,
		OutputBuffer1 = 3,
		OutputBuffer2 = 4,
		OutputBuffer3 = 5
	}

	[Serializable]
	public struct FFactoryStateColorConfig // TypeDefIndex: 50130
	{
		// Fields
		public SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryStateIconColorConfig; // 0x00
		public SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryIndicatorColorConfig; // 0x08
		public SerializeFieldDictionary<FacBuildingState, string> factoryUIEffectConfig; // 0x10
		public SerializeFieldDictionary<LogicEntityState, SerializeFieldDictionary<LogicEntityType, PerDrawConfigArray>> factoryLogicEntityColorConfig2; // 0x18
	
		// Nested types
		[Serializable]
		public struct LogicStateConfig // TypeDefIndex: 50129
		{
			// Fields
			public UnityEngine.Color color; // 0x00
			public float intensity; // 0x10
			public float alpha; // 0x14
			public float flowAlpha; // 0x18
			[ColorUsage(true, true)]
			public UnityEngine.Color c; // 0x1C
	
			// Methods
			private void _OnColorChanged(); // 0x00000001869FCDE0-0x00000001869FCE74
		}
	
		// Methods
		public bool GetStateColor(FacBuildingState enumKey, out UnityEngine.Color col); // 0x00000001834D68A0-0x00000001834D6920
		public bool GetIndicatorColor(FacBuildingState enumKey, out UnityEngine.Color col); // 0x00000001869FB3C0-0x00000001869FB460
		public bool GetStateName(FacBuildingState enumKey, out string name); // 0x00000001869FB460-0x00000001869FB500
		public bool GetPerDrawList(LogicEntityState entityState, LogicEntityType entityType, out PerDrawConfigArray perDrawList); // 0x00000001834D6700-0x00000001834D67D0
		public void OnEnable(); // 0x00000001836D5A70-0x00000001836D61D0
	}
}

namespace Beyond.Gameplay.Factory.ECSVATFSM
{
	[BurstCompatible]
	[ECSComponent]
	public struct VATFSMStateFragment : IComponentECS // TypeDefIndex: 50131
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
		public const int ID = 60; // Metadata: 0x0232ED2D
	
		// Properties
		public ref VATFSMDefinition def { get; } // 0x0000000183CCC060-0x0000000183CCC0C0 
		public int id { get; } // 0x00000001837748C0-0x0000000183774920 
	
		// Methods
		public ref FSMStateDefinition GetCurrentStateDefinition(); // 0x00000001869FDC70-0x00000001869FDCD0
		public ref FSMStateDefinition GetCurrentStateDefinitionUnsafe(ref VATFSMDefinition definition); // 0x0000000183CCC3B0-0x0000000183CCC400
		public ref FSMClipDefinition GetCurrentClipDefinition(); // 0x0000000183CCC400-0x0000000183CCC440
		public ref FSMClipDefinition GetCurrentClipDefinitionUnsafe(ref VATFSMDefinition definition); // 0x0000000183CCC2A0-0x0000000183CCC340
		public void SetActiveClipSlotUnsafe(byte clipSlot, ref VATFSMDefinition definition); // 0x0000000183CCBB30-0x0000000183CCBBA0
		public void Init(uint defHandle, uint binderHandle); // 0x0000000183CCBF70-0x0000000183CCC060
		public void SetStateUnsafe(ref FSMStateDefinition stateDef, ref VATFSMDefinition fsmDef); // 0x0000000183CCBBA0-0x0000000183CCBC40
		public void SetState(ref FSMStateDefinition stateDef); // 0x00000001869FDCD0-0x00000001869FDD40
		public void ToNextState(); // 0x00000001869FDE2C-0x00000001869FDED0
		public void SetTransition([IsReadOnly] in FSMTransitionDefinition transDef, [IsReadOnly] in FSMStateDefinition nextStateDef); // 0x00000001869FDD40-0x00000001869FDE2C
		private void __AOT_FOR_FIX__(); // 0x00000001869FDED0-0x00000001869FE00C
	}

	public struct FSMState // TypeDefIndex: 50132
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
		public float process { get; } // 0x00000001869FBFA8-0x00000001869FC024 
		public bool isFinished { get; } // 0x0000000183055690-0x00000001830556F0 
	
		// Methods
		public void Enter(); // 0x0000000183CCC440-0x0000000183CCC470
		public void Update(float deltaTime, float fsmSpeed); // 0x00000001869FBF14-0x00000001869FBFA8
		public void Exit(); // 0x00000001869FBED0-0x00000001869FBF14
		public void SetProgress(float normalized); // 0x0000000183CCC690-0x0000000183CCC6E0
	}

	public struct FSMTransition // TypeDefIndex: 50133
	{
		// Fields
		public float duration; // 0x00
		private float m_elapsedTime; // 0x04
		private bool m_isFinish; // 0x08
	
		// Properties
		public bool isFinished { get; } // 0x00000001869FC1C0-0x00000001869FC210 
		public float fromStateWeight { get; } // 0x00000001869FC140-0x00000001869FC1C0 
		public float toStateWeight { get; } // 0x00000001869FC210-0x00000001869FC270 
	
		// Methods
		public void Enter(); // 0x00000001869FC024-0x00000001869FC074
		public void Update(float deltaTime, float fsmSpeed); // 0x00000001869FC0B8-0x00000001869FC140
		public void Exit(); // 0x00000001869FC074-0x00000001869FC0B8
	}

	public struct FSMParameterSet // TypeDefIndex: 50134
	{
		// Fields
		public FixedList32Bytes<float> floats; // 0x00
		public byte bools; // 0x20
		public byte triggers; // 0x21
	
		// Methods
		[IsReadOnly]
		public float GetFloat(byte index); // 0x00000001869FB860-0x00000001869FB904
		public void SetFloat(byte index, float value); // 0x00000001869FBC20-0x00000001869FBCB8
		[IsReadOnly]
		public int GetInt(byte index); // 0x00000001869FB904-0x00000001869FB9B0
		public void SetInt(byte index, int value); // 0x00000001869FBCB8-0x00000001869FBD54
		[IsReadOnly]
		public bool GetBool(byte index); // 0x00000001869FB800-0x00000001869FB860
		public void SetBool(byte index, bool value); // 0x00000001869FBB9C-0x00000001869FBC20
		[IsReadOnly]
		public bool GetTrigger(byte index); // 0x00000001869FB9B0-0x00000001869FBA10
		public void SetTrigger(byte index); // 0x00000001869FBD54-0x00000001869FBDBC
		public void ResetTrigger(byte index); // 0x00000001869FBB34-0x00000001869FBB9C
		public void ResetAllTriggers(); // 0x00000001869FBAE8-0x00000001869FBB34
		public void SetValue(byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type, float value); // 0x00000001869FBDBC-0x00000001869FBED0
		[IsReadOnly]
		public float GetValue(byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type); // 0x00000001869FBA10-0x00000001869FBAE8
		public void ResetParametersByDef([IsReadOnly] in VATFSMDefinition def); // 0x0000000183CCC470-0x0000000183CCC590
	}

	[BurstCompile]
	public struct VATFSMSetParamRequestHandlerJob : IJobFor // TypeDefIndex: 50135
	{
		// Fields
		public EntityManager renderEm; // 0x00
		public NativeArray<VATFSMProcessor.SetAnimatorParamRequest> setParamRequestList; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public unsafe VATFSMDefinition* sharedDataPtr; // 0x20
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* envPtr; // 0x28
	
		// Methods
		public void Execute(int index); // 0x00000001869FDB24-0x00000001869FDC70
	}

	[BurstCompile]
	public struct VATFSMStateUpdateJob : IJobFor // TypeDefIndex: 50136
	{
		// Fields
		public float deltaTime; // 0x00
		public bool enableFactoryRayTracing; // 0x04
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe VATFSMDefinition* fsmDefinitionPtr; // 0x28
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x30
		public UnsafeList<VATFSMProcessor.VATFSMAudioData> animatorAudioQueue; // 0x38
		private const int S_CURRENT_FRAME_OFFSET = 72; // Metadata: 0x0232ED2E
		private const int S_PREVIOUS_FRAME_OFFSET = 76; // Metadata: 0x0232ED30
		private const int S_VAT_CLIP_START_FRAME_OFFSET = 124; // Metadata: 0x0232ED32
		private const int S_VAT_CLIP_TOTAL_FRAMES_OFFSET = 128; // Metadata: 0x0232ED34
		private const int S_VAT_PROCESS_OFFSET = 132; // Metadata: 0x0232ED36
		private const int S_VAT_SPEED_OFFSET = 136; // Metadata: 0x0232ED38
	
		// Methods
		[IDTag(1)]
		public void Execute(); // 0x00000001869FE3A0-0x00000001869FE428
		[IDTag(0)]
		public void Execute(int index); // 0x00000001869FE00C-0x00000001869FE3A0
		private bool _CheckTransitions(ref VATFSMStateFragment fsm, ref VATFSMDefinition fsmDef); // 0x00000001869FE428-0x00000001869FE53C
		private void _ComputeVATFrameData(ref VATFSMStateFragment fsm, ref VATFSMDefinition fsmDef); // 0x00000001869FE53C-0x00000001869FE740
		public void SetSharedExtData(IntPtr data); // 0x00000001838AC820-0x00000001838AC880
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public class VATFSMProcessor : BaseProcessor // TypeDefIndex: 50140
	{
		// Fields
		public NativeList<SetAnimatorParamRequest> animatorParamRequestQueue; // 0x20
		private NativeParallelHashMap<Entity, int> m_requestMaskPerEntity; // 0x30
	
		// Properties
		public override string name { get; } // 0x00000001869FDAC0-0x00000001869FDB24 
		public unsafe VATFSMDefinition* fsmDefinitionPtr { get; } // 0x00000001838ACE00-0x00000001838ACE10 
	
		// Nested types
		public enum VATAnimatorRequestType : byte // TypeDefIndex: 50137
		{
			SetParameter = 1,
			PauseOrResume = 2,
			SetSpeed = 3,
			ForceSetState = 4,
			SetStateLoop = 5,
			Reset = 6,
			SetActiveClipSlot = 7
		}
	
		public struct SetAnimatorParamRequest // TypeDefIndex: 50138
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
			public unsafe void SetParamToAnimator(GlobalEnv* envPtr, ref VATFSMStateFragment fragment, VATFSMDefinition* sharedDataPtr); // 0x0000000183CCBC40-0x0000000183CCBE30
		}
	
		public struct VATFSMAudioData // TypeDefIndex: 50139
		{
			// Fields
			public Entity entity; // 0x00
			public int hashStateName; // 0x08
		}
	
		// Constructors
		public VATFSMProcessor(); // 0x0000000184D8CF30-0x0000000184D8CF40
	
		// Methods
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting); // 0x00000001849569E0-0x0000000184956B30
		public override JobHandle Execute(ref EntityManager em, long time, long deltaTime, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies); // 0x00000001838AC8C0-0x00000001838ACE00
		private void _ResizeAnimatorAudioQueue(ref GlobalEnv env, int entityCount); // 0x00000001830556F0-0x0000000183055850
		public override void TearDown(ref EntityManager em, ref GlobalEnv env); // 0x00000001869FD97C-0x00000001869FDAC0
		private JobHandle _HandleSetAnimatorParamRequest(ref EntityManager em, ref GlobalEnv env, JobHandle jobHandle); // 0x0000000183055850-0x0000000183055E70
		private void _RemoveDuplicationRequest(ref EntityManager em); // 0x0000000183055E70-0x0000000183056390
		public void __iFixBaseProxy_Initialize(ref EntityManager P0, ref GlobalEnv P1, FactorySetting P2); // 0x00000001869EE4CC-0x00000001869EE4DC
		public JobHandle __iFixBaseProxy_Execute(ref EntityManager P0, long P1, long P2, float P3, int P4, int P5, int P6, ref GlobalEnv P7, JobHandle P8, NativeList<JobHandle> P9); // 0x00000001869EE31C-0x00000001869EE3C8
		public void __iFixBaseProxy_TearDown(ref EntityManager P0, ref GlobalEnv P1); // 0x00000001869EE540-0x00000001869EE548
	}

	[Serializable]
	public class ECSVATFSMDefinitionData // TypeDefIndex: 50142
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
		public struct VATClipSlotModeMapping // TypeDefIndex: 50141
		{
			// Fields
			public FCNodeMode mode; // 0x00
			public byte clipSlot; // 0x04
		}
	
		// Constructors
		public ECSVATFSMDefinitionData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class StateData // TypeDefIndex: 50143
	{
		// Fields
		public string name; // 0x10
		public float speed; // 0x18
		public string[] clipNames; // 0x20
	
		// Constructors
		public StateData(); // 0x0000000184D8CF30-0x0000000184D8CF40
	}

	public enum TransitionInterruptionSource // TypeDefIndex: 50144
	{
		None = 0,
		Source = 1,
		Destination = 2,
		SourceThenDestination = 3,
		DestinationThenSource = 4
	}

	[Serializable]
	public class TransitionData // TypeDefIndex: 50145
	{
		// Fields
		public string fromState; // 0x10
		public string toState; // 0x18
		public float exitTime; // 0x20
		public float duration; // 0x24
		public TransitionInterruptionSource interruptionSource; // 0x28
		public List<Beyond.Gameplay.Factory.ECSVATFSM.ConditionData> condition; // 0x30
	
		// Constructors
		public TransitionData(); // 0x00000001841E1670-0x00000001841E1680
	}

	public enum AnimatorConditionMode // TypeDefIndex: 50146
	{
		If = 1,
		IfNot = 2,
		Greater = 3,
		Less = 4,
		Equals = 6,
		NotEqual = 7
	}

	[Serializable]
	public class ConditionData // TypeDefIndex: 50147
	{
		// Fields
		public string parameterName; // 0x10
		public AnimatorConditionMode comparison; // 0x18
		public float threshold; // 0x1C
	
		// Constructors
		public ConditionData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class ParameterData // TypeDefIndex: 50148
	{
		// Fields
		public string name; // 0x10
		public AnimatorControllerParameterType type; // 0x18
		public float defaultFloat; // 0x1C
		public int defaultInt; // 0x20
		public bool defaultBool; // 0x24
	
		// Constructors
		public ParameterData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class AnimationClipData // TypeDefIndex: 50149
	{
		// Fields
		public string name; // 0x10
		public bool isLoop; // 0x18
		public float length; // 0x1C
		public int startFrame; // 0x20
		public int totalFrames; // 0x24
	
		// Constructors
		public AnimationClipData(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public string GetClipDesStr(); // 0x00000001869FA5B4-0x00000001869FA7AC
	}

	public struct VATFSMDefinition // TypeDefIndex: 50150
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

	public struct FSMModeClipSlotDefinition // TypeDefIndex: 50151
	{
		// Fields
		public byte modeRaw; // 0x00
		public byte clipSlot; // 0x01
	}

	public enum ConditionMode : byte // TypeDefIndex: 50152
	{
		If = 1,
		IfNot = 2,
		Greater = 3,
		Less = 4,
		Equals = 6,
		NotEqual = 7
	}

	public struct FSMCondition // TypeDefIndex: 50153
	{
		// Fields
		public byte parameterIndex; // 0x00
		public ConditionMode comparison; // 0x01
		public float threshold; // 0x04
	}

	[DataN(capacity = 20, tSize = 64, ring = false)]
	[NoAlias]
	public struct FSMTransitionDefinition20<T> : IEnumerable<T> // TypeDefIndex: 50156
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x0232ED54
		public const int CAPACITY = 32; // Metadata: 0x0232ED56
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x0232ED57
		public const int INVALID_INDEX = -1; // Metadata: 0x0232ED58
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
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 50154
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
		public struct _data_e__FixedBuffer // TypeDefIndex: 50155
		{
			// Fields
			public byte FixedElementField;
		}
	
		// Constructors
		public unsafe FSMTransitionDefinition20(int initialCapacity = 32 /* Metadata: 0x0232ED52 */, bool autoExtend = false /* Metadata: 0x0232ED53 */);
	
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

	public struct FSMTransitionDefinition // TypeDefIndex: 50157
	{
		// Fields
		public byte fromStateIndex; // 0x00
		public byte toStateIndex; // 0x01
		public float exitTime; // 0x02
		public float duration; // 0x06
		public FixedList32Bytes<FSMCondition> conditions; // 0x0A
	}

	public enum ParameterType : byte // TypeDefIndex: 50158
	{
		Float = 1,
		Int = 3,
		Bool = 4,
		Trigger = 9
	}

	public struct FSMParameterDefinition // TypeDefIndex: 50159
	{
		// Fields
		public int nameHash; // 0x00
		public Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type; // 0x04
		public byte index; // 0x05
		public float defaultFloat; // 0x08
		public int defaultInt; // 0x08
		public byte defaultBool; // 0x08
	}

	public struct FSMStateDefinition // TypeDefIndex: 50160
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
		public byte GetClipIndex(byte slotIndex); // 0x0000000183CCC340-0x0000000183CCC3B0
		public void SetClipIndex(byte slotIndex, byte clipIndex); // 0x0000000184332A20-0x0000000184332AA0
	}

	public struct FSMClipDefinition // TypeDefIndex: 50161
	{
		// Fields
		public int nameHash; // 0x00
		public float length; // 0x04
		public uint startFrame; // 0x08
		public uint totalFrames; // 0x0C
		public byte index; // 0x10
		public bool isLoop; // 0x11
	}

	public struct VATFSMDefinitionContainer // TypeDefIndex: 50163
	{
		// Fields
		public const int INVALID_INDEX = -1; // Metadata: 0x0232ED5D
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref VATFSMDefinition this[int index] { [IDTag(1)] get => default; } // 0x00000001869FD1E0-0x00000001869FD25C 
		public ref VATFSMDefinition this[uint index] { [IDTag(0)] get => default; } // 0x0000000183CCC170-0x0000000183CCC1E0 
	
		// Nested types
		internal struct Node // TypeDefIndex: 50162
		{
			// Fields
			public VATFSMDefinition value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public VATFSMDefinitionContainer(Unity.Collections.Allocator allocator); // 0x0000000184439330-0x00000001844393D0
	
		// Methods
		public void Dispose(); // 0x00000001869FCFB8-0x00000001869FD02C
		public void FlushPendingFree(); // 0x00000001834FF040-0x00000001834FF100
		public uint Size(); // 0x00000001869FD178-0x00000001869FD1E0
		public Span<VATFSMDefinition> AsSpan(); // 0x00000001869FCE74-0x00000001869FCF28
		public uint Create(ref VATFSMDefinition value); // 0x0000000184439440-0x0000000184439520
		public void Destroy(uint handle); // 0x00000001869FCF28-0x00000001869FCFB8
		public void Reset(); // 0x00000001844392C0-0x0000000184439330
		public void Reserve(uint newCapacity); // 0x00000001869FD0F4-0x00000001869FD178
		public IntPtr Data(); // 0x00000001838ACEB0-0x00000001838ACF10
		[IDTag(0)]
		public ref VATFSMDefinition Get(uint handle); // 0x00000001869FD090-0x00000001869FD0F4
		[IDTag(1)]
		public ref VATFSMDefinition Get(int handle); // 0x00000001869FD02C-0x00000001869FD090
	}

	public static class VATFSMDefinitionHelper // TypeDefIndex: 50164
	{
		// Methods
		private static bool _Evaluate([IsReadOnly] in FSMCondition cond, [IsReadOnly] in FSMParameterSet param, [IsReadOnly] in FixedList128Bytes<FSMParameterDefinition> paramDefs); // 0x00000001869FD728-0x00000001869FD97C
	
		// Extension methods
		public static bool TryGetValidTransition(this ref VATFSMStateFragment state, ref VATFSMDefinition def, out int transitionIndex); // 0x00000001869FD568-0x00000001869FD728
		public static bool TryGetParameterIndexAndType(this VATFSMDefinition def, int nameHash, out byte index, out Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type); // 0x00000001869FD3F8-0x00000001869FD568
		public static bool TryGetClipSlotByMode(this ref VATFSMDefinition def, FCNodeMode mode, out byte clipSlot); // 0x0000000183CCC1E0-0x0000000183CCC2A0
		public static void ResetUsedTriggers(this ref FSMParameterSet param, [IsReadOnly] in FSMTransitionDefinition transition, [IsReadOnly] in FixedList128Bytes<FSMParameterDefinition> paramDefs); // 0x00000001869FD25C-0x00000001869FD3F8
	}

	public static class FSMDefinitionLibrary // TypeDefIndex: 50165
	{
		// Fields
		public const int MAX_FSM_DEFINITION_COUNT = 128; // Metadata: 0x0232ED5E
		public const int MAX_STATE_COUNT = 15; // Metadata: 0x0232ED60
		public const int MAX_TRANSITION_COUNT = 20; // Metadata: 0x0232ED61
		public const int MAX_CONDITION_PRE_TRANSITION_COUNT = 3; // Metadata: 0x0232ED62
		public const int MAX_PARAMETER_COUNT = 7; // Metadata: 0x0232ED63
		public const int MAX_CLIP_PRE_STATE_COUNT = 3; // Metadata: 0x0232ED64
		public const int MAX_CLIP_COUNT = 20; // Metadata: 0x0232ED65
		public const byte ANY_STATE_INDEX = 255; // Metadata: 0x0232ED66
		public const string PEDESTAL_ADJUST_GROUND = "adjust_ground"; // Metadata: 0x0232ED67
		public static readonly float2 PEDESTAL_ADJUST_GROUND_RANGE; // 0x00
		public static readonly float PEDESTAL_ADJUST_GROUND_OFFSET; // 0x08
		public static NativeParallelHashMap<int, uint> s_assetHashGuidToHandle; // 0x10
		public static NativeParallelHashMap<int2, byte> s_stateNameHashToIndex; // 0x20
		public static NativeParallelHashMap<int2, byte> s_parameterNameHashToIndex; // 0x30
		public static NativeParallelHashMap<int2, byte> s_clipNameHashToIndex; // 0x40
	
		// Constructors
		static FSMDefinitionLibrary(); // 0x0000000184D590F0-0x0000000184D59150
	
		// Methods
		public static void Initialize(); // 0x0000000184956B30-0x0000000184956D30
		public static void InitFSMDefinition(int guid, ECSVATFSMDefinitionData data); // 0x00000001834A2270-0x00000001834A2BE0
		private static void _DisableFSM(Entity rEntity, ref EntityManager em); // 0x00000001834A4720-0x00000001834A4850
		public static string GetStateName(uint fsmHandler, byte stateIndex); // 0x00000001869FB698-0x00000001869FB800
		public static byte GetStateIndex(uint fsmHandler, int stateNameHash); // 0x00000001841F1C30-0x00000001841F1CF0
		public static void Dispose(); // 0x00000001869FB500-0x00000001869FB698
	
		// Extension methods
		public static void RegisterFSM(this Entity rEntity, ref EntityManager em); // 0x00000001834A40C0-0x00000001834A4160
		public static void SyncFSMDefinition(this Entity rEntity, ref EntityManager em); // 0x00000001834A4220-0x00000001834A4720
	}
}

namespace Beyond.Gameplay.Factory.Unsafe
{
	public enum BuildingStateQueryGroup : byte // TypeDefIndex: 50167
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

	public static class BuildingStateQueryRegistry // TypeDefIndex: 50168
	{
		// Methods
		public static BuildingStateQueryGroup GetGroup(int templateIdFastId); // 0x00000001869FA7AC-0x00000001869FB3C0
	}

	public static class BuildingTemplateIds // TypeDefIndex: 50171
	{
		// Fields
		private static bool s_inited; // 0x00
		private static readonly SharedStatic<Holder> HOLDER; // 0x08
	
		// Properties
		private static ref Holder Ids { get; } // 0x00000001843628E0-0x0000000184362950 
		public static ref StringIntern.FastId MINER_1 { get; } // 0x000000018435F110-0x000000018435F170 
		public static ref StringIntern.FastId MINER_2 { get; } // 0x000000018435F170-0x000000018435F1D0 
		public static ref StringIntern.FastId MINER_3 { get; } // 0x000000018435F1D0-0x000000018435F230 
		public static ref StringIntern.FastId MINER_4 { get; } // 0x000000018435F230-0x000000018435F290 
		public static ref StringIntern.FastId POWER_STATION_1 { get; } // 0x000000018435F290-0x000000018435F2F0 
		public static ref StringIntern.FastId FURNANCE_1 { get; } // 0x000000018435F2F0-0x000000018435F350 
		public static ref StringIntern.FastId FURNANCE_NOP_1 { get; } // 0x000000018435F350-0x000000018435F3B0 
		public static ref StringIntern.FastId GRINDER_1 { get; } // 0x000000018435F3B0-0x000000018435F410 
		public static ref StringIntern.FastId WINDER_1 { get; } // 0x000000018435F410-0x000000018435F470 
		public static ref StringIntern.FastId COMPONENT_MC_1 { get; } // 0x000000018435F470-0x000000018435F4D0 
		public static ref StringIntern.FastId SHAPER_1 { get; } // 0x000000018435F4D0-0x000000018435F530 
		public static ref StringIntern.FastId FILLING_POWDER_MC_1 { get; } // 0x000000018435F530-0x000000018435F590 
		public static ref StringIntern.FastId THICKENER_1 { get; } // 0x000000018435F590-0x000000018435F5F0 
		public static ref StringIntern.FastId TOOLS_ASSEBLING_MC_1 { get; } // 0x000000018435F5F0-0x000000018435F650 
		public static ref StringIntern.FastId SEEDCOLLECTOR_1 { get; } // 0x000000018435F650-0x000000018435F6B0 
		public static ref StringIntern.FastId PLANTER_1 { get; } // 0x000000018435F6B0-0x000000018435F710 
		public static ref StringIntern.FastId POWER_DIFFUSER_1 { get; } // 0x000000018435F710-0x000000018435F770 
		public static ref StringIntern.FastId POWER_DIFFUSER_2 { get; } // 0x000000018435F770-0x000000018435F7D0 
		public static ref StringIntern.FastId POWER_POLE_2 { get; } // 0x000000018435F7D0-0x000000018435F830 
		public static ref StringIntern.FastId POWER_POLE_3 { get; } // 0x000000018435F830-0x000000018435F890 
		public static ref StringIntern.FastId TRAVEL_POLE_1 { get; } // 0x000000018435F890-0x000000018435F8F0 
		public static ref StringIntern.FastId TRAVEL_POLE_NOP_1 { get; } // 0x000000018435F8F0-0x000000018435F950 
		public static ref StringIntern.FastId TRAVEL_POLE_2 { get; } // 0x000000018435F950-0x000000018435F9B0 
		public static ref StringIntern.FastId LOADER_1 { get; } // 0x000000018435F9B0-0x000000018435FA10 
		public static ref StringIntern.FastId UNLOADER_1 { get; } // 0x000000018435FA10-0x000000018435FA70 
		public static ref StringIntern.FastId STORAGER_1 { get; } // 0x000000018435FA70-0x000000018435FAD0 
		public static ref StringIntern.FastId STORAGER_NOP_1 { get; } // 0x000000018435FAD0-0x000000018435FB30 
		public static ref StringIntern.FastId POWER_TERMINAL_1 { get; } // 0x000000018435FB30-0x000000018435FB90 
		public static ref StringIntern.FastId POWER_PORT_1 { get; } // 0x000000018435FB90-0x000000018435FBF0 
		public static ref StringIntern.FastId SOIL_1 { get; } // 0x000000018435FBF0-0x000000018435FC50 
		public static ref StringIntern.FastId SOIL_2 { get; } // 0x000000018435FC50-0x000000018435FCB0 
		public static ref StringIntern.FastId SOIL_MOSS_1 { get; } // 0x000000018435FCB0-0x000000018435FD10 
		public static ref StringIntern.FastId SOIL_MOSS_2 { get; } // 0x000000018435FD10-0x000000018435FD70 
		public static ref StringIntern.FastId SOIL_MOSS_3 { get; } // 0x000000018435FD70-0x000000018435FDD0 
		public static ref StringIntern.FastId SOIL_BBFLOWER_1 { get; } // 0x000000018435FDD0-0x000000018435FE30 
		public static ref StringIntern.FastId SOIL_GRASS_1 { get; } // 0x000000018435FE30-0x000000018435FE90 
		public static ref StringIntern.FastId SOIL_GRASS_2 { get; } // 0x000000018435FE90-0x000000018435FEF0 
		public static ref StringIntern.FastId SOIL_SP_1 { get; } // 0x000000018435FEF0-0x000000018435FF50 
		public static ref StringIntern.FastId SOIL_SP_2 { get; } // 0x000000018435FF50-0x000000018435FFB0 
		public static ref StringIntern.FastId SOIL_SP_3 { get; } // 0x000000018435FFB0-0x0000000184360010 
		public static ref StringIntern.FastId SOIL_SP_4 { get; } // 0x0000000184360010-0x0000000184360070 
		public static ref StringIntern.FastId SOIL_GRASS_FAST_1 { get; } // 0x0000000184360070-0x00000001843600D0 
		public static ref StringIntern.FastId SOIL_GRASS_FAST_2 { get; } // 0x00000001843600D0-0x0000000184360130 
		public static ref StringIntern.FastId SOIL_SP_FAST_3 { get; } // 0x0000000184360130-0x0000000184360190 
		public static ref StringIntern.FastId SOIL_SP_FAST_4 { get; } // 0x0000000184360190-0x00000001843601F0 
		public static ref StringIntern.FastId BATTLE_LIGHTNING_1 { get; } // 0x00000001843601F0-0x0000000184360250 
		public static ref StringIntern.FastId BATTLE_CANNON_1 { get; } // 0x0000000184360250-0x00000001843602B0 
		public static ref StringIntern.FastId BATTLE_CANNON_2 { get; } // 0x00000001843602B0-0x0000000184360310 
		public static ref StringIntern.FastId BATTLE_TURRET_1 { get; } // 0x0000000184360310-0x0000000184360370 
		public static ref StringIntern.FastId BATTLE_TURRET_2 { get; } // 0x0000000184360370-0x00000001843603D0 
		public static ref StringIntern.FastId BATTLE_MEDIC_1 { get; } // 0x00000001843603D0-0x0000000184360430 
		public static ref StringIntern.FastId BATTLE_SHOCKWAVE_1 { get; } // 0x0000000184360430-0x0000000184360490 
		public static ref StringIntern.FastId BATTLE_FROST_1 { get; } // 0x0000000184360490-0x00000001843604F0 
		public static ref StringIntern.FastId BATTLE_SNIPER_1 { get; } // 0x00000001843604F0-0x0000000184360550 
		public static ref StringIntern.FastId BATTLE_LASER_1 { get; } // 0x0000000184360550-0x00000001843605B0 
		public static ref StringIntern.FastId BATTLE_LASER_2 { get; } // 0x00000001843605B0-0x0000000184360610 
		public static ref StringIntern.FastId BATTLE_JET_1 { get; } // 0x0000000184360610-0x0000000184360670 
		public static ref StringIntern.FastId BATTLE_TRAP_1 { get; } // 0x0000000184360670-0x00000001843606D0 
		public static ref StringIntern.FastId BATTLE_FOG_1 { get; } // 0x00000001843606D0-0x0000000184360730 
		public static ref StringIntern.FastId BATTLE_DEBUFF_1 { get; } // 0x0000000184360730-0x0000000184360790 
		public static ref StringIntern.FastId BATTLE_ROCKET_1 { get; } // 0x0000000184360790-0x00000001843607F0 
		public static ref StringIntern.FastId BATTLE_TURRET_3 { get; } // 0x00000001843607F0-0x0000000184360850 
		public static ref StringIntern.FastId BATTLE_LIGHTNING_2 { get; } // 0x0000000184360850-0x00000001843608B0 
		public static ref StringIntern.FastId BATTLE_CANNON_1_DG002 { get; } // 0x0000000184362880-0x00000001843628E0 
		public static ref StringIntern.FastId V_FLUID_CONTAINER_1 { get; } // 0x0000000184362820-0x0000000184362880 
		public static ref StringIntern.FastId PUMP_1 { get; } // 0x00000001843627C0-0x0000000184362820 
		public static ref StringIntern.FastId PUMP_2 { get; } // 0x0000000184362760-0x00000001843627C0 
		public static ref StringIntern.FastId LIQUID_STORAGER_1 { get; } // 0x0000000184362700-0x0000000184362760 
		public static ref StringIntern.FastId LIQUID_STORAGER_NOP_1 { get; } // 0x00000001843626A0-0x0000000184362700 
		public static ref StringIntern.FastId MIX_POOL_1 { get; } // 0x0000000184362640-0x00000001843626A0 
		public static ref StringIntern.FastId MIX_POOL_2 { get; } // 0x00000001843625E0-0x0000000184362640 
		public static ref StringIntern.FastId SQUIRTER_1 { get; } // 0x0000000184362580-0x00000001843625E0 
		public static ref StringIntern.FastId SQUIRTER_NOP_1 { get; } // 0x0000000184362520-0x0000000184362580 
		public static ref StringIntern.FastId DUMPER_1 { get; } // 0x00000001843624C0-0x0000000184362520 
		public static ref StringIntern.FastId DUMPER_NOP_1 { get; } // 0x0000000184362460-0x00000001843624C0 
		public static ref StringIntern.FastId LIQUID_CLEANER_1 { get; } // 0x0000000184362400-0x0000000184362460 
		public static ref StringIntern.FastId LIQUID_CLEAN_GATE_1 { get; } // 0x00000001843623A0-0x0000000184362400 
		public static ref StringIntern.FastId LIQUID_RECYCLE_GATE_1 { get; } // 0x0000000184362340-0x00000001843623A0 
		public static ref StringIntern.FastId XIRANITE_OVEN_1 { get; } // 0x00000001843622E0-0x0000000184362340 
		public static ref StringIntern.FastId LIQUID_PURIFIER_1 { get; } // 0x0000000184362280-0x00000001843622E0 
		public static ref StringIntern.FastId DISMANTLER_1 { get; } // 0x0000000184362220-0x0000000184362280 
		public static ref StringIntern.FastId LOG_HONGS_BUS { get; } // 0x00000001843621C0-0x0000000184362220 
		public static ref StringIntern.FastId LOG_HONGS_BUS_SOURCE { get; } // 0x0000000184362160-0x00000001843621C0 
		public static ref StringIntern.FastId UDPIPE_LOADER_1 { get; } // 0x0000000184362100-0x0000000184362160 
		public static ref StringIntern.FastId UDPIPE_LOADER_2 { get; } // 0x00000001843620A0-0x0000000184362100 
		public static ref StringIntern.FastId UDPIPE_UNLOADER_1 { get; } // 0x0000000184362040-0x00000001843620A0 
		public static ref StringIntern.FastId UDPIPE_UNLOADER_2 { get; } // 0x0000000184361FE0-0x0000000184362040 
		public static ref StringIntern.FastId VAPORIZER_1 { get; } // 0x0000000184361F80-0x0000000184361FE0 
		public static ref StringIntern.FastId TRANSMUTER_1 { get; } // 0x0000000184361F20-0x0000000184361F80 
		public static ref StringIntern.FastId TRANSMUTER_2 { get; } // 0x0000000184361EC0-0x0000000184361F20 
		public static ref StringIntern.FastId GAS_REACTOR_1 { get; } // 0x0000000184361E60-0x0000000184361EC0 
		public static ref StringIntern.FastId GAS_STORAGER_1 { get; } // 0x0000000184361E00-0x0000000184361E60 
		public static ref StringIntern.FastId GAS_PUMP_1 { get; } // 0x0000000184361DA0-0x0000000184361E00 
		public static ref StringIntern.FastId SP_HUB_1 { get; } // 0x0000000184361D40-0x0000000184361DA0 
		public static ref StringIntern.FastId SP_SUB_HUB_1 { get; } // 0x0000000184361CE0-0x0000000184361D40 
		public static ref StringIntern.FastId CARRIER_1 { get; } // 0x0000000184361C80-0x0000000184361CE0 
		public static ref StringIntern.FastId MARKER_1 { get; } // 0x0000000184361C20-0x0000000184361C80 
		public static ref StringIntern.FastId AIR_DANCER_1 { get; } // 0x0000000184361BC0-0x0000000184361C20 
		public static ref StringIntern.FastId CHUBBY_LUNG_STONE_1 { get; } // 0x0000000184361B60-0x0000000184361BC0 
		public static ref StringIntern.FastId CHUBBY_LUNG_BALLOON_1 { get; } // 0x0000000184361B00-0x0000000184361B60 
		public static ref StringIntern.FastId PEAR_BLOSSOM_BONSAI_1 { get; } // 0x0000000184361AA0-0x0000000184361B00 
		public static ref StringIntern.FastId JAIL_1 { get; } // 0x0000000184361A40-0x0000000184361AA0 
		public static ref StringIntern.FastId PHOTO_FRAME_1 { get; } // 0x00000001843619E0-0x0000000184361A40 
		public static ref StringIntern.FastId SIGNBOARD_1 { get; } // 0x0000000184361980-0x00000001843619E0 
		public static ref StringIntern.FastId CAT_TREE_1 { get; } // 0x0000000184361920-0x0000000184361980 
		public static ref StringIntern.FastId DISPLAY_STAND_1 { get; } // 0x00000001843618C0-0x0000000184361920 
		public static ref StringIntern.FastId MICROPHONE_1 { get; } // 0x0000000184361860-0x00000001843618C0 
	
		// Nested types
		private struct Holder // TypeDefIndex: 50169
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
			public StringIntern.FastId BATTLE_LIGHTNING_1; // 0xB4
			public StringIntern.FastId BATTLE_CANNON_1; // 0xB8
			public StringIntern.FastId BATTLE_CANNON_2; // 0xBC
			public StringIntern.FastId BATTLE_TURRET_1; // 0xC0
			public StringIntern.FastId BATTLE_TURRET_2; // 0xC4
			public StringIntern.FastId BATTLE_MEDIC_1; // 0xC8
			public StringIntern.FastId BATTLE_SHOCKWAVE_1; // 0xCC
			public StringIntern.FastId BATTLE_FROST_1; // 0xD0
			public StringIntern.FastId BATTLE_SNIPER_1; // 0xD4
			public StringIntern.FastId BATTLE_LASER_1; // 0xD8
			public StringIntern.FastId BATTLE_LASER_2; // 0xDC
			public StringIntern.FastId BATTLE_JET_1; // 0xE0
			public StringIntern.FastId BATTLE_TRAP_1; // 0xE4
			public StringIntern.FastId BATTLE_FOG_1; // 0xE8
			public StringIntern.FastId BATTLE_DEBUFF_1; // 0xEC
			public StringIntern.FastId BATTLE_ROCKET_1; // 0xF0
			public StringIntern.FastId BATTLE_TURRET_3; // 0xF4
			public StringIntern.FastId BATTLE_LIGHTNING_2; // 0xF8
			public StringIntern.FastId BATTLE_CANNON_1_DG002; // 0xFC
			public StringIntern.FastId V_FLUID_CONTAINER_1; // 0x100
			public StringIntern.FastId PUMP_1; // 0x104
			public StringIntern.FastId PUMP_2; // 0x108
			public StringIntern.FastId LIQUID_STORAGER_1; // 0x10C
			public StringIntern.FastId LIQUID_STORAGER_NOP_1; // 0x110
			public StringIntern.FastId MIX_POOL_1; // 0x114
			public StringIntern.FastId MIX_POOL_2; // 0x118
			public StringIntern.FastId SQUIRTER_1; // 0x11C
			public StringIntern.FastId SQUIRTER_NOP_1; // 0x120
			public StringIntern.FastId DUMPER_1; // 0x124
			public StringIntern.FastId DUMPER_NOP_1; // 0x128
			public StringIntern.FastId LIQUID_CLEANER_1; // 0x12C
			public StringIntern.FastId LIQUID_CLEAN_GATE_1; // 0x130
			public StringIntern.FastId LIQUID_RECYCLE_GATE_1; // 0x134
			public StringIntern.FastId XIRANITE_OVEN_1; // 0x138
			public StringIntern.FastId LIQUID_PURIFIER_1; // 0x13C
			public StringIntern.FastId DISMANTLER_1; // 0x140
			public StringIntern.FastId LOG_HONGS_BUS; // 0x144
			public StringIntern.FastId LOG_HONGS_BUS_SOURCE; // 0x148
			public StringIntern.FastId UDPIPE_LOADER_1; // 0x14C
			public StringIntern.FastId UDPIPE_LOADER_2; // 0x150
			public StringIntern.FastId UDPIPE_UNLOADER_1; // 0x154
			public StringIntern.FastId UDPIPE_UNLOADER_2; // 0x158
			public StringIntern.FastId VAPORIZER_1; // 0x15C
			public StringIntern.FastId TRANSMUTER_1; // 0x160
			public StringIntern.FastId TRANSMUTER_2; // 0x164
			public StringIntern.FastId GAS_REACTOR_1; // 0x168
			public StringIntern.FastId GAS_STORAGER_1; // 0x16C
			public StringIntern.FastId GAS_PUMP_1; // 0x170
			public StringIntern.FastId SP_HUB_1; // 0x174
			public StringIntern.FastId SP_SUB_HUB_1; // 0x178
			public StringIntern.FastId CARRIER_1; // 0x17C
			public StringIntern.FastId MARKER_1; // 0x180
			public StringIntern.FastId AIR_DANCER_1; // 0x184
			public StringIntern.FastId CHUBBY_LUNG_STONE_1; // 0x188
			public StringIntern.FastId CHUBBY_LUNG_BALLOON_1; // 0x18C
			public StringIntern.FastId PEAR_BLOSSOM_BONSAI_1; // 0x190
			public StringIntern.FastId JAIL_1; // 0x194
			public StringIntern.FastId PHOTO_FRAME_1; // 0x198
			public StringIntern.FastId SIGNBOARD_1; // 0x19C
			public StringIntern.FastId CAT_TREE_1; // 0x1A0
			public StringIntern.FastId DISPLAY_STAND_1; // 0x1A4
			public StringIntern.FastId MICROPHONE_1; // 0x1A8
		}
	
		private struct HolderContext // TypeDefIndex: 50170
		{
		}
	
		// Constructors
		static BuildingTemplateIds(); // 0x0000000184D4E490-0x0000000184D4E4F0
	
		// Methods
		public static void EnsureInit(); // 0x00000001843608B0-0x0000000184361860
	}

	[BurstCompile]
	public static class BurstBridge // TypeDefIndex: 50174
	{
		// Nested types
		public unsafe delegate void SamplePredictCargo_00000B99_PostfixBurstDelegate(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation); // TypeDefIndex: 50172; 0x0000000185FD2678-0x0000000185FD268C
	
		internal static class SamplePredictCargo_00000B99_BurstDirectCall // TypeDefIndex: 50173
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SamplePredictCargo_00000B99_BurstDirectCall(); // 0x0000000183FAEA10-0x0000000183FAEA20
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006c274); // 0x0000000186A697BC-0x0000000186A698C0
			private static IntPtr GetFunctionPointer(); // 0x0000000186A698C0-0x0000000186A69914
			public static void Constructor(); // 0x0000000183FB0510-0x0000000183FB05A0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation); // 0x0000000186A69914-0x0000000186A699DC
		}
	
		// Methods
		[BurstDiscard]
		public static void BeginProfilerSample(string name); // 0x0000000183344AC0-0x0000000183344B10
		[BurstDiscard]
		public static void EndProfilerSample(); // 0x0000000183344B10-0x0000000183344B60
		[BurstCompile]
		public static unsafe void SamplePredictCargo(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation); // 0x0000000186A62BD0-0x0000000186A62C50
		[BurstCompile]
		public static unsafe void SamplePredictCargo_BurstManaged(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation); // 0x0000000186A60A10-0x0000000186A62B54
	}

	[BurstCompile]
	public static class EntityExtensions // TypeDefIndex: 50181
	{
		// Nested types
		public delegate FacBuildingState QueryBuildingState_00000B9D_PostfixBurstDelegate(ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState); // TypeDefIndex: 50175; 0x00000001814F3120-0x00000001814F3140
	
		internal static class QueryBuildingState_00000B9D_BurstDirectCall // TypeDefIndex: 50176
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static QueryBuildingState_00000B9D_BurstDirectCall(); // 0x0000000183FAEA20-0x0000000183FAEA30
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006c321); // 0x0000000186A69504-0x0000000186A69608
			private static IntPtr GetFunctionPointer(); // 0x0000000186A69608-0x0000000186A6965C
			public static void Constructor(); // 0x0000000183FB05A0-0x0000000183FB0630
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static FacBuildingState Invoke(ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState); // 0x0000000186A6965C-0x0000000186A696F8
		}
	
		public delegate void SetFlashStatue_00000BB0_PostfixBurstDelegate(ref Entity logicEntity, ref EntityManager em, FacBuildingState statue); // TypeDefIndex: 50177; 0x0000000181546280-0x00000001815462A0
	
		internal static class SetFlashStatue_00000BB0_BurstDirectCall // TypeDefIndex: 50178
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SetFlashStatue_00000BB0_BurstDirectCall(); // 0x0000000183FAEA30-0x0000000183FAEA40
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006c330); // 0x0000000186A69B88-0x0000000186A69C8C
			private static IntPtr GetFunctionPointer(); // 0x0000000186A69C8C-0x0000000186A69CE0
			public static void Constructor(); // 0x0000000183FB0630-0x0000000183FB06C0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref Entity logicEntity, ref EntityManager em, FacBuildingState statue); // 0x0000000186A69CE0-0x0000000186A69D7C
		}
	
		public delegate void _SetRenderEntityFlashStatue_00000BB1_PostfixBurstDelegate(ref EntityManager em, ref Entity rendererEntity, byte statue); // TypeDefIndex: 50179; 0x0000000181546280-0x00000001815462A0
	
		internal static class _SetRenderEntityFlashStatue_00000BB1_BurstDirectCall // TypeDefIndex: 50180
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SetRenderEntityFlashStatue_00000BB1_BurstDirectCall(); // 0x0000000183FAEA40-0x0000000183FAEA50
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006c33f); // 0x0000000186A6AAB4-0x0000000186A6ABB8
			private static IntPtr GetFunctionPointer(); // 0x0000000186A6ABB8-0x0000000186A6AC0C
			public static void Constructor(); // 0x0000000183FB06C0-0x0000000183FB0750
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static void Invoke(ref EntityManager em, ref Entity rendererEntity, byte statue); // 0x0000000186A6AC0C-0x0000000186A6ACA8
		}
	
		// Methods
		private static FacBuildingState _QueryHubBuildingState(); // 0x0000000184D882B0-0x0000000184D882C0
		private static FacBuildingState _QuerySignBuildingState(); // 0x0000000184D882B0-0x0000000184D882C0
		private static unsafe FacBuildingState _QueryDepositBeaconBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x000000018152AB60-0x000000018152AC60
		private static unsafe FacBuildingState _QueryCollectorBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag, out FacBuildingSubState subState); // 0x0000000186A649F8-0x0000000186A64B70
		private static unsafe FacBuildingState _QueryOverrideWorkingBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000186A64CA4-0x0000000186A64DDC
		private static unsafe FacBuildingState _QueryWarehousePortBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000186A65640-0x0000000186A65714
		private static unsafe FacBuildingState _QueryStorageBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag, out FacBuildingSubState subState); // 0x0000000186A650B8-0x0000000186A651F4
		private static unsafe FacBuildingState _QueryFluidContainerBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag); // 0x0000000186A64B70-0x0000000186A64C2C
		private static unsafe FacBuildingState _QueryBattleBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000186A6473C-0x0000000186A6489C
		private static FacBuildingState _QueryDecorateBuildingState(); // 0x0000000184D882B0-0x0000000184D882C0
		private static FacBuildingState _QueryFreeBusBuildingState(ref Entity logicEntity, ref EntityManager em); // 0x0000000186A64C2C-0x0000000186A64CA4
		private static unsafe FacBuildingState _QueryUdPipeBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000186A65350-0x0000000186A654B4
		private static unsafe FacBuildingState _QueryProducerBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag, out FacBuildingSubState subState); // 0x0000000186A64EA8-0x0000000186A650B8
		private static unsafe FacBuildingState _QueryBurnPowerBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000186A6489C-0x0000000186A649F8
		private static unsafe FacBuildingState _QueryPowerPoleBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag); // 0x0000000186A64DDC-0x0000000186A64EA8
		private static unsafe FacBuildingState _QueryVaporizerBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, ChapterTagFragment* chapterTag, out FacBuildingSubState subState); // 0x0000000186A654B4-0x0000000186A65640
		private static unsafe FacBuildingState _QueryTransmuterBuildingState(ref Entity logicEntity, ref EntityManager em, UnitFragment* unitFrag, UnitConfigFragment* unitConfigFrag, ChapterTagFragment* chapterTag); // 0x0000000186A651F4-0x0000000186A65350
		private static bool _IsPowerBuilding(ref EntityManager em, ref Entity logicEntity); // 0x0000000186A64678-0x0000000186A6473C
		[BurstCompile]
		private static void _SetRenderEntityFlashStatue(ref EntityManager em, ref Entity rendererEntity, byte statue); // 0x0000000186A6596C-0x0000000186A659CC
		[BurstCompile]
		public static void _SetRenderEntityFlashStatue_BurstManaged(ref EntityManager em, ref Entity rendererEntity, byte statue); // 0x0000000186A65714-0x0000000186A6596C
	
		// Extension methods
		public static ref SharedDataContainer.SharedExtData GetExtData(this Entity entity, ref EntityManager em); // 0x0000000183056440-0x0000000183056800
		public static unsafe ref SharedDataContainer.SharedExtData GetExtData(this Entity entity, ref EntityManager em, SharedDataContainer.SharedExtData* sharedDataPtr); // 0x0000000186A63ACC-0x0000000186A63C88
		public static bool QueryBuildingStateIsClosed(this Entity logicEntity); // 0x0000000186A63DF8-0x0000000186A63EBC
		[BurstCompile]
		public static FacBuildingState QueryBuildingState(this ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState); // 0x0000000186A64208-0x0000000186A64268
		[BurstCompile]
		public static void SetFlashStatue(this ref Entity logicEntity, ref EntityManager em, FacBuildingState statue); // 0x0000000186A6444C-0x0000000186A644AC
		public static bool CulledWithLogicEntity(this Entity logicEntity, ref EntityManager em); // 0x0000000186A62C50-0x0000000186A62D50
		public static bool CulledWithRendererEntity(this Entity rendererEntity, ref EntityManager em); // 0x0000000186A62D50-0x0000000186A62E94
		[IDTag(1)]
		public static bool GetVisibility(this Entity logicEntity, Visibility.Type type); // 0x0000000186A63C88-0x0000000186A63D0C
		[IDTag(0)]
		public static bool GetVisibility(this Entity logicEntity, ref EntityManager em, Visibility.Type type); // 0x000000018392BEB0-0x000000018392BF80
		public static unsafe bool GetVisibility(this Entity logicEntity, ref EntityManager em, SharedDataContainer.SharedExtData* sharedDataPtr, Visibility.Type type); // 0x0000000186A63D0C-0x0000000186A63DC8
		[IDTag(0)]
		public static bool SetVisibility(this Entity logicEntity, ref EntityManager em, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short[] invisibleSubIndexList = null); // 0x000000018345D120-0x000000018345D230
		public static unsafe bool SetVisibility(this ref SharedDataContainer.SharedExtData extData, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short* subIndexListPtr = null, short subIndexCount = 0 /* Metadata: 0x0232ED8B */); // 0x000000018345D230-0x000000018345D400
		public static void SetVisibilityWithNotify(this Entity logicEntity, ref EntityManager em, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short[] invisibleSubIndexList = null); // 0x0000000186A644AC-0x0000000186A64678
		[IDTag(1)]
		public static bool SetVisibility(this Entity logicEntity, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, ref EntityCommandBuffer ecb); // 0x00000001834CCD40-0x00000001834CCF80
		public static void SetInMainRegion(this Entity logicEntity, bool value); // 0x0000000183051D00-0x0000000183051DA0
		public static bool IsInMainRegionFuzzy(this Entity logicEntity, ref EntityManager em); // 0x0000000184173F90-0x0000000184174020
		public static unsafe bool IsInMainRegion(this SharedDataFragment sharedData, SharedDataContainer.SharedExtData* sharedDataPtr); // 0x0000000186A63DC8-0x0000000186A63DF8
		public static void UpdatePipeEffect(this Entity logicEntity, ref EntityManager em); // 0x00000001834A5330-0x00000001834A63A0
		public static unsafe bool GetBuildingExtendConfig(this Entity logicEntity, ref EntityManager em, FixedString32Bytes extendKey, SharedDataContainer.SharedExtData* sharedDataPtr, out float3 pos, out quaternion rot, out Entity posRendererEntity); // 0x0000000186A62E94-0x0000000186A63140
		public static bool GetBuildingExtendConfig(this Entity logicEntity, ref EntityManager em, FixedString32Bytes extendKey, out float3 pos, out quaternion rot, out Entity posRendererEntity); // 0x0000000186A63140-0x0000000186A63438
		[IDTag(1)]
		public static bool GetBuildingStaticMountWorldTRS(this Entity entity, string extendKey, out float3 pos, out quaternion rot); // 0x0000000186A639F4-0x0000000186A63ACC
		[IDTag(0)]
		public static bool GetBuildingStaticMountWorldTRS(this Entity entity, ref EntityManager em, FixedString32Bytes extendKey, out float3 pos, out quaternion rot); // 0x0000000186A63438-0x0000000186A63740
		public static unsafe bool GetBuildingStaticMountWorldTRS(this Entity entity, ref EntityManager em, FixedString32Bytes extendKey, SharedDataContainer.SharedExtData* sharedDataPtr, out float3 pos, out quaternion rot); // 0x0000000186A63740-0x0000000186A639F4
		[BurstCompile]
		public static FacBuildingState QueryBuildingState_BurstManaged(this ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState); // 0x0000000186A63EBC-0x0000000186A64208
		[BurstCompile]
		public static void SetFlashStatue_BurstManaged(this ref Entity logicEntity, ref EntityManager em, FacBuildingState statue); // 0x0000000186A64268-0x0000000186A6444C
	}

	public static class GameplayExtensions // TypeDefIndex: 50182
	{
		// Extension methods
		[Conditional("UNITY_EDITOR")]
		public static void FacUnitAssertComponent<T>(this EntityManager em, Entity entity)
			where T : struct, IComponentECS;
		public static ref ChapterFragment GetChapterEntity(this EntityManager em, int chapterId, out bool existed, out Entity chapterEntity); // 0x00000001836B9090-0x00000001836BA3D0
	}

	public static class GlobalEnvExtensions // TypeDefIndex: 50183
	{
		// Extension methods
		public static unsafe GlobalEnv* GetGlobalEnv(this EntityManager em); // 0x00000001834CF5B0-0x00000001834CF820
		public static IntPtr GetGlobalEnvPtr(this EntityManager em); // 0x0000000186A65C6C-0x0000000186A65CD0
		public static bool IsGlobalEnvValid(this EntityManager em); // 0x00000001834CF270-0x00000001834CF2E0
		public static ref GlobalEnv GetGlobalEnvRef(this EntityManager em); // 0x00000001834CF2E0-0x00000001834CF5B0
		public static void SetNearBuildingPtr(this ref GlobalEnv env, ref InteractFacCollectJob.BuildingInfo info, ref InteractFacCollectJob.BuildingInfo infoLast); // 0x0000000184B2C7F0-0x0000000184B2C840
		public static void SetNearConveyorPtr(this ref GlobalEnv env, ref InteractFacCollectJob.LogisticInfo info, ref InteractFacCollectJob.LogisticInfo infoLast); // 0x0000000184B2C840-0x0000000184B2C890
		public static void SetNearPipePtr(this ref GlobalEnv env, ref InteractFacCollectJob.LogisticInfo info, ref InteractFacCollectJob.LogisticInfo infoLast); // 0x0000000184B2C890-0x0000000184B2C8E0
		public static bool GetInteractFac(this ref GlobalEnv env, out InteractFacCollectJob.BuildingInfo info); // 0x0000000183D46F10-0x0000000183D46FB0
		public static bool GetInteractConveyor(this ref GlobalEnv env, out InteractFacCollectJob.LogisticInfo info); // 0x0000000183D46EA0-0x0000000183D46F10
		public static bool GetInteractPipe(this ref GlobalEnv env, out InteractFacCollectJob.LogisticInfo info); // 0x0000000183D46E40-0x0000000183D46EA0
	}

	public interface IAllocator : IDisposable // TypeDefIndex: 50184
	{
		// Methods
		LinearAllocator.Allocation Allocate(int size);
		void Reserve(int newCapacity);
		LinearAllocator.Allocation Expand(int startIndex, int additionalSize);
		LinearAllocator.Allocation Resize(int startIndex, int newSize);
		void Free(int startIndex);
	}

	public class LinearAllocator : Beyond.Gameplay.Factory.Unsafe.IAllocator // TypeDefIndex: 50187
	{
		// Fields
		private const int INITIAL_CAPACITY = 512; // Metadata: 0x0232ED8F
		private int m_totalCapacity; // 0x10
		private unsafe byte* m_memory; // 0x18
		[CompilerGenerated]
		private readonly Dictionary<int, int> _freeBlocks_k__BackingField; // 0x20
		private readonly Dictionary<int, int> m_allocations; // 0x28
	
		// Properties
		public Dictionary<int, int> freeBlocks { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
		// Nested types
		public struct Allocation // TypeDefIndex: 50185
		{
			// Fields
			public int start; // 0x00
			public int end; // 0x04
			public bool reallocated; // 0x08
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 50186
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<int, int>, int> __9__10_0; // 0x08
			public static Func<KeyValuePair<int, int>, int> __9__10_1; // 0x10
			public static Func<KeyValuePair<int, int>, int> __9__18_0; // 0x18
			public static Func<KeyValuePair<int, int>, int> __9__18_1; // 0x20
	
			// Constructors
			static __c(); // 0x0000000186A6A714-0x0000000186A6A778
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _Allocate_b__10_0(KeyValuePair<int, int> b); // 0x0000000186A6A5F4-0x0000000186A6A624
			internal int _Allocate_b__10_1(KeyValuePair<int, int> b); // 0x0000000186A6A624-0x0000000186A6A654
			internal int _PrintAllocations_b__18_0(KeyValuePair<int, int> a); // 0x0000000186A6A654-0x0000000186A6A684
			internal int _PrintAllocations_b__18_1(KeyValuePair<int, int> b); // 0x0000000186A6A684-0x0000000186A6A6B4
		}
	
		// Constructors
		public LinearAllocator(int capacity = 512 /* Metadata: 0x0232ED8D */); // 0x0000000186A69414-0x0000000186A69504
	
		// Methods
		private void _ExpandMemory(); // 0x0000000186A6911C-0x0000000186A69278
		public Allocation Allocate(int size); // 0x0000000186A670E0-0x0000000186A67964
		public void Reserve(int newCapacity); // 0x0000000186A68B28-0x0000000186A68C30
		public Allocation Expand(int startIndex, int additionalSize); // 0x0000000186A67A18-0x0000000186A67DC4
		public Allocation Resize(int startIndex, int newSize); // 0x0000000186A68C30-0x0000000186A6911C
		private void _MergeAdjacentFreeBlocks(); // 0x0000000186A69278-0x0000000186A69414
		public void Free(int startIndex); // 0x0000000186A67E34-0x0000000186A68234
		public unsafe void* GetPointer(int offset); // 0x0000000184D8D020-0x0000000184D8D030
		public void Dispose(); // 0x0000000186A67964-0x0000000186A67A18
		public void PrintAllocations(); // 0x0000000186A68234-0x0000000186A68B28
		~LinearAllocator(); // 0x0000000186A67DC4-0x0000000186A67E34
	}

	public struct LinearAllocatorUnmanaged : Beyond.Gameplay.Factory.Unsafe.IAllocator // TypeDefIndex: 50189
	{
		// Fields
		private const int INITIAL_CAPACITY = 512; // Metadata: 0x0232ED94
		private int m_totalCapacity; // 0x00
		private unsafe byte* m_memory; // 0x08
		[CompilerGenerated]
		private NativeParallelHashMap<int, int> _freeBlocks_k__BackingField; // 0x10
		private NativeParallelHashMap<int, int> m_allocations; // 0x20
		private bool m_initialized; // 0x30
		private Unity.Collections.Allocator m_allocator; // 0x34
	
		// Properties
		public NativeParallelHashMap<int, int> freeBlocks { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2D510-0x0000000182B2D520 0x0000000184D8C980-0x0000000184D8C990
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 50188
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<int, int>, int> __9__20_1; // 0x08
			public static Func<KeyValuePair<int, int>, int> __9__20_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000186A6A778-0x0000000186A6A7DC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _PrintAllocations_b__20_1(KeyValuePair<int, int> a); // 0x0000000186A6A6E4-0x0000000186A6A714
			internal int _PrintAllocations_b__20_0(KeyValuePair<int, int> b); // 0x0000000186A6A6B4-0x0000000186A6A6E4
		}
	
		// Methods
		public void Initialize(int capacity = 512 /* Metadata: 0x0232ED91 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232ED93 */); // 0x0000000183B6DD30-0x0000000183B6DEB0
		private void _ExpandMemory(); // 0x0000000183B281C0-0x0000000183B28310
		public LinearAllocator.Allocation Allocate(int size); // 0x0000000183B29750-0x0000000183B29FE0
		public void Reserve(int newCapacity); // 0x0000000186A66DB4-0x0000000186A66EC4
		public LinearAllocator.Allocation Expand(int startIndex, int additionalSize); // 0x0000000186A65E60-0x0000000186A66128
		public LinearAllocator.Allocation Resize(int startIndex, int newSize); // 0x0000000186A66EC4-0x0000000186A670E0
		private void _MergeAdjacentFreeBlocks(); // 0x0000000183B28310-0x0000000183B28810
		public void Free(int startIndex); // 0x0000000186A66128-0x0000000186A66210
		public unsafe void* GetPointer(long offset); // 0x0000000183B5AE80-0x0000000183B5AF10
		public void Dispose(); // 0x0000000186A65D64-0x0000000186A65E60
		public void PrintAllocations(); // 0x0000000186A66210-0x0000000186A66DB4
	}

	internal struct TLSFBlockHeader // TypeDefIndex: 50190
	{
		// Fields
		public const int ALIGNMENT = 8; // Metadata: 0x0232ED96
		public unsafe TLSFBlockHeader* prev; // 0x00
		public unsafe TLSFBlockHeader* next; // 0x08
		public unsafe TLSFBlockHeader* prePhys; // 0x10
		public uint size; // 0x18
		public bool isFree; // 0x1C
	}

	public class TLSFAllocator // TypeDefIndex: 50191
	{
		// Fields
		private const int FIRST_LEVEL_INDEX_COUNT = 32; // Metadata: 0x0232ED97
		private const int SECOND_LEVEL_INDEX_COUNT = 32; // Metadata: 0x0232ED98
		private const int SMALL_BLOCK_SIZE = 256; // Metadata: 0x0232ED99
		private const int ALIGNMENT = 8; // Metadata: 0x0232ED9B
		private uint _flBitmap; // 0x10
		private uint[] _slBitmap; // 0x18
		private unsafe TLSFBlockHeader*[,] _freeList; // 0x20
		private IntPtr _memoryPool; // 0x28
		private uint _poolSize; // 0x30
		private unsafe TLSFBlockHeader* _firstBlock; // 0x38
	
		// Constructors
		public TLSFAllocator(uint size); // 0x0000000186A6A4D0-0x0000000186A6A5F4
	
		// Methods
		~TLSFAllocator(); // 0x0000000186A69EA4-0x0000000186A69F5C
		public unsafe void* Allocate(uint size); // 0x0000000186A69E38-0x0000000186A69EA4
		public unsafe void Free(void* ptr); // 0x0000000186A6A008-0x0000000186A6A044
		public uint GetFreeSpace(); // 0x0000000186A6A044-0x0000000186A6A0E0
		private unsafe TLSFBlockHeader* FindSuitableBlock(uint size); // 0x0000000186A69F5C-0x0000000186A6A008
		private unsafe void InsertFreeBlock(TLSFBlockHeader* block); // 0x0000000186A6A0E0-0x0000000186A6A1DC
		private unsafe void RemoveFreeBlock(TLSFBlockHeader* block); // 0x0000000186A6A368-0x0000000186A6A460
		private unsafe void SplitBlock(TLSFBlockHeader* block, uint size); // 0x0000000186A6A460-0x0000000186A6A4D0
		private unsafe TLSFBlockHeader* MergeBlock(TLSFBlockHeader* block); // 0x0000000186A6A284-0x0000000186A6A368
		private void MappingInsert(uint size, out int fl, out int sl); // 0x0000000186A6A1DC-0x0000000186A6A284
		private static int MostSignificantBit(uint value); // 0x0000000186A62B74-0x0000000186A62BD0
		private static int FindFirstSet(uint value); // 0x0000000186A62B54-0x0000000186A62B74
		private static uint AlignSize(uint size); // 0x0000000184D8D030-0x0000000184D8D040
	}

	public class FactoryUnsafeUtil // TypeDefIndex: 50192
	{
		// Fields
		private const uint NO_NODE_ID_RANGE_MIN = 4000000000; // Metadata: 0x0232ED9D
		private const uint NO_NODE_ID_RANGE_MAX = 4294967294; // Metadata: 0x0232EDA2
		private static uint s_nodeId; // 0x00
	
		// Constructors
		public FactoryUnsafeUtil(); // 0x00000001841E1670-0x00000001841E1680
		static FactoryUnsafeUtil(); // 0x0000000184D7A8D0-0x0000000184D7A910
	
		// Methods
		public static bool IsManualNodeId(uint id); // 0x0000000186A659CC-0x0000000186A659E0
		public static uint AllocManualNodeId(); // 0x000000018392B170-0x000000018392B210
		public static bool IsPointInSector(float3 point, float3 center, float3 dir, float checkRad, float checkDist, out float curDistanceSq, out float curCosTheta, bool ignoreY = true /* Metadata: 0x0232ED9C */); // 0x0000000186A659E0-0x0000000186A65C6C
		public static unsafe void SwapPointer<T>(ref ref T* p1, ref ref T* p2)
			where T : struct;
		public static IntPtr AddressOf(ref GlobalEnv env); // 0x0000000183924DC0-0x0000000183924DF0
		public static void CallFromLuaCheck(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class StructMarshal // TypeDefIndex: 50193
	{
		// Methods
		public static byte[] StructToBytes<T>(T str)
			where T : struct;
		public static byte[] UnmanagedStructToBytes<T>(T value)
			where T : struct;
		public static T BytesToStruct<T>(byte[] bytes, int offset)
			where T : struct;
		public static T BytesToUnmanagedStruct<T>(byte[] bytes, int offset = 0 /* Metadata: 0x0232EDA3 */)
			where T : struct;
		public static byte[] FixedList512BytesToBytes<T>([IsReadOnly] in FixedList512Bytes<T> list)
			where T : struct;
		public static FixedList512Bytes<T> BytesToFixedList512Bytes<T>([IsReadOnly] in byte[] bytes)
			where T : struct;
	}
}

namespace Beyond.Gameplay.Factory.Util
{
	public static class JobHandlerExtensions // TypeDefIndex: 50166
	{
		// Extension methods
		public static void SafeComplete(this JobHandle jobHandle); // 0x00000001869FCD78-0x00000001869FCDE0
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond // TypeDefIndex: 49584
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime(); // 0x0000000184CE2260-0x0000000184CE2290
		private static void Initialize(); // 0x0000000184CE2290-0x0000000184CE2310
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 49585
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 49586
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 49587
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 49588
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 49589
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace FactoryUIAtlas
{
	public class FactoryLiquidAtlasSOData : ScriptableObject // TypeDefIndex: 49546
	{
		// Fields
		public SerializeFieldDictionary<string, FacItemSubType> m_liquidMaterial; // 0x18
		public SerializeFieldDictionary<FacItemSubType, int> m_liquidMatIndex; // 0x20
	
		// Constructors
		public FactoryLiquidAtlasSOData(); // 0x0000000184B0B9E0-0x0000000184B0BC30
	
		// Methods
		public bool GetMaterial(string mat, out FacItemSubType matName); // 0x00000001869B8AFC-0x00000001869B8B60
		public bool GetAtlasMaterialSort(FacItemSubType matName, out int sort); // 0x00000001869B8A98-0x00000001869B8AFC
		public static FactoryLiquidAtlasSOData CreateOrGet(string path); // 0x00000001869B89B4-0x00000001869B8A98
	}

	public class FactoryUIAtlasSOData : ScriptableObject // TypeDefIndex: 49547
	{
		// Fields
		public SerializeFieldDictionary<string, RectInt> m_insertName; // 0x18
		public SerializeFieldDictionary<string, int> m_insertIndex; // 0x20
	
		// Constructors
		public FactoryUIAtlasSOData(); // 0x0000000184990BF0-0x0000000184990CC0
	
		// Methods
		public bool GetRect(string texName, out RectInt rect); // 0x000000018331C0A0-0x000000018331C100
		public bool GetIndex(string texName, out int index); // 0x00000001836BB210-0x00000001836BB2B0
		public static FactoryUIAtlasSOData CreateOrGet(string path); // 0x00000001869B8B60-0x00000001869B8C44
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 49545
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 50197
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37410-0x0000000184D37480
	
		// Methods
		public int __Gen_Wrap_0(object P0); // 0x0000000186360E84-0x0000000186360F54
		public NativeArray<int> __Gen_Wrap_1(object P0); // 0x0000000186A0A5E4-0x0000000186A0A6DC
		public object __Gen_Wrap_2(int P0); // 0x0000000186A13B88-0x0000000186A13C74
		public void __Gen_Wrap_3(); // 0x00000001863625A4-0x0000000186362640
		public void __Gen_Wrap_4(ref PerDrawConfig P0); // 0x0000000186A2B160-0x0000000186A2B2C0
		public void __Gen_Wrap_5(ref FFactoryStateColorConfig P0); // 0x0000000186A36B2C-0x0000000186A36C64
		public void __Gen_Wrap_6(object P0); // 0x00000001863633B4-0x0000000186363474
		public NativeArray<ComponentType> __Gen_Wrap_7(); // 0x0000000186A5035C-0x0000000186A5044C
		public NativeArray<ComponentType> __Gen_Wrap_8(NativeArray<ComponentType> P0, object P1); // 0x0000000186A5BAA4-0x0000000186A5BBF0
		public NativeArray<ComponentType> __Gen_Wrap_9(object P0); // 0x0000000186A60904-0x0000000186A60A10
		public void __Gen_Wrap_10(ref BlueprintSlotContainer P0); // 0x00000001869FF6CC-0x00000001869FF820
		public uint __Gen_Wrap_11(ref BlueprintSlotContainer P0, ref BlueprintSlotInfo P1); // 0x0000000186A00908-0x0000000186A00B64
		public void __Gen_Wrap_12(ref BlueprintSlotContainer P0, uint P1); // 0x0000000186A01F60-0x0000000186A020C0
		public ref BlueprintSlotInfo __Gen_Wrap_13(ref BlueprintSlotContainer P0, uint P1); // 0x0000000186A031E4-0x0000000186A03374
		public void __Gen_Wrap_14(ref ConveyorExtContainer P0); // 0x0000000186A04284-0x0000000186A043D8
		public uint __Gen_Wrap_15(ref ConveyorExtContainer P0); // 0x0000000186A05198-0x0000000186A052EC
		public Span<ConveyorExtContainer.ConveyorExt> __Gen_Wrap_16(ref ConveyorExtContainer P0); // 0x0000000186A066C8-0x0000000186A06848
		public uint __Gen_Wrap_17(ref ConveyorExtContainer P0, ref ConveyorExtContainer.ConveyorExt P1); // 0x0000000186A07990-0x0000000186A07B80
		public void __Gen_Wrap_18(ref ConveyorExtContainer P0, uint P1); // 0x0000000186A08A1C-0x0000000186A08B8C
		public IntPtr __Gen_Wrap_19(ref ConveyorExtContainer P0); // 0x0000000186A0A480-0x0000000186A0A5E4
		public ref ConveyorExtContainer.ConveyorExt __Gen_Wrap_20(ref ConveyorExtContainer P0, int P1); // 0x0000000186A0B2F0-0x0000000186A0B470
		public ref ConveyorExtContainer.ConveyorExt __Gen_Wrap_21(ref ConveyorExtContainer P0, uint P1); // 0x0000000186A0C004-0x0000000186A0C194
		public void __Gen_Wrap_22(ref ConveyorExtContainer.ConveyorExt P0); // 0x0000000186A0CF7C-0x0000000186A0D0C0
		public void __Gen_Wrap_23(ref LinearAllocatorUnmanaged P0); // 0x0000000186A0DE6C-0x0000000186A0DFD4
		public LinearAllocator.Allocation __Gen_Wrap_24(ref LinearAllocatorUnmanaged P0, int P1); // 0x0000000186A0ECDC-0x0000000186A0EEA0
		public LinearAllocator.Allocation __Gen_Wrap_25(ref ConveyorInfoAllocator P0, int P1); // 0x0000000186A103FC-0x0000000186A105C0
		public void __Gen_Wrap_26(ref LinearAllocatorUnmanaged P0, int P1); // 0x0000000186A1113C-0x0000000186A112BC
		public LinearAllocator.Allocation __Gen_Wrap_27(ref LinearAllocatorUnmanaged P0, int P1, int P2); // 0x0000000186A11E94-0x0000000186A12058
		public LinearAllocator.Allocation __Gen_Wrap_28(ref ConveyorInfoAllocator P0, LinearAllocator.Allocation P1, int P2); // 0x0000000186A12C34-0x0000000186A12E24
		public void __Gen_Wrap_29(ref ConveyorInfoAllocator P0, uint P1); // 0x0000000186A13A08-0x0000000186A13B88
		public long __Gen_Wrap_30(ref ConveyorInfoAllocator P0, uint P1); // 0x0000000186A14F7C-0x0000000186A150FC
		public int __Gen_Wrap_31(KeyValuePair<int, int> P0); // 0x0000000186A15F10-0x0000000186A16004
		public void __Gen_Wrap_32(ref ConveyorInfoAllocator P0); // 0x0000000186A17254-0x0000000186A173A8
		public void __Gen_Wrap_33(ref SharedDataContainer P0); // 0x0000000186A18978-0x0000000186A18ACC
		public uint __Gen_Wrap_34(ref SharedDataContainer P0); // 0x0000000186A1A5B8-0x0000000186A1A71C
		public Span<SharedDataContainer.SharedExtData> __Gen_Wrap_35(ref SharedDataContainer P0); // 0x0000000186A1B420-0x0000000186A1B5A0
		public uint __Gen_Wrap_36(ref SharedDataContainer P0, ref SharedDataContainer.SharedExtData P1); // 0x0000000186A1C3C0-0x0000000186A1C5D4
		public void __Gen_Wrap_37(ref SharedDataContainer P0, uint P1); // 0x0000000186A1D790-0x0000000186A1D900
		public IntPtr __Gen_Wrap_38(ref SharedDataContainer P0); // 0x0000000186A1F1B0-0x0000000186A1F314
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_39(ref SharedDataContainer P0, int P1); // 0x0000000186A20FE8-0x0000000186A21168
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_40(ref SharedDataContainer P0, uint P1); // 0x0000000186A21E8C-0x0000000186A2201C
		public bool __Gen_Wrap_41(ref Visibility P0, Visibility.EFlag P1); // 0x0000000186A23200-0x0000000186A23370
		public bool __Gen_Wrap_42(ref Visibility P0); // 0x0000000186A24240-0x0000000186A24394
		public bool __Gen_Wrap_43(ref SharedDataContainer.SharedExtData P0); // 0x0000000186A2500C-0x0000000186A25174
		public bool __Gen_Wrap_44(ref SharedDataContainer.SharedExtData P0, SharedDataContainer.DirtyFlag P1); // 0x0000000186A25EA4-0x0000000186A26014
		public void __Gen_Wrap_45(ref SharedDataContainer.SharedExtData P0, SharedDataContainer.DirtyFlag P1, bool P2); // 0x0000000186A26CF8-0x0000000186A26E88
		public float3 __Gen_Wrap_46(ref WireRendererInfo P0); // 0x0000000186A27ED4-0x0000000186A28058
		public quaternion __Gen_Wrap_47(ref WireRendererInfo P0); // 0x0000000186A28F34-0x0000000186A290B0
		public float __Gen_Wrap_48(ref WireRendererInfo P0); // 0x0000000186A2A1B0-0x0000000186A2A300
		public NativeParallelHashMap<UnitId, Entity> __Gen_Wrap_49(object P0); // 0x0000000186A2B068-0x0000000186A2B160
		public UnitId __Gen_Wrap_50(int P0, uint P1); // 0x0000000186A2BDBC-0x0000000186A2BEC4
		public void __Gen_Wrap_51(object P0, int P1, uint P2, Entity P3); // 0x0000000186A2CC9C-0x0000000186A2CDD4
		public bool __Gen_Wrap_52(object P0, int P1, uint P2); // 0x0000000186A2DAF8-0x0000000186A2DBFC
		public bool __Gen_Wrap_53(object P0, int P1, uint P2, out Entity P3); // 0x0000000186A2F058-0x0000000186A2F1B4
		public FactoryEventChannels __Gen_Wrap_54(); // 0x0000000186A30124-0x0000000186A30290
		public void __Gen_Wrap_55(ref GlobalEnv P0); // 0x0000000186A30F94-0x0000000186A311DC
		public void __Gen_Wrap_56(ref FactoryEventChannels P0); // 0x0000000186A3214C-0x0000000186A32374
		public bool __Gen_Wrap_57(ref GlobalEnv P0); // 0x0000000186A335D4-0x0000000186A3382C
		public NativeArray<EvtStatusChange> __Gen_Wrap_58(ref GlobalEnv P0); // 0x0000000186A34CC8-0x0000000186A34F48
		public NativeArray<EvtAudio> __Gen_Wrap_59(ref GlobalEnv P0); // 0x0000000186A368AC-0x0000000186A36B2C
		public NativeArray<EvtChangeTemplate> __Gen_Wrap_60(ref GlobalEnv P0); // 0x0000000186A37BAC-0x0000000186A37E2C
		public NativeArray<EvtUpdatePipeEffect> __Gen_Wrap_61(ref GlobalEnv P0); // 0x0000000186A39354-0x0000000186A395D4
		public NativeArray<EvtCreateUnitRenderer> __Gen_Wrap_62(ref GlobalEnv P0); // 0x0000000186A3AF84-0x0000000186A3B204
		public NativeArray<EvtVatUpdate> __Gen_Wrap_63(ref GlobalEnv P0); // 0x0000000186A3CA44-0x0000000186A3CCC4
		public NativeArray<EvtUpdateStatusEffect> __Gen_Wrap_64(ref GlobalEnv P0); // 0x0000000186A3E080-0x0000000186A3E300
		public NativeArray<EvtUpdateRendererProperty> __Gen_Wrap_65(ref GlobalEnv P0); // 0x0000000186A3F3BC-0x0000000186A3F63C
		public NativeArray<EvtUpdatePedestalColorLUT> __Gen_Wrap_66(ref GlobalEnv P0); // 0x0000000186A405E0-0x0000000186A40860
		public NativeArray<EvtCreateInteract> __Gen_Wrap_67(ref GlobalEnv P0); // 0x0000000186A41CF0-0x0000000186A41F70
		public NativeArray<EvtPendingCreateRenderer> __Gen_Wrap_68(ref GlobalEnv P0); // 0x0000000186A42F2C-0x0000000186A431AC
		public void __Gen_Wrap_69(ref GlobalEnv P0, int P1); // 0x0000000186A441CC-0x0000000186A44428
		public EventChannel<EvtVatUpdate> __Gen_Wrap_70(ref GlobalEnv P0); // 0x0000000186A45760-0x0000000186A459EC
		public EventChannel<EvtUpdateStatusEffect> __Gen_Wrap_71(ref GlobalEnv P0); // 0x0000000186A46DC0-0x0000000186A4704C
		public EventChannel<EvtAudio> __Gen_Wrap_72(ref GlobalEnv P0); // 0x0000000186A48114-0x0000000186A483A0
		public int __Gen_Wrap_73(); // 0x00000001863621C4-0x0000000186362270
		public FacBoneTRSBinary __Gen_Wrap_74(); // 0x0000000186A4A634-0x0000000186A4A700
		public bool __Gen_Wrap_75(object P0); // 0x00000001863632E4-0x00000001863633B4
		public bool __Gen_Wrap_76(object P0, int P1, ulong P2, uint P3, out Matrix4x4 P4); // 0x0000000186A4CD8C-0x0000000186A4CF18
		public void __Gen_Wrap_77(ref VATFSMDefinitionContainer P0); // 0x0000000186A4E098-0x0000000186A4E1EC
		public uint __Gen_Wrap_78(); // 0x00000001863621C4-0x0000000186362270
		public void __Gen_Wrap_79(uint P0); // 0x000000018635FF24-0x000000018635FFE4
		public ref ConveyorExtContainer.ConveyorExt __Gen_Wrap_80(uint P0); // 0x0000000186A5155C-0x0000000186A51648
		public IntPtr __Gen_Wrap_81(); // 0x000000018635FE78-0x000000018635FF24
		public uint __Gen_Wrap_82(bool P0); // 0x0000000186A53AF0-0x0000000186A53BC0
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_83(uint P0); // 0x0000000186A54834-0x0000000186A54920
		public ref EntityHierarchyContainer.EntityTransformData __Gen_Wrap_84(uint P0); // 0x0000000186A558B0-0x0000000186A5599C
		public ref EntityHierarchyContainer.EntityTransformData __Gen_Wrap_85(int P0); // 0x0000000186A56E3C-0x0000000186A56F28
		public float4x4 __Gen_Wrap_86(ref LocalTransform P0); // 0x0000000186A58158-0x0000000186A582EC
		public float4x4 __Gen_Wrap_87(in EntityHierarchyContainer.EntityTransformData P0); // 0x0000000186A59574-0x0000000186A596D8
		public uint __Gen_Wrap_88(ref VATFSMDefinitionContainer P0, ref VATFSMDefinition P1); // 0x0000000186A5A64C-0x0000000186A5A860
		public uint __Gen_Wrap_89(ref VATFSMDefinition P0); // 0x0000000186A5B93C-0x0000000186A5BAA4
		public ref VATFSMDefinition __Gen_Wrap_90(ref VATFSMDefinitionContainer P0, uint P1); // 0x0000000186A5D01C-0x0000000186A5D1AC
		public ref VATFSMDefinition __Gen_Wrap_91(uint P0); // 0x0000000186A5DC28-0x0000000186A5DD14
		public void __Gen_Wrap_92(ref VATFSMDefinitionContainer P0, uint P1); // 0x0000000186A5EE98-0x0000000186A5EFF8
		public IntPtr __Gen_Wrap_93(ref VATFSMDefinitionContainer P0); // 0x0000000186A5FEE4-0x0000000186A60048
		public BlueprintSlotInfo __Gen_Wrap_94(); // 0x0000000186A60184-0x0000000186A602B8
		public ref BlueprintSlotInfo __Gen_Wrap_95(uint P0); // 0x0000000186A602B8-0x0000000186A603A4
		public int __Gen_Wrap_96(ref ActivatorCostFragment P0); // 0x0000000186A603A4-0x0000000186A604F8
		public void __Gen_Wrap_97(ref ActivatorCostFragment P0); // 0x0000000186A604F8-0x0000000186A60628
		public AdditiveEffectFragment.AdditiveEffectType __Gen_Wrap_98(ref AdditiveEffectFragment P0); // 0x0000000186A60628-0x0000000186A60790
		public void __Gen_Wrap_99(ref AdditiveEffectFragment P0, AdditiveEffectFragment.AdditiveEffectType P1); // 0x0000000186A60790-0x0000000186A60904
		public void __Gen_Wrap_100(ref AdditiveEffectFragment P0); // 0x00000001869FE740-0x00000001869FE898
		public void __Gen_Wrap_101(ref AdditiveEffectFragment P0, int P1, AdditiveEffectFragment.AdditiveEffectType P2); // 0x00000001869FE898-0x00000001869FEA28
		public string __Gen_Wrap_102(ref AdditiveEffectFragment P0); // 0x00000001869FEA28-0x00000001869FEBA0
		public void __Gen_Wrap_103(ref CutoffState P0, bool P1); // 0x00000001869FEBA0-0x00000001869FECE0
		public void __Gen_Wrap_104(ref CutoffState P0, float P1); // 0x00000001869FECE0-0x00000001869FEE30
		public void __Gen_Wrap_105(ref CutoffState P0, uint P1); // 0x00000001869FEE30-0x00000001869FEF6C
		public void __Gen_Wrap_106(ref BuildDismissState P0, bool P1); // 0x00000001869FEF6C-0x00000001869FF0BC
		public void __Gen_Wrap_107(ref HighLightState P0, bool P1); // 0x00000001869FF0BC-0x00000001869FF2C4
		public void __Gen_Wrap_108(ref HighLightState P0, bool P1, bool P2); // 0x00000001869FF2C4-0x00000001869FF4E0
		public LogicEntityState __Gen_Wrap_109(ref HighLightState P0); // 0x00000001869FF4E0-0x00000001869FF6CC
		public bool __Gen_Wrap_110(ref HighLightState P0, byte P1); // 0x00000001869FF820-0x00000001869FFA28
		public void __Gen_Wrap_111(ref HighLightState P0, byte P1, bool P2); // 0x00000001869FFA28-0x00000001869FFC44
		public void __Gen_Wrap_112(ref HighLightState P0); // 0x00000001869FFC44-0x00000001869FFE30
		public void __Gen_Wrap_113(ref HintState P0, bool P1); // 0x00000001869FFE30-0x00000001869FFF7C
		public void __Gen_Wrap_114(ref FigureState P0, bool P1); // 0x00000001869FFF7C-0x0000000186A000C8
		public void __Gen_Wrap_115(ref OverloadState P0, bool P1); // 0x0000000186A000C8-0x0000000186A00214
		public void __Gen_Wrap_116(ref OverloadInvalidState P0, bool P1); // 0x0000000186A00214-0x0000000186A00360
		public void __Gen_Wrap_117(ref DitherState P0, bool P1); // 0x0000000186A00360-0x0000000186A00494
		public void __Gen_Wrap_118(ref BlueprintState P0, bool P1); // 0x0000000186A00494-0x0000000186A006C0
		public void __Gen_Wrap_119(ref BlueprintState P0, bool P1, BlueprintState.EffectType P2); // 0x0000000186A006C0-0x0000000186A00908
		public bool __Gen_Wrap_120(ref BlueprintState P0, byte P1); // 0x0000000186A00B64-0x0000000186A00D90
		public void __Gen_Wrap_121(ref BlueprintState P0, byte P1, bool P2); // 0x0000000186A00D90-0x0000000186A00FD8
		public void __Gen_Wrap_122(ref BlueprintState P0); // 0x0000000186A00FD8-0x0000000186A011F0
		public void __Gen_Wrap_123(ref PreSelectState P0, bool P1); // 0x0000000186A011F0-0x0000000186A013FC
		public bool __Gen_Wrap_124(ref PreSelectState P0, byte P1); // 0x0000000186A013FC-0x0000000186A01608
		public void __Gen_Wrap_125(ref PreSelectState P0, byte P1, bool P2); // 0x0000000186A01608-0x0000000186A01830
		public void __Gen_Wrap_126(ref PreSelectState P0); // 0x0000000186A01830-0x0000000186A01A28
		public bool __Gen_Wrap_127(ref SoloSelectState P0); // 0x0000000186A01A28-0x0000000186A01BD8
		public void __Gen_Wrap_128(ref SoloSelectState P0, bool P1); // 0x0000000186A01BD8-0x0000000186A01D94
		public bool __Gen_Wrap_129(ref SoloSelectState P0, byte P1); // 0x0000000186A01D94-0x0000000186A01F60
		public void __Gen_Wrap_130(ref SoloSelectState P0, object P1, bool P2); // 0x0000000186A020C0-0x0000000186A02298
		public void __Gen_Wrap_131(ref SoloSelectState P0, Span<byte> P1, bool P2); // 0x0000000186A02298-0x0000000186A02494
		public void __Gen_Wrap_132(ref SoloSelectState P0); // 0x0000000186A02494-0x0000000186A02634
		public void __Gen_Wrap_133(ref ContinuationState P0, bool P1); // 0x0000000186A02634-0x0000000186A02840
		public bool __Gen_Wrap_134(ref ContinuationState P0, byte P1); // 0x0000000186A02840-0x0000000186A02A4C
		public void __Gen_Wrap_135(ref ContinuationState P0, byte P1, bool P2); // 0x0000000186A02A4C-0x0000000186A02C60
		public void __Gen_Wrap_136(ref ContinuationState P0); // 0x0000000186A02C60-0x0000000186A02E44
		public void __Gen_Wrap_137(ref SocialSharingState P0, bool P1); // 0x0000000186A02E44-0x0000000186A02F74
		public void __Gen_Wrap_138(ref PowerInteractionState P0, bool P1); // 0x0000000186A02F74-0x0000000186A030A4
		public void __Gen_Wrap_139(ref InvalidOverlapPlaceState P0, bool P1); // 0x0000000186A030A4-0x0000000186A031E4
		public bool __Gen_Wrap_140(ref AdditiveEffectRendererFragment P0); // 0x0000000186A03374-0x0000000186A034C0
		public void __Gen_Wrap_141(ref AdditiveEffectRendererFragment P0, bool P1); // 0x0000000186A034C0-0x0000000186A03618
		public int __Gen_Wrap_142(ref AdditiveEffectRendererFragment P0); // 0x0000000186A03618-0x0000000186A03778
		public void __Gen_Wrap_143(ref AdditiveEffectRendererFragment P0); // 0x0000000186A03778-0x0000000186A038B4
		public int __Gen_Wrap_144(ref BattleFragment P0); // 0x0000000186A038B4-0x0000000186A03A08
		public void __Gen_Wrap_145(ref BattleFragment P0); // 0x0000000186A03A08-0x0000000186A03B38
		public bool __Gen_Wrap_146(ref BindRenderEntityFragment P0, Entity P1); // 0x0000000186A03B38-0x0000000186A03D20
		public void __Gen_Wrap_147(ref BindRenderEntityFragment P0, Entity P1); // 0x0000000186A03D20-0x0000000186A03EF8
		public void __Gen_Wrap_148(ref BindRenderEntityFragment P0, object P1); // 0x0000000186A03EF8-0x0000000186A040A0
		public void __Gen_Wrap_149(ref BindRenderEntityFragment P0, NativeArray<Entity> P1); // 0x0000000186A040A0-0x0000000186A04284
		public void __Gen_Wrap_150(ref BindRenderEntityFragment P0); // 0x0000000186A043D8-0x0000000186A04578
		public bool __Gen_Wrap_151(ref BindRenderEntityFragment P0); // 0x0000000186A04578-0x0000000186A04728
		public int __Gen_Wrap_152(ref BindRenderEntityFragment P0); // 0x0000000186A04728-0x0000000186A048D8
		public string __Gen_Wrap_153(ref BurnPowerFragment P0); // 0x0000000186A048D8-0x0000000186A04A2C
		public void __Gen_Wrap_154(ref BurnPowerFragment P0, object P1); // 0x0000000186A04A2C-0x0000000186A04B8C
		public int __Gen_Wrap_155(ref BurnPowerFragment P0); // 0x0000000186A04B8C-0x0000000186A04CE0
		public void __Gen_Wrap_156(ref BurnPowerFragment P0); // 0x0000000186A04CE0-0x0000000186A04E14
		public int __Gen_Wrap_157(ref BusFragment P0); // 0x0000000186A04E14-0x0000000186A04F48
		public void __Gen_Wrap_158(ref BusFragment P0); // 0x0000000186A04F48-0x0000000186A05060
		public int __Gen_Wrap_159(ref BusFreeFragment P0); // 0x0000000186A05060-0x0000000186A05198
		public void __Gen_Wrap_160(ref BusFreeFragment P0); // 0x0000000186A052EC-0x0000000186A05408
		public unsafe int __Gen_Wrap_161(ref CacheFragment P0, bool P1, bool P2, int P3, int P4, out FactoryItem* P5); // 0x0000000186A05408-0x0000000186A056BC
		public void __Gen_Wrap_162(ref CacheFragment P0, bool P1, bool P2, int P3, int P4, out uint P5, out int P6, out long P7); // 0x0000000186A056BC-0x0000000186A059BC
		public void __Gen_Wrap_163(ref CacheFragment P0, bool P1, bool P2, int P3, int P4, uint P5, int P6, long P7); // 0x0000000186A059BC-0x0000000186A05C44
		public void __Gen_Wrap_164(ref CacheFragment P0, bool P1, bool P2, int P3, int P4); // 0x0000000186A05C44-0x0000000186A05E94
		public int __Gen_Wrap_165(ref CacheFragment P0); // 0x0000000186A05E94-0x0000000186A0609C
		public void __Gen_Wrap_166(ref CacheFragment P0); // 0x0000000186A0609C-0x0000000186A06280
		public int __Gen_Wrap_167(ref CacheTransportFragment P0); // 0x0000000186A06280-0x0000000186A063D4
		public void __Gen_Wrap_168(ref CacheTransportFragment P0); // 0x0000000186A063D4-0x0000000186A06504
		public string __Gen_Wrap_169(ref CargoFragment P0); // 0x0000000186A06504-0x0000000186A066C8
		public void __Gen_Wrap_170(ref CargoFragment P0, object P1); // 0x0000000186A06848-0x0000000186A06A1C
		public int __Gen_Wrap_171(ref CargoFragment P0); // 0x0000000186A06A1C-0x0000000186A06BE4
		public void __Gen_Wrap_172(ref CargoFragment P0, int P1); // 0x0000000186A06BE4-0x0000000186A06DB8
		public bool __Gen_Wrap_173(ref CargoFragment P0); // 0x0000000186A06DB8-0x0000000186A06F6C
		public float __Gen_Wrap_174(ref CargoFragment P0, long P1); // 0x0000000186A06F6C-0x0000000186A0713C
		public int __Gen_Wrap_175(ref CargoFragment P0, CargoFragment P1); // 0x0000000186A0713C-0x0000000186A07360
		public CargoFragment __Gen_Wrap_176(uint P0, int4 P1, int4 P2, object P3, int P4, long P5, int P6, float P7, bool P8); // 0x0000000186A07360-0x0000000186A07588
		public void __Gen_Wrap_177(ref CargoFragment P0); // 0x0000000186A07588-0x0000000186A0772C
		public int __Gen_Wrap_178(ref CargoRendererFragment P0); // 0x0000000186A0772C-0x0000000186A07860
		public void __Gen_Wrap_179(ref CargoRendererFragment P0, int P1); // 0x0000000186A07860-0x0000000186A07990
		public void __Gen_Wrap_180(ref CargoRendererFragment P0); // 0x0000000186A07B80-0x0000000186A07C98
		public ref BlueprintSlotInfo __Gen_Wrap_181(ref ChapterFragment P0); // 0x0000000186A07C98-0x0000000186A07E1C
		public int __Gen_Wrap_182(ref ChapterFragment P0); // 0x0000000186A07E1C-0x0000000186A07F90
		public void __Gen_Wrap_183(ref ChapterFragment P0); // 0x0000000186A07F90-0x0000000186A080E0
		public int __Gen_Wrap_184(ref CollectorFragment P0); // 0x0000000186A080E0-0x0000000186A08224
		public void __Gen_Wrap_185(ref CollectorFragment P0); // 0x0000000186A08224-0x0000000186A08348
		public bool __Gen_Wrap_186(ref ConnectionFragment P0); // 0x0000000186A08348-0x0000000186A084AC
		public int __Gen_Wrap_187(ref ConnectionFragment P0); // 0x0000000186A084AC-0x0000000186A08610
		public void __Gen_Wrap_188(ref ConnectionFragment P0); // 0x0000000186A08610-0x0000000186A08754
		public unsafe void __Gen_Wrap_189(ref GlobalEnv P0, uint P1, int P2, out ConveyorInfoAllocator.Info* P3); // 0x0000000186A08754-0x0000000186A08A1C
		public void __Gen_Wrap_190(NativeList<float3> P0, ref UnityEngine.Rect P1); // 0x0000000186A08B8C-0x0000000186A08D00
		public void __Gen_Wrap_191(ref ConveyorFragment P0, ref GlobalEnv P1, ref NativeList<float3> P2, ref NativeList<float3> P3, ref NativeArray<byte> P4); // 0x0000000186A08D00-0x0000000186A09154
		public bool __Gen_Wrap_192(ref ConveyorFragment P0, ref GlobalEnv P1, float2 P2, out uint P3, out int P4); // 0x0000000186A09154-0x0000000186A094F0
		public bool __Gen_Wrap_193(ref ConveyorFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5); // 0x0000000186A094F0-0x0000000186A0982C
		public bool __Gen_Wrap_194(ref ConveyorFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref PooledList<int> P6); // 0x0000000186A0982C-0x0000000186A09BC4
		public bool __Gen_Wrap_195(ref ConveyorFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref ValueTuple<uint, int>[,] P6); // 0x0000000186A09BC4-0x0000000186A09F5C
		public void __Gen_Wrap_196(ref ConveyorFragment P0, float P1); // 0x0000000186A09F5C-0x0000000186A0A0B4
		public int __Gen_Wrap_197(ref ConveyorFragment P0); // 0x0000000186A0A0B4-0x0000000186A0A210
		public void __Gen_Wrap_198(ref ConveyorFragment P0); // 0x0000000186A0A210-0x0000000186A0A34C
		public int __Gen_Wrap_199(ref ConveyorLogisticsUnitFragment P0); // 0x0000000186A0A34C-0x0000000186A0A480
		public void __Gen_Wrap_200(ref ConveyorLogisticsUnitFragment P0); // 0x0000000186A0A6DC-0x0000000186A0A7F4
		public int __Gen_Wrap_201(ref ConveyorRenderFragment P0); // 0x0000000186A0A7F4-0x0000000186A0A958
		public void __Gen_Wrap_202(ref ConveyorRenderFragment P0, int P1); // 0x0000000186A0A958-0x0000000186A0AAC8
		public void __Gen_Wrap_203(ref ConveyorRenderFragment P0); // 0x0000000186A0AAC8-0x0000000186A0AC0C
		public bool __Gen_Wrap_204(ref DirectionFragment P0); // 0x0000000186A0AC0C-0x0000000186A0AD30
		public int __Gen_Wrap_205(ref DirectionFragment P0); // 0x0000000186A0AD30-0x0000000186A0AE64
		public void __Gen_Wrap_206(ref DirectionFragment P0); // 0x0000000186A0AE64-0x0000000186A0AF7C
		public int __Gen_Wrap_207(ref CullResultFragment P0); // 0x0000000186A0AF7C-0x0000000186A0B0B0
		public void __Gen_Wrap_208(ref CullResultFragment P0); // 0x0000000186A0B0B0-0x0000000186A0B1C8
		public int __Gen_Wrap_209(ref DebugFragment P0); // 0x0000000186A0B1C8-0x0000000186A0B2F0
		public void __Gen_Wrap_210(ref DebugFragment P0); // 0x0000000186A0B470-0x0000000186A0B574
		public bool __Gen_Wrap_211(ref EvtDestroyUnit P0); // 0x0000000186A0B574-0x0000000186A0B6B8
		public int __Gen_Wrap_212(ref EvtDestroyUnit P0); // 0x0000000186A0B6B8-0x0000000186A0B7FC
		public void __Gen_Wrap_213(ref EvtDestroyUnit P0); // 0x0000000186A0B7FC-0x0000000186A0B920
		public int __Gen_Wrap_214(ref ShowStateUI P0); // 0x0000000186A0B920-0x0000000186A0BA54
		public void __Gen_Wrap_215(ref ShowStateUI P0); // 0x0000000186A0BA54-0x0000000186A0BB6C
		public int __Gen_Wrap_216(ref ShowNameUI P0); // 0x0000000186A0BB6C-0x0000000186A0BCA0
		public void __Gen_Wrap_217(ref ShowNameUI P0); // 0x0000000186A0BCA0-0x0000000186A0BDB8
		public int __Gen_Wrap_218(ref HasRenderer P0); // 0x0000000186A0BDB8-0x0000000186A0BEEC
		public void __Gen_Wrap_219(ref HasRenderer P0); // 0x0000000186A0BEEC-0x0000000186A0C004
		public int __Gen_Wrap_220(ref EnvGeneratorUIRendererFragment P0); // 0x0000000186A0C194-0x0000000186A0C2C8
		public void __Gen_Wrap_221(ref EnvGeneratorUIRendererFragment P0, int P1); // 0x0000000186A0C2C8-0x0000000186A0C408
		public void __Gen_Wrap_222(ref EnvGeneratorUIRendererFragment P0); // 0x0000000186A0C408-0x0000000186A0C520
		public Entity __Gen_Wrap_223(ref EvtUpdatePipeEffect P0); // 0x0000000186A0C520-0x0000000186A0C668
		public void __Gen_Wrap_224(ref EvtUpdatePipeEffect P0, Entity P1); // 0x0000000186A0C668-0x0000000186A0C7CC
		public Entity __Gen_Wrap_225(ref EvtChangeTemplate P0); // 0x0000000186A0C7CC-0x0000000186A0C99C
		public void __Gen_Wrap_226(ref EvtChangeTemplate P0, Entity P1); // 0x0000000186A0C99C-0x0000000186A0CB88
		public Entity __Gen_Wrap_227(ref EvtCreateUnitRenderer P0); // 0x0000000186A0CB88-0x0000000186A0CCD0
		public void __Gen_Wrap_228(ref EvtCreateUnitRenderer P0, Entity P1); // 0x0000000186A0CCD0-0x0000000186A0CE34
		public Entity __Gen_Wrap_229(ref EvtUpdateStatusEffect P0); // 0x0000000186A0CE34-0x0000000186A0CF7C
		public void __Gen_Wrap_230(ref EvtUpdateStatusEffect P0, Entity P1); // 0x0000000186A0D0C0-0x0000000186A0D224
		public Entity __Gen_Wrap_231(ref EvtPendingCreateRenderer P0); // 0x0000000186A0D224-0x0000000186A0D36C
		public void __Gen_Wrap_232(ref EvtPendingCreateRenderer P0, Entity P1); // 0x0000000186A0D36C-0x0000000186A0D4D0
		public Entity __Gen_Wrap_233(ref EvtUpdateRendererProperty P0); // 0x0000000186A0D4D0-0x0000000186A0D624
		public void __Gen_Wrap_234(ref EvtUpdateRendererProperty P0, Entity P1); // 0x0000000186A0D624-0x0000000186A0D794
		public Entity __Gen_Wrap_235(ref EvtStatusChange P0); // 0x0000000186A0D794-0x0000000186A0D8E8
		public void __Gen_Wrap_236(ref EvtStatusChange P0, Entity P1); // 0x0000000186A0D8E8-0x0000000186A0DA64
		public Entity __Gen_Wrap_237(ref EvtCreateInteract P0); // 0x0000000186A0DA64-0x0000000186A0DBA8
		public void __Gen_Wrap_238(ref EvtCreateInteract P0, Entity P1); // 0x0000000186A0DBA8-0x0000000186A0DD18
		public Entity __Gen_Wrap_239(ref EvtVatUpdate P0); // 0x0000000186A0DD18-0x0000000186A0DE6C
		public void __Gen_Wrap_240(ref EvtVatUpdate P0, Entity P1); // 0x0000000186A0DFD4-0x0000000186A0E144
		public Entity __Gen_Wrap_241(ref EvtUpdatePedestalColorLUT P0); // 0x0000000186A0E144-0x0000000186A0E2A8
		public void __Gen_Wrap_242(ref EvtUpdatePedestalColorLUT P0, Entity P1); // 0x0000000186A0E2A8-0x0000000186A0E424
		public Entity __Gen_Wrap_243(ref EvtAudio P0); // 0x0000000186A0E424-0x0000000186A0E578
		public void __Gen_Wrap_244(ref EvtAudio P0, Entity P1); // 0x0000000186A0E578-0x0000000186A0E6D8
		public int __Gen_Wrap_245(ref AudioFragment P0); // 0x0000000186A0E6D8-0x0000000186A0E82C
		public void __Gen_Wrap_246(ref AudioFragment P0); // 0x0000000186A0E82C-0x0000000186A0E95C
		public int __Gen_Wrap_247(ref ReleaseTagFragment P0); // 0x0000000186A0E95C-0x0000000186A0EA90
		public void __Gen_Wrap_248(ref ReleaseTagFragment P0); // 0x0000000186A0EA90-0x0000000186A0EBA8
		public int __Gen_Wrap_249(ref CurMapUnitTag P0); // 0x0000000186A0EBA8-0x0000000186A0ECDC
		public void __Gen_Wrap_250(ref CurMapUnitTag P0); // 0x0000000186A0EEA0-0x0000000186A0EFB8
		public FCNodeMode __Gen_Wrap_251(ref UnitFragment P0); // 0x0000000186A0EFB8-0x0000000186A0F210
		public void __Gen_Wrap_252(ref UnitFragment P0, FCNodeMode P1); // 0x0000000186A0F210-0x0000000186A0F46C
		public bool __Gen_Wrap_253(ref UnitFragment P0); // 0x0000000186A0F46C-0x0000000186A0F6C4
		public string __Gen_Wrap_254(ref UnitFragment P0); // 0x0000000186A0F6C4-0x0000000186A0F92C
		public void __Gen_Wrap_255(ref UnitFragment P0, object P1); // 0x0000000186A0F92C-0x0000000186A0FB88
		public UnitFragment __Gen_Wrap_256(uint P0, object P1, int P2, bool2 P3, int P4, uint P5, object P6, bool P7, bool P8, bool P9, long P10, FCNodeMode P11, object P12); // 0x0000000186A0FB88-0x0000000186A0FE3C
		public int __Gen_Wrap_257(ref UnitFragment P0); // 0x0000000186A0FE3C-0x0000000186A10094
		public void __Gen_Wrap_258(ref UnitFragment P0); // 0x0000000186A10094-0x0000000186A102C8
		public int __Gen_Wrap_259(ref UnitRenderPipeLogisticsFigureReplaceFragment P0); // 0x0000000186A102C8-0x0000000186A103FC
		public void __Gen_Wrap_260(ref UnitRenderPipeLogisticsFigureReplaceFragment P0); // 0x0000000186A105C0-0x0000000186A106D8
		public int __Gen_Wrap_261(ref BusRenderFragment P0); // 0x0000000186A106D8-0x0000000186A1080C
		public void __Gen_Wrap_262(ref BusRenderFragment P0); // 0x0000000186A1080C-0x0000000186A10924
		public bool __Gen_Wrap_263(ref UnitRenderTypeFragment P0); // 0x0000000186A10924-0x0000000186A10A58
		public int __Gen_Wrap_264(ref UnitRenderTypeFragment P0); // 0x0000000186A10A58-0x0000000186A10B8C
		public void __Gen_Wrap_265(ref UnitRenderTypeFragment P0); // 0x0000000186A10B8C-0x0000000186A10CA4
		public int __Gen_Wrap_266(ref FakeUnitFragment P0); // 0x0000000186A10CA4-0x0000000186A10DD8
		public void __Gen_Wrap_267(ref FakeUnitFragment P0); // 0x0000000186A10DD8-0x0000000186A10EF0
		public int __Gen_Wrap_268(ref UIUnitFragment P0); // 0x0000000186A10EF0-0x0000000186A11024
		public void __Gen_Wrap_269(ref UIUnitFragment P0); // 0x0000000186A11024-0x0000000186A1113C
		public int __Gen_Wrap_270(ref GuideHintFragment P0); // 0x0000000186A112BC-0x0000000186A113F0
		public void __Gen_Wrap_271(ref GuideHintFragment P0); // 0x0000000186A113F0-0x0000000186A11508
		public StringIntern.FastId __Gen_Wrap_272(int P0); // 0x0000000186A11508-0x0000000186A115F4
		public string __Gen_Wrap_273(ref UnitPreviewFragment P0); // 0x0000000186A115F4-0x0000000186A11744
		public int __Gen_Wrap_274(StringIntern.FastId P0); // 0x0000000186A11744-0x0000000186A11844
		public void __Gen_Wrap_275(ref UnitPreviewFragment P0, object P1); // 0x0000000186A11844-0x0000000186A119A0
		public bool __Gen_Wrap_276(ref UnitPreviewFragment P0); // 0x0000000186A119A0-0x0000000186A11AE0
		public int __Gen_Wrap_277(ref UnitPreviewFragment P0); // 0x0000000186A11AE0-0x0000000186A11C30
		public void __Gen_Wrap_278(ref UnitPreviewFragment P0); // 0x0000000186A11C30-0x0000000186A11D60
		public int __Gen_Wrap_279(ref ConveyorRegularFragment P0); // 0x0000000186A11D60-0x0000000186A11E94
		public void __Gen_Wrap_280(ref ConveyorRegularFragment P0); // 0x0000000186A12058-0x0000000186A12170
		public int __Gen_Wrap_281(ref ConveyorGuideFragment P0); // 0x0000000186A12170-0x0000000186A122A4
		public void __Gen_Wrap_282(ref ConveyorGuideFragment P0); // 0x0000000186A122A4-0x0000000186A123BC
		public int __Gen_Wrap_283(ref PipeRegularFragment P0); // 0x0000000186A123BC-0x0000000186A124F0
		public void __Gen_Wrap_284(ref PipeRegularFragment P0); // 0x0000000186A124F0-0x0000000186A12608
		public int __Gen_Wrap_285(ref ConveyorPreviewRendererFragment P0); // 0x0000000186A12608-0x0000000186A12754
		public void __Gen_Wrap_286(ref ConveyorPreviewRendererFragment P0); // 0x0000000186A12754-0x0000000186A12880
		public int __Gen_Wrap_287(ref PipePreviewRendererFragment P0); // 0x0000000186A12880-0x0000000186A129D0
		public void __Gen_Wrap_288(ref PipePreviewRendererFragment P0); // 0x0000000186A129D0-0x0000000186A12B00
		public int __Gen_Wrap_289(ref PipePreviewFragment P0); // 0x0000000186A12B00-0x0000000186A12C34
		public void __Gen_Wrap_290(ref PipePreviewFragment P0); // 0x0000000186A12E24-0x0000000186A12F3C
		public int __Gen_Wrap_291(ref FigureRenderFragment P0); // 0x0000000186A12F3C-0x0000000186A1308C
		public void __Gen_Wrap_292(ref FigureRenderFragment P0, int P1); // 0x0000000186A1308C-0x0000000186A131E8
		public void __Gen_Wrap_293(ref FigureRenderFragment P0); // 0x0000000186A131E8-0x0000000186A13318
		public bool __Gen_Wrap_294(ref FigureRenderDirectionFragment P0); // 0x0000000186A13318-0x0000000186A1343C
		public int __Gen_Wrap_295(ref FigureRenderDirectionFragment P0); // 0x0000000186A1343C-0x0000000186A13570
		public void __Gen_Wrap_296(ref FigureRenderDirectionFragment P0); // 0x0000000186A13570-0x0000000186A13688
		public int __Gen_Wrap_297(ref FigureRenderPipeHolderFragment P0); // 0x0000000186A13688-0x0000000186A137BC
		public void __Gen_Wrap_298(ref FigureRenderPipeHolderFragment P0); // 0x0000000186A137BC-0x0000000186A138D4
		public int __Gen_Wrap_299(ref FigureRenderConveyorLogisticsFragment P0); // 0x0000000186A138D4-0x0000000186A13A08
		public void __Gen_Wrap_300(ref FigureRenderConveyorLogisticsFragment P0); // 0x0000000186A13C74-0x0000000186A13D8C
		public int __Gen_Wrap_301(ref FluidConsumeFragment P0); // 0x0000000186A13D8C-0x0000000186A13EC4
		public void __Gen_Wrap_302(ref FluidConsumeFragment P0); // 0x0000000186A13EC4-0x0000000186A13FE0
		public void __Gen_Wrap_303(ref FluidContainerFragment P0, int P1, int P2, int P3, int P4); // 0x0000000186A13FE0-0x0000000186A14220
		public void __Gen_Wrap_304(ref FluidContainerFragment P0, int P1, int P2); // 0x0000000186A14220-0x0000000186A14440
		public void __Gen_Wrap_305(ref FluidContainerFragment P0, int P1, float P2); // 0x0000000186A14440-0x0000000186A14668
		public bool __Gen_Wrap_306(ref FluidContainerFragment P0, int P1, out int P2, out int P3, out float P4, out int P5, out int P6); // 0x0000000186A14668-0x0000000186A14990
		public bool __Gen_Wrap_307(ref FluidContainerFragment P0); // 0x0000000186A14990-0x0000000186A14B80
		public void __Gen_Wrap_308(ref FluidContainerFragment P0, float P1); // 0x0000000186A14B80-0x0000000186A14D7C
		public ValueTuple<int, uint> __Gen_Wrap_309(ref FluidContainerFragment P0); // 0x0000000186A14D7C-0x0000000186A14F7C
		public void __Gen_Wrap_310(ref FluidContainerFragment P0); // 0x0000000186A150FC-0x0000000186A152F0
		public string __Gen_Wrap_311(ref FluidContainerFragment P0); // 0x0000000186A152F0-0x0000000186A154F0
		public int __Gen_Wrap_312(ref FluidContainerFragment P0); // 0x0000000186A154F0-0x0000000186A156F4
		public int __Gen_Wrap_313(ref FluidPumpInFragment P0); // 0x0000000186A156F4-0x0000000186A15828
		public void __Gen_Wrap_314(ref FluidPumpInFragment P0); // 0x0000000186A15828-0x0000000186A15940
		public int __Gen_Wrap_315(ref FluidPumpOutFragment P0); // 0x0000000186A15940-0x0000000186A15A74
		public void __Gen_Wrap_316(ref FluidPumpOutFragment P0); // 0x0000000186A15A74-0x0000000186A15B8C
		public int __Gen_Wrap_317(ref FluidReactionFragment P0); // 0x0000000186A15B8C-0x0000000186A15CC0
		public void __Gen_Wrap_318(ref FluidReactionFragment P0); // 0x0000000186A15CC0-0x0000000186A15DD8
		public int __Gen_Wrap_319(ref FluidSprayFragment P0); // 0x0000000186A15DD8-0x0000000186A15F10
		public void __Gen_Wrap_320(ref FluidSprayFragment P0); // 0x0000000186A16004-0x0000000186A16120
		public int __Gen_Wrap_321(ref FormulaManualFragment P0); // 0x0000000186A16120-0x0000000186A16274
		public void __Gen_Wrap_322(ref FormulaManualFragment P0); // 0x0000000186A16274-0x0000000186A163A4
		public void __Gen_Wrap_323(ref OutOfBufferWarning P0); // 0x0000000186A163A4-0x0000000186A164DC
		public string __Gen_Wrap_324(ref OutOfBufferWarning P0); // 0x0000000186A164DC-0x0000000186A16624
		public UnsafeList<float4x4> __Gen_Wrap_325(ref GlobalEnv P0); // 0x0000000186A16624-0x0000000186A168A4
		public UnsafeList<OutputRendererInfo> __Gen_Wrap_326(ref GlobalEnv P0); // 0x0000000186A168A4-0x0000000186A16B24
		public UnsafeList<EnvGeneratorRendererInfo> __Gen_Wrap_327(ref GlobalEnv P0); // 0x0000000186A16B24-0x0000000186A16DA4
		public IntPtr __Gen_Wrap_328(ref GlobalEnv P0); // 0x0000000186A16DA4-0x0000000186A16FFC
		public int __Gen_Wrap_329(ref GlobalEnv P0); // 0x0000000186A16FFC-0x0000000186A17254
		public UnsafeList<Matrix4x4> __Gen_Wrap_330(ref GlobalEnv P0); // 0x0000000186A173A8-0x0000000186A17628
		public ref ConveyorInfoAllocator.Info __Gen_Wrap_331(ref GlobalEnv P0, uint P1, int P2); // 0x0000000186A17628-0x0000000186A178C4
		public LinearAllocator.Allocation __Gen_Wrap_332(ref GlobalEnv P0, int P1); // 0x0000000186A178C4-0x0000000186A17B68
		public long __Gen_Wrap_333(ref GlobalEnv P0, uint P1); // 0x0000000186A17B68-0x0000000186A17DC0
		public LinearAllocator.Allocation __Gen_Wrap_334(ref GlobalEnv P0, uint P1, int P2); // 0x0000000186A17DC0-0x0000000186A18064
		public void __Gen_Wrap_335(ref GlobalEnv P0, uint P1); // 0x0000000186A18064-0x0000000186A182C0
		public UnsafeList<VATFSMProcessor.SetAnimatorParamRequest> __Gen_Wrap_336(ref GlobalEnv P0); // 0x0000000186A182C0-0x0000000186A1852C
		public string __Gen_Wrap_337(ref UnitConfigFragment P0); // 0x0000000186A1852C-0x0000000186A186E0
		public bool __Gen_Wrap_338(VATFSMDefinition P0, int P1, out byte P2, out Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P3); // 0x0000000186A186E0-0x0000000186A18890
		public byte __Gen_Wrap_339(uint P0, int P1); // 0x0000000186A18890-0x0000000186A18978
		public bool __Gen_Wrap_340(ref GlobalEnv P0, ref EntityManager P1, Entity P2, in VATFSMProcessor.SetAnimatorParamRequest P3); // 0x0000000186A18ACC-0x0000000186A18E44
		public void __Gen_Wrap_341(ref GlobalEnv P0, Entity P1, VATFSMProcessor.SetAnimatorParamRequest P2); // 0x0000000186A18E44-0x0000000186A19114
		public void __Gen_Wrap_342(ref GlobalEnv P0, Entity P1, object P2, bool P3); // 0x0000000186A19114-0x0000000186A193BC
		public bool __Gen_Wrap_343(ref GlobalEnv P0, Entity P1, in VATFSMProcessor.SetAnimatorParamRequest P2); // 0x0000000186A193BC-0x0000000186A19698
		public bool __Gen_Wrap_344(ref GlobalEnv P0, Entity P1, byte P2, bool P3); // 0x0000000186A19698-0x0000000186A1993C
		public bool __Gen_Wrap_345(ref VATFSMDefinition P0, FCNodeMode P1, out byte P2); // 0x0000000186A1993C-0x0000000186A19AFC
		public bool __Gen_Wrap_346(ref GlobalEnv P0, ref EntityManager P1, Entity P2, FCNodeMode P3); // 0x0000000186A19AFC-0x0000000186A19E1C
		public bool __Gen_Wrap_347(ref GlobalEnv P0, Entity P1, FCNodeMode P2, bool P3); // 0x0000000186A19E1C-0x0000000186A1A0D4
		public UnsafeList<VATFSMProcessor.VATFSMAudioData> __Gen_Wrap_348(ref GlobalEnv P0); // 0x0000000186A1A0D4-0x0000000186A1A33C
		public ref VATFSMProcessor.VATFSMAudioData __Gen_Wrap_349(ref GlobalEnv P0, int P1); // 0x0000000186A1A33C-0x0000000186A1A5B8
		public int __Gen_Wrap_350(ref HealthPoleFragment P0); // 0x0000000186A1A71C-0x0000000186A1A860
		public void __Gen_Wrap_351(ref HealthPoleFragment P0); // 0x0000000186A1A860-0x0000000186A1A984
		public int __Gen_Wrap_352(ref InventoryFragment P0); // 0x0000000186A1A984-0x0000000186A1AAB8
		public void __Gen_Wrap_353(ref InventoryFragment P0); // 0x0000000186A1AAB8-0x0000000186A1ABD0
		public int __Gen_Wrap_354(ref LiquidPurifierFragment P0); // 0x0000000186A1ABD0-0x0000000186A1AD04
		public void __Gen_Wrap_355(ref LiquidPurifierFragment P0); // 0x0000000186A1AD04-0x0000000186A1AE1C
		public int __Gen_Wrap_356(ref LogisticEffectFragment P0); // 0x0000000186A1AE1C-0x0000000186A1AF7C
		public void __Gen_Wrap_357(ref LogisticEffectFragment P0); // 0x0000000186A1AF7C-0x0000000186A1B0BC
		public void __Gen_Wrap_358(ref LogisticEntityBindFragment P0, Entity P1, uint P2); // 0x0000000186A1B0BC-0x0000000186A1B268
		public bool __Gen_Wrap_359(ref LogisticEntityBindFragment P0, out Entity P1); // 0x0000000186A1B268-0x0000000186A1B420
		public int __Gen_Wrap_360(ref LogisticEntityBindFragment P0); // 0x0000000186A1B5A0-0x0000000186A1B708
		public void __Gen_Wrap_361(ref LogisticEntityBindFragment P0); // 0x0000000186A1B708-0x0000000186A1B84C
		public int __Gen_Wrap_362(ref MapGridRendererFragment P0); // 0x0000000186A1B84C-0x0000000186A1B980
		public void __Gen_Wrap_363(ref MapGridRendererFragment P0); // 0x0000000186A1B980-0x0000000186A1BA98
		public void __Gen_Wrap_364(ref OutputFragment P0); // 0x0000000186A1BA98-0x0000000186A1BC00
		public void __Gen_Wrap_365(ref OutputFragment P0, float4 P1); // 0x0000000186A1BC00-0x0000000186A1BD94
		public void __Gen_Wrap_366(ref OutputFragment P0, UnityEngine.Color P1); // 0x0000000186A1BD94-0x0000000186A1BF38
		public void __Gen_Wrap_367(ref OutputFragment P0, RectInt P1); // 0x0000000186A1BF38-0x0000000186A1C0DC
		public bool __Gen_Wrap_368(ref OutputFragment P0); // 0x0000000186A1C0DC-0x0000000186A1C240
		public void __Gen_Wrap_369(ref OutputFragment P0, bool P1); // 0x0000000186A1C240-0x0000000186A1C3C0
		public int __Gen_Wrap_370(ref OutputFragment P0); // 0x0000000186A1C5D4-0x0000000186A1C74C
		public int __Gen_Wrap_371(ref OutputUIRendererFragment P0); // 0x0000000186A1C74C-0x0000000186A1C880
		public void __Gen_Wrap_372(ref OutputUIRendererFragment P0, int P1); // 0x0000000186A1C880-0x0000000186A1C9C0
		public void __Gen_Wrap_373(ref OutputUIRendererFragment P0); // 0x0000000186A1C9C0-0x0000000186A1CAD8
		public int __Gen_Wrap_374(ref PedestalLightFlashFragment P0); // 0x0000000186A1CAD8-0x0000000186A1CC5C
		public void __Gen_Wrap_375(ref PedestalLightFlashFragment P0); // 0x0000000186A1CC5C-0x0000000186A1CDBC
		public bool __Gen_Wrap_376(ref PedestalLightFlashConfigFragment P0); // 0x0000000186A1CDBC-0x0000000186A1D000
		public void __Gen_Wrap_377(ref PedestalLightFlashConfigFragment P0, int P1, float P2); // 0x0000000186A1D000-0x0000000186A1D278
		public void __Gen_Wrap_378(ref PedestalLightFlashConfigFragment P0, int P1, bool P2); // 0x0000000186A1D278-0x0000000186A1D4F0
		public void __Gen_Wrap_379(ref PedestalLightFlashConfigFragment P0, int P1, UnityEngine.Color P2); // 0x0000000186A1D4F0-0x0000000186A1D790
		public float __Gen_Wrap_380(ref PedestalLightFlashConfigFragment P0, int P1); // 0x0000000186A1D900-0x0000000186A1DB58
		public bool __Gen_Wrap_381(ref PedestalLightFlashConfigFragment P0, int P1); // 0x0000000186A1DB58-0x0000000186A1DDB0
		public float4 __Gen_Wrap_382(ref PedestalLightFlashConfigFragment P0, int P1); // 0x0000000186A1DDB0-0x0000000186A1E038
		public int __Gen_Wrap_383(ref PedestalLightFlashConfigFragment P0); // 0x0000000186A1E038-0x0000000186A1E290
		public void __Gen_Wrap_384(ref PedestalLightFlashConfigFragment P0); // 0x0000000186A1E290-0x0000000186A1E4C4
		public string __Gen_Wrap_385(ref PipeEffectFragment P0); // 0x0000000186A1E4C4-0x0000000186A1E6D8
		public void __Gen_Wrap_386(ref PipeEffectFragment P0, object P1); // 0x0000000186A1E6D8-0x0000000186A1E8E8
		public int __Gen_Wrap_387(ref PipeEffectFragment P0); // 0x0000000186A1E8E8-0x0000000186A1EAEC
		public void __Gen_Wrap_388(ref PipeEffectFragment P0); // 0x0000000186A1EAEC-0x0000000186A1ECCC
		public bool __Gen_Wrap_389(ref PipeFragment P0, ref GlobalEnv P1, ref NativeList<float3> P2, ref NativeList<float3> P3, ref NativeList<byte> P4); // 0x0000000186A1ECCC-0x0000000186A1F1B0
		public void __Gen_Wrap_390(ref GlobalEnv P0, int P1, uint P2, float P3, bool P4, float P5, bool P6, float P7); // 0x0000000186A1F314-0x0000000186A1F5F0
		public ValueTuple<int[], int> __Gen_Wrap_391(ref GlobalEnv P0, uint P1, int P2); // 0x0000000186A1F5F0-0x0000000186A1F88C
		public bool __Gen_Wrap_392(ref PipeFragment P0, ref GlobalEnv P1, float2 P2, out uint P3, out int P4); // 0x0000000186A1F88C-0x0000000186A1FCA4
		public bool __Gen_Wrap_393(ref PipeFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5); // 0x0000000186A1FCA4-0x0000000186A20060
		public bool __Gen_Wrap_394(ref PipeFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref PooledList<int> P6); // 0x0000000186A20060-0x0000000186A20478
		public bool __Gen_Wrap_395(ref PipeFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref ValueTuple<uint, int>[,] P6); // 0x0000000186A20478-0x0000000186A20890
		public void __Gen_Wrap_396(ref PipeFragment P0); // 0x0000000186A20890-0x0000000186A20A80
		public void __Gen_Wrap_397(ref PipeFragment P0, float P1); // 0x0000000186A20A80-0x0000000186A20C90
		public int __Gen_Wrap_398(ref PipeFragment P0); // 0x0000000186A20C90-0x0000000186A20E94
		public int __Gen_Wrap_399(ref PipeHolderFragment P0); // 0x0000000186A20E94-0x0000000186A20FE8
		public void __Gen_Wrap_400(ref PipeHolderFragment P0); // 0x0000000186A21168-0x0000000186A21298
		public int __Gen_Wrap_401(ref PipeLogisticsUnitFragment P0); // 0x0000000186A21298-0x0000000186A213CC
		public void __Gen_Wrap_402(ref PipeLogisticsUnitFragment P0); // 0x0000000186A213CC-0x0000000186A214E4
		public int __Gen_Wrap_403(ref PipeComRenderFragment P0); // 0x0000000186A214E4-0x0000000186A21634
		public void __Gen_Wrap_404(ref PipeComRenderFragment P0, int P1); // 0x0000000186A21634-0x0000000186A21790
		public void __Gen_Wrap_405(ref PipeComRenderFragment P0); // 0x0000000186A21790-0x0000000186A218C0
		public int __Gen_Wrap_406(ref PipeRenderFragment P0); // 0x0000000186A218C0-0x0000000186A21A48
		public void __Gen_Wrap_407(ref PipeRenderFragment P0, int P1); // 0x0000000186A21A48-0x0000000186A21BD8
		public void __Gen_Wrap_408(ref PipeRenderFragment P0); // 0x0000000186A21BD8-0x0000000186A21D3C
		public int __Gen_Wrap_409(ref PipeTrackRenderFragment P0); // 0x0000000186A21D3C-0x0000000186A21E8C
		public void __Gen_Wrap_410(ref PipeTrackRenderFragment P0, int P1); // 0x0000000186A2201C-0x0000000186A22178
		public void __Gen_Wrap_411(ref PipeTrackRenderFragment P0); // 0x0000000186A22178-0x0000000186A222A8
		public void __Gen_Wrap_412(ref ComplexPortFragment P0); // 0x0000000186A222A8-0x0000000186A22400
		public void __Gen_Wrap_413(ref ComplexPortFragment P0, int P1, bool P2, bool P3); // 0x0000000186A22400-0x0000000186A225A0
		public void __Gen_Wrap_414(ref ComplexPortFragment P0, bool P1, bool P2, object P3); // 0x0000000186A225A0-0x0000000186A22744
		public bool __Gen_Wrap_415(ref ComplexPortFragment P0, uint P1, int P2, bool P3, bool P4, uint P5, out bool P6); // 0x0000000186A22744-0x0000000186A22954
		public bool __Gen_Wrap_416(ref ComplexPortFragment P0, uint P1, bool P2, object P3); // 0x0000000186A22954-0x0000000186A22AF4
		public bool __Gen_Wrap_417(ref ComplexPortFragment P0, bool P1, object P2, bool P3); // 0x0000000186A22AF4-0x0000000186A22CA8
		public void __Gen_Wrap_418(ref ComplexPortFragment P0, float3 P1, float3 P2, ref GlobalSharedData.UnitPortConfig P3, ref UnitConfigFragment P4, float P5); // 0x0000000186A22CA8-0x0000000186A230AC
		public bool __Gen_Wrap_419(ref ComplexPortFragment P0); // 0x0000000186A230AC-0x0000000186A23200
		public bool __Gen_Wrap_420(ref Beyond.Gameplay.Factory.PortData P0, Beyond.Gameplay.Factory.PortData P1); // 0x0000000186A23370-0x0000000186A2351C
		public bool __Gen_Wrap_421(ref ComplexPortFragment P0, ComplexPortFragment P1); // 0x0000000186A2351C-0x0000000186A236B4
		public bool __Gen_Wrap_422(ref ComplexPortFragment P0, object P1); // 0x0000000186A236B4-0x0000000186A23824
		public int __Gen_Wrap_423(ref ComplexPortFragment P0); // 0x0000000186A23824-0x0000000186A2398C
		public bool __Gen_Wrap_424(ComplexPortFragment P0, ComplexPortFragment P1); // 0x0000000186A2398C-0x0000000186A23AD4
		public bool __Gen_Wrap_425(ref Beyond.Gameplay.Factory.PortData P0); // 0x0000000186A23AD4-0x0000000186A23C48
		public string __Gen_Wrap_426(ref Beyond.Gameplay.Factory.PortData P0); // 0x0000000186A23C48-0x0000000186A23DBC
		public string __Gen_Wrap_427(ref ComplexPortFragment P0); // 0x0000000186A23DBC-0x0000000186A23F20
		public float4x4 __Gen_Wrap_428(ref Beyond.Gameplay.Factory.PortData P0); // 0x0000000186A23F20-0x0000000186A240C4
		public bool __Gen_Wrap_429(ref Beyond.Gameplay.Factory.PortData P0, object P1); // 0x0000000186A240C4-0x0000000186A24240
		public int __Gen_Wrap_430(ref Beyond.Gameplay.Factory.PortData P0); // 0x0000000186A24394-0x0000000186A244F4
		public bool __Gen_Wrap_431(Beyond.Gameplay.Factory.PortData P0, Beyond.Gameplay.Factory.PortData P1); // 0x0000000186A244F4-0x0000000186A2464C
		public int __Gen_Wrap_432(ref PortPreviewUIRendererFragment P0); // 0x0000000186A2464C-0x0000000186A24780
		public void __Gen_Wrap_433(ref PortPreviewUIRendererFragment P0, int P1); // 0x0000000186A24780-0x0000000186A248C0
		public void __Gen_Wrap_434(ref PortPreviewUIRendererFragment P0); // 0x0000000186A248C0-0x0000000186A249D8
		public int __Gen_Wrap_435(ref PortStatusUIFragment P0); // 0x0000000186A249D8-0x0000000186A24B0C
		public void __Gen_Wrap_436(ref PortStatusUIFragment P0, int P1); // 0x0000000186A24B0C-0x0000000186A24C4C
		public void __Gen_Wrap_437(ref PortStatusUIFragment P0); // 0x0000000186A24C4C-0x0000000186A24D64
		public uint __Gen_Wrap_438(ref ProducerFragment P0); // 0x0000000186A24D64-0x0000000186A24EB8
		public int __Gen_Wrap_439(ref ProducerFragment P0); // 0x0000000186A24EB8-0x0000000186A2500C
		public void __Gen_Wrap_440(ref ProducerFragment P0); // 0x0000000186A25174-0x0000000186A252A8
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_441(ref SharedDataFragment P0); // 0x0000000186A252A8-0x0000000186A253EC
		public void __Gen_Wrap_442(ref SharedDataFragment P0); // 0x0000000186A253EC-0x0000000186A25510
		public int __Gen_Wrap_443(ref SharedDataFragment P0); // 0x0000000186A25510-0x0000000186A25644
		public SocialFragment __Gen_Wrap_444(ulong P0, uint P1, ulong P2, long P3, long P4, uint P5, bool P6); // 0x0000000186A25644-0x0000000186A257D4
		public bool __Gen_Wrap_445(ref SocialFragment P0); // 0x0000000186A257D4-0x0000000186A2594C
		public int __Gen_Wrap_446(ref SocialFragment P0); // 0x0000000186A2594C-0x0000000186A25AC4
		public void __Gen_Wrap_447(ref SocialFragment P0); // 0x0000000186A25AC4-0x0000000186A25C18
		public string __Gen_Wrap_448(ref SignData P0); // 0x0000000186A25C18-0x0000000186A25D7C
		public float __Gen_Wrap_449(object P0, uint3 P1); // 0x0000000186A25D7C-0x0000000186A25EA4
		public void __Gen_Wrap_450(object P0, Entity P1, uint3 P2); // 0x0000000186A26014-0x0000000186A26160
		public void __Gen_Wrap_451(object P0, ref EntityManager P1, Entity P2); // 0x0000000186A26160-0x0000000186A262E0
		public LocalTransform __Gen_Wrap_452(float4x4 P0); // 0x0000000186A262E0-0x0000000186A26420
		public LocalTransform __Gen_Wrap_453(float3 P0, quaternion P1); // 0x0000000186A26420-0x0000000186A2658C
		public LocalTransform __Gen_Wrap_454(float3 P0, quaternion P1, float P2); // 0x0000000186A2658C-0x0000000186A2671C
		public LocalTransform __Gen_Wrap_455(float3 P0); // 0x0000000186A2671C-0x0000000186A2684C
		public LocalTransform __Gen_Wrap_456(float P0, float P1, float P2); // 0x0000000186A2684C-0x0000000186A2697C
		public LocalTransform __Gen_Wrap_457(quaternion P0); // 0x0000000186A2697C-0x0000000186A26AA4
		public LocalTransform __Gen_Wrap_458(float P0); // 0x0000000186A26AA4-0x0000000186A26BA8
		public string __Gen_Wrap_459(ref LocalTransform P0); // 0x0000000186A26BA8-0x0000000186A26CF8
		public float3 __Gen_Wrap_460(ref LocalTransform P0, float3 P1); // 0x0000000186A26E88-0x0000000186A27054
		public float3 __Gen_Wrap_461(ref LocalTransform P0); // 0x0000000186A27054-0x0000000186A271C8
		public quaternion __Gen_Wrap_462(ref LocalTransform P0, quaternion P1); // 0x0000000186A271C8-0x0000000186A27384
		public float __Gen_Wrap_463(ref LocalTransform P0, float P1); // 0x0000000186A27384-0x0000000186A274F4
		public LocalTransform __Gen_Wrap_464(ref LocalTransform P0, in LocalTransform P1); // 0x0000000186A274F4-0x0000000186A276B8
		public LocalTransform __Gen_Wrap_465(ref LocalTransform P0); // 0x0000000186A276B8-0x0000000186A27820
		public LocalTransform __Gen_Wrap_466(ref LocalTransform P0, float3 P1); // 0x0000000186A27820-0x0000000186A279E0
		public LocalTransform __Gen_Wrap_467(ref LocalTransform P0, float P1, float P2, float P3); // 0x0000000186A279E0-0x0000000186A27B88
		public LocalTransform __Gen_Wrap_468(ref LocalTransform P0, quaternion P1); // 0x0000000186A27B88-0x0000000186A27D40
		public LocalTransform __Gen_Wrap_469(ref LocalTransform P0, float P1); // 0x0000000186A27D40-0x0000000186A27ED4
		public bool __Gen_Wrap_470(ref LocalTransform P0, in LocalTransform P1); // 0x0000000186A28058-0x0000000186A281E0
		public int __Gen_Wrap_471(ref LocalTransform P0); // 0x0000000186A281E0-0x0000000186A28330
		public void __Gen_Wrap_472(ref LocalTransform P0); // 0x0000000186A28330-0x0000000186A28460
		public int __Gen_Wrap_473(ref Root P0); // 0x0000000186A28460-0x0000000186A28588
		public void __Gen_Wrap_474(ref Root P0); // 0x0000000186A28588-0x0000000186A2868C
		public int __Gen_Wrap_475(ref Parent P0); // 0x0000000186A2868C-0x0000000186A287C4
		public void __Gen_Wrap_476(ref Parent P0); // 0x0000000186A287C4-0x0000000186A288E0
		public int __Gen_Wrap_477(ref Beyond.Gameplay.Factory.Child P0); // 0x0000000186A288E0-0x0000000186A28AE8
		public void __Gen_Wrap_478(ref Beyond.Gameplay.Factory.Child P0); // 0x0000000186A28AE8-0x0000000186A28CCC
		public bool __Gen_Wrap_479(ref LocalToWorld P0, float4x4 P1, int P2); // 0x0000000186A28CCC-0x0000000186A28F34
		public float3 __Gen_Wrap_480(ref LocalToWorld P0); // 0x0000000186A290B0-0x0000000186A292E4
		public quaternion __Gen_Wrap_481(ref LocalToWorld P0); // 0x0000000186A292E4-0x0000000186A29510
		public int __Gen_Wrap_482(ref LocalToWorld P0); // 0x0000000186A29510-0x0000000186A29710
		public void __Gen_Wrap_483(ref LocalToWorld P0); // 0x0000000186A29710-0x0000000186A298E8
		public int __Gen_Wrap_484(ref UdPipeFragment P0); // 0x0000000186A298E8-0x0000000186A29A2C
		public void __Gen_Wrap_485(ref UdPipeFragment P0); // 0x0000000186A29A2C-0x0000000186A29B50
		public void __Gen_Wrap_486(ref UnitConfigFragment P0, object P1); // 0x0000000186A29B50-0x0000000186A29CFC
		public int __Gen_Wrap_487(ref UnitConfigFragment P0); // 0x0000000186A29CFC-0x0000000186A29EA0
		public void __Gen_Wrap_488(ref UnitConfigFragment P0); // 0x0000000186A29EA0-0x0000000186A2A020
		public string __Gen_Wrap_489(ref FactoryUnitExtendConfig P0); // 0x0000000186A2A020-0x0000000186A2A1B0
		public FacEnvGenEnvType __Gen_Wrap_490(ref UnitEnvironmentRelation P0); // 0x0000000186A2A300-0x0000000186A2A450
		public int __Gen_Wrap_491(ref UnitEnvironmentRelation P0); // 0x0000000186A2A450-0x0000000186A2A5A0
		public void __Gen_Wrap_492(ref UnitEnvironmentRelation P0); // 0x0000000186A2A5A0-0x0000000186A2A6D0
		public int __Gen_Wrap_493(ref UnitInteractFragment P0); // 0x0000000186A2A6D0-0x0000000186A2A808
		public void __Gen_Wrap_494(ref UnitInteractFragment P0); // 0x0000000186A2A808-0x0000000186A2A924
		public int __Gen_Wrap_495(ref UnitRenderFragment P0); // 0x0000000186A2A924-0x0000000186A2AABC
		public void __Gen_Wrap_496(ref UnitRenderFragment P0, int P1); // 0x0000000186A2AABC-0x0000000186A2AC5C
		public void __Gen_Wrap_497(ref UnitRenderFragment P0); // 0x0000000186A2AC5C-0x0000000186A2ADD0
		public int __Gen_Wrap_498(ref RenderLookAtFragment P0); // 0x0000000186A2ADD0-0x0000000186A2AF2C
		public void __Gen_Wrap_499(ref RenderLookAtFragment P0); // 0x0000000186A2AF2C-0x0000000186A2B068
		public int __Gen_Wrap_500(ref ChapterTagFragment P0); // 0x0000000186A2B2C0-0x0000000186A2B404
		public void __Gen_Wrap_501(ref ChapterTagFragment P0); // 0x0000000186A2B404-0x0000000186A2B528
		public int __Gen_Wrap_502(ref UnitStatusFragment P0); // 0x0000000186A2B528-0x0000000186A2B664
		public void __Gen_Wrap_503(ref UnitStatusFragment P0); // 0x0000000186A2B664-0x0000000186A2B790
		public int __Gen_Wrap_504(ref UnitOverrideStatusFragment P0); // 0x0000000186A2B790-0x0000000186A2B8C4
		public void __Gen_Wrap_505(ref UnitOverrideStatusFragment P0); // 0x0000000186A2B8C4-0x0000000186A2B9DC
		public void __Gen_Wrap_506(int P0, object P1); // 0x0000000186374CB0-0x0000000186374D8C
		public void __Gen_Wrap_507(ref UnitStatusEffectFragment P0, int P1, object P2); // 0x0000000186A2B9DC-0x0000000186A2BB44
		public List<StatusSingleEffect> __Gen_Wrap_508(int P0, FacBuildingState P1); // 0x0000000186A2BB44-0x0000000186A2BC4C
		public List<StatusSingleEffect> __Gen_Wrap_509(ref UnitStatusEffectFragment P0, FacBuildingState P1); // 0x0000000186A2BC4C-0x0000000186A2BDBC
		public int __Gen_Wrap_510(ref UnitStatusEffectFragment P0); // 0x0000000186A2BEC4-0x0000000186A2C008
		public void __Gen_Wrap_511(ref UnitStatusEffectFragment P0); // 0x0000000186A2C008-0x0000000186A2C12C
		public string __Gen_Wrap_512(ref StatusSingleEffect P0); // 0x0000000186A2C12C-0x0000000186A2C2CC
		public void __Gen_Wrap_513(ref StatusSingleEffect P0, object P1); // 0x0000000186A2C2CC-0x0000000186A2C454
		public int __Gen_Wrap_514(ref UnitStatusUIRendererFragment P0); // 0x0000000186A2C454-0x0000000186A2C588
		public void __Gen_Wrap_515(ref UnitStatusUIRendererFragment P0, int P1); // 0x0000000186A2C588-0x0000000186A2C6C8
		public void __Gen_Wrap_516(ref UnitStatusUIRendererFragment P0); // 0x0000000186A2C6C8-0x0000000186A2C7E0
		public float3 __Gen_Wrap_517(ref UnitTransFragment P0); // 0x0000000186A2C7E0-0x0000000186A2C974
		public quaternion __Gen_Wrap_518(ref UnitTransFragment P0); // 0x0000000186A2C974-0x0000000186A2CB04
		public void __Gen_Wrap_519(ref UnitTransFragment P0, float3 P1); // 0x0000000186A2CB04-0x0000000186A2CC9C
		public bool __Gen_Wrap_520(ref UnitTransFragment P0, float3 P1, bool P2); // 0x0000000186A2CDD4-0x0000000186A2CF84
		public RectInt __Gen_Wrap_521(ref UnitTransFragment P0); // 0x0000000186A2CF84-0x0000000186A2D114
		public int __Gen_Wrap_522(ref UnitTransFragment P0); // 0x0000000186A2D114-0x0000000186A2D278
		public void __Gen_Wrap_523(ref UnitTransFragment P0); // 0x0000000186A2D278-0x0000000186A2D3B8
		public int __Gen_Wrap_524(ref ValveFragment P0); // 0x0000000186A2D3B8-0x0000000186A2D51C
		public void __Gen_Wrap_525(ref ValveFragment P0); // 0x0000000186A2D51C-0x0000000186A2D660
		public int __Gen_Wrap_526(ref Beyond.Gameplay.Factory.BoxValve P0); // 0x0000000186A2D660-0x0000000186A2D794
		public void __Gen_Wrap_527(ref Beyond.Gameplay.Factory.BoxValve P0); // 0x0000000186A2D794-0x0000000186A2D8AC
		public int __Gen_Wrap_528(ref Beyond.Gameplay.Factory.FluidValve P0); // 0x0000000186A2D8AC-0x0000000186A2D9E0
		public void __Gen_Wrap_529(ref Beyond.Gameplay.Factory.FluidValve P0); // 0x0000000186A2D9E0-0x0000000186A2DAF8
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_530(Entity P0, ref EntityManager P1); // 0x0000000186A2DBFC-0x0000000186A2DD8C
		public bool __Gen_Wrap_531(ref BlueprintSlotInfo P0, ref EntityManager P1, int P2, int P3); // 0x0000000186A2DD8C-0x0000000186A2DFD0
		public void __Gen_Wrap_532(ref BlueprintSlotInfo P0, ref EntityManager P1, int P2, Entity P3); // 0x0000000186A2DFD0-0x0000000186A2E244
		public int __Gen_Wrap_533(ref BlueprintSlotInfo P0); // 0x0000000186A2E244-0x0000000186A2E3F4
		public int __Gen_Wrap_534(ref BlueprintSlotInfo P0, int P1); // 0x0000000186A2E3F4-0x0000000186A2E5C0
		public void __Gen_Wrap_535(ref BlueprintSlotInfo P0, int P1, int P2); // 0x0000000186A2E5C0-0x0000000186A2E78C
		public ulong[] __Gen_Wrap_536(ref BlueprintSlotInfo P0); // 0x0000000186A2E78C-0x0000000186A2E950
		public void __Gen_Wrap_537(ref BlueprintSlotInfo P0, int P1, Entity P2); // 0x0000000186A2E950-0x0000000186A2EB44
		public Entity[] __Gen_Wrap_538(ref BlueprintSlotInfo P0, int P1); // 0x0000000186A2EB44-0x0000000186A2ED20
		public void __Gen_Wrap_539(ref BlueprintSlotInfo P0, ref EntityManager P1, int P2, ref PooledList<uint> P3, ref PooledList<uint> P4, ref PooledList<Entity> P5); // 0x0000000186A2ED20-0x0000000186A2F058
		public ulong __Gen_Wrap_540(ref BlueprintSlotInfo P0, int P1); // 0x0000000186A2F1B4-0x0000000186A2F380
		public Entity __Gen_Wrap_541(ref BlueprintSlotInfo P0, int P1, int P2); // 0x0000000186A2F380-0x0000000186A2F570
		public NativeArray<Entity> __Gen_Wrap_542(ref BlueprintSlotInfo P0, int P1); // 0x0000000186A2F570-0x0000000186A2F764
		public string __Gen_Wrap_543(ref BlueprintSlotInfo P0); // 0x0000000186A2F764-0x0000000186A2F914
		public string __Gen_Wrap_544(ref ConveyorRendererInfo P0); // 0x0000000186A2F914-0x0000000186A2FA88
		public byte __Gen_Wrap_545(byte P0, bool P1, bool P2, bool P3, BlueprintState.EffectType P4); // 0x0000000186A2FA88-0x0000000186A2FB9C
		public byte __Gen_Wrap_546(ref PipeRendererInfo P0); // 0x0000000186A2FB9C-0x0000000186A2FCFC
		public bool __Gen_Wrap_547(ref PipeRendererInfo P0); // 0x0000000186A2FCFC-0x0000000186A2FE5C
		public BlueprintState.EffectType __Gen_Wrap_548(ref PipeRendererInfo P0); // 0x0000000186A2FE5C-0x0000000186A2FFBC
		public bool __Gen_Wrap_549(ref UnitId P0, UnitId P1); // 0x0000000186A2FFBC-0x0000000186A30124
		public bool __Gen_Wrap_550(ref UnitId P0, object P1); // 0x0000000186A30290-0x0000000186A303D4
		public int __Gen_Wrap_551(ref UnitId P0); // 0x0000000186A303D4-0x0000000186A3050C
		public bool __Gen_Wrap_552(ref Visibility P0, Visibility.EFlag P1, bool P2); // 0x0000000186A3050C-0x0000000186A30698
		public int __Gen_Wrap_553(ref WireRendererFragment P0); // 0x0000000186A30698-0x0000000186A307CC
		public void __Gen_Wrap_554(ref WireRendererFragment P0, int P1); // 0x0000000186A307CC-0x0000000186A3090C
		public void __Gen_Wrap_555(ref WireRendererFragment P0); // 0x0000000186A3090C-0x0000000186A30A24
		public void __Gen_Wrap_556(ref GlobalSharedData.MapGridRendererData P0); // 0x0000000186A30A24-0x0000000186A30BC4
		public void __Gen_Wrap_557(ref GlobalSharedData P0); // 0x0000000186A30BC4-0x0000000186A30CDC
		public void __Gen_Wrap_558(ref GlobalSharedData.CullingGlobalSetting P0); // 0x0000000186A30CDC-0x0000000186A30E28
		public void __Gen_Wrap_559(ref GlobalSharedData.CullingGlobalSetting P0, float P1); // 0x0000000186A30E28-0x0000000186A30F94
		public float __Gen_Wrap_560(ref GlobalSharedData.CullingGlobalSetting P0); // 0x0000000186A311DC-0x0000000186A31338
		public void __Gen_Wrap_561(ref GlobalSharedData.NearByDistanceGlobalSetting P0); // 0x0000000186A31338-0x0000000186A314AC
		public void __Gen_Wrap_562(ref GlobalSharedData.NearByDistanceGlobalSetting P0, float P1); // 0x0000000186A314AC-0x0000000186A31628
		public void __Gen_Wrap_563(ref GlobalSharedData.NearByDistanceGlobalSetting P0, bool P1); // 0x0000000186A31628-0x0000000186A317A4
		public bool __Gen_Wrap_564(ref GlobalSharedData.NearByDistanceGlobalSetting P0); // 0x0000000186A317A4-0x0000000186A31928
		public float __Gen_Wrap_565(ref GlobalSharedData.NearByDistanceGlobalSetting P0); // 0x0000000186A31928-0x0000000186A31AAC
		public void __Gen_Wrap_566(ref GlobalSharedData.World3DUiGlobalSetting P0, bool P1); // 0x0000000186A31AAC-0x0000000186A31BF4
		public void __Gen_Wrap_567(ref GlobalSharedData.World3DUiGlobalSetting P0); // 0x0000000186A31BF4-0x0000000186A31D30
		public bool __Gen_Wrap_568(ref GlobalSharedData.World3DUiGlobalSetting P0); // 0x0000000186A31D30-0x0000000186A31E7C
		public void __Gen_Wrap_569(ref GlobalSharedData.CurveGlobalSetting P0, ref Beyond.Gameplay.Factory.FPtrNativeCurve P1, ref Beyond.Gameplay.Factory.FPtrNativeCurve P2, ref Beyond.Gameplay.Factory.FPtrNativeCurve P3); // 0x0000000186A31E7C-0x0000000186A3214C
		public void __Gen_Wrap_570(ref GlobalSharedData.CurveGlobalSetting P0, ref Beyond.Gameplay.Factory.FPtrNativeCurve P1); // 0x0000000186A32374-0x0000000186A32558
		public void __Gen_Wrap_571(ref GlobalSharedData.MapGridRendererData P0, ref GlobalSharedData.MapGridRendererData.MapGridInfo[] P1, ref GlobalSharedData.MapGridRendererData.MapGridInfo[] P2); // 0x0000000186A32558-0x0000000186A3279C
		public GlobalSharedData.MapGridRendererData.MapGridInfo __Gen_Wrap_572(ref GlobalSharedData.MapGridRendererData P0, int P1); // 0x0000000186A3279C-0x0000000186A329A8
		public void __Gen_Wrap_573(ref GlobalSharedData.UnitPortConfigDB P0, int P1); // 0x0000000186A329A8-0x0000000186A32AF8
		public void __Gen_Wrap_574(ref GlobalSharedData.UnitPortConfigDB P0); // 0x0000000186A32AF8-0x0000000186A32C1C
		public bool __Gen_Wrap_575(ref GlobalSharedData.UnitPortConfigDB P0, int P1, out GlobalSharedData.UnitPortConfig P2); // 0x0000000186A32C1C-0x0000000186A32E38
		public bool __Gen_Wrap_576(ref GlobalSharedData.UnitPortConfigDB P0, object P1, out GlobalSharedData.UnitPortConfig P2); // 0x0000000186A32E38-0x0000000186A33058
		public void __Gen_Wrap_577(object P0, ref FactoryUnitPortConfig P1, int P2); // 0x0000000186A33058-0x0000000186A331D8
		public GlobalSharedData.UnitPortConfig __Gen_Wrap_578(ref GlobalSharedData.UnitPortConfigDB P0, object P1); // 0x0000000186A331D8-0x0000000186A333D0
		public void __Gen_Wrap_579(ref GlobalSharedData.UnitPortConfigDB P0, int P1, in GlobalSharedData.UnitPortConfig P2); // 0x0000000186A333D0-0x0000000186A335D4
		public void __Gen_Wrap_580(ref GlobalSharedData.UnitPortConfigDB P0, object P1, in GlobalSharedData.UnitPortConfig P2); // 0x0000000186A3382C-0x0000000186A33A30
		public GlobalSharedData.UnitPortConfig __Gen_Wrap_581(ref GlobalSharedData.UnitPortConfigDB P0, int P1); // 0x0000000186A33A30-0x0000000186A33C28
		public bool __Gen_Wrap_582(ref GlobalSharedData.UnitPortConfigDB P0, object P1); // 0x0000000186A33C28-0x0000000186A33D78
		public int __Gen_Wrap_583(ref GlobalSharedData.PerDrawGlobalSetting P0, LogicEntityState P1, LogicEntityType P2); // 0x0000000186A33D78-0x0000000186A33F58
		public void __Gen_Wrap_584(ref GlobalSharedData.PerDrawGlobalSetting P0, ref HGFactoryRendererBinderComponent P1, LogicEntityState P2, LogicEntityType P3); // 0x0000000186A33F58-0x0000000186A341A0
		public void __Gen_Wrap_585(ref GlobalSharedData.PerDrawGlobalSetting P0, ref HGFactoryRendererBinderComponent P1, LogicEntityState P2, LogicEntityType P3, uint P4); // 0x0000000186A341A0-0x0000000186A343E8
		public void __Gen_Wrap_586(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting P0, int P1, PerDrawConfig P2); // 0x0000000186A343E8-0x0000000186A34658
		public void __Gen_Wrap_587(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting P0, int P1, PerDrawPassConfig P2); // 0x0000000186A34658-0x0000000186A348C0
		public void __Gen_Wrap_588(ref GlobalSharedData.PerDrawGlobalSetting P0, object P1); // 0x0000000186A348C0-0x0000000186A34A7C
		public PerDrawPassConfig __Gen_Wrap_589(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting P0, int P1); // 0x0000000186A34A7C-0x0000000186A34CC8
		public PerDrawConfig __Gen_Wrap_590(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting P0, int P1); // 0x0000000186A34F48-0x0000000186A3519C
		public void __Gen_Wrap_591(ref GlobalSharedData.SystemIntervalGlobalSetting P0, int P1); // 0x0000000186A3519C-0x0000000186A35324
		public void __Gen_Wrap_592(ref GlobalSharedData.SystemIntervalGlobalSetting P0); // 0x0000000186A35324-0x0000000186A354A4
		public int __Gen_Wrap_593(ref GlobalSharedData.SystemIntervalGlobalSetting P0); // 0x0000000186A354A4-0x0000000186A35634
		public void __Gen_Wrap_594(ref GlobalSharedData.UIEffectPathConfig P0, object P1, object P2, object P3); // 0x0000000186A35634-0x0000000186A357CC
		public bool __Gen_Wrap_595(ref GlobalSharedData.UIEffectPathConfig P0, FacBuildingState P1, out FixedString32Bytes P2, out float4 P3, out float4 P4); // 0x0000000186A357CC-0x0000000186A35A24
		public void __Gen_Wrap_596(object P0, ref EntityManager P1, ref GlobalEnv P2, object P3); // 0x0000000186A35A24-0x0000000186A35D18
		public JobHandle __Gen_Wrap_597(object P0, ref EntityManager P1, long P2, long P3, int P4, int P5, int P6, ref GlobalEnv P7, JobHandle P8, NativeList<JobHandle> P9); // 0x0000000186A35D18-0x0000000186A36110
		public JobHandle __Gen_Wrap_598(object P0, ref EntityManager P1, long P2, long P3, float P4, int P5, int P6, int P7, ref GlobalEnv P8, JobHandle P9, NativeList<JobHandle> P10); // 0x0000000186A36110-0x0000000186A3651C
		public JobHandle __Gen_Wrap_599(object P0, ref EntityManager P1, ref GlobalEnv P2, int P3, int P4, int P5, JobHandle P6); // 0x0000000186A3651C-0x0000000186A368AC
		public void __Gen_Wrap_600(object P0, ref EntityManager P1, ref GlobalEnv P2); // 0x0000000186A36C64-0x0000000186A36F30
		public void __Gen_Wrap_601(object P0, ref NativeList<JobHandle> P1); // 0x0000000186A36F30-0x0000000186A37080
		public void __Gen_Wrap_602(object P0, ref JobHandle P1, ref NativeList<JobHandle> P2); // 0x0000000186A37080-0x0000000186A3724C
		public bool __Gen_Wrap_603(object P0, ref GlobalEnv P1); // 0x0000000186A3724C-0x0000000186A374B8
		public bool __Gen_Wrap_604(object P0, ref EntityManager P1); // 0x0000000186A374B8-0x0000000186A37618
		public FunctionPointer<UnsafeJobFuncPointers.ApplyRender> __Gen_Wrap_605(); // 0x0000000186A37618-0x0000000186A376E4
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> __Gen_Wrap_606(); // 0x0000000186A376E4-0x0000000186A377B0
		public FunctionPointer<UnsafeJobFuncPointers.QueryStateIconPath> __Gen_Wrap_607(); // 0x0000000186A377B0-0x0000000186A3787C
		public bool __Gen_Wrap_608(ref EntityManager P0, float P1, float P2, float P3, out UnitFragment P4); // 0x0000000186A3787C-0x0000000186A37AE0
		public FunctionPointer<UnsafeJobFuncPointers.QueryBuildingState> __Gen_Wrap_609(); // 0x0000000186A37AE0-0x0000000186A37BAC
		public FunctionPointer<UnsafeJobFuncPointers.SetEntityFlashStatue> __Gen_Wrap_610(); // 0x0000000186A37E2C-0x0000000186A37EF8
		public void __Gen_Wrap_611(ref AdditiveEffectJob P0, IntPtr P1); // 0x0000000186A37EF8-0x0000000186A38120
		public void __Gen_Wrap_612(ref AdditiveEffectJob P0, ref AdditiveEffectFragment P1, ref SharedDataContainer.SharedExtData P2); // 0x0000000186A38120-0x0000000186A3843C
		public void __Gen_Wrap_613(ref CutoffState P0, ref BuildDismissState P1); // 0x0000000186A3843C-0x0000000186A385EC
		public void __Gen_Wrap_614(ref AdditiveEffectJob P0, int P1); // 0x0000000186A385EC-0x0000000186A38800
		public void __Gen_Wrap_615(ref AdditiveEffectJob P0, int P1, int P2); // 0x0000000186A38800-0x0000000186A38A24
		public void __Gen_Wrap_616(ref AdditiveEffectJob P0, ref EntityQueryV2.QueryResultDefer P1); // 0x0000000186A38A24-0x0000000186A38CC8
		public JobHandle __Gen_Wrap_617(ref AdditiveEffectJob P0, JobHandle P1, int P2); // 0x0000000186A38CC8-0x0000000186A38F60
		public JobHandle __Gen_Wrap_618(ref AdditiveEffectJob P0, JobHandle P1, JobHandle P2, int P3); // 0x0000000186A38F60-0x0000000186A39214
		public void __Gen_Wrap_619(ref AdditiveEffectQueryJob P0); // 0x0000000186A39214-0x0000000186A39354
		public void __Gen_Wrap_620(ref AdditiveEffectQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, ref EntityQueryV2.QueryResultDefer P2, ref EntityQueryV2.QueryResultDefer P3, bool P4); // 0x0000000186A395D4-0x0000000186A398B0
		public void __Gen_Wrap_621(ref AdditiveEffectRenderJob P0, ref SharedDataContainer.SharedExtData P1, ref AdditiveEffectRendererFragment P2, ref HGFactoryRendererBinderComponent P3); // 0x0000000186A398B0-0x0000000186A39C38
		public void __Gen_Wrap_622(ref AdditiveEffectRenderJob P0, IntPtr P1); // 0x0000000186A39C38-0x0000000186A39E48
		public void __Gen_Wrap_623(ref HGFactoryRendererBinderComponent P0, ref SharedDataContainer.SharedExtData P1, bool P2, bool P3); // 0x0000000186A39E48-0x0000000186A3A03C
		public void __Gen_Wrap_624(ref EntityManager P0, ref SharedDataContainer.SharedExtData P1, ref HGFactoryRendererBinderComponent P2, ref Beyond.Gameplay.Factory.FPtrNativeCurve P3, ref Beyond.Gameplay.Factory.FPtrNativeCurve P4, ref Beyond.Gameplay.Factory.FPtrNativeCurve P5, long P6); // 0x0000000186A3A03C-0x0000000186A3A440
		public void __Gen_Wrap_625(ref EntityManager P0, ref SharedDataContainer.SharedExtData P1, ref HGFactoryRendererBinderComponent P2); // 0x0000000186A3A440-0x0000000186A3A68C
		public void __Gen_Wrap_626(ref AdditiveEffectRenderJob P0, int P1); // 0x0000000186A3A68C-0x0000000186A3A884
		public void __Gen_Wrap_627(ref AdditiveEffectRenderJob P0, int P1, int P2); // 0x0000000186A3A884-0x0000000186A3AA90
		public void __Gen_Wrap_628(ref AdditiveEffectRenderJob P0, ref EntityQueryV2.QueryResultDefer P1); // 0x0000000186A3AA90-0x0000000186A3AD1C
		public JobHandle __Gen_Wrap_629(ref AdditiveEffectRenderJob P0, JobHandle P1, int P2); // 0x0000000186A3AD1C-0x0000000186A3AF84
		public JobHandle __Gen_Wrap_630(ref AdditiveEffectRenderJob P0, JobHandle P1, JobHandle P2, int P3); // 0x0000000186A3B204-0x0000000186A3B4B0
		public void __Gen_Wrap_631(ref AudioJobs.AudioDistanceAndCullingJob P0, int P1); // 0x0000000186A3B4B0-0x0000000186A3B620
		public void __Gen_Wrap_632(ref AudioJobs.AudioGroupEmitterJob P0, int P1); // 0x0000000186A3B620-0x0000000186A3B79C
		public void __Gen_Wrap_633(ref AudioJobs.AudioGroupEmitterJob P0, IntPtr P1); // 0x0000000186A3B79C-0x0000000186A3B928
		public void __Gen_Wrap_634(ref AudioJobs.WaterPipeEmitterJob P0, ref AudioJobs.FPipeEmitterData P1, ref PipeFragment P2); // 0x0000000186A3B928-0x0000000186A3BC58
		public void __Gen_Wrap_635(ref AudioJobs.WaterPipeEmitterJob P0, ref AudioJobs.FPipeEmitterTempData P1, ref PipeFragment P2); // 0x0000000186A3BC58-0x0000000186A3BF9C
		public void __Gen_Wrap_636(ref AudioJobs.WaterPipeEmitterJob P0, int P1); // 0x0000000186A3BF9C-0x0000000186A3C118
		public void __Gen_Wrap_637(ref AudioJobs.WaterPipeEmitterJob P0, ref GlobalEnv P1); // 0x0000000186A3C118-0x0000000186A3C420
		public void __Gen_Wrap_638(ref BatchArrowJob P0, ref FixedList512Bytes<FactoryUnitPortConfig> P1, quaternion P2, float3 P3, ComplexPortFragment P4, float4x4 P5, bool P6, float P7, bool P8, bool P9, bool P10, bool P11, bool P12, bool P13, bool P14, bool P15, bool P16, bool P17, bool P18); // 0x0000000186A3C420-0x0000000186A3C89C
		public void __Gen_Wrap_639(ref BatchArrowJob P0, int P1, EntityQueryV2.QueryResult P2); // 0x0000000186A3C89C-0x0000000186A3CA44
		public void __Gen_Wrap_640(ref BatchArrowJob P0, int P1); // 0x0000000186A3CCC4-0x0000000186A3CE24
		public void __Gen_Wrap_641(ref BatchArrowJob P0, IntPtr P1); // 0x0000000186A3CE24-0x0000000186A3CF98
		public void __Gen_Wrap_642(ref BatchArrowJob P0); // 0x0000000186A3CF98-0x0000000186A3D0DC
		public void __Gen_Wrap_643(ref BatchInsideConveyorJob P0, uint P1, float3 P2, quaternion P3, ref FixedList512Bytes<FactoryUnitPortConfig> P4, ref ComplexPortFragment P5, bool P6, float P7, bool P8); // 0x0000000186A3D0DC-0x0000000186A3D4AC
		public void __Gen_Wrap_644(ref BatchInsideConveyorJob P0, int P1, EntityQueryV2.QueryResult P2); // 0x0000000186A3D4AC-0x0000000186A3D654
		public void __Gen_Wrap_645(ref BatchInsideConveyorJob P0, int P1); // 0x0000000186A3D654-0x0000000186A3D7B4
		public void __Gen_Wrap_646(ref BatchInsideConveyorJob P0, IntPtr P1); // 0x0000000186A3D7B4-0x0000000186A3D928
		public void __Gen_Wrap_647(ref BatchInsideConveyorJob P0); // 0x0000000186A3D928-0x0000000186A3DA6C
		public void __Gen_Wrap_648(ref BatchNormalArrowJob P0, uint P1, ref FixedList512Bytes<FactoryUnitPortConfig> P2, quaternion P3, float3 P4, ComplexPortFragment P5, float4x4 P6, bool P7, float P8, bool P9, bool P10, bool P11, bool P12, bool P13, bool P14, bool P15, bool P16, bool P17); // 0x0000000186A3DA6C-0x0000000186A3DED8
		public void __Gen_Wrap_649(ref BatchNormalArrowJob P0, int P1, EntityQueryV2.QueryResult P2); // 0x0000000186A3DED8-0x0000000186A3E080
		public void __Gen_Wrap_650(ref BatchNormalArrowJob P0, int P1); // 0x0000000186A3E300-0x0000000186A3E460
		public void __Gen_Wrap_651(ref BatchNormalArrowJob P0); // 0x0000000186A3E460-0x0000000186A3E5A4
		public void __Gen_Wrap_652(ref BatchNormalArrowJob P0, IntPtr P1); // 0x0000000186A3E5A4-0x0000000186A3E718
		public void __Gen_Wrap_653(ref BatchPreviewArrowJob P0, ref FixedList512Bytes<FactoryUnitPortConfig> P1, quaternion P2, float3 P3, ComplexPortFragment P4, float4x4 P5, bool P6, float P7, bool P8, bool P9, bool P10); // 0x0000000186A3E718-0x0000000186A3EAFC
		public void __Gen_Wrap_654(ref BatchPreviewArrowJob P0, int P1, EntityQueryV2.QueryResult P2); // 0x0000000186A3EAFC-0x0000000186A3ECA4
		public void __Gen_Wrap_655(ref BatchPreviewArrowJob P0); // 0x0000000186A3ECA4-0x0000000186A3EDE8
		public void __Gen_Wrap_656(ref BatchPreviewArrowJob P0, IntPtr P1); // 0x0000000186A3EDE8-0x0000000186A3EF5C
		public void __Gen_Wrap_657(ref BufferSwapJob P0); // 0x0000000186A3EF5C-0x0000000186A3F080
		public void __Gen_Wrap_658(ref BuildingEnvRenderJob P0, Entity P1, ref UnitEnvironmentRelation P2); // 0x0000000186A3F080-0x0000000186A3F270
		public void __Gen_Wrap_659(ref BuildingEnvRenderJob P0, int P1); // 0x0000000186A3F270-0x0000000186A3F3BC
		public void __Gen_Wrap_660(ref BuildingEnvRenderJob P0, ref EntityQueryV2.QueryResultDefer P1); // 0x0000000186A3F63C-0x0000000186A3F80C
		public JobHandle __Gen_Wrap_661(ref BuildingEnvRenderJob P0, JobHandle P1, int P2); // 0x0000000186A3F80C-0x0000000186A3F9D8
		public void __Gen_Wrap_662(ref BuildingEnvRenderJob P0, int P1, int P2); // 0x0000000186A3F9D8-0x0000000186A3FB3C
		public void __Gen_Wrap_663(ref BuildingEnvRenderJob P0, IntPtr P1); // 0x0000000186A3FB3C-0x0000000186A3FC98
		public void __Gen_Wrap_664(ref BuildingLiquidRenderJob P0, Entity P1, ValueTuple<int, uint> P2); // 0x0000000186A3FC98-0x0000000186A3FE38
		public void __Gen_Wrap_665(ref BuildingLiquidRenderJob P0, int P1); // 0x0000000186A3FE38-0x0000000186A3FF84
		public void __Gen_Wrap_666(ref BuildingLiquidRenderJob P0, int P1, int P2); // 0x0000000186A3FF84-0x0000000186A400E8
		public void __Gen_Wrap_667(ref BuildingLiquidRenderJob P0, ref EntityQueryV2.QueryResultDefer P1); // 0x0000000186A400E8-0x0000000186A402B8
		public JobHandle __Gen_Wrap_668(ref BuildingLiquidRenderJob P0, JobHandle P1, int P2); // 0x0000000186A402B8-0x0000000186A40484
		public void __Gen_Wrap_669(ref BuildingLiquidRenderJob P0, IntPtr P1); // 0x0000000186A40484-0x0000000186A405E0
		public void __Gen_Wrap_670(ref BuildingStatePosCollectJob P0, ref UnitFragment P1, ref UnitTransFragment P2, ref UnitConfigFragment P3, ref UnitStatusFragment P4, ref SharedDataFragment P5); // 0x0000000186A40860-0x0000000186A40E08
		public void __Gen_Wrap_671(ref BuildingStatePosCollectJob P0, int P1); // 0x0000000186A40E08-0x0000000186A40F88
		public void __Gen_Wrap_672(ref BuildingStatePosCollectJob P0, int P1, int P2); // 0x0000000186A40F88-0x0000000186A41120
		public void __Gen_Wrap_673(ref BuildingStatePosCollectJob P0); // 0x0000000186A41120-0x0000000186A41284
		public void __Gen_Wrap_674(ref BuildingStatePosCollectJob P0, IntPtr P1); // 0x0000000186A41284-0x0000000186A41414
		public void __Gen_Wrap_675(ref BuildingStateRendererJob P0, int P1); // 0x0000000186A41414-0x0000000186A41570
		public void __Gen_Wrap_676(ref CargoCollectJob P0, int P1); // 0x0000000186A41570-0x0000000186A416F0
		public void __Gen_Wrap_677(ref CargoCollectJob P0); // 0x0000000186A416F0-0x0000000186A41854
		public void __Gen_Wrap_678(ref CargoCollectJob P0, ref GlobalEnv P1); // 0x0000000186A41854-0x0000000186A41B60
		public void __Gen_Wrap_679(ref CargoCollectJob P0, IntPtr P1); // 0x0000000186A41B60-0x0000000186A41CF0
		public void __Gen_Wrap_680(ref CargoPredictJob P0, int P1); // 0x0000000186A41F70-0x0000000186A420E0
		public void __Gen_Wrap_681(ref CargoPredictJob P0, IntPtr P1); // 0x0000000186A420E0-0x0000000186A42260
		public void __Gen_Wrap_682(ref CargoPredictJob P0, ref EntityQueryV2.QueryResultDefer P1); // 0x0000000186A42260-0x0000000186A42454
		public JobHandle __Gen_Wrap_683(ref CargoPredictJob P0, JobHandle P1, int P2); // 0x0000000186A42454-0x0000000186A42644
		public void __Gen_Wrap_684(ref CargoPredictQueryJob P0); // 0x0000000186A42644-0x0000000186A42774
		public void __Gen_Wrap_685(ref CargoPredictQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2); // 0x0000000186A42774-0x0000000186A42960
		public void __Gen_Wrap_686(ref CargoRenderJob P0, int P1, int P2); // 0x0000000186A42960-0x0000000186A42AD4
		public void __Gen_Wrap_687(ref CargoRenderJob P0, IntPtr P1); // 0x0000000186A42AD4-0x0000000186A42C40
		public void __Gen_Wrap_688(ref CargoRenderJob P0, in EntityManager P1, int P2); // 0x0000000186A42C40-0x0000000186A42DFC
		public void __Gen_Wrap_689(ref CargoRenderQueryJob P0); // 0x0000000186A42DFC-0x0000000186A42F2C
		public void __Gen_Wrap_690(ref CargoRenderQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2); // 0x0000000186A431AC-0x0000000186A43384
		public void __Gen_Wrap_691(ref ClearRendererVisibleDirtyJob P0); // 0x0000000186A43384-0x0000000186A434A8
		public void __Gen_Wrap_692(ref ClearRendererVisibleDirtyJob P0, IntPtr P1); // 0x0000000186A434A8-0x0000000186A435F8
		public void __Gen_Wrap_693(ref ConveyorCollectJob P0, ref ConveyorFragment P1, ref SharedDataFragment P2, bool P3, bool P4); // 0x0000000186A435F8-0x0000000186A43878
		public void __Gen_Wrap_694(ref ConveyorCollectJob P0, int P1); // 0x0000000186A43878-0x0000000186A439F8
		public void __Gen_Wrap_695(ref ConveyorCollectJob P0, int P1, int P2); // 0x0000000186A439F8-0x0000000186A43B90
		public void __Gen_Wrap_696(ref ConveyorCollectJob P0); // 0x0000000186A43B90-0x0000000186A43CF4
		public void __Gen_Wrap_697(ref ConveyorCollectJob P0, IntPtr P1); // 0x0000000186A43CF4-0x0000000186A43E84
		public void __Gen_Wrap_698(ref ConveyorFigureRendererJob P0, int P1, int P2); // 0x0000000186A43E84-0x0000000186A4402C
		public void __Gen_Wrap_699(ref ConveyorFigureRendererJob P0, IntPtr P1); // 0x0000000186A4402C-0x0000000186A441CC
		public void __Gen_Wrap_700(ref ConveyorFigureRendererJob P0, in EntityManager P1, int P2); // 0x0000000186A44428-0x0000000186A44620
		public void __Gen_Wrap_701(ref ConveyorInsideRenderJob P0, int P1); // 0x0000000186A44620-0x0000000186A447BC
		public void __Gen_Wrap_702(ref ConveyorPreviewCollectJob P0, ref ConveyorPreviewRendererFragment P1, ref SharedDataFragment P2, bool P3, bool P4); // 0x0000000186A447BC-0x0000000186A44A28
		public void __Gen_Wrap_703(ref ConveyorPreviewCollectJob P0, int P1); // 0x0000000186A44A28-0x0000000186A44BA4
		public void __Gen_Wrap_704(ref ConveyorPreviewCollectJob P0); // 0x0000000186A44BA4-0x0000000186A44D04
		public void __Gen_Wrap_705(ref ConveyorPreviewCollectJob P0, IntPtr P1); // 0x0000000186A44D04-0x0000000186A44E90
		public void __Gen_Wrap_706(ref ConveyorRendererJob P0, Entity P1, uint P2); // 0x0000000186A44E90-0x0000000186A45080
		public void __Gen_Wrap_707(ref ConveyorRendererJob P0, Entity P1, float P2, uint P3, float3 P4, float3 P5, float P6, float P7, float P8, bool P9, BlueprintState.EffectType P10, float P11, uint P12, bool P13, bool P14); // 0x0000000186A45080-0x0000000186A453B4
		public void __Gen_Wrap_708(ref ConveyorRendererJob P0, int P1, int P2); // 0x0000000186A453B4-0x0000000186A4558C
		public void __Gen_Wrap_709(ref ConveyorRendererJob P0, IntPtr P1); // 0x0000000186A4558C-0x0000000186A45760
		public void __Gen_Wrap_710(ref ConveyorRendererJob P0, in EntityManager P1, int P2); // 0x0000000186A459EC-0x0000000186A45C10
		public void __Gen_Wrap_711(ref EnvGeneratorCollectJob P0, ref UnitFragment P1, ref UnitTransFragment P2, ref UnitEnvironmentRelation P3, ref SharedDataFragment P4); // 0x0000000186A45C10-0x0000000186A460AC
		public void __Gen_Wrap_712(ref EnvGeneratorCollectJob P0, int P1); // 0x0000000186A460AC-0x0000000186A4621C
		public void __Gen_Wrap_713(ref EnvGeneratorCollectJob P0, int P1, int P2); // 0x0000000186A4621C-0x0000000186A463A4
		public void __Gen_Wrap_714(ref EnvGeneratorCollectJob P0); // 0x0000000186A463A4-0x0000000186A464F8
		public void __Gen_Wrap_715(ref EnvGeneratorCollectJob P0, IntPtr P1); // 0x0000000186A464F8-0x0000000186A46678
		public void __Gen_Wrap_716(ref EnvGeneratorRenderJob P0, int P1); // 0x0000000186A46678-0x0000000186A467D4
		public void __Gen_Wrap_717(ref InteractFacCollectJob P0); // 0x0000000186A467D4-0x0000000186A469DC
		public bool __Gen_Wrap_718(float3 P0, float3 P1, float3 P2, float P3, float P4, out float P5, out float P6, bool P7); // 0x0000000186A469DC-0x0000000186A46BEC
		public void __Gen_Wrap_719(ref InteractFacCollectJob.BuildingInfo P0, in InteractFacCollectJob.BuildingInfo P1); // 0x0000000186A46BEC-0x0000000186A46DC0
		public float3 __Gen_Wrap_720(float3 P0); // 0x0000000186A4704C-0x0000000186A4717C
		public bool __Gen_Wrap_721(ref InteractFacCollectJob P0, float3 P1, float P2, ref int P3); // 0x0000000186A4717C-0x0000000186A47434
		public void __Gen_Wrap_722(ref InteractFacCollectJob P0, IntPtr P1); // 0x0000000186A47434-0x0000000186A4766C
		public string __Gen_Wrap_723(ref InteractFacCollectJob.BuildingInfo P0); // 0x0000000186A4766C-0x0000000186A477FC
		public void __Gen_Wrap_724(ref InteractFacCollectJob.BuildingInfo P0, object P1); // 0x0000000186A477FC-0x0000000186A47984
		public bool __Gen_Wrap_725(ref InteractFacCollectJob.BuildingInfo P0); // 0x0000000186A47984-0x0000000186A47B00
		public bool __Gen_Wrap_726(ref InteractFacCollectJob.LogisticInfo P0); // 0x0000000186A47B00-0x0000000186A47C40
		public void __Gen_Wrap_727(ref LocalToWorldJob P0, int P1); // 0x0000000186A47C40-0x0000000186A47D90
		public void __Gen_Wrap_728(ref LocalToWorld P0, IntPtr P1, int P2); // 0x0000000186A47D90-0x0000000186A47FAC
		public void __Gen_Wrap_729(ref LocalToWorldJob P0, int P1, int P2); // 0x0000000186A47FAC-0x0000000186A48114
		public void __Gen_Wrap_730(ref LocalToWorldJob P0, IntPtr P1); // 0x0000000186A483A0-0x0000000186A48500
		public void __Gen_Wrap_731(ref LocalToWorldJob P0, ref EntityQueryV2.QueryResultDefer P1); // 0x0000000186A48500-0x0000000186A486D4
		public JobHandle __Gen_Wrap_732(ref LocalToWorldJob P0, JobHandle P1, int P2); // 0x0000000186A486D4-0x0000000186A488A4
		public void __Gen_Wrap_733(ref LocalToWorldQueryJob P0); // 0x0000000186A488A4-0x0000000186A489D4
		public void __Gen_Wrap_734(ref LocalToWorldQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2); // 0x0000000186A489D4-0x0000000186A48BC0
		public void __Gen_Wrap_735(ref LogisticEffectJob P0, int P1); // 0x0000000186A48BC0-0x0000000186A48D20
		public void __Gen_Wrap_736(ref LogisticsFigureRendererJob P0, int P1); // 0x0000000186A48D20-0x0000000186A48E90
		public void __Gen_Wrap_737(ref LogisticsFigureRendererJob P0, int P1, int P2); // 0x0000000186A48E90-0x0000000186A49018
		public void __Gen_Wrap_738(ref LogisticsHideRendererJob P0, int P1); // 0x0000000186A49018-0x0000000186A49174
		public void __Gen_Wrap_739(ref LogisticsHideRendererJob P0, int P1, int P2); // 0x0000000186A49174-0x0000000186A492E8
		public void __Gen_Wrap_740(ref LogisticsHideRendererJob P0, IntPtr P1); // 0x0000000186A492E8-0x0000000186A49454
		public void __Gen_Wrap_741(ref LookAtJob P0, int P1); // 0x0000000186A49454-0x0000000186A49590
		public void __Gen_Wrap_742(ref LookAtJob P0, IntPtr P1); // 0x0000000186A49590-0x0000000186A496E0
		public void __Gen_Wrap_743(ref LookAtJob P0, ref EntityQueryV2.QueryResultDefer P1); // 0x0000000186A496E0-0x0000000186A498A4
		public JobHandle __Gen_Wrap_744(ref LookAtJob P0, JobHandle P1, int P2); // 0x0000000186A498A4-0x0000000186A49A64
		public void __Gen_Wrap_745(ref LookAtQueryJob P0); // 0x0000000186A49A64-0x0000000186A49B94
		public void __Gen_Wrap_746(ref LookAtQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2); // 0x0000000186A49B94-0x0000000186A49D80
		public void __Gen_Wrap_747(ref OutputCollectJob P0, ref UnitFragment P1, ref UnitTransFragment P2, ref UnitConfigFragment P3, ref OutputFragment P4, ref SharedDataFragment P5); // 0x0000000186A49D80-0x0000000186A4A33C
		public void __Gen_Wrap_748(ref OutputCollectJob P0, int P1); // 0x0000000186A4A33C-0x0000000186A4A4AC
		public void __Gen_Wrap_749(ref OutputCollectJob P0, int P1, int P2); // 0x0000000186A4A4AC-0x0000000186A4A634
		public void __Gen_Wrap_750(ref OutputCollectJob P0); // 0x0000000186A4A700-0x0000000186A4A854
		public void __Gen_Wrap_751(ref OutputCollectJob P0, IntPtr P1); // 0x0000000186A4A854-0x0000000186A4A9D4
		public void __Gen_Wrap_752(ref OutputRenderJob P0, int P1); // 0x0000000186A4A9D4-0x0000000186A4AB30
		public float4 __Gen_Wrap_753(ref PedestalFlashJob P0, ref PedestalLightFlashFragment P1, float P2); // 0x0000000186A4AB30-0x0000000186A4AD7C
		public void __Gen_Wrap_754(ref PedestalFlashJob P0, int P1); // 0x0000000186A4AD7C-0x0000000186A4AED8
		public void __Gen_Wrap_755(ref PedestalFlashJob P0, int P1, int P2); // 0x0000000186A4AED8-0x0000000186A4B04C
		public void __Gen_Wrap_756(ref PedestalFlashJob P0, IntPtr P1); // 0x0000000186A4B04C-0x0000000186A4B1B8
		public int __Gen_Wrap_757(ref PipeCollectJob P0); // 0x0000000186A4B1B8-0x0000000186A4B3B4
		public void __Gen_Wrap_758(ref PipeCollectJob P0, int P1, uint P2, uint P3, int P4, bool P5, float P6, float P7, float P8, float P9, float P10, uint P11, bool P12, bool P13, bool P14); // 0x0000000186A4B3B4-0x0000000186A4B6B4
		public void __Gen_Wrap_759(ref PipeCollectJob P0, in PipeFragment P1, uint P2); // 0x0000000186A4B6B4-0x0000000186A4B958
		public void __Gen_Wrap_760(ref PipeCollectJob P0, EntityQueryV2.BlockRange P1, NativeList<GroupType> P2); // 0x0000000186A4B958-0x0000000186A4BBC0
		public void __Gen_Wrap_761(ref PipeCollectJob P0, int P1, uint P2, uint P3, float P4, float P5, float P6, uint P7, bool P8); // 0x0000000186A4BBC0-0x0000000186A4BE4C
		public void __Gen_Wrap_762(ref PipeCollectJob P0, int P1); // 0x0000000186A4BE4C-0x0000000186A4C050
		public void __Gen_Wrap_763(ref PipeCollectJob P0, int P1, int P2); // 0x0000000186A4C050-0x0000000186A4C268
		public void __Gen_Wrap_764(ref PipeCollectJob P0); // 0x0000000186A4C268-0x0000000186A4C454
		public void __Gen_Wrap_765(ref PipeCollectJob P0, ref GlobalEnv P1); // 0x0000000186A4C454-0x0000000186A4C7C8
		public void __Gen_Wrap_766(ref PipeCollectJob P0, IntPtr P1, int P2); // 0x0000000181528D10-0x0000000181529A90
		public void __Gen_Wrap_767(ref PipeComRendererJob P0, int P1, int P2); // 0x0000000186A4C7C8-0x0000000186A4C94C
		public void __Gen_Wrap_768(ref PipeFigureRendererJob P0, Entity P1, byte P2, float3 P3, float3 P4, float P5, float P6, float P7, float P8, short P9, bool P10, bool P11, bool P12); // 0x0000000186A4C94C-0x0000000186A4CBF8
		public void __Gen_Wrap_769(ref PipeFigureRendererJob P0, int P1, int P2); // 0x0000000186A4CBF8-0x0000000186A4CD8C
		public void __Gen_Wrap_770(ref PipeFigureRendererJob P0, in EntityManager P1, int P2); // 0x0000000186A4CF18-0x0000000186A4D0F4
		public void __Gen_Wrap_771(ref PipeLogisticsPosCollectJob P0, int P1); // 0x0000000186A4D0F4-0x0000000186A4D250
		public void __Gen_Wrap_772(ref PipeLogisticsPosCollectJob P0, int P1, int P2); // 0x0000000186A4D250-0x0000000186A4D3C4
		public void __Gen_Wrap_773(ref PipeLogisticsPosCollectJob P0, IntPtr P1); // 0x0000000186A4D3C4-0x0000000186A4D530
		public void __Gen_Wrap_774(ref PipeLogisticsPosCollectJob P0); // 0x0000000186A4D530-0x0000000186A4D670
		public void __Gen_Wrap_775(ref PipeRendererJob P0, Entity P1, uint P2); // 0x0000000186A4D670-0x0000000186A4D884
		public void __Gen_Wrap_776(ref PipeRendererJob P0, Entity P1, byte P2, float3 P3, float3 P4, float P5, uint P6, int P7, int P8, float P9, float P10, float P11, float P12, BlueprintState.EffectType P13, float P14, uint P15, bool P16, bool P17, bool P18); // 0x0000000186A4D884-0x0000000186A4DC28
		public void __Gen_Wrap_777(ref PipeRendererJob P0, int P1, int P2); // 0x0000000186A4DC28-0x0000000186A4DE1C
		public void __Gen_Wrap_778(ref PipeRendererJob P0, IntPtr P1, int P2); // 0x0000000181529A90-0x000000018152AB60
		public void __Gen_Wrap_779(ref PipeRendererJob P0, in EntityManager P1, in EntityManager P2, int P3); // 0x0000000186A4DE1C-0x0000000186A4E098
		public void __Gen_Wrap_780(ref PipeTrackRendererJob P0, Entity P1, float3 P2, float3 P3, float P4, float P5, float P6, float P7, float P8, bool P9); // 0x0000000186A4E1EC-0x0000000186A4E498
		public void __Gen_Wrap_781(ref PipeTrackRendererJob P0); // 0x0000000186A4E498-0x0000000186A4E618
		public void __Gen_Wrap_782(ref PipeWaterThicknessQueryJob P0); // 0x0000000186A4E618-0x0000000186A4E748
		public void __Gen_Wrap_783(ref PipeWaterThicknessQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2); // 0x0000000186A4E748-0x0000000186A4E934
		public void __Gen_Wrap_784(ref PipeWaterThicknessRiseJob P0, int P1); // 0x0000000186A4E934-0x0000000186A4EA84
		public void __Gen_Wrap_785(ref PipeWaterThicknessRiseJob P0, int P1, int P2); // 0x0000000186A4EA84-0x0000000186A4EBEC
		public void __Gen_Wrap_786(ref PipeWaterThicknessRiseJob P0, ref GlobalEnv P1); // 0x0000000186A4EBEC-0x0000000186A4EEC8
		public void __Gen_Wrap_787(ref PipeWaterThicknessRiseJob P0, ref EntityQueryV2.QueryResultDefer P1); // 0x0000000186A4EEC8-0x0000000186A4F09C
		public JobHandle __Gen_Wrap_788(ref PipeWaterThicknessRiseJob P0, JobHandle P1, int P2); // 0x0000000186A4F09C-0x0000000186A4F26C
		public void __Gen_Wrap_789(ref PortArrowRenderJob P0, int P1); // 0x0000000186A4F26C-0x0000000186A4F3D8
		public void __Gen_Wrap_790(ref PortStateCollectJob P0, ref ComplexPortFragment P1, ref SharedDataContainer.SharedExtData P2); // 0x0000000186A4F3D8-0x0000000186A4F668
		public void __Gen_Wrap_791(ref PortStateCollectJob P0, int P1); // 0x0000000186A4F668-0x0000000186A4F7D8
		public void __Gen_Wrap_792(ref PortStateCollectJob P0, IntPtr P1); // 0x0000000186A4F7D8-0x0000000186A4F958
		public void __Gen_Wrap_793(ref PortStateCollectJob P0); // 0x0000000186A4F958-0x0000000186A4FAAC
		public void __Gen_Wrap_794(ref PortStateCollectJob P0, int P1, int P2); // 0x0000000186A4FAAC-0x0000000186A4FC34
		public void __Gen_Wrap_795(ref PortStateRendererJob P0, int P1); // 0x0000000186A4FC34-0x0000000186A4FD90
		public void __Gen_Wrap_796(ref PreviewUnitQueryJob P0); // 0x0000000186A4FD90-0x0000000186A4FEC0
		public void __Gen_Wrap_797(ref PreviewUnitQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2); // 0x0000000186A4FEC0-0x0000000186A500AC
		public void __Gen_Wrap_798(ref PumpInEffectJob P0, int P1); // 0x0000000186A500AC-0x0000000186A501F8
		public void __Gen_Wrap_799(ref PumpInEffectJob P0, int P1, int P2); // 0x0000000186A501F8-0x0000000186A5035C
		public void __Gen_Wrap_800(ref PumpInEffectJob P0, ref EntityQueryV2.QueryResultDefer P1); // 0x0000000186A5044C-0x0000000186A5061C
		public JobHandle __Gen_Wrap_801(ref PumpInEffectJob P0, JobHandle P1, int P2); // 0x0000000186A5061C-0x0000000186A507E8
		public void __Gen_Wrap_802(ref PumpInEffectJob P0, IntPtr P1); // 0x0000000186A507E8-0x0000000186A50944
		public void __Gen_Wrap_803(ref ResetHierarchyDirtyJob P0); // 0x0000000186A50944-0x0000000186A50A68
		public void __Gen_Wrap_804(ref ResetHierarchyDirtyJob P0, IntPtr P1); // 0x0000000186A50A68-0x0000000186A50BB8
		public void __Gen_Wrap_805(ref StatusChangeJob P0, int P1); // 0x0000000186A50BB8-0x0000000186A50D78
		public void __Gen_Wrap_806(ref UnitCullingJob P0, int P1); // 0x0000000186A50D78-0x0000000186A50F04
		public void __Gen_Wrap_807(ref UnitCullingJob P0, int P1, int P2); // 0x0000000186A50F04-0x0000000186A510A8
		public void __Gen_Wrap_808(ref UnitCullingJob P0, ref GlobalEnv P1); // 0x0000000186A510A8-0x0000000186A513C0
		public void __Gen_Wrap_809(ref UnitCullingJob P0, IntPtr P1); // 0x0000000186A513C0-0x0000000186A5155C
		public void __Gen_Wrap_810(ref UnitPreviewRenderJob P0, int P1); // 0x0000000186A51648-0x0000000186A51798
		public void __Gen_Wrap_811(ref UnitPreviewRenderJob P0, int P1, int P2); // 0x0000000186A51798-0x0000000186A51900
		public void __Gen_Wrap_812(ref UnitPreviewRenderJob P0, ref GlobalEnv P1); // 0x0000000186A51900-0x0000000186A51BDC
		public void __Gen_Wrap_813(ref UnitPreviewRenderJob P0, IntPtr P1); // 0x0000000186A51BDC-0x0000000186A51D3C
		public void __Gen_Wrap_814(ref UnitPreviewRenderJob P0, ref EntityQueryV2.QueryResultDefer P1); // 0x0000000186A51D3C-0x0000000186A51F10
		public JobHandle __Gen_Wrap_815(ref UnitPreviewRenderJob P0, JobHandle P1, int P2); // 0x0000000186A51F10-0x0000000186A520E0
		public void __Gen_Wrap_816(ref UnitRendererQueryJob P0); // 0x0000000186A520E0-0x0000000186A52234
		public void __Gen_Wrap_817(ref UnitRendererQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, ref EntityQueryV2.QueryResultDefer P2, ref EntityQueryV2.QueryResultDefer P3, ref EntityQueryV2.QueryResultDefer P4, bool P5); // 0x0000000186A52234-0x0000000186A525A4
		public void __Gen_Wrap_818(ref UpdateUnitRendererTRSJob P0, int P1); // 0x0000000186A525A4-0x0000000186A526E0
		public void __Gen_Wrap_819(ref UpdateUnitRendererTRSJob P0, int P1, int P2); // 0x0000000186A526E0-0x0000000186A52838
		public void __Gen_Wrap_820(ref UpdateUnitRendererTRSJob P0, IntPtr P1); // 0x0000000186A52838-0x0000000186A52988
		public void __Gen_Wrap_821(ref UpdateUnitRendererTRSJob P0, ref EntityQueryV2.QueryResultDefer P1); // 0x0000000186A52988-0x0000000186A52B4C
		public JobHandle __Gen_Wrap_822(ref UpdateUnitRendererTRSJob P0, JobHandle P1, int P2); // 0x0000000186A52B4C-0x0000000186A52D0C
		public void __Gen_Wrap_823(ref WireCollectJob P0, int P1); // 0x0000000186A52D0C-0x0000000186A52F04
		public void __Gen_Wrap_824(ref WireCollectJob P0); // 0x0000000186A52F04-0x0000000186A530E0
		public void __Gen_Wrap_825(ref WireCollectJob P0, ref GlobalEnv P1); // 0x0000000186A530E0-0x0000000186A53444
		public void __Gen_Wrap_826(ref WireCollectJob P0, IntPtr P1); // 0x0000000186A53444-0x0000000186A53650
		public void __Gen_Wrap_827(ref WireRenderJob P0, Entity P1, WireRendererInfo P2); // 0x0000000186A53650-0x0000000186A53818
		public void __Gen_Wrap_828(ref WireRenderJob P0, int P1); // 0x0000000186A53818-0x0000000186A53978
		public void __Gen_Wrap_829(ref WireRenderJob P0, int P1, int P2); // 0x0000000186A53978-0x0000000186A53AF0
		public bool __Gen_Wrap_830(ref Beyond.Gameplay.Factory.FPtrNativeCurve P0); // 0x0000000186A53BC0-0x0000000186A53D04
		public NativeArray<float> __Gen_Wrap_831(ref Beyond.Gameplay.Factory.FPtrNativeCurve P0, object P1, int P2); // 0x0000000186A53D04-0x0000000186A53EB0
		public float __Gen_Wrap_832(ref Beyond.Gameplay.Factory.FPtrNativeCurve P0, float P1); // 0x0000000186A53EB0-0x0000000186A54010
		public bool __Gen_Wrap_833(ref StringIntern.FastId P0); // 0x0000000186A54010-0x0000000186A54134
		public bool __Gen_Wrap_834(ref StringIntern.FastId P0, StringIntern.FastId P1); // 0x0000000186A54134-0x0000000186A54288
		public bool __Gen_Wrap_835(ref StringIntern.FastId P0, object P1); // 0x0000000186A54288-0x0000000186A543C8
		public int __Gen_Wrap_836(ref StringIntern.FastId P0); // 0x0000000186A543C8-0x0000000186A544EC
		public bool __Gen_Wrap_837(object P0, out int P1); // 0x0000000186A544EC-0x0000000186A545E8
		public string __Gen_Wrap_838(int P0); // 0x0000000186A545E8-0x0000000186A546D4
		public PerDrawLightMode __Gen_Wrap_839(ref PerDrawPassConfig P0); // 0x0000000186A546D4-0x0000000186A54834
		public void __Gen_Wrap_840(ref PerDrawPassConfig P0, PerDrawLightMode P1); // 0x0000000186A54920-0x0000000186A54A8C
		public int __Gen_Wrap_841(ref PerDrawPassConfig P0); // 0x0000000186A54A8C-0x0000000186A54BEC
		public HGShaderLightMode __Gen_Wrap_842(ref PerDrawPassConfig P0, PerDrawLightMode P1); // 0x0000000186A54BEC-0x0000000186A54D68
		public void __Gen_Wrap_843(ref PerDrawPassConfig P0, Entity P1, ref uint P2); // 0x0000000186A54D68-0x0000000186A54F28
		public void __Gen_Wrap_844(ref PerDrawPassConfig P0, HGFactoryRendererBinderComponent P1, ref uint P2); // 0x0000000186A54F28-0x0000000186A550F4
		public void __Gen_Wrap_845(ref PerDrawConfig P0, UnityEngine.Color P1); // 0x0000000186A550F4-0x0000000186A55294
		public void __Gen_Wrap_846(ref PerDrawConfig P0, float4 P1); // 0x0000000186A55294-0x0000000186A55434
		public void __Gen_Wrap_847(ref PerDrawConfig P0, float P1); // 0x0000000186A55434-0x0000000186A555B0
		public void __Gen_Wrap_848(ref PerDrawConfig P0, HGFactoryRendererBinderComponent P1); // 0x0000000186A555B0-0x0000000186A55760
		public bool __Gen_Wrap_849(float P0, float P1, out float P2, float P3, float P4); // 0x0000000186A55760-0x0000000186A558B0
		public bool __Gen_Wrap_850(ref IProcessor P0, float P1, float P2); // 0x0000000186A5599C-0x0000000186A55AF0
		public string __Gen_Wrap_851(object P0); // 0x0000000186A55AF0-0x0000000186A55BCC
		public void __Gen_Wrap_852(ref GlobalEnv P0, ref InteractFacCollectJob.BuildingInfo P1, ref InteractFacCollectJob.BuildingInfo P2); // 0x0000000186A55BCC-0x0000000186A55F9C
		public void __Gen_Wrap_853(ref GlobalEnv P0, ref InteractFacCollectJob.LogisticInfo P1, ref InteractFacCollectJob.LogisticInfo P2); // 0x0000000186A55F9C-0x0000000186A562F0
		public JobHandle __Gen_Wrap_854(object P0, ref EntityManager P1, ref GlobalEnv P2, ref JobHandle P3, out JobHandle P4); // 0x0000000186A562F0-0x0000000186A566D0
		public bool __Gen_Wrap_855(ref FFactoryStateColorConfig P0, FacBuildingState P1, out UnityEngine.Color P2); // 0x0000000186A566D0-0x0000000186A56898
		public void __Gen_Wrap_856(object P0, ref GlobalEnv P1); // 0x0000000186A56898-0x0000000186A56AF4
		public bool __Gen_Wrap_857(object P0, int P1, out UnityEngine.Color P2); // 0x0000000186A56AF4-0x0000000186A56C38
		public bool __Gen_Wrap_858(object P0, object P1, out int P2); // 0x0000000186A56C38-0x0000000186A56D60
		public FactoryBaseColorLutConfig __Gen_Wrap_859(object P0); // 0x0000000186A56D60-0x0000000186A56E3C
		public bool __Gen_Wrap_860(ref FFactoryStateColorConfig P0, FacBuildingState P1, out string P2); // 0x0000000186A56F28-0x0000000186A570DC
		public bool __Gen_Wrap_861(ref FFactoryStateColorConfig P0, LogicEntityState P1, LogicEntityType P2, out PerDrawConfigArray P3); // 0x0000000186A570DC-0x0000000186A572BC
		public void __Gen_Wrap_862(ref FFactoryStateColorConfig.LogicStateConfig P0); // 0x0000000186A572BC-0x0000000186A5740C
		public ref VATFSMDefinition __Gen_Wrap_863(ref VATFSMStateFragment P0); // 0x0000000186A5740C-0x0000000186A575F0
		public ref FSMStateDefinition __Gen_Wrap_864(ref VATFSMStateFragment P0, ref VATFSMDefinition P1); // 0x0000000186A575F0-0x0000000186A5786C
		public ref FSMStateDefinition __Gen_Wrap_865(ref VATFSMStateFragment P0); // 0x0000000186A5786C-0x0000000186A57A3C
		public byte __Gen_Wrap_866(ref FSMStateDefinition P0, byte P1); // 0x0000000186A57A3C-0x0000000186A57BA8
		public ref FSMClipDefinition __Gen_Wrap_867(ref VATFSMStateFragment P0, ref VATFSMDefinition P1); // 0x0000000186A57BA8-0x0000000186A57E24
		public ref FSMClipDefinition __Gen_Wrap_868(ref VATFSMStateFragment P0); // 0x0000000186A57E24-0x0000000186A58008
		public void __Gen_Wrap_869(ref FSMState P0); // 0x0000000186A58008-0x0000000186A58158
		public void __Gen_Wrap_870(ref VATFSMStateFragment P0, byte P1, ref VATFSMDefinition P2); // 0x0000000186A582EC-0x0000000186A58560
		public void __Gen_Wrap_871(ref FSMParameterSet P0, byte P1, float P2); // 0x0000000186A58560-0x0000000186A586E8
		public void __Gen_Wrap_872(ref FSMParameterSet P0, byte P1, int P2); // 0x0000000186A586E8-0x0000000186A58870
		public void __Gen_Wrap_873(ref FSMParameterSet P0, byte P1, bool P2); // 0x0000000186A58870-0x0000000186A589F8
		public void __Gen_Wrap_874(ref FSMParameterSet P0); // 0x0000000186A589F8-0x0000000186A58B48
		public void __Gen_Wrap_875(ref FSMParameterSet P0, in VATFSMDefinition P1); // 0x0000000186A58B48-0x0000000186A58D0C
		public void __Gen_Wrap_876(ref VATFSMStateFragment P0, uint P1, uint P2); // 0x0000000186A58D0C-0x0000000186A58F04
		public void __Gen_Wrap_877(ref FSMTransition P0); // 0x0000000186A58F04-0x0000000186A59048
		public void __Gen_Wrap_878(ref VATFSMStateFragment P0, ref FSMStateDefinition P1, ref VATFSMDefinition P2); // 0x0000000186A59048-0x0000000186A59334
		public void __Gen_Wrap_879(ref VATFSMStateFragment P0, ref FSMStateDefinition P1); // 0x0000000186A59334-0x0000000186A59574
		public void __Gen_Wrap_880(ref VATFSMStateFragment P0); // 0x0000000186A596D8-0x0000000186A59888
		public void __Gen_Wrap_881(ref VATFSMStateFragment P0, in FSMTransitionDefinition P1, in FSMStateDefinition P2); // 0x0000000186A59888-0x0000000186A59AE8
		public int __Gen_Wrap_882(ref VATFSMStateFragment P0); // 0x0000000186A59AE8-0x0000000186A59CBC
		public float __Gen_Wrap_883(ref FSMState P0); // 0x0000000186A59CBC-0x0000000186A59E1C
		public bool __Gen_Wrap_884(ref FSMState P0); // 0x0000000186A59E1C-0x0000000186A59F7C
		public void __Gen_Wrap_885(ref FSMState P0, float P1, float P2); // 0x0000000186A59F7C-0x0000000186A5A0F4
		public void __Gen_Wrap_886(ref FSMState P0, float P1); // 0x0000000186A5A0F4-0x0000000186A5A264
		public bool __Gen_Wrap_887(ref FSMTransition P0); // 0x0000000186A5A264-0x0000000186A5A3A4
		public float __Gen_Wrap_888(ref FSMTransition P0); // 0x0000000186A5A3A4-0x0000000186A5A4E4
		public void __Gen_Wrap_889(ref FSMTransition P0, float P1, float P2); // 0x0000000186A5A4E4-0x0000000186A5A64C
		public float __Gen_Wrap_890(ref FSMParameterSet P0, byte P1); // 0x0000000186A5A860-0x0000000186A5A9CC
		public int __Gen_Wrap_891(ref FSMParameterSet P0, byte P1); // 0x0000000186A5A9CC-0x0000000186A5AB38
		public bool __Gen_Wrap_892(ref FSMParameterSet P0, byte P1); // 0x0000000186A5AB38-0x0000000186A5ACA4
		public void __Gen_Wrap_893(ref FSMParameterSet P0, byte P1); // 0x0000000186A5ACA4-0x0000000186A5AE10
		public void __Gen_Wrap_894(ref FSMParameterSet P0, byte P1, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P2, float P3); // 0x0000000186A5AE10-0x0000000186A5AFA8
		public float __Gen_Wrap_895(ref FSMParameterSet P0, byte P1, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P2); // 0x0000000186A5AFA8-0x0000000186A5B130
		public void __Gen_Wrap_896(ref VATFSMSetParamRequestHandlerJob P0, int P1); // 0x0000000186A5B130-0x0000000186A5B28C
		public bool __Gen_Wrap_897(in FSMCondition P0, in FSMParameterSet P1, in FixedList128Bytes<FSMParameterDefinition> P2); // 0x0000000186A5B28C-0x0000000186A5B474
		public bool __Gen_Wrap_898(ref VATFSMStateFragment P0, ref VATFSMDefinition P1, out int P2); // 0x0000000186A5B474-0x0000000186A5B70C
		public void __Gen_Wrap_899(ref FSMParameterSet P0, in FSMTransitionDefinition P1, in FixedList128Bytes<FSMParameterDefinition> P2); // 0x0000000186A5B70C-0x0000000186A5B93C
		public bool __Gen_Wrap_900(ref VATFSMStateUpdateJob P0, ref VATFSMStateFragment P1, ref VATFSMDefinition P2); // 0x0000000186A5BBF0-0x0000000186A5BEFC
		public void __Gen_Wrap_901(ref VATFSMStateUpdateJob P0, ref VATFSMStateFragment P1, ref VATFSMDefinition P2); // 0x0000000186A5BEFC-0x0000000186A5C1F8
		public void __Gen_Wrap_902(ref VATFSMStateUpdateJob P0, int P1); // 0x0000000186A5C1F8-0x0000000186A5C364
		public void __Gen_Wrap_903(ref VATFSMStateUpdateJob P0); // 0x0000000186A5C364-0x0000000186A5C4B4
		public void __Gen_Wrap_904(ref VATFSMStateUpdateJob P0, IntPtr P1); // 0x0000000186A5C4B4-0x0000000186A5C630
		public void __Gen_Wrap_905(object P0, ref EntityManager P1); // 0x0000000186A5C630-0x0000000186A5C780
		public void __Gen_Wrap_906(object P0, ref GlobalEnv P1, int P2); // 0x0000000186A5C780-0x0000000186A5C9F8
		public JobHandle __Gen_Wrap_907(object P0, ref EntityManager P1, ref GlobalEnv P2, JobHandle P3); // 0x0000000186A5C9F8-0x0000000186A5CD50
		public void __Gen_Wrap_908(ref FSMStateDefinition P0, byte P1, byte P2); // 0x0000000186A5CD50-0x0000000186A5CEC8
		public uint __Gen_Wrap_909(ref VATFSMDefinitionContainer P0); // 0x0000000186A5CEC8-0x0000000186A5D01C
		public Span<VATFSMDefinition> __Gen_Wrap_910(ref VATFSMDefinitionContainer P0); // 0x0000000186A5D1AC-0x0000000186A5D32C
		public ref VATFSMDefinition __Gen_Wrap_911(ref VATFSMDefinitionContainer P0, int P1); // 0x0000000186A5D32C-0x0000000186A5D4AC
		public void __Gen_Wrap_912(Entity P0, ref EntityManager P1); // 0x0000000186A5D4AC-0x0000000186A5D61C
		public string __Gen_Wrap_913(uint P0, byte P1); // 0x0000000186A5D61C-0x0000000186A5D714
		public void __Gen_Wrap_914(JobHandle P0); // 0x0000000186A5D714-0x0000000186A5D7F8
		public ref BuildingTemplateIds.Holder __Gen_Wrap_915(); // 0x0000000186A5D7F8-0x0000000186A5D8C4
		public ref StringIntern.FastId __Gen_Wrap_916(); // 0x0000000186A5D8C4-0x0000000186A5D990
		public BuildingStateQueryGroup __Gen_Wrap_917(int P0); // 0x0000000186363EE4-0x0000000186363F9C
		public bool __Gen_Wrap_918(Entity P0); // 0x0000000186A5D990-0x0000000186A5DA84
		public bool __Gen_Wrap_919(ref EntityManager P0, ref Entity P1); // 0x0000000186A5DA84-0x0000000186A5DC28
		public bool __Gen_Wrap_920(Entity P0, ref EntityManager P1); // 0x0000000186A5DD14-0x0000000186A5DE94
		public bool __Gen_Wrap_921(Entity P0, ref EntityManager P1, Visibility.Type P2); // 0x0000000186A5DE94-0x0000000186A5E024
		public bool __Gen_Wrap_922(Entity P0, Visibility.Type P1); // 0x0000000186A5E024-0x0000000186A5E134
		public bool __Gen_Wrap_923(Entity P0, ref EntityManager P1, bool P2, Visibility.EFlag P3, Visibility.Type P4, object P5); // 0x0000000186A5E134-0x0000000186A5E2F4
		public void __Gen_Wrap_924(Entity P0, ref EntityManager P1, bool P2, Visibility.EFlag P3, Visibility.Type P4, object P5); // 0x0000000186A5E2F4-0x0000000186A5E4A4
		public bool __Gen_Wrap_925(Entity P0, bool P1, Visibility.EFlag P2, Visibility.Type P3, ref EntityCommandBuffer P4); // 0x0000000186A5E4A4-0x0000000186A5E6C4
		public void __Gen_Wrap_926(Entity P0, bool P1); // 0x0000000186A5E6C4-0x0000000186A5E7D4
		public bool __Gen_Wrap_927(Entity P0, ref EntityManager P1, FixedString32Bytes P2, out float3 P3, out quaternion P4, out Entity P5); // 0x0000000186A5E7D4-0x0000000186A5EA78
		public bool __Gen_Wrap_928(Entity P0, ref EntityManager P1, FixedString32Bytes P2, out float3 P3, out quaternion P4); // 0x0000000186A5EA78-0x0000000186A5ECD8
		public bool __Gen_Wrap_929(Entity P0, object P1, out float3 P2, out quaternion P3); // 0x0000000186A5ECD8-0x0000000186A5EE98
		public ref ChapterFragment __Gen_Wrap_930(EntityManager P0, int P1, out bool P2, out Entity P3); // 0x0000000186A5EFF8-0x0000000186A5F1A8
		public IntPtr __Gen_Wrap_931(EntityManager P0); // 0x0000000186A5F1A8-0x0000000186A5F2B0
		public bool __Gen_Wrap_932(EntityManager P0); // 0x0000000186A5F2B0-0x0000000186A5F3B8
		public ref GlobalEnv __Gen_Wrap_933(EntityManager P0); // 0x0000000186A5F3B8-0x0000000186A5F4D0
		public bool __Gen_Wrap_934(ref GlobalEnv P0, out InteractFacCollectJob.BuildingInfo P1); // 0x0000000186A5F4D0-0x0000000186A5F794
		public bool __Gen_Wrap_935(ref GlobalEnv P0, out InteractFacCollectJob.LogisticInfo P1); // 0x0000000186A5F794-0x0000000186A5FA38
		public LinearAllocator.Allocation __Gen_Wrap_936(object P0, int P1); // 0x0000000186A5FA38-0x0000000186A5FB54
		public void __Gen_Wrap_937(object P0, int P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public LinearAllocator.Allocation __Gen_Wrap_938(object P0, int P1, int P2); // 0x0000000186A5FC1C-0x0000000186A5FD48
		public void __Gen_Wrap_939(ref LinearAllocatorUnmanaged P0, int P1, Unity.Collections.Allocator P2); // 0x0000000186A5FD48-0x0000000186A5FEE4
		public uint __Gen_Wrap_940(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public void __Gen_Wrap_941(object P0, uint P1, out int P2, out int P3); // 0x0000000186A60048-0x0000000186A60184
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 50198
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x0000000186A65CD0-0x0000000186A65D64
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 50199
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000186A6A9C4-0x0000000186A6AA28
		public static bool IsPatched(int id); // 0x0000000182EEF8C0-0x0000000182EEF910
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000186A6A880-0x0000000186A6A94C
		public object CreateWrapper(int id); // 0x0000000186A6A94C-0x0000000186A6A9C4
		public object InitWrapperArray(int len); // 0x0000000186A6AA28-0x0000000186A6AAB4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x0000000186A6A7DC-0x0000000186A6A880
	}

	public enum IDMAP0 // TypeDefIndex: 50200
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
		Beyond-Gameplay-Factory-Archetypes-get_gasReactor0 = 40,
		Beyond-Gameplay-Factory-Archetypes-get_squirter0 = 41,
		Beyond-Gameplay-Factory-Archetypes-get_dumper0 = 42,
		Beyond-Gameplay-Factory-Archetypes-get_liquidCleaner0 = 43,
		Beyond-Gameplay-Factory-Archetypes-get_xiraniteOven0 = 44,
		Beyond-Gameplay-Factory-Archetypes-get_liquidPurifier0 = 45,
		Beyond-Gameplay-Factory-Archetypes-get_dismantler0 = 46,
		Beyond-Gameplay-Factory-Archetypes-get_transmuter0 = 47,
		Beyond-Gameplay-Factory-Archetypes-get_vaporizer0 = 48,
		Beyond-Gameplay-Factory-Archetypes-get_bus0 = 49,
		Beyond-Gameplay-Factory-Archetypes-get_busRootRender0 = 50,
		Beyond-Gameplay-Factory-Archetypes-get_buildingRender0 = 51,
		Beyond-Gameplay-Factory-Archetypes-get_busSubRender0 = 52,
		Beyond-Gameplay-Factory-Archetypes-get_hsBus0 = 53,
		Beyond-Gameplay-Factory-Archetypes-get_hsBusSource0 = 54,
		Beyond-Gameplay-Factory-Archetypes-get_udPipeLoader0 = 55,
		Beyond-Gameplay-Factory-Archetypes-get_udPipeUnloader0 = 56,
		Beyond-Gameplay-Factory-Archetypes-get_liquidCleanGate0 = 57,
		Beyond-Gameplay-Factory-Archetypes-get_liquidRecycleGate0 = 58,
		Beyond-Gameplay-Factory-Archetypes-get_carrier0 = 59,
		Beyond-Gameplay-Factory-Archetypes-get_marker0 = 60,
		Beyond-Gameplay-Factory-Archetypes-get_decoration0 = 61,
		Beyond-Gameplay-Factory-Archetypes-get_soil0 = 62,
		Beyond-Gameplay-Factory-Archetypes-get_pipeConditioner0 = 63,
		Beyond-Gameplay-Factory-Archetypes-get_conveyorLogistics0 = 64,
		Beyond-Gameplay-Factory-Archetypes-get_pipeLogistics0 = 65,
		Beyond-Gameplay-Factory-Archetypes-get_logConditioner0 = 66,
		Beyond-Gameplay-Factory-Archetypes-get_buildingFakeUnit0 = 67,
		Beyond-Gameplay-Factory-Archetypes-get_buildingRenderOnlyUnit0 = 68,
		Beyond-Gameplay-Factory-Archetypes-get_buildingPreviewUnit0 = 69,
		Beyond-Gameplay-Factory-Archetypes-get_buildingGuideHintUnit0 = 70,
		Beyond-Gameplay-Factory-Archetypes-get_conveyor0 = 71,
		Beyond-Gameplay-Factory-Archetypes-get_guideConveyor0 = 72,
		Beyond-Gameplay-Factory-Archetypes-get_pipe0 = 73,
		Beyond-Gameplay-Factory-Archetypes-get_pipeHolder0 = 74,
		Beyond-Gameplay-Factory-Archetypes-get_cargo0 = 75,
		Beyond-Gameplay-Factory-Archetypes-get_buildingRootRender0 = 76,
		Beyond-Gameplay-Factory-Archetypes-get_buildingSubRender0 = 77,
		Beyond-Gameplay-Factory-Archetypes-get_pedestalRender0 = 78,
		Beyond-Gameplay-Factory-Archetypes-get_conveyorLeftRender0 = 79,
		Beyond-Gameplay-Factory-Archetypes-get_conveyorRightRender0 = 80,
		Beyond-Gameplay-Factory-Archetypes-get_conveyorMidRender0 = 81,
		Beyond-Gameplay-Factory-Archetypes-get_figureConveyorLogisticsRender0 = 82,
		Beyond-Gameplay-Factory-Archetypes-get_figurePipeHolderRender0 = 83,
		Beyond-Gameplay-Factory-Archetypes-get_figureLeftRender0 = 84,
		Beyond-Gameplay-Factory-Archetypes-get_figureRightRender0 = 85,
		Beyond-Gameplay-Factory-Archetypes-get_figureMidRender0 = 86,
		Beyond-Gameplay-Factory-Archetypes-get_conveyorPreviewRender0 = 87,
		Beyond-Gameplay-Factory-Archetypes-get_pipePreviewRender0 = 88,
		Beyond-Gameplay-Factory-Archetypes-get_pipeComRender0 = 89,
		Beyond-Gameplay-Factory-Archetypes-get_pipeLeftRender0 = 90,
		Beyond-Gameplay-Factory-Archetypes-get_pipeMidRender0 = 91,
		Beyond-Gameplay-Factory-Archetypes-get_pipeRightRender0 = 92,
		Beyond-Gameplay-Factory-Archetypes-get_pipeTrackLeftPreviewRender0 = 93,
		Beyond-Gameplay-Factory-Archetypes-get_pipeTrackMidPreviewRender0 = 94,
		Beyond-Gameplay-Factory-Archetypes-get_pipeTrackRightPreviewRender0 = 95,
		Beyond-Gameplay-Factory-Archetypes-get_outputUIRenderer0 = 96,
		Beyond-Gameplay-Factory-Archetypes-get_envGeneratorUIRenderer0 = 97,
		Beyond-Gameplay-Factory-Archetypes-get_wireRenderer0 = 98,
		Beyond-Gameplay-Factory-Archetypes-get_unitStatusUIRenderer0 = 99,
		Beyond-Gameplay-Factory-Archetypes-get_portPreviewUIRenderer0 = 100,
		Beyond-Gameplay-Factory-Archetypes-get_gridRenderer0 = 101,
		Beyond-Gameplay-Factory-Archetypes-get_gridMainRegionRenderer0 = 102,
		Beyond-Gameplay-Factory-Archetypes-get_portStatusUIRenderer0 = 103,
		Beyond-Gameplay-Factory-Archetypes-get_scope0 = 104,
		Beyond-Gameplay-Factory-Archetypes-Select0 = 105,
		Beyond-Gameplay-Factory-BlueprintSlotContainer-Dispose0 = 107,
		Beyond-Gameplay-Factory-BlueprintSlotContainer-FlushPendingFree0 = 108,
		Beyond-Gameplay-Factory-BlueprintSlotContainer-Create0 = 109,
		Beyond-Gameplay-Factory-BlueprintSlotContainer-Destroy0 = 110,
		Beyond-Gameplay-Factory-BlueprintSlotContainer-Reset0 = 111,
		Beyond-Gameplay-Factory-BlueprintSlotContainer-get_Item0 = 112,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Dispose0 = 113,
		Beyond-Gameplay-Factory-ConveyorExtContainer-FlushPendingFree0 = 114,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Size0 = 115,
		Beyond-Gameplay-Factory-ConveyorExtContainer-AsSpan0 = 116,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Create0 = 117,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Destroy0 = 118,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Reset0 = 119,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Reserve0 = 120,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Data0 = 121,
		Beyond-Gameplay-Factory-ConveyorExtContainer-get_Item0 = 122,
		Beyond-Gameplay-Factory-ConveyorExtContainer-get_Item1 = 123,
		Beyond-Gameplay-Factory-ConveyorExtContainer-Get0 = 124,
		Beyond-Gameplay-Factory-ConveyorExtContainer-ConveyorExt-Reset0 = 125,
		Beyond-Gameplay-Factory-ConveyorInfoAllocator-Allocate0 = 126,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Allocate0 = 127,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-_ExpandMemory0 = 129,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-_MergeAdjacentFreeBlocks0 = 130,
		Beyond-Gameplay-Factory-ConveyorInfoAllocator-Resize0 = 131,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Resize0 = 132,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Free0 = 133,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Expand0 = 134,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Reserve0 = 135,
		Beyond-Gameplay-Factory-ConveyorInfoAllocator-Free0 = 136,
		Beyond-Gameplay-Factory-ConveyorInfoAllocator-CalculateSize0 = 137,
		Beyond-Gameplay-Factory-ConveyorInfoAllocator-DebugPrint0 = 138,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-PrintAllocations0 = 139,
		Beyond-Gameplay-Factory-SharedDataContainer-Dispose0 = 144,
		Beyond-Gameplay-Factory-SharedDataContainer-FlushPendingFree0 = 145,
		Beyond-Gameplay-Factory-SharedDataContainer-Size0 = 146,
		Beyond-Gameplay-Factory-SharedDataContainer-AsSpan0 = 147,
		Beyond-Gameplay-Factory-SharedDataContainer-Create0 = 148,
		Beyond-Gameplay-Factory-SharedDataContainer-Destroy0 = 149,
		Beyond-Gameplay-Factory-SharedDataContainer-Reset0 = 150,
		Beyond-Gameplay-Factory-SharedDataContainer-Reserve0 = 151,
		Beyond-Gameplay-Factory-SharedDataContainer-Data0 = 152,
		Beyond-Gameplay-Factory-SharedDataContainer-get_Item0 = 153,
		Beyond-Gameplay-Factory-SharedDataContainer-get_Item1 = 154,
		Beyond-Gameplay-Factory-SharedDataContainer-Get0 = 155,
		Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-get_visible0 = 156,
		Beyond-Gameplay-Factory-Visibility-get_isVisible0 = 157,
		Beyond-Gameplay-Factory-Visibility-GetVisible0 = 158,
		Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-get_visibleAdditiveMat0 = 159,
		Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-IsDirty0 = 160,
		Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-SetDirty0 = 161,
		Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-IsPendingUnit0 = 162,
		Beyond-Gameplay-Factory-WireRendererInfo-get_pos0 = 163,
		Beyond-Gameplay-Factory-WireRendererInfo-get_rot0 = 164,
		Beyond-Gameplay-Factory-WireRendererInfo-get_scale0 = 165,
		Beyond-Gameplay-Factory-EntitySearcher-GetLogicEntityMap0 = 166,
		Beyond-Gameplay-Factory-EntitySearcher-RegisterLogicEntity0 = 167,
		Beyond-Gameplay-Factory-UnitId-Create0 = 168,
		Beyond-Gameplay-Factory-EntitySearcher-UnregisterLogicEntity0 = 169,
		Beyond-Gameplay-Factory-EntitySearcher-GetLogicEntity0 = 170,
		Beyond-Gameplay-Factory-EntitySearcher-_DestroyAllEntities0 = 171,
		Beyond-Gameplay-Factory-EntitySearcher-DestroyAll0 = 172,
		Beyond-Gameplay-Factory-EventChannelAccessor-InitEventChannels0 = 173,
		Beyond-Gameplay-Factory-FactoryEventChannels-Create0 = 174,
		Beyond-Gameplay-Factory-EventChannelAccessor-DisposeEventChannels0 = 175,
		Beyond-Gameplay-Factory-FactoryEventChannels-Dispose0 = 176,
		Beyond-Gameplay-Factory-FactoryEventChannels-ClearInstance0 = 177,
		Beyond-Gameplay-Factory-EventChannelAccessor-ClearAll0 = 178,
		Beyond-Gameplay-Factory-FactoryEventChannels-ClearAll0 = 179,
		Beyond-Gameplay-Factory-EventChannelAccessor-HasStatusChangeEvents0 = 180,
		Beyond-Gameplay-Factory-EventChannelAccessor-HasUpdatePipeEffectEvents0 = 181,
		Beyond-Gameplay-Factory-EventChannelAccessor-HasChangeTemplateEvents0 = 182,
		Beyond-Gameplay-Factory-EventChannelAccessor-HasCreateUnitRendererEvents0 = 183,
		Beyond-Gameplay-Factory-EventChannelAccessor-HasPendingCreateRendererEvents0 = 184,
		Beyond-Gameplay-Factory-EventChannelAccessor-HasUpdateStatusEffectEvents0 = 185,
		Beyond-Gameplay-Factory-EventChannelAccessor-HasUpdateRendererPropertyEvents0 = 186,
		Beyond-Gameplay-Factory-EventChannelAccessor-HasUpdatePedestalColorLUTEvents0 = 187,
		Beyond-Gameplay-Factory-EventChannelAccessor-HasCreateInteractEvents0 = 188,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetStatusChangeEvents0 = 189,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetAudioEvents0 = 190,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetChangeTemplateEvents0 = 191,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetUpdatePipeEffectEvents0 = 192,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetCreateUnitRendererEvents0 = 193,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetVatUpdateEvents0 = 194,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetUpdateStatusEffectEvents0 = 195,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetUpdateRendererPropertyEvents0 = 196,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetUpdatePedestalColorLUTEvents0 = 197,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetCreateInteractEvents0 = 198,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetPendingCreateRendererEvents0 = 199,
		Beyond-Gameplay-Factory-EventChannelAccessor-PrepareVatUpdateConcurrentWrites0 = 200,
		Beyond-Gameplay-Factory-EventChannelAccessor-PrepareUpdateStatusEffectConcurrentWrites0 = 201,
		Beyond-Gameplay-Factory-EventChannelAccessor-PrepareAudioConcurrentWrites0 = 202,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetVatUpdateParallelWriter0 = 203,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetUpdateStatusEffectParallelWriter0 = 204,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetAudioParallelWriter0 = 205,
		Beyond-Gameplay-Factory-EventChannelAccessor-FlushVatUpdateConcurrentWrites0 = 206,
		Beyond-Gameplay-Factory-EventChannelAccessor-FlushUpdateStatusEffectConcurrentWrites0 = 207,
		Beyond-Gameplay-Factory-EventChannelAccessor-FlushAudioConcurrentWrites0 = 208,
		Beyond-Gameplay-Factory-EventChannelAccessor-GetPendingCreateRendererCount0 = 209,
		Beyond-Gameplay-Factory-FacBoneTRSBinary-get_instance0 = 210,
		Beyond-Gameplay-Factory-FacBoneTRSBinary-get_isReady0 = 211,
		Beyond-Gameplay-Factory-FacBoneTRSBinary-InitMain0 = 212,
		Beyond-Gameplay-Factory-FacBoneTRSBinary-_DisposeResources0 = 213,
		Beyond-Gameplay-Factory-FacBoneTRSBinary-_InitTable0 = 214,
		Beyond-Gameplay-Factory-FacBoneTRSBinary-TryGetBoneTRS0 = 215,
		Beyond-Gameplay-Factory-FacBoneTRSBinary-Dispose0 = 216,
		Beyond-Gameplay-Factory-FactorySharedDataManager-InitExtData0 = 217,
		Beyond-Gameplay-Factory-FactorySharedDataManager-ResetExtData0 = 218,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Reset0 = 219,
		Beyond-Gameplay-Factory-FactorySharedDataManager-ReleaseExtData0 = 220,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Dispose0 = 221,
		Beyond-Gameplay-Factory-FactorySharedDataManager-FlushDeferredFree0 = 222,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-FlushPendingFree0 = 223,
		Beyond-Gameplay-Factory-FactorySharedDataManager-CreateConveyorExtHandle0 = 224,
		Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyConveyorExtHandle0 = 225,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetConveyorExt0 = 226,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetConveyorExtData0 = 227,
		Beyond-Gameplay-Factory-FactorySharedDataManager-CreateSharedData0 = 228,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetSharedData0 = 229,
		Beyond-Gameplay-Factory-FactorySharedDataManager-DestroySharedData0 = 230,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetSharedData1 = 231,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetSharedDataSize0 = 232,
		Beyond-Gameplay-Factory-FactorySharedDataManager-CreateTransHierarchy0 = 233,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData0 = 234,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData1 = 235,
		Beyond-Gameplay-Factory-FactorySharedDataManager-WorldTrans0 = 236,
		Beyond-Gameplay-Factory-LocalTransform-ToMatrix0 = 237,
		Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyHierarchyData0 = 238,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData2 = 239,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchySize0 = 240,
		Beyond-Gameplay-Factory-FactorySharedDataManager-CreateVATFSMDefinitionContainer0 = 241,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Create0 = 242,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetVATFSMDefinition0 = 243,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-get_Item0 = 244,
		Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyVATFSMDefinition0 = 245,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Destroy0 = 246,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetVATFSMDefinition1 = 247,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Data0 = 248,
		Beyond-Gameplay-Factory-FactorySharedDataManager-CreateBlueprintSlotInfo0 = 249,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-CreateDefault0 = 250,
		Beyond-Gameplay-Factory-FactorySharedDataManager-GetBlueprintSlotInfo0 = 251,
		Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyBlueprintSlotInfo0 = 252,
		Beyond-Gameplay-Factory-ActivatorCostFragment-get_id0 = 253,
		Beyond-Gameplay-Factory-ActivatorCostFragment-__AOT_FOR_FIX__0 = 254,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-get_curEffectType0 = 255,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-set_curEffectType0 = 256,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-PushState0 = 257,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-PeekState0 = 258,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-_Shrink0 = 259,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-PopState0 = 260,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-ShiftState0 = 261,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-InsertState0 = 262,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-DisableState0 = 263,
		Beyond-Gameplay-Factory-AdditiveEffectFragment-ToString0 = 264,
		Beyond-Gameplay-Factory-CutoffState-SetEnable0 = 265,
		Beyond-Gameplay-Factory-CutoffState-SetCutoffY0 = 267,
		Beyond-Gameplay-Factory-CutoffState-SetMode0 = 268,
		Beyond-Gameplay-Factory-BuildDismissState-SetEnable0 = 269,
		Beyond-Gameplay-Factory-HighLightState-SetEnable0 = 270,
		Beyond-Gameplay-Factory-HighLightState-SetData0 = 271,
		Beyond-Gameplay-Factory-HighLightState-GetEffectType0 = 272,
		Beyond-Gameplay-Factory-HighLightState-IsHighlight0 = 273,
		Beyond-Gameplay-Factory-HighLightState-HighlightWithSubIndex0 = 274,
		Beyond-Gameplay-Factory-HighLightState-ClearHighlightableIndexList0 = 275,
		Beyond-Gameplay-Factory-HintState-SetEnable0 = 276,
		Beyond-Gameplay-Factory-FigureState-SetEnable0 = 277,
		Beyond-Gameplay-Factory-OverloadState-SetEnable0 = 278,
		Beyond-Gameplay-Factory-OverloadInvalidState-SetEnable0 = 279,
		Beyond-Gameplay-Factory-DitherState-SetEnable0 = 280,
		Beyond-Gameplay-Factory-BlueprintState-SetEnable0 = 281,
		Beyond-Gameplay-Factory-BlueprintState-SetEnable1 = 282,
		Beyond-Gameplay-Factory-BlueprintState-IsLighten0 = 283,
		Beyond-Gameplay-Factory-BlueprintState-LightenWithSubIndex0 = 284,
		Beyond-Gameplay-Factory-BlueprintState-ClearLightenIndexList0 = 285,
		Beyond-Gameplay-Factory-PreSelectState-SetEnable0 = 286,
		Beyond-Gameplay-Factory-PreSelectState-IsLighten0 = 287,
		Beyond-Gameplay-Factory-PreSelectState-LightenWithSubIndex0 = 288,
		Beyond-Gameplay-Factory-PreSelectState-ClearLightenIndexList0 = 289,
		Beyond-Gameplay-Factory-SoloSelectState-get_enable0 = 290,
		Beyond-Gameplay-Factory-SoloSelectState-SetEnable0 = 291,
		Beyond-Gameplay-Factory-SoloSelectState-IsLighten0 = 292,
		Beyond-Gameplay-Factory-SoloSelectState-SelectWithSubIndices0 = 293,
		Beyond-Gameplay-Factory-SoloSelectState-SelectWithSubIndices1 = 294,
		Beyond-Gameplay-Factory-SoloSelectState-ClearSelectedIndexList0 = 295,
		Beyond-Gameplay-Factory-ContinuationState-SetEnable0 = 296,
		Beyond-Gameplay-Factory-ContinuationState-IsLighten0 = 297,
		Beyond-Gameplay-Factory-ContinuationState-LightenWithSubIndex0 = 298,
		Beyond-Gameplay-Factory-ContinuationState-ClearLightenIndexList0 = 299,
		Beyond-Gameplay-Factory-SocialSharingState-SetEnable0 = 300,
		Beyond-Gameplay-Factory-PowerInteractionState-SetEnable0 = 301,
		Beyond-Gameplay-Factory-InvalidOverlapPlaceState-SetEnable0 = 302,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_buildDismissEnabled0 = 303,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_buildDismissEnabled0 = 304,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_blueprintBuildEnabled0 = 305,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_blueprintBuildEnabled0 = 306,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_blueprintBuildCutoffYEnabled0 = 307,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_blueprintBuildCutoffYEnabled0 = 308,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_cutOffYIgnored0 = 309,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_cutOffYIgnored0 = 310,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_cutoffYEnabled0 = 311,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_cutoffYEnabled0 = 312,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_highLightEnabled0 = 313,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_highLightEnabled0 = 314,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_figureEnabled0 = 315,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_figureEnabled0 = 316,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_hintEnabled0 = 317,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_hintEnabled0 = 318,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_overloadEnabled0 = 319,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_overloadEnabled0 = 320,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_overloadInvalidEnabled0 = 321,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_overloadInvalidEnabled0 = 322,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_repair0Enabled0 = 323,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_repair0Enabled0 = 324,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_repair1Enabled0 = 325,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_repair1Enabled0 = 326,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_blueprintEnabled0 = 327,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_blueprintEnabled0 = 328,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_preSelectEnabled0 = 329,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_preSelectEnabled0 = 330,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_continuationEnabled0 = 331,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_continuationEnabled0 = 332,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_socialSharingEnabled0 = 333,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_socialSharingEnabled0 = 334,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_powerInteractionEnabled0 = 335,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_powerInteractionEnabled0 = 336,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_invalidOverlapPlaceEnabled0 = 337,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-set_invalidOverlapPlaceEnabled0 = 338,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_anyEffect0 = 339,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_id0 = 340,
		Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-__AOT_FOR_FIX__0 = 341,
		Beyond-Gameplay-Factory-BattleFragment-get_id0 = 342,
		Beyond-Gameplay-Factory-BattleFragment-__AOT_FOR_FIX__0 = 343,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntity0 = 344,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-Binded0 = 345,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntities0 = 346,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntities1 = 347,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-UnbindRenderEntity0 = 348,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-ClearBindRenderEntities0 = 349,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-HasRenderer0 = 350,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-get_id0 = 351,
		Beyond-Gameplay-Factory-BindRenderEntityFragment-__AOT_FOR_FIX__0 = 352,
		Beyond-Gameplay-Factory-BurnPowerFragment-get_burningItemId0 = 353,
		Beyond-Gameplay-Factory-BurnPowerFragment-set_burningItemId0 = 354,
		Beyond-Gameplay-Factory-BurnPowerFragment-get_id0 = 355,
		Beyond-Gameplay-Factory-BurnPowerFragment-__AOT_FOR_FIX__0 = 356,
		Beyond-Gameplay-Factory-BusFragment-get_id0 = 357,
		Beyond-Gameplay-Factory-BusFragment-__AOT_FOR_FIX__0 = 358,
		Beyond-Gameplay-Factory-BusFreeFragment-get_id0 = 359,
		Beyond-Gameplay-Factory-BusFreeFragment-__AOT_FOR_FIX__0 = 360,
		Beyond-Gameplay-Factory-CacheFragment-GetCacheItem0 = 361,
		Beyond-Gameplay-Factory-CacheFragment-CalcIndex0 = 362,
		Beyond-Gameplay-Factory-CacheFragment-SetCacheItem0 = 363,
		Beyond-Gameplay-Factory-CacheFragment-SetCacheSize0 = 364,
		Beyond-Gameplay-Factory-CacheFragment-get_id0 = 365,
		Beyond-Gameplay-Factory-CacheFragment-__AOT_FOR_FIX__0 = 366,
		Beyond-Gameplay-Factory-CacheTransportFragment-get_id0 = 367,
		Beyond-Gameplay-Factory-CacheTransportFragment-__AOT_FOR_FIX__0 = 368,
		Beyond-Gameplay-Factory-CargoFragment-get_itemId0 = 369,
		Beyond-Gameplay-Factory-CargoFragment-set_itemId0 = 370,
		Beyond-Gameplay-Factory-CargoFragment-get_unitAssetInstanceId0 = 371,
		Beyond-Gameplay-Factory-CargoFragment-set_unitAssetInstanceId0 = 372,
		Beyond-Gameplay-Factory-CargoFragment-get_recyclable0 = 373,
		Beyond-Gameplay-Factory-CargoFragment-PredictPos0 = 374,
		Beyond-Gameplay-Factory-CargoFragment-PredictPosWithDeltaTime0 = 375,
		Beyond-Gameplay-Factory-CargoFragment-CompareTo0 = 376,
		Beyond-Gameplay-Factory-CargoFragment-Create0 = 377,
		Beyond-Gameplay-Factory-CargoFragment-get_id0 = 378,
		Beyond-Gameplay-Factory-CargoFragment-__AOT_FOR_FIX__0 = 379,
		Beyond-Gameplay-Factory-CargoRendererFragment-get_unitAssetInstanceId0 = 380,
		Beyond-Gameplay-Factory-CargoRendererFragment-set_unitAssetInstanceId0 = 381,
		Beyond-Gameplay-Factory-CargoRendererFragment-get_id0 = 382,
		Beyond-Gameplay-Factory-CargoRendererFragment-__AOT_FOR_FIX__0 = 383,
		Beyond-Gameplay-Factory-ChapterFragment-get_blueprintSlotInfo0 = 384,
		Beyond-Gameplay-Factory-ChapterFragment-get_id0 = 385,
		Beyond-Gameplay-Factory-ChapterFragment-__AOT_FOR_FIX__0 = 386,
		Beyond-Gameplay-Factory-CollectorFragment-get_id0 = 387,
		Beyond-Gameplay-Factory-CollectorFragment-__AOT_FOR_FIX__0 = 388,
		Beyond-Gameplay-Factory-ConnectionFragment-get_valid0 = 389,
		Beyond-Gameplay-Factory-ConnectionFragment-get_id0 = 390,
		Beyond-Gameplay-Factory-ConnectionFragment-__AOT_FOR_FIX__0 = 391,
		Beyond-Gameplay-Factory-ConveyorFragment-SetInflection0 = 392,
		Beyond-Gameplay-Factory-GlobalEnv-GetConveyorRendererInfo0 = 394,
		Beyond-Gameplay-Factory-ConveyorFragment-CalcRect0 = 395,
		Beyond-Gameplay-Factory-ConveyorFragment-Sample0 = 396,
		Beyond-Gameplay-Factory-ConveyorFragment-IsInRect0 = 398,
		Beyond-Gameplay-Factory-ConveyorFragment-GetInRectUnitIndex0 = 399,
		Beyond-Gameplay-Factory-ConveyorFragment-FillRectTargets0 = 400,
		Beyond-Gameplay-Factory-ConveyorFragment-DrawDebug0 = 401,
		Beyond-Gameplay-Factory-ConveyorFragment-get_id0 = 402,
		Beyond-Gameplay-Factory-ConveyorFragment-__AOT_FOR_FIX__0 = 403,
		Beyond-Gameplay-Factory-ConveyorLogisticsUnitFragment-get_id0 = 404,
		Beyond-Gameplay-Factory-ConveyorLogisticsUnitFragment-__AOT_FOR_FIX__0 = 405,
		Beyond-Gameplay-Factory-ConveyorRenderFragment-get_unitAssetInstanceId0 = 406,
		Beyond-Gameplay-Factory-ConveyorRenderFragment-set_unitAssetInstanceId0 = 407,
		Beyond-Gameplay-Factory-ConveyorRenderFragment-get_id0 = 408,
		Beyond-Gameplay-Factory-ConveyorRenderFragment-__AOT_FOR_FIX__0 = 409,
		Beyond-Gameplay-Factory-DirectionFragment-get_isLeft0 = 410,
		Beyond-Gameplay-Factory-DirectionFragment-get_isMid0 = 411,
		Beyond-Gameplay-Factory-DirectionFragment-get_isRight0 = 412,
		Beyond-Gameplay-Factory-DirectionFragment-get_id0 = 413,
		Beyond-Gameplay-Factory-DirectionFragment-__AOT_FOR_FIX__0 = 414,
		Beyond-Gameplay-Factory-CullResultFragment-get_id0 = 415,
		Beyond-Gameplay-Factory-CullResultFragment-__AOT_FOR_FIX__0 = 416,
		Beyond-Gameplay-Factory-DebugFragment-get_id0 = 417,
		Beyond-Gameplay-Factory-DebugFragment-__AOT_FOR_FIX__0 = 418,
		Beyond-Gameplay-Factory-EvtDestroyUnit-get_timeout0 = 419,
		Beyond-Gameplay-Factory-EvtDestroyUnit-get_id0 = 420,
		Beyond-Gameplay-Factory-EvtDestroyUnit-__AOT_FOR_FIX__0 = 421,
		Beyond-Gameplay-Factory-ShowStateUI-get_id0 = 422,
		Beyond-Gameplay-Factory-ShowStateUI-__AOT_FOR_FIX__0 = 423,
		Beyond-Gameplay-Factory-ShowNameUI-get_id0 = 424,
		Beyond-Gameplay-Factory-ShowNameUI-__AOT_FOR_FIX__0 = 425,
		Beyond-Gameplay-Factory-HasRenderer-get_id0 = 426,
		Beyond-Gameplay-Factory-HasRenderer-__AOT_FOR_FIX__0 = 427,
		Beyond-Gameplay-Factory-EnvGeneratorUIRendererFragment-get_unitAssetInstanceId0 = 428,
		Beyond-Gameplay-Factory-EnvGeneratorUIRendererFragment-set_unitAssetInstanceId0 = 429,
		Beyond-Gameplay-Factory-EnvGeneratorUIRendererFragment-get_id0 = 430,
		Beyond-Gameplay-Factory-EnvGeneratorUIRendererFragment-__AOT_FOR_FIX__0 = 431,
		Beyond-Gameplay-Factory-EvtUpdatePipeEffect-get_eventEntity0 = 432,
		Beyond-Gameplay-Factory-EvtUpdatePipeEffect-set_eventEntity0 = 433,
		Beyond-Gameplay-Factory-EvtChangeTemplate-get_eventEntity0 = 434,
		Beyond-Gameplay-Factory-EvtChangeTemplate-set_eventEntity0 = 435,
		Beyond-Gameplay-Factory-EvtCreateUnitRenderer-get_eventEntity0 = 436,
		Beyond-Gameplay-Factory-EvtCreateUnitRenderer-set_eventEntity0 = 437,
		Beyond-Gameplay-Factory-EvtUpdateStatusEffect-get_eventEntity0 = 438,
		Beyond-Gameplay-Factory-EvtUpdateStatusEffect-set_eventEntity0 = 439,
		Beyond-Gameplay-Factory-EvtPendingCreateRenderer-get_eventEntity0 = 440,
		Beyond-Gameplay-Factory-EvtPendingCreateRenderer-set_eventEntity0 = 441,
		Beyond-Gameplay-Factory-EvtUpdateRendererProperty-get_eventEntity0 = 442,
		Beyond-Gameplay-Factory-EvtUpdateRendererProperty-set_eventEntity0 = 443,
		Beyond-Gameplay-Factory-EvtStatusChange-get_eventEntity0 = 444,
		Beyond-Gameplay-Factory-EvtStatusChange-set_eventEntity0 = 445,
		Beyond-Gameplay-Factory-EvtCreateInteract-get_eventEntity0 = 446,
		Beyond-Gameplay-Factory-EvtCreateInteract-set_eventEntity0 = 447,
		Beyond-Gameplay-Factory-EvtVatUpdate-get_eventEntity0 = 448,
		Beyond-Gameplay-Factory-EvtVatUpdate-set_eventEntity0 = 449,
		Beyond-Gameplay-Factory-EvtUpdatePedestalColorLUT-get_eventEntity0 = 450,
		Beyond-Gameplay-Factory-EvtUpdatePedestalColorLUT-set_eventEntity0 = 451,
		Beyond-Gameplay-Factory-EvtAudio-get_eventEntity0 = 452,
		Beyond-Gameplay-Factory-EvtAudio-set_eventEntity0 = 453,
		Beyond-Gameplay-Factory-AudioFragment-get_id0 = 454,
		Beyond-Gameplay-Factory-AudioFragment-__AOT_FOR_FIX__0 = 455,
		Beyond-Gameplay-Factory-ReleaseTagFragment-get_id0 = 456,
		Beyond-Gameplay-Factory-ReleaseTagFragment-__AOT_FOR_FIX__0 = 457,
		Beyond-Gameplay-Factory-CurMapUnitTag-get_id0 = 458,
		Beyond-Gameplay-Factory-CurMapUnitTag-__AOT_FOR_FIX__0 = 459,
		Beyond-Gameplay-Factory-UnitFragment-get_formulaManMode0 = 460,
		Beyond-Gameplay-Factory-UnitFragment-set_formulaManMode0 = 461,
		Beyond-Gameplay-Factory-UnitFragment-get_needRepair0 = 462,
		Beyond-Gameplay-Factory-UnitFragment-get_battleBroken0 = 463,
		Beyond-Gameplay-Factory-UnitFragment-get_socialUnit0 = 464,
		Beyond-Gameplay-Factory-UnitFragment-get_isInvalidPlaced0 = 465,
		Beyond-Gameplay-Factory-UnitFragment-get_isPrefabBuilding0 = 466,
		Beyond-Gameplay-Factory-UnitFragment-get_instKey0 = 467,
		Beyond-Gameplay-Factory-UnitFragment-get_templateId0 = 468,
		Beyond-Gameplay-Factory-UnitFragment-set_templateId0 = 469,
		Beyond-Gameplay-Factory-UnitFragment-get_rendererTemplateId0 = 470,
		Beyond-Gameplay-Factory-UnitFragment-set_rendererTemplateId0 = 471,
		Beyond-Gameplay-Factory-UnitFragment-get_logisticBaseRendererTemplateId0 = 472,
		Beyond-Gameplay-Factory-UnitFragment-set_logisticBaseRendererTemplateId0 = 473,
		Beyond-Gameplay-Factory-UnitFragment-get_nonLogisticBaseRendererTemplateId0 = 474,
		Beyond-Gameplay-Factory-UnitFragment-set_nonLogisticBaseRendererTemplateId0 = 475,
		Beyond-Gameplay-Factory-UnitFragment-set_instKey0 = 476,
		Beyond-Gameplay-Factory-UnitFragment-get_pipeValid0 = 477,
		Beyond-Gameplay-Factory-UnitFragment-Create0 = 478,
		Beyond-Gameplay-Factory-UnitFragment-get_id0 = 479,
		Beyond-Gameplay-Factory-UnitFragment-__AOT_FOR_FIX__0 = 480,
		Beyond-Gameplay-Factory-UnitRenderPipeLogisticsFigureReplaceFragment-get_id0 = 481,
		Beyond-Gameplay-Factory-UnitRenderPipeLogisticsFigureReplaceFragment-__AOT_FOR_FIX__0 = 482,
		Beyond-Gameplay-Factory-BusRenderFragment-get_id0 = 483,
		Beyond-Gameplay-Factory-BusRenderFragment-__AOT_FOR_FIX__0 = 484,
		Beyond-Gameplay-Factory-UnitRenderTypeFragment-get_isBuilding0 = 485,
		Beyond-Gameplay-Factory-UnitRenderTypeFragment-get_isPedestal0 = 486,
		Beyond-Gameplay-Factory-UnitRenderTypeFragment-get_isOnly0 = 487,
		Beyond-Gameplay-Factory-UnitRenderTypeFragment-get_isRegular0 = 488,
		Beyond-Gameplay-Factory-UnitRenderTypeFragment-get_id0 = 489,
		Beyond-Gameplay-Factory-UnitRenderTypeFragment-__AOT_FOR_FIX__0 = 490,
		Beyond-Gameplay-Factory-FakeUnitFragment-get_id0 = 491,
		Beyond-Gameplay-Factory-FakeUnitFragment-__AOT_FOR_FIX__0 = 492,
		Beyond-Gameplay-Factory-UIUnitFragment-get_id0 = 493,
		Beyond-Gameplay-Factory-UIUnitFragment-__AOT_FOR_FIX__0 = 494,
		Beyond-Gameplay-Factory-GuideHintFragment-get_id0 = 495,
		Beyond-Gameplay-Factory-GuideHintFragment-__AOT_FOR_FIX__0 = 496,
		Beyond-Gameplay-Factory-UnitPreviewFragment-get_templateId0 = 497,
		Beyond-Gameplay-Factory-StringIntern-FastId-op_Implicit0 = 498,
		Beyond-Gameplay-Factory-UnitPreviewFragment-set_templateId0 = 499,
		Beyond-Gameplay-Factory-StringIntern-FastId-op_Implicit1 = 500,
		Beyond-Gameplay-Factory-UnitPreviewFragment-get_previewRendererTemplateId0 = 501,
		Beyond-Gameplay-Factory-UnitPreviewFragment-set_previewRendererTemplateId0 = 502,
		Beyond-Gameplay-Factory-UnitPreviewFragment-get_logisticPedestalRendererTemplateId0 = 503,
		Beyond-Gameplay-Factory-UnitPreviewFragment-set_logisticPedestalRendererTemplateId0 = 504,
		Beyond-Gameplay-Factory-UnitPreviewFragment-get_nonLogisticPedestalRendererTemplateId0 = 505,
		Beyond-Gameplay-Factory-UnitPreviewFragment-set_nonLogisticPedestalRendererTemplateId0 = 506,
		Beyond-Gameplay-Factory-UnitPreviewFragment-get_pipeValid0 = 507,
		Beyond-Gameplay-Factory-UnitPreviewFragment-get_id0 = 508,
		Beyond-Gameplay-Factory-UnitPreviewFragment-__AOT_FOR_FIX__0 = 509,
		Beyond-Gameplay-Factory-ConveyorRegularFragment-get_id0 = 510,
		Beyond-Gameplay-Factory-ConveyorRegularFragment-__AOT_FOR_FIX__0 = 511,
		Beyond-Gameplay-Factory-ConveyorGuideFragment-get_id0 = 512,
		Beyond-Gameplay-Factory-ConveyorGuideFragment-__AOT_FOR_FIX__0 = 513,
		Beyond-Gameplay-Factory-PipeRegularFragment-get_id0 = 514,
		Beyond-Gameplay-Factory-PipeRegularFragment-__AOT_FOR_FIX__0 = 515,
		Beyond-Gameplay-Factory-ConveyorPreviewRendererFragment-get_id0 = 516,
		Beyond-Gameplay-Factory-ConveyorPreviewRendererFragment-__AOT_FOR_FIX__0 = 517,
		Beyond-Gameplay-Factory-PipePreviewRendererFragment-get_id0 = 518,
		Beyond-Gameplay-Factory-PipePreviewRendererFragment-__AOT_FOR_FIX__0 = 519,
		Beyond-Gameplay-Factory-PipePreviewFragment-get_id0 = 520,
		Beyond-Gameplay-Factory-PipePreviewFragment-__AOT_FOR_FIX__0 = 521,
		Beyond-Gameplay-Factory-FigureRenderFragment-get_unitAssetInstanceId0 = 522,
		Beyond-Gameplay-Factory-FigureRenderFragment-set_unitAssetInstanceId0 = 523,
		Beyond-Gameplay-Factory-FigureRenderFragment-get_id0 = 524,
		Beyond-Gameplay-Factory-FigureRenderFragment-__AOT_FOR_FIX__0 = 525,
		Beyond-Gameplay-Factory-FigureRenderDirectionFragment-get_isLeft0 = 526,
		Beyond-Gameplay-Factory-FigureRenderDirectionFragment-get_isMid0 = 527,
		Beyond-Gameplay-Factory-FigureRenderDirectionFragment-get_isRight0 = 528,
		Beyond-Gameplay-Factory-FigureRenderDirectionFragment-get_id0 = 529,
		Beyond-Gameplay-Factory-FigureRenderDirectionFragment-__AOT_FOR_FIX__0 = 530,
		Beyond-Gameplay-Factory-FigureRenderPipeHolderFragment-get_id0 = 531,
		Beyond-Gameplay-Factory-FigureRenderPipeHolderFragment-__AOT_FOR_FIX__0 = 532,
		Beyond-Gameplay-Factory-FigureRenderConveyorLogisticsFragment-get_id0 = 533,
		Beyond-Gameplay-Factory-FigureRenderConveyorLogisticsFragment-__AOT_FOR_FIX__0 = 534,
		Beyond-Gameplay-Factory-FluidConsumeFragment-get_id0 = 535,
		Beyond-Gameplay-Factory-FluidConsumeFragment-__AOT_FOR_FIX__0 = 536,
		Beyond-Gameplay-Factory-FluidContainerFragment-Set0 = 537,
		Beyond-Gameplay-Factory-FluidContainerFragment-SetCapacity0 = 538,
		Beyond-Gameplay-Factory-FluidContainerFragment-SetAmount0 = 539,
		Beyond-Gameplay-Factory-FluidContainerFragment-SetRenderAmount0 = 540,
		Beyond-Gameplay-Factory-FluidContainerFragment-Get0 = 541,
		Beyond-Gameplay-Factory-FluidContainerFragment-HasLiquid0 = 542,
		Beyond-Gameplay-Factory-FluidContainerFragment-CalcRenderItemAmount0 = 543,
		Beyond-Gameplay-Factory-FluidContainerFragment-GetOffsetData0 = 544,
		Beyond-Gameplay-Factory-FluidContainerFragment-Reset0 = 545,
		Beyond-Gameplay-Factory-FluidContainerFragment-ToString0 = 546,
		Beyond-Gameplay-Factory-FluidContainerFragment-get_id0 = 547,
		Beyond-Gameplay-Factory-FluidContainerFragment-__AOT_FOR_FIX__0 = 548,
		Beyond-Gameplay-Factory-FluidPumpInFragment-get_id0 = 549,
		Beyond-Gameplay-Factory-FluidPumpInFragment-__AOT_FOR_FIX__0 = 550,
		Beyond-Gameplay-Factory-FluidPumpOutFragment-get_id0 = 551,
		Beyond-Gameplay-Factory-FluidPumpOutFragment-__AOT_FOR_FIX__0 = 552,
		Beyond-Gameplay-Factory-FluidReactionFragment-get_id0 = 553,
		Beyond-Gameplay-Factory-FluidReactionFragment-__AOT_FOR_FIX__0 = 554,
		Beyond-Gameplay-Factory-FluidSprayFragment-get_id0 = 555,
		Beyond-Gameplay-Factory-FluidSprayFragment-__AOT_FOR_FIX__0 = 556,
		Beyond-Gameplay-Factory-FormulaManualFragment-get_id0 = 557,
		Beyond-Gameplay-Factory-FormulaManualFragment-__AOT_FOR_FIX__0 = 558,
		Beyond-Gameplay-Factory-OutOfBufferWarning-ResetFlags0 = 559,
		Beyond-Gameplay-Factory-OutOfBufferWarning-ToString0 = 560,
		Beyond-Gameplay-Factory-GlobalEnv-get_facSystemTickEnabled0 = 561,
		Beyond-Gameplay-Factory-GlobalEnv-InitSkipFlag0 = 562,
		Beyond-Gameplay-Factory-GlobalEnv-CreateQueryResult0 = 563,
		Beyond-Gameplay-Factory-GlobalEnv-DisposeQueryResult0 = 564,
		Beyond-Gameplay-Factory-GlobalEnv-get_portBlockPosListReader0 = 565,
		Beyond-Gameplay-Factory-GlobalEnv-get_outputUIPosListReader0 = 566,
		Beyond-Gameplay-Factory-GlobalEnv-get_envGeneratorUIPosListReader0 = 567,
		Beyond-Gameplay-Factory-GlobalEnv-get_buildingStatePosListReader0 = 568,
		Beyond-Gameplay-Factory-GlobalEnv-get_cargoMatricesBufferIntPtrReader0 = 569,
		Beyond-Gameplay-Factory-GlobalEnv-get_cargoRendererCount0 = 570,
		Beyond-Gameplay-Factory-GlobalEnv-SwapCargoBuffer0 = 571,
		Beyond-Gameplay-Factory-GlobalEnv-get_cargoDirty0 = 572,
		Beyond-Gameplay-Factory-GlobalEnv-get_conveyorLPosMatricesBufferIntPtrReader0 = 573,
		Beyond-Gameplay-Factory-GlobalEnv-get_conveyorMPosMatricesBufferIntPtrReader0 = 574,
		Beyond-Gameplay-Factory-GlobalEnv-get_conveyorRPosMatricesBufferIntPtrReader0 = 575,
		Beyond-Gameplay-Factory-GlobalEnv-get_lConveyorRenderCount0 = 576,
		Beyond-Gameplay-Factory-GlobalEnv-get_mConveyorRenderCount0 = 577,
		Beyond-Gameplay-Factory-GlobalEnv-get_rConveyorRenderCount0 = 578,
		Beyond-Gameplay-Factory-GlobalEnv-SwapConveyorBuffer0 = 579,
		Beyond-Gameplay-Factory-GlobalEnv-get_conveyorDirty0 = 580,
		Beyond-Gameplay-Factory-GlobalEnv-get_conveyorLogPosMatricesReader0 = 581,
		Beyond-Gameplay-Factory-GlobalEnv-get_portArrowMatricesIntPtrReader0 = 582,
		Beyond-Gameplay-Factory-GlobalEnv-get_portArrowRenderCount0 = 583,
		Beyond-Gameplay-Factory-GlobalEnv-SwapPortArrowBuffer0 = 584,
		Beyond-Gameplay-Factory-GlobalEnv-get_portArrowDirty0 = 585,
		Beyond-Gameplay-Factory-GlobalEnv-get_conveyorPreviewLPosMatricesIntPtrReader0 = 586,
		Beyond-Gameplay-Factory-GlobalEnv-get_conveyorPreviewMPosMatricesIntPtrReader0 = 587,
		Beyond-Gameplay-Factory-GlobalEnv-get_conveyorPreviewRPosMatricesIntPtrReader0 = 588,
		Beyond-Gameplay-Factory-GlobalEnv-get_lConveyorPreviewRenderCount0 = 589,
		Beyond-Gameplay-Factory-GlobalEnv-get_mConveyorPreviewRenderCount0 = 590,
		Beyond-Gameplay-Factory-GlobalEnv-get_rConveyorPreviewRenderCount0 = 591,
		Beyond-Gameplay-Factory-GlobalEnv-get_conveyorInsideMatricesReader0 = 592,
		Beyond-Gameplay-Factory-GlobalEnv-SwapPreviewConveyorBuffer0 = 593,
		Beyond-Gameplay-Factory-GlobalEnv-get_previewConveyorDirty0 = 594,
		Beyond-Gameplay-Factory-GlobalEnv-get_guideFigureLPosMatricesBufferIntPtrReader0 = 595,
		Beyond-Gameplay-Factory-GlobalEnv-get_guideFigureMPosMatricesBufferIntPtrReader0 = 596,
		Beyond-Gameplay-Factory-GlobalEnv-get_guideFigureRPosMatricesBufferIntPtrReader0 = 597,
		Beyond-Gameplay-Factory-GlobalEnv-get_lGuideFigureRenderCount0 = 598,
		Beyond-Gameplay-Factory-GlobalEnv-get_mGuideFigureRenderCount0 = 599,
		Beyond-Gameplay-Factory-GlobalEnv-get_rGuideFigureRenderCount0 = 600,
		Beyond-Gameplay-Factory-GlobalEnv-SwapGuideFigureBuffer0 = 601,
		Beyond-Gameplay-Factory-GlobalEnv-get_guideFigureDirty0 = 602,
		Beyond-Gameplay-Factory-GlobalEnv-get_pipeLPosMatricesBufferIntPtrReader0 = 603,
		Beyond-Gameplay-Factory-GlobalEnv-get_pipeMPosMatricesBufferIntPtrReader0 = 604,
		Beyond-Gameplay-Factory-GlobalEnv-get_pipeRPosMatricesBufferIntPtrReader0 = 605,
		Beyond-Gameplay-Factory-GlobalEnv-get_lPipeRenderCount0 = 606,
		Beyond-Gameplay-Factory-GlobalEnv-get_mPipeRenderCount0 = 607,
		Beyond-Gameplay-Factory-GlobalEnv-get_rPipeRenderCount0 = 608,
		Beyond-Gameplay-Factory-GlobalEnv-get_gasPipeLPosMatricesBufferIntPtrReader0 = 609,
		Beyond-Gameplay-Factory-GlobalEnv-get_gasPipeMPosMatricesBufferIntPtrReader0 = 610,
		Beyond-Gameplay-Factory-GlobalEnv-get_gasPipeRPosMatricesBufferIntPtrReader0 = 611,
		Beyond-Gameplay-Factory-GlobalEnv-get_lGasPipeRenderCount0 = 612,
		Beyond-Gameplay-Factory-GlobalEnv-get_mGasPipeRenderCount0 = 613,
		Beyond-Gameplay-Factory-GlobalEnv-get_rGasPipeRenderCount0 = 614,
		Beyond-Gameplay-Factory-GlobalEnv-get_pipeTrackLPosMatricesBufferIntPtrReader0 = 615,
		Beyond-Gameplay-Factory-GlobalEnv-get_pipeTrackMPosMatricesBufferIntPtrReader0 = 616,
		Beyond-Gameplay-Factory-GlobalEnv-get_pipeTrackRPosMatricesBufferIntPtrReader0 = 617,
		Beyond-Gameplay-Factory-GlobalEnv-get_lPipeTrackRenderCount0 = 618,
		Beyond-Gameplay-Factory-GlobalEnv-get_mPipeTrackRenderCount0 = 619,
		Beyond-Gameplay-Factory-GlobalEnv-get_rPipeTrackRenderCount0 = 620,
		Beyond-Gameplay-Factory-GlobalEnv-SwapPipeBuffer0 = 621,
		Beyond-Gameplay-Factory-GlobalEnv-get_anyPipeDirty0 = 622,
		Beyond-Gameplay-Factory-GlobalEnv-get_pipeDirty0 = 623,
		Beyond-Gameplay-Factory-GlobalEnv-get_gasPipeDirty0 = 624,
		Beyond-Gameplay-Factory-GlobalEnv-get_pipeHolderPosMatricesReader0 = 625,
		Beyond-Gameplay-Factory-GlobalEnv-get_comPosMatricesReader0 = 626,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireNormalBufferIntPtrReader0 = 627,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireHsNormalBufferIntPtrReader0 = 628,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireDisableBufferIntPtrReader0 = 629,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenBufferIntPtrReader0 = 630,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireHsStrengthenBufferIntPtrReader0 = 631,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenDisableBufferIntPtrReader0 = 632,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireNormalRendererCount0 = 633,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireHsNormalRendererCount0 = 634,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireDisableRendererCount0 = 635,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenRendererCount0 = 636,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireHsStrengthenRendererCount0 = 637,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenDisableRendererCount0 = 638,
		Beyond-Gameplay-Factory-GlobalEnv-SwapWireBuffer0 = 639,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireNormalDirty0 = 640,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireHsNormalDirty0 = 641,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireDisableDirty0 = 642,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenDirty0 = 643,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireHsStrengthenDirty0 = 644,
		Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenDisableDirty0 = 645,
		Beyond-Gameplay-Factory-GlobalEnv-GetConveyorRendererInfo1 = 646,
		Beyond-Gameplay-Factory-GlobalEnv-AllocateConveyorInfo0 = 647,
		Beyond-Gameplay-Factory-GlobalEnv-CalculateConveyorInfoSize0 = 648,
		Beyond-Gameplay-Factory-GlobalEnv-ResizeConveyorInfo0 = 649,
		Beyond-Gameplay-Factory-GlobalEnv-FreeConveyorInfo0 = 650,
		Beyond-Gameplay-Factory-GlobalEnv-DebugAllocatorPrint0 = 651,
		Beyond-Gameplay-Factory-GlobalEnv-get_animatorParamRequestQueueReader0 = 652,
		Beyond-Gameplay-Factory-GlobalEnv-AddSetAnimatorParamRequest0 = 653,
		Beyond-Gameplay-Factory-UnitConfigFragment-get_unitName0 = 654,
		Beyond-Gameplay-Factory-GlobalEnv-_AddAnimatorParamRequest0 = 655,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-TryGetParameterIndexAndType0 = 656,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-GetStateIndex0 = 657,
		Beyond-Gameplay-Factory-GlobalEnv-AddSetAnimatorParamRequestToPedestal0 = 658,
		Beyond-Gameplay-Factory-GlobalEnv-AddSetAnimatorClipSlotRequest0 = 659,
		Beyond-Gameplay-Factory-GlobalEnv-_AddAnimatorClipSlotRequestToBoundRenders0 = 660,
		Beyond-Gameplay-Factory-GlobalEnv-AddSetAnimatorClipSlotRequestByMode0 = 661,
		Beyond-Gameplay-Factory-GlobalEnv-_AddAnimatorClipSlotRequestByModeToRender0 = 662,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-TryGetClipSlotByMode0 = 663,
		Beyond-Gameplay-Factory-GlobalEnv-get_animatorAudioQueueWriter0 = 664,
		Beyond-Gameplay-Factory-GlobalEnv-GetAudioVATDataAt0 = 665,
		Beyond-Gameplay-Factory-GlobalEnv-GetAudioVATDataLength0 = 666,
		Beyond-Gameplay-Factory-GlobalEnv-ClearAudioVATData0 = 667,
		Beyond-Gameplay-Factory-GlobalEnv-ResetFlags0 = 668,
		Beyond-Gameplay-Factory-GlobalEnv-get_id0 = 669,
		Beyond-Gameplay-Factory-GlobalEnv-__AOT_FOR_FIX__0 = 670,
		Beyond-Gameplay-Factory-HealthPoleFragment-get_id0 = 671,
		Beyond-Gameplay-Factory-HealthPoleFragment-__AOT_FOR_FIX__0 = 672,
		Beyond-Gameplay-Factory-InventoryFragment-get_id0 = 673,
		Beyond-Gameplay-Factory-InventoryFragment-__AOT_FOR_FIX__0 = 674,
		Beyond-Gameplay-Factory-LiquidPurifierFragment-get_id0 = 675,
		Beyond-Gameplay-Factory-LiquidPurifierFragment-__AOT_FOR_FIX__0 = 676,
		Beyond-Gameplay-Factory-LogisticEffectFragment-get_id0 = 677,
		Beyond-Gameplay-Factory-LogisticEffectFragment-__AOT_FOR_FIX__0 = 678,
		Beyond-Gameplay-Factory-LogisticEntityBindFragment-EnqueueCargoEntityImpl0 = 679,
		Beyond-Gameplay-Factory-LogisticEntityBindFragment-DequeueCargoEntityImpl0 = 680,
		Beyond-Gameplay-Factory-LogisticEntityBindFragment-get_cargoCount0 = 681,
		Beyond-Gameplay-Factory-LogisticEntityBindFragment-get_id0 = 682,
		Beyond-Gameplay-Factory-LogisticEntityBindFragment-__AOT_FOR_FIX__0 = 683,
		Beyond-Gameplay-Factory-MapGridRendererFragment-get_id0 = 684,
		Beyond-Gameplay-Factory-MapGridRendererFragment-__AOT_FOR_FIX__0 = 685,
		Beyond-Gameplay-Factory-OutputFragment-Clean0 = 686,
		Beyond-Gameplay-Factory-OutputFragment-SetColor0 = 687,
		Beyond-Gameplay-Factory-OutputFragment-SetColor1 = 688,
		Beyond-Gameplay-Factory-OutputFragment-SetAtlasRect0 = 689,
		Beyond-Gameplay-Factory-OutputFragment-SetAtlasRect1 = 690,
		Beyond-Gameplay-Factory-OutputFragment-GetEnableLiquidIcon0 = 691,
		Beyond-Gameplay-Factory-OutputFragment-SetEnableLiquidIcon0 = 692,
		Beyond-Gameplay-Factory-OutputFragment-SetLiquidIconUV0 = 693,
		Beyond-Gameplay-Factory-OutputFragment-get_hasOutput0 = 694,
		Beyond-Gameplay-Factory-OutputFragment-get_id0 = 695,
		Beyond-Gameplay-Factory-OutputFragment-__AOT_FOR_FIX__0 = 696,
		Beyond-Gameplay-Factory-OutputUIRendererFragment-get_unitAssetInstanceId0 = 697,
		Beyond-Gameplay-Factory-OutputUIRendererFragment-set_unitAssetInstanceId0 = 698,
		Beyond-Gameplay-Factory-OutputUIRendererFragment-get_id0 = 699,
		Beyond-Gameplay-Factory-OutputUIRendererFragment-__AOT_FOR_FIX__0 = 700,
		Beyond-Gameplay-Factory-PedestalLightFlashFragment-get_id0 = 701,
		Beyond-Gameplay-Factory-PedestalLightFlashFragment-__AOT_FOR_FIX__0 = 702,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-IsValid0 = 703,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetIntensity0 = 704,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashIntensity0 = 705,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlash0 = 706,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashDuration0 = 707,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetColor0 = 708,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashColor0 = 709,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetIntensity0 = 710,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashIntensity0 = 711,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlash0 = 712,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashDuration0 = 713,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetColor0 = 714,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashColor0 = 715,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-get_id0 = 716,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-__AOT_FOR_FIX__0 = 717,
		Beyond-Gameplay-Factory-PipeEffectFragment-get_inEffectName0 = 718,
		Beyond-Gameplay-Factory-PipeEffectFragment-set_inEffectName0 = 719,
		Beyond-Gameplay-Factory-PipeEffectFragment-get_outEffectName0 = 720,
		Beyond-Gameplay-Factory-PipeEffectFragment-set_outEffectName0 = 721,
		Beyond-Gameplay-Factory-PipeEffectFragment-get_inEffectConnectedName0 = 722,
		Beyond-Gameplay-Factory-PipeEffectFragment-set_inEffectConnectedName0 = 723,
		Beyond-Gameplay-Factory-PipeEffectFragment-get_outEffectConnectedName0 = 724,
		Beyond-Gameplay-Factory-PipeEffectFragment-set_outEffectConnectedName0 = 725,
		Beyond-Gameplay-Factory-PipeEffectFragment-get_activateInEffectName0 = 726,
		Beyond-Gameplay-Factory-PipeEffectFragment-set_activateInEffectName0 = 727,
		Beyond-Gameplay-Factory-PipeEffectFragment-get_activateInEffectConnectedName0 = 728,
		Beyond-Gameplay-Factory-PipeEffectFragment-set_activateInEffectConnectedName0 = 729,
		Beyond-Gameplay-Factory-PipeEffectFragment-get_id0 = 730,
		Beyond-Gameplay-Factory-PipeEffectFragment-__AOT_FOR_FIX__0 = 731,
		Beyond-Gameplay-Factory-PipeFragment-SetInflection0 = 732,
		Beyond-Gameplay-Factory-PipeFragment-Bend0 = 735,
		Beyond-Gameplay-Factory-PipeFragment-GetCornerIndexList0 = 736,
		Beyond-Gameplay-Factory-PipeFragment-Sample0 = 737,
		Beyond-Gameplay-Factory-PipeFragment-IsInRect0 = 738,
		Beyond-Gameplay-Factory-PipeFragment-GetInRectUnitIndex0 = 739,
		Beyond-Gameplay-Factory-PipeFragment-FillRectTargets0 = 740,
		Beyond-Gameplay-Factory-PipeFragment-SetFluidHeightAndRefreshThickness0 = 741,
		Beyond-Gameplay-Factory-PipeFragment-RefreshWaterThicknessByFirstIndex0 = 742,
		Beyond-Gameplay-Factory-PipeFragment-get_id0 = 743,
		Beyond-Gameplay-Factory-PipeFragment-__AOT_FOR_FIX__0 = 744,
		Beyond-Gameplay-Factory-PipeHolderFragment-get_id0 = 745,
		Beyond-Gameplay-Factory-PipeHolderFragment-__AOT_FOR_FIX__0 = 746,
		Beyond-Gameplay-Factory-PipeLogisticsUnitFragment-get_id0 = 747,
		Beyond-Gameplay-Factory-PipeLogisticsUnitFragment-__AOT_FOR_FIX__0 = 748,
		Beyond-Gameplay-Factory-PipeComRenderFragment-get_unitAssetInstanceId0 = 749,
		Beyond-Gameplay-Factory-PipeComRenderFragment-set_unitAssetInstanceId0 = 750,
		Beyond-Gameplay-Factory-PipeComRenderFragment-get_id0 = 751,
		Beyond-Gameplay-Factory-PipeComRenderFragment-__AOT_FOR_FIX__0 = 752,
		Beyond-Gameplay-Factory-PipeRenderFragment-get_unitAssetInstanceId0 = 753,
		Beyond-Gameplay-Factory-PipeRenderFragment-set_unitAssetInstanceId0 = 754,
		Beyond-Gameplay-Factory-PipeRenderFragment-get_id0 = 755,
		Beyond-Gameplay-Factory-PipeRenderFragment-__AOT_FOR_FIX__0 = 756,
		Beyond-Gameplay-Factory-PipeTrackRenderFragment-get_unitAssetInstanceId0 = 757,
		Beyond-Gameplay-Factory-PipeTrackRenderFragment-set_unitAssetInstanceId0 = 758,
		Beyond-Gameplay-Factory-PipeTrackRenderFragment-get_id0 = 759,
		Beyond-Gameplay-Factory-PipeTrackRenderFragment-__AOT_FOR_FIX__0 = 760,
		Beyond-Gameplay-Factory-ComplexPortFragment-ResetBannedState0 = 761,
		Beyond-Gameplay-Factory-ComplexPortFragment-AllowAdditivePort0 = 762,
		Beyond-Gameplay-Factory-ComplexPortFragment-BanPort0 = 763,
		Beyond-Gameplay-Factory-ComplexPortFragment-BindComponentId0 = 764,
		Beyond-Gameplay-Factory-ComplexPortFragment-BlockPortsWithComponentId0 = 765,
		Beyond-Gameplay-Factory-ComplexPortFragment-BlockPorts0 = 766,
		Beyond-Gameplay-Factory-ComplexPortFragment-FollowUnit0 = 767,
		Beyond-Gameplay-Factory-ComplexPortFragment-AnyPortBlocked0 = 768,
		Beyond-Gameplay-Factory-ComplexPortFragment-AnyPortConnected0 = 769,
		Beyond-Gameplay-Factory-ComplexPortFragment-Equals0 = 770,
		Beyond-Gameplay-Factory-PortData-Equals0 = 771,
		Beyond-Gameplay-Factory-ComplexPortFragment-Equals1 = 772,
		Beyond-Gameplay-Factory-ComplexPortFragment-GetHashCode0 = 773,
		Beyond-Gameplay-Factory-ComplexPortFragment-op_Equality0 = 774,
		Beyond-Gameplay-Factory-ComplexPortFragment-op_Inequality0 = 775,
		Beyond-Gameplay-Factory-ComplexPortFragment-ToString0 = 776,
		Beyond-Gameplay-Factory-PortData-ToString0 = 777,
		Beyond-Gameplay-Factory-PortData-get_isUsable0 = 778,
		Beyond-Gameplay-Factory-ComplexPortFragment-get_id0 = 779,
		Beyond-Gameplay-Factory-ComplexPortFragment-__AOT_FOR_FIX__0 = 780,
		Beyond-Gameplay-Factory-PortData-TRS0 = 781,
		Beyond-Gameplay-Factory-PortData-Equals1 = 782,
		Beyond-Gameplay-Factory-PortData-GetHashCode0 = 783,
		Beyond-Gameplay-Factory-PortData-op_Equality0 = 784,
		Beyond-Gameplay-Factory-PortData-op_Inequality0 = 785,
		Beyond-Gameplay-Factory-PortPreviewUIRendererFragment-get_unitAssetInstanceId0 = 786,
		Beyond-Gameplay-Factory-PortPreviewUIRendererFragment-set_unitAssetInstanceId0 = 787,
		Beyond-Gameplay-Factory-PortPreviewUIRendererFragment-get_id0 = 788,
		Beyond-Gameplay-Factory-PortPreviewUIRendererFragment-__AOT_FOR_FIX__0 = 789,
		Beyond-Gameplay-Factory-PortStatusUIFragment-get_unitAssetInstanceId0 = 790,
		Beyond-Gameplay-Factory-PortStatusUIFragment-set_unitAssetInstanceId0 = 791,
		Beyond-Gameplay-Factory-PortStatusUIFragment-get_id0 = 792,
		Beyond-Gameplay-Factory-PortStatusUIFragment-__AOT_FOR_FIX__0 = 793,
		Beyond-Gameplay-Factory-ProducerFragment-get_outputFormulaId0 = 794,
		Beyond-Gameplay-Factory-ProducerFragment-get_id0 = 795,
		Beyond-Gameplay-Factory-ProducerFragment-__AOT_FOR_FIX__0 = 796,
		Beyond-Gameplay-Factory-SharedDataFragment-GetExtData0 = 797,
		Beyond-Gameplay-Factory-SharedDataFragment-DestroyData0 = 798,
		Beyond-Gameplay-Factory-SharedDataFragment-get_id0 = 799,
		Beyond-Gameplay-Factory-SharedDataFragment-__AOT_FOR_FIX__0 = 800,
		Beyond-Gameplay-Factory-SocialFragment-Create0 = 801,
		Beyond-Gameplay-Factory-SocialFragment-IsHighLiked0 = 802,
		Beyond-Gameplay-Factory-SocialFragment-IsLiked0 = 803,
		Beyond-Gameplay-Factory-SocialFragment-get_id0 = 804,
		Beyond-Gameplay-Factory-SocialFragment-__AOT_FOR_FIX__0 = 805,
		Beyond-Gameplay-Factory-SignData-GetText0 = 806,
		Beyond-Gameplay-Factory-SignData-GetCustomPerDrawData0 = 807,
		Beyond-Gameplay-Factory-SignData-SetSignBuildingIcon0 = 808,
		Beyond-Gameplay-Factory-SignData-SetSignBuildingIconWithRenderEntity0 = 809,
		Beyond-Gameplay-Factory-LocalTransform-FromMatrix0 = 810,
		Beyond-Gameplay-Factory-LocalTransform-FromMatrixSafe0 = 811,
		Beyond-Gameplay-Factory-LocalTransform-FromPositionRotation0 = 812,
		Beyond-Gameplay-Factory-LocalTransform-FromPositionRotationScale0 = 813,
		Beyond-Gameplay-Factory-LocalTransform-FromPosition0 = 814,
		Beyond-Gameplay-Factory-LocalTransform-FromPosition1 = 815,
		Beyond-Gameplay-Factory-LocalTransform-FromRotation0 = 816,
		Beyond-Gameplay-Factory-LocalTransform-FromScale0 = 817,
		Beyond-Gameplay-Factory-LocalTransform-ToString0 = 818,
		Beyond-Gameplay-Factory-LocalTransform-Right0 = 819,
		Beyond-Gameplay-Factory-LocalTransform-TransformDirection0 = 820,
		Beyond-Gameplay-Factory-LocalTransform-Up0 = 821,
		Beyond-Gameplay-Factory-LocalTransform-Forward0 = 822,
		Beyond-Gameplay-Factory-LocalTransform-TransformPoint0 = 823,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformPoint0 = 824,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformDirection0 = 825,
		Beyond-Gameplay-Factory-LocalTransform-TransformRotation0 = 826,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformRotation0 = 827,
		Beyond-Gameplay-Factory-LocalTransform-TransformScale0 = 828,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformScale0 = 829,
		Beyond-Gameplay-Factory-LocalTransform-TransformTransform0 = 830,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformTransform0 = 831,
		Beyond-Gameplay-Factory-LocalTransform-Inverse0 = 832,
		Beyond-Gameplay-Factory-LocalTransform-ToInverseMatrix0 = 833,
		Beyond-Gameplay-Factory-LocalTransform-WithPosition0 = 834,
		Beyond-Gameplay-Factory-LocalTransform-WithPosition1 = 835,
		Beyond-Gameplay-Factory-LocalTransform-WithRotation0 = 836,
		Beyond-Gameplay-Factory-LocalTransform-WithScale0 = 837,
		Beyond-Gameplay-Factory-LocalTransform-Translate0 = 838,
		Beyond-Gameplay-Factory-LocalTransform-ApplyScale0 = 839,
		Beyond-Gameplay-Factory-LocalTransform-Rotate0 = 840,
		Beyond-Gameplay-Factory-LocalTransform-RotateX0 = 841,
		Beyond-Gameplay-Factory-LocalTransform-RotateY0 = 842,
		Beyond-Gameplay-Factory-LocalTransform-RotateZ0 = 843,
		Beyond-Gameplay-Factory-LocalTransform-Equals0 = 844,
		Beyond-Gameplay-Factory-LocalTransform-get_id0 = 845,
		Beyond-Gameplay-Factory-LocalTransform-__AOT_FOR_FIX__0 = 846,
		Beyond-Gameplay-Factory-Root-get_id0 = 847,
		Beyond-Gameplay-Factory-Root-__AOT_FOR_FIX__0 = 848,
		Beyond-Gameplay-Factory-Parent-get_id0 = 849,
		Beyond-Gameplay-Factory-Parent-__AOT_FOR_FIX__0 = 850,
		Beyond-Gameplay-Factory-Child-get_id0 = 851,
		Beyond-Gameplay-Factory-Child-__AOT_FOR_FIX__0 = 852,
		Beyond-Gameplay-Factory-LocalToWorld-SetValue0 = 853,
		Beyond-Gameplay-Factory-LocalToWorld-get_right0 = 854,
		Beyond-Gameplay-Factory-LocalToWorld-get_up0 = 855,
		Beyond-Gameplay-Factory-LocalToWorld-get_forward0 = 856,
		Beyond-Gameplay-Factory-LocalToWorld-get_position0 = 857,
		Beyond-Gameplay-Factory-LocalToWorld-get_rotation0 = 858,
		Beyond-Gameplay-Factory-LocalToWorld-get_prePosition0 = 859,
		Beyond-Gameplay-Factory-LocalToWorld-get_preRotation0 = 860,
		Beyond-Gameplay-Factory-LocalToWorld-get_id0 = 861,
		Beyond-Gameplay-Factory-LocalToWorld-__AOT_FOR_FIX__0 = 862,
		Beyond-Gameplay-Factory-UdPipeFragment-get_id0 = 863,
		Beyond-Gameplay-Factory-UdPipeFragment-__AOT_FOR_FIX__0 = 864,
		Beyond-Gameplay-Factory-UnitConfigFragment-get_iconOnPanel0 = 865,
		Beyond-Gameplay-Factory-UnitConfigFragment-set_iconOnPanel0 = 866,
		Beyond-Gameplay-Factory-UnitConfigFragment-set_unitName0 = 867,
		Beyond-Gameplay-Factory-UnitConfigFragment-get_id0 = 868,
		Beyond-Gameplay-Factory-UnitConfigFragment-__AOT_FOR_FIX__0 = 869,
		Beyond-Gameplay-Factory-FactoryUnitExtendConfig-get_name0 = 870,
		Beyond-Gameplay-Factory-FactoryUnitExtendConfig-ToString0 = 871,
		Beyond-Gameplay-Factory-UnitEnvironmentRelation-get_envType0 = 874,
		Beyond-Gameplay-Factory-UnitEnvironmentRelation-get_id0 = 875,
		Beyond-Gameplay-Factory-UnitEnvironmentRelation-__AOT_FOR_FIX__0 = 876,
		Beyond-Gameplay-Factory-UnitInteractFragment-get_id0 = 877,
		Beyond-Gameplay-Factory-UnitInteractFragment-__AOT_FOR_FIX__0 = 878,
		Beyond-Gameplay-Factory-UnitRenderFragment-get_unitAssetInstanceId0 = 879,
		Beyond-Gameplay-Factory-UnitRenderFragment-set_unitAssetInstanceId0 = 880,
		Beyond-Gameplay-Factory-UnitRenderFragment-get_id0 = 881,
		Beyond-Gameplay-Factory-UnitRenderFragment-__AOT_FOR_FIX__0 = 882,
		Beyond-Gameplay-Factory-RenderLookAtFragment-get_id0 = 883,
		Beyond-Gameplay-Factory-RenderLookAtFragment-__AOT_FOR_FIX__0 = 884,
		Beyond-Gameplay-Factory-ChapterTagFragment-get_id0 = 885,
		Beyond-Gameplay-Factory-ChapterTagFragment-__AOT_FOR_FIX__0 = 886,
		Beyond-Gameplay-Factory-UnitStatusFragment-get_id0 = 887,
		Beyond-Gameplay-Factory-UnitStatusFragment-__AOT_FOR_FIX__0 = 888,
		Beyond-Gameplay-Factory-UnitOverrideStatusFragment-get_id0 = 889,
		Beyond-Gameplay-Factory-UnitOverrideStatusFragment-__AOT_FOR_FIX__0 = 890,
		Beyond-Gameplay-Factory-UnitStatusEffectFragment-SetEffectConfig0 = 891,
		Beyond-Gameplay-Factory-StatusEffectConfigCache-Register0 = 892,
		Beyond-Gameplay-Factory-UnitStatusEffectFragment-GetEffect0 = 893,
		Beyond-Gameplay-Factory-StatusEffectConfigCache-GetEffects0 = 894,
		Beyond-Gameplay-Factory-UnitStatusEffectFragment-get_id0 = 895,
		Beyond-Gameplay-Factory-UnitStatusEffectFragment-__AOT_FOR_FIX__0 = 896,
		Beyond-Gameplay-Factory-StatusEffectConfigCache-Clear0 = 897,
		Beyond-Gameplay-Factory-StatusSingleEffect-get_effectName0 = 898,
		Beyond-Gameplay-Factory-StatusSingleEffect-set_effectName0 = 899,
		Beyond-Gameplay-Factory-FacEffectCfgList-get_cfgCount0 = 900,
		Beyond-Gameplay-Factory-UnitStatusUIRendererFragment-get_unitAssetInstanceId0 = 901,
		Beyond-Gameplay-Factory-UnitStatusUIRendererFragment-set_unitAssetInstanceId0 = 903,
		Beyond-Gameplay-Factory-UnitStatusUIRendererFragment-get_id0 = 905,
		Beyond-Gameplay-Factory-UnitStatusUIRendererFragment-__AOT_FOR_FIX__0 = 906,
		Beyond-Gameplay-Factory-UnitTransFragment-get_RotationQuaternion0 = 907,
		Beyond-Gameplay-Factory-UnitTransFragment-get_Rotation0 = 908,
		Beyond-Gameplay-Factory-UnitTransFragment-set_Position0 = 909,
		Beyond-Gameplay-Factory-UnitTransFragment-get_Position0 = 910,
		Beyond-Gameplay-Factory-UnitTransFragment-set_Rotation0 = 911,
		Beyond-Gameplay-Factory-UnitTransFragment-InBound0 = 912,
		Beyond-Gameplay-Factory-UnitTransFragment-Get2DRectInt0 = 913,
		Beyond-Gameplay-Factory-UnitTransFragment-get_id0 = 914,
		Beyond-Gameplay-Factory-UnitTransFragment-__AOT_FOR_FIX__0 = 915,
		Beyond-Gameplay-Factory-ValveFragment-get_id0 = 916,
		Beyond-Gameplay-Factory-ValveFragment-__AOT_FOR_FIX__0 = 917,
		Beyond-Gameplay-Factory-BoxValve-get_id0 = 918,
		Beyond-Gameplay-Factory-BoxValve-__AOT_FOR_FIX__0 = 919,
		Beyond-Gameplay-Factory-FluidValve-get_id0 = 920,
		Beyond-Gameplay-Factory-FluidValve-__AOT_FOR_FIX__0 = 921,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-ContainsNodeId0 = 922,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetExtData0 = 923,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-RemoveEntityFromSlot0 = 924,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-FindEmptySlotIdx0 = 925,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSuitableSlotIdx0 = 926,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-SetSlotId0 = 927,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSlotIds0 = 928,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-AppendSlotInfo0 = 929,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-ClearSlotInfo0 = 930,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-DiffSlotInfo0 = 931,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetAllPendingEntitiesInSlot0 = 932,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetPendingEntityCountInSlot0 = 933,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSlotInfo0 = 934,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-ToString0 = 935,
		Beyond-Gameplay-Factory-ConveyorRendererInfo-ToString0 = 936,
		Beyond-Gameplay-Factory-PipeRendererInfo-PackPackedMeta0 = 937,
		Beyond-Gameplay-Factory-PipeRendererInfo-GetProto0 = 938,
		Beyond-Gameplay-Factory-PipeRendererInfo-GetIsPreview0 = 939,
		Beyond-Gameplay-Factory-PipeRendererInfo-GetValid0 = 940,
		Beyond-Gameplay-Factory-PipeRendererInfo-GetHighLight0 = 941,
		Beyond-Gameplay-Factory-PipeRendererInfo-GetBlueprintType0 = 942,
		Beyond-Gameplay-Factory-UnitId-Equals0 = 943,
		Beyond-Gameplay-Factory-UnitId-Equals1 = 944,
		Beyond-Gameplay-Factory-UnitId-GetHashCode0 = 945,
		Beyond-Gameplay-Factory-Visibility-SetVisible0 = 946,
		Beyond-Gameplay-Factory-WireRendererFragment-get_unitAssetInstanceId0 = 947,
		Beyond-Gameplay-Factory-WireRendererFragment-set_unitAssetInstanceId0 = 948,
		Beyond-Gameplay-Factory-WireRendererFragment-get_id0 = 949,
		Beyond-Gameplay-Factory-WireRendererFragment-__AOT_FOR_FIX__0 = 950,
		Beyond-Gameplay-Factory-GlobalSharedData-Reset0 = 951,
		Beyond-Gameplay-Factory-GlobalSharedData-MapGridRendererData-Reset0 = 952,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-ResetOverride0 = 953,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-set_sqrCullDis0 = 954,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrCullDis0 = 955,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-set_sqrUI0 = 956,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrUI0 = 957,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-set_sqrBuildingName0 = 958,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrBuildingName0 = 959,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-set_sqrWireCullDis0 = 960,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrWireCullDis0 = 961,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-ResetOverride0 = 962,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-Disable0 = 963,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-set_portPreviewCheckDistance0 = 964,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-set_pedestalFlashCheckDistance0 = 965,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-set_logisticEffectCheckDistance0 = 966,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-set_unitRendererCheckDistance0 = 967,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-set_l2wCheckDistance0 = 968,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-set_additiveEffectCheckDistance0 = 969,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-set_nearByCheck0 = 970,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_nearByCheck0 = 971,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_portPreviewCheckDistance0 = 972,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_pedestalFlashCheckDistance0 = 973,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_logisticEffectCheckDistance0 = 974,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_unitRendererCheckDistance0 = 975,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_l2wCheckDistance0 = 976,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_additiveEffectCheckDistance0 = 977,
		Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-Disable0 = 978,
		Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-set_buildingNameShadowDisable0 = 979,
		Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-ResetOverride0 = 980,
		Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-get_buildingNameShadowDisable0 = 981,
		Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetBuildCurve0 = 982,
		Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetRepairCurve00 = 983,
		Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetRepairCurve10 = 984,
		Beyond-Gameplay-Factory-GlobalSharedData-MapGridRendererData-UpdateGrid0 = 985,
		Beyond-Gameplay-Factory-GlobalSharedData-MapGridRendererData-get_Item0 = 986,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Initialize0 = 987,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Dispose0 = 988,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-EnsureValue0 = 989,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-TryGetValue1 = 990,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-TryGetValue0 = 991,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_CreateWithTable0 = 992,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_ParseGlobalPortIdx0 = 994,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Add1 = 996,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Add0 = 997,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-EnsureValue1 = 998,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_CreateWithTable1 = 999,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-ContainsKey0 = 1000,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Clear0 = 1001,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-Apply0 = 1002,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-_GetKey0 = 1003,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-ApplyPass0 = 1004,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-Parse0 = 1005,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-set_Item0 = 1006,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-set_Item0 = 1007,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-GetPerDrawPassConfig0 = 1008,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-get_Item0 = 1009,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-GetPerDrawConfig0 = 1010,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-get_Item0 = 1011,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-Disable0 = 1012,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-set_crossCollectFrameInterval0 = 1013,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-set_cullingSystemInterval0 = 1014,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-set_unitPreviewSystemInterval0 = 1015,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-set_portPreviewRenderSystemInterval0 = 1016,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-set_buildingStateSystemInterval0 = 1017,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-set_portBlockSystemInterval0 = 1018,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-set_outputUISystemInterval0 = 1019,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-set_buildingNameSystemInterval0 = 1020,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-set_adjustGroundSystemInterval0 = 1021,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-set_gridSystemInterval0 = 1022,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-ResetOverride0 = 1023,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_crossCollectFrameInterval0 = 1024,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_cullingSystemInterval0 = 1025,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_unitPreviewSystemInterval0 = 1026,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_portPreviewRenderSystemInterval0 = 1027,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_buildingStateSystemInterval0 = 1028,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_portBlockSystemInterval0 = 1029,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_outputUISystemInterval0 = 1030,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_envGeneratorUISystemInterval0 = 1031,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_buildingNameSystemInterval0 = 1032,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_adjustGroundSystemInterval0 = 1033,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_gridSystemInterval0 = 1034,
		Beyond-Gameplay-Factory-GlobalSharedData-UIEffectPathConfig-Parse0 = 1035,
		Beyond-Gameplay-Factory-GlobalSharedData-UIEffectPathConfig-Get0 = 1036,
		Beyond-Gameplay-Factory-BaseProcessor-Initialize0 = 1037,
		Beyond-Gameplay-Factory-BaseProcessor-PreExecute0 = 1038,
		Beyond-Gameplay-Factory-BaseProcessor-Execute0 = 1039,
		Beyond-Gameplay-Factory-BaseProcessor-LateExecute0 = 1040,
		Beyond-Gameplay-Factory-BaseProcessor-CleanUp0 = 1041,
		Beyond-Gameplay-Factory-BaseProcessor-TearDown0 = 1042,
		Beyond-Gameplay-Factory-BaseProcessor-get_lowFrameEnable0 = 1043,
		Beyond-Gameplay-Factory-BaseProcessor-StructuralSync0 = 1044,
		Beyond-Gameplay-Factory-BaseProcessor-ScheduleNoneDependencies0 = 1045,
		Beyond-Gameplay-Factory-BaseProcessor-InLowFrameMode0 = 1046,
		Beyond-Gameplay-Factory-BaseProcessor-SpecialEntityExisted0 = 1047,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetApplyRenderPointer0 = 1048,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetFacRegionValid0 = 1049,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetQueryStateIconPathFuncPtr0 = 1050,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetLogicEntityWithPosAdapter0 = 1051,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetQueryBuildingStatePointer0 = 1052,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetSetEntityFlashStatuePointer0 = 1053,
		Beyond-Gameplay-Factory-AdditiveEffectJob-SetSharedExtData0 = 1054,
		Beyond-Gameplay-Factory-AdditiveEffectJob-Execute1 = 1055,
		Beyond-Gameplay-Factory-AdditiveEffectJob-Execute0 = 1056,
		Beyond-Gameplay-Factory-AdditiveEffectJob-_OnStackEmpty0 = 1057,
		Beyond-Gameplay-Factory-AdditiveEffectJob-_UpdateInternalStateLifeCycle0 = 1058,
		Beyond-Gameplay-Factory-AdditiveEffectJob-_InitBuildState0 = 1059,
		Beyond-Gameplay-Factory-AdditiveEffectJob-SetQueryResult0 = 1060,
		Beyond-Gameplay-Factory-AdditiveEffectJob-ScheduleDefer0 = 1061,
		Beyond-Gameplay-Factory-AdditiveEffectJob-ScheduleDefer1 = 1062,
		Beyond-Gameplay-Factory-AdditiveEffectQueryJob-Execute0 = 1063,
		Beyond-Gameplay-Factory-AdditiveEffectQueryJob-SetQueryResult0 = 1064,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPNormalEffectExecute0 = 1065,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPBuildEffectExecute0 = 1066,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPBuildCutoffEffectExecute0 = 1067,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-SetSharedExtData0 = 1069,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-Execute1 = 1070,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-Execute0 = 1071,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BuildStateStart0 = 1072,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ResetMaterial0 = 1073,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BuildStateEnd0 = 1074,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_Repair0Start0 = 1075,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_Repair0End0 = 1076,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-SetQueryResult0 = 1077,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ScheduleDefer0 = 1078,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ScheduleDefer1 = 1079,
		Beyond-Gameplay-Factory-AudioJobs-AudioDistanceAndCullingJob-Execute0 = 1080,
		Beyond-Gameplay-Factory-AudioJobs-AudioGroupEmitterJob-Execute0 = 1081,
		Beyond-Gameplay-Factory-AudioJobs-AudioGroupEmitterJob-SetSharedExtData0 = 1082,
		Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-Execute0 = 1083,
		Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-_DoCalculate0 = 1084,
		Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-_DoCalculatePipe0 = 1085,
		Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-SetGlobalEnv0 = 1086,
		Beyond-Gameplay-Factory-BatchArrowJob-_ExecutePort0 = 1087,
		Beyond-Gameplay-Factory-BatchArrowJob-_BatchPortArrow0 = 1088,
		Beyond-Gameplay-Factory-BatchArrowJob-_ExecutePreview0 = 1089,
		Beyond-Gameplay-Factory-BatchArrowJob-Execute0 = 1090,
		Beyond-Gameplay-Factory-BatchArrowJob-SetSharedExtData0 = 1091,
		Beyond-Gameplay-Factory-BatchArrowJob-Execute1 = 1092,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-Execute0 = 1093,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-_CollectInsideConveyor0 = 1094,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-_BatchPortInside0 = 1095,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-SetSharedExtData0 = 1096,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-Execute1 = 1097,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-_ExecutePort0 = 1098,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-_BatchPortArrow0 = 1099,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-Execute0 = 1100,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-Execute1 = 1101,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-SetSharedExtData0 = 1102,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-Execute0 = 1103,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-_ExecutePreview0 = 1104,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-_BatchPortArrow0 = 1105,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-SetSharedExtData0 = 1106,
		Beyond-Gameplay-Factory-BufferSwapJob-Execute0 = 1107,
		Beyond-Gameplay-Factory-BuildingEnvRenderJob-Execute0 = 1108,
		Beyond-Gameplay-Factory-BuildingEnvRenderJob-_RenderEnv0 = 1109,
		Beyond-Gameplay-Factory-BuildingEnvRenderJob-SetQueryResult0 = 1110,
		Beyond-Gameplay-Factory-BuildingEnvRenderJob-ScheduleDefer0 = 1111,
		Beyond-Gameplay-Factory-BuildingEnvRenderJob-Execute1 = 1112,
		Beyond-Gameplay-Factory-BuildingEnvRenderJob-SetSharedExtData0 = 1113,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-Execute0 = 1114,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-_ApplyLiquidPerDraw0 = 1115,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-Execute1 = 1116,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-SetQueryResult0 = 1117,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-ScheduleDefer0 = 1118,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-SetSharedExtData0 = 1119,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute0 = 1120,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-_Collect0 = 1121,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute1 = 1122,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute2 = 1123,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-SetSharedExtData0 = 1124,
		Beyond-Gameplay-Factory-BuildingStateRendererJob-Execute0 = 1125,
		Beyond-Gameplay-Factory-CargoCollectJob-Execute0 = 1126,
		Beyond-Gameplay-Factory-CargoCollectJob-Execute1 = 1127,
		Beyond-Gameplay-Factory-CargoCollectJob-SetGlobalEnvRef0 = 1128,
		Beyond-Gameplay-Factory-CargoCollectJob-SetConveyorExtData0 = 1129,
		Beyond-Gameplay-Factory-CargoCollectJob-SetSharedExtData0 = 1130,
		Beyond-Gameplay-Factory-CargoPredictJob-Execute0 = 1131,
		Beyond-Gameplay-Factory-CargoPredictJob-SetConveyorExtData0 = 1132,
		Beyond-Gameplay-Factory-CargoPredictJob-SetSharedExtData0 = 1133,
		Beyond-Gameplay-Factory-CargoPredictJob-SetQueryResult0 = 1134,
		Beyond-Gameplay-Factory-CargoPredictJob-ScheduleDefer0 = 1135,
		Beyond-Gameplay-Factory-CargoPredictQueryJob-Execute0 = 1136,
		Beyond-Gameplay-Factory-CargoPredictQueryJob-SetQueryResult0 = 1137,
		Beyond-Gameplay-Factory-CargoRenderJob-Execute0 = 1138,
		Beyond-Gameplay-Factory-CargoRenderJob-SetRendererList0 = 1139,
		Beyond-Gameplay-Factory-CargoRenderJob-ResolveAccess0 = 1140,
		Beyond-Gameplay-Factory-CargoRenderQueryJob-Execute0 = 1141,
		Beyond-Gameplay-Factory-CargoRenderQueryJob-SetQueryResult0 = 1142,
		Beyond-Gameplay-Factory-ClearRendererVisibleDirtyJob-Execute0 = 1143,
		Beyond-Gameplay-Factory-ClearRendererVisibleDirtyJob-SetSharedExtData0 = 1144,
		Beyond-Gameplay-Factory-ConveyorCollectJob-Execute0 = 1145,
		Beyond-Gameplay-Factory-ConveyorCollectJob-_Collect0 = 1146,
		Beyond-Gameplay-Factory-ConveyorCollectJob-Execute1 = 1147,
		Beyond-Gameplay-Factory-ConveyorCollectJob-Execute2 = 1148,
		Beyond-Gameplay-Factory-ConveyorCollectJob-SetSharedExtData0 = 1149,
		Beyond-Gameplay-Factory-ConveyorFigureRendererJob-Execute0 = 1150,
		Beyond-Gameplay-Factory-ConveyorFigureRendererJob-SetSharedExtData0 = 1151,
		Beyond-Gameplay-Factory-ConveyorFigureRendererJob-ResolveAccess0 = 1152,
		Beyond-Gameplay-Factory-ConveyorInsideRenderJob-Execute0 = 1153,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-Execute0 = 1154,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-_Collect0 = 1155,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-Execute1 = 1156,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-SetSharedExtData0 = 1157,
		Beyond-Gameplay-Factory-ConveyorRendererJob-Execute0 = 1158,
		Beyond-Gameplay-Factory-ConveyorRendererJob-_HideConveyorOutOfDistance0 = 1159,
		Beyond-Gameplay-Factory-ConveyorRendererJob-_UpdateCachedConveyor0 = 1160,
		Beyond-Gameplay-Factory-ConveyorRendererJob-SetSharedExtData0 = 1161,
		Beyond-Gameplay-Factory-ConveyorRendererJob-ResolveAccess0 = 1162,
		Beyond-Gameplay-Factory-EnvGeneratorCollectJob-Execute0 = 1163,
		Beyond-Gameplay-Factory-EnvGeneratorCollectJob-_Collect0 = 1164,
		Beyond-Gameplay-Factory-EnvGeneratorCollectJob-Execute1 = 1165,
		Beyond-Gameplay-Factory-EnvGeneratorCollectJob-Execute2 = 1166,
		Beyond-Gameplay-Factory-EnvGeneratorCollectJob-SetSharedExtData0 = 1167,
		Beyond-Gameplay-Factory-EnvGeneratorRenderJob-Execute0 = 1168,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_SwapBuffer0 = 1169,
		Beyond-Gameplay-Factory-InteractFacCollectJob-Execute0 = 1170,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecuteBuilding0 = 1171,
		Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-IsPointInSector0 = 1173,
		Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-SetData0 = 1174,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecuteConveyor0 = 1175,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_CheckDist0 = 1176,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_SnapDirectionToAxis0 = 1177,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecutePipe0 = 1178,
		Beyond-Gameplay-Factory-InteractFacCollectJob-SetSharedExtData0 = 1179,
		Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-get_templateName0 = 1180,
		Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-set_templateName0 = 1181,
		Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-ToString0 = 1182,
		Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-IsPending0 = 1183,
		Beyond-Gameplay-Factory-InteractFacCollectJob-LogisticInfo-IsPending0 = 1184,
		Beyond-Gameplay-Factory-LocalToWorldJob-Execute0 = 1185,
		Beyond-Gameplay-Factory-LocalToWorldJob-TransTRS0 = 1186,
		Beyond-Gameplay-Factory-LocalToWorldJob-Execute1 = 1187,
		Beyond-Gameplay-Factory-LocalToWorldJob-SetHierarchyData0 = 1188,
		Beyond-Gameplay-Factory-LocalToWorldJob-SetQueryResult0 = 1189,
		Beyond-Gameplay-Factory-LocalToWorldJob-ScheduleDefer0 = 1190,
		Beyond-Gameplay-Factory-LocalToWorldQueryJob-Execute0 = 1191,
		Beyond-Gameplay-Factory-LocalToWorldQueryJob-SetQueryResult0 = 1192,
		Beyond-Gameplay-Factory-LogisticEffectJob-Execute0 = 1193,
		Beyond-Gameplay-Factory-LogisticsFigureRendererJob-Execute0 = 1194,
		Beyond-Gameplay-Factory-LogisticsFigureRendererJob-Execute1 = 1195,
		Beyond-Gameplay-Factory-LogisticsHideRendererJob-Execute0 = 1196,
		Beyond-Gameplay-Factory-LogisticsHideRendererJob-Execute1 = 1197,
		Beyond-Gameplay-Factory-LogisticsHideRendererJob-SetSharedExtData0 = 1198,
		Beyond-Gameplay-Factory-LookAtJob-Execute0 = 1199,
		Beyond-Gameplay-Factory-LookAtJob-SetHierarchyData0 = 1200,
		Beyond-Gameplay-Factory-LookAtJob-SetQueryResult0 = 1201,
		Beyond-Gameplay-Factory-LookAtJob-ScheduleDefer0 = 1202,
		Beyond-Gameplay-Factory-LookAtQueryJob-Execute0 = 1203,
		Beyond-Gameplay-Factory-LookAtQueryJob-SetQueryResult0 = 1204,
		Beyond-Gameplay-Factory-OutputCollectJob-Execute0 = 1205,
		Beyond-Gameplay-Factory-OutputCollectJob-_Collect0 = 1206,
		Beyond-Gameplay-Factory-OutputCollectJob-Execute1 = 1207,
		Beyond-Gameplay-Factory-OutputCollectJob-Execute2 = 1208,
		Beyond-Gameplay-Factory-OutputCollectJob-SetSharedExtData0 = 1209,
		Beyond-Gameplay-Factory-OutputRenderJob-Execute0 = 1210,
		Beyond-Gameplay-Factory-PedestalFlashJob-Execute0 = 1211,
		Beyond-Gameplay-Factory-PedestalFlashJob-_Flash0 = 1212,
		Beyond-Gameplay-Factory-PedestalFlashJob-Execute1 = 1213,
		Beyond-Gameplay-Factory-PedestalFlashJob-SetSharedExtData0 = 1214,
		Beyond-Gameplay-Factory-PipeCollectJob-get_pipeCount0 = 1215,
		Beyond-Gameplay-Factory-PipeCollectJob-Execute0 = 1216,
		Beyond-Gameplay-Factory-PipeCollectJob-_ExecutePipe0 = 1217,
		Beyond-Gameplay-Factory-PipeCollectJob-_CollectPipe0 = 1218,
		Beyond-Gameplay-Factory-PipeCollectJob-_CollectPipeCom0 = 1219,
		Beyond-Gameplay-Factory-PipeCollectJob-_ExecutePreviewPipe0 = 1220,
		Beyond-Gameplay-Factory-PipeCollectJob-_CollectTrack0 = 1221,
		Beyond-Gameplay-Factory-PipeCollectJob-Execute1 = 1222,
		Beyond-Gameplay-Factory-PipeCollectJob-Execute2 = 1223,
		Beyond-Gameplay-Factory-PipeCollectJob-SetGlobalEnvRef0 = 1224,
		Beyond-Gameplay-Factory-PipeCollectJob-SetSharedExtData0 = 1225,
		Beyond-Gameplay-Factory-PipeComRendererJob-Execute0 = 1226,
		Beyond-Gameplay-Factory-PipeFigureRendererJob-Execute0 = 1227,
		Beyond-Gameplay-Factory-PipeFigureRendererJob-_UpdateCachedPipe0 = 1228,
		Beyond-Gameplay-Factory-PipeFigureRendererJob-ResolveAccess0 = 1229,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute0 = 1230,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute1 = 1231,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-SetSharedExtData0 = 1232,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute2 = 1233,
		Beyond-Gameplay-Factory-PipeRendererJob-Execute0 = 1234,
		Beyond-Gameplay-Factory-PipeRendererJob-_HidePipeOutOfDistance0 = 1235,
		Beyond-Gameplay-Factory-PipeRendererJob-_UpdateCachedPipe0 = 1236,
		Beyond-Gameplay-Factory-PipeRendererJob-SetSharedExtData0 = 1237,
		Beyond-Gameplay-Factory-PipeRendererJob-ResolveAccess0 = 1238,
		Beyond-Gameplay-Factory-PipeTrackRendererJob-Execute0 = 1239,
		Beyond-Gameplay-Factory-PipeTrackRendererJob-_UpdateCachedTrack0 = 1240,
		Beyond-Gameplay-Factory-PipeWaterThicknessQueryJob-Execute0 = 1241,
		Beyond-Gameplay-Factory-PipeWaterThicknessQueryJob-SetQueryResult0 = 1242,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-Execute1 = 1243,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-Execute0 = 1244,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-SetGlobalEnv0 = 1245,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-SetQueryResult0 = 1246,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-ScheduleDefer0 = 1247,
		Beyond-Gameplay-Factory-PortArrowRenderJob-Execute0 = 1248,
		Beyond-Gameplay-Factory-PortStateCollectJob-Execute0 = 1249,
		Beyond-Gameplay-Factory-PortStateCollectJob-_Collect0 = 1250,
		Beyond-Gameplay-Factory-PortStateCollectJob-SetSharedExtData0 = 1251,
		Beyond-Gameplay-Factory-PortStateCollectJob-Execute1 = 1252,
		Beyond-Gameplay-Factory-PortStateCollectJob-Execute2 = 1253,
		Beyond-Gameplay-Factory-PortStateRendererJob-Execute0 = 1254,
		Beyond-Gameplay-Factory-PreviewUnitQueryJob-Execute0 = 1255,
		Beyond-Gameplay-Factory-PreviewUnitQueryJob-SetQueryResult0 = 1256,
		Beyond-Gameplay-Factory-PumpInEffectJob-Execute0 = 1257,
		Beyond-Gameplay-Factory-PumpInEffectJob-Execute1 = 1258,
		Beyond-Gameplay-Factory-PumpInEffectJob-SetQueryResult0 = 1259,
		Beyond-Gameplay-Factory-PumpInEffectJob-ScheduleDefer0 = 1260,
		Beyond-Gameplay-Factory-PumpInEffectJob-SetSharedExtData0 = 1261,
		Beyond-Gameplay-Factory-ResetHierarchyDirtyJob-Execute0 = 1262,
		Beyond-Gameplay-Factory-ResetHierarchyDirtyJob-SetHierarchyData0 = 1263,
		Beyond-Gameplay-Factory-StatusChangeJob-Execute0 = 1264,
		Beyond-Gameplay-Factory-UnitCullingJob-Execute1 = 1265,
		Beyond-Gameplay-Factory-UnitCullingJob-Execute0 = 1266,
		Beyond-Gameplay-Factory-UnitCullingJob-SetGlobalEnvRef0 = 1267,
		Beyond-Gameplay-Factory-UnitCullingJob-SetSharedExtData0 = 1268,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-Execute1 = 1269,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-Execute0 = 1270,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetGlobalEnvRef0 = 1271,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetSharedExtData0 = 1272,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetQueryResult0 = 1273,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-ScheduleDefer0 = 1274,
		Beyond-Gameplay-Factory-UnitRendererQueryJob-Execute0 = 1275,
		Beyond-Gameplay-Factory-UnitRendererQueryJob-SetQueryResult0 = 1276,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-Execute0 = 1277,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-Execute1 = 1278,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-SetSharedExtData0 = 1279,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-SetQueryResult0 = 1280,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-ScheduleDefer0 = 1281,
		Beyond-Gameplay-Factory-WireCollectJob-Execute0 = 1282,
		Beyond-Gameplay-Factory-WireCollectJob-Execute1 = 1283,
		Beyond-Gameplay-Factory-WireCollectJob-SetGlobalEnvRef0 = 1284,
		Beyond-Gameplay-Factory-WireCollectJob-SetSharedExtData0 = 1285,
		Beyond-Gameplay-Factory-WireRenderJob-Execute0 = 1286,
		Beyond-Gameplay-Factory-WireRenderJob-_UpdateCachedWire0 = 1287,
		Beyond-Gameplay-Factory-WireRenderJob-Execute1 = 1288,
		Beyond-Gameplay-Factory-FPtrNativeCurve-IsValid0 = 1289,
		Beyond-Gameplay-Factory-FPtrNativeCurve-CreateCurve0 = 1290,
		Beyond-Gameplay-Factory-FPtrNativeCurve-Evaluate0 = 1291,
		Beyond-Gameplay-Factory-StringIntern-FastId-get_isValid0 = 1292,
		Beyond-Gameplay-Factory-StringIntern-FastId-Equals0 = 1293,
		Beyond-Gameplay-Factory-StringIntern-FastId-Equals1 = 1294,
		Beyond-Gameplay-Factory-StringIntern-FastId-GetHashCode0 = 1295,
		Beyond-Gameplay-Factory-StringIntern-StringTable-GetOrAddIndex0 = 1296,
		Beyond-Gameplay-Factory-StringIntern-StringTable-TryGetIndex0 = 1297,
		Beyond-Gameplay-Factory-StringIntern-StringTable-IndexToString0 = 1298,
		Beyond-Gameplay-Factory-PerDrawPassConfig-get_lightMode0 = 1299,
		Beyond-Gameplay-Factory-PerDrawPassConfig-set_lightMode0 = 1300,
		Beyond-Gameplay-Factory-PerDrawPassConfig-Size0 = 1301,
		Beyond-Gameplay-Factory-PerDrawPassConfig-Apply0 = 1302,
		Beyond-Gameplay-Factory-PerDrawPassConfig-_ParseToHGShaderLightMode0 = 1303,
		Beyond-Gameplay-Factory-PerDrawPassConfig-Apply1 = 1304,
		Beyond-Gameplay-Factory-PerDrawConfig-Size0 = 1305,
		Beyond-Gameplay-Factory-PerDrawConfig-_OnColorChanged0 = 1306,
		Beyond-Gameplay-Factory-PerDrawConfig-_OnFloat4Changed0 = 1307,
		Beyond-Gameplay-Factory-PerDrawConfig-_OnFloatChanged0 = 1308,
		Beyond-Gameplay-Factory-PerDrawConfig-Apply0 = 1309,
		Beyond-Gameplay-Factory-ProcessorInterval-CheckInterval0 = 1310,
		Beyond-Gameplay-Factory-ProcessorInterval-_CheckInterval0 = 1311,
		Beyond-Gameplay-Factory-CargoPredictProcessor-Execute0 = 1312,
		Beyond-Gameplay-Factory-CargoPredictProcessor-get_lowFrameEnable0 = 1313,
		Beyond-Gameplay-Factory-CargoPredictProcessor-get_name0 = 1314,
		Beyond-Gameplay-Factory-CrossFrameProcessor-Initialize0 = 1315,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearBuildingPtr0 = 1316,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearConveyorPtr0 = 1317,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearPipePtr0 = 1318,
		Beyond-Gameplay-Factory-CrossFrameProcessor-LateExecute0 = 1319,
		Beyond-Gameplay-Factory-CrossFrameProcessor-TearDown0 = 1320,
		Beyond-Gameplay-Factory-CrossFrameProcessor-get_name0 = 1321,
		Beyond-Gameplay-Factory-CrossFrameProcessor-get_lowFrameEnable0 = 1322,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectConveyor0 = 1323,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPreviewConveyor0 = 1324,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectGuideConveyor0 = 1325,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectConveyorLogistics0 = 1326,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-get_name0 = 1327,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-Initialize0 = 1328,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetStateColor0 = 1329,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CreateCurrent0 = 1330,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CreateAllocator0 = 1331,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_InitArrowPlaced0 = 1332,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortState0 = 1333,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectBuildingState0 = 1334,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectCargo0 = 1335,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectWire0 = 1336,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-LateExecute0 = 1337,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPipe0 = 1338,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPipeLogistics0 = 1339,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortArrowWithDiff0 = 1340,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortArrow0 = 1341,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectOutput0 = 1342,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectEnvGenerator0 = 1343,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-TearDown0 = 1344,
		Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-GetColor0 = 1345,
		Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-GetIndex0 = 1346,
		Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-CreateOrGet0 = 1347,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetIndicatorColor0 = 1348,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetStateName0 = 1349,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetPerDrawList0 = 1350,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-LogicStateConfig-_OnColorChanged0 = 1351,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-get_def0 = 1352,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-GetCurrentStateDefinition0 = 1353,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-GetCurrentStateDefinitionUnsafe0 = 1354,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-GetCurrentClipDefinition0 = 1355,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-GetCurrentClipDefinitionUnsafe0 = 1356,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMStateDefinition-GetClipIndex0 = 1357,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetActiveClipSlotUnsafe0 = 1358,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Enter0 = 1359,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-Init0 = 1360,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetParametersByDef0 = 1361,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetFloat0 = 1362,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetInt0 = 1363,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetBool0 = 1364,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetAllTriggers0 = 1365,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetStateUnsafe0 = 1366,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Exit0 = 1367,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetState0 = 1368,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-ToNextState0 = 1369,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Exit0 = 1370,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetTransition0 = 1371,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Enter0 = 1372,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-get_id0 = 1373,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-__AOT_FOR_FIX__0 = 1374,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-get_process0 = 1375,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-get_isFinished0 = 1376,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Update0 = 1377,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-SetProgress0 = 1378,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-get_isFinished0 = 1379,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-get_fromStateWeight0 = 1380,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-get_toStateWeight0 = 1381,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Update0 = 1382,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetFloat0 = 1383,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetInt0 = 1384,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetBool0 = 1385,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetTrigger0 = 1386,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetTrigger0 = 1387,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetTrigger0 = 1388,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetValue0 = 1389,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetValue0 = 1390,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMSetParamRequestHandlerJob-Execute0 = 1391,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-Execute1 = 1392,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-Execute0 = 1393,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_CheckTransitions0 = 1394,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-TryGetValidTransition0 = 1395,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-_Evaluate0 = 1396,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-ResetUsedTriggers0 = 1397,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_ComputeVATFrameData0 = 1398,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-SetSharedExtData0 = 1399,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-get_name0 = 1400,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-Initialize0 = 1401,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-Initialize0 = 1402,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-Execute0 = 1403,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-_RemoveDuplicationRequest0 = 1404,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-_ResizeAnimatorAudioQueue0 = 1405,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-_HandleSetAnimatorParamRequest0 = 1406,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-TearDown0 = 1407,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-Dispose0 = 1408,
		Beyond-Gameplay-Factory-ECSVATFSM-AnimationClipData-GetClipDesStr0 = 1409,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMStateDefinition-SetClipIndex0 = 1410,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Size0 = 1411,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-AsSpan0 = 1412,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Reserve0 = 1413,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-get_Item1 = 1414,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Get0 = 1415,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Get1 = 1416,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-InitFSMDefinition0 = 1417,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-RegisterFSM0 = 1418,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-SyncFSMDefinition0 = 1419,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-_DisableFSM0 = 1420,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-GetStateName0 = 1421,
		Beyond-Gameplay-Factory-Util-JobHandlerExtensions-SafeComplete0 = 1422,
		Beyond-Gameplay-Factory-Unsafe-BuildingStateQueryRegistry-GetGroup0 = 1423,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_CANNON_10 = 1424,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_Ids0 = 1425,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_CANNON_1_DG0020 = 1426,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_CANNON_20 = 1427,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_DEBUFF_10 = 1428,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_FOG_10 = 1429,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_FROST_10 = 1430,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_JET_10 = 1431,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_LASER_10 = 1432,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_LASER_20 = 1433,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_LIGHTNING_10 = 1434,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_LIGHTNING_20 = 1435,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_MEDIC_10 = 1436,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_ROCKET_10 = 1437,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_SHOCKWAVE_10 = 1438,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_SNIPER_10 = 1439,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_TRAP_10 = 1440,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_TURRET_10 = 1441,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_TURRET_20 = 1442,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_BATTLE_TURRET_30 = 1443,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_POWER_STATION_10 = 1444,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_GAS_PUMP_10 = 1445,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_MINER_10 = 1446,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_MINER_20 = 1447,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_MINER_30 = 1448,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_MINER_40 = 1449,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_PUMP_10 = 1450,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_PUMP_20 = 1451,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_AIR_DANCER_10 = 1452,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_CAT_TREE_10 = 1453,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_CHUBBY_LUNG_BALLOON_10 = 1454,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_CHUBBY_LUNG_STONE_10 = 1455,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_DISPLAY_STAND_10 = 1456,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_JAIL_10 = 1457,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_MICROPHONE_10 = 1458,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_PEAR_BLOSSOM_BONSAI_10 = 1459,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_PHOTO_FRAME_10 = 1460,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SIGNBOARD_10 = 1461,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_CARRIER_10 = 1462,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_GAS_STORAGER_10 = 1463,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_LIQUID_STORAGER_10 = 1464,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_LIQUID_STORAGER_NOP_10 = 1465,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_DUMPER_10 = 1466,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_DUMPER_NOP_10 = 1467,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SQUIRTER_10 = 1468,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SQUIRTER_NOP_10 = 1469,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_LOG_HONGS_BUS0 = 1470,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_LOG_HONGS_BUS_SOURCE0 = 1471,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SP_HUB_10 = 1472,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SP_SUB_HUB_10 = 1473,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_LIQUID_CLEAN_GATE_10 = 1474,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_LIQUID_RECYCLE_GATE_10 = 1475,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_POWER_DIFFUSER_10 = 1476,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_POWER_DIFFUSER_20 = 1477,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_POWER_POLE_20 = 1478,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_POWER_POLE_30 = 1479,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_POWER_PORT_10 = 1480,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_POWER_TERMINAL_10 = 1481,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_TRAVEL_POLE_10 = 1482,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_TRAVEL_POLE_20 = 1483,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_TRAVEL_POLE_NOP_10 = 1484,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_COMPONENT_MC_10 = 1485,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_DISMANTLER_10 = 1486,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_FILLING_POWDER_MC_10 = 1487,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_FURNANCE_10 = 1488,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_GAS_REACTOR_10 = 1489,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_GRINDER_10 = 1490,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_LIQUID_CLEANER_10 = 1491,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_LIQUID_PURIFIER_10 = 1492,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_MIX_POOL_10 = 1493,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_MIX_POOL_20 = 1494,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_PLANTER_10 = 1495,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SEEDCOLLECTOR_10 = 1496,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SHAPER_10 = 1497,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_THICKENER_10 = 1498,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_TOOLS_ASSEBLING_MC_10 = 1499,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_WINDER_10 = 1500,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_XIRANITE_OVEN_10 = 1501,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_MARKER_10 = 1502,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_10 = 1503,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_20 = 1504,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_BBFLOWER_10 = 1505,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_GRASS_10 = 1506,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_GRASS_20 = 1507,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_GRASS_FAST_10 = 1508,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_GRASS_FAST_20 = 1509,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_MOSS_10 = 1510,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_MOSS_20 = 1511,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_MOSS_30 = 1512,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_SP_10 = 1513,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_SP_20 = 1514,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_SP_30 = 1515,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_SP_40 = 1516,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_SP_FAST_30 = 1517,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_SOIL_SP_FAST_40 = 1518,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_STORAGER_10 = 1519,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_STORAGER_NOP_10 = 1520,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_TRANSMUTER_10 = 1521,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_TRANSMUTER_20 = 1522,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_UDPIPE_LOADER_10 = 1523,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_UDPIPE_LOADER_20 = 1524,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_UDPIPE_UNLOADER_10 = 1525,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_UDPIPE_UNLOADER_20 = 1526,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_VAPORIZER_10 = 1527,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_LOADER_10 = 1528,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_UNLOADER_10 = 1529,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-EnsureInit0 = 1530,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_FURNANCE_NOP_10 = 1531,
		Beyond-Gameplay-Factory-Unsafe-BuildingTemplateIds-get_V_FLUID_CONTAINER_10 = 1532,
		Beyond-Gameplay-Factory-Unsafe-BurstBridge-BeginProfilerSample0 = 1533,
		Beyond-Gameplay-Factory-Unsafe-BurstBridge-EndProfilerSample0 = 1534,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-QueryBuildingStateIsClosed0 = 1535,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-_IsPowerBuilding0 = 1536,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-CulledWithLogicEntity0 = 1537,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-CulledWithRendererEntity0 = 1538,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetVisibility1 = 1539,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetVisibility0 = 1540,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibility0 = 1541,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibilityWithNotify0 = 1542,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-UpdatePipeEffect0 = 1543,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibility1 = 1544,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetInMainRegion0 = 1546,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-IsInMainRegionFuzzy0 = 1547,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingExtendConfig0 = 1548,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingStaticMountWorldTRS1 = 1549,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingStaticMountWorldTRS0 = 1550,
		Beyond-Gameplay-Factory-Unsafe-GameplayExtensions-GetChapterEntity0 = 1551,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetGlobalEnvPtr0 = 1552,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-IsGlobalEnvValid0 = 1553,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetGlobalEnvRef0 = 1554,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractFac0 = 1555,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractConveyor0 = 1556,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractPipe0 = 1557,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-_ExpandMemory0 = 1558,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-_MergeAdjacentFreeBlocks0 = 1560,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Allocate0 = 1561,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Reserve0 = 1568,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Expand0 = 1569,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Free0 = 1570,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Resize0 = 1571,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Dispose0 = 1572,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-PrintAllocations0 = 1573,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Initialize0 = 1574,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Dispose0 = 1576,
		Beyond-Gameplay-Factory-Unsafe-TLSFAllocator-GetFreeSpace0 = 1577,
		Beyond-Gameplay-Factory-Unsafe-TLSFAllocator-MappingInsert0 = 1578,
		Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-AllocManualNodeId0 = 1579,
		Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-AddressOf0 = 1580
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 49543
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 49544
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace UnityEngine.HyperGryph.ECS
{
	public static class ColliderComponentExtensions // TypeDefIndex: 49549
	{
		// Nested types
		[CompilerGenerated]
		private struct __c__DisplayClass0_0 // TypeDefIndex: 49548
		{
			// Fields
			public bool enable; // 0x00
		}
	
		// Methods
		[CompilerGenerated]
		internal static void _ToggleCollision_g__Toggle_0_0(Entity rendererEntity, ref EntityManager em, ref __c__DisplayClass0_0 param_0006b36a); // 0x00000001834A2D60-0x00000001834A2E20
		[CompilerGenerated]
		internal static void _UpdateCollisionTRS_g__UpdateTRS_2_0(Entity rendererEntity, [IsReadOnly] in EntityManager em); // 0x00000001834C7CF0-0x00000001834C7EB0
	
		// Extension methods
		public static void ToggleCollision(this Entity logicEntity, bool enable, ref EntityManager em); // 0x00000001834A63A0-0x00000001834A79D0
		public static void Toggle(this ref ECSColliderComponent collision, bool enable); // 0x0000000184212020-0x0000000184212050
		public static void UpdateCollisionTRS(this Entity logicEntity, [IsReadOnly] in EntityManager em); // 0x00000001834C9A10-0x00000001834CAFB0
		public static void UpdateCollisionTRS(this ECSColliderComponent c, float3 pos, quaternion rot); // 0x00000001834C7C00-0x00000001834C7CF0
		public static void DestroyCollisionWithRenderEntity(this Entity rEntity, ref EntityManager em); // 0x00000001834A2CD0-0x00000001834A2D60
		public static void DestroyCollision(this Entity logicEntity, ref EntityManager em); // 0x00000001869B662C-0x00000001869B6984
	}

	public static class ECSExtensions // TypeDefIndex: 49550
	{
		// Methods
		private static unsafe byte* _GetComponentPtrImpl(ref EntityInstanceData entityData, ref EntityTypeInstanceData entityTypeData, int componentId, int componentSize); // 0x00000001869B6FFC-0x00000001869B7090
		private static void _SetComponentImpl(ref EntityInstanceData entityData, ref EntityTypeInstanceData entityTypeData, int componentId, [IsReadOnly] in IntPtr component, int componentSize); // 0x00000001837AB7C0-0x00000001837AB8C0
	
		// Extension methods
		public static Entity GetEntity(this GroupType group, int index); // 0x00000001841ADAD0-0x00000001841ADAF0
		public static bool HasComponent([IsReadOnly] this in EntityManager entityManager, [IsReadOnly] in Entity entity, int componentId); // 0x000000018392D190-0x000000018392D1D0
		public static void CreateEntities([IsReadOnly] this in EntityManager em, NativeArray<ComponentType> archetypes, NativeArray<Entity> result); // 0x0000000183A25990-0x0000000183A259E0
		public static Entity CreateEntity([IsReadOnly] this in EntityManager entityManager); // 0x00000001869B6984-0x00000001869B69C4
		public static Entity CreateEntity([IsReadOnly] this in EntityManager entityManager, NativeArray<ComponentType> archetypes); // 0x00000001837AD200-0x00000001837AD2D0
		public static void Is<T>([IsReadOnly] this in EntityManager entityManager, Entity entity, bool flag)
			where T : struct, IComponentECS;
		public static void AddComponent<T>([IsReadOnly] this in EntityManager entityManager, Entity entity)
			where T : struct, IComponentECS;
		public static void AddComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId, [IsReadOnly] in IntPtr component, int componentSize); // 0x00000001837ABA30-0x00000001837ABBB0
		public static void AddOrSetComponent<T>([IsReadOnly] this in EntityManager entityManager, Entity entity, T t)
			where T : struct, IComponentECS;
		public static void AddOrSetComponent<T1, T2>([IsReadOnly] this in EntityManager entityManager, Entity entity, T1 t1, T2 t2)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public static void SetComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId, [IsReadOnly] in IntPtr component, int componentSize); // 0x00000001869B6FCC-0x00000001869B6FFC
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
		public static EntityManagerRange Iterate([IsReadOnly] this in EntityManager em, [IsReadOnly] in EntityQueryBuilder queryBuilder); // 0x00000001830C5D10-0x00000001830C5E50
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
		public static unsafe void GetComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId, int componentSize, void* componentPtr); // 0x00000001869B6BF4-0x00000001869B6CE4
		public static bool MoveComponent<T>([IsReadOnly] this in EntityManager entityManager, Entity src, Entity des)
			where T : struct, IComponentECS;
		public static void RemoveComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId); // 0x000000018392BE60-0x000000018392BEB0
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
		public static void DestroyEntitiesWithArchetype([IsReadOnly] this in EntityManager entityManager, ref ComponentMask entityMask); // 0x00000001869B69C4-0x00000001869B6BF4
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
		public static int GetEntityCount([IsReadOnly] this in EntityManager em, int compId); // 0x00000001869B6CE4-0x00000001869B6E58
		public static int GetEntityCount([IsReadOnly] this in EntityManager em, int compId0, int compId1); // 0x00000001869B6E58-0x00000001869B6FCC
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
		public static ComponentMask ComposeComponentMaskAll(this EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6); // 0x00000001830C4E10-0x00000001830C4EF0
		public static ComponentMask ComposeComponentMaskAll(this EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6, int id7); // 0x00000001830C4D10-0x00000001830C4E10
		public static ComponentMask ComposeComponentMaskAll(this EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6, int id7, int id8); // 0x0000000184D8CCF0-0x0000000184D8CE10
	}

	public static class HGFactoryRendererBinderExtensions // TypeDefIndex: 49551
	{
		// Extension methods
		public static void RenderWithTRS(this HGFactoryRendererBinderComponent binder, [IsReadOnly] in LocalToWorld localToWorld); // 0x00000001869B8DB8-0x00000001869B8F54
		public static void RenderWithTRS(this HGFactoryRendererBinderComponent binder, float4x4 value); // 0x00000001869B8F54-0x00000001869B90D8
		public static void EnableDither(this HGFactoryRendererBinderComponent binder, bool enable, float alphaValue, HGObjectFlags objectFlags); // 0x00000001869B8C44-0x00000001869B8CBC
		public static void EnableDither(this HGFactoryRendererBinderComponent binder, ref EntityManager rEntityManager, bool enable, float alphaValue, HGObjectFlags objectFlags); // 0x00000001869B8CBC-0x00000001869B8DB8
	}

	public struct PreResolvedComponentAccess<T0> // TypeDefIndex: 49552
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

	public struct PreResolvedComponentAccess<T0, T1> // TypeDefIndex: 49553
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

	public struct PreResolvedComponentAccess<T0, T1, T2> // TypeDefIndex: 49554
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

	public struct EntityCommandBuffer // TypeDefIndex: 49557
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
		public EntityManager entityManager { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184D8CE10-0x0000000184D8CE20 
	
		// Nested types
		public delegate void EntityCommandCallback(Entity entity, ref EntityManager entityManager, ref EntityCommandBufferData buffer); // TypeDefIndex: 49555; 0x0000000181546280-0x00000001815462A0
	
		public struct VirtualEntityMap // TypeDefIndex: 49556
		{
			// Fields
			public Entity virtualEntity; // 0x00
			public Entity realEntity; // 0x08
		}
	
		// Constructors
		public EntityCommandBuffer(ref EntityManager entityManager, Unity.Collections.Allocator allocator); // 0x000000018391F840-0x000000018391FA90
	
		// Methods
		public ValueTuple<bool, Entity> GetRealEntity(Entity virtualEntity); // 0x000000018392C340-0x000000018392C400
	}

	public static class EntityCommand // TypeDefIndex: 49558
	{
		// Methods
		private static unsafe void* _ComponentCpy<T>(T component)
			where T : struct, IComponentECS;
	
		// Extension methods
		public static EntityCommandBuffer CreateCommandBuffer(this EntityManager entityManager, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0232E9D6 */); // 0x000000018391F800-0x000000018391F840
		public static Entity CreateEntity(this EntityCommandBuffer ecb); // 0x00000001869B8068-0x00000001869B81F0
		public static void DestroyEntity(this EntityCommandBuffer ecb, Entity entity); // 0x00000001869B81F0-0x00000001869B8290
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
		public static void Playback(this EntityCommandBuffer ecb, bool autoDispose = true /* Metadata: 0x0232E9D7 */); // 0x000000018392BF80-0x000000018392C340
		public static void Dispose(this EntityCommandBuffer ecb); // 0x000000018392C400-0x000000018392C470
	}

	public class EntityCommandOp // TypeDefIndex: 49559
	{
		// Fields
		public static readonly int CREATE; // 0x00
		public static readonly int ADD; // 0x04
		public static readonly int REMOVE; // 0x08
		public static readonly int MODIFY; // 0x0C
		public static readonly int DESTROY; // 0x10
		public static readonly int QUERY; // 0x14
	
		// Constructors
		public EntityCommandOp(); // 0x00000001841E1670-0x00000001841E1680
		static EntityCommandOp(); // 0x0000000184D21170-0x0000000184D21220
	}

	public struct EntityCommandBufferData // TypeDefIndex: 49560
	{
		// Fields
		public int op; // 0x00
		public Entity entity; // 0x04
		public CommandBufferComponent componentData; // 0x10
	
		// Methods
		public void Free(); // 0x00000001869B7090-0x00000001869B70A4
	}

	public struct CommandBufferComponent // TypeDefIndex: 49561
	{
		// Fields
		public int componentId; // 0x00
		public int componentSize; // 0x04
		public unsafe void* component; // 0x08
	}

	[BurstCompile]
	public struct EntityCommandBufferV2 : INativeDisposable // TypeDefIndex: 49564
	{
		// Fields
		public static int s_mapSize; // 0x00
		[ReadOnly]
		public NativeQueue<EntityCommandBufferData> buffers; // 0x00
		[ReadOnly]
		public NativeParallelHashMap<ulong, VirtualEntityMap> tempEntities; // 0x18
	
		// Properties
		public bool isEmpty { get; } // 0x00000001869B74C4-0x00000001869B7500 
	
		// Nested types
		public struct VirtualEntityMap // TypeDefIndex: 49562
		{
			// Fields
			public Entity virtualEntity; // 0x00
			public Entity realEntity; // 0x08
		}
	
		public struct EntityCommandBufferParallelWriter // TypeDefIndex: 49563
		{
			// Fields
			public long tempIdx; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeQueue<EntityCommandBufferData> buffersWriter; // 0x08
			[NativeDisableParallelForRestriction]
			public NativeParallelHashMap<ulong, VirtualEntityMap> tempEntitiesWriter; // 0x20
		}
	
		// Constructors
		public EntityCommandBufferV2(Unity.Collections.Allocator allocator); // 0x00000001869B73D8-0x00000001869B74C4
		static EntityCommandBufferV2(); // 0x00000001869B739C-0x00000001869B73D8
	
		// Methods
		public ValueTuple<bool, Entity> GetRealEntity(Entity virtualEntity); // 0x00000001869B7288-0x00000001869B7344
		public void Reset(); // 0x00000001869B7344-0x00000001869B739C
		public void Dispose(); // 0x00000001869B721C-0x00000001869B7288
		public JobHandle Dispose(JobHandle dependsOn); // 0x00000001869B7150-0x00000001869B721C
		public EntityCommandBufferParallelWriter AsParallelWriter(); // 0x00000001869B70A4-0x00000001869B7150
	}

	public static class EntityCommandV2 // TypeDefIndex: 49565
	{
		// Fields
		private static readonly Queue<EntityCommandBufferV2> S_POOL; // 0x00
	
		// Constructors
		static EntityCommandV2(); // 0x00000001869B7FD4-0x00000001869B8068
	
		// Methods
		public static void DisposePool(); // 0x00000001869B7948-0x00000001869B7A4C
		public static void Recycle(ref EntityCommandBufferV2 buffer); // 0x00000001869B7F24-0x00000001869B7FD4
		private static unsafe T* _ComponentCpy<T>(T component)
			where T : struct, IComponentECS;
	
		// Extension methods
		public static EntityCommandBufferV2 CreateConcurrentCommandBufferV2(this EntityManager em); // 0x00000001869B7684-0x00000001869B7790
		public static Entity CreateEntity(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer); // 0x00000001869B7790-0x00000001869B78A8
		public static void DestroyEntity(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity); // 0x00000001869B78A8-0x00000001869B7948
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
		public static void Playback(this EntityCommandBufferV2 ecb, bool autoRecycle = true /* Metadata: 0x0232E9D8 */); // 0x00000001869B7A4C-0x00000001869B7F24
	}

	public struct ECSSpan<T> // TypeDefIndex: 49566
		where T : struct, IComponentECS
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe void* buffer;
		public int length;
	
		// Properties
		public ref T this[int index] { get => default; }
	}

	public struct EntityPool<T0, T1, T2> // TypeDefIndex: 49567
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
		public void Recycle(int count = 1 /* Metadata: 0x0232E9D9 */);
		public Entity Recycle(Entity entity);
		public static EntityPool<T0, T1, T2> Alloc(int count, Action<Entity, float3, float3, Matrix4x4, float4x4> onSpawn, Action<Entity, float4x4> onRecycle, Action<NativeArray<Entity>, int, float4x4> onAllocate, Action<NativeArray<Entity>, int, float4x4> onDeallocate = null, float4x4 customData = default, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232E9DA */, bool autoAllocate = true /* Metadata: 0x0232E9DB */);
		public void Free();
		private void _Resize();
		public static implicit operator NativeArray<Entity>(EntityPool<T0, T1, T2> pool);
		public NativeArray<Entity> AsReadOnly();
	}

	public class EntityHierarchyContainer // TypeDefIndex: 49570
	{
		// Fields
		public const int INVALID_INDEX = -1; // Metadata: 0x0232E9DC
		private HGArray<Node> m_nodes; // 0x10
	
		// Properties
		public ref EntityTransformData this[int index] { get => default; } // 0x0000000184D8CE30-0x0000000184D8CE40 
		public ref EntityTransformData this[uint index] { get => default; } // 0x0000000184D8CE20-0x0000000184D8CE30 
	
		// Nested types
		public struct EntityTransformData // TypeDefIndex: 49568
		{
			// Fields
			public uint next; // 0x00
			public LocalTransform localTrans; // 0x04
			public int parentIndex; // 0x24
			public bool dirty; // 0x28
		}
	
		internal struct Node // TypeDefIndex: 49569
		{
			// Fields
			public EntityTransformData value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public EntityHierarchyContainer(Unity.Collections.Allocator allocator); // 0x0000000184439740-0x00000001844397E0
	
		// Methods
		public void Dispose(); // 0x00000001869B8320-0x00000001869B835C
		public void FlushPendingFree(); // 0x00000001834FEF30-0x00000001834FEFB0
		public uint Size(); // 0x0000000184D86310-0x0000000184D86320
		public Span<EntityTransformData> AsSpan(); // 0x00000001869B8290-0x00000001869B8300
		public LocalTransform WorldTrans(uint handle); // 0x00000001869B84F4-0x00000001869B855C
		public LocalTransform WorldTrans(EntityTransformData transform); // 0x00000001869B83A4-0x00000001869B84F4
		public static unsafe LocalTransform WorldTrans(EntityTransformData transform, EntityTransformData* hierarchyContainer); // 0x00000001837B1E90-0x00000001837B1FD0
		public uint Create(ref EntityTransformData value); // 0x00000001837B2370-0x00000001837B23E0
		public void Destroy(uint handle); // 0x00000001869B8300-0x00000001869B8320
		public void Reset(); // 0x0000000184439260-0x00000001844392C0
		public void Reserve(uint newCapacity); // 0x00000001869B835C-0x00000001869B83A4
		public IntPtr Data(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		public ref EntityTransformData Get(uint handle); // 0x0000000184D8CE20-0x0000000184D8CE30
		public ref EntityTransformData Get(int handle); // 0x0000000184D8CE30-0x0000000184D8CE40
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct EntityQueryBuilder // TypeDefIndex: 49573
	{
		// Fields
		internal unsafe BuilderData* builderDataPtr; // 0x00
	
		// Nested types
		internal struct BuilderData // TypeDefIndex: 49572
		{
			// Fields
			internal UnsafeList<ComponentType> all; // 0x00
			internal UnsafeList<ComponentType> none; // 0x20
	
			// Nested types
			internal enum Type // TypeDefIndex: 49571
			{
				INCLUDE = 0,
				EXCLUDE = 1
			}
	
			// Methods
			public ComponentMask ComponentMask([IsReadOnly] in EntityManager em, Type type); // 0x00000001830C5E50-0x00000001830C6090
		}
	
		// Constructors
		public unsafe EntityQueryBuilder(int maxCount = 8 /* Metadata: 0x0232E9DD */); // 0x0000000183344E30-0x0000000183345120
	
		// Methods
		public static EntityQueryBuilder Create(int maxCount = 8 /* Metadata: 0x0232E9DE */); // 0x0000000183344B60-0x0000000183344E30
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
		public EntityManagerRange Build(ref EntityManager em); // 0x0000000185392128-0x0000000185392168
	}

	public static class EntityQueryV2 // TypeDefIndex: 49577
	{
		// Nested types
		public struct BlockRange // TypeDefIndex: 49574
		{
			// Fields
			public int beginGroupIdx; // 0x00
			public int endGroupIdx; // 0x04
			public int beginGroupElemBeginIdx; // 0x08
			public int endGroupElemEndIdx; // 0x0C
		}
	
		[NoAlias]
		public struct QueryResultDefer : IDisposable // TypeDefIndex: 49575
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public unsafe UnsafeList<GroupType>* groups; // 0x00
			[NativeDisableUnsafePtrRestriction]
			public unsafe UnsafeList<BlockRange>* blockRanges; // 0x08
			[NativeDisableUnsafePtrRestriction]
			private unsafe UnsafeList<int>* m_rangeCountStore; // 0x10
	
			// Properties
			public int rangeCount { get; set; } // 0x00000001869B97B8-0x00000001869B97D4 0x00000001830D3A30-0x00000001830D3A50
			public bool valid { get; } // 0x00000001869B97D4-0x00000001869B97EC 
			public unsafe int* rangeCountPtr { get; } // 0x00000001830D4550-0x00000001830D4570 
	
			// Methods
			public void InitList(Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232E9F6 */, int initialCapacity = 32 /* Metadata: 0x0232E9F7 */); // 0x00000001845F5F00-0x00000001845F6000
			public void ReleaseList(); // 0x00000001869B94F0-0x00000001869B95B8
			public void Reset(); // 0x00000001830D3A00-0x00000001830D3A30
			public ref BlockRange BlockRangeAt(int index); // 0x00000001869B90D8-0x00000001869B9120
			public ref GroupType GroupAt(int index); // 0x00000001869B94AC-0x00000001869B94F0
			public void Foreach(Func<GroupType, bool> callback); // 0x00000001869B93CC-0x00000001869B94AC
			public int EntityCount(); // 0x00000001869B92F0-0x00000001869B93CC
			public void Dispose(); // 0x00000001869B9120-0x00000001869B9144
			public void Dispose(JobHandle jobHandle, bool inCrossFrame = false /* Metadata: 0x0232E9F8 */); // 0x00000001869B9144-0x00000001869B92F0
			public override string ToString(); // 0x00000001869B95B8-0x00000001869B97B8
		}
	
		[NoAlias]
		public struct QueryResult : IDisposable // TypeDefIndex: 49576
		{
			// Fields
			[ReadOnly]
			public NativeList<GroupType> groups; // 0x00
			[ReadOnly]
			public NativeList<BlockRange> blockRanges; // 0x10
	
			// Properties
			public int rangeCount { get; } // 0x0000000185393E04-0x0000000185393E14 
			public bool isEmpty { get; } // 0x00000001869B9E8C-0x00000001869B9EA4 
	
			// Methods
			public override string ToString(); // 0x00000001869B9C54-0x00000001869B9E8C
			public void Foreach(Func<GroupType, bool> callback); // 0x00000001869B9ADC-0x00000001869B9C54
			public int EntityCount(); // 0x00000001838AE730-0x00000001838AE8F0
			public void Dispose(); // 0x00000001869B9AB8-0x00000001869B9ADC
			public void Dispose(JobHandle jobHandle, bool inCrossFrame = false /* Metadata: 0x0232E9F9 */); // 0x0000000183343630-0x0000000183343A10
		}
	
		// Extension methods
		public static QueryResult Query(this EntityManager em, ref EntityQueryBuilder builder, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0232E9E1 */, int jobCount = -1 /* Metadata: 0x0232E9E2 */); // 0x0000000183344810-0x0000000183344AC0
		public static ref QueryResultDefer QueryDefer(this EntityManager em, ref EntityQueryBuilder builder, ref QueryResultDefer qrd, int jobCount = -1 /* Metadata: 0x0232E9E3 */); // 0x00000001869B88B4-0x00000001869B89B4
		public static QueryResult Query<T>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0232E9E4 */, int jobCount = -1 /* Metadata: 0x0232E9E5 */)
			where T : struct, IComponentECS;
		public static QueryResult Query<T0, T1>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0232E9E6 */, int jobCount = -1 /* Metadata: 0x0232E9E7 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0232E9E8 */, int jobCount = -1 /* Metadata: 0x0232E9E9 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0232E9EA */, int jobCount = -1 /* Metadata: 0x0232E9EB */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3, T4>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0232E9EC */, int jobCount = -1 /* Metadata: 0x0232E9ED */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0232E9EE */, int jobCount = -1 /* Metadata: 0x0232E9EF */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0232E9F0 */, int jobCount = -1 /* Metadata: 0x0232E9F1 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6, T7>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0232E9F2 */, int jobCount = -1 /* Metadata: 0x0232E9F3 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x0232E9F4 */, int jobCount = -1 /* Metadata: 0x0232E9F5 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS
			where T8 : struct, IComponentECS;
		public static QueryResultDefer GetBlockRangesDefer(this EntityManagerRange range, int jobCount, ref QueryResultDefer qr); // 0x00000001869B855C-0x00000001869B88B4
		public static QueryResult GetBlockRanges(this EntityManagerRange range, Unity.Collections.Allocator allocator, int jobCount); // 0x0000000183346770-0x0000000183347780
	}

	[BurstCompile]
	public static class QueryResultWrapper // TypeDefIndex: 49580
	{
		// Nested types
		public unsafe delegate void Wrapper_000000E7_PostfixBurstDelegate(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount); // TypeDefIndex: 49578; 0x00000001815547C0-0x00000001815547E0
	
		internal static class Wrapper_000000E7_BurstDirectCall // TypeDefIndex: 49579
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Wrapper_000000E7_BurstDirectCall(); // 0x0000000183FB2B50-0x0000000183FB2B60
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006b4ff); // 0x000000018307B940-0x000000018307BA90
			private static IntPtr GetFunctionPointer(); // 0x000000018307B730-0x000000018307B8D0
			public static void Constructor(); // 0x0000000183FB17C0-0x0000000183FB1850
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount); // 0x000000018307B600-0x000000018307B730
		}
	
		// Methods
		[BurstCompile]
		public static unsafe void Wrapper(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount); // 0x000000018307B4B0-0x000000018307B600
		[BurstCompile]
		public static unsafe void Wrapper_BurstManaged(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount); // 0x00000001869B97EC-0x00000001869B9AB8
	}
}
