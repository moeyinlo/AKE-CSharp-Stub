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

// Image 133: Unsafe.Streaming.dll - Assembly: Unsafe.Streaming, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63779-63794
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.Gameplay.Streaming
{
	public static class StreamingUnsafeUtilsV2 // TypeDefIndex: 63788
	{
		// Fields
		public static int s_defaultSceneStateId; // 0x00
		public static int s_defaultAreaId; // 0x04
	
		// Methods
		public static StreamingSourceData CreateStreamingSourceData(Vector2 streamingPos, float chunkLoadRadius, float defaultLayerLoadRadius, float hlod0LayerLoadRadius, float hlod1LayerLoadRadius, float hlod2LayerLoadRadius, float colliderLayerLoadRadius, float tinyLayerLoadRadius, float waterLayerLoadRadius, float lightingLoadRadius, float audioLoadRadius, float rendererWithColliderLoadRadius, NativeArray<byte> layerEnabled); // 0x0000000182ED52D0-0x0000000182ED60A0
		public static void MemSet<T>(NativeArray<T> array, byte value, int count)
			where T : struct;
		public static void MemCpyUnsafe(IntPtr destination, IntPtr source, long size); // 0x000000018B5AB1A0-0x000000018B5AB218
		public static IntPtr MallocUnsafe(long size, int alignment, Unity.Collections.Allocator allocator); // 0x000000018B5AB12C-0x000000018B5AB1A0
		public static void FreeUnsafe(IntPtr memory, Unity.Collections.Allocator allocator); // 0x000000018B5AB0CC-0x000000018B5AB12C
		public static ref UnityEngine.HyperGryph.ECS.RendererInfo GetRendererInfo(IntPtr rendererInfos, int index); // 0x0000000184DB3AC0-0x0000000184DB3AD0
	
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

	public struct UnsafeArray<T> : IDisposable // TypeDefIndex: 63789
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
		public UnsafeArray(int count, Unity.Collections.Allocator allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x02353638 */);
	
		// Methods
		public T GetValue(int index);
		public ref ref T GetRef(int index);
		public void SetValue(int index, T value);
		public void Resize(int newCount, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory /* Metadata: 0x02353639 */);
		public void Dispose();
	}

	public struct VFSReadOperation : IDisposable // TypeDefIndex: 63790
	{
		// Fields
		public unsafe ReadCommand* readCommand; // 0x00
		public ReadHandle readHandle; // 0x08
	
		// Constructors
		public unsafe VFSReadOperation(FVFBlockFileInfo info, bool async); // 0x000000018B5AB3AC-0x000000018B5AB514
	
		// Methods
		public void Dispose(); // 0x000000018B5AB218-0x000000018B5AB29C
		public bool IsValid(); // 0x000000018B5AB35C-0x000000018B5AB3AC
		public NativeArray<byte> GetData(); // 0x000000018B5AB29C-0x000000018B5AB35C
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 63783
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 63784
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 63785
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 63786
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 63787
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 63782
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63791
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37560-0x0000000184D375D0
	
		// Methods
		public StreamingSourceData __Gen_Wrap_0(Vector2 P0, float P1, float P2, float P3, float P4, float P5, float P6, float P7, float P8, float P9, float P10, float P11, NativeArray<byte> P12); // 0x0000000182ED4350-0x0000000182ED52D0
		public void __Gen_Wrap_1(IntPtr P0, IntPtr P1, long P2); // 0x000000018B5AA9B4-0x000000018B5AAA98
		public IntPtr __Gen_Wrap_2(long P0, int P1, Unity.Collections.Allocator P2); // 0x000000018B5AAA98-0x000000018B5AAB88
		public void __Gen_Wrap_3(IntPtr P0, Unity.Collections.Allocator P1); // 0x000000018B5AAB88-0x000000018B5AAC50
		public void __Gen_Wrap_4(ref VFSReadOperation P0); // 0x000000018B5AAC50-0x000000018B5AAD84
		public bool __Gen_Wrap_5(ref VFSReadOperation P0); // 0x000000018B5AAD84-0x000000018B5AAEC8
		public NativeArray<byte> __Gen_Wrap_6(ref VFSReadOperation P0); // 0x000000018B5AAEC8-0x000000018B5AB038
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63792
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018B5AB038-0x000000018B5AB0CC
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63793
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018B5AB6FC-0x000000018B5AB760
		public static bool IsPatched(int id); // 0x0000000183EE5230-0x0000000183EE5280
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018B5AB5B8-0x000000018B5AB684
		public object CreateWrapper(int id); // 0x000000018B5AB684-0x000000018B5AB6FC
		public object InitWrapperArray(int len); // 0x000000018B5AB760-0x000000018B5AB7EC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018B5AB514-0x000000018B5AB5B8
	}

	public enum IDMAP0 // TypeDefIndex: 63794
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
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 63780
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 63781
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
