/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using Beyond.Gameplay.Core;
using Beyond.PackageBridge.Timeline;
using Events;
using ScriptAnimation;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 46: Unity.Timeline.dll - Assembly: Unity.Timeline, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57385-57577

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 57577
{
	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor

	// Methods
	internal static uint ComputeStringHash(string s) => default; // 0x0000000187809354-0x00000001878093A8
}

namespace Beyond.Gameplay.Core
{
	public class DontAutoBindAttribute : DontAutoBindRuntimeAttribute // TypeDefIndex: 57399
	{
		// Constructors
		public DontAutoBindAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class DontAutoBindRuntimeAttribute : Attribute // TypeDefIndex: 57400
	{
		// Constructors
		public DontAutoBindRuntimeAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class BeyondUseAutoBindingPlayableAsset : PlayableAsset // TypeDefIndex: 57401
	{
		// Fields
		public bool useAutoBinding; // 0x18
		public string autoBindingPath; // 0x20
		[NonSerialized]
		protected GameObject m_bindingGo; // 0x28
	
		// Properties
		public virtual GameObject bindingGameObject { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
	
		// Constructors
		public BeyondUseAutoBindingPlayableAsset() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public void SetBindingGameObject(GameObject tBindingGameObject) {} // 0x000000018BE3E6BC-0x000000018BE3E6E4
		protected virtual void OnBindGoChanged() {} // 0x0000000185492010-0x0000000185492020
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x000000018BE3E670-0x000000018BE3E6BC
	}

	public class RuntimeJumpBehaviour : PlayableBehaviour // TypeDefIndex: 57402
	{
		// Constructors
		public RuntimeJumpBehaviour() {} // 0x0000000185492010-0x0000000185492020
	}

	public class RuntimeJumpClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 57403
	{
		// Fields
		public bool isReverseJump; // 0x18
		public bool needChangeOptionAfterJump; // 0x19
		public int optionIndexAfterJump; // 0x1C
		public double crossFadeDurationAfterJump; // 0x20
		public bool isJumpFirst; // 0x28
	
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x0000000185FBDF10-0x0000000185FBDF20 
	
		// Constructors
		public RuntimeJumpClip() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x000000018BE41790-0x000000018BE41828
	}

	public class RuntimeJumpTrack : TrackAsset // TypeDefIndex: 57404
	{
		// Constructors
		public RuntimeJumpTrack() {} // 0x000000018BE41828-0x000000018BE41874
	}

	public class RuntimeLoopBehaviour : PlayableBehaviour // TypeDefIndex: 57405
	{
		// Constructors
		public RuntimeLoopBehaviour() {} // 0x0000000185492010-0x0000000185492020
	}

	public class RuntimeLoopClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 57406
	{
		// Fields
		public double crossFadeDuration; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x0000000185FB7DE0-0x0000000185FB7DF0 
	
		// Constructors
		public RuntimeLoopClip() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x000000018BE41874-0x000000018BE4190C
	}

	public class RuntimeLoopTrack : TrackAsset // TypeDefIndex: 57407
	{
		// Constructors
		public RuntimeLoopTrack() {} // 0x000000018BE4190C-0x000000018BE41958
	}

	public class TimelineNPCLookAtController : MonoBehaviour // TypeDefIndex: 57408
	{
		// Fields
		private static readonly HashSet<TimelineNPCLookAtController> s_instances; // 0x00
		[NonSerialized]
		public bool m_lookAtDirty; // 0x18
		public TimelineNPCLookAtTarget lookAtTarget; // 0x20
		public TimelineNPCLookAtEyeTarget lookAtEyeTarget; // 0x28
		[NonSerialized]
		public bool lookAtEnabled; // 0x30
		[NonSerialized]
		public bool lookAtEyeEnabled; // 0x31
	
		// Properties
		public static IEnumerable<TimelineNPCLookAtController> Instances { get => default; } // 0x000000018BE458B0-0x000000018BE45900 
		public bool lookAtDirty { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public float lookAtWeight { get => default; set {} } // 0x000000018BE45E10-0x000000018BE45E84 0x000000018BE46404-0x000000018BE4647C
		public float lookAtBodyWeight { get => default; set {} } // 0x000000018BE45A58-0x000000018BE45ACC 0x000000018BE4603C-0x000000018BE460B4
		public float lookAtRoll { get => default; set {} } // 0x000000018BE45CAC-0x000000018BE45D20 0x000000018BE46298-0x000000018BE46310
		public float lookAtHorizontal { get => default; set {} } // 0x000000018BE45C28-0x000000018BE45CAC 0x000000018BE4621C-0x000000018BE46298
		public float lookAtVertical { get => default; set {} } // 0x000000018BE45D8C-0x000000018BE45E10 0x000000018BE46388-0x000000018BE46404
		public float lookAtEyeWeight { get => default; set {} } // 0x000000018BE45BAC-0x000000018BE45C28 0x000000018BE461A4-0x000000018BE4621C
		public bool lookAtUseDegree { get => default; set {} } // 0x000000018BE45D20-0x000000018BE45D8C 0x000000018BE46310-0x000000018BE46388
		public bool EyeUseDegree { get => default; set {} } // 0x000000018BE45844-0x000000018BE458B0 0x000000018BE45E84-0x000000018BE45EFC
		public float lookAtEyeUp { get => default; set {} } // 0x000000018BE45B3C-0x000000018BE45BAC 0x000000018BE4612C-0x000000018BE461A4
		public float lookAtEyeDown { get => default; set {} } // 0x000000018BE45ACC-0x000000018BE45B3C 0x000000018BE460B4-0x000000018BE4612C
		public Vector3 finalPosition { get => default; set {} } // 0x000000018BE459AC-0x000000018BE45A58 0x000000018BE45F9C-0x000000018BE4603C
		public Vector3 finalEyePosition { get => default; set {} } // 0x000000018BE45900-0x000000018BE459AC 0x000000018BE45EFC-0x000000018BE45F9C
	
		// Constructors
		public TimelineNPCLookAtController() {} // 0x000000018BE45834-0x000000018BE45844
		static TimelineNPCLookAtController() {} // 0x000000018BE457A8-0x000000018BE45834
	
		// Methods
		private void OnEnable() {} // 0x000000018BE45738-0x000000018BE457A8
		private void OnDisable() {} // 0x000000018BE456C8-0x000000018BE45738
		public void MarkLookAtDirty() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Beyond.SourceGenerator
{
	internal class DataNAttribute : Attribute // TypeDefIndex: 57394
	{
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 57395
	{
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 57396
	{
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 57397
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 57398
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Events
{
	public interface INotificationTrack // TypeDefIndex: 57392
	{
	}

	public interface ITimelineNotification // TypeDefIndex: 57393
	{
		// Methods
		void OnNotify(ITimelineRootMarker root);
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 57386
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace ScriptAnimation
{
	public class TimelineNPCClothWeightController : MonoBehaviour // TypeDefIndex: 57387
	{
		// Fields
		public bool forceSetPhysicsClothWeight; // 0x18
		public float physicsClothWeight; // 0x1C
		public bool forceSetPhysicsClothPart1Weight; // 0x20
		public float physicsClothPart1Weight; // 0x24
		public bool forceSetPhysicsClothPart2Weight; // 0x28
		public float physicsClothPart2Weight; // 0x2C
		public bool forceSetLoopBodyAddWeight; // 0x30
		public float loopBodyAddWeight; // 0x34
	
		// Constructors
		public TimelineNPCClothWeightController() {} // 0x000000018BE456A4-0x000000018BE456C8
	}

	public class TimelineNPCLookAtEyeTarget : MonoBehaviour // TypeDefIndex: 57388
	{
		// Fields
		public float lookAtWeight; // 0x18
		public bool useDegree; // 0x1C
		public float lookAtUp; // 0x20
		public float lookAtDown; // 0x24
	
		// Constructors
		public TimelineNPCLookAtEyeTarget() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void ResetLookAtWeight() {} // 0x0000000185FC6B20-0x0000000185FC6B30
	}

	public class TimelineNPCLookAtTarget : MonoBehaviour // TypeDefIndex: 57389
	{
		// Fields
		public float lookAtWeight; // 0x18
		public float lookAtBodyWeight; // 0x1C
		public bool useDegree; // 0x20
		public float lookAtHorizontal; // 0x24
		public float lookAtVertical; // 0x28
		public float lookAtRoll; // 0x2C
	
		// Constructors
		public TimelineNPCLookAtTarget() {} // 0x000000018BE4647C-0x000000018BE4649C
	
		// Methods
		public void ResetLookAtWeight() {} // 0x0000000185FE62E0-0x0000000185FE62F0
	}
}

namespace ScriptAnimation.ScriptAnimationApply
{
	public class ScriptAnimationApplyBehaviour : PlayableBehaviour // TypeDefIndex: 57390
	{
		// Fields
		private IScriptAnimationJobSync m_JobSync; // 0x10
	
		// Constructors
		public ScriptAnimationApplyBehaviour() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x000000018BE41958-0x000000018BE419C8
		public void InitBehaviour(IScriptAnimationJobSync jobSync) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class ScriptAnimationApplyPlayable : PlayableAsset // TypeDefIndex: 57391
	{
		// Constructors
		public ScriptAnimationApplyPlayable() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x000000018BE419C8-0x000000018BE41A60
	}
}

namespace UnityEngine
{
	public static class PlayerLoopChecker // TypeDefIndex: 57409
	{
	}
}

namespace UnityEngine.Timeline
{
	internal class ActivationMixerPlayable : PlayableBehaviour // TypeDefIndex: 57410
	{
		// Fields
		private ActivationTrack.PostPlaybackState m_PostPlaybackState; // 0x10
		private bool m_BoundGameObjectInitialStateIsActive; // 0x14
		private bool m_useAutoBinding; // 0x15
		private ITimelineRootMarker m_RootMarker; // 0x18
		private string m_uniqueId; // 0x20
		private bool? m_lastEntityActive; // 0x28
		private GameObject m_BoundGameObject; // 0x30
	
		// Properties
		public ActivationTrack.PostPlaybackState postPlaybackState { set {} } // 0x0000000181378230-0x0000000181378240
	
		// Constructors
		public ActivationMixerPlayable() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount) => default; // 0x000000018BE3637C-0x000000018BE36408
		public void SetBoundGameObject(GameObject go) {} // 0x000000018BE36600-0x000000018BE36690
		public void SetAutoBindingData(bool useAutoBinding, ITimelineRootMarker rootMarker, string uniqueId) {} // 0x0000000183F7EF60-0x0000000183F7F010
		public override void OnPlayableDestroy(Playable playable) {} // 0x0000000185492010-0x0000000185492020
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x000000018BE36408-0x000000018BE3644C
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x000000018BE36520-0x000000018BE36600
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x000000018BE3644C-0x000000018BE36520
		private void _DoSetActive(Playable playable, FrameData info, object playerData = null) {} // 0x000000018BE36690-0x000000018BE36944
	}

	public class ActivationPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 57411
	{
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public ActivationPlayableAsset() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x000000018BE36944-0x000000018BE369B0
	}

	[Serializable]
	public class ActivationTrack : TrackAsset // TypeDefIndex: 57413
	{
		// Fields
		private PostPlaybackState m_PostPlaybackState; // 0xC0
		private ActivationMixerPlayable m_ActivationMixer; // 0xC8
	
		// Properties
		public PostPlaybackState postPlaybackState { get => default; set {} } // 0x0000000185FBE0C0-0x0000000185FBE0D0 0x000000018BE36DE4-0x000000018BE36DF4
	
		// Nested types
		public enum PostPlaybackState // TypeDefIndex: 57412
		{
			Active = 0,
			Inactive = 1,
			Revert = 2,
			LeaveAsIs = 3
		}
	
		// Constructors
		public ActivationTrack() {} // 0x00000001850B42B0-0x00000001850B4310
	
		// Methods
		internal override bool CanCompileClips() => default; // 0x000000018BE369B0-0x000000018BE369E0
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x000000018BE369E0-0x000000018BE36BD8
		private void _BindUniqueId(PlayableGraph graph) {} // 0x0000000183F7F010-0x0000000183F7F120
		internal GameObject GetBinding(PlayableDirector director) => default; // 0x000000018BE36C78-0x000000018BE36D78
		internal void UpdateTrackMode() {} // 0x000000018BE36DC8-0x000000018BE36DE4
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x000000018BE36BD8-0x000000018BE36C78
		protected override void OnCreateClip(TimelineClip clip) {} // 0x000000018BE36D78-0x000000018BE36DC8
	}

	internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback // TypeDefIndex: 57415
	{
		// Fields
		private Animator m_outputAnimator; // 0x10
		private AnimationPlayableOutput m_Output; // 0x18
		private readonly List<WeightInfo> m_Mixers; // 0x28
	
		// Nested types
		private struct WeightInfo // TypeDefIndex: 57414
		{
			// Fields
			public Playable mixer; // 0x00
			public Playable parentMixer; // 0x10
			public int port; // 0x20
		}
	
		// Constructors
		public AnimationOutputWeightProcessor() {} // Dummy constructor
		public AnimationOutputWeightProcessor(AnimationPlayableOutput output, Animator animator) {} // 0x000000018BE37C48-0x000000018BE37D18
	
		// Methods
		private void FindMixers() {} // 0x000000018BE37880-0x000000018BE37974
		private void FindMixers(Playable parent, int port, Playable node) {} // 0x000000018BE37974-0x000000018BE37C48
		public void Evaluate() {} // 0x000000018BE37684-0x000000018BE37880
	}

	[Serializable]
	public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ICustomControlBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 57423
	{
		// Fields
		private AnimationClip m_Clip; // 0x18
		private Vector3 m_Position; // 0x20
		private Vector3 m_EulerAngles; // 0x2C
		private bool m_UseTrackMatchFields; // 0x38
		private MatchTargetFields m_MatchTargetFields; // 0x3C
		private bool m_RemoveStartOffset; // 0x40
		private bool m_ApplyFootIK; // 0x41
		private LoopMode m_Loop; // 0x44
		private bool m_IgniteOnce; // 0x48
		private bool m_OnlyDeltaTime; // 0x49
		private bool m_DynamicLink; // 0x4A
		private ClothResetOption m_ClothResetOption; // 0x4C
		private AnimationEventTriggerMode m_AnimationEventTriggerMode; // 0x50
		private float m_AnimationEventTriggerWeightThreshold; // 0x54
		private ClipEndAudioBehaviour m_ClipEndAudioBehaviour; // 0x58
		private int m_ClipEndAudioFadeOutTimeMs; // 0x5C
		private bool m_MixWitherAnotherClip; // 0x60
		private float m_MainClipMixWeight; // 0x64
		private AnimationClip m_AnotherClip; // 0x68
		private AnimationClip m_blendShapeControlClip; // 0x70
		public bool DisableBlendShapeControl; // 0x78
		private AppliedOffsetMode _appliedOffsetMode_k__BackingField; // 0x7C
		private ITimelineAnimationEventContextBinding _TimelineAnimationEventContextBinding_k__BackingField; // 0x80
		private static readonly int k_LatestVersion; // 0x00
		private int m_Version; // 0x88
		private Quaternion m_Rotation; // 0x8C
	
		// Properties
		public Vector3 position { get => default; set {} } // 0x0000000185FB07A0-0x0000000185FB07B0 0x0000000185FB0650-0x0000000185FB0660
		public Quaternion rotation { get => default; set {} } // 0x0000000185FB0660-0x0000000185FB0670 0x0000000185FB0D70-0x0000000185FB0D80
		public Vector3 eulerAngles { get => default; set {} } // 0x0000000185FB0D90-0x0000000185FB0DA0 0x0000000183908D10-0x0000000183908D20
		public bool useTrackMatchFields { get => default; set {} } // 0x0000000183909010-0x0000000183909020 0x0000000185FB0750-0x0000000185FB0760
		public MatchTargetFields matchTargetFields { get => default; set {} } // 0x0000000185FB0770-0x0000000185FB0780 0x0000000185FB0760-0x0000000185FB0770
		public bool removeStartOffset { get => default; set {} } // 0x0000000185FB0780-0x0000000185FB0790 0x0000000185FB0D40-0x0000000185FB0D50
		public bool applyFootIK { get => default; set {} } // 0x0000000185FB0D50-0x0000000185FB0D60 0x000000018386C570-0x000000018386C580
		public LoopMode loop { get => default; set {} } // 0x000000018386C580-0x000000018386C590 0x00000001813AC280-0x00000001813AC290
		public bool IgniteOnce { get => default; set {} } // 0x0000000185A62990-0x0000000185A629A0 0x0000000181460F70-0x0000000181460F80
		public bool OnlyDeltaTime { get => default; set {} } // 0x0000000183F80470-0x0000000183F804D0 0x0000000185FB2210-0x0000000185FB2220
		public bool DynamicLink { get => default; set {} } // 0x0000000185FB2220-0x0000000185FB2230 0x000000018BE39064-0x000000018BE390E4
		public bool MixWithAnotherClip { get => default; set {} } // 0x0000000185FB05B0-0x0000000185FB05C0 0x0000000185FB0610-0x0000000185FB0620
		public AnimationClip AnotherClip { get => default; set {} } // 0x000000018140CF50-0x000000018140CF60 0x00000001873CBE98-0x00000001873CBEA8
		public AnimationClip BlendShapeControlClip { get => default; internal set {} } // 0x0000000181377E40-0x0000000181377E50 0x000000018BE39190-0x000000018BE3929C
		public float MainClipMixWeight { get => default; set {} } // 0x000000018BE38FFC-0x000000018BE39064 0x0000000185FB06E0-0x0000000185FB06F0
		internal bool hasRootTransforms { get => default; } // 0x0000000185FB06F0-0x0000000185FB0700 
		internal AppliedOffsetMode appliedOffsetMode { get; set; } // 0x0000000185FB0680-0x0000000185FB0690 0x0000000185FB06B0-0x0000000185FB06C0
		internal ITimelineAnimationEventContextBinding TimelineAnimationEventContextBinding { get; set; } // 0x0000000183F80440-0x0000000183F80450 0x0000000183F804D0-0x0000000183F804E0
		public AnimationClip clip { get => default; set {} } // 0x0000000183F80450-0x0000000183F80460 0x0000000183F804E0-0x0000000183F804F0
		public override double duration { get => default; } // 0x0000000183F80460-0x0000000183F80470 
		public ClothResetOption clothResetOption { get => default; set {} } // 0x0000000183F804F0-0x0000000183F80500 0x000000018BE390E4-0x000000018BE39154
		public AnimationEventTriggerMode animationEventTriggerMode { get => default; set {} } // 0x000000018BE388A0-0x000000018BE38918 0x000000018BE38588-0x000000018BE388A0
		public float animationEventTriggerWeightThreshold { get => default; set {} } // 0x000000018BE37DF8-0x000000018BE38588 0x000000018BE37D74-0x000000018BE37DF8
		public ClipEndAudioBehaviour clipEndAudioBehaviour { get => default; set {} } // 0x000000018BE38ABC-0x000000018BE38B18 0x000000018BE38A3C-0x000000018BE38ABC
		public int clipEndAudioFadeOutTimeMs { get => default; set {} } // 0x000000018BE38B2C-0x000000018BE38D34 0x000000018BE38B18-0x000000018BE38B2C
		public override IEnumerable<PlayableBinding> outputs { get => default; } // 0x000000018BE38EEC-0x000000018BE38FFC 
		public ClipCaps clipCaps { get => default; } // 0x000000018BE38A08-0x000000018BE38A18 
	
		// Nested types
		public enum LoopMode // TypeDefIndex: 57416
		{
			UseSourceAsset = 0,
			On = 1,
			Off = 2
		}
	
		public enum ClothResetOption // TypeDefIndex: 57417
		{
			SoftReset = 0,
			UseClothRelativeTeleport = 1,
			UseStablizationTime = 2,
			DisablePhysics = 3
		}
	
		public enum AnimationEventTriggerMode // TypeDefIndex: 57418
		{
			Default = 0,
			MuteAllEvents = 1,
			SeekAllEvents = 2
		}
	
		public enum ClipEndAudioBehaviour // TypeDefIndex: 57419
		{
			Default = 0,
			MuteAll = 1
		}
	
		private enum Versions // TypeDefIndex: 57420
		{
			Initial = 0,
			RotationAsEuler = 1
		}
	
		private static class AnimationPlayableAssetUpgrade // TypeDefIndex: 57421
		{
			// Methods
			public static void ConvertRotationToEuler(AnimationPlayableAsset asset) {} // 0x0000000185FBAAA0-0x0000000185FBAAC0
		}
	
		private sealed class _get_outputs_d__102 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 57422
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AnimationPlayableAsset __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get => default; } // 0x0000000185FBAA80-0x0000000185FBAAA0 
			object IEnumerator.Current { get => default; } // 0x0000000185FB0700-0x0000000185FB0710 
	
			// Constructors
			public _get_outputs_d__102() {} // Dummy constructor
			public _get_outputs_d__102(int __1__state) {} // 0x0000000185FBC570-0x0000000185FBC580
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BE39154-0x000000018BE39190
			private bool MoveNext() => default; // 0x000000018BE3929C-0x000000018BE392C4
			void IEnumerator.Reset() {} // 0x0000000185FBCE10-0x0000000185FBCE20
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator() => default; // 0x0000000185FAFE20-0x0000000185FAFE30
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185FB0790-0x0000000185FB07A0
		}
	
		// Constructors
		public AnimationPlayableAsset() {} // 0x0000000183F80CE0-0x0000000183F81080
		static AnimationPlayableAsset() {} // 0x0000000183F810A0-0x0000000183F810B0
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x000000018BE38A18-0x000000018BE38A3C
		internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop) => default; // 0x000000018BE38918-0x000000018BE38968
		internal static Playable CreatePlayable(PlayableGraph graph, AnimationPlayableAsset playableAsset) => default; // 0x000000018BE38968-0x000000018BE38A08
		internal static AnimationClipPlayable CreateAnimationClipPlayable(PlayableGraph graph, AnimationClip clip, bool removeStartOffset, bool applyFootIK, LoopMode loop) => default; // 0x000000018BE37D54-0x000000018BE37D74
		private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip) => default; // 0x0000000185492010-0x0000000185492020
		private static bool ShouldApplyEventControl(AnimationPlayableAsset playableAsset) => default; // 0x0000000183F7F120-0x0000000183F80440
		internal static Playable TryApplyAnimationEventControl(PlayableGraph graph, Playable root, AnimationPlayableAsset playableAsset) => default; // 0x000000018BE38DA0-0x000000018BE38DFC
		private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode) => default; // 0x000000018BE38D34-0x000000018BE38DA0
		public void ResetOffsets() {} // 0x000000018BE38E38-0x000000018BE38EEC
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x000000018BE38DFC-0x000000018BE38E38
		internal static bool HasRootTransforms(AnimationClip clip) => default; // 0x000000018BE37D18-0x000000018BE37D54
		public AnimationEvent[] CollectAnimationEvents() => default; // 0x0000000183F81410-0x0000000183F81430
		public void OnClipEnable(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public void OnClipDisable(Playable playable, FrameData info) {} // 0x0000000183F80C00-0x0000000183F80CE0
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000183F81080-0x0000000183F810A0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000183F810B0-0x0000000183F81100
		private void OnUpgradeFromVersion(int oldVersion) {} // 0x0000000183F81100-0x0000000183F81410
	}

	internal class AnimationPreviewUpdateCallback // TypeDefIndex: 57424
	{
		// Constructors
		public AnimationPreviewUpdateCallback() {} // Dummy constructor
	}

	public enum MatchTargetFields // TypeDefIndex: 57425
	{
		PositionX = 1,
		PositionY = 2,
		PositionZ = 4,
		RotationX = 8,
		RotationY = 16,
		RotationZ = 32
	}

	public enum TrackOffset // TypeDefIndex: 57426
	{
		ApplyTransformOffsets = 0,
		ApplySceneOffsets = 1,
		Auto = 2
	}

	internal enum AppliedOffsetMode // TypeDefIndex: 57427
	{
		NoRootTransform = 0,
		TransformOffset = 1,
		SceneOffset = 2,
		TransformOffsetLegacy = 3,
		SceneOffsetLegacy = 4,
		SceneOffsetEditor = 5,
		SceneOffsetLegacyEditor = 6
	}

	internal static class MatchTargetFieldConstants // TypeDefIndex: 57428
	{
		// Fields
		public static MatchTargetFields All; // 0x00
		public static MatchTargetFields None; // 0x04
		public static MatchTargetFields Position; // 0x08
		public static MatchTargetFields Rotation; // 0x0C
	
		// Constructors
		static MatchTargetFieldConstants() {} // 0x000000018BE41718-0x000000018BE41790
	}

	[Serializable]
	public class AnimationTrack : TrackAsset, ILayerable // TypeDefIndex: 57431
	{
		// Fields
		private const string k_DefaultInfiniteClipName = "Recorded"; // Metadata: 0x0207D90A
		private const string k_DefaultRecordableClipName = "Recorded"; // Metadata: 0x0207D913
		private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation; // 0xC0
		private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation; // 0xC4
		private Vector3 m_InfiniteClipOffsetPosition; // 0xC8
		private Vector3 m_InfiniteClipOffsetEulerAngles; // 0xD4
		private double m_InfiniteClipTimeOffset; // 0xE0
		private bool m_InfiniteClipRemoveOffset; // 0xE8
		private bool m_InfiniteClipApplyFootIK; // 0xE9
		private AnimationPlayableAsset.LoopMode mInfiniteClipLoop; // 0xEC
		private MatchTargetFields m_MatchTargetFields; // 0xF0
		private Vector3 m_Position; // 0xF4
		private Vector3 m_EulerAngles; // 0x100
		private AvatarMask m_AvatarMask; // 0x110
		private bool m_ApplyAvatarMask; // 0x118
		private bool m_DisableFloatCurveOnMask; // 0x119
		private TrackOffset m_TrackOffset; // 0x11C
		private AnimationClip m_InfiniteClip; // 0x120
		private bool m_IsAdditive; // 0x128
		private bool m_IsAdditiveToLast; // 0x129
		[NonSerialized]
		public bool muteScriptAnimAddon; // 0x12A
		private bool m_UseScriptAnimAddon; // 0x12B
		private bool m_useTPoseAsDefaultPose; // 0x12C
		private AnimationClip m_TPoseClip; // 0x130
		private ScriptableObject m_TimelineNPCDescriptor; // 0x138
		private string m_LookAtTargetPath; // 0x140
		private bool m_LookAtUseAdditive; // 0x148
		private bool m_WriteTransformDefAsPostProcess; // 0x149
		private Transform m_LookAtTarget; // 0x150
		[NonSerialized]
		private HashSet<RuntimeElement> m_allRuntimeClipUnderTrack; // 0x158
		private static readonly Queue<Transform> s_CachedQueue; // 0x00
		private Quaternion m_OpenClipOffsetRotation; // 0x160
		private Quaternion m_Rotation; // 0x170
		private bool m_ApplyOffsets; // 0x180
	
		// Properties
		public Vector3 position { get => default; set {} } // 0x000000018BE3D834-0x000000018BE3D890 0x0000000185FB8700-0x0000000185FB8710
		public Quaternion rotation { get => default; set {} } // 0x0000000186473590-0x00000001864735A4 0x0000000185FB67C0-0x0000000185FB67D0
		public Vector3 eulerAngles { get => default; set {} } // 0x0000000185FB67F0-0x0000000185FB6800 0x0000000185FB8600-0x0000000185FB8610
		public bool applyOffsets { get => default; set {} } // 0x00000001864735E0-0x00000001864735F4 0x0000000185FB9360-0x0000000185FB9370
		public TrackOffset trackOffset { get => default; set {} } // 0x0000000185FBB950-0x0000000185FBB960 0x0000000185FE6140-0x0000000185FE6150
		public MatchTargetFields matchTargetFields { get => default; set {} } // 0x0000000185FE61E0-0x0000000185FE61F0 0x0000000185FE61B0-0x0000000185FE61C0
		public AnimationClip infiniteClip { get => default; internal set {} } // 0x0000000185FE6270-0x0000000185FE6280 0x0000000185FB9470-0x0000000185FB9480
		internal bool infiniteClipRemoveOffset { get => default; set {} } // 0x0000000185FD5570-0x0000000185FD5580 0x000000018BE3CD20-0x000000018BE3CD7C
		public AvatarMask avatarMask { get => default; set {} } // 0x000000018BE3A63C-0x000000018BE3A6F0 0x000000018BE3D754-0x000000018BE3D7C4
		public bool applyAvatarMask { get => default; set {} } // 0x000000018BE3D6A4-0x000000018BE3D6EC 0x0000000185FE6190-0x0000000185FE61B0
		public bool disableFloatCurveOnMask { get => default; set {} } // 0x0000000185FE6240-0x0000000185FE6260 0x000000018BE3D6EC-0x000000018BE3D72C
		public bool isUsingScriptAnimAddon { get => default; set {} } // 0x000000018BE3D804-0x000000018BE3D834 0x0000000185FE6170-0x0000000185FE6190
		public bool lookAtUseAdditive { get => default; set {} } // 0x0000000185FE6220-0x0000000185FE6240 0x0000000185FBA440-0x0000000185FBA450
		public override IEnumerable<PlayableBinding> outputs { get => default; } // 0x0000000185FE6260-0x0000000185FE6270 
		public bool inClipMode { get => default; } // 0x0000000185FBE0C0-0x0000000185FBE0D0 
		public Vector3 infiniteClipOffsetPosition { get => default; set {} } // 0x0000000185FD2210-0x0000000185FD2220 0x0000000185FC9CD0-0x0000000185FC9CE0
		public Quaternion infiniteClipOffsetRotation { get => default; set {} } // 0x0000000185FC9D40-0x0000000185FC9D50 0x0000000185FB9650-0x0000000185FB9660
		public Vector3 infiniteClipOffsetEulerAngles { get => default; set {} } // 0x0000000185FB96B0-0x0000000185FB96C0 0x000000018BE3D184-0x000000018BE3D1B4
		internal bool infiniteClipApplyFootIK { get => default; set {} } // 0x000000018BE3AF20-0x000000018BE3AFB4 0x000000018BE3B02C-0x000000018BE3B118
		internal double infiniteClipTimeOffset { get => default; set {} } // 0x000000018BE3C1A4-0x000000018BE3C2B0 0x000000018BE3D028-0x000000018BE3D060
		public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation { get => default; set {} } // 0x000000018BE3A5C8-0x000000018BE3A63C 0x0000000185492010-0x0000000185492020
		public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation { get => default; set {} } // 0x000000018BE3D320-0x000000018BE3D48C 0x000000018BE3A6F0-0x000000018BE3AF20
		internal AnimationPlayableAsset.LoopMode infiniteClipLoop { get => default; set {} } // 0x000000018BE3D1B4-0x000000018BE3D238 0x000000018BE39824-0x000000018BE39CD4
		public Vector3 openClipOffsetPosition { get => default; set {} } // 0x000000018BE3D520-0x000000018BE3D6A4 0x000000018BE3D48C-0x000000018BE3D520
		public Quaternion openClipOffsetRotation { get => default; set {} } // 0x000000018BE3936C-0x000000018BE393D4 0x000000018BE39304-0x000000018BE3936C
		public Vector3 openClipOffsetEulerAngles { get => default; set {} } // 0x000000018BE392C4-0x000000018BE39304 0x0000000183F81410-0x0000000183F81430
		public TimelineClip.ClipExtrapolation openClipPreExtrapolation { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x000000018BE4C1DC-0x000000018BE4C25C
		public TimelineClip.ClipExtrapolation openClipPostExtrapolation { get => default; set {} } // 0x0000000183F81080-0x0000000183F810A0 0x000000018BE4C2F0-0x000000018BE4C33C
	
		// Nested types
		private static class AnimationTrackUpgrade // TypeDefIndex: 57429
		{
			// Methods
			public static void ConvertRotationsToEuler(AnimationTrack track) {} // 0x0000000185FE61C0-0x0000000185FE61E0
			public static void ConvertRootMotion(AnimationTrack track) {} // 0x0000000185FE6280-0x0000000185FE62A0
			public static void ConvertInfiniteTrack(AnimationTrack track) {} // 0x000000018BE3D7C4-0x000000018BE3D804
		}
	
		private sealed class _get_outputs_d__72 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 57430
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AnimationTrack __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
			object IEnumerator.Current { get => default; } // 0x0000000185FBC8D0-0x0000000185FBC8E0 
	
			// Constructors
			public _get_outputs_d__72() {} // Dummy constructor
			public _get_outputs_d__72(int __1__state) {} // 0x000000018BE3D8B0-0x000000018BE3D8E0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FE6150-0x0000000185FE6170
			private bool MoveNext() => default; // 0x0000000185FE61F0-0x0000000185FE6210
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator() => default; // 0x0000000185FBC8E0-0x0000000185FBC8F0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185FB23C0-0x0000000185FB23D0
		}
	
		// Constructors
		public AnimationTrack() {} // 0x000000018BE4C25C-0x000000018BE4C2E8
		static AnimationTrack() {} // 0x000000018BE4C2E8-0x000000018BE4C2F0
	
		// Methods
		public bool IsControlByThisTrack(RuntimeElement element) => default; // 0x0000000185FE6210-0x0000000185FE6220
		internal override bool CanCompileClips() => default; // 0x0000000185FCBEF0-0x0000000185FCBF00
		private void ResetOffsets() {} // 0x000000018BE3D238-0x000000018BE3D288
		public TimelineClip CreateClip(AnimationClip clip) => default; // 0x000000018BE3B480-0x000000018BE3C1A4
		public void CreateInfiniteClip(string infiniteClipName) {} // 0x0000000185492010-0x0000000185492020
		public TimelineClip CreateRecordableClip(string animClipName) => default; // 0x000000018BE3A03C-0x000000018BE3A490
		protected override void OnCreateClip(TimelineClip clip) {} // 0x0000000181B87DE0-0x0000000181B87DF0
		protected internal override int CalculateItemsHash() => default; // 0x0000000185492010-0x0000000185492020
		internal void UpdateClipOffsets() {} // 0x000000018BE3A490-0x000000018BE3A5C8
		private Playable _CreatePlayableFromClip(TimelineClip c, PlayableGraph graph, GameObject go, AppliedOffsetMode mode, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding) => default; // 0x000000018BE3D0A0-0x000000018BE3D184
		private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding) => default; // 0x000000018BE3D288-0x000000018BE3D298
		private bool ShouldLinkWithMainTrackMixer(AnimationTrack animationTrack) => default; // 0x000000018BE3CC40-0x000000018BE3CD20
		private Playable ApplyScriptAnimationPlayable(PlayableGraph graph, AnimationLayerMixerPlayable mixer, GameObject go) => default; // 0x000000018BE3C760-0x000000018BE3C8D8
		Playable ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x000000018BE3AFB4-0x000000018BE3B02C
		internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) => default; // 0x000000018BE3B118-0x000000018BE3B480
		private void AttachCustomBlend(PlayableGraph graph, AnimationLayerMixerPlayable layerMixer) {} // 0x000000018BE39CD4-0x000000018BE39E58
		private void AttachLastAdditiveClip(PlayableGraph graph, AnimationLayerMixerPlayable layerMixer, GameObject go, IntervalTree<RuntimeElement> tree, List<AnimationTrack> flattenTracks, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding) {} // 0x000000018BE3D298-0x000000018BE3D320
		private int GetDefaultBlendCount() => default; // 0x000000018BE3C8D8-0x000000018BE3C964
		private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset, Animator animator) {} // 0x000000018BE3CB70-0x000000018BE3CC40
		private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot) => default; // 0x000000018BE39E58-0x000000018BE3A03C
		private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject) => default; // 0x0000000185492010-0x0000000185492020
		private static bool UsesAbsoluteMotion(AppliedOffsetMode mode) => default; // 0x000000018BE3C470-0x000000018BE3C760
		private bool HasController(GameObject gameObject) => default; // 0x000000018BE3CB0C-0x000000018BE3CB70
		internal Animator GetBinding(PlayableDirector director) => default; // 0x000000018BE3CD7C-0x000000018BE3D028
		private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x000000018BE3C964-0x000000018BE3CB0C
		private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) => default; // 0x000000018BE393D4-0x000000018BE39824
		private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode) => default; // 0x000000018BE3C2B0-0x000000018BE3C470
		private void _AddClipIntoTree(IntervalTree<RuntimeElement> tree, RuntimeClip clip) {} // 0x0000000185FE6190-0x0000000185FE61B0
		internal override void GetEvaluationTime(out double outStart, out double outDuration) {
			outStart = default;
			outDuration = default;
		} // 0x0000000185FE6240-0x0000000185FE6260
		internal override void GetSequenceTime(out double outStart, out double outDuration) {
			outStart = default;
			outDuration = default;
		} // 0x000000018BE3D72C-0x000000018BE3D754
		private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip) {} // 0x000000018BE3D890-0x000000018BE3D8B0
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x0000000185FE6170-0x0000000185FE6190
		private void GetAnimationClips(List<AnimationClip> animClips) {} // 0x0000000185FE6220-0x0000000185FE6240
		private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform) => default; // 0x0000000185FBE0C0-0x0000000185FBE0D0
		private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode) => default; // 0x0000000185FD2210-0x0000000185FD2220
		private Transform GetGenericRootNode(GameObject gameObject) => default; // 0x0000000185FC9CD0-0x0000000185FC9CE0
		internal bool AnimatesRootTransform() => default; // 0x0000000185FC9D40-0x0000000185FC9D50
		private static Transform FindInHierarchyBreadthFirst(Transform t, string name) => default; // 0x000000018BE3D060-0x000000018BE3D0A0
		internal override void OnUpgradeFromVersion(int oldVersion) {} // 0x000000018BE4C33C-0x000000018BE4CE68
	}

	internal interface ICurvesOwner // TypeDefIndex: 57432
	{
		// Properties
		string defaultCurvesName { get; }
		UnityEngine.Object asset { get; }
		UnityEngine.Object assetOwner { get; }
		TrackAsset targetTrack { get; }
	}

	[Serializable]
	public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver // TypeDefIndex: 57437
	{
		// Fields
		private const int k_LatestVersion = 1; // Metadata: 0x0207D91C
		private int m_Version; // 0x10
		public static readonly ClipCaps kDefaultClipCaps; // 0x00
		public static readonly float kDefaultClipDurationInSeconds; // 0x04
		public static readonly double kTimeScaleMin; // 0x08
		public static readonly double kTimeScaleMax; // 0x10
		internal static readonly string kDefaultCurvesName; // 0x18
		internal static readonly double kMinDuration; // 0x20
		internal static readonly double kMaxTimeValue; // 0x28
		public int optionIndex; // 0x14
		private double m_Start; // 0x18
		private double m_ClipIn; // 0x20
		private UnityEngine.Object m_Asset; // 0x28
		private double m_Duration; // 0x30
		private double m_TimeScale; // 0x38
		private TrackAsset m_ParentTrack; // 0x40
		private double m_EaseInDuration; // 0x48
		private double m_EaseOutDuration; // 0x50
		private double m_BlendInDuration; // 0x58
		private double m_BlendOutDuration; // 0x60
		private AnimationCurve m_MixInCurve; // 0x68
		private AnimationCurve m_MixOutCurve; // 0x70
		private BlendCurveMode m_BlendInCurveMode; // 0x78
		private BlendCurveMode m_BlendOutCurveMode; // 0x7C
		private List<string> m_ExposedParameterNames; // 0x80
		private AnimationClip m_AnimationCurves; // 0x88
		private bool m_Recordable; // 0x90
		private ClipExtrapolation m_PostExtrapolationMode; // 0x94
		private ClipExtrapolation m_PreExtrapolationMode; // 0x98
		private double m_PostExtrapolationTime; // 0xA0
		private double m_PreExtrapolationTime; // 0xA8
		private string m_DisplayName; // 0xB0
	
		// Properties
		public double timeScale { get => default; } // 0x0000000181C44EA0-0x0000000181C44EB0 
		public double start { get => default; set {} } // 0x000000018BE455B8-0x000000018BE456A4 0x0000000181BD6170-0x0000000181BD61C0
		public double duration { get => default; set {} } // 0x000000018BE452E4-0x000000018BE45378 0x0000000185FE62D0-0x0000000185FE62E0
		public double end { get => default; } // 0x000000018BE44DEC-0x000000018BE44E10 
		public double clipIn { get => default; } // 0x000000018346D8F0-0x000000018346D900 
		public string displayName { get => default; set {} } // 0x0000000184784C70-0x0000000184784C90 0x000000018BE44D1C-0x000000018BE44D74
		public double clipAssetDuration { get => default; } // 0x0000000185FB0510-0x0000000185FB0520 
		public AnimationClip curves { get => default; } // 0x000000018BE44C4C-0x000000018BE44C9C 
		string ICurvesOwner.defaultCurvesName { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public UnityEngine.Object asset { get => default; set {} } // 0x0000000184A4EDC0-0x0000000184A4EDD0 0x00000001813FF010-0x00000001813FF020
		UnityEngine.Object ICurvesOwner.assetOwner { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		TrackAsset ICurvesOwner.targetTrack { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public double easeInDuration { get => default; set {} } // 0x000000018BE45378-0x000000018BE4545C 0x000000018BE44EA4-0x000000018BE44F38
		public double easeOutDuration { get => default; set {} } // 0x000000018BE4545C-0x000000018BE45540 0x000000018BE44CD4-0x000000018BE44CF8
		public double blendInDuration { get => default; } // 0x000000018BE44CF8-0x000000018BE44D1C 
		public double blendOutDuration { get => default; } // 0x000000018BE45014-0x000000018BE45044 
		public bool hasBlendIn { get => default; } // 0x000000018BE45044-0x000000018BE45074 
		public bool hasBlendOut { get => default; } // 0x000000018BE45074-0x000000018BE450DC 
		public AnimationCurve mixInCurve { get => default; set {} } // 0x0000000185A62990-0x0000000185A629A0 0x000000018BE450DC-0x000000018BE4510C
		public double mixInDuration { get => default; } // 0x000000018BE4510C-0x000000018BE45174 
		public AnimationCurve mixOutCurve { get => default; set {} } // 0x00000001874BE90C-0x00000001874BE91C 0x000000018BE451A4-0x000000018BE451D8
		public double mixOutTime { get => default; } // 0x000000018BE45174-0x000000018BE451A4 
		public double mixOutDuration { get => default; } // 0x0000000185FB2250-0x0000000185FB2260 
		public bool recordable { get => default; internal set {} } // 0x0000000185FB2260-0x0000000185FB2270 0x000000018BE44D74-0x000000018BE44DEC
		public ClipCaps clipCaps { get => default; } // 0x000000018BE44698-0x000000018BE44744 
		public ClipExtrapolation postExtrapolationMode { get => default; set {} } // 0x000000018BE45540-0x000000018BE4557C 0x000000018BE451FC-0x000000018BE45220
		public ClipExtrapolation preExtrapolationMode { get => default; set {} } // 0x000000018BE4557C-0x000000018BE455B8 0x0000000185FE62B0-0x0000000185FE62C0
		public double extrapolatedStart { get => default; } // 0x000000018BE44F38-0x000000018BE44FFC 
		public double extrapolatedDuration { get => default; } // 0x000000018BE44558-0x000000018BE44698 
	
		// Nested types
		private enum Versions // TypeDefIndex: 57433
		{
			Initial = 0,
			ClipInFromGlobalToLocal = 1
		}
	
		private static class TimelineClipUpgrade // TypeDefIndex: 57434
		{
			// Methods
			public static void UpgradeClipInFromGlobalToLocal(TimelineClip clip) {} // 0x000000018BE44C9C-0x000000018BE44CAC
		}
	
		public enum ClipExtrapolation // TypeDefIndex: 57435
		{
			None = 0,
			Hold = 1,
			Loop = 2,
			PingPong = 3,
			Continue = 4
		}
	
		public enum BlendCurveMode // TypeDefIndex: 57436
		{
			Auto = 0,
			Manual = 1
		}
	
		// Constructors
		public TimelineClip() {} // Dummy constructor
		internal TimelineClip(TrackAsset parent) {} // 0x000000018BE45220-0x000000018BE452E4
		static TimelineClip() {} // 0x000000018BE44184-0x000000018BE441C0
	
		// Methods
		private void UpgradeToLatestVersion() {} // 0x000000018BE44CAC-0x000000018BE44CD4
		public TrackAsset GetParentTrack() => default; // 0x000000018BE448DC-0x000000018BE449BC
		internal void SetParentTrack_Internal(TrackAsset newParentTrack) {} // 0x000000018BE44E10-0x000000018BE44EA4
		internal int Hash() => default; // 0x000000018BE44424-0x000000018BE44508
		public float EvaluateMixOut(double time) => default; // 0x000000018BE44360-0x000000018BE44424
		public float EvaluateMixOutAtGivenTime(double time, double mixOutTime, double mixOutDuration) => default; // 0x000000018BE44284-0x000000018BE44360
		public float EvaluateMixIn(double time) => default; // 0x000000018BE441C0-0x000000018BE44284
		public float EvaluateMixInAtGivenTime(double time, double runtimeMixInTime, double mixInDuration) => default; // 0x000000018BE44508-0x000000018BE44530
		private static AnimationCurve GetDefaultMixInCurve() => default; // 0x000000018BE44530-0x000000018BE44558
		private static AnimationCurve GetDefaultMixOutCurve() => default; // 0x000000018BE449BC-0x000000018BE44AD0
		public double ToLocalTime(double time) => default; // 0x000000018BE447E4-0x000000018BE448DC
		private static double SanitizeTimeValue(double value, double defaultValue) => default; // 0x000000018BE451D8-0x000000018BE451FC
		internal void SetPostExtrapolationTime(double time) {} // 0x0000000185FE62C0-0x0000000185FE62D0
		internal void SetPreExtrapolationTime(double time) {} // 0x000000018BE4479C-0x000000018BE447E4
		public bool IsPreExtrapolatedTime(double sequenceTime) => default; // 0x000000018BE44744-0x000000018BE4479C
		public bool IsPostExtrapolatedTime(double sequenceTime) => default; // 0x000000018BE44FFC-0x000000018BE45014
		private static double GetExtrapolatedTime(double time, ClipExtrapolation mode, double duration) => default; // 0x00000001830836C0-0x00000001830836D0
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018556CD60-0x000000018556CD80
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018BE44AD0-0x000000018BE44C4C
		public override string ToString() => default; // 0x0000000185492010-0x0000000185492020
		private void UpdateDirty(double oldValue, double newValue) {} // 0x0000000185EDD080-0x0000000185EDD180
	}

	[Serializable]
	public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview // TypeDefIndex: 57444
	{
		// Fields
		private const int k_LatestVersion = 0; // Metadata: 0x0207D926
		private int m_Version; // 0x18
		private List<ScriptableObject> m_Tracks; // 0x20
		private double m_FixedDuration; // 0x28
		[NonSerialized]
		private TrackAsset[] m_CacheOutputTracks; // 0x30
		[NonSerialized]
		private GroupTrack[] m_CacheGroupTracks; // 0x38
		[NonSerialized]
		private List<TrackAsset> m_CacheRootTracks; // 0x40
		[NonSerialized]
		private TrackAsset[] m_CacheFlattenedTracks; // 0x48
		private EditorSettings m_EditorSettings; // 0x50
		private DurationMode m_DurationMode; // 0x58
		private MarkerTrack m_MarkerTrack; // 0x60
	
		// Properties
		public EditorSettings editorSettings { get => default; } // 0x000000018BE430A8-0x000000018BE430C4 
		public override double duration { get => default; } // 0x000000018BE43048-0x000000018BE43064 
		public double fixedDuration { get => default; set {} } // 0x000000018BE4313C-0x000000018BE431DC 0x000000018BE43938-0x000000018BE43BC0
		public DurationMode durationMode { get => default; set {} } // 0x000000018BE436F0-0x000000018BE43938 0x000000018BE43ED4-0x000000018BE4402C
		public override IEnumerable<PlayableBinding> outputs { get => default; } // 0x000000018BE43040-0x000000018BE43048 
		public ClipCaps clipCaps { get => default; } // 0x0000000185FB0530-0x0000000185FB0540 
		public int outputTrackCount { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public int rootTrackCount { get => default; } // 0x000000018BE41C38-0x000000018BE41CA8 
		internal TrackAsset[] flattenedTracks { get => default; } // 0x000000018BE41F04-0x000000018BE42038 
		public MarkerTrack markerTrack { get => default; } // 0x000000018BE42414-0x000000018BE42730 
		internal List<ScriptableObject> trackObjects { get => default; }
	
		// Nested types
		private enum Versions // TypeDefIndex: 57438
		{
			Initial = 0
		}
	
		private static class TimelineAssetUpgrade // TypeDefIndex: 57439
		{
		}
	
		public enum MediaType // TypeDefIndex: 57440
		{
			Animation = 0,
			Audio = 1,
			Texture = 2,
			Video = 2,
			Script = 3,
			Hybrid = 4,
			Group = 5
		}
	
		public enum DurationMode // TypeDefIndex: 57441
		{
			BasedOnClips = 0,
			FixedLength = 1
		}
	
		[Serializable]
		public class EditorSettings // TypeDefIndex: 57442
		{
			// Fields
			internal static readonly double kMinFrameRate; // 0x00
			internal static readonly double kMaxFrameRate; // 0x08
			internal static readonly double kDefaultFrameRate; // 0x10
			private double m_Framerate; // 0x10
			private bool m_ScenePreview; // 0x18
	
			// Properties
			public double frameRate { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x0000000181460F60-0x0000000181460F70
	
			// Constructors
			public EditorSettings() {} // 0x000000018BE43DD4-0x000000018BE43E54
			static EditorSettings() {} // 0x000000018BE43E54-0x000000018BE43ED4
		}
	
		private sealed class _get_outputs_d__28 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 57443
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public TimelineAsset __4__this; // 0x40
			private IEnumerator<TrackAsset> __7__wrap1; // 0x48
			private IEnumerator<PlayableBinding> __7__wrap2; // 0x50
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get => default; } // 0x000000018BE4402C-0x000000018BE44054 
			object IEnumerator.Current { get => default; } // 0x000000018BE435A0-0x000000018BE435D4 
	
			// Constructors
			public _get_outputs_d__28() {} // Dummy constructor
			public _get_outputs_d__28(int __1__state) {} // 0x000000018BE4410C-0x000000018BE44164
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000183F80450-0x0000000183F80460
			private bool MoveNext() => default; // 0x0000000183F804E0-0x0000000183F804F0
			private void __m__Finally1() {} // 0x000000018BE44054-0x000000018BE440C4
			private void __m__Finally2() {} // 0x000000018BE43BC0-0x000000018BE43DD4
			void IEnumerator.Reset() {} // 0x000000018BE440C4-0x000000018BE4410C
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator() => default; // 0x000000018BE430C4-0x000000018BE43120
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BE43120-0x000000018BE4313C
		}
	
		// Constructors
		public TimelineAsset() {} // 0x000000018BE4BE88-0x000000018BE4BE90
	
		// Methods
		private void UpgradeToLatestVersion() {} // 0x000000018BE43064-0x000000018BE430A8
		private void OnValidate() {} // 0x000000018BE435D4-0x000000018BE43694
		public TrackAsset GetRootTrack(int index) => default; // 0x000000018BE4210C-0x000000018BE42414
		public IEnumerable<TrackAsset> GetRootTracks() => default; // 0x0000000185FE62A0-0x0000000185FE62B0
		public TrackAsset GetOutputTrack(int index) => default; // 0x000000018510A100-0x000000018510A110
		public IEnumerable<TrackAsset> GetOutputTracks() => default; // 0x0000000185325A90-0x0000000185325BB0
		public IEnumerable<GroupTrack> GetGroupTracks() => default; // 0x000000018BE42EDC-0x000000018BE43040
		private static double GetValidFrameRate(double frameRate) => default; // 0x000000018BE42038-0x000000018BE4210C
		private void UpdateRootTrackCache() {} // 0x000000018510A600-0x000000018510A640
		private void UpdateOutputTrackCache() {} // 0x000000018BE43694-0x000000018BE436F0
		public TrackAsset[] GetAllTracks() => default; // 0x000000018BE41A60-0x000000018BE41C38
		internal void AddTrackInternal(TrackAsset track) {}
		internal void RemoveTrack(TrackAsset track) {}
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x000000018BE42730-0x000000018BE428CC
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018BE42B50-0x000000018BE42EDC
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018BE431DC-0x000000018BE43398
		private void __internalAwake() {} // 0x000000018BE43398-0x000000018BE435A0
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x000000018BE41CA8-0x000000018BE41F04
		public void CreateMarkerTrack() {} // 0x000000018BE428CC-0x000000018BE429D0
		internal void Invalidate() {} // 0x000000018BE429D0-0x000000018BE42B50
		internal void UpdateFixedDurationWithItemsDuration() {} // 0x00000001850B4470-0x00000001850B44E0
		private DiscreteTime CalculateItemsDuration() => default; // 0x0000000185FC3350-0x0000000185FC3360
		private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset> allTracks) {} // 0x000000018BE416F8-0x000000018BE41718
		public TrackAsset CreateTrack(System.Type type, TrackAsset parent, string name) => default; // 0x00000001850B49C0-0x00000001850B4A30
		public T CreateTrack<T>(TrackAsset parent, string trackName)
			where T : TrackAsset, new() => default; // 0x0000000185F4AD40-0x0000000185F4ADF0
		public T CreateTrack<T>(string trackName)
			where T : TrackAsset, new() => default; // 0x0000000183F81410-0x0000000183F81430
		public T CreateTrack<T>()
			where T : TrackAsset, new() => default; // 0x000000018BE4BF2C-0x000000018BE4C018
		public bool DeleteClip(TimelineClip clip) => default; // 0x000000018BE4B978-0x000000018BE4BDFC
		public bool DeleteTrack(TrackAsset track) => default; // 0x000000018BE4C018-0x000000018BE4C060
		internal void MoveLastTrackBefore(TrackAsset asset) {} // 0x000000018BE4C060-0x000000018BE4C0AC
		public void MoveTrackAfter(TrackAsset trackToMove, TrackAsset targetTrack) {} // 0x0000000183F81080-0x0000000183F810A0
		private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, System.Type trackType) => default; // 0x000000018BE4BE90-0x000000018BE4BEDC
		private void DeleteRecordedAnimation(TrackAsset track) {} // 0x000000018BE4BEDC-0x000000018BE4BF2C
		private void DeleteRecordedAnimation(TimelineClip clip) {} // 0x000000018BE4BDFC-0x000000018BE4BE88
	}

	[Serializable]
	public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner, IDynamicBinding // TypeDefIndex: 57450
	{
		// Fields
		private const int k_LatestVersion = 3; // Metadata: 0x0207D931
		private int m_Version; // 0x18
		internal AnimationClip m_AnimClip; // 0x20
		public bool useAutoBinding; // 0x28
		public string autoBindingPath; // 0x30
		public string uniqueId; // 0x38
		public int uiBindingType; // 0x40
		private static TransientBuildData s_BuildData; // 0x00
		internal const string kDefaultCurvesName = "Track Parameters"; // Metadata: 0x0207D932
		private static Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate; // 0x18
		private static Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate; // 0x20
		private bool m_RuntimeMuted; // 0x44
		private bool m_Locked; // 0x45
		private bool m_Muted; // 0x46
		private string m_CustomPlayableFullTypename; // 0x48
		private AnimationClip m_Curves; // 0x50
		private PlayableAsset m_Parent; // 0x58
		private List<ScriptableObject> m_Children; // 0x60
		[NonSerialized]
		private int m_ItemsHash; // 0x68
		[NonSerialized]
		private TimelineClip[] m_ClipsCache; // 0x70
		private DiscreteTime m_Start; // 0x78
		private DiscreteTime m_End; // 0x80
		private bool m_CacheSorted; // 0x88
		private bool? m_SupportsNotifications; // 0x89
		private static TrackAsset[] s_EmptyCache; // 0x28
		private IEnumerable<TrackAsset> m_ChildTrackCache; // 0x90
		private static Dictionary<System.Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache; // 0x30
		protected internal List<TimelineClip> m_Clips; // 0x98
		private MarkerList m_Markers; // 0xA0
		public int OptionIndex; // 0xB8
		[NonSerialized]
		public bool useRuntimeMuted; // 0xBC
	
		// Properties
		public double start { get; } // 0x000000018BE4AF0C-0x000000018BE4AF48 
		public double end { get; } // 0x000000018BE4AE54-0x000000018BE4AE9C 
		public sealed override double duration { get; } // 0x000000018BE4AE9C-0x000000018BE4AF0C 
		public virtual bool muted { get; set; } // 0x000000018BE4AF48-0x000000018BE4B008 0x000000018BE4B1FC-0x000000018BE4B26C
		public virtual bool runtimeMuted { get; set; } // 0x000000018BE49550-0x000000018BE49570 0x00000001813ECF20-0x00000001813ECF30
		public bool mutedInHierarchy { get; } // 0x000000018571FEC0-0x000000018571FED0 
		public TimelineAsset timelineAsset { get; } // 0x0000000181460F60-0x0000000181460F70 
		public PlayableAsset parent { get; set; } // 0x0000000184A4E570-0x0000000184A4E580 0x000000018BE4A6B4-0x000000018BE4A6E0
		internal TimelineClip[] clips { get; } // 0x000000018BE4A6AC-0x000000018BE4A6B4 
		public virtual bool isEmpty { get; } // 0x0000000185779060-0x0000000185779070 
		public bool hasClips { get; } // 0x0000000185FB0530-0x0000000185FB0540 
		public bool hasCurves { get; } // 0x0000000185FB0D30-0x0000000185FB0D40 
		public bool isSubTrack { get; } // 0x00000001817D3160-0x00000001817D3170 
		public override IEnumerable<PlayableBinding> outputs { get; } // 0x000000018BE4B008-0x000000018BE4B0F4 
		internal string customPlayableTypename { get; set; } // 0x0000000185549660-0x0000000185549750 0x000000018BE475CC-0x000000018BE4766C
		public AnimationClip curves { get; internal set; } // 0x000000018BE48B88-0x000000018BE48BF8 0x000000018BE488CC-0x000000018BE4891C
		string ICurvesOwner.defaultCurvesName { get; } // 0x000000018BE4766C-0x000000018BE4788C 
		UnityEngine.Object ICurvesOwner.asset { get; }
		UnityEngine.Object ICurvesOwner.assetOwner { get; } // 0x000000018BE48BF8-0x000000018BE48D08 
		TrackAsset ICurvesOwner.targetTrack { get; } // 0x000000018BE479CC-0x000000018BE479F0 
		internal List<ScriptableObject> subTracksObjects { get; }
		public bool locked { get; set; } // 0x000000018BE48D48-0x000000018BE48D58 0x000000018510A390-0x000000018510A440
		public bool lockedInHierarchy { get; } // 0x000000018BE49570-0x000000018BE4976C 
		public bool supportsNotifications { get; } // 0x000000018BE49BD4-0x000000018BE49BE4 
	
		// Events
		internal static event Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate;
		internal static event Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate;
	
		// Nested types
		internal enum Versions // TypeDefIndex: 57445
		{
			Initial = 0,
			RotationAsEuler = 1,
			RootMotionUpgrade = 2,
			AnimatedTrackProperties = 3
		}
	
		private static class TrackAssetUpgrade // TypeDefIndex: 57446
		{
		}
	
		private struct TransientBuildData // TypeDefIndex: 57447
		{
			// Fields
			public List<TrackAsset> trackList; // 0x00
			public List<TimelineClip> clipList; // 0x08
			public List<IMarker> markerList; // 0x10
	
			// Methods
			public static TransientBuildData Create() => default; // 0x0000000185492010-0x0000000185492020
			public void Clear() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private sealed class _get_outputs_d__75 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 57448
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public TrackAsset __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get => default; } // 0x0000000185492010-0x0000000185492020 
			object IEnumerator.Current { get => default; } // 0x000000018BE4B344-0x000000018BE4B40C 
	
			// Constructors
			public _get_outputs_d__75() {} // Dummy constructor
			public _get_outputs_d__75(int __1__state) {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BE4A598-0x000000018BE4A6AC
			private bool MoveNext() => default; // 0x000000018510A110-0x000000018510A390
			void IEnumerator.Reset() {} // 0x000000018BE4AB40-0x000000018BE4AC08
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator() => default; // 0x000000018BE4AC08-0x000000018BE4ACD0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BE4B40C-0x000000018BE4B4D4
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 57449
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<TimelineClip> __9__132_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BE4B26C-0x000000018BE4B2BC
			public __c() {} // 0x000000018BE4AE00-0x000000018BE4AE54
	
			// Methods
			internal int _SortClips_b__132_0(TimelineClip clip1, TimelineClip clip2) => default; // 0x000000018BE4AD9C-0x000000018BE4AE00
		}
	
		// Constructors
		protected TrackAsset() {} // 0x0000000185492010-0x0000000185492020
		static TrackAsset() {} // 0x0000000183F80B90-0x0000000183F80C00
	
		// Methods
		protected virtual void OnBeforeTrackSerialize() {} // 0x000000018BE4B1E8-0x000000018BE4B1FC
		protected virtual void OnAfterTrackDeserialize() {} // 0x0000000185FBC810-0x0000000185FBC820
		internal virtual void OnUpgradeFromVersion(int oldVersion) {} // 0x0000000185FB08A0-0x0000000185FB08B0
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000185FB08B0-0x0000000185FB08C0
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018BE4B0F4-0x000000018BE4B1E8
		private void UpgradeToLatestVersion() {} // 0x000000018510A4E0-0x000000018510A600
		public IEnumerable<TimelineClip> GetClips() => default; // 0x0000000185779060-0x0000000185779070
		public IEnumerable<TrackAsset> GetChildTracks() => default; // 0x000000018BE4B2BC-0x000000018BE4B344
		private void __internalAwake() {} // 0x000000018BE49BE4-0x000000018BE49BF4
		public void CreateCurves(string curvesClipName) {} // 0x000000018BE474B0-0x000000018BE475CC
		public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x000000018BE46DFC-0x000000018BE46E30
		public sealed override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x000000018BE47298-0x000000018BE474B0
		public TimelineClip CreateDefaultClip() => default; // 0x000000018BE47054-0x000000018BE47298
		public TimelineClip CreateClip<T>()
			where T : ScriptableObject, IPlayableAsset => default; // 0x000000018BE46E30-0x000000018BE47054
		public bool DeleteClip(TimelineClip clip) => default; // 0x0000000185FB0520-0x0000000185FB0530
		public IMarker CreateMarker(System.Type type, double time) => default; // 0x000000018BE468D0-0x000000018BE468E0
		public T CreateMarker<T>(double time)
			where T : ScriptableObject, IMarker => default; // 0x000000018BE465CC-0x000000018BE465DC
		public bool DeleteMarker(IMarker marker) => default; // 0x000000018BE48D08-0x000000018BE48D48
		public IEnumerable<IMarker> GetMarkers() => default; // 0x000000018BE49D60-0x000000018BE49EA8
		public IEnumerable<IMarker> GetClipMarkers() => default; // 0x000000018BE46538-0x000000018BE465CC
		public int GetMarkerCount() => default; // 0x000000018BE482C8-0x000000018BE48620
		public IMarker GetMarker(int idx) => default; // 0x000000018BE48620-0x000000018BE488CC
		internal TimelineClip CreateClip(System.Type requestedType) => default; // 0x000000018BE46960-0x000000018BE46CC4
		internal TimelineClip CreateAndAddNewClipOfType(System.Type requestedType) => default; // 0x000000018BE48D58-0x000000018BE48F18
		internal TimelineClip CreateClipOfType(System.Type requestedType) => default; // 0x000000018BE48F18-0x000000018BE49114
		internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset) => default; // 0x000000018BE479F0-0x000000018BE4808C
		private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset) => default; // 0x000000018BE46CC4-0x000000018BE46DFC
		internal IEnumerable<ScriptableObject> GetMarkersRaw() => default; // 0x000000018BE4A458-0x000000018BE4A598
		internal void ClearMarkers() {} // 0x000000018BE46844-0x000000018BE468D0
		internal void AddMarker(ScriptableObject e) {} // 0x000000018BE468E0-0x000000018BE46960
		internal bool DeleteMarkerRaw(ScriptableObject marker) => default; // 0x0000000185FD2A50-0x0000000185FD2A60
		private int GetTimeRangeHash() => default; // 0x000000018BE4808C-0x000000018BE482C8
		internal void AddClip(TimelineClip newClip) {} // 0x000000018BE4649C-0x000000018BE46538
		private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable) => default; // 0x000000018BE4A1B8-0x000000018BE4A374
		internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable) => default; // 0x000000018BE4A3DC-0x000000018BE4A458
		internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) => default; // 0x000000018BE4A374-0x000000018BE4A3DC
		private void GatherCompilableTracks(IList<TrackAsset> tracks) {} // 0x000000018BE498BC-0x000000018BE49AC8
		private void GatherNotifications(List<IMarker> markers) {} // 0x000000018BE49D48-0x000000018BE49D60
		internal virtual Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) => default; // 0x000000018BE49114-0x000000018BE49490
		internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend) {} // 0x000000018BE49AC8-0x000000018BE49BD4
		internal void SortClips() {} // 0x000000018BE4A938-0x000000018BE4AB40
		internal void ClearClipsInternal() {} // 0x0000000185492010-0x0000000185492020
		internal void ClearSubTracksInternal() {} // 0x000000018BE4A86C-0x000000018BE4A938
		internal void OnClipMove() {} // 0x000000018BE465DC-0x000000018BE46674
		internal TimelineClip CreateNewClipContainerInternal() => default; // 0x000000018BE4891C-0x000000018BE48B88
		internal void AddChild(TrackAsset child) {} // 0x000000018510A440-0x000000018510A4E0
		internal void MoveLastTrackBefore(TrackAsset asset) {} // 0x000000018BE49BF4-0x000000018BE49D48
		internal bool RemoveSubTrack(TrackAsset child) => default; // 0x000000018BE46674-0x000000018BE466B0
		internal void RemoveClip(TimelineClip clip) {} // 0x000000018BE49EA8-0x000000018BE49EF0
		internal virtual void GetEvaluationTime(out double outStart, out double outDuration) {
			outStart = default;
			outDuration = default;
		} // 0x000000018BE46834-0x000000018BE46844
		internal virtual void GetSequenceTime(out double outStart, out double outDuration) {
			outStart = default;
			outDuration = default;
		} // 0x000000018BE49FB8-0x000000018BE4A1B8
		public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x000000018BE4A6E0-0x000000018BE4A86C
		internal GameObject GetGameObjectBinding(PlayableDirector director) => default; // 0x000000018BE49F74-0x000000018BE49FB8
		internal bool ValidateClipType(System.Type clipType) => default; // 0x000000018BE4976C-0x000000018BE498B4
		protected virtual void OnCreateClip(TimelineClip clip) {} // 0x000000018BE49490-0x000000018BE49550
		private void UpdateDuration() {} // 0x000000018BE49EF0-0x000000018BE49F74
		protected internal virtual int CalculateItemsHash() => default; // 0x000000018BE466B0-0x000000018BE466DC
		protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip) => default; // 0x000000018BE466DC-0x000000018BE46834
		internal void Invalidate() {} // 0x000000018BE4788C-0x000000018BE479CC
		internal double GetNotificationDuration() => default; // 0x00000001850B44E0-0x00000001850B45F0
		internal virtual bool CanCompileClips() => default; // 0x00000001850B4060-0x00000001850B4180
		public bool HasChildTracks() => default; // 0x00000001850B4180-0x00000001850B42B0
		public virtual bool CanCreateTrackMixer() => default; // 0x000000018BE4B4D4-0x000000018BE4B55C
		internal bool IsCompilable() => default; // 0x0000000183F81410-0x0000000183F81430
		private void UpdateChildTrackCache() {} // 0x0000000185492010-0x0000000185492020
		internal virtual int Hash() => default; // 0x0000000183F81430-0x0000000183F82560
		private int GetClipsHash() => default; // 0x0000000183F81080-0x0000000183F810A0
		protected static int GetAnimationClipHash(AnimationClip clip) => default; // 0x0000000183F82910-0x0000000183F82960
		private bool HasNotifications() => default; // 0x0000000183F82960-0x0000000183F833F0
		private bool CanCompileNotifications() => default; // 0x0000000183F82560-0x0000000183F82900
		private bool CanCreateMixerRecursive() => default; // 0x0000000183F82900-0x0000000183F82910
		public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x000000018BE4B764-0x000000018BE4B7C8
	}

	public class ForbidScriptDefaultValueWhenExportAttribute : Attribute // TypeDefIndex: 57451
	{
		// Constructors
		public ForbidScriptDefaultValueWhenExportAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class TimelineHelpURLAttribute : Attribute // TypeDefIndex: 57452
	{
		// Constructors
		public TimelineHelpURLAttribute() {} // Dummy constructor
	}

	public class TrackColorAttribute : Attribute // TypeDefIndex: 57453
	{
		// Fields
		private UnityEngine.Color m_Color; // 0x10
	
		// Constructors
		public TrackColorAttribute() {} // Dummy constructor
		public TrackColorAttribute(float r, float g, float b) {} // 0x00000001859EF100-0x00000001859EF140
	}

	public class UseScriptDefaultValueWhenExportAttribute : Attribute // TypeDefIndex: 57454
	{
		// Constructors
		public UseScriptDefaultValueWhenExportAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	internal class AudioClipProperties : PlayableBehaviour // TypeDefIndex: 57455
	{
		// Fields
		public float volume; // 0x10
	
		// Constructors
		public AudioClipProperties() {} // 0x0000000185FB10F0-0x0000000185FB1100
	}

	[Serializable]
	internal class AudioMixerProperties : PlayableBehaviour // TypeDefIndex: 57456
	{
		// Fields
		public float volume; // 0x10
		public float stereoPan; // 0x14
		public float spatialBlend; // 0x18
	
		// Constructors
		public AudioMixerProperties() {} // 0x0000000185FB10F0-0x0000000185FB1100
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x000000018BE3D8E0-0x000000018BE3DB70
	}

	[Serializable]
	public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 57458
	{
		// Fields
		private AudioClip m_Clip; // 0x18
		private bool m_Loop; // 0x20
		private float m_bufferingTime; // 0x24
		private AudioClipProperties m_ClipProperties; // 0x28
	
		// Properties
		internal float bufferingTime { get => default; set {} } // 0x000000018BE3DB70-0x000000018BE3DC8C 0x000000018BE3DCF4-0x000000018BE3DD04
		public AudioClip clip { get => default; set {} } // 0x000000018BE3DC8C-0x000000018BE3DCF4 0x0000000183F81410-0x0000000183F81430
		public bool loop { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x000000018BE4B7C8-0x000000018BE4B848
		public override double duration { get => default; } // 0x0000000183F81080-0x0000000183F810A0 
		public override IEnumerable<PlayableBinding> outputs { get => default; } // 0x000000018BE4B8DC-0x000000018BE4B928 
		public ClipCaps clipCaps { get => default; } // 0x000000018BE4B848-0x000000018BE4B8D4 
	
		// Nested types
		private sealed class _get_outputs_d__16 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 57457
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AudioPlayableAsset __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get => default; } // 0x0000000184088E70-0x0000000184088E80 
			object IEnumerator.Current { get => default; } // 0x00000001813EE9B0-0x00000001813EE9C0 
	
			// Constructors
			public _get_outputs_d__16() {} // Dummy constructor
			public _get_outputs_d__16(int __1__state) {} // 0x0000000185FB3810-0x0000000185FB3820
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FB3820-0x0000000185FB3830
			private bool MoveNext() => default; // 0x0000000181377E40-0x0000000181377E50
			void IEnumerator.Reset() {} // 0x00000001813ECBF0-0x00000001813ECC00
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator() => default; // 0x000000018BE3DD04-0x000000018BE3DDAC
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BE3DDAC-0x000000018BE3DE1C
		}
	
		// Constructors
		public AudioPlayableAsset() {} // 0x000000018BE4B8D4-0x000000018BE4B8DC
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x000000018BE4B928-0x000000018BE4B978
	}

	[Serializable]
	public class AudioTrack : TrackAsset // TypeDefIndex: 57460
	{
		// Fields
		private AudioMixerProperties m_TrackProperties; // 0xC0
	
		// Properties
		public override IEnumerable<PlayableBinding> outputs { get => default; } // 0x000000018BE4C18C-0x000000018BE4C1DC 
	
		// Nested types
		private sealed class _get_outputs_d__4 : IEnumerable<PlayableBinding>, IEnumerator<PlayableBinding> // TypeDefIndex: 57459
		{
			// Fields
			private int __1__state; // 0x10
			private PlayableBinding __2__current; // 0x18
			private int __l__initialThreadId; // 0x38
			public AudioTrack __4__this; // 0x40
	
			// Properties
			PlayableBinding IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get => default; } // 0x000000018BE3E464-0x000000018BE3E4D0 
			object IEnumerator.Current { get => default; } // 0x0000000183F81410-0x0000000183F81430 
	
			// Constructors
			public _get_outputs_d__4() {} // Dummy constructor
			public _get_outputs_d__4(int __1__state) {} // 0x000000018BE3E350-0x000000018BE3E464
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BE3DE1C-0x000000018BE3E350
			private bool MoveNext() => default; // 0x000000018BE3E550-0x000000018BE3E5C0
			void IEnumerator.Reset() {} // 0x000000018BE3E4D0-0x000000018BE3E550
			IEnumerator<PlayableBinding> IEnumerable<PlayableBinding>.GetEnumerator() => default; // 0x0000000185492010-0x0000000185492020
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BE4B7C8-0x000000018BE4B848
		}
	
		// Constructors
		public AudioTrack() {} // 0x000000018BE4C138-0x000000018BE4C140
	
		// Methods
		public TimelineClip CreateClip(AudioClip clip) => default; // 0x0000000183F81080-0x0000000183F810A0
		internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) => default; // 0x000000018BE4C140-0x000000018BE4C18C
		private void OnValidate() {} // 0x000000018BE4C0AC-0x000000018BE4C138
	}

	[Serializable]
	public struct ACConditionDescriptor // TypeDefIndex: 57461
	{
		// Fields
		private int m_ConditionMode; // 0x00
		private string m_ConditionEvent; // 0x08
		private float m_EventTreshold; // 0x10
	}

	public class ACTransitionDescriptor // TypeDefIndex: 57462
	{
		// Constructors
		public ACTransitionDescriptor() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum DialogTimelineTrackType // TypeDefIndex: 57463
	{
		Default = 0,
		Morph = 1,
		Animation = 2,
		Offset = 3,
		LookAt = 4
	}

	public static class BeyondCommunicator // TypeDefIndex: 57464
	{
		// Fields
		public static bool setAddonLayerAdditive; // 0x00
		private static Action<Animator, AnimationLayerMixerPlayable, AnimationTrack, ScriptableObject, Transform, CommunicatorParam> _ConnectToJobSync_k__BackingField; // 0x08
		private static Func<ITimelineRootMarker, GameObject, string, bool, bool> _TrySetTrackBindingEntityVisible_k__BackingField; // 0x10
	
		// Properties
		public static Action<Animator, AnimationLayerMixerPlayable, AnimationTrack, ScriptableObject, Transform, CommunicatorParam> ConnectToJobSync { get; set; } // 0x000000018BE3E5C0-0x000000018BE3E610 0x000000018BE3E610-0x000000018BE3E670
		public static Func<ITimelineRootMarker, GameObject, string, bool, bool> TrySetTrackBindingEntityVisible { get; set; } // 0x0000000183F80500-0x0000000183F80810 0x0000000183F80810-0x0000000183F80B90
	
		// Constructors
		static BeyondCommunicator() {} // 0x0000000185FA4FE0-0x0000000185FA5020
	}

	[Serializable]
	public class BlendMotionDescriptor // TypeDefIndex: 57465
	{
		// Fields
		public AnimationClip motion; // 0x10
		public string poseTimerParam; // 0x18
		public string blendParam; // 0x20
		public float threshold; // 0x28
	
		// Constructors
		public BlendMotionDescriptor() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class BlendTreeDescriptor // TypeDefIndex: 57467
	{
		// Fields
		public DescriptorBlendTreeType blendType; // 0x10
		public List<BlendMotionDescriptor> motionDescriptorList; // 0x18
		private string _speedParameter_k__BackingField; // 0x20
		private bool _speedParameterActive_k__BackingField; // 0x28
	
		// Nested types
		public enum DescriptorBlendTreeType // TypeDefIndex: 57466
		{
			Direct = 0,
			Simple1D = 1,
			Simple2D = 2,
			Complex2D = 3
		}
	
		// Constructors
		public BlendTreeDescriptor() {} // 0x0000000185492010-0x0000000185492020
	}

	public interface ITimelineRootMarker // TypeDefIndex: 57468
	{
		// Properties
		PlayableDirector topDirector { get; }
		GameObject rootGo { get; }
		bool useEarlyUpdate { get; }
		bool enableLoop { get; }
		bool isOptimizingHolding { get; }
		bool onlyEvaluateTopDirector { get; }
		float fixedFrameRate { get; }
		float manualTickDeltaTime { get; }
		bool isManualTicking { get; }
		Dictionary<PlayableDirector, ScriptPlayable<DirectorControlPlayable>> director2ControlPlayable { get; set; }
	
		// Methods
		void RegisterLoopSegmentRuntimeClip(string key, RuntimeClip runtimeClip);
		void UpdateAllVFXFollowBoneTools();
	}

	[Serializable]
	public class LayerDescriptor : ScriptableObject // TypeDefIndex: 57469
	{
		// Fields
		public string layerName; // 0x18
		public AvatarMask avatarMask; // 0x20
		public bool isAdditive; // 0x28
		public List<StateDescriptor> stateDescriptors; // 0x30
	
		// Constructors
		public LayerDescriptor() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	}

	[Serializable]
	public class MotionDescriptor // TypeDefIndex: 57470
	{
		// Fields
		public string stateName; // 0x10
		public AnimationClip motion; // 0x18
		public float speed; // 0x20
		public string speedParameter; // 0x28
		public bool speedParameterActive; // 0x30
		public string mirrorParameter; // 0x38
		public bool mirrorParameterActive; // 0x40
		public string timeParameter; // 0x48
		public bool timeParameterActive; // 0x50
	
		// Constructors
		public MotionDescriptor() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class StateDescriptor // TypeDefIndex: 57471
	{
		// Fields
		public string stateName; // 0x10
		public bool isDefaultState; // 0x18
		public string stateWeightParameter; // 0x20
		public bool stateWeightParameterActive; // 0x28
		public bool isBlendTree; // 0x29
		public MotionDescriptor motionDescriptor; // 0x30
		public BlendTreeDescriptor blendTreeDescriptor; // 0x38
	
		// Constructors
		public StateDescriptor() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum ClipCaps // TypeDefIndex: 57472
	{
		All = -1,
		None = 0,
		Looping = 1,
		Extrapolation = 2,
		ClipIn = 4,
		SpeedMultiplier = 8,
		Blending = 16,
		AutoScale = 40,
		ClipMarker = 64,
		DialogLoopSegment = 128,
		IgniteOnce = 256,
		OnlyDeltaTime = 1024,
		DialogJumpSegment = 2048,
		EvaluateTwiceWhenEnabled = 4096,
		DynamicLink = 8192,
		CustomBehaviourControl = 16384,
		ConditionBlend = 16385
	}

	internal static class TimelineClipCapsExtensions // TypeDefIndex: 57473
	{
		// Methods
		public static bool SupportsExtrapolation(TimelineClip clip) => default; // 0x000000018BE44164-0x000000018BE44184
		public static bool HasAny(ClipCaps caps, ClipCaps flags) => default; // 0x0000000187F33660-0x0000000187F33668
	}

	[Serializable]
	public class ControlPlayableAsset : BeyondUseAutoBindingPlayableAsset, IPropertyPreview, ITimelineClipAsset // TypeDefIndex: 57475
	{
		// Fields
		private const int k_MaxRandInt = 10000; // Metadata: 0x0207D970
		private static readonly List<PlayableDirector> k_EmptyDirectorsList; // 0x00
		private static readonly List<ParticleSystem> k_EmptyParticlesList; // 0x08
		private static readonly HashSet<ParticleSystem> s_SubEmitterCollector; // 0x10
		public ExposedReference<GameObject> sourceGameObject; // 0x30
		public GameObject prefabGameObject; // 0x40
		public bool updateParticle; // 0x48
		public uint particleRandomSeed; // 0x4C
		public bool forceRuntimeSimulate; // 0x50
		public bool updateDirector; // 0x51
		public bool updateITimeControl; // 0x52
		public bool searchHierarchy; // 0x53
		public bool active; // 0x54
		public ActivationControlPlayable.PostPlaybackState postPlayback; // 0x58
		private bool m_OnlyDeltaTime; // 0x5C
		private bool m_IgniteOnce; // 0x5D
		private PlayableAsset m_ControlDirectorAsset; // 0x60
		private double m_Duration; // 0x68
		private bool m_SupportLoop; // 0x70
		private static HashSet<PlayableDirector> s_ProcessedDirectors; // 0x18
		private static HashSet<GameObject> s_CreatedPrefabs; // 0x20
		private bool _controllingDirectors_k__BackingField; // 0x71
		private bool _controllingParticles_k__BackingField; // 0x72
	
		// Properties
		public override GameObject bindingGameObject { get => default; } // 0x0000000185FD1FA0-0x0000000185FD1FB0 
		protected virtual bool showBaseParam { get => default; } // 0x0000000185FD1FE0-0x0000000185FD1FF0 
		internal bool controllingDirectors { get; private set; } // 0x000000018BE3FBE0-0x000000018BE3FC0C 0x0000000185FB0CD0-0x0000000185FB0CE0
		public bool controllingParticles { get; protected set; } // 0x000000018BE4167C-0x000000018BE416AC 0x000000018BE3EAEC-0x000000018BE3F648
		public bool OnlyDeltaTime { get => default; set {} } // 0x000000018BE3E87C-0x000000018BE3E9D8 0x000000018BE3E9D8-0x000000018BE3EAEC
		public bool IgniteOnce { get => default; set {} } // 0x000000018BE40BE8-0x000000018BE40E50 0x000000018BE40954-0x000000018BE40BE8
		public override double duration { get => default; } // 0x000000018BE3E7BC-0x000000018BE3E87C 
		public virtual ClipCaps clipCaps { get => default; } // 0x000000018BE40600-0x000000018BE40754 
	
		// Nested types
		private sealed class _GetControlableScripts_d__53 : IEnumerable<MonoBehaviour>, IEnumerator<MonoBehaviour> // TypeDefIndex: 57474
		{
			// Fields
			private int __1__state; // 0x10
			private MonoBehaviour __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private GameObject root; // 0x28
			public GameObject __3__root; // 0x30
			private MonoBehaviour[] __7__wrap1; // 0x38
			private int __7__wrap2; // 0x40
	
			// Properties
			MonoBehaviour IEnumerator<UnityEngine.MonoBehaviour>.Current { get => default; } // 0x0000000185FB3070-0x0000000185FB3080 
			object IEnumerator.Current { get => default; } // 0x0000000185FBD4E0-0x0000000185FBD4F0 
	
			// Constructors
			public _GetControlableScripts_d__53() {} // Dummy constructor
			public _GetControlableScripts_d__53(int __1__state) {} // 0x000000018BE415EC-0x000000018BE4167C
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001840A27C0-0x00000001840A27D0
			private bool MoveNext() => default; // 0x0000000185FB3060-0x0000000185FB3070
			void IEnumerator.Reset() {} // 0x0000000185FBD4B0-0x0000000185FBD4C0
			IEnumerator<MonoBehaviour> IEnumerable<MonoBehaviour>.GetEnumerator() => default; // 0x0000000185FB0C10-0x0000000185FB0C20
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185FB0C30-0x0000000185FB0C40
		}
	
		// Constructors
		public ControlPlayableAsset() {} // 0x000000018BE4B67C-0x000000018BE4B710
		static ControlPlayableAsset() {} // 0x000000018BE4B710-0x000000018BE4B718
	
		// Methods
		public void OnEnable() {} // 0x000000018BE40754-0x000000018BE40954
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default;
		private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables) => default; // 0x000000018BE3F8D4-0x000000018BE3F944
		private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables) {} // 0x000000018BE40E50-0x000000018BE4134C
		protected virtual void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, float clipIn, float speedMultiplier, PlayableGraph graph, List<Playable> outplayables) {} // 0x000000018BE3F944-0x000000018BE3FA90
		private void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences) {} // 0x000000018BE3FA90-0x000000018BE3FBE0
		private static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables) {} // 0x000000018BE3E6E4-0x000000018BE3E7BC
		private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex) {} // 0x000000018BE3F648-0x000000018BE3F8D4
		protected virtual GameObject ResolveSourceGameObject(IExposedPropertyTable resolver) => default; // 0x000000018BE3FF30-0x000000018BE3FF8C
		internal IList<T> GetComponent<T>(GameObject gameObject) => default; // 0x000000018BE3FF8C-0x000000018BE40130
		internal static IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root) => default; // 0x000000018BE3FC0C-0x000000018BE3FD58
		internal void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems) {} // 0x000000018BE40130-0x000000018BE40600
		private IList<ParticleSystem> GetControllableParticleSystems(GameObject go) => default; // 0x000000018BE3FD58-0x000000018BE3FF30
		private static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters) {} // 0x000000018BE41580-0x000000018BE415EC
		private static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters) {} // 0x000000018BE4134C-0x000000018BE41580
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x0000000184775050-0x0000000184775070
		internal void PreviewParticlesWithControlPlayableAsset(IPropertyCollector driver, IEnumerable<ParticleSystem> particles) {} // 0x0000000185492010-0x0000000185492020
		internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles) {} // 0x000000018BE4B55C-0x000000018BE4B67C
		internal static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects) {} // 0x0000000181377E40-0x0000000181377E50
		internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts) {} // 0x000000018BE4B718-0x000000018BE4B764
		internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class ControlTrack : TrackAsset // TypeDefIndex: 57476
	{
		// Constructors
		public ControlTrack() {} // 0x000000018BE416AC-0x000000018BE416F8
	}

	public class AdditiveAnimApplyMono : MonoBehaviour // TypeDefIndex: 57478
	{
		// Fields
		private Dictionary<Transform, TransformAdditive> pendingAdditives; // 0x18
		private bool hasnewPendingUpdates; // 0x20
		private ITimelineRootMarker _parentTimelineRoot; // 0x28
	
		// Nested types
		public class TransformAdditive // TypeDefIndex: 57477
		{
			// Fields
			public Vector3 position; // 0x10
			public Vector3 rotationEuler; // 0x1C
			public Vector3 scale; // 0x28
	
			// Constructors
			public TransformAdditive() {} // 0x000000018BE371BC-0x000000018BE37234
	
			// Methods
			public void Reset() {} // 0x000000018BE37428-0x000000018BE37584
		}
	
		// Constructors
		public AdditiveAnimApplyMono() {} // 0x000000018BE5DE08-0x000000018BE5DE68
	
		// Methods
		private void Awake() {} // 0x000000018BE37388-0x000000018BE373B4
		public void RecordAdditiveTransform(Transform bone, Vector3 position, Vector3 rotationEuler, Vector3 scale) {} // 0x000000018BE36DF4-0x000000018BE371BC
		private void LateUpdate() {} // 0x000000018BE37234-0x000000018BE37388
		public void ApplyPendingTransforms() {} // 0x000000018BE373B4-0x000000018BE37428
		public void ClearPendingTransforms() {} // 0x000000018BE37584-0x000000018BE37604
		private void NotifyCutsceneRootToUpdateVFXTools() {} // 0x000000018BE37604-0x000000018BE37684
		public void RegisterRootComponent() {} // 0x000000018BE5DE68-0x000000018BE5DE70
	}

	public class AdditiveAnimMixer : PlayableBehaviour // TypeDefIndex: 57480
	{
		// Fields
		public AdditiveAnimTrack track; // 0x10
		private GameObject bindingGo; // 0x18
		private bool thisFrameAlreadyCalcualted; // 0x20
		private Dictionary<Transform, TransformAdditive> additiveCache; // 0x28
		private Dictionary<string, Transform> bonePaths; // 0x30
		private HashSet<string> notFoundBonePaths; // 0x38
		private AdditiveAnimApplyMono cachedApplyMono; // 0x40
	
		// Nested types
		private class TransformAdditive // TypeDefIndex: 57479
		{
			// Fields
			public Vector3 position; // 0x10
			public Vector3 rotationEular; // 0x1C
			public Vector3 scale; // 0x28
	
			// Constructors
			public TransformAdditive() {} // 0x000000018BE4D228-0x000000018BE4D5D8
	
			// Methods
			public void Reset() {} // 0x0000000185FBCC40-0x0000000185FBCC50
		}
	
		// Constructors
		public AdditiveAnimMixer() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x000000018BE4D5D8-0x000000018BE4DD24
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x000000018BE4DD24-0x000000018BE4E02C
		private void _AddToAdditiveCache(AdditiveAnimPlayable additiveAnimPlayable, float clipTime, float weight) {} // 0x000000018BE4E02C-0x000000018BE4E138
		private void _ApplyAdditive() {} // 0x000000018BE5DE08-0x000000018BE5DE68
	}

	public class AdditiveAnimPlayable : PlayableBehaviour // TypeDefIndex: 57481
	{
		// Fields
		public List<AdditiveAnimPlayableAsset.AnimationCurveInfo> extractedCurves; // 0x10
		private Dictionary<string, List<AdditiveAnimPlayableAsset.AnimationCurveInfo>> _curveCache; // 0x18
	
		// Constructors
		public AdditiveAnimPlayable() {} // 0x000000018BE4E6B4-0x000000018BE4E72C
	
		// Methods
		public override void OnPlayableCreate(Playable playable) {} // 0x000000018BE4E63C-0x000000018BE4E6B4
		public void InitializeCurveCache() {} // 0x000000018BE4E3AC-0x000000018BE4E63C
	}

	[Serializable]
	public class AdditiveAnimPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 57483
	{
		// Fields
		public AnimationClip additiveClip; // 0x18
		private ScriptPlayable<AdditiveAnimPlayable> additiveAnimPlayable; // 0x20
		public List<AnimationCurveInfo> extractedCurves; // 0x30
		private bool m_OnlyDeltaTime; // 0x38
		private bool m_IgniteOnce; // 0x39
		[NonSerialized]
		private AnimationClip _lastProcessedClip; // 0x40
	
		// Properties
		public bool OnlyDeltaTime { get => default; set {} } // 0x0000000185FAFE20-0x0000000185FAFE30 0x0000000185FB0710-0x0000000185FB0720
		public bool IgniteOnce { get => default; set {} } // 0x0000000185FB0720-0x0000000185FB0730 0x000000018BE4E138-0x000000018BE4E264
		public ClipCaps clipCaps { get => default; } // 0x000000018BE4E308-0x000000018BE4E388 
	
		// Nested types
		[Serializable]
		public class AnimationCurveInfo // TypeDefIndex: 57482
		{
			// Fields
			public string path; // 0x10
			public string propertyName; // 0x18
			public AnimationCurve curve; // 0x20
	
			// Constructors
			public AnimationCurveInfo() {} // 0x0000000185FB0700-0x0000000185FB0710
		}
	
		// Constructors
		public AdditiveAnimPlayableAsset() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x000000018BE4E264-0x000000018BE4E308
		private void _InitializeBehaviourCurveCache() {} // 0x000000018BE4E388-0x000000018BE4E3AC
	}

	public class AdditiveAnimTrack : TrackAsset // TypeDefIndex: 57484
	{
		// Fields
		private const string k_DefaultRecordableClipName = "Recorded Additive"; // Metadata: 0x0207D974
		private bool m_InfiniteClip; // 0xC0
		private AnimationClip m_RecordableClip; // 0xC8
	
		// Constructors
		public AdditiveAnimTrack() {} // 0x000000018BE4EA28-0x000000018BE4EA74
	
		// Methods
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) => default; // 0x000000018BE4E754-0x000000018BE4E850
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x000000018BE4E850-0x000000018BE4EA28
		public TimelineClip CreateRecordableClip(string animClipName) => default; // 0x000000018BE4E72C-0x000000018BE4E754
	}

	public class CombineToTopPlayableAttribute : Attribute // TypeDefIndex: 57485
	{
		// Constructors
		public CombineToTopPlayableAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CustomControlPlayableAsset : PlayableAsset, ITimelineClipAsset, ICustomControlBehaviour // TypeDefIndex: 57486
	{
		// Fields
		protected CustomControlPlayableBehaviour m_CustomControlBehaviour; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x000000018BE4EE3C-0x000000018BE4EE58 
		protected virtual ClipCaps extraClipCaps { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public CustomControlPlayableAsset() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x000000018BE4ED34-0x000000018BE4ED84
		public virtual void OnClipEnable(Playable playable, FrameData info) {} // 0x000000018BE4EDE0-0x000000018BE4EE3C
		public virtual void OnClipDisable(Playable playable, FrameData info) {} // 0x000000018BE4ED84-0x000000018BE4EDE0
	}

	public class CustomControlPlayableBehaviour : PlayableBehaviour, ICustomControlBehaviour // TypeDefIndex: 57487
	{
		// Constructors
		public CustomControlPlayableBehaviour() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual void OnClipEnable(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnClipDisable(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
	}

	public interface ICustomControlBehaviour // TypeDefIndex: 57488
	{
		// Methods
		void OnClipEnable(Playable playable, FrameData info);
		void OnClipDisable(Playable playable, FrameData info);
	}

	public interface IDynamicBinding // TypeDefIndex: 57489
	{
	}

	public interface ITimelineAnimationEventContextBinding // TypeDefIndex: 57490
	{
		// Methods
		void RegisterAnimationEventRuntimeContext(int playableId, AnimationEvent[] animationEvents, AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, float triggerThreshold, float curClipTime, float curWeight, AnimationPlayableAsset.ClipEndAudioBehaviour clipEndAudioBehaviour = AnimationPlayableAsset.ClipEndAudioBehaviour.Default /* Metadata: 0x0207D986 */);
		void UnregisterAnimationEventRuntimeContext(int playableId, AnimationEvent[] animationEvents);
		void UpdateClipInfo(int playableId, float curClipTime, float curClipWeight);
		void StopAllAudioForPlayable(int playableId, int fadeOutTimeMs = 100 /* Metadata: 0x0207D987 */);
	}

	public class SegmentLoopPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 57491
	{
		// Constructors
		public SegmentLoopPlayableBehaviour() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SegmentLoopPlayableClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 57492
	{
		// Fields
		public string loopSegmentKey; // 0x18
	
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x0000000185FB7DE0-0x0000000185FB7DF0 
	
		// Constructors
		public SegmentLoopPlayableClip() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x000000018BE54828-0x000000018BE548D4
	}

	public class SegmentLoopTrack : TrackAsset // TypeDefIndex: 57493
	{
		// Constructors
		public SegmentLoopTrack() {} // 0x000000018BE548D4-0x000000018BE54920
	}

	internal struct DiscreteTime : IComparable // TypeDefIndex: 57494
	{
		// Fields
		private const double k_Tick = 1E-12; // Metadata: 0x0207D989
		public static readonly DiscreteTime kMaxTime; // 0x00
		private readonly long m_DiscreteTime; // 0x00
	
		// Properties
		public static double tickValue { get => default; } // 0x0000000185FE6340-0x0000000185FE6350 
	
		// Constructors
		private DiscreteTime(long time) : this() {
			m_DiscreteTime = default;
		} // 0x0000000185FB2BB0-0x0000000185FB2BC0
		public DiscreteTime(double time) : this() {
			m_DiscreteTime = default;
		} // 0x000000018BE4FC78-0x000000018BE4FCD4
		public DiscreteTime(int time) : this() {
			m_DiscreteTime = default;
		} // 0x000000018BE4FC20-0x000000018BE4FC78
		static DiscreteTime() {
			kMaxTime = default;
		} // 0x000000018BE4FBE0-0x000000018BE4FC20
	
		// Methods
		public DiscreteTime OneTickBefore() => default; // 0x0000000185FE6310-0x0000000185FE6320
		public DiscreteTime OneTickAfter() => default; // 0x0000000185FE6300-0x0000000185FE6310
		public static DiscreteTime FromTicks(long ticks) => default; // 0x0000000185779060-0x0000000185779070
		public int CompareTo(object obj) => default; // 0x000000018BE4F958-0x000000018BE4F9C0
		public bool Equals(DiscreteTime other) => default; // 0x0000000183FAA6F0-0x0000000183FAA700
		public override bool Equals(object obj) => default; // 0x000000018BE4FA74-0x000000018BE4FAE0
		private static long DoubleToDiscreteTime(double time) => default; // 0x000000018BE4F9C0-0x000000018BE4FA74
		private static long IntToDiscreteTime(int time) => default; // 0x000000018BE4FB30-0x000000018BE4FB80
		private static double ToDouble(long time) => default; // 0x0000000185FE6320-0x0000000185FE6340
		public static explicit operator double(DiscreteTime b) => default; // 0x000000018BE4FCD4-0x000000018BE4FD24
		public static explicit operator DiscreteTime(double time) => default; // 0x000000018BE4FD24-0x000000018BE4FD4C
		public static implicit operator DiscreteTime(int time) => default; // 0x000000018BE4FD4C-0x000000018BE4FD74
		public static bool operator ==(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x000000018406FBE0-0x000000018406FBF0
		public static bool operator !=(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x000000018BE4FD74-0x000000018BE4FDC0
		public static bool operator <=(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x000000018B387334-0x000000018B38733C
		public static bool operator >=(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x0000000183FF1610-0x0000000183FF1620
		public static DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x0000000185FE6350-0x0000000185FE6360
		public override string ToString() => default; // 0x000000018BE4FBD8-0x000000018BE4FBE0
		public override int GetHashCode() => default; // 0x0000000185FD1580-0x0000000185FD1590
		public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs) => default; // 0x000000018BE4FB80-0x000000018BE4FBD8
		public static long GetNearestTick(double time) => default; // 0x000000018BE4FAE0-0x000000018BE4FB30
	}

	internal class InfiniteRuntimeClip : RuntimeElement // TypeDefIndex: 57495
	{
		// Fields
		private Playable m_Playable; // 0x18
		private static readonly long kIntervalEnd; // 0x00
		private int _optionIndex_k__BackingField; // 0x28
	
		// Properties
		public override long intervalStart { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public override long intervalEnd { get => default; } // 0x000000018BE508EC-0x000000018BE5093C 
		public override int optionIndex { get; set; } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
		public override bool enable { set {} } // 0x000000018BE5093C-0x000000018BE509A0
	
		// Constructors
		public InfiniteRuntimeClip() {} // Dummy constructor
		public InfiniteRuntimeClip(Playable playable) {} // 0x0000000185FB30E0-0x0000000185FB30F0
		static InfiniteRuntimeClip() {} // 0x000000018BE5085C-0x000000018BE508EC
	
		// Methods
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null) {} // 0x000000018BE50804-0x000000018BE5085C
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData) {} // 0x000000018BE507A4-0x000000018BE50804
	}

	internal interface IInterval // TypeDefIndex: 57496
	{
		// Properties
		long intervalStart { get; }
		long intervalEnd { get; }
	}

	internal interface IRuntimeReset // TypeDefIndex: 57497
	{
		// Methods
		void RuntimeReset();
	}

	internal interface IOption // TypeDefIndex: 57498
	{
	}

	internal struct IntervalTreeNode // TypeDefIndex: 57499
	{
		// Fields
		public long center; // 0x00
		public int first; // 0x08
		public int last; // 0x0C
		public int left; // 0x10
		public int right; // 0x14
	}

	internal class IntervalTree<T> // TypeDefIndex: 57501
		where T : IInterval, IRuntimeReset
	{
		// Fields
		private const int kMinNodeSize = 10; // Metadata: 0x0207D991
		private const int kInvalidNode = -1; // Metadata: 0x0207D992
		private const long kCenterUnknown = 9223372036854775807; // Metadata: 0x0207D993
		private readonly List<Entry> m_Entries;
		private readonly List<IntervalTreeNode> m_Nodes;
		private bool _dirty_k__BackingField;
	
		// Properties
		public bool dirty { get; internal set; }
	
		// Nested types
		internal struct Entry // TypeDefIndex: 57500
		{
			// Fields
			public long intervalStart;
			public long intervalEnd;
			public T item;
		}
	
		// Constructors
		public IntervalTree() {}
	
		// Methods
		public void Add(T item) {}
		public void IntersectsWith(long value, List<T> results) {}
		public void IntersectsWithRange(long start, long end, List<T> results) {}
		public void UpdateIntervals() {}
		public void RuntimeReset() {}
		private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results) {}
		private void QueryRange(IntervalTreeNode intervalTreeNode, long start, long end, List<T> results) {}
		public void Rebuild() {}
		private int Rebuild(int start, int end) => default;
	}

	public class RuntimeClip : RuntimeClipBase // TypeDefIndex: 57502
	{
		// Fields
		public double runtimeLocalTimeOffset; // 0x20
		public double runtimeMixOutTime; // 0x28
		public double runtimeMixOutDuration; // 0x30
		public double runtimeMixInTime; // 0x38
		public double runtimeMixInDuration; // 0x40
		public bool runtimeLooping; // 0x48
		public bool runtimeLoopingMute; // 0x49
		private bool _isInMixIn; // 0x4A
		private bool _isMixIn; // 0x4B
		private bool _hadIgniteOnce; // 0x4C
		private double lastTickTime; // 0x50
		private bool _onlyDeltaTimeLooped; // 0x58
		private int _optionIndex_k__BackingField; // 0x5C
		private int m_originalPort; // 0x60
		private bool _hadClipEnabled; // 0x64
		public bool isRuntimeJumpExhaust; // 0x65
		private TimelineClip m_Clip; // 0x68
		private Playable m_Playable; // 0x70
		private Playable m_ParentMixer; // 0x80
		private Playable m_RootPlayable; // 0x90
		private bool m_enabled; // 0xA0
	
		// Properties
		public override int optionIndex { get; set; } // 0x0000000183F80460-0x0000000183F80470 0x0000000183F804F0-0x0000000183F80500
		public bool dynamicLink { get => default; } // 0x000000018BE53EE4-0x000000018BE53F0C 
		public bool customBehaviourControl { get => default; } // 0x000000018BE53E90-0x000000018BE53EB8 
		public override double start { get => default; } // 0x000000018BE54038-0x000000018BE54064 
		public override double end { get => default; } // 0x000000018BE53F0C-0x000000018BE53F64 
		public override double duration { get => default; } // 0x000000018BE53EB8-0x000000018BE53EE4 
		public TimelineClip clip { get => default; } // 0x00000001813AC280-0x00000001813AC290 
		public Playable mixer { get => default; } // 0x0000000185FBC0B0-0x0000000185FBC0C0 
		public Playable playable { get => default; } // 0x0000000185FBB870-0x0000000185FBB880 
		public override long intervalStart { get => default; } // 0x000000018BE53FDC-0x000000018BE54038 
		public override long intervalEnd { get => default; } // 0x000000018BE53F64-0x000000018BE53FDC 
		public override bool enable { set {} } // 0x000000018BE54064-0x000000018BE542A0
		public bool isEnabling { get => default; } // 0x000000018346D900-0x000000018346D910 
	
		// Constructors
		public RuntimeClip() {} // Dummy constructor
		public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, int originalPort) {} // 0x000000018BE53E38-0x000000018BE53E90
	
		// Methods
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, int originalPort) {} // 0x000000018BE52F48-0x000000018BE5305C
		public void SetTime(double time) {} // 0x000000018BE53B90-0x000000018BE53BE8
		public void SetDuration(double duration) {} // 0x000000018BE53B38-0x000000018BE53B90
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null) {} // 0x000000018BE531FC-0x000000018BE5354C
		public float EvaluateMixIn(float localTime) => default; // 0x000000018BE5354C-0x000000018BE53608
		public float EvaluateMixOut(float localTime) => default; // 0x000000018BE53608-0x000000018BE53698
		public double ToLocalTime(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot) => default; // 0x000000018BE53BE8-0x000000018BE53D70
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData) {} // 0x000000018BE5305C-0x000000018BE531FC
		public override bool CheckIfRuntimeTimeLoop(out bool canSkip, out double reverseTime) {
			canSkip = default;
			reverseTime = default;
			return default;
		} // 0x000000018BE52EFC-0x000000018BE52F48
		public override bool CheckIfRuntimeTimeJump(out double jumpTime, out bool isReverseJump) {
			jumpTime = default;
			isReverseJump = default;
			return default;
		} // 0x000000018BE52DD0-0x000000018BE52EFC
		public override void RuntimeLoopOver() {} // 0x000000018BE538A8-0x000000018BE538D8
		public override void RuntimeLoopOn() {} // 0x000000018BE53878-0x000000018BE538A8
		public override void GetRuntimeCrossFadeDuration(out double duration, out double jumpTargetTime) {
			duration = default;
			jumpTargetTime = default;
		} // 0x000000018BE53698-0x000000018BE537BC
		public override void RecalculateRuntimeCrossFadeMixIn(double mixInTime, double mixInDuration) {} // 0x000000018BE537BC-0x000000018BE5380C
		public override void RecalculateRuntimeCrossFadeMixOut(double curTime, double mixStartTime, double mixDuration) {} // 0x000000018BE5380C-0x000000018BE53878
		public bool TryGetJumpClip(out RuntimeJumpClip jumpClip) {
			jumpClip = default;
			return default;
		} // 0x000000018BE53D70-0x000000018BE53E38
		public override void RuntimeReset() {} // 0x000000018BE538D8-0x000000018BE53B38
	}

	public abstract class RuntimeClipBase : RuntimeElement // TypeDefIndex: 57503
	{
		// Fields
		private int _optionIndex_k__BackingField; // 0x18
	
		// Properties
		public abstract double start { get; }
		public abstract double duration { get; }
		public abstract double end { get; }
		public override int optionIndex { get; set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public override long intervalStart { get; } // 0x000000018BE52D74-0x000000018BE52DD0 
		public override long intervalEnd { get; } // 0x000000018BE52CFC-0x000000018BE52D74 
	
		// Constructors
		protected RuntimeClipBase() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class RuntimeElement : IInterval, IOption, IRuntimeReset // TypeDefIndex: 57504
	{
		// Fields
		private int _intervalBit_k__BackingField; // 0x10
		private bool _isLooping_k__BackingField; // 0x14
	
		// Properties
		public abstract long intervalStart { get; }
		public abstract long intervalEnd { get; }
		public abstract int optionIndex { get; set; }
		public int intervalBit { get; set; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public bool isLooping { get; set; } // 0x0000000185FBA190-0x0000000185FBA1A0 0x0000000185FBA1B0-0x0000000185FBA1C0
		public abstract bool enable { get; set; }
	
		// Constructors
		protected RuntimeElement() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null);
		public abstract void DisableAt(double localTime, double rootDuration, FrameData frameData);
		public virtual bool CheckIfRuntimeTimeLoop(out bool canSkip, out double reverseTime) {
			canSkip = default;
			reverseTime = default;
			return default;
		} // 0x0000000185FE6470-0x0000000185FE6480
		public virtual bool CheckIfRuntimeTimeJump(out double jumpTime, out bool isReverseJump) {
			jumpTime = default;
			isReverseJump = default;
			return default;
		} // 0x0000000185FE6460-0x0000000185FE6470
		public virtual void RuntimeLoopOver() {} // 0x0000000185492010-0x0000000185492020
		public virtual void RuntimeLoopOn() {} // 0x0000000185492010-0x0000000185492020
		public virtual void GetRuntimeCrossFadeDuration(out double duration, out double jumpTargetTime) {
			duration = default;
			jumpTargetTime = default;
		} // 0x0000000185FE6480-0x0000000185FE6490
		public virtual void RecalculateRuntimeCrossFadeMixIn(double mixInTime, double mixDuration) {} // 0x0000000185492010-0x0000000185492020
		public virtual void RecalculateRuntimeCrossFadeMixOut(double curTime, double mixStartTime, double mixDuration) {} // 0x0000000185492010-0x0000000185492020
		public virtual void RuntimeReset() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ScheduleRuntimeClip : RuntimeClipBase // TypeDefIndex: 57505
	{
		// Fields
		private TimelineClip m_Clip; // 0x20
		private Playable m_Playable; // 0x28
		private Playable m_ParentMixer; // 0x38
		private double m_StartDelay; // 0x48
		private double m_FinishTail; // 0x50
		private bool m_Started; // 0x58
	
		// Properties
		public override double start { get => default; } // 0x000000018BE546B8-0x000000018BE54730 
		public override double duration { get => default; } // 0x000000018BE54634-0x000000018BE5467C 
		public override double end { get => default; } // 0x000000018BE5467C-0x000000018BE546B8 
		public TimelineClip clip { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public Playable mixer { get => default; } // 0x0000000185FBB850-0x0000000185FBB860 
		public Playable playable { get => default; } // 0x0000000185FBB610-0x0000000185FBB620 
		public override bool enable { set {} } // 0x000000018BE54730-0x000000018BE54828
	
		// Constructors
		public ScheduleRuntimeClip() {} // Dummy constructor
		public ScheduleRuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2 /* Metadata: 0x0207D99B */, double finishTail = 0.1 /* Metadata: 0x0207D9A3 */) {} // 0x000000018BE545E4-0x000000018BE54634
	
		// Methods
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail) {} // 0x000000018BE542A0-0x000000018BE54338
		public override void EvaluateAt(double localTime, FrameData frameData, ITimelineRootMarker timelineRoot = null) {} // 0x000000018BE54338-0x000000018BE545E4
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData) {} // 0x00000001879082B0-0x00000001879082C0
	}

	public interface IMarker // TypeDefIndex: 57506
	{
		// Properties
		double time { get; set; }
		TrackAsset parent { get; }
	
		// Methods
		void Initialize(TrackAsset parent);
	}

	public interface INotificationOptionProvider // TypeDefIndex: 57507
	{
		// Properties
		NotificationFlags flags { get; }
	}

	public abstract class Marker : ScriptableObject, IMarker // TypeDefIndex: 57508
	{
		// Fields
		private double m_Time; // 0x18
		private TrackAsset _parent_k__BackingField; // 0x20
	
		// Properties
		public TrackAsset parent { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public double time { get; set; } // 0x0000000181C44EA0-0x0000000181C44EB0 0x000000018BE5120C-0x000000018BE51264
	
		// Constructors
		protected Marker() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		void IMarker.Initialize(TrackAsset parentTrack) {} // 0x000000018BE510EC-0x000000018BE5120C
		public virtual void OnInitialize(TrackAsset aPent) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	internal struct MarkerList : ISerializationCallbackReceiver // TypeDefIndex: 57509
	{
		// Fields
		private List<ScriptableObject> m_Objects; // 0x00
		[NonSerialized]
		private List<IMarker> m_Cache; // 0x08
		private bool m_CacheDirty; // 0x10
		private bool m_HasNotifications; // 0x11
	
		// Properties
		public List<IMarker> markers { get => default; } // 0x00000001864733FC-0x0000000186473418 
		public int Count { get => default; } // 0x000000018BE50EA0-0x000000018BE50EE8 
		public IMarker this[int idx] { get => default; } // 0x000000018BE50EE8-0x000000018BE50F44 
	
		// Constructors
		public MarkerList(int capacity) : this() {
			m_Objects = default;
			m_Cache = default;
			m_CacheDirty = default;
			m_HasNotifications = default;
		} // 0x00000001850B4640-0x00000001850B4720
	
		// Methods
		public void Add(ScriptableObject item) {} // 0x000000018BE509A0-0x000000018BE50A24
		public bool Remove(IMarker item) => default; // 0x000000018BE50CEC-0x000000018BE50DF0
		public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty) => default; // 0x000000018BE50DF0-0x000000018BE50EA0
		public void Clear() {} // 0x000000018BE50A24-0x000000018BE50A70
		public IEnumerable<IMarker> GetMarkers() => default; // 0x00000001864733FC-0x0000000186473418
		public List<ScriptableObject> GetRawMarkerList() => default; // 0x00000001834AFB60-0x00000001834AFB70
		public IMarker CreateMarker(System.Type type, double time, TrackAsset owner) => default; // 0x000000018BE50A70-0x000000018BE50CD0
		public bool HasNotifications() => default; // 0x000000018BE50CD0-0x000000018BE50CEC
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000185492010-0x0000000185492020
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000181B9A230-0x0000000181B9A240
		private void BuildCache() {} // 0x00000001850B4720-0x00000001850B49C0
	}

	[Serializable]
	public class MarkerTrack : TrackAsset, INotificationTrack // TypeDefIndex: 57510
	{
		// Properties
		public override IEnumerable<PlayableBinding> outputs { get => default; } // 0x000000018BE50F90-0x000000018BE510EC 
	
		// Constructors
		public MarkerTrack() {} // 0x000000018BE50F44-0x000000018BE50F90
	}

	internal class CustomSignalEventDrawer : PropertyAttribute // TypeDefIndex: 57511
	{
		// Constructors
		public CustomSignalEventDrawer() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SignalAsset : ScriptableObject // TypeDefIndex: 57512
	{
		// Fields
		private static Action<SignalAsset> OnEnableCallback; // 0x00
	
		// Events
		internal static event Action<SignalAsset> OnEnableCallback;
	
		// Constructors
		public SignalAsset() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		private void OnEnable() {} // 0x000000018BE54920-0x000000018BE54970
	}

	[Serializable]
	public class SignalEmitter : Marker, INotification, INotificationOptionProvider // TypeDefIndex: 57513
	{
		// Fields
		private bool m_Retroactive; // 0x28
		private bool m_EmitOnce; // 0x29
		private SignalAsset m_Asset; // 0x30
	
		// Properties
		public bool retroactive { get => default; set {} } // 0x00000001813B31B0-0x00000001813B31C0 0x00000001813B4840-0x00000001813B4850
		public bool emitOnce { get => default; set {} } // 0x00000001813B34D0-0x00000001813B34E0 0x00000001813B4850-0x00000001813B4860
		public SignalAsset asset { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		PropertyName INotification.id { get => default; } // 0x000000018BE54AA8-0x000000018BE54B4C 
		NotificationFlags INotificationOptionProvider.flags { get => default; } // 0x000000018BE54B4C-0x000000018BE54B74 
	
		// Constructors
		public SignalEmitter() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	}

	public class SignalReceiver : MonoBehaviour, INotificationReceiver // TypeDefIndex: 57515
	{
		// Fields
		private EventKeyValue m_Events; // 0x18
	
		// Nested types
		[Serializable]
		private class EventKeyValue // TypeDefIndex: 57514
		{
			// Fields
			private List<SignalAsset> m_Signals; // 0x10
			private List<UnityEvent> m_Events; // 0x18
	
			// Properties
			public List<SignalAsset> signals { get => default; } // 0x000000018B40D310-0x000000018B40D32C 
			public List<UnityEvent> events { get => default; } // 0x000000018BE55174-0x000000018BE551AC 
	
			// Constructors
			public EventKeyValue() {} // 0x000000018BE55070-0x000000018BE550B8
	
			// Methods
			public bool TryGetValue(SignalAsset key, out UnityEvent value) {
				value = default;
				return default;
			} // 0x000000018BE55268-0x000000018BE55348
			public void Append(SignalAsset key, UnityEvent value) {} // 0x000000018BE54BE0-0x000000018BE54D3C
			public void Remove(int idx) {} // 0x000000018BE54B74-0x000000018BE54BE0
			public void Remove(SignalAsset key) {} // 0x000000018BE553F0-0x000000018BE554B8
		}
	
		// Constructors
		public SignalReceiver() {} // 0x000000018BE50010-0x000000018BE500D0
	
		// Methods
		public void OnNotify(Playable origin, INotification notification, object context) {} // 0x000000018BE54E08-0x000000018BE55070
		public void AddReaction(SignalAsset asset, UnityEvent reaction) {} // 0x000000018BE55348-0x000000018BE553F0
		public int AddEmptyReaction(UnityEvent reaction) => default; // 0x000000018BE54D3C-0x000000018BE54E08
		public void Remove(SignalAsset asset) {} // 0x000000018BE550B8-0x000000018BE55174
		public IEnumerable<SignalAsset> GetRegisteredSignals() => default; // 0x000000018BE551AC-0x000000018BE55268
		public UnityEvent GetReaction(SignalAsset key) => default; // 0x0000000185492010-0x0000000185492020
		public int Count() => default; // 0x000000018BE554B8-0x000000018BE55528
		public void ChangeSignalAtIndex(int idx, SignalAsset newKey) {} // 0x000000018BE4FF68-0x000000018BE50010
		public void RemoveAtIndex(int idx) {} // 0x000000018BE4FDC0-0x000000018BE4FE48
		public void ChangeReactionAtIndex(int idx, UnityEvent reaction) {} // 0x000000018BE4FEEC-0x000000018BE4FF68
		public UnityEvent GetReactionAtIndex(int idx) => default; // 0x000000018BE4FE48-0x000000018BE4FEEC
		public SignalAsset GetSignalAssetAtIndex(int idx) => default; // 0x000000018346D130-0x000000018346D140
		private void OnEnable() {} // 0x0000000181377E40-0x0000000181377E50
	}

	[Serializable]
	public class SignalTrack : MarkerTrack // TypeDefIndex: 57516
	{
		// Constructors
		public SignalTrack() {} // 0x000000018BE55528-0x000000018BE55530
	}

	public static class TrackAssetExtensions // TypeDefIndex: 57517
	{
	}

	[Serializable]
	public class GroupTrack : TrackAsset // TypeDefIndex: 57518
	{
		// Fields
		public TimelineConditionBase enableOnCondition; // 0xC0
	
		// Properties
		public override IEnumerable<PlayableBinding> outputs { get => default; } // 0x000000018BE506C8-0x000000018BE50718 
	
		// Constructors
		public GroupTrack() {} // 0x00000001850B4360-0x00000001850B43B0
	
		// Methods
		public void CalculateRuntimeMuted() {} // 0x000000018BE50640-0x000000018BE506C8
		internal override bool CanCompileClips() => default; // 0x00000001814A81B0-0x00000001814A81C0
	}

	public interface ILayerable // TypeDefIndex: 57519
	{
		// Methods
		Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount);
	}

	public interface ITimeDilationListener // TypeDefIndex: 57520
	{
		// Methods
		void OnTimeDilationChanged(float timeDilation);
	}

	public class ActivationControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 57523
	{
		// Fields
		public GameObject gameObject; // 0x10
		public PostPlaybackState postPlayback; // 0x18
		private InitialState m_InitialState; // 0x1C
	
		// Nested types
		public enum PostPlaybackState // TypeDefIndex: 57521
		{
			Active = 0,
			Inactive = 1,
			Revert = 2
		}
	
		private enum InitialState // TypeDefIndex: 57522
		{
			Unset = 0,
			Active = 1,
			Inactive = 2
		}
	
		// Constructors
		public ActivationControlPlayable() {} // 0x0000000185FB83D0-0x0000000185FB83E0
	
		// Methods
		public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, PostPlaybackState postPlaybackState) => default; // 0x000000018BE4CE68-0x000000018BE4CF9C
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x000000018BE4D028-0x000000018BE4D098
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x000000018BE4CF9C-0x000000018BE4D028
		public override void ProcessFrame(Playable playable, FrameData info, object userData) {} // 0x000000018BE4D1B8-0x000000018BE4D228
		public override void OnGraphStart(Playable playable) {} // 0x000000018BE4D098-0x000000018BE4D114
		public override void OnPlayableDestroy(Playable playable) {} // 0x000000018BE4D114-0x000000018BE4D1B8
		public override void RuntimeReset() {} // 0x0000000185492010-0x0000000185492020
	}

	public class AnimationEventRuntimeContextPlayable : PlayableBehaviour // TypeDefIndex: 57524
	{
		// Fields
		private ITimelineAnimationEventContextBinding m_TimelineAnimationEventContextBinding; // 0x10
		private AnimationPlayableAsset.AnimationEventTriggerMode m_TriggerMode; // 0x18
		private AnimationPlayableAsset.ClipEndAudioBehaviour m_ClipEndAudioBehaviour; // 0x1C
		private AnimationEvent[] m_CachedAnimationEvents; // 0x20
		private float m_ClipDuration; // 0x28
		private float m_TriggerThreshold; // 0x2C
		private bool m_IsRegistered; // 0x30
		private bool m_HasRegisteredOnce; // 0x31
	
		// Constructors
		public AnimationEventRuntimeContextPlayable() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static ScriptPlayable<AnimationEventRuntimeContextPlayable> Create(PlayableGraph graph, ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, AnimationEvent[] cachedAnimationEvents, float clipDuration = 0f /* Metadata: 0x0207D9B1 */, float weightThreshold = 0f /* Metadata: 0x0207D9B5 */, AnimationPlayableAsset.ClipEndAudioBehaviour clipEndAudioBehaviour = AnimationPlayableAsset.ClipEndAudioBehaviour.Default /* Metadata: 0x0207D9B9 */, int inputCount = 1 /* Metadata: 0x0207D9BA */) => default; // 0x0000000183F833F0-0x0000000183F84340
		public void Initialize(ITimelineAnimationEventContextBinding timelineAnimationEventContextBinding, AnimationPlayableAsset.AnimationEventTriggerMode triggerMode, AnimationEvent[] cachedAnimationEvents, float clipDuration, float weightThreshold = 0f /* Metadata: 0x0207D9BB */, AnimationPlayableAsset.ClipEndAudioBehaviour clipEndAudioBehaviour = AnimationPlayableAsset.ClipEndAudioBehaviour.Default /* Metadata: 0x0207D9BF */) {} // 0x0000000183F84340-0x0000000183F84420
		public void ResetRegistration(Playable playable) {} // 0x0000000183F84420-0x0000000183F864C0
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x000000018BE4EA74-0x000000018BE4EBD4
	}

	[Serializable]
	public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour // TypeDefIndex: 57525
	{
		// Properties
		public virtual double duration { get => default; } // 0x000000018BE4EC94-0x000000018BE4ECE4 
		public virtual IEnumerable<PlayableBinding> outputs { get => default; } // 0x000000018BE4ECE4-0x000000018BE4ED34 
	
		// Constructors
		public BasicPlayableBehaviour() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public virtual void OnGraphStart(Playable playable) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnGraphStop(Playable playable) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnPlayableCreate(Playable playable) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnPlayableDestroy(Playable playable) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public virtual void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000185492010-0x0000000185492020
		public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x000000018BE4EBD4-0x000000018BE4EC94
	}

	public class ControlPlayableBehaviour : PlayableBehaviour, IBehaviourRuntimeReset // TypeDefIndex: 57526
	{
		// Constructors
		public ControlPlayableBehaviour() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual void RuntimeReset() {} // 0x0000000185492010-0x0000000185492020
	}

	public class DirectorControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 57527
	{
		// Fields
		public PlayableDirector director; // 0x10
		public ITimelineRootMarker rootMarker; // 0x18
		private const float SYNC_START_FORBID_THRESHOLD = 0.016666668f; // Metadata: 0x0207D9C0
		private bool m_SyncTime; // 0x20
		private double m_AssetDuration; // 0x28
		private TimelinePlayable m_TimelinePlayable; // 0x30
	
		// Constructors
		public DirectorControlPlayable() {} // 0x0000000185FE62F0-0x0000000185FE6300
	
		// Methods
		public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director) => default; // 0x000000018BE4EE58-0x000000018BE4F0C0
		public override void OnPlayableDestroy(Playable playable) {} // 0x000000018BE4F230-0x000000018BE4F2CC
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x000000018BE4F2CC-0x000000018BE4F4F4
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x000000018BE4F178-0x000000018BE4F230
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x000000018BE4F0C0-0x000000018BE4F178
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x000000018BE4F4F4-0x000000018BE4F624
		private void SyncSpeed(double speed) {} // 0x000000018BE4F624-0x000000018BE4F770
		private void SyncStart(PlayableGraph graph, double time) {} // 0x000000018BE4F770-0x000000018BE4F894
		private void SyncStop(PlayableGraph graph, double time) {} // 0x000000018BE4F894-0x000000018BE4F958
		public override void RuntimeReset() {} // 0x0000000185492010-0x0000000185492020
	}

	public interface ITimeControl // TypeDefIndex: 57528
	{
		// Methods
		void SetTime(double time);
		void OnControlTimeStart();
		void OnControlTimeStop();
	}

	[Serializable]
	public enum NotificationFlags : short // TypeDefIndex: 57529
	{
		TriggerInEditMode = 1,
		Retroactive = 2,
		TriggerOnce = 4
	}

	public class ParticleControlPlayable : ControlPlayableBehaviour, ITimeDilationListener // TypeDefIndex: 57530
	{
		// Fields
		private float m_LastPlayableTime; // 0x10
		private float m_LastParticleTime; // 0x14
		private uint m_RandomSeed; // 0x18
		private bool m_forceRuntimeSimulate; // 0x1C
		private float m_clipIn; // 0x20
		private bool m_hadInitialized; // 0x24
		private float originalSimulateSpeed; // 0x28
		private float simulateSpeedModifier; // 0x2C
		private ParticleSystem _particleSystem_k__BackingField; // 0x30
		private bool m_hadIgnite; // 0x38
		private bool m_hadSimulate; // 0x39
		private bool m_hadPlayed; // 0x3A
	
		// Properties
		public ParticleSystem particleSystem { get; private set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		private bool shouldSimulate { get => default; } // 0x000000018BE521F4-0x000000018BE5221C 
	
		// Constructors
		public ParticleControlPlayable() {} // 0x0000000185FE6430-0x0000000185FE6460
	
		// Methods
		public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed, float clipIn, float speedMultiplier, bool forceRuntimeSimulate) => default; // 0x000000018BE51764-0x000000018BE518F8
		public void Initialize(ParticleSystem ps, uint randomSeed, float clipIn, float simulateSpeed, bool forceRuntimeSimulate) {} // 0x000000018BE518F8-0x000000018BE519B8
		private void SetOriginalSimulateSpeed(ParticleSystem particleSystem, double simulateSpeed) {} // 0x000000018BE51C74-0x000000018BE51DAC
		private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed) {} // 0x000000018BE51DAC-0x000000018BE51EA8
		public override void PrepareFrame(Playable playable, FrameData data) {} // 0x000000018BE51AD0-0x000000018BE51C74
		private void _SimulateParticle(float time, float particleTime, bool previewMode) {} // 0x000000018BE52180-0x000000018BE521F4
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000185FE6410-0x0000000185FE6420
		private void _PlayOrQueuedParticleSystem() {} // 0x000000018BE52068-0x000000018BE52180
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x000000018BE519B8-0x000000018BE51A74
		private void Simulate(float time, bool restart) {} // 0x000000018BE51EA8-0x000000018BE52068
		public override void RuntimeReset() {} // 0x0000000185FE6420-0x0000000185FE6430
		public void OnTimeDilationChanged(float timeScale) {} // 0x000000018BE51A74-0x000000018BE51AD0
	}

	public class PrefabControlPlayable : PlayableBehaviour // TypeDefIndex: 57531
	{
		// Fields
		private GameObject m_Instance; // 0x10
	
		// Properties
		public GameObject prefabInstance { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public PrefabControlPlayable() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform) => default; // 0x000000018BE525CC-0x000000018BE526FC
		public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform) => default; // 0x000000018BE526FC-0x000000018BE52950
		public override void OnPlayableDestroy(Playable playable) {} // 0x000000018BE52A4C-0x000000018BE52AD4
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x000000018BE529DC-0x000000018BE52A4C
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x000000018BE52950-0x000000018BE529DC
		private static void SetHideFlagsRecursive(GameObject gameObject) {} // 0x000000018BE52AD4-0x000000018BE52CFC
	}

	public class TimeControlPlayable : ControlPlayableBehaviour // TypeDefIndex: 57532
	{
		// Fields
		private ITimeControl m_timeControl; // 0x10
		private bool m_started; // 0x18
	
		// Constructors
		public TimeControlPlayable() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl) => default; // 0x000000018BE55530-0x000000018BE55620
		public void Initialize(ITimeControl timeControl) {} // 0x0000000184096E30-0x0000000184096EF0
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x000000018BE556C8-0x000000018BE55740
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x000000018BE55674-0x000000018BE556C8
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x000000018BE55620-0x000000018BE55674
		public override void RuntimeReset() {} // 0x0000000185492010-0x0000000185492020
	}

	public class TimeNotificationBehaviour : PlayableBehaviour // TypeDefIndex: 57535
	{
		// Fields
		private readonly List<NotificationEntry> m_Notifications; // 0x10
		private double m_PreviousTime; // 0x18
		private bool m_NeedSortNotifications; // 0x20
		private bool m_IsManualUpdate; // 0x21
		private Playable m_TimeSource; // 0x28
	
		// Properties
		public Playable timeSource { set {} } // 0x000000018BE55C7C-0x000000018BE56050
		public bool isManualUpdate { set {} } // 0x000000018BE56050-0x000000018BE56178
	
		// Nested types
		private struct NotificationEntry // TypeDefIndex: 57533
		{
			// Fields
			public double time; // 0x00
			public INotification payload; // 0x08
			public bool notificationFired; // 0x10
			public NotificationFlags flags; // 0x12
	
			// Properties
			public bool triggerInEditor { get => default; } // 0x0000000185FBB620-0x0000000185FBB630 
			public bool prewarm { get => default; } // 0x00000001813EE990-0x00000001813EE9A0 
			public bool triggerOnce { get => default; } // 0x000000018BE55824-0x000000018BE55934 
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 57534
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<NotificationEntry> __9__15_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BE55740-0x000000018BE557F4
			public __c() {} // 0x000000018BE55ADC-0x000000018BE55C7C
	
			// Methods
			internal int _SortNotifications_b__15_0(NotificationEntry x, NotificationEntry y) => default; // 0x000000018BE55934-0x000000018BE55ADC
		}
	
		// Constructors
		public TimeNotificationBehaviour() {} // 0x000000018BE5DEAC-0x000000018BE5DEC8
	
		// Methods
		public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode) => default; // 0x000000018BE557F4-0x000000018BE55824
		public void AddNotification(double time, INotification payload, NotificationFlags flags = NotificationFlags.Retroactive /* Metadata: 0x0207D9CA */) {} // 0x000000018BE56258-0x000000018BE56438
		public override void OnGraphStart(Playable playable) {} // 0x000000018BE56178-0x000000018BE56258
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x000000018BE56438-0x000000018BE564B4
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000185FB6A70-0x0000000185FB6A80
		private void SortNotifications() {} // 0x000000018BE564B4-0x000000018BE56578
		private static bool CanRestoreNotification(NotificationEntry e, FrameData info, double currentTime, double previousTime) => default; // 0x000000018BE56578-0x000000018BE565F0
		private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState) {} // 0x000000018BE5126C-0x000000018BE51274
		private void SyncDurationWithExternalSource(Playable playable) {} // 0x000000018BE51264-0x000000018BE5126C
		private static void Trigger_internal(Playable playable, PlayableOutput output, ref NotificationEntry e) {} // 0x000000018BE51274-0x000000018BE5127C
		private static void Restore_internal(ref NotificationEntry e) {} // 0x000000018BE5DF64-0x000000018BE5DFC8
		private static double _GetPlayableTime(Playable playable) => default; // 0x0000000185492010-0x0000000185492020
	}

	public class CommunicatorParam // TypeDefIndex: 57536
	{
		// Fields
		public IScriptAnimationJobSync jobSync; // 0x10
		public string uniqueId; // 0x18
		public bool lookAtUseAdditive; // 0x20
	
		// Constructors
		public CommunicatorParam() {} // 0x0000000185492010-0x0000000185492020
	}

	public interface IAutoGenMono // TypeDefIndex: 57537
	{
	}

	public interface IBehaviourRuntimeReset // TypeDefIndex: 57538
	{
	}

	public interface IScriptAnimationJobSync : IAutoGenMono // TypeDefIndex: 57539
	{
		// Methods
		void ProcessRootMotion(AnimationStream stream);
		void CalcLayerMainStream(float deltaTime);
		void ResetCloth(List<RuntimeElement> activeRuntimeElements, bool useSoftReset = true /* Metadata: 0x0207D9CC */, bool keepPose = false /* Metadata: 0x0207D9CD */, bool useRelativeTeleport = false /* Metadata: 0x0207D9CE */);
	}

	public struct TimelineScriptAnimationJob : IAnimationJob // TypeDefIndex: 57540
	{
		// Fields
		public IScriptAnimationJobSync bindedScriptAnimationJobSync; // 0x00
		public Animator bindedAnimator; // 0x08
	
		// Constructors
		public TimelineScriptAnimationJob(IScriptAnimationJobSync job, Animator animator) {
			bindedScriptAnimationJobSync = default;
			bindedAnimator = default;
		} // 0x000000018523F5B0-0x000000018523F5E0
	
		// Methods
		public void ProcessAnimation(AnimationStream stream) {} // 0x0000000185492010-0x0000000185492020
		public void ProcessRootMotion(AnimationStream stream) {} // 0x000000018BE5DD60-0x000000018BE5DDA8
	}

	[Serializable]
	public class PlayableTrack : TrackAsset // TypeDefIndex: 57541
	{
		// Constructors
		public PlayableTrack() {} // 0x000000018BE52580-0x000000018BE525CC
	
		// Methods
		protected override void OnCreateClip(TimelineClip clip) {} // 0x000000018BE524E8-0x000000018BE52580
	}

	public class TrackMediaType : Attribute // TypeDefIndex: 57542
	{
		// Constructors
		public TrackMediaType() {} // Dummy constructor
	}

	public class TrackClipTypeAttribute : Attribute // TypeDefIndex: 57543
	{
		// Fields
		public readonly System.Type inspectedType; // 0x10
		public readonly bool allowAutoCreate; // 0x18
	
		// Constructors
		public TrackClipTypeAttribute() {} // Dummy constructor
		public TrackClipTypeAttribute(System.Type clipClass) {} // 0x0000000185970F40-0x0000000185970F60
		public TrackClipTypeAttribute(System.Type clipClass, bool allowAutoCreate) {} // 0x0000000185FAF340-0x0000000185FAF350
	}

	public class NotKeyableAttribute : Attribute // TypeDefIndex: 57544
	{
		// Constructors
		public NotKeyableAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum TrackBindingFlags // TypeDefIndex: 57545
	{
		None = 0,
		AllowCreateComponent = 1,
		All = 1
	}

	public class TrackBindingTypeAttribute : Attribute // TypeDefIndex: 57546
	{
		// Fields
		public readonly System.Type type; // 0x10
		public readonly TrackBindingFlags flags; // 0x18
	
		// Constructors
		public TrackBindingTypeAttribute() {} // Dummy constructor
		public TrackBindingTypeAttribute(System.Type type) {} // 0x0000000185A54930-0x0000000185A54960
		public TrackBindingTypeAttribute(System.Type type, TrackBindingFlags flags) {} // 0x00000001845D7850-0x00000001845D7870
	}

	public class SupportsChildTracksAttribute : Attribute // TypeDefIndex: 57547
	{
		// Fields
		public readonly System.Type childType; // 0x10
		public readonly int levels; // 0x18
	
		// Constructors
		public SupportsChildTracksAttribute() {} // Dummy constructor
		public SupportsChildTracksAttribute(System.Type childType = null, int levels = 2147483647 /* Metadata: 0x0207D9D2 */) {} // 0x0000000185F0F810-0x0000000185F0F830
	}

	internal class IgnoreOnPlayableTrackAttribute : Attribute // TypeDefIndex: 57548
	{
		// Constructors
		public IgnoreOnPlayableTrackAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class TimeFieldAttribute : PropertyAttribute // TypeDefIndex: 57550
	{
		// Fields
		private readonly UseEditMode _useEditMode_k__BackingField; // 0x10
	
		// Nested types
		public enum UseEditMode // TypeDefIndex: 57549
		{
			None = 0,
			ApplyEditMode = 1
		}
	
		// Constructors
		public TimeFieldAttribute() {} // Dummy constructor
		public TimeFieldAttribute(UseEditMode useEditMode = UseEditMode.ApplyEditMode /* Metadata: 0x0207D9D3 */) {} // 0x0000000181378230-0x0000000181378240
	}

	internal class FrameRateFieldAttribute : PropertyAttribute // TypeDefIndex: 57551
	{
		// Constructors
		public FrameRateFieldAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HideInMenuAttribute : Attribute // TypeDefIndex: 57552
	{
		// Constructors
		public HideInMenuAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class CustomStyleAttribute : Attribute // TypeDefIndex: 57553
	{
		// Fields
		public readonly string ussStyle; // 0x10
	
		// Constructors
		public CustomStyleAttribute() {} // Dummy constructor
		public CustomStyleAttribute(string ussStyle) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	internal class MenuCategoryAttribute : Attribute // TypeDefIndex: 57554
	{
		// Constructors
		public MenuCategoryAttribute() {} // Dummy constructor
	}

	public interface ITimelineClipAsset // TypeDefIndex: 57555
	{
		// Properties
		ClipCaps clipCaps { get; }
	}

	internal interface ITimelineEvaluateCallback // TypeDefIndex: 57556
	{
		// Methods
		void Evaluate();
	}

	public class TimelinePlayable : PlayableBehaviour // TypeDefIndex: 57557
	{
		// Fields
		public double timeOffset; // 0x10
		public int newOptionIndex; // 0x18
		public int curOptionIndex; // 0x1C
		public int lastOptionIndex; // 0x20
		public bool checkTimeJumpForNextSeek; // 0x24
		private IntervalTree<RuntimeElement> m_IntervalTree; // 0x28
		private List<RuntimeElement> m_ActiveClips; // 0x30
		private HashSet<RuntimeElement> m_ActiveClipsSet; // 0x38
		private List<RuntimeElement> m_CurrentListOfActiveClips; // 0x40
		private List<RuntimeElement> m_ActiveClipsCalcCache; // 0x48
		private List<RuntimeElement> m_RuntimeResetClipCache; // 0x50
		private List<ITimeDilationListener> m_timeDialationListeners; // 0x58
		private int m_ActiveBit; // 0x60
		private bool m_needEvaluateTwice; // 0x64
		private bool m_isTimelineEnded; // 0x65
		private List<ITimelineEvaluateCallback> m_EvaluateCallbacks; // 0x68
		private Dictionary<TrackAsset, Playable> m_PlayableCache; // 0x70
		private PlayableDirector m_TopDirector; // 0x78
		private List<PlayableDirector> m_AllDirectorUnderRoot; // 0x80
		private PlayableDirector m_DirectorHoldingThisPlayable; // 0x88
		private ITimelineRootMarker m_RootMarker; // 0x90
		private List<IScriptAnimationJobSync> m_ScriptAnimationJobSyncs; // 0x98
		private HashSet<Playable> m_forbidPostProcessMixers; // 0xA0
		internal static bool muteAudioScrubbing; // 0x00
		private double m_timeForNextFrame; // 0xA8
	
		// Properties
		public double timeForNextFrame { get => default; } // 0x0000000185FE64A0-0x0000000185FE64B0 
		public ITimelineRootMarker timelineRootMarker { get => default; } // 0x0000000181B5FFD0-0x0000000181B5FFE0 
		public bool enableLoop { get => default; } // 0x000000018BE5B0A4-0x000000018BE5B118 
	
		// Constructors
		public TimelinePlayable() {} // 0x000000018BE5AD54-0x000000018BE5B0A4
		static TimelinePlayable() {} // 0x000000018BE5AD1C-0x000000018BE5AD54
	
		// Methods
		public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) => default; // 0x000000018BE58BCC-0x000000018BE58E1C
		public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) {} // 0x000000018BE578B4-0x000000018BE57E34
		public void MarkTimelineEnd() {} // 0x0000000185FE6490-0x0000000185FE64A0
		public bool IsTimelineEnded() => default; // 0x0000000185FBDF90-0x0000000185FBDFA0
		private void CompileCombineTopTopTrackList(PlayableGraph graph, Playable timelinePlayable, bool createOutputs) {} // 0x000000018BE57198-0x000000018BE57660
		private static void CollectCombineToTopTracksRecursive(TrackAsset track, List<TrackAsset> combineTracks) {} // 0x000000018BE56FCC-0x000000018BE57198
		private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs, bool isCompilingCombineToTopTracks) {} // 0x000000018BE57660-0x000000018BE578B4
		private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port) {} // 0x000000018BE57E34-0x000000018BE58794
		private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput, Animator animator) {} // 0x000000018BE59220-0x000000018BE592CC
		private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs) => default; // 0x000000018BE58794-0x000000018BE58BCC
		public void UpdateIntervalTree() {} // 0x000000018BE5A4B4-0x000000018BE5A4FC
		public void RuntimeResetIntervalTree() {} // 0x000000018BE5A278-0x000000018BE5A2C0
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x000000018BE59ED8-0x000000018BE5A224
		private void _ResetScriptAnimationJobySyncs() {} // 0x000000018BE5ABA0-0x000000018BE5AD1C
		private void _EvaluateTwice() {} // 0x000000018BE5A9D4-0x000000018BE5AA84
		public List<RuntimeElement> GetCurrentActiveClips() => default; // 0x00000001813FF010-0x00000001813FF020
		public List<RuntimeElement> GetActiveClipsAtGivenTime(double givenTime, List<RuntimeElement> activeClips = null) => default; // 0x000000018BE59DA4-0x000000018BE59E74
		public List<RuntimeElement> GetActiveClipsAtGivenTimeRange(double startTime, double endTime, List<RuntimeElement> activeClips = null) => default; // 0x000000018BE59CA8-0x000000018BE59DA4
		protected virtual void Evaluate(Playable playable, FrameData frameData) {} // 0x000000018BE592CC-0x000000018BE59CA8
		private bool DoReverseLoop(double reverseTime) => default; // 0x000000018BE58FB0-0x000000018BE59220
		private bool DoReverseJump(RuntimeClip runtimeClip, double jumpTime) => default; // 0x000000018BE58ED4-0x000000018BE58FB0
		private bool DoJump(RuntimeClip runtimeClip, double localTime, double jumpTime) => default; // 0x000000018BE58E1C-0x000000018BE58ED4
		private bool _CheckIfTimeJumping(FrameData frameData, double localTime) => default; // 0x000000018BE5A4FC-0x000000018BE5A9D4
		private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent) {} // 0x000000018BE56EF8-0x000000018BE56F68
		public void SetTimeForNextFrame(double newTime) {} // 0x0000000185FE62C0-0x0000000185FE62D0
		public void RegisterTimeDilationListener(ITimeDilationListener listener) {} // 0x000000018BE5A224-0x000000018BE5A278
		public void MarkMixerForbidPostProcess(Playable mixer) {} // 0x000000018BE59E74-0x000000018BE59ED8
		public bool CheckIfMixerForbidPostProcess(Playable mixer) => default; // 0x000000018BE56F68-0x000000018BE56FCC
		public void SetTimeScale(float usingTimeScale) {} // 0x000000018BE5A2C0-0x000000018BE5A4B4
		private void _NotifyTimeScaleChanged(float usingTimeScale) {} // 0x000000018BE5AA84-0x000000018BE5ABA0
	}

	public static class AnimationPreviewUtilities // TypeDefIndex: 57558
	{
	}

	internal static class Extrapolation // TypeDefIndex: 57560
	{
		// Fields
		internal static readonly double kMinExtrapolationTime; // 0x00
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 57559
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<TimelineClip> __9__2_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BE500D0-0x000000018BE50490
			public __c() {} // 0x000000018BE50490-0x000000018BE505D4
	
			// Methods
			internal int _SortClipsByStartTime_b__2_0(TimelineClip clip1, TimelineClip clip2) => default; // 0x000000018BE505D4-0x000000018BE50640
		}
	
		// Constructors
		static Extrapolation() {} // 0x000000018BE5DE70-0x000000018BE5DEAC
	
		// Methods
		internal static void CalculateExtrapolationTimes(TrackAsset asset) {} // 0x000000018BE5DFC8-0x000000018BE5E02C
		private static TimelineClip[] SortClipsByStartTime(TimelineClip[] clips) => default; // 0x0000000185492010-0x0000000185492020
	}

	internal static class HashUtility // TypeDefIndex: 57561
	{
		// Methods
		public static int CombineHash(int h1, int h2) => default; // 0x0000000185FE63F0-0x0000000185FE6410
		public static int CombineHash(int h1, int h2, int h3) => default; // 0x0000000185FE63B0-0x0000000185FE63F0
		public static int CombineHash(int h1, int h2, int h3, int h4) => default; // 0x0000000185FE6360-0x0000000185FE63B0
		public static int CombineHash(int h1, int h2, int h3, int h4, int h5) => default; // 0x000000018BE50718-0x000000018BE50750
		public static int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6) => default; // 0x000000018BE50750-0x000000018BE507A4
	}

	public interface IPropertyCollector // TypeDefIndex: 57562
	{
		// Methods
		void PushActiveGameObject(GameObject gameObject);
		void PopActiveGameObject();
		void AddFromClip(AnimationClip clip);
		void AddFromName<T>(string name)
			where T : Component;
		void AddFromName<T>(GameObject obj, string name)
			where T : Component;
		void AddFromName(GameObject obj, string name);
		void AddFromComponent(GameObject obj, Component component);
		void AddObjectProperties(UnityEngine.Object obj, AnimationClip clip);
	}

	public interface IPropertyPreview // TypeDefIndex: 57563
	{
		// Methods
		void GatherProperties(PlayableDirector director, IPropertyCollector driver);
	}

	internal static class NotificationUtilities // TypeDefIndex: 57564
	{
		// Methods
		public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, double duration, DirectorWrapMode extrapolationMode) => default; // 0x000000018BE5127C-0x000000018BE51644
		public static bool TrackTypeSupportsNotifications(System.Type type) => default; // 0x000000018BE51644-0x000000018BE51764
	}

	public static class PlayableDirectorUtility // TypeDefIndex: 57565
	{
		// Methods
		public static void SetOptionIndexSingleDirector(PlayableDirector director, int curOptionIndex, int lastOptionIndex) {} // 0x000000018BE524B8-0x000000018BE524E8
		public static TimelinePlayable GetTimelinePlayable(PlayableDirector director) => default; // 0x000000018BE5243C-0x000000018BE524B8
		public static TimelinePlayable GetTimelinePlayable(PlayableGraph graph) => default; // 0x000000018BE5238C-0x000000018BE5243C
		public static TimelinePlayable GetTimelinePlayableFromChildPlayable(Playable playable) => default; // 0x000000018BE522E0-0x000000018BE5238C
		public static bool CheckIfTimelineFunctional(Playable playable) => default; // 0x000000018BE5221C-0x000000018BE522E0
	}

	public static class TimelineClipExtensions // TypeDefIndex: 57566
	{
		// Fields
		private static readonly string k_UndoSetParentTrackText; // 0x00
	
		// Constructors
		static TimelineClipExtensions() {} // 0x000000018BE566C4-0x000000018BE56720
	}

	public static class TimelineCreateUtilities // TypeDefIndex: 57569
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 57567
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x000000018BE56960-0x000000018BE56C14
	
			// Methods
			internal bool _GenerateUniqueActorName_b__0(ScriptableObject x) => default; // 0x000000018BE56C14-0x000000018BE56CD4
		}
	
		private sealed class __c__DisplayClass0_1 // TypeDefIndex: 57568
		{
			// Fields
			public string result; // 0x10
	
			// Constructors
			public __c__DisplayClass0_1() {} // 0x000000018BE567BC-0x000000018BE56960
	
			// Methods
			internal bool _GenerateUniqueActorName_b__1(ScriptableObject x) => default; // 0x000000018BE56CD4-0x000000018BE56EF8
		}
	
		// Methods
		public static string GenerateUniqueActorName(List<ScriptableObject> tracks, string name) => default; // 0x0000000185492010-0x0000000185492020
		public static void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset) {} // 0x000000018BE5DEC8-0x000000018BE5DF00
		public static AnimationClip CreateAnimationClipForTrack(string name, TrackAsset track, bool isLegacy) => default; // 0x0000000185492010-0x0000000185492020
		public static bool ValidateParentTrack(TrackAsset parent, System.Type childType) => default; // 0x000000018BE5DEC8-0x000000018BE5DF00
	}

	public class TimelineRuntimeUtils // TypeDefIndex: 57570
	{
		// Constructors
		public TimelineRuntimeUtils() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static double GetTimelineDeltaTime(Playable playable, FrameData frameData) => default; // 0x000000018BE5D7B8-0x000000018BE5D830
		public static bool CheckWillRuntimeElementEnabled(RuntimeElement element, int curOptionIndex, int lastOptionIndex, long curDiscreteTime) => default; // 0x000000018BE5B118-0x000000018BE5B1BC
		public static void DoReverseJump(RuntimeClip jumpClip, ITimelineRootMarker timelineRoot, double curTime, double jumpTime, double mixDuration, int curOptionIndex, int lastOptionIndex, bool needChangeOptionAfterJump, int newOptionIndex) {} // 0x000000018BE5C1C0-0x000000018BE5D1BC
		public static void DoJump(RuntimeClip jumpClip, ITimelineRootMarker timelineRoot, double curTime, double jumpTime, double mixDuration, int curOptionIndex, int lastOptionIndex, bool needChangeOptionAfterJump, int optionIndexChangingTo) {} // 0x000000018BE5B1BC-0x000000018BE5C1C0
		public static double GetSubDirectorTimeForDirectorControl(Playable playable, PlayableDirector director) => default; // 0x000000018BE5D660-0x000000018BE5D7B8
		public static void SetNewTimeForCutsceneRoot(ITimelineRootMarker timelineRoot, double newTime, bool useThisTimeNextFrame = false /* Metadata: 0x0207D9D6 */) {} // 0x000000018BE5DAA0-0x000000018BE5DD60
		public static AnimationClip FindTPoseClipFromLayerDescriptors(List<LayerDescriptor> layerDescriptors) => default; // 0x000000018BE5D1BC-0x000000018BE5D660
		public static void LinkDefaultTPoseIfNeeded(AnimationLayerMixerPlayable mixer, List<LayerDescriptor> layerDescriptors, string gameObjectName, bool disableBaseTPoseClip = false /* Metadata: 0x0207D9D7 */) {} // 0x000000018BE5D9CC-0x000000018BE5DAA0
		public static void LinkDefaultTPoseClip(AnimationLayerMixerPlayable mixer, AnimationClip tposeClip, string gameObjectName) {} // 0x000000018BE5D830-0x000000018BE5D9CC
	}

	internal static class TimelineUndo // TypeDefIndex: 57571
	{
		// Methods
		public static void PushDestroyUndo(TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy) {} // 0x000000018BE5DDA8-0x000000018BE5DE08
	}

	public enum StandardFrameRates // TypeDefIndex: 57572
	{
		Fps24 = 0,
		Fps23_97 = 1,
		Fps25 = 2,
		Fps30 = 3,
		Fps29_97 = 4,
		Fps50 = 5,
		Fps60 = 6,
		Fps59_94 = 7
	}

	internal static class TimeUtility // TypeDefIndex: 57574
	{
		// Fields
		public static readonly double kTimeEpsilon; // 0x00
		public static readonly double kFrameRateEpsilon; // 0x08
		public static readonly double k_MaxTimelineDurationInSeconds; // 0x10
		public static readonly double kFrameRateRounding; // 0x18
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 57573
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018BE565F0-0x000000018BE566C4
			public __c() {} // 0x0000000185F53CC0-0x0000000185F53D60
		}
	
		// Constructors
		static TimeUtility() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static double GetAnimationClipLength(AnimationClip clip) => default; // 0x000000018BE5DF00-0x000000018BE5DF64
	}

	internal static class WeightUtility // TypeDefIndex: 57575
	{
		// Methods
		public static float NormalizeMixer(Playable mixer) => default; // 0x000000018BE5E02C-0x000000018BE5E2B0
	}
}

namespace UnityEngine.Timeline.Condition
{
	public class TimelineConditionControlMono : MonoBehaviour // TypeDefIndex: 57576
	{
		// Fields
		public TimelineConditionBase condition; // 0x18
	
		// Constructors
		public TimelineConditionControlMono() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void RefreshOnCondition() {} // 0x000000018BE56720-0x000000018BE567BC
	}
}
