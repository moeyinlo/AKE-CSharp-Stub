/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using Beyond.Gameplay.Core;
using IFix.Core;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering;

// Image 105: SkeletalUnsafe.Gameplay.Beyond.dll - Assembly: SkeletalUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63282-63305
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__285717778 // TypeDefIndex: 63301
{
	// Methods
	public static void CreateJobReflectionData(); // 0x0000000182E86550-0x0000000182E86D60
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit(); // 0x0000000182E86D60-0x0000000182E8C370
}

namespace Beyond.Gameplay.Core
{
	public static class NativeArrayExtensions // TypeDefIndex: 63285
	{
		// Methods
		public static void FastCopy<T>(NativeArray<T> src, NativeArray<T> dst)
			where T : struct;
	}

	public static class SkeletalMorphUnsafeJobDefines // TypeDefIndex: 63289
	{
		// Nested types
		public static class SimpleWriteLock // TypeDefIndex: 63286
		{
			// Methods
			public static bool EnterLock(NativeArray<int> lockFlag, int maxSpinCount = 10000 /* Metadata: 0x02352767 */); // 0x000000018AC4DE38-0x000000018AC4DEEC
			public static void MainThreadEnterLock(NativeArray<int> lockFlag, int millisecondsTimeout = 500 /* Metadata: 0x0235276B */, int spinBeforeTiming = 1000 /* Metadata: 0x0235276D */); // 0x00000001835B4EC0-0x00000001835B5020
			public static void ExitLock(NativeArray<int> lockFlag); // 0x00000001835B5020-0x00000001835B5050
		}
	
		[BurstCompile]
		public struct TrackerLock : IJob // TypeDefIndex: 63287
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> flag; // 0x00
			[NativeDisableParallelForRestriction]
			public bool isEnter; // 0x10
	
			// Methods
			public void Execute(); // 0x000000018AC4E0B4-0x000000018AC4E128
		}
	
		[BurstCompile]
		public struct ApplyBoneToAnimatorTransJob : IJob // TypeDefIndex: 63288
		{
			// Fields
			[ReadOnly]
			public bool runtime_writeNoDirty; // 0x00
			[ReadOnly]
			public float runtime_applyWeight; // 0x04
			[NativeDisableParallelForRestriction]
			public NativeArray<FBoneRuntimeData> runtime_allBoneBasePose; // 0x08
			[NativeDisableParallelForRestriction]
			public NativeArray<FBoneRuntimeData> runtime_allBonePose; // 0x18
			[NativeDisableUnsafePtrRestriction]
			public AnimationTransformRWBufferHandle runtime_allBonesTransformRWBufferHandle; // 0x28
	
			// Methods
			public void Execute(); // 0x000000018AC4A844-0x000000018AC4AAC4
			public static void CleanAnimatorTransJob(AnimationTransformRWBufferHandle rwHandler); // 0x00000001845A6050-0x00000001845A60C0
			public static void SetAnimatorTransPhysicsRatioPtr(AnimationTransformRWBufferHandle rwHandler, float value); // 0x00000001835B5050-0x00000001835B50E0
		}
	}

	public struct FSkeletalMorphShaderPropMappingData // TypeDefIndex: 63290
	{
		// Fields
		public int vectorIndex; // 0x00
		public ShaderPropertyType propertyType; // 0x04
		public int paramNameID; // 0x08
		public int paramRuntimeIdx; // 0x0C
	}

	public struct FBoneRuntimeData // TypeDefIndex: 63291
	{
		// Fields
		public Vector3 pos; // 0x00
		public Vector3 rot; // 0x0C
		public Vector3 sca; // 0x18
		public bool bIsDirty; // 0x24
	
		// Methods
		public override string ToString(); // 0x000000018AC4AAC4-0x000000018AC4ABD8
		public string __iFixBaseProxy_ToString(); // 0x000000018AC4ABD8-0x000000018AC4AC3C
	}

	public struct FSkeletalMorphBoneData // TypeDefIndex: 63292
	{
		// Fields
		public int boneNameHash; // 0x00
		public int boneID; // 0x04
		public Vector3 position; // 0x08
		public Vector3 rotation; // 0x14
		public Vector3 scale; // 0x20
	}

	[Flags]
	public enum EMorphPartType // TypeDefIndex: 63293
	{
		None = 0,
		REyeMorphs = 1,
		LEyeMorphs = 2,
		RBrowMorphs = 4,
		LBrowMorphs = 8,
		MouthMorphs = 16,
		Other = 32,
		LEar = 64,
		REar = 128,
		All = 255
	}

	public struct FSkeletalMorphMappingData // TypeDefIndex: 63294
	{
		// Fields
		public int id; // 0x00
		public int nameHash; // 0x04
		public int tagHash; // 0x08
		public EMorphPartType partType; // 0x0C
		public int boneOffset; // 0x10
		public int boneLen; // 0x14
		public unsafe FSkeletalMorphBoneData* bones; // 0x18
		public bool bIsShaderProp; // 0x20
		public static FSkeletalMorphMappingData s_defaultMappingData; // 0x00
	
		// Constructors
		static FSkeletalMorphMappingData(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public bool IsValid(); // 0x000000018AC4AF30-0x000000018AC4AF7C
		public FSkeletalMorphBoneData GetBoneData(int idx); // 0x000000018AC4AE24-0x000000018AC4AF30
		public void SetMapping(NativeArray<FSkeletalMorphBoneData> bigList, int bonesOffset, int bonesLen); // 0x00000001835B4500-0x00000001835B4590
	}

	public struct PtrList<T> // TypeDefIndex: 63295
		where T : struct
	{
		// Fields
		public int len;
		public unsafe T* data;
	}

	public struct FSkeletalMorphAnim // TypeDefIndex: 63296
	{
		// Fields
		public static FSkeletalMorphAnim INVALID; // 0x00
		public int animSoTagID; // 0x00
		public float duration; // 0x04
		public bool bIsAdditiveClip; // 0x08
		public bool bIsOverride; // 0x09
		public bool bIsPauseAutoBlink; // 0x0A
		public bool bIsPoseAnim; // 0x0B
		public PtrList<FMorphCtrlCurve> eyeCurveR; // 0x10
		public PtrList<FMorphCtrlCurve> eyeCurveL; // 0x20
		public PtrList<FMorphCtrlCurve> browCurveR; // 0x30
		public PtrList<FMorphCtrlCurve> browCurveL; // 0x40
		public PtrList<FMorphCtrlCurve> mouthCurve; // 0x50
		public PtrList<FMorphCtrlCurve> otherCurve; // 0x60
		public PtrList<FMorphCtrlCurve> lEarCurve; // 0x70
		public PtrList<FMorphCtrlCurve> rEarCurve; // 0x80
	
		// Constructors
		static FSkeletalMorphAnim(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public bool IsValid(); // 0x00000001835B4E00-0x00000001835B4E70
		public NativeArray<FMorphCtrlCurve> Create(EMorphPartType partType, int curveLen); // 0x00000001842EA200-0x00000001842EA300
		public bool GetCurveData(EMorphPartType partType, int idx, out FMorphCtrlCurve curve); // 0x000000018AC4AC3C-0x000000018AC4AD7C
		public int GetCurveLen(EMorphPartType partType); // 0x000000018AC4AD7C-0x000000018AC4AE24
		public void SetCurveData(EMorphPartType partType, int idx, ref FMorphCtrlCurve curve); // 0x00000001835B52C0-0x00000001835B53E0
	}

	public struct FMorphCtrlCurve // TypeDefIndex: 63297
	{
		// Fields
		public const int RESOLUTION = 30; // Metadata: 0x0235277C
		public int ctrlNameHash; // 0x00
		public FPtrAnimNativeCurve curve; // 0x08
	
		// Methods
		[IDTag(0)]
		public NativeArray<Keyframe> Create(string name, AnimationCurve animCurve, Unity.Collections.Allocator allocator); // 0x0000000183B04FB0-0x0000000183B05050
		[IDTag(1)]
		public NativeArray<Keyframe> Create(string name, float poseVal, Unity.Collections.Allocator allocator); // 0x000000018419EF50-0x000000018419F010
	}

	public struct FSkeletalMorphPose // TypeDefIndex: 63298
	{
		// Fields
		public static FSkeletalMorphPose INVALID; // 0x00
		public PtrList<FMorphCtrlValue> eyeValueR; // 0x00
		public PtrList<FMorphCtrlValue> eyeValueL; // 0x10
		public PtrList<FMorphCtrlValue> browValueR; // 0x20
		public PtrList<FMorphCtrlValue> browValueL; // 0x30
		public PtrList<FMorphCtrlValue> mouthValue; // 0x40
		public PtrList<FMorphCtrlValue> otherValue; // 0x50
		public bool bIsAdditivePose; // 0x60
	
		// Constructors
		static FSkeletalMorphPose(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public bool IsValid(); // 0x000000018AC4B2A4-0x000000018AC4B318
		public int AllCurveNum(); // 0x000000018AC4AF7C-0x000000018AC4AFD4
		public NativeArray<FMorphCtrlValue> Create(EMorphPartType partType, int curveLen); // 0x000000018AC4AFD4-0x000000018AC4B128
		public bool GetValueData(EMorphPartType partType, int idx, out FMorphCtrlValue curve); // 0x000000018AC4B128-0x000000018AC4B214
		public int GetValueLen(EMorphPartType partType); // 0x000000018AC4B214-0x000000018AC4B2A4
		public void SetValueData(EMorphPartType partType, int idx, ref FMorphCtrlValue curve); // 0x000000018AC4B318-0x000000018AC4B3F4
	}

	public struct FMorphCtrlValue // TypeDefIndex: 63299
	{
		// Fields
		public int ctrlNameHash; // 0x00
		public float value; // 0x04
	}

	public static class SkeletalMorphUnsafeJobUtils // TypeDefIndex: 63300
	{
		// Methods
		public static ref ref T GetUnsafeElementRef<T>(NativeArray<T> array, int idx)
			where T : struct;
		public static void SetUnsafeElementRef<T>(NativeArray<T> array, int idx, ref ref T val)
			where T : struct;
		public static Quaternion FromMaya(Vector3 eulerAngle); // 0x000000018AC4DEEC-0x000000018AC4E0B4
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 63302
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37090-0x0000000184D37100
	
		// Methods
		public bool __Gen_Wrap_0(NativeArray<int> P0, int P1); // 0x000000018AC4B3F4-0x000000018AC4B500
		public void __Gen_Wrap_1(NativeArray<int> P0, int P1, int P2); // 0x000000018AC4C890-0x000000018AC4C9BC
		public void __Gen_Wrap_2(NativeArray<int> P0); // 0x000000018AC4D344-0x000000018AC4D43C
		public void __Gen_Wrap_3(ref SkeletalMorphUnsafeJobDefines.TrackerLock P0); // 0x000000018AC4D43C-0x000000018AC4D570
		public Quaternion __Gen_Wrap_4(Vector3 P0); // 0x000000018AC4D570-0x000000018AC4D698
		public void __Gen_Wrap_5(ref SkeletalMorphUnsafeJobDefines.ApplyBoneToAnimatorTransJob P0); // 0x000000018AC4D698-0x000000018AC4D874
		public void __Gen_Wrap_6(AnimationTransformRWBufferHandle P0); // 0x000000018AC4D874-0x000000018AC4D99C
		public void __Gen_Wrap_7(AnimationTransformRWBufferHandle P0, float P1); // 0x000000018AC4D99C-0x000000018AC4DAEC
		public string __Gen_Wrap_8(ref FBoneRuntimeData P0); // 0x000000018AC4DAEC-0x000000018AC4DC50
		public bool __Gen_Wrap_9(ref FSkeletalMorphMappingData P0); // 0x000000018AC4DC50-0x000000018AC4DDA4
		public FSkeletalMorphBoneData __Gen_Wrap_10(ref FSkeletalMorphMappingData P0, int P1); // 0x000000018AC4B500-0x000000018AC4B6B4
		public void __Gen_Wrap_11(ref FSkeletalMorphMappingData P0, NativeArray<FSkeletalMorphBoneData> P1, int P2, int P3); // 0x000000018AC4B6B4-0x000000018AC4B874
		public bool __Gen_Wrap_12(ref FSkeletalMorphAnim P0); // 0x000000018AC4B874-0x000000018AC4BA64
		public NativeArray<FMorphCtrlCurve> __Gen_Wrap_13(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2); // 0x000000018AC4BA64-0x000000018AC4BCA4
		public bool __Gen_Wrap_14(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2, out FMorphCtrlCurve P3); // 0x000000018AC4BCA4-0x000000018AC4BF04
		public int __Gen_Wrap_15(ref FSkeletalMorphAnim P0, EMorphPartType P1); // 0x000000018AC4BF04-0x000000018AC4C0F8
		public void __Gen_Wrap_16(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2, ref FMorphCtrlCurve P3); // 0x000000018AC4C0F8-0x000000018AC4C38C
		public NativeArray<Keyframe> __Gen_Wrap_17(ref FMorphCtrlCurve P0, object P1, object P2, Unity.Collections.Allocator P3); // 0x000000018AC4C38C-0x000000018AC4C544
		public NativeArray<Keyframe> __Gen_Wrap_18(ref FMorphCtrlCurve P0, object P1, float P2, Unity.Collections.Allocator P3); // 0x000000018AC4C544-0x000000018AC4C6FC
		public bool __Gen_Wrap_19(ref FSkeletalMorphPose P0); // 0x000000018AC4C6FC-0x000000018AC4C890
		public int __Gen_Wrap_20(ref FSkeletalMorphPose P0); // 0x000000018AC4C9BC-0x000000018AC4CB50
		public NativeArray<FMorphCtrlValue> __Gen_Wrap_21(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2); // 0x000000018AC4CB50-0x000000018AC4CD4C
		public bool __Gen_Wrap_22(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2, out FMorphCtrlValue P3); // 0x000000018AC4CD4C-0x000000018AC4CF64
		public int __Gen_Wrap_23(ref FSkeletalMorphPose P0, EMorphPartType P1); // 0x000000018AC4CF64-0x000000018AC4D114
		public void __Gen_Wrap_24(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2, ref FMorphCtrlValue P3); // 0x000000018AC4D114-0x000000018AC4D344
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 63303
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018AC4DDA4-0x000000018AC4DE38
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 63304
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018AC4E310-0x000000018AC4E374
		public static bool IsPatched(int id); // 0x00000001835B4E70-0x00000001835B4EC0
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018AC4E1CC-0x000000018AC4E298
		public object CreateWrapper(int id); // 0x000000018AC4E298-0x000000018AC4E310
		public object InitWrapperArray(int len); // 0x000000018AC4E374-0x000000018AC4FD60
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018AC4E128-0x000000018AC4E1CC
	}

	public enum IDMAP0 // TypeDefIndex: 63305
	{
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-EnterLock0 = 0,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-MainThreadEnterLock0 = 1,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-ExitLock0 = 2,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-TrackerLock-Execute0 = 3,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-Execute0 = 4,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobUtils-FromMaya0 = 5,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-CleanAnimatorTransJob0 = 6,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-SetAnimatorTransPhysicsRatioPtr0 = 7,
		Beyond-Gameplay-Core-FBoneRuntimeData-ToString0 = 8,
		Beyond-Gameplay-Core-FSkeletalMorphMappingData-IsValid0 = 9,
		Beyond-Gameplay-Core-FSkeletalMorphMappingData-GetBoneData0 = 10,
		Beyond-Gameplay-Core-FSkeletalMorphMappingData-SetMapping0 = 11,
		Beyond-Gameplay-Core-FSkeletalMorphAnim-IsValid0 = 12,
		Beyond-Gameplay-Core-FSkeletalMorphAnim-Create0 = 13,
		Beyond-Gameplay-Core-FSkeletalMorphAnim-GetCurveData0 = 14,
		Beyond-Gameplay-Core-FSkeletalMorphAnim-GetCurveLen0 = 15,
		Beyond-Gameplay-Core-FSkeletalMorphAnim-SetCurveData0 = 16,
		Beyond-Gameplay-Core-FMorphCtrlCurve-Create0 = 17,
		Beyond-Gameplay-Core-FMorphCtrlCurve-Create1 = 18,
		Beyond-Gameplay-Core-FSkeletalMorphPose-IsValid0 = 19,
		Beyond-Gameplay-Core-FSkeletalMorphPose-AllCurveNum0 = 20,
		Beyond-Gameplay-Core-FSkeletalMorphPose-Create0 = 21,
		Beyond-Gameplay-Core-FSkeletalMorphPose-GetValueData0 = 22,
		Beyond-Gameplay-Core-FSkeletalMorphPose-GetValueLen0 = 23,
		Beyond-Gameplay-Core-FSkeletalMorphPose-SetValueData0 = 24
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 63283
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 63284
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
