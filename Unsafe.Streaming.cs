/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Beyond.Gameplay.Streaming;
using Beyond.VFS;
using IFix.Core;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.HyperGryph.Streaming;

// Image 132: Unsafe.Streaming.dll - Assembly: Unsafe.Streaming, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91226-91250

namespace Beyond.Gameplay.Streaming
{
	public static class StreamingUnsafeUtilsV2 // TypeDefIndex: 91237
	{
		// Fields
		public static int s_defaultSceneStateId; // 0x00
		public static int s_defaultAreaId; // 0x04
	
		// Methods
		public static StreamingSourceData CreateStreamingSourceData(Vector2 streamingPos, float chunkLoadRadius, float defaultLayerLoadRadius, float hlod0LayerLoadRadius, float hlod1LayerLoadRadius, float hlod2LayerLoadRadius, float colliderLayerLoadRadius, float tinyLayerLoadRadius, float waterLayerLoadRadius, float lightingLoadRadius, float audioLoadRadius, float rendererWithColliderLoadRadius, NativeArray<byte> layerEnabled); // 0x0000000185FE8840-0x0000000185FE8A10
		public static void MemSet<T>(NativeArray<T> array, byte value, int count)
			where T : struct;
		public static void MemCpyUnsafe(IntPtr destination, IntPtr source, long size); // 0x000000018D6D3F54-0x000000018D6D3FA8
		public static IntPtr MallocUnsafe(long size, int alignment, Unity.Collections.Allocator allocator); // 0x000000018D6D3F00-0x000000018D6D3F54
		public static void FreeUnsafe(IntPtr memory, Unity.Collections.Allocator allocator); // 0x000000018D6D3EC0-0x000000018D6D3F00
		public static ref UnityEngine.HyperGryph.ECS.RendererInfo GetRendererInfo(IntPtr rendererInfos, int index); // 0x000000018725B260-0x000000018725B270
	
		// Extension methods
		public static Span<T> AsSpan<T>(this NativeArray<T> nativeArray)
			where T : struct;
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> nativeArray)
			where T : struct;
		public static byte[] ConvertToBytes<T>(this T val)
			where T : struct;
		public static IntPtr GetIntPtr<T>(this NativeArray<T> array)
			where T : struct;
		public static IntPtr GetReadonlyIntPtr<T>(this NativeArray<T> array)
			where T : struct;
		public static UIntPtr GetReadonlyUIntPtr<T>(this NativeArray<T> array)
			where T : struct;
		public static IntPtr GetRendererInfos<T>(this ref ref T kComponent)
			where T : struct, IRenderObjectKComponent;
		public static TTo ReinterpretAs<TFrom, TTo>(this TFrom val)
			where TFrom : struct
			where TTo : struct;
	}

	public struct UnsafeArray<T> : IDisposable // TypeDefIndex: 91238
		where T : struct
	{
		// Fields
		public IntPtr ptr;
		public int count;
		public Unity.Collections.Allocator allocator;
	
		// Properties
		public bool IsCreated { get; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public UnsafeArray(int count, Unity.Collections.Allocator allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0264BFBC */);
	
		// Methods
		public T GetValue(int index);
		public ref ref T GetRef(int index);
		public void SetValue(int index, T value);
		public void Resize(int newCount, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x0264BFBD */);
		public void Dispose();
	}

	public struct VFSReadOperation : IDisposable // TypeDefIndex: 91239
	{
		// Fields
		public unsafe ReadCommand* readCommand; // 0x00
		public ReadHandle readHandle; // 0x08
	
		// Constructors
		public unsafe VFSReadOperation(FVFBlockFileInfo info, bool async); // 0x000000018D6D4140-0x000000018D6D42B0
	
		// Methods
		public void Dispose(); // 0x000000018D6D3FA8-0x000000018D6D4030
		public bool IsValid(); // 0x000000018D6D4100-0x000000018D6D4140
		public NativeArray<byte> GetData(); // 0x000000018D6D4030-0x000000018D6D4100
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 91230
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 91231
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 91232
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 91233
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 91234
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 91235
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 91236
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 91229
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 91240
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018D6D3DC4-0x000000018D6D3E28
	
		// Methods
		public StreamingSourceData __Gen_Wrap_0(Vector2 P0, float P1, float P2, float P3, float P4, float P5, float P6, float P7, float P8, float P9, float P10, float P11, NativeArray<byte> P12); // 0x000000018D6D34C8-0x000000018D6D371C
		public void __Gen_Wrap_1(IntPtr P0, IntPtr P1, long P2); // 0x000000018D6D371C-0x000000018D6D3808
		public IntPtr __Gen_Wrap_2(long P0, int P1, Unity.Collections.Allocator P2); // 0x000000018D6D3808-0x000000018D6D3900
		public void __Gen_Wrap_3(IntPtr P0, Unity.Collections.Allocator P1); // 0x000000018D6D3900-0x000000018D6D39D0
		public void __Gen_Wrap_4(ref VFSReadOperation P0); // 0x000000018D6D39D0-0x000000018D6D3B08
		public bool __Gen_Wrap_5(ref VFSReadOperation P0); // 0x000000018D6D3B08-0x000000018D6D3C50
		public NativeArray<byte> __Gen_Wrap_6(ref VFSReadOperation P0); // 0x000000018D6D3C50-0x000000018D6D3DC4
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 91241
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018D6D3E28-0x000000018D6D3EC0
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 91242
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018D6D449C-0x000000018D6D4500
		public static bool IsPatched(int id); // 0x000000018D6D458C-0x000000018D6D4608
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018D6D4354-0x000000018D6D4420
		public object CreateWrapper(int id); // 0x000000018D6D4420-0x000000018D6D449C
		public object InitWrapperArray(int len); // 0x000000018D6D4500-0x000000018D6D458C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018D6D42B0-0x000000018D6D4354
	}

	public delegate StreamingSourceData __HotPatchDelegate_0(Vector2 P0, float P1, float P2, float P3, float P4, float P5, float P6, float P7, float P8, float P9, float P10, float P11, NativeArray<byte> P12); // TypeDefIndex: 91243; 0x0000000187A9AF6C-0x0000000187A9B070

	public enum HotPatchIDMAP0 // TypeDefIndex: 91244
	{
		Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-CreateStreamingSourceData0 = 0,
		Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-MemCpyUnsafe0 = 1,
		Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-MallocUnsafe0 = 2,
		Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-FreeUnsafe0 = 3,
		Beyond-Gameplay-Streaming-VFSReadOperation-Dispose0 = 4,
		Beyond-Gameplay-Streaming-VFSReadOperation-IsValid0 = 5,
		Beyond-Gameplay-Streaming-VFSReadOperation-GetData0 = 6
	}

	public delegate void __HotPatchDelegate_1(IntPtr P0, IntPtr P1, long P2); // TypeDefIndex: 91245; 0x00000001811DF7F0-0x00000001811DF810

	public delegate IntPtr __HotPatchDelegate_2(long P0, int P1, Unity.Collections.Allocator P2); // TypeDefIndex: 91246; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_3(IntPtr P0, Unity.Collections.Allocator P1); // TypeDefIndex: 91247; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_4(ref VFSReadOperation P0); // TypeDefIndex: 91248; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_5(ref VFSReadOperation P0); // TypeDefIndex: 91249; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate NativeArray<byte> __HotPatchDelegate_6(ref VFSReadOperation P0); // TypeDefIndex: 91250; 0x0000000186464680-0x00000001864646B0
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 91227
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 91228
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
