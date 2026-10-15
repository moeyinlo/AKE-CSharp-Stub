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

// Image 103: SkeletalUnsafe.Gameplay.Beyond.dll - Assembly: SkeletalUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90652-90700

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1783802405 // TypeDefIndex: 90671
{
	// Methods
	public static void CreateJobReflectionData(); // 0x0000000184E401B0-0x0000000184E40960
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit(); // 0x0000000184E40960-0x0000000184E41910
}

namespace Beyond.Gameplay.Core
{
	public static class NativeArrayExtensions // TypeDefIndex: 90655
	{
		// Methods
		public static void FastCopy<T>(NativeArray<T> src, NativeArray<T> dst)
			where T : struct;
	}

	public static class SkeletalMorphUnsafeJobDefines // TypeDefIndex: 90659
	{
		// Nested types
		public static class SimpleWriteLock // TypeDefIndex: 90656
		{
			// Methods
			public static bool EnterLock(NativeArray<int> lockFlag, int maxSpinCount = 10000 /* Metadata: 0x0264B0D8 */); // 0x000000018CE3F84C-0x000000018CE3F900
			public static void MainThreadEnterLock(NativeArray<int> lockFlag, int millisecondsTimeout = 500 /* Metadata: 0x0264B0DC */, int spinBeforeTiming = 1000 /* Metadata: 0x0264B0DE */); // 0x0000000185363B20-0x0000000185363C60
			public static void ExitLock(NativeArray<int> lockFlag); // 0x0000000185363AF0-0x0000000185363B20
		}
	
		[BurstCompile]
		public struct TrackerLock : IJob // TypeDefIndex: 90657
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> flag; // 0x00
			[NativeDisableParallelForRestriction]
			public bool isEnter; // 0x10
	
			// Methods
			public void Execute(); // 0x000000018CE3FAD0-0x000000018CE3FB38
		}
	
		[BurstCompile]
		public struct ApplyBoneToAnimatorTransJob : IJob // TypeDefIndex: 90658
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
			public void Execute(); // 0x000000018CE3C328-0x000000018CE3C5B0
			public static void CleanAnimatorTransJob(AnimationTransformRWBufferHandle rwHandler); // 0x0000000186943F80-0x0000000186944370
			public static void SetAnimatorTransPhysicsRatioPtr(AnimationTransformRWBufferHandle rwHandler, float value); // 0x0000000185361740-0x00000001853617B0
		}
	}

	public struct FSkeletalMorphShaderPropMappingData // TypeDefIndex: 90660
	{
		// Fields
		public int vectorIndex; // 0x00
		public ShaderPropertyType propertyType; // 0x04
		public int paramNameID; // 0x08
		public int paramRuntimeIdx; // 0x0C
	}

	public struct FBoneRuntimeData // TypeDefIndex: 90661
	{
		// Fields
		public Vector3 pos; // 0x00
		public Vector3 rot; // 0x0C
		public Vector3 sca; // 0x18
		public bool bIsDirty; // 0x24
	
		// Methods
		public override string ToString(); // 0x000000018CE3C5B0-0x000000018CE3C6C4
		public string __iFixBaseProxy_ToString(); // 0x000000018CE3C6C4-0x000000018CE3C728
	}

	public struct FSkeletalMorphBoneData // TypeDefIndex: 90662
	{
		// Fields
		public int boneNameHash; // 0x00
		public int boneID; // 0x04
		public Vector3 position; // 0x08
		public Vector3 rotation; // 0x14
		public Vector3 scale; // 0x20
	}

	[Flags]
	public enum EMorphPartType // TypeDefIndex: 90663
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

	public struct FSkeletalMorphMappingData // TypeDefIndex: 90664
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
		static FSkeletalMorphMappingData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool IsValid(); // 0x000000018CE3C9C4-0x000000018CE3CA00
		public FSkeletalMorphBoneData GetBoneData(int idx); // 0x000000018CE3C8D4-0x000000018CE3C9C4
		public void SetMapping(NativeArray<FSkeletalMorphBoneData> bigList, int bonesOffset, int bonesLen); // 0x0000000185A14F80-0x0000000185A14FC0
	}

	public struct PtrList<T> // TypeDefIndex: 90665
		where T : struct
	{
		// Fields
		public int len;
		public unsafe T* data;
	}

	public struct FSkeletalMorphAnim // TypeDefIndex: 90666
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
		static FSkeletalMorphAnim(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool IsValid(); // 0x00000001856F9D00-0x00000001856F9D40
		public NativeArray<FMorphCtrlCurve> Create(EMorphPartType partType, int curveLen); // 0x00000001865E2E00-0x00000001865E2EF0
		public bool GetCurveData(EMorphPartType partType, int idx, out FMorphCtrlCurve curve); // 0x000000018CE3C728-0x000000018CE3C848
		public int GetCurveLen(EMorphPartType partType); // 0x000000018CE3C848-0x000000018CE3C8D4
		public void SetCurveData(EMorphPartType partType, int idx, ref FMorphCtrlCurve curve); // 0x0000000185365310-0x00000001853653B0
	}

	public struct FMorphCtrlCurve // TypeDefIndex: 90667
	{
		// Fields
		public const int RESOLUTION = 30; // Metadata: 0x0264B0ED
		public int ctrlNameHash; // 0x00
		public FPtrAnimNativeCurve curve; // 0x08
	
		// Methods
		[IDTag(0)]
		public NativeArray<Keyframe> Create(string name, AnimationCurve animCurve, Unity.Collections.Allocator allocator); // 0x0000000185364AB0-0x0000000185364B70
		[IDTag(1)]
		public NativeArray<Keyframe> Create(string name, float poseVal, Unity.Collections.Allocator allocator); // 0x0000000186564CD0-0x0000000186564DC0
	}

	public struct FSkeletalMorphPose // TypeDefIndex: 90668
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
		static FSkeletalMorphPose(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool IsValid(); // 0x000000018CE3CCDC-0x000000018CE3CD38
		public int AllCurveNum(); // 0x000000018CE3CA00-0x000000018CE3CA44
		public NativeArray<FMorphCtrlValue> Create(EMorphPartType partType, int curveLen); // 0x000000018CE3CA44-0x000000018CE3CB98
		public bool GetValueData(EMorphPartType partType, int idx, out FMorphCtrlValue curve); // 0x000000018CE3CB98-0x000000018CE3CC6C
		public int GetValueLen(EMorphPartType partType); // 0x000000018CE3CC6C-0x000000018CE3CCDC
		public void SetValueData(EMorphPartType partType, int idx, ref FMorphCtrlValue curve); // 0x000000018CE3CD38-0x000000018CE3CDF4
	}

	public struct FMorphCtrlValue // TypeDefIndex: 90669
	{
		// Fields
		public int ctrlNameHash; // 0x00
		public float value; // 0x04
	}

	public static class SkeletalMorphUnsafeJobUtils // TypeDefIndex: 90670
	{
		// Methods
		public static ref ref T GetUnsafeElementRef<T>(NativeArray<T> array, int idx)
			where T : struct;
		public static void SetUnsafeElementRef<T>(NativeArray<T> array, int idx, ref ref T val)
			where T : struct;
		public static Quaternion FromMaya(Vector3 eulerAngle); // 0x000000018CE3F900-0x000000018CE3FAD0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 90672
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018CE3F750-0x000000018CE3F7B4
	
		// Methods
		public bool __Gen_Wrap_0(NativeArray<int> P0, int P1); // 0x000000018CE3CDF4-0x000000018CE3CF08
		public void __Gen_Wrap_1(NativeArray<int> P0, int P1, int P2); // 0x000000018CE3E248-0x000000018CE3E368
		public void __Gen_Wrap_2(NativeArray<int> P0); // 0x000000018CE3ED04-0x000000018CE3EDEC
		public void __Gen_Wrap_3(ref SkeletalMorphUnsafeJobDefines.TrackerLock P0); // 0x000000018CE3EDEC-0x000000018CE3EF24
		public Quaternion __Gen_Wrap_4(Vector3 P0); // 0x000000018CE3EF24-0x000000018CE3F050
		public void __Gen_Wrap_5(ref SkeletalMorphUnsafeJobDefines.ApplyBoneToAnimatorTransJob P0); // 0x000000018CE3F050-0x000000018CE3F230
		public void __Gen_Wrap_6(AnimationTransformRWBufferHandle P0); // 0x000000018CE3F230-0x000000018CE3F34C
		public void __Gen_Wrap_7(AnimationTransformRWBufferHandle P0, float P1); // 0x000000018CE3F34C-0x000000018CE3F490
		public string __Gen_Wrap_8(ref FBoneRuntimeData P0); // 0x000000018CE3F490-0x000000018CE3F5F8
		public bool __Gen_Wrap_9(ref FSkeletalMorphMappingData P0); // 0x000000018CE3F5F8-0x000000018CE3F750
		public FSkeletalMorphBoneData __Gen_Wrap_10(ref FSkeletalMorphMappingData P0, int P1); // 0x000000018CE3CF08-0x000000018CE3D0C0
		public void __Gen_Wrap_11(ref FSkeletalMorphMappingData P0, NativeArray<FSkeletalMorphBoneData> P1, int P2, int P3); // 0x000000018CE3D0C0-0x000000018CE3D270
		public bool __Gen_Wrap_12(ref FSkeletalMorphAnim P0); // 0x000000018CE3D270-0x000000018CE3D44C
		public NativeArray<FMorphCtrlCurve> __Gen_Wrap_13(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2); // 0x000000018CE3D44C-0x000000018CE3D67C
		public bool __Gen_Wrap_14(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2, out FMorphCtrlCurve P3); // 0x000000018CE3D67C-0x000000018CE3D8E0
		public int __Gen_Wrap_15(ref FSkeletalMorphAnim P0, EMorphPartType P1); // 0x000000018CE3D8E0-0x000000018CE3DAD8
		public void __Gen_Wrap_16(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2, ref FMorphCtrlCurve P3); // 0x000000018CE3DAD8-0x000000018CE3DD5C
		public NativeArray<Keyframe> __Gen_Wrap_17(ref FMorphCtrlCurve P0, object P1, object P2, Unity.Collections.Allocator P3); // 0x000000018CE3DD5C-0x000000018CE3DF04
		public NativeArray<Keyframe> __Gen_Wrap_18(ref FMorphCtrlCurve P0, object P1, float P2, Unity.Collections.Allocator P3); // 0x000000018CE3DF04-0x000000018CE3E0B0
		public bool __Gen_Wrap_19(ref FSkeletalMorphPose P0); // 0x000000018CE3E0B0-0x000000018CE3E248
		public int __Gen_Wrap_20(ref FSkeletalMorphPose P0); // 0x000000018CE3E368-0x000000018CE3E500
		public NativeArray<FMorphCtrlValue> __Gen_Wrap_21(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2); // 0x000000018CE3E500-0x000000018CE3E700
		public bool __Gen_Wrap_22(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2, out FMorphCtrlValue P3); // 0x000000018CE3E700-0x000000018CE3E91C
		public int __Gen_Wrap_23(ref FSkeletalMorphPose P0, EMorphPartType P1); // 0x000000018CE3E91C-0x000000018CE3EAD0
		public void __Gen_Wrap_24(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2, ref FMorphCtrlValue P3); // 0x000000018CE3EAD0-0x000000018CE3ED04
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 90673
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018CE3F7B4-0x000000018CE3F84C
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 90674
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018CE3FD24-0x000000018CE3FD88
		public static bool IsPatched(int id); // 0x000000018CE3FE14-0x000000018CE41810
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018CE3FBDC-0x000000018CE3FCA8
		public object CreateWrapper(int id); // 0x000000018CE3FCA8-0x000000018CE3FD24
		public object InitWrapperArray(int len); // 0x000000018CE3FD88-0x000000018CE3FE14
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018CE3FB38-0x000000018CE3FBDC
	}

	public delegate bool __HotPatchDelegate_0(NativeArray<int> P0, int P1); // TypeDefIndex: 90675; 0x00000001826DF750-0x00000001826DF780

	public enum HotPatchIDMAP0 // TypeDefIndex: 90676
	{
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-EnterLock0 = 0,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-MainThreadEnterLock0 = 1,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-SimpleWriteLock-ExitLock0 = 2,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-TrackerLock-Execute0 = 3,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobUtils-FromMaya0 = 4,
		Beyond-Gameplay-Core-SkeletalMorphUnsafeJobDefines-ApplyBoneToAnimatorTransJob-Execute0 = 5,
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

	public delegate void __HotPatchDelegate_1(NativeArray<int> P0, int P1, int P2); // TypeDefIndex: 90677; 0x00000001826DF9A0-0x00000001826DF9D0

	public delegate void __HotPatchDelegate_2(NativeArray<int> P0); // TypeDefIndex: 90678; 0x0000000186A4F2D0-0x0000000186A4F300

	public delegate void __HotPatchDelegate_3(ref SkeletalMorphUnsafeJobDefines.TrackerLock P0); // TypeDefIndex: 90679; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Quaternion __HotPatchDelegate_4(Vector3 P0); // TypeDefIndex: 90680; 0x0000000184160990-0x00000001841609E0

	public delegate void __HotPatchDelegate_5(ref SkeletalMorphUnsafeJobDefines.ApplyBoneToAnimatorTransJob P0); // TypeDefIndex: 90681; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_6(AnimationTransformRWBufferHandle P0); // TypeDefIndex: 90682; 0x0000000187A20498-0x0000000187A204F4

	public delegate void __HotPatchDelegate_7(AnimationTransformRWBufferHandle P0, float P1); // TypeDefIndex: 90683; 0x0000000187A1B7E0-0x0000000187A1B83C

	public delegate string __HotPatchDelegate_8(ref FBoneRuntimeData P0); // TypeDefIndex: 90684; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_9(ref FSkeletalMorphMappingData P0); // TypeDefIndex: 90685; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate FSkeletalMorphBoneData __HotPatchDelegate_10(ref FSkeletalMorphMappingData P0, int P1); // TypeDefIndex: 90686; 0x0000000184E4D4B0-0x0000000184E4D500

	public delegate void __HotPatchDelegate_11(ref FSkeletalMorphMappingData P0, NativeArray<FSkeletalMorphBoneData> P1, int P2, int P3); // TypeDefIndex: 90687; 0x00000001826E9FD0-0x00000001826EA010

	public delegate bool __HotPatchDelegate_12(ref FSkeletalMorphAnim P0); // TypeDefIndex: 90688; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate NativeArray<FMorphCtrlCurve> __HotPatchDelegate_13(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2); // TypeDefIndex: 90689; 0x00000001812D51A0-0x00000001812D51E0

	public delegate bool __HotPatchDelegate_14(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2, out FMorphCtrlCurve P3); // TypeDefIndex: 90690; 0x00000001811CDB70-0x00000001811CDB90

	public delegate int __HotPatchDelegate_15(ref FSkeletalMorphAnim P0, EMorphPartType P1); // TypeDefIndex: 90691; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_16(ref FSkeletalMorphAnim P0, EMorphPartType P1, int P2, ref FMorphCtrlCurve P3); // TypeDefIndex: 90692; 0x00000001811CDB70-0x00000001811CDB90

	public delegate NativeArray<Keyframe> __HotPatchDelegate_17(ref FMorphCtrlCurve P0, object P1, object P2, Unity.Collections.Allocator P3); // TypeDefIndex: 90693; 0x000000018416EFB0-0x000000018416F000

	public delegate NativeArray<Keyframe> __HotPatchDelegate_18(ref FMorphCtrlCurve P0, object P1, float P2, Unity.Collections.Allocator P3); // TypeDefIndex: 90694; 0x000000018BCE6144-0x000000018BCE6190

	public delegate bool __HotPatchDelegate_19(ref FSkeletalMorphPose P0); // TypeDefIndex: 90695; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_20(ref FSkeletalMorphPose P0); // TypeDefIndex: 90696; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate NativeArray<FMorphCtrlValue> __HotPatchDelegate_21(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2); // TypeDefIndex: 90697; 0x00000001812D51A0-0x00000001812D51E0

	public delegate bool __HotPatchDelegate_22(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2, out FMorphCtrlValue P3); // TypeDefIndex: 90698; 0x00000001811CDB70-0x00000001811CDB90

	public delegate int __HotPatchDelegate_23(ref FSkeletalMorphPose P0, EMorphPartType P1); // TypeDefIndex: 90699; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_24(ref FSkeletalMorphPose P0, EMorphPartType P1, int P2, ref FMorphCtrlValue P3); // TypeDefIndex: 90700; 0x00000001811CDB70-0x00000001811CDB90
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 90653
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 90654
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
