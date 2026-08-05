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

// Image 27: RootMotion.dll - Assembly: RootMotion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56068-56293
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 56293
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_16 CF97ADEEDB59E05BFD73A2B4C2A8885708C4F4F70C84C64B27120E72AB733B72; // 0x00 // Static value (base64): AQAAAAIAAAADAAAABAAAAA== - Metadata: 0x02347974

	// Nested types
	private struct __StaticArrayInitTypeSize_16 // TypeDefIndex: 56292
	{
	}
}

namespace RootMotion
{
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour // TypeDefIndex: 56075
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
		[CompilerGenerated]
		private bool _isBaking_k__BackingField; // 0x50
		[CompilerGenerated]
		private float _bakingProgress_k__BackingField; // 0x54
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
		[CompilerGenerated]
		private float _clipLength_k__BackingField; // 0x88
		protected bool addLoopFrame; // 0x8C
	
		// Properties
		public bool isBaking { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86800-0x0000000184D86810 0x0000000184D86840-0x0000000184D86850
		public float bakingProgress { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86E00-0x0000000184D86E10 0x0000000184D86E10-0x0000000184D86E20
		protected float clipLength { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E220-0x0000000184D8E230 0x0000000184D8E250-0x0000000184D8E260
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 56069
		{
			AnimationClips = 0,
			AnimationStates = 1,
			PlayableDirector = 2,
			Realtime = 3
		}
	
		public delegate void BakerDelegate(AnimationClip clip, float time); // TypeDefIndex: 56070; 0x00000001838E1420-0x00000001838E1430
	
		[Serializable]
		public class ClipSettings // TypeDefIndex: 56074
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
			public enum BasedUponRotation // TypeDefIndex: 56071
			{
				Original = 0,
				BodyOrientation = 1
			}
	
			[Serializable]
			public enum BasedUponY // TypeDefIndex: 56072
			{
				Original = 0,
				CenterOfMass = 1,
				Feet = 2
			}
	
			[Serializable]
			public enum BasedUponXZ // TypeDefIndex: 56073
			{
				Original = 0,
				CenterOfMass = 1
			}
	
			// Constructors
			public ClipSettings(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		protected Baker(); // 0x000000018ABD7DDC-0x000000018ABD7EC0
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018ABD7D74-0x000000018ABD7DA8
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018ABD7D40-0x000000018ABD7D74
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABD7DA8-0x000000018ABD7DDC
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABD7D0C-0x000000018ABD7D40
		protected abstract Transform GetCharacterRoot();
		protected abstract void OnStartBaking();
		protected abstract void OnSetLoopFrame(float time);
		protected abstract void OnSetCurves(ref AnimationClip clip);
		protected abstract void OnSetKeyframes(float time, bool lastFrame);
		public void BakeClip(); // 0x00000001841E1670-0x00000001841E1680
		public void StartBaking(); // 0x00000001841E1670-0x00000001841E1680
		public void StopBaking(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class GenericBaker : Baker // TypeDefIndex: 56076
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
		public GenericBaker(); // 0x000000018ABDE9DC-0x000000018ABDEA38
	
		// Methods
		private void Awake(); // 0x000000018ABDE448-0x000000018ABDE670
		protected override Transform GetCharacterRoot(); // 0x0000000184D85EE0-0x0000000184D85EF0
		protected override void OnStartBaking(); // 0x000000018ABDE8E8-0x000000018ABDE9DC
		protected override void OnSetLoopFrame(float time); // 0x000000018ABDE880-0x000000018ABDE8E8
		protected override void OnSetCurves(ref AnimationClip clip); // 0x000000018ABDE7B0-0x000000018ABDE818
		protected override void OnSetKeyframes(float time, bool lastFrame); // 0x000000018ABDE818-0x000000018ABDE880
		private bool IsIgnored(Transform t); // 0x000000018ABDE710-0x000000018ABDE7B0
		private bool BakePosition(Transform t); // 0x000000018ABDE670-0x000000018ABDE710
	}

	public class TQ // TypeDefIndex: 56077
	{
		// Fields
		public Vector3 t; // 0x10
		public Quaternion q; // 0x1C
	
		// Constructors
		public TQ(); // 0x00000001841E1670-0x00000001841E1680
		public TQ(Vector3 translation, Quaternion rotation); // 0x0000000184DA9470-0x0000000184DA9490
	}

	public class AvatarUtility // TypeDefIndex: 56078
	{
		// Constructors
		public AvatarUtility(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal); // 0x000000018ABD4100-0x000000018ABD42FC
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ); // 0x000000018ABD3B40-0x000000018ABD4100
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal); // 0x000000018ABD4480-0x000000018ABD48CC
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale); // 0x000000018ABD42FC-0x000000018ABD444C
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal); // 0x000000018ABD444C-0x000000018ABD4480
	}

	public static class BakerUtilities // TypeDefIndex: 56079
	{
		// Methods
		public static void ReduceKeyframes(AnimationCurve curve, float maxError); // 0x000000018ABD7B7C-0x000000018ABD7BBC
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError); // 0x000000018ABD784C-0x000000018ABD7B7C
		public static void SetLoopFrame(float time, AnimationCurve curve); // 0x000000018ABD7BBC-0x000000018ABD7D0C
		public static void SetTangentMode(AnimationCurve curve); // 0x00000001841E1670-0x00000001841E1680
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q); // 0x000000018ABD76B4-0x000000018ABD784C
	}

	[Serializable]
	public class BakerHumanoidQT // TypeDefIndex: 56080
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
		public BakerHumanoidQT(string name); // 0x000000018ABD5C28-0x000000018ABD5D8C
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name); // 0x000000018ABD5D8C-0x000000018ABD5F1C
	
		// Methods
		public Quaternion EvaluateRotation(float time); // 0x000000018ABD4F50-0x000000018ABD5018
		public Vector3 EvaluatePosition(float time); // 0x000000018ABD4EB4-0x000000018ABD4F50
		public TQ Evaluate(float time); // 0x000000018ABD5018-0x000000018ABD50B8
		public void GetCurvesFromClip(AnimationClip clip, Animator animator); // 0x00000001841E1670-0x00000001841E1680
		public void Reset(); // 0x000000018ABD5230-0x000000018ABD53D0
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation); // 0x000000018ABD576C-0x000000018ABD5AAC
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot); // 0x000000018ABD5AAC-0x000000018ABD5BA0
		public void MoveLastKeyframes(float time); // 0x000000018ABD511C-0x000000018ABD51B4
		public void SetLoopFrame(float time); // 0x000000018ABD5BA0-0x000000018ABD5C28
		public void SetRootLoopFrame(float time); // 0x00000001841E1670-0x00000001841E1680
		private void MoveLastKeyframe(float time, AnimationCurve curve); // 0x000000018ABD50B8-0x000000018ABD511C
		public void MultiplyLength(AnimationCurve curve, float mlp); // 0x000000018ABD51B4-0x000000018ABD5230
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp); // 0x000000018ABD53D0-0x000000018ABD576C
	}

	[Serializable]
	public class BakerMuscle // TypeDefIndex: 56081
	{
		// Fields
		public AnimationCurve curve; // 0x10
		private int muscleIndex; // 0x18
		private string propertyName; // 0x20
	
		// Constructors
		public BakerMuscle(int muscleIndex); // 0x000000018ABD6A68-0x000000018ABD6ACC
	
		// Methods
		private string MuscleNameToPropertyName(string n); // 0x000000018ABD5F1C-0x000000018ABD68B8
		public void MultiplyLength(AnimationCurve curve, float mlp); // 0x000000018ABD51B4-0x000000018ABD5230
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp); // 0x000000018ABD691C-0x000000018ABD6A18
		public void Reset(); // 0x000000018ABD68B8-0x000000018ABD691C
		public void SetKeyframe(float time, float[] muscles); // 0x000000018ABD6A18-0x000000018ABD6A58
		public void SetLoopFrame(float time); // 0x000000018ABD6A58-0x000000018ABD6A68
	}

	[Serializable]
	public class BakerTransform // TypeDefIndex: 56082
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
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode); // 0x000000018ABD762C-0x000000018ABD76B4
	
		// Methods
		public void SetRelativeSpace(Vector3 position, Quaternion rotation); // 0x0000000184DA8EF0-0x0000000184DA8F10
		public void SetCurves(ref AnimationClip clip); // 0x000000018ABD7150-0x000000018ABD7420
		private void AddRootMotionCurves(ref AnimationClip clip); // 0x000000018ABD6CA8-0x000000018ABD6F54
		public void Reset(); // 0x000000018ABD6FD8-0x000000018ABD7150
		public void ReduceKeyframes(float maxError); // 0x000000018ABD6F54-0x000000018ABD6FD8
		public void SetKeyframes(float time); // 0x000000018ABD7420-0x000000018ABD762C
		public void AddLoopFrame(float time); // 0x000000018ABD6ACC-0x000000018ABD6CA8
	}

	public class HumanoidBaker : Baker // TypeDefIndex: 56083
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
		public HumanoidBaker(); // 0x000000018ABE010C-0x000000018ABE01A0
	
		// Methods
		private void Awake(); // 0x000000018ABDF380-0x000000018ABDF87C
		protected override Transform GetCharacterRoot(); // 0x000000018ABDF87C-0x000000018ABDF89C
		protected override void OnStartBaking(); // 0x000000018ABDFF3C-0x000000018ABE0020
		protected override void OnSetLoopFrame(float time); // 0x000000018ABDFE5C-0x000000018ABDFF3C
		protected override void OnSetCurves(ref AnimationClip clip); // 0x000000018ABDF89C-0x000000018ABDFAA8
		protected override void OnSetKeyframes(float time, bool lastFrame); // 0x000000018ABDFAA8-0x000000018ABDFE5C
		private void UpdateHumanPose(); // 0x000000018ABE0020-0x000000018ABE010C
	}

	[Serializable]
	public enum Axis // TypeDefIndex: 56084
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public class AxisTools // TypeDefIndex: 56085
	{
		// Constructors
		public AxisTools(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static Vector3 ToVector3(RootMotion.Axis axis); // 0x000000018ABD4DF4-0x000000018ABD4E34
		public static RootMotion.Axis ToAxis(Vector3 v); // 0x000000018ABD4DB4-0x000000018ABD4DF4
		public static RootMotion.Axis GetAxisToPoint(Transform t, Vector3 worldPosition); // 0x000000018ABD49B8-0x000000018ABD4AA4
		public static RootMotion.Axis GetAxisToDirection(Transform t, Vector3 direction); // 0x000000018ABD48CC-0x000000018ABD49B8
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition); // 0x000000018ABD4D04-0x000000018ABD4DB4
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction); // 0x000000018ABD4AA4-0x000000018ABD4B10
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction); // 0x000000018ABD4B10-0x000000018ABD4D04
	}

	[Serializable]
	public class BipedLimbOrientations // TypeDefIndex: 56087
	{
		// Fields
		public LimbOrientation leftArm; // 0x10
		public LimbOrientation rightArm; // 0x18
		public LimbOrientation leftLeg; // 0x20
		public LimbOrientation rightLeg; // 0x28
	
		// Properties
		public static BipedLimbOrientations UMA { get; } // 0x000000018ABD88A8-0x000000018ABD8B38 
		public static BipedLimbOrientations MaxBiped { get; } // 0x000000018ABD8618-0x000000018ABD88A8 
	
		// Nested types
		[Serializable]
		public class LimbOrientation // TypeDefIndex: 56086
		{
			// Fields
			public Vector3 upperBoneForwardAxis; // 0x10
			public Vector3 lowerBoneForwardAxis; // 0x1C
			public Vector3 lastBoneLeftAxis; // 0x28
	
			// Constructors
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis); // 0x0000000184D8EB70-0x0000000184D8EBB0
		}
	
		// Constructors
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg); // 0x00000001832FABF0-0x00000001832FAC40
	}

	public static class BipedNaming // TypeDefIndex: 56090
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
		public enum BoneType // TypeDefIndex: 56088
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
		public enum BoneSide // TypeDefIndex: 56089
		{
			Center = 0,
			Left = 1,
			Right = 2
		}
	
		// Constructors
		static BipedNaming(); // 0x000000018ABD91B8-0x000000018ABDA430
	
		// Methods
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones); // 0x000000018ABD8ECC-0x000000018ABD901C
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones); // 0x000000018ABD8D14-0x000000018ABD8E64
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones); // 0x000000018ABD8E64-0x000000018ABD8ECC
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones); // 0x000000018ABD901C-0x000000018ABD90A0
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings); // 0x000000018ABD90A0-0x000000018ABD9180
		public static BoneType GetBoneType(string boneName); // 0x000000018ABD8BA4-0x000000018ABD8C9C
		public static BoneSide GetBoneSide(string boneName); // 0x000000018ABD8B38-0x000000018ABD8BA4
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center /* Metadata: 0x023478A6 */, params string[][] namings); // 0x000000018ABD8C9C-0x000000018ABD8D14
		private static bool isLeft(string boneName); // 0x000000018ABDA68C-0x000000018ABDA74C
		private static bool isRight(string boneName); // 0x000000018ABDA7D4-0x000000018ABDA894
		private static bool isSpine(string boneName); // 0x000000018ABDA894-0x000000018ABDA91C
		private static bool isHead(string boneName); // 0x000000018ABDA604-0x000000018ABDA68C
		private static bool isArm(string boneName); // 0x000000018ABDA4F4-0x000000018ABDA57C
		private static bool isLeg(string boneName); // 0x000000018ABDA74C-0x000000018ABDA7D4
		private static bool isTail(string boneName); // 0x000000018ABDA91C-0x000000018ABDA9A4
		private static bool isEye(string boneName); // 0x000000018ABDA57C-0x000000018ABDA604
		private static bool isTypeExclude(string boneName); // 0x000000018ABDA9A4-0x000000018ABDA9F8
		private static bool matchesNaming(string boneName, string[] namingConvention); // 0x000000018ABDAAEC-0x000000018ABDAB9C
		private static bool excludesNaming(string boneName, string[] namingConvention); // 0x000000018ABDA430-0x000000018ABDA498
		private static bool matchesLastLetter(string boneName, string[] namingConvention); // 0x000000018ABDAA54-0x000000018ABDAAEC
		private static bool LastLetterIs(string boneName, string letter); // 0x000000018ABD9180-0x000000018ABD91B8
		private static string firstLetter(string boneName); // 0x000000018ABDA498-0x000000018ABDA4F4
		private static string lastLetter(string boneName); // 0x000000018ABDA9F8-0x000000018ABDAA54
	}

	[Serializable]
	public class BipedReferences // TypeDefIndex: 56092
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
		public virtual bool isFilled { get; } // 0x00000001839DCB00-0x00000001839DD2A0 
		public bool isEmpty { get; } // 0x000000018ABDCCD0-0x000000018ABDCCDC 
	
		// Nested types
		public struct AutoDetectParams // TypeDefIndex: 56091
		{
			// Fields
			public bool legsParentInSpine; // 0x00
			public bool includeEyes; // 0x01
	
			// Properties
			public static AutoDetectParams Default { get; } // 0x0000000184DA8EE0-0x0000000184DA8EF0 
	
			// Constructors
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes); // 0x0000000182BBF3D0-0x0000000182BBF3E0
		}
	
		// Constructors
		public BipedReferences(); // 0x00000001839DD730-0x00000001839DD7A0
	
		// Methods
		public virtual bool IsEmpty(bool includeRoot); // 0x000000018ABDC3B0-0x000000018ABDC6BC
		public virtual bool Contains(Transform t, bool ignoreRoot = false /* Metadata: 0x023478B1 */); // 0x000000018ABDB50C-0x000000018ABDB838
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams); // 0x000000018ABDB314-0x000000018ABDB50C
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams); // 0x000000018ABDB958-0x000000018ABDC0EC
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams); // 0x000000018ABDAE74-0x000000018ABDB314
		public static bool SetupError(BipedReferences references, ref string errorMessage); // 0x00000001839DD2A0-0x00000001839DD3C0
		public static bool SetupWarning(BipedReferences references, ref string warningMessage); // 0x000000018ABDCC04-0x000000018ABDCCD0
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm); // 0x000000018ABDC6BC-0x000000018ABDC778
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams); // 0x000000018ABDAB9C-0x000000018ABDAC78
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams); // 0x000000018ABDAD2C-0x000000018ABDAE74
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms); // 0x000000018ABDB838-0x000000018ABDB958
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform); // 0x000000018ABDAC78-0x000000018ABDAD2C
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage); // 0x00000001835B1DE0-0x00000001835B22D0
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage); // 0x000000018ABDC778-0x000000018ABDCA0C
		private static bool SpineError(BipedReferences references, ref string errorMessage); // 0x00000001839E01C0-0x00000001839E0590
		private static bool SpineWarning(BipedReferences references, ref string warningMessage); // 0x00000001812081B0-0x0000000181208610
		private static bool EyesError(BipedReferences references, ref string errorMessage); // 0x00000001839DD3C0-0x00000001839DD470
		private static bool EyesWarning(BipedReferences references, ref string warningMessage); // 0x00000001812081B0-0x0000000181208610
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage); // 0x000000018ABDCA0C-0x000000018ABDCC04
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage); // 0x000000018ABDC0EC-0x000000018ABDC308
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation); // 0x000000018ABDC308-0x000000018ABDC3B0
	}

	public class Comments : MonoBehaviour // TypeDefIndex: 56093
	{
		// Fields
		[Multiline]
		public string text; // 0x18
	
		// Constructors
		public Comments(); // 0x0000000185393520-0x0000000185393538
	}

	public class DemoGUIMessage : MonoBehaviour // TypeDefIndex: 56094
	{
		// Fields
		public string text; // 0x18
		public UnityEngine.Color color; // 0x20
	
		// Constructors
		public DemoGUIMessage(); // 0x000000018ABDD30C-0x000000018ABDD344
	
		// Methods
		private void OnGUI(); // 0x000000018ABDD268-0x000000018ABDD30C
	}

	public class Hierarchy // TypeDefIndex: 56095
	{
		// Constructors
		public Hierarchy(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static bool HierarchyIsValid(Transform[] bones); // 0x00000001839DFDE0-0x00000001839DFE50
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects); // 0x00000001835B1D00-0x00000001835B1DE0
		public static bool IsAncestor(Transform transform, Transform ancestor); // 0x00000001839DFE50-0x00000001839E0040
		public static bool ContainsChild(Transform transform, Transform child); // 0x000000018ABDEC94-0x000000018ABDED6C
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array); // 0x000000018ABDEA38-0x000000018ABDEC94
		public static Transform GetAncestor(Transform transform, int minChildCount); // 0x000000018ABDED6C-0x000000018ABDEE40
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2); // 0x000000018ABDEF90-0x000000018ABDF0BC
		public static Transform GetFirstCommonAncestor(Transform[] transforms); // 0x000000018ABDF0BC-0x000000018ABDF1DC
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms); // 0x000000018ABDEE40-0x000000018ABDEF90
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms); // 0x000000018ABDF1DC-0x000000018ABDF380
	}

	public class InspectorComment : PropertyAttribute // TypeDefIndex: 56096
	{
		// Fields
		public string name; // 0x10
		public string color; // 0x18
	
		// Constructors
		public InspectorComment(string name); // 0x000000018ABE0214-0x000000018ABE0280
		public InspectorComment(string name, string color); // 0x000000018ABE01A0-0x000000018ABE0214
	}

	[Serializable]
	public enum InterpolationMode // TypeDefIndex: 56097
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

	public class Interp // TypeDefIndex: 56098
	{
		// Constructors
		public Interp(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static float Float(float t, RootMotion.InterpolationMode mode); // 0x000000018ABE0280-0x000000018ABE05D0
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, RootMotion.InterpolationMode mode); // 0x000000018ABE0890-0x000000018ABE0960
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed); // 0x00000001831CD6D0-0x00000001831CD780
		private static float None(float t, float b, float c); // 0x0000000184DA9140-0x0000000184DA9150
		private static float InOutCubic(float t, float b, float c); // 0x0000000184DA9070-0x0000000184DA90A0
		private static float InOutQuintic(float t, float b, float c); // 0x0000000184DA90A0-0x0000000184DA90F0
		private static float InQuintic(float t, float b, float c); // 0x0000000184DA9120-0x0000000184DA9140
		private static float InQuartic(float t, float b, float c); // 0x0000000184DA9100-0x0000000184DA9120
		private static float InCubic(float t, float b, float c); // 0x0000000184DA8F90-0x0000000184DA8FB0
		private static float InQuadratic(float t, float b, float c); // 0x0000000184DA90F0-0x0000000184DA9100
		private static float OutQuintic(float t, float b, float c); // 0x0000000184DA9400-0x0000000184DA9470
		private static float OutQuartic(float t, float b, float c); // 0x0000000184DA93A0-0x0000000184DA9400
		private static float OutCubic(float t, float b, float c); // 0x0000000184DA91E0-0x0000000184DA9220
		private static float OutInCubic(float t, float b, float c); // 0x0000000184DA9320-0x0000000184DA9360
		private static float OutInQuartic(float t, float b, float c); // 0x0000000184DA9360-0x0000000184DA93A0
		private static float BackInCubic(float t, float b, float c); // 0x0000000184DA8F20-0x0000000184DA8F50
		private static float BackInQuartic(float t, float b, float c); // 0x0000000184DA8F50-0x0000000184DA8F90
		private static float OutBackCubic(float t, float b, float c); // 0x0000000184DA9150-0x0000000184DA9190
		private static float OutBackQuartic(float t, float b, float c); // 0x0000000184DA9190-0x0000000184DA91E0
		private static float OutElasticSmall(float t, float b, float c); // 0x0000000184DA92A0-0x0000000184DA9320
		private static float OutElasticBig(float t, float b, float c); // 0x0000000184DA9220-0x0000000184DA92A0
		private static float InElasticSmall(float t, float b, float c); // 0x0000000184DA9010-0x0000000184DA9070
		private static float InElasticBig(float t, float b, float c); // 0x0000000184DA8FB0-0x0000000184DA9010
		private static float InSine(float t, float b, float c); // 0x000000018ABE0714-0x000000018ABE0760
		private static float OutSine(float t, float b, float c); // 0x000000018ABE0854-0x000000018ABE0890
		private static float InOutSine(float t, float b, float c); // 0x000000018ABE06C0-0x000000018ABE0714
		private static float InElastic(float t, float b, float c); // 0x000000018ABE05F8-0x000000018ABE06C0
		private static float OutElastic(float t, float b, float c); // 0x000000018ABE079C-0x000000018ABE0854
		private static float InBack(float t, float b, float c); // 0x000000018ABE05D0-0x000000018ABE05F8
		private static float OutBack(float t, float b, float c); // 0x000000018ABE0760-0x000000018ABE079C
	}

	public static class LayerMaskExtensions // TypeDefIndex: 56099
	{
		// Methods
		public static bool Contains(LayerMask mask, int layer); // 0x000000018ABE0A40-0x000000018ABE0A50
		public static LayerMask Create(params string[] layerNames); // 0x000000018A994A28-0x000000018A994A30
		public static LayerMask Create(params int[] layerNumbers); // 0x000000018A994A30-0x000000018A994A38
		public static LayerMask NamesToMask(params string[] layerNames); // 0x000000018A994A38-0x000000018A994A94
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers); // 0x000000018A994A94-0x000000018A994AD4
	
		// Extension methods
		public static LayerMask Inverse(this LayerMask original); // 0x0000000184DA68B0-0x0000000184DA68C0
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames); // 0x000000018A994948-0x000000018A994968
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames); // 0x000000018A994C78-0x000000018A994C9C
		public static string[] MaskToNames(this LayerMask original); // 0x000000018ABE0A50-0x000000018ABE0B2C
		public static int[] MaskToNumbers(this LayerMask original); // 0x000000018ABE0B2C-0x000000018ABE0BF4
		public static string MaskToString(this LayerMask original); // 0x000000018ABE0BF4-0x000000018ABE0C30
		public static string MaskToString(this LayerMask original, string delimiter); // 0x000000018ABE0C30-0x000000018ABE0CBC
	}

	public abstract class LazySingleton<T> : MonoBehaviour // TypeDefIndex: 56100
		where T : LazySingleton<T>
	{
		// Fields
		private static T sInstance;
	
		// Properties
		public static bool hasInstance { get; }
		public static T instance { get; }
	
		// Constructors
		protected LazySingleton();
	
		// Methods
		protected virtual void Awake();
	}

	public enum ShowIfMode // TypeDefIndex: 56101
	{
		Disabled = 0,
		Hidden = 1
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowIfAttribute : PropertyAttribute // TypeDefIndex: 56102
	{
		// Fields
		[CompilerGenerated]
		private string _propName_k__BackingField; // 0x10
		[CompilerGenerated]
		private object _propValue_k__BackingField; // 0x18
		[CompilerGenerated]
		private object _otherPropValue_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _indent_k__BackingField; // 0x28
		[CompilerGenerated]
		private ShowIfMode _mode_k__BackingField; // 0x2C
	
		// Properties
		public string propName { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public object propValue { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public object otherPropValue { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public bool indent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		public ShowIfMode mode { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
	
		// Constructors
		public ShowIfAttribute(string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x023478CF */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x023478D0 */); // 0x000000018ABE2800-0x000000018ABE2848
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowRangeIfAttribute : ShowIfAttribute // TypeDefIndex: 56103
	{
		// Fields
		[CompilerGenerated]
		private float _min_k__BackingField; // 0x30
		[CompilerGenerated]
		private float _max_k__BackingField; // 0x34
	
		// Properties
		public float min { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86E20-0x0000000184D86E30 0x0000000184D86E30-0x0000000184D86E40
		public float max { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E050-0x0000000184D8E060 0x0000000184D8E060-0x0000000184D8E070
	
		// Constructors
		public ShowRangeIfAttribute(float min, float max, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x023478D1 */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x023478D2 */); // 0x000000018ABE29AC-0x000000018ABE2A18
	}

	public class ShowLargeHeaderIf : ShowIfAttribute // TypeDefIndex: 56104
	{
		// Fields
		public string name; // 0x30
		public string color; // 0x38
	
		// Constructors
		public ShowLargeHeaderIf(string name, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x023478D3 */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x023478D4 */); // 0x000000018ABE28F8-0x000000018ABE29AC
		public ShowLargeHeaderIf(string name, string color, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x023478D5 */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x023478D6 */); // 0x000000018ABE2848-0x000000018ABE28F8
	}

	public class LargeHeader : PropertyAttribute // TypeDefIndex: 56105
	{
		// Fields
		public string name; // 0x10
		public string color; // 0x18
	
		// Constructors
		public LargeHeader(string name); // 0x000000018ABE09D4-0x000000018ABE0A40
		public LargeHeader(string name, string color); // 0x000000018ABE0960-0x000000018ABE09D4
	}

	public static class QuaTools // TypeDefIndex: 56106
	{
		// Methods
		public static float GetYaw(Quaternion space, Vector3 forward); // 0x000000018ABE20D4-0x000000018ABE214C
		public static float GetPitch(Quaternion space, Vector3 forward); // 0x000000018ABE2054-0x000000018ABE20D4
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up); // 0x000000018ABE1DF0-0x000000018ABE1F98
		public static float GetYaw(Quaternion space, Quaternion rotation); // 0x000000018ABE214C-0x000000018ABE2210
		public static float GetPitch(Quaternion space, Quaternion rotation); // 0x000000018ABE1F98-0x000000018ABE2054
		public static float GetBank(Quaternion space, Quaternion rotation); // 0x000000018ABE1BF4-0x000000018ABE1DF0
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight); // 0x000000018ABE2210-0x000000018ABE226C
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight); // 0x000000018ABE2698-0x000000018ABE26F4
		public static Quaternion LinearBlend(Quaternion q, float weight); // 0x000000018ABE226C-0x000000018ABE22E8
		public static Quaternion SphericalBlend(Quaternion q, float weight); // 0x000000018ABE26F4-0x000000018ABE2770
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis); // 0x000000018ABE18A4-0x000000018ABE19B8
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation); // 0x0000000184128B30-0x0000000184128BE0
		public static Quaternion FromToRotation(Quaternion from, Quaternion to); // 0x000000018ABE19B8-0x000000018ABE1A5C
		public static Vector3 GetAxis(Vector3 v); // 0x000000018ABE1A5C-0x000000018ABE1BF4
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing); // 0x000000018ABE1720-0x000000018ABE18A4
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing); // 0x000000018ABE1634-0x000000018ABE1720
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2); // 0x000000018ABE22E8-0x000000018ABE2410
		public static Vector3 ToBiPolar(Vector3 euler); // 0x000000018ABE27B0-0x000000018ABE2800
		public static float ToBiPolar(float angle); // 0x000000018ABE2770-0x000000018ABE27B0
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space); // 0x000000018ABE2410-0x000000018ABE2588
		public static Quaternion MirrorYZ(Quaternion r); // 0x000000018ABE2588-0x000000018ABE2698
	}

	public abstract class Singleton<T> : MonoBehaviour // TypeDefIndex: 56107
		where T : Singleton<T>
	{
		// Fields
		private static T sInstance;
	
		// Properties
		public static T instance { get; }
	
		// Constructors
		protected Singleton();
	
		// Methods
		public static void Clear();
		protected virtual void Awake();
	}

	public class SolverManager : MonoBehaviour // TypeDefIndex: 56108
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
		private bool animatePhysics { get; } // 0x00000001835BD390-0x00000001835BD460 
		private bool isAnimated { get; } // 0x000000018408A440-0x000000018408A560 
	
		// Constructors
		public SolverManager(); // 0x0000000185394740-0x000000018539475C
	
		// Methods
		public void Disable(); // 0x000000018ABE2A18-0x000000018ABE2A90
		protected virtual void InitiateSolver(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void UpdateSolver(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void FixTransforms(); // 0x00000001841E1670-0x00000001841E1680
		private void OnDisable(); // 0x0000000184089B40-0x0000000184089B70
		private void Start(); // 0x000000018408A300-0x000000018408A310
		public void Initiate(); // 0x000000018408A310-0x000000018408A350
		private void Update(); // 0x00000001835BD130-0x00000001835BD200
		private void FindAnimatorRecursive(Transform t, bool findInChildren); // 0x000000018408A350-0x000000018408A440
		private void FixedUpdate(); // 0x00000001835BD2D0-0x00000001835BD390
		private void LateUpdate(); // 0x00000001835BD200-0x00000001835BD2D0
		public void UpdateSolverExternal(); // 0x000000018ABE2A90-0x000000018ABE2AC0
	}

	public class TriggerEventBroadcaster : MonoBehaviour // TypeDefIndex: 56109
	{
		// Fields
		public GameObject target; // 0x18
	
		// Constructors
		public TriggerEventBroadcaster(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnTriggerEnter(Collider collider); // 0x000000018ABE2AC0-0x000000018ABE2B58
		private void OnTriggerStay(Collider collider); // 0x000000018ABE2BF0-0x000000018ABE2C88
		private void OnTriggerExit(Collider collider); // 0x000000018ABE2B58-0x000000018ABE2BF0
	}

	public static class V2Tools // TypeDefIndex: 56110
	{
		// Methods
		public static Vector2 XZ(Vector3 v); // 0x0000000184D88A40-0x0000000184D88A60
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2); // 0x000000018ABE2CD8-0x000000018ABE2D34
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2); // 0x000000018ABE2C88-0x000000018ABE2CD8
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r); // 0x000000018ABE2D34-0x000000018ABE2E48
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r); // 0x000000018ABE2E48-0x000000018ABE2F6C
	}

	public static class V3Tools // TypeDefIndex: 56111
	{
		// Methods
		public static float GetYaw(Vector3 forward); // 0x0000000184DA9490-0x0000000184DA94B0
		public static float GetPitch(Vector3 forward); // 0x000000018ABE3A98-0x000000018ABE3ADC
		public static float GetBank(Vector3 forward, Vector3 up); // 0x000000018ABE39D8-0x000000018ABE3A98
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward); // 0x000000018ABE3B88-0x000000018ABE3C38
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward); // 0x000000018ABE3ADC-0x000000018ABE3B88
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up); // 0x000000018ABE3840-0x000000018ABE39D8
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight); // 0x000000018ABE3E14-0x000000018ABE3E8C
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight); // 0x000000018ABE4048-0x000000018ABE40C8
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight); // 0x000000018ABE3620-0x000000018ABE3744
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight); // 0x000000018ABE34DC-0x000000018ABE3620
		public static Vector3 Flatten(Vector3 v, Vector3 normal); // 0x000000018ABE3744-0x000000018ABE3840
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing); // 0x000000018ABE331C-0x000000018ABE34DC
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed); // 0x000000018ABE2F6C-0x000000018ABE3138
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue); // 0x000000018ABE3138-0x000000018ABE331C
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint); // 0x00000001831CD780-0x00000001831CD8D0
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal); // 0x000000018ABE3E8C-0x000000018ABE4048
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point); // 0x000000018ABE40C8-0x000000018ABE41A4
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point); // 0x000000018ABE3C38-0x000000018ABE3D24
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point); // 0x000000018ABE3D24-0x000000018ABE3E14
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point); // 0x000000018ABE41A4-0x000000018ABE4270
		public static Vector3 Div(Vector3 v1, Vector3 v2); // 0x000000018AAED088-0x000000018AAED0BC
	}

	public static class Warning // TypeDefIndex: 56113
	{
		// Fields
		public static bool logged; // 0x00
	
		// Nested types
		public delegate void Logger(string message); // TypeDefIndex: 56112; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Methods
		public static void Log(string message, Logger logger, bool logInEditMode = false /* Metadata: 0x023478D7 */); // 0x000000018ABE4310-0x000000018ABE4418
		public static void Log(string message, Transform context, bool logInEditMode = false /* Metadata: 0x023478D8 */); // 0x000000018ABE4270-0x000000018ABE4310
	}
}

namespace RootMotion.Demos
{
	[Serializable]
	public class Navigator // TypeDefIndex: 56115
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
		[CompilerGenerated]
		private Vector3 _normalizedDeltaPosition_k__BackingField; // 0x24
		[CompilerGenerated]
		private State _state_k__BackingField; // 0x30
		private Transform transform; // 0x38
		private int cornerIndex; // 0x40
		private Vector3[] corners; // 0x48
		private NavMeshPath path; // 0x50
		private Vector3 lastTargetPosition; // 0x58
		private bool initiated; // 0x64
		private float nextPathTime; // 0x68
	
		// Properties
		public Vector3 normalizedDeltaPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D905E0-0x0000000184D90600 0x0000000184D905D0-0x0000000184D905E0
		public State state { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
	
		// Nested types
		public enum State // TypeDefIndex: 56114
		{
			Idle = 0,
			Seeking = 1,
			OnPath = 2
		}
	
		// Constructors
		public Navigator(); // 0x000000018ABE15D0-0x000000018ABE1634
	
		// Methods
		public void Initiate(Transform transform); // 0x000000018ABE0F30-0x000000018ABE0FF4
		public void Update(Vector3 targetPosition); // 0x000000018ABE1010-0x000000018ABE13C8
		private void CalculatePath(Vector3 targetPosition); // 0x000000018ABE0CBC-0x000000018ABE0D40
		private bool Find(Vector3 targetPosition); // 0x000000018ABE0D40-0x000000018ABE0F04
		private void Stop(); // 0x000000018ABE0FF4-0x000000018ABE1010
		private float HorDistance(Vector3 p1, Vector3 p2); // 0x000000018ABE0F04-0x000000018ABE0F30
		public void Visualize(); // 0x000000018ABE13C8-0x000000018ABE15D0
	}
}

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	public class BipedIK : SolverManager // TypeDefIndex: 56116
	{
		// Fields
		public BipedReferences references; // 0x38
		public BipedIKSolvers solvers; // 0x40
	
		// Constructors
		public BipedIK(); // 0x00000001839DD680-0x00000001839DD730
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018ABD81E8-0x000000018ABD821C
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018ABD81B4-0x000000018ABD81E8
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABD85D4-0x000000018ABD8608
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABD8018-0x000000018ABD804C
		public float GetIKPositionWeight(AvatarIKGoal goal); // 0x000000018ABD80AC-0x000000018ABD80D0
		public float GetIKRotationWeight(AvatarIKGoal goal); // 0x000000018ABD8120-0x000000018ABD8144
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight); // 0x000000018ABD821C-0x000000018ABD8254
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight); // 0x000000018ABD8288-0x000000018ABD82C0
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition); // 0x000000018ABD8254-0x000000018ABD8288
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation); // 0x000000018ABD82C0-0x000000018ABD82EC
		public Vector3 GetIKPosition(AvatarIKGoal goal); // 0x000000018ABD80D0-0x000000018ABD8120
		public Quaternion GetIKRotation(AvatarIKGoal goal); // 0x000000018ABD8144-0x000000018ABD817C
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes); // 0x000000018ABD831C-0x000000018ABD8388
		public void SetLookAtPosition(Vector3 lookAtPosition); // 0x000000018ABD82EC-0x000000018ABD831C
		public void SetSpinePosition(Vector3 spinePosition); // 0x000000018ABD8388-0x000000018ABD83B8
		public void SetSpineWeight(float weight); // 0x000000018ABD83B8-0x000000018ABD83E0
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal); // 0x000000018ABD804C-0x000000018ABD80AC
		public void InitiateBipedIK(); // 0x000000018ABD817C-0x000000018ABD818C
		public void UpdateBipedIK(); // 0x000000018ABD8608-0x000000018ABD8618
		public void SetToDefaults(); // 0x000000018ABD83E0-0x000000018ABD85D4
		protected override void FixTransforms(); // 0x000000018326A140-0x000000018326A380
		protected override void InitiateSolver(); // 0x00000001839DE270-0x00000001839DE430
		protected override void UpdateSolver(); // 0x000000018326A380-0x000000018326AB60
		public void LogWarning(string message); // 0x000000018ABD818C-0x000000018ABD81B4
	}

	[Serializable]
	public class BipedIKSolvers // TypeDefIndex: 56117
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
		public IKSolverLimb[] limbs { get; } // 0x000000018326AB60-0x000000018326AC50 
		public IKSolver[] ikSolvers { get; } // 0x000000018ABD7EC0-0x000000018ABD8018 
	
		// Constructors
		public BipedIKSolvers(); // 0x00000001839DD7A0-0x00000001839DD990
	
		// Methods
		public void AssignReferences(BipedReferences references); // 0x00000001839DE050-0x00000001839DE1F0
	}

	[Serializable]
	public abstract class Constraint // TypeDefIndex: 56118
	{
		// Fields
		public Transform transform; // 0x10
		public float weight; // 0x18
	
		// Properties
		public bool isValid { get; } // 0x000000018ABDD218-0x000000018ABDD268 
	
		// Constructors
		protected Constraint(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public abstract void UpdateConstraint();
	}

	[Serializable]
	public class ConstraintPosition : Constraint // TypeDefIndex: 56119
	{
		// Fields
		public Vector3 position; // 0x20
	
		// Constructors
		public ConstraintPosition(); // 0x00000001841E1670-0x00000001841E1680
		public ConstraintPosition(Transform transform); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void UpdateConstraint(); // 0x000000018ABDCF14-0x000000018ABDCFC0
	}

	[Serializable]
	public class ConstraintPositionOffset : Constraint // TypeDefIndex: 56120
	{
		// Fields
		public Vector3 offset; // 0x20
		private Vector3 defaultLocalPosition; // 0x2C
		private Vector3 lastLocalPosition; // 0x38
		private bool initiated; // 0x44
	
		// Properties
		private bool positionChanged { get; } // 0x000000018ABDCE90-0x000000018ABDCF14 
	
		// Constructors
		public ConstraintPositionOffset(); // 0x00000001841E1670-0x00000001841E1680
		public ConstraintPositionOffset(Transform transform); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void UpdateConstraint(); // 0x000000018ABDCCDC-0x000000018ABDCE90
	}

	[Serializable]
	public class ConstraintRotation : Constraint // TypeDefIndex: 56121
	{
		// Fields
		public Quaternion rotation; // 0x20
	
		// Constructors
		public ConstraintRotation(); // 0x00000001841E1670-0x00000001841E1680
		public ConstraintRotation(Transform transform); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void UpdateConstraint(); // 0x000000018ABDD180-0x000000018ABDD218
	}

	[Serializable]
	public class ConstraintRotationOffset : Constraint // TypeDefIndex: 56122
	{
		// Fields
		public Quaternion offset; // 0x20
		private Quaternion defaultRotation; // 0x30
		private Quaternion defaultLocalRotation; // 0x40
		private Quaternion lastLocalRotation; // 0x50
		private Quaternion defaultTargetLocalRotation; // 0x60
		private bool initiated; // 0x70
	
		// Properties
		private bool rotationChanged { get; } // 0x000000018ABDD128-0x000000018ABDD180 
	
		// Constructors
		public ConstraintRotationOffset(); // 0x00000001841E1670-0x00000001841E1680
		public ConstraintRotationOffset(Transform transform); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void UpdateConstraint(); // 0x000000018ABDCFC0-0x000000018ABDD128
	}

	[Serializable]
	public class Constraints // TypeDefIndex: 56123
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
		public Constraints(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public bool IsValid(); // 0x000000018326B110-0x000000018326B180
		public void Initiate(Transform transform); // 0x00000001839DDFD0-0x00000001839DE050
		public void Update(); // 0x000000018326ADF0-0x000000018326B110
	}

	[Serializable]
	public class Finger // TypeDefIndex: 56125
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
		[CompilerGenerated]
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
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
		public Vector3 IKPosition { get; set; } // 0x000000018ABDE3AC-0x000000018ABDE3D8 0x000000018ABDE3FC-0x000000018ABDE428
		public Quaternion IKRotation { get; set; } // 0x000000018ABDE3D8-0x000000018ABDE3FC 0x000000018ABDE428-0x000000018ABDE448
	
		// Nested types
		[Serializable]
		public enum DOF // TypeDefIndex: 56124
		{
			One = 0,
			Three = 1
		}
	
		// Constructors
		public Finger(); // 0x0000000184DA8F10-0x0000000184DA8F20
	
		// Methods
		public bool IsValid(ref string errorMessage); // 0x000000018ABDDC10-0x000000018ABDDCD8
		public void Initiate(Transform hand, int index); // 0x000000018ABDD418-0x000000018ABDDC10
		public void FixTransforms(); // 0x000000018ABDD344-0x000000018ABDD418
		public void StoreDefaultLocalState(); // 0x000000018ABDDCD8-0x000000018ABDDD90
		public void Update(float masterWeight); // 0x000000018ABDDD90-0x000000018ABDE3AC
	}

	public class FingerRig : SolverManager // TypeDefIndex: 56126
	{
		// Fields
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight; // 0x38
		public Finger[] fingers; // 0x40
		[CompilerGenerated]
		private bool _initiated_k__BackingField; // 0x48
	
		// Properties
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
	
		// Constructors
		public FingerRig(); // 0x000000018ABE5278-0x000000018ABE52D0
	
		// Methods
		public bool IsValid(ref string errorMessage); // 0x000000018ABE5028-0x000000018ABE5090
		[ContextMenu("Auto-detect")]
		public void AutoDetect(); // 0x000000018ABE4CCC-0x000000018ABE4F28
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null); // 0x000000018ABE4B48-0x000000018ABE4CCC
		public void RemoveFinger(int index); // 0x000000018ABE5090-0x000000018ABE51C4
		private void AddChildrenRecursive(Transform parent, ref Transform[] array); // 0x000000018ABE4A8C-0x000000018ABE4B48
		protected override void InitiateSolver(); // 0x000000018ABE4F90-0x000000018ABE5028
		public void UpdateFingerSolvers(); // 0x000000018ABE5210-0x000000018ABE5270
		public void FixFingerTransforms(); // 0x000000018ABE4F28-0x000000018ABE4F7C
		public void StoreDefaultLocalState(); // 0x000000018ABE51C4-0x000000018ABE5210
		protected override void UpdateSolver(); // 0x000000018ABE5270-0x000000018ABE5278
		protected override void FixTransforms(); // 0x000000018ABE4F7C-0x000000018ABE4F90
	}

	public abstract class Grounder : MonoBehaviour // TypeDefIndex: 56128
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
		[CompilerGenerated]
		private bool _initiated_k__BackingField; // 0x48
	
		// Properties
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
	
		// Nested types
		public delegate void GrounderDelegate(); // TypeDefIndex: 56127; 0x00000001853DEDB8-0x00000001853DEDC8
	
		// Constructors
		protected Grounder(); // 0x0000000184407EE0-0x0000000184407F80
	
		// Methods
		public abstract void ResetPosition();
		protected Vector3 GetSpineOffsetTarget(); // 0x000000018ABEAA4C-0x000000018ABEAB2C
		protected void LogWarning(string message); // 0x000000018ABD818C-0x000000018ABD81B4
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg); // 0x000000018ABEA6A4-0x000000018ABEA850
		private Vector3 GetLegSpineTangent(Grounding.Leg leg); // 0x000000018ABEA850-0x000000018ABEAA4C
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderBipedIK : Grounder // TypeDefIndex: 56129
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
		public float RightFootOffsetY { get; } // 0x0000000184D92880-0x0000000184D92890 
		public float LeftFootOffsetY { get; } // 0x0000000184D91E60-0x0000000184D91E70 
		public float RightFootOri { get; } // 0x0000000184DA94B0-0x0000000184DA94C0 
		public float LeftFootOri { get; } // 0x0000000184D8E650-0x0000000184D8E660 
	
		// Constructors
		public GrounderBipedIK(); // 0x0000000184407E50-0x0000000184407EE0
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABE5BD4-0x000000018ABE5C08
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABE5BA0-0x000000018ABE5BD4
		public override void ResetPosition(); // 0x000000018ABE5C08-0x000000018ABE5C48
		private bool IsReadyToInitiate(); // 0x0000000183E5EAC0-0x0000000183E5EBC0
		private void Update(); // 0x0000000183E5EA60-0x0000000183E5EAC0
		private void Initiate(); // 0x0000000183E5EBC0-0x0000000183E5EF60
		private void OnDisable(); // 0x0000000184D1A0D0-0x0000000184D1A130
		private void OnSolverUpdate(); // 0x000000018326EB70-0x000000018326F5A0
		private void SetLegIK(IKSolverLimb limb, int index); // 0x000000018326CB90-0x000000018326CF60
		private void OnPostSolverUpdate(); // 0x000000018326C820-0x000000018326CB90
		private void OnDestroy(); // 0x0000000184D38F60-0x0000000184D38FC0
		private Quaternion ClampPitchAndRollAroundForward(Quaternion Q, Quaternion calfQ, float minPitch, float maxPitch, float minRoll, float maxRoll); // 0x0000000183271CE0-0x00000001832721C0
		private float NormalizeAngle(float angle); // 0x00000001832721C0-0x0000000183272240
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderFBBIK : Grounder // TypeDefIndex: 56131
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
		public class SpineEffector // TypeDefIndex: 56130
		{
			// Fields
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType; // 0x10
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight; // 0x14
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight; // 0x18
	
			// Constructors
			public SpineEffector(); // 0x00000001815845C0-0x00000001815845D0
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight); // 0x0000000184DA9650-0x0000000184DA9660
		}
	
		// Constructors
		public GrounderFBBIK(); // 0x000000018ABE6A98-0x000000018ABE6B20
	
		// Methods
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial(); // 0x000000018ABE67EC-0x000000018ABE6820
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABE6820-0x000000018ABE6854
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABE67B8-0x000000018ABE67EC
		public override void ResetPosition(); // 0x000000018ABE6854-0x000000018ABE688C
		private bool IsReadyToInitiate(); // 0x000000018ABE5F58-0x000000018ABE5FD0
		private void Update(); // 0x000000018ABE6A3C-0x000000018ABE6A98
		private void FixedUpdate(); // 0x0000000184D8D080-0x0000000184D8D090
		private void LateUpdate(); // 0x0000000184D8D080-0x0000000184D8D090
		private void Initiate(); // 0x000000018ABE5C48-0x000000018ABE5F58
		private void OnSolverUpdate(); // 0x000000018ABE62DC-0x000000018ABE67B8
		private void SetLegIK(IKEffector effector, Grounding.Leg leg); // 0x000000018ABE688C-0x000000018ABE6A3C
		private void OnDrawGizmosSelected(); // 0x000000018ABE61B4-0x000000018ABE62C4
		private void OnPostSolverUpdate(); // 0x000000018ABE62C4-0x000000018ABE62DC
		private void OnDestroy(); // 0x000000018ABE5FD0-0x000000018ABE61B4
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderIK : Grounder // TypeDefIndex: 56132
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
		public GrounderIK(); // 0x000000018ABE81E8-0x000000018ABE8274
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABE7848-0x000000018ABE787C
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABE7814-0x000000018ABE7848
		public override void ResetPosition(); // 0x000000018ABE787C-0x000000018ABE7B04
		private bool IsReadyToInitiate(); // 0x000000018ABE6F7C-0x000000018ABE70F8
		private void OnDisable(); // 0x000000018ABE7320-0x000000018ABE73D8
		private void Update(); // 0x000000018ABE7DEC-0x000000018ABE81E8
		private void Initiate(); // 0x000000018ABE6B20-0x000000018ABE6F7C
		private void OnSolverUpdate(); // 0x000000018ABE75AC-0x000000018ABE7814
		private void SetLegIK(int index); // 0x000000018ABE7B04-0x000000018ABE7DEC
		private void OnPostSolverUpdate(); // 0x000000018ABE73D8-0x000000018ABE75AC
		private void OnDestroy(); // 0x000000018ABE70F8-0x000000018ABE7320
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderQuadruped : Grounder // TypeDefIndex: 56134
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
		public struct Foot // TypeDefIndex: 56133
		{
			// Fields
			public IKSolver solver; // 0x00
			public Transform transform; // 0x08
			public Quaternion rotation; // 0x10
			public Grounding.Leg leg; // 0x20
	
			// Constructors
			public Foot(IKSolver solver, Transform transform); // 0x000000018ABE52D0-0x000000018ABE532C
		}
	
		// Constructors
		public GrounderQuadruped(); // 0x000000018ABEA5BC-0x000000018ABEA6A4
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABE9AB4-0x000000018ABE9AE8
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABE9A80-0x000000018ABE9AB4
		public override void ResetPosition(); // 0x000000018ABE9AE8-0x000000018ABE9CAC
		private bool IsReadyToInitiate(); // 0x000000018ABE8D18-0x000000018ABE8E18
		private bool IsReadyToInitiateLegs(IK[] ikComponents); // 0x000000018ABE8BD0-0x000000018ABE8D18
		private void OnDisable(); // 0x000000018ABE8F34-0x000000018ABE8FA0
		private void Update(); // 0x000000018ABEA55C-0x000000018ABEA5BC
		private void Initiate(); // 0x000000018ABE87F4-0x000000018ABE8BD0
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset); // 0x000000018ABE8490-0x000000018ABE87F4
		private void LateUpdate(); // 0x000000018ABE8E18-0x000000018ABE8EF8
		private void RootRotation(); // 0x000000018ABE9CAC-0x000000018ABEA158
		private void OnSolverUpdate(); // 0x000000018ABE9278-0x000000018ABE9A80
		private void UpdateForefeetRoot(); // 0x000000018ABEA2C4-0x000000018ABEA55C
		private void SetFootIK(Foot foot, float maxOffset); // 0x000000018ABEA158-0x000000018ABEA2C4
		private void OnPostSolverUpdate(); // 0x000000018ABE8FA0-0x000000018ABE9278
		private void OnDestroy(); // 0x000000018ABE8EF8-0x000000018ABE8F34
		private void DestroyLegs(IK[] ikComponents); // 0x000000018ABE8274-0x000000018ABE8490
	}

	[Serializable]
	public class Grounding // TypeDefIndex: 56141
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
		[CompilerGenerated]
		private BipedReferences _references_k__BackingField; // 0xC0
		[CompilerGenerated]
		private Leg[] _legs_k__BackingField; // 0xC8
		[CompilerGenerated]
		private Pelvis _pelvis_k__BackingField; // 0xD0
		[CompilerGenerated]
		private bool _isGrounded_k__BackingField; // 0xD8
		[CompilerGenerated]
		private Transform _root_k__BackingField; // 0xE0
		[CompilerGenerated]
		private RaycastHit _rootHit_k__BackingField; // 0xE8
		public OnRaycastDelegate Raycast; // 0x128
		public OnCapsuleCastDelegate CapsuleCast; // 0x130
		public OnSphereCastDelegate SphereCast; // 0x138
		[CompilerGenerated]
		private Transform _entityTransform_k__BackingField; // 0x140
		[CompilerGenerated]
		private bool _entityIsOnMovableBase_k__BackingField; // 0x148
		[CompilerGenerated]
		private Vector3 _entityRelativePosition_k__BackingField; // 0x14C
		[CompilerGenerated]
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
		public BipedReferences references { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000186AC5ACC-0x0000000186AC5AE0
		public Leg[] legs { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 0x0000000186AC5B30-0x0000000186AC5B44
		public Pelvis pelvis { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D876B0-0x0000000184D876C0 0x000000018678D7BC-0x000000018678D7D0
		public bool isGrounded { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA6C90-0x0000000184DA6CA0 0x0000000184DA6CE0-0x0000000184DA6CF0
		public Transform root { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8D1C0-0x0000000184D8D1D0 0x0000000186AC5B08-0x0000000186AC5B1C
		public RaycastHit rootHit { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA0A70-0x0000000184DA0AA0 0x0000000184DA9530-0x0000000184DA9560
		public bool rootGrounded { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public Transform entityTransform { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DA60-0x0000000184D8DA70 0x0000000186B8B404-0x0000000186B8B418
		public bool entityIsOnMovableBase { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8FE60-0x0000000184D8FE70 0x0000000184D8FE90-0x0000000184D8FEA0
		public Vector3 entityRelativePosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA94C0-0x0000000184DA94E0 0x0000000184DA9500-0x0000000184DA9520
		public Quaternion entityRelativeRotation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA94E0-0x0000000184DA94F0 0x0000000184DA9520-0x0000000184DA9530
		public bool isInitiated { get; } // 0x0000000184DA94F0-0x0000000184DA9500 
		public Vector3 up { get; } // 0x0000000183269FA0-0x000000018326A000 
		public Vector3 forward { get; } // 0x0000000182F40ED0-0x0000000182F40F70 
		private bool useRootRotation { get; } // 0x000000018326A000-0x000000018326A020 
	
		// Nested types
		[Serializable]
		public enum Quality // TypeDefIndex: 56135
		{
			Fastest = 0,
			Simple = 1,
			Best = 2,
			Custom = 3
		}
	
		public delegate bool OnRaycastDelegate(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 56136; 0x0000000186226A0C-0x0000000186226A7C
	
		public delegate bool OnCapsuleCastDelegate(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 56137; 0x0000000186225F10-0x0000000186225FB4
	
		public delegate bool OnSphereCastDelegate(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 56138; 0x0000000186225970-0x00000001862259EC
	
		public class Leg // TypeDefIndex: 56139
		{
			// Fields
			[CompilerGenerated]
			private bool _isGrounded_k__BackingField; // 0x10
			[CompilerGenerated]
			private Vector3 _IKPosition_k__BackingField; // 0x14
			public Quaternion rotationOffset; // 0x20
			[CompilerGenerated]
			private bool _initiated_k__BackingField; // 0x30
			[CompilerGenerated]
			private float _heightFromGround_k__BackingField; // 0x34
			[CompilerGenerated]
			private float _fowardMoveFromGround_k__BackingField; // 0x38
			[CompilerGenerated]
			private float _rightMoveFromGround_k__BackingField; // 0x3C
			[CompilerGenerated]
			private Vector3 _velocity_k__BackingField; // 0x40
			[CompilerGenerated]
			private Transform _transform_k__BackingField; // 0x50
			[CompilerGenerated]
			private float _IKOffset_k__BackingField; // 0x58
			[CompilerGenerated]
			private float _IKOffsetZ_k__BackingField; // 0x5C
			[CompilerGenerated]
			private float _IKOffsetX_k__BackingField; // 0x60
			[CompilerGenerated]
			private RaycastHit _heelHit_k__BackingField; // 0x68
			[CompilerGenerated]
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
			public const float MAX_PREDICTION_DISTANCE = 2.25f; // Metadata: 0x023478E8
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
			public bool isGrounded { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
			public Vector3 IKPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001816057F0-0x0000000181605810 0x0000000184D91E50-0x0000000184D91E60
			public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
			public float heightFromGround { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E050-0x0000000184D8E060 0x0000000184D8E060-0x0000000184D8E070
			public float fowardMoveFromGround { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88360-0x0000000184D88370 0x0000000184D88370-0x0000000184D88380
			public float rightMoveFromGround { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D863E0-0x0000000184D863F0 0x0000000184D86460-0x0000000184D86470
			public Vector3 velocity { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D89660-0x0000000184D89680 0x0000000184D89690-0x0000000184D896A0
			public Transform transform { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
			public float IKOffset { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88400-0x0000000184D88410 0x0000000184D88430-0x0000000184D88440
			public float IKOffsetZ { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D91500-0x0000000184D91510 0x0000000184D91510-0x0000000184D91520
			public float IKOffsetX { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88480-0x0000000184D88490 0x0000000184D884A0-0x0000000184D884B0
			public RaycastHit heelHit { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA95C0-0x0000000184DA95F0 0x0000000184DA9620-0x0000000184DA9650
			public RaycastHit capsuleHit { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA9590-0x0000000184DA95C0 0x0000000184DA95F0-0x0000000184DA9620
			public RaycastHit GetHitPoint { get; } // 0x000000018ABEBE48-0x000000018ABEBEBC 
			public Vector3 right { get; } // 0x000000018326A020-0x000000018326A140 
			public Vector3 speedRight { get; } // 0x000000018411E9B0-0x000000018411EA40 
			public Vector3 predictOffsetwithPercent { get; } // 0x0000000183EE2080-0x0000000183EE2190 
			private bool isLeft { get; } // 0x0000000183277EC0-0x0000000183277FD0 
			private bool isMoving { get; } // 0x000000018ABEBEBC-0x000000018ABEBEDC 
			public float stepHeightFromGround { get; } // 0x0000000183DB9310-0x0000000183DB9440 
			public float stepForwardFromGround { get; } // 0x0000000183DF3490-0x0000000183DF34C0 
			public float stepRightFromGround { get; } // 0x0000000183DF34C0-0x0000000183DF3590 
			private Vector3 animFootGroundPos { get; } // 0x0000000183275760-0x00000001832759E0 
			public float rootYOffset { get; } // 0x0000000183269C20-0x0000000183269F50 
	
			// Constructors
			public Leg(); // 0x0000000183E5F1E0-0x0000000183E5F250
			static Leg(); // 0x0000000184CE9F90-0x0000000184CEA030
	
			// Methods
			public void SetFootPosition(Vector3 position); // 0x0000000184DA9570-0x0000000184DA9590
			public void Initiate(Grounding grounding, Transform transform); // 0x0000000183E5F250-0x0000000183E5F330
			public void OnEnable(); // 0x0000000183E5F330-0x0000000183E5F390
			public void Reset(); // 0x000000018ABEBAE4-0x000000018ABEBB70
			private void _ResetPredictReference(RaycastHit curHit); // 0x0000000183BB64B0-0x0000000183BB6530
			private void _PredictNextStepHit(Vector3 prediction, Vector3 predictVec, bool canChangeHeight = true /* Metadata: 0x023478E6 */); // 0x000000018327FC60-0x000000018327FEC0
			private float _CanHitPointLand(RaycastHit hit, out RaycastHit predictHit); // 0x000000018327FEC0-0x00000001832802B0
			public void Process(); // 0x0000000183277FD0-0x000000018327ABA0
			private void _UpdateHeelHit(float curStepPercent, Vector3 prediction); // 0x0000000183D24FE0-0x0000000183D250E0
			private Vector3 _UpdatePredictOffset(float curStepPercent); // 0x0000000183D250E0-0x0000000183D25200
			public void FinalSetIKPosition(Vector3 thighPos); // 0x000000018326BDB0-0x000000018326BFC0
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel, Vector3 predictPos); // 0x0000000183913000-0x0000000183913D80
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel); // 0x000000018ABEAF98-0x000000018ABEB694
			private RaycastHit GetRaycastHitCustom(Vector3 offsetFromHeel); // 0x00000001832028C0-0x0000000183202E40
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel); // 0x000000018ABEB694-0x000000018ABEBAE4
			private Vector3 RotateNormal(Vector3 normal); // 0x0000000183268970-0x00000001832689E0
			private void SetFootToPoint(Vector3 normal, Vector3 point); // 0x000000018ABEBD80-0x000000018ABEBE48
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint); // 0x000000018ABEBB70-0x000000018ABEBD80
			private void SetFootToPoint(Vector3 normal, Vector3 pointForXZ, Vector3 pointForY); // 0x0000000183268620-0x0000000183268970
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint, Vector3 footNormal, bool isLimitByComplex = true /* Metadata: 0x023478E7 */); // 0x00000001831CD2D0-0x00000001831CD6D0
			private float GetHeightFromGround(Vector3 hitPoint); // 0x0000000183269590-0x0000000183269640
			private void RotateFoot(); // 0x000000018326C6A0-0x000000018326C730
			private Quaternion GetRotationOffsetTarget(); // 0x0000000184DA9560-0x0000000184DA9570
			private Vector3 RotateNormalWithLimit(Vector3 normal); // 0x00000001832689E0-0x00000001832693B0
		}
	
		public class Pelvis // TypeDefIndex: 56140
		{
			// Fields
			[CompilerGenerated]
			private Vector3 _IKOffset_k__BackingField; // 0x10
			[CompilerGenerated]
			private float _heightOffset_k__BackingField; // 0x1C
			private float forwardOffset; // 0x20
			public float pelivsSpeedY; // 0x24
			private Grounding grounding; // 0x28
			private Vector3 lastRootPosition; // 0x30
			private float damperF; // 0x3C
			private bool initiated; // 0x40
			private float lastTime; // 0x44
	
			// Properties
			public Vector3 IKOffset { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8C950-0x0000000184D8C970 0x0000000184D8C970-0x0000000184D8C980
			public float heightOffset { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
	
			// Constructors
			public Pelvis(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Initiate(Grounding grounding); // 0x0000000183E5F390-0x0000000183E5F3C0
			public void Reset(); // 0x000000018ABEC63C-0x000000018ABEC6BC
			public void OnEnable(); // 0x0000000183E5F3C0-0x0000000183E5F430
			public void Process(float pelivsOffset, float _forwardOffset, bool isGrounded, bool islastFrameLegStretch = false /* Metadata: 0x023478EC */, bool isSameLegReflastFrame = false /* Metadata: 0x023478ED */); // 0x000000018326B180-0x000000018326B8B0
			private RaycastHit GetRaycastHitCustom(Vector3 rayOrigin); // 0x000000018ABEC274-0x000000018ABEC63C
		}
	
		// Constructors
		public Grounding(); // 0x0000000184407F80-0x0000000184408140
	
		// Methods
		private void _UpdateFloorPredictTheta(); // 0x0000000183269640-0x0000000183269970
		private void _UpdateFloorFeetThetaByFoot(); // 0x0000000183269970-0x0000000183269C20
		private void _UpdateFloorFeetThetaByRoot(); // 0x0000000183C5D910-0x0000000183C5DB50
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f /* Metadata: 0x023478DE */); // 0x00000001832701C0-0x0000000183270630
		public bool IsValid(ref string errorMessage); // 0x0000000183E5F430-0x0000000183E5F570
		public void Initiate(Transform root, Transform[] feet, BipedReferences references = null); // 0x0000000183E5EF60-0x0000000183E5F1E0
		public void Update(); // 0x000000018326D370-0x000000018326E580
		public Vector3 GetLegsPlaneNormal(); // 0x000000018ABEAD1C-0x000000018ABEAF10
		public void Reset(); // 0x000000018ABEAF28-0x000000018ABEAF98
		public void LogWarning(string message); // 0x000000018ABEAF10-0x000000018ABEAF28
		public float GetVerticalOffset(Vector3 p1, Vector3 p2); // 0x0000000183269F50-0x0000000183269FA0
		public Vector3 Flatten(Vector3 v); // 0x000000018ABEAB2C-0x000000018ABEAC20
		public Vector3 GetFootCenterOffset(); // 0x000000018ABEAC20-0x000000018ABEAD1C
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK // TypeDefIndex: 56142
	{
		// Fields
		public IKSolverAim solver; // 0x38
	
		// Constructors
		public AimIK(); // 0x000000018ABE451C-0x000000018ABE458C
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABE44B4-0x000000018ABE44E8
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABE444C-0x000000018ABE4480
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial(); // 0x000000018ABE4480-0x000000018ABE44B4
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABE44E8-0x000000018ABE451C
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABE4418-0x000000018ABE444C
		public override IKSolver GetIKSolver(); // 0x0000000184D85A50-0x0000000184D85A60
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class ArmIK : IK // TypeDefIndex: 56143
	{
		// Fields
		public IKSolverArm solver; // 0x38
	
		// Constructors
		public ArmIK(); // 0x000000018ABE465C-0x000000018ABE46CC
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABE45F4-0x000000018ABE4628
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABE45C0-0x000000018ABE45F4
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABE4628-0x000000018ABE465C
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABE458C-0x000000018ABE45C0
		public override IKSolver GetIKSolver(); // 0x0000000184D85A50-0x0000000184D85A60
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK // TypeDefIndex: 56144
	{
		// Fields
		public IKSolverCCD solver; // 0x38
	
		// Constructors
		public CCDIK(); // 0x000000018ABE479C-0x000000018ABE480C
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABE4734-0x000000018ABE4768
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABE4700-0x000000018ABE4734
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABE4768-0x000000018ABE479C
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABE46CC-0x000000018ABE4700
		public override IKSolver GetIKSolver(); // 0x0000000184D85A50-0x0000000184D85A60
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	public class FABRIK : IK // TypeDefIndex: 56145
	{
		// Fields
		public IKSolverFABRIK solver; // 0x38
	
		// Constructors
		public FABRIK(); // 0x000000018ABE4A1C-0x000000018ABE4A8C
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABE49B4-0x000000018ABE49E8
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABE4980-0x000000018ABE49B4
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABE49E8-0x000000018ABE4A1C
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABE494C-0x000000018ABE4980
		public override IKSolver GetIKSolver(); // 0x0000000184D85A50-0x0000000184D85A60
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	public class FABRIKRoot : IK // TypeDefIndex: 56146
	{
		// Fields
		public IKSolverFABRIKRoot solver; // 0x38
	
		// Constructors
		public FABRIKRoot(); // 0x000000018ABE48DC-0x000000018ABE494C
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABE4874-0x000000018ABE48A8
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABE4840-0x000000018ABE4874
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABE48A8-0x000000018ABE48DC
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABE480C-0x000000018ABE4840
		public override IKSolver GetIKSolver(); // 0x0000000184D85A50-0x0000000184D85A60
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK // TypeDefIndex: 56147
	{
		// Fields
		public BipedReferences references; // 0x38
		public IKSolverFullBodyBiped solver; // 0x40
	
		// Constructors
		public FullBodyBipedIK(); // 0x000000018ABE5AF8-0x000000018ABE5BA0
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABE54D4-0x000000018ABE5508
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABE546C-0x000000018ABE54A0
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial(); // 0x000000018ABE54A0-0x000000018ABE54D4
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial(); // 0x000000018ABE5438-0x000000018ABE546C
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABE5AC4-0x000000018ABE5AF8
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABE532C-0x000000018ABE5360
		public void SetReferences(BipedReferences references, Transform rootNode); // 0x000000018ABE5A88-0x000000018ABE5AC4
		public override IKSolver GetIKSolver(); // 0x0000000184D85A60-0x0000000184D85A70
		public bool ReferencesError(ref string errorMessage); // 0x000000018ABE5508-0x000000018ABE56E8
		public bool ReferencesWarning(ref string warningMessage); // 0x000000018ABE56E8-0x000000018ABE5A5C
		[ContextMenu("Reinitiate")]
		private void Reinitiate(); // 0x000000018ABE5A5C-0x000000018ABE5A88
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences(); // 0x000000018ABE5360-0x000000018ABE5438
	}

	public abstract class IK : SolverManager // TypeDefIndex: 56148
	{
		// Constructors
		protected IK(); // 0x0000000185394738-0x0000000185394740
	
		// Methods
		public abstract IKSolver GetIKSolver();
		protected override void UpdateSolver(); // 0x000000018ABFD638-0x000000018ABFD698
		protected override void InitiateSolver(); // 0x000000018ABFD5DC-0x000000018ABFD638
		protected override void FixTransforms(); // 0x000000018ABFD598-0x000000018ABFD5DC
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}

	public class IKExecutionOrder : MonoBehaviour // TypeDefIndex: 56149
	{
		// Fields
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents; // 0x18
		[Tooltip("Optional. Assign it if you are using \'Animate Physics\' as the Update Mode.")]
		public Animator animator; // 0x20
		private bool fixedFrame; // 0x28
	
		// Properties
		private bool animatePhysics { get; } // 0x000000018ABF8560-0x000000018ABF85D8 
	
		// Constructors
		public IKExecutionOrder(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Start(); // 0x000000018ABF84E0-0x000000018ABF8534
		private void Update(); // 0x000000018ABF8534-0x000000018ABF8560
		private void FixedUpdate(); // 0x000000018ABF843C-0x000000018ABF846C
		private void LateUpdate(); // 0x000000018ABF846C-0x000000018ABF84E0
		private void FixTransforms(); // 0x000000018ABF83CC-0x000000018ABF843C
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class LegIK : IK // TypeDefIndex: 56150
	{
		// Fields
		public IKSolverLeg solver; // 0x38
	
		// Constructors
		public LegIK(); // 0x000000018ABFD7E0-0x000000018ABFD850
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABFD778-0x000000018ABFD7AC
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABFD744-0x000000018ABFD778
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABFD7AC-0x000000018ABFD7E0
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABFD710-0x000000018ABFD744
		public override IKSolver GetIKSolver(); // 0x0000000184D85A50-0x0000000184D85A60
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class LimbIK : IK // TypeDefIndex: 56151
	{
		// Fields
		public IKSolverLimb solver; // 0x38
	
		// Constructors
		public LimbIK(); // 0x000000018ABFD920-0x000000018ABFD990
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABFD8B8-0x000000018ABFD8EC
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABFD884-0x000000018ABFD8B8
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABFD8EC-0x000000018ABFD920
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABFD850-0x000000018ABFD884
		public override IKSolver GetIKSolver(); // 0x0000000184D85A50-0x0000000184D85A60
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	public class LookAtIK : IK // TypeDefIndex: 56152
	{
		// Fields
		public IKSolverLookAt solver; // 0x38
	
		// Constructors
		public LookAtIK(); // 0x00000001839DCA90-0x00000001839DCB00
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABFD9F8-0x000000018ABFDA2C
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABFD9C4-0x000000018ABFD9F8
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABFDA2C-0x000000018ABFDA60
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABFD990-0x000000018ABFD9C4
		public override IKSolver GetIKSolver(); // 0x0000000184D85A50-0x0000000184D85A60
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	public class TrigonometricIK : IK // TypeDefIndex: 56153
	{
		// Fields
		public IKSolverTrigonometric solver; // 0x38
	
		// Constructors
		public TrigonometricIK(); // 0x000000018ABFEEAC-0x000000018ABFEF1C
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABFEE44-0x000000018ABFEE78
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABFEE10-0x000000018ABFEE44
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018ABFEE78-0x000000018ABFEEAC
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018ABFEDDC-0x000000018ABFEE10
		public override IKSolver GetIKSolver(); // 0x0000000184D85A50-0x0000000184D85A60
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK // TypeDefIndex: 56155
	{
		// Fields
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select \'Auto-detect References\' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public References references; // 0x38
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver; // 0x40
	
		// Nested types
		[Serializable]
		public class References // TypeDefIndex: 56154
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
			public bool isFilled { get; } // 0x000000018ABFE978-0x000000018ABFEDDC 
			public bool isEmpty { get; } // 0x000000018ABFE608-0x000000018ABFE978 
	
			// Constructors
			public References(); // 0x00000001841E1670-0x00000001841E1680
			public References(BipedReferences b); // 0x000000018ABFE3C4-0x000000018ABFE608
	
			// Methods
			public Transform[] GetTransforms(); // 0x000000018ABFE0A4-0x000000018ABFE3C4
			public static bool AutoDetectReferences(Transform root, out References references); // 0x000000018ABFDC0C-0x000000018ABFE0A4
		}
	
		// Constructors
		public VRIK(); // 0x000000018ABFF1C4-0x000000018ABFF25C
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018ABFF03C-0x000000018ABFF070
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018ABFEFD4-0x000000018ABFF008
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial(); // 0x000000018ABFF008-0x000000018ABFF03C
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences(); // 0x000000018ABFEF1C-0x000000018ABFEF40
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations(); // 0x000000018ABFEF40-0x000000018ABFEF6C
		public override IKSolver GetIKSolver(); // 0x0000000184D85A60-0x0000000184D85A70
		protected override void InitiateSolver(); // 0x000000018ABFEF6C-0x000000018ABFEFD4
		protected override void UpdateSolver(); // 0x000000018ABFF070-0x000000018ABFF1C4
	}

	[Serializable]
	public class FABRIKChain // TypeDefIndex: 56156
	{
		// Fields
		public FABRIK ik; // 0x10
		[Range(0f, 1f)]
		public float pull; // 0x18
		[Range(0f, 1f)]
		public float pin; // 0x1C
		public int[] children; // 0x20
	
		// Constructors
		public FABRIKChain(); // 0x000000018ABEEE04-0x000000018ABEEE54
	
		// Methods
		public bool IsValid(ref string message); // 0x000000018ABEEB38-0x000000018ABEEBE8
		public void Initiate(); // 0x000000018ABEEB14-0x000000018ABEEB38
		public void Stage1(FABRIKChain[] chain); // 0x000000018ABEEBE8-0x000000018ABEECDC
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain); // 0x000000018ABEECDC-0x000000018ABEEE04
		private Vector3 GetCentroid(FABRIKChain[] chain); // 0x000000018ABEE818-0x000000018ABEEB14
	}

	public class FBBIKArmBending : MonoBehaviour // TypeDefIndex: 56157
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
		public FBBIKArmBending(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void LateUpdate(); // 0x000000018ABEEE54-0x000000018ABEF470
		private void OnPostFBBIK(); // 0x000000018ABEF598-0x000000018ABEF76C
		private void OnDestroy(); // 0x000000018ABEF470-0x000000018ABEF598
	}

	public class FBBIKHeadEffector : MonoBehaviour // TypeDefIndex: 56159
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
		public class BendBone // TypeDefIndex: 56158
		{
			// Fields
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform; // 0x10
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight; // 0x18
			private Quaternion defaultLocalRotation; // 0x1C
	
			// Constructors
			public BendBone(); // 0x000000018ABEC75C-0x000000018ABEC780
			public BendBone(Transform transform, float weight); // 0x000000018ABEC724-0x000000018ABEC75C
	
			// Methods
			public void StoreDefaultLocalState(); // 0x000000018ABEC6F0-0x000000018ABEC724
			public void FixTransforms(); // 0x000000018ABEC6BC-0x000000018ABEC6F0
		}
	
		// Constructors
		public FBBIKHeadEffector(); // 0x000000018ABF2DD4-0x000000018ABF2FA8
	
		// Methods
		private void Start(); // 0x000000018ABF2924-0x000000018ABF2DD4
		private void OnStoreDefaultLocalState(); // 0x000000018ABF1BEC-0x000000018ABF2120
		private void OnFixTransforms(); // 0x000000018ABF0D84-0x000000018ABF1170
		private void OnPreRead(); // 0x000000018ABF1370-0x000000018ABF1BEC
		private void SpineBend(); // 0x000000018ABF25F4-0x000000018ABF2924
		private void CCDPass(); // 0x000000018ABEF76C-0x000000018ABEFAF4
		private void Iterate(int iteration); // 0x000000018ABEFDA0-0x000000018ABF0850
		private void OnPostUpdate(); // 0x000000018ABF1170-0x000000018ABF1370
		private void ChestDirection(); // 0x000000018ABEFAF4-0x000000018ABEFDA0
		private void PostStretching(); // 0x000000018ABF2120-0x000000018ABF2488
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset); // 0x000000018ABF0850-0x000000018ABF0970
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance); // 0x000000018ABF2488-0x000000018ABF25F4
		private void OnDestroy(); // 0x000000018ABF0970-0x000000018ABF0D84
	}

	[Serializable]
	public class FBIKChain // TypeDefIndex: 56162
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
		private const float maxLimbLength = 0.99999f; // Metadata: 0x023478EF
	
		// Nested types
		[Serializable]
		public class ChildConstraint // TypeDefIndex: 56160
		{
			// Fields
			public float pushElasticity; // 0x10
			public float pullElasticity; // 0x14
			[SerializeField]
			private Transform bone1; // 0x18
			[SerializeField]
			private Transform bone2; // 0x20
			[CompilerGenerated]
			private float _nominalDistance_k__BackingField; // 0x28
			[CompilerGenerated]
			private bool _isRigid_k__BackingField; // 0x2C
			private float crossFade; // 0x30
			private float inverseCrossFade; // 0x34
			private int chain1Index; // 0x38
			private int chain2Index; // 0x3C
	
			// Properties
			public float nominalDistance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
			public bool isRigid { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D869F0-0x0000000184D86A00 0x0000000184D86A00-0x0000000184D86A10
	
			// Constructors
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f /* Metadata: 0x023478F3 */, float pullElasticity = 0f /* Metadata: 0x023478F7 */); // 0x000000018ABEE7DC-0x000000018ABEE818
	
			// Methods
			public void Initiate(IKSolverFullBody solver); // 0x000000018ABEE29C-0x000000018ABEE2F4
			public void OnPreSolve(IKSolverFullBody solver); // 0x000000018ABEE2F4-0x000000018ABEE4C8
			public void Solve(IKSolverFullBody solver); // 0x000000018ABEE4C8-0x000000018ABEE7DC
		}
	
		[Serializable]
		public enum Smoothing // TypeDefIndex: 56161
		{
			None = 0,
			Exponential = 1,
			Cubic = 2
		}
	
		// Constructors
		public FBIKChain(); // 0x000000018ABF56DC-0x000000018ABF57E0
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms); // 0x000000018ABF5580-0x000000018ABF56DC
	
		// Methods
		public void SetNodes(params Transform[] boneTransforms); // 0x000000018ABF4850-0x000000018ABF4948
		public int GetNodeIndex(Transform boneTransform); // 0x000000018ABF395C-0x000000018ABF3A04
		public bool IsValid(ref string message); // 0x000000018ABF3B9C-0x000000018ABF3C80
		public void Initiate(IKSolverFullBody solver); // 0x000000018ABF3A04-0x000000018ABF3B9C
		public void ReadPose(IKSolverFullBody solver, bool fullBody); // 0x000000018ABF4374-0x000000018ABF4850
		private void CalculateBoneLengths(IKSolverFullBody solver); // 0x000000018ABF3154-0x000000018ABF3660
		public void Reach(IKSolverFullBody solver); // 0x000000018ABF4010-0x000000018ABF4374
		public Vector3 Push(IKSolverFullBody solver); // 0x000000018ABF3C80-0x000000018ABF4010
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false /* Metadata: 0x023478EE */); // 0x000000018ABF4D48-0x000000018ABF5044
		public void Stage1(IKSolverFullBody solver); // 0x000000018ABF5044-0x000000018ABF5460
		public void Stage2(IKSolverFullBody solver, Vector3 position); // 0x000000018ABF5460-0x000000018ABF5580
		public void SolveConstraintSystems(IKSolverFullBody solver); // 0x000000018ABF49AC-0x000000018ABF4AC0
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018ABF4AC0-0x000000018ABF4B98
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude); // 0x000000018ABF379C-0x000000018ABF395C
		private void SolveChildConstraints(IKSolverFullBody solver); // 0x000000018ABF4948-0x000000018ABF49AC
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance); // 0x000000018ABF4B98-0x000000018ABF4D48
		public void ForwardReach(Vector3 position); // 0x000000018ABF3660-0x000000018ABF379C
		private void BackwardReach(Vector3 position); // 0x000000018ABF2FA8-0x000000018ABF3154
	}

	[Serializable]
	public class IKConstraintBend // TypeDefIndex: 56163
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
		[CompilerGenerated]
		private bool _initiated_k__BackingField; // 0x84
		private bool limbOrientationsSet; // 0x85
	
		// Properties
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182A80FA0-0x0000000182A80FB0 0x0000000182A80FB0-0x0000000182A80FC0
	
		// Constructors
		public IKConstraintBend(); // 0x000000018ABF6AA4-0x000000018ABF6AC4
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3); // 0x000000018ABF6A74-0x000000018ABF6AA4
	
		// Methods
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger); // 0x000000018ABF608C-0x000000018ABF6218
		public void SetBones(Transform bone1, Transform bone2, Transform bone3); // 0x00000001831D14F0-0x00000001831D1530
		public void Initiate(IKSolverFullBody solver); // 0x000000018ABF5D9C-0x000000018ABF608C
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last); // 0x000000018ABF6874-0x000000018ABF6A74
		public void LimitBend(float solverWeight, float positionWeight); // 0x000000018ABF6218-0x000000018ABF667C
		public Vector3 GetDir(IKSolverFullBody solver); // 0x000000018ABF57E0-0x000000018ABF5D9C
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent); // 0x000000018ABF6778-0x000000018ABF6874
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent); // 0x000000018ABF667C-0x000000018ABF6778
	}

	[Serializable]
	public class IKEffector // TypeDefIndex: 56164
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
		[CompilerGenerated]
		private bool _isEndEffector_k__BackingField; // 0x50
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
		public bool isEndEffector { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86800-0x0000000184D86810 0x0000000184D86840-0x0000000184D86850
	
		// Constructors
		public IKEffector(); // 0x000000018ABF8108-0x000000018ABF8250
		public IKEffector(Transform bone, Transform[] childBones); // 0x000000018ABF8250-0x000000018ABF83CC
	
		// Methods
		public IKSolver.Node GetNode(IKSolverFullBody solver); // 0x000000018ABF6AC4-0x000000018ABF6B1C
		public void PinToBone(float positionWeight, float rotationWeight); // 0x000000018ABF7BA0-0x000000018ABF7C68
		public bool IsValid(IKSolver solver, ref string message); // 0x000000018ABF7304-0x000000018ABF7554
		public void Initiate(IKSolverFullBody solver); // 0x000000018ABF7028-0x000000018ABF7304
		public void ResetOffset(IKSolverFullBody solver); // 0x000000018ABF7C68-0x000000018ABF7D48
		public void SetToTarget(); // 0x000000018ABF7D48-0x000000018ABF7DE8
		public void OnPreSolve(IKSolverFullBody solver); // 0x000000018ABF7568-0x000000018ABF7BA0
		public void OnPostWrite(); // 0x000000018ABF7554-0x000000018ABF7568
		private Quaternion GetPlaneRotation(IKSolverFullBody solver); // 0x000000018ABF6B1C-0x000000018ABF6D30
		public void Update(IKSolverFullBody solver); // 0x000000018ABF7DE8-0x000000018ABF8108
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset); // 0x000000018ABF6D30-0x000000018ABF7028
	}

	[Serializable]
	public class IKMapping // TypeDefIndex: 56166
	{
		// Nested types
		[Serializable]
		public class BoneMap // TypeDefIndex: 56165
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
			public Vector3 swingDirection { get; } // 0x000000018ABEDA94-0x000000018ABEDB10 
			public bool isNodeBone { get; } // 0x000000018ABED88C-0x000000018ABED894 
			private Quaternion lastAnimatedTargetRotation { get; } // 0x000000018ABED894-0x000000018ABEDA94 
	
			// Constructors
			public BoneMap(); // 0x0000000184DA9660-0x0000000184DA9690
	
			// Methods
			public void Initiate(Transform transform, IKSolverFullBody solver); // 0x000000018ABECBAC-0x000000018ABECBF8
			public void StoreDefaultLocalState(); // 0x000000018ABED324-0x000000018ABED380
			public void FixTransform(bool position); // 0x000000018ABEC884-0x000000018ABEC8EC
			public void SetLength(BoneMap nextBone); // 0x000000018ABECF80-0x000000018ABED020
			public void SetLocalSwingAxis(BoneMap swingTarget); // 0x000000018ABED150-0x000000018ABED15C
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2); // 0x000000018ABED020-0x000000018ABED150
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection); // 0x000000018ABED15C-0x000000018ABED1FC
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3); // 0x000000018ABED1FC-0x000000018ABED2E8
			public void UpdatePlane(bool rotation, bool position); // 0x000000018ABED728-0x000000018ABED88C
			public void SetIKPosition(); // 0x000000018ABECF44-0x000000018ABECF80
			public void MaintainRotation(); // 0x000000018ABECBF8-0x000000018ABECC2C
			public void SetToIKPosition(); // 0x000000018ABED2E8-0x000000018ABED324
			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null); // 0x000000018ABEC780-0x000000018ABEC884
			public Vector3 GetPlanePosition(IKSolverFullBody solver); // 0x000000018ABEC8EC-0x000000018ABEC9E4
			public void PositionToPlane(IKSolverFullBody solver); // 0x000000018ABECC2C-0x000000018ABECC7C
			public void RotateToPlane(IKSolverFullBody solver, float weight); // 0x000000018ABECE5C-0x000000018ABECF44
			public void Swing(Vector3 swingTarget, float weight); // 0x000000018ABED528-0x000000018ABED5AC
			public void Swing(Vector3 pos1, Vector3 pos2, float weight); // 0x000000018ABED380-0x000000018ABED528
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight); // 0x000000018ABED5AC-0x000000018ABED728
			public void RotateToMaintain(float weight); // 0x000000018ABECDC4-0x000000018ABECE5C
			public void RotateToEffector(IKSolverFullBody solver, float weight); // 0x000000018ABECC7C-0x000000018ABECDC4
			private Quaternion GetTargetRotation(IKSolverFullBody solver); // 0x000000018ABEC9E4-0x000000018ABECBAC
		}
	
		// Constructors
		public IKMapping(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual bool IsValid(IKSolver solver, ref string message); // 0x0000000182FFF600-0x0000000182FFF610
		public virtual void Initiate(IKSolverFullBody solver); // 0x00000001841E1670-0x00000001841E1680
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger = null); // 0x000000018ABFB2EC-0x000000018ABFB3E8
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018ABF4AC0-0x000000018ABF4B98
	}

	[Serializable]
	public class IKMappingBone : IKMapping // TypeDefIndex: 56167
	{
		// Fields
		public Transform bone; // 0x10
		[Range(0f, 1f)]
		public float maintainRotationWeight; // 0x18
		private BoneMap boneMap; // 0x20
	
		// Constructors
		public IKMappingBone(); // 0x000000018ABF8790-0x000000018ABF8814
		public IKMappingBone(Transform bone); // 0x000000018ABF8814-0x000000018ABF88B0
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x000000018ABF86A4-0x000000018ABF8720
		public void StoreDefaultLocalState(); // 0x000000018ABF8740-0x000000018ABF8760
		public void FixTransforms(); // 0x000000018ABF85D8-0x000000018ABF85FC
		public override void Initiate(IKSolverFullBody solver); // 0x000000018ABF85FC-0x000000018ABF86A4
		public void ReadPose(); // 0x000000018ABF8720-0x000000018ABF8740
		public void WritePose(float solverWeight); // 0x000000018ABF8760-0x000000018ABF8790
	}

	[Serializable]
	public class IKMappingLimb : IKMapping // TypeDefIndex: 56169
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
		public enum BoneMapType // TypeDefIndex: 56168
		{
			Parent = 0,
			Bone1 = 1,
			Bone2 = 2,
			Bone3 = 3
		}
	
		// Constructors
		public IKMappingLimb(); // 0x000000018ABF939C-0x000000018ABF9510
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null); // 0x000000018ABF9510-0x000000018ABF96F0
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x000000018ABF8CEC-0x000000018ABF8D7C
		public BoneMap GetBoneMap(BoneMapType boneMap); // 0x000000018ABF8958-0x000000018ABF89F8
		public void SetLimbOrientation(Vector3 upper, Vector3 lower); // 0x000000018ABF8E40-0x000000018ABF9188
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null); // 0x000000018ABF8DF8-0x000000018ABF8E40
		public void StoreDefaultLocalState(); // 0x000000018ABF9188-0x000000018ABF9224
		public void FixTransforms(); // 0x000000018ABF88B0-0x000000018ABF8958
		public override void Initiate(IKSolverFullBody solver); // 0x000000018ABF89F8-0x000000018ABF8CEC
		public void ReadPose(); // 0x000000018ABF8D7C-0x000000018ABF8DF8
		public void WritePose(IKSolverFullBody solver, bool fullBody); // 0x000000018ABF9224-0x000000018ABF939C
	}

	[Serializable]
	public class IKMappingSpine : IKMapping // TypeDefIndex: 56170
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
		public IKMappingSpine(); // 0x000000018ABFB14C-0x000000018ABFB2EC
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone); // 0x000000018ABFAF34-0x000000018ABFB14C
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x000000018ABFA170-0x000000018ABFA444
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone); // 0x000000018932E3C0-0x000000018932E41C
		public void StoreDefaultLocalState(); // 0x000000018ABFAAD4-0x000000018ABFAB28
		public void FixTransforms(); // 0x000000018ABF9814-0x000000018ABF9880
		public override void Initiate(IKSolverFullBody solver); // 0x000000018ABF99D4-0x000000018ABFA170
		private bool UseFABRIK(); // 0x000000018ABFAB28-0x000000018ABFAB54
		public void ReadPose(); // 0x000000018ABFA7B8-0x000000018ABFAAD4
		public void WritePose(IKSolverFullBody solver); // 0x000000018ABFAB54-0x000000018ABFAF34
		public void ForwardReach(Vector3 position); // 0x000000018ABF9880-0x000000018ABF99D4
		private void BackwardReach(Vector3 position); // 0x000000018ABF96F0-0x000000018ABF9814
		private void MapToSolverPositions(IKSolverFullBody solver); // 0x000000018ABFA444-0x000000018ABFA7B8
	}

	[Serializable]
	public abstract class IKSolver // TypeDefIndex: 56176
	{
		// Fields
		[HideInInspector]
		public bool executedInEditor; // 0x10
		[HideInInspector]
		public Vector3 IKPosition; // 0x14
		[Range(0f, 1f)]
		[Tooltip("The positional or the master weight of the solver.")]
		public float IKPositionWeight; // 0x20
		[CompilerGenerated]
		private bool _initiated_k__BackingField; // 0x24
		public UpdateDelegate OnPreInitiate; // 0x28
		public UpdateDelegate OnPostInitiate; // 0x30
		public UpdateDelegate OnPreUpdate; // 0x38
		public UpdateDelegate OnPostUpdate; // 0x40
		protected bool firstInitiation; // 0x48
		[HideInInspector]
		[SerializeField]
		protected Transform root; // 0x50
	
		// Properties
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86870-0x0000000184D86880 0x0000000184D86880-0x0000000184D86890
	
		// Nested types
		[Serializable]
		public class Point // TypeDefIndex: 56171
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
			public Point(); // 0x00000001839DDFA0-0x00000001839DDFD0
	
			// Methods
			public void StoreDefaultLocalState(); // 0x00000001839DFD60-0x00000001839DFDE0
			public void FixTransform(); // 0x0000000182FA5C50-0x0000000182FA5DE0
			public void UpdateSolverPosition(); // 0x000000018ABFDB74-0x000000018ABFDBB0
			public void UpdateSolverLocalPosition(); // 0x000000018ABFDADC-0x000000018ABFDB18
			public void UpdateSolverState(); // 0x000000018ABFDBB0-0x000000018ABFDC0C
			public void UpdateSolverLocalState(); // 0x000000018ABFDB18-0x000000018ABFDB74
		}
	
		[Serializable]
		public class Bone : Point // TypeDefIndex: 56172
		{
			// Fields
			public float length; // 0x58
			public float sqrMag; // 0x5C
			public Vector3 axis; // 0x60
			private RotationLimit _rotationLimit; // 0x70
			private bool isLimited; // 0x78
	
			// Properties
			public RotationLimit rotationLimit { get; set; } // 0x00000001833B2120-0x00000001833B22A0 0x000000018ABEE23C-0x000000018ABEE29C
	
			// Constructors
			public Bone(); // 0x00000001839DDF40-0x00000001839DDFA0
			public Bone(Transform transform); // 0x000000018ABEE1CC-0x000000018ABEE23C
			public Bone(Transform transform, float weight); // 0x000000018ABEE148-0x000000018ABEE1CC
	
			// Methods
			public void Swing(Vector3 swingTarget, float weight = 1f /* Metadata: 0x02347902 */); // 0x000000018ABEDF44-0x000000018ABEE148
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x02347906 */); // 0x000000018ABEDB4C-0x000000018ABEDD74
			public void Swing2D(Vector3 swingTarget, float weight = 1f /* Metadata: 0x0234790A */); // 0x000000018ABEDD74-0x000000018ABEDF44
			public void SetToSolverPosition(); // 0x000000018ABEDB10-0x000000018ABEDB4C
		}
	
		[Serializable]
		public class Node : Point // TypeDefIndex: 56173
		{
			// Fields
			public float length; // 0x58
			public float effectorPositionWeight; // 0x5C
			public float effectorRotationWeight; // 0x60
			public Vector3 offset; // 0x64
	
			// Constructors
			public Node(); // 0x000000018ABFDA90-0x000000018ABFDA98
			public Node(Transform transform); // 0x000000018ABFDA60-0x000000018ABFDA90
			public Node(Transform transform, float weight); // 0x000000018ABFDA98-0x000000018ABFDADC
		}
	
		public delegate void UpdateDelegate(); // TypeDefIndex: 56174; 0x00000001853DEDB8-0x00000001853DEDC8
	
		public delegate void IterationDelegate(int i); // TypeDefIndex: 56175; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Constructors
		protected IKSolver(); // 0x0000000184DA9690-0x0000000184DA96A0
	
		// Methods
		public bool IsValid(); // 0x000000018ABFD198-0x000000018ABFD1EC
		public abstract bool IsValid(ref string message);
		public void Initiate(Transform root); // 0x00000001839DE430-0x00000001839DE590
		public void Update(); // 0x000000018326AC50-0x000000018326ACB0
		public virtual Vector3 GetIKPosition(); // 0x00000001816057F0-0x0000000181605810
		public void SetIKPosition(Vector3 position); // 0x0000000184D91E50-0x0000000184D91E60
		public float GetIKPositionWeight(); // 0x00000001811EC8A0-0x00000001811EC8B0
		public void SetIKPositionWeight(float weight); // 0x000000018ABFD574-0x000000018ABFD598
		public Transform GetRoot(); // 0x0000000184D86270-0x0000000184D86280
		public abstract Point[] GetPoints();
		public abstract Point GetPoint(Transform transform);
		public abstract void FixTransforms();
		public abstract void StoreDefaultLocalState();
		protected abstract void OnInitiate();
		protected abstract void OnUpdate();
		protected void LogWarning(string message); // 0x000000018ABFD1EC-0x000000018ABFD204
		public static Transform ContainsDuplicateBone(Bone[] bones); // 0x00000001839DFC20-0x00000001839DFD10
		public static bool HierarchyIsValid(Bone[] bones); // 0x00000001839DEEF0-0x00000001839DEF70
		protected static float PreSolveBones(ref Bone[] bones); // 0x000000018ABFD204-0x000000018ABFD574
	}

	[Serializable]
	public class IKSolverAim : IKSolverHeuristic // TypeDefIndex: 56177
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
		public Vector3 transformAxis { get; } // 0x000000018ABFBF7C-0x000000018ABFC000 
		public Vector3 transformPoleAxis { get; } // 0x000000018ABFC000-0x000000018ABFC084 
		protected override int minBones { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		protected override Vector3 localDirection { get; } // 0x000000018ABFBECC-0x000000018ABFBF7C 
	
		// Constructors
		public IKSolverAim(); // 0x00000001839DDB50-0x00000001839DDBB0
	
		// Methods
		public float GetAngle(); // 0x000000018ABFB3E8-0x000000018ABFB4B4
		protected override void OnInitiate(); // 0x00000001839DE740-0x00000001839DE920
		protected override void OnUpdate(); // 0x0000000183B9F470-0x0000000183B9F680
		private void Solve(); // 0x000000018ABFBDB8-0x000000018ABFBECC
		private Vector3 GetClampedIKPosition(); // 0x000000018ABFB4B4-0x000000018ABFB888
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight); // 0x000000018ABFB888-0x000000018ABFBDB8
	}

	[Serializable]
	public class IKSolverArm : IKSolver // TypeDefIndex: 56178
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
		public IKSolverArm(); // 0x000000018ABFCFA0-0x000000018ABFD198
	
		// Methods
		public override bool IsValid(ref string message); // 0x000000018ABFC358-0x000000018ABFC654
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root); // 0x000000018ABFCBC0-0x000000018ABFCC70
		public override Point[] GetPoints(); // 0x000000018ABFC254-0x000000018ABFC358
		public override Point GetPoint(Transform transform); // 0x000000018ABFC0E8-0x000000018ABFC254
		public override void StoreDefaultLocalState(); // 0x000000018ABFCCF0-0x000000018ABFCD50
		public override void FixTransforms(); // 0x000000018ABFC084-0x000000018ABFC0E8
		protected override void OnInitiate(); // 0x000000018ABFC654-0x000000018ABFC6D0
		protected override void OnUpdate(); // 0x000000018ABFC6D0-0x000000018ABFC6FC
		private void Solve(); // 0x000000018ABFCC70-0x000000018ABFCCF0
		private void Read(); // 0x000000018ABFC6FC-0x000000018ABFCBC0
		private void Write(); // 0x000000018ABFCD50-0x000000018ABFCFA0
	}

	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic // TypeDefIndex: 56179
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
	
		// Constructors
		public IKSolverCCD(); // 0x000000018ABFFD84-0x000000018ABFFD8C
	
		// Methods
		public void FadeOutBoneWeights(); // 0x000000018ABFF25C-0x000000018ABFF2F4
		protected override void OnInitiate(); // 0x000000018ABFF2F4-0x000000018ABFF370
		protected override void OnUpdate(); // 0x000000018ABFF370-0x000000018ABFF628
		protected void Solve(Vector3 targetPosition); // 0x000000018ABFF628-0x000000018ABFFD84
	}

	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic // TypeDefIndex: 56180
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
		private bool[] limitedBones; // 0x90
		private Vector3[] solverLocalPositions; // 0x98
	
		// Properties
		protected override bool boneLengthCanBeZero { get; } // 0x00000001812081B0-0x0000000181208610 
	
		// Constructors
		public IKSolverFABRIK(); // 0x00000001839DDBB0-0x00000001839DDC40
	
		// Methods
		public void SolveForward(Vector3 position); // 0x000000018AC02600-0x000000018AC0269C
		public void SolveBackward(Vector3 position); // 0x000000018AC02564-0x000000018AC02600
		public override Vector3 GetIKPosition(); // 0x000000018AC016A8-0x000000018AC01744
		protected override void OnInitiate(); // 0x00000001839DF320-0x00000001839DF680
		protected override void OnUpdate(); // 0x0000000183F6ECB0-0x0000000183F6ECF0
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018AC0269C-0x000000018AC02784
		private void OnPreSolve(); // 0x000000018AC02098-0x000000018AC02564
		private void OnPostSolve(); // 0x000000018AC02050-0x000000018AC02098
		private void Solve(Vector3 targetPosition); // 0x000000018AC02784-0x000000018AC0280C
		private void ForwardReach(Vector3 position); // 0x000000018AC014CC-0x000000018AC016A8
		private void SolverMove(int index, Vector3 offset); // 0x000000018AC02998-0x000000018AC02A2C
		private void SolverRotate(int index, Quaternion rotation, bool recursive); // 0x000000018AC02AB0-0x000000018AC02B40
		private void SolverRotateChildren(int index, Quaternion rotation); // 0x000000018AC02A2C-0x000000018AC02AB0
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation); // 0x000000018AC0280C-0x000000018AC02998
		private Quaternion GetParentSolverRotation(int index); // 0x00000001839DEA40-0x00000001839DEBD0
		private Vector3 GetParentSolverPosition(int index); // 0x00000001839DEBD0-0x00000001839DED80
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed); // 0x000000018AC01744-0x000000018AC01880
		private void LimitForward(int rotateBone, int limitBone); // 0x000000018AC01880-0x000000018AC01DF4
		private void BackwardReach(Vector3 position); // 0x000000018AC01498-0x000000018AC014CC
		private void BackwardReachUnlimited(Vector3 position); // 0x000000018AC01378-0x000000018AC01498
		private void BackwardReachLimited(Vector3 position); // 0x000000018AC00DBC-0x000000018AC01378
		private void MapToSolverPositions(); // 0x000000018AC01EE4-0x000000018AC02050
		private void MapToSolverPositionsLimited(); // 0x000000018AC01DF4-0x000000018AC01EE4
	}

	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver // TypeDefIndex: 56181
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
		public IKSolverFABRIKRoot(); // 0x000000018AC00D64-0x000000018AC00DBC
	
		// Methods
		public override bool IsValid(ref string message); // 0x000000018AC003BC-0x000000018AC00A08
		public override void StoreDefaultLocalState(); // 0x000000018AC00CD4-0x000000018AC00D64
		public override void FixTransforms(); // 0x000000018ABFFE84-0x000000018ABFFF24
		protected override void OnInitiate(); // 0x000000018AC00A08-0x000000018AC00AD8
		private bool IsRoot(int index); // 0x000000018AC0032C-0x000000018AC003BC
		protected override void OnUpdate(); // 0x000000018AC00AD8-0x000000018AC00CD4
		public override Point[] GetPoints(); // 0x000000018AC002A4-0x000000018AC0032C
		public override Point GetPoint(Transform transform); // 0x000000018AC0022C-0x000000018AC002A4
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain); // 0x000000018ABFFD8C-0x000000018ABFFE84
		private Vector3 GetCentroid(); // 0x000000018ABFFF24-0x000000018AC0022C
	}

	[Serializable]
	public class IKSolverFullBody : IKSolver // TypeDefIndex: 56182
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
		public IKSolverFullBody(); // 0x000000018AC06C58-0x000000018AC06D78
	
		// Methods
		public IKEffector GetEffector(Transform t); // 0x000000018AC05DDC-0x000000018AC05E98
		public FBIKChain GetChain(Transform transform); // 0x000000018AC05D98-0x000000018AC05DDC
		public int GetChainIndex(Transform transform); // 0x000000018AC05C94-0x000000018AC05D98
		public Node GetNode(int chainIndex, int nodeIndex); // 0x000000018AC05E98-0x000000018AC05EE0
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex); // 0x000000018AC05C18-0x000000018AC05C94
		public override Point[] GetPoints(); // 0x000000018AC06020-0x000000018AC0616C
		public override Point GetPoint(Transform transform); // 0x000000018AC05EE0-0x000000018AC06020
		public override bool IsValid(ref string message); // 0x000000018AC0616C-0x000000018AC0631C
		public override void StoreDefaultLocalState(); // 0x000000018AC06AE4-0x000000018AC06B98
		public override void FixTransforms(); // 0x000000018AC05B50-0x000000018AC05C18
		protected override void OnInitiate(); // 0x000000018AC0631C-0x000000018AC06428
		protected override void OnUpdate(); // 0x000000018AC06428-0x000000018AC06588
		protected virtual void ReadPose(); // 0x000000018AC06588-0x000000018AC067B0
		protected virtual void Solve(); // 0x000000018AC067B0-0x000000018AC06AE4
		protected virtual void ApplyBendConstraints(); // 0x000000018AC05B14-0x000000018AC05B50
		protected virtual void WritePose(); // 0x000000018AC06B98-0x000000018AC06C58
	}

	[Serializable]
	public enum FullBodyBipedEffector // TypeDefIndex: 56183
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
	public enum FullBodyBipedChain // TypeDefIndex: 56184
	{
		LeftArm = 0,
		RightArm = 1,
		LeftLeg = 2,
		RightLeg = 3
	}

	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 56185
	{
		// Fields
		public Transform rootNode; // 0xD0
		[Range(0f, 1f)]
		public float spineStiffness; // 0xD8
		[Range(-1f, 1f)]
		public float pullBodyVertical; // 0xDC
		[Range(-1f, 1f)]
		public float pullBodyHorizontal; // 0xE0
		[CompilerGenerated]
		private Vector3 _pullBodyOffset_k__BackingField; // 0xE4
		private Vector3 offset; // 0xF0
	
		// Properties
		public IKEffector bodyEffector { get; } // 0x000000018AC05938-0x000000018AC05944 
		public IKEffector leftShoulderEffector { get; } // 0x000000018AC05A0C-0x000000018AC05A1C 
		public IKEffector rightShoulderEffector { get; } // 0x000000018AC05AF4-0x000000018AC05B04 
		public IKEffector leftThighEffector { get; } // 0x000000018AC05A1C-0x000000018AC05A2C 
		public IKEffector rightThighEffector { get; } // 0x000000018AC05B04-0x000000018AC05B14 
		public IKEffector leftHandEffector { get; } // 0x000000018AC059A8-0x000000018AC059B8 
		public IKEffector rightHandEffector { get; } // 0x000000018AC05A90-0x000000018AC05AA0 
		public IKEffector leftFootEffector { get; } // 0x000000018AC05998-0x000000018AC059A8 
		public IKEffector rightFootEffector { get; } // 0x000000018AC05A80-0x000000018AC05A90 
		public FBIKChain leftArmChain { get; } // 0x000000018AC05944-0x000000018AC0596C 
		public FBIKChain rightArmChain { get; } // 0x000000018AC05A2C-0x000000018AC05A54 
		public FBIKChain leftLegChain { get; } // 0x000000018AC059B8-0x000000018AC059E0 
		public FBIKChain rightLegChain { get; } // 0x000000018AC05AA0-0x000000018AC05AC8 
		public IKMappingLimb leftArmMapping { get; } // 0x000000018AC0596C-0x000000018AC05998 
		public IKMappingLimb rightArmMapping { get; } // 0x000000018AC05A54-0x000000018AC05A80 
		public IKMappingLimb leftLegMapping { get; } // 0x000000018AC059E0-0x000000018AC05A0C 
		public IKMappingLimb rightLegMapping { get; } // 0x000000018AC05AC8-0x000000018AC05AF4 
		public IKMappingBone headMapping { get; } // 0x000000018AC039E4-0x000000018AC03A0C 
		public Vector3 pullBodyOffset { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA96A0-0x0000000184DA96C0 0x0000000184DA96C0-0x0000000184DA96E0
	
		// Constructors
		public IKSolverFullBodyBiped(); // 0x000000018AC0591C-0x000000018AC05938
	
		// Methods
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f /* Metadata: 0x0234791B */); // 0x000000018AC040E4-0x000000018AC04148
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight); // 0x000000018AC04148-0x000000018AC041FC
		public FBIKChain GetChain(FullBodyBipedChain c); // 0x000000018AC03544-0x000000018AC035C4
		public FBIKChain GetChain(FullBodyBipedEffector effector); // 0x000000018AC035C4-0x000000018AC03674
		public IKEffector GetEffector(FullBodyBipedEffector effector); // 0x000000018AC03674-0x000000018AC037AC
		public IKEffector GetEndEffector(FullBodyBipedChain c); // 0x000000018AC037AC-0x000000018AC0382C
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain); // 0x000000018AC03AAC-0x000000018AC03B38
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector); // 0x000000018AC03B38-0x000000018AC03BD8
		public IKMappingSpine GetSpineMapping(); // 0x0000000184D862B0-0x0000000184D862C0
		public IKMappingBone GetHeadMapping(); // 0x000000018AC039E4-0x000000018AC03A0C
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb); // 0x000000018AC032A4-0x000000018AC0332C
		public override bool IsValid(ref string message); // 0x000000018AC03C78-0x000000018AC03E0C
		public void SetToReferences(BipedReferences references, Transform rootNode = null); // 0x000000018AC04494-0x000000018AC05848
		public static Transform DetectRootNodeBone(BipedReferences references); // 0x000000018AC02F28-0x000000018AC032A4
		public void SetLimbOrientations(BipedLimbOrientations o); // 0x000000018AC04428-0x000000018AC04494
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation); // 0x000000018AC041FC-0x000000018AC04428
		private static Transform GetLeftClavicle(BipedReferences references); // 0x000000018AC03A0C-0x000000018AC03AAC
		private static Transform GetRightClavicle(BipedReferences references); // 0x000000018AC03BD8-0x000000018AC03C78
		private static bool Contains(Transform[] array, Transform transform); // 0x000000018AC02E90-0x000000018AC02F28
		protected override void ReadPose(); // 0x000000018AC03FE0-0x000000018AC040E4
		private void PullBody(); // 0x000000018AC03E0C-0x000000018AC03FE0
		private Vector3 GetBodyOffset(); // 0x000000018AC0332C-0x000000018AC03544
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset); // 0x000000018AC0382C-0x000000018AC039E4
		protected override void ApplyBendConstraints(); // 0x000000018AC02B40-0x000000018AC02E90
		protected override void WritePose(); // 0x000000018AC05848-0x000000018AC0591C
	}

	[Serializable]
	public class IKSolverHeuristic : IKSolver // TypeDefIndex: 56186
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
		protected virtual int minBones { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		protected virtual bool boneLengthCanBeZero { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		protected virtual bool allowCommonParent { get; } // 0x00000001812081B0-0x0000000181208610 
		protected virtual Vector3 localDirection { get; } // 0x000000018AC07578-0x000000018AC076C4 
		protected float positionOffset { get; } // 0x000000018AC076C4-0x000000018AC0773C 
	
		// Constructors
		public IKSolverHeuristic(); // 0x00000001839DDC40-0x00000001839DDCA0
	
		// Methods
		public bool SetChain(Transform[] hierarchy, Transform root); // 0x00000001839DED80-0x00000001839DEE90
		public void AddBone(Transform bone); // 0x000000018AC06D78-0x000000018AC06E7C
		public override void StoreDefaultLocalState(); // 0x00000001839DEE90-0x00000001839DEEF0
		public override void FixTransforms(); // 0x000000018AC06E7C-0x000000018AC06EDC
		public override bool IsValid(ref string message); // 0x00000001839DEF70-0x00000001839DF320
		public override Point[] GetPoints(); // 0x0000000184D862B0-0x0000000184D862C0
		public override Point GetPoint(Transform transform); // 0x000000018AC06EDC-0x000000018AC06F98
		protected override void OnInitiate(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnUpdate(); // 0x00000001841E1670-0x00000001841E1680
		protected void InitiateBones(); // 0x00000001839DF680-0x00000001839DFC20
		protected Vector3 GetSingularityOffset(); // 0x000000018AC06F98-0x000000018AC072E8
		private bool SingularityDetected(); // 0x000000018AC072E8-0x000000018AC07578
	}

	[Serializable]
	public class IKSolverLeg : IKSolver // TypeDefIndex: 56187
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
		public IKSolverLeg(); // 0x000000018AC0854C-0x000000018AC08744
	
		// Methods
		public override bool IsValid(ref string message); // 0x000000018AC079AC-0x000000018AC07CA8
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root); // 0x000000018ABFCBC0-0x000000018ABFCC70
		public override Point[] GetPoints(); // 0x000000018AC078A8-0x000000018AC079AC
		public override Point GetPoint(Transform transform); // 0x000000018AC0773C-0x000000018AC078A8
		public override void StoreDefaultLocalState(); // 0x000000018ABFCCF0-0x000000018ABFCD50
		public override void FixTransforms(); // 0x000000018ABFC084-0x000000018ABFC0E8
		protected override void OnInitiate(); // 0x000000018AC07CA8-0x000000018AC07D24
		protected override void OnUpdate(); // 0x000000018AC07D24-0x000000018AC07D50
		private void Solve(); // 0x000000018AC08210-0x000000018AC082FC
		private void Read(); // 0x000000018AC07D50-0x000000018AC08210
		private void Write(); // 0x000000018AC082FC-0x000000018AC0854C
	}

	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric // TypeDefIndex: 56190
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
		private AxisDirection[] axisDirections { get; } // 0x000000018AC087CC-0x000000018AC087E8 
	
		// Nested types
		[Serializable]
		public enum BendModifier // TypeDefIndex: 56188
		{
			Animation = 0,
			Target = 1,
			Parent = 2,
			Arm = 3,
			Goal = 4
		}
	
		[Serializable]
		public struct AxisDirection // TypeDefIndex: 56189
		{
			// Fields
			public Vector3 direction; // 0x00
			public Vector3 axis; // 0x0C
			public float dot; // 0x18
	
			// Constructors
			public AxisDirection(Vector3 direction, Vector3 axis); // 0x00000001833B3B20-0x00000001833B3B80
		}
	
		// Constructors
		public IKSolverLimb(); // 0x000000018AC08744-0x000000018AC087CC
		public IKSolverLimb(AvatarIKGoal goal); // 0x00000001839DD990-0x00000001839DDA30
	
		// Methods
		public void MaintainRotation(); // 0x000000018326ACB0-0x000000018326AD20
		public void MaintainBend(); // 0x000000018326AD20-0x000000018326ADF0
		protected override void OnInitiateVirtual(); // 0x00000001833B26B0-0x00000001833B29F0
		protected override void OnUpdateVirtual(); // 0x0000000183A6DCD0-0x0000000183A6DDA0
		protected override void OnPostSolveVirtual(); // 0x0000000183C2DF70-0x0000000183C2DFC0
		private void StoreAxisDirections(ref AxisDirection[] axisDirections); // 0x00000001833B3830-0x00000001833B3B20
		private Vector3 GetModifiedBendNormal(); // 0x0000000183A6DDA0-0x0000000183A6DED0
	}

	[Serializable]
	public class IKSolverLookAt : IKSolver // TypeDefIndex: 56192
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
		public Quaternion[] spineVirtualBone { get; set; } // 0x000000018AC08D98-0x000000018AC08E6C 0x000000018485F170-0x000000018485F180
		public Quaternion headVirtualBones { get; set; } // 0x0000000184D8E8F0-0x0000000184D8E900 0x0000000184DA96F0-0x0000000184DA9700
		public Quaternion eyeVirtualBone { get; set; } // 0x0000000184D9DC90-0x0000000184D9DCA0 0x0000000184DA12D0-0x0000000184DA12E0
		protected bool spineIsValid { get; } // 0x00000001839E00C0-0x00000001839E01C0 
		protected bool spineIsEmpty { get; } // 0x0000000183270BE0-0x0000000183270C10 
		protected bool headIsValid { get; } // 0x00000001839E0040-0x00000001839E0050 
		protected bool headIsEmpty { get; } // 0x0000000183270B60-0x0000000183270BE0 
		protected bool eyesIsValid { get; } // 0x00000001839E0050-0x00000001839E00C0 
		protected bool eyesIsEmpty { get; } // 0x0000000183270B30-0x0000000183270B60 
	
		// Nested types
		[Serializable]
		public class LookAtBone : IKSolver.Bone // TypeDefIndex: 56191
		{
			// Fields
			public Vector3 positionOffset; // 0x80
			public Vector3 baseForwardOffsetEuler; // 0x8C
	
			// Properties
			public Vector3 forward { get; } // 0x0000000182F410B0-0x0000000182F41150 
	
			// Constructors
			public LookAtBone(); // 0x00000001839DDF20-0x00000001839DDF40
			public LookAtBone(Transform transform); // 0x00000001839DD630-0x00000001839DD680
	
			// Methods
			public void Initiate(Transform root); // 0x00000001843C8CC0-0x00000001843C8E00
			public void LookAt(Vector3 direction, float weight); // 0x0000000183272B30-0x0000000183272D20
			public Quaternion LookAtReturnRotation(Vector3 direction, float weight); // 0x000000018AC0E6A4-0x000000018AC0E7A0
		}
	
		// Constructors
		public IKSolverLookAt(); // 0x00000001839DDCA0-0x00000001839DDF20
	
		// Methods
		public void SetLookAtWeight(float weight); // 0x000000018ABFD574-0x000000018ABFD598
		public void SetLookAtWeight(float weight, float bodyWeight); // 0x000000018AC08AF4-0x000000018AC08B3C
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight); // 0x000000018AC08BE4-0x000000018AC08C48
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight); // 0x000000018AC08D20-0x000000018AC08D98
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight); // 0x000000018AC08B3C-0x000000018AC08BE4
		public void SetLookAtWeight(float weight, float bodyWeight = 0f /* Metadata: 0x02347924 */, float headWeight = 1f /* Metadata: 0x02347928 */, float eyesWeight = 0.5f /* Metadata: 0x0234792C */, float clampWeight = 0.5f /* Metadata: 0x02347930 */, float clampWeightHead = 0.5f /* Metadata: 0x02347934 */, float clampWeightEyes = 0.3f /* Metadata: 0x02347938 */); // 0x000000018AC08C48-0x000000018AC08D20
		public override void StoreDefaultLocalState(); // 0x00000001839DE920-0x00000001839DEA40
		public void SetDirty(); // 0x0000000184DA96E0-0x0000000184DA96F0
		public override void FixTransforms(); // 0x0000000183E998B0-0x0000000183E998E0
		public override bool IsValid(ref string message); // 0x00000001839DE590-0x00000001839DE740
		public override Point[] GetPoints(); // 0x000000018AC08920-0x000000018AC08AF4
		public override Point GetPoint(Transform transform); // 0x000000018AC087E8-0x000000018AC08920
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root); // 0x00000001839DD470-0x00000001839DD540
		protected override void OnInitiate(); // 0x00000001843C8A50-0x00000001843C8CC0
		protected override void OnUpdate(); // 0x00000001832709C0-0x0000000183270A80
		protected void SolveSpine(); // 0x00000001832724E0-0x0000000183272A10
		protected void SolveHead(); // 0x00000001832713B0-0x0000000183271B40
		protected void SolveEyes(); // 0x0000000183270A80-0x0000000183270B30
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp); // 0x0000000183251E90-0x0000000183251F80
		protected void SetBones(Transform[] array, ref LookAtBone[] bones); // 0x00000001839DD540-0x00000001839DD630
	}

	[Serializable]
	public class IKSolverTrigonometric : IKSolver // TypeDefIndex: 56194
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
		public class TrigonometricBone : IKSolver.Bone // TypeDefIndex: 56193
		{
			// Fields
			private Quaternion targetToLocalSpace; // 0x80
			private Vector3 defaultLocalBendNormal; // 0x90
	
			// Constructors
			public TrigonometricBone(); // 0x000000018539475C-0x0000000185394764
	
			// Methods
			public void Initiate(Vector3 childPosition, Vector3 bendNormal); // 0x0000000184128940-0x0000000184128B30
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal); // 0x0000000183271130-0x00000001832711D0
			public Vector3 GetBendNormalFromCurrentRotation(); // 0x0000000182F41150-0x0000000182F41200
		}
	
		// Constructors
		public IKSolverTrigonometric(); // 0x00000001839DDA30-0x00000001839DDB50
	
		// Methods
		public void SetBendGoalPosition(Vector3 goalPosition, float weight); // 0x000000018AC091E4-0x000000018AC093F0
		public void SetBendPlaneToCurrent(); // 0x0000000184128BE0-0x0000000184128C10
		public void SetIKRotation(Quaternion rotation); // 0x0000000184DA9710-0x0000000184DA9720
		public void SetIKRotationWeight(float weight); // 0x000000018AC093F0-0x000000018AC09414
		public Quaternion GetIKRotation(); // 0x0000000184DA9700-0x0000000184DA9710
		public float GetIKRotationWeight(); // 0x0000000184D88480-0x0000000184D88490
		public override Point[] GetPoints(); // 0x000000018AC09120-0x000000018AC091E4
		public override Point GetPoint(Transform transform); // 0x000000018AC09028-0x000000018AC09120
		public override void StoreDefaultLocalState(); // 0x00000001839DFD10-0x00000001839DFD60
		public override void FixTransforms(); // 0x0000000182FA5DE0-0x0000000182FA6250
		public override bool IsValid(ref string message); // 0x00000001835B22D0-0x00000001835B27E0
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root); // 0x00000001839DE1F0-0x00000001839DE270
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight); // 0x000000018AC09414-0x000000018AC098F8
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2); // 0x000000018AC08E6C-0x000000018AC09028
		protected override void OnInitiate(); // 0x0000000184128750-0x0000000184128840
		private bool IsDirectHierarchy(); // 0x0000000184128C10-0x0000000184128D30
		public void InitiateBones(); // 0x0000000184128840-0x0000000184128940
		protected override void OnUpdate(); // 0x00000001832759E0-0x0000000183276380
		protected virtual void OnInitiateVirtual(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnUpdateVirtual(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnPostSolveVirtual(); // 0x00000001841E1670-0x00000001841E1680
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal); // 0x0000000183270E10-0x0000000183271130
	}

	[Serializable]
	public class IKSolverVR : IKSolver // TypeDefIndex: 56206
	{
		// Fields
		[CompilerGenerated]
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
		[Range(0f, 2f)]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		public int LOD; // 0xD0
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale; // 0xD4
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet; // 0xD8
		[CompilerGenerated]
		private VirtualBone _rootBone_k__BackingField; // 0xE0
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
		public Animator animator { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		[HideInInspector]
		public VirtualBone rootBone { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8D1C0-0x0000000184D8D1D0 0x0000000186AC5B08-0x0000000186AC5B1C
	
		// Nested types
		[Serializable]
		public class Arm : BodyPart // TypeDefIndex: 56196
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
			[CompilerGenerated]
			private Vector3 _position_k__BackingField; // 0xDC
			[CompilerGenerated]
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
			public Vector3 position { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA9720-0x0000000184DA9740 0x0000000184DA9740-0x0000000184DA9760
			public Quaternion rotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA0B10-0x0000000184DA0B20 0x0000000184DA9760-0x0000000184DA9770
			private VirtualBone shoulder { get; } // 0x000000018AC11E54-0x000000018AC11E7C 
			private VirtualBone upperArm { get; } // 0x000000018AC11E7C-0x000000018AC11EC4 
			private VirtualBone forearm { get; } // 0x000000018AC11DBC-0x000000018AC11E08 
			private VirtualBone hand { get; } // 0x000000018AC11E08-0x000000018AC11E54 
	
			// Nested types
			[Serializable]
			public enum ShoulderRotationMode // TypeDefIndex: 56195
			{
				YawPitch = 0,
				FromTo = 1
			}
	
			// Constructors
			public Arm(); // 0x000000018AC11C84-0x000000018AC11DBC
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x000000018AC0EE9C-0x000000018AC0F89C
			public override void PreSolve(float scale); // 0x000000018AC0F89C-0x000000018AC0FAC8
			public override void ApplyOffsets(float scale); // 0x000000018AC0E7A0-0x000000018AC0E808
			private void Stretching(); // 0x000000018AC1146C-0x000000018AC1192C
			public void Solve(bool isLeft); // 0x000000018AC0FAE4-0x000000018AC1146C
			public override void ResetOffsets(); // 0x000000018AC0FAC8-0x000000018AC0FAE4
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x000000018AC11A44-0x000000018AC11C84
			private float DamperValue(float value, float min, float max, float weight = 1f /* Metadata: 0x0234793C */); // 0x000000018AC0E808-0x000000018AC0E8B0
			private Vector3 GetBendNormal(Vector3 dir); // 0x000000018AC0E8B0-0x000000018AC0EE9C
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, UnityEngine.Color color); // 0x000000018AC1192C-0x000000018AC11A44
		}
	
		[Serializable]
		public abstract class BodyPart // TypeDefIndex: 56197
		{
			// Fields
			[CompilerGenerated]
			private float _sqrMag_k__BackingField; // 0x10
			[CompilerGenerated]
			private float _mag_k__BackingField; // 0x14
			[HideInInspector]
			public VirtualBone[] bones; // 0x18
			protected bool initiated; // 0x20
			protected Vector3 rootPosition; // 0x24
			protected Quaternion rootRotation; // 0x30
			protected int index; // 0x40
			protected int LOD; // 0x44
	
			// Properties
			public float sqrMag { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85F70-0x0000000184D85F80 0x0000000184D88280-0x0000000184D88290
			public float mag { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88D40-0x0000000184D88D50 0x0000000184D88D50-0x0000000184D88D60
	
			// Constructors
			protected BodyPart(); // 0x000000018AC12584-0x000000018AC125E4
	
			// Methods
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);
			public abstract void PreSolve(float scale);
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);
			public abstract void ApplyOffsets(float scale);
			public abstract void ResetOffsets();
			public void SetLOD(int LOD); // 0x0000000184D86580-0x0000000184D86590
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x000000018AC12064-0x000000018AC1216C
			public void MovePosition(Vector3 position); // 0x000000018AC11EC4-0x000000018AC11FA8
			public void MoveRotation(Quaternion rotation); // 0x000000018AC11FA8-0x000000018AC12064
			public void Translate(Vector3 position, Quaternion rotation); // 0x000000018AC123E8-0x000000018AC1243C
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot); // 0x000000018AC1228C-0x000000018AC123E8
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f /* Metadata: 0x02347942 */); // 0x000000018AC1216C-0x000000018AC1228C
			public void Visualize(UnityEngine.Color color); // 0x000000018AC1243C-0x000000018AC12554
			public void Visualize(); // 0x000000018AC12554-0x000000018AC12584
		}
	
		[Serializable]
		public class Footstep // TypeDefIndex: 56198
		{
			// Fields
			public float stepSpeed; // 0x10
			public Vector3 characterSpaceOffset; // 0x14
			public Vector3 position; // 0x20
			public Quaternion rotation; // 0x2C
			public Quaternion stepToRootRot; // 0x3C
			public bool isSupportLeg; // 0x4C
			public bool relaxFlag; // 0x4D
			[CompilerGenerated]
			private float _stepProgress_k__BackingField; // 0x50
			public Vector3 stepFrom; // 0x54
			public Vector3 stepTo; // 0x60
			public Quaternion stepFromRot; // 0x6C
			public Quaternion stepToRot; // 0x7C
			private Quaternion footRelativeToRoot; // 0x8C
			private float supportLegW; // 0x9C
			private float supportLegWV; // 0xA0
	
			// Properties
			public bool isStepping { get; } // 0x000000018AC12B90-0x000000018AC12BA0 
			public float stepProgress { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
	
			// Constructors
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset); // 0x000000018AC12A6C-0x000000018AC12B90
	
			// Methods
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation); // 0x0000000184DA9770-0x0000000184DA97C0
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold); // 0x000000018AC125E4-0x000000018AC1270C
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime); // 0x000000018AC12804-0x000000018AC12918
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime); // 0x000000018AC1270C-0x000000018AC12804
			public void Update(RootMotion.InterpolationMode interpolation, UnityEvent onStep, float deltaTime); // 0x000000018AC12918-0x000000018AC12A6C
		}
	
		[Serializable]
		public class Leg : BodyPart // TypeDefIndex: 56199
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
			[CompilerGenerated]
			private Vector3 _position_k__BackingField; // 0xC4
			[CompilerGenerated]
			private Quaternion _rotation_k__BackingField; // 0xD0
			[CompilerGenerated]
			private bool _hasToes_k__BackingField; // 0xE0
			[CompilerGenerated]
			private Vector3 _thighRelativeToPelvis_k__BackingField; // 0xE4
			private Vector3 footPosition; // 0xF0
			private Quaternion footRotation; // 0xFC
			private Vector3 bendNormal; // 0x10C
			private Quaternion calfRelToThigh; // 0x118
			private Quaternion thighRelToFoot; // 0x128
			[CompilerGenerated]
			private Vector3 _bendNormalRelToPelvis_k__BackingField; // 0x138
			[CompilerGenerated]
			private Vector3 _bendNormalRelToTarget_k__BackingField; // 0x144
	
			// Properties
			public Vector3 position { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D9E3A0-0x0000000184D9E3C0 0x0000000184D9E440-0x0000000184D9E460
			public Quaternion rotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D9E7C0-0x0000000184D9E7D0 0x0000000184DA12C0-0x0000000184DA12D0
			public bool hasToes { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D885E0-0x0000000184D885F0 0x0000000184D88640-0x0000000184D88650
			public VirtualBone thigh { get; } // 0x000000018AC11E54-0x000000018AC11E7C 
			private VirtualBone calf { get; } // 0x0000000188355F28-0x0000000188355F50 
			private VirtualBone foot { get; } // 0x000000018AC170B0-0x000000018AC170D8 
			private VirtualBone toes { get; } // 0x000000018AC17108-0x000000018AC17130 
			public VirtualBone lastBone { get; } // 0x000000018AC170D8-0x000000018AC17108 
			public Vector3 thighRelativeToPelvis { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA96A0-0x0000000184DA96C0 0x0000000184DA96C0-0x0000000184DA96E0
			public Vector3 bendNormalRelToPelvis { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA97C0-0x0000000184DA97E0 0x0000000184DA9800-0x0000000184DA9820
			public Vector3 bendNormalRelToTarget { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA97E0-0x0000000184DA9800 0x0000000184DA9820-0x0000000184DA9840
	
			// Constructors
			public Leg(); // 0x000000018AC16FC4-0x000000018AC170B0
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x000000018AC156C8-0x000000018AC15F04
			public override void PreSolve(float scale); // 0x000000018AC15F04-0x000000018AC164D8
			public override void ApplyOffsets(float scale); // 0x000000018AC14A54-0x000000018AC15098
			private void ApplyPositionOffset(Vector3 offset, float weight); // 0x000000018AC15098-0x000000018AC15180
			private void ApplyRotationOffset(Quaternion offset, float weight); // 0x000000018AC15180-0x000000018AC15358
			public void Solve(bool stretch); // 0x000000018AC16540-0x000000018AC167C8
			private void FixTwistRotations(); // 0x000000018AC15358-0x000000018AC156C8
			private void Stretching(); // 0x000000018AC167C8-0x000000018AC16D80
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x000000018AC16D80-0x000000018AC16FC4
			public override void ResetOffsets(); // 0x000000018AC164D8-0x000000018AC16540
		}
	
		[Serializable]
		public class Locomotion // TypeDefIndex: 56201
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
			[CompilerGenerated]
			private Vector3 _centerOfMass_k__BackingField; // 0x148
			private Footstep[] footsteps; // 0x158
			private Vector3 lastComPosition; // 0x160
			private Vector3 comVelocity; // 0x16C
			private int leftFootIndex; // 0x178
			private int rightFootIndex; // 0x17C
	
			// Properties
			public Vector3 centerOfMass { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D90FC0-0x0000000184D90FE0 0x0000000184D91040-0x0000000184D91060
			public Vector3 leftFootstepPosition { get; } // 0x000000018AC1B360-0x000000018AC1B3A4 
			public Vector3 rightFootstepPosition { get; } // 0x000000018AC1B3E4-0x000000018AC1B428 
			public Quaternion leftFootstepRotation { get; } // 0x000000018AC1B3A4-0x000000018AC1B3E4 
			public Quaternion rightFootstepRotation { get; } // 0x000000018AC1B428-0x000000018AC1B468 
	
			// Nested types
			[Serializable]
			public enum Mode // TypeDefIndex: 56200
			{
				Procedural = 0,
				Animated = 1
			}
	
			// Constructors
			public Locomotion(); // 0x000000018AC1B1B4-0x000000018AC1B360
	
			// Methods
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale); // 0x000000018AC18048-0x000000018AC180A8
			public void Reset(Vector3[] positions, Quaternion[] rotations); // 0x000000018AC186B0-0x000000018AC186E0
			public void Relax(); // 0x000000018AC180FC-0x000000018AC18104
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot); // 0x000000018AC17A54-0x000000018AC17AD8
			public void AddDeltaPosition(Vector3 delta); // 0x000000018AC173BC-0x000000018AC17418
			public void Initiate_Animated(Animator animator, Vector3[] positions); // 0x000000018AC17CC8-0x000000018AC17D7C
			private void ResetParams(Vector3[] positions); // 0x000000018AC18104-0x000000018AC181C4
			public void Reset_Animated(Vector3[] positions); // 0x000000018AC181C4-0x000000018AC18414
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot); // 0x000000018AC17418-0x000000018AC17640
			private void AddDeltaPosition_Animated(Vector3 delta); // 0x000000018AC17130-0x000000018AC17234
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime); // 0x000000018AC186E0-0x000000018AC196E4
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale); // 0x000000018AC17D7C-0x000000018AC18048
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations); // 0x000000018AC18414-0x000000018AC186B0
			private void Relax_Procedural(); // 0x000000018AC180A8-0x000000018AC180FC
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot); // 0x000000018AC17640-0x000000018AC17A54
			private void AddDeltaPosition_Procedural(Vector3 delta); // 0x000000018AC17234-0x000000018AC173BC
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime); // 0x000000018AC196E4-0x000000018AC1B028
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition); // 0x000000018AC1B028-0x000000018AC1B1B4
			private bool CanStep(); // 0x000000018AC17AD8-0x000000018AC17B38
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius); // 0x000000018AC17B38-0x000000018AC17CC8
		}
	
		[Serializable]
		public class Spine : BodyPart // TypeDefIndex: 56202
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
			[CompilerGenerated]
			private Quaternion _anchorRotation_k__BackingField; // 0x164
			[CompilerGenerated]
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
			internal VirtualBone pelvis { get; } // 0x000000018AC1EFBC-0x000000018AC1EFEC 
			internal VirtualBone firstSpineBone { get; } // 0x000000018AC1EF2C-0x000000018AC1EF5C 
			internal VirtualBone chest { get; } // 0x000000018AC1EEE8-0x000000018AC1EF2C 
			internal VirtualBone head { get; } // 0x000000018AC1EF5C-0x000000018AC1EF8C 
			private VirtualBone neck { get; } // 0x000000018AC1EF8C-0x000000018AC1EFBC 
			internal Quaternion anchorRotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA9850-0x0000000184DA9860 0x0000000184DA9870-0x0000000184DA9880
			internal Quaternion anchorRelativeToHead { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA9840-0x0000000184DA9850 0x0000000184DA9860-0x0000000184DA9870
	
			// Constructors
			public Spine(); // 0x000000018AC1ED2C-0x000000018AC1EEE8
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x000000018AC1CB00-0x000000018AC1D668
			public override void PreSolve(float scale); // 0x000000018AC1D668-0x000000018AC1DBE4
			public override void ApplyOffsets(float scale); // 0x000000018AC1B840-0x000000018AC1BDA4
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms); // 0x000000018AC1C228-0x000000018AC1C3F0
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale); // 0x000000018AC1DFB0-0x000000018AC1E6C0
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight); // 0x000000018AC1C3F0-0x000000018AC1C614
			private void SolvePelvis(); // 0x000000018AC1DC98-0x000000018AC1DFB0
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x000000018AC1EB20-0x000000018AC1ED2C
			public override void ResetOffsets(); // 0x000000018AC1DBE4-0x000000018AC1DC98
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms); // 0x000000018AC1B468-0x000000018AC1B840
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w); // 0x000000018AC1C614-0x000000018AC1C7A4
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale); // 0x000000018AC1E6C0-0x000000018AC1EB20
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2 /* Metadata: 0x02347948 */); // 0x000000018AC1C7A4-0x000000018AC1CB00
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w); // 0x000000018AC1BDA4-0x000000018AC1BFB8
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w); // 0x000000018AC1BFB8-0x000000018AC1C228
		}
	
		[Serializable]
		public enum PositionOffset // TypeDefIndex: 56203
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
		public enum RotationOffset // TypeDefIndex: 56204
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2
		}
	
		[Serializable]
		public class VirtualBone // TypeDefIndex: 56205
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
			public VirtualBone(Vector3 position, Quaternion rotation); // 0x0000000184DA9880-0x0000000184DA98B0
	
			// Methods
			public void Read(Vector3 position, Quaternion rotation); // 0x0000000184DA9880-0x0000000184DA98B0
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x02347955 */); // 0x000000018AC21714-0x000000018AC218D8
			public static float PreSolve(ref VirtualBone[] bones); // 0x000000018AC20200-0x000000018AC204B8
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation); // 0x000000018AC204B8-0x000000018AC2063C
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation); // 0x000000018AC2063C-0x000000018AC207FC
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation); // 0x000000018AC207FC-0x000000018AC209B4
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation); // 0x000000018AC209B4-0x000000018AC20A68
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight); // 0x000000018AC211CC-0x000000018AC21714
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2); // 0x000000018AC20044-0x000000018AC20200
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset); // 0x000000018AC20D3C-0x000000018AC211CC
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018AC20C58-0x000000018AC20D3C
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations); // 0x000000018AC20A68-0x000000018AC20C58
		}
	
		// Constructors
		public IKSolverVR(); // 0x000000018AC0E38C-0x000000018AC0E6A4
	
		// Methods
		public void SetToReferences(VRIK.References references); // 0x000000018AC0BF8C-0x000000018AC0C290
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero); // 0x000000018AC0AD88-0x000000018AC0B0D4
		public void DefaultAnimationCurves(); // 0x000000018AC09E9C-0x000000018AC0A054
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value); // 0x000000018AC09A44-0x000000018AC09D50
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value); // 0x000000018AC09D50-0x000000018AC09DA8
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value); // 0x000000018AC09DA8-0x000000018AC09E9C
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot); // 0x000000018AC098F8-0x000000018AC09A44
		public void Reset(); // 0x000000018AC0BE54-0x000000018AC0BF8C
		public override void StoreDefaultLocalState(); // 0x000000018AC0DAB8-0x000000018AC0DC10
		public override void FixTransforms(); // 0x000000018AC0A054-0x000000018AC0A228
		public override Point[] GetPoints(); // 0x000000018AC0AC14-0x000000018AC0AC64
		public override Point GetPoint(Transform transform); // 0x000000018AC0ABC4-0x000000018AC0AC14
		public override bool IsValid(ref string message); // 0x000000018AC0B0D4-0x000000018AC0B358
		private Vector3 GetNormal(Transform[] transforms); // 0x000000018AC0A228-0x000000018AC0A4DC
		private static Keyframe[] GetSineKeyframes(float mag); // 0x000000018AC0ACC4-0x000000018AC0AD88
		private void UpdateSolverTransforms(); // 0x000000018AC0DC10-0x000000018AC0DD54
		protected override void OnInitiate(); // 0x000000018AC0B358-0x000000018AC0B3AC
		protected override void OnUpdate(); // 0x000000018AC0B3AC-0x000000018AC0B8EC
		private void WriteTransforms(); // 0x000000018AC0DD54-0x000000018AC0E22C
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms); // 0x000000018AC0B8EC-0x000000018AC0BE54
		private void Solve(); // 0x000000018AC0C290-0x000000018AC0DAB8
		private Vector3 GetPosition(int index); // 0x000000018AC0AC64-0x000000018AC0AC94
		private Quaternion GetRotation(int index); // 0x000000018AC0AC94-0x000000018AC0ACC4
		private void Write(); // 0x000000018AC0E22C-0x000000018AC0E38C
		private Vector3 GetPelvisOffset(float deltaTime); // 0x000000018AC0A4DC-0x000000018AC0ABC4
	}

	public class TwistRelaxer : MonoBehaviour // TypeDefIndex: 56207
	{
		// Fields
		public IK ik; // 0x18
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers; // 0x20
	
		// Constructors
		public TwistRelaxer(); // 0x000000018AC1F484-0x000000018AC1F4D4
	
		// Methods
		public void Start(); // 0x000000018AC1F230-0x000000018AC1F3E8
		private void Update(); // 0x000000018AC1F3E8-0x000000018AC1F484
		private void OnPostUpdate(); // 0x000000018AC1F1A4-0x000000018AC1F230
		private void LateUpdate(); // 0x000000018AC1EFEC-0x000000018AC1F078
		private void OnDestroy(); // 0x000000018AC1F078-0x000000018AC1F1A4
	}

	[Serializable]
	public class TwistSolver // TypeDefIndex: 56208
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
		public TwistSolver(); // 0x000000018AC1FFA8-0x000000018AC20044
	
		// Methods
		public void Initiate(); // 0x000000018AC1F588-0x000000018AC1FB44
		public void FixTransforms(); // 0x000000018AC1F4D4-0x000000018AC1F588
		public void Relax(); // 0x000000018AC1FB44-0x000000018AC1FFA8
	}

	[Serializable]
	public class InteractionEffector // TypeDefIndex: 56209
	{
		// Fields
		[CompilerGenerated]
		private FullBodyBipedEffector _effectorType_k__BackingField; // 0x10
		[CompilerGenerated]
		private bool _isPaused_k__BackingField; // 0x14
		[CompilerGenerated]
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
		public FullBodyBipedEffector effectorType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		public bool isPaused { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8EE50-0x0000000184D8EE60 0x0000000184D8EE70-0x0000000184D8EE80
		public InteractionObject interactionObject { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public bool inInteraction { get; } // 0x000000018AC149CC-0x000000018AC14A1C 
		public float progress { get; } // 0x000000018AC14A1C-0x000000018AC14A54 
	
		// Constructors
		public InteractionEffector(FullBodyBipedEffector effectorType); // 0x000000018AC14940-0x000000018AC149CC
	
		// Methods
		public void Initiate(InteractionSystem interactionSystem); // 0x000000018AC12BA0-0x000000018AC12C58
		private void StoreDefaults(); // 0x000000018AC13E0C-0x000000018AC13FFC
		public bool ResetToDefaults(float speed, float deltaTime); // 0x000000018AC13310-0x000000018AC13780
		public bool Pause(); // 0x000000018AC12F44-0x000000018AC13064
		public bool Resume(); // 0x000000018AC13780-0x000000018AC137D4
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt); // 0x000000018AC13BDC-0x000000018AC13CE4
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt); // 0x000000018AC137D4-0x000000018AC13BDC
		public void Update(Transform root, float speed, float deltaTime); // 0x000000018AC142A4-0x000000018AC14940
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause); // 0x000000018AC13FFC-0x000000018AC142A4
		private void PickUp(Transform root); // 0x000000018AC13064-0x000000018AC13310
		public bool Stop(); // 0x000000018AC13CE4-0x000000018AC13E0C
		public void OnPostFBBIK(); // 0x000000018AC12C58-0x000000018AC12F44
	}

	[Serializable]
	public class InteractionLookAt // TypeDefIndex: 56210
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
		public InteractionLookAt(); // 0x0000000184DA99B0-0x0000000184DA99C0
	
		// Methods
		public void Look(Transform target, float time); // 0x000000018AC27558-0x000000018AC276E4
		public void OnFixTransforms(); // 0x000000018AC276E4-0x000000018AC27764
		public void Update(); // 0x000000018AC2793C-0x000000018AC27B60
		public void SolveSpine(); // 0x000000018AC27828-0x000000018AC2793C
		public void SolveHead(); // 0x000000018AC27764-0x000000018AC27828
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour // TypeDefIndex: 56217
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
		[CompilerGenerated]
		private float _length_k__BackingField; // 0x48
		[CompilerGenerated]
		private InteractionSystem _lastUsedInteractionSystem_k__BackingField; // 0x50
		private InteractionTarget[] targets; // 0x58
	
		// Properties
		public float length { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public InteractionSystem lastUsedInteractionSystem { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public Transform lookAtTarget { get; } // 0x000000018AC28EE4-0x000000018AC28F4C 
		public Transform targetsRoot { get; } // 0x000000018AC28F4C-0x000000018AC28FB4 
	
		// Nested types
		[Serializable]
		public class InteractionEvent // TypeDefIndex: 56211
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
			public InteractionEvent(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Activate(Transform t); // 0x000000018AC274B0-0x000000018AC27558
		}
	
		[Serializable]
		public class Message // TypeDefIndex: 56212
		{
			// Fields
			[Tooltip("The name of the function called.")]
			public string function; // 0x10
			[Tooltip("The recipient game object.")]
			public GameObject recipient; // 0x18
			private const string empty = ""; // Metadata: 0x02347959
	
			// Constructors
			public Message(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Send(Transform t); // 0x000000018AC2E2E0-0x000000018AC2E3B8
		}
	
		[Serializable]
		public class AnimatorEvent // TypeDefIndex: 56213
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
			private const string empty = ""; // Metadata: 0x0234795A
	
			// Constructors
			public AnimatorEvent(); // 0x0000000184DA98B0-0x0000000184DA98C0
	
			// Methods
			public void Activate(bool pickUp); // 0x000000018AC22CA8-0x000000018AC22D68
			private void Activate(Animator animator); // 0x000000018AC22D68-0x000000018AC22E04
			private void Activate(Animation animation); // 0x000000018AC22BEC-0x000000018AC22CA8
		}
	
		[Serializable]
		public class WeightCurve // TypeDefIndex: 56215
		{
			// Fields
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type; // 0x10
			[Tooltip("The weight curve.")]
			public AnimationCurve curve; // 0x18
	
			// Nested types
			[Serializable]
			public enum Type // TypeDefIndex: 56214
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
			public WeightCurve(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public float GetValue(float timer); // 0x000000018AC337EC-0x000000018AC3380C
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 56216
		{
			// Fields
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve; // 0x10
			[Tooltip("The multiplier of the curve\'s value.")]
			public float multiplier; // 0x14
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result; // 0x18
	
			// Constructors
			public Multiplier(); // 0x00000001815845C0-0x00000001815845D0
	
			// Methods
			public float GetValue(WeightCurve weightCurve, float timer); // 0x000000018AC2E3B8-0x000000018AC2E3E8
		}
	
		// Constructors
		public InteractionObject(); // 0x000000018AC28E94-0x000000018AC28EE4
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018AC28E24-0x000000018AC28E58
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018AC28D20-0x000000018AC28D54
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1(); // 0x000000018AC28D54-0x000000018AC28D88
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2(); // 0x000000018AC28D88-0x000000018AC28DBC
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3(); // 0x000000018AC28DBC-0x000000018AC28DF0
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4(); // 0x000000018AC28DF0-0x000000018AC28E24
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018AC28E60-0x000000018AC28E94
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018AC27B60-0x000000018AC27B94
		public void Initiate(); // 0x000000018AC28B6C-0x000000018AC28D20
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem); // 0x000000018AC28774-0x000000018AC288A8
		public bool CurveUsed(WeightCurve.Type type); // 0x000000018AC28590-0x000000018AC28608
		public InteractionTarget[] GetTargets(); // 0x0000000182E56440-0x0000000182E56460
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag); // 0x000000018AC2865C-0x000000018AC28774
		public void OnStartInteraction(InteractionSystem interactionSystem); // 0x0000000182FDAEA0-0x0000000182FDAEB0
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight); // 0x000000018AC27B94-0x000000018AC27FF4
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer); // 0x000000018AC28908-0x000000018AC28B18
		private void Start(); // 0x000000018AC28E58-0x000000018AC28E60
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight); // 0x000000018AC27FF4-0x000000018AC28590
		private Transform GetTarget(FullBodyBipedEffector effectorType); // 0x000000018AC288A8-0x000000018AC28908
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType); // 0x000000018AC28B18-0x000000018AC28B6C
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType); // 0x000000018AC28608-0x000000018AC2865C
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour // TypeDefIndex: 56220
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
		[CompilerGenerated]
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
		[SerializeField]
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		private FullBodyBipedIK fullBody; // 0xD0
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt; // 0xD8
		private InteractionEffector[] interactionEffectors; // 0xE0
		[CompilerGenerated]
		private bool _initiated_k__BackingField; // 0xE8
		private Collider lastCollider; // 0xF0
		private Collider c; // 0xF8
		private float lastTime; // 0x100
	
		// Properties
		public bool inInteraction { get; } // 0x000000018AC2C740-0x000000018AC2C7D0 
		public FullBodyBipedIK ik { get; set; } // 0x0000000184D876B0-0x0000000184D876C0 0x000000018678D7BC-0x000000018678D7D0
		public List<InteractionTrigger> triggersInRange { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8C8C0-0x0000000184D8C8D0 0x0000000184D8C8F0-0x0000000184D8C900
	
		// Nested types
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // TypeDefIndex: 56218; 0x00000001838E1420-0x00000001838E1430
	
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent); // TypeDefIndex: 56219; 0x0000000181546280-0x00000001815462A0
	
		// Constructors
		public InteractionSystem(); // 0x000000018AC2C360-0x000000018AC2C740
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018AC2A858-0x000000018AC2A88C
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018AC2A754-0x000000018AC2A788
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1(); // 0x000000018AC2A788-0x000000018AC2A7BC
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2(); // 0x000000018AC2A7BC-0x000000018AC2A7F0
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3(); // 0x000000018AC2A7F0-0x000000018AC2A824
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4(); // 0x000000018AC2A824-0x000000018AC2A858
		[ContextMenu("Support")]
		private void SupportGroup(); // 0x000000018AC2B428-0x000000018AC2B45C
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018AC28FB4-0x000000018AC28FE8
		public bool IsInInteraction(FullBodyBipedEffector effectorType); // 0x000000018AC29A44-0x000000018AC29AF4
		public bool IsPaused(FullBodyBipedEffector effectorType); // 0x000000018AC29C64-0x000000018AC29D10
		public bool IsPaused(); // 0x000000018AC29BD4-0x000000018AC29C64
		public bool IsInSync(); // 0x000000018AC29AF4-0x000000018AC29BD4
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt); // 0x000000018AC2AC20-0x000000018AC2AD0C
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt); // 0x000000018AC2AB34-0x000000018AC2AC20
		public bool PauseInteraction(FullBodyBipedEffector effectorType); // 0x000000018AC2A8F0-0x000000018AC2A96C
		public bool ResumeInteraction(FullBodyBipedEffector effectorType); // 0x000000018AC2AAB8-0x000000018AC2AB34
		public bool StopInteraction(FullBodyBipedEffector effectorType); // 0x000000018AC2B3AC-0x000000018AC2B428
		public void PauseAll(); // 0x000000018AC2A88C-0x000000018AC2A8F0
		public void ResumeAll(); // 0x000000018AC2AA54-0x000000018AC2AAB8
		public void StopAll(); // 0x000000018AC2B358-0x000000018AC2B3AC
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType); // 0x000000018AC29748-0x000000018AC297C4
		public float GetProgress(FullBodyBipedEffector effectorType); // 0x000000018AC29880-0x000000018AC29900
		public float GetMinActiveProgress(); // 0x000000018AC297C4-0x000000018AC29880
		public bool TriggerInteraction(int index, bool interrupt); // 0x000000018AC2BC44-0x000000018AC2BDD8
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject); // 0x000000018AC2B7E4-0x000000018AC2B9C8
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget); // 0x000000018AC2B9C8-0x000000018AC2BC44
		public InteractionTrigger.Range GetClosestInteractionRange(); // 0x000000018AC292C0-0x000000018AC29398
		public InteractionObject GetClosestInteractionObjectInRange(); // 0x000000018AC29194-0x000000018AC291D4
		public InteractionTarget GetClosestInteractionTargetInRange(); // 0x000000018AC29398-0x000000018AC29408
		public InteractionObject[] GetClosestInteractionObjectsInRange(); // 0x000000018AC291D4-0x000000018AC292C0
		public InteractionTarget[] GetClosestInteractionTargetsInRange(); // 0x000000018AC29408-0x000000018AC29564
		public bool TriggerEffectorsReady(int index); // 0x000000018AC2B45C-0x000000018AC2B6FC
		public InteractionTrigger.Range GetTriggerRange(int index); // 0x000000018AC29900-0x000000018AC29A04
		public int GetClosestTriggerIndex(); // 0x000000018AC29564-0x000000018AC29748
		public void Start(); // 0x000000018AC2AD0C-0x000000018AC2B358
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018AC29A04-0x000000018AC29A24
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018AC29A24-0x000000018AC29A44
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018AC29A24-0x000000018AC29A44
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018AC29DD8-0x000000018AC29E44
		public void OnTriggerEnter(Collider c); // 0x000000018AC2A58C-0x000000018AC2A684
		public void OnTriggerExit(Collider c); // 0x000000018AC2A684-0x000000018AC2A754
		private bool ContactIsInRange(int index, out int bestRangeIndex); // 0x000000018AC28FE8-0x000000018AC29194
		private void OnDrawGizmosSelected(); // 0x000000018AC2A344-0x000000018AC2A424
		public void Update(); // 0x000000018AC2C150-0x000000018AC2C360
		private void Raycasting(); // 0x000000018AC2A96C-0x000000018AC2AA54
		private void UpdateTriggerEventBroadcasting(); // 0x000000018AC2BF04-0x000000018AC2C150
		private void OnEnable(); // 0x000000018AC2A424-0x000000018AC2A444
		private void UpdateEffectors(); // 0x000000018AC2BDD8-0x000000018AC2BF04
		private void OnPreFBBIK(); // 0x000000018AC2A510-0x000000018AC2A58C
		private void OnPostFBBIK(); // 0x000000018AC2A468-0x000000018AC2A510
		private void OnFixTransforms(); // 0x000000018AC2A444-0x000000018AC2A468
		private void OnDestroy(); // 0x000000018AC29E44-0x000000018AC2A344
		private bool IsValid(bool log); // 0x000000018AC29D10-0x000000018AC29DD8
		private bool TriggerIndexIsValid(int index); // 0x000000018AC2B6FC-0x000000018AC2B7E4
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour // TypeDefIndex: 56223
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
		public enum RotationMode // TypeDefIndex: 56221
		{
			TwoDOF = 0,
			ThreeDOF = 1
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 56222
		{
			// Fields
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve; // 0x10
			[Tooltip("Multiplier of the curve\'s value.")]
			public float multiplier; // 0x14
	
			// Constructors
			public Multiplier(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public InteractionTarget(); // 0x000000018AC2D0CC-0x000000018AC2D118
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018AC2C968-0x000000018AC2C99C
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018AC2C864-0x000000018AC2C898
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1(); // 0x000000018AC2C898-0x000000018AC2C8CC
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2(); // 0x000000018AC2C8CC-0x000000018AC2C900
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3(); // 0x000000018AC2C900-0x000000018AC2C934
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4(); // 0x000000018AC2C934-0x000000018AC2C968
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018AC2D098-0x000000018AC2D0CC
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018AC2C7D0-0x000000018AC2C804
		public float GetValue(InteractionObject.WeightCurve.Type curveType); // 0x000000018AC2C804-0x000000018AC2C864
		public void ResetRotation(); // 0x000000018AC2C99C-0x000000018AC2CA18
		public void RotateTo(Transform bone); // 0x000000018AC2CA18-0x000000018AC2D098
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour // TypeDefIndex: 56228
	{
		// Fields
		[Tooltip("The valid ranges of the character\'s and/or its camera\'s position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges; // 0x18
	
		// Nested types
		[Serializable]
		public class CharacterPosition // TypeDefIndex: 56224
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
			public Vector3 offset3D { get; } // 0x0000000184DA9960-0x0000000184DA9980 
			public Vector3 direction3D { get; } // 0x000000018AC24A8C-0x000000018AC24B1C 
	
			// Constructors
			public CharacterPosition(); // 0x0000000184DA9950-0x0000000184DA9960
	
			// Methods
			public bool IsInRange(Transform character, Transform trigger, out float error); // 0x000000018AC24444-0x000000018AC24A8C
		}
	
		[Serializable]
		public class CameraPosition // TypeDefIndex: 56225
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
			public CameraPosition(); // 0x000000018AC243EC-0x000000018AC24444
	
			// Methods
			public Quaternion GetRotation(); // 0x000000018AC23FF0-0x000000018AC24150
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error); // 0x000000018AC24150-0x000000018AC243EC
		}
	
		[Serializable]
		public class Range // TypeDefIndex: 56227
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
			public class Interaction // TypeDefIndex: 56226
			{
				// Fields
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject; // 0x10
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors; // 0x18
	
				// Constructors
				public Interaction(); // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Constructors
			public Range(); // 0x0000000184D8EB60-0x0000000184D8EB70
	
			// Methods
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError); // 0x000000018AC2FB40-0x000000018AC2FC30
		}
	
		// Constructors
		public InteractionTrigger(); // 0x000000018AC2D3CC-0x000000018AC2D41C
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018AC2D364-0x000000018AC2D398
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018AC2D2FC-0x000000018AC2D330
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4(); // 0x000000018AC2D330-0x000000018AC2D364
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018AC2D398-0x000000018AC2D3CC
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018AC2D118-0x000000018AC2D14C
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit); // 0x000000018AC2D14C-0x000000018AC2D2FC
	}

	public class GenericPoser : Poser // TypeDefIndex: 56230
	{
		// Fields
		public Map[] maps; // 0x50
	
		// Nested types
		[Serializable]
		public class Map // TypeDefIndex: 56229
		{
			// Fields
			public Transform bone; // 0x10
			public Transform target; // 0x18
			private Vector3 defaultLocalPosition; // 0x20
			private Quaternion defaultLocalRotation; // 0x2C
	
			// Constructors
			public Map(Transform bone, Transform target); // 0x000000018AC2E2AC-0x000000018AC2E2E0
	
			// Methods
			public void StoreDefaultState(); // 0x000000018ABED324-0x000000018ABED380
			public void FixTransform(); // 0x000000018AC2E0F0-0x000000018AC2E150
			public void Update(float localRotationWeight, float localPositionWeight); // 0x000000018AC2E150-0x000000018AC2E2AC
		}
	
		// Constructors
		public GenericPoser(); // 0x000000018AC25E0C-0x000000018AC25E24
	
		// Methods
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping(); // 0x000000018AC259D8-0x000000018AC25C08
		protected override void InitiatePoser(); // 0x000000018AC25CD8-0x000000018AC25CE0
		protected override void UpdatePoser(); // 0x000000018AC25D34-0x000000018AC25E0C
		protected override void FixPoserTransforms(); // 0x000000018AC25C08-0x000000018AC25C5C
		private void StoreDefaultState(); // 0x000000018AC25CE0-0x000000018AC25D34
		private Transform GetTargetNamed(string tName, Transform[] array); // 0x000000018AC25C5C-0x000000018AC25CD8
	}

	public class HandPoser : Poser // TypeDefIndex: 56231
	{
		// Fields
		protected Transform[] children; // 0x50
		private Transform _poseRoot; // 0x58
		private Transform[] poseChildren; // 0x60
		private Vector3[] defaultLocalPositions; // 0x68
		private Quaternion[] defaultLocalRotations; // 0x70
	
		// Constructors
		public HandPoser(); // 0x000000018AC25E0C-0x000000018AC25E24
	
		// Methods
		public override void AutoMapping(); // 0x000000018AC25E24-0x000000018AC25EDC
		protected override void InitiatePoser(); // 0x000000018AC25FD0-0x000000018AC26020
		protected override void FixPoserTransforms(); // 0x000000018AC25EDC-0x000000018AC25FD0
		protected override void UpdatePoser(); // 0x000000018AC26184-0x000000018AC264D4
		protected void StoreDefaultState(); // 0x000000018AC26020-0x000000018AC26184
	}

	public abstract class Poser : SolverManager // TypeDefIndex: 56232
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
		protected Poser(); // 0x000000018AC25E0C-0x000000018AC25E24
	
		// Methods
		public abstract void AutoMapping();
		public void UpdateManual(); // 0x00000001873629EC-0x00000001873629FC
		protected abstract void InitiatePoser();
		protected abstract void UpdatePoser();
		protected abstract void FixPoserTransforms();
		protected override void UpdateSolver(); // 0x000000018AC2E81C-0x000000018AC2E858
		protected override void InitiateSolver(); // 0x000000018AC2E7F4-0x000000018AC2E81C
		protected override void FixTransforms(); // 0x000000018AC2E7E0-0x000000018AC2E7F4
	}

	public class RagdollUtility : MonoBehaviour // TypeDefIndex: 56236
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
		private bool isRagdoll { get; } // 0x000000018AC2FAE0-0x000000018AC2FB40 
		private bool ikUsed { get; } // 0x000000018AC2F9E4-0x000000018AC2FAE0 
	
		// Nested types
		public class Rigidbone // TypeDefIndex: 56233
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
			public Rigidbone(Rigidbody r); // 0x000000018AC30384-0x000000018AC304F8
	
			// Methods
			public void RecordVelocity(); // 0x000000018AC30010-0x000000018AC3012C
			public void WakeUp(float velocityWeight, float angularVelocityWeight); // 0x000000018AC3012C-0x000000018AC30384
		}
	
		public class Child // TypeDefIndex: 56234
		{
			// Fields
			public Transform t; // 0x10
			public Vector3 localPosition; // 0x18
			public Quaternion localRotation; // 0x24
	
			// Constructors
			public Child(Transform transform); // 0x000000018AC24CD4-0x000000018AC24D3C
	
			// Methods
			public void FixTransform(float weight); // 0x000000018AC24B1C-0x000000018AC24C78
			public void StoreLocalState(); // 0x000000018AC24C78-0x000000018AC24CD4
		}
	
		[CompilerGenerated]
		private sealed class _DisableRagdollSmooth_d__21 : IEnumerator<object> // TypeDefIndex: 56235
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public RagdollUtility __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DisableRagdollSmooth_d__21(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AC334D8-0x000000018AC336A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AC336A0-0x000000018AC336EC
		}
	
		// Constructors
		public RagdollUtility(); // 0x000000018AC2F8F0-0x000000018AC2F9E4
	
		// Methods
		public void EnableRagdoll(); // 0x000000018AC2EDD8-0x000000018AC2EE00
		public void DisableRagdoll(); // 0x000000018AC2ED90-0x000000018AC2EDD8
		public void Start(); // 0x000000018AC2F2AC-0x000000018AC2F6B4
		[IteratorStateMachine(typeof(_DisableRagdollSmooth_d__21))]
		private IEnumerator DisableRagdollSmooth(); // 0x000000018AC2ED34-0x000000018AC2ED90
		private void Update(); // 0x000000018AC2F700-0x000000018AC2F8F0
		private void FixedUpdate(); // 0x000000018AC2EE5C-0x000000018AC2EE94
		private void LateUpdate(); // 0x000000018AC2EE94-0x000000018AC2EF00
		private void AfterLastIK(); // 0x000000018AC2ED08-0x000000018AC2ED34
		private void AfterAnimation(); // 0x000000018AC2ECD0-0x000000018AC2ED08
		private void OnFinalPose(); // 0x000000018AC2F02C-0x000000018AC2F068
		private void RagdollEnabler(); // 0x000000018AC2F068-0x000000018AC2F260
		private void RecordVelocities(); // 0x000000018AC2F260-0x000000018AC2F2AC
		private void StoreLocalState(); // 0x000000018AC2F6B4-0x000000018AC2F700
		private void FixTransforms(float weight); // 0x000000018AC2EE00-0x000000018AC2EE5C
		private void OnDestroy(); // 0x000000018AC2EF00-0x000000018AC2F02C
	}

	public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 56237
	{
		// Fields
		public Vector3 axis; // 0x18
		[HideInInspector]
		public Quaternion defaultLocalRotation; // 0x24
		[CompilerGenerated]
		private bool _defaultLocalRotationOverride_k__BackingField; // 0x34
		private bool initiated; // 0x35
		private bool applicationQuit; // 0x36
		private bool defaultLocalRotationSet; // 0x37
	
		// Properties
		public Vector3 secondaryAxis { get; } // 0x0000000184DA9A00-0x0000000184DA9A20 
		public Vector3 crossAxis { get; } // 0x000000018AC32EC0-0x000000018AC32F30 
		public bool defaultLocalRotationOverride { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86A90-0x0000000184D86AA0 0x0000000184D86AA0-0x0000000184D86AB0
	
		// Constructors
		protected RotationLimit(); // 0x000000018AC32E90-0x000000018AC32EC0
	
		// Methods
		public void SetDefaultLocalRotation(); // 0x000000018AC32E50-0x000000018AC32E90
		public void SetDefaultLocalRotation(Quaternion localRotation); // 0x0000000184DA99F0-0x0000000184DA9A00
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed); // 0x000000018AC32A34-0x000000018AC32B58
		public bool Apply(); // 0x000000018AC328A8-0x000000018AC32944
		public void Disable(); // 0x000000018AC32A0C-0x000000018AC32A34
		protected abstract Quaternion LimitRotation(Quaternion rotation);
		private void Awake(); // 0x000000018AC32944-0x000000018AC32A0C
		private void LateUpdate(); // 0x000000018AC32BD0-0x000000018AC32BD8
		public void LogWarning(string message); // 0x000000018ABD818C-0x000000018ABD81B4
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis); // 0x000000018AC32BD8-0x000000018AC32C88
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit); // 0x000000018AC32C88-0x000000018AC32E50
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal); // 0x000000018AC32B58-0x000000018AC32BD0
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitAngle : RotationLimit // TypeDefIndex: 56238
	{
		// Fields
		[Range(0f, 180f)]
		public float limit; // 0x38
		[Range(0f, 180f)]
		public float twistLimit; // 0x3C
	
		// Constructors
		public RotationLimitAngle(); // 0x000000018AC30894-0x000000018AC308AC
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018AC3082C-0x000000018AC30860
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018AC307F8-0x000000018AC3082C
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018AC30860-0x000000018AC30894
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018AC304F8-0x000000018AC3052C
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018AC3052C-0x000000018AC305F0
		private Quaternion LimitSwing(Quaternion rotation); // 0x000000018AC305F0-0x000000018AC307F8
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitHinge : RotationLimit // TypeDefIndex: 56239
	{
		// Fields
		public bool useLimits; // 0x38
		public float min; // 0x3C
		public float max; // 0x40
		[HideInInspector]
		public float zeroAxisDisplayOffset; // 0x44
		private float lastAngle; // 0x48
	
		// Constructors
		public RotationLimitHinge(); // 0x000000018AC30BDC-0x000000018AC30BF8
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018AC30B74-0x000000018AC30BA8
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018AC30B40-0x000000018AC30B74
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018AC30BA8-0x000000018AC30BDC
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018AC308AC-0x000000018AC308E0
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018AC30B0C-0x000000018AC30B40
		private Quaternion LimitHinge(Quaternion rotation); // 0x000000018AC308E0-0x000000018AC30B0C
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 56242
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
		public class ReachCone // TypeDefIndex: 56240
		{
			// Fields
			public Vector3[] tetrahedron; // 0x10
			public float volume; // 0x18
			public Vector3 S; // 0x1C
			public Vector3 B; // 0x28
	
			// Properties
			public Vector3 o { get; } // 0x000000018AC2FFE4-0x000000018AC30010 
			public Vector3 a { get; } // 0x000000018AC2FF44-0x000000018AC2FF74 
			public Vector3 b { get; } // 0x000000018AC2FF74-0x000000018AC2FFA4 
			public Vector3 c { get; } // 0x000000018AC2FFA4-0x000000018AC2FFD4 
			public bool isValid { get; } // 0x000000018AC2FFD4-0x000000018AC2FFE4 
	
			// Constructors
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c); // 0x000000018AC2FDE8-0x000000018AC2FF44
	
			// Methods
			public void Calculate(); // 0x000000018AC2FC30-0x000000018AC2FDE8
		}
	
		[Serializable]
		public class LimitPoint // TypeDefIndex: 56241
		{
			// Fields
			public Vector3 point; // 0x10
			public float tangentWeight; // 0x1C
	
			// Constructors
			public LimitPoint(); // 0x000000018AC2D41C-0x000000018AC2D440
		}
	
		// Constructors
		public RotationLimitPolygonal(); // 0x000000018AC323D0-0x000000018AC32428
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018AC31560-0x000000018AC31594
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018AC3152C-0x000000018AC31560
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018AC32230-0x000000018AC32264
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018AC30BF8-0x000000018AC30C2C
		public void SetLimitPoints(LimitPoint[] points); // 0x000000018AC31A7C-0x000000018AC31AF0
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018AC31190-0x000000018AC3127C
		private void Start(); // 0x000000018AC32058-0x000000018AC32230
		public void ResetToDefault(); // 0x000000018AC31698-0x000000018AC31A7C
		public void BuildReachCones(); // 0x000000018AC30C2C-0x000000018AC30FF8
		private Vector3[] SmoothPoints(); // 0x000000018AC31AF0-0x000000018AC32058
		private float GetScalar(int k); // 0x000000018AC31140-0x000000018AC31190
		private Vector3 PointToTangentPlane(Vector3 p, float r); // 0x000000018AC31594-0x000000018AC31698
		private Vector3 TangentPointToSphere(Vector3 q, float r); // 0x000000018AC32264-0x000000018AC323D0
		private Quaternion LimitSwing(Quaternion rotation); // 0x000000018AC3127C-0x000000018AC3152C
		private int GetReachCone(Vector3 L); // 0x000000018AC30FF8-0x000000018AC31140
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitSpline : RotationLimit // TypeDefIndex: 56243
	{
		// Fields
		[Range(0f, 180f)]
		public float twistLimit; // 0x38
		[HideInInspector]
		public AnimationCurve spline; // 0x40
	
		// Constructors
		public RotationLimitSpline(); // 0x000000018AC32898-0x000000018AC328A8
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018AC32810-0x000000018AC32844
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018AC327DC-0x000000018AC32810
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018AC32864-0x000000018AC32898
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018AC32428-0x000000018AC3245C
		public void SetSpline(Keyframe[] keyframes); // 0x000000018AC32844-0x000000018AC32864
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018AC3245C-0x000000018AC32520
		public Quaternion LimitSwing(Quaternion rotation); // 0x000000018AC32520-0x000000018AC327DC
	}

	public class AimController : MonoBehaviour // TypeDefIndex: 56245
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
		private Vector3 pivot { get; } // 0x000000018AC22840-0x000000018AC22948 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _TurnToTarget_d__37 : IEnumerator<object> // TypeDefIndex: 56244
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public AimController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _TurnToTarget_d__37(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AC336EC-0x000000018AC337A0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AC337A0-0x000000018AC337EC
		}
	
		// Constructors
		public AimController(); // 0x000000018AC227B0-0x000000018AC22840
	
		// Methods
		private void Start(); // 0x000000018AC22664-0x000000018AC22754
		private void LateUpdate(); // 0x000000018AC21A10-0x000000018AC223A0
		private void ApplyMinDistance(); // 0x000000018AC218D8-0x000000018AC21A10
		private void RootRotation(); // 0x000000018AC223A0-0x000000018AC22664
		[IteratorStateMachine(typeof(_TurnToTarget_d__37))]
		private IEnumerator TurnToTarget(); // 0x000000018AC22754-0x000000018AC227B0
	}

	public class AimPoser : MonoBehaviour // TypeDefIndex: 56247
	{
		// Fields
		public float angleBuffer; // 0x18
		public Pose[] poses; // 0x20
	
		// Nested types
		[Serializable]
		public class Pose // TypeDefIndex: 56246
		{
			// Fields
			public bool visualize; // 0x10
			public string name; // 0x18
			public Vector3 direction; // 0x20
			public float yaw; // 0x2C
			public float pitch; // 0x30
			private float angleBuffer; // 0x34
	
			// Constructors
			public Pose(); // 0x0000000184DA99C0-0x0000000184DA99E0
	
			// Methods
			public bool IsInDirection(Vector3 d); // 0x000000018AC2E5BC-0x000000018AC2E7E0
			public void SetAngleBuffer(float value); // 0x0000000184D8E060-0x0000000184D8E070
		}
	
		// Constructors
		public AimPoser(); // 0x000000018AC22A70-0x000000018AC22AC8
	
		// Methods
		public Pose GetPose(Vector3 localDirection); // 0x000000018AC22948-0x000000018AC22A10
		public void SetPoseActive(Pose pose); // 0x000000018AC22A10-0x000000018AC22A70
	}

	public class Amplifier : OffsetModifier // TypeDefIndex: 56250
	{
		// Fields
		[Tooltip("The amplified bodies.")]
		public Body[] bodies; // 0x30
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 56249
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
			public class EffectorLink // TypeDefIndex: 56248
			{
				// Fields
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Weight of using this effector")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Constructors
			public Body(); // 0x0000000184DA9920-0x0000000184DA9940
	
			// Methods
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime); // 0x000000018AC23578-0x000000018AC239B8
			private static Vector3 Multiply(Vector3 v1, Vector3 v2); // 0x0000000184DA98C0-0x0000000184DA9900
		}
	
		// Constructors
		public Amplifier(); // 0x000000018AC22BE4-0x000000018AC22BEC
	
		// Methods
		protected override void OnModifyOffset(); // 0x000000018AC22AC8-0x000000018AC22BE4
	}

	public class BodyTilt : OffsetModifier // TypeDefIndex: 56251
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
		public BodyTilt(); // 0x000000018AC2302C-0x000000018AC23044
	
		// Methods
		protected override void Start(); // 0x000000018AC22FE0-0x000000018AC2302C
		protected override void OnModifyOffset(); // 0x000000018AC22E04-0x000000018AC22FE0
	}

	public class CCDBendGoal : MonoBehaviour // TypeDefIndex: 56252
	{
		// Fields
		public CCDIK ik; // 0x18
		[Range(0f, 1f)]
		public float weight; // 0x20
	
		// Constructors
		public CCDBendGoal(); // 0x000000018539808C-0x00000001853980A8
	
		// Methods
		private void Start(); // 0x000000018AC23EFC-0x000000018AC23FF0
		private void BeforeIK(); // 0x000000018AC23AEC-0x000000018AC23DD4
		private void OnDestroy(); // 0x000000018AC23DD4-0x000000018AC23EFC
	}

	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour // TypeDefIndex: 56253
	{
		// Fields
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator; // 0x18
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose; // 0x20
		[HideInInspector]
		public Transform[] bones; // 0x28
		[CompilerGenerated]
		private IK _ik_k__BackingField; // 0x30
	
		// Properties
		public IK ik { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	
		// Constructors
		public EditorIK(); // 0x000000018AC2589C-0x000000018AC258EC
	
		// Methods
		private void OnEnable(); // 0x000000018AC2544C-0x000000018AC25594
		private void OnDisable(); // 0x000000018AC25380-0x000000018AC2544C
		private void OnDestroy(); // 0x000000018AC25248-0x000000018AC25380
		public void StoreDefaultPose(); // 0x000000018AC25594-0x000000018AC2560C
		public bool Initiate(); // 0x000000018AC25078-0x000000018AC25248
		public void Update(); // 0x000000018AC2560C-0x000000018AC2589C
	}

	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject // TypeDefIndex: 56254
	{
		// Fields
		public Vector3[] localPositions; // 0x18
		public Quaternion[] localRotations; // 0x20
	
		// Properties
		public bool poseStored { get; } // 0x000000018AC25058-0x000000018AC25078 
	
		// Constructors
		public EditorIKPose(); // 0x000000018AC24FE0-0x000000018AC25058
	
		// Methods
		public void Store(Transform[] T); // 0x000000018AC24E94-0x000000018AC24FE0
		public bool Restore(Transform[] T); // 0x000000018AC24D3C-0x000000018AC24E94
	}

	public class HitReaction : OffsetModifier // TypeDefIndex: 56260
	{
		// Fields
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints; // 0x30
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints; // 0x38
	
		// Properties
		public bool inProgress { get; } // 0x000000018AC2721C-0x000000018AC2729C 
	
		// Nested types
		[Serializable]
		public abstract class HitPoint // TypeDefIndex: 56255
		{
			// Fields
			[Tooltip("Just for visual clarity, not used at all")]
			public string name; // 0x10
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider; // 0x18
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime; // 0x20
			[CompilerGenerated]
			private float _crossFader_k__BackingField; // 0x24
			[CompilerGenerated]
			private float _timer_k__BackingField; // 0x28
			[CompilerGenerated]
			private Vector3 _force_k__BackingField; // 0x2C
			private float length; // 0x38
			private float crossFadeSpeed; // 0x3C
			private float lastTime; // 0x40
	
			// Properties
			public bool inProgress { get; } // 0x000000018AC26CF8-0x000000018AC26D08 
			protected float crossFader { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D89850-0x0000000184D89860 0x0000000184D89860-0x0000000184D89870
			protected float timer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
			protected Vector3 force { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D90540-0x0000000184D90560 0x0000000184D90510-0x0000000184D90520
	
			// Constructors
			protected HitPoint(); // 0x0000000184DA99A0-0x0000000184DA99B0
	
			// Methods
			public virtual void Hit(Vector3 force, Vector3 point); // 0x000000018AC26C1C-0x000000018AC26CF8
			public void Apply(IKSolverFullBodyBiped solver, float weight); // 0x000000018AC26B54-0x000000018AC26C1C
			protected abstract float GetLength();
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);
		}
	
		[Serializable]
		public class HitPointEffector : HitPoint // TypeDefIndex: 56257
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
			public class EffectorLink // TypeDefIndex: 56256
			{
				// Fields
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public EffectorLink(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader); // 0x000000018AC258EC-0x000000018AC259D8
				public void CrossFadeStart(); // 0x0000000184DA9980-0x0000000184DA99A0
			}
	
			// Constructors
			public HitPointEffector(); // 0x0000000184DA99A0-0x0000000184DA99B0
	
			// Methods
			protected override float GetLength(); // 0x000000018AC26874-0x000000018AC2697C
			protected override void CrossFadeStart(); // 0x000000018AC26828-0x000000018AC26874
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight); // 0x000000018AC2697C-0x000000018AC26B54
		}
	
		[Serializable]
		public class HitPointBone : HitPoint // TypeDefIndex: 56259
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
			public class BoneLink // TypeDefIndex: 56258
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
				public BoneLink(); // 0x000000018AC23ABC-0x000000018AC23AEC
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader); // 0x000000018AC239B8-0x000000018AC23ABC
				public void CrossFadeStart(); // 0x0000000184DA9940-0x0000000184DA9950
			}
	
			// Constructors
			public HitPointBone(); // 0x0000000184DA99A0-0x0000000184DA99B0
	
			// Methods
			public override void Hit(Vector3 force, Vector3 point); // 0x000000018AC26594-0x000000018AC26754
			protected override float GetLength(); // 0x000000018AC26518-0x000000018AC26594
			protected override void CrossFadeStart(); // 0x000000018AC264D4-0x000000018AC26518
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight); // 0x000000018AC26754-0x000000018AC26828
		}
	
		// Constructors
		public HitReaction(); // 0x000000018AC22BE4-0x000000018AC22BEC
	
		// Methods
		protected override void OnModifyOffset(); // 0x000000018AC27174-0x000000018AC2721C
		public void Hit(Collider collider, Vector3 force, Vector3 point); // 0x000000018AC26F94-0x000000018AC27174
	}

	public class HitReactionVRIK : OffsetModifierVRIK // TypeDefIndex: 56266
	{
		// Fields
		public AnimationCurve[] offsetCurves; // 0x30
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets; // 0x38
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets; // 0x40
	
		// Nested types
		[Serializable]
		public abstract class Offset // TypeDefIndex: 56261
		{
			// Fields
			[Tooltip("Just for visual clarity, not used at all")]
			public string name; // 0x10
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider; // 0x18
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime; // 0x20
			[CompilerGenerated]
			private float _crossFader_k__BackingField; // 0x24
			[CompilerGenerated]
			private float _timer_k__BackingField; // 0x28
			[CompilerGenerated]
			private Vector3 _force_k__BackingField; // 0x2C
			private float length; // 0x38
			private float crossFadeSpeed; // 0x3C
			private float lastTime; // 0x40
	
			// Properties
			protected float crossFader { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D89850-0x0000000184D89860 0x0000000184D89860-0x0000000184D89870
			protected float timer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
			protected Vector3 force { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D90540-0x0000000184D90560 0x0000000184D90510-0x0000000184D90520
	
			// Constructors
			protected Offset(); // 0x0000000184DA99A0-0x0000000184DA99B0
	
			// Methods
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point); // 0x000000018AC2E4C0-0x000000018AC2E5BC
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight); // 0x000000018AC2E3E8-0x000000018AC2E4C0
			protected abstract float GetLength(AnimationCurve[] curves);
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);
		}
	
		[Serializable]
		public class PositionOffset : Offset // TypeDefIndex: 56263
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
			public class PositionOffsetLink // TypeDefIndex: 56262
			{
				// Fields
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset; // 0x10
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public PositionOffsetLink(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				public void Apply(VRIK ik, Vector3 offset, float crossFader); // 0x000000018AC2E858-0x000000018AC2E908
				public void CrossFadeStart(); // 0x0000000184DA9980-0x0000000184DA99A0
			}
	
			// Constructors
			public PositionOffset(); // 0x0000000184DA99E0-0x0000000184DA99F0
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves); // 0x000000018AC2E954-0x000000018AC2EAC8
			protected override void CrossFadeStart(); // 0x000000018AC2E908-0x000000018AC2E954
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight); // 0x000000018AC2EAC8-0x000000018AC2ECD0
		}
	
		[Serializable]
		public class RotationOffset : Offset // TypeDefIndex: 56265
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
			public class RotationOffsetLink // TypeDefIndex: 56264
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
				public RotationOffsetLink(); // 0x000000018AC3300C-0x000000018AC3303C
	
				// Methods
				public void Apply(VRIK ik, Quaternion offset, float crossFader); // 0x000000018AC32F30-0x000000018AC3300C
				public void CrossFadeStart(); // 0x0000000184DA9A20-0x0000000184DA9A30
			}
	
			// Constructors
			public RotationOffset(); // 0x0000000184DA99A0-0x0000000184DA99B0
	
			// Methods
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point); // 0x000000018AC33138-0x000000018AC33300
			protected override float GetLength(AnimationCurve[] curves); // 0x000000018AC33080-0x000000018AC33138
			protected override void CrossFadeStart(); // 0x000000018AC3303C-0x000000018AC33080
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight); // 0x000000018AC33300-0x000000018AC334D8
		}
	
		// Constructors
		public HitReactionVRIK(); // 0x000000018AC22BE4-0x000000018AC22BEC
	
		// Methods
		protected override void OnModifyOffset(); // 0x000000018AC26EF0-0x000000018AC26F94
		public void Hit(Collider collider, Vector3 force, Vector3 point); // 0x000000018AC26D08-0x000000018AC26EF0
	}

	public class Inertia : OffsetModifier // TypeDefIndex: 56269
	{
		// Fields
		[Tooltip("The array of Bodies")]
		public Body[] bodies; // 0x30
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits; // 0x38
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 56268
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
			public class EffectorLink // TypeDefIndex: 56267
			{
				// Fields
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Weight of using this effector")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Constructors
			public Body(); // 0x0000000184DA9900-0x0000000184DA9920
	
			// Methods
			public void Reset(); // 0x000000018AC23044-0x000000018AC23104
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime); // 0x000000018AC23104-0x000000018AC23578
		}
	
		// Constructors
		public Inertia(); // 0x000000018AC22BE4-0x000000018AC22BEC
	
		// Methods
		public void ResetBodies(); // 0x000000018AC2734C-0x000000018AC273A8
		protected override void OnModifyOffset(); // 0x000000018AC2729C-0x000000018AC2734C
	}

	public class LookAtController : MonoBehaviour // TypeDefIndex: 56270
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
		private Vector3 pivot { get; } // 0x000000018AC2DFE8-0x000000018AC2E0F0 
	
		// Constructors
		public LookAtController(); // 0x000000018AC2DF84-0x000000018AC2DFE8
	
		// Methods
		private void Start(); // 0x000000018AC2DEBC-0x000000018AC2DF84
		private void LateUpdate(); // 0x000000018AC2D578-0x000000018AC2DC58
		private void ApplyMinDistance(); // 0x000000018AC2D440-0x000000018AC2D578
		private void RootRotation(); // 0x000000018AC2DC58-0x000000018AC2DEBC
	}

	public abstract class OffsetModifier : MonoBehaviour // TypeDefIndex: 56273
	{
		// Fields
		[Tooltip("The master weight")]
		public float weight; // 0x18
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik; // 0x20
		protected float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x000000018AC34514-0x000000018AC34530 
	
		// Nested types
		[Serializable]
		public class OffsetLimits // TypeDefIndex: 56271
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
			public OffsetLimits(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Apply(IKEffector e, Quaternion rootRotation); // 0x000000018AC34040-0x000000018AC34218
			private float SpringAxis(float value, float min, float max); // 0x000000018AC34218-0x000000018AC3424C
			private float Spring(float value, float limit, bool negative); // 0x000000018AC3424C-0x000000018AC342A8
		}
	
		[CompilerGenerated]
		private sealed class _Initiate_d__8 : IEnumerator<object> // TypeDefIndex: 56272
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public OffsetModifier __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Initiate_d__8(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AC36A50-0x000000018AC36BBC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AC36BBC-0x000000018AC36C08
		}
	
		// Constructors
		protected OffsetModifier(); // 0x00000001890D4B8C-0x00000001890D4BA8
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start(); // 0x000000018AC34838-0x000000018AC3485C
		[IteratorStateMachine(typeof(_Initiate_d__8))]
		private IEnumerator Initiate(); // 0x000000018AC345F0-0x000000018AC3464C
		private void ModifyOffset(); // 0x000000018AC3464C-0x000000018AC34710
		protected void ApplyLimits(OffsetLimits[] limits); // 0x000000018AC34530-0x000000018AC345F0
		protected virtual void OnDestroy(); // 0x000000018AC34710-0x000000018AC34838
	}

	public abstract class OffsetModifierVRIK : MonoBehaviour // TypeDefIndex: 56275
	{
		// Fields
		[Tooltip("The master weight")]
		public float weight; // 0x18
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik; // 0x20
		private float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x000000018AC34514-0x000000018AC34530 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Initiate_d__7 : IEnumerator<object> // TypeDefIndex: 56274
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public OffsetModifierVRIK __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Initiate_d__7(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AC36898-0x000000018AC36A04
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AC36A04-0x000000018AC36A50
		}
	
		// Constructors
		protected OffsetModifierVRIK(); // 0x00000001890D4B8C-0x00000001890D4BA8
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start(); // 0x000000018AC344F0-0x000000018AC34514
		[IteratorStateMachine(typeof(_Initiate_d__7))]
		private IEnumerator Initiate(); // 0x000000018AC342A8-0x000000018AC34304
		private void ModifyOffset(); // 0x000000018AC34304-0x000000018AC343C8
		protected virtual void OnDestroy(); // 0x000000018AC343C8-0x000000018AC344F0
	}

	public class OffsetPose : MonoBehaviour // TypeDefIndex: 56277
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x18
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 56276
		{
			// Fields
			public FullBodyBipedEffector effector; // 0x10
			public Vector3 offset; // 0x14
			public Vector3 pin; // 0x20
			public Vector3 pinWeight; // 0x2C
	
			// Constructors
			public EffectorLink(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation); // 0x000000018AC33D78-0x000000018AC34040
		}
	
		// Constructors
		public OffsetPose(); // 0x000000018AC34998-0x000000018AC349E8
	
		// Methods
		public void Apply(IKSolverFullBodyBiped solver, float weight); // 0x000000018AC3485C-0x000000018AC34908
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation); // 0x000000018AC34908-0x000000018AC34998
	}

	public class PenetrationAvoidance : OffsetModifier // TypeDefIndex: 56280
	{
		// Fields
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders; // 0x30
	
		// Nested types
		[Serializable]
		public class Avoider // TypeDefIndex: 56279
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
			public class EffectorLink // TypeDefIndex: 56278
			{
				// Fields
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Constructors
			public Avoider(); // 0x0000000184DA9A30-0x0000000184DA9A40
	
			// Methods
			public void Solve(IKSolverFullBodyBiped solver, float weight); // 0x000000018AC33BB4-0x000000018AC33D78
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver); // 0x000000018AC3380C-0x000000018AC3398C
			private Vector3 Raycast(Vector3 from, Vector3 to); // 0x000000018AC3398C-0x000000018AC33BB4
		}
	
		// Constructors
		public PenetrationAvoidance(); // 0x000000018AC22BE4-0x000000018AC22BEC
	
		// Methods
		protected override void OnModifyOffset(); // 0x000000018AC349E8-0x000000018AC34A54
	}

	public class Recoil : OffsetModifier // TypeDefIndex: 56284
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
		public bool isFinished { get; } // 0x000000018AC35E0C-0x000000018AC35E2C 
		private IKEffector primaryHandEffector { get; } // 0x000000018AC35E2C-0x000000018AC35E74 
		private IKEffector secondaryHandEffector { get; } // 0x000000018AC35E94-0x000000018AC35EDC 
		private Transform primaryHand { get; } // 0x000000018AC35E74-0x000000018AC35E94 
		private Transform secondaryHand { get; } // 0x000000018AC35EDC-0x000000018AC35EFC 
	
		// Nested types
		[Serializable]
		public class RecoilOffset // TypeDefIndex: 56282
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
			public class EffectorLink // TypeDefIndex: 56281
			{
				// Fields
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Weight of using this effector")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x00000001841E1670-0x00000001841E1680
			}
	
			// Constructors
			public RecoilOffset(); // 0x0000000184DA9A40-0x0000000184DA9A50
	
			// Methods
			public void Start(); // 0x000000018AC34C68-0x000000018AC34CDC
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft); // 0x000000018AC34A54-0x000000018AC34C68
		}
	
		[Serializable]
		public enum Handedness // TypeDefIndex: 56283
		{
			Right = 0,
			Left = 1
		}
	
		// Constructors
		public Recoil(); // 0x000000018AC35DA0-0x000000018AC35E0C
	
		// Methods
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation); // 0x000000018AC35D80-0x000000018AC35DA0
		public void Fire(float magnitude); // 0x000000018AC34ED4-0x000000018AC35020
		protected override void OnModifyOffset(); // 0x000000018AC35234-0x000000018AC35D80
		private void AfterFBBIK(); // 0x000000018AC34D8C-0x000000018AC34ED4
		private void AfterAimIK(); // 0x000000018AC34CDC-0x000000018AC34D8C
		protected override void OnDestroy(); // 0x000000018AC35020-0x000000018AC35234
	}

	public class ShoulderRotator : MonoBehaviour // TypeDefIndex: 56285
	{
		// Fields
		[Tooltip("Weight of shoulder rotation")]
		public float weight; // 0x18
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset; // 0x1C
		private FullBodyBipedIK ik; // 0x20
		private bool skip; // 0x28
	
		// Constructors
		public ShoulderRotator(); // 0x000000018AC36770-0x000000018AC36794
	
		// Methods
		private void Start(); // 0x000000018AC36654-0x000000018AC36770
		private void RotateShoulders(); // 0x000000018AC3657C-0x000000018AC36654
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset); // 0x000000018AC36128-0x000000018AC3657C
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain); // 0x000000018AC35FC4-0x000000018AC36000
		private void OnDestroy(); // 0x000000018AC36000-0x000000018AC36128
	}

	public static class VRIKCalibrator // TypeDefIndex: 56289
	{
		// Nested types
		[Serializable]
		public class Settings // TypeDefIndex: 56286
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
			public Settings(); // 0x000000018AC35EFC-0x000000018AC35FC4
		}
	
		[Serializable]
		public class CalibrationData // TypeDefIndex: 56288
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
			public class Target // TypeDefIndex: 56287
			{
				// Fields
				public bool used; // 0x10
				public Vector3 localPosition; // 0x14
				public Quaternion localRotation; // 0x20
	
				// Constructors
				public Target(Transform t); // 0x000000018AC367FC-0x000000018AC36898
	
				// Methods
				public void SetTo(Transform t); // 0x000000018AC36794-0x000000018AC367FC
			}
	
			// Constructors
			public CalibrationData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Methods
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings); // 0x000000018AC3B260-0x000000018AC3B284
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp); // 0x000000018AC3B200-0x000000018AC3B260
		private static void CalibrateScale(VRIK ik, Settings settings); // 0x000000018AC38530-0x000000018AC38550
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f /* Metadata: 0x0234796B */); // 0x000000018AC38550-0x000000018AC386DC
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null); // 0x000000018AC39254-0x000000018AC3AA44
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft); // 0x000000018AC37DF0-0x000000018AC38530
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null); // 0x000000018AC386DC-0x000000018AC39254
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft); // 0x000000018AC37BA0-0x000000018AC37DF0
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f /* Metadata: 0x0234796F */); // 0x000000018AC3AA44-0x000000018AC3AC90
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset); // 0x000000018AC37610-0x000000018AC37BA0
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset); // 0x000000018AC36C08-0x000000018AC36F04
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset); // 0x000000018AC373C0-0x000000018AC37610
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft); // 0x000000018AC36F04-0x000000018AC373C0
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm); // 0x000000018AC3B084-0x000000018AC3B200
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm); // 0x000000018AC3AC90-0x000000018AC3B084
	}

	public class VRIKLODController : MonoBehaviour // TypeDefIndex: 56290
	{
		// Fields
		public Renderer LODRenderer; // 0x18
		public float LODDistance; // 0x20
		public bool allowCulled; // 0x24
		private VRIK ik; // 0x28
	
		// Constructors
		public VRIKLODController(); // 0x000000018AC3B45C-0x000000018AC3B47C
	
		// Methods
		private void Start(); // 0x000000018AC3B3E0-0x000000018AC3B428
		private void Update(); // 0x000000018AC3B428-0x000000018AC3B45C
		private int GetLODLevel(); // 0x000000018AC3B284-0x000000018AC3B3E0
	}

	public class VRIKRootController : MonoBehaviour // TypeDefIndex: 56291
	{
		// Fields
		[CompilerGenerated]
		private Vector3 _pelvisTargetRight_k__BackingField; // 0x18
		private Transform pelvisTarget; // 0x28
		private Transform leftFootTarget; // 0x30
		private Transform rightFootTarget; // 0x38
		private VRIK ik; // 0x40
	
		// Properties
		public Vector3 pelvisTargetRight { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D89870-0x0000000184D89890 0x0000000184D89890-0x0000000184D898A0
	
		// Constructors
		public VRIKRootController(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x000000018AC3B47C-0x000000018AC3B5A8
		public void Calibrate(); // 0x000000018AC3B5A8-0x000000018AC3B7CC
		public void Calibrate(VRIKCalibrator.CalibrationData data); // 0x000000018AC3B7CC-0x000000018AC3B954
		private void OnPreUpdate(); // 0x000000018AC3BA7C-0x000000018AC3BF88
		private void OnDestroy(); // 0x000000018AC3B954-0x000000018AC3BA7C
	}
}
