/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Serialization;

// Image 27: RootMotion.dll - Assembly: RootMotion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 52597-52822
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace RootMotion
{
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour // TypeDefIndex: 52604
	{
		// Fields
		[Range(1f, 90f)]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		public int frameRate; // 0x18
		[Range(0f, 0.1f)]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		public float keyReductionError; // 0x1C
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode; // 0x20
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips; // 0x28
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select \'Find Animation States\' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates; // 0x30
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder; // 0x38
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were \'Idle\' and \'Walk\', then with \'_Baked\' as Append Name, the Baker will create \'Idle_Baked\' and \'Walk_Baked\' animation clips.")]
		public string appendName; // 0x40
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName; // 0x48
		[HideInInspector]
		public Animator animator; // 0x58
		[HideInInspector]
		public PlayableDirector director; // 0x60
		public BakerDelegate OnStartClip; // 0x68
		public BakerDelegate OnUpdateClip; // 0x70
		[Tooltip("If enabled, baked clips will have the same AnimationClipSettings as the clips used for baking. If disabled, clip settings from below will be applied to all the baked clips.")]
		public bool inheritClipSettings; // 0x78
		[Tooltip("AnimationClipSettings applied to the baked animation clip.")]
		public ClipSettings clipSettings; // 0x80
		protected bool addLoopFrame; // 0x8C
	
		// Properties
		public bool isBaking { get; private set; } // 0x0000000183D4F000-0x0000000183D4F010 0x0000000183D4F030-0x0000000183D4F040
		public float bakingProgress { get; private set; } // 0x0000000183D4F670-0x0000000183D4F680 0x0000000183D4F680-0x0000000183D4F690
		protected float clipLength { get; private set; } // 0x0000000183D56E70-0x0000000183D56E80 0x0000000183D56E90-0x0000000183D56EA0
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 52598
		{
			AnimationClips = 0,
			AnimationStates = 1,
			PlayableDirector = 2,
			Realtime = 3
		}
	
		public delegate void BakerDelegate(AnimationClip clip, float time); // TypeDefIndex: 52599; 0x0000000182065C10-0x0000000182065C20
	
		[Serializable]
		public class ClipSettings // TypeDefIndex: 52603
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
			public enum BasedUponRotation // TypeDefIndex: 52600
			{
				Original = 0,
				BodyOrientation = 1
			}
	
			[Serializable]
			public enum BasedUponY // TypeDefIndex: 52601
			{
				Original = 0,
				CenterOfMass = 1,
				Feet = 2
			}
	
			[Serializable]
			public enum BasedUponXZ // TypeDefIndex: 52602
			{
				Original = 0,
				CenterOfMass = 1
			}
	
			// Constructors
			public ClipSettings() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		protected Baker() {} // 0x00000001895F8C20-0x00000001895F8D04
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual() {} // 0x00000001895F8BB8-0x00000001895F8BEC
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference() {} // 0x00000001895F8B84-0x00000001895F8BB8
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x00000001895F8BEC-0x00000001895F8C20
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x00000001895F8B50-0x00000001895F8B84
		protected abstract Transform GetCharacterRoot();
		protected abstract void OnStartBaking();
		protected abstract void OnSetLoopFrame(float time);
		protected abstract void OnSetCurves(ref AnimationClip clip);
		protected abstract void OnSetKeyframes(float time, bool lastFrame);
		public void BakeClip() {} // 0x000000018350B670-0x000000018350B680
		public void StartBaking() {} // 0x000000018350B670-0x000000018350B680
		public void StopBaking() {} // 0x000000018350B670-0x000000018350B680
	}

	public class GenericBaker : Baker // TypeDefIndex: 52605
	{
		// Fields
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy; // 0x90
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root; // 0x98
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode; // 0xA0
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList; // 0xA8
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList; // 0xB0
		private BakerTransform[] children; // 0xB8
		private BakerTransform rootChild; // 0xC0
		private int rootChildIndex; // 0xC8
	
		// Constructors
		public GenericBaker() {} // 0x00000001895FF810-0x00000001895FF86C
	
		// Methods
		private void Awake() {} // 0x00000001895FF27C-0x00000001895FF4A4
		protected override Transform GetCharacterRoot() => default; // 0x00000001811AC510-0x00000001811AC520
		protected override void OnStartBaking() {} // 0x00000001895FF71C-0x00000001895FF810
		protected override void OnSetLoopFrame(float time) {} // 0x00000001895FF6B4-0x00000001895FF71C
		protected override void OnSetCurves(ref AnimationClip clip) {} // 0x00000001895FF5E4-0x00000001895FF64C
		protected override void OnSetKeyframes(float time, bool lastFrame) {} // 0x00000001895FF64C-0x00000001895FF6B4
		private bool IsIgnored(Transform t) => default; // 0x00000001895FF544-0x00000001895FF5E4
		private bool BakePosition(Transform t) => default; // 0x00000001895FF4A4-0x00000001895FF544
	}

	public class TQ // TypeDefIndex: 52606
	{
		// Fields
		public Vector3 t; // 0x10
		public Quaternion q; // 0x1C
	
		// Constructors
		public TQ() {} // 0x000000018350B670-0x000000018350B680
		public TQ(Vector3 translation, Quaternion rotation) {} // 0x0000000183D74890-0x0000000183D748B0
	}

	public class AvatarUtility // TypeDefIndex: 52607
	{
		// Constructors
		public AvatarUtility() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal) => default; // 0x00000001895F4F44-0x00000001895F5140
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ) => default; // 0x00000001895F4984-0x00000001895F4F44
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal) => default; // 0x00000001895F52C4-0x00000001895F5710
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale) => default; // 0x00000001895F5140-0x00000001895F5290
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal) => default; // 0x00000001895F5290-0x00000001895F52C4
	}

	public static class BakerUtilities // TypeDefIndex: 52608
	{
		// Methods
		public static void ReduceKeyframes(AnimationCurve curve, float maxError) {} // 0x00000001895F89C0-0x00000001895F8A00
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError) => default; // 0x00000001895F8690-0x00000001895F89C0
		public static void SetLoopFrame(float time, AnimationCurve curve) {} // 0x00000001895F8A00-0x00000001895F8B50
		public static void SetTangentMode(AnimationCurve curve) {} // 0x000000018350B670-0x000000018350B680
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q) => default; // 0x00000001895F84F8-0x00000001895F8690
	}

	[Serializable]
	public class BakerHumanoidQT // TypeDefIndex: 52609
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
		public BakerHumanoidQT(string name) {} // 0x00000001895F6A6C-0x00000001895F6BD0
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name) {} // 0x00000001895F6BD0-0x00000001895F6D60
	
		// Methods
		public Quaternion EvaluateRotation(float time) => default; // 0x00000001895F5D94-0x00000001895F5E5C
		public Vector3 EvaluatePosition(float time) => default; // 0x00000001895F5CF8-0x00000001895F5D94
		public TQ Evaluate(float time) => default; // 0x00000001895F5E5C-0x00000001895F5EFC
		public void GetCurvesFromClip(AnimationClip clip, Animator animator) {} // 0x000000018350B670-0x000000018350B680
		public void Reset() {} // 0x00000001895F6074-0x00000001895F6214
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation) {} // 0x00000001895F65B0-0x00000001895F68F0
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot) {} // 0x00000001895F68F0-0x00000001895F69E4
		public void MoveLastKeyframes(float time) {} // 0x00000001895F5F60-0x00000001895F5FF8
		public void SetLoopFrame(float time) {} // 0x00000001895F69E4-0x00000001895F6A6C
		public void SetRootLoopFrame(float time) {} // 0x000000018350B670-0x000000018350B680
		private void MoveLastKeyframe(float time, AnimationCurve curve) {} // 0x00000001895F5EFC-0x00000001895F5F60
		public void MultiplyLength(AnimationCurve curve, float mlp) {} // 0x00000001895F5FF8-0x00000001895F6074
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp) {} // 0x00000001895F6214-0x00000001895F65B0
	}

	[Serializable]
	public class BakerMuscle // TypeDefIndex: 52610
	{
		// Fields
		public AnimationCurve curve; // 0x10
		private int muscleIndex; // 0x18
		private string propertyName; // 0x20
	
		// Constructors
		public BakerMuscle() {} // Dummy constructor
		public BakerMuscle(int muscleIndex) {} // 0x00000001895F78AC-0x00000001895F7910
	
		// Methods
		private string MuscleNameToPropertyName(string n) => default; // 0x00000001895F6D60-0x00000001895F76FC
		public void MultiplyLength(AnimationCurve curve, float mlp) {} // 0x00000001895F5FF8-0x00000001895F6074
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp) {} // 0x00000001895F7760-0x00000001895F785C
		public void Reset() {} // 0x00000001895F76FC-0x00000001895F7760
		public void SetKeyframe(float time, float[] muscles) {} // 0x00000001895F785C-0x00000001895F789C
		public void SetLoopFrame(float time) {} // 0x00000001895F789C-0x00000001895F78AC
	}

	[Serializable]
	public class BakerTransform // TypeDefIndex: 52611
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
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode) {} // 0x00000001895F8470-0x00000001895F84F8
	
		// Methods
		public void SetRelativeSpace(Vector3 position, Quaternion rotation) {} // 0x0000000183D74310-0x0000000183D74330
		public void SetCurves(ref AnimationClip clip) {} // 0x00000001895F7F94-0x00000001895F8264
		private void AddRootMotionCurves(ref AnimationClip clip) {} // 0x00000001895F7AEC-0x00000001895F7D98
		public void Reset() {} // 0x00000001895F7E1C-0x00000001895F7F94
		public void ReduceKeyframes(float maxError) {} // 0x00000001895F7D98-0x00000001895F7E1C
		public void SetKeyframes(float time) {} // 0x00000001895F8264-0x00000001895F8470
		public void AddLoopFrame(float time) {} // 0x00000001895F7910-0x00000001895F7AEC
	}

	public class HumanoidBaker : Baker // TypeDefIndex: 52612
	{
		// Fields
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK; // 0x90
		[Range(0f, 0.1f)]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for \'Key Reduction Error\' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling \'Foot IK\' in the Animator.")]
		public float IKKeyReductionError; // 0x94
		[Range(1f, 9f)]
		[Tooltip("Frame rate divider for the muscle curves. If you have \'Frame Rate\' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling \'Foot IK\' in the Animator.")]
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
		public HumanoidBaker() {} // 0x0000000189600F40-0x0000000189600FD4
	
		// Methods
		private void Awake() {} // 0x00000001896001B4-0x00000001896006B0
		protected override Transform GetCharacterRoot() => default; // 0x00000001896006B0-0x00000001896006D0
		protected override void OnStartBaking() {} // 0x0000000189600D70-0x0000000189600E54
		protected override void OnSetLoopFrame(float time) {} // 0x0000000189600C90-0x0000000189600D70
		protected override void OnSetCurves(ref AnimationClip clip) {} // 0x00000001896006D0-0x00000001896008DC
		protected override void OnSetKeyframes(float time, bool lastFrame) {} // 0x00000001896008DC-0x0000000189600C90
		private void UpdateHumanPose() {} // 0x0000000189600E54-0x0000000189600F40
	}

	[Serializable]
	public enum Axis // TypeDefIndex: 52613
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public class AxisTools // TypeDefIndex: 52614
	{
		// Constructors
		public AxisTools() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Vector3 ToVector3(RootMotion.Axis axis) => default; // 0x00000001895F5C38-0x00000001895F5C78
		public static RootMotion.Axis ToAxis(Vector3 v) => default; // 0x00000001895F5BF8-0x00000001895F5C38
		public static RootMotion.Axis GetAxisToPoint(Transform t, Vector3 worldPosition) => default; // 0x00000001895F57FC-0x00000001895F58E8
		public static RootMotion.Axis GetAxisToDirection(Transform t, Vector3 direction) => default; // 0x00000001895F5710-0x00000001895F57FC
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition) => default; // 0x00000001895F5B48-0x00000001895F5BF8
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction) => default; // 0x00000001895F58E8-0x00000001895F5954
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction) => default; // 0x00000001895F5954-0x00000001895F5B48
	}

	[Serializable]
	public class BipedLimbOrientations // TypeDefIndex: 52616
	{
		// Fields
		public LimbOrientation leftArm; // 0x10
		public LimbOrientation rightArm; // 0x18
		public LimbOrientation leftLeg; // 0x20
		public LimbOrientation rightLeg; // 0x28
	
		// Properties
		public static BipedLimbOrientations UMA { get => default; } // 0x00000001895F96EC-0x00000001895F997C 
		public static BipedLimbOrientations MaxBiped { get => default; } // 0x00000001895F945C-0x00000001895F96EC 
	
		// Nested types
		[Serializable]
		public class LimbOrientation // TypeDefIndex: 52615
		{
			// Fields
			public Vector3 upperBoneForwardAxis; // 0x10
			public Vector3 lowerBoneForwardAxis; // 0x1C
			public Vector3 lastBoneLeftAxis; // 0x28
	
			// Constructors
			public LimbOrientation() {} // Dummy constructor
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis) {} // 0x0000000183D587B0-0x0000000183D587F0
		}
	
		// Constructors
		public BipedLimbOrientations() {} // Dummy constructor
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg) {} // 0x0000000182F73D30-0x0000000182F73D80
	}

	public static class BipedNaming // TypeDefIndex: 52619
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
		public enum BoneType // TypeDefIndex: 52617
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
		public enum BoneSide // TypeDefIndex: 52618
		{
			Center = 0,
			Left = 1,
			Right = 2
		}
	
		// Constructors
		static BipedNaming() {} // 0x00000001895F9FFC-0x00000001895FB274
	
		// Methods
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones) => default; // 0x00000001895F9D10-0x00000001895F9E60
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones) => default; // 0x00000001895F9B58-0x00000001895F9CA8
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones) => default; // 0x00000001895F9CA8-0x00000001895F9D10
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones) => default; // 0x00000001895F9E60-0x00000001895F9EE4
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings) => default; // 0x00000001895F9EE4-0x00000001895F9FC4
		public static BoneType GetBoneType(string boneName) => default; // 0x00000001895F99E8-0x00000001895F9AE0
		public static BoneSide GetBoneSide(string boneName) => default; // 0x00000001895F997C-0x00000001895F99E8
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center /* Metadata: 0x01FD2ACE */, params string[][] namings) => default; // 0x00000001895F9AE0-0x00000001895F9B58
		private static bool isLeft(string boneName) => default; // 0x00000001895FB4D0-0x00000001895FB590
		private static bool isRight(string boneName) => default; // 0x00000001895FB618-0x00000001895FB6D8
		private static bool isSpine(string boneName) => default; // 0x00000001895FB6D8-0x00000001895FB760
		private static bool isHead(string boneName) => default; // 0x00000001895FB448-0x00000001895FB4D0
		private static bool isArm(string boneName) => default; // 0x00000001895FB338-0x00000001895FB3C0
		private static bool isLeg(string boneName) => default; // 0x00000001895FB590-0x00000001895FB618
		private static bool isTail(string boneName) => default; // 0x00000001895FB760-0x00000001895FB7E8
		private static bool isEye(string boneName) => default; // 0x00000001895FB3C0-0x00000001895FB448
		private static bool isTypeExclude(string boneName) => default; // 0x00000001895FB7E8-0x00000001895FB83C
		private static bool matchesNaming(string boneName, string[] namingConvention) => default; // 0x00000001895FB930-0x00000001895FB9E0
		private static bool excludesNaming(string boneName, string[] namingConvention) => default; // 0x00000001895FB274-0x00000001895FB2DC
		private static bool matchesLastLetter(string boneName, string[] namingConvention) => default; // 0x00000001895FB898-0x00000001895FB930
		private static bool LastLetterIs(string boneName, string letter) => default; // 0x00000001895F9FC4-0x00000001895F9FFC
		private static string firstLetter(string boneName) => default; // 0x00000001895FB2DC-0x00000001895FB338
		private static string lastLetter(string boneName) => default; // 0x00000001895FB83C-0x00000001895FB898
	}

	[Serializable]
	public class BipedReferences // TypeDefIndex: 52621
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
		public virtual bool isFilled { get => default; } // 0x00000001829EC8B0-0x00000001829ECCA0 
		public bool isEmpty { get => default; } // 0x00000001895FDB14-0x00000001895FDB20 
	
		// Nested types
		public struct AutoDetectParams // TypeDefIndex: 52620
		{
			// Fields
			public bool legsParentInSpine; // 0x00
			public bool includeEyes; // 0x01
	
			// Properties
			public static AutoDetectParams Default { get => default; } // 0x0000000183D74300-0x0000000183D74310 
	
			// Constructors
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes) : this() {
				this.legsParentInSpine = default;
				this.includeEyes = default;
			} // 0x0000000183D67530-0x0000000183D67540
		}
	
		// Constructors
		public BipedReferences() {} // 0x00000001829ED130-0x00000001829ED1A0
	
		// Methods
		public virtual bool IsEmpty(bool includeRoot) => default; // 0x00000001895FD1F4-0x00000001895FD500
		public virtual bool Contains(Transform t, bool ignoreRoot = false /* Metadata: 0x01FD2AD9 */) => default; // 0x00000001895FC350-0x00000001895FC67C
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams) => default; // 0x00000001895FC158-0x00000001895FC350
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams) {} // 0x00000001895FC79C-0x00000001895FCF30
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams) {} // 0x00000001895FBCB8-0x00000001895FC158
		public static bool SetupError(BipedReferences references, ref string errorMessage) => default; // 0x00000001829ECCA0-0x00000001829ECDC0
		public static bool SetupWarning(BipedReferences references, ref string warningMessage) => default; // 0x00000001895FDA48-0x00000001895FDB14
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm) => default; // 0x00000001895FD500-0x00000001895FD5BC
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams) => default; // 0x00000001895FB9E0-0x00000001895FBABC
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams) => default; // 0x00000001895FBB70-0x00000001895FBCB8
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) {} // 0x00000001895FC67C-0x00000001895FC79C
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) {} // 0x00000001895FBABC-0x00000001895FBB70
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) => default; // 0x00000001829F0320-0x00000001829F0700
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) => default; // 0x00000001895FD5BC-0x00000001895FD850
		private static bool SpineError(BipedReferences references, ref string errorMessage) => default; // 0x00000001829ED9D0-0x00000001829EDD00
		private static bool SpineWarning(BipedReferences references, ref string warningMessage) => default; // 0x000000018115F4C0-0x000000018115F530
		private static bool EyesError(BipedReferences references, ref string errorMessage) => default; // 0x00000001829ECDC0-0x00000001829ECE70
		private static bool EyesWarning(BipedReferences references, ref string warningMessage) => default; // 0x000000018115F4C0-0x000000018115F530
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) => default; // 0x00000001895FD850-0x00000001895FDA48
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) => default; // 0x00000001895FCF30-0x00000001895FD14C
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) => default; // 0x00000001895FD14C-0x00000001895FD1F4
	}

	public class Comments : MonoBehaviour // TypeDefIndex: 52622
	{
		// Fields
		[Multiline]
		public string text; // 0x18
	
		// Constructors
		public Comments() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public class DemoGUIMessage : MonoBehaviour // TypeDefIndex: 52623
	{
		// Fields
		public string text; // 0x18
		public UnityEngine.Color color; // 0x20
	
		// Constructors
		public DemoGUIMessage() {} // 0x00000001895FE150-0x00000001895FE178
	
		// Methods
		private void OnGUI() {} // 0x00000001895FE0AC-0x00000001895FE150
	}

	public class Hierarchy // TypeDefIndex: 52624
	{
		// Constructors
		public Hierarchy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static bool HierarchyIsValid(Transform[] bones) => default; // 0x00000001829EF630-0x00000001829EF6A0
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects) => default; // 0x00000001829EFEA0-0x00000001829EFF80
		public static bool IsAncestor(Transform transform, Transform ancestor) => default; // 0x00000001829EF6A0-0x00000001829EF7E0
		public static bool ContainsChild(Transform transform, Transform child) => default; // 0x00000001895FFAC8-0x00000001895FFBA0
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array) {} // 0x00000001895FF86C-0x00000001895FFAC8
		public static Transform GetAncestor(Transform transform, int minChildCount) => default; // 0x00000001895FFBA0-0x00000001895FFC74
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2) => default; // 0x00000001895FFDC4-0x00000001895FFEF0
		public static Transform GetFirstCommonAncestor(Transform[] transforms) => default; // 0x00000001895FFEF0-0x0000000189600010
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms) => default; // 0x00000001895FFC74-0x00000001895FFDC4
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms) => default; // 0x0000000189600010-0x00000001896001B4
	}

	public class InspectorComment : PropertyAttribute // TypeDefIndex: 52625
	{
		// Fields
		public string name; // 0x10
		public string color; // 0x18
	
		// Constructors
		public InspectorComment() {} // Dummy constructor
		public InspectorComment(string name) {} // 0x0000000189601048-0x00000001896010B4
		public InspectorComment(string name, string color) {} // 0x0000000189600FD4-0x0000000189601048
	}

	[Serializable]
	public enum InterpolationMode // TypeDefIndex: 52626
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

	public class Interp // TypeDefIndex: 52627
	{
		// Constructors
		public Interp() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static float Float(float t, RootMotion.InterpolationMode mode) => default; // 0x00000001896010B4-0x0000000189601404
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, RootMotion.InterpolationMode mode) => default; // 0x00000001896016C4-0x0000000189601794
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed) => default; // 0x000000018281C190-0x000000018281C240
		private static float None(float t, float b, float c) => default; // 0x0000000183D74560-0x0000000183D74570
		private static float InOutCubic(float t, float b, float c) => default; // 0x0000000183D74490-0x0000000183D744C0
		private static float InOutQuintic(float t, float b, float c) => default; // 0x0000000183D744C0-0x0000000183D74510
		private static float InQuintic(float t, float b, float c) => default; // 0x0000000183D74540-0x0000000183D74560
		private static float InQuartic(float t, float b, float c) => default; // 0x0000000183D74520-0x0000000183D74540
		private static float InCubic(float t, float b, float c) => default; // 0x0000000183D743B0-0x0000000183D743D0
		private static float InQuadratic(float t, float b, float c) => default; // 0x0000000183D74510-0x0000000183D74520
		private static float OutQuintic(float t, float b, float c) => default; // 0x0000000183D74820-0x0000000183D74890
		private static float OutQuartic(float t, float b, float c) => default; // 0x0000000183D747C0-0x0000000183D74820
		private static float OutCubic(float t, float b, float c) => default; // 0x0000000183D74600-0x0000000183D74640
		private static float OutInCubic(float t, float b, float c) => default; // 0x0000000183D74740-0x0000000183D74780
		private static float OutInQuartic(float t, float b, float c) => default; // 0x0000000183D74780-0x0000000183D747C0
		private static float BackInCubic(float t, float b, float c) => default; // 0x0000000183D74340-0x0000000183D74370
		private static float BackInQuartic(float t, float b, float c) => default; // 0x0000000183D74370-0x0000000183D743B0
		private static float OutBackCubic(float t, float b, float c) => default; // 0x0000000183D74570-0x0000000183D745B0
		private static float OutBackQuartic(float t, float b, float c) => default; // 0x0000000183D745B0-0x0000000183D74600
		private static float OutElasticSmall(float t, float b, float c) => default; // 0x0000000183D746C0-0x0000000183D74740
		private static float OutElasticBig(float t, float b, float c) => default; // 0x0000000183D74640-0x0000000183D746C0
		private static float InElasticSmall(float t, float b, float c) => default; // 0x0000000183D74430-0x0000000183D74490
		private static float InElasticBig(float t, float b, float c) => default; // 0x0000000183D743D0-0x0000000183D74430
		private static float InSine(float t, float b, float c) => default; // 0x0000000189601548-0x0000000189601594
		private static float OutSine(float t, float b, float c) => default; // 0x0000000189601688-0x00000001896016C4
		private static float InOutSine(float t, float b, float c) => default; // 0x00000001896014F4-0x0000000189601548
		private static float InElastic(float t, float b, float c) => default; // 0x000000018960142C-0x00000001896014F4
		private static float OutElastic(float t, float b, float c) => default; // 0x00000001896015D0-0x0000000189601688
		private static float InBack(float t, float b, float c) => default; // 0x0000000189601404-0x000000018960142C
		private static float OutBack(float t, float b, float c) => default; // 0x0000000189601594-0x00000001896015D0
	}

	public static class LayerMaskExtensions // TypeDefIndex: 52628
	{
		// Methods
		public static bool Contains(LayerMask mask, int layer) => default; // 0x0000000189601874-0x0000000189601884
		public static LayerMask Create(params string[] layerNames) => default; // 0x00000001893A97C8-0x00000001893A97D0
		public static LayerMask Create(params int[] layerNumbers) => default; // 0x00000001893A97D0-0x00000001893A97D8
		public static LayerMask NamesToMask(params string[] layerNames) => default; // 0x00000001893A97D8-0x00000001893A9834
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers) => default; // 0x00000001893A9834-0x00000001893A9874
	
		// Extension methods
		public static LayerMask Inverse(this LayerMask original) => default; // 0x0000000183D71FC0-0x0000000183D71FD0
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames) => default; // 0x00000001893A96E8-0x00000001893A9708
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames) => default; // 0x00000001893A9A18-0x00000001893A9A3C
		public static string[] MaskToNames(this LayerMask original) => default; // 0x0000000189601884-0x0000000189601960
		public static int[] MaskToNumbers(this LayerMask original) => default; // 0x0000000189601960-0x0000000189601A28
		public static string MaskToString(this LayerMask original) => default; // 0x0000000189601A28-0x0000000189601A64
		public static string MaskToString(this LayerMask original, string delimiter) => default; // 0x0000000189601A64-0x0000000189601AF0
	}

	public abstract class LazySingleton<T> : MonoBehaviour // TypeDefIndex: 52629
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

	public enum ShowIfMode // TypeDefIndex: 52630
	{
		Disabled = 0,
		Hidden = 1
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowIfAttribute : PropertyAttribute // TypeDefIndex: 52631
	{
		// Properties
		public string propName { get; protected set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public object propValue { get; protected set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public object otherPropValue { get; protected set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public bool indent { get; private set; } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		public ShowIfMode mode { get; protected set; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
	
		// Constructors
		public ShowIfAttribute() {} // Dummy constructor
		public ShowIfAttribute(string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x01FD2AF7 */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x01FD2AF8 */) {} // 0x000000018960363C-0x0000000189603684
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowRangeIfAttribute : ShowIfAttribute // TypeDefIndex: 52632
	{
		// Properties
		public float min { get; private set; } // 0x0000000183D4F5D0-0x0000000183D4F5E0 0x0000000183D4F5E0-0x0000000183D4F5F0
		public float max { get; private set; } // 0x0000000183D56CA0-0x0000000183D56CB0 0x0000000183D56CB0-0x0000000183D56CC0
	
		// Constructors
		public ShowRangeIfAttribute() {} // Dummy constructor
		public ShowRangeIfAttribute(float min, float max, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x01FD2AF9 */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x01FD2AFA */) {} // 0x00000001896037E8-0x0000000189603854
	}

	public class ShowLargeHeaderIf : ShowIfAttribute // TypeDefIndex: 52633
	{
		// Fields
		public string name; // 0x30
		public string color; // 0x38
	
		// Constructors
		public ShowLargeHeaderIf() {} // Dummy constructor
		public ShowLargeHeaderIf(string name, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x01FD2AFB */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x01FD2AFC */) {} // 0x0000000189603734-0x00000001896037E8
		public ShowLargeHeaderIf(string name, string color, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x01FD2AFD */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x01FD2AFE */) {} // 0x0000000189603684-0x0000000189603734
	}

	public class LargeHeader : PropertyAttribute // TypeDefIndex: 52634
	{
		// Fields
		public string name; // 0x10
		public string color; // 0x18
	
		// Constructors
		public LargeHeader() {} // Dummy constructor
		public LargeHeader(string name) {} // 0x0000000189601808-0x0000000189601874
		public LargeHeader(string name, string color) {} // 0x0000000189601794-0x0000000189601808
	}

	public static class QuaTools // TypeDefIndex: 52635
	{
		// Methods
		public static float GetYaw(Quaternion space, Vector3 forward) => default; // 0x0000000189602F10-0x0000000189602F88
		public static float GetPitch(Quaternion space, Vector3 forward) => default; // 0x0000000189602E90-0x0000000189602F10
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up) => default; // 0x0000000189602C2C-0x0000000189602DD4
		public static float GetYaw(Quaternion space, Quaternion rotation) => default; // 0x0000000189602F88-0x000000018960304C
		public static float GetPitch(Quaternion space, Quaternion rotation) => default; // 0x0000000189602DD4-0x0000000189602E90
		public static float GetBank(Quaternion space, Quaternion rotation) => default; // 0x0000000189602A30-0x0000000189602C2C
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight) => default; // 0x000000018960304C-0x00000001896030A8
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight) => default; // 0x00000001896034D4-0x0000000189603530
		public static Quaternion LinearBlend(Quaternion q, float weight) => default; // 0x00000001896030A8-0x0000000189603124
		public static Quaternion SphericalBlend(Quaternion q, float weight) => default; // 0x0000000189603530-0x00000001896035AC
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis) => default; // 0x00000001896026E0-0x00000001896027F4
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation) => default; // 0x0000000182B23BE0-0x0000000182B23C90
		public static Quaternion FromToRotation(Quaternion from, Quaternion to) => default; // 0x00000001896027F4-0x0000000189602898
		public static Vector3 GetAxis(Vector3 v) => default; // 0x0000000189602898-0x0000000189602A30
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing) => default; // 0x000000018960255C-0x00000001896026E0
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing) => default; // 0x0000000189602470-0x000000018960255C
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2) => default; // 0x0000000189603124-0x000000018960324C
		public static Vector3 ToBiPolar(Vector3 euler) => default; // 0x00000001896035EC-0x000000018960363C
		public static float ToBiPolar(float angle) => default; // 0x00000001896035AC-0x00000001896035EC
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space) => default; // 0x000000018960324C-0x00000001896033C4
		public static Quaternion MirrorYZ(Quaternion r) => default; // 0x00000001896033C4-0x00000001896034D4
	}

	public abstract class Singleton<T> : MonoBehaviour // TypeDefIndex: 52636
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

	public class SolverManager : MonoBehaviour // TypeDefIndex: 52637
	{
		// Fields
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms; // 0x18
		private Animator animator; // 0x20
		private Animation legacy; // 0x28
		private bool updateFrame; // 0x30
		private bool componentInitiated; // 0x31
		private bool skipSolverUpdate; // 0x32
	
		// Properties
		private bool animatePhysics { get => default; } // 0x0000000182DBA970-0x0000000182DBAAC0 
		private bool isAnimated { get => default; } // 0x0000000182C6B6E0-0x0000000182C6B770 
	
		// Constructors
		public SolverManager() {} // 0x00000001842726E8-0x00000001842726F4
	
		// Methods
		public void Disable() {} // 0x0000000189603854-0x00000001896038CC
		protected virtual void InitiateSolver() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void UpdateSolver() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void FixTransforms() {} // 0x000000018350B670-0x000000018350B680
		private void OnDisable() {} // 0x00000001896038CC-0x00000001896038F8
		private void Start() {} // 0x0000000182C6B5A0-0x0000000182C6B5B0
		public void Initiate() {} // 0x0000000182C6B5B0-0x0000000182C6B5F0
		private void Update() {} // 0x0000000182DBA780-0x0000000182DBA7C0
		private void FindAnimatorRecursive(Transform t, bool findInChildren) {} // 0x0000000182C6B5F0-0x0000000182C6B6E0
		private void FixedUpdate() {} // 0x0000000182DBA800-0x0000000182DBA970
		private void LateUpdate() {} // 0x0000000182DBA7C0-0x0000000182DBA800
		public void UpdateSolverExternal() {} // 0x00000001896038F8-0x0000000189603928
	}

	public class TriggerEventBroadcaster : MonoBehaviour // TypeDefIndex: 52638
	{
		// Fields
		public GameObject target; // 0x18
	
		// Constructors
		public TriggerEventBroadcaster() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnTriggerEnter(Collider collider) {} // 0x0000000189603928-0x00000001896039C0
		private void OnTriggerStay(Collider collider) {} // 0x0000000189603A58-0x0000000189603AF0
		private void OnTriggerExit(Collider collider) {} // 0x00000001896039C0-0x0000000189603A58
	}

	public static class V2Tools // TypeDefIndex: 52639
	{
		// Methods
		public static Vector2 XZ(Vector3 v) => default; // 0x0000000183D51590-0x0000000183D515B0
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2) => default; // 0x0000000189603B40-0x0000000189603B9C
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2) => default; // 0x0000000189603AF0-0x0000000189603B40
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r) => default; // 0x0000000189603B9C-0x0000000189603CB0
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r) => default; // 0x0000000189603CB0-0x0000000189603DD4
	}

	public static class V3Tools // TypeDefIndex: 52640
	{
		// Methods
		public static float GetYaw(Vector3 forward) => default; // 0x0000000183D748B0-0x0000000183D748D0
		public static float GetPitch(Vector3 forward) => default; // 0x0000000189604910-0x0000000189604954
		public static float GetBank(Vector3 forward, Vector3 up) => default; // 0x0000000189604850-0x0000000189604910
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward) => default; // 0x0000000189604A00-0x0000000189604AB0
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward) => default; // 0x0000000189604954-0x0000000189604A00
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up) => default; // 0x00000001896046B8-0x0000000189604850
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight) => default; // 0x0000000189604C8C-0x0000000189604D04
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight) => default; // 0x0000000189604EC0-0x0000000189604F40
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight) => default; // 0x0000000189604488-0x00000001896045B4
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight) => default; // 0x0000000189604344-0x0000000189604488
		public static Vector3 Flatten(Vector3 v, Vector3 normal) => default; // 0x00000001896045B4-0x00000001896046B8
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing) => default; // 0x0000000189604184-0x0000000189604344
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed) {
			changed = default;
			return default;
		} // 0x0000000189603DD4-0x0000000189603FA0
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue) {
			clampValue = default;
			return default;
		} // 0x0000000189603FA0-0x0000000189604184
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint) => default; // 0x000000018285D270-0x000000018285D3C0
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal) => default; // 0x0000000189604D04-0x0000000189604EC0
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point) => default; // 0x0000000189604F40-0x000000018960501C
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point) => default; // 0x0000000189604AB0-0x0000000189604B9C
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point) => default; // 0x0000000189604B9C-0x0000000189604C8C
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point) => default; // 0x000000018960501C-0x00000001896050E8
		public static Vector3 Div(Vector3 v1, Vector3 v2) => default; // 0x000000018950BFE0-0x000000018950C014
	}

	public static class Warning // TypeDefIndex: 52642
	{
		// Fields
		public static bool logged; // 0x00
	
		// Nested types
		public delegate void Logger(string message); // TypeDefIndex: 52641; 0x0000000182149960-0x0000000182149970
	
		// Methods
		public static void Log(string message, Logger logger, bool logInEditMode = false /* Metadata: 0x01FD2AFF */) {} // 0x0000000189605188-0x0000000189605290
		public static void Log(string message, Transform context, bool logInEditMode = false /* Metadata: 0x01FD2B00 */) {} // 0x00000001896050E8-0x0000000189605188
	}
}

namespace RootMotion.Demos
{
	[Serializable]
	public class Navigator // TypeDefIndex: 52644
	{
		// Fields
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking; // 0x10
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius; // 0x14
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance; // 0x18
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance; // 0x1C
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval; // 0x20
		private Transform transform; // 0x38
		private int cornerIndex; // 0x40
		private Vector3[] corners; // 0x48
		private NavMeshPath path; // 0x50
		private Vector3 lastTargetPosition; // 0x58
		private bool initiated; // 0x64
		private float nextPathTime; // 0x68
	
		// Properties
		public Vector3 normalizedDeltaPosition { get; private set; } // 0x0000000183D59780-0x0000000183D597A0 0x0000000183D5A9E0-0x0000000183D5A9F0
		public State state { get; private set; } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
	
		// Nested types
		public enum State // TypeDefIndex: 52643
		{
			Idle = 0,
			Seeking = 1,
			OnPath = 2
		}
	
		// Constructors
		public Navigator() {} // 0x000000018960240C-0x0000000189602470
	
		// Methods
		public void Initiate(Transform transform) {} // 0x0000000189601D64-0x0000000189601E28
		public void Update(Vector3 targetPosition) {} // 0x0000000189601E44-0x00000001896021FC
		private void CalculatePath(Vector3 targetPosition) {} // 0x0000000189601AF0-0x0000000189601B74
		private bool Find(Vector3 targetPosition) => default; // 0x0000000189601B74-0x0000000189601D38
		private void Stop() {} // 0x0000000189601E28-0x0000000189601E44
		private float HorDistance(Vector3 p1, Vector3 p2) => default; // 0x0000000189601D38-0x0000000189601D64
		public void Visualize() {} // 0x00000001896021FC-0x000000018960240C
	}
}

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	public class BipedIK : SolverManager // TypeDefIndex: 52645
	{
		// Fields
		public BipedReferences references; // 0x38
		public BipedIKSolvers solvers; // 0x40
	
		// Constructors
		public BipedIK() {} // 0x00000001829ED080-0x00000001829ED130
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual() {} // 0x00000001895F902C-0x00000001895F9060
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference() {} // 0x00000001895F8FF8-0x00000001895F902C
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x00000001895F9418-0x00000001895F944C
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x00000001895F8E5C-0x00000001895F8E90
		public float GetIKPositionWeight(AvatarIKGoal goal) => default; // 0x00000001895F8EF0-0x00000001895F8F14
		public float GetIKRotationWeight(AvatarIKGoal goal) => default; // 0x00000001895F8F64-0x00000001895F8F88
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight) {} // 0x00000001895F9060-0x00000001895F9098
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight) {} // 0x00000001895F90CC-0x00000001895F9104
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition) {} // 0x00000001895F9098-0x00000001895F90CC
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation) {} // 0x00000001895F9104-0x00000001895F9130
		public Vector3 GetIKPosition(AvatarIKGoal goal) => default; // 0x00000001895F8F14-0x00000001895F8F64
		public Quaternion GetIKRotation(AvatarIKGoal goal) => default; // 0x00000001895F8F88-0x00000001895F8FC0
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes) {} // 0x00000001895F9160-0x00000001895F91CC
		public void SetLookAtPosition(Vector3 lookAtPosition) {} // 0x00000001895F9130-0x00000001895F9160
		public void SetSpinePosition(Vector3 spinePosition) {} // 0x00000001895F91CC-0x00000001895F91FC
		public void SetSpineWeight(float weight) {} // 0x00000001895F91FC-0x00000001895F9224
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal) => default; // 0x00000001895F8E90-0x00000001895F8EF0
		public void InitiateBipedIK() {} // 0x00000001895F8FC0-0x00000001895F8FD0
		public void UpdateBipedIK() {} // 0x00000001895F944C-0x00000001895F945C
		public void SetToDefaults() {} // 0x00000001895F9224-0x00000001895F9418
		protected override void FixTransforms() {} // 0x000000018238DCF0-0x000000018238DF80
		protected override void InitiateSolver() {} // 0x000000018270AC20-0x000000018270ADE0
		protected override void UpdateSolver() {} // 0x000000018238DF80-0x000000018238E810
		public void LogWarning(string message) {} // 0x00000001895F8FD0-0x00000001895F8FF8
	}

	[Serializable]
	public class BipedIKSolvers // TypeDefIndex: 52646
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
		public IKSolverLimb[] limbs { get => default; } // 0x000000018238E810-0x000000018238E920 
		public IKSolver[] ikSolvers { get => default; } // 0x00000001895F8D04-0x00000001895F8E5C 
	
		// Constructors
		public BipedIKSolvers() {} // 0x00000001829ED1A0-0x00000001829ED390
	
		// Methods
		public void AssignReferences(BipedReferences references) {} // 0x00000001829EDD00-0x00000001829EDEA0
	}

	[Serializable]
	public abstract class Constraint // TypeDefIndex: 52647
	{
		// Fields
		public Transform transform; // 0x10
		public float weight; // 0x18
	
		// Properties
		public bool isValid { get; } // 0x00000001895FE05C-0x00000001895FE0AC 
	
		// Constructors
		protected Constraint() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract void UpdateConstraint();
	}

	[Serializable]
	public class ConstraintPosition : Constraint // TypeDefIndex: 52648
	{
		// Fields
		public Vector3 position; // 0x20
	
		// Constructors
		public ConstraintPosition() {} // 0x000000018350B670-0x000000018350B680
		public ConstraintPosition(Transform transform) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void UpdateConstraint() {} // 0x00000001895FDD58-0x00000001895FDE04
	}

	[Serializable]
	public class ConstraintPositionOffset : Constraint // TypeDefIndex: 52649
	{
		// Fields
		public Vector3 offset; // 0x20
		private Vector3 defaultLocalPosition; // 0x2C
		private Vector3 lastLocalPosition; // 0x38
		private bool initiated; // 0x44
	
		// Properties
		private bool positionChanged { get => default; } // 0x00000001895FDCD4-0x00000001895FDD58 
	
		// Constructors
		public ConstraintPositionOffset() {} // 0x000000018350B670-0x000000018350B680
		public ConstraintPositionOffset(Transform transform) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void UpdateConstraint() {} // 0x00000001895FDB20-0x00000001895FDCD4
	}

	[Serializable]
	public class ConstraintRotation : Constraint // TypeDefIndex: 52650
	{
		// Fields
		public Quaternion rotation; // 0x20
	
		// Constructors
		public ConstraintRotation() {} // 0x000000018350B670-0x000000018350B680
		public ConstraintRotation(Transform transform) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void UpdateConstraint() {} // 0x00000001895FDFC4-0x00000001895FE05C
	}

	[Serializable]
	public class ConstraintRotationOffset : Constraint // TypeDefIndex: 52651
	{
		// Fields
		public Quaternion offset; // 0x20
		private Quaternion defaultRotation; // 0x30
		private Quaternion defaultLocalRotation; // 0x40
		private Quaternion lastLocalRotation; // 0x50
		private Quaternion defaultTargetLocalRotation; // 0x60
		private bool initiated; // 0x70
	
		// Properties
		private bool rotationChanged { get => default; } // 0x00000001895FDF6C-0x00000001895FDFC4 
	
		// Constructors
		public ConstraintRotationOffset() {} // 0x000000018350B670-0x000000018350B680
		public ConstraintRotationOffset(Transform transform) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void UpdateConstraint() {} // 0x00000001895FDE04-0x00000001895FDF6C
	}

	[Serializable]
	public class Constraints // TypeDefIndex: 52652
	{
		// Fields
		public Transform transform; // 0x10
		public Transform target; // 0x18
		public Vector3 positionOffset; // 0x20
		public Vector3 position; // 0x2C
		[Range(0f, 1f)]
		public float positionWeight; // 0x38
		public Vector3 rotationOffset; // 0x3C
		public Vector3 rotation; // 0x48
		[Range(0f, 1f)]
		public float rotationWeight; // 0x54
	
		// Constructors
		public Constraints() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool IsValid() => default; // 0x0000000182E4DC40-0x0000000182E4DD10
		public void Initiate(Transform transform) {} // 0x00000001839D9660-0x00000001839D96E0
		public void Update() {} // 0x0000000182E4D7D0-0x0000000182E4DC40
	}

	[Serializable]
	public class Finger // TypeDefIndex: 52654
	{
		// Fields
		[Range(0f, 1f)]
		[Tooltip("Master Weight for the finger.")]
		public float weight; // 0x10
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		public float rotationWeight; // 0x14
		[Tooltip("Rotational degrees of freedom. When set to \'One\' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF; // 0x18
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist; // 0x1C
		[Tooltip("The first bone of the finger.")]
		public Transform bone1; // 0x20
		[Tooltip("The second bone of the finger.")]
		public Transform bone2; // 0x28
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3; // 0x30
		[Tooltip("The fingertip object. If your character doesn\'t have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip; // 0x38
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target; // 0x40
		private IKSolverLimb solver; // 0x50
		private Quaternion bone3RelativeToTarget; // 0x58
		private Vector3 bone3DefaultLocalPosition; // 0x68
		private Quaternion bone3DefaultLocalRotation; // 0x74
		private Vector3 bone1Axis; // 0x84
		private Vector3 tipAxis; // 0x90
		private Vector3 bone1TwistAxis; // 0x9C
		private Vector3 defaultBendNormal; // 0xA8
	
		// Properties
		public bool initiated { get; private set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
		public Vector3 IKPosition { get => default; set {} } // 0x00000001895FF1E0-0x00000001895FF20C 0x00000001895FF230-0x00000001895FF25C
		public Quaternion IKRotation { get => default; set {} } // 0x00000001895FF20C-0x00000001895FF230 0x00000001895FF25C-0x00000001895FF27C
	
		// Nested types
		[Serializable]
		public enum DOF // TypeDefIndex: 52653
		{
			One = 0,
			Three = 1
		}
	
		// Constructors
		public Finger() {} // 0x0000000183D74330-0x0000000183D74340
	
		// Methods
		public bool IsValid(ref string errorMessage) => default; // 0x00000001895FEA44-0x00000001895FEB0C
		public void Initiate(Transform hand, int index) {} // 0x00000001895FE24C-0x00000001895FEA44
		public void FixTransforms() {} // 0x00000001895FE178-0x00000001895FE24C
		public void StoreDefaultLocalState() {} // 0x00000001895FEB0C-0x00000001895FEBC4
		public void Update(float masterWeight) {} // 0x00000001895FEBC4-0x00000001895FF1E0
	}

	public class FingerRig : SolverManager // TypeDefIndex: 52655
	{
		// Fields
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight; // 0x38
		public Finger[] fingers; // 0x40
	
		// Properties
		public bool initiated { get; private set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
	
		// Constructors
		public FingerRig() {} // 0x0000000189606104-0x0000000189606160
	
		// Methods
		public bool IsValid(ref string errorMessage) => default; // 0x0000000189605EB4-0x0000000189605F1C
		[ContextMenu("Auto-detect")]
		public void AutoDetect() {} // 0x0000000189605B58-0x0000000189605DB4
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null) {} // 0x00000001896059D4-0x0000000189605B58
		public void RemoveFinger(int index) {} // 0x0000000189605F1C-0x0000000189606050
		private void AddChildrenRecursive(Transform parent, ref Transform[] array) {} // 0x0000000189605918-0x00000001896059D4
		protected override void InitiateSolver() {} // 0x0000000189605E1C-0x0000000189605EB4
		public void UpdateFingerSolvers() {} // 0x000000018960609C-0x00000001896060FC
		public void FixFingerTransforms() {} // 0x0000000189605DB4-0x0000000189605E08
		public void StoreDefaultLocalState() {} // 0x0000000189606050-0x000000018960609C
		protected override void UpdateSolver() {} // 0x00000001896060FC-0x0000000189606104
		protected override void FixTransforms() {} // 0x0000000189605E08-0x0000000189605E1C
	}

	public abstract class Grounder : MonoBehaviour // TypeDefIndex: 52657
	{
		// Fields
		[Range(0f, 1f)]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		public float weight; // 0x18
		[Range(0f, 1f)]
		[Tooltip("The weight of feets(virtual feets) to grounder.It won\'t change the position of pelivs,but only makes feet bake to the place by animation.")]
		public float maintianPelvisFootWeight; // 0x1C
		[Range(0f, 1f)]
		[Tooltip("The weight of feets adsorbing the virtual bone.")]
		public float footAdsorbWeight; // 0x20
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver; // 0x28
		public GrounderDelegate OnPreGrounder; // 0x30
		public GrounderDelegate OnPostGrounder; // 0x38
		public GrounderDelegate OnPostIK; // 0x40
	
		// Properties
		public bool initiated { get; protected set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
	
		// Nested types
		public delegate void GrounderDelegate(); // TypeDefIndex: 52656; 0x00000001842BE03C-0x00000001842BE04C
	
		// Constructors
		protected Grounder() {} // 0x00000001835217C0-0x0000000183521850
	
		// Methods
		public abstract void ResetPosition();
		protected Vector3 GetSpineOffsetTarget() => default; // 0x000000018960B8E0-0x000000018960B9C0
		protected void LogWarning(string message) {} // 0x00000001895F8FD0-0x00000001895F8FF8
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg) => default; // 0x000000018960B538-0x000000018960B6E4
		private Vector3 GetLegSpineTangent(Grounding.Leg leg) => default; // 0x000000018960B6E4-0x000000018960B8E0
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderBipedIK : Grounder // TypeDefIndex: 52658
	{
		// Fields
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik; // 0x50
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend; // 0x58
		[Tooltip("The interpolation speed of spine bending.")]
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
		public float RightFootOffsetY { get => default; } // 0x0000000183D58000-0x0000000183D58010 
		public float LeftFootOffsetY { get => default; } // 0x0000000183D58340-0x0000000183D58350 
		public float RightFootOri { get => default; } // 0x0000000183D56EE0-0x0000000183D56EF0 
		public float LeftFootOri { get => default; } // 0x0000000183D58510-0x0000000183D58520 
	
		// Constructors
		public GrounderBipedIK() {} // 0x0000000183521730-0x00000001835217C0
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x0000000189606A68-0x0000000189606A9C
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x0000000189606A34-0x0000000189606A68
		public override void ResetPosition() {} // 0x0000000189606A9C-0x0000000189606ADC
		private bool IsReadyToInitiate() => default; // 0x00000001830DB2A0-0x00000001830DB360
		private void Update() {} // 0x00000001830DB240-0x00000001830DB2A0
		private void Initiate() {} // 0x00000001830DB360-0x00000001830DB6F0
		private void OnDisable() {} // 0x0000000183D4DFF0-0x0000000183D4E010
		private void OnSolverUpdate() {} // 0x0000000182648710-0x0000000182649230
		private void SetLegIK(IKSolverLimb limb, int index) {} // 0x00000001826492D0-0x0000000182649780
		private void OnPostSolverUpdate() {} // 0x00000001826483A0-0x0000000182648710
		private void OnDestroy() {} // 0x0000000183D43420-0x0000000183D43480
		private Quaternion ClampPitchAndRollAroundForward(Quaternion Q, Quaternion calfQ, float minPitch, float maxPitch, float minRoll, float maxRoll) => default; // 0x0000000182503630-0x0000000182503B30
		private float NormalizeAngle(float angle) => default; // 0x0000000182503B30-0x0000000182503F00
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderFBBIK : Grounder // TypeDefIndex: 52660
	{
		// Fields
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik; // 0x50
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend; // 0x58
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed; // 0x5C
		public SpineEffector[] spine; // 0x60
		private Transform[] feet; // 0x68
		private Vector3 spineOffset; // 0x70
		private bool firstSolve; // 0x7C
	
		// Nested types
		[Serializable]
		public class SpineEffector // TypeDefIndex: 52659
		{
			// Fields
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType; // 0x10
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight; // 0x14
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight; // 0x18
	
			// Constructors
			public SpineEffector() {} // 0x0000000183D58F50-0x0000000183D58F60
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight) {} // 0x0000000183D74A50-0x0000000183D74A60
		}
	
		// Constructors
		public GrounderFBBIK() {} // 0x000000018960792C-0x00000001896079B4
	
		// Methods
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial() {} // 0x0000000189607680-0x00000001896076B4
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x00000001896076B4-0x00000001896076E8
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x000000018960764C-0x0000000189607680
		public override void ResetPosition() {} // 0x00000001896076E8-0x0000000189607720
		private bool IsReadyToInitiate() => default; // 0x0000000189606DEC-0x0000000189606E64
		private void Update() {} // 0x00000001896078D0-0x000000018960792C
		private void FixedUpdate() {} // 0x0000000183D566D0-0x0000000183D566E0
		private void LateUpdate() {} // 0x0000000183D566D0-0x0000000183D566E0
		private void Initiate() {} // 0x0000000189606ADC-0x0000000189606DEC
		private void OnSolverUpdate() {} // 0x0000000189607170-0x000000018960764C
		private void SetLegIK(IKEffector effector, Grounding.Leg leg) {} // 0x0000000189607720-0x00000001896078D0
		private void OnDrawGizmosSelected() {} // 0x0000000189607048-0x0000000189607158
		private void OnPostSolverUpdate() {} // 0x0000000189607158-0x0000000189607170
		private void OnDestroy() {} // 0x0000000189606E64-0x0000000189607048
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderIK : Grounder // TypeDefIndex: 52661
	{
		// Fields
		public IK[] legs; // 0x50
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis; // 0x58
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot; // 0x60
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		public float rootRotationWeight; // 0x68
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed; // 0x6C
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
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
		public GrounderIK() {} // 0x000000018960907C-0x0000000189609108
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x00000001896086DC-0x0000000189608710
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x00000001896086A8-0x00000001896086DC
		public override void ResetPosition() {} // 0x0000000189608710-0x0000000189608998
		private bool IsReadyToInitiate() => default; // 0x0000000189607E10-0x0000000189607F8C
		private void OnDisable() {} // 0x00000001896081B4-0x000000018960826C
		private void Update() {} // 0x0000000189608C80-0x000000018960907C
		private void Initiate() {} // 0x00000001896079B4-0x0000000189607E10
		private void OnSolverUpdate() {} // 0x0000000189608440-0x00000001896086A8
		private void SetLegIK(int index) {} // 0x0000000189608998-0x0000000189608C80
		private void OnPostSolverUpdate() {} // 0x000000018960826C-0x0000000189608440
		private void OnDestroy() {} // 0x0000000189607F8C-0x00000001896081B4
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderQuadruped : Grounder // TypeDefIndex: 52663
	{
		// Fields
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver; // 0x50
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		public float rootRotationWeight; // 0x58
		[Range(-90f, 0f)]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		public float minRootRotation; // 0x5C
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		public float maxRootRotation; // 0x60
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed; // 0x64
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset; // 0x68
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset; // 0x6C
		[Range(0f, 1f)]
		[Tooltip("The weight of maintaining the head\'s rotation as it was before solving the Grounding (range: 0 - 1).")]
		public float maintainHeadRotationWeight; // 0x70
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot; // 0x78
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis; // 0x80
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone; // 0x88
		[Tooltip("The head (optional, if you intend to maintain its rotation).")]
		public Transform head; // 0x90
		public IK[] legs; // 0x98
		public IK[] forelegs; // 0xA0
		[HideInInspector]
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
		public struct Foot // TypeDefIndex: 52662
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
			} // 0x0000000189606160-0x00000001896061BC
		}
	
		// Constructors
		public GrounderQuadruped() {} // 0x000000018960B450-0x000000018960B538
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x000000018960A948-0x000000018960A97C
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x000000018960A914-0x000000018960A948
		public override void ResetPosition() {} // 0x000000018960A97C-0x000000018960AB40
		private bool IsReadyToInitiate() => default; // 0x0000000189609BAC-0x0000000189609CAC
		private bool IsReadyToInitiateLegs(IK[] ikComponents) => default; // 0x0000000189609A64-0x0000000189609BAC
		private void OnDisable() {} // 0x0000000189609DC8-0x0000000189609E34
		private void Update() {} // 0x000000018960B3F0-0x000000018960B450
		private void Initiate() {} // 0x0000000189609688-0x0000000189609A64
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset) => default; // 0x0000000189609324-0x0000000189609688
		private void LateUpdate() {} // 0x0000000189609CAC-0x0000000189609D8C
		private void RootRotation() {} // 0x000000018960AB40-0x000000018960AFEC
		private void OnSolverUpdate() {} // 0x000000018960A10C-0x000000018960A914
		private void UpdateForefeetRoot() {} // 0x000000018960B158-0x000000018960B3F0
		private void SetFootIK(Foot foot, float maxOffset) {} // 0x000000018960AFEC-0x000000018960B158
		private void OnPostSolverUpdate() {} // 0x0000000189609E34-0x000000018960A10C
		private void OnDestroy() {} // 0x0000000189609D8C-0x0000000189609DC8
		private void DestroyLegs(IK[] ikComponents) {} // 0x0000000189609108-0x0000000189609324
	}

	[Serializable]
	public class Grounding // TypeDefIndex: 52670
	{
		// Fields
		public Transform IKFootBoneL; // 0x10
		public Transform IKFootBoneR; // 0x18
		[NonSerialized]
		[HideInInspector]
		public float floorLogicTheta; // 0x20
		[HideInInspector]
		public float floorAnimTheta; // 0x24
		[HideInInspector]
		public float floorPredictTheta; // 0x28
		[HideInInspector]
		public float floorFeetThetaByFoot; // 0x2C
		[NonSerialized]
		[HideInInspector]
		public float floorFeetThetaByRoot; // 0x30
		[NonSerialized]
		[HideInInspector]
		public float floorFeetThetaByLogic; // 0x34
		[NonSerialized]
		[HideInInspector]
		public float betweenFeetDistance; // 0x38
		[NonSerialized]
		[HideInInspector]
		public bool isMoving; // 0x3C
		[NonSerialized]
		[HideInInspector]
		public bool isAccelerating; // 0x3D
		[NonSerialized]
		[HideInInspector]
		public bool isPlayingMontage; // 0x3E
		[NonSerialized]
		[HideInInspector]
		public bool isOnMovableBase; // 0x3F
		[NonSerialized]
		[HideInInspector]
		public float SG_timeRef; // 0x40
		[NonSerialized]
		[HideInInspector]
		public float gait; // 0x44
		[NonSerialized]
		[HideInInspector]
		public float startAnimWeight; // 0x48
		[NonSerialized]
		[HideInInspector]
		public Vector3 playerSpeed; // 0x4C
		private bool m_isAcceleratingLastFrame; // 0x58
		[NonSerialized]
		[HideInInspector]
		public bool isLastFrameInvalid; // 0x59
		[Tooltip("\u817F\u4F38\u76F4\u7684\u6700\u957F\u8DDD\u79BB\u3002\u4FDD\u6301ik\u4E0D\u4F1A\u8BA9\u817F\u88AB\u7EF7\u76F4")]
		public float maxLegLength; // 0x5C
		[Tooltip("\u8D85\u8FC7\u8FD9\u4E2A\u9AD8\u5EA6\u7684\u62AC\u817F\u4F1A\u62C9\u52A8\u8D28\u5FC3")]
		public float maxFeetOffset; // 0x60
		[Tooltip("\u8D28\u5FC3\u79BB\u6700\u9AD8\u811A\u81F3\u5C11\u8D85\u8FC7\u8FD9\u4E2A\u8DDD\u79BB")]
		public float minPelvisHeight; // 0x64
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers; // 0x68
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep; // 0x6C
		[Tooltip("The height offset of the root.")]
		public float heightOffset; // 0x70
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed; // 0x74
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius; // 0x78
		[HideInInspector]
		[Tooltip("Offset of the foot center along character forward axis.")]
		public float footCenterOffset; // 0x7C
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction; // 0x80
		[Range(0f, 1f)]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		public float footRotationWeight; // 0x84
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed; // 0x88
		[Range(0f, 90f)]
		public float maxFootRotationAngleFore; // 0x8C
		[Range(0f, 90f)]
		public float maxFootRotationAngleBack; // 0x90
		[Range(0f, 90f)]
		public float maxFootRotationAngleIn; // 0x94
		[Range(0f, 90f)]
		public float maxFootRotationAngleOut; // 0x98
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver; // 0x9C
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed; // 0xA0
		[Tooltip("The speed of moving the character forward/back.")]
		public float pelvisSpeedXZ; // 0xA4
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		public float pelvisDamper; // 0xA8
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight; // 0xAC
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don\'t want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight; // 0xB0
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius; // 0xB4
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the \'Max Step\' value.")]
		public bool overstepFallsDown; // 0xB8
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality; // 0xBC
		public OnRaycastDelegate Raycast; // 0x128
		public OnCapsuleCastDelegate CapsuleCast; // 0x130
		public OnSphereCastDelegate SphereCast; // 0x138
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
		public BipedReferences references { get; private set; } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
		public Leg[] legs { get; private set; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 0x00000001858B4280-0x00000001858B4294
		public Pelvis pelvis { get; private set; } // 0x0000000183D50050-0x0000000183D50060 0x000000018554A7E0-0x000000018554A7F4
		public bool isGrounded { get; private set; } // 0x0000000183D51180-0x0000000183D51190 0x0000000183D511E0-0x0000000183D511F0
		public Transform root { get; private set; } // 0x0000000183D51140-0x0000000183D51150 0x000000018589D964-0x000000018589D978
		public RaycastHit rootHit { get; private set; } // 0x0000000183D6B8F0-0x0000000183D6B920 0x0000000183D74930-0x0000000183D74960
		public bool rootGrounded { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public Transform entityTransform { get; set; } // 0x0000000183D57300-0x0000000183D57310 0x00000001858B3FD8-0x00000001858B3FEC
		public bool entityIsOnMovableBase { get; set; } // 0x0000000183D57CB0-0x0000000183D57CC0 0x0000000183D5A1F0-0x0000000183D5A200
		public Vector3 entityRelativePosition { get; set; } // 0x0000000183D748D0-0x0000000183D748F0 0x0000000183D74900-0x0000000183D74920
		public Quaternion entityRelativeRotation { get; set; } // 0x0000000183D748F0-0x0000000183D74900 0x0000000183D74920-0x0000000183D74930
		public Vector3 up { get => default; } // 0x0000000182388E40-0x0000000182388EA0 
		public Vector3 forward { get => default; } // 0x000000018281B940-0x000000018281B9E0 
		private bool useRootRotation { get => default; } // 0x0000000182388EA0-0x0000000182388EC0 
	
		// Nested types
		[Serializable]
		public enum Quality // TypeDefIndex: 52664
		{
			Fastest = 0,
			Simple = 1,
			Best = 2,
			Custom = 3
		}
	
		public delegate bool OnRaycastDelegate(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 52665; 0x0000000185011CFC-0x0000000185011D6C
	
		public delegate bool OnCapsuleCastDelegate(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 52666; 0x00000001850112A8-0x000000018501134C
	
		public delegate bool OnSphereCastDelegate(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 52667; 0x0000000185010C40-0x0000000185010CBC
	
		public class Leg // TypeDefIndex: 52668
		{
			// Fields
			public Quaternion rotationOffset; // 0x20
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
			public const float MAX_PREDICTION_DISTANCE = 2.25f; // Metadata: 0x01FD2B10
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
			public bool isGrounded { get; private set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
			public Vector3 IKPosition { get; private set; } // 0x0000000181176980-0x00000001811769A0 0x0000000183D6E520-0x0000000183D6E530
			public bool initiated { get; private set; } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
			public float heightFromGround { get; private set; } // 0x0000000183D56CA0-0x0000000183D56CB0 0x0000000183D56CB0-0x0000000183D56CC0
			public float fowardMoveFromGround { get; private set; } // 0x0000000183D51000-0x0000000183D51010 0x0000000183D51010-0x0000000183D51020
			public float rightMoveFromGround { get; private set; } // 0x0000000183D4EC60-0x0000000183D4EC70 0x0000000183D4ECE0-0x0000000183D4ECF0
			public Vector3 velocity { get; private set; } // 0x0000000183D52300-0x0000000183D52320 0x0000000183D52330-0x0000000183D52340
			public Transform transform { get; private set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
			public float IKOffset { get; private set; } // 0x0000000183D51080-0x0000000183D51090 0x0000000183D510B0-0x0000000183D510C0
			public float IKOffsetZ { get; private set; } // 0x0000000183D56C10-0x0000000183D56C20 0x0000000183D5BDF0-0x0000000183D5BE00
			public float IKOffsetX { get; private set; } // 0x0000000183D50D50-0x0000000183D50D60 0x0000000183D50D80-0x0000000183D50D90
			public RaycastHit heelHit { get; private set; } // 0x0000000183D749C0-0x0000000183D749F0 0x0000000183D74A20-0x0000000183D74A50
			public RaycastHit capsuleHit { get; private set; } // 0x0000000183D74990-0x0000000183D749C0 0x0000000183D749F0-0x0000000183D74A20
			public RaycastHit GetHitPoint { get => default; } // 0x000000018960CCDC-0x000000018960CD50 
			public Vector3 right { get => default; } // 0x0000000182388EC0-0x0000000182389000 
			public Vector3 speedRight { get => default; } // 0x0000000183577330-0x00000001835773C0 
			public Vector3 predictOffsetwithPercent { get => default; } // 0x00000001831145F0-0x0000000183114640 
			private bool isLeft { get => default; } // 0x0000000182E50A90-0x0000000182E50C10 
			private bool isMoving { get => default; } // 0x000000018960CD50-0x000000018960CD70 
			public float stepHeightFromGround { get => default; } // 0x000000018303B890-0x000000018303B8E0 
			public float stepForwardFromGround { get => default; } // 0x000000018306A270-0x000000018306A2A0 
			public float stepRightFromGround { get => default; } // 0x000000018306A2A0-0x000000018306A2D0 
			private Vector3 animFootGroundPos { get => default; } // 0x000000018238FC10-0x000000018238FE90 
			public float rootYOffset { get => default; } // 0x0000000182388AC0-0x0000000182388DF0 
	
			// Constructors
			public Leg() {} // 0x00000001830DB980-0x00000001830DB9F0
			static Leg() {} // 0x0000000183CBA040-0x0000000183CBA0E0
	
			// Methods
			public void SetFootPosition(Vector3 position) {} // 0x0000000183D74970-0x0000000183D74990
			public void Initiate(Grounding grounding, Transform transform) {} // 0x00000001830DB9F0-0x00000001830DBAD0
			public void OnEnable() {} // 0x00000001830DBAD0-0x00000001830DBB30
			public void Reset() {} // 0x000000018960C978-0x000000018960CA04
			private void _ResetPredictReference(RaycastHit curHit) {} // 0x0000000182E509F0-0x0000000182E50A70
			private void _PredictNextStepHit(Vector3 prediction, Vector3 predictVec, bool canChangeHeight = true /* Metadata: 0x01FD2B0E */) {} // 0x0000000182A5D410-0x0000000182A5D640
			private float _CanHitPointLand(RaycastHit hit, out RaycastHit predictHit) {
				predictHit = default;
				return default;
			} // 0x0000000182A5D640-0x0000000182A5DA10
			public void Process() {} // 0x00000001822F51C0-0x00000001822F7F30
			private void _UpdateHeelHit(float curStepPercent, Vector3 prediction) {} // 0x00000001832071E0-0x00000001832072E0
			private Vector3 _UpdatePredictOffset(float curStepPercent) => default; // 0x00000001832072E0-0x0000000183207400
			public void FinalSetIKPosition(Vector3 thighPos) {} // 0x0000000182EC8C80-0x0000000182EC8EC0
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel, Vector3 predictPos) => default; // 0x00000001829FA5B0-0x00000001829FB1C0
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel) => default; // 0x000000018960BE2C-0x000000018960C528
			private RaycastHit GetRaycastHitCustom(Vector3 offsetFromHeel) => default; // 0x00000001827EA3C0-0x00000001827EA760
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel) => default; // 0x000000018960C528-0x000000018960C978
			private Vector3 RotateNormal(Vector3 normal) => default; // 0x0000000182387690-0x0000000182387700
			private void SetFootToPoint(Vector3 normal, Vector3 point) {} // 0x000000018960CC14-0x000000018960CCDC
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint) {} // 0x000000018960CA04-0x000000018960CC14
			private void SetFootToPoint(Vector3 normal, Vector3 pointForXZ, Vector3 pointForY) {} // 0x0000000182387320-0x0000000182387690
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint, Vector3 footNormal, bool isLimitByComplex = true /* Metadata: 0x01FD2B0F */) {} // 0x000000018285CE70-0x000000018285D270
			private float GetHeightFromGround(Vector3 hitPoint) => default; // 0x00000001823883F0-0x00000001823884A0
			private void RotateFoot() {} // 0x000000018264A1F0-0x000000018264A2A0
			private Quaternion GetRotationOffsetTarget() => default; // 0x0000000183D74960-0x0000000183D74970
			private Vector3 RotateNormalWithLimit(Vector3 normal) => default; // 0x0000000182387700-0x00000001823881E0
		}
	
		public class Pelvis // TypeDefIndex: 52669
		{
			// Fields
			private float forwardOffset; // 0x20
			public float pelivsSpeedY; // 0x24
			private Grounding grounding; // 0x28
			private Vector3 lastRootPosition; // 0x30
			private float damperF; // 0x3C
			private bool initiated; // 0x40
			private float lastTime; // 0x44
	
			// Properties
			public Vector3 IKOffset { get; private set; } // 0x0000000183D55550-0x0000000183D55570 0x0000000183D55570-0x0000000183D55580
			public float heightOffset { get; private set; } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
	
			// Constructors
			public Pelvis() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Initiate(Grounding grounding) {} // 0x00000001830DBB30-0x00000001830DBB60
			public void Reset() {} // 0x000000018960D4D0-0x000000018960D550
			public void OnEnable() {} // 0x00000001830DBB60-0x00000001830DBBD0
			public void Process(float pelivsOffset, float _forwardOffset, bool isGrounded, bool islastFrameLegStretch = false /* Metadata: 0x01FD2B14 */, bool isSameLegReflastFrame = false /* Metadata: 0x01FD2B15 */) {} // 0x000000018281B9E0-0x000000018281C190
			private RaycastHit GetRaycastHitCustom(Vector3 rayOrigin) => default; // 0x000000018960D108-0x000000018960D4D0
		}
	
		// Constructors
		public Grounding() {} // 0x0000000183521850-0x0000000183521A10
	
		// Methods
		private void _UpdateFloorPredictTheta() {} // 0x00000001823884A0-0x00000001823887F0
		private void _UpdateFloorFeetThetaByFoot() {} // 0x00000001823887F0-0x0000000182388AC0
		private void _UpdateFloorFeetThetaByRoot() {} // 0x000000018281B6E0-0x000000018281B940
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f /* Metadata: 0x01FD2B06 */) => default; // 0x00000001827E9AC0-0x00000001827E9FA0
		public bool IsValid(ref string errorMessage) => default; // 0x00000001830DBBD0-0x00000001830DBCB0
		public void Initiate(Transform root, Transform[] feet, BipedReferences references = null) {} // 0x00000001830DB6F0-0x00000001830DB980
		public void Update() {} // 0x0000000182390970-0x0000000182391AB0
		public Vector3 GetLegsPlaneNormal() => default; // 0x000000018960BBB0-0x000000018960BDA4
		public void Reset() {} // 0x000000018960BDBC-0x000000018960BE2C
		public void LogWarning(string message) {} // 0x000000018960BDA4-0x000000018960BDBC
		public float GetVerticalOffset(Vector3 p1, Vector3 p2) => default; // 0x0000000182388DF0-0x0000000182388E40
		public Vector3 Flatten(Vector3 v) => default; // 0x000000018960B9C0-0x000000018960BAB4
		public Vector3 GetFootCenterOffset() => default; // 0x000000018960BAB4-0x000000018960BBB0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK // TypeDefIndex: 52671
	{
		// Fields
		public IKSolverAim solver; // 0x38
	
		// Constructors
		public AimIK() {} // 0x0000000189605394-0x0000000189605408
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x000000018960532C-0x0000000189605360
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x00000001896052C4-0x00000001896052F8
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial() {} // 0x00000001896052F8-0x000000018960532C
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x0000000189605360-0x0000000189605394
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x0000000189605290-0x00000001896052C4
		public override IKSolver GetIKSolver() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class ArmIK : IK // TypeDefIndex: 52672
	{
		// Fields
		public IKSolverArm solver; // 0x38
	
		// Constructors
		public ArmIK() {} // 0x00000001896054D8-0x000000018960554C
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x0000000189605470-0x00000001896054A4
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x000000018960543C-0x0000000189605470
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x00000001896054A4-0x00000001896054D8
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x0000000189605408-0x000000018960543C
		public override IKSolver GetIKSolver() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK // TypeDefIndex: 52673
	{
		// Fields
		public IKSolverCCD solver; // 0x38
	
		// Constructors
		public CCDIK() {} // 0x000000018960561C-0x0000000189605690
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x00000001896055B4-0x00000001896055E8
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x0000000189605580-0x00000001896055B4
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x00000001896055E8-0x000000018960561C
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x000000018960554C-0x0000000189605580
		public override IKSolver GetIKSolver() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	public class FABRIK : IK // TypeDefIndex: 52674
	{
		// Fields
		public IKSolverFABRIK solver; // 0x38
	
		// Constructors
		public FABRIK() {} // 0x00000001896058A4-0x0000000189605918
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x000000018960583C-0x0000000189605870
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x0000000189605808-0x000000018960583C
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x0000000189605870-0x00000001896058A4
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x00000001896057D4-0x0000000189605808
		public override IKSolver GetIKSolver() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	public class FABRIKRoot : IK // TypeDefIndex: 52675
	{
		// Fields
		public IKSolverFABRIKRoot solver; // 0x38
	
		// Constructors
		public FABRIKRoot() {} // 0x0000000189605760-0x00000001896057D4
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x00000001896056F8-0x000000018960572C
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x00000001896056C4-0x00000001896056F8
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x000000018960572C-0x0000000189605760
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x0000000189605690-0x00000001896056C4
		public override IKSolver GetIKSolver() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK // TypeDefIndex: 52676
	{
		// Fields
		public BipedReferences references; // 0x38
		public IKSolverFullBodyBiped solver; // 0x40
	
		// Constructors
		public FullBodyBipedIK() {} // 0x0000000189606988-0x0000000189606A34
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x0000000189606364-0x0000000189606398
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x00000001896062FC-0x0000000189606330
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial() {} // 0x0000000189606330-0x0000000189606364
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial() {} // 0x00000001896062C8-0x00000001896062FC
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x0000000189606954-0x0000000189606988
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x00000001896061BC-0x00000001896061F0
		public void SetReferences(BipedReferences references, Transform rootNode) {} // 0x0000000189606918-0x0000000189606954
		public override IKSolver GetIKSolver() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
		public bool ReferencesError(ref string errorMessage) => default; // 0x0000000189606398-0x0000000189606578
		public bool ReferencesWarning(ref string warningMessage) => default; // 0x0000000189606578-0x00000001896068EC
		[ContextMenu("Reinitiate")]
		private void Reinitiate() {} // 0x00000001896068EC-0x0000000189606918
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences() {} // 0x00000001896061F0-0x00000001896062C8
	}

	public abstract class IK : SolverManager // TypeDefIndex: 52677
	{
		// Constructors
		protected IK() {} // 0x00000001842726E8-0x00000001842726F4
	
		// Methods
		public abstract IKSolver GetIKSolver();
		protected override void UpdateSolver() {} // 0x000000018961E4CC-0x000000018961E52C
		protected override void InitiateSolver() {} // 0x000000018961E470-0x000000018961E4CC
		protected override void FixTransforms() {} // 0x000000018961E42C-0x000000018961E470
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}

	public class IKExecutionOrder : MonoBehaviour // TypeDefIndex: 52678
	{
		// Fields
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents; // 0x18
		[Tooltip("Optional. Assign it if you are using \'Animate Physics\' as the Update Mode.")]
		public Animator animator; // 0x20
		private bool fixedFrame; // 0x28
	
		// Properties
		private bool animatePhysics { get => default; } // 0x00000001896193F4-0x000000018961946C 
	
		// Constructors
		public IKExecutionOrder() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Start() {} // 0x0000000189619374-0x00000001896193C8
		private void Update() {} // 0x00000001896193C8-0x00000001896193F4
		private void FixedUpdate() {} // 0x00000001896192D0-0x0000000189619300
		private void LateUpdate() {} // 0x0000000189619300-0x0000000189619374
		private void FixTransforms() {} // 0x0000000189619260-0x00000001896192D0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class LegIK : IK // TypeDefIndex: 52679
	{
		// Fields
		public IKSolverLeg solver; // 0x38
	
		// Constructors
		public LegIK() {} // 0x000000018961E674-0x000000018961E6E8
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x000000018961E60C-0x000000018961E640
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x000000018961E5D8-0x000000018961E60C
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x000000018961E640-0x000000018961E674
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x000000018961E5A4-0x000000018961E5D8
		public override IKSolver GetIKSolver() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class LimbIK : IK // TypeDefIndex: 52680
	{
		// Fields
		public IKSolverLimb solver; // 0x38
	
		// Constructors
		public LimbIK() {} // 0x000000018961E7B8-0x000000018961E82C
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x000000018961E750-0x000000018961E784
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x000000018961E71C-0x000000018961E750
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x000000018961E784-0x000000018961E7B8
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x000000018961E6E8-0x000000018961E71C
		public override IKSolver GetIKSolver() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	public class LookAtIK : IK // TypeDefIndex: 52681
	{
		// Fields
		public IKSolverLookAt solver; // 0x38
	
		// Constructors
		public LookAtIK() {} // 0x000000018961E8FC-0x000000018961E970
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x000000018961E894-0x000000018961E8C8
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x000000018961E860-0x000000018961E894
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x000000018961E8C8-0x000000018961E8FC
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x000000018961E82C-0x000000018961E860
		public override IKSolver GetIKSolver() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	public class TrigonometricIK : IK // TypeDefIndex: 52682
	{
		// Fields
		public IKSolverTrigonometric solver; // 0x38
	
		// Constructors
		public TrigonometricIK() {} // 0x000000018961FDBC-0x000000018961FE30
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x000000018961FD54-0x000000018961FD88
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x000000018961FD20-0x000000018961FD54
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x000000018961FD88-0x000000018961FDBC
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x000000018961FCEC-0x000000018961FD20
		public override IKSolver GetIKSolver() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK // TypeDefIndex: 52684
	{
		// Fields
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select \'Auto-detect References\' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public References references; // 0x38
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver; // 0x40
	
		// Nested types
		[Serializable]
		public class References // TypeDefIndex: 52683
		{
			// Fields
			public Transform root; // 0x10
			[LargeHeader("Spine")]
			public Transform pelvis; // 0x18
			public Transform spine; // 0x20
			[Tooltip("Optional")]
			public Transform chest; // 0x28
			[Tooltip("Optional")]
			public Transform neck; // 0x30
			public Transform head; // 0x38
			[LargeHeader("Left Arm")]
			[Tooltip("Optional")]
			public Transform leftShoulder; // 0x40
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftUpperArm; // 0x48
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftForearm; // 0x50
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftHand; // 0x58
			[LargeHeader("Right Arm")]
			[Tooltip("Optional")]
			public Transform rightShoulder; // 0x60
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightUpperArm; // 0x68
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightForearm; // 0x70
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightHand; // 0x78
			[LargeHeader("Left Leg")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh; // 0x80
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf; // 0x88
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot; // 0x90
			[Tooltip("Optional")]
			public Transform leftToes; // 0x98
			[LargeHeader("Right Leg")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh; // 0xA0
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf; // 0xA8
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot; // 0xB0
			[Tooltip("Optional")]
			public Transform rightToes; // 0xB8
	
			// Properties
			public bool isFilled { get => default; } // 0x000000018961F888-0x000000018961FCEC 
			public bool isEmpty { get => default; } // 0x000000018961F518-0x000000018961F888 
	
			// Constructors
			public References() {} // 0x000000018350B670-0x000000018350B680
			public References(BipedReferences b) {} // 0x000000018961F2D4-0x000000018961F518
	
			// Methods
			public Transform[] GetTransforms() => default; // 0x000000018961EFB4-0x000000018961F2D4
			public static bool AutoDetectReferences(Transform root, out References references) {
				references = default;
				return default;
			} // 0x000000018961EB1C-0x000000018961EFB4
		}
	
		// Constructors
		public VRIK() {} // 0x00000001896200D8-0x0000000189620174
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {} // 0x000000018961FF50-0x000000018961FF84
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {} // 0x000000018961FEE8-0x000000018961FF1C
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial() {} // 0x000000018961FF1C-0x000000018961FF50
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences() {} // 0x000000018961FE30-0x000000018961FE54
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations() {} // 0x000000018961FE54-0x000000018961FE80
		public override IKSolver GetIKSolver() => default; // 0x0000000183D4E2B0-0x0000000183D4E2C0
		protected override void InitiateSolver() {} // 0x000000018961FE80-0x000000018961FEE8
		protected override void UpdateSolver() {} // 0x000000018961FF84-0x00000001896200D8
	}

	[Serializable]
	public class FABRIKChain // TypeDefIndex: 52685
	{
		// Fields
		public FABRIK ik; // 0x10
		[Range(0f, 1f)]
		public float pull; // 0x18
		[Range(0f, 1f)]
		public float pin; // 0x1C
		public int[] children; // 0x20
	
		// Constructors
		public FABRIKChain() {} // 0x000000018960FC98-0x000000018960FCE8
	
		// Methods
		public bool IsValid(ref string message) => default; // 0x000000018960F9CC-0x000000018960FA7C
		public void Initiate() {} // 0x000000018960F9A8-0x000000018960F9CC
		public void Stage1(FABRIKChain[] chain) {} // 0x000000018960FA7C-0x000000018960FB70
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain) {} // 0x000000018960FB70-0x000000018960FC98
		private Vector3 GetCentroid(FABRIKChain[] chain) => default; // 0x000000018960F6AC-0x000000018960F9A8
	}

	public class FBBIKArmBending : MonoBehaviour // TypeDefIndex: 52686
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
		public FBBIKArmBending() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void LateUpdate() {} // 0x000000018960FCE8-0x0000000189610304
		private void OnPostFBBIK() {} // 0x000000018961042C-0x0000000189610600
		private void OnDestroy() {} // 0x0000000189610304-0x000000018961042C
	}

	public class FBBIKHeadEffector : MonoBehaviour // TypeDefIndex: 52688
	{
		// Fields
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik; // 0x18
		[LargeHeader("Position")]
		[Range(0f, 1f)]
		[Tooltip("Master weight for positioning the head.")]
		public float positionWeight; // 0x20
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the body along with the head")]
		public float bodyWeight; // 0x24
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the thighs along with the head")]
		public float thighWeight; // 0x28
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody; // 0x2C
		[LargeHeader("Rotation")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the head bone after solving")]
		public float rotationWeight; // 0x30
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the body")]
		public float bodyClampWeight; // 0x34
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight; // 0x38
		[Range(0f, 1f)]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		public float bendWeight; // 0x3C
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones; // 0x40
		[LargeHeader("CCD")]
		[Range(0f, 1f)]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		public float CCDWeight; // 0x48
		[Range(0f, 1f)]
		[Tooltip("The weight of rolling the bones in towards the target")]
		public float roll; // 0x4C
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper; // 0x50
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones; // 0x58
		[LargeHeader("Stretching")]
		[Range(0f, 1f)]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the \'Stretch Bones\', the hands might become offset from their target positions.")]
		public float postStretchWeight; // 0x60
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch; // 0x64
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper; // 0x68
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead; // 0x6C
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones; // 0x70
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection; // 0x78
		[Range(0f, 1f)]
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
		public class BendBone // TypeDefIndex: 52687
		{
			// Fields
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform; // 0x10
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight; // 0x18
			private Quaternion defaultLocalRotation; // 0x1C
	
			// Constructors
			public BendBone() {} // 0x000000018960D5F0-0x000000018960D614
			public BendBone(Transform transform, float weight) {} // 0x000000018960D5B8-0x000000018960D5F0
	
			// Methods
			public void StoreDefaultLocalState() {} // 0x000000018960D584-0x000000018960D5B8
			public void FixTransforms() {} // 0x000000018960D550-0x000000018960D584
		}
	
		// Constructors
		public FBBIKHeadEffector() {} // 0x0000000189613C68-0x0000000189613E3C
	
		// Methods
		private void Start() {} // 0x00000001896137B8-0x0000000189613C68
		private void OnStoreDefaultLocalState() {} // 0x0000000189612A80-0x0000000189612FB4
		private void OnFixTransforms() {} // 0x0000000189611C18-0x0000000189612004
		private void OnPreRead() {} // 0x0000000189612204-0x0000000189612A80
		private void SpineBend() {} // 0x0000000189613488-0x00000001896137B8
		private void CCDPass() {} // 0x0000000189610600-0x0000000189610988
		private void Iterate(int iteration) {} // 0x0000000189610C34-0x00000001896116E4
		private void OnPostUpdate() {} // 0x0000000189612004-0x0000000189612204
		private void ChestDirection() {} // 0x0000000189610988-0x0000000189610C34
		private void PostStretching() {} // 0x0000000189612FB4-0x000000018961331C
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset) {} // 0x00000001896116E4-0x0000000189611804
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance) {} // 0x000000018961331C-0x0000000189613488
		private void OnDestroy() {} // 0x0000000189611804-0x0000000189611C18
	}

	[Serializable]
	public class FBIKChain // TypeDefIndex: 52691
	{
		// Fields
		[Range(0f, 1f)]
		public float pin; // 0x10
		[Range(0f, 1f)]
		public float pull; // 0x14
		[Range(0f, 1f)]
		public float push; // 0x18
		[Range(-1f, 1f)]
		public float pushParent; // 0x1C
		[Range(0f, 1f)]
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
		private const float maxLimbLength = 0.99999f; // Metadata: 0x01FD2B17
	
		// Nested types
		[Serializable]
		public class ChildConstraint // TypeDefIndex: 52689
		{
			// Fields
			public float pushElasticity; // 0x10
			public float pullElasticity; // 0x14
			[SerializeField]
			private Transform bone1; // 0x18
			[SerializeField]
			private Transform bone2; // 0x20
			private float crossFade; // 0x30
			private float inverseCrossFade; // 0x34
			private int chain1Index; // 0x38
			private int chain2Index; // 0x3C
	
			// Properties
			public float nominalDistance { get; private set; } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
			public bool isRigid { get; private set; } // 0x0000000183D4F1A0-0x0000000183D4F1B0 0x0000000183D4F1B0-0x0000000183D4F1C0
	
			// Constructors
			public ChildConstraint() {} // Dummy constructor
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f /* Metadata: 0x01FD2B1B */, float pullElasticity = 0f /* Metadata: 0x01FD2B1F */) {} // 0x000000018960F670-0x000000018960F6AC
	
			// Methods
			public void Initiate(IKSolverFullBody solver) {} // 0x000000018960F130-0x000000018960F188
			public void OnPreSolve(IKSolverFullBody solver) {} // 0x000000018960F188-0x000000018960F35C
			public void Solve(IKSolverFullBody solver) {} // 0x000000018960F35C-0x000000018960F670
		}
	
		[Serializable]
		public enum Smoothing // TypeDefIndex: 52690
		{
			None = 0,
			Exponential = 1,
			Cubic = 2
		}
	
		// Constructors
		public FBIKChain() {} // 0x0000000189616570-0x0000000189616674
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms) {} // 0x0000000189616414-0x0000000189616570
	
		// Methods
		public void SetNodes(params Transform[] boneTransforms) {} // 0x00000001896156E4-0x00000001896157DC
		public int GetNodeIndex(Transform boneTransform) => default; // 0x00000001896147F0-0x0000000189614898
		public bool IsValid(ref string message) => default; // 0x0000000189614A30-0x0000000189614B14
		public void Initiate(IKSolverFullBody solver) {} // 0x0000000189614898-0x0000000189614A30
		public void ReadPose(IKSolverFullBody solver, bool fullBody) {} // 0x0000000189615208-0x00000001896156E4
		private void CalculateBoneLengths(IKSolverFullBody solver) {} // 0x0000000189613FE8-0x00000001896144F4
		public void Reach(IKSolverFullBody solver) {} // 0x0000000189614EA4-0x0000000189615208
		public Vector3 Push(IKSolverFullBody solver) => default; // 0x0000000189614B14-0x0000000189614EA4
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false /* Metadata: 0x01FD2B16 */) {} // 0x0000000189615BDC-0x0000000189615ED8
		public void Stage1(IKSolverFullBody solver) {} // 0x0000000189615ED8-0x00000001896162F4
		public void Stage2(IKSolverFullBody solver, Vector3 position) {} // 0x00000001896162F4-0x0000000189616414
		public void SolveConstraintSystems(IKSolverFullBody solver) {} // 0x0000000189615840-0x0000000189615954
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x0000000189615954-0x0000000189615A2C
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude) => default; // 0x0000000189614630-0x00000001896147F0
		private void SolveChildConstraints(IKSolverFullBody solver) {} // 0x00000001896157DC-0x0000000189615840
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance) {} // 0x0000000189615A2C-0x0000000189615BDC
		public void ForwardReach(Vector3 position) {} // 0x00000001896144F4-0x0000000189614630
		private void BackwardReach(Vector3 position) {} // 0x0000000189613E3C-0x0000000189613FE8
	}

	[Serializable]
	public class IKConstraintBend // TypeDefIndex: 52692
	{
		// Fields
		public Transform bone1; // 0x10
		public Transform bone2; // 0x18
		public Transform bone3; // 0x20
		public Transform bendGoal; // 0x28
		public Vector3 direction; // 0x30
		public Quaternion rotationOffset; // 0x3C
		[Range(0f, 1f)]
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
		private bool limbOrientationsSet; // 0x85
	
		// Properties
		public bool initiated { get; private set; } // 0x0000000183D51AD0-0x0000000183D51AE0 0x0000000183D51B30-0x0000000183D51B40
	
		// Constructors
		public IKConstraintBend() {} // 0x0000000189617938-0x0000000189617958
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3) {} // 0x0000000189617908-0x0000000189617938
	
		// Methods
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger) => default; // 0x0000000189616F20-0x00000001896170AC
		public void SetBones(Transform bone1, Transform bone2, Transform bone3) {} // 0x000000018285BDC0-0x000000018285BE00
		public void Initiate(IKSolverFullBody solver) {} // 0x0000000189616C30-0x0000000189616F20
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last) {} // 0x0000000189617708-0x0000000189617908
		public void LimitBend(float solverWeight, float positionWeight) {} // 0x00000001896170AC-0x0000000189617510
		public Vector3 GetDir(IKSolverFullBody solver) => default; // 0x0000000189616674-0x0000000189616C30
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent) => default; // 0x000000018961760C-0x0000000189617708
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent) => default; // 0x0000000189617510-0x000000018961760C
	}

	[Serializable]
	public class IKEffector // TypeDefIndex: 52693
	{
		// Fields
		public Transform bone; // 0x10
		public Transform target; // 0x18
		[Range(0f, 1f)]
		public float positionWeight; // 0x20
		[Range(0f, 1f)]
		public float rotationWeight; // 0x24
		public Vector3 position; // 0x28
		public Quaternion rotation; // 0x34
		public Vector3 positionOffset; // 0x44
		public bool effectChildNodes; // 0x51
		[Range(0f, 1f)]
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
		public bool isEndEffector { get; private set; } // 0x0000000183D4F000-0x0000000183D4F010 0x0000000183D4F030-0x0000000183D4F040
	
		// Constructors
		public IKEffector() {} // 0x0000000189618F9C-0x00000001896190E4
		public IKEffector(Transform bone, Transform[] childBones) {} // 0x00000001896190E4-0x0000000189619260
	
		// Methods
		public IKSolver.Node GetNode(IKSolverFullBody solver) => default; // 0x0000000189617958-0x00000001896179B0
		public void PinToBone(float positionWeight, float rotationWeight) {} // 0x0000000189618A34-0x0000000189618AFC
		public bool IsValid(IKSolver solver, ref string message) => default; // 0x0000000189618198-0x00000001896183E8
		public void Initiate(IKSolverFullBody solver) {} // 0x0000000189617EBC-0x0000000189618198
		public void ResetOffset(IKSolverFullBody solver) {} // 0x0000000189618AFC-0x0000000189618BDC
		public void SetToTarget() {} // 0x0000000189618BDC-0x0000000189618C7C
		public void OnPreSolve(IKSolverFullBody solver) {} // 0x00000001896183FC-0x0000000189618A34
		public void OnPostWrite() {} // 0x00000001896183E8-0x00000001896183FC
		private Quaternion GetPlaneRotation(IKSolverFullBody solver) => default; // 0x00000001896179B0-0x0000000189617BC4
		public void Update(IKSolverFullBody solver) {} // 0x0000000189618C7C-0x0000000189618F9C
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset) {
			planeRotationOffset = default;
			return default;
		} // 0x0000000189617BC4-0x0000000189617EBC
	}

	[Serializable]
	public class IKMapping // TypeDefIndex: 52695
	{
		// Nested types
		[Serializable]
		public class BoneMap // TypeDefIndex: 52694
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
			public Vector3 swingDirection { get => default; } // 0x000000018960E928-0x000000018960E9A4 
			public bool isNodeBone { get => default; } // 0x000000018960E720-0x000000018960E728 
			private Quaternion lastAnimatedTargetRotation { get => default; } // 0x000000018960E728-0x000000018960E928 
	
			// Constructors
			public BoneMap() {} // 0x0000000183D74A60-0x0000000183D74A90
	
			// Methods
			public void Initiate(Transform transform, IKSolverFullBody solver) {} // 0x000000018960DA40-0x000000018960DA8C
			public void StoreDefaultLocalState() {} // 0x000000018960E1B8-0x000000018960E214
			public void FixTransform(bool position) {} // 0x000000018960D718-0x000000018960D780
			public void SetLength(BoneMap nextBone) {} // 0x000000018960DE14-0x000000018960DEB4
			public void SetLocalSwingAxis(BoneMap swingTarget) {} // 0x000000018960DFE4-0x000000018960DFF0
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2) {} // 0x000000018960DEB4-0x000000018960DFE4
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection) {} // 0x000000018960DFF0-0x000000018960E090
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3) {} // 0x000000018960E090-0x000000018960E17C
			public void UpdatePlane(bool rotation, bool position) {} // 0x000000018960E5BC-0x000000018960E720
			public void SetIKPosition() {} // 0x000000018960DDD8-0x000000018960DE14
			public void MaintainRotation() {} // 0x000000018960DA8C-0x000000018960DAC0
			public void SetToIKPosition() {} // 0x000000018960E17C-0x000000018960E1B8
			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null) {} // 0x000000018960D614-0x000000018960D718
			public Vector3 GetPlanePosition(IKSolverFullBody solver) => default; // 0x000000018960D780-0x000000018960D878
			public void PositionToPlane(IKSolverFullBody solver) {} // 0x000000018960DAC0-0x000000018960DB10
			public void RotateToPlane(IKSolverFullBody solver, float weight) {} // 0x000000018960DCF0-0x000000018960DDD8
			public void Swing(Vector3 swingTarget, float weight) {} // 0x000000018960E3BC-0x000000018960E440
			public void Swing(Vector3 pos1, Vector3 pos2, float weight) {} // 0x000000018960E214-0x000000018960E3BC
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight) {} // 0x000000018960E440-0x000000018960E5BC
			public void RotateToMaintain(float weight) {} // 0x000000018960DC58-0x000000018960DCF0
			public void RotateToEffector(IKSolverFullBody solver, float weight) {} // 0x000000018960DB10-0x000000018960DC58
			private Quaternion GetTargetRotation(IKSolverFullBody solver) => default; // 0x000000018960D878-0x000000018960DA40
		}
	
		// Constructors
		public IKMapping() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual bool IsValid(IKSolver solver, ref string message) => default; // 0x000000018232EB60-0x000000018232EB70
		public virtual void Initiate(IKSolverFullBody solver) {} // 0x000000018350B670-0x000000018350B680
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger = null) => default; // 0x000000018961C180-0x000000018961C27C
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x0000000189615954-0x0000000189615A2C
	}

	[Serializable]
	public class IKMappingBone : IKMapping // TypeDefIndex: 52696
	{
		// Fields
		public Transform bone; // 0x10
		[Range(0f, 1f)]
		public float maintainRotationWeight; // 0x18
		private BoneMap boneMap; // 0x20
	
		// Constructors
		public IKMappingBone() {} // 0x0000000189619624-0x00000001896196A8
		public IKMappingBone(Transform bone) {} // 0x00000001896196A8-0x0000000189619744
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message) => default; // 0x0000000189619538-0x00000001896195B4
		public void StoreDefaultLocalState() {} // 0x00000001896195D4-0x00000001896195F4
		public void FixTransforms() {} // 0x000000018961946C-0x0000000189619490
		public override void Initiate(IKSolverFullBody solver) {} // 0x0000000189619490-0x0000000189619538
		public void ReadPose() {} // 0x00000001896195B4-0x00000001896195D4
		public void WritePose(float solverWeight) {} // 0x00000001896195F4-0x0000000189619624
	}

	[Serializable]
	public class IKMappingLimb : IKMapping // TypeDefIndex: 52698
	{
		// Fields
		public Transform parentBone; // 0x10
		public Transform bone1; // 0x18
		public Transform bone2; // 0x20
		public Transform bone3; // 0x28
		[Range(0f, 1f)]
		public float maintainRotationWeight; // 0x30
		[Range(0f, 1f)]
		public float weight; // 0x34
		[NonSerialized]
		public bool updatePlaneRotations; // 0x38
		private BoneMap boneMapParent; // 0x40
		private BoneMap boneMap1; // 0x48
		private BoneMap boneMap2; // 0x50
		private BoneMap boneMap3; // 0x58
	
		// Nested types
		[Serializable]
		public enum BoneMapType // TypeDefIndex: 52697
		{
			Parent = 0,
			Bone1 = 1,
			Bone2 = 2,
			Bone3 = 3
		}
	
		// Constructors
		public IKMappingLimb() {} // 0x000000018961A230-0x000000018961A3A4
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null) {} // 0x000000018961A3A4-0x000000018961A584
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message) => default; // 0x0000000189619B80-0x0000000189619C10
		public BoneMap GetBoneMap(BoneMapType boneMap) => default; // 0x00000001896197EC-0x000000018961988C
		public void SetLimbOrientation(Vector3 upper, Vector3 lower) {} // 0x0000000189619CD4-0x000000018961A01C
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null) {} // 0x0000000189619C8C-0x0000000189619CD4
		public void StoreDefaultLocalState() {} // 0x000000018961A01C-0x000000018961A0B8
		public void FixTransforms() {} // 0x0000000189619744-0x00000001896197EC
		public override void Initiate(IKSolverFullBody solver) {} // 0x000000018961988C-0x0000000189619B80
		public void ReadPose() {} // 0x0000000189619C10-0x0000000189619C8C
		public void WritePose(IKSolverFullBody solver, bool fullBody) {} // 0x000000018961A0B8-0x000000018961A230
	}

	[Serializable]
	public class IKMappingSpine : IKMapping // TypeDefIndex: 52699
	{
		// Fields
		public Transform[] spineBones; // 0x10
		public Transform leftUpperArmBone; // 0x18
		public Transform rightUpperArmBone; // 0x20
		public Transform leftThighBone; // 0x28
		public Transform rightThighBone; // 0x30
		[Range(1f, 3f)]
		public int iterations; // 0x38
		[Range(0f, 1f)]
		public float twistWeight; // 0x3C
		private int rootNodeIndex; // 0x40
		private BoneMap[] spine; // 0x48
		private BoneMap leftUpperArm; // 0x50
		private BoneMap rightUpperArm; // 0x58
		private BoneMap leftThigh; // 0x60
		private BoneMap rightThigh; // 0x68
		private bool useFABRIK; // 0x70
	
		// Constructors
		public IKMappingSpine() {} // 0x000000018961BFE0-0x000000018961C180
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) {} // 0x000000018961BDC8-0x000000018961BFE0
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message) => default; // 0x000000018961B004-0x000000018961B2D8
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) {} // 0x0000000187D6BBD4-0x0000000187D6BC30
		public void StoreDefaultLocalState() {} // 0x000000018961B968-0x000000018961B9BC
		public void FixTransforms() {} // 0x000000018961A6A8-0x000000018961A714
		public override void Initiate(IKSolverFullBody solver) {} // 0x000000018961A868-0x000000018961B004
		private bool UseFABRIK() => default; // 0x000000018961B9BC-0x000000018961B9E8
		public void ReadPose() {} // 0x000000018961B64C-0x000000018961B968
		public void WritePose(IKSolverFullBody solver) {} // 0x000000018961B9E8-0x000000018961BDC8
		public void ForwardReach(Vector3 position) {} // 0x000000018961A714-0x000000018961A868
		private void BackwardReach(Vector3 position) {} // 0x000000018961A584-0x000000018961A6A8
		private void MapToSolverPositions(IKSolverFullBody solver) {} // 0x000000018961B2D8-0x000000018961B64C
	}

	[Serializable]
	public abstract class IKSolver // TypeDefIndex: 52705
	{
		// Fields
		[HideInInspector]
		public bool executedInEditor; // 0x10
		[HideInInspector]
		public Vector3 IKPosition; // 0x14
		[Range(0f, 1f)]
		[Tooltip("The positional or the master weight of the solver.")]
		public float IKPositionWeight; // 0x20
		public UpdateDelegate OnPreInitiate; // 0x28
		public UpdateDelegate OnPostInitiate; // 0x30
		public UpdateDelegate OnPreUpdate; // 0x38
		public UpdateDelegate OnPostUpdate; // 0x40
		protected bool firstInitiation; // 0x48
		[HideInInspector]
		[SerializeField]
		protected Transform root; // 0x50
	
		// Properties
		public bool initiated { get; private set; } // 0x0000000183D4F090-0x0000000183D4F0A0 0x0000000183D4F0A0-0x0000000183D4F0B0
	
		// Nested types
		[Serializable]
		public class Point // TypeDefIndex: 52700
		{
			// Fields
			public Transform transform; // 0x10
			[Range(0f, 1f)]
			public float weight; // 0x18
			public Vector3 solverPosition; // 0x1C
			public Quaternion solverRotation; // 0x28
			public Vector3 defaultLocalPosition; // 0x38
			public Quaternion defaultLocalRotation; // 0x44
	
			// Constructors
			public Point() {} // 0x00000001829ED9A0-0x00000001829ED9D0
	
			// Methods
			public void StoreDefaultLocalState() {} // 0x00000001829EF5B0-0x00000001829EF630
			public void FixTransform() {} // 0x000000018251A6B0-0x000000018251A850
			public void UpdateSolverPosition() {} // 0x000000018961EA84-0x000000018961EAC0
			public void UpdateSolverLocalPosition() {} // 0x000000018961E9EC-0x000000018961EA28
			public void UpdateSolverState() {} // 0x000000018961EAC0-0x000000018961EB1C
			public void UpdateSolverLocalState() {} // 0x000000018961EA28-0x000000018961EA84
		}
	
		[Serializable]
		public class Bone : Point // TypeDefIndex: 52701
		{
			// Fields
			public float length; // 0x58
			public float sqrMag; // 0x5C
			public Vector3 axis; // 0x60
			private RotationLimit _rotationLimit; // 0x70
			private bool isLimited; // 0x78
	
			// Properties
			public RotationLimit rotationLimit { get => default; set {} } // 0x00000001829EFAA0-0x00000001829EFB90 0x000000018960F0D0-0x000000018960F130
	
			// Constructors
			public Bone() {} // 0x00000001829ED940-0x00000001829ED9A0
			public Bone(Transform transform) {} // 0x000000018960F060-0x000000018960F0D0
			public Bone(Transform transform, float weight) {} // 0x000000018960EFDC-0x000000018960F060
	
			// Methods
			public void Swing(Vector3 swingTarget, float weight = 1f /* Metadata: 0x01FD2B2A */) {} // 0x000000018960EDD8-0x000000018960EFDC
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x01FD2B2E */) {} // 0x000000018960E9E0-0x000000018960EC08
			public void Swing2D(Vector3 swingTarget, float weight = 1f /* Metadata: 0x01FD2B32 */) {} // 0x000000018960EC08-0x000000018960EDD8
			public void SetToSolverPosition() {} // 0x000000018960E9A4-0x000000018960E9E0
		}
	
		[Serializable]
		public class Node : Point // TypeDefIndex: 52702
		{
			// Fields
			public float length; // 0x58
			public float effectorPositionWeight; // 0x5C
			public float effectorRotationWeight; // 0x60
			public Vector3 offset; // 0x64
	
			// Constructors
			public Node() {} // 0x000000018961E9A0-0x000000018961E9A8
			public Node(Transform transform) {} // 0x000000018961E970-0x000000018961E9A0
			public Node(Transform transform, float weight) {} // 0x000000018961E9A8-0x000000018961E9EC
		}
	
		public delegate void UpdateDelegate(); // TypeDefIndex: 52703; 0x00000001842BE03C-0x00000001842BE04C
	
		public delegate void IterationDelegate(int i); // TypeDefIndex: 52704; 0x0000000182149960-0x0000000182149970
	
		// Constructors
		protected IKSolver() {} // 0x0000000183D74A90-0x0000000183D74AA0
	
		// Methods
		public bool IsValid() => default; // 0x000000018961E02C-0x000000018961E080
		public abstract bool IsValid(ref string message);
		public void Initiate(Transform root) {} // 0x000000018270B4B0-0x000000018270B5D0
		public void Update() {} // 0x000000018238E920-0x000000018238E980
		public virtual Vector3 GetIKPosition() => default; // 0x0000000181176980-0x00000001811769A0
		public void SetIKPosition(Vector3 position) {} // 0x0000000183D6E520-0x0000000183D6E530
		public float GetIKPositionWeight() => default; // 0x0000000183D4F2E0-0x0000000183D4F2F0
		public void SetIKPositionWeight(float weight) {} // 0x000000018961E408-0x000000018961E42C
		public Transform GetRoot() => default; // 0x0000000183D4EAF0-0x0000000183D4EB00
		public abstract Point[] GetPoints();
		public abstract Point GetPoint(Transform transform);
		public abstract void FixTransforms();
		public abstract void StoreDefaultLocalState();
		protected abstract void OnInitiate();
		protected abstract void OnUpdate();
		protected void LogWarning(string message) {} // 0x000000018961E080-0x000000018961E098
		public static Transform ContainsDuplicateBone(Bone[] bones) => default; // 0x00000001829EF470-0x00000001829EF560
		public static bool HierarchyIsValid(Bone[] bones) => default; // 0x00000001829EE840-0x00000001829EE8C0
		protected static float PreSolveBones(ref Bone[] bones) => default; // 0x000000018961E098-0x000000018961E408
	}

	[Serializable]
	public class IKSolverAim : IKSolverHeuristic // TypeDefIndex: 52706
	{
		// Fields
		public Transform transform; // 0x88
		public Vector3 axis; // 0x90
		public Vector3 poleAxis; // 0x9C
		public Vector3 polePosition; // 0xA8
		[Range(0f, 1f)]
		public float poleWeight; // 0xB4
		public Transform poleTarget; // 0xB8
		[Range(0f, 1f)]
		public float clampWeight; // 0xC0
		[Range(0f, 2f)]
		public int clampSmoothing; // 0xC4
		public IterationDelegate OnPreIteration; // 0xC8
		private float step; // 0xD0
		private Vector3 clampedIKPosition; // 0xD4
		private RotationLimit transformLimit; // 0xE0
		private Transform lastTransform; // 0xE8
	
		// Properties
		public Vector3 transformAxis { get => default; } // 0x000000018961CE10-0x000000018961CE94 
		public Vector3 transformPoleAxis { get => default; } // 0x000000018961CE94-0x000000018961CF18 
		protected override int minBones { get => default; } // 0x0000000181168950-0x0000000181168960 
		protected override Vector3 localDirection { get => default; } // 0x000000018961CD60-0x000000018961CE10 
	
		// Constructors
		public IKSolverAim() {} // 0x00000001829ED550-0x00000001829ED5B0
	
		// Methods
		public float GetAngle() => default; // 0x000000018961C27C-0x000000018961C348
		protected override void OnInitiate() {} // 0x00000001829EE1E0-0x00000001829EE360
		protected override void OnUpdate() {} // 0x0000000182ED2CE0-0x0000000182ED2FF0
		private void Solve() {} // 0x000000018961CC4C-0x000000018961CD60
		private Vector3 GetClampedIKPosition() => default; // 0x000000018961C348-0x000000018961C71C
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight) {} // 0x000000018961C71C-0x000000018961CC4C
	}

	[Serializable]
	public class IKSolverArm : IKSolver // TypeDefIndex: 52707
	{
		// Fields
		[Range(0f, 1f)]
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
		public IKSolverArm() {} // 0x000000018961DE34-0x000000018961E02C
	
		// Methods
		public override bool IsValid(ref string message) => default; // 0x000000018961D1EC-0x000000018961D4E8
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root) => default; // 0x000000018961DA54-0x000000018961DB04
		public override Point[] GetPoints() => default; // 0x000000018961D0E8-0x000000018961D1EC
		public override Point GetPoint(Transform transform) => default; // 0x000000018961CF7C-0x000000018961D0E8
		public override void StoreDefaultLocalState() {} // 0x000000018961DB84-0x000000018961DBE4
		public override void FixTransforms() {} // 0x000000018961CF18-0x000000018961CF7C
		protected override void OnInitiate() {} // 0x000000018961D4E8-0x000000018961D564
		protected override void OnUpdate() {} // 0x000000018961D564-0x000000018961D590
		private void Solve() {} // 0x000000018961DB04-0x000000018961DB84
		private void Read() {} // 0x000000018961D590-0x000000018961DA54
		private void Write() {} // 0x000000018961DBE4-0x000000018961DE34
	}

	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic // TypeDefIndex: 52708
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
	
		// Constructors
		public IKSolverCCD() {} // 0x0000000189620C9C-0x0000000189620CA4
	
		// Methods
		public void FadeOutBoneWeights() {} // 0x0000000189620174-0x000000018962020C
		protected override void OnInitiate() {} // 0x000000018962020C-0x0000000189620288
		protected override void OnUpdate() {} // 0x0000000189620288-0x0000000189620540
		protected void Solve(Vector3 targetPosition) {} // 0x0000000189620540-0x0000000189620C9C
	}

	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic // TypeDefIndex: 52709
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
		private bool[] limitedBones; // 0x90
		private Vector3[] solverLocalPositions; // 0x98
	
		// Properties
		protected override bool boneLengthCanBeZero { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public IKSolverFABRIK() {} // 0x00000001829ED5B0-0x00000001829ED640
	
		// Methods
		public void SolveForward(Vector3 position) {} // 0x0000000189623518-0x00000001896235B4
		public void SolveBackward(Vector3 position) {} // 0x000000018962347C-0x0000000189623518
		public override Vector3 GetIKPosition() => default; // 0x00000001896225C0-0x000000018962265C
		protected override void OnInitiate() {} // 0x00000001829EEBF0-0x00000001829EEF50
		protected override void OnUpdate() {} // 0x00000001831AB200-0x00000001831AB250
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x00000001896235B4-0x000000018962369C
		private void OnPreSolve() {} // 0x0000000189622FB0-0x000000018962347C
		private void OnPostSolve() {} // 0x0000000189622F68-0x0000000189622FB0
		private void Solve(Vector3 targetPosition) {} // 0x000000018962369C-0x0000000189623724
		private void ForwardReach(Vector3 position) {} // 0x00000001896223E4-0x00000001896225C0
		private void SolverMove(int index, Vector3 offset) {} // 0x00000001896238B0-0x0000000189623944
		private void SolverRotate(int index, Quaternion rotation, bool recursive) {} // 0x00000001896239C8-0x0000000189623A58
		private void SolverRotateChildren(int index, Quaternion rotation) {} // 0x0000000189623944-0x00000001896239C8
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation) {} // 0x0000000189623724-0x00000001896238B0
		private Quaternion GetParentSolverRotation(int index) => default; // 0x00000001829EE450-0x00000001829EE580
		private Vector3 GetParentSolverPosition(int index) => default; // 0x00000001829EE580-0x00000001829EE6D0
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed) {
			changed = default;
			return default;
		} // 0x000000018962265C-0x0000000189622798
		private void LimitForward(int rotateBone, int limitBone) {} // 0x0000000189622798-0x0000000189622D0C
		private void BackwardReach(Vector3 position) {} // 0x00000001896223B0-0x00000001896223E4
		private void BackwardReachUnlimited(Vector3 position) {} // 0x0000000189622290-0x00000001896223B0
		private void BackwardReachLimited(Vector3 position) {} // 0x0000000189621CD4-0x0000000189622290
		private void MapToSolverPositions() {} // 0x0000000189622DFC-0x0000000189622F68
		private void MapToSolverPositionsLimited() {} // 0x0000000189622D0C-0x0000000189622DFC
	}

	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver // TypeDefIndex: 52710
	{
		// Fields
		public int iterations; // 0x58
		[Range(0f, 1f)]
		public float rootPin; // 0x5C
		public FABRIKChain[] chains; // 0x60
		private bool zeroWeightApplied; // 0x68
		private bool[] isRoot; // 0x70
		private Vector3 rootDefaultPosition; // 0x78
	
		// Constructors
		public IKSolverFABRIKRoot() {} // 0x0000000189621C7C-0x0000000189621CD4
	
		// Methods
		public override bool IsValid(ref string message) => default; // 0x00000001896212D4-0x0000000189621920
		public override void StoreDefaultLocalState() {} // 0x0000000189621BEC-0x0000000189621C7C
		public override void FixTransforms() {} // 0x0000000189620D9C-0x0000000189620E3C
		protected override void OnInitiate() {} // 0x0000000189621920-0x00000001896219F0
		private bool IsRoot(int index) => default; // 0x0000000189621244-0x00000001896212D4
		protected override void OnUpdate() {} // 0x00000001896219F0-0x0000000189621BEC
		public override Point[] GetPoints() => default; // 0x00000001896211BC-0x0000000189621244
		public override Point GetPoint(Transform transform) => default; // 0x0000000189621144-0x00000001896211BC
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain) {} // 0x0000000189620CA4-0x0000000189620D9C
		private Vector3 GetCentroid() => default; // 0x0000000189620E3C-0x0000000189621144
	}

	[Serializable]
	public class IKSolverFullBody : IKSolver // TypeDefIndex: 52711
	{
		// Fields
		[Range(0f, 10f)]
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
		public IKSolverFullBody() {} // 0x0000000189627B70-0x0000000189627C90
	
		// Methods
		public IKEffector GetEffector(Transform t) => default; // 0x0000000189626CF4-0x0000000189626DB0
		public FBIKChain GetChain(Transform transform) => default; // 0x0000000189626CB0-0x0000000189626CF4
		public int GetChainIndex(Transform transform) => default; // 0x0000000189626BAC-0x0000000189626CB0
		public Node GetNode(int chainIndex, int nodeIndex) => default; // 0x0000000189626DB0-0x0000000189626DF8
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex) {
			chainIndex = default;
			nodeIndex = default;
		} // 0x0000000189626B30-0x0000000189626BAC
		public override Point[] GetPoints() => default; // 0x0000000189626F38-0x0000000189627084
		public override Point GetPoint(Transform transform) => default; // 0x0000000189626DF8-0x0000000189626F38
		public override bool IsValid(ref string message) => default; // 0x0000000189627084-0x0000000189627234
		public override void StoreDefaultLocalState() {} // 0x00000001896279FC-0x0000000189627AB0
		public override void FixTransforms() {} // 0x0000000189626A68-0x0000000189626B30
		protected override void OnInitiate() {} // 0x0000000189627234-0x0000000189627340
		protected override void OnUpdate() {} // 0x0000000189627340-0x00000001896274A0
		protected virtual void ReadPose() {} // 0x00000001896274A0-0x00000001896276C8
		protected virtual void Solve() {} // 0x00000001896276C8-0x00000001896279FC
		protected virtual void ApplyBendConstraints() {} // 0x0000000189626A2C-0x0000000189626A68
		protected virtual void WritePose() {} // 0x0000000189627AB0-0x0000000189627B70
	}

	[Serializable]
	public enum FullBodyBipedEffector // TypeDefIndex: 52712
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
	public enum FullBodyBipedChain // TypeDefIndex: 52713
	{
		LeftArm = 0,
		RightArm = 1,
		LeftLeg = 2,
		RightLeg = 3
	}

	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 52714
	{
		// Fields
		public Transform rootNode; // 0xD0
		[Range(0f, 1f)]
		public float spineStiffness; // 0xD8
		[Range(-1f, 1f)]
		public float pullBodyVertical; // 0xDC
		[Range(-1f, 1f)]
		public float pullBodyHorizontal; // 0xE0
		private Vector3 offset; // 0xF0
	
		// Properties
		public IKEffector bodyEffector { get => default; } // 0x0000000189626850-0x000000018962685C 
		public IKEffector leftShoulderEffector { get => default; } // 0x0000000189626924-0x0000000189626934 
		public IKEffector rightShoulderEffector { get => default; } // 0x0000000189626A0C-0x0000000189626A1C 
		public IKEffector leftThighEffector { get => default; } // 0x0000000189626934-0x0000000189626944 
		public IKEffector rightThighEffector { get => default; } // 0x0000000189626A1C-0x0000000189626A2C 
		public IKEffector leftHandEffector { get => default; } // 0x00000001896268C0-0x00000001896268D0 
		public IKEffector rightHandEffector { get => default; } // 0x00000001896269A8-0x00000001896269B8 
		public IKEffector leftFootEffector { get => default; } // 0x00000001896268B0-0x00000001896268C0 
		public IKEffector rightFootEffector { get => default; } // 0x0000000189626998-0x00000001896269A8 
		public FBIKChain leftArmChain { get => default; } // 0x000000018962685C-0x0000000189626884 
		public FBIKChain rightArmChain { get => default; } // 0x0000000189626944-0x000000018962696C 
		public FBIKChain leftLegChain { get => default; } // 0x00000001896268D0-0x00000001896268F8 
		public FBIKChain rightLegChain { get => default; } // 0x00000001896269B8-0x00000001896269E0 
		public IKMappingLimb leftArmMapping { get => default; } // 0x0000000189626884-0x00000001896268B0 
		public IKMappingLimb rightArmMapping { get => default; } // 0x000000018962696C-0x0000000189626998 
		public IKMappingLimb leftLegMapping { get => default; } // 0x00000001896268F8-0x0000000189626924 
		public IKMappingLimb rightLegMapping { get => default; } // 0x00000001896269E0-0x0000000189626A0C 
		public IKMappingBone headMapping { get => default; } // 0x00000001896248FC-0x0000000189624924 
		public Vector3 pullBodyOffset { get; private set; } // 0x0000000183D74AA0-0x0000000183D74AC0 0x0000000183D74AC0-0x0000000183D74AE0
	
		// Constructors
		public IKSolverFullBodyBiped() {} // 0x0000000189626834-0x0000000189626850
	
		// Methods
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f /* Metadata: 0x01FD2B43 */) {} // 0x0000000189624FFC-0x0000000189625060
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight) {} // 0x0000000189625060-0x0000000189625114
		public FBIKChain GetChain(FullBodyBipedChain c) => default; // 0x000000018962445C-0x00000001896244DC
		public FBIKChain GetChain(FullBodyBipedEffector effector) => default; // 0x00000001896244DC-0x000000018962458C
		public IKEffector GetEffector(FullBodyBipedEffector effector) => default; // 0x000000018962458C-0x00000001896246C4
		public IKEffector GetEndEffector(FullBodyBipedChain c) => default; // 0x00000001896246C4-0x0000000189624744
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain) => default; // 0x00000001896249C4-0x0000000189624A50
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector) => default; // 0x0000000189624A50-0x0000000189624AF0
		public IKMappingSpine GetSpineMapping() => default; // 0x0000000183D4EB30-0x0000000183D4EB40
		public IKMappingBone GetHeadMapping() => default; // 0x00000001896248FC-0x0000000189624924
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb) => default; // 0x00000001896241BC-0x0000000189624244
		public override bool IsValid(ref string message) => default; // 0x0000000189624B90-0x0000000189624D24
		public void SetToReferences(BipedReferences references, Transform rootNode = null) {} // 0x00000001896253AC-0x0000000189626760
		public static Transform DetectRootNodeBone(BipedReferences references) => default; // 0x0000000189623E40-0x00000001896241BC
		public void SetLimbOrientations(BipedLimbOrientations o) {} // 0x0000000189625340-0x00000001896253AC
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation) {} // 0x0000000189625114-0x0000000189625340
		private static Transform GetLeftClavicle(BipedReferences references) => default; // 0x0000000189624924-0x00000001896249C4
		private static Transform GetRightClavicle(BipedReferences references) => default; // 0x0000000189624AF0-0x0000000189624B90
		private static bool Contains(Transform[] array, Transform transform) => default; // 0x0000000189623DA8-0x0000000189623E40
		protected override void ReadPose() {} // 0x0000000189624EF8-0x0000000189624FFC
		private void PullBody() {} // 0x0000000189624D24-0x0000000189624EF8
		private Vector3 GetBodyOffset() => default; // 0x0000000189624244-0x000000018962445C
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset) => default; // 0x0000000189624744-0x00000001896248FC
		protected override void ApplyBendConstraints() {} // 0x0000000189623A58-0x0000000189623DA8
		protected override void WritePose() {} // 0x0000000189626760-0x0000000189626834
	}

	[Serializable]
	public class IKSolverHeuristic : IKSolver // TypeDefIndex: 52715
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
		protected virtual int minBones { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		protected virtual bool boneLengthCanBeZero { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		protected virtual bool allowCommonParent { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		protected virtual Vector3 localDirection { get => default; } // 0x0000000189628490-0x00000001896285DC 
		protected float positionOffset { get => default; } // 0x00000001896285DC-0x0000000189628654 
	
		// Constructors
		public IKSolverHeuristic() {} // 0x00000001829ED640-0x00000001829ED6A0
	
		// Methods
		public bool SetChain(Transform[] hierarchy, Transform root) => default; // 0x00000001829EE6D0-0x00000001829EE7E0
		public void AddBone(Transform bone) {} // 0x0000000189627C90-0x0000000189627D94
		public override void StoreDefaultLocalState() {} // 0x00000001829EE7E0-0x00000001829EE840
		public override void FixTransforms() {} // 0x0000000189627D94-0x0000000189627DF4
		public override bool IsValid(ref string message) => default; // 0x00000001829EE8C0-0x00000001829EEBF0
		public override Point[] GetPoints() => default; // 0x0000000183D4EB30-0x0000000183D4EB40
		public override Point GetPoint(Transform transform) => default; // 0x0000000189627DF4-0x0000000189627EB0
		protected override void OnInitiate() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnUpdate() {} // 0x000000018350B670-0x000000018350B680
		protected void InitiateBones() {} // 0x00000001829EEF50-0x00000001829EF470
		protected Vector3 GetSingularityOffset() => default; // 0x0000000189627EB0-0x0000000189628200
		private bool SingularityDetected() => default; // 0x0000000189628200-0x0000000189628490
	}

	[Serializable]
	public class IKSolverLeg : IKSolver // TypeDefIndex: 52716
	{
		// Fields
		[Range(0f, 1f)]
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
		public IKSolverLeg() {} // 0x0000000189629464-0x000000018962965C
	
		// Methods
		public override bool IsValid(ref string message) => default; // 0x00000001896288C4-0x0000000189628BC0
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root) => default; // 0x000000018961DA54-0x000000018961DB04
		public override Point[] GetPoints() => default; // 0x00000001896287C0-0x00000001896288C4
		public override Point GetPoint(Transform transform) => default; // 0x0000000189628654-0x00000001896287C0
		public override void StoreDefaultLocalState() {} // 0x000000018961DB84-0x000000018961DBE4
		public override void FixTransforms() {} // 0x000000018961CF18-0x000000018961CF7C
		protected override void OnInitiate() {} // 0x0000000189628BC0-0x0000000189628C3C
		protected override void OnUpdate() {} // 0x0000000189628C3C-0x0000000189628C68
		private void Solve() {} // 0x0000000189629128-0x0000000189629214
		private void Read() {} // 0x0000000189628C68-0x0000000189629128
		private void Write() {} // 0x0000000189629214-0x0000000189629464
	}

	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric // TypeDefIndex: 52719
	{
		// Fields
		public AvatarIKGoal goal; // 0xA8
		public BendModifier bendModifier; // 0xAC
		[Range(0f, 1f)]
		public float maintainRotationWeight; // 0xB0
		[Range(0f, 1f)]
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
		private AxisDirection[] axisDirections { get => default; } // 0x00000001896296E4-0x0000000189629700 
	
		// Nested types
		[Serializable]
		public enum BendModifier // TypeDefIndex: 52717
		{
			Animation = 0,
			Target = 1,
			Parent = 2,
			Arm = 3,
			Goal = 4
		}
	
		[Serializable]
		public struct AxisDirection // TypeDefIndex: 52718
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
			} // 0x00000001825D3C30-0x00000001825D3C90
		}
	
		// Constructors
		public IKSolverLimb() {} // 0x000000018962965C-0x00000001896296E4
		public IKSolverLimb(AvatarIKGoal goal) {} // 0x00000001829ED390-0x00000001829ED430
	
		// Methods
		public void MaintainRotation() {} // 0x000000018238E980-0x000000018238E9F0
		public void MaintainBend() {} // 0x000000018238E9F0-0x000000018238EAC0
		protected override void OnInitiateVirtual() {} // 0x00000001829EF7E0-0x00000001829EFAA0
		protected override void OnUpdateVirtual() {} // 0x0000000182DD1C30-0x0000000182DD1D00
		protected override void OnPostSolveVirtual() {} // 0x0000000182F82720-0x0000000182F82770
		private void StoreAxisDirections(ref AxisDirection[] axisDirections) {} // 0x00000001825D3940-0x00000001825D3C30
		private Vector3 GetModifiedBendNormal() => default; // 0x0000000182DD1D00-0x0000000182DD1EB0
	}

	[Serializable]
	public class IKSolverLookAt : IKSolver // TypeDefIndex: 52721
	{
		// Fields
		public Transform target; // 0x58
		public LookAtBone[] spine; // 0x60
		private Quaternion[] m_spineVirtualBones; // 0x68
		public LookAtBone head; // 0x70
		private Quaternion m_headVirtualBones; // 0x78
		public LookAtBone[] eyes; // 0x88
		private Quaternion m_eyeVirtualBone; // 0x90
		[Range(0f, 1f)]
		public float bodyWeight; // 0xA0
		[Range(0f, 1f)]
		public float headWeight; // 0xA4
		[Range(0f, 1f)]
		public float eyesWeight; // 0xA8
		[Range(0f, 1f)]
		public float clampWeight; // 0xAC
		[Range(0f, 1f)]
		public float clampWeightHead; // 0xB0
		[Range(0f, 1f)]
		public float clampWeightEyes; // 0xB4
		[Range(0f, 2f)]
		public int clampSmoothing; // 0xB8
		public AnimationCurve spineWeightCurve; // 0xC0
		public Vector3 spineTargetOffset; // 0xC8
		protected Vector3[] spineForwards; // 0xD8
		protected Vector3[] headForwards; // 0xE0
		protected Vector3[] eyeForward; // 0xE8
		private bool isDirty; // 0xF0
	
		// Properties
		public Quaternion[] spineVirtualBone { get => default; set {} } // 0x0000000189629CB0-0x0000000189629DA0 0x00000001838C5570-0x00000001838C5580
		public Quaternion headVirtualBones { get => default; set {} } // 0x0000000183D58660-0x0000000183D58670 0x0000000183D6C700-0x0000000183D6C710
		public Quaternion eyeVirtualBone { get => default; set {} } // 0x0000000183D68BC0-0x0000000183D68BD0 0x0000000183D6C0C0-0x0000000183D6C0D0
		protected bool spineIsValid { get => default; } // 0x00000001829EDF20-0x00000001829EDFF0 
		protected bool spineIsEmpty { get => default; } // 0x00000001829EE060-0x00000001829EE090 
		protected bool headIsValid { get => default; } // 0x00000001829EE090-0x00000001829EE0A0 
		protected bool headIsEmpty { get => default; } // 0x00000001830EA160-0x00000001830EA240 
		protected bool eyesIsValid { get => default; } // 0x00000001829EDFF0-0x00000001829EE060 
		protected bool eyesIsEmpty { get => default; } // 0x0000000182F8DDE0-0x0000000182F8DE10 
	
		// Nested types
		[Serializable]
		public class LookAtBone : IKSolver.Bone // TypeDefIndex: 52720
		{
			// Fields
			public Vector3 positionOffset; // 0x80
			public Vector3 baseForwardOffsetEuler; // 0x8C
	
			// Properties
			public Vector3 forward { get => default; } // 0x000000018258A9F0-0x000000018258AA90 
	
			// Constructors
			public LookAtBone() {} // 0x00000001829ED920-0x00000001829ED940
			public LookAtBone(Transform transform) {} // 0x00000001829ED030-0x00000001829ED080
	
			// Methods
			public void Initiate(Transform root) {} // 0x00000001835042E0-0x0000000183504410
			public void LookAt(Vector3 direction, float weight) {} // 0x000000018258A6B0-0x000000018258A8A0
			public Quaternion LookAtReturnRotation(Vector3 direction, float weight) => default; // 0x000000018962F5D8-0x000000018962F6D4
		}
	
		// Constructors
		public IKSolverLookAt() {} // 0x00000001829ED6A0-0x00000001829ED920
	
		// Methods
		public void SetLookAtWeight(float weight) {} // 0x000000018961E408-0x000000018961E42C
		public void SetLookAtWeight(float weight, float bodyWeight) {} // 0x0000000189629A0C-0x0000000189629A54
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) {} // 0x0000000189629AFC-0x0000000189629B60
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) {} // 0x0000000189629C38-0x0000000189629CB0
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) {} // 0x0000000189629A54-0x0000000189629AFC
		public void SetLookAtWeight(float weight, float bodyWeight = 0f /* Metadata: 0x01FD2B4C */, float headWeight = 1f /* Metadata: 0x01FD2B50 */, float eyesWeight = 0.5f /* Metadata: 0x01FD2B54 */, float clampWeight = 0.5f /* Metadata: 0x01FD2B58 */, float clampWeightHead = 0.5f /* Metadata: 0x01FD2B5C */, float clampWeightEyes = 0.3f /* Metadata: 0x01FD2B60 */) {} // 0x0000000189629B60-0x0000000189629C38
		public override void StoreDefaultLocalState() {} // 0x00000001829EE360-0x00000001829EE450
		public void SetDirty() {} // 0x0000000183D74AE0-0x0000000183D74AF0
		public override void FixTransforms() {} // 0x00000001831265D0-0x0000000183126620
		public override bool IsValid(ref string message) => default; // 0x00000001829EE0A0-0x00000001829EE1E0
		public override Point[] GetPoints() => default; // 0x0000000189629838-0x0000000189629A0C
		public override Point GetPoint(Transform transform) => default; // 0x0000000189629700-0x0000000189629838
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root) => default; // 0x00000001829ECE70-0x00000001829ECF40
		protected override void OnInitiate() {} // 0x0000000183504070-0x00000001835042E0
		protected override void OnUpdate() {} // 0x0000000182F8DBD0-0x0000000182F8DD30
		protected void SolveSpine() {} // 0x0000000182589FC0-0x000000018258A520
		protected void SolveHead() {} // 0x00000001825897A0-0x0000000182589FC0
		protected void SolveEyes() {} // 0x0000000182F8DD30-0x0000000182F8DDE0
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp) => default; // 0x0000000182E4E8C0-0x0000000182E4E9B0
		protected void SetBones(Transform[] array, ref LookAtBone[] bones) {} // 0x00000001829ECF40-0x00000001829ED030
	}

	[Serializable]
	public class IKSolverTrigonometric : IKSolver // TypeDefIndex: 52723
	{
		// Fields
		public Transform target; // 0x58
		[Range(0f, 1f)]
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
		public class TrigonometricBone : IKSolver.Bone // TypeDefIndex: 52722
		{
			// Fields
			private Quaternion targetToLocalSpace; // 0x80
			private Vector3 defaultLocalBendNormal; // 0x90
	
			// Constructors
			public TrigonometricBone() {} // 0x00000001842726F4-0x0000000184272700
	
			// Methods
			public void Initiate(Vector3 childPosition, Vector3 bendNormal) {} // 0x0000000182B22AD0-0x0000000182B22CC0
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal) => default; // 0x000000018258A520-0x000000018258A5E0
			public Vector3 GetBendNormalFromCurrentRotation() => default; // 0x000000018238EAC0-0x000000018238EB70
		}
	
		// Constructors
		public IKSolverTrigonometric() {} // 0x00000001829ED430-0x00000001829ED550
	
		// Methods
		public void SetBendGoalPosition(Vector3 goalPosition, float weight) {} // 0x000000018962A118-0x000000018962A324
		public void SetBendPlaneToCurrent() {} // 0x0000000182B229A0-0x0000000182B229D0
		public void SetIKRotation(Quaternion rotation) {} // 0x0000000183D74B00-0x0000000183D74B10
		public void SetIKRotationWeight(float weight) {} // 0x000000018962A324-0x000000018962A348
		public Quaternion GetIKRotation() => default; // 0x0000000183D74AF0-0x0000000183D74B00
		public float GetIKRotationWeight() => default; // 0x0000000183D50D50-0x0000000183D50D60
		public override Point[] GetPoints() => default; // 0x000000018962A054-0x000000018962A118
		public override Point GetPoint(Transform transform) => default; // 0x0000000189629F5C-0x000000018962A054
		public override void StoreDefaultLocalState() {} // 0x00000001829EF560-0x00000001829EF5B0
		public override void FixTransforms() {} // 0x000000018251A850-0x000000018251AEA0
		public override bool IsValid(ref string message) => default; // 0x00000001829F0700-0x00000001829F0AD0
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root) => default; // 0x00000001829EDEA0-0x00000001829EDF20
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight) {} // 0x000000018962A348-0x000000018962A82C
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) => default; // 0x0000000189629DA0-0x0000000189629F5C
		protected override void OnInitiate() {} // 0x0000000182B228B0-0x0000000182B229A0
		private bool IsDirectHierarchy() => default; // 0x0000000182B22790-0x0000000182B228B0
		public void InitiateBones() {} // 0x0000000182B229D0-0x0000000182B22AD0
		protected override void OnUpdate() {} // 0x000000018238FE90-0x00000001823908C0
		protected virtual void OnInitiateVirtual() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnUpdateVirtual() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnPostSolveVirtual() {} // 0x000000018350B670-0x000000018350B680
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal) => default; // 0x00000001825893E0-0x0000000182589740
	}

	[Serializable]
	public class IKSolverVR : IKSolver // TypeDefIndex: 52735
	{
		// Fields
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
		[Range(0f, 2f)]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		public int LOD; // 0xD0
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale; // 0xD4
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet; // 0xD8
		[Tooltip("The spine solver.")]
		public Spine spine; // 0xE8
		[Tooltip("The left arm solver.")]
		public Arm leftArm; // 0xF0
		[Tooltip("The right arm solver.")]
		public Arm rightArm; // 0xF8
		[Tooltip("The left leg solver.")]
		public Leg leftLeg; // 0x100
		[Tooltip("The right leg solver.")]
		public Leg rightLeg; // 0x108
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
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
		public Animator animator { get; private set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		[HideInInspector]
		public VirtualBone rootBone { get; private set; } // 0x0000000183D51140-0x0000000183D51150 0x000000018589D964-0x000000018589D978
	
		// Nested types
		[Serializable]
		public class Arm : BodyPart // TypeDefIndex: 52725
		{
			// Fields
			[LargeHeader("Hand")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust its position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar\'s hand as it it was held by the avatar, duplicate the avatar\'s hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target; // 0x48
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight; // 0x50
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight; // 0x54
			[LargeHeader("Shoulder")]
			[Range(0f, 1f)]
			[Tooltip("The weight of shoulder rotation")]
			public float shoulderRotationWeight; // 0x58
			[ShowIf("shoulderRotationWeight", 0f, 1F / 0F, false, ShowIfMode.Hidden)]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode; // 0x5C
			[ShowRangeIf(0f, 1f, "shoulderRotationWeight", 0f, 1F / 0F, false, ShowIfMode.Hidden)]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			public float shoulderTwistWeight; // 0x60
			[ShowIf("shoulderRotationWeight", 0f, 1F / 0F, false, ShowIfMode.Hidden)]
			[Tooltip("Tweak this value to adjust shoulder rotation around the yaw (up) axis.")]
			public float shoulderYawOffset; // 0x64
			[ShowIf("shoulderRotationWeight", 0f, 1F / 0F, false, ShowIfMode.Hidden)]
			[Tooltip("Tweak this value to adjust shoulder rotation around the pitch (forward) axis.")]
			public float shoulderPitchOffset; // 0x68
			[LargeHeader("Bending")]
			[Tooltip("The elbow will be bent towards this Transform if \'Bend Goal Weight\' > 0.")]
			public Transform bendGoal; // 0x70
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the \'Bend Goal\' Transform.")]
			public float bendGoalWeight; // 0x78
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset; // 0x7C
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select \'Guess Hand Orientations\' from the context menu.")]
			public Vector3 wristToPalmAxis; // 0x80
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select \'Guess Hand Orientations\' from the context menu.")]
			public Vector3 palmToThumbAxis; // 0x8C
			[LargeHeader("Stretching")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			public float armLengthMlp; // 0x98
			[Tooltip("\'Time\' represents (target distance / arm length) and \'value\' represents the amount of stretching. So value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right by the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the \'VRIK (Basic)\' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve; // 0xA0
			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPosition; // 0xA8
			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotation; // 0xB4
			[NonSerialized]
			[HideInInspector]
			public Vector3 bendDirection; // 0xC4
			[NonSerialized]
			[HideInInspector]
			public Vector3 handPositionOffset; // 0xD0
			private bool hasShoulder; // 0xF8
			private Vector3 chestForwardAxis; // 0xFC
			private Vector3 chestUpAxis; // 0x108
			private Quaternion chestRotation; // 0x114
			private Vector3 chestForward; // 0x124
			private Vector3 chestUp; // 0x130
			private Quaternion forearmRelToUpperArm; // 0x13C
			private Vector3 upperArmBendAxis; // 0x14C
	
			// Properties
			public Vector3 position { get; private set; } // 0x0000000183D74B10-0x0000000183D74B30 0x0000000183D74B30-0x0000000183D74B50
			public Quaternion rotation { get; private set; } // 0x0000000183D6B980-0x0000000183D6B990 0x0000000183D74B50-0x0000000183D74B60
			private VirtualBone shoulder { get => default; } // 0x0000000189632D88-0x0000000189632DB0 
			private VirtualBone upperArm { get => default; } // 0x0000000189632DB0-0x0000000189632DF8 
			private VirtualBone forearm { get => default; } // 0x0000000189632CF0-0x0000000189632D3C 
			private VirtualBone hand { get => default; } // 0x0000000189632D3C-0x0000000189632D88 
	
			// Nested types
			[Serializable]
			public enum ShoulderRotationMode // TypeDefIndex: 52724
			{
				YawPitch = 0,
				FromTo = 1
			}
	
			// Constructors
			public Arm() {} // 0x0000000189632BB8-0x0000000189632CF0
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) {} // 0x000000018962FDD0-0x00000001896307D0
			public override void PreSolve(float scale) {} // 0x00000001896307D0-0x00000001896309FC
			public override void ApplyOffsets(float scale) {} // 0x000000018962F6D4-0x000000018962F73C
			private void Stretching() {} // 0x00000001896323A0-0x0000000189632860
			public void Solve(bool isLeft) {} // 0x0000000189630A18-0x00000001896323A0
			public override void ResetOffsets() {} // 0x00000001896309FC-0x0000000189630A18
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) {} // 0x0000000189632978-0x0000000189632BB8
			private float DamperValue(float value, float min, float max, float weight = 1f /* Metadata: 0x01FD2B64 */) => default; // 0x000000018962F73C-0x000000018962F7E4
			private Vector3 GetBendNormal(Vector3 dir) => default; // 0x000000018962F7E4-0x000000018962FDD0
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, UnityEngine.Color color) {} // 0x0000000189632860-0x0000000189632978
		}
	
		[Serializable]
		public abstract class BodyPart // TypeDefIndex: 52726
		{
			// Fields
			[HideInInspector]
			public VirtualBone[] bones; // 0x18
			protected bool initiated; // 0x20
			protected Vector3 rootPosition; // 0x24
			protected Quaternion rootRotation; // 0x30
			protected int index; // 0x40
			protected int LOD; // 0x44
	
			// Properties
			public float sqrMag { get; private set; } // 0x0000000183D4E7A0-0x0000000183D4E7B0 0x0000000183D50CA0-0x0000000183D50CB0
			public float mag { get; private set; } // 0x0000000183D51930-0x0000000183D51940 0x0000000183D51940-0x0000000183D51950
	
			// Constructors
			protected BodyPart() {} // 0x00000001896334B8-0x0000000189633518
	
			// Methods
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);
			public abstract void PreSolve(float scale);
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);
			public abstract void ApplyOffsets(float scale);
			public abstract void ResetOffsets();
			public void SetLOD(int LOD) {} // 0x0000000183D4EEA0-0x0000000183D4EEB0
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) {} // 0x0000000189632F98-0x00000001896330A0
			public void MovePosition(Vector3 position) {} // 0x0000000189632DF8-0x0000000189632EDC
			public void MoveRotation(Quaternion rotation) {} // 0x0000000189632EDC-0x0000000189632F98
			public void Translate(Vector3 position, Quaternion rotation) {} // 0x000000018963331C-0x0000000189633370
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot) {} // 0x00000001896331C0-0x000000018963331C
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f /* Metadata: 0x01FD2B6A */) {} // 0x00000001896330A0-0x00000001896331C0
			public void Visualize(UnityEngine.Color color) {} // 0x0000000189633370-0x0000000189633488
			public void Visualize() {} // 0x0000000189633488-0x00000001896334B8
		}
	
		[Serializable]
		public class Footstep // TypeDefIndex: 52727
		{
			// Fields
			public float stepSpeed; // 0x10
			public Vector3 characterSpaceOffset; // 0x14
			public Vector3 position; // 0x20
			public Quaternion rotation; // 0x2C
			public Quaternion stepToRootRot; // 0x3C
			public bool isSupportLeg; // 0x4C
			public bool relaxFlag; // 0x4D
			public Vector3 stepFrom; // 0x54
			public Vector3 stepTo; // 0x60
			public Quaternion stepFromRot; // 0x6C
			public Quaternion stepToRot; // 0x7C
			private Quaternion footRelativeToRoot; // 0x8C
			private float supportLegW; // 0x9C
			private float supportLegWV; // 0xA0
	
			// Properties
			public bool isStepping { get => default; } // 0x0000000189633AC4-0x0000000189633AD4 
			public float stepProgress { get; private set; } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
	
			// Constructors
			public Footstep() {} // Dummy constructor
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset) {} // 0x00000001896339A0-0x0000000189633AC4
	
			// Methods
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation) {} // 0x0000000183D74B60-0x0000000183D74BB0
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold) {} // 0x0000000189633518-0x0000000189633640
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime) {} // 0x0000000189633738-0x000000018963384C
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime) {} // 0x0000000189633640-0x0000000189633738
			public void Update(RootMotion.InterpolationMode interpolation, UnityEvent onStep, float deltaTime) {} // 0x000000018963384C-0x00000001896339A0
		}
	
		[Serializable]
		public class Leg : BodyPart // TypeDefIndex: 52728
		{
			// Fields
			[LargeHeader("Foot/Toe")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust its position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target; // 0x48
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight; // 0x50
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight; // 0x54
			[LargeHeader("Bending")]
			[Tooltip("The knee will be bent towards this Transform if \'Bend Goal Weight\' > 0.")]
			public Transform bendGoal; // 0x58
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the knee towards the \'Bend Goal\' Transform.")]
			public float bendGoalWeight; // 0x60
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of knee bending direction.")]
			public float swivelOffset; // 0x64
			[Range(0f, 1f)]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			public float bendToTargetWeight; // 0x68
			[LargeHeader("Stretching")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			public float legLengthMlp; // 0x6C
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the \'VRIK (Basic)\' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve; // 0x70
			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPosition; // 0x78
			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotation; // 0x84
			[NonSerialized]
			[HideInInspector]
			public Vector3 footPositionOffset; // 0x94
			[NonSerialized]
			[HideInInspector]
			public Vector3 heelPositionOffset; // 0xA0
			[NonSerialized]
			[HideInInspector]
			public Quaternion footRotationOffset; // 0xAC
			[NonSerialized]
			[HideInInspector]
			public float currentMag; // 0xBC
			[HideInInspector]
			public bool useAnimatedBendNormal; // 0xC0
			private Vector3 footPosition; // 0xF0
			private Quaternion footRotation; // 0xFC
			private Vector3 bendNormal; // 0x10C
			private Quaternion calfRelToThigh; // 0x118
			private Quaternion thighRelToFoot; // 0x128
	
			// Properties
			public Vector3 position { get; private set; } // 0x0000000183D5B430-0x0000000183D5B450 0x0000000183D69480-0x0000000183D694A0
			public Quaternion rotation { get; private set; } // 0x0000000183D5B210-0x0000000183D5B220 0x0000000183D5B220-0x0000000183D5B230
			public bool hasToes { get; private set; } // 0x0000000183D58140-0x0000000183D58150 0x0000000183D59200-0x0000000183D59210
			public VirtualBone thigh { get => default; } // 0x0000000189632D88-0x0000000189632DB0 
			private VirtualBone calf { get => default; } // 0x0000000186E95EB4-0x0000000186E95EDC 
			private VirtualBone foot { get => default; } // 0x0000000189637FE4-0x000000018963800C 
			private VirtualBone toes { get => default; } // 0x000000018963803C-0x0000000189638064 
			public VirtualBone lastBone { get => default; } // 0x000000018963800C-0x000000018963803C 
			public Vector3 thighRelativeToPelvis { get; private set; } // 0x0000000183D74AA0-0x0000000183D74AC0 0x0000000183D74AC0-0x0000000183D74AE0
			public Vector3 bendNormalRelToPelvis { get; set; } // 0x0000000183D74BB0-0x0000000183D74BD0 0x0000000183D74BF0-0x0000000183D74C10
			public Vector3 bendNormalRelToTarget { get; set; } // 0x0000000183D74BD0-0x0000000183D74BF0 0x0000000183D74C10-0x0000000183D74C30
	
			// Constructors
			public Leg() {} // 0x0000000189637EF8-0x0000000189637FE4
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) {} // 0x00000001896365FC-0x0000000189636E38
			public override void PreSolve(float scale) {} // 0x0000000189636E38-0x000000018963740C
			public override void ApplyOffsets(float scale) {} // 0x0000000189635988-0x0000000189635FCC
			private void ApplyPositionOffset(Vector3 offset, float weight) {} // 0x0000000189635FCC-0x00000001896360B4
			private void ApplyRotationOffset(Quaternion offset, float weight) {} // 0x00000001896360B4-0x000000018963628C
			public void Solve(bool stretch) {} // 0x0000000189637474-0x00000001896376FC
			private void FixTwistRotations() {} // 0x000000018963628C-0x00000001896365FC
			private void Stretching() {} // 0x00000001896376FC-0x0000000189637CB4
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) {} // 0x0000000189637CB4-0x0000000189637EF8
			public override void ResetOffsets() {} // 0x000000018963740C-0x0000000189637474
		}
	
		[Serializable]
		public class Locomotion // TypeDefIndex: 52730
		{
			// Fields
			[Tooltip("Procedural (legacy) or animated locomotion.")]
			public Mode mode; // 0x10
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural/animated locomotion.")]
			public float weight; // 0x14
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Start moving (horizontal distance to HMD + HMD velocity) threshold.")]
			public float moveThreshold; // 0x18
			[SerializeField]
			[ShowLargeHeaderIf("Animation", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			private byte animationHeader; // 0x1C
			[ShowRangeIf(0.1f, 1f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Minimum locomotion animation speed.")]
			public float minAnimationSpeed; // 0x20
			[ShowRangeIf(1f, 10f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Maximum locomotion animation speed.")]
			public float maxAnimationSpeed; // 0x24
			[ShowRangeIf(0.05f, 0.2f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Smoothing time for Vector3.SmoothDamping \'VRIK_Horizontal\' and \'VRIK_Vertical\' parameters. Larger values make animation smoother, but less responsive.")]
			public float animationSmoothTime; // 0x28
			[SerializeField]
			[ShowLargeHeaderIf("Root Position", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			private byte rootPositionHeader; // 0x2C
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("X and Z standing offset from the horizontal position of the HMD.")]
			public Vector2 standOffset; // 0x30
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while moving.")]
			public float rootLerpSpeedWhileMoving; // 0x38
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while in transition from locomotion to idle state.")]
			public float rootLerpSpeedWhileStopping; // 0x3C
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while turning on spot.")]
			public float rootLerpSpeedWhileTurning; // 0x40
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Max horizontal distance from the root to the HMD.")]
			public float maxRootOffset; // 0x44
			[SerializeField]
			[ShowLargeHeaderIf("Root Rotation", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			private byte rootRotationHeader; // 0x48
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Max root angle from head forward while moving (ik.solver.spine.maxRootAngle).")]
			public float maxRootAngleMoving; // 0x4C
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Max root angle from head forward while standing (ik.solver.spine.maxRootAngle.")]
			public float maxRootAngleStanding; // 0x50
			[HideInInspector]
			[SerializeField]
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
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance; // 0xD0
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the \'Angle Threshold\'.")]
			public float stepThreshold; // 0xD4
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Makes a step only if step target position is at least \'Step Threshold\' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold; // 0xD8
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp; // 0xDC
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity; // 0xE0
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor; // 0xE4
			[ShowRangeIf(0.9f, 1f, "mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch; // 0xE8
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed; // 0xEC
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed; // 0xF0
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight; // 0xF8
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Reduce this value if locomotion makes the head bob too much.")]
			public float maxBodyYOffset; // 0x100
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight; // 0x108
			[ShowRangeIf(0f, 180f, "mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			public float relaxLegTwistMinAngle; // 0x110
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed; // 0x114
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Interpolation mode of the step.")]
			public RootMotion.InterpolationMode stepInterpolation; // 0x118
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset; // 0x11C
			[HideInInspector]
			public bool blockingEnabled; // 0x128
			[HideInInspector]
			public LayerMask blockingLayers; // 0x12C
			[HideInInspector]
			public float raycastRadius; // 0x130
			[HideInInspector]
			public float raycastHeight; // 0x134
			[HideInInspector]
			[SerializeField]
			public UnityEvent onLeftFootstep; // 0x138
			[HideInInspector]
			[SerializeField]
			public UnityEvent onRightFootstep; // 0x140
			private Footstep[] footsteps; // 0x158
			private Vector3 lastComPosition; // 0x160
			private Vector3 comVelocity; // 0x16C
			private int leftFootIndex; // 0x178
			private int rightFootIndex; // 0x17C
	
			// Properties
			public Vector3 centerOfMass { get; private set; } // 0x0000000183D5B7F0-0x0000000183D5B810 0x0000000183D5B8B0-0x0000000183D5B8D0
			public Vector3 leftFootstepPosition { get => default; } // 0x000000018963C298-0x000000018963C2DC 
			public Vector3 rightFootstepPosition { get => default; } // 0x000000018963C31C-0x000000018963C360 
			public Quaternion leftFootstepRotation { get => default; } // 0x000000018963C2DC-0x000000018963C31C 
			public Quaternion rightFootstepRotation { get => default; } // 0x000000018963C360-0x000000018963C3A0 
	
			// Nested types
			[Serializable]
			public enum Mode // TypeDefIndex: 52729
			{
				Procedural = 0,
				Animated = 1
			}
	
			// Constructors
			public Locomotion() {} // 0x000000018963C0EC-0x000000018963C298
	
			// Methods
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale) {} // 0x0000000189638F7C-0x0000000189638FDC
			public void Reset(Vector3[] positions, Quaternion[] rotations) {} // 0x00000001896395E4-0x0000000189639614
			public void Relax() {} // 0x0000000189639030-0x0000000189639038
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot) {} // 0x0000000189638988-0x0000000189638A0C
			public void AddDeltaPosition(Vector3 delta) {} // 0x00000001896382F0-0x000000018963834C
			public void Initiate_Animated(Animator animator, Vector3[] positions) {} // 0x0000000189638BFC-0x0000000189638CB0
			private void ResetParams(Vector3[] positions) {} // 0x0000000189639038-0x00000001896390F8
			public void Reset_Animated(Vector3[] positions) {} // 0x00000001896390F8-0x0000000189639348
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot) {} // 0x000000018963834C-0x0000000189638574
			private void AddDeltaPosition_Animated(Vector3 delta) {} // 0x0000000189638064-0x0000000189638168
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime) {} // 0x0000000189639614-0x000000018963A620
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale) {} // 0x0000000189638CB0-0x0000000189638F7C
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations) {} // 0x0000000189639348-0x00000001896395E4
			private void Relax_Procedural() {} // 0x0000000189638FDC-0x0000000189639030
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot) {} // 0x0000000189638574-0x0000000189638988
			private void AddDeltaPosition_Procedural(Vector3 delta) {} // 0x0000000189638168-0x00000001896382F0
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime) {
				leftFootPosition = default;
				rightFootPosition = default;
				leftFootRotation = default;
				rightFootRotation = default;
				leftFootOffset = default;
				rightFootOffset = default;
				leftHeelOffset = default;
				rightHeelOffset = default;
			} // 0x000000018963A620-0x000000018963BF60
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition) => default; // 0x000000018963BF60-0x000000018963C0EC
			private bool CanStep() => default; // 0x0000000189638A0C-0x0000000189638A6C
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius) => default; // 0x0000000189638A6C-0x0000000189638BFC
		}
	
		[Serializable]
		public class Spine : BodyPart // TypeDefIndex: 52731
		{
			// Fields
			[LargeHeader("Head")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust its position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar\'s eyes, duplicate the avatar\'s head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget; // 0x48
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			public float positionWeight; // 0x50
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			public float rotationWeight; // 0x54
			[Range(0f, 1f)]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			public float headClampWeight; // 0x58
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight; // 0x5C
			[Range(0f, 1f)]
			[Tooltip("Allows for more natural locomotion animation for 3rd person networked avatars by inheriting vertical head bob motion from the animation while head target height is close to head bone height.")]
			public float useAnimatedHeadHeightWeight; // 0x60
			[ShowIf("useAnimatedHeadHeightWeight", 0f, 1F / 0F, false, ShowIfMode.Hidden)]
			[Tooltip("If abs(head target height - head bone height) < this value, will use head bone height as head target Y.")]
			public float useAnimatedHeadHeightRange; // 0x64
			[ShowIf("useAnimatedHeadHeightWeight", 0f, 1F / 0F, false, ShowIfMode.Hidden)]
			[Tooltip("Falloff range for the \'Use Animated Head Height Range\' effect above. If head target height from head bone height is greater than useAnimatedHeadHeightRange + animatedHeadHeightBlend, then the head will be vertically locked to the head target again.")]
			public float animatedHeadHeightBlend; // 0x68
			[LargeHeader("Pelvis")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar\'s pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget; // 0x70
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			public float pelvisPositionWeight; // 0x78
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			public float pelvisRotationWeight; // 0x7C
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain its animated position?")]
			public float maintainPelvisPosition; // 0x80
			[LargeHeader("Chest")]
			[Tooltip("If \'Chest Goal Weight\' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal; // 0x88
			[Range(0f, 1f)]
			[Tooltip("Weight of turning the chest towards the \'Chest Goal\'.")]
			public float chestGoalWeight; // 0x90
			[Range(0f, 1f)]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			public float chestClampWeight; // 0x94
			[Range(0f, 1f)]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			public float rotateChestByHands; // 0x98
			[LargeHeader("Spine")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			public float bodyPosStiffness; // 0x9C
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			public float bodyRotStiffness; // 0xA0
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			public float neckStiffness; // 0xA4
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching; // 0xA8
			[LargeHeader("Root Rotation")]
			[Range(0f, 180f)]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			public float maxRootAngle; // 0xAC
			[Range(-180f, 180f)]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			public float rootHeadingOffset; // 0xB0
			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPositionHead; // 0xB4
			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotationHead; // 0xC0
			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPositionPelvis; // 0xD0
			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotationPelvis; // 0xDC
			[NonSerialized]
			[HideInInspector]
			public Vector3 goalPositionChest; // 0xEC
			[NonSerialized]
			[HideInInspector]
			public Vector3 pelvisPositionOffset; // 0xF8
			[NonSerialized]
			[HideInInspector]
			public Vector3 chestPositionOffset; // 0x104
			[NonSerialized]
			[HideInInspector]
			public Vector3 headPositionOffset; // 0x110
			[NonSerialized]
			[HideInInspector]
			public Quaternion pelvisRotationOffset; // 0x11C
			[NonSerialized]
			[HideInInspector]
			public Quaternion chestRotationOffset; // 0x12C
			[NonSerialized]
			[HideInInspector]
			public Quaternion headRotationOffset; // 0x13C
			[NonSerialized]
			[HideInInspector]
			public Vector3 faceDirection; // 0x14C
			[NonSerialized]
			[HideInInspector]
			internal Vector3 headPosition; // 0x158
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
			internal VirtualBone pelvis { get => default; } // 0x000000018963FEC4-0x000000018963FEF4 
			internal VirtualBone firstSpineBone { get => default; } // 0x000000018963FE34-0x000000018963FE64 
			internal VirtualBone chest { get => default; } // 0x000000018963FDF0-0x000000018963FE34 
			internal VirtualBone head { get => default; } // 0x000000018963FE64-0x000000018963FE94 
			private VirtualBone neck { get => default; } // 0x000000018963FE94-0x000000018963FEC4 
			internal Quaternion anchorRotation { get; private set; } // 0x0000000183D74C40-0x0000000183D74C50 0x0000000183D74C60-0x0000000183D74C70
			internal Quaternion anchorRelativeToHead { get; private set; } // 0x0000000183D74C30-0x0000000183D74C40 0x0000000183D74C50-0x0000000183D74C60
	
			// Constructors
			public Spine() {} // 0x000000018963FC34-0x000000018963FDF0
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index) {} // 0x000000018963DA38-0x000000018963E5A0
			public override void PreSolve(float scale) {} // 0x000000018963E5A0-0x000000018963EAEC
			public override void ApplyOffsets(float scale) {} // 0x000000018963C778-0x000000018963CCDC
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms) {} // 0x000000018963D160-0x000000018963D328
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale) {} // 0x000000018963EEB8-0x000000018963F5C8
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight) {} // 0x000000018963D328-0x000000018963D54C
			private void SolvePelvis() {} // 0x000000018963EBA0-0x000000018963EEB8
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations) {} // 0x000000018963FA28-0x000000018963FC34
			public override void ResetOffsets() {} // 0x000000018963EAEC-0x000000018963EBA0
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms) {} // 0x000000018963C3A0-0x000000018963C778
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w) {} // 0x000000018963D54C-0x000000018963D6DC
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale) {} // 0x000000018963F5C8-0x000000018963FA28
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2 /* Metadata: 0x01FD2B70 */) => default; // 0x000000018963D6DC-0x000000018963DA38
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w) {} // 0x000000018963CCDC-0x000000018963CEF0
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w) {} // 0x000000018963CEF0-0x000000018963D160
		}
	
		[Serializable]
		public enum PositionOffset // TypeDefIndex: 52732
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
		public enum RotationOffset // TypeDefIndex: 52733
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2
		}
	
		[Serializable]
		public class VirtualBone // TypeDefIndex: 52734
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
			public VirtualBone(Vector3 position, Quaternion rotation) {} // 0x0000000183D74C70-0x0000000183D74CA0
	
			// Methods
			public void Read(Vector3 position, Quaternion rotation) {} // 0x0000000183D74C70-0x0000000183D74CA0
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x01FD2B7D */) {} // 0x000000018964261C-0x00000001896427E0
			public static float PreSolve(ref VirtualBone[] bones) => default; // 0x0000000189641108-0x00000001896413C0
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation) {} // 0x00000001896413C0-0x0000000189641544
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation) {} // 0x0000000189641544-0x0000000189641704
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation) {} // 0x0000000189641704-0x00000001896418BC
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation) {} // 0x00000001896418BC-0x0000000189641970
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight) {} // 0x00000001896420D4-0x000000018964261C
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) => default; // 0x0000000189640F4C-0x0000000189641108
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset) {} // 0x0000000189641C44-0x00000001896420D4
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x0000000189641B60-0x0000000189641C44
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations) {} // 0x0000000189641970-0x0000000189641B60
		}
	
		// Constructors
		public IKSolverVR() {} // 0x000000018962F2C0-0x000000018962F5D8
	
		// Methods
		public void SetToReferences(VRIK.References references) {} // 0x000000018962CEC0-0x000000018962D1C4
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero) {} // 0x000000018962BCBC-0x000000018962C008
		public void DefaultAnimationCurves() {} // 0x000000018962ADD0-0x000000018962AF88
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value) {} // 0x000000018962A978-0x000000018962AC84
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value) {} // 0x000000018962AC84-0x000000018962ACDC
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value) {} // 0x000000018962ACDC-0x000000018962ADD0
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot) {} // 0x000000018962A82C-0x000000018962A978
		public void Reset() {} // 0x000000018962CD88-0x000000018962CEC0
		public override void StoreDefaultLocalState() {} // 0x000000018962E9EC-0x000000018962EB44
		public override void FixTransforms() {} // 0x000000018962AF88-0x000000018962B15C
		public override Point[] GetPoints() => default; // 0x000000018962BB48-0x000000018962BB98
		public override Point GetPoint(Transform transform) => default; // 0x000000018962BAF8-0x000000018962BB48
		public override bool IsValid(ref string message) => default; // 0x000000018962C008-0x000000018962C28C
		private Vector3 GetNormal(Transform[] transforms) => default; // 0x000000018962B15C-0x000000018962B410
		private static Keyframe[] GetSineKeyframes(float mag) => default; // 0x000000018962BBF8-0x000000018962BCBC
		private void UpdateSolverTransforms() {} // 0x000000018962EB44-0x000000018962EC88
		protected override void OnInitiate() {} // 0x000000018962C28C-0x000000018962C2E0
		protected override void OnUpdate() {} // 0x000000018962C2E0-0x000000018962C820
		private void WriteTransforms() {} // 0x000000018962EC88-0x000000018962F160
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms) {} // 0x000000018962C820-0x000000018962CD88
		private void Solve() {} // 0x000000018962D1C4-0x000000018962E9EC
		private Vector3 GetPosition(int index) => default; // 0x000000018962BB98-0x000000018962BBC8
		private Quaternion GetRotation(int index) => default; // 0x000000018962BBC8-0x000000018962BBF8
		private void Write() {} // 0x000000018962F160-0x000000018962F2C0
		private Vector3 GetPelvisOffset(float deltaTime) => default; // 0x000000018962B410-0x000000018962BAF8
	}

	public class TwistRelaxer : MonoBehaviour // TypeDefIndex: 52736
	{
		// Fields
		public IK ik; // 0x18
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers; // 0x20
	
		// Constructors
		public TwistRelaxer() {} // 0x000000018964038C-0x00000001896403DC
	
		// Methods
		public void Start() {} // 0x0000000189640138-0x00000001896402F0
		private void Update() {} // 0x00000001896402F0-0x000000018964038C
		private void OnPostUpdate() {} // 0x00000001896400AC-0x0000000189640138
		private void LateUpdate() {} // 0x000000018963FEF4-0x000000018963FF80
		private void OnDestroy() {} // 0x000000018963FF80-0x00000001896400AC
	}

	[Serializable]
	public class TwistSolver // TypeDefIndex: 52737
	{
		// Fields
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform; // 0x10
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent; // 0x18
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children; // 0x20
		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight; // 0x28
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade; // 0x2C
		[Range(-180f, 180f)]
		[Tooltip("Rotation offset around the twist axis.")]
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
		public TwistSolver() {} // 0x0000000189640EB0-0x0000000189640F4C
	
		// Methods
		public void Initiate() {} // 0x0000000189640490-0x0000000189640A4C
		public void FixTransforms() {} // 0x00000001896403DC-0x0000000189640490
		public void Relax() {} // 0x0000000189640A4C-0x0000000189640EB0
	}

	[Serializable]
	public class InteractionEffector // TypeDefIndex: 52738
	{
		// Fields
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
		public FullBodyBipedEffector effectorType { get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public bool isPaused { get; private set; } // 0x0000000183D58C00-0x0000000183D58C10 0x0000000183D58C20-0x0000000183D58C30
		public InteractionObject interactionObject { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public bool inInteraction { get => default; } // 0x0000000189635900-0x0000000189635950 
		public float progress { get => default; } // 0x0000000189635950-0x0000000189635988 
	
		// Constructors
		public InteractionEffector() {} // Dummy constructor
		public InteractionEffector(FullBodyBipedEffector effectorType) {} // 0x0000000189635874-0x0000000189635900
	
		// Methods
		public void Initiate(InteractionSystem interactionSystem) {} // 0x0000000189633AD4-0x0000000189633B8C
		private void StoreDefaults() {} // 0x0000000189634D40-0x0000000189634F30
		public bool ResetToDefaults(float speed, float deltaTime) => default; // 0x0000000189634244-0x00000001896346B4
		public bool Pause() => default; // 0x0000000189633E78-0x0000000189633F98
		public bool Resume() => default; // 0x00000001896346B4-0x0000000189634708
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt) => default; // 0x0000000189634B10-0x0000000189634C18
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt) => default; // 0x0000000189634708-0x0000000189634B10
		public void Update(Transform root, float speed, float deltaTime) {} // 0x00000001896351D8-0x0000000189635874
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause) {
			pickUp = default;
			pause = default;
		} // 0x0000000189634F30-0x00000001896351D8
		private void PickUp(Transform root) {} // 0x0000000189633F98-0x0000000189634244
		public bool Stop() => default; // 0x0000000189634C18-0x0000000189634D40
		public void OnPostFBBIK() {} // 0x0000000189633B8C-0x0000000189633E78
	}

	[Serializable]
	public class InteractionLookAt // TypeDefIndex: 52739
	{
		// Fields
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik; // 0x10
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed; // 0x18
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed; // 0x1C
		[HideInInspector]
		public bool isPaused; // 0x20
		private Transform lookAtTarget; // 0x28
		private float stopLookTime; // 0x30
		private float weight; // 0x34
		private bool firstFBBIKSolve; // 0x38
	
		// Constructors
		public InteractionLookAt() {} // 0x0000000183D74DA0-0x0000000183D74DB0
	
		// Methods
		public void Look(Transform target, float time) {} // 0x000000018964844C-0x00000001896485D8
		public void OnFixTransforms() {} // 0x00000001896485D8-0x0000000189648658
		public void Update() {} // 0x0000000189648830-0x0000000189648A54
		public void SolveSpine() {} // 0x000000018964871C-0x0000000189648830
		public void SolveHead() {} // 0x0000000189648658-0x000000018964871C
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour // TypeDefIndex: 52746
	{
		// Fields
		[Tooltip("If the Interaction System has a \'Look At\' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget; // 0x18
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot; // 0x20
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace; // 0x28
		public WeightCurve[] weightCurves; // 0x30
		public Multiplier[] multipliers; // 0x38
		public InteractionEvent[] events; // 0x40
		private InteractionTarget[] targets; // 0x58
	
		// Properties
		public float length { get; private set; } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public InteractionSystem lastUsedInteractionSystem { get; private set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public Transform lookAtTarget { get => default; } // 0x0000000189649DD8-0x0000000189649E40 
		public Transform targetsRoot { get => default; } // 0x0000000189649E40-0x0000000189649EA8 
	
		// Nested types
		[Serializable]
		public class InteractionEvent // TypeDefIndex: 52740
		{
			// Fields
			[Tooltip("The time of the event since interaction start.")]
			public float time; // 0x10
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause; // 0x14
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp; // 0x15
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations; // 0x18
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages; // 0x20
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent; // 0x28
	
			// Constructors
			public InteractionEvent() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Activate(Transform t) {} // 0x00000001896483A4-0x000000018964844C
		}
	
		[Serializable]
		public class Message // TypeDefIndex: 52741
		{
			// Fields
			[Tooltip("The name of the function called.")]
			public string function; // 0x10
			[Tooltip("The recipient game object.")]
			public GameObject recipient; // 0x18
			private const string empty = ""; // Metadata: 0x01FD2B81
	
			// Constructors
			public Message() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Send(Transform t) {} // 0x000000018964F1C4-0x000000018964F29C
		}
	
		[Serializable]
		public class AnimatorEvent // TypeDefIndex: 52742
		{
			// Fields
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator; // 0x10
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation; // 0x18
			[Tooltip("The name of the animation state.")]
			public string animationState; // 0x20
			[Tooltip("The crossfading time.")]
			public float crossfadeTime; // 0x28
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer; // 0x2C
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime; // 0x30
			private const string empty = ""; // Metadata: 0x01FD2B82
	
			// Constructors
			public AnimatorEvent() {} // 0x0000000183D74CA0-0x0000000183D74CB0
	
			// Methods
			public void Activate(bool pickUp) {} // 0x0000000189643BA8-0x0000000189643C68
			private void Activate(Animator animator) {} // 0x0000000189643C68-0x0000000189643D04
			private void Activate(Animation animation) {} // 0x0000000189643AEC-0x0000000189643BA8
		}
	
		[Serializable]
		public class WeightCurve // TypeDefIndex: 52744
		{
			// Fields
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type; // 0x10
			[Tooltip("The weight curve.")]
			public AnimationCurve curve; // 0x18
	
			// Nested types
			[Serializable]
			public enum Type // TypeDefIndex: 52743
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
			public WeightCurve() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public float GetValue(float timer) => default; // 0x00000001896546E0-0x0000000189654700
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 52745
		{
			// Fields
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve; // 0x10
			[Tooltip("The multiplier of the curve\'s value.")]
			public float multiplier; // 0x14
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result; // 0x18
	
			// Constructors
			public Multiplier() {} // 0x0000000183D58F50-0x0000000183D58F60
	
			// Methods
			public float GetValue(WeightCurve weightCurve, float timer) => default; // 0x000000018964F29C-0x000000018964F2CC
		}
	
		// Constructors
		public InteractionObject() {} // 0x0000000189649D88-0x0000000189649DD8
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual() {} // 0x0000000189649D18-0x0000000189649D4C
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference() {} // 0x0000000189649C14-0x0000000189649C48
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1() {} // 0x0000000189649C48-0x0000000189649C7C
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2() {} // 0x0000000189649C7C-0x0000000189649CB0
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3() {} // 0x0000000189649CB0-0x0000000189649CE4
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4() {} // 0x0000000189649CE4-0x0000000189649D18
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x0000000189649D54-0x0000000189649D88
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x0000000189648A54-0x0000000189648A88
		public void Initiate() {} // 0x0000000189649A60-0x0000000189649C14
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem) => default; // 0x0000000189649668-0x000000018964979C
		public bool CurveUsed(WeightCurve.Type type) => default; // 0x0000000189649484-0x00000001896494FC
		public InteractionTarget[] GetTargets() => default; // 0x0000000183D4EAA0-0x0000000183D4EAB0
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag) => default; // 0x0000000189649550-0x0000000189649668
		public void OnStartInteraction(InteractionSystem interactionSystem) {} // 0x0000000182C926C0-0x0000000182C926D0
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight) {} // 0x0000000189648A88-0x0000000189648EE8
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer) => default; // 0x00000001896497FC-0x0000000189649A0C
		private void Start() {} // 0x0000000189649D4C-0x0000000189649D54
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight) {} // 0x0000000189648EE8-0x0000000189649484
		private Transform GetTarget(FullBodyBipedEffector effectorType) => default; // 0x000000018964979C-0x00000001896497FC
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType) => default; // 0x0000000189649A0C-0x0000000189649A60
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType) => default; // 0x00000001896494FC-0x0000000189649550
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour // TypeDefIndex: 52749
	{
		// Fields
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag; // 0x18
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime; // 0x20
		[Tooltip("The master speed for all interactions.")]
		public float speed; // 0x24
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed; // 0x28
		[FormerlySerializedAs("collider")]
		[Header("Triggering")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		public Collider characterCollider; // 0x30
		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera\'s position. Assign the first person view character camera.")]
		public Transform FPSCamera; // 0x38
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers; // 0x40
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance; // 0x44
		private List<InteractionTrigger> inContact; // 0x50
		private List<int> bestRangeIndexes; // 0x58
		public InteractionDelegate OnInteractionStart; // 0x60
		public InteractionDelegate OnInteractionPause; // 0x68
		public InteractionDelegate OnInteractionPickUp; // 0x70
		public InteractionDelegate OnInteractionResume; // 0x78
		public InteractionDelegate OnInteractionStop; // 0x80
		public InteractionEventDelegate OnInteractionEvent; // 0x88
		public RaycastHit raycastHit; // 0x90
		[SerializeField]
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		private FullBodyBipedIK fullBody; // 0xD0
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt; // 0xD8
		private InteractionEffector[] interactionEffectors; // 0xE0
		private Collider lastCollider; // 0xF0
		private Collider c; // 0xF8
		private float lastTime; // 0x100
	
		// Properties
		public bool inInteraction { get => default; } // 0x000000018964D634-0x000000018964D6C4 
		public FullBodyBipedIK ik { get => default; set {} } // 0x0000000183D50050-0x0000000183D50060 0x000000018554A7E0-0x000000018554A7F4
		public List<InteractionTrigger> triggersInRange { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public bool initiated { get; private set; } // 0x0000000183D554A0-0x0000000183D554B0 0x0000000183D554D0-0x0000000183D554E0
	
		// Nested types
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // TypeDefIndex: 52747; 0x0000000182065C10-0x0000000182065C20
	
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent); // TypeDefIndex: 52748; 0x00000001811360D0-0x00000001811360F0
	
		// Constructors
		public InteractionSystem() {} // 0x000000018964D254-0x000000018964D634
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual() {} // 0x000000018964B74C-0x000000018964B780
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference() {} // 0x000000018964B648-0x000000018964B67C
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1() {} // 0x000000018964B67C-0x000000018964B6B0
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2() {} // 0x000000018964B6B0-0x000000018964B6E4
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3() {} // 0x000000018964B6E4-0x000000018964B718
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4() {} // 0x000000018964B718-0x000000018964B74C
		[ContextMenu("Support")]
		private void SupportGroup() {} // 0x000000018964C31C-0x000000018964C350
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x0000000189649EA8-0x0000000189649EDC
		public bool IsInInteraction(FullBodyBipedEffector effectorType) => default; // 0x000000018964A938-0x000000018964A9E8
		public bool IsPaused(FullBodyBipedEffector effectorType) => default; // 0x000000018964AB58-0x000000018964AC04
		public bool IsPaused() => default; // 0x000000018964AAC8-0x000000018964AB58
		public bool IsInSync() => default; // 0x000000018964A9E8-0x000000018964AAC8
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt) => default; // 0x000000018964BB14-0x000000018964BC00
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt) => default; // 0x000000018964BA28-0x000000018964BB14
		public bool PauseInteraction(FullBodyBipedEffector effectorType) => default; // 0x000000018964B7E4-0x000000018964B860
		public bool ResumeInteraction(FullBodyBipedEffector effectorType) => default; // 0x000000018964B9AC-0x000000018964BA28
		public bool StopInteraction(FullBodyBipedEffector effectorType) => default; // 0x000000018964C2A0-0x000000018964C31C
		public void PauseAll() {} // 0x000000018964B780-0x000000018964B7E4
		public void ResumeAll() {} // 0x000000018964B948-0x000000018964B9AC
		public void StopAll() {} // 0x000000018964C24C-0x000000018964C2A0
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType) => default; // 0x000000018964A63C-0x000000018964A6B8
		public float GetProgress(FullBodyBipedEffector effectorType) => default; // 0x000000018964A774-0x000000018964A7F4
		public float GetMinActiveProgress() => default; // 0x000000018964A6B8-0x000000018964A774
		public bool TriggerInteraction(int index, bool interrupt) => default; // 0x000000018964CB38-0x000000018964CCCC
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject) {
			interactionObject = default;
			return default;
		} // 0x000000018964C6D8-0x000000018964C8BC
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget) {
			interactionTarget = default;
			return default;
		} // 0x000000018964C8BC-0x000000018964CB38
		public InteractionTrigger.Range GetClosestInteractionRange() => default; // 0x000000018964A1B4-0x000000018964A28C
		public InteractionObject GetClosestInteractionObjectInRange() => default; // 0x000000018964A088-0x000000018964A0C8
		public InteractionTarget GetClosestInteractionTargetInRange() => default; // 0x000000018964A28C-0x000000018964A2FC
		public InteractionObject[] GetClosestInteractionObjectsInRange() => default; // 0x000000018964A0C8-0x000000018964A1B4
		public InteractionTarget[] GetClosestInteractionTargetsInRange() => default; // 0x000000018964A2FC-0x000000018964A458
		public bool TriggerEffectorsReady(int index) => default; // 0x000000018964C350-0x000000018964C5F0
		public InteractionTrigger.Range GetTriggerRange(int index) => default; // 0x000000018964A7F4-0x000000018964A8F8
		public int GetClosestTriggerIndex() => default; // 0x000000018964A458-0x000000018964A63C
		public void Start() {} // 0x000000018964BC00-0x000000018964C24C
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x000000018964A8F8-0x000000018964A918
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x000000018964A918-0x000000018964A938
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x000000018964A918-0x000000018964A938
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x000000018964ACCC-0x000000018964AD38
		public void OnTriggerEnter(Collider c) {} // 0x000000018964B480-0x000000018964B578
		public void OnTriggerExit(Collider c) {} // 0x000000018964B578-0x000000018964B648
		private bool ContactIsInRange(int index, out int bestRangeIndex) {
			bestRangeIndex = default;
			return default;
		} // 0x0000000189649EDC-0x000000018964A088
		private void OnDrawGizmosSelected() {} // 0x000000018964B238-0x000000018964B318
		public void Update() {} // 0x000000018964D044-0x000000018964D254
		private void Raycasting() {} // 0x000000018964B860-0x000000018964B948
		private void UpdateTriggerEventBroadcasting() {} // 0x000000018964CDF8-0x000000018964D044
		private void OnEnable() {} // 0x000000018964B318-0x000000018964B338
		private void UpdateEffectors() {} // 0x000000018964CCCC-0x000000018964CDF8
		private void OnPreFBBIK() {} // 0x000000018964B404-0x000000018964B480
		private void OnPostFBBIK() {} // 0x000000018964B35C-0x000000018964B404
		private void OnFixTransforms() {} // 0x000000018964B338-0x000000018964B35C
		private void OnDestroy() {} // 0x000000018964AD38-0x000000018964B238
		private bool IsValid(bool log) => default; // 0x000000018964AC04-0x000000018964ACCC
		private bool TriggerIndexIsValid(int index) => default; // 0x000000018964C5F0-0x000000018964C6D8
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour // TypeDefIndex: 52752
	{
		// Fields
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType; // 0x18
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers; // 0x20
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp; // 0x28
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot; // 0x30
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget\'s rotation to the effector bone rotation.")]
		public RotationMode rotationMode; // 0x38
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis; // 0x3C
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight; // 0x48
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight; // 0x4C
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if \'Rotate Once\' is disabled")]
		public float threeDOFWeight; // 0x50
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce; // 0x54
		private Quaternion defaultLocalRotation; // 0x58
		private Transform lastPivot; // 0x68
	
		// Nested types
		[Serializable]
		public enum RotationMode // TypeDefIndex: 52750
		{
			TwoDOF = 0,
			ThreeDOF = 1
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 52751
		{
			// Fields
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve; // 0x10
			[Tooltip("Multiplier of the curve\'s value.")]
			public float multiplier; // 0x14
	
			// Constructors
			public Multiplier() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public InteractionTarget() {} // 0x000000018964DFC0-0x000000018964DFFC
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual() {} // 0x000000018964D85C-0x000000018964D890
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference() {} // 0x000000018964D758-0x000000018964D78C
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1() {} // 0x000000018964D78C-0x000000018964D7C0
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2() {} // 0x000000018964D7C0-0x000000018964D7F4
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3() {} // 0x000000018964D7F4-0x000000018964D828
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4() {} // 0x000000018964D828-0x000000018964D85C
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x000000018964DF8C-0x000000018964DFC0
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x000000018964D6C4-0x000000018964D6F8
		public float GetValue(InteractionObject.WeightCurve.Type curveType) => default; // 0x000000018964D6F8-0x000000018964D758
		public void ResetRotation() {} // 0x000000018964D890-0x000000018964D90C
		public void RotateTo(Transform bone) {} // 0x000000018964D90C-0x000000018964DF8C
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour // TypeDefIndex: 52757
	{
		// Fields
		[Tooltip("The valid ranges of the character\'s and/or its camera\'s position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges; // 0x18
	
		// Nested types
		[Serializable]
		public class CharacterPosition // TypeDefIndex: 52753
		{
			// Fields
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use; // 0x10
			[Tooltip("The offset of the character\'s position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset; // 0x14
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset; // 0x1C
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character\'s forward from the direction of this trigger.")]
			public float maxAngle; // 0x20
			[Tooltip("Max offset of the character\'s position from this range\'s center.")]
			public float radius; // 0x24
			[Tooltip("If true, will rotate the trigger around its Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit; // 0x28
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis; // 0x29
	
			// Properties
			public Vector3 offset3D { get => default; } // 0x0000000183D74D50-0x0000000183D74D70 
			public Vector3 direction3D { get => default; } // 0x0000000189645990-0x0000000189645A20 
	
			// Constructors
			public CharacterPosition() {} // 0x0000000183D74D40-0x0000000183D74D50
	
			// Methods
			public bool IsInRange(Transform character, Transform trigger, out float error) {
				error = default;
				return default;
			} // 0x0000000189645348-0x0000000189645990
		}
	
		[Serializable]
		public class CameraPosition // TypeDefIndex: 52754
		{
			// Fields
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget; // 0x10
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget\'s space).")]
			public Vector3 direction; // 0x18
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance; // 0x24
			[Range(0f, 180f)]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			public float maxAngle; // 0x28
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis; // 0x2C
	
			// Constructors
			public CameraPosition() {} // 0x00000001896452F0-0x0000000189645348
	
			// Methods
			public Quaternion GetRotation() => default; // 0x0000000189644EF4-0x0000000189645054
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error) {
				error = default;
				return default;
			} // 0x0000000189645054-0x00000001896452F0
		}
	
		[Serializable]
		public class Range // TypeDefIndex: 52756
		{
			// Fields
			[HideInInspector]
			public string name; // 0x10
			[HideInInspector]
			public bool show; // 0x18
			[Tooltip("The range for the character\'s position and rotation.")]
			public CharacterPosition characterPosition; // 0x20
			[Tooltip("The range for the character camera\'s position and rotation.")]
			public CameraPosition cameraPosition; // 0x28
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions; // 0x30
	
			// Nested types
			[Serializable]
			public class Interaction // TypeDefIndex: 52755
			{
				// Fields
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject; // 0x10
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors; // 0x18
	
				// Constructors
				public Interaction() {} // 0x000000018350B670-0x000000018350B680
			}
	
			// Constructors
			public Range() {} // 0x0000000183D587A0-0x0000000183D587B0
	
			// Methods
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError) {
				maxError = default;
				return default;
			} // 0x0000000189650A40-0x0000000189650B30
		}
	
		// Constructors
		public InteractionTrigger() {} // 0x000000018964E2B0-0x000000018964E300
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual() {} // 0x000000018964E248-0x000000018964E27C
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference() {} // 0x000000018964E1E0-0x000000018964E214
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4() {} // 0x000000018964E214-0x000000018964E248
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x000000018964E27C-0x000000018964E2B0
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x000000018964DFFC-0x000000018964E030
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit) => default; // 0x000000018964E030-0x000000018964E1E0
	}

	public class GenericPoser : Poser // TypeDefIndex: 52759
	{
		// Fields
		public Map[] maps; // 0x50
	
		// Nested types
		[Serializable]
		public class Map // TypeDefIndex: 52758
		{
			// Fields
			public Transform bone; // 0x10
			public Transform target; // 0x18
			private Vector3 defaultLocalPosition; // 0x20
			private Quaternion defaultLocalRotation; // 0x2C
	
			// Constructors
			public Map() {} // Dummy constructor
			public Map(Transform bone, Transform target) {} // 0x000000018964F190-0x000000018964F1C4
	
			// Methods
			public void StoreDefaultState() {} // 0x000000018960E1B8-0x000000018960E214
			public void FixTransform() {} // 0x000000018964EFD4-0x000000018964F034
			public void Update(float localRotationWeight, float localPositionWeight) {} // 0x000000018964F034-0x000000018964F190
		}
	
		// Constructors
		public GenericPoser() {} // 0x0000000189646D10-0x0000000189646D18
	
		// Methods
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping() {} // 0x00000001896468DC-0x0000000189646B0C
		protected override void InitiatePoser() {} // 0x0000000189646BDC-0x0000000189646BE4
		protected override void UpdatePoser() {} // 0x0000000189646C38-0x0000000189646D10
		protected override void FixPoserTransforms() {} // 0x0000000189646B0C-0x0000000189646B60
		private void StoreDefaultState() {} // 0x0000000189646BE4-0x0000000189646C38
		private Transform GetTargetNamed(string tName, Transform[] array) => default; // 0x0000000189646B60-0x0000000189646BDC
	}

	public class HandPoser : Poser // TypeDefIndex: 52760
	{
		// Fields
		protected Transform[] children; // 0x50
		private Transform _poseRoot; // 0x58
		private Transform[] poseChildren; // 0x60
		private Vector3[] defaultLocalPositions; // 0x68
		private Quaternion[] defaultLocalRotations; // 0x70
	
		// Constructors
		public HandPoser() {} // 0x0000000189646D10-0x0000000189646D18
	
		// Methods
		public override void AutoMapping() {} // 0x0000000189646D18-0x0000000189646DD0
		protected override void InitiatePoser() {} // 0x0000000189646EC4-0x0000000189646F14
		protected override void FixPoserTransforms() {} // 0x0000000189646DD0-0x0000000189646EC4
		protected override void UpdatePoser() {} // 0x0000000189647078-0x00000001896473C8
		protected void StoreDefaultState() {} // 0x0000000189646F14-0x0000000189647078
	}

	public abstract class Poser : SolverManager // TypeDefIndex: 52761
	{
		// Fields
		public Transform poseRoot; // 0x38
		[Range(0f, 1f)]
		public float weight; // 0x40
		[Range(0f, 1f)]
		public float localRotationWeight; // 0x44
		[Range(0f, 1f)]
		public float localPositionWeight; // 0x48
		private bool initiated; // 0x4C
	
		// Constructors
		protected Poser() {} // 0x000000018964F73C-0x000000018964F758
	
		// Methods
		public abstract void AutoMapping();
		public void UpdateManual() {} // 0x0000000185FED3AC-0x0000000185FED3BC
		protected abstract void InitiatePoser();
		protected abstract void UpdatePoser();
		protected abstract void FixPoserTransforms();
		protected override void UpdateSolver() {} // 0x000000018964F700-0x000000018964F73C
		protected override void InitiateSolver() {} // 0x000000018964F6D8-0x000000018964F700
		protected override void FixTransforms() {} // 0x000000018964F6C4-0x000000018964F6D8
	}

	public class RagdollUtility : MonoBehaviour // TypeDefIndex: 52765
	{
		// Fields
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik; // 0x18
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime; // 0x20
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll; // 0x24
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity; // 0x28
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
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
		private bool isRagdoll { get => default; } // 0x00000001896509E0-0x0000000189650A40 
		private bool ikUsed { get => default; } // 0x00000001896508E4-0x00000001896509E0 
	
		// Nested types
		public class Rigidbone // TypeDefIndex: 52762
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
			public Rigidbone(Rigidbody r) {} // 0x0000000189651284-0x00000001896513F8
	
			// Methods
			public void RecordVelocity() {} // 0x0000000189650F10-0x000000018965102C
			public void WakeUp(float velocityWeight, float angularVelocityWeight) {} // 0x000000018965102C-0x0000000189651284
		}
	
		public class Child // TypeDefIndex: 52763
		{
			// Fields
			public Transform t; // 0x10
			public Vector3 localPosition; // 0x18
			public Quaternion localRotation; // 0x24
	
			// Constructors
			public Child() {} // Dummy constructor
			public Child(Transform transform) {} // 0x0000000189645BD8-0x0000000189645C40
	
			// Methods
			public void FixTransform(float weight) {} // 0x0000000189645A20-0x0000000189645B7C
			public void StoreLocalState() {} // 0x0000000189645B7C-0x0000000189645BD8
		}
	
		// Constructors
		public RagdollUtility() {} // 0x00000001896507F0-0x00000001896508E4
	
		// Methods
		public void EnableRagdoll() {} // 0x000000018964FCD8-0x000000018964FD00
		public void DisableRagdoll() {} // 0x000000018964FC90-0x000000018964FCD8
		public void Start() {} // 0x00000001896501AC-0x00000001896505B4
		[IteratorStateMachine(typeof(_DisableRagdollSmooth_d__21))]
		private IEnumerator DisableRagdollSmooth() => default; // 0x000000018964FC34-0x000000018964FC90
		private void Update() {} // 0x0000000189650600-0x00000001896507F0
		private void FixedUpdate() {} // 0x000000018964FD5C-0x000000018964FD94
		private void LateUpdate() {} // 0x000000018964FD94-0x000000018964FE00
		private void AfterLastIK() {} // 0x000000018964FC08-0x000000018964FC34
		private void AfterAnimation() {} // 0x000000018964FBD0-0x000000018964FC08
		private void OnFinalPose() {} // 0x000000018964FF2C-0x000000018964FF68
		private void RagdollEnabler() {} // 0x000000018964FF68-0x0000000189650160
		private void RecordVelocities() {} // 0x0000000189650160-0x00000001896501AC
		private void StoreLocalState() {} // 0x00000001896505B4-0x0000000189650600
		private void FixTransforms(float weight) {} // 0x000000018964FD00-0x000000018964FD5C
		private void OnDestroy() {} // 0x000000018964FE00-0x000000018964FF2C
	}

	public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 52766
	{
		// Fields
		public Vector3 axis; // 0x18
		[HideInInspector]
		public Quaternion defaultLocalRotation; // 0x24
		private bool initiated; // 0x35
		private bool applicationQuit; // 0x36
		private bool defaultLocalRotationSet; // 0x37
	
		// Properties
		public Vector3 secondaryAxis { get; } // 0x0000000183D74DF0-0x0000000183D74E10 
		public Vector3 crossAxis { get; } // 0x0000000189653DB4-0x0000000189653E24 
		public bool defaultLocalRotationOverride { get; private set; } // 0x0000000183D4F570-0x0000000183D4F580 0x0000000183D4F590-0x0000000183D4F5A0
	
		// Constructors
		protected RotationLimit() {} // 0x0000000189653D90-0x0000000189653DB4
	
		// Methods
		public void SetDefaultLocalRotation() {} // 0x0000000189653D50-0x0000000189653D90
		public void SetDefaultLocalRotation(Quaternion localRotation) {} // 0x0000000183D74DE0-0x0000000183D74DF0
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) {
			changed = default;
			return default;
		} // 0x0000000189653934-0x0000000189653A58
		public bool Apply() => default; // 0x00000001896537A8-0x0000000189653844
		public void Disable() {} // 0x000000018965390C-0x0000000189653934
		protected abstract Quaternion LimitRotation(Quaternion rotation);
		private void Awake() {} // 0x0000000189653844-0x000000018965390C
		private void LateUpdate() {} // 0x0000000189653AD0-0x0000000189653AD8
		public void LogWarning(string message) {} // 0x00000001895F8FD0-0x00000001895F8FF8
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) => default; // 0x0000000189653AD8-0x0000000189653B88
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) => default; // 0x0000000189653B88-0x0000000189653D50
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) => default; // 0x0000000189653A58-0x0000000189653AD0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitAngle : RotationLimit // TypeDefIndex: 52767
	{
		// Fields
		[Range(0f, 180f)]
		public float limit; // 0x38
		[Range(0f, 180f)]
		public float twistLimit; // 0x3C
	
		// Constructors
		public RotationLimitAngle() {} // 0x0000000189651794-0x00000001896517AC
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual() {} // 0x000000018965172C-0x0000000189651760
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference() {} // 0x00000001896516F8-0x000000018965172C
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x0000000189651760-0x0000000189651794
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x00000001896513F8-0x000000018965142C
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x000000018965142C-0x00000001896514F0
		private Quaternion LimitSwing(Quaternion rotation) => default; // 0x00000001896514F0-0x00000001896516F8
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitHinge : RotationLimit // TypeDefIndex: 52768
	{
		// Fields
		public bool useLimits; // 0x38
		public float min; // 0x3C
		public float max; // 0x40
		[HideInInspector]
		public float zeroAxisDisplayOffset; // 0x44
		private float lastAngle; // 0x48
	
		// Constructors
		public RotationLimitHinge() {} // 0x0000000189651ADC-0x0000000189651AF8
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual() {} // 0x0000000189651A74-0x0000000189651AA8
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference() {} // 0x0000000189651A40-0x0000000189651A74
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x0000000189651AA8-0x0000000189651ADC
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x00000001896517AC-0x00000001896517E0
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x0000000189651A0C-0x0000000189651A40
		private Quaternion LimitHinge(Quaternion rotation) => default; // 0x00000001896517E0-0x0000000189651A0C
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 52771
	{
		// Fields
		[Range(0f, 180f)]
		public float twistLimit; // 0x38
		[Range(0f, 3f)]
		public int smoothIterations; // 0x3C
		[HideInInspector]
		public LimitPoint[] points; // 0x40
		[HideInInspector]
		public Vector3[] P; // 0x48
		[HideInInspector]
		public ReachCone[] reachCones; // 0x50
	
		// Nested types
		[Serializable]
		public class ReachCone // TypeDefIndex: 52769
		{
			// Fields
			public Vector3[] tetrahedron; // 0x10
			public float volume; // 0x18
			public Vector3 S; // 0x1C
			public Vector3 B; // 0x28
	
			// Properties
			public Vector3 o { get => default; } // 0x0000000189650EE4-0x0000000189650F10 
			public Vector3 a { get => default; } // 0x0000000189650E44-0x0000000189650E74 
			public Vector3 b { get => default; } // 0x0000000189650E74-0x0000000189650EA4 
			public Vector3 c { get => default; } // 0x0000000189650EA4-0x0000000189650ED4 
			public bool isValid { get => default; } // 0x0000000189650ED4-0x0000000189650EE4 
	
			// Constructors
			public ReachCone() {} // Dummy constructor
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c) {} // 0x0000000189650CE8-0x0000000189650E44
	
			// Methods
			public void Calculate() {} // 0x0000000189650B30-0x0000000189650CE8
		}
	
		[Serializable]
		public class LimitPoint // TypeDefIndex: 52770
		{
			// Fields
			public Vector3 point; // 0x10
			public float tangentWeight; // 0x1C
	
			// Constructors
			public LimitPoint() {} // 0x000000018964E300-0x000000018964E324
		}
	
		// Constructors
		public RotationLimitPolygonal() {} // 0x00000001896532D0-0x0000000189653328
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual() {} // 0x0000000189652460-0x0000000189652494
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference() {} // 0x000000018965242C-0x0000000189652460
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x0000000189653130-0x0000000189653164
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x0000000189651AF8-0x0000000189651B2C
		public void SetLimitPoints(LimitPoint[] points) {} // 0x000000018965297C-0x00000001896529F0
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x0000000189652090-0x000000018965217C
		private void Start() {} // 0x0000000189652F58-0x0000000189653130
		public void ResetToDefault() {} // 0x0000000189652598-0x000000018965297C
		public void BuildReachCones() {} // 0x0000000189651B2C-0x0000000189651EF8
		private Vector3[] SmoothPoints() => default; // 0x00000001896529F0-0x0000000189652F58
		private float GetScalar(int k) => default; // 0x0000000189652040-0x0000000189652090
		private Vector3 PointToTangentPlane(Vector3 p, float r) => default; // 0x0000000189652494-0x0000000189652598
		private Vector3 TangentPointToSphere(Vector3 q, float r) => default; // 0x0000000189653164-0x00000001896532D0
		private Quaternion LimitSwing(Quaternion rotation) => default; // 0x000000018965217C-0x000000018965242C
		private int GetReachCone(Vector3 L) => default; // 0x0000000189651EF8-0x0000000189652040
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitSpline : RotationLimit // TypeDefIndex: 52772
	{
		// Fields
		[Range(0f, 180f)]
		public float twistLimit; // 0x38
		[HideInInspector]
		public AnimationCurve spline; // 0x40
	
		// Constructors
		public RotationLimitSpline() {} // 0x0000000189653798-0x00000001896537A8
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual() {} // 0x0000000189653710-0x0000000189653744
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference() {} // 0x00000001896536DC-0x0000000189653710
		[ContextMenu("Support Group")]
		private void SupportGroup() {} // 0x0000000189653764-0x0000000189653798
		[ContextMenu("Asset Store Thread")]
		private void ASThread() {} // 0x0000000189653328-0x000000018965335C
		public void SetSpline(Keyframe[] keyframes) {} // 0x0000000189653744-0x0000000189653764
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x000000018965335C-0x0000000189653420
		public Quaternion LimitSwing(Quaternion rotation) => default; // 0x0000000189653420-0x00000001896536DC
	}

	public class AimController : MonoBehaviour // TypeDefIndex: 52774
	{
		// Fields
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik; // 0x18
		[Range(0f, 1f)]
		[Tooltip("Master weight of the IK solver.")]
		public float weight; // 0x20
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target; // 0x28
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime; // 0x30
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime; // 0x34
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget; // 0x38
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta; // 0x3C
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta; // 0x40
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed; // 0x44
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime; // 0x48
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot; // 0x4C
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance; // 0x58
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset; // 0x5C
		[Header("RootRotation")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		public float maxRootAngle; // 0x68
		[Tooltip("If enabled, aligns the root forward to target direction after \'Max Root Angle\' has been exceeded.")]
		public bool turnToTarget; // 0x6C
		[Tooltip("The time of turning towards the target direction if \'Max Root Angle has been exceeded and \'Turn To Target\' is enabled.")]
		public float turnToTargetTime; // 0x70
		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection; // 0x74
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. \'Use Animated Aim Direction\' must be enabled for this property to work.")]
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
		private Vector3 pivot { get => default; } // 0x0000000189643748-0x0000000189643850 
	
		// Constructors
		public AimController() {} // 0x00000001896436B8-0x0000000189643748
	
		// Methods
		private void Start() {} // 0x000000018964356C-0x000000018964365C
		private void LateUpdate() {} // 0x0000000189642918-0x00000001896432A8
		private void ApplyMinDistance() {} // 0x00000001896427E0-0x0000000189642918
		private void RootRotation() {} // 0x00000001896432A8-0x000000018964356C
		[IteratorStateMachine(typeof(_TurnToTarget_d__37))]
		private IEnumerator TurnToTarget() => default; // 0x000000018964365C-0x00000001896436B8
	}

	public class AimPoser : MonoBehaviour // TypeDefIndex: 52776
	{
		// Fields
		public float angleBuffer; // 0x18
		public Pose[] poses; // 0x20
	
		// Nested types
		[Serializable]
		public class Pose // TypeDefIndex: 52775
		{
			// Fields
			public bool visualize; // 0x10
			public string name; // 0x18
			public Vector3 direction; // 0x20
			public float yaw; // 0x2C
			public float pitch; // 0x30
			private float angleBuffer; // 0x34
	
			// Constructors
			public Pose() {} // 0x0000000183D74DB0-0x0000000183D74DD0
	
			// Methods
			public bool IsInDirection(Vector3 d) => default; // 0x000000018964F4A0-0x000000018964F6C4
			public void SetAngleBuffer(float value) {} // 0x0000000183D56CB0-0x0000000183D56CC0
		}
	
		// Constructors
		public AimPoser() {} // 0x0000000189643978-0x00000001896439D0
	
		// Methods
		public Pose GetPose(Vector3 localDirection) => default; // 0x0000000189643850-0x0000000189643918
		public void SetPoseActive(Pose pose) {} // 0x0000000189643918-0x0000000189643978
	}

	public class Amplifier : OffsetModifier // TypeDefIndex: 52779
	{
		// Fields
		[Tooltip("The amplified bodies.")]
		public Body[] bodies; // 0x30
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 52778
		{
			// Fields
			[Tooltip("The Transform that\'s motion we are reading.")]
			public Transform transform; // 0x10
			[Tooltip("Amplify the \'transform\'s\' position relative to this Transform.")]
			public Transform relativeTo; // 0x18
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks; // 0x20
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight; // 0x28
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight; // 0x2C
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed; // 0x30
			private Vector3 lastRelativePos; // 0x34
			private Vector3 smoothDelta; // 0x40
			private bool firstUpdate; // 0x4C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 52777
			{
				// Fields
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Weight of using this effector")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink() {} // 0x000000018350B670-0x000000018350B680
			}
	
			// Constructors
			public Body() {} // 0x0000000183D74D10-0x0000000183D74D30
	
			// Methods
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime) {} // 0x000000018964447C-0x00000001896448BC
			private static Vector3 Multiply(Vector3 v1, Vector3 v2) => default; // 0x0000000183D74CB0-0x0000000183D74CF0
		}
	
		// Constructors
		public Amplifier() {} // 0x0000000187B4A6A8-0x0000000187B4A6B8
	
		// Methods
		protected override void OnModifyOffset() {} // 0x00000001896439D0-0x0000000189643AEC
	}

	public class BodyTilt : OffsetModifier // TypeDefIndex: 52780
	{
		// Fields
		[Tooltip("Speed of tilting")]
		public float tiltSpeed; // 0x30
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity; // 0x34
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft; // 0x38
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight; // 0x40
		private float tiltAngle; // 0x48
		private Vector3 lastForward; // 0x4C
	
		// Constructors
		public BodyTilt() {} // 0x0000000189643F2C-0x0000000189643F48
	
		// Methods
		protected override void Start() {} // 0x0000000189643EE0-0x0000000189643F2C
		protected override void OnModifyOffset() {} // 0x0000000189643D04-0x0000000189643EE0
	}

	public class CCDBendGoal : MonoBehaviour // TypeDefIndex: 52781
	{
		// Fields
		public CCDIK ik; // 0x18
		[Range(0f, 1f)]
		public float weight; // 0x20
	
		// Constructors
		public CCDBendGoal() {} // 0x0000000183CFE7F0-0x0000000183CFE800
	
		// Methods
		private void Start() {} // 0x0000000189644E00-0x0000000189644EF4
		private void BeforeIK() {} // 0x00000001896449F0-0x0000000189644CD8
		private void OnDestroy() {} // 0x0000000189644CD8-0x0000000189644E00
	}

	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour // TypeDefIndex: 52782
	{
		// Fields
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator; // 0x18
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose; // 0x20
		[HideInInspector]
		public Transform[] bones; // 0x28
	
		// Properties
		public IK ik { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
	
		// Constructors
		public EditorIK() {} // 0x00000001896467A0-0x00000001896467F0
	
		// Methods
		private void OnEnable() {} // 0x0000000189646350-0x0000000189646498
		private void OnDisable() {} // 0x0000000189646284-0x0000000189646350
		private void OnDestroy() {} // 0x000000018964614C-0x0000000189646284
		public void StoreDefaultPose() {} // 0x0000000189646498-0x0000000189646510
		public bool Initiate() => default; // 0x0000000189645F7C-0x000000018964614C
		public void Update() {} // 0x0000000189646510-0x00000001896467A0
	}

	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject // TypeDefIndex: 52783
	{
		// Fields
		public Vector3[] localPositions; // 0x18
		public Quaternion[] localRotations; // 0x20
	
		// Properties
		public bool poseStored { get => default; } // 0x0000000189645F5C-0x0000000189645F7C 
	
		// Constructors
		public EditorIKPose() {} // 0x0000000189645EE4-0x0000000189645F5C
	
		// Methods
		public void Store(Transform[] T) {} // 0x0000000189645D98-0x0000000189645EE4
		public bool Restore(Transform[] T) => default; // 0x0000000189645C40-0x0000000189645D98
	}

	public class HitReaction : OffsetModifier // TypeDefIndex: 52789
	{
		// Fields
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints; // 0x30
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints; // 0x38
	
		// Properties
		public bool inProgress { get => default; } // 0x0000000189648110-0x0000000189648190 
	
		// Nested types
		[Serializable]
		public abstract class HitPoint // TypeDefIndex: 52784
		{
			// Fields
			[Tooltip("Just for visual clarity, not used at all")]
			public string name; // 0x10
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider; // 0x18
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime; // 0x20
			private float length; // 0x38
			private float crossFadeSpeed; // 0x3C
			private float lastTime; // 0x40
	
			// Properties
			public bool inProgress { get; } // 0x0000000189647BEC-0x0000000189647BFC 
			protected float crossFader { get; private set; } // 0x0000000183D524F0-0x0000000183D52500 0x0000000183D52500-0x0000000183D52510
			protected float timer { get; private set; } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
			protected Vector3 force { get; private set; } // 0x0000000183D59800-0x0000000183D59820 0x0000000183D5BF30-0x0000000183D5BF40
	
			// Constructors
			protected HitPoint() {} // 0x0000000183D74D90-0x0000000183D74DA0
	
			// Methods
			public virtual void Hit(Vector3 force, Vector3 point) {} // 0x0000000189647B10-0x0000000189647BEC
			public void Apply(IKSolverFullBodyBiped solver, float weight) {} // 0x0000000189647A48-0x0000000189647B10
			protected abstract float GetLength();
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);
		}
	
		[Serializable]
		public class HitPointEffector : HitPoint // TypeDefIndex: 52786
		{
			// Fields
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection; // 0x48
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection; // 0x50
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks; // 0x58
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 52785
			{
				// Fields
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public EffectorLink() {} // 0x000000018350B670-0x000000018350B680
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader) {} // 0x00000001896467F0-0x00000001896468DC
				public void CrossFadeStart() {} // 0x0000000183D74D70-0x0000000183D74D90
			}
	
			// Constructors
			public HitPointEffector() {} // 0x0000000183D74D90-0x0000000183D74DA0
	
			// Methods
			protected override float GetLength() => default; // 0x0000000189647768-0x0000000189647870
			protected override void CrossFadeStart() {} // 0x000000018964771C-0x0000000189647768
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight) {} // 0x0000000189647870-0x0000000189647A48
		}
	
		[Serializable]
		public class HitPointBone : HitPoint // TypeDefIndex: 52788
		{
			// Fields
			[Tooltip("The angle to rotate the bone around its rigidbody\'s world center of mass")]
			public AnimationCurve aroundCenterOfMass; // 0x48
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks; // 0x50
			private Rigidbody rigidbody; // 0x58
			private Vector3 comAxis; // 0x60
	
			// Nested types
			[Serializable]
			public class BoneLink // TypeDefIndex: 52787
			{
				// Fields
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone; // 0x10
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight; // 0x18
				private Quaternion lastValue; // 0x1C
				private Quaternion current; // 0x2C
	
				// Constructors
				public BoneLink() {} // 0x00000001896449C0-0x00000001896449F0
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader) {} // 0x00000001896448BC-0x00000001896449C0
				public void CrossFadeStart() {} // 0x0000000183D74D30-0x0000000183D74D40
			}
	
			// Constructors
			public HitPointBone() {} // 0x0000000183D74D90-0x0000000183D74DA0
	
			// Methods
			public override void Hit(Vector3 force, Vector3 point) {} // 0x0000000189647488-0x0000000189647648
			protected override float GetLength() => default; // 0x000000018964740C-0x0000000189647488
			protected override void CrossFadeStart() {} // 0x00000001896473C8-0x000000018964740C
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight) {} // 0x0000000189647648-0x000000018964771C
		}
	
		// Constructors
		public HitReaction() {} // 0x0000000187B4A6A8-0x0000000187B4A6B8
	
		// Methods
		protected override void OnModifyOffset() {} // 0x0000000189648068-0x0000000189648110
		public void Hit(Collider collider, Vector3 force, Vector3 point) {} // 0x0000000189647E88-0x0000000189648068
	}

	public class HitReactionVRIK : OffsetModifierVRIK // TypeDefIndex: 52795
	{
		// Fields
		public AnimationCurve[] offsetCurves; // 0x30
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets; // 0x38
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets; // 0x40
	
		// Nested types
		[Serializable]
		public abstract class Offset // TypeDefIndex: 52790
		{
			// Fields
			[Tooltip("Just for visual clarity, not used at all")]
			public string name; // 0x10
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider; // 0x18
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime; // 0x20
			private float length; // 0x38
			private float crossFadeSpeed; // 0x3C
			private float lastTime; // 0x40
	
			// Properties
			protected float crossFader { get; private set; } // 0x0000000183D524F0-0x0000000183D52500 0x0000000183D52500-0x0000000183D52510
			protected float timer { get; private set; } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
			protected Vector3 force { get; private set; } // 0x0000000183D59800-0x0000000183D59820 0x0000000183D5BF30-0x0000000183D5BF40
	
			// Constructors
			protected Offset() {} // 0x0000000183D74D90-0x0000000183D74DA0
	
			// Methods
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point) {} // 0x000000018964F3A4-0x000000018964F4A0
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight) {} // 0x000000018964F2CC-0x000000018964F3A4
			protected abstract float GetLength(AnimationCurve[] curves);
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);
		}
	
		[Serializable]
		public class PositionOffset : Offset // TypeDefIndex: 52792
		{
			// Fields
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex; // 0x48
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex; // 0x4C
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks; // 0x50
	
			// Nested types
			[Serializable]
			public class PositionOffsetLink // TypeDefIndex: 52791
			{
				// Fields
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset; // 0x10
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public PositionOffsetLink() {} // 0x000000018350B670-0x000000018350B680
	
				// Methods
				public void Apply(VRIK ik, Vector3 offset, float crossFader) {} // 0x000000018964F758-0x000000018964F808
				public void CrossFadeStart() {} // 0x0000000183D74D70-0x0000000183D74D90
			}
	
			// Constructors
			public PositionOffset() {} // 0x0000000183D74DD0-0x0000000183D74DE0
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves) => default; // 0x000000018964F854-0x000000018964F9C8
			protected override void CrossFadeStart() {} // 0x000000018964F808-0x000000018964F854
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight) {} // 0x000000018964F9C8-0x000000018964FBD0
		}
	
		[Serializable]
		public class RotationOffset : Offset // TypeDefIndex: 52794
		{
			// Fields
			[Tooltip("The angle to rotate the bone around its rigidbody\'s world center of mass")]
			public int curveIndex; // 0x48
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks; // 0x50
			private Rigidbody rigidbody; // 0x58
			private Vector3 comAxis; // 0x60
	
			// Nested types
			[Serializable]
			public class RotationOffsetLink // TypeDefIndex: 52793
			{
				// Fields
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset; // 0x10
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight; // 0x14
				private Quaternion lastValue; // 0x18
				private Quaternion current; // 0x28
	
				// Constructors
				public RotationOffsetLink() {} // 0x0000000189653F00-0x0000000189653F30
	
				// Methods
				public void Apply(VRIK ik, Quaternion offset, float crossFader) {} // 0x0000000189653E24-0x0000000189653F00
				public void CrossFadeStart() {} // 0x0000000183D74E10-0x0000000183D74E20
			}
	
			// Constructors
			public RotationOffset() {} // 0x0000000183D74D90-0x0000000183D74DA0
	
			// Methods
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point) {} // 0x000000018965402C-0x00000001896541F4
			protected override float GetLength(AnimationCurve[] curves) => default; // 0x0000000189653F74-0x000000018965402C
			protected override void CrossFadeStart() {} // 0x0000000189653F30-0x0000000189653F74
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight) {} // 0x00000001896541F4-0x00000001896543CC
		}
	
		// Constructors
		public HitReactionVRIK() {} // 0x0000000187B4A6A8-0x0000000187B4A6B8
	
		// Methods
		protected override void OnModifyOffset() {} // 0x0000000189647DE4-0x0000000189647E88
		public void Hit(Collider collider, Vector3 force, Vector3 point) {} // 0x0000000189647BFC-0x0000000189647DE4
	}

	public class Inertia : OffsetModifier // TypeDefIndex: 52798
	{
		// Fields
		[Tooltip("The array of Bodies")]
		public Body[] bodies; // 0x30
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits; // 0x38
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 52797
		{
			// Fields
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform; // 0x10
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks; // 0x18
			[Tooltip("The speed to follow the Transform")]
			public float speed; // 0x20
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration; // 0x24
			[Range(0f, 1f)]
			[Tooltip("Matching target velocity")]
			public float matchVelocity; // 0x28
			[Tooltip("gravity applied to the Body")]
			public float gravity; // 0x2C
			private Vector3 delta; // 0x30
			private Vector3 lazyPoint; // 0x3C
			private Vector3 direction; // 0x48
			private Vector3 lastPosition; // 0x54
			private bool firstUpdate; // 0x60
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 52796
			{
				// Fields
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Weight of using this effector")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink() {} // 0x000000018350B670-0x000000018350B680
			}
	
			// Constructors
			public Body() {} // 0x0000000183D74CF0-0x0000000183D74D10
	
			// Methods
			public void Reset() {} // 0x0000000189643F48-0x0000000189644008
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime) {} // 0x0000000189644008-0x000000018964447C
		}
	
		// Constructors
		public Inertia() {} // 0x0000000187B4A6A8-0x0000000187B4A6B8
	
		// Methods
		public void ResetBodies() {} // 0x0000000189648240-0x000000018964829C
		protected override void OnModifyOffset() {} // 0x0000000189648190-0x0000000189648240
	}

	public class LookAtController : MonoBehaviour // TypeDefIndex: 52799
	{
		// Fields
		public LookAtIK ik; // 0x18
		[Header("Target Smoothing")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		public Transform target; // 0x20
		[Range(0f, 1f)]
		public float weight; // 0x28
		public Vector3 offset; // 0x2C
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime; // 0x38
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime; // 0x3C
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget; // 0x40
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta; // 0x44
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta; // 0x48
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed; // 0x4C
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot; // 0x50
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance; // 0x5C
		[Header("RootRotation")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		public float maxRootAngle; // 0x60
		private Transform lastTarget; // 0x68
		private float switchWeight; // 0x70
		private float switchWeightV; // 0x74
		private float weightV; // 0x78
		private Vector3 lastPosition; // 0x7C
		private Vector3 dir; // 0x88
		private bool lastSmoothTowardsTarget; // 0x94
	
		// Properties
		private Vector3 pivot { get => default; } // 0x000000018964EECC-0x000000018964EFD4 
	
		// Constructors
		public LookAtController() {} // 0x000000018964EE68-0x000000018964EECC
	
		// Methods
		private void Start() {} // 0x000000018964EDA0-0x000000018964EE68
		private void LateUpdate() {} // 0x000000018964E45C-0x000000018964EB3C
		private void ApplyMinDistance() {} // 0x000000018964E324-0x000000018964E45C
		private void RootRotation() {} // 0x000000018964EB3C-0x000000018964EDA0
	}

	public abstract class OffsetModifier : MonoBehaviour // TypeDefIndex: 52802
	{
		// Fields
		[Tooltip("The master weight")]
		public float weight; // 0x18
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik; // 0x20
		protected float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x0000000189655408-0x0000000189655424 
	
		// Nested types
		[Serializable]
		public class OffsetLimits // TypeDefIndex: 52800
		{
			// Fields
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector; // 0x10
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring; // 0x14
			[Tooltip("Which axes to limit the offset on?")]
			public bool x; // 0x18
			[Tooltip("Which axes to limit the offset on?")]
			public bool y; // 0x19
			[Tooltip("Which axes to limit the offset on?")]
			public bool z; // 0x1A
			[Tooltip("The limits")]
			public float minX; // 0x1C
			[Tooltip("The limits")]
			public float maxX; // 0x20
			[Tooltip("The limits")]
			public float minY; // 0x24
			[Tooltip("The limits")]
			public float maxY; // 0x28
			[Tooltip("The limits")]
			public float minZ; // 0x2C
			[Tooltip("The limits")]
			public float maxZ; // 0x30
	
			// Constructors
			public OffsetLimits() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Apply(IKEffector e, Quaternion rootRotation) {} // 0x0000000189654F34-0x000000018965510C
			private float SpringAxis(float value, float min, float max) => default; // 0x000000018965510C-0x0000000189655140
			private float Spring(float value, float limit, bool negative) => default; // 0x0000000189655140-0x000000018965519C
		}
	
		// Constructors
		protected OffsetModifier() {} // 0x0000000187B4A6A8-0x0000000187B4A6B8
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start() {} // 0x000000018965572C-0x0000000189655750
		[IteratorStateMachine(typeof(_Initiate_d__8))]
		private IEnumerator Initiate() => default; // 0x00000001896554E4-0x0000000189655540
		private void ModifyOffset() {} // 0x0000000189655540-0x0000000189655604
		protected void ApplyLimits(OffsetLimits[] limits) {} // 0x0000000189655424-0x00000001896554E4
		protected virtual void OnDestroy() {} // 0x0000000189655604-0x000000018965572C
	}

	public abstract class OffsetModifierVRIK : MonoBehaviour // TypeDefIndex: 52804
	{
		// Fields
		[Tooltip("The master weight")]
		public float weight; // 0x18
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik; // 0x20
		private float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x0000000189655408-0x0000000189655424 
	
		// Constructors
		protected OffsetModifierVRIK() {} // 0x0000000187B4A6A8-0x0000000187B4A6B8
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start() {} // 0x00000001896553E4-0x0000000189655408
		[IteratorStateMachine(typeof(_Initiate_d__7))]
		private IEnumerator Initiate() => default; // 0x000000018965519C-0x00000001896551F8
		private void ModifyOffset() {} // 0x00000001896551F8-0x00000001896552BC
		protected virtual void OnDestroy() {} // 0x00000001896552BC-0x00000001896553E4
	}

	public class OffsetPose : MonoBehaviour // TypeDefIndex: 52806
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x18
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 52805
		{
			// Fields
			public FullBodyBipedEffector effector; // 0x10
			public Vector3 offset; // 0x14
			public Vector3 pin; // 0x20
			public Vector3 pinWeight; // 0x2C
	
			// Constructors
			public EffectorLink() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation) {} // 0x0000000189654C6C-0x0000000189654F34
		}
	
		// Constructors
		public OffsetPose() {} // 0x000000018965588C-0x00000001896558DC
	
		// Methods
		public void Apply(IKSolverFullBodyBiped solver, float weight) {} // 0x0000000189655750-0x00000001896557FC
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation) {} // 0x00000001896557FC-0x000000018965588C
	}

	public class PenetrationAvoidance : OffsetModifier // TypeDefIndex: 52809
	{
		// Fields
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders; // 0x30
	
		// Nested types
		[Serializable]
		public class Avoider // TypeDefIndex: 52808
		{
			// Fields
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom; // 0x10
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo; // 0x18
			[Range(0f, 1f)]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			public float raycastRadius; // 0x20
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors; // 0x28
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn; // 0x30
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut; // 0x34
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers; // 0x38
			private Vector3 offset; // 0x3C
			private Vector3 offsetTarget; // 0x48
			private Vector3 offsetV; // 0x54
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 52807
			{
				// Fields
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink() {} // 0x000000018350B670-0x000000018350B680
			}
	
			// Constructors
			public Avoider() {} // 0x0000000183D74E20-0x0000000183D74E30
	
			// Methods
			public void Solve(IKSolverFullBodyBiped solver, float weight) {} // 0x0000000189654AA8-0x0000000189654C6C
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver) => default; // 0x0000000189654700-0x0000000189654880
			private Vector3 Raycast(Vector3 from, Vector3 to) => default; // 0x0000000189654880-0x0000000189654AA8
		}
	
		// Constructors
		public PenetrationAvoidance() {} // 0x0000000187B4A6A8-0x0000000187B4A6B8
	
		// Methods
		protected override void OnModifyOffset() {} // 0x00000001896558DC-0x0000000189655948
	}

	public class Recoil : OffsetModifier // TypeDefIndex: 52813
	{
		// Fields
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK; // 0x30
		[Tooltip("Optional head AimIK solver. This solver should only use neck and head bones and have the head as Aim Transform")]
		public AimIK headIK; // 0x38
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast; // 0x40
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness; // 0x44
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded; // 0x48
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight; // 0x50
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom; // 0x58
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom; // 0x5C
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset; // 0x68
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime; // 0x74
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets; // 0x78
		[HideInInspector]
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
		public bool isFinished { get => default; } // 0x0000000189656D00-0x0000000189656D20 
		private IKEffector primaryHandEffector { get => default; } // 0x0000000189656D20-0x0000000189656D68 
		private IKEffector secondaryHandEffector { get => default; } // 0x0000000189656D88-0x0000000189656DD0 
		private Transform primaryHand { get => default; } // 0x0000000189656D68-0x0000000189656D88 
		private Transform secondaryHand { get => default; } // 0x0000000189656DD0-0x0000000189656DF0 
	
		// Nested types
		[Serializable]
		public class RecoilOffset // TypeDefIndex: 52811
		{
			// Fields
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset; // 0x10
			[Range(0f, 1f)]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			public float additivity; // 0x1C
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag; // 0x20
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks; // 0x28
			private Vector3 additiveOffset; // 0x30
			private Vector3 lastOffset; // 0x3C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 52810
			{
				// Fields
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Weight of using this effector")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink() {} // 0x000000018350B670-0x000000018350B680
			}
	
			// Constructors
			public RecoilOffset() {} // 0x0000000183D74E30-0x0000000183D74E40
	
			// Methods
			public void Start() {} // 0x0000000189655B5C-0x0000000189655BD0
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft) {} // 0x0000000189655948-0x0000000189655B5C
		}
	
		[Serializable]
		public enum Handedness // TypeDefIndex: 52812
		{
			Right = 0,
			Left = 1
		}
	
		// Constructors
		public Recoil() {} // 0x0000000189656C94-0x0000000189656D00
	
		// Methods
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation) {} // 0x0000000189656C74-0x0000000189656C94
		public void Fire(float magnitude) {} // 0x0000000189655DC8-0x0000000189655F14
		protected override void OnModifyOffset() {} // 0x0000000189656128-0x0000000189656C74
		private void AfterFBBIK() {} // 0x0000000189655C80-0x0000000189655DC8
		private void AfterAimIK() {} // 0x0000000189655BD0-0x0000000189655C80
		protected override void OnDestroy() {} // 0x0000000189655F14-0x0000000189656128
	}

	public class ShoulderRotator : MonoBehaviour // TypeDefIndex: 52814
	{
		// Fields
		[Tooltip("Weight of shoulder rotation")]
		public float weight; // 0x18
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset; // 0x1C
		private FullBodyBipedIK ik; // 0x20
		private bool skip; // 0x28
	
		// Constructors
		public ShoulderRotator() {} // 0x0000000189657664-0x000000018965767C
	
		// Methods
		private void Start() {} // 0x0000000189657548-0x0000000189657664
		private void RotateShoulders() {} // 0x0000000189657470-0x0000000189657548
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset) {} // 0x000000018965701C-0x0000000189657470
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain) => default; // 0x0000000189656EB8-0x0000000189656EF4
		private void OnDestroy() {} // 0x0000000189656EF4-0x000000018965701C
	}

	public static class VRIKCalibrator // TypeDefIndex: 52818
	{
		// Nested types
		[Serializable]
		public class Settings // TypeDefIndex: 52815
		{
			// Fields
			[Tooltip("Multiplies character scale")]
			public float scaleMlp; // 0x10
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward; // 0x14
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp; // 0x20
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward; // 0x2C
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp; // 0x38
			[Tooltip("Local axis of the foot trackers towards the player\'s forward direction.")]
			public Vector3 footTrackerForward; // 0x44
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp; // 0x50
			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset; // 0x5C
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset; // 0x68
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset; // 0x74
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset; // 0x78
			[Range(-180f, 180f)]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			public float footHeadingOffset; // 0x7C
			[Range(0f, 1f)]
			public float pelvisPositionWeight; // 0x80
			[Range(0f, 1f)]
			public float pelvisRotationWeight; // 0x84
	
			// Constructors
			public Settings() {} // 0x0000000189656DF0-0x0000000189656EB8
		}
	
		[Serializable]
		public class CalibrationData // TypeDefIndex: 52817
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
			public class Target // TypeDefIndex: 52816
			{
				// Fields
				public bool used; // 0x10
				public Vector3 localPosition; // 0x14
				public Quaternion localRotation; // 0x20
	
				// Constructors
				public Target() {} // Dummy constructor
				public Target(Transform t) {} // 0x00000001896576E4-0x0000000189657780
	
				// Methods
				public void SetTo(Transform t) {} // 0x000000018965767C-0x00000001896576E4
			}
	
			// Constructors
			public CalibrationData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Methods
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings) {} // 0x000000018965C148-0x000000018965C16C
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp) {} // 0x000000018965C0E8-0x000000018965C148
		private static void CalibrateScale(VRIK ik, Settings settings) {} // 0x0000000189659418-0x0000000189659438
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f /* Metadata: 0x01FD2B93 */) {} // 0x0000000189659438-0x00000001896595C4
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null) => default; // 0x000000018965A13C-0x000000018965B92C
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft) {} // 0x0000000189658CD8-0x0000000189659418
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null) {} // 0x00000001896595C4-0x000000018965A13C
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft) {} // 0x0000000189658A88-0x0000000189658CD8
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f /* Metadata: 0x01FD2B97 */) => default; // 0x000000018965B92C-0x000000018965BB78
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset) {} // 0x00000001896584F8-0x0000000189658A88
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset) {} // 0x0000000189657AF0-0x0000000189657DEC
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset) {} // 0x00000001896582A8-0x00000001896584F8
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft) {} // 0x0000000189657DEC-0x00000001896582A8
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm) => default; // 0x000000018965BF6C-0x000000018965C0E8
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm) => default; // 0x000000018965BB78-0x000000018965BF6C
	}

	public class VRIKLODController : MonoBehaviour // TypeDefIndex: 52819
	{
		// Fields
		public Renderer LODRenderer; // 0x18
		public float LODDistance; // 0x20
		public bool allowCulled; // 0x24
		private VRIK ik; // 0x28
	
		// Constructors
		public VRIKLODController() {} // 0x000000018965C344-0x000000018965C358
	
		// Methods
		private void Start() {} // 0x000000018965C2C8-0x000000018965C310
		private void Update() {} // 0x000000018965C310-0x000000018965C344
		private int GetLODLevel() => default; // 0x000000018965C16C-0x000000018965C2C8
	}

	public class VRIKRootController : MonoBehaviour // TypeDefIndex: 52820
	{
		// Fields
		private Transform pelvisTarget; // 0x28
		private Transform leftFootTarget; // 0x30
		private Transform rightFootTarget; // 0x38
		private VRIK ik; // 0x40
	
		// Properties
		public Vector3 pelvisTargetRight { get; private set; } // 0x0000000183D52510-0x0000000183D52530 0x0000000183D52530-0x0000000183D52540
	
		// Constructors
		public VRIKRootController() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x000000018965C358-0x000000018965C484
		public void Calibrate() {} // 0x000000018965C484-0x000000018965C6A8
		public void Calibrate(VRIKCalibrator.CalibrationData data) {} // 0x000000018965C6A8-0x000000018965C830
		private void OnPreUpdate() {} // 0x000000018965C958-0x000000018965CE64
		private void OnDestroy() {} // 0x000000018965C830-0x000000018965C958
	}
}
