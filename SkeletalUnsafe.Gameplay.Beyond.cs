/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using Beyond.Gameplay.Core;
using IFix.Core;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering;

// Image 99: SkeletalUnsafe.Gameplay.Beyond.dll - Assembly: SkeletalUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59526-59549
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2734917912 // TypeDefIndex: 59545
{
	// Constructors
	public __JobReflectionRegistrationOutput__2734917912() {} // Dummy constructor

	// Methods
	public static void CreateJobReflectionData() {} // 0x000000018227D630-0x000000018227DE40
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit() {} // 0x000000018227DE40-0x000000018228B0F0
}

namespace Beyond.Gameplay.Core
{
	public static class NativeArrayExtensions // TypeDefIndex: 59529
	{
		// Methods
		public static void FastCopy<T>(NativeArray<T> src, NativeArray<T> dst)
			where T : struct {}
	}

	public static class SkeletalMorphUnsafeJobDefines // TypeDefIndex: 59533
	{
		// Nested types
		public static class SimpleWriteLock // TypeDefIndex: 59530
		{
			// Methods
			public static bool EnterLock(NativeArray<int> lockFlag, int maxSpinCount = 10000 /* Metadata: 0x01FDD193 */) => default; // 0x000000018966E29C-0x000000018966E350
			public static void MainThreadEnterLock(NativeArray<int> lockFlag, int millisecondsTimeout = 500 /* Metadata: 0x01FDD197 */, int spinBeforeTiming = 1000 /* Metadata: 0x01FDD199 */) {} // 0x0000000182FABFA0-0x0000000182FAC120
			public static void ExitLock(NativeArray<int> lockFlag) {} // 0x0000000182FABF50-0x0000000182FABFA0
		}
	
		[BurstCompile]
		public struct TrackerLock : IJob // TypeDefIndex: 59531
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> flag; // 0x00
			[NativeDisableParallelForRestriction]
			public bool isEnter; // 0x10
	
			// Methods
			public void Execute() {} // 0x000000018966E518-0x000000018966E58C
		}
	
		[BurstCompile]
		public struct ApplyBoneToAnimatorTransJob : IJob // TypeDefIndex: 59532
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
			public void Execute() {} // 0x000000018966AD10-0x000000018966AF24
			public static void CleanAnimatorTransJob(AnimationTransformRWBufferHandle rwHandler) {} // 0x0000000182514AD0-0x0000000182514B20
			public static void SetAnimatorTransPhysicsRatioPtr(AnimationTransformRWBufferHandle rwHandler, float value) {} // 0x00000001829F8070-0x00000001829F8100
		}
	}

	public struct FSkeletalMorphShaderPropMappingData // TypeDefIndex: 59534
	{
		// Fields
		public int vectorIndex; // 0x00
		public ShaderPropertyType propertyType; // 0x04
		public int paramNameID; // 0x08
		public int paramRuntimeIdx; // 0x0C
	}

	public struct FBoneRuntimeData // TypeDefIndex: 59535
	{
		// Fields
		public Vector3 pos; // 0x00
		public Vector3 rot; // 0x0C
		public Vector3 sca; // 0x18
		public bool bIsDirty; // 0x24
	
		// Methods
		public override string ToString() => default; // 0x000000018966AF24-0x000000018966B038
		public string __iFixBaseProxy_ToString() => default; // 0x000000018966B038-0x000000018966B09C
	}

	public struct FSkeletalMorphBoneData // TypeDefIndex: 59536
	{
		// Fields
		public int boneNameHash; // 0x00
		public int boneID; // 0x04
		public Vector3 position; // 0x08
		public Vector3 rotation; // 0x14
		public Vector3 scale; // 0x20
	}

	[Flags]
	public enum EMorphPartType // TypeDefIndex: 59537
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

	public struct FSkeletalMorphMappingData // TypeDefIndex: 59538
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
		static FSkeletalMorphMappingData() {
			s_defaultMappingData = default;
		} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool IsValid() => default; // 0x000000018966B390-0x000000018966B3DC
		public FSkeletalMorphBoneData GetBoneData(int idx) => default; // 0x000000018966B284-0x000000018966B390
		public void SetMapping(NativeArray<FSkeletalMorphBoneData> bigList, int bonesOffset, int bonesLen) {} // 0x00000001829F2B10-0x00000001829F2B90
	}

	public struct PtrList<T> // TypeDefIndex: 59539
		where T : struct
	{
		// Fields
		public int len;
		public unsafe T* data;
	}

	public struct FSkeletalMorphAnim // TypeDefIndex: 59540
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
		static FSkeletalMorphAnim() {
			INVALID = default;
		} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool IsValid() => default; // 0x00000001829F2EF0-0x00000001829F2F80
		public NativeArray<FMorphCtrlCurve> Create(EMorphPartType partType, int curveLen) => default; // 0x0000000182CFCC30-0x0000000182CFCD60
		public bool GetCurveData(EMorphPartType partType, int idx, out FMorphCtrlCurve curve) {
			curve = default;
			return default;
		} // 0x000000018966B09C-0x000000018966B1DC
		public int GetCurveLen(EMorphPartType partType) => default; // 0x000000018966B1DC-0x000000018966B284
		public void SetCurveData(EMorphPartType partType, int idx, ref FMorphCtrlCurve curve) {} // 0x0000000182CFCB10-0x0000000182CFCC30
	}

	public struct FMorphCtrlCurve // TypeDefIndex: 59541
	{
		// Fields
		public const int RESOLUTION = 30; // Metadata: 0x01FDD1A8
		public int ctrlNameHash; // 0x00
		public FPtrAnimNativeCurve curve; // 0x08
	
		// Methods
		[IDTag(0)]
		public NativeArray<Keyframe> Create(string name, AnimationCurve animCurve, Unity.Collections.Allocator allocator) => default; // 0x0000000182FAC6A0-0x0000000182FAC760
		[IDTag(1)]
		public NativeArray<Keyframe> Create(string name, float poseVal, Unity.Collections.Allocator allocator) => default; // 0x0000000182CFBFB0-0x0000000182CFC070
	}

	public struct FSkeletalMorphPose // TypeDefIndex: 59542
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
		static FSkeletalMorphPose() {
			INVALID = default;
		} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool IsValid() => default; // 0x000000018966B704-0x000000018966B778
		public int AllCurveNum() => default; // 0x000000018966B3DC-0x000000018966B434
		public NativeArray<FMorphCtrlValue> Create(EMorphPartType partType, int curveLen) => default; // 0x000000018966B434-0x000000018966B588
		public bool GetValueData(EMorphPartType partType, int idx, out FMorphCtrlValue curve) {
			curve = default;
			return default;
		} // 0x000000018966B588-0x000000018966B674
		public int GetValueLen(EMorphPartType partType) => default; // 0x000000018966B674-0x000000018966B704
		public void SetValueData(EMorphPartType partType, int idx, ref FMorphCtrlValue curve) {} // 0x000000018966B778-0x000000018966B854
	}

	public struct FMorphCtrlValue // TypeDefIndex: 59543
	{
		// Fields
		public int ctrlNameHash; // 0x00
		public float value; // 0x04
	}

	public static class SkeletalMorphUnsafeJobUtils // TypeDefIndex: 59544
	{
		// Methods
		public static ref ref T GetUnsafeElementRef<T>(NativeArray<T> array, int idx)
			where T : struct => ref _refReturnTypeForGetUnsafeElementRef;
		private ref T _refReturnTypeForGetUnsafeElementRef; // Dummy field
		public static void SetUnsafeElementRef<T>(NativeArray<T> array, int idx, ref ref T val)
			where T : struct {}
		public static Quaternion FromMaya(Vector3 eulerAngle) => default; // 0x000000018966E350-0x000000018966E518
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59546
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D05720-0x0000000183D05790
	
		// Methods
		public bool __Gen_Wrap_0(NativeArray<int> P0, int P1) => default; // 0x000000018966B854-0x000000018966B960
		public void __Gen_Wrap_1(NativeArray<int> P0, int P1, int P2) {} // 0x000000018966CCF4-0x000000018966CE20
		public void __Gen_Wrap_2(NativeArray<int> P0) {} // 0x000000018966D7A8-0x000000018966D8A0
		public void __Gen_Wrap_3(ref SkeletalMorphUnsafeJobDefines.TrackerLock P0) {} // 0x000000018966D8A0-0x000000018966D9D4
		public Quaternion __Gen_Wrap_4(Vector3 P0) => default; // 0x000000018966D9D4-0x000000018966DAFC
		public void __Gen_Wrap_5(ref SkeletalMorphUnsafeJobDefines.ApplyBoneToAnimatorTransJob P0) {} // 0x000000018966DAFC-0x000000018966DCD8
		public void __Gen_Wrap_6(AnimationTransformRWBufferHandle P0) {} // 0x000000018966DCD8-0x000000018966DE00
		public void __Gen_Wrap_7(AnimationTransformRWBufferHandle P0, float P1) {} // 0x000000018966DE00-0x000000018966DF50
		public string __Gen_Wrap_8(ref FBoneRuntimeData P0) => default; // 0x000000018966DF50-0x000000018966E0B4
		public bool __Gen_Wrap_9(ref FSkeletalMorphMappingData P0) => default; // 0x000000018966E0B4-0x000000018966E208
		public FSkeletalMorphBoneData __Gen_Wrap_10(ref FSkeletalMorphMappingData P0, int P1) => default; // 0x000000018966B960-0x000000018966BB14
		public void __Gen_Wrap_11(ref FSkeletalMorphMappingData P0, NativeArray<FSkeletalMorphBoneData> P1, int P2, int P3) {} // 0x000000018966BB14-0x000000018966BCD4
		public bool __Gen_Wrap_12(ref FSkeletalMorphAnim P0) => default; // 0x000000018966BCD4-0x000000018966BEC4
		public NativeArray<FMorphCtrlCurve> __Gen_Wrap_13(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2) => default; // 0x000000018966BEC4-0x000000018966C104
		public bool __Gen_Wrap_14(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2, out FMorphCtrlCurve P3) {
			P3 = default;
			return default;
		} // 0x000000018966C104-0x000000018966C364
		public int __Gen_Wrap_15(ref FSkeletalMorphAnim P0, EMorphPartType P1) => default; // 0x000000018966C364-0x000000018966C558
		public void __Gen_Wrap_16(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2, ref FMorphCtrlCurve P3) {} // 0x000000018966C558-0x000000018966C7F0
		public NativeArray<Keyframe> __Gen_Wrap_17(ref FMorphCtrlCurve P0, object P1, object P2, Unity.Collections.Allocator P3) => default; // 0x000000018966C7F0-0x000000018966C9A8
		public NativeArray<Keyframe> __Gen_Wrap_18(ref FMorphCtrlCurve P0, object P1, float P2, Unity.Collections.Allocator P3) => default; // 0x000000018966C9A8-0x000000018966CB60
		public bool __Gen_Wrap_19(ref FSkeletalMorphPose P0) => default; // 0x000000018966CB60-0x000000018966CCF4
		public int __Gen_Wrap_20(ref FSkeletalMorphPose P0) => default; // 0x000000018966CE20-0x000000018966CFB4
		public NativeArray<FMorphCtrlValue> __Gen_Wrap_21(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2) => default; // 0x000000018966CFB4-0x000000018966D1B0
		public bool __Gen_Wrap_22(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2, out FMorphCtrlValue P3) {
			P3 = default;
			return default;
		} // 0x000000018966D1B0-0x000000018966D3C8
		public int __Gen_Wrap_23(ref FSkeletalMorphPose P0, EMorphPartType P1) => default; // 0x000000018966D3C8-0x000000018966D578
		public void __Gen_Wrap_24(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2, ref FMorphCtrlValue P3) {} // 0x000000018966D578-0x000000018966D7A8
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 59547
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018966E208-0x000000018966E29C
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 59548
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018966E774-0x000000018966E7D8
		public static bool IsPatched(int id) => default; // 0x00000001829F2F80-0x00000001829F2FF0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018966E630-0x000000018966E6FC
		public object CreateWrapper(int id) => default; // 0x000000018966E6FC-0x000000018966E774
		public object InitWrapperArray(int len) => default; // 0x000000018966E7D8-0x0000000189670D70
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018966E58C-0x000000018966E630
	}

	public enum IDMAP0 // TypeDefIndex: 59549
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
