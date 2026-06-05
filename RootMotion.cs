/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using RootMotion;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;

// Image 27: RootMotion.dll - Assembly: RootMotion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 53583-53808

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 53808
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_16 CF97ADEEDB59E05BFD73A2B4C2A8885708C4F4F70C84C64B27120E72AB733B72; // 0x00 // Static value (base64): AQAAAAIAAAADAAAABAAAAA== - Metadata: 0x02078374

	// Nested types
	private struct __StaticArrayInitTypeSize_16 // TypeDefIndex: 53807
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace RootMotion
{
	public abstract class Baker : MonoBehaviour // TypeDefIndex: 53590
	{
		// Fields
		public int frameRate; // 0x18
		public float keyReductionError; // 0x1C
		public Mode mode; // 0x20
		public AnimationClip[] animationClips; // 0x28
		public string[] animationStates; // 0x30
		public string saveToFolder; // 0x38
		public string appendName; // 0x40
		public string saveName; // 0x48
		private bool _isBaking_k__BackingField; // 0x50
		private float _bakingProgress_k__BackingField; // 0x54
		public Animator animator; // 0x58
		public PlayableDirector director; // 0x60
		public BakerDelegate OnStartClip; // 0x68
		public BakerDelegate OnUpdateClip; // 0x70
		public bool inheritClipSettings; // 0x78
		public ClipSettings clipSettings; // 0x80
		private float _clipLength_k__BackingField; // 0x88
		protected bool addLoopFrame; // 0x8C
	
		// Properties
		public bool isBaking { get; private set; }
		public float bakingProgress { get; private set; }
		protected float clipLength { get; private set; } // 0x000000018B71EC64-0x000000018B71ED48 0x0000000189AE6BDC-0x0000000189AE6CB0
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 53584
		{
			AnimationClips = 0,
			AnimationStates = 1,
			PlayableDirector = 2,
			Realtime = 3
		}
	
		public delegate void BakerDelegate(AnimationClip clip, float time); // TypeDefIndex: 53585; 0x000000018B71EBC8-0x000000018B71EBFC
	
		[Serializable]
		public class ClipSettings // TypeDefIndex: 53589
		{
			// Fields
			public bool loopTime; // 0x10
			public bool loopBlend; // 0x11
			public float cycleOffset; // 0x14
			public bool loopBlendOrientation; // 0x18
			public BasedUponRotation basedUponRotation; // 0x1C
			public float orientationOffsetY; // 0x20
			public bool loopBlendPositionY; // 0x24
			public BasedUponY basedUponY; // 0x28
			public float level; // 0x2C
			public bool loopBlendPositionXZ; // 0x30
			public BasedUponXZ basedUponXZ; // 0x34
			public bool mirror; // 0x38
	
			// Nested types
			[Serializable]
			public enum BasedUponRotation // TypeDefIndex: 53586
			{
				Original = 0,
				BodyOrientation = 1
			}
	
			[Serializable]
			public enum BasedUponY // TypeDefIndex: 53587
			{
				Original = 0,
				CenterOfMass = 1,
				Feet = 2
			}
	
			[Serializable]
			public enum BasedUponXZ // TypeDefIndex: 53588
			{
				Original = 0,
				CenterOfMass = 1
			}
	
			// Constructors
			public ClipSettings() {} // 0x00000001813ECBE0-0x00000001813ECBF0
		}
	
		// Constructors
		protected Baker() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void OpenUserManual() {} // 0x00000001813EE9A0-0x00000001813EE9B0
		private void OpenScriptReference() {} // 0x0000000183F80440-0x0000000183F80450
		private void SupportGroup() {} // 0x0000000183F804D0-0x0000000183F804E0
		private void ASThread() {}
		protected abstract Transform GetCharacterRoot(); // 0x0000000185FB8BC0-0x0000000185FB8BD0
		protected abstract void OnStartBaking(); // 0x0000000185FB8BE0-0x0000000185FB8BF0
		protected abstract void OnSetLoopFrame(float time); // 0x0000000185492010-0x0000000185492020
		protected abstract void OnSetCurves(ref AnimationClip clip); // 0x0000000185492010-0x0000000185492020
		protected abstract void OnSetKeyframes(float time, bool lastFrame); // 0x0000000185492010-0x0000000185492020
		public void BakeClip() {} // 0x00000001831C5680-0x00000001831C5690
		public void StartBaking() {} // 0x000000018B71BCBC-0x000000018B71BD3C
		public void StopBaking() {} // 0x00000001864BB614-0x00000001864BB734
	}

	public class GenericBaker : Baker // TypeDefIndex: 53591
	{
		// Fields
		public bool markAsLegacy; // 0x90
		public Transform root; // 0x98
		public Transform rootNode; // 0xA0
		public Transform[] ignoreList; // 0xA8
		public Transform[] bakePositionList; // 0xB0
		private BakerTransform[] children; // 0xB8
		private BakerTransform rootChild; // 0xC0
		private int rootChildIndex; // 0xC8
	
		// Constructors
		public GenericBaker() {} // 0x000000018B725854-0x000000018B7258B0
	
		// Methods
		private void Awake() {} // 0x000000018B7252C0-0x000000018B7254E8
		protected override Transform GetCharacterRoot() => default; // 0x0000000181E336C0-0x0000000181E336D0
		protected override void OnStartBaking() {} // 0x000000018B725760-0x000000018B725854
		protected override void OnSetLoopFrame(float time) {} // 0x000000018B7256F8-0x000000018B725760
		protected override void OnSetCurves(ref AnimationClip clip) {} // 0x000000018B725628-0x000000018B725690
		protected override void OnSetKeyframes(float time, bool lastFrame) {} // 0x000000018B725690-0x000000018B7256F8
		private bool IsIgnored(Transform t) => default; // 0x000000018B725588-0x000000018B725628
		private bool BakePosition(Transform t) => default; // 0x000000018B7254E8-0x000000018B725588
	}

	public class TQ // TypeDefIndex: 53592
	{
		// Fields
		public Vector3 t; // 0x10
		public Quaternion q; // 0x1C
	
		// Constructors
		public TQ() {} // 0x0000000185492010-0x0000000185492020
		public TQ(Vector3 translation, Quaternion rotation) {} // 0x0000000185FD5500-0x0000000185FD5520
	}

	public class AvatarUtility // TypeDefIndex: 53593
	{
		// Constructors
		public AvatarUtility() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal) => default; // 0x000000018B71AF88-0x000000018B71B184
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ) => default; // 0x000000018B71A9C8-0x000000018B71AF88
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal) => default; // 0x000000018B71B308-0x000000018B71B754
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale) => default; // 0x000000018B71B184-0x000000018B71B2D4
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal) => default; // 0x000000018B71B2D4-0x000000018B71B308
	}

	public static class BakerUtilities // TypeDefIndex: 53594
	{
		// Methods
		public static void ReduceKeyframes(AnimationCurve curve, float maxError) {} // 0x000000018B71EA04-0x000000018B71EA44
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError) => default; // 0x000000018B71E6D4-0x000000018B71EA04
		public static void SetLoopFrame(float time, AnimationCurve curve) {} // 0x000000018B71EA44-0x000000018B71EB94
		public static void SetTangentMode(AnimationCurve curve) {} // 0x0000000185492010-0x0000000185492020
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q) => default; // 0x000000018B71E53C-0x000000018B71E6D4
	}

	[Serializable]
	public class BakerHumanoidQT // TypeDefIndex: 53595
	{
		// Fields
		private Transform transform; // 0x10
		private string Qx; // 0x18
		private string Qy; // 0x20
		private string Qz; // 0x28
		private string Qw; // 0x30
		private string Tx; // 0x38
		private string Ty; // 0x40
		private string Tz; // 0x48
		public AnimationCurve rotX; // 0x50
		public AnimationCurve rotY; // 0x58
		public AnimationCurve rotZ; // 0x60
		public AnimationCurve rotW; // 0x68
		public AnimationCurve posX; // 0x70
		public AnimationCurve posY; // 0x78
		public AnimationCurve posZ; // 0x80
		private AvatarIKGoal goal; // 0x88
		private Quaternion lastQ; // 0x8C
		private bool lastQSet; // 0x9C
	
		// Constructors
		public BakerHumanoidQT() {} // Dummy constructor
		public BakerHumanoidQT(string name) {} // 0x000000018B71CAB0-0x000000018B71CC14
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name) {} // 0x000000018B71CC14-0x000000018B71CDA4
	
		// Methods
		public Quaternion EvaluateRotation(float time) => default; // 0x000000018B71BDD8-0x000000018B71BEA0
		public Vector3 EvaluatePosition(float time) => default; // 0x000000018B71BD3C-0x000000018B71BDD8
		public TQ Evaluate(float time) => default; // 0x000000018B71BEA0-0x000000018B71BF40
		public void GetCurvesFromClip(AnimationClip clip, Animator animator) {} // 0x0000000185492010-0x0000000185492020
		public void Reset() {} // 0x000000018B71C0B8-0x000000018B71C258
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation) {} // 0x000000018B71C5F4-0x000000018B71C934
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot) {} // 0x000000018B71C934-0x000000018B71CA28
		public void MoveLastKeyframes(float time) {} // 0x000000018B71BFA4-0x000000018B71C03C
		public void SetLoopFrame(float time) {} // 0x000000018B71CA28-0x000000018B71CAB0
		public void SetRootLoopFrame(float time) {} // 0x0000000185492010-0x0000000185492020
		private void MoveLastKeyframe(float time, AnimationCurve curve) {} // 0x000000018B71BF40-0x000000018B71BFA4
		public void MultiplyLength(AnimationCurve curve, float mlp) {} // 0x000000018B71C03C-0x000000018B71C0B8
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp) {} // 0x000000018B71C258-0x000000018B71C5F4
	}

	[Serializable]
	public class BakerMuscle // TypeDefIndex: 53596
	{
		// Fields
		public AnimationCurve curve; // 0x10
		private int muscleIndex; // 0x18
		private string propertyName; // 0x20
	
		// Constructors
		public BakerMuscle() {} // Dummy constructor
		public BakerMuscle(int muscleIndex) {} // 0x000000018B71D8F0-0x000000018B71D954
	
		// Methods
		private string MuscleNameToPropertyName(string n) => default; // 0x000000018B71CDA4-0x000000018B71D740
		public void MultiplyLength(AnimationCurve curve, float mlp) {} // 0x000000018B71C03C-0x000000018B71C0B8
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp) {} // 0x000000018B71D7A4-0x000000018B71D8A0
		public void Reset() {} // 0x000000018B71D740-0x000000018B71D7A4
		public void SetKeyframe(float time, float[] muscles) {} // 0x000000018B71D8A0-0x000000018B71D8E0
		public void SetLoopFrame(float time) {} // 0x000000018B71D8E0-0x000000018B71D8F0
	}

	[Serializable]
	public class BakerTransform // TypeDefIndex: 53597
	{
		// Fields
		public Transform transform; // 0x10
		public AnimationCurve posX; // 0x18
		public AnimationCurve posY; // 0x20
		public AnimationCurve posZ; // 0x28
		public AnimationCurve rotX; // 0x30
		public AnimationCurve rotY; // 0x38
		public AnimationCurve rotZ; // 0x40
		public AnimationCurve rotW; // 0x48
		private string relativePath; // 0x50
		private bool recordPosition; // 0x58
		private Vector3 relativePosition; // 0x5C
		private bool isRootNode; // 0x68
		private Quaternion relativeRotation; // 0x6C
	
		// Constructors
		public BakerTransform() {} // Dummy constructor
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode) {} // 0x000000018B71E4B4-0x000000018B71E53C
	
		// Methods
		public void SetRelativeSpace(Vector3 position, Quaternion rotation) {} // 0x0000000185FD4F80-0x0000000185FD4FA0
		public void SetCurves(ref AnimationClip clip) {} // 0x000000018B71DFD8-0x000000018B71E2A8
		private void AddRootMotionCurves(ref AnimationClip clip) {} // 0x000000018B71DB30-0x000000018B71DDDC
		public void Reset() {} // 0x000000018B71DE60-0x000000018B71DFD8
		public void ReduceKeyframes(float maxError) {} // 0x000000018B71DDDC-0x000000018B71DE60
		public void SetKeyframes(float time) {} // 0x000000018B71E2A8-0x000000018B71E4B4
		public void AddLoopFrame(float time) {} // 0x000000018B71D954-0x000000018B71DB30
	}

	public class HumanoidBaker : Baker // TypeDefIndex: 53598
	{
		// Fields
		public bool bakeHandIK; // 0x90
		public float IKKeyReductionError; // 0x94
		public int muscleFrameRateDiv; // 0x98
		private BakerMuscle[] bakerMuscles; // 0xA0
		private BakerHumanoidQT rootQT; // 0xA8
		private BakerHumanoidQT leftFootQT; // 0xB0
		private BakerHumanoidQT rightFootQT; // 0xB8
		private BakerHumanoidQT leftHandQT; // 0xC0
		private BakerHumanoidQT rightHandQT; // 0xC8
		private float[] muscles; // 0xD0
		private HumanPose pose; // 0xD8
		private HumanPoseHandler handler; // 0x100
		private Vector3 bodyPosition; // 0x108
		private Quaternion bodyRotation; // 0x114
		private int mN; // 0x124
		private Quaternion lastBodyRotation; // 0x128
	
		// Constructors
		public HumanoidBaker() {} // 0x000000018B726F84-0x000000018B727018
	
		// Methods
		private void Awake() {} // 0x000000018B7261F8-0x000000018B7266F4
		protected override Transform GetCharacterRoot() => default; // 0x000000018B7266F4-0x000000018B726714
		protected override void OnStartBaking() {} // 0x000000018B726DB4-0x000000018B726E98
		protected override void OnSetLoopFrame(float time) {} // 0x000000018B726CD4-0x000000018B726DB4
		protected override void OnSetCurves(ref AnimationClip clip) {} // 0x000000018B726714-0x000000018B726920
		protected override void OnSetKeyframes(float time, bool lastFrame) {} // 0x000000018B726920-0x000000018B726CD4
		private void UpdateHumanPose() {} // 0x000000018B726E98-0x000000018B726F84
	}

	[Serializable]
	public enum Axis // TypeDefIndex: 53599
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public class AxisTools // TypeDefIndex: 53600
	{
		// Constructors
		public AxisTools() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static Vector3 ToVector3(RootMotion.Axis axis) => default; // 0x000000018B71BC7C-0x000000018B71BCBC
		public static RootMotion.Axis ToAxis(Vector3 v) => default; // 0x000000018B71BC3C-0x000000018B71BC7C
		public static RootMotion.Axis GetAxisToPoint(Transform t, Vector3 worldPosition) => default; // 0x000000018B71B840-0x000000018B71B92C
		public static RootMotion.Axis GetAxisToDirection(Transform t, Vector3 direction) => default; // 0x000000018B71B754-0x000000018B71B840
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition) => default; // 0x000000018B71BB8C-0x000000018B71BC3C
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction) => default; // 0x000000018B71B92C-0x000000018B71B998
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction) => default; // 0x000000018B71B998-0x000000018B71BB8C
	}

	[Serializable]
	public class BipedLimbOrientations // TypeDefIndex: 53602
	{
		// Fields
		public LimbOrientation leftArm; // 0x10
		public LimbOrientation rightArm; // 0x18
		public LimbOrientation leftLeg; // 0x20
		public LimbOrientation rightLeg; // 0x28
	
		// Properties
		public static BipedLimbOrientations UMA { get => default; } // 0x000000018B71F4A0-0x000000018B71F730 
		public static BipedLimbOrientations MaxBiped { get => default; } // 0x0000000185FBA950-0x0000000185FBA990 
	
		// Nested types
		[Serializable]
		public class LimbOrientation // TypeDefIndex: 53601
		{
			// Fields
			public Vector3 upperBoneForwardAxis; // 0x10
			public Vector3 lowerBoneForwardAxis; // 0x1C
			public Vector3 lastBoneLeftAxis; // 0x28
	
			// Constructors
			public LimbOrientation() {} // Dummy constructor
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis) {} // 0x000000018470BF70-0x000000018470BFC0
		}
	
		// Constructors
		public BipedLimbOrientations() {} // Dummy constructor
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg) {} // 0x000000018B71F730-0x000000018B71F9C0
	}

	public static class BipedNaming // TypeDefIndex: 53605
	{
		// Fields
		public static string[] typeLeft; // 0x00
		public static string[] typeRight; // 0x08
		public static string[] typeSpine; // 0x10
		public static string[] typeHead; // 0x18
		public static string[] typeArm; // 0x20
		public static string[] typeLeg; // 0x28
		public static string[] typeTail; // 0x30
		public static string[] typeEye; // 0x38
		public static string[] typeExclude; // 0x40
		public static string[] typeExcludeSpine; // 0x48
		public static string[] typeExcludeHead; // 0x50
		public static string[] typeExcludeArm; // 0x58
		public static string[] typeExcludeLeg; // 0x60
		public static string[] typeExcludeTail; // 0x68
		public static string[] typeExcludeEye; // 0x70
		public static string[] pelvis; // 0x78
		public static string[] hand; // 0x80
		public static string[] foot; // 0x88
	
		// Nested types
		[Serializable]
		public enum BoneType // TypeDefIndex: 53603
		{
			Unassigned = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Leg = 4,
			Tail = 5,
			Eye = 6
		}
	
		[Serializable]
		public enum BoneSide // TypeDefIndex: 53604
		{
			Center = 0,
			Left = 1,
			Right = 2
		}
	
		// Constructors
		static BipedNaming() {} // 0x000000018B720040-0x000000018B7212B8
	
		// Methods
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones) => default; // 0x000000018B71FD54-0x000000018B71FEA4
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones) => default; // 0x000000018B71FB9C-0x000000018B71FCEC
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones) => default; // 0x000000018B71FCEC-0x000000018B71FD54
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones) => default; // 0x000000018B71FEA4-0x000000018B71FF28
		public static Transform GetNamingMatch(Transform[] transforms, string[][] namings) => default; // 0x000000018B71FF28-0x000000018B720008
		public static BoneType GetBoneType(string boneName) => default; // 0x000000018B71FA2C-0x000000018B71FB24
		public static BoneSide GetBoneSide(string boneName) => default; // 0x000000018B71F9C0-0x000000018B71FA2C
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center /* Metadata: 0x020782A6 */, string[][] namings) => default; // 0x000000018B71FB24-0x000000018B71FB9C
		private static bool isLeft(string boneName) => default; // 0x000000018B721514-0x000000018B7215D4
		private static bool isRight(string boneName) => default; // 0x000000018B72165C-0x000000018B72171C
		private static bool isSpine(string boneName) => default; // 0x000000018B72171C-0x000000018B7217A4
		private static bool isHead(string boneName) => default; // 0x000000018B72148C-0x000000018B721514
		private static bool isArm(string boneName) => default; // 0x000000018B72137C-0x000000018B721404
		private static bool isLeg(string boneName) => default; // 0x000000018B7215D4-0x000000018B72165C
		private static bool isTail(string boneName) => default; // 0x000000018B7217A4-0x000000018B72182C
		private static bool isEye(string boneName) => default; // 0x000000018B721404-0x000000018B72148C
		private static bool isTypeExclude(string boneName) => default; // 0x000000018B72182C-0x000000018B721880
		private static bool matchesNaming(string boneName, string[] namingConvention) => default; // 0x000000018B721974-0x000000018B721A24
		private static bool excludesNaming(string boneName, string[] namingConvention) => default; // 0x000000018B7212B8-0x000000018B721320
		private static bool matchesLastLetter(string boneName, string[] namingConvention) => default; // 0x000000018B7218DC-0x000000018B721974
		private static bool LastLetterIs(string boneName, string letter) => default; // 0x000000018B720008-0x000000018B720040
		private static string firstLetter(string boneName) => default; // 0x000000018B721320-0x000000018B72137C
		private static string lastLetter(string boneName) => default; // 0x000000018B721880-0x000000018B7218DC
	}

	[Serializable]
	public class BipedReferences // TypeDefIndex: 53607
	{
		// Fields
		public Transform root; // 0x10
		public Transform pelvis; // 0x18
		public Transform leftThigh; // 0x20
		public Transform leftCalf; // 0x28
		public Transform leftFoot; // 0x30
		public Transform rightThigh; // 0x38
		public Transform rightCalf; // 0x40
		public Transform rightFoot; // 0x48
		public Transform leftUpperArm; // 0x50
		public Transform leftForearm; // 0x58
		public Transform leftHand; // 0x60
		public Transform rightUpperArm; // 0x68
		public Transform rightForearm; // 0x70
		public Transform rightHand; // 0x78
		public Transform head; // 0x80
		public Transform[] spine; // 0x88
		public Transform[] eyes; // 0x90
	
		// Properties
		public virtual bool isFilled { get => default; } // 0x000000018B723238-0x000000018B723544 
		public bool isEmpty { get => default; } // 0x000000018B722394-0x000000018B7226C0 
	
		// Nested types
		public struct AutoDetectParams // TypeDefIndex: 53606
		{
			// Fields
			public bool legsParentInSpine; // 0x00
			public bool includeEyes; // 0x01
	
			// Properties
			public static AutoDetectParams Default { get => default; } // 0x000000018B723B58-0x000000018B723B64 
	
			// Constructors
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes) : this() {
				this.legsParentInSpine = default;
				this.includeEyes = default;
			} // 0x000000018573F200-0x000000018573F5F0
		}
	
		// Constructors
		public BipedReferences() {} // 0x0000000185FD4F70-0x0000000185FD4F80
	
		// Methods
		public virtual bool IsEmpty(bool includeRoot) => default; // 0x000000018B72219C-0x000000018B722394
		public virtual bool Contains(Transform t, bool ignoreRoot = false /* Metadata: 0x020782B1 */) => default; // 0x000000018B7227E0-0x000000018B722F74
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams) => default; // 0x000000018B721CFC-0x000000018B72219C
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams) {} // 0x0000000184EDE2A0-0x0000000184EDE3C0
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams) {} // 0x000000018B723A8C-0x000000018B723B58
		public static bool SetupError(BipedReferences references, ref string errorMessage) => default; // 0x000000018B723544-0x000000018B723600
		public static bool SetupWarning(BipedReferences references, ref string warningMessage) => default; // 0x000000018B721A24-0x000000018B721B00
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm) => default; // 0x000000018B721BB4-0x000000018B721CFC
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams) => default; // 0x000000018B7226C0-0x000000018B7227E0
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams) => default; // 0x000000018B721B00-0x000000018B721BB4
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) {} // 0x0000000184EDD520-0x0000000184EDD900
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) {} // 0x000000018B723600-0x000000018B723894
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) => default; // 0x0000000184EDAA30-0x0000000184EDAD60
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) => default; // 0x00000001814A81B0-0x00000001814A81C0
		private static bool SpineError(BipedReferences references, ref string errorMessage) => default; // 0x0000000185D52F90-0x0000000185D53040
		private static bool SpineWarning(BipedReferences references, ref string warningMessage) => default; // 0x00000001814A81B0-0x00000001814A81C0
		private static bool EyesError(BipedReferences references, ref string errorMessage) => default; // 0x000000018B723894-0x000000018B723A8C
		private static bool EyesWarning(BipedReferences references, ref string warningMessage) => default; // 0x000000018B722F74-0x000000018B723190
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) => default; // 0x000000018B723190-0x000000018B723238
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) => default; // 0x0000000184EDA110-0x0000000184EDA180
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) => default; // 0x0000000185FC8310-0x0000000185FC8320
	}

	public class Comments : MonoBehaviour // TypeDefIndex: 53608
	{
		// Fields
		public string text; // 0x18
	
		// Constructors
		public Comments() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class DemoGUIMessage : MonoBehaviour // TypeDefIndex: 53609
	{
		// Fields
		public string text; // 0x18
		public UnityEngine.Color color; // 0x20
	
		// Constructors
		public DemoGUIMessage() {} // 0x000000018B724194-0x000000018B7241BC
	
		// Methods
		private void OnGUI() {} // 0x000000018B7240F0-0x000000018B724194
	}

	public class Hierarchy // TypeDefIndex: 53610
	{
		// Constructors
		public Hierarchy() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static bool HierarchyIsValid(Transform[] bones) => default; // 0x0000000184EDC940-0x0000000184EDC9B0
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects) => default; // 0x0000000184EDE1C0-0x0000000184EDE2A0
		public static bool IsAncestor(Transform transform, Transform ancestor) => default; // 0x0000000184EDC9B0-0x0000000184EDCAF0
		public static bool ContainsChild(Transform transform, Transform child) => default; // 0x000000018B725B0C-0x000000018B725BE4
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array) {} // 0x000000018B7258B0-0x000000018B725B0C
		public static Transform GetAncestor(Transform transform, int minChildCount) => default; // 0x000000018B725BE4-0x000000018B725CB8
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2) => default; // 0x000000018B725E08-0x000000018B725F34
		public static Transform GetFirstCommonAncestor(Transform[] transforms) => default; // 0x000000018B725F34-0x000000018B726054
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms) => default; // 0x000000018B725CB8-0x000000018B725E08
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms) => default; // 0x000000018B726054-0x000000018B7261F8
	}

	public class InspectorComment : PropertyAttribute // TypeDefIndex: 53611
	{
		// Fields
		public string name; // 0x10
		public string color; // 0x18
	
		// Constructors
		public InspectorComment() {} // Dummy constructor
		public InspectorComment(string name) {} // 0x000000018B72708C-0x000000018B7270F8
		public InspectorComment(string name, string color) {} // 0x000000018B727018-0x000000018B72708C
	}

	[Serializable]
	public enum InterpolationMode // TypeDefIndex: 53612
	{
		None = 0,
		InOutCubic = 1,
		InOutQuintic = 2,
		InOutSine = 3,
		InQuintic = 4,
		InQuartic = 5,
		InCubic = 6,
		InQuadratic = 7,
		InElastic = 8,
		InElasticSmall = 9,
		InElasticBig = 10,
		InSine = 11,
		InBack = 12,
		OutQuintic = 13,
		OutQuartic = 14,
		OutCubic = 15,
		OutInCubic = 16,
		OutInQuartic = 17,
		OutElastic = 18,
		OutElasticSmall = 19,
		OutElasticBig = 20,
		OutSine = 21,
		OutBack = 22,
		OutBackCubic = 23,
		OutBackQuartic = 24,
		BackInCubic = 25,
		BackInQuartic = 26
	}

	public class Interp // TypeDefIndex: 53613
	{
		// Constructors
		public Interp() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static float Float(float t, RootMotion.InterpolationMode mode) => default; // 0x000000018B7270F8-0x000000018B727448
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, RootMotion.InterpolationMode mode) => default; // 0x000000018B727708-0x000000018B7277D8
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed) => default; // 0x00000001844C9040-0x00000001844C90F0
		private static float None(float t, float b, float c) => default; // 0x0000000185FD51D0-0x0000000185FD51E0
		private static float InOutCubic(float t, float b, float c) => default; // 0x0000000185FD5100-0x0000000185FD5130
		private static float InOutQuintic(float t, float b, float c) => default; // 0x0000000185FD5130-0x0000000185FD5180
		private static float InQuintic(float t, float b, float c) => default; // 0x0000000185FD51B0-0x0000000185FD51D0
		private static float InQuartic(float t, float b, float c) => default; // 0x0000000185FD5190-0x0000000185FD51B0
		private static float InCubic(float t, float b, float c) => default; // 0x0000000185FD5020-0x0000000185FD5040
		private static float InQuadratic(float t, float b, float c) => default; // 0x0000000185FD5180-0x0000000185FD5190
		private static float OutQuintic(float t, float b, float c) => default; // 0x0000000185FD5490-0x0000000185FD5500
		private static float OutQuartic(float t, float b, float c) => default; // 0x0000000185FD5430-0x0000000185FD5490
		private static float OutCubic(float t, float b, float c) => default; // 0x0000000185FD5270-0x0000000185FD52B0
		private static float OutInCubic(float t, float b, float c) => default; // 0x0000000185FD53B0-0x0000000185FD53F0
		private static float OutInQuartic(float t, float b, float c) => default; // 0x0000000185FD53F0-0x0000000185FD5430
		private static float BackInCubic(float t, float b, float c) => default; // 0x0000000185FD4FB0-0x0000000185FD4FE0
		private static float BackInQuartic(float t, float b, float c) => default; // 0x0000000185FD4FE0-0x0000000185FD5020
		private static float OutBackCubic(float t, float b, float c) => default; // 0x0000000185FD51E0-0x0000000185FD5220
		private static float OutBackQuartic(float t, float b, float c) => default; // 0x0000000185FD5220-0x0000000185FD5270
		private static float OutElasticSmall(float t, float b, float c) => default; // 0x0000000185FD5330-0x0000000185FD53B0
		private static float OutElasticBig(float t, float b, float c) => default; // 0x0000000185FD52B0-0x0000000185FD5330
		private static float InElasticSmall(float t, float b, float c) => default; // 0x0000000185FD50A0-0x0000000185FD5100
		private static float InElasticBig(float t, float b, float c) => default; // 0x0000000185FD5040-0x0000000185FD50A0
		private static float InSine(float t, float b, float c) => default; // 0x000000018B72758C-0x000000018B7275D8
		private static float OutSine(float t, float b, float c) => default; // 0x000000018B7276CC-0x000000018B727708
		private static float InOutSine(float t, float b, float c) => default; // 0x000000018B727538-0x000000018B72758C
		private static float InElastic(float t, float b, float c) => default; // 0x000000018B727470-0x000000018B727538
		private static float OutElastic(float t, float b, float c) => default; // 0x000000018B727614-0x000000018B7276CC
		private static float InBack(float t, float b, float c) => default; // 0x000000018B727448-0x000000018B727470
		private static float OutBack(float t, float b, float c) => default; // 0x000000018B7275D8-0x000000018B727614
	}

	public static class LayerMaskExtensions // TypeDefIndex: 53614
	{
		// Methods
		public static bool Contains(LayerMask mask, int layer) => default; // 0x000000018B7278B8-0x000000018B7278C8
		public static LayerMask Create(string[] layerNames) => default; // 0x000000018B4CF698-0x000000018B4CF6A0
		public static LayerMask Create(int[] layerNumbers) => default; // 0x000000018B4CF6A0-0x000000018B4CF6A8
		public static LayerMask NamesToMask(string[] layerNames) => default; // 0x000000018B4CF6A8-0x000000018B4CF704
		public static LayerMask LayerNumbersToMask(int[] layerNumbers) => default; // 0x000000018B4CF704-0x000000018B4CF744
		public static LayerMask Inverse(LayerMask original) => default; // 0x0000000185FD2C20-0x0000000185FD2C30
		public static LayerMask AddToMask(LayerMask original, string[] layerNames) => default; // 0x000000018B4CF5B8-0x000000018B4CF5D8
		public static LayerMask RemoveFromMask(LayerMask original, string[] layerNames) => default; // 0x000000018B4CF8E8-0x000000018B4CF90C
		public static string[] MaskToNames(LayerMask original) => default; // 0x000000018B7278C8-0x000000018B7279A4
		public static int[] MaskToNumbers(LayerMask original) => default; // 0x000000018B7279A4-0x000000018B727A6C
		public static string MaskToString(LayerMask original) => default; // 0x000000018B727A6C-0x000000018B727AA8
		public static string MaskToString(LayerMask original, string delimiter) => default; // 0x000000018B727AA8-0x000000018B727B34
	}

	public abstract class LazySingleton<T> : MonoBehaviour // TypeDefIndex: 53615
		where T : LazySingleton<T>
	{
		// Fields
		private static T sInstance;
	
		// Properties
		public static bool hasInstance { get; }
		public static T instance { get; }
	
		// Constructors
		protected LazySingleton() {}
	
		// Methods
		protected virtual void Awake() {}
	}

	public enum ShowIfMode // TypeDefIndex: 53616
	{
		Disabled = 0,
		Hidden = 1
	}

	public class ShowIfAttribute : PropertyAttribute // TypeDefIndex: 53617
	{
		// Fields
		private string _propName_k__BackingField; // 0x10
		private object _propValue_k__BackingField; // 0x18
		private object _otherPropValue_k__BackingField; // 0x20
		private bool _indent_k__BackingField; // 0x28
		private ShowIfMode _mode_k__BackingField; // 0x2C
	
		// Properties
		public string propName { get; protected set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public object propValue { get; protected set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public object otherPropValue { get; protected set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public bool indent { get; private set; } // 0x00000001813B31B0-0x00000001813B31C0 0x00000001813B4840-0x00000001813B4850
		public ShowIfMode mode { get; protected set; } // 0x0000000185FB0630-0x0000000185FB0640 0x0000000185FB0640-0x0000000185FB0650
	
		// Constructors
		public ShowIfAttribute() {} // Dummy constructor
		public ShowIfAttribute(string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x020782CF */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x020782D0 */) {} // 0x000000018B729680-0x000000018B7296C8
	}

	public class ShowRangeIfAttribute : ShowIfAttribute // TypeDefIndex: 53618
	{
		// Fields
		private float _min_k__BackingField; // 0x30
		private float _max_k__BackingField; // 0x34
	
		// Properties
		public float min { get; private set; } // 0x0000000185FB0BE0-0x0000000185FB0BF0 0x0000000185FB0BF0-0x0000000185FB0C00
		public float max { get; private set; } // 0x0000000185FB8060-0x0000000185FB8070 0x0000000185FB8A50-0x0000000185FB8A60
	
		// Constructors
		public ShowRangeIfAttribute() {} // Dummy constructor
		public ShowRangeIfAttribute(float min, float max, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x020782D1 */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x020782D2 */) {} // 0x000000018B72982C-0x000000018B729898
	}

	public class ShowLargeHeaderIf : ShowIfAttribute // TypeDefIndex: 53619
	{
		// Fields
		public string name; // 0x30
		public string color; // 0x38
	
		// Constructors
		public ShowLargeHeaderIf() {} // Dummy constructor
		public ShowLargeHeaderIf(string name, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x020782D3 */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x020782D4 */) {} // 0x000000018B729778-0x000000018B72982C
		public ShowLargeHeaderIf(string name, string color, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x020782D5 */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x020782D6 */) {} // 0x000000018B7296C8-0x000000018B729778
	}

	public class LargeHeader : PropertyAttribute // TypeDefIndex: 53620
	{
		// Fields
		public string name; // 0x10
		public string color; // 0x18
	
		// Constructors
		public LargeHeader() {} // Dummy constructor
		public LargeHeader(string name) {} // 0x000000018B72784C-0x000000018B7278B8
		public LargeHeader(string name, string color) {} // 0x000000018B7277D8-0x000000018B72784C
	}

	public static class QuaTools // TypeDefIndex: 53621
	{
		// Methods
		public static float GetYaw(Quaternion space, Vector3 forward) => default; // 0x000000018B728F54-0x000000018B728FCC
		public static float GetPitch(Quaternion space, Vector3 forward) => default; // 0x000000018B728ED4-0x000000018B728F54
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up) => default; // 0x000000018B728C70-0x000000018B728E18
		public static float GetYaw(Quaternion space, Quaternion rotation) => default; // 0x000000018B728FCC-0x000000018B729090
		public static float GetPitch(Quaternion space, Quaternion rotation) => default; // 0x000000018B728E18-0x000000018B728ED4
		public static float GetBank(Quaternion space, Quaternion rotation) => default; // 0x000000018B728A74-0x000000018B728C70
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight) => default; // 0x000000018B729090-0x000000018B7290EC
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight) => default; // 0x000000018B729518-0x000000018B729574
		public static Quaternion LinearBlend(Quaternion q, float weight) => default; // 0x000000018B7290EC-0x000000018B729168
		public static Quaternion SphericalBlend(Quaternion q, float weight) => default; // 0x000000018B729574-0x000000018B7295F0
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis) => default; // 0x000000018B728724-0x000000018B728838
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation) => default; // 0x00000001852A47D0-0x00000001852A4880
		public static Quaternion FromToRotation(Quaternion from, Quaternion to) => default; // 0x000000018B728838-0x000000018B7288DC
		public static Vector3 GetAxis(Vector3 v) => default; // 0x000000018B7288DC-0x000000018B728A74
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing) => default; // 0x000000018B7285A0-0x000000018B728724
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing) => default; // 0x000000018B7284B4-0x000000018B7285A0
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2) => default; // 0x000000018B729168-0x000000018B729290
		public static Vector3 ToBiPolar(Vector3 euler) => default; // 0x000000018B729630-0x000000018B729680
		public static float ToBiPolar(float angle) => default; // 0x000000018B7295F0-0x000000018B729630
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space) => default; // 0x000000018B729290-0x000000018B729408
		public static Quaternion MirrorYZ(Quaternion r) => default; // 0x000000018B729408-0x000000018B729518
	}

	public abstract class Singleton<T> : MonoBehaviour // TypeDefIndex: 53622
		where T : Singleton<T>
	{
		// Fields
		private static T sInstance;
	
		// Properties
		public static T instance { get; }
	
		// Constructors
		protected Singleton() {}
	
		// Methods
		public static void Clear() {}
		protected virtual void Awake() {}
	}

	public class SolverManager : MonoBehaviour // TypeDefIndex: 53623
	{
		// Fields
		public bool fixTransforms; // 0x18
		private Animator animator; // 0x20
		private Animation legacy; // 0x28
		private bool updateFrame; // 0x30
		private bool componentInitiated; // 0x31
		private bool skipSolverUpdate; // 0x32
	
		// Properties
		private bool animatePhysics { get => default; } // 0x0000000184B98E00-0x0000000184B98F50 
		private bool isAnimated { get => default; } // 0x00000001849D8700-0x00000001849D8790 
	
		// Constructors
		public SolverManager() {} // 0x00000001864717D0-0x00000001864717DC
	
		// Methods
		public void Disable() {} // 0x000000018B729898-0x000000018B729910
		protected virtual void InitiateSolver() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void UpdateSolver() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void FixTransforms() {} // 0x0000000185492010-0x0000000185492020
		private void OnDisable() {} // 0x000000018B729910-0x000000018B72993C
		private void Start() {} // 0x00000001849D8790-0x00000001849D87A0
		public void Initiate() {} // 0x00000001849D87A0-0x00000001849D87E0
		private void Update() {} // 0x0000000184B98C10-0x0000000184B98C50
		private void FindAnimatorRecursive(Transform t, bool findInChildren) {} // 0x00000001849D8610-0x00000001849D8700
		private void FixedUpdate() {} // 0x0000000184B98C90-0x0000000184B98E00
		private void LateUpdate() {} // 0x0000000184B98C50-0x0000000184B98C90
		public void UpdateSolverExternal() {} // 0x000000018B72993C-0x000000018B72996C
	}

	public class TriggerEventBroadcaster : MonoBehaviour // TypeDefIndex: 53624
	{
		// Fields
		public GameObject target; // 0x18
	
		// Constructors
		public TriggerEventBroadcaster() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void OnTriggerEnter(Collider collider) {} // 0x000000018B72996C-0x000000018B729A04
		private void OnTriggerStay(Collider collider) {} // 0x000000018B729A9C-0x000000018B729B34
		private void OnTriggerExit(Collider collider) {} // 0x000000018B729A04-0x000000018B729A9C
	}

	public static class V2Tools // TypeDefIndex: 53625
	{
		// Methods
		public static Vector2 XZ(Vector3 v) => default; // 0x0000000185FB2A20-0x0000000185FB2A40
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2) => default; // 0x000000018B729B84-0x000000018B729BE0
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2) => default; // 0x000000018B729B34-0x000000018B729B84
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r) => default; // 0x000000018B729BE0-0x000000018B729CF4
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r) => default; // 0x000000018B729CF4-0x000000018B729E18
	}

	public static class V3Tools // TypeDefIndex: 53626
	{
		// Methods
		public static float GetYaw(Vector3 forward) => default; // 0x0000000185FD5520-0x0000000185FD5540
		public static float GetPitch(Vector3 forward) => default; // 0x000000018B72A954-0x000000018B72A998
		public static float GetBank(Vector3 forward, Vector3 up) => default; // 0x000000018B72A894-0x000000018B72A954
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward) => default; // 0x000000018B72AA44-0x000000018B72AAF4
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward) => default; // 0x000000018B72A998-0x000000018B72AA44
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up) => default; // 0x000000018B72A6FC-0x000000018B72A894
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight) => default; // 0x000000018B72ACD0-0x000000018B72AD48
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight) => default; // 0x000000018B72AF04-0x000000018B72AF84
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight) => default; // 0x000000018B72A4CC-0x000000018B72A5F8
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight) => default; // 0x000000018B72A388-0x000000018B72A4CC
		public static Vector3 Flatten(Vector3 v, Vector3 normal) => default; // 0x000000018B72A5F8-0x000000018B72A6FC
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing) => default; // 0x000000018B72A1C8-0x000000018B72A388
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed) {
			changed = default;
			return default;
		} // 0x000000018B729E18-0x000000018B729FE4
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue) {
			clampValue = default;
			return default;
		} // 0x000000018B729FE4-0x000000018B72A1C8
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint) => default; // 0x000000018496E700-0x000000018496E850
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal) => default; // 0x000000018B72AD48-0x000000018B72AF04
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point) => default; // 0x000000018B72AF84-0x000000018B72B060
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point) => default; // 0x000000018B72AAF4-0x000000018B72ABE0
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point) => default; // 0x000000018B72ABE0-0x000000018B72ACD0
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point) => default; // 0x000000018B72B060-0x000000018B72B12C
		public static Vector3 Div(Vector3 v1, Vector3 v2) => default; // 0x000000018B632038-0x000000018B63206C
	}

	public static class Warning // TypeDefIndex: 53628
	{
		// Fields
		public static bool logged; // 0x00
	
		// Nested types
		public delegate void Logger(string message); // TypeDefIndex: 53627; 0x000000018B72B12C-0x000000018B72B1CC
	
		// Methods
		public static void Log(string message, Logger logger, bool logInEditMode = false /* Metadata: 0x020782D7 */) {} // 0x0000000185A264E0-0x0000000185A26510
		public static void Log(string message, Transform context, bool logInEditMode = false /* Metadata: 0x020782D8 */) {} // 0x00000001864BB614-0x00000001864BB734
	}
}

namespace RootMotion.Demos
{
	[Serializable]
	public class Navigator // TypeDefIndex: 53630
	{
		// Fields
		public bool activeTargetSeeking; // 0x10
		public float cornerRadius; // 0x14
		public float recalculateOnPathDistance; // 0x18
		public float maxSampleDistance; // 0x1C
		public float nextPathInterval; // 0x20
		private Vector3 _normalizedDeltaPosition_k__BackingField; // 0x24
		private State _state_k__BackingField; // 0x30
		private Transform transform; // 0x38
		private int cornerIndex; // 0x40
		private Vector3[] corners; // 0x48
		private NavMeshPath path; // 0x50
		private Vector3 lastTargetPosition; // 0x58
		private bool initiated; // 0x64
		private float nextPathTime; // 0x68
	
		// Properties
		public Vector3 normalizedDeltaPosition { get; private set; } // 0x0000000185FB8980-0x0000000185FB89A0 0x0000000185FBC070-0x0000000185FBC080
		public State state { get; private set; } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
	
		// Nested types
		public enum State // TypeDefIndex: 53629
		{
			Idle = 0,
			Seeking = 1,
			OnPath = 2
		}
	
		// Constructors
		public Navigator() {} // 0x000000018B728450-0x000000018B7284B4
	
		// Methods
		public void Initiate(Transform transform) {} // 0x000000018B727DA8-0x000000018B727E6C
		public void Update(Vector3 targetPosition) {} // 0x000000018B727E88-0x000000018B728240
		private void CalculatePath(Vector3 targetPosition) {} // 0x000000018B727B34-0x000000018B727BB8
		private bool Find(Vector3 targetPosition) => default; // 0x000000018B727BB8-0x000000018B727D7C
		private void Stop() {} // 0x000000018B727E6C-0x000000018B727E88
		private float HorDistance(Vector3 p1, Vector3 p2) => default; // 0x000000018B727D7C-0x000000018B727DA8
		public void Visualize() {} // 0x000000018B728240-0x000000018B728450
	}
}

namespace RootMotion.FinalIK
{
	public class BipedIK : SolverManager // TypeDefIndex: 53631
	{
		// Fields
		public BipedReferences references; // 0x38
		public BipedIKSolvers solvers; // 0x40
	
		// Constructors
		public BipedIK() {} // 0x0000000184EDA060-0x0000000184EDA110
	
		// Methods
		private void OpenUserManual() {} // 0x000000018B71F070-0x000000018B71F0A4
		private void OpenScriptReference() {} // 0x000000018B71F03C-0x000000018B71F070
		private void SupportGroup() {} // 0x000000018B71F45C-0x000000018B71F490
		private void ASThread() {} // 0x000000018B71EEA0-0x000000018B71EED4
		public float GetIKPositionWeight(AvatarIKGoal goal) => default; // 0x000000018B71EF34-0x000000018B71EF58
		public float GetIKRotationWeight(AvatarIKGoal goal) => default; // 0x000000018B71EFA8-0x000000018B71EFCC
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight) {} // 0x000000018B71F0A4-0x000000018B71F0DC
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight) {} // 0x000000018B71F110-0x000000018B71F148
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition) {} // 0x000000018B71F0DC-0x000000018B71F110
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation) {} // 0x000000018B71F148-0x000000018B71F174
		public Vector3 GetIKPosition(AvatarIKGoal goal) => default; // 0x000000018B71EF58-0x000000018B71EFA8
		public Quaternion GetIKRotation(AvatarIKGoal goal) => default; // 0x000000018B71EFCC-0x000000018B71F004
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes) {} // 0x000000018B71F1A4-0x000000018B71F210
		public void SetLookAtPosition(Vector3 lookAtPosition) {} // 0x000000018B71F174-0x000000018B71F1A4
		public void SetSpinePosition(Vector3 spinePosition) {} // 0x000000018B71F210-0x000000018B71F240
		public void SetSpineWeight(float weight) {} // 0x000000018B71F240-0x000000018B71F268
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal) => default; // 0x000000018B71EED4-0x000000018B71EF34
		public void InitiateBipedIK() {} // 0x000000018B71F004-0x000000018B71F014
		public void UpdateBipedIK() {} // 0x000000018B71F490-0x000000018B71F4A0
		public void SetToDefaults() {} // 0x000000018B71F268-0x000000018B71F45C
		protected override void FixTransforms() {} // 0x00000001844E03B0-0x00000001844E0640
		protected override void InitiateSolver() {} // 0x0000000184EDAF80-0x0000000184EDB140
		protected override void UpdateSolver() {} // 0x00000001844E0640-0x00000001844E0ED0
		public void LogWarning(string message) {} // 0x000000018B71F014-0x000000018B71F03C
	}

	[Serializable]
	public class BipedIKSolvers // TypeDefIndex: 53632
	{
		// Fields
		public IKSolverLimb leftFoot; // 0x10
		public IKSolverLimb rightFoot; // 0x18
		public IKSolverLimb leftHand; // 0x20
		public IKSolverLimb rightHand; // 0x28
		public IKSolverFABRIK spine; // 0x30
		public IKSolverLookAt lookAt; // 0x38
		public IKSolverAim aim; // 0x40
		public Constraints pelvis; // 0x48
		private IKSolverLimb[] _limbs; // 0x50
		private IKSolver[] _ikSolvers; // 0x58
	
		// Properties
		public IKSolverLimb[] limbs { get => default; } // 0x00000001844E0ED0-0x00000001844E0FE0 
		public IKSolver[] ikSolvers { get => default; } // 0x000000018B71ED48-0x000000018B71EEA0 
	
		// Constructors
		public BipedIKSolvers() {} // 0x0000000184EDA180-0x0000000184EDA370
	
		// Methods
		public void AssignReferences(BipedReferences references) {} // 0x0000000184EDAD60-0x0000000184EDAF00
	}

	[Serializable]
	public abstract class Constraint // TypeDefIndex: 53633
	{
		// Fields
		public Transform transform; // 0x10
		public float weight; // 0x18
	
		// Properties
		public bool isValid { get; } // 0x000000018B7240A0-0x000000018B7240F0 
	
		// Constructors
		protected Constraint() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract void UpdateConstraint();
	}

	[Serializable]
	public class ConstraintPosition : Constraint // TypeDefIndex: 53634
	{
		// Fields
		public Vector3 position; // 0x20
	
		// Constructors
		public ConstraintPosition() {} // 0x0000000185492010-0x0000000185492020
		public ConstraintPosition(Transform transform) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void UpdateConstraint() {} // 0x000000018B723D9C-0x000000018B723E48
	}

	[Serializable]
	public class ConstraintPositionOffset : Constraint // TypeDefIndex: 53635
	{
		// Fields
		public Vector3 offset; // 0x20
		private Vector3 defaultLocalPosition; // 0x2C
		private Vector3 lastLocalPosition; // 0x38
		private bool initiated; // 0x44
	
		// Properties
		private bool positionChanged { get => default; } // 0x000000018B723D18-0x000000018B723D9C 
	
		// Constructors
		public ConstraintPositionOffset() {} // 0x0000000185492010-0x0000000185492020
		public ConstraintPositionOffset(Transform transform) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void UpdateConstraint() {} // 0x000000018B723B64-0x000000018B723D18
	}

	[Serializable]
	public class ConstraintRotation : Constraint // TypeDefIndex: 53636
	{
		// Fields
		public Quaternion rotation; // 0x20
	
		// Constructors
		public ConstraintRotation() {} // 0x0000000185492010-0x0000000185492020
		public ConstraintRotation(Transform transform) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void UpdateConstraint() {} // 0x000000018B724008-0x000000018B7240A0
	}

	[Serializable]
	public class ConstraintRotationOffset : Constraint // TypeDefIndex: 53637
	{
		// Fields
		public Quaternion offset; // 0x20
		private Quaternion defaultRotation; // 0x30
		private Quaternion defaultLocalRotation; // 0x40
		private Quaternion lastLocalRotation; // 0x50
		private Quaternion defaultTargetLocalRotation; // 0x60
		private bool initiated; // 0x70
	
		// Properties
		private bool rotationChanged { get => default; } // 0x000000018B723FB0-0x000000018B724008 
	
		// Constructors
		public ConstraintRotationOffset() {} // 0x0000000185492010-0x0000000185492020
		public ConstraintRotationOffset(Transform transform) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void UpdateConstraint() {} // 0x000000018B723E48-0x000000018B723FB0
	}

	[Serializable]
	public class Constraints // TypeDefIndex: 53638
	{
		// Fields
		public Transform transform; // 0x10
		public Transform target; // 0x18
		public Vector3 positionOffset; // 0x20
		public Vector3 position; // 0x2C
		public float positionWeight; // 0x38
		public Vector3 rotationOffset; // 0x3C
		public Vector3 rotation; // 0x48
		public float rotationWeight; // 0x54
	
		// Constructors
		public Constraints() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool IsValid() => default; // 0x00000001844E16A0-0x00000001844E1770
		public void Initiate(Transform transform) {} // 0x0000000184EDA9B0-0x0000000184EDAA30
		public void Update() {} // 0x00000001844E1230-0x00000001844E16A0
	}

	[Serializable]
	public class Finger // TypeDefIndex: 53640
	{
		// Fields
		public float weight; // 0x10
		public float rotationWeight; // 0x14
		public DOF rotationDOF; // 0x18
		public bool fixBone1Twist; // 0x1C
		public Transform bone1; // 0x20
		public Transform bone2; // 0x28
		public Transform bone3; // 0x30
		public Transform tip; // 0x38
		public Transform target; // 0x40
		private bool _initiated_k__BackingField; // 0x48
		private IKSolverLimb solver; // 0x50
		private Quaternion bone3RelativeToTarget; // 0x58
		private Vector3 bone3DefaultLocalPosition; // 0x68
		private Quaternion bone3DefaultLocalRotation; // 0x74
		private Vector3 bone1Axis; // 0x84
		private Vector3 tipAxis; // 0x90
		private Vector3 bone1TwistAxis; // 0x9C
		private Vector3 defaultBendNormal; // 0xA8
	
		// Properties
		public bool initiated { get; private set; } // 0x0000000185FB0750-0x0000000185FB0760 0x0000000185FB0770-0x0000000185FB0780
		public Vector3 IKPosition { get => default; set {} } // 0x000000018B725224-0x000000018B725250 0x000000018B725274-0x000000018B7252A0
		public Quaternion IKRotation { get => default; set {} } // 0x000000018B725250-0x000000018B725274 0x000000018B7252A0-0x000000018B7252C0
	
		// Nested types
		[Serializable]
		public enum DOF // TypeDefIndex: 53639
		{
			One = 0,
			Three = 1
		}
	
		// Constructors
		public Finger() {} // 0x0000000185FD4FA0-0x0000000185FD4FB0
	
		// Methods
		public bool IsValid(ref string errorMessage) => default; // 0x000000018B724A88-0x000000018B724B50
		public void Initiate(Transform hand, int index) {} // 0x000000018B724290-0x000000018B724A88
		public void FixTransforms() {} // 0x000000018B7241BC-0x000000018B724290
		public void StoreDefaultLocalState() {} // 0x000000018B724B50-0x000000018B724C08
		public void Update(float masterWeight) {} // 0x000000018B724C08-0x000000018B725224
	}

	public class FingerRig : SolverManager // TypeDefIndex: 53641
	{
		// Fields
		public float weight; // 0x38
		public Finger[] fingers; // 0x40
		private bool _initiated_k__BackingField; // 0x48
	
		// Properties
		public bool initiated { get; private set; } // 0x0000000185FB0750-0x0000000185FB0760 0x0000000185FB0770-0x0000000185FB0780
	
		// Constructors
		public FingerRig() {} // 0x000000018B72C148-0x000000018B72C1A4
	
		// Methods
		public bool IsValid(ref string errorMessage) => default; // 0x000000018B72BEF8-0x000000018B72BF60
		public void AutoDetect() {} // 0x000000018B72BB9C-0x000000018B72BDF8
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null) {} // 0x000000018B72BA18-0x000000018B72BB9C
		public void RemoveFinger(int index) {} // 0x000000018B72BF60-0x000000018B72C094
		private void AddChildrenRecursive(Transform parent, ref Transform[] array) {} // 0x000000018B72B95C-0x000000018B72BA18
		protected override void InitiateSolver() {} // 0x000000018B72BE60-0x000000018B72BEF8
		public void UpdateFingerSolvers() {} // 0x000000018B72C0E0-0x000000018B72C140
		public void FixFingerTransforms() {} // 0x000000018B72BDF8-0x000000018B72BE4C
		public void StoreDefaultLocalState() {} // 0x000000018B72C094-0x000000018B72C0E0
		protected override void UpdateSolver() {} // 0x000000018B72C140-0x000000018B72C148
		protected override void FixTransforms() {} // 0x000000018B72BE4C-0x000000018B72BE60
	}

	public abstract class Grounder : MonoBehaviour // TypeDefIndex: 53643
	{
		// Fields
		public float weight; // 0x18
		public float maintianPelvisFootWeight; // 0x1C
		public float footAdsorbWeight; // 0x20
		public Grounding solver; // 0x28
		public GrounderDelegate OnPreGrounder; // 0x30
		public GrounderDelegate OnPostGrounder; // 0x38
		public GrounderDelegate OnPostIK; // 0x40
		private bool _initiated_k__BackingField; // 0x48
	
		// Properties
		public bool initiated { get; protected set; } // 0x000000018B73157C-0x000000018B731728 0x000000018B731728-0x000000018B731924
	
		// Nested types
		public delegate void GrounderDelegate(); // TypeDefIndex: 53642; 0x0000000185FB0750-0x0000000185FB0760
	
		// Constructors
		protected Grounder() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		public abstract void ResetPosition(); // 0x000000018B71F014-0x000000018B71F03C
		protected Vector3 GetSpineOffsetTarget() => default;
		protected void LogWarning(string message) {}
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg) => default; // 0x00000001855659C0-0x0000000185565A50
		private Vector3 GetLegSpineTangent(Grounding.Leg leg) => default; // 0x00000001864BC330-0x00000001864BC3F4
		protected abstract void OpenUserManual(); // 0x00000001864BC320-0x00000001864BC330
		protected abstract void OpenScriptReference(); // 0x00000001864BC2FC-0x00000001864BC320
	}

	public class GrounderBipedIK : Grounder // TypeDefIndex: 53644
	{
		// Fields
		public BipedIK ik; // 0x50
		public float spineBend; // 0x58
		public float spineSpeed; // 0x5C
		private Transform[] feet; // 0x60
		private Quaternion[] footRotations; // 0x68
		private Vector3 animatedPelvisLocalPosition; // 0x70
		private Vector3 solvedPelvisLocalPosition; // 0x7C
		private Vector3 spineOffset; // 0x88
		private float lastWeight; // 0x94
		private float lastAdsorbWeight; // 0x98
		private float rightFootOffsetY; // 0x9C
		private float leftFootOffsetY; // 0xA0
		private float rightFootOri; // 0xA4
		private float leftFootOri; // 0xA8
		public Transform ikOriReferenceBone; // 0xB0
	
		// Properties
		public float RightFootOffsetY { get => default; } // 0x0000000185FB9790-0x0000000185FB97A0 
		public float LeftFootOffsetY { get => default; } // 0x0000000185FB9B70-0x0000000185FB9B80 
		public float RightFootOri { get => default; } // 0x0000000185FB8C30-0x0000000185FB8C40 
		public float LeftFootOri { get => default; } // 0x0000000185FB9D40-0x0000000185FB9D50 
	
		// Constructors
		public GrounderBipedIK() {} // 0x0000000185565930-0x00000001855659C0
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B72CAAC-0x000000018B72CAE0
		protected override void OpenScriptReference() {} // 0x000000018B72CA78-0x000000018B72CAAC
		public override void ResetPosition() {} // 0x000000018B72CAE0-0x000000018B72CB20
		private bool IsReadyToInitiate() => default; // 0x0000000184FE4BA0-0x0000000184FE4C60
		private void Update() {} // 0x0000000184FE4B40-0x0000000184FE4BA0
		private void Initiate() {} // 0x0000000184EDE3C0-0x0000000184EDE750
		private void OnDisable() {} // 0x0000000185FAFB90-0x0000000185FAFBB0
		private void OnSolverUpdate() {} // 0x00000001844E1C70-0x00000001844E2790
		private void SetLegIK(IKSolverLimb limb, int index) {} // 0x00000001844E2830-0x00000001844E2CE0
		private void OnPostSolverUpdate() {} // 0x00000001844E1900-0x00000001844E1C70
		private void OnDestroy() {} // 0x0000000185FA3820-0x0000000185FA3880
		private Quaternion ClampPitchAndRollAroundForward(Quaternion Q, Quaternion calfQ, float minPitch, float maxPitch, float minRoll, float maxRoll) => default; // 0x000000018416B4F0-0x000000018416B9F0
		private float NormalizeAngle(float angle) => default; // 0x000000018416B9F0-0x000000018416BDC0
	}

	public class GrounderFBBIK : Grounder // TypeDefIndex: 53646
	{
		// Fields
		public FullBodyBipedIK ik; // 0x50
		public float spineBend; // 0x58
		public float spineSpeed; // 0x5C
		public SpineEffector[] spine; // 0x60
		private Transform[] feet; // 0x68
		private Vector3 spineOffset; // 0x70
		private bool firstSolve; // 0x7C
	
		// Nested types
		[Serializable]
		public class SpineEffector // TypeDefIndex: 53645
		{
			// Fields
			public FullBodyBipedEffector effectorType; // 0x10
			public float horizontalWeight; // 0x14
			public float verticalWeight; // 0x18
	
			// Constructors
			public SpineEffector() {} // 0x000000018B72D6C4-0x000000018B72D6F8
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight) {} // 0x000000018B72D6F8-0x000000018B72D72C
		}
	
		// Constructors
		public GrounderFBBIK() {} // 0x0000000185FD56D0-0x0000000185FD56E0
	
		// Methods
		private void OpenTutorial() {} // 0x000000018B72D690-0x000000018B72D6C4
		protected override void OpenUserManual() {} // 0x000000018B72D72C-0x000000018B72D764
		protected override void OpenScriptReference() {} // 0x000000018B72CE30-0x000000018B72CEA8
		public override void ResetPosition() {} // 0x000000018B72D914-0x000000018B72D970
		private bool IsReadyToInitiate() => default; // 0x0000000185FB7D20-0x0000000185FB7D30
		private void Update() {} // 0x0000000185FB7D20-0x0000000185FB7D30
		private void FixedUpdate() {} // 0x000000018B72CB20-0x000000018B72CE30
		private void LateUpdate() {} // 0x000000018B72D1B4-0x000000018B72D690
		private void Initiate() {} // 0x000000018B72D764-0x000000018B72D914
		private void OnSolverUpdate() {} // 0x000000018B72D08C-0x000000018B72D19C
		private void SetLegIK(IKEffector effector, Grounding.Leg leg) {} // 0x000000018B72D19C-0x000000018B72D1B4
		private void OnDrawGizmosSelected() {} // 0x000000018B72CEA8-0x000000018B72D08C
		private void OnPostSolverUpdate() {} // 0x000000018B72D970-0x000000018B72D9F8
		private void OnDestroy() {} // 0x0000000181BBBA40-0x0000000181BBBA50
	}

	public class GrounderIK : Grounder // TypeDefIndex: 53647
	{
		// Fields
		public IK[] legs; // 0x50
		public Transform pelvis; // 0x58
		public Transform characterRoot; // 0x60
		public float rootRotationWeight; // 0x68
		public float rootRotationSpeed; // 0x6C
		public float maxRootRotationAngle; // 0x70
		private Transform[] feet; // 0x78
		private Quaternion[] footRotations; // 0x80
		private Vector3 animatedPelvisLocalPosition; // 0x88
		private Vector3 solvedPelvisLocalPosition; // 0x94
		private int solvedFeet; // 0xA0
		private bool solved; // 0xA4
		private float lastWeight; // 0xA8
		private Rigidbody characterRootRigidbody; // 0xB0
	
		// Constructors
		public GrounderIK() {} // 0x000000018B72F0C0-0x000000018B72F14C
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B72E720-0x000000018B72E754
		protected override void OpenScriptReference() {} // 0x000000018B72E6EC-0x000000018B72E720
		public override void ResetPosition() {} // 0x000000018B72E754-0x000000018B72E9DC
		private bool IsReadyToInitiate() => default; // 0x000000018B72DE54-0x000000018B72DFD0
		private void OnDisable() {} // 0x000000018B72E1F8-0x000000018B72E2B0
		private void Update() {} // 0x000000018B72ECC4-0x000000018B72F0C0
		private void Initiate() {} // 0x000000018B72D9F8-0x000000018B72DE54
		private void OnSolverUpdate() {} // 0x000000018B72E484-0x000000018B72E6EC
		private void SetLegIK(int index) {} // 0x000000018B72E9DC-0x000000018B72ECC4
		private void OnPostSolverUpdate() {} // 0x000000018B72E2B0-0x000000018B72E484
		private void OnDestroy() {} // 0x000000018B72DFD0-0x000000018B72E1F8
	}

	public class GrounderQuadruped : Grounder // TypeDefIndex: 53649
	{
		// Fields
		public Grounding forelegSolver; // 0x50
		public float rootRotationWeight; // 0x58
		public float minRootRotation; // 0x5C
		public float maxRootRotation; // 0x60
		public float rootRotationSpeed; // 0x64
		public float maxLegOffset; // 0x68
		public float maxForeLegOffset; // 0x6C
		public float maintainHeadRotationWeight; // 0x70
		public Transform characterRoot; // 0x78
		public Transform pelvis; // 0x80
		public Transform lastSpineBone; // 0x88
		public Transform head; // 0x90
		public IK[] legs; // 0x98
		public IK[] forelegs; // 0xA0
		public Vector3 gravity; // 0xA8
		private Foot[] feet; // 0xB8
		private Vector3 animatedPelvisLocalPosition; // 0xC0
		private Quaternion animatedPelvisLocalRotation; // 0xCC
		private Quaternion animatedHeadLocalRotation; // 0xDC
		private Vector3 solvedPelvisLocalPosition; // 0xEC
		private Quaternion solvedPelvisLocalRotation; // 0xF8
		private Quaternion solvedHeadLocalRotation; // 0x108
		private int solvedFeet; // 0x118
		private bool solved; // 0x11C
		private float angle; // 0x120
		private Transform forefeetRoot; // 0x128
		private Quaternion headRotation; // 0x130
		private float lastWeight; // 0x140
		private Rigidbody characterRootRigidbody; // 0x148
	
		// Nested types
		public struct Foot // TypeDefIndex: 53648
		{
			// Fields
			public IKSolver solver; // 0x00
			public Transform transform; // 0x08
			public Quaternion rotation; // 0x10
			public Grounding.Leg leg; // 0x20
	
			// Constructors
			public Foot(IKSolver solver, Transform transform) {
				this.solver = default;
				this.transform = default;
				rotation = default;
				leg = default;
			} // 0x000000018B73098C-0x000000018B7309C0
		}
	
		// Constructors
		public GrounderQuadruped() {} // 0x000000018B72C1A4-0x000000018B72C200
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B730958-0x000000018B73098C
		protected override void OpenScriptReference() {} // 0x000000018B7309C0-0x000000018B730B84
		public override void ResetPosition() {} // 0x000000018B72FBF0-0x000000018B72FCF0
		private bool IsReadyToInitiate() => default; // 0x000000018B72FAA8-0x000000018B72FBF0
		private bool IsReadyToInitiateLegs(IK[] ikComponents) => default; // 0x000000018B72FE0C-0x000000018B72FE78
		private void OnDisable() {} // 0x000000018B731434-0x000000018B731494
		private void Update() {} // 0x000000018B72F6CC-0x000000018B72FAA8
		private void Initiate() {} // 0x000000018B72F368-0x000000018B72F6CC
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset) => default; // 0x000000018B72FCF0-0x000000018B72FDD0
		private void LateUpdate() {} // 0x000000018B730B84-0x000000018B731030
		private void RootRotation() {} // 0x000000018B730150-0x000000018B730958
		private void OnSolverUpdate() {} // 0x000000018B73119C-0x000000018B731434
		private void UpdateForefeetRoot() {} // 0x000000018B731030-0x000000018B73119C
		private void SetFootIK(Foot foot, float maxOffset) {} // 0x000000018B72FE78-0x000000018B730150
		private void OnPostSolverUpdate() {} // 0x000000018B72FDD0-0x000000018B72FE0C
		private void OnDestroy() {} // 0x000000018B72F14C-0x000000018B72F368
		private void DestroyLegs(IK[] ikComponents) {} // 0x000000018B731494-0x000000018B73157C
	}

	[Serializable]
	public class Grounding // TypeDefIndex: 53656
	{
		// Fields
		public Transform IKFootBoneL; // 0x10
		public Transform IKFootBoneR; // 0x18
		[NonSerialized]
		public float floorLogicTheta; // 0x20
		public float floorAnimTheta; // 0x24
		public float floorPredictTheta; // 0x28
		public float floorFeetThetaByFoot; // 0x2C
		[NonSerialized]
		public float floorFeetThetaByRoot; // 0x30
		[NonSerialized]
		public float floorFeetThetaByLogic; // 0x34
		[NonSerialized]
		public float betweenFeetDistance; // 0x38
		[NonSerialized]
		public bool isMoving; // 0x3C
		[NonSerialized]
		public bool isAccelerating; // 0x3D
		[NonSerialized]
		public bool isPlayingMontage; // 0x3E
		[NonSerialized]
		public bool isOnMovableBase; // 0x3F
		[NonSerialized]
		public float SG_timeRef; // 0x40
		[NonSerialized]
		public float gait; // 0x44
		[NonSerialized]
		public float startAnimWeight; // 0x48
		[NonSerialized]
		public Vector3 playerSpeed; // 0x4C
		private bool m_isAcceleratingLastFrame; // 0x58
		[NonSerialized]
		public bool isLastFrameInvalid; // 0x59
		public float maxLegLength; // 0x5C
		public float maxFeetOffset; // 0x60
		public float minPelvisHeight; // 0x64
		public LayerMask layers; // 0x68
		public float maxStep; // 0x6C
		public float heightOffset; // 0x70
		public float footSpeed; // 0x74
		public float footRadius; // 0x78
		public float footCenterOffset; // 0x7C
		public float prediction; // 0x80
		public float footRotationWeight; // 0x84
		public float footRotationSpeed; // 0x88
		public float maxFootRotationAngleFore; // 0x8C
		public float maxFootRotationAngleBack; // 0x90
		public float maxFootRotationAngleIn; // 0x94
		public float maxFootRotationAngleOut; // 0x98
		public bool rotateSolver; // 0x9C
		public float pelvisSpeed; // 0xA0
		public float pelvisSpeedXZ; // 0xA4
		public float pelvisDamper; // 0xA8
		public float lowerPelvisWeight; // 0xAC
		public float liftPelvisWeight; // 0xB0
		public float rootSphereCastRadius; // 0xB4
		public bool overstepFallsDown; // 0xB8
		public Quality quality; // 0xBC
		private BipedReferences _references_k__BackingField; // 0xC0
		private Leg[] _legs_k__BackingField; // 0xC8
		private Pelvis _pelvis_k__BackingField; // 0xD0
		private bool _isGrounded_k__BackingField; // 0xD8
		private Transform _root_k__BackingField; // 0xE0
		private RaycastHit _rootHit_k__BackingField; // 0xE8
		public OnRaycastDelegate Raycast; // 0x128
		public OnCapsuleCastDelegate CapsuleCast; // 0x130
		public OnSphereCastDelegate SphereCast; // 0x138
		private Transform _entityTransform_k__BackingField; // 0x140
		private bool _entityIsOnMovableBase_k__BackingField; // 0x148
		private Vector3 _entityRelativePosition_k__BackingField; // 0x14C
		private Quaternion _entityRelativeRotation_k__BackingField; // 0x158
		private bool lastIsDependingLeftLeg; // 0x168
		private bool isSameLegWithLastFrame; // 0x169
		private float rootDeltaAngle; // 0x16C
		private float pelvisForwardOffset; // 0x170
		private Vector3 m_lastFrameForwardVec; // 0x174
		private bool lastIsUsingLoswest; // 0x180
		private float m_actualMaxFootOffset; // 0x184
		public float forwardFeetOffset; // 0x188
		public bool isUsingLoswest; // 0x18C
		public bool isDependingLeftLeg; // 0x18D
		private bool initiated; // 0x18E
	
		// Properties
		public BipedReferences references { get; private set; } // 0x00000001844C90F0-0x00000001844C9270 0x000000018B732D94-0x000000018B732DB4
		public Leg[] legs { get; private set; } // 0x00000001844C9270-0x00000001844CBFE0 0x0000000185170170-0x0000000185170270
		public Pelvis pelvis { get; private set; } // 0x0000000185170270-0x0000000185170390 0x0000000184CB8590-0x0000000184CB87D0
		public bool isGrounded { get; private set; } // 0x0000000184EC10A0-0x0000000184EC10F0 0x00000001850E5F50-0x00000001850E5F80
		public Transform root { get; private set; } // 0x00000001850E5F20-0x00000001850E5F50 0x000000018446C0E0-0x000000018446CCF0
		public RaycastHit rootHit { get; private set; } // 0x000000018B731E70-0x000000018B73256C 0x00000001842960E0-0x0000000184296530
		public bool rootGrounded { get => default; } // 0x000000018B73256C-0x000000018B7329BC 
		public Transform entityTransform { get; set; } // 0x000000018428B520-0x000000018428B590 0x000000018B732C58-0x000000018B732D20
		public bool entityIsOnMovableBase { get; set; } // 0x000000018B732A48-0x000000018B732C58 0x000000018428B1B0-0x000000018428B520
		public Vector3 entityRelativePosition { get; set; } // 0x000000018496E300-0x000000018496E700 0x000000018428C280-0x000000018428C330
		public Quaternion entityRelativeRotation { get; set; } // 0x00000001844E3750-0x00000001844E3800 0x0000000185FD55E0-0x0000000185FD55F0
		public bool isInitiated { get => default; } // 0x0000000185FB6850-0x0000000185FB6860 
		public Vector3 up { get => default; } // 0x0000000183B7E5A0-0x0000000183B7E5B0 
		public Vector3 forward { get => default; } // 0x00000001855BAB60-0x00000001855BAB90 
		private bool useRootRotation { get => default; } // 0x000000018496D820-0x000000018496DFD0 
	
		// Nested types
		[Serializable]
		public enum Quality // TypeDefIndex: 53650
		{
			Fastest = 0,
			Simple = 1,
			Best = 2,
			Custom = 3
		}
	
		public delegate bool OnRaycastDelegate(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 53651; 0x000000018428C680-0x000000018428C950
	
		public delegate bool OnCapsuleCastDelegate(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 53652; 0x0000000185FB0300-0x0000000185FB0310
	
		public delegate bool OnSphereCastDelegate(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 53653; 0x0000000185FB2610-0x0000000185FB2620
	
		public class Leg // TypeDefIndex: 53654
		{
			// Fields
			private bool _isGrounded_k__BackingField; // 0x10
			private Vector3 _IKPosition_k__BackingField; // 0x14
			public Quaternion rotationOffset; // 0x20
			private bool _initiated_k__BackingField; // 0x30
			private float _heightFromGround_k__BackingField; // 0x34
			private float _fowardMoveFromGround_k__BackingField; // 0x38
			private float _rightMoveFromGround_k__BackingField; // 0x3C
			private Vector3 _velocity_k__BackingField; // 0x40
			private Transform _transform_k__BackingField; // 0x50
			private float _IKOffset_k__BackingField; // 0x58
			private float _IKOffsetZ_k__BackingField; // 0x5C
			private float _IKOffsetX_k__BackingField; // 0x60
			private RaycastHit _heelHit_k__BackingField; // 0x68
			private RaycastHit _capsuleHit_k__BackingField; // 0xA8
			public bool invertFootCenter; // 0xE8
			private Vector3 m_lastEntityPos; // 0xEC
			private Vector3 m_lastFootPos; // 0xF8
			private Vector3 m_lastHeelPoint; // 0x104
			private Vector3 m_lastToePoint; // 0x110
			private Vector3 m_lastSidePoint; // 0x11C
			private Grounding grounding; // 0x128
			private float lastTime; // 0x130
			private float deltaTime; // 0x134
			private Vector3 lastPosition; // 0x138
			private Quaternion toHitNormal; // 0x144
			private Quaternion r; // 0x154
			private Vector3 up; // 0x164
			private Vector3 forward; // 0x170
			private Vector3 speedDir; // 0x17C
			private Vector3 lastTransformPosition; // 0x188
			private bool doOverrideFootPosition; // 0x194
			private Vector3 overrideFootPosition; // 0x198
			public Vector3 transformPosition; // 0x1A4
			private static readonly ProfilerMarker MARKER_TEMP_PREDICT_FOOT_CAST; // 0x00
			private static readonly ProfilerMarker MARKER_TEMP_BUILTIN_BEST_CAST; // 0x08
			public const float MAX_PREDICTION_DISTANCE = 2.25f; // Metadata: 0x020782E8
			private Vector2 lastFramePredictPos; // 0x1B0
			public Vector3 predictOffset; // 0x1B8
			public Vector3 lastPredictOffset; // 0x1C4
			public Vector3 lastPredictOffsetwithPercent; // 0x1D0
			private Vector3 m_predictOffsetwithPercent; // 0x1DC
			private bool hasPredictThisStep; // 0x1E8
			public RaycastHit curPredictHit; // 0x1F0
			public float curStepTime; // 0x230
			public RaycastHit curCapsuleHit; // 0x238
			public Vector3 lastLandFootPos; // 0x278
			private float feetOffsetFromRoot; // 0x284
			public Vector3 lastPathPoint; // 0x288
			public RaycastHit m_heelHit; // 0x298
			public Vector3 curFeetCalculatePos; // 0x2D8
			private Vector3 lastCurHitPoint; // 0x2E4
			public Vector3 predictLimitForwardOffset; // 0x2F0
			private float m_maxStep; // 0x2FC
			private Vector3 m_lastHitNormal; // 0x300
			private bool m_isInStair; // 0x30C
			public float footSpeed; // 0x310
			public float heightFromRoot; // 0x314
			public bool isLastFrameLegStretch; // 0x318
			private Vector3 lastCapusuleHitPos; // 0x31C
	
			// Properties
			public bool isGrounded { get; private set; } // 0x0000000187A4749C-0x0000000187A474B0 0x0000000185FCC570-0x0000000185FCC5A0
			public Vector3 IKPosition { get; private set; } // 0x0000000185FD55B0-0x0000000185FD55E0 0x00000001840A27C0-0x00000001840A27D0
			public bool initiated { get; private set; } // 0x0000000185FB85F0-0x0000000185FB8600 0x0000000187A47758-0x0000000187A4776C
			public float heightFromGround { get; private set; } // 0x0000000185FB9470-0x0000000185FB9480 0x0000000185FD5570-0x0000000185FD5580
			public float fowardMoveFromGround { get; private set; } // 0x0000000185FD5540-0x0000000185FD5560 0x0000000185FD5580-0x0000000185FD55A0
			public float rightMoveFromGround { get; private set; } // 0x0000000185FD5560-0x0000000185FD5570 0x0000000185FD55A0-0x0000000185FD55B0
			public Vector3 velocity { get; private set; } // 0x00000001847FDCA0-0x00000001847FE180 0x00000001855BAC00-0x00000001855BACE0
			public Transform transform { get; private set; } // 0x00000001855BA720-0x00000001855BA9B0 0x0000000184217570-0x00000001842186B0
			public float IKOffset { get; private set; } // 0x000000018B731BF4-0x000000018B731DE8 0x000000018B731E00-0x000000018B731E70
			public float IKOffsetZ { get; private set; } // 0x0000000183EAA150-0x0000000183EAA160 0x000000018B731DE8-0x000000018B731E00
			public float IKOffsetX { get; private set; } // 0x000000018428CCD0-0x000000018428CD30 0x000000018496E230-0x000000018496E2D0
			public RaycastHit heelHit { get; private set; } // 0x000000018428CC80-0x000000018428CCD0 0x000000018B731A04-0x000000018B731AF8
			public RaycastHit capsuleHit { get; private set; } // 0x000000018428CD30-0x000000018428CD50 0x000000018B731AF8-0x000000018B731BF4
			public RaycastHit GetHitPoint { get => default; } // 0x0000000185565A50-0x0000000185565C10 
			public Vector3 right { get => default; } // 0x0000000187218D1C-0x0000000187218D8C 
			public Vector3 speedRight { get => default; } // 0x000000018B732EF4-0x000000018B733020 
			public Vector3 predictOffsetwithPercent { get => default; } // 0x000000018B732DB4-0x000000018B732EF4 
			private bool isLeft { get => default; } // 0x000000018B733020-0x000000018B73314C 
			private bool isMoving { get => default; } // 0x0000000187207114-0x0000000187207140 
			public float stepHeightFromGround { get => default; } // 0x00000001814294C0-0x00000001814294D0 
			public float stepForwardFromGround { get => default; } // 0x000000018142A360-0x000000018142A370 
			public float stepRightFromGround { get => default; } // 0x0000000185FB8060-0x0000000185FB8070 
			private Vector3 animFootGroundPos { get => default; } // 0x0000000185FBD3C0-0x0000000185FBD3D0 
			public float rootYOffset { get => default; } // 0x0000000185FB2200-0x0000000185FB2210 
	
			// Constructors
			public Leg() {} // 0x0000000185FD5640-0x0000000185FD5670
			static Leg() {} // 0x0000000185FD56A0-0x0000000185FD56D0
	
			// Methods
			public void SetFootPosition(Vector3 position) {} // 0x0000000185565CA0-0x0000000185565D30
			public void Initiate(Grounding grounding, Transform transform) {} // 0x0000000187207114-0x0000000187207140
			public void OnEnable() {} // 0x0000000185565D30-0x0000000185565DC0
			public void Reset() {} // 0x00000001872182C8-0x000000018721836C
			private void _ResetPredictReference(RaycastHit curHit) {} // 0x0000000187207114-0x0000000187207140
			private void _PredictNextStepHit(Vector3 prediction, Vector3 predictVec, bool canChangeHeight = true /* Metadata: 0x020782E6 */) {} // 0x0000000185565C10-0x0000000185565CA0
			private float _CanHitPointLand(RaycastHit hit, out RaycastHit predictHit) {
				predictHit = default;
				return default;
			} // 0x0000000187217C60-0x0000000187217CDC
			public void Process() {} // 0x0000000181C2FD60-0x0000000181C2FD70
			private void _UpdateHeelHit(float curStepPercent, Vector3 prediction) {} // 0x000000018184FBD0-0x000000018184FBE0
			private Vector3 _UpdatePredictOffset(float curStepPercent) => default; // 0x0000000181C6BA90-0x0000000181C6BAB0
			public void FinalSetIKPosition(Vector3 thighPos) {} // 0x0000000185FCF170-0x0000000185FCF180
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel, Vector3 predictPos) => default; // 0x0000000185FB8A50-0x0000000185FB8A60
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel) => default; // 0x0000000185FB24B0-0x0000000185FB24C0
			private RaycastHit GetRaycastHitCustom(Vector3 offsetFromHeel) => default; // 0x0000000185FB24C0-0x0000000185FB24D0
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel) => default; // 0x0000000185FB0580-0x0000000185FB0590
			private Vector3 RotateNormal(Vector3 normal) => default; // 0x0000000185FB05E0-0x0000000185FB05F0
			private void SetFootToPoint(Vector3 normal, Vector3 point) {} // 0x0000000185FB3620-0x0000000185FB3640
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint) {} // 0x0000000185FB3650-0x0000000185FB3660
			private void SetFootToPoint(Vector3 normal, Vector3 pointForXZ, Vector3 pointForY) {} // 0x0000000181460F60-0x0000000181460F70
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint, Vector3 footNormal, bool isLimitByComplex = true /* Metadata: 0x020782E7 */) {} // 0x0000000184A4E570-0x0000000184A4E580
			private float GetHeightFromGround(Vector3 hitPoint) => default; // 0x0000000181DE2580-0x0000000181DE2590
			private void RotateFoot() {} // 0x0000000181DE28C0-0x0000000181DE28D0
			private Quaternion GetRotationOffsetTarget() => default; // 0x0000000185FB89D0-0x0000000185FB89E0
			private Vector3 RotateNormalWithLimit(Vector3 normal) => default; // 0x0000000185FB2230-0x0000000185FB2240
		}
	
		public class Pelvis // TypeDefIndex: 53655
		{
			// Fields
			private Vector3 _IKOffset_k__BackingField; // 0x10
			private float _heightOffset_k__BackingField; // 0x1C
			private float forwardOffset; // 0x20
			public float pelivsSpeedY; // 0x24
			private Grounding grounding; // 0x28
			private Vector3 lastRootPosition; // 0x30
			private float damperF; // 0x3C
			private bool initiated; // 0x40
			private float lastTime; // 0x44
	
			// Properties
			public Vector3 IKOffset { get; private set; } // 0x0000000185FD5610-0x0000000185FD5640 0x0000000185FD5670-0x0000000185FD56A0
			public float heightOffset { get; private set; } // 0x000000018B732D20-0x000000018B732D94 0x0000000185FD55F0-0x0000000185FD5610
	
			// Constructors
			public Pelvis() {} // 0x00000001850449D0-0x0000000185044A20
	
			// Methods
			public void Initiate(Grounding grounding) {} // 0x000000018428CD50-0x000000018428CE90
			public void Reset() {} // 0x00000001855F09F0-0x00000001855F0A80
			public void OnEnable() {} // 0x00000001855BAA20-0x00000001855BAB00
			public void Process(float pelivsOffset, float _forwardOffset, bool isGrounded, bool islastFrameLegStretch = false /* Metadata: 0x020782EC */, bool isSameLegReflastFrame = false /* Metadata: 0x020782ED */) {} // 0x00000001855BAB00-0x00000001855BAB60
			private RaycastHit GetRaycastHitCustom(Vector3 rayOrigin) => default; // 0x000000018B7329BC-0x000000018B732A48
		}
	
		// Constructors
		public Grounding() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void _UpdateFloorPredictTheta() {} // 0x0000000184C41980-0x0000000184C41A00
		private void _UpdateFloorFeetThetaByFoot() {} // 0x00000001848EE8D0-0x00000001848EEB00
		private void _UpdateFloorFeetThetaByRoot() {} // 0x00000001848EEB00-0x00000001848EEED0
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f /* Metadata: 0x020782DE */) => default; // 0x0000000184216810-0x0000000184216A90
		public bool IsValid(ref string errorMessage) => default; // 0x000000018428C950-0x000000018428CC80
		public void Initiate(Transform root, Transform[] feet, BipedReferences references = null) {} // 0x000000018428B590-0x000000018428C070
		public void Update() {} // 0x00000001855BA9B0-0x00000001855BAA20
		public Vector3 GetLegsPlaneNormal() => default; // 0x0000000185F0E200-0x0000000185F0E2A0
		public void Reset() {} // 0x00000001834AE2B0-0x00000001834AE2D0
		public void LogWarning(string message) {} // 0x0000000185FB0850-0x0000000185FB0860
		public float GetVerticalOffset(Vector3 p1, Vector3 p2) => default; // 0x000000018B733514-0x000000018B733594
		public Vector3 Flatten(Vector3 v) => default; // 0x00000001855BAB90-0x00000001855BAC00
		public Vector3 GetFootCenterOffset() => default; // 0x000000018B73314C-0x000000018B733514
	}

	public class AimIK : IK // TypeDefIndex: 53657
	{
		// Fields
		public IKSolverAim solver; // 0x38
	
		// Constructors
		public AimIK() {} // 0x000000018B72B3D8-0x000000018B72B44C
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B72B370-0x000000018B72B3A4
		protected override void OpenScriptReference() {} // 0x000000018B72B308-0x000000018B72B33C
		private void OpenSetupTutorial() {} // 0x000000018B72B33C-0x000000018B72B370
		private void SupportGroup() {} // 0x000000018B72B3A4-0x000000018B72B3D8
		private void ASThread() {} // 0x000000018B72B2D4-0x000000018B72B308
		public override IKSolver GetIKSolver() => default; // 0x00000001813ECBC0-0x00000001813ECBD0
	}

	public class ArmIK : IK // TypeDefIndex: 53658
	{
		// Fields
		public IKSolverArm solver; // 0x38
	
		// Constructors
		public ArmIK() {} // 0x000000018B72B51C-0x000000018B72B590
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B72B4B4-0x000000018B72B4E8
		protected override void OpenScriptReference() {} // 0x000000018B72B480-0x000000018B72B4B4
		private void SupportGroup() {} // 0x000000018B72B4E8-0x000000018B72B51C
		private void ASThread() {} // 0x000000018B72B44C-0x000000018B72B480
		public override IKSolver GetIKSolver() => default; // 0x00000001813ECBC0-0x00000001813ECBD0
	}

	public class CCDIK : IK // TypeDefIndex: 53659
	{
		// Fields
		public IKSolverCCD solver; // 0x38
	
		// Constructors
		public CCDIK() {} // 0x000000018B72B660-0x000000018B72B6D4
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B72B5F8-0x000000018B72B62C
		protected override void OpenScriptReference() {} // 0x000000018B72B5C4-0x000000018B72B5F8
		private void SupportGroup() {} // 0x000000018B72B62C-0x000000018B72B660
		private void ASThread() {} // 0x000000018B72B590-0x000000018B72B5C4
		public override IKSolver GetIKSolver() => default; // 0x00000001813ECBC0-0x00000001813ECBD0
	}

	public class FABRIK : IK // TypeDefIndex: 53660
	{
		// Fields
		public IKSolverFABRIK solver; // 0x38
	
		// Constructors
		public FABRIK() {} // 0x000000018B72B8E8-0x000000018B72B95C
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B72B880-0x000000018B72B8B4
		protected override void OpenScriptReference() {} // 0x000000018B72B84C-0x000000018B72B880
		private void SupportGroup() {} // 0x000000018B72B8B4-0x000000018B72B8E8
		private void ASThread() {} // 0x000000018B72B818-0x000000018B72B84C
		public override IKSolver GetIKSolver() => default; // 0x00000001813ECBC0-0x00000001813ECBD0
	}

	public class FABRIKRoot : IK // TypeDefIndex: 53661
	{
		// Fields
		public IKSolverFABRIKRoot solver; // 0x38
	
		// Constructors
		public FABRIKRoot() {} // 0x000000018B72B7A4-0x000000018B72B818
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B72B73C-0x000000018B72B770
		protected override void OpenScriptReference() {} // 0x000000018B72B708-0x000000018B72B73C
		private void SupportGroup() {} // 0x000000018B72B770-0x000000018B72B7A4
		private void ASThread() {} // 0x000000018B72B6D4-0x000000018B72B708
		public override IKSolver GetIKSolver() => default; // 0x00000001813ECBC0-0x00000001813ECBD0
	}

	public class FullBodyBipedIK : IK // TypeDefIndex: 53662
	{
		// Fields
		public BipedReferences references; // 0x38
		public IKSolverFullBodyBiped solver; // 0x40
	
		// Constructors
		public FullBodyBipedIK() {} // 0x000000018B72C9CC-0x000000018B72CA78
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B72C3A8-0x000000018B72C3DC
		protected override void OpenScriptReference() {} // 0x000000018B72C340-0x000000018B72C374
		private void OpenSetupTutorial() {} // 0x000000018B72C374-0x000000018B72C3A8
		private void OpenInspectorTutorial() {} // 0x000000018B72C30C-0x000000018B72C340
		private void SupportGroup() {} // 0x000000018B72C998-0x000000018B72C9CC
		private void ASThread() {} // 0x000000018B72C200-0x000000018B72C234
		public void SetReferences(BipedReferences references, Transform rootNode) {} // 0x000000018B72C95C-0x000000018B72C998
		public override IKSolver GetIKSolver() => default; // 0x00000001813FF010-0x00000001813FF020
		public bool ReferencesError(ref string errorMessage) => default; // 0x000000018B72C3DC-0x000000018B72C5BC
		public bool ReferencesWarning(ref string warningMessage) => default; // 0x000000018B72C5BC-0x000000018B72C930
		private void Reinitiate() {} // 0x000000018B72C930-0x000000018B72C95C
		private void AutoDetectReferences() {} // 0x000000018B72C234-0x000000018B72C30C
	}

	public abstract class IK : SolverManager // TypeDefIndex: 53663
	{
		// Constructors
		protected IK() {} // 0x00000001864717D0-0x00000001864717DC
	
		// Methods
		public abstract IKSolver GetIKSolver();
		protected override void UpdateSolver() {} // 0x000000018B744510-0x000000018B744570
		protected override void InitiateSolver() {} // 0x000000018B7444B4-0x000000018B744510
		protected override void FixTransforms() {} // 0x000000018B744470-0x000000018B7444B4
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}

	public class IKExecutionOrder : MonoBehaviour // TypeDefIndex: 53664
	{
		// Fields
		public IK[] IKComponents; // 0x18
		public Animator animator; // 0x20
		private bool fixedFrame; // 0x28
	
		// Properties
		private bool animatePhysics { get => default; } // 0x000000018B73F438-0x000000018B73F4B0 
	
		// Constructors
		public IKExecutionOrder() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Start() {} // 0x000000018B73F3B8-0x000000018B73F40C
		private void Update() {} // 0x000000018B73F40C-0x000000018B73F438
		private void FixedUpdate() {} // 0x000000018B73F314-0x000000018B73F344
		private void LateUpdate() {} // 0x000000018B73F344-0x000000018B73F3B8
		private void FixTransforms() {} // 0x000000018B73F2A4-0x000000018B73F314
	}

	public class LegIK : IK // TypeDefIndex: 53665
	{
		// Fields
		public IKSolverLeg solver; // 0x38
	
		// Constructors
		public LegIK() {} // 0x000000018B7446B8-0x000000018B74472C
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B744650-0x000000018B744684
		protected override void OpenScriptReference() {} // 0x000000018B74461C-0x000000018B744650
		private void SupportGroup() {} // 0x000000018B744684-0x000000018B7446B8
		private void ASThread() {} // 0x000000018B7445E8-0x000000018B74461C
		public override IKSolver GetIKSolver() => default; // 0x00000001813ECBC0-0x00000001813ECBD0
	}

	public class LimbIK : IK // TypeDefIndex: 53666
	{
		// Fields
		public IKSolverLimb solver; // 0x38
	
		// Constructors
		public LimbIK() {} // 0x000000018B7447FC-0x000000018B744870
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B744794-0x000000018B7447C8
		protected override void OpenScriptReference() {} // 0x000000018B744760-0x000000018B744794
		private void SupportGroup() {} // 0x000000018B7447C8-0x000000018B7447FC
		private void ASThread() {} // 0x000000018B74472C-0x000000018B744760
		public override IKSolver GetIKSolver() => default; // 0x00000001813ECBC0-0x00000001813ECBD0
	}

	public class LookAtIK : IK // TypeDefIndex: 53667
	{
		// Fields
		public IKSolverLookAt solver; // 0x38
	
		// Constructors
		public LookAtIK() {} // 0x000000018B744940-0x000000018B7449B4
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B7448D8-0x000000018B74490C
		protected override void OpenScriptReference() {} // 0x000000018B7448A4-0x000000018B7448D8
		private void SupportGroup() {} // 0x000000018B74490C-0x000000018B744940
		private void ASThread() {} // 0x000000018B744870-0x000000018B7448A4
		public override IKSolver GetIKSolver() => default; // 0x00000001813ECBC0-0x00000001813ECBD0
	}

	public class TrigonometricIK : IK // TypeDefIndex: 53668
	{
		// Fields
		public IKSolverTrigonometric solver; // 0x38
	
		// Constructors
		public TrigonometricIK() {} // 0x000000018B745E00-0x000000018B745E74
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B745D98-0x000000018B745DCC
		protected override void OpenScriptReference() {} // 0x000000018B745D64-0x000000018B745D98
		private void SupportGroup() {} // 0x000000018B745DCC-0x000000018B745E00
		private void ASThread() {} // 0x000000018B745D30-0x000000018B745D64
		public override IKSolver GetIKSolver() => default; // 0x00000001813ECBC0-0x00000001813ECBD0
	}

	public class VRIK : IK // TypeDefIndex: 53670
	{
		// Fields
		public References references; // 0x38
		public IKSolverVR solver; // 0x40
	
		// Nested types
		[Serializable]
		public class References // TypeDefIndex: 53669
		{
			// Fields
			public Transform root; // 0x10
			public Transform pelvis; // 0x18
			public Transform spine; // 0x20
			public Transform chest; // 0x28
			public Transform neck; // 0x30
			public Transform head; // 0x38
			public Transform leftShoulder; // 0x40
			public Transform leftUpperArm; // 0x48
			public Transform leftForearm; // 0x50
			public Transform leftHand; // 0x58
			public Transform rightShoulder; // 0x60
			public Transform rightUpperArm; // 0x68
			public Transform rightForearm; // 0x70
			public Transform rightHand; // 0x78
			public Transform leftThigh; // 0x80
			public Transform leftCalf; // 0x88
			public Transform leftFoot; // 0x90
			public Transform leftToes; // 0x98
			public Transform rightThigh; // 0xA0
			public Transform rightCalf; // 0xA8
			public Transform rightFoot; // 0xB0
			public Transform rightToes; // 0xB8
	
			// Properties
			public bool isFilled { get => default; } // 0x000000018B745E74-0x000000018B745E98 
			public bool isEmpty { get => default; } // 0x000000018B745E98-0x000000018B745EC4 
	
			// Constructors
			public References() {} // 0x000000018B745F94-0x000000018B745FC8
			public References(BipedReferences b) {} // 0x000000018B745F2C-0x000000018B745F60
	
			// Methods
			public Transform[] GetTransforms() => default; // 0x000000018B745F60-0x000000018B745F94
			public static bool AutoDetectReferences(Transform root, out References references) {
				references = default;
				return default;
			} // 0x00000001813FF010-0x00000001813FF020
		}
	
		// Constructors
		public VRIK() {} // 0x000000018B744B60-0x000000018B744FF8
	
		// Methods
		protected override void OpenUserManual() {} // 0x000000018B745EC4-0x000000018B745F2C
		protected override void OpenScriptReference() {} // 0x000000018B745FC8-0x000000018B74611C
		private void OpenSetupTutorial() {} // 0x000000018B74611C-0x000000018B7461B8
		public void AutoDetectReferences() {} // 0x0000000185492010-0x0000000185492020
		public void GuessHandOrientations() {} // 0x000000018B745318-0x000000018B74555C
		public override IKSolver GetIKSolver() => default; // 0x000000018B744FF8-0x000000018B745318
		protected override void InitiateSolver() {} // 0x000000018B7458CC-0x000000018B745D30
		protected override void UpdateSolver() {} // 0x000000018B74555C-0x000000018B7458CC
	}

	[Serializable]
	public class FABRIKChain // TypeDefIndex: 53671
	{
		// Fields
		public FABRIK ik; // 0x10
		public float pull; // 0x18
		public float pin; // 0x1C
		public int[] children; // 0x20
	
		// Constructors
		public FABRIKChain() {} // 0x000000018B735CDC-0x000000018B735D2C
	
		// Methods
		public bool IsValid(ref string message) => default; // 0x000000018B735A10-0x000000018B735AC0
		public void Initiate() {} // 0x000000018B7359EC-0x000000018B735A10
		public void Stage1(FABRIKChain[] chain) {} // 0x000000018B735AC0-0x000000018B735BB4
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain) {} // 0x000000018B735BB4-0x000000018B735CDC
		private Vector3 GetCentroid(FABRIKChain[] chain) => default; // 0x000000018B7356F0-0x000000018B7359EC
	}

	public class FBBIKArmBending : MonoBehaviour // TypeDefIndex: 53672
	{
		// Fields
		public FullBodyBipedIK ik; // 0x18
		public Vector3 bendDirectionOffsetLeft; // 0x20
		public Vector3 bendDirectionOffsetRight; // 0x2C
		public Vector3 characterSpaceBendOffsetLeft; // 0x38
		public Vector3 characterSpaceBendOffsetRight; // 0x44
		private Quaternion leftHandTargetRotation; // 0x50
		private Quaternion rightHandTargetRotation; // 0x60
		private bool initiated; // 0x70
	
		// Constructors
		public FBBIKArmBending() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void LateUpdate() {} // 0x000000018B735D2C-0x000000018B736348
		private void OnPostFBBIK() {} // 0x000000018B736470-0x000000018B736644
		private void OnDestroy() {} // 0x000000018B736348-0x000000018B736470
	}

	public class FBBIKHeadEffector : MonoBehaviour // TypeDefIndex: 53674
	{
		// Fields
		public FullBodyBipedIK ik; // 0x18
		public float positionWeight; // 0x20
		public float bodyWeight; // 0x24
		public float thighWeight; // 0x28
		public bool handsPullBody; // 0x2C
		public float rotationWeight; // 0x30
		public float bodyClampWeight; // 0x34
		public float headClampWeight; // 0x38
		public float bendWeight; // 0x3C
		public BendBone[] bendBones; // 0x40
		public float CCDWeight; // 0x48
		public float roll; // 0x4C
		public float damper; // 0x50
		public Transform[] CCDBones; // 0x58
		public float postStretchWeight; // 0x60
		public float maxStretch; // 0x64
		public float stretchDamper; // 0x68
		public bool fixHead; // 0x6C
		public Transform[] stretchBones; // 0x70
		public Vector3 chestDirection; // 0x78
		public float chestDirectionWeight; // 0x84
		public Transform[] chestBones; // 0x88
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK; // 0x90
		private Vector3 offset; // 0x98
		private Vector3 headToBody; // 0xA4
		private Vector3 shoulderCenterToHead; // 0xB0
		private Vector3 headToLeftThigh; // 0xBC
		private Vector3 headToRightThigh; // 0xC8
		private Vector3 leftShoulderPos; // 0xD4
		private Vector3 rightShoulderPos; // 0xE0
		private float shoulderDist; // 0xEC
		private float leftShoulderDist; // 0xF0
		private float rightShoulderDist; // 0xF4
		private Quaternion chestRotation; // 0xF8
		private Quaternion headRotationRelativeToRoot; // 0x108
		private Quaternion[] ccdDefaultLocalRotations; // 0x118
		private Vector3 headLocalPosition; // 0x120
		private Quaternion headLocalRotation; // 0x12C
		private Vector3[] stretchLocalPositions; // 0x140
		private Quaternion[] stretchLocalRotations; // 0x148
		private Vector3[] chestLocalPositions; // 0x150
		private Quaternion[] chestLocalRotations; // 0x158
		private int bendBonesCount; // 0x160
		private int ccdBonesCount; // 0x164
		private int stretchBonesCount; // 0x168
		private int chestBonesCount; // 0x16C
	
		// Nested types
		[Serializable]
		public class BendBone // TypeDefIndex: 53673
		{
			// Fields
			public Transform transform; // 0x10
			public float weight; // 0x18
			private Quaternion defaultLocalRotation; // 0x1C
	
			// Constructors
			public BendBone() {} // 0x000000018B7397FC-0x000000018B739CAC
			public BendBone(Transform transform, float weight) {} // 0x000000018B738AC4-0x000000018B738FF8
	
			// Methods
			public void StoreDefaultLocalState() {} // 0x000000018B737C5C-0x000000018B738048
			public void FixTransforms() {} // 0x000000018B738248-0x000000018B738AC4
		}
	
		// Constructors
		public FBBIKHeadEffector() {} // 0x000000018B733594-0x000000018B7335C8
	
		// Methods
		private void Start() {} // 0x000000018B7394CC-0x000000018B7397FC
		private void OnStoreDefaultLocalState() {} // 0x000000018B736644-0x000000018B7369CC
		private void OnFixTransforms() {} // 0x000000018B736C78-0x000000018B737728
		private void OnPreRead() {} // 0x000000018B738048-0x000000018B738248
		private void SpineBend() {} // 0x000000018B7369CC-0x000000018B736C78
		private void CCDPass() {} // 0x000000018B738FF8-0x000000018B739360
		private void Iterate(int iteration) {} // 0x000000018B737728-0x000000018B737848
		private void OnPostUpdate() {} // 0x000000018B739360-0x000000018B7394CC
		private void ChestDirection() {} // 0x000000018B737848-0x000000018B737C5C
		private void PostStretching() {} // 0x000000018B739CAC-0x000000018B739E80
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset) {} // 0x000000018B733634-0x000000018B733658
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance) {} // 0x000000018B7335FC-0x000000018B733634
		private void OnDestroy() {} // 0x000000018B7335C8-0x000000018B7335FC
	}

	[Serializable]
	public class FBIKChain // TypeDefIndex: 53677
	{
		// Fields
		public float pin; // 0x10
		public float pull; // 0x14
		public float push; // 0x18
		public float pushParent; // 0x1C
		public float reach; // 0x20
		public Smoothing reachSmoothing; // 0x24
		public Smoothing pushSmoothing; // 0x28
		public IKSolver.Node[] nodes; // 0x30
		public int[] children; // 0x38
		public ChildConstraint[] childConstraints; // 0x40
		public IKConstraintBend bendConstraint; // 0x48
		private float rootLength; // 0x50
		private bool initiated; // 0x54
		private float length; // 0x58
		private float distance; // 0x5C
		private IKSolver.Point p; // 0x60
		private float reachForce; // 0x68
		private float pullParentSum; // 0x6C
		private float[] crossFades; // 0x70
		private float sqrMag1; // 0x78
		private float sqrMag2; // 0x7C
		private float sqrMagDif; // 0x80
		private const float maxLimbLength = 0.99999f; // Metadata: 0x020782EF
	
		// Nested types
		[Serializable]
		public class ChildConstraint // TypeDefIndex: 53675
		{
			// Fields
			public float pushElasticity; // 0x10
			public float pullElasticity; // 0x14
			private Transform bone1; // 0x18
			private Transform bone2; // 0x20
			private float _nominalDistance_k__BackingField; // 0x28
			private bool _isRigid_k__BackingField; // 0x2C
			private float crossFade; // 0x30
			private float inverseCrossFade; // 0x34
			private int chain1Index; // 0x38
			private int chain2Index; // 0x3C
	
			// Properties
			public float nominalDistance { get; private set; } // 0x000000018B73C5B4-0x000000018B73C6B8 0x000000018B73C458-0x000000018B73C5B4
			public bool isRigid { get; private set; } // 0x000000018B73B728-0x000000018B73B820 0x000000018B73A834-0x000000018B73A8DC
	
			// Constructors
			public ChildConstraint() {} // Dummy constructor
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f /* Metadata: 0x020782F3 */, float pullElasticity = 0f /* Metadata: 0x020782F7 */) {} // 0x000000018B73AA74-0x000000018B73AB58
	
			// Methods
			public void Initiate(IKSolverFullBody solver) {} // 0x000000018B73A8DC-0x000000018B73AA74
			public void OnPreSolve(IKSolverFullBody solver) {} // 0x000000018B73B24C-0x000000018B73B728
			public void Solve(IKSolverFullBody solver) {} // 0x000000018B73A02C-0x000000018B73A538
		}
	
		[Serializable]
		public enum Smoothing // TypeDefIndex: 53676
		{
			None = 0,
			Exponential = 1,
			Cubic = 2
		}
	
		// Constructors
		public FBIKChain() {} // 0x000000018B73AEE8-0x000000018B73B24C
		public FBIKChain(float pin, float pull, Transform[] nodeTransforms) {} // 0x000000018B73AB58-0x000000018B73AEE8
	
		// Methods
		public void SetNodes(Transform[] boneTransforms) {} // 0x000000018B73BC20-0x000000018B73BF1C
		public int GetNodeIndex(Transform boneTransform) => default; // 0x000000018B73BF1C-0x000000018B73C338
		public bool IsValid(ref string message) => default; // 0x000000018B73C338-0x000000018B73C458
		public void Initiate(IKSolverFullBody solver) {} // 0x000000018B73B884-0x000000018B73B998
		public void ReadPose(IKSolverFullBody solver, bool fullBody) {} // 0x000000018B73B998-0x000000018B73BA70
		private void CalculateBoneLengths(IKSolverFullBody solver) {} // 0x000000018B73A674-0x000000018B73A834
		public void Reach(IKSolverFullBody solver) {} // 0x000000018B73B820-0x000000018B73B884
		public Vector3 Push(IKSolverFullBody solver) => default; // 0x000000018B73BA70-0x000000018B73BC20
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false /* Metadata: 0x020782EE */) {} // 0x000000018B73A538-0x000000018B73A674
		public void Stage1(IKSolverFullBody solver) {} // 0x000000018B739E80-0x000000018B73A02C
		public void Stage2(IKSolverFullBody solver, Vector3 position) {} // 0x0000000185FB0A50-0x0000000185FB0A60
		public void SolveConstraintSystems(IKSolverFullBody solver) {} // 0x0000000185FB0A60-0x0000000185FB0A70
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x0000000185FB08C0-0x0000000185FB08D0
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude) => default; // 0x0000000185FB08D0-0x0000000185FB08E0
		private void SolveChildConstraints(IKSolverFullBody solver) {} // 0x000000018B7356B4-0x000000018B7356F0
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance) {} // 0x000000018B735174-0x000000018B7351CC
		public void ForwardReach(Vector3 position) {} // 0x000000018B7351CC-0x000000018B7353A0
		private void BackwardReach(Vector3 position) {} // 0x000000018B7353A0-0x000000018B7356B4
	}

	[Serializable]
	public class IKConstraintBend // TypeDefIndex: 53678
	{
		// Fields
		public Transform bone1; // 0x10
		public Transform bone2; // 0x18
		public Transform bone3; // 0x20
		public Transform bendGoal; // 0x28
		public Vector3 direction; // 0x30
		public Quaternion rotationOffset; // 0x3C
		public float weight; // 0x4C
		public Vector3 defaultLocalDirection; // 0x50
		public Vector3 defaultChildDirection; // 0x5C
		[NonSerialized]
		public float clampF; // 0x68
		private int chainIndex1; // 0x6C
		private int nodeIndex1; // 0x70
		private int chainIndex2; // 0x74
		private int nodeIndex2; // 0x78
		private int chainIndex3; // 0x7C
		private int nodeIndex3; // 0x80
		private bool _initiated_k__BackingField; // 0x84
		private bool limbOrientationsSet; // 0x85
	
		// Properties
		public bool initiated { get; private set; } // 0x0000000185FB2E40-0x0000000185FB2E50 0x0000000185FB2EA0-0x0000000185FB2EB0
	
		// Constructors
		public IKConstraintBend() {} // 0x000000018B73D97C-0x000000018B73D99C
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3) {} // 0x000000018B73D94C-0x000000018B73D97C
	
		// Methods
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger) => default; // 0x000000018B73CF64-0x000000018B73D0F0
		public void SetBones(Transform bone1, Transform bone2, Transform bone3) {} // 0x000000018496F6A0-0x000000018496F6E0
		public void Initiate(IKSolverFullBody solver) {} // 0x000000018B73CC74-0x000000018B73CF64
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last) {} // 0x000000018B73D74C-0x000000018B73D94C
		public void LimitBend(float solverWeight, float positionWeight) {} // 0x000000018B73D0F0-0x000000018B73D554
		public Vector3 GetDir(IKSolverFullBody solver) => default; // 0x000000018B73C6B8-0x000000018B73CC74
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent) => default; // 0x000000018B73D650-0x000000018B73D74C
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent) => default; // 0x000000018B73D554-0x000000018B73D650
	}

	[Serializable]
	public class IKEffector // TypeDefIndex: 53679
	{
		// Fields
		public Transform bone; // 0x10
		public Transform target; // 0x18
		public float positionWeight; // 0x20
		public float rotationWeight; // 0x24
		public Vector3 position; // 0x28
		public Quaternion rotation; // 0x34
		public Vector3 positionOffset; // 0x44
		private bool _isEndEffector_k__BackingField; // 0x50
		public bool effectChildNodes; // 0x51
		public float maintainRelativePositionWeight; // 0x54
		public Transform[] childBones; // 0x58
		public Transform planeBone1; // 0x60
		public Transform planeBone2; // 0x68
		public Transform planeBone3; // 0x70
		public Quaternion planeRotationOffset; // 0x78
		private float posW; // 0x88
		private float rotW; // 0x8C
		private Vector3[] localPositions; // 0x90
		private bool usePlaneNodes; // 0x98
		private Quaternion animatedPlaneRotation; // 0x9C
		private Vector3 animatedPosition; // 0xAC
		private bool firstUpdate; // 0xB8
		private int chainIndex; // 0xBC
		private int nodeIndex; // 0xC0
		private int plane1ChainIndex; // 0xC4
		private int plane1NodeIndex; // 0xC8
		private int plane2ChainIndex; // 0xCC
		private int plane2NodeIndex; // 0xD0
		private int plane3ChainIndex; // 0xD4
		private int plane3NodeIndex; // 0xD8
		private int[] childChainIndexes; // 0xE0
		private int[] childNodeIndexes; // 0xE8
	
		// Properties
		public bool isEndEffector { get; private set; } // 0x00000001813ECBE0-0x00000001813ECBF0 0x00000001813EE9A0-0x00000001813EE9B0
	
		// Constructors
		public IKEffector() {} // 0x000000018B73EFE0-0x000000018B73F128
		public IKEffector(Transform bone, Transform[] childBones) {} // 0x000000018B73F128-0x000000018B73F2A4
	
		// Methods
		public IKSolver.Node GetNode(IKSolverFullBody solver) => default; // 0x000000018B73D99C-0x000000018B73D9F4
		public void PinToBone(float positionWeight, float rotationWeight) {} // 0x000000018B73EA78-0x000000018B73EB40
		public bool IsValid(IKSolver solver, ref string message) => default; // 0x000000018B73E1DC-0x000000018B73E42C
		public void Initiate(IKSolverFullBody solver) {} // 0x000000018B73DF00-0x000000018B73E1DC
		public void ResetOffset(IKSolverFullBody solver) {} // 0x000000018B73EB40-0x000000018B73EC20
		public void SetToTarget() {} // 0x000000018B73EC20-0x000000018B73ECC0
		public void OnPreSolve(IKSolverFullBody solver) {} // 0x000000018B73E440-0x000000018B73EA78
		public void OnPostWrite() {} // 0x000000018B73E42C-0x000000018B73E440
		private Quaternion GetPlaneRotation(IKSolverFullBody solver) => default; // 0x000000018B73D9F4-0x000000018B73DC08
		public void Update(IKSolverFullBody solver) {} // 0x000000018B73ECC0-0x000000018B73EFE0
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset) {
			planeRotationOffset = default;
			return default;
		} // 0x000000018B73DC08-0x000000018B73DF00
	}

	[Serializable]
	public class IKMapping // TypeDefIndex: 53681
	{
		// Nested types
		[Serializable]
		public class BoneMap // TypeDefIndex: 53680
		{
			// Fields
			public Transform transform; // 0x10
			public int chainIndex; // 0x18
			public int nodeIndex; // 0x1C
			public Vector3 defaultLocalPosition; // 0x20
			public Quaternion defaultLocalRotation; // 0x2C
			public Vector3 localSwingAxis; // 0x3C
			public Vector3 localTwistAxis; // 0x48
			public Vector3 planePosition; // 0x54
			public Vector3 ikPosition; // 0x60
			public Quaternion defaultLocalTargetRotation; // 0x6C
			private Quaternion maintainRotation; // 0x7C
			public float length; // 0x8C
			public Quaternion animatedRotation; // 0x90
			private Transform planeBone1; // 0xA0
			private Transform planeBone2; // 0xA8
			private Transform planeBone3; // 0xB0
			private int plane1ChainIndex; // 0xB8
			private int plane1NodeIndex; // 0xBC
			private int plane2ChainIndex; // 0xC0
			private int plane2NodeIndex; // 0xC4
			private int plane3ChainIndex; // 0xC8
			private int plane3NodeIndex; // 0xCC
	
			// Properties
			public Vector3 swingDirection { get => default; } // 0x0000000185492010-0x0000000185492020 
			public bool isNodeBone { get => default; } // 0x0000000185492010-0x0000000185492020 
			private Quaternion lastAnimatedTargetRotation { get => default; } // 0x000000018B734258-0x000000018B734400 
	
			// Constructors
			public BoneMap() {} // 0x000000018B734484-0x000000018B734600
	
			// Methods
			public void Initiate(Transform transform, IKSolverFullBody solver) {} // 0x00000001840A27C0-0x00000001840A27D0
			public void StoreDefaultLocalState() {} // 0x000000018B7421C4-0x000000018B7422C0
			public void FixTransform(bool position) {} // 0x000000018B73B998-0x000000018B73BA70
			public void SetLength(BoneMap nextBone) {} // 0x000000018B733A84-0x000000018B733AD0
			public void SetLocalSwingAxis(BoneMap swingTarget) {} // 0x000000018B73496C-0x000000018B7349E8
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2) {} // 0x000000018B7341FC-0x000000018B734258
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection) {} // 0x000000018B73375C-0x000000018B7337C4
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3) {} // 0x000000018B734764-0x000000018B73476C
			public void UpdatePlane(bool rotation, bool position) {} // 0x000000018B733E58-0x000000018B733EF8
			public void SetIKPosition() {} // 0x000000018B734028-0x000000018B734034
			public void MaintainRotation() {} // 0x000000018B733EF8-0x000000018B734028
			public void SetToIKPosition() {} // 0x000000018B734034-0x000000018B7340D4
			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null) {} // 0x000000018B7340D4-0x000000018B7341C0
			public Vector3 GetPlanePosition(IKSolverFullBody solver) => default; // 0x000000018B734600-0x000000018B734764
			public void PositionToPlane(IKSolverFullBody solver) {} // 0x000000018B733E1C-0x000000018B733E58
			public void RotateToPlane(IKSolverFullBody solver, float weight) {} // 0x000000018B733AD0-0x000000018B733B04
			public void Swing(Vector3 swingTarget, float weight) {} // 0x000000018B7341C0-0x000000018B7341FC
			public void Swing(Vector3 pos1, Vector3 pos2, float weight) {} // 0x000000018B733658-0x000000018B73375C
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight) {} // 0x000000018B7337C4-0x000000018B7338BC
			public void RotateToMaintain(float weight) {} // 0x000000018B733B04-0x000000018B733B54
			public void RotateToEffector(IKSolverFullBody solver, float weight) {} // 0x000000018B733D34-0x000000018B733E1C
			private Quaternion GetTargetRotation(IKSolverFullBody solver) => default; // 0x000000018B734400-0x000000018B734484
		}
	
		// Constructors
		public IKMapping() {} // 0x0000000185FD56E0-0x0000000185FD5710
	
		// Methods
		public virtual bool IsValid(IKSolver solver, ref string message) => default; // 0x000000018B733C9C-0x000000018B733D34
		public virtual void Initiate(IKSolverFullBody solver) {} // 0x000000018B733B54-0x000000018B733C9C
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger = null) => default; // 0x000000018B7338BC-0x000000018B733A84
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x000000018B73476C-0x000000018B73496C
	}

	[Serializable]
	public class IKMappingBone : IKMapping // TypeDefIndex: 53682
	{
		// Fields
		public Transform bone; // 0x10
		public float maintainRotationWeight; // 0x18
		private BoneMap boneMap; // 0x20
	
		// Constructors
		public IKMappingBone() {} // 0x000000018B73F668-0x000000018B73F6EC
		public IKMappingBone(Transform bone) {} // 0x000000018B73F6EC-0x000000018B73F788
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message) => default; // 0x000000018B73F57C-0x000000018B73F5F8
		public void StoreDefaultLocalState() {} // 0x000000018B73F618-0x000000018B73F638
		public void FixTransforms() {} // 0x000000018B73F4B0-0x000000018B73F4D4
		public override void Initiate(IKSolverFullBody solver) {} // 0x000000018B73F4D4-0x000000018B73F57C
		public void ReadPose() {} // 0x000000018B73F5F8-0x000000018B73F618
		public void WritePose(float solverWeight) {} // 0x000000018B73F638-0x000000018B73F668
	}

	[Serializable]
	public class IKMappingLimb : IKMapping // TypeDefIndex: 53684
	{
		// Fields
		public Transform parentBone; // 0x10
		public Transform bone1; // 0x18
		public Transform bone2; // 0x20
		public Transform bone3; // 0x28
		public float maintainRotationWeight; // 0x30
		public float weight; // 0x34
		[NonSerialized]
		public bool updatePlaneRotations; // 0x38
		private BoneMap boneMapParent; // 0x40
		private BoneMap boneMap1; // 0x48
		private BoneMap boneMap2; // 0x50
		private BoneMap boneMap3; // 0x58
	
		// Nested types
		[Serializable]
		public enum BoneMapType // TypeDefIndex: 53683
		{
			Parent = 0,
			Bone1 = 1,
			Bone2 = 2,
			Bone3 = 3
		}
	
		// Constructors
		public IKMappingLimb() {} // 0x000000018B740274-0x000000018B7403E8
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null) {} // 0x000000018B7403E8-0x000000018B7405C8
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message) => default; // 0x000000018B73FBC4-0x000000018B73FC54
		public BoneMap GetBoneMap(BoneMapType boneMap) => default; // 0x000000018B73F830-0x000000018B73F8D0
		public void SetLimbOrientation(Vector3 upper, Vector3 lower) {} // 0x000000018B73FD18-0x000000018B740060
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null) {} // 0x000000018B73FCD0-0x000000018B73FD18
		public void StoreDefaultLocalState() {} // 0x000000018B740060-0x000000018B7400FC
		public void FixTransforms() {} // 0x000000018B73F788-0x000000018B73F830
		public override void Initiate(IKSolverFullBody solver) {} // 0x000000018B73F8D0-0x000000018B73FBC4
		public void ReadPose() {} // 0x000000018B73FC54-0x000000018B73FCD0
		public void WritePose(IKSolverFullBody solver, bool fullBody) {} // 0x000000018B7400FC-0x000000018B740274
	}

	[Serializable]
	public class IKMappingSpine : IKMapping // TypeDefIndex: 53685
	{
		// Fields
		public Transform[] spineBones; // 0x10
		public Transform leftUpperArmBone; // 0x18
		public Transform rightUpperArmBone; // 0x20
		public Transform leftThighBone; // 0x28
		public Transform rightThighBone; // 0x30
		public int iterations; // 0x38
		public float twistWeight; // 0x3C
		private int rootNodeIndex; // 0x40
		private BoneMap[] spine; // 0x48
		private BoneMap leftUpperArm; // 0x50
		private BoneMap rightUpperArm; // 0x58
		private BoneMap leftThigh; // 0x60
		private BoneMap rightThigh; // 0x68
		private bool useFABRIK; // 0x70
	
		// Constructors
		public IKMappingSpine() {} // 0x000000018B742024-0x000000018B7421C4
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) {} // 0x000000018B741E0C-0x000000018B742024
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message) => default; // 0x000000018B741048-0x000000018B74131C
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) {} // 0x0000000189EDC1D4-0x0000000189EDC230
		public void StoreDefaultLocalState() {} // 0x000000018B7419AC-0x000000018B741A00
		public void FixTransforms() {} // 0x000000018B7406EC-0x000000018B740758
		public override void Initiate(IKSolverFullBody solver) {} // 0x000000018B7408AC-0x000000018B741048
		private bool UseFABRIK() => default; // 0x000000018B741A00-0x000000018B741A2C
		public void ReadPose() {} // 0x000000018B741690-0x000000018B7419AC
		public void WritePose(IKSolverFullBody solver) {} // 0x000000018B741A2C-0x000000018B741E0C
		public void ForwardReach(Vector3 position) {} // 0x000000018B740758-0x000000018B7408AC
		private void BackwardReach(Vector3 position) {} // 0x000000018B7405C8-0x000000018B7406EC
		private void MapToSolverPositions(IKSolverFullBody solver) {} // 0x000000018B74131C-0x000000018B741690
	}

	[Serializable]
	public abstract class IKSolver // TypeDefIndex: 53691
	{
		// Fields
		public bool executedInEditor; // 0x10
		public Vector3 IKPosition; // 0x14
		public float IKPositionWeight; // 0x20
		private bool _initiated_k__BackingField; // 0x24
		public UpdateDelegate OnPreInitiate; // 0x28
		public UpdateDelegate OnPostInitiate; // 0x30
		public UpdateDelegate OnPreUpdate; // 0x38
		public UpdateDelegate OnPostUpdate; // 0x40
		protected bool firstInitiation; // 0x48
		protected Transform root; // 0x50
	
		// Properties
		public bool initiated { get; private set; } // 0x000000018B7350A4-0x000000018B735114 0x000000018B735020-0x000000018B7350A4
	
		// Nested types
		[Serializable]
		public class Point // TypeDefIndex: 53686
		{
			// Fields
			public Transform transform; // 0x10
			public float weight; // 0x18
			public Vector3 solverPosition; // 0x1C
			public Quaternion solverRotation; // 0x28
			public Vector3 defaultLocalPosition; // 0x38
			public Quaternion defaultLocalRotation; // 0x44
	
			// Constructors
			public Point() {} // 0x0000000181C9AC70-0x0000000181C9AC80
	
			// Methods
			public void StoreDefaultLocalState() {} // 0x000000018B744070-0x000000018B7440C4
			public void FixTransform() {}
			public void UpdateSolverPosition() {} // 0x0000000184EDB140-0x0000000184EDB260
			public void UpdateSolverLocalPosition() {} // 0x00000001844E0FE0-0x00000001844E1040
			public void UpdateSolverState() {} // 0x0000000181C6BA90-0x0000000181C6BAB0
			public void UpdateSolverLocalState() {} // 0x0000000185FCF170-0x0000000185FCF180
		}
	
		[Serializable]
		public class Bone : Point // TypeDefIndex: 53687
		{
			// Fields
			public float length; // 0x58
			public float sqrMag; // 0x5C
			public Vector3 axis; // 0x60
			private RotationLimit _rotationLimit; // 0x70
			private bool isLimited; // 0x78
	
			// Properties
			public RotationLimit rotationLimit { get => default; set {} } // 0x000000018B74444C-0x000000018B744470 0x0000000181460F60-0x0000000181460F70
	
			// Constructors
			public Bone() {}
			public Bone(Transform transform) {}
			public Bone(Transform transform, float weight) {}
	
			// Methods
			public void Swing(Vector3 swingTarget, float weight = 1f /* Metadata: 0x02078302 */) {} // 0x0000000185FB0810-0x0000000185FB0820
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x02078306 */) {} // 0x0000000185FB0820-0x0000000185FB0830
			public void Swing2D(Vector3 swingTarget, float weight = 1f /* Metadata: 0x0207830A */) {}
			public void SetToSolverPosition() {}
		}
	
		[Serializable]
		public class Node : Point // TypeDefIndex: 53688
		{
			// Fields
			public float length; // 0x58
			public float effectorPositionWeight; // 0x5C
			public float effectorRotationWeight; // 0x60
			public Vector3 offset; // 0x64
	
			// Constructors
			public Node() {}
			public Node(Transform transform) {} // 0x000000018B7440C4-0x000000018B7440DC
			public Node(Transform transform, float weight) {} // 0x0000000184EDC780-0x0000000184EDC870
		}
	
		public delegate void UpdateDelegate(); // TypeDefIndex: 53689; 0x000000018B7440DC-0x000000018B74444C
	
		public delegate void IterationDelegate(int i); // TypeDefIndex: 53690; 0x000000018B744AC8-0x000000018B744B04
	
		// Constructors
		protected IKSolver() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		public bool IsValid() => default; // 0x000000018B744A6C-0x000000018B744AC8
		public abstract bool IsValid(ref string message); // 0x0000000184EDA980-0x0000000184EDA9B0
		public void Initiate(Transform root) {} // 0x0000000184EDD100-0x0000000184EDD1F0
		public void Update() {} // 0x000000018B735114-0x000000018B735174
		public virtual Vector3 GetIKPosition() => default; // 0x000000018B734E1C-0x000000018B735020
		public void SetIKPosition(Vector3 position) {} // 0x000000018B734A24-0x000000018B734C4C
		public float GetIKPositionWeight() => default; // 0x000000018B734C4C-0x000000018B734E1C
		public void SetIKPositionWeight(float weight) {} // 0x000000018B7349E8-0x000000018B734A24
		public Transform GetRoot() => default; // 0x0000000184EDA920-0x0000000184EDA980
		public abstract Point[] GetPoints(); // 0x000000018B7449E4-0x000000018B7449EC
		public abstract Point GetPoint(Transform transform); // 0x000000018B7449B4-0x000000018B7449E4
		public abstract void FixTransforms(); // 0x000000018B7449EC-0x000000018B744A30
		public abstract void StoreDefaultLocalState(); // 0x000000018454C420-0x000000018454C490
		protected abstract void OnInitiate(); // 0x00000001864BC320-0x00000001864BC330
		protected abstract void OnUpdate(); // 0x00000001864BC2FC-0x00000001864BC320
		protected void LogWarning(string message) {} // 0x00000001864BB614-0x00000001864BB734
		public static Transform ContainsDuplicateBone(Bone[] bones) => default; // 0x000000018789F4A4-0x000000018789F56C
		public static bool HierarchyIsValid(Bone[] bones) => default; // 0x00000001833EEC70-0x00000001833EEC80
		protected static float PreSolveBones(ref Bone[] bones) => default; // 0x000000018B744570-0x000000018B7445E8
	}

	[Serializable]
	public class IKSolverAim : IKSolverHeuristic // TypeDefIndex: 53692
	{
		// Fields
		public Transform transform; // 0x88
		public Vector3 axis; // 0x90
		public Vector3 poleAxis; // 0x9C
		public Vector3 polePosition; // 0xA8
		public float poleWeight; // 0xB4
		public Transform poleTarget; // 0xB8
		public float clampWeight; // 0xC0
		public int clampSmoothing; // 0xC4
		public IterationDelegate OnPreIteration; // 0xC8
		private float step; // 0xD0
		private Vector3 clampedIKPosition; // 0xD4
		private RotationLimit transformLimit; // 0xE0
		private Transform lastTransform; // 0xE8
	
		// Properties
		public Vector3 transformAxis { get => default; } // 0x000000018B742E54-0x000000018B742ED8 
		public Vector3 transformPoleAxis { get => default; } // 0x000000018B742ED8-0x000000018B742F5C 
		protected override int minBones { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
		protected override Vector3 localDirection { get => default; } // 0x000000018B742DA4-0x000000018B742E54 
	
		// Constructors
		public IKSolverAim() {} // 0x0000000184EDA530-0x0000000184EDA590
	
		// Methods
		public float GetAngle() => default; // 0x000000018B7422C0-0x000000018B74238C
		protected override void OnInitiate() {} // 0x0000000184EDB4F0-0x0000000184EDB670
		protected override void OnUpdate() {} // 0x0000000184CEA520-0x0000000184CEA830
		private void Solve() {} // 0x000000018B742C90-0x000000018B742DA4
		private Vector3 GetClampedIKPosition() => default; // 0x000000018B74238C-0x000000018B742760
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight) {} // 0x000000018B742760-0x000000018B742C90
	}

	[Serializable]
	public class IKSolverArm : IKSolver // TypeDefIndex: 53693
	{
		// Fields
		public float IKRotationWeight; // 0x58
		public Quaternion IKRotation; // 0x5C
		public Point chest; // 0x70
		public Point shoulder; // 0x78
		public Point upperArm; // 0x80
		public Point forearm; // 0x88
		public Point hand; // 0x90
		public bool isLeft; // 0x98
		public IKSolverVR.Arm arm; // 0xA0
		private Vector3[] positions; // 0xA8
		private Quaternion[] rotations; // 0xB0
	
		// Constructors
		public IKSolverArm() {} // 0x000000018B743E78-0x000000018B744070
	
		// Methods
		public override bool IsValid(ref string message) => default; // 0x000000018B743230-0x000000018B74352C
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root) => default; // 0x000000018B743A98-0x000000018B743B48
		public override Point[] GetPoints() => default; // 0x000000018B74312C-0x000000018B743230
		public override Point GetPoint(Transform transform) => default; // 0x000000018B742FC0-0x000000018B74312C
		public override void StoreDefaultLocalState() {} // 0x000000018B743BC8-0x000000018B743C28
		public override void FixTransforms() {} // 0x000000018B742F5C-0x000000018B742FC0
		protected override void OnInitiate() {} // 0x000000018B74352C-0x000000018B7435A8
		protected override void OnUpdate() {} // 0x000000018B7435A8-0x000000018B7435D4
		private void Solve() {} // 0x000000018B743B48-0x000000018B743BC8
		private void Read() {} // 0x000000018B7435D4-0x000000018B743A98
		private void Write() {} // 0x000000018B743C28-0x000000018B743E78
	}

	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic // TypeDefIndex: 53694
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
	
		// Constructors
		public IKSolverCCD() {} // 0x000000018B746CE0-0x000000018B746CE8
	
		// Methods
		public void FadeOutBoneWeights() {} // 0x000000018B7461B8-0x000000018B746250
		protected override void OnInitiate() {} // 0x000000018B746250-0x000000018B7462CC
		protected override void OnUpdate() {} // 0x000000018B7462CC-0x000000018B746584
		protected void Solve(Vector3 targetPosition) {} // 0x000000018B746584-0x000000018B746CE0
	}

	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic // TypeDefIndex: 53695
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
		private bool[] limitedBones; // 0x90
		private Vector3[] solverLocalPositions; // 0x98
	
		// Properties
		protected override bool boneLengthCanBeZero { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public IKSolverFABRIK() {} // 0x0000000184EDA590-0x0000000184EDA620
	
		// Methods
		public void SolveForward(Vector3 position) {} // 0x000000018B74955C-0x000000018B7495F8
		public void SolveBackward(Vector3 position) {} // 0x000000018B7494C0-0x000000018B74955C
		public override Vector3 GetIKPosition() => default; // 0x000000018B748604-0x000000018B7486A0
		protected override void OnInitiate() {} // 0x0000000184EDBF00-0x0000000184EDC260
		protected override void OnUpdate() {} // 0x0000000185120F20-0x0000000185120F70
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x000000018B7495F8-0x000000018B7496E0
		private void OnPreSolve() {} // 0x000000018B748FF4-0x000000018B7494C0
		private void OnPostSolve() {} // 0x000000018B748FAC-0x000000018B748FF4
		private void Solve(Vector3 targetPosition) {} // 0x000000018B7496E0-0x000000018B749768
		private void ForwardReach(Vector3 position) {} // 0x000000018B748428-0x000000018B748604
		private void SolverMove(int index, Vector3 offset) {} // 0x000000018B7498F4-0x000000018B749988
		private void SolverRotate(int index, Quaternion rotation, bool recursive) {} // 0x000000018B749A0C-0x000000018B749A9C
		private void SolverRotateChildren(int index, Quaternion rotation) {} // 0x000000018B749988-0x000000018B749A0C
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation) {} // 0x000000018B749768-0x000000018B7498F4
		private Quaternion GetParentSolverRotation(int index) => default; // 0x0000000184EDB760-0x0000000184EDB890
		private Vector3 GetParentSolverPosition(int index) => default; // 0x0000000184EDB890-0x0000000184EDB9E0
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed) {
			changed = default;
			return default;
		} // 0x000000018B7486A0-0x000000018B7487DC
		private void LimitForward(int rotateBone, int limitBone) {} // 0x000000018B7487DC-0x000000018B748D50
		private void BackwardReach(Vector3 position) {} // 0x000000018B7483F4-0x000000018B748428
		private void BackwardReachUnlimited(Vector3 position) {} // 0x000000018B7482D4-0x000000018B7483F4
		private void BackwardReachLimited(Vector3 position) {} // 0x000000018B747D18-0x000000018B7482D4
		private void MapToSolverPositions() {} // 0x000000018B748E40-0x000000018B748FAC
		private void MapToSolverPositionsLimited() {} // 0x000000018B748D50-0x000000018B748E40
	}

	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver // TypeDefIndex: 53696
	{
		// Fields
		public int iterations; // 0x58
		public float rootPin; // 0x5C
		public FABRIKChain[] chains; // 0x60
		private bool zeroWeightApplied; // 0x68
		private bool[] isRoot; // 0x70
		private Vector3 rootDefaultPosition; // 0x78
	
		// Constructors
		public IKSolverFABRIKRoot() {} // 0x000000018B747CC0-0x000000018B747D18
	
		// Methods
		public override bool IsValid(ref string message) => default; // 0x000000018B747318-0x000000018B747964
		public override void StoreDefaultLocalState() {} // 0x000000018B747C30-0x000000018B747CC0
		public override void FixTransforms() {} // 0x000000018B746DE0-0x000000018B746E80
		protected override void OnInitiate() {} // 0x000000018B747964-0x000000018B747A34
		private bool IsRoot(int index) => default; // 0x000000018B747288-0x000000018B747318
		protected override void OnUpdate() {} // 0x000000018B747A34-0x000000018B747C30
		public override Point[] GetPoints() => default; // 0x000000018B747200-0x000000018B747288
		public override Point GetPoint(Transform transform) => default; // 0x000000018B747188-0x000000018B747200
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain) {} // 0x000000018B746CE8-0x000000018B746DE0
		private Vector3 GetCentroid() => default; // 0x000000018B746E80-0x000000018B747188
	}

	[Serializable]
	public class IKSolverFullBody : IKSolver // TypeDefIndex: 53697
	{
		// Fields
		public int iterations; // 0x58
		public FBIKChain[] chain; // 0x60
		public IKEffector[] effectors; // 0x68
		public IKMappingSpine spineMapping; // 0x70
		public IKMappingBone[] boneMappings; // 0x78
		public IKMappingLimb[] limbMappings; // 0x80
		public bool FABRIKPass; // 0x88
		public UpdateDelegate OnPreRead; // 0x90
		public UpdateDelegate OnPreSolve; // 0x98
		public IterationDelegate OnPreIteration; // 0xA0
		public IterationDelegate OnPostIteration; // 0xA8
		public UpdateDelegate OnPreBend; // 0xB0
		public UpdateDelegate OnPostSolve; // 0xB8
		public UpdateDelegate OnStoreDefaultLocalState; // 0xC0
		public UpdateDelegate OnFixTransforms; // 0xC8
	
		// Constructors
		public IKSolverFullBody() {} // 0x000000018B74DBB4-0x000000018B74DCD4
	
		// Methods
		public IKEffector GetEffector(Transform t) => default; // 0x000000018B74CD38-0x000000018B74CDF4
		public FBIKChain GetChain(Transform transform) => default; // 0x000000018B74CCF4-0x000000018B74CD38
		public int GetChainIndex(Transform transform) => default; // 0x000000018B74CBF0-0x000000018B74CCF4
		public Node GetNode(int chainIndex, int nodeIndex) => default; // 0x000000018B74CDF4-0x000000018B74CE3C
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex) {
			chainIndex = default;
			nodeIndex = default;
		} // 0x000000018B74CB74-0x000000018B74CBF0
		public override Point[] GetPoints() => default; // 0x000000018B74CF7C-0x000000018B74D0C8
		public override Point GetPoint(Transform transform) => default; // 0x000000018B74CE3C-0x000000018B74CF7C
		public override bool IsValid(ref string message) => default; // 0x000000018B74D0C8-0x000000018B74D278
		public override void StoreDefaultLocalState() {} // 0x000000018B74DA40-0x000000018B74DAF4
		public override void FixTransforms() {} // 0x000000018B74CAAC-0x000000018B74CB74
		protected override void OnInitiate() {} // 0x000000018B74D278-0x000000018B74D384
		protected override void OnUpdate() {} // 0x000000018B74D384-0x000000018B74D4E4
		protected virtual void ReadPose() {} // 0x000000018B74D4E4-0x000000018B74D70C
		protected virtual void Solve() {} // 0x000000018B74D70C-0x000000018B74DA40
		protected virtual void ApplyBendConstraints() {} // 0x000000018B74CA70-0x000000018B74CAAC
		protected virtual void WritePose() {} // 0x000000018B74DAF4-0x000000018B74DBB4
	}

	[Serializable]
	public enum FullBodyBipedEffector // TypeDefIndex: 53698
	{
		Body = 0,
		LeftShoulder = 1,
		RightShoulder = 2,
		LeftThigh = 3,
		RightThigh = 4,
		LeftHand = 5,
		RightHand = 6,
		LeftFoot = 7,
		RightFoot = 8
	}

	[Serializable]
	public enum FullBodyBipedChain // TypeDefIndex: 53699
	{
		LeftArm = 0,
		RightArm = 1,
		LeftLeg = 2,
		RightLeg = 3
	}

	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 53700
	{
		// Fields
		public Transform rootNode; // 0xD0
		public float spineStiffness; // 0xD8
		public float pullBodyVertical; // 0xDC
		public float pullBodyHorizontal; // 0xE0
		private Vector3 _pullBodyOffset_k__BackingField; // 0xE4
		private Vector3 offset; // 0xF0
	
		// Properties
		public IKEffector bodyEffector { get => default; } // 0x000000018B74C894-0x000000018B74C8A0 
		public IKEffector leftShoulderEffector { get => default; } // 0x000000018B74C968-0x000000018B74C978 
		public IKEffector rightShoulderEffector { get => default; } // 0x000000018B74CA50-0x000000018B74CA60 
		public IKEffector leftThighEffector { get => default; } // 0x000000018B74C978-0x000000018B74C988 
		public IKEffector rightThighEffector { get => default; } // 0x000000018B74CA60-0x000000018B74CA70 
		public IKEffector leftHandEffector { get => default; } // 0x000000018B74C904-0x000000018B74C914 
		public IKEffector rightHandEffector { get => default; } // 0x000000018B74C9EC-0x000000018B74C9FC 
		public IKEffector leftFootEffector { get => default; } // 0x000000018B74C8F4-0x000000018B74C904 
		public IKEffector rightFootEffector { get => default; } // 0x000000018B74C9DC-0x000000018B74C9EC 
		public FBIKChain leftArmChain { get => default; } // 0x000000018B74C8A0-0x000000018B74C8C8 
		public FBIKChain rightArmChain { get => default; } // 0x000000018B74C988-0x000000018B74C9B0 
		public FBIKChain leftLegChain { get => default; } // 0x000000018B74C914-0x000000018B74C93C 
		public FBIKChain rightLegChain { get => default; } // 0x000000018B74C9FC-0x000000018B74CA24 
		public IKMappingLimb leftArmMapping { get => default; } // 0x000000018B74C8C8-0x000000018B74C8F4 
		public IKMappingLimb rightArmMapping { get => default; } // 0x000000018B74C9B0-0x000000018B74C9DC 
		public IKMappingLimb leftLegMapping { get => default; } // 0x000000018B74C93C-0x000000018B74C968 
		public IKMappingLimb rightLegMapping { get => default; } // 0x000000018B74CA24-0x000000018B74CA50 
		public IKMappingBone headMapping { get => default; } // 0x000000018B74A940-0x000000018B74A968 
		public Vector3 pullBodyOffset { get; private set; } // 0x0000000185FD5720-0x0000000185FD5740 0x0000000185FD5740-0x0000000185FD5760
	
		// Constructors
		public IKSolverFullBodyBiped() {} // 0x000000018B74C878-0x000000018B74C894
	
		// Methods
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f /* Metadata: 0x0207831B */) {} // 0x000000018B74B040-0x000000018B74B0A4
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight) {} // 0x000000018B74B0A4-0x000000018B74B158
		public FBIKChain GetChain(FullBodyBipedChain c) => default; // 0x000000018B74A4A0-0x000000018B74A520
		public FBIKChain GetChain(FullBodyBipedEffector effector) => default; // 0x000000018B74A520-0x000000018B74A5D0
		public IKEffector GetEffector(FullBodyBipedEffector effector) => default; // 0x000000018B74A5D0-0x000000018B74A708
		public IKEffector GetEndEffector(FullBodyBipedChain c) => default; // 0x000000018B74A708-0x000000018B74A788
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain) => default; // 0x000000018B74AA08-0x000000018B74AA94
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector) => default; // 0x000000018B74AA94-0x000000018B74AB34
		public IKMappingSpine GetSpineMapping() => default; // 0x0000000181460F70-0x0000000181460F80
		public IKMappingBone GetHeadMapping() => default; // 0x000000018B74A940-0x000000018B74A968
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb) => default; // 0x000000018B74A200-0x000000018B74A288
		public override bool IsValid(ref string message) => default; // 0x000000018B74ABD4-0x000000018B74AD68
		public void SetToReferences(BipedReferences references, Transform rootNode = null) {} // 0x000000018B74B3F0-0x000000018B74C7A4
		public static Transform DetectRootNodeBone(BipedReferences references) => default; // 0x000000018B749E84-0x000000018B74A200
		public void SetLimbOrientations(BipedLimbOrientations o) {} // 0x000000018B74B384-0x000000018B74B3F0
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation) {} // 0x000000018B74B158-0x000000018B74B384
		private static Transform GetLeftClavicle(BipedReferences references) => default; // 0x000000018B74A968-0x000000018B74AA08
		private static Transform GetRightClavicle(BipedReferences references) => default; // 0x000000018B74AB34-0x000000018B74ABD4
		private static bool Contains(Transform[] array, Transform transform) => default; // 0x000000018B749DEC-0x000000018B749E84
		protected override void ReadPose() {} // 0x000000018B74AF3C-0x000000018B74B040
		private void PullBody() {} // 0x000000018B74AD68-0x000000018B74AF3C
		private Vector3 GetBodyOffset() => default; // 0x000000018B74A288-0x000000018B74A4A0
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset) => default; // 0x000000018B74A788-0x000000018B74A940
		protected override void ApplyBendConstraints() {} // 0x000000018B749A9C-0x000000018B749DEC
		protected override void WritePose() {} // 0x000000018B74C7A4-0x000000018B74C878
	}

	[Serializable]
	public class IKSolverHeuristic : IKSolver // TypeDefIndex: 53701
	{
		// Fields
		public Transform target; // 0x58
		public float tolerance; // 0x60
		public int maxIterations; // 0x64
		public bool useRotationLimits; // 0x68
		public bool XY; // 0x69
		public Bone[] bones; // 0x70
		protected Vector3 lastLocalDirection; // 0x78
		protected float chainLength; // 0x84
	
		// Properties
		protected virtual int minBones { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		protected virtual bool boneLengthCanBeZero { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		protected virtual bool allowCommonParent { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		protected virtual Vector3 localDirection { get => default; } // 0x000000018B74E4D4-0x000000018B74E620 
		protected float positionOffset { get => default; } // 0x000000018B74E620-0x000000018B74E698 
	
		// Constructors
		public IKSolverHeuristic() {} // 0x0000000184EDA620-0x0000000184EDA680
	
		// Methods
		public bool SetChain(Transform[] hierarchy, Transform root) => default; // 0x0000000184EDB9E0-0x0000000184EDBAF0
		public void AddBone(Transform bone) {} // 0x000000018B74DCD4-0x000000018B74DDD8
		public override void StoreDefaultLocalState() {} // 0x0000000184EDBAF0-0x0000000184EDBB50
		public override void FixTransforms() {} // 0x000000018B74DDD8-0x000000018B74DE38
		public override bool IsValid(ref string message) => default; // 0x0000000184EDBBD0-0x0000000184EDBF00
		public override Point[] GetPoints() => default; // 0x0000000181460F70-0x0000000181460F80
		public override Point GetPoint(Transform transform) => default; // 0x000000018B74DE38-0x000000018B74DEF4
		protected override void OnInitiate() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnUpdate() {} // 0x0000000185492010-0x0000000185492020
		protected void InitiateBones() {} // 0x0000000184EDC260-0x0000000184EDC780
		protected Vector3 GetSingularityOffset() => default; // 0x000000018B74DEF4-0x000000018B74E244
		private bool SingularityDetected() => default; // 0x000000018B74E244-0x000000018B74E4D4
	}

	[Serializable]
	public class IKSolverLeg : IKSolver // TypeDefIndex: 53702
	{
		// Fields
		public float IKRotationWeight; // 0x58
		public Quaternion IKRotation; // 0x5C
		public Point pelvis; // 0x70
		public Point thigh; // 0x78
		public Point calf; // 0x80
		public Point foot; // 0x88
		public Point toe; // 0x90
		public IKSolverVR.Leg leg; // 0x98
		public Vector3 heelOffset; // 0xA0
		private Vector3[] positions; // 0xB0
		private Quaternion[] rotations; // 0xB8
	
		// Constructors
		public IKSolverLeg() {} // 0x000000018B74F4A8-0x000000018B74F6A0
	
		// Methods
		public override bool IsValid(ref string message) => default; // 0x000000018B74E908-0x000000018B74EC04
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root) => default; // 0x000000018B743A98-0x000000018B743B48
		public override Point[] GetPoints() => default; // 0x000000018B74E804-0x000000018B74E908
		public override Point GetPoint(Transform transform) => default; // 0x000000018B74E698-0x000000018B74E804
		public override void StoreDefaultLocalState() {} // 0x000000018B743BC8-0x000000018B743C28
		public override void FixTransforms() {} // 0x000000018B742F5C-0x000000018B742FC0
		protected override void OnInitiate() {} // 0x000000018B74EC04-0x000000018B74EC80
		protected override void OnUpdate() {} // 0x000000018B74EC80-0x000000018B74ECAC
		private void Solve() {} // 0x000000018B74F16C-0x000000018B74F258
		private void Read() {} // 0x000000018B74ECAC-0x000000018B74F16C
		private void Write() {} // 0x000000018B74F258-0x000000018B74F4A8
	}

	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric // TypeDefIndex: 53705
	{
		// Fields
		public AvatarIKGoal goal; // 0xA8
		public BendModifier bendModifier; // 0xAC
		public float maintainRotationWeight; // 0xB0
		public float bendModifierWeight; // 0xB4
		public Transform bendGoal; // 0xB8
		private bool maintainBendFor1Frame; // 0xC0
		private bool maintainRotationFor1Frame; // 0xC1
		private Quaternion defaultRootRotation; // 0xC4
		private Quaternion parentDefaultRotation; // 0xD4
		private Quaternion bone3RotationBeforeSolve; // 0xE4
		private Quaternion maintainRotation; // 0xF4
		private Quaternion bone3DefaultRotation; // 0x104
		private Vector3 _bendNormal; // 0x114
		private Vector3 animationNormal; // 0x120
		private AxisDirection[] axisDirectionsLeft; // 0x130
		private AxisDirection[] axisDirectionsRight; // 0x138
	
		// Properties
		private AxisDirection[] axisDirections { get => default; } // 0x0000000184EDCDB0-0x0000000184EDD0A0 
	
		// Nested types
		[Serializable]
		public enum BendModifier // TypeDefIndex: 53703
		{
			Animation = 0,
			Target = 1,
			Parent = 2,
			Arm = 3,
			Goal = 4
		}
	
		[Serializable]
		public struct AxisDirection // TypeDefIndex: 53704
		{
			// Fields
			public Vector3 direction; // 0x00
			public Vector3 axis; // 0x0C
			public float dot; // 0x18
	
			// Constructors
			public AxisDirection(Vector3 direction, Vector3 axis) {
				this.direction = default;
				this.axis = default;
				dot = default;
			} // 0x00000001844E1040-0x00000001844E10B0
		}
	
		// Constructors
		public IKSolverLimb() {} // 0x0000000184EDA370-0x0000000184EDA410
		public IKSolverLimb(AvatarIKGoal goal) {} // 0x000000018B74F728-0x000000018B74F744
	
		// Methods
		public void MaintainRotation() {} // 0x00000001844E10B0-0x00000001844E1180
		public void MaintainBend() {} // 0x0000000184EDCAF0-0x0000000184EDCDB0
		protected override void OnInitiateVirtual() {} // 0x0000000184BDC200-0x0000000184BDC2D0
		protected override void OnUpdateVirtual() {} // 0x0000000184DBEE70-0x0000000184DBEEC0
		protected override void OnPostSolveVirtual() {} // 0x000000018B74F6A0-0x000000018B74F728
		private void StoreAxisDirections(ref AxisDirection[] axisDirections) {} // 0x0000000184BDC2D0-0x0000000184BDC480
		private Vector3 GetModifiedBendNormal() => default; // 0x0000000184EDD0A0-0x0000000184EDD100
	}

	[Serializable]
	public class IKSolverLookAt : IKSolver // TypeDefIndex: 53707
	{
		// Fields
		public Transform target; // 0x58
		public LookAtBone[] spine; // 0x60
		private Quaternion[] m_spineVirtualBones; // 0x68
		public LookAtBone head; // 0x70
		private Quaternion m_headVirtualBones; // 0x78
		public LookAtBone[] eyes; // 0x88
		private Quaternion m_eyeVirtualBone; // 0x90
		public float bodyWeight; // 0xA0
		public float headWeight; // 0xA4
		public float eyesWeight; // 0xA8
		public float clampWeight; // 0xAC
		public float clampWeightHead; // 0xB0
		public float clampWeightEyes; // 0xB4
		public int clampSmoothing; // 0xB8
		public AnimationCurve spineWeightCurve; // 0xC0
		public Vector3 spineTargetOffset; // 0xC8
		protected Vector3[] spineForwards; // 0xD8
		protected Vector3[] headForwards; // 0xE0
		protected Vector3[] eyeForward; // 0xE8
		private bool isDirty; // 0xF0
	
		// Properties
		public Quaternion[] spineVirtualBone { get => default; set {} } // 0x000000018B74444C-0x000000018B744470 0x000000018B74FA50-0x000000018B74FA98
		public Quaternion headVirtualBones { get => default; set {} } // 0x000000018B74FB40-0x000000018B74FBA4 0x000000018B74FC7C-0x000000018B74FCF4
		public Quaternion eyeVirtualBone { get => default; set {} } // 0x000000018B74FA98-0x000000018B74FB40 0x000000018B74FBA4-0x000000018B74FC7C
		protected bool spineIsValid { get => default; } // 0x0000000184EDB330-0x0000000184EDB3A0 
		protected bool spineIsEmpty { get => default; } // 0x00000001840CDA80-0x00000001840CDAB0 
		protected bool headIsValid { get => default; } // 0x00000001840CDBC0-0x00000001840CDCB0 
		protected bool headIsEmpty { get => default; } // 0x0000000184ED9F20-0x0000000184EDA010 
		protected bool eyesIsValid { get => default; } // 0x0000000184EDA900-0x0000000184EDA920 
		protected bool eyesIsEmpty { get => default; } // 0x0000000184EDA010-0x0000000184EDA060 
	
		// Nested types
		[Serializable]
		public class LookAtBone : IKSolver.Bone // TypeDefIndex: 53706
		{
			// Fields
			public Vector3 positionOffset; // 0x80
			public Vector3 baseForwardOffsetEuler; // 0x8C
	
			// Properties
			public Vector3 forward { get => default; } // 0x0000000185FCCD40-0x0000000185FCCD50 
	
			// Constructors
			public LookAtBone() {} // 0x000000018B74FCF4-0x000000018B74FDE4
			public LookAtBone(Transform transform) {} // 0x0000000185A62990-0x0000000185A629A0
	
			// Methods
			public void Initiate(Transform root) {} // 0x0000000185FB9E60-0x0000000185FB9E70
			public void LookAt(Vector3 direction, float weight) {} // 0x0000000185FCD380-0x0000000185FCD390
			public Quaternion LookAtReturnRotation(Vector3 direction, float weight) => default; // 0x0000000185FC9A40-0x0000000185FC9A50
		}
	
		// Constructors
		public IKSolverLookAt() {} // 0x00000001840D01C0-0x00000001840D0260
	
		// Methods
		public void SetLookAtWeight(float weight) {} // 0x0000000184EDB670-0x0000000184EDB760
		public void SetLookAtWeight(float weight, float bodyWeight) {} // 0x0000000185FD5760-0x0000000185FD5770
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) {} // 0x0000000185076430-0x0000000185076480
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) {} // 0x0000000184EDB3B0-0x0000000184EDB4F0
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) {} // 0x000000018B74F87C-0x000000018B74FA50
		public void SetLookAtWeight(float weight, float bodyWeight = 0f /* Metadata: 0x02078324 */, float headWeight = 1f /* Metadata: 0x02078328 */, float eyesWeight = 0.5f /* Metadata: 0x0207832C */, float clampWeight = 0.5f /* Metadata: 0x02078330 */, float clampWeightHead = 0.5f /* Metadata: 0x02078334 */, float clampWeightEyes = 0.3f /* Metadata: 0x02078338 */) {} // 0x000000018B74F744-0x000000018B74F87C
		public override void StoreDefaultLocalState() {} // 0x0000000184ED9E50-0x0000000184ED9F20
		public void SetDirty() {} // 0x00000001855492C0-0x0000000185549530
		public override void FixTransforms() {} // 0x00000001840CD870-0x00000001840CD9D0
		public override bool IsValid(ref string message) => default; // 0x0000000184EDB260-0x0000000184EDB330
		public override Point[] GetPoints() => default; // 0x00000001840CDB90-0x00000001840CDBC0
		public override Point GetPoint(Transform transform) => default; // 0x00000001840CF790-0x00000001840CFCF0
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root) => default; // 0x0000000184EDB3A0-0x0000000184EDB3B0
		protected override void OnInitiate() {} // 0x00000001840CDAB0-0x00000001840CDB90
		protected override void OnUpdate() {} // 0x00000001840CEF70-0x00000001840CF790
		protected void SolveSpine() {} // 0x00000001840CD9D0-0x00000001840CDA80
		protected void SolveHead() {} // 0x0000000184EDA680-0x0000000184EDA900
		protected void SolveEyes() {} // 0x0000000185549530-0x0000000185549660
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp) => default; // 0x00000001840CFE80-0x00000001840D0070
		protected void SetBones(Transform[] array, ref LookAtBone[] bones) {} // 0x000000018B75561C-0x000000018B755718
	}

	[Serializable]
	public class IKSolverTrigonometric : IKSolver // TypeDefIndex: 53709
	{
		// Fields
		public Transform target; // 0x58
		public float IKRotationWeight; // 0x60
		public Quaternion IKRotation; // 0x64
		public Vector3 bendNormal; // 0x74
		public TrigonometricBone bone1; // 0x80
		public TrigonometricBone bone2; // 0x88
		public TrigonometricBone bone3; // 0x90
		protected Vector3 weightIKPosition; // 0x98
		protected bool directHierarchy; // 0xA4
	
		// Nested types
		[Serializable]
		public class TrigonometricBone : IKSolver.Bone // TypeDefIndex: 53708
		{
			// Fields
			private Quaternion targetToLocalSpace; // 0x80
			private Vector3 defaultLocalBendNormal; // 0x90
	
			// Constructors
			public TrigonometricBone() {} // 0x000000018B750368-0x000000018B75038C
	
			// Methods
			public void Initiate(Vector3 childPosition, Vector3 bendNormal) {} // 0x000000018B75015C-0x000000018B750368
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal) => default; // 0x00000001852A4880-0x00000001852A48B0
			public Vector3 GetBendNormalFromCurrentRotation() => default; // 0x0000000185FD5780-0x0000000185FD5790
		}
	
		// Constructors
		public IKSolverTrigonometric() {} // 0x00000001864729F4-0x00000001864729FC
	
		// Methods
		public void SetBendGoalPosition(Vector3 goalPosition, float weight) {} // 0x0000000185FD5770-0x0000000185FD5780
		public void SetBendPlaneToCurrent() {} // 0x0000000185FB2200-0x0000000185FB2210
		public void SetIKRotation(Quaternion rotation) {} // 0x000000018B750098-0x000000018B75015C
		public void SetIKRotationWeight(float weight) {} // 0x000000018B74FFA0-0x000000018B750098
		public Quaternion GetIKRotation() => default; // 0x0000000184EDC870-0x0000000184EDC8C0
		public float GetIKRotationWeight() => default; // 0x0000000184214F30-0x00000001842155D0
		public override Point[] GetPoints() => default; // 0x0000000184EDD900-0x0000000184EDDCD0
		public override Point GetPoint(Transform transform) => default; // 0x0000000184EDAF00-0x0000000184EDAF80
		public override void StoreDefaultLocalState() {} // 0x000000018B75038C-0x000000018B750870
		public override void FixTransforms() {} // 0x000000018B74FDE4-0x000000018B74FFA0
		public override bool IsValid(ref string message) => default; // 0x00000001852A43F0-0x00000001852A44E0
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root) => default; // 0x00000001852A48B0-0x00000001852A49D0
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight) {} // 0x00000001852A44E0-0x00000001852A45E0
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) => default; // 0x0000000184216A90-0x00000001842174C0
		protected override void OnInitiate() {} // 0x0000000185492010-0x0000000185492020
		private bool IsDirectHierarchy() => default; // 0x0000000185492010-0x0000000185492020
		public void InitiateBones() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnUpdate() {} // 0x00000001840CEBB0-0x00000001840CEF10
		protected virtual void OnInitiateVirtual() {} // 0x0000000184EDA410-0x0000000184EDA530
		protected virtual void OnUpdateVirtual() {} // 0x00000001852A45E0-0x00000001852A47D0
		protected virtual void OnPostSolveVirtual() {} // 0x00000001840CFCF0-0x00000001840CFDB0
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal) => default; // 0x00000001844E1180-0x00000001844E1230
	}

	[Serializable]
	public class IKSolverVR : IKSolver // TypeDefIndex: 53721
	{
		// Fields
		private Animator _animator_k__BackingField; // 0x58
		private Transform[] solverTransforms; // 0x60
		private bool hasChest; // 0x68
		private bool hasNeck; // 0x69
		private bool hasShoulders; // 0x6A
		private bool hasToes; // 0x6B
		private bool hasLegs; // 0x6C
		private bool hasArms; // 0x6D
		private Vector3[] readPositions; // 0x70
		private Quaternion[] readRotations; // 0x78
		private Vector3[] solvedPositions; // 0x80
		private Quaternion[] solvedRotations; // 0x88
		private Quaternion[] defaultLocalRotations; // 0x90
		private Vector3[] defaultLocalPositions; // 0x98
		private Vector3 rootV; // 0xA0
		private Vector3 rootVelocity; // 0xAC
		private Vector3 bodyOffset; // 0xB8
		private int supportLegIndex; // 0xC4
		private int lastLOD; // 0xC8
		private float lastLocomotionWeight; // 0xCC
		public int LOD; // 0xD0
		public float scale; // 0xD4
		public bool plantFeet; // 0xD8
		private VirtualBone _rootBone_k__BackingField; // 0xE0
		public Spine spine; // 0xE8
		public Arm leftArm; // 0xF0
		public Arm rightArm; // 0xF8
		public Leg leftLeg; // 0x100
		public Leg rightLeg; // 0x108
		public Locomotion locomotion; // 0x110
		private Leg[] legs; // 0x118
		private Arm[] arms; // 0x120
		private Vector3 headPosition; // 0x128
		private Vector3 headDeltaPosition; // 0x134
		private Vector3 raycastOriginPelvis; // 0x140
		private Vector3 lastOffset; // 0x14C
		private Vector3 debugPos1; // 0x158
		private Vector3 debugPos2; // 0x164
		private Vector3 debugPos3; // 0x170
		private Vector3 debugPos4; // 0x17C
	
		// Properties
		public Animator animator { get; private set; } // 0x0000000185FD58B0-0x0000000185FD58C0 0x000000018B763A7C-0x000000018B7645E4
		public VirtualBone rootBone { get; private set; } // 0x000000018B768118-0x000000018B768660 0x000000018B766F90-0x000000018B76714C
	
		// Nested types
		[Serializable]
		public class Arm : BodyPart // TypeDefIndex: 53711
		{
			// Fields
			public Transform target; // 0x48
			public float positionWeight; // 0x50
			public float rotationWeight; // 0x54
			public float shoulderRotationWeight; // 0x58
			public ShoulderRotationMode shoulderRotationMode; // 0x5C
			public float shoulderTwistWeight; // 0x60
			public float shoulderYawOffset; // 0x64
			public float shoulderPitchOffset; // 0x68
			public Transform bendGoal; // 0x70
			public float bendGoalWeight; // 0x78
			public float swivelOffset; // 0x7C
			public Vector3 wristToPalmAxis; // 0x80
			public Vector3 palmToThumbAxis; // 0x8C
			public float armLengthMlp; // 0x98
			public AnimationCurve stretchCurve; // 0xA0
			[NonSerialized]
			public Vector3 IKPosition; // 0xA8
			[NonSerialized]
			public Quaternion IKRotation; // 0xB4
			[NonSerialized]
			public Vector3 bendDirection; // 0xC4
			[NonSerialized]
			public Vector3 handPositionOffset; // 0xD0
			private Vector3 _position_k__BackingField; // 0xDC
			private Quaternion _rotation_k__BackingField; // 0xE8
			private bool hasShoulder; // 0xF8
			private Vector3 chestForwardAxis; // 0xFC
			private Vector3 chestUpAxis; // 0x108
			private Quaternion chestRotation; // 0x114
			private Vector3 chestForward; // 0x124
			private Vector3 chestUp; // 0x130
			private Quaternion forearmRelToUpperArm; // 0x13C
			private Vector3 upperArmBendAxis; // 0x14C
	
			// Properties
			public Vector3 position { get; private set; } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
			public Quaternion rotation { get; private set; } // 0x000000018B752F04-0x000000018B753208 0x000000018B751D00-0x000000018B75204C
			private VirtualBone shoulder { get => default; } // 0x000000018B750E14-0x000000018B750FCC 
			private VirtualBone upperArm { get => default; } // 0x000000018B7509BC-0x000000018B750CC8 
			private VirtualBone forearm { get => default; } // 0x000000018B750CC8-0x000000018B750D20 
			private VirtualBone hand { get => default; } // 0x000000018B750D20-0x000000018B750E14 
	
			// Nested types
			[Serializable]
			public enum ShoulderRotationMode // TypeDefIndex: 53710
			{
				YawPitch = 0,
				FromTo = 1
			}
	
			// Constructors
			public Arm() {} // 0x000000018B7522D0-0x000000018B752324
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) {} // 0x000000018B750870-0x000000018B7509BC
			public override void PreSolve(float scale) {} // 0x000000018B752DCC-0x000000018B752F04
			public override void ApplyOffsets(float scale) {} // 0x000000018B754A30-0x000000018B754B88
			private void Stretching() {} // 0x000000018B750FCC-0x000000018B7511A0
			public void Solve(bool isLeft) {} // 0x000000018B751B8C-0x000000018B751BDC
			public override void ResetOffsets() {} // 0x000000018B751B3C-0x000000018B751B8C
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) {} // 0x000000018B75204C-0x000000018B7522D0
			private float DamperValue(float value, float min, float max, float weight = 1f /* Metadata: 0x0207833C */) => default; // 0x000000018B7511A0-0x000000018B751454
			private Vector3 GetBendNormal(Vector3 dir) => default; // 0x000000018B751C3C-0x000000018B751D00
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, UnityEngine.Color color) {} // 0x000000018B754B88-0x000000018B754CCC
		}
	
		[Serializable]
		public abstract class BodyPart // TypeDefIndex: 53712
		{
			// Fields
			private float _sqrMag_k__BackingField; // 0x10
			private float _mag_k__BackingField; // 0x14
			public VirtualBone[] bones; // 0x18
			protected bool initiated; // 0x20
			protected Vector3 rootPosition; // 0x24
			protected Quaternion rootRotation; // 0x30
			protected int index; // 0x40
			protected int LOD; // 0x44
	
			// Properties
			public float sqrMag { get; private set; } // 0x000000018B751C0C-0x000000018B751C3C 0x0000000185FB25D0-0x0000000185FB25E0
			public float mag { get; private set; } // 0x0000000187A4749C-0x0000000187A474B0 0x000000018B7551A4-0x000000018B755304
	
			// Constructors
			protected BodyPart() {} // 0x000000018B758D80-0x000000018B758DCC
	
			// Methods
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x000000018B752324-0x000000018B752864
			public abstract void PreSolve(float scale); // 0x000000018B754CCC-0x000000018B7551A4
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x000000018B752864-0x000000018B752DCC
			public abstract void ApplyOffsets(float scale); // 0x000000018B753208-0x000000018B754A30
			public abstract void ResetOffsets(); // 0x000000018B751BDC-0x000000018B751C0C
			public void SetLOD(int LOD) {} // 0x000000018B751454-0x000000018B751B3C
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) {} // 0x000000018B755304-0x000000018B75561C
			public void MovePosition(Vector3 position) {} // 0x000000018304E8B0-0x000000018304E8D0
			public void MoveRotation(Quaternion rotation) {} // 0x0000000185FD5790-0x0000000185FD57B0
			public void Translate(Vector3 position, Quaternion rotation) {} // 0x000000018304E8D0-0x000000018304E8E0
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot) {} // 0x0000000185FD57B0-0x0000000185FD57C0
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f /* Metadata: 0x02078342 */) {} // 0x000000018B758DCC-0x000000018B758DF4
			public void Visualize(UnityEngine.Color color) {} // 0x000000018B758DF4-0x000000018B758E3C
			public void Visualize() {} // 0x000000018B758D34-0x000000018B758D80
		}
	
		[Serializable]
		public class Footstep // TypeDefIndex: 53713
		{
			// Fields
			public float stepSpeed; // 0x10
			public Vector3 characterSpaceOffset; // 0x14
			public Vector3 position; // 0x20
			public Quaternion rotation; // 0x2C
			public Quaternion stepToRootRot; // 0x3C
			public bool isSupportLeg; // 0x4C
			public bool relaxFlag; // 0x4D
			private float _stepProgress_k__BackingField; // 0x50
			public Vector3 stepFrom; // 0x54
			public Vector3 stepTo; // 0x60
			public Quaternion stepFromRot; // 0x6C
			public Quaternion stepToRot; // 0x7C
			private Quaternion footRelativeToRoot; // 0x8C
			private float supportLegW; // 0x9C
			private float supportLegWV; // 0xA0
	
			// Properties
			public bool isStepping { get => default; } // 0x000000018B755E14-0x000000018B756814 
			public float stepProgress { get; private set; } // 0x000000018B756814-0x000000018B756A40 0x000000018B755718-0x000000018B755780
	
			// Constructors
			public Footstep() {} // Dummy constructor
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset) {} // 0x000000018B7583E4-0x000000018B7588A4
	
			// Methods
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation) {} // 0x000000018B756A5C-0x000000018B7583E4
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold) {} // 0x000000018B756A40-0x000000018B756A5C
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime) {} // 0x000000018B7589BC-0x000000018B758BFC
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime) {} // 0x000000018B755780-0x000000018B755828
			public void Update(RootMotion.InterpolationMode interpolation, UnityEvent onStep, float deltaTime) {} // 0x000000018B755828-0x000000018B755E14
		}
	
		[Serializable]
		public class Leg : BodyPart // TypeDefIndex: 53714
		{
			// Fields
			public Transform target; // 0x48
			public float positionWeight; // 0x50
			public float rotationWeight; // 0x54
			public Transform bendGoal; // 0x58
			public float bendGoalWeight; // 0x60
			public float swivelOffset; // 0x64
			public float bendToTargetWeight; // 0x68
			public float legLengthMlp; // 0x6C
			public AnimationCurve stretchCurve; // 0x70
			[NonSerialized]
			public Vector3 IKPosition; // 0x78
			[NonSerialized]
			public Quaternion IKRotation; // 0x84
			[NonSerialized]
			public Vector3 footPositionOffset; // 0x94
			[NonSerialized]
			public Vector3 heelPositionOffset; // 0xA0
			[NonSerialized]
			public Quaternion footRotationOffset; // 0xAC
			[NonSerialized]
			public float currentMag; // 0xBC
			public bool useAnimatedBendNormal; // 0xC0
			private Vector3 _position_k__BackingField; // 0xC4
			private Quaternion _rotation_k__BackingField; // 0xD0
			private bool _hasToes_k__BackingField; // 0xE0
			private Vector3 _thighRelativeToPelvis_k__BackingField; // 0xE4
			private Vector3 footPosition; // 0xF0
			private Quaternion footRotation; // 0xFC
			private Vector3 bendNormal; // 0x10C
			private Quaternion calfRelToThigh; // 0x118
			private Quaternion thighRelToFoot; // 0x128
			private Vector3 _bendNormalRelToPelvis_k__BackingField; // 0x138
			private Vector3 _bendNormalRelToTarget_k__BackingField; // 0x144
	
			// Properties
			public Vector3 position { get; private set; } // 0x000000018B7588A4-0x000000018B7589BC 0x000000018B758BFC-0x000000018B758D34
			public Quaternion rotation { get; private set; }
			public bool hasToes { get; private set; }
			public VirtualBone thigh { get => default; }
			private VirtualBone calf { get => default; } // 0x0000000181DCCCE0-0x0000000181DCCCF0 
			private VirtualBone foot { get => default; } // 0x0000000181A6E380-0x0000000181A6E390 
			private VirtualBone toes { get => default; } // 0x0000000185FB2D80-0x0000000185FB2D90 
			public VirtualBone lastBone { get => default; } // 0x0000000181A6E390-0x0000000181A6FA00 
			public Vector3 thighRelativeToPelvis { get; private set; } // 0x0000000183909010-0x0000000183909020 0x000000018B758FDC-0x000000018B7590E4
			public Vector3 bendNormalRelToPelvis { get; set; } // 0x000000018B758E3C-0x000000018B758F20 0x000000018B758F20-0x000000018B758FDC
			public Vector3 bendNormalRelToTarget { get; set; } // 0x000000018B759360-0x000000018B7593B4 0x000000018B759204-0x000000018B759360
	
			// Constructors
			public Leg() {} // 0x000000018B75977C-0x000000018B759890
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) {} // 0x000000018B7590E4-0x000000018B759204
			public override void PreSolve(float scale) {} // 0x000000018B7593B4-0x000000018B7594CC
			public override void ApplyOffsets(float scale) {} // 0x000000018B7594CC-0x000000018B7594FC
			private void ApplyPositionOffset(Vector3 offset, float weight) {} // 0x000000018B7594FC-0x000000018B75955C
			private void ApplyRotationOffset(Quaternion offset, float weight) {} // 0x000000018B759B08-0x000000018B759B18
			public void Solve(bool stretch) {} // 0x0000000185FB3000-0x0000000185FB3010
			private void FixTwistRotations() {} // 0x0000000185FB3010-0x0000000185FB3020
			private void Stretching() {} // 0x000000018B7599E4-0x000000018B759B08
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) {} // 0x0000000185FD57C0-0x0000000185FD5810
			public override void ResetOffsets() {} // 0x000000018B75955C-0x000000018B759684
		}
	
		[Serializable]
		public class Locomotion // TypeDefIndex: 53716
		{
			// Fields
			public Mode mode; // 0x10
			public float weight; // 0x14
			public float moveThreshold; // 0x18
			private byte animationHeader; // 0x1C
			public float minAnimationSpeed; // 0x20
			public float maxAnimationSpeed; // 0x24
			public float animationSmoothTime; // 0x28
			private byte rootPositionHeader; // 0x2C
			public Vector2 standOffset; // 0x30
			public float rootLerpSpeedWhileMoving; // 0x38
			public float rootLerpSpeedWhileStopping; // 0x3C
			public float rootLerpSpeedWhileTurning; // 0x40
			public float maxRootOffset; // 0x44
			private byte rootRotationHeader; // 0x48
			public float maxRootAngleMoving; // 0x4C
			public float maxRootAngleStanding; // 0x50
			public float stepLengthMlp; // 0x54
			private Animator animator; // 0x58
			private Vector3 velocityLocal; // 0x60
			private Vector3 velocityLocalV; // 0x6C
			private Vector3 lastCorrection; // 0x78
			private Vector3 lastHeadTargetPos; // 0x84
			private Vector3 lastSpeedRootPos; // 0x90
			private Vector3 lastEndRootPos; // 0x9C
			private float rootLerpSpeed; // 0xA8
			private float rootVelocityV; // 0xAC
			private float animSpeed; // 0xB0
			private float animSpeedV; // 0xB4
			private float stopMoveTimer; // 0xB8
			private float turn; // 0xBC
			private float maxRootAngleV; // 0xC0
			private float currentAnimationSmoothTime; // 0xC4
			private bool isMoving; // 0xC8
			private bool firstFrame; // 0xC9
			private static int VRIK_Horizontal; // 0x00
			private static int VRIK_Vertical; // 0x04
			private static int VRIK_IsMoving; // 0x08
			private static int VRIK_Speed; // 0x0C
			private static int VRIK_Turn; // 0x10
			private static bool isHashed; // 0x14
			private float lastVelLocalMag; // 0xCC
			public float footDistance; // 0xD0
			public float stepThreshold; // 0xD4
			public float angleThreshold; // 0xD8
			public float comAngleMlp; // 0xDC
			public float maxVelocity; // 0xE0
			public float velocityFactor; // 0xE4
			public float maxLegStretch; // 0xE8
			public float rootSpeed; // 0xEC
			public float stepSpeed; // 0xF0
			public AnimationCurve stepHeight; // 0xF8
			public float maxBodyYOffset; // 0x100
			public AnimationCurve heelHeight; // 0x108
			public float relaxLegTwistMinAngle; // 0x110
			public float relaxLegTwistSpeed; // 0x114
			public RootMotion.InterpolationMode stepInterpolation; // 0x118
			public Vector3 offset; // 0x11C
			public bool blockingEnabled; // 0x128
			public LayerMask blockingLayers; // 0x12C
			public float raycastRadius; // 0x130
			public float raycastHeight; // 0x134
			public UnityEvent onLeftFootstep; // 0x138
			public UnityEvent onRightFootstep; // 0x140
			private Vector3 _centerOfMass_k__BackingField; // 0x148
			private Footstep[] footsteps; // 0x158
			private Vector3 lastComPosition; // 0x160
			private Vector3 comVelocity; // 0x16C
			private int leftFootIndex; // 0x178
			private int rightFootIndex; // 0x17C
	
			// Properties
			public Vector3 centerOfMass { get; private set; } // 0x000000018B75E080-0x000000018B75E0A8 0x000000018B75E050-0x000000018B75E080
			public Vector3 leftFootstepPosition { get => default; } // 0x000000018B75C640-0x000000018B75CE7C 
			public Vector3 rightFootstepPosition { get => default; } // 0x000000018B75CE7C-0x000000018B75D450 
			public Quaternion leftFootstepRotation { get => default; } // 0x000000018B75B9CC-0x000000018B75C010 
			public Quaternion rightFootstepRotation { get => default; } // 0x000000018B75C010-0x000000018B75C0F8 
	
			// Nested types
			[Serializable]
			public enum Mode // TypeDefIndex: 53715
			{
				Procedural = 0,
				Animated = 1
			}
	
			// Constructors
			public Locomotion() {} // 0x000000018B75D740-0x000000018B75DCF8
	
			// Methods
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale) {} // 0x000000018B759684-0x000000018B75977C
			public void Reset(Vector3[] positions, Quaternion[] rotations) {} // 0x000000018B759890-0x000000018B7599E4
			public void Relax() {} // 0x0000000185FBCA20-0x0000000185FBCA40
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot) {} // 0x0000000185FCA140-0x0000000185FCA160
			public void AddDeltaPosition(Vector3 delta) {} // 0x0000000185FBC8B0-0x0000000185FBC8C0
			public void Initiate_Animated(Animator animator, Vector3[] positions) {} // 0x0000000185FBC8C0-0x0000000185FBC8D0
			private void ResetParams(Vector3[] positions) {} // 0x0000000185FB98E0-0x0000000185FB98F0
			public void Reset_Animated(Vector3[] positions) {} // 0x0000000185FBA780-0x0000000185FBA790
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot) {} // 0x000000018B758DCC-0x000000018B758DF4
			private void AddDeltaPosition_Animated(Vector3 delta) {} // 0x0000000188FF8D8C-0x0000000188FF8DB4
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime) {} // 0x000000018B75E028-0x000000018B75E050
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale) {} // 0x0000000185FD5720-0x0000000185FD5740
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations) {} // 0x0000000185FD5740-0x0000000185FD5760
			private void Relax_Procedural() {} // 0x0000000185FD5810-0x0000000185FD5830
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot) {} // 0x0000000185FD5850-0x0000000185FD5870
			private void AddDeltaPosition_Procedural(Vector3 delta) {} // 0x0000000185FD5830-0x0000000185FD5850
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime) {
				leftFootPosition = default;
				rightFootPosition = default;
				leftFootRotation = default;
				rightFootRotation = default;
				leftFootOffset = default;
				rightFootOffset = default;
				leftHeelOffset = default;
				rightHeelOffset = default;
			} // 0x0000000185FD5870-0x0000000185FD5890
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition) => default; // 0x000000018B75C0F8-0x000000018B75C2D0
			private bool CanStep() => default; // 0x000000018B75D4B8-0x000000018B75D740
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius) => default; // 0x000000018B75C2D0-0x000000018B75C640
		}
	
		[Serializable]
		public class Spine : BodyPart // TypeDefIndex: 53717
		{
			// Fields
			public Transform headTarget; // 0x48
			public float positionWeight; // 0x50
			public float rotationWeight; // 0x54
			public float headClampWeight; // 0x58
			public float minHeadHeight; // 0x5C
			public float useAnimatedHeadHeightWeight; // 0x60
			public float useAnimatedHeadHeightRange; // 0x64
			public float animatedHeadHeightBlend; // 0x68
			public Transform pelvisTarget; // 0x70
			public float pelvisPositionWeight; // 0x78
			public float pelvisRotationWeight; // 0x7C
			public float maintainPelvisPosition; // 0x80
			public Transform chestGoal; // 0x88
			public float chestGoalWeight; // 0x90
			public float chestClampWeight; // 0x94
			public float rotateChestByHands; // 0x98
			public float bodyPosStiffness; // 0x9C
			public float bodyRotStiffness; // 0xA0
			public float neckStiffness; // 0xA4
			public float moveBodyBackWhenCrouching; // 0xA8
			public float maxRootAngle; // 0xAC
			public float rootHeadingOffset; // 0xB0
			[NonSerialized]
			public Vector3 IKPositionHead; // 0xB4
			[NonSerialized]
			public Quaternion IKRotationHead; // 0xC0
			[NonSerialized]
			public Vector3 IKPositionPelvis; // 0xD0
			[NonSerialized]
			public Quaternion IKRotationPelvis; // 0xDC
			[NonSerialized]
			public Vector3 goalPositionChest; // 0xEC
			[NonSerialized]
			public Vector3 pelvisPositionOffset; // 0xF8
			[NonSerialized]
			public Vector3 chestPositionOffset; // 0x104
			[NonSerialized]
			public Vector3 headPositionOffset; // 0x110
			[NonSerialized]
			public Quaternion pelvisRotationOffset; // 0x11C
			[NonSerialized]
			public Quaternion chestRotationOffset; // 0x12C
			[NonSerialized]
			public Quaternion headRotationOffset; // 0x13C
			[NonSerialized]
			public Vector3 faceDirection; // 0x14C
			[NonSerialized]
			internal Vector3 headPosition; // 0x158
			private Quaternion _anchorRotation_k__BackingField; // 0x164
			private Quaternion _anchorRelativeToHead_k__BackingField; // 0x174
			private Quaternion headRotation; // 0x184
			private Quaternion pelvisRotation; // 0x194
			private Quaternion anchorRelativeToPelvis; // 0x1A4
			private Quaternion pelvisRelativeRotation; // 0x1B4
			private Quaternion chestRelativeRotation; // 0x1C4
			private Vector3 headDeltaPosition; // 0x1D4
			private Quaternion pelvisDeltaRotation; // 0x1E0
			private Quaternion chestTargetRotation; // 0x1F0
			private int pelvisIndex; // 0x200
			private int spineIndex; // 0x204
			private int chestIndex; // 0x208
			private int neckIndex; // 0x20C
			private int headIndex; // 0x210
			private float length; // 0x214
			private bool hasChest; // 0x218
			private bool hasNeck; // 0x219
			private bool hasLegs; // 0x21A
			private float headHeight; // 0x21C
			private float sizeMlp; // 0x220
			private Vector3 chestForward; // 0x224
	
			// Properties
			internal VirtualBone pelvis { get => default; } // 0x000000018B75DCF8-0x000000018B75DF3C 
			internal VirtualBone firstSpineBone { get => default; } // 0x000000018B75D450-0x000000018B75D4B8 
			internal VirtualBone chest { get => default; } // 0x000000018B75DF3C-0x000000018B75E028 
			internal VirtualBone head { get => default; } // 0x000000018B75EFC0-0x000000018B75F020 
			private VirtualBone neck { get => default; } // 0x000000018B75F628-0x000000018B75F658 
			internal Quaternion anchorRotation { get; private set; } // 0x000000018B75F074-0x000000018B75F07C 0x000000018B75E9CC-0x000000018B75EA50
			internal Quaternion anchorRelativeToHead { get; private set; } // 0x000000018B75E334-0x000000018B75E390 0x000000018B75EC40-0x000000018B75ECF4
	
			// Constructors
			public Spine() {} // 0x000000018B762320-0x000000018B762360
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) {} // 0x000000018B75F07C-0x000000018B75F13C
			public override void PreSolve(float scale) {} // 0x000000018B75F13C-0x000000018B75F38C
			public override void ApplyOffsets(float scale) {} // 0x000000018B75E390-0x000000018B75E5B8
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms) {} // 0x000000018B75E0A8-0x000000018B75E1AC
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale) {} // 0x000000018B75F658-0x000000018B760664
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight) {} // 0x0000000185FBCEB0-0x0000000185FBCED0
			private void SolvePelvis() {} // 0x0000000185FBCF70-0x0000000185FBCF90
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) {} // 0x000000018B75ECF4-0x000000018B75EFC0
			public override void ResetOffsets() {} // 0x000000018B75F38C-0x000000018B75F628
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms) {} // 0x000000018B75F020-0x000000018B75F074
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w) {} // 0x000000018B75E5B8-0x000000018B75E9CC
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale) {} // 0x000000018B75E1AC-0x000000018B75E334
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2 /* Metadata: 0x02078348 */) => default; // 0x000000018B760664-0x000000018B761FA4
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w) {} // 0x000000018B7622DC-0x000000018B762320
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w) {} // 0x000000018B762360-0x000000018B7623A4
		}
	
		[Serializable]
		public enum PositionOffset // TypeDefIndex: 53718
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2,
			LeftHand = 3,
			RightHand = 4,
			LeftFoot = 5,
			RightFoot = 6,
			LeftHeel = 7,
			RightHeel = 8
		}
	
		[Serializable]
		public enum RotationOffset // TypeDefIndex: 53719
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2
		}
	
		[Serializable]
		public class VirtualBone // TypeDefIndex: 53720
		{
			// Fields
			public Vector3 readPosition; // 0x10
			public Quaternion readRotation; // 0x1C
			public Vector3 solverPosition; // 0x2C
			public Quaternion solverRotation; // 0x38
			public float length; // 0x48
			public float sqrMag; // 0x4C
			public Vector3 axis; // 0x50
	
			// Constructors
			public VirtualBone() {} // Dummy constructor
			public VirtualBone(Vector3 position, Quaternion rotation) {} // 0x000000018B7623A4-0x000000018B7623E4
	
			// Methods
			public void Read(Vector3 position, Quaternion rotation) {} // 0x000000018B761FA4-0x000000018B762130
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x02078355 */) {} // 0x000000018B75EA50-0x000000018B75EAB0
			public static float PreSolve(ref VirtualBone[] bones) => default; // 0x000000018B75EAB0-0x000000018B75EC40
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation) {} // 0x000000018B762130-0x000000018B7622DC
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation) {} // 0x000000018B765F08-0x000000018B765F38
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation) {} // 0x000000018B765E78-0x000000018B765EA8
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation) {} // 0x000000018B765E34-0x000000018B765E78
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight) {} // 0x000000018B765EA8-0x000000018B765ED8
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) => default; // 0x000000018B765ED8-0x000000018B765F08
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset) {} // 0x0000000185FD58A0-0x0000000185FD58B0
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x0000000185FD58C0-0x0000000185FD58D0
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations) {} // 0x0000000185FD5890-0x0000000185FD58A0
		}
	
		// Constructors
		public IKSolverVR() {} // 0x000000018B7679B4-0x000000018B767BA4
	
		// Methods
		public void SetToReferences(VRIK.References references) {} // 0x000000018B7645E4-0x000000018B764B30
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero) {} // 0x000000018B7627BC-0x000000018B762D20
		public void DefaultAnimationCurves() {} // 0x000000018B7631A4-0x000000018B76336C
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value) {} // 0x000000018B764EFC-0x000000018B76560C
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value) {} // 0x000000018B76336C-0x000000018B763590
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value) {} // 0x000000018B764BE4-0x000000018B764EFC
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot) {} // 0x000000018B765A6C-0x000000018B765C78
		public void Reset() {} // 0x000000018B764B30-0x000000018B764BE4
		public override void StoreDefaultLocalState() {} // 0x000000018B7623E4-0x000000018B7627BC
		public override void FixTransforms() {} // 0x000000018B763590-0x000000018B763720
		public override Point[] GetPoints() => default; // 0x000000018B76560C-0x000000018B765A6C
		public override Point GetPoint(Transform transform) => default; // 0x000000018B763720-0x000000018B763A7C
		public override bool IsValid(ref string message) => default; // 0x000000018B762D20-0x000000018B762F34
		private Vector3 GetNormal(Transform[] transforms) => default; // 0x000000018B762F34-0x000000018B7631A4
		private static Keyframe[] GetSineKeyframes(float mag) => default; // 0x000000018B765C78-0x000000018B765E34
		private void UpdateSolverTransforms() {} // 0x0000000185FD58D0-0x0000000185FD5900
		protected override void OnInitiate() {} // 0x0000000185FD58D0-0x0000000185FD5900
		protected override void OnUpdate() {} // 0x000000018B768660-0x000000018B768824
		private void WriteTransforms() {} // 0x000000018B76714C-0x000000018B767404
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms) {} // 0x000000018B767404-0x000000018B767588
		private void Solve() {} // 0x000000018B767588-0x000000018B767748
		private Vector3 GetPosition(int index) => default; // 0x000000018B767748-0x000000018B767900
		private Quaternion GetRotation(int index) => default; // 0x000000018B767900-0x000000018B7679B4
		private void Write() {} // 0x000000018B767C88-0x000000018B768118
		private Vector3 GetPelvisOffset(float deltaTime) => default; // 0x000000018B767BA4-0x000000018B767C88
	}

	public class TwistRelaxer : MonoBehaviour // TypeDefIndex: 53722
	{
		// Fields
		public IK ik; // 0x18
		public TwistSolver[] twistSolvers; // 0x20
	
		// Constructors
		public TwistRelaxer() {} // 0x000000018B7663D0-0x000000018B766420
	
		// Methods
		public void Start() {} // 0x000000018B76617C-0x000000018B766334
		private void Update() {} // 0x000000018B766334-0x000000018B7663D0
		private void OnPostUpdate() {} // 0x000000018B7660F0-0x000000018B76617C
		private void LateUpdate() {} // 0x000000018B765F38-0x000000018B765FC4
		private void OnDestroy() {} // 0x000000018B765FC4-0x000000018B7660F0
	}

	[Serializable]
	public class TwistSolver // TypeDefIndex: 53723
	{
		// Fields
		public Transform transform; // 0x10
		public Transform parent; // 0x18
		public Transform[] children; // 0x20
		public float weight; // 0x28
		public float parentChildCrossfade; // 0x2C
		public float twistAngleOffset; // 0x30
		private Vector3 twistAxis; // 0x34
		private Vector3 axis; // 0x40
		private Vector3 axisRelativeToParentDefault; // 0x4C
		private Vector3 axisRelativeToChildDefault; // 0x58
		private Quaternion[] childRotations; // 0x68
		private bool inititated; // 0x70
		private Quaternion defaultLocalRotation; // 0x74
		private Quaternion[] defaultChildLocalRotations; // 0x88
	
		// Constructors
		public TwistSolver() {} // 0x000000018B766EF4-0x000000018B766F90
	
		// Methods
		public void Initiate() {} // 0x000000018B7664D4-0x000000018B766A90
		public void FixTransforms() {} // 0x000000018B766420-0x000000018B7664D4
		public void Relax() {} // 0x000000018B766A90-0x000000018B766EF4
	}

	[Serializable]
	public class InteractionEffector // TypeDefIndex: 53724
	{
		// Fields
		private FullBodyBipedEffector _effectorType_k__BackingField; // 0x10
		private bool _isPaused_k__BackingField; // 0x14
		private InteractionObject _interactionObject_k__BackingField; // 0x18
		private Poser poser; // 0x20
		private IKEffector effector; // 0x28
		private float timer; // 0x30
		private float length; // 0x34
		private float weight; // 0x38
		private float fadeInSpeed; // 0x3C
		private float defaultPositionWeight; // 0x40
		private float defaultRotationWeight; // 0x44
		private float defaultPull; // 0x48
		private float defaultReach; // 0x4C
		private float defaultPush; // 0x50
		private float defaultPushParent; // 0x54
		private float defaultBendGoalWeight; // 0x58
		private float resetTimer; // 0x5C
		private bool positionWeightUsed; // 0x60
		private bool rotationWeightUsed; // 0x61
		private bool pullUsed; // 0x62
		private bool reachUsed; // 0x63
		private bool pushUsed; // 0x64
		private bool pushParentUsed; // 0x65
		private bool bendGoalWeightUsed; // 0x66
		private bool pickedUp; // 0x67
		private bool defaults; // 0x68
		private bool pickUpOnPostFBBIK; // 0x69
		private Vector3 pickUpPosition; // 0x6C
		private Vector3 pausePositionRelative; // 0x78
		private Quaternion pickUpRotation; // 0x84
		private Quaternion pauseRotationRelative; // 0x94
		private InteractionTarget interactionTarget; // 0xA8
		private Transform target; // 0xB0
		private List<bool> triggered; // 0xB8
		private InteractionSystem interactionSystem; // 0xC0
		private bool started; // 0xC8
	
		// Properties
		public FullBodyBipedEffector effectorType { get; private set; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public bool isPaused { get; private set; } // 0x0000000185FBA190-0x0000000185FBA1A0 0x0000000185FBA1B0-0x0000000185FBA1C0
		public InteractionObject interactionObject { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public bool inInteraction { get => default; } // 0x000000018B75B944-0x000000018B75B994 
		public float progress { get => default; } // 0x000000018B75B994-0x000000018B75B9CC 
	
		// Constructors
		public InteractionEffector() {} // Dummy constructor
		public InteractionEffector(FullBodyBipedEffector effectorType) {} // 0x000000018B75B8B8-0x000000018B75B944
	
		// Methods
		public void Initiate(InteractionSystem interactionSystem) {} // 0x000000018B759B18-0x000000018B759BD0
		private void StoreDefaults() {} // 0x000000018B75AD84-0x000000018B75AF74
		public bool ResetToDefaults(float speed, float deltaTime) => default; // 0x000000018B75A288-0x000000018B75A6F8
		public bool Pause() => default; // 0x000000018B759EBC-0x000000018B759FDC
		public bool Resume() => default; // 0x000000018B75A6F8-0x000000018B75A74C
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt) => default; // 0x000000018B75AB54-0x000000018B75AC5C
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt) => default; // 0x000000018B75A74C-0x000000018B75AB54
		public void Update(Transform root, float speed, float deltaTime) {} // 0x000000018B75B21C-0x000000018B75B8B8
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause) {
			pickUp = default;
			pause = default;
		} // 0x000000018B75AF74-0x000000018B75B21C
		private void PickUp(Transform root) {} // 0x000000018B759FDC-0x000000018B75A288
		public bool Stop() => default; // 0x000000018B75AC5C-0x000000018B75AD84
		public void OnPostFBBIK() {} // 0x000000018B759BD0-0x000000018B759EBC
	}

	[Serializable]
	public class InteractionLookAt // TypeDefIndex: 53725
	{
		// Fields
		public LookAtIK ik; // 0x10
		public float lerpSpeed; // 0x18
		public float weightSpeed; // 0x1C
		public bool isPaused; // 0x20
		private Transform lookAtTarget; // 0x28
		private float stopLookTime; // 0x30
		private float weight; // 0x34
		private bool firstFBBIKSolve; // 0x38
	
		// Constructors
		public InteractionLookAt() {} // 0x0000000185FD5A00-0x0000000185FD5A10
	
		// Methods
		public void Look(Transform target, float time) {} // 0x000000018B76E490-0x000000018B76E61C
		public void OnFixTransforms() {} // 0x000000018B76E61C-0x000000018B76E69C
		public void Update() {} // 0x000000018B76E874-0x000000018B76EA98
		public void SolveSpine() {} // 0x000000018B76E760-0x000000018B76E874
		public void SolveHead() {} // 0x000000018B76E69C-0x000000018B76E760
	}

	public class InteractionObject : MonoBehaviour // TypeDefIndex: 53732
	{
		// Fields
		public Transform otherLookAtTarget; // 0x18
		public Transform otherTargetsRoot; // 0x20
		public Transform positionOffsetSpace; // 0x28
		public WeightCurve[] weightCurves; // 0x30
		public Multiplier[] multipliers; // 0x38
		public InteractionEvent[] events; // 0x40
		private float _length_k__BackingField; // 0x48
		private InteractionSystem _lastUsedInteractionSystem_k__BackingField; // 0x50
		private InteractionTarget[] targets; // 0x58
	
		// Properties
		public float length { get; private set; } // 0x000000018B76F840-0x000000018B76FA50 0x000000018B76FE84-0x000000018B76FEEC
		public InteractionSystem lastUsedInteractionSystem { get; private set; } // 0x000000018B76FD90-0x000000018B76FD98 0x000000018B76EF2C-0x000000018B76F4C8
		public Transform lookAtTarget { get => default; } // 0x000000018B76FA50-0x000000018B76FAA4 
		public Transform targetsRoot { get => default; } // 0x000000018B769CAC-0x000000018B769D48 
	
		// Nested types
		[Serializable]
		public class InteractionEvent // TypeDefIndex: 53726
		{
			// Fields
			public float time; // 0x10
			public bool pause; // 0x14
			public bool pickUp; // 0x15
			public AnimatorEvent[] animations; // 0x18
			public Message[] messages; // 0x20
			public UnityEvent unityEvent; // 0x28
	
			// Constructors
			public InteractionEvent() {} // 0x000000018B76FC58-0x000000018B76FC8C
	
			// Methods
			public void Activate(Transform t) {} // 0x000000018B76FD5C-0x000000018B76FD90
		}
	
		[Serializable]
		public class Message // TypeDefIndex: 53727
		{
			// Fields
			public string function; // 0x10
			public GameObject recipient; // 0x18
			private const string empty = ""; // Metadata: 0x02078359
	
			// Constructors
			public Message() {} // 0x000000018B76FCC0-0x000000018B76FCF4
	
			// Methods
			public void Send(Transform t) {} // 0x000000018B76FC8C-0x000000018B76FCC0
		}
	
		[Serializable]
		public class AnimatorEvent // TypeDefIndex: 53728
		{
			// Fields
			public Animator animator; // 0x10
			public Animation animation; // 0x18
			public string animationState; // 0x20
			public float crossfadeTime; // 0x28
			public int layer; // 0x2C
			public bool resetNormalizedTime; // 0x30
			private const string empty = ""; // Metadata: 0x0207835A
	
			// Constructors
			public AnimatorEvent() {} // 0x000000018B76EA98-0x000000018B76EACC
	
			// Methods
			public void Activate(bool pickUp) {} // 0x000000018B76FCF4-0x000000018B76FD28
			private void Activate(Animator animator) {} // 0x000000018B76FD28-0x000000018B76FD5C
			private void Activate(Animation animation) {} // 0x000000018B76FD98-0x000000018B76FDCC
		}
	
		[Serializable]
		public class WeightCurve // TypeDefIndex: 53730
		{
			// Fields
			public Type type; // 0x10
			public AnimationCurve curve; // 0x18
	
			// Nested types
			[Serializable]
			public enum Type // TypeDefIndex: 53729
			{
				PositionWeight = 0,
				RotationWeight = 1,
				PositionOffsetX = 2,
				PositionOffsetY = 3,
				PositionOffsetZ = 4,
				Pull = 5,
				Reach = 6,
				RotateBoneWeight = 7,
				Push = 8,
				PushParent = 9,
				PoserWeight = 10,
				BendGoalWeight = 11
			}
	
			// Constructors
			public WeightCurve() {} // 0x0000000185FBCE20-0x0000000185FBCE30
	
			// Methods
			public float GetValue(float timer) => default; // 0x0000000185FB80E0-0x0000000185FB80F0
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 53731
		{
			// Fields
			public WeightCurve.Type curve; // 0x10
			public float multiplier; // 0x14
			public WeightCurve.Type result; // 0x18
	
			// Constructors
			public Multiplier() {} // 0x0000000184A4E570-0x0000000184A4E580
	
			// Methods
			public float GetValue(WeightCurve weightCurve, float timer) => default; // 0x0000000181460F60-0x0000000181460F70
		}
	
		// Constructors
		public InteractionObject() {} // 0x0000000181BBBA40-0x0000000181BBBA50
	
		// Methods
		private void OpenUserManual() {} // 0x000000018B76FAA4-0x000000018B76FC58
		private void OpenScriptReference() {} // 0x000000018B76FE1C-0x000000018B76FE84
		private void OpenTutorial1() {} // 0x000000018B76F6AC-0x000000018B76F7E0
		private void OpenTutorial2() {} // 0x000000018B76F4C8-0x000000018B76F540
		private void OpenTutorial3() {} // 0x00000001813F1630-0x00000001813F1640
		private void OpenTutorial4() {} // 0x000000018B76F594-0x000000018B76F6AC
		private void SupportGroup() {} // 0x0000000184A4E570-0x0000000184A4E580
		private void ASThread() {} // 0x000000018B76EACC-0x000000018B76EF2C
		public void Initiate() {} // 0x000000018B76F7E0-0x000000018B76F840
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem) => default; // 0x000000018B76F540-0x000000018B76F594
		public bool CurveUsed(WeightCurve.Type type) => default; // 0x000000018B76FDCC-0x000000018B76FE1C
		public InteractionTarget[] GetTargets() => default; // 0x000000018B76E3E8-0x000000018B76E490
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag) => default; // 0x0000000185492010-0x0000000185492020
		public void OnStartInteraction(InteractionSystem interactionSystem) {} // 0x000000018B775208-0x000000018B7752E0
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight) {} // 0x0000000185492010-0x0000000185492020
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer) => default; // 0x000000018B769BEC-0x000000018B769CAC
		private void Start() {} // 0x000000018B769B30-0x000000018B769BEC
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight) {} // 0x0000000185FD5900-0x0000000185FD5910
		private Transform GetTarget(FullBodyBipedEffector effectorType) => default; // 0x000000018B77A724-0x000000018B77A744
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType) => default; // 0x0000000185492010-0x0000000185492020
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType) => default; // 0x000000018B7752E0-0x000000018B775310
	}

	public class InteractionSystem : MonoBehaviour // TypeDefIndex: 53735
	{
		// Fields
		public string targetTag; // 0x18
		public float fadeInTime; // 0x20
		public float speed; // 0x24
		public float resetToDefaultsSpeed; // 0x28
		public Collider characterCollider; // 0x30
		public Transform FPSCamera; // 0x38
		public LayerMask camRaycastLayers; // 0x40
		public float camRaycastDistance; // 0x44
		private List<InteractionTrigger> _triggersInRange_k__BackingField; // 0x48
		private List<InteractionTrigger> inContact; // 0x50
		private List<int> bestRangeIndexes; // 0x58
		public InteractionDelegate OnInteractionStart; // 0x60
		public InteractionDelegate OnInteractionPause; // 0x68
		public InteractionDelegate OnInteractionPickUp; // 0x70
		public InteractionDelegate OnInteractionResume; // 0x78
		public InteractionDelegate OnInteractionStop; // 0x80
		public InteractionEventDelegate OnInteractionEvent; // 0x88
		public RaycastHit raycastHit; // 0x90
		private FullBodyBipedIK fullBody; // 0xD0
		public InteractionLookAt lookAt; // 0xD8
		private InteractionEffector[] interactionEffectors; // 0xE0
		private bool _initiated_k__BackingField; // 0xE8
		private Collider lastCollider; // 0xF0
		private Collider c; // 0xF8
		private float lastTime; // 0x100
	
		// Properties
		public bool inInteraction { get => default; } // 0x000000018B7719F0-0x000000018B771A6C 
		public FullBodyBipedIK ik { get => default; set {} } // 0x000000018B77095C-0x000000018B77097C 0x000000018B77095C-0x000000018B77097C
		public List<InteractionTrigger> triggersInRange { get; private set; } // 0x000000018B770D10-0x000000018B770D7C 0x000000018B7714C4-0x000000018B7715BC
		public bool initiated { get; private set; } // 0x000000018B7715BC-0x000000018B77168C 0x000000018B76FF20-0x000000018B7700CC
	
		// Nested types
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // TypeDefIndex: 53733; 0x000000018B77168C-0x000000018B7716C0
	
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent); // TypeDefIndex: 53734; 0x000000018B77175C-0x000000018B771790
	
		// Constructors
		public InteractionSystem() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		private void OpenUserManual() {} // 0x000000018B773678-0x000000018B773708
		private void OpenScriptReference() {} // 0x000000018B77097C-0x000000018B770A2C
		private void OpenTutorial1() {} // 0x000000018B770B9C-0x000000018B770C48
		private void OpenTutorial2() {} // 0x000000018B770B0C-0x000000018B770B9C
		private void OpenTutorial3() {} // 0x000000018B770A2C-0x000000018B770B0C
		private void OpenTutorial4() {} // 0x000000018B771B58-0x000000018B771C44
		private void SupportGroup() {} // 0x000000018B771A6C-0x000000018B771B58
		private void ASThread() {} // 0x000000018B771828-0x000000018B7718A4
		public bool IsInInteraction(FullBodyBipedEffector effectorType) => default; // 0x000000018B7722E4-0x000000018B772360
		public bool IsPaused(FullBodyBipedEffector effectorType) => default; // 0x000000018B7717C4-0x000000018B771828
		public bool IsPaused() => default; // 0x000000018B77198C-0x000000018B7719F0
		public bool IsInSync() => default; // 0x000000018B772290-0x000000018B7722E4
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt) => default; // 0x000000018B770680-0x000000018B7706FC
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt) => default; // 0x000000018B7707B8-0x000000018B770838
		public bool PauseInteraction(FullBodyBipedEffector effectorType) => default; // 0x000000018B7706FC-0x000000018B7707B8
		public bool ResumeInteraction(FullBodyBipedEffector effectorType) => default; // 0x000000018B772B7C-0x000000018B772D10
		public bool StopInteraction(FullBodyBipedEffector effectorType) => default; // 0x000000018B77271C-0x000000018B772900
		public void PauseAll() {} // 0x000000018B772900-0x000000018B772B7C
		public void ResumeAll() {} // 0x000000018B7701F8-0x000000018B7702D0
		public void StopAll() {} // 0x000000018B7700CC-0x000000018B77010C
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType) => default; // 0x000000018B7702D0-0x000000018B770340
		public float GetProgress(FullBodyBipedEffector effectorType) => default; // 0x000000018B77010C-0x000000018B7701F8
		public float GetMinActiveProgress() => default; // 0x000000018B770340-0x000000018B77049C
		public bool TriggerInteraction(int index, bool interrupt) => default; // 0x000000018B772394-0x000000018B772634
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject) {
			interactionObject = default;
			return default;
		} // 0x000000018B770838-0x000000018B77093C
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget) {
			interactionTarget = default;
			return default;
		} // 0x000000018B77049C-0x000000018B770680
		public InteractionTrigger.Range GetClosestInteractionRange() => default; // 0x0000000185FB15A0-0x0000000185FB15B0
		public InteractionObject GetClosestInteractionObjectInRange() => default; // 0x000000018774BD78-0x000000018774BD8C
		public InteractionTarget GetClosestInteractionTargetInRange() => default; // 0x00000001813ECF20-0x00000001813ECF30
		public InteractionObject[] GetClosestInteractionObjectsInRange() => default; // 0x000000018571FEC0-0x000000018571FED0
		public InteractionTarget[] GetClosestInteractionTargetsInRange() => default; // 0x0000000185FB67C0-0x0000000185FB67D0
		public bool TriggerEffectorsReady(int index) => default; // 0x0000000185FB67F0-0x0000000185FB6800
		public InteractionTrigger.Range GetTriggerRange(int index) => default; // 0x000000018B771C44-0x000000018B772290
		public int GetClosestTriggerIndex() => default; // 0x000000018B77093C-0x000000018B77095C
		public void Start() {} // 0x000000018B77127C-0x000000018B77135C
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x000000018B773088-0x000000018B773298
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x000000018B7718A4-0x000000018B77198C
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x000000018B772E3C-0x000000018B773088
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x000000018B77135C-0x000000018B77137C
		public void OnTriggerEnter(Collider c) {} // 0x000000018B772D10-0x000000018B772E3C
		public void OnTriggerExit(Collider c) {} // 0x000000018B771448-0x000000018B7714C4
		private bool ContactIsInRange(int index, out int bestRangeIndex) {
			bestRangeIndex = default;
			return default;
		} // 0x000000018B7713A0-0x000000018B771448
		private void OnDrawGizmosSelected() {} // 0x000000018B77137C-0x000000018B7713A0
		public void Update() {} // 0x000000018B770D7C-0x000000018B77127C
		private void Raycasting() {} // 0x000000018B770C48-0x000000018B770D10
		private void UpdateTriggerEventBroadcasting() {} // 0x000000018B772634-0x000000018B77271C
		private void OnEnable() {} // 0x000000018B773298-0x000000018B773678
		private void UpdateEffectors() {} // 0x00000001864BB734-0x00000001864BB7FC
		private void OnPreFBBIK() {} // 0x00000001831C5680-0x00000001831C5690
		private void OnPostFBBIK() {} // 0x000000018B76E2E0-0x000000018B76E360
		private void OnFixTransforms() {} // 0x00000001864BB614-0x00000001864BB734
		private void OnDestroy() {} // 0x000000018A1DF768-0x000000018A1DF830
		private bool IsValid(bool log) => default; // 0x0000000181A578C0-0x0000000181A578E0
		private bool TriggerIndexIsValid(int index) => default; // 0x000000018B76E360-0x000000018B76E3E8
	}

	public class InteractionTarget : MonoBehaviour // TypeDefIndex: 53738
	{
		// Fields
		public FullBodyBipedEffector effectorType; // 0x18
		public Multiplier[] multipliers; // 0x20
		public float interactionSpeedMlp; // 0x28
		public Transform pivot; // 0x30
		public RotationMode rotationMode; // 0x38
		public Vector3 twistAxis; // 0x3C
		public float twistWeight; // 0x48
		public float swingWeight; // 0x4C
		public float threeDOFWeight; // 0x50
		public bool rotateOnce; // 0x54
		private Quaternion defaultLocalRotation; // 0x58
		private Transform lastPivot; // 0x68
	
		// Nested types
		[Serializable]
		public enum RotationMode // TypeDefIndex: 53736
		{
			TwoDOF = 0,
			ThreeDOF = 1
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 53737
		{
			// Fields
			public InteractionObject.WeightCurve.Type curve; // 0x10
			public float multiplier; // 0x14
	
			// Constructors
			public Multiplier() {} // 0x000000018B7738A0-0x000000018B7738D4
		}
	
		// Constructors
		public InteractionTarget() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void OpenUserManual() {} // 0x000000018B77379C-0x000000018B7737D0
		private void OpenScriptReference() {} // 0x000000018B7737D0-0x000000018B773804
		private void OpenTutorial1() {} // 0x000000018B773804-0x000000018B773838
		private void OpenTutorial2() {} // 0x000000018B773838-0x000000018B77386C
		private void OpenTutorial3() {} // 0x000000018B77386C-0x000000018B7738A0
		private void OpenTutorial4() {} // 0x000000018B773FD0-0x000000018B774004
		private void SupportGroup() {} // 0x000000018B773708-0x000000018B77373C
		private void ASThread() {} // 0x000000018B77373C-0x000000018B77379C
		public float GetValue(InteractionObject.WeightCurve.Type curveType) => default; // 0x000000018B7738D4-0x000000018B773950
		public void ResetRotation() {} // 0x000000018B773950-0x000000018B773FD0
		public void RotateTo(Transform bone) {} // 0x000000018B774004-0x000000018B774040
	}

	public class InteractionTrigger : MonoBehaviour // TypeDefIndex: 53743
	{
		// Fields
		public Range[] ranges; // 0x18
	
		// Nested types
		[Serializable]
		public class CharacterPosition // TypeDefIndex: 53739
		{
			// Fields
			public bool use; // 0x10
			public Vector2 offset; // 0x14
			public float angleOffset; // 0x1C
			public float maxAngle; // 0x20
			public float radius; // 0x24
			public bool orbit; // 0x28
			public bool fixYAxis; // 0x29
	
			// Properties
			public Vector3 offset3D { get => default; } // 0x000000018B77428C-0x000000018B7742C0 
			public Vector3 direction3D { get => default; } // 0x000000018B774224-0x000000018B774258 
	
			// Constructors
			public CharacterPosition() {} // 0x000000018B7742C0-0x000000018B7742F4
	
			// Methods
			public bool IsInRange(Transform character, Transform trigger, out float error) {
				error = default;
				return default;
			} // 0x000000018B774258-0x000000018B77428C
		}
	
		[Serializable]
		public class CameraPosition // TypeDefIndex: 53740
		{
			// Fields
			public Collider lookAtTarget; // 0x10
			public Vector3 direction; // 0x18
			public float maxDistance; // 0x24
			public float maxAngle; // 0x28
			public bool fixYAxis; // 0x2C
	
			// Constructors
			public CameraPosition() {} // 0x000000018B7742F4-0x000000018B774344
	
			// Methods
			public Quaternion GetRotation() => default; // 0x000000018B774040-0x000000018B774074
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error) {
				error = default;
				return default;
			} // 0x000000018B774074-0x000000018B774224
		}
	
		[Serializable]
		public class Range // TypeDefIndex: 53742
		{
			// Fields
			public string name; // 0x10
			public bool show; // 0x18
			public CharacterPosition characterPosition; // 0x20
			public CameraPosition cameraPosition; // 0x28
			public Interaction[] interactions; // 0x30
	
			// Nested types
			[Serializable]
			public class Interaction // TypeDefIndex: 53741
			{
				// Fields
				public InteractionObject interactionObject; // 0x10
				public FullBodyBipedEffector[] effectors; // 0x18
	
				// Constructors
				public Interaction() {} // 0x0000000185FD59B0-0x0000000185FD59D0
			}
	
			// Constructors
			public Range() {} // 0x000000018B76B38C-0x000000018B76B9D4
	
			// Methods
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError) {
				maxError = default;
				return default;
			} // 0x000000018B76B9D4-0x000000018B76BA64
		}
	
		// Constructors
		public InteractionTrigger() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void OpenUserManual() {} // 0x0000000185FD59A0-0x0000000185FD59B0
		private void OpenScriptReference() {} // 0x000000018B76AF38-0x000000018B76B098
		private void OpenTutorial4() {} // 0x000000018B76B098-0x000000018B76B334
		private void SupportGroup() {} // 0x000000018B76B334-0x000000018B76B38C
		private void ASThread() {} // 0x000000018B776A84-0x000000018B776B74
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit) => default; // 0x0000000181B75280-0x0000000181B75290
	}

	public class GenericPoser : Poser // TypeDefIndex: 53745
	{
		// Fields
		public Map[] maps; // 0x50
	
		// Nested types
		[Serializable]
		public class Map // TypeDefIndex: 53744
		{
			// Fields
			public Transform bone; // 0x10
			public Transform target; // 0x18
			private Vector3 defaultLocalPosition; // 0x20
			private Quaternion defaultLocalRotation; // 0x2C
	
			// Constructors
			public Map() {} // Dummy constructor
			public Map(Transform bone, Transform target) {} // 0x000000018B76C920-0x000000018B76CB50
	
			// Methods
			public void StoreDefaultState() {} // 0x000000018B76CC20-0x000000018B76CC28
			public void FixTransform() {} // 0x000000018B76CC7C-0x000000018B76CD54
			public void Update(float localRotationWeight, float localPositionWeight) {} // 0x000000018B76CB50-0x000000018B76CBA4
		}
	
		// Constructors
		public GenericPoser() {} // 0x000000018B775078-0x000000018B7751D4
	
		// Methods
		public override void AutoMapping() {} // 0x000000018B76CC28-0x000000018B76CC7C
		protected override void InitiatePoser() {} // 0x000000018B76CBA4-0x000000018B76CC20
		protected override void UpdatePoser() {} // 0x000000018B76CD54-0x000000018B76CD5C
		protected override void FixPoserTransforms() {} // 0x000000018B7751D4-0x000000018B775208
		private void StoreDefaultState() {} // 0x000000018B7341FC-0x000000018B734258
		private Transform GetTargetNamed(string tName, Transform[] array) => default; // 0x000000018B775018-0x000000018B775078
	}

	public class HandPoser : Poser // TypeDefIndex: 53746
	{
		// Fields
		protected Transform[] children; // 0x50
		private Transform _poseRoot; // 0x58
		private Transform[] poseChildren; // 0x60
		private Vector3[] defaultLocalPositions; // 0x68
		private Quaternion[] defaultLocalRotations; // 0x70
	
		// Constructors
		public HandPoser() {} // 0x000000018B76CD54-0x000000018B76CD5C
	
		// Methods
		public override void AutoMapping() {} // 0x000000018B76CD5C-0x000000018B76CE14
		protected override void InitiatePoser() {} // 0x000000018B76CF08-0x000000018B76CF58
		protected override void FixPoserTransforms() {} // 0x000000018B76CE14-0x000000018B76CF08
		protected override void UpdatePoser() {} // 0x000000018B76D0BC-0x000000018B76D40C
		protected void StoreDefaultState() {} // 0x000000018B76CF58-0x000000018B76D0BC
	}

	public abstract class Poser : SolverManager // TypeDefIndex: 53747
	{
		// Fields
		public Transform poseRoot; // 0x38
		public float weight; // 0x40
		public float localRotationWeight; // 0x44
		public float localPositionWeight; // 0x48
		private bool initiated; // 0x4C
	
		// Constructors
		protected Poser() {} // 0x000000018B775780-0x000000018B77579C
	
		// Methods
		public abstract void AutoMapping();
		public void UpdateManual() {} // 0x0000000188169208-0x0000000188169218
		protected abstract void InitiatePoser();
		protected abstract void UpdatePoser();
		protected abstract void FixPoserTransforms();
		protected override void UpdateSolver() {} // 0x000000018B775744-0x000000018B775780
		protected override void InitiateSolver() {} // 0x000000018B77571C-0x000000018B775744
		protected override void FixTransforms() {} // 0x000000018B775708-0x000000018B77571C
	}

	public class RagdollUtility : MonoBehaviour // TypeDefIndex: 53751
	{
		// Fields
		public IK ik; // 0x18
		public float ragdollToAnimationTime; // 0x20
		public bool applyIkOnRagdoll; // 0x24
		public float applyVelocity; // 0x28
		public float applyAngularVelocity; // 0x2C
		private Animator animator; // 0x30
		private Rigidbone[] rigidbones; // 0x38
		private Child[] children; // 0x40
		private bool enableRagdollFlag; // 0x48
		private AnimatorUpdateMode animatorUpdateMode; // 0x4C
		private IK[] allIKComponents; // 0x50
		private bool[] fixTransforms; // 0x58
		private float ragdollWeight; // 0x60
		private float ragdollWeightV; // 0x64
		private bool fixedFrame; // 0x68
		private bool[] disabledIKComponents; // 0x70
	
		// Properties
		private bool isRagdoll { get => default; } // 0x000000018B76BBC0-0x000000018B76BC1C 
		private bool ikUsed { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		public class Rigidbone // TypeDefIndex: 53748
		{
			// Fields
			public Rigidbody r; // 0x10
			public Transform t; // 0x18
			public Collider collider; // 0x20
			public Joint joint; // 0x28
			public Rigidbody c; // 0x30
			public bool updateAnchor; // 0x38
			public Vector3 deltaPosition; // 0x3C
			public Quaternion deltaRotation; // 0x48
			public float deltaTime; // 0x58
			public Vector3 lastPosition; // 0x5C
			public Quaternion lastRotation; // 0x68
	
			// Constructors
			public Rigidbone() {} // Dummy constructor
			public Rigidbone(Rigidbody r) {} // 0x000000018B775D1C-0x000000018B775D44
	
			// Methods
			public void RecordVelocity() {} // 0x000000018B775CD4-0x000000018B775D1C
			public void WakeUp(float velocityWeight, float angularVelocityWeight) {} // 0x000000018B7761F0-0x000000018B7765F8
		}
	
		public class Child // TypeDefIndex: 53749
		{
			// Fields
			public Transform t; // 0x10
			public Vector3 localPosition; // 0x18
			public Quaternion localRotation; // 0x24
	
			// Constructors
			public Child() {} // Dummy constructor
			public Child(Transform transform) {} // 0x000000018B775C78-0x000000018B775CD4
	
			// Methods
			public void FixTransform(float weight) {} // 0x000000018B776644-0x000000018B776834
			public void StoreLocalState() {} // 0x000000018B775DA0-0x000000018B775DD8
		}
	
		private sealed class _DisableRagdollSmooth_d__21 : IEnumerator<object> // TypeDefIndex: 53750
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public RagdollUtility __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B775F70-0x000000018B775FAC 
			object IEnumerator.Current { get => default; } // 0x000000018B776A24-0x000000018B776A84 
	
			// Constructors
			public _DisableRagdollSmooth_d__21() {} // Dummy constructor
			public _DisableRagdollSmooth_d__21(int __1__state) {} // 0x000000018B775DD8-0x000000018B775E44
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B775C4C-0x000000018B775C78
			private bool MoveNext() => default; // 0x000000018B775C14-0x000000018B775C4C
			void IEnumerator.Reset() {} // 0x000000018B775FAC-0x000000018B7761A4
		}
	
		// Constructors
		public RagdollUtility() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public void EnableRagdoll() {} // 0x000000018B7761A4-0x000000018B7761F0
		public void DisableRagdoll() {} // 0x000000018B776928-0x000000018B776A24
		public void Start() {} // 0x000000018B7765F8-0x000000018B776644
		private IEnumerator DisableRagdollSmooth() => default; // 0x000000018B775D44-0x000000018B775DA0
		private void Update() {} // 0x000000018B775E44-0x000000018B775F70
		private void FixedUpdate() {} // 0x000000018B776834-0x000000018B776928
		private void LateUpdate() {} // 0x000000018B7772C8-0x000000018B77743C
		private void AfterLastIK() {} // 0x000000018B776F54-0x000000018B777070
		private void AfterAnimation() {} // 0x000000018B777070-0x000000018B7772C8
		private void OnFinalPose() {} // 0x000000018B76BC1C-0x000000018B76BC84
		private void RagdollEnabler() {} // 0x000000018B76BA64-0x000000018B76BBC0
		private void RecordVelocities() {} // 0x0000000181378230-0x0000000181378240
		private void StoreLocalState() {} // 0x000000018B77A410-0x000000018B77A5D8
		private void FixTransforms(float weight) {} // 0x0000000181377E40-0x0000000181377E50
		private void OnDestroy() {} // 0x000000018B77A5D8-0x000000018B77A624
	}

	public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 53752
	{
		// Fields
		public Vector3 axis; // 0x18
		public Quaternion defaultLocalRotation; // 0x24
		private bool _defaultLocalRotationOverride_k__BackingField; // 0x34
		private bool initiated; // 0x35
		private bool applicationQuit; // 0x36
		private bool defaultLocalRotationSet; // 0x37
	
		// Properties
		public Vector3 secondaryAxis { get; } // 0x0000000185FD5A50-0x0000000185FD5A70 
		public Vector3 crossAxis { get; } // 0x000000018B779DF8-0x000000018B779E68 
		public bool defaultLocalRotationOverride { get; private set; } // 0x0000000185FB0B90-0x0000000185FB0BA0 0x0000000185FB0BB0-0x0000000185FB0BC0
	
		// Constructors
		protected RotationLimit() {} // 0x000000018B779DD4-0x000000018B779DF8
	
		// Methods
		public void SetDefaultLocalRotation() {} // 0x000000018B779D94-0x000000018B779DD4
		public void SetDefaultLocalRotation(Quaternion localRotation) {} // 0x0000000185FD5A40-0x0000000185FD5A50
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) {
			changed = default;
			return default;
		} // 0x000000018B779978-0x000000018B779A9C
		public bool Apply() => default; // 0x000000018B7797EC-0x000000018B779888
		public void Disable() {} // 0x000000018B779950-0x000000018B779978
		protected abstract Quaternion LimitRotation(Quaternion rotation);
		private void Awake() {} // 0x000000018B779888-0x000000018B779950
		private void LateUpdate() {} // 0x000000018B779B14-0x000000018B779B1C
		public void LogWarning(string message) {} // 0x000000018B71F014-0x000000018B71F03C
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) => default; // 0x000000018B779B1C-0x000000018B779BCC
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) => default; // 0x000000018B779BCC-0x000000018B779D94
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) => default; // 0x000000018B779A9C-0x000000018B779B14
	}

	public class RotationLimitAngle : RotationLimit // TypeDefIndex: 53753
	{
		// Fields
		public float limit; // 0x38
		public float twistLimit; // 0x3C
	
		// Constructors
		public RotationLimitAngle() {} // 0x000000018B7777D8-0x000000018B7777F0
	
		// Methods
		private void OpenUserManual() {} // 0x000000018B777770-0x000000018B7777A4
		private void OpenScriptReference() {} // 0x000000018B77773C-0x000000018B777770
		private void SupportGroup() {} // 0x000000018B7777A4-0x000000018B7777D8
		private void ASThread() {} // 0x000000018B77743C-0x000000018B777470
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x000000018B777470-0x000000018B777534
		private Quaternion LimitSwing(Quaternion rotation) => default; // 0x000000018B777534-0x000000018B77773C
	}

	public class RotationLimitHinge : RotationLimit // TypeDefIndex: 53754
	{
		// Fields
		public bool useLimits; // 0x38
		public float min; // 0x3C
		public float max; // 0x40
		public float zeroAxisDisplayOffset; // 0x44
		private float lastAngle; // 0x48
	
		// Constructors
		public RotationLimitHinge() {} // 0x000000018B777B20-0x000000018B777B3C
	
		// Methods
		private void OpenUserManual() {} // 0x000000018B777AB8-0x000000018B777AEC
		private void OpenScriptReference() {} // 0x000000018B777A84-0x000000018B777AB8
		private void SupportGroup() {} // 0x000000018B777AEC-0x000000018B777B20
		private void ASThread() {} // 0x000000018B7777F0-0x000000018B777824
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x000000018B777A50-0x000000018B777A84
		private Quaternion LimitHinge(Quaternion rotation) => default; // 0x000000018B777824-0x000000018B777A50
	}

	public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 53757
	{
		// Fields
		public float twistLimit; // 0x38
		public int smoothIterations; // 0x3C
		public LimitPoint[] points; // 0x40
		public Vector3[] P; // 0x48
		public ReachCone[] reachCones; // 0x50
	
		// Nested types
		[Serializable]
		public class ReachCone // TypeDefIndex: 53755
		{
			// Fields
			public Vector3[] tetrahedron; // 0x10
			public float volume; // 0x18
			public Vector3 S; // 0x1C
			public Vector3 B; // 0x28
	
			// Properties
			public Vector3 o { get => default; } // 0x000000018B7784A4-0x000000018B7784D8 
			public Vector3 a { get => default; } // 0x000000018B778470-0x000000018B7784A4 
			public Vector3 b { get => default; } // 0x000000018B779174-0x000000018B7791A8 
			public Vector3 c { get => default; } // 0x000000018B777B3C-0x000000018B777B70 
			public bool isValid { get => default; } // 0x000000018B7780D4-0x000000018B7781C0 
	
			// Constructors
			public ReachCone() {} // Dummy constructor
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c) {} // 0x000000018B7789C0-0x000000018B778A34
	
			// Methods
			public void Calculate() {} // 0x000000018B778F9C-0x000000018B779174
		}
	
		[Serializable]
		public class LimitPoint // TypeDefIndex: 53756
		{
			// Fields
			public Vector3 point; // 0x10
			public float tangentWeight; // 0x1C
	
			// Constructors
			public LimitPoint() {} // 0x000000018B7785DC-0x000000018B7789C0
		}
	
		// Constructors
		public RotationLimitPolygonal() {} // 0x000000018B774344-0x000000018B774368
	
		// Methods
		private void OpenUserManual() {} // 0x000000018B777B70-0x000000018B777F3C
		private void OpenScriptReference() {} // 0x000000018B778A34-0x000000018B778F9C
		private void SupportGroup() {} // 0x000000018B778084-0x000000018B7780D4
		private void ASThread() {} // 0x000000018B7784D8-0x000000018B7785DC
		public void SetLimitPoints(LimitPoint[] points) {} // 0x000000018B7791A8-0x000000018B779314
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x000000018B7781C0-0x000000018B778470
		private void Start() {} // 0x000000018B777F3C-0x000000018B778084
		public void ResetToDefault() {} // 0x000000018B779314-0x000000018B77936C
		public void BuildReachCones() {} // 0x000000018B776F28-0x000000018B776F54
		private Vector3[] SmoothPoints() => default; // 0x000000018B776E88-0x000000018B776EB8
		private float GetScalar(int k) => default; // 0x000000018B776EB8-0x000000018B776EE8
		private Vector3 PointToTangentPlane(Vector3 p, float r) => default; // 0x000000018B776EE8-0x000000018B776F18
		private Vector3 TangentPointToSphere(Vector3 q, float r) => default; // 0x000000018B776D2C-0x000000018B776E88
		private Quaternion LimitSwing(Quaternion rotation) => default; // 0x000000018B776F18-0x000000018B776F28
		private int GetReachCone(Vector3 L) => default; // 0x000000018B776B74-0x000000018B776D2C
	}

	public class RotationLimitSpline : RotationLimit // TypeDefIndex: 53758
	{
		// Fields
		public float twistLimit; // 0x38
		public AnimationCurve spline; // 0x40
	
		// Constructors
		public RotationLimitSpline() {} // 0x000000018B7797DC-0x000000018B7797EC
	
		// Methods
		private void OpenUserManual() {} // 0x000000018B779754-0x000000018B779788
		private void OpenScriptReference() {} // 0x000000018B779720-0x000000018B779754
		private void SupportGroup() {} // 0x000000018B7797A8-0x000000018B7797DC
		private void ASThread() {} // 0x000000018B77936C-0x000000018B7793A0
		public void SetSpline(Keyframe[] keyframes) {} // 0x000000018B779788-0x000000018B7797A8
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x000000018B7793A0-0x000000018B779464
		public Quaternion LimitSwing(Quaternion rotation) => default; // 0x000000018B779464-0x000000018B779720
	}

	public class AimController : MonoBehaviour // TypeDefIndex: 53760
	{
		// Fields
		public AimIK ik; // 0x18
		public float weight; // 0x20
		public Transform target; // 0x28
		public float targetSwitchSmoothTime; // 0x30
		public float weightSmoothTime; // 0x34
		public bool smoothTurnTowardsTarget; // 0x38
		public float maxRadiansDelta; // 0x3C
		public float maxMagnitudeDelta; // 0x40
		public float slerpSpeed; // 0x44
		public float smoothDampTime; // 0x48
		public Vector3 pivotOffsetFromRoot; // 0x4C
		public float minDistance; // 0x58
		public Vector3 offset; // 0x5C
		public float maxRootAngle; // 0x68
		public bool turnToTarget; // 0x6C
		public float turnToTargetTime; // 0x70
		public bool useAnimatedAimDirection; // 0x74
		public Vector3 animatedAimDirection; // 0x78
		private Transform lastTarget; // 0x88
		private float switchWeight; // 0x90
		private float switchWeightV; // 0x94
		private float weightV; // 0x98
		private Vector3 lastPosition; // 0x9C
		private Vector3 dir; // 0xA8
		private bool lastSmoothTowardsTarget; // 0xB4
		private bool turningToTarget; // 0xB5
		private float turnToTargetMlp; // 0xB8
		private float turnToTargetMlpV; // 0xBC
		private float yawV; // 0xC0
		private float pitchV; // 0xC4
		private float dirMagV; // 0xC8
	
		// Properties
		private Vector3 pivot { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private sealed class _TurnToTarget_d__37 : IEnumerator<object> // TypeDefIndex: 53759
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public AimController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B768824-0x000000018B76895C 
			object IEnumerator.Current { get => default; } // 0x000000018B7696A0-0x000000018B7696FC 
	
			// Constructors
			public _TurnToTarget_d__37() {} // Dummy constructor
			public _TurnToTarget_d__37(int __1__state) {} // 0x000000018B7695B0-0x000000018B7696A0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B76895C-0x000000018B7692EC
			private bool MoveNext() => default; // 0x000000018B76978C-0x000000018B769894
			void IEnumerator.Reset() {} // 0x000000018B7692EC-0x000000018B7695B0
		}
	
		// Constructors
		public AimController() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		private void Start() {} // 0x000000018B7696FC-0x000000018B76978C
		private void LateUpdate() {} // 0x0000000181378230-0x0000000181378240
		private void ApplyMinDistance() {} // 0x000000018B77A624-0x000000018B77A6D8
		private void RootRotation() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator TurnToTarget() => default; // 0x000000018B77A6D8-0x000000018B77A724
	}

	public class AimPoser : MonoBehaviour // TypeDefIndex: 53762
	{
		// Fields
		public float angleBuffer; // 0x18
		public Pose[] poses; // 0x20
	
		// Nested types
		[Serializable]
		public class Pose // TypeDefIndex: 53761
		{
			// Fields
			public bool visualize; // 0x10
			public string name; // 0x18
			public Vector3 direction; // 0x20
			public float yaw; // 0x2C
			public float pitch; // 0x30
			private float angleBuffer; // 0x34
	
			// Constructors
			public Pose() {} // 0x000000018B7699BC-0x000000018B769A14
	
			// Methods
			public bool IsInDirection(Vector3 d) => default; // 0x000000018B769894-0x000000018B76995C
			public void SetAngleBuffer(float value) {} // 0x000000018B76995C-0x000000018B7699BC
		}
	
		// Constructors
		public AimPoser() {} // 0x0000000185FD5A10-0x0000000185FD5A30
	
		// Methods
		public Pose GetPose(Vector3 localDirection) => default; // 0x000000018B7754E4-0x000000018B775708
		public void SetPoseActive(Pose pose) {} // 0x0000000185FB8A50-0x0000000185FB8A60
	}

	public class Amplifier : OffsetModifier // TypeDefIndex: 53765
	{
		// Fields
		public Body[] bodies; // 0x30
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 53764
		{
			// Fields
			public Transform transform; // 0x10
			public Transform relativeTo; // 0x18
			public EffectorLink[] effectorLinks; // 0x20
			public float verticalWeight; // 0x28
			public float horizontalWeight; // 0x2C
			public float speed; // 0x30
			private Vector3 lastRelativePos; // 0x34
			private Vector3 smoothDelta; // 0x40
			private bool firstUpdate; // 0x4C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 53763
			{
				// Fields
				public FullBodyBipedEffector effector; // 0x10
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink() {} // 0x000000018B769A14-0x000000018B769B30
			}
	
			// Constructors
			public Body() {} // 0x0000000185FD5910-0x0000000185FD5950
	
			// Methods
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime) {} // 0x0000000189CBA364-0x0000000189CBA374
			private static Vector3 Multiply(Vector3 v1, Vector3 v2) => default; // 0x000000018B76A4C0-0x000000018B76A900
		}
	
		// Constructors
		public Amplifier() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void OnModifyOffset() {} // 0x0000000185FD5970-0x0000000185FD5990
	}

	public class BodyTilt : OffsetModifier // TypeDefIndex: 53766
	{
		// Fields
		public float tiltSpeed; // 0x30
		public float tiltSensitivity; // 0x34
		public OffsetPose poseLeft; // 0x38
		public OffsetPose poseRight; // 0x40
		private float tiltAngle; // 0x48
		private Vector3 lastForward; // 0x4C
	
		// Constructors
		public BodyTilt() {} // 0x000000018B769F70-0x000000018B769F8C
	
		// Methods
		protected override void Start() {} // 0x000000018B769F24-0x000000018B769F70
		protected override void OnModifyOffset() {} // 0x000000018B769D48-0x000000018B769F24
	}

	public class CCDBendGoal : MonoBehaviour // TypeDefIndex: 53767
	{
		// Fields
		public CCDIK ik; // 0x18
		public float weight; // 0x20
	
		// Constructors
		public CCDBendGoal() {} // 0x0000000185F5A9C0-0x0000000185F5A9D0
	
		// Methods
		private void Start() {} // 0x000000018B76AE44-0x000000018B76AF38
		private void BeforeIK() {} // 0x000000018B76AA34-0x000000018B76AD1C
		private void OnDestroy() {} // 0x000000018B76AD1C-0x000000018B76AE44
	}

	public class EditorIK : MonoBehaviour // TypeDefIndex: 53768
	{
		// Fields
		public Animator animator; // 0x18
		public EditorIKPose defaultPose; // 0x20
		public Transform[] bones; // 0x28
		private IK _ik_k__BackingField; // 0x30
	
		// Properties
		public IK ik { get; private set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
	
		// Constructors
		public EditorIK() {} // 0x000000018B76C7E4-0x000000018B76C834
	
		// Methods
		private void OnEnable() {} // 0x000000018B76C394-0x000000018B76C4DC
		private void OnDisable() {} // 0x000000018B76C2C8-0x000000018B76C394
		private void OnDestroy() {} // 0x000000018B76C190-0x000000018B76C2C8
		public void StoreDefaultPose() {} // 0x000000018B76C4DC-0x000000018B76C554
		public bool Initiate() => default; // 0x000000018B76BFC0-0x000000018B76C190
		public void Update() {} // 0x000000018B76C554-0x000000018B76C7E4
	}

	public class EditorIKPose : ScriptableObject // TypeDefIndex: 53769
	{
		// Fields
		public Vector3[] localPositions; // 0x18
		public Quaternion[] localRotations; // 0x20
	
		// Properties
		public bool poseStored { get => default; } // 0x000000018B76BFA0-0x000000018B76BFC0 
	
		// Constructors
		public EditorIKPose() {} // 0x000000018B76BF28-0x000000018B76BFA0
	
		// Methods
		public void Store(Transform[] T) {} // 0x000000018B76BDDC-0x000000018B76BF28
		public bool Restore(Transform[] T) => default; // 0x000000018B76BC84-0x000000018B76BDDC
	}

	public class HitReaction : OffsetModifier // TypeDefIndex: 53775
	{
		// Fields
		public HitPointEffector[] effectorHitPoints; // 0x30
		public HitPointBone[] boneHitPoints; // 0x38
	
		// Properties
		public bool inProgress { get => default; } // 0x0000000185FD59F0-0x0000000185FD5A00 
	
		// Nested types
		[Serializable]
		public abstract class HitPoint // TypeDefIndex: 53770
		{
			// Fields
			public string name; // 0x10
			public Collider collider; // 0x18
			private float crossFadeTime; // 0x20
			private float _crossFader_k__BackingField; // 0x24
			private float _timer_k__BackingField; // 0x28
			private Vector3 _force_k__BackingField; // 0x2C
			private float length; // 0x38
			private float crossFadeSpeed; // 0x3C
			private float lastTime; // 0x40
	
			// Properties
			public bool inProgress { get; } // 0x000000018B76E154-0x000000018B76E1D4 
			protected float crossFader { get; private set; } // 0x000000018B76E0AC-0x000000018B76E154 0x000000018B76DECC-0x000000018B76E0AC
			protected float timer { get; private set; } // 0x0000000189CBA364-0x0000000189CBA374 0x000000018B76DC30-0x000000018B76DC40
			protected Vector3 force { get; private set; } // 0x0000000185FB3810-0x0000000185FB3820 0x0000000185FB3820-0x0000000185FB3830
	
			// Constructors
			protected HitPoint() {} // 0x000000018B76DA8C-0x000000018B76DB54
	
			// Methods
			public virtual void Hit(Vector3 force, Vector3 point) {} // 0x0000000185FB0A50-0x0000000185FB0A60
			public void Apply(IKSolverFullBodyBiped solver, float weight) {} // 0x0000000185FB0A60-0x0000000185FB0A70
			protected abstract float GetLength(); // 0x0000000185FBAA80-0x0000000185FBAAA0
			protected abstract void CrossFadeStart(); // 0x0000000185FBCE10-0x0000000185FBCE20
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight); // 0x000000018B76DB54-0x000000018B76DC30
		}
	
		[Serializable]
		public class HitPointEffector : HitPoint // TypeDefIndex: 53772
		{
			// Fields
			public AnimationCurve offsetInForceDirection; // 0x48
			public AnimationCurve offsetInUpDirection; // 0x50
			public EffectorLink[] effectorLinks; // 0x58
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 53771
			{
				// Fields
				public FullBodyBipedEffector effector; // 0x10
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public EffectorLink() {}
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader) {}
				public void CrossFadeStart() {}
			}
	
			// Constructors
			public HitPointEffector() {} // 0x000000018B76D8B4-0x000000018B76DA8C
	
			// Methods
			protected override float GetLength() => default; // 0x0000000185FD59F0-0x0000000185FD5A00
			protected override void CrossFadeStart() {} // 0x000000018B76D7AC-0x000000018B76D8B4
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight) {} // 0x000000018B76D760-0x000000018B76D7AC
		}
	
		[Serializable]
		public class HitPointBone : HitPoint // TypeDefIndex: 53774
		{
			// Fields
			public AnimationCurve aroundCenterOfMass; // 0x48
			public BoneLink[] boneLinks; // 0x50
			private Rigidbody rigidbody; // 0x58
			private Vector3 comAxis; // 0x60
	
			// Nested types
			[Serializable]
			public class BoneLink // TypeDefIndex: 53773
			{
				// Fields
				public Transform bone; // 0x10
				public float weight; // 0x18
				private Quaternion lastValue; // 0x1C
				private Quaternion current; // 0x2C
	
				// Constructors
				public BoneLink() {} // 0x0000000185FD59D0-0x0000000185FD59F0
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader) {} // 0x0000000185FD59F0-0x0000000185FD5A00
				public void CrossFadeStart() {} // 0x000000018B76C834-0x000000018B76C920
			}
	
			// Constructors
			public HitPointBone() {} // 0x000000018B76D68C-0x000000018B76D760
	
			// Methods
			public override void Hit(Vector3 force, Vector3 point) {} // 0x0000000185492010-0x0000000185492020
			protected override float GetLength() => default; // 0x000000018B76D4CC-0x000000018B76D68C
			protected override void CrossFadeStart() {} // 0x000000018B76D450-0x000000018B76D4CC
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight) {} // 0x000000018B76D40C-0x000000018B76D450
		}
	
		// Constructors
		public HitReaction() {} // 0x000000018B76AA04-0x000000018B76AA34
	
		// Methods
		protected override void OnModifyOffset() {} // 0x000000018B76A900-0x000000018B76AA04
		public void Hit(Collider collider, Vector3 force, Vector3 point) {} // 0x0000000185FD5990-0x0000000185FD59A0
	}

	public class HitReactionVRIK : OffsetModifierVRIK // TypeDefIndex: 53781
	{
		// Fields
		public AnimationCurve[] offsetCurves; // 0x30
		public PositionOffset[] positionOffsets; // 0x38
		public RotationOffset[] rotationOffsets; // 0x40
	
		// Nested types
		[Serializable]
		public abstract class Offset // TypeDefIndex: 53776
		{
			// Fields
			public string name; // 0x10
			public Collider collider; // 0x18
			private float crossFadeTime; // 0x20
			private float _crossFader_k__BackingField; // 0x24
			private float _timer_k__BackingField; // 0x28
			private Vector3 _force_k__BackingField; // 0x2C
			private float length; // 0x38
			private float crossFadeSpeed; // 0x3C
			private float lastTime; // 0x40
	
			// Properties
			protected float crossFader { get; private set; } // 0x000000018B76DE28-0x000000018B76DECC 0x000000018B76DC40-0x000000018B76DE28
			protected float timer { get; private set; } // 0x0000000189CBA364-0x0000000189CBA374 0x0000000185FB3810-0x0000000185FB3820
			protected Vector3 force { get; private set; } // 0x0000000185FB3820-0x0000000185FB3830 0x0000000185FB0A50-0x0000000185FB0A60
	
			// Constructors
			protected Offset() {}
	
			// Methods
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point) {} // 0x0000000185FB0A60-0x0000000185FB0A70
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight) {} // 0x0000000185FBAA80-0x0000000185FBAAA0
			protected abstract float GetLength(AnimationCurve[] curves); // 0x0000000185FBCE10-0x0000000185FBCE20
			protected abstract void CrossFadeStart(); // 0x000000018B7753E8-0x000000018B7754E4
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight); // 0x000000018B775310-0x000000018B7753E8
		}
	
		[Serializable]
		public class PositionOffset : Offset // TypeDefIndex: 53778
		{
			// Fields
			public int forceDirCurveIndex; // 0x48
			public int upDirCurveIndex; // 0x4C
			public PositionOffsetLink[] offsetLinks; // 0x50
	
			// Nested types
			[Serializable]
			public class PositionOffsetLink // TypeDefIndex: 53777
			{
				// Fields
				public IKSolverVR.PositionOffset positionOffset; // 0x10
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public PositionOffsetLink() {} // 0x0000000185FD59F0-0x0000000185FD5A00
	
				// Methods
				public void Apply(VRIK ik, Vector3 offset, float crossFader) {}
				public void CrossFadeStart() {}
			}
	
			// Constructors
			public PositionOffset() {} // 0x0000000185FD5A30-0x0000000185FD5A40
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves) => default; // 0x000000018B775898-0x000000018B775A0C
			protected override void CrossFadeStart() {} // 0x000000018B77584C-0x000000018B775898
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight) {} // 0x000000018B775A0C-0x000000018B775C14
		}
	
		[Serializable]
		public class RotationOffset : Offset // TypeDefIndex: 53780
		{
			// Fields
			public int curveIndex; // 0x48
			public RotationOffsetLink[] offsetLinks; // 0x50
			private Rigidbody rigidbody; // 0x58
			private Vector3 comAxis; // 0x60
	
			// Nested types
			[Serializable]
			public class RotationOffsetLink // TypeDefIndex: 53779
			{
				// Fields
				public IKSolverVR.RotationOffset rotationOffset; // 0x10
				public float weight; // 0x14
				private Quaternion lastValue; // 0x18
				private Quaternion current; // 0x28
	
				// Constructors
				public RotationOffsetLink() {} // 0x0000000185492010-0x0000000185492020
	
				// Methods
				public void Apply(VRIK ik, Quaternion offset, float crossFader) {} // 0x000000018B77579C-0x000000018B77584C
				public void CrossFadeStart() {} // 0x0000000185FD59D0-0x0000000185FD59F0
			}
	
			// Constructors
			public RotationOffset() {} // 0x0000000185FD59F0-0x0000000185FD5A00
	
			// Methods
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point) {} // 0x000000018B77A070-0x000000018B77A238
			protected override float GetLength(AnimationCurve[] curves) => default; // 0x000000018B779FB8-0x000000018B77A070
			protected override void CrossFadeStart() {} // 0x000000018B779F74-0x000000018B779FB8
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight) {} // 0x000000018B77A238-0x000000018B77A410
		}
	
		// Constructors
		public HitReactionVRIK() {} // 0x000000018B779F44-0x000000018B779F74
	
		// Methods
		protected override void OnModifyOffset() {} // 0x000000018B779E68-0x000000018B779F44
		public void Hit(Collider collider, Vector3 force, Vector3 point) {} // 0x0000000185FD5A70-0x0000000185FD5A80
	}

	public class Inertia : OffsetModifier // TypeDefIndex: 53784
	{
		// Fields
		public Body[] bodies; // 0x30
		public OffsetLimits[] limits; // 0x38
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 53783
		{
			// Fields
			public Transform transform; // 0x10
			public EffectorLink[] effectorLinks; // 0x18
			public float speed; // 0x20
			public float acceleration; // 0x24
			public float matchVelocity; // 0x28
			public float gravity; // 0x2C
			private Vector3 delta; // 0x30
			private Vector3 lazyPoint; // 0x3C
			private Vector3 direction; // 0x48
			private Vector3 lastPosition; // 0x54
			private bool firstUpdate; // 0x60
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 53782
			{
				// Fields
				public FullBodyBipedEffector effector; // 0x10
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink() {} // 0x000000018B76E284-0x000000018B76E2E0
			}
	
			// Constructors
			public Body() {} // 0x000000018B769F8C-0x000000018B76A04C
	
			// Methods
			public void Reset() {} // 0x000000018B76E1D4-0x000000018B76E284
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime) {} // 0x0000000189CBA364-0x0000000189CBA374
		}
	
		// Constructors
		public Inertia() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void ResetBodies() {} // 0x000000018B76A04C-0x000000018B76A4C0
		protected override void OnModifyOffset() {} // 0x0000000185FD5950-0x0000000185FD5970
	}

	public class LookAtController : MonoBehaviour // TypeDefIndex: 53785
	{
		// Fields
		public LookAtIK ik; // 0x18
		public Transform target; // 0x20
		public float weight; // 0x28
		public Vector3 offset; // 0x2C
		public float targetSwitchSmoothTime; // 0x38
		public float weightSmoothTime; // 0x3C
		public bool smoothTurnTowardsTarget; // 0x40
		public float maxRadiansDelta; // 0x44
		public float maxMagnitudeDelta; // 0x48
		public float slerpSpeed; // 0x4C
		public Vector3 pivotOffsetFromRoot; // 0x50
		public float minDistance; // 0x5C
		public float maxRootAngle; // 0x60
		private Transform lastTarget; // 0x68
		private float switchWeight; // 0x70
		private float switchWeightV; // 0x74
		private float weightV; // 0x78
		private Vector3 lastPosition; // 0x7C
		private Vector3 dir; // 0x88
		private bool lastSmoothTowardsTarget; // 0x94
	
		// Properties
		private Vector3 pivot { get => default; } // 0x000000018B774F10-0x000000018B775018 
	
		// Constructors
		public LookAtController() {} // 0x000000018B774EAC-0x000000018B774F10
	
		// Methods
		private void Start() {} // 0x000000018B774DE4-0x000000018B774EAC
		private void LateUpdate() {} // 0x000000018B7744A0-0x000000018B774B80
		private void ApplyMinDistance() {} // 0x000000018B774368-0x000000018B7744A0
		private void RootRotation() {} // 0x000000018B774B80-0x000000018B774DE4
	}

	public abstract class OffsetModifier : MonoBehaviour // TypeDefIndex: 53788
	{
		// Fields
		public float weight; // 0x18
		public FullBodyBipedIK ik; // 0x20
		protected float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x000000018B77B184-0x000000018B77B1E0 
	
		// Nested types
		[Serializable]
		public class OffsetLimits // TypeDefIndex: 53786
		{
			// Fields
			public FullBodyBipedEffector effector; // 0x10
			public float spring; // 0x14
			public bool x; // 0x18
			public bool y; // 0x19
			public bool z; // 0x1A
			public float minX; // 0x1C
			public float maxX; // 0x20
			public float minY; // 0x24
			public float maxY; // 0x28
			public float minZ; // 0x2C
			public float maxZ; // 0x30
	
			// Constructors
			public OffsetLimits() {} // 0x000000018B77B528-0x000000018B77B584
	
			// Methods
			public void Apply(IKEffector e, Quaternion rootRotation) {} // 0x000000018B77B44C-0x000000018B77B468
			private float SpringAxis(float value, float min, float max) => default;
			private float Spring(float value, float limit, bool negative) => default; // 0x000000018B77B770-0x000000018B77B794
		}
	
		private sealed class _Initiate_d__8 : IEnumerator<object> // TypeDefIndex: 53787
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public OffsetModifier __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000189CBA364-0x0000000189CBA374 
			object IEnumerator.Current { get => default; } // 0x000000018B77B150-0x000000018B77B184 
	
			// Constructors
			public _Initiate_d__8() {} // Dummy constructor
			public _Initiate_d__8(int __1__state) {} // 0x000000018B77B584-0x000000018B77B648
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B77B468-0x000000018B77B528
			private bool MoveNext() => default; // 0x000000018B77B648-0x000000018B77B770
			void IEnumerator.Reset() {} // 0x000000018B77AF78-0x000000018B77B150
		}
	
		// Constructors
		protected OffsetModifier() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected abstract void OnModifyOffset(); // 0x0000000185492010-0x0000000185492020
		protected virtual void Start() {} // 0x0000000181378230-0x0000000181378240
		private IEnumerator Initiate() => default; // 0x0000000185492010-0x0000000185492020
		private void ModifyOffset() {} // 0x000000018B77D97C-0x000000018B77DAE8
		protected void ApplyLimits(OffsetLimits[] limits) {} // 0x0000000181377E40-0x0000000181377E50
		protected virtual void OnDestroy() {} // 0x000000018B77DAE8-0x000000018B77DB34
	}

	public abstract class OffsetModifierVRIK : MonoBehaviour // TypeDefIndex: 53790
	{
		// Fields
		public float weight; // 0x18
		public VRIK ik; // 0x20
		private float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x0000000189CBA364-0x0000000189CBA374 
	
		// Nested types
		private sealed class _Initiate_d__7 : IEnumerator<object> // TypeDefIndex: 53789
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public OffsetModifierVRIK __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018B77B1E0-0x000000018B77B23C 
			object IEnumerator.Current { get => default; } // 0x000000018B77B300-0x000000018B77B428 
	
			// Constructors
			public _Initiate_d__7() {} // Dummy constructor
			public _Initiate_d__7(int __1__state) {} // 0x000000018B77B44C-0x000000018B77B468
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default; // 0x000000018B77B428-0x000000018B77B44C
			void IEnumerator.Reset() {} // 0x000000018B77B23C-0x000000018B77B300
		}
	
		// Constructors
		protected OffsetModifierVRIK() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected abstract void OnModifyOffset(); // 0x0000000181378230-0x0000000181378240
		protected virtual void Start() {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator Initiate() => default; // 0x000000018B77D7C4-0x000000018B77D930
		private void ModifyOffset() {} // 0x0000000181377E40-0x0000000181377E50
		protected virtual void OnDestroy() {} // 0x000000018B77D930-0x000000018B77D97C
	}

	public class OffsetPose : MonoBehaviour // TypeDefIndex: 53792
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x18
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 53791
		{
			// Fields
			public FullBodyBipedEffector effector; // 0x10
			public Vector3 offset; // 0x14
			public Vector3 pin; // 0x20
			public Vector3 pinWeight; // 0x2C
	
			// Constructors
			public EffectorLink() {} // 0x000000018B77B840-0x000000018B77B8D0
	
			// Methods
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation) {} // 0x000000018B77B794-0x000000018B77B840
		}
	
		// Constructors
		public OffsetPose() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Apply(IKSolverFullBodyBiped solver, float weight) {} // 0x000000018B77B8D0-0x000000018B77B920
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation) {} // 0x000000018B77ACB0-0x000000018B77AF78
	}

	public class PenetrationAvoidance : OffsetModifier // TypeDefIndex: 53795
	{
		// Fields
		public Avoider[] avoiders; // 0x30
	
		// Nested types
		[Serializable]
		public class Avoider // TypeDefIndex: 53794
		{
			// Fields
			public Transform[] raycastFrom; // 0x10
			public Transform raycastTo; // 0x18
			public float raycastRadius; // 0x20
			public EffectorLink[] effectors; // 0x28
			public float smoothTimeIn; // 0x30
			public float smoothTimeOut; // 0x34
			public LayerMask layers; // 0x38
			private Vector3 offset; // 0x3C
			private Vector3 offsetTarget; // 0x48
			private Vector3 offsetV; // 0x54
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 53793
			{
				// Fields
				public FullBodyBipedEffector effector; // 0x10
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink() {} // 0x000000018B77B920-0x000000018B77B98C
			}
	
			// Constructors
			public Avoider() {} // 0x000000018B77A8C4-0x000000018B77AAEC
	
			// Methods
			public void Solve(IKSolverFullBodyBiped solver, float weight) {} // 0x0000000189CBA364-0x0000000189CBA374
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver) => default; // 0x000000018B77AAEC-0x000000018B77ACB0
			private Vector3 Raycast(Vector3 from, Vector3 to) => default; // 0x000000018B77A744-0x000000018B77A8C4
		}
	
		// Constructors
		public PenetrationAvoidance() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void OnModifyOffset() {} // 0x0000000185FD5A80-0x0000000185FD5A90
	}

	public class Recoil : OffsetModifier // TypeDefIndex: 53799
	{
		// Fields
		public AimIK aimIK; // 0x30
		public AimIK headIK; // 0x38
		public bool aimIKSolvedLast; // 0x40
		public Handedness handedness; // 0x44
		public bool twoHanded; // 0x48
		public AnimationCurve recoilWeight; // 0x50
		public float magnitudeRandom; // 0x58
		public Vector3 rotationRandom; // 0x5C
		public Vector3 handRotationOffset; // 0x68
		public float blendTime; // 0x74
		public RecoilOffset[] offsets; // 0x78
		public Quaternion rotationOffset; // 0x80
		private float magnitudeMlp; // 0x90
		private float endTime; // 0x94
		private Quaternion handRotation; // 0x98
		private Quaternion secondaryHandRelativeRotation; // 0xA8
		private Quaternion randomRotation; // 0xB8
		private float length; // 0xC8
		private bool initiated; // 0xCC
		private float blendWeight; // 0xD0
		private float w; // 0xD4
		private Quaternion primaryHandRotation; // 0xD8
		private bool handRotationsSet; // 0xE8
		private Vector3 aimIKAxis; // 0xEC
	
		// Properties
		public bool isFinished { get => default; } // 0x000000018B77BCC4-0x000000018B77BE0C 
		private IKEffector primaryHandEffector { get => default; } // 0x000000018B77BF58-0x000000018B77C16C 
		private IKEffector secondaryHandEffector { get => default; } // 0x000000018B77CCD8-0x000000018B77CD44 
		private Transform primaryHand { get => default; } // 0x000000018B77BBA0-0x000000018B77BC14 
		private Transform secondaryHand { get => default; } // 0x000000018B77B98C-0x000000018B77BBA0 
	
		// Nested types
		[Serializable]
		public class RecoilOffset // TypeDefIndex: 53797
		{
			// Fields
			public Vector3 offset; // 0x10
			public float additivity; // 0x1C
			public float maxAdditiveOffsetMag; // 0x20
			public EffectorLink[] effectorLinks; // 0x28
			private Vector3 additiveOffset; // 0x30
			private Vector3 lastOffset; // 0x3C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 53796
			{
				// Fields
				public FullBodyBipedEffector effector; // 0x10
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink() {} // 0x000000018B77CD44-0x000000018B77CD64
			}
	
			// Constructors
			public RecoilOffset() {} // 0x000000018B77C16C-0x000000018B77CCB8
	
			// Methods
			public void Start() {} // 0x000000018B77CCB8-0x000000018B77CCD8
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft) {} // 0x000000018B77BE0C-0x000000018B77BF58
		}
	
		[Serializable]
		public enum Handedness // TypeDefIndex: 53798
		{
			Right = 0,
			Left = 1
		}
	
		// Constructors
		public Recoil() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation) {} // 0x000000018B77BC14-0x000000018B77BCC4
		public void Fire(float magnitude) {} // 0x000000018B77CD64-0x000000018B77CDAC
		protected override void OnModifyOffset() {} // 0x000000018B77CDCC-0x000000018B77CE14
		private void AfterFBBIK() {} // 0x000000018B77CDAC-0x000000018B77CDCC
		private void AfterAimIK() {} // 0x000000018B77CE14-0x000000018B77CE34
		protected override void OnDestroy() {} // 0x0000000185FD5A90-0x0000000185FD5AA0
	}

	public class ShoulderRotator : MonoBehaviour // TypeDefIndex: 53800
	{
		// Fields
		public float weight; // 0x18
		public float offset; // 0x1C
		private FullBodyBipedIK ik; // 0x20
		private bool skip; // 0x28
	
		// Constructors
		public ShoulderRotator() {} // 0x000000018B77D6A8-0x000000018B77D6C0
	
		// Methods
		private void Start() {} // 0x000000018B77D58C-0x000000018B77D6A8
		private void RotateShoulders() {} // 0x000000018B77D4B4-0x000000018B77D58C
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset) {} // 0x000000018B77D060-0x000000018B77D4B4
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain) => default; // 0x000000018B77CEFC-0x000000018B77CF38
		private void OnDestroy() {} // 0x000000018B77CF38-0x000000018B77D060
	}

	public static class VRIKCalibrator // TypeDefIndex: 53804
	{
		// Nested types
		[Serializable]
		public class Settings // TypeDefIndex: 53801
		{
			// Fields
			public float scaleMlp; // 0x10
			public Vector3 headTrackerForward; // 0x14
			public Vector3 headTrackerUp; // 0x20
			public Vector3 handTrackerForward; // 0x2C
			public Vector3 handTrackerUp; // 0x38
			public Vector3 footTrackerForward; // 0x44
			public Vector3 footTrackerUp; // 0x50
			public Vector3 headOffset; // 0x5C
			public Vector3 handOffset; // 0x68
			public float footForwardOffset; // 0x74
			public float footInwardOffset; // 0x78
			public float footHeadingOffset; // 0x7C
			public float pelvisPositionWeight; // 0x80
			public float pelvisRotationWeight; // 0x84
	
			// Constructors
			public Settings() {} // 0x000000018B78218C-0x000000018B7821B0
		}
	
		[Serializable]
		public class CalibrationData // TypeDefIndex: 53803
		{
			// Fields
			public float scale; // 0x10
			public Target head; // 0x18
			public Target leftHand; // 0x20
			public Target rightHand; // 0x28
			public Target pelvis; // 0x30
			public Target leftFoot; // 0x38
			public Target rightFoot; // 0x40
			public Target leftLegGoal; // 0x48
			public Target rightLegGoal; // 0x50
			public Vector3 pelvisTargetRight; // 0x58
			public float pelvisPositionWeight; // 0x64
			public float pelvisRotationWeight; // 0x68
	
			// Nested types
			[Serializable]
			public class Target // TypeDefIndex: 53802
			{
				// Fields
				public bool used; // 0x10
				public Vector3 localPosition; // 0x14
				public Quaternion localRotation; // 0x20
	
				// Constructors
				public Target() {} // Dummy constructor
				public Target(Transform t) {} // 0x000000018B78212C-0x000000018B78218C
	
				// Methods
				public void SetTo(Transform t) {} // 0x000000018B77F45C-0x000000018B77F47C
			}
	
			// Constructors
			public CalibrationData() {} // 0x000000018B77F47C-0x000000018B77F608
		}
	
		// Methods
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings) {} // 0x000000018B780180-0x000000018B781970
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp) {} // 0x000000018B77ED1C-0x000000018B77F45C
		private static void CalibrateScale(VRIK ik, Settings settings) {} // 0x000000018B77F608-0x000000018B780180
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f /* Metadata: 0x0207836B */) {} // 0x000000018B77EACC-0x000000018B77ED1C
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null) => default; // 0x000000018B781970-0x000000018B781BBC
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft) {} // 0x000000018B77E53C-0x000000018B77EACC
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null) {} // 0x000000018B77DB34-0x000000018B77DE30
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft) {} // 0x000000018B77E2EC-0x000000018B77E53C
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f /* Metadata: 0x0207836F */) => default; // 0x000000018B77DE30-0x000000018B77E2EC
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset) {} // 0x000000018B781FB0-0x000000018B78212C
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset) {} // 0x000000018B781BBC-0x000000018B781FB0
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset) {} // 0x000000018B77CE34-0x000000018B77CEFC
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft) {} // 0x0000000185492010-0x0000000185492020
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm) => default; // 0x000000018B77D728-0x000000018B77D7C4
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm) => default; // 0x000000018B77D6C0-0x000000018B77D728
	}

	public class VRIKLODController : MonoBehaviour // TypeDefIndex: 53805
	{
		// Fields
		public Renderer LODRenderer; // 0x18
		public float LODDistance; // 0x20
		public bool allowCulled; // 0x24
		private VRIK ik; // 0x28
	
		// Constructors
		public VRIKLODController() {} // 0x000000018B782388-0x000000018B78239C
	
		// Methods
		private void Start() {} // 0x000000018B78230C-0x000000018B782354
		private void Update() {} // 0x000000018B782354-0x000000018B782388
		private int GetLODLevel() => default; // 0x000000018B7821B0-0x000000018B78230C
	}

	public class VRIKRootController : MonoBehaviour // TypeDefIndex: 53806
	{
		// Fields
		private Vector3 _pelvisTargetRight_k__BackingField; // 0x18
		private Transform pelvisTarget; // 0x28
		private Transform leftFootTarget; // 0x30
		private Transform rightFootTarget; // 0x38
		private VRIK ik; // 0x40
	
		// Properties
		public Vector3 pelvisTargetRight { get; private set; } // 0x0000000185FB3830-0x0000000185FB3850 0x0000000185FB3850-0x0000000185FB3860
	
		// Constructors
		public VRIKRootController() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Awake() {} // 0x000000018B78239C-0x000000018B7824C8
		public void Calibrate() {} // 0x000000018B7824C8-0x000000018B7826EC
		public void Calibrate(VRIKCalibrator.CalibrationData data) {} // 0x000000018B7826EC-0x000000018B782874
		private void OnPreUpdate() {} // 0x000000018B78299C-0x000000018B782EA8
		private void OnDestroy() {} // 0x000000018B782874-0x000000018B78299C
	}
}
