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

// Image 28: RootMotion.dll - Assembly: RootMotion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 82800-83025

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 83025
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_16 CF97ADEEDB59E05BFD73A2B4C2A8885708C4F4F70C84C64B27120E72AB733B72; // 0x00 // Static value (base64): AQAAAAIAAAADAAAABAAAAA== - Metadata: 0x026417B0

	// Nested types
	private struct __StaticArrayInitTypeSize_16 // TypeDefIndex: 83024
	{
	}
}

namespace RootMotion
{
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour // TypeDefIndex: 82807
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
		public bool isBaking { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DFF0-0x000000018225E000 0x000000018225E000-0x000000018225E010
		public float bakingProgress { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233590-0x00000001872335A0 0x00000001872335A0-0x00000001872335B0
		protected float clipLength { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723B540-0x000000018723B550 0x000000018723B570-0x000000018723B580
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 82801
		{
			AnimationClips = 0,
			AnimationStates = 1,
			PlayableDirector = 2,
			Realtime = 3
		}
	
		public delegate void BakerDelegate(AnimationClip clip, float time); // TypeDefIndex: 82802; 0x00000001859B7730-0x00000001859B7740
	
		[Serializable]
		public class ClipSettings // TypeDefIndex: 82806
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
			public enum BasedUponRotation // TypeDefIndex: 82803
			{
				Original = 0,
				BodyOrientation = 1
			}
	
			[Serializable]
			public enum BasedUponY // TypeDefIndex: 82804
			{
				Original = 0,
				CenterOfMass = 1,
				Feet = 2
			}
	
			[Serializable]
			public enum BasedUponXZ // TypeDefIndex: 82805
			{
				Original = 0,
				CenterOfMass = 1
			}
	
			// Constructors
			public ClipSettings(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		protected Baker(); // 0x000000018CDCC908-0x000000018CDCC9EC
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018CDCC8A0-0x000000018CDCC8D4
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018CDCC86C-0x000000018CDCC8A0
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDCC8D4-0x000000018CDCC908
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDCC838-0x000000018CDCC86C
		protected abstract Transform GetCharacterRoot();
		protected abstract void OnStartBaking();
		protected abstract void OnSetLoopFrame(float time);
		protected abstract void OnSetCurves(ref AnimationClip clip);
		protected abstract void OnSetKeyframes(float time, bool lastFrame);
		public void BakeClip(); // 0x0000000186805BA0-0x0000000186805BB0
		public void StartBaking(); // 0x0000000186805BA0-0x0000000186805BB0
		public void StopBaking(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class GenericBaker : Baker // TypeDefIndex: 82808
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
		public GenericBaker(); // 0x000000018CDD3658-0x000000018CDD36B8
	
		// Methods
		private void Awake(); // 0x000000018CDD307C-0x000000018CDD32B0
		protected override Transform GetCharacterRoot(); // 0x0000000187232C70-0x0000000187232C80
		protected override void OnStartBaking(); // 0x000000018CDD3558-0x000000018CDD3658
		protected override void OnSetLoopFrame(float time); // 0x000000018CDD34E8-0x000000018CDD3558
		protected override void OnSetCurves(ref AnimationClip clip); // 0x000000018CDD3408-0x000000018CDD3478
		protected override void OnSetKeyframes(float time, bool lastFrame); // 0x000000018CDD3478-0x000000018CDD34E8
		private bool IsIgnored(Transform t); // 0x000000018CDD335C-0x000000018CDD3408
		private bool BakePosition(Transform t); // 0x000000018CDD32B0-0x000000018CDD335C
	}

	public class TQ // TypeDefIndex: 82809
	{
		// Fields
		public Vector3 t; // 0x10
		public Quaternion q; // 0x1C
	
		// Constructors
		public TQ(); // 0x0000000186805BA0-0x0000000186805BB0
		public TQ(Vector3 translation, Quaternion rotation); // 0x0000000187257540-0x0000000187257560
	}

	public class AvatarUtility // TypeDefIndex: 82810
	{
		// Constructors
		public AvatarUtility(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal); // 0x000000018CDC8B44-0x000000018CDC8D40
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ); // 0x000000018CDC8584-0x000000018CDC8B44
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal); // 0x000000018CDC8EC0-0x000000018CDC930C
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale); // 0x000000018CDC8D40-0x000000018CDC8E8C
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal); // 0x000000018CDC8E8C-0x000000018CDC8EC0
	}

	public static class BakerUtilities // TypeDefIndex: 82811
	{
		// Methods
		public static void ReduceKeyframes(AnimationCurve curve, float maxError); // 0x000000018CDCC6A8-0x000000018CDCC6E8
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError); // 0x000000018CDCC394-0x000000018CDCC6A8
		public static void SetLoopFrame(float time, AnimationCurve curve); // 0x000000018CDCC6E8-0x000000018CDCC838
		public static void SetTangentMode(AnimationCurve curve); // 0x0000000186805BA0-0x0000000186805BB0
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q); // 0x000000018CDCC1FC-0x000000018CDCC394
	}

	[Serializable]
	public class BakerHumanoidQT // TypeDefIndex: 82812
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
		public BakerHumanoidQT(string name); // 0x000000018CDCA744-0x000000018CDCA8A8
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name); // 0x000000018CDCA8A8-0x000000018CDCAA38
	
		// Methods
		public Quaternion EvaluateRotation(float time); // 0x000000018CDC9A54-0x000000018CDC9B1C
		public Vector3 EvaluatePosition(float time); // 0x000000018CDC99B8-0x000000018CDC9A54
		public TQ Evaluate(float time); // 0x000000018CDC9B1C-0x000000018CDC9BBC
		public void GetCurvesFromClip(AnimationClip clip, Animator animator); // 0x0000000186805BA0-0x0000000186805BB0
		public void Reset(); // 0x000000018CDC9D34-0x000000018CDC9ED4
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation); // 0x000000018CDCA284-0x000000018CDCA5C8
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot); // 0x000000018CDCA5C8-0x000000018CDCA6BC
		public void MoveLastKeyframes(float time); // 0x000000018CDC9C20-0x000000018CDC9CB8
		public void SetLoopFrame(float time); // 0x000000018CDCA6BC-0x000000018CDCA744
		public void SetRootLoopFrame(float time); // 0x0000000186805BA0-0x0000000186805BB0
		private void MoveLastKeyframe(float time, AnimationCurve curve); // 0x000000018CDC9BBC-0x000000018CDC9C20
		public void MultiplyLength(AnimationCurve curve, float mlp); // 0x000000018CDC9CB8-0x000000018CDC9D34
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp); // 0x000000018CDC9ED4-0x000000018CDCA284
	}

	[Serializable]
	public class BakerMuscle // TypeDefIndex: 82813
	{
		// Fields
		public AnimationCurve curve; // 0x10
		private int muscleIndex; // 0x18
		private string propertyName; // 0x20
	
		// Constructors
		public BakerMuscle(int muscleIndex); // 0x000000018CDCB584-0x000000018CDCB5E8
	
		// Methods
		private string MuscleNameToPropertyName(string n); // 0x000000018CDCAA38-0x000000018CDCB3D4
		public void MultiplyLength(AnimationCurve curve, float mlp); // 0x000000018CDC9CB8-0x000000018CDC9D34
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp); // 0x000000018CDCB438-0x000000018CDCB534
		public void Reset(); // 0x000000018CDCB3D4-0x000000018CDCB438
		public void SetKeyframe(float time, float[] muscles); // 0x000000018CDCB534-0x000000018CDCB574
		public void SetLoopFrame(float time); // 0x000000018CDCB574-0x000000018CDCB584
	}

	[Serializable]
	public class BakerTransform // TypeDefIndex: 82814
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
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode); // 0x000000018CDCC174-0x000000018CDCC1FC
	
		// Methods
		public void SetRelativeSpace(Vector3 position, Quaternion rotation); // 0x0000000187256FC0-0x0000000187256FE0
		public void SetCurves(ref AnimationClip clip); // 0x000000018CDCBC80-0x000000018CDCBF68
		private void AddRootMotionCurves(ref AnimationClip clip); // 0x000000018CDCB7C4-0x000000018CDCBA84
		public void Reset(); // 0x000000018CDCBB08-0x000000018CDCBC80
		public void ReduceKeyframes(float maxError); // 0x000000018CDCBA84-0x000000018CDCBB08
		public void SetKeyframes(float time); // 0x000000018CDCBF68-0x000000018CDCC174
		public void AddLoopFrame(float time); // 0x000000018CDCB5E8-0x000000018CDCB7C4
	}

	public class HumanoidBaker : Baker // TypeDefIndex: 82815
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
		public HumanoidBaker(); // 0x000000018CDD4E0C-0x000000018CDD4EA0
	
		// Methods
		private void Awake(); // 0x000000018CDD4014-0x000000018CDD4530
		protected override Transform GetCharacterRoot(); // 0x000000018CDD4530-0x000000018CDD4550
		protected override void OnStartBaking(); // 0x000000018CDD4C2C-0x000000018CDD4D1C
		protected override void OnSetLoopFrame(float time); // 0x000000018CDD4B40-0x000000018CDD4C2C
		protected override void OnSetCurves(ref AnimationClip clip); // 0x000000018CDD4550-0x000000018CDD4778
		protected override void OnSetKeyframes(float time, bool lastFrame); // 0x000000018CDD4778-0x000000018CDD4B40
		private void UpdateHumanPose(); // 0x000000018CDD4D1C-0x000000018CDD4E0C
	}

	[Serializable]
	public enum Axis // TypeDefIndex: 82816
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public class AxisTools // TypeDefIndex: 82817
	{
		// Constructors
		public AxisTools(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static Vector3 ToVector3(RootMotion.Axis axis); // 0x000000018CDC9834-0x000000018CDC9874
		public static RootMotion.Axis ToAxis(Vector3 v); // 0x000000018CDC97F4-0x000000018CDC9834
		public static RootMotion.Axis GetAxisToPoint(Transform t, Vector3 worldPosition); // 0x000000018CDC93F8-0x000000018CDC94E4
		public static RootMotion.Axis GetAxisToDirection(Transform t, Vector3 direction); // 0x000000018CDC930C-0x000000018CDC93F8
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition); // 0x000000018CDC9744-0x000000018CDC97F4
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction); // 0x000000018CDC94E4-0x000000018CDC9550
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction); // 0x000000018CDC9550-0x000000018CDC9744
	}

	[Serializable]
	public class BipedLimbOrientations // TypeDefIndex: 82819
	{
		// Fields
		public LimbOrientation leftArm; // 0x10
		public LimbOrientation rightArm; // 0x18
		public LimbOrientation leftLeg; // 0x20
		public LimbOrientation rightLeg; // 0x28
	
		// Properties
		public static BipedLimbOrientations UMA { get; } // 0x000000018CDCD400-0x000000018CDCD694 
		public static BipedLimbOrientations MaxBiped { get; } // 0x000000018CDCD16C-0x000000018CDCD400 
	
		// Nested types
		[Serializable]
		public class LimbOrientation // TypeDefIndex: 82818
		{
			// Fields
			public Vector3 upperBoneForwardAxis; // 0x10
			public Vector3 lowerBoneForwardAxis; // 0x1C
			public Vector3 lastBoneLeftAxis; // 0x28
	
			// Constructors
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis); // 0x000000018723D660-0x000000018723D6A0
		}
	
		// Constructors
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg); // 0x00000001851E8C40-0x00000001851E8C90
	}

	public static class BipedNaming // TypeDefIndex: 82822
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
		public enum BoneType // TypeDefIndex: 82820
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
		public enum BoneSide // TypeDefIndex: 82821
		{
			Center = 0,
			Left = 1,
			Right = 2
		}
	
		// Constructors
		static BipedNaming(); // 0x000000018CDCDD58-0x000000018CDCEFD0
	
		// Methods
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones); // 0x000000018CDCDA40-0x000000018CDCDBA8
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones); // 0x000000018CDCD870-0x000000018CDCD9D8
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones); // 0x000000018CDCD9D8-0x000000018CDCDA40
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones); // 0x000000018CDCDBA8-0x000000018CDCDC2C
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings); // 0x000000018CDCDC2C-0x000000018CDCDD1C
		public static BoneType GetBoneType(string boneName); // 0x000000018CDCD700-0x000000018CDCD7F8
		public static BoneSide GetBoneSide(string boneName); // 0x000000018CDCD694-0x000000018CDCD700
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center /* Metadata: 0x026416DE */, params string[][] namings); // 0x000000018CDCD7F8-0x000000018CDCD870
		private static bool isLeft(string boneName); // 0x000000018CDCF238-0x000000018CDCF2F8
		private static bool isRight(string boneName); // 0x000000018CDCF380-0x000000018CDCF440
		private static bool isSpine(string boneName); // 0x000000018CDCF440-0x000000018CDCF4C8
		private static bool isHead(string boneName); // 0x000000018CDCF1B0-0x000000018CDCF238
		private static bool isArm(string boneName); // 0x000000018CDCF0A0-0x000000018CDCF128
		private static bool isLeg(string boneName); // 0x000000018CDCF2F8-0x000000018CDCF380
		private static bool isTail(string boneName); // 0x000000018CDCF4C8-0x000000018CDCF550
		private static bool isEye(string boneName); // 0x000000018CDCF128-0x000000018CDCF1B0
		private static bool isTypeExclude(string boneName); // 0x000000018CDCF550-0x000000018CDCF5A4
		private static bool matchesNaming(string boneName, string[] namingConvention); // 0x000000018CDCF6A4-0x000000018CDCF760
		private static bool excludesNaming(string boneName, string[] namingConvention); // 0x000000018CDCEFD0-0x000000018CDCF044
		private static bool matchesLastLetter(string boneName, string[] namingConvention); // 0x000000018CDCF600-0x000000018CDCF6A4
		private static bool LastLetterIs(string boneName, string letter); // 0x000000018CDCDD1C-0x000000018CDCDD58
		private static string firstLetter(string boneName); // 0x000000018CDCF044-0x000000018CDCF0A0
		private static string lastLetter(string boneName); // 0x000000018CDCF5A4-0x000000018CDCF600
	}

	[Serializable]
	public class BipedReferences // TypeDefIndex: 82824
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
		public virtual bool isFilled { get; } // 0x0000000186A0CB20-0x0000000186A0D2D0 
		public bool isEmpty { get; } // 0x000000018CDD18F0-0x000000018CDD18FC 
	
		// Nested types
		public struct AutoDetectParams // TypeDefIndex: 82823
		{
			// Fields
			public bool legsParentInSpine; // 0x00
			public bool includeEyes; // 0x01
	
			// Properties
			public static AutoDetectParams Default { get; } // 0x0000000187256FB0-0x0000000187256FC0 
	
			// Constructors
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes); // 0x00000001844AD090-0x00000001844AD0A0
		}
	
		// Constructors
		public BipedReferences(); // 0x0000000185CD2640-0x0000000185CD26B0
	
		// Methods
		public virtual bool IsEmpty(bool includeRoot); // 0x000000018CDD0FB4-0x000000018CDD12D0
		public virtual bool Contains(Transform t, bool ignoreRoot = false /* Metadata: 0x026416E9 */); // 0x000000018CDD00DC-0x000000018CDD040C
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams); // 0x000000018CDCFED8-0x000000018CDD00DC
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams); // 0x000000018CDD052C-0x000000018CDD0CF0
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams); // 0x000000018CDCFA38-0x000000018CDCFED8
		public static bool SetupError(BipedReferences references, ref string errorMessage); // 0x0000000185A167D0-0x0000000185A168F0
		public static bool SetupWarning(BipedReferences references, ref string warningMessage); // 0x000000018CDD1818-0x000000018CDD18F0
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm); // 0x000000018CDD12D0-0x000000018CDD138C
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams); // 0x000000018CDCF760-0x000000018CDCF83C
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams); // 0x000000018CDCF8F0-0x000000018CDCFA38
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms); // 0x000000018CDD040C-0x000000018CDD052C
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform); // 0x000000018CDCF83C-0x000000018CDCF8F0
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage); // 0x0000000185A15E90-0x0000000185A16390
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage); // 0x000000018CDD138C-0x000000018CDD1620
		private static bool SpineError(BipedReferences references, ref string errorMessage); // 0x0000000185CD5D00-0x0000000185CD60D0
		private static bool SpineWarning(BipedReferences references, ref string warningMessage); // 0x00000001843FFFF0-0x0000000184400000
		private static bool EyesError(BipedReferences references, ref string errorMessage); // 0x0000000186ED7F60-0x0000000186ED8010
		private static bool EyesWarning(BipedReferences references, ref string warningMessage); // 0x00000001843FFFF0-0x0000000184400000
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage); // 0x000000018CDD1620-0x000000018CDD1818
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage); // 0x000000018CDD0CF0-0x000000018CDD0F0C
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation); // 0x000000018CDD0F0C-0x000000018CDD0FB4
	}

	public class Comments : MonoBehaviour // TypeDefIndex: 82825
	{
		// Fields
		[Multiline]
		public string text; // 0x18
	
		// Constructors
		public Comments(); // 0x00000001878364A0-0x00000001878364B8
	}

	public class DemoGUIMessage : MonoBehaviour // TypeDefIndex: 82826
	{
		// Fields
		public string text; // 0x18
		public UnityEngine.Color color; // 0x20
	
		// Constructors
		public DemoGUIMessage(); // 0x000000018CDD1F34-0x000000018CDD1F6C
	
		// Methods
		private void OnGUI(); // 0x000000018CDD1E90-0x000000018CDD1F34
	}

	public class Hierarchy // TypeDefIndex: 82827
	{
		// Constructors
		public Hierarchy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static bool HierarchyIsValid(Transform[] bones); // 0x0000000185CD5840-0x0000000185CD58C0
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects); // 0x0000000185A166C0-0x0000000185A167D0
		public static bool IsAncestor(Transform transform, Transform ancestor); // 0x0000000185CD58C0-0x0000000185CD5AD0
		public static bool ContainsChild(Transform transform, Transform child); // 0x000000018CDD3914-0x000000018CDD39F8
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array); // 0x000000018CDD36B8-0x000000018CDD3914
		public static Transform GetAncestor(Transform transform, int minChildCount); // 0x000000018CDD39F8-0x000000018CDD3ACC
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2); // 0x000000018CDD3C1C-0x000000018CDD3D48
		public static Transform GetFirstCommonAncestor(Transform[] transforms); // 0x000000018CDD3D48-0x000000018CDD3E70
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms); // 0x000000018CDD3ACC-0x000000018CDD3C1C
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms); // 0x000000018CDD3E70-0x000000018CDD4014
	}

	public class InspectorComment : PropertyAttribute // TypeDefIndex: 82828
	{
		// Fields
		public string name; // 0x10
		public string color; // 0x18
	
		// Constructors
		public InspectorComment(string name); // 0x000000018CDD4F14-0x000000018CDD4F80
		public InspectorComment(string name, string color); // 0x000000018CDD4EA0-0x000000018CDD4F14
	}

	[Serializable]
	public enum InterpolationMode // TypeDefIndex: 82829
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

	public class Interp // TypeDefIndex: 82830
	{
		// Constructors
		public Interp(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static float Float(float t, RootMotion.InterpolationMode mode); // 0x000000018CDD4F80-0x000000018CDD52D0
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, RootMotion.InterpolationMode mode); // 0x000000018CDD558C-0x000000018CDD565C
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed); // 0x00000001854AF8C0-0x00000001854AF970
		private static float None(float t, float b, float c); // 0x0000000187257210-0x0000000187257220
		private static float InOutCubic(float t, float b, float c); // 0x0000000187257140-0x0000000187257170
		private static float InOutQuintic(float t, float b, float c); // 0x0000000187257170-0x00000001872571C0
		private static float InQuintic(float t, float b, float c); // 0x00000001872571F0-0x0000000187257210
		private static float InQuartic(float t, float b, float c); // 0x00000001872571D0-0x00000001872571F0
		private static float InCubic(float t, float b, float c); // 0x0000000187257060-0x0000000187257080
		private static float InQuadratic(float t, float b, float c); // 0x00000001872571C0-0x00000001872571D0
		private static float OutQuintic(float t, float b, float c); // 0x00000001872574D0-0x0000000187257540
		private static float OutQuartic(float t, float b, float c); // 0x0000000187257470-0x00000001872574D0
		private static float OutCubic(float t, float b, float c); // 0x00000001872572B0-0x00000001872572F0
		private static float OutInCubic(float t, float b, float c); // 0x00000001872573F0-0x0000000187257430
		private static float OutInQuartic(float t, float b, float c); // 0x0000000187257430-0x0000000187257470
		private static float BackInCubic(float t, float b, float c); // 0x0000000187256FF0-0x0000000187257020
		private static float BackInQuartic(float t, float b, float c); // 0x0000000187257020-0x0000000187257060
		private static float OutBackCubic(float t, float b, float c); // 0x0000000187257220-0x0000000187257260
		private static float OutBackQuartic(float t, float b, float c); // 0x0000000187257260-0x00000001872572B0
		private static float OutElasticSmall(float t, float b, float c); // 0x0000000187257370-0x00000001872573F0
		private static float OutElasticBig(float t, float b, float c); // 0x00000001872572F0-0x0000000187257370
		private static float InElasticSmall(float t, float b, float c); // 0x00000001872570E0-0x0000000187257140
		private static float InElasticBig(float t, float b, float c); // 0x0000000187257080-0x00000001872570E0
		private static float InSine(float t, float b, float c); // 0x000000018CDD5410-0x000000018CDD545C
		private static float OutSine(float t, float b, float c); // 0x000000018CDD5550-0x000000018CDD558C
		private static float InOutSine(float t, float b, float c); // 0x000000018CDD53BC-0x000000018CDD5410
		private static float InElastic(float t, float b, float c); // 0x000000018CDD52F8-0x000000018CDD53BC
		private static float OutElastic(float t, float b, float c); // 0x000000018CDD5498-0x000000018CDD5550
		private static float InBack(float t, float b, float c); // 0x000000018CDD52D0-0x000000018CDD52F8
		private static float OutBack(float t, float b, float c); // 0x000000018CDD545C-0x000000018CDD5498
	}

	public static class LayerMaskExtensions // TypeDefIndex: 82831
	{
		// Methods
		public static bool Contains(LayerMask mask, int layer); // 0x000000018CDD573C-0x000000018CDD574C
		public static LayerMask Create(params string[] layerNames); // 0x000000018CB45C28-0x000000018CB45C30
		public static LayerMask Create(params int[] layerNumbers); // 0x000000018CB45C30-0x000000018CB45C38
		public static LayerMask NamesToMask(params string[] layerNames); // 0x000000018CB45C38-0x000000018CB45CA0
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers); // 0x000000018CB45CA0-0x000000018CB45CE0
	
		// Extension methods
		public static LayerMask Inverse(this LayerMask original); // 0x00000001872544A0-0x00000001872544B0
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames); // 0x000000018CB45B28-0x000000018CB45B48
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames); // 0x000000018CB45E80-0x000000018CB45EA4
		public static string[] MaskToNames(this LayerMask original); // 0x000000018CDD574C-0x000000018CDD5824
		public static int[] MaskToNumbers(this LayerMask original); // 0x000000018CDD5824-0x000000018CDD58E8
		public static string MaskToString(this LayerMask original); // 0x000000018CDD58E8-0x000000018CDD5924
		public static string MaskToString(this LayerMask original, string delimiter); // 0x000000018CDD5924-0x000000018CDD59B0
	}

	public abstract class LazySingleton<T> : MonoBehaviour // TypeDefIndex: 82832
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

	public enum ShowIfMode // TypeDefIndex: 82833
	{
		Disabled = 0,
		Hidden = 1
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowIfAttribute : PropertyAttribute // TypeDefIndex: 82834
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
		public string propName { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public object propValue { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public object otherPropValue { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public bool indent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public ShowIfMode mode { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
	
		// Constructors
		public ShowIfAttribute(string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x02641707 */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x02641708 */); // 0x000000018CDD753C-0x000000018CDD7584
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowRangeIfAttribute : ShowIfAttribute // TypeDefIndex: 82835
	{
		// Fields
		[CompilerGenerated]
		private float _min_k__BackingField; // 0x30
		[CompilerGenerated]
		private float _max_k__BackingField; // 0x34
	
		// Properties
		public float min { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233870-0x0000000187233880 0x0000000187233880-0x0000000187233890
		public float max { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723CEF0-0x000000018723CF00 0x0000000187233AF0-0x0000000187233B00
	
		// Constructors
		public ShowRangeIfAttribute(float min, float max, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x02641709 */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x0264170A */); // 0x000000018CDD76EC-0x000000018CDD7758
	}

	public class ShowLargeHeaderIf : ShowIfAttribute // TypeDefIndex: 82836
	{
		// Fields
		public string name; // 0x30
		public string color; // 0x38
	
		// Constructors
		public ShowLargeHeaderIf(string name, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x0264170B */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x0264170C */); // 0x000000018CDD7638-0x000000018CDD76EC
		public ShowLargeHeaderIf(string name, string color, string propertyName, object propertyValue = null, object otherPropertyValue = null, bool indent = false /* Metadata: 0x0264170D */, ShowIfMode mode = ShowIfMode.Hidden /* Metadata: 0x0264170E */); // 0x000000018CDD7584-0x000000018CDD7638
	}

	public class LargeHeader : PropertyAttribute // TypeDefIndex: 82837
	{
		// Fields
		public string name; // 0x10
		public string color; // 0x18
	
		// Constructors
		public LargeHeader(string name); // 0x000000018CDD56D0-0x000000018CDD573C
		public LargeHeader(string name, string color); // 0x000000018CDD565C-0x000000018CDD56D0
	}

	public static class QuaTools // TypeDefIndex: 82838
	{
		// Methods
		public static float GetYaw(Quaternion space, Vector3 forward); // 0x000000018CDD6E00-0x000000018CDD6E78
		public static float GetPitch(Quaternion space, Vector3 forward); // 0x000000018CDD6D80-0x000000018CDD6E00
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up); // 0x000000018CDD6B1C-0x000000018CDD6CC4
		public static float GetYaw(Quaternion space, Quaternion rotation); // 0x000000018CDD6E78-0x000000018CDD6F3C
		public static float GetPitch(Quaternion space, Quaternion rotation); // 0x000000018CDD6CC4-0x000000018CDD6D80
		public static float GetBank(Quaternion space, Quaternion rotation); // 0x000000018CDD6920-0x000000018CDD6B1C
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight); // 0x000000018CDD6F3C-0x000000018CDD6F9C
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight); // 0x000000018CDD73CC-0x000000018CDD742C
		public static Quaternion LinearBlend(Quaternion q, float weight); // 0x000000018CDD6F9C-0x000000018CDD701C
		public static Quaternion SphericalBlend(Quaternion q, float weight); // 0x000000018CDD742C-0x000000018CDD74AC
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis); // 0x000000018CDD65C4-0x000000018CDD66E4
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation); // 0x0000000185764E10-0x0000000185764EC0
		public static Quaternion FromToRotation(Quaternion from, Quaternion to); // 0x000000018CDD66E4-0x000000018CDD6788
		public static Vector3 GetAxis(Vector3 v); // 0x000000018CDD6788-0x000000018CDD6920
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing); // 0x000000018CDD643C-0x000000018CDD65C4
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing); // 0x000000018CDD6350-0x000000018CDD643C
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2); // 0x000000018CDD701C-0x000000018CDD7144
		public static Vector3 ToBiPolar(Vector3 euler); // 0x000000018CDD74EC-0x000000018CDD753C
		public static float ToBiPolar(float angle); // 0x000000018CDD74AC-0x000000018CDD74EC
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space); // 0x000000018CDD7144-0x000000018CDD72BC
		public static Quaternion MirrorYZ(Quaternion r); // 0x000000018CDD72BC-0x000000018CDD73CC
	}

	public abstract class Singleton<T> : MonoBehaviour // TypeDefIndex: 82839
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

	public class SolverManager : MonoBehaviour // TypeDefIndex: 82840
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
		private bool animatePhysics { get; } // 0x00000001859E68E0-0x00000001859E69B0 
		private bool isAnimated { get; } // 0x0000000185EA51D0-0x0000000185EA5300 
	
		// Constructors
		public SolverManager(); // 0x0000000187836ABC-0x0000000187836AD8
	
		// Methods
		public void Disable(); // 0x000000018CDD7758-0x000000018CDD77D0
		protected virtual void InitiateSolver(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void UpdateSolver(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void FixTransforms(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnDisable(); // 0x0000000185EA5060-0x0000000185EA5090
		private void Start(); // 0x0000000185EA5090-0x0000000185EA50A0
		public void Initiate(); // 0x0000000185EA50A0-0x0000000185EA50E0
		private void Update(); // 0x00000001859E5A80-0x00000001859E6140
		private void FindAnimatorRecursive(Transform t, bool findInChildren); // 0x0000000185EA50E0-0x0000000185EA51D0
		private void FixedUpdate(); // 0x00000001859E6800-0x00000001859E68E0
		private void LateUpdate(); // 0x00000001859E6140-0x00000001859E6800
		public void UpdateSolverExternal(); // 0x000000018CDD77D0-0x000000018CDD7800
	}

	public class TriggerEventBroadcaster : MonoBehaviour // TypeDefIndex: 82841
	{
		// Fields
		public GameObject target; // 0x18
	
		// Constructors
		public TriggerEventBroadcaster(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnTriggerEnter(Collider collider); // 0x000000018CDD7800-0x000000018CDD789C
		private void OnTriggerStay(Collider collider); // 0x000000018CDD7938-0x000000018CDD79D4
		private void OnTriggerExit(Collider collider); // 0x000000018CDD789C-0x000000018CDD7938
	}

	public static class V2Tools // TypeDefIndex: 82842
	{
		// Methods
		public static Vector2 XZ(Vector3 v); // 0x0000000187235940-0x0000000187235960
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2); // 0x000000018CDD7A24-0x000000018CDD7A80
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2); // 0x000000018CDD79D4-0x000000018CDD7A24
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r); // 0x000000018CDD7A80-0x000000018CDD7B98
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r); // 0x000000018CDD7B98-0x000000018CDD7CC0
	}

	public static class V3Tools // TypeDefIndex: 82843
	{
		// Methods
		public static float GetYaw(Vector3 forward); // 0x0000000187257560-0x0000000187257580
		public static float GetPitch(Vector3 forward); // 0x000000018CDD8804-0x000000018CDD8848
		public static float GetBank(Vector3 forward, Vector3 up); // 0x000000018CDD8744-0x000000018CDD8804
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward); // 0x000000018CDD88F4-0x000000018CDD89A4
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward); // 0x000000018CDD8848-0x000000018CDD88F4
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up); // 0x000000018CDD85AC-0x000000018CDD8744
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight); // 0x000000018CDD8B80-0x000000018CDD8BF8
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight); // 0x000000018CDD8DB4-0x000000018CDD8E34
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight); // 0x000000018CDD8388-0x000000018CDD84AC
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight); // 0x000000018CDD8244-0x000000018CDD8388
		public static Vector3 Flatten(Vector3 v, Vector3 normal); // 0x000000018CDD84AC-0x000000018CDD85AC
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing); // 0x000000018CDD8080-0x000000018CDD8244
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed); // 0x000000018CDD7CC0-0x000000018CDD7E90
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue); // 0x000000018CDD7E90-0x000000018CDD8080
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint); // 0x00000001856C0520-0x00000001856C0720
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal); // 0x000000018CDD8BF8-0x000000018CDD8DB4
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point); // 0x000000018CDD8E34-0x000000018CDD8F10
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point); // 0x000000018CDD89A4-0x000000018CDD8A90
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point); // 0x000000018CDD8A90-0x000000018CDD8B80
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point); // 0x000000018CDD8F10-0x000000018CDD8FDC
		public static Vector3 Div(Vector3 v1, Vector3 v2); // 0x000000018CCDFE94-0x000000018CCDFEC8
	}

	public static class Warning // TypeDefIndex: 82845
	{
		// Fields
		public static bool logged; // 0x00
	
		// Nested types
		public delegate void Logger(string message); // TypeDefIndex: 82844; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Methods
		public static void Log(string message, Logger logger, bool logInEditMode = false /* Metadata: 0x0264170F */); // 0x000000018CDD907C-0x000000018CDD9188
		public static void Log(string message, Transform context, bool logInEditMode = false /* Metadata: 0x02641710 */); // 0x000000018CDD8FDC-0x000000018CDD907C
	}
}

namespace RootMotion.Demos
{
	[Serializable]
	public class Navigator // TypeDefIndex: 82847
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
		public Vector3 normalizedDeltaPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723E4F0-0x000000018723E510 0x000000018723E4E0-0x000000018723E4F0
		public State state { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
	
		// Nested types
		public enum State // TypeDefIndex: 82846
		{
			Idle = 0,
			Seeking = 1,
			OnPath = 2
		}
	
		// Constructors
		public Navigator(); // 0x000000018CDD62EC-0x000000018CDD6350
	
		// Methods
		public void Initiate(Transform transform); // 0x000000018CDD5C48-0x000000018CDD5D10
		public void Update(Vector3 targetPosition); // 0x000000018CDD5D2C-0x000000018CDD60EC
		private void CalculatePath(Vector3 targetPosition); // 0x000000018CDD59B0-0x000000018CDD5A38
		private bool Find(Vector3 targetPosition); // 0x000000018CDD5A38-0x000000018CDD5C1C
		private void Stop(); // 0x000000018CDD5D10-0x000000018CDD5D2C
		private float HorDistance(Vector3 p1, Vector3 p2); // 0x000000018CDD5C1C-0x000000018CDD5C48
		public void Visualize(); // 0x000000018CDD60EC-0x000000018CDD62EC
	}
}

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	public class BipedIK : SolverManager // TypeDefIndex: 82848
	{
		// Fields
		public BipedReferences references; // 0x38
		public BipedIKSolvers solvers; // 0x40
	
		// Constructors
		public BipedIK(); // 0x0000000185CD2590-0x0000000185CD2640
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018CDCCD14-0x000000018CDCCD48
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018CDCCCE0-0x000000018CDCCD14
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDCD128-0x000000018CDCD15C
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDCCB44-0x000000018CDCCB78
		public float GetIKPositionWeight(AvatarIKGoal goal); // 0x000000018CDCCBD8-0x000000018CDCCBFC
		public float GetIKRotationWeight(AvatarIKGoal goal); // 0x000000018CDCCC4C-0x000000018CDCCC70
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight); // 0x000000018CDCCD48-0x000000018CDCCD80
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight); // 0x000000018CDCCDB4-0x000000018CDCCDEC
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition); // 0x000000018CDCCD80-0x000000018CDCCDB4
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation); // 0x000000018CDCCDEC-0x000000018CDCCE18
		public Vector3 GetIKPosition(AvatarIKGoal goal); // 0x000000018CDCCBFC-0x000000018CDCCC4C
		public Quaternion GetIKRotation(AvatarIKGoal goal); // 0x000000018CDCCC70-0x000000018CDCCCA8
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes); // 0x000000018CDCCE48-0x000000018CDCCEB8
		public void SetLookAtPosition(Vector3 lookAtPosition); // 0x000000018CDCCE18-0x000000018CDCCE48
		public void SetSpinePosition(Vector3 spinePosition); // 0x000000018CDCCEB8-0x000000018CDCCEE8
		public void SetSpineWeight(float weight); // 0x000000018CDCCEE8-0x000000018CDCCF10
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal); // 0x000000018CDCCB78-0x000000018CDCCBD8
		public void InitiateBipedIK(); // 0x000000018CDCCCA8-0x000000018CDCCCB8
		public void UpdateBipedIK(); // 0x000000018CDCD15C-0x000000018CDCD16C
		public void SetToDefaults(); // 0x000000018CDCCF10-0x000000018CDCD128
		protected override void FixTransforms(); // 0x00000001854ACAC0-0x00000001854ACD00
		protected override void InitiateSolver(); // 0x0000000185CD20C0-0x0000000185CD2290
		protected override void UpdateSolver(); // 0x00000001854ACD00-0x00000001854AD510
		public void LogWarning(string message); // 0x000000018CDCCCB8-0x000000018CDCCCE0
	}

	[Serializable]
	public class BipedIKSolvers // TypeDefIndex: 82849
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
		public IKSolverLimb[] limbs { get; } // 0x00000001854AD510-0x00000001854AD600 
		public IKSolver[] ikSolvers { get; } // 0x000000018CDCC9EC-0x000000018CDCCB44 
	
		// Constructors
		public BipedIKSolvers(); // 0x0000000185CD26B0-0x0000000185CD28A0
	
		// Methods
		public void AssignReferences(BipedReferences references); // 0x0000000185CD2FE0-0x0000000185CD3180
	}

	[Serializable]
	public abstract class Constraint // TypeDefIndex: 82850
	{
		// Fields
		public Transform transform; // 0x10
		public float weight; // 0x18
	
		// Properties
		public bool isValid { get; } // 0x000000018CDD1E40-0x000000018CDD1E90 
	
		// Constructors
		protected Constraint(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract void UpdateConstraint();
	}

	[Serializable]
	public class ConstraintPosition : Constraint // TypeDefIndex: 82851
	{
		// Fields
		public Vector3 position; // 0x20
	
		// Constructors
		public ConstraintPosition(); // 0x0000000186805BA0-0x0000000186805BB0
		public ConstraintPosition(Transform transform); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void UpdateConstraint(); // 0x000000018CDD1B34-0x000000018CDD1BE0
	}

	[Serializable]
	public class ConstraintPositionOffset : Constraint // TypeDefIndex: 82852
	{
		// Fields
		public Vector3 offset; // 0x20
		private Vector3 defaultLocalPosition; // 0x2C
		private Vector3 lastLocalPosition; // 0x38
		private bool initiated; // 0x44
	
		// Properties
		private bool positionChanged { get; } // 0x000000018CDD1AB0-0x000000018CDD1B34 
	
		// Constructors
		public ConstraintPositionOffset(); // 0x0000000186805BA0-0x0000000186805BB0
		public ConstraintPositionOffset(Transform transform); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void UpdateConstraint(); // 0x000000018CDD18FC-0x000000018CDD1AB0
	}

	[Serializable]
	public class ConstraintRotation : Constraint // TypeDefIndex: 82853
	{
		// Fields
		public Quaternion rotation; // 0x20
	
		// Constructors
		public ConstraintRotation(); // 0x0000000186805BA0-0x0000000186805BB0
		public ConstraintRotation(Transform transform); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void UpdateConstraint(); // 0x000000018CDD1DA4-0x000000018CDD1E40
	}

	[Serializable]
	public class ConstraintRotationOffset : Constraint // TypeDefIndex: 82854
	{
		// Fields
		public Quaternion offset; // 0x20
		private Quaternion defaultRotation; // 0x30
		private Quaternion defaultLocalRotation; // 0x40
		private Quaternion lastLocalRotation; // 0x50
		private Quaternion defaultTargetLocalRotation; // 0x60
		private bool initiated; // 0x70
	
		// Properties
		private bool rotationChanged { get; } // 0x000000018CDD1D4C-0x000000018CDD1DA4 
	
		// Constructors
		public ConstraintRotationOffset(); // 0x0000000186805BA0-0x0000000186805BB0
		public ConstraintRotationOffset(Transform transform); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void UpdateConstraint(); // 0x000000018CDD1BE0-0x000000018CDD1D4C
	}

	[Serializable]
	public class Constraints // TypeDefIndex: 82855
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
		public Constraints(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool IsValid(); // 0x00000001854ADBA0-0x00000001854ADC10
		public void Initiate(Transform transform); // 0x0000000185CD2290-0x0000000185CD2310
		public void Update(); // 0x00000001854AD860-0x00000001854ADBA0
	}

	[Serializable]
	public class Finger // TypeDefIndex: 82857
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
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
		public Vector3 IKPosition { get; set; } // 0x000000018CDD2FE0-0x000000018CDD300C 0x000000018CDD3030-0x000000018CDD305C
		public Quaternion IKRotation { get; set; } // 0x000000018CDD300C-0x000000018CDD3030 0x000000018CDD305C-0x000000018CDD307C
	
		// Nested types
		[Serializable]
		public enum DOF // TypeDefIndex: 82856
		{
			One = 0,
			Three = 1
		}
	
		// Constructors
		public Finger(); // 0x0000000187256FE0-0x0000000187256FF0
	
		// Methods
		public bool IsValid(ref string errorMessage); // 0x000000018CDD2840-0x000000018CDD2908
		public void Initiate(Transform hand, int index); // 0x000000018CDD2040-0x000000018CDD2840
		public void FixTransforms(); // 0x000000018CDD1F6C-0x000000018CDD2040
		public void StoreDefaultLocalState(); // 0x000000018CDD2908-0x000000018CDD29C0
		public void Update(float masterWeight); // 0x000000018CDD29C0-0x000000018CDD2FE0
	}

	public class FingerRig : SolverManager // TypeDefIndex: 82858
	{
		// Fields
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight; // 0x38
		public Finger[] fingers; // 0x40
		[CompilerGenerated]
		private bool _initiated_k__BackingField; // 0x48
	
		// Properties
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
	
		// Constructors
		public FingerRig(); // 0x000000018CDDA038-0x000000018CDDA090
	
		// Methods
		public bool IsValid(ref string errorMessage); // 0x000000018CDD9DB0-0x000000018CDD9E24
		[ContextMenu("Auto-detect")]
		public void AutoDetect(); // 0x000000018CDD9A3C-0x000000018CDD9C98
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null); // 0x000000018CDD98B8-0x000000018CDD9A3C
		public void RemoveFinger(int index); // 0x000000018CDD9E24-0x000000018CDD9F6C
		private void AddChildrenRecursive(Transform parent, ref Transform[] array); // 0x000000018CDD97FC-0x000000018CDD98B8
		protected override void InitiateSolver(); // 0x000000018CDD9D10-0x000000018CDD9DB0
		public void UpdateFingerSolvers(); // 0x000000018CDD9FC4-0x000000018CDDA030
		public void FixFingerTransforms(); // 0x000000018CDD9C98-0x000000018CDD9CFC
		public void StoreDefaultLocalState(); // 0x000000018CDD9F6C-0x000000018CDD9FC4
		protected override void UpdateSolver(); // 0x000000018CDDA030-0x000000018CDDA038
		protected override void FixTransforms(); // 0x000000018CDD9CFC-0x000000018CDD9D10
	}

	public abstract class Grounder : MonoBehaviour // TypeDefIndex: 82860
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
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
	
		// Nested types
		public delegate void GrounderDelegate(); // TypeDefIndex: 82859; 0x0000000185B44B70-0x0000000185B44B80
	
		// Constructors
		protected Grounder(); // 0x0000000186860F90-0x0000000186861030
	
		// Methods
		public abstract void ResetPosition();
		protected Vector3 GetSpineOffsetTarget(); // 0x000000018CDDF8DC-0x000000018CDDF9C4
		protected void LogWarning(string message); // 0x000000018CDCCCB8-0x000000018CDCCCE0
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg); // 0x000000018CDDF530-0x000000018CDDF6DC
		private Vector3 GetLegSpineTangent(Grounding.Leg leg); // 0x000000018CDDF6DC-0x000000018CDDF8DC
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderBipedIK : Grounder // TypeDefIndex: 82861
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
		public float RightFootOffsetY { get; } // 0x000000018723D7D0-0x000000018723D7E0 
		public float LeftFootOffsetY { get; } // 0x0000000187253DD0-0x0000000187253DE0 
		public float RightFootOri { get; } // 0x000000018723F320-0x000000018723F330 
		public float LeftFootOri { get; } // 0x0000000187250E40-0x0000000187250E50 
	
		// Constructors
		public GrounderBipedIK(); // 0x0000000186860F00-0x0000000186860F90
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDDA998-0x000000018CDDA9CC
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDDA964-0x000000018CDDA998
		public override void ResetPosition(); // 0x000000018CDDA9CC-0x000000018CDDAA0C
		private bool IsReadyToInitiate(); // 0x00000001857637C0-0x00000001857638C0
		private void Update(); // 0x0000000185763760-0x00000001857637C0
		private void Initiate(); // 0x0000000185763D60-0x0000000185764100
		private void OnDisable(); // 0x0000000186D24700-0x0000000186D24760
		private void OnSolverUpdate(); // 0x0000000185549B90-0x000000018554BD10
		private void SetLegIK(IKSolverLimb limb, int index); // 0x0000000185184170-0x0000000185184550
		private void OnPostSolverUpdate(); // 0x00000001854ADDB0-0x00000001854AE120
		private void OnDestroy(); // 0x00000001871DD1F0-0x00000001871DD250
		private Quaternion ClampPitchAndRollAroundForward(Quaternion Q, Quaternion calfQ, float minPitch, float maxPitch, float minRoll, float maxRoll); // 0x0000000185024020-0x0000000185024500
		private float NormalizeAngle(float angle); // 0x0000000185023FA0-0x0000000185024020
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderFBBIK : Grounder // TypeDefIndex: 82863
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
		public class SpineEffector // TypeDefIndex: 82862
		{
			// Fields
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType; // 0x10
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight; // 0x14
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight; // 0x18
	
			// Constructors
			public SpineEffector(); // 0x000000018723C870-0x000000018723C880
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight); // 0x0000000187257710-0x0000000187257720
		}
	
		// Constructors
		public GrounderFBBIK(); // 0x000000018CDDB86C-0x000000018CDDB8F4
	
		// Methods
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial(); // 0x000000018CDDB5BC-0x000000018CDDB5F0
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDDB5F0-0x000000018CDDB624
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDDB588-0x000000018CDDB5BC
		public override void ResetPosition(); // 0x000000018CDDB624-0x000000018CDDB65C
		private bool IsReadyToInitiate(); // 0x000000018CDDAD1C-0x000000018CDDAD94
		private void Update(); // 0x000000018CDDB810-0x000000018CDDB86C
		private void FixedUpdate(); // 0x000000018723B270-0x000000018723B280
		private void LateUpdate(); // 0x000000018723B270-0x000000018723B280
		private void Initiate(); // 0x000000018CDDAA0C-0x000000018CDDAD1C
		private void OnSolverUpdate(); // 0x000000018CDDB0A4-0x000000018CDDB588
		private void SetLegIK(IKEffector effector, Grounding.Leg leg); // 0x000000018CDDB65C-0x000000018CDDB810
		private void OnDrawGizmosSelected(); // 0x000000018CDDAF78-0x000000018CDDB088
		private void OnPostSolverUpdate(); // 0x000000018CDDB088-0x000000018CDDB0A4
		private void OnDestroy(); // 0x000000018CDDAD94-0x000000018CDDAF78
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderIK : Grounder // TypeDefIndex: 82864
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
		public GrounderIK(); // 0x000000018CDDCFF0-0x000000018CDDD07C
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDDC648-0x000000018CDDC67C
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDDC614-0x000000018CDDC648
		public override void ResetPosition(); // 0x000000018CDDC67C-0x000000018CDDC8FC
		private bool IsReadyToInitiate(); // 0x000000018CDDBD50-0x000000018CDDBEDC
		private void OnDisable(); // 0x000000018CDDC104-0x000000018CDDC1C8
		private void Update(); // 0x000000018CDDCBEC-0x000000018CDDCFF0
		private void Initiate(); // 0x000000018CDDB8F4-0x000000018CDDBD50
		private void OnSolverUpdate(); // 0x000000018CDDC3A4-0x000000018CDDC614
		private void SetLegIK(int index); // 0x000000018CDDC8FC-0x000000018CDDCBEC
		private void OnPostSolverUpdate(); // 0x000000018CDDC1C8-0x000000018CDDC3A4
		private void OnDestroy(); // 0x000000018CDDBEDC-0x000000018CDDC104
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderQuadruped : Grounder // TypeDefIndex: 82866
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
		public struct Foot // TypeDefIndex: 82865
		{
			// Fields
			public IKSolver solver; // 0x00
			public Transform transform; // 0x08
			public Quaternion rotation; // 0x10
			public Grounding.Leg leg; // 0x20
	
			// Constructors
			public Foot(IKSolver solver, Transform transform); // 0x000000018CDDA090-0x000000018CDDA0EC
		}
	
		// Constructors
		public GrounderQuadruped(); // 0x000000018CDDF448-0x000000018CDDF530
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDDE92C-0x000000018CDDE960
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDDE8F8-0x000000018CDDE92C
		public override void ResetPosition(); // 0x000000018CDDE960-0x000000018CDDEB28
		private bool IsReadyToInitiate(); // 0x000000018CDDDB64-0x000000018CDDDC64
		private bool IsReadyToInitiateLegs(IK[] ikComponents); // 0x000000018CDDDA0C-0x000000018CDDDB64
		private void OnDisable(); // 0x000000018CDDDD80-0x000000018CDDDDF0
		private void Update(); // 0x000000018CDDF3E8-0x000000018CDDF448
		private void Initiate(); // 0x000000018CDDD610-0x000000018CDDDA0C
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset); // 0x000000018CDDD298-0x000000018CDDD610
		private void LateUpdate(); // 0x000000018CDDDC64-0x000000018CDDDD44
		private void RootRotation(); // 0x000000018CDDEB28-0x000000018CDDEFD8
		private void OnSolverUpdate(); // 0x000000018CDDE0D4-0x000000018CDDE8F8
		private void UpdateForefeetRoot(); // 0x000000018CDDF144-0x000000018CDDF3E8
		private void SetFootIK(Foot foot, float maxOffset); // 0x000000018CDDEFD8-0x000000018CDDF144
		private void OnPostSolverUpdate(); // 0x000000018CDDDDF0-0x000000018CDDE0D4
		private void OnDestroy(); // 0x000000018CDDDD44-0x000000018CDDDD80
		private void DestroyLegs(IK[] ikComponents); // 0x000000018CDDD07C-0x000000018CDDD298
	}

	[Serializable]
	public class Grounding // TypeDefIndex: 82873
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
		public BipedReferences references { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187236200-0x0000000187236210 0x0000000188D95540-0x0000000188D95554
		public Leg[] legs { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723BB00-0x000000018723BB10 0x0000000188D9C9D0-0x0000000188D9C9E4
		public Pelvis pelvis { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234580-0x0000000187234590 0x0000000188A79A0C-0x0000000188A79A20
		public bool isGrounded { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184F59D60-0x0000000184F59D70 0x0000000184F59D70-0x0000000184F59D80
		public Transform root { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872360B0-0x00000001872360C0 0x0000000188C247F0-0x0000000188C24804
		public RaycastHit rootHit { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724ECF0-0x000000018724ED20 0x00000001872575F0-0x0000000187257620
		public bool rootGrounded { get; } // 0x00000001851A4410-0x00000001851A4420 
		public Transform entityTransform { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BE50-0x000000018723BE60 0x0000000188DC478C-0x0000000188DC47A0
		public bool entityIsOnMovableBase { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184F6ABE0-0x0000000184F6ABF0 0x0000000184F6ABF0-0x0000000184F6AC00
		public Vector3 entityRelativePosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187257580-0x00000001872575A0 0x00000001872575C0-0x00000001872575E0
		public Quaternion entityRelativeRotation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872575A0-0x00000001872575B0 0x00000001872575E0-0x00000001872575F0
		public bool isInitiated { get; } // 0x00000001872575B0-0x00000001872575C0 
		public Vector3 up { get; } // 0x00000001854AF010-0x00000001854AF070 
		public Vector3 forward { get; } // 0x0000000185184550-0x00000001851845F0 
		private bool useRootRotation { get; } // 0x00000001854AF070-0x00000001854AF090 
	
		// Nested types
		[Serializable]
		public enum Quality // TypeDefIndex: 82867
		{
			Fastest = 0,
			Simple = 1,
			Best = 2,
			Custom = 3
		}
	
		public delegate bool OnRaycastDelegate(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 82868; 0x0000000184161650-0x00000001841616C0
	
		public delegate bool OnCapsuleCastDelegate(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 82869; 0x00000001879913BC-0x0000000187991460
	
		public delegate bool OnSphereCastDelegate(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction); // TypeDefIndex: 82870; 0x0000000187996BC8-0x0000000187996C44
	
		public class Leg // TypeDefIndex: 82871
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
			public const float MAX_PREDICTION_DISTANCE = 2.25f; // Metadata: 0x02641720
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
			public bool isGrounded { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
			public Vector3 IKPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829EBA20-0x00000001829EBA40 0x000000018723FDA0-0x000000018723FDB0
			public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
			public float heightFromGround { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723CEF0-0x000000018723CF00 0x0000000187233AF0-0x0000000187233B00
			public float fowardMoveFromGround { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235380-0x0000000187235390 0x0000000187235390-0x00000001872353A0
			public float rightMoveFromGround { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872330B0-0x00000001872330C0 0x0000000187233110-0x0000000187233120
			public Vector3 velocity { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187236520-0x0000000187236540 0x0000000187236550-0x0000000187236560
			public Transform transform { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
			public float IKOffset { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872353B0-0x00000001872353C0 0x00000001872353E0-0x00000001872353F0
			public float IKOffsetZ { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001826DD0B0-0x00000001826DD0C0 0x00000001826DD0C0-0x00000001826DD0D0
			public float IKOffsetX { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872352B0-0x00000001872352C0 0x00000001872352D0-0x00000001872352E0
			public RaycastHit heelHit { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187257680-0x00000001872576B0 0x00000001872576E0-0x0000000187257710
			public RaycastHit capsuleHit { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187257650-0x0000000187257680 0x00000001872576B0-0x00000001872576E0
			public RaycastHit GetHitPoint { get; } // 0x000000018CDE0D00-0x000000018CDE0D74 
			public Vector3 right { get; } // 0x00000001854AE210-0x00000001854AE330 
			public Vector3 speedRight { get; } // 0x00000001854A5800-0x00000001854A5920 
			public Vector3 predictOffsetwithPercent { get; } // 0x0000000186047CE0-0x0000000186047DF0 
			private bool isLeft { get; } // 0x00000001854AF970-0x00000001854AFA80 
			private bool isMoving { get; } // 0x000000018CDE0D74-0x000000018CDE0D94 
			public float stepHeightFromGround { get; } // 0x00000001854AF090-0x00000001854AF0E0 
			public float stepForwardFromGround { get; } // 0x00000001854AF820-0x00000001854AF850 
			public float stepRightFromGround { get; } // 0x00000001854AF850-0x00000001854AF880 
			private Vector3 animFootGroundPos { get; } // 0x0000000185027B40-0x0000000185027DC0 
			public float rootYOffset { get; } // 0x00000001854AEC90-0x00000001854AEFC0 
	
			// Constructors
			public Leg(); // 0x0000000185764680-0x00000001857646F0
			static Leg(); // 0x0000000187110120-0x00000001871101C0
	
			// Methods
			public void SetFootPosition(Vector3 position); // 0x0000000187257630-0x0000000187257650
			public void Initiate(Grounding grounding, Transform transform); // 0x00000001857646F0-0x00000001857647D0
			public void OnEnable(); // 0x00000001857647D0-0x0000000185764830
			public void Reset(); // 0x000000018CDE0994-0x000000018CDE0A24
			private void _ResetPredictReference(RaycastHit curHit); // 0x00000001854ADC10-0x00000001854ADD20
			private void _PredictNextStepHit(Vector3 prediction, Vector3 predictVec, bool canChangeHeight = true /* Metadata: 0x0264171E */); // 0x0000000185879D20-0x0000000185879F80
			private float _CanHitPointLand(RaycastHit hit, out RaycastHit predictHit); // 0x0000000185879F80-0x000000018587A350
			public void Process(); // 0x00000001854AFA80-0x00000001854B32D0
			private void _UpdateHeelHit(float curStepPercent, Vector3 prediction); // 0x0000000185E330D0-0x0000000185E33290
			private Vector3 _UpdatePredictOffset(float curStepPercent); // 0x0000000185E33290-0x0000000185E333B0
			public void FinalSetIKPosition(Vector3 thighPos); // 0x000000018546A520-0x000000018546A7E0
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel, Vector3 predictPos); // 0x0000000185BB79C0-0x0000000185BB86B0
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel); // 0x000000018CDDFE40-0x000000018CDE0544
			private RaycastHit GetRaycastHitCustom(Vector3 offsetFromHeel); // 0x000000018517B9A0-0x000000018517BFF0
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel); // 0x000000018CDE0544-0x000000018CDE0994
			private Vector3 RotateNormal(Vector3 normal); // 0x0000000184FBF2C0-0x0000000184FBF330
			private void SetFootToPoint(Vector3 normal, Vector3 point); // 0x000000018CDE0C38-0x000000018CDE0D00
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint); // 0x000000018CDE0A24-0x000000018CDE0C38
			private void SetFootToPoint(Vector3 normal, Vector3 pointForXZ, Vector3 pointForY); // 0x0000000184FBEC20-0x0000000184FBF2C0
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint, Vector3 footNormal, bool isLimitByComplex = true /* Metadata: 0x0264171F */); // 0x00000001856BFF90-0x00000001856C0520
			private float GetHeightFromGround(Vector3 hitPoint); // 0x00000001854AE330-0x00000001854AE6E0
			private void RotateFoot(); // 0x00000001854ADD20-0x00000001854ADDB0
			private Quaternion GetRotationOffsetTarget(); // 0x0000000187257620-0x0000000187257630
			private Vector3 RotateNormalWithLimit(Vector3 normal); // 0x0000000184FBF330-0x0000000184FBFDD0
		}
	
		public class Pelvis // TypeDefIndex: 82872
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
			public Vector3 IKOffset { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184432B70-0x0000000184432B90 0x0000000187239670-0x0000000187239680
			public float heightOffset { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
	
			// Constructors
			public Pelvis(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Initiate(Grounding grounding); // 0x0000000185764830-0x0000000185764860
			public void Reset(); // 0x000000018CDE1500-0x000000018CDE1584
			public void OnEnable(); // 0x0000000185764860-0x00000001857648D0
			public void Process(float pelivsOffset, float _forwardOffset, bool isGrounded, bool islastFrameLegStretch = false /* Metadata: 0x02641724 */, bool isSameLegReflastFrame = false /* Metadata: 0x02641725 */); // 0x00000001854AF0E0-0x00000001854AF820
			private RaycastHit GetRaycastHitCustom(Vector3 rayOrigin); // 0x000000018CDE1138-0x000000018CDE1500
		}
	
		// Constructors
		public Grounding(); // 0x0000000186861030-0x00000001868611F0
	
		// Methods
		private void _UpdateFloorPredictTheta(); // 0x00000001854AE6E0-0x00000001854AE9E0
		private void _UpdateFloorFeetThetaByFoot(); // 0x00000001854AE9E0-0x00000001854AEC90
		private void _UpdateFloorFeetThetaByRoot(); // 0x0000000185CB9180-0x0000000185CB93C0
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f /* Metadata: 0x02641716 */); // 0x000000018517D440-0x000000018517DAC0
		public bool IsValid(ref string errorMessage); // 0x00000001857648D0-0x0000000185764A10
		public void Initiate(Transform root, Transform[] feet, BipedReferences references = null); // 0x00000001857643E0-0x0000000185764680
		public void Update(); // 0x00000001851825B0-0x0000000185184170
		public Vector3 GetLegsPlaneNormal(); // 0x000000018CDDFBB4-0x000000018CDDFDAC
		public void Reset(); // 0x000000018CDDFDC4-0x000000018CDDFE40
		public void LogWarning(string message); // 0x000000018CDDFDAC-0x000000018CDDFDC4
		public float GetVerticalOffset(Vector3 p1, Vector3 p2); // 0x00000001854AEFC0-0x00000001854AF010
		public Vector3 Flatten(Vector3 v); // 0x000000018CDDF9C4-0x000000018CDDFAB8
		public Vector3 GetFootCenterOffset(); // 0x000000018CDDFAB8-0x000000018CDDFBB4
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK // TypeDefIndex: 82874
	{
		// Fields
		public IKSolverAim solver; // 0x38
	
		// Constructors
		public AimIK(); // 0x000000018CDD928C-0x000000018CDD92FC
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDD9224-0x000000018CDD9258
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDD91BC-0x000000018CDD91F0
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial(); // 0x000000018CDD91F0-0x000000018CDD9224
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDD9258-0x000000018CDD928C
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDD9188-0x000000018CDD91BC
		public override IKSolver GetIKSolver(); // 0x0000000182986470-0x0000000182986480
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class ArmIK : IK // TypeDefIndex: 82875
	{
		// Fields
		public IKSolverArm solver; // 0x38
	
		// Constructors
		public ArmIK(); // 0x000000018CDD93CC-0x000000018CDD943C
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDD9364-0x000000018CDD9398
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDD9330-0x000000018CDD9364
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDD9398-0x000000018CDD93CC
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDD92FC-0x000000018CDD9330
		public override IKSolver GetIKSolver(); // 0x0000000182986470-0x0000000182986480
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK // TypeDefIndex: 82876
	{
		// Fields
		public IKSolverCCD solver; // 0x38
	
		// Constructors
		public CCDIK(); // 0x000000018CDD950C-0x000000018CDD957C
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDD94A4-0x000000018CDD94D8
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDD9470-0x000000018CDD94A4
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDD94D8-0x000000018CDD950C
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDD943C-0x000000018CDD9470
		public override IKSolver GetIKSolver(); // 0x0000000182986470-0x0000000182986480
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	public class FABRIK : IK // TypeDefIndex: 82877
	{
		// Fields
		public IKSolverFABRIK solver; // 0x38
	
		// Constructors
		public FABRIK(); // 0x000000018CDD978C-0x000000018CDD97FC
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDD9724-0x000000018CDD9758
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDD96F0-0x000000018CDD9724
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDD9758-0x000000018CDD978C
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDD96BC-0x000000018CDD96F0
		public override IKSolver GetIKSolver(); // 0x0000000182986470-0x0000000182986480
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	public class FABRIKRoot : IK // TypeDefIndex: 82878
	{
		// Fields
		public IKSolverFABRIKRoot solver; // 0x38
	
		// Constructors
		public FABRIKRoot(); // 0x000000018CDD964C-0x000000018CDD96BC
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDD95E4-0x000000018CDD9618
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDD95B0-0x000000018CDD95E4
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDD9618-0x000000018CDD964C
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDD957C-0x000000018CDD95B0
		public override IKSolver GetIKSolver(); // 0x0000000182986470-0x0000000182986480
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK // TypeDefIndex: 82879
	{
		// Fields
		public BipedReferences references; // 0x38
		public IKSolverFullBodyBiped solver; // 0x40
	
		// Constructors
		public FullBodyBipedIK(); // 0x000000018CDDA8BC-0x000000018CDDA964
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDDA294-0x000000018CDDA2C8
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDDA22C-0x000000018CDDA260
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial(); // 0x000000018CDDA260-0x000000018CDDA294
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial(); // 0x000000018CDDA1F8-0x000000018CDDA22C
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDDA888-0x000000018CDDA8BC
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDDA0EC-0x000000018CDDA120
		public void SetReferences(BipedReferences references, Transform rootNode); // 0x000000018CDDA84C-0x000000018CDDA888
		public override IKSolver GetIKSolver(); // 0x000000018226EEA0-0x000000018226EEB0
		public bool ReferencesError(ref string errorMessage); // 0x000000018CDDA2C8-0x000000018CDDA4AC
		public bool ReferencesWarning(ref string warningMessage); // 0x000000018CDDA4AC-0x000000018CDDA820
		[ContextMenu("Reinitiate")]
		private void Reinitiate(); // 0x000000018CDDA820-0x000000018CDDA84C
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences(); // 0x000000018CDDA120-0x000000018CDDA1F8
	}

	public abstract class IK : SolverManager // TypeDefIndex: 82880
	{
		// Constructors
		protected IK(); // 0x000000018783A01C-0x000000018783A024
	
		// Methods
		public abstract IKSolver GetIKSolver();
		protected override void UpdateSolver(); // 0x00000001863B9850-0x00000001863B98B0
		protected override void InitiateSolver(); // 0x00000001863B97A0-0x00000001863B9800
		protected override void FixTransforms(); // 0x00000001863B9800-0x00000001863B9850
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}

	public class IKExecutionOrder : MonoBehaviour // TypeDefIndex: 82881
	{
		// Fields
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents; // 0x18
		[Tooltip("Optional. Assign it if you are using \'Animate Physics\' as the Update Mode.")]
		public Animator animator; // 0x20
		private bool fixedFrame; // 0x28
	
		// Properties
		private bool animatePhysics { get; } // 0x000000018CDED590-0x000000018CDED608 
	
		// Constructors
		public IKExecutionOrder(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Start(); // 0x000000018CDED504-0x000000018CDED564
		private void Update(); // 0x000000018CDED564-0x000000018CDED590
		private void FixedUpdate(); // 0x000000018CDED454-0x000000018CDED484
		private void LateUpdate(); // 0x000000018CDED484-0x000000018CDED504
		private void FixTransforms(); // 0x000000018CDED3E0-0x000000018CDED454
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class LegIK : IK // TypeDefIndex: 82882
	{
		// Fields
		public IKSolverLeg solver; // 0x38
	
		// Constructors
		public LegIK(); // 0x000000018CDF2728-0x000000018CDF2798
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDF26C0-0x000000018CDF26F4
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDF268C-0x000000018CDF26C0
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDF26F4-0x000000018CDF2728
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDF2658-0x000000018CDF268C
		public override IKSolver GetIKSolver(); // 0x0000000182986470-0x0000000182986480
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class LimbIK : IK // TypeDefIndex: 82883
	{
		// Fields
		public IKSolverLimb solver; // 0x38
	
		// Constructors
		public LimbIK(); // 0x000000018CDF2868-0x000000018CDF28D8
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDF2800-0x000000018CDF2834
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDF27CC-0x000000018CDF2800
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDF2834-0x000000018CDF2868
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDF2798-0x000000018CDF27CC
		public override IKSolver GetIKSolver(); // 0x0000000182986470-0x0000000182986480
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	public class LookAtIK : IK // TypeDefIndex: 82884
	{
		// Fields
		public IKSolverLookAt solver; // 0x38
	
		// Constructors
		public LookAtIK(); // 0x0000000185CD2520-0x0000000185CD2590
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDF2940-0x000000018CDF2974
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDF290C-0x000000018CDF2940
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDF2974-0x000000018CDF29A8
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDF28D8-0x000000018CDF290C
		public override IKSolver GetIKSolver(); // 0x0000000182986470-0x0000000182986480
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	public class TrigonometricIK : IK // TypeDefIndex: 82885
	{
		// Fields
		public IKSolverTrigonometric solver; // 0x38
	
		// Constructors
		public TrigonometricIK(); // 0x000000018CDF3DF4-0x000000018CDF3E64
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDF3D8C-0x000000018CDF3DC0
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDF3D58-0x000000018CDF3D8C
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CDF3DC0-0x000000018CDF3DF4
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CDF3D24-0x000000018CDF3D58
		public override IKSolver GetIKSolver(); // 0x0000000182986470-0x0000000182986480
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK // TypeDefIndex: 82887
	{
		// Fields
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select \'Auto-detect References\' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public References references; // 0x38
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver; // 0x40
	
		// Nested types
		[Serializable]
		public class References // TypeDefIndex: 82886
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
			public bool isFilled { get; } // 0x000000018CDF38C0-0x000000018CDF3D24 
			public bool isEmpty { get; } // 0x000000018CDF3550-0x000000018CDF38C0 
	
			// Constructors
			public References(); // 0x0000000186805BA0-0x0000000186805BB0
			public References(BipedReferences b); // 0x000000018CDF330C-0x000000018CDF3550
	
			// Methods
			public Transform[] GetTransforms(); // 0x000000018CDF2FEC-0x000000018CDF330C
			public static bool AutoDetectReferences(Transform root, out References references); // 0x000000018CDF2B54-0x000000018CDF2FEC
		}
	
		// Constructors
		public VRIK(); // 0x000000018CDF410C-0x000000018CDF41A4
	
		// Methods
		[ContextMenu("User Manual")]
		protected override void OpenUserManual(); // 0x000000018CDF3F84-0x000000018CDF3FB8
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference(); // 0x000000018CDF3F1C-0x000000018CDF3F50
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial(); // 0x000000018CDF3F50-0x000000018CDF3F84
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences(); // 0x000000018CDF3E64-0x000000018CDF3E88
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations(); // 0x000000018CDF3E88-0x000000018CDF3EB4
		public override IKSolver GetIKSolver(); // 0x000000018226EEA0-0x000000018226EEB0
		protected override void InitiateSolver(); // 0x000000018CDF3EB4-0x000000018CDF3F1C
		protected override void UpdateSolver(); // 0x000000018CDF3FB8-0x000000018CDF410C
	}

	[Serializable]
	public class FABRIKChain // TypeDefIndex: 82888
	{
		// Fields
		public FABRIK ik; // 0x10
		[Range(0f, 1f)]
		public float pull; // 0x18
		[Range(0f, 1f)]
		public float pin; // 0x1C
		public int[] children; // 0x20
	
		// Constructors
		public FABRIKChain(); // 0x000000018CDE3D0C-0x000000018CDE3D5C
	
		// Methods
		public bool IsValid(ref string message); // 0x000000018CDE3A1C-0x000000018CDE3ACC
		public void Initiate(); // 0x000000018CDE39F8-0x000000018CDE3A1C
		public void Stage1(FABRIKChain[] chain); // 0x000000018CDE3ACC-0x000000018CDE3BD4
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain); // 0x000000018CDE3BD4-0x000000018CDE3D0C
		private Vector3 GetCentroid(FABRIKChain[] chain); // 0x000000018CDE36F4-0x000000018CDE39F8
	}

	public class FBBIKArmBending : MonoBehaviour // TypeDefIndex: 82889
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
		public FBBIKArmBending(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void LateUpdate(); // 0x000000018CDE3D5C-0x000000018CDE4378
		private void OnPostFBBIK(); // 0x000000018CDE44A0-0x000000018CDE4674
		private void OnDestroy(); // 0x000000018CDE4378-0x000000018CDE44A0
	}

	public class FBBIKHeadEffector : MonoBehaviour // TypeDefIndex: 82891
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
		public class BendBone // TypeDefIndex: 82890
		{
			// Fields
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform; // 0x10
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight; // 0x18
			private Quaternion defaultLocalRotation; // 0x1C
	
			// Constructors
			public BendBone(); // 0x000000018CDE1624-0x000000018CDE1648
			public BendBone(Transform transform, float weight); // 0x000000018CDE15EC-0x000000018CDE1624
	
			// Methods
			public void StoreDefaultLocalState(); // 0x000000018CDE15B8-0x000000018CDE15EC
			public void FixTransforms(); // 0x000000018CDE1584-0x000000018CDE15B8
		}
	
		// Constructors
		public FBBIKHeadEffector(); // 0x000000018CDE7CFC-0x000000018CDE7ED0
	
		// Methods
		private void Start(); // 0x000000018CDE784C-0x000000018CDE7CFC
		private void OnStoreDefaultLocalState(); // 0x000000018CDE6B18-0x000000018CDE7044
		private void OnFixTransforms(); // 0x000000018CDE5CAC-0x000000018CDE6090
		private void OnPreRead(); // 0x000000018CDE6298-0x000000018CDE6B18
		private void SpineBend(); // 0x000000018CDE751C-0x000000018CDE784C
		private void CCDPass(); // 0x000000018CDE4674-0x000000018CDE4A00
		private void Iterate(int iteration); // 0x000000018CDE4CB4-0x000000018CDE5778
		private void OnPostUpdate(); // 0x000000018CDE6090-0x000000018CDE6298
		private void ChestDirection(); // 0x000000018CDE4A00-0x000000018CDE4CB4
		private void PostStretching(); // 0x000000018CDE7044-0x000000018CDE73B0
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset); // 0x000000018CDE5778-0x000000018CDE5898
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance); // 0x000000018CDE73B0-0x000000018CDE751C
		private void OnDestroy(); // 0x000000018CDE5898-0x000000018CDE5CAC
	}

	[Serializable]
	public class FBIKChain // TypeDefIndex: 82894
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
		private const float maxLimbLength = 0.99999f; // Metadata: 0x02641727
	
		// Nested types
		[Serializable]
		public class ChildConstraint // TypeDefIndex: 82892
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
			public float nominalDistance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
			public bool isRigid { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018224A5F0-0x000000018224A600 0x000000018224A600-0x000000018224A610
	
			// Constructors
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f /* Metadata: 0x0264172B */, float pullElasticity = 0f /* Metadata: 0x0264172F */); // 0x000000018CDE36B8-0x000000018CDE36F4
	
			// Methods
			public void Initiate(IKSolverFullBody solver); // 0x000000018CDE317C-0x000000018CDE31D4
			public void OnPreSolve(IKSolverFullBody solver); // 0x000000018CDE31D4-0x000000018CDE33A8
			public void Solve(IKSolverFullBody solver); // 0x000000018CDE33A8-0x000000018CDE36B8
		}
	
		[Serializable]
		public enum Smoothing // TypeDefIndex: 82893
		{
			None = 0,
			Exponential = 1,
			Cubic = 2
		}
	
		// Constructors
		public FBIKChain(); // 0x000000018CDEA688-0x000000018CDEA78C
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms); // 0x000000018CDEA52C-0x000000018CDEA688
	
		// Methods
		public void SetNodes(params Transform[] boneTransforms); // 0x000000018CDE97D8-0x000000018CDE98DC
		public int GetNodeIndex(Transform boneTransform); // 0x000000018CDE88A0-0x000000018CDE8954
		public bool IsValid(ref string message); // 0x000000018CDE8AF4-0x000000018CDE8BE4
		public void Initiate(IKSolverFullBody solver); // 0x000000018CDE8954-0x000000018CDE8AF4
		public void ReadPose(IKSolverFullBody solver, bool fullBody); // 0x000000018CDE92E8-0x000000018CDE97D8
		private void CalculateBoneLengths(IKSolverFullBody solver); // 0x000000018CDE8080-0x000000018CDE8580
		public void Reach(IKSolverFullBody solver); // 0x000000018CDE8F7C-0x000000018CDE92E8
		public Vector3 Push(IKSolverFullBody solver); // 0x000000018CDE8BE4-0x000000018CDE8F7C
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false /* Metadata: 0x02641726 */); // 0x000000018CDE9CEC-0x000000018CDE9FEC
		public void Stage1(IKSolverFullBody solver); // 0x000000018CDE9FEC-0x000000018CDEA3FC
		public void Stage2(IKSolverFullBody solver, Vector3 position); // 0x000000018CDEA3FC-0x000000018CDEA52C
		public void SolveConstraintSystems(IKSolverFullBody solver); // 0x000000018CDE9948-0x000000018CDE9A64
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018CDE9A64-0x000000018CDE9B3C
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude); // 0x000000018CDE86E0-0x000000018CDE88A0
		private void SolveChildConstraints(IKSolverFullBody solver); // 0x000000018CDE98DC-0x000000018CDE9948
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance); // 0x000000018CDE9B3C-0x000000018CDE9CEC
		public void ForwardReach(Vector3 position); // 0x000000018CDE8580-0x000000018CDE86E0
		private void BackwardReach(Vector3 position); // 0x000000018CDE7ED0-0x000000018CDE8080
	}

	[Serializable]
	public class IKConstraintBend // TypeDefIndex: 82895
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
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018224EFC0-0x000000018224EFD0 0x000000018224EFD0-0x000000018224EFE0
	
		// Constructors
		public IKConstraintBend(); // 0x000000018CDEBA78-0x000000018CDEBA98
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3); // 0x000000018CDEBA48-0x000000018CDEBA78
	
		// Methods
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger); // 0x000000018CDEB048-0x000000018CDEB1E4
		public void SetBones(Transform bone1, Transform bone2, Transform bone3); // 0x00000001854F5A50-0x00000001854F5A90
		public void Initiate(IKSolverFullBody solver); // 0x000000018CDEAD48-0x000000018CDEB048
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last); // 0x000000018CDEB848-0x000000018CDEBA48
		public void LimitBend(float solverWeight, float positionWeight); // 0x000000018CDEB1E4-0x000000018CDEB650
		public Vector3 GetDir(IKSolverFullBody solver); // 0x000000018CDEA78C-0x000000018CDEAD48
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent); // 0x000000018CDEB74C-0x000000018CDEB848
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent); // 0x000000018CDEB650-0x000000018CDEB74C
	}

	[Serializable]
	public class IKEffector // TypeDefIndex: 82896
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
		public bool isEndEffector { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DFF0-0x000000018225E000 0x000000018225E000-0x000000018225E010
	
		// Constructors
		public IKEffector(); // 0x000000018CDED11C-0x000000018CDED264
		public IKEffector(Transform bone, Transform[] childBones); // 0x000000018CDED264-0x000000018CDED3E0
	
		// Methods
		public IKSolver.Node GetNode(IKSolverFullBody solver); // 0x000000018CDEBA98-0x000000018CDEBAF0
		public void PinToBone(float positionWeight, float rotationWeight); // 0x000000018CDECBB0-0x000000018CDECC78
		public bool IsValid(IKSolver solver, ref string message); // 0x000000018CDEC2EC-0x000000018CDEC550
		public void Initiate(IKSolverFullBody solver); // 0x000000018CDEBFFC-0x000000018CDEC2EC
		public void ResetOffset(IKSolverFullBody solver); // 0x000000018CDECC78-0x000000018CDECD5C
		public void SetToTarget(); // 0x000000018CDECD5C-0x000000018CDECDFC
		public void OnPreSolve(IKSolverFullBody solver); // 0x000000018CDEC564-0x000000018CDECBB0
		public void OnPostWrite(); // 0x000000018CDEC550-0x000000018CDEC564
		private Quaternion GetPlaneRotation(IKSolverFullBody solver); // 0x000000018CDEBAF0-0x000000018CDEBD04
		public void Update(IKSolverFullBody solver); // 0x000000018CDECDFC-0x000000018CDED11C
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset); // 0x000000018CDEBD04-0x000000018CDEBFFC
	}

	[Serializable]
	public class IKMapping // TypeDefIndex: 82898
	{
		// Nested types
		[Serializable]
		public class BoneMap // TypeDefIndex: 82897
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
			public Vector3 swingDirection { get; } // 0x000000018CDE296C-0x000000018CDE29E8 
			public bool isNodeBone { get; } // 0x000000018CDE2764-0x000000018CDE276C 
			private Quaternion lastAnimatedTargetRotation { get; } // 0x000000018CDE276C-0x000000018CDE296C 
	
			// Constructors
			public BoneMap(); // 0x0000000187257720-0x0000000187257750
	
			// Methods
			public void Initiate(Transform transform, IKSolverFullBody solver); // 0x000000018CDE1A74-0x000000018CDE1AC0
			public void StoreDefaultLocalState(); // 0x000000018CDE21F4-0x000000018CDE2250
			public void FixTransform(bool position); // 0x000000018CDE174C-0x000000018CDE17B4
			public void SetLength(BoneMap nextBone); // 0x000000018CDE1E48-0x000000018CDE1EE8
			public void SetLocalSwingAxis(BoneMap swingTarget); // 0x000000018CDE2018-0x000000018CDE2024
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2); // 0x000000018CDE1EE8-0x000000018CDE2018
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection); // 0x000000018CDE2024-0x000000018CDE20C4
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3); // 0x000000018CDE20C4-0x000000018CDE21B8
			public void UpdatePlane(bool rotation, bool position); // 0x000000018CDE2600-0x000000018CDE2764
			public void SetIKPosition(); // 0x000000018CDE1E0C-0x000000018CDE1E48
			public void MaintainRotation(); // 0x000000018CDE1AC0-0x000000018CDE1AF4
			public void SetToIKPosition(); // 0x000000018CDE21B8-0x000000018CDE21F4
			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null); // 0x000000018CDE1648-0x000000018CDE174C
			public Vector3 GetPlanePosition(IKSolverFullBody solver); // 0x000000018CDE17B4-0x000000018CDE18AC
			public void PositionToPlane(IKSolverFullBody solver); // 0x000000018CDE1AF4-0x000000018CDE1B44
			public void RotateToPlane(IKSolverFullBody solver, float weight); // 0x000000018CDE1D2C-0x000000018CDE1E0C
			public void Swing(Vector3 swingTarget, float weight); // 0x000000018CDE23FC-0x000000018CDE2480
			public void Swing(Vector3 pos1, Vector3 pos2, float weight); // 0x000000018CDE2250-0x000000018CDE23FC
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight); // 0x000000018CDE2480-0x000000018CDE2600
			public void RotateToMaintain(float weight); // 0x000000018CDE1C90-0x000000018CDE1D2C
			public void RotateToEffector(IKSolverFullBody solver, float weight); // 0x000000018CDE1B44-0x000000018CDE1C90
			private Quaternion GetTargetRotation(IKSolverFullBody solver); // 0x000000018CDE18AC-0x000000018CDE1A74
		}
	
		// Constructors
		public IKMapping(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual bool IsValid(IKSolver solver, ref string message); // 0x00000001851A4410-0x00000001851A4420
		public virtual void Initiate(IKSolverFullBody solver); // 0x0000000186805BA0-0x0000000186805BB0
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger = null); // 0x000000018CDF0328-0x000000018CDF0428
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018CDE9A64-0x000000018CDE9B3C
	}

	[Serializable]
	public class IKMappingBone : IKMapping // TypeDefIndex: 82899
	{
		// Fields
		public Transform bone; // 0x10
		[Range(0f, 1f)]
		public float maintainRotationWeight; // 0x18
		private BoneMap boneMap; // 0x20
	
		// Constructors
		public IKMappingBone(); // 0x000000018CDED7C0-0x000000018CDED844
		public IKMappingBone(Transform bone); // 0x000000018CDED844-0x000000018CDED8E0
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x000000018CDED6D4-0x000000018CDED750
		public void StoreDefaultLocalState(); // 0x000000018CDED770-0x000000018CDED790
		public void FixTransforms(); // 0x000000018CDED608-0x000000018CDED62C
		public override void Initiate(IKSolverFullBody solver); // 0x000000018CDED62C-0x000000018CDED6D4
		public void ReadPose(); // 0x000000018CDED750-0x000000018CDED770
		public void WritePose(float solverWeight); // 0x000000018CDED790-0x000000018CDED7C0
	}

	[Serializable]
	public class IKMappingLimb : IKMapping // TypeDefIndex: 82901
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
		public enum BoneMapType // TypeDefIndex: 82900
		{
			Parent = 0,
			Bone1 = 1,
			Bone2 = 2,
			Bone3 = 3
		}
	
		// Constructors
		public IKMappingLimb(); // 0x000000018CDEE3F0-0x000000018CDEE564
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null); // 0x000000018CDEE564-0x000000018CDEE73C
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x000000018CDEDD28-0x000000018CDEDDCC
		public BoneMap GetBoneMap(BoneMapType boneMap); // 0x000000018CDED988-0x000000018CDEDA28
		public void SetLimbOrientation(Vector3 upper, Vector3 lower); // 0x000000018CDEDE90-0x000000018CDEE1D8
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null); // 0x000000018CDEDE48-0x000000018CDEDE90
		public void StoreDefaultLocalState(); // 0x000000018CDEE1D8-0x000000018CDEE274
		public void FixTransforms(); // 0x000000018CDED8E0-0x000000018CDED988
		public override void Initiate(IKSolverFullBody solver); // 0x000000018CDEDA28-0x000000018CDEDD28
		public void ReadPose(); // 0x000000018CDEDDCC-0x000000018CDEDE48
		public void WritePose(IKSolverFullBody solver, bool fullBody); // 0x000000018CDEE274-0x000000018CDEE3F0
	}

	[Serializable]
	public class IKMappingSpine : IKMapping // TypeDefIndex: 82902
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
		public IKMappingSpine(); // 0x000000018CDF0188-0x000000018CDF0328
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone); // 0x000000018CDEFF84-0x000000018CDF0188
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x000000018CDEF1A8-0x000000018CDEF494
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone); // 0x000000018B8B62E0-0x000000018B8B633C
		public void StoreDefaultLocalState(); // 0x000000018CDEFB18-0x000000018CDEFB74
		public void FixTransforms(); // 0x000000018CDEE860-0x000000018CDEE8D4
		public override void Initiate(IKSolverFullBody solver); // 0x000000018CDEEA48-0x000000018CDEF1A8
		private bool UseFABRIK(); // 0x000000018CDEFB74-0x000000018CDEFBA0
		public void ReadPose(); // 0x000000018CDEF804-0x000000018CDEFB18
		public void WritePose(IKSolverFullBody solver); // 0x000000018CDEFBA0-0x000000018CDEFF84
		public void ForwardReach(Vector3 position); // 0x000000018CDEE8D4-0x000000018CDEEA48
		private void BackwardReach(Vector3 position); // 0x000000018CDEE73C-0x000000018CDEE860
		private void MapToSolverPositions(IKSolverFullBody solver); // 0x000000018CDEF494-0x000000018CDEF804
	}

	[Serializable]
	public abstract class IKSolver // TypeDefIndex: 82908
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
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018223FE80-0x000000018223FE90 0x000000018223FE90-0x000000018223FEA0
	
		// Nested types
		[Serializable]
		public class Point // TypeDefIndex: 82903
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
			public Point(); // 0x0000000185CD2EB0-0x0000000185CD2EE0
	
			// Methods
			public void StoreDefaultLocalState(); // 0x0000000185CD57A0-0x0000000185CD5840
			public void FixTransform(); // 0x000000018514E660-0x000000018514E880
			public void UpdateSolverPosition(); // 0x000000018CDF2ABC-0x000000018CDF2AF8
			public void UpdateSolverLocalPosition(); // 0x000000018CDF2A24-0x000000018CDF2A60
			public void UpdateSolverState(); // 0x000000018CDF2AF8-0x000000018CDF2B54
			public void UpdateSolverLocalState(); // 0x000000018CDF2A60-0x000000018CDF2ABC
		}
	
		[Serializable]
		public class Bone : Point // TypeDefIndex: 82904
		{
			// Fields
			public float length; // 0x58
			public float sqrMag; // 0x5C
			public Vector3 axis; // 0x60
			private RotationLimit _rotationLimit; // 0x70
			private bool isLimited; // 0x78
	
			// Properties
			public RotationLimit rotationLimit { get; set; } // 0x0000000185CD3D40-0x0000000185CD3EC0 0x000000018CDE311C-0x000000018CDE317C
	
			// Constructors
			public Bone(); // 0x0000000185CD2E50-0x0000000185CD2EB0
			public Bone(Transform transform); // 0x000000018CDE30AC-0x000000018CDE311C
			public Bone(Transform transform, float weight); // 0x000000018CDE3028-0x000000018CDE30AC
	
			// Methods
			public void Swing(Vector3 swingTarget, float weight = 1f /* Metadata: 0x0264173A */); // 0x000000018CDE2E24-0x000000018CDE3028
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x0264173E */); // 0x000000018CDE2A24-0x000000018CDE2C54
			public void Swing2D(Vector3 swingTarget, float weight = 1f /* Metadata: 0x02641742 */); // 0x000000018CDE2C54-0x000000018CDE2E24
			public void SetToSolverPosition(); // 0x000000018CDE29E8-0x000000018CDE2A24
		}
	
		[Serializable]
		public class Node : Point // TypeDefIndex: 82905
		{
			// Fields
			public float length; // 0x58
			public float effectorPositionWeight; // 0x5C
			public float effectorRotationWeight; // 0x60
			public Vector3 offset; // 0x64
	
			// Constructors
			public Node(); // 0x000000018CDF29D8-0x000000018CDF29E0
			public Node(Transform transform); // 0x000000018CDF29A8-0x000000018CDF29D8
			public Node(Transform transform, float weight); // 0x000000018CDF29E0-0x000000018CDF2A24
		}
	
		public delegate void UpdateDelegate(); // TypeDefIndex: 82906; 0x0000000185B44B70-0x0000000185B44B80
	
		public delegate void IterationDelegate(int i); // TypeDefIndex: 82907; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		protected IKSolver(); // 0x0000000187257750-0x0000000187257760
	
		// Methods
		public bool IsValid(); // 0x000000018CDF21FC-0x000000018CDF2258
		public abstract bool IsValid(ref string message);
		public void Initiate(Transform root); // 0x00000001859AF750-0x00000001859AF8C0
		public void Update(); // 0x00000001854AD600-0x00000001854AD670
		public virtual Vector3 GetIKPosition(); // 0x00000001829EBA20-0x00000001829EBA40
		public void SetIKPosition(Vector3 position); // 0x000000018723FDA0-0x000000018723FDB0
		public float GetIKPositionWeight(); // 0x00000001872332C0-0x00000001872332D0
		public void SetIKPositionWeight(float weight); // 0x000000018CDF25B8-0x000000018CDF25DC
		public Transform GetRoot(); // 0x000000018226EBD0-0x000000018226EBE0
		public abstract Point[] GetPoints();
		public abstract Point GetPoint(Transform transform);
		public abstract void FixTransforms();
		public abstract void StoreDefaultLocalState();
		protected abstract void OnInitiate();
		protected abstract void OnUpdate();
		protected void LogWarning(string message); // 0x000000018CDF2258-0x000000018CDF2270
		public static Transform ContainsDuplicateBone(Bone[] bones); // 0x0000000185CD5630-0x0000000185CD5750
		public static bool HierarchyIsValid(Bone[] bones); // 0x0000000185CD48D0-0x0000000185CD4960
		protected static float PreSolveBones(ref Bone[] bones); // 0x000000018CDF2270-0x000000018CDF25B8
	}

	[Serializable]
	public class IKSolverAim : IKSolverHeuristic // TypeDefIndex: 82909
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
		public Vector3 transformAxis { get; } // 0x000000018CDF0FDC-0x000000018CDF1060 
		public Vector3 transformPoleAxis { get; } // 0x000000018CDF1060-0x000000018CDF10E4 
		protected override int minBones { get; } // 0x00000001872328C0-0x00000001872328D0 
		protected override Vector3 localDirection { get; } // 0x000000018CDF0F24-0x000000018CDF0FDC 
	
		// Constructors
		public IKSolverAim(); // 0x0000000185CD2A60-0x0000000185CD2AC0
	
		// Methods
		public float GetAngle(); // 0x000000018CDF0428-0x000000018CDF04F4
		protected override void OnInitiate(); // 0x0000000185CD4090-0x0000000185CD4290
		protected override void OnUpdate(); // 0x00000001851509B0-0x0000000185150BD0
		private void Solve(); // 0x000000018CDF0E00-0x000000018CDF0F24
		private Vector3 GetClampedIKPosition(); // 0x000000018CDF04F4-0x000000018CDF08CC
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight); // 0x000000018CDF08CC-0x000000018CDF0E00
	}

	[Serializable]
	public class IKSolverArm : IKSolver // TypeDefIndex: 82910
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
		public IKSolverArm(); // 0x000000018CDF2004-0x000000018CDF21FC
	
		// Methods
		public override bool IsValid(ref string message); // 0x000000018CDF13B8-0x000000018CDF16B4
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root); // 0x000000018CDF1C24-0x000000018CDF1CD4
		public override Point[] GetPoints(); // 0x000000018CDF12B4-0x000000018CDF13B8
		public override Point GetPoint(Transform transform); // 0x000000018CDF1148-0x000000018CDF12B4
		public override void StoreDefaultLocalState(); // 0x000000018CDF1D54-0x000000018CDF1DB4
		public override void FixTransforms(); // 0x000000018CDF10E4-0x000000018CDF1148
		protected override void OnInitiate(); // 0x000000018CDF16B4-0x000000018CDF1730
		protected override void OnUpdate(); // 0x000000018CDF1730-0x000000018CDF175C
		private void Solve(); // 0x000000018CDF1CD4-0x000000018CDF1D54
		private void Read(); // 0x000000018CDF175C-0x000000018CDF1C24
		private void Write(); // 0x000000018CDF1DB4-0x000000018CDF2004
	}

	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic // TypeDefIndex: 82911
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
	
		// Constructors
		public IKSolverCCD(); // 0x000000018CDF4CB8-0x000000018CDF4CC0
	
		// Methods
		public void FadeOutBoneWeights(); // 0x000000018CDF41A4-0x000000018CDF4248
		protected override void OnInitiate(); // 0x000000018CDF4248-0x000000018CDF42C4
		protected override void OnUpdate(); // 0x000000018CDF42C4-0x000000018CDF457C
		protected void Solve(Vector3 targetPosition); // 0x000000018CDF457C-0x000000018CDF4CB8
	}

	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic // TypeDefIndex: 82912
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
		private bool[] limitedBones; // 0x90
		private Vector3[] solverLocalPositions; // 0x98
	
		// Properties
		protected override bool boneLengthCanBeZero { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public IKSolverFABRIK(); // 0x0000000185CD2AC0-0x0000000185CD2B50
	
		// Methods
		public void SolveForward(Vector3 position); // 0x000000018CDF75DC-0x000000018CDF7678
		public void SolveBackward(Vector3 position); // 0x000000018CDF7540-0x000000018CDF75DC
		public override Vector3 GetIKPosition(); // 0x000000018CDF66A8-0x000000018CDF6744
		protected override void OnInitiate(); // 0x0000000185CD4D10-0x0000000185CD50A0
		protected override void OnUpdate(); // 0x000000018618DCB0-0x000000018618DCF0
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018CDF7678-0x000000018CDF7760
		private void OnPreSolve(); // 0x000000018CDF70B0-0x000000018CDF7540
		private void OnPostSolve(); // 0x000000018CDF7068-0x000000018CDF70B0
		private void Solve(Vector3 targetPosition); // 0x000000018CDF7760-0x000000018CDF77E8
		private void ForwardReach(Vector3 position); // 0x000000018CDF64B8-0x000000018CDF66A8
		private void SolverMove(int index, Vector3 offset); // 0x000000018CDF7974-0x000000018CDF7A14
		private void SolverRotate(int index, Quaternion rotation, bool recursive); // 0x000000018CDF7AA0-0x000000018CDF7B3C
		private void SolverRotateChildren(int index, Quaternion rotation); // 0x000000018CDF7A14-0x000000018CDF7AA0
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation); // 0x000000018CDF77E8-0x000000018CDF7974
		private Quaternion GetParentSolverRotation(int index); // 0x0000000185CD4290-0x0000000185CD4420
		private Vector3 GetParentSolverPosition(int index); // 0x0000000185CD4420-0x0000000185CD45D0
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed); // 0x000000018CDF6744-0x000000018CDF6880
		private void LimitForward(int rotateBone, int limitBone); // 0x000000018CDF6880-0x000000018CDF6E08
		private void BackwardReach(Vector3 position); // 0x000000018CDF6484-0x000000018CDF64B8
		private void BackwardReachUnlimited(Vector3 position); // 0x000000018CDF6364-0x000000018CDF6484
		private void BackwardReachLimited(Vector3 position); // 0x000000018CDF5DDC-0x000000018CDF6364
		private void MapToSolverPositions(); // 0x000000018CDF6EF8-0x000000018CDF7068
		private void MapToSolverPositionsLimited(); // 0x000000018CDF6E08-0x000000018CDF6EF8
	}

	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver // TypeDefIndex: 82913
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
		public IKSolverFABRIKRoot(); // 0x000000018CDF5D84-0x000000018CDF5DDC
	
		// Methods
		public override bool IsValid(ref string message); // 0x000000018CDF534C-0x000000018CDF59F4
		public override void StoreDefaultLocalState(); // 0x000000018CDF5CEC-0x000000018CDF5D84
		public override void FixTransforms(); // 0x000000018CDF4DCC-0x000000018CDF4E74
		protected override void OnInitiate(); // 0x000000018CDF59F4-0x000000018CDF5ACC
		private bool IsRoot(int index); // 0x000000018CDF52B4-0x000000018CDF534C
		protected override void OnUpdate(); // 0x000000018CDF5ACC-0x000000018CDF5CEC
		public override Point[] GetPoints(); // 0x000000018CDF5218-0x000000018CDF52B4
		public override Point GetPoint(Transform transform); // 0x000000018CDF5194-0x000000018CDF5218
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain); // 0x000000018CDF4CC0-0x000000018CDF4DCC
		private Vector3 GetCentroid(); // 0x000000018CDF4E74-0x000000018CDF5194
	}

	[Serializable]
	public class IKSolverFullBody : IKSolver // TypeDefIndex: 82914
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
		public IKSolverFullBody(); // 0x000000018CDFBDAC-0x000000018CDFBECC
	
		// Methods
		public IKEffector GetEffector(Transform t); // 0x000000018CDFAE78-0x000000018CDFAF3C
		public FBIKChain GetChain(Transform transform); // 0x000000018CDFAE34-0x000000018CDFAE78
		public int GetChainIndex(Transform transform); // 0x000000018CDFAD1C-0x000000018CDFAE34
		public Node GetNode(int chainIndex, int nodeIndex); // 0x000000018CDFAF3C-0x000000018CDFAF84
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex); // 0x000000018CDFAC9C-0x000000018CDFAD1C
		public override Point[] GetPoints(); // 0x000000018CDFB0D4-0x000000018CDFB234
		public override Point GetPoint(Transform transform); // 0x000000018CDFAF84-0x000000018CDFB0D4
		public override bool IsValid(ref string message); // 0x000000018CDFB234-0x000000018CDFB3F8
		public override void StoreDefaultLocalState(); // 0x000000018CDFBC08-0x000000018CDFBCD8
		public override void FixTransforms(); // 0x000000018CDFABB4-0x000000018CDFAC9C
		protected override void OnInitiate(); // 0x000000018CDFB3F8-0x000000018CDFB51C
		protected override void OnUpdate(); // 0x000000018CDFB51C-0x000000018CDFB694
		protected virtual void ReadPose(); // 0x000000018CDFB694-0x000000018CDFB8C4
		protected virtual void Solve(); // 0x000000018CDFB8C4-0x000000018CDFBC08
		protected virtual void ApplyBendConstraints(); // 0x000000018CDFAB78-0x000000018CDFABB4
		protected virtual void WritePose(); // 0x000000018CDFBCD8-0x000000018CDFBDAC
	}

	[Serializable]
	public enum FullBodyBipedEffector // TypeDefIndex: 82915
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
	public enum FullBodyBipedChain // TypeDefIndex: 82916
	{
		LeftArm = 0,
		RightArm = 1,
		LeftLeg = 2,
		RightLeg = 3
	}

	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 82917
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
		public IKEffector bodyEffector { get; } // 0x000000018CDFA99C-0x000000018CDFA9A8 
		public IKEffector leftShoulderEffector { get; } // 0x000000018CDFAA70-0x000000018CDFAA80 
		public IKEffector rightShoulderEffector { get; } // 0x000000018CDFAB58-0x000000018CDFAB68 
		public IKEffector leftThighEffector { get; } // 0x000000018CDFAA80-0x000000018CDFAA90 
		public IKEffector rightThighEffector { get; } // 0x000000018CDFAB68-0x000000018CDFAB78 
		public IKEffector leftHandEffector { get; } // 0x000000018CDFAA0C-0x000000018CDFAA1C 
		public IKEffector rightHandEffector { get; } // 0x000000018CDFAAF4-0x000000018CDFAB04 
		public IKEffector leftFootEffector { get; } // 0x000000018CDFA9FC-0x000000018CDFAA0C 
		public IKEffector rightFootEffector { get; } // 0x000000018CDFAAE4-0x000000018CDFAAF4 
		public FBIKChain leftArmChain { get; } // 0x000000018CDFA9A8-0x000000018CDFA9D0 
		public FBIKChain rightArmChain { get; } // 0x000000018CDFAA90-0x000000018CDFAAB8 
		public FBIKChain leftLegChain { get; } // 0x000000018CDFAA1C-0x000000018CDFAA44 
		public FBIKChain rightLegChain { get; } // 0x000000018CDFAB04-0x000000018CDFAB2C 
		public IKMappingLimb leftArmMapping { get; } // 0x000000018CDFA9D0-0x000000018CDFA9FC 
		public IKMappingLimb rightArmMapping { get; } // 0x000000018CDFAAB8-0x000000018CDFAAE4 
		public IKMappingLimb leftLegMapping { get; } // 0x000000018CDFAA44-0x000000018CDFAA70 
		public IKMappingLimb rightLegMapping { get; } // 0x000000018CDFAB2C-0x000000018CDFAB58 
		public IKMappingBone headMapping { get; } // 0x000000018CDF8A08-0x000000018CDF8A30 
		public Vector3 pullBodyOffset { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187257760-0x0000000187257780 0x0000000187257780-0x00000001872577A0
	
		// Constructors
		public IKSolverFullBodyBiped(); // 0x000000018CDFA980-0x000000018CDFA99C
	
		// Methods
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f /* Metadata: 0x02641753 */); // 0x000000018CDF9118-0x000000018CDF917C
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight); // 0x000000018CDF917C-0x000000018CDF9230
		public FBIKChain GetChain(FullBodyBipedChain c); // 0x000000018CDF8568-0x000000018CDF85E8
		public FBIKChain GetChain(FullBodyBipedEffector effector); // 0x000000018CDF85E8-0x000000018CDF8698
		public IKEffector GetEffector(FullBodyBipedEffector effector); // 0x000000018CDF8698-0x000000018CDF87D0
		public IKEffector GetEndEffector(FullBodyBipedChain c); // 0x000000018CDF87D0-0x000000018CDF8850
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain); // 0x000000018CDF8AD0-0x000000018CDF8B5C
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector); // 0x000000018CDF8B5C-0x000000018CDF8BFC
		public IKMappingSpine GetSpineMapping(); // 0x0000000187232FC0-0x0000000187232FD0
		public IKMappingBone GetHeadMapping(); // 0x000000018CDF8A08-0x000000018CDF8A30
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb); // 0x000000018CDF82C0-0x000000018CDF8348
		public override bool IsValid(ref string message); // 0x000000018CDF8C9C-0x000000018CDF8E30
		public void SetToReferences(BipedReferences references, Transform rootNode = null); // 0x000000018CDF94D0-0x000000018CDFA8AC
		public static Transform DetectRootNodeBone(BipedReferences references); // 0x000000018CDF7F34-0x000000018CDF82C0
		public void SetLimbOrientations(BipedLimbOrientations o); // 0x000000018CDF9464-0x000000018CDF94D0
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation); // 0x000000018CDF9230-0x000000018CDF9464
		private static Transform GetLeftClavicle(BipedReferences references); // 0x000000018CDF8A30-0x000000018CDF8AD0
		private static Transform GetRightClavicle(BipedReferences references); // 0x000000018CDF8BFC-0x000000018CDF8C9C
		private static bool Contains(Transform[] array, Transform transform); // 0x000000018CDF7E90-0x000000018CDF7F34
		protected override void ReadPose(); // 0x000000018CDF9008-0x000000018CDF9118
		private void PullBody(); // 0x000000018CDF8E30-0x000000018CDF9008
		private Vector3 GetBodyOffset(); // 0x000000018CDF8348-0x000000018CDF8568
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset); // 0x000000018CDF8850-0x000000018CDF8A08
		protected override void ApplyBendConstraints(); // 0x000000018CDF7B3C-0x000000018CDF7E90
		protected override void WritePose(); // 0x000000018CDFA8AC-0x000000018CDFA980
	}

	[Serializable]
	public class IKSolverHeuristic : IKSolver // TypeDefIndex: 82918
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
		protected virtual int minBones { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		protected virtual bool boneLengthCanBeZero { get; } // 0x00000001851A4410-0x00000001851A4420 
		protected virtual bool allowCommonParent { get; } // 0x00000001843FFFF0-0x0000000184400000 
		protected virtual Vector3 localDirection { get; } // 0x000000018CDFC6E0-0x000000018CDFC830 
		protected float positionOffset { get; } // 0x000000018CDFC830-0x000000018CDFC8A8 
	
		// Constructors
		public IKSolverHeuristic(); // 0x0000000185CD2B50-0x0000000185CD2BB0
	
		// Methods
		public bool SetChain(Transform[] hierarchy, Transform root); // 0x0000000185CD4750-0x0000000185CD4870
		public void AddBone(Transform bone); // 0x000000018CDFBECC-0x000000018CDFBFD0
		public override void StoreDefaultLocalState(); // 0x0000000185CD4870-0x0000000185CD48D0
		public override void FixTransforms(); // 0x000000018CDFBFD0-0x000000018CDFC03C
		public override bool IsValid(ref string message); // 0x0000000185CD4960-0x0000000185CD4D10
		public override Point[] GetPoints(); // 0x0000000187232FC0-0x0000000187232FD0
		public override Point GetPoint(Transform transform); // 0x000000018CDFC03C-0x000000018CDFC100
		protected override void OnInitiate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnUpdate(); // 0x0000000186805BA0-0x0000000186805BB0
		protected void InitiateBones(); // 0x0000000185CD50A0-0x0000000185CD5630
		protected Vector3 GetSingularityOffset(); // 0x000000018CDFC100-0x000000018CDFC450
		private bool SingularityDetected(); // 0x000000018CDFC450-0x000000018CDFC6E0
	}

	[Serializable]
	public class IKSolverLeg : IKSolver // TypeDefIndex: 82919
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
		public IKSolverLeg(); // 0x000000018CDFD6BC-0x000000018CDFD8B4
	
		// Methods
		public override bool IsValid(ref string message); // 0x000000018CDFCB18-0x000000018CDFCE14
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root); // 0x000000018CDF1C24-0x000000018CDF1CD4
		public override Point[] GetPoints(); // 0x000000018CDFCA14-0x000000018CDFCB18
		public override Point GetPoint(Transform transform); // 0x000000018CDFC8A8-0x000000018CDFCA14
		public override void StoreDefaultLocalState(); // 0x000000018CDF1D54-0x000000018CDF1DB4
		public override void FixTransforms(); // 0x000000018CDF10E4-0x000000018CDF1148
		protected override void OnInitiate(); // 0x000000018CDFCE14-0x000000018CDFCE90
		protected override void OnUpdate(); // 0x000000018CDFCE90-0x000000018CDFCEBC
		private void Solve(); // 0x000000018CDFD380-0x000000018CDFD46C
		private void Read(); // 0x000000018CDFCEBC-0x000000018CDFD380
		private void Write(); // 0x000000018CDFD46C-0x000000018CDFD6BC
	}

	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric // TypeDefIndex: 82922
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
		private AxisDirection[] axisDirections { get; } // 0x000000018CDFD93C-0x000000018CDFD958 
	
		// Nested types
		[Serializable]
		public enum BendModifier // TypeDefIndex: 82920
		{
			Animation = 0,
			Target = 1,
			Parent = 2,
			Arm = 3,
			Goal = 4
		}
	
		[Serializable]
		public struct AxisDirection // TypeDefIndex: 82921
		{
			// Fields
			public Vector3 direction; // 0x00
			public Vector3 axis; // 0x0C
			public float dot; // 0x18
	
			// Constructors
			public AxisDirection(Vector3 direction, Vector3 axis); // 0x0000000185CD3CE0-0x0000000185CD3D40
		}
	
		// Constructors
		public IKSolverLimb(); // 0x000000018CDFD8B4-0x000000018CDFD93C
		public IKSolverLimb(AvatarIKGoal goal); // 0x0000000185CD28A0-0x0000000185CD2940
	
		// Methods
		public void MaintainRotation(); // 0x00000001854AD670-0x00000001854AD6E0
		public void MaintainBend(); // 0x00000001854AD6E0-0x00000001854AD7B0
		protected override void OnInitiateVirtual(); // 0x0000000185CD3200-0x0000000185CD3560
		protected override void OnUpdateVirtual(); // 0x00000001854A9590-0x00000001854A9660
		protected override void OnPostSolveVirtual(); // 0x0000000185DE86A0-0x0000000185DE86F0
		private void StoreAxisDirections(ref AxisDirection[] axisDirections); // 0x0000000185CD39F0-0x0000000185CD3CE0
		private Vector3 GetModifiedBendNormal(); // 0x00000001854A9660-0x00000001854A9800
	}

	[Serializable]
	public class IKSolverLookAt : IKSolver // TypeDefIndex: 82924
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
		public Quaternion[] spineVirtualBone { get; set; } // 0x0000000185764300-0x00000001857643E0 0x0000000186B19440-0x0000000186B19450
		public Quaternion headVirtualBones { get; set; } // 0x000000018723C550-0x000000018723C560 0x00000001872577B0-0x00000001872577C0
		public Quaternion eyeVirtualBone { get; set; } // 0x000000018724BCC0-0x000000018724BCD0 0x0000000187233B50-0x0000000187233B60
		protected bool spineIsValid { get; } // 0x0000000185CD5BF0-0x0000000185CD5D00 
		protected bool spineIsEmpty { get; } // 0x00000001854A9800-0x00000001854A9830 
		protected bool headIsValid { get; } // 0x0000000185CD5AD0-0x0000000185CD5AE0 
		protected bool headIsEmpty { get; } // 0x00000001854A9830-0x00000001854A98B0 
		protected bool eyesIsValid { get; } // 0x0000000185CD5AE0-0x0000000185CD5BF0 
		protected bool eyesIsEmpty { get; } // 0x00000001854A8970-0x00000001854A89A0 
	
		// Nested types
		[Serializable]
		public class LookAtBone : IKSolver.Bone // TypeDefIndex: 82923
		{
			// Fields
			public Vector3 positionOffset; // 0x80
			public Vector3 baseForwardOffsetEuler; // 0x8C
	
			// Properties
			public Vector3 forward { get; } // 0x000000018509FC40-0x000000018509FCE0 
	
			// Constructors
			public LookAtBone(); // 0x0000000185CD2E30-0x0000000185CD2E50
			public LookAtBone(Transform transform); // 0x0000000185CD24D0-0x0000000185CD2520
	
			// Methods
			public void Initiate(Transform root); // 0x0000000185CD6360-0x0000000185CD64D0
			public void LookAt(Vector3 direction, float weight); // 0x000000018509F890-0x000000018509FA80
			public Quaternion LookAtReturnRotation(Vector3 direction, float weight); // 0x000000018CE037C8-0x000000018CE038C8
		}
	
		// Constructors
		public IKSolverLookAt(); // 0x0000000185CD2BB0-0x0000000185CD2E30
	
		// Methods
		public void SetLookAtWeight(float weight); // 0x0000000186D24A90-0x0000000186D24AC0
		public void SetLookAtWeight(float weight, float bodyWeight); // 0x000000018CDFDC74-0x000000018CDFDCBC
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight); // 0x000000018CDFDD64-0x000000018CDFDDC8
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight); // 0x000000018CDFDEA0-0x000000018CDFDF18
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight); // 0x000000018CDFDCBC-0x000000018CDFDD64
		public void SetLookAtWeight(float weight, float bodyWeight = 0f /* Metadata: 0x0264175C */, float headWeight = 1f /* Metadata: 0x02641760 */, float eyesWeight = 0.5f /* Metadata: 0x02641764 */, float clampWeight = 0.5f /* Metadata: 0x02641768 */, float clampWeightHead = 0.5f /* Metadata: 0x0264176C */, float clampWeightEyes = 0.3f /* Metadata: 0x02641770 */); // 0x000000018CDFDDC8-0x000000018CDFDEA0
		public override void StoreDefaultLocalState(); // 0x0000000185CD45D0-0x0000000185CD4750
		public void SetDirty(); // 0x00000001872577A0-0x00000001872577B0
		public override void FixTransforms(); // 0x0000000185764100-0x0000000185764300
		public override bool IsValid(ref string message); // 0x0000000185CD3EC0-0x0000000185CD4090
		public override Point[] GetPoints(); // 0x000000018CDFDAA0-0x000000018CDFDC74
		public override Point GetPoint(Transform transform); // 0x000000018CDFD958-0x000000018CDFDAA0
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root); // 0x0000000185CD2310-0x0000000185CD23E0
		protected override void OnInitiate(); // 0x0000000185CD60D0-0x0000000185CD6360
		protected override void OnUpdate(); // 0x00000001854A8540-0x00000001854A8670
		protected void SolveSpine(); // 0x00000001854A9040-0x00000001854A9590
		protected void SolveHead(); // 0x00000001854A89A0-0x00000001854A9040
		protected void SolveEyes(); // 0x00000001854A8670-0x00000001854A8970
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp); // 0x00000001850DE4E0-0x00000001850DE820
		protected void SetBones(Transform[] array, ref LookAtBone[] bones); // 0x0000000185CD23E0-0x0000000185CD24D0
	}

	[Serializable]
	public class IKSolverTrigonometric : IKSolver // TypeDefIndex: 82926
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
		public class TrigonometricBone : IKSolver.Bone // TypeDefIndex: 82925
		{
			// Fields
			private Quaternion targetToLocalSpace; // 0x80
			private Vector3 defaultLocalBendNormal; // 0x90
	
			// Constructors
			public TrigonometricBone(); // 0x000000018783A024-0x000000018783A02C
	
			// Methods
			public void Initiate(Vector3 childPosition, Vector3 bendNormal); // 0x0000000185764C00-0x0000000185764E10
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal); // 0x00000001855482F0-0x0000000185548390
			public Vector3 GetBendNormalFromCurrentRotation(); // 0x00000001854AD7B0-0x00000001854AD860
		}
	
		// Constructors
		public IKSolverTrigonometric(); // 0x0000000185CD2940-0x0000000185CD2A60
	
		// Methods
		public void SetBendGoalPosition(Vector3 goalPosition, float weight); // 0x000000018CDFE290-0x000000018CDFE49C
		public void SetBendPlaneToCurrent(); // 0x0000000185764EC0-0x0000000185764EF0
		public void SetIKRotation(Quaternion rotation); // 0x00000001872577D0-0x00000001872577E0
		public void SetIKRotationWeight(float weight); // 0x000000018CDFE49C-0x000000018CDFE4C0
		public Quaternion GetIKRotation(); // 0x00000001872577C0-0x00000001872577D0
		public float GetIKRotationWeight(); // 0x00000001872352B0-0x00000001872352C0
		public override Point[] GetPoints(); // 0x000000018CDFE1CC-0x000000018CDFE290
		public override Point GetPoint(Transform transform); // 0x000000018CDFE0D4-0x000000018CDFE1CC
		public override void StoreDefaultLocalState(); // 0x0000000185CD5750-0x0000000185CD57A0
		public override void FixTransforms(); // 0x000000018514E1E0-0x000000018514E660
		public override bool IsValid(ref string message); // 0x0000000185A15980-0x0000000185A15E90
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root); // 0x0000000185CD3180-0x0000000185CD3200
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight); // 0x000000018CDFE4C0-0x000000018CDFE9AC
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2); // 0x000000018CDFDF18-0x000000018CDFE0D4
		protected override void OnInitiate(); // 0x0000000185764A10-0x0000000185764B00
		private bool IsDirectHierarchy(); // 0x0000000185764EF0-0x0000000185765010
		public void InitiateBones(); // 0x0000000185764B00-0x0000000185764C00
		protected override void OnUpdate(); // 0x0000000185028670-0x0000000185029010
		protected virtual void OnInitiateVirtual(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnUpdateVirtual(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnPostSolveVirtual(); // 0x0000000186805BA0-0x0000000186805BB0
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal); // 0x0000000185547FD0-0x00000001855482F0
	}

	[Serializable]
	public class IKSolverVR : IKSolver // TypeDefIndex: 82938
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
		public Animator animator { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		[HideInInspector]
		public VirtualBone rootBone { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872360B0-0x00000001872360C0 0x0000000188C247F0-0x0000000188C24804
	
		// Nested types
		[Serializable]
		public class Arm : BodyPart // TypeDefIndex: 82928
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
			public Vector3 position { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872577E0-0x0000000187257800 0x0000000187257800-0x0000000187257820
			public Quaternion rotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724ED90-0x000000018724EDA0 0x0000000187257820-0x0000000187257830
			private VirtualBone shoulder { get; } // 0x000000018CE06F84-0x000000018CE06FAC 
			private VirtualBone upperArm { get; } // 0x000000018CE06FAC-0x000000018CE06FF4 
			private VirtualBone forearm { get; } // 0x000000018CE06EEC-0x000000018CE06F38 
			private VirtualBone hand { get; } // 0x000000018CE06F38-0x000000018CE06F84 
	
			// Nested types
			[Serializable]
			public enum ShoulderRotationMode // TypeDefIndex: 82927
			{
				YawPitch = 0,
				FromTo = 1
			}
	
			// Constructors
			public Arm(); // 0x000000018CE06DB4-0x000000018CE06EEC
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x000000018CE03FC4-0x000000018CE049C4
			public override void PreSolve(float scale); // 0x000000018CE049C4-0x000000018CE04BF8
			public override void ApplyOffsets(float scale); // 0x000000018CE038C8-0x000000018CE03930
			private void Stretching(); // 0x000000018CE0659C-0x000000018CE06A5C
			public void Solve(bool isLeft); // 0x000000018CE04C14-0x000000018CE0659C
			public override void ResetOffsets(); // 0x000000018CE04BF8-0x000000018CE04C14
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x000000018CE06B74-0x000000018CE06DB4
			private float DamperValue(float value, float min, float max, float weight = 1f /* Metadata: 0x02641774 */); // 0x000000018CE03930-0x000000018CE039D8
			private Vector3 GetBendNormal(Vector3 dir); // 0x000000018CE039D8-0x000000018CE03FC4
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, UnityEngine.Color color); // 0x000000018CE06A5C-0x000000018CE06B74
		}
	
		[Serializable]
		public abstract class BodyPart // TypeDefIndex: 82929
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
			public float sqrMag { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232D00-0x0000000187232D10 0x0000000187235230-0x0000000187235240
			public float mag { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187235C60-0x0000000187235C70 0x0000000187235C70-0x0000000187235C80
	
			// Constructors
			protected BodyPart(); // 0x000000018CE076DC-0x000000018CE0773C
	
			// Methods
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);
			public abstract void PreSolve(float scale);
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);
			public abstract void ApplyOffsets(float scale);
			public abstract void ResetOffsets();
			public void SetLOD(int LOD); // 0x0000000182271C60-0x0000000182271C70
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x000000018CE071A8-0x000000018CE072B0
			public void MovePosition(Vector3 position); // 0x000000018CE06FF4-0x000000018CE070E8
			public void MoveRotation(Quaternion rotation); // 0x000000018CE070E8-0x000000018CE071A8
			public void Translate(Vector3 position, Quaternion rotation); // 0x000000018CE07540-0x000000018CE07594
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot); // 0x000000018CE073DC-0x000000018CE07540
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f /* Metadata: 0x0264177A */); // 0x000000018CE072B0-0x000000018CE073DC
			public void Visualize(UnityEngine.Color color); // 0x000000018CE07594-0x000000018CE076AC
			public void Visualize(); // 0x000000018CE076AC-0x000000018CE076DC
		}
	
		[Serializable]
		public class Footstep // TypeDefIndex: 82930
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
			public bool isStepping { get; } // 0x000000018CE07CF4-0x000000018CE07D04 
			public float stepProgress { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
	
			// Constructors
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset); // 0x000000018CE07BD0-0x000000018CE07CF4
	
			// Methods
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation); // 0x0000000187257830-0x0000000187257880
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold); // 0x000000018CE0773C-0x000000018CE07868
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime); // 0x000000018CE07960-0x000000018CE07A78
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime); // 0x000000018CE07868-0x000000018CE07960
			public void Update(RootMotion.InterpolationMode interpolation, UnityEvent onStep, float deltaTime); // 0x000000018CE07A78-0x000000018CE07BD0
		}
	
		[Serializable]
		public class Leg : BodyPart // TypeDefIndex: 82931
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
			public Vector3 position { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724C500-0x000000018724C520 0x000000018724C5A0-0x000000018724C5C0
			public Quaternion rotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724C890-0x000000018724C8A0 0x0000000187233B40-0x0000000187233B50
			public bool hasToes { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872354F0-0x0000000187235500 0x0000000187235540-0x0000000187235550
			public VirtualBone thigh { get; } // 0x000000018CE06F84-0x000000018CE06FAC 
			private VirtualBone calf { get; } // 0x000000018A83E1C8-0x000000018A83E1F0 
			private VirtualBone foot { get; } // 0x000000018CE0C260-0x000000018CE0C288 
			private VirtualBone toes { get; } // 0x000000018CE0C2B8-0x000000018CE0C2E0 
			public VirtualBone lastBone { get; } // 0x000000018CE0C288-0x000000018CE0C2B8 
			public Vector3 thighRelativeToPelvis { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187257760-0x0000000187257780 0x0000000187257780-0x00000001872577A0
			public Vector3 bendNormalRelToPelvis { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187257880-0x00000001872578A0 0x00000001872578C0-0x00000001872578E0
			public Vector3 bendNormalRelToTarget { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872578A0-0x00000001872578C0 0x00000001872578E0-0x0000000187257900
	
			// Constructors
			public Leg(); // 0x000000018CE0C174-0x000000018CE0C260
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x000000018CE0A86C-0x000000018CE0B0A8
			public override void PreSolve(float scale); // 0x000000018CE0B0A8-0x000000018CE0B680
			public override void ApplyOffsets(float scale); // 0x000000018CE09BF0-0x000000018CE0A234
			private void ApplyPositionOffset(Vector3 offset, float weight); // 0x000000018CE0A234-0x000000018CE0A31C
			private void ApplyRotationOffset(Quaternion offset, float weight); // 0x000000018CE0A31C-0x000000018CE0A4F8
			public void Solve(bool stretch); // 0x000000018CE0B6E8-0x000000018CE0B978
			private void FixTwistRotations(); // 0x000000018CE0A4F8-0x000000018CE0A86C
			private void Stretching(); // 0x000000018CE0B978-0x000000018CE0BF30
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x000000018CE0BF30-0x000000018CE0C174
			public override void ResetOffsets(); // 0x000000018CE0B680-0x000000018CE0B6E8
		}
	
		[Serializable]
		public class Locomotion // TypeDefIndex: 82933
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
			public Vector3 centerOfMass { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723EED0-0x000000018723EEF0 0x000000018723EF50-0x000000018723EF70
			public Vector3 leftFootstepPosition { get; } // 0x000000018CE1058C-0x000000018CE105D0 
			public Vector3 rightFootstepPosition { get; } // 0x000000018CE10610-0x000000018CE10654 
			public Quaternion leftFootstepRotation { get; } // 0x000000018CE105D0-0x000000018CE10610 
			public Quaternion rightFootstepRotation { get; } // 0x000000018CE10654-0x000000018CE10694 
	
			// Nested types
			[Serializable]
			public enum Mode // TypeDefIndex: 82932
			{
				Procedural = 0,
				Animated = 1
			}
	
			// Constructors
			public Locomotion(); // 0x000000018CE103E0-0x000000018CE1058C
	
			// Methods
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale); // 0x000000018CE0D220-0x000000018CE0D280
			public void Reset(Vector3[] positions, Quaternion[] rotations); // 0x000000018CE0D8A8-0x000000018CE0D8D8
			public void Relax(); // 0x000000018CE0D2D4-0x000000018CE0D2DC
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot); // 0x000000018CE0CC24-0x000000018CE0CCA8
			public void AddDeltaPosition(Vector3 delta); // 0x000000018CE0C578-0x000000018CE0C5D4
			public void Initiate_Animated(Animator animator, Vector3[] positions); // 0x000000018CE0CE98-0x000000018CE0CF4C
			private void ResetParams(Vector3[] positions); // 0x000000018CE0D2DC-0x000000018CE0D39C
			public void Reset_Animated(Vector3[] positions); // 0x000000018CE0D39C-0x000000018CE0D604
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot); // 0x000000018CE0C5D4-0x000000018CE0C7FC
			private void AddDeltaPosition_Animated(Vector3 delta); // 0x000000018CE0C2E0-0x000000018CE0C3E4
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime); // 0x000000018CE0D8D8-0x000000018CE0E8E0
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale); // 0x000000018CE0CF4C-0x000000018CE0D220
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations); // 0x000000018CE0D604-0x000000018CE0D8A8
			private void Relax_Procedural(); // 0x000000018CE0D280-0x000000018CE0D2D4
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot); // 0x000000018CE0C7FC-0x000000018CE0CC24
			private void AddDeltaPosition_Procedural(Vector3 delta); // 0x000000018CE0C3E4-0x000000018CE0C578
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime); // 0x000000018CE0E8E0-0x000000018CE1024C
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition); // 0x000000018CE1024C-0x000000018CE103E0
			private bool CanStep(); // 0x000000018CE0CCA8-0x000000018CE0CD08
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius); // 0x000000018CE0CD08-0x000000018CE0CE98
		}
	
		[Serializable]
		public class Spine : BodyPart // TypeDefIndex: 82934
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
			internal VirtualBone pelvis { get; } // 0x000000018CE14270-0x000000018CE142A0 
			internal VirtualBone firstSpineBone { get; } // 0x000000018CE141E0-0x000000018CE14210 
			internal VirtualBone chest { get; } // 0x000000018CE1419C-0x000000018CE141E0 
			internal VirtualBone head { get; } // 0x000000018CE14210-0x000000018CE14240 
			private VirtualBone neck { get; } // 0x000000018CE14240-0x000000018CE14270 
			internal Quaternion anchorRotation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187257910-0x0000000187257920 0x0000000187257930-0x0000000187257940
			internal Quaternion anchorRelativeToHead { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187257900-0x0000000187257910 0x0000000187257920-0x0000000187257930
	
			// Constructors
			public Spine(); // 0x000000018CE13FE0-0x000000018CE1419C
	
			// Methods
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index); // 0x000000018CE11D74-0x000000018CE128DC
			public override void PreSolve(float scale); // 0x000000018CE128DC-0x000000018CE12E64
			public override void ApplyOffsets(float scale); // 0x000000018CE10A70-0x000000018CE10FD8
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms); // 0x000000018CE11484-0x000000018CE1164C
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale); // 0x000000018CE1323C-0x000000018CE13964
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight); // 0x000000018CE1164C-0x000000018CE11870
			private void SolvePelvis(); // 0x000000018CE12F18-0x000000018CE1323C
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations); // 0x000000018CE13DD4-0x000000018CE13FE0
			public override void ResetOffsets(); // 0x000000018CE12E64-0x000000018CE12F18
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms); // 0x000000018CE10694-0x000000018CE10A70
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w); // 0x000000018CE11870-0x000000018CE11A04
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale); // 0x000000018CE13964-0x000000018CE13DD4
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2 /* Metadata: 0x02641780 */); // 0x000000018CE11A04-0x000000018CE11D74
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w); // 0x000000018CE10FD8-0x000000018CE11204
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w); // 0x000000018CE11204-0x000000018CE11484
		}
	
		[Serializable]
		public enum PositionOffset // TypeDefIndex: 82935
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
		public enum RotationOffset // TypeDefIndex: 82936
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2
		}
	
		[Serializable]
		public class VirtualBone // TypeDefIndex: 82937
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
			public VirtualBone(Vector3 position, Quaternion rotation); // 0x0000000187257940-0x0000000187257970
	
			// Methods
			public void Read(Vector3 position, Quaternion rotation); // 0x0000000187257940-0x0000000187257970
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f /* Metadata: 0x0264178D */); // 0x000000018CE16A04-0x000000018CE16BC8
			public static float PreSolve(ref VirtualBone[] bones); // 0x000000018CE15508-0x000000018CE15794
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation); // 0x000000018CE15794-0x000000018CE15918
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation); // 0x000000018CE15918-0x000000018CE15AD4
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation); // 0x000000018CE15AD4-0x000000018CE15C8C
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation); // 0x000000018CE15C8C-0x000000018CE15D48
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight); // 0x000000018CE164C8-0x000000018CE16A04
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2); // 0x000000018CE1534C-0x000000018CE15508
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset); // 0x000000018CE16034-0x000000018CE164C8
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018CE15F50-0x000000018CE16034
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations); // 0x000000018CE15D48-0x000000018CE15F50
		}
	
		// Constructors
		public IKSolverVR(); // 0x000000018CE034B0-0x000000018CE037C8
	
		// Methods
		public void SetToReferences(VRIK.References references); // 0x000000018CE01094-0x000000018CE01398
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero); // 0x000000018CDFFE74-0x000000018CE001C0
		public void DefaultAnimationCurves(); // 0x000000018CDFEF54-0x000000018CDFF10C
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value); // 0x000000018CDFEAF8-0x000000018CDFEE04
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value); // 0x000000018CDFEE04-0x000000018CDFEE5C
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value); // 0x000000018CDFEE5C-0x000000018CDFEF54
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot); // 0x000000018CDFE9AC-0x000000018CDFEAF8
		public void Reset(); // 0x000000018CE00F5C-0x000000018CE01094
		public override void StoreDefaultLocalState(); // 0x000000018CE02BF8-0x000000018CE02D54
		public override void FixTransforms(); // 0x000000018CDFF10C-0x000000018CDFF2F8
		public override Point[] GetPoints(); // 0x000000018CDFFCF4-0x000000018CDFFD44
		public override Point GetPoint(Transform transform); // 0x000000018CDFFCA4-0x000000018CDFFCF4
		public override bool IsValid(ref string message); // 0x000000018CE001C0-0x000000018CE00444
		private Vector3 GetNormal(Transform[] transforms); // 0x000000018CDFF2F8-0x000000018CDFF5B0
		private static Keyframe[] GetSineKeyframes(float mag); // 0x000000018CDFFDA4-0x000000018CDFFE74
		private void UpdateSolverTransforms(); // 0x000000018CE02D54-0x000000018CE02E9C
		protected override void OnInitiate(); // 0x000000018CE00444-0x000000018CE0049C
		protected override void OnUpdate(); // 0x000000018CE0049C-0x000000018CE009E8
		private void WriteTransforms(); // 0x000000018CE02E9C-0x000000018CE03350
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms); // 0x000000018CE009E8-0x000000018CE00F5C
		private void Solve(); // 0x000000018CE01398-0x000000018CE02BF8
		private Vector3 GetPosition(int index); // 0x000000018CDFFD44-0x000000018CDFFD74
		private Quaternion GetRotation(int index); // 0x000000018CDFFD74-0x000000018CDFFDA4
		private void Write(); // 0x000000018CE03350-0x000000018CE034B0
		private Vector3 GetPelvisOffset(float deltaTime); // 0x000000018CDFF5B0-0x000000018CDFFCA4
	}

	public class TwistRelaxer : MonoBehaviour // TypeDefIndex: 82939
	{
		// Fields
		public IK ik; // 0x18
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers; // 0x20
	
		// Constructors
		public TwistRelaxer(); // 0x000000018CE1476C-0x000000018CE147BC
	
		// Methods
		public void Start(); // 0x000000018CE144FC-0x000000018CE146C4
		private void Update(); // 0x000000018CE146C4-0x000000018CE1476C
		private void OnPostUpdate(); // 0x000000018CE14464-0x000000018CE144FC
		private void LateUpdate(); // 0x000000018CE142A0-0x000000018CE14338
		private void OnDestroy(); // 0x000000018CE14338-0x000000018CE14464
	}

	[Serializable]
	public class TwistSolver // TypeDefIndex: 82940
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
		public TwistSolver(); // 0x000000018CE152B0-0x000000018CE1534C
	
		// Methods
		public void Initiate(); // 0x000000018CE14880-0x000000018CE14E40
		public void FixTransforms(); // 0x000000018CE147BC-0x000000018CE14880
		public void Relax(); // 0x000000018CE14E40-0x000000018CE152B0
	}

	[Serializable]
	public class InteractionEffector // TypeDefIndex: 82941
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
		public FullBodyBipedEffector effectorType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public bool isPaused { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187239C50-0x0000000187239C60 0x000000018723C800-0x000000018723C810
		public InteractionObject interactionObject { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public bool inInteraction { get; } // 0x000000018CE09B68-0x000000018CE09BB8 
		public float progress { get; } // 0x000000018CE09BB8-0x000000018CE09BF0 
	
		// Constructors
		public InteractionEffector(FullBodyBipedEffector effectorType); // 0x000000018CE09ADC-0x000000018CE09B68
	
		// Methods
		public void Initiate(InteractionSystem interactionSystem); // 0x000000018CE07D04-0x000000018CE07DBC
		private void StoreDefaults(); // 0x000000018CE08FC0-0x000000018CE091B0
		public bool ResetToDefaults(float speed, float deltaTime); // 0x000000018CE08490-0x000000018CE08900
		public bool Pause(); // 0x000000018CE080B0-0x000000018CE081D4
		public bool Resume(); // 0x000000018CE08900-0x000000018CE08958
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt); // 0x000000018CE08D88-0x000000018CE08E94
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt); // 0x000000018CE08958-0x000000018CE08D88
		public void Update(Transform root, float speed, float deltaTime); // 0x000000018CE0943C-0x000000018CE09ADC
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause); // 0x000000018CE091B0-0x000000018CE0943C
		private void PickUp(Transform root); // 0x000000018CE081D4-0x000000018CE08490
		public bool Stop(); // 0x000000018CE08E94-0x000000018CE08FC0
		public void OnPostFBBIK(); // 0x000000018CE07DBC-0x000000018CE080B0
	}

	[Serializable]
	public class InteractionLookAt // TypeDefIndex: 82942
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
		public InteractionLookAt(); // 0x0000000187257A70-0x0000000187257A80
	
		// Methods
		public void Look(Transform target, float time); // 0x000000018CE1CA28-0x000000018CE1CBB4
		public void OnFixTransforms(); // 0x000000018CE1CBB4-0x000000018CE1CC34
		public void Update(); // 0x000000018CE1CE18-0x000000018CE1D03C
		public void SolveSpine(); // 0x000000018CE1CCFC-0x000000018CE1CE18
		public void SolveHead(); // 0x000000018CE1CC34-0x000000018CE1CCFC
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour // TypeDefIndex: 82949
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
		public float length { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public InteractionSystem lastUsedInteractionSystem { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public Transform lookAtTarget { get; } // 0x000000018CE1E3C0-0x000000018CE1E428 
		public Transform targetsRoot { get; } // 0x000000018CE1E428-0x000000018CE1E490 
	
		// Nested types
		[Serializable]
		public class InteractionEvent // TypeDefIndex: 82943
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
			public InteractionEvent(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Activate(Transform t); // 0x000000018CE1C970-0x000000018CE1CA28
		}
	
		[Serializable]
		public class Message // TypeDefIndex: 82944
		{
			// Fields
			[Tooltip("The name of the function called.")]
			public string function; // 0x10
			[Tooltip("The recipient game object.")]
			public GameObject recipient; // 0x18
			private const string empty = ""; // Metadata: 0x02641791
	
			// Constructors
			public Message(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Send(Transform t); // 0x000000018CE23988-0x000000018CE23A64
		}
	
		[Serializable]
		public class AnimatorEvent // TypeDefIndex: 82945
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
			private const string empty = ""; // Metadata: 0x02641792
	
			// Constructors
			public AnimatorEvent(); // 0x0000000187257970-0x0000000187257980
	
			// Methods
			public void Activate(bool pickUp); // 0x000000018CE17FB4-0x000000018CE18074
			private void Activate(Animator animator); // 0x000000018CE18074-0x000000018CE18118
			private void Activate(Animation animation); // 0x000000018CE17EF8-0x000000018CE17FB4
		}
	
		[Serializable]
		public class WeightCurve // TypeDefIndex: 82947
		{
			// Fields
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type; // 0x10
			[Tooltip("The weight curve.")]
			public AnimationCurve curve; // 0x18
	
			// Nested types
			[Serializable]
			public enum Type // TypeDefIndex: 82946
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
			public WeightCurve(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public float GetValue(float timer); // 0x000000018CE28F94-0x000000018CE28FB4
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 82948
		{
			// Fields
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve; // 0x10
			[Tooltip("The multiplier of the curve\'s value.")]
			public float multiplier; // 0x14
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result; // 0x18
	
			// Constructors
			public Multiplier(); // 0x000000018723C870-0x000000018723C880
	
			// Methods
			public float GetValue(WeightCurve weightCurve, float timer); // 0x000000018CE23A64-0x000000018CE23A94
		}
	
		// Constructors
		public InteractionObject(); // 0x000000018CE1E370-0x000000018CE1E3C0
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018CE1E300-0x000000018CE1E334
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018CE1E1FC-0x000000018CE1E230
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1(); // 0x000000018CE1E230-0x000000018CE1E264
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2(); // 0x000000018CE1E264-0x000000018CE1E298
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3(); // 0x000000018CE1E298-0x000000018CE1E2CC
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4(); // 0x000000018CE1E2CC-0x000000018CE1E300
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CE1E33C-0x000000018CE1E370
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CE1D03C-0x000000018CE1D070
		public void Initiate(); // 0x000000018CE1E044-0x000000018CE1E1FC
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem); // 0x000000018CE1DC44-0x000000018CE1DD88
		public bool CurveUsed(WeightCurve.Type type); // 0x000000018CE1DA54-0x000000018CE1DAD0
		public InteractionTarget[] GetTargets(); // 0x0000000187232F70-0x0000000187232F80
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag); // 0x000000018CE1DB24-0x000000018CE1DC44
		public void OnStartInteraction(InteractionSystem interactionSystem); // 0x00000001869E1E00-0x00000001869E1E10
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight); // 0x000000018CE1D070-0x000000018CE1D4B8
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer); // 0x000000018CE1DDE8-0x000000018CE1DFF0
		private void Start(); // 0x000000018CE1E334-0x000000018CE1E33C
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight); // 0x000000018CE1D4B8-0x000000018CE1DA54
		private Transform GetTarget(FullBodyBipedEffector effectorType); // 0x000000018CE1DD88-0x000000018CE1DDE8
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType); // 0x000000018CE1DFF0-0x000000018CE1E044
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType); // 0x000000018CE1DAD0-0x000000018CE1DB24
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour // TypeDefIndex: 82952
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
		public bool inInteraction { get; } // 0x000000018CE21DB0-0x000000018CE21E48 
		public FullBodyBipedIK ik { get; set; } // 0x0000000187234580-0x0000000187234590 0x0000000188A79A0C-0x0000000188A79A20
		public List<InteractionTrigger> triggersInRange { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public bool initiated { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018299E130-0x000000018299E140 0x000000018299E140-0x000000018299E150
	
		// Nested types
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // TypeDefIndex: 82950; 0x00000001859B7730-0x00000001859B7740
	
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent); // TypeDefIndex: 82951; 0x00000001811DF7F0-0x00000001811DF810
	
		// Constructors
		public InteractionSystem(); // 0x000000018CE219D0-0x000000018CE21DB0
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018CE1FDC0-0x000000018CE1FDF4
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018CE1FCBC-0x000000018CE1FCF0
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1(); // 0x000000018CE1FCF0-0x000000018CE1FD24
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2(); // 0x000000018CE1FD24-0x000000018CE1FD58
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3(); // 0x000000018CE1FD58-0x000000018CE1FD8C
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4(); // 0x000000018CE1FD8C-0x000000018CE1FDC0
		[ContextMenu("Support")]
		private void SupportGroup(); // 0x000000018CE209EC-0x000000018CE20A20
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CE1E490-0x000000018CE1E4C4
		public bool IsInInteraction(FullBodyBipedEffector effectorType); // 0x000000018CE1EF50-0x000000018CE1F00C
		public bool IsPaused(FullBodyBipedEffector effectorType); // 0x000000018CE1F1B4-0x000000018CE1F26C
		public bool IsPaused(); // 0x000000018CE1F11C-0x000000018CE1F1B4
		public bool IsInSync(); // 0x000000018CE1F00C-0x000000018CE1F11C
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt); // 0x000000018CE201B8-0x000000018CE202AC
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt); // 0x000000018CE200C0-0x000000018CE201B8
		public bool PauseInteraction(FullBodyBipedEffector effectorType); // 0x000000018CE1FE60-0x000000018CE1FEE4
		public bool ResumeInteraction(FullBodyBipedEffector effectorType); // 0x000000018CE2003C-0x000000018CE200C0
		public bool StopInteraction(FullBodyBipedEffector effectorType); // 0x000000018CE20968-0x000000018CE209EC
		public void PauseAll(); // 0x000000018CE1FDF4-0x000000018CE1FE60
		public void ResumeAll(); // 0x000000018CE1FFD0-0x000000018CE2003C
		public void StopAll(); // 0x000000018CE20908-0x000000018CE20968
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType); // 0x000000018CE1EC4C-0x000000018CE1ECCC
		public float GetProgress(FullBodyBipedEffector effectorType); // 0x000000018CE1ED88-0x000000018CE1EE0C
		public float GetMinActiveProgress(); // 0x000000018CE1ECCC-0x000000018CE1ED88
		public bool TriggerInteraction(int index, bool interrupt); // 0x000000018CE2128C-0x000000018CE2142C
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject); // 0x000000018CE20E04-0x000000018CE20FF8
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget); // 0x000000018CE20FF8-0x000000018CE2128C
		public InteractionTrigger.Range GetClosestInteractionRange(); // 0x000000018CE1E7AC-0x000000018CE1E884
		public InteractionObject GetClosestInteractionObjectInRange(); // 0x000000018CE1E674-0x000000018CE1E6B4
		public InteractionTarget GetClosestInteractionTargetInRange(); // 0x000000018CE1E884-0x000000018CE1E8F4
		public InteractionObject[] GetClosestInteractionObjectsInRange(); // 0x000000018CE1E6B4-0x000000018CE1E7AC
		public InteractionTarget[] GetClosestInteractionTargetsInRange(); // 0x000000018CE1E8F4-0x000000018CE1EA68
		public bool TriggerEffectorsReady(int index); // 0x000000018CE20A20-0x000000018CE20D1C
		public InteractionTrigger.Range GetTriggerRange(int index); // 0x000000018CE1EE0C-0x000000018CE1EF10
		public int GetClosestTriggerIndex(); // 0x000000018CE1EA68-0x000000018CE1EC4C
		public void Start(); // 0x000000018CE202AC-0x000000018CE20908
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018CE1EF10-0x000000018CE1EF30
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018CE1EF30-0x000000018CE1EF50
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018CE1EF30-0x000000018CE1EF50
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject); // 0x000000018CE1F334-0x000000018CE1F3A0
		public void OnTriggerEnter(Collider c); // 0x000000018CE1FAF4-0x000000018CE1FBEC
		public void OnTriggerExit(Collider c); // 0x000000018CE1FBEC-0x000000018CE1FCBC
		private bool ContactIsInRange(int index, out int bestRangeIndex); // 0x000000018CE1E4C4-0x000000018CE1E674
		private void OnDrawGizmosSelected(); // 0x000000018CE1F8A0-0x000000018CE1F980
		public void Update(); // 0x000000018CE217B8-0x000000018CE219D0
		private void Raycasting(); // 0x000000018CE1FEE4-0x000000018CE1FFD0
		private void UpdateTriggerEventBroadcasting(); // 0x000000018CE2156C-0x000000018CE217B8
		private void OnEnable(); // 0x000000018CE1F980-0x000000018CE1F9A0
		private void UpdateEffectors(); // 0x000000018CE2142C-0x000000018CE2156C
		private void OnPreFBBIK(); // 0x000000018CE1FA78-0x000000018CE1FAF4
		private void OnPostFBBIK(); // 0x000000018CE1F9C4-0x000000018CE1FA78
		private void OnFixTransforms(); // 0x000000018CE1F9A0-0x000000018CE1F9C4
		private void OnDestroy(); // 0x000000018CE1F3A0-0x000000018CE1F8A0
		private bool IsValid(bool log); // 0x000000018CE1F26C-0x000000018CE1F334
		private bool TriggerIndexIsValid(int index); // 0x000000018CE20D1C-0x000000018CE20E04
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour // TypeDefIndex: 82955
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
		public enum RotationMode // TypeDefIndex: 82953
		{
			TwoDOF = 0,
			ThreeDOF = 1
		}
	
		[Serializable]
		public class Multiplier // TypeDefIndex: 82954
		{
			// Fields
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve; // 0x10
			[Tooltip("Multiplier of the curve\'s value.")]
			public float multiplier; // 0x14
	
			// Constructors
			public Multiplier(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public InteractionTarget(); // 0x000000018CE22758-0x000000018CE227A4
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018CE21FE8-0x000000018CE2201C
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018CE21EE4-0x000000018CE21F18
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1(); // 0x000000018CE21F18-0x000000018CE21F4C
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2(); // 0x000000018CE21F4C-0x000000018CE21F80
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3(); // 0x000000018CE21F80-0x000000018CE21FB4
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4(); // 0x000000018CE21FB4-0x000000018CE21FE8
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CE22724-0x000000018CE22758
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CE21E48-0x000000018CE21E7C
		public float GetValue(InteractionObject.WeightCurve.Type curveType); // 0x000000018CE21E7C-0x000000018CE21EE4
		public void ResetRotation(); // 0x000000018CE2201C-0x000000018CE22098
		public void RotateTo(Transform bone); // 0x000000018CE22098-0x000000018CE22724
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour // TypeDefIndex: 82960
	{
		// Fields
		[Tooltip("The valid ranges of the character\'s and/or its camera\'s position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges; // 0x18
	
		// Nested types
		[Serializable]
		public class CharacterPosition // TypeDefIndex: 82956
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
			public Vector3 offset3D { get; } // 0x0000000187257A20-0x0000000187257A40 
			public Vector3 direction3D { get; } // 0x000000018CE19DF8-0x000000018CE19E88 
	
			// Constructors
			public CharacterPosition(); // 0x0000000187257A10-0x0000000187257A20
	
			// Methods
			public bool IsInRange(Transform character, Transform trigger, out float error); // 0x000000018CE197A0-0x000000018CE19DF8
		}
	
		[Serializable]
		public class CameraPosition // TypeDefIndex: 82957
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
			public CameraPosition(); // 0x000000018CE19748-0x000000018CE197A0
	
			// Methods
			public Quaternion GetRotation(); // 0x000000018CE19348-0x000000018CE194A8
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error); // 0x000000018CE194A8-0x000000018CE19748
		}
	
		[Serializable]
		public class Range // TypeDefIndex: 82959
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
			public class Interaction // TypeDefIndex: 82958
			{
				// Fields
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject; // 0x10
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors; // 0x18
	
				// Constructors
				public Interaction(); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Constructors
			public Range(); // 0x0000000187233970-0x0000000187233980
	
			// Methods
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError); // 0x000000018CE2528C-0x000000018CE2538C
		}
	
		// Constructors
		public InteractionTrigger(); // 0x000000018CE22A60-0x000000018CE22AB0
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018CE229F8-0x000000018CE22A2C
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018CE22990-0x000000018CE229C4
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4(); // 0x000000018CE229C4-0x000000018CE229F8
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CE22A2C-0x000000018CE22A60
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CE227A4-0x000000018CE227D8
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit); // 0x000000018CE227D8-0x000000018CE22990
	}

	public class GenericPoser : Poser // TypeDefIndex: 82962
	{
		// Fields
		public Map[] maps; // 0x50
	
		// Nested types
		[Serializable]
		public class Map // TypeDefIndex: 82961
		{
			// Fields
			public Transform bone; // 0x10
			public Transform target; // 0x18
			private Vector3 defaultLocalPosition; // 0x20
			private Quaternion defaultLocalRotation; // 0x2C
	
			// Constructors
			public Map(Transform bone, Transform target); // 0x000000018CE23954-0x000000018CE23988
	
			// Methods
			public void StoreDefaultState(); // 0x000000018CDE21F4-0x000000018CDE2250
			public void FixTransform(); // 0x000000018CE23794-0x000000018CE237F4
			public void Update(float localRotationWeight, float localPositionWeight); // 0x000000018CE237F4-0x000000018CE23954
		}
	
		// Constructors
		public GenericPoser(); // 0x000000018CE1B1B4-0x000000018CE1B1CC
	
		// Methods
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping(); // 0x000000018CE1AD54-0x000000018CE1AF8C
		protected override void InitiatePoser(); // 0x000000018CE1B070-0x000000018CE1B078
		protected override void UpdatePoser(); // 0x000000018CE1B0D4-0x000000018CE1B1B4
		protected override void FixPoserTransforms(); // 0x000000018CE1AF8C-0x000000018CE1AFE8
		private void StoreDefaultState(); // 0x000000018CE1B078-0x000000018CE1B0D4
		private Transform GetTargetNamed(string tName, Transform[] array); // 0x000000018CE1AFE8-0x000000018CE1B070
	}

	public class HandPoser : Poser // TypeDefIndex: 82963
	{
		// Fields
		protected Transform[] children; // 0x50
		private Transform _poseRoot; // 0x58
		private Transform[] poseChildren; // 0x60
		private Vector3[] defaultLocalPositions; // 0x68
		private Quaternion[] defaultLocalRotations; // 0x70
	
		// Constructors
		public HandPoser(); // 0x000000018CE1B1B4-0x000000018CE1B1CC
	
		// Methods
		public override void AutoMapping(); // 0x000000018CE1B1CC-0x000000018CE1B284
		protected override void InitiatePoser(); // 0x000000018CE1B380-0x000000018CE1B3D0
		protected override void FixPoserTransforms(); // 0x000000018CE1B284-0x000000018CE1B380
		protected override void UpdatePoser(); // 0x000000018CE1B53C-0x000000018CE1B878
		protected void StoreDefaultState(); // 0x000000018CE1B3D0-0x000000018CE1B53C
	}

	public abstract class Poser : SolverManager // TypeDefIndex: 82964
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
		protected Poser(); // 0x000000018CE1B1B4-0x000000018CE1B1CC
	
		// Methods
		public abstract void AutoMapping();
		public void UpdateManual(); // 0x000000018783BBB0-0x000000018783BBC0
		protected abstract void InitiatePoser();
		protected abstract void UpdatePoser();
		protected abstract void FixPoserTransforms();
		protected override void UpdateSolver(); // 0x000000018CE23ED4-0x000000018CE23F10
		protected override void InitiateSolver(); // 0x000000018CE23EAC-0x000000018CE23ED4
		protected override void FixTransforms(); // 0x000000018CE23E98-0x000000018CE23EAC
	}

	public class RagdollUtility : MonoBehaviour // TypeDefIndex: 82968
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
		private bool isRagdoll { get; } // 0x000000018CE2522C-0x000000018CE2528C 
		private bool ikUsed { get; } // 0x000000018CE25124-0x000000018CE2522C 
	
		// Nested types
		public class Rigidbone // TypeDefIndex: 82965
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
			public Rigidbone(Rigidbody r); // 0x000000018CE25AEC-0x000000018CE25C60
	
			// Methods
			public void RecordVelocity(); // 0x000000018CE25770-0x000000018CE2588C
			public void WakeUp(float velocityWeight, float angularVelocityWeight); // 0x000000018CE2588C-0x000000018CE25AEC
		}
	
		public class Child // TypeDefIndex: 82966
		{
			// Fields
			public Transform t; // 0x10
			public Vector3 localPosition; // 0x18
			public Quaternion localRotation; // 0x24
	
			// Constructors
			public Child(Transform transform); // 0x000000018CE1A044-0x000000018CE1A0AC
	
			// Methods
			public void FixTransform(float weight); // 0x000000018CE19E88-0x000000018CE19FE8
			public void StoreLocalState(); // 0x000000018CE19FE8-0x000000018CE1A044
		}
	
		[CompilerGenerated]
		private sealed class _DisableRagdollSmooth_d__21 : IEnumerator<object> // TypeDefIndex: 82967
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public RagdollUtility __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DisableRagdollSmooth_d__21(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CE28C5C-0x000000018CE28E3C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CE28E3C-0x000000018CE28E88
		}
	
		// Constructors
		public RagdollUtility(); // 0x000000018CE25030-0x000000018CE25124
	
		// Methods
		public void EnableRagdoll(); // 0x000000018CE244A4-0x000000018CE244CC
		public void DisableRagdoll(); // 0x000000018CE2445C-0x000000018CE244A4
		public void Start(); // 0x000000018CE249B8-0x000000018CE24DC4
		[IteratorStateMachine(typeof(_DisableRagdollSmooth_d__21))]
		private IEnumerator DisableRagdollSmooth(); // 0x000000018CE24400-0x000000018CE2445C
		private void Update(); // 0x000000018CE24E1C-0x000000018CE25030
		private void FixedUpdate(); // 0x000000018CE24538-0x000000018CE24570
		private void LateUpdate(); // 0x000000018CE24570-0x000000018CE245DC
		private void AfterLastIK(); // 0x000000018CE243D4-0x000000018CE24400
		private void AfterAnimation(); // 0x000000018CE2439C-0x000000018CE243D4
		private void OnFinalPose(); // 0x000000018CE24708-0x000000018CE24744
		private void RagdollEnabler(); // 0x000000018CE24744-0x000000018CE24960
		private void RecordVelocities(); // 0x000000018CE24960-0x000000018CE249B8
		private void StoreLocalState(); // 0x000000018CE24DC4-0x000000018CE24E1C
		private void FixTransforms(float weight); // 0x000000018CE244CC-0x000000018CE24538
		private void OnDestroy(); // 0x000000018CE245DC-0x000000018CE24708
	}

	public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 82969
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
		public Vector3 secondaryAxis { get; } // 0x0000000187257AC0-0x0000000187257AE0 
		public Vector3 crossAxis { get; } // 0x000000018CE2862C-0x000000018CE2869C 
		public bool defaultLocalRotationOverride { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBB0-0x000000018226EBC0 0x000000018226EBC0-0x000000018226EBD0
	
		// Constructors
		protected RotationLimit(); // 0x000000018CE285FC-0x000000018CE2862C
	
		// Methods
		public void SetDefaultLocalRotation(); // 0x000000018CE285BC-0x000000018CE285FC
		public void SetDefaultLocalRotation(Quaternion localRotation); // 0x0000000187257AB0-0x0000000187257AC0
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed); // 0x000000018CE281A4-0x000000018CE282C8
		public bool Apply(); // 0x000000018CE28014-0x000000018CE280B4
		public void Disable(); // 0x000000018CE2817C-0x000000018CE281A4
		protected abstract Quaternion LimitRotation(Quaternion rotation);
		private void Awake(); // 0x000000018CE280B4-0x000000018CE2817C
		private void LateUpdate(); // 0x000000018CE28340-0x000000018CE28348
		public void LogWarning(string message); // 0x000000018CDCCCB8-0x000000018CDCCCE0
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis); // 0x000000018CE28348-0x000000018CE283F8
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit); // 0x000000018CE283F8-0x000000018CE285BC
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal); // 0x000000018CE282C8-0x000000018CE28340
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitAngle : RotationLimit // TypeDefIndex: 82970
	{
		// Fields
		[Range(0f, 180f)]
		public float limit; // 0x38
		[Range(0f, 180f)]
		public float twistLimit; // 0x3C
	
		// Constructors
		public RotationLimitAngle(); // 0x000000018CE25FF0-0x000000018CE26008
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018CE25F88-0x000000018CE25FBC
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018CE25F54-0x000000018CE25F88
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CE25FBC-0x000000018CE25FF0
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CE25C60-0x000000018CE25C94
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018CE25C94-0x000000018CE25D4C
		private Quaternion LimitSwing(Quaternion rotation); // 0x000000018CE25D4C-0x000000018CE25F54
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitHinge : RotationLimit // TypeDefIndex: 82971
	{
		// Fields
		public bool useLimits; // 0x38
		public float min; // 0x3C
		public float max; // 0x40
		[HideInInspector]
		public float zeroAxisDisplayOffset; // 0x44
		private float lastAngle; // 0x48
	
		// Constructors
		public RotationLimitHinge(); // 0x000000018CE26338-0x000000018CE26354
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018CE262D0-0x000000018CE26304
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018CE2629C-0x000000018CE262D0
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CE26304-0x000000018CE26338
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CE26008-0x000000018CE2603C
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018CE26268-0x000000018CE2629C
		private Quaternion LimitHinge(Quaternion rotation); // 0x000000018CE2603C-0x000000018CE26268
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitPolygonal : RotationLimit // TypeDefIndex: 82974
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
		public class ReachCone // TypeDefIndex: 82972
		{
			// Fields
			public Vector3[] tetrahedron; // 0x10
			public float volume; // 0x18
			public Vector3 S; // 0x1C
			public Vector3 B; // 0x28
	
			// Properties
			public Vector3 o { get; } // 0x000000018CE25744-0x000000018CE25770 
			public Vector3 a { get; } // 0x000000018CE256A4-0x000000018CE256D4 
			public Vector3 b { get; } // 0x000000018CE256D4-0x000000018CE25704 
			public Vector3 c { get; } // 0x000000018CE25704-0x000000018CE25734 
			public bool isValid { get; } // 0x000000018CE25734-0x000000018CE25744 
	
			// Constructors
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c); // 0x000000018CE25544-0x000000018CE256A4
	
			// Methods
			public void Calculate(); // 0x000000018CE2538C-0x000000018CE25544
		}
	
		[Serializable]
		public class LimitPoint // TypeDefIndex: 82973
		{
			// Fields
			public Vector3 point; // 0x10
			public float tangentWeight; // 0x1C
	
			// Constructors
			public LimitPoint(); // 0x000000018CE22AB0-0x000000018CE22AD4
		}
	
		// Constructors
		public RotationLimitPolygonal(); // 0x000000018CE27B48-0x000000018CE27BA0
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018CE26CC0-0x000000018CE26CF4
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018CE26C8C-0x000000018CE26CC0
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CE279A8-0x000000018CE279DC
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CE26354-0x000000018CE26388
		public void SetLimitPoints(LimitPoint[] points); // 0x000000018CE271E4-0x000000018CE27258
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018CE268FC-0x000000018CE269DC
		private void Start(); // 0x000000018CE277CC-0x000000018CE279A8
		public void ResetToDefault(); // 0x000000018CE26DF8-0x000000018CE271E4
		public void BuildReachCones(); // 0x000000018CE26388-0x000000018CE26758
		private Vector3[] SmoothPoints(); // 0x000000018CE27258-0x000000018CE277CC
		private float GetScalar(int k); // 0x000000018CE268AC-0x000000018CE268FC
		private Vector3 PointToTangentPlane(Vector3 p, float r); // 0x000000018CE26CF4-0x000000018CE26DF8
		private Vector3 TangentPointToSphere(Vector3 q, float r); // 0x000000018CE279DC-0x000000018CE27B48
		private Quaternion LimitSwing(Quaternion rotation); // 0x000000018CE269DC-0x000000018CE26C8C
		private int GetReachCone(Vector3 L); // 0x000000018CE26758-0x000000018CE268AC
	}

	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitSpline : RotationLimit // TypeDefIndex: 82975
	{
		// Fields
		[Range(0f, 180f)]
		public float twistLimit; // 0x38
		[HideInInspector]
		public AnimationCurve spline; // 0x40
	
		// Constructors
		public RotationLimitSpline(); // 0x000000018CE28004-0x000000018CE28014
	
		// Methods
		[ContextMenu("User Manual")]
		private void OpenUserManual(); // 0x000000018CE27F7C-0x000000018CE27FB0
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference(); // 0x000000018CE27F48-0x000000018CE27F7C
		[ContextMenu("Support Group")]
		private void SupportGroup(); // 0x000000018CE27FD0-0x000000018CE28004
		[ContextMenu("Asset Store Thread")]
		private void ASThread(); // 0x000000018CE27BA0-0x000000018CE27BD4
		public void SetSpline(Keyframe[] keyframes); // 0x000000018CE27FB0-0x000000018CE27FD0
		protected override Quaternion LimitRotation(Quaternion rotation); // 0x000000018CE27BD4-0x000000018CE27C8C
		public Quaternion LimitSwing(Quaternion rotation); // 0x000000018CE27C8C-0x000000018CE27F48
	}

	public class AimController : MonoBehaviour // TypeDefIndex: 82977
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
		private Vector3 pivot { get; } // 0x000000018CE17B40-0x000000018CE17C48 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _TurnToTarget_d__37 : IEnumerator<object> // TypeDefIndex: 82976
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public AimController __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _TurnToTarget_d__37(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CE28E88-0x000000018CE28F48
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CE28F48-0x000000018CE28F94
		}
	
		// Constructors
		public AimController(); // 0x000000018CE17AB0-0x000000018CE17B40
	
		// Methods
		private void Start(); // 0x000000018CE17960-0x000000018CE17A54
		private void LateUpdate(); // 0x000000018CE16D00-0x000000018CE1769C
		private void ApplyMinDistance(); // 0x000000018CE16BC8-0x000000018CE16D00
		private void RootRotation(); // 0x000000018CE1769C-0x000000018CE17960
		[IteratorStateMachine(typeof(_TurnToTarget_d__37))]
		private IEnumerator TurnToTarget(); // 0x000000018CE17A54-0x000000018CE17AB0
	}

	public class AimPoser : MonoBehaviour // TypeDefIndex: 82979
	{
		// Fields
		public float angleBuffer; // 0x18
		public Pose[] poses; // 0x20
	
		// Nested types
		[Serializable]
		public class Pose // TypeDefIndex: 82978
		{
			// Fields
			public bool visualize; // 0x10
			public string name; // 0x18
			public Vector3 direction; // 0x20
			public float yaw; // 0x2C
			public float pitch; // 0x30
			private float angleBuffer; // 0x34
	
			// Constructors
			public Pose(); // 0x0000000187257A80-0x0000000187257AA0
	
			// Methods
			public bool IsInDirection(Vector3 d); // 0x000000018CE23C70-0x000000018CE23E98
			public void SetAngleBuffer(float value); // 0x0000000187233AF0-0x0000000187233B00
		}
	
		// Constructors
		public AimPoser(); // 0x000000018CE17D78-0x000000018CE17DD0
	
		// Methods
		public Pose GetPose(Vector3 localDirection); // 0x000000018CE17C48-0x000000018CE17D20
		public void SetPoseActive(Pose pose); // 0x000000018CE17D20-0x000000018CE17D78
	}

	public class Amplifier : OffsetModifier // TypeDefIndex: 82982
	{
		// Fields
		[Tooltip("The amplified bodies.")]
		public Body[] bodies; // 0x30
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 82981
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
			public class EffectorLink // TypeDefIndex: 82980
			{
				// Fields
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Weight of using this effector")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Constructors
			public Body(); // 0x00000001872579E0-0x0000000187257A00
	
			// Methods
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime); // 0x000000018CE188A4-0x000000018CE18CEC
			private static Vector3 Multiply(Vector3 v1, Vector3 v2); // 0x0000000187257980-0x00000001872579C0
		}
	
		// Constructors
		public Amplifier(); // 0x000000018CE17EF0-0x000000018CE17EF8
	
		// Methods
		protected override void OnModifyOffset(); // 0x000000018CE17DD0-0x000000018CE17EF0
	}

	public class BodyTilt : OffsetModifier // TypeDefIndex: 82983
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
		public BodyTilt(); // 0x000000018CE1834C-0x000000018CE18364
	
		// Methods
		protected override void Start(); // 0x000000018CE18300-0x000000018CE1834C
		protected override void OnModifyOffset(); // 0x000000018CE18118-0x000000018CE18300
	}

	public class CCDBendGoal : MonoBehaviour // TypeDefIndex: 82984
	{
		// Fields
		public CCDIK ik; // 0x18
		[Range(0f, 1f)]
		public float weight; // 0x20
	
		// Constructors
		public CCDBendGoal(); // 0x000000018CE1932C-0x000000018CE19348
	
		// Methods
		private void Start(); // 0x000000018CE19238-0x000000018CE1932C
		private void BeforeIK(); // 0x000000018CE18E24-0x000000018CE19110
		private void OnDestroy(); // 0x000000018CE19110-0x000000018CE19238
	}

	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour // TypeDefIndex: 82985
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
		public IK ik { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
	
		// Constructors
		public EditorIK(); // 0x000000018CE1AC18-0x000000018CE1AC68
	
		// Methods
		private void OnEnable(); // 0x000000018CE1A7C8-0x000000018CE1A910
		private void OnDisable(); // 0x000000018CE1A6FC-0x000000018CE1A7C8
		private void OnDestroy(); // 0x000000018CE1A5C4-0x000000018CE1A6FC
		public void StoreDefaultPose(); // 0x000000018CE1A910-0x000000018CE1A988
		public bool Initiate(); // 0x000000018CE1A3F4-0x000000018CE1A5C4
		public void Update(); // 0x000000018CE1A988-0x000000018CE1AC18
	}

	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject // TypeDefIndex: 82986
	{
		// Fields
		public Vector3[] localPositions; // 0x18
		public Quaternion[] localRotations; // 0x20
	
		// Properties
		public bool poseStored { get; } // 0x000000018CE1A3D4-0x000000018CE1A3F4 
	
		// Constructors
		public EditorIKPose(); // 0x000000018CE1A35C-0x000000018CE1A3D4
	
		// Methods
		public void Store(Transform[] T); // 0x000000018CE1A208-0x000000018CE1A35C
		public bool Restore(Transform[] T); // 0x000000018CE1A0AC-0x000000018CE1A208
	}

	public class HitReaction : OffsetModifier // TypeDefIndex: 82992
	{
		// Fields
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints; // 0x30
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints; // 0x38
	
		// Properties
		public bool inProgress { get; } // 0x000000018CE1C614-0x000000018CE1C698 
	
		// Nested types
		[Serializable]
		public abstract class HitPoint // TypeDefIndex: 82987
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
			public bool inProgress { get; } // 0x000000018CE1C0C4-0x000000018CE1C0D4 
			protected float crossFader { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187236710-0x0000000187236720 0x0000000187236720-0x0000000187236730
			protected float timer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
			protected Vector3 force { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233AD0-0x0000000187233AF0 0x0000000187233B00-0x0000000187233B10
	
			// Constructors
			protected HitPoint(); // 0x0000000187257A60-0x0000000187257A70
	
			// Methods
			public virtual void Hit(Vector3 force, Vector3 point); // 0x000000018CE1BFE4-0x000000018CE1C0C4
			public void Apply(IKSolverFullBodyBiped solver, float weight); // 0x000000018CE1BF1C-0x000000018CE1BFE4
			protected abstract float GetLength();
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);
		}
	
		[Serializable]
		public class HitPointEffector : HitPoint // TypeDefIndex: 82989
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
			public class EffectorLink // TypeDefIndex: 82988
			{
				// Fields
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public EffectorLink(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader); // 0x000000018CE1AC68-0x000000018CE1AD54
				public void CrossFadeStart(); // 0x0000000187257A40-0x0000000187257A60
			}
	
			// Constructors
			public HitPointEffector(); // 0x0000000187257A60-0x0000000187257A70
	
			// Methods
			protected override float GetLength(); // 0x000000018CE1BC2C-0x000000018CE1BD34
			protected override void CrossFadeStart(); // 0x000000018CE1BBDC-0x000000018CE1BC2C
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight); // 0x000000018CE1BD34-0x000000018CE1BF1C
		}
	
		[Serializable]
		public class HitPointBone : HitPoint // TypeDefIndex: 82991
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
			public class BoneLink // TypeDefIndex: 82990
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
				public BoneLink(); // 0x000000018CE18DF4-0x000000018CE18E24
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader); // 0x000000018CE18CEC-0x000000018CE18DF4
				public void CrossFadeStart(); // 0x0000000187257A00-0x0000000187257A10
			}
	
			// Constructors
			public HitPointBone(); // 0x0000000187257A60-0x0000000187257A70
	
			// Methods
			public override void Hit(Vector3 force, Vector3 point); // 0x000000018CE1B938-0x000000018CE1BAF8
			protected override float GetLength(); // 0x000000018CE1B8BC-0x000000018CE1B938
			protected override void CrossFadeStart(); // 0x000000018CE1B878-0x000000018CE1B8BC
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight); // 0x000000018CE1BAF8-0x000000018CE1BBDC
		}
	
		// Constructors
		public HitReaction(); // 0x000000018CE17EF0-0x000000018CE17EF8
	
		// Methods
		protected override void OnModifyOffset(); // 0x000000018CE1C558-0x000000018CE1C614
		public void Hit(Collider collider, Vector3 force, Vector3 point); // 0x000000018CE1C378-0x000000018CE1C558
	}

	public class HitReactionVRIK : OffsetModifierVRIK // TypeDefIndex: 82998
	{
		// Fields
		public AnimationCurve[] offsetCurves; // 0x30
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets; // 0x38
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets; // 0x40
	
		// Nested types
		[Serializable]
		public abstract class Offset // TypeDefIndex: 82993
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
			protected float crossFader { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187236710-0x0000000187236720 0x0000000187236720-0x0000000187236730
			protected float timer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
			protected Vector3 force { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233AD0-0x0000000187233AF0 0x0000000187233B00-0x0000000187233B10
	
			// Constructors
			protected Offset(); // 0x0000000187257A60-0x0000000187257A70
	
			// Methods
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point); // 0x000000018CE23B6C-0x000000018CE23C70
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight); // 0x000000018CE23A94-0x000000018CE23B6C
			protected abstract float GetLength(AnimationCurve[] curves);
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);
		}
	
		[Serializable]
		public class PositionOffset : Offset // TypeDefIndex: 82995
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
			public class PositionOffsetLink // TypeDefIndex: 82994
			{
				// Fields
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset; // 0x10
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public PositionOffsetLink(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				public void Apply(VRIK ik, Vector3 offset, float crossFader); // 0x000000018CE23F10-0x000000018CE23FC0
				public void CrossFadeStart(); // 0x0000000187257A40-0x0000000187257A60
			}
	
			// Constructors
			public PositionOffset(); // 0x0000000187257AA0-0x0000000187257AB0
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves); // 0x000000018CE24010-0x000000018CE24184
			protected override void CrossFadeStart(); // 0x000000018CE23FC0-0x000000018CE24010
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight); // 0x000000018CE24184-0x000000018CE2439C
		}
	
		[Serializable]
		public class RotationOffset : Offset // TypeDefIndex: 82997
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
			public class RotationOffsetLink // TypeDefIndex: 82996
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
				public RotationOffsetLink(); // 0x000000018CE2877C-0x000000018CE287AC
	
				// Methods
				public void Apply(VRIK ik, Quaternion offset, float crossFader); // 0x000000018CE2869C-0x000000018CE2877C
				public void CrossFadeStart(); // 0x0000000187257AE0-0x0000000187257AF0
			}
	
			// Constructors
			public RotationOffset(); // 0x0000000187257A60-0x0000000187257A70
	
			// Methods
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point); // 0x000000018CE288A8-0x000000018CE28A74
			protected override float GetLength(AnimationCurve[] curves); // 0x000000018CE287F0-0x000000018CE288A8
			protected override void CrossFadeStart(); // 0x000000018CE287AC-0x000000018CE287F0
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight); // 0x000000018CE28A74-0x000000018CE28C5C
		}
	
		// Constructors
		public HitReactionVRIK(); // 0x000000018CE17EF0-0x000000018CE17EF8
	
		// Methods
		protected override void OnModifyOffset(); // 0x000000018CE1C2BC-0x000000018CE1C378
		public void Hit(Collider collider, Vector3 force, Vector3 point); // 0x000000018CE1C0D4-0x000000018CE1C2BC
	}

	public class Inertia : OffsetModifier // TypeDefIndex: 83001
	{
		// Fields
		[Tooltip("The array of Bodies")]
		public Body[] bodies; // 0x30
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits; // 0x38
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 83000
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
			public class EffectorLink // TypeDefIndex: 82999
			{
				// Fields
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Weight of using this effector")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Constructors
			public Body(); // 0x00000001872579C0-0x00000001872579E0
	
			// Methods
			public void Reset(); // 0x000000018CE18364-0x000000018CE18424
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime); // 0x000000018CE18424-0x000000018CE188A4
		}
	
		// Constructors
		public Inertia(); // 0x000000018CE17EF0-0x000000018CE17EF8
	
		// Methods
		public void ResetBodies(); // 0x000000018CE1C74C-0x000000018CE1C7B4
		protected override void OnModifyOffset(); // 0x000000018CE1C698-0x000000018CE1C74C
	}

	public class LookAtController : MonoBehaviour // TypeDefIndex: 83002
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
		private Vector3 pivot { get; } // 0x000000018CE2368C-0x000000018CE23794 
	
		// Constructors
		public LookAtController(); // 0x000000018CE23628-0x000000018CE2368C
	
		// Methods
		private void Start(); // 0x000000018CE23560-0x000000018CE23628
		private void LateUpdate(); // 0x000000018CE22C0C-0x000000018CE232F8
		private void ApplyMinDistance(); // 0x000000018CE22AD4-0x000000018CE22C0C
		private void RootRotation(); // 0x000000018CE232F8-0x000000018CE23560
	}

	public abstract class OffsetModifier : MonoBehaviour // TypeDefIndex: 83005
	{
		// Fields
		[Tooltip("The master weight")]
		public float weight; // 0x18
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik; // 0x20
		protected float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x000000018CE29CEC-0x000000018CE29D08 
	
		// Nested types
		[Serializable]
		public class OffsetLimits // TypeDefIndex: 83003
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
			public OffsetLimits(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Apply(IKEffector e, Quaternion rootRotation); // 0x000000018CE29808-0x000000018CE299EC
			private float SpringAxis(float value, float min, float max); // 0x000000018CE299EC-0x000000018CE29A24
			private float Spring(float value, float limit, bool negative); // 0x000000018CE29A24-0x000000018CE29A80
		}
	
		[CompilerGenerated]
		private sealed class _Initiate_d__8 : IEnumerator<object> // TypeDefIndex: 83004
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public OffsetModifier __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Initiate_d__8(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CE2C274-0x000000018CE2C3E8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CE2C3E8-0x000000018CE2C434
		}
	
		// Constructors
		protected OffsetModifier(); // 0x000000018B63B174-0x000000018B63B190
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start(); // 0x000000018CE2A010-0x000000018CE2A034
		[IteratorStateMachine(typeof(_Initiate_d__8))]
		private IEnumerator Initiate(); // 0x000000018CE29DC8-0x000000018CE29E24
		private void ModifyOffset(); // 0x000000018CE29E24-0x000000018CE29EE8
		protected void ApplyLimits(OffsetLimits[] limits); // 0x000000018CE29D08-0x000000018CE29DC8
		protected virtual void OnDestroy(); // 0x000000018CE29EE8-0x000000018CE2A010
	}

	public abstract class OffsetModifierVRIK : MonoBehaviour // TypeDefIndex: 83007
	{
		// Fields
		[Tooltip("The master weight")]
		public float weight; // 0x18
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik; // 0x20
		private float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x000000018CE29CEC-0x000000018CE29D08 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Initiate_d__7 : IEnumerator<object> // TypeDefIndex: 83006
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public OffsetModifierVRIK __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Initiate_d__7(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CE2C0B4-0x000000018CE2C228
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CE2C228-0x000000018CE2C274
		}
	
		// Constructors
		protected OffsetModifierVRIK(); // 0x000000018B63B174-0x000000018B63B190
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start(); // 0x000000018CE29CC8-0x000000018CE29CEC
		[IteratorStateMachine(typeof(_Initiate_d__7))]
		private IEnumerator Initiate(); // 0x000000018CE29A80-0x000000018CE29ADC
		private void ModifyOffset(); // 0x000000018CE29ADC-0x000000018CE29BA0
		protected virtual void OnDestroy(); // 0x000000018CE29BA0-0x000000018CE29CC8
	}

	public class OffsetPose : MonoBehaviour // TypeDefIndex: 83009
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x18
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 83008
		{
			// Fields
			public FullBodyBipedEffector effector; // 0x10
			public Vector3 offset; // 0x14
			public Vector3 pin; // 0x20
			public Vector3 pinWeight; // 0x2C
	
			// Constructors
			public EffectorLink(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation); // 0x000000018CE29540-0x000000018CE29808
		}
	
		// Constructors
		public OffsetPose(); // 0x000000018CE2A190-0x000000018CE2A1E0
	
		// Methods
		public void Apply(IKSolverFullBodyBiped solver, float weight); // 0x000000018CE2A034-0x000000018CE2A0F0
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation); // 0x000000018CE2A0F0-0x000000018CE2A190
	}

	public class PenetrationAvoidance : OffsetModifier // TypeDefIndex: 83012
	{
		// Fields
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders; // 0x30
	
		// Nested types
		[Serializable]
		public class Avoider // TypeDefIndex: 83011
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
			public class EffectorLink // TypeDefIndex: 83010
			{
				// Fields
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Constructors
			public Avoider(); // 0x0000000187257AF0-0x0000000187257B00
	
			// Methods
			public void Solve(IKSolverFullBodyBiped solver, float weight); // 0x000000018CE29368-0x000000018CE29540
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver); // 0x000000018CE28FB4-0x000000018CE29138
			private Vector3 Raycast(Vector3 from, Vector3 to); // 0x000000018CE29138-0x000000018CE29368
		}
	
		// Constructors
		public PenetrationAvoidance(); // 0x000000018CE17EF0-0x000000018CE17EF8
	
		// Methods
		protected override void OnModifyOffset(); // 0x000000018CE2A1E0-0x000000018CE2A25C
	}

	public class Recoil : OffsetModifier // TypeDefIndex: 83016
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
		public bool isFinished { get; } // 0x000000018CE2B63C-0x000000018CE2B65C 
		private IKEffector primaryHandEffector { get; } // 0x000000018CE2B65C-0x000000018CE2B69C 
		private IKEffector secondaryHandEffector { get; } // 0x000000018CE2B6BC-0x000000018CE2B6FC 
		private Transform primaryHand { get; } // 0x000000018CE2B69C-0x000000018CE2B6BC 
		private Transform secondaryHand { get; } // 0x000000018CE2B6FC-0x000000018CE2B71C 
	
		// Nested types
		[Serializable]
		public class RecoilOffset // TypeDefIndex: 83014
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
			public class EffectorLink // TypeDefIndex: 83013
			{
				// Fields
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip("Weight of using this effector")]
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Constructors
			public RecoilOffset(); // 0x0000000187257B00-0x0000000187257B10
	
			// Methods
			public void Start(); // 0x000000018CE2A47C-0x000000018CE2A4F0
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft); // 0x000000018CE2A25C-0x000000018CE2A47C
		}
	
		[Serializable]
		public enum Handedness // TypeDefIndex: 83015
		{
			Right = 0,
			Left = 1
		}
	
		// Constructors
		public Recoil(); // 0x000000018CE2B5D0-0x000000018CE2B63C
	
		// Methods
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation); // 0x000000018CE2B5B0-0x000000018CE2B5D0
		public void Fire(float magnitude); // 0x000000018CE2A6E8-0x000000018CE2A840
		protected override void OnModifyOffset(); // 0x000000018CE2AA54-0x000000018CE2B5B0
		private void AfterFBBIK(); // 0x000000018CE2A5A0-0x000000018CE2A6E8
		private void AfterAimIK(); // 0x000000018CE2A4F0-0x000000018CE2A5A0
		protected override void OnDestroy(); // 0x000000018CE2A840-0x000000018CE2AA54
	}

	public class ShoulderRotator : MonoBehaviour // TypeDefIndex: 83017
	{
		// Fields
		[Tooltip("Weight of shoulder rotation")]
		public float weight; // 0x18
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset; // 0x1C
		private FullBodyBipedIK ik; // 0x20
		private bool skip; // 0x28
	
		// Constructors
		public ShoulderRotator(); // 0x000000018CE2BF8C-0x000000018CE2BFB0
	
		// Methods
		private void Start(); // 0x000000018CE2BE70-0x000000018CE2BF8C
		private void RotateShoulders(); // 0x000000018CE2BD90-0x000000018CE2BE70
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset); // 0x000000018CE2B948-0x000000018CE2BD90
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain); // 0x000000018CE2B7E4-0x000000018CE2B820
		private void OnDestroy(); // 0x000000018CE2B820-0x000000018CE2B948
	}

	public static class VRIKCalibrator // TypeDefIndex: 83021
	{
		// Nested types
		[Serializable]
		public class Settings // TypeDefIndex: 83018
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
			public Settings(); // 0x000000018CE2B71C-0x000000018CE2B7E4
		}
	
		[Serializable]
		public class CalibrationData // TypeDefIndex: 83020
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
			public class Target // TypeDefIndex: 83019
			{
				// Fields
				public bool used; // 0x10
				public Vector3 localPosition; // 0x14
				public Quaternion localRotation; // 0x20
	
				// Constructors
				public Target(Transform t); // 0x000000018CE2C018-0x000000018CE2C0B4
	
				// Methods
				public void SetTo(Transform t); // 0x000000018CE2BFB0-0x000000018CE2C018
			}
	
			// Constructors
			public CalibrationData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Methods
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings); // 0x000000018CE30AC0-0x000000018CE30AE4
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp); // 0x000000018CE30A60-0x000000018CE30AC0
		private static void CalibrateScale(VRIK ik, Settings settings); // 0x000000018CE2DD74-0x000000018CE2DD94
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f /* Metadata: 0x026417A3 */); // 0x000000018CE2DD94-0x000000018CE2DF1C
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null); // 0x000000018CE2EAA0-0x000000018CE302A4
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft); // 0x000000018CE2D634-0x000000018CE2DD74
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, Transform bodyTracker = null, Transform leftHandTracker = null, Transform rightHandTracker = null, Transform leftFootTracker = null, Transform rightFootTracker = null); // 0x000000018CE2DF1C-0x000000018CE2EAA0
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft); // 0x000000018CE2D3E4-0x000000018CE2D634
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f /* Metadata: 0x026417A7 */); // 0x000000018CE302A4-0x000000018CE304F0
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset); // 0x000000018CE2CE54-0x000000018CE2D3E4
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset); // 0x000000018CE2C434-0x000000018CE2C730
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset); // 0x000000018CE2CBFC-0x000000018CE2CE54
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft); // 0x000000018CE2C730-0x000000018CE2CBFC
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm); // 0x000000018CE308E4-0x000000018CE30A60
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm); // 0x000000018CE304F0-0x000000018CE308E4
	}

	public class VRIKLODController : MonoBehaviour // TypeDefIndex: 83022
	{
		// Fields
		public Renderer LODRenderer; // 0x18
		public float LODDistance; // 0x20
		public bool allowCulled; // 0x24
		private VRIK ik; // 0x28
	
		// Constructors
		public VRIKLODController(); // 0x000000018CE30CBC-0x000000018CE30CDC
	
		// Methods
		private void Start(); // 0x000000018CE30C40-0x000000018CE30C88
		private void Update(); // 0x000000018CE30C88-0x000000018CE30CBC
		private int GetLODLevel(); // 0x000000018CE30AE4-0x000000018CE30C40
	}

	public class VRIKRootController : MonoBehaviour // TypeDefIndex: 83023
	{
		// Fields
		[CompilerGenerated]
		private Vector3 _pelvisTargetRight_k__BackingField; // 0x18
		private Transform pelvisTarget; // 0x28
		private Transform leftFootTarget; // 0x30
		private Transform rightFootTarget; // 0x38
		private VRIK ik; // 0x40
	
		// Properties
		public Vector3 pelvisTargetRight { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187236730-0x0000000187236750 0x0000000187236750-0x0000000187236760
	
		// Constructors
		public VRIKRootController(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Awake(); // 0x000000018CE30CDC-0x000000018CE30E08
		public void Calibrate(); // 0x000000018CE30E08-0x000000018CE3102C
		public void Calibrate(VRIKCalibrator.CalibrationData data); // 0x000000018CE3102C-0x000000018CE311B4
		private void OnPreUpdate(); // 0x000000018CE312DC-0x000000018CE317EC
		private void OnDestroy(); // 0x000000018CE311B4-0x000000018CE312DC
	}
}
