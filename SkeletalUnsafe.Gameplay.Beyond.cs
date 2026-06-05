/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using Beyond;
using Beyond.Gameplay.Core;
using IFix.Core;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering;

// Image 102: SkeletalUnsafe.Gameplay.Beyond.dll - Assembly: SkeletalUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60630-60653

internal class __JobReflectionRegistrationOutput__668062907 // TypeDefIndex: 60649
{
	// Constructors
	public __JobReflectionRegistrationOutput__668062907() {} // Dummy constructor

	// Methods
	public static void CreateJobReflectionData() {} // 0x0000000183EAF2C0-0x0000000183EAFAD0
	public static void EarlyInit() {} // 0x0000000183EAFAD0-0x0000000183EB5BA0
}

namespace Beyond.Gameplay.Core
{
	public static class NativeArrayExtensions // TypeDefIndex: 60633
	{
		// Methods
		public static void FastCopy<T>(NativeArray<T> src, NativeArray<T> dst)
			where T : struct {}
	}

	public static class SkeletalMorphUnsafeJobDefines // TypeDefIndex: 60637
	{
		// Nested types
		public static class SimpleWriteLock // TypeDefIndex: 60634
		{
			// Methods
			public static bool EnterLock(NativeArray<int> lockFlag, int maxSpinCount = 10000 /* Metadata: 0x02082A7F */) => default; // 0x000000018B7943B8-0x000000018B79446C
			public static void MainThreadEnterLock(NativeArray<int> lockFlag, int millisecondsTimeout = 500 /* Metadata: 0x02082A83 */, int spinBeforeTiming = 1000 /* Metadata: 0x02082A85 */) {} // 0x00000001847DF380-0x00000001847DF500
			public static void ExitLock(NativeArray<int> lockFlag) {} // 0x00000001847DF330-0x00000001847DF380
		}
	
		public struct TrackerLock : IJob // TypeDefIndex: 60635
		{
			// Fields
			public NativeArray<int> flag; // 0x00
			public bool isEnter; // 0x10
	
			// Methods
			public void Execute() {} // 0x000000018B794634-0x000000018B7946A8
		}
	
		public struct ApplyBoneToAnimatorTransJob : IJob // TypeDefIndex: 60636
		{
			// Fields
			public bool runtime_writeNoDirty; // 0x00
			public float runtime_applyWeight; // 0x04
			public NativeArray<FBoneRuntimeData> runtime_allBoneBasePose; // 0x08
			public NativeArray<FBoneRuntimeData> runtime_allBonePose; // 0x18
			public AnimationTransformRWBufferHandle runtime_allBonesTransformRWBufferHandle; // 0x28
	
			// Methods
			public void Execute() {} // 0x000000018B790E2C-0x000000018B791040
			public static void CleanAnimatorTransJob(AnimationTransformRWBufferHandle rwHandler) {} // 0x00000001841E7B00-0x00000001841E8710
			public static void SetAnimatorTransPhysicsRatioPtr(AnimationTransformRWBufferHandle rwHandler, float value) {} // 0x00000001847DF750-0x00000001847DF7E0
		}
	}

	public struct FSkeletalMorphShaderPropMappingData // TypeDefIndex: 60638
	{
		// Fields
		public int vectorIndex; // 0x00
		public ShaderPropertyType propertyType; // 0x04
		public int paramNameID; // 0x08
		public int paramRuntimeIdx; // 0x0C
	}

	public struct FBoneRuntimeData // TypeDefIndex: 60639
	{
		// Fields
		public Vector3 pos; // 0x00
		public Vector3 rot; // 0x0C
		public Vector3 sca; // 0x18
		public bool bIsDirty; // 0x24
	
		// Methods
		public override string ToString() => default; // 0x000000018B791040-0x000000018B791154
		public string __iFixBaseProxy_ToString() => default; // 0x000000018B791154-0x000000018B7911B8
	}

	public struct FSkeletalMorphBoneData // TypeDefIndex: 60640
	{
		// Fields
		public int boneNameHash; // 0x00
		public int boneID; // 0x04
		public Vector3 position; // 0x08
		public Vector3 rotation; // 0x14
		public Vector3 scale; // 0x20
	}

	public enum EMorphPartType // TypeDefIndex: 60641
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

	public struct FSkeletalMorphMappingData // TypeDefIndex: 60642
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
		} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool IsValid() => default; // 0x000000018B7914AC-0x000000018B7914F8
		public FSkeletalMorphBoneData GetBoneData(int idx) => default; // 0x000000018B7913A0-0x000000018B7914AC
		public void SetMapping(NativeArray<FSkeletalMorphBoneData> bigList, int bonesOffset, int bonesLen) {} // 0x00000001847DF7E0-0x00000001847DF860
	}

	public struct PtrList<T> // TypeDefIndex: 60643
		where T : struct
	{
		// Fields
		public int len;
		public unsafe T* data;
	}

	public struct FSkeletalMorphAnim // TypeDefIndex: 60644
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
		} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool IsValid() => default; // 0x00000001847DFBC0-0x00000001847DFC50
		public NativeArray<FMorphCtrlCurve> Create(EMorphPartType partType, int curveLen) => default; // 0x00000001847DEFD0-0x00000001847DF100
		public bool GetCurveData(EMorphPartType partType, int idx, out FMorphCtrlCurve curve) {
			curve = default;
			return default;
		} // 0x000000018B7911B8-0x000000018B7912F8
		public int GetCurveLen(EMorphPartType partType) => default; // 0x000000018B7912F8-0x000000018B7913A0
		public void SetCurveData(EMorphPartType partType, int idx, ref FMorphCtrlCurve curve) {} // 0x00000001847DF100-0x00000001847DF220
	}

	public struct FMorphCtrlCurve // TypeDefIndex: 60645
	{
		// Fields
		public const int RESOLUTION = 30; // Metadata: 0x02082A94
		public int ctrlNameHash; // 0x00
		public FPtrAnimNativeCurve curve; // 0x08
	
		// Methods
		public NativeArray<Keyframe> Create(string name, AnimationCurve animCurve, Unity.Collections.Allocator allocator) => default; // 0x0000000184879870-0x0000000184879930
		public NativeArray<Keyframe> Create(string name, float poseVal, Unity.Collections.Allocator allocator) => default; // 0x000000018487A980-0x000000018487AA40
	}

	public struct FSkeletalMorphPose // TypeDefIndex: 60646
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
		} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool IsValid() => default; // 0x000000018B791820-0x000000018B791894
		public int AllCurveNum() => default; // 0x000000018B7914F8-0x000000018B791550
		public NativeArray<FMorphCtrlValue> Create(EMorphPartType partType, int curveLen) => default; // 0x000000018B791550-0x000000018B7916A4
		public bool GetValueData(EMorphPartType partType, int idx, out FMorphCtrlValue curve) {
			curve = default;
			return default;
		} // 0x000000018B7916A4-0x000000018B791790
		public int GetValueLen(EMorphPartType partType) => default; // 0x000000018B791790-0x000000018B791820
		public void SetValueData(EMorphPartType partType, int idx, ref FMorphCtrlValue curve) {} // 0x000000018B791894-0x000000018B791970
	}

	public struct FMorphCtrlValue // TypeDefIndex: 60647
	{
		// Fields
		public int ctrlNameHash; // 0x00
		public float value; // 0x04
	}

	public static class SkeletalMorphUnsafeJobUtils // TypeDefIndex: 60648
	{
		// Methods
		public static ref ref T GetUnsafeElementRef<T>(NativeArray<T> array, int idx)
			where T : struct => ref _refReturnTypeForGetUnsafeElementRef;
		private ref T _refReturnTypeForGetUnsafeElementRef; // Dummy field
		public static void SetUnsafeElementRef<T>(NativeArray<T> array, int idx, ref ref T val)
			where T : struct {}
		public static Quaternion FromMaya(Vector3 eulerAngle) => default; // 0x000000018B79446C-0x000000018B794634
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 60650
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64010-0x0000000185F64080
	
		// Methods
		public bool __Gen_Wrap_0(NativeArray<int> P0, int P1) => default; // 0x000000018B791970-0x000000018B791A7C
		public void __Gen_Wrap_1(NativeArray<int> P0, int P1, int P2) {} // 0x000000018B792E10-0x000000018B792F3C
		public void __Gen_Wrap_2(NativeArray<int> P0) {} // 0x000000018B7938C4-0x000000018B7939BC
		public void __Gen_Wrap_3(ref SkeletalMorphUnsafeJobDefines.TrackerLock P0) {} // 0x000000018B7939BC-0x000000018B793AF0
		public Quaternion __Gen_Wrap_4(Vector3 P0) => default; // 0x000000018B793AF0-0x000000018B793C18
		public void __Gen_Wrap_5(ref SkeletalMorphUnsafeJobDefines.ApplyBoneToAnimatorTransJob P0) {} // 0x000000018B793C18-0x000000018B793DF4
		public void __Gen_Wrap_6(AnimationTransformRWBufferHandle P0) {} // 0x000000018B793DF4-0x000000018B793F1C
		public void __Gen_Wrap_7(AnimationTransformRWBufferHandle P0, float P1) {} // 0x000000018B793F1C-0x000000018B79406C
		public string __Gen_Wrap_8(ref FBoneRuntimeData P0) => default; // 0x000000018B79406C-0x000000018B7941D0
		public bool __Gen_Wrap_9(ref FSkeletalMorphMappingData P0) => default; // 0x000000018B7941D0-0x000000018B794324
		public FSkeletalMorphBoneData __Gen_Wrap_10(ref FSkeletalMorphMappingData P0, int P1) => default; // 0x000000018B791A7C-0x000000018B791C30
		public void __Gen_Wrap_11(ref FSkeletalMorphMappingData P0, NativeArray<FSkeletalMorphBoneData> P1, int P2, int P3) {} // 0x000000018B791C30-0x000000018B791DF0
		public bool __Gen_Wrap_12(ref FSkeletalMorphAnim P0) => default; // 0x000000018B791DF0-0x000000018B791FE0
		public NativeArray<FMorphCtrlCurve> __Gen_Wrap_13(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2) => default; // 0x000000018B791FE0-0x000000018B792220
		public bool __Gen_Wrap_14(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2, out FMorphCtrlCurve P3) {
			P3 = default;
			return default;
		} // 0x000000018B792220-0x000000018B792480
		public int __Gen_Wrap_15(ref FSkeletalMorphAnim P0, EMorphPartType P1) => default; // 0x000000018B792480-0x000000018B792674
		public void __Gen_Wrap_16(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2, ref FMorphCtrlCurve P3) {} // 0x000000018B792674-0x000000018B79290C
		public NativeArray<Keyframe> __Gen_Wrap_17(ref FMorphCtrlCurve P0, object P1, object P2, Unity.Collections.Allocator P3) => default; // 0x000000018B79290C-0x000000018B792AC4
		public NativeArray<Keyframe> __Gen_Wrap_18(ref FMorphCtrlCurve P0, object P1, float P2, Unity.Collections.Allocator P3) => default; // 0x000000018B792AC4-0x000000018B792C7C
		public bool __Gen_Wrap_19(ref FSkeletalMorphPose P0) => default; // 0x000000018B792C7C-0x000000018B792E10
		public int __Gen_Wrap_20(ref FSkeletalMorphPose P0) => default; // 0x000000018B792F3C-0x000000018B7930D0
		public NativeArray<FMorphCtrlValue> __Gen_Wrap_21(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2) => default; // 0x000000018B7930D0-0x000000018B7932CC
		public bool __Gen_Wrap_22(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2, out FMorphCtrlValue P3) {
			P3 = default;
			return default;
		} // 0x000000018B7932CC-0x000000018B7934E4
		public int __Gen_Wrap_23(ref FSkeletalMorphPose P0, EMorphPartType P1) => default; // 0x000000018B7934E4-0x000000018B793694
		public void __Gen_Wrap_24(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2, ref FMorphCtrlValue P3) {} // 0x000000018B793694-0x000000018B7938C4
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 60651
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018B794324-0x000000018B7943B8
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 60652
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018B794890-0x000000018B7948F4
		public static bool IsPatched(int id) => default; // 0x00000001847DFC50-0x00000001847DFCC0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018B79474C-0x000000018B794818
		public object CreateWrapper(int id) => default; // 0x000000018B794818-0x000000018B794890
		public object InitWrapperArray(int len) => default; // 0x000000018B7948F4-0x000000018B796E8C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018B7946A8-0x000000018B79474C
	}

	public enum IDMAP0 // TypeDefIndex: 60653
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
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60631
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 60632
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
