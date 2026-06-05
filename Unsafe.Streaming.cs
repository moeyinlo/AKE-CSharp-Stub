/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Beyond.Gameplay.Streaming;
using Beyond.VFS;
using IFix.Core;
using Unity.Collections;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.HyperGryph.Streaming;

// Image 131: Unsafe.Streaming.dll - Assembly: Unsafe.Streaming, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61143-61158

namespace Beyond.Gameplay.Streaming
{
	public static class StreamingUnsafeUtilsV2 // TypeDefIndex: 61152
	{
		// Fields
		public static int s_defaultSceneStateId; // 0x00
		public static int s_defaultAreaId; // 0x04
	
		// Methods
		public static StreamingSourceData CreateStreamingSourceData(Vector2 streamingPos, float chunkLoadRadius, float defaultLayerLoadRadius, float hlod0LayerLoadRadius, float hlod1LayerLoadRadius, float hlod2LayerLoadRadius, float colliderLayerLoadRadius, float tinyLayerLoadRadius, float waterLayerLoadRadius, float lightingLoadRadius, float audioLoadRadius, NativeArray<byte> layerEnabled) => default; // 0x0000000184DD7CC0-0x0000000184DD7EB0
		public static void MemSet<T>(NativeArray<T> array, byte value, int count)
			where T : struct {}
		public static Span<T> AsSpan<T>(NativeArray<T> nativeArray)
			where T : struct => default;
		public static ReadOnlySpan<T> AsReadOnlySpan<T>(NativeArray<T> nativeArray)
			where T : struct => default;
		public static void MemCpyUnsafe(IntPtr destination, IntPtr source, long size) {} // 0x000000018C0BF214-0x000000018C0BF28C
		public static IntPtr MallocUnsafe(long size, int alignment, Unity.Collections.Allocator allocator) => default; // 0x000000018C0BF1A0-0x000000018C0BF214
		public static void FreeUnsafe(IntPtr memory, Unity.Collections.Allocator allocator) {} // 0x000000018C0BF140-0x000000018C0BF1A0
		public static byte[] ConvertToBytes<T>(T val)
			where T : struct => default;
		public static IntPtr GetIntPtr<T>(NativeArray<T> array)
			where T : struct => default;
		public static IntPtr GetReadonlyIntPtr<T>(NativeArray<T> array)
			where T : struct => default;
		public static UIntPtr GetReadonlyUIntPtr<T>(NativeArray<T> array)
			where T : struct => default;
		public static IntPtr GetRendererInfos<T>(ref ref T kComponent)
			where T : struct, IRenderObjectKComponent => default;
		public static ref UnityEngine.HyperGryph.ECS.RendererInfo GetRendererInfo(IntPtr rendererInfos, int index) => ref _refReturnTypeForGetRendererInfo; // 0x0000000185FDF9D0-0x0000000185FDF9E0
		private ref UnityEngine.HyperGryph.ECS.RendererInfo _refReturnTypeForGetRendererInfo; // Dummy field
		public static TTo ReinterpretAs<TFrom, TTo>(TFrom val)
			where TFrom : struct
			where TTo : struct => default;
	}

	public struct UnsafeArray<T> : IDisposable // TypeDefIndex: 61153
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
		public UnsafeArray(int count, Unity.Collections.Allocator allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x020839B8 */) : this() {
			ptr = default;
			this.count = default;
			this.allocator = default;
		}
	
		// Methods
		public T GetValue(int index) => default;
		public ref ref T GetRef(int index) => ref _refReturnTypeForGetRef;
		private ref T _refReturnTypeForGetRef; // Dummy field
		public void SetValue(int index, T value) {}
		public void Resize(int newCount, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x020839B9 */) {}
		public void Dispose() {}
	}

	public struct VFSReadOperation : IDisposable // TypeDefIndex: 61154
	{
		// Fields
		public unsafe ReadCommand* readCommand; // 0x00
		public ReadHandle readHandle; // 0x08
	
		// Constructors
		public unsafe VFSReadOperation(FVFBlockFileInfo info, bool async) {
			readCommand = default;
			readHandle = default;
		} // 0x000000018C0BF420-0x000000018C0BF588
	
		// Methods
		public void Dispose() {} // 0x000000018C0BF28C-0x000000018C0BF310
		public bool IsValid() => default; // 0x000000018C0BF3D0-0x000000018C0BF420
		public NativeArray<byte> GetData() => default; // 0x000000018C0BF310-0x000000018C0BF3D0
	}
}

namespace Beyond.SourceGenerator
{
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 61147
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 61148
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 61149
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 61150
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 61151
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 61146
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 61155
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F644E0-0x0000000185F64550
	
		// Methods
		public StreamingSourceData __Gen_Wrap_0(Vector2 P0, float P1, float P2, float P3, float P4, float P5, float P6, float P7, float P8, float P9, float P10, NativeArray<byte> P11) => default; // 0x000000018C0BE7E0-0x000000018C0BEA28
		public void __Gen_Wrap_1(IntPtr P0, IntPtr P1, long P2) {} // 0x000000018C0BEA28-0x000000018C0BEB0C
		public IntPtr __Gen_Wrap_2(long P0, int P1, Unity.Collections.Allocator P2) => default; // 0x000000018C0BEB0C-0x000000018C0BEBFC
		public void __Gen_Wrap_3(IntPtr P0, Unity.Collections.Allocator P1) {} // 0x000000018C0BEBFC-0x000000018C0BECC4
		public void __Gen_Wrap_4(ref VFSReadOperation P0) {} // 0x000000018C0BECC4-0x000000018C0BEDF8
		public bool __Gen_Wrap_5(ref VFSReadOperation P0) => default; // 0x000000018C0BEDF8-0x000000018C0BEF3C
		public NativeArray<byte> __Gen_Wrap_6(ref VFSReadOperation P0) => default; // 0x000000018C0BEF3C-0x000000018C0BF0AC
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 61156
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018C0BF0AC-0x000000018C0BF140
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 61157
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018C0BF770-0x000000018C0BF7D4
		public static bool IsPatched(int id) => default; // 0x0000000184DD7EB0-0x0000000184DD7F20
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018C0BF62C-0x000000018C0BF6F8
		public object CreateWrapper(int id) => default; // 0x000000018C0BF6F8-0x000000018C0BF770
		public object InitWrapperArray(int len) => default; // 0x000000018C0BF7D4-0x000000018C0BF860
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018C0BF588-0x000000018C0BF62C
	}

	public enum IDMAP0 // TypeDefIndex: 61158
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

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 61144
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 61145
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
