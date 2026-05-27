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
using Unity.Collections;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.HyperGryph.Streaming;

// Image 128: Unsafe.Streaming.dll - Assembly: Unsafe.Streaming, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60038-60053
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Gameplay.Streaming
{
	public static class StreamingUnsafeUtilsV2 // TypeDefIndex: 60047
	{
		// Fields
		public static int s_defaultSceneStateId; // 0x00
		public static int s_defaultAreaId; // 0x04
	
		// Methods
		public static StreamingSourceData CreateStreamingSourceData(Vector2 streamingPos, float chunkLoadRadius, float defaultLayerLoadRadius, float hlod0LayerLoadRadius, float hlod1LayerLoadRadius, float hlod2LayerLoadRadius, float colliderLayerLoadRadius, float tinyLayerLoadRadius, float waterLayerLoadRadius, float lightingLoadRadius, float audioLoadRadius, NativeArray<byte> layerEnabled) => default; // 0x000000018279F430-0x000000018279F620
		public static void MemSet<T>(NativeArray<T> array, byte value, int count)
			where T : struct {}
		public static void MemCpyUnsafe(IntPtr destination, IntPtr source, long size) {} // 0x0000000189FA7154-0x0000000189FA71CC
		public static IntPtr MallocUnsafe(long size, int alignment, Unity.Collections.Allocator allocator) => default; // 0x0000000189FA70E0-0x0000000189FA7154
		public static void FreeUnsafe(IntPtr memory, Unity.Collections.Allocator allocator) {} // 0x0000000189FA7080-0x0000000189FA70E0
		public static ref UnityEngine.HyperGryph.ECS.RendererInfo GetRendererInfo(IntPtr rendererInfos, int index) => ref _refReturnTypeForGetRendererInfo; // 0x0000000183D7ED40-0x0000000183D7ED50
		private ref UnityEngine.HyperGryph.ECS.RendererInfo _refReturnTypeForGetRendererInfo; // Dummy field
	
		// Extension methods
		public static Span<T> AsSpan<T>(this NativeArray<T> nativeArray)
			where T : struct => default;
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(this NativeArray<T> nativeArray)
			where T : struct => default;
		public static byte[] ConvertToBytes<T>(this T val)
			where T : struct => default;
		public static IntPtr GetIntPtr<T>(this NativeArray<T> array)
			where T : struct => default;
		public static IntPtr GetReadonlyIntPtr<T>(this NativeArray<T> array)
			where T : struct => default;
		public static UIntPtr GetReadonlyUIntPtr<T>(this NativeArray<T> array)
			where T : struct => default;
		public static IntPtr GetRendererInfos<T>(this ref ref T kComponent)
			where T : struct, IRenderObjectKComponent => default;
		public static TTo ReinterpretAs<TFrom, TTo>(this TFrom val)
			where TFrom : struct
			where TTo : struct => default;
	}

	public struct UnsafeArray<T> : IDisposable // TypeDefIndex: 60048
		where T : struct
	{
		// Fields
		public IntPtr ptr;
		public int count;
		public Unity.Collections.Allocator allocator;
	
		// Properties
		public bool IsCreated { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public UnsafeArray(int count, Unity.Collections.Allocator allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x01FDE0CC */) : this() {
			ptr = default;
			this.count = default;
			this.allocator = default;
		}
	
		// Methods
		public T GetValue(int index) => default;
		public ref ref T GetRef(int index) => ref _refReturnTypeForGetRef;
		private ref T _refReturnTypeForGetRef; // Dummy field
		public void SetValue(int index, T value) {}
		public void Resize(int newCount, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x01FDE0CD */) {}
		public void Dispose() {}
	}

	public struct VFSReadOperation : IDisposable // TypeDefIndex: 60049
	{
		// Fields
		public unsafe ReadCommand* readCommand; // 0x00
		public ReadHandle readHandle; // 0x08
	
		// Constructors
		public unsafe VFSReadOperation(FVFBlockFileInfo info, bool async) {
			readCommand = default;
			readHandle = default;
		} // 0x0000000189FA7360-0x0000000189FA74B8
	
		// Methods
		public void Dispose() {} // 0x0000000189FA71CC-0x0000000189FA7250
		public bool IsValid() => default; // 0x0000000189FA7310-0x0000000189FA7360
		public NativeArray<byte> GetData() => default; // 0x0000000189FA7250-0x0000000189FA7310
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 60042
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 60043
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 60044
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 60045
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 60046
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 60041
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60050
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05BF0-0x0000000183D05C60
	
		// Methods
		public StreamingSourceData __Gen_Wrap_0(Vector2 P0, float P1, float P2, float P3, float P4, float P5, float P6, float P7, float P8, float P9, float P10, NativeArray<byte> P11) => default; // 0x0000000189FA6720-0x0000000189FA6968
		public void __Gen_Wrap_1(IntPtr P0, IntPtr P1, long P2) {} // 0x0000000189FA6968-0x0000000189FA6A4C
		public IntPtr __Gen_Wrap_2(long P0, int P1, Unity.Collections.Allocator P2) => default; // 0x0000000189FA6A4C-0x0000000189FA6B3C
		public void __Gen_Wrap_3(IntPtr P0, Unity.Collections.Allocator P1) {} // 0x0000000189FA6B3C-0x0000000189FA6C04
		public void __Gen_Wrap_4(ref VFSReadOperation P0) {} // 0x0000000189FA6C04-0x0000000189FA6D38
		public bool __Gen_Wrap_5(ref VFSReadOperation P0) => default; // 0x0000000189FA6D38-0x0000000189FA6E7C
		public NativeArray<byte> __Gen_Wrap_6(ref VFSReadOperation P0) => default; // 0x0000000189FA6E7C-0x0000000189FA6FEC
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60051
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000189FA6FEC-0x0000000189FA7080
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60052
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000189FA76A0-0x0000000189FA7704
		public static bool IsPatched(int id) => default; // 0x0000000183132F60-0x00000001831330B0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000189FA755C-0x0000000189FA7628
		public object CreateWrapper(int id) => default; // 0x0000000189FA7628-0x0000000189FA76A0
		public object InitWrapperArray(int len) => default; // 0x0000000189FA7704-0x0000000189FA7790
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000189FA74B8-0x0000000189FA755C
	}

	public enum IDMAP0 // TypeDefIndex: 60053
	{
		Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-CreateStreamingSourceData0 = 0,
		Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-MemCpyUnsafe0 = 1,
		Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-MallocUnsafe0 = 2,
		Beyond-Gameplay-Streaming-StreamingUnsafeUtilsV2-FreeUnsafe0 = 3,
		Beyond-Gameplay-Streaming-VFSReadOperation-Dispose0 = 4,
		Beyond-Gameplay-Streaming-VFSReadOperation-IsValid0 = 5,
		Beyond-Gameplay-Streaming-VFSReadOperation-GetData0 = 6
	}
}
