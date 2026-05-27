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
using Beyond.PoolCore;
using Beyond.SourceGenerator;
using Beyond.SparkBuffer.Runtime.Wrapper;
using FactoryUIAtlas;
using IFix.Core;
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

// Image 16: FactoryUnsafe.Gameplay.Beyond.dll - Assembly: FactoryUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 48500-49128
[assembly: BurstCompiler.StaticTypeReinit(typeof(Beyond.Gameplay.Factory.Unsafe.EntityExtensions._SetRenderEntityFlashStatue_00000A51_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(QueryResultWrapper.Wrapper_000000D7_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnsafeJobFuncPointers.ApplyPerDrawRender_0000085C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnsafeJobFuncPointers.GetQueryStateIconPath_0000085E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnsafeJobFuncPointers.GetLogicEntityWithPos_00000860_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnsafeJobFuncPointers.QueryBuildingStateFunc_00000862_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnsafeJobFuncPointers.SetEntityFlashStatueFunc_00000864_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectJob._BuildDismissState_00000882_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectJob._Repair0_00000884_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildStart_0000088E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._FigureStart_000008A0_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildProcess_0000088F_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildEnd_00000890_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildCutoffStateStart_00000891_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildCutoffStateEnd_00000892_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BPBuildCutoffStateProcess_00000893_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._CutoffStateStart_00000897_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._CutoffStateEnd_00000898_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._CutoffStateProcess_00000899_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BuildStateProcess_0000089C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HighLightStart_0000089D_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HighLightEnd_0000089E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HighLightProcess_0000089F_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectJob._Repair1_00000885_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._FigureProcess_000008A1_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BlueprintStart_000008B5_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HintProcess_000008A5_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadStart_000008A6_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadEnd_000008A7_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadProcess_000008A8_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadInvalidStart_000008A9_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadInvalidEnd_000008AA_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._OverloadInvalidProcess_000008AB_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._Repair0Process_000008AE_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._Repair1Start_000008AF_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._Repair1End_000008B0_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._Repair1Process_000008B1_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BlueprintProcessInternal_000008B3_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._BlueprintEnd_000008B4_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HintEnd_000008A4_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._PreSelectStart_000008B6_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._PreSelectEnd_000008B7_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._PreSelectProcess_000008B8_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._ContinuationStart_000008B9_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._ContinuationEnd_000008BA_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._ContinuationProcess_000008BB_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._SocialSharingStart_000008BC_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._PowerInteractionStart_000008BD_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._PowerInteractionEnd_000008BE_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(BurstBridge.SamplePredictCargo_00000A4A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(Beyond.Gameplay.Factory.Unsafe.EntityExtensions.QueryBuildingState_00000A4E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(Beyond.Gameplay.Factory.Unsafe.EntityExtensions.SetFlashStatue_00000A50_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._HintStart_000008A3_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AdditiveEffectRenderJob._FigureEnd_000008A2_BurstDirectCall))]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3364214955 // TypeDefIndex: 49123
{
	// Constructors
	public __JobReflectionRegistrationOutput__3364214955() {} // Dummy constructor

	// Methods
	public static void CreateJobReflectionData() {} // 0x0000000181138FB0-0x000000018113E6C0
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit() {} // 0x000000018113E6C0-0x000000018113E6D0
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 49124
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize() {} // 0x00000001837FF630-0x00000001837FFD50
}

namespace Beyond
{
	public struct FixedStack<T> : IDisposable // TypeDefIndex: 48536
		where T : struct
	{
		// Fields
		private unsafe T* m_items;
		private readonly int m_capacity;
		private int m_size;
		private bool m_disposed;
	
		// Properties
		public int count { [IsReadOnly] get => default; }
		public int capacity { [IsReadOnly] get => default; }
		public bool isEmpty { [IsReadOnly] get => default; }
		public bool isFull { [IsReadOnly] get => default; }
	
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
		[IsReadOnly]
		public T Peek() => default;
		public void Clear() {}
		public void Dispose() {}
	}

	public struct HGArray<T> // TypeDefIndex: 48537
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

	public static class AssetInstanceParseUtil // TypeDefIndex: 48538
	{
		// Methods
		[IDTag(1)]
		public static NativeArray<int> Parse(UnityEngine.Object[] objects) => default; // 0x000000018578D3FC-0x000000018578D4EC
		[IDTag(0)]
		public static int Parse(UnityEngine.Object obj) => default; // 0x000000018578D4EC-0x000000018578D580
		public static object Get(int id) => default; // 0x00000001831148C0-0x0000000183114920
		public static T Get<T>(int id) => default;
	}
}

namespace Beyond.Gameplay
{
	[CreateAssetMenu(fileName = "FactorySetting", menuName = "Beyond/Gameplay/FactorySetting")]
	public class FactorySetting : ScriptableObject // TypeDefIndex: 48545
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
		[HideInInspector]
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
		[Range(0.001f, 1f)]
		public float buildingDither; // 0x160
		[Range(0.001f, 1f)]
		public float pedestalDither; // 0x164
		[Unit(Units.Meter)]
		public float ditherTargetField; // 0x168
		[Unit(Units.Meter)]
		public float ditherDistance; // 0x16C
		[Range(0f, 1f)]
		public float lowFrameRate; // 0x170
	
		// Constructors
		public FactorySetting() {} // 0x0000000183D3A980-0x0000000183D3A9D0
	
		// Methods
		private void OnEnable() {} // 0x00000001832BB410-0x00000001832BB450
	}

	[Serializable]
	public struct FactoryEffectSetting // TypeDefIndex: 48546
	{
		// Fields
		public int maxEffectCount; // 0x00
		public float effectInterval; // 0x04
	}
}

namespace Beyond.Gameplay.Factory
{
	public static class Archetypes // TypeDefIndex: 48547
	{
		// Properties
		public static NativeArray<ComponentType> empty { get; } // 0x000000018241BE40-0x000000018241C8B0 
		public static NativeArray<ComponentType> env { get; } // 0x0000000182AE47C0-0x0000000182AE48E0 
		public static NativeArray<ComponentType> connection { get; } // 0x00000001827D0A00-0x00000001827D0B20 
		public static NativeArray<ComponentType> buildingUnit { get; } // 0x000000018241D130-0x000000018241D6F0 
		public static NativeArray<ComponentType> powerStation { get; } // 0x0000000182D02A80-0x0000000182D02B60 
		public static NativeArray<ComponentType> furnace { get; } // 0x0000000182D049D0-0x0000000182D04B00 
		public static NativeArray<ComponentType> grinder { get; } // 0x0000000182D04C00-0x0000000182D04D30 
		public static NativeArray<ComponentType> winder { get; } // 0x0000000182D06190-0x0000000182D062B0 
		public static NativeArray<ComponentType> componentMc { get; } // 0x0000000182D05310-0x0000000182D05440 
		public static NativeArray<ComponentType> shaper { get; } // 0x0000000182D051E0-0x0000000182D05310 
		public static NativeArray<ComponentType> fillingPowderMc { get; } // 0x0000000182D056A0-0x0000000182D057D0 
		public static NativeArray<ComponentType> thickener { get; } // 0x0000000182D04770-0x0000000182D048A0 
		public static NativeArray<ComponentType> hub { get; } // 0x0000000182D027B0-0x0000000182D02840 
		public static NativeArray<ComponentType> subHub { get; } // 0x0000000182D02960-0x0000000182D029F0 
		public static NativeArray<ComponentType> miner { get; } // 0x0000000182D04B00-0x0000000182D04C00 
		public static NativeArray<ComponentType> toolsAssemblingMc { get; } // 0x0000000182D05570-0x0000000182D056A0 
		public static NativeArray<ComponentType> seedCollector { get; } // 0x0000000182D02F80-0x0000000182D030B0 
		public static NativeArray<ComponentType> planter { get; } // 0x0000000182D048A0-0x0000000182D049D0 
		public static NativeArray<ComponentType> powerDiffuser { get; } // 0x0000000182D04210-0x0000000182D042A0 
		public static NativeArray<ComponentType> powerPole { get; } // 0x0000000182D03140-0x0000000182D031D0 
		public static NativeArray<ComponentType> travelPole { get; } // 0x0000000182D030B0-0x0000000182D03140 
		public static NativeArray<ComponentType> loader { get; } // 0x0000000182D02840-0x0000000182D028D0 
		public static NativeArray<ComponentType> unloader { get; } // 0x0000000182D04690-0x0000000182D04770 
		public static NativeArray<ComponentType> storage { get; } // 0x0000000182D02D60-0x0000000182D02DF0 
		public static NativeArray<ComponentType> powerTerminal { get; } // 0x000000018578D268-0x000000018578D314 
		public static NativeArray<ComponentType> powerPort { get; } // 0x0000000182D02BF0-0x0000000182D02C80 
		public static NativeArray<ComponentType> facBattle { get; } // 0x0000000182D04D30-0x0000000182D04E10 
		public static NativeArray<ComponentType> pump { get; } // 0x0000000182D02E80-0x0000000182D02F80 
		public static NativeArray<ComponentType> liquidStorage { get; } // 0x0000000182D062B0-0x0000000182D06380 
		public static NativeArray<ComponentType> mixPool { get; } // 0x0000000182D050B0-0x0000000182D051E0 
		public static NativeArray<ComponentType> squirter { get; } // 0x000000018578D314-0x000000018578D3FC 
		public static NativeArray<ComponentType> dumper { get; } // 0x0000000182D057D0-0x0000000182D058D0 
		public static NativeArray<ComponentType> liquidCleaner { get; } // 0x0000000182D02B60-0x0000000182D02BF0 
		public static NativeArray<ComponentType> xiraniteOven { get; } // 0x0000000182D05440-0x0000000182D05570 
		public static NativeArray<ComponentType> liquidPurifier { get; } // 0x0000000182D05A20-0x0000000182D05B70 
		public static NativeArray<ComponentType> dismantler { get; } // 0x000000018578CE18-0x000000018578CF48 
		public static NativeArray<ComponentType> hsBus { get; } // 0x0000000182D02C80-0x0000000182D02D60 
		public static NativeArray<ComponentType> hsBusSource { get; } // 0x0000000182D028D0-0x0000000182D02960 
		public static NativeArray<ComponentType> udPipeLoader { get; } // 0x0000000182D04E10-0x0000000182D04F60 
		public static NativeArray<ComponentType> udPipeUnloader { get; } // 0x0000000182D04F60-0x0000000182D050B0 
		public static NativeArray<ComponentType> liquidCleanGate { get; } // 0x000000018578CF48-0x000000018578D030 
		public static NativeArray<ComponentType> liquidRecycleGate { get; } // 0x000000018578D030-0x000000018578D118 
		public static NativeArray<ComponentType> carrier { get; } // 0x0000000182D029F0-0x0000000182D02A80 
		public static NativeArray<ComponentType> marker { get; } // 0x0000000182D02DF0-0x0000000182D02E80 
		public static NativeArray<ComponentType> decoration { get; } // 0x000000018578CAF8-0x000000018578CE18 
		public static NativeArray<ComponentType> pipeConditioner { get; } // 0x0000000182D058D0-0x0000000182D05A20 
		public static NativeArray<ComponentType> logConditioner { get; } // 0x000000018578D118-0x000000018578D268 
		public static NativeArray<ComponentType> buildingFakeUnit { get; } // 0x0000000182D06380-0x0000000182D06710 
		public static NativeArray<ComponentType> buildingRenderOnlyUnit { get; } // 0x0000000182EB09E0-0x0000000182EB0CB0 
		public static NativeArray<ComponentType> buildingPreviewUnit { get; } // 0x0000000182EAFED0-0x0000000182EB0200 
		public static NativeArray<ComponentType> buildingGuideHintUnit { get; } // 0x0000000182EB06E0-0x0000000182EB09E0 
		public static NativeArray<ComponentType> conveyor { get; } // 0x0000000182768D50-0x0000000182768FF0 
		public static NativeArray<ComponentType> guideConveyor { get; } // 0x000000018398B3E0-0x000000018398B650 
		public static NativeArray<ComponentType> pipe { get; } // 0x0000000182C5E200-0x0000000182C5E9B0 
		public static NativeArray<ComponentType> pipeHolder { get; } // 0x0000000182D05E90-0x0000000182D06190 
		public static NativeArray<ComponentType> cargo { get; } // 0x000000018241CBB0-0x000000018241D130 
		public static NativeArray<ComponentType> buildingRender { get; } // 0x0000000182767720-0x0000000182767AB0 
		public static NativeArray<ComponentType> pedestalRender { get; } // 0x0000000182768FF0-0x0000000182769350 
		public static NativeArray<ComponentType> conveyorLeftRender { get; } // 0x0000000182C5D2B0-0x0000000182C5D4C0 
		public static NativeArray<ComponentType> conveyorRightRender { get; } // 0x0000000182C5CEC0-0x0000000182C5D0D0 
		public static NativeArray<ComponentType> conveyorMidRender { get; } // 0x0000000182C5DDE0-0x0000000182C5DFF0 
		public static NativeArray<ComponentType> figurePipeHolderRender { get; } // 0x000000018365A400-0x000000018365A5E0 
		public static NativeArray<ComponentType> figureLeftRender { get; } // 0x000000018365A5E0-0x000000018365A7C0 
		public static NativeArray<ComponentType> figureRightRender { get; } // 0x000000018365A7C0-0x000000018365A9A0 
		public static NativeArray<ComponentType> figureMidRender { get; } // 0x000000018365A9A0-0x000000018365AB80 
		public static NativeArray<ComponentType> conveyorPreviewRender { get; } // 0x00000001837F78C0-0x00000001837F7AA0 
		public static NativeArray<ComponentType> pipePreviewRender { get; } // 0x00000001838755D0-0x0000000183875780 
		public static NativeArray<ComponentType> pipeComRender { get; } // 0x0000000182C5D6A0-0x0000000182C5D830 
		public static NativeArray<ComponentType> pipeLeftRender { get; } // 0x0000000182C5CAA0-0x0000000182C5CCB0 
		public static NativeArray<ComponentType> pipeMidRender { get; } // 0x0000000182C5DFF0-0x0000000182C5E200 
		public static NativeArray<ComponentType> pipeRightRender { get; } // 0x0000000182C5CCB0-0x0000000182C5CEC0 
		public static NativeArray<ComponentType> pipeTrackLeftPreviewRender { get; } // 0x0000000182C5BF60-0x0000000182C5C140 
		public static NativeArray<ComponentType> pipeTrackMidPreviewRender { get; } // 0x0000000182C5C140-0x0000000182C5C320 
		public static NativeArray<ComponentType> pipeTrackRightPreviewRender { get; } // 0x0000000182C5C320-0x0000000182C5C500 
		public static NativeArray<ComponentType> outputUIRenderer { get; } // 0x000000018388E780-0x000000018388E900 
		public static NativeArray<ComponentType> wireRenderer { get; } // 0x0000000182C5EDE0-0x0000000182C5EF70 
		public static NativeArray<ComponentType> unitStatusUIRenderer { get; } // 0x000000018388EAD0-0x000000018388EC50 
		public static NativeArray<ComponentType> portPreviewUIRenderer { get; } // 0x00000001836F9360-0x00000001836F94F0 
		public static NativeArray<ComponentType> gridRenderer { get; } // 0x00000001837AFEB0-0x00000001837B0090 
		public static NativeArray<ComponentType> gridMainRegionRenderer { get; } // 0x00000001837B0090-0x00000001837B0270 
		public static NativeArray<ComponentType> portStatusUIRenderer { get; } // 0x000000018388EE10-0x000000018388EF90 
		public static NativeArray<ComponentType> scope { get; } // 0x0000000182D07070-0x0000000182D07190 
	
		// Methods
		public static NativeArray<ComponentType> CreateArchetype(NativeArray<ComponentType> baseArchetype, params ComponentType[] extraTypes) => default; // 0x0000000182D042A0-0x0000000182D04460
		public static NativeArray<ComponentType> Select(string templateId) => default; // 0x0000000182D031D0-0x0000000182D041B0
	}

	[DataN(capacity = 16, tSize = 4, ring = false)]
	[NoAlias]
	public struct AdditiveEffectRequestStack<T> : IEnumerable<T> // TypeDefIndex: 48550
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x01FBB8D5
		public const int CAPACITY = 16; // Metadata: 0x01FBB8D6
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x01FBB8D7
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB8D8
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48548
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
			public Enumerator([IsReadOnly] in AdditiveEffectRequestStack<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe AdditiveEffectRequestStack(int initialCapacity = 16 /* Metadata: 0x01FBB8D3 */, bool autoExtend = false /* Metadata: 0x01FBB8D4 */) : this() {
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

	public struct ConveyorExtContainer // TypeDefIndex: 48553
	{
		// Fields
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref ConveyorExt this[int index] { get => default; } // 0x000000018578DBC0-0x000000018578DC04 
		public ref ConveyorExt this[uint index] { get => default; } // 0x00000001823F8B70-0x00000001823F8BC0 
	
		// Nested types
		public struct ConveyorExt // TypeDefIndex: 48551
		{
			// Fields
			public int outCargoIndex; // 0x00
			public int cargoBeginIndex; // 0x04
			public int cargoEndIndex; // 0x08
	
			// Methods
			public void Reset() {} // 0x0000000182BC1160-0x0000000182BC1190
		}
	
		internal struct Node // TypeDefIndex: 48552
		{
			// Fields
			public ConveyorExt value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public ConveyorExtContainer(Unity.Collections.Allocator allocator) : this() {
			m_nodes = default;
		} // 0x0000000182C34C80-0x0000000182C34D20
	
		// Methods
		public void Dispose() {} // 0x000000018578DA14-0x000000018578DA7C
		public uint Size() => default; // 0x000000018578DB5C-0x000000018578DBC0
		public Span<ConveyorExt> AsSpan() => default; // 0x000000018578D8D8-0x000000018578D988
		public uint Create(ref ConveyorExt value) => default; // 0x0000000182A8F6B0-0x0000000182A8F760
		public void Destroy(uint handle) {} // 0x000000018578D988-0x000000018578DA14
		public void Reset() {} // 0x0000000182C34B70-0x0000000182C34BE0
		public void Reserve(uint newCapacity) {} // 0x000000018578DADC-0x000000018578DB5C
		public IntPtr Data() => default; // 0x00000001826DE950-0x00000001826DE9E0
		public ref ConveyorExt Get(uint handle) => ref _refReturnTypeForGet; // 0x000000018578DA7C-0x000000018578DADC
		private ref ConveyorExt _refReturnTypeForGet; // Dummy field
	}

	public struct ConveyorInfoAllocator // TypeDefIndex: 48555
	{
		// Fields
		private LinearAllocatorUnmanaged m_allocator; // 0x00
	
		// Properties
		public unsafe void* memoryPtr { get => default; } // 0x000000018578DCE0-0x000000018578DCEC 
	
		// Nested types
		public struct Info // TypeDefIndex: 48554
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
		public static unsafe ConveyorInfoAllocator* Create(int capacity) => default; // 0x0000000183281030-0x00000001832810E0
		public static unsafe void Destroy(ConveyorInfoAllocator* allocator) {} // 0x000000018578DC54-0x000000018578DC80
		public LinearAllocator.Allocation Allocate(int count) => default; // 0x0000000182A8E070-0x0000000182A8E0E0
		public LinearAllocator.Allocation Resize(LinearAllocator.Allocation allocation, int newCount) => default; // 0x00000001839B16D0-0x00000001839B1750
		public void Free(uint memoryOffset) {} // 0x000000018578DC80-0x000000018578DCE0
		public long CalculateSize(uint memoryOffset) => default; // 0x0000000182A90290-0x0000000182A902E0
		public unsafe Info* GetInfo(long offset) => default; // 0x000000018427032C-0x0000000184270334
		public void DebugPrint() {} // 0x000000018578DC04-0x000000018578DC54
	}

	public struct Data2<T> // TypeDefIndex: 48556
		where T : struct
	{
		// Fields
		public T port0;
		public T port1;
	
		// Properties
		public int length { get => default; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data4<T> // TypeDefIndex: 48557
		where T : struct
	{
		// Fields
		public Data2<T> port0;
		public Data2<T> port1;
	
		// Properties
		public int length { get => default; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data8<T> // TypeDefIndex: 48558
		where T : struct
	{
		// Fields
		public Data4<T> port0;
		public Data4<T> port1;
	
		// Properties
		public int length { get => default; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data16<T> // TypeDefIndex: 48559
		where T : struct
	{
		// Fields
		public Data8<T> port0;
		public Data8<T> port1;
	
		// Properties
		public int length { get => default; }
		public T this[int idx] { get => default; set {} }
	}

	public struct Data32<T> // TypeDefIndex: 48560
		where T : struct
	{
		// Fields
		public Data16<T> port0;
		public Data16<T> port1;
	
		// Properties
		public int length { get => default; }
		public T this[int idx] { get => default; set {} }
	}

	[DataN(capacity = 4, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData4<T> : IEnumerable<T> // TypeDefIndex: 48563
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x01FBB8DB
		public const int CAPACITY = 4; // Metadata: 0x01FBB8DC
		public const int CAPACITY_MINUS_ONE = 3; // Metadata: 0x01FBB8DD
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB8DE
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48561
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
			public Enumerator([IsReadOnly] in EntityData4<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe EntityData4(int initialCapacity = 4 /* Metadata: 0x01FBB8D9 */, bool autoExtend = false /* Metadata: 0x01FBB8DA */) : this() {
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

	[DataN(capacity = 8, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData8<T> : IEnumerable<T> // TypeDefIndex: 48566
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x01FBB8E1
		public const int CAPACITY = 8; // Metadata: 0x01FBB8E2
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x01FBB8E3
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB8E4
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48564
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
			public Enumerator([IsReadOnly] in EntityData8<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe EntityData8(int initialCapacity = 8 /* Metadata: 0x01FBB8DF */, bool autoExtend = false /* Metadata: 0x01FBB8E0 */) : this() {
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

	[DataN(capacity = 32, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData32<T> : IEnumerable<T> // TypeDefIndex: 48569
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x01FBB8E7
		public const int CAPACITY = 32; // Metadata: 0x01FBB8E8
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x01FBB8E9
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB8EA
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48567
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
			public Enumerator([IsReadOnly] in EntityData32<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe EntityData32(int initialCapacity = 32 /* Metadata: 0x01FBB8E5 */, bool autoExtend = false /* Metadata: 0x01FBB8E6 */) : this() {
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

	[DataN(capacity = 64, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData64<T> : IEnumerable<T> // TypeDefIndex: 48572
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x01FBB8EE
		public const int CAPACITY = 64; // Metadata: 0x01FBB8EF
		public const int CAPACITY_MINUS_ONE = 63; // Metadata: 0x01FBB8F1
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB8F2
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48570
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
			public Enumerator([IsReadOnly] in EntityData64<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe EntityData64(int initialCapacity = 64 /* Metadata: 0x01FBB8EB */, bool autoExtend = false /* Metadata: 0x01FBB8ED */) : this() {
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

	[DataN(capacity = 128, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData128<T> : IEnumerable<T> // TypeDefIndex: 48575
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x01FBB8F6
		public const int CAPACITY = 128; // Metadata: 0x01FBB8F7
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x01FBB8F9
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB8FB
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48573
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
			public Enumerator([IsReadOnly] in EntityData128<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe EntityData128(int initialCapacity = 128 /* Metadata: 0x01FBB8F3 */, bool autoExtend = false /* Metadata: 0x01FBB8F5 */) : this() {
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

	[DataN(capacity = 256, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData256<T> : IEnumerable<T> // TypeDefIndex: 48578
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x01FBB8FF
		public const int CAPACITY = 256; // Metadata: 0x01FBB900
		public const int CAPACITY_MINUS_ONE = 255; // Metadata: 0x01FBB902
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB904
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48576
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
			public Enumerator([IsReadOnly] in EntityData256<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe EntityData256(int initialCapacity = 256 /* Metadata: 0x01FBB8FC */, bool autoExtend = false /* Metadata: 0x01FBB8FE */) : this() {
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

	[DataN(capacity = 512, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData512<T> : IEnumerable<T> // TypeDefIndex: 48581
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x01FBB908
		public const int CAPACITY = 512; // Metadata: 0x01FBB909
		public const int CAPACITY_MINUS_ONE = 511; // Metadata: 0x01FBB90B
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB90D
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48579
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
			public Enumerator([IsReadOnly] in EntityData512<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe EntityData512(int initialCapacity = 512 /* Metadata: 0x01FBB905 */, bool autoExtend = false /* Metadata: 0x01FBB907 */) : this() {
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

	[DataN(capacity = 1024, tSize = 8, ring = true)]
	[NoAlias]
	public struct EntityData1024<T> : IEnumerable<T> // TypeDefIndex: 48584
		where T : struct
	{
		// Fields
		public const int T_SIZE = 8; // Metadata: 0x01FBB911
		public const int CAPACITY = 1024; // Metadata: 0x01FBB912
		public const int CAPACITY_MINUS_ONE = 1023; // Metadata: 0x01FBB914
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB916
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48582
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
			public Enumerator([IsReadOnly] in EntityData1024<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe EntityData1024(int initialCapacity = 1024 /* Metadata: 0x01FBB90E */, bool autoExtend = false /* Metadata: 0x01FBB910 */) : this() {
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

	[DataN(capacity = 6, tSize = 16, ring = false)]
	[NoAlias]
	public struct Float4Data6<T> : IEnumerable<T> // TypeDefIndex: 48587
		where T : struct
	{
		// Fields
		public const int T_SIZE = 16; // Metadata: 0x01FBB919
		public const int CAPACITY = 8; // Metadata: 0x01FBB91A
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x01FBB91B
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB91C
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48585
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
			public Enumerator([IsReadOnly] in Float4Data6<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe Float4Data6(int initialCapacity = 8 /* Metadata: 0x01FBB917 */, bool autoExtend = false /* Metadata: 0x01FBB918 */) : this() {
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

	[DataN(capacity = 16, tSize = 16, ring = false)]
	[NoAlias]
	public struct Float4Data16<T> : IEnumerable<T> // TypeDefIndex: 48590
		where T : struct
	{
		// Fields
		public const int T_SIZE = 16; // Metadata: 0x01FBB91F
		public const int CAPACITY = 16; // Metadata: 0x01FBB920
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x01FBB921
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB922
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48588
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
			public Enumerator([IsReadOnly] in Float4Data16<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe Float4Data16(int initialCapacity = 16 /* Metadata: 0x01FBB91D */, bool autoExtend = false /* Metadata: 0x01FBB91E */) : this() {
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

	[DataN(capacity = 8, tSize = 4, ring = false)]
	[NoAlias]
	public struct IntData8<T> : IEnumerable<T> // TypeDefIndex: 48593
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x01FBB925
		public const int CAPACITY = 8; // Metadata: 0x01FBB926
		public const int CAPACITY_MINUS_ONE = 7; // Metadata: 0x01FBB927
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB928
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48591
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
			public Enumerator([IsReadOnly] in IntData8<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe IntData8(int initialCapacity = 8 /* Metadata: 0x01FBB923 */, bool autoExtend = false /* Metadata: 0x01FBB924 */) : this() {
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

	[DataN(capacity = 32, tSize = 4, ring = false)]
	[NoAlias]
	public struct IntData32<T> : IEnumerable<T> // TypeDefIndex: 48596
		where T : struct
	{
		// Fields
		public const int T_SIZE = 4; // Metadata: 0x01FBB92B
		public const int CAPACITY = 32; // Metadata: 0x01FBB92C
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x01FBB92D
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB92E
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48594
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
			public Enumerator([IsReadOnly] in IntData32<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe IntData32(int initialCapacity = 32 /* Metadata: 0x01FBB929 */, bool autoExtend = false /* Metadata: 0x01FBB92A */) : this() {
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

	public struct LogisticsExtContainer // TypeDefIndex: 48598
	{
		// Nested types
		public struct LogisticsExtData // TypeDefIndex: 48597
		{
		}
	}

	public struct OutputRendererInfo // TypeDefIndex: 48599
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
	public struct PortData16<T> : IEnumerable<T> // TypeDefIndex: 48602
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x01FBB931
		public const int CAPACITY = 16; // Metadata: 0x01FBB933
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x01FBB934
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB935
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48600
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
			public Enumerator([IsReadOnly] in PortData16<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe PortData16(int initialCapacity = 16 /* Metadata: 0x01FBB92F */, bool autoExtend = false /* Metadata: 0x01FBB930 */) : this() {
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

	[DataN(capacity = 32, tSize = 64, ring = false)]
	[NoAlias]
	public struct PortData32<T> : IEnumerable<T> // TypeDefIndex: 48605
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x01FBB938
		public const int CAPACITY = 32; // Metadata: 0x01FBB93A
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x01FBB93B
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB93C
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48603
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
			public Enumerator([IsReadOnly] in PortData32<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe PortData32(int initialCapacity = 32 /* Metadata: 0x01FBB936 */, bool autoExtend = false /* Metadata: 0x01FBB937 */) : this() {
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

	[DataN(capacity = 128, tSize = 64, ring = false)]
	[NoAlias]
	public struct PortData128<T> : IEnumerable<T> // TypeDefIndex: 48608
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x01FBB940
		public const int CAPACITY = 128; // Metadata: 0x01FBB942
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x01FBB944
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB946
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48606
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
			public Enumerator([IsReadOnly] in PortData128<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe PortData128(int initialCapacity = 128 /* Metadata: 0x01FBB93D */, bool autoExtend = false /* Metadata: 0x01FBB93F */) : this() {
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

	[DataN(capacity = 256, tSize = 64, ring = false)]
	[NoAlias]
	public struct PortData256<T> : IEnumerable<T> // TypeDefIndex: 48611
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x01FBB94A
		public const int CAPACITY = 256; // Metadata: 0x01FBB94C
		public const int CAPACITY_MINUS_ONE = 255; // Metadata: 0x01FBB94E
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB950
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48609
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
			public Enumerator([IsReadOnly] in PortData256<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe PortData256(int initialCapacity = 256 /* Metadata: 0x01FBB947 */, bool autoExtend = false /* Metadata: 0x01FBB949 */) : this() {
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

	public struct SharedDataContainer // TypeDefIndex: 48615
	{
		// Fields
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref SharedExtData this[int index] { get => default; } // 0x00000001857908D4-0x0000000185790918 
		public ref SharedExtData this[uint index] { get => default; } // 0x00000001824FD630-0x00000001824FD680 
	
		// Nested types
		public struct SharedExtData // TypeDefIndex: 48612
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
			public bool inMainRegion; // 0xD10
	
			// Properties
			public bool visible { get => default; } // 0x00000001824FBB30-0x00000001824FBD00 
			public bool visibleAdditiveMat { get => default; } // 0x0000000182429770-0x00000001824297D0 
	
			// Methods
			public bool IsDirty(DirtyFlag f) => default; // 0x0000000185790918-0x0000000185790978
			public void SetDirty(DirtyFlag f, bool d) {} // 0x0000000185790978-0x0000000185790A00
			public bool IsPendingUnit() => default; // 0x00000001828BD8F0-0x00000001828BD970
		}
	
		[Flags]
		public enum DirtyFlag // TypeDefIndex: 48613
		{
			NONE = 0,
			STATUS_CHANGE = 1,
			VAT_UPDATE = 2,
			UPDATE_STATUS_EFFECT = 4,
			CULL_STATUS_CHANGE = 8,
			ALL = 255
		}
	
		internal struct Node // TypeDefIndex: 48614
		{
			// Fields
			public SharedExtData value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public SharedDataContainer(Unity.Collections.Allocator allocator) : this() {
			m_nodes = default;
		} // 0x0000000182C34BE0-0x0000000182C34C80
	
		// Methods
		public void Dispose() {} // 0x0000000185790720-0x0000000185790788
		public uint Size() => default; // 0x0000000185790870-0x00000001857908D4
		public Span<SharedExtData> AsSpan() => default; // 0x0000000185790670-0x0000000185790720
		public uint Create(ref SharedExtData value) => default; // 0x0000000182755A20-0x0000000182755BD0
		public void Destroy(uint handle) {} // 0x0000000183854130-0x00000001838541A0
		public void Reset() {} // 0x0000000182C34B00-0x0000000182C34B70
		public void Reserve(uint newCapacity) {} // 0x00000001857907EC-0x0000000185790870
		public IntPtr Data() => default; // 0x00000001826E4790-0x00000001826E4830
		public ref SharedExtData Get(uint handle) => ref _refReturnTypeForGet; // 0x0000000185790788-0x00000001857907EC
		private ref SharedExtData _refReturnTypeForGet; // Dummy field
	}

	public struct StaticMountInfo // TypeDefIndex: 48616
	{
		// Fields
		public Entity rendererEntity; // 0x00
		public FactoryUnitExtendConfig mountConfig; // 0x08
	}

	[DataN(capacity = 16, tSize = 80, ring = false)]
	[NoAlias]
	public struct StaticMountInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 48619
		where T : struct
	{
		// Fields
		public const int T_SIZE = 80; // Metadata: 0x01FBB95A
		public const int CAPACITY = 16; // Metadata: 0x01FBB95C
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x01FBB95D
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB95E
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48617
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
			public Enumerator([IsReadOnly] in StaticMountInfoCollection<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe StaticMountInfoCollection(int initialCapacity = 16 /* Metadata: 0x01FBB958 */, bool autoExtend = false /* Metadata: 0x01FBB959 */) : this() {
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

	[DataN(capacity = 12, tSize = 128, ring = false)]
	[NoAlias]
	public struct UnitExtendConfig12<T> : IEnumerable<T> // TypeDefIndex: 48622
		where T : struct
	{
		// Fields
		public const int T_SIZE = 128; // Metadata: 0x01FBB961
		public const int CAPACITY = 16; // Metadata: 0x01FBB963
		public const int CAPACITY_MINUS_ONE = 15; // Metadata: 0x01FBB964
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB965
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48620
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
			public Enumerator([IsReadOnly] in UnitExtendConfig12<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe UnitExtendConfig12(int initialCapacity = 16 /* Metadata: 0x01FBB95F */, bool autoExtend = false /* Metadata: 0x01FBB960 */) : this() {
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

	public struct WireRendererInfo // TypeDefIndex: 48623
	{
		// Fields
		public float3 fromPos; // 0x00
		public float3 toPos; // 0x0C
		public ulong connectionId; // 0x18
		public float alpha; // 0x20
	
		// Properties
		public float3 pos { get => default; } // 0x0000000185790A00-0x0000000185790AC8 
		public quaternion rot { get => default; } // 0x0000000185790AC8-0x0000000185790C04 
		public float scale { get => default; } // 0x0000000185790C04-0x0000000185790C40 
	}

	[DataN(capacity = 512, tSize = 48, ring = false)]
	[NoAlias]
	public struct WireRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 48626
		where T : struct
	{
		// Fields
		public const int T_SIZE = 48; // Metadata: 0x01FBB969
		public const int CAPACITY = 512; // Metadata: 0x01FBB96A
		public const int CAPACITY_MINUS_ONE = 511; // Metadata: 0x01FBB96C
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB96E
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48624
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
			public Enumerator([IsReadOnly] in WireRendererInfoCollection<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe WireRendererInfoCollection(int initialCapacity = 512 /* Metadata: 0x01FBB966 */, bool autoExtend = false /* Metadata: 0x01FBB968 */) : this() {
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

	public class EntitySearcher // TypeDefIndex: 48627
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private NativeParallelHashMap<UnitId, Entity> m_logicEntityMap; // 0x10
	
		// Constructors
		public EntitySearcher() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public NativeParallelHashMap<UnitId, Entity> GetLogicEntityMap() => default; // 0x000000018578F04C-0x000000018578F0B4
		public void RegisterLogicEntity(int chapterId, uint nodeId, Entity entity) {} // 0x00000001830EB410-0x00000001830EB5F0
		public bool UnregisterLogicEntity(int chapterId, uint nodeId) => default; // 0x000000018399FC10-0x000000018399FCB0
		public bool GetLogicEntity(int chapterId, uint nodeId, out Entity entity) {
			entity = default;
			return default;
		} // 0x00000001824FC8E0-0x00000001824FCD80
		private void _DestroyAllEntities() {} // 0x000000018578F0B4-0x000000018578F168
		public void DestroyAll() {} // 0x000000018578EFFC-0x000000018578F04C
	}

	public static class MiscExtensions // TypeDefIndex: 48628
	{
		// Extension methods
		public static void SafeDispose<T>(this NativeList<T> list)
			where T : struct {}
		public static void SafeDispose<T>(this NativeArray<T> array)
			where T : struct {}
		public static void SafeDispose<T>(this NativeQueue<T> queue)
			where T : struct {}
		public static void SafeDispose<T>(this UnsafeList<T> list)
			where T : struct {}
		public static void SafeDispose<TKey, TValue>(this NativeParallelHashMap<TKey, TValue> list)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct {}
		public static void SafeDispose<TKey, TValue>(this UnsafeParallelHashMap<TKey, TValue> list)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct {}
	}

	public static class FactoryProfilerMakers // TypeDefIndex: 48629
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
		static FactoryProfilerMakers() {} // 0x000000018380A1F0-0x000000018380A6F0
	}

	public static class FactorySharedDataManager // TypeDefIndex: 48630
	{
		// Fields
		private static ConveyorExtContainer s_conveyorExtData; // 0x00
		private static SharedDataContainer s_sharedData; // 0x18
		private static EntityHierarchyContainer s_hierarchy; // 0x30
		private static VATFSMDefinitionContainer s_vatFsm; // 0x38
	
		// Methods
		public static void InitExtData() {} // 0x0000000182C34620-0x0000000182C34790
		public static void ResetExtData() {} // 0x0000000182C34790-0x0000000182C34840
		public static void ReleaseExtData() {} // 0x000000018578F410-0x000000018578F4CC
		public static uint CreateConveyorExtHandle() => default; // 0x0000000182A8DF80-0x0000000182A8DFF0
		public static void DestroyConveyorExtHandle(uint handle) {} // 0x000000018578F314-0x000000018578F390
		public static ref ConveyorExtContainer.ConveyorExt GetConveyorExt(uint handle) => ref _refReturnTypeForGetConveyorExt; // 0x00000001823F8A80-0x00000001823F8B70
		private ref ConveyorExtContainer.ConveyorExt _refReturnTypeForGetConveyorExt; // Dummy field
		public static IntPtr GetConveyorExtData() => default; // 0x00000001826DE8A0-0x00000001826DE950
		public static uint CreateSharedData(bool adjustMapValid = true /* Metadata: 0x01FBB96F */) => default; // 0x0000000182755910-0x0000000182755A20
		[IDTag(0)]
		public static ref SharedDataContainer.SharedExtData GetSharedData(uint handle) => ref _refReturnTypeForGetSharedData; // 0x00000001824FD550-0x00000001824FD630
		private ref SharedDataContainer.SharedExtData _refReturnTypeForGetSharedData; // Dummy field
		public static void DestroySharedData(uint handle) {} // 0x00000001838540C0-0x0000000183854130
		[IDTag(1)]
		public static IntPtr GetSharedData() => default; // 0x00000001826E4640-0x00000001826E4790
		public static uint CreateTransHierarchy() => default; // 0x0000000182765460-0x0000000182765500
		[IDTag(0)]
		public static ref EntityHierarchyContainer.EntityTransformData GetHierarchyData(uint handle) => ref _refReturnTypeForGetHierarchyData; // 0x0000000182769FE0-0x000000018276A0D0
		private ref EntityHierarchyContainer.EntityTransformData _refReturnTypeForGetHierarchyData; // Dummy field
		[IDTag(1)]
		public static ref EntityHierarchyContainer.EntityTransformData GetHierarchyData(int handle) => ref _refReturnTypeForGetHierarchyData; // 0x0000000182767640-0x00000001827676D0
		private ref EntityHierarchyContainer.EntityTransformData _refReturnTypeForGetHierarchyData; // Dummy field
		public static float4x4 WorldTrans([IsReadOnly] in EntityHierarchyContainer.EntityTransformData transform) => default; // 0x000000018578F4CC-0x000000018578F5F0
		public static void DestroyHierarchyData(uint handle) {} // 0x0000000182AADB20-0x0000000182AADB90
		[IDTag(2)]
		public static IntPtr GetHierarchyData() => default; // 0x00000001826E0B00-0x00000001826E0BE0
		public static uint CreateVATFSMDefinitionContainer(ref VATFSMDefinition definition) => default; // 0x0000000182C349B0-0x0000000182C34A20
		[IDTag(0)]
		public static ref VATFSMDefinition GetVATFSMDefinition(uint handle) => ref _refReturnTypeForGetVATFSMDefinition; // 0x00000001831A8A30-0x00000001831A8AB0
		private ref VATFSMDefinition _refReturnTypeForGetVATFSMDefinition; // Dummy field
		public static void DestroyVATFSMDefinition(uint handle) {} // 0x000000018578F390-0x000000018578F410
		[IDTag(1)]
		public static IntPtr GetVATFSMDefinition() => default; // 0x00000001827DA610-0x00000001827DA760
	}

	public struct AdditiveEffectFragment // TypeDefIndex: 48633
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
		public AdditiveEffectType curEffectType { get => default; set {} } // 0x0000000183D55980-0x0000000183D55990 0x0000000183D55990-0x0000000183D559B0
	
		// Nested types
		public struct Request // TypeDefIndex: 48631
		{
			// Fields
			public AdditiveEffectType type; // 0x00
			public short typeValue; // 0x00
			public AdditiveEffectType lastType; // 0x02
			public short lastTypeValue; // 0x02
		}
	
		public enum AdditiveEffectType : short // TypeDefIndex: 48632
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
		public void PushState(AdditiveEffectType state) {} // 0x0000000182CBAB50-0x0000000182CBAC10
		public void InsertState(int index, AdditiveEffectType state) {} // 0x0000000182CB9D20-0x0000000182CB9E30
		public AdditiveEffectType ShiftState() => default; // 0x0000000185790EB0-0x0000000185790F3C
		public AdditiveEffectType PopState() => default; // 0x0000000185790E08-0x0000000185790EB0
		public AdditiveEffectType PeekState() => default; // 0x0000000182CBA770-0x0000000182CBA7D0
		public void DisableState(AdditiveEffectType state) {} // 0x0000000182CBA690-0x0000000182CBA770
		private void _Shrink() {} // 0x0000000182CBAC10-0x0000000182CBADE0
		[BurstDiscard]
		public override string ToString() => default; // 0x0000000185790F3C-0x0000000185791080
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185791080-0x00000001857910E0
	}

	public struct CutoffState // TypeDefIndex: 48634
	{
		// Fields
		private bool m_enable; // 0x00
		public uint mode; // 0x04
		public float cutOffY; // 0x08
	
		// Properties
		public bool enable { [IsReadOnly] get; private set; } // 0x0000000183D516E0-0x0000000183D516F0 0x0000000183D51700-0x0000000183D51710
	
		// Methods
		public void SetEnable(bool v) {} // 0x00000001857946C8-0x0000000185794720
		public void SetCutoffY(float v) {} // 0x000000018579465C-0x00000001857946C8
		public void SetMode(uint v) {} // 0x0000000185794720-0x0000000185794778
	}

	public struct BuildDismissState // TypeDefIndex: 48636
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
		public enum BuildEffectType : byte // TypeDefIndex: 48635
		{
			DEFAULT = 0,
			TYPE1 = 1
		}
	
		// Methods
		public void SetEnable(bool v) {} // 0x0000000185791AA0-0x0000000185791AF8
	}

	public struct RepairState // TypeDefIndex: 48637
	{
		// Fields
		public bool enable; // 0x00
		public RepairState0 state0; // 0x08
		public RepairState1 state1; // 0x18
	}

	public struct RepairState0 // TypeDefIndex: 48638
	{
		// Fields
		public bool enable; // 0x00
		public float duration; // 0x04
		public long startTms; // 0x08
	}

	public struct RepairState1 // TypeDefIndex: 48639
	{
		// Fields
		public bool enable; // 0x00
		public float duration; // 0x04
		public long startTms; // 0x08
	}

	public struct HighLightState // TypeDefIndex: 48640
	{
		// Fields
		public bool enable; // 0x00
		public bool invalid; // 0x01
		public bool social; // 0x02
		public FixedList128Bytes<byte> indexList; // 0x04
		public DitherState ditherState; // 0x84
	
		// Methods
		public void SetEnable(bool isEnable) {} // 0x00000001837F7B20-0x00000001837F7B60
		public void SetData(bool isInvalid, bool isSocial) {} // 0x0000000182CBA620-0x0000000182CBA690
		public LogicEntityState GetEffectType() => default; // 0x00000001857983B8-0x000000018579841C
		public bool IsHighlight(byte index) => default; // 0x00000001857984FC-0x00000001857985AC
		public void HighlightWithSubIndex(byte index, bool en) {} // 0x000000018579841C-0x00000001857984FC
		public void ClearHighlightableIndexList() {} // 0x0000000182CBA5C0-0x0000000182CBA620
	}

	public struct HintState // TypeDefIndex: 48641
	{
		// Fields
		public bool enable; // 0x00
		public bool showSelf; // 0x01
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x00000001857985AC-0x0000000185798604
	}

	public struct FigureState // TypeDefIndex: 48642
	{
		// Fields
		public bool valid; // 0x00
		public bool enable; // 0x01
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x0000000185795C50-0x0000000185795CA8
	}

	public struct OverloadState // TypeDefIndex: 48643
	{
		// Fields
		public bool enable; // 0x00
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x000000018579961C-0x0000000185799674
	}

	public struct OverloadInvalidState // TypeDefIndex: 48644
	{
		// Fields
		public bool enable; // 0x00
		public DitherState ditherState; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x00000001857995C4-0x000000018579961C
	}

	public struct DitherState // TypeDefIndex: 48645
	{
		// Fields
		public bool enable; // 0x00
		public float ditherVal; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x0000000185794884-0x00000001857948DC
	}

	public struct BlueprintState // TypeDefIndex: 48647
	{
		// Fields
		public bool enable; // 0x00
		public EffectType effectType; // 0x01
		public FixedList512Bytes<byte> indexList; // 0x02
		public CutoffState cutoffState; // 0x204
		public BuildDismissState buildState; // 0x218
	
		// Nested types
		public enum EffectType : byte // TypeDefIndex: 48646
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
		public void SetEnable(bool v) {} // 0x0000000182422A20-0x0000000182422A60
		[IDTag(1)]
		public void SetEnable(bool v, EffectType type) {} // 0x00000001824229D0-0x0000000182422A20
		public bool IsLighten(byte index) => default; // 0x00000001857919F0-0x0000000185791AA0
		public void LightenWithSubIndex(byte index, bool en) {} // 0x000000018361E700-0x000000018361E7B0
		public void ClearLightenIndexList() {} // 0x0000000182422650-0x00000001824226B0
	}

	public struct PreSelectState // TypeDefIndex: 48648
	{
		// Fields
		public bool enable; // 0x00
		public FixedList512Bytes<byte> indexList; // 0x02
	
		// Methods
		public void SetEnable(bool v) {} // 0x00000001837F7AE0-0x00000001837F7B20
		public bool IsLighten(byte index) => default; // 0x000000018579AD30-0x000000018579ADE0
		public void LightenWithSubIndex(byte index, bool en) {} // 0x000000018579ADE0-0x000000018579AEC0
		public void ClearLightenIndexList() {} // 0x000000018579ACBC-0x000000018579AD30
	}

	public struct SoloSelectState // TypeDefIndex: 48649
	{
		// Fields
		public bool enable; // 0x00
		public int selectedIndex; // 0x04
	
		// Methods
		public void SetEnable(bool v) {} // 0x000000018579B3A8-0x000000018579B400
		public bool IsLighten(int index) => default; // 0x000000018579B348-0x000000018579B3A8
	}

	public struct ContinuationState // TypeDefIndex: 48650
	{
		// Fields
		public bool enable; // 0x00
		public FixedList512Bytes<byte> indexList; // 0x02
	
		// Methods
		public void SetEnable(bool v) {} // 0x00000001837F7AA0-0x00000001837F7AE0
		public bool IsLighten(byte index) => default; // 0x0000000185793830-0x00000001857938E0
		public void LightenWithSubIndex(byte index, bool en) {} // 0x00000001857938E0-0x00000001857939C0
		public void ClearLightenIndexList() {} // 0x00000001857937BC-0x0000000185793830
	}

	public struct SocialSharingState // TypeDefIndex: 48651
	{
		// Fields
		public bool enable; // 0x00
	
		// Methods
		public void SetEnable(bool v) {} // 0x000000018579B2F0-0x000000018579B348
	}

	public struct PowerInteractionState // TypeDefIndex: 48652
	{
		// Fields
		public bool enable; // 0x00
	
		// Methods
		public void SetEnable(bool v) {} // 0x000000018579AC64-0x000000018579ACBC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct AdditiveEffectRendererFragment : IComponentECS // TypeDefIndex: 48653
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
		public const int ID = 1; // Metadata: 0x01FBB998
	
		// Properties
		public bool buildDismissEnabled { get => default; set {} } // 0x0000000183D559E0-0x0000000183D559F0 0x00000001857912D8-0x00000001857912E4
		public bool blueprintBuildEnabled { get => default; set {} } // 0x0000000183D559C0-0x0000000183D559D0 0x00000001857912C0-0x00000001857912CC
		public bool blueprintBuildCutoffYEnabled { get => default; set {} } // 0x0000000183D559B0-0x0000000183D559C0 0x00000001857912B4-0x00000001857912C0
		public bool cutOffYIgnored { get => default; set {} } // 0x0000000183D55A00-0x0000000183D55A10 0x00000001857912F0-0x00000001857912FC
		public bool cutoffYEnabled { get => default; set {} } // 0x0000000183D55A10-0x0000000183D55A20 0x00000001857912FC-0x0000000185791308
		public bool highLightEnabled { get => default; set {} } // 0x0000000183D55A30-0x0000000183D55A40 0x0000000185791314-0x0000000185791320
		public bool figureEnabled { get => default; set {} } // 0x0000000183D55A20-0x0000000183D55A30 0x0000000185791308-0x0000000185791314
		public bool hintEnabled { get => default; set {} } // 0x0000000183D557D0-0x0000000183D557E0 0x0000000185791320-0x000000018579132C
		public bool overloadEnabled { get => default; set {} } // 0x0000000183D55A40-0x0000000183D55A50 0x000000018579132C-0x0000000185791338
		public bool overloadInvalidEnabled { get => default; set {} } // 0x0000000183D55A50-0x0000000183D55A60 0x0000000185791338-0x0000000185791344
		public bool repair0Enabled { get => default; set {} } // 0x0000000183D55A70-0x0000000183D55A80 0x000000018579135C-0x0000000185791368
		public bool repair1Enabled { get => default; set {} } // 0x0000000183D516E0-0x0000000183D516F0 0x0000000185791368-0x0000000185791374
		public bool blueprintEnabled { get => default; set {} } // 0x0000000183D559D0-0x0000000183D559E0 0x00000001857912CC-0x00000001857912D8
		public bool preSelectEnabled { get => default; set {} } // 0x0000000183D55A60-0x0000000183D55A70 0x0000000185791350-0x000000018579135C
		public bool continuationEnabled { get => default; set {} } // 0x0000000183D559F0-0x0000000183D55A00 0x00000001857912E4-0x00000001857912F0
		public bool socialSharingEnabled { get => default; set {} } // 0x00000001811797F0-0x0000000181179800 0x0000000185791374-0x0000000185791380
		public bool powerInteractionEnabled { get => default; set {} } // 0x0000000183D510E0-0x0000000183D510F0 0x0000000185791344-0x0000000185791350
		public bool anyEffect { get => default; } // 0x0000000185791200-0x00000001857912B4 
		public int id { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857910E0-0x0000000185791200
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BattleFragment : IComponentECS // TypeDefIndex: 48654
	{
		// Fields
		public bool overload; // 0x00
		public float currentEnergy; // 0x04
		public float maxEnergy; // 0x08
		public const int ID = 2; // Metadata: 0x01FBB999
	
		// Properties
		public int id { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579149C-0x00000001857915B8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BindRenderEntityFragment : IComponentECS // TypeDefIndex: 48655
	{
		// Fields
		public EntityData512<Entity> renderEntities; // 0x00
		public const int ID = 3; // Metadata: 0x01FBB99A
	
		// Properties
		public int id { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
	
		// Methods
		public void BindRenderEntity(Entity renderEntity) {} // 0x0000000182429600-0x0000000182429680
		[IDTag(0)]
		public void BindRenderEntities(Entity[] renderEntityList) {} // 0x00000001857915B8-0x0000000185791648
		[IDTag(1)]
		public void BindRenderEntities(NativeArray<Entity> renderEntityList) {} // 0x0000000185791648-0x000000018579179C
		public void UnbindRenderEntity(Entity renderEntity) {} // 0x000000018579179C-0x00000001857918A4
		public void ClearBindRenderEntities() {} // 0x0000000182603DB0-0x0000000182603E00
		public bool Binded(Entity renderEntity) => default; // 0x0000000182429680-0x0000000182429770
		public bool HasRenderer() => default; // 0x00000001827D9720-0x00000001827D97C0
		private void __AOT_FOR_FIX__() {} // 0x00000001857918A4-0x00000001857919F0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BurnPowerFragment : IComponentECS // TypeDefIndex: 48656
	{
		// Fields
		public long currentLeastProgress; // 0x00
		public long powerGenPerSec; // 0x08
		public FixedString64Bytes burningItemId; // 0x10
		public const int ID = 4; // Metadata: 0x01FBB99B
	
		// Properties
		public int id { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185791AF8-0x0000000185791C1C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BusFragment : IComponentECS // TypeDefIndex: 48657
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 5; // Metadata: 0x01FBB99C
	
		// Properties
		public int id { get => default; } // 0x0000000183D51100-0x0000000183D51110 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185791C1C-0x0000000185791D28
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BusFreeFragment : IComponentECS // TypeDefIndex: 48658
	{
		// Fields
		public bool connectToStart; // 0x00
		public bool enabled; // 0x01
		public const int ID = 6; // Metadata: 0x01FBB99D
	
		// Properties
		public int id { get => default; } // 0x0000000183D51110-0x0000000183D51120 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185791D28-0x0000000185791E3C
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct CacheFragment : IComponentECS // TypeDefIndex: 48666
	{
		// Fields
		private const int CONTAINER_OFFSET = 16; // Metadata: 0x01FBB99E
		private const int ITEM_SIZE = 16; // Metadata: 0x01FBB99F
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
		public const int ID = 7; // Metadata: 0x01FBB9A0
	
		// Properties
		public int id { get => default; } // 0x0000000183D55AA0-0x0000000183D55AB0 
	
		// Methods
		public void GetCacheItem(bool inOut, bool isFluid, int cacheIndex, int indexInCache, out uint itemId, out int itemAmount, out long tms) {
			itemId = default;
			itemAmount = default;
			tms = default;
		} // 0x0000000185791F48-0x000000018579205C
		public void SetCacheItem(bool inOut, bool isFluid, int cacheIndex, int indexInCache, uint itemId, int itemAmount, long tms) {} // 0x00000001827545C0-0x0000000182754680
		public void SetCacheSize(bool inOut, bool isFluid, int cacheIndex, int sizeCount) {} // 0x0000000182754550-0x00000001827545C0
		public unsafe int CalcIndex(bool inOut, bool isFluid, int cacheIndex, int indexInCache, out FactoryItem* ptr) {
			ptr = default;
			return default;
		} // 0x0000000182754680-0x0000000182754750
		private void __AOT_FOR_FIX__() {} // 0x000000018579205C-0x00000001857921A0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CacheTransportFragment : IComponentECS // TypeDefIndex: 48667
	{
		// Fields
		public bool autoTransport; // 0x00
		public bool inUse; // 0x01
		public float currentProgress; // 0x04
		public float totalProgress; // 0x08
		public const int ID = 8; // Metadata: 0x01FBB9A1
	
		// Properties
		public int id { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857921A0-0x00000001857922BC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CargoFragment : IComponentECS, IUnitConfigRef, IComparable<CargoFragment> // TypeDefIndex: 48669
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
		public int itemFastId; // 0x54
		public long tms; // 0x58
		public float adjustTms; // 0x60
		public uint conveyorExtHandle; // 0x64
		public int cargoIndex; // 0x68
		public int indexInRendererList; // 0x6C
		public int unitConfigAssetInstanceId; // 0x70
		public const int ID = 9; // Metadata: 0x01FBB9A2
	
		// Properties
		public string itemId { get => default; set {} } // 0x0000000185792604-0x0000000185792610 0x0000000185792620-0x0000000185792640
		public bool recyclable { get => default; } // 0x0000000185792610-0x0000000185792620 
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4F0C0-0x0000000183D4F0D0 0x0000000183D4F0F0-0x0000000183D4F100
		public int id { get => default; } // 0x0000000183D55810-0x0000000183D55820 
	
		// Nested types
		public struct ItemUV // TypeDefIndex: 48668
		{
			// Fields
			public bool isLiquid; // 0x00
			public int4 itemAtlasRect; // 0x04
			public int4 liquidAtlasRect; // 0x14
		}
	
		// Methods
		public float PredictPos(long serverTime) => default; // 0x0000000185792438-0x00000001857924C8
		public float PredictPosWithDeltaTime(long deltaTime) => default; // 0x00000001857923C8-0x0000000185792438
		public int CompareTo(CargoFragment other) => default; // 0x00000001857922BC-0x000000018579237C
		public unsafe bool GetVisible(CargoRendererInfoCollection<CargoRendererInfo>* rendererList) => default; // 0x000000018579237C-0x00000001857923C8
		public static CargoFragment Create(uint unitId, int4 itemAtlasRect, int4 liquidAtlasRect, int itemFastId, int conveyorSpeed, long tms, int conveyorLength, float minDis, bool isLiquidItem) => default; // 0x00000001827DA350-0x00000001827DA610
		private void __AOT_FOR_FIX__() {} // 0x00000001857924C8-0x0000000185792604
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CargoRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48670
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 10; // Metadata: 0x01FBB9A3
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D55730-0x0000000183D55740 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185792640-0x000000018579274C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ChapterFragment : IComponentECS // TypeDefIndex: 48671
	{
		// Fields
		public long powerCost; // 0x00
		public long powerGen; // 0x08
		public long powerSaveCurrent; // 0x10
		public long powerSaveMax; // 0x18
		public bool isStopByPower; // 0x20
		public int chapterId; // 0x24
		public BlueprintSlotInfo blueprintSlotInfo; // 0x28
		public const int ID = 11; // Metadata: 0x01FBB9A4
	
		// Properties
		public int id { get => default; } // 0x0000000183D557B0-0x0000000183D557C0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579274C-0x0000000185792898
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CollectorFragment : IComponentECS // TypeDefIndex: 48672
	{
		// Fields
		public long currentProgress; // 0x00
		public uint collectItem; // 0x08
		public const int ID = 12; // Metadata: 0x01FBB9A5
	
		// Properties
		public int id { get => default; } // 0x0000000183D557A0-0x0000000183D557B0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185792898-0x00000001857929B0
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct ConnectionFragment : IComponentECS // TypeDefIndex: 48674
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
		public const int ID = 13; // Metadata: 0x01FBB9A6
	
		// Properties
		public bool valid { get => default; } // 0x00000001827D2640-0x00000001827D2760 
		public int id { get => default; } // 0x0000000183D557F0-0x0000000183D55800 
	
		// Nested types
		public enum RendererType : byte // TypeDefIndex: 48673
		{
			NORMAL = 0,
			HS = 1
		}
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185793698-0x00000001857937BC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorFragment : IComponentECS, ILogisticSample // TypeDefIndex: 48676
	{
		// Fields
		public uint factoryUnitId; // 0x00
		public float speed; // 0x04
		public UnityEngine.Rect bounds; // 0x08
		public uint startMemoryOffsetHandle; // 0x1C
		public uint endMemoryOffsetHandle; // 0x20
		public const int ID = 14; // Metadata: 0x01FBB9AD
	
		// Properties
		public int length { [IsReadOnly] get; private set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public int id { get => default; } // 0x0000000183D55AC0-0x0000000183D55AD0 
	
		// Nested types
		public enum ProtoType : byte // TypeDefIndex: 48675
		{
			LEFT = 0,
			MID = 1,
			RIGHT = 2
		}
	
		// Methods
		public void SetInflection(ref GlobalEnv env, ref NativeList<float3> p, ref NativeList<float3> r, ref NativeArray<byte> proto) {} // 0x0000000182A8DC80-0x0000000182A8DF80
		public static void CalcRect(NativeList<float3> posList, ref UnityEngine.Rect b) {} // 0x0000000182A8DAB0-0x0000000182A8DC80
		public bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInConveyor) {
			unitId = default;
			indexInConveyor = default;
			return default;
		} // 0x00000001824FB300-0x00000001824FB5C0
		public bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax) => default; // 0x0000000185793C30-0x0000000185793DB8
		public bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex) => default; // 0x00000001828BD970-0x00000001828BDB70
		public bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets) => default; // 0x0000000185793A14-0x0000000185793C30
		public void DrawDebug(float groundY = 0f /* Metadata: 0x01FBB9A9 */) {} // 0x00000001857939C0-0x0000000185793A14
		private void __AOT_FOR_FIX__() {} // 0x0000000185793DB8-0x0000000185793EDC
	}

	public interface ILogisticSample // TypeDefIndex: 48677
	{
		// Methods
		bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInLogistic);
		bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax);
		bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex);
		bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets);
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorLogisticsUnitFragment : IComponentECS // TypeDefIndex: 48678
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 15; // Metadata: 0x01FBB9B1
	
		// Properties
		public int id { get => default; } // 0x0000000183D55AE0-0x0000000183D55AF0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185793FE8-0x00000001857940F4
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct ConveyorRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48679
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int indexInConveyor; // 0x04
		public HGFactoryEntityTransformData transformData; // 0x08
		public float3 position; // 0x08
		public float scale; // 0x14
		public quaternion rotation; // 0x18
		public const int ID = 16; // Metadata: 0x01FBB9B2
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D55B10-0x0000000183D55B20 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185794320-0x0000000185794444
	}

	[BurstCompatible]
	[ECSComponent]
	public struct LeftFragment : IComponentECS // TypeDefIndex: 48680
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 17; // Metadata: 0x01FBB9B3
	
		// Properties
		public int id { get => default; } // 0x0000000183D55F90-0x0000000183D55FA0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185798710-0x000000018579881C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct RightFragment : IComponentECS // TypeDefIndex: 48681
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 18; // Metadata: 0x01FBB9B4
	
		// Properties
		public int id { get => default; } // 0x0000000183D56100-0x0000000183D56110 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579AFCC-0x000000018579B0D8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct MidFragment : IComponentECS // TypeDefIndex: 48682
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 19; // Metadata: 0x01FBB9B5
	
		// Properties
		public int id { get => default; } // 0x0000000183D55FE0-0x0000000183D55FF0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185798D48-0x0000000185798E54
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CullResultFragment : IComponentECS // TypeDefIndex: 48683
	{
		// Fields
		public bool culled; // 0x00
		public const int ID = 22; // Metadata: 0x01FBB9B6
	
		// Properties
		public int id { get => default; } // 0x0000000183D55B20-0x0000000183D55B30 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185794444-0x0000000185794550
	}

	[BurstCompatible]
	[ECSComponent]
	public struct DebugFragment : IComponentECS // TypeDefIndex: 48684
	{
		// Fields
		public const int ID = 26; // Metadata: 0x01FBB9B7
	
		// Properties
		public int id { get => default; } // 0x0000000183D55B40-0x0000000183D55B50 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185794778-0x0000000185794884
	}

	[BurstCompatible]
	[ECSComponent]
	public struct EvtDestroyUnit : IReactiveComponent // TypeDefIndex: 48685
	{
		// Fields
		public long targetDestroyTime; // 0x00
		public long checkedTime; // 0x08
		public const int ID = 27; // Metadata: 0x01FBB9B8
	
		// Properties
		public bool timeout { get => default; } // 0x0000000182AABCC0-0x0000000182AABCD0 
		public int id { get => default; } // 0x0000000183D55BC0-0x0000000183D55BD0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185794D54-0x0000000185794E6C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ShowStateUI : IComponentECS // TypeDefIndex: 48686
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 28; // Metadata: 0x01FBB9B9
	
		// Properties
		public int id { get => default; } // 0x0000000183D56120-0x0000000183D56130 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579B1E4-0x000000018579B2F0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ShowNameUI : IComponentECS // TypeDefIndex: 48687
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 29; // Metadata: 0x01FBB9BA
	
		// Properties
		public int id { get => default; } // 0x0000000183D56110-0x0000000183D56120 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579B0D8-0x000000018579B1E4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct HasRenderer : IComponentECS // TypeDefIndex: 48688
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 30; // Metadata: 0x01FBB9BB
	
		// Properties
		public int id { get => default; } // 0x0000000183D55770-0x0000000183D55780 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185798194-0x00000001857982A0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct EvtUpdatePipeEffect : INotificationComponent // TypeDefIndex: 48689
	{
		// Fields
		public Entity evtEntity; // 0x00
		public const int ID = 31; // Metadata: 0x01FBB9BC
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		public int id { get => default; } // 0x0000000183D55C10-0x0000000183D55C20 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857951B0-0x00000001857952BC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct EvtChangeTemplate : INotificationComponent // TypeDefIndex: 48690
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
		public const int ID = 32; // Metadata: 0x01FBB9BD
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x0000000183D55B60-0x0000000183D55B70 0x0000000183D55B80-0x0000000183D55B90
		public int id { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857949F4-0x0000000185794B30
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct EvtCreateUnitRenderer : INotificationComponent // TypeDefIndex: 48691
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public const int ID = 33; // Metadata: 0x01FBB9BE
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		public int id { get => default; } // 0x0000000183D55BB0-0x0000000183D55BC0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185794C48-0x0000000185794D54
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct EvtUpdateStatusEffect : INotificationComponent // TypeDefIndex: 48692
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public const int ID = 34; // Metadata: 0x01FBB9BF
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		public int id { get => default; } // 0x0000000183D55C30-0x0000000183D55C40 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857953D4-0x00000001857954E0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct EvtPendingCreateRenderer : INotificationComponent // TypeDefIndex: 48693
	{
		// Fields
		public Entity evtEntity; // 0x00
		public const int ID = 35; // Metadata: 0x01FBB9C0
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		public int id { get => default; } // 0x0000000183D55BD0-0x0000000183D55BE0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185794E6C-0x0000000185794F78
	}

	[BurstCompatible]
	[ECSComponent]
	public struct EvtUpdateRendererProperty : INotificationComponent // TypeDefIndex: 48694
	{
		// Fields
		public bool evtColliderToggle; // 0x00
		public bool colliderToggle; // 0x01
		public bool evtVisible; // 0x02
		public bool visible; // 0x03
		public bool additiveVisible; // 0x04
		public Entity evtEntity; // 0x08
		public const int ID = 36; // Metadata: 0x01FBB9C1
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x0000000183D55BA0-0x0000000183D55BB0
		public int id { get => default; } // 0x0000000183D55C20-0x0000000183D55C30 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857952BC-0x00000001857953D4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct EvtStatusChange : INotificationComponent // TypeDefIndex: 48695
	{
		// Fields
		public bool forceUpdate; // 0x00
		public Entity evtEntity; // 0x04
		public const int ID = 37; // Metadata: 0x01FBB9C2
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x0000000183D55BE0-0x0000000183D55BF0 0x0000000183D55C00-0x0000000183D55C10
		public int id { get => default; } // 0x0000000183D55BF0-0x0000000183D55C00 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185794F78-0x0000000185795094
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct EvtCreateInteract : INotificationComponent // TypeDefIndex: 48696
	{
		// Fields
		public ulong interactObjectId; // 0x00
		public Entity evtEntity; // 0x08
		public ulong evtEntityId; // 0x08
		public const int ID = 38; // Metadata: 0x01FBB9C3
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x0000000183D55BA0-0x0000000183D55BB0
		public int id { get => default; } // 0x0000000183D55B90-0x0000000183D55BA0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185794B30-0x0000000185794C48
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct EvtVatUpdate : INotificationComponent // TypeDefIndex: 48697
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public byte placeHolder; // 0x08
		public const int ID = 39; // Metadata: 0x01FBB9C4
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		public int id { get => default; } // 0x0000000183D55C40-0x0000000183D55C50 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857954E0-0x00000001857955F8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct EvtUpdatePedestalColorLUT : INotificationComponent // TypeDefIndex: 48698
	{
		// Fields
		public bool light; // 0x00
		public Entity evtEntity; // 0x04
		public const int ID = 40; // Metadata: 0x01FBB9C5
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x0000000183D55BE0-0x0000000183D55BF0 0x0000000183D55C00-0x0000000183D55C10
		public int id { get => default; } // 0x0000000183D55740-0x0000000183D55750 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185795094-0x00000001857951B0
	}

	public enum EvtAudioType : short // TypeDefIndex: 48699
	{
		BUILDING_STATUS = 1,
		BUILDING_DESTROY = 2
	}

	[Flags]
	public enum AudioCullingState : byte // TypeDefIndex: 48700
	{
		AUDIBLE = 1,
		PENDING_CULL = 2,
		CULLED = 4,
		CULLED_CUR_FRAME = 6,
		PENDING_RESTORE = 8,
		AUDIBLE_CUR_FRAME = 9
	}

	public enum AudioDebugGizmosType : byte // TypeDefIndex: 48701
	{
		NONE = 0,
		GROUP_EMITTER_AREA1 = 1,
		GROUP_EMITTER_AREA2 = 2,
		GROUP_EMITTER_AREA3 = 3,
		GROUP_EMITTER_OUT_OF_RANGE = 4,
		GROUP_EMITTER_NOT_CONSIDERED_TYPE = 5,
		GROUP_EMITTER_NOT_CONSIDERED_STATUS = 6
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct EvtAudio : INotificationComponent // TypeDefIndex: 48702
	{
		// Fields
		public ulong evtEntityId; // 0x00
		public Entity evtEntity; // 0x00
		public EvtAudioType evtType; // 0x08
		public const int ID = 41; // Metadata: 0x01FBB9D7
	
		// Properties
		public Entity eventEntity { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		public int id { get => default; } // 0x0000000183D55B50-0x0000000183D55B60 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857948DC-0x00000001857949F4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct AudioFragment : IComponentECS // TypeDefIndex: 48703
	{
		// Fields
		public uint audioFragmentId; // 0x00
		public float distSqToListener; // 0x04
		public AudioCullingState cullingState; // 0x08
		public const int ID = 42; // Metadata: 0x01FBB9D8
	
		// Properties
		public int id { get => default; } // 0x0000000183D55A80-0x0000000183D55A90 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185791380-0x000000018579149C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ReleaseTagFragment : IComponentECS // TypeDefIndex: 48704
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 43; // Metadata: 0x01FBB9D9
	
		// Properties
		public int id { get => default; } // 0x0000000183D560F0-0x0000000183D56100 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579AEC0-0x000000018579AFCC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct CurMapUnitTag : IComponentECS // TypeDefIndex: 48705
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 45; // Metadata: 0x01FBB9DA
	
		// Properties
		public int id { get => default; } // 0x0000000183D55B30-0x0000000183D55B40 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185794550-0x000000018579465C
	}

	public struct StaticMountOffset // TypeDefIndex: 48706
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
	public struct UnitFragment : IComponentECS // TypeDefIndex: 48707
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
		public int templateIdFastString; // 0x34
		public int rendererTemplateIdFastString; // 0x38
		public int logisticBaseRendererTemplateIdFastString; // 0x3C
		public int nonLogisticBaseRendererTemplateIdFastString; // 0x40
		public int instKeyFastString; // 0x44
		public StaticMountOffset staticMountOffset; // 0x48
		public const int ID = 46; // Metadata: 0x01FBB9EB
	
		// Properties
		public bool needRepair { get => default; } // 0x000000018579B658-0x000000018579B660 
		public bool battleBroken { get => default; } // 0x000000018579B650-0x000000018579B658 
		public bool socialUnit { get => default; } // 0x00000001828BC270-0x00000001828BC280 
		public string templateId { get => default; set {} } // 0x000000018426FD18-0x000000018426FD24 0x00000001842716CC-0x0000000184271728
		public string rendererTemplateId { get => default; set {} } // 0x000000018579B660-0x000000018579B66C 0x00000001842716AC-0x00000001842716CC
		public string logisticBaseRendererTemplateId { get => default; set {} } // 0x0000000184270AD8-0x0000000184270AE4 0x000000018579B66C-0x000000018579B68C
		public string nonLogisticBaseRendererTemplateId { get => default; set {} } // 0x0000000184270ACC-0x0000000184270AD8 0x000000018579B68C-0x000000018579B6AC
		public string instKey { get => default; set {} } // 0x00000001842725B0-0x00000001842725BC 0x000000018427168C-0x00000001842716AC
		public FCNodeMode formulaType { get => default; } // 0x0000000182763520-0x0000000182763530 
		public int id { get => default; } // 0x0000000183D56140-0x0000000183D56150 
	
		// Methods
		public static UnitFragment Create(uint nodeId, string templateId, int nodeType, bool2 buildDismissEnabled, int level = 0 /* Metadata: 0x01FBB9DB */, uint nodeFlag = 0 /* Metadata: 0x01FBB9DC */, string rendererTemplateId = "" /* Metadata: 0x01FBB9DD */, bool inBlock = false /* Metadata: 0x01FBB9DE */, bool inPower = false /* Metadata: 0x01FBB9DF */, bool inActive = true /* Metadata: 0x01FBB9E0 */, long powerCost = 0 /* Metadata: 0x01FBB9E1 */, bool formulaManMode = false /* Metadata: 0x01FBB9E9 */, string instKey = "" /* Metadata: 0x01FBB9EA */) => default; // 0x0000000182754E10-0x0000000182755000
		private void __AOT_FOR_FIX__() {} // 0x000000018579B50C-0x000000018579B650
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitRenderPipeLogisticsFigureReplaceFragment : IComponentECS // TypeDefIndex: 48708
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 47; // Metadata: 0x01FBB9EC
	
		// Properties
		public int id { get => default; } // 0x0000000183D56180-0x0000000183D56190 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579BB1C-0x000000018579BC28
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BusRenderFragment : IComponentECS // TypeDefIndex: 48709
	{
		// Fields
		public int idx; // 0x00
		public const int ID = 48; // Metadata: 0x01FBB9ED
	
		// Properties
		public int id { get => default; } // 0x0000000183D55A90-0x0000000183D55AA0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185791E3C-0x0000000185791F48
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitRenderBuildingFragment : IComponentECS // TypeDefIndex: 48710
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 49; // Metadata: 0x01FBB9EE
	
		// Properties
		public int id { get => default; } // 0x0000000183D56170-0x0000000183D56180 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579B904-0x000000018579BA10
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitRenderPedestalFragment : IComponentECS // TypeDefIndex: 48711
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 50; // Metadata: 0x01FBB9EF
	
		// Properties
		public int id { get => default; } // 0x0000000183D55760-0x0000000183D55770 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579BA10-0x000000018579BB1C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitRendererRegularFragment : IComponentECS // TypeDefIndex: 48712
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 51; // Metadata: 0x01FBB9F0
	
		// Properties
		public int id { get => default; } // 0x0000000183D56190-0x0000000183D561A0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579BC28-0x000000018579BD34
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitOnlyRendererFragment : IComponentECS // TypeDefIndex: 48713
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 52; // Metadata: 0x01FBB9F1
	
		// Properties
		public int id { get => default; } // 0x0000000183D56150-0x0000000183D56160 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579B6AC-0x000000018579B7B8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FakeUnitFragment : IComponentECS // TypeDefIndex: 48714
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 53; // Metadata: 0x01FBB9F2
	
		// Properties
		public int id { get => default; } // 0x0000000183D55C50-0x0000000183D55C60 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857955F8-0x0000000185795704
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UIUnitFragment : IComponentECS // TypeDefIndex: 48715
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 54; // Metadata: 0x01FBB9F3
	
		// Properties
		public int id { get => default; } // 0x0000000183D56130-0x0000000183D56140 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579B400-0x000000018579B50C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct GuideHintFragment : IComponentECS // TypeDefIndex: 48716
	{
		// Fields
		public int hashKey; // 0x00
		public const int ID = 55; // Metadata: 0x01FBB9F4
	
		// Properties
		public int id { get => default; } // 0x0000000183D55F60-0x0000000183D55F70 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185798088-0x0000000185798194
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitPreviewFragment : IComponentECS // TypeDefIndex: 48719
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
		public const int ID = 56; // Metadata: 0x01FBB9F5
	
		// Properties
		public string templateId { get => default; set {} } // 0x000000018579B8F8-0x000000018579B904 0x00000001842744C8-0x00000001842744F0
		public string previewRendererTemplateId { get => default; set {} } // 0x000000018579B8EC-0x000000018579B8F8 0x00000001842744A8-0x00000001842744C8
		public string logisticPedestalRendererTemplateId { get => default; set {} } // 0x000000018579B8D4-0x000000018579B8E0 0x0000000184274488-0x00000001842744A8
		public string nonLogisticPedestalRendererTemplateId { get => default; set {} } // 0x000000018579B8E0-0x000000018579B8EC 0x0000000184274468-0x0000000184274488
		public int id { get => default; } // 0x0000000183D56160-0x0000000183D56170 
	
		// Nested types
		public enum EntityTarget // TypeDefIndex: 48717
		{
			BUILDING = 0,
			PEDESTAL_LOGISTIC = 1,
			PEDESTAL_NO_LOGISTIC = 2
		}
	
		public enum EntityType // TypeDefIndex: 48718
		{
			NORMAL = 0,
			BLUEPRINT = 1
		}
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579B7B8-0x000000018579B8D4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorRegularFragment : IComponentECS // TypeDefIndex: 48720
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 57; // Metadata: 0x01FBB9FB
	
		// Properties
		public int id { get => default; } // 0x0000000183D55B00-0x0000000183D55B10 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185794214-0x0000000185794320
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorGuideFragment : IComponentECS // TypeDefIndex: 48721
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 58; // Metadata: 0x01FBB9FC
	
		// Properties
		public int id { get => default; } // 0x0000000183D55AD0-0x0000000183D55AE0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185793EDC-0x0000000185793FE8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeRegularFragment : IComponentECS // TypeDefIndex: 48722
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 59; // Metadata: 0x01FBB9FD
	
		// Properties
		public int id { get => default; } // 0x0000000183D560C0-0x0000000183D560D0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579A918-0x000000018579AA24
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ConveyorPreviewRendererFragment : IComponentECS // TypeDefIndex: 48723
	{
		// Fields
		public bool valid; // 0x00
		public UnitPreviewFragment.EntityType entityType; // 0x04
		public int length; // 0x08
		public uint startMemoryOffsetHandle; // 0x0C
		public uint endMemoryOffsetHandle; // 0x10
		public const int ID = 60; // Metadata: 0x01FBB9FE
	
		// Properties
		public int id { get => default; } // 0x0000000183D55AF0-0x0000000183D55B00 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857940F4-0x0000000185794214
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipePreviewRendererFragment : IComponentECS // TypeDefIndex: 48724
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
		public const int ID = 61; // Metadata: 0x01FBB9FF
	
		// Properties
		public int id { get => default; } // 0x0000000183D560B0-0x0000000183D560C0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579A7FC-0x000000018579A918
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipePreviewFragment : IComponentECS // TypeDefIndex: 48725
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 62; // Metadata: 0x01FBBA00
	
		// Properties
		public int id { get => default; } // 0x0000000183D560A0-0x0000000183D560B0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579A6F0-0x000000018579A7FC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48726
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 63; // Metadata: 0x01FBBA01
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D55C60-0x0000000183D55C70 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185795704-0x0000000185795820
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderLeftFragment : IComponentECS // TypeDefIndex: 48727
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 64; // Metadata: 0x01FBBA02
	
		// Properties
		public int id { get => default; } // 0x0000000183D55C70-0x0000000183D55C80 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185795820-0x000000018579592C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderRightFragment : IComponentECS // TypeDefIndex: 48728
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 65; // Metadata: 0x01FBBA04
	
		// Properties
		public int id { get => default; } // 0x0000000183D55CA0-0x0000000183D55CB0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185795B44-0x0000000185795C50
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderMidFragment : IComponentECS // TypeDefIndex: 48729
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 66; // Metadata: 0x01FBBA06
	
		// Properties
		public int id { get => default; } // 0x0000000183D55C80-0x0000000183D55C90 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579592C-0x0000000185795A38
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FigureRenderPipeHolderFragment : IComponentECS // TypeDefIndex: 48730
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 67; // Metadata: 0x01FBBA08
	
		// Properties
		public int id { get => default; } // 0x0000000183D55C90-0x0000000183D55CA0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185795A38-0x0000000185795B44
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidConsumeFragment : IComponentECS // TypeDefIndex: 48731
	{
		// Fields
		public long progress; // 0x00
		public const int ID = 68; // Metadata: 0x01FBBA0A
	
		// Properties
		public int id { get => default; } // 0x0000000183D55CB0-0x0000000183D55CC0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185795CA8-0x0000000185795DB4
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct FluidContainerFragment : IComponentECS // TypeDefIndex: 48732
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
		public const int ID = 69; // Metadata: 0x01FBBA0C
	
		// Properties
		public int id { get => default; } // 0x0000000183D55CC0-0x0000000183D55CD0 
	
		// Methods
		public void Set(int index, int itemId, int itemAmount, int itemSubType) {} // 0x00000001830AF660-0x00000001830AF6C0
		public void SetCapacity(int index, int cap) {} // 0x00000001830AF6C0-0x00000001830AF710
		public void SetAmount(int index, int amount) {} // 0x0000000185796384-0x00000001857963F8
		public bool Get(int index, out int itemId, out int itemAmount, out float renderItemAmount, out int itemSubType, out int cap) {
			itemId = default;
			itemAmount = default;
			renderItemAmount = default;
			itemSubType = default;
			cap = default;
			return default;
		} // 0x00000001830D4630-0x00000001830D46C0
		public bool HasLiquid() => default; // 0x000000018579631C-0x0000000185796384
		public void CalcRenderItemAmount(float step) {} // 0x0000000185795DB4-0x000000018579619C
		public ValueTuple<int, uint> GetOffsetData() => default; // 0x000000018579619C-0x000000018579631C
		public void Reset() {} // 0x0000000183B297A0-0x0000000183B29820
		public override string ToString() => default; // 0x00000001857963F8-0x0000000185796DCC
		private void __AOT_FOR_FIX__() {} // 0x0000000185796E74-0x0000000185796FB4
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185796DCC-0x0000000185796E74
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidPumpInFragment : IComponentECS // TypeDefIndex: 48733
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 70; // Metadata: 0x01FBBA0E
	
		// Properties
		public int id { get => default; } // 0x0000000183D55CD0-0x0000000183D55CE0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185796FB4-0x00000001857970C0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidPumpOutFragment : IComponentECS // TypeDefIndex: 48734
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 71; // Metadata: 0x01FBBA10
	
		// Properties
		public int id { get => default; } // 0x0000000183D55CE0-0x0000000183D55CF0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857970C0-0x00000001857971CC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidReactionFragment : IComponentECS // TypeDefIndex: 48735
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 72; // Metadata: 0x01FBBA12
	
		// Properties
		public int id { get => default; } // 0x0000000183D55CF0-0x0000000183D55D00 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857971CC-0x00000001857972D8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidSprayFragment : IComponentECS // TypeDefIndex: 48736
	{
		// Fields
		public long progress; // 0x00
		public const int ID = 73; // Metadata: 0x01FBBA14
	
		// Properties
		public int id { get => default; } // 0x0000000183D55D00-0x0000000183D55D10 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857972D8-0x00000001857973E4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FormulaManualFragment : IComponentECS // TypeDefIndex: 48737
	{
		// Fields
		public int currentGroup; // 0x00
		public int currentMode; // 0x04
		public int lockedFormulaId; // 0x08
		public const int ID = 74; // Metadata: 0x01FBBA16
	
		// Properties
		public int id { get => default; } // 0x0000000183D55D10-0x0000000183D55D20 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857973E4-0x0000000185797500
	}

	public struct EvtLogisticFigureRenderer // TypeDefIndex: 48738
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
		} // 0x0000000183D06750-0x0000000183D067C0
	}

	public struct OutOfBufferWarning // TypeDefIndex: 48739
	{
		// Fields
		public bool pipe; // 0x00
		public bool wire; // 0x01
		public bool conveyor; // 0x02
		public bool cargo; // 0x03
		public bool operated; // 0x04
	
		// Methods
		public void ResetFlags() {} // 0x0000000183B341C0-0x0000000183B341F0
		public override string ToString() => default; // 0x0000000185798E54-0x0000000185799020
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185799020-0x0000000185799074
	}

	[Flags]
	public enum FacSystemTickSkipSource : byte // TypeDefIndex: 48740
	{
		NONE = 0,
		MAP = 1,
		UI = 2,
		GM = 128,
		ALL = 255
	}

	[BurstCompatible]
	[ECSComponent]
	public struct GlobalEnv : IComponentECS // TypeDefIndex: 48741
	{
		// Fields
		public OutOfBufferWarning outOfBufferWarning; // 0x00
		public bool teardown; // 0x05
		public bool isSquadInFight; // 0x06
		public bool isTowerDefence; // 0x07
		public FacSystemTickSkipSource facSystemTickSkip; // 0x08
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
		public const int ID = 76; // Metadata: 0x01FBBA1D
	
		// Properties
		public bool facSystemTickEnabled { get => default; } // 0x000000018312EE60-0x000000018312EEF0 
		public UnsafeList<float4x4> portBlockPosListReader { get => default; } // 0x0000000182BC0770-0x0000000182BC07E0 
		public UnsafeList<OutputRendererInfo> outputUIPosListReader { get => default; } // 0x00000001833B82C0-0x00000001833B8330 
		public UnsafeList<float4x4> buildingStatePosListReader { get => default; } // 0x0000000182BC0580-0x0000000182BC0640 
		public IntPtr cargoMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55DF0-0x0000000183D55E00 
		public int cargoRendererCount { get => default; } // 0x00000001824F4CF0-0x00000001824F4D30 
		public bool cargoDirty { get => default; } // 0x00000001824F5340-0x00000001824F5560 
		public IntPtr conveyorLPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55E00-0x0000000183D55E10 
		public IntPtr conveyorMPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55E10-0x0000000183D55E20 
		public IntPtr conveyorRPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55E40-0x0000000183D55E50 
		public int lConveyorRenderCount { get => default; } // 0x0000000182F51F40-0x0000000182F51F80 
		public int mConveyorRenderCount { get => default; } // 0x0000000182F51F00-0x0000000182F51F40 
		public int rConveyorRenderCount { get => default; } // 0x0000000182F51EC0-0x0000000182F51F00 
		public bool conveyorDirty { get => default; } // 0x00000001822BC460-0x00000001822BC7A0 
		public IntPtr portArrowMatricesIntPtrReader { get => default; } // 0x0000000183D55EF0-0x0000000183D55F00 
		public int portArrowRenderCount { get => default; } // 0x0000000182BBFE00-0x0000000182BBFE40 
		public bool portArrowDirty { get => default; } // 0x0000000185797E84-0x0000000185797FD4 
		public IntPtr conveyorPreviewLPosMatricesIntPtrReader { get => default; } // 0x0000000183D55E20-0x0000000183D55E30 
		public IntPtr conveyorPreviewMPosMatricesIntPtrReader { get => default; } // 0x0000000181143890-0x00000001811438A0 
		public IntPtr conveyorPreviewRPosMatricesIntPtrReader { get => default; } // 0x0000000183D55E30-0x0000000183D55E40 
		public int lConveyorPreviewRenderCount { get => default; } // 0x0000000182F51E80-0x0000000182F51EC0 
		public int mConveyorPreviewRenderCount { get => default; } // 0x0000000182F51E40-0x0000000182F51E80 
		public int rConveyorPreviewRenderCount { get => default; } // 0x0000000182F51E00-0x0000000182F51E40 
		public UnsafeList<float4x4> conveyorInsideMatricesReader { get => default; } // 0x0000000182BC0220-0x0000000182BC0290 
		public bool previewConveyorDirty { get => default; } // 0x00000001822BC7A0-0x00000001822BCAE0 
		public IntPtr guideFigureLPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55E50-0x0000000183D55E60 
		public IntPtr guideFigureMPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55E60-0x0000000183D55E70 
		public IntPtr guideFigureRPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55E70-0x0000000183D55E80 
		public int lGuideFigureRenderCount { get => default; } // 0x0000000182F53700-0x0000000182F53740 
		public int mGuideFigureRenderCount { get => default; } // 0x0000000182F536C0-0x0000000182F53700 
		public int rGuideFigureRenderCount { get => default; } // 0x0000000182F53680-0x0000000182F536C0 
		public bool guideFigureDirty { get => default; } // 0x00000001822B9B60-0x00000001822B9F30 
		public IntPtr pipeLPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55E90-0x0000000183D55EA0 
		public IntPtr pipeMPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55EA0-0x0000000183D55EB0 
		public IntPtr pipeRPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55EB0-0x0000000183D55EC0 
		public int lPipeRenderCount { get => default; } // 0x0000000182F53640-0x0000000182F53680 
		public int mPipeRenderCount { get => default; } // 0x0000000182F53600-0x0000000182F53640 
		public int rPipeRenderCount { get => default; } // 0x0000000182F535C0-0x0000000182F53600 
		public IntPtr pipeTrackLPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55EC0-0x0000000183D55ED0 
		public IntPtr pipeTrackMPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55ED0-0x0000000183D55EE0 
		public IntPtr pipeTrackRPosMatricesBufferIntPtrReader { get => default; } // 0x0000000183D55EE0-0x0000000183D55EF0 
		public int lPipeTrackRenderCount { get => default; } // 0x0000000183365940-0x0000000183365980 
		public int mPipeTrackRenderCount { get => default; } // 0x0000000183365900-0x0000000183365940 
		public int rPipeTrackRenderCount { get => default; } // 0x00000001833658C0-0x0000000183365900 
		public bool pipeDirty { get => default; } // 0x00000001822BCAE0-0x00000001822BCE20 
		public UnsafeList<Matrix4x4> pipeHolderPosMatricesReader { get => default; } // 0x0000000182F533F0-0x0000000182F53460 
		public UnsafeList<float4x4> comPosMatricesReader { get => default; } // 0x0000000182BC0640-0x0000000182BC0770 
		public IntPtr wireNormalBufferIntPtrReader { get => default; } // 0x0000000183D55F30-0x0000000183D55F40 
		public IntPtr wireHsNormalBufferIntPtrReader { get => default; } // 0x0000000183D55F10-0x0000000183D55F20 
		public IntPtr wireDisableBufferIntPtrReader { get => default; } // 0x0000000183D55F00-0x0000000183D55F10 
		public IntPtr wireStrengthenBufferIntPtrReader { get => default; } // 0x0000000183D55F40-0x0000000183D55F50 
		public IntPtr wireHsStrengthenBufferIntPtrReader { get => default; } // 0x0000000183D55F20-0x0000000183D55F30 
		public IntPtr wireStrengthenDisableBufferIntPtrReader { get => default; } // 0x0000000183D55F50-0x0000000183D55F60 
		public int wireNormalRendererCount { get => default; } // 0x00000001824F47C0-0x00000001824F4800 
		public int wireHsNormalRendererCount { get => default; } // 0x00000001824F4800-0x00000001824F4840 
		public int wireDisableRendererCount { get => default; } // 0x0000000185797FD4-0x0000000185798010 
		public int wireStrengthenRendererCount { get => default; } // 0x000000018579804C-0x0000000185798088 
		public int wireHsStrengthenRendererCount { get => default; } // 0x00000001824F4840-0x00000001824F4880 
		public int wireStrengthenDisableRendererCount { get => default; } // 0x0000000185798010-0x000000018579804C 
		public bool wireNormalDirty { get => default; } // 0x00000001824F5560-0x00000001824F5780 
		public bool wireHsNormalDirty { get => default; } // 0x00000001824F5780-0x00000001824F59A0 
		public bool wireDisableDirty { get => default; } // 0x00000001824F59A0-0x00000001824F5BC0 
		public bool wireStrengthenDirty { get => default; } // 0x00000001824F5BC0-0x00000001824F5DE0 
		public bool wireHsStrengthenDirty { get => default; } // 0x00000001824F5DE0-0x00000001824F6000 
		public bool wireStrengthenDisableDirty { get => default; } // 0x00000001824F6000-0x00000001824F6220 
		public UnsafeList<VATFSMProcessor.SetAnimatorParamRequest> animatorParamRequestQueueReader { get => default; } // 0x0000000185797DE8-0x0000000185797E84 
		public UnsafeList<VATFSMProcessor.VATFSMAudioData> animatorAudioQueueWriter { get => default; } // 0x00000001826DEF30-0x00000001826DEF90 
		public int id { get => default; } // 0x0000000183D55E80-0x0000000183D55E90 
	
		// Methods
		public void InitSkipFlag() {} // 0x000000018327B3C0-0x000000018327B3F0
		public void CreateQueryResult() {} // 0x0000000183278AF0-0x0000000183278C30
		public void DisposeQueryResult() {} // 0x0000000185797554-0x0000000185797624
		public void SwapCargoBuffer() {} // 0x000000018579768C-0x0000000185797728
		public unsafe void SetConveyorBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1) {} // 0x0000000183D55D60-0x0000000183D55DA0
		public void SwapConveyorBuffer() {} // 0x0000000185797728-0x00000001857977FC
		public unsafe void SetPortArrowBuffers(void* buffer0, void* buffer1) {} // 0x0000000183D55DA0-0x0000000183D55DB0
		public void SwapPortArrowBuffer() {} // 0x0000000185797A08-0x0000000185797AA4
		public unsafe void SetPreviewConveyorBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1) {} // 0x0000000183D55DB0-0x0000000183D55DF0
		public void SwapPreviewConveyorBuffer() {} // 0x0000000185797AA4-0x0000000185797B78
		public unsafe void SeGuideFigureBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1) {} // 0x0000000183D55D20-0x0000000183D55D60
		public void SwapGuideFigureBuffer() {} // 0x00000001857977FC-0x00000001857978D0
		public unsafe void SetPipeBuffers(void* lBuffer0, void* lBuffer1, void* mBuffer0, void* mBuffer1, void* rBuffer0, void* rBuffer1, void* trackLBuffer0, void* trackLBuffer1, void* trackMBuffer0, void* trackMBuffer1, void* trackRBuffer0, void* trackRBuffer1) {} // 0x0000000183281170-0x0000000183281200
		public void SwapPipeBuffer() {} // 0x00000001857978D0-0x0000000185797A08
		public unsafe void SetWireBuffer(void* normal0, void* normal1, void* hsNormal0, void* hsNormal1, void* disable0, void* disable1, void* strengthen0, void* strengthen1, void* hsStrengthen0, void* hsStrengthen1, void* strengthenDisable0, void* strengthenDisable1) {} // 0x00000001832810E0-0x0000000183281170
		public void SwapWireBuffer() {} // 0x0000000185797B78-0x0000000185797CA4
		[IDTag(0)]
		public unsafe void GetConveyorRendererInfo(uint memoryStartOffset, int countIdx, out ConveyorInfoAllocator.Info* info) {
			info = default;
		} // 0x00000001824FBA60-0x00000001824FBB30
		[IDTag(1)]
		public ref ConveyorInfoAllocator.Info GetConveyorRendererInfo(uint memoryStartOffset, int countIdx) => ref _refReturnTypeForGetConveyorRendererInfo; // 0x0000000182A8C040-0x0000000182A8C1A0
		private ref ConveyorInfoAllocator.Info _refReturnTypeForGetConveyorRendererInfo; // Dummy field
		public LinearAllocator.Allocation AllocateConveyorInfo(int count) => default; // 0x0000000182A8DFF0-0x0000000182A8E070
		public long CalculateConveyorInfoSize(uint memoryOffset) => default; // 0x0000000182A90250-0x0000000182A90290
		public LinearAllocator.Allocation ResizeConveyorInfo(uint startIndex, int count) => default; // 0x00000001839B1620-0x00000001839B16D0
		public void FreeConveyorInfo(uint startIndex) {} // 0x0000000185797624-0x000000018579768C
		public void DebugAllocatorPrint() {} // 0x0000000185797500-0x0000000185797554
		public void AddSetAnimatorParamRequest(Entity logicEntity, VATFSMProcessor.SetAnimatorParamRequest rq) {} // 0x00000001827D86B0-0x00000001827D9290
		private void _AddAnimatorParamRequest(ref EntityManager em, Entity renderEntity, [IsReadOnly] in VATFSMProcessor.SetAnimatorParamRequest rq) {} // 0x00000001827D9290-0x00000001827D9720
		public ref VATFSMProcessor.VATFSMAudioData GetAudioVATDataAt(int index) => ref _refReturnTypeForGetAudioVATDataAt; // 0x0000000182764120-0x0000000182764180
		private ref VATFSMProcessor.VATFSMAudioData _refReturnTypeForGetAudioVATDataAt; // Dummy field
		public int GetAudioVATDataLength() => default; // 0x0000000182764080-0x00000001827640D0
		public void ClearAudioVATData() {} // 0x00000001827640D0-0x0000000182764120
		public void ResetFlags() {} // 0x0000000183316880-0x00000001833168C0
		private void __AOT_FOR_FIX__() {} // 0x0000000185797CA4-0x0000000185797DE8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct HealthPoleFragment : IComponentECS // TypeDefIndex: 48742
	{
		// Fields
		public long currentProgress; // 0x00
		public int currentPoint; // 0x08
		public const int ID = 77; // Metadata: 0x01FBBA1F
	
		// Properties
		public int id { get => default; } // 0x0000000183D55F70-0x0000000183D55F80 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857982A0-0x00000001857983B8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct InventoryFragment : IComponentECS // TypeDefIndex: 48743
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 78; // Metadata: 0x01FBBA21
	
		// Properties
		public int id { get => default; } // 0x0000000183D55F80-0x0000000183D55F90 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185798604-0x0000000185798710
	}

	public interface IPositionFragment // TypeDefIndex: 48744
	{
		// Properties
		float3 Position { get; }
	}

	public interface IReactiveComponent : IComponentECS // TypeDefIndex: 48745
	{
	}

	public interface INotificationComponent : IReactiveComponent // TypeDefIndex: 48746
	{
		// Properties
		Entity eventEntity { get; set; }
	}

	public interface IRotateFragment // TypeDefIndex: 48747
	{
		// Properties
		float3 Rotation { get; }
		quaternion RotationQuaternion { get; }
	}

	public interface IUnitConfigRef // TypeDefIndex: 48748
	{
		// Properties
		int unitAssetInstanceId { get; set; }
	}

	[BurstCompatible]
	[ECSComponent]
	public struct LiquidPurifierFragment : IComponentECS // TypeDefIndex: 48749
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 79; // Metadata: 0x01FBBA23
	
		// Properties
		public int id { get => default; } // 0x0000000183D55FA0-0x0000000183D55FB0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579881C-0x0000000185798928
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct LogisticEffectFragment : IComponentECS // TypeDefIndex: 48750
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
		public const int ID = 80; // Metadata: 0x01FBBA25
	
		// Properties
		public int id { get => default; } // 0x0000000183D55FB0-0x0000000183D55FC0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185798928-0x0000000185798A48
	}

	[BurstCompatible]
	[ECSComponent]
	public struct LogisticEntityBindFragment : IComponentECS // TypeDefIndex: 48751
	{
		// Fields
		public EntityData256<Entity> cargoEntities; // 0x00
		public uint conveyorExtHandle; // 0x808
		public const int ID = 81; // Metadata: 0x01FBBA27
	
		// Properties
		public int cargoCount { get => default; } // 0x0000000182BC1430-0x0000000182BC1470 
		public int id { get => default; } // 0x0000000183D55FC0-0x0000000183D55FD0 
	
		// Methods
		public void EnqueueCargoEntityImpl(Entity cargoEntity, uint conveyorSharedDataIndex) {} // 0x00000001823F8BC0-0x00000001823F8F70
		public bool DequeueCargoEntityImpl(out Entity cargoEntity) {
			cargoEntity = default;
			return default;
		} // 0x00000001823F8730-0x00000001823F88B0
		public unsafe void Arrive(ref CargoFragment cargo, ConveyorExtContainer.ConveyorExt* conveyorExtData) {} // 0x0000000185798AC0-0x0000000185798AF0
		public unsafe void Arrive(Entity cargoEntity, ConveyorExtContainer.ConveyorExt* conveyorExtData) {} // 0x0000000185798A48-0x0000000185798AC0
		private void __AOT_FOR_FIX__() {} // 0x0000000185798AF0-0x0000000185798C3C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct MapGridRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48752
	{
		// Fields
		public const int ID = 82; // Metadata: 0x01FBBA29
	
		// Properties
		public int unitAssetInstanceId { [IsReadOnly] get; set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D55FD0-0x0000000183D55FE0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185798C3C-0x0000000185798D48
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct OutputFragment : IComponentECS // TypeDefIndex: 48753
	{
		// Fields
		public int3 itemAll; // 0x00
		public float4x3 rarityColorAll; // 0x0C
		public float4x3 atlasRectAll; // 0x3C
		public byte enableLiquidIcon; // 0x6C
		public float4x3 liquidAtlasUV; // 0x6D
		public static readonly int MAX_OUTPUT; // 0x00
		public const int ID = 83; // Metadata: 0x01FBBA2B
	
		// Properties
		public int this[int index] { get => default; set {} } // 0x0000000183D55FF0-0x0000000183D56000 0x0000000183D56010-0x0000000183D56020
		public bool hasOutput { get => default; } // 0x0000000185799454-0x00000001857994B8 
		public int id { get => default; } // 0x0000000183D56000-0x0000000183D56010 
	
		// Constructors
		static OutputFragment() {
			MAX_OUTPUT = default;
		} // 0x0000000183D43FA0-0x0000000183D43FE0
	
		// Methods
		public void Clean() {} // 0x0000000182752430-0x0000000182752510
		public ref float4 GetColor(int index) => ref _refReturnTypeForGetColor; // 0x00000001857990D8-0x000000018579913C
		private ref float4 _refReturnTypeForGetColor; // Dummy field
		[IDTag(0)]
		public void SetColor(int index, float4 color) {} // 0x0000000185799290-0x0000000185799314
		[IDTag(1)]
		public void SetColor(int index, UnityEngine.Color color) {} // 0x0000000182C04040-0x0000000182C04090
		[IDTag(0)]
		public void SetAtlasRect(int index, float4 rect) {} // 0x000000018579920C-0x0000000185799290
		[IDTag(1)]
		public void SetAtlasRect(int index, RectInt rect) {} // 0x0000000182C03770-0x0000000182C03860
		public ref float4 GetAtlasRect(int index) => ref _refReturnTypeForGetAtlasRect; // 0x0000000185799074-0x00000001857990D8
		private ref float4 _refReturnTypeForGetAtlasRect; // Dummy field
		public bool GetEnableLiquidIcon(int index) => default; // 0x000000018579913C-0x00000001857991A8
		public void SetEnableLiquidIcon(int index, bool enable) {} // 0x0000000182C04090-0x0000000182C04100
		public ref float4 GetLiquidIconUV(int index) => ref _refReturnTypeForGetLiquidIconUV; // 0x00000001857991A8-0x000000018579920C
		private ref float4 _refReturnTypeForGetLiquidIconUV; // Dummy field
		public void SetLiquidIconUV(int index, RectInt rect) {} // 0x0000000182C04100-0x0000000182C04190
		private void __AOT_FOR_FIX__() {} // 0x0000000185799314-0x0000000185799454
	}

	[BurstCompatible]
	[ECSComponent]
	public struct OutputUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48754
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 84; // Metadata: 0x01FBBA2D
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D56020-0x0000000183D56030 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857994B8-0x00000001857995C4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PedestalLightFlashFragment : IComponentECS // TypeDefIndex: 48755
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
		public const int ID = 85; // Metadata: 0x01FBBA2F
	
		// Properties
		public int id { get => default; } // 0x0000000183D56040-0x0000000183D56050 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185799BFC-0x0000000185799D28
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PedestalLightFlashConfigFragment : IComponentECS // TypeDefIndex: 48760
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ float intensity[0]; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ float flashIntensity[0]; // 0x40
		public unsafe fixed /* 0x00000000-0x00000000 */ float flashDuration[0]; // 0x80
		public unsafe fixed /* 0x00000000-0x00000000 */ bool flash[0]; // 0xC0
		public Float4Data16<float4> color; // 0xD0
		public Float4Data16<float4> flashColor; // 0x1D8
		public const int ID = 86; // Metadata: 0x01FBBA31
	
		// Properties
		public int id { get => default; } // 0x0000000183D56030-0x0000000183D56040 
	
		// Methods
		public bool IsValid() => default; // 0x0000000185799A3C-0x0000000185799AB8
		public void SetIntensity(int idx, float value) {} // 0x000000018276B1A0-0x000000018276B230
		public void SetFlashIntensity(int idx, float value) {} // 0x000000018276B110-0x000000018276B1A0
		public void SetFlash(int idx, bool value) {} // 0x000000018276B230-0x000000018276B2D0
		public void SetFlashDuration(int idx, float value) {} // 0x000000018276B080-0x000000018276B110
		public void SetColor(int idx, UnityEngine.Color value) {} // 0x000000018276B2D0-0x000000018276B430
		public void SetFlashColor(int idx, UnityEngine.Color value) {} // 0x000000018276B430-0x000000018276B590
		public float GetIntensity(int idx) => default; // 0x00000001857999E0-0x0000000185799A3C
		public float GetFlashIntensity(int idx) => default; // 0x0000000185799924-0x0000000185799980
		public bool GetFlash(int idx) => default; // 0x0000000185799980-0x00000001857999E0
		public float GetFlashDuration(int idx) => default; // 0x00000001857998C4-0x0000000185799924
		public float4 GetColor(int idx) => default; // 0x0000000185799674-0x000000018579979C
		public float4 GetFlashColor(int idx) => default; // 0x000000018579979C-0x00000001857998C4
		private void __AOT_FOR_FIX__() {} // 0x0000000185799AB8-0x0000000185799BFC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeEffectFragment : IComponentECS // TypeDefIndex: 48761
	{
		// Fields
		public IntData32<uint> pipeEffectInstanceId; // 0x00
		public FixedString64Bytes inEffectName; // 0x88
		public FixedString64Bytes outEffectName; // 0xC8
		public FixedString64Bytes inEffectConnectedName; // 0x108
		public FixedString64Bytes outEffectConnectedName; // 0x148
		public const int ID = 87; // Metadata: 0x01FBBA33
	
		// Properties
		public int id { get => default; } // 0x0000000183D56060-0x0000000183D56070 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185799E44-0x0000000185799F88
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeFragment : IComponentECS, ILogisticSample // TypeDefIndex: 48762
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
		public uint startMemoryOffsetHandle; // 0x74
		public uint endMemoryOffsetHandle; // 0x78
		public const int ID = 88; // Metadata: 0x01FBBA3F
	
		// Properties
		public int length { [IsReadOnly] get; private set; } // 0x0000000183D4F0C0-0x0000000183D4F0D0 0x0000000183D4F0F0-0x0000000183D4F100
		public int id { get => default; } // 0x0000000183D56070-0x0000000183D56080 
	
		// Constructors
		static PipeFragment() {
			PIPE_HEIGHT = default;
		} // 0x0000000183D43EA0-0x0000000183D43EE0
	
		// Methods
		public bool SetInflection(ref GlobalEnv env, ref NativeList<float3> p, ref NativeList<float3> r, ref NativeList<byte> proto) => default; // 0x0000000182A8D600-0x0000000182A8DAB0
		public static void Bend(ref GlobalEnv env, int pipeLength, uint startMemoryOffsetHandle, float pipeHeight, bool bOverrideEntranceY = false /* Metadata: 0x01FBBA35 */, float overrideEntranceY = 0f /* Metadata: 0x01FBBA36 */, bool bOverrideExitY = false /* Metadata: 0x01FBBA3A */, float overrideExitY = 0f /* Metadata: 0x01FBBA3B */) {} // 0x0000000182A8BED0-0x0000000182A8C040
		public static ValueTuple<int[], int> GetCornerIndexList(ref GlobalEnv env, uint startMemoryOffsetHandle, int length) => default; // 0x0000000182AAF1E0-0x0000000182AAF300
		public bool Sample(ref GlobalEnv env, float2 p, out uint unitId, out int indexInPipe) {
			unitId = default;
			indexInPipe = default;
			return default;
		} // 0x00000001824FB6F0-0x00000001824FB9D0
		public bool IsInRect(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax) => default; // 0x000000018579A1C8-0x000000018579A38C
		public bool GetInRectUnitIndex(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref PooledList<int> unitIndex) => default; // 0x00000001828BF7C0-0x00000001828BFA00
		public bool FillRectTargets(ref GlobalEnv env, float xMin, float xMax, float yMin, float yMax, ref ValueTuple<uint, int>[,] rectTargets) => default; // 0x0000000185799F88-0x000000018579A1C8
		private void __AOT_FOR_FIX__() {} // 0x000000018579A38C-0x000000018579A4C8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeHolderFragment : IComponentECS // TypeDefIndex: 48763
	{
		// Fields
		public int indexInPipe; // 0x00
		public Entity pipeEntity; // 0x04
		public const int ID = 89; // Metadata: 0x01FBBA41
	
		// Properties
		public int id { get => default; } // 0x0000000183D56080-0x0000000183D56090 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579A4C8-0x000000018579A5E4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeLogisticsUnitFragment : IComponentECS // TypeDefIndex: 48764
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 90; // Metadata: 0x01FBBA43
	
		// Properties
		public int id { get => default; } // 0x0000000183D56090-0x0000000183D560A0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579A5E4-0x000000018579A6F0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeComRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48765
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 91; // Metadata: 0x01FBBA45
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D56050-0x0000000183D56060 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x0000000185799D28-0x0000000185799E44
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct PipeRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48766
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int indexInPipe; // 0x04
		public FixedString32Bytes prototype; // 0x08
		public float3 position; // 0x28
		public float scale; // 0x34
		public quaternion rotation; // 0x38
		public HGFactoryEntityTransformData transformData; // 0x28
		public const int ID = 92; // Metadata: 0x01FBBA47
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D560D0-0x0000000183D560E0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579AA24-0x000000018579AB48
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PipeTrackRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48767
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public float3 position; // 0x04
		public quaternion rotation; // 0x10
		public const int ID = 93; // Metadata: 0x01FBBA49
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D560E0-0x0000000183D560F0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x000000018579AB48-0x000000018579AC64
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ComplexPortFragment : IComponentECS, IEquatable<ComplexPortFragment> // TypeDefIndex: 48768
	{
		// Fields
		public PortData32<Beyond.Gameplay.Factory.PortData> ports; // 0x00
		public int2 pedestalPortCount; // 0x808
		public int2 pipePortCount; // 0x810
		public bool dataInit; // 0x818
		public const int ID = 94; // Metadata: 0x01FBBA4F
	
		// Properties
		public int id { get => default; } // 0x0000000183D55AB0-0x0000000183D55AC0 
	
		// Methods
		public bool BindComponentId(uint componentId, int idx, bool isInput, bool isBlock, uint touchComId, out bool pipeChanged) {
			pipeChanged = default;
			return default;
		} // 0x00000001828B67B0-0x00000001828B6A90
		public bool BlockPortsWithComponentId(uint componentId, bool isBlock, int[] portIndices) => default; // 0x0000000185792B24-0x0000000185792CA4
		public bool BlockPorts(bool isBlock, List<int> portIndices, bool input) => default; // 0x00000001828B7240-0x00000001828B7410
		public void FollowUnit(float3 worldPos, float3 worldDir, ref GlobalSharedData.UnitPortConfig portConfig, ref UnitConfigFragment unitConfig, float effectOffset = 0.5f /* Metadata: 0x01FBBA4B */) {} // 0x00000001828B6A90-0x00000001828B7240
		public bool AnyPortBlocked() => default; // 0x00000001857929B0-0x0000000185792A6C
		public bool AnyPortConnected() => default; // 0x0000000185792A6C-0x0000000185792B24
		[IDTag(0)]
		public bool Equals(ComplexPortFragment other) => default; // 0x0000000185792D60-0x0000000185792F54
		[IDTag(1)]
		public override bool Equals(object obj) => default; // 0x0000000185792CA4-0x0000000185792D60
		public override int GetHashCode() => default; // 0x0000000185792F54-0x0000000185793148
		public static bool operator ==(ComplexPortFragment left, ComplexPortFragment right) => default; // 0x0000000185793510-0x00000001857935D4
		public static bool operator !=(ComplexPortFragment left, ComplexPortFragment right) => default; // 0x00000001857935D4-0x0000000185793698
		public override string ToString() => default; // 0x0000000185793148-0x0000000185793290
		private void __AOT_FOR_FIX__() {} // 0x00000001857933C4-0x0000000185793510
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x0000000185793290-0x0000000185793304
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000185793304-0x0000000185793364
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185793364-0x00000001857933C4
	}

	public struct PortData : IEquatable<Beyond.Gameplay.Factory.PortData> // TypeDefIndex: 48769
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
		public float4x4 TRS() => default; // 0x00000001857A698C-0x00000001857A6A5C
		[IDTag(0)]
		public bool Equals(PortData other) => default; // 0x00000001857A666C-0x00000001857A67C4
		[IDTag(1)]
		public override bool Equals(object obj) => default; // 0x00000001857A65B4-0x00000001857A666C
		public override int GetHashCode() => default; // 0x00000001857A67C4-0x00000001857A698C
		public static bool operator ==(PortData left, PortData right) => default; // 0x00000001857A6E40-0x00000001857A6F00
		public static bool operator !=(PortData left, PortData right) => default; // 0x00000001857A6F00-0x00000001857A6FC4
		public override string ToString() => default; // 0x00000001857A6A5C-0x00000001857A6D10
		public string __iFixBaseProxy_ToString() => default; // 0x00000001857A6DE0-0x00000001857A6E40
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x00000001857A6D10-0x00000001857A6D80
		public int __iFixBaseProxy_GetHashCode() => default; // 0x00000001857A6D80-0x00000001857A6DE0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PortPreviewUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48770
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 95; // Metadata: 0x01FBBA51
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D56380-0x0000000183D56390 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A6FC4-0x00000001857A70D0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PortStatusUIFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48771
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 96; // Metadata: 0x01FBBA53
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D56390-0x0000000183D563A0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A70D0-0x00000001857A71DC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct PowerPoleFragment : IComponentECS // TypeDefIndex: 48772
	{
		// Fields
		public const int ID = 97; // Metadata: 0x01FBBA55
	
		// Properties
		public int id { get => default; } // 0x0000000183D563A0-0x0000000183D563B0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A71DC-0x00000001857A72E8
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ProducerFragment : IComponentECS // TypeDefIndex: 48773
	{
		// Fields
		public uint componentId; // 0x00
		public long currentProgress; // 0x08
		public uint formulaId; // 0x10
		public uint lastFormulaId; // 0x14
		public const int ID = 98; // Metadata: 0x01FBBA57
	
		// Properties
		public uint outputFormulaId { get => default; } // 0x0000000182752540-0x0000000182752550 
		public int id { get => default; } // 0x0000000183D563B0-0x0000000183D563C0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A72E8-0x00000001857A7408
	}

	[BurstCompatible]
	[ECSComponent]
	public struct SharedDataFragment : IComponentECS // TypeDefIndex: 48774
	{
		// Fields
		public uint dataHandle; // 0x00
		public const int ID = 99; // Metadata: 0x01FBBA59
	
		// Properties
		public int id { get => default; } // 0x0000000183D563E0-0x0000000183D563F0 
	
		// Methods
		public ref SharedDataContainer.SharedExtData GetExtData() => ref _refReturnTypeForGetExtData; // 0x00000001824FD3F0-0x00000001824FD550
		private ref SharedDataContainer.SharedExtData _refReturnTypeForGetExtData; // Dummy field
		public void DestroyData() {} // 0x0000000183854080-0x00000001838540C0
		private void __AOT_FOR_FIX__() {} // 0x00000001857A7FE4-0x00000001857A80F0
	}

	public enum SocialBuildingStates : uint // TypeDefIndex: 48775
	{
		Invalid = 0,
		Disable = 1,
		Unlocked = 2,
		Activated = 3,
		Locked = 4
	}

	[BurstCompatible]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct SocialFragment : IComponentECS // TypeDefIndex: 48777
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
		public const int ID = 100; // Metadata: 0x01FBBA60
	
		// Properties
		public int id { get => default; } // 0x0000000183D563F0-0x0000000183D56400 
	
		// Nested types
		[Flags]
		public enum EOwner // TypeDefIndex: 48776
		{
			MINE = 1,
			OTHERS = 2,
			ALL = 3
		}
	
		// Methods
		public static SocialFragment Create(ulong ownerId, uint socialNodeId, ulong like, long lastSetLikeTs, long expirationTs, uint socialState, bool isPreset) => default; // 0x00000001829BCFF0-0x00000001829BD0D0
		public bool IsHighLiked() => default; // 0x0000000182F870F0-0x0000000182F871E0
		public bool IsLiked() => default; // 0x00000001857A8288-0x00000001857A8304
		private void __AOT_FOR_FIX__() {} // 0x00000001857A8304-0x00000001857A842C
	}

	public struct SignData // TypeDefIndex: 48778
	{
		// Fields
		public uint3 content; // 0x00
		public const int CONTENT_LENGTH = 3; // Metadata: 0x01FBBA65
	
		// Methods
		public string GetText() => default; // 0x00000001857A80F0-0x00000001857A8288
		public static float GetCustomPerDrawData(FactoryUIAtlasSOData config, uint3 content) => default; // 0x0000000182F887D0-0x0000000182F889B0
		public static void SetSignBuildingIcon(FactoryUIAtlasSOData data, ref EntityManager em, Entity logicEntity) {} // 0x0000000182F877C0-0x0000000182F87A40
		public static void SetSignBuildingIconWithRenderEntity(FactoryUIAtlasSOData config, Entity rEntity, uint3 iconId) {} // 0x0000000182F882B0-0x0000000182F887D0
	}

	[Serializable]
	[BurstCompatible]
	[BurstCompile]
	[ECSComponent(layoutKind = LayoutKind.Explicit)]
	public struct LocalTransform : IComponentECS // TypeDefIndex: 48779
	{
		// Fields
		public float3 position; // 0x00
		public float scale; // 0x0C
		public quaternion rotation; // 0x10
		public HGFactoryEntityTransformData entityTransformData; // 0x00
		public static readonly LocalTransform Identity; // 0x00
		public const int ID = 101; // Metadata: 0x01FBBA66
	
		// Properties
		public int id { get => default; } // 0x0000000183D562A0-0x0000000183D562B0 
	
		// Constructors
		static LocalTransform() {
			Identity = default;
		} // 0x0000000183CBD130-0x0000000183CBD1D0
	
		// Methods
		public static LocalTransform FromMatrix(float4x4 matrix) => default; // 0x00000001857A458C-0x00000001857A4838
		public static LocalTransform FromMatrixSafe(float4x4 matrix) => default; // 0x00000001857A4028-0x00000001857A458C
		public static LocalTransform FromPositionRotation(float3 position, quaternion rotation) => default; // 0x00000001857A4838-0x00000001857A4904
		public static LocalTransform FromPositionRotationScale(float3 position, quaternion rotation, float scale) => default; // 0x000000018276A190-0x000000018276A220
		[IDTag(0)]
		public static LocalTransform FromPosition(float3 position) => default; // 0x00000001857A49EC-0x00000001857A4ABC
		[IDTag(1)]
		public static LocalTransform FromPosition(float x, float y, float z) => default; // 0x00000001857A4904-0x00000001857A49EC
		public static LocalTransform FromRotation(quaternion rotation) => default; // 0x00000001857A4ABC-0x00000001857A4B84
		public static LocalTransform FromScale(float scale) => default; // 0x00000001857A4B84-0x00000001857A4C5C
		public override string ToString() => default; // 0x00000001857A5710-0x00000001857A5874
		public float3 Right() => default; // 0x00000001857A5208-0x00000001857A52D4
		public float3 Up() => default; // 0x00000001857A5A84-0x00000001857A5B5C
		public float3 Forward() => default; // 0x00000001857A3F50-0x00000001857A4028
		public float3 TransformPoint(float3 point) => default; // 0x00000001830B6370-0x00000001830B6450
		public float3 InverseTransformPoint(float3 point) => default; // 0x00000001857A4D34-0x00000001857A4E70
		public float3 TransformDirection(float3 direction) => default; // 0x00000001857A5874-0x00000001857A5934
		public float3 InverseTransformDirection(float3 direction) => default; // 0x00000001857A4C5C-0x00000001857A4D34
		public quaternion TransformRotation(quaternion rotation) => default; // 0x00000001830B6300-0x00000001830B6370
		public quaternion InverseTransformRotation(quaternion rotation) => default; // 0x00000001857A4E70-0x00000001857A4F30
		public float TransformScale(float scale) => default; // 0x00000001830B62C0-0x00000001830B6300
		public float InverseTransformScale(float scale) => default; // 0x00000001857A4F30-0x00000001857A4F90
		public LocalTransform TransformTransform([IsReadOnly] in LocalTransform transformData) => default; // 0x00000001830B6160-0x00000001830B62C0
		public LocalTransform InverseTransformTransform([IsReadOnly] in LocalTransform transformData) => default; // 0x00000001857A4F90-0x00000001857A50C8
		public LocalTransform Inverse() => default; // 0x00000001857A50C8-0x00000001857A5208
		public float4x4 ToMatrix() => default; // 0x00000001828B4C60-0x00000001828B4E70
		public float4x4 ToInverseMatrix() => default; // 0x00000001857A5634-0x00000001857A5710
		[IDTag(0)]
		public LocalTransform WithPosition(float3 p) => default; // 0x00000001857A5B5C-0x00000001857A5C18
		[IDTag(1)]
		public LocalTransform WithPosition(float x, float y, float z) => default; // 0x00000001857A5C18-0x00000001857A5CF8
		public LocalTransform WithRotation(quaternion r) => default; // 0x00000001857A5CF8-0x00000001857A5DB0
		public LocalTransform WithScale(float s) => default; // 0x00000001857A5DB0-0x00000001857A5E54
		public LocalTransform Translate(float3 translation) => default; // 0x00000001857A5934-0x00000001857A5A2C
		public LocalTransform ApplyScale(float scale) => default; // 0x00000001857A3DFC-0x00000001857A3EA8
		public LocalTransform Rotate(quaternion rotation) => default; // 0x00000001857A5550-0x00000001857A5634
		public LocalTransform RotateX(float angle) => default; // 0x00000001857A52D4-0x00000001857A53A8
		public LocalTransform RotateY(float angle) => default; // 0x00000001857A53A8-0x00000001857A547C
		public LocalTransform RotateZ(float angle) => default; // 0x00000001857A547C-0x00000001857A5550
		public bool Equals([IsReadOnly] in LocalTransform other) => default; // 0x00000001857A3EA8-0x00000001857A3F50
		private void __AOT_FOR_FIX__() {} // 0x00000001857A5E54-0x00000001857A5F70
		public string __iFixBaseProxy_ToString() => default; // 0x00000001857A5A2C-0x00000001857A5A84
	}

	[BurstCompatible]
	[ECSComponent]
	public struct Root : IComponentECS // TypeDefIndex: 48780
	{
		// Fields
		public const int ID = 102; // Metadata: 0x01FBBA68
	
		// Properties
		public int id { get => default; } // 0x0000000183D563D0-0x0000000183D563E0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A7A94-0x00000001857A7BA0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct Parent : IComponentECS // TypeDefIndex: 48781
	{
		// Fields
		public Entity value; // 0x00
		public const int ID = 103; // Metadata: 0x01FBBA6A
	
		// Properties
		public int id { get => default; } // 0x0000000183D56370-0x0000000183D56380 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A5FD4-0x00000001857A60E0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct Child : IComponentECS // TypeDefIndex: 48782
	{
		// Fields
		public EntityData32<Entity> value; // 0x00
		public const int ID = 104; // Metadata: 0x01FBBA6C
	
		// Properties
		public int id { get => default; } // 0x0000000183D56220-0x0000000183D56230 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A2850-0x00000001857A2994
	}

	[BurstCompatible]
	[ECSComponent]
	public struct LocalToWorld : IComponentECS // TypeDefIndex: 48783
	{
		// Fields
		public float4x4 READ_ONLY_VAL; // 0x00
		public float4x4 PRE_FRAME_READ_ONLY_VAL; // 0x40
		public uint hierarchyHandle; // 0x80
		public bool dirty; // 0x84
		public int calcFrameCount; // 0x88
		public const int ID = 105; // Metadata: 0x01FBBA6E
	
		// Properties
		public float3 right { get => default; } // 0x00000001857A3D0C-0x00000001857A3D84 
		public float3 up { get => default; } // 0x00000001857A3D84-0x00000001857A3DFC 
		public float3 forward { get => default; } // 0x00000001857A3B64-0x00000001857A3BDC 
		public float3 position { get => default; } // 0x00000001828B41D0-0x00000001828B4260 
		public quaternion rotation { get => default; } // 0x00000001828B4E70-0x00000001828B52E0 
		public float3 prePosition { get => default; } // 0x00000001857A3BDC-0x00000001857A3C54 
		public quaternion preRotation { get => default; } // 0x00000001857A3C54-0x00000001857A3D0C 
		public unsafe float4x4* READ_ONLY_VAL_PTR { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		public unsafe float4x4* PRE_FRAME_READ_ONLY_VAL_PTR { get => default; } // 0x0000000183D56280-0x0000000183D56290 
		public int id { get => default; } // 0x0000000183D56290-0x0000000183D562A0 
	
		// Methods
		public bool SetValue(float4x4 value, int frameCount) => default; // 0x00000001828B47E0-0x00000001828B48A0
		private void __AOT_FOR_FIX__() {} // 0x00000001857A3A24-0x00000001857A3B64
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UdPipeFragment : IComponentECS // TypeDefIndex: 48784
	{
		// Fields
		public ulong connectedCompId; // 0x00
		public int offset; // 0x08
		public const int ID = 106; // Metadata: 0x01FBBA70
	
		// Properties
		public int id { get => default; } // 0x0000000183D564A0-0x0000000183D564B0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A8700-0x00000001857A8818
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitConfigFragment : IComponentECS // TypeDefIndex: 48785
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public int powerCost; // 0x04
		public bool isShowOutputUI; // 0x08
		public bool needPower; // 0x09
		public bool hidePreviewArrow; // 0x0A
		public short inputPortCount; // 0x0C
		public short outputPortCount; // 0x0E
		public int facBuildingType; // 0x10
		public float3 bounds; // 0x14
		public int unitNameFastString; // 0x20
		public int iconOnPanelFastString; // 0x24
		public UnitConfigInternal baseConfig; // 0x28
		public const int ID = 107; // Metadata: 0x01FBBA72
	
		// Properties
		public string iconOnPanel { get => default; set {} } // 0x0000000184272998-0x00000001842729A4 0x0000000184274E78-0x0000000184274E98
		public string unitName { get => default; set {} } // 0x00000001857A8940-0x00000001857A894C 0x00000001857A894C-0x00000001857A896C
		public int id { get => default; } // 0x0000000183D564B0-0x0000000183D564C0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A8818-0x00000001857A8940
	}

	[Serializable]
	public struct UnitConfigInternal // TypeDefIndex: 48786
	{
		// Fields
		public Bounds bounds; // 0x00
		public Bounds buildingBounds; // 0x18
	}

	[Serializable]
	public struct FactoryUnitPortConfig // TypeDefIndex: 48787
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
	public struct FactoryUnitExtendConfig // TypeDefIndex: 48788
	{
		// Fields
		[HideInInspector]
		public FixedString32Bytes nameRaw; // 0x00
		public float3 pos; // 0x20
		public quaternion rot; // 0x2C
	
		// Properties
		public string name { get => default; } // 0x0000000184270A90-0x0000000184270A98 
		public int unLoaderIndex { [IsReadOnly] get; set; } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x0000000183D4EDC0-0x0000000183D4EDD0
		public bool isUnLoader { [IsReadOnly] get; set; } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
	
		// Methods
		public override string ToString() => default; // 0x00000001857A2E9C-0x00000001857A308C
		public string __iFixBaseProxy_ToString() => default; // 0x00000001857A308C-0x00000001857A30FC
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitInteractFragment : IComponentECS // TypeDefIndex: 48789
	{
		// Fields
		public ulong interactObjectId; // 0x00
		public const int ID = 108; // Metadata: 0x01FBBA74
	
		// Properties
		public int id { get => default; } // 0x0000000183D564C0-0x0000000183D564D0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A8AB8-0x00000001857A8BC4
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitRenderFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48790
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
		public const int ID = 109; // Metadata: 0x01FBBA76
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4EEC0-0x0000000183D4EED0 0x0000000183D4EF10-0x0000000183D4EF20
		public int id { get => default; } // 0x0000000183D564E0-0x0000000183D564F0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A8FC8-0x00000001857A90F0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct RenderLookAtFragment : IComponentECS // TypeDefIndex: 48791
	{
		// Fields
		public bool lookAtEnable; // 0x00
		public bool lookAtArrived; // 0x01
		public bool yawEnabled; // 0x02
		public bool pitchEnabled; // 0x03
		public quaternion deltaQuaternion; // 0x04
		public float3 targetPos; // 0x14
		public half interpolation; // 0x20
		public const int ID = 110; // Metadata: 0x01FBBA78
	
		// Properties
		public int id { get => default; } // 0x0000000183D563C0-0x0000000183D563D0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A7970-0x00000001857A7A94
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ChapterTagFragment : IComponentECS // TypeDefIndex: 48792
	{
		// Fields
		public int chapterId; // 0x00
		public int mapId; // 0x04
		public int panelIndex; // 0x08
		public int sceneId; // 0x0C
		public const int ID = 111; // Metadata: 0x01FBBA7A
	
		// Properties
		public int id { get => default; } // 0x0000000183D56210-0x0000000183D56220 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A2738-0x00000001857A2850
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitStatusFragment : IComponentECS // TypeDefIndex: 48793
	{
		// Fields
		public byte preStatus; // 0x00
		public byte status; // 0x01
		public byte subStatus; // 0x02
		public const int ID = 112; // Metadata: 0x01FBBA7C
	
		// Properties
		public int id { get => default; } // 0x0000000183D56500-0x0000000183D56510 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A923C-0x00000001857A9350
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitOverrideStatusFragment : IComponentECS // TypeDefIndex: 48794
	{
		// Fields
		public bool working; // 0x00
		public const int ID = 113; // Metadata: 0x01FBBA7E
	
		// Properties
		public int id { get => default; } // 0x0000000183D564D0-0x0000000183D564E0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A8BC4-0x00000001857A8CD0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitStatusEffectFragment : IComponentECS // TypeDefIndex: 48795
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
		public const int ID = 114; // Metadata: 0x01FBBA80
	
		// Properties
		public int id { get => default; } // 0x0000000183D564F0-0x0000000183D56500 
	
		// Methods
		public void SetEffects(BuildingStatus buildingStatus, FacEffectCfgList cfgList) {} // 0x0000000182EC6620-0x0000000182EC8C80
		public FixedList512Bytes<StatusSingleEffect> GetEffect(FacBuildingState status) => default; // 0x00000001829BF710-0x00000001829BFB00
		private void __AOT_FOR_FIX__() {} // 0x00000001857A90F0-0x00000001857A923C
	}

	public struct StatusNormalEffect // TypeDefIndex: 48796
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusClosedEffect // TypeDefIndex: 48797
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusIdleEffect // TypeDefIndex: 48798
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusBlockedEffect // TypeDefIndex: 48799
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusNoPowerEffect // TypeDefIndex: 48800
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusNotInPowerNetEffect // TypeDefIndex: 48801
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusFixableEffect // TypeDefIndex: 48802
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusBrokenEffect // TypeDefIndex: 48803
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusOverloadEffect // TypeDefIndex: 48804
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	public struct StatusBusDisconnectEffect // TypeDefIndex: 48805
	{
		// Fields
		public FixedList512Bytes<StatusSingleEffect> effectSetting; // 0x00
	}

	[Serializable]
	public struct StatusSingleEffect // TypeDefIndex: 48806
	{
		// Fields
		public BuildingSubState subState; // 0x00
		[HideInInspector]
		public FixedString64Bytes name; // 0x02
		public float3 offset; // 0x44
		public bool needAlignToBuilding; // 0x50
	
		// Properties
		public string effectName { get => default; set {} } // 0x00000001829BF4A0-0x00000001829BF5F0 0x00000001857A842C-0x00000001857A8484
	}

	[Serializable]
	public class FacEffectCfgList // TypeDefIndex: 48807
	{
		// Fields
		public List<StatusSingleEffect> list; // 0x10
	
		// Properties
		public int cfgCount { get => default; } // 0x00000001857A2D8C-0x00000001857A2DCC 
	
		// Constructors
		public FacEffectCfgList() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public enum BuildingStatus // TypeDefIndex: 48808
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

	[Flags]
	public enum BuildingSubState : byte // TypeDefIndex: 48809
	{
		NONE = 0,
		SUB_STATE_1 = 1,
		SUB_STATE_2 = 2,
		SUB_STATE_3 = 4,
		SUB_STATE_4 = 8,
		ANY = 15
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitStatusUIRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48810
	{
		// Fields
		public const int ID = 115; // Metadata: 0x01FBBA95
	
		// Properties
		public int unitConfigAssetInstanceId { [IsReadOnly] get; set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D56510-0x0000000183D56520 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A9350-0x00000001857A945C
	}

	[BurstCompatible]
	[ECSComponent]
	public struct UnitTransFragment : IComponentECS, IRotateFragment, IPositionFragment // TypeDefIndex: 48811
	{
		// Fields
		public float3 __position; // 0x00
		public float3 __rotation; // 0x0C
		public float3 cornerLD; // 0x18
		public float3 cornerRU; // 0x24
		public const int ID = 116; // Metadata: 0x01FBBA98
	
		// Properties
		public quaternion RotationQuaternion { get => default; } // 0x0000000182503F00-0x0000000182503FA0 
		public float3 Position { get => default; set {} } // 0x0000000183D56520-0x0000000183D56540 0x0000000183D56570-0x0000000183D56580
		public float3 Rotation { get => default; set {} } // 0x0000000183D56540-0x0000000183D56560 0x0000000183D56580-0x0000000183D56590
		public int id { get => default; } // 0x0000000183D56560-0x0000000183D56570 
	
		// Methods
		public bool InBound(float3 pos, bool ignoreY = true /* Metadata: 0x01FBBA97 */) => default; // 0x00000001857A945C-0x00000001857A95F0
		private void __AOT_FOR_FIX__() {} // 0x00000001857A95F0-0x00000001857A9714
	}

	[BurstCompatible]
	[ECSComponent]
	public struct ValveFragment : IComponentECS // TypeDefIndex: 48812
	{
		// Fields
		public bool enable; // 0x00
		public uint selectedItemId; // 0x04
		public int passed; // 0x08
		public int currentPassed; // 0x0C
		public FactoryItem holdItem; // 0x10
		public const int ID = 117; // Metadata: 0x01FBBA9A
	
		// Properties
		public int id { get => default; } // 0x0000000183D56590-0x0000000183D565A0 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A9F44-0x00000001857AA060
	}

	[BurstCompatible]
	[ECSComponent]
	public struct BoxValve : IComponentECS // TypeDefIndex: 48813
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 118; // Metadata: 0x01FBBA9C
	
		// Properties
		public int id { get => default; } // 0x0000000183D56200-0x0000000183D56210 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A262C-0x00000001857A2738
	}

	[BurstCompatible]
	[ECSComponent]
	public struct FluidValve : IComponentECS // TypeDefIndex: 48814
	{
		// Fields
		public byte placeHolder; // 0x00
		public const int ID = 119; // Metadata: 0x01FBBA9E
	
		// Properties
		public int id { get => default; } // 0x0000000183D56270-0x0000000183D56280 
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857A30FC-0x00000001857A3208
	}

	public struct BlueprintSlotInfo // TypeDefIndex: 48822
	{
		// Fields
		public const int RELATED_SLOT_ID = -1; // Metadata: 0x01FBBAA1
		public const int SLOT_MAX_COUNT = 6; // Metadata: 0x01FBBAA2
		public const int UNIT_MAX_COUNT_PER_SLOT = 256; // Metadata: 0x01FBBAA3
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo0[0]; // 0x00
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo1[0]; // 0x800
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo2[0]; // 0x1000
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo3[0]; // 0x1800
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo4[0]; // 0x2000
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintSlotInfo5[0]; // 0x2800
		private unsafe fixed /* 0x00000000-0x00000000 */ ulong m_blueprintRelatedSlotInfo[0]; // 0x3000
	
		// Methods
		public bool ContainsNodeId(ref EntityManager em, int slotId, int nodeId) => default; // 0x00000001857A1ADC-0x00000001857A1C0C
		public void RemoveEntityFromSlot(ref EntityManager em, int slotId, Entity overdueEntity) {} // 0x00000001857A1F5C-0x00000001857A2060
		public int FindEmptySlotIdx() => default; // 0x00000001857A1C0C-0x00000001857A1C80
		public int GetSuitableSlotIdx(int slotId) => default; // 0x00000001857A1ED4-0x00000001857A1F5C
		public void SetSlotId(int index, int slotId) {} // 0x00000001857A2060-0x00000001857A20DC
		public ulong[] GetSlotIds() => default; // 0x0000000182D077E0-0x0000000182D07880
		public void AppendSlotInfo(int slotId, Entity logicEntity) {} // 0x00000001857A196C-0x00000001857A1A4C
		public Entity[] ClearSlotInfo(int slotId) => default; // 0x00000001857A1A4C-0x00000001857A1ADC
		private unsafe Entity[] _ClearSlotInfo(ulong* slotGroupPtr) => default; // 0x00000001857A24FC-0x00000001857A262C
		public void DiffSlotInfo(ref EntityManager em, int slotId, ref PooledList<uint> baseList, ref PooledList<uint> newList, ref PooledList<Entity> overdueList) {} // 0x0000000182AD3B40-0x0000000182AD3D20
		public NativeArray<Entity> GetAllPendingEntitiesInSlot(int slotId) => default; // 0x00000001857A1C80-0x00000001857A1D90
		public Entity GetSlotInfo(int slotId, int index) => default; // 0x00000001857A1E10-0x00000001857A1ED4
		public ulong GetPendingEntityCountInSlot(int slotId) => default; // 0x00000001857A1D90-0x00000001857A1E10
		public unsafe ulong* GetSlotGroupWithSlotId(int slotId, out int slotIdx, bool includeInvalid = true /* Metadata: 0x01FBBAA0 */) {
			slotIdx = default;
			return default;
		} // 0x0000000182AD3D20-0x0000000182AD3D70
		public unsafe ulong* GetRelatedSlotGroup() => default; // 0x0000000183D561F0-0x0000000183D56200
		public unsafe ulong* GetSlotGroup(int index) => default; // 0x0000000182D07880-0x0000000182D07910
		public static BlueprintSlotInfo CreateDefault() => default; // 0x0000000182D06FF0-0x0000000182D07070
		public override string ToString() => default; // 0x00000001857A20DC-0x00000001857A247C
		public string __iFixBaseProxy_ToString() => default; // 0x00000001857A247C-0x00000001857A24FC
	}

	[DataN(capacity = 4096, tSize = 72, ring = false)]
	[NoAlias]
	public struct CargoRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 48825
		where T : struct
	{
		// Fields
		public const int T_SIZE = 72; // Metadata: 0x01FBBAA8
		public const int CAPACITY = 4096; // Metadata: 0x01FBBAAA
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x01FBBAAC
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBBAAE
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48823
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
			public Enumerator([IsReadOnly] in CargoRendererInfoCollection<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe CargoRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x01FBBAA5 */, bool autoExtend = false /* Metadata: 0x01FBBAA7 */) : this() {
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

	public struct CargoRendererInfo // TypeDefIndex: 48826
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
	public struct ConveyorRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 48829
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x01FBBAB2
		public const int CAPACITY = 4096; // Metadata: 0x01FBBAB4
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x01FBBAB6
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBBAB8
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48827
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
			public Enumerator([IsReadOnly] in ConveyorRendererInfoCollection<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe ConveyorRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x01FBBAAF */, bool autoExtend = false /* Metadata: 0x01FBBAB1 */) : this() {
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

	public struct ConveyorRendererInfo // TypeDefIndex: 48830
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
		public override string ToString() => default; // 0x00000001857A2994-0x00000001857A2D24
		public string __iFixBaseProxy_ToString() => default; // 0x00000001857A2D24-0x00000001857A2D8C
	}

	public struct FactoryItem // TypeDefIndex: 48831
	{
		// Fields
		public uint itemId; // 0x00
		public int itemAmount; // 0x04
		public long tms; // 0x08
	}

	[DataN(capacity = 4096, tSize = 96, ring = false)]
	[NoAlias]
	public struct PipeRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 48834
		where T : struct
	{
		// Fields
		public const int T_SIZE = 96; // Metadata: 0x01FBBABC
		public const int CAPACITY = 4096; // Metadata: 0x01FBBABE
		public const int CAPACITY_MINUS_ONE = 4095; // Metadata: 0x01FBBAC0
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBBAC2
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48832
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
			public Enumerator([IsReadOnly] in PipeRendererInfoCollection<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe PipeRendererInfoCollection(int initialCapacity = 4096 /* Metadata: 0x01FBBAB9 */, bool autoExtend = false /* Metadata: 0x01FBBABB */) : this() {
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

	[DataN(capacity = 128, tSize = 64, ring = false)]
	[NoAlias]
	public struct PipeTrackRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 48837
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x01FBBAC6
		public const int CAPACITY = 128; // Metadata: 0x01FBBAC8
		public const int CAPACITY_MINUS_ONE = 127; // Metadata: 0x01FBBACA
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBBACC
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48835
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
			public Enumerator([IsReadOnly] in PipeTrackRendererInfoCollection<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe PipeTrackRendererInfoCollection(int initialCapacity = 128 /* Metadata: 0x01FBBAC3 */, bool autoExtend = false /* Metadata: 0x01FBBAC5 */) : this() {
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

	public struct PipeRendererInfo // TypeDefIndex: 48838
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

	public struct PipeTrackRendererInfo // TypeDefIndex: 48839
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
	public struct PortArrowRendererInfoCollection<T> : IEnumerable<T> // TypeDefIndex: 48842
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x01FBBAD0
		public const int CAPACITY = 2048; // Metadata: 0x01FBBAD2
		public const int CAPACITY_MINUS_ONE = 2047; // Metadata: 0x01FBBAD4
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBBAD6
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 48840
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
			public Enumerator([IsReadOnly] in PortArrowRendererInfoCollection<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe PortArrowRendererInfoCollection(int initialCapacity = 2048 /* Metadata: 0x01FBBACD */, bool autoExtend = false /* Metadata: 0x01FBBACF */) : this() {
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

	public struct PortArrowRendererInfo // TypeDefIndex: 48843
	{
		// Fields
		public float3 pos; // 0x00
		public bool isForbidden; // 0x0C
		public quaternion rot; // 0x10
		public float4 renderColor; // 0x20
		public float4 atlasUV; // 0x30
	}

	public struct UnitId : IEquatable<UnitId> // TypeDefIndex: 48844
	{
		// Fields
		public int mapId; // 0x00
		public uint factoryUnitId; // 0x04
	
		// Methods
		[IDTag(0)]
		public bool Equals(UnitId other) => default; // 0x00000001824FD350-0x00000001824FD3F0
		[IDTag(1)]
		public override bool Equals(object obj) => default; // 0x00000001857A896C-0x00000001857A8A08
		public override int GetHashCode() => default; // 0x00000001824FD0F0-0x00000001824FD180
		public static UnitId Create(int mapId, uint factoryUnitId) => default; // 0x00000001824FD060-0x00000001824FD0F0
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x00000001857A8A08-0x00000001857A8A68
		public int __iFixBaseProxy_GetHashCode() => default; // 0x00000001857A8A68-0x00000001857A8AB8
	}

	public struct Visibility // TypeDefIndex: 48848
	{
		// Fields
		public static Visibility s_defaultVal; // 0x00
		public uint visibleFlags; // 0x00
		public short invisibleSubCount; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte invisibleSubBits[0]; // 0x06
		public const int SUB_INDEX_MAX_COUNT = 128; // Metadata: 0x01FBBAD7
		public const int SUB_BIT_BYTE_COUNT = 16; // Metadata: 0x01FBBAD9
	
		// Properties
		public bool isVisible { get => default; } // 0x00000001824FBD00-0x00000001824FBE80 
	
		// Nested types
		[Flags]
		public enum EFlag // TypeDefIndex: 48845
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
		public enum Type : byte // TypeDefIndex: 48846
		{
			BASE = 1,
			ADDITIVE_MAT = 2
		}
	
		// Constructors
		static Visibility() {
			s_defaultVal = default;
		} // 0x0000000183D0C950-0x0000000183D0C9B0
	
		// Methods
		public bool SetVisible(EFlag flag, bool visible) => default; // 0x0000000182F41F60-0x0000000182F41FF0
		public unsafe bool SetVisible(EFlag flag, bool visible, short* invisibleIndexListPtr, short invisibleIndexCount) => default; // 0x00000001824FB150-0x00000001824FB300
		public bool GetVisible(EFlag flag) => default; // 0x00000001824FBE80-0x00000001824FBF10
		public bool IsSubRendererInvisible(int subIndex) => default; // 0x00000001857AA060-0x00000001857AA0D0
		private static unsafe void _SetSubInvisible(byte* head, int index, bool invisible) {} // 0x00000001857AA0F0-0x00000001857AA11C
		private static unsafe bool _GetSubInvisible(byte* head, int index) => default; // 0x00000001857AA0D0-0x00000001857AA0F0
	}

	[BurstCompatible]
	[ECSComponent]
	public struct WireRendererFragment : IComponentECS, IUnitConfigRef // TypeDefIndex: 48850
	{
		// Fields
		public int unitConfigAssetInstanceId; // 0x00
		public const int ID = 120; // Metadata: 0x01FBBAEB
	
		// Properties
		public int unitAssetInstanceId { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public int id { get => default; } // 0x0000000183D565A0-0x0000000183D565B0 
	
		// Nested types
		public enum Type : byte // TypeDefIndex: 48849
		{
			NORMAL = 0,
			HS_NORMAL = 1,
			DISABLE = 2,
			STRENGTHEN = 3,
			HS_STRENGTHEN = 4,
			STRENGTHEN_DISABLE = 5
		}
	
		// Methods
		private void __AOT_FOR_FIX__() {} // 0x00000001857AA11C-0x00000001857AA228
	}

	public struct GlobalSharedData // TypeDefIndex: 48874
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
		public struct CullingGlobalSetting // TypeDefIndex: 48851
		{
			// Fields
			public bool bOverride; // 0x00
			public CullingDisSetting setting; // 0x04
			public CullingDisSetting overrideSetting; // 0x14
	
			// Properties
			public float sqrCullDis { get => default; set {} } // 0x0000000182501140-0x00000001825011D0 0x0000000183D56240-0x0000000183D56250
			public float sqrUI { get => default; set {} } // 0x0000000182C663C0-0x0000000182C66450 0x0000000183D56250-0x0000000183D56260
			public float sqrBuildingName { get => default; set {} } // 0x0000000182C66380-0x0000000182C663C0 0x0000000183D56230-0x0000000183D56240
			public float sqrWireCullDis { get => default; set {} } // 0x0000000182765B90-0x0000000182765BD0 0x0000000183D56260-0x0000000183D56270
	
			// Methods
			public void ResetOverride() {} // 0x0000000183102240-0x0000000183102270
		}
	
		[Serializable]
		public struct CullingDisSetting // TypeDefIndex: 48852
		{
			// Fields
			public float sqrCullDis; // 0x00
			public float sqrBuildingName; // 0x04
			public float sqrUI; // 0x08
			public float sqrWireCullDis; // 0x0C
		}
	
		public struct NearByDistanceGlobalSetting // TypeDefIndex: 48853
		{
			// Fields
			public bool bOverride; // 0x00
			public NearByDistanceSetting setting; // 0x04
			public NearByDistanceSetting overrideSetting; // 0x20
	
			// Properties
			public bool nearByCheck { get => default; set {} } // 0x0000000182BBE240-0x0000000182BBE2C0 0x0000000183D56330-0x0000000183D56340
			public float portPreviewCheckDistance { get => default; set {} } // 0x0000000182BC01E0-0x0000000182BC0220 0x0000000183D56350-0x0000000183D56360
			public float pedestalFlashCheckDistance { get => default; set {} } // 0x0000000182BBE1C0-0x0000000182BBE200 0x0000000183D56340-0x0000000183D56350
			public float logisticEffectCheckDistance { get => default; set {} } // 0x0000000182BBE200-0x0000000182BBE240 0x0000000183D56320-0x0000000183D56330
			public float unitRendererCheckDistance { get => default; set {} } // 0x0000000182BBB290-0x0000000182BBB2D0 0x0000000183D56360-0x0000000183D56370
			public float l2wCheckDistance { get => default; set {} } // 0x0000000182BBEB80-0x0000000182BBED60 0x0000000183D56310-0x0000000183D56320
			public float additiveEffectCheckDistance { get => default; set {} } // 0x0000000182BBED60-0x0000000182BBEDA0 0x0000000183D56300-0x0000000183D56310
	
			// Methods
			public void ResetOverride() {} // 0x00000001831022B0-0x00000001831022F0
			public void Disable() {} // 0x00000001857A5F70-0x00000001857A5FD4
		}
	
		[Serializable]
		public struct NearByDistanceSetting // TypeDefIndex: 48854
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
	
		public struct World3DUiGlobalSetting // TypeDefIndex: 48855
		{
			// Fields
			public bool bOverride; // 0x00
			public World3DUiSetting setting; // 0x01
			public World3DUiSetting overrideSetting; // 0x02
	
			// Properties
			public bool buildingNameShadowDisable { get => default; set {} } // 0x00000001831021D0-0x0000000183102210 0x0000000183D565B0-0x0000000183D565C0
	
			// Methods
			public void Disable() {} // 0x00000001857AA228-0x00000001857AA278
			public void ResetOverride() {} // 0x0000000183102210-0x0000000183102240
		}
	
		[Serializable]
		public struct World3DUiSetting // TypeDefIndex: 48856
		{
			// Fields
			public bool buildingNameShadowDisable; // 0x00
		}
	
		[Serializable]
		public struct CurveGlobalSetting // TypeDefIndex: 48857
		{
			// Fields
			public unsafe void* buildCurve; // 0x00
			public unsafe void* buildAlphaCurve0; // 0x08
			public unsafe void* buildAlphaCurve1; // 0x10
			public unsafe void* repairCurve0; // 0x18
			public unsafe void* repairCurve1; // 0x20
	
			// Methods
			public void SetBuildCurve(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1) {} // 0x00000001833D9E00-0x00000001833D9E60
			public void SetRepairCurve0(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve) {} // 0x00000001833D9DC0-0x00000001833D9E00
			public void SetRepairCurve1(ref Beyond.Gameplay.Factory.FPtrNativeCurve curve) {} // 0x00000001833D9D80-0x00000001833D9DC0
		}
	
		[NoAlias]
		public struct MapGridRendererData // TypeDefIndex: 48861
		{
			// Fields
			public const int MAX_COUNT = 3200; // Metadata: 0x01FBBAF3
			public short gridCountRegion; // 0x00
			public short gridCountField; // 0x02
			public short gridCount; // 0x04
			public unsafe fixed /* 0x00000000-0x00000000 */ byte infos[0]; // 0x06
	
			// Properties
			public MapGridInfo this[int idx] { get => default; } // 0x0000000183D562C0-0x0000000183D56300 
	
			// Nested types
			public struct MapGridInfo // TypeDefIndex: 48859
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
				public enum SelectType // TypeDefIndex: 48858
				{
					NORMAL = 0,
					BLUEPRINT = 1
				}
			}
	
			// Methods
			public void UpdateGrid([NoAlias] ref MapGridInfo[] gridInfosRegion, [NoAlias] ref MapGridInfo[] gridInfosField) {} // 0x00000001829112B0-0x00000001829113F0
			public void Reset() {} // 0x000000018327BA20-0x000000018327BA50
			public unsafe MapGridInfo* GetGridInfoPtr(int idx) => default; // 0x0000000183D562B0-0x0000000183D562C0
		}
	
		[Serializable]
		public struct UnitPortConfigDB // TypeDefIndex: 48862
		{
			// Fields
			public NativeParallelHashMap<int, UnitPortConfig> configMap; // 0x00
	
			// Methods
			public void Initialize(int capacity = 128 /* Metadata: 0x01FBBAF7 */) {} // 0x00000001831022F0-0x00000001831023A0
			public void Dispose() {} // 0x00000001857A8DF0-0x00000001857A8E84
			[IDTag(0)]
			public bool EnsureValue(string unitName, out UnitPortConfig value) {
				value = default;
				return default;
			} // 0x00000001829C00F0-0x00000001829C02D0
			[IDTag(1)]
			public bool EnsureValue(int unitNameFastId, out UnitPortConfig value) {
				value = default;
				return default;
			} // 0x00000001829BFE20-0x00000001829BFE80
			[IDTag(1)]
			public bool TryGetValue(string unitName, out UnitPortConfig value) {
				value = default;
				return default;
			} // 0x00000001829C02D0-0x00000001829C0340
			[IDTag(0)]
			public bool TryGetValue(int unitNameFastId, out UnitPortConfig value) {
				value = default;
				return default;
			} // 0x00000001829C0340-0x00000001829C0500
			[IDTag(1)]
			public void Add(string unitName, UnitPortConfig value) {} // 0x000000018345DAE0-0x000000018345DBB0
			[IDTag(0)]
			public void Add(int unitNameFastId, UnitPortConfig value) {} // 0x000000018345DBB0-0x000000018345DC90
			public bool ContainsKey(string unitName) => default; // 0x00000001857A8D64-0x00000001857A8DF0
			public void Clear() {} // 0x00000001857A8CD0-0x00000001857A8D64
			[IDTag(1)]
			private UnitPortConfig _CreateWithTable(int unitNameFastId) => default; // 0x00000001857A8E84-0x00000001857A8FC8
			[IDTag(0)]
			private UnitPortConfig _CreateWithTable(string unitName) => default; // 0x000000018287FC00-0x00000001828806F0
			private static void _ParseGlobalPortIdx(string templateName, ref FactoryUnitPortConfig port, int inPortCount) {} // 0x0000000182880B60-0x0000000182880D10
		}
	
		public struct UnitPortConfig // TypeDefIndex: 48863
		{
			// Fields
			public ushort inputPortCount; // 0x00
			public ushort outputPortCount; // 0x02
			public FixedList512Bytes<FactoryUnitPortConfig> portIn; // 0x04
			public FixedList512Bytes<FactoryUnitPortConfig> portOut; // 0x204
		}
	
		[Serializable]
		public struct PerDrawGlobalSetting // TypeDefIndex: 48870
		{
			// Fields
			public const int COLOR_DATA_CAPACITY = 57690; // Metadata: 0x01FBBAF9
			public const int PASS_DATA_CAPACITY = 57600; // Metadata: 0x01FBBAFD
			public unsafe fixed /* 0x00000000-0x00000000 */ byte colorData[0]; // 0x00
			public unsafe fixed /* 0x00000000-0x00000000 */ byte passData[0]; // 0xE15A
	
			// Nested types
			public struct PerDrawPassGlobalSetting // TypeDefIndex: 48865
			{
				// Fields
				public int count; // 0x00
				public unsafe fixed /* 0x00000000-0x00000000 */ byte config[0]; // 0x04
	
				// Properties
				public PerDrawPassConfig this[int idx] { get => default; set {} } // 0x00000001857A6504-0x00000001857A65B4 0x00000001832C9270-0x00000001832C92E0
	
				// Methods
				public PerDrawPassConfig GetPerDrawPassConfig(int idx) => default; // 0x00000001857A6464-0x00000001857A6504
			}
	
			public struct PerDrawColorGlobalSetting // TypeDefIndex: 48867
			{
				// Fields
				public int count; // 0x00
				public unsafe fixed /* 0x00000000-0x00000000 */ byte configs[0]; // 0x04
	
				// Properties
				public PerDrawConfig this[int idx] { get => default; set {} } // 0x00000001857A6188-0x00000001857A6244 0x00000001832C9200-0x00000001832C9270
	
				// Methods
				public PerDrawConfig GetPerDrawConfig(int idx) => default; // 0x00000001857A60E0-0x00000001857A6188
			}
	
			// Methods
			public unsafe void Apply(HGFactoryRendererBinderComponent* binder, LogicEntityState entityState, LogicEntityType entityType) {} // 0x00000001857A63FC-0x00000001857A6464
			public void Apply(ref HGFactoryRendererBinderComponent binder, LogicEntityState entityState, LogicEntityType entityType) {} // 0x0000000182421790-0x0000000182421820
			public static unsafe void Apply(ref HGFactoryRendererBinderComponent binder, PerDrawConfig* perDrawConfigs, int length) {} // 0x0000000182421860-0x0000000182421A10
			public unsafe void ApplyPass(HGFactoryRendererBinderComponent* binder, LogicEntityState entityState, LogicEntityType entityType, uint currentLightMode) {} // 0x00000001857A6308-0x00000001857A6378
			public void ApplyPass(ref HGFactoryRendererBinderComponent binder, LogicEntityState entityState, LogicEntityType entityType, uint currentLightMode) {} // 0x00000001857A6244-0x00000001857A6308
			public static unsafe void ApplyPass(ref HGFactoryRendererBinderComponent binder, PerDrawPassConfig* perDrawConfigs, int length, uint currentLightMode) {} // 0x00000001857A6378-0x00000001857A63FC
			public void Parse(SerializeFieldDictionary<LogicEntityState, SerializeFieldDictionary<LogicEntityType, PerDrawConfigArray>> setting) {} // 0x00000001832C7C20-0x00000001832C9200
			private int _GetKey(LogicEntityState entityState, LogicEntityType entityType) => default; // 0x0000000182421820-0x0000000182421860
		}
	
		public struct SystemIntervalGlobalSetting // TypeDefIndex: 48871
		{
			// Fields
			public bool bOverride; // 0x00
			public SystemIntervalSetting setting; // 0x04
			public SystemIntervalSetting overrideSetting; // 0x2C
	
			// Properties
			public int crossCollectFrameInterval { get => default; set {} } // 0x0000000183280FB0-0x0000000183280FE0 0x0000000183D56430-0x0000000183D56440
			public int cullingSystemInterval { get => default; set {} } // 0x00000001823110D0-0x0000000182311110 0x0000000183D56440-0x0000000183D56450
			public int unitPreviewSystemInterval { get => default; set {} } // 0x0000000182310F90-0x0000000182310FD0 0x0000000183D56490-0x0000000183D564A0
			public int portPreviewRenderSystemInterval { get => default; set {} } // 0x0000000182311010-0x0000000182311050 0x0000000183D56480-0x0000000183D56490
			public int buildingStateSystemInterval { get => default; set {} } // 0x0000000182311110-0x0000000182311150 0x0000000183D56420-0x0000000183D56430
			public int portBlockSystemInterval { get => default; set {} } // 0x0000000182310FD0-0x0000000182311010 0x0000000183D56470-0x0000000183D56480
			public int outputUISystemInterval { get => default; set {} } // 0x0000000182311050-0x0000000182311090 0x0000000183D56460-0x0000000183D56470
			public int buildingNameSystemInterval { get => default; set {} } // 0x00000001857A84FC-0x00000001857A8558 0x0000000183D56410-0x0000000183D56420
			public int adjustGroundSystemInterval { get => default; set {} } // 0x0000000182311150-0x0000000182311190 0x0000000183D56400-0x0000000183D56410
			public int gridSystemInterval { get => default; set {} } // 0x0000000182311090-0x00000001823110D0 0x0000000183D56450-0x0000000183D56460
	
			// Methods
			public void Disable() {} // 0x00000001857A8484-0x00000001857A84FC
			public void ResetOverride() {} // 0x0000000183102270-0x00000001831022B0
		}
	
		[Serializable]
		public struct SystemIntervalSetting // TypeDefIndex: 48872
		{
			// Fields
			private const int MIN_INTERVAL = 0; // Metadata: 0x01FBBB01
			private const int MAX_INTERVAL = 60; // Metadata: 0x01FBBB02
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
		public struct UIEffectPathConfig // TypeDefIndex: 48873
		{
			// Fields
			public static int s_max; // 0x00
			public NativeParallelHashMap<int, FixedString32Bytes> atlasNames; // 0x00
			public NativeParallelHashMap<int, float4> atlasColors; // 0x10
			public NativeParallelHashMap<int, float4> atlasUVs; // 0x20
	
			// Constructors
			static UIEffectPathConfig() {
				s_max = default;
			} // 0x0000000183D438E0-0x0000000183D43920
	
			// Methods
			public void Parse(SerializeFieldDictionary<FacBuildingState, string> config, SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryStateIconColorConfig, FactoryUIAtlasSOData uvConfig) {} // 0x000000018327F6A0-0x00000001832807F0
			public bool Get(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color) {
				path = default;
				uv = default;
				color = default;
				return default;
			} // 0x00000001857A8558-0x00000001857A8700
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
		} // 0x00000001839C9260-0x00000001839C94A0
	
		// Methods
		public void Reset() {} // 0x00000001857A3980-0x00000001857A3A24
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public abstract class BaseProcessor : IProcessor // TypeDefIndex: 48875
	{
		// Fields
		protected FactorySetting m_factorySetting; // 0x10
	
		// Properties
		public virtual float interval { get; protected set; } // 0x0000000183D4EBF0-0x0000000183D4EC00 0x0000000183D4EC00-0x0000000183D4EC10
		public virtual float curInterval { get; set; } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public abstract string name { get; }
		public virtual bool lowFrameEnable { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		protected BaseProcessor() {} // 0x0000000183D561E0-0x0000000183D561F0
	
		// Methods
		public virtual void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting) {} // 0x000000018327B300-0x000000018327B360
		public virtual JobHandle PreExecute(ref EntityManager em, long time, long deltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default; // 0x000000018230FF50-0x0000000182310000
		public virtual JobHandle Execute(ref EntityManager em, long time, long deltaTime, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default; // 0x000000018230BA00-0x000000018230BAB0
		public virtual JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle) => default; // 0x00000001824FC4C0-0x00000001824FC570
		public virtual void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null) {} // 0x000000018230BAB0-0x000000018230D4A0
		public virtual void TearDown(ref EntityManager em, ref GlobalEnv env) {} // 0x00000001857A1910-0x00000001857A196C
		protected void StructuralSync(ref JobHandle jh, ref NativeList<JobHandle> noneDependencies) {} // 0x0000000182311370-0x00000001823113E0
		protected void ScheduleNoneDependencies(ref NativeList<JobHandle> noneDependencies) {} // 0x00000001823111D0-0x00000001823112E0
		public bool InLowFrameMode(ref GlobalEnv env) => default; // 0x00000001824FB9D0-0x00000001824FBA60
		protected bool SpecialEntityExisted(ref EntityManager em) => default; // 0x0000000182BBB120-0x0000000182BBB290
	}

	public interface IProcessor // TypeDefIndex: 48876
	{
		// Properties
		float interval { get; }
		float curInterval { get; set; }
		string name { get; }
		bool lowFrameEnable { get; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Methods
		void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting);
		JobHandle PreExecute(ref EntityManager em, long time, long dt, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies);
		JobHandle Execute(ref EntityManager em, long time, long dt, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies);
		JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle);
		void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null);
		void TearDown(ref EntityManager em, ref GlobalEnv env);
		bool InLowFrameMode(ref GlobalEnv env);
	}

	public class StructuralChangedAttribute : Attribute // TypeDefIndex: 48877
	{
		// Constructors
		public StructuralChangedAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[BurstCompile]
	public class UnsafeJobFuncPointers // TypeDefIndex: 48893
	{
		// Nested types
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void ApplyRender(HGFactoryRendererBinderComponent* binder, PerDrawConfig* perDrawConfigs, int length); // TypeDefIndex: 48878; 0x00000001811360D0-0x00000001811360F0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate bool FacRegionPosValid(EntityManager* entityManager, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // TypeDefIndex: 48879; 0x00000001857A2E88-0x00000001857A2E9C
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool QueryStateIconPath(FacBuildingState stateUI, out FixedString32Bytes path, out float4 uv, out float4 color); // TypeDefIndex: 48880; 0x000000018101C850-0x000000018101C870
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate FacBuildingState QueryBuildingState(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // TypeDefIndex: 48881; 0x0000000181035ED0-0x0000000181035EF0
	
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SetEntityFlashStatue(ref EntityManager em, ref Entity entity, FacBuildingState statue); // TypeDefIndex: 48882; 0x00000001811360D0-0x00000001811360F0
	
		public unsafe delegate void ApplyPerDrawRender_0000085C_PostfixBurstDelegate(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length); // TypeDefIndex: 48883; 0x00000001811360D0-0x00000001811360F0
	
		internal static class ApplyPerDrawRender_0000085C_BurstDirectCall // TypeDefIndex: 48884
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static ApplyPerDrawRender_0000085C_BurstDirectCall() {} // 0x0000000183CECAF0-0x0000000183CECB00
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066a47) {} // 0x00000001857A160C-0x00000001857A1710
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857A1710-0x00000001857A1764
			public static void Constructor() {} // 0x0000000183CECB00-0x0000000183CECB90
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length) {} // 0x00000001857A1764-0x00000001857A1800
		}
	
		public delegate bool GetQueryStateIconPath_0000085E_PostfixBurstDelegate(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color); // TypeDefIndex: 48885; 0x000000018101C850-0x000000018101C870
	
		internal static class GetQueryStateIconPath_0000085E_BurstDirectCall // TypeDefIndex: 48886
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static GetQueryStateIconPath_0000085E_BurstDirectCall() {} // 0x0000000183CEB510-0x0000000183CEB520
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066a58) {} // 0x00000001857A35D8-0x00000001857A36DC
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857A36DC-0x00000001857A3730
			public static void Constructor() {} // 0x0000000183CEB520-0x0000000183CEB5B0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static bool Invoke(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color) {
				path = default;
				uv = default;
				color = default;
				return default;
			} // 0x00000001857A3730-0x00000001857A37DC
		}
	
		public unsafe delegate bool GetLogicEntityWithPos_00000860_PostfixBurstDelegate([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment); // TypeDefIndex: 48887; 0x00000001857A2E88-0x00000001857A2E9C
	
		internal static class GetLogicEntityWithPos_00000860_BurstDirectCall // TypeDefIndex: 48888
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static GetLogicEntityWithPos_00000860_BurstDirectCall() {} // 0x0000000183CEB5B0-0x0000000183CEB5C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066a6e) {} // 0x00000001857A3208-0x00000001857A330C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857A330C-0x00000001857A3360
			public static void Constructor() {} // 0x0000000183CEB5C0-0x0000000183CEB650
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe bool Invoke([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment) {
				unitFragment = default;
				return default;
			} // 0x00000001857A3360-0x00000001857A3448
		}
	
		public delegate FacBuildingState QueryBuildingStateFunc_00000862_PostfixBurstDelegate(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState); // TypeDefIndex: 48889; 0x0000000181035ED0-0x0000000181035EF0
	
		internal static class QueryBuildingStateFunc_00000862_BurstDirectCall // TypeDefIndex: 48890
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static QueryBuildingStateFunc_00000862_BurstDirectCall() {} // 0x0000000183CEA9D0-0x0000000183CEA9E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066a80) {} // 0x00000001857A7408-0x00000001857A750C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857A750C-0x00000001857A7560
			public static void Constructor() {} // 0x0000000183CEA9E0-0x0000000183CEAA70
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static FacBuildingState Invoke(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState) {
				subState = default;
				return default;
			} // 0x00000001857A7560-0x00000001857A7600
		}
	
		public delegate void SetEntityFlashStatueFunc_00000864_PostfixBurstDelegate(ref EntityManager em, ref Entity entity, FacBuildingState statue); // TypeDefIndex: 48891; 0x00000001811360D0-0x00000001811360F0
	
		internal static class SetEntityFlashStatueFunc_00000864_BurstDirectCall // TypeDefIndex: 48892
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SetEntityFlashStatueFunc_00000864_BurstDirectCall() {} // 0x0000000183CEA930-0x0000000183CEA940
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066a8f) {} // 0x00000001857A7BA0-0x00000001857A7CA4
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857A7CA4-0x00000001857A7CF8
			public static void Constructor() {} // 0x0000000183CEA940-0x0000000183CEA9D0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager em, ref Entity entity, FacBuildingState statue) {} // 0x00000001857A7CF8-0x00000001857A7D98
		}
	
		// Constructors
		public UnsafeJobFuncPointers() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static FunctionPointer<ApplyRender> GetApplyRenderPointer() => default; // 0x000000018327EC70-0x000000018327ED40
		public static FunctionPointer<FacRegionPosValid> GetFacRegionValid() => default; // 0x0000000183280EE0-0x0000000183280FB0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(ApplyRender))]
		public static unsafe void ApplyPerDrawRender(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length) {} // 0x00000001857A9768-0x00000001857A97C8
		public static FunctionPointer<QueryStateIconPath> GetQueryStateIconPathFuncPtr() => default; // 0x0000000183280E10-0x0000000183280EE0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryStateIconPath))]
		public static bool GetQueryStateIconPath(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color) {
			path = default;
			uv = default;
			color = default;
			return default;
		} // 0x00000001857A9DE8-0x00000001857A9E5C
		public static bool GetLogicEntityWithPosAdapter(ref EntityManager em, float x, float y, float z, out UnitFragment unitFragment) {
			unitFragment = default;
			return default;
		} // 0x00000001857A97C8-0x00000001857A99B0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(FacRegionPosValid))]
		public static unsafe bool GetLogicEntityWithPos([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment) {
			unitFragment = default;
			return default;
		} // 0x00000001857A9C88-0x00000001857A9D1C
		public static FunctionPointer<QueryBuildingState> GetQueryBuildingStatePointer() => default; // 0x00000001838DDBE0-0x00000001838DDCB0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryBuildingState))]
		public static FacBuildingState QueryBuildingStateFunc(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState) {
			subState = default;
			return default;
		} // 0x00000001857A9E70-0x00000001857A9ED0
		public static FunctionPointer<SetEntityFlashStatue> GetSetEntityFlashStatuePointer() => default; // 0x00000001838DDB10-0x00000001838DDBE0
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(SetEntityFlashStatue))]
		public static void SetEntityFlashStatueFunc(ref EntityManager em, ref Entity entity, FacBuildingState statue) {} // 0x00000001857A9EE4-0x00000001857A9F44
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(ApplyRender))]
		public static unsafe void ApplyPerDrawRender_BurstManaged(HGFactoryRendererBinderComponent* binderPtr, PerDrawConfig* perDrawConfigs, int length) {} // 0x00000001857A9714-0x00000001857A9768
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryStateIconPath))]
		public static bool GetQueryStateIconPath_BurstManaged(FacBuildingState state, out FixedString32Bytes path, out float4 uv, out float4 color) {
			path = default;
			uv = default;
			color = default;
			return default;
		} // 0x00000001857A9D1C-0x00000001857A9DE8
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(FacRegionPosValid))]
		public static unsafe bool GetLogicEntityWithPos_BurstManaged([NoAlias] EntityManager* em, float x, float y, float z, SharedDataContainer.SharedExtData* sharedDataPtr, out UnitFragment* unitFragment) {
			unitFragment = default;
			return default;
		} // 0x00000001857A99B0-0x00000001857A9C88
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(QueryBuildingState))]
		public static FacBuildingState QueryBuildingStateFunc_BurstManaged(ref EntityManager em, ref Entity entity, out FacBuildingSubState subState) {
			subState = default;
			return default;
		} // 0x00000001857A9E5C-0x00000001857A9E70
		[BurstCompile]
		[AOT.MonoPInvokeCallback(typeof(SetEntityFlashStatue))]
		public static void SetEntityFlashStatueFunc_BurstManaged(ref EntityManager em, ref Entity entity, FacBuildingState statue) {} // 0x00000001857A9ED0-0x00000001857A9EE4
	}

	[BurstCompile(FloatPrecision = FloatPrecision.High, FloatMode = FloatMode.Fast)]
	public struct AdditiveEffectJob : IJobParallelForDefer // TypeDefIndex: 48900
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
		public delegate bool _BuildDismissState_00000882_PostfixBurstDelegate(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 48894; 0x0000000182121030-0x0000000182121050
	
		internal static class _BuildDismissState_00000882_BurstDirectCall // TypeDefIndex: 48895
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BuildDismissState_00000882_BurstDirectCall() {} // 0x0000000183CE84F0-0x0000000183CE8500
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066ada) {} // 0x00000001857AA278-0x00000001857AA37C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857AA37C-0x00000001857AA3D0
			public static void Constructor() {} // 0x0000000183CE8500-0x0000000183CE8590
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static bool Invoke(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) => default; // 0x00000001857AA3D0-0x00000001857AA4A8
		}
	
		public delegate bool _Repair0_00000884_PostfixBurstDelegate(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 48896; 0x0000000181035ED0-0x0000000181035EF0
	
		internal static class _Repair0_00000884_BurstDirectCall // TypeDefIndex: 48897
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair0_00000884_BurstDirectCall() {} // 0x0000000183CE7230-0x0000000183CE7240
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066aed) {} // 0x00000001857AA6C4-0x00000001857AA7C8
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857AA7C8-0x00000001857AA81C
			public static void Constructor() {} // 0x0000000183CE7240-0x0000000183CE72D0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static bool Invoke(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x00000001857AA81C-0x00000001857AA8B4
		}
	
		public delegate bool _Repair1_00000885_PostfixBurstDelegate(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 48898; 0x0000000181035ED0-0x0000000181035EF0
	
		internal static class _Repair1_00000885_BurstDirectCall // TypeDefIndex: 48899
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1_00000885_BurstDirectCall() {} // 0x0000000183CE6FB0-0x0000000183CE6FC0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066afc) {} // 0x00000001857AAA44-0x00000001857AAB48
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857AAB48-0x00000001857AAB9C
			public static void Constructor() {} // 0x0000000183CE6FC0-0x0000000183CE7050
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static bool Invoke(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x00000001857AAB9C-0x00000001857AAC34
		}
	
		// Methods
		public void SetSharedExtData(IntPtr data) {} // 0x000000018322B560-0x000000018322B5F0
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x000000018579C8B4-0x000000018579C934
		[IDTag(0)]
		public void Execute(int index) {} // 0x000000018579C590-0x000000018579C8B4
		private void _OnStackEmpty(ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData) {} // 0x000000018579CB58-0x000000018579CBEC
		private void _CancelPreState(AdditiveEffectFragment.AdditiveEffectType preState, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData) {} // 0x000000018579BE44-0x000000018579BE58
		private void _ResumeState(AdditiveEffectFragment.AdditiveEffectType state, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData) {} // 0x000000018579BEC0-0x000000018579C120
		private void _SetStateValid(AdditiveEffectFragment.AdditiveEffectType state, ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData, bool valid) {} // 0x000000018579CCAC-0x000000018579CF2C
		private void _UpdateInternalStateLifeCycle(ref AdditiveEffectFragment additiveEffect, ref SharedDataContainer.SharedExtData extData) {} // 0x000000018579CF2C-0x000000018579D0A0
		[BurstCompile]
		private static bool _BuildDismissState(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) => default; // 0x000000018579CA4C-0x000000018579CAE4
		private static void _InitBuildState(ref CutoffState cutoffState, ref BuildDismissState buildDismissState) {} // 0x000000018579CAE4-0x000000018579CB58
		[BurstCompile]
		private static bool _Repair0(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x000000018579CBEC-0x000000018579CC4C
		[BurstCompile]
		private static bool _Repair1(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x000000018579CC4C-0x000000018579CCAC
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x000000018322B5F0-0x000000018322B670
		[IDTag(0)]
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB03 */) => default; // 0x00000001830EA470-0x00000001830EA690
		[IDTag(1)]
		public JobHandle ScheduleDefer(JobHandle jobHandleDep0, JobHandle jobHandleDep1, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB04 */) => default; // 0x000000018579C934-0x000000018579CA4C
		[BurstCompile]
		public static bool _BuildDismissState_BurstManaged(ref AdditiveEffectFragment additiveEffect, ref BuildDismissState buildState, ref CutoffState cutoffState, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) => default; // 0x000000018579BD34-0x000000018579BE44
		[BurstCompile]
		public static bool _Repair0_BurstManaged(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x000000018579BE58-0x000000018579BE8C
		[BurstCompile]
		public static bool _Repair1_BurstManaged(ref SharedDataContainer.SharedExtData extData, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) => default; // 0x000000018579BE8C-0x000000018579BEC0
	}

	[BurstCompile]
	public struct AdditiveEffectQueryJob : IJob // TypeDefIndex: 48901
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
		public void Execute() {} // 0x000000018579D0A0-0x000000018579D224
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer additiveEffectQr, ref EntityQueryV2.QueryResultDefer hintQr, ref EntityQueryV2.QueryResultDefer additiveEffectRendererQr, bool resetQr = true /* Metadata: 0x01FBBB05 */) {} // 0x00000001826DF900-0x00000001826DFA10
	}

	[BurstCompile]
	public struct AdditiveEffectRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 48984
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
		public delegate void _BPBuildStart_0000088E_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 48902; 0x000000018551C468-0x000000018551C47C
	
		internal static class _BPBuildStart_0000088E_BurstDirectCall // TypeDefIndex: 48903
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildStart_0000088E_BurstDirectCall() {} // 0x0000000183CE8770-0x0000000183CE8780
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066c68) {} // 0x00000001857B8CF0-0x00000001857B8DF4
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857B8DF4-0x00000001857B8E48
			public static void Constructor() {} // 0x0000000183CE8780-0x0000000183CE8810
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x00000001857B8E48-0x00000001857B8F10
		}
	
		public delegate void _BPBuildProcess_0000088F_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 48904; 0x000000018551C468-0x000000018551C47C
	
		internal static class _BPBuildProcess_0000088F_BurstDirectCall // TypeDefIndex: 48905
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildProcess_0000088F_BurstDirectCall() {} // 0x0000000183CE8810-0x0000000183CE8820
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066c83) {} // 0x00000001857B8988-0x00000001857B8A8C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857B8A8C-0x00000001857B8AE0
			public static void Constructor() {} // 0x0000000183CE8820-0x0000000183CE88B0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x00000001857B8AE0-0x00000001857B8BA8
		}
	
		public delegate void _BPBuildEnd_00000890_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 48906; 0x000000018551C468-0x000000018551C47C
	
		internal static class _BPBuildEnd_00000890_BurstDirectCall // TypeDefIndex: 48907
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildEnd_00000890_BurstDirectCall() {} // 0x0000000183CE88B0-0x0000000183CE88C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066c9e) {} // 0x00000001857B8548-0x00000001857B864C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857B864C-0x00000001857B86A0
			public static void Constructor() {} // 0x0000000183CE88C0-0x0000000183CE8950
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x00000001857B86A0-0x00000001857B876C
		}
	
		public delegate void _BPBuildCutoffStateStart_00000891_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 48908; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _BPBuildCutoffStateStart_00000891_BurstDirectCall // TypeDefIndex: 48909
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateStart_00000891_BurstDirectCall() {} // 0x0000000183CE8950-0x0000000183CE8960
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066cb1) {} // 0x00000001857B8298-0x00000001857B839C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857B839C-0x00000001857B83F0
			public static void Constructor() {} // 0x0000000183CE8960-0x0000000183CE89F0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x00000001857B83F0-0x00000001857B8484
		}
	
		public delegate void _BPBuildCutoffStateEnd_00000892_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 48910; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _BPBuildCutoffStateEnd_00000892_BurstDirectCall // TypeDefIndex: 48911
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateEnd_00000892_BurstDirectCall() {} // 0x0000000183CE8A90-0x0000000183CE8AA0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066cc0) {} // 0x00000001857B7C5C-0x00000001857B7D60
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857B7D60-0x00000001857B7DB4
			public static void Constructor() {} // 0x0000000183CE8AA0-0x0000000183CE8B30
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x00000001857B7DB4-0x00000001857B7E4C
		}
	
		public delegate void _BPBuildCutoffStateProcess_00000893_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 48912; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _BPBuildCutoffStateProcess_00000893_BurstDirectCall // TypeDefIndex: 48913
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BPBuildCutoffStateProcess_00000893_BurstDirectCall() {} // 0x0000000183CE89F0-0x0000000183CE8A00
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066ccf) {} // 0x00000001857B7FE4-0x00000001857B80E8
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857B80E8-0x00000001857B813C
			public static void Constructor() {} // 0x0000000183CE8A00-0x0000000183CE8A90
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x00000001857B813C-0x00000001857B81D4
		}
	
		public delegate void _CutoffStateStart_00000897_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 48914; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _CutoffStateStart_00000897_BurstDirectCall // TypeDefIndex: 48915
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateStart_00000897_BurstDirectCall() {} // 0x0000000183CE8090-0x0000000183CE80A0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066cde) {} // 0x00000001857BAA84-0x00000001857BAB88
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BAB88-0x00000001857BABDC
			public static void Constructor() {} // 0x0000000183CE80A0-0x0000000183CE8130
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x00000001857BABDC-0x00000001857BAC74
		}
	
		public delegate void _CutoffStateEnd_00000898_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 48916; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _CutoffStateEnd_00000898_BurstDirectCall // TypeDefIndex: 48917
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateEnd_00000898_BurstDirectCall() {} // 0x0000000183CE81D0-0x0000000183CE81E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066ced) {} // 0x00000001857BA51C-0x00000001857BA620
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BA620-0x00000001857BA674
			public static void Constructor() {} // 0x0000000183CE81E0-0x0000000183CE8270
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x00000001857BA674-0x00000001857BA70C
		}
	
		public delegate void _CutoffStateProcess_00000899_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder); // TypeDefIndex: 48918; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _CutoffStateProcess_00000899_BurstDirectCall // TypeDefIndex: 48919
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _CutoffStateProcess_00000899_BurstDirectCall() {} // 0x0000000183CE8130-0x0000000183CE8140
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066cfc) {} // 0x00000001857BA7D0-0x00000001857BA8D4
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BA8D4-0x00000001857BA928
			public static void Constructor() {} // 0x0000000183CE8140-0x0000000183CE81D0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x00000001857BA928-0x00000001857BA9C0
		}
	
		public delegate void _BuildStateProcess_0000089C_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time); // TypeDefIndex: 48920; 0x000000018551C468-0x000000018551C47C
	
		internal static class _BuildStateProcess_0000089C_BurstDirectCall // TypeDefIndex: 48921
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BuildStateProcess_0000089C_BurstDirectCall() {} // 0x0000000183CE8450-0x0000000183CE8460
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066d13) {} // 0x00000001857B998C-0x00000001857B9A90
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857B9A90-0x00000001857B9AE4
			public static void Constructor() {} // 0x0000000183CE8460-0x0000000183CE84F0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x00000001857B9AE4-0x00000001857B9BD0
		}
	
		public delegate void _HighLightStart_0000089D_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48922; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _HighLightStart_0000089D_BurstDirectCall // TypeDefIndex: 48923
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightStart_0000089D_BurstDirectCall() {} // 0x0000000183CE7C30-0x0000000183CE7C40
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066d26) {} // 0x00000001857BBAD0-0x00000001857BBBD4
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BBBD4-0x00000001857BBC28
			public static void Constructor() {} // 0x0000000183CE7C40-0x0000000183CE7CD0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BBC28-0x00000001857BBCC0
		}
	
		public delegate void _HighLightEnd_0000089E_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48924; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _HighLightEnd_0000089E_BurstDirectCall // TypeDefIndex: 48925
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightEnd_0000089E_BurstDirectCall() {} // 0x0000000183CE7D70-0x0000000183CE7D80
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066d35) {} // 0x00000001857BB560-0x00000001857BB664
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BB664-0x00000001857BB6B8
			public static void Constructor() {} // 0x0000000183CE7D80-0x0000000183CE7E10
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BB6B8-0x00000001857BB754
		}
	
		public delegate void _HighLightProcess_0000089F_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48926; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _HighLightProcess_0000089F_BurstDirectCall // TypeDefIndex: 48927
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HighLightProcess_0000089F_BurstDirectCall() {} // 0x0000000183CE7CD0-0x0000000183CE7CE0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066d44) {} // 0x00000001857BB818-0x00000001857BB91C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BB91C-0x00000001857BB970
			public static void Constructor() {} // 0x0000000183CE7CE0-0x0000000183CE7D70
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BB970-0x00000001857BBA0C
		}
	
		public delegate void _FigureStart_000008A0_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48928; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _FigureStart_000008A0_BurstDirectCall // TypeDefIndex: 48929
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureStart_000008A0_BurstDirectCall() {} // 0x0000000183CE7E10-0x0000000183CE7E20
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066d53) {} // 0x00000001857BB2A8-0x00000001857BB3AC
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BB3AC-0x00000001857BB400
			public static void Constructor() {} // 0x0000000183CE7E20-0x0000000183CE7EB0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BB400-0x00000001857BB49C
		}
	
		public delegate void _FigureProcess_000008A1_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48930; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _FigureProcess_000008A1_BurstDirectCall // TypeDefIndex: 48931
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureProcess_000008A1_BurstDirectCall() {} // 0x0000000183CE7EB0-0x0000000183CE7EC0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066d62) {} // 0x00000001857BAFF0-0x00000001857BB0F4
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BB0F4-0x00000001857BB148
			public static void Constructor() {} // 0x0000000183CE7EC0-0x0000000183CE7F50
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BB148-0x00000001857BB1E4
		}
	
		public delegate void _FigureEnd_000008A2_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48932; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _FigureEnd_000008A2_BurstDirectCall // TypeDefIndex: 48933
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _FigureEnd_000008A2_BurstDirectCall() {} // 0x0000000183CE7F50-0x0000000183CE7F60
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066d71) {} // 0x00000001857BAD38-0x00000001857BAE3C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BAE3C-0x00000001857BAE90
			public static void Constructor() {} // 0x0000000183CE7F60-0x0000000183CE7FF0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BAE90-0x00000001857BAF2C
		}
	
		public delegate void _HintStart_000008A3_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha); // TypeDefIndex: 48934; 0x0000000182097E50-0x0000000182097E70
	
		internal static class _HintStart_000008A3_BurstDirectCall // TypeDefIndex: 48935
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintStart_000008A3_BurstDirectCall() {} // 0x0000000183CE7A50-0x0000000183CE7A60
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066d82) {} // 0x00000001857BC2E4-0x00000001857BC3E8
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BC3E8-0x00000001857BC43C
			public static void Constructor() {} // 0x0000000183CE7A60-0x0000000183CE7AF0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha) {} // 0x00000001857BC43C-0x00000001857BC4EC
		}
	
		public delegate void _HintEnd_000008A4_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48936; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _HintEnd_000008A4_BurstDirectCall // TypeDefIndex: 48937
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintEnd_000008A4_BurstDirectCall() {} // 0x0000000183CE7B90-0x0000000183CE7BA0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066d92) {} // 0x00000001857BBD84-0x00000001857BBE88
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BBE88-0x00000001857BBEDC
			public static void Constructor() {} // 0x0000000183CE7BA0-0x0000000183CE7C30
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BBEDC-0x00000001857BBF78
		}
	
		public delegate void _HintProcess_000008A5_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48938; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _HintProcess_000008A5_BurstDirectCall // TypeDefIndex: 48939
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _HintProcess_000008A5_BurstDirectCall() {} // 0x0000000183CE7AF0-0x0000000183CE7B00
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066da1) {} // 0x00000001857BC03C-0x00000001857BC140
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BC140-0x00000001857BC194
			public static void Constructor() {} // 0x0000000183CE7B00-0x0000000183CE7B90
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BC194-0x00000001857BC220
		}
	
		public delegate void _OverloadStart_000008A6_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48940; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _OverloadStart_000008A6_BurstDirectCall // TypeDefIndex: 48941
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadStart_000008A6_BurstDirectCall() {} // 0x0000000183CE7690-0x0000000183CE76A0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066db0) {} // 0x00000001857BD428-0x00000001857BD52C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BD52C-0x00000001857BD580
			public static void Constructor() {} // 0x0000000183CE76A0-0x0000000183CE7730
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BD580-0x00000001857BD61C
		}
	
		public delegate void _OverloadEnd_000008A7_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48942; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _OverloadEnd_000008A7_BurstDirectCall // TypeDefIndex: 48943
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadEnd_000008A7_BurstDirectCall() {} // 0x0000000183CE79B0-0x0000000183CE79C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066dbf) {} // 0x00000001857BC6B0-0x00000001857BC7B4
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BC7B4-0x00000001857BC808
			public static void Constructor() {} // 0x0000000183CE79C0-0x0000000183CE7A50
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BC808-0x00000001857BC8A4
		}
	
		public delegate void _OverloadProcess_000008A8_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48944; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _OverloadProcess_000008A8_BurstDirectCall // TypeDefIndex: 48945
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadProcess_000008A8_BurstDirectCall() {} // 0x0000000183CE7730-0x0000000183CE7740
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066dce) {} // 0x00000001857BD180-0x00000001857BD284
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BD284-0x00000001857BD2D8
			public static void Constructor() {} // 0x0000000183CE7740-0x0000000183CE77D0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BD2D8-0x00000001857BD364
		}
	
		public delegate void _OverloadInvalidStart_000008A9_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48946; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _OverloadInvalidStart_000008A9_BurstDirectCall // TypeDefIndex: 48947
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidStart_000008A9_BurstDirectCall() {} // 0x0000000183CE77D0-0x0000000183CE77E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066ddd) {} // 0x00000001857BCEC8-0x00000001857BCFCC
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BCFCC-0x00000001857BD020
			public static void Constructor() {} // 0x0000000183CE77E0-0x0000000183CE7870
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BD020-0x00000001857BD0BC
		}
	
		public delegate void _OverloadInvalidEnd_000008AA_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48948; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _OverloadInvalidEnd_000008AA_BurstDirectCall // TypeDefIndex: 48949
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidEnd_000008AA_BurstDirectCall() {} // 0x0000000183CE7910-0x0000000183CE7920
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066dec) {} // 0x00000001857BC968-0x00000001857BCA6C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BCA6C-0x00000001857BCAC0
			public static void Constructor() {} // 0x0000000183CE7920-0x0000000183CE79B0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BCAC0-0x00000001857BCB5C
		}
	
		public delegate void _OverloadInvalidProcess_000008AB_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48950; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _OverloadInvalidProcess_000008AB_BurstDirectCall // TypeDefIndex: 48951
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _OverloadInvalidProcess_000008AB_BurstDirectCall() {} // 0x0000000183CE7870-0x0000000183CE7880
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066dfb) {} // 0x00000001857BCC20-0x00000001857BCD24
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BCD24-0x00000001857BCD78
			public static void Constructor() {} // 0x0000000183CE7880-0x0000000183CE7910
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BCD78-0x00000001857BCE04
		}
	
		public delegate void _Repair0Process_000008AE_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 48952; 0x0000000181028930-0x0000000181028950
	
		internal static class _Repair0Process_000008AE_BurstDirectCall // TypeDefIndex: 48953
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair0Process_000008AE_BurstDirectCall() {} // 0x0000000183CE72D0-0x0000000183CE72E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066e0e) {} // 0x00000001857BE458-0x00000001857BE55C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BE55C-0x00000001857BE5B0
			public static void Constructor() {} // 0x0000000183CE72E0-0x0000000183CE7370
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x00000001857BE5B0-0x00000001857BE670
		}
	
		public delegate void _Repair1Start_000008AF_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48954; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _Repair1Start_000008AF_BurstDirectCall // TypeDefIndex: 48955
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1Start_000008AF_BurstDirectCall() {} // 0x0000000183CE7050-0x0000000183CE7060
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066e1f) {} // 0x00000001857BEE34-0x00000001857BEF38
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BEF38-0x00000001857BEF8C
			public static void Constructor() {} // 0x0000000183CE7060-0x0000000183CE70F0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BEF8C-0x00000001857BF024
		}
	
		public delegate void _Repair1End_000008B0_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48956; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _Repair1End_000008B0_BurstDirectCall // TypeDefIndex: 48957
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1End_000008B0_BurstDirectCall() {} // 0x0000000183CE7190-0x0000000183CE71A0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066e2e) {} // 0x00000001857BE858-0x00000001857BE95C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BE95C-0x00000001857BE9B0
			public static void Constructor() {} // 0x0000000183CE71A0-0x0000000183CE7230
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BE9B0-0x00000001857BEA44
		}
	
		public delegate void _Repair1Process_000008B1_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time); // TypeDefIndex: 48958; 0x0000000181028930-0x0000000181028950
	
		internal static class _Repair1Process_000008B1_BurstDirectCall // TypeDefIndex: 48959
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _Repair1Process_000008B1_BurstDirectCall() {} // 0x0000000183CE70F0-0x0000000183CE7100
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066e41) {} // 0x00000001857BEB08-0x00000001857BEC0C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BEC0C-0x00000001857BEC60
			public static void Constructor() {} // 0x0000000183CE7100-0x0000000183CE7190
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x00000001857BEC60-0x00000001857BED20
		}
	
		public delegate void _BlueprintProcessInternal_000008B3_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48960; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _BlueprintProcessInternal_000008B3_BurstDirectCall // TypeDefIndex: 48961
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintProcessInternal_000008B3_BurstDirectCall() {} // 0x0000000183CE8630-0x0000000183CE8640
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066e52) {} // 0x00000001857B941C-0x00000001857B9520
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857B9520-0x00000001857B9574
			public static void Constructor() {} // 0x0000000183CE8640-0x0000000183CE86D0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857B9574-0x00000001857B9610
		}
	
		public delegate void _BlueprintEnd_000008B4_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer); // TypeDefIndex: 48962; 0x0000000182097E50-0x0000000182097E70
	
		internal static class _BlueprintEnd_000008B4_BurstDirectCall // TypeDefIndex: 48963
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintEnd_000008B4_BurstDirectCall() {} // 0x0000000183CE86D0-0x0000000183CE86E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066e63) {} // 0x00000001857B9058-0x00000001857B915C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857B915C-0x00000001857B91B0
			public static void Constructor() {} // 0x0000000183CE86E0-0x0000000183CE8770
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer) {} // 0x00000001857B91B0-0x00000001857B9258
		}
	
		public delegate void _BlueprintStart_000008B5_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48964; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _BlueprintStart_000008B5_BurstDirectCall // TypeDefIndex: 48965
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _BlueprintStart_000008B5_BurstDirectCall() {} // 0x0000000183CE8590-0x0000000183CE85A0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066e73) {} // 0x00000001857B96D4-0x00000001857B97D8
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857B97D8-0x00000001857B982C
			public static void Constructor() {} // 0x0000000183CE85A0-0x0000000183CE8630
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857B982C-0x00000001857B98C8
		}
	
		public delegate void _PreSelectStart_000008B6_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48966; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _PreSelectStart_000008B6_BurstDirectCall // TypeDefIndex: 48967
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectStart_000008B6_BurstDirectCall() {} // 0x0000000183CE7370-0x0000000183CE7380
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066e82) {} // 0x00000001857BE1A4-0x00000001857BE2A8
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BE2A8-0x00000001857BE2FC
			public static void Constructor() {} // 0x0000000183CE7380-0x0000000183CE7410
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BE2FC-0x00000001857BE394
		}
	
		public delegate void _PreSelectEnd_000008B7_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48968; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _PreSelectEnd_000008B7_BurstDirectCall // TypeDefIndex: 48969
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectEnd_000008B7_BurstDirectCall() {} // 0x0000000183CE74B0-0x0000000183CE74C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066e91) {} // 0x00000001857BDC4C-0x00000001857BDD50
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BDD50-0x00000001857BDDA4
			public static void Constructor() {} // 0x0000000183CE74C0-0x0000000183CE7550
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BDDA4-0x00000001857BDE38
		}
	
		public delegate void _PreSelectProcess_000008B8_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48970; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _PreSelectProcess_000008B8_BurstDirectCall // TypeDefIndex: 48971
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PreSelectProcess_000008B8_BurstDirectCall() {} // 0x0000000183CE7410-0x0000000183CE7420
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066ea0) {} // 0x00000001857BDEFC-0x00000001857BE000
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BE000-0x00000001857BE054
			public static void Constructor() {} // 0x0000000183CE7420-0x0000000183CE74B0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BE054-0x00000001857BE0E0
		}
	
		public delegate void _ContinuationStart_000008B9_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48972; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _ContinuationStart_000008B9_BurstDirectCall // TypeDefIndex: 48973
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationStart_000008B9_BurstDirectCall() {} // 0x0000000183CE8270-0x0000000183CE8280
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066eaf) {} // 0x00000001857BA268-0x00000001857BA36C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BA36C-0x00000001857BA3C0
			public static void Constructor() {} // 0x0000000183CE8280-0x0000000183CE8310
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BA3C0-0x00000001857BA458
		}
	
		public delegate void _ContinuationEnd_000008BA_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48974; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _ContinuationEnd_000008BA_BurstDirectCall // TypeDefIndex: 48975
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationEnd_000008BA_BurstDirectCall() {} // 0x0000000183CE83B0-0x0000000183CE83C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066ebe) {} // 0x00000001857B9D18-0x00000001857B9E1C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857B9E1C-0x00000001857B9E70
			public static void Constructor() {} // 0x0000000183CE83C0-0x0000000183CE8450
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857B9E70-0x00000001857B9EFC
		}
	
		public delegate void _ContinuationProcess_000008BB_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48976; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _ContinuationProcess_000008BB_BurstDirectCall // TypeDefIndex: 48977
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _ContinuationProcess_000008BB_BurstDirectCall() {} // 0x0000000183CE8310-0x0000000183CE8320
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066ecd) {} // 0x00000001857B9FC0-0x00000001857BA0C4
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BA0C4-0x00000001857BA118
			public static void Constructor() {} // 0x0000000183CE8320-0x0000000183CE83B0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BA118-0x00000001857BA1A4
		}
	
		public delegate void _SocialSharingStart_000008BC_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48978; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _SocialSharingStart_000008BC_BurstDirectCall // TypeDefIndex: 48979
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SocialSharingStart_000008BC_BurstDirectCall() {} // 0x0000000183CE6F10-0x0000000183CE6F20
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066edc) {} // 0x00000001857BF0E8-0x00000001857BF1EC
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BF1EC-0x00000001857BF240
			public static void Constructor() {} // 0x0000000183CE6F20-0x0000000183CE6FB0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BF240-0x00000001857BF2D8
		}
	
		public delegate void _PowerInteractionStart_000008BD_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48980; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _PowerInteractionStart_000008BD_BurstDirectCall // TypeDefIndex: 48981
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PowerInteractionStart_000008BD_BurstDirectCall() {} // 0x0000000183CE7550-0x0000000183CE7560
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066eeb) {} // 0x00000001857BD994-0x00000001857BDA98
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BDA98-0x00000001857BDAEC
			public static void Constructor() {} // 0x0000000183CE7560-0x0000000183CE75F0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BDAEC-0x00000001857BDB88
		}
	
		public delegate void _PowerInteractionEnd_000008BE_PostfixBurstDelegate(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder); // TypeDefIndex: 48982; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _PowerInteractionEnd_000008BE_BurstDirectCall // TypeDefIndex: 48983
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _PowerInteractionEnd_000008BE_BurstDirectCall() {} // 0x0000000183CE75F0-0x0000000183CE7600
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066efa) {} // 0x00000001857BD6E0-0x00000001857BD7E4
			private static IntPtr GetFunctionPointer() => default; // 0x00000001857BD7E4-0x00000001857BD838
			public static void Constructor() {} // 0x0000000183CE7600-0x0000000183CE7690
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857BD838-0x00000001857BD8D0
		}
	
		// Methods
		private void _BPNormalEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579E634-0x000000018579E71C
		private void _BPBuildEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579E0E8-0x000000018579E23C
		private void _BPBuildCutoffEffectExecute(ref SharedDataContainer.SharedExtData extData, ref AdditiveEffectRendererFragment effectRenderer, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579DD6C-0x000000018579DE50
		[BurstCompile]
		private static void _BPBuildStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018579E59C-0x000000018579E634
		[BurstCompile]
		private static void _BPBuildProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018579E460-0x000000018579E4F8
		[BurstCompile]
		private static void _BPBuildEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018579E354-0x000000018579E3EC
		[BurstCompile]
		private static void _BPBuildCutoffStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579E088-0x000000018579E0E8
		[BurstCompile]
		private static void _BPBuildCutoffStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579DEF0-0x000000018579DF50
		[BurstCompile]
		private static void _BPBuildCutoffStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579DFD0-0x000000018579E030
		public void SetSharedExtData(IntPtr data) {} // 0x00000001833253B0-0x00000001833253F0
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x000000018579DA5C-0x000000018579DADC
		[IDTag(0)]
		public void Execute(int index) {} // 0x000000018579D224-0x000000018579DA5C
		[BurstCompile]
		private static void _CutoffStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579F5D0-0x000000018579F630
		[BurstCompile]
		private static void _CutoffStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579F3FC-0x000000018579F45C
		[BurstCompile]
		private static void _CutoffStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579F4DC-0x000000018579F53C
		private static void _BuildStateStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018579EFA0-0x000000018579F13C
		private static void _BuildStateEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018579EC6C-0x000000018579EE24
		[BurstCompile]
		private static void _BuildStateProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018579EF08-0x000000018579EFA0
		[BurstCompile]
		private static void _HighLightStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579FF04-0x000000018579FF64
		[BurstCompile]
		private static void _HighLightEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579FA34-0x000000018579FA94
		[BurstCompile]
		private static void _HighLightProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579FCE4-0x000000018579FD44
		[BurstCompile]
		private static void _FigureStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579F8B4-0x000000018579F914
		[BurstCompile]
		private static void _FigureProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579F84C-0x000000018579F8AC
		[BurstCompile]
		private static void _FigureEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579F6E8-0x000000018579F748
		[BurstCompile]
		private static void _HintStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha) {} // 0x00000001857A0298-0x00000001857A030C
		[BurstCompile]
		private static void _HintEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0050-0x00000001857A00B0
		[BurstCompile]
		private static void _HintProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A00B0-0x00000001857A0110
		[BurstCompile]
		private static void _OverloadStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A08B4-0x00000001857A0914
		[BurstCompile]
		private static void _OverloadEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A03BC-0x00000001857A041C
		[BurstCompile]
		private static void _OverloadProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0768-0x00000001857A07C8
		[BurstCompile]
		private static void _OverloadInvalidStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0708-0x00000001857A0768
		[BurstCompile]
		private static void _OverloadInvalidEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A04CC-0x00000001857A052C
		[BurstCompile]
		private static void _OverloadInvalidProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A052C-0x00000001857A058C
		private static void _Repair0Start(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A10B8-0x00000001857A1180
		private static void _Repair0End(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0E98-0x00000001857A0F70
		[BurstCompile]
		private static void _Repair0Process(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x00000001857A1038-0x00000001857A10B8
		[BurstCompile]
		private static void _Repair1Start(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A1428-0x00000001857A1488
		[BurstCompile]
		private static void _Repair1End(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A1220-0x00000001857A1280
		[BurstCompile]
		private static void _Repair1Process(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x00000001857A1310-0x00000001857A1390
		private static void _BlueprintProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer) {} // 0x000000018579C120-0x000000018579C590
		[BurstCompile]
		private static void _BlueprintProcessInternal(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579EB5C-0x000000018579EBBC
		[BurstCompile]
		private static void _BlueprintEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer) {} // 0x000000018579E80C-0x000000018579E880
		[BurstCompile]
		private static void _BlueprintStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579EC0C-0x000000018579EC6C
		[BurstCompile]
		private static void _PreSelectStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0E38-0x00000001857A0E98
		[BurstCompile]
		private static void _PreSelectEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0C38-0x00000001857A0C98
		[BurstCompile]
		private static void _PreSelectProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0C98-0x00000001857A0CF8
		[BurstCompile]
		private static void _ContinuationStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579F2E8-0x000000018579F348
		[BurstCompile]
		private static void _ContinuationEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579F13C-0x000000018579F19C
		[BurstCompile]
		private static void _ContinuationProcess(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579F19C-0x000000018579F1FC
		[BurstCompile]
		private static void _SocialSharingStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A15AC-0x00000001857A160C
		[BurstCompile]
		private static void _PowerInteractionStart(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0B64-0x00000001857A0BC4
		[BurstCompile]
		private static void _PowerInteractionEnd(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A09A8-0x00000001857A0A08
		public static void ResetMaterial(ref HGFactoryRendererBinderComponent rendererBinder, ref SharedDataContainer.SharedExtData extData, bool resetRenderPass = true /* Metadata: 0x01FBBB06 */, bool resetAdditiveMat = true /* Metadata: 0x01FBBB07 */) {} // 0x000000018579DADC-0x000000018579DC94
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x00000001833253F0-0x0000000183325430
		[IDTag(0)]
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB08 */) => default; // 0x000000018579DC94-0x000000018579DD6C
		[IDTag(1)]
		public JobHandle ScheduleDefer(JobHandle jobHandleDep0, JobHandle jobHandleDep1, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB09 */) => default; // 0x0000000182BC0AA0-0x0000000182BC0BD0
		[BurstCompile]
		public static void _BPBuildStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018579E4F8-0x000000018579E59C
		[BurstCompile]
		public static void _BPBuildProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018579E3EC-0x000000018579E460
		[BurstCompile]
		public static void _BPBuildEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018579E23C-0x000000018579E354
		[BurstCompile]
		public static void _BPBuildCutoffStateStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579E030-0x000000018579E088
		[BurstCompile]
		public static void _BPBuildCutoffStateEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579DE50-0x000000018579DEF0
		[BurstCompile]
		public static void _BPBuildCutoffStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579DF50-0x000000018579DFD0
		[BurstCompile]
		public static void _CutoffStateStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579F53C-0x000000018579F5D0
		[BurstCompile]
		public static void _CutoffStateEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579F348-0x000000018579F3FC
		[BurstCompile]
		public static void _CutoffStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent binder) {} // 0x000000018579F45C-0x000000018579F4DC
		[BurstCompile]
		public static void _BuildStateProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve0, ref Beyond.Gameplay.Factory.FPtrNativeCurve alphaCurve1, long time) {} // 0x000000018579EE24-0x000000018579EF08
		[BurstCompile]
		public static void _HighLightStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579FD44-0x000000018579FF04
		[BurstCompile]
		public static void _HighLightEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579F914-0x000000018579FA34
		[BurstCompile]
		public static void _HighLightProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579FA94-0x000000018579FCE4
		[BurstCompile]
		public static void _FigureStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579F8AC-0x000000018579F8B4
		[BurstCompile]
		public static void _FigureProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579F748-0x000000018579F84C
		[BurstCompile]
		public static void _FigureEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579F630-0x000000018579F6E8
		[BurstCompile]
		public static void _HintStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, float colorTypeAlpha) {} // 0x00000001857A0110-0x00000001857A0298
		[BurstCompile]
		public static void _HintEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579FF64-0x00000001857A0050
		[BurstCompile]
		public static void _HintProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018350B670-0x000000018350B680
		[BurstCompile]
		public static void _OverloadStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A07C8-0x00000001857A08B4
		[BurstCompile]
		public static void _OverloadEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A030C-0x00000001857A03BC
		[BurstCompile]
		public static void _OverloadProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018350B670-0x000000018350B680
		[BurstCompile]
		public static void _OverloadInvalidStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A058C-0x00000001857A0708
		[BurstCompile]
		public static void _OverloadInvalidEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A041C-0x00000001857A04CC
		[BurstCompile]
		public static void _OverloadInvalidProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018350B670-0x000000018350B680
		[BurstCompile]
		public static void _Repair0Process_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x00000001857A0F70-0x00000001857A1038
		[BurstCompile]
		public static void _Repair1Start_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A1390-0x00000001857A1428
		[BurstCompile]
		public static void _Repair1End_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A1180-0x00000001857A1220
		[BurstCompile]
		public static void _Repair1Process_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref Beyond.Gameplay.Factory.FPtrNativeCurve curve, long time) {} // 0x00000001857A1280-0x00000001857A1310
		[BurstCompile]
		public static void _BlueprintProcessInternal_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579E880-0x000000018579EB5C
		[BurstCompile]
		public static void _BlueprintEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder, ref AdditiveEffectRendererFragment effectRenderer) {} // 0x000000018579E71C-0x000000018579E80C
		[BurstCompile]
		public static void _BlueprintStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579EBBC-0x000000018579EC0C
		[BurstCompile]
		public static void _PreSelectStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0CF8-0x00000001857A0E38
		[BurstCompile]
		public static void _PreSelectEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0BC4-0x00000001857A0C38
		[BurstCompile]
		public static void _PreSelectProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018350B670-0x000000018350B680
		[BurstCompile]
		public static void _ContinuationStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018579F1FC-0x000000018579F2E8
		[BurstCompile]
		public static void _ContinuationEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018350B670-0x000000018350B680
		[BurstCompile]
		public static void _ContinuationProcess_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x000000018350B670-0x000000018350B680
		[BurstCompile]
		public static void _SocialSharingStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A1488-0x00000001857A15AC
		[BurstCompile]
		public static void _PowerInteractionStart_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0A08-0x00000001857A0B64
		[BurstCompile]
		public static void _PowerInteractionEnd_BurstManaged(ref EntityManager rEntityManager, ref SharedDataContainer.SharedExtData extData, ref HGFactoryRendererBinderComponent rendererBinder) {} // 0x00000001857A0914-0x00000001857A09A8
	}

	public static class AudioJobs // TypeDefIndex: 48991
	{
		// Nested types
		public struct FAggregateEmitterTempData // TypeDefIndex: 48985
		{
			// Fields
			public float3 sumPos; // 0x00
			public float sumWeight; // 0x0C
			public int count; // 0x10
		}
	
		public struct FWaterPipeEmitterData // TypeDefIndex: 48986
		{
			// Fields
			public float3 posData; // 0x00
			public float2 extraData; // 0x0C
			public float sumWeight; // 0x14
			public int count; // 0x18
		}
	
		public struct FGroupEmitterTempData // TypeDefIndex: 48987
		{
			// Fields
			public float3x3 sumPos; // 0x00
			public float3 sumWeight; // 0x24
			public float3 count; // 0x30
			public int inMainRegionActiveCount; // 0x3C
		}
	
		[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
		public struct AudioDistanceAndCullingJob : IJobParallelFor // TypeDefIndex: 48988
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
			public void Execute(int index) {} // 0x00000001857AD0F0-0x00000001857AD30C
		}
	
		[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
		public struct AudioGroupEmitterJob : IJobParallelFor // TypeDefIndex: 48989
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
			public void Execute(int index) {} // 0x00000001857AD30C-0x00000001857AD928
			public void SetSharedExtData(IntPtr data) {} // 0x0000000182762ED0-0x0000000182762F10
		}
	
		[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
		public struct WaterPipeEmitterJob : IJobParallelFor // TypeDefIndex: 48990
		{
			// Fields
			[ReadOnly]
			public float3 listenerPos; // 0x00
			[NoAlias]
			public EntityQueryV2.QueryResult qr; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<FWaterPipeEmitterData> tempEmitterData; // 0x30
			[ReadOnly]
			public float outerRadiusSq; // 0x40
			[NativeDisableUnsafePtrRestriction]
			public unsafe GlobalEnv* envPtr; // 0x48
	
			// Methods
			public void Execute(int index) {} // 0x00000001857B7830-0x00000001857B79A0
			private void _DoCalculate(int index, ref PipeFragment unit) {} // 0x00000001857B79A0-0x00000001857B7C5C
			public void SetGlobalEnv(ref GlobalEnv env) {} // 0x00000001832071A0-0x00000001832071E0
		}
	
		// Methods
		private static void _EntityIdx(int groupIdx, EntityQueryV2.BlockRange blockRange, GroupType group, out int startEntityIdx, out int endEntityIdx) {
			startEntityIdx = default;
			endEntityIdx = default;
		} // 0x00000001857ACC7C-0x00000001857ACF14
		[Conditional("BEYOND_DEBUG")]
		private static void _SetDebugGizmosType(ref AudioFragment audioFrag, AudioDebugGizmosType t) {} // 0x000000018350B670-0x000000018350B680
	}

	[BurstCompile]
	public struct BatchArrowJob : IJob // TypeDefIndex: 48992
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
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x4E8
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x4F0
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x4F8
		public float4 normalColor; // 0x500
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x510
	
		// Methods
		private void _ExecutePort(int index, EntityQueryV2.QueryResult qr) {} // 0x00000001857AE694-0x00000001857AED24
		private void _ExecutePreview(int index, EntityQueryV2.QueryResult qr) {} // 0x00000001857AED24-0x00000001857AF29C
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857AD9E0-0x00000001857ADAA4
		private void _BatchPortArrow(bool formulaManMode, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, float mapHeightValue, bool inOut, bool preview = false /* Metadata: 0x01FBBB0A */, bool inBuildMode = false /* Metadata: 0x01FBBB0B */, bool inMainRegion = true /* Metadata: 0x01FBBB0C */, bool buildingBelt = true /* Metadata: 0x01FBBB0D */, bool buildingPipe = true /* Metadata: 0x01FBBB0E */, bool blueprintSelectedUnit = false /* Metadata: 0x01FBBB0F */, bool inputDisabled = false /* Metadata: 0x01FBBB10 */, bool outputDisabled = false /* Metadata: 0x01FBBB11 */, bool inputFluidDisabled = false /* Metadata: 0x01FBBB12 */, bool outputFluidDisabled = false /* Metadata: 0x01FBBB13 */) {} // 0x00000001857ADAA4-0x00000001857AE694
		public void SetSharedExtData(IntPtr data) {} // 0x00000001826DBDA0-0x00000001826DBDE0
		[IDTag(1)]
		public void Execute() {} // 0x00000001857AD928-0x00000001857AD9E0
	}

	[BurstCompile]
	public struct BatchInsideConveyorJob : IJob // TypeDefIndex: 48993
	{
		// Fields
		public EntityQueryV2.QueryResult normalQr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public GlobalEnv globalEnv; // 0x20
		public UnsafeList<float4x4> conveyorInsideMatrices; // 0x498
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x4A0
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x4A8
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857AF29C-0x00000001857AF314
		private void _CollectInsideConveyor(int index, EntityQueryV2.QueryResult qr) {} // 0x00000001857AF7AC-0x00000001857AFCA0
		private void _BatchPortInside(uint nodeId, float3 pos, quaternion rot, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, ref ComplexPortFragment ports, bool bInOut, float mapHeightValue, bool blueprintSelectedUnit) {} // 0x00000001857AF390-0x00000001857AF7AC
		public void SetSharedExtData(IntPtr data) {} // 0x00000001826DBDE0-0x00000001826DBE20
		[IDTag(1)]
		public void Execute() {} // 0x00000001857AF314-0x00000001857AF390
	}

	[BurstCompile]
	public struct BatchNormalArrowJob : IJob // TypeDefIndex: 48994
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
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x4C8
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x4D0
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x4D8
		public float4 normalColor; // 0x4E0
		public UnsafeParallelHashMap<int, bool> arrowPlacedDic; // 0x4F0
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x500
	
		// Methods
		private void _ExecutePort(int index, EntityQueryV2.QueryResult qr) {} // 0x00000001857B0A40-0x00000001857B10CC
		private void _BatchPortArrow(uint nodeId, bool formulaManMode, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, float mapHeightValue, bool inOut, bool inBuildMode = false /* Metadata: 0x01FBBB14 */, bool inMainRegion = true /* Metadata: 0x01FBBB15 */, bool buildingBelt = true /* Metadata: 0x01FBBB16 */, bool buildingPipe = true /* Metadata: 0x01FBBB17 */, bool inputDisabled = false /* Metadata: 0x01FBBB18 */, bool outputDisabled = false /* Metadata: 0x01FBBB19 */, bool inputFluidDisabled = false /* Metadata: 0x01FBBB1A */, bool outputFluidDisabled = false /* Metadata: 0x01FBBB1B */) {} // 0x00000001857AFDFC-0x00000001857B0A40
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857AFD28-0x00000001857AFDA0
		[IDTag(1)]
		public void Execute() {} // 0x00000001857AFCA0-0x00000001857AFD28
		public void SetSharedExtData(IntPtr data) {} // 0x00000001857AFDA0-0x00000001857AFDFC
	}

	[BurstCompile]
	public struct BatchPreviewArrowJob : IJob // TypeDefIndex: 48995
	{
		// Fields
		[NoAlias]
		public EntityManager em; // 0x00
		public EntityQueryV2.QueryResult previewQr; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public GlobalEnv globalEnv; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe PortArrowRendererInfoCollection<PortArrowRendererInfo>* outputMatrices; // 0x4A8
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> regionPosValidFuncPtr; // 0x4B0
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x4B8
		public float4 normalColor; // 0x4C0
		public UnsafeParallelHashMap<int, bool> arrowPlacedDic; // 0x4D0
		[NativeSetThreadIndex]
		private int m_threadIndex; // 0x4E0
	
		// Methods
		public void Execute() {} // 0x00000001857B10CC-0x00000001857B1168
		private void _ExecutePreview(int index, EntityQueryV2.QueryResult qr) {} // 0x00000001857B1B84-0x00000001857B20B0
		private void _BatchPortArrow(bool formulaManMode, ref FixedList512Bytes<FactoryUnitPortConfig> portConfigs, quaternion rot, float3 pos, ComplexPortFragment ports, float4x4 uvList, float mapHeightValue, bool inOut, bool inBuildMode = false /* Metadata: 0x01FBBB1C */, bool inMainRegion = true /* Metadata: 0x01FBBB1D */) {} // 0x00000001857B11C4-0x00000001857B1B84
		public void SetSharedExtData(IntPtr data) {} // 0x00000001857B1168-0x00000001857B11C4
	}

	[BurstCompile]
	public struct BufferSwapJob : IJob // TypeDefIndex: 48996
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
		public void Execute() {} // 0x00000001857B20B0-0x00000001857B2168
	}

	[BurstCompile]
	public struct BuildingLiquidRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 48997
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
		public void Execute(int index) {} // 0x00000001857B2168-0x00000001857B2790
		private void _ApplyLiquidPerDraw(Entity rEntity, ValueTuple<int, uint> liquidData) {} // 0x0000000181062B80-0x0000000181063B70
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857B2790-0x00000001857B2810
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x0000000182BBA8F0-0x0000000182BBA930
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB1E */) => default; // 0x0000000182BBAC40-0x0000000182BBACF0
		public void SetSharedExtData(IntPtr data) {} // 0x0000000182BBA930-0x0000000182BBA970
	}

	[BurstCompile]
	public struct BuildingStatePosCollectJob : IJob // TypeDefIndex: 48998
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
		public void Execute(int index) {} // 0x00000001857B2810-0x00000001857B2A68
		private void _Collect(ref UnitFragment unit, ref UnitTransFragment trans, ref UnitConfigFragment config, ref UnitStatusFragment status, ref SharedDataFragment sharedData) {} // 0x00000001857B2B70-0x00000001857B30C8
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857B2A68-0x00000001857B2AF4
		[IDTag(2)]
		public void Execute() {} // 0x00000001857B2AF4-0x00000001857B2B70
		public void SetSharedExtData(IntPtr data) {} // 0x00000001826DBC20-0x00000001826DBC60
	}

	[BurstCompile]
	public struct BuildingStateRendererJob : IJobParallelFor // TypeDefIndex: 48999
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<float4x4> statePosList; // 0x20
	
		// Methods
		public void Execute(int index) {} // 0x00000001857B30C8-0x00000001857B3278
	}

	[BurstCompile]
	public struct CargoCollectJob : IJob // TypeDefIndex: 49000
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
		public void Execute(int index) {} // 0x00000001857B3278-0x00000001857B344C
		private unsafe void _Collect(CargoFragment* cargoFrag, ref SharedDataContainer.SharedExtData extData, ref ConveyorExtContainer.ConveyorExt conveyorExt) {} // 0x00000001857B34F8-0x00000001857B3728
		[IDTag(1)]
		public void Execute() {} // 0x00000001857B344C-0x00000001857B34F8
		public void SetGlobalEnvRef(ref GlobalEnv envRef) {} // 0x0000000183325470-0x00000001833254B0
		public void SetConveyorExtData(IntPtr data) {} // 0x00000001833254B0-0x00000001833254F0
		public void SetSharedExtData(IntPtr data) {} // 0x0000000183325430-0x0000000183325470
	}

	[BurstCompile]
	public struct CargoPredictJob : IJobParallelFor, IJobParallelForDefer // TypeDefIndex: 49001
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
		public void Execute(int index) {} // 0x00000001857B3728-0x00000001857B3B44
		public void SetConveyorExtData(IntPtr data) {} // 0x00000001826DF630-0x00000001826DF670
		public void SetSharedExtData(IntPtr data) {} // 0x00000001826DF5F0-0x00000001826DF630
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x00000001826DF5B0-0x00000001826DF5F0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB1F */) => default; // 0x00000001826DE7F0-0x00000001826DE8A0
	}

	[BurstCompile]
	public struct CargoPredictQueryJob : IJob // TypeDefIndex: 49002
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute() {} // 0x00000001857B3B44-0x00000001857B3C20
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x01FBBB20 */) {} // 0x00000001826DF670-0x00000001826DF6F0
	}

	[BurstCompile]
	public struct CargoRenderJob : IJobParallelForDefer, IJobParallelFor // TypeDefIndex: 49003
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public unsafe CargoRendererInfoCollection<CargoRendererInfo>* rendererList; // 0x20
	
		// Methods
		public void Execute(int index) {} // 0x00000001857B3C20-0x00000001857B3DAC
		public void SetRendererList(IntPtr data) {} // 0x00000001824F4880-0x00000001824F48C0
	}

	[BurstCompile]
	public struct CargoRenderQueryJob : IJob // TypeDefIndex: 49004
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute() {} // 0x00000001857B3DAC-0x00000001857B3E68
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x01FBBB21 */) {} // 0x00000001857B3E68-0x00000001857B3EE4
	}

	[BurstCompile]
	public struct ConveyorCollectJob : IJob // TypeDefIndex: 49005
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
		public void Execute(int index) {} // 0x00000001857B3EE4-0x00000001857B409C
		private void _Collect(ref ConveyorFragment conveyor, ref SharedDataFragment sharedDataFrag, bool preview, bool valid) {} // 0x00000001857B41A4-0x00000001857B4588
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857B409C-0x00000001857B4128
		[IDTag(2)]
		public void Execute() {} // 0x00000001857B4128-0x00000001857B41A4
		public void SetSharedExtData(IntPtr data) {} // 0x000000018322B730-0x000000018322B7B0
	}

	[BurstCompile]
	public struct ConveyorFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 49006
	{
		// Fields
		public int startOffsetIndex; // 0x00
		public float conveyorOffsetY; // 0x04
		public float simpleDrawingType; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public IntPtr dataMatrices; // 0x10
		public NativeArray<Entity> rendererEntities; // 0x18
		public EntityManager em; // 0x28
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857B4614-0x00000001857B47F8
		private void _UpdateCachedConveyor(Entity cachedEntity, uint sharedDataHandle, float adjustGroundHeight, float3 pos, float3 rot, float conveyorIdx, float conveyorLength, float speed, bool preview, float offsetY, bool valid = true /* Metadata: 0x01FBBB22 */, bool highlight = false /* Metadata: 0x01FBBB23 */, bool selectTypeInvalid = true /* Metadata: 0x01FBBB24 */) {} // 0x00000001857B47F8-0x00000001857B4A54
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857B4588-0x00000001857B4614
		public void SetSharedExtData(IntPtr data) {} // 0x0000000182F533B0-0x0000000182F533F0
	}

	[BurstCompile]
	public struct ConveyorInsideRenderJob : IJobParallelFor // TypeDefIndex: 49007
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
		public void Execute(int index) {} // 0x00000001857B4A54-0x00000001857B4CD8
	}

	[BurstCompile]
	public struct ConveyorPreviewCollectJob : IJob // TypeDefIndex: 49008
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
		public void Execute(int index) {} // 0x00000001857B4CD8-0x00000001857B4EAC
		private void _Collect(ref ConveyorPreviewRendererFragment conveyor, ref SharedDataFragment sharedData, bool preview, bool valid) {} // 0x00000001857B4F28-0x00000001857B5148
		[IDTag(1)]
		public void Execute() {} // 0x00000001857B4EAC-0x00000001857B4F28
		public void SetSharedExtData(IntPtr data) {} // 0x00000001826DBC60-0x00000001826DBCA0
	}

	[BurstCompile]
	public struct ConveyorRendererJob : IJobParallelForBatch // TypeDefIndex: 49009
	{
		// Fields
		public float conveyorOffsetY; // 0x00
		public EntityManager em; // 0x08
		public NativeArray<Entity> rendererEntities; // 0x18
		[NativeDisableUnsafePtrRestriction]
		public IntPtr dataMatrices; // 0x28
		[NativeDisableUnsafePtrRestriction]
		public IntPtr previewDataMatrices; // 0x30
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x38
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857B51C8-0x00000001857B5418
		private void _UpdateCachedConveyor(Entity cachedEntity, float adjustGroundHeight, uint sharedDataHandle, float3 pos, float3 rot, float conveyorIdx, float conveyorLength, float speed, bool preview, BlueprintState.EffectType blueprintRenderType, float offsetY, uint lightMode, bool valid = true /* Metadata: 0x01FBBB25 */, bool highlight = false /* Metadata: 0x01FBBB26 */, bool selectTypeInvalid = true /* Metadata: 0x01FBBB27 */) {} // 0x00000001857B5418-0x00000001857B58F0
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857B5148-0x00000001857B51C8
		public void SetSharedExtData(IntPtr data) {} // 0x0000000182F51DC0-0x0000000182F51E00
	}

	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public struct InteractFacCollectJob : IJob // TypeDefIndex: 49013
	{
		// Fields
		public float3 targetPosition; // 0x00
		public float3 targetForward; // 0x0C
		public float maxAngle; // 0x18
		public float maxDist; // 0x1C
		public float radiusExpand; // 0x20
		public const float ROLE_HIGH_ADDED_VALUE = 2f; // Metadata: 0x01FBBB28
		public const float PIPE_HEIGHT_RANGE = 4f; // Metadata: 0x01FBBB2C
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
		public struct BuildingInfoWrap // TypeDefIndex: 49010
		{
			// Fields
			public BuildingInfo buildingInfo; // 0x00
	
			// Properties
			public UnitConfigFragment unitConfig { [IsReadOnly] get; set; } // 0x0000000183D565C0-0x0000000183D56600 0x0000000183D56600-0x0000000183D56640
	
			// Methods
			public unsafe void SwapTo(BuildingInfoWrap* other) {} // 0x00000001857BF4C8-0x00000001857BF508
		}
	
		public struct BuildingInfo // TypeDefIndex: 49011
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
			public string templateName { get => default; } // 0x0000000182763320-0x0000000182763330 
	
			// Methods
			public override string ToString() => default; // 0x00000001857BF5D0-0x00000001857BF730
			public void SetData([IsReadOnly] in BuildingInfo info) {} // 0x00000001857BF508-0x00000001857BF5D0
			public bool IsPending() => default; // 0x0000000182AAED30-0x0000000182AAED60
			public string __iFixBaseProxy_ToString() => default; // 0x00000001857BF730-0x00000001857BF7B0
		}
	
		public struct LogisticInfo // TypeDefIndex: 49012
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
			public bool IsPending() => default; // 0x00000001857C0C74-0x00000001857C0CC4
			public unsafe void SwapTo(LogisticInfo* other) {} // 0x00000001857C0CC4-0x00000001857C0D0C
		}
	
		// Constructors
		static InteractFacCollectJob() {
			LOGISTIC_INTERACT_SAMPLE_OFFSETS = default;
		} // 0x0000000183925820-0x0000000183925B50
	
		// Methods
		private void _SwapBuffer() {} // 0x00000001857B77A4-0x00000001857B7830
		public void Execute() {} // 0x00000001857B58F0-0x00000001857B5988
		private void _ExecuteBuilding() {} // 0x00000001857B5DE8-0x00000001857B6F48
		private void _ExecuteConveyor() {} // 0x00000001857B6F48-0x00000001857B7240
		private void _ExecutePipe() {} // 0x00000001857B7240-0x00000001857B756C
		private bool _CheckDist(float3 pos, float distSqThreshold, ref int minSearchIndex) => default; // 0x00000001857B5988-0x00000001857B5DE8
		private static float3 _SnapDirectionToAxis(float3 direction) => default; // 0x00000001857B756C-0x00000001857B77A4
		public void SetSharedExtData(IntPtr data) {} // 0x00000001831E6E60-0x00000001831E6EF0
	}

	[BurstCompile]
	public struct LocalToWorldJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 49014
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityQueryV2.QueryResultDefer* qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityHierarchyContainer.EntityTransformData* hierarchyDataPtr; // 0x08
		public int frameCount; // 0x10
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C06B8-0x00000001857C0810
		public static void TransTRS(ref LocalToWorld localToWorld, IntPtr hierarchyIntPtr, int frameCount = -1 /* Metadata: 0x01FBBB30 */) {} // 0x00000001828B4730-0x00000001828B47E0
		public static unsafe void TransTRS(ref LocalToWorld localToWorld, EntityHierarchyContainer.EntityTransformData* hierarchyPtr, int frameCount = -1 /* Metadata: 0x01FBBB31 */) {} // 0x00000001828B48A0-0x00000001828B4AF0
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C0638-0x00000001857C06B8
		public void SetHierarchyData(IntPtr data) {} // 0x0000000182BBF010-0x0000000182BBF050
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x0000000182BBEFD0-0x0000000182BBF010
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB32 */) => default; // 0x0000000182BBEF20-0x0000000182BBEFD0
	}

	[BurstCompile]
	public struct LocalToWorldQueryJob : IJob // TypeDefIndex: 49015
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute() {} // 0x00000001857C0810-0x00000001857C08EC
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x01FBBB33 */) {} // 0x0000000182BBF050-0x0000000182BBF0D0
	}

	[BurstCompile]
	public struct LogisticEffectJob : IJobParallelFor // TypeDefIndex: 49016
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public long deltaTime; // 0x20
	
		// Methods
		public void Execute(int index) {} // 0x00000001857C08EC-0x00000001857C0C74
	}

	[BurstCompile]
	public struct LookAtJob : IJobParallelFor, IJobParallelForDefer // TypeDefIndex: 49017
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe EntityHierarchyContainer.EntityTransformData* hierarchyDataPtr; // 0x08
	
		// Methods
		public void Execute(int index) {} // 0x00000001857C0D0C-0x00000001857C151C
		public void SetHierarchyData(IntPtr data) {} // 0x00000001826DFA60-0x00000001826DFAA0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x00000001826DFAA0-0x00000001826DFAE0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB34 */) => default; // 0x00000001826DFD50-0x00000001826DFE00
	}

	[BurstCompile]
	public struct LookAtQueryJob : IJob // TypeDefIndex: 49018
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute() {} // 0x00000001857C151C-0x00000001857C15D8
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x01FBBB35 */) {} // 0x00000001826DF6F0-0x00000001826DF770
	}

	[BurstCompile]
	public struct OutputCollectJob : IJob // TypeDefIndex: 49019
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
		public void Execute(int index) {} // 0x00000001857C1710-0x00000001857C198C
		private void _Collect(ref UnitFragment unit, ref UnitTransFragment trans, ref UnitConfigFragment config, ref OutputFragment output, ref SharedDataFragment sharedData) {} // 0x00000001857C198C-0x00000001857C1DAC
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C15D8-0x00000001857C1664
		[IDTag(2)]
		public void Execute() {} // 0x00000001857C1664-0x00000001857C1710
		public void SetSharedExtData(IntPtr data) {} // 0x00000001826DBCE0-0x00000001826DBD20
	}

	[BurstCompile]
	public struct OutputRenderJob : IJobParallelFor // TypeDefIndex: 49020
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<OutputRendererInfo> posList; // 0x20
	
		// Methods
		public void Execute(int index) {} // 0x00000001857C1DAC-0x00000001857C2168
	}

	[BurstCompile]
	public struct PedestalFlashJob : IJobParallelForBatch // TypeDefIndex: 49021
	{
		// Fields
		public EntityQueryV2.QueryResult qr; // 0x00
		public long time; // 0x20
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedExtDataPtr; // 0x28
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C21E8-0x00000001857C245C
		private float4 _Flash(ref PedestalLightFlashFragment flashConfig, float deltaTime) => default; // 0x00000001857C245C-0x00000001857C2580
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C2168-0x00000001857C21E8
		public void SetSharedExtData(IntPtr data) {} // 0x000000018346C8E0-0x000000018346C920
	}

	[BurstCompile]
	public struct PipeCollectJob : IJob // TypeDefIndex: 49022
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
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* trackLPosMatrices; // 0x58
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* trackMPosMatrices; // 0x60
		[NativeDisableUnsafePtrRestriction]
		public unsafe PipeTrackRendererInfoCollection<PipeTrackRendererInfo>* trackRPosMatrices; // 0x68
		public UnsafeList<float4x4> comPosMatrices; // 0x70
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x78
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* envPtr; // 0x80
	
		// Properties
		public int pipeCount { get => default; } // 0x00000001857C3D40-0x00000001857C3D70 
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C2AD8-0x00000001857C2BEC
		private void _ExecutePipe(EntityQueryV2.BlockRange blockRange, NativeList<GroupType> groups) {} // 0x00000001857C383C-0x00000001857C3AE0
		private void _ExecutePreviewPipe(EntityQueryV2.BlockRange blockRange, NativeList<GroupType> groups) {} // 0x00000001857C3AE0-0x00000001857C3D40
		private void _CollectPipe(int pipeLength, uint memoryStartOffset, uint memoryEndOffset, int subItemType, float waterThickness, float waterFlowDeltaTime, float waterDirection, float pipeHeight, uint sharedDataHandle, bool isPreview = false /* Metadata: 0x01FBBB36 */, bool valid = true /* Metadata: 0x01FBBB37 */, bool highLight = false /* Metadata: 0x01FBBB38 */) {} // 0x00000001857C316C-0x00000001857C35D8
		private void _CollectPipeCom([IsReadOnly] in PipeFragment pipe, uint sharedDataHandle) {} // 0x00000001857C2C78-0x00000001857C316C
		private void _CollectTrack(int pipeLength, uint memoryStartOffset, uint memoryEndOffset, float pipeHeight, float gridPathHeightStart, float gridPathHeightEnd, uint sharedDataHandle, bool pipeValid) {} // 0x00000001857C35D8-0x00000001857C383C
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C2BEC-0x00000001857C2C78
		[IDTag(2)]
		public void Execute() {} // 0x00000001857C2A5C-0x00000001857C2AD8
		public void SetGlobalEnvRef(ref GlobalEnv envRef) {} // 0x00000001826DBD20-0x00000001826DBD60
		public void SetSharedExtData(IntPtr data) {} // 0x00000001826DBD60-0x00000001826DBDA0
	}

	[BurstCompile]
	public struct PipeComRendererJob : IJobParallelForBatch // TypeDefIndex: 49023
	{
		// Fields
		public EntityManager em; // 0x00
		public UnsafeList<float4x4> comPosArr; // 0x10
		public NativeArray<Entity> rendererEntities; // 0x20
		public bool useDistanceFilter; // 0x30
		public float2 distanceFilterCenterPos; // 0x34
		public float distanceThreshold; // 0x3C
	
		// Methods
		public void Execute(int startIndex, int count) {} // 0x00000001857C3D70-0x00000001857C4090
	}

	[BurstCompile]
	public struct PipeFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 49024
	{
		// Fields
		public int startOffsetIndex; // 0x00
		public float simpleDrawingType; // 0x04
		[NativeDisableUnsafePtrRestriction]
		public IntPtr dataMatrices; // 0x08
		public NativeArray<Entity> rendererEntities; // 0x10
		public EntityManager em; // 0x20
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C4090-0x00000001857C4350
		private void _UpdateCachedPipe(Entity cachedEntity, byte protoType, float3 pos, float3 rot, float indexInPipe, float pipeLength, float waterDirection, float waterThickness, float pipeHeight, float subItemType, bool isPreview = false /* Metadata: 0x01FBBB39 */, bool valid = true /* Metadata: 0x01FBBB3A */, bool highLight = false /* Metadata: 0x01FBBB3B */) {} // 0x00000001857C43DC-0x00000001857C46E8
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C4350-0x00000001857C43DC
	}

	[BurstCompile]
	public struct PipeHolderFigureRendererJob : IJobParallelForBatch // TypeDefIndex: 49025
	{
		// Fields
		public EntityManager em; // 0x00
		public float offsetY; // 0x10
		public UnsafeList<Matrix4x4> dataMatrices; // 0x18
		public NativeArray<Entity> rendererEntities; // 0x28
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C4774-0x00000001857C49E8
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C46E8-0x00000001857C4774
	}

	[BurstCompile]
	public struct PipeHolderHideRendererJob : IJobParallelForBatch // TypeDefIndex: 49026
	{
		// Fields
		public bool drawPipe; // 0x00
		public EntityQueryV2.QueryResult holderQr; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x28
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C49E8-0x00000001857C4B74
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C4B74-0x00000001857C4C00
		public void SetSharedExtData(IntPtr data) {} // 0x0000000182F53740-0x0000000182F53780
	}

	[BurstCompile]
	public struct PipeLogisticsPosCollectJob : IJob // TypeDefIndex: 49027
	{
		// Fields
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x20
		public UnsafeList<Matrix4x4> posList; // 0x28
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C4D08-0x00000001857C505C
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C4C7C-0x00000001857C4D08
		public void SetSharedExtData(IntPtr data) {} // 0x00000001836D0C20-0x00000001836D0C60
		[IDTag(2)]
		public void Execute() {} // 0x00000001857C4C00-0x00000001857C4C7C
	}

	[BurstCompile]
	public struct PipeRendererJob : IJobParallelForBatch // TypeDefIndex: 49028
	{
		// Fields
		public EntityManager em; // 0x00
		public EntityManager rendererEntityManager; // 0x10
		public bool inTopView; // 0x20
		public bool useDistanceFilter; // 0x21
		public float2 distanceFilterCenterPos; // 0x24
		public float distanceThreshold; // 0x2C
		[NativeDisableUnsafePtrRestriction]
		public IntPtr dataMatrices; // 0x30
		public NativeArray<Entity> rendererEntities; // 0x38
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x48
	
		// Methods
		public void Execute(int startIndex, int count) {} // 0x00000001857C505C-0x00000001857C5334
		private void _UpdateCachedPipe(Entity cachedEntity, byte protoType, float3 pos, float3 rot, float bend, uint sharedDataHandle, int indexInPipe, int pipeLength, float waterDirection, float waterThickness, float subItemType, BlueprintState.EffectType blueprintRenderType, float waterFlowDeltaTime, uint lightMode, bool isPreview = false /* Metadata: 0x01FBBB3C */, bool valid = true /* Metadata: 0x01FBBB3D */, bool highLight = false /* Metadata: 0x01FBBB3E */) {} // 0x00000001857C5334-0x00000001857C5B88
		public void SetSharedExtData(IntPtr data) {} // 0x00000001826E3E00-0x00000001826E3E80
	}

	[BurstCompile]
	public struct PipeTrackRendererJob : IJob // TypeDefIndex: 49029
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
		public void Execute() {} // 0x00000001857C5B88-0x00000001857C5FAC
		private void _UpdateCachedTrack(Entity cachedEntity, float3 pos, float3 rot, float indexInPipe, float pipeLength, float pipeHeight, float gridPathHeight, float gridPathHeightEnd, bool valid) {} // 0x00000001857C5FAC-0x00000001857C6350
	}

	[BurstCompile]
	public struct PipeWaterThicknessQueryJob : IJob // TypeDefIndex: 49030
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_queryResult; // 0x18
	
		// Methods
		public void Execute() {} // 0x00000001857C6350-0x00000001857C640C
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer qr, bool resetQr = true /* Metadata: 0x01FBBB3F */) {} // 0x00000001826DF770-0x00000001826DF7F0
	}

	[BurstCompile]
	public struct PipeWaterThicknessRiseJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 49031
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		public float deltaTime; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* globalEnv; // 0x10
	
		// Methods
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C640C-0x00000001857C648C
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C648C-0x00000001857C6640
		public void SetGlobalEnv(ref GlobalEnv env) {} // 0x00000001826DF530-0x00000001826DF570
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x00000001826DF4F0-0x00000001826DF530
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB40 */) => default; // 0x00000001826DF440-0x00000001826DF4F0
	}

	[BurstCompile]
	public struct PortArrowRenderJob : IJobParallelFor // TypeDefIndex: 49032
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
		public void Execute(int index) {} // 0x00000001857C6640-0x00000001857C6914
	}

	[BurstCompile]
	public struct PortStateCollectJob : IJob // TypeDefIndex: 49033
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
		public void Execute(int index) {} // 0x00000001857C6A1C-0x00000001857C6BC0
		private void _Collect(ref ComplexPortFragment complexPortFrag, ref SharedDataContainer.SharedExtData extData) {} // 0x00000001857C6BC0-0x00000001857C6E44
		public void SetSharedExtData(IntPtr data) {} // 0x00000001826DBCA0-0x00000001826DBCE0
		[IDTag(1)]
		public void Execute() {} // 0x00000001857C69A0-0x00000001857C6A1C
		[IDTag(2)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C6914-0x00000001857C69A0
	}

	[BurstCompile]
	public struct PortStateRendererJob : IJobParallelFor // TypeDefIndex: 49034
	{
		// Fields
		public EntityManager em; // 0x00
		public NativeArray<Entity> rendererEntities; // 0x10
		public UnsafeList<float4x4> posList; // 0x20
	
		// Methods
		public void Execute(int index) {} // 0x00000001857C6E44-0x00000001857C703C
	}

	[BurstCompile]
	public struct PreviewUnitQueryJob : IJob // TypeDefIndex: 49035
	{
		// Fields
		public EntityManager em; // 0x00
		public int jobCount; // 0x10
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_previewUnitQr; // 0x18
	
		// Methods
		public void Execute() {} // 0x00000001857C703C-0x00000001857C70F8
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer previewUnitQr, bool resetQr = true /* Metadata: 0x01FBBB41 */) {} // 0x000000018306C940-0x000000018306C990
	}

	[BurstCompile]
	public struct PumpInEffectJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 49036
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
		public void Execute(int index) {} // 0x00000001857C7178-0x00000001857C75F0
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C70F8-0x00000001857C7178
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x0000000182BBA970-0x0000000182BBA9B0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB42 */) => default; // 0x0000000182BBADC0-0x0000000182BBAE70
		public void SetSharedExtData(IntPtr data) {} // 0x0000000182BBA9B0-0x0000000182BBA9F0
	}

	[BurstCompile]
	public struct StatusChangeJob : IJobParallelFor // TypeDefIndex: 49037
	{
		// Fields
		public EntityManager em; // 0x00
		public EntityQueryV2.QueryResult qr; // 0x10
		public EntityCommandBufferV2.EntityCommandBufferParallelWriter ecb; // 0x30
		public FunctionPointer<UnsafeJobFuncPointers.QueryBuildingState> queryBuildingState; // 0x60
		public FunctionPointer<UnsafeJobFuncPointers.SetEntityFlashStatue> setEntityFlashStatue; // 0x68
	
		// Methods
		public void Execute(int index) {} // 0x00000001857C75F0-0x00000001857C79A4
	}

	[BurstCompile]
	public struct UnitCullingJob : IJobParallelForBatch // TypeDefIndex: 49038
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
		public void Execute(int startIndex, int count) {} // 0x00000001857C7DA4-0x00000001857C7E24
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C79A4-0x00000001857C7DA4
		public void SetGlobalEnvRef(ref GlobalEnv envRef) {} // 0x0000000182C666A0-0x0000000182C666E0
		public void SetSharedExtData(IntPtr data) {} // 0x0000000182C66660-0x0000000182C666A0
	}

	[BurstCompile]
	public struct UnitPreviewRenderJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 49039
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
		public void Execute(int startIndex, int count) {} // 0x00000001857C8160-0x00000001857C81E0
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C7E24-0x00000001857C8160
		public void SetGlobalEnvRef(ref GlobalEnv envRef) {} // 0x000000018306C900-0x000000018306C940
		public void SetSharedExtData(IntPtr data) {} // 0x000000018306C8C0-0x000000018306C900
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x000000018306C880-0x000000018306C8C0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB43 */) => default; // 0x000000018306C790-0x000000018306C880
	}

	[BurstCompile]
	public struct UnitRendererQueryJob : IJob // TypeDefIndex: 49040
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
	
		// Methods
		public void Execute() {} // 0x00000001857C81E0-0x00000001857C8364
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer unitQr, ref EntityQueryV2.QueryResultDefer liquidQr, ref EntityQueryV2.QueryResultDefer pumpQr, bool resetQr = true /* Metadata: 0x01FBBB44 */) {} // 0x00000001826DF7F0-0x00000001826DF900
	}

	[BurstCompile]
	public struct UpdateUnitRendererTRSJob : IJobParallelForBatch, IJobParallelForDefer // TypeDefIndex: 49041
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe EntityQueryV2.QueryResultDefer* m_qr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x08
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C83F0-0x00000001857C85B0
		private void _Transform(ref HGFactoryRendererBinderComponent rendererBinder, ref LocalToWorld localToWorld, ref SharedDataFragment sharedData) {} // 0x00000001857C85B0-0x00000001857C8664
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C8364-0x00000001857C83F0
		public void SetSharedExtData(IntPtr data) {} // 0x0000000182BBA870-0x0000000182BBA8B0
		public void SetQueryResult(ref EntityQueryV2.QueryResultDefer data) {} // 0x0000000182BBA8B0-0x0000000182BBA8F0
		public JobHandle ScheduleDefer(JobHandle jobHandle, int innerLoopBatchCount = 1 /* Metadata: 0x01FBBB45 */) => default; // 0x0000000182BBAE70-0x0000000182BBB120
	}

	[BurstCompile]
	public struct WireCollectJob : IJob // TypeDefIndex: 49042
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
		public void Execute(int index) {} // 0x00000001857C8664-0x00000001857C8C9C
		private bool _IsNormalConnection(FacBuildingState state) => default; // 0x00000001857BF460-0x00000001857BF4C8
		private bool _IsDisabledConnection(FacBuildingState state) => default; // 0x00000001857BF450-0x00000001857BF460
		[IDTag(1)]
		public void Execute() {} // 0x00000001857C8C9C-0x00000001857C8D48
		public void SetGlobalEnvRef(ref GlobalEnv envRef) {} // 0x0000000182765640-0x0000000182765680
		public void SetSharedExtData(IntPtr data) {} // 0x0000000182765680-0x00000001827656C0
	}

	[BurstCompile]
	public struct WireRenderJob : IJobParallelForBatch // TypeDefIndex: 49043
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public IntPtr dataMatrices; // 0x00
		public EntityManager em; // 0x08
		public NativeArray<Entity> rendererEntities; // 0x18
	
		// Methods
		[IDTag(0)]
		public void Execute(int index) {} // 0x00000001857C8DD4-0x00000001857C8ED0
		private void _UpdateCachedWire(Entity cachedEntity, WireRendererInfo arg) {} // 0x00000001857C8ED0-0x00000001857C90A8
		[IDTag(1)]
		public void Execute(int startIndex, int count) {} // 0x00000001857C8D48-0x00000001857C8DD4
	}

	public struct FactoryBuildingEffectData : IEventData // TypeDefIndex: 49044
	{
		// Fields
		public Entity buildingLogicEntity; // 0x00
		public AdditiveEffectFragment.AdditiveEffectType effectType; // 0x08
	}

	public struct FPtrNativeCurve // TypeDefIndex: 49045
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe float* m_values; // 0x00
		private int m_valuesLength; // 0x08
		private UnityEngine.WrapMode m_preWrapMode; // 0x0C
		private UnityEngine.WrapMode m_postWrapMode; // 0x10
	
		// Methods
		public bool IsValid() => default; // 0x00000001857BFB5C-0x00000001857BFBAC
		public NativeArray<float> CreateCurve(AnimationCurve curve, int resolution) => default; // 0x00000001833D9B30-0x00000001833D9D80
		public float Evaluate(float t) => default; // 0x00000001857BF9C8-0x00000001857BFB5C
		private float _Repeat(float t, float length) => default; // 0x0000000184277234-0x0000000184277280
		private float _Pingpong(float t, float length) => default; // 0x00000001842786BC-0x00000001842786F0
	}

	[Serializable]
	public struct PerDrawConfigArray // TypeDefIndex: 49046
	{
		// Fields
		public const int MAX_COUNT = 10; // Metadata: 0x01FBBB46
		public PerDrawConfig[] perDrawConfigArray; // 0x00
		public PerDrawPassConfig[] passConfigArray; // 0x08
	}

	[Serializable]
	public struct PerDrawPassConfig // TypeDefIndex: 49047
	{
		// Fields
		public bool enable; // 0x00
		[HideInInspector]
		public uint lightModeRaw; // 0x01
	
		// Properties
		public PerDrawLightMode lightMode { get => default; set {} } // 0x0000000183D56660-0x0000000183D56670 0x0000000183D56670-0x0000000183D56680
	
		// Methods
		public int Size() => default; // 0x00000001857C283C-0x00000001857C288C
		[IDTag(0)]
		public void Apply(Entity rendererEntity, ref uint currentLightMode) {} // 0x00000001857C2714-0x00000001857C27B8
		[IDTag(1)]
		public void Apply(HGFactoryRendererBinderComponent binder, ref uint currentLightMode) {} // 0x00000001857C27B8-0x00000001857C283C
		private HGShaderLightMode _ParseToHGShaderLightMode(PerDrawLightMode value) => default; // 0x00000001857C288C-0x00000001857C2A5C
	}

	[Serializable]
	public struct PerDrawConfig // TypeDefIndex: 49048
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
		public static int Size() => default; // 0x00000001857C2580-0x00000001857C25C4
		public void OnValidate() {} // 0x00000001832BBE50-0x00000001832BBEA0
		private void _OnPerDrawTypeChanged() {} // 0x00000001832BBEA0-0x00000001832BBF90
		private void _OnColorChanged(UnityEngine.Color c) {} // 0x00000001857C25C4-0x00000001857C2634
		private void _OnFloat4Changed(float4 f) {} // 0x00000001857C2634-0x00000001857C269C
		private void _OnFloatChanged(float f) {} // 0x00000001857C269C-0x00000001857C2714
		public void Apply(HGFactoryRendererBinderComponent binder) {} // 0x0000000182421A10-0x0000000182421B20
	}

	public enum LogicEntityState // TypeDefIndex: 49049
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

	public class PerDrawDataOffsetAttribute : Attribute // TypeDefIndex: 49050
	{
		// Fields
		public System.Type type; // 0x10
		public int typeValue; // 0x18
	
		// Constructors
		public PerDrawDataOffsetAttribute() {} // Dummy constructor
		public PerDrawDataOffsetAttribute(System.Type type, int typeValue) {} // 0x0000000183C805B0-0x0000000183C805D0
	}

	public enum LogicEntityType // TypeDefIndex: 49051
	{
		CONVEYOR = 0,
		PIPE = 1,
		BUILDING = 2,
		INDICATOR = 3,
		GRID = 4,
		MAX = 5
	}

	public enum PerDrawOffset // TypeDefIndex: 49052
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
	public enum PerDrawLightMode : uint // TypeDefIndex: 49053
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

	public static class PerDrawDataOffset // TypeDefIndex: 49054
	{
		// Fields
		public const int BASE_COLOR = 0; // Metadata: 0x01FBBBA8
		public const int EMISSIVE_COLOR = 16; // Metadata: 0x01FBBBA9
		public const int SOCIAL_SIGN_ICON_INDEX = 60; // Metadata: 0x01FBBBAA
		public const int CUTOFF_POS_Y = 32; // Metadata: 0x01FBBBAB
		public const int EMISSIVE_LUT_INDEX = 36; // Metadata: 0x01FBBBAC
		public const int EMISSIVE_LUT_BIT_MASK = 40; // Metadata: 0x01FBBBAD
		public const int LIQUID_HEIGHT_INDEX = 44; // Metadata: 0x01FBBBAE
		public const int FACTORY_COLOR_TYPE = 48; // Metadata: 0x01FBBBAF
		public const int ENABLE_CUTOFF = 52; // Metadata: 0x01FBBBB0
		public const int EMISSIVE_ANIMATION_MODE = 56; // Metadata: 0x01FBBBB1
		public const int LIQUID_COLOR_INDEX = 60; // Metadata: 0x01FBBBB2
		public const int UI_ATLAS_UV = 0; // Metadata: 0x01FBBBB3
		public const int UI_LIQUID_ATLAS_UV = 16; // Metadata: 0x01FBBBB4
		public const int ENABLE_LIQUID_ICON = 68; // Metadata: 0x01FBBBB5
		public const int RARITY_COLOR = 48; // Metadata: 0x01FBBBB7
		public const int TINT_COLOR = 32; // Metadata: 0x01FBBBB8
		public const int INDICATOR_DATA = 64; // Metadata: 0x01FBBBB9
		public const int DISABLE_ICON_DEPTH_BLEND = 72; // Metadata: 0x01FBBBBB
		public const int GRID_MODE = 16; // Metadata: 0x01FBBBBD
		public const int RENDER_ON_WATER = 20; // Metadata: 0x01FBBBBE
		public const int OVERLOOK = 44; // Metadata: 0x01FBBBBF
		public const int ARROW_STEP_COUNT = 8; // Metadata: 0x01FBBBC0
		public const int SIMPLE_DRAWING_TYPE = 12; // Metadata: 0x01FBBBC1
		public const int TIME_OFFSET = 0; // Metadata: 0x01FBBBC2
		public const int ARROW_UV_SPEED = 4; // Metadata: 0x01FBBBC3
		public const int ENABLE_CONVEYOR_INDICATOR = 12; // Metadata: 0x01FBBBC4
		public const int ARROW_DATA = 16; // Metadata: 0x01FBBBC5
		public const int BELT_COLOR = 32; // Metadata: 0x01FBBBC6
		public const int FLOW_INTENSITY = 48; // Metadata: 0x01FBBBC7
		public const int BELT_COLOR_INTENSITY = 52; // Metadata: 0x01FBBBC8
		public const int BELT_COLOR_ALPHA = 56; // Metadata: 0x01FBBBC9
		public const int ELECTRIC_WIRE_ALPHA = 12; // Metadata: 0x01FBBBCA
		public const int VFX_TINT_COLOR_ALPHA = 44; // Metadata: 0x01FBBBCB
		public const int ELECTRIC_WIRE_LENGTH = 56; // Metadata: 0x01FBBBCC
		public const int WATER_THICKNESS = 0; // Metadata: 0x01FBBBCD
		public const int WATER_DELTA_TIME = 4; // Metadata: 0x01FBBBCE
		public const int TUBE_INDEX = 8; // Metadata: 0x01FBBBCF
		public const int TUBE_COUNT = 12; // Metadata: 0x01FBBBD0
		public const int WATER_DIRECTION = 16; // Metadata: 0x01FBBBD1
		public const int ENABLE_OVERLOOK_ARROW = 20; // Metadata: 0x01FBBBD2
		public const int TUBE_BEND_X_DEGREE = 24; // Metadata: 0x01FBBBD3
		public const int TUBE_BEND_TAG = 28; // Metadata: 0x01FBBBD4
		public const int GLASS_COLOR = 32; // Metadata: 0x01FBBBD5
		public const int ATLAS_UV_INDEX = 48; // Metadata: 0x01FBBBD6
		public const int ENABLE_TUBE_INDICATOR = 52; // Metadata: 0x01FBBBD7
		public const int DITHER_TRANSPARENT_ALPHA = 64; // Metadata: 0x01FBBBD8
		public const int BLUEPRINT_NOISE_ALPHA = 68; // Metadata: 0x01FBBBDA
		public const int FACTORY_VAT_FRAME = 72; // Metadata: 0x01FBBBDC
		public const int FACTORY_VAT_LAST_FRAME = 76; // Metadata: 0x01FBBBDE
	}

	public class ProcessorInterval // TypeDefIndex: 49055
	{
		// Constructors
		public ProcessorInterval() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static bool CheckInterval(ref IProcessor processor, float delta = 1f /* Metadata: 0x01FBBBE0 */, float rate = 1f /* Metadata: 0x01FBBBE4 */) => default; // 0x000000018230D4A0-0x000000018230D810
		private static bool _CheckInterval(float frameInterval, float intervalSetting, out float curInterval, float delta = 1f /* Metadata: 0x01FBBBE8 */, float rate = 1f /* Metadata: 0x01FBBBEC */) {
			curInterval = default;
			return default;
		} // 0x000000018230D810-0x000000018230D8E0
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public class CargoPredictProcessor : BaseProcessor // TypeDefIndex: 49056
	{
		// Properties
		public override bool lowFrameEnable { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public override string name { get => default; } // 0x00000001857BF85C-0x00000001857BF888 
	
		// Constructors
		public CargoPredictProcessor() {} // 0x0000000183D561E0-0x0000000183D561F0
	
		// Methods
		public override JobHandle Execute(ref EntityManager em, long time, long dt, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default; // 0x00000001826DE520-0x00000001826DE7F0
		public JobHandle __iFixBaseProxy_Execute(ref EntityManager P0, long P1, long P2, float P3, int P4, int P5, int P6, ref GlobalEnv P7, JobHandle P8, NativeList<JobHandle> P9) => default; // 0x00000001857BF7B0-0x00000001857BF85C
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public class CrossFrameProcessor : BaseProcessor // TypeDefIndex: 49057
	{
		// Fields
		private InteractFacCollectJob.BuildingInfo m_nearBuildingInfo; // 0x20
		private InteractFacCollectJob.LogisticInfo m_nearConveyorInfo; // 0x74
		private InteractFacCollectJob.LogisticInfo m_nearPipeInfo; // 0x94
		private InteractFacCollectJob.BuildingInfo m_nearBuildingInfoLast; // 0xB4
		private InteractFacCollectJob.LogisticInfo m_nearConveyorInfoLast; // 0x108
		private InteractFacCollectJob.LogisticInfo m_nearPipeInfoLast; // 0x128
		private const float MAX_BUILDING_INTERACT_RADIUS = 1.5f; // Metadata: 0x01FBBBF0
		private const float BUILDING_INTERACT_RADIUS_EXPAND = 0.6f; // Metadata: 0x01FBBBF4
	
		// Properties
		public override string name { get => default; } // 0x00000001857BF99C-0x00000001857BF9C8 
		public override bool lowFrameEnable { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public CrossFrameProcessor() {} // 0x0000000183D561E0-0x0000000183D561F0
	
		// Methods
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting) {} // 0x0000000183B290B0-0x0000000183B29160
		public override JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle) => default; // 0x00000001826E8330-0x00000001826E8CD0
		public override void TearDown(ref EntityManager em, ref GlobalEnv env) {} // 0x00000001857BF888-0x00000001857BF920
		public void __iFixBaseProxy_Initialize(ref EntityManager P0, ref GlobalEnv P1, FactorySetting P2) {} // 0x00000001857BF920-0x00000001857BF930
		public JobHandle __iFixBaseProxy_LateExecute(ref EntityManager P0, ref GlobalEnv P1, int P2, int P3, int P4, JobHandle P5) => default; // 0x00000001857BF930-0x00000001857BF994
		public void __iFixBaseProxy_TearDown(ref EntityManager P0, ref GlobalEnv P1) {} // 0x00000001857BF994-0x00000001857BF99C
	}

	public abstract class EntityDestroyReactiveProcessor<T> : ReactiveProcessor<T> // TypeDefIndex: 49058
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

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public class FacRendererCollectProcessor : BaseProcessor // TypeDefIndex: 49059
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
		public override string name { get => default; } // 0x00000001857C060C-0x00000001857C0638 
	
		// Constructors
		public FacRendererCollectProcessor() {} // 0x0000000183D56640-0x0000000183D56660
		static FacRendererCollectProcessor() {} // 0x0000000183D2C4E0-0x0000000183D2C530
	
		// Methods
		private JobHandle _CollectConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorCollectJobHandle) {
			conveyorCollectJobHandle = default;
			return default;
		} // 0x00000001826DDD60-0x00000001826DDFF0
		private JobHandle _CollectPreviewConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorPreviewCollectJobHandle) {
			conveyorPreviewCollectJobHandle = default;
			return default;
		} // 0x00000001826DD450-0x00000001826DD6F0
		private JobHandle _CollectGuideConveyor(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle conveyorCollectJobHandle) {
			conveyorCollectJobHandle = default;
			return default;
		} // 0x00000001826DDFF0-0x00000001826DE280
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting) {} // 0x0000000183280BC0-0x0000000183280E10
		private void _CreateAllocator(ref GlobalEnv env) {} // 0x0000000183280FE0-0x0000000183281030
		private void _CreateCurrent(ref GlobalEnv env) {} // 0x0000000183280830-0x0000000183280BC0
		private JobHandle _CollectPortState(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portCollectJobHandle) {
			portCollectJobHandle = default;
			return default;
		} // 0x00000001826DC270-0x00000001826DC5A0
		private JobHandle _CollectBuildingState(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle buildingStateCollectJobHandle) {
			buildingStateCollectJobHandle = default;
			return default;
		} // 0x00000001826DBF10-0x00000001826DC270
		private JobHandle _CollectOutput(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle outputCollectJobHandle) {
			outputCollectJobHandle = default;
			return default;
		} // 0x00000001826DD180-0x00000001826DD450
		private JobHandle _CollectCargo(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle cargoCollectJobHandle) {
			cargoCollectJobHandle = default;
			return default;
		} // 0x00000001826DE280-0x00000001826DE520
		private JobHandle _CollectWire(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle wireCollectJobHandle) {
			wireCollectJobHandle = default;
			return default;
		} // 0x00000001827656C0-0x0000000182765B90
		public override JobHandle LateExecute(ref EntityManager em, ref GlobalEnv env, int frameCount, int curChapterId, int curMapId, JobHandle jobHandle) => default; // 0x00000001826DD6F0-0x00000001826DDB30
		public override void TearDown(ref EntityManager em, ref GlobalEnv env) {} // 0x00000001857BFBAC-0x00000001857BFD48
		private JobHandle _CollectPipe(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle pipeCollectJobHandle) {
			pipeCollectJobHandle = default;
			return default;
		} // 0x00000001826DC5A0-0x00000001826DCA40
		private JobHandle _CollectPipeLogistics(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle pipeHolderCollectJobHandle) {
			pipeHolderCollectJobHandle = default;
			return default;
		} // 0x00000001826DDB30-0x00000001826DDD60
		private void _InitArrowPlaced(ref GlobalEnv env) {} // 0x0000000183281200-0x0000000183281290
		private JobHandle _CollectPortArrow(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portArrowCollectJobHandle) {
			portArrowCollectJobHandle = default;
			return default;
		} // 0x00000001826DCA40-0x00000001826DD180
		private JobHandle _CollectPortArrowWithDiff(ref EntityManager em, ref GlobalEnv env, ref JobHandle jobHandle, out JobHandle portArrowCollectJobHandle) {
			portArrowCollectJobHandle = default;
			return default;
		} // 0x00000001857BFD48-0x00000001857C060C
		public void __iFixBaseProxy_Initialize(ref EntityManager P0, ref GlobalEnv P1, FactorySetting P2) {} // 0x00000001857BF920-0x00000001857BF930
		public JobHandle __iFixBaseProxy_LateExecute(ref EntityManager P0, ref GlobalEnv P1, int P2, int P3, int P4, JobHandle P5) => default; // 0x00000001857BF930-0x00000001857BF994
		public void __iFixBaseProxy_TearDown(ref EntityManager P0, ref GlobalEnv P1) {} // 0x00000001857BF994-0x00000001857BF99C
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public abstract class ReactiveProcessor<T> : BaseProcessor // TypeDefIndex: 49060
		where T : struct, IReactiveComponent, IComponentECS
	{
		// Properties
		public override string name { get; }
	
		// Constructors
		protected ReactiveProcessor() {}
	
		// Methods
		public override JobHandle PreExecute(ref EntityManager em, long time, long dt, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default;
		public override JobHandle Execute(ref EntityManager em, long time, long dt, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default;
		protected virtual void Perform(ref EntityManager em, ref EntityCommandBufferV2.EntityCommandBufferParallelWriter ecb, [IsReadOnly] in ECSSpan<T> dataSpans, ref GlobalEnv env, GroupType group, long time) {}
		protected virtual bool CleanUpEntityFilter(ref EntityManager em, Entity entity) => default;
		public override void CleanUp(ref EntityManager em, ref GlobalEnv env, Action<EntityManager, Entity> hook = null) {}
		public override void TearDown(ref EntityManager em, ref GlobalEnv env) {}
	}

	public class AdditiveMaterialBitIndex // TypeDefIndex: 49061
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
		public AdditiveMaterialBitIndex() {} // 0x000000018350B670-0x000000018350B680
		static AdditiveMaterialBitIndex() {} // 0x0000000183CC46F0-0x0000000183CC4880
	}

	[CreateAssetMenu(fileName = "FactoryBaseColorSetting", menuName = "Factory/BaseLUTColorSetting")]
	public class FactoryBaseColorLutConfig : ScriptableObject // TypeDefIndex: 49062
	{
		// Fields
		public SerializeFieldDictionary<FacBuildingBaseBuffer, UnityEngine.Color> factoryBuildingBaseStateConfig; // 0x18
		public SerializeFieldDictionary<BuildAndMode, int> factoryBuildingCrafterData; // 0x20
		public int factoryBuildingCount; // 0x28
	
		// Constructors
		public FactoryBaseColorLutConfig() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public bool GetColor(int sort, out UnityEngine.Color col) {
			col = default;
			return default;
		} // 0x00000001857FD538-0x00000001857FD5D8
		public bool GetIndex(string id, string group, out int index) {
			index = default;
			return default;
		} // 0x0000000183214600-0x0000000183214880
		public static FactoryBaseColorLutConfig CreateOrGet(string path) => default; // 0x00000001857FD418-0x00000001857FD538
	}

	public enum FacBuildingBaseBuffer // TypeDefIndex: 49063
	{
		InputBuffer1 = 0,
		InputBuffer2 = 1,
		InputBuffer3 = 2,
		OutputBuffer1 = 3,
		OutputBuffer2 = 4,
		OutputBuffer3 = 5
	}

	[Serializable]
	public struct BuildAndMode // TypeDefIndex: 49064
	{
		// Fields
		public string build; // 0x00
		public string mode; // 0x08
	}

	[Serializable]
	public struct FFactoryStateColorConfig // TypeDefIndex: 49066
	{
		// Fields
		public SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryStateIconColorConfig; // 0x00
		public SerializeFieldDictionary<FacBuildingState, UnityEngine.Color> factoryIndicatorColorConfig; // 0x08
		public SerializeFieldDictionary<FacBuildingState, string> factoryUIEffectConfig; // 0x10
		public SerializeFieldDictionary<LogicEntityState, SerializeFieldDictionary<LogicEntityType, PerDrawConfigArray>> factoryLogicEntityColorConfig2; // 0x18
	
		// Nested types
		[Serializable]
		public struct LogicStateConfig // TypeDefIndex: 49065
		{
			// Fields
			public UnityEngine.Color color; // 0x00
			public float intensity; // 0x10
			public float alpha; // 0x14
			public float flowAlpha; // 0x18
			[ColorUsage(true, true)]
			public UnityEngine.Color c; // 0x1C
	
			// Methods
			private void _OnColorChanged() {} // 0x0000000185800CC4-0x0000000185800D58
		}
	
		// Methods
		public bool GetStateColor(FacBuildingState enumKey, out UnityEngine.Color col) {
			col = default;
			return default;
		} // 0x000000018327F620-0x000000018327F6A0
		public bool GetIndicatorColor(FacBuildingState enumKey, out UnityEngine.Color col) {
			col = default;
			return default;
		} // 0x00000001857FC5F8-0x00000001857FC698
		public bool GetStateName(FacBuildingState enumKey, out string name) {
			name = default;
			return default;
		} // 0x00000001857FC698-0x00000001857FC738
		public bool GetPerDrawList(LogicEntityState entityState, LogicEntityType entityType, out PerDrawConfigArray perDrawList) {
			perDrawList = default;
			return default;
		} // 0x000000018327EBA0-0x000000018327EC70
		public void OnEnable() {} // 0x00000001832BB450-0x00000001832BBE50
	}
}

namespace Beyond.Gameplay.Factory.ECSVATFSM
{
	[BurstCompatible]
	[ECSComponent]
	public struct VATFSMStateFragment : IComponentECS // TypeDefIndex: 49067
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
		public const int ID = 75; // Metadata: 0x01FBBBFE
	
		// Properties
		public ref VATFSMDefinition def { get => default; } // 0x0000000184271798-0x00000001842717A4 
		public int id { get => default; } // 0x0000000183D566A0-0x0000000183D566B0 
	
		// Methods
		public void Init(uint defHandle, uint binderHandle) {} // 0x00000001827637A0-0x00000001827638A0
		public void SetState([IsReadOnly] in FSMStateDefinition stateDef) {} // 0x0000000185802664-0x0000000185802704
		public void ToNextState() {} // 0x000000018580279C-0x000000018580283C
		public void SetTransition([IsReadOnly] in FSMTransitionDefinition transDef, [IsReadOnly] in FSMStateDefinition nextStateDef) {} // 0x0000000185802704-0x000000018580279C
		private void __AOT_FOR_FIX__() {} // 0x000000018580283C-0x0000000185802978
	}

	public struct FSMState // TypeDefIndex: 49068
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
		public float process { get => default; } // 0x00000001857FD1D8-0x00000001857FD254 
		public bool isFinished { get => default; } // 0x0000000181002A50-0x0000000181002A60 
	
		// Methods
		public void Enter() {} // 0x00000001827638A0-0x00000001827638D0
		public void Update(float deltaTime, float fsmSpeed) {} // 0x00000001857FD144-0x00000001857FD1D8
		public void Exit() {} // 0x00000001857FD094-0x00000001857FD0D8
		public void SetProgress(float normalized) {} // 0x00000001857FD0D8-0x00000001857FD144
	}

	public struct FSMTransition // TypeDefIndex: 49069
	{
		// Fields
		public float duration; // 0x00
		private float m_elapsedTime; // 0x04
		private bool m_isFinish; // 0x08
	
		// Properties
		public bool isFinished { get => default; } // 0x00000001857FD3F0-0x00000001857FD3F8 
		public float fromStateWeight { get => default; } // 0x00000001857FD370-0x00000001857FD3F0 
		public float toStateWeight { get => default; } // 0x00000001857FD3F8-0x00000001857FD418 
	
		// Methods
		public void Enter() {} // 0x00000001857FD254-0x00000001857FD2A4
		public void Update(float deltaTime, float fsmSpeed) {} // 0x00000001857FD2E8-0x00000001857FD370
		public void Exit() {} // 0x00000001857FD2A4-0x00000001857FD2E8
	}

	public struct FSMParameterSet // TypeDefIndex: 49070
	{
		// Fields
		public FixedList32Bytes<float> floats; // 0x00
		public byte bools; // 0x20
		public byte triggers; // 0x21
	
		// Methods
		[IsReadOnly]
		public float GetFloat(byte index) => default; // 0x00000001857FCA24-0x00000001857FCAC8
		public void SetFloat(byte index, float value) {} // 0x00000001857FCDE4-0x00000001857FCE7C
		[IsReadOnly]
		public int GetInt(byte index) => default; // 0x00000001857FCAC8-0x00000001857FCB74
		public void SetInt(byte index, int value) {} // 0x00000001857FCE7C-0x00000001857FCF18
		[IsReadOnly]
		public bool GetBool(byte index) => default; // 0x00000001857FC9C4-0x00000001857FCA24
		public void SetBool(byte index, bool value) {} // 0x00000001857FCD60-0x00000001857FCDE4
		[IsReadOnly]
		public bool GetTrigger(byte index) => default; // 0x00000001857FCB74-0x00000001857FCBD4
		public void SetTrigger(byte index) {} // 0x00000001857FCF18-0x00000001857FCF80
		public void ResetTrigger(byte index) {} // 0x00000001857FCCF8-0x00000001857FCD60
		public void ResetAllTriggers() {} // 0x00000001857FCCAC-0x00000001857FCCF8
		public void SetValue(byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type, float value) {} // 0x00000001857FCF80-0x00000001857FD094
		[IsReadOnly]
		public float GetValue(byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type) => default; // 0x00000001857FCBD4-0x00000001857FCCAC
		public void ResetParametersByDef([IsReadOnly] in VATFSMDefinition def) {} // 0x0000000182763530-0x00000001827636A0
	}

	[BurstCompile]
	public struct VATFSMSetParamRequestHandlerJob : IJobFor // TypeDefIndex: 49071
	{
		// Fields
		public EntityManager renderEm; // 0x00
		public NativeArray<VATFSMProcessor.SetAnimatorParamRequest> setParamRequestList; // 0x10
		[NativeDisableUnsafePtrRestriction]
		public unsafe VATFSMDefinition* sharedDataPtr; // 0x20
		[NativeDisableUnsafePtrRestriction]
		public unsafe GlobalEnv* envPtr; // 0x28
	
		// Methods
		public void Execute(int index) {} // 0x0000000185802520-0x0000000185802664
	}

	[BurstCompile]
	public struct VATFSMStateUpdateJob : IJobFor // TypeDefIndex: 49072
	{
		// Fields
		public float deltaTime; // 0x00
		[NoAlias]
		public EntityQueryV2.QueryResult qr; // 0x08
		[NativeDisableUnsafePtrRestriction]
		public unsafe VATFSMDefinition* fsmDefinitionPtr; // 0x28
		[NativeDisableUnsafePtrRestriction]
		public unsafe SharedDataContainer.SharedExtData* sharedDataPtr; // 0x30
		public UnsafeList<VATFSMProcessor.VATFSMAudioData> animatorAudioQueue; // 0x38
		private const int S_CURRENT_FRAME_OFFSET = 72; // Metadata: 0x01FBBC00
		private const int S_PREVIOUS_FRAME_OFFSET = 76; // Metadata: 0x01FBBC02
	
		// Methods
		[IDTag(1)]
		public void Execute() {} // 0x0000000185802C5C-0x0000000185802CE4
		[IDTag(0)]
		public void Execute(int index) {} // 0x0000000185802978-0x0000000185802C5C
		private bool _CheckTransitions(ref VATFSMStateFragment fsm, ref VATFSMDefinition fsmDef) => default; // 0x0000000185802DD0-0x0000000185802F08
		private void _ComputeVATFrameData(ref VATFSMStateFragment state, ref VATFSMDefinition fsmDef) {} // 0x0000000185802F08-0x0000000185803070
		private void _AddVATAudioData(Entity renderEntity, ref FSMState newState, ref VATFSMDefinition fsmDef) {} // 0x0000000185802CE4-0x0000000185802DD0
		public void SetSharedExtData(IntPtr data) {} // 0x00000001826DF570-0x00000001826DF5B0
	}

	[Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public class VATFSMProcessor : BaseProcessor // TypeDefIndex: 49076
	{
		// Fields
		public NativeList<SetAnimatorParamRequest> animatorParamRequestQueue; // 0x20
		private NativeParallelHashMap<Entity, int> m_requestMaskPerEntity; // 0x30
	
		// Properties
		public override string name { get => default; } // 0x00000001858024F4-0x0000000185802520 
		public unsafe VATFSMDefinition* fsmDefinitionPtr { get => default; } // 0x00000001826DEF20-0x00000001826DEF30 
	
		// Nested types
		public enum VATAnimatorRequestType : byte // TypeDefIndex: 49073
		{
			SetParameter = 1,
			PauseOrResume = 2,
			SetSpeed = 3,
			ForceSetState = 4,
			SetStateLoop = 5,
			Reset = 6
		}
	
		public struct SetAnimatorParamRequest // TypeDefIndex: 49074
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
			public unsafe void SetParamToAnimator(GlobalEnv* envPtr, ref VATFSMStateFragment fragment, VATFSMDefinition* sharedDataPtr) {} // 0x0000000185800D58-0x0000000185801010
		}
	
		public struct VATFSMAudioData // TypeDefIndex: 49075
		{
			// Fields
			public Entity entity; // 0x00
			public int hashStateName; // 0x08
		}
	
		// Constructors
		public VATFSMProcessor() {} // 0x0000000183D561E0-0x0000000183D561F0
	
		// Methods
		public override void Initialize(ref EntityManager em, ref GlobalEnv env, FactorySetting factorySetting) {} // 0x00000001839B4770-0x00000001839B48A0
		public override JobHandle Execute(ref EntityManager em, long time, long deltaTime, float tickDeltaTime, int frameCount, int curChapterId, int curMapId, ref GlobalEnv env, JobHandle jobHandle, NativeList<JobHandle> noneDependencies) => default; // 0x00000001826DE9E0-0x00000001826DEED0
		public override void TearDown(ref EntityManager em, ref GlobalEnv env) {} // 0x00000001858023CC-0x00000001858024F4
		private JobHandle _HandleSetAnimatorParamRequest(ref EntityManager em, ref GlobalEnv env, JobHandle jobHandle) => default; // 0x00000001824FD6F0-0x00000001824FDE30
		private void _RemoveDuplicationRequest(ref EntityManager em) {} // 0x00000001824FDE30-0x00000001824FE430
		public void __iFixBaseProxy_Initialize(ref EntityManager P0, ref GlobalEnv P1, FactorySetting P2) {} // 0x00000001857BF920-0x00000001857BF930
		public JobHandle __iFixBaseProxy_Execute(ref EntityManager P0, long P1, long P2, float P3, int P4, int P5, int P6, ref GlobalEnv P7, JobHandle P8, NativeList<JobHandle> P9) => default; // 0x00000001857BF7B0-0x00000001857BF85C
		public void __iFixBaseProxy_TearDown(ref EntityManager P0, ref GlobalEnv P1) {} // 0x00000001857BF994-0x00000001857BF99C
	}

	[Serializable]
	public class ECSVATFSMDefinitionData // TypeDefIndex: 49077
	{
		// Fields
		public string fsmName; // 0x10
		public string defaultStateName; // 0x18
		public List<StateData> states; // 0x20
		public List<TransitionData> transitions; // 0x28
		public List<ParameterData> parameters; // 0x30
		public List<AnimationClipData> animationClips; // 0x38
	
		// Constructors
		public ECSVATFSMDefinitionData() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class StateData // TypeDefIndex: 49078
	{
		// Fields
		public string name; // 0x10
		public float speed; // 0x18
		public string clipName; // 0x20
	
		// Constructors
		public StateData() {} // 0x0000000183D561E0-0x0000000183D561F0
	}

	public enum TransitionInterruptionSource // TypeDefIndex: 49079
	{
		None = 0,
		Source = 1,
		Destination = 2,
		SourceThenDestination = 3,
		DestinationThenSource = 4
	}

	[Serializable]
	public class TransitionData // TypeDefIndex: 49080
	{
		// Fields
		public string fromState; // 0x10
		public string toState; // 0x18
		public float exitTime; // 0x20
		public float duration; // 0x24
		public TransitionInterruptionSource interruptionSource; // 0x28
		public List<Beyond.Gameplay.Factory.ECSVATFSM.ConditionData> condition; // 0x30
	
		// Constructors
		public TransitionData() {} // 0x000000018350B670-0x000000018350B680
	}

	public enum AnimatorConditionMode // TypeDefIndex: 49081
	{
		If = 1,
		IfNot = 2,
		Greater = 3,
		Less = 4,
		Equals = 6,
		NotEqual = 7
	}

	[Serializable]
	public class ConditionData // TypeDefIndex: 49082
	{
		// Fields
		public string parameterName; // 0x10
		public AnimatorConditionMode comparison; // 0x18
		public float threshold; // 0x1C
	
		// Constructors
		public ConditionData() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class ParameterData // TypeDefIndex: 49083
	{
		// Fields
		public string name; // 0x10
		public AnimatorControllerParameterType type; // 0x18
		public float defaultFloat; // 0x1C
		public int defaultInt; // 0x20
		public bool defaultBool; // 0x24
	
		// Constructors
		public ParameterData() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class AnimationClipData // TypeDefIndex: 49084
	{
		// Fields
		public string name; // 0x10
		public bool isLoop; // 0x18
		public float length; // 0x1C
		public int startFrame; // 0x20
		public int totalFrames; // 0x24
	
		// Constructors
		public AnimationClipData() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public string GetClipDesStr() => default; // 0x00000001857FA4EC-0x00000001857FA6E4
	}

	public struct VATFSMDefinition // TypeDefIndex: 49085
	{
		// Fields
		public byte defaultStateIndex; // 0x00
		public FixedList512Bytes<FSMStateDefinition> states; // 0x02
		public FSMTransitionDefinition20<FSMTransitionDefinition> transitions; // 0x204
		public FixedList128Bytes<FSMParameterDefinition> parameters; // 0xA0C
	}

	public enum ConditionMode : byte // TypeDefIndex: 49086
	{
		If = 1,
		IfNot = 2,
		Greater = 3,
		Less = 4,
		Equals = 6,
		NotEqual = 7
	}

	public struct FSMCondition // TypeDefIndex: 49087
	{
		// Fields
		public byte parameterIndex; // 0x00
		public ConditionMode comparison; // 0x01
		public float threshold; // 0x04
	}

	[DataN(capacity = 20, tSize = 64, ring = false)]
	[NoAlias]
	public struct FSMTransitionDefinition20<T> : IEnumerable<T> // TypeDefIndex: 49090
		where T : struct
	{
		// Fields
		public const int T_SIZE = 64; // Metadata: 0x01FBBC1D
		public const int CAPACITY = 32; // Metadata: 0x01FBBC1F
		public const int CAPACITY_MINUS_ONE = 31; // Metadata: 0x01FBBC20
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBBC21
		private int m_beginIndex;
		private int m_endIndex;
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0];
	
		// Properties
		public int length { get => default; }
		public bool ring { get => default; }
		public int beginIndex { get => default; }
		public int endIndex { get => default; }
		public bool isEmpty { get => default; }
		public ref T this[int index] { get => default; }
	
		// Nested types
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 49088
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
			public Enumerator([IsReadOnly] in FSMTransitionDefinition20<T> data, int count) : this() {
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
	
		// Constructors
		public unsafe FSMTransitionDefinition20(int initialCapacity = 32 /* Metadata: 0x01FBBC1B */, bool autoExtend = false /* Metadata: 0x01FBBC1C */) : this() {
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

	public struct FSMTransitionDefinition // TypeDefIndex: 49091
	{
		// Fields
		public byte fromStateIndex; // 0x00
		public byte toStateIndex; // 0x01
		public float exitTime; // 0x02
		public float duration; // 0x06
		public FixedList32Bytes<FSMCondition> conditions; // 0x0A
	}

	public enum ParameterType : byte // TypeDefIndex: 49092
	{
		Float = 1,
		Int = 3,
		Bool = 4,
		Trigger = 9
	}

	public struct FSMParameterDefinition // TypeDefIndex: 49093
	{
		// Fields
		public int nameHash; // 0x00
		public Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type; // 0x04
		public byte index; // 0x05
		public float defaultFloat; // 0x08
		public int defaultInt; // 0x08
		public byte defaultBool; // 0x08
	}

	public struct FSMStateDefinition // TypeDefIndex: 49094
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

	public struct VATFSMDefinitionContainer // TypeDefIndex: 49096
	{
		// Fields
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBBC26
		private HGArray<Node> m_nodes; // 0x00
	
		// Properties
		public ref VATFSMDefinition this[int index] { get => default; } // 0x0000000185801D18-0x0000000185801D5C 
		public ref VATFSMDefinition this[uint index] { get => default; } // 0x00000001831A8AB0-0x00000001831A8B00 
	
		// Nested types
		internal struct Node // TypeDefIndex: 49095
		{
			// Fields
			public VATFSMDefinition value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public VATFSMDefinitionContainer(Unity.Collections.Allocator allocator) : this() {
			m_nodes = default;
		} // 0x0000000182C34910-0x0000000182C349B0
	
		// Methods
		public void Dispose() {} // 0x0000000185801AF8-0x0000000185801B64
		public uint Size() => default; // 0x0000000185801CB0-0x0000000185801D18
		public Span<VATFSMDefinition> AsSpan() => default; // 0x00000001858019B4-0x0000000185801A68
		public uint Create(ref VATFSMDefinition value) => default; // 0x0000000182C34A20-0x0000000182C34B00
		public void Destroy(uint handle) {} // 0x0000000185801A68-0x0000000185801AF8
		public void Reset() {} // 0x0000000182C348A0-0x0000000182C34910
		public void Reserve(uint newCapacity) {} // 0x0000000185801C2C-0x0000000185801CB0
		public IntPtr Data() => default; // 0x00000001827DA760-0x00000001827DA800
		[IDTag(0)]
		public ref VATFSMDefinition Get(uint handle) => ref _refReturnTypeForGet; // 0x0000000185801BC8-0x0000000185801C2C
		private ref VATFSMDefinition _refReturnTypeForGet; // Dummy field
		[IDTag(1)]
		public ref VATFSMDefinition Get(int handle) => ref _refReturnTypeForGet; // 0x0000000185801B64-0x0000000185801BC8
		private ref VATFSMDefinition _refReturnTypeForGet; // Dummy field
	}

	public static class VATFSMDefinitionHelper // TypeDefIndex: 49097
	{
		// Methods
		private static bool _Evaluate([IsReadOnly] in FSMCondition cond, [IsReadOnly] in FSMParameterSet param, [IsReadOnly] in FixedList128Bytes<FSMParameterDefinition> paramDefs) => default; // 0x0000000185802218-0x00000001858023CC
	
		// Extension methods
		public static bool TryGetValidTransition(this ref VATFSMStateFragment state, ref VATFSMDefinition def, out int transitionIndex) {
			transitionIndex = default;
			return default;
		} // 0x0000000185802068-0x0000000185802218
		public static bool TryGetParameterIndexAndType(this VATFSMDefinition def, int nameHash, out byte index, out Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type) {
			index = default;
			type = default;
			return default;
		} // 0x0000000185801EF8-0x0000000185802068
		public static void ResetUsedTriggers(this ref FSMParameterSet param, [IsReadOnly] in FSMTransitionDefinition transition, [IsReadOnly] in FixedList128Bytes<FSMParameterDefinition> paramDefs) {} // 0x0000000185801D5C-0x0000000185801EF8
	}

	public static class FSMDefinitionLibrary // TypeDefIndex: 49098
	{
		// Fields
		public const int MAX_FSM_DEFINITION_COUNT = 128; // Metadata: 0x01FBBC27
		public const int MAX_STATE_COUNT = 20; // Metadata: 0x01FBBC29
		public const int MAX_TRANSITION_COUNT = 20; // Metadata: 0x01FBBC2A
		public const int MAX_CONDITION_PRE_TRANSITION_COUNT = 3; // Metadata: 0x01FBBC2B
		public const int MAX_PARAMETER_COUNT = 7; // Metadata: 0x01FBBC2C
		public const byte ANY_STATE_INDEX = 255; // Metadata: 0x01FBBC2D
		public static NativeParallelHashMap<int, uint> s_assetHashGuidToHandle; // 0x00
		public static NativeParallelHashMap<int2, byte> s_stateNameHashToIndex; // 0x10
		public static NativeParallelHashMap<int2, byte> s_parameterNameHashToIndex; // 0x20
	
		// Methods
		public static void Initialize() {} // 0x00000001839B48A0-0x00000001839B4A30
		public static void InitFSMDefinition(int guid, ECSVATFSMDefinitionData data) {} // 0x0000000182764770-0x0000000182764DA0
		public static string GetStateName(uint fsmHandler, byte stateIndex) => default; // 0x00000001857FC880-0x00000001857FC9C4
		public static byte GetStateIndex(uint fsmHandler, int stateNameHash) => default; // 0x00000001827DA800-0x00000001827DA990
		public static void Dispose() {} // 0x00000001857FC738-0x00000001857FC880
	
		// Extension methods
		public static void RegisterFSM(this Entity rEntity, ref EntityManager em) {} // 0x0000000182764180-0x0000000182764550
	}
}

namespace Beyond.Gameplay.Factory.Unsafe
{
	[BurstCompile]
	public static class BurstBridge // TypeDefIndex: 49102
	{
		// Nested types
		public unsafe delegate void SamplePredictCargo_00000A4A_PostfixBurstDelegate(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation); // TypeDefIndex: 49100; 0x0000000181133330-0x0000000181133350
	
		internal static class SamplePredictCargo_00000A4A_BurstDirectCall // TypeDefIndex: 49101
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SamplePredictCargo_00000A4A_BurstDirectCall() {} // 0x0000000181132500-0x0000000181132510
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000671cc) {} // 0x0000000181130F60-0x0000000181131BD0
			private static IntPtr GetFunctionPointer() => default; // 0x0000000181131BD0-0x0000000181131ED0
			public static void Constructor() {} // 0x00000001811306C0-0x0000000181130F60
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation) {
				position = default;
				rotation = default;
			} // 0x0000000181131ED0-0x0000000181132500
		}
	
		// Methods
		[BurstDiscard]
		public static void BeginProfilerSample(string name) {} // 0x00000001826E72D0-0x00000001826E7340
		[BurstDiscard]
		public static void EndProfilerSample() {} // 0x00000001826E7340-0x00000001826E73B0
		[BurstCompile]
		public static unsafe void SamplePredictCargo(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x00000001857FA6E4-0x00000001857FA764
		[BurstCompile]
		public static unsafe void SamplePredictCargo_BurstManaged(ConveyorFragment* conveyor, GlobalEnv* env, float predictDistance, out float3 position, out quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x00000001857F908C-0x00000001857FA354
	}

	[BurstCompile]
	public static class EntityExtensions // TypeDefIndex: 49109
	{
		// Nested types
		public delegate FacBuildingState QueryBuildingState_00000A4E_PostfixBurstDelegate(ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState); // TypeDefIndex: 49103; 0x0000000181035ED0-0x0000000181035EF0
	
		internal static class QueryBuildingState_00000A4E_BurstDirectCall // TypeDefIndex: 49104
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static QueryBuildingState_00000A4E_BurstDirectCall() {} // 0x000000018112F700-0x000000018112F710
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00067241) {} // 0x000000018112E180-0x000000018112EDF0
			private static IntPtr GetFunctionPointer() => default; // 0x000000018112EDF0-0x000000018112F0F0
			public static void Constructor() {} // 0x000000018112D8E0-0x000000018112E180
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static FacBuildingState Invoke(ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState) {
				subState = default;
				return default;
			} // 0x000000018112F0F0-0x000000018112F700
		}
	
		public delegate void SetFlashStatue_00000A50_PostfixBurstDelegate(ref Entity logicEntity, ref EntityManager em, FacBuildingState statue); // TypeDefIndex: 49105; 0x00000001811360D0-0x00000001811360F0
	
		internal static class SetFlashStatue_00000A50_BurstDirectCall // TypeDefIndex: 49106
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static SetFlashStatue_00000A50_BurstDirectCall() {} // 0x00000001811352B0-0x00000001811352C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00067250) {} // 0x0000000181133D30-0x00000001811349A0
			private static IntPtr GetFunctionPointer() => default; // 0x00000001811349A0-0x0000000181134CA0
			public static void Constructor() {} // 0x0000000181133490-0x0000000181133D30
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref Entity logicEntity, ref EntityManager em, FacBuildingState statue) {} // 0x0000000181134CA0-0x00000001811352B0
		}
	
		public delegate void _SetRenderEntityFlashStatue_00000A51_PostfixBurstDelegate(ref EntityManager em, ref Entity rendererEntity, byte statue); // TypeDefIndex: 49107; 0x00000001811360D0-0x00000001811360F0
	
		internal static class _SetRenderEntityFlashStatue_00000A51_BurstDirectCall // TypeDefIndex: 49108
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static _SetRenderEntityFlashStatue_00000A51_BurstDirectCall() {} // 0x0000000181138050-0x0000000181138060
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006725f) {} // 0x0000000181136AD0-0x0000000181137740
			private static IntPtr GetFunctionPointer() => default; // 0x0000000181137740-0x0000000181137A40
			public static void Constructor() {} // 0x0000000181136230-0x0000000181136AD0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static void Invoke(ref EntityManager em, ref Entity rendererEntity, byte statue) {} // 0x0000000181137A40-0x0000000181138050
		}
	
		// Methods
		private static bool _IsPowerBuilding(ref EntityManager em, ref Entity logicEntity) => default; // 0x00000001857FC28C-0x00000001857FC340
		[BurstCompile]
		private static void _SetRenderEntityFlashStatue(ref EntityManager em, ref Entity rendererEntity, byte statue) {} // 0x00000001857FC598-0x00000001857FC5F8
		[BurstCompile]
		public static void _SetRenderEntityFlashStatue_BurstManaged(ref EntityManager em, ref Entity rendererEntity, byte statue) {} // 0x00000001857FC340-0x00000001857FC598
	
		// Extension methods
		public static ref SharedDataContainer.SharedExtData GetExtData(this Entity entity, ref EntityManager em) => ref _refReturnTypeForGetExtData; // 0x00000001824FC570-0x00000001824FC8E0
		private ref SharedDataContainer.SharedExtData _refReturnTypeForGetExtData; // Dummy field
		public static unsafe ref SharedDataContainer.SharedExtData GetExtData(this Entity entity, ref EntityManager em, SharedDataContainer.SharedExtData* sharedDataPtr) => ref _refReturnTypeForGetExtData; // 0x00000001857FB540-0x00000001857FB6FC
		private ref SharedDataContainer.SharedExtData _refReturnTypeForGetExtData; // Dummy field
		public static bool QueryBuildingStateIsClosed(this Entity logicEntity) => default; // 0x00000001857FB86C-0x00000001857FB930
		[BurstCompile]
		public static FacBuildingState QueryBuildingState(this ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState) {
			subState = default;
			return default;
		} // 0x00000001857FBDCC-0x00000001857FBE2C
		[BurstCompile]
		public static void SetFlashStatue(this ref Entity logicEntity, ref EntityManager em, FacBuildingState statue) {} // 0x00000001857FC010-0x00000001857FC070
		public static bool CulledWithLogicEntity(this Entity logicEntity, ref EntityManager em) => default; // 0x00000001857FA764-0x00000001857FA864
		public static bool CulledWithRendererEntity(this Entity rendererEntity, ref EntityManager em) => default; // 0x00000001857FA864-0x00000001857FA9A8
		[IDTag(1)]
		public static bool GetVisibility(this Entity logicEntity, Visibility.Type type) => default; // 0x00000001857FB6FC-0x00000001857FB780
		[IDTag(0)]
		public static bool GetVisibility(this Entity logicEntity, ref EntityManager em, Visibility.Type type) => default; // 0x0000000182429500-0x0000000182429600
		public static unsafe bool GetVisibility(this Entity logicEntity, ref EntityManager em, SharedDataContainer.SharedExtData* sharedDataPtr, Visibility.Type type) => default; // 0x00000001857FB780-0x00000001857FB83C
		[IDTag(0)]
		public static bool SetVisibility(this Entity logicEntity, ref EntityManager em, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short[] invisibleSubIndexList = null) => default; // 0x00000001823F91F0-0x00000001823F93D0
		public static unsafe bool SetVisibility(this ref SharedDataContainer.SharedExtData extData, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short* subIndexListPtr = null, short subIndexCount = 0 /* Metadata: 0x01FBBC2E */) => default; // 0x00000001823F93D0-0x00000001823F9660
		public static void SetVisibilityWithNotify(this Entity logicEntity, ref EntityManager em, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, short[] invisibleSubIndexList = null) {} // 0x00000001824297D0-0x0000000182429980
		[IDTag(1)]
		public static bool SetVisibility(this Entity logicEntity, bool visible, Visibility.EFlag reasonFlag, Visibility.Type type, ref EntityCommandBuffer ecb) => default; // 0x00000001823F8F70-0x00000001823F91F0
		public static void SetInMainRegion(this Entity logicEntity, bool value) {} // 0x00000001827D3380-0x00000001827D3450
		public static bool IsInMainRegionFuzzy(this Entity logicEntity, ref EntityManager em) => default; // 0x00000001827D32A0-0x00000001827D32F0
		public static unsafe bool IsInMainRegion(this SharedDataFragment sharedData, SharedDataContainer.SharedExtData* sharedDataPtr) => default; // 0x00000001857FB83C-0x00000001857FB86C
		[IDTag(0)]
		public static void UpdatePipeEffect(this Entity logicEntity, ref EntityManager em) {} // 0x00000001826E3250-0x00000001826E3740
		[IDTag(1)]
		public static void UpdatePipeEffect(this Entity logicEntity, ref EntityCommandBufferV2.EntityCommandBufferParallelWriter ecb) {} // 0x00000001857FC070-0x00000001857FC28C
		public static unsafe bool GetBuildingExtendConfig(this Entity logicEntity, ref EntityManager em, FixedString32Bytes extendKey, SharedDataContainer.SharedExtData* sharedDataPtr, out float3 pos, out quaternion rot, out Entity posRendererEntity) {
			pos = default;
			rot = default;
			posRendererEntity = default;
			return default;
		} // 0x00000001857FA9A8-0x00000001857FAC54
		public static bool GetBuildingExtendConfig(this Entity logicEntity, ref EntityManager em, FixedString32Bytes extendKey, out float3 pos, out quaternion rot, out Entity posRendererEntity) {
			pos = default;
			rot = default;
			posRendererEntity = default;
			return default;
		} // 0x00000001857FAC54-0x00000001857FAF4C
		[IDTag(1)]
		public static bool GetBuildingStaticMountWorldTRS(this Entity entity, string extendKey, out float3 pos, out quaternion rot) {
			pos = default;
			rot = default;
			return default;
		} // 0x00000001857FB468-0x00000001857FB540
		[IDTag(0)]
		public static bool GetBuildingStaticMountWorldTRS(this Entity entity, ref EntityManager em, FixedString32Bytes extendKey, out float3 pos, out quaternion rot) {
			pos = default;
			rot = default;
			return default;
		} // 0x00000001857FAF4C-0x00000001857FB204
		public static unsafe bool GetBuildingStaticMountWorldTRS(this Entity entity, ref EntityManager em, FixedString32Bytes extendKey, SharedDataContainer.SharedExtData* sharedDataPtr, out float3 pos, out quaternion rot) {
			pos = default;
			rot = default;
			return default;
		} // 0x00000001857FB204-0x00000001857FB468
		[BurstCompile]
		public static FacBuildingState QueryBuildingState_BurstManaged(this ref Entity logicEntity, ref EntityManager em, out FacBuildingSubState subState) {
			subState = default;
			return default;
		} // 0x00000001857FB930-0x00000001857FBDCC
		[BurstCompile]
		public static void SetFlashStatue_BurstManaged(this ref Entity logicEntity, ref EntityManager em, FacBuildingState statue) {} // 0x00000001857FBE2C-0x00000001857FC010
	}

	public static class GameplayExtensions // TypeDefIndex: 49110
	{
		// Extension methods
		[Conditional("UNITY_EDITOR")]
		public static void FacUnitAssertComponent<T>(this EntityManager em, Entity entity)
			where T : struct, IComponentECS {}
		public static ref ChapterFragment GetChapterEntity(this EntityManager em, int chapterId, out bool existed, out Entity chapterEntity) {
			existed = default;
			chapterEntity = default;
			return default;
		} // 0x0000000182D07F30-0x0000000182D082B0
		private ref ChapterFragment _refReturnTypeForGetChapterEntity; // Dummy field
	}

	public static class GlobalEnvExtensions // TypeDefIndex: 49111
	{
		// Extension methods
		public static unsafe GlobalEnv* GetGlobalEnv(this EntityManager em) => default; // 0x00000001827D9B30-0x00000001827D9CC0
		public static IntPtr GetGlobalEnvPtr(this EntityManager em) => default; // 0x00000001857FD878-0x00000001857FD8DC
		public static bool IsGlobalEnvValid(this EntityManager em) => default; // 0x0000000182985AE0-0x0000000182985B70
		public static ref GlobalEnv GetGlobalEnvRef(this EntityManager em) => ref _refReturnTypeForGetGlobalEnvRef; // 0x00000001827D9930-0x00000001827D9B30
		private ref GlobalEnv _refReturnTypeForGetGlobalEnvRef; // Dummy field
		public static void SetNearBuildingPtr(this ref GlobalEnv env, ref InteractFacCollectJob.BuildingInfo info, ref InteractFacCollectJob.BuildingInfo infoLast) {} // 0x0000000183B29160-0x0000000183B291B0
		public static void SetNearConveyorPtr(this ref GlobalEnv env, ref InteractFacCollectJob.LogisticInfo info, ref InteractFacCollectJob.LogisticInfo infoLast) {} // 0x0000000183B291B0-0x0000000183B29200
		public static void SetNearPipePtr(this ref GlobalEnv env, ref InteractFacCollectJob.LogisticInfo info, ref InteractFacCollectJob.LogisticInfo infoLast) {} // 0x0000000183B29200-0x0000000183B29250
		public static bool GetInteractFac(this ref GlobalEnv env, out InteractFacCollectJob.BuildingInfo info) {
			info = default;
			return default;
		} // 0x0000000182AAEC30-0x0000000182AAECD0
		public static bool GetInteractConveyor(this ref GlobalEnv env, out InteractFacCollectJob.LogisticInfo info) {
			info = default;
			return default;
		} // 0x0000000182AAEBC0-0x0000000182AAEC30
		public static bool GetInteractPipe(this ref GlobalEnv env, out InteractFacCollectJob.LogisticInfo info) {
			info = default;
			return default;
		} // 0x0000000182AAEB60-0x0000000182AAEBC0
	}

	public interface IAllocator : IDisposable // TypeDefIndex: 49112
	{
		// Methods
		LinearAllocator.Allocation Allocate(int size);
		void Reserve(int newCapacity);
		LinearAllocator.Allocation Expand(int startIndex, int additionalSize);
		LinearAllocator.Allocation Resize(int startIndex, int newSize);
		void Free(int startIndex);
	}

	public class LinearAllocator : Beyond.Gameplay.Factory.Unsafe.IAllocator // TypeDefIndex: 49115
	{
		// Fields
		private const int INITIAL_CAPACITY = 512; // Metadata: 0x01FBBC32
		private int m_totalCapacity; // 0x10
		private unsafe byte* m_memory; // 0x18
		private readonly Dictionary<int, int> m_allocations; // 0x28
	
		// Properties
		public Dictionary<int, int> freeBlocks { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Nested types
		public struct Allocation // TypeDefIndex: 49113
		{
			// Fields
			public int start; // 0x00
			public int end; // 0x04
			public bool reallocated; // 0x08
		}
	
		// Constructors
		public LinearAllocator() {} // Dummy constructor
		public LinearAllocator(int capacity = 512 /* Metadata: 0x01FBBC30 */) {} // 0x0000000185800BD4-0x0000000185800CC4
	
		// Methods
		private void _ExpandMemory() {} // 0x00000001858008DC-0x0000000185800A38
		public Allocation Allocate(int size) => default; // 0x00000001857FE788-0x00000001857FF124
		public void Reserve(int newCapacity) {} // 0x00000001858002E8-0x00000001858003F0
		public Allocation Expand(int startIndex, int additionalSize) => default; // 0x00000001857FF1D8-0x00000001857FF584
		public Allocation Resize(int startIndex, int newSize) => default; // 0x00000001858003F0-0x00000001858008DC
		private void _MergeAdjacentFreeBlocks() {} // 0x0000000185800A38-0x0000000185800BD4
		public void Free(int startIndex) {} // 0x00000001857FF5F4-0x00000001857FF9F4
		public unsafe void* GetPointer(int offset) => default; // 0x0000000183D56680-0x0000000183D56690
		public void Dispose() {} // 0x00000001857FF124-0x00000001857FF1D8
		public void PrintAllocations() {} // 0x00000001857FF9F4-0x00000001858002E8
		~LinearAllocator() {} // 0x00000001857FF584-0x00000001857FF5F4
	}

	public struct LinearAllocatorUnmanaged : Beyond.Gameplay.Factory.Unsafe.IAllocator // TypeDefIndex: 49117
	{
		// Fields
		private const int INITIAL_CAPACITY = 512; // Metadata: 0x01FBBC37
		private int m_totalCapacity; // 0x00
		private unsafe byte* m_memory; // 0x08
		private NativeParallelHashMap<int, int> m_allocations; // 0x20
		private bool m_initialized; // 0x30
		private Unity.Collections.Allocator m_allocator; // 0x34
	
		// Properties
		public NativeParallelHashMap<int, int> freeBlocks { [IsReadOnly] get; set; } // 0x00000001820B7B30-0x00000001820B7B40 0x0000000183D55580-0x0000000183D55590
	
		// Methods
		public void Initialize(int capacity = 512 /* Metadata: 0x01FBBC34 */, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x01FBBC36 */) {} // 0x0000000183281410-0x0000000183281590
		private void _ExpandMemory() {} // 0x0000000182A90100-0x0000000182A90250
		public LinearAllocator.Allocation Allocate(int size) => default; // 0x0000000182A8E0E0-0x0000000182A8F5F0
		public void Reserve(int newCapacity) {} // 0x00000001857FE678-0x00000001857FE788
		public LinearAllocator.Allocation Expand(int startIndex, int additionalSize) => default; // 0x00000001839B1870-0x00000001839B1A50
		public LinearAllocator.Allocation Resize(int startIndex, int newSize) => default; // 0x00000001839B1750-0x00000001839B1870
		private void _MergeAdjacentFreeBlocks() {} // 0x00000001823CB160-0x00000001823CBB10
		public void Free(int startIndex) {} // 0x00000001839B1A50-0x00000001839B1B30
		public unsafe void* GetPointer(long offset) => default; // 0x0000000182E50A70-0x0000000182E50A90
		public void Dispose() {} // 0x00000001857FD9D8-0x00000001857FDAD4
		public void PrintAllocations() {} // 0x00000001857FDAD4-0x00000001857FE678
	}

	internal struct TLSFBlockHeader // TypeDefIndex: 49118
	{
		// Fields
		public const int ALIGNMENT = 8; // Metadata: 0x01FBBC39
		public unsafe TLSFBlockHeader* prev; // 0x00
		public unsafe TLSFBlockHeader* next; // 0x08
		public unsafe TLSFBlockHeader* prePhys; // 0x10
		public uint size; // 0x18
		public bool isFree; // 0x1C
	}

	public class TLSFAllocator // TypeDefIndex: 49119
	{
		// Fields
		private const int FIRST_LEVEL_INDEX_COUNT = 32; // Metadata: 0x01FBBC3A
		private const int SECOND_LEVEL_INDEX_COUNT = 32; // Metadata: 0x01FBBC3B
		private const int SMALL_BLOCK_SIZE = 256; // Metadata: 0x01FBBC3C
		private const int ALIGNMENT = 8; // Metadata: 0x01FBBC3E
		private uint _flBitmap; // 0x10
		private uint[] _slBitmap; // 0x18
		private unsafe TLSFBlockHeader*[,] _freeList; // 0x20
		private IntPtr _memoryPool; // 0x28
		private uint _poolSize; // 0x30
		private unsafe TLSFBlockHeader* _firstBlock; // 0x38
	
		// Constructors
		public TLSFAllocator() {} // Dummy constructor
		public TLSFAllocator(uint size) {} // 0x00000001858016A8-0x00000001858017CC
	
		// Methods
		~TLSFAllocator() {} // 0x000000018580107C-0x0000000185801134
		public unsafe void* Allocate(uint size) => default; // 0x0000000185801010-0x000000018580107C
		public unsafe void Free(void* ptr) {} // 0x00000001858011E0-0x000000018580121C
		public uint GetFreeSpace() => default; // 0x000000018580121C-0x00000001858012B8
		private unsafe TLSFBlockHeader* FindSuitableBlock(uint size) => default; // 0x0000000185801134-0x00000001858011E0
		private unsafe void InsertFreeBlock(TLSFBlockHeader* block) {} // 0x00000001858012B8-0x00000001858013B4
		private unsafe void RemoveFreeBlock(TLSFBlockHeader* block) {} // 0x0000000185801540-0x0000000185801638
		private unsafe void SplitBlock(TLSFBlockHeader* block, uint size) {} // 0x0000000185801638-0x00000001858016A8
		private unsafe TLSFBlockHeader* MergeBlock(TLSFBlockHeader* block) => default; // 0x000000018580145C-0x0000000185801540
		private void MappingInsert(uint size, out int fl, out int sl) {
			fl = default;
			sl = default;
		} // 0x00000001858013B4-0x000000018580145C
		private static int MostSignificantBit(uint value) => default; // 0x00000001857FA43C-0x00000001857FA498
		private static int FindFirstSet(uint value) => default; // 0x00000001857FA41C-0x00000001857FA43C
		private static uint AlignSize(uint size) => default; // 0x0000000183D56690-0x0000000183D566A0
	}

	public class FactoryUnsafeUtil // TypeDefIndex: 49120
	{
		// Fields
		private const uint NO_NODE_ID_RANGE_MIN = 4000000000; // Metadata: 0x01FBBC40
		private const uint NO_NODE_ID_RANGE_MAX = 4294967294; // Metadata: 0x01FBBC45
		private static uint s_nodeId; // 0x00
	
		// Constructors
		public FactoryUnsafeUtil() {} // 0x000000018350B670-0x000000018350B680
		static FactoryUnsafeUtil() {} // 0x0000000183D44820-0x0000000183D44860
	
		// Methods
		public static bool IsManualNodeId(uint id) => default; // 0x00000001857FD5D8-0x00000001857FD5EC
		public static uint AllocManualNodeId() => default; // 0x0000000182F40DD0-0x0000000182F40E70
		public static bool IsPointInSector(float3 point, float3 center, float3 dir, float checkRad, float checkDist, out float curDistanceSq, out float curCosTheta, bool ignoreY = true /* Metadata: 0x01FBBC3F */) {
			curDistanceSq = default;
			curCosTheta = default;
			return default;
		} // 0x00000001857FD5EC-0x00000001857FD878
		public static unsafe void SwapPointer<T>(ref ref T* p1, ref ref T* p2)
			where T : struct {}
		public static IntPtr AddressOf(ref GlobalEnv env) => default; // 0x00000001827DD160-0x00000001827DD630
		public static void CallFromLuaCheck() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class StructMarshal // TypeDefIndex: 49121
	{
		// Methods
		public static byte[] StructToBytes<T>(T str)
			where T : struct => default;
		public static byte[] UnmanagedStructToBytes<T>(T value)
			where T : struct => default;
		public static T BytesToStruct<T>(byte[] bytes, int offset)
			where T : struct => default;
		public static T BytesToUnmanagedStruct<T>(byte[] bytes, int offset = 0 /* Metadata: 0x01FBBC46 */)
			where T : struct => default;
		public static byte[] FixedList512BytesToBytes<T>([IsReadOnly] in FixedList512Bytes<T> list)
			where T : struct => default;
		public static FixedList512Bytes<T> BytesToFixedList512Bytes<T>([IsReadOnly] in byte[] bytes)
			where T : struct => default;
	}
}

namespace Beyond.Gameplay.Factory.Util
{
	public static class JobHandlerExtensions // TypeDefIndex: 49099
	{
		// Extension methods
		public static void SafeComplete(this JobHandle jobHandle) {} // 0x00000001857FD970-0x00000001857FD9D8
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond // TypeDefIndex: 48539
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime() {} // 0x0000000183CB2C90-0x0000000183CB2CC0
		private static void Initialize() {} // 0x0000000183CB2CC0-0x0000000183CB2D40
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 48540
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 48541
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 48542
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 48543
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 48544
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace FactoryUIAtlas
{
	[CreateAssetMenu(fileName = "FactoryPipeLiquidSetting", menuName = "Factory/FactoryPipeLiquidSetting")]
	public class FactoryLiquidAtlasSOData : ScriptableObject // TypeDefIndex: 48504
	{
		// Fields
		public SerializeFieldDictionary<string, FacItemSubType> m_liquidMaterial; // 0x18
		public SerializeFieldDictionary<FacItemSubType, int> m_liquidMatIndex; // 0x20
	
		// Constructors
		public FactoryLiquidAtlasSOData() {} // 0x0000000183C8A360-0x0000000183C8A430
	
		// Methods
		public bool GetMaterial(string mat, out FacItemSubType matName) {
			matName = default;
			return default;
		} // 0x000000018578F2B0-0x000000018578F314
		public bool GetAtlasMaterialSort(FacItemSubType matName, out int sort) {
			sort = default;
			return default;
		} // 0x000000018578F24C-0x000000018578F2B0
		public static FactoryLiquidAtlasSOData CreateOrGet(string path) => default; // 0x000000018578F168-0x000000018578F24C
	}

	public class FactoryUIAtlasSOData : ScriptableObject // TypeDefIndex: 48505
	{
		// Fields
		public SerializeFieldDictionary<string, RectInt> m_insertName; // 0x18
		public SerializeFieldDictionary<string, int> m_insertIndex; // 0x20
	
		// Constructors
		public FactoryUIAtlasSOData() {} // 0x00000001839DEBD0-0x00000001839DED00
	
		// Methods
		public bool GetRect(string texName, out RectInt rect) {
			rect = default;
			return default;
		} // 0x0000000182C03700-0x0000000182C03770
		public bool GetIndex(string texName, out int index) {
			index = default;
			return default;
		} // 0x0000000182F889B0-0x0000000182F88B10
		public static FactoryUIAtlasSOData CreateOrGet(string path) => default; // 0x000000018578F5F0-0x000000018578F6D4
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 48503
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 49125
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05AA0-0x0000000183D05B10
	
		// Methods
		public int __Gen_Wrap_0(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public NativeArray<int> __Gen_Wrap_1(object P0) => default; // 0x00000001857D3C80-0x00000001857D3D78
		public object __Gen_Wrap_2(int P0) => default; // 0x00000001857E0920-0x00000001857E0A0C
		public void __Gen_Wrap_3() {} // 0x00000001850F3444-0x00000001850F34E0
		public void __Gen_Wrap_4(ref PerDrawConfig P0) {} // 0x00000001857F3BBC-0x00000001857F3D1C
		public void __Gen_Wrap_5(ref FFactoryStateColorConfig P0) {} // 0x00000001857F494C-0x00000001857F4A84
		public void __Gen_Wrap_6(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public NativeArray<ComponentType> __Gen_Wrap_7() => default; // 0x00000001857F6984-0x00000001857F6A74
		public NativeArray<ComponentType> __Gen_Wrap_8(NativeArray<ComponentType> P0, object P1) => default; // 0x00000001857F7EE0-0x00000001857F802C
		public NativeArray<ComponentType> __Gen_Wrap_9(object P0) => default; // 0x00000001857F8F80-0x00000001857F908C
		public void __Gen_Wrap_10(ref ConveyorExtContainer P0) {} // 0x00000001857CA008-0x00000001857CA150
		public uint __Gen_Wrap_11(ref ConveyorExtContainer P0) => default; // 0x00000001857CB6B0-0x00000001857CB7F4
		public Span<ConveyorExtContainer.ConveyorExt> __Gen_Wrap_12(ref ConveyorExtContainer P0) => default; // 0x00000001857CCE4C-0x00000001857CCFBC
		public uint __Gen_Wrap_13(ref ConveyorExtContainer P0, ref ConveyorExtContainer.ConveyorExt P1) => default; // 0x00000001857CE07C-0x00000001857CE25C
		public void __Gen_Wrap_14(ref ConveyorExtContainer P0, uint P1) {} // 0x00000001857CEDD8-0x00000001857CEF38
		public IntPtr __Gen_Wrap_15(ref ConveyorExtContainer P0) => default; // 0x00000001857CFC34-0x00000001857CFD8C
		public ref ConveyorExtContainer.ConveyorExt __Gen_Wrap_16(ref ConveyorExtContainer P0, uint P1) => ref _refReturnTypeFor__Gen_Wrap_16; // 0x00000001857D0998-0x00000001857D0B08
		private ref ConveyorExtContainer.ConveyorExt _refReturnTypeFor__Gen_Wrap_16; // Dummy field
		public void __Gen_Wrap_17(ref ConveyorExtContainer.ConveyorExt P0) {} // 0x00000001857D1654-0x00000001857D1798
		public void __Gen_Wrap_18(ref LinearAllocatorUnmanaged P0) {} // 0x00000001857D2A60-0x00000001857D2BC8
		public LinearAllocator.Allocation __Gen_Wrap_19(ref LinearAllocatorUnmanaged P0, int P1) => default; // 0x00000001857D3ABC-0x00000001857D3C80
		public LinearAllocator.Allocation __Gen_Wrap_20(ref ConveyorInfoAllocator P0, int P1) => default; // 0x00000001857D56F4-0x00000001857D58B8
		public void __Gen_Wrap_21(ref LinearAllocatorUnmanaged P0, int P1) {} // 0x00000001857D6B50-0x00000001857D6CD0
		public LinearAllocator.Allocation __Gen_Wrap_22(ref LinearAllocatorUnmanaged P0, int P1, int P2) => default; // 0x00000001857D7F70-0x00000001857D8144
		public LinearAllocator.Allocation __Gen_Wrap_23(ref ConveyorInfoAllocator P0, LinearAllocator.Allocation P1, int P2) => default; // 0x00000001857D9650-0x00000001857D9850
		public void __Gen_Wrap_24(ref ConveyorInfoAllocator P0, uint P1) {} // 0x00000001857DB9A0-0x00000001857DBB20
		public long __Gen_Wrap_25(ref ConveyorInfoAllocator P0, uint P1) => default; // 0x00000001857DCC40-0x00000001857DCDD0
		public int __Gen_Wrap_26(KeyValuePair<int, int> P0) => default; // 0x00000001857DDC10-0x00000001857DDD04
		public void __Gen_Wrap_27(ref ConveyorInfoAllocator P0) {} // 0x00000001857DE968-0x00000001857DEABC
		public void __Gen_Wrap_28(ref SharedDataContainer P0) {} // 0x00000001857DF84C-0x00000001857DF994
		public uint __Gen_Wrap_29(ref SharedDataContainer P0) => default; // 0x00000001857E07DC-0x00000001857E0920
		public Span<SharedDataContainer.SharedExtData> __Gen_Wrap_30(ref SharedDataContainer P0) => default; // 0x00000001857E19E8-0x00000001857E1B58
		public uint __Gen_Wrap_31(ref SharedDataContainer P0, ref SharedDataContainer.SharedExtData P1) => default; // 0x00000001857E2998-0x00000001857E2B98
		public void __Gen_Wrap_32(ref SharedDataContainer P0, uint P1) {} // 0x00000001857E39B8-0x00000001857E3B18
		public IntPtr __Gen_Wrap_33(ref SharedDataContainer P0) => default; // 0x00000001857E4F74-0x00000001857E50CC
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_34(ref SharedDataContainer P0, uint P1) => ref _refReturnTypeFor__Gen_Wrap_34; // 0x00000001857E6028-0x00000001857E6198
		private ref SharedDataContainer.SharedExtData _refReturnTypeFor__Gen_Wrap_34; // Dummy field
		public bool __Gen_Wrap_35(ref SharedDataContainer.SharedExtData P0, SharedDataContainer.DirtyFlag P1) => default; // 0x00000001857E6F78-0x00000001857E70E8
		public void __Gen_Wrap_36(ref SharedDataContainer.SharedExtData P0, SharedDataContainer.DirtyFlag P1, bool P2) {} // 0x00000001857E82A8-0x00000001857E8424
		public bool __Gen_Wrap_37(ref SharedDataContainer.SharedExtData P0) => default; // 0x00000001857E9898-0x00000001857E9A00
		public float3 __Gen_Wrap_38(ref WireRendererInfo P0) => default; // 0x00000001857EB2B4-0x00000001857EB438
		public quaternion __Gen_Wrap_39(ref WireRendererInfo P0) => default; // 0x00000001857EC6A4-0x00000001857EC820
		public NativeParallelHashMap<UnitId, Entity> __Gen_Wrap_40(object P0) => default; // 0x00000001857EDCD4-0x00000001857EDDCC
		public UnitId __Gen_Wrap_41(int P0, uint P1) => default; // 0x00000001857EF65C-0x00000001857EF764
		public void __Gen_Wrap_42(object P0, int P1, uint P2, Entity P3) {} // 0x00000001857F0E34-0x00000001857F0F64
		public bool __Gen_Wrap_43(object P0, int P1, uint P2) => default; // 0x000000018561022C-0x0000000185610330
		public bool __Gen_Wrap_44(object P0, int P1, uint P2, out Entity P3) {
			P3 = default;
			return default;
		} // 0x00000001857F382C-0x00000001857F3988
		public void __Gen_Wrap_45(ref VATFSMDefinitionContainer P0) {} // 0x00000001857F3988-0x00000001857F3AD0
		public uint __Gen_Wrap_46() => default; // 0x00000001850EF068-0x00000001850EF114
		public void __Gen_Wrap_47(uint P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public ref ConveyorExtContainer.ConveyorExt __Gen_Wrap_48(uint P0) => ref _refReturnTypeFor__Gen_Wrap_48; // 0x00000001857F3AD0-0x00000001857F3BBC
		private ref ConveyorExtContainer.ConveyorExt _refReturnTypeFor__Gen_Wrap_48; // Dummy field
		public IntPtr __Gen_Wrap_49() => default; // 0x000000018516C778-0x000000018516C824
		public uint __Gen_Wrap_50(bool P0) => default; // 0x00000001857F3D1C-0x00000001857F3DEC
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_51(uint P0) => ref _refReturnTypeFor__Gen_Wrap_51; // 0x00000001857F3DEC-0x00000001857F3ED8
		private ref SharedDataContainer.SharedExtData _refReturnTypeFor__Gen_Wrap_51; // Dummy field
		public ref EntityHierarchyContainer.EntityTransformData __Gen_Wrap_52(uint P0) => ref _refReturnTypeFor__Gen_Wrap_52; // 0x00000001857F3ED8-0x00000001857F3FC4
		private ref EntityHierarchyContainer.EntityTransformData _refReturnTypeFor__Gen_Wrap_52; // Dummy field
		public ref EntityHierarchyContainer.EntityTransformData __Gen_Wrap_53(int P0) => ref _refReturnTypeFor__Gen_Wrap_53; // 0x00000001857F3FC4-0x00000001857F40B0
		private ref EntityHierarchyContainer.EntityTransformData _refReturnTypeFor__Gen_Wrap_53; // Dummy field
		public float4x4 __Gen_Wrap_54(ref LocalTransform P0) => default; // 0x00000001857F40B0-0x00000001857F4244
		public float4x4 __Gen_Wrap_55(in EntityHierarchyContainer.EntityTransformData P0) => default; // 0x00000001857F4244-0x00000001857F43A8
		public uint __Gen_Wrap_56(ref VATFSMDefinitionContainer P0, ref VATFSMDefinition P1) => default; // 0x00000001857F43A8-0x00000001857F45A8
		public uint __Gen_Wrap_57(ref VATFSMDefinition P0) => default; // 0x00000001857F45A8-0x00000001857F4710
		public ref VATFSMDefinition __Gen_Wrap_58(uint P0) => ref _refReturnTypeFor__Gen_Wrap_58; // 0x00000001857F4710-0x00000001857F47FC
		private ref VATFSMDefinition _refReturnTypeFor__Gen_Wrap_58; // Dummy field
		public void __Gen_Wrap_59(ref VATFSMDefinitionContainer P0, uint P1) {} // 0x00000001857F47FC-0x00000001857F494C
		public IntPtr __Gen_Wrap_60(ref VATFSMDefinitionContainer P0) => default; // 0x00000001857F4A84-0x00000001857F4BDC
		public AdditiveEffectFragment.AdditiveEffectType __Gen_Wrap_61(ref AdditiveEffectFragment P0) => default; // 0x00000001857F4BDC-0x00000001857F4D44
		public void __Gen_Wrap_62(ref AdditiveEffectFragment P0) {} // 0x00000001857F4D44-0x00000001857F4E9C
		public void __Gen_Wrap_63(ref AdditiveEffectFragment P0, AdditiveEffectFragment.AdditiveEffectType P1) {} // 0x00000001857F4E9C-0x00000001857F5010
		public void __Gen_Wrap_64(ref AdditiveEffectFragment P0, int P1, AdditiveEffectFragment.AdditiveEffectType P2) {} // 0x00000001857F5010-0x00000001857F51A0
		public string __Gen_Wrap_65(ref AdditiveEffectFragment P0) => default; // 0x00000001857F51A0-0x00000001857F5318
		public void __Gen_Wrap_66(ref CutoffState P0, bool P1) {} // 0x00000001857F5318-0x00000001857F5458
		public void __Gen_Wrap_67(ref CutoffState P0, float P1) {} // 0x00000001857F5458-0x00000001857F55A8
		public void __Gen_Wrap_68(ref CutoffState P0, uint P1) {} // 0x00000001857F55A8-0x00000001857F56E4
		public void __Gen_Wrap_69(ref BuildDismissState P0, bool P1) {} // 0x00000001857F56E4-0x00000001857F5834
		public void __Gen_Wrap_70(ref HighLightState P0, bool P1) {} // 0x00000001857F5834-0x00000001857F5A3C
		public void __Gen_Wrap_71(ref HighLightState P0, bool P1, bool P2) {} // 0x00000001857F5A3C-0x00000001857F5C58
		public LogicEntityState __Gen_Wrap_72(ref HighLightState P0) => default; // 0x00000001857F5C58-0x00000001857F5E44
		public bool __Gen_Wrap_73(ref HighLightState P0, byte P1) => default; // 0x00000001857F5E44-0x00000001857F604C
		public void __Gen_Wrap_74(ref HighLightState P0, byte P1, bool P2) {} // 0x00000001857F604C-0x00000001857F6268
		public void __Gen_Wrap_75(ref HighLightState P0) {} // 0x00000001857F6268-0x00000001857F6454
		public void __Gen_Wrap_76(ref HintState P0, bool P1) {} // 0x00000001857F6454-0x00000001857F65A0
		public void __Gen_Wrap_77(ref FigureState P0, bool P1) {} // 0x00000001857F65A0-0x00000001857F66EC
		public void __Gen_Wrap_78(ref OverloadState P0, bool P1) {} // 0x00000001857F66EC-0x00000001857F6838
		public void __Gen_Wrap_79(ref OverloadInvalidState P0, bool P1) {} // 0x00000001857F6838-0x00000001857F6984
		public void __Gen_Wrap_80(ref DitherState P0, bool P1) {} // 0x00000001857F6A74-0x00000001857F6BA8
		public void __Gen_Wrap_81(ref BlueprintState P0, bool P1) {} // 0x00000001857F6BA8-0x00000001857F6DD4
		public void __Gen_Wrap_82(ref BlueprintState P0, bool P1, BlueprintState.EffectType P2) {} // 0x00000001857F6DD4-0x00000001857F701C
		public bool __Gen_Wrap_83(ref BlueprintState P0, byte P1) => default; // 0x00000001857F701C-0x00000001857F7248
		public void __Gen_Wrap_84(ref BlueprintState P0, byte P1, bool P2) {} // 0x00000001857F7248-0x00000001857F7490
		public void __Gen_Wrap_85(ref BlueprintState P0) {} // 0x00000001857F7490-0x00000001857F76A8
		public void __Gen_Wrap_86(ref PreSelectState P0, bool P1) {} // 0x00000001857F76A8-0x00000001857F78B4
		public bool __Gen_Wrap_87(ref PreSelectState P0, byte P1) => default; // 0x00000001857F78B4-0x00000001857F7AC0
		public void __Gen_Wrap_88(ref PreSelectState P0, byte P1, bool P2) {} // 0x00000001857F7AC0-0x00000001857F7CE8
		public void __Gen_Wrap_89(ref PreSelectState P0) {} // 0x00000001857F7CE8-0x00000001857F7EE0
		public void __Gen_Wrap_90(ref SoloSelectState P0, bool P1) {} // 0x00000001857F802C-0x00000001857F8160
		public bool __Gen_Wrap_91(ref SoloSelectState P0, int P1) => default; // 0x00000001857F8160-0x00000001857F82A0
		public void __Gen_Wrap_92(ref ContinuationState P0, bool P1) {} // 0x00000001857F82A0-0x00000001857F84AC
		public bool __Gen_Wrap_93(ref ContinuationState P0, byte P1) => default; // 0x00000001857F84AC-0x00000001857F86B8
		public void __Gen_Wrap_94(ref ContinuationState P0, byte P1, bool P2) {} // 0x00000001857F86B8-0x00000001857F88CC
		public void __Gen_Wrap_95(ref ContinuationState P0) {} // 0x00000001857F88CC-0x00000001857F8AB0
		public void __Gen_Wrap_96(ref SocialSharingState P0, bool P1) {} // 0x00000001857F8AB0-0x00000001857F8BE0
		public void __Gen_Wrap_97(ref PowerInteractionState P0, bool P1) {} // 0x00000001857F8BE0-0x00000001857F8D10
		public bool __Gen_Wrap_98(ref AdditiveEffectRendererFragment P0) => default; // 0x00000001857F8D10-0x00000001857F8E50
		public void __Gen_Wrap_99(ref AdditiveEffectRendererFragment P0) {} // 0x00000001857F8E50-0x00000001857F8F80
		public void __Gen_Wrap_100(ref BattleFragment P0) {} // 0x00000001857C90A8-0x00000001857C91D8
		public bool __Gen_Wrap_101(ref BindRenderEntityFragment P0, Entity P1) => default; // 0x00000001857C91D8-0x00000001857C93C0
		public void __Gen_Wrap_102(ref BindRenderEntityFragment P0, Entity P1) {} // 0x00000001857C93C0-0x00000001857C9598
		public void __Gen_Wrap_103(ref BindRenderEntityFragment P0, object P1) {} // 0x00000001857C9598-0x00000001857C9740
		public void __Gen_Wrap_104(ref BindRenderEntityFragment P0, NativeArray<Entity> P1) {} // 0x00000001857C9740-0x00000001857C9924
		public void __Gen_Wrap_105(ref BindRenderEntityFragment P0) {} // 0x00000001857C9924-0x00000001857C9AC4
		public bool __Gen_Wrap_106(ref BindRenderEntityFragment P0) => default; // 0x00000001857C9AC4-0x00000001857C9C74
		public void __Gen_Wrap_107(ref BurnPowerFragment P0) {} // 0x00000001857C9C74-0x00000001857C9DD4
		public void __Gen_Wrap_108(ref BusFragment P0) {} // 0x00000001857C9DD4-0x00000001857C9EEC
		public void __Gen_Wrap_109(ref BusFreeFragment P0) {} // 0x00000001857C9EEC-0x00000001857CA008
		public unsafe int __Gen_Wrap_110(ref CacheFragment P0, bool P1, bool P2, int P3, int P4, out FactoryItem* P5) {
			P5 = default;
			return default;
		} // 0x00000001857CA150-0x00000001857CA404
		public void __Gen_Wrap_111(ref CacheFragment P0, bool P1, bool P2, int P3, int P4, out uint P5, out int P6, out long P7) {
			P5 = default;
			P6 = default;
			P7 = default;
		} // 0x00000001857CA404-0x00000001857CA704
		public void __Gen_Wrap_112(ref CacheFragment P0, bool P1, bool P2, int P3, int P4, uint P5, int P6, long P7) {} // 0x00000001857CA704-0x00000001857CA98C
		public void __Gen_Wrap_113(ref CacheFragment P0, bool P1, bool P2, int P3, int P4) {} // 0x00000001857CA98C-0x00000001857CABDC
		public void __Gen_Wrap_114(ref CacheFragment P0) {} // 0x00000001857CABDC-0x00000001857CADC0
		public void __Gen_Wrap_115(ref CacheTransportFragment P0) {} // 0x00000001857CADC0-0x00000001857CAEF0
		public float __Gen_Wrap_116(ref CargoFragment P0, long P1) => default; // 0x00000001857CAEF0-0x00000001857CB0C0
		public int __Gen_Wrap_117(ref CargoFragment P0, CargoFragment P1) => default; // 0x00000001857CB0C0-0x00000001857CB2E4
		public CargoFragment __Gen_Wrap_118(uint P0, int4 P1, int4 P2, int P3, int P4, long P5, int P6, float P7, bool P8) => default; // 0x00000001857CB2E4-0x00000001857CB50C
		public void __Gen_Wrap_119(ref CargoFragment P0) {} // 0x00000001857CB50C-0x00000001857CB6B0
		public void __Gen_Wrap_120(ref CargoRendererFragment P0) {} // 0x00000001857CB7F4-0x00000001857CB90C
		public void __Gen_Wrap_121(ref ChapterFragment P0) {} // 0x00000001857CB90C-0x00000001857CBA98
		public void __Gen_Wrap_122(ref CollectorFragment P0) {} // 0x00000001857CBA98-0x00000001857CBBBC
		public bool __Gen_Wrap_123(ref ConnectionFragment P0) => default; // 0x00000001857CBBBC-0x00000001857CBD24
		public void __Gen_Wrap_124(ref ConnectionFragment P0) {} // 0x00000001857CBD24-0x00000001857CBE68
		public unsafe void __Gen_Wrap_125(ref GlobalEnv P0, uint P1, int P2, out ConveyorInfoAllocator.Info* P3) {
			P3 = default;
		} // 0x00000001857CBE68-0x00000001857CC150
		public void __Gen_Wrap_126(NativeList<float3> P0, ref UnityEngine.Rect P1) {} // 0x00000001857CC150-0x00000001857CC2C4
		public void __Gen_Wrap_127(ref ConveyorFragment P0, ref GlobalEnv P1, ref NativeList<float3> P2, ref NativeList<float3> P3, ref NativeArray<byte> P4) {} // 0x00000001857CC2C4-0x00000001857CC734
		public bool __Gen_Wrap_128(ref ConveyorFragment P0, ref GlobalEnv P1, float2 P2, out uint P3, out int P4) {
			P3 = default;
			P4 = default;
			return default;
		} // 0x00000001857CC734-0x00000001857CCAF0
		public bool __Gen_Wrap_129(ref ConveyorFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5) => default; // 0x00000001857CCAF0-0x00000001857CCE4C
		public bool __Gen_Wrap_130(ref ConveyorFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref PooledList<int> P6) => default; // 0x00000001857CCFBC-0x00000001857CD374
		public bool __Gen_Wrap_131(ref ConveyorFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref ValueTuple<uint, int>[,] P6) => default; // 0x00000001857CD374-0x00000001857CD72C
		public void __Gen_Wrap_132(ref ConveyorFragment P0, float P1) {} // 0x00000001857CD72C-0x00000001857CD884
		public void __Gen_Wrap_133(ref ConveyorFragment P0) {} // 0x00000001857CD884-0x00000001857CD9C0
		public void __Gen_Wrap_134(ref ConveyorLogisticsUnitFragment P0) {} // 0x00000001857CD9C0-0x00000001857CDAD8
		public void __Gen_Wrap_135(ref ConveyorRenderFragment P0) {} // 0x00000001857CDAD8-0x00000001857CDC1C
		public void __Gen_Wrap_136(ref LeftFragment P0) {} // 0x00000001857CDC1C-0x00000001857CDD34
		public void __Gen_Wrap_137(ref RightFragment P0) {} // 0x00000001857CDD34-0x00000001857CDE4C
		public void __Gen_Wrap_138(ref MidFragment P0) {} // 0x00000001857CDE4C-0x00000001857CDF64
		public void __Gen_Wrap_139(ref CullResultFragment P0) {} // 0x00000001857CDF64-0x00000001857CE07C
		public void __Gen_Wrap_140(ref DebugFragment P0) {} // 0x00000001857CE25C-0x00000001857CE360
		public void __Gen_Wrap_141(ref EvtDestroyUnit P0) {} // 0x00000001857CE360-0x00000001857CE484
		public void __Gen_Wrap_142(ref ShowStateUI P0) {} // 0x00000001857CE484-0x00000001857CE59C
		public void __Gen_Wrap_143(ref ShowNameUI P0) {} // 0x00000001857CE59C-0x00000001857CE6B4
		public void __Gen_Wrap_144(ref HasRenderer P0) {} // 0x00000001857CE6B4-0x00000001857CE7CC
		public void __Gen_Wrap_145(ref EvtUpdatePipeEffect P0) {} // 0x00000001857CE7CC-0x00000001857CE8E8
		public void __Gen_Wrap_146(ref EvtChangeTemplate P0) {} // 0x00000001857CE8E8-0x00000001857CEA84
		public void __Gen_Wrap_147(ref EvtCreateUnitRenderer P0) {} // 0x00000001857CEA84-0x00000001857CEBA0
		public void __Gen_Wrap_148(ref EvtUpdateStatusEffect P0) {} // 0x00000001857CEBA0-0x00000001857CECBC
		public void __Gen_Wrap_149(ref EvtPendingCreateRenderer P0) {} // 0x00000001857CECBC-0x00000001857CEDD8
		public void __Gen_Wrap_150(ref EvtUpdateRendererProperty P0) {} // 0x00000001857CEF38-0x00000001857CF05C
		public void __Gen_Wrap_151(ref EvtStatusChange P0) {} // 0x00000001857CF05C-0x00000001857CF18C
		public void __Gen_Wrap_152(ref EvtCreateInteract P0) {} // 0x00000001857CF18C-0x00000001857CF2B0
		public void __Gen_Wrap_153(ref EvtVatUpdate P0) {} // 0x00000001857CF2B0-0x00000001857CF3D4
		public void __Gen_Wrap_154(ref EvtUpdatePedestalColorLUT P0) {} // 0x00000001857CF3D4-0x00000001857CF504
		public void __Gen_Wrap_155(ref EvtAudio P0) {} // 0x00000001857CF504-0x00000001857CF628
		public void __Gen_Wrap_156(ref AudioFragment P0) {} // 0x00000001857CF628-0x00000001857CF758
		public void __Gen_Wrap_157(ref ReleaseTagFragment P0) {} // 0x00000001857CF758-0x00000001857CF870
		public void __Gen_Wrap_158(ref CurMapUnitTag P0) {} // 0x00000001857CF870-0x00000001857CF988
		public UnitFragment __Gen_Wrap_159(uint P0, object P1, int P2, bool2 P3, int P4, uint P5, object P6, bool P7, bool P8, bool P9, long P10, bool P11, object P12) => default; // 0x00000001857CF988-0x00000001857CFC34
		public void __Gen_Wrap_160(ref UnitFragment P0) {} // 0x00000001857CFD8C-0x00000001857CFFC0
		public void __Gen_Wrap_161(ref UnitRenderPipeLogisticsFigureReplaceFragment P0) {} // 0x00000001857CFFC0-0x00000001857D00D8
		public void __Gen_Wrap_162(ref BusRenderFragment P0) {} // 0x00000001857D00D8-0x00000001857D01F0
		public void __Gen_Wrap_163(ref UnitRenderBuildingFragment P0) {} // 0x00000001857D01F0-0x00000001857D0308
		public void __Gen_Wrap_164(ref UnitRenderPedestalFragment P0) {} // 0x00000001857D0308-0x00000001857D0420
		public void __Gen_Wrap_165(ref UnitRendererRegularFragment P0) {} // 0x00000001857D0420-0x00000001857D0538
		public void __Gen_Wrap_166(ref UnitOnlyRendererFragment P0) {} // 0x00000001857D0538-0x00000001857D0650
		public void __Gen_Wrap_167(ref FakeUnitFragment P0) {} // 0x00000001857D0650-0x00000001857D0768
		public void __Gen_Wrap_168(ref UIUnitFragment P0) {} // 0x00000001857D0768-0x00000001857D0880
		public void __Gen_Wrap_169(ref GuideHintFragment P0) {} // 0x00000001857D0880-0x00000001857D0998
		public void __Gen_Wrap_170(ref UnitPreviewFragment P0) {} // 0x00000001857D0B08-0x00000001857D0C38
		public void __Gen_Wrap_171(ref ConveyorRegularFragment P0) {} // 0x00000001857D0C38-0x00000001857D0D50
		public void __Gen_Wrap_172(ref ConveyorGuideFragment P0) {} // 0x00000001857D0D50-0x00000001857D0E68
		public void __Gen_Wrap_173(ref PipeRegularFragment P0) {} // 0x00000001857D0E68-0x00000001857D0F80
		public void __Gen_Wrap_174(ref ConveyorPreviewRendererFragment P0) {} // 0x00000001857D0F80-0x00000001857D10AC
		public void __Gen_Wrap_175(ref PipePreviewRendererFragment P0) {} // 0x00000001857D10AC-0x00000001857D11DC
		public void __Gen_Wrap_176(ref PipePreviewFragment P0) {} // 0x00000001857D11DC-0x00000001857D12F4
		public void __Gen_Wrap_177(ref FigureRenderFragment P0) {} // 0x00000001857D12F4-0x00000001857D1424
		public void __Gen_Wrap_178(ref FigureRenderLeftFragment P0) {} // 0x00000001857D1424-0x00000001857D153C
		public void __Gen_Wrap_179(ref FigureRenderRightFragment P0) {} // 0x00000001857D153C-0x00000001857D1654
		public void __Gen_Wrap_180(ref FigureRenderMidFragment P0) {} // 0x00000001857D1798-0x00000001857D18B0
		public void __Gen_Wrap_181(ref FigureRenderPipeHolderFragment P0) {} // 0x00000001857D18B0-0x00000001857D19C8
		public void __Gen_Wrap_182(ref FluidConsumeFragment P0) {} // 0x00000001857D19C8-0x00000001857D1AE4
		public void __Gen_Wrap_183(ref FluidContainerFragment P0, int P1, int P2, int P3, int P4) {} // 0x00000001857D1AE4-0x00000001857D1D24
		public void __Gen_Wrap_184(ref FluidContainerFragment P0, int P1, int P2) {} // 0x00000001857D1D24-0x00000001857D1F44
		public bool __Gen_Wrap_185(ref FluidContainerFragment P0, int P1, out int P2, out int P3, out float P4, out int P5, out int P6) {
			P2 = default;
			P3 = default;
			P4 = default;
			P5 = default;
			P6 = default;
			return default;
		} // 0x00000001857D1F44-0x00000001857D226C
		public bool __Gen_Wrap_186(ref FluidContainerFragment P0) => default; // 0x00000001857D226C-0x00000001857D2470
		public void __Gen_Wrap_187(ref FluidContainerFragment P0, float P1) {} // 0x00000001857D2470-0x00000001857D266C
		public ValueTuple<int, uint> __Gen_Wrap_188(ref FluidContainerFragment P0) => default; // 0x00000001857D266C-0x00000001857D286C
		public void __Gen_Wrap_189(ref FluidContainerFragment P0) {} // 0x00000001857D286C-0x00000001857D2A60
		public string __Gen_Wrap_190(ref FluidContainerFragment P0) => default; // 0x00000001857D2BC8-0x00000001857D2DC8
		public void __Gen_Wrap_191(ref FluidPumpInFragment P0) {} // 0x00000001857D2DC8-0x00000001857D2EE0
		public void __Gen_Wrap_192(ref FluidPumpOutFragment P0) {} // 0x00000001857D2EE0-0x00000001857D2FF8
		public void __Gen_Wrap_193(ref FluidReactionFragment P0) {} // 0x00000001857D2FF8-0x00000001857D3110
		public void __Gen_Wrap_194(ref FluidSprayFragment P0) {} // 0x00000001857D3110-0x00000001857D322C
		public void __Gen_Wrap_195(ref FormulaManualFragment P0) {} // 0x00000001857D322C-0x00000001857D335C
		public void __Gen_Wrap_196(ref OutOfBufferWarning P0) {} // 0x00000001857D335C-0x00000001857D3494
		public string __Gen_Wrap_197(ref OutOfBufferWarning P0) => default; // 0x00000001857D3494-0x00000001857D35DC
		public bool __Gen_Wrap_198(ref GlobalEnv P0) => default; // 0x00000001857D35DC-0x00000001857D3854
		public void __Gen_Wrap_199(ref GlobalEnv P0) {} // 0x00000001857D3854-0x00000001857D3ABC
		public UnsafeList<float4x4> __Gen_Wrap_200(ref GlobalEnv P0) => default; // 0x00000001857D3D78-0x00000001857D4018
		public UnsafeList<OutputRendererInfo> __Gen_Wrap_201(ref GlobalEnv P0) => default; // 0x00000001857D4018-0x00000001857D42B8
		public UnsafeList<Matrix4x4> __Gen_Wrap_202(ref GlobalEnv P0) => default; // 0x00000001857D42B8-0x00000001857D4558
		public ref ConveyorInfoAllocator.Info __Gen_Wrap_203(ref GlobalEnv P0, uint P1, int P2) => ref _refReturnTypeFor__Gen_Wrap_203; // 0x00000001857D4558-0x00000001857D4814
		private ref ConveyorInfoAllocator.Info _refReturnTypeFor__Gen_Wrap_203; // Dummy field
		public LinearAllocator.Allocation __Gen_Wrap_204(ref GlobalEnv P0, int P1) => default; // 0x00000001857D4814-0x00000001857D4AD8
		public long __Gen_Wrap_205(ref GlobalEnv P0, uint P1) => default; // 0x00000001857D4AD8-0x00000001857D4D64
		public LinearAllocator.Allocation __Gen_Wrap_206(ref GlobalEnv P0, uint P1, int P2) => default; // 0x00000001857D4D64-0x00000001857D503C
		public void __Gen_Wrap_207(ref GlobalEnv P0, uint P1) {} // 0x00000001857D503C-0x00000001857D52B8
		public UnsafeList<VATFSMProcessor.SetAnimatorParamRequest> __Gen_Wrap_208(ref GlobalEnv P0) => default; // 0x00000001857D52B8-0x00000001857D5544
		public bool __Gen_Wrap_209(VATFSMDefinition P0, int P1, out byte P2, out Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P3) {
			P2 = default;
			P3 = default;
			return default;
		} // 0x00000001857D5544-0x00000001857D56F4
		public byte __Gen_Wrap_210(uint P0, int P1) => default; // 0x000000018561A558-0x000000018561A640
		public void __Gen_Wrap_211(ref GlobalEnv P0, ref EntityManager P1, Entity P2, in VATFSMProcessor.SetAnimatorParamRequest P3) {} // 0x00000001857D58B8-0x00000001857D5C38
		public void __Gen_Wrap_212(ref GlobalEnv P0, Entity P1, VATFSMProcessor.SetAnimatorParamRequest P2) {} // 0x00000001857D5C38-0x00000001857D5F20
		public UnsafeList<VATFSMProcessor.VATFSMAudioData> __Gen_Wrap_213(ref GlobalEnv P0) => default; // 0x00000001857D5F20-0x00000001857D61A8
		public ref VATFSMProcessor.VATFSMAudioData __Gen_Wrap_214(ref GlobalEnv P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_214; // 0x00000001857D61A8-0x00000001857D6444
		private ref VATFSMProcessor.VATFSMAudioData _refReturnTypeFor__Gen_Wrap_214; // Dummy field
		public int __Gen_Wrap_215(ref GlobalEnv P0) => default; // 0x00000001857D6444-0x00000001857D66BC
		public void __Gen_Wrap_216(ref HealthPoleFragment P0) {} // 0x00000001857D66BC-0x00000001857D67E0
		public void __Gen_Wrap_217(ref InventoryFragment P0) {} // 0x00000001857D67E0-0x00000001857D68F8
		public void __Gen_Wrap_218(ref LiquidPurifierFragment P0) {} // 0x00000001857D68F8-0x00000001857D6A10
		public void __Gen_Wrap_219(ref LogisticEffectFragment P0) {} // 0x00000001857D6A10-0x00000001857D6B50
		public void __Gen_Wrap_220(ref LogisticEntityBindFragment P0, Entity P1, uint P2) {} // 0x00000001857D6CD0-0x00000001857D6E7C
		public bool __Gen_Wrap_221(ref LogisticEntityBindFragment P0, out Entity P1) {
			P1 = default;
			return default;
		} // 0x00000001857D6E7C-0x00000001857D7034
		public void __Gen_Wrap_222(ref LogisticEntityBindFragment P0) {} // 0x00000001857D7034-0x00000001857D7178
		public void __Gen_Wrap_223(ref MapGridRendererFragment P0) {} // 0x00000001857D7178-0x00000001857D7290
		public void __Gen_Wrap_224(ref OutputFragment P0) {} // 0x00000001857D7290-0x00000001857D7484
		public ref float4 __Gen_Wrap_225(ref OutputFragment P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_225; // 0x00000001857D7484-0x00000001857D76A0
		private ref float4 _refReturnTypeFor__Gen_Wrap_225; // Dummy field
		public void __Gen_Wrap_226(ref OutputFragment P0, int P1, float4 P2) {} // 0x00000001857D76A0-0x00000001857D78D4
		public void __Gen_Wrap_227(ref OutputFragment P0, int P1, UnityEngine.Color P2) {} // 0x00000001857D78D4-0x00000001857D7B1C
		public void __Gen_Wrap_228(ref OutputFragment P0, int P1, RectInt P2) {} // 0x00000001857D7B1C-0x00000001857D7D64
		public bool __Gen_Wrap_229(ref OutputFragment P0, int P1) => default; // 0x00000001857D7D64-0x00000001857D7F70
		public void __Gen_Wrap_230(ref OutputFragment P0, int P1, bool P2) {} // 0x00000001857D8144-0x00000001857D8364
		public bool __Gen_Wrap_231(ref OutputFragment P0) => default; // 0x00000001857D8364-0x00000001857D8554
		public void __Gen_Wrap_232(ref OutputUIRendererFragment P0) {} // 0x00000001857D8554-0x00000001857D866C
		public void __Gen_Wrap_233(ref PedestalLightFlashFragment P0) {} // 0x00000001857D866C-0x00000001857D87CC
		public bool __Gen_Wrap_234(ref PedestalLightFlashConfigFragment P0) => default; // 0x00000001857D87CC-0x00000001857D8A10
		public void __Gen_Wrap_235(ref PedestalLightFlashConfigFragment P0, int P1, float P2) {} // 0x00000001857D8A10-0x00000001857D8C88
		public void __Gen_Wrap_236(ref PedestalLightFlashConfigFragment P0, int P1, bool P2) {} // 0x00000001857D8C88-0x00000001857D8F00
		public void __Gen_Wrap_237(ref PedestalLightFlashConfigFragment P0, int P1, UnityEngine.Color P2) {} // 0x00000001857D8F00-0x00000001857D91A0
		public float __Gen_Wrap_238(ref PedestalLightFlashConfigFragment P0, int P1) => default; // 0x00000001857D91A0-0x00000001857D93F8
		public bool __Gen_Wrap_239(ref PedestalLightFlashConfigFragment P0, int P1) => default; // 0x00000001857D93F8-0x00000001857D9650
		public float4 __Gen_Wrap_240(ref PedestalLightFlashConfigFragment P0, int P1) => default; // 0x00000001857D9850-0x00000001857D9AD8
		public void __Gen_Wrap_241(ref PedestalLightFlashConfigFragment P0) {} // 0x00000001857D9AD8-0x00000001857D9D0C
		public void __Gen_Wrap_242(ref PipeEffectFragment P0) {} // 0x00000001857D9D0C-0x00000001857D9EF0
		public bool __Gen_Wrap_243(ref PipeFragment P0, ref GlobalEnv P1, ref NativeList<float3> P2, ref NativeList<float3> P3, ref NativeList<byte> P4) => default; // 0x00000001857D9EF0-0x00000001857DA3D4
		public void __Gen_Wrap_244(ref GlobalEnv P0, int P1, uint P2, float P3, bool P4, float P5, bool P6, float P7) {} // 0x00000001857DA3D4-0x00000001857DA6D0
		public ValueTuple<int[], int> __Gen_Wrap_245(ref GlobalEnv P0, uint P1, int P2) => default; // 0x00000001857DA6D0-0x00000001857DA98C
		public bool __Gen_Wrap_246(ref PipeFragment P0, ref GlobalEnv P1, float2 P2, out uint P3, out int P4) {
			P3 = default;
			P4 = default;
			return default;
		} // 0x00000001857DA98C-0x00000001857DADA8
		public bool __Gen_Wrap_247(ref PipeFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5) => default; // 0x00000001857DADA8-0x00000001857DB168
		public bool __Gen_Wrap_248(ref PipeFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref PooledList<int> P6) => default; // 0x00000001857DB168-0x00000001857DB584
		public bool __Gen_Wrap_249(ref PipeFragment P0, ref GlobalEnv P1, float P2, float P3, float P4, float P5, ref ValueTuple<uint, int>[,] P6) => default; // 0x00000001857DB584-0x00000001857DB9A0
		public void __Gen_Wrap_250(ref PipeFragment P0) {} // 0x00000001857DBB20-0x00000001857DBCD0
		public void __Gen_Wrap_251(ref PipeHolderFragment P0) {} // 0x00000001857DBCD0-0x00000001857DBE00
		public void __Gen_Wrap_252(ref PipeLogisticsUnitFragment P0) {} // 0x00000001857DBE00-0x00000001857DBF18
		public void __Gen_Wrap_253(ref PipeComRenderFragment P0) {} // 0x00000001857DBF18-0x00000001857DC048
		public void __Gen_Wrap_254(ref PipeRenderFragment P0) {} // 0x00000001857DC048-0x00000001857DC1AC
		public void __Gen_Wrap_255(ref PipeTrackRenderFragment P0) {} // 0x00000001857DC1AC-0x00000001857DC2DC
		public bool __Gen_Wrap_256(ref ComplexPortFragment P0, uint P1, int P2, bool P3, bool P4, uint P5, out bool P6) {
			P6 = default;
			return default;
		} // 0x00000001857DC2DC-0x00000001857DC4EC
		public bool __Gen_Wrap_257(ref ComplexPortFragment P0, uint P1, bool P2, object P3) => default; // 0x00000001857DC4EC-0x00000001857DC68C
		public bool __Gen_Wrap_258(ref ComplexPortFragment P0, bool P1, object P2, bool P3) => default; // 0x00000001857DC68C-0x00000001857DC840
		public void __Gen_Wrap_259(ref ComplexPortFragment P0, float3 P1, float3 P2, ref GlobalSharedData.UnitPortConfig P3, ref UnitConfigFragment P4, float P5) {} // 0x00000001857DC840-0x00000001857DCC40
		public bool __Gen_Wrap_260(ref ComplexPortFragment P0) => default; // 0x00000001857DCDD0-0x00000001857DCF38
		public bool __Gen_Wrap_261(ref Beyond.Gameplay.Factory.PortData P0, Beyond.Gameplay.Factory.PortData P1) => default; // 0x00000001857DCF38-0x00000001857DD0CC
		public bool __Gen_Wrap_262(ref ComplexPortFragment P0, ComplexPortFragment P1) => default; // 0x00000001857DD0CC-0x00000001857DD264
		public bool __Gen_Wrap_263(ref ComplexPortFragment P0, object P1) => default; // 0x00000001857DD264-0x00000001857DD3D4
		public int __Gen_Wrap_264(ref ComplexPortFragment P0) => default; // 0x00000001857DD3D4-0x00000001857DD528
		public bool __Gen_Wrap_265(ComplexPortFragment P0, ComplexPortFragment P1) => default; // 0x00000001857DD528-0x00000001857DD670
		public string __Gen_Wrap_266(ref Beyond.Gameplay.Factory.PortData P0) => default; // 0x00000001857DD670-0x00000001857DD7D4
		public string __Gen_Wrap_267(ref ComplexPortFragment P0) => default; // 0x00000001857DD7D4-0x00000001857DD938
		public void __Gen_Wrap_268(ref ComplexPortFragment P0) {} // 0x00000001857DD938-0x00000001857DDA7C
		public float4x4 __Gen_Wrap_269(ref Beyond.Gameplay.Factory.PortData P0) => default; // 0x00000001857DDA7C-0x00000001857DDC10
		public bool __Gen_Wrap_270(ref Beyond.Gameplay.Factory.PortData P0, object P1) => default; // 0x00000001857DDD04-0x00000001857DDE70
		public int __Gen_Wrap_271(ref Beyond.Gameplay.Factory.PortData P0) => default; // 0x00000001857DDE70-0x00000001857DDFC0
		public bool __Gen_Wrap_272(Beyond.Gameplay.Factory.PortData P0, Beyond.Gameplay.Factory.PortData P1) => default; // 0x00000001857DDFC0-0x00000001857DE108
		public void __Gen_Wrap_273(ref PortPreviewUIRendererFragment P0) {} // 0x00000001857DE108-0x00000001857DE220
		public void __Gen_Wrap_274(ref PortStatusUIFragment P0) {} // 0x00000001857DE220-0x00000001857DE338
		public void __Gen_Wrap_275(ref PowerPoleFragment P0) {} // 0x00000001857DE338-0x00000001857DE43C
		public void __Gen_Wrap_276(ref ProducerFragment P0) {} // 0x00000001857DE43C-0x00000001857DE570
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_277(ref SharedDataFragment P0) => ref _refReturnTypeFor__Gen_Wrap_277; // 0x00000001857DE570-0x00000001857DE6B4
		private ref SharedDataContainer.SharedExtData _refReturnTypeFor__Gen_Wrap_277; // Dummy field
		public void __Gen_Wrap_278(ref SharedDataFragment P0) {} // 0x00000001857DE6B4-0x00000001857DE7D8
		public SocialFragment __Gen_Wrap_279(ulong P0, uint P1, ulong P2, long P3, long P4, uint P5, bool P6) => default; // 0x00000001857DE7D8-0x00000001857DE968
		public bool __Gen_Wrap_280(ref SocialFragment P0) => default; // 0x00000001857DEABC-0x00000001857DEC34
		public void __Gen_Wrap_281(ref SocialFragment P0) {} // 0x00000001857DEC34-0x00000001857DED88
		public string __Gen_Wrap_282(ref SignData P0) => default; // 0x00000001857DED88-0x00000001857DEEEC
		public float __Gen_Wrap_283(object P0, uint3 P1) => default; // 0x00000001857DEEEC-0x00000001857DF014
		public void __Gen_Wrap_284(object P0, Entity P1, uint3 P2) {} // 0x00000001857DF014-0x00000001857DF160
		public void __Gen_Wrap_285(object P0, ref EntityManager P1, Entity P2) {} // 0x00000001857DF160-0x00000001857DF2E0
		public LocalTransform __Gen_Wrap_286(float4x4 P0) => default; // 0x00000001857DF2E0-0x00000001857DF420
		public LocalTransform __Gen_Wrap_287(float3 P0, quaternion P1) => default; // 0x00000001857DF420-0x00000001857DF58C
		public LocalTransform __Gen_Wrap_288(float3 P0, quaternion P1, float P2) => default; // 0x00000001857DF58C-0x00000001857DF71C
		public LocalTransform __Gen_Wrap_289(float3 P0) => default; // 0x00000001857DF71C-0x00000001857DF84C
		public LocalTransform __Gen_Wrap_290(float P0, float P1, float P2) => default; // 0x00000001857DF994-0x00000001857DFAC4
		public LocalTransform __Gen_Wrap_291(quaternion P0) => default; // 0x00000001857DFAC4-0x00000001857DFBEC
		public LocalTransform __Gen_Wrap_292(float P0) => default; // 0x00000001857DFBEC-0x00000001857DFCF0
		public string __Gen_Wrap_293(ref LocalTransform P0) => default; // 0x00000001857DFCF0-0x00000001857DFE40
		public float3 __Gen_Wrap_294(ref LocalTransform P0, float3 P1) => default; // 0x00000001857DFE40-0x00000001857E000C
		public float3 __Gen_Wrap_295(ref LocalTransform P0) => default; // 0x00000001857E000C-0x00000001857E0180
		public quaternion __Gen_Wrap_296(ref LocalTransform P0, quaternion P1) => default; // 0x00000001857E0180-0x00000001857E0340
		public float __Gen_Wrap_297(ref LocalTransform P0, float P1) => default; // 0x00000001857E0340-0x00000001857E04B0
		public LocalTransform __Gen_Wrap_298(ref LocalTransform P0, in LocalTransform P1) => default; // 0x00000001857E04B0-0x00000001857E0674
		public LocalTransform __Gen_Wrap_299(ref LocalTransform P0) => default; // 0x00000001857E0674-0x00000001857E07DC
		public LocalTransform __Gen_Wrap_300(ref LocalTransform P0, float3 P1) => default; // 0x00000001857E0A0C-0x00000001857E0BCC
		public LocalTransform __Gen_Wrap_301(ref LocalTransform P0, float P1, float P2, float P3) => default; // 0x00000001857E0BCC-0x00000001857E0D74
		public LocalTransform __Gen_Wrap_302(ref LocalTransform P0, quaternion P1) => default; // 0x00000001857E0D74-0x00000001857E0F30
		public LocalTransform __Gen_Wrap_303(ref LocalTransform P0, float P1) => default; // 0x00000001857E0F30-0x00000001857E10C4
		public bool __Gen_Wrap_304(ref LocalTransform P0, in LocalTransform P1) => default; // 0x00000001857E10C4-0x00000001857E124C
		public void __Gen_Wrap_305(ref LocalTransform P0) {} // 0x00000001857E124C-0x00000001857E137C
		public void __Gen_Wrap_306(ref Root P0) {} // 0x00000001857E137C-0x00000001857E1480
		public void __Gen_Wrap_307(ref Parent P0) {} // 0x00000001857E1480-0x00000001857E159C
		public void __Gen_Wrap_308(ref Beyond.Gameplay.Factory.Child P0) {} // 0x00000001857E159C-0x00000001857E1780
		public bool __Gen_Wrap_309(ref LocalToWorld P0, float4x4 P1, int P2) => default; // 0x00000001857E1780-0x00000001857E19E8
		public float3 __Gen_Wrap_310(ref LocalToWorld P0) => default; // 0x00000001857E1B58-0x00000001857E1D8C
		public void __Gen_Wrap_311(ref LocalToWorld P0) {} // 0x00000001857E1D8C-0x00000001857E1F64
		public void __Gen_Wrap_312(ref UdPipeFragment P0) {} // 0x00000001857E1F64-0x00000001857E2088
		public void __Gen_Wrap_313(ref UnitConfigFragment P0) {} // 0x00000001857E2088-0x00000001857E21FC
		public string __Gen_Wrap_314(ref FactoryUnitExtendConfig P0) => default; // 0x00000001857E21FC-0x00000001857E237C
		public void __Gen_Wrap_315(ref UnitInteractFragment P0) {} // 0x00000001857E237C-0x00000001857E2498
		public void __Gen_Wrap_316(ref UnitRenderFragment P0) {} // 0x00000001857E2498-0x00000001857E260C
		public void __Gen_Wrap_317(ref RenderLookAtFragment P0) {} // 0x00000001857E260C-0x00000001857E2748
		public void __Gen_Wrap_318(ref ChapterTagFragment P0) {} // 0x00000001857E2748-0x00000001857E286C
		public void __Gen_Wrap_319(ref UnitStatusFragment P0) {} // 0x00000001857E286C-0x00000001857E2998
		public void __Gen_Wrap_320(ref UnitOverrideStatusFragment P0) {} // 0x00000001857E2B98-0x00000001857E2CB0
		public void __Gen_Wrap_321(ref UnitStatusEffectFragment P0, BuildingStatus P1, object P2) {} // 0x00000001857E2CB0-0x00000001857E2E80
		public FixedList512Bytes<StatusSingleEffect> __Gen_Wrap_322(ref UnitStatusEffectFragment P0, FacBuildingState P1) => default; // 0x00000001857E2E80-0x00000001857E30C4
		public void __Gen_Wrap_323(ref UnitStatusEffectFragment P0) {} // 0x00000001857E30C4-0x00000001857E3250
		public void __Gen_Wrap_324(ref UnitStatusUIRendererFragment P0) {} // 0x00000001857E3250-0x00000001857E3368
		public bool __Gen_Wrap_325(ref UnitTransFragment P0, float3 P1, bool P2) => default; // 0x00000001857E3368-0x00000001857E3518
		public void __Gen_Wrap_326(ref UnitTransFragment P0) {} // 0x00000001857E3518-0x00000001857E3658
		public void __Gen_Wrap_327(ref ValveFragment P0) {} // 0x00000001857E3658-0x00000001857E3788
		public void __Gen_Wrap_328(ref Beyond.Gameplay.Factory.BoxValve P0) {} // 0x00000001857E3788-0x00000001857E38A0
		public void __Gen_Wrap_329(ref Beyond.Gameplay.Factory.FluidValve P0) {} // 0x00000001857E38A0-0x00000001857E39B8
		public ref SharedDataContainer.SharedExtData __Gen_Wrap_330(Entity P0, ref EntityManager P1) => ref _refReturnTypeFor__Gen_Wrap_330; // 0x00000001857E3B18-0x00000001857E3CA8
		private ref SharedDataContainer.SharedExtData _refReturnTypeFor__Gen_Wrap_330; // Dummy field
		public bool __Gen_Wrap_331(ref BlueprintSlotInfo P0, ref EntityManager P1, int P2, int P3) => default; // 0x00000001857E3CA8-0x00000001857E3EEC
		public void __Gen_Wrap_332(ref BlueprintSlotInfo P0, ref EntityManager P1, int P2, Entity P3) {} // 0x00000001857E3EEC-0x00000001857E4160
		public int __Gen_Wrap_333(ref BlueprintSlotInfo P0) => default; // 0x00000001857E4160-0x00000001857E4310
		public int __Gen_Wrap_334(ref BlueprintSlotInfo P0, int P1) => default; // 0x00000001857E4310-0x00000001857E44DC
		public void __Gen_Wrap_335(ref BlueprintSlotInfo P0, int P1, int P2) {} // 0x00000001857E44DC-0x00000001857E46A8
		public ulong[] __Gen_Wrap_336(ref BlueprintSlotInfo P0) => default; // 0x00000001857E46A8-0x00000001857E486C
		public void __Gen_Wrap_337(ref BlueprintSlotInfo P0, int P1, Entity P2) {} // 0x00000001857E486C-0x00000001857E4A60
		public Entity[] __Gen_Wrap_338(ref BlueprintSlotInfo P0, int P1) => default; // 0x00000001857E4A60-0x00000001857E4C3C
		public void __Gen_Wrap_339(ref BlueprintSlotInfo P0, ref EntityManager P1, int P2, ref PooledList<uint> P3, ref PooledList<uint> P4, ref PooledList<Entity> P5) {} // 0x00000001857E4C3C-0x00000001857E4F74
		public ulong __Gen_Wrap_340(ref BlueprintSlotInfo P0, int P1) => default; // 0x00000001857E50CC-0x00000001857E5298
		public Entity __Gen_Wrap_341(ref BlueprintSlotInfo P0, int P1, int P2) => default; // 0x00000001857E5298-0x00000001857E5488
		public NativeArray<Entity> __Gen_Wrap_342(ref BlueprintSlotInfo P0, int P1) => default; // 0x00000001857E5488-0x00000001857E567C
		public BlueprintSlotInfo __Gen_Wrap_343() => default; // 0x00000001857E567C-0x00000001857E57B0
		public string __Gen_Wrap_344(ref BlueprintSlotInfo P0) => default; // 0x00000001857E57B0-0x00000001857E5960
		public string __Gen_Wrap_345(ref ConveyorRendererInfo P0) => default; // 0x00000001857E5960-0x00000001857E5AD4
		public bool __Gen_Wrap_346(ref UnitId P0, UnitId P1) => default; // 0x00000001857E5AD4-0x00000001857E5C3C
		public bool __Gen_Wrap_347(ref UnitId P0, object P1) => default; // 0x00000001857E5C3C-0x00000001857E5D80
		public int __Gen_Wrap_348(ref UnitId P0) => default; // 0x00000001857E5D80-0x00000001857E5EB8
		public bool __Gen_Wrap_349(ref Visibility P0, Visibility.EFlag P1) => default; // 0x00000001857E5EB8-0x00000001857E6028
		public bool __Gen_Wrap_350(ref Visibility P0) => default; // 0x00000001857E6198-0x00000001857E62F0
		public bool __Gen_Wrap_351(ref Visibility P0, Visibility.EFlag P1, bool P2) => default; // 0x00000001857E62F0-0x00000001857E647C
		public void __Gen_Wrap_352(ref WireRendererFragment P0) {} // 0x00000001857E647C-0x00000001857E6594
		public void __Gen_Wrap_353(ref GlobalSharedData.MapGridRendererData P0) {} // 0x00000001857E6594-0x00000001857E6734
		public void __Gen_Wrap_354(ref GlobalSharedData P0) {} // 0x00000001857E6734-0x00000001857E684C
		public void __Gen_Wrap_355(ref GlobalSharedData.CullingGlobalSetting P0) {} // 0x00000001857E684C-0x00000001857E699C
		public float __Gen_Wrap_356(ref GlobalSharedData.CullingGlobalSetting P0) => default; // 0x00000001857E699C-0x00000001857E6AFC
		public void __Gen_Wrap_357(ref GlobalSharedData.NearByDistanceGlobalSetting P0) {} // 0x00000001857E6AFC-0x00000001857E6C70
		public bool __Gen_Wrap_358(ref GlobalSharedData.NearByDistanceGlobalSetting P0) => default; // 0x00000001857E6C70-0x00000001857E6DF4
		public float __Gen_Wrap_359(ref GlobalSharedData.NearByDistanceGlobalSetting P0) => default; // 0x00000001857E6DF4-0x00000001857E6F78
		public void __Gen_Wrap_360(ref GlobalSharedData.World3DUiGlobalSetting P0) {} // 0x00000001857E70E8-0x00000001857E7224
		public bool __Gen_Wrap_361(ref GlobalSharedData.World3DUiGlobalSetting P0) => default; // 0x00000001857E7224-0x00000001857E7370
		public void __Gen_Wrap_362(ref GlobalSharedData.CurveGlobalSetting P0, ref Beyond.Gameplay.Factory.FPtrNativeCurve P1, ref Beyond.Gameplay.Factory.FPtrNativeCurve P2, ref Beyond.Gameplay.Factory.FPtrNativeCurve P3) {} // 0x00000001857E7370-0x00000001857E764C
		public void __Gen_Wrap_363(ref GlobalSharedData.CurveGlobalSetting P0, ref Beyond.Gameplay.Factory.FPtrNativeCurve P1) {} // 0x00000001857E764C-0x00000001857E7830
		public void __Gen_Wrap_364(ref GlobalSharedData.MapGridRendererData P0, ref GlobalSharedData.MapGridRendererData.MapGridInfo[] P1, ref GlobalSharedData.MapGridRendererData.MapGridInfo[] P2) {} // 0x00000001857E7830-0x00000001857E7A74
		public void __Gen_Wrap_365(ref GlobalSharedData.UnitPortConfigDB P0, int P1) {} // 0x00000001857E7A74-0x00000001857E7BC4
		public void __Gen_Wrap_366(ref GlobalSharedData.UnitPortConfigDB P0) {} // 0x00000001857E7BC4-0x00000001857E7CE8
		public bool __Gen_Wrap_367(ref GlobalSharedData.UnitPortConfigDB P0, int P1, out GlobalSharedData.UnitPortConfig P2) {
			P2 = default;
			return default;
		} // 0x00000001857E7CE8-0x00000001857E7F04
		public bool __Gen_Wrap_368(ref GlobalSharedData.UnitPortConfigDB P0, object P1, out GlobalSharedData.UnitPortConfig P2) {
			P2 = default;
			return default;
		} // 0x00000001857E7F04-0x00000001857E8124
		public void __Gen_Wrap_369(object P0, ref FactoryUnitPortConfig P1, int P2) {} // 0x00000001857E8124-0x00000001857E82A8
		public GlobalSharedData.UnitPortConfig __Gen_Wrap_370(ref GlobalSharedData.UnitPortConfigDB P0, object P1) => default; // 0x00000001857E8424-0x00000001857E861C
		public void __Gen_Wrap_371(ref GlobalSharedData.UnitPortConfigDB P0, int P1, GlobalSharedData.UnitPortConfig P2) {} // 0x00000001857E861C-0x00000001857E8810
		public void __Gen_Wrap_372(ref GlobalSharedData.UnitPortConfigDB P0, object P1, GlobalSharedData.UnitPortConfig P2) {} // 0x00000001857E8810-0x00000001857E8A08
		public GlobalSharedData.UnitPortConfig __Gen_Wrap_373(ref GlobalSharedData.UnitPortConfigDB P0, int P1) => default; // 0x00000001857E8A08-0x00000001857E8C00
		public bool __Gen_Wrap_374(ref GlobalSharedData.UnitPortConfigDB P0, object P1) => default; // 0x00000001857E8C00-0x00000001857E8D50
		public int __Gen_Wrap_375(ref GlobalSharedData.PerDrawGlobalSetting P0, LogicEntityState P1, LogicEntityType P2) => default; // 0x00000001857E8D50-0x00000001857E8F30
		public void __Gen_Wrap_376(ref GlobalSharedData.PerDrawGlobalSetting P0, ref HGFactoryRendererBinderComponent P1, LogicEntityState P2, LogicEntityType P3) {} // 0x00000001857E8F30-0x00000001857E9178
		public void __Gen_Wrap_377(ref GlobalSharedData.PerDrawGlobalSetting P0, ref HGFactoryRendererBinderComponent P1, LogicEntityState P2, LogicEntityType P3, uint P4) {} // 0x00000001857E9178-0x00000001857E93C0
		public void __Gen_Wrap_378(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting P0, int P1, PerDrawConfig P2) {} // 0x00000001857E93C0-0x00000001857E9630
		public void __Gen_Wrap_379(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting P0, int P1, PerDrawPassConfig P2) {} // 0x00000001857E9630-0x00000001857E9898
		public void __Gen_Wrap_380(ref GlobalSharedData.PerDrawGlobalSetting P0, object P1) {} // 0x00000001857E9A00-0x00000001857E9BBC
		public PerDrawPassConfig __Gen_Wrap_381(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting P0, int P1) => default; // 0x00000001857E9BBC-0x00000001857E9E08
		public PerDrawConfig __Gen_Wrap_382(ref GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting P0, int P1) => default; // 0x00000001857E9E08-0x00000001857EA05C
		public void __Gen_Wrap_383(ref GlobalSharedData.SystemIntervalGlobalSetting P0) {} // 0x00000001857EA05C-0x00000001857EA1DC
		public int __Gen_Wrap_384(ref GlobalSharedData.SystemIntervalGlobalSetting P0) => default; // 0x00000001857EA1DC-0x00000001857EA36C
		public void __Gen_Wrap_385(ref GlobalSharedData.UIEffectPathConfig P0, object P1, object P2, object P3) {} // 0x00000001857EA36C-0x00000001857EA504
		public bool __Gen_Wrap_386(ref GlobalSharedData.UIEffectPathConfig P0, FacBuildingState P1, out FixedString32Bytes P2, out float4 P3, out float4 P4) {
			P2 = default;
			P3 = default;
			P4 = default;
			return default;
		} // 0x00000001857EA504-0x00000001857EA75C
		public void __Gen_Wrap_387(object P0, ref EntityManager P1, ref GlobalEnv P2, object P3) {} // 0x00000001857EA75C-0x00000001857EAA70
		public JobHandle __Gen_Wrap_388(object P0, ref EntityManager P1, long P2, long P3, int P4, int P5, int P6, ref GlobalEnv P7, JobHandle P8, NativeList<JobHandle> P9) => default; // 0x00000001857EAA70-0x00000001857EAE88
		public JobHandle __Gen_Wrap_389(object P0, ref EntityManager P1, long P2, long P3, float P4, int P5, int P6, int P7, ref GlobalEnv P8, JobHandle P9, NativeList<JobHandle> P10) => default; // 0x00000001857EAE88-0x00000001857EB2B4
		public JobHandle __Gen_Wrap_390(object P0, ref EntityManager P1, ref GlobalEnv P2, int P3, int P4, int P5, JobHandle P6) => default; // 0x00000001857EB438-0x00000001857EB7E8
		public void __Gen_Wrap_391(object P0, ref EntityManager P1, ref GlobalEnv P2) {} // 0x00000001857EB7E8-0x00000001857EBAD4
		public void __Gen_Wrap_392(object P0, ref NativeList<JobHandle> P1) {} // 0x00000001857EBAD4-0x00000001857EBC24
		public void __Gen_Wrap_393(object P0, ref JobHandle P1, ref NativeList<JobHandle> P2) {} // 0x00000001857EBC24-0x00000001857EBDF0
		public bool __Gen_Wrap_394(object P0, ref GlobalEnv P1) => default; // 0x00000001857EBDF0-0x00000001857EC07C
		public bool __Gen_Wrap_395(object P0, ref EntityManager P1) => default; // 0x00000001857EC07C-0x00000001857EC1DC
		public FunctionPointer<UnsafeJobFuncPointers.ApplyRender> __Gen_Wrap_396() => default; // 0x00000001857EC1DC-0x00000001857EC2A8
		public FunctionPointer<UnsafeJobFuncPointers.FacRegionPosValid> __Gen_Wrap_397() => default; // 0x00000001857EC2A8-0x00000001857EC374
		public FunctionPointer<UnsafeJobFuncPointers.QueryStateIconPath> __Gen_Wrap_398() => default; // 0x00000001857EC374-0x00000001857EC440
		public bool __Gen_Wrap_399(ref EntityManager P0, float P1, float P2, float P3, out UnitFragment P4) {
			P4 = default;
			return default;
		} // 0x00000001857EC440-0x00000001857EC6A4
		public FunctionPointer<UnsafeJobFuncPointers.QueryBuildingState> __Gen_Wrap_400() => default; // 0x00000001857EC820-0x00000001857EC8EC
		public FunctionPointer<UnsafeJobFuncPointers.SetEntityFlashStatue> __Gen_Wrap_401() => default; // 0x00000001857EC8EC-0x00000001857EC9B8
		public void __Gen_Wrap_402(ref AdditiveEffectJob P0, IntPtr P1) {} // 0x00000001857EC9B8-0x00000001857ECBE0
		public void __Gen_Wrap_403(ref AdditiveEffectJob P0, ref AdditiveEffectFragment P1, ref SharedDataContainer.SharedExtData P2) {} // 0x00000001857ECBE0-0x00000001857ECEFC
		public void __Gen_Wrap_404(ref CutoffState P0, ref BuildDismissState P1) {} // 0x00000001857ECEFC-0x00000001857ED0AC
		public void __Gen_Wrap_405(ref AdditiveEffectJob P0, int P1) {} // 0x00000001857ED0AC-0x00000001857ED2C0
		public void __Gen_Wrap_406(ref AdditiveEffectJob P0, int P1, int P2) {} // 0x00000001857ED2C0-0x00000001857ED4E4
		public void __Gen_Wrap_407(ref AdditiveEffectJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001857ED4E4-0x00000001857ED788
		public JobHandle __Gen_Wrap_408(ref AdditiveEffectJob P0, JobHandle P1, int P2) => default; // 0x00000001857ED788-0x00000001857EDA20
		public JobHandle __Gen_Wrap_409(ref AdditiveEffectJob P0, JobHandle P1, JobHandle P2, int P3) => default; // 0x00000001857EDA20-0x00000001857EDCD4
		public void __Gen_Wrap_410(ref AdditiveEffectQueryJob P0) {} // 0x00000001857EDDCC-0x00000001857EDF0C
		public void __Gen_Wrap_411(ref AdditiveEffectQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, ref EntityQueryV2.QueryResultDefer P2, ref EntityQueryV2.QueryResultDefer P3, bool P4) {} // 0x00000001857EDF0C-0x00000001857EE200
		public void __Gen_Wrap_412(ref AdditiveEffectRenderJob P0, ref SharedDataContainer.SharedExtData P1, ref AdditiveEffectRendererFragment P2, ref HGFactoryRendererBinderComponent P3) {} // 0x00000001857EE200-0x00000001857EE578
		public void __Gen_Wrap_413(ref AdditiveEffectRenderJob P0, IntPtr P1) {} // 0x00000001857EE578-0x00000001857EE788
		public void __Gen_Wrap_414(ref HGFactoryRendererBinderComponent P0, ref SharedDataContainer.SharedExtData P1, bool P2, bool P3) {} // 0x00000001857EE788-0x00000001857EE97C
		public void __Gen_Wrap_415(ref EntityManager P0, ref SharedDataContainer.SharedExtData P1, ref HGFactoryRendererBinderComponent P2, ref Beyond.Gameplay.Factory.FPtrNativeCurve P3, ref Beyond.Gameplay.Factory.FPtrNativeCurve P4, ref Beyond.Gameplay.Factory.FPtrNativeCurve P5, long P6) {} // 0x00000001857EE97C-0x00000001857EED80
		public void __Gen_Wrap_416(ref EntityManager P0, ref SharedDataContainer.SharedExtData P1, ref HGFactoryRendererBinderComponent P2) {} // 0x00000001857EED80-0x00000001857EEFCC
		public void __Gen_Wrap_417(ref AdditiveEffectRenderJob P0, int P1) {} // 0x00000001857EEFCC-0x00000001857EF1C4
		public void __Gen_Wrap_418(ref AdditiveEffectRenderJob P0, int P1, int P2) {} // 0x00000001857EF1C4-0x00000001857EF3D0
		public void __Gen_Wrap_419(ref AdditiveEffectRenderJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001857EF3D0-0x00000001857EF65C
		public JobHandle __Gen_Wrap_420(ref AdditiveEffectRenderJob P0, JobHandle P1, int P2) => default; // 0x00000001857EF764-0x00000001857EF9CC
		public JobHandle __Gen_Wrap_421(ref AdditiveEffectRenderJob P0, JobHandle P1, JobHandle P2, int P3) => default; // 0x00000001857EF9CC-0x00000001857EFC7C
		public void __Gen_Wrap_422(ref AudioJobs.AudioDistanceAndCullingJob P0, int P1) {} // 0x00000001857EFC7C-0x00000001857EFDEC
		public void __Gen_Wrap_423(ref AudioJobs.AudioGroupEmitterJob P0, int P1) {} // 0x00000001857EFDEC-0x00000001857EFF68
		public void __Gen_Wrap_424(ref AudioJobs.AudioGroupEmitterJob P0, IntPtr P1) {} // 0x00000001857EFF68-0x00000001857F00F4
		public void __Gen_Wrap_425(ref AudioJobs.WaterPipeEmitterJob P0, int P1, ref PipeFragment P2) {} // 0x00000001857F00F4-0x00000001857F036C
		public void __Gen_Wrap_426(ref AudioJobs.WaterPipeEmitterJob P0, int P1) {} // 0x00000001857F036C-0x00000001857F04E8
		public void __Gen_Wrap_427(ref AudioJobs.WaterPipeEmitterJob P0, ref GlobalEnv P1) {} // 0x00000001857F04E8-0x00000001857F0810
		public void __Gen_Wrap_428(ref BatchArrowJob P0, bool P1, ref FixedList512Bytes<FactoryUnitPortConfig> P2, quaternion P3, float3 P4, ComplexPortFragment P5, float4x4 P6, float P7, bool P8, bool P9, bool P10, bool P11, bool P12, bool P13, bool P14, bool P15, bool P16, bool P17, bool P18) {} // 0x00000001857F0810-0x00000001857F0C8C
		public void __Gen_Wrap_429(ref BatchArrowJob P0, int P1, EntityQueryV2.QueryResult P2) {} // 0x00000001857F0C8C-0x00000001857F0E34
		public void __Gen_Wrap_430(ref BatchArrowJob P0, int P1) {} // 0x00000001857F0F64-0x00000001857F10C4
		public void __Gen_Wrap_431(ref BatchArrowJob P0, IntPtr P1) {} // 0x00000001857F10C4-0x00000001857F1238
		public void __Gen_Wrap_432(ref BatchArrowJob P0) {} // 0x00000001857F1238-0x00000001857F137C
		public void __Gen_Wrap_433(ref BatchInsideConveyorJob P0, uint P1, float3 P2, quaternion P3, ref FixedList512Bytes<FactoryUnitPortConfig> P4, ref ComplexPortFragment P5, bool P6, float P7, bool P8) {} // 0x00000001857F137C-0x00000001857F1804
		public void __Gen_Wrap_434(ref BatchInsideConveyorJob P0, int P1, EntityQueryV2.QueryResult P2) {} // 0x00000001857F1804-0x00000001857F1A68
		public void __Gen_Wrap_435(ref BatchInsideConveyorJob P0, int P1) {} // 0x00000001857F1A68-0x00000001857F1C80
		public void __Gen_Wrap_436(ref BatchInsideConveyorJob P0, IntPtr P1) {} // 0x00000001857F1C80-0x00000001857F1EAC
		public void __Gen_Wrap_437(ref BatchInsideConveyorJob P0) {} // 0x00000001857F1EAC-0x00000001857F20B0
		public void __Gen_Wrap_438(ref BatchNormalArrowJob P0, uint P1, bool P2, ref FixedList512Bytes<FactoryUnitPortConfig> P3, quaternion P4, float3 P5, ComplexPortFragment P6, float4x4 P7, float P8, bool P9, bool P10, bool P11, bool P12, bool P13, bool P14, bool P15, bool P16, bool P17) {} // 0x00000001857F20B0-0x00000001857F2520
		public void __Gen_Wrap_439(ref BatchNormalArrowJob P0, int P1, EntityQueryV2.QueryResult P2) {} // 0x00000001857F2520-0x00000001857F26C8
		public void __Gen_Wrap_440(ref BatchNormalArrowJob P0, int P1) {} // 0x00000001857F26C8-0x00000001857F2828
		public void __Gen_Wrap_441(ref BatchNormalArrowJob P0) {} // 0x00000001857F2828-0x00000001857F296C
		public void __Gen_Wrap_442(ref BatchNormalArrowJob P0, IntPtr P1) {} // 0x00000001857F296C-0x00000001857F2AE0
		public void __Gen_Wrap_443(ref BatchPreviewArrowJob P0, bool P1, ref FixedList512Bytes<FactoryUnitPortConfig> P2, quaternion P3, float3 P4, ComplexPortFragment P5, float4x4 P6, float P7, bool P8, bool P9, bool P10) {} // 0x00000001857F2AE0-0x00000001857F2FB4
		public void __Gen_Wrap_444(ref BatchPreviewArrowJob P0, int P1, EntityQueryV2.QueryResult P2) {} // 0x00000001857F2FB4-0x00000001857F3258
		public void __Gen_Wrap_445(ref BatchPreviewArrowJob P0) {} // 0x00000001857F3258-0x00000001857F349C
		public void __Gen_Wrap_446(ref BatchPreviewArrowJob P0, IntPtr P1) {} // 0x00000001857F349C-0x00000001857F3708
		public void __Gen_Wrap_447(ref BufferSwapJob P0) {} // 0x00000001857F3708-0x00000001857F382C
		public void __Gen_Wrap_448(ref BuildingLiquidRenderJob P0, Entity P1, ValueTuple<int, uint> P2) {} // 0x0000000181063B70-0x0000000181064B50
		public void __Gen_Wrap_449(ref BuildingLiquidRenderJob P0, int P1) {} // 0x0000000181064B50-0x0000000181065710
		public void __Gen_Wrap_450(ref BuildingLiquidRenderJob P0, int P1, int P2) {} // 0x0000000181065710-0x00000001810662E0
		public void __Gen_Wrap_451(ref BuildingLiquidRenderJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001810662E0-0x00000001810672B0
		public JobHandle __Gen_Wrap_452(ref BuildingLiquidRenderJob P0, JobHandle P1, int P2) => default; // 0x00000001810672B0-0x0000000181068250
		public void __Gen_Wrap_453(ref BuildingLiquidRenderJob P0, IntPtr P1) {} // 0x0000000181068250-0x0000000181068E40
		public void __Gen_Wrap_454(ref BuildingStatePosCollectJob P0, ref UnitFragment P1, ref UnitTransFragment P2, ref UnitConfigFragment P3, ref UnitStatusFragment P4, ref SharedDataFragment P5) {} // 0x0000000181068E40-0x000000018106AD70
		public void __Gen_Wrap_455(ref BuildingStatePosCollectJob P0, int P1) {} // 0x000000018106AD70-0x000000018106B970
		public void __Gen_Wrap_456(ref BuildingStatePosCollectJob P0, int P1, int P2) {} // 0x000000018106B970-0x000000018106C580
		public void __Gen_Wrap_457(ref BuildingStatePosCollectJob P0) {} // 0x000000018106C580-0x000000018106D170
		public void __Gen_Wrap_458(ref BuildingStatePosCollectJob P0, IntPtr P1) {} // 0x000000018106D170-0x000000018106DDB0
		public void __Gen_Wrap_459(ref BuildingStateRendererJob P0, int P1) {} // 0x000000018106DDB0-0x000000018106E980
		public void __Gen_Wrap_460(ref CargoCollectJob P0, int P1) {} // 0x000000018106E980-0x000000018106F580
		public void __Gen_Wrap_461(ref CargoCollectJob P0) {} // 0x000000018106F580-0x0000000181070170
		public void __Gen_Wrap_462(ref CargoCollectJob P0, ref GlobalEnv P1) {} // 0x0000000181070170-0x0000000181071370
		public void __Gen_Wrap_463(ref CargoCollectJob P0, IntPtr P1) {} // 0x0000000181071370-0x0000000181071FB0
		public void __Gen_Wrap_464(ref CargoPredictJob P0, int P1) {} // 0x0000000181071FB0-0x0000000181072B90
		public void __Gen_Wrap_465(ref CargoPredictJob P0, IntPtr P1) {} // 0x0000000181072B90-0x00000001810737B0
		public void __Gen_Wrap_466(ref CargoPredictJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001810737B0-0x00000001810747A0
		public JobHandle __Gen_Wrap_467(ref CargoPredictJob P0, JobHandle P1, int P2) => default; // 0x00000001810747A0-0x0000000181075780
		public void __Gen_Wrap_468(ref CargoPredictQueryJob P0) {} // 0x0000000181075780-0x0000000181076330
		public void __Gen_Wrap_469(ref CargoPredictQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x0000000181076330-0x0000000181077320
		public void __Gen_Wrap_470(ref CargoRenderJob P0, int P1) {} // 0x0000000181077320-0x0000000181077F00
		public void __Gen_Wrap_471(ref CargoRenderJob P0, IntPtr P1) {} // 0x0000000181077F00-0x0000000181078B10
		public void __Gen_Wrap_472(ref CargoRenderQueryJob P0) {} // 0x0000000181078B10-0x00000001810796C0
		public void __Gen_Wrap_473(ref CargoRenderQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x00000001810796C0-0x000000018107A6B0
		public void __Gen_Wrap_474(ref ConveyorCollectJob P0, ref ConveyorFragment P1, ref SharedDataFragment P2, bool P3, bool P4) {} // 0x000000018107A6B0-0x000000018107BB30
		public void __Gen_Wrap_475(ref ConveyorCollectJob P0, int P1) {} // 0x000000018107BB30-0x000000018107C730
		public void __Gen_Wrap_476(ref ConveyorCollectJob P0, int P1, int P2) {} // 0x000000018107C730-0x000000018107D340
		public void __Gen_Wrap_477(ref ConveyorCollectJob P0) {} // 0x000000018107D340-0x000000018107DF30
		public void __Gen_Wrap_478(ref ConveyorCollectJob P0, IntPtr P1) {} // 0x000000018107DF30-0x000000018107EB70
		public void __Gen_Wrap_479(ref ConveyorFigureRendererJob P0, int P1) {} // 0x000000018107EB70-0x000000018107F750
		public void __Gen_Wrap_480(ref ConveyorFigureRendererJob P0, int P1, int P2) {} // 0x000000018107F750-0x0000000181080350
		public void __Gen_Wrap_481(ref ConveyorFigureRendererJob P0, IntPtr P1) {} // 0x0000000181080350-0x0000000181080F70
		public void __Gen_Wrap_482(ref ConveyorInsideRenderJob P0, int P1) {} // 0x0000000181080F70-0x0000000181081BB0
		public void __Gen_Wrap_483(ref ConveyorPreviewCollectJob P0, ref ConveyorPreviewRendererFragment P1, ref SharedDataFragment P2, bool P3, bool P4) {} // 0x0000000181081BB0-0x0000000181083010
		public void __Gen_Wrap_484(ref ConveyorPreviewCollectJob P0, int P1) {} // 0x0000000181083010-0x0000000181083C10
		public void __Gen_Wrap_485(ref ConveyorPreviewCollectJob P0) {} // 0x0000000181083C10-0x0000000181084800
		public void __Gen_Wrap_486(ref ConveyorPreviewCollectJob P0, IntPtr P1) {} // 0x0000000181084800-0x0000000181085430
		public void __Gen_Wrap_487(ref ConveyorRendererJob P0, Entity P1, float P2, uint P3, float3 P4, float3 P5, float P6, float P7, float P8, bool P9, BlueprintState.EffectType P10, float P11, uint P12, bool P13, bool P14, bool P15) {} // 0x0000000181085430-0x0000000181086570
		public void __Gen_Wrap_488(ref ConveyorRendererJob P0, int P1) {} // 0x0000000181086570-0x0000000181087150
		public void __Gen_Wrap_489(ref ConveyorRendererJob P0, int P1, int P2) {} // 0x0000000181087150-0x0000000181087D50
		public void __Gen_Wrap_490(ref ConveyorRendererJob P0, IntPtr P1) {} // 0x0000000181087D50-0x0000000181088970
		public void __Gen_Wrap_491(ref InteractFacCollectJob P0) {} // 0x0000000181088970-0x00000001810896C0
		public bool __Gen_Wrap_492(float3 P0, float3 P1, float3 P2, float P3, float P4, out float P5, out float P6, bool P7) {
			P5 = default;
			P6 = default;
			return default;
		} // 0x00000001810896C0-0x0000000181089F40
		public void __Gen_Wrap_493(ref InteractFacCollectJob.BuildingInfo P0, in InteractFacCollectJob.BuildingInfo P1) {} // 0x0000000181089F40-0x000000018108AC70
		public float3 __Gen_Wrap_494(float3 P0) => default; // 0x000000018108AC70-0x000000018108B820
		public bool __Gen_Wrap_495(ref InteractFacCollectJob P0, float3 P1, float P2, ref int P3) => default; // 0x000000018108B820-0x000000018108C7A0
		public void __Gen_Wrap_496(ref InteractFacCollectJob P0, IntPtr P1) {} // 0x000000018108C7A0-0x000000018108D530
		public string __Gen_Wrap_497(ref InteractFacCollectJob.BuildingInfo P0) => default; // 0x000000018108D530-0x000000018108E420
		public bool __Gen_Wrap_498(ref InteractFacCollectJob.BuildingInfo P0) => default; // 0x000000018108E420-0x000000018108F030
		public bool __Gen_Wrap_499(ref InteractFacCollectJob.LogisticInfo P0) => default; // 0x000000018108F030-0x000000018108FC00
		public void __Gen_Wrap_500(ref LocalToWorldJob P0, int P1) {} // 0x000000018108FC00-0x00000001810907C0
		public void __Gen_Wrap_501(ref LocalToWorld P0, IntPtr P1, int P2) {} // 0x00000001810907C0-0x00000001810914D0
		public void __Gen_Wrap_502(ref LocalToWorldJob P0, int P1, int P2) {} // 0x00000001810914D0-0x00000001810920A0
		public void __Gen_Wrap_503(ref LocalToWorldJob P0, IntPtr P1) {} // 0x00000001810920A0-0x0000000181092CA0
		public void __Gen_Wrap_504(ref LocalToWorldJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x0000000181092CA0-0x0000000181093C70
		public JobHandle __Gen_Wrap_505(ref LocalToWorldJob P0, JobHandle P1, int P2) => default; // 0x0000000181093C70-0x0000000181094C20
		public void __Gen_Wrap_506(ref LocalToWorldQueryJob P0) {} // 0x0000000181094C20-0x00000001810957D0
		public void __Gen_Wrap_507(ref LocalToWorldQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x00000001810957D0-0x00000001810967C0
		public void __Gen_Wrap_508(ref LogisticEffectJob P0, int P1) {} // 0x00000001810967C0-0x00000001810973A0
		public void __Gen_Wrap_509(ref LookAtJob P0, int P1) {} // 0x00000001810973A0-0x0000000181097F50
		public void __Gen_Wrap_510(ref LookAtJob P0, IntPtr P1) {} // 0x0000000181097F50-0x0000000181098B30
		public void __Gen_Wrap_511(ref LookAtJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x0000000181098B30-0x0000000181099AE0
		public JobHandle __Gen_Wrap_512(ref LookAtJob P0, JobHandle P1, int P2) => default; // 0x0000000181099AE0-0x000000018109AA80
		public void __Gen_Wrap_513(ref LookAtQueryJob P0) {} // 0x000000018109AA80-0x000000018109B630
		public void __Gen_Wrap_514(ref LookAtQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x000000018109B630-0x000000018109C620
		public void __Gen_Wrap_515(ref OutputCollectJob P0, ref UnitFragment P1, ref UnitTransFragment P2, ref UnitConfigFragment P3, ref OutputFragment P4, ref SharedDataFragment P5) {} // 0x000000018109C620-0x000000018109E640
		public void __Gen_Wrap_516(ref OutputCollectJob P0, int P1) {} // 0x000000018109E640-0x000000018109F220
		public void __Gen_Wrap_517(ref OutputCollectJob P0, int P1, int P2) {} // 0x000000018109F220-0x000000018109FE20
		public void __Gen_Wrap_518(ref OutputCollectJob P0) {} // 0x000000018109FE20-0x00000001810A09F0
		public void __Gen_Wrap_519(ref OutputCollectJob P0, IntPtr P1) {} // 0x00000001810A09F0-0x00000001810A1610
		public void __Gen_Wrap_520(ref OutputRenderJob P0, int P1) {} // 0x00000001810A1610-0x00000001810A21E0
		public float4 __Gen_Wrap_521(ref PedestalFlashJob P0, ref PedestalLightFlashFragment P1, float P2) => default; // 0x00000001810A21E0-0x00000001810A3420
		public void __Gen_Wrap_522(ref PedestalFlashJob P0, int P1) {} // 0x00000001810A3420-0x00000001810A3FF0
		public void __Gen_Wrap_523(ref PedestalFlashJob P0, int P1, int P2) {} // 0x00000001810A3FF0-0x00000001810A4BD0
		public void __Gen_Wrap_524(ref PedestalFlashJob P0, IntPtr P1) {} // 0x00000001810A4BD0-0x00000001810A57D0
		public void __Gen_Wrap_525(ref PipeCollectJob P0, int P1, uint P2, uint P3, int P4, float P5, float P6, float P7, float P8, uint P9, bool P10, bool P11, bool P12) {} // 0x00000001810A57D0-0x00000001810A64D0
		public void __Gen_Wrap_526(ref PipeCollectJob P0, in PipeFragment P1, uint P2) {} // 0x00000001810A64D0-0x00000001810A7360
		public void __Gen_Wrap_527(ref PipeCollectJob P0, EntityQueryV2.BlockRange P1, NativeList<GroupType> P2) {} // 0x00000001810A7360-0x00000001810A83F0
		public void __Gen_Wrap_528(ref PipeCollectJob P0, int P1, uint P2, uint P3, float P4, float P5, float P6, uint P7, bool P8) {} // 0x00000001810A83F0-0x00000001810A9080
		public void __Gen_Wrap_529(ref PipeCollectJob P0, int P1) {} // 0x00000001810A9080-0x00000001810A9D10
		public void __Gen_Wrap_530(ref PipeCollectJob P0, int P1, int P2) {} // 0x00000001810A9D10-0x00000001810AA9C0
		public void __Gen_Wrap_531(ref PipeCollectJob P0) {} // 0x00000001810AA9C0-0x00000001810AB640
		public void __Gen_Wrap_532(ref PipeCollectJob P0, ref GlobalEnv P1) {} // 0x00000001810AB640-0x00000001810AC8D0
		public void __Gen_Wrap_533(ref PipeCollectJob P0, IntPtr P1) {} // 0x00000001810AC8D0-0x00000001810AD5B0
		public void __Gen_Wrap_534(ref PipeComRendererJob P0, int P1, int P2) {} // 0x00000001810AD5B0-0x00000001810AE1B0
		public void __Gen_Wrap_535(ref PipeFigureRendererJob P0, Entity P1, byte P2, float3 P3, float3 P4, float P5, float P6, float P7, float P8, float P9, float P10, bool P11, bool P12, bool P13) {} // 0x00000001810AE1B0-0x00000001810AF2A0
		public void __Gen_Wrap_536(ref PipeFigureRendererJob P0, int P1) {} // 0x00000001810AF2A0-0x00000001810AFE70
		public void __Gen_Wrap_537(ref PipeFigureRendererJob P0, int P1, int P2) {} // 0x00000001810AFE70-0x00000001810B0A50
		public void __Gen_Wrap_538(ref PipeHolderFigureRendererJob P0, int P1) {} // 0x00000001810B0A50-0x00000001810B1630
		public void __Gen_Wrap_539(ref PipeHolderFigureRendererJob P0, int P1, int P2) {} // 0x00000001810B1630-0x00000001810B2230
		public void __Gen_Wrap_540(ref PipeHolderHideRendererJob P0, int P1) {} // 0x00000001810B2230-0x00000001810B2E00
		public void __Gen_Wrap_541(ref PipeHolderHideRendererJob P0, int P1, int P2) {} // 0x00000001810B2E00-0x00000001810B39E0
		public void __Gen_Wrap_542(ref PipeHolderHideRendererJob P0, IntPtr P1) {} // 0x00000001810B39E0-0x00000001810B45E0
		public void __Gen_Wrap_543(ref PipeLogisticsPosCollectJob P0, int P1) {} // 0x00000001810B45E0-0x00000001810B51B0
		public void __Gen_Wrap_544(ref PipeLogisticsPosCollectJob P0, int P1, int P2) {} // 0x00000001810B51B0-0x00000001810B5D90
		public void __Gen_Wrap_545(ref PipeLogisticsPosCollectJob P0, IntPtr P1) {} // 0x00000001810B5D90-0x00000001810B6990
		public void __Gen_Wrap_546(ref PipeLogisticsPosCollectJob P0) {} // 0x00000001810B6990-0x00000001810B7550
		public void __Gen_Wrap_547(ref PipeRendererJob P0, Entity P1, byte P2, float3 P3, float3 P4, float P5, uint P6, int P7, int P8, float P9, float P10, float P11, BlueprintState.EffectType P12, float P13, uint P14, bool P15, bool P16, bool P17) {} // 0x00000001810B7550-0x00000001810B8670
		public void __Gen_Wrap_548(ref PipeRendererJob P0, int P1, int P2) {} // 0x00000001810B8670-0x00000001810B9280
		public void __Gen_Wrap_549(ref PipeRendererJob P0, IntPtr P1) {} // 0x00000001810B9280-0x00000001810B9EB0
		public void __Gen_Wrap_550(ref PipeTrackRendererJob P0, Entity P1, float3 P2, float3 P3, float P4, float P5, float P6, float P7, float P8, bool P9) {} // 0x00000001810B9EB0-0x00000001810BB080
		public void __Gen_Wrap_551(ref PipeTrackRendererJob P0) {} // 0x00000001810BB080-0x00000001810BBCA0
		public void __Gen_Wrap_552(ref PipeWaterThicknessQueryJob P0) {} // 0x00000001810BBCA0-0x00000001810BC850
		public void __Gen_Wrap_553(ref PipeWaterThicknessQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x00000001810BC850-0x00000001810BD840
		public void __Gen_Wrap_554(ref PipeWaterThicknessRiseJob P0, int P1) {} // 0x00000001810BD840-0x00000001810BE400
		public void __Gen_Wrap_555(ref PipeWaterThicknessRiseJob P0, int P1, int P2) {} // 0x00000001810BE400-0x00000001810BEFD0
		public void __Gen_Wrap_556(ref PipeWaterThicknessRiseJob P0, ref GlobalEnv P1) {} // 0x00000001810BEFD0-0x00000001810C01B0
		public void __Gen_Wrap_557(ref PipeWaterThicknessRiseJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001810C01B0-0x00000001810C1180
		public JobHandle __Gen_Wrap_558(ref PipeWaterThicknessRiseJob P0, JobHandle P1, int P2) => default; // 0x00000001810C1180-0x00000001810C2130
		public void __Gen_Wrap_559(ref PortArrowRenderJob P0, int P1) {} // 0x00000001810C2130-0x00000001810C2D10
		public void __Gen_Wrap_560(ref PortStateCollectJob P0, ref ComplexPortFragment P1, ref SharedDataContainer.SharedExtData P2) {} // 0x00000001810C2D10-0x00000001810C41A0
		public void __Gen_Wrap_561(ref PortStateCollectJob P0, int P1) {} // 0x00000001810C41A0-0x00000001810C4D80
		public void __Gen_Wrap_562(ref PortStateCollectJob P0, IntPtr P1) {} // 0x00000001810C4D80-0x00000001810C59A0
		public void __Gen_Wrap_563(ref PortStateCollectJob P0) {} // 0x00000001810C59A0-0x00000001810C6570
		public void __Gen_Wrap_564(ref PortStateCollectJob P0, int P1, int P2) {} // 0x00000001810C6570-0x00000001810C7170
		public void __Gen_Wrap_565(ref PortStateRendererJob P0, int P1) {} // 0x00000001810C7170-0x00000001810C7D40
		public void __Gen_Wrap_566(ref PreviewUnitQueryJob P0) {} // 0x00000001810C7D40-0x00000001810C88F0
		public void __Gen_Wrap_567(ref PreviewUnitQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, bool P2) {} // 0x00000001810C88F0-0x00000001810C98E0
		public void __Gen_Wrap_568(ref PumpInEffectJob P0, int P1) {} // 0x00000001810C98E0-0x00000001810CA4A0
		public void __Gen_Wrap_569(ref PumpInEffectJob P0, int P1, int P2) {} // 0x00000001810CA4A0-0x00000001810CB070
		public void __Gen_Wrap_570(ref PumpInEffectJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001810CB070-0x00000001810CC040
		public JobHandle __Gen_Wrap_571(ref PumpInEffectJob P0, JobHandle P1, int P2) => default; // 0x00000001810CC040-0x00000001810CCFE0
		public void __Gen_Wrap_572(ref PumpInEffectJob P0, IntPtr P1) {} // 0x00000001810CCFE0-0x00000001810CDBD0
		public void __Gen_Wrap_573(ref StatusChangeJob P0, int P1) {} // 0x00000001810CDBD0-0x00000001810CE810
		public void __Gen_Wrap_574(ref UnitCullingJob P0, int P1) {} // 0x00000001810CE810-0x00000001810CF420
		public void __Gen_Wrap_575(ref UnitCullingJob P0, int P1, int P2) {} // 0x00000001810CF420-0x00000001810D0040
		public void __Gen_Wrap_576(ref UnitCullingJob P0, ref GlobalEnv P1) {} // 0x00000001810D0040-0x00000001810D1260
		public void __Gen_Wrap_577(ref UnitCullingJob P0, IntPtr P1) {} // 0x00000001810D1260-0x00000001810D1EB0
		public void __Gen_Wrap_578(ref UnitPreviewRenderJob P0, int P1) {} // 0x00000001810D1EB0-0x00000001810D2A70
		public void __Gen_Wrap_579(ref UnitPreviewRenderJob P0, int P1, int P2) {} // 0x00000001810D2A70-0x00000001810D3640
		public void __Gen_Wrap_580(ref UnitPreviewRenderJob P0, ref GlobalEnv P1) {} // 0x00000001810D3640-0x00000001810D4820
		public void __Gen_Wrap_581(ref UnitPreviewRenderJob P0, IntPtr P1) {} // 0x00000001810D4820-0x00000001810D5420
		public void __Gen_Wrap_582(ref UnitPreviewRenderJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001810D5420-0x00000001810D63F0
		public JobHandle __Gen_Wrap_583(ref UnitPreviewRenderJob P0, JobHandle P1, int P2) => default; // 0x00000001810D63F0-0x00000001810D73A0
		public void __Gen_Wrap_584(ref UnitRendererQueryJob P0) {} // 0x00000001810D73A0-0x00000001810D7F60
		public void __Gen_Wrap_585(ref UnitRendererQueryJob P0, ref EntityQueryV2.QueryResultDefer P1, ref EntityQueryV2.QueryResultDefer P2, ref EntityQueryV2.QueryResultDefer P3, bool P4) {} // 0x00000001810D7F60-0x00000001810D9320
		public void __Gen_Wrap_586(ref UpdateUnitRendererTRSJob P0, int P1) {} // 0x00000001810D9320-0x00000001810D9ED0
		public void __Gen_Wrap_587(ref UpdateUnitRendererTRSJob P0, int P1, int P2) {} // 0x00000001810D9ED0-0x00000001810DAA80
		public void __Gen_Wrap_588(ref UpdateUnitRendererTRSJob P0, IntPtr P1) {} // 0x00000001810DAA80-0x00000001810DB660
		public void __Gen_Wrap_589(ref UpdateUnitRendererTRSJob P0, ref EntityQueryV2.QueryResultDefer P1) {} // 0x00000001810DB660-0x00000001810DC610
		public JobHandle __Gen_Wrap_590(ref UpdateUnitRendererTRSJob P0, JobHandle P1, int P2) => default; // 0x00000001810DC610-0x00000001810DD5B0
		public void __Gen_Wrap_591(ref WireCollectJob P0, int P1) {} // 0x00000001810DD5B0-0x00000001810DE270
		public void __Gen_Wrap_592(ref WireCollectJob P0) {} // 0x00000001810DE270-0x00000001810DEF20
		public void __Gen_Wrap_593(ref WireCollectJob P0, ref GlobalEnv P1) {} // 0x00000001810DEF20-0x00000001810E01D0
		public void __Gen_Wrap_594(ref WireCollectJob P0, IntPtr P1) {} // 0x00000001810E01D0-0x00000001810E0ED0
		public void __Gen_Wrap_595(ref WireRenderJob P0, Entity P1, WireRendererInfo P2) {} // 0x00000001810E0ED0-0x00000001810E1E90
		public void __Gen_Wrap_596(ref WireRenderJob P0, int P1) {} // 0x00000001810E1E90-0x00000001810E2A70
		public void __Gen_Wrap_597(ref WireRenderJob P0, int P1, int P2) {} // 0x00000001810E2A70-0x00000001810E3660
		public bool __Gen_Wrap_598(ref Beyond.Gameplay.Factory.FPtrNativeCurve P0) => default; // 0x00000001810E3660-0x00000001810E4230
		public NativeArray<float> __Gen_Wrap_599(ref Beyond.Gameplay.Factory.FPtrNativeCurve P0, object P1, int P2) => default; // 0x00000001810E4230-0x00000001810E5230
		public float __Gen_Wrap_600(ref Beyond.Gameplay.Factory.FPtrNativeCurve P0, float P1) => default; // 0x00000001810E5230-0x00000001810E5E20
		public int __Gen_Wrap_601(ref PerDrawPassConfig P0) => default; // 0x00000001810E5E20-0x00000001810E6A00
		public HGShaderLightMode __Gen_Wrap_602(ref PerDrawPassConfig P0, PerDrawLightMode P1) => default; // 0x00000001810E6A00-0x00000001810E75F0
		public void __Gen_Wrap_603(ref PerDrawPassConfig P0, Entity P1, ref uint P2) {} // 0x00000001810E75F0-0x00000001810E83B0
		public void __Gen_Wrap_604(ref PerDrawPassConfig P0, HGFactoryRendererBinderComponent P1, ref uint P2) {} // 0x00000001810E83B0-0x00000001810E9170
		public int __Gen_Wrap_605() => default; // 0x00000001810E9170-0x00000001810E9340
		public void __Gen_Wrap_606(ref PerDrawConfig P0, UnityEngine.Color P1) {} // 0x00000001810E9340-0x00000001810EA2A0
		public void __Gen_Wrap_607(ref PerDrawConfig P0, float4 P1) {} // 0x00000001810EA2A0-0x00000001810EB200
		public void __Gen_Wrap_608(ref PerDrawConfig P0, float P1) {} // 0x00000001810EB200-0x00000001810EBE20
		public void __Gen_Wrap_609(ref PerDrawConfig P0, HGFactoryRendererBinderComponent P1) {} // 0x00000001810EBE20-0x00000001810ECDE0
		public bool __Gen_Wrap_610(float P0, float P1, out float P2, float P3, float P4) {
			P2 = default;
			return default;
		} // 0x00000001810ECDE0-0x00000001810ED0E0
		public bool __Gen_Wrap_611(ref IProcessor P0, float P1, float P2) => default; // 0x00000001810ED0E0-0x00000001810EDB30
		public void __Gen_Wrap_612(ref GlobalEnv P0, ref InteractFacCollectJob.BuildingInfo P1, ref InteractFacCollectJob.BuildingInfo P2) {} // 0x00000001810EDB30-0x00000001810EEF70
		public void __Gen_Wrap_613(ref GlobalEnv P0, ref InteractFacCollectJob.LogisticInfo P1, ref InteractFacCollectJob.LogisticInfo P2) {} // 0x00000001810EEF70-0x00000001810F0320
		public JobHandle __Gen_Wrap_614(object P0, ref EntityManager P1, ref GlobalEnv P2, ref JobHandle P3, out JobHandle P4) {
			P4 = default;
			return default;
		} // 0x00000001810F0320-0x00000001810F1AF0
		public bool __Gen_Wrap_615(ref FFactoryStateColorConfig P0, FacBuildingState P1, out UnityEngine.Color P2) {
			P2 = default;
			return default;
		} // 0x00000001810F1AF0-0x00000001810F2920
		public void __Gen_Wrap_616(object P0, ref GlobalEnv P1) {} // 0x00000001810F2920-0x00000001810F3810
		public bool __Gen_Wrap_617(object P0, int P1, out UnityEngine.Color P2) {
			P2 = default;
			return default;
		} // 0x00000001810F3810-0x00000001810F4170
		public bool __Gen_Wrap_618(object P0, object P1, object P2, out int P3) {
			P3 = default;
			return default;
		} // 0x00000001810F4170-0x00000001810F4660
		public FactoryBaseColorLutConfig __Gen_Wrap_619(object P0) => default; // 0x00000001810F4660-0x00000001810F4F90
		public bool __Gen_Wrap_620(ref FFactoryStateColorConfig P0, FacBuildingState P1, out string P2) {
			P2 = default;
			return default;
		} // 0x00000001810F4F90-0x00000001810F5E60
		public bool __Gen_Wrap_621(ref FFactoryStateColorConfig P0, LogicEntityState P1, LogicEntityType P2, out PerDrawConfigArray P3) {
			P3 = default;
			return default;
		} // 0x00000001810F5E60-0x00000001810F6D00
		public void __Gen_Wrap_622(ref FFactoryStateColorConfig.LogicStateConfig P0) {} // 0x00000001810F6D00-0x00000001810F78D0
		public void __Gen_Wrap_623(ref FSMParameterSet P0, byte P1, float P2) {} // 0x00000001810F78D0-0x00000001810F8510
		public void __Gen_Wrap_624(ref FSMParameterSet P0, byte P1, int P2) {} // 0x00000001810F8510-0x00000001810F9140
		public void __Gen_Wrap_625(ref FSMParameterSet P0, byte P1, bool P2) {} // 0x00000001810F9140-0x00000001810F9D70
		public void __Gen_Wrap_626(ref FSMParameterSet P0) {} // 0x00000001810F9D70-0x00000001810FA950
		public void __Gen_Wrap_627(ref FSMParameterSet P0, in VATFSMDefinition P1) {} // 0x00000001810FA950-0x00000001810FB930
		public void __Gen_Wrap_628(ref FSMState P0) {} // 0x00000001810FB930-0x00000001810FC510
		public void __Gen_Wrap_629(ref VATFSMStateFragment P0, uint P1, uint P2) {} // 0x00000001810FC510-0x00000001810FD1E0
		public void __Gen_Wrap_630(ref FSMTransition P0) {} // 0x00000001810FD1E0-0x00000001810FDDA0
		public void __Gen_Wrap_631(ref VATFSMStateFragment P0, in FSMStateDefinition P1) {} // 0x00000001810FDDA0-0x00000001810FEE10
		public void __Gen_Wrap_632(ref VATFSMStateFragment P0) {} // 0x00000001810FEE10-0x00000001810FFA60
		public void __Gen_Wrap_633(ref VATFSMStateFragment P0, in FSMTransitionDefinition P1, in FSMStateDefinition P2) {} // 0x00000001810FFA60-0x0000000181100AE0
		public float __Gen_Wrap_634(ref FSMState P0) => default; // 0x0000000181100AE0-0x00000001811016D0
		public void __Gen_Wrap_635(ref FSMState P0, float P1, float P2) {} // 0x00000001811016D0-0x00000001811022E0
		public void __Gen_Wrap_636(ref FSMState P0, float P1) {} // 0x00000001811022E0-0x0000000181102F00
		public float __Gen_Wrap_637(ref FSMTransition P0) => default; // 0x0000000181102F00-0x0000000181103AD0
		public void __Gen_Wrap_638(ref FSMTransition P0, float P1, float P2) {} // 0x0000000181103AD0-0x00000001811046C0
		public float __Gen_Wrap_639(ref FSMParameterSet P0, byte P1) => default; // 0x00000001811046C0-0x00000001811052B0
		public int __Gen_Wrap_640(ref FSMParameterSet P0, byte P1) => default; // 0x00000001811052B0-0x0000000181105EA0
		public bool __Gen_Wrap_641(ref FSMParameterSet P0, byte P1) => default; // 0x0000000181105EA0-0x0000000181106A90
		public void __Gen_Wrap_642(ref FSMParameterSet P0, byte P1) {} // 0x0000000181106A90-0x0000000181107690
		public void __Gen_Wrap_643(ref FSMParameterSet P0, byte P1, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P2, float P3) {} // 0x0000000181107690-0x0000000181108300
		public float __Gen_Wrap_644(ref FSMParameterSet P0, byte P1, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P2) => default; // 0x0000000181108300-0x0000000181108F00
		public void __Gen_Wrap_645(ref VATFSMSetParamRequestHandlerJob P0, int P1) {} // 0x0000000181108F00-0x0000000181109AD0
		public bool __Gen_Wrap_646(in FSMCondition P0, in FSMParameterSet P1, in FixedList128Bytes<FSMParameterDefinition> P2) => default; // 0x0000000181109AD0-0x000000018110A7F0
		public bool __Gen_Wrap_647(ref VATFSMStateFragment P0, ref VATFSMDefinition P1, out int P2) {
			P2 = default;
			return default;
		} // 0x000000018110A7F0-0x000000018110B8C0
		public void __Gen_Wrap_648(ref FSMParameterSet P0, in FSMTransitionDefinition P1, in FixedList128Bytes<FSMParameterDefinition> P2) {} // 0x000000018110B8C0-0x000000018110C8E0
		public bool __Gen_Wrap_649(ref VATFSMStateUpdateJob P0, ref VATFSMStateFragment P1, ref VATFSMDefinition P2) => default; // 0x000000018110C8E0-0x000000018110DDE0
		public void __Gen_Wrap_650(ref VATFSMStateUpdateJob P0, Entity P1, ref FSMState P2, ref VATFSMDefinition P3) {} // 0x000000018110DDE0-0x000000018110F4B0
		public void __Gen_Wrap_651(ref VATFSMStateUpdateJob P0, ref VATFSMStateFragment P1, ref VATFSMDefinition P2) {} // 0x000000018110F4B0-0x00000001811109A0
		public void __Gen_Wrap_652(ref VATFSMStateUpdateJob P0, int P1) {} // 0x00000001811109A0-0x0000000181111580
		public void __Gen_Wrap_653(ref VATFSMStateUpdateJob P0) {} // 0x0000000181111580-0x0000000181112150
		public void __Gen_Wrap_654(ref VATFSMStateUpdateJob P0, IntPtr P1) {} // 0x0000000181112150-0x0000000181112D70
		public void __Gen_Wrap_655(object P0, ref EntityManager P1) {} // 0x0000000181112D70-0x0000000181113A20
		public JobHandle __Gen_Wrap_656(object P0, ref EntityManager P1, ref GlobalEnv P2, JobHandle P3) => default; // 0x0000000181113A20-0x0000000181115170
		public string __Gen_Wrap_657(object P0) => default; // 0x0000000181115170-0x0000000181115AA0
		public uint __Gen_Wrap_658(ref VATFSMDefinitionContainer P0) => default; // 0x0000000181115AA0-0x0000000181116660
		public Span<VATFSMDefinition> __Gen_Wrap_659(ref VATFSMDefinitionContainer P0) => default; // 0x0000000181116660-0x0000000181117540
		public ref VATFSMDefinition __Gen_Wrap_660(ref VATFSMDefinitionContainer P0, uint P1) => ref _refReturnTypeFor__Gen_Wrap_660; // 0x0000000181117540-0x0000000181118410
		private ref VATFSMDefinition _refReturnTypeFor__Gen_Wrap_660; // Dummy field
		public ref VATFSMDefinition __Gen_Wrap_661(ref VATFSMDefinitionContainer P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_661; // 0x0000000181118410-0x00000001811192E0
		private ref VATFSMDefinition _refReturnTypeFor__Gen_Wrap_661; // Dummy field
		public void __Gen_Wrap_662(int P0, object P1) {} // 0x00000001811192E0-0x00000001811195D0
		public void __Gen_Wrap_663(Entity P0, ref EntityManager P1) {} // 0x00000001811195D0-0x000000018111A540
		public string __Gen_Wrap_664(uint P0, byte P1) => default; // 0x000000018111A540-0x000000018111ADE0
		public void __Gen_Wrap_665(JobHandle P0) {} // 0x000000018111ADE0-0x000000018111B380
		public bool __Gen_Wrap_666(Entity P0) => default; // 0x000000018111B380-0x000000018111B930
		public bool __Gen_Wrap_667(ref EntityManager P0, ref Entity P1) => default; // 0x000000018111B930-0x000000018111C8E0
		public bool __Gen_Wrap_668(Entity P0, ref EntityManager P1) => default; // 0x000000018111C8E0-0x000000018111D860
		public bool __Gen_Wrap_669(Entity P0, ref EntityManager P1, Visibility.Type P2) => default; // 0x000000018111D860-0x000000018111E4A0
		public bool __Gen_Wrap_670(Entity P0, Visibility.Type P1) => default; // 0x000000018111E4A0-0x000000018111EA50
		public bool __Gen_Wrap_671(Entity P0, ref EntityManager P1, bool P2, Visibility.EFlag P3, Visibility.Type P4, object P5) => default; // 0x000000018111EA50-0x000000018111F7D0
		public void __Gen_Wrap_672(Entity P0, ref EntityManager P1, bool P2, Visibility.EFlag P3, Visibility.Type P4, object P5) {} // 0x000000018111F7D0-0x0000000181120540
		public bool __Gen_Wrap_673(Entity P0, bool P1, Visibility.EFlag P2, Visibility.Type P3, ref EntityCommandBuffer P4) => default; // 0x0000000181120540-0x00000001811212A0
		public void __Gen_Wrap_674(Entity P0, bool P1) {} // 0x00000001811212A0-0x0000000181121850
		public void __Gen_Wrap_675(Entity P0, ref EntityCommandBufferV2.EntityCommandBufferParallelWriter P1) {} // 0x0000000181121850-0x00000001811227B0
		public bool __Gen_Wrap_676(Entity P0, ref EntityManager P1, FixedString32Bytes P2, out float3 P3, out quaternion P4, out Entity P5) {
			P3 = default;
			P4 = default;
			P5 = default;
			return default;
		} // 0x00000001811227B0-0x0000000181123C10
		public bool __Gen_Wrap_677(Entity P0, ref EntityManager P1, FixedString32Bytes P2, out float3 P3, out quaternion P4) {
			P3 = default;
			P4 = default;
			return default;
		} // 0x0000000181123C10-0x0000000181125020
		public bool __Gen_Wrap_678(Entity P0, object P1, out float3 P2, out quaternion P3) {
			P2 = default;
			P3 = default;
			return default;
		} // 0x0000000181125020-0x0000000181125F10
		public ref ChapterFragment __Gen_Wrap_679(EntityManager P0, int P1, out bool P2, out Entity P3) {
			P2 = default;
			P3 = default;
			return default;
		} // 0x0000000181125F10-0x0000000181126CF0
		private ref ChapterFragment _refReturnTypeFor__Gen_Wrap_679; // Dummy field
		public IntPtr __Gen_Wrap_680(EntityManager P0) => default; // 0x0000000181126CF0-0x00000001811272A0
		public bool __Gen_Wrap_681(EntityManager P0) => default; // 0x00000001811272A0-0x0000000181127850
		public ref GlobalEnv __Gen_Wrap_682(EntityManager P0) => ref _refReturnTypeFor__Gen_Wrap_682; // 0x0000000181127850-0x0000000181128430
		private ref GlobalEnv _refReturnTypeFor__Gen_Wrap_682; // Dummy field
		public bool __Gen_Wrap_683(ref GlobalEnv P0, out InteractFacCollectJob.BuildingInfo P1) {
			P1 = default;
			return default;
		} // 0x0000000181128430-0x0000000181129410
		public bool __Gen_Wrap_684(ref GlobalEnv P0, out InteractFacCollectJob.LogisticInfo P1) {
			P1 = default;
			return default;
		} // 0x0000000181129410-0x000000018112A3D0
		public LinearAllocator.Allocation __Gen_Wrap_685(object P0, int P1) => default; // 0x000000018112A3D0-0x000000018112ACD0
		public void __Gen_Wrap_686(object P0, int P1) {} // 0x00000001810502C0-0x0000000181050590
		public LinearAllocator.Allocation __Gen_Wrap_687(object P0, int P1, int P2) => default; // 0x000000018112ACD0-0x000000018112B5F0
		public void __Gen_Wrap_688(ref LinearAllocatorUnmanaged P0, int P1, Unity.Collections.Allocator P2) {} // 0x000000018112B5F0-0x000000018112C230
		public uint __Gen_Wrap_689(object P0) => default; // 0x000000018112C230-0x000000018112C4F0
		public void __Gen_Wrap_690(object P0, uint P1, out int P2, out int P3) {
			P2 = default;
			P3 = default;
		} // 0x000000018112C4F0-0x000000018112C830
		public IntPtr __Gen_Wrap_691(ref GlobalEnv P0) => default; // 0x000000018112C830-0x000000018112D8E0
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 49126
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001857FD8DC-0x00000001857FD970
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 49127
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000185803258-0x00000001858032BC
		public static bool IsPatched(int id) => default; // 0x00000001824FD680-0x00000001824FD6F0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000185803114-0x00000001858031E0
		public object CreateWrapper(int id) => default; // 0x00000001858031E0-0x0000000185803258
		public object InitWrapperArray(int len) => default; // 0x00000001858032BC-0x00000001858033E4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000185803070-0x0000000185803114
	}

	public enum IDMAP0 // TypeDefIndex: 49128
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
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-GetStateIndex0 = 357,
		Beyond-Gameplay-Factory-GlobalEnv-get_animatorAudioQueueWriter0 = 358,
		Beyond-Gameplay-Factory-GlobalEnv-GetAudioVATDataAt0 = 359,
		Beyond-Gameplay-Factory-GlobalEnv-GetAudioVATDataLength0 = 360,
		Beyond-Gameplay-Factory-GlobalEnv-ClearAudioVATData0 = 361,
		Beyond-Gameplay-Factory-GlobalEnv-ResetFlags0 = 362,
		Beyond-Gameplay-Factory-GlobalEnv-__AOT_FOR_FIX__0 = 363,
		Beyond-Gameplay-Factory-HealthPoleFragment-__AOT_FOR_FIX__0 = 364,
		Beyond-Gameplay-Factory-InventoryFragment-__AOT_FOR_FIX__0 = 365,
		Beyond-Gameplay-Factory-LiquidPurifierFragment-__AOT_FOR_FIX__0 = 366,
		Beyond-Gameplay-Factory-LogisticEffectFragment-__AOT_FOR_FIX__0 = 367,
		Beyond-Gameplay-Factory-LogisticEntityBindFragment-EnqueueCargoEntityImpl0 = 368,
		Beyond-Gameplay-Factory-LogisticEntityBindFragment-DequeueCargoEntityImpl0 = 369,
		Beyond-Gameplay-Factory-LogisticEntityBindFragment-__AOT_FOR_FIX__0 = 370,
		Beyond-Gameplay-Factory-MapGridRendererFragment-__AOT_FOR_FIX__0 = 371,
		Beyond-Gameplay-Factory-OutputFragment-Clean0 = 372,
		Beyond-Gameplay-Factory-OutputFragment-GetColor0 = 373,
		Beyond-Gameplay-Factory-OutputFragment-SetColor0 = 374,
		Beyond-Gameplay-Factory-OutputFragment-SetColor1 = 375,
		Beyond-Gameplay-Factory-OutputFragment-SetAtlasRect0 = 376,
		Beyond-Gameplay-Factory-OutputFragment-SetAtlasRect1 = 377,
		Beyond-Gameplay-Factory-OutputFragment-GetAtlasRect0 = 378,
		Beyond-Gameplay-Factory-OutputFragment-GetEnableLiquidIcon0 = 379,
		Beyond-Gameplay-Factory-OutputFragment-SetEnableLiquidIcon0 = 380,
		Beyond-Gameplay-Factory-OutputFragment-GetLiquidIconUV0 = 381,
		Beyond-Gameplay-Factory-OutputFragment-SetLiquidIconUV0 = 382,
		Beyond-Gameplay-Factory-OutputFragment-get_hasOutput0 = 383,
		Beyond-Gameplay-Factory-OutputFragment-__AOT_FOR_FIX__0 = 384,
		Beyond-Gameplay-Factory-OutputUIRendererFragment-__AOT_FOR_FIX__0 = 385,
		Beyond-Gameplay-Factory-PedestalLightFlashFragment-__AOT_FOR_FIX__0 = 386,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-IsValid0 = 387,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetIntensity0 = 388,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashIntensity0 = 389,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlash0 = 390,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashDuration0 = 391,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetColor0 = 392,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashColor0 = 393,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetIntensity0 = 394,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashIntensity0 = 395,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlash0 = 396,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashDuration0 = 397,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetColor0 = 398,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashColor0 = 399,
		Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-__AOT_FOR_FIX__0 = 400,
		Beyond-Gameplay-Factory-PipeEffectFragment-__AOT_FOR_FIX__0 = 401,
		Beyond-Gameplay-Factory-PipeFragment-SetInflection0 = 402,
		Beyond-Gameplay-Factory-PipeFragment-Bend0 = 405,
		Beyond-Gameplay-Factory-PipeFragment-GetCornerIndexList0 = 406,
		Beyond-Gameplay-Factory-PipeFragment-Sample0 = 407,
		Beyond-Gameplay-Factory-PipeFragment-IsInRect0 = 408,
		Beyond-Gameplay-Factory-PipeFragment-GetInRectUnitIndex0 = 409,
		Beyond-Gameplay-Factory-PipeFragment-FillRectTargets0 = 410,
		Beyond-Gameplay-Factory-PipeFragment-__AOT_FOR_FIX__0 = 411,
		Beyond-Gameplay-Factory-PipeHolderFragment-__AOT_FOR_FIX__0 = 412,
		Beyond-Gameplay-Factory-PipeLogisticsUnitFragment-__AOT_FOR_FIX__0 = 413,
		Beyond-Gameplay-Factory-PipeComRenderFragment-__AOT_FOR_FIX__0 = 414,
		Beyond-Gameplay-Factory-PipeRenderFragment-__AOT_FOR_FIX__0 = 415,
		Beyond-Gameplay-Factory-PipeTrackRenderFragment-__AOT_FOR_FIX__0 = 416,
		Beyond-Gameplay-Factory-ComplexPortFragment-BindComponentId0 = 417,
		Beyond-Gameplay-Factory-ComplexPortFragment-BlockPortsWithComponentId0 = 418,
		Beyond-Gameplay-Factory-ComplexPortFragment-BlockPorts0 = 419,
		Beyond-Gameplay-Factory-ComplexPortFragment-FollowUnit0 = 420,
		Beyond-Gameplay-Factory-ComplexPortFragment-AnyPortBlocked0 = 421,
		Beyond-Gameplay-Factory-ComplexPortFragment-AnyPortConnected0 = 422,
		Beyond-Gameplay-Factory-ComplexPortFragment-Equals0 = 423,
		Beyond-Gameplay-Factory-PortData-Equals0 = 424,
		Beyond-Gameplay-Factory-ComplexPortFragment-Equals1 = 425,
		Beyond-Gameplay-Factory-ComplexPortFragment-GetHashCode0 = 426,
		Beyond-Gameplay-Factory-ComplexPortFragment-op_Equality0 = 427,
		Beyond-Gameplay-Factory-ComplexPortFragment-op_Inequality0 = 428,
		Beyond-Gameplay-Factory-ComplexPortFragment-ToString0 = 429,
		Beyond-Gameplay-Factory-PortData-ToString0 = 430,
		Beyond-Gameplay-Factory-ComplexPortFragment-__AOT_FOR_FIX__0 = 431,
		Beyond-Gameplay-Factory-PortData-TRS0 = 432,
		Beyond-Gameplay-Factory-PortData-Equals1 = 433,
		Beyond-Gameplay-Factory-PortData-GetHashCode0 = 434,
		Beyond-Gameplay-Factory-PortData-op_Equality0 = 435,
		Beyond-Gameplay-Factory-PortData-op_Inequality0 = 436,
		Beyond-Gameplay-Factory-PortPreviewUIRendererFragment-__AOT_FOR_FIX__0 = 437,
		Beyond-Gameplay-Factory-PortStatusUIFragment-__AOT_FOR_FIX__0 = 438,
		Beyond-Gameplay-Factory-PowerPoleFragment-__AOT_FOR_FIX__0 = 439,
		Beyond-Gameplay-Factory-ProducerFragment-__AOT_FOR_FIX__0 = 440,
		Beyond-Gameplay-Factory-SharedDataFragment-GetExtData0 = 441,
		Beyond-Gameplay-Factory-SharedDataFragment-DestroyData0 = 442,
		Beyond-Gameplay-Factory-SharedDataFragment-__AOT_FOR_FIX__0 = 443,
		Beyond-Gameplay-Factory-SocialFragment-Create0 = 444,
		Beyond-Gameplay-Factory-SocialFragment-IsHighLiked0 = 445,
		Beyond-Gameplay-Factory-SocialFragment-IsLiked0 = 446,
		Beyond-Gameplay-Factory-SocialFragment-__AOT_FOR_FIX__0 = 447,
		Beyond-Gameplay-Factory-SignData-GetText0 = 448,
		Beyond-Gameplay-Factory-SignData-GetCustomPerDrawData0 = 449,
		Beyond-Gameplay-Factory-SignData-SetSignBuildingIcon0 = 450,
		Beyond-Gameplay-Factory-SignData-SetSignBuildingIconWithRenderEntity0 = 451,
		Beyond-Gameplay-Factory-LocalTransform-FromMatrix0 = 452,
		Beyond-Gameplay-Factory-LocalTransform-FromMatrixSafe0 = 453,
		Beyond-Gameplay-Factory-LocalTransform-FromPositionRotation0 = 454,
		Beyond-Gameplay-Factory-LocalTransform-FromPositionRotationScale0 = 455,
		Beyond-Gameplay-Factory-LocalTransform-FromPosition0 = 456,
		Beyond-Gameplay-Factory-LocalTransform-FromPosition1 = 457,
		Beyond-Gameplay-Factory-LocalTransform-FromRotation0 = 458,
		Beyond-Gameplay-Factory-LocalTransform-FromScale0 = 459,
		Beyond-Gameplay-Factory-LocalTransform-ToString0 = 460,
		Beyond-Gameplay-Factory-LocalTransform-Right0 = 461,
		Beyond-Gameplay-Factory-LocalTransform-TransformDirection0 = 462,
		Beyond-Gameplay-Factory-LocalTransform-Up0 = 463,
		Beyond-Gameplay-Factory-LocalTransform-Forward0 = 464,
		Beyond-Gameplay-Factory-LocalTransform-TransformPoint0 = 465,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformPoint0 = 466,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformDirection0 = 467,
		Beyond-Gameplay-Factory-LocalTransform-TransformRotation0 = 468,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformRotation0 = 469,
		Beyond-Gameplay-Factory-LocalTransform-TransformScale0 = 470,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformScale0 = 471,
		Beyond-Gameplay-Factory-LocalTransform-TransformTransform0 = 472,
		Beyond-Gameplay-Factory-LocalTransform-InverseTransformTransform0 = 473,
		Beyond-Gameplay-Factory-LocalTransform-Inverse0 = 474,
		Beyond-Gameplay-Factory-LocalTransform-ToInverseMatrix0 = 475,
		Beyond-Gameplay-Factory-LocalTransform-WithPosition0 = 476,
		Beyond-Gameplay-Factory-LocalTransform-WithPosition1 = 477,
		Beyond-Gameplay-Factory-LocalTransform-WithRotation0 = 478,
		Beyond-Gameplay-Factory-LocalTransform-WithScale0 = 479,
		Beyond-Gameplay-Factory-LocalTransform-Translate0 = 480,
		Beyond-Gameplay-Factory-LocalTransform-ApplyScale0 = 481,
		Beyond-Gameplay-Factory-LocalTransform-Rotate0 = 482,
		Beyond-Gameplay-Factory-LocalTransform-RotateX0 = 483,
		Beyond-Gameplay-Factory-LocalTransform-RotateY0 = 484,
		Beyond-Gameplay-Factory-LocalTransform-RotateZ0 = 485,
		Beyond-Gameplay-Factory-LocalTransform-Equals0 = 486,
		Beyond-Gameplay-Factory-LocalTransform-__AOT_FOR_FIX__0 = 487,
		Beyond-Gameplay-Factory-Root-__AOT_FOR_FIX__0 = 488,
		Beyond-Gameplay-Factory-Parent-__AOT_FOR_FIX__0 = 489,
		Beyond-Gameplay-Factory-Child-__AOT_FOR_FIX__0 = 490,
		Beyond-Gameplay-Factory-LocalToWorld-SetValue0 = 491,
		Beyond-Gameplay-Factory-LocalToWorld-get_right0 = 492,
		Beyond-Gameplay-Factory-LocalToWorld-get_up0 = 493,
		Beyond-Gameplay-Factory-LocalToWorld-get_forward0 = 494,
		Beyond-Gameplay-Factory-LocalToWorld-get_position0 = 495,
		Beyond-Gameplay-Factory-LocalToWorld-get_prePosition0 = 496,
		Beyond-Gameplay-Factory-LocalToWorld-__AOT_FOR_FIX__0 = 497,
		Beyond-Gameplay-Factory-UdPipeFragment-__AOT_FOR_FIX__0 = 498,
		Beyond-Gameplay-Factory-UnitConfigFragment-__AOT_FOR_FIX__0 = 499,
		Beyond-Gameplay-Factory-FactoryUnitExtendConfig-ToString0 = 500,
		Beyond-Gameplay-Factory-UnitInteractFragment-__AOT_FOR_FIX__0 = 503,
		Beyond-Gameplay-Factory-UnitRenderFragment-__AOT_FOR_FIX__0 = 504,
		Beyond-Gameplay-Factory-RenderLookAtFragment-__AOT_FOR_FIX__0 = 505,
		Beyond-Gameplay-Factory-ChapterTagFragment-__AOT_FOR_FIX__0 = 506,
		Beyond-Gameplay-Factory-UnitStatusFragment-__AOT_FOR_FIX__0 = 507,
		Beyond-Gameplay-Factory-UnitOverrideStatusFragment-__AOT_FOR_FIX__0 = 508,
		Beyond-Gameplay-Factory-UnitStatusEffectFragment-SetEffects0 = 509,
		Beyond-Gameplay-Factory-UnitStatusEffectFragment-GetEffect0 = 510,
		Beyond-Gameplay-Factory-UnitStatusEffectFragment-__AOT_FOR_FIX__0 = 511,
		Beyond-Gameplay-Factory-UnitStatusUIRendererFragment-__AOT_FOR_FIX__0 = 512,
		Beyond-Gameplay-Factory-UnitTransFragment-InBound0 = 513,
		Beyond-Gameplay-Factory-UnitTransFragment-__AOT_FOR_FIX__0 = 514,
		Beyond-Gameplay-Factory-ValveFragment-__AOT_FOR_FIX__0 = 515,
		Beyond-Gameplay-Factory-BoxValve-__AOT_FOR_FIX__0 = 516,
		Beyond-Gameplay-Factory-FluidValve-__AOT_FOR_FIX__0 = 517,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-ContainsNodeId0 = 518,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetExtData0 = 519,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-RemoveEntityFromSlot0 = 520,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-FindEmptySlotIdx0 = 521,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSuitableSlotIdx0 = 522,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-SetSlotId0 = 523,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSlotIds0 = 524,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-AppendSlotInfo0 = 525,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-ClearSlotInfo0 = 526,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-DiffSlotInfo0 = 527,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetAllPendingEntitiesInSlot0 = 528,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetPendingEntityCountInSlot0 = 529,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSlotInfo0 = 530,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-CreateDefault0 = 531,
		Beyond-Gameplay-Factory-BlueprintSlotInfo-ToString0 = 532,
		Beyond-Gameplay-Factory-ConveyorRendererInfo-ToString0 = 533,
		Beyond-Gameplay-Factory-UnitId-Equals0 = 534,
		Beyond-Gameplay-Factory-UnitId-Equals1 = 535,
		Beyond-Gameplay-Factory-UnitId-GetHashCode0 = 536,
		Beyond-Gameplay-Factory-Visibility-get_isVisible0 = 537,
		Beyond-Gameplay-Factory-Visibility-GetVisible0 = 538,
		Beyond-Gameplay-Factory-Visibility-SetVisible0 = 539,
		Beyond-Gameplay-Factory-WireRendererFragment-__AOT_FOR_FIX__0 = 540,
		Beyond-Gameplay-Factory-GlobalSharedData-Reset0 = 541,
		Beyond-Gameplay-Factory-GlobalSharedData-MapGridRendererData-Reset0 = 542,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-ResetOverride0 = 543,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrCullDis0 = 544,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrUI0 = 545,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrBuildingName0 = 546,
		Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrWireCullDis0 = 547,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-ResetOverride0 = 548,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-Disable0 = 549,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_nearByCheck0 = 550,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_portPreviewCheckDistance0 = 551,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_pedestalFlashCheckDistance0 = 552,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_logisticEffectCheckDistance0 = 553,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_unitRendererCheckDistance0 = 554,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_l2wCheckDistance0 = 555,
		Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_additiveEffectCheckDistance0 = 556,
		Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-Disable0 = 557,
		Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-ResetOverride0 = 558,
		Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-get_buildingNameShadowDisable0 = 559,
		Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetBuildCurve0 = 560,
		Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetRepairCurve00 = 561,
		Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetRepairCurve10 = 562,
		Beyond-Gameplay-Factory-GlobalSharedData-MapGridRendererData-UpdateGrid0 = 563,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Initialize0 = 564,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Dispose0 = 565,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-EnsureValue0 = 566,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-TryGetValue1 = 567,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-TryGetValue0 = 568,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_CreateWithTable0 = 569,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_ParseGlobalPortIdx0 = 571,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Add1 = 573,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Add0 = 574,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-EnsureValue1 = 575,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-_CreateWithTable1 = 576,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-ContainsKey0 = 577,
		Beyond-Gameplay-Factory-GlobalSharedData-UnitPortConfigDB-Clear0 = 578,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-Apply0 = 579,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-_GetKey0 = 580,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-ApplyPass0 = 581,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-Parse0 = 582,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-set_Item0 = 583,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-set_Item0 = 584,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-GetPerDrawPassConfig0 = 585,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-get_Item0 = 586,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-GetPerDrawConfig0 = 587,
		Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-get_Item0 = 588,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-Disable0 = 589,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-ResetOverride0 = 590,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_crossCollectFrameInterval0 = 591,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_cullingSystemInterval0 = 592,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_unitPreviewSystemInterval0 = 593,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_portPreviewRenderSystemInterval0 = 594,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_buildingStateSystemInterval0 = 595,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_portBlockSystemInterval0 = 596,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_outputUISystemInterval0 = 597,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_buildingNameSystemInterval0 = 598,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_adjustGroundSystemInterval0 = 599,
		Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_gridSystemInterval0 = 600,
		Beyond-Gameplay-Factory-GlobalSharedData-UIEffectPathConfig-Parse0 = 601,
		Beyond-Gameplay-Factory-GlobalSharedData-UIEffectPathConfig-Get0 = 602,
		Beyond-Gameplay-Factory-BaseProcessor-Initialize0 = 603,
		Beyond-Gameplay-Factory-BaseProcessor-PreExecute0 = 604,
		Beyond-Gameplay-Factory-BaseProcessor-Execute0 = 605,
		Beyond-Gameplay-Factory-BaseProcessor-LateExecute0 = 606,
		Beyond-Gameplay-Factory-BaseProcessor-CleanUp0 = 607,
		Beyond-Gameplay-Factory-BaseProcessor-TearDown0 = 608,
		Beyond-Gameplay-Factory-BaseProcessor-StructuralSync0 = 609,
		Beyond-Gameplay-Factory-BaseProcessor-ScheduleNoneDependencies0 = 610,
		Beyond-Gameplay-Factory-BaseProcessor-InLowFrameMode0 = 611,
		Beyond-Gameplay-Factory-BaseProcessor-SpecialEntityExisted0 = 612,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetApplyRenderPointer0 = 613,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetFacRegionValid0 = 614,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetQueryStateIconPathFuncPtr0 = 615,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetLogicEntityWithPosAdapter0 = 616,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetQueryBuildingStatePointer0 = 617,
		Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetSetEntityFlashStatuePointer0 = 618,
		Beyond-Gameplay-Factory-AdditiveEffectJob-SetSharedExtData0 = 619,
		Beyond-Gameplay-Factory-AdditiveEffectJob-Execute1 = 620,
		Beyond-Gameplay-Factory-AdditiveEffectJob-Execute0 = 621,
		Beyond-Gameplay-Factory-AdditiveEffectJob-_OnStackEmpty0 = 622,
		Beyond-Gameplay-Factory-AdditiveEffectJob-_UpdateInternalStateLifeCycle0 = 623,
		Beyond-Gameplay-Factory-AdditiveEffectJob-_InitBuildState0 = 624,
		Beyond-Gameplay-Factory-AdditiveEffectJob-SetQueryResult0 = 625,
		Beyond-Gameplay-Factory-AdditiveEffectJob-ScheduleDefer0 = 626,
		Beyond-Gameplay-Factory-AdditiveEffectJob-ScheduleDefer1 = 627,
		Beyond-Gameplay-Factory-AdditiveEffectQueryJob-Execute0 = 628,
		Beyond-Gameplay-Factory-AdditiveEffectQueryJob-SetQueryResult0 = 629,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPNormalEffectExecute0 = 630,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPBuildEffectExecute0 = 631,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPBuildCutoffEffectExecute0 = 632,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-SetSharedExtData0 = 634,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-Execute1 = 635,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-Execute0 = 636,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BuildStateStart0 = 637,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ResetMaterial0 = 638,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BuildStateEnd0 = 639,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_Repair0Start0 = 640,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_Repair0End0 = 641,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-SetQueryResult0 = 642,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ScheduleDefer0 = 643,
		Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ScheduleDefer1 = 644,
		Beyond-Gameplay-Factory-AudioJobs-AudioDistanceAndCullingJob-Execute0 = 645,
		Beyond-Gameplay-Factory-AudioJobs-AudioGroupEmitterJob-Execute0 = 646,
		Beyond-Gameplay-Factory-AudioJobs-AudioGroupEmitterJob-SetSharedExtData0 = 647,
		Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-Execute0 = 648,
		Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-_DoCalculate0 = 649,
		Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-SetGlobalEnv0 = 650,
		Beyond-Gameplay-Factory-BatchArrowJob-_ExecutePort0 = 651,
		Beyond-Gameplay-Factory-BatchArrowJob-_BatchPortArrow0 = 652,
		Beyond-Gameplay-Factory-BatchArrowJob-_ExecutePreview0 = 653,
		Beyond-Gameplay-Factory-BatchArrowJob-Execute0 = 654,
		Beyond-Gameplay-Factory-BatchArrowJob-SetSharedExtData0 = 655,
		Beyond-Gameplay-Factory-BatchArrowJob-Execute1 = 656,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-Execute0 = 657,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-_CollectInsideConveyor0 = 658,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-_BatchPortInside0 = 659,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-SetSharedExtData0 = 660,
		Beyond-Gameplay-Factory-BatchInsideConveyorJob-Execute1 = 661,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-_ExecutePort0 = 662,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-_BatchPortArrow0 = 663,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-Execute0 = 664,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-Execute1 = 665,
		Beyond-Gameplay-Factory-BatchNormalArrowJob-SetSharedExtData0 = 666,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-Execute0 = 667,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-_ExecutePreview0 = 668,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-_BatchPortArrow0 = 669,
		Beyond-Gameplay-Factory-BatchPreviewArrowJob-SetSharedExtData0 = 670,
		Beyond-Gameplay-Factory-BufferSwapJob-Execute0 = 671,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-Execute0 = 672,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-_ApplyLiquidPerDraw0 = 673,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-Execute1 = 674,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-SetQueryResult0 = 675,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-ScheduleDefer0 = 676,
		Beyond-Gameplay-Factory-BuildingLiquidRenderJob-SetSharedExtData0 = 677,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute0 = 678,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-_Collect0 = 679,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute1 = 680,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute2 = 681,
		Beyond-Gameplay-Factory-BuildingStatePosCollectJob-SetSharedExtData0 = 682,
		Beyond-Gameplay-Factory-BuildingStateRendererJob-Execute0 = 683,
		Beyond-Gameplay-Factory-CargoCollectJob-Execute0 = 684,
		Beyond-Gameplay-Factory-CargoCollectJob-Execute1 = 685,
		Beyond-Gameplay-Factory-CargoCollectJob-SetGlobalEnvRef0 = 686,
		Beyond-Gameplay-Factory-CargoCollectJob-SetConveyorExtData0 = 687,
		Beyond-Gameplay-Factory-CargoCollectJob-SetSharedExtData0 = 688,
		Beyond-Gameplay-Factory-CargoPredictJob-Execute0 = 689,
		Beyond-Gameplay-Factory-CargoPredictJob-SetConveyorExtData0 = 690,
		Beyond-Gameplay-Factory-CargoPredictJob-SetSharedExtData0 = 691,
		Beyond-Gameplay-Factory-CargoPredictJob-SetQueryResult0 = 692,
		Beyond-Gameplay-Factory-CargoPredictJob-ScheduleDefer0 = 693,
		Beyond-Gameplay-Factory-CargoPredictQueryJob-Execute0 = 694,
		Beyond-Gameplay-Factory-CargoPredictQueryJob-SetQueryResult0 = 695,
		Beyond-Gameplay-Factory-CargoRenderJob-Execute0 = 696,
		Beyond-Gameplay-Factory-CargoRenderJob-SetRendererList0 = 697,
		Beyond-Gameplay-Factory-CargoRenderQueryJob-Execute0 = 698,
		Beyond-Gameplay-Factory-CargoRenderQueryJob-SetQueryResult0 = 699,
		Beyond-Gameplay-Factory-ConveyorCollectJob-Execute0 = 700,
		Beyond-Gameplay-Factory-ConveyorCollectJob-_Collect0 = 701,
		Beyond-Gameplay-Factory-ConveyorCollectJob-Execute1 = 702,
		Beyond-Gameplay-Factory-ConveyorCollectJob-Execute2 = 703,
		Beyond-Gameplay-Factory-ConveyorCollectJob-SetSharedExtData0 = 704,
		Beyond-Gameplay-Factory-ConveyorFigureRendererJob-Execute0 = 705,
		Beyond-Gameplay-Factory-ConveyorFigureRendererJob-Execute1 = 706,
		Beyond-Gameplay-Factory-ConveyorFigureRendererJob-SetSharedExtData0 = 707,
		Beyond-Gameplay-Factory-ConveyorInsideRenderJob-Execute0 = 708,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-Execute0 = 709,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-_Collect0 = 710,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-Execute1 = 711,
		Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-SetSharedExtData0 = 712,
		Beyond-Gameplay-Factory-ConveyorRendererJob-Execute0 = 713,
		Beyond-Gameplay-Factory-ConveyorRendererJob-_UpdateCachedConveyor0 = 714,
		Beyond-Gameplay-Factory-ConveyorRendererJob-Execute1 = 715,
		Beyond-Gameplay-Factory-ConveyorRendererJob-SetSharedExtData0 = 716,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_SwapBuffer0 = 717,
		Beyond-Gameplay-Factory-InteractFacCollectJob-Execute0 = 718,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecuteBuilding0 = 719,
		Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-IsPointInSector0 = 721,
		Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-SetData0 = 722,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecuteConveyor0 = 723,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_CheckDist0 = 724,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_SnapDirectionToAxis0 = 725,
		Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecutePipe0 = 726,
		Beyond-Gameplay-Factory-InteractFacCollectJob-SetSharedExtData0 = 727,
		Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-ToString0 = 728,
		Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-IsPending0 = 729,
		Beyond-Gameplay-Factory-InteractFacCollectJob-LogisticInfo-IsPending0 = 730,
		Beyond-Gameplay-Factory-LocalToWorldJob-Execute0 = 731,
		Beyond-Gameplay-Factory-LocalToWorldJob-TransTRS0 = 732,
		Beyond-Gameplay-Factory-LocalToWorldJob-Execute1 = 733,
		Beyond-Gameplay-Factory-LocalToWorldJob-SetHierarchyData0 = 734,
		Beyond-Gameplay-Factory-LocalToWorldJob-SetQueryResult0 = 735,
		Beyond-Gameplay-Factory-LocalToWorldJob-ScheduleDefer0 = 736,
		Beyond-Gameplay-Factory-LocalToWorldQueryJob-Execute0 = 737,
		Beyond-Gameplay-Factory-LocalToWorldQueryJob-SetQueryResult0 = 738,
		Beyond-Gameplay-Factory-LogisticEffectJob-Execute0 = 739,
		Beyond-Gameplay-Factory-LookAtJob-Execute0 = 740,
		Beyond-Gameplay-Factory-LookAtJob-SetHierarchyData0 = 741,
		Beyond-Gameplay-Factory-LookAtJob-SetQueryResult0 = 742,
		Beyond-Gameplay-Factory-LookAtJob-ScheduleDefer0 = 743,
		Beyond-Gameplay-Factory-LookAtQueryJob-Execute0 = 744,
		Beyond-Gameplay-Factory-LookAtQueryJob-SetQueryResult0 = 745,
		Beyond-Gameplay-Factory-OutputCollectJob-Execute0 = 746,
		Beyond-Gameplay-Factory-OutputCollectJob-_Collect0 = 747,
		Beyond-Gameplay-Factory-OutputCollectJob-Execute1 = 748,
		Beyond-Gameplay-Factory-OutputCollectJob-Execute2 = 749,
		Beyond-Gameplay-Factory-OutputCollectJob-SetSharedExtData0 = 750,
		Beyond-Gameplay-Factory-OutputRenderJob-Execute0 = 751,
		Beyond-Gameplay-Factory-PedestalFlashJob-Execute0 = 752,
		Beyond-Gameplay-Factory-PedestalFlashJob-_Flash0 = 753,
		Beyond-Gameplay-Factory-PedestalFlashJob-Execute1 = 754,
		Beyond-Gameplay-Factory-PedestalFlashJob-SetSharedExtData0 = 755,
		Beyond-Gameplay-Factory-PipeCollectJob-Execute0 = 756,
		Beyond-Gameplay-Factory-PipeCollectJob-_ExecutePipe0 = 757,
		Beyond-Gameplay-Factory-PipeCollectJob-_CollectPipe0 = 758,
		Beyond-Gameplay-Factory-PipeCollectJob-_CollectPipeCom0 = 759,
		Beyond-Gameplay-Factory-PipeCollectJob-_ExecutePreviewPipe0 = 760,
		Beyond-Gameplay-Factory-PipeCollectJob-_CollectTrack0 = 761,
		Beyond-Gameplay-Factory-PipeCollectJob-Execute1 = 762,
		Beyond-Gameplay-Factory-PipeCollectJob-Execute2 = 763,
		Beyond-Gameplay-Factory-PipeCollectJob-SetGlobalEnvRef0 = 764,
		Beyond-Gameplay-Factory-PipeCollectJob-SetSharedExtData0 = 765,
		Beyond-Gameplay-Factory-PipeComRendererJob-Execute0 = 766,
		Beyond-Gameplay-Factory-PipeFigureRendererJob-Execute0 = 767,
		Beyond-Gameplay-Factory-PipeFigureRendererJob-_UpdateCachedPipe0 = 768,
		Beyond-Gameplay-Factory-PipeFigureRendererJob-Execute1 = 769,
		Beyond-Gameplay-Factory-PipeHolderFigureRendererJob-Execute0 = 770,
		Beyond-Gameplay-Factory-PipeHolderFigureRendererJob-Execute1 = 771,
		Beyond-Gameplay-Factory-PipeHolderHideRendererJob-Execute0 = 772,
		Beyond-Gameplay-Factory-PipeHolderHideRendererJob-Execute1 = 773,
		Beyond-Gameplay-Factory-PipeHolderHideRendererJob-SetSharedExtData0 = 774,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute0 = 775,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute1 = 776,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-SetSharedExtData0 = 777,
		Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute2 = 778,
		Beyond-Gameplay-Factory-PipeRendererJob-Execute0 = 779,
		Beyond-Gameplay-Factory-PipeRendererJob-_UpdateCachedPipe0 = 780,
		Beyond-Gameplay-Factory-PipeRendererJob-SetSharedExtData0 = 781,
		Beyond-Gameplay-Factory-PipeTrackRendererJob-Execute0 = 782,
		Beyond-Gameplay-Factory-PipeTrackRendererJob-_UpdateCachedTrack0 = 783,
		Beyond-Gameplay-Factory-PipeWaterThicknessQueryJob-Execute0 = 784,
		Beyond-Gameplay-Factory-PipeWaterThicknessQueryJob-SetQueryResult0 = 785,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-Execute1 = 786,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-Execute0 = 787,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-SetGlobalEnv0 = 788,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-SetQueryResult0 = 789,
		Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-ScheduleDefer0 = 790,
		Beyond-Gameplay-Factory-PortArrowRenderJob-Execute0 = 791,
		Beyond-Gameplay-Factory-PortStateCollectJob-Execute0 = 792,
		Beyond-Gameplay-Factory-PortStateCollectJob-_Collect0 = 793,
		Beyond-Gameplay-Factory-PortStateCollectJob-SetSharedExtData0 = 794,
		Beyond-Gameplay-Factory-PortStateCollectJob-Execute1 = 795,
		Beyond-Gameplay-Factory-PortStateCollectJob-Execute2 = 796,
		Beyond-Gameplay-Factory-PortStateRendererJob-Execute0 = 797,
		Beyond-Gameplay-Factory-PreviewUnitQueryJob-Execute0 = 798,
		Beyond-Gameplay-Factory-PreviewUnitQueryJob-SetQueryResult0 = 799,
		Beyond-Gameplay-Factory-PumpInEffectJob-Execute0 = 800,
		Beyond-Gameplay-Factory-PumpInEffectJob-Execute1 = 801,
		Beyond-Gameplay-Factory-PumpInEffectJob-SetQueryResult0 = 802,
		Beyond-Gameplay-Factory-PumpInEffectJob-ScheduleDefer0 = 803,
		Beyond-Gameplay-Factory-PumpInEffectJob-SetSharedExtData0 = 804,
		Beyond-Gameplay-Factory-StatusChangeJob-Execute0 = 805,
		Beyond-Gameplay-Factory-UnitCullingJob-Execute1 = 806,
		Beyond-Gameplay-Factory-UnitCullingJob-Execute0 = 807,
		Beyond-Gameplay-Factory-UnitCullingJob-SetGlobalEnvRef0 = 808,
		Beyond-Gameplay-Factory-UnitCullingJob-SetSharedExtData0 = 809,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-Execute1 = 810,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-Execute0 = 811,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetGlobalEnvRef0 = 812,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetSharedExtData0 = 813,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetQueryResult0 = 814,
		Beyond-Gameplay-Factory-UnitPreviewRenderJob-ScheduleDefer0 = 815,
		Beyond-Gameplay-Factory-UnitRendererQueryJob-Execute0 = 816,
		Beyond-Gameplay-Factory-UnitRendererQueryJob-SetQueryResult0 = 817,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-Execute0 = 818,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-Execute1 = 819,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-SetSharedExtData0 = 820,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-SetQueryResult0 = 821,
		Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-ScheduleDefer0 = 822,
		Beyond-Gameplay-Factory-WireCollectJob-Execute0 = 823,
		Beyond-Gameplay-Factory-WireCollectJob-Execute1 = 824,
		Beyond-Gameplay-Factory-WireCollectJob-SetGlobalEnvRef0 = 825,
		Beyond-Gameplay-Factory-WireCollectJob-SetSharedExtData0 = 826,
		Beyond-Gameplay-Factory-WireRenderJob-Execute0 = 827,
		Beyond-Gameplay-Factory-WireRenderJob-_UpdateCachedWire0 = 828,
		Beyond-Gameplay-Factory-WireRenderJob-Execute1 = 829,
		Beyond-Gameplay-Factory-FPtrNativeCurve-IsValid0 = 830,
		Beyond-Gameplay-Factory-FPtrNativeCurve-CreateCurve0 = 831,
		Beyond-Gameplay-Factory-FPtrNativeCurve-Evaluate0 = 832,
		Beyond-Gameplay-Factory-PerDrawPassConfig-Size0 = 833,
		Beyond-Gameplay-Factory-PerDrawPassConfig-Apply0 = 834,
		Beyond-Gameplay-Factory-PerDrawPassConfig-_ParseToHGShaderLightMode0 = 835,
		Beyond-Gameplay-Factory-PerDrawPassConfig-Apply1 = 836,
		Beyond-Gameplay-Factory-PerDrawConfig-Size0 = 837,
		Beyond-Gameplay-Factory-PerDrawConfig-_OnColorChanged0 = 838,
		Beyond-Gameplay-Factory-PerDrawConfig-_OnFloat4Changed0 = 839,
		Beyond-Gameplay-Factory-PerDrawConfig-_OnFloatChanged0 = 840,
		Beyond-Gameplay-Factory-PerDrawConfig-Apply0 = 841,
		Beyond-Gameplay-Factory-ProcessorInterval-CheckInterval0 = 842,
		Beyond-Gameplay-Factory-ProcessorInterval-_CheckInterval0 = 843,
		Beyond-Gameplay-Factory-CargoPredictProcessor-Execute0 = 844,
		Beyond-Gameplay-Factory-CrossFrameProcessor-Initialize0 = 845,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearBuildingPtr0 = 846,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearConveyorPtr0 = 847,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearPipePtr0 = 848,
		Beyond-Gameplay-Factory-CrossFrameProcessor-LateExecute0 = 849,
		Beyond-Gameplay-Factory-CrossFrameProcessor-TearDown0 = 850,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectConveyor0 = 851,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPreviewConveyor0 = 852,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectGuideConveyor0 = 853,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-Initialize0 = 854,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetStateColor0 = 855,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CreateCurrent0 = 856,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CreateAllocator0 = 857,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_InitArrowPlaced0 = 858,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortState0 = 859,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectBuildingState0 = 860,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectOutput0 = 861,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectCargo0 = 862,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectWire0 = 863,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-LateExecute0 = 864,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPipe0 = 865,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPipeLogistics0 = 866,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortArrowWithDiff0 = 867,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortArrow0 = 868,
		Beyond-Gameplay-Factory-FacRendererCollectProcessor-TearDown0 = 869,
		Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-GetColor0 = 870,
		Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-GetIndex0 = 871,
		Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-CreateOrGet0 = 872,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetIndicatorColor0 = 873,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetStateName0 = 874,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetPerDrawList0 = 875,
		Beyond-Gameplay-Factory-FFactoryStateColorConfig-LogicStateConfig-_OnColorChanged0 = 876,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-Init0 = 877,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetParametersByDef0 = 878,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetFloat0 = 879,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetInt0 = 880,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetBool0 = 881,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetAllTriggers0 = 882,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Enter0 = 883,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetState0 = 884,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Exit0 = 885,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-ToNextState0 = 886,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Exit0 = 887,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetTransition0 = 888,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Enter0 = 889,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-__AOT_FOR_FIX__0 = 890,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-get_process0 = 891,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Update0 = 892,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMState-SetProgress0 = 893,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-get_fromStateWeight0 = 894,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Update0 = 895,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetFloat0 = 896,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetInt0 = 897,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetBool0 = 898,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetTrigger0 = 899,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetTrigger0 = 900,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetTrigger0 = 901,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetValue0 = 902,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetValue0 = 903,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMSetParamRequestHandlerJob-Execute0 = 904,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-Execute1 = 905,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-Execute0 = 906,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_CheckTransitions0 = 907,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-TryGetValidTransition0 = 908,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-_Evaluate0 = 909,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-ResetUsedTriggers0 = 910,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_AddVATAudioData0 = 911,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_ComputeVATFrameData0 = 912,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-SetSharedExtData0 = 913,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-Initialize0 = 914,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-Initialize0 = 915,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-Execute0 = 916,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-_RemoveDuplicationRequest0 = 917,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-_HandleSetAnimatorParamRequest0 = 918,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-TearDown0 = 919,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-Dispose0 = 920,
		Beyond-Gameplay-Factory-ECSVATFSM-AnimationClipData-GetClipDesStr0 = 921,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Size0 = 922,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-AsSpan0 = 923,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Reserve0 = 924,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Get0 = 925,
		Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Get1 = 926,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-InitFSMDefinition0 = 927,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-RegisterFSM0 = 928,
		Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-GetStateName0 = 929,
		Beyond-Gameplay-Factory-Util-JobHandlerExtensions-SafeComplete0 = 930,
		Beyond-Gameplay-Factory-Unsafe-BurstBridge-BeginProfilerSample0 = 931,
		Beyond-Gameplay-Factory-Unsafe-BurstBridge-EndProfilerSample0 = 932,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-QueryBuildingStateIsClosed0 = 933,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-_IsPowerBuilding0 = 934,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-CulledWithLogicEntity0 = 935,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-CulledWithRendererEntity0 = 936,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetVisibility1 = 937,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetVisibility0 = 938,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibility0 = 939,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibilityWithNotify0 = 940,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-UpdatePipeEffect0 = 941,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibility1 = 942,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetInMainRegion0 = 944,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-IsInMainRegionFuzzy0 = 945,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-UpdatePipeEffect1 = 946,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingExtendConfig0 = 947,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingStaticMountWorldTRS1 = 948,
		Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingStaticMountWorldTRS0 = 949,
		Beyond-Gameplay-Factory-Unsafe-GameplayExtensions-GetChapterEntity0 = 950,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetGlobalEnvPtr0 = 951,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-IsGlobalEnvValid0 = 952,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetGlobalEnvRef0 = 953,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractFac0 = 954,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractConveyor0 = 955,
		Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractPipe0 = 956,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-_ExpandMemory0 = 957,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-_MergeAdjacentFreeBlocks0 = 959,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Allocate0 = 960,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Reserve0 = 967,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Expand0 = 968,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Free0 = 969,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Resize0 = 970,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Dispose0 = 971,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocator-PrintAllocations0 = 972,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Initialize0 = 973,
		Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Dispose0 = 975,
		Beyond-Gameplay-Factory-Unsafe-TLSFAllocator-GetFreeSpace0 = 976,
		Beyond-Gameplay-Factory-Unsafe-TLSFAllocator-MappingInsert0 = 977,
		Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-AllocManualNodeId0 = 978,
		Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-AddressOf0 = 979
	}
}

namespace UnityEngine.HyperGryph.ECS
{
	public static class ColliderComponentExtensions // TypeDefIndex: 48507
	{
		// Extension methods
		public static void ToggleCollision(this Entity logicEntity, bool enable, ref EntityManager em) {} // 0x00000001826E1310-0x00000001826E1840
		public static void Toggle(this ref ECSColliderComponent collision, bool enable) {} // 0x000000018294A510-0x000000018294A580
		public static void UpdateCollisionTRS(this Entity logicEntity, [IsReadOnly] in EntityManager em) {} // 0x000000018294AD30-0x000000018294B260
		public static void UpdateCollisionTRS(this ECSColliderComponent c, float3 pos, quaternion rot) {} // 0x000000018294BB80-0x000000018294BC80
		public static void DestroyCollisionWithRenderEntity(this Entity rEntity, ref EntityManager em) {} // 0x0000000182AAC900-0x0000000182AAC9D0
		public static void DestroyCollision(this Entity logicEntity, ref EntityManager em) {} // 0x000000018578D580-0x000000018578D8D8
	}

	public static class ECSExtensions // TypeDefIndex: 48508
	{
		// Methods
		private static void _SetComponentImpl(ref EntityInstanceData entityData, ref EntityTypeInstanceData entityTypeData, int componentId, [IsReadOnly] in IntPtr component, int componentSize) {} // 0x00000001823F4F60-0x00000001823F5070
	
		// Extension methods
		public static Entity GetEntity(this GroupType group, int index) => default; // 0x0000000182433940-0x0000000182433960
		public static bool HasComponent([IsReadOnly] this in EntityManager entityManager, [IsReadOnly] in Entity entity, int componentId) => default; // 0x00000001823F4300-0x00000001823F4340
		public static void CreateEntities([IsReadOnly] this in EntityManager em, NativeArray<ComponentType> archetypes, NativeArray<Entity> result) {} // 0x0000000182C5E9B0-0x0000000182C5EA00
		public static Entity CreateEntity([IsReadOnly] this in EntityManager entityManager) => default; // 0x000000018241C8B0-0x000000018241C980
		public static Entity CreateEntity([IsReadOnly] this in EntityManager entityManager, NativeArray<ComponentType> archetypes) => default; // 0x0000000182755860-0x0000000182755910
		public static void Is<T>([IsReadOnly] this in EntityManager entityManager, Entity entity, bool flag)
			where T : struct, IComponentECS {}
		public static void AddComponent<T>([IsReadOnly] this in EntityManager entityManager, Entity entity)
			where T : struct, IComponentECS {}
		public static void AddComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId, [IsReadOnly] in IntPtr component, int componentSize) {} // 0x000000018241D6F0-0x000000018241DB30
		public static void AddOrSetComponent<T>([IsReadOnly] this in EntityManager entityManager, Entity entity, T t)
			where T : struct, IComponentECS {}
		public static void AddOrSetComponent<T1, T2>([IsReadOnly] this in EntityManager entityManager, Entity entity, T1 t1, T2 t2)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS {}
		public static void SetComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId, [IsReadOnly] in IntPtr component, int componentSize) {} // 0x0000000183386BB0-0x0000000183386BE0
		public static void SetComponents<T0, T1, T2>([IsReadOnly] this in EntityManager entityManager, [IsReadOnly] in Entity entity, [IsReadOnly] in ref T0 t0, [IsReadOnly] in ref T1 t1, [IsReadOnly] in ref T2 t2)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS {}
		public static void SetComponents<T0, T1, T2, T3>([IsReadOnly] this in EntityManager entityManager, [IsReadOnly] in Entity entity, [IsReadOnly] in ref T0 t0, [IsReadOnly] in ref T1 t1, [IsReadOnly] in ref T2 t2, [IsReadOnly] in ref T3 t3)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS {}
		public static void SetComponents<T0, T1, T2, T3, T4>([IsReadOnly] this in EntityManager entityManager, [IsReadOnly] in Entity entity, [IsReadOnly] in ref T0 t0, [IsReadOnly] in ref T1 t1, [IsReadOnly] in ref T2 t2, [IsReadOnly] in ref T3 t3, [IsReadOnly] in ref T4 t4)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS {}
		public static EntityManagerRange Iterate([IsReadOnly] this in EntityManager em, [IsReadOnly] in EntityQueryBuilder queryBuilder) => default; // 0x0000000182434950-0x0000000182434AF0
		public static EntityManagerRange Iterate<T0, T1, T2>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5, T6>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5, T6, T7>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS => default;
		public static EntityManagerRange Iterate<T0, T1, T2, T3, T4, T5, T6, T7, T8>([IsReadOnly] this in EntityManager em)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS
			where T8 : struct, IComponentECS => default;
		public static unsafe void GetComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId, int componentSize, void* componentPtr) {} // 0x000000018578DF1C-0x000000018578E00C
		public static bool MoveComponent<T>([IsReadOnly] this in EntityManager entityManager, Entity src, Entity des)
			where T : struct, IComponentECS => default;
		public static void RemoveComponent([IsReadOnly] this in EntityManager entityManager, Entity entity, int componentId) {} // 0x0000000182420E00-0x0000000182420E50
		public static void SafeRemoveComponent<T>([IsReadOnly] this in EntityManager entityManager, Entity entity)
			where T : struct, IComponentECS {}
		public static void RemoveComponent<T>([IsReadOnly] this in EntityManager entityManager)
			where T : struct, IComponentECS {}
		public static bool GetInstance<T, TR>([IsReadOnly] this in EntityManager em, out Entity entity, out ref TR component)
			where T : struct, IComponentECS
			where TR : struct, IComponentECS {
			entity = default;
			component = default;
			return default;
		}
		public static bool GetFirst<T, TR>([IsReadOnly] this in EntityManager entityManager, out Entity entity, out ref TR component)
			where T : struct, IComponentECS
			where TR : struct, IComponentECS {
			entity = default;
			component = default;
			return default;
		}
		public static bool GetFirst<T1, T2, TR>([IsReadOnly] this in EntityManager entityManager, out Entity entity, out ref TR component)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where TR : struct, IComponentECS {
			entity = default;
			component = default;
			return default;
		}
		public static void NotifyEvent<T>([IsReadOnly] this in EntityManager em, Entity logicEntity)
			where T : struct, INotificationComponent {}
		public static void NotifyEvent<T>([IsReadOnly] this in EntityManager em, Entity logicEntity, T t)
			where T : struct, INotificationComponent {}
		public static void NotifyEvent<T1, T2>([IsReadOnly] this in EntityManager em, Entity logicEntity, T1 t1, T2 t2)
			where T1 : struct, INotificationComponent
			where T2 : struct, INotificationComponent {}
		public static void DispatchEvent<T>([IsReadOnly] this in EntityManager em, Entity entity)
			where T : struct, IReactiveComponent {}
		public static void DispatchEvent<T>([IsReadOnly] this in EntityManager em, Entity entity, T t)
			where T : struct, IReactiveComponent {}
		public static void DispatchEvent<T1, T2>([IsReadOnly] this in EntityManager em, Entity entity, T1 t1, T2 t2)
			where T1 : struct, IReactiveComponent
			where T2 : struct, IReactiveComponent {}
		public static void DestroyEntitiesWithArchetype([IsReadOnly] this in EntityManager entityManager, ref ComponentMask entityMask) {} // 0x000000018578DCEC-0x000000018578DF1C
		public static void DestroyEntities<T>([IsReadOnly] this in EntityManager entityManager)
			where T : struct, IComponentECS {}
		public static void DestroyEntities<T1, T2>([IsReadOnly] this in EntityManager entityManager)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS {}
		public static bool HasEntity<T>([IsReadOnly] this in EntityManager em)
			where T : struct, IComponentECS => default;
		public static bool HasEntity<T1, T2>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS => default;
		public static int GetEntityCount([IsReadOnly] this in EntityManager em, int compId) => default; // 0x000000018578E00C-0x000000018578E180
		public static int GetEntityCount([IsReadOnly] this in EntityManager em, int compId0, int compId1) => default; // 0x000000018578E180-0x000000018578E2F4
		public static int GetEntityCount<T>([IsReadOnly] this in EntityManager em)
			where T : struct, IComponentECS => default;
		public static int GetEntityCount<T1, T2>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS => default;
		public static int GetEntityCount<T1, T2, T3>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS => default;
		public static int GetEntityCount<T1, T2, T3, T4>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS => default;
		public static int GetEntityCount<T1, T2, T3, T4, T5>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS => default;
		public static int GetEntityCount<T1, T2, T3, T4, T5, T6>([IsReadOnly] this in EntityManager em)
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS => default;
		public static void EnsureComponent<T>([IsReadOnly] this in EntityManager em, Entity entity)
			where T : struct, IComponentECS {}
		public static void EnsureComponent<T>([IsReadOnly] this in EntityManager em, Entity entity, out ref T comp)
			where T : struct, IComponentECS {
			comp = default;
		}
		public static ECSSpan<T> GetComponentAsSpan<T>(this GroupType groupType)
			where T : struct, IComponentECS => default;
		public static ECSSpan<T> GetComponentAsSpan<T>(this GroupType groupType, int componentId)
			where T : struct, IComponentECS => default;
		public static ComponentMask ComposeComponentMaskAll(this EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6) => default; // 0x0000000182F1F010-0x0000000182F1F0F0
		public static ComponentMask ComposeComponentMaskAll(this EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6, int id7) => default; // 0x0000000182F6D7C0-0x0000000182F6D8C0
		public static ComponentMask ComposeComponentMaskAll(this EntityManager em, int id0, int id1, int id2, int id3, int id4, int id5, int id6, int id7, int id8) => default; // 0x0000000183D55830-0x0000000183D55950
	}

	public static class HGFactoryRendererBinderExtensions // TypeDefIndex: 48509
	{
		// Extension methods
		public static void RenderWithTRS(this HGFactoryRendererBinderComponent binder, [IsReadOnly] in LocalToWorld localToWorld) {} // 0x000000018578F6D4-0x000000018578F870
		public static void RenderWithTRS(this HGFactoryRendererBinderComponent binder, float4x4 value) {} // 0x000000018578F870-0x000000018578F9F4
		public static void EnableDither(this HGFactoryRendererBinderComponent binder, bool enable, float alphaValue, HGObjectFlags objectFlags) {} // 0x00000001826E3920-0x00000001826E3B40
		public static void EnableDither(this HGFactoryRendererBinderComponent binder, ref EntityManager rEntityManager, bool enable, float alphaValue, HGObjectFlags objectFlags) {} // 0x00000001826E3740-0x00000001826E3920
	}

	public struct EntityCommandBuffer // TypeDefIndex: 48512
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
	
		// Properties
		public EntityManager entityManager { [IsReadOnly] get; } // 0x0000000183D55950-0x0000000183D55960 
	
		// Nested types
		public delegate void EntityCommandCallback(Entity entity, ref EntityManager entityManager, ref EntityCommandBufferData buffer); // TypeDefIndex: 48510; 0x00000001811360D0-0x00000001811360F0
	
		public struct VirtualEntityMap // TypeDefIndex: 48511
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
		} // 0x0000000182751B20-0x0000000182751D70
	
		// Methods
		public ValueTuple<bool, Entity> GetRealEntity(Entity virtualEntity) => default; // 0x0000000182420010-0x0000000182420260
	}

	public static class EntityCommand // TypeDefIndex: 48513
	{
		// Methods
		private static unsafe void* _ComponentCpy<T>(T component)
			where T : struct, IComponentECS => default;
	
		// Extension methods
		public static EntityCommandBuffer CreateCommandBuffer(this EntityManager entityManager, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x01FBB8AF */) => default; // 0x0000000182751AE0-0x0000000182751B20
		public static Entity CreateEntity(this EntityCommandBuffer ecb) => default; // 0x00000001826037B0-0x0000000182603980
		public static void DestroyEntity(this EntityCommandBuffer ecb, Entity entity) {} // 0x0000000182603550-0x0000000182603610
		public static void AddComponent<T>(this EntityCommandBuffer ecb, Entity entity)
			where T : struct, IComponentECS {}
		public static void AddComponent<T>(this EntityCommandBuffer ecb, Entity entity, T component)
			where T : struct, IComponentECS {}
		public static void RemoveComponent<T>(this EntityCommandBuffer ecb, Entity entity)
			where T : struct, IComponentECS {}
		public static void SetComponent<T>(this EntityCommandBuffer ecb, Entity entity, T component)
			where T : struct, IComponentECS {}
		public static void Is<T>(this EntityCommandBuffer ecb, Entity entity, bool flag)
			where T : struct, IComponentECS {}
		public static void GetComponent<T>(this EntityCommandBuffer ecb, Entity entity, ref ref T component)
			where T : struct, IComponentECS {}
		public static void NotifyEvent<T>(this EntityCommandBuffer ecb, Entity entity)
			where T : struct, INotificationComponent {}
		public static void NotifyEvent<T>(this EntityCommandBuffer ecb, Entity entity, T t)
			where T : struct, INotificationComponent {}
		public static void DispatchEvent<T>(this EntityCommandBuffer ecb, Entity entity)
			where T : struct, IReactiveComponent {}
		public static void DispatchEvent<T>(this EntityCommandBuffer ecb, Entity entity, T component)
			where T : struct, IReactiveComponent {}
		public static void Playback(this EntityCommandBuffer ecb, bool autoDispose = true /* Metadata: 0x01FBB8B0 */) {} // 0x000000018241F5C0-0x000000018241FCA0
		public static void Dispose(this EntityCommandBuffer ecb) {} // 0x0000000182420E50-0x0000000182420F10
	}

	public class EntityCommandOp // TypeDefIndex: 48514
	{
		// Fields
		public static readonly int CREATE; // 0x00
		public static readonly int ADD; // 0x04
		public static readonly int REMOVE; // 0x08
		public static readonly int MODIFY; // 0x0C
		public static readonly int DESTROY; // 0x10
		public static readonly int QUERY; // 0x14
	
		// Constructors
		public EntityCommandOp() {} // 0x000000018350B670-0x000000018350B680
		static EntityCommandOp() {} // 0x0000000183CF0C70-0x0000000183CF0D20
	}

	public struct EntityCommandBufferData // TypeDefIndex: 48515
	{
		// Fields
		public int op; // 0x00
		public Entity entity; // 0x04
		public CommandBufferComponent componentData; // 0x10
	
		// Methods
		public void Free() {} // 0x000000018426FD78-0x000000018426FD8C
	}

	public struct CommandBufferComponent // TypeDefIndex: 48516
	{
		// Fields
		public int componentId; // 0x00
		public int componentSize; // 0x04
		public unsafe void* component; // 0x08
	}

	[BurstCompile]
	public struct EntityCommandBufferV2 : INativeDisposable // TypeDefIndex: 48519
	{
		// Fields
		public static int s_mapSize; // 0x00
		[ReadOnly]
		public NativeQueue<EntityCommandBufferData> buffers; // 0x00
		[ReadOnly]
		public NativeParallelHashMap<ulong, VirtualEntityMap> tempEntities; // 0x18
	
		// Properties
		public bool isEmpty { get => default; } // 0x000000018578E42C-0x000000018578E468 
	
		// Nested types
		public struct VirtualEntityMap // TypeDefIndex: 48517
		{
			// Fields
			public Entity virtualEntity; // 0x00
			public Entity realEntity; // 0x08
		}
	
		public struct EntityCommandBufferParallelWriter // TypeDefIndex: 48518
		{
			// Fields
			public long tempIdx; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeQueue<EntityCommandBufferData> buffersWriter; // 0x08
			[NativeDisableParallelForRestriction]
			public NativeParallelHashMap<ulong, VirtualEntityMap> tempEntitiesWriter; // 0x20
		}
	
		// Constructors
		public EntityCommandBufferV2(Unity.Collections.Allocator allocator) : this() {
			buffers = default;
			tempEntities = default;
		} // 0x0000000183C787B0-0x0000000183C788A0
		static EntityCommandBufferV2() {
			s_mapSize = default;
		} // 0x0000000183D44920-0x0000000183D44960
	
		// Methods
		public ValueTuple<bool, Entity> GetRealEntity(Entity virtualEntity) => default; // 0x000000018241E560-0x000000018241E7D0
		public void Reset() {} // 0x000000018241F0A0-0x000000018241F260
		public void Dispose() {} // 0x000000018578E3C0-0x000000018578E42C
		public JobHandle Dispose(JobHandle dependsOn) => default; // 0x000000018578E2F4-0x000000018578E3C0
		public EntityCommandBufferParallelWriter AsParallelWriter() => default; // 0x0000000182309D90-0x0000000182309E60
	}

	public static class EntityCommandV2 // TypeDefIndex: 48520
	{
		// Fields
		private static readonly Queue<EntityCommandBufferV2> S_POOL; // 0x00
	
		// Constructors
		static EntityCommandV2() {} // 0x0000000183CDEFC0-0x0000000183CDF080
	
		// Methods
		public static void DisposePool() {} // 0x000000018578E7A4-0x000000018578E8A8
		public static void Recycle(ref EntityCommandBufferV2 buffer) {} // 0x000000018241ED90-0x000000018241F0A0
		private static unsafe T* _ComponentCpy<T>(T component)
			where T : struct, IComponentECS => default;
	
		// Extension methods
		public static EntityCommandBufferV2 CreateConcurrentCommandBufferV2(this EntityManager em) => default; // 0x00000001823081E0-0x00000001823083F0
		public static Entity CreateEntity(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer) => default; // 0x000000018578E5EC-0x000000018578E704
		public static void DestroyEntity(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity) {} // 0x000000018578E704-0x000000018578E7A4
		public static void AddComponent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, IComponentECS {}
		public static void AddComponent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T component)
			where T : struct, IComponentECS {}
		public static void RemoveComponent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, IComponentECS {}
		public static void SetComponent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T component)
			where T : struct, IComponentECS {}
		public static void GetComponent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, ref ref T component)
			where T : struct, IComponentECS {}
		public static void NotifyEvent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, INotificationComponent {}
		public static void NotifyEvent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T t)
			where T : struct, INotificationComponent {}
		public static void DispatchEvent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity)
			where T : struct, IReactiveComponent {}
		public static void DispatchEvent<T>(this ref EntityCommandBufferV2.EntityCommandBufferParallelWriter writer, Entity entity, T component)
			where T : struct, IReactiveComponent {}
		public static void Playback(this EntityCommandBufferV2 ecb, bool autoRecycle = true /* Metadata: 0x01FBB8B1 */) {} // 0x000000018241DB30-0x000000018241E560
	}

	public struct ECSSpan<T> // TypeDefIndex: 48521
		where T : struct, IComponentECS
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public unsafe void* buffer;
		public int length;
	
		// Properties
		public ref T this[int index] { get => default; }
	}

	public struct EntityPool<T0, T1, T2> // TypeDefIndex: 48522
		where T0 : struct
		where T1 : struct
		where T2 : struct
	{
		// Fields
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
		public int defaultSize { [IsReadOnly] get; private set; }
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
		public void Recycle(int count = 1 /* Metadata: 0x01FBB8B2 */) {}
		public Entity Recycle(Entity entity) => default;
		public static EntityPool<T0, T1, T2> Alloc(int count, Action<Entity, float3, float3, Matrix4x4, float4x4> onSpawn, Action<Entity, float4x4> onRecycle, Action<NativeArray<Entity>, int, float4x4> onAllocate, Action<NativeArray<Entity>, int, float4x4> onDeallocate = null, float4x4 customData = default, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x01FBB8B3 */, bool autoAllocate = true /* Metadata: 0x01FBB8B4 */) => default;
		public void Free() {}
		private void _Resize() {}
		public static implicit operator NativeArray<Entity>(EntityPool<T0, T1, T2> pool) => default;
		public NativeArray<Entity> AsReadOnly() => default;
	}

	public class EntityHierarchyContainer // TypeDefIndex: 48525
	{
		// Fields
		public const int INVALID_INDEX = -1; // Metadata: 0x01FBB8B5
		private HGArray<Node> m_nodes; // 0x10
	
		// Properties
		public ref EntityTransformData this[int index] { get => default; } // 0x00000001827676D0-0x0000000182767720 
		public ref EntityTransformData this[uint index] { get => default; } // 0x000000018276A0D0-0x000000018276A110 
	
		// Nested types
		public struct EntityTransformData // TypeDefIndex: 48523
		{
			// Fields
			public uint next; // 0x00
			public LocalTransform localTrans; // 0x04
			public int parentIndex; // 0x24
			public bool dirty; // 0x28
		}
	
		internal struct Node // TypeDefIndex: 48524
		{
			// Fields
			public EntityTransformData value; // 0x00
			public uint next; // 0x00
		}
	
		// Constructors
		public EntityHierarchyContainer() {} // Dummy constructor
		public EntityHierarchyContainer(Unity.Collections.Allocator allocator) {} // 0x0000000182C34D20-0x0000000182C34DC0
	
		// Methods
		public void Dispose() {} // 0x000000018578E918-0x000000018578E95C
		public uint Size() => default; // 0x000000018578E9B4-0x000000018578E9E8
		public Span<EntityTransformData> AsSpan() => default; // 0x000000018578E8A8-0x000000018578E918
		public LocalTransform WorldTrans(uint handle) => default; // 0x000000018578EB34-0x000000018578EBAC
		public LocalTransform WorldTrans(EntityTransformData transform) => default; // 0x000000018578E9E8-0x000000018578EB34
		public static unsafe LocalTransform WorldTrans(EntityTransformData transform, EntityTransformData* hierarchyContainer) => default; // 0x00000001828B4AF0-0x00000001828B4C60
		public uint Create(ref EntityTransformData value) => default; // 0x0000000182765500-0x0000000182765640
		public void Destroy(uint handle) {} // 0x0000000182AADB90-0x0000000182AADBF0
		public void Reset() {} // 0x0000000182C34840-0x0000000182C348A0
		public void Reserve(uint newCapacity) {} // 0x000000018578E96C-0x000000018578E9B4
		public IntPtr Data() => default; // 0x00000001826E0BE0-0x00000001826E0C20
		public ref EntityTransformData Get(uint handle) => ref _refReturnTypeForGet; // 0x000000018578E95C-0x000000018578E964
		private ref EntityTransformData _refReturnTypeForGet; // Dummy field
		public ref EntityTransformData Get(int handle) => ref _refReturnTypeForGet; // 0x000000018578E964-0x000000018578E96C
		private ref EntityTransformData _refReturnTypeForGet; // Dummy field
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	public struct EntityQueryBuilder // TypeDefIndex: 48528
	{
		// Fields
		internal unsafe BuilderData* builderDataPtr; // 0x00
	
		// Nested types
		internal struct BuilderData // TypeDefIndex: 48527
		{
			// Fields
			internal UnsafeList<ComponentType> all; // 0x00
			internal UnsafeList<ComponentType> none; // 0x20
	
			// Nested types
			internal enum Type // TypeDefIndex: 48526
			{
				INCLUDE = 0,
				EXCLUDE = 1
			}
	
			// Methods
			public ComponentMask ComponentMask([IsReadOnly] in EntityManager em, Type type) => default; // 0x0000000182434AF0-0x0000000182434D60
		}
	
		// Constructors
		public unsafe EntityQueryBuilder(int maxCount = 8 /* Metadata: 0x01FBB8B6 */) {
			builderDataPtr = default;
		} // 0x00000001826E8D50-0x00000001826E9100
	
		// Methods
		public static EntityQueryBuilder Create(int maxCount = 8 /* Metadata: 0x01FBB8B7 */) => default; // 0x00000001826E8CD0-0x00000001826E8D00
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
			where T4 : struct, IComponentECS => default;
		public EntityManagerRange Build(ref EntityManager em) => default; // 0x0000000184271414-0x0000000184271454
	}

	public static class EntityQueryV2 // TypeDefIndex: 48532
	{
		// Nested types
		public struct BlockRange // TypeDefIndex: 48529
		{
			// Fields
			public int beginGroupIdx; // 0x00
			public int endGroupIdx; // 0x04
			public int beginGroupElemBeginIdx; // 0x08
			public int endGroupElemEndIdx; // 0x0C
		}
	
		[NoAlias]
		public struct QueryResultDefer : IDisposable // TypeDefIndex: 48530
		{
			// Fields
			[NativeDisableUnsafePtrRestriction]
			public unsafe UnsafeList<GroupType>* groups; // 0x00
			[NativeDisableUnsafePtrRestriction]
			public unsafe UnsafeList<BlockRange>* blockRanges; // 0x08
			public int rangeCount; // 0x10
	
			// Properties
			public bool valid { get => default; } // 0x000000018578FFB0-0x000000018578FFB8 
			public unsafe int* rangeCountPtr { get => default; } // 0x0000000183D55960-0x0000000183D55970 
	
			// Methods
			public void InitList(Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x01FBB8CF */, int initialCapacity = 32 /* Metadata: 0x01FBB8D0 */) {} // 0x0000000183278C30-0x0000000183278CE0
			public void ReleaseList() {} // 0x000000018578FD74-0x000000018578FDCC
			public void Reset() {} // 0x00000001826DFA10-0x00000001826DFA60
			public ref BlockRange BlockRangeAt(int index) => ref _refReturnTypeForBlockRangeAt; // 0x000000018578F9F4-0x000000018578FA3C
			private ref BlockRange _refReturnTypeForBlockRangeAt; // Dummy field
			public ref GroupType GroupAt(int index) => ref _refReturnTypeForGroupAt; // 0x000000018578FD30-0x000000018578FD74
			private ref GroupType _refReturnTypeForGroupAt; // Dummy field
			public void Foreach(Func<GroupType, bool> callback) {} // 0x000000018578FC60-0x000000018578FD30
			public int EntityCount() => default; // 0x000000018578FB94-0x000000018578FC60
			public void Dispose() {} // 0x000000018578FA3C-0x000000018578FA60
			public void Dispose(JobHandle jobHandle, bool inCrossFrame = false /* Metadata: 0x01FBB8D1 */) {} // 0x000000018578FA60-0x000000018578FB94
			public override string ToString() => default; // 0x000000018578FDCC-0x000000018578FFB0
		}
	
		[NoAlias]
		public struct QueryResult : IDisposable // TypeDefIndex: 48531
		{
			// Fields
			[ReadOnly]
			public NativeList<GroupType> groups; // 0x00
			[ReadOnly]
			public NativeList<BlockRange> blockRanges; // 0x10
	
			// Properties
			public int rangeCount { get => default; } // 0x00000001826DEED0-0x00000001826DEF20 
			public bool isEmpty { get => default; } // 0x0000000185790658-0x0000000185790670 
	
			// Methods
			public override string ToString() => default; // 0x0000000185790420-0x0000000185790658
			public void Foreach(Func<GroupType, bool> callback) {} // 0x00000001857902A8-0x0000000185790420
			public int EntityCount() => default; // 0x00000001826DEF90-0x00000001826DF1A0
			public void Dispose() {} // 0x0000000185790284-0x00000001857902A8
			public void Dispose(JobHandle jobHandle, bool inCrossFrame = false /* Metadata: 0x01FBB8D2 */) {} // 0x00000001826E6970-0x00000001826E6CD0
		}
	
		// Extension methods
		public static QueryResult Query(this EntityManager em, ref EntityQueryBuilder builder, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x01FBB8BA */, int jobCount = -1 /* Metadata: 0x01FBB8BB */) => default; // 0x00000001826E6FC0-0x00000001826E72D0
		public static ref QueryResultDefer QueryDefer(this EntityManager em, ref EntityQueryBuilder builder, ref QueryResultDefer qrd, int jobCount = -1 /* Metadata: 0x01FBB8BC */) => ref _refReturnTypeForQueryDefer; // 0x000000018578EEFC-0x000000018578EFFC
		private ref QueryResultDefer _refReturnTypeForQueryDefer; // Dummy field
		public static QueryResult Query<T>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x01FBB8BD */, int jobCount = -1 /* Metadata: 0x01FBB8BE */)
			where T : struct, IComponentECS => default;
		public static QueryResult Query<T0, T1>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x01FBB8BF */, int jobCount = -1 /* Metadata: 0x01FBB8C0 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS => default;
		public static QueryResult Query<T0, T1, T2>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x01FBB8C1 */, int jobCount = -1 /* Metadata: 0x01FBB8C2 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS => default;
		public static QueryResult Query<T0, T1, T2, T3>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x01FBB8C3 */, int jobCount = -1 /* Metadata: 0x01FBB8C4 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS => default;
		public static QueryResult Query<T0, T1, T2, T3, T4>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x01FBB8C5 */, int jobCount = -1 /* Metadata: 0x01FBB8C6 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS => default;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x01FBB8C7 */, int jobCount = -1 /* Metadata: 0x01FBB8C8 */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS => default;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x01FBB8C9 */, int jobCount = -1 /* Metadata: 0x01FBB8CA */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS => default;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6, T7>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x01FBB8CB */, int jobCount = -1 /* Metadata: 0x01FBB8CC */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS => default;
		public static QueryResult Query<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this EntityManager em, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.TempJob /* Metadata: 0x01FBB8CD */, int jobCount = -1 /* Metadata: 0x01FBB8CE */)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS
			where T2 : struct, IComponentECS
			where T3 : struct, IComponentECS
			where T4 : struct, IComponentECS
			where T5 : struct, IComponentECS
			where T6 : struct, IComponentECS
			where T7 : struct, IComponentECS
			where T8 : struct, IComponentECS => default;
		public static QueryResultDefer GetBlockRangesDefer(this EntityManagerRange range, int jobCount, ref QueryResultDefer qr) => default; // 0x000000018578EBAC-0x000000018578EEFC
		public static QueryResult GetBlockRanges(this EntityManagerRange range, Unity.Collections.Allocator allocator, int jobCount) => default; // 0x00000001826E73B0-0x00000001826E7D80
	}

	[BurstCompile]
	public static class QueryResultWrapper // TypeDefIndex: 48535
	{
		// Nested types
		public unsafe delegate void Wrapper_000000D7_PostfixBurstDelegate(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount); // TypeDefIndex: 48533; 0x0000000182097E50-0x0000000182097E70
	
		internal static class Wrapper_000000D7_BurstDirectCall // TypeDefIndex: 48534
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static Wrapper_000000D7_BurstDirectCall() {} // 0x0000000183CE8EF0-0x0000000183CE8F00
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00066543) {} // 0x00000001826E8180-0x00000001826E8330
			private static IntPtr GetFunctionPointer() => default; // 0x00000001826E7F60-0x00000001826E80F0
			public static void Constructor() {} // 0x0000000183CE8F00-0x0000000183CE8F90
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount) {} // 0x00000001826E7EA0-0x00000001826E7F60
		}
	
		// Methods
		[BurstCompile]
		public static unsafe void Wrapper(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount) {} // 0x00000001826E7D80-0x00000001826E7EA0
		[BurstCompile]
		public static unsafe void Wrapper_BurstManaged(EntityManagerRange* range, UnsafeList<GroupType>* groups, UnsafeList<EntityQueryV2.BlockRange>* blockRange, int workerCount) {} // 0x000000018578FFB8-0x0000000185790284
	}
}
